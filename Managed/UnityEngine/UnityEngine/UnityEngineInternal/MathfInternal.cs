using System;

namespace UnityEngineInternal
{
	// Token: 0x02000062 RID: 98
	public struct MathfInternal
	{
		// Token: 0x04000101 RID: 257
		public static volatile float FloatMinNormal = 1.1754944E-38f;

		// Token: 0x04000102 RID: 258
		public static volatile float FloatMinDenormal = float.Epsilon;

		// Token: 0x04000103 RID: 259
		public static bool IsFlushToZeroEnabled = MathfInternal.FloatMinDenormal == 0f;
	}
}
