using System;

namespace System.Timers
{
	/// <summary>Provides data for the <see cref="E:System.Timers.Timer.Elapsed" /> event.</summary>
	// Token: 0x020004CB RID: 1227
	public class ElapsedEventArgs : EventArgs
	{
		// Token: 0x06002B77 RID: 11127 RVA: 0x0001E379 File Offset: 0x0001C579
		internal ElapsedEventArgs(DateTime time)
		{
			this.time = time;
		}

		/// <summary>Gets the time the <see cref="E:System.Timers.Timer.Elapsed" /> event was raised.</summary>
		/// <returns>The time the <see cref="E:System.Timers.Timer.Elapsed" /> event was raised.</returns>
		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x06002B78 RID: 11128 RVA: 0x0001E388 File Offset: 0x0001C588
		public DateTime SignalTime
		{
			get
			{
				return this.time;
			}
		}

		// Token: 0x04001B41 RID: 6977
		private DateTime time;
	}
}
