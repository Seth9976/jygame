using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Use this PropertyAttribute to add a header above some fields in the Inspector.</para>
	/// </summary>
	// Token: 0x020002C7 RID: 711
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
	public class HeaderAttribute : PropertyAttribute
	{
		/// <summary>
		///   <para>Add a header above some fields in the Inspector.</para>
		/// </summary>
		/// <param name="header">The header text.</param>
		// Token: 0x060021B7 RID: 8631 RVA: 0x0000D842 File Offset: 0x0000BA42
		public HeaderAttribute(string header)
		{
			this.header = header;
		}

		/// <summary>
		///   <para>The header text.</para>
		/// </summary>
		// Token: 0x04000ADF RID: 2783
		public readonly string header;
	}
}
