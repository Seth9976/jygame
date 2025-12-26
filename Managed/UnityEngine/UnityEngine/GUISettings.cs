using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>General settings for how the GUI behaves.</para>
	/// </summary>
	// Token: 0x020001E0 RID: 480
	[Serializable]
	public sealed class GUISettings
	{
		/// <summary>
		///   <para>Should double-clicking select words in text fields.</para>
		/// </summary>
		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06001C01 RID: 7169 RVA: 0x0000ABC6 File Offset: 0x00008DC6
		// (set) Token: 0x06001C02 RID: 7170 RVA: 0x0000ABCE File Offset: 0x00008DCE
		public bool doubleClickSelectsWord
		{
			get
			{
				return this.m_DoubleClickSelectsWord;
			}
			set
			{
				this.m_DoubleClickSelectsWord = value;
			}
		}

		/// <summary>
		///   <para>Should triple-clicking select whole text in text fields.</para>
		/// </summary>
		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06001C03 RID: 7171 RVA: 0x0000ABD7 File Offset: 0x00008DD7
		// (set) Token: 0x06001C04 RID: 7172 RVA: 0x0000ABDF File Offset: 0x00008DDF
		public bool tripleClickSelectsLine
		{
			get
			{
				return this.m_TripleClickSelectsLine;
			}
			set
			{
				this.m_TripleClickSelectsLine = value;
			}
		}

		/// <summary>
		///   <para>The color of the cursor in text fields.</para>
		/// </summary>
		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06001C05 RID: 7173 RVA: 0x0000ABE8 File Offset: 0x00008DE8
		// (set) Token: 0x06001C06 RID: 7174 RVA: 0x0000ABF0 File Offset: 0x00008DF0
		public Color cursorColor
		{
			get
			{
				return this.m_CursorColor;
			}
			set
			{
				this.m_CursorColor = value;
			}
		}

		/// <summary>
		///   <para>The speed of text field cursor flashes.</para>
		/// </summary>
		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06001C07 RID: 7175 RVA: 0x0000ABF9 File Offset: 0x00008DF9
		// (set) Token: 0x06001C08 RID: 7176 RVA: 0x0000AC17 File Offset: 0x00008E17
		public float cursorFlashSpeed
		{
			get
			{
				if (this.m_CursorFlashSpeed >= 0f)
				{
					return this.m_CursorFlashSpeed;
				}
				return GUISettings.Internal_GetCursorFlashSpeed();
			}
			set
			{
				this.m_CursorFlashSpeed = value;
			}
		}

		/// <summary>
		///   <para>The color of the selection rect in text fields.</para>
		/// </summary>
		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06001C09 RID: 7177 RVA: 0x0000AC20 File Offset: 0x00008E20
		// (set) Token: 0x06001C0A RID: 7178 RVA: 0x0000AC28 File Offset: 0x00008E28
		public Color selectionColor
		{
			get
			{
				return this.m_SelectionColor;
			}
			set
			{
				this.m_SelectionColor = value;
			}
		}

		// Token: 0x06001C0B RID: 7179
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetCursorFlashSpeed();

		// Token: 0x04000758 RID: 1880
		[SerializeField]
		private bool m_DoubleClickSelectsWord = true;

		// Token: 0x04000759 RID: 1881
		[SerializeField]
		private bool m_TripleClickSelectsLine = true;

		// Token: 0x0400075A RID: 1882
		[SerializeField]
		private Color m_CursorColor = Color.white;

		// Token: 0x0400075B RID: 1883
		[SerializeField]
		private float m_CursorFlashSpeed = -1f;

		// Token: 0x0400075C RID: 1884
		[SerializeField]
		private Color m_SelectionColor = new Color(0.5f, 0.5f, 1f);
	}
}
