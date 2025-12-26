using System;

namespace UnityEngine.Networking
{
	// Token: 0x02000014 RID: 20
	public class LogFilter
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00004808 File Offset: 0x00002A08
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00004810 File Offset: 0x00002A10
		public static int currentLogLevel
		{
			get
			{
				return LogFilter.s_CurrentLogLevel;
			}
			set
			{
				LogFilter.s_CurrentLogLevel = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00004818 File Offset: 0x00002A18
		internal static bool logDev
		{
			get
			{
				return LogFilter.s_CurrentLogLevel <= 0;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00004828 File Offset: 0x00002A28
		public static bool logDebug
		{
			get
			{
				return LogFilter.s_CurrentLogLevel <= 1;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00004838 File Offset: 0x00002A38
		public static bool logInfo
		{
			get
			{
				return LogFilter.s_CurrentLogLevel <= 2;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00004848 File Offset: 0x00002A48
		public static bool logWarn
		{
			get
			{
				return LogFilter.s_CurrentLogLevel <= 3;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00004858 File Offset: 0x00002A58
		public static bool logError
		{
			get
			{
				return LogFilter.s_CurrentLogLevel <= 4;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00004868 File Offset: 0x00002A68
		public static bool logFatal
		{
			get
			{
				return LogFilter.s_CurrentLogLevel <= 5;
			}
		}

		// Token: 0x0400003F RID: 63
		internal const int Developer = 0;

		// Token: 0x04000040 RID: 64
		public const int Debug = 1;

		// Token: 0x04000041 RID: 65
		public const int Info = 2;

		// Token: 0x04000042 RID: 66
		public const int Warn = 3;

		// Token: 0x04000043 RID: 67
		public const int Error = 4;

		// Token: 0x04000044 RID: 68
		public const int Fatal = 5;

		// Token: 0x04000045 RID: 69
		public static LogFilter.FilterLevel current = LogFilter.FilterLevel.Info;

		// Token: 0x04000046 RID: 70
		private static int s_CurrentLogLevel = 2;

		// Token: 0x02000015 RID: 21
		public enum FilterLevel
		{
			// Token: 0x04000048 RID: 72
			Developer,
			// Token: 0x04000049 RID: 73
			Debug,
			// Token: 0x0400004A RID: 74
			Info,
			// Token: 0x0400004B RID: 75
			Warn,
			// Token: 0x0400004C RID: 76
			Error,
			// Token: 0x0400004D RID: 77
			Fatal
		}
	}
}
