using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	// Token: 0x0200002A RID: 42
	internal struct RenderBufferHelper
	{
		// Token: 0x06000219 RID: 537
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int GetLoadAction(out RenderBuffer b);

		// Token: 0x0600021A RID: 538
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void SetLoadAction(out RenderBuffer b, int a);

		// Token: 0x0600021B RID: 539
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int GetStoreAction(out RenderBuffer b);

		// Token: 0x0600021C RID: 540
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void SetStoreAction(out RenderBuffer b, int a);
	}
}
