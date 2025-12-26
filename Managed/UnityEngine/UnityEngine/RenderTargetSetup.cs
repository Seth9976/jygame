using System;
using UnityEngine.Rendering;

namespace UnityEngine
{
	/// <summary>
	///   <para>Fully describes setup of RenderTarget.</para>
	/// </summary>
	// Token: 0x02000260 RID: 608
	public struct RenderTargetSetup
	{
		// Token: 0x0600209B RID: 8347 RVA: 0x0000CE30 File Offset: 0x0000B030
		internal RenderTargetSetup(RenderBuffer[] color, RenderBuffer depth, int mip, int face, RenderBufferLoadAction[] colorLoad, RenderBufferStoreAction[] colorStore, RenderBufferLoadAction depthLoad, RenderBufferStoreAction depthStore)
		{
			this.color = color;
			this.depth = depth;
			this.mipLevel = mip;
			this.cubemapFace = face;
			this.colorLoad = colorLoad;
			this.colorStore = colorStore;
			this.depthLoad = depthLoad;
			this.depthStore = depthStore;
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x000284FC File Offset: 0x000266FC
		internal RenderTargetSetup(RenderBuffer[] color, RenderBuffer depth, int mip, int face)
		{
			this = new RenderTargetSetup(color, depth, mip, face, RenderTargetSetup.LoadActions(color), RenderTargetSetup.StoreActions(color), depth.loadAction, depth.storeAction);
		}

		/// <summary>
		///   <para>Constructs RenderTargetSetup.</para>
		/// </summary>
		/// <param name="color">Color Buffer(s) to set.</param>
		/// <param name="depth">Depth Buffer to set.</param>
		/// <param name="mipLevel">Mip Level to render to.</param>
		/// <param name="face">Cubemap face to render to.</param>
		// Token: 0x0600209D RID: 8349 RVA: 0x0000CE6F File Offset: 0x0000B06F
		public RenderTargetSetup(RenderBuffer color, RenderBuffer depth)
		{
			this = new RenderTargetSetup(new RenderBuffer[] { color }, depth);
		}

		/// <summary>
		///   <para>Constructs RenderTargetSetup.</para>
		/// </summary>
		/// <param name="color">Color Buffer(s) to set.</param>
		/// <param name="depth">Depth Buffer to set.</param>
		/// <param name="mipLevel">Mip Level to render to.</param>
		/// <param name="face">Cubemap face to render to.</param>
		// Token: 0x0600209E RID: 8350 RVA: 0x0000CE8B File Offset: 0x0000B08B
		public RenderTargetSetup(RenderBuffer color, RenderBuffer depth, int mipLevel)
		{
			this = new RenderTargetSetup(new RenderBuffer[] { color }, depth, mipLevel);
		}

		/// <summary>
		///   <para>Constructs RenderTargetSetup.</para>
		/// </summary>
		/// <param name="color">Color Buffer(s) to set.</param>
		/// <param name="depth">Depth Buffer to set.</param>
		/// <param name="mipLevel">Mip Level to render to.</param>
		/// <param name="face">Cubemap face to render to.</param>
		// Token: 0x0600209F RID: 8351 RVA: 0x0000CEA8 File Offset: 0x0000B0A8
		public RenderTargetSetup(RenderBuffer color, RenderBuffer depth, int mipLevel, CubemapFace face)
		{
			this = new RenderTargetSetup(new RenderBuffer[] { color }, depth, mipLevel, face);
		}

		/// <summary>
		///   <para>Constructs RenderTargetSetup.</para>
		/// </summary>
		/// <param name="color">Color Buffer(s) to set.</param>
		/// <param name="depth">Depth Buffer to set.</param>
		/// <param name="mipLevel">Mip Level to render to.</param>
		/// <param name="face">Cubemap face to render to.</param>
		// Token: 0x060020A0 RID: 8352 RVA: 0x0000CEC7 File Offset: 0x0000B0C7
		public RenderTargetSetup(RenderBuffer[] color, RenderBuffer depth)
		{
			this = new RenderTargetSetup(color, depth, 0, -1);
		}

		/// <summary>
		///   <para>Constructs RenderTargetSetup.</para>
		/// </summary>
		/// <param name="color">Color Buffer(s) to set.</param>
		/// <param name="depth">Depth Buffer to set.</param>
		/// <param name="mipLevel">Mip Level to render to.</param>
		/// <param name="face">Cubemap face to render to.</param>
		// Token: 0x060020A1 RID: 8353 RVA: 0x0000CED3 File Offset: 0x0000B0D3
		public RenderTargetSetup(RenderBuffer[] color, RenderBuffer depth, int mipLevel)
		{
			this = new RenderTargetSetup(color, depth, mipLevel, -1);
		}

		/// <summary>
		///   <para>Constructs RenderTargetSetup.</para>
		/// </summary>
		/// <param name="color">Color Buffer(s) to set.</param>
		/// <param name="depth">Depth Buffer to set.</param>
		/// <param name="mipLevel">Mip Level to render to.</param>
		/// <param name="face">Cubemap face to render to.</param>
		// Token: 0x060020A2 RID: 8354 RVA: 0x0000CEDF File Offset: 0x0000B0DF
		public RenderTargetSetup(RenderBuffer[] color, RenderBuffer depth, int mipLevel, CubemapFace face)
		{
			this = new RenderTargetSetup(color, depth, mipLevel, (int)face);
		}

		// Token: 0x060020A3 RID: 8355 RVA: 0x00028530 File Offset: 0x00026730
		internal static RenderBufferLoadAction[] LoadActions(RenderBuffer[] buf)
		{
			RenderBufferLoadAction[] array = new RenderBufferLoadAction[buf.Length];
			for (int i = 0; i < buf.Length; i++)
			{
				array[i] = buf[i].loadAction;
				buf[i].loadAction = RenderBufferLoadAction.Load;
			}
			return array;
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x00028578 File Offset: 0x00026778
		internal static RenderBufferStoreAction[] StoreActions(RenderBuffer[] buf)
		{
			RenderBufferStoreAction[] array = new RenderBufferStoreAction[buf.Length];
			for (int i = 0; i < buf.Length; i++)
			{
				array[i] = buf[i].storeAction;
				buf[i].storeAction = RenderBufferStoreAction.Store;
			}
			return array;
		}

		/// <summary>
		///   <para>Color Buffers to set.</para>
		/// </summary>
		// Token: 0x040008E3 RID: 2275
		public RenderBuffer[] color;

		/// <summary>
		///   <para>Depth Buffer to set.</para>
		/// </summary>
		// Token: 0x040008E4 RID: 2276
		public RenderBuffer depth;

		/// <summary>
		///   <para>Mip Level to render to.</para>
		/// </summary>
		// Token: 0x040008E5 RID: 2277
		public int mipLevel;

		/// <summary>
		///   <para>Cubemap face to render to.</para>
		/// </summary>
		// Token: 0x040008E6 RID: 2278
		public int cubemapFace;

		/// <summary>
		///   <para>Load Actions for Color Buffers. It will override any actions set on RenderBuffers themselves.</para>
		/// </summary>
		// Token: 0x040008E7 RID: 2279
		public RenderBufferLoadAction[] colorLoad;

		/// <summary>
		///   <para>Store Actions for Color Buffers. It will override any actions set on RenderBuffers themselves.</para>
		/// </summary>
		// Token: 0x040008E8 RID: 2280
		public RenderBufferStoreAction[] colorStore;

		/// <summary>
		///   <para>Load Action for Depth Buffer. It will override any actions set on RenderBuffer itself.</para>
		/// </summary>
		// Token: 0x040008E9 RID: 2281
		public RenderBufferLoadAction depthLoad;

		/// <summary>
		///   <para>Store Actions for Depth Buffer. It will override any actions set on RenderBuffer itself.</para>
		/// </summary>
		// Token: 0x040008EA RID: 2282
		public RenderBufferStoreAction depthStore;
	}
}
