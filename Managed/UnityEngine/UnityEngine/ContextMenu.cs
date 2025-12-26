using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>The ContextMenu attribute allows you to add commands to the context menu.</para>
	/// </summary>
	// Token: 0x0200024B RID: 587
	public sealed class ContextMenu : Attribute
	{
		/// <summary>
		///   <para>Adds the function to the context menu of the component.</para>
		/// </summary>
		/// <param name="name"></param>
		// Token: 0x06002071 RID: 8305 RVA: 0x0000CCEC File Offset: 0x0000AEEC
		public ContextMenu(string name)
		{
			this.m_ItemName = name;
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06002072 RID: 8306 RVA: 0x0000CCFB File Offset: 0x0000AEFB
		public string menuItem
		{
			get
			{
				return this.m_ItemName;
			}
		}

		// Token: 0x040008DA RID: 2266
		private string m_ItemName;
	}
}
