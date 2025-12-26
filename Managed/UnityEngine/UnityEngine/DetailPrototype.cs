using System;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Detail prototype used by the Terrain GameObject.</para>
	/// </summary>
	// Token: 0x020001A4 RID: 420
	[StructLayout(LayoutKind.Sequential)]
	public sealed class DetailPrototype
	{
		/// <summary>
		///   <para>GameObject used by the DetailPrototype.</para>
		/// </summary>
		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x0600180C RID: 6156 RVA: 0x00008942 File Offset: 0x00006B42
		// (set) Token: 0x0600180D RID: 6157 RVA: 0x0000894A File Offset: 0x00006B4A
		public GameObject prototype
		{
			get
			{
				return this.m_Prototype;
			}
			set
			{
				this.m_Prototype = value;
			}
		}

		/// <summary>
		///   <para>Texture used by the DetailPrototype.</para>
		/// </summary>
		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x0600180E RID: 6158 RVA: 0x00008953 File Offset: 0x00006B53
		// (set) Token: 0x0600180F RID: 6159 RVA: 0x0000895B File Offset: 0x00006B5B
		public Texture2D prototypeTexture
		{
			get
			{
				return this.m_PrototypeTexture;
			}
			set
			{
				this.m_PrototypeTexture = value;
			}
		}

		/// <summary>
		///   <para>Minimum width of the grass billboards (if render mode is GrassBillboard).</para>
		/// </summary>
		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001810 RID: 6160 RVA: 0x00008964 File Offset: 0x00006B64
		// (set) Token: 0x06001811 RID: 6161 RVA: 0x0000896C File Offset: 0x00006B6C
		public float minWidth
		{
			get
			{
				return this.m_MinWidth;
			}
			set
			{
				this.m_MinWidth = value;
			}
		}

		/// <summary>
		///   <para>Maximum width of the grass billboards (if render mode is GrassBillboard).</para>
		/// </summary>
		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001812 RID: 6162 RVA: 0x00008975 File Offset: 0x00006B75
		// (set) Token: 0x06001813 RID: 6163 RVA: 0x0000897D File Offset: 0x00006B7D
		public float maxWidth
		{
			get
			{
				return this.m_MaxWidth;
			}
			set
			{
				this.m_MaxWidth = value;
			}
		}

		/// <summary>
		///   <para>Minimum height of the grass billboards (if render mode is GrassBillboard).</para>
		/// </summary>
		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001814 RID: 6164 RVA: 0x00008986 File Offset: 0x00006B86
		// (set) Token: 0x06001815 RID: 6165 RVA: 0x0000898E File Offset: 0x00006B8E
		public float minHeight
		{
			get
			{
				return this.m_MinHeight;
			}
			set
			{
				this.m_MinHeight = value;
			}
		}

		/// <summary>
		///   <para>Maximum height of the grass billboards (if render mode is GrassBillboard).</para>
		/// </summary>
		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001816 RID: 6166 RVA: 0x00008997 File Offset: 0x00006B97
		// (set) Token: 0x06001817 RID: 6167 RVA: 0x0000899F File Offset: 0x00006B9F
		public float maxHeight
		{
			get
			{
				return this.m_MaxHeight;
			}
			set
			{
				this.m_MaxHeight = value;
			}
		}

		/// <summary>
		///   <para>How spread out is the noise for the DetailPrototype.</para>
		/// </summary>
		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001818 RID: 6168 RVA: 0x000089A8 File Offset: 0x00006BA8
		// (set) Token: 0x06001819 RID: 6169 RVA: 0x000089B0 File Offset: 0x00006BB0
		public float noiseSpread
		{
			get
			{
				return this.m_NoiseSpread;
			}
			set
			{
				this.m_NoiseSpread = value;
			}
		}

		/// <summary>
		///   <para>Bend factor of the detailPrototype.</para>
		/// </summary>
		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x0600181A RID: 6170 RVA: 0x000089B9 File Offset: 0x00006BB9
		// (set) Token: 0x0600181B RID: 6171 RVA: 0x000089C1 File Offset: 0x00006BC1
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

		/// <summary>
		///   <para>Color when the DetailPrototypes are "healthy".</para>
		/// </summary>
		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x0600181C RID: 6172 RVA: 0x000089CA File Offset: 0x00006BCA
		// (set) Token: 0x0600181D RID: 6173 RVA: 0x000089D2 File Offset: 0x00006BD2
		public Color healthyColor
		{
			get
			{
				return this.m_HealthyColor;
			}
			set
			{
				this.m_HealthyColor = value;
			}
		}

		/// <summary>
		///   <para>Color when the DetailPrototypes are "dry".</para>
		/// </summary>
		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x0600181E RID: 6174 RVA: 0x000089DB File Offset: 0x00006BDB
		// (set) Token: 0x0600181F RID: 6175 RVA: 0x000089E3 File Offset: 0x00006BE3
		public Color dryColor
		{
			get
			{
				return this.m_DryColor;
			}
			set
			{
				this.m_DryColor = value;
			}
		}

		/// <summary>
		///   <para>Render mode for the DetailPrototype.</para>
		/// </summary>
		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001820 RID: 6176 RVA: 0x000089EC File Offset: 0x00006BEC
		// (set) Token: 0x06001821 RID: 6177 RVA: 0x000089F4 File Offset: 0x00006BF4
		public DetailRenderMode renderMode
		{
			get
			{
				return (DetailRenderMode)this.m_RenderMode;
			}
			set
			{
				this.m_RenderMode = (int)value;
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001822 RID: 6178 RVA: 0x000089FD File Offset: 0x00006BFD
		// (set) Token: 0x06001823 RID: 6179 RVA: 0x00008A0B File Offset: 0x00006C0B
		public bool usePrototypeMesh
		{
			get
			{
				return this.m_UsePrototypeMesh != 0;
			}
			set
			{
				this.m_UsePrototypeMesh = ((!value) ? 0 : 1);
			}
		}

		// Token: 0x0400050B RID: 1291
		private GameObject m_Prototype;

		// Token: 0x0400050C RID: 1292
		private Texture2D m_PrototypeTexture;

		// Token: 0x0400050D RID: 1293
		private Color m_HealthyColor = new Color(0.2627451f, 0.9764706f, 0.16470589f, 1f);

		// Token: 0x0400050E RID: 1294
		private Color m_DryColor = new Color(0.8039216f, 0.7372549f, 0.101960786f, 1f);

		// Token: 0x0400050F RID: 1295
		private float m_MinWidth = 1f;

		// Token: 0x04000510 RID: 1296
		private float m_MaxWidth = 2f;

		// Token: 0x04000511 RID: 1297
		private float m_MinHeight = 1f;

		// Token: 0x04000512 RID: 1298
		private float m_MaxHeight = 2f;

		// Token: 0x04000513 RID: 1299
		private float m_NoiseSpread = 0.1f;

		// Token: 0x04000514 RID: 1300
		private float m_BendFactor = 0.1f;

		// Token: 0x04000515 RID: 1301
		private int m_RenderMode = 2;

		// Token: 0x04000516 RID: 1302
		private int m_UsePrototypeMesh;
	}
}
