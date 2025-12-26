using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Used to communicate between scripting and the controller. Some parameters can be set in scripting and used by the controller, while other parameters are based on Custom Curves in Animation Clips and can be sampled using the scripting API.</para>
	/// </summary>
	// Token: 0x0200018A RID: 394
	public sealed class AnimatorControllerParameter
	{
		/// <summary>
		///   <para>The name of the parameter.</para>
		/// </summary>
		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06001722 RID: 5922 RVA: 0x00008597 File Offset: 0x00006797
		public string name
		{
			get
			{
				return this.m_Name;
			}
		}

		/// <summary>
		///   <para>Returns the hash of the parameter based on its name.</para>
		/// </summary>
		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001723 RID: 5923 RVA: 0x0000859F File Offset: 0x0000679F
		public int nameHash
		{
			get
			{
				return Animator.StringToHash(this.m_Name);
			}
		}

		/// <summary>
		///   <para>The type of the parameter.</para>
		/// </summary>
		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06001724 RID: 5924 RVA: 0x000085AC File Offset: 0x000067AC
		// (set) Token: 0x06001725 RID: 5925 RVA: 0x000085B4 File Offset: 0x000067B4
		public AnimatorControllerParameterType type
		{
			get
			{
				return this.m_Type;
			}
			set
			{
				this.m_Type = value;
			}
		}

		/// <summary>
		///   <para>The default bool value for the parameter.</para>
		/// </summary>
		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001726 RID: 5926 RVA: 0x000085BD File Offset: 0x000067BD
		// (set) Token: 0x06001727 RID: 5927 RVA: 0x000085C5 File Offset: 0x000067C5
		public float defaultFloat
		{
			get
			{
				return this.m_DefaultFloat;
			}
			set
			{
				this.m_DefaultFloat = value;
			}
		}

		/// <summary>
		///   <para>The default bool value for the parameter.</para>
		/// </summary>
		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001728 RID: 5928 RVA: 0x000085CE File Offset: 0x000067CE
		// (set) Token: 0x06001729 RID: 5929 RVA: 0x000085D6 File Offset: 0x000067D6
		public int defaultInt
		{
			get
			{
				return this.m_DefaultInt;
			}
			set
			{
				this.m_DefaultInt = value;
			}
		}

		/// <summary>
		///   <para>The default bool value for the parameter.</para>
		/// </summary>
		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x0600172A RID: 5930 RVA: 0x000085DF File Offset: 0x000067DF
		// (set) Token: 0x0600172B RID: 5931 RVA: 0x000085E7 File Offset: 0x000067E7
		public bool defaultBool
		{
			get
			{
				return this.m_DefaultBool;
			}
			set
			{
				this.m_DefaultBool = value;
			}
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x0001AF30 File Offset: 0x00019130
		public override bool Equals(object o)
		{
			AnimatorControllerParameter animatorControllerParameter = o as AnimatorControllerParameter;
			return animatorControllerParameter != null && this.m_Name == animatorControllerParameter.m_Name && this.m_Type == animatorControllerParameter.m_Type && this.m_DefaultFloat == animatorControllerParameter.m_DefaultFloat && this.m_DefaultInt == animatorControllerParameter.m_DefaultInt && this.m_DefaultBool == animatorControllerParameter.m_DefaultBool;
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x000085F0 File Offset: 0x000067F0
		public override int GetHashCode()
		{
			return this.name.GetHashCode();
		}

		// Token: 0x04000461 RID: 1121
		internal string m_Name = string.Empty;

		// Token: 0x04000462 RID: 1122
		internal AnimatorControllerParameterType m_Type;

		// Token: 0x04000463 RID: 1123
		internal float m_DefaultFloat;

		// Token: 0x04000464 RID: 1124
		internal int m_DefaultInt;

		// Token: 0x04000465 RID: 1125
		internal bool m_DefaultBool;
	}
}
