using System;

namespace UnityEngine.Assertions
{
	/// <summary>
	///   <para>An exception that is thrown on a failure. Assertions.Assert._raiseExceptions needs to be set to true.</para>
	/// </summary>
	// Token: 0x020002F8 RID: 760
	public class AssertionException : Exception
	{
		// Token: 0x06002323 RID: 8995 RVA: 0x0000E8B0 File Offset: 0x0000CAB0
		public AssertionException(string message, string userMessage)
			: base(message)
		{
			this.m_UserMessage = userMessage;
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06002324 RID: 8996 RVA: 0x0002E358 File Offset: 0x0002C558
		public override string Message
		{
			get
			{
				string text = base.Message;
				if (this.m_UserMessage != null)
				{
					text = text + '\n' + this.m_UserMessage;
				}
				return text;
			}
		}

		// Token: 0x04000BA6 RID: 2982
		private string m_UserMessage;
	}
}
