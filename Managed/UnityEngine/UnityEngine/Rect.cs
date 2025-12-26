using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>A 2D Rectangle defined by x, y position and width, height.</para>
	/// </summary>
	// Token: 0x0200005B RID: 91
	public struct Rect
	{
		/// <summary>
		///   <para>Creates a new rectangle.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="width"></param>
		/// <param name="height"></param>
		// Token: 0x06000556 RID: 1366 RVA: 0x00003C6D File Offset: 0x00001E6D
		public Rect(float x, float y, float width, float height)
		{
			this.m_XMin = x;
			this.m_YMin = y;
			this.m_Width = width;
			this.m_Height = height;
		}

		/// <summary>
		///   <para>Creates a rectangle given a size and position.</para>
		/// </summary>
		/// <param name="position">The position of the top-left corner.</param>
		/// <param name="size">The width and height.</param>
		// Token: 0x06000557 RID: 1367 RVA: 0x00003C8C File Offset: 0x00001E8C
		public Rect(Vector2 position, Vector2 size)
		{
			this.m_XMin = position.x;
			this.m_YMin = position.y;
			this.m_Width = size.x;
			this.m_Height = size.y;
		}

		/// <summary>
		///   <para></para>
		/// </summary>
		/// <param name="source"></param>
		// Token: 0x06000558 RID: 1368 RVA: 0x00003CC2 File Offset: 0x00001EC2
		public Rect(Rect source)
		{
			this.m_XMin = source.m_XMin;
			this.m_YMin = source.m_YMin;
			this.m_Width = source.m_Width;
			this.m_Height = source.m_Height;
		}

		/// <summary>
		///   <para>Creates a rectangle from min/max coordinate values.</para>
		/// </summary>
		/// <param name="xmin"></param>
		/// <param name="ymin"></param>
		/// <param name="xmax"></param>
		/// <param name="ymax"></param>
		// Token: 0x06000559 RID: 1369 RVA: 0x00003CF8 File Offset: 0x00001EF8
		public static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax)
		{
			return new Rect(xmin, ymin, xmax - xmin, ymax - ymin);
		}

		/// <summary>
		///   <para>Set components of an existing Rect.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="width"></param>
		/// <param name="height"></param>
		// Token: 0x0600055A RID: 1370 RVA: 0x00003C6D File Offset: 0x00001E6D
		public void Set(float x, float y, float width, float height)
		{
			this.m_XMin = x;
			this.m_YMin = y;
			this.m_Width = width;
			this.m_Height = height;
		}

		/// <summary>
		///   <para>Left coordinate of the rectangle.</para>
		/// </summary>
		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x00003D07 File Offset: 0x00001F07
		// (set) Token: 0x0600055C RID: 1372 RVA: 0x00003D0F File Offset: 0x00001F0F
		public float x
		{
			get
			{
				return this.m_XMin;
			}
			set
			{
				this.m_XMin = value;
			}
		}

		/// <summary>
		///   <para>Top coordinate of the rectangle.</para>
		/// </summary>
		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x00003D18 File Offset: 0x00001F18
		// (set) Token: 0x0600055E RID: 1374 RVA: 0x00003D20 File Offset: 0x00001F20
		public float y
		{
			get
			{
				return this.m_YMin;
			}
			set
			{
				this.m_YMin = value;
			}
		}

		/// <summary>
		///   <para>The top left coordinates of the rectangle.</para>
		/// </summary>
		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x00003D29 File Offset: 0x00001F29
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x00003D3C File Offset: 0x00001F3C
		public Vector2 position
		{
			get
			{
				return new Vector2(this.m_XMin, this.m_YMin);
			}
			set
			{
				this.m_XMin = value.x;
				this.m_YMin = value.y;
			}
		}

		/// <summary>
		///   <para>Center coordinate of the rectangle.</para>
		/// </summary>
		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x00003D58 File Offset: 0x00001F58
		// (set) Token: 0x06000562 RID: 1378 RVA: 0x00003D85 File Offset: 0x00001F85
		public Vector2 center
		{
			get
			{
				return new Vector2(this.x + this.m_Width / 2f, this.y + this.m_Height / 2f);
			}
			set
			{
				this.m_XMin = value.x - this.m_Width / 2f;
				this.m_YMin = value.y - this.m_Height / 2f;
			}
		}

		/// <summary>
		///   <para>Lower left corner of the rectangle.</para>
		/// </summary>
		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x00003DBB File Offset: 0x00001FBB
		// (set) Token: 0x06000564 RID: 1380 RVA: 0x00003DCE File Offset: 0x00001FCE
		public Vector2 min
		{
			get
			{
				return new Vector2(this.xMin, this.yMin);
			}
			set
			{
				this.xMin = value.x;
				this.yMin = value.y;
			}
		}

		/// <summary>
		///   <para>Upper right corner of the rectangle.</para>
		/// </summary>
		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x00003DEA File Offset: 0x00001FEA
		// (set) Token: 0x06000566 RID: 1382 RVA: 0x00003DFD File Offset: 0x00001FFD
		public Vector2 max
		{
			get
			{
				return new Vector2(this.xMax, this.yMax);
			}
			set
			{
				this.xMax = value.x;
				this.yMax = value.y;
			}
		}

		/// <summary>
		///   <para>Width of the rectangle.</para>
		/// </summary>
		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x00003E19 File Offset: 0x00002019
		// (set) Token: 0x06000568 RID: 1384 RVA: 0x00003E21 File Offset: 0x00002021
		public float width
		{
			get
			{
				return this.m_Width;
			}
			set
			{
				this.m_Width = value;
			}
		}

		/// <summary>
		///   <para>Height of the rectangle.</para>
		/// </summary>
		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x00003E2A File Offset: 0x0000202A
		// (set) Token: 0x0600056A RID: 1386 RVA: 0x00003E32 File Offset: 0x00002032
		public float height
		{
			get
			{
				return this.m_Height;
			}
			set
			{
				this.m_Height = value;
			}
		}

		/// <summary>
		///   <para>The size of the rectangle.</para>
		/// </summary>
		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x00003E3B File Offset: 0x0000203B
		// (set) Token: 0x0600056C RID: 1388 RVA: 0x00003E4E File Offset: 0x0000204E
		public Vector2 size
		{
			get
			{
				return new Vector2(this.m_Width, this.m_Height);
			}
			set
			{
				this.m_Width = value.x;
				this.m_Height = value.y;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x00003D07 File Offset: 0x00001F07
		[Obsolete("use xMin")]
		public float left
		{
			get
			{
				return this.m_XMin;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x00003E6A File Offset: 0x0000206A
		[Obsolete("use xMax")]
		public float right
		{
			get
			{
				return this.m_XMin + this.m_Width;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x00003D18 File Offset: 0x00001F18
		[Obsolete("use yMin")]
		public float top
		{
			get
			{
				return this.m_YMin;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x00003E79 File Offset: 0x00002079
		[Obsolete("use yMax")]
		public float bottom
		{
			get
			{
				return this.m_YMin + this.m_Height;
			}
		}

		/// <summary>
		///   <para>Left coordinate of the rectangle.</para>
		/// </summary>
		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x00003D07 File Offset: 0x00001F07
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x0001183C File Offset: 0x0000FA3C
		public float xMin
		{
			get
			{
				return this.m_XMin;
			}
			set
			{
				float xMax = this.xMax;
				this.m_XMin = value;
				this.m_Width = xMax - this.m_XMin;
			}
		}

		/// <summary>
		///   <para>Top coordinate of the rectangle.</para>
		/// </summary>
		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x00003D18 File Offset: 0x00001F18
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x00011868 File Offset: 0x0000FA68
		public float yMin
		{
			get
			{
				return this.m_YMin;
			}
			set
			{
				float yMax = this.yMax;
				this.m_YMin = value;
				this.m_Height = yMax - this.m_YMin;
			}
		}

		/// <summary>
		///   <para>Right coordinate of the rectangle.</para>
		/// </summary>
		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x00003E88 File Offset: 0x00002088
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x00003E97 File Offset: 0x00002097
		public float xMax
		{
			get
			{
				return this.m_Width + this.m_XMin;
			}
			set
			{
				this.m_Width = value - this.m_XMin;
			}
		}

		/// <summary>
		///   <para>Bottom coordinate of the rectangle.</para>
		/// </summary>
		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x00003EA7 File Offset: 0x000020A7
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x00003EB6 File Offset: 0x000020B6
		public float yMax
		{
			get
			{
				return this.m_Height + this.m_YMin;
			}
			set
			{
				this.m_Height = value - this.m_YMin;
			}
		}

		/// <summary>
		///   <para>Returns a nicely formatted string for this Rect.</para>
		/// </summary>
		/// <param name="format"></param>
		// Token: 0x06000579 RID: 1401 RVA: 0x00011894 File Offset: 0x0000FA94
		public override string ToString()
		{
			return UnityString.Format("(x:{0:F2}, y:{1:F2}, width:{2:F2}, height:{3:F2})", new object[] { this.x, this.y, this.width, this.height });
		}

		/// <summary>
		///   <para>Returns a nicely formatted string for this Rect.</para>
		/// </summary>
		/// <param name="format"></param>
		// Token: 0x0600057A RID: 1402 RVA: 0x000118EC File Offset: 0x0000FAEC
		public string ToString(string format)
		{
			return UnityString.Format("(x:{0}, y:{1}, width:{2}, height:{3})", new object[]
			{
				this.x.ToString(format),
				this.y.ToString(format),
				this.width.ToString(format),
				this.height.ToString(format)
			});
		}

		/// <summary>
		///   <para>Returns true if the x and y components of point is a point inside this rectangle. If allowInverse is present and true, the width and height of the Rect are allowed to take negative values (ie, the min value is greater than the max), and the test will still work.</para>
		/// </summary>
		/// <param name="point">Point to test.</param>
		/// <param name="allowInverse">Does the test allow the Rect's width and height to be negative?</param>
		// Token: 0x0600057B RID: 1403 RVA: 0x00011954 File Offset: 0x0000FB54
		public bool Contains(Vector2 point)
		{
			return point.x >= this.xMin && point.x < this.xMax && point.y >= this.yMin && point.y < this.yMax;
		}

		/// <summary>
		///   <para>Returns true if the x and y components of point is a point inside this rectangle. If allowInverse is present and true, the width and height of the Rect are allowed to take negative values (ie, the min value is greater than the max), and the test will still work.</para>
		/// </summary>
		/// <param name="point">Point to test.</param>
		/// <param name="allowInverse">Does the test allow the Rect's width and height to be negative?</param>
		// Token: 0x0600057C RID: 1404 RVA: 0x000119AC File Offset: 0x0000FBAC
		public bool Contains(Vector3 point)
		{
			return point.x >= this.xMin && point.x < this.xMax && point.y >= this.yMin && point.y < this.yMax;
		}

		/// <summary>
		///   <para>Returns true if the x and y components of point is a point inside this rectangle. If allowInverse is present and true, the width and height of the Rect are allowed to take negative values (ie, the min value is greater than the max), and the test will still work.</para>
		/// </summary>
		/// <param name="point">Point to test.</param>
		/// <param name="allowInverse">Does the test allow the Rect's width and height to be negative?</param>
		// Token: 0x0600057D RID: 1405 RVA: 0x00011A04 File Offset: 0x0000FC04
		public bool Contains(Vector3 point, bool allowInverse)
		{
			if (!allowInverse)
			{
				return this.Contains(point);
			}
			bool flag = false;
			if ((this.width < 0f && point.x <= this.xMin && point.x > this.xMax) || (this.width >= 0f && point.x >= this.xMin && point.x < this.xMax))
			{
				flag = true;
			}
			return flag && ((this.height < 0f && point.y <= this.yMin && point.y > this.yMax) || (this.height >= 0f && point.y >= this.yMin && point.y < this.yMax));
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00011AFC File Offset: 0x0000FCFC
		private static Rect OrderMinMax(Rect rect)
		{
			if (rect.xMin > rect.xMax)
			{
				float xMin = rect.xMin;
				rect.xMin = rect.xMax;
				rect.xMax = xMin;
			}
			if (rect.yMin > rect.yMax)
			{
				float yMin = rect.yMin;
				rect.yMin = rect.yMax;
				rect.yMax = yMin;
			}
			return rect;
		}

		/// <summary>
		///   <para>Returns true if the other rectangle overlaps this one. If allowInverse is present and true, the widths and heights of the Rects are allowed to take negative values (ie, the min value is greater than the max), and the test will still work.</para>
		/// </summary>
		/// <param name="other">Other rectangle to test overlapping with.</param>
		/// <param name="allowInverse">Does the test allow the Rects' widths and heights to be negative?</param>
		// Token: 0x0600057F RID: 1407 RVA: 0x00011B6C File Offset: 0x0000FD6C
		public bool Overlaps(Rect other)
		{
			return other.xMax > this.xMin && other.xMin < this.xMax && other.yMax > this.yMin && other.yMin < this.yMax;
		}

		/// <summary>
		///   <para>Returns true if the other rectangle overlaps this one. If allowInverse is present and true, the widths and heights of the Rects are allowed to take negative values (ie, the min value is greater than the max), and the test will still work.</para>
		/// </summary>
		/// <param name="other">Other rectangle to test overlapping with.</param>
		/// <param name="allowInverse">Does the test allow the Rects' widths and heights to be negative?</param>
		// Token: 0x06000580 RID: 1408 RVA: 0x00011BC4 File Offset: 0x0000FDC4
		public bool Overlaps(Rect other, bool allowInverse)
		{
			Rect rect = this;
			if (allowInverse)
			{
				rect = Rect.OrderMinMax(rect);
				other = Rect.OrderMinMax(other);
			}
			return rect.Overlaps(other);
		}

		/// <summary>
		///   <para>Returns a point inside a rectangle, given normalized coordinates.</para>
		/// </summary>
		/// <param name="rectangle">Rectangle to get a point inside.</param>
		/// <param name="normalizedRectCoordinates">Normalized coordinates to get a point for.</param>
		// Token: 0x06000581 RID: 1409 RVA: 0x00003EC6 File Offset: 0x000020C6
		public static Vector2 NormalizedToPoint(Rect rectangle, Vector2 normalizedRectCoordinates)
		{
			return new Vector2(Mathf.Lerp(rectangle.x, rectangle.xMax, normalizedRectCoordinates.x), Mathf.Lerp(rectangle.y, rectangle.yMax, normalizedRectCoordinates.y));
		}

		/// <summary>
		///   <para>Returns the normalized coordinates cooresponding the the point.</para>
		/// </summary>
		/// <param name="rectangle">Rectangle to get normalized coordinates inside.</param>
		/// <param name="point">A point inside the rectangle to get normalized coordinates for.</param>
		// Token: 0x06000582 RID: 1410 RVA: 0x00003F01 File Offset: 0x00002101
		public static Vector2 PointToNormalized(Rect rectangle, Vector2 point)
		{
			return new Vector2(Mathf.InverseLerp(rectangle.x, rectangle.xMax, point.x), Mathf.InverseLerp(rectangle.y, rectangle.yMax, point.y));
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00011BF8 File Offset: 0x0000FDF8
		public override int GetHashCode()
		{
			return this.x.GetHashCode() ^ (this.width.GetHashCode() << 2) ^ (this.y.GetHashCode() >> 2) ^ (this.height.GetHashCode() >> 1);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00011C48 File Offset: 0x0000FE48
		public override bool Equals(object other)
		{
			if (!(other is Rect))
			{
				return false;
			}
			Rect rect = (Rect)other;
			return this.x.Equals(rect.x) && this.y.Equals(rect.y) && this.width.Equals(rect.width) && this.height.Equals(rect.height);
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00011CD0 File Offset: 0x0000FED0
		public static bool operator !=(Rect lhs, Rect rhs)
		{
			return lhs.x != rhs.x || lhs.y != rhs.y || lhs.width != rhs.width || lhs.height != rhs.height;
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00011D2C File Offset: 0x0000FF2C
		public static bool operator ==(Rect lhs, Rect rhs)
		{
			return lhs.x == rhs.x && lhs.y == rhs.y && lhs.width == rhs.width && lhs.height == rhs.height;
		}

		// Token: 0x040000E0 RID: 224
		private float m_XMin;

		// Token: 0x040000E1 RID: 225
		private float m_YMin;

		// Token: 0x040000E2 RID: 226
		private float m_Width;

		// Token: 0x040000E3 RID: 227
		private float m_Height;
	}
}
