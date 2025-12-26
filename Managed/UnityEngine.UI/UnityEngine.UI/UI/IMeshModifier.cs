using System;

namespace UnityEngine.UI
{
	// Token: 0x020000A3 RID: 163
	public interface IMeshModifier
	{
		// Token: 0x060005AE RID: 1454
		[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts) instead", false)]
		void ModifyMesh(Mesh mesh);

		// Token: 0x060005AF RID: 1455
		void ModifyMesh(VertexHelper verts);
	}
}
