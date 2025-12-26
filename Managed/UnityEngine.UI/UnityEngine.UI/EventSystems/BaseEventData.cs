using System;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000020 RID: 32
	public class BaseEventData
	{
		// Token: 0x0600008D RID: 141 RVA: 0x0000326C File Offset: 0x0000146C
		public BaseEventData(EventSystem eventSystem)
		{
			this.m_EventSystem = eventSystem;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000327C File Offset: 0x0000147C
		public void Reset()
		{
			this.m_Used = false;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00003288 File Offset: 0x00001488
		public void Use()
		{
			this.m_Used = true;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00003294 File Offset: 0x00001494
		public bool used
		{
			get
			{
				return this.m_Used;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000091 RID: 145 RVA: 0x0000329C File Offset: 0x0000149C
		public BaseInputModule currentInputModule
		{
			get
			{
				return this.m_EventSystem.currentInputModule;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000092 RID: 146 RVA: 0x000032AC File Offset: 0x000014AC
		// (set) Token: 0x06000093 RID: 147 RVA: 0x000032BC File Offset: 0x000014BC
		public GameObject selectedObject
		{
			get
			{
				return this.m_EventSystem.currentSelectedGameObject;
			}
			set
			{
				this.m_EventSystem.SetSelectedGameObject(value, this);
			}
		}

		// Token: 0x0400004B RID: 75
		private readonly EventSystem m_EventSystem;

		// Token: 0x0400004C RID: 76
		private bool m_Used;
	}
}
