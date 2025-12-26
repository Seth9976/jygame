using System;
using System.Collections.Generic;

namespace UnityEngine.Networking.Match
{
	/// <summary>
	///   <para>Abstract class that contains shared accessors for any response.</para>
	/// </summary>
	// Token: 0x020001FF RID: 511
	public abstract class Response : ResponseBase, IResponse
	{
		/// <summary>
		///   <para>Bool describing if the request was successful.</para>
		/// </summary>
		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06001DEC RID: 7660 RVA: 0x0000BB48 File Offset: 0x00009D48
		// (set) Token: 0x06001DED RID: 7661 RVA: 0x0000BB50 File Offset: 0x00009D50
		public bool success { get; private set; }

		/// <summary>
		///   <para>Extended string information that is returned when the server encounters an error processing a request.</para>
		/// </summary>
		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06001DEE RID: 7662 RVA: 0x0000BB59 File Offset: 0x00009D59
		// (set) Token: 0x06001DEF RID: 7663 RVA: 0x0000BB61 File Offset: 0x00009D61
		public string extendedInfo { get; private set; }

		// Token: 0x06001DF0 RID: 7664 RVA: 0x0000BB6A File Offset: 0x00009D6A
		public void SetSuccess()
		{
			this.success = true;
			this.extendedInfo = string.Empty;
		}

		// Token: 0x06001DF1 RID: 7665 RVA: 0x0000BB7E File Offset: 0x00009D7E
		public void SetFailure(string info)
		{
			this.success = false;
			this.extendedInfo = info;
		}

		/// <summary>
		///   <para>Provides string description of current class data.</para>
		/// </summary>
		// Token: 0x06001DF2 RID: 7666 RVA: 0x0000BB8E File Offset: 0x00009D8E
		public override string ToString()
		{
			return UnityString.Format("[{0}]-success:{1}-extendedInfo:{2}", new object[]
			{
				base.ToString(),
				this.success,
				this.extendedInfo
			});
		}

		// Token: 0x06001DF3 RID: 7667 RVA: 0x00024A3C File Offset: 0x00022C3C
		public override void Parse(object obj)
		{
			IDictionary<string, object> dictionary = obj as IDictionary<string, object>;
			if (dictionary != null)
			{
				this.success = base.ParseJSONBool("success", obj, dictionary);
				this.extendedInfo = base.ParseJSONString("extendedInfo", obj, dictionary);
				if (!this.success)
				{
					throw new FormatException("FAILURE Returned from server: " + this.extendedInfo);
				}
			}
		}
	}
}
