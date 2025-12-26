using System;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>A Splat prototype is just a texture that is used by the TerrainData.</para>
	/// </summary>
	// Token: 0x020001A5 RID: 421
	[StructLayout(LayoutKind.Sequential)]
	public sealed class SplatPrototype
	{
		/// <summary>
		///   <para>Texture of the splat applied to the Terrain.</para>
		/// </summary>
		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06001825 RID: 6181 RVA: 0x00008A20 File Offset: 0x00006C20
		// (set) Token: 0x06001826 RID: 6182 RVA: 0x00008A28 File Offset: 0x00006C28
		public Texture2D texture
		{
			get
			{
				return this.m_Texture;
			}
			set
			{
				this.m_Texture = value;
			}
		}

		/// <summary>
		///   <para>Normal map of the splat applied to the Terrain.</para>
		/// </summary>
		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06001827 RID: 6183 RVA: 0x00008A31 File Offset: 0x00006C31
		// (set) Token: 0x06001828 RID: 6184 RVA: 0x00008A39 File Offset: 0x00006C39
		public Texture2D normalMap
		{
			get
			{
				return this.m_NormalMap;
			}
			set
			{
				this.m_NormalMap = value;
			}
		}

		/// <summary>
		///   <para>Size of the tile used in the texture of the SplatPrototype.</para>
		/// </summary>
		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001829 RID: 6185 RVA: 0x00008A42 File Offset: 0x00006C42
		// (set) Token: 0x0600182A RID: 6186 RVA: 0x00008A4A File Offset: 0x00006C4A
		public Vector2 tileSize
		{
			get
			{
				return this.m_TileSize;
			}
			set
			{
				this.m_TileSize = value;
			}
		}

		/// <summary>
		///   <para>Offset of the tile texture of the SplatPrototype.</para>
		/// </summary>
		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x0600182B RID: 6187 RVA: 0x00008A53 File Offset: 0x00006C53
		// (set) Token: 0x0600182C RID: 6188 RVA: 0x00008A5B File Offset: 0x00006C5B
		public Vector2 tileOffset
		{
			get
			{
				return this.m_TileOffset;
			}
			set
			{
				this.m_TileOffset = value;
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x0600182D RID: 6189 RVA: 0x00008A64 File Offset: 0x00006C64
		// (set) Token: 0x0600182E RID: 6190 RVA: 0x00008A8C File Offset: 0x00006C8C
		public Color specular
		{
			get
			{
				return new Color(this.m_SpecularMetallic.x, this.m_SpecularMetallic.y, this.m_SpecularMetallic.z);
			}
			set
			{
				this.m_SpecularMetallic.x = value.r;
				this.m_SpecularMetallic.y = value.g;
				this.m_SpecularMetallic.z = value.b;
			}
		}

		/// <summary>
		///   <para>The metallic value of the splat layer.</para>
		/// </summary>
		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x0600182F RID: 6191 RVA: 0x00008AC4 File Offset: 0x00006CC4
		// (set) Token: 0x06001830 RID: 6192 RVA: 0x00008AD1 File Offset: 0x00006CD1
		public float metallic
		{
			get
			{
				return this.m_SpecularMetallic.w;
			}
			set
			{
				this.m_SpecularMetallic.w = value;
			}
		}

		/// <summary>
		///   <para>The smoothness value of the splat layer when the main texture has no alpha channel.</para>
		/// </summary>
		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06001831 RID: 6193 RVA: 0x00008ADF File Offset: 0x00006CDF
		// (set) Token: 0x06001832 RID: 6194 RVA: 0x00008AE7 File Offset: 0x00006CE7
		public float smoothness
		{
			get
			{
				return this.m_Smoothness;
			}
			set
			{
				this.m_Smoothness = value;
			}
		}

		// Token: 0x04000517 RID: 1303
		private Texture2D m_Texture;

		// Token: 0x04000518 RID: 1304
		private Texture2D m_NormalMap;

		// Token: 0x04000519 RID: 1305
		private Vector2 m_TileSize = new Vector2(15f, 15f);

		// Token: 0x0400051A RID: 1306
		private Vector2 m_TileOffset = new Vector2(0f, 0f);

		// Token: 0x0400051B RID: 1307
		private Vector4 m_SpecularMetallic = new Vector4(0f, 0f, 0f, 0f);

		// Token: 0x0400051C RID: 1308
		private float m_Smoothness;
	}
}
