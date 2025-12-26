using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Diagnostics
{
	/// <summary>Prepares performance data for the performance.dll the system loads when working with performance counters.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x02000240 RID: 576
	[ComVisible(true)]
	[global::System.MonoTODO("not implemented")]
	[Guid("82840be1-d273-11d2-b94a-00600893b17a")]
	[Obsolete("use PerformanceCounter")]
	[PermissionSet((SecurityAction)14, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\nversion=\"1\"\nUnrestricted=\"true\"/>\n")]
	public sealed class PerformanceCounterManager : ICollectData
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.PerformanceCounterManager" /> class.</summary>
		// Token: 0x060013DC RID: 5084 RVA: 0x000021C3 File Offset: 0x000003C3
		[Obsolete("use PerformanceCounter")]
		public PerformanceCounterManager()
		{
		}

		/// <summary>Called by the perf dll's close performance data </summary>
		// Token: 0x060013DD RID: 5085 RVA: 0x00002664 File Offset: 0x00000864
		void ICollectData.CloseData()
		{
			throw new NotImplementedException();
		}

		/// <summary>Performance data collection routine. Called by the PerfCount perf dll.</summary>
		/// <param name="callIdx">The call index. </param>
		/// <param name="valueNamePtr">A pointer to a Unicode string list with the requested Object identifiers.</param>
		/// <param name="dataPtr">A pointer to the data buffer.</param>
		/// <param name="totalBytes">A pointer to a number of bytes.</param>
		/// <param name="res">When this method returns, contains a <see cref="T:System.IntPtr" /> with a value of -1.</param>
		// Token: 0x060013DE RID: 5086 RVA: 0x00002664 File Offset: 0x00000864
		void ICollectData.CollectData(int callIdx, IntPtr valueNamePtr, IntPtr dataPtr, int totalBytes, out IntPtr res)
		{
			throw new NotImplementedException();
		}
	}
}
