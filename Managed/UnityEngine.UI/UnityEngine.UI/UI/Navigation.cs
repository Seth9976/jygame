using System;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x02000062 RID: 98
	[Serializable]
	public struct Navigation
	{
		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0000FBB0 File Offset: 0x0000DDB0
		// (set) Token: 0x06000327 RID: 807 RVA: 0x0000FBB8 File Offset: 0x0000DDB8
		public Navigation.Mode mode
		{
			get
			{
				return this.m_Mode;
			}
			set
			{
				this.m_Mode = value;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000328 RID: 808 RVA: 0x0000FBC4 File Offset: 0x0000DDC4
		// (set) Token: 0x06000329 RID: 809 RVA: 0x0000FBCC File Offset: 0x0000DDCC
		public Selectable selectOnUp
		{
			get
			{
				return this.m_SelectOnUp;
			}
			set
			{
				this.m_SelectOnUp = value;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600032A RID: 810 RVA: 0x0000FBD8 File Offset: 0x0000DDD8
		// (set) Token: 0x0600032B RID: 811 RVA: 0x0000FBE0 File Offset: 0x0000DDE0
		public Selectable selectOnDown
		{
			get
			{
				return this.m_SelectOnDown;
			}
			set
			{
				this.m_SelectOnDown = value;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0000FBEC File Offset: 0x0000DDEC
		// (set) Token: 0x0600032D RID: 813 RVA: 0x0000FBF4 File Offset: 0x0000DDF4
		public Selectable selectOnLeft
		{
			get
			{
				return this.m_SelectOnLeft;
			}
			set
			{
				this.m_SelectOnLeft = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0000FC00 File Offset: 0x0000DE00
		// (set) Token: 0x0600032F RID: 815 RVA: 0x0000FC08 File Offset: 0x0000DE08
		public Selectable selectOnRight
		{
			get
			{
				return this.m_SelectOnRight;
			}
			set
			{
				this.m_SelectOnRight = value;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000330 RID: 816 RVA: 0x0000FC14 File Offset: 0x0000DE14
		public static Navigation defaultNavigation
		{
			get
			{
				return new Navigation
				{
					m_Mode = Navigation.Mode.Automatic
				};
			}
		}

		// Token: 0x04000193 RID: 403
		[SerializeField]
		[FormerlySerializedAs("mode")]
		private Navigation.Mode m_Mode;

		// Token: 0x04000194 RID: 404
		[SerializeField]
		[FormerlySerializedAs("selectOnUp")]
		private Selectable m_SelectOnUp;

		// Token: 0x04000195 RID: 405
		[FormerlySerializedAs("selectOnDown")]
		[SerializeField]
		private Selectable m_SelectOnDown;

		// Token: 0x04000196 RID: 406
		[SerializeField]
		[FormerlySerializedAs("selectOnLeft")]
		private Selectable m_SelectOnLeft;

		// Token: 0x04000197 RID: 407
		[FormerlySerializedAs("selectOnRight")]
		[SerializeField]
		private Selectable m_SelectOnRight;

		// Token: 0x02000063 RID: 99
		[Flags]
		public enum Mode
		{
			// Token: 0x04000199 RID: 409
			None = 0,
			// Token: 0x0400019A RID: 410
			Horizontal = 1,
			// Token: 0x0400019B RID: 411
			Vertical = 2,
			// Token: 0x0400019C RID: 412
			Automatic = 3,
			// Token: 0x0400019D RID: 413
			Explicit = 4
		}
	}
}
