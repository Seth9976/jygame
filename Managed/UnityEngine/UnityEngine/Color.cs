using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Representation of RGBA colors.</para>
	/// </summary>
	// Token: 0x02000058 RID: 88
	public struct Color
	{
		/// <summary>
		///   <para>Constructs a new Color with given r,g,b,a components.</para>
		/// </summary>
		/// <param name="r">Red component.</param>
		/// <param name="g">Green component.</param>
		/// <param name="b">Blue component.</param>
		/// <param name="a">Alpha component.</param>
		// Token: 0x060004EB RID: 1259 RVA: 0x0000368B File Offset: 0x0000188B
		public Color(float r, float g, float b, float a)
		{
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = a;
		}

		/// <summary>
		///   <para>Constructs a new Color with given r,g,b components and sets a to 1.</para>
		/// </summary>
		/// <param name="r">Red component.</param>
		/// <param name="g">Green component.</param>
		/// <param name="b">Blue component.</param>
		// Token: 0x060004EC RID: 1260 RVA: 0x000036AA File Offset: 0x000018AA
		public Color(float r, float g, float b)
		{
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = 1f;
		}

		/// <summary>
		///   <para>Returns a nicely formatted string of this color.</para>
		/// </summary>
		/// <param name="format"></param>
		// Token: 0x060004ED RID: 1261 RVA: 0x00010D00 File Offset: 0x0000EF00
		public override string ToString()
		{
			return UnityString.Format("RGBA({0:F3}, {1:F3}, {2:F3}, {3:F3})", new object[] { this.r, this.g, this.b, this.a });
		}

		/// <summary>
		///   <para>Returns a nicely formatted string of this color.</para>
		/// </summary>
		/// <param name="format"></param>
		// Token: 0x060004EE RID: 1262 RVA: 0x00010D58 File Offset: 0x0000EF58
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

		// Token: 0x060004EF RID: 1263 RVA: 0x00010DB4 File Offset: 0x0000EFB4
		public override int GetHashCode()
		{
			return this.GetHashCode();
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00010DD4 File Offset: 0x0000EFD4
		public override bool Equals(object other)
		{
			if (!(other is Color))
			{
				return false;
			}
			Color color = (Color)other;
			return this.r.Equals(color.r) && this.g.Equals(color.g) && this.b.Equals(color.b) && this.a.Equals(color.a);
		}

		/// <summary>
		///   <para>Linearly interpolates between colors a and b by t.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="t"></param>
		// Token: 0x060004F1 RID: 1265 RVA: 0x00010E50 File Offset: 0x0000F050
		public static Color Lerp(Color a, Color b, float t)
		{
			t = Mathf.Clamp01(t);
			return new Color(a.r + (b.r - a.r) * t, a.g + (b.g - a.g) * t, a.b + (b.b - a.b) * t, a.a + (b.a - a.a) * t);
		}

		/// <summary>
		///   <para>Linearly interpolates between colors a and b by t.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="t"></param>
		// Token: 0x060004F2 RID: 1266 RVA: 0x00010ED0 File Offset: 0x0000F0D0
		public static Color LerpUnclamped(Color a, Color b, float t)
		{
			return new Color(a.r + (b.r - a.r) * t, a.g + (b.g - a.g) * t, a.b + (b.b - a.b) * t, a.a + (b.a - a.a) * t);
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x000036CC File Offset: 0x000018CC
		internal Color RGBMultiplied(float multiplier)
		{
			return new Color(this.r * multiplier, this.g * multiplier, this.b * multiplier, this.a);
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x000036F1 File Offset: 0x000018F1
		internal Color AlphaMultiplied(float multiplier)
		{
			return new Color(this.r, this.g, this.b, this.a * multiplier);
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00003712 File Offset: 0x00001912
		internal Color RGBMultiplied(Color multiplier)
		{
			return new Color(this.r * multiplier.r, this.g * multiplier.g, this.b * multiplier.b, this.a);
		}

		/// <summary>
		///   <para>Solid red. RGBA is (1, 0, 0, 1).</para>
		/// </summary>
		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x00003749 File Offset: 0x00001949
		public static Color red
		{
			get
			{
				return new Color(1f, 0f, 0f, 1f);
			}
		}

		/// <summary>
		///   <para>Solid green. RGBA is (0, 1, 0, 1).</para>
		/// </summary>
		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x00003764 File Offset: 0x00001964
		public static Color green
		{
			get
			{
				return new Color(0f, 1f, 0f, 1f);
			}
		}

		/// <summary>
		///   <para>Solid blue. RGBA is (0, 0, 1, 1).</para>
		/// </summary>
		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x0000377F File Offset: 0x0000197F
		public static Color blue
		{
			get
			{
				return new Color(0f, 0f, 1f, 1f);
			}
		}

		/// <summary>
		///   <para>Solid white. RGBA is (1, 1, 1, 1).</para>
		/// </summary>
		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x0000379A File Offset: 0x0000199A
		public static Color white
		{
			get
			{
				return new Color(1f, 1f, 1f, 1f);
			}
		}

		/// <summary>
		///   <para>Solid black. RGBA is (0, 0, 0, 1).</para>
		/// </summary>
		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x000037B5 File Offset: 0x000019B5
		public static Color black
		{
			get
			{
				return new Color(0f, 0f, 0f, 1f);
			}
		}

		/// <summary>
		///   <para>Yellow. RGBA is (1, 0.92, 0.016, 1), but the color is nice to look at!</para>
		/// </summary>
		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x000037D0 File Offset: 0x000019D0
		public static Color yellow
		{
			get
			{
				return new Color(1f, 0.92156863f, 0.015686275f, 1f);
			}
		}

		/// <summary>
		///   <para>Cyan. RGBA is (0, 1, 1, 1).</para>
		/// </summary>
		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x000037EB File Offset: 0x000019EB
		public static Color cyan
		{
			get
			{
				return new Color(0f, 1f, 1f, 1f);
			}
		}

		/// <summary>
		///   <para>Magenta. RGBA is (1, 0, 1, 1).</para>
		/// </summary>
		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x00003806 File Offset: 0x00001A06
		public static Color magenta
		{
			get
			{
				return new Color(1f, 0f, 1f, 1f);
			}
		}

		/// <summary>
		///   <para>Gray. RGBA is (0.5, 0.5, 0.5, 1).</para>
		/// </summary>
		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x00003821 File Offset: 0x00001A21
		public static Color gray
		{
			get
			{
				return new Color(0.5f, 0.5f, 0.5f, 1f);
			}
		}

		/// <summary>
		///   <para>English spelling for gray. RGBA is the same (0.5, 0.5, 0.5, 1).</para>
		/// </summary>
		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x00003821 File Offset: 0x00001A21
		public static Color grey
		{
			get
			{
				return new Color(0.5f, 0.5f, 0.5f, 1f);
			}
		}

		/// <summary>
		///   <para>Completely transparent. RGBA is (0, 0, 0, 0).</para>
		/// </summary>
		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x0000383C File Offset: 0x00001A3C
		public static Color clear
		{
			get
			{
				return new Color(0f, 0f, 0f, 0f);
			}
		}

		/// <summary>
		///   <para>The grayscale value of the color. (Read Only)</para>
		/// </summary>
		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x00003857 File Offset: 0x00001A57
		public float grayscale
		{
			get
			{
				return 0.299f * this.r + 0.587f * this.g + 0.114f * this.b;
			}
		}

		/// <summary>
		///   <para>A version of the color that has had the inverse gamma curve applied.</para>
		/// </summary>
		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x0000387F File Offset: 0x00001A7F
		public Color linear
		{
			get
			{
				return new Color(Mathf.GammaToLinearSpace(this.r), Mathf.GammaToLinearSpace(this.g), Mathf.GammaToLinearSpace(this.b), this.a);
			}
		}

		/// <summary>
		///   <para>A version of the color that has had the gamma curve applied.</para>
		/// </summary>
		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x000038AD File Offset: 0x00001AAD
		public Color gamma
		{
			get
			{
				return new Color(Mathf.LinearToGammaSpace(this.r), Mathf.LinearToGammaSpace(this.g), Mathf.LinearToGammaSpace(this.b), this.a);
			}
		}

		/// <summary>
		///   <para>Returns the maximum color component value: Max(r,g,b).</para>
		/// </summary>
		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x000038DB File Offset: 0x00001ADB
		public float maxColorComponent
		{
			get
			{
				return Mathf.Max(Mathf.Max(this.r, this.g), this.b);
			}
		}

		// Token: 0x17000157 RID: 343
		public float this[int index]
		{
			get
			{
				switch (index)
				{
				case 0:
					return this.r;
				case 1:
					return this.g;
				case 2:
					return this.b;
				case 3:
					return this.a;
				default:
					throw new IndexOutOfRangeException("Invalid Vector3 index!");
				}
			}
			set
			{
				switch (index)
				{
				case 0:
					this.r = value;
					break;
				case 1:
					this.g = value;
					break;
				case 2:
					this.b = value;
					break;
				case 3:
					this.a = value;
					break;
				default:
					throw new IndexOutOfRangeException("Invalid Vector3 index!");
				}
			}
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00011000 File Offset: 0x0000F200
		public static Color operator +(Color a, Color b)
		{
			return new Color(a.r + b.r, a.g + b.g, a.b + b.b, a.a + b.a);
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00011050 File Offset: 0x0000F250
		public static Color operator -(Color a, Color b)
		{
			return new Color(a.r - b.r, a.g - b.g, a.b - b.b, a.a - b.a);
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x000110A0 File Offset: 0x0000F2A0
		public static Color operator *(Color a, Color b)
		{
			return new Color(a.r * b.r, a.g * b.g, a.b * b.b, a.a * b.a);
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x000038F9 File Offset: 0x00001AF9
		public static Color operator *(Color a, float b)
		{
			return new Color(a.r * b, a.g * b, a.b * b, a.a * b);
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00003924 File Offset: 0x00001B24
		public static Color operator *(float b, Color a)
		{
			return new Color(a.r * b, a.g * b, a.b * b, a.a * b);
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0000394F File Offset: 0x00001B4F
		public static Color operator /(Color a, float b)
		{
			return new Color(a.r / b, a.g / b, a.b / b, a.a / b);
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0000397A File Offset: 0x00001B7A
		public static bool operator ==(Color lhs, Color rhs)
		{
			return lhs == rhs;
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0000398D File Offset: 0x00001B8D
		public static bool operator !=(Color lhs, Color rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00003999 File Offset: 0x00001B99
		public static implicit operator Vector4(Color c)
		{
			return new Vector4(c.r, c.g, c.b, c.a);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x000039BC File Offset: 0x00001BBC
		public static implicit operator Color(Vector4 v)
		{
			return new Color(v.x, v.y, v.z, v.w);
		}

		/// <summary>
		///   <para>Red component of the color.</para>
		/// </summary>
		// Token: 0x040000D3 RID: 211
		public float r;

		/// <summary>
		///   <para>Green component of the color.</para>
		/// </summary>
		// Token: 0x040000D4 RID: 212
		public float g;

		/// <summary>
		///   <para>Blue component of the color.</para>
		/// </summary>
		// Token: 0x040000D5 RID: 213
		public float b;

		/// <summary>
		///   <para>Alpha component of the color.</para>
		/// </summary>
		// Token: 0x040000D6 RID: 214
		public float a;
	}
}
