using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>The RequireComponent attribute lets automatically add required component as a dependency.</para>
	/// </summary>
	// Token: 0x02000248 RID: 584
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public sealed class RequireComponent : Attribute
	{
		/// <summary>
		///   <para>Require a single component.</para>
		/// </summary>
		/// <param name="requiredComponent"></param>
		// Token: 0x06002063 RID: 8291 RVA: 0x0000CC3B File Offset: 0x0000AE3B
		public RequireComponent(Type requiredComponent)
		{
			this.m_Type0 = requiredComponent;
		}

		/// <summary>
		///   <para>Require a two components.</para>
		/// </summary>
		/// <param name="requiredComponent"></param>
		/// <param name="requiredComponent2"></param>
		// Token: 0x06002064 RID: 8292 RVA: 0x0000CC4A File Offset: 0x0000AE4A
		public RequireComponent(Type requiredComponent, Type requiredComponent2)
		{
			this.m_Type0 = requiredComponent;
			this.m_Type1 = requiredComponent2;
		}

		/// <summary>
		///   <para>Require three components.</para>
		/// </summary>
		/// <param name="requiredComponent"></param>
		/// <param name="requiredComponent2"></param>
		/// <param name="requiredComponent3"></param>
		// Token: 0x06002065 RID: 8293 RVA: 0x0000CC60 File Offset: 0x0000AE60
		public RequireComponent(Type requiredComponent, Type requiredComponent2, Type requiredComponent3)
		{
			this.m_Type0 = requiredComponent;
			this.m_Type1 = requiredComponent2;
			this.m_Type2 = requiredComponent3;
		}

		// Token: 0x040008D2 RID: 2258
		public Type m_Type0;

		// Token: 0x040008D3 RID: 2259
		public Type m_Type1;

		// Token: 0x040008D4 RID: 2260
		public Type m_Type2;
	}
}
