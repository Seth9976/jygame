using System;
using System.Collections.Generic;

namespace UnityEngine.Networking.Match
{
	/// <summary>
	///   <para>JSON object to request a UNET match creation.</para>
	/// </summary>
	// Token: 0x02000203 RID: 515
	public class CreateMatchRequest : Request
	{
		/// <summary>
		///   <para>Name of the match to create.</para>
		/// </summary>
		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06001DFA RID: 7674 RVA: 0x0000BBE9 File Offset: 0x00009DE9
		// (set) Token: 0x06001DFB RID: 7675 RVA: 0x0000BBF1 File Offset: 0x00009DF1
		public string name { get; set; }

		/// <summary>
		///   <para>Max number of clients that may join the match to create, including the host.</para>
		/// </summary>
		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06001DFC RID: 7676 RVA: 0x0000BBFA File Offset: 0x00009DFA
		// (set) Token: 0x06001DFD RID: 7677 RVA: 0x0000BC02 File Offset: 0x00009E02
		public uint size { get; set; }

		/// <summary>
		///   <para>The (optional) public network address for the client making the request. This is the internet available public address another client on the internet (but not the local network) could use to connect directly to the client making the request and may be used to better connect multiple clients. If it is not supplied the networking layer will still be completely functional.</para>
		/// </summary>
		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06001DFE RID: 7678 RVA: 0x0000BC0B File Offset: 0x00009E0B
		// (set) Token: 0x06001DFF RID: 7679 RVA: 0x0000BC13 File Offset: 0x00009E13
		public string publicAddress { get; set; }

		/// <summary>
		///   <para>The (optional) private network address for the client making the request. This is the local network available private address another client on the same network could use to connect directly to the client making the request and may be used to better connect multiple clients. If it is not supplied the networking layer will still be completely functional.</para>
		/// </summary>
		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06001E00 RID: 7680 RVA: 0x0000BC1C File Offset: 0x00009E1C
		// (set) Token: 0x06001E01 RID: 7681 RVA: 0x0000BC24 File Offset: 0x00009E24
		public string privateAddress { get; set; }

		/// <summary>
		///   <para>The optional game defined Elo score for the client making the request. The Elo score is averaged against all clients in a match and that value is used to produce better search results when listing available matches.
		/// If the Elo is provided the result set will be ordered according to the magnitude of the absoloute value of the difference of the a client searching for a match and the network average for all clients in each match. If the Elo score is not provided (and therefore 0 for all matches) the Elo score will not affect the search results.
		/// Each game can calculate this value as they wish according to whatever scale is best for that game.</para>
		/// </summary>
		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06001E02 RID: 7682 RVA: 0x0000BC2D File Offset: 0x00009E2D
		// (set) Token: 0x06001E03 RID: 7683 RVA: 0x0000BC35 File Offset: 0x00009E35
		public int eloScore { get; set; }

		/// <summary>
		///   <para>Bool to describe if the created match should be advertised.</para>
		/// </summary>
		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06001E04 RID: 7684 RVA: 0x0000BC3E File Offset: 0x00009E3E
		// (set) Token: 0x06001E05 RID: 7685 RVA: 0x0000BC46 File Offset: 0x00009E46
		public bool advertise { get; set; }

		/// <summary>
		///   <para>Password for the match to create. Leave blank for no password. Cannot be null.</para>
		/// </summary>
		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06001E06 RID: 7686 RVA: 0x0000BC4F File Offset: 0x00009E4F
		// (set) Token: 0x06001E07 RID: 7687 RVA: 0x0000BC57 File Offset: 0x00009E57
		public string password { get; set; }

		/// <summary>
		///   <para>Match attributes describing game specific features for this match. Each attribute is a key/value pair of a string key with a long value. Each match may have up to 10 of these values.
		/// The game is free to use this as desired to assist in finding better match results when clients search for matches to join.</para>
		/// </summary>
		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06001E08 RID: 7688 RVA: 0x0000BC60 File Offset: 0x00009E60
		// (set) Token: 0x06001E09 RID: 7689 RVA: 0x0000BC68 File Offset: 0x00009E68
		public Dictionary<string, long> matchAttributes { get; set; }

		/// <summary>
		///   <para>Provides string description of current class data.</para>
		/// </summary>
		// Token: 0x06001E0A RID: 7690 RVA: 0x00024AA0 File Offset: 0x00022CA0
		public override string ToString()
		{
			return UnityString.Format("[{0}]-name:{1},size:{2},advertise:{3},HasPassword:{4},matchAttributes.Count:{5}", new object[]
			{
				base.ToString(),
				this.name,
				this.size,
				this.advertise,
				(!(this.password == string.Empty)) ? "YES" : "NO",
				(this.matchAttributes != null) ? this.matchAttributes.Count : 0
			});
		}

		/// <summary>
		///   <para>Accessor to verify if the contained data is a valid request with respect to initialized variables and accepted parameters.</para>
		/// </summary>
		// Token: 0x06001E0B RID: 7691 RVA: 0x0000BC71 File Offset: 0x00009E71
		public override bool IsValid()
		{
			return (base.IsValid() && this.size >= 2U && this.matchAttributes == null) || this.matchAttributes.Count <= 10;
		}
	}
}
