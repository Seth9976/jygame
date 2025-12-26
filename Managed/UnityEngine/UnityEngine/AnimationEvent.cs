using System;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>AnimationEvent lets you call a script function similar to SendMessage as part of playing back an animation.</para>
	/// </summary>
	// Token: 0x02000171 RID: 369
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class AnimationEvent
	{
		/// <summary>
		///   <para>Creates a new animation event.</para>
		/// </summary>
		// Token: 0x06001561 RID: 5473 RVA: 0x0001A6EC File Offset: 0x000188EC
		public AnimationEvent()
		{
			this.m_Time = 0f;
			this.m_FunctionName = string.Empty;
			this.m_StringParameter = string.Empty;
			this.m_ObjectReferenceParameter = null;
			this.m_FloatParameter = 0f;
			this.m_IntParameter = 0;
			this.m_MessageOptions = 0;
			this.m_Source = AnimationEventSource.NoSource;
			this.m_StateSender = null;
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001562 RID: 5474 RVA: 0x00007EA3 File Offset: 0x000060A3
		// (set) Token: 0x06001563 RID: 5475 RVA: 0x00007EAB File Offset: 0x000060AB
		[Obsolete("Use stringParameter instead")]
		public string data
		{
			get
			{
				return this.m_StringParameter;
			}
			set
			{
				this.m_StringParameter = value;
			}
		}

		/// <summary>
		///   <para>String parameter that is stored in the event and will be sent to the function.</para>
		/// </summary>
		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06001564 RID: 5476 RVA: 0x00007EA3 File Offset: 0x000060A3
		// (set) Token: 0x06001565 RID: 5477 RVA: 0x00007EAB File Offset: 0x000060AB
		public string stringParameter
		{
			get
			{
				return this.m_StringParameter;
			}
			set
			{
				this.m_StringParameter = value;
			}
		}

		/// <summary>
		///   <para>Float parameter that is stored in the event and will be sent to the function.</para>
		/// </summary>
		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06001566 RID: 5478 RVA: 0x00007EB4 File Offset: 0x000060B4
		// (set) Token: 0x06001567 RID: 5479 RVA: 0x00007EBC File Offset: 0x000060BC
		public float floatParameter
		{
			get
			{
				return this.m_FloatParameter;
			}
			set
			{
				this.m_FloatParameter = value;
			}
		}

		/// <summary>
		///   <para>Int parameter that is stored in the event and will be sent to the function.</para>
		/// </summary>
		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001568 RID: 5480 RVA: 0x00007EC5 File Offset: 0x000060C5
		// (set) Token: 0x06001569 RID: 5481 RVA: 0x00007ECD File Offset: 0x000060CD
		public int intParameter
		{
			get
			{
				return this.m_IntParameter;
			}
			set
			{
				this.m_IntParameter = value;
			}
		}

		/// <summary>
		///   <para>Object reference parameter that is stored in the event and will be sent to the function.</para>
		/// </summary>
		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x0600156A RID: 5482 RVA: 0x00007ED6 File Offset: 0x000060D6
		// (set) Token: 0x0600156B RID: 5483 RVA: 0x00007EDE File Offset: 0x000060DE
		public Object objectReferenceParameter
		{
			get
			{
				return this.m_ObjectReferenceParameter;
			}
			set
			{
				this.m_ObjectReferenceParameter = value;
			}
		}

		/// <summary>
		///   <para>The name of the function that will be called.</para>
		/// </summary>
		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x0600156C RID: 5484 RVA: 0x00007EE7 File Offset: 0x000060E7
		// (set) Token: 0x0600156D RID: 5485 RVA: 0x00007EEF File Offset: 0x000060EF
		public string functionName
		{
			get
			{
				return this.m_FunctionName;
			}
			set
			{
				this.m_FunctionName = value;
			}
		}

		/// <summary>
		///   <para>The time at which the event will be fired off.</para>
		/// </summary>
		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x0600156E RID: 5486 RVA: 0x00007EF8 File Offset: 0x000060F8
		// (set) Token: 0x0600156F RID: 5487 RVA: 0x00007F00 File Offset: 0x00006100
		public float time
		{
			get
			{
				return this.m_Time;
			}
			set
			{
				this.m_Time = value;
			}
		}

		/// <summary>
		///   <para>Function call options.</para>
		/// </summary>
		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001570 RID: 5488 RVA: 0x00007F09 File Offset: 0x00006109
		// (set) Token: 0x06001571 RID: 5489 RVA: 0x00007F11 File Offset: 0x00006111
		public SendMessageOptions messageOptions
		{
			get
			{
				return (SendMessageOptions)this.m_MessageOptions;
			}
			set
			{
				this.m_MessageOptions = (int)value;
			}
		}

		/// <summary>
		///   <para>Returns true if this Animation event has been fired by an Animation component.</para>
		/// </summary>
		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001572 RID: 5490 RVA: 0x00007F1A File Offset: 0x0000611A
		public bool isFiredByLegacy
		{
			get
			{
				return this.m_Source == AnimationEventSource.Legacy;
			}
		}

		/// <summary>
		///   <para>Returns true if this Animation event has been fired by an Animator component.</para>
		/// </summary>
		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06001573 RID: 5491 RVA: 0x00007F25 File Offset: 0x00006125
		public bool isFiredByAnimator
		{
			get
			{
				return this.m_Source == AnimationEventSource.Animator;
			}
		}

		/// <summary>
		///   <para>The animation state that fired this event (Read Only).</para>
		/// </summary>
		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06001574 RID: 5492 RVA: 0x00007F30 File Offset: 0x00006130
		public AnimationState animationState
		{
			get
			{
				if (!this.isFiredByLegacy)
				{
					Debug.LogError("AnimationEvent was not fired by Animation component, you shouldn't use AnimationEvent.animationState");
				}
				return this.m_StateSender;
			}
		}

		/// <summary>
		///   <para>The animator state info related to this event (Read Only).</para>
		/// </summary>
		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06001575 RID: 5493 RVA: 0x00007F4D File Offset: 0x0000614D
		public AnimatorStateInfo animatorStateInfo
		{
			get
			{
				if (!this.isFiredByAnimator)
				{
					Debug.LogError("AnimationEvent was not fired by Animator component, you shouldn't use AnimationEvent.animatorStateInfo");
				}
				return this.m_AnimatorStateInfo;
			}
		}

		/// <summary>
		///   <para>The animator clip info related to this event (Read Only).</para>
		/// </summary>
		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001576 RID: 5494 RVA: 0x00007F6A File Offset: 0x0000616A
		public AnimatorClipInfo animatorClipInfo
		{
			get
			{
				if (!this.isFiredByAnimator)
				{
					Debug.LogError("AnimationEvent was not fired by Animator component, you shouldn't use AnimationEvent.animatorClipInfo");
				}
				return this.m_AnimatorClipInfo;
			}
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x0001A750 File Offset: 0x00018950
		internal int GetHash()
		{
			int hashCode = this.functionName.GetHashCode();
			return 33 * hashCode + this.time.GetHashCode();
		}

		// Token: 0x04000404 RID: 1028
		internal float m_Time;

		// Token: 0x04000405 RID: 1029
		internal string m_FunctionName;

		// Token: 0x04000406 RID: 1030
		internal string m_StringParameter;

		// Token: 0x04000407 RID: 1031
		internal Object m_ObjectReferenceParameter;

		// Token: 0x04000408 RID: 1032
		internal float m_FloatParameter;

		// Token: 0x04000409 RID: 1033
		internal int m_IntParameter;

		// Token: 0x0400040A RID: 1034
		internal int m_MessageOptions;

		// Token: 0x0400040B RID: 1035
		internal AnimationEventSource m_Source;

		// Token: 0x0400040C RID: 1036
		internal AnimationState m_StateSender;

		// Token: 0x0400040D RID: 1037
		internal AnimatorStateInfo m_AnimatorStateInfo;

		// Token: 0x0400040E RID: 1038
		internal AnimatorClipInfo m_AnimatorClipInfo;
	}
}
