using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x020000A1 RID: 161
	[ExecuteInEditMode]
	public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier
	{
		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x0001862C File Offset: 0x0001682C
		protected Graphic graphic
		{
			get
			{
				if (this.m_Graphic == null)
				{
					this.m_Graphic = base.GetComponent<Graphic>();
				}
				return this.m_Graphic;
			}
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00018654 File Offset: 0x00016854
		protected override void OnEnable()
		{
			base.OnEnable();
			if (this.graphic != null)
			{
				this.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00018684 File Offset: 0x00016884
		protected override void OnDisable()
		{
			if (this.graphic != null)
			{
				this.graphic.SetVerticesDirty();
			}
			base.OnDisable();
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x000186B4 File Offset: 0x000168B4
		protected override void OnDidApplyAnimationProperties()
		{
			if (this.graphic != null)
			{
				this.graphic.SetVerticesDirty();
			}
			base.OnDidApplyAnimationProperties();
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x000186E4 File Offset: 0x000168E4
		public virtual void ModifyMesh(Mesh mesh)
		{
			using (VertexHelper vertexHelper = new VertexHelper(mesh))
			{
				this.ModifyMesh(vertexHelper);
				vertexHelper.FillMesh(mesh);
			}
		}

		// Token: 0x060005AC RID: 1452
		public abstract void ModifyMesh(VertexHelper vh);

		// Token: 0x040002AF RID: 687
		[NonSerialized]
		private Graphic m_Graphic;
	}
}
