using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>A structure describing the webcam device.</para>
	/// </summary>
	// Token: 0x0200016B RID: 363
	public struct WebCamDevice
	{
		/// <summary>
		///   <para>A human-readable name of the device. Varies across different systems.</para>
		/// </summary>
		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x0600152F RID: 5423 RVA: 0x00007DB1 File Offset: 0x00005FB1
		public string name
		{
			get
			{
				return this.m_Name;
			}
		}

		/// <summary>
		///   <para>True if camera faces the same direction a screen does, false otherwise.</para>
		/// </summary>
		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001530 RID: 5424 RVA: 0x00007DB9 File Offset: 0x00005FB9
		public bool isFrontFacing
		{
			get
			{
				return (this.m_Flags & 1) == 1;
			}
		}

		// Token: 0x040003F5 RID: 1013
		internal string m_Name;

		// Token: 0x040003F6 RID: 1014
		internal int m_Flags;
	}
}
