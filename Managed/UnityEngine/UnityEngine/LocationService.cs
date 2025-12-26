using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Interface into location functionality.</para>
	/// </summary>
	// Token: 0x020000C2 RID: 194
	public sealed class LocationService
	{
		/// <summary>
		///   <para>Specifies whether location service is enabled in user settings.</para>
		/// </summary>
		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000AFC RID: 2812
		public extern bool isEnabledByUser
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns location service status.</para>
		/// </summary>
		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000AFD RID: 2813
		public extern LocationServiceStatus status
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Last measured device geographical location.</para>
		/// </summary>
		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000AFE RID: 2814
		public extern LocationInfo lastData
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Starts location service updates.  Last location coordinates could be.</para>
		/// </summary>
		/// <param name="desiredAccuracyInMeters"></param>
		/// <param name="updateDistanceInMeters"></param>
		// Token: 0x06000AFF RID: 2815
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Start([DefaultValue("10f")] float desiredAccuracyInMeters, [DefaultValue("10f")] float updateDistanceInMeters);

		/// <summary>
		///   <para>Starts location service updates.  Last location coordinates could be.</para>
		/// </summary>
		/// <param name="desiredAccuracyInMeters"></param>
		/// <param name="updateDistanceInMeters"></param>
		// Token: 0x06000B00 RID: 2816 RVA: 0x00016F20 File Offset: 0x00015120
		[ExcludeFromDocs]
		public void Start(float desiredAccuracyInMeters)
		{
			float num = 10f;
			this.Start(desiredAccuracyInMeters, num);
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00016F3C File Offset: 0x0001513C
		[ExcludeFromDocs]
		public void Start()
		{
			float num = 10f;
			float num2 = 10f;
			this.Start(num2, num);
		}

		/// <summary>
		///   <para>Stops location service updates. This could be useful for saving battery life.</para>
		/// </summary>
		// Token: 0x06000B02 RID: 2818
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Stop();
	}
}
