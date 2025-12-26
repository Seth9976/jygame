using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Link allowing movement outside the planar navigation mesh.</para>
	/// </summary>
	// Token: 0x0200014B RID: 331
	public sealed class OffMeshLink : Component
	{
		/// <summary>
		///   <para>Is link active.</para>
		/// </summary>
		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x060013F6 RID: 5110
		// (set) Token: 0x060013F7 RID: 5111
		public extern bool activated
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Is link occupied. (Read Only)</para>
		/// </summary>
		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x060013F8 RID: 5112
		public extern bool occupied
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Modify pathfinding cost for the link.</para>
		/// </summary>
		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x060013F9 RID: 5113
		// (set) Token: 0x060013FA RID: 5114
		public extern float costOverride
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Can link be traversed in both directions.</para>
		/// </summary>
		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x060013FB RID: 5115
		// (set) Token: 0x060013FC RID: 5116
		public extern bool biDirectional
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Explicitly update the link endpoints.</para>
		/// </summary>
		// Token: 0x060013FD RID: 5117
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void UpdatePositions();

		/// <summary>
		///   <para>NavMeshLayer for this OffMeshLink component.</para>
		/// </summary>
		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x060013FE RID: 5118
		// (set) Token: 0x060013FF RID: 5119
		[Obsolete("Use area instead.")]
		public extern int navMeshLayer
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>NavMesh area index for this OffMeshLink component.</para>
		/// </summary>
		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06001400 RID: 5120
		// (set) Token: 0x06001401 RID: 5121
		public extern int area
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Automatically update endpoints.</para>
		/// </summary>
		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06001402 RID: 5122
		// (set) Token: 0x06001403 RID: 5123
		public extern bool autoUpdatePositions
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The transform representing link start position.</para>
		/// </summary>
		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001404 RID: 5124
		// (set) Token: 0x06001405 RID: 5125
		public extern Transform startTransform
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The transform representing link end position.</para>
		/// </summary>
		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001406 RID: 5126
		// (set) Token: 0x06001407 RID: 5127
		public extern Transform endTransform
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
