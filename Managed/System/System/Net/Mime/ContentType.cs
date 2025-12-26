using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;
using System.Text;

namespace System.Net.Mime
{
	/// <summary>Represents a MIME protocol Content-Type header.</summary>
	// Token: 0x02000366 RID: 870
	public class ContentType
	{
		/// <summary>Initializes a new default instance of the <see cref="T:System.Net.Mime.ContentType" /> class. </summary>
		// Token: 0x06001E88 RID: 7816 RVA: 0x00016338 File Offset: 0x00014538
		public ContentType()
		{
			this.mediaType = "application/octet-stream";
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Mime.ContentType" /> class using the specified string. </summary>
		/// <param name="contentType">A <see cref="T:System.String" />, for example, "text/plain; charset=us-ascii", that contains the MIME media type, subtype, and optional parameters.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="contentType" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="contentType" /> is <see cref="F:System.String.Empty" /> ("").</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="contentType" /> is in a form that cannot be parsed.</exception>
		// Token: 0x06001E89 RID: 7817 RVA: 0x0005F1FC File Offset: 0x0005D3FC
		public ContentType(string contentType)
		{
			if (contentType == null)
			{
				throw new ArgumentNullException("contentType");
			}
			if (contentType.Length < 1)
			{
				throw new ArgumentException("contentType");
			}
			int num = contentType.IndexOf(';');
			if (num > 0)
			{
				string[] array = contentType.Split(new char[] { ';' });
				this.MediaType = array[0].Trim();
				for (int i = 1; i < array.Length; i++)
				{
					this.Parse(array[i]);
				}
			}
			else
			{
				this.MediaType = contentType.Trim();
			}
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x0005F2A0 File Offset: 0x0005D4A0
		private void Parse(string pair)
		{
			if (pair == null || pair.Length < 1)
			{
				return;
			}
			string[] array = pair.Split(new char[] { '=' });
			if (array.Length == 2)
			{
				this.parameters.Add(array[0].Trim(), array[1].Trim());
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06001E8C RID: 7820 RVA: 0x0001636F File Offset: 0x0001456F
		private static Encoding UTF8Unmarked
		{
			get
			{
				if (ContentType.utf8unmarked == null)
				{
					ContentType.utf8unmarked = new UTF8Encoding(false);
				}
				return ContentType.utf8unmarked;
			}
		}

		/// <summary>Gets or sets the value of the boundary parameter included in the Content-Type header represented by this instance.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the value associated with the boundary parameter.</returns>
		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06001E8D RID: 7821 RVA: 0x0001638B File Offset: 0x0001458B
		// (set) Token: 0x06001E8E RID: 7822 RVA: 0x0001639D File Offset: 0x0001459D
		public string Boundary
		{
			get
			{
				return this.parameters["boundary"];
			}
			set
			{
				this.parameters["boundary"] = value;
			}
		}

		/// <summary>Gets or sets the value of the charset parameter included in the Content-Type header represented by this instance.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the value associated with the charset parameter.</returns>
		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06001E8F RID: 7823 RVA: 0x000163B0 File Offset: 0x000145B0
		// (set) Token: 0x06001E90 RID: 7824 RVA: 0x000163C2 File Offset: 0x000145C2
		public string CharSet
		{
			get
			{
				return this.parameters["charset"];
			}
			set
			{
				this.parameters["charset"] = value;
			}
		}

		/// <summary>Gets or sets the media type value included in the Content-Type header represented by this instance.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the media type and subtype value. This value does not include the semicolon (;) separator that follows the subtype.</returns>
		/// <exception cref="T:System.ArgumentNullException">The value specified for a set operation is null.</exception>
		/// <exception cref="T:System.ArgumentException">The value specified for a set operation is <see cref="F:System.String.Empty" /> ("").</exception>
		/// <exception cref="T:System.FormatException">The value specified for a set operation is in a form that cannot be parsed.</exception>
		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06001E91 RID: 7825 RVA: 0x000163D5 File Offset: 0x000145D5
		// (set) Token: 0x06001E92 RID: 7826 RVA: 0x0005F2F8 File Offset: 0x0005D4F8
		public string MediaType
		{
			get
			{
				return this.mediaType;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException();
				}
				if (value.Length < 1)
				{
					throw new ArgumentException();
				}
				if (value.IndexOf('/') < 1)
				{
					throw new FormatException();
				}
				if (value.IndexOf(';') != -1)
				{
					throw new FormatException();
				}
				this.mediaType = value;
			}
		}

		/// <summary>Gets or sets the value of the name parameter included in the Content-Type header represented by this instance.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the value associated with the name parameter. </returns>
		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06001E93 RID: 7827 RVA: 0x000163DD File Offset: 0x000145DD
		// (set) Token: 0x06001E94 RID: 7828 RVA: 0x000163EF File Offset: 0x000145EF
		public string Name
		{
			get
			{
				return this.parameters["name"];
			}
			set
			{
				this.parameters["name"] = value;
			}
		}

		/// <summary>Gets the dictionary that contains the parameters included in the Content-Type header represented by this instance.</summary>
		/// <returns>A writable <see cref="T:System.Collections.Specialized.StringDictionary" /> that contains name and value pairs.</returns>
		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06001E95 RID: 7829 RVA: 0x00016402 File Offset: 0x00014602
		public global::System.Collections.Specialized.StringDictionary Parameters
		{
			get
			{
				return this.parameters;
			}
		}

		/// <summary>Determines whether the content-type header of the specified <see cref="T:System.Net.Mime.ContentType" /> object is equal to the content-type header of this object.</summary>
		/// <returns>true if the content-type headers are the same; otherwise false.</returns>
		/// <param name="rparam">The <see cref="T:System.Net.Mime.ContentType" /> object to compare with this object.</param>
		// Token: 0x06001E96 RID: 7830 RVA: 0x0001640A File Offset: 0x0001460A
		public override bool Equals(object obj)
		{
			return this.Equals(obj as ContentType);
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x00016418 File Offset: 0x00014618
		private bool Equals(ContentType other)
		{
			return other != null && this.ToString() == other.ToString();
		}

		/// <summary>Determines the hash code of the specified <see cref="T:System.Net.Mime.ContentType" /> object</summary>
		/// <returns>An integer hash value.</returns>
		// Token: 0x06001E98 RID: 7832 RVA: 0x00016434 File Offset: 0x00014634
		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		/// <summary>Returns a string representation of this <see cref="T:System.Net.Mime.ContentType" /> object.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the current settings for this <see cref="T:System.Net.Mime.ContentType" />.</returns>
		// Token: 0x06001E99 RID: 7833 RVA: 0x0005F354 File Offset: 0x0005D554
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			Encoding encoding = ((this.CharSet == null) ? Encoding.UTF8 : Encoding.GetEncoding(this.CharSet));
			stringBuilder.Append(this.MediaType);
			if (this.Parameters != null && this.Parameters.Count > 0)
			{
				foreach (object obj in this.parameters)
				{
					DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
					if (dictionaryEntry.Value != null && dictionaryEntry.Value.ToString().Length > 0)
					{
						stringBuilder.Append("; ");
						stringBuilder.Append(dictionaryEntry.Key);
						stringBuilder.Append("=");
						stringBuilder.Append(ContentType.WrapIfEspecialsExist(ContentType.EncodeSubjectRFC2047(dictionaryEntry.Value as string, encoding)));
					}
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x00016441 File Offset: 0x00014641
		private static string WrapIfEspecialsExist(string s)
		{
			s = s.Replace("\"", "\\\"");
			if (s.IndexOfAny(ContentType.especials) >= 0)
			{
				return '"' + s + '"';
			}
			return s;
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x0005F470 File Offset: 0x0005D670
		internal static Encoding GuessEncoding(string s)
		{
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] >= '\u0080')
				{
					return ContentType.UTF8Unmarked;
				}
			}
			return null;
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x0005F4AC File Offset: 0x0005D6AC
		internal static TransferEncoding GuessTransferEncoding(Encoding enc)
		{
			if (Encoding.ASCII.Equals(enc))
			{
				return TransferEncoding.SevenBit;
			}
			if (Encoding.UTF8.CodePage == enc.CodePage || Encoding.Unicode.CodePage == enc.CodePage || Encoding.UTF32.CodePage == enc.CodePage)
			{
				return TransferEncoding.Base64;
			}
			return TransferEncoding.QuotedPrintable;
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x0005F510 File Offset: 0x0005D710
		internal static string To2047(byte[] bytes)
		{
			StringWriter stringWriter = new StringWriter();
			foreach (byte b in bytes)
			{
				if (b > 127 || b == 9)
				{
					stringWriter.Write("=");
					stringWriter.Write(Convert.ToString(b, 16).ToUpper());
				}
				else
				{
					stringWriter.Write(Convert.ToChar(b));
				}
			}
			return stringWriter.GetStringBuilder().ToString();
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x0005F588 File Offset: 0x0005D788
		internal static string EncodeSubjectRFC2047(string s, Encoding enc)
		{
			if (s == null || Encoding.ASCII.Equals(enc))
			{
				return s;
			}
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] >= '\u0080')
				{
					string text = ContentType.To2047(enc.GetBytes(s));
					return string.Concat(new string[] { "=?", enc.HeaderName, "?Q?", text, "?=" });
				}
			}
			return s;
		}

		// Token: 0x040012CB RID: 4811
		private static Encoding utf8unmarked;

		// Token: 0x040012CC RID: 4812
		private string mediaType;

		// Token: 0x040012CD RID: 4813
		private global::System.Collections.Specialized.StringDictionary parameters = new global::System.Collections.Specialized.StringDictionary();

		// Token: 0x040012CE RID: 4814
		private static readonly char[] especials = new char[]
		{
			'(', ')', '<', '>', '@', ',', ';', ':', '<', '>',
			'/', '[', ']', '?', '.', '='
		};
	}
}
