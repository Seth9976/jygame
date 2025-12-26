using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Describes different types of camera.</para>
	/// </summary>
	// Token: 0x02000263 RID: 611
	[Flags]
	public enum CameraType
	{
		/// <summary>
		///   <para>Used to indicate a regular in-game camera.</para>
		/// </summary>
		// Token: 0x040008F6 RID: 2294
		Game = 1,
		/// <summary>
		///   <para>Used to indicate that a camera is used for rendering the Scene View in the Editor.</para>
		/// </summary>
		// Token: 0x040008F7 RID: 2295
		SceneView = 2,
		/// <summary>
		///   <para>Used to indicate a camera that is used for rendering previews in the Editor.</para>
		/// </summary>
		// Token: 0x040008F8 RID: 2296
		Preview = 4
	}
}
