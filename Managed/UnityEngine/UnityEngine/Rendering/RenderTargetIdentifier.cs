using System;

namespace UnityEngine.Rendering
{
	/// <summary>
	///   <para>Identifies a RenderTexture for a Rendering.CommandBuffer.</para>
	/// </summary>
	// Token: 0x0200028F RID: 655
	public struct RenderTargetIdentifier
	{
		/// <summary>
		///   <para>Creates a render target identifier.</para>
		/// </summary>
		/// <param name="rt">RenderTexture object to use.</param>
		/// <param name="type">Built-in temporary render texture type.</param>
		/// <param name="name">Temporary render texture name.</param>
		/// <param name="nameID">Temporary render texture name (as integer, see Shader.PropertyToID).</param>
		// Token: 0x060020A5 RID: 8357 RVA: 0x0000CEEC File Offset: 0x0000B0EC
		public RenderTargetIdentifier(BuiltinRenderTextureType type)
		{
			this.m_Type = type;
			this.m_NameID = -1;
			this.m_InstanceID = 0;
		}

		/// <summary>
		///   <para>Creates a render target identifier.</para>
		/// </summary>
		/// <param name="rt">RenderTexture object to use.</param>
		/// <param name="type">Built-in temporary render texture type.</param>
		/// <param name="name">Temporary render texture name.</param>
		/// <param name="nameID">Temporary render texture name (as integer, see Shader.PropertyToID).</param>
		// Token: 0x060020A6 RID: 8358 RVA: 0x0000CF03 File Offset: 0x0000B103
		public RenderTargetIdentifier(string name)
		{
			this.m_Type = BuiltinRenderTextureType.None;
			this.m_NameID = Shader.PropertyToID(name);
			this.m_InstanceID = 0;
		}

		/// <summary>
		///   <para>Creates a render target identifier.</para>
		/// </summary>
		/// <param name="rt">RenderTexture object to use.</param>
		/// <param name="type">Built-in temporary render texture type.</param>
		/// <param name="name">Temporary render texture name.</param>
		/// <param name="nameID">Temporary render texture name (as integer, see Shader.PropertyToID).</param>
		// Token: 0x060020A7 RID: 8359 RVA: 0x0000CF1F File Offset: 0x0000B11F
		public RenderTargetIdentifier(int nameID)
		{
			this.m_Type = BuiltinRenderTextureType.None;
			this.m_NameID = nameID;
			this.m_InstanceID = 0;
		}

		/// <summary>
		///   <para>Creates a render target identifier.</para>
		/// </summary>
		/// <param name="rt">RenderTexture object to use.</param>
		/// <param name="type">Built-in temporary render texture type.</param>
		/// <param name="name">Temporary render texture name.</param>
		/// <param name="nameID">Temporary render texture name (as integer, see Shader.PropertyToID).</param>
		// Token: 0x060020A8 RID: 8360 RVA: 0x0000CF36 File Offset: 0x0000B136
		public RenderTargetIdentifier(RenderTexture rt)
		{
			this.m_Type = BuiltinRenderTextureType.None;
			this.m_NameID = -1;
			this.m_InstanceID = ((!rt) ? 0 : rt.GetInstanceID());
		}

		// Token: 0x060020A9 RID: 8361 RVA: 0x0000CF63 File Offset: 0x0000B163
		public static implicit operator RenderTargetIdentifier(BuiltinRenderTextureType type)
		{
			return new RenderTargetIdentifier(type);
		}

		// Token: 0x060020AA RID: 8362 RVA: 0x0000CF6B File Offset: 0x0000B16B
		public static implicit operator RenderTargetIdentifier(string name)
		{
			return new RenderTargetIdentifier(name);
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x0000CF73 File Offset: 0x0000B173
		public static implicit operator RenderTargetIdentifier(int nameID)
		{
			return new RenderTargetIdentifier(nameID);
		}

		// Token: 0x060020AC RID: 8364 RVA: 0x0000CF7B File Offset: 0x0000B17B
		public static implicit operator RenderTargetIdentifier(RenderTexture rt)
		{
			return new RenderTargetIdentifier(rt);
		}

		// Token: 0x04000A60 RID: 2656
		private BuiltinRenderTextureType m_Type;

		// Token: 0x04000A61 RID: 2657
		private int m_NameID;

		// Token: 0x04000A62 RID: 2658
		private int m_InstanceID;
	}
}
