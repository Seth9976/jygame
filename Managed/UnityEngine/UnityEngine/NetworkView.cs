using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>The network view is the binding material of multiplayer games.</para>
	/// </summary>
	// Token: 0x0200006F RID: 111
	public sealed class NetworkView : Behaviour
	{
		// Token: 0x06000683 RID: 1667
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_RPC(NetworkView view, string name, RPCMode mode, object[] args);

		// Token: 0x06000684 RID: 1668
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_RPC_Target(NetworkView view, string name, NetworkPlayer target, object[] args);

		/// <summary>
		///   <para>Call a RPC function on all connected peers.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="mode"></param>
		/// <param name="args"></param>
		// Token: 0x06000685 RID: 1669 RVA: 0x00004BFB File Offset: 0x00002DFB
		[Obsolete("NetworkView RPC functions are deprecated. Refer to the new Multiplayer Networking system.")]
		public void RPC(string name, RPCMode mode, params object[] args)
		{
			NetworkView.Internal_RPC(this, name, mode, args);
		}

		/// <summary>
		///   <para>Call a RPC function on a specific player.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="target"></param>
		/// <param name="args"></param>
		// Token: 0x06000686 RID: 1670 RVA: 0x00004C06 File Offset: 0x00002E06
		[Obsolete("NetworkView RPC functions are deprecated. Refer to the new Multiplayer Networking system.")]
		public void RPC(string name, NetworkPlayer target, params object[] args)
		{
			NetworkView.Internal_RPC_Target(this, name, target, args);
		}

		/// <summary>
		///   <para>The component the network view is observing.</para>
		/// </summary>
		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000687 RID: 1671
		// (set) Token: 0x06000688 RID: 1672
		public extern Component observed
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The type of NetworkStateSynchronization set for this network view.</para>
		/// </summary>
		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000689 RID: 1673
		// (set) Token: 0x0600068A RID: 1674
		public extern NetworkStateSynchronization stateSynchronization
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x0600068B RID: 1675
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_GetViewID(out NetworkViewID viewID);

		// Token: 0x0600068C RID: 1676 RVA: 0x00004C11 File Offset: 0x00002E11
		private void Internal_SetViewID(NetworkViewID viewID)
		{
			NetworkView.INTERNAL_CALL_Internal_SetViewID(this, ref viewID);
		}

		// Token: 0x0600068D RID: 1677
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_SetViewID(NetworkView self, ref NetworkViewID viewID);

		/// <summary>
		///   <para>The ViewID of this network view.</para>
		/// </summary>
		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x00013BA8 File Offset: 0x00011DA8
		// (set) Token: 0x0600068F RID: 1679 RVA: 0x00004C1B File Offset: 0x00002E1B
		public NetworkViewID viewID
		{
			get
			{
				NetworkViewID networkViewID;
				this.Internal_GetViewID(out networkViewID);
				return networkViewID;
			}
			set
			{
				this.Internal_SetViewID(value);
			}
		}

		/// <summary>
		///   <para>The network group number of this network view.</para>
		/// </summary>
		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000690 RID: 1680
		// (set) Token: 0x06000691 RID: 1681
		public extern int group
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Is the network view controlled by this object?</para>
		/// </summary>
		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x00013BC0 File Offset: 0x00011DC0
		public bool isMine
		{
			get
			{
				return this.viewID.isMine;
			}
		}

		/// <summary>
		///   <para>The NetworkPlayer who owns this network view.</para>
		/// </summary>
		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x00013BDC File Offset: 0x00011DDC
		public NetworkPlayer owner
		{
			get
			{
				return this.viewID.owner;
			}
		}

		/// <summary>
		///   <para>Set the scope of the network view in relation to a specific network player.</para>
		/// </summary>
		/// <param name="player"></param>
		/// <param name="relevancy"></param>
		// Token: 0x06000694 RID: 1684
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool SetScope(NetworkPlayer player, bool relevancy);

		/// <summary>
		///   <para>Find a network view based on a NetworkViewID.</para>
		/// </summary>
		/// <param name="viewID"></param>
		// Token: 0x06000695 RID: 1685 RVA: 0x00004C24 File Offset: 0x00002E24
		public static NetworkView Find(NetworkViewID viewID)
		{
			return NetworkView.INTERNAL_CALL_Find(ref viewID);
		}

		// Token: 0x06000696 RID: 1686
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern NetworkView INTERNAL_CALL_Find(ref NetworkViewID viewID);
	}
}
