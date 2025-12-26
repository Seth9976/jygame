using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Text;

namespace System.Net
{
	// Token: 0x020002D1 RID: 721
	internal class ChunkStream
	{
		// Token: 0x060018A0 RID: 6304 RVA: 0x00012332 File Offset: 0x00010532
		public ChunkStream(byte[] buffer, int offset, int size, WebHeaderCollection headers)
			: this(headers)
		{
			this.Write(buffer, offset, size);
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x00012345 File Offset: 0x00010545
		public ChunkStream(WebHeaderCollection headers)
		{
			this.headers = headers;
			this.saved = new StringBuilder();
			this.chunks = new ArrayList();
			this.chunkSize = -1;
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x00012371 File Offset: 0x00010571
		public void ResetBuffer()
		{
			this.chunkSize = -1;
			this.chunkRead = 0;
			this.chunks.Clear();
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x0001238C File Offset: 0x0001058C
		public void WriteAndReadBack(byte[] buffer, int offset, int size, ref int read)
		{
			if (offset + read > 0)
			{
				this.Write(buffer, offset, offset + read);
			}
			read = this.Read(buffer, offset, size);
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x000123B2 File Offset: 0x000105B2
		public int Read(byte[] buffer, int offset, int size)
		{
			return this.ReadFromChunks(buffer, offset, size);
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x0004B1A8 File Offset: 0x000493A8
		private int ReadFromChunks(byte[] buffer, int offset, int size)
		{
			int count = this.chunks.Count;
			int num = 0;
			for (int i = 0; i < count; i++)
			{
				ChunkStream.Chunk chunk = (ChunkStream.Chunk)this.chunks[i];
				if (chunk != null)
				{
					if (chunk.Offset == chunk.Bytes.Length)
					{
						this.chunks[i] = null;
					}
					else
					{
						num += chunk.Read(buffer, offset + num, size - num);
						if (num == size)
						{
							break;
						}
					}
				}
			}
			return num;
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x000123BD File Offset: 0x000105BD
		public void Write(byte[] buffer, int offset, int size)
		{
			this.InternalWrite(buffer, ref offset, size);
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x0004B234 File Offset: 0x00049434
		private void InternalWrite(byte[] buffer, ref int offset, int size)
		{
			if (this.state == ChunkStream.State.None)
			{
				this.state = this.GetChunkSize(buffer, ref offset, size);
				if (this.state == ChunkStream.State.None)
				{
					return;
				}
				this.saved.Length = 0;
				this.sawCR = false;
				this.gotit = false;
			}
			if (this.state == ChunkStream.State.Body && offset < size)
			{
				this.state = this.ReadBody(buffer, ref offset, size);
				if (this.state == ChunkStream.State.Body)
				{
					return;
				}
			}
			if (this.state == ChunkStream.State.BodyFinished && offset < size)
			{
				this.state = this.ReadCRLF(buffer, ref offset, size);
				if (this.state == ChunkStream.State.BodyFinished)
				{
					return;
				}
				this.sawCR = false;
			}
			if (this.state == ChunkStream.State.Trailer && offset < size)
			{
				this.state = this.ReadTrailer(buffer, ref offset, size);
				if (this.state == ChunkStream.State.Trailer)
				{
					return;
				}
				this.saved.Length = 0;
				this.sawCR = false;
				this.gotit = false;
			}
			if (offset < size)
			{
				this.InternalWrite(buffer, ref offset, size);
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x060018A8 RID: 6312 RVA: 0x000123C9 File Offset: 0x000105C9
		public bool WantMore
		{
			get
			{
				return this.chunkRead != this.chunkSize || this.chunkSize != 0 || this.state != ChunkStream.State.None;
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x060018A9 RID: 6313 RVA: 0x000123F6 File Offset: 0x000105F6
		public int ChunkLeft
		{
			get
			{
				return this.chunkSize - this.chunkRead;
			}
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x0004B344 File Offset: 0x00049544
		private ChunkStream.State ReadBody(byte[] buffer, ref int offset, int size)
		{
			if (this.chunkSize == 0)
			{
				return ChunkStream.State.BodyFinished;
			}
			int num = size - offset;
			if (num + this.chunkRead > this.chunkSize)
			{
				num = this.chunkSize - this.chunkRead;
			}
			byte[] array = new byte[num];
			Buffer.BlockCopy(buffer, offset, array, 0, num);
			this.chunks.Add(new ChunkStream.Chunk(array));
			offset += num;
			this.chunkRead += num;
			return (this.chunkRead != this.chunkSize) ? ChunkStream.State.Body : ChunkStream.State.BodyFinished;
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x0004B3D4 File Offset: 0x000495D4
		private ChunkStream.State GetChunkSize(byte[] buffer, ref int offset, int size)
		{
			char c = '\0';
			while (offset < size)
			{
				c = (char)buffer[offset++];
				if (c == '\r')
				{
					if (this.sawCR)
					{
						ChunkStream.ThrowProtocolViolation("2 CR found");
					}
					this.sawCR = true;
				}
				else
				{
					if (this.sawCR && c == '\n')
					{
						break;
					}
					if (c == ' ')
					{
						this.gotit = true;
					}
					if (!this.gotit)
					{
						this.saved.Append(c);
					}
					if (this.saved.Length > 20)
					{
						ChunkStream.ThrowProtocolViolation("chunk size too long.");
					}
				}
			}
			if (!this.sawCR || c != '\n')
			{
				if (offset < size)
				{
					ChunkStream.ThrowProtocolViolation("Missing \\n");
				}
				try
				{
					if (this.saved.Length > 0)
					{
						this.chunkSize = int.Parse(ChunkStream.RemoveChunkExtension(this.saved.ToString()), NumberStyles.HexNumber);
					}
				}
				catch (Exception)
				{
					ChunkStream.ThrowProtocolViolation("Cannot parse chunk size.");
				}
				return ChunkStream.State.None;
			}
			this.chunkRead = 0;
			try
			{
				this.chunkSize = int.Parse(ChunkStream.RemoveChunkExtension(this.saved.ToString()), NumberStyles.HexNumber);
			}
			catch (Exception)
			{
				ChunkStream.ThrowProtocolViolation("Cannot parse chunk size.");
			}
			if (this.chunkSize == 0)
			{
				this.trailerState = 2;
				return ChunkStream.State.Trailer;
			}
			return ChunkStream.State.Body;
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x0004B55C File Offset: 0x0004975C
		private static string RemoveChunkExtension(string input)
		{
			int num = input.IndexOf(';');
			if (num == -1)
			{
				return input;
			}
			return input.Substring(0, num);
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x0004B584 File Offset: 0x00049784
		private ChunkStream.State ReadCRLF(byte[] buffer, ref int offset, int size)
		{
			if (!this.sawCR)
			{
				if ((ushort)buffer[offset++] != 13)
				{
					ChunkStream.ThrowProtocolViolation("Expecting \\r");
				}
				this.sawCR = true;
				if (offset == size)
				{
					return ChunkStream.State.BodyFinished;
				}
			}
			if (this.sawCR && (ushort)buffer[offset++] != 10)
			{
				ChunkStream.ThrowProtocolViolation("Expecting \\n");
			}
			return ChunkStream.State.None;
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x0004B5F4 File Offset: 0x000497F4
		private ChunkStream.State ReadTrailer(byte[] buffer, ref int offset, int size)
		{
			if (this.trailerState == 2 && (ushort)buffer[offset] == 13 && this.saved.Length == 0)
			{
				offset++;
				if (offset < size && (ushort)buffer[offset] == 10)
				{
					offset++;
					return ChunkStream.State.None;
				}
				offset--;
			}
			int num = this.trailerState;
			string text = "\r\n\r";
			while (offset < size && num < 4)
			{
				char c = (char)buffer[offset++];
				if ((num == 0 || num == 2) && c == '\r')
				{
					num++;
				}
				else if ((num == 1 || num == 3) && c == '\n')
				{
					num++;
				}
				else if (num > 0)
				{
					this.saved.Append(text.Substring(0, (this.saved.Length != 0) ? num : (num - 2)));
					num = 0;
					if (this.saved.Length > 4196)
					{
						ChunkStream.ThrowProtocolViolation("Error reading trailer (too long).");
					}
				}
			}
			if (num < 4)
			{
				this.trailerState = num;
				if (offset < size)
				{
					ChunkStream.ThrowProtocolViolation("Error reading trailer.");
				}
				return ChunkStream.State.Trailer;
			}
			StringReader stringReader = new StringReader(this.saved.ToString());
			string text2;
			while ((text2 = stringReader.ReadLine()) != null && text2 != string.Empty)
			{
				this.headers.Add(text2);
			}
			return ChunkStream.State.None;
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x0004B77C File Offset: 0x0004997C
		private static void ThrowProtocolViolation(string message)
		{
			WebException ex = new WebException(message, null, WebExceptionStatus.ServerProtocolViolation, null);
			throw ex;
		}

		// Token: 0x04000FB9 RID: 4025
		internal WebHeaderCollection headers;

		// Token: 0x04000FBA RID: 4026
		private int chunkSize;

		// Token: 0x04000FBB RID: 4027
		private int chunkRead;

		// Token: 0x04000FBC RID: 4028
		private ChunkStream.State state;

		// Token: 0x04000FBD RID: 4029
		private StringBuilder saved;

		// Token: 0x04000FBE RID: 4030
		private bool sawCR;

		// Token: 0x04000FBF RID: 4031
		private bool gotit;

		// Token: 0x04000FC0 RID: 4032
		private int trailerState;

		// Token: 0x04000FC1 RID: 4033
		private ArrayList chunks;

		// Token: 0x020002D2 RID: 722
		private enum State
		{
			// Token: 0x04000FC3 RID: 4035
			None,
			// Token: 0x04000FC4 RID: 4036
			Body,
			// Token: 0x04000FC5 RID: 4037
			BodyFinished,
			// Token: 0x04000FC6 RID: 4038
			Trailer
		}

		// Token: 0x020002D3 RID: 723
		private class Chunk
		{
			// Token: 0x060018B0 RID: 6320 RVA: 0x00012405 File Offset: 0x00010605
			public Chunk(byte[] chunk)
			{
				this.Bytes = chunk;
			}

			// Token: 0x060018B1 RID: 6321 RVA: 0x0004B798 File Offset: 0x00049998
			public int Read(byte[] buffer, int offset, int size)
			{
				int num = ((size <= this.Bytes.Length - this.Offset) ? size : (this.Bytes.Length - this.Offset));
				Buffer.BlockCopy(this.Bytes, this.Offset, buffer, offset, num);
				this.Offset += num;
				return num;
			}

			// Token: 0x04000FC7 RID: 4039
			public byte[] Bytes;

			// Token: 0x04000FC8 RID: 4040
			public int Offset;
		}
	}
}
