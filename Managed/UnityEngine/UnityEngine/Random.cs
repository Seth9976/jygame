using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Class for generating random data.</para>
	/// </summary>
	// Token: 0x020000CD RID: 205
	public sealed class Random
	{
		/// <summary>
		///   <para>Sets the seed for the random number generator.</para>
		/// </summary>
		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000C94 RID: 3220
		// (set) Token: 0x06000C95 RID: 3221
		public static extern int seed
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Returns a random float number between and min [inclusive] and max [inclusive] (Read Only).</para>
		/// </summary>
		/// <param name="min"></param>
		/// <param name="max"></param>
		// Token: 0x06000C96 RID: 3222
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Range(float min, float max);

		/// <summary>
		///   <para>Returns a random integer number between min [inclusive] and max [exclusive] (Read Only).</para>
		/// </summary>
		/// <param name="min"></param>
		/// <param name="max"></param>
		// Token: 0x06000C97 RID: 3223 RVA: 0x00006606 File Offset: 0x00004806
		public static int Range(int min, int max)
		{
			return Random.RandomRangeInt(min, max);
		}

		// Token: 0x06000C98 RID: 3224
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int RandomRangeInt(int min, int max);

		/// <summary>
		///   <para>Returns a random number between 0.0 [inclusive] and 1.0 [inclusive] (Read Only).</para>
		/// </summary>
		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000C99 RID: 3225
		public static extern float value
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns a random point inside a sphere with radius 1 (Read Only).</para>
		/// </summary>
		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000C9A RID: 3226 RVA: 0x00017760 File Offset: 0x00015960
		public static Vector3 insideUnitSphere
		{
			get
			{
				Vector3 vector;
				Random.INTERNAL_get_insideUnitSphere(out vector);
				return vector;
			}
		}

		// Token: 0x06000C9B RID: 3227
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_insideUnitSphere(out Vector3 value);

		// Token: 0x06000C9C RID: 3228
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetRandomUnitCircle(out Vector2 output);

		/// <summary>
		///   <para>Returns a random point inside a circle with radius 1 (Read Only).</para>
		/// </summary>
		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000C9D RID: 3229 RVA: 0x00017778 File Offset: 0x00015978
		public static Vector2 insideUnitCircle
		{
			get
			{
				Vector2 vector;
				Random.GetRandomUnitCircle(out vector);
				return vector;
			}
		}

		/// <summary>
		///   <para>Returns a random point on the surface of a sphere with radius 1 (Read Only).</para>
		/// </summary>
		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000C9E RID: 3230 RVA: 0x00017790 File Offset: 0x00015990
		public static Vector3 onUnitSphere
		{
			get
			{
				Vector3 vector;
				Random.INTERNAL_get_onUnitSphere(out vector);
				return vector;
			}
		}

		// Token: 0x06000C9F RID: 3231
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_onUnitSphere(out Vector3 value);

		/// <summary>
		///   <para>Returns a random rotation (Read Only).</para>
		/// </summary>
		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x000177A8 File Offset: 0x000159A8
		public static Quaternion rotation
		{
			get
			{
				Quaternion quaternion;
				Random.INTERNAL_get_rotation(out quaternion);
				return quaternion;
			}
		}

		// Token: 0x06000CA1 RID: 3233
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_rotation(out Quaternion value);

		/// <summary>
		///   <para>Returns a random rotation with uniform distribution (Read Only).</para>
		/// </summary>
		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000CA2 RID: 3234 RVA: 0x000177C0 File Offset: 0x000159C0
		public static Quaternion rotationUniform
		{
			get
			{
				Quaternion quaternion;
				Random.INTERNAL_get_rotationUniform(out quaternion);
				return quaternion;
			}
		}

		// Token: 0x06000CA3 RID: 3235
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_rotationUniform(out Quaternion value);

		// Token: 0x06000CA4 RID: 3236 RVA: 0x0000660F File Offset: 0x0000480F
		[Obsolete("Use Random.Range instead")]
		public static float RandomRange(float min, float max)
		{
			return Random.Range(min, max);
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00006618 File Offset: 0x00004818
		[Obsolete("Use Random.Range instead")]
		public static int RandomRange(int min, int max)
		{
			return Random.Range(min, max);
		}
	}
}
