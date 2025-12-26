using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>State of OffMeshLink.</para>
	/// </summary>
	// Token: 0x0200014A RID: 330
	public struct OffMeshLinkData
	{
		/// <summary>
		///   <para>Is link valid (Read Only).</para>
		/// </summary>
		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x060013EE RID: 5102 RVA: 0x00007C0D File Offset: 0x00005E0D
		public bool valid
		{
			get
			{
				return this.m_Valid != 0;
			}
		}

		/// <summary>
		///   <para>Is link active (Read Only).</para>
		/// </summary>
		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x060013EF RID: 5103 RVA: 0x00007C1B File Offset: 0x00005E1B
		public bool activated
		{
			get
			{
				return this.m_Activated != 0;
			}
		}

		/// <summary>
		///   <para>Link type specifier (Read Only).</para>
		/// </summary>
		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x060013F0 RID: 5104 RVA: 0x00007C29 File Offset: 0x00005E29
		public OffMeshLinkType linkType
		{
			get
			{
				return this.m_LinkType;
			}
		}

		/// <summary>
		///   <para>Link start world position (Read Only).</para>
		/// </summary>
		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x060013F1 RID: 5105 RVA: 0x00007C31 File Offset: 0x00005E31
		public Vector3 startPos
		{
			get
			{
				return this.m_StartPos;
			}
		}

		/// <summary>
		///   <para>Link end world position (Read Only).</para>
		/// </summary>
		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x060013F2 RID: 5106 RVA: 0x00007C39 File Offset: 0x00005E39
		public Vector3 endPos
		{
			get
			{
				return this.m_EndPos;
			}
		}

		/// <summary>
		///   <para>The OffMeshLink if the link type is a manually placed Offmeshlink (Read Only).</para>
		/// </summary>
		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x060013F3 RID: 5107 RVA: 0x00007C41 File Offset: 0x00005E41
		public OffMeshLink offMeshLink
		{
			get
			{
				return this.GetOffMeshLinkInternal(this.m_InstanceID);
			}
		}

		// Token: 0x060013F4 RID: 5108
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern OffMeshLink GetOffMeshLinkInternal(int instanceID);

		// Token: 0x0400038A RID: 906
		private int m_Valid;

		// Token: 0x0400038B RID: 907
		private int m_Activated;

		// Token: 0x0400038C RID: 908
		private int m_InstanceID;

		// Token: 0x0400038D RID: 909
		private OffMeshLinkType m_LinkType;

		// Token: 0x0400038E RID: 910
		private Vector3 m_StartPos;

		// Token: 0x0400038F RID: 911
		private Vector3 m_EndPos;
	}
}
