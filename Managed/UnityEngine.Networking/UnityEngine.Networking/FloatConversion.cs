using System;

namespace UnityEngine.Networking
{
	// Token: 0x02000034 RID: 52
	internal class FloatConversion
	{
		// Token: 0x0600013B RID: 315 RVA: 0x00006B88 File Offset: 0x00004D88
		public static float ToSingle(uint value)
		{
			UIntFloat uintFloat = default(UIntFloat);
			uintFloat.intValue = value;
			return uintFloat.floatValue;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00006BAC File Offset: 0x00004DAC
		public static double ToDouble(ulong value)
		{
			UIntFloat uintFloat = default(UIntFloat);
			uintFloat.longValue = value;
			return uintFloat.doubleValue;
		}
	}
}
