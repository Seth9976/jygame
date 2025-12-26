using System;

namespace UnityEngine.Networking
{
	// Token: 0x02000007 RID: 7
	[AttributeUsage(AttributeTargets.Class)]
	public class NetworkSettingsAttribute : Attribute
	{
		// Token: 0x0400002E RID: 46
		public int channel;

		// Token: 0x0400002F RID: 47
		public float sendInterval = 0.1f;
	}
}
