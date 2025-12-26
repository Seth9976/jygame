using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	// Token: 0x0200007F RID: 127
	internal sealed class RuntimeUndo
	{
		// Token: 0x060007BE RID: 1982
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetTransformParent(Transform transform, Transform newParent, string name);

		// Token: 0x060007BF RID: 1983
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RecordObject(Object objectToUndo, string name);

		// Token: 0x060007C0 RID: 1984
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RecordObjects(Object[] objectsToUndo, string name);
	}
}
