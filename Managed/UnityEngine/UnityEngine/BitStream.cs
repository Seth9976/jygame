using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>The BitStream class represents seralized variables, packed into a stream.</para>
	/// </summary>
	// Token: 0x02000071 RID: 113
	public sealed class BitStream
	{
		// Token: 0x060006EE RID: 1774
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Serializeb(ref int value);

		// Token: 0x060006EF RID: 1775
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Serializec(ref char value);

		// Token: 0x060006F0 RID: 1776
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Serializes(ref short value);

		// Token: 0x060006F1 RID: 1777
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Serializei(ref int value);

		// Token: 0x060006F2 RID: 1778
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Serializef(ref float value, float maximumDelta);

		// Token: 0x060006F3 RID: 1779 RVA: 0x00004CCF File Offset: 0x00002ECF
		private void Serializeq(ref Quaternion value, float maximumDelta)
		{
			BitStream.INTERNAL_CALL_Serializeq(this, ref value, maximumDelta);
		}

		// Token: 0x060006F4 RID: 1780
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Serializeq(BitStream self, ref Quaternion value, float maximumDelta);

		// Token: 0x060006F5 RID: 1781 RVA: 0x00004CD9 File Offset: 0x00002ED9
		private void Serializev(ref Vector3 value, float maximumDelta)
		{
			BitStream.INTERNAL_CALL_Serializev(this, ref value, maximumDelta);
		}

		// Token: 0x060006F6 RID: 1782
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Serializev(BitStream self, ref Vector3 value, float maximumDelta);

		// Token: 0x060006F7 RID: 1783 RVA: 0x00004CE3 File Offset: 0x00002EE3
		private void Serializen(ref NetworkViewID viewID)
		{
			BitStream.INTERNAL_CALL_Serializen(this, ref viewID);
		}

		// Token: 0x060006F8 RID: 1784
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Serializen(BitStream self, ref NetworkViewID viewID);

		// Token: 0x060006F9 RID: 1785 RVA: 0x00013DD4 File Offset: 0x00011FD4
		public void Serialize(ref bool value)
		{
			int num = ((!value) ? 0 : 1);
			this.Serializeb(ref num);
			value = num != 0;
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00004CEC File Offset: 0x00002EEC
		public void Serialize(ref char value)
		{
			this.Serializec(ref value);
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00004CF5 File Offset: 0x00002EF5
		public void Serialize(ref short value)
		{
			this.Serializes(ref value);
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00004CFE File Offset: 0x00002EFE
		public void Serialize(ref int value)
		{
			this.Serializei(ref value);
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00013E08 File Offset: 0x00012008
		[ExcludeFromDocs]
		public void Serialize(ref float value)
		{
			float num = 1E-05f;
			this.Serialize(ref value, num);
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00004D07 File Offset: 0x00002F07
		public void Serialize(ref float value, [DefaultValue("0.00001F")] float maxDelta)
		{
			this.Serializef(ref value, maxDelta);
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00013E24 File Offset: 0x00012024
		[ExcludeFromDocs]
		public void Serialize(ref Quaternion value)
		{
			float num = 1E-05f;
			this.Serialize(ref value, num);
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00004D11 File Offset: 0x00002F11
		public void Serialize(ref Quaternion value, [DefaultValue("0.00001F")] float maxDelta)
		{
			this.Serializeq(ref value, maxDelta);
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00013E40 File Offset: 0x00012040
		[ExcludeFromDocs]
		public void Serialize(ref Vector3 value)
		{
			float num = 1E-05f;
			this.Serialize(ref value, num);
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00004D1B File Offset: 0x00002F1B
		public void Serialize(ref Vector3 value, [DefaultValue("0.00001F")] float maxDelta)
		{
			this.Serializev(ref value, maxDelta);
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00013E5C File Offset: 0x0001205C
		public void Serialize(ref NetworkPlayer value)
		{
			int index = value.index;
			this.Serializei(ref index);
			value.index = index;
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00004D25 File Offset: 0x00002F25
		public void Serialize(ref NetworkViewID viewID)
		{
			this.Serializen(ref viewID);
		}

		/// <summary>
		///   <para>Is the BitStream currently being read? (Read Only)</para>
		/// </summary>
		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000705 RID: 1797
		public extern bool isReading
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Is the BitStream currently being written? (Read Only)</para>
		/// </summary>
		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000706 RID: 1798
		public extern bool isWriting
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x06000707 RID: 1799
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Serialize(ref string value);

		// Token: 0x04000147 RID: 327
		internal IntPtr m_Ptr;
	}
}
