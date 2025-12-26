using System;
using System.Collections.Generic;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200002E RID: 46
	[AddComponentMenu("Event/Physics Raycaster")]
	[RequireComponent(typeof(Camera))]
	public class PhysicsRaycaster : BaseRaycaster
	{
		// Token: 0x0600012A RID: 298 RVA: 0x00005290 File Offset: 0x00003490
		protected PhysicsRaycaster()
		{
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600012B RID: 299 RVA: 0x000052A4 File Offset: 0x000034A4
		public override Camera eventCamera
		{
			get
			{
				if (this.m_EventCamera == null)
				{
					this.m_EventCamera = base.GetComponent<Camera>();
				}
				return this.m_EventCamera ?? Camera.main;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600012C RID: 300 RVA: 0x000052D8 File Offset: 0x000034D8
		public virtual int depth
		{
			get
			{
				return (!(this.eventCamera != null)) ? 16777215 : ((int)this.eventCamera.depth);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0000530C File Offset: 0x0000350C
		public int finalEventMask
		{
			get
			{
				return (!(this.eventCamera != null)) ? (-1) : (this.eventCamera.cullingMask & this.m_EventMask);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00005348 File Offset: 0x00003548
		// (set) Token: 0x0600012F RID: 303 RVA: 0x00005350 File Offset: 0x00003550
		public LayerMask eventMask
		{
			get
			{
				return this.m_EventMask;
			}
			set
			{
				this.m_EventMask = value;
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000535C File Offset: 0x0000355C
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
			if (this.eventCamera == null)
			{
				return;
			}
			Ray ray = this.eventCamera.ScreenPointToRay(eventData.position);
			float num = this.eventCamera.farClipPlane - this.eventCamera.nearClipPlane;
			RaycastHit[] array = Physics.RaycastAll(ray, num, this.finalEventMask);
			if (array.Length > 1)
			{
				Array.Sort<RaycastHit>(array, (RaycastHit r1, RaycastHit r2) => r1.distance.CompareTo(r2.distance));
			}
			if (array.Length != 0)
			{
				int i = 0;
				int num2 = array.Length;
				while (i < num2)
				{
					RaycastResult raycastResult = new RaycastResult
					{
						gameObject = array[i].collider.gameObject,
						module = this,
						distance = array[i].distance,
						worldPosition = array[i].point,
						worldNormal = array[i].normal,
						screenPosition = eventData.position,
						index = (float)resultAppendList.Count,
						sortingLayer = 0,
						sortingOrder = 0
					};
					resultAppendList.Add(raycastResult);
					i++;
				}
			}
		}

		// Token: 0x0400008C RID: 140
		protected const int kNoEventMaskSet = -1;

		// Token: 0x0400008D RID: 141
		protected Camera m_EventCamera;

		// Token: 0x0400008E RID: 142
		[SerializeField]
		protected LayerMask m_EventMask = -1;
	}
}
