using System;
using UnityEngine;

namespace DG.Tweening.Plugins.Core.PathCore
{
	// Token: 0x0200001B RID: 27
	internal abstract class ABSPathDecoder
	{
		// Token: 0x060000E7 RID: 231
		internal abstract void FinalizePath(Path p, Vector3[] wps, bool isClosedPath);

		// Token: 0x060000E8 RID: 232
		internal abstract Vector3 GetPoint(float perc, Vector3[] wps, Path p);
	}
}
