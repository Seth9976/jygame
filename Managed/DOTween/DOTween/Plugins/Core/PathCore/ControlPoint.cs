using System;
using UnityEngine;

namespace DG.Tweening.Plugins.Core.PathCore
{
	// Token: 0x02000006 RID: 6
	internal struct ControlPoint
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002515 File Offset: 0x00000715
		public ControlPoint(Vector3 a, Vector3 b)
		{
			this.a = a;
			this.b = b;
		}

		// Token: 0x04000006 RID: 6
		internal Vector3 a;

		// Token: 0x04000007 RID: 7
		internal Vector3 b;
	}
}
