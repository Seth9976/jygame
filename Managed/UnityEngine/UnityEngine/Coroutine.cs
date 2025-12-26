using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>MonoBehaviour.StartCoroutine returns a Coroutine. Instances of this class are only used to reference these coroutines and do not hold any exposed properties or functions.</para>
	/// </summary>
	// Token: 0x02000011 RID: 17
	[StructLayout(LayoutKind.Sequential)]
	public sealed class Coroutine : YieldInstruction
	{
		// Token: 0x0600005D RID: 93 RVA: 0x000021F3 File Offset: 0x000003F3
		private Coroutine()
		{
		}

		// Token: 0x0600005E RID: 94
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void ReleaseCoroutine();

		// Token: 0x0600005F RID: 95 RVA: 0x0000ED38 File Offset: 0x0000CF38
		~Coroutine()
		{
			this.ReleaseCoroutine();
		}

		// Token: 0x04000068 RID: 104
		internal IntPtr m_Ptr;
	}
}
