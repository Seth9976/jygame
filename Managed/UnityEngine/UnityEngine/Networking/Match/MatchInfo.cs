using System;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
	/// <summary>
	///   <para>Details about a UNET Matchmaker match.</para>
	/// </summary>
	// Token: 0x02000217 RID: 535
	public class MatchInfo
	{
		// Token: 0x06001EA8 RID: 7848 RVA: 0x00025310 File Offset: 0x00023510
		public MatchInfo(CreateMatchResponse matchResponse)
		{
			this.address = matchResponse.address;
			this.port = matchResponse.port;
			this.networkId = matchResponse.networkId;
			this.accessToken = new NetworkAccessToken(matchResponse.accessTokenString);
			this.nodeId = matchResponse.nodeId;
			this.usingRelay = matchResponse.usingRelay;
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x00025370 File Offset: 0x00023570
		public MatchInfo(JoinMatchResponse matchResponse)
		{
			this.address = matchResponse.address;
			this.port = matchResponse.port;
			this.networkId = matchResponse.networkId;
			this.accessToken = new NetworkAccessToken(matchResponse.accessTokenString);
			this.nodeId = matchResponse.nodeId;
			this.usingRelay = matchResponse.usingRelay;
		}

		/// <summary>
		///   <para>IP address of the host of the match,.</para>
		/// </summary>
		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06001EAA RID: 7850 RVA: 0x0000C239 File Offset: 0x0000A439
		// (set) Token: 0x06001EAB RID: 7851 RVA: 0x0000C241 File Offset: 0x0000A441
		public string address { get; private set; }

		/// <summary>
		///   <para>Port of the host of the match.</para>
		/// </summary>
		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06001EAC RID: 7852 RVA: 0x0000C24A File Offset: 0x0000A44A
		// (set) Token: 0x06001EAD RID: 7853 RVA: 0x0000C252 File Offset: 0x0000A452
		public int port { get; private set; }

		/// <summary>
		///   <para>The unique ID of this match.</para>
		/// </summary>
		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06001EAE RID: 7854 RVA: 0x0000C25B File Offset: 0x0000A45B
		// (set) Token: 0x06001EAF RID: 7855 RVA: 0x0000C263 File Offset: 0x0000A463
		public NetworkID networkId { get; private set; }

		/// <summary>
		///   <para>The binary access token this client uses to authenticate its session for future commands.</para>
		/// </summary>
		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06001EB0 RID: 7856 RVA: 0x0000C26C File Offset: 0x0000A46C
		// (set) Token: 0x06001EB1 RID: 7857 RVA: 0x0000C274 File Offset: 0x0000A474
		public NetworkAccessToken accessToken { get; private set; }

		/// <summary>
		///   <para>NodeID for this member client in the match.</para>
		/// </summary>
		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06001EB2 RID: 7858 RVA: 0x0000C27D File Offset: 0x0000A47D
		// (set) Token: 0x06001EB3 RID: 7859 RVA: 0x0000C285 File Offset: 0x0000A485
		public NodeID nodeId { get; private set; }

		/// <summary>
		///   <para>Flag to say if the math uses a relay server.</para>
		/// </summary>
		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06001EB4 RID: 7860 RVA: 0x0000C28E File Offset: 0x0000A48E
		// (set) Token: 0x06001EB5 RID: 7861 RVA: 0x0000C296 File Offset: 0x0000A496
		public bool usingRelay { get; private set; }

		// Token: 0x06001EB6 RID: 7862 RVA: 0x000253D0 File Offset: 0x000235D0
		public override string ToString()
		{
			return UnityString.Format("{0} @ {1}:{2} [{3},{4}]", new object[] { this.networkId, this.address, this.port, this.nodeId, this.usingRelay });
		}
	}
}
