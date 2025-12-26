using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>The animation component is used to play back animations.</para>
	/// </summary>
	// Token: 0x0200017A RID: 378
	public sealed class Animation : Behaviour, IEnumerable
	{
		/// <summary>
		///   <para>The default animation.</para>
		/// </summary>
		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x060015BC RID: 5564
		// (set) Token: 0x060015BD RID: 5565
		public extern AnimationClip clip
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Should the default animation clip (the Animation.clip property) automatically start playing on startup?</para>
		/// </summary>
		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x060015BE RID: 5566
		// (set) Token: 0x060015BF RID: 5567
		public extern bool playAutomatically
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>How should time beyond the playback range of the clip be treated?</para>
		/// </summary>
		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x060015C0 RID: 5568
		// (set) Token: 0x060015C1 RID: 5569
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
		///   <para>Stops all playing animations that were started with this Animation.</para>
		/// </summary>
		// Token: 0x060015C2 RID: 5570 RVA: 0x000080AD File Offset: 0x000062AD
		public void Stop()
		{
			Animation.INTERNAL_CALL_Stop(this);
		}

		// Token: 0x060015C3 RID: 5571
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Stop(Animation self);

		/// <summary>
		///   <para>Stops an animation named name.</para>
		/// </summary>
		/// <param name="name"></param>
		// Token: 0x060015C4 RID: 5572 RVA: 0x000080B5 File Offset: 0x000062B5
		public void Stop(string name)
		{
			this.Internal_StopByName(name);
		}

		// Token: 0x060015C5 RID: 5573
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_StopByName(string name);

		/// <summary>
		///   <para>Rewinds the animation named name.</para>
		/// </summary>
		/// <param name="name"></param>
		// Token: 0x060015C6 RID: 5574 RVA: 0x000080BE File Offset: 0x000062BE
		public void Rewind(string name)
		{
			this.Internal_RewindByName(name);
		}

		// Token: 0x060015C7 RID: 5575
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_RewindByName(string name);

		/// <summary>
		///   <para>Rewinds all animations.</para>
		/// </summary>
		// Token: 0x060015C8 RID: 5576 RVA: 0x000080C7 File Offset: 0x000062C7
		public void Rewind()
		{
			Animation.INTERNAL_CALL_Rewind(this);
		}

		// Token: 0x060015C9 RID: 5577
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Rewind(Animation self);

		/// <summary>
		///   <para>Samples animations at the current state.</para>
		/// </summary>
		// Token: 0x060015CA RID: 5578 RVA: 0x000080CF File Offset: 0x000062CF
		public void Sample()
		{
			Animation.INTERNAL_CALL_Sample(this);
		}

		// Token: 0x060015CB RID: 5579
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Sample(Animation self);

		/// <summary>
		///   <para>Are we playing any animations?</para>
		/// </summary>
		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x060015CC RID: 5580
		public extern bool isPlaying
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Is the animation named name playing?</para>
		/// </summary>
		/// <param name="name"></param>
		// Token: 0x060015CD RID: 5581
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsPlaying(string name);

		// Token: 0x170005FF RID: 1535
		public AnimationState this[string name]
		{
			get
			{
				return this.GetState(name);
			}
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x0001A870 File Offset: 0x00018A70
		[ExcludeFromDocs]
		public bool Play()
		{
			PlayMode playMode = PlayMode.StopSameLayer;
			return this.Play(playMode);
		}

		/// <summary>
		///   <para>Plays an animation without any blending.</para>
		/// </summary>
		/// <param name="mode"></param>
		/// <param name="animation"></param>
		// Token: 0x060015D0 RID: 5584 RVA: 0x000080E0 File Offset: 0x000062E0
		public bool Play([DefaultValue("PlayMode.StopSameLayer")] PlayMode mode)
		{
			return this.PlayDefaultAnimation(mode);
		}

		/// <summary>
		///   <para>Plays an animation without any blending.</para>
		/// </summary>
		/// <param name="mode"></param>
		/// <param name="animation"></param>
		// Token: 0x060015D1 RID: 5585
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool Play(string animation, [DefaultValue("PlayMode.StopSameLayer")] PlayMode mode);

		/// <summary>
		///   <para>Plays an animation without any blending.</para>
		/// </summary>
		/// <param name="mode"></param>
		/// <param name="animation"></param>
		// Token: 0x060015D2 RID: 5586 RVA: 0x0001A888 File Offset: 0x00018A88
		[ExcludeFromDocs]
		public bool Play(string animation)
		{
			PlayMode playMode = PlayMode.StopSameLayer;
			return this.Play(animation, playMode);
		}

		/// <summary>
		///   <para>Fades the animation with name animation in over a period of time seconds and fades other animations out.</para>
		/// </summary>
		/// <param name="animation"></param>
		/// <param name="fadeLength"></param>
		/// <param name="mode"></param>
		// Token: 0x060015D3 RID: 5587
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void CrossFade(string animation, [DefaultValue("0.3F")] float fadeLength, [DefaultValue("PlayMode.StopSameLayer")] PlayMode mode);

		/// <summary>
		///   <para>Fades the animation with name animation in over a period of time seconds and fades other animations out.</para>
		/// </summary>
		/// <param name="animation"></param>
		/// <param name="fadeLength"></param>
		/// <param name="mode"></param>
		// Token: 0x060015D4 RID: 5588 RVA: 0x0001A8A0 File Offset: 0x00018AA0
		[ExcludeFromDocs]
		public void CrossFade(string animation, float fadeLength)
		{
			PlayMode playMode = PlayMode.StopSameLayer;
			this.CrossFade(animation, fadeLength, playMode);
		}

		/// <summary>
		///   <para>Fades the animation with name animation in over a period of time seconds and fades other animations out.</para>
		/// </summary>
		/// <param name="animation"></param>
		/// <param name="fadeLength"></param>
		/// <param name="mode"></param>
		// Token: 0x060015D5 RID: 5589 RVA: 0x0001A8B8 File Offset: 0x00018AB8
		[ExcludeFromDocs]
		public void CrossFade(string animation)
		{
			PlayMode playMode = PlayMode.StopSameLayer;
			float num = 0.3f;
			this.CrossFade(animation, num, playMode);
		}

		/// <summary>
		///   <para>Blends the animation named animation towards targetWeight over the next time seconds.</para>
		/// </summary>
		/// <param name="animation"></param>
		/// <param name="targetWeight"></param>
		/// <param name="fadeLength"></param>
		// Token: 0x060015D6 RID: 5590
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Blend(string animation, [DefaultValue("1.0F")] float targetWeight, [DefaultValue("0.3F")] float fadeLength);

		/// <summary>
		///   <para>Blends the animation named animation towards targetWeight over the next time seconds.</para>
		/// </summary>
		/// <param name="animation"></param>
		/// <param name="targetWeight"></param>
		/// <param name="fadeLength"></param>
		// Token: 0x060015D7 RID: 5591 RVA: 0x0001A8D8 File Offset: 0x00018AD8
		[ExcludeFromDocs]
		public void Blend(string animation, float targetWeight)
		{
			float num = 0.3f;
			this.Blend(animation, targetWeight, num);
		}

		/// <summary>
		///   <para>Blends the animation named animation towards targetWeight over the next time seconds.</para>
		/// </summary>
		/// <param name="animation"></param>
		/// <param name="targetWeight"></param>
		/// <param name="fadeLength"></param>
		// Token: 0x060015D8 RID: 5592 RVA: 0x0001A8F4 File Offset: 0x00018AF4
		[ExcludeFromDocs]
		public void Blend(string animation)
		{
			float num = 0.3f;
			float num2 = 1f;
			this.Blend(animation, num2, num);
		}

		/// <summary>
		///   <para>Cross fades an animation after previous animations has finished playing.</para>
		/// </summary>
		/// <param name="animation"></param>
		/// <param name="fadeLength"></param>
		/// <param name="queue"></param>
		/// <param name="mode"></param>
		// Token: 0x060015D9 RID: 5593
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern AnimationState CrossFadeQueued(string animation, [DefaultValue("0.3F")] float fadeLength, [DefaultValue("QueueMode.CompleteOthers")] QueueMode queue, [DefaultValue("PlayMode.StopSameLayer")] PlayMode mode);

		/// <summary>
		///   <para>Cross fades an animation after previous animations has finished playing.</para>
		/// </summary>
		/// <param name="animation"></param>
		/// <param name="fadeLength"></param>
		/// <param name="queue"></param>
		/// <param name="mode"></param>
		// Token: 0x060015DA RID: 5594 RVA: 0x0001A918 File Offset: 0x00018B18
		[ExcludeFromDocs]
		public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue)
		{
			PlayMode playMode = PlayMode.StopSameLayer;
			return this.CrossFadeQueued(animation, fadeLength, queue, playMode);
		}

		/// <summary>
		///   <para>Cross fades an animation after previous animations has finished playing.</para>
		/// </summary>
		/// <param name="animation"></param>
		/// <param name="fadeLength"></param>
		/// <param name="queue"></param>
		/// <param name="mode"></param>
		// Token: 0x060015DB RID: 5595 RVA: 0x0001A934 File Offset: 0x00018B34
		[ExcludeFromDocs]
		public AnimationState CrossFadeQueued(string animation, float fadeLength)
		{
			PlayMode playMode = PlayMode.StopSameLayer;
			QueueMode queueMode = QueueMode.CompleteOthers;
			return this.CrossFadeQueued(animation, fadeLength, queueMode, playMode);
		}

		/// <summary>
		///   <para>Cross fades an animation after previous animations has finished playing.</para>
		/// </summary>
		/// <param name="animation"></param>
		/// <param name="fadeLength"></param>
		/// <param name="queue"></param>
		/// <param name="mode"></param>
		// Token: 0x060015DC RID: 5596 RVA: 0x0001A950 File Offset: 0x00018B50
		[ExcludeFromDocs]
		public AnimationState CrossFadeQueued(string animation)
		{
			PlayMode playMode = PlayMode.StopSameLayer;
			QueueMode queueMode = QueueMode.CompleteOthers;
			float num = 0.3f;
			return this.CrossFadeQueued(animation, num, queueMode, playMode);
		}

		/// <summary>
		///   <para>Plays an animation after previous animations has finished playing.</para>
		/// </summary>
		/// <param name="animation"></param>
		/// <param name="queue"></param>
		/// <param name="mode"></param>
		// Token: 0x060015DD RID: 5597
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern AnimationState PlayQueued(string animation, [DefaultValue("QueueMode.CompleteOthers")] QueueMode queue, [DefaultValue("PlayMode.StopSameLayer")] PlayMode mode);

		/// <summary>
		///   <para>Plays an animation after previous animations has finished playing.</para>
		/// </summary>
		/// <param name="animation"></param>
		/// <param name="queue"></param>
		/// <param name="mode"></param>
		// Token: 0x060015DE RID: 5598 RVA: 0x0001A974 File Offset: 0x00018B74
		[ExcludeFromDocs]
		public AnimationState PlayQueued(string animation, QueueMode queue)
		{
			PlayMode playMode = PlayMode.StopSameLayer;
			return this.PlayQueued(animation, queue, playMode);
		}

		/// <summary>
		///   <para>Plays an animation after previous animations has finished playing.</para>
		/// </summary>
		/// <param name="animation"></param>
		/// <param name="queue"></param>
		/// <param name="mode"></param>
		// Token: 0x060015DF RID: 5599 RVA: 0x0001A98C File Offset: 0x00018B8C
		[ExcludeFromDocs]
		public AnimationState PlayQueued(string animation)
		{
			PlayMode playMode = PlayMode.StopSameLayer;
			QueueMode queueMode = QueueMode.CompleteOthers;
			return this.PlayQueued(animation, queueMode, playMode);
		}

		/// <summary>
		///   <para>Adds a clip to the animation with name newName.</para>
		/// </summary>
		/// <param name="clip"></param>
		/// <param name="newName"></param>
		// Token: 0x060015E0 RID: 5600 RVA: 0x000080E9 File Offset: 0x000062E9
		public void AddClip(AnimationClip clip, string newName)
		{
			this.AddClip(clip, newName, int.MinValue, int.MaxValue);
		}

		/// <summary>
		///   <para>Adds clip to the only play between firstFrame and lastFrame. The new clip will also be added to the animation with name newName.</para>
		/// </summary>
		/// <param name="addLoopFrame">Should an extra frame be inserted at the end that matches the first frame? Turn this on if you are making a looping animation.</param>
		/// <param name="clip"></param>
		/// <param name="newName"></param>
		/// <param name="firstFrame"></param>
		/// <param name="lastFrame"></param>
		// Token: 0x060015E1 RID: 5601
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame, [DefaultValue("false")] bool addLoopFrame);

		/// <summary>
		///   <para>Adds clip to the only play between firstFrame and lastFrame. The new clip will also be added to the animation with name newName.</para>
		/// </summary>
		/// <param name="addLoopFrame">Should an extra frame be inserted at the end that matches the first frame? Turn this on if you are making a looping animation.</param>
		/// <param name="clip"></param>
		/// <param name="newName"></param>
		/// <param name="firstFrame"></param>
		/// <param name="lastFrame"></param>
		// Token: 0x060015E2 RID: 5602 RVA: 0x0001A9A8 File Offset: 0x00018BA8
		[ExcludeFromDocs]
		public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame)
		{
			bool flag = false;
			this.AddClip(clip, newName, firstFrame, lastFrame, flag);
		}

		/// <summary>
		///   <para>Remove clip from the animation list.</para>
		/// </summary>
		/// <param name="clip"></param>
		// Token: 0x060015E3 RID: 5603
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RemoveClip(AnimationClip clip);

		/// <summary>
		///   <para>Remove clip from the animation list.</para>
		/// </summary>
		/// <param name="clipName"></param>
		// Token: 0x060015E4 RID: 5604 RVA: 0x000080FD File Offset: 0x000062FD
		public void RemoveClip(string clipName)
		{
			this.RemoveClip2(clipName);
		}

		/// <summary>
		///   <para>Get the number of clips currently assigned to this animation.</para>
		/// </summary>
		// Token: 0x060015E5 RID: 5605
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetClipCount();

		// Token: 0x060015E6 RID: 5606
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void RemoveClip2(string clipName);

		// Token: 0x060015E7 RID: 5607
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool PlayDefaultAnimation(PlayMode mode);

		// Token: 0x060015E8 RID: 5608 RVA: 0x000080E0 File Offset: 0x000062E0
		[Obsolete("use PlayMode instead of AnimationPlayMode.")]
		public bool Play(AnimationPlayMode mode)
		{
			return this.PlayDefaultAnimation((PlayMode)mode);
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x00008106 File Offset: 0x00006306
		[Obsolete("use PlayMode instead of AnimationPlayMode.")]
		public bool Play(string animation, AnimationPlayMode mode)
		{
			return this.Play(animation, (PlayMode)mode);
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00008110 File Offset: 0x00006310
		public void SyncLayer(int layer)
		{
			Animation.INTERNAL_CALL_SyncLayer(this, layer);
		}

		// Token: 0x060015EB RID: 5611
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SyncLayer(Animation self, int layer);

		// Token: 0x060015EC RID: 5612 RVA: 0x00008119 File Offset: 0x00006319
		public IEnumerator GetEnumerator()
		{
			return new Animation.Enumerator(this);
		}

		// Token: 0x060015ED RID: 5613
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern AnimationState GetState(string name);

		// Token: 0x060015EE RID: 5614
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern AnimationState GetStateAtIndex(int index);

		// Token: 0x060015EF RID: 5615
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern int GetStateCount();

		// Token: 0x060015F0 RID: 5616 RVA: 0x0001A9C4 File Offset: 0x00018BC4
		public AnimationClip GetClip(string name)
		{
			AnimationState state = this.GetState(name);
			if (state)
			{
				return state.clip;
			}
			return null;
		}

		/// <summary>
		///   <para>When turned on, animations will be executed in the physics loop. This is only useful in conjunction with kinematic rigidbodies.</para>
		/// </summary>
		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x060015F1 RID: 5617
		// (set) Token: 0x060015F2 RID: 5618
		public extern bool animatePhysics
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>When turned on, Unity might stop animating if it thinks that the results of the animation won't be visible to the user.</para>
		/// </summary>
		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x060015F3 RID: 5619
		// (set) Token: 0x060015F4 RID: 5620
		[Obsolete("Use cullingType instead")]
		public extern bool animateOnlyIfVisible
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Controls culling of this Animation component.</para>
		/// </summary>
		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x060015F5 RID: 5621
		// (set) Token: 0x060015F6 RID: 5622
		public extern AnimationCullingType cullingType
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>AABB of this Animation animation component in local space.</para>
		/// </summary>
		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x060015F7 RID: 5623 RVA: 0x0001A9EC File Offset: 0x00018BEC
		// (set) Token: 0x060015F8 RID: 5624 RVA: 0x00008121 File Offset: 0x00006321
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

		// Token: 0x060015F9 RID: 5625
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_localBounds(out Bounds value);

		// Token: 0x060015FA RID: 5626
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_localBounds(ref Bounds value);

		// Token: 0x0200017B RID: 379
		private sealed class Enumerator : IEnumerator
		{
			// Token: 0x060015FB RID: 5627 RVA: 0x0000812B File Offset: 0x0000632B
			internal Enumerator(Animation outer)
			{
				this.m_Outer = outer;
			}

			// Token: 0x17000604 RID: 1540
			// (get) Token: 0x060015FC RID: 5628 RVA: 0x00008141 File Offset: 0x00006341
			public object Current
			{
				get
				{
					return this.m_Outer.GetStateAtIndex(this.m_CurrentIndex);
				}
			}

			// Token: 0x060015FD RID: 5629 RVA: 0x0001AA04 File Offset: 0x00018C04
			public bool MoveNext()
			{
				int stateCount = this.m_Outer.GetStateCount();
				this.m_CurrentIndex++;
				return this.m_CurrentIndex < stateCount;
			}

			// Token: 0x060015FE RID: 5630 RVA: 0x00008154 File Offset: 0x00006354
			public void Reset()
			{
				this.m_CurrentIndex = -1;
			}

			// Token: 0x04000426 RID: 1062
			private Animation m_Outer;

			// Token: 0x04000427 RID: 1063
			private int m_CurrentIndex = -1;
		}
	}
}
