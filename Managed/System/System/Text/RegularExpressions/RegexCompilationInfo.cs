using System;

namespace System.Text.RegularExpressions
{
	/// <summary>Provides information about a regular expression that is used to compile a regular expression to a stand-alone assembly. </summary>
	// Token: 0x020004A7 RID: 1191
	[Serializable]
	public class RegexCompilationInfo
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Text.RegularExpressions.RegexCompilationInfo" /> class that contains information about a regular expression to be included in an assembly. </summary>
		/// <param name="pattern">The regular expression to compile. </param>
		/// <param name="options">The regular expression options to use when compiling the regular expression. </param>
		/// <param name="name">The name of the type that represents the compiled regular expression. </param>
		/// <param name="fullnamespace">The namespace to which the new type belongs. </param>
		/// <param name="ispublic">true to make the compiled regular expression publicly visible; otherwise, false. </param>
		// Token: 0x06002A13 RID: 10771 RVA: 0x0001D474 File Offset: 0x0001B674
		public RegexCompilationInfo(string pattern, RegexOptions options, string name, string fullnamespace, bool ispublic)
		{
			this.Pattern = pattern;
			this.Options = options;
			this.Name = name;
			this.Namespace = fullnamespace;
			this.IsPublic = ispublic;
		}

		/// <summary>Gets or sets a value that indicates whether the compiled regular expression has public visibility.</summary>
		/// <returns>true if the regular expression has public visibility; otherwise, false.</returns>
		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x06002A14 RID: 10772 RVA: 0x0001D4A1 File Offset: 0x0001B6A1
		// (set) Token: 0x06002A15 RID: 10773 RVA: 0x0001D4A9 File Offset: 0x0001B6A9
		public bool IsPublic
		{
			get
			{
				return this.isPublic;
			}
			set
			{
				this.isPublic = value;
			}
		}

		/// <summary>Gets or sets the name of the type that represents the compiled regular expression.</summary>
		/// <returns>The name of the new type.</returns>
		/// <exception cref="T:System.ArgumentNullException">The value for this property is null.</exception>
		/// <exception cref="T:System.ArgumentException">The value for this property is an empty string.</exception>
		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x06002A16 RID: 10774 RVA: 0x0001D4B2 File Offset: 0x0001B6B2
		// (set) Token: 0x06002A17 RID: 10775 RVA: 0x0001D4BA File Offset: 0x0001B6BA
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("Name");
				}
				if (value.Length == 0)
				{
					throw new ArgumentException("Name");
				}
				this.name = value;
			}
		}

		/// <summary>Gets or sets the namespace to which the new type belongs.</summary>
		/// <returns>The namespace of the new type.</returns>
		/// <exception cref="T:System.ArgumentNullException">The value for this property is null.</exception>
		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x06002A18 RID: 10776 RVA: 0x0001D4EA File Offset: 0x0001B6EA
		// (set) Token: 0x06002A19 RID: 10777 RVA: 0x0001D4F2 File Offset: 0x0001B6F2
		public string Namespace
		{
			get
			{
				return this.nspace;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("Namespace");
				}
				this.nspace = value;
			}
		}

		/// <summary>Gets or sets the options to use when compiling the regular expression.</summary>
		/// <returns>A bitwise combination of the enumeration values.</returns>
		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x06002A1A RID: 10778 RVA: 0x0001D50C File Offset: 0x0001B70C
		// (set) Token: 0x06002A1B RID: 10779 RVA: 0x0001D514 File Offset: 0x0001B714
		public RegexOptions Options
		{
			get
			{
				return this.options;
			}
			set
			{
				this.options = value;
			}
		}

		/// <summary>Gets or sets the regular expression to compile.</summary>
		/// <returns>The regular expression to compile.</returns>
		/// <exception cref="T:System.ArgumentNullException">The value for this property is null.</exception>
		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x06002A1C RID: 10780 RVA: 0x0001D51D File Offset: 0x0001B71D
		// (set) Token: 0x06002A1D RID: 10781 RVA: 0x0001D525 File Offset: 0x0001B725
		public string Pattern
		{
			get
			{
				return this.pattern;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("pattern");
				}
				this.pattern = value;
			}
		}

		// Token: 0x04001A2C RID: 6700
		private string pattern;

		// Token: 0x04001A2D RID: 6701
		private string name;

		// Token: 0x04001A2E RID: 6702
		private string nspace;

		// Token: 0x04001A2F RID: 6703
		private RegexOptions options;

		// Token: 0x04001A30 RID: 6704
		private bool isPublic;
	}
}
