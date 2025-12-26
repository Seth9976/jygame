using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Provides information about the current and previous states of one sphere in a CullingGroup.</para>
	/// </summary>
	// Token: 0x0200004A RID: 74
	public struct CullingGroupEvent
	{
		/// <summary>
		///   <para>The index of the sphere that has changed.</para>
		/// </summary>
		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x00002B24 File Offset: 0x00000D24
		public int index
		{
			get
			{
				return this.m_Index;
			}
		}

		/// <summary>
		///   <para>Was the sphere considered visible by the most recent culling pass?</para>
		/// </summary>
		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x00002B2C File Offset: 0x00000D2C
		public bool isVisible
		{
			get
			{
				return (this.m_ThisState & 128) != 0;
			}
		}

		/// <summary>
		///   <para>Was the sphere visible before the most recent culling pass?</para>
		/// </summary>
		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x00002B40 File Offset: 0x00000D40
		public bool wasVisible
		{
			get
			{
				return (this.m_PrevState & 128) != 0;
			}
		}

		/// <summary>
		///   <para>Did this sphere change from being invisible to being visible in the most recent culling pass?</para>
		/// </summary>
		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x00002B54 File Offset: 0x00000D54
		public bool hasBecomeVisible
		{
			get
			{
				return this.isVisible && !this.wasVisible;
			}
		}

		/// <summary>
		///   <para>Did this sphere change from being visible to being invisible in the most recent culling pass?</para>
		/// </summary>
		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x00002B6D File Offset: 0x00000D6D
		public bool hasBecomeInvisible
		{
			get
			{
				return !this.isVisible && this.wasVisible;
			}
		}

		/// <summary>
		///   <para>The current distance band index of the sphere, after the most recent culling pass.</para>
		/// </summary>
		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x00002B83 File Offset: 0x00000D83
		public int currentDistance
		{
			get
			{
				return (int)(this.m_ThisState & 127);
			}
		}

		/// <summary>
		///   <para>The distance band index of the sphere before the most recent culling pass.</para>
		/// </summary>
		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x00002B8E File Offset: 0x00000D8E
		public int previousDistance
		{
			get
			{
				return (int)(this.m_PrevState & 127);
			}
		}

		// Token: 0x040000B5 RID: 181
		private const byte kIsVisibleMask = 128;

		// Token: 0x040000B6 RID: 182
		private const byte kDistanceMask = 127;

		// Token: 0x040000B7 RID: 183
		private int m_Index;

		// Token: 0x040000B8 RID: 184
		private byte m_PrevState;

		// Token: 0x040000B9 RID: 185
		private byte m_ThisState;
	}
}
