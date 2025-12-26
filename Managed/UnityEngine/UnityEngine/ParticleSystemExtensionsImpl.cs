using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	// Token: 0x020000E5 RID: 229
	internal sealed class ParticleSystemExtensionsImpl
	{
		// Token: 0x06000DBD RID: 3517
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int GetSafeCollisionEventSize(ParticleSystem ps);

		// Token: 0x06000DBE RID: 3518
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int GetCollisionEvents(ParticleSystem ps, GameObject go, ParticleCollisionEvent[] collisionEvents);
	}
}
