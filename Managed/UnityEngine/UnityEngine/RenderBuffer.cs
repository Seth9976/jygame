using System;
using UnityEngine.Rendering;

namespace UnityEngine
{
	/// <summary>
	///   <para>Color or depth buffer part of a RenderTexture.</para>
	/// </summary>
	// Token: 0x0200025F RID: 607
	public struct RenderBuffer
	{
		// Token: 0x06002094 RID: 8340 RVA: 0x0000CDF4 File Offset: 0x0000AFF4
		internal void SetLoadAction(RenderBufferLoadAction action)
		{
			RenderBufferHelper.SetLoadAction(out this, (int)action);
		}

		// Token: 0x06002095 RID: 8341 RVA: 0x0000CDFD File Offset: 0x0000AFFD
		internal void SetStoreAction(RenderBufferStoreAction action)
		{
			RenderBufferHelper.SetStoreAction(out this, (int)action);
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06002096 RID: 8342 RVA: 0x0000CE06 File Offset: 0x0000B006
		// (set) Token: 0x06002097 RID: 8343 RVA: 0x0000CE0E File Offset: 0x0000B00E
		internal RenderBufferLoadAction loadAction
		{
			get
			{
				return (RenderBufferLoadAction)RenderBufferHelper.GetLoadAction(out this);
			}
			set
			{
				this.SetLoadAction(value);
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06002098 RID: 8344 RVA: 0x0000CE17 File Offset: 0x0000B017
		// (set) Token: 0x06002099 RID: 8345 RVA: 0x0000CE1F File Offset: 0x0000B01F
		internal RenderBufferStoreAction storeAction
		{
			get
			{
				return (RenderBufferStoreAction)RenderBufferHelper.GetStoreAction(out this);
			}
			set
			{
				this.SetStoreAction(value);
			}
		}

		/// <summary>
		///   <para>Returns native RenderBuffer. Be warned this is not native Texture, but rather pointer to unity struct that can be used with native unity API. Currently such API exists only on iOS.</para>
		/// </summary>
		// Token: 0x0600209A RID: 8346 RVA: 0x0000CE28 File Offset: 0x0000B028
		public IntPtr GetNativeRenderBufferPtr()
		{
			return this.m_BufferPtr;
		}

		// Token: 0x040008E1 RID: 2273
		internal int m_RenderTextureInstanceID;

		// Token: 0x040008E2 RID: 2274
		internal IntPtr m_BufferPtr;
	}
}
