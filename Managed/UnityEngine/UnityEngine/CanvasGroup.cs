using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>A Canvas placable element that can be used to modify children Alpha, Raycasting, Enabled state.</para>
	/// </summary>
	// Token: 0x020001BD RID: 445
	public sealed class CanvasGroup : Component, ICanvasRaycastFilter
	{
		/// <summary>
		///   <para>Set the alpha of the group.</para>
		/// </summary>
		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x0600199A RID: 6554
		// (set) Token: 0x0600199B RID: 6555
		public extern float alpha
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Is the group interactable (are the elements beneath the group enabled).</para>
		/// </summary>
		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x0600199C RID: 6556
		// (set) Token: 0x0600199D RID: 6557
		public extern bool interactable
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Does this group block raycasting (allow collision).</para>
		/// </summary>
		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x0600199E RID: 6558
		// (set) Token: 0x0600199F RID: 6559
		public extern bool blocksRaycasts
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Should the group ignore parent groups?</para>
		/// </summary>
		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x060019A0 RID: 6560
		// (set) Token: 0x060019A1 RID: 6561
		public extern bool ignoreParentGroups
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Returns true if the Group allows raycasts.</para>
		/// </summary>
		/// <param name="sp"></param>
		/// <param name="eventCamera"></param>
		// Token: 0x060019A2 RID: 6562 RVA: 0x0000907D File Offset: 0x0000727D
		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			return this.blocksRaycasts;
		}
	}
}
