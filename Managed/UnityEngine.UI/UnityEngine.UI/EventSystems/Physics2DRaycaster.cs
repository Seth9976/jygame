using System;
using System.Collections.Generic;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200002D RID: 45
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Event/Physics 2D Raycaster")]
	public class Physics2DRaycaster : PhysicsRaycaster
	{
		// Token: 0x06000128 RID: 296 RVA: 0x000050E8 File Offset: 0x000032E8
		protected Physics2DRaycaster()
		{
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000050F0 File Offset: 0x000032F0
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
			if (this.eventCamera == null)
			{
				return;
			}
			Ray ray = this.eventCamera.ScreenPointToRay(eventData.position);
			float num = this.eventCamera.farClipPlane - this.eventCamera.nearClipPlane;
			RaycastHit2D[] array = Physics2D.RaycastAll(ray.origin, ray.direction, num, base.finalEventMask);
			if (array.Length != 0)
			{
				int i = 0;
				int num2 = array.Length;
				while (i < num2)
				{
					SpriteRenderer component = array[i].collider.gameObject.GetComponent<SpriteRenderer>();
					RaycastResult raycastResult = new RaycastResult
					{
						gameObject = array[i].collider.gameObject,
						module = this,
						distance = Vector3.Distance(this.eventCamera.transform.position, array[i].transform.position),
						worldPosition = array[i].point,
						worldNormal = array[i].normal,
						screenPosition = eventData.position,
						index = (float)resultAppendList.Count,
						sortingLayer = ((!(component != null)) ? 0 : component.sortingLayerID),
						sortingOrder = ((!(component != null)) ? 0 : component.sortingOrder)
					};
					resultAppendList.Add(raycastResult);
					i++;
				}
			}
		}
	}
}
