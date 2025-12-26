using System;

namespace UnityEngine.Networking
{
	// Token: 0x0200005E RID: 94
	public class NetworkMessage
	{
		// Token: 0x06000494 RID: 1172 RVA: 0x00017940 File Offset: 0x00015B40
		public static string Dump(byte[] payload, int sz)
		{
			string text = "[";
			for (int i = 0; i < sz; i++)
			{
				text = text + payload[i] + " ";
			}
			return text + "]";
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00017988 File Offset: 0x00015B88
		public TMsg ReadMessage<TMsg>() where TMsg : MessageBase, new()
		{
			TMsg tmsg = new TMsg();
			tmsg.Deserialize(this.reader);
			return tmsg;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x000179B0 File Offset: 0x00015BB0
		public void ReadMessage<TMsg>(TMsg msg) where TMsg : MessageBase
		{
			msg.Deserialize(this.reader);
		}

		// Token: 0x0400020A RID: 522
		public short msgType;

		// Token: 0x0400020B RID: 523
		public NetworkConnection conn;

		// Token: 0x0400020C RID: 524
		public NetworkReader reader;

		// Token: 0x0400020D RID: 525
		public int channelId;
	}
}
