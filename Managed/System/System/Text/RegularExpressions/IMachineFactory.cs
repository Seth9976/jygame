using System;
using System.Collections;

namespace System.Text.RegularExpressions
{
	// Token: 0x02000482 RID: 1154
	internal interface IMachineFactory
	{
		// Token: 0x060028C1 RID: 10433
		IMachine NewInstance();

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x060028C2 RID: 10434
		// (set) Token: 0x060028C3 RID: 10435
		IDictionary Mapping { get; set; }

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x060028C4 RID: 10436
		int GroupCount { get; }

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x060028C5 RID: 10437
		// (set) Token: 0x060028C6 RID: 10438
		int Gap { get; set; }

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x060028C7 RID: 10439
		// (set) Token: 0x060028C8 RID: 10440
		string[] NamesMapping { get; set; }
	}
}
