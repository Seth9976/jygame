using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Low-level graphics library.</para>
	/// </summary>
	// Token: 0x02000036 RID: 54
	public sealed class GL
	{
		/// <summary>
		///   <para>Submit a vertex.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		// Token: 0x060002AA RID: 682
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Vertex3(float x, float y, float z);

		/// <summary>
		///   <para>Submit a vertex.</para>
		/// </summary>
		/// <param name="v"></param>
		// Token: 0x060002AB RID: 683 RVA: 0x000027BF File Offset: 0x000009BF
		public static void Vertex(Vector3 v)
		{
			GL.INTERNAL_CALL_Vertex(ref v);
		}

		// Token: 0x060002AC RID: 684
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Vertex(ref Vector3 v);

		/// <summary>
		///   <para>Sets current vertex color.</para>
		/// </summary>
		/// <param name="c"></param>
		// Token: 0x060002AD RID: 685 RVA: 0x000027C8 File Offset: 0x000009C8
		public static void Color(Color c)
		{
			GL.INTERNAL_CALL_Color(ref c);
		}

		// Token: 0x060002AE RID: 686
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Color(ref Color c);

		/// <summary>
		///   <para>Sets current texture coordinate (v.x,v.y,v.z) for all texture units.</para>
		/// </summary>
		/// <param name="v"></param>
		// Token: 0x060002AF RID: 687 RVA: 0x000027D1 File Offset: 0x000009D1
		public static void TexCoord(Vector3 v)
		{
			GL.INTERNAL_CALL_TexCoord(ref v);
		}

		// Token: 0x060002B0 RID: 688
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_TexCoord(ref Vector3 v);

		/// <summary>
		///   <para>Sets current texture coordinate (x,y) for all texture units.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		// Token: 0x060002B1 RID: 689
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void TexCoord2(float x, float y);

		/// <summary>
		///   <para>Sets current texture coordinate (x,y,z) for all texture units.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		// Token: 0x060002B2 RID: 690
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void TexCoord3(float x, float y, float z);

		/// <summary>
		///   <para>Sets current texture coordinate (x,y) for the actual texture unit.</para>
		/// </summary>
		/// <param name="unit"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		// Token: 0x060002B3 RID: 691
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MultiTexCoord2(int unit, float x, float y);

		/// <summary>
		///   <para>Sets current texture coordinate (x,y,z) to the actual texture unit.</para>
		/// </summary>
		/// <param name="unit"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		// Token: 0x060002B4 RID: 692
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MultiTexCoord3(int unit, float x, float y, float z);

		/// <summary>
		///   <para>Sets current texture coordinate (v.x,v.y,v.z) to the actual texture unit.</para>
		/// </summary>
		/// <param name="unit"></param>
		/// <param name="v"></param>
		// Token: 0x060002B5 RID: 693 RVA: 0x000027DA File Offset: 0x000009DA
		public static void MultiTexCoord(int unit, Vector3 v)
		{
			GL.INTERNAL_CALL_MultiTexCoord(unit, ref v);
		}

		// Token: 0x060002B6 RID: 694
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_MultiTexCoord(int unit, ref Vector3 v);

		/// <summary>
		///   <para>Begin drawing 3D primitives.</para>
		/// </summary>
		/// <param name="mode">Primitives to draw: can be TRIANGLES, TRIANGLE_STRIP, QUADS or LINES.</param>
		// Token: 0x060002B7 RID: 695
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Begin(int mode);

		/// <summary>
		///   <para>End drawing 3D primitives.</para>
		/// </summary>
		// Token: 0x060002B8 RID: 696
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void End();

		/// <summary>
		///   <para>Helper function to set up an ortho perspective transform.</para>
		/// </summary>
		// Token: 0x060002B9 RID: 697
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void LoadOrtho();

		/// <summary>
		///   <para>Setup a matrix for pixel-correct rendering.</para>
		/// </summary>
		// Token: 0x060002BA RID: 698
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void LoadPixelMatrix();

		// Token: 0x060002BB RID: 699
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void LoadPixelMatrixArgs(float left, float right, float bottom, float top);

		/// <summary>
		///   <para>Setup a matrix for pixel-correct rendering.</para>
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <param name="bottom"></param>
		/// <param name="top"></param>
		// Token: 0x060002BC RID: 700 RVA: 0x000027E4 File Offset: 0x000009E4
		public static void LoadPixelMatrix(float left, float right, float bottom, float top)
		{
			GL.LoadPixelMatrixArgs(left, right, bottom, top);
		}

		/// <summary>
		///   <para>Set the rendering viewport.</para>
		/// </summary>
		/// <param name="pixelRect"></param>
		// Token: 0x060002BD RID: 701 RVA: 0x000027EF File Offset: 0x000009EF
		public static void Viewport(Rect pixelRect)
		{
			GL.INTERNAL_CALL_Viewport(ref pixelRect);
		}

		// Token: 0x060002BE RID: 702
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Viewport(ref Rect pixelRect);

		/// <summary>
		///   <para>Load an arbitrary matrix to the current projection matrix.</para>
		/// </summary>
		/// <param name="mat"></param>
		// Token: 0x060002BF RID: 703 RVA: 0x000027F8 File Offset: 0x000009F8
		public static void LoadProjectionMatrix(Matrix4x4 mat)
		{
			GL.INTERNAL_CALL_LoadProjectionMatrix(ref mat);
		}

		// Token: 0x060002C0 RID: 704
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_LoadProjectionMatrix(ref Matrix4x4 mat);

		/// <summary>
		///   <para>Load the identity matrix to the current modelview matrix.</para>
		/// </summary>
		// Token: 0x060002C1 RID: 705
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void LoadIdentity();

		/// <summary>
		///   <para>The current modelview matrix.</para>
		/// </summary>
		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x0000FB78 File Offset: 0x0000DD78
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x00002801 File Offset: 0x00000A01
		public static Matrix4x4 modelview
		{
			get
			{
				Matrix4x4 matrix4x;
				GL.INTERNAL_get_modelview(out matrix4x);
				return matrix4x;
			}
			set
			{
				GL.INTERNAL_set_modelview(ref value);
			}
		}

		// Token: 0x060002C4 RID: 708
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_modelview(out Matrix4x4 value);

		// Token: 0x060002C5 RID: 709
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_modelview(ref Matrix4x4 value);

		/// <summary>
		///   <para>Multiplies the current modelview matrix with the one specified.</para>
		/// </summary>
		/// <param name="mat"></param>
		// Token: 0x060002C6 RID: 710 RVA: 0x0000280A File Offset: 0x00000A0A
		public static void MultMatrix(Matrix4x4 mat)
		{
			GL.INTERNAL_CALL_MultMatrix(ref mat);
		}

		// Token: 0x060002C7 RID: 711
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_MultMatrix(ref Matrix4x4 mat);

		/// <summary>
		///   <para>Saves both projection and modelview matrices to the matrix stack.</para>
		/// </summary>
		// Token: 0x060002C8 RID: 712
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void PushMatrix();

		/// <summary>
		///   <para>Restores both projection and modelview matrices off the top of the matrix stack.</para>
		/// </summary>
		// Token: 0x060002C9 RID: 713
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void PopMatrix();

		/// <summary>
		///   <para>Compute GPU projection matrix from camera's projection matrix.</para>
		/// </summary>
		/// <param name="proj"></param>
		/// <param name="renderIntoTexture"></param>
		// Token: 0x060002CA RID: 714 RVA: 0x00002813 File Offset: 0x00000A13
		public static Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture)
		{
			return GL.INTERNAL_CALL_GetGPUProjectionMatrix(ref proj, renderIntoTexture);
		}

		// Token: 0x060002CB RID: 715
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Matrix4x4 INTERNAL_CALL_GetGPUProjectionMatrix(ref Matrix4x4 proj, bool renderIntoTexture);

		/// <summary>
		///   <para>Should rendering be done in wireframe?</para>
		/// </summary>
		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060002CC RID: 716
		// (set) Token: 0x060002CD RID: 717
		public static extern bool wireframe
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060002CE RID: 718
		// (set) Token: 0x060002CF RID: 719
		public static extern bool sRGBWrite
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Select whether to invert the backface culling (true) or not (false).</para>
		/// </summary>
		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060002D0 RID: 720
		// (set) Token: 0x060002D1 RID: 721
		public static extern bool invertCulling
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x060002D2 RID: 722
		[Obsolete("Use invertCulling property")]
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetRevertBackfacing(bool revertBackFaces);

		// Token: 0x060002D3 RID: 723 RVA: 0x0000FB90 File Offset: 0x0000DD90
		[ExcludeFromDocs]
		public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor)
		{
			float num = 1f;
			GL.Clear(clearDepth, clearColor, backgroundColor, num);
		}

		/// <summary>
		///   <para>Clear the current render buffer.</para>
		/// </summary>
		/// <param name="clearDepth">Should the depth buffer be cleared?</param>
		/// <param name="clearColor">Should the color buffer be cleared?</param>
		/// <param name="backgroundColor">The color to clear with, used only if clearColor is true.</param>
		/// <param name="depth">The depth to clear Z buffer with, used only if clearDepth is true.</param>
		// Token: 0x060002D4 RID: 724 RVA: 0x0000281D File Offset: 0x00000A1D
		public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor, [DefaultValue("1.0f")] float depth)
		{
			GL.Internal_Clear(clearDepth, clearColor, backgroundColor, depth);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00002828 File Offset: 0x00000A28
		private static void Internal_Clear(bool clearDepth, bool clearColor, Color backgroundColor, float depth)
		{
			GL.INTERNAL_CALL_Internal_Clear(clearDepth, clearColor, ref backgroundColor, depth);
		}

		// Token: 0x060002D6 RID: 726
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_Clear(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth);

		/// <summary>
		///   <para>Clear the current render buffer with camera's skybox.</para>
		/// </summary>
		/// <param name="clearDepth">Should the depth buffer be cleared?</param>
		/// <param name="camera">Camera to get projection parameters and skybox from.</param>
		// Token: 0x060002D7 RID: 727
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearWithSkybox(bool clearDepth, Camera camera);

		/// <summary>
		///   <para>Invalidate the internally cached renderstates.</para>
		/// </summary>
		// Token: 0x060002D8 RID: 728
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void InvalidateState();

		/// <summary>
		///   <para>Send a user-defined event to a native code plugin.</para>
		/// </summary>
		/// <param name="eventID">User defined id to send to the callback.</param>
		/// <param name="callback">Native code callback to queue for Unity's renderer to invoke.</param>
		// Token: 0x060002D9 RID: 729
		[WrapperlessIcall]
		[Obsolete("IssuePluginEvent(eventID) is deprecated. Use IssuePluginEvent(callback, eventID) instead.")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void IssuePluginEvent(int eventID);

		/// <summary>
		///   <para>Send a user-defined event to a native code plugin.</para>
		/// </summary>
		/// <param name="eventID">User defined id to send to the callback.</param>
		/// <param name="callback">Native code callback to queue for Unity's renderer to invoke.</param>
		// Token: 0x060002DA RID: 730 RVA: 0x00002834 File Offset: 0x00000A34
		public static void IssuePluginEvent(IntPtr callback, int eventID)
		{
			if (callback == IntPtr.Zero)
			{
				throw new ArgumentException("Null callback specified.");
			}
			GL.IssuePluginEventInternal(callback, eventID);
		}

		// Token: 0x060002DB RID: 731
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void IssuePluginEventInternal(IntPtr callback, int eventID);

		/// <summary>
		///   <para>Resolves the render target for subsequent operations sampling from it.</para>
		/// </summary>
		// Token: 0x060002DC RID: 732
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RenderTargetBarrier();

		/// <summary>
		///   <para>Mode for Begin: draw triangles.</para>
		/// </summary>
		// Token: 0x040000A4 RID: 164
		public const int TRIANGLES = 4;

		/// <summary>
		///   <para>Mode for Begin: draw triangle strip.</para>
		/// </summary>
		// Token: 0x040000A5 RID: 165
		public const int TRIANGLE_STRIP = 5;

		/// <summary>
		///   <para>Mode for Begin: draw quads.</para>
		/// </summary>
		// Token: 0x040000A6 RID: 166
		public const int QUADS = 7;

		/// <summary>
		///   <para>Mode for Begin: draw lines.</para>
		/// </summary>
		// Token: 0x040000A7 RID: 167
		public const int LINES = 1;
	}
}
