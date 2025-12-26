using System;
using DG.Tweening.Core;
using UnityEngine;

namespace DG.Tweening.Plugins.Core.PathCore
{
	// Token: 0x0200000D RID: 13
	[Serializable]
	public class Path
	{
		// Token: 0x06000096 RID: 150 RVA: 0x00003ED0 File Offset: 0x000020D0
		public Path(PathType type, Vector3[] waypoints, int subdivisionsXSegment, Color? gizmoColor = null)
		{
			this.type = type;
			this.subdivisionsXSegment = subdivisionsXSegment;
			if (gizmoColor != null)
			{
				this.gizmoColor = gizmoColor.Value;
			}
			this.AssignWaypoints(waypoints, true);
			this.AssignDecoder(type);
			if (DOTween.isUnityEditor)
			{
				DOTween.GizmosDelegates.Add(new TweenCallback(this.Draw));
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00003F5C File Offset: 0x0000215C
		internal void FinalizePath(bool isClosedPath, AxisConstraint lockPositionAxes, Vector3 currTargetVal)
		{
			if (lockPositionAxes != AxisConstraint.None)
			{
				bool flag = (lockPositionAxes & AxisConstraint.X) == AxisConstraint.X;
				bool flag2 = (lockPositionAxes & AxisConstraint.Y) == AxisConstraint.Y;
				bool flag3 = (lockPositionAxes & AxisConstraint.Z) == AxisConstraint.Z;
				for (int i = 0; i < this.wps.Length; i++)
				{
					Vector3 vector = this.wps[i];
					this.wps[i] = new Vector3(flag ? currTargetVal.x : vector.x, flag2 ? currTargetVal.y : vector.y, flag3 ? currTargetVal.z : vector.z);
				}
			}
			this._decoder.FinalizePath(this, this.wps, isClosedPath);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000400C File Offset: 0x0000220C
		internal Vector3 GetPoint(float perc, bool convertToConstantPerc = false)
		{
			if (convertToConstantPerc)
			{
				perc = this.ConvertToConstantPathPerc(perc);
			}
			return this._decoder.GetPoint(perc, this.wps, this);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00004030 File Offset: 0x00002230
		internal float ConvertToConstantPathPerc(float perc)
		{
			if (this.type == PathType.Linear)
			{
				return perc;
			}
			if (perc > 0f && perc < 1f)
			{
				float num = this.length * perc;
				float num2 = 0f;
				float num3 = 0f;
				float num4 = 0f;
				float num5 = 0f;
				int num6 = this.lengthsTable.Length;
				int i = 0;
				while (i < num6)
				{
					if (this.lengthsTable[i] > num)
					{
						num4 = this.timesTable[i];
						num5 = this.lengthsTable[i];
						if (i > 0)
						{
							num3 = this.lengthsTable[i - 1];
							break;
						}
						break;
					}
					else
					{
						num2 = this.timesTable[i];
						i++;
					}
				}
				perc = num2 + (num - num3) / (num5 - num3) * (num4 - num2);
			}
			if (perc > 1f)
			{
				perc = 1f;
			}
			else if (perc < 0f)
			{
				perc = 0f;
			}
			return perc;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000410C File Offset: 0x0000230C
		internal static void RefreshNonLinearDrawWps(Path p)
		{
			int num = p.wps.Length;
			int num2 = num * 5;
			if (p.nonLinearDrawWps == null || p.nonLinearDrawWps.Length != num2 + 1)
			{
				p.nonLinearDrawWps = new Vector3[num2 + 1];
			}
			for (int i = 0; i <= num2; i++)
			{
				float num3 = (float)i / (float)num2;
				Vector3 point = p.GetPoint(num3, false);
				p.nonLinearDrawWps[i] = point;
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00004178 File Offset: 0x00002378
		internal void Destroy()
		{
			if (DOTween.isUnityEditor)
			{
				DOTween.GizmosDelegates.Remove(new TweenCallback(this.Draw));
			}
			this.wps = null;
			this.wpLengths = (this.timesTable = (this.lengthsTable = null));
			this.nonLinearDrawWps = null;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000041CC File Offset: 0x000023CC
		internal void AssignWaypoints(Vector3[] newWps, bool cloneWps = false)
		{
			if (cloneWps)
			{
				int num = newWps.Length;
				this.wps = new Vector3[num];
				for (int i = 0; i < num; i++)
				{
					this.wps[i] = newWps[i];
				}
				return;
			}
			this.wps = newWps;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00004220 File Offset: 0x00002420
		internal void AssignDecoder(PathType pathType)
		{
			this.type = pathType;
			if (pathType == PathType.Linear)
			{
				if (Path._linearDecoder == null)
				{
					Path._linearDecoder = new LinearDecoder();
				}
				this._decoder = Path._linearDecoder;
				return;
			}
			if (Path._catmullRomDecoder == null)
			{
				Path._catmullRomDecoder = new CatmullRomDecoder();
			}
			this._decoder = Path._catmullRomDecoder;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00004273 File Offset: 0x00002473
		private void Draw()
		{
			Path.Draw(this);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000427C File Offset: 0x0000247C
		private static void Draw(Path p)
		{
			if (p.timesTable == null)
			{
				return;
			}
			Color color = p.gizmoColor;
			color.a *= 0.5f;
			Gizmos.color = p.gizmoColor;
			int num = p.wps.Length;
			if (p._changed || (p.type != PathType.Linear && p.nonLinearDrawWps == null))
			{
				p._changed = false;
				if (p.type != PathType.Linear)
				{
					Path.RefreshNonLinearDrawWps(p);
				}
			}
			PathType pathType = p.type;
			if (pathType == PathType.Linear)
			{
				Vector3 vector = p.wps[0];
				for (int i = 0; i < num; i++)
				{
					Vector3 vector2 = p.wps[i];
					Gizmos.DrawLine(vector2, vector);
					vector = vector2;
				}
			}
			else
			{
				Vector3 vector = p.nonLinearDrawWps[0];
				int num2 = p.nonLinearDrawWps.Length;
				for (int j = 1; j < num2; j++)
				{
					Vector3 vector2 = p.nonLinearDrawWps[j];
					Gizmos.DrawLine(vector2, vector);
					vector = vector2;
				}
			}
			Gizmos.color = color;
			for (int k = 0; k < num; k++)
			{
				Gizmos.DrawSphere(p.wps[k], 0.075f);
			}
			if (p.lookAtPosition != null)
			{
				Vector3 value = p.lookAtPosition.Value;
				Gizmos.DrawLine(p.targetPosition, value);
				Gizmos.DrawWireSphere(value, 0.075f);
			}
		}

		// Token: 0x0400001E RID: 30
		private static CatmullRomDecoder _catmullRomDecoder;

		// Token: 0x0400001F RID: 31
		private static LinearDecoder _linearDecoder;

		// Token: 0x04000020 RID: 32
		internal PathType type;

		// Token: 0x04000021 RID: 33
		internal int subdivisionsXSegment;

		// Token: 0x04000022 RID: 34
		internal int subdivisions;

		// Token: 0x04000023 RID: 35
		internal Vector3[] wps;

		// Token: 0x04000024 RID: 36
		internal ControlPoint[] controlPoints;

		// Token: 0x04000025 RID: 37
		internal float length;

		// Token: 0x04000026 RID: 38
		internal float[] wpLengths;

		// Token: 0x04000027 RID: 39
		internal float[] timesTable;

		// Token: 0x04000028 RID: 40
		internal float[] lengthsTable;

		// Token: 0x04000029 RID: 41
		internal int linearWPIndex = -1;

		// Token: 0x0400002A RID: 42
		private ABSPathDecoder _decoder;

		// Token: 0x0400002B RID: 43
		private bool _changed;

		// Token: 0x0400002C RID: 44
		internal Vector3[] nonLinearDrawWps;

		// Token: 0x0400002D RID: 45
		internal Vector3 targetPosition;

		// Token: 0x0400002E RID: 46
		internal Vector3? lookAtPosition;

		// Token: 0x0400002F RID: 47
		internal Color gizmoColor = new Color(1f, 1f, 1f, 0.7f);
	}
}
