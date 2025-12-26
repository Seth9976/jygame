using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Tracks outstanding handles and forces a garbage collection when the specified threshold is reached.</summary>
	// Token: 0x020004E8 RID: 1256
	public sealed class HandleCollector
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.HandleCollector" /> class using a name and a threshold at which to begin handle collection. </summary>
		/// <param name="name">A name for the collector.  This parameter allows you to name collectors that track handle types separately.</param>
		/// <param name="initialThreshold">A value that specifies the point at which collections should begin.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="initialThreshold" /> parameter is less than 0.</exception>
		// Token: 0x06002C59 RID: 11353 RVA: 0x0001EB68 File Offset: 0x0001CD68
		public HandleCollector(string name, int initialThreshold)
			: this(name, initialThreshold, int.MaxValue)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.HandleCollector" /> class using a name, a threshold at which to begin handle collection, and a threshold at which handle collection must occur. </summary>
		/// <param name="name">A name for the collector.  This parameter allows you to name collectors that track handle types separately.</param>
		/// <param name="initialThreshold">A value that specifies the point at which collections should begin.</param>
		/// <param name="maximumThreshold">A value that specifies the point at which collections must occur. This should be set to the maximum number of available handles.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="initialThreshold" /> parameter is less than 0.-or-The <paramref name="maximumThreshold" /> parameter is less than 0.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="maximumThreshold" /> parameter is less than the <paramref name="initialThreshold" /> parameter.</exception>
		// Token: 0x06002C5A RID: 11354 RVA: 0x000907B4 File Offset: 0x0008E9B4
		public HandleCollector(string name, int initialThreshold, int maximumThreshold)
		{
			if (initialThreshold < 0)
			{
				throw new ArgumentOutOfRangeException("initialThreshold", "initialThreshold must not be less than zero");
			}
			if (maximumThreshold < 0)
			{
				throw new ArgumentOutOfRangeException("maximumThreshold", "maximumThreshold must not be less than zero");
			}
			if (maximumThreshold < initialThreshold)
			{
				throw new ArgumentException("maximumThreshold must not be less than initialThreshold");
			}
			this.name = name;
			this.init = initialThreshold;
			this.max = maximumThreshold;
		}

		/// <summary>Gets the number of handles collected.</summary>
		/// <returns>The number of handles collected.</returns>
		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x06002C5B RID: 11355 RVA: 0x0001EB77 File Offset: 0x0001CD77
		public int Count
		{
			get
			{
				return this.count;
			}
		}

		/// <summary>Gets a value that specifies the point at which collections should begin.</summary>
		/// <returns>A value that specifies the point at which collections should begin.</returns>
		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x06002C5C RID: 11356 RVA: 0x0001EB7F File Offset: 0x0001CD7F
		public int InitialThreshold
		{
			get
			{
				return this.init;
			}
		}

		/// <summary>Gets a value that specifies the point at which collections must occur.</summary>
		/// <returns>A value that specifies the point at which collections must occur.</returns>
		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x06002C5D RID: 11357 RVA: 0x0001EB87 File Offset: 0x0001CD87
		public int MaximumThreshold
		{
			get
			{
				return this.max;
			}
		}

		/// <summary>Gets the name of a <see cref="T:System.Runtime.InteropServices.HandleCollector" /> object.</summary>
		/// <returns>This <see cref="P:System.Runtime.InteropServices.HandleCollector.Name" /> property allows you to name collectors that track handle types separately.</returns>
		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x06002C5E RID: 11358 RVA: 0x0001EB8F File Offset: 0x0001CD8F
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Increments the current handle count.</summary>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Runtime.InteropServices.HandleCollector.Count" /> property is less than 0.</exception>
		// Token: 0x06002C5F RID: 11359 RVA: 0x00090828 File Offset: 0x0008EA28
		public void Add()
		{
			if (++this.count >= this.max)
			{
				GC.Collect(GC.MaxGeneration);
			}
			else if (this.count >= this.init && DateTime.Now - this.previous_collection > TimeSpan.FromSeconds(5.0))
			{
				GC.Collect(GC.MaxGeneration);
				this.previous_collection = DateTime.Now;
			}
		}

		/// <summary>Decrements the current handle count.</summary>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Runtime.InteropServices.HandleCollector.Count" /> property is less than 0.</exception>
		// Token: 0x06002C60 RID: 11360 RVA: 0x0001EB97 File Offset: 0x0001CD97
		public void Remove()
		{
			if (this.count == 0)
			{
				throw new InvalidOperationException("Cannot call Remove method when Count is 0");
			}
			this.count--;
		}

		// Token: 0x04001BC3 RID: 7107
		private int count;

		// Token: 0x04001BC4 RID: 7108
		private readonly int init;

		// Token: 0x04001BC5 RID: 7109
		private readonly int max;

		// Token: 0x04001BC6 RID: 7110
		private readonly string name;

		// Token: 0x04001BC7 RID: 7111
		private DateTime previous_collection = DateTime.MinValue;
	}
}
