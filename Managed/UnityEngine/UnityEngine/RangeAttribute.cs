using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Attribute used to make a float or int variable in a script be restricted to a specific range.</para>
	/// </summary>
	// Token: 0x020002C8 RID: 712
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public sealed class RangeAttribute : PropertyAttribute
	{
		/// <summary>
		///   <para>Attribute used to make a float or int variable in a script be restricted to a specific range.</para>
		/// </summary>
		/// <param name="min">The minimum allowed value.</param>
		/// <param name="max">The maximum allowed value.</param>
		// Token: 0x060021B8 RID: 8632 RVA: 0x0000D851 File Offset: 0x0000BA51
		public RangeAttribute(float min, float max)
		{
			this.min = min;
			this.max = max;
		}

		// Token: 0x04000AE0 RID: 2784
		public readonly float min;

		// Token: 0x04000AE1 RID: 2785
		public readonly float max;
	}
}
