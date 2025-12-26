using System;

namespace UnityEngine.Assertions
{
	// Token: 0x020002F9 RID: 761
	internal class AssertionMessageUtil
	{
		// Token: 0x06002326 RID: 8998 RVA: 0x0000E8C0 File Offset: 0x0000CAC0
		public static string GetMessage(string failureMessage)
		{
			return UnityString.Format("{0} {1}", new object[] { "Assertion failed.", failureMessage });
		}

		// Token: 0x06002327 RID: 8999 RVA: 0x0000E8DE File Offset: 0x0000CADE
		public static string GetMessage(string failureMessage, string expected)
		{
			return AssertionMessageUtil.GetMessage(UnityString.Format("{0}{1}{2} {3}", new object[]
			{
				failureMessage,
				Environment.NewLine,
				"Expected:",
				expected
			}));
		}

		// Token: 0x06002328 RID: 9000 RVA: 0x0002E38C File Offset: 0x0002C58C
		public static string GetEqualityMessage(object actual, object expected, bool expectEqual)
		{
			return AssertionMessageUtil.GetMessage(UnityString.Format("Values are {0}equal.", new object[] { (!expectEqual) ? string.Empty : "not " }), UnityString.Format("{0} {2} {1}", new object[]
			{
				actual,
				expected,
				(!expectEqual) ? "!=" : "=="
			}));
		}

		// Token: 0x06002329 RID: 9001 RVA: 0x0002E3F8 File Offset: 0x0002C5F8
		public static string NullFailureMessage(object value, bool expectNull)
		{
			return AssertionMessageUtil.GetMessage(UnityString.Format("Value was {0}Null", new object[] { (!expectNull) ? string.Empty : "not " }), UnityString.Format("Value was {0}Null", new object[] { (!expectNull) ? "not " : string.Empty }));
		}

		// Token: 0x0600232A RID: 9002 RVA: 0x0000E90D File Offset: 0x0000CB0D
		public static string BooleanFailureMessage(bool expected)
		{
			return AssertionMessageUtil.GetMessage("Value was " + !expected, expected.ToString());
		}

		// Token: 0x04000BA7 RID: 2983
		private const string k_Expected = "Expected:";

		// Token: 0x04000BA8 RID: 2984
		private const string k_AssertionFailed = "Assertion failed.";
	}
}
