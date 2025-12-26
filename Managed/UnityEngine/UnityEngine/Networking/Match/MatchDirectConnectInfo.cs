using System;
using System.Collections.Generic;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
	/// <summary>
	///   <para>Class describing a client in a network match.</para>
	/// </summary>
	// Token: 0x0200020A RID: 522
	public class MatchDirectConnectInfo : ResponseBase
	{
		/// <summary>
		///   <para>NodeID of the client described in this direct connect info.</para>
		/// </summary>
		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06001E57 RID: 7767 RVA: 0x0000BF1F File Offset: 0x0000A11F
		// (set) Token: 0x06001E58 RID: 7768 RVA: 0x0000BF27 File Offset: 0x0000A127
		public NodeID nodeId { get; set; }

		/// <summary>
		///   <para>Public address the client described by this class provided.</para>
		/// </summary>
		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06001E59 RID: 7769 RVA: 0x0000BF30 File Offset: 0x0000A130
		// (set) Token: 0x06001E5A RID: 7770 RVA: 0x0000BF38 File Offset: 0x0000A138
		public string publicAddress { get; set; }

		/// <summary>
		///   <para>Private address the client described by this class provided.</para>
		/// </summary>
		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06001E5B RID: 7771 RVA: 0x0000BF41 File Offset: 0x0000A141
		// (set) Token: 0x06001E5C RID: 7772 RVA: 0x0000BF49 File Offset: 0x0000A149
		public string privateAddress { get; set; }

		// Token: 0x06001E5D RID: 7773 RVA: 0x0000BF52 File Offset: 0x0000A152
		public override string ToString()
		{
			return UnityString.Format("[{0}]-nodeId:{1},publicAddress:{2},privateAddress:{3}", new object[]
			{
				base.ToString(),
				this.nodeId,
				this.publicAddress,
				this.privateAddress
			});
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x00024F80 File Offset: 0x00023180
		public override void Parse(object obj)
		{
			IDictionary<string, object> dictionary = obj as IDictionary<string, object>;
			if (dictionary != null)
			{
				this.nodeId = (NodeID)base.ParseJSONUInt16("nodeId", obj, dictionary);
				this.publicAddress = base.ParseJSONString("publicAddress", obj, dictionary);
				this.privateAddress = base.ParseJSONString("privateAddress", obj, dictionary);
				return;
			}
			throw new FormatException("While parsing JSON response, found obj is not of type IDictionary<string,object>:" + obj.ToString());
		}
	}
}
