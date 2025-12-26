using System;
using System.Collections;

namespace System.Text.RegularExpressions
{
	// Token: 0x02000491 RID: 1169
	internal class InterpreterFactory : IMachineFactory
	{
		// Token: 0x06002929 RID: 10537 RVA: 0x0001C9C7 File Offset: 0x0001ABC7
		public InterpreterFactory(ushort[] pattern)
		{
			this.pattern = pattern;
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x0001C9D6 File Offset: 0x0001ABD6
		public IMachine NewInstance()
		{
			return new Interpreter(this.pattern);
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x0600292B RID: 10539 RVA: 0x0001C9E3 File Offset: 0x0001ABE3
		public int GroupCount
		{
			get
			{
				return (int)this.pattern[1];
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x0600292C RID: 10540 RVA: 0x0001C9ED File Offset: 0x0001ABED
		// (set) Token: 0x0600292D RID: 10541 RVA: 0x0001C9F5 File Offset: 0x0001ABF5
		public int Gap
		{
			get
			{
				return this.gap;
			}
			set
			{
				this.gap = value;
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x0600292E RID: 10542 RVA: 0x0001C9FE File Offset: 0x0001ABFE
		// (set) Token: 0x0600292F RID: 10543 RVA: 0x0001CA06 File Offset: 0x0001AC06
		public IDictionary Mapping
		{
			get
			{
				return this.mapping;
			}
			set
			{
				this.mapping = value;
			}
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x06002930 RID: 10544 RVA: 0x0001CA0F File Offset: 0x0001AC0F
		// (set) Token: 0x06002931 RID: 10545 RVA: 0x0001CA17 File Offset: 0x0001AC17
		public string[] NamesMapping
		{
			get
			{
				return this.namesMapping;
			}
			set
			{
				this.namesMapping = value;
			}
		}

		// Token: 0x040019E2 RID: 6626
		private IDictionary mapping;

		// Token: 0x040019E3 RID: 6627
		private ushort[] pattern;

		// Token: 0x040019E4 RID: 6628
		private string[] namesMapping;

		// Token: 0x040019E5 RID: 6629
		private int gap;
	}
}
