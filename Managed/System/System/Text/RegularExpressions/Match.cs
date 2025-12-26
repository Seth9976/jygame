using System;

namespace System.Text.RegularExpressions
{
	/// <summary>Represents the results from a single regular expression match.</summary>
	// Token: 0x020004A4 RID: 1188
	[Serializable]
	public class Match : Group
	{
		// Token: 0x060029DD RID: 10717 RVA: 0x0001D281 File Offset: 0x0001B481
		private Match()
		{
			this.regex = null;
			this.machine = null;
			this.text_length = 0;
			this.groups = new GroupCollection(1, 1);
			this.groups.SetValue(this, 0);
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x0001D2B8 File Offset: 0x0001B4B8
		internal Match(Regex regex, IMachine machine, string text, int text_length, int n_groups, int index, int length)
			: base(text, index, length)
		{
			this.regex = regex;
			this.machine = machine;
			this.text_length = text_length;
		}

		// Token: 0x060029DF RID: 10719 RVA: 0x00082264 File Offset: 0x00080464
		internal Match(Regex regex, IMachine machine, string text, int text_length, int n_groups, int index, int length, int n_caps)
			: base(text, index, length, n_caps)
		{
			this.regex = regex;
			this.machine = machine;
			this.text_length = text_length;
			this.groups = new GroupCollection(n_groups, regex.Gap);
			this.groups.SetValue(this, 0);
		}

		/// <summary>Gets the empty group. All failed matches return this empty match.</summary>
		/// <returns>An empty <see cref="T:System.Text.RegularExpressions.Match" />.</returns>
		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x060029E1 RID: 10721 RVA: 0x0001D2E7 File Offset: 0x0001B4E7
		public static Match Empty
		{
			get
			{
				return Match.empty;
			}
		}

		/// <summary>Returns a <see cref="T:System.Text.RegularExpressions.Match" /> instance equivalent to the one supplied that is suitable to share between multiple threads.</summary>
		/// <returns>A match that is suitable to share between multiple threads.</returns>
		/// <param name="inner">A match equivalent to the one expected.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="inner" /> is null.</exception>
		// Token: 0x060029E2 RID: 10722 RVA: 0x0001CF1F File Offset: 0x0001B11F
		[global::System.MonoTODO("not thread-safe")]
		public static Match Synchronized(Match inner)
		{
			if (inner == null)
			{
				throw new ArgumentNullException("inner");
			}
			return inner;
		}

		/// <summary>Gets a collection of groups matched by the regular expression.</summary>
		/// <returns>The character groups matched by the pattern.</returns>
		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x060029E3 RID: 10723 RVA: 0x0001D2EE File Offset: 0x0001B4EE
		public virtual GroupCollection Groups
		{
			get
			{
				return this.groups;
			}
		}

		/// <summary>Returns a new <see cref="T:System.Text.RegularExpressions.Match" /> object with the results for the next match, starting at the position at which the last match ended (at the character after the last matched character).</summary>
		/// <returns>The next regular expression match.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x060029E4 RID: 10724 RVA: 0x000822B4 File Offset: 0x000804B4
		public Match NextMatch()
		{
			if (this == Match.Empty)
			{
				return Match.Empty;
			}
			int num = ((!this.regex.RightToLeft) ? (base.Index + base.Length) : base.Index);
			if (base.Length == 0)
			{
				num += ((!this.regex.RightToLeft) ? 1 : (-1));
			}
			return this.machine.Scan(this.regex, base.Text, num, this.text_length);
		}

		/// <summary>Returns the expansion of the specified replacement pattern. </summary>
		/// <returns>The expanded version of the <paramref name="replacement" /> parameter.</returns>
		/// <param name="replacement">The replacement pattern to use. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="replacement" /> is null.</exception>
		/// <exception cref="T:System.NotSupportedException">Expansion is not allowed for this pattern.</exception>
		// Token: 0x060029E5 RID: 10725 RVA: 0x0001D2F6 File Offset: 0x0001B4F6
		public virtual string Result(string replacement)
		{
			if (replacement == null)
			{
				throw new ArgumentNullException("replacement");
			}
			if (this.machine == null)
			{
				throw new NotSupportedException("Result cannot be called on failed Match.");
			}
			return this.machine.Result(replacement, this);
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x060029E6 RID: 10726 RVA: 0x0001D32C File Offset: 0x0001B52C
		internal Regex Regex
		{
			get
			{
				return this.regex;
			}
		}

		// Token: 0x04001A1A RID: 6682
		private Regex regex;

		// Token: 0x04001A1B RID: 6683
		private IMachine machine;

		// Token: 0x04001A1C RID: 6684
		private int text_length;

		// Token: 0x04001A1D RID: 6685
		private GroupCollection groups;

		// Token: 0x04001A1E RID: 6686
		private static Match empty = new Match();
	}
}
