using System;

namespace UnityEngineInternal
{
	// Token: 0x0200030B RID: 779
	[AttributeUsage(AttributeTargets.Method)]
	[Serializable]
	public class TypeInferenceRuleAttribute : Attribute
	{
		// Token: 0x06002373 RID: 9075 RVA: 0x0000EBB3 File Offset: 0x0000CDB3
		public TypeInferenceRuleAttribute(TypeInferenceRules rule)
			: this(rule.ToString())
		{
		}

		// Token: 0x06002374 RID: 9076 RVA: 0x0000EBC6 File Offset: 0x0000CDC6
		public TypeInferenceRuleAttribute(string rule)
		{
			this._rule = rule;
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x0000EBD5 File Offset: 0x0000CDD5
		public override string ToString()
		{
			return this._rule;
		}

		// Token: 0x04000BC7 RID: 3015
		private readonly string _rule;
	}
}
