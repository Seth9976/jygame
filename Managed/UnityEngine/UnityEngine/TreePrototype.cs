using System;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Simple class that contains a pointer to a tree prototype.</para>
	/// </summary>
	// Token: 0x020001A2 RID: 418
	[StructLayout(LayoutKind.Sequential)]
	public sealed class TreePrototype
	{
		/// <summary>
		///   <para>Retrieves the actual GameObect used by the tree.</para>
		/// </summary>
		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001807 RID: 6151 RVA: 0x00008920 File Offset: 0x00006B20
		// (set) Token: 0x06001808 RID: 6152 RVA: 0x00008928 File Offset: 0x00006B28
		public GameObject prefab
		{
			get
			{
				return this.m_Prefab;
			}
			set
			{
				this.m_Prefab = value;
			}
		}

		/// <summary>
		///   <para>Bend factor of the tree prototype.</para>
		/// </summary>
		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06001809 RID: 6153 RVA: 0x00008931 File Offset: 0x00006B31
		// (set) Token: 0x0600180A RID: 6154 RVA: 0x00008939 File Offset: 0x00006B39
		public float bendFactor
		{
			get
			{
				return this.m_BendFactor;
			}
			set
			{
				this.m_BendFactor = value;
			}
		}

		// Token: 0x04000505 RID: 1285
		internal GameObject m_Prefab;

		// Token: 0x04000506 RID: 1286
		internal float m_BendFactor;
	}
}
