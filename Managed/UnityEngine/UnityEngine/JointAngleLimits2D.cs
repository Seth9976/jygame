using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Angular limits on the rotation of a Rigidbody2D object around a HingeJoint2D.</para>
	/// </summary>
	// Token: 0x0200012B RID: 299
	public struct JointAngleLimits2D
	{
		/// <summary>
		///   <para>Lower angular limit of rotation.</para>
		/// </summary>
		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06001282 RID: 4738 RVA: 0x000078E9 File Offset: 0x00005AE9
		// (set) Token: 0x06001283 RID: 4739 RVA: 0x000078F1 File Offset: 0x00005AF1
		public float min
		{
			get
			{
				return this.m_LowerAngle;
			}
			set
			{
				this.m_LowerAngle = value;
			}
		}

		/// <summary>
		///   <para>Upper angular limit of rotation.</para>
		/// </summary>
		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06001284 RID: 4740 RVA: 0x000078FA File Offset: 0x00005AFA
		// (set) Token: 0x06001285 RID: 4741 RVA: 0x00007902 File Offset: 0x00005B02
		public float max
		{
			get
			{
				return this.m_UpperAngle;
			}
			set
			{
				this.m_UpperAngle = value;
			}
		}

		// Token: 0x0400035E RID: 862
		private float m_LowerAngle;

		// Token: 0x0400035F RID: 863
		private float m_UpperAngle;
	}
}
