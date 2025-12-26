using System;

namespace System.ComponentModel
{
	/// <summary>Specifies the filter string and filter type to use for a toolbox item.</summary>
	// Token: 0x020001B1 RID: 433
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
	[Serializable]
	public sealed class ToolboxItemFilterAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ToolboxItemFilterAttribute" /> class using the specified filter string.</summary>
		/// <param name="filterString">The filter string for the toolbox item. </param>
		// Token: 0x06000F05 RID: 3845 RVA: 0x0000C717 File Offset: 0x0000A917
		public ToolboxItemFilterAttribute(string filterString)
		{
			this.Filter = filterString;
			this.ItemFilterType = ToolboxItemFilterType.Allow;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ToolboxItemFilterAttribute" /> class using the specified filter string and type.</summary>
		/// <param name="filterString">The filter string for the toolbox item. </param>
		/// <param name="filterType">A <see cref="T:System.ComponentModel.ToolboxItemFilterType" /> indicating the type of the filter. </param>
		// Token: 0x06000F06 RID: 3846 RVA: 0x0000C72D File Offset: 0x0000A92D
		public ToolboxItemFilterAttribute(string filterString, ToolboxItemFilterType filterType)
		{
			this.Filter = filterString;
			this.ItemFilterType = filterType;
		}

		/// <summary>Gets the filter string for the toolbox item.</summary>
		/// <returns>The filter string for the toolbox item.</returns>
		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000F07 RID: 3847 RVA: 0x0000C743 File Offset: 0x0000A943
		public string FilterString
		{
			get
			{
				return this.Filter;
			}
		}

		/// <summary>Gets the type of the filter.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.ToolboxItemFilterType" /> that indicates the type of the filter.</returns>
		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000F08 RID: 3848 RVA: 0x0000C74B File Offset: 0x0000A94B
		public ToolboxItemFilterType FilterType
		{
			get
			{
				return this.ItemFilterType;
			}
		}

		/// <summary>Gets the type ID for the attribute.</summary>
		/// <returns>The type ID for this attribute. All <see cref="T:System.ComponentModel.ToolboxItemFilterAttribute" /> objects with the same filter string return the same type ID.</returns>
		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000F09 RID: 3849 RVA: 0x0000C753 File Offset: 0x0000A953
		public override object TypeId
		{
			get
			{
				return base.TypeId + this.Filter;
			}
		}

		/// <param name="obj">The object to compare.</param>
		// Token: 0x06000F0A RID: 3850 RVA: 0x00036650 File Offset: 0x00034850
		public override bool Equals(object obj)
		{
			return obj is ToolboxItemFilterAttribute && (obj == this || (((ToolboxItemFilterAttribute)obj).FilterString == this.Filter && ((ToolboxItemFilterAttribute)obj).FilterType == this.ItemFilterType));
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x0000C766 File Offset: 0x0000A966
		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		/// <summary>Indicates whether the specified object has a matching filter string.</summary>
		/// <returns>true if the specified object has a matching filter string; otherwise, false.</returns>
		/// <param name="obj">The object to test for a matching filter string. </param>
		// Token: 0x06000F0C RID: 3852 RVA: 0x0000C773 File Offset: 0x0000A973
		public override bool Match(object obj)
		{
			return obj is ToolboxItemFilterAttribute && ((ToolboxItemFilterAttribute)obj).FilterString == this.Filter;
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x0000C798 File Offset: 0x0000A998
		public override string ToString()
		{
			return string.Format("{0},{1}", this.Filter, this.ItemFilterType);
		}

		// Token: 0x0400044D RID: 1101
		private string Filter;

		// Token: 0x0400044E RID: 1102
		private ToolboxItemFilterType ItemFilterType;
	}
}
