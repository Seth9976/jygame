using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000085 RID: 133
	[AddComponentMenu("Layout/Canvas Scaler", 101)]
	[RequireComponent(typeof(Canvas))]
	[ExecuteInEditMode]
	public class CanvasScaler : UIBehaviour
	{
		// Token: 0x060004B2 RID: 1202 RVA: 0x00015B28 File Offset: 0x00013D28
		protected CanvasScaler()
		{
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x00015BA4 File Offset: 0x00013DA4
		// (set) Token: 0x060004B4 RID: 1204 RVA: 0x00015BAC File Offset: 0x00013DAC
		public CanvasScaler.ScaleMode uiScaleMode
		{
			get
			{
				return this.m_UiScaleMode;
			}
			set
			{
				this.m_UiScaleMode = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x00015BB8 File Offset: 0x00013DB8
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x00015BC0 File Offset: 0x00013DC0
		public float referencePixelsPerUnit
		{
			get
			{
				return this.m_ReferencePixelsPerUnit;
			}
			set
			{
				this.m_ReferencePixelsPerUnit = value;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00015BCC File Offset: 0x00013DCC
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x00015BD4 File Offset: 0x00013DD4
		public float scaleFactor
		{
			get
			{
				return this.m_ScaleFactor;
			}
			set
			{
				this.m_ScaleFactor = value;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00015BE0 File Offset: 0x00013DE0
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x00015BE8 File Offset: 0x00013DE8
		public Vector2 referenceResolution
		{
			get
			{
				return this.m_ReferenceResolution;
			}
			set
			{
				this.m_ReferenceResolution = value;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x00015BF4 File Offset: 0x00013DF4
		// (set) Token: 0x060004BC RID: 1212 RVA: 0x00015BFC File Offset: 0x00013DFC
		public CanvasScaler.ScreenMatchMode screenMatchMode
		{
			get
			{
				return this.m_ScreenMatchMode;
			}
			set
			{
				this.m_ScreenMatchMode = value;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x00015C08 File Offset: 0x00013E08
		// (set) Token: 0x060004BE RID: 1214 RVA: 0x00015C10 File Offset: 0x00013E10
		public float matchWidthOrHeight
		{
			get
			{
				return this.m_MatchWidthOrHeight;
			}
			set
			{
				this.m_MatchWidthOrHeight = value;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x00015C1C File Offset: 0x00013E1C
		// (set) Token: 0x060004C0 RID: 1216 RVA: 0x00015C24 File Offset: 0x00013E24
		public CanvasScaler.Unit physicalUnit
		{
			get
			{
				return this.m_PhysicalUnit;
			}
			set
			{
				this.m_PhysicalUnit = value;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x00015C30 File Offset: 0x00013E30
		// (set) Token: 0x060004C2 RID: 1218 RVA: 0x00015C38 File Offset: 0x00013E38
		public float fallbackScreenDPI
		{
			get
			{
				return this.m_FallbackScreenDPI;
			}
			set
			{
				this.m_FallbackScreenDPI = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x00015C44 File Offset: 0x00013E44
		// (set) Token: 0x060004C4 RID: 1220 RVA: 0x00015C4C File Offset: 0x00013E4C
		public float defaultSpriteDPI
		{
			get
			{
				return this.m_DefaultSpriteDPI;
			}
			set
			{
				this.m_DefaultSpriteDPI = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x00015C58 File Offset: 0x00013E58
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x00015C60 File Offset: 0x00013E60
		public float dynamicPixelsPerUnit
		{
			get
			{
				return this.m_DynamicPixelsPerUnit;
			}
			set
			{
				this.m_DynamicPixelsPerUnit = value;
			}
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00015C6C File Offset: 0x00013E6C
		protected override void OnEnable()
		{
			base.OnEnable();
			this.m_Canvas = base.GetComponent<Canvas>();
			this.Handle();
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00015C88 File Offset: 0x00013E88
		protected override void OnDisable()
		{
			this.SetScaleFactor(1f);
			this.SetReferencePixelsPerUnit(100f);
			base.OnDisable();
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00015CA8 File Offset: 0x00013EA8
		protected virtual void Update()
		{
			this.Handle();
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00015CB0 File Offset: 0x00013EB0
		protected virtual void Handle()
		{
			if (this.m_Canvas == null || !this.m_Canvas.isRootCanvas)
			{
				return;
			}
			if (this.m_Canvas.renderMode == RenderMode.WorldSpace)
			{
				this.HandleWorldCanvas();
				return;
			}
			switch (this.m_UiScaleMode)
			{
			case CanvasScaler.ScaleMode.ConstantPixelSize:
				this.HandleConstantPixelSize();
				break;
			case CanvasScaler.ScaleMode.ScaleWithScreenSize:
				this.HandleScaleWithScreenSize();
				break;
			case CanvasScaler.ScaleMode.ConstantPhysicalSize:
				this.HandleConstantPhysicalSize();
				break;
			}
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00015D38 File Offset: 0x00013F38
		protected virtual void HandleWorldCanvas()
		{
			this.SetScaleFactor(this.m_DynamicPixelsPerUnit);
			this.SetReferencePixelsPerUnit(this.m_ReferencePixelsPerUnit);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00015D54 File Offset: 0x00013F54
		protected virtual void HandleConstantPixelSize()
		{
			this.SetScaleFactor(this.m_ScaleFactor);
			this.SetReferencePixelsPerUnit(this.m_ReferencePixelsPerUnit);
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00015D70 File Offset: 0x00013F70
		protected virtual void HandleScaleWithScreenSize()
		{
			Vector2 vector = new Vector2((float)Screen.width, (float)Screen.height);
			float num = 0f;
			switch (this.m_ScreenMatchMode)
			{
			case CanvasScaler.ScreenMatchMode.MatchWidthOrHeight:
			{
				float num2 = Mathf.Log(vector.x / this.m_ReferenceResolution.x, 2f);
				float num3 = Mathf.Log(vector.y / this.m_ReferenceResolution.y, 2f);
				float num4 = Mathf.Lerp(num2, num3, this.m_MatchWidthOrHeight);
				num = Mathf.Pow(2f, num4);
				break;
			}
			case CanvasScaler.ScreenMatchMode.Expand:
				num = Mathf.Min(vector.x / this.m_ReferenceResolution.x, vector.y / this.m_ReferenceResolution.y);
				break;
			case CanvasScaler.ScreenMatchMode.Shrink:
				num = Mathf.Max(vector.x / this.m_ReferenceResolution.x, vector.y / this.m_ReferenceResolution.y);
				break;
			}
			this.SetScaleFactor(num);
			this.SetReferencePixelsPerUnit(this.m_ReferencePixelsPerUnit);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00015E88 File Offset: 0x00014088
		protected virtual void HandleConstantPhysicalSize()
		{
			float dpi = Screen.dpi;
			float num = ((dpi != 0f) ? dpi : this.m_FallbackScreenDPI);
			float num2 = 1f;
			switch (this.m_PhysicalUnit)
			{
			case CanvasScaler.Unit.Centimeters:
				num2 = 2.54f;
				break;
			case CanvasScaler.Unit.Millimeters:
				num2 = 25.4f;
				break;
			case CanvasScaler.Unit.Inches:
				num2 = 1f;
				break;
			case CanvasScaler.Unit.Points:
				num2 = 72f;
				break;
			case CanvasScaler.Unit.Picas:
				num2 = 6f;
				break;
			}
			this.SetScaleFactor(num / num2);
			this.SetReferencePixelsPerUnit(this.m_ReferencePixelsPerUnit * num2 / this.m_DefaultSpriteDPI);
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00015F34 File Offset: 0x00014134
		protected void SetScaleFactor(float scaleFactor)
		{
			if (scaleFactor == this.m_PrevScaleFactor)
			{
				return;
			}
			this.m_Canvas.scaleFactor = scaleFactor;
			this.m_PrevScaleFactor = scaleFactor;
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00015F64 File Offset: 0x00014164
		protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit)
		{
			if (referencePixelsPerUnit == this.m_PrevReferencePixelsPerUnit)
			{
				return;
			}
			this.m_Canvas.referencePixelsPerUnit = referencePixelsPerUnit;
			this.m_PrevReferencePixelsPerUnit = referencePixelsPerUnit;
		}

		// Token: 0x04000245 RID: 581
		private const float kLogBase = 2f;

		// Token: 0x04000246 RID: 582
		[Tooltip("Determines how UI elements in the Canvas are scaled.")]
		[SerializeField]
		private CanvasScaler.ScaleMode m_UiScaleMode;

		// Token: 0x04000247 RID: 583
		[SerializeField]
		[Tooltip("If a sprite has this 'Pixels Per Unit' setting, then one pixel in the sprite will cover one unit in the UI.")]
		protected float m_ReferencePixelsPerUnit = 100f;

		// Token: 0x04000248 RID: 584
		[Tooltip("Scales all UI elements in the Canvas by this factor.")]
		[SerializeField]
		protected float m_ScaleFactor = 1f;

		// Token: 0x04000249 RID: 585
		[SerializeField]
		[Tooltip("The resolution the UI layout is designed for. If the screen resolution is larger, the UI will be scaled up, and if it's smaller, the UI will be scaled down. This is done in accordance with the Screen Match Mode.")]
		protected Vector2 m_ReferenceResolution = new Vector2(800f, 600f);

		// Token: 0x0400024A RID: 586
		[Tooltip("A mode used to scale the canvas area if the aspect ratio of the current resolution doesn't fit the reference resolution.")]
		[SerializeField]
		protected CanvasScaler.ScreenMatchMode m_ScreenMatchMode;

		// Token: 0x0400024B RID: 587
		[Range(0f, 1f)]
		[Tooltip("Determines if the scaling is using the width or height as reference, or a mix in between.")]
		[SerializeField]
		protected float m_MatchWidthOrHeight;

		// Token: 0x0400024C RID: 588
		[SerializeField]
		[Tooltip("The physical unit to specify positions and sizes in.")]
		protected CanvasScaler.Unit m_PhysicalUnit = CanvasScaler.Unit.Points;

		// Token: 0x0400024D RID: 589
		[Tooltip("The DPI to assume if the screen DPI is not known.")]
		[SerializeField]
		protected float m_FallbackScreenDPI = 96f;

		// Token: 0x0400024E RID: 590
		[Tooltip("The pixels per inch to use for sprites that have a 'Pixels Per Unit' setting that matches the 'Reference Pixels Per Unit' setting.")]
		[SerializeField]
		protected float m_DefaultSpriteDPI = 96f;

		// Token: 0x0400024F RID: 591
		[SerializeField]
		[Tooltip("The amount of pixels per unit to use for dynamically created bitmaps in the UI, such as Text.")]
		protected float m_DynamicPixelsPerUnit = 1f;

		// Token: 0x04000250 RID: 592
		private Canvas m_Canvas;

		// Token: 0x04000251 RID: 593
		[NonSerialized]
		private float m_PrevScaleFactor = 1f;

		// Token: 0x04000252 RID: 594
		[NonSerialized]
		private float m_PrevReferencePixelsPerUnit = 100f;

		// Token: 0x02000086 RID: 134
		public enum ScaleMode
		{
			// Token: 0x04000254 RID: 596
			ConstantPixelSize,
			// Token: 0x04000255 RID: 597
			ScaleWithScreenSize,
			// Token: 0x04000256 RID: 598
			ConstantPhysicalSize
		}

		// Token: 0x02000087 RID: 135
		public enum ScreenMatchMode
		{
			// Token: 0x04000258 RID: 600
			MatchWidthOrHeight,
			// Token: 0x04000259 RID: 601
			Expand,
			// Token: 0x0400025A RID: 602
			Shrink
		}

		// Token: 0x02000088 RID: 136
		public enum Unit
		{
			// Token: 0x0400025C RID: 604
			Centimeters,
			// Token: 0x0400025D RID: 605
			Millimeters,
			// Token: 0x0400025E RID: 606
			Inches,
			// Token: 0x0400025F RID: 607
			Points,
			// Token: 0x04000260 RID: 608
			Picas
		}
	}
}
