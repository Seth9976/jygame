using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Helper class to generate form data to post to web servers using the WWW class.</para>
	/// </summary>
	// Token: 0x0200009D RID: 157
	public sealed class WWWForm
	{
		/// <summary>
		///   <para>Creates an empty WWWForm object.</para>
		/// </summary>
		// Token: 0x060008FD RID: 2301 RVA: 0x00015A70 File Offset: 0x00013C70
		public WWWForm()
		{
			this.formData = new List<byte[]>();
			this.fieldNames = new List<string>();
			this.fileNames = new List<string>();
			this.types = new List<string>();
			this.boundary = new byte[40];
			for (int i = 0; i < 40; i++)
			{
				int num = Random.Range(48, 110);
				if (num > 57)
				{
					num += 7;
				}
				if (num > 90)
				{
					num += 6;
				}
				this.boundary[i] = (byte)num;
			}
		}

		/// <summary>
		///   <para>Add a simple field to the form.</para>
		/// </summary>
		/// <param name="fieldName"></param>
		/// <param name="value"></param>
		/// <param name="e"></param>
		// Token: 0x060008FE RID: 2302 RVA: 0x00015AFC File Offset: 0x00013CFC
		[ExcludeFromDocs]
		public void AddField(string fieldName, string value)
		{
			Encoding utf = Encoding.UTF8;
			this.AddField(fieldName, value, utf);
		}

		/// <summary>
		///   <para>Add a simple field to the form.</para>
		/// </summary>
		/// <param name="fieldName"></param>
		/// <param name="value"></param>
		/// <param name="e"></param>
		// Token: 0x060008FF RID: 2303 RVA: 0x00015B18 File Offset: 0x00013D18
		public void AddField(string fieldName, string value, [DefaultValue("System.Text.Encoding.UTF8")] Encoding e)
		{
			this.fieldNames.Add(fieldName);
			this.fileNames.Add(null);
			this.formData.Add(e.GetBytes(value));
			this.types.Add("text/plain; charset=\"" + e.WebName + "\"");
		}

		/// <summary>
		///   <para>Adds a simple field to the form.</para>
		/// </summary>
		/// <param name="fieldName"></param>
		/// <param name="i"></param>
		// Token: 0x06000900 RID: 2304 RVA: 0x000056D6 File Offset: 0x000038D6
		public void AddField(string fieldName, int i)
		{
			this.AddField(fieldName, i.ToString());
		}

		/// <summary>
		///   <para>Add binary data to the form.</para>
		/// </summary>
		/// <param name="fieldName"></param>
		/// <param name="contents"></param>
		/// <param name="fileName"></param>
		/// <param name="mimeType"></param>
		// Token: 0x06000901 RID: 2305 RVA: 0x00015B70 File Offset: 0x00013D70
		[ExcludeFromDocs]
		public void AddBinaryData(string fieldName, byte[] contents, string fileName)
		{
			string text = null;
			this.AddBinaryData(fieldName, contents, fileName, text);
		}

		/// <summary>
		///   <para>Add binary data to the form.</para>
		/// </summary>
		/// <param name="fieldName"></param>
		/// <param name="contents"></param>
		/// <param name="fileName"></param>
		/// <param name="mimeType"></param>
		// Token: 0x06000902 RID: 2306 RVA: 0x00015B8C File Offset: 0x00013D8C
		[ExcludeFromDocs]
		public void AddBinaryData(string fieldName, byte[] contents)
		{
			string text = null;
			string text2 = null;
			this.AddBinaryData(fieldName, contents, text2, text);
		}

		/// <summary>
		///   <para>Add binary data to the form.</para>
		/// </summary>
		/// <param name="fieldName"></param>
		/// <param name="contents"></param>
		/// <param name="fileName"></param>
		/// <param name="mimeType"></param>
		// Token: 0x06000903 RID: 2307 RVA: 0x00015BA8 File Offset: 0x00013DA8
		public void AddBinaryData(string fieldName, byte[] contents, [DefaultValue("null")] string fileName, [DefaultValue("null")] string mimeType)
		{
			this.containsFiles = true;
			bool flag = contents.Length > 8 && contents[0] == 137 && contents[1] == 80 && contents[2] == 78 && contents[3] == 71 && contents[4] == 13 && contents[5] == 10 && contents[6] == 26 && contents[7] == 10;
			if (fileName == null)
			{
				fileName = fieldName + ((!flag) ? ".dat" : ".png");
			}
			if (mimeType == null)
			{
				if (flag)
				{
					mimeType = "image/png";
				}
				else
				{
					mimeType = "application/octet-stream";
				}
			}
			this.fieldNames.Add(fieldName);
			this.fileNames.Add(fileName);
			this.formData.Add(contents);
			this.types.Add(mimeType);
		}

		/// <summary>
		///   <para>(Read Only) Returns the correct request headers for posting the form using the WWW class.</para>
		/// </summary>
		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x00015C90 File Offset: 0x00013E90
		public Dictionary<string, string> headers
		{
			get
			{
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				if (this.containsFiles)
				{
					dictionary["Content-Type"] = "multipart/form-data; boundary=\"" + Encoding.UTF8.GetString(this.boundary, 0, this.boundary.Length) + "\"";
				}
				else
				{
					dictionary["Content-Type"] = "application/x-www-form-urlencoded";
				}
				return dictionary;
			}
		}

		/// <summary>
		///   <para>(Read Only) The raw data to pass as the POST request body when sending the form.</para>
		/// </summary>
		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000905 RID: 2309 RVA: 0x00015CF8 File Offset: 0x00013EF8
		public byte[] data
		{
			get
			{
				if (this.containsFiles)
				{
					byte[] bytes = WWW.DefaultEncoding.GetBytes("--");
					byte[] bytes2 = WWW.DefaultEncoding.GetBytes("\r\n");
					byte[] bytes3 = WWW.DefaultEncoding.GetBytes("Content-Type: ");
					byte[] bytes4 = WWW.DefaultEncoding.GetBytes("Content-disposition: form-data; name=\"");
					byte[] bytes5 = WWW.DefaultEncoding.GetBytes("\"");
					byte[] bytes6 = WWW.DefaultEncoding.GetBytes("; filename=\"");
					using (MemoryStream memoryStream = new MemoryStream(1024))
					{
						for (int i = 0; i < this.formData.Count; i++)
						{
							memoryStream.Write(bytes2, 0, bytes2.Length);
							memoryStream.Write(bytes, 0, bytes.Length);
							memoryStream.Write(this.boundary, 0, this.boundary.Length);
							memoryStream.Write(bytes2, 0, bytes2.Length);
							memoryStream.Write(bytes3, 0, bytes3.Length);
							byte[] bytes7 = Encoding.UTF8.GetBytes(this.types[i]);
							memoryStream.Write(bytes7, 0, bytes7.Length);
							memoryStream.Write(bytes2, 0, bytes2.Length);
							memoryStream.Write(bytes4, 0, bytes4.Length);
							string headerName = Encoding.UTF8.HeaderName;
							string text = this.fieldNames[i];
							if (!WWWTranscoder.SevenBitClean(text, Encoding.UTF8) || text.IndexOf("=?") > -1)
							{
								text = string.Concat(new string[]
								{
									"=?",
									headerName,
									"?Q?",
									WWWTranscoder.QPEncode(text, Encoding.UTF8),
									"?="
								});
							}
							byte[] bytes8 = Encoding.UTF8.GetBytes(text);
							memoryStream.Write(bytes8, 0, bytes8.Length);
							memoryStream.Write(bytes5, 0, bytes5.Length);
							if (this.fileNames[i] != null)
							{
								string text2 = this.fileNames[i];
								if (!WWWTranscoder.SevenBitClean(text2, Encoding.UTF8) || text2.IndexOf("=?") > -1)
								{
									text2 = string.Concat(new string[]
									{
										"=?",
										headerName,
										"?Q?",
										WWWTranscoder.QPEncode(text2, Encoding.UTF8),
										"?="
									});
								}
								byte[] bytes9 = Encoding.UTF8.GetBytes(text2);
								memoryStream.Write(bytes6, 0, bytes6.Length);
								memoryStream.Write(bytes9, 0, bytes9.Length);
								memoryStream.Write(bytes5, 0, bytes5.Length);
							}
							memoryStream.Write(bytes2, 0, bytes2.Length);
							memoryStream.Write(bytes2, 0, bytes2.Length);
							byte[] array = this.formData[i];
							memoryStream.Write(array, 0, array.Length);
						}
						memoryStream.Write(bytes2, 0, bytes2.Length);
						memoryStream.Write(bytes, 0, bytes.Length);
						memoryStream.Write(this.boundary, 0, this.boundary.Length);
						memoryStream.Write(bytes, 0, bytes.Length);
						memoryStream.Write(bytes2, 0, bytes2.Length);
						return memoryStream.ToArray();
					}
				}
				byte[] bytes10 = WWW.DefaultEncoding.GetBytes("&");
				byte[] bytes11 = WWW.DefaultEncoding.GetBytes("=");
				byte[] array5;
				using (MemoryStream memoryStream2 = new MemoryStream(1024))
				{
					for (int j = 0; j < this.formData.Count; j++)
					{
						byte[] array2 = WWWTranscoder.URLEncode(Encoding.UTF8.GetBytes(this.fieldNames[j]));
						byte[] array3 = this.formData[j];
						byte[] array4 = WWWTranscoder.URLEncode(array3);
						if (j > 0)
						{
							memoryStream2.Write(bytes10, 0, bytes10.Length);
						}
						memoryStream2.Write(array2, 0, array2.Length);
						memoryStream2.Write(bytes11, 0, bytes11.Length);
						memoryStream2.Write(array4, 0, array4.Length);
					}
					array5 = memoryStream2.ToArray();
				}
				return array5;
			}
		}

		// Token: 0x040001EA RID: 490
		private List<byte[]> formData;

		// Token: 0x040001EB RID: 491
		private List<string> fieldNames;

		// Token: 0x040001EC RID: 492
		private List<string> fileNames;

		// Token: 0x040001ED RID: 493
		private List<string> types;

		// Token: 0x040001EE RID: 494
		private byte[] boundary;

		// Token: 0x040001EF RID: 495
		private bool containsFiles;
	}
}
