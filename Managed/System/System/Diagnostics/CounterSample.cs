using System;

namespace System.Diagnostics
{
	/// <summary>Defines a structure that holds the raw data for a performance counter.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x02000218 RID: 536
	public struct CounterSample
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.CounterSample" /> structure and sets the <see cref="P:System.Diagnostics.CounterSample.CounterTimeStamp" /> property to 0 (zero).</summary>
		/// <param name="rawValue">The numeric value associated with the performance counter sample. </param>
		/// <param name="baseValue">An optional, base raw value for the counter, to use only if the sample is based on multiple counters. </param>
		/// <param name="counterFrequency">The frequency with which the counter is read. </param>
		/// <param name="systemFrequency">The frequency with which the system reads from the counter. </param>
		/// <param name="timeStamp">The raw time stamp. </param>
		/// <param name="timeStamp100nSec">The raw, high-fidelity time stamp. </param>
		/// <param name="counterType">A <see cref="T:System.Diagnostics.PerformanceCounterType" /> object that indicates the type of the counter for which this sample is a snapshot. </param>
		// Token: 0x060011D2 RID: 4562 RVA: 0x0003C680 File Offset: 0x0003A880
		public CounterSample(long rawValue, long baseValue, long counterFrequency, long systemFrequency, long timeStamp, long timeStamp100nSec, PerformanceCounterType counterType)
		{
			this = new CounterSample(rawValue, baseValue, counterFrequency, systemFrequency, timeStamp, timeStamp100nSec, counterType, 0L);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.CounterSample" /> structure and sets the <see cref="P:System.Diagnostics.CounterSample.CounterTimeStamp" /> property to the value that is passed in.</summary>
		/// <param name="rawValue">The numeric value associated with the performance counter sample. </param>
		/// <param name="baseValue">An optional, base raw value for the counter, to use only if the sample is based on multiple counters. </param>
		/// <param name="counterFrequency">The frequency with which the counter is read. </param>
		/// <param name="systemFrequency">The frequency with which the system reads from the counter. </param>
		/// <param name="timeStamp">The raw time stamp. </param>
		/// <param name="timeStamp100nSec">The raw, high-fidelity time stamp. </param>
		/// <param name="counterType">A <see cref="T:System.Diagnostics.PerformanceCounterType" /> object that indicates the type of the counter for which this sample is a snapshot. </param>
		/// <param name="counterTimeStamp">The time at which the sample was taken. </param>
		// Token: 0x060011D3 RID: 4563 RVA: 0x0000E5F3 File Offset: 0x0000C7F3
		public CounterSample(long rawValue, long baseValue, long counterFrequency, long systemFrequency, long timeStamp, long timeStamp100nSec, PerformanceCounterType counterType, long counterTimeStamp)
		{
			this.rawValue = rawValue;
			this.baseValue = baseValue;
			this.counterFrequency = counterFrequency;
			this.systemFrequency = systemFrequency;
			this.timeStamp = timeStamp;
			this.timeStamp100nSec = timeStamp100nSec;
			this.counterType = counterType;
			this.counterTimeStamp = counterTimeStamp;
		}

		/// <summary>Gets an optional, base raw value for the counter.</summary>
		/// <returns>The base raw value, which is used only if the sample is based on multiple counters.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x060011D5 RID: 4565 RVA: 0x0000E651 File Offset: 0x0000C851
		public long BaseValue
		{
			get
			{
				return this.baseValue;
			}
		}

		/// <summary>Gets the raw counter frequency.</summary>
		/// <returns>The frequency with which the counter is read.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x0000E659 File Offset: 0x0000C859
		public long CounterFrequency
		{
			get
			{
				return this.counterFrequency;
			}
		}

		/// <summary>Gets the counter's time stamp.</summary>
		/// <returns>The time at which the sample was taken.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x060011D7 RID: 4567 RVA: 0x0000E661 File Offset: 0x0000C861
		public long CounterTimeStamp
		{
			get
			{
				return this.counterTimeStamp;
			}
		}

		/// <summary>Gets the performance counter type.</summary>
		/// <returns>A <see cref="T:System.Diagnostics.PerformanceCounterType" /> object that indicates the type of the counter for which this sample is a snapshot.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x060011D8 RID: 4568 RVA: 0x0000E669 File Offset: 0x0000C869
		public PerformanceCounterType CounterType
		{
			get
			{
				return this.counterType;
			}
		}

		/// <summary>Gets the raw value of the counter.</summary>
		/// <returns>The numeric value that is associated with the performance counter sample.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x060011D9 RID: 4569 RVA: 0x0000E671 File Offset: 0x0000C871
		public long RawValue
		{
			get
			{
				return this.rawValue;
			}
		}

		/// <summary>Gets the raw system frequency.</summary>
		/// <returns>The frequency with which the system reads from the counter.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x060011DA RID: 4570 RVA: 0x0000E679 File Offset: 0x0000C879
		public long SystemFrequency
		{
			get
			{
				return this.systemFrequency;
			}
		}

		/// <summary>Gets the raw time stamp.</summary>
		/// <returns>The system time stamp.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x060011DB RID: 4571 RVA: 0x0000E681 File Offset: 0x0000C881
		public long TimeStamp
		{
			get
			{
				return this.timeStamp;
			}
		}

		/// <summary>Gets the raw, high-fidelity time stamp.</summary>
		/// <returns>The system time stamp, represented within 0.1 millisecond.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x060011DC RID: 4572 RVA: 0x0000E689 File Offset: 0x0000C889
		public long TimeStamp100nSec
		{
			get
			{
				return this.timeStamp100nSec;
			}
		}

		/// <summary>Calculates the performance data of the counter, using a single sample point. This method is generally used for uncalculated performance counter types.</summary>
		/// <returns>The calculated performance value.</returns>
		/// <param name="counterSample">The <see cref="T:System.Diagnostics.CounterSample" /> structure to use as a base point for calculating performance data. </param>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		// Token: 0x060011DD RID: 4573 RVA: 0x0000E691 File Offset: 0x0000C891
		public static float Calculate(CounterSample counterSample)
		{
			return CounterSampleCalculator.ComputeCounterValue(counterSample);
		}

		/// <summary>Calculates the performance data of the counter, using two sample points. This method is generally used for calculated performance counter types, such as averages.</summary>
		/// <returns>The calculated performance value.</returns>
		/// <param name="counterSample">The <see cref="T:System.Diagnostics.CounterSample" /> structure to use as a base point for calculating performance data. </param>
		/// <param name="nextCounterSample">The <see cref="T:System.Diagnostics.CounterSample" /> structure to use as an ending point for calculating performance data. </param>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		// Token: 0x060011DE RID: 4574 RVA: 0x0000E699 File Offset: 0x0000C899
		public static float Calculate(CounterSample counterSample, CounterSample nextCounterSample)
		{
			return CounterSampleCalculator.ComputeCounterValue(counterSample, nextCounterSample);
		}

		/// <summary>Indicates whether the specified structure is a <see cref="T:System.Diagnostics.CounterSample" /> structure and is identical to the current <see cref="T:System.Diagnostics.CounterSample" /> structure.</summary>
		/// <returns>true if <paramref name="o" /> is a <see cref="T:System.Diagnostics.CounterSample" /> structure and is identical to the current instance; otherwise, false. </returns>
		/// <param name="o">The <see cref="T:System.Diagnostics.CounterSample" /> structure to be compared with the current structure.</param>
		// Token: 0x060011DF RID: 4575 RVA: 0x0000E6A2 File Offset: 0x0000C8A2
		public override bool Equals(object obj)
		{
			return obj is CounterSample && this.Equals((CounterSample)obj);
		}

		/// <summary>Indicates whether the specified <see cref="T:System.Diagnostics.CounterSample" /> structure is equal to the current <see cref="T:System.Diagnostics.CounterSample" /> structure.</summary>
		/// <returns>true if <paramref name="sample" /> is equal to the current instance; otherwise, false. </returns>
		/// <param name="sample">The <see cref="T:System.Diagnostics.CounterSample" /> structure to be compared with this instance.</param>
		// Token: 0x060011E0 RID: 4576 RVA: 0x0003C6A0 File Offset: 0x0003A8A0
		public bool Equals(CounterSample other)
		{
			return this.rawValue == other.rawValue && this.baseValue == other.counterFrequency && this.counterFrequency == other.counterFrequency && this.systemFrequency == other.systemFrequency && this.timeStamp == other.timeStamp && this.timeStamp100nSec == other.timeStamp100nSec && this.counterTimeStamp == other.counterTimeStamp && this.counterType == other.counterType;
		}

		/// <summary>Gets a hash code for the current counter sample.</summary>
		/// <returns>A hash code for the current counter sample.</returns>
		// Token: 0x060011E1 RID: 4577 RVA: 0x0003C740 File Offset: 0x0003A940
		public override int GetHashCode()
		{
			return (int)((this.rawValue << 28) ^ ((this.baseValue << 24) ^ ((this.counterFrequency << 20) ^ ((this.systemFrequency << 16) ^ ((this.timeStamp << 8) ^ ((this.timeStamp100nSec << 4) ^ (this.counterTimeStamp ^ (long)this.counterType)))))));
		}

		/// <summary>Returns a value that indicates whether two <see cref="T:System.Diagnostics.CounterSample" /> structures are equal.</summary>
		/// <returns>true if <paramref name="a" /> and <paramref name="b" /> are equal; otherwise, false.</returns>
		/// <param name="a">A <see cref="T:System.Diagnostics.CounterSample" /> structure.</param>
		/// <param name="b">Another <see cref="T:System.Diagnostics.CounterSample" /> structure to be compared to the structure specified by the <paramref name="a" /> parameter.</param>
		// Token: 0x060011E2 RID: 4578 RVA: 0x0000E6BD File Offset: 0x0000C8BD
		public static bool operator ==(CounterSample obj1, CounterSample obj2)
		{
			return obj1.Equals(obj2);
		}

		/// <summary>Returns a value that indicates whether two <see cref="T:System.Diagnostics.CounterSample" /> structures are not equal.</summary>
		/// <returns>true if <paramref name="a" /> and <paramref name="b" /> are not equal; otherwise, false</returns>
		/// <param name="a">A <see cref="T:System.Diagnostics.CounterSample" /> structure.</param>
		/// <param name="b">Another <see cref="T:System.Diagnostics.CounterSample" /> structure to be compared to the structure specified by the <paramref name="a" /> parameter.</param>
		// Token: 0x060011E3 RID: 4579 RVA: 0x0000E6C7 File Offset: 0x0000C8C7
		public static bool operator !=(CounterSample obj1, CounterSample obj2)
		{
			return !obj1.Equals(obj2);
		}

		// Token: 0x04000520 RID: 1312
		private long rawValue;

		// Token: 0x04000521 RID: 1313
		private long baseValue;

		// Token: 0x04000522 RID: 1314
		private long counterFrequency;

		// Token: 0x04000523 RID: 1315
		private long systemFrequency;

		// Token: 0x04000524 RID: 1316
		private long timeStamp;

		// Token: 0x04000525 RID: 1317
		private long timeStamp100nSec;

		// Token: 0x04000526 RID: 1318
		private long counterTimeStamp;

		// Token: 0x04000527 RID: 1319
		private PerformanceCounterType counterType;

		/// <summary>Defines an empty, uninitialized performance counter sample of type NumberOfItems32.</summary>
		/// <filterpriority>1</filterpriority>
		// Token: 0x04000528 RID: 1320
		public static CounterSample Empty = new CounterSample(0L, 0L, 0L, 0L, 0L, 0L, PerformanceCounterType.NumberOfItems32, 0L);
	}
}
