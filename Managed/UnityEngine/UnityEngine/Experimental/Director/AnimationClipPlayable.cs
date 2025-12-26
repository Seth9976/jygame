using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Experimental.Director
{
	/// <summary>
	///   <para>Playable that plays an AnimationClip. Can be used as an input to an AnimationPlayable.</para>
	/// </summary>
	// Token: 0x0200019E RID: 414
	public sealed class AnimationClipPlayable : AnimationPlayable
	{
		// Token: 0x06001774 RID: 6004 RVA: 0x00008785 File Offset: 0x00006985
		public AnimationClipPlayable(AnimationClip clip)
			: base(false)
		{
			this.m_Ptr = IntPtr.Zero;
			this.InstantiateEnginePlayable(clip);
		}

		// Token: 0x06001775 RID: 6005
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void InstantiateEnginePlayable(AnimationClip clip);

		/// <summary>
		///   <para>AnimationClip played by this playable.</para>
		/// </summary>
		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06001776 RID: 6006
		public extern AnimationClip clip
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x000087A0 File Offset: 0x000069A0
		public override int AddInput(AnimationPlayable source)
		{
			Debug.LogError("AnimationClipPlayable doesn't support adding inputs");
			return -1;
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x000087AD File Offset: 0x000069AD
		public override bool SetInput(AnimationPlayable source, int index)
		{
			Debug.LogError("AnimationClipPlayable doesn't support setting inputs");
			return false;
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x000087AD File Offset: 0x000069AD
		public override bool SetInputs(IEnumerable<AnimationPlayable> sources)
		{
			Debug.LogError("AnimationClipPlayable doesn't support setting inputs");
			return false;
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x000087BA File Offset: 0x000069BA
		public override bool RemoveInput(int index)
		{
			Debug.LogError("AnimationClipPlayable doesn't support removing inputs");
			return false;
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x000087BA File Offset: 0x000069BA
		public override bool RemoveInput(AnimationPlayable playable)
		{
			Debug.LogError("AnimationClipPlayable doesn't support removing inputs");
			return false;
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x000087BA File Offset: 0x000069BA
		public override bool RemoveAllInputs()
		{
			Debug.LogError("AnimationClipPlayable doesn't support removing inputs");
			return false;
		}

		/// <summary>
		///   <para>The speed at which the AnimationClip is played.</para>
		/// </summary>
		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x0600177D RID: 6013
		// (set) Token: 0x0600177E RID: 6014
		public extern float speed
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
