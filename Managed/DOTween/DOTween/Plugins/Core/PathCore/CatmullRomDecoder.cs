using System;
using UnityEngine;

namespace DG.Tweening.Plugins.Core.PathCore
{
	// Token: 0x0200001C RID: 28
	internal class CatmullRomDecoder : ABSPathDecoder
	{
		// Token: 0x060000EA RID: 234 RVA: 0x0000627C File Offset: 0x0000447C
		internal override void FinalizePath(Path p, Vector3[] wps, bool isClosedPath)
		{
			int num = wps.Length;
			if (p.controlPoints == null || p.controlPoints.Length != 2)
			{
				p.controlPoints = new ControlPoint[2];
			}
			if (isClosedPath)
			{
				p.controlPoints[0] = new ControlPoint(wps[num - 2], Vector3.zero);
				p.controlPoints[1] = new ControlPoint(wps[1], Vector3.zero);
			}
			else
			{
				p.controlPoints[0] = new ControlPoint(wps[1], Vector3.zero);
				Vector3 vector = wps[num - 1];
				Vector3 vector2 = vector - wps[num - 2];
				p.controlPoints[1] = new ControlPoint(vector + vector2, Vector3.zero);
			}
			p.subdivisions = (num + 2) * p.subdivisionsXSegment;
			this.SetTimeToLengthTables(p, p.subdivisions);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000638C File Offset: 0x0000458C
		internal override Vector3 GetPoint(float perc, Vector3[] wps, Path p)
		{
			int num = wps.Length - 1;
			int num2 = (int)Math.Floor((double)(perc * (float)num));
			int num3 = num - 1;
			if (num3 > num2)
			{
				num3 = num2;
			}
			float num4 = perc * (float)num - (float)num3;
			Vector3 vector = ((num3 == 0) ? p.controlPoints[0].a : wps[num3 - 1]);
			Vector3 vector2 = wps[num3];
			Vector3 vector3 = wps[num3 + 1];
			Vector3 vector4 = ((num3 + 2 > wps.Length - 1) ? p.controlPoints[1].a : wps[num3 + 2]);
			return 0.5f * ((-vector + 3f * vector2 - 3f * vector3 + vector4) * (num4 * num4 * num4) + (2f * vector - 5f * vector2 + 4f * vector3 - vector4) * (num4 * num4) + (-vector + vector3) * num4 + 2f * vector2);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000064E0 File Offset: 0x000046E0
		internal void SetTimeToLengthTables(Path p, int subdivisions)
		{
			float num = 0f;
			float num2 = 1f / (float)subdivisions;
			float[] array = new float[subdivisions];
			float[] array2 = new float[subdivisions];
			Vector3 vector = this.GetPoint(0f, p.wps, p);
			for (int i = 1; i < subdivisions + 1; i++)
			{
				float num3 = num2 * (float)i;
				Vector3 point = this.GetPoint(num3, p.wps, p);
				num += Vector3.Distance(point, vector);
				vector = point;
				array[i - 1] = num3;
				array2[i - 1] = num;
			}
			p.length = num;
			p.timesTable = array;
			p.lengthsTable = array2;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000657C File Offset: 0x0000477C
		internal void SetWaypointsLengths(Path p, int subdivisions)
		{
			int num = p.wps.Length - 2;
			float[] array = new float[num];
			array[0] = 0f;
			Vector3[] array2 = new Vector3[4];
			for (int i = 2; i < num + 1; i++)
			{
				array2[0] = p.wps[i - 2];
				array2[1] = p.wps[i - 1];
				array2[2] = p.wps[i];
				array2[3] = p.wps[i + 1];
				float num2 = 0f;
				float num3 = 1f / (float)subdivisions;
				Vector3 vector = this.GetPoint(0f, array2, p);
				for (int j = 1; j < subdivisions + 1; j++)
				{
					float num4 = num3 * (float)j;
					Vector3 point = this.GetPoint(num4, array2, p);
					num2 += Vector3.Distance(point, vector);
					vector = point;
				}
				array[i - 1] = num2;
			}
			p.wpLengths = array;
		}
	}
}
