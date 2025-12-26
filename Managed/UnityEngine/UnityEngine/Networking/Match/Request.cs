using System;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
	/// <summary>
	///   <para>Abstract base for requests, which includes common info in all requests.</para>
	/// </summary>
	// Token: 0x020001FC RID: 508
	public abstract class Request
	{
		/// <summary>
		///   <para>SourceID for the current client, required in every request. This is generated from the Cloud API.</para>
		/// </summary>
		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06001DD0 RID: 7632 RVA: 0x0000B982 File Offset: 0x00009B82
		// (set) Token: 0x06001DD1 RID: 7633 RVA: 0x0000B98A File Offset: 0x00009B8A
		public SourceID sourceId { get; set; }

		/// <summary>
		///   <para>The Cloud Project Id for this game, required in every request. This is used to match games of the same type.</para>
		/// </summary>
		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06001DD2 RID: 7634 RVA: 0x0000B993 File Offset: 0x00009B93
		// (set) Token: 0x06001DD3 RID: 7635 RVA: 0x0000B99B File Offset: 0x00009B9B
		public string projectId { get; set; }

		/// <summary>
		///   <para>AppID for the current game, required in every request. This is generated from the Cloud API.</para>
		/// </summary>
		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06001DD4 RID: 7636 RVA: 0x0000B9A4 File Offset: 0x00009BA4
		// (set) Token: 0x06001DD5 RID: 7637 RVA: 0x0000B9AC File Offset: 0x00009BAC
		public AppID appId { get; set; }

		/// <summary>
		///   <para>The JSON encoded binary access token this client uses to authenticate its session for future commands.</para>
		/// </summary>
		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06001DD6 RID: 7638 RVA: 0x0000B9B5 File Offset: 0x00009BB5
		// (set) Token: 0x06001DD7 RID: 7639 RVA: 0x0000B9BD File Offset: 0x00009BBD
		public string accessTokenString { get; set; }

		/// <summary>
		///   <para>Domain for the request. All commands will be sandboxed to their own domain; For example no clients with domain 1 will see matches with domain 2. This can be used to prevent incompatible client versions from communicating.</para>
		/// </summary>
		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06001DD8 RID: 7640 RVA: 0x0000B9C6 File Offset: 0x00009BC6
		// (set) Token: 0x06001DD9 RID: 7641 RVA: 0x0000B9CE File Offset: 0x00009BCE
		public int domain { get; set; }

		/// <summary>
		///   <para>Accessor to verify if the contained data is a valid request with respect to initialized variables and accepted parameters.</para>
		/// </summary>
		// Token: 0x06001DDA RID: 7642 RVA: 0x0000B9D7 File Offset: 0x00009BD7
		public virtual bool IsValid()
		{
			return this.appId != AppID.Invalid && this.sourceId != SourceID.Invalid;
		}

		/// <summary>
		///   <para>Provides string description of current class data.</para>
		/// </summary>
		// Token: 0x06001DDB RID: 7643 RVA: 0x00024858 File Offset: 0x00022A58
		public override string ToString()
		{
			return UnityString.Format("[{0}]-SourceID:0x{1},AppID:0x{2},domain:{3}", new object[]
			{
				base.ToString(),
				this.sourceId.ToString("X"),
				this.appId.ToString("X"),
				this.domain
			});
		}

		/// <summary>
		///   <para>Matchmaker protocol version info.</para>
		/// </summary>
		// Token: 0x040007EB RID: 2027
		public int version = 2;
	}
}
