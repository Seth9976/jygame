using System;

namespace DG.Tweening.Core
{
	// Token: 0x02000047 RID: 71
	internal class SequenceCallback : ABSSequentiable
	{
		// Token: 0x060001CC RID: 460 RVA: 0x0000C0B5 File Offset: 0x0000A2B5
		public SequenceCallback(float sequencedPosition, TweenCallback callback)
		{
			this.tweenType = TweenType.Callback;
			this.sequencedPosition = sequencedPosition;
			this.onStart = callback;
		}
	}
}
