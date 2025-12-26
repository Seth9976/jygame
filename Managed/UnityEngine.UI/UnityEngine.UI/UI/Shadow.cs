using System;
using System.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x020000A6 RID: 166
	[AddComponentMenu("UI/Effects/Shadow", 14)]
	public class Shadow : BaseMeshEffect
	{
		// Token: 0x060005B4 RID: 1460 RVA: 0x00018904 File Offset: 0x00016B04
		protected Shadow()
		{
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x00018954 File Offset: 0x00016B54
		// (set) Token: 0x060005B6 RID: 1462 RVA: 0x0001895C File Offset: 0x00016B5C
		public Color effectColor
		{
			get
			{
				return this.m_EffectColor;
			}
			set
			{
				this.m_EffectColor = value;
				if (base.graphic != null)
				{
					base.graphic.SetVerticesDirty();
				}
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x00018984 File Offset: 0x00016B84
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x0001898C File Offset: 0x00016B8C
		public Vector2 effectDistance
		{
			get
			{
				return this.m_EffectDistance;
			}
			set
			{
				if (value.x > 600f)
				{
					value.x = 600f;
				}
				if (value.x < -600f)
				{
					value.x = -600f;
				}
				if (value.y > 600f)
				{
					value.y = 600f;
				}
				if (value.y < -600f)
				{
					value.y = -600f;
				}
				if (this.m_EffectDistance == value)
				{
					return;
				}
				this.m_EffectDistance = value;
				if (base.graphic != null)
				{
					base.graphic.SetVerticesDirty();
				}
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x00018A44 File Offset: 0x00016C44
		// (set) Token: 0x060005BA RID: 1466 RVA: 0x00018A4C File Offset: 0x00016C4C
		public bool useGraphicAlpha
		{
			get
			{
				return this.m_UseGraphicAlpha;
			}
			set
			{
				this.m_UseGraphicAlpha = value;
				if (base.graphic != null)
				{
					base.graphic.SetVerticesDirty();
				}
			}
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00018A74 File Offset: 0x00016C74
		protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y)
		{
			int num = verts.Count * 2;
			if (verts.Capacity < num)
			{
				verts.Capacity = num;
			}
			for (int i = start; i < end; i++)
			{
				UIVertex uivertex = verts[i];
				verts.Add(uivertex);
				Vector3 position = uivertex.position;
				position.x += x;
				position.y += y;
				uivertex.position = position;
				Color32 color2 = color;
				if (this.m_UseGraphicAlpha)
				{
					color2.a = color2.a * verts[i].color.a / byte.MaxValue;
				}
				uivertex.color = color2;
				verts[i] = uivertex;
			}
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00018B3C File Offset: 0x00016D3C
		protected void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, float x, float y)
		{
			int num = verts.Count * 2;
			if (verts.Capacity < num)
			{
				verts.Capacity = num;
			}
			this.ApplyShadowZeroAlloc(verts, color, start, end, x, y);
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00018B74 File Offset: 0x00016D74
		public override void ModifyMesh(VertexHelper vh)
		{
			if (!this.IsActive())
			{
				return;
			}
			List<UIVertex> list = ListPool<UIVertex>.Get();
			vh.GetUIVertexStream(list);
			this.ApplyShadow(list, this.effectColor, 0, list.Count, this.effectDistance.x, this.effectDistance.y);
			vh.Clear();
			vh.AddUIVertexTriangleStream(list);
			ListPool<UIVertex>.Release(list);
		}

		// Token: 0x040002B0 RID: 688
		[SerializeField]
		private Color m_EffectColor = new Color(0f, 0f, 0f, 0.5f);

		// Token: 0x040002B1 RID: 689
		[SerializeField]
		private Vector2 m_EffectDistance = new Vector2(1f, -1f);

		// Token: 0x040002B2 RID: 690
		[SerializeField]
		private bool m_UseGraphicAlpha = true;
	}
}
