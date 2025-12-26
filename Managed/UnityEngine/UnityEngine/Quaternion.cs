using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Quaternions are used to represent rotations.</para>
	/// </summary>
	// Token: 0x0200005A RID: 90
	public struct Quaternion
	{
		/// <summary>
		///   <para>Constructs new Quaternion with given x,y,z,w components.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		/// <param name="w"></param>
		// Token: 0x06000518 RID: 1304 RVA: 0x00003A3D File Offset: 0x00001C3D
		public Quaternion(float x, float y, float z, float w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		// Token: 0x17000158 RID: 344
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
				case 3:
					return this.w;
				default:
					throw new IndexOutOfRangeException("Invalid Quaternion index!");
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
				case 3:
					this.w = value;
					break;
				default:
					throw new IndexOutOfRangeException("Invalid Quaternion index!");
				}
			}
		}

		/// <summary>
		///   <para>Set x, y, z and w components of an existing Quaternion.</para>
		/// </summary>
		/// <param name="new_x"></param>
		/// <param name="new_y"></param>
		/// <param name="new_z"></param>
		/// <param name="new_w"></param>
		// Token: 0x0600051B RID: 1307 RVA: 0x00003A3D File Offset: 0x00001C3D
		public void Set(float new_x, float new_y, float new_z, float new_w)
		{
			this.x = new_x;
			this.y = new_y;
			this.z = new_z;
			this.w = new_w;
		}

		/// <summary>
		///   <para>The identity rotation (Read Only).</para>
		/// </summary>
		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x00003A5C File Offset: 0x00001C5C
		public static Quaternion identity
		{
			get
			{
				return new Quaternion(0f, 0f, 0f, 1f);
			}
		}

		/// <summary>
		///   <para>The dot product between two rotations.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		// Token: 0x0600051D RID: 1309 RVA: 0x000113CC File Offset: 0x0000F5CC
		public static float Dot(Quaternion a, Quaternion b)
		{
			return a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w;
		}

		/// <summary>
		///   <para>Creates a rotation which rotates angle degrees around axis.</para>
		/// </summary>
		/// <param name="angle"></param>
		/// <param name="axis"></param>
		// Token: 0x0600051E RID: 1310 RVA: 0x00003A77 File Offset: 0x00001C77
		public static Quaternion AngleAxis(float angle, Vector3 axis)
		{
			return Quaternion.INTERNAL_CALL_AngleAxis(angle, ref axis);
		}

		// Token: 0x0600051F RID: 1311
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Quaternion INTERNAL_CALL_AngleAxis(float angle, ref Vector3 axis);

		// Token: 0x06000520 RID: 1312 RVA: 0x00003A81 File Offset: 0x00001C81
		public void ToAngleAxis(out float angle, out Vector3 axis)
		{
			Quaternion.Internal_ToAxisAngleRad(this, out axis, out angle);
			angle *= 57.29578f;
		}

		/// <summary>
		///   <para>Creates a rotation which rotates from fromDirection to toDirection.</para>
		/// </summary>
		/// <param name="fromDirection"></param>
		/// <param name="toDirection"></param>
		// Token: 0x06000521 RID: 1313 RVA: 0x00003A9A File Offset: 0x00001C9A
		public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection)
		{
			return Quaternion.INTERNAL_CALL_FromToRotation(ref fromDirection, ref toDirection);
		}

		// Token: 0x06000522 RID: 1314
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Quaternion INTERNAL_CALL_FromToRotation(ref Vector3 fromDirection, ref Vector3 toDirection);

		/// <summary>
		///   <para>Creates a rotation which rotates from fromDirection to toDirection.</para>
		/// </summary>
		/// <param name="fromDirection"></param>
		/// <param name="toDirection"></param>
		// Token: 0x06000523 RID: 1315 RVA: 0x00003AA5 File Offset: 0x00001CA5
		public void SetFromToRotation(Vector3 fromDirection, Vector3 toDirection)
		{
			this = Quaternion.FromToRotation(fromDirection, toDirection);
		}

		/// <summary>
		///   <para>Creates a rotation with the specified forward and upwards directions.</para>
		/// </summary>
		/// <param name="forward">The direction to look in.</param>
		/// <param name="upwards">The vector that defines in which direction up is.</param>
		// Token: 0x06000524 RID: 1316 RVA: 0x00003AB4 File Offset: 0x00001CB4
		public static Quaternion LookRotation(Vector3 forward, [DefaultValue("Vector3.up")] Vector3 upwards)
		{
			return Quaternion.INTERNAL_CALL_LookRotation(ref forward, ref upwards);
		}

		/// <summary>
		///   <para>Creates a rotation with the specified forward and upwards directions.</para>
		/// </summary>
		/// <param name="forward">The direction to look in.</param>
		/// <param name="upwards">The vector that defines in which direction up is.</param>
		// Token: 0x06000525 RID: 1317 RVA: 0x00011418 File Offset: 0x0000F618
		[ExcludeFromDocs]
		public static Quaternion LookRotation(Vector3 forward)
		{
			Vector3 up = Vector3.up;
			return Quaternion.INTERNAL_CALL_LookRotation(ref forward, ref up);
		}

		// Token: 0x06000526 RID: 1318
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Quaternion INTERNAL_CALL_LookRotation(ref Vector3 forward, ref Vector3 upwards);

		/// <summary>
		///   <para>Creates a rotation with the specified forward and upwards directions.</para>
		/// </summary>
		/// <param name="view">The direction to look in.</param>
		/// <param name="up">The vector that defines in which direction up is.</param>
		// Token: 0x06000527 RID: 1319 RVA: 0x00011434 File Offset: 0x0000F634
		[ExcludeFromDocs]
		public void SetLookRotation(Vector3 view)
		{
			Vector3 up = Vector3.up;
			this.SetLookRotation(view, up);
		}

		/// <summary>
		///   <para>Creates a rotation with the specified forward and upwards directions.</para>
		/// </summary>
		/// <param name="view">The direction to look in.</param>
		/// <param name="up">The vector that defines in which direction up is.</param>
		// Token: 0x06000528 RID: 1320 RVA: 0x00003ABF File Offset: 0x00001CBF
		public void SetLookRotation(Vector3 view, [DefaultValue("Vector3.up")] Vector3 up)
		{
			this = Quaternion.LookRotation(view, up);
		}

		/// <summary>
		///   <para>Spherically interpolates between a and b by t. The parameter t is clamped to the range [0, 1].</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="t"></param>
		// Token: 0x06000529 RID: 1321 RVA: 0x00003ACE File Offset: 0x00001CCE
		public static Quaternion Slerp(Quaternion a, Quaternion b, float t)
		{
			return Quaternion.INTERNAL_CALL_Slerp(ref a, ref b, t);
		}

		// Token: 0x0600052A RID: 1322
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Quaternion INTERNAL_CALL_Slerp(ref Quaternion a, ref Quaternion b, float t);

		/// <summary>
		///   <para>Spherically interpolates between a and b by t. The parameter t is not clamped.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="t"></param>
		// Token: 0x0600052B RID: 1323 RVA: 0x00003ADA File Offset: 0x00001CDA
		public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t)
		{
			return Quaternion.INTERNAL_CALL_SlerpUnclamped(ref a, ref b, t);
		}

		// Token: 0x0600052C RID: 1324
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Quaternion INTERNAL_CALL_SlerpUnclamped(ref Quaternion a, ref Quaternion b, float t);

		/// <summary>
		///   <para>Interpolates between a and b by t and normalizes the result afterwards. The parameter t is clamped to the range [0, 1].</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="t"></param>
		// Token: 0x0600052D RID: 1325 RVA: 0x00003AE6 File Offset: 0x00001CE6
		public static Quaternion Lerp(Quaternion a, Quaternion b, float t)
		{
			return Quaternion.INTERNAL_CALL_Lerp(ref a, ref b, t);
		}

		// Token: 0x0600052E RID: 1326
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Quaternion INTERNAL_CALL_Lerp(ref Quaternion a, ref Quaternion b, float t);

		/// <summary>
		///   <para>Interpolates between a and b by t and normalizes the result afterwards. The parameter t is not clamped.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="t"></param>
		// Token: 0x0600052F RID: 1327 RVA: 0x00003AF2 File Offset: 0x00001CF2
		public static Quaternion LerpUnclamped(Quaternion a, Quaternion b, float t)
		{
			return Quaternion.INTERNAL_CALL_LerpUnclamped(ref a, ref b, t);
		}

		// Token: 0x06000530 RID: 1328
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Quaternion INTERNAL_CALL_LerpUnclamped(ref Quaternion a, ref Quaternion b, float t);

		/// <summary>
		///   <para>Rotates a rotation from towards to.</para>
		/// </summary>
		/// <param name="from"></param>
		/// <param name="to"></param>
		/// <param name="maxDegreesDelta"></param>
		// Token: 0x06000531 RID: 1329 RVA: 0x00011450 File Offset: 0x0000F650
		public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta)
		{
			float num = Quaternion.Angle(from, to);
			if (num == 0f)
			{
				return to;
			}
			float num2 = Mathf.Min(1f, maxDegreesDelta / num);
			return Quaternion.SlerpUnclamped(from, to, num2);
		}

		/// <summary>
		///   <para>Returns the Inverse of rotation.</para>
		/// </summary>
		/// <param name="rotation"></param>
		// Token: 0x06000532 RID: 1330 RVA: 0x00003AFE File Offset: 0x00001CFE
		public static Quaternion Inverse(Quaternion rotation)
		{
			return Quaternion.INTERNAL_CALL_Inverse(ref rotation);
		}

		// Token: 0x06000533 RID: 1331
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Quaternion INTERNAL_CALL_Inverse(ref Quaternion rotation);

		/// <summary>
		///   <para>Returns a nicely formatted string of the Quaternion.</para>
		/// </summary>
		/// <param name="format"></param>
		// Token: 0x06000534 RID: 1332 RVA: 0x00011488 File Offset: 0x0000F688
		public override string ToString()
		{
			return UnityString.Format("({0:F1}, {1:F1}, {2:F1}, {3:F1})", new object[] { this.x, this.y, this.z, this.w });
		}

		/// <summary>
		///   <para>Returns a nicely formatted string of the Quaternion.</para>
		/// </summary>
		/// <param name="format"></param>
		// Token: 0x06000535 RID: 1333 RVA: 0x000114E0 File Offset: 0x0000F6E0
		public string ToString(string format)
		{
			return UnityString.Format("({0}, {1}, {2}, {3})", new object[]
			{
				this.x.ToString(format),
				this.y.ToString(format),
				this.z.ToString(format),
				this.w.ToString(format)
			});
		}

		/// <summary>
		///   <para>Returns the angle in degrees between two rotations a and b.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		// Token: 0x06000536 RID: 1334 RVA: 0x0001153C File Offset: 0x0000F73C
		public static float Angle(Quaternion a, Quaternion b)
		{
			float num = Quaternion.Dot(a, b);
			return Mathf.Acos(Mathf.Min(Mathf.Abs(num), 1f)) * 2f * 57.29578f;
		}

		/// <summary>
		///   <para>Returns the euler angle representation of the rotation.</para>
		/// </summary>
		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x00003B07 File Offset: 0x00001D07
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x00003B1E File Offset: 0x00001D1E
		public Vector3 eulerAngles
		{
			get
			{
				return Quaternion.Internal_ToEulerRad(this) * 57.29578f;
			}
			set
			{
				this = Quaternion.Internal_FromEulerRad(value * 0.017453292f);
			}
		}

		/// <summary>
		///   <para>Returns a rotation that rotates z degrees around the z axis, x degrees around the x axis, and y degrees around the y axis (in that order).</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		// Token: 0x06000539 RID: 1337 RVA: 0x00003B36 File Offset: 0x00001D36
		public static Quaternion Euler(float x, float y, float z)
		{
			return Quaternion.Internal_FromEulerRad(new Vector3(x, y, z) * 0.017453292f);
		}

		/// <summary>
		///   <para>Returns a rotation that rotates z degrees around the z axis, x degrees around the x axis, and y degrees around the y axis (in that order).</para>
		/// </summary>
		/// <param name="euler"></param>
		// Token: 0x0600053A RID: 1338 RVA: 0x00003B4F File Offset: 0x00001D4F
		public static Quaternion Euler(Vector3 euler)
		{
			return Quaternion.Internal_FromEulerRad(euler * 0.017453292f);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00003B61 File Offset: 0x00001D61
		private static Vector3 Internal_ToEulerRad(Quaternion rotation)
		{
			return Quaternion.INTERNAL_CALL_Internal_ToEulerRad(ref rotation);
		}

		// Token: 0x0600053C RID: 1340
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Vector3 INTERNAL_CALL_Internal_ToEulerRad(ref Quaternion rotation);

		// Token: 0x0600053D RID: 1341 RVA: 0x00003B6A File Offset: 0x00001D6A
		private static Quaternion Internal_FromEulerRad(Vector3 euler)
		{
			return Quaternion.INTERNAL_CALL_Internal_FromEulerRad(ref euler);
		}

		// Token: 0x0600053E RID: 1342
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Quaternion INTERNAL_CALL_Internal_FromEulerRad(ref Vector3 euler);

		// Token: 0x0600053F RID: 1343 RVA: 0x00003B73 File Offset: 0x00001D73
		private static void Internal_ToAxisAngleRad(Quaternion q, out Vector3 axis, out float angle)
		{
			Quaternion.INTERNAL_CALL_Internal_ToAxisAngleRad(ref q, out axis, out angle);
		}

		// Token: 0x06000540 RID: 1344
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_ToAxisAngleRad(ref Quaternion q, out Vector3 axis, out float angle);

		// Token: 0x06000541 RID: 1345 RVA: 0x00003B7E File Offset: 0x00001D7E
		[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
		public static Quaternion EulerRotation(float x, float y, float z)
		{
			return Quaternion.Internal_FromEulerRad(new Vector3(x, y, z));
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00003B8D File Offset: 0x00001D8D
		[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
		public static Quaternion EulerRotation(Vector3 euler)
		{
			return Quaternion.Internal_FromEulerRad(euler);
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00003B95 File Offset: 0x00001D95
		[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
		public void SetEulerRotation(float x, float y, float z)
		{
			this = Quaternion.Internal_FromEulerRad(new Vector3(x, y, z));
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00003BAA File Offset: 0x00001DAA
		[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
		public void SetEulerRotation(Vector3 euler)
		{
			this = Quaternion.Internal_FromEulerRad(euler);
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00003BB8 File Offset: 0x00001DB8
		[Obsolete("Use Quaternion.eulerAngles instead. This function was deprecated because it uses radians instead of degrees")]
		public Vector3 ToEuler()
		{
			return Quaternion.Internal_ToEulerRad(this);
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00003B7E File Offset: 0x00001D7E
		[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
		public static Quaternion EulerAngles(float x, float y, float z)
		{
			return Quaternion.Internal_FromEulerRad(new Vector3(x, y, z));
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00003B8D File Offset: 0x00001D8D
		[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
		public static Quaternion EulerAngles(Vector3 euler)
		{
			return Quaternion.Internal_FromEulerRad(euler);
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00003BC5 File Offset: 0x00001DC5
		[Obsolete("Use Quaternion.ToAngleAxis instead. This function was deprecated because it uses radians instead of degrees")]
		public void ToAxisAngle(out Vector3 axis, out float angle)
		{
			Quaternion.Internal_ToAxisAngleRad(this, out axis, out angle);
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00003BD4 File Offset: 0x00001DD4
		[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
		public void SetEulerAngles(float x, float y, float z)
		{
			this.SetEulerRotation(new Vector3(x, y, z));
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00003BE4 File Offset: 0x00001DE4
		[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
		public void SetEulerAngles(Vector3 euler)
		{
			this = Quaternion.EulerRotation(euler);
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00003BF2 File Offset: 0x00001DF2
		[Obsolete("Use Quaternion.eulerAngles instead. This function was deprecated because it uses radians instead of degrees")]
		public static Vector3 ToEulerAngles(Quaternion rotation)
		{
			return Quaternion.Internal_ToEulerRad(rotation);
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00003BB8 File Offset: 0x00001DB8
		[Obsolete("Use Quaternion.eulerAngles instead. This function was deprecated because it uses radians instead of degrees")]
		public Vector3 ToEulerAngles()
		{
			return Quaternion.Internal_ToEulerRad(this);
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00003BFA File Offset: 0x00001DFA
		[Obsolete("Use Quaternion.AngleAxis instead. This function was deprecated because it uses radians instead of degrees")]
		public static Quaternion AxisAngle(Vector3 axis, float angle)
		{
			return Quaternion.INTERNAL_CALL_AxisAngle(ref axis, angle);
		}

		// Token: 0x0600054E RID: 1358
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Quaternion INTERNAL_CALL_AxisAngle(ref Vector3 axis, float angle);

		// Token: 0x0600054F RID: 1359 RVA: 0x00003C04 File Offset: 0x00001E04
		[Obsolete("Use Quaternion.AngleAxis instead. This function was deprecated because it uses radians instead of degrees")]
		public void SetAxisAngle(Vector3 axis, float angle)
		{
			this = Quaternion.AxisAngle(axis, angle);
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00003C13 File Offset: 0x00001E13
		public override int GetHashCode()
		{
			return this.x.GetHashCode() ^ (this.y.GetHashCode() << 2) ^ (this.z.GetHashCode() >> 2) ^ (this.w.GetHashCode() >> 1);
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00011574 File Offset: 0x0000F774
		public override bool Equals(object other)
		{
			if (!(other is Quaternion))
			{
				return false;
			}
			Quaternion quaternion = (Quaternion)other;
			return this.x.Equals(quaternion.x) && this.y.Equals(quaternion.y) && this.z.Equals(quaternion.z) && this.w.Equals(quaternion.w);
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x000115F0 File Offset: 0x0000F7F0
		public static Quaternion operator *(Quaternion lhs, Quaternion rhs)
		{
			return new Quaternion(lhs.w * rhs.x + lhs.x * rhs.w + lhs.y * rhs.z - lhs.z * rhs.y, lhs.w * rhs.y + lhs.y * rhs.w + lhs.z * rhs.x - lhs.x * rhs.z, lhs.w * rhs.z + lhs.z * rhs.w + lhs.x * rhs.y - lhs.y * rhs.x, lhs.w * rhs.w - lhs.x * rhs.x - lhs.y * rhs.y - lhs.z * rhs.z);
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00011700 File Offset: 0x0000F900
		public static Vector3 operator *(Quaternion rotation, Vector3 point)
		{
			float num = rotation.x * 2f;
			float num2 = rotation.y * 2f;
			float num3 = rotation.z * 2f;
			float num4 = rotation.x * num;
			float num5 = rotation.y * num2;
			float num6 = rotation.z * num3;
			float num7 = rotation.x * num2;
			float num8 = rotation.x * num3;
			float num9 = rotation.y * num3;
			float num10 = rotation.w * num;
			float num11 = rotation.w * num2;
			float num12 = rotation.w * num3;
			Vector3 vector;
			vector.x = (1f - (num5 + num6)) * point.x + (num7 - num12) * point.y + (num8 + num11) * point.z;
			vector.y = (num7 + num12) * point.x + (1f - (num4 + num6)) * point.y + (num9 - num10) * point.z;
			vector.z = (num8 - num11) * point.x + (num9 + num10) * point.y + (1f - (num4 + num5)) * point.z;
			return vector;
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00003C4A File Offset: 0x00001E4A
		public static bool operator ==(Quaternion lhs, Quaternion rhs)
		{
			return Quaternion.Dot(lhs, rhs) > 0.999999f;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00003C5A File Offset: 0x00001E5A
		public static bool operator !=(Quaternion lhs, Quaternion rhs)
		{
			return Quaternion.Dot(lhs, rhs) <= 0.999999f;
		}

		// Token: 0x040000DB RID: 219
		public const float kEpsilon = 1E-06f;

		/// <summary>
		///   <para>X component of the Quaternion. Don't modify this directly unless you know quaternions inside out.</para>
		/// </summary>
		// Token: 0x040000DC RID: 220
		public float x;

		/// <summary>
		///   <para>Y component of the Quaternion. Don't modify this directly unless you know quaternions inside out.</para>
		/// </summary>
		// Token: 0x040000DD RID: 221
		public float y;

		/// <summary>
		///   <para>Z component of the Quaternion. Don't modify this directly unless you know quaternions inside out.</para>
		/// </summary>
		// Token: 0x040000DE RID: 222
		public float z;

		/// <summary>
		///   <para>W component of the Quaternion. Don't modify this directly unless you know quaternions inside out.</para>
		/// </summary>
		// Token: 0x040000DF RID: 223
		public float w;
	}
}
