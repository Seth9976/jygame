using System;
using System.Text;

namespace UnityEngine.Experimental.Networking
{
	/// <summary>
	///   <para>A helper object for adding file uploads to multipart forms via the [IMultipartFormSection] API.</para>
	/// </summary>
	// Token: 0x020001F4 RID: 500
	public class MultipartFormFileSection : IMultipartFormSection
	{
		/// <summary>
		///   <para>Contains a named file section based on the raw bytes from data, with a custom Content-Type and file name.</para>
		/// </summary>
		/// <param name="name">Name of this form section.</param>
		/// <param name="data">Raw contents of the file to upload.</param>
		/// <param name="fileName">Name of the file uploaded by this form section.</param>
		/// <param name="contentType">The value for this section's Content-Type header.</param>
		// Token: 0x06001D83 RID: 7555 RVA: 0x00024650 File Offset: 0x00022850
		public MultipartFormFileSection(string name, byte[] data, string fileName, string contentType)
		{
			if (data == null || data.Length < 1)
			{
				throw new ArgumentException("Cannot create a multipart form file section without body data");
			}
			if (string.IsNullOrEmpty(fileName))
			{
				fileName = "file.dat";
			}
			if (string.IsNullOrEmpty(contentType))
			{
				contentType = "application/octet-stream";
			}
			this.Init(name, data, fileName, contentType);
		}

		/// <summary>
		///   <para>Contains an anonymous file section based on the raw bytes from data, assigns a default Content-Type and file name.</para>
		/// </summary>
		/// <param name="data">Raw contents of the file to upload.</param>
		// Token: 0x06001D84 RID: 7556 RVA: 0x0000B785 File Offset: 0x00009985
		public MultipartFormFileSection(byte[] data)
			: this(null, data, null, null)
		{
		}

		/// <summary>
		///   <para>Contains an anonymous file section based on the raw bytes from data with a specific file name. Assigns a default Content-Type.</para>
		/// </summary>
		/// <param name="data">Raw contents of the file to upload.</param>
		/// <param name="fileName">Name of the file uploaded by this form section.</param>
		// Token: 0x06001D85 RID: 7557 RVA: 0x0000B791 File Offset: 0x00009991
		public MultipartFormFileSection(string fileName, byte[] data)
			: this(null, data, fileName, null)
		{
		}

		/// <summary>
		///   <para>Contains a named file section with data drawn from data, as marshaled by dataEncoding. Assigns a specific file name from fileName and a default Content-Type.</para>
		/// </summary>
		/// <param name="name">Name of this form section.</param>
		/// <param name="data">Contents of the file to upload.</param>
		/// <param name="dataEncoding">A string encoding.</param>
		/// <param name="fileName">Name of the file uploaded by this form section.</param>
		// Token: 0x06001D86 RID: 7558 RVA: 0x000246B0 File Offset: 0x000228B0
		public MultipartFormFileSection(string name, string data, Encoding dataEncoding, string fileName)
		{
			if (data == null || data.Length < 1)
			{
				throw new ArgumentException("Cannot create a multipart form file section without body data");
			}
			if (dataEncoding == null)
			{
				dataEncoding = Encoding.UTF8;
			}
			byte[] bytes = dataEncoding.GetBytes(data);
			if (string.IsNullOrEmpty(fileName))
			{
				fileName = "file.txt";
			}
			if (string.IsNullOrEmpty(this.content))
			{
				this.content = "text/plain; charset=" + dataEncoding.WebName;
			}
			this.Init(name, bytes, fileName, this.content);
		}

		/// <summary>
		///   <para>An anonymous file section with data drawn from data, as marshaled by dataEncoding. Assigns a specific file name from fileName and a default Content-Type.</para>
		/// </summary>
		/// <param name="data">Contents of the file to upload.</param>
		/// <param name="dataEncoding">A string encoding.</param>
		/// <param name="fileName">Name of the file uploaded by this form section.</param>
		// Token: 0x06001D87 RID: 7559 RVA: 0x0000B79D File Offset: 0x0000999D
		public MultipartFormFileSection(string data, Encoding dataEncoding, string fileName)
			: this(null, data, dataEncoding, fileName)
		{
		}

		/// <summary>
		///   <para>An anonymous file section with data drawn from the UTF8 string data. Assigns a specific file name from fileName and a default Content-Type.</para>
		/// </summary>
		/// <param name="data">Contents of the file to upload.</param>
		/// <param name="fileName">Name of the file uploaded by this form section.</param>
		// Token: 0x06001D88 RID: 7560 RVA: 0x0000B7A9 File Offset: 0x000099A9
		public MultipartFormFileSection(string data, string fileName)
			: this(data, null, fileName)
		{
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x0000B7B4 File Offset: 0x000099B4
		private void Init(string name, byte[] data, string fileName, string contentType)
		{
			this.name = name;
			this.data = data;
			this.file = fileName;
			this.content = contentType;
		}

		/// <summary>
		///   <para>Returns the name of this section, if any.</para>
		/// </summary>
		/// <returns>
		///   <para>The section's name, or null.</para>
		/// </returns>
		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06001D8A RID: 7562 RVA: 0x0000B7D3 File Offset: 0x000099D3
		public string sectionName
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>
		///   <para>Returns the raw binary data contained in this section. Will not return null or a zero-length array.</para>
		/// </summary>
		/// <returns>
		///   <para>The raw binary data contained in this section. Will not be null or empty.</para>
		/// </returns>
		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06001D8B RID: 7563 RVA: 0x0000B7DB File Offset: 0x000099DB
		public byte[] sectionData
		{
			get
			{
				return this.data;
			}
		}

		/// <summary>
		///   <para>Returns a string denoting the desired filename of this section on the destination server.</para>
		/// </summary>
		/// <returns>
		///   <para>The desired file name of this section, or null if this is not a file section.</para>
		/// </returns>
		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06001D8C RID: 7564 RVA: 0x0000B7E3 File Offset: 0x000099E3
		public string fileName
		{
			get
			{
				return this.file;
			}
		}

		/// <summary>
		///   <para>Returns the value of the section's Content-Type header.</para>
		/// </summary>
		/// <returns>
		///   <para>The Content-Type header for this section, or null.</para>
		/// </returns>
		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06001D8D RID: 7565 RVA: 0x0000B7EB File Offset: 0x000099EB
		public string contentType
		{
			get
			{
				return this.content;
			}
		}

		// Token: 0x040007E5 RID: 2021
		private string name;

		// Token: 0x040007E6 RID: 2022
		private byte[] data;

		// Token: 0x040007E7 RID: 2023
		private string file;

		// Token: 0x040007E8 RID: 2024
		private string content;
	}
}
