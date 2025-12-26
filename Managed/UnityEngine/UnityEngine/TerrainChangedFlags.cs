using System;

namespace UnityEngine
{
	// Token: 0x020001A8 RID: 424
	[Flags]
	internal enum TerrainChangedFlags
	{
		// Token: 0x04000526 RID: 1318
		NoChange = 0,
		// Token: 0x04000527 RID: 1319
		Heightmap = 1,
		// Token: 0x04000528 RID: 1320
		TreeInstances = 2,
		// Token: 0x04000529 RID: 1321
		DelayedHeightmapUpdate = 4,
		// Token: 0x0400052A RID: 1322
		FlushEverythingImmediately = 8,
		// Token: 0x0400052B RID: 1323
		RemoveDirtyDetailsImmediately = 16,
		// Token: 0x0400052C RID: 1324
		WillBeDestroyed = 256
	}
}
