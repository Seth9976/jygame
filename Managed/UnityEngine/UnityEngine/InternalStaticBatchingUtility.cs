using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace UnityEngine
{
	// Token: 0x02000304 RID: 772
	internal class InternalStaticBatchingUtility
	{
		// Token: 0x06002366 RID: 9062 RVA: 0x0000EB2D File Offset: 0x0000CD2D
		public static void CombineRoot(GameObject staticBatchRoot)
		{
			InternalStaticBatchingUtility.Combine(staticBatchRoot, false, false);
		}

		// Token: 0x06002367 RID: 9063 RVA: 0x0002E708 File Offset: 0x0002C908
		public static void Combine(GameObject staticBatchRoot, bool combineOnlyStatic, bool isEditorPostprocessScene)
		{
			GameObject[] array = (GameObject[])Object.FindObjectsOfType(typeof(GameObject));
			List<GameObject> list = new List<GameObject>();
			foreach (GameObject gameObject in array)
			{
				if (!(staticBatchRoot != null) || gameObject.transform.IsChildOf(staticBatchRoot.transform))
				{
					if (!combineOnlyStatic || gameObject.isStaticBatchable)
					{
						list.Add(gameObject);
					}
				}
			}
			array = list.ToArray();
			InternalStaticBatchingUtility.CombineGameObjects(array, staticBatchRoot, isEditorPostprocessScene);
		}

		// Token: 0x06002368 RID: 9064 RVA: 0x0002E7A4 File Offset: 0x0002C9A4
		public static void CombineGameObjects(GameObject[] gos, GameObject staticBatchRoot, bool isEditorPostprocessScene)
		{
			Matrix4x4 matrix4x = Matrix4x4.identity;
			Transform transform = null;
			if (staticBatchRoot)
			{
				matrix4x = staticBatchRoot.transform.worldToLocalMatrix;
				transform = staticBatchRoot.transform;
			}
			int num = 0;
			int num2 = 0;
			List<MeshSubsetCombineUtility.MeshInstance> list = new List<MeshSubsetCombineUtility.MeshInstance>();
			List<MeshSubsetCombineUtility.SubMeshInstance> list2 = new List<MeshSubsetCombineUtility.SubMeshInstance>();
			List<GameObject> list3 = new List<GameObject>();
			Array.Sort(gos, new InternalStaticBatchingUtility.SortGO());
			foreach (GameObject gameObject in gos)
			{
				MeshFilter meshFilter = gameObject.GetComponent(typeof(MeshFilter)) as MeshFilter;
				if (!(meshFilter == null))
				{
					Mesh sharedMesh = meshFilter.sharedMesh;
					if (!(sharedMesh == null) && (isEditorPostprocessScene || sharedMesh.canAccess))
					{
						Renderer component = meshFilter.GetComponent<Renderer>();
						if (!(component == null) && component.enabled)
						{
							if (component.staticBatchIndex == 0)
							{
								Material[] array = meshFilter.GetComponent<Renderer>().sharedMaterials;
								if (!array.Any((Material m) => m != null && m.shader != null && m.shader.disableBatching != DisableBatchingType.False))
								{
									if (num2 + meshFilter.sharedMesh.vertexCount > 64000)
									{
										InternalStaticBatchingUtility.MakeBatch(list, list2, list3, transform, num++);
										list.Clear();
										list2.Clear();
										list3.Clear();
										num2 = 0;
									}
									MeshSubsetCombineUtility.MeshInstance meshInstance = default(MeshSubsetCombineUtility.MeshInstance);
									meshInstance.meshInstanceID = sharedMesh.GetInstanceID();
									meshInstance.rendererInstanceID = component.GetInstanceID();
									MeshRenderer meshRenderer = component as MeshRenderer;
									if (meshRenderer != null && meshRenderer.additionalVertexStreams != null)
									{
										meshInstance.additionalVertexStreamsMeshInstanceID = meshRenderer.additionalVertexStreams.GetInstanceID();
									}
									meshInstance.transform = matrix4x * meshFilter.transform.localToWorldMatrix;
									meshInstance.lightmapScaleOffset = component.lightmapScaleOffset;
									meshInstance.realtimeLightmapScaleOffset = component.realtimeLightmapScaleOffset;
									list.Add(meshInstance);
									if (array.Length > sharedMesh.subMeshCount)
									{
										Debug.LogWarning(string.Concat(new object[] { "Mesh has more materials (", array.Length, ") than subsets (", sharedMesh.subMeshCount, ")" }), meshFilter.GetComponent<Renderer>());
										Material[] array2 = new Material[sharedMesh.subMeshCount];
										for (int j = 0; j < sharedMesh.subMeshCount; j++)
										{
											array2[j] = meshFilter.GetComponent<Renderer>().sharedMaterials[j];
										}
										meshFilter.GetComponent<Renderer>().sharedMaterials = array2;
										array = array2;
									}
									for (int k = 0; k < Math.Min(array.Length, sharedMesh.subMeshCount); k++)
									{
										list2.Add(new MeshSubsetCombineUtility.SubMeshInstance
										{
											meshInstanceID = meshFilter.sharedMesh.GetInstanceID(),
											vertexOffset = num2,
											subMeshIndex = k,
											gameObjectInstanceID = gameObject.GetInstanceID(),
											transform = meshInstance.transform
										});
										list3.Add(gameObject);
									}
									num2 += sharedMesh.vertexCount;
								}
							}
						}
					}
				}
			}
			InternalStaticBatchingUtility.MakeBatch(list, list2, list3, transform, num);
		}

		// Token: 0x06002369 RID: 9065 RVA: 0x0002EB08 File Offset: 0x0002CD08
		private static void MakeBatch(List<MeshSubsetCombineUtility.MeshInstance> meshes, List<MeshSubsetCombineUtility.SubMeshInstance> subsets, List<GameObject> subsetGOs, Transform staticBatchRootTransform, int batchIndex)
		{
			if (meshes.Count < 2)
			{
				return;
			}
			MeshSubsetCombineUtility.MeshInstance[] array = meshes.ToArray();
			MeshSubsetCombineUtility.SubMeshInstance[] array2 = subsets.ToArray();
			string text = "Combined Mesh";
			text = text + " (root: " + ((!(staticBatchRootTransform != null)) ? "scene" : staticBatchRootTransform.name) + ")";
			if (batchIndex > 0)
			{
				text = text + " " + (batchIndex + 1);
			}
			Mesh mesh = StaticBatchingUtility.InternalCombineVertices(array, text);
			StaticBatchingUtility.InternalCombineIndices(array2, mesh);
			int num = 0;
			for (int i = 0; i < array2.Length; i++)
			{
				MeshSubsetCombineUtility.SubMeshInstance subMeshInstance = array2[i];
				GameObject gameObject = subsetGOs[i];
				Mesh mesh2 = mesh;
				MeshFilter meshFilter = (MeshFilter)gameObject.GetComponent(typeof(MeshFilter));
				meshFilter.sharedMesh = mesh2;
				Renderer component = gameObject.GetComponent<Renderer>();
				component.SetSubsetIndex(subMeshInstance.subMeshIndex, num);
				component.staticBatchRootTransform = staticBatchRootTransform;
				component.enabled = false;
				component.enabled = true;
				MeshRenderer meshRenderer = component as MeshRenderer;
				if (meshRenderer != null)
				{
					meshRenderer.additionalVertexStreams = null;
				}
				num++;
			}
		}

		// Token: 0x04000BB4 RID: 2996
		private const int MaxVerticesInBatch = 64000;

		// Token: 0x04000BB5 RID: 2997
		private const string CombinedMeshPrefix = "Combined Mesh";

		// Token: 0x02000305 RID: 773
		internal class SortGO : IComparer
		{
			// Token: 0x0600236C RID: 9068 RVA: 0x0002EC3C File Offset: 0x0002CE3C
			int IComparer.Compare(object a, object b)
			{
				if (a == b)
				{
					return 0;
				}
				Renderer renderer = InternalStaticBatchingUtility.SortGO.GetRenderer(a as GameObject);
				Renderer renderer2 = InternalStaticBatchingUtility.SortGO.GetRenderer(b as GameObject);
				int num = InternalStaticBatchingUtility.SortGO.GetMaterialId(renderer).CompareTo(InternalStaticBatchingUtility.SortGO.GetMaterialId(renderer2));
				if (num == 0)
				{
					num = InternalStaticBatchingUtility.SortGO.GetLightmapIndex(renderer).CompareTo(InternalStaticBatchingUtility.SortGO.GetLightmapIndex(renderer2));
				}
				return num;
			}

			// Token: 0x0600236D RID: 9069 RVA: 0x0000EB6A File Offset: 0x0000CD6A
			private static int GetMaterialId(Renderer renderer)
			{
				if (renderer == null || renderer.sharedMaterial == null)
				{
					return 0;
				}
				return renderer.sharedMaterial.GetInstanceID();
			}

			// Token: 0x0600236E RID: 9070 RVA: 0x0000EB96 File Offset: 0x0000CD96
			private static int GetLightmapIndex(Renderer renderer)
			{
				if (renderer == null)
				{
					return -1;
				}
				return renderer.lightmapIndex;
			}

			// Token: 0x0600236F RID: 9071 RVA: 0x0002EC9C File Offset: 0x0002CE9C
			private static Renderer GetRenderer(GameObject go)
			{
				if (go == null)
				{
					return null;
				}
				MeshFilter meshFilter = go.GetComponent(typeof(MeshFilter)) as MeshFilter;
				if (meshFilter == null)
				{
					return null;
				}
				return meshFilter.GetComponent<Renderer>();
			}
		}
	}
}
