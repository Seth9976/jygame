using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Information about the current transition.</para>
	/// </summary>
	// Token: 0x02000187 RID: 391
	public struct AnimatorTransitionInfo
	{
		/// <summary>
		///   <para>Does name match the name of the active Transition.</para>
		/// </summary>
		/// <param name="name"></param>
		// Token: 0x06001627 RID: 5671 RVA: 0x000081E9 File Offset: 0x000063E9
		public bool IsName(string name)
		{
			return Animator.StringToHash(name) == this.m_Name || Animator.StringToHash(name) == this.m_FullPath;
		}

		/// <summary>
		///   <para>Does userName match the name of the active Transition.</para>
		/// </summary>
		/// <param name="name"></param>
		// Token: 0x06001628 RID: 5672 RVA: 0x0000820D File Offset: 0x0000640D
		public bool IsUserName(string name)
		{
			return Animator.StringToHash(name) == this.m_UserName;
		}

		/// <summary>
		///   <para>The unique name of the Transition.</para>
		/// </summary>
		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001629 RID: 5673 RVA: 0x0000821D File Offset: 0x0000641D
		public int fullPathHash
		{
			get
			{
				return this.m_FullPath;
			}
		}

		/// <summary>
		///   <para>The simplified name of the Transition.</para>
		/// </summary>
		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x0600162A RID: 5674 RVA: 0x00008225 File Offset: 0x00006425
		public int nameHash
		{
			get
			{
				return this.m_Name;
			}
		}

		/// <summary>
		///   <para>The user-specidied name of the Transition.</para>
		/// </summary>
		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x0600162B RID: 5675 RVA: 0x0000822D File Offset: 0x0000642D
		public int userNameHash
		{
			get
			{
				return this.m_UserName;
			}
		}

		/// <summary>
		///   <para>Normalized time of the Transition.</para>
		/// </summary>
		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x0600162C RID: 5676 RVA: 0x00008235 File Offset: 0x00006435
		public float normalizedTime
		{
			get
			{
				return this.m_NormalizedTime;
			}
		}

		/// <summary>
		///   <para>Returns true if the transition is from an AnyState node, or from Animator.CrossFade().</para>
		/// </summary>
		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x0600162D RID: 5677 RVA: 0x0000823D File Offset: 0x0000643D
		public bool anyState
		{
			get
			{
				return this.m_AnyState;
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x0600162E RID: 5678 RVA: 0x00008245 File Offset: 0x00006445
		internal bool entry
		{
			get
			{
				return (this.m_TransitionType & 2) != 0;
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x0600162F RID: 5679 RVA: 0x00008255 File Offset: 0x00006455
		internal bool exit
		{
			get
			{
				return (this.m_TransitionType & 4) != 0;
			}
		}

		// Token: 0x04000459 RID: 1113
		private int m_FullPath;

		// Token: 0x0400045A RID: 1114
		private int m_UserName;

		// Token: 0x0400045B RID: 1115
		private int m_Name;

		// Token: 0x0400045C RID: 1116
		private float m_NormalizedTime;

		// Token: 0x0400045D RID: 1117
		private bool m_AnyState;

		// Token: 0x0400045E RID: 1118
		private int m_TransitionType;
	}
}
