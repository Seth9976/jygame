using System;

namespace System.Diagnostics
{
	// Token: 0x0200026A RID: 618
	internal class TraceSourceInfo
	{
		// Token: 0x060015D9 RID: 5593 RVA: 0x00010C95 File Offset: 0x0000EE95
		public TraceSourceInfo(string name, SourceLevels levels)
		{
			this.name = name;
			this.levels = levels;
			this.listeners = new TraceListenerCollection();
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x00010CB6 File Offset: 0x0000EEB6
		internal TraceSourceInfo(string name, SourceLevels levels, TraceImplSettings settings)
		{
			this.name = name;
			this.levels = levels;
			this.listeners = new TraceListenerCollection(false);
			this.listeners.Add(new DefaultTraceListener(), settings);
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x060015DB RID: 5595 RVA: 0x00010CE9 File Offset: 0x0000EEE9
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x060015DC RID: 5596 RVA: 0x00010CF1 File Offset: 0x0000EEF1
		public SourceLevels Levels
		{
			get
			{
				return this.levels;
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060015DD RID: 5597 RVA: 0x00010CF9 File Offset: 0x0000EEF9
		public TraceListenerCollection Listeners
		{
			get
			{
				return this.listeners;
			}
		}

		// Token: 0x040006C5 RID: 1733
		private string name;

		// Token: 0x040006C6 RID: 1734
		private SourceLevels levels;

		// Token: 0x040006C7 RID: 1735
		private TraceListenerCollection listeners;
	}
}
