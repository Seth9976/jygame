using System;
using UnityEngine;

namespace DG.Tweening
{
	// Token: 0x0200000A RID: 10
	public struct Color2
	{
		// Token: 0x06000052 RID: 82 RVA: 0x00002F5D File Offset: 0x0000115D
		public Color2(Color ca, Color cb)
		{
			this.ca = ca;
			this.cb = cb;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002F6D File Offset: 0x0000116D
		public static Color2 operator +(Color2 c1, Color2 c2)
		{
			return new Color2(c1.ca + c2.ca, c1.cb + c2.cb);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002F9A File Offset: 0x0000119A
		public static Color2 operator -(Color2 c1, Color2 c2)
		{
			return new Color2(c1.ca - c2.ca, c1.cb - c2.cb);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002FC7 File Offset: 0x000011C7
		public static Color2 operator *(Color2 c1, float f)
		{
			return new Color2(c1.ca * f, c1.cb * f);
		}

		// Token: 0x0400001C RID: 28
		public Color ca;

		// Token: 0x0400001D RID: 29
		public Color cb;
	}
}
