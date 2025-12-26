using System;

namespace System.Text.RegularExpressions
{
	/// <summary>Represents the results from a single capturing group. </summary>
	// Token: 0x02000499 RID: 1177
	[Serializable]
	public class Group : Capture
	{
		// Token: 0x0600297D RID: 10621 RVA: 0x0001CEB2 File Offset: 0x0001B0B2
		internal Group(string text, int index, int length, int n_caps)
			: base(text, index, length)
		{
			this.success = true;
			this.captures = new CaptureCollection(n_caps);
			this.captures.SetValue(this, n_caps - 1);
		}

		// Token: 0x0600297E RID: 10622 RVA: 0x0001CEE1 File Offset: 0x0001B0E1
		internal Group(string text, int index, int length)
			: base(text, index, length)
		{
			this.success = true;
		}

		// Token: 0x0600297F RID: 10623 RVA: 0x0001CEF3 File Offset: 0x0001B0F3
		internal Group()
			: base(string.Empty)
		{
			this.success = false;
			this.captures = new CaptureCollection(0);
		}

		/// <summary>Returns a Group object equivalent to the one supplied that is safe to share between multiple threads.</summary>
		/// <returns>A regular expression Group object. </returns>
		/// <param name="inner">The input <see cref="T:System.Text.RegularExpressions.Group" /> object.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="inner" /> is null.</exception>
		// Token: 0x06002981 RID: 10625 RVA: 0x0001CF1F File Offset: 0x0001B11F
		[global::System.MonoTODO("not thread-safe")]
		public static Group Synchronized(Group inner)
		{
			if (inner == null)
			{
				throw new ArgumentNullException("inner");
			}
			return inner;
		}

		/// <summary>Gets a collection of all the captures matched by the capturing group, in innermost-leftmost-first order (or innermost-rightmost-first order if the regular expression is modified with the <see cref="F:System.Text.RegularExpressions.RegexOptions.RightToLeft" /> option). The collection may have zero or more items.</summary>
		/// <returns>The collection of substrings matched by the group.</returns>
		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06002982 RID: 10626 RVA: 0x0001CF33 File Offset: 0x0001B133
		public CaptureCollection Captures
		{
			get
			{
				return this.captures;
			}
		}

		/// <summary>Gets a value indicating whether the match is successful.</summary>
		/// <returns>true if the match is successful; otherwise, false.</returns>
		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06002983 RID: 10627 RVA: 0x0001CF3B File Offset: 0x0001B13B
		public bool Success
		{
			get
			{
				return this.success;
			}
		}

		// Token: 0x040019F0 RID: 6640
		internal static Group Fail = new Group();

		// Token: 0x040019F1 RID: 6641
		private bool success;

		// Token: 0x040019F2 RID: 6642
		private CaptureCollection captures;
	}
}
