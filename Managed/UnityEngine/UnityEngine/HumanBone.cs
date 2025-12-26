using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>The mapping between a bone in the model and the conceptual bone in the Mecanim human anatomy.</para>
	/// </summary>
	// Token: 0x0200018E RID: 398
	public struct HumanBone
	{
		/// <summary>
		///   <para>The name of the bone to which the Mecanim human bone is mapped.</para>
		/// </summary>
		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x0600173B RID: 5947 RVA: 0x00008664 File Offset: 0x00006864
		// (set) Token: 0x0600173C RID: 5948 RVA: 0x0000866C File Offset: 0x0000686C
		public string boneName
		{
			get
			{
				return this.m_BoneName;
			}
			set
			{
				this.m_BoneName = value;
			}
		}

		/// <summary>
		///   <para>The name of the Mecanim human bone to which the bone from the model is mapped.</para>
		/// </summary>
		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x0600173D RID: 5949 RVA: 0x00008675 File Offset: 0x00006875
		// (set) Token: 0x0600173E RID: 5950 RVA: 0x0000867D File Offset: 0x0000687D
		public string humanName
		{
			get
			{
				return this.m_HumanName;
			}
			set
			{
				this.m_HumanName = value;
			}
		}

		// Token: 0x04000470 RID: 1136
		private string m_BoneName;

		// Token: 0x04000471 RID: 1137
		private string m_HumanName;

		/// <summary>
		///   <para>The rotation limits that define the muscle for this bone.</para>
		/// </summary>
		// Token: 0x04000472 RID: 1138
		public HumanLimit limit;
	}
}
