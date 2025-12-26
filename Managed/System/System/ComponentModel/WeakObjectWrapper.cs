using System;

namespace System.ComponentModel
{
	// Token: 0x020001C8 RID: 456
	internal sealed class WeakObjectWrapper
	{
		// Token: 0x06000FF0 RID: 4080 RVA: 0x0000CFD0 File Offset: 0x0000B1D0
		public WeakObjectWrapper(object target)
		{
			this.TargetHashCode = target.GetHashCode();
			this.Weak = new WeakReference(target);
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000FF1 RID: 4081 RVA: 0x0000CFF0 File Offset: 0x0000B1F0
		// (set) Token: 0x06000FF2 RID: 4082 RVA: 0x0000CFF8 File Offset: 0x0000B1F8
		public int TargetHashCode { get; private set; }

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x0000D001 File Offset: 0x0000B201
		// (set) Token: 0x06000FF4 RID: 4084 RVA: 0x0000D009 File Offset: 0x0000B209
		public WeakReference Weak { get; private set; }
	}
}
