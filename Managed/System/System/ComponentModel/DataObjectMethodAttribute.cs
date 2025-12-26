using System;

namespace System.ComponentModel
{
	/// <summary>Identifies a data operation method exposed by a type, what type of operation the method performs, and whether the method is the default data method. This class cannot be inherited.</summary>
	// Token: 0x020000EE RID: 238
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class DataObjectMethodAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DataObjectMethodAttribute" /> class and identifies the type of data operation the method performs.</summary>
		/// <param name="methodType">One of the <see cref="T:System.ComponentModel.DataObjectMethodType" /> values that describes the data operation the method performs.</param>
		// Token: 0x060009D8 RID: 2520 RVA: 0x00009376 File Offset: 0x00007576
		public DataObjectMethodAttribute(DataObjectMethodType methodType)
			: this(methodType, false)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DataObjectMethodAttribute" /> class, identifies the type of data operation the method performs, and identifies whether the method is the default data method that the data object exposes.</summary>
		/// <param name="methodType">One of the <see cref="T:System.ComponentModel.DataObjectMethodType" /> values that describes the data operation the method performs.</param>
		/// <param name="isDefault">true to indicate the method that the attribute is applied to is the default method of the data object for the specified <paramref name="methodType" />; otherwise, false.</param>
		// Token: 0x060009D9 RID: 2521 RVA: 0x00009380 File Offset: 0x00007580
		public DataObjectMethodAttribute(DataObjectMethodType methodType, bool isDefault)
		{
			this._methodType = methodType;
			this._isDefault = isDefault;
		}

		/// <summary>Gets a <see cref="T:System.ComponentModel.DataObjectMethodType" /> value indicating the type of data operation the method performs.</summary>
		/// <returns>One of the <see cref="T:System.ComponentModel.DataObjectMethodType" /> values that identifies the type of data operation performed by the method to which the <see cref="T:System.ComponentModel.DataObjectMethodAttribute" /> is applied.</returns>
		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060009DA RID: 2522 RVA: 0x00009396 File Offset: 0x00007596
		public DataObjectMethodType MethodType
		{
			get
			{
				return this._methodType;
			}
		}

		/// <summary>Gets a value indicating whether the method that the <see cref="T:System.ComponentModel.DataObjectMethodAttribute" /> is applied to is the default data method exposed by the data object for a specific method type.</summary>
		/// <returns>true if the method is the default method exposed by the object for a method type; otherwise, false.</returns>
		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x0000939E File Offset: 0x0000759E
		public bool IsDefault
		{
			get
			{
				return this._isDefault;
			}
		}

		/// <summary>Gets a value indicating whether this instance shares a common pattern with a specified attribute.</summary>
		/// <returns>true if this instance is the same as the instance specified by the <paramref name="obj" /> parameter; otherwise, false.</returns>
		/// <param name="obj">An object to compare with this instance of <see cref="T:System.ComponentModel.DataObjectMethodAttribute" />.</param>
		// Token: 0x060009DC RID: 2524 RVA: 0x000093A6 File Offset: 0x000075A6
		public override bool Match(object obj)
		{
			return obj is DataObjectMethodAttribute && ((DataObjectMethodAttribute)obj).MethodType == this.MethodType;
		}

		/// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary>
		/// <returns>true if this instance is the same as the instance specified by the <paramref name="obj" /> parameter; otherwise, false.</returns>
		/// <param name="obj">An object to compare with this instance of <see cref="T:System.ComponentModel.DataObjectMethodAttribute" />.</param>
		// Token: 0x060009DD RID: 2525 RVA: 0x000093C8 File Offset: 0x000075C8
		public override bool Equals(object obj)
		{
			return this.Match(obj) && ((DataObjectMethodAttribute)obj).IsDefault == this.IsDefault;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x060009DE RID: 2526 RVA: 0x0002FF14 File Offset: 0x0002E114
		public override int GetHashCode()
		{
			return this.MethodType.GetHashCode() ^ this.IsDefault.GetHashCode();
		}

		// Token: 0x040002A5 RID: 677
		private readonly DataObjectMethodType _methodType;

		// Token: 0x040002A6 RID: 678
		private readonly bool _isDefault;
	}
}
