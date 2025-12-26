using System;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
	/// <summary>
	///   <para>JSON object to request a UNET match drop a client.</para>
	/// </summary>
	// Token: 0x02000208 RID: 520
	public class DropConnectionRequest : Request
	{
		/// <summary>
		///   <para>NetworkID of the match the client to drop is in.</para>
		/// </summary>
		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06001E3D RID: 7741 RVA: 0x0000BE4C File Offset: 0x0000A04C
		// (set) Token: 0x06001E3E RID: 7742 RVA: 0x0000BE54 File Offset: 0x0000A054
		public NetworkID networkId { get; set; }

		/// <summary>
		///   <para>NodeID of the connection to drop.</para>
		/// </summary>
		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06001E3F RID: 7743 RVA: 0x0000BE5D File Offset: 0x0000A05D
		// (set) Token: 0x06001E40 RID: 7744 RVA: 0x0000BE65 File Offset: 0x0000A065
		public NodeID nodeId { get; set; }

		/// <summary>
		///   <para>Provides string description of current class data.</para>
		/// </summary>
		// Token: 0x06001E41 RID: 7745 RVA: 0x00024DF8 File Offset: 0x00022FF8
		public override string ToString()
		{
			return UnityString.Format("[{0}]-networkId:0x{1},nodeId:0x{2}", new object[]
			{
				base.ToString(),
				this.networkId.ToString("X"),
				this.nodeId.ToString("X")
			});
		}

		/// <summary>
		///   <para>Accessor to verify if the contained data is a valid request with respect to initialized variables and accepted parameters.</para>
		/// </summary>
		// Token: 0x06001E42 RID: 7746 RVA: 0x0000BE6E File Offset: 0x0000A06E
		public override bool IsValid()
		{
			return base.IsValid() && this.networkId != NetworkID.Invalid && this.nodeId != NodeID.Invalid;
		}
	}
}
