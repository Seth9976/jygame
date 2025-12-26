using System;

namespace JetBrains.Annotations
{
	// Token: 0x0200029E RID: 670
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
	public sealed class ContractAnnotationAttribute : Attribute
	{
		// Token: 0x060020BC RID: 8380 RVA: 0x0000CFCF File Offset: 0x0000B1CF
		public ContractAnnotationAttribute([NotNull] string contract)
			: this(contract, false)
		{
		}

		// Token: 0x060020BD RID: 8381 RVA: 0x0000CFD9 File Offset: 0x0000B1D9
		public ContractAnnotationAttribute([NotNull] string contract, bool forceFullStates)
		{
			this.Contract = contract;
			this.ForceFullStates = forceFullStates;
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x060020BE RID: 8382 RVA: 0x0000CFEF File Offset: 0x0000B1EF
		// (set) Token: 0x060020BF RID: 8383 RVA: 0x0000CFF7 File Offset: 0x0000B1F7
		public string Contract { get; private set; }

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x060020C0 RID: 8384 RVA: 0x0000D000 File Offset: 0x0000B200
		// (set) Token: 0x060020C1 RID: 8385 RVA: 0x0000D008 File Offset: 0x0000B208
		public bool ForceFullStates { get; private set; }
	}
}
