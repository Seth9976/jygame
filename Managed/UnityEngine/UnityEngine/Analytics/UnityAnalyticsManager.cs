using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Analytics
{
	// Token: 0x02000229 RID: 553
	internal class UnityAnalyticsManager
	{
		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06001F8F RID: 8079
		// (set) Token: 0x06001F90 RID: 8080
		public static extern bool enabled
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06001F91 RID: 8081
		// (set) Token: 0x06001F92 RID: 8082
		public static extern bool initializeOnStartup
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06001F93 RID: 8083
		// (set) Token: 0x06001F94 RID: 8084
		public static extern bool testMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06001F95 RID: 8085
		// (set) Token: 0x06001F96 RID: 8086
		public static extern string testEventUrl
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06001F97 RID: 8087
		// (set) Token: 0x06001F98 RID: 8088
		public static extern string testConfigUrl
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06001F99 RID: 8089
		public static extern string unityAdsId
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06001F9A RID: 8090
		public static extern bool unityAdsTrackingEnabled
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06001F9B RID: 8091
		public static extern string deviceUniqueIdentifier
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}
	}
}
