using System;

namespace UnityEngine.Experimental.Director
{
	/// <summary>
	///   <para>This structure contains the frame information a Playable receives in Playable.PrepareFrame.</para>
	/// </summary>
	// Token: 0x020002FC RID: 764
	public struct FrameData
	{
		/// <summary>
		///   <para>Frame update counter. Can be used to know when to initialize your Playable (when updateid is 0).</para>
		/// </summary>
		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06002348 RID: 9032 RVA: 0x0000EA79 File Offset: 0x0000CC79
		public int updateId
		{
			get
			{
				return this.m_UpdateId;
			}
		}

		/// <summary>
		///   <para>Current time at the start of the frame.</para>
		/// </summary>
		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06002349 RID: 9033 RVA: 0x0000EA81 File Offset: 0x0000CC81
		public float time
		{
			get
			{
				return (float)this.m_Time;
			}
		}

		/// <summary>
		///   <para>Last frame's start time.</para>
		/// </summary>
		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x0600234A RID: 9034 RVA: 0x0000EA8A File Offset: 0x0000CC8A
		public float lastTime
		{
			get
			{
				return (float)this.m_LastTime;
			}
		}

		/// <summary>
		///   <para>Time difference between this frame and the preceding frame.</para>
		/// </summary>
		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x0600234B RID: 9035 RVA: 0x0000EA93 File Offset: 0x0000CC93
		public float deltaTime
		{
			get
			{
				return (float)this.m_Time - (float)this.m_LastTime;
			}
		}

		/// <summary>
		///   <para>Time speed multiplier. 1 is normal speed, 0 is stopped.</para>
		/// </summary>
		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x0600234C RID: 9036 RVA: 0x0000EAA4 File Offset: 0x0000CCA4
		public float timeScale
		{
			get
			{
				return (float)this.m_TimeScale;
			}
		}

		/// <summary>
		///   <para>Current time at the start of the frame in double precision.</para>
		/// </summary>
		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x0600234D RID: 9037 RVA: 0x0000EAAD File Offset: 0x0000CCAD
		public double dTime
		{
			get
			{
				return this.m_Time;
			}
		}

		/// <summary>
		///   <para>Time difference between this frame and the preceding frame in double precision.</para>
		/// </summary>
		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x0600234E RID: 9038 RVA: 0x0000EAB5 File Offset: 0x0000CCB5
		public double dLastTime
		{
			get
			{
				return this.m_LastTime;
			}
		}

		/// <summary>
		///   <para>Time difference between this frame and the preceding frame in double precision.</para>
		/// </summary>
		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x0600234F RID: 9039 RVA: 0x0000EABD File Offset: 0x0000CCBD
		public double dDeltaTime
		{
			get
			{
				return this.m_Time - this.m_LastTime;
			}
		}

		/// <summary>
		///   <para>Time speed multiplier in double precision.</para>
		/// </summary>
		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06002350 RID: 9040 RVA: 0x0000EACC File Offset: 0x0000CCCC
		public double dtimeScale
		{
			get
			{
				return this.m_TimeScale;
			}
		}

		// Token: 0x04000BAD RID: 2989
		internal int m_UpdateId;

		// Token: 0x04000BAE RID: 2990
		internal double m_Time;

		// Token: 0x04000BAF RID: 2991
		internal double m_LastTime;

		// Token: 0x04000BB0 RID: 2992
		internal double m_TimeScale;
	}
}
