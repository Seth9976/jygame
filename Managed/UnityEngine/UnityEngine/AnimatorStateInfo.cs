using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Information about the current or next state.</para>
	/// </summary>
	// Token: 0x02000186 RID: 390
	public struct AnimatorStateInfo
	{
		/// <summary>
		///   <para>Does name match the name of the active state in the statemachine?</para>
		/// </summary>
		/// <param name="name"></param>
		// Token: 0x0600161C RID: 5660 RVA: 0x0001AA4C File Offset: 0x00018C4C
		public bool IsName(string name)
		{
			int num = Animator.StringToHash(name);
			return num == this.m_FullPath || num == this.m_Name || num == this.m_Path;
		}

		/// <summary>
		///   <para>The full path hash for this state.</para>
		/// </summary>
		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x0600161D RID: 5661 RVA: 0x0000818B File Offset: 0x0000638B
		public int fullPathHash
		{
			get
			{
				return this.m_FullPath;
			}
		}

		/// <summary>
		///   <para>The hashed name of the State.</para>
		/// </summary>
		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x0600161E RID: 5662 RVA: 0x00008193 File Offset: 0x00006393
		[Obsolete("Use AnimatorStateInfo.fullPathHash instead.")]
		public int nameHash
		{
			get
			{
				return this.m_Path;
			}
		}

		/// <summary>
		///   <para>The hash is generated using Animator::StringToHash. The string to pass doest not include the parent layer's name.</para>
		/// </summary>
		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x0600161F RID: 5663 RVA: 0x0000819B File Offset: 0x0000639B
		public int shortNameHash
		{
			get
			{
				return this.m_Name;
			}
		}

		/// <summary>
		///   <para>Normalized time of the State.</para>
		/// </summary>
		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001620 RID: 5664 RVA: 0x000081A3 File Offset: 0x000063A3
		public float normalizedTime
		{
			get
			{
				return this.m_NormalizedTime;
			}
		}

		/// <summary>
		///   <para>Current duration of the state.</para>
		/// </summary>
		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001621 RID: 5665 RVA: 0x000081AB File Offset: 0x000063AB
		public float length
		{
			get
			{
				return this.m_Length;
			}
		}

		/// <summary>
		///   <para>The playback speed of the animation. 1 is the normal playback speed.</para>
		/// </summary>
		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001622 RID: 5666 RVA: 0x000081B3 File Offset: 0x000063B3
		public float speed
		{
			get
			{
				return this.m_Speed;
			}
		}

		/// <summary>
		///   <para>The speed multiplier for this state.</para>
		/// </summary>
		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001623 RID: 5667 RVA: 0x000081BB File Offset: 0x000063BB
		public float speedMultiplier
		{
			get
			{
				return this.m_SpeedMultiplier;
			}
		}

		/// <summary>
		///   <para>The Tag of the State.</para>
		/// </summary>
		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001624 RID: 5668 RVA: 0x000081C3 File Offset: 0x000063C3
		public int tagHash
		{
			get
			{
				return this.m_Tag;
			}
		}

		/// <summary>
		///   <para>Does tag match the tag of the active state in the statemachine.</para>
		/// </summary>
		/// <param name="tag"></param>
		// Token: 0x06001625 RID: 5669 RVA: 0x000081CB File Offset: 0x000063CB
		public bool IsTag(string tag)
		{
			return Animator.StringToHash(tag) == this.m_Tag;
		}

		/// <summary>
		///   <para>Is the state looping.</para>
		/// </summary>
		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001626 RID: 5670 RVA: 0x000081DB File Offset: 0x000063DB
		public bool loop
		{
			get
			{
				return this.m_Loop != 0;
			}
		}

		// Token: 0x04000450 RID: 1104
		private int m_Name;

		// Token: 0x04000451 RID: 1105
		private int m_Path;

		// Token: 0x04000452 RID: 1106
		private int m_FullPath;

		// Token: 0x04000453 RID: 1107
		private float m_NormalizedTime;

		// Token: 0x04000454 RID: 1108
		private float m_Length;

		// Token: 0x04000455 RID: 1109
		private float m_Speed;

		// Token: 0x04000456 RID: 1110
		private float m_SpeedMultiplier;

		// Token: 0x04000457 RID: 1111
		private int m_Tag;

		// Token: 0x04000458 RID: 1112
		private int m_Loop;
	}
}
