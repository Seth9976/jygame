using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>An enumeration of transform properties that can be driven on a RectTransform by an object.</para>
	/// </summary>
	// Token: 0x02000076 RID: 118
	[Flags]
	public enum DrivenTransformProperties
	{
		/// <summary>
		///   <para>Deselects all driven properties.</para>
		/// </summary>
		// Token: 0x04000156 RID: 342
		None = 0,
		/// <summary>
		///   <para>Selects all driven properties.</para>
		/// </summary>
		// Token: 0x04000157 RID: 343
		All = -1,
		/// <summary>
		///   <para>Selects driven property RectTransform.anchoredPosition.x.</para>
		/// </summary>
		// Token: 0x04000158 RID: 344
		AnchoredPositionX = 2,
		/// <summary>
		///   <para>Selects driven property RectTransform.anchoredPosition.y.</para>
		/// </summary>
		// Token: 0x04000159 RID: 345
		AnchoredPositionY = 4,
		/// <summary>
		///   <para>Selects driven property RectTransform.anchoredPosition3D.z.</para>
		/// </summary>
		// Token: 0x0400015A RID: 346
		AnchoredPositionZ = 8,
		/// <summary>
		///   <para>Selects driven property Transform.localRotation.</para>
		/// </summary>
		// Token: 0x0400015B RID: 347
		Rotation = 16,
		/// <summary>
		///   <para>Selects driven property Transform.localScale.x.</para>
		/// </summary>
		// Token: 0x0400015C RID: 348
		ScaleX = 32,
		/// <summary>
		///   <para>Selects driven property Transform.localScale.y.</para>
		/// </summary>
		// Token: 0x0400015D RID: 349
		ScaleY = 64,
		/// <summary>
		///   <para>Selects driven property Transform.localScale.z.</para>
		/// </summary>
		// Token: 0x0400015E RID: 350
		ScaleZ = 128,
		/// <summary>
		///   <para>Selects driven property RectTransform.anchorMin.x.</para>
		/// </summary>
		// Token: 0x0400015F RID: 351
		AnchorMinX = 256,
		/// <summary>
		///   <para>Selects driven property RectTransform.anchorMin.y.</para>
		/// </summary>
		// Token: 0x04000160 RID: 352
		AnchorMinY = 512,
		/// <summary>
		///   <para>Selects driven property RectTransform.anchorMax.x.</para>
		/// </summary>
		// Token: 0x04000161 RID: 353
		AnchorMaxX = 1024,
		/// <summary>
		///   <para>Selects driven property RectTransform.anchorMax.y.</para>
		/// </summary>
		// Token: 0x04000162 RID: 354
		AnchorMaxY = 2048,
		/// <summary>
		///   <para>Selects driven property RectTransform.sizeDelta.x.</para>
		/// </summary>
		// Token: 0x04000163 RID: 355
		SizeDeltaX = 4096,
		/// <summary>
		///   <para>Selects driven property RectTransform.sizeDelta.y.</para>
		/// </summary>
		// Token: 0x04000164 RID: 356
		SizeDeltaY = 8192,
		/// <summary>
		///   <para>Selects driven property RectTransform.pivot.x.</para>
		/// </summary>
		// Token: 0x04000165 RID: 357
		PivotX = 16384,
		/// <summary>
		///   <para>Selects driven property RectTransform.pivot.y.</para>
		/// </summary>
		// Token: 0x04000166 RID: 358
		PivotY = 32768,
		/// <summary>
		///   <para>Selects driven property RectTransform.anchoredPosition.</para>
		/// </summary>
		// Token: 0x04000167 RID: 359
		AnchoredPosition = 6,
		/// <summary>
		///   <para>Selects driven property RectTransform.anchoredPosition3D.</para>
		/// </summary>
		// Token: 0x04000168 RID: 360
		AnchoredPosition3D = 14,
		/// <summary>
		///   <para>Selects driven property combining ScaleX, ScaleY &amp;&amp; ScaleZ.</para>
		/// </summary>
		// Token: 0x04000169 RID: 361
		Scale = 224,
		/// <summary>
		///   <para>Selects driven property combining AnchorMinX and AnchorMinY.</para>
		/// </summary>
		// Token: 0x0400016A RID: 362
		AnchorMin = 768,
		/// <summary>
		///   <para>Selects driven property combining AnchorMaxX and AnchorMaxY.</para>
		/// </summary>
		// Token: 0x0400016B RID: 363
		AnchorMax = 3072,
		/// <summary>
		///   <para>Selects driven property combining AnchorMinX, AnchorMinY, AnchorMaxX and AnchorMaxY.</para>
		/// </summary>
		// Token: 0x0400016C RID: 364
		Anchors = 3840,
		/// <summary>
		///   <para>Selects driven property combining SizeDeltaX and SizeDeltaY.</para>
		/// </summary>
		// Token: 0x0400016D RID: 365
		SizeDelta = 12288,
		/// <summary>
		///   <para>Selects driven property combining PivotX and PivotY.</para>
		/// </summary>
		// Token: 0x0400016E RID: 366
		Pivot = 49152
	}
}
