using System;

namespace UnityEngine.UI
{
	// Token: 0x02000082 RID: 130
	internal class RectangularVertexClipper
	{
		// Token: 0x060004A2 RID: 1186 RVA: 0x00015768 File Offset: 0x00013968
		public Rect GetCanvasRect(RectTransform t, Canvas c)
		{
			t.GetWorldCorners(this.m_WorldCorners);
			Transform component = c.GetComponent<Transform>();
			for (int i = 0; i < 4; i++)
			{
				this.m_CanvasCorners[i] = component.InverseTransformPoint(this.m_WorldCorners[i]);
			}
			return new Rect(this.m_CanvasCorners[0].x, this.m_CanvasCorners[0].y, this.m_CanvasCorners[2].x - this.m_CanvasCorners[0].x, this.m_CanvasCorners[2].y - this.m_CanvasCorners[0].y);
		}

		// Token: 0x04000239 RID: 569
		private readonly Vector3[] m_WorldCorners = new Vector3[4];

		// Token: 0x0400023A RID: 570
		private readonly Vector3[] m_CanvasCorners = new Vector3[4];
	}
}
