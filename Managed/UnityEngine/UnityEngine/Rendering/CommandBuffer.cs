using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine.Rendering
{
	/// <summary>
	///   <para>List of graphics commands to execute.</para>
	/// </summary>
	// Token: 0x0200007C RID: 124
	public sealed class CommandBuffer : IDisposable
	{
		/// <summary>
		///   <para>Create a new empty command buffer.</para>
		/// </summary>
		// Token: 0x06000761 RID: 1889 RVA: 0x00004F04 File Offset: 0x00003104
		public CommandBuffer()
		{
			this.m_Ptr = IntPtr.Zero;
			CommandBuffer.InitBuffer(this);
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x000143B0 File Offset: 0x000125B0
		~CommandBuffer()
		{
			this.Dispose(false);
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00004F1D File Offset: 0x0000311D
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00004F2C File Offset: 0x0000312C
		private void Dispose(bool disposing)
		{
			this.ReleaseBuffer();
			this.m_Ptr = IntPtr.Zero;
		}

		// Token: 0x06000765 RID: 1893
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void InitBuffer(CommandBuffer buf);

		// Token: 0x06000766 RID: 1894
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void ReleaseBuffer();

		// Token: 0x06000767 RID: 1895 RVA: 0x00004F3F File Offset: 0x0000313F
		public void Release()
		{
			this.Dispose();
		}

		/// <summary>
		///   <para>Name of this command buffer.</para>
		/// </summary>
		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000768 RID: 1896
		// (set) Token: 0x06000769 RID: 1897
		public extern string name
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Size of this command buffer in bytes (Read Only).</para>
		/// </summary>
		// Token: 0x170001CA RID: 458
		// (get) Token: 0x0600076A RID: 1898
		public extern int sizeInBytes
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Clear all commands in the buffer.</para>
		/// </summary>
		// Token: 0x0600076B RID: 1899
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Clear();

		/// <summary>
		///   <para>Add a "draw mesh" command.</para>
		/// </summary>
		/// <param name="mesh">Mesh to draw.</param>
		/// <param name="matrix">Transformation matrix to use.</param>
		/// <param name="material">Material to use.</param>
		/// <param name="submeshIndex">Which subset of the mesh to render.</param>
		/// <param name="shaderPass">Which pass of the shader to use (default is -1, which renders all passes).</param>
		/// <param name="properties">Additional material properties to apply onto material just before this mesh will be drawn. See MaterialPropertyBlock.</param>
		// Token: 0x0600076C RID: 1900 RVA: 0x00004F47 File Offset: 0x00003147
		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, [DefaultValue("0")] int submeshIndex, [DefaultValue("-1")] int shaderPass, [DefaultValue("null")] MaterialPropertyBlock properties)
		{
			CommandBuffer.INTERNAL_CALL_DrawMesh(this, mesh, ref matrix, material, submeshIndex, shaderPass, properties);
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x000143E0 File Offset: 0x000125E0
		[ExcludeFromDocs]
		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass)
		{
			MaterialPropertyBlock materialPropertyBlock = null;
			CommandBuffer.INTERNAL_CALL_DrawMesh(this, mesh, ref matrix, material, submeshIndex, shaderPass, materialPropertyBlock);
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00014400 File Offset: 0x00012600
		[ExcludeFromDocs]
		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex)
		{
			MaterialPropertyBlock materialPropertyBlock = null;
			int num = -1;
			CommandBuffer.INTERNAL_CALL_DrawMesh(this, mesh, ref matrix, material, submeshIndex, num, materialPropertyBlock);
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00014420 File Offset: 0x00012620
		[ExcludeFromDocs]
		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material)
		{
			MaterialPropertyBlock materialPropertyBlock = null;
			int num = -1;
			int num2 = 0;
			CommandBuffer.INTERNAL_CALL_DrawMesh(this, mesh, ref matrix, material, num2, num, materialPropertyBlock);
		}

		// Token: 0x06000770 RID: 1904
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DrawMesh(CommandBuffer self, Mesh mesh, ref Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties);

		/// <summary>
		///   <para>Add a "draw renderer" command.</para>
		/// </summary>
		/// <param name="renderer">Renderer to draw.</param>
		/// <param name="material">Material to use.</param>
		/// <param name="submeshIndex">Which subset of the mesh to render.</param>
		/// <param name="shaderPass">Which pass of the shader to use (default is -1, which renders all passes).</param>
		// Token: 0x06000771 RID: 1905
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void DrawRenderer(Renderer renderer, Material material, [DefaultValue("0")] int submeshIndex, [DefaultValue("-1")] int shaderPass);

		// Token: 0x06000772 RID: 1906 RVA: 0x00014440 File Offset: 0x00012640
		[ExcludeFromDocs]
		public void DrawRenderer(Renderer renderer, Material material, int submeshIndex)
		{
			int num = -1;
			this.DrawRenderer(renderer, material, submeshIndex, num);
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x0001445C File Offset: 0x0001265C
		[ExcludeFromDocs]
		public void DrawRenderer(Renderer renderer, Material material)
		{
			int num = -1;
			int num2 = 0;
			this.DrawRenderer(renderer, material, num2, num);
		}

		/// <summary>
		///   <para>Add a "draw procedural geometry" command.</para>
		/// </summary>
		/// <param name="matrix">Transformation matrix to use.</param>
		/// <param name="material">Material to use.</param>
		/// <param name="shaderPass">Which pass of the shader to use (or -1 for all passes).</param>
		/// <param name="topology">Topology of the procedural geometry.</param>
		/// <param name="vertexCount">Vertex count to render.</param>
		/// <param name="instanceCount">Instance count to render.</param>
		/// <param name="properties">Additional material properties to apply just before rendering. See MaterialPropertyBlock.</param>
		// Token: 0x06000774 RID: 1908 RVA: 0x00004F59 File Offset: 0x00003159
		public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, [DefaultValue("1")] int instanceCount, [DefaultValue("null")] MaterialPropertyBlock properties)
		{
			CommandBuffer.INTERNAL_CALL_DrawProcedural(this, ref matrix, material, shaderPass, topology, vertexCount, instanceCount, properties);
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00014478 File Offset: 0x00012678
		[ExcludeFromDocs]
		public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount)
		{
			MaterialPropertyBlock materialPropertyBlock = null;
			CommandBuffer.INTERNAL_CALL_DrawProcedural(this, ref matrix, material, shaderPass, topology, vertexCount, instanceCount, materialPropertyBlock);
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00014498 File Offset: 0x00012698
		[ExcludeFromDocs]
		public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount)
		{
			MaterialPropertyBlock materialPropertyBlock = null;
			int num = 1;
			CommandBuffer.INTERNAL_CALL_DrawProcedural(this, ref matrix, material, shaderPass, topology, vertexCount, num, materialPropertyBlock);
		}

		// Token: 0x06000777 RID: 1911
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DrawProcedural(CommandBuffer self, ref Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties);

		/// <summary>
		///   <para>Add a "draw procedural geometry" command.</para>
		/// </summary>
		/// <param name="matrix">Transformation matrix to use.</param>
		/// <param name="material">Material to use.</param>
		/// <param name="shaderPass">Which pass of the shader to use (or -1 for all passes).</param>
		/// <param name="topology">Topology of the procedural geometry.</param>
		/// <param name="properties">Additional material properties to apply just before rendering. See MaterialPropertyBlock.</param>
		/// <param name="bufferWithArgs">Buffer with draw arguments.</param>
		/// <param name="argsOffset">Offset where in the buffer the draw arguments are.</param>
		// Token: 0x06000778 RID: 1912 RVA: 0x00004F6D File Offset: 0x0000316D
		public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, [DefaultValue("0")] int argsOffset, [DefaultValue("null")] MaterialPropertyBlock properties)
		{
			CommandBuffer.INTERNAL_CALL_DrawProceduralIndirect(this, ref matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x000144BC File Offset: 0x000126BC
		[ExcludeFromDocs]
		public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset)
		{
			MaterialPropertyBlock materialPropertyBlock = null;
			CommandBuffer.INTERNAL_CALL_DrawProceduralIndirect(this, ref matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, materialPropertyBlock);
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x000144DC File Offset: 0x000126DC
		[ExcludeFromDocs]
		public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs)
		{
			MaterialPropertyBlock materialPropertyBlock = null;
			int num = 0;
			CommandBuffer.INTERNAL_CALL_DrawProceduralIndirect(this, ref matrix, material, shaderPass, topology, bufferWithArgs, num, materialPropertyBlock);
		}

		// Token: 0x0600077B RID: 1915
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DrawProceduralIndirect(CommandBuffer self, ref Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties);

		/// <summary>
		///   <para>Add a "set active render target" command.</para>
		/// </summary>
		/// <param name="rt">Render target to set for both color &amp; depth buffers.</param>
		/// <param name="color">Render target to set as a color buffer.</param>
		/// <param name="colors">Render targets to set as color buffers (MRT).</param>
		/// <param name="depth">Render target to set as a depth buffer.</param>
		/// <param name="mipLevel">The mip level of the render target to render into.</param>
		/// <param name="cubemapFace">The cubemap face of a cubemap render target to render into.</param>
		// Token: 0x0600077C RID: 1916 RVA: 0x00004F81 File Offset: 0x00003181
		public void SetRenderTarget(RenderTargetIdentifier rt)
		{
			this.SetRenderTarget_Single(ref rt, 0, CubemapFace.Unknown);
		}

		/// <summary>
		///   <para>Add a "set active render target" command.</para>
		/// </summary>
		/// <param name="rt">Render target to set for both color &amp; depth buffers.</param>
		/// <param name="color">Render target to set as a color buffer.</param>
		/// <param name="colors">Render targets to set as color buffers (MRT).</param>
		/// <param name="depth">Render target to set as a depth buffer.</param>
		/// <param name="mipLevel">The mip level of the render target to render into.</param>
		/// <param name="cubemapFace">The cubemap face of a cubemap render target to render into.</param>
		// Token: 0x0600077D RID: 1917 RVA: 0x00004F8D File Offset: 0x0000318D
		public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel)
		{
			this.SetRenderTarget_Single(ref rt, mipLevel, CubemapFace.Unknown);
		}

		/// <summary>
		///   <para>Add a "set active render target" command.</para>
		/// </summary>
		/// <param name="rt">Render target to set for both color &amp; depth buffers.</param>
		/// <param name="color">Render target to set as a color buffer.</param>
		/// <param name="colors">Render targets to set as color buffers (MRT).</param>
		/// <param name="depth">Render target to set as a depth buffer.</param>
		/// <param name="mipLevel">The mip level of the render target to render into.</param>
		/// <param name="cubemapFace">The cubemap face of a cubemap render target to render into.</param>
		// Token: 0x0600077E RID: 1918 RVA: 0x00004F99 File Offset: 0x00003199
		public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace)
		{
			this.SetRenderTarget_Single(ref rt, mipLevel, cubemapFace);
		}

		/// <summary>
		///   <para>Add a "set active render target" command.</para>
		/// </summary>
		/// <param name="rt">Render target to set for both color &amp; depth buffers.</param>
		/// <param name="color">Render target to set as a color buffer.</param>
		/// <param name="colors">Render targets to set as color buffers (MRT).</param>
		/// <param name="depth">Render target to set as a depth buffer.</param>
		/// <param name="mipLevel">The mip level of the render target to render into.</param>
		/// <param name="cubemapFace">The cubemap face of a cubemap render target to render into.</param>
		// Token: 0x0600077F RID: 1919 RVA: 0x00004FA5 File Offset: 0x000031A5
		public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth)
		{
			this.SetRenderTarget_ColDepth(ref color, ref depth, 0, CubemapFace.Unknown);
		}

		/// <summary>
		///   <para>Add a "set active render target" command.</para>
		/// </summary>
		/// <param name="rt">Render target to set for both color &amp; depth buffers.</param>
		/// <param name="color">Render target to set as a color buffer.</param>
		/// <param name="colors">Render targets to set as color buffers (MRT).</param>
		/// <param name="depth">Render target to set as a depth buffer.</param>
		/// <param name="mipLevel">The mip level of the render target to render into.</param>
		/// <param name="cubemapFace">The cubemap face of a cubemap render target to render into.</param>
		// Token: 0x06000780 RID: 1920 RVA: 0x00004FB3 File Offset: 0x000031B3
		public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel)
		{
			this.SetRenderTarget_ColDepth(ref color, ref depth, mipLevel, CubemapFace.Unknown);
		}

		/// <summary>
		///   <para>Add a "set active render target" command.</para>
		/// </summary>
		/// <param name="rt">Render target to set for both color &amp; depth buffers.</param>
		/// <param name="color">Render target to set as a color buffer.</param>
		/// <param name="colors">Render targets to set as color buffers (MRT).</param>
		/// <param name="depth">Render target to set as a depth buffer.</param>
		/// <param name="mipLevel">The mip level of the render target to render into.</param>
		/// <param name="cubemapFace">The cubemap face of a cubemap render target to render into.</param>
		// Token: 0x06000781 RID: 1921 RVA: 0x00004FC1 File Offset: 0x000031C1
		public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace)
		{
			this.SetRenderTarget_ColDepth(ref color, ref depth, mipLevel, cubemapFace);
		}

		/// <summary>
		///   <para>Add a "set active render target" command.</para>
		/// </summary>
		/// <param name="rt">Render target to set for both color &amp; depth buffers.</param>
		/// <param name="color">Render target to set as a color buffer.</param>
		/// <param name="colors">Render targets to set as color buffers (MRT).</param>
		/// <param name="depth">Render target to set as a depth buffer.</param>
		/// <param name="mipLevel">The mip level of the render target to render into.</param>
		/// <param name="cubemapFace">The cubemap face of a cubemap render target to render into.</param>
		// Token: 0x06000782 RID: 1922 RVA: 0x00004FD0 File Offset: 0x000031D0
		public void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth)
		{
			this.SetRenderTarget_Multiple(colors, ref depth);
		}

		// Token: 0x06000783 RID: 1923
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetRenderTarget_Single(ref RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace);

		// Token: 0x06000784 RID: 1924
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetRenderTarget_ColDepth(ref RenderTargetIdentifier color, ref RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace);

		// Token: 0x06000785 RID: 1925
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetRenderTarget_Multiple(RenderTargetIdentifier[] color, ref RenderTargetIdentifier depth);

		/// <summary>
		///   <para>Add a "blit into a render texture" command.</para>
		/// </summary>
		/// <param name="source">Source texture or render target to blit from.</param>
		/// <param name="dest">Destination to blit into.</param>
		/// <param name="mat">Material to use.</param>
		/// <param name="pass">Shader pass to use (default is -1, meaning "all passes").</param>
		// Token: 0x06000786 RID: 1926 RVA: 0x00004FDB File Offset: 0x000031DB
		public void Blit(Texture source, RenderTargetIdentifier dest)
		{
			this.Blit_Texture(source, ref dest, null, -1);
		}

		/// <summary>
		///   <para>Add a "blit into a render texture" command.</para>
		/// </summary>
		/// <param name="source">Source texture or render target to blit from.</param>
		/// <param name="dest">Destination to blit into.</param>
		/// <param name="mat">Material to use.</param>
		/// <param name="pass">Shader pass to use (default is -1, meaning "all passes").</param>
		// Token: 0x06000787 RID: 1927 RVA: 0x00004FE8 File Offset: 0x000031E8
		public void Blit(Texture source, RenderTargetIdentifier dest, Material mat)
		{
			this.Blit_Texture(source, ref dest, mat, -1);
		}

		/// <summary>
		///   <para>Add a "blit into a render texture" command.</para>
		/// </summary>
		/// <param name="source">Source texture or render target to blit from.</param>
		/// <param name="dest">Destination to blit into.</param>
		/// <param name="mat">Material to use.</param>
		/// <param name="pass">Shader pass to use (default is -1, meaning "all passes").</param>
		// Token: 0x06000788 RID: 1928 RVA: 0x00004FF5 File Offset: 0x000031F5
		public void Blit(Texture source, RenderTargetIdentifier dest, Material mat, int pass)
		{
			this.Blit_Texture(source, ref dest, mat, pass);
		}

		// Token: 0x06000789 RID: 1929
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Blit_Texture(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass);

		/// <summary>
		///   <para>Add a "blit into a render texture" command.</para>
		/// </summary>
		/// <param name="source">Source texture or render target to blit from.</param>
		/// <param name="dest">Destination to blit into.</param>
		/// <param name="mat">Material to use.</param>
		/// <param name="pass">Shader pass to use (default is -1, meaning "all passes").</param>
		// Token: 0x0600078A RID: 1930 RVA: 0x00005003 File Offset: 0x00003203
		public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest)
		{
			this.Blit_Identifier(ref source, ref dest, null, -1);
		}

		/// <summary>
		///   <para>Add a "blit into a render texture" command.</para>
		/// </summary>
		/// <param name="source">Source texture or render target to blit from.</param>
		/// <param name="dest">Destination to blit into.</param>
		/// <param name="mat">Material to use.</param>
		/// <param name="pass">Shader pass to use (default is -1, meaning "all passes").</param>
		// Token: 0x0600078B RID: 1931 RVA: 0x00005011 File Offset: 0x00003211
		public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat)
		{
			this.Blit_Identifier(ref source, ref dest, mat, -1);
		}

		/// <summary>
		///   <para>Add a "blit into a render texture" command.</para>
		/// </summary>
		/// <param name="source">Source texture or render target to blit from.</param>
		/// <param name="dest">Destination to blit into.</param>
		/// <param name="mat">Material to use.</param>
		/// <param name="pass">Shader pass to use (default is -1, meaning "all passes").</param>
		// Token: 0x0600078C RID: 1932 RVA: 0x0000501F File Offset: 0x0000321F
		public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass)
		{
			this.Blit_Identifier(ref source, ref dest, mat, pass);
		}

		// Token: 0x0600078D RID: 1933
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Blit_Identifier(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, [DefaultValue("null")] Material mat, [DefaultValue("-1")] int pass);

		// Token: 0x0600078E RID: 1934 RVA: 0x00014500 File Offset: 0x00012700
		[ExcludeFromDocs]
		private void Blit_Identifier(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat)
		{
			int num = -1;
			this.Blit_Identifier(ref source, ref dest, mat, num);
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x0001451C File Offset: 0x0001271C
		[ExcludeFromDocs]
		private void Blit_Identifier(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest)
		{
			int num = -1;
			Material material = null;
			this.Blit_Identifier(ref source, ref dest, material, num);
		}

		/// <summary>
		///   <para>Add a "get a temporary render texture" command.</para>
		/// </summary>
		/// <param name="nameID">Shader property name for this texture.</param>
		/// <param name="width">Width in pixels, or -1 for "camera pixel width".</param>
		/// <param name="height">Height in pixels, or -1 for "camera pixel height".</param>
		/// <param name="depthBuffer">Depth buffer bits (0, 16 or 24).</param>
		/// <param name="filter">Texture filtering mode (default is Point).</param>
		/// <param name="format">Format of the render texture (default is ARGB32).</param>
		/// <param name="readWrite">Color space.</param>
		/// <param name="antiAliasing">Anti-aliasing (default is no anti-aliasing).</param>
		// Token: 0x06000790 RID: 1936
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void GetTemporaryRT(int nameID, int width, int height, [DefaultValue("0")] int depthBuffer, [DefaultValue("FilterMode.Point")] FilterMode filter, [DefaultValue("RenderTextureFormat.Default")] RenderTextureFormat format, [DefaultValue("RenderTextureReadWrite.Default")] RenderTextureReadWrite readWrite, [DefaultValue("1")] int antiAliasing);

		// Token: 0x06000791 RID: 1937 RVA: 0x00014538 File Offset: 0x00012738
		[ExcludeFromDocs]
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite)
		{
			int num = 1;
			this.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, readWrite, num);
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x0001455C File Offset: 0x0001275C
		[ExcludeFromDocs]
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format)
		{
			int num = 1;
			RenderTextureReadWrite renderTextureReadWrite = RenderTextureReadWrite.Default;
			this.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, renderTextureReadWrite, num);
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00014580 File Offset: 0x00012780
		[ExcludeFromDocs]
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter)
		{
			int num = 1;
			RenderTextureReadWrite renderTextureReadWrite = RenderTextureReadWrite.Default;
			RenderTextureFormat renderTextureFormat = RenderTextureFormat.Default;
			this.GetTemporaryRT(nameID, width, height, depthBuffer, filter, renderTextureFormat, renderTextureReadWrite, num);
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x000145A4 File Offset: 0x000127A4
		[ExcludeFromDocs]
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer)
		{
			int num = 1;
			RenderTextureReadWrite renderTextureReadWrite = RenderTextureReadWrite.Default;
			RenderTextureFormat renderTextureFormat = RenderTextureFormat.Default;
			FilterMode filterMode = FilterMode.Point;
			this.GetTemporaryRT(nameID, width, height, depthBuffer, filterMode, renderTextureFormat, renderTextureReadWrite, num);
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x000145C8 File Offset: 0x000127C8
		[ExcludeFromDocs]
		public void GetTemporaryRT(int nameID, int width, int height)
		{
			int num = 1;
			RenderTextureReadWrite renderTextureReadWrite = RenderTextureReadWrite.Default;
			RenderTextureFormat renderTextureFormat = RenderTextureFormat.Default;
			FilterMode filterMode = FilterMode.Point;
			int num2 = 0;
			this.GetTemporaryRT(nameID, width, height, num2, filterMode, renderTextureFormat, renderTextureReadWrite, num);
		}

		/// <summary>
		///   <para>Add a "release a temporary render texture" command.</para>
		/// </summary>
		/// <param name="nameID">Shader property name for this texture.</param>
		// Token: 0x06000796 RID: 1942
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void ReleaseTemporaryRT(int nameID);

		/// <summary>
		///   <para>Adds a "clear render target" command.</para>
		/// </summary>
		/// <param name="clearDepth">Should clear depth buffer?</param>
		/// <param name="clearColor">Should clear color buffer?</param>
		/// <param name="backgroundColor">Color to clear with.</param>
		/// <param name="depth">Depth to clear with (default is 1.0).</param>
		// Token: 0x06000797 RID: 1943 RVA: 0x0000502E File Offset: 0x0000322E
		public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, [DefaultValue("1.0f")] float depth)
		{
			CommandBuffer.INTERNAL_CALL_ClearRenderTarget(this, clearDepth, clearColor, ref backgroundColor, depth);
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x000145F0 File Offset: 0x000127F0
		[ExcludeFromDocs]
		public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor)
		{
			float num = 1f;
			CommandBuffer.INTERNAL_CALL_ClearRenderTarget(this, clearDepth, clearColor, ref backgroundColor, num);
		}

		// Token: 0x06000799 RID: 1945
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ClearRenderTarget(CommandBuffer self, bool clearDepth, bool clearColor, ref Color backgroundColor, float depth);

		/// <summary>
		///   <para>Add a "set global shader float property" command.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x0600079A RID: 1946 RVA: 0x0000503C File Offset: 0x0000323C
		public void SetGlobalFloat(string name, float value)
		{
			this.SetGlobalFloat(Shader.PropertyToID(name), value);
		}

		/// <summary>
		///   <para>Add a "set global shader float property" command.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x0600079B RID: 1947
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetGlobalFloat(int nameID, float value);

		/// <summary>
		///   <para>Add a "set global shader vector property" command.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x0600079C RID: 1948 RVA: 0x0000504B File Offset: 0x0000324B
		public void SetGlobalVector(string name, Vector4 value)
		{
			this.SetGlobalVector(Shader.PropertyToID(name), value);
		}

		/// <summary>
		///   <para>Add a "set global shader vector property" command.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x0600079D RID: 1949 RVA: 0x0000505A File Offset: 0x0000325A
		public void SetGlobalVector(int nameID, Vector4 value)
		{
			CommandBuffer.INTERNAL_CALL_SetGlobalVector(this, nameID, ref value);
		}

		// Token: 0x0600079E RID: 1950
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetGlobalVector(CommandBuffer self, int nameID, ref Vector4 value);

		/// <summary>
		///   <para>Add a "set global shader color property" command.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x0600079F RID: 1951 RVA: 0x00005065 File Offset: 0x00003265
		public void SetGlobalColor(string name, Color value)
		{
			this.SetGlobalColor(Shader.PropertyToID(name), value);
		}

		/// <summary>
		///   <para>Add a "set global shader color property" command.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x060007A0 RID: 1952 RVA: 0x00005074 File Offset: 0x00003274
		public void SetGlobalColor(int nameID, Color value)
		{
			CommandBuffer.INTERNAL_CALL_SetGlobalColor(this, nameID, ref value);
		}

		// Token: 0x060007A1 RID: 1953
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetGlobalColor(CommandBuffer self, int nameID, ref Color value);

		/// <summary>
		///   <para>Add a "set global shader matrix property" command.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x060007A2 RID: 1954 RVA: 0x0000507F File Offset: 0x0000327F
		public void SetGlobalMatrix(string name, Matrix4x4 value)
		{
			this.SetGlobalMatrix(Shader.PropertyToID(name), value);
		}

		/// <summary>
		///   <para>Add a "set global shader matrix property" command.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x060007A3 RID: 1955 RVA: 0x0000508E File Offset: 0x0000328E
		public void SetGlobalMatrix(int nameID, Matrix4x4 value)
		{
			CommandBuffer.INTERNAL_CALL_SetGlobalMatrix(this, nameID, ref value);
		}

		// Token: 0x060007A4 RID: 1956
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetGlobalMatrix(CommandBuffer self, int nameID, ref Matrix4x4 value);

		/// <summary>
		///   <para>Add a "set global shader texture property" command.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x060007A5 RID: 1957 RVA: 0x00005099 File Offset: 0x00003299
		public void SetGlobalTexture(string name, RenderTargetIdentifier value)
		{
			this.SetGlobalTexture(Shader.PropertyToID(name), value);
		}

		/// <summary>
		///   <para>Add a "set global shader texture property" command.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x060007A6 RID: 1958 RVA: 0x000050A8 File Offset: 0x000032A8
		public void SetGlobalTexture(int nameID, RenderTargetIdentifier value)
		{
			this.SetGlobalTexture_Impl(nameID, ref value);
		}

		// Token: 0x060007A7 RID: 1959
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetGlobalTexture_Impl(int nameID, ref RenderTargetIdentifier rt);

		/// <summary>
		///   <para>Send a user-defined event to a native code plugin.</para>
		/// </summary>
		/// <param name="callback">Native code callback to queue for Unity's renderer to invoke.</param>
		/// <param name="eventID">User defined id to send to the callback.</param>
		// Token: 0x060007A8 RID: 1960 RVA: 0x000050B3 File Offset: 0x000032B3
		public void IssuePluginEvent(IntPtr callback, int eventID)
		{
			if (callback == IntPtr.Zero)
			{
				throw new ArgumentException("Null callback specified.");
			}
			this.IssuePluginEventInternal(callback, eventID);
		}

		// Token: 0x060007A9 RID: 1961
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void IssuePluginEventInternal(IntPtr callback, int eventID);

		// Token: 0x04000178 RID: 376
		internal IntPtr m_Ptr;
	}
}
