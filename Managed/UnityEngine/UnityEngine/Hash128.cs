using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Represent the hash value.</para>
	/// </summary>
	// Token: 0x0200009B RID: 155
	public struct Hash128
	{
		/// <summary>
		///   <para>Construct the Hash128.</para>
		/// </summary>
		/// <param name="u32_0"></param>
		/// <param name="u32_1"></param>
		/// <param name="u32_2"></param>
		/// <param name="u32_3"></param>
		// Token: 0x060008C0 RID: 2240 RVA: 0x00005515 File Offset: 0x00003715
		public Hash128(uint u32_0, uint u32_1, uint u32_2, uint u32_3)
		{
			this.m_u32_0 = u32_0;
			this.m_u32_1 = u32_1;
			this.m_u32_2 = u32_2;
			this.m_u32_3 = u32_3;
		}

		/// <summary>
		///   <para>Get if the hash value is valid or not. (Read Only)</para>
		/// </summary>
		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060008C1 RID: 2241 RVA: 0x00005534 File Offset: 0x00003734
		public bool isValid
		{
			get
			{
				return this.m_u32_0 != 0U || this.m_u32_1 != 0U || this.m_u32_2 != 0U || this.m_u32_3 != 0U;
			}
		}

		/// <summary>
		///   <para>Convert Hash128 to string.</para>
		/// </summary>
		// Token: 0x060008C2 RID: 2242 RVA: 0x00005566 File Offset: 0x00003766
		public override string ToString()
		{
			return Hash128.Internal_Hash128ToString(this.m_u32_0, this.m_u32_1, this.m_u32_2, this.m_u32_3);
		}

		/// <summary>
		///   <para>Convert the input string to Hash128.</para>
		/// </summary>
		/// <param name="hashString"></param>
		// Token: 0x060008C3 RID: 2243
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Hash128 Parse(string hashString);

		// Token: 0x060008C4 RID: 2244
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string Internal_Hash128ToString(uint d0, uint d1, uint d2, uint d3);

		// Token: 0x040001E5 RID: 485
		private uint m_u32_0;

		// Token: 0x040001E6 RID: 486
		private uint m_u32_1;

		// Token: 0x040001E7 RID: 487
		private uint m_u32_2;

		// Token: 0x040001E8 RID: 488
		private uint m_u32_3;
	}
}
