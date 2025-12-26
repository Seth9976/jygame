using System;

namespace JetBrains.Annotations
{
	// Token: 0x0200029B RID: 667
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
	public sealed class StringFormatMethodAttribute : Attribute
	{
		// Token: 0x060020B4 RID: 8372 RVA: 0x0000CF8F File Offset: 0x0000B18F
		public StringFormatMethodAttribute(string formatParameterName)
		{
			this.FormatParameterName = formatParameterName;
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x060020B5 RID: 8373 RVA: 0x0000CF9E File Offset: 0x0000B19E
		// (set) Token: 0x060020B6 RID: 8374 RVA: 0x0000CFA6 File Offset: 0x0000B1A6
		public string FormatParameterName { get; private set; }
	}
}
