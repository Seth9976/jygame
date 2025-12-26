using System;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

namespace UnityEngine
{
	/// <summary>
	///   <para>Stores light probes for the scene.</para>
	/// </summary>
	// Token: 0x02000031 RID: 49
	public sealed class LightProbes : Object
	{
		// Token: 0x06000273 RID: 627 RVA: 0x00002748 File Offset: 0x00000948
		public static void GetInterpolatedProbe(Vector3 position, Renderer renderer, out SphericalHarmonicsL2 probe)
		{
			LightProbes.INTERNAL_CALL_GetInterpolatedProbe(ref position, renderer, out probe);
		}

		// Token: 0x06000274 RID: 628
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetInterpolatedProbe(ref Vector3 position, Renderer renderer, out SphericalHarmonicsL2 probe);

		/// <summary>
		///   <para>Positions of the baked light probes (Read Only).</para>
		/// </summary>
		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000275 RID: 629
		public extern Vector3[] positions
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Coefficients of baked light probes.</para>
		/// </summary>
		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000276 RID: 630
		// (set) Token: 0x06000277 RID: 631
		public extern SphericalHarmonicsL2[] bakedProbes
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The number of light probes (Read Only).</para>
		/// </summary>
		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000278 RID: 632
		public extern int count
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The number of cells space is divided into (Read Only).</para>
		/// </summary>
		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000279 RID: 633
		public extern int cellCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00002753 File Offset: 0x00000953
		[Obsolete("GetInterpolatedLightProbe has been deprecated. Please use the static GetInterpolatedProbe instead.", true)]
		public void GetInterpolatedLightProbe(Vector3 position, Renderer renderer, float[] coefficients)
		{
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600027B RID: 635 RVA: 0x00002755 File Offset: 0x00000955
		// (set) Token: 0x0600027C RID: 636 RVA: 0x00002753 File Offset: 0x00000953
		[Obsolete("coefficients property has been deprecated. Please use bakedProbes instead.", true)]
		public float[] coefficients
		{
			get
			{
				return new float[0];
			}
			set
			{
			}
		}
	}
}
