using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Gizmos are used to give visual debugging or setup aids in the scene view.</para>
	/// </summary>
	// Token: 0x02000052 RID: 82
	public sealed class Gizmos
	{
		/// <summary>
		///   <para>Draws a ray starting at from to from + direction.</para>
		/// </summary>
		/// <param name="r"></param>
		/// <param name="from"></param>
		/// <param name="direction"></param>
		// Token: 0x06000442 RID: 1090 RVA: 0x00002C39 File Offset: 0x00000E39
		public static void DrawRay(Ray r)
		{
			Gizmos.DrawLine(r.origin, r.origin + r.direction);
		}

		/// <summary>
		///   <para>Draws a ray starting at from to from + direction.</para>
		/// </summary>
		/// <param name="r"></param>
		/// <param name="from"></param>
		/// <param name="direction"></param>
		// Token: 0x06000443 RID: 1091 RVA: 0x00002C5A File Offset: 0x00000E5A
		public static void DrawRay(Vector3 from, Vector3 direction)
		{
			Gizmos.DrawLine(from, from + direction);
		}

		/// <summary>
		///   <para>Draws a line starting at from towards to.</para>
		/// </summary>
		/// <param name="from"></param>
		/// <param name="to"></param>
		// Token: 0x06000444 RID: 1092 RVA: 0x00002C69 File Offset: 0x00000E69
		public static void DrawLine(Vector3 from, Vector3 to)
		{
			Gizmos.INTERNAL_CALL_DrawLine(ref from, ref to);
		}

		// Token: 0x06000445 RID: 1093
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DrawLine(ref Vector3 from, ref Vector3 to);

		/// <summary>
		///   <para>Draws a wireframe sphere with center and radius.</para>
		/// </summary>
		/// <param name="center"></param>
		/// <param name="radius"></param>
		// Token: 0x06000446 RID: 1094 RVA: 0x00002C74 File Offset: 0x00000E74
		public static void DrawWireSphere(Vector3 center, float radius)
		{
			Gizmos.INTERNAL_CALL_DrawWireSphere(ref center, radius);
		}

		// Token: 0x06000447 RID: 1095
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DrawWireSphere(ref Vector3 center, float radius);

		/// <summary>
		///   <para>Draws a solid sphere with center and radius.</para>
		/// </summary>
		/// <param name="center"></param>
		/// <param name="radius"></param>
		// Token: 0x06000448 RID: 1096 RVA: 0x00002C7E File Offset: 0x00000E7E
		public static void DrawSphere(Vector3 center, float radius)
		{
			Gizmos.INTERNAL_CALL_DrawSphere(ref center, radius);
		}

		// Token: 0x06000449 RID: 1097
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DrawSphere(ref Vector3 center, float radius);

		/// <summary>
		///   <para>Draw a wireframe box with center and size.</para>
		/// </summary>
		/// <param name="center"></param>
		/// <param name="size"></param>
		// Token: 0x0600044A RID: 1098 RVA: 0x00002C88 File Offset: 0x00000E88
		public static void DrawWireCube(Vector3 center, Vector3 size)
		{
			Gizmos.INTERNAL_CALL_DrawWireCube(ref center, ref size);
		}

		// Token: 0x0600044B RID: 1099
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DrawWireCube(ref Vector3 center, ref Vector3 size);

		/// <summary>
		///   <para>Draw a solid box with center and size.</para>
		/// </summary>
		/// <param name="center"></param>
		/// <param name="size"></param>
		// Token: 0x0600044C RID: 1100 RVA: 0x00002C93 File Offset: 0x00000E93
		public static void DrawCube(Vector3 center, Vector3 size)
		{
			Gizmos.INTERNAL_CALL_DrawCube(ref center, ref size);
		}

		// Token: 0x0600044D RID: 1101
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DrawCube(ref Vector3 center, ref Vector3 size);

		// Token: 0x0600044E RID: 1102 RVA: 0x00010258 File Offset: 0x0000E458
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation)
		{
			Vector3 one = Vector3.one;
			Gizmos.DrawMesh(mesh, position, rotation, one);
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00010274 File Offset: 0x0000E474
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Vector3 position)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Gizmos.DrawMesh(mesh, position, identity, one);
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00010298 File Offset: 0x0000E498
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Vector3 zero = Vector3.zero;
			Gizmos.DrawMesh(mesh, zero, identity, one);
		}

		/// <summary>
		///   <para>Draws a mesh.</para>
		/// </summary>
		/// <param name="mesh">Mesh to draw as a gizmo.</param>
		/// <param name="position">Position (default is zero).</param>
		/// <param name="rotation">Rotation (default is no rotation).</param>
		/// <param name="scale">Scale (default is no scale).</param>
		/// <param name="submeshIndex">Submesh to draw (default is -1, which draws whole mesh).</param>
		// Token: 0x06000451 RID: 1105 RVA: 0x00002C9E File Offset: 0x00000E9E
		public static void DrawMesh(Mesh mesh, [DefaultValue("Vector3.zero")] Vector3 position, [DefaultValue("Quaternion.identity")] Quaternion rotation, [DefaultValue("Vector3.one")] Vector3 scale)
		{
			Gizmos.DrawMesh(mesh, -1, position, rotation, scale);
		}

		/// <summary>
		///   <para>Draws a mesh.</para>
		/// </summary>
		/// <param name="mesh">Mesh to draw as a gizmo.</param>
		/// <param name="position">Position (default is zero).</param>
		/// <param name="rotation">Rotation (default is no rotation).</param>
		/// <param name="scale">Scale (default is no scale).</param>
		/// <param name="submeshIndex">Submesh to draw (default is -1, which draws whole mesh).</param>
		// Token: 0x06000452 RID: 1106 RVA: 0x00002CAA File Offset: 0x00000EAA
		public static void DrawMesh(Mesh mesh, int submeshIndex, [DefaultValue("Vector3.zero")] Vector3 position, [DefaultValue("Quaternion.identity")] Quaternion rotation, [DefaultValue("Vector3.one")] Vector3 scale)
		{
			Gizmos.INTERNAL_CALL_DrawMesh(mesh, submeshIndex, ref position, ref rotation, ref scale);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x000102C0 File Offset: 0x0000E4C0
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation)
		{
			Vector3 one = Vector3.one;
			Gizmos.INTERNAL_CALL_DrawMesh(mesh, submeshIndex, ref position, ref rotation, ref one);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x000102E0 File Offset: 0x0000E4E0
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Gizmos.INTERNAL_CALL_DrawMesh(mesh, submeshIndex, ref position, ref identity, ref one);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00010308 File Offset: 0x0000E508
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, int submeshIndex)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Vector3 zero = Vector3.zero;
			Gizmos.INTERNAL_CALL_DrawMesh(mesh, submeshIndex, ref zero, ref identity, ref one);
		}

		// Token: 0x06000456 RID: 1110
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DrawMesh(Mesh mesh, int submeshIndex, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale);

		// Token: 0x06000457 RID: 1111 RVA: 0x00010334 File Offset: 0x0000E534
		[ExcludeFromDocs]
		public static void DrawWireMesh(Mesh mesh, Vector3 position, Quaternion rotation)
		{
			Vector3 one = Vector3.one;
			Gizmos.DrawWireMesh(mesh, position, rotation, one);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00010350 File Offset: 0x0000E550
		[ExcludeFromDocs]
		public static void DrawWireMesh(Mesh mesh, Vector3 position)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Gizmos.DrawWireMesh(mesh, position, identity, one);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00010374 File Offset: 0x0000E574
		[ExcludeFromDocs]
		public static void DrawWireMesh(Mesh mesh)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Vector3 zero = Vector3.zero;
			Gizmos.DrawWireMesh(mesh, zero, identity, one);
		}

		/// <summary>
		///   <para>Draws a wireframe mesh.</para>
		/// </summary>
		/// <param name="mesh">Mesh to draw as a gizmo.</param>
		/// <param name="position">Position (default is zero).</param>
		/// <param name="rotation">Rotation (default is no rotation).</param>
		/// <param name="scale">Scale (default is no scale).</param>
		/// <param name="submeshIndex">Submesh to draw (default is -1, which draws whole mesh).</param>
		// Token: 0x0600045A RID: 1114 RVA: 0x00002CB9 File Offset: 0x00000EB9
		public static void DrawWireMesh(Mesh mesh, [DefaultValue("Vector3.zero")] Vector3 position, [DefaultValue("Quaternion.identity")] Quaternion rotation, [DefaultValue("Vector3.one")] Vector3 scale)
		{
			Gizmos.DrawWireMesh(mesh, -1, position, rotation, scale);
		}

		/// <summary>
		///   <para>Draws a wireframe mesh.</para>
		/// </summary>
		/// <param name="mesh">Mesh to draw as a gizmo.</param>
		/// <param name="position">Position (default is zero).</param>
		/// <param name="rotation">Rotation (default is no rotation).</param>
		/// <param name="scale">Scale (default is no scale).</param>
		/// <param name="submeshIndex">Submesh to draw (default is -1, which draws whole mesh).</param>
		// Token: 0x0600045B RID: 1115 RVA: 0x00002CC5 File Offset: 0x00000EC5
		public static void DrawWireMesh(Mesh mesh, int submeshIndex, [DefaultValue("Vector3.zero")] Vector3 position, [DefaultValue("Quaternion.identity")] Quaternion rotation, [DefaultValue("Vector3.one")] Vector3 scale)
		{
			Gizmos.INTERNAL_CALL_DrawWireMesh(mesh, submeshIndex, ref position, ref rotation, ref scale);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0001039C File Offset: 0x0000E59C
		[ExcludeFromDocs]
		public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation)
		{
			Vector3 one = Vector3.one;
			Gizmos.INTERNAL_CALL_DrawWireMesh(mesh, submeshIndex, ref position, ref rotation, ref one);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x000103BC File Offset: 0x0000E5BC
		[ExcludeFromDocs]
		public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Gizmos.INTERNAL_CALL_DrawWireMesh(mesh, submeshIndex, ref position, ref identity, ref one);
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x000103E4 File Offset: 0x0000E5E4
		[ExcludeFromDocs]
		public static void DrawWireMesh(Mesh mesh, int submeshIndex)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Vector3 zero = Vector3.zero;
			Gizmos.INTERNAL_CALL_DrawWireMesh(mesh, submeshIndex, ref zero, ref identity, ref one);
		}

		// Token: 0x0600045F RID: 1119
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DrawWireMesh(Mesh mesh, int submeshIndex, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale);

		/// <summary>
		///   <para>Draw an icon at a position in the scene view.</para>
		/// </summary>
		/// <param name="center"></param>
		/// <param name="name"></param>
		/// <param name="allowScaling"></param>
		// Token: 0x06000460 RID: 1120 RVA: 0x00002CD4 File Offset: 0x00000ED4
		public static void DrawIcon(Vector3 center, string name, [DefaultValue("true")] bool allowScaling)
		{
			Gizmos.INTERNAL_CALL_DrawIcon(ref center, name, allowScaling);
		}

		/// <summary>
		///   <para>Draw an icon at a position in the scene view.</para>
		/// </summary>
		/// <param name="center"></param>
		/// <param name="name"></param>
		/// <param name="allowScaling"></param>
		// Token: 0x06000461 RID: 1121 RVA: 0x00010410 File Offset: 0x0000E610
		[ExcludeFromDocs]
		public static void DrawIcon(Vector3 center, string name)
		{
			bool flag = true;
			Gizmos.INTERNAL_CALL_DrawIcon(ref center, name, flag);
		}

		// Token: 0x06000462 RID: 1122
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DrawIcon(ref Vector3 center, string name, bool allowScaling);

		/// <summary>
		///   <para>Draw a texture in the scene.</para>
		/// </summary>
		/// <param name="screenRect">The size and position of the texture on the "screen" defined by the XY plane.</param>
		/// <param name="texture">The texture to be displayed.</param>
		/// <param name="mat">An optional material to apply the texture.</param>
		/// <param name="leftBorder">Inset from the rectangle's left edge.</param>
		/// <param name="rightBorder">Inset from the rectangle's right edge.</param>
		/// <param name="topBorder">Inset from the rectangle's top edge.</param>
		/// <param name="bottomBorder">Inset from the rectangle's bottom edge.</param>
		// Token: 0x06000463 RID: 1123 RVA: 0x00010428 File Offset: 0x0000E628
		[ExcludeFromDocs]
		public static void DrawGUITexture(Rect screenRect, Texture texture)
		{
			Material material = null;
			Gizmos.DrawGUITexture(screenRect, texture, material);
		}

		/// <summary>
		///   <para>Draw a texture in the scene.</para>
		/// </summary>
		/// <param name="screenRect">The size and position of the texture on the "screen" defined by the XY plane.</param>
		/// <param name="texture">The texture to be displayed.</param>
		/// <param name="mat">An optional material to apply the texture.</param>
		/// <param name="leftBorder">Inset from the rectangle's left edge.</param>
		/// <param name="rightBorder">Inset from the rectangle's right edge.</param>
		/// <param name="topBorder">Inset from the rectangle's top edge.</param>
		/// <param name="bottomBorder">Inset from the rectangle's bottom edge.</param>
		// Token: 0x06000464 RID: 1124 RVA: 0x00002CDF File Offset: 0x00000EDF
		public static void DrawGUITexture(Rect screenRect, Texture texture, [DefaultValue("null")] Material mat)
		{
			Gizmos.DrawGUITexture(screenRect, texture, 0, 0, 0, 0, mat);
		}

		/// <summary>
		///   <para>Draw a texture in the scene.</para>
		/// </summary>
		/// <param name="screenRect">The size and position of the texture on the "screen" defined by the XY plane.</param>
		/// <param name="texture">The texture to be displayed.</param>
		/// <param name="mat">An optional material to apply the texture.</param>
		/// <param name="leftBorder">Inset from the rectangle's left edge.</param>
		/// <param name="rightBorder">Inset from the rectangle's right edge.</param>
		/// <param name="topBorder">Inset from the rectangle's top edge.</param>
		/// <param name="bottomBorder">Inset from the rectangle's bottom edge.</param>
		// Token: 0x06000465 RID: 1125 RVA: 0x00002CED File Offset: 0x00000EED
		public static void DrawGUITexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, [DefaultValue("null")] Material mat)
		{
			Gizmos.INTERNAL_CALL_DrawGUITexture(ref screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, mat);
		}

		/// <summary>
		///   <para>Draw a texture in the scene.</para>
		/// </summary>
		/// <param name="screenRect">The size and position of the texture on the "screen" defined by the XY plane.</param>
		/// <param name="texture">The texture to be displayed.</param>
		/// <param name="mat">An optional material to apply the texture.</param>
		/// <param name="leftBorder">Inset from the rectangle's left edge.</param>
		/// <param name="rightBorder">Inset from the rectangle's right edge.</param>
		/// <param name="topBorder">Inset from the rectangle's top edge.</param>
		/// <param name="bottomBorder">Inset from the rectangle's bottom edge.</param>
		// Token: 0x06000466 RID: 1126 RVA: 0x00010440 File Offset: 0x0000E640
		[ExcludeFromDocs]
		public static void DrawGUITexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder)
		{
			Material material = null;
			Gizmos.INTERNAL_CALL_DrawGUITexture(ref screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, material);
		}

		// Token: 0x06000467 RID: 1127
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DrawGUITexture(ref Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat);

		/// <summary>
		///   <para>Sets the color for the gizmos that will be drawn next.</para>
		/// </summary>
		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x00010460 File Offset: 0x0000E660
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x00002CFF File Offset: 0x00000EFF
		public static Color color
		{
			get
			{
				Color color;
				Gizmos.INTERNAL_get_color(out color);
				return color;
			}
			set
			{
				Gizmos.INTERNAL_set_color(ref value);
			}
		}

		// Token: 0x0600046A RID: 1130
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_color(out Color value);

		// Token: 0x0600046B RID: 1131
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_color(ref Color value);

		/// <summary>
		///   <para>Set the gizmo matrix used to draw all gizmos.</para>
		/// </summary>
		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x00010478 File Offset: 0x0000E678
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x00002D08 File Offset: 0x00000F08
		public static Matrix4x4 matrix
		{
			get
			{
				Matrix4x4 matrix4x;
				Gizmos.INTERNAL_get_matrix(out matrix4x);
				return matrix4x;
			}
			set
			{
				Gizmos.INTERNAL_set_matrix(ref value);
			}
		}

		// Token: 0x0600046E RID: 1134
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_matrix(out Matrix4x4 value);

		// Token: 0x0600046F RID: 1135
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_matrix(ref Matrix4x4 value);

		/// <summary>
		///   <para>Draw a camera frustum using the currently set Gizmos.matrix for it's location and rotation.</para>
		/// </summary>
		/// <param name="center">The apex of the truncated pyramid.</param>
		/// <param name="fov">Vertical field of view (ie, the angle at the apex in degrees).</param>
		/// <param name="maxRange">Distance of the frustum's far plane.</param>
		/// <param name="minRange">Distance of the frustum's near plane.</param>
		/// <param name="aspect">Width/height ratio.</param>
		// Token: 0x06000470 RID: 1136 RVA: 0x00002D11 File Offset: 0x00000F11
		public static void DrawFrustum(Vector3 center, float fov, float maxRange, float minRange, float aspect)
		{
			Gizmos.INTERNAL_CALL_DrawFrustum(ref center, fov, maxRange, minRange, aspect);
		}

		// Token: 0x06000471 RID: 1137
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DrawFrustum(ref Vector3 center, float fov, float maxRange, float minRange, float aspect);
	}
}
