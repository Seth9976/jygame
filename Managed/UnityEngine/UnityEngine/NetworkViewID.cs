using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>The NetworkViewID is a unique identifier for a network view instance in a multiplayer game.</para>
	/// </summary>
	// Token: 0x0200006D RID: 109
	public struct NetworkViewID
	{
		/// <summary>
		///   <para>Represents an invalid network view ID.</para>
		/// </summary>
		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x00013B14 File Offset: 0x00011D14
		public static NetworkViewID unassigned
		{
			get
			{
				NetworkViewID networkViewID;
				NetworkViewID.INTERNAL_get_unassigned(out networkViewID);
				return networkViewID;
			}
		}

		// Token: 0x0600066C RID: 1644
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_unassigned(out NetworkViewID value);

		// Token: 0x0600066D RID: 1645 RVA: 0x00004B8F File Offset: 0x00002D8F
		internal static bool Internal_IsMine(NetworkViewID value)
		{
			return NetworkViewID.INTERNAL_CALL_Internal_IsMine(ref value);
		}

		// Token: 0x0600066E RID: 1646
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Internal_IsMine(ref NetworkViewID value);

		// Token: 0x0600066F RID: 1647 RVA: 0x00004B98 File Offset: 0x00002D98
		internal static void Internal_GetOwner(NetworkViewID value, out NetworkPlayer player)
		{
			NetworkViewID.INTERNAL_CALL_Internal_GetOwner(ref value, out player);
		}

		// Token: 0x06000670 RID: 1648
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_GetOwner(ref NetworkViewID value, out NetworkPlayer player);

		// Token: 0x06000671 RID: 1649 RVA: 0x00004BA2 File Offset: 0x00002DA2
		internal static string Internal_GetString(NetworkViewID value)
		{
			return NetworkViewID.INTERNAL_CALL_Internal_GetString(ref value);
		}

		// Token: 0x06000672 RID: 1650
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string INTERNAL_CALL_Internal_GetString(ref NetworkViewID value);

		// Token: 0x06000673 RID: 1651 RVA: 0x00004BAB File Offset: 0x00002DAB
		internal static bool Internal_Compare(NetworkViewID lhs, NetworkViewID rhs)
		{
			return NetworkViewID.INTERNAL_CALL_Internal_Compare(ref lhs, ref rhs);
		}

		// Token: 0x06000674 RID: 1652
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Internal_Compare(ref NetworkViewID lhs, ref NetworkViewID rhs);

		// Token: 0x06000675 RID: 1653 RVA: 0x00004BB6 File Offset: 0x00002DB6
		public override int GetHashCode()
		{
			return this.a ^ this.b ^ this.c;
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00013B2C File Offset: 0x00011D2C
		public override bool Equals(object other)
		{
			if (!(other is NetworkViewID))
			{
				return false;
			}
			NetworkViewID networkViewID = (NetworkViewID)other;
			return NetworkViewID.Internal_Compare(this, networkViewID);
		}

		/// <summary>
		///   <para>True if instantiated by me.</para>
		/// </summary>
		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x00004BCC File Offset: 0x00002DCC
		public bool isMine
		{
			get
			{
				return NetworkViewID.Internal_IsMine(this);
			}
		}

		/// <summary>
		///   <para>The NetworkPlayer who owns the NetworkView. Could be the server.</para>
		/// </summary>
		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x00013B5C File Offset: 0x00011D5C
		public NetworkPlayer owner
		{
			get
			{
				NetworkPlayer networkPlayer;
				NetworkViewID.Internal_GetOwner(this, out networkPlayer);
				return networkPlayer;
			}
		}

		/// <summary>
		///   <para>Returns a formatted string with details on this NetworkViewID.</para>
		/// </summary>
		// Token: 0x06000679 RID: 1657 RVA: 0x00004BD9 File Offset: 0x00002DD9
		public override string ToString()
		{
			return NetworkViewID.Internal_GetString(this);
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00004BE6 File Offset: 0x00002DE6
		public static bool operator ==(NetworkViewID lhs, NetworkViewID rhs)
		{
			return NetworkViewID.Internal_Compare(lhs, rhs);
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00004BEF File Offset: 0x00002DEF
		public static bool operator !=(NetworkViewID lhs, NetworkViewID rhs)
		{
			return !NetworkViewID.Internal_Compare(lhs, rhs);
		}

		// Token: 0x04000143 RID: 323
		private int a;

		// Token: 0x04000144 RID: 324
		private int b;

		// Token: 0x04000145 RID: 325
		private int c;
	}
}
