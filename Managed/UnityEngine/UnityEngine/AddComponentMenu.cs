using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>The AddComponentMenu attribute allows you to place a script anywhere in the "Component" menu, instead of just the "Component-&gt;Scripts" menu.</para>
	/// </summary>
	// Token: 0x02000249 RID: 585
	public sealed class AddComponentMenu : Attribute
	{
		/// <summary>
		///   <para>Add an item in the Component menu.</para>
		/// </summary>
		/// <param name="menuName">The path to the component.</param>
		/// <param name="order">Where in the component menu to add the new item.</param>
		// Token: 0x06002066 RID: 8294 RVA: 0x0000CC7D File Offset: 0x0000AE7D
		public AddComponentMenu(string menuName)
		{
			this.m_AddComponentMenu = menuName;
			this.m_Ordering = 0;
		}

		/// <summary>
		///   <para>Add an item in the Component menu.</para>
		/// </summary>
		/// <param name="menuName">The path to the component.</param>
		/// <param name="order">Where in the component menu to add the new item.</param>
		// Token: 0x06002067 RID: 8295 RVA: 0x0000CC93 File Offset: 0x0000AE93
		public AddComponentMenu(string menuName, int order)
		{
			this.m_AddComponentMenu = menuName;
			this.m_Ordering = order;
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06002068 RID: 8296 RVA: 0x0000CCA9 File Offset: 0x0000AEA9
		public string componentMenu
		{
			get
			{
				return this.m_AddComponentMenu;
			}
		}

		/// <summary>
		///   <para>The order of the component in the component menu (lower is higher to the top).</para>
		/// </summary>
		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06002069 RID: 8297 RVA: 0x0000CCB1 File Offset: 0x0000AEB1
		public int componentOrder
		{
			get
			{
				return this.m_Ordering;
			}
		}

		// Token: 0x040008D5 RID: 2261
		private string m_AddComponentMenu;

		// Token: 0x040008D6 RID: 2262
		private int m_Ordering;
	}
}
