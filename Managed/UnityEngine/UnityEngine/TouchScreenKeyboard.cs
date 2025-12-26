using System;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Interface into the native iPhone, Android, Windows Phone and Windows Store Apps on-screen keyboards - it is not available on other platforms.</para>
	/// </summary>
	// Token: 0x02000051 RID: 81
	public sealed class TouchScreenKeyboard
	{
		/// <summary>
		///   <para>Opens the native keyboard provided by OS on the screen.</para>
		/// </summary>
		/// <param name="text">Text to edit.</param>
		/// <param name="keyboardType">Type of keyboard (eg, any text, numbers only, etc).</param>
		/// <param name="autocorrection">Is autocorrection applied?</param>
		/// <param name="multiline">Can more than one line of text be entered?</param>
		/// <param name="secure">Is the text masked (for passwords, etc)?</param>
		/// <param name="alert">Is the keyboard opened in alert mode?</param>
		/// <param name="textPlaceholder">Text to be used if no other text is present.</param>
		// Token: 0x0600042F RID: 1071 RVA: 0x00010150 File Offset: 0x0000E350
		[ExcludeFromDocs]
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert)
		{
			string empty = string.Empty;
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, empty);
		}

		/// <summary>
		///   <para>Opens the native keyboard provided by OS on the screen.</para>
		/// </summary>
		/// <param name="text">Text to edit.</param>
		/// <param name="keyboardType">Type of keyboard (eg, any text, numbers only, etc).</param>
		/// <param name="autocorrection">Is autocorrection applied?</param>
		/// <param name="multiline">Can more than one line of text be entered?</param>
		/// <param name="secure">Is the text masked (for passwords, etc)?</param>
		/// <param name="alert">Is the keyboard opened in alert mode?</param>
		/// <param name="textPlaceholder">Text to be used if no other text is present.</param>
		// Token: 0x06000430 RID: 1072 RVA: 0x00010174 File Offset: 0x0000E374
		[ExcludeFromDocs]
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure)
		{
			string empty = string.Empty;
			bool flag = false;
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, flag, empty);
		}

		/// <summary>
		///   <para>Opens the native keyboard provided by OS on the screen.</para>
		/// </summary>
		/// <param name="text">Text to edit.</param>
		/// <param name="keyboardType">Type of keyboard (eg, any text, numbers only, etc).</param>
		/// <param name="autocorrection">Is autocorrection applied?</param>
		/// <param name="multiline">Can more than one line of text be entered?</param>
		/// <param name="secure">Is the text masked (for passwords, etc)?</param>
		/// <param name="alert">Is the keyboard opened in alert mode?</param>
		/// <param name="textPlaceholder">Text to be used if no other text is present.</param>
		// Token: 0x06000431 RID: 1073 RVA: 0x00010198 File Offset: 0x0000E398
		[ExcludeFromDocs]
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline)
		{
			string empty = string.Empty;
			bool flag = false;
			bool flag2 = false;
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, flag2, flag, empty);
		}

		/// <summary>
		///   <para>Opens the native keyboard provided by OS on the screen.</para>
		/// </summary>
		/// <param name="text">Text to edit.</param>
		/// <param name="keyboardType">Type of keyboard (eg, any text, numbers only, etc).</param>
		/// <param name="autocorrection">Is autocorrection applied?</param>
		/// <param name="multiline">Can more than one line of text be entered?</param>
		/// <param name="secure">Is the text masked (for passwords, etc)?</param>
		/// <param name="alert">Is the keyboard opened in alert mode?</param>
		/// <param name="textPlaceholder">Text to be used if no other text is present.</param>
		// Token: 0x06000432 RID: 1074 RVA: 0x000101BC File Offset: 0x0000E3BC
		[ExcludeFromDocs]
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection)
		{
			string empty = string.Empty;
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, flag3, flag2, flag, empty);
		}

		/// <summary>
		///   <para>Opens the native keyboard provided by OS on the screen.</para>
		/// </summary>
		/// <param name="text">Text to edit.</param>
		/// <param name="keyboardType">Type of keyboard (eg, any text, numbers only, etc).</param>
		/// <param name="autocorrection">Is autocorrection applied?</param>
		/// <param name="multiline">Can more than one line of text be entered?</param>
		/// <param name="secure">Is the text masked (for passwords, etc)?</param>
		/// <param name="alert">Is the keyboard opened in alert mode?</param>
		/// <param name="textPlaceholder">Text to be used if no other text is present.</param>
		// Token: 0x06000433 RID: 1075 RVA: 0x000101E4 File Offset: 0x0000E3E4
		[ExcludeFromDocs]
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType)
		{
			string empty = string.Empty;
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = true;
			return TouchScreenKeyboard.Open(text, keyboardType, flag4, flag3, flag2, flag, empty);
		}

		/// <summary>
		///   <para>Opens the native keyboard provided by OS on the screen.</para>
		/// </summary>
		/// <param name="text">Text to edit.</param>
		/// <param name="keyboardType">Type of keyboard (eg, any text, numbers only, etc).</param>
		/// <param name="autocorrection">Is autocorrection applied?</param>
		/// <param name="multiline">Can more than one line of text be entered?</param>
		/// <param name="secure">Is the text masked (for passwords, etc)?</param>
		/// <param name="alert">Is the keyboard opened in alert mode?</param>
		/// <param name="textPlaceholder">Text to be used if no other text is present.</param>
		// Token: 0x06000434 RID: 1076 RVA: 0x00010210 File Offset: 0x0000E410
		[ExcludeFromDocs]
		public static TouchScreenKeyboard Open(string text)
		{
			string empty = string.Empty;
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = true;
			TouchScreenKeyboardType touchScreenKeyboardType = TouchScreenKeyboardType.Default;
			return TouchScreenKeyboard.Open(text, touchScreenKeyboardType, flag4, flag3, flag2, flag, empty);
		}

		/// <summary>
		///   <para>Opens the native keyboard provided by OS on the screen.</para>
		/// </summary>
		/// <param name="text">Text to edit.</param>
		/// <param name="keyboardType">Type of keyboard (eg, any text, numbers only, etc).</param>
		/// <param name="autocorrection">Is autocorrection applied?</param>
		/// <param name="multiline">Can more than one line of text be entered?</param>
		/// <param name="secure">Is the text masked (for passwords, etc)?</param>
		/// <param name="alert">Is the keyboard opened in alert mode?</param>
		/// <param name="textPlaceholder">Text to be used if no other text is present.</param>
		// Token: 0x06000435 RID: 1077 RVA: 0x00002096 File Offset: 0x00000296
		public static TouchScreenKeyboard Open(string text, [DefaultValue("TouchScreenKeyboardType.Default")] TouchScreenKeyboardType keyboardType, [DefaultValue("true")] bool autocorrection, [DefaultValue("false")] bool multiline, [DefaultValue("false")] bool secure, [DefaultValue("false")] bool alert, [DefaultValue("\"\"")] string textPlaceholder)
		{
			return null;
		}

		/// <summary>
		///   <para>Returns the text displayed by the input field of the keyboard.</para>
		/// </summary>
		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x00002C2F File Offset: 0x00000E2F
		// (set) Token: 0x06000437 RID: 1079 RVA: 0x00002753 File Offset: 0x00000953
		public string text
		{
			get
			{
				return string.Empty;
			}
			set
			{
			}
		}

		/// <summary>
		///   <para>Will text input field above the keyboard be hidden when the keyboard is on screen?</para>
		/// </summary>
		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x00002C36 File Offset: 0x00000E36
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x00002753 File Offset: 0x00000953
		public static bool hideInput
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>
		///   <para>Is the keyboard visible or sliding into the position on the screen?</para>
		/// </summary>
		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x00002C36 File Offset: 0x00000E36
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x00002753 File Offset: 0x00000953
		public bool active
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>
		///   <para>Specifies if input process was finished. (Read Only)</para>
		/// </summary>
		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x000021E1 File Offset: 0x000003E1
		public bool done
		{
			get
			{
				return true;
			}
		}

		/// <summary>
		///   <para>Specifies if input process was canceled. (Read Only)</para>
		/// </summary>
		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x00002C36 File Offset: 0x00000E36
		public bool wasCanceled
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x00010240 File Offset: 0x0000E440
		private static Rect area
		{
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x00002C36 File Offset: 0x00000E36
		private static bool visible
		{
			get
			{
				return false;
			}
		}

		/// <summary>
		///   <para>Is touch screen keyboard supported.</para>
		/// </summary>
		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x00002C36 File Offset: 0x00000E36
		public static bool isSupported
		{
			get
			{
				return false;
			}
		}
	}
}
