using System;
using System.Text;

namespace UnityEngine.Experimental.Networking
{
	/// <summary>
	///   <para>A helper object for form sections containing generic, non-file data.</para>
	/// </summary>
	// Token: 0x020001F3 RID: 499
	public class MultipartFormDataSection : IMultipartFormSection
	{
		/// <summary>
		///   <para>A raw data section with a section name and a Content-Type header.</para>
		/// </summary>
		/// <param name="name">Section name.</param>
		/// <param name="data">Data payload of this section.</param>
		/// <param name="contentType">The value for this section's Content-Type header.</param>
		// Token: 0x06001D78 RID: 7544 RVA: 0x0000B6F8 File Offset: 0x000098F8
		public MultipartFormDataSection(string name, byte[] data, string contentType)
		{
			if (data == null || data.Length < 1)
			{
				throw new ArgumentException("Cannot create a multipart form data section without body data");
			}
			this.name = name;
			this.data = data;
			this.content = contentType;
		}

		/// <summary>
		///   <para>Raw data section with a section name, no Content-Type header.</para>
		/// </summary>
		/// <param name="name">Section name.</param>
		/// <param name="data">Data payload of this section.</param>
		// Token: 0x06001D79 RID: 7545 RVA: 0x0000B72F File Offset: 0x0000992F
		public MultipartFormDataSection(string name, byte[] data)
			: this(name, data, null)
		{
		}

		/// <summary>
		///   <para>Raw data section, unnamed and no Content-Type header.</para>
		/// </summary>
		/// <param name="data">Data payload of this section.</param>
		// Token: 0x06001D7A RID: 7546 RVA: 0x0000B73A File Offset: 0x0000993A
		public MultipartFormDataSection(byte[] data)
			: this(null, data)
		{
		}

		/// <summary>
		///   <para>A named raw data section whose payload is derived from a string, with a Content-Type header.</para>
		/// </summary>
		/// <param name="name">Section name.</param>
		/// <param name="data">String data payload for this section.</param>
		/// <param name="contentType">The value for this section's Content-Type header.</param>
		/// <param name="encoding">An encoding to marshal data to or from raw bytes.</param>
		// Token: 0x06001D7B RID: 7547 RVA: 0x000245D0 File Offset: 0x000227D0
		public MultipartFormDataSection(string name, string data, Encoding encoding, string contentType)
		{
			if (data == null || data.Length < 1)
			{
				throw new ArgumentException("Cannot create a multipart form data section without body data");
			}
			byte[] bytes = encoding.GetBytes(data);
			this.name = name;
			this.data = bytes;
			if (contentType != null && !contentType.Contains("encoding="))
			{
				contentType = contentType.Trim() + "; encoding=" + encoding.WebName;
			}
			this.content = contentType;
		}

		/// <summary>
		///   <para>A named raw data section whose payload is derived from a UTF8 string, with a Content-Type header.</para>
		/// </summary>
		/// <param name="name">Section name.</param>
		/// <param name="data">String data payload for this section.</param>
		/// <param name="contentType">C.</param>
		// Token: 0x06001D7C RID: 7548 RVA: 0x0000B744 File Offset: 0x00009944
		public MultipartFormDataSection(string name, string data, string contentType)
			: this(name, data, Encoding.UTF8, contentType)
		{
		}

		/// <summary>
		///   <para>A names raw data section whose payload is derived from a UTF8 string, with a default Content-Type.</para>
		/// </summary>
		/// <param name="name">Section name.</param>
		/// <param name="data">String data payload for this section.</param>
		// Token: 0x06001D7D RID: 7549 RVA: 0x0000B754 File Offset: 0x00009954
		public MultipartFormDataSection(string name, string data)
			: this(name, data, "text/plain")
		{
		}

		/// <summary>
		///   <para>An anonymous raw data section whose payload is derived from a UTF8 string, with a default Content-Type.</para>
		/// </summary>
		/// <param name="data">String data payload for this section.</param>
		// Token: 0x06001D7E RID: 7550 RVA: 0x0000B763 File Offset: 0x00009963
		public MultipartFormDataSection(string data)
			: this(null, data)
		{
		}

		/// <summary>
		///   <para>Returns the name of this section, if any.</para>
		/// </summary>
		/// <returns>
		///   <para>The section's name, or null.</para>
		/// </returns>
		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06001D7F RID: 7551 RVA: 0x0000B76D File Offset: 0x0000996D
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
		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06001D80 RID: 7552 RVA: 0x0000B775 File Offset: 0x00009975
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
		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06001D81 RID: 7553 RVA: 0x00002096 File Offset: 0x00000296
		public string fileName
		{
			get
			{
				return null;
			}
		}

		/// <summary>
		///   <para>Returns the value to use in this section's Content-Type header.</para>
		/// </summary>
		/// <returns>
		///   <para>The Content-Type header for this section, or null.</para>
		/// </returns>
		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06001D82 RID: 7554 RVA: 0x0000B77D File Offset: 0x0000997D
		public string contentType
		{
			get
			{
				return this.content;
			}
		}

		// Token: 0x040007E2 RID: 2018
		private string name;

		// Token: 0x040007E3 RID: 2019
		private byte[] data;

		// Token: 0x040007E4 RID: 2020
		private string content;
	}
}
