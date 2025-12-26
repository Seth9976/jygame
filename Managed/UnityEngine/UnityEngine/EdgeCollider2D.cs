using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Collider for 2D physics representing an arbitrary set of connected edges (lines) defined by its vertices.</para>
	/// </summary>
	// Token: 0x02000126 RID: 294
	public sealed class EdgeCollider2D : Collider2D
	{
		/// <summary>
		///   <para>Reset to a single edge consisting of two points.</para>
		/// </summary>
		// Token: 0x06001265 RID: 4709
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Reset();

		/// <summary>
		///   <para>Gets the number of edges.</para>
		/// </summary>
		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06001266 RID: 4710
		public extern int edgeCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Gets the number of points.</para>
		/// </summary>
		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06001267 RID: 4711
		public extern int pointCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Get or set the points defining multiple continuous edges.</para>
		/// </summary>
		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06001268 RID: 4712
		// (set) Token: 0x06001269 RID: 4713
		public extern Vector2[] points
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
