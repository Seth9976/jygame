using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Avatar definition.</para>
	/// </summary>
	// Token: 0x0200019B RID: 411
	public sealed class Avatar : Object
	{
		// Token: 0x06001756 RID: 5974 RVA: 0x0000208E File Offset: 0x0000028E
		private Avatar()
		{
		}

		/// <summary>
		///   <para>Return true if this avatar is a valid mecanim avatar. It can be a generic avatar or a human avatar.</para>
		/// </summary>
		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06001757 RID: 5975
		public extern bool isValid
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Return true if this avatar is a valid human avatar.</para>
		/// </summary>
		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06001758 RID: 5976
		public extern bool isHuman
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x06001759 RID: 5977
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void SetMuscleMinMax(int muscleId, float min, float max);

		// Token: 0x0600175A RID: 5978
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void SetParameter(int parameterId, float value);

		// Token: 0x0600175B RID: 5979
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern float GetAxisLength(int humanId);

		// Token: 0x0600175C RID: 5980
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern Quaternion GetPreRotation(int humanId);

		// Token: 0x0600175D RID: 5981
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern Quaternion GetPostRotation(int humanId);

		// Token: 0x0600175E RID: 5982 RVA: 0x00008733 File Offset: 0x00006933
		internal Quaternion GetZYPostQ(int humanId, Quaternion parentQ, Quaternion q)
		{
			return Avatar.INTERNAL_CALL_GetZYPostQ(this, humanId, ref parentQ, ref q);
		}

		// Token: 0x0600175F RID: 5983
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Quaternion INTERNAL_CALL_GetZYPostQ(Avatar self, int humanId, ref Quaternion parentQ, ref Quaternion q);

		// Token: 0x06001760 RID: 5984 RVA: 0x00008740 File Offset: 0x00006940
		internal Quaternion GetZYRoll(int humanId, Vector3 uvw)
		{
			return Avatar.INTERNAL_CALL_GetZYRoll(this, humanId, ref uvw);
		}

		// Token: 0x06001761 RID: 5985
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Quaternion INTERNAL_CALL_GetZYRoll(Avatar self, int humanId, ref Vector3 uvw);

		// Token: 0x06001762 RID: 5986
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern Vector3 GetLimitSign(int humanId);
	}
}
