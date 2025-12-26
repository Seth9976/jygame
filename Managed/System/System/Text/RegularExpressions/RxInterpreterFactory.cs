using System;
using System.Collections;

namespace System.Text.RegularExpressions
{
	// Token: 0x020004B2 RID: 1202
	internal class RxInterpreterFactory : IMachineFactory
	{
		// Token: 0x06002AC6 RID: 10950 RVA: 0x0001DC96 File Offset: 0x0001BE96
		public RxInterpreterFactory(byte[] program, EvalDelegate eval_del)
		{
			this.program = program;
			this.eval_del = eval_del;
		}

		// Token: 0x06002AC7 RID: 10951 RVA: 0x0001DCAC File Offset: 0x0001BEAC
		public IMachine NewInstance()
		{
			return new RxInterpreter(this.program, this.eval_del);
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x06002AC8 RID: 10952 RVA: 0x0001DCBF File Offset: 0x0001BEBF
		public int GroupCount
		{
			get
			{
				return (int)this.program[1] | ((int)this.program[2] << 8);
			}
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x06002AC9 RID: 10953 RVA: 0x0001DCD4 File Offset: 0x0001BED4
		// (set) Token: 0x06002ACA RID: 10954 RVA: 0x0001DCDC File Offset: 0x0001BEDC
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

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x06002ACB RID: 10955 RVA: 0x0001DCE5 File Offset: 0x0001BEE5
		// (set) Token: 0x06002ACC RID: 10956 RVA: 0x0001DCED File Offset: 0x0001BEED
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

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06002ACD RID: 10957 RVA: 0x0001DCF6 File Offset: 0x0001BEF6
		// (set) Token: 0x06002ACE RID: 10958 RVA: 0x0001DCFE File Offset: 0x0001BEFE
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

		// Token: 0x04001A76 RID: 6774
		private IDictionary mapping;

		// Token: 0x04001A77 RID: 6775
		private byte[] program;

		// Token: 0x04001A78 RID: 6776
		private EvalDelegate eval_del;

		// Token: 0x04001A79 RID: 6777
		private string[] namesMapping;

		// Token: 0x04001A7A RID: 6778
		private int gap;
	}
}
