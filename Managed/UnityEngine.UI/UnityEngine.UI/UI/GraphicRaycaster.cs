using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x02000047 RID: 71
	[RequireComponent(typeof(Canvas))]
	[AddComponentMenu("Event/Graphic Raycaster")]
	public class GraphicRaycaster : BaseRaycaster
	{
		// Token: 0x06000234 RID: 564 RVA: 0x0000904C File Offset: 0x0000724C
		protected GraphicRaycaster()
		{
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000236 RID: 566 RVA: 0x0000908C File Offset: 0x0000728C
		public override int sortOrderPriority
		{
			get
			{
				if (this.canvas.renderMode == RenderMode.ScreenSpaceOverlay)
				{
					return this.canvas.sortingOrder;
				}
				return base.sortOrderPriority;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000237 RID: 567 RVA: 0x000090BC File Offset: 0x000072BC
		public override int renderOrderPriority
		{
			get
			{
				if (this.canvas.renderMode == RenderMode.ScreenSpaceOverlay)
				{
					return this.canvas.renderOrder;
				}
				return base.renderOrderPriority;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000238 RID: 568 RVA: 0x000090EC File Offset: 0x000072EC
		// (set) Token: 0x06000239 RID: 569 RVA: 0x000090F4 File Offset: 0x000072F4
		public bool ignoreReversedGraphics
		{
			get
			{
				return this.m_IgnoreReversedGraphics;
			}
			set
			{
				this.m_IgnoreReversedGraphics = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00009100 File Offset: 0x00007300
		// (set) Token: 0x0600023B RID: 571 RVA: 0x00009108 File Offset: 0x00007308
		public GraphicRaycaster.BlockingObjects blockingObjects
		{
			get
			{
				return this.m_BlockingObjects;
			}
			set
			{
				this.m_BlockingObjects = value;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600023C RID: 572 RVA: 0x00009114 File Offset: 0x00007314
		private Canvas canvas
		{
			get
			{
				if (this.m_Canvas != null)
				{
					return this.m_Canvas;
				}
				this.m_Canvas = base.GetComponent<Canvas>();
				return this.m_Canvas;
			}
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000914C File Offset: 0x0000734C
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
			if (this.canvas == null)
			{
				return;
			}
			Vector2 vector;
			if (this.eventCamera == null)
			{
				vector = new Vector2(eventData.position.x / (float)Screen.width, eventData.position.y / (float)Screen.height);
			}
			else
			{
				vector = this.eventCamera.ScreenToViewportPoint(eventData.position);
			}
			if (vector.x < 0f || vector.x > 1f || vector.y < 0f || vector.y > 1f)
			{
				return;
			}
			float num = float.MaxValue;
			Ray ray = default(Ray);
			if (this.eventCamera != null)
			{
				ray = this.eventCamera.ScreenPointToRay(eventData.position);
			}
			if (this.canvas.renderMode != RenderMode.ScreenSpaceOverlay && this.blockingObjects != GraphicRaycaster.BlockingObjects.None)
			{
				float num2 = 100f;
				if (this.eventCamera != null)
				{
					num2 = this.eventCamera.farClipPlane - this.eventCamera.nearClipPlane;
				}
				RaycastHit raycastHit;
				if ((this.blockingObjects == GraphicRaycaster.BlockingObjects.ThreeD || this.blockingObjects == GraphicRaycaster.BlockingObjects.All) && Physics.Raycast(ray, out raycastHit, num2, this.m_BlockingMask))
				{
					num = raycastHit.distance;
				}
				if (this.blockingObjects == GraphicRaycaster.BlockingObjects.TwoD || this.blockingObjects == GraphicRaycaster.BlockingObjects.All)
				{
					RaycastHit2D raycastHit2D = Physics2D.Raycast(ray.origin, ray.direction, num2, this.m_BlockingMask);
					if (raycastHit2D.collider != null)
					{
						num = raycastHit2D.fraction * num2;
					}
				}
			}
			this.m_RaycastResults.Clear();
			GraphicRaycaster.Raycast(this.canvas, this.eventCamera, eventData.position, this.m_RaycastResults);
			for (int i = 0; i < this.m_RaycastResults.Count; i++)
			{
				GameObject gameObject = this.m_RaycastResults[i].gameObject;
				bool flag = true;
				if (this.ignoreReversedGraphics)
				{
					if (this.eventCamera == null)
					{
						Vector3 vector2 = gameObject.transform.rotation * Vector3.forward;
						flag = Vector3.Dot(Vector3.forward, vector2) > 0f;
					}
					else
					{
						Vector3 vector3 = this.eventCamera.transform.rotation * Vector3.forward;
						Vector3 vector4 = gameObject.transform.rotation * Vector3.forward;
						flag = Vector3.Dot(vector3, vector4) > 0f;
					}
				}
				if (flag)
				{
					float num3;
					if (this.eventCamera == null || this.canvas.renderMode == RenderMode.ScreenSpaceOverlay)
					{
						num3 = 0f;
					}
					else
					{
						Transform transform = gameObject.transform;
						Vector3 forward = transform.forward;
						num3 = Vector3.Dot(forward, transform.position - ray.origin) / Vector3.Dot(forward, ray.direction);
						if (num3 < 0f)
						{
							goto IL_03CF;
						}
					}
					if (num3 < num)
					{
						RaycastResult raycastResult = new RaycastResult
						{
							gameObject = gameObject,
							module = this,
							distance = num3,
							screenPosition = eventData.position,
							index = (float)resultAppendList.Count,
							depth = this.m_RaycastResults[i].depth,
							sortingLayer = this.canvas.sortingLayerID,
							sortingOrder = this.canvas.sortingOrder
						};
						resultAppendList.Add(raycastResult);
					}
				}
				IL_03CF:;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600023E RID: 574 RVA: 0x00009540 File Offset: 0x00007740
		public override Camera eventCamera
		{
			get
			{
				if (this.canvas.renderMode == RenderMode.ScreenSpaceOverlay || (this.canvas.renderMode == RenderMode.ScreenSpaceCamera && this.canvas.worldCamera == null))
				{
					return null;
				}
				return (!(this.canvas.worldCamera != null)) ? Camera.main : this.canvas.worldCamera;
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000095B4 File Offset: 0x000077B4
		private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, List<Graphic> results)
		{
			IList<Graphic> graphicsForCanvas = GraphicRegistry.GetGraphicsForCanvas(canvas);
			for (int i = 0; i < graphicsForCanvas.Count; i++)
			{
				Graphic graphic = graphicsForCanvas[i];
				if (graphic.depth != -1 && graphic.raycastTarget)
				{
					if (RectTransformUtility.RectangleContainsScreenPoint(graphic.rectTransform, pointerPosition, eventCamera))
					{
						if (graphic.Raycast(pointerPosition, eventCamera))
						{
							GraphicRaycaster.s_SortedGraphics.Add(graphic);
						}
					}
				}
			}
			GraphicRaycaster.s_SortedGraphics.Sort((Graphic g1, Graphic g2) => g2.depth.CompareTo(g1.depth));
			for (int j = 0; j < GraphicRaycaster.s_SortedGraphics.Count; j++)
			{
				results.Add(GraphicRaycaster.s_SortedGraphics[j]);
			}
			GraphicRaycaster.s_SortedGraphics.Clear();
		}

		// Token: 0x040000FE RID: 254
		protected const int kNoEventMaskSet = -1;

		// Token: 0x040000FF RID: 255
		[SerializeField]
		[FormerlySerializedAs("ignoreReversedGraphics")]
		private bool m_IgnoreReversedGraphics = true;

		// Token: 0x04000100 RID: 256
		[SerializeField]
		[FormerlySerializedAs("blockingObjects")]
		private GraphicRaycaster.BlockingObjects m_BlockingObjects;

		// Token: 0x04000101 RID: 257
		[SerializeField]
		protected LayerMask m_BlockingMask = -1;

		// Token: 0x04000102 RID: 258
		private Canvas m_Canvas;

		// Token: 0x04000103 RID: 259
		[NonSerialized]
		private List<Graphic> m_RaycastResults = new List<Graphic>();

		// Token: 0x04000104 RID: 260
		[NonSerialized]
		private static readonly List<Graphic> s_SortedGraphics = new List<Graphic>();

		// Token: 0x02000048 RID: 72
		public enum BlockingObjects
		{
			// Token: 0x04000107 RID: 263
			None,
			// Token: 0x04000108 RID: 264
			TwoD,
			// Token: 0x04000109 RID: 265
			ThreeD,
			// Token: 0x0400010A RID: 266
			All
		}
	}
}
