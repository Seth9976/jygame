using System;

namespace System.ComponentModel.Design
{
	/// <summary>Specifies the context keyword for a class or member. This class cannot be inherited.</summary>
	// Token: 0x0200010F RID: 271
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
	[Serializable]
	public sealed class HelpKeywordAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.HelpKeywordAttribute" /> class. </summary>
		// Token: 0x06000AB7 RID: 2743 RVA: 0x000021D7 File Offset: 0x000003D7
		public HelpKeywordAttribute()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.HelpKeywordAttribute" /> class. </summary>
		/// <param name="keyword">The Help keyword value.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="keyword" /> is null.</exception>
		// Token: 0x06000AB8 RID: 2744 RVA: 0x00009DF3 File Offset: 0x00007FF3
		public HelpKeywordAttribute(string keyword)
		{
			this.contextKeyword = keyword;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.HelpKeywordAttribute" /> class from the given type. </summary>
		/// <param name="t">The type from which the Help keyword will be taken.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="t" /> is null.</exception>
		// Token: 0x06000AB9 RID: 2745 RVA: 0x00009E02 File Offset: 0x00008002
		public HelpKeywordAttribute(Type t)
		{
			if (t == null)
			{
				throw new ArgumentNullException("t");
			}
			this.contextKeyword = t.FullName;
		}

		/// <summary>Determines whether two <see cref="T:System.ComponentModel.Design.HelpKeywordAttribute" /> instances are equal.</summary>
		/// <returns>true if the specified <see cref="T:System.ComponentModel.Design.HelpKeywordAttribute" /> is equal to the current <see cref="T:System.ComponentModel.Design.HelpKeywordAttribute" />; otherwise, false.</returns>
		/// <param name="obj">The <see cref="T:System.ComponentModel.Design.HelpKeywordAttribute" /> to compare with the current <see cref="T:System.ComponentModel.Design.HelpKeywordAttribute" />.</param>
		// Token: 0x06000ABB RID: 2747 RVA: 0x00030778 File Offset: 0x0002E978
		public override bool Equals(object other)
		{
			if (other == null)
			{
				return false;
			}
			HelpKeywordAttribute helpKeywordAttribute = other as HelpKeywordAttribute;
			return helpKeywordAttribute != null && helpKeywordAttribute.contextKeyword == this.contextKeyword;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A hash code for the current <see cref="T:System.ComponentModel.Design.HelpKeywordAttribute" />.</returns>
		// Token: 0x06000ABC RID: 2748 RVA: 0x00009E27 File Offset: 0x00008027
		public override int GetHashCode()
		{
			return (this.contextKeyword == null) ? 0 : this.contextKeyword.GetHashCode();
		}

		/// <summary>Determines whether the Help keyword is null.</summary>
		/// <returns>true if the Help keyword is null; otherwise, false.</returns>
		// Token: 0x06000ABD RID: 2749 RVA: 0x00009E45 File Offset: 0x00008045
		public override bool IsDefaultAttribute()
		{
			return this.contextKeyword == null;
		}

		/// <summary>Gets the Help keyword supplied by this attribute.</summary>
		/// <returns>The Help keyword supplied by this attribute.</returns>
		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x00009E50 File Offset: 0x00008050
		public string HelpKeyword
		{
			get
			{
				return this.contextKeyword;
			}
		}

		/// <summary>Represents the default value for <see cref="T:System.ComponentModel.Design.HelpKeywordAttribute" />. This field is read-only.</summary>
		// Token: 0x040002F0 RID: 752
		public static readonly HelpKeywordAttribute Default;

		// Token: 0x040002F1 RID: 753
		private string contextKeyword;
	}
}
