using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>SortingLayer allows you to set the render order of multiple sprites easily. There is always a default SortingLayer named "Default" which all sprites are added to initially. Added more SortingLayers to easily control the order of rendering of groups of sprites. Layers can be ordered before or after the default layer.</para>
	/// </summary>
	// Token: 0x0200008A RID: 138
	public struct SortingLayer
	{
		/// <summary>
		///   <para>This is the unique id assigned to the layer. It is not an ordered running value and it should not be used to compare with other layers to determine the sorting order.</para>
		/// </summary>
		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x00005463 File Offset: 0x00003663
		public int id
		{
			get
			{
				return this.m_Id;
			}
		}

		/// <summary>
		///   <para>Returns the name of the layer as defined in the TagManager.</para>
		/// </summary>
		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x0000546B File Offset: 0x0000366B
		public string name
		{
			get
			{
				return SortingLayer.IDToName(this.m_Id);
			}
		}

		/// <summary>
		///   <para>This is the relative value that indicates the sort order of this layer relative to the other layers.</para>
		/// </summary>
		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000848 RID: 2120 RVA: 0x00005478 File Offset: 0x00003678
		public int value
		{
			get
			{
				return SortingLayer.GetLayerValueFromID(this.m_Id);
			}
		}

		/// <summary>
		///   <para>Returns all the layers defined in this project.</para>
		/// </summary>
		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x00014808 File Offset: 0x00012A08
		public static SortingLayer[] layers
		{
			get
			{
				int[] sortingLayerIDsInternal = SortingLayer.GetSortingLayerIDsInternal();
				SortingLayer[] array = new SortingLayer[sortingLayerIDsInternal.Length];
				for (int i = 0; i < sortingLayerIDsInternal.Length; i++)
				{
					array[i].m_Id = sortingLayerIDsInternal[i];
				}
				return array;
			}
		}

		// Token: 0x0600084A RID: 2122
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int[] GetSortingLayerIDsInternal();

		/// <summary>
		///   <para>Returns the final sorting layer value. To determine the sorting order between the various sorting layers, use this method to retrieve the final sorting value and use CompareTo to determine the order.</para>
		/// </summary>
		/// <param name="id">The unique value of the sorting layer as returned by any renderer's sortingLayerID property.</param>
		/// <returns>
		///   <para>The final sorting value of the layer relative to other layers.</para>
		/// </returns>
		// Token: 0x0600084B RID: 2123
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetLayerValueFromID(int id);

		/// <summary>
		///   <para>Returns the final sorting layer value. See Also: GetLayerValueFromID.</para>
		/// </summary>
		/// <param name="name">The unique value of the sorting layer as returned by any renderer's sortingLayerID property.</param>
		/// <returns>
		///   <para>The final sorting value of the layer relative to other layers.</para>
		/// </returns>
		// Token: 0x0600084C RID: 2124
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetLayerValueFromName(string name);

		/// <summary>
		///   <para>Returns the id given the name. Will return 0 if an invalid name was given.</para>
		/// </summary>
		/// <param name="name">The name of the layer.</param>
		/// <returns>
		///   <para>The unique id of the layer with name.</para>
		/// </returns>
		// Token: 0x0600084D RID: 2125
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int NameToID(string name);

		/// <summary>
		///   <para>Returns the unique id of the layer. Will return "&lt;unknown layer&gt;" if an invalid id is given.</para>
		/// </summary>
		/// <param name="id">The unique id of the layer.</param>
		/// <returns>
		///   <para>The name of the layer with id or "&lt;unknown layer&gt;" for invalid id.</para>
		/// </returns>
		// Token: 0x0600084E RID: 2126
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string IDToName(int id);

		/// <summary>
		///   <para>Returns true if the id provided is a valid layer id.</para>
		/// </summary>
		/// <param name="id">The unique id of a layer.</param>
		/// <returns>
		///   <para>True if the id provided is valid and assigned to a layer.</para>
		/// </returns>
		// Token: 0x0600084F RID: 2127
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsValid(int id);

		// Token: 0x04000182 RID: 386
		private int m_Id;
	}
}
