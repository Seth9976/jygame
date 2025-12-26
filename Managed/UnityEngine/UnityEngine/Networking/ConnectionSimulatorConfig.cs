using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Networking
{
	/// <summary>
	///   <para>Create configuration for network simulator; You can use this class in editor and developer build only.</para>
	/// </summary>
	// Token: 0x02000224 RID: 548
	public sealed class ConnectionSimulatorConfig : IDisposable
	{
		/// <summary>
		///   <para>Will create object describing network simulation parameters.</para>
		/// </summary>
		/// <param name="outMinDelay">Minimal simulation delay for outgoing traffic in ms.</param>
		/// <param name="outAvgDelay">Average simulation delay for outgoing traffic in ms.</param>
		/// <param name="inMinDelay">Minimal  simulation delay for incoming traffic in ms.</param>
		/// <param name="inAvgDelay">Average  simulation delay for incoming traffic in ms.</param>
		/// <param name="packetLossPercentage">Probability of packet loss  0 &lt;= p &lt;= 1.</param>
		// Token: 0x06001F54 RID: 8020
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern ConnectionSimulatorConfig(int outMinDelay, int outAvgDelay, int inMinDelay, int inAvgDelay, float packetLossPercentage);

		/// <summary>
		///   <para>Destructor.</para>
		/// </summary>
		// Token: 0x06001F55 RID: 8021
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Dispose();

		// Token: 0x06001F56 RID: 8022 RVA: 0x000262C8 File Offset: 0x000244C8
		~ConnectionSimulatorConfig()
		{
			this.Dispose();
		}

		// Token: 0x04000897 RID: 2199
		internal IntPtr m_Ptr;
	}
}
