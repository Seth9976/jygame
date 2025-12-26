using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>The language the user's operating system is running in. Returned by Application.systemLanguage.</para>
	/// </summary>
	// Token: 0x0200000A RID: 10
	public enum SystemLanguage
	{
		/// <summary>
		///   <para>Afrikaans.</para>
		/// </summary>
		// Token: 0x04000031 RID: 49
		Afrikaans,
		/// <summary>
		///   <para>Arabic.</para>
		/// </summary>
		// Token: 0x04000032 RID: 50
		Arabic,
		/// <summary>
		///   <para>Basque.</para>
		/// </summary>
		// Token: 0x04000033 RID: 51
		Basque,
		/// <summary>
		///   <para>Belarusian.</para>
		/// </summary>
		// Token: 0x04000034 RID: 52
		Belarusian,
		/// <summary>
		///   <para>Bulgarian.</para>
		/// </summary>
		// Token: 0x04000035 RID: 53
		Bulgarian,
		/// <summary>
		///   <para>Catalan.</para>
		/// </summary>
		// Token: 0x04000036 RID: 54
		Catalan,
		/// <summary>
		///   <para>Chinese.</para>
		/// </summary>
		// Token: 0x04000037 RID: 55
		Chinese,
		/// <summary>
		///   <para>Czech.</para>
		/// </summary>
		// Token: 0x04000038 RID: 56
		Czech,
		/// <summary>
		///   <para>Danish.</para>
		/// </summary>
		// Token: 0x04000039 RID: 57
		Danish,
		/// <summary>
		///   <para>Dutch.</para>
		/// </summary>
		// Token: 0x0400003A RID: 58
		Dutch,
		/// <summary>
		///   <para>English.</para>
		/// </summary>
		// Token: 0x0400003B RID: 59
		English,
		/// <summary>
		///   <para>Estonian.</para>
		/// </summary>
		// Token: 0x0400003C RID: 60
		Estonian,
		/// <summary>
		///   <para>Faroese.</para>
		/// </summary>
		// Token: 0x0400003D RID: 61
		Faroese,
		/// <summary>
		///   <para>Finnish.</para>
		/// </summary>
		// Token: 0x0400003E RID: 62
		Finnish,
		/// <summary>
		///   <para>French.</para>
		/// </summary>
		// Token: 0x0400003F RID: 63
		French,
		/// <summary>
		///   <para>German.</para>
		/// </summary>
		// Token: 0x04000040 RID: 64
		German,
		/// <summary>
		///   <para>Greek.</para>
		/// </summary>
		// Token: 0x04000041 RID: 65
		Greek,
		/// <summary>
		///   <para>Hebrew.</para>
		/// </summary>
		// Token: 0x04000042 RID: 66
		Hebrew,
		/// <summary>
		///   <para>Icelandic.</para>
		/// </summary>
		// Token: 0x04000043 RID: 67
		Icelandic = 19,
		/// <summary>
		///   <para>Indonesian.</para>
		/// </summary>
		// Token: 0x04000044 RID: 68
		Indonesian,
		/// <summary>
		///   <para>Italian.</para>
		/// </summary>
		// Token: 0x04000045 RID: 69
		Italian,
		/// <summary>
		///   <para>Japanese.</para>
		/// </summary>
		// Token: 0x04000046 RID: 70
		Japanese,
		/// <summary>
		///   <para>Korean.</para>
		/// </summary>
		// Token: 0x04000047 RID: 71
		Korean,
		/// <summary>
		///   <para>Latvian.</para>
		/// </summary>
		// Token: 0x04000048 RID: 72
		Latvian,
		/// <summary>
		///   <para>Lithuanian.</para>
		/// </summary>
		// Token: 0x04000049 RID: 73
		Lithuanian,
		/// <summary>
		///   <para>Norwegian.</para>
		/// </summary>
		// Token: 0x0400004A RID: 74
		Norwegian,
		/// <summary>
		///   <para>Polish.</para>
		/// </summary>
		// Token: 0x0400004B RID: 75
		Polish,
		/// <summary>
		///   <para>Portuguese.</para>
		/// </summary>
		// Token: 0x0400004C RID: 76
		Portuguese,
		/// <summary>
		///   <para>Romanian.</para>
		/// </summary>
		// Token: 0x0400004D RID: 77
		Romanian,
		/// <summary>
		///   <para>Russian.</para>
		/// </summary>
		// Token: 0x0400004E RID: 78
		Russian,
		/// <summary>
		///   <para>Serbo-Croatian.</para>
		/// </summary>
		// Token: 0x0400004F RID: 79
		SerboCroatian,
		/// <summary>
		///   <para>Slovak.</para>
		/// </summary>
		// Token: 0x04000050 RID: 80
		Slovak,
		/// <summary>
		///   <para>Slovenian.</para>
		/// </summary>
		// Token: 0x04000051 RID: 81
		Slovenian,
		/// <summary>
		///   <para>Spanish.</para>
		/// </summary>
		// Token: 0x04000052 RID: 82
		Spanish,
		/// <summary>
		///   <para>Swedish.</para>
		/// </summary>
		// Token: 0x04000053 RID: 83
		Swedish,
		/// <summary>
		///   <para>Thai.</para>
		/// </summary>
		// Token: 0x04000054 RID: 84
		Thai,
		/// <summary>
		///   <para>Turkish.</para>
		/// </summary>
		// Token: 0x04000055 RID: 85
		Turkish,
		/// <summary>
		///   <para>Ukrainian.</para>
		/// </summary>
		// Token: 0x04000056 RID: 86
		Ukrainian,
		/// <summary>
		///   <para>Vietnamese.</para>
		/// </summary>
		// Token: 0x04000057 RID: 87
		Vietnamese,
		/// <summary>
		///   <para>ChineseSimplified.</para>
		/// </summary>
		// Token: 0x04000058 RID: 88
		ChineseSimplified,
		/// <summary>
		///   <para>ChineseTraditional.</para>
		/// </summary>
		// Token: 0x04000059 RID: 89
		ChineseTraditional,
		/// <summary>
		///   <para>Unknown.</para>
		/// </summary>
		// Token: 0x0400005A RID: 90
		Unknown,
		/// <summary>
		///   <para>Hungarian.</para>
		/// </summary>
		// Token: 0x0400005B RID: 91
		Hungarian = 18
	}
}
