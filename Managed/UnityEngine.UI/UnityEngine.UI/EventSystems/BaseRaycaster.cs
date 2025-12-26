using System;
using System.Collections.Generic;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200002C RID: 44
	public abstract class BaseRaycaster : UIBehaviour
	{
		// Token: 0x06000120 RID: 288
		public abstract void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList);

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000121 RID: 289
		public abstract Camera eventCamera { get; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000122 RID: 290 RVA: 0x0000504C File Offset: 0x0000324C
		[Obsolete("Please use sortOrderPriority and renderOrderPriority", false)]
		public virtual int priority
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00005050 File Offset: 0x00003250
		public virtual int sortOrderPriority
		{
			get
			{
				return int.MinValue;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00005058 File Offset: 0x00003258
		public virtual int renderOrderPriority
		{
			get
			{
				return int.MinValue;
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00005060 File Offset: 0x00003260
		public override string ToString()
		{
			return string.Concat(new object[] { "Name: ", base.gameObject, "\neventCamera: ", this.eventCamera, "\nsortOrderPriority: ", this.sortOrderPriority, "\nrenderOrderPriority: ", this.renderOrderPriority });
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000050C8 File Offset: 0x000032C8
		protected override void OnEnable()
		{
			base.OnEnable();
			RaycasterManager.AddRaycaster(this);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000050D8 File Offset: 0x000032D8
		protected override void OnDisable()
		{
			RaycasterManager.RemoveRaycasters(this);
			base.OnDisable();
		}
	}
}
