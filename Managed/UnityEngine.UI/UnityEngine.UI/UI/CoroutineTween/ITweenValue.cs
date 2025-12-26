using System;

namespace UnityEngine.UI.CoroutineTween
{
	// Token: 0x0200002F RID: 47
	internal interface ITweenValue
	{
		// Token: 0x06000132 RID: 306
		void TweenValue(float floatPercentage);

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000133 RID: 307
		bool ignoreTimeScale { get; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000134 RID: 308
		float duration { get; }

		// Token: 0x06000135 RID: 309
		bool ValidTarget();
	}
}
