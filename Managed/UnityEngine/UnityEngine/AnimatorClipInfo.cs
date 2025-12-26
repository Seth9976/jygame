using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Information about clip been played and blended by the Animator.</para>
	/// </summary>
	// Token: 0x02000183 RID: 387
	public struct AnimatorClipInfo
	{
		/// <summary>
		///   <para>Returns the animation clip played by the Animator.</para>
		/// </summary>
		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001619 RID: 5657 RVA: 0x00008165 File Offset: 0x00006365
		public AnimationClip clip
		{
			get
			{
				return (this.m_ClipInstanceID == 0) ? null : AnimatorClipInfo.ClipInstanceToScriptingObject(this.m_ClipInstanceID);
			}
		}

		/// <summary>
		///   <para>Returns the blending weight used by the Animator to blend this clip.</para>
		/// </summary>
		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x0600161A RID: 5658 RVA: 0x00008183 File Offset: 0x00006383
		public float weight
		{
			get
			{
				return this.m_Weight;
			}
		}

		// Token: 0x0600161B RID: 5659
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AnimationClip ClipInstanceToScriptingObject(int instanceID);

		// Token: 0x04000446 RID: 1094
		private int m_ClipInstanceID;

		// Token: 0x04000447 RID: 1095
		private float m_Weight;
	}
}
