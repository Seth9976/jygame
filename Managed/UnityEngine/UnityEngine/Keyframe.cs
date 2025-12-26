using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>A single keyframe that can be injected into an animation curve.</para>
	/// </summary>
	// Token: 0x02000173 RID: 371
	public struct Keyframe
	{
		/// <summary>
		///   <para>Create a keyframe.</para>
		/// </summary>
		/// <param name="time"></param>
		/// <param name="value"></param>
		// Token: 0x06001594 RID: 5524 RVA: 0x00007FCE File Offset: 0x000061CE
		public Keyframe(float time, float value)
		{
			this.m_Time = time;
			this.m_Value = value;
			this.m_InTangent = 0f;
			this.m_OutTangent = 0f;
		}

		/// <summary>
		///   <para>Create a keyframe.</para>
		/// </summary>
		/// <param name="time"></param>
		/// <param name="value"></param>
		/// <param name="inTangent"></param>
		/// <param name="outTangent"></param>
		// Token: 0x06001595 RID: 5525 RVA: 0x00007FF4 File Offset: 0x000061F4
		public Keyframe(float time, float value, float inTangent, float outTangent)
		{
			this.m_Time = time;
			this.m_Value = value;
			this.m_InTangent = inTangent;
			this.m_OutTangent = outTangent;
		}

		/// <summary>
		///   <para>The time of the keyframe.</para>
		/// </summary>
		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06001596 RID: 5526 RVA: 0x00008013 File Offset: 0x00006213
		// (set) Token: 0x06001597 RID: 5527 RVA: 0x0000801B File Offset: 0x0000621B
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
		///   <para>The value of the curve at keyframe.</para>
		/// </summary>
		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001598 RID: 5528 RVA: 0x00008024 File Offset: 0x00006224
		// (set) Token: 0x06001599 RID: 5529 RVA: 0x0000802C File Offset: 0x0000622C
		public float value
		{
			get
			{
				return this.m_Value;
			}
			set
			{
				this.m_Value = value;
			}
		}

		/// <summary>
		///   <para>Describes the tangent when approaching this point from the previous point in the curve.</para>
		/// </summary>
		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x0600159A RID: 5530 RVA: 0x00008035 File Offset: 0x00006235
		// (set) Token: 0x0600159B RID: 5531 RVA: 0x0000803D File Offset: 0x0000623D
		public float inTangent
		{
			get
			{
				return this.m_InTangent;
			}
			set
			{
				this.m_InTangent = value;
			}
		}

		/// <summary>
		///   <para>Describes the tangent when leaving this point towards the next point in the curve.</para>
		/// </summary>
		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x0600159C RID: 5532 RVA: 0x00008046 File Offset: 0x00006246
		// (set) Token: 0x0600159D RID: 5533 RVA: 0x0000804E File Offset: 0x0000624E
		public float outTangent
		{
			get
			{
				return this.m_OutTangent;
			}
			set
			{
				this.m_OutTangent = value;
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x0600159E RID: 5534 RVA: 0x00002C36 File Offset: 0x00000E36
		// (set) Token: 0x0600159F RID: 5535 RVA: 0x00002753 File Offset: 0x00000953
		public int tangentMode
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x0400040F RID: 1039
		private float m_Time;

		// Token: 0x04000410 RID: 1040
		private float m_Value;

		// Token: 0x04000411 RID: 1041
		private float m_InTangent;

		// Token: 0x04000412 RID: 1042
		private float m_OutTangent;
	}
}
