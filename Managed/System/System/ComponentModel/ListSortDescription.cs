using System;

namespace System.ComponentModel
{
	/// <summary>Provides a description of the sort operation applied to a data source.</summary>
	// Token: 0x02000185 RID: 389
	public class ListSortDescription
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ListSortDescription" /> class with the specified property description and direction.</summary>
		/// <param name="property">The <see cref="T:System.ComponentModel.PropertyDescriptor" /> that describes the property by which the data source is sorted.</param>
		/// <param name="direction">One of the <see cref="T:System.ComponentModel.ListSortDescription" />  values.</param>
		// Token: 0x06000D4D RID: 3405 RVA: 0x0000B0FC File Offset: 0x000092FC
		public ListSortDescription(PropertyDescriptor propertyDescriptor, ListSortDirection sortDirection)
		{
			this.propertyDescriptor = propertyDescriptor;
			this.sortDirection = sortDirection;
		}

		/// <summary>Gets or sets the abstract description of a class property associated with this <see cref="T:System.ComponentModel.ListSortDescription" /></summary>
		/// <returns>The <see cref="T:System.ComponentModel.PropertyDescriptor" /> associated with this <see cref="T:System.ComponentModel.ListSortDescription" />. </returns>
		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000D4E RID: 3406 RVA: 0x0000B112 File Offset: 0x00009312
		// (set) Token: 0x06000D4F RID: 3407 RVA: 0x0000B11A File Offset: 0x0000931A
		public PropertyDescriptor PropertyDescriptor
		{
			get
			{
				return this.propertyDescriptor;
			}
			set
			{
				this.propertyDescriptor = value;
			}
		}

		/// <summary>Gets or sets the direction of the sort operation associated with this <see cref="T:System.ComponentModel.ListSortDescription" />.</summary>
		/// <returns>One of the <see cref="T:System.ComponentModel.ListSortDirection" /> values. </returns>
		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000D50 RID: 3408 RVA: 0x0000B123 File Offset: 0x00009323
		// (set) Token: 0x06000D51 RID: 3409 RVA: 0x0000B12B File Offset: 0x0000932B
		public ListSortDirection SortDirection
		{
			get
			{
				return this.sortDirection;
			}
			set
			{
				this.sortDirection = value;
			}
		}

		// Token: 0x040003B0 RID: 944
		private PropertyDescriptor propertyDescriptor;

		// Token: 0x040003B1 RID: 945
		private ListSortDirection sortDirection;
	}
}
