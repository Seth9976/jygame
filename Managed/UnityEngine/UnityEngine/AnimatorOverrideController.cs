using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Interface to control AnimatorOverrideController.</para>
	/// </summary>
	// Token: 0x0200016E RID: 366
	public sealed class AnimatorOverrideController : RuntimeAnimatorController
	{
		// Token: 0x06001551 RID: 5457 RVA: 0x00007E6D File Offset: 0x0000606D
		public AnimatorOverrideController()
		{
			AnimatorOverrideController.Internal_CreateAnimationSet(this);
		}

		// Token: 0x06001552 RID: 5458
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CreateAnimationSet([Writable] AnimatorOverrideController self);

		/// <summary>
		///   <para>The Controller that the AnimatorOverrideController overrides.</para>
		/// </summary>
		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06001553 RID: 5459
		// (set) Token: 0x06001554 RID: 5460
		public extern RuntimeAnimatorController runtimeAnimatorController
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x170005D8 RID: 1496
		public AnimationClip this[string name]
		{
			get
			{
				return this.Internal_GetClipByName(name, true);
			}
			set
			{
				this.Internal_SetClipByName(name, value);
			}
		}

		// Token: 0x06001557 RID: 5463
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern AnimationClip Internal_GetClipByName(string name, bool returnEffectiveClip);

		// Token: 0x06001558 RID: 5464
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_SetClipByName(string name, AnimationClip clip);

		// Token: 0x170005D9 RID: 1497
		public AnimationClip this[AnimationClip clip]
		{
			get
			{
				return this.Internal_GetClip(clip, true);
			}
			set
			{
				this.Internal_SetClip(clip, value);
			}
		}

		// Token: 0x0600155B RID: 5467
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern AnimationClip Internal_GetClip(AnimationClip originalClip, bool returnEffectiveClip);

		// Token: 0x0600155C RID: 5468
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_SetClip(AnimationClip originalClip, AnimationClip overrideClip);

		/// <summary>
		///   <para>Returns the list of orignal clip from the controller and their override clip.</para>
		/// </summary>
		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x0600155D RID: 5469 RVA: 0x0001A604 File Offset: 0x00018804
		// (set) Token: 0x0600155E RID: 5470 RVA: 0x0001A6B4 File Offset: 0x000188B4
		public AnimationClipPair[] clips
		{
			get
			{
				AnimationClip[] array = this.GetOriginalClips();
				Dictionary<AnimationClip, bool> dictionary = new Dictionary<AnimationClip, bool>(array.Length);
				foreach (AnimationClip animationClip in array)
				{
					dictionary[animationClip] = true;
				}
				array = new AnimationClip[dictionary.Count];
				dictionary.Keys.CopyTo(array, 0);
				AnimationClipPair[] array3 = new AnimationClipPair[array.Length];
				for (int j = 0; j < array.Length; j++)
				{
					array3[j] = new AnimationClipPair();
					array3[j].originalClip = array[j];
					array3[j].overrideClip = this.Internal_GetClip(array[j], false);
				}
				return array3;
			}
			set
			{
				for (int i = 0; i < value.Length; i++)
				{
					this.Internal_SetClip(value[i].originalClip, value[i].overrideClip);
				}
			}
		}

		// Token: 0x0600155F RID: 5471
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern AnimationClip[] GetOriginalClips();

		// Token: 0x06001560 RID: 5472
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern AnimationClip[] GetOverrideClips();
	}
}
