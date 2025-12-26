using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Types of modifier key that can be active during a keystroke event.</para>
	/// </summary>
	// Token: 0x020001C5 RID: 453
	[Flags]
	public enum EventModifiers
	{
		/// <summary>
		///   <para>No modifier key pressed during a keystroke event.</para>
		/// </summary>
		// Token: 0x040006D9 RID: 1753
		None = 0,
		/// <summary>
		///   <para>Shift key.</para>
		/// </summary>
		// Token: 0x040006DA RID: 1754
		Shift = 1,
		/// <summary>
		///   <para>Control key.</para>
		/// </summary>
		// Token: 0x040006DB RID: 1755
		Control = 2,
		/// <summary>
		///   <para>Alt key.</para>
		/// </summary>
		// Token: 0x040006DC RID: 1756
		Alt = 4,
		/// <summary>
		///   <para>Command key (Mac).</para>
		/// </summary>
		// Token: 0x040006DD RID: 1757
		Command = 8,
		/// <summary>
		///   <para>Num lock key.</para>
		/// </summary>
		// Token: 0x040006DE RID: 1758
		Numeric = 16,
		/// <summary>
		///   <para>Caps lock key.</para>
		/// </summary>
		// Token: 0x040006DF RID: 1759
		CapsLock = 32,
		/// <summary>
		///   <para>Function key.</para>
		/// </summary>
		// Token: 0x040006E0 RID: 1760
		FunctionKey = 64
	}
}
