using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Representation of 3D vectors and points.</para>
	/// </summary>
	// Token: 0x02000057 RID: 87
	public struct Vector3
	{
		/// <summary>
		///   <para>Creates a new vector with given x, y, z components.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		// Token: 0x060004AA RID: 1194 RVA: 0x000030FD File Offset: 0x000012FD
		public Vector3(float x, float y, float z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		/// <summary>
		///   <para>Creates a new vector with given x, y components and sets z to zero.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		// Token: 0x060004AB RID: 1195 RVA: 0x00003114 File Offset: 0x00001314
		public Vector3(float x, float y)
		{
			this.x = x;
			this.y = y;
			this.z = 0f;
		}

		/// <summary>
		///   <para>Linearly interpolates between two vectors.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="t"></param>
		// Token: 0x060004AC RID: 1196 RVA: 0x00010818 File Offset: 0x0000EA18
		public static Vector3 Lerp(Vector3 a, Vector3 b, float t)
		{
			t = Mathf.Clamp01(t);
			return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
		}

		/// <summary>
		///   <para>Linearly interpolates between two vectors.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="t"></param>
		// Token: 0x060004AD RID: 1197 RVA: 0x00010880 File Offset: 0x0000EA80
		public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t)
		{
			return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
		}

		/// <summary>
		///   <para>Spherically interpolates between two vectors.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="t"></param>
		// Token: 0x060004AE RID: 1198 RVA: 0x0000312F File Offset: 0x0000132F
		public static Vector3 Slerp(Vector3 a, Vector3 b, float t)
		{
			return Vector3.INTERNAL_CALL_Slerp(ref a, ref b, t);
		}

		// Token: 0x060004AF RID: 1199
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Vector3 INTERNAL_CALL_Slerp(ref Vector3 a, ref Vector3 b, float t);

		/// <summary>
		///   <para>Spherically interpolates between two vectors.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="t"></param>
		// Token: 0x060004B0 RID: 1200 RVA: 0x0000313B File Offset: 0x0000133B
		public static Vector3 SlerpUnclamped(Vector3 a, Vector3 b, float t)
		{
			return Vector3.INTERNAL_CALL_SlerpUnclamped(ref a, ref b, t);
		}

		// Token: 0x060004B1 RID: 1201
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Vector3 INTERNAL_CALL_SlerpUnclamped(ref Vector3 a, ref Vector3 b, float t);

		// Token: 0x060004B2 RID: 1202 RVA: 0x00003147 File Offset: 0x00001347
		private static void Internal_OrthoNormalize2(ref Vector3 a, ref Vector3 b)
		{
			Vector3.INTERNAL_CALL_Internal_OrthoNormalize2(ref a, ref b);
		}

		// Token: 0x060004B3 RID: 1203
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_OrthoNormalize2(ref Vector3 a, ref Vector3 b);

		// Token: 0x060004B4 RID: 1204 RVA: 0x00003150 File Offset: 0x00001350
		private static void Internal_OrthoNormalize3(ref Vector3 a, ref Vector3 b, ref Vector3 c)
		{
			Vector3.INTERNAL_CALL_Internal_OrthoNormalize3(ref a, ref b, ref c);
		}

		// Token: 0x060004B5 RID: 1205
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_OrthoNormalize3(ref Vector3 a, ref Vector3 b, ref Vector3 c);

		// Token: 0x060004B6 RID: 1206 RVA: 0x0000315A File Offset: 0x0000135A
		public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent)
		{
			Vector3.Internal_OrthoNormalize2(ref normal, ref tangent);
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00003163 File Offset: 0x00001363
		public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent, ref Vector3 binormal)
		{
			Vector3.Internal_OrthoNormalize3(ref normal, ref tangent, ref binormal);
		}

		/// <summary>
		///   <para>Moves a point current in a straight line towards a target point.</para>
		/// </summary>
		/// <param name="current"></param>
		/// <param name="target"></param>
		/// <param name="maxDistanceDelta"></param>
		// Token: 0x060004B8 RID: 1208 RVA: 0x000108E0 File Offset: 0x0000EAE0
		public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta)
		{
			Vector3 vector = target - current;
			float magnitude = vector.magnitude;
			if (magnitude <= maxDistanceDelta || magnitude == 0f)
			{
				return target;
			}
			return current + vector / magnitude * maxDistanceDelta;
		}

		/// <summary>
		///   <para>Rotates a vector current towards target.</para>
		/// </summary>
		/// <param name="current"></param>
		/// <param name="target"></param>
		/// <param name="maxRadiansDelta"></param>
		/// <param name="maxMagnitudeDelta"></param>
		// Token: 0x060004B9 RID: 1209 RVA: 0x0000316D File Offset: 0x0000136D
		public static Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta)
		{
			return Vector3.INTERNAL_CALL_RotateTowards(ref current, ref target, maxRadiansDelta, maxMagnitudeDelta);
		}

		// Token: 0x060004BA RID: 1210
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Vector3 INTERNAL_CALL_RotateTowards(ref Vector3 current, ref Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta);

		// Token: 0x060004BB RID: 1211 RVA: 0x00010924 File Offset: 0x0000EB24
		[ExcludeFromDocs]
		public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed)
		{
			float deltaTime = Time.deltaTime;
			return Vector3.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00010944 File Offset: 0x0000EB44
		[ExcludeFromDocs]
		public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime)
		{
			float deltaTime = Time.deltaTime;
			float positiveInfinity = float.PositiveInfinity;
			return Vector3.SmoothDamp(current, target, ref currentVelocity, smoothTime, positiveInfinity, deltaTime);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00010968 File Offset: 0x0000EB68
		public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, [DefaultValue("Mathf.Infinity")] float maxSpeed, [DefaultValue("Time.deltaTime")] float deltaTime)
		{
			smoothTime = Mathf.Max(0.0001f, smoothTime);
			float num = 2f / smoothTime;
			float num2 = num * deltaTime;
			float num3 = 1f / (1f + num2 + 0.48f * num2 * num2 + 0.235f * num2 * num2 * num2);
			Vector3 vector = current - target;
			Vector3 vector2 = target;
			float num4 = maxSpeed * smoothTime;
			vector = Vector3.ClampMagnitude(vector, num4);
			target = current - vector;
			Vector3 vector3 = (currentVelocity + num * vector) * deltaTime;
			currentVelocity = (currentVelocity - num * vector3) * num3;
			Vector3 vector4 = target + (vector + vector3) * num3;
			if (Vector3.Dot(vector2 - current, vector4 - vector2) > 0f)
			{
				vector4 = vector2;
				currentVelocity = (vector4 - vector2) / deltaTime;
			}
			return vector4;
		}

		// Token: 0x1700013B RID: 315
		public float this[int index]
		{
			get
			{
				switch (index)
				{
				case 0:
					return this.x;
				case 1:
					return this.y;
				case 2:
					return this.z;
				default:
					throw new IndexOutOfRangeException("Invalid Vector3 index!");
				}
			}
			set
			{
				switch (index)
				{
				case 0:
					this.x = value;
					break;
				case 1:
					this.y = value;
					break;
				case 2:
					this.z = value;
					break;
				default:
					throw new IndexOutOfRangeException("Invalid Vector3 index!");
				}
			}
		}

		/// <summary>
		///   <para>Set x, y and z components of an existing Vector3.</para>
		/// </summary>
		/// <param name="new_x"></param>
		/// <param name="new_y"></param>
		/// <param name="new_z"></param>
		// Token: 0x060004C0 RID: 1216 RVA: 0x000030FD File Offset: 0x000012FD
		public void Set(float new_x, float new_y, float new_z)
		{
			this.x = new_x;
			this.y = new_y;
			this.z = new_z;
		}

		/// <summary>
		///   <para>Multiplies two vectors component-wise.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		// Token: 0x060004C1 RID: 1217 RVA: 0x0000317A File Offset: 0x0000137A
		public static Vector3 Scale(Vector3 a, Vector3 b)
		{
			return new Vector3(a.x * b.x, a.y * b.y, a.z * b.z);
		}

		/// <summary>
		///   <para>Multiplies every component of this vector by the same component of scale.</para>
		/// </summary>
		/// <param name="scale"></param>
		// Token: 0x060004C2 RID: 1218 RVA: 0x000031AE File Offset: 0x000013AE
		public void Scale(Vector3 scale)
		{
			this.x *= scale.x;
			this.y *= scale.y;
			this.z *= scale.z;
		}

		/// <summary>
		///   <para>Cross Product of two vectors.</para>
		/// </summary>
		/// <param name="lhs"></param>
		/// <param name="rhs"></param>
		// Token: 0x060004C3 RID: 1219 RVA: 0x00010B04 File Offset: 0x0000ED04
		public static Vector3 Cross(Vector3 lhs, Vector3 rhs)
		{
			return new Vector3(lhs.y * rhs.z - lhs.z * rhs.y, lhs.z * rhs.x - lhs.x * rhs.z, lhs.x * rhs.y - lhs.y * rhs.x);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x000031EC File Offset: 0x000013EC
		public override int GetHashCode()
		{
			return this.x.GetHashCode() ^ (this.y.GetHashCode() << 2) ^ (this.z.GetHashCode() >> 2);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00010B74 File Offset: 0x0000ED74
		public override bool Equals(object other)
		{
			if (!(other is Vector3))
			{
				return false;
			}
			Vector3 vector = (Vector3)other;
			return this.x.Equals(vector.x) && this.y.Equals(vector.y) && this.z.Equals(vector.z);
		}

		/// <summary>
		///   <para>Reflects a vector off the plane defined by a normal.</para>
		/// </summary>
		/// <param name="inDirection"></param>
		/// <param name="inNormal"></param>
		// Token: 0x060004C6 RID: 1222 RVA: 0x00003215 File Offset: 0x00001415
		public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal)
		{
			return -2f * Vector3.Dot(inNormal, inDirection) * inNormal + inDirection;
		}

		/// <summary>
		///   <para></para>
		/// </summary>
		/// <param name="value"></param>
		// Token: 0x060004C7 RID: 1223 RVA: 0x00010BD8 File Offset: 0x0000EDD8
		public static Vector3 Normalize(Vector3 value)
		{
			float num = Vector3.Magnitude(value);
			if (num > 1E-05f)
			{
				return value / num;
			}
			return Vector3.zero;
		}

		/// <summary>
		///   <para>Makes this vector have a magnitude of 1.</para>
		/// </summary>
		// Token: 0x060004C8 RID: 1224 RVA: 0x00010C04 File Offset: 0x0000EE04
		public void Normalize()
		{
			float num = Vector3.Magnitude(this);
			if (num > 1E-05f)
			{
				this /= num;
			}
			else
			{
				this = Vector3.zero;
			}
		}

		/// <summary>
		///   <para>Returns this vector with a magnitude of 1 (Read Only).</para>
		/// </summary>
		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x00003230 File Offset: 0x00001430
		public Vector3 normalized
		{
			get
			{
				return Vector3.Normalize(this);
			}
		}

		/// <summary>
		///   <para>Returns a nicely formatted string for this vector.</para>
		/// </summary>
		/// <param name="format"></param>
		// Token: 0x060004CA RID: 1226 RVA: 0x0000323D File Offset: 0x0000143D
		public override string ToString()
		{
			return UnityString.Format("({0:F1}, {1:F1}, {2:F1})", new object[] { this.x, this.y, this.z });
		}

		/// <summary>
		///   <para>Returns a nicely formatted string for this vector.</para>
		/// </summary>
		/// <param name="format"></param>
		// Token: 0x060004CB RID: 1227 RVA: 0x00003279 File Offset: 0x00001479
		public string ToString(string format)
		{
			return UnityString.Format("({0}, {1}, {2})", new object[]
			{
				this.x.ToString(format),
				this.y.ToString(format),
				this.z.ToString(format)
			});
		}

		/// <summary>
		///   <para>Dot Product of two vectors.</para>
		/// </summary>
		/// <param name="lhs"></param>
		/// <param name="rhs"></param>
		// Token: 0x060004CC RID: 1228 RVA: 0x000032B8 File Offset: 0x000014B8
		public static float Dot(Vector3 lhs, Vector3 rhs)
		{
			return lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z;
		}

		/// <summary>
		///   <para>Projects a vector onto another vector.</para>
		/// </summary>
		/// <param name="vector"></param>
		/// <param name="onNormal"></param>
		// Token: 0x060004CD RID: 1229 RVA: 0x00010C4C File Offset: 0x0000EE4C
		public static Vector3 Project(Vector3 vector, Vector3 onNormal)
		{
			float num = Vector3.Dot(onNormal, onNormal);
			if (num < Mathf.Epsilon)
			{
				return Vector3.zero;
			}
			return onNormal * Vector3.Dot(vector, onNormal) / num;
		}

		/// <summary>
		///   <para>Projects a vector onto a plane defined by a normal orthogonal to the plane.</para>
		/// </summary>
		/// <param name="vector"></param>
		/// <param name="planeNormal"></param>
		// Token: 0x060004CE RID: 1230 RVA: 0x000032E9 File Offset: 0x000014E9
		public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal)
		{
			return vector - Vector3.Project(vector, planeNormal);
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x000032F8 File Offset: 0x000014F8
		[Obsolete("Use Vector3.ProjectOnPlane instead.")]
		public static Vector3 Exclude(Vector3 excludeThis, Vector3 fromThat)
		{
			return fromThat - Vector3.Project(fromThat, excludeThis);
		}

		/// <summary>
		///   <para>Returns the angle in degrees between from and to.</para>
		/// </summary>
		/// <param name="from">The angle extends round from this vector.</param>
		/// <param name="to">The angle extends round to this vector.</param>
		// Token: 0x060004D0 RID: 1232 RVA: 0x00003307 File Offset: 0x00001507
		public static float Angle(Vector3 from, Vector3 to)
		{
			return Mathf.Acos(Mathf.Clamp(Vector3.Dot(from.normalized, to.normalized), -1f, 1f)) * 57.29578f;
		}

		/// <summary>
		///   <para>Returns the distance between a and b.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		// Token: 0x060004D1 RID: 1233 RVA: 0x00010C88 File Offset: 0x0000EE88
		public static float Distance(Vector3 a, Vector3 b)
		{
			Vector3 vector = new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
			return Mathf.Sqrt(vector.x * vector.x + vector.y * vector.y + vector.z * vector.z);
		}

		/// <summary>
		///   <para>Returns a copy of vector with its magnitude clamped to maxLength.</para>
		/// </summary>
		/// <param name="vector"></param>
		/// <param name="maxLength"></param>
		// Token: 0x060004D2 RID: 1234 RVA: 0x00003336 File Offset: 0x00001536
		public static Vector3 ClampMagnitude(Vector3 vector, float maxLength)
		{
			if (vector.sqrMagnitude > maxLength * maxLength)
			{
				return vector.normalized * maxLength;
			}
			return vector;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00003356 File Offset: 0x00001556
		public static float Magnitude(Vector3 a)
		{
			return Mathf.Sqrt(a.x * a.x + a.y * a.y + a.z * a.z);
		}

		/// <summary>
		///   <para>Returns the length of this vector (Read Only).</para>
		/// </summary>
		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x0000338C File Offset: 0x0000158C
		public float magnitude
		{
			get
			{
				return Mathf.Sqrt(this.x * this.x + this.y * this.y + this.z * this.z);
			}
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x000033BC File Offset: 0x000015BC
		public static float SqrMagnitude(Vector3 a)
		{
			return a.x * a.x + a.y * a.y + a.z * a.z;
		}

		/// <summary>
		///   <para>Returns the squared length of this vector (Read Only).</para>
		/// </summary>
		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x000033ED File Offset: 0x000015ED
		public float sqrMagnitude
		{
			get
			{
				return this.x * this.x + this.y * this.y + this.z * this.z;
			}
		}

		/// <summary>
		///   <para>Returns a vector that is made from the smallest components of two vectors.</para>
		/// </summary>
		/// <param name="lhs"></param>
		/// <param name="rhs"></param>
		// Token: 0x060004D7 RID: 1239 RVA: 0x00003418 File Offset: 0x00001618
		public static Vector3 Min(Vector3 lhs, Vector3 rhs)
		{
			return new Vector3(Mathf.Min(lhs.x, rhs.x), Mathf.Min(lhs.y, rhs.y), Mathf.Min(lhs.z, rhs.z));
		}

		/// <summary>
		///   <para>Returns a vector that is made from the largest components of two vectors.</para>
		/// </summary>
		/// <param name="lhs"></param>
		/// <param name="rhs"></param>
		// Token: 0x060004D8 RID: 1240 RVA: 0x00003458 File Offset: 0x00001658
		public static Vector3 Max(Vector3 lhs, Vector3 rhs)
		{
			return new Vector3(Mathf.Max(lhs.x, rhs.x), Mathf.Max(lhs.y, rhs.y), Mathf.Max(lhs.z, rhs.z));
		}

		/// <summary>
		///   <para>Shorthand for writing Vector3(0, 0, 0).</para>
		/// </summary>
		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x00003498 File Offset: 0x00001698
		public static Vector3 zero
		{
			get
			{
				return new Vector3(0f, 0f, 0f);
			}
		}

		/// <summary>
		///   <para>Shorthand for writing Vector3(1, 1, 1).</para>
		/// </summary>
		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x000034AE File Offset: 0x000016AE
		public static Vector3 one
		{
			get
			{
				return new Vector3(1f, 1f, 1f);
			}
		}

		/// <summary>
		///   <para>Shorthand for writing Vector3(0, 0, 1).</para>
		/// </summary>
		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x000034C4 File Offset: 0x000016C4
		public static Vector3 forward
		{
			get
			{
				return new Vector3(0f, 0f, 1f);
			}
		}

		/// <summary>
		///   <para>Shorthand for writing Vector3(0, 0, -1).</para>
		/// </summary>
		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x000034DA File Offset: 0x000016DA
		public static Vector3 back
		{
			get
			{
				return new Vector3(0f, 0f, -1f);
			}
		}

		/// <summary>
		///   <para>Shorthand for writing Vector3(0, 1, 0).</para>
		/// </summary>
		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x000034F0 File Offset: 0x000016F0
		public static Vector3 up
		{
			get
			{
				return new Vector3(0f, 1f, 0f);
			}
		}

		/// <summary>
		///   <para>Shorthand for writing Vector3(0, -1, 0).</para>
		/// </summary>
		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x00003506 File Offset: 0x00001706
		public static Vector3 down
		{
			get
			{
				return new Vector3(0f, -1f, 0f);
			}
		}

		/// <summary>
		///   <para>Shorthand for writing Vector3(-1, 0, 0).</para>
		/// </summary>
		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x0000351C File Offset: 0x0000171C
		public static Vector3 left
		{
			get
			{
				return new Vector3(-1f, 0f, 0f);
			}
		}

		/// <summary>
		///   <para>Shorthand for writing Vector3(1, 0, 0).</para>
		/// </summary>
		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x00003532 File Offset: 0x00001732
		public static Vector3 right
		{
			get
			{
				return new Vector3(1f, 0f, 0f);
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x000034C4 File Offset: 0x000016C4
		[Obsolete("Use Vector3.forward instead.")]
		public static Vector3 fwd
		{
			get
			{
				return new Vector3(0f, 0f, 1f);
			}
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00003548 File Offset: 0x00001748
		[Obsolete("Use Vector3.Angle instead. AngleBetween uses radians instead of degrees and was deprecated for this reason")]
		public static float AngleBetween(Vector3 from, Vector3 to)
		{
			return Mathf.Acos(Mathf.Clamp(Vector3.Dot(from.normalized, to.normalized), -1f, 1f));
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00003571 File Offset: 0x00001771
		public static Vector3 operator +(Vector3 a, Vector3 b)
		{
			return new Vector3(a.x + b.x, a.y + b.y, a.z + b.z);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x000035A5 File Offset: 0x000017A5
		public static Vector3 operator -(Vector3 a, Vector3 b)
		{
			return new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x000035D9 File Offset: 0x000017D9
		public static Vector3 operator -(Vector3 a)
		{
			return new Vector3(-a.x, -a.y, -a.z);
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x000035F8 File Offset: 0x000017F8
		public static Vector3 operator *(Vector3 a, float d)
		{
			return new Vector3(a.x * d, a.y * d, a.z * d);
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0000361A File Offset: 0x0000181A
		public static Vector3 operator *(float d, Vector3 a)
		{
			return new Vector3(a.x * d, a.y * d, a.z * d);
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0000363C File Offset: 0x0000183C
		public static Vector3 operator /(Vector3 a, float d)
		{
			return new Vector3(a.x / d, a.y / d, a.z / d);
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0000365E File Offset: 0x0000185E
		public static bool operator ==(Vector3 lhs, Vector3 rhs)
		{
			return Vector3.SqrMagnitude(lhs - rhs) < 9.9999994E-11f;
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00003673 File Offset: 0x00001873
		public static bool operator !=(Vector3 lhs, Vector3 rhs)
		{
			return Vector3.SqrMagnitude(lhs - rhs) >= 9.9999994E-11f;
		}

		// Token: 0x040000CF RID: 207
		public const float kEpsilon = 1E-05f;

		/// <summary>
		///   <para>X component of the vector.</para>
		/// </summary>
		// Token: 0x040000D0 RID: 208
		public float x;

		/// <summary>
		///   <para>Y component of the vector.</para>
		/// </summary>
		// Token: 0x040000D1 RID: 209
		public float y;

		/// <summary>
		///   <para>Z component of the vector.</para>
		/// </summary>
		// Token: 0x040000D2 RID: 210
		public float z;
	}
}
