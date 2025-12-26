using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Text file assets.</para>
	/// </summary>
	// Token: 0x02000080 RID: 128
	public class TextAsset : Object
	{
		/// <summary>
		///   <para>The text contents of the .txt file as a string. (Read Only)</para>
		/// </summary>
		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060007C2 RID: 1986
		public extern string text
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The raw bytes of the text asset. (Read Only)</para>
		/// </summary>
		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060007C3 RID: 1987
		public extern byte[] bytes
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x0000518E File Offset: 0x0000338E
		public override string ToString()
		{
			return this.text;
		}
	}
}
