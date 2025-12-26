using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Structure describing acceleration status of the device.</para>
	/// </summary>
	// Token: 0x020000BE RID: 190
	public struct AccelerationEvent
	{
		/// <summary>
		///   <para>Value of acceleration.</para>
		/// </summary>
		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x00005DD1 File Offset: 0x00003FD1
		public Vector3 acceleration
		{
			get
			{
				return this.m_Acceleration;
			}
		}

		/// <summary>
		///   <para>Amount of time passed since last accelerometer measurement.</para>
		/// </summary>
		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x00005DD9 File Offset: 0x00003FD9
		public float deltaTime
		{
			get
			{
				return this.m_TimeDelta;
			}
		}

		// Token: 0x0400023F RID: 575
		private Vector3 m_Acceleration;

		// Token: 0x04000240 RID: 576
		private float m_TimeDelta;
	}
}
