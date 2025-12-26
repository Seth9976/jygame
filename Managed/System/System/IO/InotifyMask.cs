using System;

namespace System.IO
{
	// Token: 0x0200028E RID: 654
	[Flags]
	internal enum InotifyMask : uint
	{
		// Token: 0x04000758 RID: 1880
		Access = 1U,
		// Token: 0x04000759 RID: 1881
		Modify = 2U,
		// Token: 0x0400075A RID: 1882
		Attrib = 4U,
		// Token: 0x0400075B RID: 1883
		CloseWrite = 8U,
		// Token: 0x0400075C RID: 1884
		CloseNoWrite = 16U,
		// Token: 0x0400075D RID: 1885
		Open = 32U,
		// Token: 0x0400075E RID: 1886
		MovedFrom = 64U,
		// Token: 0x0400075F RID: 1887
		MovedTo = 128U,
		// Token: 0x04000760 RID: 1888
		Create = 256U,
		// Token: 0x04000761 RID: 1889
		Delete = 512U,
		// Token: 0x04000762 RID: 1890
		DeleteSelf = 1024U,
		// Token: 0x04000763 RID: 1891
		MoveSelf = 2048U,
		// Token: 0x04000764 RID: 1892
		BaseEvents = 4095U,
		// Token: 0x04000765 RID: 1893
		Umount = 8192U,
		// Token: 0x04000766 RID: 1894
		Overflow = 16384U,
		// Token: 0x04000767 RID: 1895
		Ignored = 32768U,
		// Token: 0x04000768 RID: 1896
		OnlyDir = 16777216U,
		// Token: 0x04000769 RID: 1897
		DontFollow = 33554432U,
		// Token: 0x0400076A RID: 1898
		AddMask = 536870912U,
		// Token: 0x0400076B RID: 1899
		Directory = 1073741824U,
		// Token: 0x0400076C RID: 1900
		OneShot = 2147483648U
	}
}
