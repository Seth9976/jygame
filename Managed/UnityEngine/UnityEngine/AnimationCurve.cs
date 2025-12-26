using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>A collection of curves form an AnimationClip.</para>
	/// </summary>
	// Token: 0x02000174 RID: 372
	[StructLayout(LayoutKind.Sequential)]
	public sealed class AnimationCurve
	{
		/// <summary>
		///   <para>Creates an animation curve from arbitrary number of keyframes.</para>
		/// </summary>
		/// <param name="keys"></param>
		// Token: 0x060015A0 RID: 5536 RVA: 0x00008057 File Offset: 0x00006257
		public AnimationCurve(params Keyframe[] keys)
		{
			this.Init(keys);
		}

		/// <summary>
		///   <para>Creates an empty animation curve.</para>
		/// </summary>
		// Token: 0x060015A1 RID: 5537 RVA: 0x00008066 File Offset: 0x00006266
		public AnimationCurve()
		{
			this.Init(null);
		}

		// Token: 0x060015A2 RID: 5538
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Cleanup();

		// Token: 0x060015A3 RID: 5539 RVA: 0x0001A798 File Offset: 0x00018998
		~AnimationCurve()
		{
			this.Cleanup();
		}

		/// <summary>
		///   <para>Evaluate the curve at time.</para>
		/// </summary>
		/// <param name="time">The time within the curve you want to evaluate (the horizontal axis in the curve graph).</param>
		/// <returns>
		///   <para>The value of the curve, at the point in time specified.</para>
		/// </returns>
		// Token: 0x060015A4 RID: 5540
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern float Evaluate(float time);

		/// <summary>
		///   <para>All keys defined in the animation curve.</para>
		/// </summary>
		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x060015A5 RID: 5541 RVA: 0x00008075 File Offset: 0x00006275
		// (set) Token: 0x060015A6 RID: 5542 RVA: 0x0000807D File Offset: 0x0000627D
		public Keyframe[] keys
		{
			get
			{
				return this.GetKeys();
			}
			set
			{
				this.SetKeys(value);
			}
		}

		/// <summary>
		///   <para>Add a new key to the curve.</para>
		/// </summary>
		/// <param name="time">The time at which to add the key (horizontal axis in the curve graph).</param>
		/// <param name="value">The value for the key (vertical axis in the curve graph).</param>
		/// <returns>
		///   <para>The index of the added key, or -1 if the key could not be added.</para>
		/// </returns>
		// Token: 0x060015A7 RID: 5543
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int AddKey(float time, float value);

		/// <summary>
		///   <para>Add a new key to the curve.</para>
		/// </summary>
		/// <param name="key">The key to add to the curve.</param>
		/// <returns>
		///   <para>The index of the added key, or -1 if the key could not be added.</para>
		/// </returns>
		// Token: 0x060015A8 RID: 5544 RVA: 0x00008086 File Offset: 0x00006286
		public int AddKey(Keyframe key)
		{
			return this.AddKey_Internal(key);
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x0000808F File Offset: 0x0000628F
		private int AddKey_Internal(Keyframe key)
		{
			return AnimationCurve.INTERNAL_CALL_AddKey_Internal(this, ref key);
		}

		// Token: 0x060015AA RID: 5546
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_AddKey_Internal(AnimationCurve self, ref Keyframe key);

		/// <summary>
		///   <para>Removes the keyframe at index and inserts key.</para>
		/// </summary>
		/// <param name="index">The index of the key to move.</param>
		/// <param name="key">The key (with its new time) to insert.</param>
		/// <returns>
		///   <para>The index of the keyframe after moving it.</para>
		/// </returns>
		// Token: 0x060015AB RID: 5547 RVA: 0x00008099 File Offset: 0x00006299
		public int MoveKey(int index, Keyframe key)
		{
			return AnimationCurve.INTERNAL_CALL_MoveKey(this, index, ref key);
		}

		// Token: 0x060015AC RID: 5548
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_MoveKey(AnimationCurve self, int index, ref Keyframe key);

		/// <summary>
		///   <para>Removes a key.</para>
		/// </summary>
		/// <param name="index">The index of the key to remove.</param>
		// Token: 0x060015AD RID: 5549
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RemoveKey(int index);

		// Token: 0x170005F7 RID: 1527
		public Keyframe this[int index]
		{
			get
			{
				return this.GetKey_Internal(index);
			}
		}

		/// <summary>
		///   <para>The number of keys in the curve. (Read Only)</para>
		/// </summary>
		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x060015AF RID: 5551
		public extern int length
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x060015B0 RID: 5552
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetKeys(Keyframe[] keys);

		// Token: 0x060015B1 RID: 5553
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Keyframe GetKey_Internal(int index);

		// Token: 0x060015B2 RID: 5554
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Keyframe[] GetKeys();

		/// <summary>
		///   <para>Smooth the in and out tangents of the keyframe at index.</para>
		/// </summary>
		/// <param name="index">The index of the keyframe to be smoothed.</param>
		/// <param name="weight">The smoothing weight to apply to the keyframe's tangents.</param>
		// Token: 0x060015B3 RID: 5555
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SmoothTangents(int index, float weight);

		/// <summary>
		///   <para>A straight Line starting at timeStart, valueStart and ending at timeEnd, valueEnd.</para>
		/// </summary>
		/// <param name="timeStart">The start time for the linear curve.</param>
		/// <param name="valueStart">The start value for the linear curve.</param>
		/// <param name="timeEnd">The end time for the linear curve.</param>
		/// <param name="valueEnd">The end value for the linear curve.</param>
		/// <returns>
		///   <para>The (straight) curve created from the values specified.</para>
		/// </returns>
		// Token: 0x060015B4 RID: 5556 RVA: 0x0001A7C8 File Offset: 0x000189C8
		public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd)
		{
			float num = (valueEnd - valueStart) / (timeEnd - timeStart);
			Keyframe[] array = new Keyframe[]
			{
				new Keyframe(timeStart, valueStart, 0f, num),
				new Keyframe(timeEnd, valueEnd, num, 0f)
			};
			return new AnimationCurve(array);
		}

		/// <summary>
		///   <para>Creates an ease-in and out curve starting at timeStart, valueStart and ending at timeEnd, valueEnd.</para>
		/// </summary>
		/// <param name="timeStart">The start time for the ease curve.</param>
		/// <param name="valueStart">The start value for the ease curve.</param>
		/// <param name="timeEnd">The end time for the ease curve.</param>
		/// <param name="valueEnd">The end value for the ease curve.</param>
		/// <returns>
		///   <para>The ease-in and out curve generated from the specified values.</para>
		/// </returns>
		// Token: 0x060015B5 RID: 5557 RVA: 0x0001A81C File Offset: 0x00018A1C
		public static AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd)
		{
			Keyframe[] array = new Keyframe[]
			{
				new Keyframe(timeStart, valueStart, 0f, 0f),
				new Keyframe(timeEnd, valueEnd, 0f, 0f)
			};
			return new AnimationCurve(array);
		}

		/// <summary>
		///   <para>The behaviour of the animation before the first keyframe.</para>
		/// </summary>
		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x060015B6 RID: 5558
		// (set) Token: 0x060015B7 RID: 5559
		public extern WrapMode preWrapMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The behaviour of the animation after the last keyframe.</para>
		/// </summary>
		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x060015B8 RID: 5560
		// (set) Token: 0x060015B9 RID: 5561
		public extern WrapMode postWrapMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x060015BA RID: 5562
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Init(Keyframe[] keys);

		// Token: 0x04000413 RID: 1043
		internal IntPtr m_Ptr;
	}
}
