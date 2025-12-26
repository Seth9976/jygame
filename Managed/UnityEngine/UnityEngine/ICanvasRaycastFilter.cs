using System;

namespace UnityEngine
{
	// Token: 0x020001BC RID: 444
	public interface ICanvasRaycastFilter
	{
		/// <summary>
		///   <para>Given a point and a camera is the raycast valid.</para>
		/// </summary>
		/// <param name="sp">Screen position.</param>
		/// <param name="eventCamera">Raycast camera.</param>
		/// <returns>
		///   <para>Valid.</para>
		/// </returns>
		// Token: 0x06001998 RID: 6552
		bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera);
	}
}
