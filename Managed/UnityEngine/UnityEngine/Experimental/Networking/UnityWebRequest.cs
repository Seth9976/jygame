using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace UnityEngine.Experimental.Networking
{
	/// <summary>
	///   <para>The UnityWebRequest object is used to communicate with web servers.</para>
	/// </summary>
	// Token: 0x020001EF RID: 495
	[StructLayout(LayoutKind.Sequential)]
	public sealed class UnityWebRequest : IDisposable
	{
		/// <summary>
		///   <para>Creates a UnityWebRequest with the default options and no attached DownloadHandler or UploadHandler. Default method is GET.</para>
		/// </summary>
		/// <param name="url">The target URL with which this UnityWebRequest will communicate. Also accessible via the url property.</param>
		// Token: 0x06001D27 RID: 7463 RVA: 0x0000B5FB File Offset: 0x000097FB
		public UnityWebRequest()
		{
			this.InternalCreate();
			this.InternalSetDefaults();
		}

		/// <summary>
		///   <para>Creates a UnityWebRequest with the default options and no attached DownloadHandler or UploadHandler. Default method is GET.</para>
		/// </summary>
		/// <param name="url">The target URL with which this UnityWebRequest will communicate. Also accessible via the url property.</param>
		// Token: 0x06001D28 RID: 7464 RVA: 0x0000B60F File Offset: 0x0000980F
		public UnityWebRequest(string url)
		{
			this.InternalCreate();
			this.InternalSetDefaults();
			this.url = url;
		}

		// Token: 0x06001D29 RID: 7465 RVA: 0x0000B62A File Offset: 0x0000982A
		public UnityWebRequest(string url, string method)
		{
			this.InternalCreate();
			this.InternalSetDefaults();
			this.url = url;
			this.method = method;
		}

		// Token: 0x06001D2A RID: 7466 RVA: 0x0000B64C File Offset: 0x0000984C
		public UnityWebRequest(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler)
		{
			this.InternalCreate();
			this.InternalSetDefaults();
			this.url = url;
			this.method = method;
			this.downloadHandler = downloadHandler;
			this.uploadHandler = uploadHandler;
		}

		/// <summary>
		///   <para>Creates a UnityWebRequest configured for HTTP GET.</para>
		/// </summary>
		/// <param name="uri">The URI of the resource to retrieve via HTTP GET.</param>
		/// <returns>
		///   <para>A UnityWebRequest object configured to retrieve data from uri.</para>
		/// </returns>
		// Token: 0x06001D2C RID: 7468 RVA: 0x00023AD4 File Offset: 0x00021CD4
		public static UnityWebRequest Get(string uri)
		{
			return new UnityWebRequest(uri, "GET", new DownloadHandlerBuffer(), null);
		}

		/// <summary>
		///   <para>Creates a UnityWebRequest configured for HTTP DELETE.</para>
		/// </summary>
		/// <param name="uri">The URI to which a DELETE request should be sent.</param>
		/// <returns>
		///   <para>A UnityWebRequest configured to send an HTTP DELETE request.</para>
		/// </returns>
		// Token: 0x06001D2D RID: 7469 RVA: 0x00023AF4 File Offset: 0x00021CF4
		public static UnityWebRequest Delete(string uri)
		{
			return new UnityWebRequest(uri, "DELETE");
		}

		/// <summary>
		///   <para>Creates a UnityWebRequest configured to send a HTTP HEAD request.</para>
		/// </summary>
		/// <param name="uri">The URI to which to send a HTTP HEAD request.</param>
		/// <returns>
		///   <para>A UnityWebRequest configured to transmit a HTTP HEAD request.</para>
		/// </returns>
		// Token: 0x06001D2E RID: 7470 RVA: 0x00023B10 File Offset: 0x00021D10
		public static UnityWebRequest Head(string uri)
		{
			return new UnityWebRequest(uri, "HEAD");
		}

		/// <summary>
		///   <para>Create a UnityWebRequest intended to download an image via HTTP GET and create a Texture based on the retrieved data.</para>
		/// </summary>
		/// <param name="uri">The URI of the image to download.</param>
		/// <param name="nonReadable">If true, the texture's raw data will not be accessible to script. This can conserve memory. Default: false.</param>
		/// <returns>
		///   <para>A UnityWebRequest properly configured to download an image and convert it to a Texture.</para>
		/// </returns>
		// Token: 0x06001D2F RID: 7471 RVA: 0x0000B67D File Offset: 0x0000987D
		public static UnityWebRequest GetTexture(string uri)
		{
			return UnityWebRequest.GetTexture(uri, false);
		}

		/// <summary>
		///   <para>Create a UnityWebRequest intended to download an image via HTTP GET and create a Texture based on the retrieved data.</para>
		/// </summary>
		/// <param name="uri">The URI of the image to download.</param>
		/// <param name="nonReadable">If true, the texture's raw data will not be accessible to script. This can conserve memory. Default: false.</param>
		/// <returns>
		///   <para>A UnityWebRequest properly configured to download an image and convert it to a Texture.</para>
		/// </returns>
		// Token: 0x06001D30 RID: 7472 RVA: 0x00023B2C File Offset: 0x00021D2C
		public static UnityWebRequest GetTexture(string uri, bool nonReadable)
		{
			return new UnityWebRequest(uri, "GET", new DownloadHandlerTexture(nonReadable), null);
		}

		// Token: 0x06001D31 RID: 7473 RVA: 0x0000B686 File Offset: 0x00009886
		public static UnityWebRequest GetAssetBundle(string uri)
		{
			return UnityWebRequest.GetAssetBundle(uri, 0U);
		}

		/// <summary>
		///   <para>Creates a UnityWebRequest optimized for downloading a Unity Asset Bundle via HTTP GET.</para>
		/// </summary>
		/// <param name="uri">The URI of the asset bundle to download.</param>
		/// <param name="crc">If nonzero, this number will be compared to the checksum of the downloaded asset bundle data. If the CRCs do not match, an error will be logged and the asset bundle will not be loaded. If set to zero, CRC checking will be skipped.</param>
		/// <param name="version">An integer version number, which will be compared to the cached version of the asset bundle to download. Increment this number to force Unity to redownload a cached asset bundle.
		///
		/// Analogous to the version parameter for WWW.LoadFromCacheOrDownload.</param>
		/// <param name="hash">A version hash. If this hash does not match the hash for the cached version of this asset bundle, the asset bundle will be redownloaded.</param>
		/// <returns>
		///   <para>A UnityWebRequest configured to downloading a Unity Asset Bundle.</para>
		/// </returns>
		// Token: 0x06001D32 RID: 7474 RVA: 0x00023B50 File Offset: 0x00021D50
		public static UnityWebRequest GetAssetBundle(string uri, uint crc)
		{
			return new UnityWebRequest(uri, "GET", new DownloadHandlerAssetBundle(uri, crc), null);
		}

		/// <summary>
		///   <para>Creates a UnityWebRequest optimized for downloading a Unity Asset Bundle via HTTP GET.</para>
		/// </summary>
		/// <param name="uri">The URI of the asset bundle to download.</param>
		/// <param name="crc">If nonzero, this number will be compared to the checksum of the downloaded asset bundle data. If the CRCs do not match, an error will be logged and the asset bundle will not be loaded. If set to zero, CRC checking will be skipped.</param>
		/// <param name="version">An integer version number, which will be compared to the cached version of the asset bundle to download. Increment this number to force Unity to redownload a cached asset bundle.
		///
		/// Analogous to the version parameter for WWW.LoadFromCacheOrDownload.</param>
		/// <param name="hash">A version hash. If this hash does not match the hash for the cached version of this asset bundle, the asset bundle will be redownloaded.</param>
		/// <returns>
		///   <para>A UnityWebRequest configured to downloading a Unity Asset Bundle.</para>
		/// </returns>
		// Token: 0x06001D33 RID: 7475 RVA: 0x00023B74 File Offset: 0x00021D74
		public static UnityWebRequest GetAssetBundle(string uri, uint version, uint crc)
		{
			return new UnityWebRequest(uri, "GET", new DownloadHandlerAssetBundle(uri, version, crc), null);
		}

		/// <summary>
		///   <para>Creates a UnityWebRequest optimized for downloading a Unity Asset Bundle via HTTP GET.</para>
		/// </summary>
		/// <param name="uri">The URI of the asset bundle to download.</param>
		/// <param name="crc">If nonzero, this number will be compared to the checksum of the downloaded asset bundle data. If the CRCs do not match, an error will be logged and the asset bundle will not be loaded. If set to zero, CRC checking will be skipped.</param>
		/// <param name="version">An integer version number, which will be compared to the cached version of the asset bundle to download. Increment this number to force Unity to redownload a cached asset bundle.
		///
		/// Analogous to the version parameter for WWW.LoadFromCacheOrDownload.</param>
		/// <param name="hash">A version hash. If this hash does not match the hash for the cached version of this asset bundle, the asset bundle will be redownloaded.</param>
		/// <returns>
		///   <para>A UnityWebRequest configured to downloading a Unity Asset Bundle.</para>
		/// </returns>
		// Token: 0x06001D34 RID: 7476 RVA: 0x00023B98 File Offset: 0x00021D98
		public static UnityWebRequest GetAssetBundle(string uri, Hash128 hash, uint crc)
		{
			return new UnityWebRequest(uri, "GET", new DownloadHandlerAssetBundle(uri, hash, crc), null);
		}

		/// <summary>
		///   <para>Create a UnityWebRequest configured to upload raw data to a remote server via HTTP PUT.</para>
		/// </summary>
		/// <param name="uri">The URI to which the data will be sent.</param>
		/// <param name="bodyData">The data to transmit to the remote server.
		///
		/// If a string, the string will be converted to raw bytes via &lt;a href="http:msdn.microsoft.comen-uslibrarysystem.text.encoding.utf8"&gt;System.Text.Encoding.UTF8&lt;a&gt;.</param>
		/// <returns>
		///   <para>A UnityWebRequest configured to transmit bodyData to uri via HTTP PUT.</para>
		/// </returns>
		// Token: 0x06001D35 RID: 7477 RVA: 0x00023BBC File Offset: 0x00021DBC
		public static UnityWebRequest Put(string uri, byte[] bodyData)
		{
			return new UnityWebRequest(uri, "PUT", new DownloadHandlerBuffer(), new UploadHandlerRaw(bodyData));
		}

		/// <summary>
		///   <para>Create a UnityWebRequest configured to upload raw data to a remote server via HTTP PUT.</para>
		/// </summary>
		/// <param name="uri">The URI to which the data will be sent.</param>
		/// <param name="bodyData">The data to transmit to the remote server.
		///
		/// If a string, the string will be converted to raw bytes via &lt;a href="http:msdn.microsoft.comen-uslibrarysystem.text.encoding.utf8"&gt;System.Text.Encoding.UTF8&lt;a&gt;.</param>
		/// <returns>
		///   <para>A UnityWebRequest configured to transmit bodyData to uri via HTTP PUT.</para>
		/// </returns>
		// Token: 0x06001D36 RID: 7478 RVA: 0x00023BE4 File Offset: 0x00021DE4
		public static UnityWebRequest Put(string uri, string bodyData)
		{
			return new UnityWebRequest(uri, "PUT", new DownloadHandlerBuffer(), new UploadHandlerRaw(Encoding.UTF8.GetBytes(bodyData)));
		}

		/// <summary>
		///   <para>Create a UnityWebRequest configured to send form data to a server via HTTP POST.</para>
		/// </summary>
		/// <param name="uri">The target URI to which form data will be transmitted.</param>
		/// <param name="postData">Form body data. Will be URLEncoded via WWWTranscoder.URLEncode prior to transmission.</param>
		/// <returns>
		///   <para>A UnityWebRequest configured to send form data to uri via POST.</para>
		/// </returns>
		// Token: 0x06001D37 RID: 7479 RVA: 0x00023C14 File Offset: 0x00021E14
		public static UnityWebRequest Post(string uri, string postData)
		{
			UnityWebRequest unityWebRequest = new UnityWebRequest(uri, "POST");
			string text = WWWTranscoder.URLEncode(postData, Encoding.UTF8);
			unityWebRequest.uploadHandler = new UploadHandlerRaw(Encoding.UTF8.GetBytes(text));
			unityWebRequest.uploadHandler.contentType = "application/x-www-form-urlencoded";
			unityWebRequest.downloadHandler = new DownloadHandlerBuffer();
			return unityWebRequest;
		}

		/// <summary>
		///   <para>Create a UnityWebRequest configured to send form data to a server via HTTP POST.</para>
		/// </summary>
		/// <param name="uri">The target URI to which form data will be transmitted.</param>
		/// <param name="formData">Form fields or files encapsulated in a WWWForm object, for formatting and transmission to the remote server.</param>
		/// <returns>
		///   <para>A UnityWebRequest configured to send form data to uri via POST.</para>
		/// </returns>
		// Token: 0x06001D38 RID: 7480 RVA: 0x00023C6C File Offset: 0x00021E6C
		public static UnityWebRequest Post(string uri, WWWForm formData)
		{
			UnityWebRequest unityWebRequest = new UnityWebRequest(uri, "POST");
			unityWebRequest.uploadHandler = new UploadHandlerRaw(formData.data);
			unityWebRequest.downloadHandler = new DownloadHandlerBuffer();
			Dictionary<string, string> headers = formData.headers;
			foreach (KeyValuePair<string, string> keyValuePair in headers)
			{
				unityWebRequest.SetRequestHeader(keyValuePair.Key, keyValuePair.Value);
			}
			return unityWebRequest;
		}

		// Token: 0x06001D39 RID: 7481 RVA: 0x00023D00 File Offset: 0x00021F00
		public static UnityWebRequest Post(string uri, List<IMultipartFormSection> multipartFormSections)
		{
			byte[] array = UnityWebRequest.GenerateBoundary();
			return UnityWebRequest.Post(uri, multipartFormSections, array);
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x00023D1C File Offset: 0x00021F1C
		public static UnityWebRequest Post(string uri, List<IMultipartFormSection> multipartFormSections, byte[] boundary)
		{
			UnityWebRequest unityWebRequest = new UnityWebRequest(uri, "POST");
			byte[] array = UnityWebRequest.SerializeFormSections(multipartFormSections, boundary);
			unityWebRequest.uploadHandler = new UploadHandlerRaw(array)
			{
				contentType = "multipart/form-data; boundary=" + Encoding.UTF8.GetString(boundary, 0, boundary.Length)
			};
			unityWebRequest.downloadHandler = new DownloadHandlerBuffer();
			return unityWebRequest;
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x00023D78 File Offset: 0x00021F78
		public static UnityWebRequest Post(string uri, Dictionary<string, string> formFields)
		{
			UnityWebRequest unityWebRequest = new UnityWebRequest(uri, "POST");
			byte[] array = UnityWebRequest.SerializeSimpleForm(formFields);
			unityWebRequest.uploadHandler = new UploadHandlerRaw(array)
			{
				contentType = "application/x-www-form-urlencoded"
			};
			unityWebRequest.downloadHandler = new DownloadHandlerBuffer();
			return unityWebRequest;
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x00023DC0 File Offset: 0x00021FC0
		public static byte[] SerializeFormSections(List<IMultipartFormSection> multipartFormSections, byte[] boundary)
		{
			byte[] bytes = Encoding.UTF8.GetBytes("\r\n");
			int num = 0;
			foreach (IMultipartFormSection multipartFormSection in multipartFormSections)
			{
				num += 64 + multipartFormSection.sectionData.Length;
			}
			List<byte> list = new List<byte>(num);
			foreach (IMultipartFormSection multipartFormSection2 in multipartFormSections)
			{
				string text = "form-data";
				string sectionName = multipartFormSection2.sectionName;
				string fileName = multipartFormSection2.fileName;
				if (!string.IsNullOrEmpty(fileName))
				{
					text = "file";
				}
				string text2 = "Content-Disposition: " + text;
				if (!string.IsNullOrEmpty(sectionName))
				{
					text2 = text2 + "; name=\"" + sectionName + "\"";
				}
				if (!string.IsNullOrEmpty(fileName))
				{
					text2 = text2 + "; filename=\"" + fileName + "\"";
				}
				text2 += "\r\n";
				string contentType = multipartFormSection2.contentType;
				if (!string.IsNullOrEmpty(contentType))
				{
					text2 = text2 + "Content-Type: " + contentType + "\r\n";
				}
				list.AddRange(boundary);
				list.AddRange(bytes);
				list.AddRange(Encoding.UTF8.GetBytes(text2));
				list.AddRange(bytes);
				list.AddRange(multipartFormSection2.sectionData);
			}
			list.TrimExcess();
			return list.ToArray();
		}

		/// <summary>
		///   <para>Generate a random 40-byte array for use as a multipart form boundary.</para>
		/// </summary>
		/// <returns>
		///   <para>40 random bytes, guaranteed to contain only printable ASCII values.</para>
		/// </returns>
		// Token: 0x06001D3D RID: 7485 RVA: 0x00023F8C File Offset: 0x0002218C
		public static byte[] GenerateBoundary()
		{
			byte[] array = new byte[40];
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
				array[i] = (byte)num;
			}
			return array;
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x00023FDC File Offset: 0x000221DC
		public static byte[] SerializeSimpleForm(Dictionary<string, string> formFields)
		{
			string text = string.Empty;
			foreach (KeyValuePair<string, string> keyValuePair in formFields)
			{
				if (text.Length > 0)
				{
					text += "&";
				}
				text = text + Uri.EscapeDataString(keyValuePair.Key) + "=" + Uri.EscapeDataString(keyValuePair.Value);
			}
			return Encoding.UTF8.GetBytes(text);
		}

		/// <summary>
		///   <para>If true, any DownloadHandler attached to this UnityWebRequest will have DownloadHandler.Dispose called automatically when UnityWebRequest.Dispose is called.</para>
		/// </summary>
		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06001D3F RID: 7487 RVA: 0x0000B68F File Offset: 0x0000988F
		// (set) Token: 0x06001D40 RID: 7488 RVA: 0x0000B697 File Offset: 0x00009897
		public bool disposeDownloadHandlerOnDispose { get; set; }

		/// <summary>
		///   <para>If true, any UploadHandler attached to this UnityWebRequest will have UploadHandler.Dispose called automatically when UnityWebRequest.Dispose is called.</para>
		/// </summary>
		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06001D41 RID: 7489 RVA: 0x0000B6A0 File Offset: 0x000098A0
		// (set) Token: 0x06001D42 RID: 7490 RVA: 0x0000B6A8 File Offset: 0x000098A8
		public bool disposeUploadHandlerOnDispose { get; set; }

		// Token: 0x06001D43 RID: 7491
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void InternalCreate();

		// Token: 0x06001D44 RID: 7492
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void InternalDestroy();

		// Token: 0x06001D45 RID: 7493 RVA: 0x0000B6B1 File Offset: 0x000098B1
		private void InternalSetDefaults()
		{
			this.disposeDownloadHandlerOnDispose = true;
			this.disposeUploadHandlerOnDispose = true;
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x00024078 File Offset: 0x00022278
		~UnityWebRequest()
		{
			this.InternalDestroy();
		}

		/// <summary>
		///   <para>Signals that this [UnityWebRequest] is no longer being used, and should clean up any resources it is using.</para>
		/// </summary>
		// Token: 0x06001D47 RID: 7495 RVA: 0x000240A8 File Offset: 0x000222A8
		public void Dispose()
		{
			if (this.disposeDownloadHandlerOnDispose)
			{
				DownloadHandler downloadHandler = this.downloadHandler;
				if (downloadHandler != null)
				{
					downloadHandler.Dispose();
				}
			}
			if (this.disposeUploadHandlerOnDispose)
			{
				UploadHandler uploadHandler = this.uploadHandler;
				if (uploadHandler != null)
				{
					uploadHandler.Dispose();
				}
			}
			this.InternalDestroy();
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001D48 RID: 7496
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern AsyncOperation InternalBegin();

		// Token: 0x06001D49 RID: 7497
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void InternalAbort();

		/// <summary>
		///   <para>Begin communicating with the remote server.</para>
		/// </summary>
		/// <returns>
		///   <para>An AsyncOperation indicating the progress/completion state of the UnityWebRequest. Yield this object to wait until the UnityWebRequest is done.</para>
		/// </returns>
		// Token: 0x06001D4A RID: 7498 RVA: 0x0000B6C1 File Offset: 0x000098C1
		public AsyncOperation Send()
		{
			return this.InternalBegin();
		}

		/// <summary>
		///   <para>If in progress, halts the UnityWebRequest as soon as possible.</para>
		/// </summary>
		// Token: 0x06001D4B RID: 7499 RVA: 0x0000B6C9 File Offset: 0x000098C9
		public void Abort()
		{
			this.InternalAbort();
		}

		// Token: 0x06001D4C RID: 7500
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void InternalSetMethod(UnityWebRequest.UnityWebRequestMethod methodType);

		// Token: 0x06001D4D RID: 7501
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void InternalSetCustomMethod(string customMethodName);

		// Token: 0x06001D4E RID: 7502
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern int InternalGetMethod();

		// Token: 0x06001D4F RID: 7503
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern string InternalGetCustomMethod();

		/// <summary>
		///   <para>Defines the HTTP verb used by this UnityWebRequest, such as GET or POST.</para>
		/// </summary>
		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06001D50 RID: 7504 RVA: 0x00024100 File Offset: 0x00022300
		// (set) Token: 0x06001D51 RID: 7505 RVA: 0x00024150 File Offset: 0x00022350
		public string method
		{
			get
			{
				switch (this.InternalGetMethod())
				{
				case 0:
					return "GET";
				case 1:
					return "POST";
				case 2:
					return "PUT";
				case 3:
					return "HEAD";
				default:
					return this.InternalGetCustomMethod();
				}
			}
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentException("Cannot set a UnityWebRequest's method to an empty or null string");
				}
				string text = value.ToUpper();
				switch (text)
				{
				case "GET":
					this.InternalSetMethod(UnityWebRequest.UnityWebRequestMethod.Get);
					return;
				case "POST":
					this.InternalSetMethod(UnityWebRequest.UnityWebRequestMethod.Post);
					return;
				case "PUT":
					this.InternalSetMethod(UnityWebRequest.UnityWebRequestMethod.Put);
					return;
				case "HEAD":
					this.InternalSetMethod(UnityWebRequest.UnityWebRequestMethod.Head);
					return;
				}
				this.InternalSetCustomMethod(value.ToUpper());
			}
		}

		// Token: 0x06001D52 RID: 7506
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern int InternalGetError();

		/// <summary>
		///   <para>A human-readable string describing any system errors encountered by this UnityWebRequest object while handling HTTP requests or responses. (Read Only)</para>
		/// </summary>
		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06001D53 RID: 7507
		public extern string error
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Determines whether this UnityWebRequest will include Expect: 100-Continue in its outgoing request headers. (Default: true).</para>
		/// </summary>
		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06001D54 RID: 7508
		// (set) Token: 0x06001D55 RID: 7509
		public extern bool useHttpContinue
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Defines the target URL for the UnityWebRequest to communicate with.</para>
		/// </summary>
		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06001D56 RID: 7510 RVA: 0x0000B6D1 File Offset: 0x000098D1
		// (set) Token: 0x06001D57 RID: 7511 RVA: 0x00024238 File Offset: 0x00022438
		public string url
		{
			get
			{
				return this.InternalGetUrl();
			}
			set
			{
				string text = value;
				string text2 = "http://localhost/";
				Uri uri = new Uri(text2);
				if (text.StartsWith("//"))
				{
					text = uri.Scheme + ":" + text;
				}
				if (text.StartsWith("/"))
				{
					text = uri.Scheme + "://" + uri.Host + text;
				}
				if (UnityWebRequest.domainRegex.IsMatch(text))
				{
					text = uri.Scheme + "://" + text;
				}
				Uri uri2 = null;
				try
				{
					uri2 = new Uri(text);
				}
				catch (FormatException ex)
				{
					try
					{
						uri2 = new Uri(uri, text);
					}
					catch (FormatException)
					{
						throw ex;
					}
				}
				this.InternalSetUrl(uri2.AbsoluteUri);
			}
		}

		// Token: 0x06001D58 RID: 7512
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern string InternalGetUrl();

		// Token: 0x06001D59 RID: 7513
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void InternalSetUrl(string url);

		/// <summary>
		///   <para>The numeric HTTP response code returned by the server, such as 200, 404 or 500. (Read Only)</para>
		/// </summary>
		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06001D5A RID: 7514
		public extern long responseCode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns a floating-point value between 0.0 and 1.0, indicating the progress of uploading body data to the server.</para>
		/// </summary>
		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06001D5B RID: 7515
		public extern float uploadProgress
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns true while a UnityWebRequest’s configuration properties can be altered. (Read Only)</para>
		/// </summary>
		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06001D5C RID: 7516
		public extern bool isModifiable
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns true after the UnityWebRequest has finished communicating with the remote server. (Read Only)</para>
		/// </summary>
		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06001D5D RID: 7517
		public extern bool isDone
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns true after this UnityWebRequest encounters a system error. (Read Only)</para>
		/// </summary>
		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06001D5E RID: 7518
		public extern bool isError
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns a floating-point value between 0.0 and 1.0, indicating the progress of downloading body data from the server. (Read Only)</para>
		/// </summary>
		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06001D5F RID: 7519
		public extern float downloadProgress
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns the number of bytes of body data the system has uploaded to the remote server. (Read Only)</para>
		/// </summary>
		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06001D60 RID: 7520
		public extern ulong uploadedBytes
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns the number of bytes of body data the system has downloaded from the remote server. (Read Only)</para>
		/// </summary>
		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06001D61 RID: 7521
		public extern ulong downloadedBytes
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Indicates the number of redirects which this UnityWebRequest will follow before halting with a “Redirect Limit Exceeded” system error.</para>
		/// </summary>
		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06001D62 RID: 7522
		// (set) Token: 0x06001D63 RID: 7523
		public extern int redirectLimit
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Indicates whether the UnityWebRequest system should employ the HTTP/1.1 chunked-transfer encoding method.</para>
		/// </summary>
		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06001D64 RID: 7524
		// (set) Token: 0x06001D65 RID: 7525
		public extern bool chunkedTransfer
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Retrieves the value of a custom request header.</para>
		/// </summary>
		/// <param name="name">Name of the custom request header. Case-sensitive.</param>
		/// <returns>
		///   <para>The value of the custom request header. If no custom header with a matching name has been set, returns an empty string.</para>
		/// </returns>
		// Token: 0x06001D66 RID: 7526
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern string GetRequestHeader(string name);

		// Token: 0x06001D67 RID: 7527
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void InternalSetRequestHeader(string name, string value);

		/// <summary>
		///   <para>Set a HTTP request header to a custom value.</para>
		/// </summary>
		/// <param name="name">The key of the header to be set. Case-sensitive.</param>
		/// <param name="value">The header's intended value.</param>
		// Token: 0x06001D68 RID: 7528 RVA: 0x00024314 File Offset: 0x00022514
		public void SetRequestHeader(string name, string value)
		{
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentException("Cannot set a Request Header with a null or empty name");
			}
			if (string.IsNullOrEmpty(value))
			{
				throw new ArgumentException("Cannot set a Request header with a null or empty value");
			}
			if (!UnityWebRequest.IsHeaderNameLegal(name))
			{
				throw new ArgumentException("Cannot set Request Header " + name + " - name contains illegal characters or is not user-overridable");
			}
			if (!UnityWebRequest.IsHeaderValueLegal(value))
			{
				throw new ArgumentException("Cannot set Request Header - value contains illegal characters");
			}
			this.InternalSetRequestHeader(name, value);
		}

		/// <summary>
		///   <para>Retrieves the value of a response header from the latest HTTP response received.</para>
		/// </summary>
		/// <param name="name">The name of the HTTP header to retrieve. Case-sensitive.</param>
		/// <returns>
		///   <para>The value of the HTTP header from the latest HTTP response. If no header with a matching name has been received, or no responses have been received, returns null.</para>
		/// </returns>
		// Token: 0x06001D69 RID: 7529
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern string GetResponseHeader(string name);

		// Token: 0x06001D6A RID: 7530
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern string[] InternalGetResponseHeaderKeys();

		/// <summary>
		///   <para>Retrieves a dictionary containing all the response headers received by this UnityWebRequest in the latest HTTP response.</para>
		/// </summary>
		/// <returns>
		///   <para>A dictionary containing all the response headers received in the latest HTTP response. If no responses have been received, returns null.</para>
		/// </returns>
		// Token: 0x06001D6B RID: 7531 RVA: 0x0002438C File Offset: 0x0002258C
		public Dictionary<string, string> GetResponseHeaders()
		{
			string[] array = this.InternalGetResponseHeaderKeys();
			if (array == null)
			{
				return null;
			}
			Dictionary<string, string> dictionary = new Dictionary<string, string>(array.Length);
			for (int i = 0; i < array.Length; i++)
			{
				string responseHeader = this.GetResponseHeader(array[i]);
				dictionary.Add(array[i], responseHeader);
			}
			return dictionary;
		}

		/// <summary>
		///   <para>Holds a reference to the UploadHandler object which manages body data to be uploaded to the remote server.</para>
		/// </summary>
		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06001D6C RID: 7532
		// (set) Token: 0x06001D6D RID: 7533
		public extern UploadHandler uploadHandler
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Holds a reference to a DownloadHandler object, which manages body data received from the remote server by this UnityWebRequest.</para>
		/// </summary>
		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06001D6E RID: 7534
		// (set) Token: 0x06001D6F RID: 7535
		public extern DownloadHandler downloadHandler
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06001D70 RID: 7536 RVA: 0x000243DC File Offset: 0x000225DC
		private static bool ContainsForbiddenCharacters(string s, int firstAllowedCharCode)
		{
			foreach (char c in s)
			{
				if ((int)c < firstAllowedCharCode || c == '\u007f')
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001D71 RID: 7537 RVA: 0x0002441C File Offset: 0x0002261C
		private static bool IsHeaderNameLegal(string headerName)
		{
			if (string.IsNullOrEmpty(headerName))
			{
				return false;
			}
			headerName = headerName.ToLower();
			if (UnityWebRequest.ContainsForbiddenCharacters(headerName, 33))
			{
				return false;
			}
			if (headerName.StartsWith("sec-") || headerName.StartsWith("proxy-"))
			{
				return false;
			}
			foreach (string text in UnityWebRequest.forbiddenHeaderKeys)
			{
				if (string.Equals(headerName, text))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x0000B6D9 File Offset: 0x000098D9
		private static bool IsHeaderValueLegal(string headerValue)
		{
			return !string.IsNullOrEmpty(headerValue) && !UnityWebRequest.ContainsForbiddenCharacters(headerValue, 32);
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x0002449C File Offset: 0x0002269C
		private static string GetErrorDescription(UnityWebRequest.UnityWebRequestError errorCode)
		{
			switch (errorCode)
			{
			case UnityWebRequest.UnityWebRequestError.OK:
				return "No Error";
			case UnityWebRequest.UnityWebRequestError.SDKError:
				return "Internal Error With Transport Layer";
			case UnityWebRequest.UnityWebRequestError.UnsupportedProtocol:
				return "Specified Transport Protocol is Unsupported";
			case UnityWebRequest.UnityWebRequestError.MalformattedUrl:
				return "URL is Malformatted";
			case UnityWebRequest.UnityWebRequestError.CannotResolveProxy:
				return "Unable to resolve specified proxy server";
			case UnityWebRequest.UnityWebRequestError.CannotResolveHost:
				return "Unable to resolve host specified in URL";
			case UnityWebRequest.UnityWebRequestError.CannotConnectToHost:
				return "Unable to connect to host specified in URL";
			case UnityWebRequest.UnityWebRequestError.AccessDenied:
				return "Remote server denied access to the specified URL";
			case UnityWebRequest.UnityWebRequestError.GenericHTTPError:
				return "Unknown/Generic HTTP Error - Check HTTP Error code";
			case UnityWebRequest.UnityWebRequestError.WriteError:
				return "Error when transmitting request to remote server - transmission terminated prematurely";
			case UnityWebRequest.UnityWebRequestError.ReadError:
				return "Error when reading response from remote server - transmission terminated prematurely";
			case UnityWebRequest.UnityWebRequestError.OutOfMemory:
				return "Out of Memory";
			case UnityWebRequest.UnityWebRequestError.Timeout:
				return "Timeout occurred while waiting for response from remote server";
			case UnityWebRequest.UnityWebRequestError.HTTPPostError:
				return "Error while transmitting HTTP POST body data";
			case UnityWebRequest.UnityWebRequestError.SSLCannotConnect:
				return "Unable to connect to SSL server at remote host";
			case UnityWebRequest.UnityWebRequestError.Aborted:
				return "Request was manually aborted by local code";
			case UnityWebRequest.UnityWebRequestError.TooManyRedirects:
				return "Redirect limit exceeded";
			case UnityWebRequest.UnityWebRequestError.ReceivedNoData:
				return "Received an empty response from remote host";
			case UnityWebRequest.UnityWebRequestError.SSLNotSupported:
				return "SSL connections are not supported on the local machine";
			case UnityWebRequest.UnityWebRequestError.FailedToSendData:
				return "Failed to transmit body data";
			case UnityWebRequest.UnityWebRequestError.FailedToReceiveData:
				return "Failed to receive response body data";
			case UnityWebRequest.UnityWebRequestError.SSLCertificateError:
				return "Failure to authenticate SSL certificate of remote host";
			case UnityWebRequest.UnityWebRequestError.SSLCipherNotAvailable:
				return "SSL cipher received from remote host is not supported on the local machine";
			case UnityWebRequest.UnityWebRequestError.SSLCACertError:
				return "Failure to authenticate Certificate Authority of the SSL certificate received from the remote host";
			case UnityWebRequest.UnityWebRequestError.UnrecognizedContentEncoding:
				return "Remote host returned data with an unrecognized/unparseable content encoding";
			case UnityWebRequest.UnityWebRequestError.LoginFailed:
				return "HTTP authentication failed";
			case UnityWebRequest.UnityWebRequestError.SSLShutdownFailed:
				return "Failure while shutting down SSL connection";
			}
			return "Unknown error";
		}

		/// <summary>
		///   <para>The string "GET", commonly used as the verb for an HTTP GET request.</para>
		/// </summary>
		// Token: 0x040007B3 RID: 1971
		public const string kHttpVerbGET = "GET";

		/// <summary>
		///   <para>The string "HEAD", commonly used as the verb for an HTTP HEAD request.</para>
		/// </summary>
		// Token: 0x040007B4 RID: 1972
		public const string kHttpVerbHEAD = "HEAD";

		/// <summary>
		///   <para>The string "POST", commonly used as the verb for an HTTP POST request.</para>
		/// </summary>
		// Token: 0x040007B5 RID: 1973
		public const string kHttpVerbPOST = "POST";

		/// <summary>
		///   <para>The string "PUT", commonly used as the verb for an HTTP PUT request.</para>
		/// </summary>
		// Token: 0x040007B6 RID: 1974
		public const string kHttpVerbPUT = "PUT";

		/// <summary>
		///   <para>The string "CREATE", commonly used as the verb for an HTTP CREATE request.</para>
		/// </summary>
		// Token: 0x040007B7 RID: 1975
		public const string kHttpVerbCREATE = "CREATE";

		/// <summary>
		///   <para>The string "DELETE", commonly used as the verb for an HTTP DELETE request.</para>
		/// </summary>
		// Token: 0x040007B8 RID: 1976
		public const string kHttpVerbDELETE = "DELETE";

		// Token: 0x040007B9 RID: 1977
		[NonSerialized]
		internal IntPtr m_Ptr;

		// Token: 0x040007BA RID: 1978
		private static Regex domainRegex = new Regex("^\\s*\\w+(?:\\.\\w+)+\\s*$");

		// Token: 0x040007BB RID: 1979
		private static readonly string[] forbiddenHeaderKeys = new string[]
		{
			"accept-charset", "accept-encoding", "access-control-request-headers", "access-control-request-method", "connection", "content-length", "cookie", "cookie2", "date", "dnt",
			"expect", "host", "keep-alive", "origin", "referer", "te", "trailer", "transfer-encoding", "upgrade", "user-agent",
			"via", "x-unity-version"
		};

		// Token: 0x020001F0 RID: 496
		internal enum UnityWebRequestMethod
		{
			// Token: 0x040007C0 RID: 1984
			Get,
			// Token: 0x040007C1 RID: 1985
			Post,
			// Token: 0x040007C2 RID: 1986
			Put,
			// Token: 0x040007C3 RID: 1987
			Head,
			// Token: 0x040007C4 RID: 1988
			Custom
		}

		// Token: 0x020001F1 RID: 497
		internal enum UnityWebRequestError
		{
			// Token: 0x040007C6 RID: 1990
			OK,
			// Token: 0x040007C7 RID: 1991
			Unknown,
			// Token: 0x040007C8 RID: 1992
			SDKError,
			// Token: 0x040007C9 RID: 1993
			UnsupportedProtocol,
			// Token: 0x040007CA RID: 1994
			MalformattedUrl,
			// Token: 0x040007CB RID: 1995
			CannotResolveProxy,
			// Token: 0x040007CC RID: 1996
			CannotResolveHost,
			// Token: 0x040007CD RID: 1997
			CannotConnectToHost,
			// Token: 0x040007CE RID: 1998
			AccessDenied,
			// Token: 0x040007CF RID: 1999
			GenericHTTPError,
			// Token: 0x040007D0 RID: 2000
			WriteError,
			// Token: 0x040007D1 RID: 2001
			ReadError,
			// Token: 0x040007D2 RID: 2002
			OutOfMemory,
			// Token: 0x040007D3 RID: 2003
			Timeout,
			// Token: 0x040007D4 RID: 2004
			HTTPPostError,
			// Token: 0x040007D5 RID: 2005
			SSLCannotConnect,
			// Token: 0x040007D6 RID: 2006
			Aborted,
			// Token: 0x040007D7 RID: 2007
			TooManyRedirects,
			// Token: 0x040007D8 RID: 2008
			ReceivedNoData,
			// Token: 0x040007D9 RID: 2009
			SSLNotSupported,
			// Token: 0x040007DA RID: 2010
			FailedToSendData,
			// Token: 0x040007DB RID: 2011
			FailedToReceiveData,
			// Token: 0x040007DC RID: 2012
			SSLCertificateError,
			// Token: 0x040007DD RID: 2013
			SSLCipherNotAvailable,
			// Token: 0x040007DE RID: 2014
			SSLCACertError,
			// Token: 0x040007DF RID: 2015
			UnrecognizedContentEncoding,
			// Token: 0x040007E0 RID: 2016
			LoginFailed,
			// Token: 0x040007E1 RID: 2017
			SSLShutdownFailed
		}
	}
}
