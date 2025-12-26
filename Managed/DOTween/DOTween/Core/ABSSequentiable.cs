using System;

namespace DG.Tweening.Core
{
	// Token: 0x0200000E RID: 14
	public abstract class ABSSequentiable
	{
		// Token: 0x04000030 RID: 48
		internal TweenType tweenType;

		// Token: 0x04000031 RID: 49
		internal float sequencedPosition;

		// Token: 0x04000032 RID: 50
		internal float sequencedEndPosition;

		// Token: 0x04000033 RID: 51
		internal TweenCallback onStart;
	}
}
