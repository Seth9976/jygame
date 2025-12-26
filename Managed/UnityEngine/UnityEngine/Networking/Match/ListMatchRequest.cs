using System;
using System.Collections.Generic;

namespace UnityEngine.Networking.Match
{
	/// <summary>
	///   <para>JSON object to request a list of UNET matches. This list is page based with a 1 index.</para>
	/// </summary>
	// Token: 0x02000209 RID: 521
	public class ListMatchRequest : Request
	{
		/// <summary>
		///   <para>Number of results per page to be returned.</para>
		/// </summary>
		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06001E44 RID: 7748 RVA: 0x0000BE97 File Offset: 0x0000A097
		// (set) Token: 0x06001E45 RID: 7749 RVA: 0x0000BE9F File Offset: 0x0000A09F
		public int pageSize { get; set; }

		/// <summary>
		///   <para>1 based page number requested.</para>
		/// </summary>
		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06001E46 RID: 7750 RVA: 0x0000BEA8 File Offset: 0x0000A0A8
		// (set) Token: 0x06001E47 RID: 7751 RVA: 0x0000BEB0 File Offset: 0x0000A0B0
		public int pageNum { get; set; }

		/// <summary>
		///   <para>Name filter to apply to the match list.</para>
		/// </summary>
		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06001E48 RID: 7752 RVA: 0x0000BEB9 File Offset: 0x0000A0B9
		// (set) Token: 0x06001E49 RID: 7753 RVA: 0x0000BEC1 File Offset: 0x0000A0C1
		public string nameFilter { get; set; }

		/// <summary>
		///   <para>Only return matches that have a password if this is true, only return matches without a password if this is false.</para>
		/// </summary>
		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06001E4A RID: 7754 RVA: 0x0000BECA File Offset: 0x0000A0CA
		// (set) Token: 0x06001E4B RID: 7755 RVA: 0x0000BED2 File Offset: 0x0000A0D2
		public bool includePasswordMatches { get; set; }

		/// <summary>
		///   <para>The optional game defined Elo score for the client making the request. The Elo score is averaged against all clients in a match and that value is used to produce better search results when listing available matches.
		/// If the Elo is provided the result set will be ordered according to the magnitude of the absoloute value of the difference of the a client searching for a match and the network average for all clients in each match. If the Elo score is not provided (and therefore 0 for all matches) the Elo score will not affect the search results.
		/// Each game can calculate this value as they wish according to whatever scale is best for that game.</para>
		/// </summary>
		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06001E4C RID: 7756 RVA: 0x0000BEDB File Offset: 0x0000A0DB
		// (set) Token: 0x06001E4D RID: 7757 RVA: 0x0000BEE3 File Offset: 0x0000A0E3
		public int eloScore { get; set; }

		/// <summary>
		///   <para>List of match attributes to filter against. This will filter down to matches that both have a name that contains the entire text string provided and the value specified in the filter is less than the attribute value for the matching name.
		/// No additional wildcards are allowed in the name. A maximum of 10 filters can be specified between all 3 filter lists.</para>
		/// </summary>
		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06001E4E RID: 7758 RVA: 0x0000BEEC File Offset: 0x0000A0EC
		// (set) Token: 0x06001E4F RID: 7759 RVA: 0x0000BEF4 File Offset: 0x0000A0F4
		public Dictionary<string, long> matchAttributeFilterLessThan { get; set; }

		/// <summary>
		///   <para>List of match attributes to filter against. This will filter down to matches that both have a name that contains the entire text string provided and the value specified in the filter is equal to the attribute value for the matching name.
		/// No additional wildcards are allowed in the name. A maximum of 10 filters can be specified between all 3 filter lists.</para>
		/// </summary>
		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06001E50 RID: 7760 RVA: 0x0000BEFD File Offset: 0x0000A0FD
		// (set) Token: 0x06001E51 RID: 7761 RVA: 0x0000BF05 File Offset: 0x0000A105
		public Dictionary<string, long> matchAttributeFilterEqualTo { get; set; }

		/// <summary>
		///   <para>List of match attributes to filter against. This will filter down to matches that both have a name that contains the entire text string provided and the value specified in the filter is greater than the attribute value for the matching name.
		/// No additional wildcards are allowed in the name. A maximum of 10 filters can be specified between all 3 filter lists.</para>
		/// </summary>
		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06001E52 RID: 7762 RVA: 0x0000BF0E File Offset: 0x0000A10E
		// (set) Token: 0x06001E53 RID: 7763 RVA: 0x0000BF16 File Offset: 0x0000A116
		public Dictionary<string, long> matchAttributeFilterGreaterThan { get; set; }

		/// <summary>
		///   <para>Provides string description of current class data.</para>
		/// </summary>
		// Token: 0x06001E54 RID: 7764 RVA: 0x00024E50 File Offset: 0x00023050
		public override string ToString()
		{
			return UnityString.Format("[{0}]-pageSize:{1},pageNum:{2},nameFilter:{3},matchAttributeFilterLessThan.Count:{4}, matchAttributeFilterGreaterThan.Count:{5}", new object[]
			{
				base.ToString(),
				this.pageSize,
				this.pageNum,
				this.nameFilter,
				(this.matchAttributeFilterLessThan != null) ? this.matchAttributeFilterLessThan.Count : 0,
				(this.matchAttributeFilterGreaterThan != null) ? this.matchAttributeFilterGreaterThan.Count : 0
			});
		}

		/// <summary>
		///   <para>Accessor to verify if the contained data is a valid request with respect to initialized variables and accepted parameters.</para>
		/// </summary>
		// Token: 0x06001E55 RID: 7765 RVA: 0x00024EE4 File Offset: 0x000230E4
		public override bool IsValid()
		{
			int num = ((this.matchAttributeFilterLessThan != null) ? this.matchAttributeFilterLessThan.Count : 0);
			num += ((this.matchAttributeFilterEqualTo != null) ? this.matchAttributeFilterEqualTo.Count : 0);
			num += ((this.matchAttributeFilterGreaterThan != null) ? this.matchAttributeFilterGreaterThan.Count : 0);
			return base.IsValid() && (this.pageSize >= 1 || this.pageSize <= 1000) && num <= 10;
		}
	}
}
