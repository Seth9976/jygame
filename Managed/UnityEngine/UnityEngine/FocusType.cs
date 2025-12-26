using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Used by GUIUtility.GetControlID to inform the UnityGUI system if a given control can get keyboard focus.</para>
	/// </summary>
	// Token: 0x020001EA RID: 490
	public enum FocusType
	{
		/// <summary>
		///   <para>This control can get keyboard focus on Windows, but not on Mac. Used for buttons, checkboxes and other "pressable" things.</para>
		/// </summary>
		// Token: 0x0400079B RID: 1947
		Native,
		/// <summary>
		///   <para>This is a proper keyboard control. It can have input focus on all platforms. Used for TextField and TextArea controls.</para>
		/// </summary>
		// Token: 0x0400079C RID: 1948
		Keyboard,
		/// <summary>
		///   <para>This control can never recieve keyboard focus.</para>
		/// </summary>
		// Token: 0x0400079D RID: 1949
		Passive
	}
}
