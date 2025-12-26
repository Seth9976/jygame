using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Easing;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening.Plugins
{
	// Token: 0x02000024 RID: 36
	public class PathPlugin : ABSTweenPlugin<Vector3, Path, PathOptions>
	{
		// Token: 0x06000138 RID: 312 RVA: 0x000086BC File Offset: 0x000068BC
		public override void Reset(TweenerCore<Vector3, Path, PathOptions> t)
		{
			t.endValue.Destroy();
			t.startValue = (t.endValue = (t.changeValue = null));
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000086ED File Offset: 0x000068ED
		public override void SetFrom(TweenerCore<Vector3, Path, PathOptions> t, bool isRelative)
		{
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000086EF File Offset: 0x000068EF
		public static ABSTweenPlugin<Vector3, Path, PathOptions> Get()
		{
			return PluginsManager.GetCustomPlugin<PathPlugin, Vector3, Path, PathOptions>();
		}

		// Token: 0x0600013B RID: 315 RVA: 0x000086F6 File Offset: 0x000068F6
		public override Path ConvertToStartValue(TweenerCore<Vector3, Path, PathOptions> t, Vector3 value)
		{
			return t.endValue;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00008700 File Offset: 0x00006900
		public override void SetRelativeEndValue(TweenerCore<Vector3, Path, PathOptions> t)
		{
			Vector3 vector = t.getter();
			int num = t.endValue.wps.Length;
			for (int i = 0; i < num; i++)
			{
				t.endValue.wps[i] += vector;
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00008758 File Offset: 0x00006958
		public override void SetChangeValue(TweenerCore<Vector3, Path, PathOptions> t)
		{
			Vector3 vector = t.getter();
			Path endValue = t.endValue;
			int num = endValue.wps.Length;
			int num2 = 0;
			bool flag = false;
			bool flag2 = false;
			if (endValue.wps[0] != vector)
			{
				flag = true;
				num2++;
			}
			if (t.plugOptions.isClosedPath && endValue.wps[num - 1] != vector)
			{
				flag2 = true;
				num2++;
			}
			int num3 = num + num2;
			Vector3[] array = new Vector3[num3];
			int num4 = (flag ? 1 : 0);
			if (flag)
			{
				array[0] = vector;
			}
			if (flag2)
			{
				array[array.Length - 1] = array[0];
			}
			for (int i = 0; i < num; i++)
			{
				array[i + num4] = endValue.wps[i];
			}
			endValue.wps = array;
			endValue.FinalizePath(t.plugOptions.isClosedPath, t.plugOptions.lockPositionAxis, vector);
			Transform transform = (Transform)t.target;
			t.plugOptions.startupZRot = transform.eulerAngles.z;
			if (t.plugOptions.orientType == OrientType.ToPath && t.plugOptions.useLocalPosition)
			{
				t.plugOptions.parent = transform.parent;
			}
			t.changeValue = t.endValue;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000088DA File Offset: 0x00006ADA
		public override float GetSpeedBasedDuration(PathOptions options, float unitsXSecond, Path changeValue)
		{
			return changeValue.length / unitsXSecond;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000088E4 File Offset: 0x00006AE4
		public override void EvaluateAndApply(PathOptions options, Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Path startValue, Path changeValue, float duration)
		{
			float num = EaseManager.Evaluate(t, elapsed, 0f, 1f, duration, t.easeOvershootOrAmplitude, t.easePeriod);
			float num2 = changeValue.ConvertToConstantPathPerc(num);
			Vector3 point = changeValue.GetPoint(num2, false);
			changeValue.targetPosition = point;
			setter(point);
			if (options.orientType != OrientType.None)
			{
				Transform transform = (Transform)t.target;
				Quaternion quaternion = Quaternion.identity;
				switch (options.orientType)
				{
				case OrientType.ToPath:
				{
					Vector3 vector;
					if (changeValue.type == PathType.Linear && options.lookAhead <= 0.0001f)
					{
						vector = point + changeValue.wps[changeValue.linearWPIndex] - changeValue.wps[changeValue.linearWPIndex - 1];
					}
					else
					{
						float num3 = num2 + options.lookAhead;
						if (num3 > 1f)
						{
							num3 = (options.isClosedPath ? (num3 - 1f) : 1.00001f);
						}
						vector = changeValue.GetPoint(num3, false);
					}
					Vector3 vector2 = transform.up;
					if (options.useLocalPosition && options.parent != null)
					{
						vector = options.parent.TransformPoint(vector);
					}
					if (options.lockRotationAxis != AxisConstraint.None)
					{
						if ((options.lockRotationAxis & AxisConstraint.X) == AxisConstraint.X)
						{
							Vector3 vector3 = transform.InverseTransformPoint(vector);
							vector3.y = 0f;
							vector = transform.TransformPoint(vector3);
							vector2 = ((options.useLocalPosition && options.parent != null) ? options.parent.up : Vector3.up);
						}
						if ((options.lockRotationAxis & AxisConstraint.Y) == AxisConstraint.Y)
						{
							Vector3 vector4 = transform.InverseTransformPoint(vector);
							if (vector4.z < 0f)
							{
								vector4.z = -vector4.z;
							}
							vector4.x = 0f;
							vector = transform.TransformPoint(vector4);
						}
						if ((options.lockRotationAxis & AxisConstraint.Z) == AxisConstraint.Z)
						{
							if (options.useLocalPosition && options.parent != null)
							{
								vector2 = options.parent.TransformDirection(Vector3.up);
							}
							else
							{
								vector2 = transform.TransformDirection(Vector3.up);
							}
							vector2.z = options.startupZRot;
						}
					}
					if (options.mode == PathMode.Full3D)
					{
						Vector3 vector5 = vector - transform.position;
						if (vector5 == Vector3.zero)
						{
							vector5 = transform.forward;
						}
						quaternion = Quaternion.LookRotation(vector5, vector2);
					}
					else
					{
						float num4 = 0f;
						float num5 = Utils.Angle2D(transform.position, vector);
						if (num5 < 0f)
						{
							num5 = 360f + num5;
						}
						if (options.mode == PathMode.Sidescroller2D)
						{
							num4 = (float)((vector.x < transform.position.x) ? 180 : 0);
							if (num5 > 90f && num5 < 270f)
							{
								num5 = 180f - num5;
							}
						}
						quaternion = Quaternion.Euler(0f, num4, num5);
					}
					break;
				}
				case OrientType.LookAtTransform:
					if (options.lookAtTransform != null)
					{
						changeValue.lookAtPosition = new Vector3?(options.lookAtTransform.position);
						quaternion = Quaternion.LookRotation(options.lookAtTransform.position - transform.position, transform.up);
					}
					break;
				case OrientType.LookAtPosition:
					changeValue.lookAtPosition = new Vector3?(options.lookAtPosition);
					quaternion = Quaternion.LookRotation(options.lookAtPosition - transform.position, transform.up);
					break;
				}
				if (options.hasCustomForwardDirection)
				{
					quaternion *= options.forward;
				}
				transform.rotation = quaternion;
			}
		}

		// Token: 0x040000BB RID: 187
		public const float MinLookAhead = 0.0001f;
	}
}
