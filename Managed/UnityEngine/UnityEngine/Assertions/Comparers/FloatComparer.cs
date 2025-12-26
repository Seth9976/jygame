using System;
using System.Collections.Generic;

namespace UnityEngine.Assertions.Comparers
{
	// Token: 0x020002FA RID: 762
	internal class FloatComparer : IEqualityComparer<float>
	{
		// Token: 0x0600232B RID: 9003 RVA: 0x0000E92E File Offset: 0x0000CB2E
		public FloatComparer()
			: this(1E-05f, false)
		{
		}

		// Token: 0x0600232C RID: 9004 RVA: 0x0000E93C File Offset: 0x0000CB3C
		public FloatComparer(bool relative)
			: this(1E-05f, relative)
		{
		}

		// Token: 0x0600232D RID: 9005 RVA: 0x0000E94A File Offset: 0x0000CB4A
		public FloatComparer(float error)
			: this(error, false)
		{
		}

		// Token: 0x0600232E RID: 9006 RVA: 0x0000E954 File Offset: 0x0000CB54
		public FloatComparer(float error, bool relative)
		{
			this.m_Error = error;
			this.m_Relative = relative;
		}

		// Token: 0x06002330 RID: 9008 RVA: 0x0000E97B File Offset: 0x0000CB7B
		public bool Equals(float a, float b)
		{
			return (!this.m_Relative) ? FloatComparer.AreEqual(a, b, this.m_Error) : FloatComparer.AreEqualRelative(a, b, this.m_Error);
		}

		// Token: 0x06002331 RID: 9009 RVA: 0x0000E9A7 File Offset: 0x0000CBA7
		public int GetHashCode(float obj)
		{
			return base.GetHashCode();
		}

		// Token: 0x06002332 RID: 9010 RVA: 0x0000E9AF File Offset: 0x0000CBAF
		public static bool AreEqual(float expected, float actual, float error)
		{
			return Math.Abs(actual - expected) <= error;
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x0002E45C File Offset: 0x0002C65C
		public static bool AreEqualRelative(float expected, float actual, float error)
		{
			if (expected == actual)
			{
				return true;
			}
			float num = Math.Abs(expected);
			float num2 = Math.Abs(actual);
			float num3 = Math.Abs((actual - expected) / ((num <= num2) ? num2 : num));
			return num3 <= error;
		}

		// Token: 0x04000BA9 RID: 2985
		internal const float k_Epsilon = 1E-05f;

		// Token: 0x04000BAA RID: 2986
		private readonly float m_Error;

		// Token: 0x04000BAB RID: 2987
		private readonly bool m_Relative;

		// Token: 0x04000BAC RID: 2988
		public static readonly FloatComparer s_ComparerWithDefaultTolerance = new FloatComparer(1E-05f);
	}
}
