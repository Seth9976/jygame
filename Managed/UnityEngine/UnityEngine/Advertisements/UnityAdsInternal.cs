using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Advertisements
{
	// Token: 0x020000DA RID: 218
	internal sealed class UnityAdsInternal
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000D1C RID: 3356 RVA: 0x000067F6 File Offset: 0x000049F6
		// (remove) Token: 0x06000D1D RID: 3357 RVA: 0x0000680D File Offset: 0x00004A0D
		public static event UnityAdsDelegate onCampaignsAvailable;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000D1E RID: 3358 RVA: 0x00006824 File Offset: 0x00004A24
		// (remove) Token: 0x06000D1F RID: 3359 RVA: 0x0000683B File Offset: 0x00004A3B
		public static event UnityAdsDelegate onCampaignsFetchFailed;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000D20 RID: 3360 RVA: 0x00006852 File Offset: 0x00004A52
		// (remove) Token: 0x06000D21 RID: 3361 RVA: 0x00006869 File Offset: 0x00004A69
		public static event UnityAdsDelegate onShow;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000D22 RID: 3362 RVA: 0x00006880 File Offset: 0x00004A80
		// (remove) Token: 0x06000D23 RID: 3363 RVA: 0x00006897 File Offset: 0x00004A97
		public static event UnityAdsDelegate onHide;

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000D24 RID: 3364 RVA: 0x000068AE File Offset: 0x00004AAE
		// (remove) Token: 0x06000D25 RID: 3365 RVA: 0x000068C5 File Offset: 0x00004AC5
		public static event UnityAdsDelegate<string, bool> onVideoCompleted;

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000D26 RID: 3366 RVA: 0x000068DC File Offset: 0x00004ADC
		// (remove) Token: 0x06000D27 RID: 3367 RVA: 0x000068F3 File Offset: 0x00004AF3
		public static event UnityAdsDelegate onVideoStarted;

		// Token: 0x06000D28 RID: 3368
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RegisterNative();

		// Token: 0x06000D29 RID: 3369
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Init(string gameId, bool testModeEnabled, bool debugModeEnabled, string unityVersion);

		// Token: 0x06000D2A RID: 3370
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Show(string zoneId, string rewardItemKey, string options);

		// Token: 0x06000D2B RID: 3371
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool CanShowAds(string zoneId);

		// Token: 0x06000D2C RID: 3372
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetLogLevel(int logLevel);

		// Token: 0x06000D2D RID: 3373
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetCampaignDataURL(string url);

		// Token: 0x06000D2E RID: 3374 RVA: 0x0000690A File Offset: 0x00004B0A
		public static void RemoveAllEventHandlers()
		{
			UnityAdsInternal.onCampaignsAvailable = null;
			UnityAdsInternal.onCampaignsFetchFailed = null;
			UnityAdsInternal.onShow = null;
			UnityAdsInternal.onHide = null;
			UnityAdsInternal.onVideoCompleted = null;
			UnityAdsInternal.onVideoStarted = null;
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x000179C0 File Offset: 0x00015BC0
		public static void CallUnityAdsCampaignsAvailable()
		{
			UnityAdsDelegate unityAdsDelegate = UnityAdsInternal.onCampaignsAvailable;
			if (unityAdsDelegate != null)
			{
				unityAdsDelegate();
			}
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x000179E0 File Offset: 0x00015BE0
		public static void CallUnityAdsCampaignsFetchFailed()
		{
			UnityAdsDelegate unityAdsDelegate = UnityAdsInternal.onCampaignsFetchFailed;
			if (unityAdsDelegate != null)
			{
				unityAdsDelegate();
			}
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x00017A00 File Offset: 0x00015C00
		public static void CallUnityAdsShow()
		{
			UnityAdsDelegate unityAdsDelegate = UnityAdsInternal.onShow;
			if (unityAdsDelegate != null)
			{
				unityAdsDelegate();
			}
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x00017A20 File Offset: 0x00015C20
		public static void CallUnityAdsHide()
		{
			UnityAdsDelegate unityAdsDelegate = UnityAdsInternal.onHide;
			if (unityAdsDelegate != null)
			{
				unityAdsDelegate();
			}
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x00017A40 File Offset: 0x00015C40
		public static void CallUnityAdsVideoCompleted(string rewardItemKey, bool skipped)
		{
			UnityAdsDelegate<string, bool> unityAdsDelegate = UnityAdsInternal.onVideoCompleted;
			if (unityAdsDelegate != null)
			{
				unityAdsDelegate(rewardItemKey, skipped);
			}
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x00017A64 File Offset: 0x00015C64
		public static void CallUnityAdsVideoStarted()
		{
			UnityAdsDelegate unityAdsDelegate = UnityAdsInternal.onVideoStarted;
			if (unityAdsDelegate != null)
			{
				unityAdsDelegate();
			}
		}
	}
}
