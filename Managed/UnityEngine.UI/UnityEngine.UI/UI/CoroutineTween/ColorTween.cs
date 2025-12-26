using System;
using UnityEngine.Events;

namespace UnityEngine.UI.CoroutineTween
{
	// Token: 0x02000030 RID: 48
	internal struct ColorTween : ITweenValue
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000136 RID: 310 RVA: 0x000054C4 File Offset: 0x000036C4
		// (set) Token: 0x06000137 RID: 311 RVA: 0x000054CC File Offset: 0x000036CC
		public Color startColor
		{
			get
			{
				return this.m_StartColor;
			}
			set
			{
				this.m_StartColor = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000138 RID: 312 RVA: 0x000054D8 File Offset: 0x000036D8
		// (set) Token: 0x06000139 RID: 313 RVA: 0x000054E0 File Offset: 0x000036E0
		public Color targetColor
		{
			get
			{
				return this.m_TargetColor;
			}
			set
			{
				this.m_TargetColor = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600013A RID: 314 RVA: 0x000054EC File Offset: 0x000036EC
		// (set) Token: 0x0600013B RID: 315 RVA: 0x000054F4 File Offset: 0x000036F4
		public ColorTween.ColorTweenMode tweenMode
		{
			get
			{
				return this.m_TweenMode;
			}
			set
			{
				this.m_TweenMode = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00005500 File Offset: 0x00003700
		// (set) Token: 0x0600013D RID: 317 RVA: 0x00005508 File Offset: 0x00003708
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

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00005514 File Offset: 0x00003714
		// (set) Token: 0x0600013F RID: 319 RVA: 0x0000551C File Offset: 0x0000371C
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

		// Token: 0x06000140 RID: 320 RVA: 0x00005528 File Offset: 0x00003728
		public void TweenValue(float floatPercentage)
		{
			if (!this.ValidTarget())
			{
				return;
			}
			Color color = Color.Lerp(this.m_StartColor, this.m_TargetColor, floatPercentage);
			if (this.m_TweenMode == ColorTween.ColorTweenMode.Alpha)
			{
				color.r = this.m_StartColor.r;
				color.g = this.m_StartColor.g;
				color.b = this.m_StartColor.b;
			}
			else if (this.m_TweenMode == ColorTween.ColorTweenMode.RGB)
			{
				color.a = this.m_StartColor.a;
			}
			this.m_Target.Invoke(color);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x000055C8 File Offset: 0x000037C8
		public void AddOnChangedCallback(UnityAction<Color> callback)
		{
			if (this.m_Target == null)
			{
				this.m_Target = new ColorTween.ColorTweenCallback();
			}
			this.m_Target.AddListener(callback);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000055F8 File Offset: 0x000037F8
		public bool GetIgnoreTimescale()
		{
			return this.m_IgnoreTimeScale;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00005600 File Offset: 0x00003800
		public float GetDuration()
		{
			return this.m_Duration;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00005608 File Offset: 0x00003808
		public bool ValidTarget()
		{
			return this.m_Target != null;
		}

		// Token: 0x04000090 RID: 144
		private ColorTween.ColorTweenCallback m_Target;

		// Token: 0x04000091 RID: 145
		private Color m_StartColor;

		// Token: 0x04000092 RID: 146
		private Color m_TargetColor;

		// Token: 0x04000093 RID: 147
		private ColorTween.ColorTweenMode m_TweenMode;

		// Token: 0x04000094 RID: 148
		private float m_Duration;

		// Token: 0x04000095 RID: 149
		private bool m_IgnoreTimeScale;

		// Token: 0x02000031 RID: 49
		public enum ColorTweenMode
		{
			// Token: 0x04000097 RID: 151
			All,
			// Token: 0x04000098 RID: 152
			RGB,
			// Token: 0x04000099 RID: 153
			Alpha
		}

		// Token: 0x02000032 RID: 50
		public class ColorTweenCallback : UnityEvent<Color>
		{
		}
	}
}
