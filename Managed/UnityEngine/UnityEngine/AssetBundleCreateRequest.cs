using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Asynchronous create request for an AssetBundle.</para>
	/// </summary>
	// Token: 0x02000002 RID: 2
	public sealed class AssetBundleCreateRequest : AsyncOperation
	{
		/// <summary>
		///   <para>Asset object being loaded (Read Only).</para>
		/// </summary>
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2
		public extern AssetBundle assetBundle
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x06000003 RID: 3
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void DisableCompatibilityChecks();
	}
}
