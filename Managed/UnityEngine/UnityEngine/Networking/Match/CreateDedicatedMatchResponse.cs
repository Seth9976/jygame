using System;
using System.Collections.Generic;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
	// Token: 0x0200020E RID: 526
	public class CreateDedicatedMatchResponse : BasicResponse
	{
		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06001E8D RID: 7821 RVA: 0x0000C121 File Offset: 0x0000A321
		// (set) Token: 0x06001E8E RID: 7822 RVA: 0x0000C129 File Offset: 0x0000A329
		public NetworkID networkId { get; set; }

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06001E8F RID: 7823 RVA: 0x0000C132 File Offset: 0x0000A332
		// (set) Token: 0x06001E90 RID: 7824 RVA: 0x0000C13A File Offset: 0x0000A33A
		public NodeID nodeId { get; set; }

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06001E91 RID: 7825 RVA: 0x0000C143 File Offset: 0x0000A343
		// (set) Token: 0x06001E92 RID: 7826 RVA: 0x0000C14B File Offset: 0x0000A34B
		public string address { get; set; }

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06001E93 RID: 7827 RVA: 0x0000C154 File Offset: 0x0000A354
		// (set) Token: 0x06001E94 RID: 7828 RVA: 0x0000C15C File Offset: 0x0000A35C
		public int port { get; set; }

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06001E95 RID: 7829 RVA: 0x0000C165 File Offset: 0x0000A365
		// (set) Token: 0x06001E96 RID: 7830 RVA: 0x0000C16D File Offset: 0x0000A36D
		public string accessTokenString { get; set; }

		// Token: 0x06001E97 RID: 7831 RVA: 0x000251A0 File Offset: 0x000233A0
		public override void Parse(object obj)
		{
			base.Parse(obj);
			IDictionary<string, object> dictionary = obj as IDictionary<string, object>;
			if (dictionary != null)
			{
				this.address = base.ParseJSONString("address", obj, dictionary);
				this.port = base.ParseJSONInt32("port", obj, dictionary);
				this.accessTokenString = base.ParseJSONString("accessTokenString", obj, dictionary);
				this.networkId = (NetworkID)base.ParseJSONUInt64("networkId", obj, dictionary);
				this.nodeId = (NodeID)base.ParseJSONUInt16("nodeId", obj, dictionary);
				return;
			}
			throw new FormatException("While parsing JSON response, found obj is not of type IDictionary<string,object>:" + obj.ToString());
		}
	}
}
