using System;

namespace UnityEngine.UI
{
	// Token: 0x02000071 RID: 113
	internal static class SetPropertyUtility
	{
		// Token: 0x06000405 RID: 1029 RVA: 0x000133D4 File Offset: 0x000115D4
		public static bool SetColor(ref Color currentValue, Color newValue)
		{
			if (currentValue.r == newValue.r && currentValue.g == newValue.g && currentValue.b == newValue.b && currentValue.a == newValue.a)
			{
				return false;
			}
			currentValue = newValue;
			return true;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00013434 File Offset: 0x00011634
		public static bool SetStruct<T>(ref T currentValue, T newValue) where T : struct
		{
			if (currentValue.Equals(newValue))
			{
				return false;
			}
			currentValue = newValue;
			return true;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00013458 File Offset: 0x00011658
		public static bool SetClass<T>(ref T currentValue, T newValue) where T : class
		{
			if ((currentValue == null && newValue == null) || (currentValue != null && currentValue.Equals(newValue)))
			{
				return false;
			}
			currentValue = newValue;
			return true;
		}
	}
}
