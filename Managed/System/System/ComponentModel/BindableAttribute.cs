using System;

namespace System.ComponentModel
{
	/// <summary>Specifies whether a member is typically used for binding. This class cannot be inherited.</summary>
	// Token: 0x020000D3 RID: 211
	[AttributeUsage(AttributeTargets.All)]
	public sealed class BindableAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.BindableAttribute" /> class with one of the <see cref="T:System.ComponentModel.BindableSupport" /> values.</summary>
		/// <param name="flags">One of the <see cref="T:System.ComponentModel.BindableSupport" /> values. </param>
		// Token: 0x06000900 RID: 2304 RVA: 0x000087BB File Offset: 0x000069BB
		public BindableAttribute(BindableSupport flags)
		{
			if (flags == BindableSupport.No)
			{
				this.bindable = false;
			}
			if (flags == BindableSupport.Yes || flags == BindableSupport.Default)
			{
				this.bindable = true;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.BindableAttribute" /> class with a Boolean value.</summary>
		/// <param name="bindable">true to use property for binding; otherwise, false.</param>
		// Token: 0x06000901 RID: 2305 RVA: 0x000087E5 File Offset: 0x000069E5
		public BindableAttribute(bool bindable)
		{
			this.bindable = bindable;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.BindableAttribute" /> class.</summary>
		/// <param name="bindable">true to use property for binding; otherwise, false.</param>
		/// <param name="direction">One of the <see cref="T:System.ComponentModel.BindingDirection" /> values.</param>
		// Token: 0x06000902 RID: 2306 RVA: 0x000087F4 File Offset: 0x000069F4
		public BindableAttribute(bool bindable, BindingDirection direction)
		{
			this.bindable = bindable;
			this.direction = direction;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.BindableAttribute" /> class.</summary>
		/// <param name="flags">One of the <see cref="T:System.ComponentModel.BindableSupport" /> values. </param>
		/// <param name="direction">One of the <see cref="T:System.ComponentModel.BindingDirection" /> values.</param>
		// Token: 0x06000903 RID: 2307 RVA: 0x0000880A File Offset: 0x00006A0A
		public BindableAttribute(BindableSupport flags, BindingDirection direction)
			: this(flags)
		{
			this.direction = direction;
		}

		/// <summary>Gets a value indicating the direction or directions of this property's data binding.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.BindingDirection" />.</returns>
		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000905 RID: 2309 RVA: 0x0000883D File Offset: 0x00006A3D
		public BindingDirection Direction
		{
			get
			{
				return this.direction;
			}
		}

		/// <summary>Gets a value indicating that a property is typically used for binding.</summary>
		/// <returns>true if the property is typically used for binding; otherwise, false.</returns>
		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x00008845 File Offset: 0x00006A45
		public bool Bindable
		{
			get
			{
				return this.bindable;
			}
		}

		/// <summary>Determines whether two <see cref="T:System.ComponentModel.BindableAttribute" /> objects are equal.</summary>
		/// <returns>true if the specified <see cref="T:System.ComponentModel.BindableAttribute" /> is equal to the current <see cref="T:System.ComponentModel.BindableAttribute" />; false if it is not equal.</returns>
		/// <param name="obj">The object to compare.</param>
		// Token: 0x06000907 RID: 2311 RVA: 0x0000884D File Offset: 0x00006A4D
		public override bool Equals(object obj)
		{
			return obj is BindableAttribute && (obj == this || ((BindableAttribute)obj).Bindable == this.bindable);
		}

		/// <summary>Serves as a hash function for the <see cref="T:System.ComponentModel.BindableAttribute" /> class.</summary>
		/// <returns>A hash code for the current <see cref="T:System.ComponentModel.BindableAttribute" />.</returns>
		// Token: 0x06000908 RID: 2312 RVA: 0x00008878 File Offset: 0x00006A78
		public override int GetHashCode()
		{
			return this.bindable.GetHashCode();
		}

		/// <summary>Determines if this attribute is the default.</summary>
		/// <returns>true if the attribute is the default value for this attribute class; otherwise, false.</returns>
		// Token: 0x06000909 RID: 2313 RVA: 0x00008885 File Offset: 0x00006A85
		public override bool IsDefaultAttribute()
		{
			return this.bindable == BindableAttribute.Default.Bindable;
		}

		// Token: 0x0400025E RID: 606
		private bool bindable;

		// Token: 0x0400025F RID: 607
		private BindingDirection direction;

		/// <summary>Specifies that a property is not typically used for binding. This field is read-only.</summary>
		// Token: 0x04000260 RID: 608
		public static readonly BindableAttribute No = new BindableAttribute(BindableSupport.No);

		/// <summary>Specifies that a property is typically used for binding. This field is read-only.</summary>
		// Token: 0x04000261 RID: 609
		public static readonly BindableAttribute Yes = new BindableAttribute(BindableSupport.Yes);

		/// <summary>Specifies the default value for the <see cref="T:System.ComponentModel.BindableAttribute" />, which is <see cref="F:System.ComponentModel.BindableAttribute.No" />. This field is read-only.</summary>
		// Token: 0x04000262 RID: 610
		public static readonly BindableAttribute Default = new BindableAttribute(BindableSupport.Default);
	}
}
