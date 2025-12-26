using System;

namespace UnityEngine.Networking
{
	// Token: 0x0200000B RID: 11
	[AttributeUsage(AttributeTargets.Event)]
	public class SyncEventAttribute : Attribute
	{
		// Token: 0x04000033 RID: 51
		public int channel;
	}
}
