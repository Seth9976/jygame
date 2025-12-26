using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>A path as calculated by the navigation system.</para>
	/// </summary>
	// Token: 0x02000148 RID: 328
	[StructLayout(LayoutKind.Sequential)]
	public sealed class NavMeshPath
	{
		/// <summary>
		///   <para>NavMeshPath constructor.</para>
		/// </summary>
		// Token: 0x060013E4 RID: 5092
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern NavMeshPath();

		// Token: 0x060013E5 RID: 5093
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void DestroyNavMeshPath();

		// Token: 0x060013E6 RID: 5094 RVA: 0x0001A2FC File Offset: 0x000184FC
		~NavMeshPath()
		{
			this.DestroyNavMeshPath();
			this.m_Ptr = IntPtr.Zero;
		}

		/// <summary>
		///   <para>Calculate the corners for the path.</para>
		/// </summary>
		/// <param name="results">Array to store path corners.</param>
		/// <returns>
		///   <para>The number of corners along the path - including start and end points.</para>
		/// </returns>
		// Token: 0x060013E7 RID: 5095
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetCornersNonAlloc(Vector3[] results);

		// Token: 0x060013E8 RID: 5096
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Vector3[] CalculateCornersInternal();

		// Token: 0x060013E9 RID: 5097
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void ClearCornersInternal();

		/// <summary>
		///   <para>Erase all corner points from path.</para>
		/// </summary>
		// Token: 0x060013EA RID: 5098 RVA: 0x00007BD7 File Offset: 0x00005DD7
		public void ClearCorners()
		{
			this.ClearCornersInternal();
			this.m_corners = null;
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x00007BE6 File Offset: 0x00005DE6
		private void CalculateCorners()
		{
			if (this.m_corners == null)
			{
				this.m_corners = this.CalculateCornersInternal();
			}
		}

		/// <summary>
		///   <para>Corner points of the path. (Read Only)</para>
		/// </summary>
		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x060013EC RID: 5100 RVA: 0x00007BFF File Offset: 0x00005DFF
		public Vector3[] corners
		{
			get
			{
				this.CalculateCorners();
				return this.m_corners;
			}
		}

		/// <summary>
		///   <para>Status of the path. (Read Only)</para>
		/// </summary>
		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x060013ED RID: 5101
		public extern NavMeshPathStatus status
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x04000384 RID: 900
		internal IntPtr m_Ptr;

		// Token: 0x04000385 RID: 901
		internal Vector3[] m_corners;
	}
}
