using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Offsets for rectangles, borders, etc.</para>
	/// </summary>
	// Token: 0x020001E4 RID: 484
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class RectOffset
	{
		/// <summary>
		///   <para>Creates a new rectangle with offsets.</para>
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <param name="top"></param>
		/// <param name="bottom"></param>
		// Token: 0x06001C53 RID: 7251 RVA: 0x0000AF4E File Offset: 0x0000914E
		public RectOffset()
		{
			this.Init();
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x0000AF5C File Offset: 0x0000915C
		internal RectOffset(GUIStyle sourceStyle, IntPtr source)
		{
			this.m_SourceStyle = sourceStyle;
			this.m_Ptr = source;
		}

		/// <summary>
		///   <para>Creates a new rectangle with offsets.</para>
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <param name="top"></param>
		/// <param name="bottom"></param>
		// Token: 0x06001C55 RID: 7253 RVA: 0x0000AF72 File Offset: 0x00009172
		public RectOffset(int left, int right, int top, int bottom)
		{
			this.Init();
			this.left = left;
			this.right = right;
			this.top = top;
			this.bottom = bottom;
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x000232F4 File Offset: 0x000214F4
		~RectOffset()
		{
			if (this.m_SourceStyle == null)
			{
				this.Cleanup();
			}
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x00023330 File Offset: 0x00021530
		public override string ToString()
		{
			return UnityString.Format("RectOffset (l:{0} r:{1} t:{2} b:{3})", new object[] { this.left, this.right, this.top, this.bottom });
		}

		// Token: 0x06001C58 RID: 7256
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Init();

		// Token: 0x06001C59 RID: 7257
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Cleanup();

		/// <summary>
		///   <para>Left edge size.</para>
		/// </summary>
		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06001C5A RID: 7258
		// (set) Token: 0x06001C5B RID: 7259
		public extern int left
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Right edge size.</para>
		/// </summary>
		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06001C5C RID: 7260
		// (set) Token: 0x06001C5D RID: 7261
		public extern int right
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Top edge size.</para>
		/// </summary>
		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06001C5E RID: 7262
		// (set) Token: 0x06001C5F RID: 7263
		public extern int top
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Bottom edge size.</para>
		/// </summary>
		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06001C60 RID: 7264
		// (set) Token: 0x06001C61 RID: 7265
		public extern int bottom
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Shortcut for left + right. (Read Only)</para>
		/// </summary>
		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06001C62 RID: 7266
		public extern int horizontal
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Shortcut for top + bottom. (Read Only)</para>
		/// </summary>
		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06001C63 RID: 7267
		public extern int vertical
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Add the border offsets to a rect.</para>
		/// </summary>
		/// <param name="rect"></param>
		// Token: 0x06001C64 RID: 7268 RVA: 0x0000AF9D File Offset: 0x0000919D
		public Rect Add(Rect rect)
		{
			return RectOffset.INTERNAL_CALL_Add(this, ref rect);
		}

		// Token: 0x06001C65 RID: 7269
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Rect INTERNAL_CALL_Add(RectOffset self, ref Rect rect);

		/// <summary>
		///   <para>Remove the border offsets from a rect.</para>
		/// </summary>
		/// <param name="rect"></param>
		// Token: 0x06001C66 RID: 7270 RVA: 0x0000AFA7 File Offset: 0x000091A7
		public Rect Remove(Rect rect)
		{
			return RectOffset.INTERNAL_CALL_Remove(this, ref rect);
		}

		// Token: 0x06001C67 RID: 7271
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Rect INTERNAL_CALL_Remove(RectOffset self, ref Rect rect);

		// Token: 0x0400077B RID: 1915
		[NonSerialized]
		internal IntPtr m_Ptr;

		// Token: 0x0400077C RID: 1916
		private readonly GUIStyle m_SourceStyle;
	}
}
