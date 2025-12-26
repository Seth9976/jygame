using System;
using UnityEngine.Events;

namespace UnityEngine.UI.CoroutineTween
{
	// Token: 0x02000033 RID: 51
	internal struct FloatTween : ITweenValue
	{
		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00005620 File Offset: 0x00003820
		// (set) Token: 0x06000147 RID: 327 RVA: 0x00005628 File Offset: 0x00003828
		public float startValue
		{
			get
			{
				return this.m_StartValue;
			}
			set
			{
				this.m_StartValue = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00005634 File Offset: 0x00003834
		// (set) Token: 0x06000149 RID: 329 RVA: 0x0000563C File Offset: 0x0000383C
		public float targetValue
		{
			get
			{
				return this.m_TargetValue;
			}
			set
			{
				this.m_TargetValue = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00005648 File Offset: 0x00003848
		// (set) Token: 0x0600014B RID: 331 RVA: 0x00005650 File Offset: 0x00003850
		public float duration
		{
			get
			{
				return this.m_Duration;
			}
			set
			{
				this.m_Duration = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600014C RID: 332 RVA: 0x0000565C File Offset: 0x0000385C
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00005664 File Offset: 0x00003864
		public bool ignoreTimeScale
		{
			get
			{
				return this.m_IgnoreTimeScale;
			}
			set
			{
				this.m_IgnoreTimeScale = value;
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00005670 File Offset: 0x00003870
		public void TweenValue(float floatPercentage)
		{
			if (!this.ValidTarget())
			{
				return;
			}
			float num = Mathf.Lerp(this.m_StartValue, this.m_TargetValue, floatPercentage);
			this.m_Target.Invoke(num);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000056A8 File Offset: 0x000038A8
		public void AddOnChangedCallback(UnityAction<float> callback)
		{
			if (this.m_Target == null)
			{
				this.m_Target = new FloatTween.FloatTweenCallback();
			}
			this.m_Target.AddListener(callback);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000056D8 File Offset: 0x000038D8
		public bool GetIgnoreTimescale()
		{
			return this.m_IgnoreTimeScale;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000056E0 File Offset: 0x000038E0
		public float GetDuration()
		{
			return this.m_Duration;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000056E8 File Offset: 0x000038E8
		public bool ValidTarget()
		{
			return this.m_Target != null;
		}

		// Token: 0x0400009A RID: 154
		private FloatTween.FloatTweenCallback m_Target;

		// Token: 0x0400009B RID: 155
		private float m_StartValue;

		// Token: 0x0400009C RID: 156
		private float m_TargetValue;

		// Token: 0x0400009D RID: 157
		private float m_Duration;

		// Token: 0x0400009E RID: 158
		private bool m_IgnoreTimeScale;

		// Token: 0x02000034 RID: 52
		public class FloatTweenCallback : UnityEvent<float>
		{
		}
	}
}
