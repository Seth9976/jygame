using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Rendering;

namespace UnityEngine
{
	/// <summary>
	///   <para>Raw interface to Unity's drawing functions.</para>
	/// </summary>
	// Token: 0x0200002E RID: 46
	public sealed class Graphics
	{
		// Token: 0x0600021E RID: 542 RVA: 0x0000F420 File Offset: 0x0000D620
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows)
		{
			bool flag = true;
			Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows, flag);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000F444 File Offset: 0x0000D644
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties)
		{
			bool flag = true;
			bool flag2 = true;
			Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex, properties, flag2, flag);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000F468 File Offset: 0x0000D668
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex)
		{
			bool flag = true;
			bool flag2 = true;
			MaterialPropertyBlock materialPropertyBlock = null;
			Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex, materialPropertyBlock, flag2, flag);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000F490 File Offset: 0x0000D690
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera)
		{
			bool flag = true;
			bool flag2 = true;
			MaterialPropertyBlock materialPropertyBlock = null;
			int num = 0;
			Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, num, materialPropertyBlock, flag2, flag);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000F4B8 File Offset: 0x0000D6B8
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer)
		{
			bool flag = true;
			bool flag2 = true;
			MaterialPropertyBlock materialPropertyBlock = null;
			int num = 0;
			Camera camera = null;
			Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, num, materialPropertyBlock, flag2, flag);
		}

		/// <summary>
		///   <para>Draw a mesh.</para>
		/// </summary>
		/// <param name="mesh">The Mesh to draw.</param>
		/// <param name="position">Position of the mesh.</param>
		/// <param name="rotation">Rotation of the mesh.</param>
		/// <param name="matrix">Transformation matrix of the mesh (combines position, rotation and other transformations).</param>
		/// <param name="material">Material to use.</param>
		/// <param name="layer"> to use.</param>
		/// <param name="camera">If null (default), the mesh will be drawn in all cameras. Otherwise it will be rendered in the given camera only.</param>
		/// <param name="submeshIndex">Which subset of the mesh to draw. This applies only to meshes that are composed of several materials.</param>
		/// <param name="properties">Additional material properties to apply onto material just before this mesh will be drawn. See MaterialPropertyBlock.</param>
		/// <param name="castShadows">Should the mesh cast shadows?</param>
		/// <param name="receiveShadows">Should the mesh receive shadows?</param>
		/// <param name="materialIndex"></param>
		/// <param name="probeAnchor"></param>
		// Token: 0x06000223 RID: 547 RVA: 0x0000F4E4 File Offset: 0x0000D6E4
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, [DefaultValue("null")] Camera camera, [DefaultValue("0")] int submeshIndex, [DefaultValue("null")] MaterialPropertyBlock properties, [DefaultValue("true")] bool castShadows, [DefaultValue("true")] bool receiveShadows)
		{
			Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex, properties, (!castShadows) ? ShadowCastingMode.Off : ShadowCastingMode.On, receiveShadows);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000F514 File Offset: 0x0000D714
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows)
		{
			Transform transform = null;
			Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, transform);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000F53C File Offset: 0x0000D73C
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows)
		{
			Transform transform = null;
			bool flag = true;
			Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows, flag, transform);
		}

		/// <summary>
		///   <para>Draw a mesh.</para>
		/// </summary>
		/// <param name="mesh">The Mesh to draw.</param>
		/// <param name="position">Position of the mesh.</param>
		/// <param name="rotation">Rotation of the mesh.</param>
		/// <param name="matrix">Transformation matrix of the mesh (combines position, rotation and other transformations).</param>
		/// <param name="material">Material to use.</param>
		/// <param name="layer"> to use.</param>
		/// <param name="camera">If null (default), the mesh will be drawn in all cameras. Otherwise it will be rendered in the given camera only.</param>
		/// <param name="submeshIndex">Which subset of the mesh to draw. This applies only to meshes that are composed of several materials.</param>
		/// <param name="properties">Additional material properties to apply onto material just before this mesh will be drawn. See MaterialPropertyBlock.</param>
		/// <param name="castShadows">Should the mesh cast shadows?</param>
		/// <param name="receiveShadows">Should the mesh receive shadows?</param>
		/// <param name="materialIndex"></param>
		/// <param name="probeAnchor"></param>
		// Token: 0x06000226 RID: 550 RVA: 0x0000F564 File Offset: 0x0000D764
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, [DefaultValue("true")] bool receiveShadows, [DefaultValue("null")] Transform probeAnchor)
		{
			Internal_DrawMeshTRArguments internal_DrawMeshTRArguments = default(Internal_DrawMeshTRArguments);
			internal_DrawMeshTRArguments.position = position;
			internal_DrawMeshTRArguments.rotation = rotation;
			internal_DrawMeshTRArguments.layer = layer;
			internal_DrawMeshTRArguments.submeshIndex = submeshIndex;
			internal_DrawMeshTRArguments.castShadows = (int)castShadows;
			internal_DrawMeshTRArguments.receiveShadows = ((!receiveShadows) ? 0 : 1);
			internal_DrawMeshTRArguments.reflectionProbeAnchorInstanceID = ((!(probeAnchor != null)) ? 0 : probeAnchor.GetInstanceID());
			Graphics.Internal_DrawMeshTR(ref internal_DrawMeshTRArguments, properties, material, mesh, camera);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000F5E8 File Offset: 0x0000D7E8
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows)
		{
			bool flag = true;
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, flag);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000F60C File Offset: 0x0000D80C
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties)
		{
			bool flag = true;
			bool flag2 = true;
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, flag2, flag);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000F630 File Offset: 0x0000D830
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex)
		{
			bool flag = true;
			bool flag2 = true;
			MaterialPropertyBlock materialPropertyBlock = null;
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, materialPropertyBlock, flag2, flag);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000F654 File Offset: 0x0000D854
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera)
		{
			bool flag = true;
			bool flag2 = true;
			MaterialPropertyBlock materialPropertyBlock = null;
			int num = 0;
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, num, materialPropertyBlock, flag2, flag);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000F678 File Offset: 0x0000D878
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer)
		{
			bool flag = true;
			bool flag2 = true;
			MaterialPropertyBlock materialPropertyBlock = null;
			int num = 0;
			Camera camera = null;
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, num, materialPropertyBlock, flag2, flag);
		}

		/// <summary>
		///   <para>Draw a mesh.</para>
		/// </summary>
		/// <param name="mesh">The Mesh to draw.</param>
		/// <param name="position">Position of the mesh.</param>
		/// <param name="rotation">Rotation of the mesh.</param>
		/// <param name="matrix">Transformation matrix of the mesh (combines position, rotation and other transformations).</param>
		/// <param name="material">Material to use.</param>
		/// <param name="layer"> to use.</param>
		/// <param name="camera">If null (default), the mesh will be drawn in all cameras. Otherwise it will be rendered in the given camera only.</param>
		/// <param name="submeshIndex">Which subset of the mesh to draw. This applies only to meshes that are composed of several materials.</param>
		/// <param name="properties">Additional material properties to apply onto material just before this mesh will be drawn. See MaterialPropertyBlock.</param>
		/// <param name="castShadows">Should the mesh cast shadows?</param>
		/// <param name="receiveShadows">Should the mesh receive shadows?</param>
		/// <param name="materialIndex"></param>
		/// <param name="probeAnchor"></param>
		// Token: 0x0600022C RID: 556 RVA: 0x0000F6A0 File Offset: 0x0000D8A0
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, [DefaultValue("null")] Camera camera, [DefaultValue("0")] int submeshIndex, [DefaultValue("null")] MaterialPropertyBlock properties, [DefaultValue("true")] bool castShadows, [DefaultValue("true")] bool receiveShadows)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, (!castShadows) ? ShadowCastingMode.Off : ShadowCastingMode.On, receiveShadows);
		}

		/// <summary>
		///   <para>Draw a mesh.</para>
		/// </summary>
		/// <param name="mesh">The Mesh to draw.</param>
		/// <param name="position">Position of the mesh.</param>
		/// <param name="rotation">Rotation of the mesh.</param>
		/// <param name="matrix">Transformation matrix of the mesh (combines position, rotation and other transformations).</param>
		/// <param name="material">Material to use.</param>
		/// <param name="layer"> to use.</param>
		/// <param name="camera">If null (default), the mesh will be drawn in all cameras. Otherwise it will be rendered in the given camera only.</param>
		/// <param name="submeshIndex">Which subset of the mesh to draw. This applies only to meshes that are composed of several materials.</param>
		/// <param name="properties">Additional material properties to apply onto material just before this mesh will be drawn. See MaterialPropertyBlock.</param>
		/// <param name="castShadows">Should the mesh cast shadows?</param>
		/// <param name="receiveShadows">Should the mesh receive shadows?</param>
		/// <param name="materialIndex"></param>
		/// <param name="probeAnchor"></param>
		// Token: 0x0600022D RID: 557 RVA: 0x0000F6CC File Offset: 0x0000D8CC
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows)
		{
			Transform transform = null;
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, transform);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000F6F0 File Offset: 0x0000D8F0
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows)
		{
			Transform transform = null;
			bool flag = true;
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, flag, transform);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000F714 File Offset: 0x0000D914
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, [DefaultValue("true")] bool receiveShadows, [DefaultValue("null")] Transform probeAnchor)
		{
			Internal_DrawMeshMatrixArguments internal_DrawMeshMatrixArguments = default(Internal_DrawMeshMatrixArguments);
			internal_DrawMeshMatrixArguments.matrix = matrix;
			internal_DrawMeshMatrixArguments.layer = layer;
			internal_DrawMeshMatrixArguments.submeshIndex = submeshIndex;
			internal_DrawMeshMatrixArguments.castShadows = (int)castShadows;
			internal_DrawMeshMatrixArguments.receiveShadows = ((!receiveShadows) ? 0 : 1);
			internal_DrawMeshMatrixArguments.reflectionProbeAnchorInstanceID = ((!(probeAnchor != null)) ? 0 : probeAnchor.GetInstanceID());
			Graphics.Internal_DrawMeshMatrix(ref internal_DrawMeshMatrixArguments, properties, material, mesh, camera);
		}

		// Token: 0x06000230 RID: 560
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_DrawMeshTR(ref Internal_DrawMeshTRArguments arguments, MaterialPropertyBlock properties, Material material, Mesh mesh, Camera camera);

		// Token: 0x06000231 RID: 561
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_DrawMeshMatrix(ref Internal_DrawMeshMatrixArguments arguments, MaterialPropertyBlock properties, Material material, Mesh mesh, Camera camera);

		/// <summary>
		///   <para>Draw a mesh immediately.</para>
		/// </summary>
		/// <param name="mesh">The Mesh to draw.</param>
		/// <param name="position">Position of the mesh.</param>
		/// <param name="rotation">Rotation of the mesh.</param>
		/// <param name="matrix">Transformation matrix of the mesh (combines position, rotation and other transformations). Note that the mesh will not be displayed correctly if matrix has negative scale.</param>
		/// <param name="materialIndex">Subset of the mesh to draw.</param>
		// Token: 0x06000232 RID: 562 RVA: 0x000025B1 File Offset: 0x000007B1
		public static void DrawMeshNow(Mesh mesh, Vector3 position, Quaternion rotation)
		{
			Graphics.Internal_DrawMeshNow1(mesh, position, rotation, -1);
		}

		/// <summary>
		///   <para>Draw a mesh immediately.</para>
		/// </summary>
		/// <param name="mesh">The Mesh to draw.</param>
		/// <param name="position">Position of the mesh.</param>
		/// <param name="rotation">Rotation of the mesh.</param>
		/// <param name="matrix">Transformation matrix of the mesh (combines position, rotation and other transformations). Note that the mesh will not be displayed correctly if matrix has negative scale.</param>
		/// <param name="materialIndex">Subset of the mesh to draw.</param>
		// Token: 0x06000233 RID: 563 RVA: 0x000025BC File Offset: 0x000007BC
		public static void DrawMeshNow(Mesh mesh, Vector3 position, Quaternion rotation, int materialIndex)
		{
			Graphics.Internal_DrawMeshNow1(mesh, position, rotation, materialIndex);
		}

		/// <summary>
		///   <para>Draw a mesh immediately.</para>
		/// </summary>
		/// <param name="mesh">The Mesh to draw.</param>
		/// <param name="position">Position of the mesh.</param>
		/// <param name="rotation">Rotation of the mesh.</param>
		/// <param name="matrix">Transformation matrix of the mesh (combines position, rotation and other transformations). Note that the mesh will not be displayed correctly if matrix has negative scale.</param>
		/// <param name="materialIndex">Subset of the mesh to draw.</param>
		// Token: 0x06000234 RID: 564 RVA: 0x000025C7 File Offset: 0x000007C7
		public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix)
		{
			Graphics.Internal_DrawMeshNow2(mesh, matrix, -1);
		}

		/// <summary>
		///   <para>Draw a mesh immediately.</para>
		/// </summary>
		/// <param name="mesh">The Mesh to draw.</param>
		/// <param name="position">Position of the mesh.</param>
		/// <param name="rotation">Rotation of the mesh.</param>
		/// <param name="matrix">Transformation matrix of the mesh (combines position, rotation and other transformations). Note that the mesh will not be displayed correctly if matrix has negative scale.</param>
		/// <param name="materialIndex">Subset of the mesh to draw.</param>
		// Token: 0x06000235 RID: 565 RVA: 0x000025D1 File Offset: 0x000007D1
		public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix, int materialIndex)
		{
			Graphics.Internal_DrawMeshNow2(mesh, matrix, materialIndex);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x000025DB File Offset: 0x000007DB
		private static void Internal_DrawMeshNow1(Mesh mesh, Vector3 position, Quaternion rotation, int materialIndex)
		{
			Graphics.INTERNAL_CALL_Internal_DrawMeshNow1(mesh, ref position, ref rotation, materialIndex);
		}

		// Token: 0x06000237 RID: 567
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_DrawMeshNow1(Mesh mesh, ref Vector3 position, ref Quaternion rotation, int materialIndex);

		// Token: 0x06000238 RID: 568 RVA: 0x000025E8 File Offset: 0x000007E8
		private static void Internal_DrawMeshNow2(Mesh mesh, Matrix4x4 matrix, int materialIndex)
		{
			Graphics.INTERNAL_CALL_Internal_DrawMeshNow2(mesh, ref matrix, materialIndex);
		}

		// Token: 0x06000239 RID: 569
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_DrawMeshNow2(Mesh mesh, ref Matrix4x4 matrix, int materialIndex);

		/// <summary>
		///   <para>Draws a fully procedural geometry on the GPU.</para>
		/// </summary>
		/// <param name="topology"></param>
		/// <param name="vertexCount"></param>
		/// <param name="instanceCount"></param>
		// Token: 0x0600023A RID: 570
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DrawProcedural(MeshTopology topology, int vertexCount, [DefaultValue("1")] int instanceCount);

		// Token: 0x0600023B RID: 571 RVA: 0x0000F790 File Offset: 0x0000D990
		[ExcludeFromDocs]
		public static void DrawProcedural(MeshTopology topology, int vertexCount)
		{
			int num = 1;
			Graphics.DrawProcedural(topology, vertexCount, num);
		}

		/// <summary>
		///   <para>Draws a fully procedural geometry on the GPU.</para>
		/// </summary>
		/// <param name="topology">Topology of the procedural geometry.</param>
		/// <param name="bufferWithArgs">Buffer with draw arguments.</param>
		/// <param name="argsOffset">Offset where in the buffer the draw arguments are.</param>
		// Token: 0x0600023C RID: 572
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DrawProceduralIndirect(MeshTopology topology, ComputeBuffer bufferWithArgs, [DefaultValue("0")] int argsOffset);

		// Token: 0x0600023D RID: 573 RVA: 0x0000F7A8 File Offset: 0x0000D9A8
		[ExcludeFromDocs]
		public static void DrawProceduralIndirect(MeshTopology topology, ComputeBuffer bufferWithArgs)
		{
			int num = 0;
			Graphics.DrawProceduralIndirect(topology, bufferWithArgs, num);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000F7C0 File Offset: 0x0000D9C0
		[ExcludeFromDocs]
		public static void DrawTexture(Rect screenRect, Texture texture)
		{
			Material material = null;
			Graphics.DrawTexture(screenRect, texture, material);
		}

		/// <summary>
		///   <para>Draw a texture in screen coordinates.</para>
		/// </summary>
		/// <param name="screenRect">Rectangle on the screen to use for the texture. In pixel coordinates with (0,0) in the upper-left corner.</param>
		/// <param name="texture">Texture to draw.</param>
		/// <param name="sourceRect">Region of the texture to use. In normalized coordinates with (0,0) in the bottom-left corner.</param>
		/// <param name="leftBorder">Number of pixels from the left that are not affected by scale.</param>
		/// <param name="rightBorder">Number of pixels from the right that are not affected by scale.</param>
		/// <param name="topBorder">Number of pixels from the top that are not affected by scale.</param>
		/// <param name="bottomBorder">Number of pixels from the bottom that are not affected by scale.</param>
		/// <param name="color">Color that modulates the output. The neutral value is (0.5, 0.5, 0.5, 0.5). Set as vertex color for the shader.</param>
		/// <param name="mat">Custom Material that can be used to draw the texture. If null is passed, a default material with the Internal-GUITexture.shader is used.</param>
		// Token: 0x0600023F RID: 575 RVA: 0x000025F3 File Offset: 0x000007F3
		public static void DrawTexture(Rect screenRect, Texture texture, [DefaultValue("null")] Material mat)
		{
			Graphics.DrawTexture(screenRect, texture, 0, 0, 0, 0, mat);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000F7D8 File Offset: 0x0000D9D8
		[ExcludeFromDocs]
		public static void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder)
		{
			Material material = null;
			Graphics.DrawTexture(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, material);
		}

		/// <summary>
		///   <para>Draw a texture in screen coordinates.</para>
		/// </summary>
		/// <param name="screenRect">Rectangle on the screen to use for the texture. In pixel coordinates with (0,0) in the upper-left corner.</param>
		/// <param name="texture">Texture to draw.</param>
		/// <param name="sourceRect">Region of the texture to use. In normalized coordinates with (0,0) in the bottom-left corner.</param>
		/// <param name="leftBorder">Number of pixels from the left that are not affected by scale.</param>
		/// <param name="rightBorder">Number of pixels from the right that are not affected by scale.</param>
		/// <param name="topBorder">Number of pixels from the top that are not affected by scale.</param>
		/// <param name="bottomBorder">Number of pixels from the bottom that are not affected by scale.</param>
		/// <param name="color">Color that modulates the output. The neutral value is (0.5, 0.5, 0.5, 0.5). Set as vertex color for the shader.</param>
		/// <param name="mat">Custom Material that can be used to draw the texture. If null is passed, a default material with the Internal-GUITexture.shader is used.</param>
		// Token: 0x06000241 RID: 577 RVA: 0x00002601 File Offset: 0x00000801
		public static void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, [DefaultValue("null")] Material mat)
		{
			Graphics.DrawTexture(screenRect, texture, new Rect(0f, 0f, 1f, 1f), leftBorder, rightBorder, topBorder, bottomBorder, mat);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000F7F8 File Offset: 0x0000D9F8
		[ExcludeFromDocs]
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder)
		{
			Material material = null;
			Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, material);
		}

		/// <summary>
		///   <para>Draw a texture in screen coordinates.</para>
		/// </summary>
		/// <param name="screenRect">Rectangle on the screen to use for the texture. In pixel coordinates with (0,0) in the upper-left corner.</param>
		/// <param name="texture">Texture to draw.</param>
		/// <param name="sourceRect">Region of the texture to use. In normalized coordinates with (0,0) in the bottom-left corner.</param>
		/// <param name="leftBorder">Number of pixels from the left that are not affected by scale.</param>
		/// <param name="rightBorder">Number of pixels from the right that are not affected by scale.</param>
		/// <param name="topBorder">Number of pixels from the top that are not affected by scale.</param>
		/// <param name="bottomBorder">Number of pixels from the bottom that are not affected by scale.</param>
		/// <param name="color">Color that modulates the output. The neutral value is (0.5, 0.5, 0.5, 0.5). Set as vertex color for the shader.</param>
		/// <param name="mat">Custom Material that can be used to draw the texture. If null is passed, a default material with the Internal-GUITexture.shader is used.</param>
		// Token: 0x06000243 RID: 579 RVA: 0x0000F818 File Offset: 0x0000DA18
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, [DefaultValue("null")] Material mat)
		{
			InternalDrawTextureArguments internalDrawTextureArguments = default(InternalDrawTextureArguments);
			internalDrawTextureArguments.screenRect = screenRect;
			internalDrawTextureArguments.texture = texture;
			internalDrawTextureArguments.sourceRect = sourceRect;
			internalDrawTextureArguments.leftBorder = leftBorder;
			internalDrawTextureArguments.rightBorder = rightBorder;
			internalDrawTextureArguments.topBorder = topBorder;
			internalDrawTextureArguments.bottomBorder = bottomBorder;
			Color32 color = default(Color32);
			color.r = (color.g = (color.b = (color.a = 128)));
			internalDrawTextureArguments.color = color;
			internalDrawTextureArguments.mat = mat;
			Graphics.DrawTexture(ref internalDrawTextureArguments);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000F8B4 File Offset: 0x0000DAB4
		[ExcludeFromDocs]
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color)
		{
			Material material = null;
			Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, material);
		}

		/// <summary>
		///   <para>Draw a texture in screen coordinates.</para>
		/// </summary>
		/// <param name="screenRect">Rectangle on the screen to use for the texture. In pixel coordinates with (0,0) in the upper-left corner.</param>
		/// <param name="texture">Texture to draw.</param>
		/// <param name="sourceRect">Region of the texture to use. In normalized coordinates with (0,0) in the bottom-left corner.</param>
		/// <param name="leftBorder">Number of pixels from the left that are not affected by scale.</param>
		/// <param name="rightBorder">Number of pixels from the right that are not affected by scale.</param>
		/// <param name="topBorder">Number of pixels from the top that are not affected by scale.</param>
		/// <param name="bottomBorder">Number of pixels from the bottom that are not affected by scale.</param>
		/// <param name="color">Color that modulates the output. The neutral value is (0.5, 0.5, 0.5, 0.5). Set as vertex color for the shader.</param>
		/// <param name="mat">Custom Material that can be used to draw the texture. If null is passed, a default material with the Internal-GUITexture.shader is used.</param>
		// Token: 0x06000245 RID: 581 RVA: 0x0000F8D8 File Offset: 0x0000DAD8
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color, [DefaultValue("null")] Material mat)
		{
			InternalDrawTextureArguments internalDrawTextureArguments = default(InternalDrawTextureArguments);
			internalDrawTextureArguments.screenRect = screenRect;
			internalDrawTextureArguments.texture = texture;
			internalDrawTextureArguments.sourceRect = sourceRect;
			internalDrawTextureArguments.leftBorder = leftBorder;
			internalDrawTextureArguments.rightBorder = rightBorder;
			internalDrawTextureArguments.topBorder = topBorder;
			internalDrawTextureArguments.bottomBorder = bottomBorder;
			internalDrawTextureArguments.color = color;
			internalDrawTextureArguments.mat = mat;
			Graphics.DrawTexture(ref internalDrawTextureArguments);
		}

		// Token: 0x06000246 RID: 582
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void DrawTexture(ref InternalDrawTextureArguments arguments);

		/// <summary>
		///   <para>Execute a command buffer.</para>
		/// </summary>
		/// <param name="buffer">The buffer to execute.</param>
		// Token: 0x06000247 RID: 583
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ExecuteCommandBuffer(CommandBuffer buffer);

		/// <summary>
		///   <para>Copies source texture into destination render texture with a shader.</para>
		/// </summary>
		/// <param name="source">Source texture.</param>
		/// <param name="dest">Destination RenderTexture, or null to blit directly to screen.</param>
		/// <param name="mat">Material to use. Material's shader could do some post-processing effect, for example.</param>
		/// <param name="pass">If -1 (default), draws all passes in the material. Otherwise, draws given pass only.</param>
		// Token: 0x06000248 RID: 584
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Blit(Texture source, RenderTexture dest);

		// Token: 0x06000249 RID: 585 RVA: 0x0000F948 File Offset: 0x0000DB48
		[ExcludeFromDocs]
		public static void Blit(Texture source, RenderTexture dest, Material mat)
		{
			int num = -1;
			Graphics.Blit(source, dest, mat, num);
		}

		/// <summary>
		///   <para>Copies source texture into destination render texture with a shader.</para>
		/// </summary>
		/// <param name="source">Source texture.</param>
		/// <param name="dest">Destination RenderTexture, or null to blit directly to screen.</param>
		/// <param name="mat">Material to use. Material's shader could do some post-processing effect, for example.</param>
		/// <param name="pass">If -1 (default), draws all passes in the material. Otherwise, draws given pass only.</param>
		// Token: 0x0600024A RID: 586 RVA: 0x0000262B File Offset: 0x0000082B
		public static void Blit(Texture source, RenderTexture dest, Material mat, [DefaultValue("-1")] int pass)
		{
			Graphics.Internal_BlitMaterial(source, dest, mat, pass, true);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000F960 File Offset: 0x0000DB60
		[ExcludeFromDocs]
		public static void Blit(Texture source, Material mat)
		{
			int num = -1;
			Graphics.Blit(source, mat, num);
		}

		/// <summary>
		///   <para>Copies source texture into destination render texture with a shader.</para>
		/// </summary>
		/// <param name="source">Source texture.</param>
		/// <param name="dest">Destination RenderTexture, or null to blit directly to screen.</param>
		/// <param name="mat">Material to use. Material's shader could do some post-processing effect, for example.</param>
		/// <param name="pass">If -1 (default), draws all passes in the material. Otherwise, draws given pass only.</param>
		// Token: 0x0600024C RID: 588 RVA: 0x00002637 File Offset: 0x00000837
		public static void Blit(Texture source, Material mat, [DefaultValue("-1")] int pass)
		{
			Graphics.Internal_BlitMaterial(source, null, mat, pass, false);
		}

		// Token: 0x0600024D RID: 589
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_BlitMaterial(Texture source, RenderTexture dest, Material mat, int pass, bool setRT);

		/// <summary>
		///   <para>Copies source texture into destination, for multi-tap shader.</para>
		/// </summary>
		/// <param name="source">Source texture.</param>
		/// <param name="dest">Destination RenderTexture, or null to blit directly to screen.</param>
		/// <param name="mat">Material to use for copying. Material's shader should do some post-processing effect.</param>
		/// <param name="offsets">Variable number of filtering offsets. Offsets are given in pixels.</param>
		// Token: 0x0600024E RID: 590 RVA: 0x00002643 File Offset: 0x00000843
		public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, params Vector2[] offsets)
		{
			Graphics.Internal_BlitMultiTap(source, dest, mat, offsets);
		}

		// Token: 0x0600024F RID: 591
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_BlitMultiTap(Texture source, RenderTexture dest, Material mat, Vector2[] offsets);

		// Token: 0x06000250 RID: 592
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetNullRT();

		// Token: 0x06000251 RID: 593
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetRTFullSetup(out RenderBuffer color, out RenderBuffer depth, int mip, int face, RenderBufferLoadAction colorLoad, RenderBufferStoreAction colorStore, RenderBufferLoadAction depthLoad, RenderBufferStoreAction depthStore);

		// Token: 0x06000252 RID: 594
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetRTSimple(out RenderBuffer color, out RenderBuffer depth, int mip, int face);

		// Token: 0x06000253 RID: 595
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetMRTFullSetup(RenderBuffer[] color, out RenderBuffer depth, int mip, int face, RenderBufferLoadAction[] colorLoad, RenderBufferStoreAction[] colorStore, RenderBufferLoadAction depthLoad, RenderBufferStoreAction depthStore);

		// Token: 0x06000254 RID: 596
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetMRTSimple(RenderBuffer[] color, out RenderBuffer depth, int mip, int face);

		/// <summary>
		///   <para>Currently active color buffer (Read Only).</para>
		/// </summary>
		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000255 RID: 597 RVA: 0x0000F978 File Offset: 0x0000DB78
		public static RenderBuffer activeColorBuffer
		{
			get
			{
				RenderBuffer renderBuffer;
				Graphics.GetActiveColorBuffer(out renderBuffer);
				return renderBuffer;
			}
		}

		/// <summary>
		///   <para>Currently active depth/stencil buffer (Read Only).</para>
		/// </summary>
		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000256 RID: 598 RVA: 0x0000F990 File Offset: 0x0000DB90
		public static RenderBuffer activeDepthBuffer
		{
			get
			{
				RenderBuffer renderBuffer;
				Graphics.GetActiveDepthBuffer(out renderBuffer);
				return renderBuffer;
			}
		}

		// Token: 0x06000257 RID: 599
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetActiveColorBuffer(out RenderBuffer res);

		// Token: 0x06000258 RID: 600
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetActiveDepthBuffer(out RenderBuffer res);

		/// <summary>
		///   <para>Set random write target for Shader Model 5.0 level pixel shaders.</para>
		/// </summary>
		/// <param name="index">Index of the random write target in the shader.</param>
		/// <param name="uav">RenderTexture/ComputeBuffer to set as write target.</param>
		// Token: 0x06000259 RID: 601 RVA: 0x0000264E File Offset: 0x0000084E
		public static void SetRandomWriteTarget(int index, RenderTexture uav)
		{
			Graphics.Internal_SetRandomWriteTargetRT(index, uav);
		}

		/// <summary>
		///   <para>Set random write target for Shader Model 5.0 level pixel shaders.</para>
		/// </summary>
		/// <param name="index">Index of the random write target in the shader.</param>
		/// <param name="uav">RenderTexture/ComputeBuffer to set as write target.</param>
		// Token: 0x0600025A RID: 602 RVA: 0x00002657 File Offset: 0x00000857
		public static void SetRandomWriteTarget(int index, ComputeBuffer uav)
		{
			Graphics.Internal_SetRandomWriteTargetBuffer(index, uav);
		}

		/// <summary>
		///   <para>Clear random write targets for Shader Model 5.0 level pixel shaders.</para>
		/// </summary>
		// Token: 0x0600025B RID: 603
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearRandomWriteTargets();

		// Token: 0x0600025C RID: 604
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetRandomWriteTargetRT(int index, RenderTexture uav);

		// Token: 0x0600025D RID: 605
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetRandomWriteTargetBuffer(int index, ComputeBuffer uav);

		// Token: 0x0600025E RID: 606
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void SetupVertexLights(Light[] lights);

		// Token: 0x0600025F RID: 607 RVA: 0x00002660 File Offset: 0x00000860
		internal static void CheckLoadActionValid(RenderBufferLoadAction load, string bufferType)
		{
			if (load != RenderBufferLoadAction.Load && load != RenderBufferLoadAction.DontCare)
			{
				throw new ArgumentException("Bad " + bufferType + " LoadAction");
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00002685 File Offset: 0x00000885
		internal static void CheckStoreActionValid(RenderBufferStoreAction store, string bufferType)
		{
			if (store != RenderBufferStoreAction.Store && store != RenderBufferStoreAction.DontCare)
			{
				throw new ArgumentException("Bad " + bufferType + " StoreAction");
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000F9A8 File Offset: 0x0000DBA8
		internal static void SetRenderTargetImpl(RenderTargetSetup setup)
		{
			if (setup.color.Length == 0)
			{
				throw new ArgumentException("Invalid color buffer count for SetRenderTarget");
			}
			if (setup.color.Length != setup.colorLoad.Length)
			{
				throw new ArgumentException("Color LoadAction and Buffer arrays have different sizes");
			}
			if (setup.color.Length != setup.colorStore.Length)
			{
				throw new ArgumentException("Color StoreAction and Buffer arrays have different sizes");
			}
			foreach (RenderBufferLoadAction renderBufferLoadAction in setup.colorLoad)
			{
				Graphics.CheckLoadActionValid(renderBufferLoadAction, "Color");
			}
			foreach (RenderBufferStoreAction renderBufferStoreAction in setup.colorStore)
			{
				Graphics.CheckStoreActionValid(renderBufferStoreAction, "Color");
			}
			Graphics.CheckLoadActionValid(setup.depthLoad, "Depth");
			Graphics.CheckStoreActionValid(setup.depthStore, "Depth");
			bool flag = setup.cubemapFace != -1;
			if (flag && (setup.cubemapFace < 0 || setup.cubemapFace > 5))
			{
				throw new ArgumentException("Bad CubemapFace");
			}
			Graphics.Internal_SetMRTFullSetup(setup.color, out setup.depth, setup.mipLevel, setup.cubemapFace, setup.colorLoad, setup.colorStore, setup.depthLoad, setup.depthStore);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000FB0C File Offset: 0x0000DD0C
		internal static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, int face)
		{
			RenderBuffer renderBuffer = colorBuffer;
			RenderBuffer renderBuffer2 = depthBuffer;
			Graphics.Internal_SetRTSimple(out renderBuffer, out renderBuffer2, mipLevel, face);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x000026AA File Offset: 0x000008AA
		internal static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, int face)
		{
			if (rt)
			{
				Graphics.SetRenderTargetImpl(rt.colorBuffer, rt.depthBuffer, mipLevel, face);
			}
			else
			{
				Graphics.Internal_SetNullRT();
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000FB28 File Offset: 0x0000DD28
		internal static void SetRenderTargetImpl(RenderBuffer[] colorBuffers, RenderBuffer depthBuffer, int mipLevel, int face)
		{
			RenderBuffer renderBuffer = depthBuffer;
			Graphics.Internal_SetMRTSimple(colorBuffers, out renderBuffer, mipLevel, face);
		}

		/// <summary>
		///   <para>Sets current render target.</para>
		/// </summary>
		/// <param name="setup"></param>
		/// <param name="rt"></param>
		/// <param name="mipLevel"></param>
		/// <param name="face"></param>
		/// <param name="colorBuffer"></param>
		/// <param name="depthBuffer"></param>
		/// <param name="colorBuffers"></param>
		// Token: 0x06000265 RID: 613 RVA: 0x000026D4 File Offset: 0x000008D4
		public static void SetRenderTarget(RenderTexture rt)
		{
			Graphics.SetRenderTargetImpl(rt, 0, -1);
		}

		/// <summary>
		///   <para>Sets current render target.</para>
		/// </summary>
		/// <param name="setup"></param>
		/// <param name="rt"></param>
		/// <param name="mipLevel"></param>
		/// <param name="face"></param>
		/// <param name="colorBuffer"></param>
		/// <param name="depthBuffer"></param>
		/// <param name="colorBuffers"></param>
		// Token: 0x06000266 RID: 614 RVA: 0x000026DE File Offset: 0x000008DE
		public static void SetRenderTarget(RenderTexture rt, int mipLevel)
		{
			Graphics.SetRenderTargetImpl(rt, mipLevel, -1);
		}

		/// <summary>
		///   <para>Sets current render target.</para>
		/// </summary>
		/// <param name="setup"></param>
		/// <param name="rt"></param>
		/// <param name="mipLevel"></param>
		/// <param name="face"></param>
		/// <param name="colorBuffer"></param>
		/// <param name="depthBuffer"></param>
		/// <param name="colorBuffers"></param>
		// Token: 0x06000267 RID: 615 RVA: 0x000026E8 File Offset: 0x000008E8
		public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face)
		{
			Graphics.SetRenderTargetImpl(rt, mipLevel, (int)face);
		}

		/// <summary>
		///   <para>Sets current render target.</para>
		/// </summary>
		/// <param name="setup"></param>
		/// <param name="rt"></param>
		/// <param name="mipLevel"></param>
		/// <param name="face"></param>
		/// <param name="colorBuffer"></param>
		/// <param name="depthBuffer"></param>
		/// <param name="colorBuffers"></param>
		// Token: 0x06000268 RID: 616 RVA: 0x000026F2 File Offset: 0x000008F2
		public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer)
		{
			Graphics.SetRenderTargetImpl(colorBuffer, depthBuffer, 0, -1);
		}

		/// <summary>
		///   <para>Sets current render target.</para>
		/// </summary>
		/// <param name="setup"></param>
		/// <param name="rt"></param>
		/// <param name="mipLevel"></param>
		/// <param name="face"></param>
		/// <param name="colorBuffer"></param>
		/// <param name="depthBuffer"></param>
		/// <param name="colorBuffers"></param>
		// Token: 0x06000269 RID: 617 RVA: 0x000026FD File Offset: 0x000008FD
		public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel)
		{
			Graphics.SetRenderTargetImpl(colorBuffer, depthBuffer, mipLevel, -1);
		}

		/// <summary>
		///   <para>Sets current render target.</para>
		/// </summary>
		/// <param name="setup"></param>
		/// <param name="rt"></param>
		/// <param name="mipLevel"></param>
		/// <param name="face"></param>
		/// <param name="colorBuffer"></param>
		/// <param name="depthBuffer"></param>
		/// <param name="colorBuffers"></param>
		// Token: 0x0600026A RID: 618 RVA: 0x00002708 File Offset: 0x00000908
		public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face)
		{
			Graphics.SetRenderTargetImpl(colorBuffer, depthBuffer, mipLevel, (int)face);
		}

		/// <summary>
		///   <para>Sets current render target.</para>
		/// </summary>
		/// <param name="setup"></param>
		/// <param name="rt"></param>
		/// <param name="mipLevel"></param>
		/// <param name="face"></param>
		/// <param name="colorBuffer"></param>
		/// <param name="depthBuffer"></param>
		/// <param name="colorBuffers"></param>
		// Token: 0x0600026B RID: 619 RVA: 0x00002713 File Offset: 0x00000913
		public static void SetRenderTarget(RenderBuffer[] colorBuffers, RenderBuffer depthBuffer)
		{
			Graphics.SetRenderTargetImpl(colorBuffers, depthBuffer, 0, -1);
		}

		/// <summary>
		///   <para>Sets current render target.</para>
		/// </summary>
		/// <param name="setup"></param>
		/// <param name="rt"></param>
		/// <param name="mipLevel"></param>
		/// <param name="face"></param>
		/// <param name="colorBuffer"></param>
		/// <param name="depthBuffer"></param>
		/// <param name="colorBuffers"></param>
		// Token: 0x0600026C RID: 620 RVA: 0x0000271E File Offset: 0x0000091E
		public static void SetRenderTarget(RenderTargetSetup setup)
		{
			Graphics.SetRenderTargetImpl(setup);
		}
	}
}
