using System;
using System.Collections.Generic;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
	/// <summary>
	///   <para>JSON response for a JoinMatchRequest. It contains all information necessdary to continue joining a match.</para>
	/// </summary>
	// Token: 0x02000206 RID: 518
	public class JoinMatchResponse : BasicResponse
	{
		/// <summary>
		///   <para>Network address to connect to in order to join the match.</para>
		/// </summary>
		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06001E29 RID: 7721 RVA: 0x0000BD85 File Offset: 0x00009F85
		// (set) Token: 0x06001E2A RID: 7722 RVA: 0x0000BD8D File Offset: 0x00009F8D
		public string address { get; set; }

		/// <summary>
		///   <para>Network port to connect to in order to join the match.</para>
		/// </summary>
		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06001E2B RID: 7723 RVA: 0x0000BD96 File Offset: 0x00009F96
		// (set) Token: 0x06001E2C RID: 7724 RVA: 0x0000BD9E File Offset: 0x00009F9E
		public int port { get; set; }

		/// <summary>
		///   <para>NetworkID of the match.</para>
		/// </summary>
		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06001E2D RID: 7725 RVA: 0x0000BDA7 File Offset: 0x00009FA7
		// (set) Token: 0x06001E2E RID: 7726 RVA: 0x0000BDAF File Offset: 0x00009FAF
		public NetworkID networkId { get; set; }

		/// <summary>
		///   <para>JSON encoding for the binary access token this client uses to authenticate its session for future commands.</para>
		/// </summary>
		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06001E2F RID: 7727 RVA: 0x0000BDB8 File Offset: 0x00009FB8
		// (set) Token: 0x06001E30 RID: 7728 RVA: 0x0000BDC0 File Offset: 0x00009FC0
		public string accessTokenString { get; set; }

		/// <summary>
		///   <para>NodeID for the requesting client in the mach that it is joining.</para>
		/// </summary>
		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06001E31 RID: 7729 RVA: 0x0000BDC9 File Offset: 0x00009FC9
		// (set) Token: 0x06001E32 RID: 7730 RVA: 0x0000BDD1 File Offset: 0x00009FD1
		public NodeID nodeId { get; set; }

		/// <summary>
		///   <para>If the match is hosted by a relay server.</para>
		/// </summary>
		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06001E33 RID: 7731 RVA: 0x0000BDDA File Offset: 0x00009FDA
		// (set) Token: 0x06001E34 RID: 7732 RVA: 0x0000BDE2 File Offset: 0x00009FE2
		public bool usingRelay { get; set; }

		/// <summary>
		///   <para>Provides string description of current class data.</para>
		/// </summary>
		// Token: 0x06001E35 RID: 7733 RVA: 0x00024CCC File Offset: 0x00022ECC
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

		// Token: 0x06001E36 RID: 7734 RVA: 0x00024D48 File Offset: 0x00022F48
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
