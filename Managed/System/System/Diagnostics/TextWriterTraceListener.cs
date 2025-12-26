using System;
using System.IO;

namespace System.Diagnostics
{
	/// <summary>Directs tracing or debugging output to a <see cref="T:System.IO.TextWriter" /> or to a <see cref="T:System.IO.Stream" />, such as <see cref="T:System.IO.FileStream" />.</summary>
	/// <filterpriority>1</filterpriority>
	// Token: 0x0200025B RID: 603
	public class TextWriterTraceListener : TraceListener
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.TextWriterTraceListener" /> class with <see cref="T:System.IO.TextWriter" /> as the output recipient.</summary>
		// Token: 0x06001514 RID: 5396 RVA: 0x00010456 File Offset: 0x0000E656
		public TextWriterTraceListener()
			: base("TextWriter")
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.TextWriterTraceListener" /> class, using the stream as the recipient of the debugging and tracing output.</summary>
		/// <param name="stream">A <see cref="T:System.IO.Stream" /> that represents the stream the <see cref="T:System.Diagnostics.TextWriterTraceListener" /> writes to. </param>
		/// <exception cref="T:System.ArgumentNullException">The stream is null. </exception>
		// Token: 0x06001515 RID: 5397 RVA: 0x00010463 File Offset: 0x0000E663
		public TextWriterTraceListener(Stream stream)
			: this(stream, string.Empty)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.TextWriterTraceListener" /> class, using the file as the recipient of the debugging and tracing output.</summary>
		/// <param name="fileName">The name of the file the <see cref="T:System.Diagnostics.TextWriterTraceListener" /> writes to. </param>
		/// <exception cref="T:System.ArgumentNullException">The file is null. </exception>
		// Token: 0x06001516 RID: 5398 RVA: 0x00010471 File Offset: 0x0000E671
		public TextWriterTraceListener(string fileName)
			: this(fileName, string.Empty)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.TextWriterTraceListener" /> class using the specified writer as recipient of the tracing or debugging output.</summary>
		/// <param name="writer">A <see cref="T:System.IO.TextWriter" /> that receives the output from the <see cref="T:System.Diagnostics.TextWriterTraceListener" />. </param>
		/// <exception cref="T:System.ArgumentNullException">The writer is null. </exception>
		// Token: 0x06001517 RID: 5399 RVA: 0x0001047F File Offset: 0x0000E67F
		public TextWriterTraceListener(TextWriter writer)
			: this(writer, string.Empty)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.TextWriterTraceListener" /> class with the specified name, using the stream as the recipient of the debugging and tracing output.</summary>
		/// <param name="stream">A <see cref="T:System.IO.Stream" /> that represents the stream the <see cref="T:System.Diagnostics.TextWriterTraceListener" /> writes to. </param>
		/// <param name="name">The name of the new instance. </param>
		/// <exception cref="T:System.ArgumentNullException">The stream is null. </exception>
		// Token: 0x06001518 RID: 5400 RVA: 0x0001048D File Offset: 0x0000E68D
		public TextWriterTraceListener(Stream stream, string name)
			: base((name == null) ? string.Empty : name)
		{
			if (stream == null)
			{
				throw new ArgumentNullException("stream");
			}
			this.writer = new StreamWriter(stream);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.TextWriterTraceListener" /> class with the specified name, using the file as the recipient of the debugging and tracing output.</summary>
		/// <param name="fileName">The name of the file the <see cref="T:System.Diagnostics.TextWriterTraceListener" /> writes to. </param>
		/// <param name="name">The name of the new instance. </param>
		/// <exception cref="T:System.ArgumentNullException">The stream is null. </exception>
		// Token: 0x06001519 RID: 5401 RVA: 0x000104C3 File Offset: 0x0000E6C3
		public TextWriterTraceListener(string fileName, string name)
			: base((name == null) ? string.Empty : name)
		{
			if (fileName == null)
			{
				throw new ArgumentNullException("fileName");
			}
			this.writer = new StreamWriter(new FileStream(fileName, FileMode.Append, FileAccess.Write, FileShare.ReadWrite));
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.TextWriterTraceListener" /> class with the specified name, using the specified writer as recipient of the tracing or debugging output.</summary>
		/// <param name="writer">A <see cref="T:System.IO.TextWriter" /> that receives the output from the <see cref="T:System.Diagnostics.TextWriterTraceListener" />. </param>
		/// <param name="name">The name of the new instance. </param>
		/// <exception cref="T:System.ArgumentNullException">The writer is null. </exception>
		// Token: 0x0600151A RID: 5402 RVA: 0x00010501 File Offset: 0x0000E701
		public TextWriterTraceListener(TextWriter writer, string name)
			: base((name == null) ? string.Empty : name)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			this.writer = writer;
		}

		/// <summary>Gets or sets the text writer that receives the tracing or debugging output.</summary>
		/// <returns>A <see cref="T:System.IO.TextWriter" /> that represents the writer that receives the tracing or debugging output.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x0600151B RID: 5403 RVA: 0x00010532 File Offset: 0x0000E732
		// (set) Token: 0x0600151C RID: 5404 RVA: 0x0001053A File Offset: 0x0000E73A
		public TextWriter Writer
		{
			get
			{
				return this.writer;
			}
			set
			{
				this.writer = value;
			}
		}

		/// <summary>Closes the <see cref="P:System.Diagnostics.TextWriterTraceListener.Writer" /> so that it no longer receives tracing or debugging output.</summary>
		/// <filterpriority>1</filterpriority>
		// Token: 0x0600151D RID: 5405 RVA: 0x00010543 File Offset: 0x0000E743
		public override void Close()
		{
			if (this.writer != null)
			{
				this.writer.Flush();
				this.writer.Close();
				this.writer = null;
			}
		}

		/// <summary>Disposes this <see cref="T:System.Diagnostics.TextWriterTraceListener" /> object.</summary>
		/// <param name="disposing">true to release managed resources; if false, <see cref="M:System.Diagnostics.TextWriterTraceListener.Dispose(System.Boolean)" /> has no effect.</param>
		// Token: 0x0600151E RID: 5406 RVA: 0x0001056D File Offset: 0x0000E76D
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.Close();
			}
			base.Dispose(disposing);
		}

		/// <summary>Flushes the output buffer for the <see cref="P:System.Diagnostics.TextWriterTraceListener.Writer" />.</summary>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x0600151F RID: 5407 RVA: 0x00010582 File Offset: 0x0000E782
		public override void Flush()
		{
			if (this.writer != null)
			{
				this.writer.Flush();
			}
		}

		/// <summary>Writes a message to this instance's <see cref="P:System.Diagnostics.TextWriterTraceListener.Writer" />.</summary>
		/// <param name="message">A message to write. </param>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x06001520 RID: 5408 RVA: 0x0001059A File Offset: 0x0000E79A
		public override void Write(string message)
		{
			if (this.writer != null)
			{
				if (base.NeedIndent)
				{
					this.WriteIndent();
				}
				this.writer.Write(message);
			}
		}

		/// <summary>Writes a message to this instance's <see cref="P:System.Diagnostics.TextWriterTraceListener.Writer" /> followed by a line terminator. The default line terminator is a carriage return followed by a line feed (\r\n).</summary>
		/// <param name="message">A message to write. </param>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x06001521 RID: 5409 RVA: 0x000105C4 File Offset: 0x0000E7C4
		public override void WriteLine(string message)
		{
			if (this.writer != null)
			{
				if (base.NeedIndent)
				{
					this.WriteIndent();
				}
				this.writer.WriteLine(message);
				base.NeedIndent = true;
			}
		}

		// Token: 0x0400066F RID: 1647
		private TextWriter writer;
	}
}
