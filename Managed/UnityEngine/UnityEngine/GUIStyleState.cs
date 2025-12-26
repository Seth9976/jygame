using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Specialized values for the given states used by GUIStyle objects.</para>
	/// </summary>
	// Token: 0x020001E3 RID: 483
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class GUIStyleState
	{
		// Token: 0x06001C46 RID: 7238 RVA: 0x0000AEFC File Offset: 0x000090FC
		public GUIStyleState()
		{
			this.Init();
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x0000AF0A File Offset: 0x0000910A
		internal GUIStyleState(GUIStyle sourceStyle, IntPtr source)
		{
			this.m_SourceStyle = sourceStyle;
			this.m_Ptr = source;
			this.m_Background = this.GetBackgroundInternal();
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x000232A0 File Offset: 0x000214A0
		~GUIStyleState()
		{
			if (this.m_SourceStyle == null)
			{
				this.Cleanup();
			}
		}

		/// <summary>
		///   <para>The background image used by GUI elements in this given state.</para>
		/// </summary>
		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06001C49 RID: 7241 RVA: 0x0000AF2C File Offset: 0x0000912C
		// (set) Token: 0x06001C4A RID: 7242 RVA: 0x0000AF34 File Offset: 0x00009134
		public Texture2D background
		{
			get
			{
				return this.GetBackgroundInternal();
			}
			set
			{
				this.SetBackgroundInternal(value);
				this.m_Background = value;
			}
		}

		// Token: 0x06001C4B RID: 7243
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Init();

		// Token: 0x06001C4C RID: 7244
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Cleanup();

		// Token: 0x06001C4D RID: 7245
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetBackgroundInternal(Texture2D value);

		// Token: 0x06001C4E RID: 7246
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Texture2D GetBackgroundInternal();

		/// <summary>
		///   <para>The text color used by GUI elements in this state.</para>
		/// </summary>
		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06001C4F RID: 7247 RVA: 0x000232DC File Offset: 0x000214DC
		// (set) Token: 0x06001C50 RID: 7248 RVA: 0x0000AF44 File Offset: 0x00009144
		public Color textColor
		{
			get
			{
				Color color;
				this.INTERNAL_get_textColor(out color);
				return color;
			}
			set
			{
				this.INTERNAL_set_textColor(ref value);
			}
		}

		// Token: 0x06001C51 RID: 7249
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_textColor(out Color value);

		// Token: 0x06001C52 RID: 7250
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_textColor(ref Color value);

		// Token: 0x04000778 RID: 1912
		[NonSerialized]
		internal IntPtr m_Ptr;

		// Token: 0x04000779 RID: 1913
		private readonly GUIStyle m_SourceStyle;

		// Token: 0x0400077A RID: 1914
		[NonSerialized]
		private Texture2D m_Background;
	}
}
