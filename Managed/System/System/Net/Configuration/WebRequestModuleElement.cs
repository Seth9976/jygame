using System;
using System.ComponentModel;
using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Represents a URI prefix and the associated class that handles creating Web requests for the prefix. This class cannot be inherited.</summary>
	// Token: 0x020002F8 RID: 760
	public sealed class WebRequestModuleElement : ConfigurationElement
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.WebRequestModuleElement" /> class. </summary>
		// Token: 0x060019BC RID: 6588 RVA: 0x000056FB File Offset: 0x000038FB
		public WebRequestModuleElement()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.WebRequestModuleElement" /> class using the specified URI prefix and type information. </summary>
		/// <param name="prefix">A string containing a URI prefix.</param>
		/// <param name="type">A string containing the type and assembly information for the class that handles creating requests for resources that use the <paramref name="prefix" /> URI prefix. For more information, see the Remarks section.</param>
		// Token: 0x060019BD RID: 6589 RVA: 0x00013077 File Offset: 0x00011277
		public WebRequestModuleElement(string prefix, string type)
		{
			base[WebRequestModuleElement.typeProp] = type;
			this.Prefix = prefix;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.WebRequestModuleElement" /> class using the specified URI prefix and type identifier.</summary>
		/// <param name="prefix">A string containing a URI prefix.</param>
		/// <param name="type">A <see cref="T:System.Type" /> that identifies the class that handles creating requests for resources that use the <paramref name="prefix" /> URI prefix. </param>
		// Token: 0x060019BE RID: 6590 RVA: 0x00013092 File Offset: 0x00011292
		public WebRequestModuleElement(string prefix, Type type)
			: this(prefix, type.FullName)
		{
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x0004CC10 File Offset: 0x0004AE10
		static WebRequestModuleElement()
		{
			WebRequestModuleElement.properties.Add(WebRequestModuleElement.prefixProp);
			WebRequestModuleElement.properties.Add(WebRequestModuleElement.typeProp);
		}

		/// <summary>Gets or sets the URI prefix for the current Web request module.</summary>
		/// <returns>A string that contains a URI prefix.</returns>
		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x060019C0 RID: 6592 RVA: 0x000130A1 File Offset: 0x000112A1
		// (set) Token: 0x060019C1 RID: 6593 RVA: 0x000130B3 File Offset: 0x000112B3
		[ConfigurationProperty("prefix", Options = ConfigurationPropertyOptions.IsRequired | ConfigurationPropertyOptions.IsKey)]
		public string Prefix
		{
			get
			{
				return (string)base[WebRequestModuleElement.prefixProp];
			}
			set
			{
				base[WebRequestModuleElement.prefixProp] = value;
			}
		}

		/// <summary>Gets or sets a class that creates Web requests.</summary>
		/// <returns>A <see cref="T:System.Type" /> instance that identifies a Web request module.</returns>
		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x060019C2 RID: 6594 RVA: 0x000130C1 File Offset: 0x000112C1
		// (set) Token: 0x060019C3 RID: 6595 RVA: 0x000130D8 File Offset: 0x000112D8
		[global::System.ComponentModel.TypeConverter(typeof(global::System.ComponentModel.TypeConverter))]
		[ConfigurationProperty("type")]
		public Type Type
		{
			get
			{
				return Type.GetType((string)base[WebRequestModuleElement.typeProp]);
			}
			set
			{
				base[WebRequestModuleElement.typeProp] = value.FullName;
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x060019C4 RID: 6596 RVA: 0x000130EB File Offset: 0x000112EB
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return WebRequestModuleElement.properties;
			}
		}

		// Token: 0x0400101C RID: 4124
		private static ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

		// Token: 0x0400101D RID: 4125
		private static ConfigurationProperty prefixProp = new ConfigurationProperty("prefix", typeof(string), null, ConfigurationPropertyOptions.IsRequired | ConfigurationPropertyOptions.IsKey);

		// Token: 0x0400101E RID: 4126
		private static ConfigurationProperty typeProp = new ConfigurationProperty("type", typeof(string));
	}
}
