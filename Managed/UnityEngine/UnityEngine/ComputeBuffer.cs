using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace UnityEngine
{
	/// <summary>
	///   <para>Data buffer to hold data for compute shaders.</para>
	/// </summary>
	// Token: 0x020000B1 RID: 177
	public sealed class ComputeBuffer : IDisposable
	{
		/// <summary>
		///   <para>Create a Compute Buffer.</para>
		/// </summary>
		/// <param name="count">Number of elements in the buffer.</param>
		/// <param name="stride">Size of one element in the buffer. Has to match size of buffer type in the shader. See for cross-platform compatibility information.</param>
		/// <param name="type">Type of the buffer, default is ComputeBufferType.Default.</param>
		// Token: 0x06000A64 RID: 2660 RVA: 0x00005ABB File Offset: 0x00003CBB
		public ComputeBuffer(int count, int stride)
			: this(count, stride, ComputeBufferType.Default)
		{
		}

		/// <summary>
		///   <para>Create a Compute Buffer.</para>
		/// </summary>
		/// <param name="count">Number of elements in the buffer.</param>
		/// <param name="stride">Size of one element in the buffer. Has to match size of buffer type in the shader. See for cross-platform compatibility information.</param>
		/// <param name="type">Type of the buffer, default is ComputeBufferType.Default.</param>
		// Token: 0x06000A65 RID: 2661 RVA: 0x00005AC6 File Offset: 0x00003CC6
		public ComputeBuffer(int count, int stride, ComputeBufferType type)
		{
			this.m_Ptr = IntPtr.Zero;
			ComputeBuffer.InitBuffer(this, count, stride, type);
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x00016CA4 File Offset: 0x00014EA4
		~ComputeBuffer()
		{
			this.Dispose(false);
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x00005AE2 File Offset: 0x00003CE2
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x00005AF1 File Offset: 0x00003CF1
		private void Dispose(bool disposing)
		{
			ComputeBuffer.DestroyBuffer(this);
			this.m_Ptr = IntPtr.Zero;
		}

		// Token: 0x06000A69 RID: 2665
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void InitBuffer(ComputeBuffer buf, int count, int stride, ComputeBufferType type);

		// Token: 0x06000A6A RID: 2666
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void DestroyBuffer(ComputeBuffer buf);

		/// <summary>
		///   <para>Release a Compute Buffer.</para>
		/// </summary>
		// Token: 0x06000A6B RID: 2667 RVA: 0x00005B04 File Offset: 0x00003D04
		public void Release()
		{
			this.Dispose();
		}

		/// <summary>
		///   <para>Number of elements in the buffer (Read Only).</para>
		/// </summary>
		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000A6C RID: 2668
		public extern int count
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Size of one element in the buffer (Read Only).</para>
		/// </summary>
		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000A6D RID: 2669
		public extern int stride
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Set the buffer with values from an array.</para>
		/// </summary>
		/// <param name="data">Array of values to fill the buffer.</param>
		// Token: 0x06000A6E RID: 2670 RVA: 0x00005B0C File Offset: 0x00003D0C
		[SecuritySafeCritical]
		public void SetData(Array data)
		{
			this.InternalSetData(data, Marshal.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x06000A6F RID: 2671
		[SecurityCritical]
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void InternalSetData(Array data, int elemSize);

		/// <summary>
		///   <para>Read data values from the buffer into an array.</para>
		/// </summary>
		/// <param name="data">An array to receive the data.</param>
		// Token: 0x06000A70 RID: 2672 RVA: 0x00005B25 File Offset: 0x00003D25
		[SecuritySafeCritical]
		public void GetData(Array data)
		{
			this.InternalGetData(data, Marshal.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x06000A71 RID: 2673
		[SecurityCritical]
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void InternalGetData(Array data, int elemSize);

		/// <summary>
		///   <para>Copy counter value of append/consume buffer into another buffer.</para>
		/// </summary>
		/// <param name="src">Append/consume buffer to copy the counter from.</param>
		/// <param name="dst">A buffer to copy the counter to.</param>
		/// <param name="dstOffset">Target byte offset in dst.</param>
		// Token: 0x06000A72 RID: 2674
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CopyCount(ComputeBuffer src, ComputeBuffer dst, int dstOffset);

		// Token: 0x04000216 RID: 534
		internal IntPtr m_Ptr;
	}
}
