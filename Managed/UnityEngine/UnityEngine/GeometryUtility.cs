using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Utility class for common geometric functions.</para>
	/// </summary>
	// Token: 0x02000033 RID: 51
	public sealed class GeometryUtility
	{
		/// <summary>
		///   <para>Calculates frustum planes.</para>
		/// </summary>
		/// <param name="camera"></param>
		// Token: 0x0600028A RID: 650 RVA: 0x00002764 File Offset: 0x00000964
		public static Plane[] CalculateFrustumPlanes(Camera camera)
		{
			return GeometryUtility.CalculateFrustumPlanes(camera.projectionMatrix * camera.worldToCameraMatrix);
		}

		/// <summary>
		///   <para>Calculates frustum planes.</para>
		/// </summary>
		/// <param name="worldToProjectionMatrix"></param>
		// Token: 0x0600028B RID: 651 RVA: 0x0000FB44 File Offset: 0x0000DD44
		public static Plane[] CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix)
		{
			Plane[] array = new Plane[6];
			GeometryUtility.Internal_ExtractPlanes(array, worldToProjectionMatrix);
			return array;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000277C File Offset: 0x0000097C
		private static void Internal_ExtractPlanes(Plane[] planes, Matrix4x4 worldToProjectionMatrix)
		{
			GeometryUtility.INTERNAL_CALL_Internal_ExtractPlanes(planes, ref worldToProjectionMatrix);
		}

		// Token: 0x0600028D RID: 653
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_ExtractPlanes(Plane[] planes, ref Matrix4x4 worldToProjectionMatrix);

		/// <summary>
		///   <para>Returns true if bounds are inside the plane array.</para>
		/// </summary>
		/// <param name="planes"></param>
		/// <param name="bounds"></param>
		// Token: 0x0600028E RID: 654 RVA: 0x00002786 File Offset: 0x00000986
		public static bool TestPlanesAABB(Plane[] planes, Bounds bounds)
		{
			return GeometryUtility.INTERNAL_CALL_TestPlanesAABB(planes, ref bounds);
		}

		// Token: 0x0600028F RID: 655
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_TestPlanesAABB(Plane[] planes, ref Bounds bounds);
	}
}
