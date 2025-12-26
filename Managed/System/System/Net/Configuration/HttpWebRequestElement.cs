using System;
using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Represents the maximum length for response headers. This class cannot be inherited.</summary>
	// Token: 0x020002E3 RID: 739
	public sealed class HttpWebRequestElement : ConfigurationElement
	{
		// Token: 0x06001929 RID: 6441 RVA: 0x0004C234 File Offset: 0x0004A434
		static HttpWebRequestElement()
		{
			HttpWebRequestElement.properties.Add(HttpWebRequestElement.maximumErrorResponseLengthProp);
			HttpWebRequestElement.properties.Add(HttpWebRequestElement.maximumResponseHeadersLengthProp);
			HttpWebRequestElement.properties.Add(HttpWebRequestElement.maximumUnauthorizedUploadLengthProp);
			HttpWebRequestElement.properties.Add(HttpWebRequestElement.useUnsafeHeaderParsingProp);
		}

		/// <summary>Gets or sets the maximum allowed length of an error response.</summary>
		/// <returns>A 32-bit signed integer containing the maximum length in kilobytes (1024 bytes) of the error response. The default value is 64.</returns>
		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x000128F4 File Offset: 0x00010AF4
		// (set) Token: 0x0600192B RID: 6443 RVA: 0x00012906 File Offset: 0x00010B06
		[ConfigurationProperty("maximumErrorResponseLength", DefaultValue = "64")]
		public int MaximumErrorResponseLength
		{
			get
			{
				return (int)base[HttpWebRequestElement.maximumErrorResponseLengthProp];
			}
			set
			{
				base[HttpWebRequestElement.maximumErrorResponseLengthProp] = value;
			}
		}

		/// <summary>Gets or sets the maximum allowed length of the response headers.</summary>
		/// <returns>A 32-bit signed integer containing the maximum length in kilobytes (1024 bytes) of the response headers. The default value is 64.</returns>
		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x0600192C RID: 6444 RVA: 0x00012919 File Offset: 0x00010B19
		// (set) Token: 0x0600192D RID: 6445 RVA: 0x0001292B File Offset: 0x00010B2B
		[ConfigurationProperty("maximumResponseHeadersLength", DefaultValue = "64")]
		public int MaximumResponseHeadersLength
		{
			get
			{
				return (int)base[HttpWebRequestElement.maximumResponseHeadersLengthProp];
			}
			set
			{
				base[HttpWebRequestElement.maximumResponseHeadersLengthProp] = value;
			}
		}

		/// <summary>Gets or sets the maximum length of an upload in response to an unauthorized error code.</summary>
		/// <returns>A 32-bit signed integer containing the maximum length (in bytes) of an upload in respons to an unauthorized error code. A value of -1 indicates that no size limit will be imposed on the upload. The default value is -1.</returns>
		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x0600192E RID: 6446 RVA: 0x0001293E File Offset: 0x00010B3E
		// (set) Token: 0x0600192F RID: 6447 RVA: 0x00012950 File Offset: 0x00010B50
		[ConfigurationProperty("maximumUnauthorizedUploadLength", DefaultValue = "-1")]
		public int MaximumUnauthorizedUploadLength
		{
			get
			{
				return (int)base[HttpWebRequestElement.maximumUnauthorizedUploadLengthProp];
			}
			set
			{
				base[HttpWebRequestElement.maximumUnauthorizedUploadLengthProp] = value;
			}
		}

		/// <summary>Setting this property ignores validation errors that occur during HTTP parsing.</summary>
		/// <returns>Boolean that indicates whether this property has been set. </returns>
		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001930 RID: 6448 RVA: 0x00012963 File Offset: 0x00010B63
		// (set) Token: 0x06001931 RID: 6449 RVA: 0x00012975 File Offset: 0x00010B75
		[ConfigurationProperty("useUnsafeHeaderParsing", DefaultValue = "False")]
		public bool UseUnsafeHeaderParsing
		{
			get
			{
				return (bool)base[HttpWebRequestElement.useUnsafeHeaderParsingProp];
			}
			set
			{
				base[HttpWebRequestElement.useUnsafeHeaderParsingProp] = value;
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001932 RID: 6450 RVA: 0x00012988 File Offset: 0x00010B88
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return HttpWebRequestElement.properties;
			}
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x00004F1D File Offset: 0x0000311D
		[global::System.MonoTODO]
		protected override void PostDeserialize()
		{
			base.PostDeserialize();
		}

		// Token: 0x04000FE3 RID: 4067
		private static ConfigurationProperty maximumErrorResponseLengthProp = new ConfigurationProperty("maximumErrorResponseLength", typeof(int), 64);

		// Token: 0x04000FE4 RID: 4068
		private static ConfigurationProperty maximumResponseHeadersLengthProp = new ConfigurationProperty("maximumResponseHeadersLength", typeof(int), 64);

		// Token: 0x04000FE5 RID: 4069
		private static ConfigurationProperty maximumUnauthorizedUploadLengthProp = new ConfigurationProperty("maximumUnauthorizedUploadLength", typeof(int), -1);

		// Token: 0x04000FE6 RID: 4070
		private static ConfigurationProperty useUnsafeHeaderParsingProp = new ConfigurationProperty("useUnsafeHeaderParsing", typeof(bool), false);

		// Token: 0x04000FE7 RID: 4071
		private static ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();
	}
}
