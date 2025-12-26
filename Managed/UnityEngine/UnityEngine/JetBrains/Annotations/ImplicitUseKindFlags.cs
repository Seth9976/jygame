using System;

namespace JetBrains.Annotations
{
	// Token: 0x020002A4 RID: 676
	[Flags]
	public enum ImplicitUseKindFlags
	{
		// Token: 0x04000A88 RID: 2696
		Default = 7,
		// Token: 0x04000A89 RID: 2697
		Access = 1,
		// Token: 0x04000A8A RID: 2698
		Assign = 2,
		// Token: 0x04000A8B RID: 2699
		InstantiatedWithFixedConstructorSignature = 4,
		// Token: 0x04000A8C RID: 2700
		InstantiatedNoFixedConstructorSignature = 8
	}
}
