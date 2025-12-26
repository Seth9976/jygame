using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Class internally used to pass layout options into GUILayout functions. You don't use these directly, but construct them with the layouting functions in the GUILayout class.</para>
	/// </summary>
	// Token: 0x020001DD RID: 477
	public sealed class GUILayoutOption
	{
		// Token: 0x06001BFF RID: 7167 RVA: 0x0000ABB0 File Offset: 0x00008DB0
		internal GUILayoutOption(GUILayoutOption.Type type, object value)
		{
			this.type = type;
			this.value = value;
		}

		// Token: 0x04000743 RID: 1859
		internal GUILayoutOption.Type type;

		// Token: 0x04000744 RID: 1860
		internal object value;

		// Token: 0x020001DE RID: 478
		internal enum Type
		{
			// Token: 0x04000746 RID: 1862
			fixedWidth,
			// Token: 0x04000747 RID: 1863
			fixedHeight,
			// Token: 0x04000748 RID: 1864
			minWidth,
			// Token: 0x04000749 RID: 1865
			maxWidth,
			// Token: 0x0400074A RID: 1866
			minHeight,
			// Token: 0x0400074B RID: 1867
			maxHeight,
			// Token: 0x0400074C RID: 1868
			stretchWidth,
			// Token: 0x0400074D RID: 1869
			stretchHeight,
			// Token: 0x0400074E RID: 1870
			alignStart,
			// Token: 0x0400074F RID: 1871
			alignMiddle,
			// Token: 0x04000750 RID: 1872
			alignEnd,
			// Token: 0x04000751 RID: 1873
			alignJustify,
			// Token: 0x04000752 RID: 1874
			equalSize,
			// Token: 0x04000753 RID: 1875
			spacing
		}
	}
}
