using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UnityEngineInternal
{
	// Token: 0x020000DE RID: 222
	public sealed class GIDebugVisualisation
	{
		// Token: 0x06000D46 RID: 3398
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ResetRuntimeInputTextures();

		// Token: 0x06000D47 RID: 3399
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void PlayCycleMode();

		// Token: 0x06000D48 RID: 3400
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void PauseCycleMode();

		// Token: 0x06000D49 RID: 3401
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StopCycleMode();

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000D4A RID: 3402
		public static extern bool cycleMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000D4B RID: 3403
		public static extern bool pauseCycleMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000D4C RID: 3404
		// (set) Token: 0x06000D4D RID: 3405
		public static extern GITextureType texType
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06000D4E RID: 3406
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CycleSkipInstances(int skip);

		// Token: 0x06000D4F RID: 3407
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CycleSkipSystems(int skip);
	}
}
