using System;
using System.Collections.Generic;

namespace UnityEngine.Networking.Match
{
	/// <summary>
	///   <para>JSON response for a ListMatchRequest. It contains a list of matches that can be parsed through to describe a page of matches.</para>
	/// </summary>
	// Token: 0x0200020C RID: 524
	public class ListMatchResponse : BasicResponse
	{
		/// <summary>
		///   <para>Constructor for response class.</para>
		/// </summary>
		/// <param name="matches">A list of matches to give to the object. Only used when generating a new response and not used by callers of a ListMatchRequest.</param>
		/// <param name="otherMatches"></param>
		// Token: 0x06001E74 RID: 7796 RVA: 0x0000BBE1 File Offset: 0x00009DE1
		public ListMatchResponse()
		{
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x0000C026 File Offset: 0x0000A226
		public ListMatchResponse(List<MatchDesc> otherMatches)
		{
			this.matches = otherMatches;
		}

		/// <summary>
		///   <para>List of matches fitting the requested description.</para>
		/// </summary>
		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06001E76 RID: 7798 RVA: 0x0000C035 File Offset: 0x0000A235
		// (set) Token: 0x06001E77 RID: 7799 RVA: 0x0000C03D File Offset: 0x0000A23D
		public List<MatchDesc> matches { get; set; }

		/// <summary>
		///   <para>Provides string description of current class data.</para>
		/// </summary>
		// Token: 0x06001E78 RID: 7800 RVA: 0x0000C046 File Offset: 0x0000A246
		public override string ToString()
		{
			return UnityString.Format("[{0}]-matches.Count:{1}", new object[]
			{
				base.ToString(),
				this.matches.Count
			});
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x00025150 File Offset: 0x00023350
		public override void Parse(object obj)
		{
			base.Parse(obj);
			IDictionary<string, object> dictionary = obj as IDictionary<string, object>;
			if (dictionary != null)
			{
				this.matches = base.ParseJSONList<MatchDesc>("matches", obj, dictionary);
				return;
			}
			throw new FormatException("While parsing JSON response, found obj is not of type IDictionary<string,object>:" + obj.ToString());
		}
	}
}
