using System;

namespace UnityEngine
{
	// Token: 0x020001D7 RID: 471
	internal class GUILayoutEntry
	{
		// Token: 0x06001BD6 RID: 7126 RVA: 0x0002077C File Offset: 0x0001E97C
		public GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style)
		{
			this.minWidth = _minWidth;
			this.maxWidth = _maxWidth;
			this.minHeight = _minHeight;
			this.maxHeight = _maxHeight;
			if (_style == null)
			{
				_style = GUIStyle.none;
			}
			this.style = _style;
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x000207EC File Offset: 0x0001E9EC
		public GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, GUILayoutOption[] options)
		{
			this.minWidth = _minWidth;
			this.maxWidth = _maxWidth;
			this.minHeight = _minHeight;
			this.maxHeight = _maxHeight;
			this.style = _style;
			this.ApplyOptions(options);
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06001BD9 RID: 7129 RVA: 0x0000AAF3 File Offset: 0x00008CF3
		// (set) Token: 0x06001BDA RID: 7130 RVA: 0x0000AAFB File Offset: 0x00008CFB
		public GUIStyle style
		{
			get
			{
				return this.m_Style;
			}
			set
			{
				this.m_Style = value;
				this.ApplyStyleSettings(value);
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06001BDB RID: 7131 RVA: 0x0000AB0B File Offset: 0x00008D0B
		public virtual RectOffset margin
		{
			get
			{
				return this.style.margin;
			}
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x00002753 File Offset: 0x00000953
		public virtual void CalcWidth()
		{
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x00002753 File Offset: 0x00000953
		public virtual void CalcHeight()
		{
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x0000AB18 File Offset: 0x00008D18
		public virtual void SetHorizontal(float x, float width)
		{
			this.rect.x = x;
			this.rect.width = width;
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x0000AB32 File Offset: 0x00008D32
		public virtual void SetVertical(float y, float height)
		{
			this.rect.y = y;
			this.rect.height = height;
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x00020858 File Offset: 0x0001EA58
		protected virtual void ApplyStyleSettings(GUIStyle style)
		{
			this.stretchWidth = ((style.fixedWidth != 0f || !style.stretchWidth) ? 0 : 1);
			this.stretchHeight = ((style.fixedHeight != 0f || !style.stretchHeight) ? 0 : 1);
			this.m_Style = style;
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x000208BC File Offset: 0x0001EABC
		public virtual void ApplyOptions(GUILayoutOption[] options)
		{
			if (options == null)
			{
				return;
			}
			foreach (GUILayoutOption guilayoutOption in options)
			{
				switch (guilayoutOption.type)
				{
				case GUILayoutOption.Type.fixedWidth:
					this.minWidth = (this.maxWidth = (float)guilayoutOption.value);
					this.stretchWidth = 0;
					break;
				case GUILayoutOption.Type.fixedHeight:
					this.minHeight = (this.maxHeight = (float)guilayoutOption.value);
					this.stretchHeight = 0;
					break;
				case GUILayoutOption.Type.minWidth:
					this.minWidth = (float)guilayoutOption.value;
					if (this.maxWidth < this.minWidth)
					{
						this.maxWidth = this.minWidth;
					}
					break;
				case GUILayoutOption.Type.maxWidth:
					this.maxWidth = (float)guilayoutOption.value;
					if (this.minWidth > this.maxWidth)
					{
						this.minWidth = this.maxWidth;
					}
					this.stretchWidth = 0;
					break;
				case GUILayoutOption.Type.minHeight:
					this.minHeight = (float)guilayoutOption.value;
					if (this.maxHeight < this.minHeight)
					{
						this.maxHeight = this.minHeight;
					}
					break;
				case GUILayoutOption.Type.maxHeight:
					this.maxHeight = (float)guilayoutOption.value;
					if (this.minHeight > this.maxHeight)
					{
						this.minHeight = this.maxHeight;
					}
					this.stretchHeight = 0;
					break;
				case GUILayoutOption.Type.stretchWidth:
					this.stretchWidth = (int)guilayoutOption.value;
					break;
				case GUILayoutOption.Type.stretchHeight:
					this.stretchHeight = (int)guilayoutOption.value;
					break;
				}
			}
			if (this.maxWidth != 0f && this.maxWidth < this.minWidth)
			{
				this.maxWidth = this.minWidth;
			}
			if (this.maxHeight != 0f && this.maxHeight < this.minHeight)
			{
				this.maxHeight = this.minHeight;
			}
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x00020ACC File Offset: 0x0001ECCC
		public override string ToString()
		{
			string text = string.Empty;
			for (int i = 0; i < GUILayoutEntry.indent; i++)
			{
				text += " ";
			}
			return string.Concat(new object[]
			{
				text,
				UnityString.Format("{1}-{0} (x:{2}-{3}, y:{4}-{5})", new object[]
				{
					(this.style == null) ? "NULL" : this.style.name,
					base.GetType(),
					this.rect.x,
					this.rect.xMax,
					this.rect.y,
					this.rect.yMax
				}),
				"   -   W: ",
				this.minWidth,
				"-",
				this.maxWidth,
				(this.stretchWidth == 0) ? string.Empty : "+",
				", H: ",
				this.minHeight,
				"-",
				this.maxHeight,
				(this.stretchHeight == 0) ? string.Empty : "+"
			});
		}

		// Token: 0x04000712 RID: 1810
		public float minWidth;

		// Token: 0x04000713 RID: 1811
		public float maxWidth;

		// Token: 0x04000714 RID: 1812
		public float minHeight;

		// Token: 0x04000715 RID: 1813
		public float maxHeight;

		// Token: 0x04000716 RID: 1814
		public Rect rect = new Rect(0f, 0f, 0f, 0f);

		// Token: 0x04000717 RID: 1815
		public int stretchWidth;

		// Token: 0x04000718 RID: 1816
		public int stretchHeight;

		// Token: 0x04000719 RID: 1817
		private GUIStyle m_Style = GUIStyle.none;

		// Token: 0x0400071A RID: 1818
		internal static Rect kDummyRect = new Rect(0f, 0f, 1f, 1f);

		// Token: 0x0400071B RID: 1819
		protected static int indent = 0;
	}
}
