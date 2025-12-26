using System;
using System.Collections;

namespace System.Diagnostics
{
	/// <summary>Provides a strongly typed collection of <see cref="T:System.Diagnostics.InstanceData" /> objects.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x02000235 RID: 565
	public class InstanceDataCollection : DictionaryBase
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.InstanceDataCollection" /> class, using the specified performance counter (which defines a performance instance).</summary>
		/// <param name="counterName">The name of the counter, which often describes the quantity that is being counted. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="counterName" /> parameter is null. </exception>
		// Token: 0x06001345 RID: 4933 RVA: 0x0000F4DB File Offset: 0x0000D6DB
		[Obsolete("Use InstanceDataCollectionCollection indexer instead.")]
		public InstanceDataCollection(string counterName)
		{
			InstanceDataCollection.CheckNull(counterName, "counterName");
			this.counterName = counterName;
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x0000F46C File Offset: 0x0000D66C
		private static void CheckNull(object value, string name)
		{
			if (value == null)
			{
				throw new ArgumentNullException(name);
			}
		}

		/// <summary>Gets the name of the performance counter whose instance data you want to get.</summary>
		/// <returns>The performance counter name.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06001347 RID: 4935 RVA: 0x0000F4F5 File Offset: 0x0000D6F5
		public string CounterName
		{
			get
			{
				return this.counterName;
			}
		}

		/// <summary>Gets the instance data associated with this counter. This is typically a set of raw counter values.</summary>
		/// <returns>An <see cref="T:System.Diagnostics.InstanceData" /> item, by which the <see cref="T:System.Diagnostics.InstanceDataCollection" /> object is indexed.</returns>
		/// <param name="instanceName">The name of the performance counter category instance, or an empty string ("") if the category contains a single instance. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="instanceName" /> parameter is null. </exception>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700047B RID: 1147
		public InstanceData this[string instanceName]
		{
			get
			{
				InstanceDataCollection.CheckNull(instanceName, "instanceName");
				return (InstanceData)base.Dictionary[instanceName];
			}
		}

		/// <summary>Gets the object and counter registry keys for the objects associated with this instance data.</summary>
		/// <returns>An <see cref="T:System.Collections.ICollection" /> that represents a set of object-specific registry keys.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06001349 RID: 4937 RVA: 0x0000F499 File Offset: 0x0000D699
		public ICollection Keys
		{
			get
			{
				return base.Dictionary.Keys;
			}
		}

		/// <summary>Gets the raw counter values that comprise the instance data for the counter.</summary>
		/// <returns>An <see cref="T:System.Collections.ICollection" /> that represents the counter's raw data values.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x0600134A RID: 4938 RVA: 0x0000F4A6 File Offset: 0x0000D6A6
		public ICollection Values
		{
			get
			{
				return base.Dictionary.Values;
			}
		}

		/// <summary>Determines whether a performance instance with a specified name (identified by one of the indexed <see cref="T:System.Diagnostics.InstanceData" /> objects) exists in the collection.</summary>
		/// <returns>true if the instance exists in the collection; otherwise, false.</returns>
		/// <param name="instanceName">The name of the instance to find in this collection. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="instanceName" /> parameter is null. </exception>
		/// <filterpriority>2</filterpriority>
		// Token: 0x0600134B RID: 4939 RVA: 0x0000F51B File Offset: 0x0000D71B
		public bool Contains(string instanceName)
		{
			InstanceDataCollection.CheckNull(instanceName, "instanceName");
			return base.Dictionary.Contains(instanceName);
		}

		/// <summary>Copies the items in the collection to the specified one-dimensional array at the specified index.</summary>
		/// <param name="instances">The one-dimensional <see cref="T:System.Array" /> that is the destination of the values copied from the collection. </param>
		/// <param name="index">The zero-based index value at which to add the new instances. </param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x0600134C RID: 4940 RVA: 0x0000F4CC File Offset: 0x0000D6CC
		public void CopyTo(InstanceData[] instances, int index)
		{
			base.Dictionary.CopyTo(instances, index);
		}

		// Token: 0x0400059B RID: 1435
		private string counterName;
	}
}
