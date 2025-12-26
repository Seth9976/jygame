using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>The Master Server is used to make matchmaking between servers and clients easy.</para>
	/// </summary>
	// Token: 0x02000074 RID: 116
	public sealed class MasterServer
	{
		/// <summary>
		///   <para>The IP address of the master server.</para>
		/// </summary>
		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600071F RID: 1823
		// (set) Token: 0x06000720 RID: 1824
		public static extern string ipAddress
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The connection port of the master server.</para>
		/// </summary>
		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000721 RID: 1825
		// (set) Token: 0x06000722 RID: 1826
		public static extern int port
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Request a host list from the master server.</para>
		/// </summary>
		/// <param name="gameTypeName"></param>
		// Token: 0x06000723 RID: 1827
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RequestHostList(string gameTypeName);

		/// <summary>
		///   <para>Check for the latest host list received by using MasterServer.RequestHostList.</para>
		/// </summary>
		// Token: 0x06000724 RID: 1828
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern HostData[] PollHostList();

		/// <summary>
		///   <para>Register this server on the master server.</para>
		/// </summary>
		/// <param name="gameTypeName"></param>
		/// <param name="gameName"></param>
		/// <param name="comment"></param>
		// Token: 0x06000725 RID: 1829
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RegisterHost(string gameTypeName, string gameName, [DefaultValue("\"\"")] string comment);

		/// <summary>
		///   <para>Register this server on the master server.</para>
		/// </summary>
		/// <param name="gameTypeName"></param>
		/// <param name="gameName"></param>
		/// <param name="comment"></param>
		// Token: 0x06000726 RID: 1830 RVA: 0x00013E80 File Offset: 0x00012080
		[ExcludeFromDocs]
		public static void RegisterHost(string gameTypeName, string gameName)
		{
			string empty = string.Empty;
			MasterServer.RegisterHost(gameTypeName, gameName, empty);
		}

		/// <summary>
		///   <para>Unregister this server from the master server.</para>
		/// </summary>
		// Token: 0x06000727 RID: 1831
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnregisterHost();

		/// <summary>
		///   <para>Clear the host list which was received by MasterServer.PollHostList.</para>
		/// </summary>
		// Token: 0x06000728 RID: 1832
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearHostList();

		/// <summary>
		///   <para>Set the minimum update rate for master server host information update.</para>
		/// </summary>
		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000729 RID: 1833
		// (set) Token: 0x0600072A RID: 1834
		public static extern int updateRate
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Report this machine as a dedicated server.</para>
		/// </summary>
		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600072B RID: 1835
		// (set) Token: 0x0600072C RID: 1836
		public static extern bool dedicatedServer
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}
	}
}
