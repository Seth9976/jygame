using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Provide a custom documentation URL for a class.</para>
	/// </summary>
	// Token: 0x0200024E RID: 590
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public sealed class HelpURLAttribute : Attribute
	{
		/// <summary>
		///   <para>Initialize the HelpURL attribute with a documentation url.</para>
		/// </summary>
		/// <param name="url">The custom documentation URL for this class.</param>
		// Token: 0x06002075 RID: 8309 RVA: 0x0000CD03 File Offset: 0x0000AF03
		public HelpURLAttribute(string url)
		{
			this.URL = url;
		}

		/// <summary>
		///   <para>The documentation URL specified for this class.</para>
		/// </summary>
		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06002076 RID: 8310 RVA: 0x0000CD12 File Offset: 0x0000AF12
		// (set) Token: 0x06002077 RID: 8311 RVA: 0x0000CD1A File Offset: 0x0000AF1A
		public string URL { get; private set; }
	}
}
