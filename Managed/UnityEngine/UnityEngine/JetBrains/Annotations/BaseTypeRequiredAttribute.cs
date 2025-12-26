using System;

namespace JetBrains.Annotations
{
	// Token: 0x020002A1 RID: 673
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
	[BaseTypeRequired(typeof(Attribute))]
	public sealed class BaseTypeRequiredAttribute : Attribute
	{
		// Token: 0x060020C7 RID: 8391 RVA: 0x0000D03A File Offset: 0x0000B23A
		public BaseTypeRequiredAttribute([NotNull] Type baseType)
		{
			this.BaseType = baseType;
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x060020C8 RID: 8392 RVA: 0x0000D049 File Offset: 0x0000B249
		// (set) Token: 0x060020C9 RID: 8393 RVA: 0x0000D051 File Offset: 0x0000B251
		[NotNull]
		public Type BaseType { get; private set; }
	}
}
