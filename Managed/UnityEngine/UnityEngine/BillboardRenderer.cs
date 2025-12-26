using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Renders a billboard.</para>
	/// </summary>
	// Token: 0x020000D3 RID: 211
	public sealed class BillboardRenderer : Renderer
	{
		/// <summary>
		///   <para>The BillboardAsset to render.</para>
		/// </summary>
		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000CD4 RID: 3284
		// (set) Token: 0x06000CD5 RID: 3285
		public extern BillboardAsset billboard
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}
	}
}
