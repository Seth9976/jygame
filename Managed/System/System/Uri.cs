using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Text;

namespace System
{
	/// <summary>Provides an object representation of a uniform resource identifier (URI) and easy access to the parts of the URI.</summary>
	/// <filterpriority>1</filterpriority>
	// Token: 0x020004D0 RID: 1232
	[global::System.ComponentModel.TypeConverter(typeof(global::System.UriTypeConverter))]
	[Serializable]
	public class Uri : ISerializable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Uri" /> class with the specified URI.</summary>
		/// <param name="uriString">A URI. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="uriString" /> is null. </exception>
		/// <exception cref="T:System.UriFormatException">
		///   <paramref name="uriString" /> is empty.-or- The scheme specified in <paramref name="uriString" /> is not correctly formed. See <see cref="M:System.Uri.CheckSchemeName(System.String)" />.-or- <paramref name="uriString" /> contains too many slashes.-or- The password specified in <paramref name="uriString" /> is not valid.-or- The host name specified in <paramref name="uriString" /> is not valid.-or- The file name specified in <paramref name="uriString" /> is not valid. -or- The user name specified in <paramref name="uriString" /> is not valid.-or- The host or authority name specified in <paramref name="uriString" /> cannot be terminated by backslashes.-or- The port number specified in <paramref name="uriString" /> is not valid or cannot be parsed.-or- The length of <paramref name="uriString" /> exceeds 65519 characters.-or- The length of the scheme specified in <paramref name="uriString" /> exceeds 1023 characters.-or- There is an invalid character sequence in <paramref name="uriString" />.-or- The MS-DOS path specified in <paramref name="uriString" /> must start with c:\\.</exception>
		// Token: 0x06002BAB RID: 11179 RVA: 0x0001E5BE File Offset: 0x0001C7BE
		public Uri(string uriString)
			: this(uriString, false)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Uri" /> class from the specified instances of the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> classes.</summary>
		/// <param name="serializationInfo">An instance of the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> class containing the information required to serialize the new <see cref="T:System.Uri" /> instance. </param>
		/// <param name="streamingContext">An instance of the <see cref="T:System.Runtime.Serialization.StreamingContext" /> class containing the source of the serialized stream associated with the new <see cref="T:System.Uri" /> instance. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="serializationInfo" /> parameter contains a null URI. </exception>
		/// <exception cref="T:System.UriFormatException">The <paramref name="serializationInfo" /> parameter contains a URI that is empty.-or- The scheme specified is not correctly formed. See <see cref="M:System.Uri.CheckSchemeName(System.String)" />.-or- The URI contains too many slashes.-or- The password specified in the URI is not valid.-or- The host name specified in URI is not valid.-or- The file name specified in the URI is not valid. -or- The user name specified in the URI is not valid.-or- The host or authority name specified in the URI cannot be terminated by backslashes.-or- The port number specified in the URI is not valid or cannot be parsed.-or- The length of URI exceeds 65519 characters.-or- The length of the scheme specified in the URI exceeds 1023 characters.-or- There is an invalid character sequence in the URI.-or- The MS-DOS path specified in the URI must start with c:\\.</exception>
		// Token: 0x06002BAC RID: 11180 RVA: 0x0001E5C8 File Offset: 0x0001C7C8
		protected Uri(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(serializationInfo.GetString("AbsoluteUri"), true)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Uri" /> class with the specified URI. This constructor allows you to specify if the URI string is a relative URI, absolute URI, or is indeterminate.</summary>
		/// <param name="uriString">A string that identifies the resource to be represented by the <see cref="T:System.Uri" /> instance.</param>
		/// <param name="uriKind">Specifies whether the URI string is a relative URI, absolute URI, or is indeterminate.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="uriKind" /> is invalid. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="uriString" /> is null. </exception>
		/// <exception cref="T:System.UriFormatException">
		///   <paramref name="uriString" /> contains a relative URI and <paramref name="uriKind" /> is <see cref="F:System.UriKind.Absolute" />.or<paramref name="uriString" /> contains an absolute URI and <paramref name="uriKind" /> is <see cref="F:System.UriKind.Relative" />.or<paramref name="uriString" /> is empty.-or- The scheme specified in <paramref name="uriString" /> is not correctly formed. See <see cref="M:System.Uri.CheckSchemeName(System.String)" />.-or- <paramref name="uriString" /> contains too many slashes.-or- The password specified in <paramref name="uriString" /> is not valid.-or- The host name specified in <paramref name="uriString" /> is not valid.-or- The file name specified in <paramref name="uriString" /> is not valid. -or- The user name specified in <paramref name="uriString" /> is not valid.-or- The host or authority name specified in <paramref name="uriString" /> cannot be terminated by backslashes.-or- The port number specified in <paramref name="uriString" /> is not valid or cannot be parsed.-or- The length of <paramref name="uriString" /> exceeds 65519 characters.-or- The length of the scheme specified in <paramref name="uriString" /> exceeds 1023 characters.-or- There is an invalid character sequence in <paramref name="uriString" />.-or- The MS-DOS path specified in <paramref name="uriString" /> must start with c:\\.</exception>
		// Token: 0x06002BAD RID: 11181 RVA: 0x0008C4E4 File Offset: 0x0008A6E4
		public Uri(string uriString, global::System.UriKind uriKind)
		{
			this.scheme = string.Empty;
			this.host = string.Empty;
			this.port = -1;
			this.path = string.Empty;
			this.query = string.Empty;
			this.fragment = string.Empty;
			this.userinfo = string.Empty;
			this.isAbsoluteUri = true;
			base..ctor();
			this.source = uriString;
			this.ParseUri(uriKind);
			switch (uriKind)
			{
			case global::System.UriKind.RelativeOrAbsolute:
				break;
			case global::System.UriKind.Absolute:
				if (!this.IsAbsoluteUri)
				{
					throw new global::System.UriFormatException("Invalid URI: The format of the URI could not be determined.");
				}
				break;
			case global::System.UriKind.Relative:
				if (this.IsAbsoluteUri)
				{
					throw new global::System.UriFormatException("Invalid URI: The format of the URI could not be determined because the parameter 'uriString' represents an absolute URI.");
				}
				break;
			default:
			{
				string text = global::Locale.GetText("Invalid UriKind value '{0}'.", new object[] { uriKind });
				throw new ArgumentException(text);
			}
			}
		}

		// Token: 0x06002BAE RID: 11182 RVA: 0x0008C5CC File Offset: 0x0008A7CC
		private Uri(string uriString, global::System.UriKind uriKind, out bool success)
		{
			this.scheme = string.Empty;
			this.host = string.Empty;
			this.port = -1;
			this.path = string.Empty;
			this.query = string.Empty;
			this.fragment = string.Empty;
			this.userinfo = string.Empty;
			this.isAbsoluteUri = true;
			base..ctor();
			if (uriString == null)
			{
				success = false;
				return;
			}
			if (uriKind != global::System.UriKind.RelativeOrAbsolute && uriKind != global::System.UriKind.Absolute && uriKind != global::System.UriKind.Relative)
			{
				string text = global::Locale.GetText("Invalid UriKind value '{0}'.", new object[] { uriKind });
				throw new ArgumentException(text);
			}
			this.source = uriString;
			if (this.ParseNoExceptions(uriKind, uriString) != null)
			{
				success = false;
			}
			else
			{
				success = true;
				switch (uriKind)
				{
				case global::System.UriKind.RelativeOrAbsolute:
					break;
				case global::System.UriKind.Absolute:
					if (!this.IsAbsoluteUri)
					{
						success = false;
					}
					break;
				case global::System.UriKind.Relative:
					if (this.IsAbsoluteUri)
					{
						success = false;
					}
					break;
				default:
					success = false;
					break;
				}
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Uri" /> class based on the combination of a specified base <see cref="T:System.Uri" /> instance and a relative <see cref="T:System.Uri" /> instance.</summary>
		/// <param name="baseUri">An absolute <see cref="T:System.Uri" /> that is the base for the new <see cref="T:System.Uri" /> instance. </param>
		/// <param name="relativeUri">A relative <see cref="T:System.Uri" /> instance that is combined with <paramref name="baseUri" />. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="baseUri" /> is null.-or- <paramref name="baseUri" /> is not an absolute <see cref="T:System.Uri" /> instance. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="baseUri" /> is not an absolute <see cref="T:System.Uri" /> instance. </exception>
		/// <exception cref="T:System.UriFormatException">The URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is empty or contains only spaces.-or- The scheme specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is not valid.-or- The URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> contains too many slashes.-or- The password specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is not valid.-or- The host name specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is not valid.-or- The file name specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is not valid. -or- The user name specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is not valid.-or- The host or authority name specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> cannot be terminated by backslashes.-or- The port number specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is not valid or cannot be parsed.-or- The length of the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> exceeds 65519 characters.-or- The length of the scheme specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> exceeds 1023 characters.-or- There is an invalid character sequence in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" />.-or- The MS-DOS path specified in <paramref name="uriString" /> must start with c:\\.</exception>
		// Token: 0x06002BAF RID: 11183 RVA: 0x0008C6DC File Offset: 0x0008A8DC
		public Uri(global::System.Uri baseUri, global::System.Uri relativeUri)
		{
			this.scheme = string.Empty;
			this.host = string.Empty;
			this.port = -1;
			this.path = string.Empty;
			this.query = string.Empty;
			this.fragment = string.Empty;
			this.userinfo = string.Empty;
			this.isAbsoluteUri = true;
			base..ctor();
			this.Merge(baseUri, (!(relativeUri == null)) ? relativeUri.OriginalString : string.Empty);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Uri" /> class with the specified URI, with explicit control of character escaping.</summary>
		/// <param name="uriString">The URI. </param>
		/// <param name="dontEscape">true if <paramref name="uriString" /> is completely escaped; otherwise, false. See Remarks. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="uriString" /> is null. </exception>
		/// <exception cref="T:System.UriFormatException">
		///   <paramref name="uriString" /> is empty or contains only spaces.-or- The scheme specified in <paramref name="uriString" /> is not valid.-or- <paramref name="uriString" /> contains too many slashes.-or- The password specified in <paramref name="uriString" /> is not valid.-or- The host name specified in <paramref name="uriString" /> is not valid.-or- The file name specified in <paramref name="uriString" /> is not valid. -or- The user name specified in <paramref name="uriString" /> is not valid.-or- The host or authority name specified in <paramref name="uriString" /> cannot be terminated by backslashes.-or- The port number specified in <paramref name="uriString" /> is not valid or cannot be parsed.-or- The length of <paramref name="uriString" /> exceeds 65519 characters.-or- The length of the scheme specified in <paramref name="uriString" /> exceeds 1023 characters.-or- There is an invalid character sequence in <paramref name="uriString" />.-or- The MS-DOS path specified in <paramref name="uriString" /> must start with c:\\.</exception>
		// Token: 0x06002BB0 RID: 11184 RVA: 0x0008C764 File Offset: 0x0008A964
		[Obsolete]
		public Uri(string uriString, bool dontEscape)
		{
			this.scheme = string.Empty;
			this.host = string.Empty;
			this.port = -1;
			this.path = string.Empty;
			this.query = string.Empty;
			this.fragment = string.Empty;
			this.userinfo = string.Empty;
			this.isAbsoluteUri = true;
			base..ctor();
			this.userEscaped = dontEscape;
			this.source = uriString;
			this.ParseUri(global::System.UriKind.Absolute);
			if (!this.isAbsoluteUri)
			{
				throw new global::System.UriFormatException("Invalid URI: The format of the URI could not be determined: " + uriString);
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Uri" /> class based on the specified base URI and relative URI string.</summary>
		/// <param name="baseUri">The base URI. </param>
		/// <param name="relativeUri">The relative URI to add to the base URI. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="uriString" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="baseUri" /> is not an absolute <see cref="T:System.Uri" /> instance. </exception>
		/// <exception cref="T:System.UriFormatException">The URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is empty or contains only spaces.-or- The scheme specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is not valid.-or- The URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> contains too many slashes.-or- The password specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is not valid.-or- The host name specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is not valid.-or- The file name specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is not valid. -or- The user name specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is not valid.-or- The host or authority name specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> cannot be terminated by backslashes.-or- The port number specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is not valid or cannot be parsed.-or- The length of the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> exceeds 65519 characters.-or- The length of the scheme specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> exceeds 1023 characters.-or- There is an invalid character sequence in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" />.-or- The MS-DOS path specified in <paramref name="uriString" /> must start with c:\\.</exception>
		// Token: 0x06002BB1 RID: 11185 RVA: 0x0008C7F8 File Offset: 0x0008A9F8
		public Uri(global::System.Uri baseUri, string relativeUri)
		{
			this.scheme = string.Empty;
			this.host = string.Empty;
			this.port = -1;
			this.path = string.Empty;
			this.query = string.Empty;
			this.fragment = string.Empty;
			this.userinfo = string.Empty;
			this.isAbsoluteUri = true;
			base..ctor();
			this.Merge(baseUri, relativeUri);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Uri" /> class based on the specified base and relative URIs, with explicit control of character escaping.</summary>
		/// <param name="baseUri">The base URI. </param>
		/// <param name="relativeUri">The relative URI to add to the base URI. </param>
		/// <param name="dontEscape">true if <paramref name="uriString" /> is completely escaped; otherwise, false. See Remarks. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="uriString" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="baseUri" /> is not an absolute <see cref="T:System.Uri" /> instance. </exception>
		/// <exception cref="T:System.UriFormatException">The URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is empty or contains only spaces.-or- The scheme specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is not valid.-or- The URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> contains too many slashes.-or- The password specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is not valid.-or- The host name specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is not valid.-or- The file name specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is not valid. -or- The user name specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is not valid.-or- The host or authority name specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> cannot be terminated by backslashes.-or- The port number specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is not valid or cannot be parsed.-or- The length of the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> exceeds 65519 characters.-or- The length of the scheme specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> exceeds 1023 characters.-or- There is an invalid character sequence in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" />.-or- The MS-DOS path specified in <paramref name="uriString" /> must start with c:\\.</exception>
		// Token: 0x06002BB2 RID: 11186 RVA: 0x0008C864 File Offset: 0x0008AA64
		[Obsolete("dontEscape is always false")]
		public Uri(global::System.Uri baseUri, string relativeUri, bool dontEscape)
		{
			this.scheme = string.Empty;
			this.host = string.Empty;
			this.port = -1;
			this.path = string.Empty;
			this.query = string.Empty;
			this.fragment = string.Empty;
			this.userinfo = string.Empty;
			this.isAbsoluteUri = true;
			base..ctor();
			this.userEscaped = dontEscape;
			this.Merge(baseUri, relativeUri);
		}

		/// <summary>Returns the data needed to serialize the current instance.</summary>
		/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object containing the information required to serialize the <see cref="T:System.Uri" />.</param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object containing the source and destination of the serialized stream associated with the <see cref="T:System.Uri" />.</param>
		// Token: 0x06002BB4 RID: 11188 RVA: 0x0001E5DC File Offset: 0x0001C7DC
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("AbsoluteUri", this.AbsoluteUri);
		}

		// Token: 0x06002BB5 RID: 11189 RVA: 0x0008CA54 File Offset: 0x0008AC54
		private void Merge(global::System.Uri baseUri, string relativeUri)
		{
			if (baseUri == null)
			{
				throw new ArgumentNullException("baseUri");
			}
			if (!baseUri.IsAbsoluteUri)
			{
				throw new ArgumentOutOfRangeException("baseUri");
			}
			if (relativeUri == null)
			{
				relativeUri = string.Empty;
			}
			if (relativeUri.Length >= 2 && relativeUri[0] == '\\' && relativeUri[1] == '\\')
			{
				this.source = relativeUri;
				this.ParseUri(global::System.UriKind.Absolute);
				return;
			}
			int num = relativeUri.IndexOf(':');
			if (num != -1)
			{
				int num2 = relativeUri.IndexOfAny(new char[] { '/', '\\', '?' });
				if (num2 > num || num2 < 0)
				{
					if (string.CompareOrdinal(baseUri.Scheme, 0, relativeUri, 0, num) != 0 || !global::System.Uri.IsPredefinedScheme(baseUri.Scheme) || (relativeUri.Length > num + 1 && relativeUri[num + 1] == '/'))
					{
						this.source = relativeUri;
						this.ParseUri(global::System.UriKind.Absolute);
						return;
					}
					relativeUri = relativeUri.Substring(num + 1);
				}
			}
			this.scheme = baseUri.scheme;
			this.host = baseUri.host;
			this.port = baseUri.port;
			this.userinfo = baseUri.userinfo;
			this.isUnc = baseUri.isUnc;
			this.isUnixFilePath = baseUri.isUnixFilePath;
			this.isOpaquePart = baseUri.isOpaquePart;
			if (relativeUri == string.Empty)
			{
				this.path = baseUri.path;
				this.query = baseUri.query;
				this.fragment = baseUri.fragment;
				return;
			}
			num = relativeUri.IndexOf('#');
			if (num != -1)
			{
				if (this.userEscaped)
				{
					this.fragment = relativeUri.Substring(num);
				}
				else
				{
					this.fragment = "#" + global::System.Uri.EscapeString(relativeUri.Substring(num + 1));
				}
				relativeUri = relativeUri.Substring(0, num);
			}
			num = relativeUri.IndexOf('?');
			if (num != -1)
			{
				this.query = relativeUri.Substring(num);
				if (!this.userEscaped)
				{
					this.query = global::System.Uri.EscapeString(this.query);
				}
				relativeUri = relativeUri.Substring(0, num);
			}
			if (relativeUri.Length > 0 && relativeUri[0] == '/')
			{
				if (relativeUri.Length > 1 && relativeUri[1] == '/')
				{
					this.source = this.scheme + ':' + relativeUri;
					this.ParseUri(global::System.UriKind.Absolute);
					return;
				}
				this.path = relativeUri;
				if (!this.userEscaped)
				{
					this.path = global::System.Uri.EscapeString(this.path);
				}
				return;
			}
			else
			{
				this.path = baseUri.path;
				if (relativeUri.Length > 0 || this.query.Length > 0)
				{
					num = this.path.LastIndexOf('/');
					if (num >= 0)
					{
						this.path = this.path.Substring(0, num + 1);
					}
				}
				if (relativeUri.Length == 0)
				{
					return;
				}
				this.path += relativeUri;
				int num3 = 0;
				for (;;)
				{
					num = this.path.IndexOf("./", num3);
					if (num == -1)
					{
						break;
					}
					if (num == 0)
					{
						this.path = this.path.Remove(0, 2);
					}
					else if (this.path[num - 1] != '.')
					{
						this.path = this.path.Remove(num, 2);
					}
					else
					{
						num3 = num + 1;
					}
				}
				if (this.path.Length > 1 && this.path[this.path.Length - 1] == '.' && this.path[this.path.Length - 2] == '/')
				{
					this.path = this.path.Remove(this.path.Length - 1, 1);
				}
				num3 = 0;
				for (;;)
				{
					num = this.path.IndexOf("/../", num3);
					if (num == -1)
					{
						break;
					}
					if (num == 0)
					{
						num3 = 3;
					}
					else
					{
						int num4 = this.path.LastIndexOf('/', num - 1);
						if (num4 == -1)
						{
							num3 = num + 1;
						}
						else if (this.path.Substring(num4 + 1, num - num4 - 1) != "..")
						{
							this.path = this.path.Remove(num4 + 1, num - num4 + 3);
						}
						else
						{
							num3 = num + 1;
						}
					}
				}
				if (this.path.Length > 3 && this.path.EndsWith("/.."))
				{
					num = this.path.LastIndexOf('/', this.path.Length - 4);
					if (num != -1 && this.path.Substring(num + 1, this.path.Length - num - 4) != "..")
					{
						this.path = this.path.Remove(num + 1, this.path.Length - num - 1);
					}
				}
				if (!this.userEscaped)
				{
					this.path = global::System.Uri.EscapeString(this.path);
				}
				return;
			}
		}

		/// <summary>Gets the absolute path of the URI.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the absolute path to the resource.</returns>
		/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x06002BB6 RID: 11190 RVA: 0x0008CFA0 File Offset: 0x0008B1A0
		public string AbsolutePath
		{
			get
			{
				this.EnsureAbsoluteUri();
				string text = this.Scheme;
				if (text != null)
				{
					if (global::System.Uri.<>f__switch$map1C == null)
					{
						global::System.Uri.<>f__switch$map1C = new Dictionary<string, int>(2)
						{
							{ "mailto", 0 },
							{ "file", 0 }
						};
					}
					int num;
					if (global::System.Uri.<>f__switch$map1C.TryGetValue(text, out num))
					{
						if (num == 0)
						{
							return this.path;
						}
					}
				}
				if (this.path.Length != 0)
				{
					return this.path;
				}
				string text2 = this.Scheme + global::System.Uri.SchemeDelimiter;
				if (this.path.StartsWith(text2))
				{
					return "/";
				}
				return string.Empty;
			}
		}

		/// <summary>Gets the absolute URI.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the entire URI.</returns>
		/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x06002BB7 RID: 11191 RVA: 0x0008D058 File Offset: 0x0008B258
		public string AbsoluteUri
		{
			get
			{
				this.EnsureAbsoluteUri();
				if (this.cachedAbsoluteUri == null)
				{
					this.cachedAbsoluteUri = this.GetLeftPart(global::System.UriPartial.Path);
					if (this.query.Length > 0)
					{
						this.cachedAbsoluteUri += this.query;
					}
					if (this.fragment.Length > 0)
					{
						this.cachedAbsoluteUri += this.fragment;
					}
				}
				return this.cachedAbsoluteUri;
			}
		}

		/// <summary>Gets the Domain Name System (DNS) host name or IP address and the port number for a server.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the authority component of the URI represented by this instance.</returns>
		/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x06002BB8 RID: 11192 RVA: 0x0008D0DC File Offset: 0x0008B2DC
		public string Authority
		{
			get
			{
				this.EnsureAbsoluteUri();
				return (global::System.Uri.GetDefaultPort(this.Scheme) != this.port) ? (this.host + ":" + this.port) : this.host;
			}
		}

		/// <summary>Gets the escaped URI fragment.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains any URI fragment information.</returns>
		/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs. </exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x06002BB9 RID: 11193 RVA: 0x0001E5EF File Offset: 0x0001C7EF
		public string Fragment
		{
			get
			{
				this.EnsureAbsoluteUri();
				return this.fragment;
			}
		}

		/// <summary>Gets the host component of this instance.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the host name. This is usually the DNS host name or IP address of the server.</returns>
		/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x06002BBA RID: 11194 RVA: 0x0001E5FD File Offset: 0x0001C7FD
		public string Host
		{
			get
			{
				this.EnsureAbsoluteUri();
				return this.host;
			}
		}

		/// <summary>Gets the type of the host name specified in the URI.</summary>
		/// <returns>A member of the <see cref="T:System.UriHostNameType" /> enumeration.</returns>
		/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x06002BBB RID: 11195 RVA: 0x0008D12C File Offset: 0x0008B32C
		public global::System.UriHostNameType HostNameType
		{
			get
			{
				this.EnsureAbsoluteUri();
				global::System.UriHostNameType uriHostNameType = global::System.Uri.CheckHostName(this.Host);
				if (uriHostNameType != global::System.UriHostNameType.Unknown)
				{
					return uriHostNameType;
				}
				string text = this.Scheme;
				if (text != null)
				{
					if (global::System.Uri.<>f__switch$map1D == null)
					{
						global::System.Uri.<>f__switch$map1D = new Dictionary<string, int>(1) { { "mailto", 0 } };
					}
					int num;
					if (global::System.Uri.<>f__switch$map1D.TryGetValue(text, out num))
					{
						if (num == 0)
						{
							return global::System.UriHostNameType.Basic;
						}
					}
				}
				return (!this.IsFile) ? uriHostNameType : global::System.UriHostNameType.Basic;
			}
		}

		/// <summary>Gets whether the port value of the URI is the default for this scheme.</summary>
		/// <returns>A <see cref="T:System.Boolean" /> value that is true if the value in the <see cref="P:System.Uri.Port" /> property is the default port for this scheme; otherwise, false.</returns>
		/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x06002BBC RID: 11196 RVA: 0x0001E60B File Offset: 0x0001C80B
		public bool IsDefaultPort
		{
			get
			{
				this.EnsureAbsoluteUri();
				return global::System.Uri.GetDefaultPort(this.Scheme) == this.port;
			}
		}

		/// <summary>Gets a value indicating whether the specified <see cref="T:System.Uri" /> is a file URI.</summary>
		/// <returns>A <see cref="T:System.Boolean" /> value that is true if the <see cref="T:System.Uri" /> is a file URI; otherwise, false.</returns>
		/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x06002BBD RID: 11197 RVA: 0x0001E626 File Offset: 0x0001C826
		public bool IsFile
		{
			get
			{
				this.EnsureAbsoluteUri();
				return this.Scheme == global::System.Uri.UriSchemeFile;
			}
		}

		/// <summary>Gets whether the specified <see cref="T:System.Uri" /> references the local host.</summary>
		/// <returns>A <see cref="T:System.Boolean" /> value that is true if this <see cref="T:System.Uri" /> references the local host; otherwise, false.</returns>
		/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs. </exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x06002BBE RID: 11198 RVA: 0x0008D1B4 File Offset: 0x0008B3B4
		public bool IsLoopback
		{
			get
			{
				this.EnsureAbsoluteUri();
				if (this.Host.Length == 0)
				{
					return this.IsFile;
				}
				global::System.Net.IPAddress ipaddress;
				global::System.Net.IPv6Address pv6Address;
				return this.host == "loopback" || this.host == "localhost" || (global::System.Net.IPAddress.TryParse(this.host, out ipaddress) && global::System.Net.IPAddress.Loopback.Equals(ipaddress)) || (global::System.Net.IPv6Address.TryParse(this.host, out pv6Address) && global::System.Net.IPv6Address.IsLoopback(pv6Address));
			}
		}

		/// <summary>Gets whether the specified <see cref="T:System.Uri" /> is a universal naming convention (UNC) path.</summary>
		/// <returns>A <see cref="T:System.Boolean" /> value that is true if the <see cref="T:System.Uri" /> is a UNC path; otherwise, false.</returns>
		/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs. </exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x06002BBF RID: 11199 RVA: 0x0001E63E File Offset: 0x0001C83E
		public bool IsUnc
		{
			get
			{
				this.EnsureAbsoluteUri();
				return this.isUnc;
			}
		}

		/// <summary>Gets a local operating-system representation of a file name.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the local operating-system representation of a file name.</returns>
		/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs. </exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x06002BC0 RID: 11200 RVA: 0x0008D250 File Offset: 0x0008B450
		public string LocalPath
		{
			get
			{
				this.EnsureAbsoluteUri();
				if (this.cachedLocalPath != null)
				{
					return this.cachedLocalPath;
				}
				if (!this.IsFile)
				{
					return this.AbsolutePath;
				}
				bool flag = this.path.Length > 3 && this.path[1] == ':' && (this.path[2] == '\\' || this.path[2] == '/');
				if (!this.IsUnc)
				{
					string text = this.Unescape(this.path);
					bool flag2 = flag;
					if (flag2)
					{
						this.cachedLocalPath = text.Replace('/', '\\');
					}
					else
					{
						this.cachedLocalPath = text;
					}
				}
				else if (this.path.Length > 1 && this.path[1] == ':')
				{
					this.cachedLocalPath = this.Unescape(this.path.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar));
				}
				else if (Path.DirectorySeparatorChar == '\\')
				{
					string text2 = this.host;
					if (this.path.Length > 0 && (this.path.Length > 1 || this.path[0] != '/'))
					{
						text2 += this.path.Replace('/', '\\');
					}
					this.cachedLocalPath = "\\\\" + this.Unescape(text2);
				}
				else
				{
					this.cachedLocalPath = this.Unescape(this.path);
				}
				if (this.cachedLocalPath.Length == 0)
				{
					this.cachedLocalPath = Path.DirectorySeparatorChar.ToString();
				}
				return this.cachedLocalPath;
			}
		}

		/// <summary>Gets the <see cref="P:System.Uri.AbsolutePath" /> and <see cref="P:System.Uri.Query" /> properties separated by a question mark (?).</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the <see cref="P:System.Uri.AbsolutePath" /> and <see cref="P:System.Uri.Query" /> properties separated by a question mark (?).</returns>
		/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs. </exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x06002BC1 RID: 11201 RVA: 0x0001E64C File Offset: 0x0001C84C
		public string PathAndQuery
		{
			get
			{
				this.EnsureAbsoluteUri();
				return this.path + this.Query;
			}
		}

		/// <summary>Gets the port number of this URI.</summary>
		/// <returns>An <see cref="T:System.Int32" /> value that contains the port number for this URI.</returns>
		/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs. </exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x06002BC2 RID: 11202 RVA: 0x0001E665 File Offset: 0x0001C865
		public int Port
		{
			get
			{
				this.EnsureAbsoluteUri();
				return this.port;
			}
		}

		/// <summary>Gets any query information included in the specified URI.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains any query information included in the specified URI.</returns>
		/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs. </exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x06002BC3 RID: 11203 RVA: 0x0001E673 File Offset: 0x0001C873
		public string Query
		{
			get
			{
				this.EnsureAbsoluteUri();
				return this.query;
			}
		}

		/// <summary>Gets the scheme name for this URI.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the scheme for this URI, converted to lowercase.</returns>
		/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs. </exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06002BC4 RID: 11204 RVA: 0x0001E681 File Offset: 0x0001C881
		public string Scheme
		{
			get
			{
				this.EnsureAbsoluteUri();
				return this.scheme;
			}
		}

		/// <summary>Gets an array containing the path segments that make up the specified URI.</summary>
		/// <returns>A <see cref="T:System.String" /> array that contains the path segments that make up the specified URI.</returns>
		/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs. </exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x06002BC5 RID: 11205 RVA: 0x0008D418 File Offset: 0x0008B618
		public string[] Segments
		{
			get
			{
				this.EnsureAbsoluteUri();
				if (this.segments != null)
				{
					return this.segments;
				}
				if (this.path.Length == 0)
				{
					this.segments = new string[0];
					return this.segments;
				}
				string[] array = this.path.Split(new char[] { '/' });
				this.segments = array;
				bool flag = this.path.EndsWith("/");
				if (array.Length > 0 && flag)
				{
					string[] array2 = new string[array.Length - 1];
					Array.Copy(array, 0, array2, 0, array.Length - 1);
					array = array2;
				}
				int i = 0;
				if (this.IsFile && this.path.Length > 1 && this.path[1] == ':')
				{
					string[] array3 = new string[array.Length + 1];
					Array.Copy(array, 1, array3, 2, array.Length - 1);
					array = array3;
					array[0] = this.path.Substring(0, 2);
					array[1] = string.Empty;
					i++;
				}
				int num = array.Length;
				while (i < num)
				{
					if (i != num - 1 || flag)
					{
						string[] array4 = array;
						int num2 = i;
						array4[num2] += '/';
					}
					i++;
				}
				this.segments = array;
				return this.segments;
			}
		}

		/// <summary>Indicates that the URI string was completely escaped before the <see cref="T:System.Uri" /> instance was created.</summary>
		/// <returns>A <see cref="T:System.Boolean" /> value that is true if the <paramref name="dontEscape" /> parameter was set to true when the <see cref="T:System.Uri" /> instance was created; otherwise, false.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x06002BC6 RID: 11206 RVA: 0x0001E68F File Offset: 0x0001C88F
		public bool UserEscaped
		{
			get
			{
				return this.userEscaped;
			}
		}

		/// <summary>Gets the user name, password, or other user-specific information associated with the specified URI.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the user information associated with the URI. The returned value does not include the '@' character reserved for delimiting the user information part of the URI.</returns>
		/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x06002BC7 RID: 11207 RVA: 0x0001E697 File Offset: 0x0001C897
		public string UserInfo
		{
			get
			{
				this.EnsureAbsoluteUri();
				return this.userinfo;
			}
		}

		/// <summary>Gets an unescaped host name that is safe to use for DNS resolution.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the unescaped host part of the URI that is suitable for DNS resolution; or the original unescaped host string, if it is already suitable for resolution.</returns>
		/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs. </exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x06002BC8 RID: 11208 RVA: 0x0001E6A5 File Offset: 0x0001C8A5
		[global::System.MonoTODO("add support for IPv6 address")]
		public string DnsSafeHost
		{
			get
			{
				this.EnsureAbsoluteUri();
				return this.Unescape(this.Host);
			}
		}

		/// <summary>Gets whether the <see cref="T:System.Uri" /> instance is absolute.</summary>
		/// <returns>A <see cref="T:System.Boolean" /> value that is true if the <see cref="T:System.Uri" /> instance is absolute; otherwise, false.</returns>
		/// <filterpriority>1</filterpriority>
		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x06002BC9 RID: 11209 RVA: 0x0001E6B9 File Offset: 0x0001C8B9
		public bool IsAbsoluteUri
		{
			get
			{
				return this.isAbsoluteUri;
			}
		}

		/// <summary>Gets the original URI string that was passed to the <see cref="T:System.Uri" /> constructor.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the exact URI specified when this instance was constructed; otherwise, <see cref="F:System.String.Empty" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x06002BCA RID: 11210 RVA: 0x0001E6C1 File Offset: 0x0001C8C1
		public string OriginalString
		{
			get
			{
				return (this.source == null) ? this.ToString() : this.source;
			}
		}

		/// <summary>Determines whether the specified host name is a valid DNS name.</summary>
		/// <returns>A <see cref="T:System.UriHostNameType" /> that indicates the type of the host name. If the type of the host name cannot be determined or if the host name is null or a zero-length string, this method returns <see cref="F:System.UriHostNameType.Unknown" />.</returns>
		/// <param name="name">The host name to validate. This can be an IPv4 or IPv6 address or an Internet host name. </param>
		/// <filterpriority>1</filterpriority>
		// Token: 0x06002BCB RID: 11211 RVA: 0x0008D570 File Offset: 0x0008B770
		public static global::System.UriHostNameType CheckHostName(string name)
		{
			if (name == null || name.Length == 0)
			{
				return global::System.UriHostNameType.Unknown;
			}
			if (global::System.Uri.IsIPv4Address(name))
			{
				return global::System.UriHostNameType.IPv4;
			}
			if (global::System.Uri.IsDomainAddress(name))
			{
				return global::System.UriHostNameType.Dns;
			}
			global::System.Net.IPv6Address pv6Address;
			if (global::System.Net.IPv6Address.TryParse(name, out pv6Address))
			{
				return global::System.UriHostNameType.IPv6;
			}
			return global::System.UriHostNameType.Unknown;
		}

		// Token: 0x06002BCC RID: 11212 RVA: 0x0008D5BC File Offset: 0x0008B7BC
		internal static bool IsIPv4Address(string name)
		{
			string[] array = name.Split(new char[] { '.' });
			if (array.Length != 4)
			{
				return false;
			}
			for (int i = 0; i < 4; i++)
			{
				if (array[i].Length == 0)
				{
					return false;
				}
				uint num;
				if (!uint.TryParse(array[i], out num))
				{
					return false;
				}
				if (num > 255U)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06002BCD RID: 11213 RVA: 0x0008D628 File Offset: 0x0008B828
		internal static bool IsDomainAddress(string name)
		{
			int length = name.Length;
			int num = 0;
			for (int i = 0; i < length; i++)
			{
				char c = name[i];
				if (num == 0)
				{
					if (!char.IsLetterOrDigit(c))
					{
						return false;
					}
				}
				else if (c == '.')
				{
					num = 0;
				}
				else if (!char.IsLetterOrDigit(c) && c != '-' && c != '_')
				{
					return false;
				}
				if (++num == 64)
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>Converts the internally stored URI to canonical form.</summary>
		/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this method is valid only for absolute URIs. </exception>
		/// <exception cref="T:System.UriFormatException">The URI is incorrectly formed.</exception>
		// Token: 0x06002BCE RID: 11214 RVA: 0x000029F5 File Offset: 0x00000BF5
		[Obsolete("This method does nothing, it has been obsoleted")]
		protected virtual void Canonicalize()
		{
		}

		/// <summary>Calling this method has no effect.</summary>
		// Token: 0x06002BCF RID: 11215 RVA: 0x000029F5 File Offset: 0x00000BF5
		[Obsolete]
		[global::System.MonoTODO("Find out what this should do")]
		protected virtual void CheckSecurity()
		{
		}

		/// <summary>Determines whether the specified scheme name is valid.</summary>
		/// <returns>A <see cref="T:System.Boolean" /> value that is true if the scheme name is valid; otherwise, false.</returns>
		/// <param name="schemeName">The scheme name to validate. </param>
		/// <filterpriority>1</filterpriority>
		// Token: 0x06002BD0 RID: 11216 RVA: 0x0008D6AC File Offset: 0x0008B8AC
		public static bool CheckSchemeName(string schemeName)
		{
			if (schemeName == null || schemeName.Length == 0)
			{
				return false;
			}
			if (!global::System.Uri.IsAlpha(schemeName[0]))
			{
				return false;
			}
			int length = schemeName.Length;
			for (int i = 1; i < length; i++)
			{
				char c = schemeName[i];
				if (!char.IsDigit(c) && !global::System.Uri.IsAlpha(c) && c != '.' && c != '+' && c != '-')
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06002BD1 RID: 11217 RVA: 0x0008D734 File Offset: 0x0008B934
		private static bool IsAlpha(char c)
		{
			return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
		}

		/// <summary>Compares two <see cref="T:System.Uri" /> instances for equality.</summary>
		/// <returns>A <see cref="T:System.Boolean" /> value that is true if the two instances represent the same URI; otherwise, false.</returns>
		/// <param name="comparand">The <see cref="T:System.Uri" /> instance or a URI identifier to compare with the current instance. </param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x06002BD2 RID: 11218 RVA: 0x0008D76C File Offset: 0x0008B96C
		public override bool Equals(object comparant)
		{
			if (comparant == null)
			{
				return false;
			}
			global::System.Uri uri = comparant as global::System.Uri;
			if (uri == null)
			{
				string text = comparant as string;
				if (text == null)
				{
					return false;
				}
				uri = new global::System.Uri(text);
			}
			return this.InternalEquals(uri);
		}

		// Token: 0x06002BD3 RID: 11219 RVA: 0x0008D7AC File Offset: 0x0008B9AC
		private bool InternalEquals(global::System.Uri uri)
		{
			if (this.isAbsoluteUri != uri.isAbsoluteUri)
			{
				return false;
			}
			if (!this.isAbsoluteUri)
			{
				return this.source == uri.source;
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			return this.scheme.ToLower(invariantCulture) == uri.scheme.ToLower(invariantCulture) && this.host.ToLower(invariantCulture) == uri.host.ToLower(invariantCulture) && this.port == uri.port && this.query == uri.query && this.path == uri.path;
		}

		/// <summary>Gets the hash code for the URI.</summary>
		/// <returns>An <see cref="T:System.Int32" /> containing the hash value generated for this URI.</returns>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x06002BD4 RID: 11220 RVA: 0x0008D870 File Offset: 0x0008BA70
		public override int GetHashCode()
		{
			if (this.cachedHashCode == 0)
			{
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				if (this.isAbsoluteUri)
				{
					this.cachedHashCode = this.scheme.ToLower(invariantCulture).GetHashCode() ^ this.host.ToLower(invariantCulture).GetHashCode() ^ this.port ^ this.query.GetHashCode() ^ this.path.GetHashCode();
				}
				else
				{
					this.cachedHashCode = this.source.GetHashCode();
				}
			}
			return this.cachedHashCode;
		}

		/// <summary>Gets the specified portion of a <see cref="T:System.Uri" /> instance.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the specified portion of the <see cref="T:System.Uri" /> instance.</returns>
		/// <param name="part">One of the <see cref="T:System.UriPartial" /> values that specifies the end of the URI portion to return. </param>
		/// <exception cref="T:System.InvalidOperationException">The current <see cref="T:System.Uri" /> instance is not an absolute instance. </exception>
		/// <exception cref="T:System.ArgumentException">The specified <paramref name="part" /> is not valid. </exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x06002BD5 RID: 11221 RVA: 0x0008D900 File Offset: 0x0008BB00
		public string GetLeftPart(global::System.UriPartial part)
		{
			this.EnsureAbsoluteUri();
			switch (part)
			{
			case global::System.UriPartial.Scheme:
				return this.scheme + this.GetOpaqueWiseSchemeDelimiter();
			case global::System.UriPartial.Authority:
			{
				if (this.scheme == global::System.Uri.UriSchemeMailto || this.scheme == global::System.Uri.UriSchemeNews)
				{
					return string.Empty;
				}
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(this.scheme);
				stringBuilder.Append(this.GetOpaqueWiseSchemeDelimiter());
				if (this.path.Length > 1 && this.path[1] == ':' && global::System.Uri.UriSchemeFile == this.scheme)
				{
					stringBuilder.Append('/');
				}
				if (this.userinfo.Length > 0)
				{
					stringBuilder.Append(this.userinfo).Append('@');
				}
				stringBuilder.Append(this.host);
				int num = global::System.Uri.GetDefaultPort(this.scheme);
				if (this.port != -1 && this.port != num)
				{
					stringBuilder.Append(':').Append(this.port);
				}
				return stringBuilder.ToString();
			}
			case global::System.UriPartial.Path:
			{
				StringBuilder stringBuilder2 = new StringBuilder();
				stringBuilder2.Append(this.scheme);
				stringBuilder2.Append(this.GetOpaqueWiseSchemeDelimiter());
				if (this.path.Length > 1 && this.path[1] == ':' && global::System.Uri.UriSchemeFile == this.scheme)
				{
					stringBuilder2.Append('/');
				}
				if (this.userinfo.Length > 0)
				{
					stringBuilder2.Append(this.userinfo).Append('@');
				}
				stringBuilder2.Append(this.host);
				int num = global::System.Uri.GetDefaultPort(this.scheme);
				if (this.port != -1 && this.port != num)
				{
					stringBuilder2.Append(':').Append(this.port);
				}
				if (this.path.Length > 0)
				{
					string text = this.Scheme;
					if (text != null)
					{
						if (global::System.Uri.<>f__switch$map1E == null)
						{
							global::System.Uri.<>f__switch$map1E = new Dictionary<string, int>(2)
							{
								{ "mailto", 0 },
								{ "news", 0 }
							};
						}
						int num2;
						if (global::System.Uri.<>f__switch$map1E.TryGetValue(text, out num2))
						{
							if (num2 == 0)
							{
								stringBuilder2.Append(this.path);
								goto IL_02A6;
							}
						}
					}
					stringBuilder2.Append(global::System.Uri.Reduce(this.path, global::System.Uri.CompactEscaped(this.Scheme)));
				}
				IL_02A6:
				return stringBuilder2.ToString();
			}
			default:
				return null;
			}
		}

		/// <summary>Gets the decimal value of a hexadecimal digit.</summary>
		/// <returns>An <see cref="T:System.Int32" /> value that contains a number from 0 to 15 that corresponds to the specified hexadecimal digit.</returns>
		/// <param name="digit">The hexadecimal digit (0-9, a-f, A-F) to convert. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="digit" /> is not a valid hexadecimal digit (0-9, a-f, A-F). </exception>
		/// <filterpriority>1</filterpriority>
		// Token: 0x06002BD6 RID: 11222 RVA: 0x0008DBBC File Offset: 0x0008BDBC
		public static int FromHex(char digit)
		{
			if ('0' <= digit && digit <= '9')
			{
				return (int)(digit - '0');
			}
			if ('a' <= digit && digit <= 'f')
			{
				return (int)(digit - 'a' + '\n');
			}
			if ('A' <= digit && digit <= 'F')
			{
				return (int)(digit - 'A' + '\n');
			}
			throw new ArgumentException("digit");
		}

		/// <summary>Converts a specified character into its hexadecimal equivalent.</summary>
		/// <returns>The hexadecimal representation of the specified character.</returns>
		/// <param name="character">The character to convert to hexadecimal representation. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="character" /> is greater than 255. </exception>
		/// <filterpriority>1</filterpriority>
		// Token: 0x06002BD7 RID: 11223 RVA: 0x0008DC18 File Offset: 0x0008BE18
		public static string HexEscape(char character)
		{
			if (character > 'ÿ')
			{
				throw new ArgumentOutOfRangeException("character");
			}
			return "%" + global::System.Uri.hexUpperChars[(int)((character & 'ð') >> 4)] + global::System.Uri.hexUpperChars[(int)(character & '\u000f')];
		}

		/// <summary>Converts a specified hexadecimal representation of a character to the character.</summary>
		/// <returns>The character represented by the hexadecimal encoding at position <paramref name="index" />. If the character at <paramref name="index" /> is not hexadecimal encoded, the character at <paramref name="index" /> is returned. The value of <paramref name="index" /> is incremented to point to the character following the one returned.</returns>
		/// <param name="pattern">The hexadecimal representation of a character. </param>
		/// <param name="index">The location in <paramref name="pattern" /> where the hexadecimal representation of a character begins. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than 0 or greater than or equal to the number of characters in <paramref name="pattern" />. </exception>
		/// <filterpriority>1</filterpriority>
		// Token: 0x06002BD8 RID: 11224 RVA: 0x0008DC70 File Offset: 0x0008BE70
		public static char HexUnescape(string pattern, ref int index)
		{
			if (pattern == null)
			{
				throw new ArgumentException("pattern");
			}
			if (index < 0 || index >= pattern.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (!global::System.Uri.IsHexEncoding(pattern, index))
			{
				return pattern[index++];
			}
			index++;
			int num = global::System.Uri.FromHex(pattern[index++]);
			int num2 = global::System.Uri.FromHex(pattern[index++]);
			return (char)((num << 4) | num2);
		}

		/// <summary>Determines whether a specified character is a valid hexadecimal digit.</summary>
		/// <returns>A <see cref="T:System.Boolean" /> value that is true if the character is a valid hexadecimal digit; otherwise false.</returns>
		/// <param name="character">The character to validate. </param>
		/// <filterpriority>1</filterpriority>
		// Token: 0x06002BD9 RID: 11225 RVA: 0x0001E6DF File Offset: 0x0001C8DF
		public static bool IsHexDigit(char digit)
		{
			return ('0' <= digit && digit <= '9') || ('a' <= digit && digit <= 'f') || ('A' <= digit && digit <= 'F');
		}

		/// <summary>Determines whether a character in a string is hexadecimal encoded.</summary>
		/// <returns>A <see cref="T:System.Boolean" /> value that is true if <paramref name="pattern" /> is hexadecimal encoded at the specified location; otherwise, false.</returns>
		/// <param name="pattern">The string to check. </param>
		/// <param name="index">The location in <paramref name="pattern" /> to check for hexadecimal encoding. </param>
		/// <filterpriority>1</filterpriority>
		// Token: 0x06002BDA RID: 11226 RVA: 0x0008DD04 File Offset: 0x0008BF04
		public static bool IsHexEncoding(string pattern, int index)
		{
			return index + 3 <= pattern.Length && (pattern[index++] == '%' && global::System.Uri.IsHexDigit(pattern[index++])) && global::System.Uri.IsHexDigit(pattern[index]);
		}

		/// <summary>Determines the difference between two <see cref="T:System.Uri" /> instances.</summary>
		/// <returns>If the hostname and scheme of this URI instance and <paramref name="toUri" /> are the same, then this method returns a relative <see cref="T:System.Uri" /> that, when appended to the current URI instance, yields <paramref name="toUri" />.If the hostname or scheme is different, then this method returns a <see cref="T:System.Uri" />  that represents the <paramref name="toUri" /> parameter.</returns>
		/// <param name="uri">The URI to compare to the current URI.</param>
		/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs. </exception>
		// Token: 0x06002BDB RID: 11227 RVA: 0x0008DD5C File Offset: 0x0008BF5C
		public global::System.Uri MakeRelativeUri(global::System.Uri uri)
		{
			if (uri == null)
			{
				throw new ArgumentNullException("uri");
			}
			if (this.Host != uri.Host || this.Scheme != uri.Scheme)
			{
				return uri;
			}
			string text = string.Empty;
			if (this.path != uri.path)
			{
				string[] array = this.Segments;
				string[] array2 = uri.Segments;
				int i = 0;
				int num = Math.Min(array.Length, array2.Length);
				while (i < num)
				{
					if (array[i] != array2[i])
					{
						break;
					}
					i++;
				}
				for (int j = i + 1; j < array.Length; j++)
				{
					text += "../";
				}
				for (int k = i; k < array2.Length; k++)
				{
					text += array2[k];
				}
			}
			uri.AppendQueryAndFragment(ref text);
			return new global::System.Uri(text, global::System.UriKind.Relative);
		}

		/// <summary>Determines the difference between two <see cref="T:System.Uri" /> instances.</summary>
		/// <returns>If the hostname and scheme of this URI instance and <paramref name="toUri" /> are the same, then this method returns a <see cref="T:System.String" /> that represents a relative URI that, when appended to the current URI instance, yields the <paramref name="toUri" /> parameter.If the hostname or scheme is different, then this method returns a <see cref="T:System.String" /> that represents the <paramref name="toUri" /> parameter.</returns>
		/// <param name="toUri">The URI to compare to the current URI. </param>
		/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this method is valid only for absolute URIs. </exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x06002BDC RID: 11228 RVA: 0x0008DE68 File Offset: 0x0008C068
		[Obsolete("Use MakeRelativeUri(Uri uri) instead.")]
		public string MakeRelative(global::System.Uri toUri)
		{
			if (this.Scheme != toUri.Scheme || this.Authority != toUri.Authority)
			{
				return toUri.ToString();
			}
			string text = string.Empty;
			if (this.path != toUri.path)
			{
				string[] array = this.Segments;
				string[] array2 = toUri.Segments;
				int i = 0;
				int num = Math.Min(array.Length, array2.Length);
				while (i < num)
				{
					if (array[i] != array2[i])
					{
						break;
					}
					i++;
				}
				for (int j = i + 1; j < array.Length; j++)
				{
					text += "../";
				}
				for (int k = i; k < array2.Length; k++)
				{
					text += array2[k];
				}
			}
			return text;
		}

		// Token: 0x06002BDD RID: 11229 RVA: 0x0008DF54 File Offset: 0x0008C154
		private void AppendQueryAndFragment(ref string result)
		{
			if (this.query.Length > 0)
			{
				string text = ((this.query[0] != '?') ? global::System.Uri.Unescape(this.query, false) : ('?' + global::System.Uri.Unescape(this.query.Substring(1), false)));
				result += text;
			}
			if (this.fragment.Length > 0)
			{
				result += this.fragment;
			}
		}

		/// <summary>Gets a canonical string representation for the specified <see cref="T:System.Uri" /> instance.</summary>
		/// <returns>A <see cref="T:System.String" /> instance that contains the unescaped canonical representation of the <see cref="T:System.Uri" /> instance. All characters are unescaped except #, ?, and %.</returns>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x06002BDE RID: 11230 RVA: 0x0008DFE0 File Offset: 0x0008C1E0
		public override string ToString()
		{
			if (this.cachedToString != null)
			{
				return this.cachedToString;
			}
			if (this.isAbsoluteUri)
			{
				this.cachedToString = global::System.Uri.Unescape(this.GetLeftPart(global::System.UriPartial.Path), true);
			}
			else
			{
				this.cachedToString = this.Unescape(this.path);
			}
			this.AppendQueryAndFragment(ref this.cachedToString);
			return this.cachedToString;
		}

		/// <summary>Returns the data needed to serialize the current instance.</summary>
		/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object containing the information required to serialize the <see cref="T:System.Uri" />.</param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object containing the source and destination of the serialized stream associated with the <see cref="T:System.Uri" />.</param>
		// Token: 0x06002BDF RID: 11231 RVA: 0x0001E5DC File Offset: 0x0001C7DC
		protected void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("AbsoluteUri", this.AbsoluteUri);
		}

		/// <summary>Converts any unsafe or reserved characters in the path component to their hexadecimal character representations.</summary>
		/// <exception cref="T:System.UriFormatException">The URI passed from the constructor is invalid. This exception can occur if a URI has too many characters or the URI is relative.</exception>
		// Token: 0x06002BE0 RID: 11232 RVA: 0x0001E717 File Offset: 0x0001C917
		[Obsolete]
		protected virtual void Escape()
		{
			this.path = global::System.Uri.EscapeString(this.path);
		}

		/// <summary>Converts a string to its escaped representation.</summary>
		/// <returns>The escaped representation of the string.</returns>
		/// <param name="str">The string to transform to its escaped representation. </param>
		// Token: 0x06002BE1 RID: 11233 RVA: 0x0001E72A File Offset: 0x0001C92A
		[Obsolete]
		protected static string EscapeString(string str)
		{
			return global::System.Uri.EscapeString(str, false, true, true);
		}

		// Token: 0x06002BE2 RID: 11234 RVA: 0x0008E048 File Offset: 0x0008C248
		internal static string EscapeString(string str, bool escapeReserved, bool escapeHex, bool escapeBrackets)
		{
			if (str == null)
			{
				return string.Empty;
			}
			StringBuilder stringBuilder = new StringBuilder();
			int length = str.Length;
			for (int i = 0; i < length; i++)
			{
				if (global::System.Uri.IsHexEncoding(str, i))
				{
					stringBuilder.Append(str.Substring(i, 3));
					i += 2;
				}
				else
				{
					byte[] bytes = Encoding.UTF8.GetBytes(new char[] { str[i] });
					int num = bytes.Length;
					for (int j = 0; j < num; j++)
					{
						char c = (char)bytes[j];
						if (c <= ' ' || c >= '\u007f' || "<>%\"{}|\\^`".IndexOf(c) != -1 || (escapeHex && c == '#') || (escapeBrackets && (c == '[' || c == ']')) || (escapeReserved && ";/?:@&=+$,".IndexOf(c) != -1))
						{
							stringBuilder.Append(global::System.Uri.HexEscape(c));
						}
						else
						{
							stringBuilder.Append(c);
						}
					}
				}
			}
			return stringBuilder.ToString();
		}

		/// <summary>Parses the URI of the current instance to ensure it contains all the parts required for a valid URI.</summary>
		/// <exception cref="T:System.UriFormatException">The Uri passed from the constructor is invalid. </exception>
		// Token: 0x06002BE3 RID: 11235 RVA: 0x000029F5 File Offset: 0x00000BF5
		[Obsolete("The method has been deprecated. It is not used by the system.")]
		protected virtual void Parse()
		{
		}

		// Token: 0x06002BE4 RID: 11236 RVA: 0x0008E168 File Offset: 0x0008C368
		private void ParseUri(global::System.UriKind kind)
		{
			this.Parse(kind, this.source);
			if (this.userEscaped)
			{
				return;
			}
			this.host = global::System.Uri.EscapeString(this.host, false, true, false);
			if (this.host.Length > 1 && this.host[0] != '[' && this.host[this.host.Length - 1] != ']')
			{
				this.host = this.host.ToLower(CultureInfo.InvariantCulture);
			}
			if (this.path.Length > 0)
			{
				this.path = global::System.Uri.EscapeString(this.path);
			}
		}

		/// <summary>Converts the specified string by replacing any escape sequences with their unescaped representation.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the unescaped value of the <paramref name="path" /> parameter.</returns>
		/// <param name="path">The <see cref="T:System.String" /> to convert. </param>
		// Token: 0x06002BE5 RID: 11237 RVA: 0x0001E735 File Offset: 0x0001C935
		[Obsolete]
		protected virtual string Unescape(string str)
		{
			return global::System.Uri.Unescape(str, false);
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x0008E220 File Offset: 0x0008C420
		internal static string Unescape(string str, bool excludeSpecial)
		{
			if (str == null)
			{
				return string.Empty;
			}
			StringBuilder stringBuilder = new StringBuilder();
			int length = str.Length;
			for (int i = 0; i < length; i++)
			{
				char c = str[i];
				if (c == '%')
				{
					char c3;
					char c2 = global::System.Uri.HexUnescapeMultiByte(str, ref i, out c3);
					if (excludeSpecial && c2 == '#')
					{
						stringBuilder.Append("%23");
					}
					else if (excludeSpecial && c2 == '%')
					{
						stringBuilder.Append("%25");
					}
					else if (excludeSpecial && c2 == '?')
					{
						stringBuilder.Append("%3F");
					}
					else
					{
						stringBuilder.Append(c2);
						if (c3 != '\0')
						{
							stringBuilder.Append(c3);
						}
					}
					i--;
				}
				else
				{
					stringBuilder.Append(c);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x0008E304 File Offset: 0x0008C504
		private void ParseAsWindowsUNC(string uriString)
		{
			this.scheme = global::System.Uri.UriSchemeFile;
			this.port = -1;
			this.fragment = string.Empty;
			this.query = string.Empty;
			this.isUnc = true;
			uriString = uriString.TrimStart(new char[] { '\\' });
			int num = uriString.IndexOf('\\');
			if (num > 0)
			{
				this.path = uriString.Substring(num);
				this.host = uriString.Substring(0, num);
			}
			else
			{
				this.host = uriString;
				this.path = string.Empty;
			}
			this.path = this.path.Replace("\\", "/");
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x0008E3B0 File Offset: 0x0008C5B0
		private string ParseAsWindowsAbsoluteFilePath(string uriString)
		{
			if (uriString.Length > 2 && uriString[2] != '\\' && uriString[2] != '/')
			{
				return "Relative file path is not allowed.";
			}
			this.scheme = global::System.Uri.UriSchemeFile;
			this.host = string.Empty;
			this.port = -1;
			this.path = uriString.Replace("\\", "/");
			this.fragment = string.Empty;
			this.query = string.Empty;
			return null;
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x0008E438 File Offset: 0x0008C638
		private void ParseAsUnixAbsoluteFilePath(string uriString)
		{
			this.isUnixFilePath = true;
			this.scheme = global::System.Uri.UriSchemeFile;
			this.port = -1;
			this.fragment = string.Empty;
			this.query = string.Empty;
			this.host = string.Empty;
			this.path = null;
			if (uriString.Length >= 2 && uriString[0] == '/' && uriString[1] == '/')
			{
				uriString = uriString.TrimStart(new char[] { '/' });
				this.path = '/' + uriString;
			}
			if (this.path == null)
			{
				this.path = uriString;
			}
		}

		// Token: 0x06002BEA RID: 11242 RVA: 0x0008E4E8 File Offset: 0x0008C6E8
		private void Parse(global::System.UriKind kind, string uriString)
		{
			if (uriString == null)
			{
				throw new ArgumentNullException("uriString");
			}
			string text = this.ParseNoExceptions(kind, uriString);
			if (text != null)
			{
				throw new global::System.UriFormatException(text);
			}
		}

		// Token: 0x06002BEB RID: 11243 RVA: 0x0008E51C File Offset: 0x0008C71C
		private string ParseNoExceptions(global::System.UriKind kind, string uriString)
		{
			uriString = uriString.Trim();
			int length = uriString.Length;
			if (length == 0 && (kind == global::System.UriKind.Relative || kind == global::System.UriKind.RelativeOrAbsolute))
			{
				this.isAbsoluteUri = false;
				return null;
			}
			if (length <= 1 && kind != global::System.UriKind.Relative)
			{
				return "Absolute URI is too short";
			}
			int num = uriString.IndexOf(':');
			if (num == 0)
			{
				return "Invalid URI: The format of the URI could not be determined.";
			}
			if (num < 0)
			{
				if (uriString[0] == '/' && Path.DirectorySeparatorChar == '/')
				{
					this.ParseAsUnixAbsoluteFilePath(uriString);
					if (kind == global::System.UriKind.Relative)
					{
						this.isAbsoluteUri = false;
					}
				}
				else if (uriString.Length >= 2 && uriString[0] == '\\' && uriString[1] == '\\')
				{
					this.ParseAsWindowsUNC(uriString);
				}
				else
				{
					this.isAbsoluteUri = false;
					this.path = uriString;
				}
				return null;
			}
			if (num == 1)
			{
				if (!global::System.Uri.IsAlpha(uriString[0]))
				{
					return "URI scheme must start with a letter.";
				}
				string text = this.ParseAsWindowsAbsoluteFilePath(uriString);
				if (text != null)
				{
					return text;
				}
				return null;
			}
			else
			{
				this.scheme = uriString.Substring(0, num).ToLower(CultureInfo.InvariantCulture);
				if (!global::System.Uri.CheckSchemeName(this.scheme))
				{
					return global::Locale.GetText("URI scheme must start with a letter and must consist of one of alphabet, digits, '+', '-' or '.' character.");
				}
				int num2 = num + 1;
				int num3 = uriString.Length;
				num = uriString.IndexOf('#', num2);
				if (!this.IsUnc && num != -1)
				{
					if (this.userEscaped)
					{
						this.fragment = uriString.Substring(num);
					}
					else
					{
						this.fragment = "#" + global::System.Uri.EscapeString(uriString.Substring(num + 1));
					}
					num3 = num;
				}
				num = uriString.IndexOf('?', num2, num3 - num2);
				if (num != -1)
				{
					this.query = uriString.Substring(num, num3 - num);
					num3 = num;
					if (!this.userEscaped)
					{
						this.query = global::System.Uri.EscapeString(this.query);
					}
				}
				if (global::System.Uri.IsPredefinedScheme(this.scheme) && this.scheme != global::System.Uri.UriSchemeMailto && this.scheme != global::System.Uri.UriSchemeNews && (num3 - num2 < 2 || (num3 - num2 >= 2 && uriString[num2] == '/' && uriString[num2 + 1] != '/')))
				{
					return "Invalid URI: The Authority/Host could not be parsed.";
				}
				bool flag = num3 - num2 >= 2 && uriString[num2] == '/' && uriString[num2 + 1] == '/';
				bool flag2 = this.scheme == global::System.Uri.UriSchemeFile && flag && (num3 - num2 == 2 || uriString[num2 + 2] == '/');
				bool flag3 = false;
				if (flag)
				{
					if (kind == global::System.UriKind.Relative)
					{
						return "Absolute URI when we expected a relative one";
					}
					if (this.scheme != global::System.Uri.UriSchemeMailto && this.scheme != global::System.Uri.UriSchemeNews)
					{
						num2 += 2;
					}
					if (this.scheme == global::System.Uri.UriSchemeFile)
					{
						int num4 = 2;
						for (int i = num2; i < num3; i++)
						{
							if (uriString[i] != '/')
							{
								break;
							}
							num4++;
						}
						if (num4 >= 4)
						{
							flag2 = false;
							while (num2 < num3 && uriString[num2] == '/')
							{
								num2++;
							}
						}
						else if (num4 >= 3)
						{
							num2++;
						}
					}
					if (num3 - num2 > 1 && uriString[num2 + 1] == ':')
					{
						flag2 = false;
						flag3 = true;
					}
				}
				else if (!global::System.Uri.IsPredefinedScheme(this.scheme))
				{
					this.path = uriString.Substring(num2, num3 - num2);
					this.isOpaquePart = true;
					return null;
				}
				if (flag2)
				{
					num = -1;
				}
				else
				{
					num = uriString.IndexOf('/', num2, num3 - num2);
					if (num == -1 && flag3)
					{
						num = uriString.IndexOf('\\', num2, num3 - num2);
					}
				}
				if (num == -1)
				{
					if (this.scheme != global::System.Uri.UriSchemeMailto && this.scheme != global::System.Uri.UriSchemeNews)
					{
						this.path = "/";
					}
				}
				else
				{
					this.path = uriString.Substring(num, num3 - num);
					num3 = num;
				}
				if (flag2)
				{
					num = -1;
				}
				else
				{
					num = uriString.IndexOf('@', num2, num3 - num2);
				}
				if (num != -1)
				{
					this.userinfo = uriString.Substring(num2, num - num2);
					num2 = num + 1;
				}
				this.port = -1;
				if (flag2)
				{
					num = -1;
				}
				else
				{
					num = uriString.LastIndexOf(':', num3 - 1, num3 - num2);
				}
				if (num != -1 && num != num3 - 1)
				{
					string text2 = uriString.Substring(num + 1, num3 - (num + 1));
					if (text2.Length > 0 && text2[text2.Length - 1] != ']')
					{
						if (!int.TryParse(text2, NumberStyles.Integer, CultureInfo.InvariantCulture, out this.port) || this.port < 0 || this.port > 65535)
						{
							return "Invalid URI: Invalid port number";
						}
						num3 = num;
					}
					else if (this.port == -1)
					{
						this.port = global::System.Uri.GetDefaultPort(this.scheme);
					}
				}
				else if (this.port == -1)
				{
					this.port = global::System.Uri.GetDefaultPort(this.scheme);
				}
				uriString = uriString.Substring(num2, num3 - num2);
				this.host = uriString;
				if (flag2)
				{
					this.path = global::System.Uri.Reduce('/' + uriString, true);
					this.host = string.Empty;
				}
				else if (this.host.Length == 2 && this.host[1] == ':')
				{
					this.path = this.host + this.path;
					this.host = string.Empty;
				}
				else if (this.isUnixFilePath)
				{
					uriString = "//" + uriString;
					this.host = string.Empty;
				}
				else if (this.scheme == global::System.Uri.UriSchemeFile)
				{
					this.isUnc = true;
				}
				else if (this.scheme == global::System.Uri.UriSchemeNews)
				{
					if (this.host.Length > 0)
					{
						this.path = this.host;
						this.host = string.Empty;
					}
				}
				else if (this.host.Length == 0 && (this.scheme == global::System.Uri.UriSchemeHttp || this.scheme == global::System.Uri.UriSchemeGopher || this.scheme == global::System.Uri.UriSchemeNntp || this.scheme == global::System.Uri.UriSchemeHttps || this.scheme == global::System.Uri.UriSchemeFtp))
				{
					return "Invalid URI: The hostname could not be parsed";
				}
				bool flag4 = this.host.Length > 0 && global::System.Uri.CheckHostName(this.host) == global::System.UriHostNameType.Unknown;
				if (!flag4 && this.host.Length > 1 && this.host[0] == '[' && this.host[this.host.Length - 1] == ']')
				{
					global::System.Net.IPv6Address pv6Address;
					if (global::System.Net.IPv6Address.TryParse(this.host, out pv6Address))
					{
						this.host = "[" + pv6Address.ToString(true) + "]";
					}
					else
					{
						flag4 = true;
					}
				}
				if (flag4 && (this.Parser is global::System.DefaultUriParser || this.Parser == null))
				{
					return global::Locale.GetText("Invalid URI: The hostname could not be parsed. (" + this.host + ")");
				}
				global::System.UriFormatException ex = null;
				if (this.Parser != null)
				{
					this.Parser.InitializeAndValidate(this, out ex);
				}
				if (ex != null)
				{
					return ex.Message;
				}
				if (this.scheme != global::System.Uri.UriSchemeMailto && this.scheme != global::System.Uri.UriSchemeNews && this.scheme != global::System.Uri.UriSchemeFile)
				{
					this.path = global::System.Uri.Reduce(this.path, global::System.Uri.CompactEscaped(this.scheme));
				}
				return null;
			}
		}

		// Token: 0x06002BEC RID: 11244 RVA: 0x0008EDB0 File Offset: 0x0008CFB0
		private static bool CompactEscaped(string scheme)
		{
			if (scheme != null)
			{
				if (global::System.Uri.<>f__switch$map1F == null)
				{
					global::System.Uri.<>f__switch$map1F = new Dictionary<string, int>(5)
					{
						{ "file", 0 },
						{ "http", 0 },
						{ "https", 0 },
						{ "net.pipe", 0 },
						{ "net.tcp", 0 }
					};
				}
				int num;
				if (global::System.Uri.<>f__switch$map1F.TryGetValue(scheme, out num))
				{
					if (num == 0)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06002BED RID: 11245 RVA: 0x0008EE38 File Offset: 0x0008D038
		private static string Reduce(string path, bool compact_escaped)
		{
			if (path == "/")
			{
				return path;
			}
			StringBuilder stringBuilder = new StringBuilder();
			if (compact_escaped)
			{
				for (int i = 0; i < path.Length; i++)
				{
					char c = path[i];
					char c2 = c;
					if (c2 != '%')
					{
						if (c2 != '\\')
						{
							stringBuilder.Append(c);
						}
						else
						{
							stringBuilder.Append('/');
						}
					}
					else if (i < path.Length - 2)
					{
						char c3 = path[i + 1];
						char c4 = char.ToUpper(path[i + 2]);
						if ((c3 == '2' && c4 == 'F') || (c3 == '5' && c4 == 'C'))
						{
							stringBuilder.Append('/');
							i += 2;
						}
						else
						{
							stringBuilder.Append(c);
						}
					}
					else
					{
						stringBuilder.Append(c);
					}
				}
				path = stringBuilder.ToString();
			}
			else
			{
				path = path.Replace('\\', '/');
			}
			ArrayList arrayList = new ArrayList();
			int j = 0;
			while (j < path.Length)
			{
				int num = path.IndexOf('/', j);
				if (num == -1)
				{
					num = path.Length;
				}
				string text = path.Substring(j, num - j);
				j = num + 1;
				if (text.Length != 0 && !(text == "."))
				{
					if (text == "..")
					{
						int count = arrayList.Count;
						if (count != 0)
						{
							arrayList.RemoveAt(count - 1);
						}
					}
					else
					{
						arrayList.Add(text);
					}
				}
			}
			if (arrayList.Count == 0)
			{
				return "/";
			}
			stringBuilder.Length = 0;
			if (path[0] == '/')
			{
				stringBuilder.Append('/');
			}
			bool flag = true;
			foreach (object obj in arrayList)
			{
				string text2 = (string)obj;
				if (flag)
				{
					flag = false;
				}
				else
				{
					stringBuilder.Append('/');
				}
				stringBuilder.Append(text2);
			}
			if (path.EndsWith("/"))
			{
				stringBuilder.Append('/');
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06002BEE RID: 11246 RVA: 0x0008F0BC File Offset: 0x0008D2BC
		private static char HexUnescapeMultiByte(string pattern, ref int index, out char surrogate)
		{
			surrogate = '\0';
			if (pattern == null)
			{
				throw new ArgumentException("pattern");
			}
			if (index < 0 || index >= pattern.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (!global::System.Uri.IsHexEncoding(pattern, index))
			{
				return pattern[index++];
			}
			int num = index++;
			int num2 = global::System.Uri.FromHex(pattern[index++]);
			int num3 = global::System.Uri.FromHex(pattern[index++]);
			int num4 = num2;
			int num5 = 0;
			while ((num4 & 8) == 8)
			{
				num5++;
				num4 <<= 1;
			}
			if (num5 <= 1)
			{
				return (char)((num2 << 4) | num3);
			}
			byte[] array = new byte[num5];
			bool flag = false;
			array[0] = (byte)((num2 << 4) | num3);
			for (int i = 1; i < num5; i++)
			{
				if (!global::System.Uri.IsHexEncoding(pattern, index++))
				{
					flag = true;
					break;
				}
				int num6 = global::System.Uri.FromHex(pattern[index++]);
				if ((num6 & 12) != 8)
				{
					flag = true;
					break;
				}
				int num7 = global::System.Uri.FromHex(pattern[index++]);
				array[i] = (byte)((num6 << 4) | num7);
			}
			if (flag)
			{
				index = num + 3;
				return (char)array[0];
			}
			byte b = byte.MaxValue;
			b = (byte)(b >> num5 + 1);
			int num8 = (int)(array[0] & b);
			for (int j = 1; j < num5; j++)
			{
				num8 <<= 6;
				num8 |= (int)(array[j] & 63);
			}
			if (num8 <= 65535)
			{
				return (char)num8;
			}
			num8 -= 65536;
			surrogate = (char)((num8 & 1023) | 56320);
			return (char)((num8 >> 10) | 55296);
		}

		// Token: 0x06002BEF RID: 11247 RVA: 0x0008F2B0 File Offset: 0x0008D4B0
		internal static string GetSchemeDelimiter(string scheme)
		{
			for (int i = 0; i < global::System.Uri.schemes.Length; i++)
			{
				if (global::System.Uri.schemes[i].scheme == scheme)
				{
					return global::System.Uri.schemes[i].delimiter;
				}
			}
			return global::System.Uri.SchemeDelimiter;
		}

		// Token: 0x06002BF0 RID: 11248 RVA: 0x0008F308 File Offset: 0x0008D508
		internal static int GetDefaultPort(string scheme)
		{
			global::System.UriParser uriParser = global::System.UriParser.GetParser(scheme);
			if (uriParser == null)
			{
				return -1;
			}
			return uriParser.DefaultPort;
		}

		// Token: 0x06002BF1 RID: 11249 RVA: 0x0001E73E File Offset: 0x0001C93E
		private string GetOpaqueWiseSchemeDelimiter()
		{
			if (this.isOpaquePart)
			{
				return ":";
			}
			return global::System.Uri.GetSchemeDelimiter(this.scheme);
		}

		/// <summary>Gets whether a character is invalid in a file system name.</summary>
		/// <returns>A <see cref="T:System.Boolean" /> value that is true if the specified character is invalid; otherwise false.</returns>
		/// <param name="character">The <see cref="T:System.Char" /> to test. </param>
		// Token: 0x06002BF2 RID: 11250 RVA: 0x0008F32C File Offset: 0x0008D52C
		[Obsolete]
		protected virtual bool IsBadFileSystemCharacter(char ch)
		{
			if (ch < ' ' || (ch < '@' && ch > '9'))
			{
				return true;
			}
			switch (ch)
			{
			case '*':
			case ',':
			case '/':
				break;
			default:
				switch (ch)
				{
				case '\\':
				case '^':
					break;
				default:
					if (ch != '\0' && ch != '"' && ch != '&' && ch != '|')
					{
						return false;
					}
					break;
				}
				break;
			}
			return true;
		}

		/// <summary>Gets whether the specified character should be escaped.</summary>
		/// <returns>A <see cref="T:System.Boolean" /> value that is true if the specified character should be escaped; otherwise, false.</returns>
		/// <param name="character">The <see cref="T:System.Char" /> to test. </param>
		// Token: 0x06002BF3 RID: 11251 RVA: 0x0008F3B4 File Offset: 0x0008D5B4
		[Obsolete]
		protected static bool IsExcludedCharacter(char ch)
		{
			return ch <= ' ' || ch >= '\u007f' || (ch == '"' || ch == '#' || ch == '%' || ch == '<' || ch == '>' || ch == '[' || ch == '\\' || ch == ']' || ch == '^' || ch == '`' || ch == '{' || ch == '|' || ch == '}');
		}

		// Token: 0x06002BF4 RID: 11252 RVA: 0x0008F440 File Offset: 0x0008D640
		internal static bool MaybeUri(string s)
		{
			int num = s.IndexOf(':');
			return num != -1 && num < 10 && global::System.Uri.IsPredefinedScheme(s.Substring(0, num));
		}

		// Token: 0x06002BF5 RID: 11253 RVA: 0x0008F478 File Offset: 0x0008D678
		private static bool IsPredefinedScheme(string scheme)
		{
			if (scheme != null)
			{
				if (global::System.Uri.<>f__switch$map20 == null)
				{
					global::System.Uri.<>f__switch$map20 = new Dictionary<string, int>(10)
					{
						{ "http", 0 },
						{ "https", 0 },
						{ "file", 0 },
						{ "ftp", 0 },
						{ "nntp", 0 },
						{ "gopher", 0 },
						{ "mailto", 0 },
						{ "news", 0 },
						{ "net.pipe", 0 },
						{ "net.tcp", 0 }
					};
				}
				int num;
				if (global::System.Uri.<>f__switch$map20.TryGetValue(scheme, out num))
				{
					if (num == 0)
					{
						return true;
					}
				}
			}
			return false;
		}

		/// <summary>Gets whether the specified character is a reserved character.</summary>
		/// <returns>A <see cref="T:System.Boolean" /> value that is true if the specified character is a reserved character otherwise, false.</returns>
		/// <param name="character">The <see cref="T:System.Char" /> to test. </param>
		// Token: 0x06002BF6 RID: 11254 RVA: 0x0008F540 File Offset: 0x0008D740
		[Obsolete]
		protected virtual bool IsReservedCharacter(char ch)
		{
			return ch == '$' || ch == '&' || ch == '+' || ch == ',' || ch == '/' || ch == ':' || ch == ';' || ch == '=' || ch == '@';
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x06002BF7 RID: 11255 RVA: 0x0001E75C File Offset: 0x0001C95C
		// (set) Token: 0x06002BF8 RID: 11256 RVA: 0x0001E79B File Offset: 0x0001C99B
		private global::System.UriParser Parser
		{
			get
			{
				if (this.parser == null)
				{
					this.parser = global::System.UriParser.GetParser(this.Scheme);
					if (this.parser == null)
					{
						this.parser = new global::System.DefaultUriParser("*");
					}
				}
				return this.parser;
			}
			set
			{
				this.parser = value;
			}
		}

		/// <summary>Gets the specified components of the current instance using the specified escaping for special characters.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the components.</returns>
		/// <param name="components">A bitwise combination of the <see cref="T:System.UriComponents" /> values that specifies which parts of the current instance to return to the caller.</param>
		/// <param name="format">One of the <see cref="T:System.UriFormat" /> values that controls how special characters are escaped. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="uriComponents" /> is not a combination of valid <see cref="T:System.UriComponents" /> values.</exception>
		/// <exception cref="T:System.InvalidOperationException">The current <see cref="T:System.Uri" /> is not an absolute URI. Relative URIs cannot be used with this method.</exception>
		/// <filterpriority>1</filterpriority>
		// Token: 0x06002BF9 RID: 11257 RVA: 0x0001E7A4 File Offset: 0x0001C9A4
		public string GetComponents(global::System.UriComponents components, global::System.UriFormat format)
		{
			return this.Parser.GetComponents(this, components, format);
		}

		/// <summary>Determines whether the current <see cref="T:System.Uri" /> instance is a base of the specified <see cref="T:System.Uri" /> instance.</summary>
		/// <returns>true if the current <see cref="T:System.Uri" /> instance is a base of <paramref name="uri" />; otherwise, false.</returns>
		/// <param name="uri">The specified <see cref="T:System.Uri" /> instance to test. </param>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x06002BFA RID: 11258 RVA: 0x0001E7B4 File Offset: 0x0001C9B4
		public bool IsBaseOf(global::System.Uri uri)
		{
			return this.Parser.IsBaseOf(this, uri);
		}

		/// <summary>Indicates whether the string used to construct this <see cref="T:System.Uri" /> was well-formed and is not required to be further escaped.</summary>
		/// <returns>A <see cref="T:System.Boolean" /> value that is true if the string was well-formed; else false.</returns>
		// Token: 0x06002BFB RID: 11259 RVA: 0x0001E7C3 File Offset: 0x0001C9C3
		public bool IsWellFormedOriginalString()
		{
			return global::System.Uri.EscapeString(this.OriginalString) == this.OriginalString;
		}

		/// <summary>Compares the specified parts of two URIs using the specified comparison rules.</summary>
		/// <returns>An <see cref="T:System.Int32" /> value that indicates the lexical relationship between the compared <see cref="T:System.Uri" /> components.ValueMeaningLess than zero<paramref name="uri1" /> is less than <paramref name="uri2" />.Zero<paramref name="uri1" /> equals <paramref name="uri2" />.Greater than zero<paramref name="uri1" /> is greater than <paramref name="uri2" />.</returns>
		/// <param name="uri1">The first <see cref="T:System.Uri" />.</param>
		/// <param name="uri2">The second <see cref="T:System.Uri" />.</param>
		/// <param name="partsToCompare">A bitwise combination of the <see cref="T:System.UriComponents" /> values that specifies the parts of <paramref name="uri1" /> and <paramref name="uri2" /> to compare.</param>
		/// <param name="compareFormat">One of the <see cref="T:System.UriFormat" /> values that specifies the character escaping used when the URI components are compared.</param>
		/// <param name="comparisonType">One of the <see cref="T:System.StringComparison" /> values.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="comparisonType" /> is not a valid <see cref="T:System.StringComparison" /> value.</exception>
		/// <filterpriority>1</filterpriority>
		// Token: 0x06002BFC RID: 11260 RVA: 0x0008F598 File Offset: 0x0008D798
		public static int Compare(global::System.Uri uri1, global::System.Uri uri2, global::System.UriComponents partsToCompare, global::System.UriFormat compareFormat, StringComparison comparisonType)
		{
			if (comparisonType < StringComparison.CurrentCulture || comparisonType > StringComparison.OrdinalIgnoreCase)
			{
				string text = global::Locale.GetText("Invalid StringComparison value '{0}'", new object[] { comparisonType });
				throw new ArgumentException("comparisonType", text);
			}
			if (uri1 == null && uri2 == null)
			{
				return 0;
			}
			string components = uri1.GetComponents(partsToCompare, compareFormat);
			string components2 = uri2.GetComponents(partsToCompare, compareFormat);
			return string.Compare(components, components2, comparisonType);
		}

		// Token: 0x06002BFD RID: 11261 RVA: 0x0008F614 File Offset: 0x0008D814
		private static bool NeedToEscapeDataChar(char b)
		{
			return (b < 'A' || b > 'Z') && (b < 'a' || b > 'z') && (b < '0' || b > '9') && b != '_' && b != '~' && b != '!' && b != '\'' && b != '(' && b != ')' && b != '*' && b != '-' && b != '.';
		}

		/// <summary>Converts a string to its escaped representation.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the escaped representation of <paramref name="stringToEscape" />.</returns>
		/// <param name="stringToEscape">The string to escape.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="stringToEscape" /> is null. </exception>
		/// <exception cref="T:System.UriFormatException">The length of <paramref name="stringToEscape" /> exceeds 32766 characters.</exception>
		// Token: 0x06002BFE RID: 11262 RVA: 0x0008F69C File Offset: 0x0008D89C
		public static string EscapeDataString(string stringToEscape)
		{
			if (stringToEscape == null)
			{
				throw new ArgumentNullException("stringToEscape");
			}
			if (stringToEscape.Length > 32766)
			{
				string text = global::Locale.GetText("Uri is longer than the maximum {0} characters.");
				throw new global::System.UriFormatException(text);
			}
			bool flag = false;
			foreach (char c in stringToEscape)
			{
				if (global::System.Uri.NeedToEscapeDataChar(c))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return stringToEscape;
			}
			StringBuilder stringBuilder = new StringBuilder();
			byte[] bytes = Encoding.UTF8.GetBytes(stringToEscape);
			foreach (byte b in bytes)
			{
				if (global::System.Uri.NeedToEscapeDataChar((char)b))
				{
					stringBuilder.Append(global::System.Uri.HexEscape((char)b));
				}
				else
				{
					stringBuilder.Append((char)b);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06002BFF RID: 11263 RVA: 0x0008F78C File Offset: 0x0008D98C
		private static bool NeedToEscapeUriChar(char b)
		{
			return (b < 'A' || b > 'Z') && (b < 'a' || b > 'z') && (b < '&' || b > ';') && b != '!' && b != '#' && b != '$' && b != '=' && b != '?' && b != '@' && b != '_' && b != '~';
		}

		/// <summary>Converts a URI string to its escaped representation.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the escaped representation of <paramref name="stringToEscape" />.</returns>
		/// <param name="stringToEscape">The string to escape.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="stringToEscape" /> is null. </exception>
		/// <exception cref="T:System.UriFormatException">The length of <paramref name="stringToEscape" /> exceeds 32766 characters.</exception>
		// Token: 0x06002C00 RID: 11264 RVA: 0x0008F80C File Offset: 0x0008DA0C
		public static string EscapeUriString(string stringToEscape)
		{
			if (stringToEscape == null)
			{
				throw new ArgumentNullException("stringToEscape");
			}
			if (stringToEscape.Length > 32766)
			{
				string text = global::Locale.GetText("Uri is longer than the maximum {0} characters.");
				throw new global::System.UriFormatException(text);
			}
			bool flag = false;
			foreach (char c in stringToEscape)
			{
				if (global::System.Uri.NeedToEscapeUriChar(c))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return stringToEscape;
			}
			StringBuilder stringBuilder = new StringBuilder();
			byte[] bytes = Encoding.UTF8.GetBytes(stringToEscape);
			foreach (byte b in bytes)
			{
				if (global::System.Uri.NeedToEscapeUriChar((char)b))
				{
					stringBuilder.Append(global::System.Uri.HexEscape((char)b));
				}
				else
				{
					stringBuilder.Append((char)b);
				}
			}
			return stringBuilder.ToString();
		}

		/// <summary>Indicates whether the string is well-formed by attempting to construct a URI with the string and ensures that the string does not require further escaping.</summary>
		/// <returns>A <see cref="T:System.Boolean" /> value that is true if the string was well-formed; else false.</returns>
		/// <param name="uriString">The string used to attempt to construct a <see cref="T:System.Uri" />.</param>
		/// <param name="uriKind">The type of the <see cref="T:System.Uri" /> in <paramref name="uriString" />.</param>
		// Token: 0x06002C01 RID: 11265 RVA: 0x0008F8FC File Offset: 0x0008DAFC
		public static bool IsWellFormedUriString(string uriString, global::System.UriKind uriKind)
		{
			global::System.Uri uri;
			return uriString != null && global::System.Uri.TryCreate(uriString, uriKind, out uri) && uri.IsWellFormedOriginalString();
		}

		/// <summary>Creates a new <see cref="T:System.Uri" /> using the specified <see cref="T:System.String" /> instance and a <see cref="T:System.UriKind" />.</summary>
		/// <returns>A <see cref="T:System.Boolean" /> value that is true if the <see cref="T:System.Uri" /> was successfully created; otherwise, false.</returns>
		/// <param name="uriString">The <see cref="T:System.String" /> representing the <see cref="T:System.Uri" />.</param>
		/// <param name="uriKind">The type of the Uri.</param>
		/// <param name="result">When this method returns, contains the constructed <see cref="T:System.Uri" />.</param>
		// Token: 0x06002C02 RID: 11266 RVA: 0x0008F928 File Offset: 0x0008DB28
		public static bool TryCreate(string uriString, global::System.UriKind uriKind, out global::System.Uri result)
		{
			bool flag;
			global::System.Uri uri = new global::System.Uri(uriString, uriKind, out flag);
			if (flag)
			{
				result = uri;
				return true;
			}
			result = null;
			return false;
		}

		/// <summary>Creates a new <see cref="T:System.Uri" /> using the specified base and relative <see cref="T:System.String" /> instances.</summary>
		/// <returns>A <see cref="T:System.Boolean" /> value that is true if the <see cref="T:System.Uri" /> was successfully created; otherwise, false.</returns>
		/// <param name="baseUri">The base <see cref="T:System.Uri" />.</param>
		/// <param name="relativeUri">The relative <see cref="T:System.Uri" />, represented as a <see cref="T:System.String" />, to add to the base <see cref="T:System.Uri" />.</param>
		/// <param name="result">When this method returns, contains a <see cref="T:System.Uri" /> constructed from <paramref name="baseUri" /> and <paramref name="relativeUri" />. This parameter is passed uninitialized.</param>
		// Token: 0x06002C03 RID: 11267 RVA: 0x0008F950 File Offset: 0x0008DB50
		public static bool TryCreate(global::System.Uri baseUri, string relativeUri, out global::System.Uri result)
		{
			bool flag;
			try
			{
				result = new global::System.Uri(baseUri, relativeUri);
				flag = true;
			}
			catch (global::System.UriFormatException)
			{
				result = null;
				flag = false;
			}
			return flag;
		}

		/// <summary>Creates a new <see cref="T:System.Uri" /> using the specified base and relative <see cref="T:System.Uri" /> instances.</summary>
		/// <returns>A <see cref="T:System.Boolean" /> value that is true if the <see cref="T:System.Uri" /> was successfully created; otherwise, false.</returns>
		/// <param name="baseUri">The base <see cref="T:System.Uri" />. </param>
		/// <param name="relativeUri">The relative <see cref="T:System.Uri" /> to add to the base <see cref="T:System.Uri" />. </param>
		/// <param name="result">When this method returns, contains a <see cref="T:System.Uri" /> constructed from <paramref name="baseUri" /> and <paramref name="relativeUri" />. This parameter is passed uninitialized.</param>
		/// <filterpriority>1</filterpriority>
		// Token: 0x06002C04 RID: 11268 RVA: 0x0008F994 File Offset: 0x0008DB94
		public static bool TryCreate(global::System.Uri baseUri, global::System.Uri relativeUri, out global::System.Uri result)
		{
			bool flag;
			try
			{
				result = new global::System.Uri(baseUri, relativeUri.OriginalString);
				flag = true;
			}
			catch (global::System.UriFormatException)
			{
				result = null;
				flag = false;
			}
			return flag;
		}

		/// <summary>Converts a string to its unescaped representation.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the unescaped representation of <paramref name="stringToUnescape" />. </returns>
		/// <param name="stringToUnescape">The string to unescape.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="stringToUnescape" /> is null. </exception>
		// Token: 0x06002C05 RID: 11269 RVA: 0x0008F9DC File Offset: 0x0008DBDC
		public static string UnescapeDataString(string stringToUnescape)
		{
			if (stringToUnescape == null)
			{
				throw new ArgumentNullException("stringToUnescape");
			}
			if (stringToUnescape.IndexOf('%') == -1 && stringToUnescape.IndexOf('+') == -1)
			{
				return stringToUnescape;
			}
			StringBuilder stringBuilder = new StringBuilder();
			long num = (long)stringToUnescape.Length;
			MemoryStream memoryStream = new MemoryStream();
			int num2 = 0;
			while ((long)num2 < num)
			{
				if (stringToUnescape[num2] == '%' && (long)(num2 + 2) < num && stringToUnescape[num2 + 1] != '%')
				{
					int num3;
					if (stringToUnescape[num2 + 1] == 'u' && (long)(num2 + 5) < num)
					{
						if (memoryStream.Length > 0L)
						{
							stringBuilder.Append(global::System.Uri.GetChars(memoryStream, Encoding.UTF8));
							memoryStream.SetLength(0L);
						}
						num3 = global::System.Uri.GetChar(stringToUnescape, num2 + 2, 4);
						if (num3 != -1)
						{
							stringBuilder.Append((char)num3);
							num2 += 5;
						}
						else
						{
							stringBuilder.Append('%');
						}
					}
					else if ((num3 = global::System.Uri.GetChar(stringToUnescape, num2 + 1, 2)) != -1)
					{
						memoryStream.WriteByte((byte)num3);
						num2 += 2;
					}
					else
					{
						stringBuilder.Append('%');
					}
				}
				else
				{
					if (memoryStream.Length > 0L)
					{
						stringBuilder.Append(global::System.Uri.GetChars(memoryStream, Encoding.UTF8));
						memoryStream.SetLength(0L);
					}
					stringBuilder.Append(stringToUnescape[num2]);
				}
				num2++;
			}
			if (memoryStream.Length > 0L)
			{
				stringBuilder.Append(global::System.Uri.GetChars(memoryStream, Encoding.UTF8));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06002C06 RID: 11270 RVA: 0x0008FB78 File Offset: 0x0008DD78
		private static int GetInt(byte b)
		{
			char c = (char)b;
			if (c >= '0' && c <= '9')
			{
				return (int)(c - '0');
			}
			if (c >= 'a' && c <= 'f')
			{
				return (int)(c - 'a' + '\n');
			}
			if (c >= 'A' && c <= 'F')
			{
				return (int)(c - 'A' + '\n');
			}
			return -1;
		}

		// Token: 0x06002C07 RID: 11271 RVA: 0x0008FBD0 File Offset: 0x0008DDD0
		private static int GetChar(string str, int offset, int length)
		{
			int num = 0;
			int num2 = length + offset;
			for (int i = offset; i < num2; i++)
			{
				char c = str[i];
				if (c > '\u007f')
				{
					return -1;
				}
				int @int = global::System.Uri.GetInt((byte)c);
				if (@int == -1)
				{
					return -1;
				}
				num = (num << 4) + @int;
			}
			return num;
		}

		// Token: 0x06002C08 RID: 11272 RVA: 0x000149A2 File Offset: 0x00012BA2
		private static char[] GetChars(MemoryStream b, Encoding e)
		{
			return e.GetChars(b.GetBuffer(), 0, (int)b.Length);
		}

		// Token: 0x06002C09 RID: 11273 RVA: 0x0001E7DB File Offset: 0x0001C9DB
		private void EnsureAbsoluteUri()
		{
			if (!this.IsAbsoluteUri)
			{
				throw new InvalidOperationException("This operation is not supported for a relative URI.");
			}
		}

		/// <summary>Determines whether two <see cref="T:System.Uri" /> instances have the same value.</summary>
		/// <returns>A <see cref="T:System.Boolean" /> value that is true if the <see cref="T:System.Uri" /> instances are equivalent; otherwise, false.</returns>
		/// <param name="uri1">A <see cref="T:System.Uri" /> instance to compare with <paramref name="uri2" />. </param>
		/// <param name="uri2">A <see cref="T:System.Uri" /> instance to compare with <paramref name="uri1" />. </param>
		/// <filterpriority>3</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x06002C0A RID: 11274 RVA: 0x0001E7F3 File Offset: 0x0001C9F3
		public static bool operator ==(global::System.Uri u1, global::System.Uri u2)
		{
			return object.Equals(u1, u2);
		}

		/// <summary>Determines whether two <see cref="T:System.Uri" /> instances do not have the same value.</summary>
		/// <returns>A <see cref="T:System.Boolean" /> value that is true if the two <see cref="T:System.Uri" /> instances are not equal; otherwise, false. If either parameter is null, this method returns true.</returns>
		/// <param name="uri1">A <see cref="T:System.Uri" /> instance to compare with <paramref name="uri2" />. </param>
		/// <param name="uri2">A <see cref="T:System.Uri" /> instance to compare with <paramref name="uri1" />. </param>
		/// <filterpriority>3</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x06002C0B RID: 11275 RVA: 0x0001E7FC File Offset: 0x0001C9FC
		public static bool operator !=(global::System.Uri u1, global::System.Uri u2)
		{
			return !(u1 == u2);
		}

		// Token: 0x04001B63 RID: 7011
		private const int MaxUriLength = 32766;

		// Token: 0x04001B64 RID: 7012
		private bool isUnixFilePath;

		// Token: 0x04001B65 RID: 7013
		private string source;

		// Token: 0x04001B66 RID: 7014
		private string scheme;

		// Token: 0x04001B67 RID: 7015
		private string host;

		// Token: 0x04001B68 RID: 7016
		private int port;

		// Token: 0x04001B69 RID: 7017
		private string path;

		// Token: 0x04001B6A RID: 7018
		private string query;

		// Token: 0x04001B6B RID: 7019
		private string fragment;

		// Token: 0x04001B6C RID: 7020
		private string userinfo;

		// Token: 0x04001B6D RID: 7021
		private bool isUnc;

		// Token: 0x04001B6E RID: 7022
		private bool isOpaquePart;

		// Token: 0x04001B6F RID: 7023
		private bool isAbsoluteUri;

		// Token: 0x04001B70 RID: 7024
		private string[] segments;

		// Token: 0x04001B71 RID: 7025
		private bool userEscaped;

		// Token: 0x04001B72 RID: 7026
		private string cachedAbsoluteUri;

		// Token: 0x04001B73 RID: 7027
		private string cachedToString;

		// Token: 0x04001B74 RID: 7028
		private string cachedLocalPath;

		// Token: 0x04001B75 RID: 7029
		private int cachedHashCode;

		// Token: 0x04001B76 RID: 7030
		private static readonly string hexUpperChars = "0123456789ABCDEF";

		/// <summary>Specifies the characters that separate the communication protocol scheme from the address portion of the URI. This field is read-only.</summary>
		/// <filterpriority>1</filterpriority>
		// Token: 0x04001B77 RID: 7031
		public static readonly string SchemeDelimiter = "://";

		/// <summary>Specifies that the URI is a pointer to a file. This field is read-only.</summary>
		/// <filterpriority>1</filterpriority>
		// Token: 0x04001B78 RID: 7032
		public static readonly string UriSchemeFile = "file";

		/// <summary>Specifies that the URI is accessed through the File Transfer Protocol (FTP). This field is read-only.</summary>
		/// <filterpriority>1</filterpriority>
		// Token: 0x04001B79 RID: 7033
		public static readonly string UriSchemeFtp = "ftp";

		/// <summary>Specifies that the URI is accessed through the Gopher protocol. This field is read-only.</summary>
		/// <filterpriority>1</filterpriority>
		// Token: 0x04001B7A RID: 7034
		public static readonly string UriSchemeGopher = "gopher";

		/// <summary>Specifies that the URI is accessed through the Hypertext Transfer Protocol (HTTP). This field is read-only.</summary>
		/// <filterpriority>1</filterpriority>
		// Token: 0x04001B7B RID: 7035
		public static readonly string UriSchemeHttp = "http";

		/// <summary>Specifies that the URI is accessed through the Secure Hypertext Transfer Protocol (HTTPS). This field is read-only.</summary>
		/// <filterpriority>1</filterpriority>
		// Token: 0x04001B7C RID: 7036
		public static readonly string UriSchemeHttps = "https";

		/// <summary>Specifies that the URI is an e-mail address and is accessed through the Simple Mail Transport Protocol (SMTP). This field is read-only.</summary>
		/// <filterpriority>1</filterpriority>
		// Token: 0x04001B7D RID: 7037
		public static readonly string UriSchemeMailto = "mailto";

		/// <summary>Specifies that the URI is an Internet news group and is accessed through the Network News Transport Protocol (NNTP). This field is read-only.</summary>
		/// <filterpriority>1</filterpriority>
		// Token: 0x04001B7E RID: 7038
		public static readonly string UriSchemeNews = "news";

		/// <summary>Specifies that the URI is an Internet news group and is accessed through the Network News Transport Protocol (NNTP). This field is read-only.</summary>
		/// <filterpriority>1</filterpriority>
		// Token: 0x04001B7F RID: 7039
		public static readonly string UriSchemeNntp = "nntp";

		/// <summary>Specifies that the URI is accessed through the NetPipe scheme used by Windows Communication Foundation (WCF). This field is read-only.</summary>
		// Token: 0x04001B80 RID: 7040
		public static readonly string UriSchemeNetPipe = "net.pipe";

		/// <summary>Specifies that the URI is accessed through the NetTcp scheme used by Windows Communication Foundation (WCF). This field is read-only.</summary>
		// Token: 0x04001B81 RID: 7041
		public static readonly string UriSchemeNetTcp = "net.tcp";

		// Token: 0x04001B82 RID: 7042
		private static global::System.Uri.UriScheme[] schemes = new global::System.Uri.UriScheme[]
		{
			new global::System.Uri.UriScheme(global::System.Uri.UriSchemeHttp, global::System.Uri.SchemeDelimiter, 80),
			new global::System.Uri.UriScheme(global::System.Uri.UriSchemeHttps, global::System.Uri.SchemeDelimiter, 443),
			new global::System.Uri.UriScheme(global::System.Uri.UriSchemeFtp, global::System.Uri.SchemeDelimiter, 21),
			new global::System.Uri.UriScheme(global::System.Uri.UriSchemeFile, global::System.Uri.SchemeDelimiter, -1),
			new global::System.Uri.UriScheme(global::System.Uri.UriSchemeMailto, ":", 25),
			new global::System.Uri.UriScheme(global::System.Uri.UriSchemeNews, ":", 119),
			new global::System.Uri.UriScheme(global::System.Uri.UriSchemeNntp, global::System.Uri.SchemeDelimiter, 119),
			new global::System.Uri.UriScheme(global::System.Uri.UriSchemeGopher, global::System.Uri.SchemeDelimiter, 70)
		};

		// Token: 0x04001B83 RID: 7043
		[NonSerialized]
		private global::System.UriParser parser;

		// Token: 0x020004D1 RID: 1233
		private struct UriScheme
		{
			// Token: 0x06002C0C RID: 11276 RVA: 0x0001E808 File Offset: 0x0001CA08
			public UriScheme(string s, string d, int p)
			{
				this.scheme = s;
				this.delimiter = d;
				this.defaultPort = p;
			}

			// Token: 0x04001B89 RID: 7049
			public string scheme;

			// Token: 0x04001B8A RID: 7050
			public string delimiter;

			// Token: 0x04001B8B RID: 7051
			public int defaultPort;
		}
	}
}
