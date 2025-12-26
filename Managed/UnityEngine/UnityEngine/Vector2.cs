using System;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Representation of 2D vectors and points.</para>
	/// </summary>
	// Token: 0x02000056 RID: 86
	public struct Vector2
	{
		/// <summary>
		///   <para>Constructs a new vector with given x, y components.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		// Token: 0x0600047D RID: 1149 RVA: 0x00002D39 File Offset: 0x00000F39
		public Vector2(float x, float y)
		{
			this.x = x;
			this.y = y;
		}

		// Token: 0x17000131 RID: 305
		public float this[int index]
		{
			get
			{
				if (index == 0)
				{
					return this.x;
				}
				if (index != 1)
				{
					throw new IndexOutOfRangeException("Invalid Vector2 index!");
				}
				return this.y;
			}
			set
			{
				if (index != 0)
				{
					if (index != 1)
					{
						throw new IndexOutOfRangeException("Invalid Vector2 index!");
					}
					this.y = value;
				}
				else
				{
					this.x = value;
				}
			}
		}

		/// <summary>
		///   <para>Set x and y components of an existing Vector2.</para>
		/// </summary>
		/// <param name="new_x"></param>
		/// <param name="new_y"></param>
		// Token: 0x06000480 RID: 1152 RVA: 0x00002D39 File Offset: 0x00000F39
		public void Set(float new_x, float new_y)
		{
			this.x = new_x;
			this.y = new_y;
		}

		/// <summary>
		///   <para>Linearly interpolates between vectors a and b by t.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="t"></param>
		// Token: 0x06000481 RID: 1153 RVA: 0x00010570 File Offset: 0x0000E770
		public static Vector2 Lerp(Vector2 a, Vector2 b, float t)
		{
			t = Mathf.Clamp01(t);
			return new Vector2(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t);
		}

		/// <summary>
		///   <para>Linearly interpolates between vectors a and b by t.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="t"></param>
		// Token: 0x06000482 RID: 1154 RVA: 0x00002D49 File Offset: 0x00000F49
		public static Vector2 LerpUnclamped(Vector2 a, Vector2 b, float t)
		{
			return new Vector2(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t);
		}

		/// <summary>
		///   <para>Moves a point current towards target.</para>
		/// </summary>
		/// <param name="current"></param>
		/// <param name="target"></param>
		/// <param name="maxDistanceDelta"></param>
		// Token: 0x06000483 RID: 1155 RVA: 0x000105BC File Offset: 0x0000E7BC
		public static Vector2 MoveTowards(Vector2 current, Vector2 target, float maxDistanceDelta)
		{
			Vector2 vector = target - current;
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
		// Token: 0x06000484 RID: 1156 RVA: 0x00002D82 File Offset: 0x00000F82
		public static Vector2 Scale(Vector2 a, Vector2 b)
		{
			return new Vector2(a.x * b.x, a.y * b.y);
		}

		/// <summary>
		///   <para>Multiplies every component of this vector by the same component of scale.</para>
		/// </summary>
		/// <param name="scale"></param>
		// Token: 0x06000485 RID: 1157 RVA: 0x00002DA7 File Offset: 0x00000FA7
		public void Scale(Vector2 scale)
		{
			this.x *= scale.x;
			this.y *= scale.y;
		}

		/// <summary>
		///   <para>Makes this vector have a magnitude of 1.</para>
		/// </summary>
		// Token: 0x06000486 RID: 1158 RVA: 0x00010600 File Offset: 0x0000E800
		public void Normalize()
		{
			float magnitude = this.magnitude;
			if (magnitude > 1E-05f)
			{
				this /= magnitude;
			}
			else
			{
				this = Vector2.zero;
			}
		}

		/// <summary>
		///   <para>Returns this vector with a magnitude of 1 (Read Only).</para>
		/// </summary>
		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x00010644 File Offset: 0x0000E844
		public Vector2 normalized
		{
			get
			{
				Vector2 vector = new Vector2(this.x, this.y);
				vector.Normalize();
				return vector;
			}
		}

		/// <summary>
		///   <para>Returns a nicely formatted string for this vector.</para>
		/// </summary>
		/// <param name="format"></param>
		// Token: 0x06000488 RID: 1160 RVA: 0x00002DD1 File Offset: 0x00000FD1
		public override string ToString()
		{
			return UnityString.Format("({0:F1}, {1:F1})", new object[] { this.x, this.y });
		}

		/// <summary>
		///   <para>Returns a nicely formatted string for this vector.</para>
		/// </summary>
		/// <param name="format"></param>
		// Token: 0x06000489 RID: 1161 RVA: 0x00002DFF File Offset: 0x00000FFF
		public string ToString(string format)
		{
			return UnityString.Format("({0}, {1})", new object[]
			{
				this.x.ToString(format),
				this.y.ToString(format)
			});
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00002E2F File Offset: 0x0000102F
		public override int GetHashCode()
		{
			return this.x.GetHashCode() ^ (this.y.GetHashCode() << 2);
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0001066C File Offset: 0x0000E86C
		public override bool Equals(object other)
		{
			if (!(other is Vector2))
			{
				return false;
			}
			Vector2 vector = (Vector2)other;
			return this.x.Equals(vector.x) && this.y.Equals(vector.y);
		}

		/// <summary>
		///   <para>Reflects a vector off the vector defined by a normal.</para>
		/// </summary>
		/// <param name="inDirection"></param>
		/// <param name="inNormal"></param>
		// Token: 0x0600048C RID: 1164 RVA: 0x00002E4A File Offset: 0x0000104A
		public static Vector2 Reflect(Vector2 inDirection, Vector2 inNormal)
		{
			return -2f * Vector2.Dot(inNormal, inDirection) * inNormal + inDirection;
		}

		/// <summary>
		///   <para>Dot Product of two vectors.</para>
		/// </summary>
		/// <param name="lhs"></param>
		/// <param name="rhs"></param>
		// Token: 0x0600048D RID: 1165 RVA: 0x00002E65 File Offset: 0x00001065
		public static float Dot(Vector2 lhs, Vector2 rhs)
		{
			return lhs.x * rhs.x + lhs.y * rhs.y;
		}

		/// <summary>
		///   <para>Returns the length of this vector (Read Only).</para>
		/// </summary>
		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x00002E86 File Offset: 0x00001086
		public float magnitude
		{
			get
			{
				return Mathf.Sqrt(this.x * this.x + this.y * this.y);
			}
		}

		/// <summary>
		///   <para>Returns the squared length of this vector (Read Only).</para>
		/// </summary>
		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x00002EA8 File Offset: 0x000010A8
		public float sqrMagnitude
		{
			get
			{
				return this.x * this.x + this.y * this.y;
			}
		}

		/// <summary>
		///   <para>Returns the angle in degrees between from and to.</para>
		/// </summary>
		/// <param name="from"></param>
		/// <param name="to"></param>
		// Token: 0x06000490 RID: 1168 RVA: 0x00002EC5 File Offset: 0x000010C5
		public static float Angle(Vector2 from, Vector2 to)
		{
			return Mathf.Acos(Mathf.Clamp(Vector2.Dot(from.normalized, to.normalized), -1f, 1f)) * 57.29578f;
		}

		/// <summary>
		///   <para>Returns the distance between a and b.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		// Token: 0x06000491 RID: 1169 RVA: 0x000106BC File Offset: 0x0000E8BC
		public static float Distance(Vector2 a, Vector2 b)
		{
			return (a - b).magnitude;
		}

		/// <summary>
		///   <para>Returns a copy of vector with its magnitude clamped to maxLength.</para>
		/// </summary>
		/// <param name="vector"></param>
		/// <param name="maxLength"></param>
		// Token: 0x06000492 RID: 1170 RVA: 0x00002EF4 File Offset: 0x000010F4
		public static Vector2 ClampMagnitude(Vector2 vector, float maxLength)
		{
			if (vector.sqrMagnitude > maxLength * maxLength)
			{
				return vector.normalized * maxLength;
			}
			return vector;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00002F14 File Offset: 0x00001114
		public static float SqrMagnitude(Vector2 a)
		{
			return a.x * a.x + a.y * a.y;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00002EA8 File Offset: 0x000010A8
		public float SqrMagnitude()
		{
			return this.x * this.x + this.y * this.y;
		}

		/// <summary>
		///   <para>Returns a vector that is made from the smallest components of two vectors.</para>
		/// </summary>
		/// <param name="lhs"></param>
		/// <param name="rhs"></param>
		// Token: 0x06000495 RID: 1173 RVA: 0x00002F35 File Offset: 0x00001135
		public static Vector2 Min(Vector2 lhs, Vector2 rhs)
		{
			return new Vector2(Mathf.Min(lhs.x, rhs.x), Mathf.Min(lhs.y, rhs.y));
		}

		/// <summary>
		///   <para>Returns a vector that is made from the largest components of two vectors.</para>
		/// </summary>
		/// <param name="lhs"></param>
		/// <param name="rhs"></param>
		// Token: 0x06000496 RID: 1174 RVA: 0x00002F62 File Offset: 0x00001162
		public static Vector2 Max(Vector2 lhs, Vector2 rhs)
		{
			return new Vector2(Mathf.Max(lhs.x, rhs.x), Mathf.Max(lhs.y, rhs.y));
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x000106D8 File Offset: 0x0000E8D8
		[ExcludeFromDocs]
		public static Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, float smoothTime, float maxSpeed)
		{
			float deltaTime = Time.deltaTime;
			return Vector2.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x000106F8 File Offset: 0x0000E8F8
		[ExcludeFromDocs]
		public static Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, float smoothTime)
		{
			float deltaTime = Time.deltaTime;
			float positiveInfinity = float.PositiveInfinity;
			return Vector2.SmoothDamp(current, target, ref currentVelocity, smoothTime, positiveInfinity, deltaTime);
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0001071C File Offset: 0x0000E91C
		public static Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, float smoothTime, [DefaultValue("Mathf.Infinity")] float maxSpeed, [DefaultValue("Time.deltaTime")] float deltaTime)
		{
			smoothTime = Mathf.Max(0.0001f, smoothTime);
			float num = 2f / smoothTime;
			float num2 = num * deltaTime;
			float num3 = 1f / (1f + num2 + 0.48f * num2 * num2 + 0.235f * num2 * num2 * num2);
			Vector2 vector = current - target;
			Vector2 vector2 = target;
			float num4 = maxSpeed * smoothTime;
			vector = Vector2.ClampMagnitude(vector, num4);
			target = current - vector;
			Vector2 vector3 = (currentVelocity + num * vector) * deltaTime;
			currentVelocity = (currentVelocity - num * vector3) * num3;
			Vector2 vector4 = target + (vector + vector3) * num3;
			if (Vector2.Dot(vector2 - current, vector4 - vector2) > 0f)
			{
				vector4 = vector2;
				currentVelocity = (vector4 - vector2) / deltaTime;
			}
			return vector4;
		}

		/// <summary>
		///   <para>Shorthand for writing Vector2(0, 0).</para>
		/// </summary>
		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x00002F8F File Offset: 0x0000118F
		public static Vector2 zero
		{
			get
			{
				return new Vector2(0f, 0f);
			}
		}

		/// <summary>
		///   <para>Shorthand for writing Vector2(1, 1).</para>
		/// </summary>
		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x00002FA0 File Offset: 0x000011A0
		public static Vector2 one
		{
			get
			{
				return new Vector2(1f, 1f);
			}
		}

		/// <summary>
		///   <para>Shorthand for writing Vector2(0, 1).</para>
		/// </summary>
		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x00002FB1 File Offset: 0x000011B1
		public static Vector2 up
		{
			get
			{
				return new Vector2(0f, 1f);
			}
		}

		/// <summary>
		///   <para>Shorthand for writing Vector2(0, -1).</para>
		/// </summary>
		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x00002FC2 File Offset: 0x000011C2
		public static Vector2 down
		{
			get
			{
				return new Vector2(0f, -1f);
			}
		}

		/// <summary>
		///   <para>Shorthand for writing Vector2(-1, 0).</para>
		/// </summary>
		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x00002FD3 File Offset: 0x000011D3
		public static Vector2 left
		{
			get
			{
				return new Vector2(-1f, 0f);
			}
		}

		/// <summary>
		///   <para>Shorthand for writing Vector2(1, 0).</para>
		/// </summary>
		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00002FE4 File Offset: 0x000011E4
		public static Vector2 right
		{
			get
			{
				return new Vector2(1f, 0f);
			}
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00002FF5 File Offset: 0x000011F5
		public static Vector2 operator +(Vector2 a, Vector2 b)
		{
			return new Vector2(a.x + b.x, a.y + b.y);
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0000301A File Offset: 0x0000121A
		public static Vector2 operator -(Vector2 a, Vector2 b)
		{
			return new Vector2(a.x - b.x, a.y - b.y);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0000303F File Offset: 0x0000123F
		public static Vector2 operator -(Vector2 a)
		{
			return new Vector2(-a.x, -a.y);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00003056 File Offset: 0x00001256
		public static Vector2 operator *(Vector2 a, float d)
		{
			return new Vector2(a.x * d, a.y * d);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0000306F File Offset: 0x0000126F
		public static Vector2 operator *(float d, Vector2 a)
		{
			return new Vector2(a.x * d, a.y * d);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00003088 File Offset: 0x00001288
		public static Vector2 operator /(Vector2 a, float d)
		{
			return new Vector2(a.x / d, a.y / d);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x000030A1 File Offset: 0x000012A1
		public static bool operator ==(Vector2 lhs, Vector2 rhs)
		{
			return Vector2.SqrMagnitude(lhs - rhs) < 9.9999994E-11f;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x000030B6 File Offset: 0x000012B6
		public static bool operator !=(Vector2 lhs, Vector2 rhs)
		{
			return Vector2.SqrMagnitude(lhs - rhs) >= 9.9999994E-11f;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x000030CE File Offset: 0x000012CE
		public static implicit operator Vector2(Vector3 v)
		{
			return new Vector2(v.x, v.y);
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x000030E3 File Offset: 0x000012E3
		public static implicit operator Vector3(Vector2 v)
		{
			return new Vector3(v.x, v.y, 0f);
		}

		// Token: 0x040000CC RID: 204
		public const float kEpsilon = 1E-05f;

		/// <summary>
		///   <para>X component of the vector.</para>
		/// </summary>
		// Token: 0x040000CD RID: 205
		public float x;

		/// <summary>
		///   <para>Y component of the vector.</para>
		/// </summary>
		// Token: 0x040000CE RID: 206
		public float y;
	}
}
