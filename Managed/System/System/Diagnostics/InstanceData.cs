using System;

namespace System.Diagnostics
{
	/// <summary>Holds instance data associated with a performance counter sample.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x02000236 RID: 566
	public class InstanceData
	{
		/// <summary>Initializes a new instance of the InstanceData class, using the specified sample and performance counter instance.</summary>
		/// <param name="instanceName">The name of an instance associated with the performance counter. </param>
		/// <param name="sample">A <see cref="T:System.Diagnostics.CounterSample" /> taken from the instance specified by the <paramref name="instanceName" /> parameter. </param>
		// Token: 0x0600134D RID: 4941 RVA: 0x0000F534 File Offset: 0x0000D734
		public InstanceData(string instanceName, CounterSample sample)
		{
			this.instanceName = instanceName;
			this.sample = sample;
		}

		/// <summary>Gets the instance name associated with this instance data.</summary>
		/// <returns>The name of an instance associated with the performance counter.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x0600134E RID: 4942 RVA: 0x0000F54A File Offset: 0x0000D74A
		public string InstanceName
		{
			get
			{
				return this.instanceName;
			}
		}

		/// <summary>Gets the raw data value associated with the performance counter sample.</summary>
		/// <returns>The raw value read by the performance counter sample associated with the <see cref="P:System.Diagnostics.InstanceData.Sample" /> property.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x0600134F RID: 4943 RVA: 0x0000F552 File Offset: 0x0000D752
		public long RawValue
		{
			get
			{
				return this.sample.RawValue;
			}
		}

		/// <summary>Gets the performance counter sample that generated this data.</summary>
		/// <returns>A <see cref="T:System.Diagnostics.CounterSample" /> taken from the instance specified by the <see cref="P:System.Diagnostics.InstanceData.InstanceName" /> property.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06001350 RID: 4944 RVA: 0x0000F55F File Offset: 0x0000D75F
		public CounterSample Sample
		{
			get
			{
				return this.sample;
			}
		}

		// Token: 0x0400059C RID: 1436
		private string instanceName;

		// Token: 0x0400059D RID: 1437
		private CounterSample sample;
	}
}
