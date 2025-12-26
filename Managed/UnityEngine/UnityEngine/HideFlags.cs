using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Bit mask that controls object destruction, saving and visibility in inspectors.</para>
	/// </summary>
	// Token: 0x020000C5 RID: 197
	[Flags]
	public enum HideFlags
	{
		/// <summary>
		///   <para>A normal, visible object. This is the default.</para>
		/// </summary>
		// Token: 0x04000251 RID: 593
		None = 0,
		/// <summary>
		///   <para>The object will not appear in the hierarchy.</para>
		/// </summary>
		// Token: 0x04000252 RID: 594
		HideInHierarchy = 1,
		/// <summary>
		///   <para>It is not possible to view it in the inspector.</para>
		/// </summary>
		// Token: 0x04000253 RID: 595
		HideInInspector = 2,
		/// <summary>
		///   <para>The object will not be saved to the scene in the editor.</para>
		/// </summary>
		// Token: 0x04000254 RID: 596
		DontSaveInEditor = 4,
		/// <summary>
		///   <para>The object is not be editable in the inspector.</para>
		/// </summary>
		// Token: 0x04000255 RID: 597
		NotEditable = 8,
		/// <summary>
		///   <para>The object will not be saved when building a player.</para>
		/// </summary>
		// Token: 0x04000256 RID: 598
		DontSaveInBuild = 16,
		/// <summary>
		///   <para>The object will not be unloaded by Resources.UnloadUnusedAssets.</para>
		/// </summary>
		// Token: 0x04000257 RID: 599
		DontUnloadUnusedAsset = 32,
		/// <summary>
		///   <para>The object will not be saved to the scene. It will not be destroyed when a new scene is loaded. It is a shortcut for HideFlags.DontSaveInBuild | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset.</para>
		/// </summary>
		// Token: 0x04000258 RID: 600
		DontSave = 52,
		/// <summary>
		///   <para>A combination of not shown in the hierarchy, not saved to to scenes and not unloaded by The object will not be unloaded by Resources.UnloadUnusedAssets.</para>
		/// </summary>
		// Token: 0x04000259 RID: 601
		HideAndDontSave = 61
	}
}
