using System;
using System.Collections.Generic;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
	/// <summary>
	///   <para>JSON response for a CreateMatchRequest. It contains all information necessdary to continue joining a match.</para>
	/// </summary>
	// Token: 0x02000204 RID: 516
	public class CreateMatchResponse : BasicResponse
	{
		/// <summary>
		///   <para>Network address to connect to in order to join the match.</para>
		/// </summary>
		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06001E0D RID: 7693 RVA: 0x0000BCAD File Offset: 0x00009EAD
		// (set) Token: 0x06001E0E RID: 7694 RVA: 0x0000BCB5 File Offset: 0x00009EB5
		public string address { get; set; }

		/// <summary>
		///   <para>Network port to connect to in order to join the match.</para>
		/// </summary>
		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06001E0F RID: 7695 RVA: 0x0000BCBE File Offset: 0x00009EBE
		// (set) Token: 0x06001E10 RID: 7696 RVA: 0x0000BCC6 File Offset: 0x00009EC6
		public int port { get; set; }

		/// <summary>
		///   <para>The network id for the match created.</para>
		/// </summary>
		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06001E11 RID: 7697 RVA: 0x0000BCCF File Offset: 0x00009ECF
		// (set) Token: 0x06001E12 RID: 7698 RVA: 0x0000BCD7 File Offset: 0x00009ED7
		public NetworkID networkId { get; set; }

		/// <summary>
		///   <para>JSON encoding for the binary access token this client uses to authenticate its session for future commands.</para>
		/// </summary>
		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06001E13 RID: 7699 RVA: 0x0000BCE0 File Offset: 0x00009EE0
		// (set) Token: 0x06001E14 RID: 7700 RVA: 0x0000BCE8 File Offset: 0x00009EE8
		public string accessTokenString { get; set; }

		/// <summary>
		///   <para>NodeId for the requesting client in the created match.</para>
		/// </summary>
		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06001E15 RID: 7701 RVA: 0x0000BCF1 File Offset: 0x00009EF1
		// (set) Token: 0x06001E16 RID: 7702 RVA: 0x0000BCF9 File Offset: 0x00009EF9
		public NodeID nodeId { get; set; }

		/// <summary>
		///   <para>If the match is hosted by a relay server.</para>
		/// </summary>
		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x06001E17 RID: 7703 RVA: 0x0000BD02 File Offset: 0x00009F02
		// (set) Token: 0x06001E18 RID: 7704 RVA: 0x0000BD0A File Offset: 0x00009F0A
		public bool usingRelay { get; set; }

		/// <summary>
		///   <para>Provides string description of current class data.</para>
		/// </summary>
		// Token: 0x06001E19 RID: 7705 RVA: 0x00024B38 File Offset: 0x00022D38
		public override string ToString()
		{
			return UnityString.Format("[{0}]-address:{1},port:{2},networkId:0x{3},nodeId:0x{4},usingRelay:{5}", new object[]
			{
				base.ToString(),
				this.address,
				this.port,
				this.networkId.ToString("X"),
				this.nodeId.ToString("X"),
				this.usingRelay
			});
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x00024BB4 File Offset: 0x00022DB4
		public override void Parse(object obj)
		{
			base.Parse(obj);
			IDictionary<string, object> dictionary = obj as IDictionary<string, object>;
			if (dictionary != null)
			{
				this.address = base.ParseJSONString("address", obj, dictionary);
				this.port = base.ParseJSONInt32("port", obj, dictionary);
				this.networkId = (NetworkID)base.ParseJSONUInt64("networkId", obj, dictionary);
				this.accessTokenString = base.ParseJSONString("accessTokenString", obj, dictionary);
				this.nodeId = (NodeID)base.ParseJSONUInt16("nodeId", obj, dictionary);
				this.usingRelay = base.ParseJSONBool("usingRelay", obj, dictionary);
				return;
			}
			throw new FormatException("While parsing JSON response, found obj is not of type IDictionary<string,object>:" + obj.ToString());
		}
	}
}
