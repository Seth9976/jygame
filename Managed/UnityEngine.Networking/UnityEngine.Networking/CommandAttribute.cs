using System;

namespace UnityEngine.Networking
{
	// Token: 0x02000009 RID: 9
	[AttributeUsage(AttributeTargets.Method)]
	public class CommandAttribute : Attribute
	{
		// Token: 0x04000031 RID: 49
		public int channel;
	}
}
