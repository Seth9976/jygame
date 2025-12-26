using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Position, size, anchor and pivot information for a rectangle.</para>
	/// </summary>
	// Token: 0x02000078 RID: 120
	public sealed class RectTransform : Transform
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000734 RID: 1844 RVA: 0x00004E47 File Offset: 0x00003047
		// (remove) Token: 0x06000735 RID: 1845 RVA: 0x00004E5E File Offset: 0x0000305E
		public static event RectTransform.ReapplyDrivenProperties reapplyDrivenProperties;

		/// <summary>
		///   <para>The calculated rectangle in the local space of the Transform.</para>
		/// </summary>
		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x00013E9C File Offset: 0x0001209C
		public Rect rect
		{
			get
			{
				Rect rect;
				this.INTERNAL_get_rect(out rect);
				return rect;
			}
		}

		// Token: 0x06000737 RID: 1847
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_rect(out Rect value);

		/// <summary>
		///   <para>The normalized position in the parent RectTransform that the lower left corner is anchored to.</para>
		/// </summary>
		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x00013EB4 File Offset: 0x000120B4
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x00004E75 File Offset: 0x00003075
		public Vector2 anchorMin
		{
			get
			{
				Vector2 vector;
				this.INTERNAL_get_anchorMin(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_anchorMin(ref value);
			}
		}

		// Token: 0x0600073A RID: 1850
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_anchorMin(out Vector2 value);

		// Token: 0x0600073B RID: 1851
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_anchorMin(ref Vector2 value);

		/// <summary>
		///   <para>The normalized position in the parent RectTransform that the upper right corner is anchored to.</para>
		/// </summary>
		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x00013ECC File Offset: 0x000120CC
		// (set) Token: 0x0600073D RID: 1853 RVA: 0x00004E7F File Offset: 0x0000307F
		public Vector2 anchorMax
		{
			get
			{
				Vector2 vector;
				this.INTERNAL_get_anchorMax(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_anchorMax(ref value);
			}
		}

		// Token: 0x0600073E RID: 1854
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_anchorMax(out Vector2 value);

		// Token: 0x0600073F RID: 1855
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_anchorMax(ref Vector2 value);

		/// <summary>
		///   <para>The 3D position of the pivot of this RectTransform relative to the anchor reference point.</para>
		/// </summary>
		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x00013EE4 File Offset: 0x000120E4
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x00013F1C File Offset: 0x0001211C
		public Vector3 anchoredPosition3D
		{
			get
			{
				Vector2 anchoredPosition = this.anchoredPosition;
				return new Vector3(anchoredPosition.x, anchoredPosition.y, base.localPosition.z);
			}
			set
			{
				this.anchoredPosition = new Vector2(value.x, value.y);
				Vector3 localPosition = base.localPosition;
				localPosition.z = value.z;
				base.localPosition = localPosition;
			}
		}

		/// <summary>
		///   <para>The position of the pivot of this RectTransform relative to the anchor reference point.</para>
		/// </summary>
		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x00013F60 File Offset: 0x00012160
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x00004E89 File Offset: 0x00003089
		public Vector2 anchoredPosition
		{
			get
			{
				Vector2 vector;
				this.INTERNAL_get_anchoredPosition(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_anchoredPosition(ref value);
			}
		}

		// Token: 0x06000744 RID: 1860
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_anchoredPosition(out Vector2 value);

		// Token: 0x06000745 RID: 1861
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_anchoredPosition(ref Vector2 value);

		/// <summary>
		///   <para>The size of this RectTransform relative to the distances between the anchors.</para>
		/// </summary>
		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x00013F78 File Offset: 0x00012178
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x00004E93 File Offset: 0x00003093
		public Vector2 sizeDelta
		{
			get
			{
				Vector2 vector;
				this.INTERNAL_get_sizeDelta(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_sizeDelta(ref value);
			}
		}

		// Token: 0x06000748 RID: 1864
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_sizeDelta(out Vector2 value);

		// Token: 0x06000749 RID: 1865
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_sizeDelta(ref Vector2 value);

		/// <summary>
		///   <para>The normalized position in this RectTransform that it rotates around.</para>
		/// </summary>
		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x00013F90 File Offset: 0x00012190
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x00004E9D File Offset: 0x0000309D
		public Vector2 pivot
		{
			get
			{
				Vector2 vector;
				this.INTERNAL_get_pivot(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_pivot(ref value);
			}
		}

		// Token: 0x0600074C RID: 1868
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_pivot(out Vector2 value);

		// Token: 0x0600074D RID: 1869
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_pivot(ref Vector2 value);

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x0600074E RID: 1870
		// (set) Token: 0x0600074F RID: 1871
		internal extern Object drivenByObject
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000750 RID: 1872
		// (set) Token: 0x06000751 RID: 1873
		internal extern DrivenTransformProperties drivenProperties
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00004EA7 File Offset: 0x000030A7
		internal static void SendReapplyDrivenProperties(RectTransform driven)
		{
			if (RectTransform.reapplyDrivenProperties != null)
			{
				RectTransform.reapplyDrivenProperties(driven);
			}
		}

		/// <summary>
		///   <para>Get the corners of the calculated rectangle in the local space of its Transform.</para>
		/// </summary>
		/// <param name="fourCornersArray">Array that corners should be filled into.</param>
		// Token: 0x06000753 RID: 1875 RVA: 0x00013FA8 File Offset: 0x000121A8
		public void GetLocalCorners(Vector3[] fourCornersArray)
		{
			if (fourCornersArray == null || fourCornersArray.Length < 4)
			{
				Debug.LogError("Calling GetLocalCorners with an array that is null or has less than 4 elements.");
				return;
			}
			Rect rect = this.rect;
			float x = rect.x;
			float y = rect.y;
			float xMax = rect.xMax;
			float yMax = rect.yMax;
			fourCornersArray[0] = new Vector3(x, y, 0f);
			fourCornersArray[1] = new Vector3(x, yMax, 0f);
			fourCornersArray[2] = new Vector3(xMax, yMax, 0f);
			fourCornersArray[3] = new Vector3(xMax, y, 0f);
		}

		/// <summary>
		///   <para>Get the corners of the calculated rectangle in world space.</para>
		/// </summary>
		/// <param name="fourCornersArray">Array that corners should be filled into.</param>
		// Token: 0x06000754 RID: 1876 RVA: 0x0001405C File Offset: 0x0001225C
		public void GetWorldCorners(Vector3[] fourCornersArray)
		{
			if (fourCornersArray == null || fourCornersArray.Length < 4)
			{
				Debug.LogError("Calling GetWorldCorners with an array that is null or has less than 4 elements.");
				return;
			}
			this.GetLocalCorners(fourCornersArray);
			Transform transform = base.transform;
			for (int i = 0; i < 4; i++)
			{
				fourCornersArray[i] = transform.TransformPoint(fourCornersArray[i]);
			}
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x000140C4 File Offset: 0x000122C4
		internal Rect GetRectInParentSpace()
		{
			Rect rect = this.rect;
			Vector2 vector = this.offsetMin + Vector2.Scale(this.pivot, rect.size);
			Transform parent = base.transform.parent;
			if (parent)
			{
				RectTransform component = parent.GetComponent<RectTransform>();
				if (component)
				{
					vector += Vector2.Scale(this.anchorMin, component.rect.size);
				}
			}
			rect.x += vector.x;
			rect.y += vector.y;
			return rect;
		}

		/// <summary>
		///   <para>The offset of the lower left corner of the rectangle relative to the lower left anchor.</para>
		/// </summary>
		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x00004EBE File Offset: 0x000030BE
		// (set) Token: 0x06000757 RID: 1879 RVA: 0x0001416C File Offset: 0x0001236C
		public Vector2 offsetMin
		{
			get
			{
				return this.anchoredPosition - Vector2.Scale(this.sizeDelta, this.pivot);
			}
			set
			{
				Vector2 vector = value - (this.anchoredPosition - Vector2.Scale(this.sizeDelta, this.pivot));
				this.sizeDelta -= vector;
				this.anchoredPosition += Vector2.Scale(vector, Vector2.one - this.pivot);
			}
		}

		/// <summary>
		///   <para>The offset of the upper right corner of the rectangle relative to the upper right anchor.</para>
		/// </summary>
		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x00004EDC File Offset: 0x000030DC
		// (set) Token: 0x06000759 RID: 1881 RVA: 0x000141D8 File Offset: 0x000123D8
		public Vector2 offsetMax
		{
			get
			{
				return this.anchoredPosition + Vector2.Scale(this.sizeDelta, Vector2.one - this.pivot);
			}
			set
			{
				Vector2 vector = value - (this.anchoredPosition + Vector2.Scale(this.sizeDelta, Vector2.one - this.pivot));
				this.sizeDelta += vector;
				this.anchoredPosition += Vector2.Scale(vector, this.pivot);
			}
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00014244 File Offset: 0x00012444
		public void SetInsetAndSizeFromParentEdge(RectTransform.Edge edge, float inset, float size)
		{
			int num = ((edge != RectTransform.Edge.Top && edge != RectTransform.Edge.Bottom) ? 0 : 1);
			bool flag = edge == RectTransform.Edge.Top || edge == RectTransform.Edge.Right;
			float num2 = (float)((!flag) ? 0 : 1);
			Vector2 vector = this.anchorMin;
			vector[num] = num2;
			this.anchorMin = vector;
			vector = this.anchorMax;
			vector[num] = num2;
			this.anchorMax = vector;
			Vector2 sizeDelta = this.sizeDelta;
			sizeDelta[num] = size;
			this.sizeDelta = sizeDelta;
			Vector2 anchoredPosition = this.anchoredPosition;
			anchoredPosition[num] = ((!flag) ? (inset + size * this.pivot[num]) : (-inset - size * (1f - this.pivot[num])));
			this.anchoredPosition = anchoredPosition;
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00014320 File Offset: 0x00012520
		public void SetSizeWithCurrentAnchors(RectTransform.Axis axis, float size)
		{
			Vector2 sizeDelta = this.sizeDelta;
			sizeDelta[(int)axis] = size - this.GetParentSize()[(int)axis] * (this.anchorMax[(int)axis] - this.anchorMin[(int)axis]);
			this.sizeDelta = sizeDelta;
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00014378 File Offset: 0x00012578
		private Vector2 GetParentSize()
		{
			RectTransform rectTransform = base.parent as RectTransform;
			if (!rectTransform)
			{
				return Vector2.zero;
			}
			return rectTransform.rect.size;
		}

		/// <summary>
		///   <para>Enum used to specify one edge of a rectangle.</para>
		/// </summary>
		// Token: 0x02000079 RID: 121
		public enum Edge
		{
			/// <summary>
			///   <para>The left edge.</para>
			/// </summary>
			// Token: 0x04000171 RID: 369
			Left,
			/// <summary>
			///   <para>The right edge.</para>
			/// </summary>
			// Token: 0x04000172 RID: 370
			Right,
			/// <summary>
			///   <para>The top edge.</para>
			/// </summary>
			// Token: 0x04000173 RID: 371
			Top,
			/// <summary>
			///   <para>The bottom edge.</para>
			/// </summary>
			// Token: 0x04000174 RID: 372
			Bottom
		}

		/// <summary>
		///   <para>An axis that can be horizontal or vertical.</para>
		/// </summary>
		// Token: 0x0200007A RID: 122
		public enum Axis
		{
			/// <summary>
			///   <para>Horizontal.</para>
			/// </summary>
			// Token: 0x04000176 RID: 374
			Horizontal,
			/// <summary>
			///   <para>Vertical.</para>
			/// </summary>
			// Token: 0x04000177 RID: 375
			Vertical
		}

		/// <summary>
		///   <para>Delegate used for the reapplyDrivenProperties event.</para>
		/// </summary>
		/// <param name="driven"></param>
		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x0600075E RID: 1886
		public delegate void ReapplyDrivenProperties(RectTransform driven);
	}
}
