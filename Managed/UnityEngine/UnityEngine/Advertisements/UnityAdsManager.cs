using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Advertisements
{
	// Token: 0x02000228 RID: 552
	internal class UnityAdsManager
	{
		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06001F84 RID: 8068
		// (set) Token: 0x06001F85 RID: 8069
		public static extern bool enabled
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06001F86 RID: 8070
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsPlatformEnabled(RuntimePlatform platform);

		// Token: 0x06001F87 RID: 8071
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetPlatformEnabled(RuntimePlatform platform, bool value);

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06001F88 RID: 8072
		// (set) Token: 0x06001F89 RID: 8073
		public static extern bool initializeOnStartup
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06001F8A RID: 8074
		// (set) Token: 0x06001F8B RID: 8075
		public static extern bool testMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06001F8C RID: 8076
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string GetGameId(RuntimePlatform platform);

		// Token: 0x06001F8D RID: 8077
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetGameId(RuntimePlatform platform, string gameId);
	}
}
