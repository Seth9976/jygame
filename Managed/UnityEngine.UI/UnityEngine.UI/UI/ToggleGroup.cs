using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200007D RID: 125
	[DisallowMultipleComponent]
	[AddComponentMenu("UI/Toggle Group", 32)]
	public class ToggleGroup : UIBehaviour
	{
		// Token: 0x06000489 RID: 1161 RVA: 0x00015300 File Offset: 0x00013500
		protected ToggleGroup()
		{
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x00015314 File Offset: 0x00013514
		// (set) Token: 0x0600048B RID: 1163 RVA: 0x0001531C File Offset: 0x0001351C
		public bool allowSwitchOff
		{
			get
			{
				return this.m_AllowSwitchOff;
			}
			set
			{
				this.m_AllowSwitchOff = value;
			}
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00015328 File Offset: 0x00013528
		private void ValidateToggleIsInGroup(Toggle toggle)
		{
			if (toggle == null || !this.m_Toggles.Contains(toggle))
			{
				throw new ArgumentException(string.Format("Toggle {0} is not part of ToggleGroup {1}", new object[] { toggle, this }));
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00015368 File Offset: 0x00013568
		public void NotifyToggleOn(Toggle toggle)
		{
			this.ValidateToggleIsInGroup(toggle);
			for (int i = 0; i < this.m_Toggles.Count; i++)
			{
				if (!(this.m_Toggles[i] == toggle))
				{
					this.m_Toggles[i].isOn = false;
				}
			}
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x000153C8 File Offset: 0x000135C8
		public void UnregisterToggle(Toggle toggle)
		{
			if (this.m_Toggles.Contains(toggle))
			{
				this.m_Toggles.Remove(toggle);
			}
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x000153E8 File Offset: 0x000135E8
		public void RegisterToggle(Toggle toggle)
		{
			if (!this.m_Toggles.Contains(toggle))
			{
				this.m_Toggles.Add(toggle);
			}
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00015408 File Offset: 0x00013608
		public bool AnyTogglesOn()
		{
			return this.m_Toggles.Find((Toggle x) => x.isOn) != null;
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00015444 File Offset: 0x00013644
		public IEnumerable<Toggle> ActiveToggles()
		{
			return this.m_Toggles.Where((Toggle x) => x.isOn);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x0001547C File Offset: 0x0001367C
		public void SetAllTogglesOff()
		{
			bool allowSwitchOff = this.m_AllowSwitchOff;
			this.m_AllowSwitchOff = true;
			for (int i = 0; i < this.m_Toggles.Count; i++)
			{
				this.m_Toggles[i].isOn = false;
			}
			this.m_AllowSwitchOff = allowSwitchOff;
		}

		// Token: 0x04000233 RID: 563
		[SerializeField]
		private bool m_AllowSwitchOff;

		// Token: 0x04000234 RID: 564
		private List<Toggle> m_Toggles = new List<Toggle>();
	}
}
