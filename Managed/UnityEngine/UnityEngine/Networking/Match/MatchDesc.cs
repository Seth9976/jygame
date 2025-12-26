using System;
using System.Collections.Generic;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
	/// <summary>
	///   <para>A member contained in a ListMatchResponse.matches list. Each element describes an individual match.</para>
	/// </summary>
	// Token: 0x0200020B RID: 523
	public class MatchDesc : ResponseBase
	{
		/// <summary>
		///   <para>NetworkID of the match.</para>
		/// </summary>
		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06001E60 RID: 7776 RVA: 0x0000BF8D File Offset: 0x0000A18D
		// (set) Token: 0x06001E61 RID: 7777 RVA: 0x0000BF95 File Offset: 0x0000A195
		public NetworkID networkId { get; set; }

		/// <summary>
		///   <para>Name of the match.</para>
		/// </summary>
		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06001E62 RID: 7778 RVA: 0x0000BF9E File Offset: 0x0000A19E
		// (set) Token: 0x06001E63 RID: 7779 RVA: 0x0000BFA6 File Offset: 0x0000A1A6
		public string name { get; set; }

		/// <summary>
		///   <para>The optional game defined Elo score for the match as a whole. The Elo score is averaged against all clients in a match and that value is used to produce better search results when listing available matches.
		/// If the Elo is provided the result set will be ordered according to the magnitude of the absoloute value of the difference of the a client searching for a match and the network average for all clients in each match. If the Elo score is not provided (and therefore 0 for all matches) the Elo score will not affect the search results.
		/// Each game can calculate this value as they wish according to whatever scale is best for that game.</para>
		/// </summary>
		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06001E64 RID: 7780 RVA: 0x0000BFAF File Offset: 0x0000A1AF
		// (set) Token: 0x06001E65 RID: 7781 RVA: 0x0000BFB7 File Offset: 0x0000A1B7
		public int averageEloScore { get; set; }

		/// <summary>
		///   <para>Max number of users that may connect to a match.</para>
		/// </summary>
		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06001E66 RID: 7782 RVA: 0x0000BFC0 File Offset: 0x0000A1C0
		// (set) Token: 0x06001E67 RID: 7783 RVA: 0x0000BFC8 File Offset: 0x0000A1C8
		public int maxSize { get; set; }

		/// <summary>
		///   <para>Current number of users connected to a match.</para>
		/// </summary>
		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06001E68 RID: 7784 RVA: 0x0000BFD1 File Offset: 0x0000A1D1
		// (set) Token: 0x06001E69 RID: 7785 RVA: 0x0000BFD9 File Offset: 0x0000A1D9
		public int currentSize { get; set; }

		/// <summary>
		///   <para>Describes if this match is considered private.</para>
		/// </summary>
		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06001E6A RID: 7786 RVA: 0x0000BFE2 File Offset: 0x0000A1E2
		// (set) Token: 0x06001E6B RID: 7787 RVA: 0x0000BFEA File Offset: 0x0000A1EA
		public bool isPrivate { get; set; }

		/// <summary>
		///   <para>Match attributes describing game specific features for this match. Each attribute is a key/value pair of a string key with a long value. Each match may have up to 10 of these values.
		/// The game is free to use this as desired to assist in finding better match results when clients search for matches to join.</para>
		/// </summary>
		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06001E6C RID: 7788 RVA: 0x0000BFF3 File Offset: 0x0000A1F3
		// (set) Token: 0x06001E6D RID: 7789 RVA: 0x0000BFFB File Offset: 0x0000A1FB
		public Dictionary<string, long> matchAttributes { get; set; }

		/// <summary>
		///   <para>The NodeID of the host in a matchmaker match.</para>
		/// </summary>
		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06001E6E RID: 7790 RVA: 0x0000C004 File Offset: 0x0000A204
		// (set) Token: 0x06001E6F RID: 7791 RVA: 0x0000C00C File Offset: 0x0000A20C
		public NodeID hostNodeId { get; set; }

		/// <summary>
		///   <para>Direct connection info for network games; This is not required for games utilizing matchmaker.</para>
		/// </summary>
		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06001E70 RID: 7792 RVA: 0x0000C015 File Offset: 0x0000A215
		// (set) Token: 0x06001E71 RID: 7793 RVA: 0x0000C01D File Offset: 0x0000A21D
		public List<MatchDirectConnectInfo> directConnectInfos { get; set; }

		/// <summary>
		///   <para>Provides string description of current class data.</para>
		/// </summary>
		// Token: 0x06001E72 RID: 7794 RVA: 0x00024FF0 File Offset: 0x000231F0
		public override string ToString()
		{
			return UnityString.Format("[{0}]-networkId:0x{1},name:{2},averageEloScore:{3},maxSize:{4},currentSize:{5},isPrivate:{6},matchAttributes.Count:{7},directConnectInfos.Count:{8}", new object[]
			{
				base.ToString(),
				this.networkId.ToString("X"),
				this.name,
				this.averageEloScore,
				this.maxSize,
				this.currentSize,
				this.isPrivate,
				(this.matchAttributes != null) ? this.matchAttributes.Count : 0,
				this.directConnectInfos.Count
			});
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x000250A8 File Offset: 0x000232A8
		public override void Parse(object obj)
		{
			IDictionary<string, object> dictionary = obj as IDictionary<string, object>;
			if (dictionary != null)
			{
				this.networkId = (NetworkID)base.ParseJSONUInt64("networkId", obj, dictionary);
				this.name = base.ParseJSONString("name", obj, dictionary);
				this.maxSize = base.ParseJSONInt32("maxSize", obj, dictionary);
				this.currentSize = base.ParseJSONInt32("currentSize", obj, dictionary);
				this.isPrivate = base.ParseJSONBool("isPrivate", obj, dictionary);
				this.directConnectInfos = base.ParseJSONList<MatchDirectConnectInfo>("directConnectInfos", obj, dictionary);
				return;
			}
			throw new FormatException("While parsing JSON response, found obj is not of type IDictionary<string,object>:" + obj.ToString());
		}
	}
}
