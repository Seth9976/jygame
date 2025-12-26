using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Types of UnityGUI input and processing events.</para>
	/// </summary>
	// Token: 0x020001C4 RID: 452
	public enum EventType
	{
		/// <summary>
		///   <para>Mouse button was pressed.</para>
		/// </summary>
		// Token: 0x040006BA RID: 1722
		MouseDown,
		/// <summary>
		///   <para>Mouse button was released.</para>
		/// </summary>
		// Token: 0x040006BB RID: 1723
		MouseUp,
		/// <summary>
		///   <para>Mouse was moved (editor views only).</para>
		/// </summary>
		// Token: 0x040006BC RID: 1724
		MouseMove,
		/// <summary>
		///   <para>Mouse was dragged.</para>
		/// </summary>
		// Token: 0x040006BD RID: 1725
		MouseDrag,
		/// <summary>
		///   <para>A keyboard key was pressed.</para>
		/// </summary>
		// Token: 0x040006BE RID: 1726
		KeyDown,
		/// <summary>
		///   <para>A keyboard key was released.</para>
		/// </summary>
		// Token: 0x040006BF RID: 1727
		KeyUp,
		/// <summary>
		///   <para>The scroll wheel was moved.</para>
		/// </summary>
		// Token: 0x040006C0 RID: 1728
		ScrollWheel,
		/// <summary>
		///   <para>A repaint event. One is sent every frame.</para>
		/// </summary>
		// Token: 0x040006C1 RID: 1729
		Repaint,
		/// <summary>
		///   <para>A layout event.</para>
		/// </summary>
		// Token: 0x040006C2 RID: 1730
		Layout,
		/// <summary>
		///   <para>Editor only: drag &amp; drop operation updated.</para>
		/// </summary>
		// Token: 0x040006C3 RID: 1731
		DragUpdated,
		/// <summary>
		///   <para>Editor only: drag &amp; drop operation performed.</para>
		/// </summary>
		// Token: 0x040006C4 RID: 1732
		DragPerform,
		/// <summary>
		///   <para>Editor only: drag &amp; drop operation exited.</para>
		/// </summary>
		// Token: 0x040006C5 RID: 1733
		DragExited = 15,
		/// <summary>
		///   <para>Event should be ignored.</para>
		/// </summary>
		// Token: 0x040006C6 RID: 1734
		Ignore = 11,
		/// <summary>
		///   <para>Already processed event.</para>
		/// </summary>
		// Token: 0x040006C7 RID: 1735
		Used,
		/// <summary>
		///   <para>Validates a special command (e.g. copy &amp; paste).</para>
		/// </summary>
		// Token: 0x040006C8 RID: 1736
		ValidateCommand,
		/// <summary>
		///   <para>Execute a special command (eg. copy &amp; paste).</para>
		/// </summary>
		// Token: 0x040006C9 RID: 1737
		ExecuteCommand,
		/// <summary>
		///   <para>User has right-clicked (or control-clicked on the mac).</para>
		/// </summary>
		// Token: 0x040006CA RID: 1738
		ContextClick = 16,
		// Token: 0x040006CB RID: 1739
		mouseDown = 0,
		// Token: 0x040006CC RID: 1740
		mouseUp,
		// Token: 0x040006CD RID: 1741
		mouseMove,
		// Token: 0x040006CE RID: 1742
		mouseDrag,
		// Token: 0x040006CF RID: 1743
		keyDown,
		// Token: 0x040006D0 RID: 1744
		keyUp,
		// Token: 0x040006D1 RID: 1745
		scrollWheel,
		// Token: 0x040006D2 RID: 1746
		repaint,
		// Token: 0x040006D3 RID: 1747
		layout,
		// Token: 0x040006D4 RID: 1748
		dragUpdated,
		// Token: 0x040006D5 RID: 1749
		dragPerform,
		// Token: 0x040006D6 RID: 1750
		ignore,
		// Token: 0x040006D7 RID: 1751
		used
	}
}
