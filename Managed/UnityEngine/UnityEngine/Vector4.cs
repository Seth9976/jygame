using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Representation of four-dimensional vectors.</para>
	/// </summary>
	// Token: 0x0200005E RID: 94
	public struct Vector4
	{
		/// <summary>
		///   <para>Creates a new vector with given x, y, z, w components.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		/// <param name="w"></param>
		// Token: 0x060005CF RID: 1487 RVA: 0x000042DA File Offset: 0x000024DA
		public Vector4(float x, float y, float z, float w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		/// <summary>
		///   <para>Creates a new vector with given x, y, z components and sets w to zero.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		// Token: 0x060005D0 RID: 1488 RVA: 0x000042F9 File Offset: 0x000024F9
		public Vector4(float x, float y, float z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = 0f;
		}

		/// <summary>
		///   <para>Creates a new vector with given x, y components and sets z and w to zero.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		// Token: 0x060005D1 RID: 1489 RVA: 0x0000431B File Offset: 0x0000251B
		public Vector4(float x, float y)
		{
			this.x = x;
			this.y = y;
			this.z = 0f;
			this.w = 0f;
		}

		// Token: 0x17000178 RID: 376
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
					throw new IndexOutOfRangeException("Invalid Vector4 index!");
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
					throw new IndexOutOfRangeException("Invalid Vector4 index!");
				}
			}
		}

		/// <summary>
		///   <para>Set x, y, z and w components of an existing Vector4.</para>
		/// </summary>
		/// <param name="new_x"></param>
		/// <param name="new_y"></param>
		/// <param name="new_z"></param>
		/// <param name="new_w"></param>
		// Token: 0x060005D4 RID: 1492 RVA: 0x000042DA File Offset: 0x000024DA
		public void Set(float new_x, float new_y, float new_z, float new_w)
		{
			this.x = new_x;
			this.y = new_y;
			this.z = new_z;
			this.w = new_w;
		}

		/// <summary>
		///   <para>Linearly interpolates between two vectors.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="t"></param>
		// Token: 0x060005D5 RID: 1493 RVA: 0x00013008 File Offset: 0x00011208
		public static Vector4 Lerp(Vector4 a, Vector4 b, float t)
		{
			t = Mathf.Clamp01(t);
			return new Vector4(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t, a.w + (b.w - a.w) * t);
		}

		/// <summary>
		///   <para>Linearly interpolates between two vectors.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="t"></param>
		// Token: 0x060005D6 RID: 1494 RVA: 0x00013088 File Offset: 0x00011288
		public static Vector4 LerpUnclamped(Vector4 a, Vector4 b, float t)
		{
			return new Vector4(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t, a.w + (b.w - a.w) * t);
		}

		/// <summary>
		///   <para>Moves a point current towards target.</para>
		/// </summary>
		/// <param name="current"></param>
		/// <param name="target"></param>
		/// <param name="maxDistanceDelta"></param>
		// Token: 0x060005D7 RID: 1495 RVA: 0x00013100 File Offset: 0x00011300
		public static Vector4 MoveTowards(Vector4 current, Vector4 target, float maxDistanceDelta)
		{
			Vector4 vector = target - current;
			float magnitude = vector.magnitude;
			if (magnitude <= maxDistanceDelta || magnitude == 0f)
			{
				return target;
			}
			return current + vector / magnitude * maxDistanceDelta;
		}

		/// <summary>
		///   <para>Multiplies two vectors component-wise.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		// Token: 0x060005D8 RID: 1496 RVA: 0x00013144 File Offset: 0x00011344
		public static Vector4 Scale(Vector4 a, Vector4 b)
		{
			return new Vector4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
		}

		/// <summary>
		///   <para>Multiplies every component of this vector by the same component of scale.</para>
		/// </summary>
		/// <param name="scale"></param>
		// Token: 0x060005D9 RID: 1497 RVA: 0x00013194 File Offset: 0x00011394
		public void Scale(Vector4 scale)
		{
			this.x *= scale.x;
			this.y *= scale.y;
			this.z *= scale.z;
			this.w *= scale.w;
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00004341 File Offset: 0x00002541
		public override int GetHashCode()
		{
			return this.x.GetHashCode() ^ (this.y.GetHashCode() << 2) ^ (this.z.GetHashCode() >> 2) ^ (this.w.GetHashCode() >> 1);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x000131F4 File Offset: 0x000113F4
		public override bool Equals(object other)
		{
			if (!(other is Vector4))
			{
				return false;
			}
			Vector4 vector = (Vector4)other;
			return this.x.Equals(vector.x) && this.y.Equals(vector.y) && this.z.Equals(vector.z) && this.w.Equals(vector.w);
		}

		/// <summary>
		///   <para></para>
		/// </summary>
		/// <param name="a"></param>
		// Token: 0x060005DC RID: 1500 RVA: 0x00013270 File Offset: 0x00011470
		public static Vector4 Normalize(Vector4 a)
		{
			float num = Vector4.Magnitude(a);
			if (num > 1E-05f)
			{
				return a / num;
			}
			return Vector4.zero;
		}

		/// <summary>
		///   <para>Makes this vector have a magnitude of 1.</para>
		/// </summary>
		// Token: 0x060005DD RID: 1501 RVA: 0x0001329C File Offset: 0x0001149C
		public void Normalize()
		{
			float num = Vector4.Magnitude(this);
			if (num > 1E-05f)
			{
				this /= num;
			}
			else
			{
				this = Vector4.zero;
			}
		}

		/// <summary>
		///   <para>Returns this vector with a magnitude of 1 (Read Only).</para>
		/// </summary>
		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x00004378 File Offset: 0x00002578
		public Vector4 normalized
		{
			get
			{
				return Vector4.Normalize(this);
			}
		}

		/// <summary>
		///   <para>Returns a nicely formatted string for this vector.</para>
		/// </summary>
		/// <param name="format"></param>
		// Token: 0x060005DF RID: 1503 RVA: 0x000132E4 File Offset: 0x000114E4
		public override string ToString()
		{
			return UnityString.Format("({0:F1}, {1:F1}, {2:F1}, {3:F1})", new object[] { this.x, this.y, this.z, this.w });
		}

		/// <summary>
		///   <para>Returns a nicely formatted string for this vector.</para>
		/// </summary>
		/// <param name="format"></param>
		// Token: 0x060005E0 RID: 1504 RVA: 0x0001333C File Offset: 0x0001153C
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
		///   <para>Dot Product of two vectors.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		// Token: 0x060005E1 RID: 1505 RVA: 0x00013398 File Offset: 0x00011598
		public static float Dot(Vector4 a, Vector4 b)
		{
			return a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w;
		}

		/// <summary>
		///   <para>Projects a vector onto another vector.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		// Token: 0x060005E2 RID: 1506 RVA: 0x00004385 File Offset: 0x00002585
		public static Vector4 Project(Vector4 a, Vector4 b)
		{
			return b * Vector4.Dot(a, b) / Vector4.Dot(b, b);
		}

		/// <summary>
		///   <para>Returns the distance between a and b.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		// Token: 0x060005E3 RID: 1507 RVA: 0x000043A0 File Offset: 0x000025A0
		public static float Distance(Vector4 a, Vector4 b)
		{
			return Vector4.Magnitude(a - b);
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x000043AE File Offset: 0x000025AE
		public static float Magnitude(Vector4 a)
		{
			return Mathf.Sqrt(Vector4.Dot(a, a));
		}

		/// <summary>
		///   <para>Returns the length of this vector (Read Only).</para>
		/// </summary>
		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x000043BC File Offset: 0x000025BC
		public float magnitude
		{
			get
			{
				return Mathf.Sqrt(Vector4.Dot(this, this));
			}
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x000043D4 File Offset: 0x000025D4
		public static float SqrMagnitude(Vector4 a)
		{
			return Vector4.Dot(a, a);
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x000043DD File Offset: 0x000025DD
		public float SqrMagnitude()
		{
			return Vector4.Dot(this, this);
		}

		/// <summary>
		///   <para>Returns the squared length of this vector (Read Only).</para>
		/// </summary>
		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x000043DD File Offset: 0x000025DD
		public float sqrMagnitude
		{
			get
			{
				return Vector4.Dot(this, this);
			}
		}

		/// <summary>
		///   <para>Returns a vector that is made from the smallest components of two vectors.</para>
		/// </summary>
		/// <param name="lhs"></param>
		/// <param name="rhs"></param>
		// Token: 0x060005E9 RID: 1513 RVA: 0x000133E4 File Offset: 0x000115E4
		public static Vector4 Min(Vector4 lhs, Vector4 rhs)
		{
			return new Vector4(Mathf.Min(lhs.x, rhs.x), Mathf.Min(lhs.y, rhs.y), Mathf.Min(lhs.z, rhs.z), Mathf.Min(lhs.w, rhs.w));
		}

		/// <summary>
		///   <para>Returns a vector that is made from the largest components of two vectors.</para>
		/// </summary>
		/// <param name="lhs"></param>
		/// <param name="rhs"></param>
		// Token: 0x060005EA RID: 1514 RVA: 0x00013444 File Offset: 0x00011644
		public static Vector4 Max(Vector4 lhs, Vector4 rhs)
		{
			return new Vector4(Mathf.Max(lhs.x, rhs.x), Mathf.Max(lhs.y, rhs.y), Mathf.Max(lhs.z, rhs.z), Mathf.Max(lhs.w, rhs.w));
		}

		/// <summary>
		///   <para>Shorthand for writing Vector4(0,0,0,0).</para>
		/// </summary>
		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x000043F0 File Offset: 0x000025F0
		public static Vector4 zero
		{
			get
			{
				return new Vector4(0f, 0f, 0f, 0f);
			}
		}

		/// <summary>
		///   <para>Shorthand for writing Vector4(1,1,1,1).</para>
		/// </summary>
		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x0000440B File Offset: 0x0000260B
		public static Vector4 one
		{
			get
			{
				return new Vector4(1f, 1f, 1f, 1f);
			}
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x000134A4 File Offset: 0x000116A4
		public static Vector4 operator +(Vector4 a, Vector4 b)
		{
			return new Vector4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x000134F4 File Offset: 0x000116F4
		public static Vector4 operator -(Vector4 a, Vector4 b)
		{
			return new Vector4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00004426 File Offset: 0x00002626
		public static Vector4 operator -(Vector4 a)
		{
			return new Vector4(-a.x, -a.y, -a.z, -a.w);
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x0000444D File Offset: 0x0000264D
		public static Vector4 operator *(Vector4 a, float d)
		{
			return new Vector4(a.x * d, a.y * d, a.z * d, a.w * d);
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00004478 File Offset: 0x00002678
		public static Vector4 operator *(float d, Vector4 a)
		{
			return new Vector4(a.x * d, a.y * d, a.z * d, a.w * d);
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x000044A3 File Offset: 0x000026A3
		public static Vector4 operator /(Vector4 a, float d)
		{
			return new Vector4(a.x / d, a.y / d, a.z / d, a.w / d);
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x000044CE File Offset: 0x000026CE
		public static bool operator ==(Vector4 lhs, Vector4 rhs)
		{
			return Vector4.SqrMagnitude(lhs - rhs) < 9.9999994E-11f;
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x000044E3 File Offset: 0x000026E3
		public static bool operator !=(Vector4 lhs, Vector4 rhs)
		{
			return Vector4.SqrMagnitude(lhs - rhs) >= 9.9999994E-11f;
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x000044FB File Offset: 0x000026FB
		public static implicit operator Vector4(Vector3 v)
		{
			return new Vector4(v.x, v.y, v.z, 0f);
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x0000451C File Offset: 0x0000271C
		public static implicit operator Vector3(Vector4 v)
		{
			return new Vector3(v.x, v.y, v.z);
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00004538 File Offset: 0x00002738
		public static implicit operator Vector4(Vector2 v)
		{
			return new Vector4(v.x, v.y, 0f, 0f);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00004557 File Offset: 0x00002757
		public static implicit operator Vector2(Vector4 v)
		{
			return new Vector2(v.x, v.y);
		}

		// Token: 0x040000F6 RID: 246
		public const float kEpsilon = 1E-05f;

		/// <summary>
		///   <para>X component of the vector.</para>
		/// </summary>
		// Token: 0x040000F7 RID: 247
		public float x;

		/// <summary>
		///   <para>Y component of the vector.</para>
		/// </summary>
		// Token: 0x040000F8 RID: 248
		public float y;

		/// <summary>
		///   <para>Z component of the vector.</para>
		/// </summary>
		// Token: 0x040000F9 RID: 249
		public float z;

		/// <summary>
		///   <para>W component of the vector.</para>
		/// </summary>
		// Token: 0x040000FA RID: 250
		public float w;
	}
}
