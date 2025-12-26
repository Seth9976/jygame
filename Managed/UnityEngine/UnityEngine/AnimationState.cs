using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>The AnimationState gives full control over animation blending.</para>
	/// </summary>
	// Token: 0x0200017C RID: 380
	public sealed class AnimationState : TrackedReference
	{
		/// <summary>
		///   <para>Enables / disables the animation.</para>
		/// </summary>
		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001600 RID: 5632
		// (set) Token: 0x06001601 RID: 5633
		public extern bool enabled
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The weight of animation.</para>
		/// </summary>
		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001602 RID: 5634
		// (set) Token: 0x06001603 RID: 5635
		public extern float weight
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Wrapping mode of the animation.</para>
		/// </summary>
		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001604 RID: 5636
		// (set) Token: 0x06001605 RID: 5637
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
		///   <para>The current time of the animation.</para>
		/// </summary>
		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001606 RID: 5638
		// (set) Token: 0x06001607 RID: 5639
		public extern float time
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The normalized time of the animation.</para>
		/// </summary>
		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001608 RID: 5640
		// (set) Token: 0x06001609 RID: 5641
		public extern float normalizedTime
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The playback speed of the animation. 1 is normal playback speed.</para>
		/// </summary>
		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x0600160A RID: 5642
		// (set) Token: 0x0600160B RID: 5643
		public extern float speed
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The normalized playback speed.</para>
		/// </summary>
		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x0600160C RID: 5644
		// (set) Token: 0x0600160D RID: 5645
		public extern float normalizedSpeed
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The length of the animation clip in seconds.</para>
		/// </summary>
		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x0600160E RID: 5646
		public extern float length
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x0600160F RID: 5647
		// (set) Token: 0x06001610 RID: 5648
		public extern int layer
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The clip that is being played by this animation state.</para>
		/// </summary>
		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001611 RID: 5649
		public extern AnimationClip clip
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Adds a transform which should be animated. This allows you to reduce the number of animations you have to create.</para>
		/// </summary>
		/// <param name="mix"></param>
		/// <param name="recursive"></param>
		// Token: 0x06001612 RID: 5650
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void AddMixingTransform(Transform mix, [DefaultValue("true")] bool recursive);

		/// <summary>
		///   <para>Adds a transform which should be animated. This allows you to reduce the number of animations you have to create.</para>
		/// </summary>
		/// <param name="mix"></param>
		/// <param name="recursive"></param>
		// Token: 0x06001613 RID: 5651 RVA: 0x0001AA34 File Offset: 0x00018C34
		[ExcludeFromDocs]
		public void AddMixingTransform(Transform mix)
		{
			bool flag = true;
			this.AddMixingTransform(mix, flag);
		}

		/// <summary>
		///   <para>Removes a transform which should be animated.</para>
		/// </summary>
		/// <param name="mix"></param>
		// Token: 0x06001614 RID: 5652
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RemoveMixingTransform(Transform mix);

		/// <summary>
		///   <para>The name of the animation.</para>
		/// </summary>
		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001615 RID: 5653
		// (set) Token: 0x06001616 RID: 5654
		public extern string name
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Which blend mode should be used?</para>
		/// </summary>
		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06001617 RID: 5655
		// (set) Token: 0x06001618 RID: 5656
		public extern AnimationBlendMode blendMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}
	}
}
