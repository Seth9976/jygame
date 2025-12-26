using System;

namespace UnityEngine.SocialPlatforms
{
	/// <summary>
	///   <para>The score range a leaderboard query should include.</para>
	/// </summary>
	// Token: 0x020002C1 RID: 705
	public struct Range
	{
		/// <summary>
		///   <para>Constructor for a score range, the range starts from a specific value and contains a maxium score count.</para>
		/// </summary>
		/// <param name="fromValue">The minimum allowed value.</param>
		/// <param name="valueCount">The number of possible values.</param>
		// Token: 0x060021A0 RID: 8608 RVA: 0x0000D7DA File Offset: 0x0000B9DA
		public Range(int fromValue, int valueCount)
		{
			this.from = fromValue;
			this.count = valueCount;
		}

		/// <summary>
		///   <para>The rank of the first score which is returned.</para>
		/// </summary>
		// Token: 0x04000AD8 RID: 2776
		public int from;

		/// <summary>
		///   <para>The total amount of scores retreived.</para>
		/// </summary>
		// Token: 0x04000AD9 RID: 2777
		public int count;
	}
}
