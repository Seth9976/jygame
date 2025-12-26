using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Base class for AnimationClips and BlendTrees.</para>
	/// </summary>
	// Token: 0x020000D1 RID: 209
	public class Motion : Object
	{
		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000CBA RID: 3258
		public extern float averageDuration
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000CBB RID: 3259
		public extern float averageAngularSpeed
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x00017828 File Offset: 0x00015A28
		public Vector3 averageSpeed
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_averageSpeed(out vector);
				return vector;
			}
		}

		// Token: 0x06000CBD RID: 3261
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_averageSpeed(out Vector3 value);

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000CBE RID: 3262
		public extern float apparentSpeed
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000CBF RID: 3263
		public extern bool isLooping
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000CC0 RID: 3264
		public extern bool legacy
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000CC1 RID: 3265
		public extern bool isHumanMotion
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x06000CC2 RID: 3266
		[Obsolete("ValidateIfRetargetable is not supported anymore. Use isHumanMotion instead.", true)]
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool ValidateIfRetargetable(bool val);

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000CC3 RID: 3267
		[Obsolete("isAnimatorMotion is not supported anymore. Use !legacy instead.", true)]
		public extern bool isAnimatorMotion
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}
	}
}
