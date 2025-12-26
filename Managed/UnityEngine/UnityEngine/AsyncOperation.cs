using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Asynchronous operation coroutine.</para>
	/// </summary>
	// Token: 0x020000A5 RID: 165
	[StructLayout(LayoutKind.Sequential)]
	public class AsyncOperation : YieldInstruction
	{
		// Token: 0x06000948 RID: 2376
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void InternalDestroy();

		// Token: 0x06000949 RID: 2377 RVA: 0x000167A4 File Offset: 0x000149A4
		~AsyncOperation()
		{
			this.InternalDestroy();
		}

		/// <summary>
		///   <para>Has the operation finished? (Read Only)</para>
		/// </summary>
		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600094A RID: 2378
		public extern bool isDone
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>What's the operation's progress. (Read Only)</para>
		/// </summary>
		// Token: 0x17000223 RID: 547
		// (get) Token: 0x0600094B RID: 2379
		public extern float progress
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Priority lets you tweak in which order async operation calls will be performed.</para>
		/// </summary>
		// Token: 0x17000224 RID: 548
		// (get) Token: 0x0600094C RID: 2380
		// (set) Token: 0x0600094D RID: 2381
		public extern int priority
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Allow scenes to be activated as soon as it is ready.</para>
		/// </summary>
		// Token: 0x17000225 RID: 549
		// (get) Token: 0x0600094E RID: 2382
		// (set) Token: 0x0600094F RID: 2383
		public extern bool allowSceneActivation
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x040001FB RID: 507
		internal IntPtr m_Ptr;
	}
}
