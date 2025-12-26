using System;

namespace UnityEngine.Rendering
{
	/// <summary>
	///   <para>When a probe's ReflectionProbe.refreshMode is set to ReflectionProbeRefreshMode.EveryFrame, this enum specify whether or not Unity should update the probe's cubemap over several frames or update the whole cubemap in one frame.
	/// Updating a probe's cubemap is a costly operation. Unity needs to render the entire scene for each face of the cubemap, as well as perform special blurring in order to get glossy reflections. The impact on frame rate can be significant. Time-slicing helps maintaning a more constant frame rate during these updates by performing the rendering over several frames.</para>
	/// </summary>
	// Token: 0x02000296 RID: 662
	public enum ReflectionProbeTimeSlicingMode
	{
		/// <summary>
		///   <para>Instructs Unity to use time-slicing by first rendering all faces at once, then spreading the remaining work over the next 8 frames. Using this option, updating the probe will take 9 frames.</para>
		/// </summary>
		// Token: 0x04000A79 RID: 2681
		AllFacesAtOnce,
		/// <summary>
		///   <para>Instructs Unity to spread the rendering of each face over several frames. Using this option, updating the cubemap will take 14 frames. This option greatly reduces the impact on frame rate, however it may produce incorrect results, especially in scenes where lighting conditions change over these 14 frames.</para>
		/// </summary>
		// Token: 0x04000A7A RID: 2682
		IndividualFaces,
		/// <summary>
		///   <para>Unity will render the probe entirely in one frame.</para>
		/// </summary>
		// Token: 0x04000A7B RID: 2683
		NoTimeSlicing
	}
}
