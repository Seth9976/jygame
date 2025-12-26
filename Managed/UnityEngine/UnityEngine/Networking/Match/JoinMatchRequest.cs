using System;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
	/// <summary>
	///   <para>JSON object to request joining an existing UNET match.</para>
	/// </summary>
	// Token: 0x02000205 RID: 517
	public class JoinMatchRequest : Request
	{
		/// <summary>
		///   <para>NetworkID of the match to join.</para>
		/// </summary>
		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06001E1C RID: 7708 RVA: 0x0000BD13 File Offset: 0x00009F13
		// (set) Token: 0x06001E1D RID: 7709 RVA: 0x0000BD1B File Offset: 0x00009F1B
		public NetworkID networkId { get; set; }

		/// <summary>
		///   <para>The (optional) public network address for the client making the request. This is the internet available public address another client on the internet (but not the local network) could use to connect directly to the client making the request and may be used to better connect multiple clients. If it is not supplied the networking layer will still be completely functional.</para>
		/// </summary>
		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06001E1E RID: 7710 RVA: 0x0000BD24 File Offset: 0x00009F24
		// (set) Token: 0x06001E1F RID: 7711 RVA: 0x0000BD2C File Offset: 0x00009F2C
		public string publicAddress { get; set; }

		/// <summary>
		///   <para>The (optional) private network address for the client making the request. This is the local network available private address another client on the same network could use to connect directly to the client making the request and may be used to better connect multiple clients. If it is not supplied the networking layer will still be completely functional.</para>
		/// </summary>
		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06001E20 RID: 7712 RVA: 0x0000BD35 File Offset: 0x00009F35
		// (set) Token: 0x06001E21 RID: 7713 RVA: 0x0000BD3D File Offset: 0x00009F3D
		public string privateAddress { get; set; }

		/// <summary>
		///   <para>The optional game defined Elo score for the client making the request. The Elo score is averaged against all clients in a match and that value is used to produce better search results when listing available matches.
		/// If the Elo is provided the result set will be ordered according to the magnitude of the absoloute value of the difference of the a client searching for a match and the network average for all clients in each match. If the Elo score is not provided (and therefore 0 for all matches) the Elo score will not affect the search results.
		/// Each game can calculate this value as they wish according to whatever scale is best for that game.</para>
		/// </summary>
		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06001E22 RID: 7714 RVA: 0x0000BD46 File Offset: 0x00009F46
		// (set) Token: 0x06001E23 RID: 7715 RVA: 0x0000BD4E File Offset: 0x00009F4E
		public int eloScore { get; set; }

		/// <summary>
		///   <para>Password for the match to join. Leave blank for no password. Cannot be null.</para>
		/// </summary>
		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06001E24 RID: 7716 RVA: 0x0000BD57 File Offset: 0x00009F57
		// (set) Token: 0x06001E25 RID: 7717 RVA: 0x0000BD5F File Offset: 0x00009F5F
		public string password { get; set; }

		/// <summary>
		///   <para>Provides string description of current class data.</para>
		/// </summary>
		// Token: 0x06001E26 RID: 7718 RVA: 0x00024C64 File Offset: 0x00022E64
		public override string ToString()
		{
			return UnityString.Format("[{0}]-networkId:0x{1},HasPassword:{2}", new object[]
			{
				base.ToString(),
				this.networkId.ToString("X"),
				(!(this.password == string.Empty)) ? "YES" : "NO"
			});
		}

		/// <summary>
		///   <para>Accessor to verify if the contained data is a valid request with respect to initialized variables and accepted parameters.</para>
		/// </summary>
		// Token: 0x06001E27 RID: 7719 RVA: 0x0000BD68 File Offset: 0x00009F68
		public override bool IsValid()
		{
			return base.IsValid() && this.networkId != NetworkID.Invalid;
		}
	}
}
