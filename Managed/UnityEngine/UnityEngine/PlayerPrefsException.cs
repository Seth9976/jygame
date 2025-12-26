using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>An exception thrown by the PlayerPrefs class in a  web player build.</para>
	/// </summary>
	// Token: 0x020000CF RID: 207
	public sealed class PlayerPrefsException : Exception
	{
		// Token: 0x06000CA7 RID: 3239 RVA: 0x00006621 File Offset: 0x00004821
		public PlayerPrefsException(string error)
			: base(error)
		{
		}
	}
}
