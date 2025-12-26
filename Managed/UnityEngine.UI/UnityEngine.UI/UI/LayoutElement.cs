using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000096 RID: 150
	[RequireComponent(typeof(RectTransform))]
	[ExecuteInEditMode]
	[AddComponentMenu("Layout/Layout Element", 140)]
	public class LayoutElement : UIBehaviour, ILayoutElement, ILayoutIgnorer
	{
		// Token: 0x0600050A RID: 1290 RVA: 0x00016CE8 File Offset: 0x00014EE8
		protected LayoutElement()
		{
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x00016D40 File Offset: 0x00014F40
		// (set) Token: 0x0600050C RID: 1292 RVA: 0x00016D48 File Offset: 0x00014F48
		public virtual bool ignoreLayout
		{
			get
			{
				return this.m_IgnoreLayout;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<bool>(ref this.m_IgnoreLayout, value))
				{
					this.SetDirty();
				}
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00016D64 File Offset: 0x00014F64
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00016D68 File Offset: 0x00014F68
		public virtual void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x00016D6C File Offset: 0x00014F6C
		// (set) Token: 0x06000510 RID: 1296 RVA: 0x00016D74 File Offset: 0x00014F74
		public virtual float minWidth
		{
			get
			{
				return this.m_MinWidth;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<float>(ref this.m_MinWidth, value))
				{
					this.SetDirty();
				}
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x00016D90 File Offset: 0x00014F90
		// (set) Token: 0x06000512 RID: 1298 RVA: 0x00016D98 File Offset: 0x00014F98
		public virtual float minHeight
		{
			get
			{
				return this.m_MinHeight;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<float>(ref this.m_MinHeight, value))
				{
					this.SetDirty();
				}
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x00016DB4 File Offset: 0x00014FB4
		// (set) Token: 0x06000514 RID: 1300 RVA: 0x00016DBC File Offset: 0x00014FBC
		public virtual float preferredWidth
		{
			get
			{
				return this.m_PreferredWidth;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<float>(ref this.m_PreferredWidth, value))
				{
					this.SetDirty();
				}
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x00016DD8 File Offset: 0x00014FD8
		// (set) Token: 0x06000516 RID: 1302 RVA: 0x00016DE0 File Offset: 0x00014FE0
		public virtual float preferredHeight
		{
			get
			{
				return this.m_PreferredHeight;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<float>(ref this.m_PreferredHeight, value))
				{
					this.SetDirty();
				}
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x00016DFC File Offset: 0x00014FFC
		// (set) Token: 0x06000518 RID: 1304 RVA: 0x00016E04 File Offset: 0x00015004
		public virtual float flexibleWidth
		{
			get
			{
				return this.m_FlexibleWidth;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<float>(ref this.m_FlexibleWidth, value))
				{
					this.SetDirty();
				}
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x00016E20 File Offset: 0x00015020
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x00016E28 File Offset: 0x00015028
		public virtual float flexibleHeight
		{
			get
			{
				return this.m_FlexibleHeight;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<float>(ref this.m_FlexibleHeight, value))
				{
					this.SetDirty();
				}
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x00016E44 File Offset: 0x00015044
		public virtual int layoutPriority
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00016E48 File Offset: 0x00015048
		protected override void OnEnable()
		{
			base.OnEnable();
			this.SetDirty();
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00016E58 File Offset: 0x00015058
		protected override void OnTransformParentChanged()
		{
			this.SetDirty();
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00016E60 File Offset: 0x00015060
		protected override void OnDisable()
		{
			this.SetDirty();
			base.OnDisable();
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00016E70 File Offset: 0x00015070
		protected override void OnDidApplyAnimationProperties()
		{
			this.SetDirty();
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00016E78 File Offset: 0x00015078
		protected override void OnBeforeTransformParentChanged()
		{
			this.SetDirty();
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00016E80 File Offset: 0x00015080
		protected void SetDirty()
		{
			if (!this.IsActive())
			{
				return;
			}
			LayoutRebuilder.MarkLayoutForRebuild(base.transform as RectTransform);
		}

		// Token: 0x0400027E RID: 638
		[SerializeField]
		private bool m_IgnoreLayout;

		// Token: 0x0400027F RID: 639
		[SerializeField]
		private float m_MinWidth = -1f;

		// Token: 0x04000280 RID: 640
		[SerializeField]
		private float m_MinHeight = -1f;

		// Token: 0x04000281 RID: 641
		[SerializeField]
		private float m_PreferredWidth = -1f;

		// Token: 0x04000282 RID: 642
		[SerializeField]
		private float m_PreferredHeight = -1f;

		// Token: 0x04000283 RID: 643
		[SerializeField]
		private float m_FlexibleWidth = -1f;

		// Token: 0x04000284 RID: 644
		[SerializeField]
		private float m_FlexibleHeight = -1f;
	}
}
