using System;
using System.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine.UI
{
	// Token: 0x02000077 RID: 119
	public static class StencilMaterial
	{
		// Token: 0x0600043F RID: 1087 RVA: 0x0001408C File Offset: 0x0001228C
		[Obsolete("Use Material.Add instead.", true)]
		public static Material Add(Material baseMat, int stencilID)
		{
			return null;
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00014090 File Offset: 0x00012290
		public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask)
		{
			return StencilMaterial.Add(baseMat, stencilID, operation, compareFunction, colorWriteMask, 255, 255);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x000140A8 File Offset: 0x000122A8
		public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask)
		{
			if ((stencilID <= 0 && colorWriteMask == ColorWriteMask.All) || baseMat == null)
			{
				return baseMat;
			}
			if (!baseMat.HasProperty("_Stencil"))
			{
				Debug.LogWarning("Material " + baseMat.name + " doesn't have _Stencil property", baseMat);
				return baseMat;
			}
			if (!baseMat.HasProperty("_StencilOp"))
			{
				Debug.LogWarning("Material " + baseMat.name + " doesn't have _StencilOp property", baseMat);
				return baseMat;
			}
			if (!baseMat.HasProperty("_StencilComp"))
			{
				Debug.LogWarning("Material " + baseMat.name + " doesn't have _StencilComp property", baseMat);
				return baseMat;
			}
			if (!baseMat.HasProperty("_StencilReadMask"))
			{
				Debug.LogWarning("Material " + baseMat.name + " doesn't have _StencilReadMask property", baseMat);
				return baseMat;
			}
			if (!baseMat.HasProperty("_StencilReadMask"))
			{
				Debug.LogWarning("Material " + baseMat.name + " doesn't have _StencilWriteMask property", baseMat);
				return baseMat;
			}
			if (!baseMat.HasProperty("_ColorMask"))
			{
				Debug.LogWarning("Material " + baseMat.name + " doesn't have _ColorMask property", baseMat);
				return baseMat;
			}
			for (int i = 0; i < StencilMaterial.m_List.Count; i++)
			{
				StencilMaterial.MatEntry matEntry = StencilMaterial.m_List[i];
				if (matEntry.baseMat == baseMat && matEntry.stencilId == stencilID && matEntry.operation == operation && matEntry.compareFunction == compareFunction && matEntry.readMask == readMask && matEntry.writeMask == writeMask && matEntry.colorMask == colorWriteMask)
				{
					matEntry.count++;
					return matEntry.customMat;
				}
			}
			StencilMaterial.MatEntry matEntry2 = new StencilMaterial.MatEntry();
			matEntry2.count = 1;
			matEntry2.baseMat = baseMat;
			matEntry2.customMat = new Material(baseMat);
			matEntry2.customMat.hideFlags = HideFlags.HideAndDontSave;
			matEntry2.stencilId = stencilID;
			matEntry2.operation = operation;
			matEntry2.compareFunction = compareFunction;
			matEntry2.readMask = readMask;
			matEntry2.writeMask = writeMask;
			matEntry2.colorMask = colorWriteMask;
			matEntry2.useAlphaClip = operation != StencilOp.Keep && writeMask > 0;
			matEntry2.customMat.name = string.Format("Stencil Id:{0}, Op:{1}, Comp:{2}, WriteMask:{3}, ReadMask:{4}, ColorMask:{5} AlphaClip:{6} ({7})", new object[] { stencilID, operation, compareFunction, writeMask, readMask, colorWriteMask, matEntry2.useAlphaClip, baseMat.name });
			matEntry2.customMat.SetInt("_Stencil", stencilID);
			matEntry2.customMat.SetInt("_StencilOp", (int)operation);
			matEntry2.customMat.SetInt("_StencilComp", (int)compareFunction);
			matEntry2.customMat.SetInt("_StencilReadMask", readMask);
			matEntry2.customMat.SetInt("_StencilWriteMask", writeMask);
			matEntry2.customMat.SetInt("_ColorMask", (int)colorWriteMask);
			matEntry2.customMat.SetInt("_UseAlphaClip", (!matEntry2.useAlphaClip) ? 0 : 1);
			StencilMaterial.m_List.Add(matEntry2);
			return matEntry2.customMat;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x000143F0 File Offset: 0x000125F0
		public static void Remove(Material customMat)
		{
			if (customMat == null)
			{
				return;
			}
			for (int i = 0; i < StencilMaterial.m_List.Count; i++)
			{
				StencilMaterial.MatEntry matEntry = StencilMaterial.m_List[i];
				if (!(matEntry.customMat != customMat))
				{
					if (--matEntry.count == 0)
					{
						Misc.DestroyImmediate(matEntry.customMat);
						matEntry.baseMat = null;
						StencilMaterial.m_List.RemoveAt(i);
					}
					return;
				}
			}
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0001447C File Offset: 0x0001267C
		public static void ClearAll()
		{
			for (int i = 0; i < StencilMaterial.m_List.Count; i++)
			{
				StencilMaterial.MatEntry matEntry = StencilMaterial.m_List[i];
				Misc.DestroyImmediate(matEntry.customMat);
				matEntry.baseMat = null;
			}
			StencilMaterial.m_List.Clear();
		}

		// Token: 0x04000219 RID: 537
		private static List<StencilMaterial.MatEntry> m_List = new List<StencilMaterial.MatEntry>();

		// Token: 0x02000078 RID: 120
		private class MatEntry
		{
			// Token: 0x0400021A RID: 538
			public Material baseMat;

			// Token: 0x0400021B RID: 539
			public Material customMat;

			// Token: 0x0400021C RID: 540
			public int count;

			// Token: 0x0400021D RID: 541
			public int stencilId;

			// Token: 0x0400021E RID: 542
			public StencilOp operation;

			// Token: 0x0400021F RID: 543
			public CompareFunction compareFunction = CompareFunction.Always;

			// Token: 0x04000220 RID: 544
			public int readMask;

			// Token: 0x04000221 RID: 545
			public int writeMask;

			// Token: 0x04000222 RID: 546
			public bool useAlphaClip;

			// Token: 0x04000223 RID: 547
			public ColorWriteMask colorMask;
		}
	}
}
