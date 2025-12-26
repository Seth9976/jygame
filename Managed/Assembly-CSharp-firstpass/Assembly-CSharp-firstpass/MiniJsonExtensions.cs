using System;
using System.Collections;
using System.Collections.Generic;

// Token: 0x02000003 RID: 3
public static class MiniJsonExtensions
{
	// Token: 0x06000018 RID: 24 RVA: 0x00002CDC File Offset: 0x00000EDC
	public static string toJson(this Hashtable obj)
	{
		return MiniJSON.jsonEncode(obj);
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002CE4 File Offset: 0x00000EE4
	public static string toJson(this Dictionary<string, string> obj)
	{
		return MiniJSON.jsonEncode(obj);
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002CEC File Offset: 0x00000EEC
	public static ArrayList arrayListFromJson(this string json)
	{
		return MiniJSON.jsonDecode(json) as ArrayList;
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002CFC File Offset: 0x00000EFC
	public static Hashtable hashtableFromJson(this string json)
	{
		return MiniJSON.jsonDecode(json) as Hashtable;
	}
}
