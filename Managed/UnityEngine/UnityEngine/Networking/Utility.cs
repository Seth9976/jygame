using System;
using System.Collections.Generic;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking
{
	// Token: 0x02000216 RID: 534
	public class Utility
	{
		// Token: 0x06001E9E RID: 7838 RVA: 0x000021D6 File Offset: 0x000003D6
		private Utility()
		{
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06001EA0 RID: 7840 RVA: 0x0000C1F1 File Offset: 0x0000A3F1
		// (set) Token: 0x06001EA1 RID: 7841 RVA: 0x0000C1F8 File Offset: 0x0000A3F8
		public static bool useRandomSourceID
		{
			get
			{
				return Utility.s_useRandomSourceID;
			}
			set
			{
				Utility.SetUseRandomSourceID(value);
			}
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x0000C200 File Offset: 0x0000A400
		public static SourceID GetSourceID()
		{
			return (SourceID)((long)(SystemInfo.deviceUniqueIdentifier + Utility.s_randomSourceComponent).GetHashCode());
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x00025294 File Offset: 0x00023494
		private static void SetUseRandomSourceID(bool useRandomSourceID)
		{
			if (useRandomSourceID && !Utility.s_useRandomSourceID)
			{
				Utility.s_randomSourceComponent = Utility.s_randomGenerator.Next(int.MaxValue);
			}
			else if (!useRandomSourceID && Utility.s_useRandomSourceID)
			{
				Utility.s_randomSourceComponent = 0;
			}
			Utility.s_useRandomSourceID = useRandomSourceID;
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x0000C21C File Offset: 0x0000A41C
		public static void SetAppID(AppID newAppID)
		{
			Utility.s_programAppID = newAppID;
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x0000C224 File Offset: 0x0000A424
		public static AppID GetAppID()
		{
			return Utility.s_programAppID;
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x0000C22B File Offset: 0x0000A42B
		public static void SetAccessTokenForNetwork(NetworkID netId, NetworkAccessToken accessToken)
		{
			Utility.s_dictTokens.Add(netId, accessToken);
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x000252E8 File Offset: 0x000234E8
		public static NetworkAccessToken GetAccessTokenForNetwork(NetworkID netId)
		{
			NetworkAccessToken networkAccessToken;
			if (!Utility.s_dictTokens.TryGetValue(netId, out networkAccessToken))
			{
				networkAccessToken = new NetworkAccessToken();
			}
			return networkAccessToken;
		}

		// Token: 0x04000841 RID: 2113
		private static Random s_randomGenerator = new Random(Environment.TickCount);

		// Token: 0x04000842 RID: 2114
		private static bool s_useRandomSourceID = false;

		// Token: 0x04000843 RID: 2115
		private static int s_randomSourceComponent = 0;

		// Token: 0x04000844 RID: 2116
		private static AppID s_programAppID = AppID.Invalid;

		// Token: 0x04000845 RID: 2117
		private static Dictionary<NetworkID, NetworkAccessToken> s_dictTokens = new Dictionary<NetworkID, NetworkAccessToken>();
	}
}
