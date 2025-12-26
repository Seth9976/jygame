using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Representation of RGBA colors in 32 bit format.</para>
	/// </summary>
	// Token: 0x02000059 RID: 89
	[IL2CPPStructAlignment(Align = 4)]
	public struct Color32
	{
		/// <summary>
		///   <para>Constructs a new Color with given r, g, b, a components.</para>
		/// </summary>
		/// <param name="r"></param>
		/// <param name="g"></param>
		/// <param name="b"></param>
		/// <param name="a"></param>
		// Token: 0x06000511 RID: 1297 RVA: 0x000039DF File Offset: 0x00001BDF
		public Color32(byte r, byte g, byte b, byte a)
		{
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = a;
		}

		/// <summary>
		///   <para>Returns a nicely formatted string of this color.</para>
		/// </summary>
		/// <param name="format"></param>
		// Token: 0x06000512 RID: 1298 RVA: 0x000110F0 File Offset: 0x0000F2F0
		public override string ToString()
		{
			return UnityString.Format("RGBA({0}, {1}, {2}, {3})", new object[] { this.r, this.g, this.b, this.a });
		}

		/// <summary>
		///   <para>Returns a nicely formatted string of this color.</para>
		/// </summary>
		/// <param name="format"></param>
		// Token: 0x06000513 RID: 1299 RVA: 0x00011148 File Offset: 0x0000F348
		public string ToString(string format)
		{
			return UnityString.Format("RGBA({0}, {1}, {2}, {3})", new object[]
			{
				this.r.ToString(format),
				this.g.ToString(format),
				this.b.ToString(format),
				this.a.ToString(format)
			});
		}

		/// <summary>
		///   <para>Linearly interpolates between colors a and b by t.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="t"></param>
		// Token: 0x06000514 RID: 1300 RVA: 0x000111A4 File Offset: 0x0000F3A4
		public static Color32 Lerp(Color32 a, Color32 b, float t)
		{
			t = Mathf.Clamp01(t);
			return new Color32((byte)((float)a.r + (float)(b.r - a.r) * t), (byte)((float)a.g + (float)(b.g - a.g) * t), (byte)((float)a.b + (float)(b.b - a.b) * t), (byte)((float)a.a + (float)(b.a - a.a) * t));
		}

		/// <summary>
		///   <para>Linearly interpolates between colors a and b by t.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="t"></param>
		// Token: 0x06000515 RID: 1301 RVA: 0x00011230 File Offset: 0x0000F430
		public static Color32 LerpUnclamped(Color32 a, Color32 b, float t)
		{
			return new Color32((byte)((float)a.r + (float)(b.r - a.r) * t), (byte)((float)a.g + (float)(b.g - a.g) * t), (byte)((float)a.b + (float)(b.b - a.b) * t), (byte)((float)a.a + (float)(b.a - a.a) * t));
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x000112B4 File Offset: 0x0000F4B4
		public static implicit operator Color32(Color c)
		{
			return new Color32((byte)(Mathf.Clamp01(c.r) * 255f), (byte)(Mathf.Clamp01(c.g) * 255f), (byte)(Mathf.Clamp01(c.b) * 255f), (byte)(Mathf.Clamp01(c.a) * 255f));
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x000039FE File Offset: 0x00001BFE
		public static implicit operator Color(Color32 c)
		{
			return new Color((float)c.r / 255f, (float)c.g / 255f, (float)c.b / 255f, (float)c.a / 255f);
		}

		/// <summary>
		///   <para>Red component of the color.</para>
		/// </summary>
		// Token: 0x040000D7 RID: 215
		public byte r;

		/// <summary>
		///   <para>Green component of the color.</para>
		/// </summary>
		// Token: 0x040000D8 RID: 216
		public byte g;

		/// <summary>
		///   <para>Blue component of the color.</para>
		/// </summary>
		// Token: 0x040000D9 RID: 217
		public byte b;

		/// <summary>
		///   <para>Alpha component of the color.</para>
		/// </summary>
		// Token: 0x040000DA RID: 218
		public byte a;
	}
}
