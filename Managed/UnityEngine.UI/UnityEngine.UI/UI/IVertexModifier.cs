using System;
using System.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x020000A2 RID: 162
	[Obsolete("Use IMeshModifier instead", true)]
	public interface IVertexModifier
	{
		// Token: 0x060005AD RID: 1453
		[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts)  instead", true)]
		void ModifyVertices(List<UIVertex> verts);
	}
}
