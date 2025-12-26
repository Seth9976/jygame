using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Stores keyframe based animations.</para>
	/// </summary>
	// Token: 0x02000172 RID: 370
	public sealed class AnimationClip : Motion
	{
		/// <summary>
		///   <para>Creates a new animation clip.</para>
		/// </summary>
		// Token: 0x06001578 RID: 5496 RVA: 0x00007F87 File Offset: 0x00006187
		public AnimationClip()
		{
			AnimationClip.Internal_CreateAnimationClip(this);
		}

		/// <summary>
		///   <para>Samples an animation at a given time for any animated properties.</para>
		/// </summary>
		/// <param name="go">The animated game object.</param>
		/// <param name="time">The time to sample an animation.</param>
		// Token: 0x06001579 RID: 5497
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SampleAnimation(GameObject go, float time);

		// Token: 0x0600157A RID: 5498
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CreateAnimationClip([Writable] AnimationClip self);

		/// <summary>
		///   <para>Animation length in seconds. (Read Only)</para>
		/// </summary>
		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x0600157B RID: 5499
		public extern float length
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x0600157C RID: 5500
		internal extern float startTime
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x0600157D RID: 5501
		internal extern float stopTime
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Frame rate at which keyframes are sampled. (Read Only)</para>
		/// </summary>
		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x0600157E RID: 5502
		// (set) Token: 0x0600157F RID: 5503
		public extern float frameRate
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Assigns the curve to animate a specific property.</para>
		/// </summary>
		/// <param name="relativePath">Path to the game object this curve applies to. relativePath is formatted similar to a pathname, e.g. "rootspineleftArm".
		/// If relativePath is empty it refers to the game object the animation clip is attached to.</param>
		/// <param name="type">The class type of the component that is animated.</param>
		/// <param name="propertyName">The name or path to the property being animated.</param>
		/// <param name="curve">The animation curve.</param>
		// Token: 0x06001580 RID: 5504
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetCurve(string relativePath, Type type, string propertyName, AnimationCurve curve);

		/// <summary>
		///   <para>In order to insure better interpolation of quaternions, call this function after you are finished setting animation curves.</para>
		/// </summary>
		// Token: 0x06001581 RID: 5505 RVA: 0x00007F95 File Offset: 0x00006195
		public void EnsureQuaternionContinuity()
		{
			AnimationClip.INTERNAL_CALL_EnsureQuaternionContinuity(this);
		}

		// Token: 0x06001582 RID: 5506
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_EnsureQuaternionContinuity(AnimationClip self);

		/// <summary>
		///   <para>Clears all curves from the clip.</para>
		/// </summary>
		// Token: 0x06001583 RID: 5507 RVA: 0x00007F9D File Offset: 0x0000619D
		public void ClearCurves()
		{
			AnimationClip.INTERNAL_CALL_ClearCurves(this);
		}

		// Token: 0x06001584 RID: 5508
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ClearCurves(AnimationClip self);

		/// <summary>
		///   <para>Sets the default wrap mode used in the animation state.</para>
		/// </summary>
		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001585 RID: 5509
		// (set) Token: 0x06001586 RID: 5510
		public extern WrapMode wrapMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>AABB of this Animation Clip in local space of Animation component that it is attached too.</para>
		/// </summary>
		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06001587 RID: 5511 RVA: 0x0001A780 File Offset: 0x00018980
		// (set) Token: 0x06001588 RID: 5512 RVA: 0x00007FA5 File Offset: 0x000061A5
		public Bounds localBounds
		{
			get
			{
				Bounds bounds;
				this.INTERNAL_get_localBounds(out bounds);
				return bounds;
			}
			set
			{
				this.INTERNAL_set_localBounds(ref value);
			}
		}

		// Token: 0x06001589 RID: 5513
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_localBounds(out Bounds value);

		// Token: 0x0600158A RID: 5514
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_localBounds(ref Bounds value);

		/// <summary>
		///   <para>Set to true if the AnimationClip will be used with the Legacy Animation component ( instead of the Animator ).</para>
		/// </summary>
		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x0600158B RID: 5515
		// (set) Token: 0x0600158C RID: 5516
		public new extern bool legacy
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Returns true if the animation contains curve that drives a humanoid rig.</para>
		/// </summary>
		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x0600158D RID: 5517
		public extern bool humanMotion
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Adds an animation event to the clip.</para>
		/// </summary>
		/// <param name="evt">AnimationEvent to add.</param>
		// Token: 0x0600158E RID: 5518 RVA: 0x00007FAF File Offset: 0x000061AF
		public void AddEvent(AnimationEvent evt)
		{
			this.AddEventInternal(evt);
		}

		// Token: 0x0600158F RID: 5519
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void AddEventInternal(object evt);

		/// <summary>
		///   <para>Animation Events for this animation clip.</para>
		/// </summary>
		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06001590 RID: 5520 RVA: 0x00007FB8 File Offset: 0x000061B8
		// (set) Token: 0x06001591 RID: 5521 RVA: 0x00007FC5 File Offset: 0x000061C5
		public AnimationEvent[] events
		{
			get
			{
				return (AnimationEvent[])this.GetEventsInternal();
			}
			set
			{
				this.SetEventsInternal(value);
			}
		}

		// Token: 0x06001592 RID: 5522
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void SetEventsInternal(Array value);

		// Token: 0x06001593 RID: 5523
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern Array GetEventsInternal();
	}
}
