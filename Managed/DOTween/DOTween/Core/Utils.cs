using System;
using UnityEngine;

namespace DG.Tweening.Core
{
	// Token: 0x0200003A RID: 58
	internal static class Utils
	{
		// Token: 0x0600018E RID: 398 RVA: 0x0000A070 File Offset: 0x00008270
		internal static Vector3 Vector3FromAngle(float degrees, float magnitude)
		{
			float num = degrees * 0.017453292f;
			return new Vector3(magnitude * Mathf.Cos(num), magnitude * Mathf.Sin(num), 0f);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000A0A0 File Offset: 0x000082A0
		public static float Angle2D(Vector3 from, Vector3 to)
		{
			Vector2 right = Vector2.right;
			to -= from;
			float num = Vector2.Angle(right, to);
			if (Vector3.Cross(right, to).z > 0f)
			{
				num = 360f - num;
			}
			return num * -1f;
		}
	}
}
