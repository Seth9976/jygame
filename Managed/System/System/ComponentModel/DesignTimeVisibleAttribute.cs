using System;

namespace System.ComponentModel
{
	/// <summary>
	///   <see cref="T:System.ComponentModel.DesignTimeVisibleAttribute" /> marks a component's visibility. If <see cref="F:System.ComponentModel.DesignTimeVisibleAttribute.Yes" /> is present, a visual designer can show this component on a designer.</summary>
	// Token: 0x02000142 RID: 322
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
	public sealed class DesignTimeVisibleAttribute : Attribute
	{
		/// <summary>Creates a new <see cref="T:System.ComponentModel.DesignTimeVisibleAttribute" /> set to the default value of false.</summary>
		// Token: 0x06000BE2 RID: 3042 RVA: 0x0000A4C7 File Offset: 0x000086C7
		public DesignTimeVisibleAttribute()
			: this(true)
		{
		}

		/// <summary>Creates a new <see cref="T:System.ComponentModel.DesignTimeVisibleAttribute" /> with the <see cref="P:System.ComponentModel.DesignTimeVisibleAttribute.Visible" /> property set to the given value in <paramref name="visible" />.</summary>
		/// <param name="visible">The value that the <see cref="P:System.ComponentModel.DesignTimeVisibleAttribute.Visible" /> property will be set against. </param>
		// Token: 0x06000BE3 RID: 3043 RVA: 0x0000A4D0 File Offset: 0x000086D0
		public DesignTimeVisibleAttribute(bool visible)
		{
			this.visible = visible;
		}

		/// <summary>Gets or sets whether the component should be shown at design time.</summary>
		/// <returns>true if this component should be shown at design time, or false if it shouldn't.</returns>
		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000BE5 RID: 3045 RVA: 0x0000A502 File Offset: 0x00008702
		public bool Visible
		{
			get
			{
				return this.visible;
			}
		}

		/// <param name="obj">The object to compare.</param>
		// Token: 0x06000BE6 RID: 3046 RVA: 0x0000A50A File Offset: 0x0000870A
		public override bool Equals(object obj)
		{
			return obj is DesignTimeVisibleAttribute && (obj == this || ((DesignTimeVisibleAttribute)obj).Visible == this.visible);
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x0000A535 File Offset: 0x00008735
		public override int GetHashCode()
		{
			return this.visible.GetHashCode();
		}

		/// <summary>Gets a value indicating if this instance is equal to the <see cref="F:System.ComponentModel.DesignTimeVisibleAttribute.Default" /> value.</summary>
		/// <returns>true, if this instance is equal to the <see cref="F:System.ComponentModel.DesignTimeVisibleAttribute.Default" /> value; otherwise, false.</returns>
		// Token: 0x06000BE8 RID: 3048 RVA: 0x0000A542 File Offset: 0x00008742
		public override bool IsDefaultAttribute()
		{
			return this.visible == DesignTimeVisibleAttribute.Default.Visible;
		}

		// Token: 0x04000364 RID: 868
		private bool visible;

		/// <summary>The default visibility which is Yes.</summary>
		// Token: 0x04000365 RID: 869
		public static readonly DesignTimeVisibleAttribute Default = new DesignTimeVisibleAttribute(true);

		/// <summary>Marks a component as not visible in a visual designer.</summary>
		// Token: 0x04000366 RID: 870
		public static readonly DesignTimeVisibleAttribute No = new DesignTimeVisibleAttribute(false);

		/// <summary>Marks a component as visible in a visual designer.</summary>
		// Token: 0x04000367 RID: 871
		public static readonly DesignTimeVisibleAttribute Yes = new DesignTimeVisibleAttribute(true);
	}
}
