using System;

namespace System.ComponentModel
{
	/// <summary>Identifies a type as an object suitable for binding to an <see cref="T:System.Web.UI.WebControls.ObjectDataSource" /> object. This class cannot be inherited.</summary>
	// Token: 0x020000EC RID: 236
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class DataObjectAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DataObjectAttribute" /> class. </summary>
		// Token: 0x060009C7 RID: 2503 RVA: 0x00009262 File Offset: 0x00007462
		public DataObjectAttribute()
			: this(true)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DataObjectAttribute" /> class and indicates whether an object is suitable for binding to an <see cref="T:System.Web.UI.WebControls.ObjectDataSource" /> object.</summary>
		/// <param name="isDataObject">true if the object is suitable for binding to an <see cref="T:System.Web.UI.WebControls.ObjectDataSource" /> object; otherwise, false.</param>
		// Token: 0x060009C8 RID: 2504 RVA: 0x0000926B File Offset: 0x0000746B
		public DataObjectAttribute(bool isDataObject)
		{
			this._isDataObject = isDataObject;
		}

		/// <summary>Gets a value indicating whether an object should be considered suitable for binding to an <see cref="T:System.Web.UI.WebControls.ObjectDataSource" /> object at design time.</summary>
		/// <returns>true if the object should be considered suitable for binding to an <see cref="T:System.Web.UI.WebControls.ObjectDataSource" /> object; otherwise, false.</returns>
		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x0000929C File Offset: 0x0000749C
		public bool IsDataObject
		{
			get
			{
				return this._isDataObject;
			}
		}

		/// <summary>Determines whether this instance of <see cref="T:System.ComponentModel.DataObjectAttribute" /> fits the pattern of another object.</summary>
		/// <returns>true if this instance is the same as the instance specified by the <paramref name="obj" /> parameter; otherwise, false.</returns>
		/// <param name="obj">An object to compare with this instance of <see cref="T:System.ComponentModel.DataObjectAttribute" />. </param>
		// Token: 0x060009CB RID: 2507 RVA: 0x000092A4 File Offset: 0x000074A4
		public override bool Equals(object obj)
		{
			return obj is DataObjectAttribute && ((DataObjectAttribute)obj).IsDataObject == this.IsDataObject;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x060009CC RID: 2508 RVA: 0x0002FE4C File Offset: 0x0002E04C
		public override int GetHashCode()
		{
			return this.IsDataObject.GetHashCode();
		}

		/// <summary>Gets a value indicating whether the current value of the attribute is the default value for the attribute.</summary>
		/// <returns>true if the current value of the attribute is the default; otherwise, false.</returns>
		// Token: 0x060009CD RID: 2509 RVA: 0x000092C6 File Offset: 0x000074C6
		public override bool IsDefaultAttribute()
		{
			return DataObjectAttribute.Default.Equals(this);
		}

		/// <summary>Indicates that the class is suitable for binding to an <see cref="T:System.Web.UI.WebControls.ObjectDataSource" /> object at design time. This field is read-only.</summary>
		// Token: 0x0400029D RID: 669
		public static readonly DataObjectAttribute DataObject = new DataObjectAttribute(true);

		/// <summary>Represents the default value of the <see cref="T:System.ComponentModel.DataObjectAttribute" /> class, which indicates that the class is suitable for binding to an <see cref="T:System.Web.UI.WebControls.ObjectDataSource" /> object at design time. This field is read-only.</summary>
		// Token: 0x0400029E RID: 670
		public static readonly DataObjectAttribute Default = DataObjectAttribute.NonDataObject;

		/// <summary>Indicates that the class is not suitable for binding to an <see cref="T:System.Web.UI.WebControls.ObjectDataSource" /> object at design time. This field is read-only.</summary>
		// Token: 0x0400029F RID: 671
		public static readonly DataObjectAttribute NonDataObject = new DataObjectAttribute(false);

		// Token: 0x040002A0 RID: 672
		private readonly bool _isDataObject;
	}
}
