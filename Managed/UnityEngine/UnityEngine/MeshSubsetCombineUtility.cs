using System;

namespace UnityEngine
{
	// Token: 0x02000306 RID: 774
	internal class MeshSubsetCombineUtility
	{
		// Token: 0x02000307 RID: 775
		public struct MeshInstance
		{
			// Token: 0x04000BB7 RID: 2999
			public int meshInstanceID;

			// Token: 0x04000BB8 RID: 3000
			public int rendererInstanceID;

			// Token: 0x04000BB9 RID: 3001
			public int additionalVertexStreamsMeshInstanceID;

			// Token: 0x04000BBA RID: 3002
			public Matrix4x4 transform;

			// Token: 0x04000BBB RID: 3003
			public Vector4 lightmapScaleOffset;

			// Token: 0x04000BBC RID: 3004
			public Vector4 realtimeLightmapScaleOffset;
		}

		// Token: 0x02000308 RID: 776
		public struct SubMeshInstance
		{
			// Token: 0x04000BBD RID: 3005
			public int meshInstanceID;

			// Token: 0x04000BBE RID: 3006
			public int vertexOffset;

			// Token: 0x04000BBF RID: 3007
			public int gameObjectInstanceID;

			// Token: 0x04000BC0 RID: 3008
			public int subMeshIndex;

			// Token: 0x04000BC1 RID: 3009
			public Matrix4x4 transform;
		}
	}
}
