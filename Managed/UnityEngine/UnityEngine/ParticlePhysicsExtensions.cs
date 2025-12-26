using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Method extension for Physics in Particle System.</para>
	/// </summary>
	// Token: 0x020000E6 RID: 230
	public static class ParticlePhysicsExtensions
	{
		/// <summary>
		///   <para>Safe array size for use with ParticleSystem.GetCollisionEvents.</para>
		/// </summary>
		/// <param name="ps"></param>
		// Token: 0x06000DBF RID: 3519 RVA: 0x00006A77 File Offset: 0x00004C77
		public static int GetSafeCollisionEventSize(this ParticleSystem ps)
		{
			return ParticleSystemExtensionsImpl.GetSafeCollisionEventSize(ps);
		}

		/// <summary>
		///   <para>Get the particle collision events for a GameObject. Returns the number of events written to the array.</para>
		/// </summary>
		/// <param name="go">The GameObject for which to retrieve collision events.</param>
		/// <param name="collisionEvents">Array to write collision events to.</param>
		/// <param name="ps"></param>
		// Token: 0x06000DC0 RID: 3520 RVA: 0x00006A7F File Offset: 0x00004C7F
		public static int GetCollisionEvents(this ParticleSystem ps, GameObject go, ParticleCollisionEvent[] collisionEvents)
		{
			return ParticleSystemExtensionsImpl.GetCollisionEvents(ps, go, collisionEvents);
		}
	}
}
