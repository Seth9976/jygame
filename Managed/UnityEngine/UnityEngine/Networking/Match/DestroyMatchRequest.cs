using System;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
	/// <summary>
	///   <para>JSON object to request a UNET match destruction.</para>
	/// </summary>
	// Token: 0x02000207 RID: 519
	public class DestroyMatchRequest : Request
	{
		/// <summary>
		///   <para>NetworkID of the match to destroy.</para>
		/// </summary>
		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06001E38 RID: 7736 RVA: 0x0000BDEB File Offset: 0x00009FEB
		// (set) Token: 0x06001E39 RID: 7737 RVA: 0x0000BDF3 File Offset: 0x00009FF3
		public NetworkID networkId { get; set; }

		/// <summary>
		///   <para>Provides string description of current class data.</para>
		/// </summary>
		// Token: 0x06001E3A RID: 7738 RVA: 0x0000BDFC File Offset: 0x00009FFC
		public override string ToString()
		{
			return UnityString.Format("[{0}]-networkId:0x{1}", new object[]
			{
				base.ToString(),
				this.networkId.ToString("X")
			});
		}

		/// <summary>
		///   <para>Accessor to verify if the contained data is a valid request with respect to initialized variables and accepted parameters.</para>
		/// </summary>
		// Token: 0x06001E3B RID: 7739 RVA: 0x0000BE2F File Offset: 0x0000A02F
		public override bool IsValid()
		{
			return base.IsValid() && this.networkId != NetworkID.Invalid;
		}
	}
}
