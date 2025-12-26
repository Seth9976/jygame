using System;

namespace System.IO
{
	// Token: 0x0200028F RID: 655
	internal struct InotifyEvent
	{
		// Token: 0x060016E2 RID: 5858 RVA: 0x000114A3 File Offset: 0x0000F6A3
		public override string ToString()
		{
			return string.Format("[Descriptor: {0} Mask: {1} Name: {2}]", this.WatchDescriptor, this.Mask, this.Name);
		}

		// Token: 0x0400076D RID: 1901
		public static readonly InotifyEvent Default = default(InotifyEvent);

		// Token: 0x0400076E RID: 1902
		public int WatchDescriptor;

		// Token: 0x0400076F RID: 1903
		public InotifyMask Mask;

		// Token: 0x04000770 RID: 1904
		public string Name;
	}
}
