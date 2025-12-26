using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Tree Component for the tree creator.</para>
	/// </summary>
	// Token: 0x020001AC RID: 428
	public sealed class Tree : Component
	{
		/// <summary>
		///   <para>Data asociated to the Tree.</para>
		/// </summary>
		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x060018CF RID: 6351
		// (set) Token: 0x060018D0 RID: 6352
		public extern ScriptableObject data
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Tells if there is wind data exported from SpeedTree are saved on this component.</para>
		/// </summary>
		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x060018D1 RID: 6353
		public extern bool hasSpeedTreeWind
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}
	}
}
