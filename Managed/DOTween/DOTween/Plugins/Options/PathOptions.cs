using System;
using UnityEngine;

namespace DG.Tweening.Plugins.Options
{
	// Token: 0x02000031 RID: 49
	public struct PathOptions
	{
		// Token: 0x040000D0 RID: 208
		public PathMode mode;

		// Token: 0x040000D1 RID: 209
		public OrientType orientType;

		// Token: 0x040000D2 RID: 210
		public AxisConstraint lockPositionAxis;

		// Token: 0x040000D3 RID: 211
		public AxisConstraint lockRotationAxis;

		// Token: 0x040000D4 RID: 212
		public bool isClosedPath;

		// Token: 0x040000D5 RID: 213
		public Vector3 lookAtPosition;

		// Token: 0x040000D6 RID: 214
		public Transform lookAtTransform;

		// Token: 0x040000D7 RID: 215
		public float lookAhead;

		// Token: 0x040000D8 RID: 216
		public bool hasCustomForwardDirection;

		// Token: 0x040000D9 RID: 217
		public Quaternion forward;

		// Token: 0x040000DA RID: 218
		public bool useLocalPosition;

		// Token: 0x040000DB RID: 219
		public Transform parent;

		// Token: 0x040000DC RID: 220
		internal float startupZRot;
	}
}
