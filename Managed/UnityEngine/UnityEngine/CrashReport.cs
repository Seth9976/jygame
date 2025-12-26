using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Holds data for a single application crash event and provides access to all gathered crash reports.</para>
	/// </summary>
	// Token: 0x02000015 RID: 21
	public sealed class CrashReport
	{
		// Token: 0x0600007E RID: 126 RVA: 0x00002237 File Offset: 0x00000437
		private CrashReport(string id, DateTime time, string text)
		{
			this.id = id;
			this.time = time;
			this.text = text;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000ED68 File Offset: 0x0000CF68
		private static int Compare(CrashReport c1, CrashReport c2)
		{
			long ticks = c1.time.Ticks;
			long ticks2 = c2.time.Ticks;
			if (ticks > ticks2)
			{
				return 1;
			}
			if (ticks < ticks2)
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000EDA8 File Offset: 0x0000CFA8
		private static void PopulateReports()
		{
			object obj = CrashReport.reportsLock;
			lock (obj)
			{
				if (CrashReport.internalReports == null)
				{
					string[] reports = CrashReport.GetReports();
					CrashReport.internalReports = new List<CrashReport>(reports.Length);
					foreach (string text in reports)
					{
						double num;
						string text2;
						CrashReport.GetReportData(text, out num, out text2);
						DateTime dateTime = new DateTime(1970, 1, 1);
						DateTime dateTime2 = dateTime.AddSeconds(num);
						CrashReport.internalReports.Add(new CrashReport(text, dateTime2, text2));
					}
					CrashReport.internalReports.Sort(new Comparison<CrashReport>(CrashReport.Compare));
				}
			}
		}

		/// <summary>
		///   <para>Returns all currently available reports in a new array.</para>
		/// </summary>
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000082 RID: 130 RVA: 0x0000EE6C File Offset: 0x0000D06C
		public static CrashReport[] reports
		{
			get
			{
				CrashReport.PopulateReports();
				object obj = CrashReport.reportsLock;
				CrashReport[] array;
				lock (obj)
				{
					array = CrashReport.internalReports.ToArray();
				}
				return array;
			}
		}

		/// <summary>
		///   <para>Returns last crash report, or null if no reports are available.</para>
		/// </summary>
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000083 RID: 131 RVA: 0x0000EEB8 File Offset: 0x0000D0B8
		public static CrashReport lastReport
		{
			get
			{
				CrashReport.PopulateReports();
				object obj = CrashReport.reportsLock;
				lock (obj)
				{
					if (CrashReport.internalReports.Count > 0)
					{
						return CrashReport.internalReports[CrashReport.internalReports.Count - 1];
					}
				}
				return null;
			}
		}

		/// <summary>
		///   <para>Remove all reports from available reports list.</para>
		/// </summary>
		// Token: 0x06000084 RID: 132 RVA: 0x0000EF24 File Offset: 0x0000D124
		public static void RemoveAll()
		{
			foreach (CrashReport crashReport in CrashReport.reports)
			{
				crashReport.Remove();
			}
		}

		/// <summary>
		///   <para>Remove report from available reports list.</para>
		/// </summary>
		// Token: 0x06000085 RID: 133 RVA: 0x0000EF58 File Offset: 0x0000D158
		public void Remove()
		{
			if (CrashReport.RemoveReport(this.id))
			{
				object obj = CrashReport.reportsLock;
				lock (obj)
				{
					CrashReport.internalReports.Remove(this);
				}
			}
		}

		// Token: 0x06000086 RID: 134
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string[] GetReports();

		// Token: 0x06000087 RID: 135
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetReportData(string id, out double secondsSinceUnixEpoch, out string text);

		// Token: 0x06000088 RID: 136
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool RemoveReport(string id);

		// Token: 0x0400006E RID: 110
		private static List<CrashReport> internalReports;

		// Token: 0x0400006F RID: 111
		private static object reportsLock = new object();

		// Token: 0x04000070 RID: 112
		private readonly string id;

		/// <summary>
		///   <para>Time, when the crash occured.</para>
		/// </summary>
		// Token: 0x04000071 RID: 113
		public readonly DateTime time;

		/// <summary>
		///   <para>Crash report data as formatted text.</para>
		/// </summary>
		// Token: 0x04000072 RID: 114
		public readonly string text;
	}
}
