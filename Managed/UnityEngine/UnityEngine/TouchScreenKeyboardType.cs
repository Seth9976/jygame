using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Describes the type of keyboard.</para>
	/// </summary>
	// Token: 0x02000050 RID: 80
	public enum TouchScreenKeyboardType
	{
		/// <summary>
		///   <para>Default keyboard for the current input method.</para>
		/// </summary>
		// Token: 0x040000C2 RID: 194
		Default,
		/// <summary>
		///   <para>Keyboard displays standard ASCII characters.</para>
		/// </summary>
		// Token: 0x040000C3 RID: 195
		ASCIICapable,
		/// <summary>
		///   <para>Keyboard with numbers and punctuation.</para>
		/// </summary>
		// Token: 0x040000C4 RID: 196
		NumbersAndPunctuation,
		/// <summary>
		///   <para>Keyboard optimized for URL entry.</para>
		/// </summary>
		// Token: 0x040000C5 RID: 197
		URL,
		/// <summary>
		///   <para>Numeric keypad designed for PIN entry.</para>
		/// </summary>
		// Token: 0x040000C6 RID: 198
		NumberPad,
		/// <summary>
		///   <para>Keypad designed for entering telephone numbers.</para>
		/// </summary>
		// Token: 0x040000C7 RID: 199
		PhonePad,
		/// <summary>
		///   <para>Keypad designed for entering a person's name or phone number.</para>
		/// </summary>
		// Token: 0x040000C8 RID: 200
		NamePhonePad,
		/// <summary>
		///   <para>Keyboard optimized for specifying email addresses.</para>
		/// </summary>
		// Token: 0x040000C9 RID: 201
		EmailAddress,
		/// <summary>
		///   <para>Keyboard designed for Nintendo Network Accounts (available on Wii U only).</para>
		/// </summary>
		// Token: 0x040000CA RID: 202
		NintendoNetworkAccount
	}
}
