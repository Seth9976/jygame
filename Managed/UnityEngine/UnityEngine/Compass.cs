using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Interface into compass functionality.</para>
	/// </summary>
	// Token: 0x020000C3 RID: 195
	public sealed class Compass
	{
		/// <summary>
		///   <para>The heading in degrees relative to the magnetic North Pole. (Read Only)</para>
		/// </summary>
		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000B04 RID: 2820
		public extern float magneticHeading
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The heading in degrees relative to the geographic North Pole. (Read Only)</para>
		/// </summary>
		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000B05 RID: 2821
		public extern float trueHeading
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Accuracy of heading reading in degrees.</para>
		/// </summary>
		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000B06 RID: 2822
		public extern float headingAccuracy
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The raw geomagnetic data measured in microteslas. (Read Only)</para>
		/// </summary>
		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x00016F60 File Offset: 0x00015160
		public Vector3 rawVector
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_rawVector(out vector);
				return vector;
			}
		}

		// Token: 0x06000B08 RID: 2824
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_rawVector(out Vector3 value);

		/// <summary>
		///   <para>Timestamp (in seconds since 1970) when the heading was last time updated. (Read Only)</para>
		/// </summary>
		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000B09 RID: 2825
		public extern double timestamp
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Used to enable or disable compass. Note, that if you want Input.compass.trueHeading property to contain a valid value, you must also enable location updates by calling Input.location.Start().</para>
		/// </summary>
		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000B0A RID: 2826
		// (set) Token: 0x06000B0B RID: 2827
		public extern bool enabled
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
