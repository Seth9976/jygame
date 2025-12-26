using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Parameters for the optional motor force applied to a Joint2D.</para>
	/// </summary>
	// Token: 0x0200012D RID: 301
	public struct JointMotor2D
	{
		/// <summary>
		///   <para>The desired speed for the Rigidbody2D to reach as it moves with the joint.</para>
		/// </summary>
		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x0600128A RID: 4746 RVA: 0x0000792D File Offset: 0x00005B2D
		// (set) Token: 0x0600128B RID: 4747 RVA: 0x00007935 File Offset: 0x00005B35
		public float motorSpeed
		{
			get
			{
				return this.m_MotorSpeed;
			}
			set
			{
				this.m_MotorSpeed = value;
			}
		}

		/// <summary>
		///   <para>The maximum force that can be applied to the Rigidbody2D at the joint to attain the target speed.</para>
		/// </summary>
		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x0600128C RID: 4748 RVA: 0x0000793E File Offset: 0x00005B3E
		// (set) Token: 0x0600128D RID: 4749 RVA: 0x00007946 File Offset: 0x00005B46
		public float maxMotorTorque
		{
			get
			{
				return this.m_MaximumMotorTorque;
			}
			set
			{
				this.m_MaximumMotorTorque = value;
			}
		}

		// Token: 0x04000362 RID: 866
		private float m_MotorSpeed;

		// Token: 0x04000363 RID: 867
		private float m_MaximumMotorTorque;
	}
}
