using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Ping any given IP address (given in dot notation).</para>
	/// </summary>
	// Token: 0x0200006E RID: 110
	public sealed class Ping
	{
		/// <summary>
		///   <para>Perform a ping to the supplied target IP address.</para>
		/// </summary>
		/// <param name="address"></param>
		// Token: 0x0600067C RID: 1660
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Ping(string address);

		// Token: 0x0600067D RID: 1661
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void DestroyPing();

		// Token: 0x0600067E RID: 1662 RVA: 0x00013B78 File Offset: 0x00011D78
		~Ping()
		{
			this.DestroyPing();
		}

		/// <summary>
		///   <para>Has the ping function completed?</para>
		/// </summary>
		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600067F RID: 1663
		public extern bool isDone
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>This property contains the ping time result after isDone returns true.</para>
		/// </summary>
		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000680 RID: 1664
		public extern int time
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The IP target of the ping.</para>
		/// </summary>
		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000681 RID: 1665
		public extern string ip
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x04000146 RID: 326
		private IntPtr pingWrapper;
	}
}
