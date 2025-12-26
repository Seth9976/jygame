using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Interface into the Gyroscope.</para>
	/// </summary>
	// Token: 0x020000BF RID: 191
	public sealed class Gyroscope
	{
		// Token: 0x06000AE2 RID: 2786 RVA: 0x00005DE1 File Offset: 0x00003FE1
		internal Gyroscope(int index)
		{
			this.m_GyroIndex = index;
		}

		// Token: 0x06000AE3 RID: 2787
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Vector3 rotationRate_Internal(int idx);

		// Token: 0x06000AE4 RID: 2788
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Vector3 rotationRateUnbiased_Internal(int idx);

		// Token: 0x06000AE5 RID: 2789
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Vector3 gravity_Internal(int idx);

		// Token: 0x06000AE6 RID: 2790
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Vector3 userAcceleration_Internal(int idx);

		// Token: 0x06000AE7 RID: 2791
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Quaternion attitude_Internal(int idx);

		// Token: 0x06000AE8 RID: 2792
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool getEnabled_Internal(int idx);

		// Token: 0x06000AE9 RID: 2793
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void setEnabled_Internal(int idx, bool enabled);

		// Token: 0x06000AEA RID: 2794
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float getUpdateInterval_Internal(int idx);

		// Token: 0x06000AEB RID: 2795
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void setUpdateInterval_Internal(int idx, float interval);

		/// <summary>
		///   <para>Returns rotation rate as measured by the device's gyroscope.</para>
		/// </summary>
		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x00005DF0 File Offset: 0x00003FF0
		public Vector3 rotationRate
		{
			get
			{
				return Gyroscope.rotationRate_Internal(this.m_GyroIndex);
			}
		}

		/// <summary>
		///   <para>Returns unbiased rotation rate as measured by the device's gyroscope.</para>
		/// </summary>
		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x00005DFD File Offset: 0x00003FFD
		public Vector3 rotationRateUnbiased
		{
			get
			{
				return Gyroscope.rotationRateUnbiased_Internal(this.m_GyroIndex);
			}
		}

		/// <summary>
		///   <para>Returns the gravity acceleration vector expressed in the device's reference frame.</para>
		/// </summary>
		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000AEE RID: 2798 RVA: 0x00005E0A File Offset: 0x0000400A
		public Vector3 gravity
		{
			get
			{
				return Gyroscope.gravity_Internal(this.m_GyroIndex);
			}
		}

		/// <summary>
		///   <para>Returns the acceleration that the user is giving to the device.</para>
		/// </summary>
		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x00005E17 File Offset: 0x00004017
		public Vector3 userAcceleration
		{
			get
			{
				return Gyroscope.userAcceleration_Internal(this.m_GyroIndex);
			}
		}

		/// <summary>
		///   <para>Returns the attitude (ie, orientation in space) of the device.</para>
		/// </summary>
		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x00005E24 File Offset: 0x00004024
		public Quaternion attitude
		{
			get
			{
				return Gyroscope.attitude_Internal(this.m_GyroIndex);
			}
		}

		/// <summary>
		///   <para>Sets or retrieves the enabled status of this gyroscope.</para>
		/// </summary>
		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x00005E31 File Offset: 0x00004031
		// (set) Token: 0x06000AF2 RID: 2802 RVA: 0x00005E3E File Offset: 0x0000403E
		public bool enabled
		{
			get
			{
				return Gyroscope.getEnabled_Internal(this.m_GyroIndex);
			}
			set
			{
				Gyroscope.setEnabled_Internal(this.m_GyroIndex, value);
			}
		}

		/// <summary>
		///   <para>Sets or retrieves gyroscope interval in seconds.</para>
		/// </summary>
		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x00005E4C File Offset: 0x0000404C
		// (set) Token: 0x06000AF4 RID: 2804 RVA: 0x00005E59 File Offset: 0x00004059
		public float updateInterval
		{
			get
			{
				return Gyroscope.getUpdateInterval_Internal(this.m_GyroIndex);
			}
			set
			{
				Gyroscope.setUpdateInterval_Internal(this.m_GyroIndex, value);
			}
		}

		// Token: 0x04000241 RID: 577
		private int m_GyroIndex;
	}
}
