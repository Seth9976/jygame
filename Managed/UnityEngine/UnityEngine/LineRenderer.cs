using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>The line renderer is used to draw free-floating lines in 3D space.</para>
	/// </summary>
	// Token: 0x02000028 RID: 40
	public sealed class LineRenderer : Renderer
	{
		/// <summary>
		///   <para>Set the line width at the start and at the end.</para>
		/// </summary>
		/// <param name="start"></param>
		/// <param name="end"></param>
		// Token: 0x060001E7 RID: 487 RVA: 0x00002469 File Offset: 0x00000669
		public void SetWidth(float start, float end)
		{
			LineRenderer.INTERNAL_CALL_SetWidth(this, start, end);
		}

		// Token: 0x060001E8 RID: 488
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetWidth(LineRenderer self, float start, float end);

		/// <summary>
		///   <para>Set the line color at the start and at the end.</para>
		/// </summary>
		/// <param name="start"></param>
		/// <param name="end"></param>
		// Token: 0x060001E9 RID: 489 RVA: 0x00002473 File Offset: 0x00000673
		public void SetColors(Color start, Color end)
		{
			LineRenderer.INTERNAL_CALL_SetColors(this, ref start, ref end);
		}

		// Token: 0x060001EA RID: 490
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetColors(LineRenderer self, ref Color start, ref Color end);

		/// <summary>
		///   <para>Set the number of line segments.</para>
		/// </summary>
		/// <param name="count"></param>
		// Token: 0x060001EB RID: 491 RVA: 0x0000247F File Offset: 0x0000067F
		public void SetVertexCount(int count)
		{
			LineRenderer.INTERNAL_CALL_SetVertexCount(this, count);
		}

		// Token: 0x060001EC RID: 492
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetVertexCount(LineRenderer self, int count);

		/// <summary>
		///   <para>Set the position of the vertex in the line.</para>
		/// </summary>
		/// <param name="index"></param>
		/// <param name="position"></param>
		// Token: 0x060001ED RID: 493 RVA: 0x00002488 File Offset: 0x00000688
		public void SetPosition(int index, Vector3 position)
		{
			LineRenderer.INTERNAL_CALL_SetPosition(this, index, ref position);
		}

		// Token: 0x060001EE RID: 494
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetPosition(LineRenderer self, int index, ref Vector3 position);

		/// <summary>
		///   <para>If enabled, the lines are defined in world space.</para>
		/// </summary>
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001EF RID: 495
		// (set) Token: 0x060001F0 RID: 496
		public extern bool useWorldSpace
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}
	}
}
