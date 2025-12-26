using System;
using System.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x020000A0 RID: 160
	[Obsolete("Use BaseMeshEffect instead", true)]
	public abstract class BaseVertexEffect
	{
		// Token: 0x060005A5 RID: 1445
		[Obsolete("Use BaseMeshEffect.ModifyMeshes instead", true)]
		public abstract void ModifyVertices(List<UIVertex> vertices);
	}
}
