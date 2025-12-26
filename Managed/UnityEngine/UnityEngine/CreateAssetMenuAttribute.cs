using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Mark a ScriptableObject-derived type to be automatically listed in the Assets/Create submenu, so that instances of the type can be easily created and stored in the project as ".asset" files.</para>
	/// </summary>
	// Token: 0x0200024A RID: 586
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public sealed class CreateAssetMenuAttribute : Attribute
	{
		/// <summary>
		///   <para>The display name for this type shown in the Assets/Create menu.</para>
		/// </summary>
		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x0600206B RID: 8299 RVA: 0x0000CCB9 File Offset: 0x0000AEB9
		// (set) Token: 0x0600206C RID: 8300 RVA: 0x0000CCC1 File Offset: 0x0000AEC1
		public string menuName { get; set; }

		/// <summary>
		///   <para>The default file name used by newly created instances of this type.</para>
		/// </summary>
		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x0600206D RID: 8301 RVA: 0x0000CCCA File Offset: 0x0000AECA
		// (set) Token: 0x0600206E RID: 8302 RVA: 0x0000CCD2 File Offset: 0x0000AED2
		public string fileName { get; set; }

		/// <summary>
		///   <para>The position of the menu item within the Assets/Create menu.</para>
		/// </summary>
		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x0600206F RID: 8303 RVA: 0x0000CCDB File Offset: 0x0000AEDB
		// (set) Token: 0x06002070 RID: 8304 RVA: 0x0000CCE3 File Offset: 0x0000AEE3
		public int order { get; set; }
	}
}
