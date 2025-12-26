using System;

namespace UnityEngine.Networking
{
	// Token: 0x0200005D RID: 93
	public class MsgType
	{
		// Token: 0x06000492 RID: 1170 RVA: 0x000178EC File Offset: 0x00015AEC
		public static string MsgTypeToString(short value)
		{
			if (value < 0 || value > 46)
			{
				return string.Empty;
			}
			string text = MsgType.msgLabels[(int)value];
			if (string.IsNullOrEmpty(text))
			{
				text = "[" + value + "]";
			}
			return text;
		}

		// Token: 0x040001E3 RID: 483
		public const short ObjectDestroy = 1;

		// Token: 0x040001E4 RID: 484
		public const short Rpc = 2;

		// Token: 0x040001E5 RID: 485
		public const short ObjectSpawn = 3;

		// Token: 0x040001E6 RID: 486
		public const short Owner = 4;

		// Token: 0x040001E7 RID: 487
		public const short Command = 5;

		// Token: 0x040001E8 RID: 488
		public const short LocalPlayerTransform = 6;

		// Token: 0x040001E9 RID: 489
		public const short SyncEvent = 7;

		// Token: 0x040001EA RID: 490
		public const short UpdateVars = 8;

		// Token: 0x040001EB RID: 491
		public const short SyncList = 9;

		// Token: 0x040001EC RID: 492
		public const short ObjectSpawnScene = 10;

		// Token: 0x040001ED RID: 493
		public const short NetworkInfo = 11;

		// Token: 0x040001EE RID: 494
		public const short SpawnFinished = 12;

		// Token: 0x040001EF RID: 495
		public const short ObjectHide = 13;

		// Token: 0x040001F0 RID: 496
		public const short CRC = 14;

		// Token: 0x040001F1 RID: 497
		public const short LocalClientAuthority = 15;

		// Token: 0x040001F2 RID: 498
		public const short LocalChildTransform = 16;

		// Token: 0x040001F3 RID: 499
		internal const short UserMessage = 0;

		// Token: 0x040001F4 RID: 500
		internal const short HLAPIMsg = 28;

		// Token: 0x040001F5 RID: 501
		internal const short LLAPIMsg = 29;

		// Token: 0x040001F6 RID: 502
		internal const short HLAPIResend = 30;

		// Token: 0x040001F7 RID: 503
		internal const short HLAPIPending = 31;

		// Token: 0x040001F8 RID: 504
		public const short InternalHighest = 31;

		// Token: 0x040001F9 RID: 505
		public const short Connect = 32;

		// Token: 0x040001FA RID: 506
		public const short Disconnect = 33;

		// Token: 0x040001FB RID: 507
		public const short Error = 34;

		// Token: 0x040001FC RID: 508
		public const short Ready = 35;

		// Token: 0x040001FD RID: 509
		public const short NotReady = 36;

		// Token: 0x040001FE RID: 510
		public const short AddPlayer = 37;

		// Token: 0x040001FF RID: 511
		public const short RemovePlayer = 38;

		// Token: 0x04000200 RID: 512
		public const short Scene = 39;

		// Token: 0x04000201 RID: 513
		public const short Animation = 40;

		// Token: 0x04000202 RID: 514
		public const short AnimationParameters = 41;

		// Token: 0x04000203 RID: 515
		public const short AnimationTrigger = 42;

		// Token: 0x04000204 RID: 516
		public const short LobbyReadyToBegin = 43;

		// Token: 0x04000205 RID: 517
		public const short LobbySceneLoaded = 44;

		// Token: 0x04000206 RID: 518
		public const short LobbyAddPlayerFailed = 45;

		// Token: 0x04000207 RID: 519
		public const short LobbyReturnToLobby = 46;

		// Token: 0x04000208 RID: 520
		public const short Highest = 46;

		// Token: 0x04000209 RID: 521
		internal static string[] msgLabels = new string[]
		{
			"none",
			"ObjectDestroy",
			"Rpc",
			"ObjectSpawn",
			"Owner",
			"Command",
			"LocalPlayerTransform",
			"SyncEvent",
			"UpdateVars",
			"SyncList",
			"ObjectSpawnScene",
			"NetworkInfo",
			"SpawnFinished",
			"ObjectHide",
			"CRC",
			"LocalClientAuthority",
			"LocalChildTransform",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Connect",
			"Disconnect",
			"Error",
			"Ready",
			"NotReady",
			"AddPlayer",
			"RemovePlayer",
			"Scene",
			"Animation",
			"AnimationParams",
			"AnimationTrigger",
			"LobbyReadyToBegin",
			"LobbySceneLoaded",
			"LobbyAddPlayerFailed",
			"LobbyReturnToLobby"
		};
	}
}
