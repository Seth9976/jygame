using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>A component can be designed drive a RectTransform. The DrivenRectTransformTracker struct is used to specify which RectTransforms it is driving.</para>
	/// </summary>
	// Token: 0x02000077 RID: 119
	public struct DrivenRectTransformTracker
	{
		/// <summary>
		///   <para>Add a RectTransform to be driven.</para>
		/// </summary>
		/// <param name="driver">The object to drive properties.</param>
		/// <param name="rectTransform">The RectTransform to be driven.</param>
		/// <param name="drivenProperties">The properties to be driven.</param>
		// Token: 0x06000731 RID: 1841 RVA: 0x00002753 File Offset: 0x00000953
		public void Add(Object driver, RectTransform rectTransform, DrivenTransformProperties drivenProperties)
		{
		}

		/// <summary>
		///   <para>Clear the list of RectTransforms being driven.</para>
		/// </summary>
		// Token: 0x06000732 RID: 1842 RVA: 0x00002753 File Offset: 0x00000953
		public void Clear()
		{
		}
	}
}
