using System;
using System.Collections;

namespace System.ComponentModel
{
	/// <summary>Extends the <see cref="T:System.ComponentModel.IBindingList" /> interface by providing advanced sorting and filtering capabilities.</summary>
	// Token: 0x02000155 RID: 341
	public interface IBindingListView : IList, ICollection, IEnumerable, IBindingList
	{
		/// <summary>Gets or sets the filter to be used to exclude items from the collection of items returned by the data source</summary>
		/// <returns>The string used to filter items out in the item collection returned by the data source. </returns>
		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000C79 RID: 3193
		// (set) Token: 0x06000C7A RID: 3194
		string Filter { get; set; }

		/// <summary>Gets the collection of sort descriptions currently applied to the data source.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.ListSortDescriptionCollection" /> currently applied to the data source.</returns>
		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000C7B RID: 3195
		ListSortDescriptionCollection SortDescriptions { get; }

		/// <summary>Gets a value indicating whether the data source supports advanced sorting. </summary>
		/// <returns>true if the data source supports advanced sorting; otherwise, false. </returns>
		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000C7C RID: 3196
		bool SupportsAdvancedSorting { get; }

		/// <summary>Gets a value indicating whether the data source supports filtering. </summary>
		/// <returns>true if the data source supports filtering; otherwise, false. </returns>
		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000C7D RID: 3197
		bool SupportsFiltering { get; }

		/// <summary>Sorts the data source based on the given <see cref="T:System.ComponentModel.ListSortDescriptionCollection" />.</summary>
		/// <param name="sorts">The <see cref="T:System.ComponentModel.ListSortDescriptionCollection" /> containing the sorts to apply to the data source.</param>
		// Token: 0x06000C7E RID: 3198
		void ApplySort(ListSortDescriptionCollection sorts);

		/// <summary>Removes the current filter applied to the data source.</summary>
		// Token: 0x06000C7F RID: 3199
		void RemoveFilter();
	}
}
