using System;

// Token: 0x02000004 RID: 4
internal sealed class Locale
{
	// Token: 0x06000003 RID: 3 RVA: 0x000021C3 File Offset: 0x000003C3
	private Locale()
	{
	}

	// Token: 0x06000004 RID: 4 RVA: 0x000021CB File Offset: 0x000003CB
	public static string GetText(string msg)
	{
		return msg;
	}

	// Token: 0x06000005 RID: 5 RVA: 0x000021CE File Offset: 0x000003CE
	public static string GetText(string fmt, params object[] args)
	{
		return string.Format(fmt, args);
	}
}
