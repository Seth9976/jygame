using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>LODGroup lets you group multiple Renderers into LOD levels.</para>
	/// </summary>
	// Token: 0x02000047 RID: 71
	public sealed class LODGroup : Component
	{
		/// <summary>
		///   <para>The local reference point against which the LOD distance is calculated.</para>
		/// </summary>
		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x00010074 File Offset: 0x0000E274
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x00002AD2 File Offset: 0x00000CD2
		public Vector3 localReferencePoint
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_localReferencePoint(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_localReferencePoint(ref value);
			}
		}

		// Token: 0x060003E9 RID: 1001
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_localReferencePoint(out Vector3 value);

		// Token: 0x060003EA RID: 1002
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_localReferencePoint(ref Vector3 value);

		/// <summary>
		///   <para>The size of the LOD object in local space.</para>
		/// </summary>
		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060003EB RID: 1003
		// (set) Token: 0x060003EC RID: 1004
		public extern float size
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The number of LOD levels.</para>
		/// </summary>
		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060003ED RID: 1005
		public extern int lodCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The LOD fade mode used.</para>
		/// </summary>
		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060003EE RID: 1006
		// (set) Token: 0x060003EF RID: 1007
		public extern LODFadeMode fadeMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Specify if the cross-fading should be animated by time. The animation duration is specified globally as crossFadeAnimationDuration.</para>
		/// </summary>
		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060003F0 RID: 1008
		// (set) Token: 0x060003F1 RID: 1009
		public extern bool animateCrossFading
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Enable / Disable the LODGroup - Disabling will turn off all renderers.</para>
		/// </summary>
		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060003F2 RID: 1010
		// (set) Token: 0x060003F3 RID: 1011
		public extern bool enabled
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Recalculate the bounding region for the LODGroup (Relatively slow, do not call often).</para>
		/// </summary>
		// Token: 0x060003F4 RID: 1012
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RecalculateBounds();

		/// <summary>
		///   <para>Returns the array of LODs.</para>
		/// </summary>
		/// <returns>
		///   <para>The LOD array.</para>
		/// </returns>
		// Token: 0x060003F5 RID: 1013
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern LOD[] GetLODs();

		// Token: 0x060003F6 RID: 1014 RVA: 0x00002ADC File Offset: 0x00000CDC
		[Obsolete("Use SetLODs instead.")]
		public void SetLODS(LOD[] lods)
		{
			this.SetLODs(lods);
		}

		/// <summary>
		///   <para>Set the LODs for the LOD group. This will remove any existing LODs configured on the LODGroup.</para>
		/// </summary>
		/// <param name="lods">The LODs to use for this group.</param>
		// Token: 0x060003F7 RID: 1015
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetLODs(LOD[] lods);

		/// <summary>
		///   <para></para>
		/// </summary>
		/// <param name="index">The LOD level to use. Passing index &lt; 0 will return to standard LOD processing.</param>
		// Token: 0x060003F8 RID: 1016
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void ForceLOD(int index);

		/// <summary>
		///   <para>The cross-fading animation duration in seconds. ArgumentException will be thrown if it is set to zero or a negative value.</para>
		/// </summary>
		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060003F9 RID: 1017
		// (set) Token: 0x060003FA RID: 1018
		public static extern float crossFadeAnimationDuration
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
