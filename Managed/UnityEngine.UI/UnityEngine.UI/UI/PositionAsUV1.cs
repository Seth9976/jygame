using System;

namespace UnityEngine.UI
{
	// Token: 0x020000A5 RID: 165
	[AddComponentMenu("UI/Effects/Position As UV1", 16)]
	public class PositionAsUV1 : BaseMeshEffect
	{
		// Token: 0x060005B2 RID: 1458 RVA: 0x00018898 File Offset: 0x00016A98
		protected PositionAsUV1()
		{
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x000188A0 File Offset: 0x00016AA0
		public override void ModifyMesh(VertexHelper vh)
		{
			UIVertex uivertex = default(UIVertex);
			for (int i = 0; i < vh.currentVertCount; i++)
			{
				vh.PopulateUIVertex(ref uivertex, i);
				uivertex.uv1 = new Vector2(uivertex.position.x, uivertex.position.y);
				vh.SetUIVertex(uivertex, i);
			}
		}
	}
}
