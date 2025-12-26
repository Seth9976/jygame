using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>A standard 4x4 transformation matrix.</para>
	/// </summary>
	// Token: 0x0200005C RID: 92
	public struct Matrix4x4
	{
		// Token: 0x1700016C RID: 364
		public float this[int row, int column]
		{
			get
			{
				return this[row + column * 4];
			}
			set
			{
				this[row + column * 4] = value;
			}
		}

		// Token: 0x1700016D RID: 365
		public float this[int index]
		{
			get
			{
				switch (index)
				{
				case 0:
					return this.m00;
				case 1:
					return this.m10;
				case 2:
					return this.m20;
				case 3:
					return this.m30;
				case 4:
					return this.m01;
				case 5:
					return this.m11;
				case 6:
					return this.m21;
				case 7:
					return this.m31;
				case 8:
					return this.m02;
				case 9:
					return this.m12;
				case 10:
					return this.m22;
				case 11:
					return this.m32;
				case 12:
					return this.m03;
				case 13:
					return this.m13;
				case 14:
					return this.m23;
				case 15:
					return this.m33;
				default:
					throw new IndexOutOfRangeException("Invalid matrix index!");
				}
			}
			set
			{
				switch (index)
				{
				case 0:
					this.m00 = value;
					break;
				case 1:
					this.m10 = value;
					break;
				case 2:
					this.m20 = value;
					break;
				case 3:
					this.m30 = value;
					break;
				case 4:
					this.m01 = value;
					break;
				case 5:
					this.m11 = value;
					break;
				case 6:
					this.m21 = value;
					break;
				case 7:
					this.m31 = value;
					break;
				case 8:
					this.m02 = value;
					break;
				case 9:
					this.m12 = value;
					break;
				case 10:
					this.m22 = value;
					break;
				case 11:
					this.m32 = value;
					break;
				case 12:
					this.m03 = value;
					break;
				case 13:
					this.m13 = value;
					break;
				case 14:
					this.m23 = value;
					break;
				case 15:
					this.m33 = value;
					break;
				default:
					throw new IndexOutOfRangeException("Invalid matrix index!");
				}
			}
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00011F84 File Offset: 0x00010184
		public override int GetHashCode()
		{
			return this.GetColumn(0).GetHashCode() ^ (this.GetColumn(1).GetHashCode() << 2) ^ (this.GetColumn(2).GetHashCode() >> 2) ^ (this.GetColumn(3).GetHashCode() >> 1);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00011FD8 File Offset: 0x000101D8
		public override bool Equals(object other)
		{
			if (!(other is Matrix4x4))
			{
				return false;
			}
			Matrix4x4 matrix4x = (Matrix4x4)other;
			return this.GetColumn(0).Equals(matrix4x.GetColumn(0)) && this.GetColumn(1).Equals(matrix4x.GetColumn(1)) && this.GetColumn(2).Equals(matrix4x.GetColumn(2)) && this.GetColumn(3).Equals(matrix4x.GetColumn(3));
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00003F57 File Offset: 0x00002157
		public static Matrix4x4 Inverse(Matrix4x4 m)
		{
			return Matrix4x4.INTERNAL_CALL_Inverse(ref m);
		}

		// Token: 0x0600058E RID: 1422
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Matrix4x4 INTERNAL_CALL_Inverse(ref Matrix4x4 m);

		// Token: 0x0600058F RID: 1423 RVA: 0x00003F60 File Offset: 0x00002160
		public static Matrix4x4 Transpose(Matrix4x4 m)
		{
			return Matrix4x4.INTERNAL_CALL_Transpose(ref m);
		}

		// Token: 0x06000590 RID: 1424
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Matrix4x4 INTERNAL_CALL_Transpose(ref Matrix4x4 m);

		// Token: 0x06000591 RID: 1425 RVA: 0x00003F69 File Offset: 0x00002169
		internal static bool Invert(Matrix4x4 inMatrix, out Matrix4x4 dest)
		{
			return Matrix4x4.INTERNAL_CALL_Invert(ref inMatrix, out dest);
		}

		// Token: 0x06000592 RID: 1426
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Invert(ref Matrix4x4 inMatrix, out Matrix4x4 dest);

		/// <summary>
		///   <para>The inverse of this matrix (Read Only).</para>
		/// </summary>
		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x00003F73 File Offset: 0x00002173
		public Matrix4x4 inverse
		{
			get
			{
				return Matrix4x4.Inverse(this);
			}
		}

		/// <summary>
		///   <para>Returns the transpose of this matrix (Read Only).</para>
		/// </summary>
		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x00003F80 File Offset: 0x00002180
		public Matrix4x4 transpose
		{
			get
			{
				return Matrix4x4.Transpose(this);
			}
		}

		/// <summary>
		///   <para>Is this the identity matrix?</para>
		/// </summary>
		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000595 RID: 1429
		public extern bool isIdentity
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Get a column of the matrix.</para>
		/// </summary>
		/// <param name="i"></param>
		// Token: 0x06000596 RID: 1430 RVA: 0x00003F8D File Offset: 0x0000218D
		public Vector4 GetColumn(int i)
		{
			return new Vector4(this[0, i], this[1, i], this[2, i], this[3, i]);
		}

		/// <summary>
		///   <para>Returns a row of the matrix.</para>
		/// </summary>
		/// <param name="i"></param>
		// Token: 0x06000597 RID: 1431 RVA: 0x00003FB4 File Offset: 0x000021B4
		public Vector4 GetRow(int i)
		{
			return new Vector4(this[i, 0], this[i, 1], this[i, 2], this[i, 3]);
		}

		/// <summary>
		///   <para>Sets a column of the matrix.</para>
		/// </summary>
		/// <param name="i"></param>
		/// <param name="v"></param>
		// Token: 0x06000598 RID: 1432 RVA: 0x00003FDB File Offset: 0x000021DB
		public void SetColumn(int i, Vector4 v)
		{
			this[0, i] = v.x;
			this[1, i] = v.y;
			this[2, i] = v.z;
			this[3, i] = v.w;
		}

		/// <summary>
		///   <para>Sets a row of the matrix.</para>
		/// </summary>
		/// <param name="i"></param>
		/// <param name="v"></param>
		// Token: 0x06000599 RID: 1433 RVA: 0x00004019 File Offset: 0x00002219
		public void SetRow(int i, Vector4 v)
		{
			this[i, 0] = v.x;
			this[i, 1] = v.y;
			this[i, 2] = v.z;
			this[i, 3] = v.w;
		}

		/// <summary>
		///   <para>Transforms a position by this matrix (generic).</para>
		/// </summary>
		/// <param name="v"></param>
		// Token: 0x0600059A RID: 1434 RVA: 0x0001207C File Offset: 0x0001027C
		public Vector3 MultiplyPoint(Vector3 v)
		{
			Vector3 vector;
			vector.x = this.m00 * v.x + this.m01 * v.y + this.m02 * v.z + this.m03;
			vector.y = this.m10 * v.x + this.m11 * v.y + this.m12 * v.z + this.m13;
			vector.z = this.m20 * v.x + this.m21 * v.y + this.m22 * v.z + this.m23;
			float num = this.m30 * v.x + this.m31 * v.y + this.m32 * v.z + this.m33;
			num = 1f / num;
			vector.x *= num;
			vector.y *= num;
			vector.z *= num;
			return vector;
		}

		/// <summary>
		///   <para>Transforms a position by this matrix (fast).</para>
		/// </summary>
		/// <param name="v"></param>
		// Token: 0x0600059B RID: 1435 RVA: 0x000121A4 File Offset: 0x000103A4
		public Vector3 MultiplyPoint3x4(Vector3 v)
		{
			Vector3 vector;
			vector.x = this.m00 * v.x + this.m01 * v.y + this.m02 * v.z + this.m03;
			vector.y = this.m10 * v.x + this.m11 * v.y + this.m12 * v.z + this.m13;
			vector.z = this.m20 * v.x + this.m21 * v.y + this.m22 * v.z + this.m23;
			return vector;
		}

		/// <summary>
		///   <para>Transforms a direction by this matrix.</para>
		/// </summary>
		/// <param name="v"></param>
		// Token: 0x0600059C RID: 1436 RVA: 0x00012260 File Offset: 0x00010460
		public Vector3 MultiplyVector(Vector3 v)
		{
			Vector3 vector;
			vector.x = this.m00 * v.x + this.m01 * v.y + this.m02 * v.z;
			vector.y = this.m10 * v.x + this.m11 * v.y + this.m12 * v.z;
			vector.z = this.m20 * v.x + this.m21 * v.y + this.m22 * v.z;
			return vector;
		}

		/// <summary>
		///   <para>Creates a scaling matrix.</para>
		/// </summary>
		/// <param name="v"></param>
		// Token: 0x0600059D RID: 1437 RVA: 0x00012308 File Offset: 0x00010508
		public static Matrix4x4 Scale(Vector3 v)
		{
			return new Matrix4x4
			{
				m00 = v.x,
				m01 = 0f,
				m02 = 0f,
				m03 = 0f,
				m10 = 0f,
				m11 = v.y,
				m12 = 0f,
				m13 = 0f,
				m20 = 0f,
				m21 = 0f,
				m22 = v.z,
				m23 = 0f,
				m30 = 0f,
				m31 = 0f,
				m32 = 0f,
				m33 = 1f
			};
		}

		/// <summary>
		///   <para>Returns a matrix with all elements set to zero (Read Only).</para>
		/// </summary>
		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x000123E4 File Offset: 0x000105E4
		public static Matrix4x4 zero
		{
			get
			{
				return new Matrix4x4
				{
					m00 = 0f,
					m01 = 0f,
					m02 = 0f,
					m03 = 0f,
					m10 = 0f,
					m11 = 0f,
					m12 = 0f,
					m13 = 0f,
					m20 = 0f,
					m21 = 0f,
					m22 = 0f,
					m23 = 0f,
					m30 = 0f,
					m31 = 0f,
					m32 = 0f,
					m33 = 0f
				};
			}
		}

		/// <summary>
		///   <para>Returns the identity matrix (Read Only).</para>
		/// </summary>
		// Token: 0x17000172 RID: 370
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x000124BC File Offset: 0x000106BC
		public static Matrix4x4 identity
		{
			get
			{
				return new Matrix4x4
				{
					m00 = 1f,
					m01 = 0f,
					m02 = 0f,
					m03 = 0f,
					m10 = 0f,
					m11 = 1f,
					m12 = 0f,
					m13 = 0f,
					m20 = 0f,
					m21 = 0f,
					m22 = 1f,
					m23 = 0f,
					m30 = 0f,
					m31 = 0f,
					m32 = 0f,
					m33 = 1f
				};
			}
		}

		/// <summary>
		///   <para>Sets this matrix to a translation, rotation and scaling matrix.</para>
		/// </summary>
		/// <param name="pos"></param>
		/// <param name="q"></param>
		/// <param name="s"></param>
		// Token: 0x060005A0 RID: 1440 RVA: 0x00004057 File Offset: 0x00002257
		public void SetTRS(Vector3 pos, Quaternion q, Vector3 s)
		{
			this = Matrix4x4.TRS(pos, q, s);
		}

		/// <summary>
		///   <para>Creates a translation, rotation and scaling matrix.</para>
		/// </summary>
		/// <param name="pos"></param>
		/// <param name="q"></param>
		/// <param name="s"></param>
		// Token: 0x060005A1 RID: 1441 RVA: 0x00004067 File Offset: 0x00002267
		public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s)
		{
			return Matrix4x4.INTERNAL_CALL_TRS(ref pos, ref q, ref s);
		}

		// Token: 0x060005A2 RID: 1442
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Matrix4x4 INTERNAL_CALL_TRS(ref Vector3 pos, ref Quaternion q, ref Vector3 s);

		/// <summary>
		///   <para>Returns a nicely formatted string for this matrix.</para>
		/// </summary>
		/// <param name="format"></param>
		// Token: 0x060005A3 RID: 1443 RVA: 0x00012594 File Offset: 0x00010794
		public override string ToString()
		{
			return UnityString.Format("{0:F5}\t{1:F5}\t{2:F5}\t{3:F5}\n{4:F5}\t{5:F5}\t{6:F5}\t{7:F5}\n{8:F5}\t{9:F5}\t{10:F5}\t{11:F5}\n{12:F5}\t{13:F5}\t{14:F5}\t{15:F5}\n", new object[]
			{
				this.m00, this.m01, this.m02, this.m03, this.m10, this.m11, this.m12, this.m13, this.m20, this.m21,
				this.m22, this.m23, this.m30, this.m31, this.m32, this.m33
			});
		}

		/// <summary>
		///   <para>Returns a nicely formatted string for this matrix.</para>
		/// </summary>
		/// <param name="format"></param>
		// Token: 0x060005A4 RID: 1444 RVA: 0x0001269C File Offset: 0x0001089C
		public string ToString(string format)
		{
			return UnityString.Format("{0}\t{1}\t{2}\t{3}\n{4}\t{5}\t{6}\t{7}\n{8}\t{9}\t{10}\t{11}\n{12}\t{13}\t{14}\t{15}\n", new object[]
			{
				this.m00.ToString(format),
				this.m01.ToString(format),
				this.m02.ToString(format),
				this.m03.ToString(format),
				this.m10.ToString(format),
				this.m11.ToString(format),
				this.m12.ToString(format),
				this.m13.ToString(format),
				this.m20.ToString(format),
				this.m21.ToString(format),
				this.m22.ToString(format),
				this.m23.ToString(format),
				this.m30.ToString(format),
				this.m31.ToString(format),
				this.m32.ToString(format),
				this.m33.ToString(format)
			});
		}

		/// <summary>
		///   <para>Creates an orthogonal projection matrix.</para>
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <param name="bottom"></param>
		/// <param name="top"></param>
		/// <param name="zNear"></param>
		/// <param name="zFar"></param>
		// Token: 0x060005A5 RID: 1445
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar);

		/// <summary>
		///   <para>Creates a perspective projection matrix.</para>
		/// </summary>
		/// <param name="fov"></param>
		/// <param name="aspect"></param>
		/// <param name="zNear"></param>
		/// <param name="zFar"></param>
		// Token: 0x060005A6 RID: 1446
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar);

		// Token: 0x060005A7 RID: 1447 RVA: 0x000127B4 File Offset: 0x000109B4
		public static Matrix4x4 operator *(Matrix4x4 lhs, Matrix4x4 rhs)
		{
			return new Matrix4x4
			{
				m00 = lhs.m00 * rhs.m00 + lhs.m01 * rhs.m10 + lhs.m02 * rhs.m20 + lhs.m03 * rhs.m30,
				m01 = lhs.m00 * rhs.m01 + lhs.m01 * rhs.m11 + lhs.m02 * rhs.m21 + lhs.m03 * rhs.m31,
				m02 = lhs.m00 * rhs.m02 + lhs.m01 * rhs.m12 + lhs.m02 * rhs.m22 + lhs.m03 * rhs.m32,
				m03 = lhs.m00 * rhs.m03 + lhs.m01 * rhs.m13 + lhs.m02 * rhs.m23 + lhs.m03 * rhs.m33,
				m10 = lhs.m10 * rhs.m00 + lhs.m11 * rhs.m10 + lhs.m12 * rhs.m20 + lhs.m13 * rhs.m30,
				m11 = lhs.m10 * rhs.m01 + lhs.m11 * rhs.m11 + lhs.m12 * rhs.m21 + lhs.m13 * rhs.m31,
				m12 = lhs.m10 * rhs.m02 + lhs.m11 * rhs.m12 + lhs.m12 * rhs.m22 + lhs.m13 * rhs.m32,
				m13 = lhs.m10 * rhs.m03 + lhs.m11 * rhs.m13 + lhs.m12 * rhs.m23 + lhs.m13 * rhs.m33,
				m20 = lhs.m20 * rhs.m00 + lhs.m21 * rhs.m10 + lhs.m22 * rhs.m20 + lhs.m23 * rhs.m30,
				m21 = lhs.m20 * rhs.m01 + lhs.m21 * rhs.m11 + lhs.m22 * rhs.m21 + lhs.m23 * rhs.m31,
				m22 = lhs.m20 * rhs.m02 + lhs.m21 * rhs.m12 + lhs.m22 * rhs.m22 + lhs.m23 * rhs.m32,
				m23 = lhs.m20 * rhs.m03 + lhs.m21 * rhs.m13 + lhs.m22 * rhs.m23 + lhs.m23 * rhs.m33,
				m30 = lhs.m30 * rhs.m00 + lhs.m31 * rhs.m10 + lhs.m32 * rhs.m20 + lhs.m33 * rhs.m30,
				m31 = lhs.m30 * rhs.m01 + lhs.m31 * rhs.m11 + lhs.m32 * rhs.m21 + lhs.m33 * rhs.m31,
				m32 = lhs.m30 * rhs.m02 + lhs.m31 * rhs.m12 + lhs.m32 * rhs.m22 + lhs.m33 * rhs.m32,
				m33 = lhs.m30 * rhs.m03 + lhs.m31 * rhs.m13 + lhs.m32 * rhs.m23 + lhs.m33 * rhs.m33
			};
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00012C2C File Offset: 0x00010E2C
		public static Vector4 operator *(Matrix4x4 lhs, Vector4 v)
		{
			Vector4 vector;
			vector.x = lhs.m00 * v.x + lhs.m01 * v.y + lhs.m02 * v.z + lhs.m03 * v.w;
			vector.y = lhs.m10 * v.x + lhs.m11 * v.y + lhs.m12 * v.z + lhs.m13 * v.w;
			vector.z = lhs.m20 * v.x + lhs.m21 * v.y + lhs.m22 * v.z + lhs.m23 * v.w;
			vector.w = lhs.m30 * v.x + lhs.m31 * v.y + lhs.m32 * v.z + lhs.m33 * v.w;
			return vector;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00012D54 File Offset: 0x00010F54
		public static bool operator ==(Matrix4x4 lhs, Matrix4x4 rhs)
		{
			return lhs.GetColumn(0) == rhs.GetColumn(0) && lhs.GetColumn(1) == rhs.GetColumn(1) && lhs.GetColumn(2) == rhs.GetColumn(2) && lhs.GetColumn(3) == rhs.GetColumn(3);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00004074 File Offset: 0x00002274
		public static bool operator !=(Matrix4x4 lhs, Matrix4x4 rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x040000E4 RID: 228
		public float m00;

		// Token: 0x040000E5 RID: 229
		public float m10;

		// Token: 0x040000E6 RID: 230
		public float m20;

		// Token: 0x040000E7 RID: 231
		public float m30;

		// Token: 0x040000E8 RID: 232
		public float m01;

		// Token: 0x040000E9 RID: 233
		public float m11;

		// Token: 0x040000EA RID: 234
		public float m21;

		// Token: 0x040000EB RID: 235
		public float m31;

		// Token: 0x040000EC RID: 236
		public float m02;

		// Token: 0x040000ED RID: 237
		public float m12;

		// Token: 0x040000EE RID: 238
		public float m22;

		// Token: 0x040000EF RID: 239
		public float m32;

		// Token: 0x040000F0 RID: 240
		public float m03;

		// Token: 0x040000F1 RID: 241
		public float m13;

		// Token: 0x040000F2 RID: 242
		public float m23;

		// Token: 0x040000F3 RID: 243
		public float m33;
	}
}
