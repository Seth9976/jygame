using System;

namespace System.Text.RegularExpressions
{
	// Token: 0x02000481 RID: 1153
	internal interface IMachine
	{
		// Token: 0x060028BD RID: 10429
		Match Scan(Regex regex, string text, int start, int end);

		// Token: 0x060028BE RID: 10430
		string[] Split(Regex regex, string input, int count, int startat);

		// Token: 0x060028BF RID: 10431
		string Replace(Regex regex, string input, string replacement, int count, int startat);

		// Token: 0x060028C0 RID: 10432
		string Result(string replacement, Match match);
	}
}
