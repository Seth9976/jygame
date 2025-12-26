using System;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Asynchronous load request from the Resources bundle.</para>
	/// </summary>
	// Token: 0x0200007D RID: 125
	[StructLayout(LayoutKind.Sequential)]
	public sealed class ResourceRequest : AsyncOperation
	{
		/// <summary>
		///   <para>Asset object being loaded (Read Only).</para>
		/// </summary>
		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060007AB RID: 1963 RVA: 0x000050D8 File Offset: 0x000032D8
		public Object asset
		{
			get
			{
				return Resources.Load(this.m_Path, this.m_Type);
			}
		}

		// Token: 0x04000179 RID: 377
		internal string m_Path;

		// Token: 0x0400017A RID: 378
		internal Type m_Type;
	}
}
