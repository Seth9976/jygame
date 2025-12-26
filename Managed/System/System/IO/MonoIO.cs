using System;
using System.Runtime.CompilerServices;

namespace System.IO
{
	// Token: 0x0200029C RID: 668
	internal sealed class MonoIO
	{
		// Token: 0x0600171C RID: 5916
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Close(IntPtr handle, out MonoIOError error);

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x0600171D RID: 5917
		public static extern IntPtr ConsoleOutput
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x0600171E RID: 5918
		public static extern IntPtr ConsoleInput
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x0600171F RID: 5919
		public static extern IntPtr ConsoleError
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x06001720 RID: 5920
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool CreatePipe(out IntPtr read_handle, out IntPtr write_handle);

		// Token: 0x06001721 RID: 5921
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool DuplicateHandle(IntPtr source_process_handle, IntPtr source_handle, IntPtr target_process_handle, out IntPtr target_handle, int access, int inherit, int options);

		// Token: 0x06001722 RID: 5922
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetTempPath(out string path);
	}
}
