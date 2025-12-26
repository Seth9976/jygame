using System;

namespace UnityEngine.Networking
{
	// Token: 0x02000016 RID: 22
	public abstract class MessageBase
	{
		// Token: 0x0600008C RID: 140 RVA: 0x00004880 File Offset: 0x00002A80
		public virtual void Deserialize(NetworkReader reader)
		{
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00004884 File Offset: 0x00002A84
		public virtual void Serialize(NetworkWriter writer)
		{
		}
	}
}
