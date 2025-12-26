using System;
using System.Collections;

namespace System.Text.RegularExpressions
{
	// Token: 0x02000492 RID: 1170
	internal class PatternCompiler : ICompiler
	{
		// Token: 0x06002932 RID: 10546 RVA: 0x0001CA20 File Offset: 0x0001AC20
		public PatternCompiler()
		{
			this.pgm = new ArrayList();
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x0001CA33 File Offset: 0x0001AC33
		public static ushort EncodeOp(OpCode op, OpFlags flags)
		{
			return (ushort)(op | (OpCode)(flags & (OpFlags)65280));
		}

		// Token: 0x06002934 RID: 10548 RVA: 0x0001CA3F File Offset: 0x0001AC3F
		public static void DecodeOp(ushort word, out OpCode op, out OpFlags flags)
		{
			op = (OpCode)(word & 255);
			flags = (OpFlags)(word & 65280);
		}

		// Token: 0x06002935 RID: 10549 RVA: 0x0001CA55 File Offset: 0x0001AC55
		public void Reset()
		{
			this.pgm.Clear();
		}

		// Token: 0x06002936 RID: 10550 RVA: 0x0007F538 File Offset: 0x0007D738
		public IMachineFactory GetMachineFactory()
		{
			ushort[] array = new ushort[this.pgm.Count];
			this.pgm.CopyTo(array);
			return new InterpreterFactory(array);
		}

		// Token: 0x06002937 RID: 10551 RVA: 0x0001CA62 File Offset: 0x0001AC62
		public void EmitFalse()
		{
			this.Emit(OpCode.False);
		}

		// Token: 0x06002938 RID: 10552 RVA: 0x0001CA6B File Offset: 0x0001AC6B
		public void EmitTrue()
		{
			this.Emit(OpCode.True);
		}

		// Token: 0x06002939 RID: 10553 RVA: 0x0007F568 File Offset: 0x0007D768
		private void EmitCount(int count)
		{
			this.Emit((ushort)(count & 65535));
			this.Emit((ushort)((uint)count >> 16));
		}

		// Token: 0x0600293A RID: 10554 RVA: 0x0001CA74 File Offset: 0x0001AC74
		public void EmitCharacter(char c, bool negate, bool ignore, bool reverse)
		{
			this.Emit(OpCode.Character, PatternCompiler.MakeFlags(negate, ignore, reverse, false));
			if (ignore)
			{
				c = char.ToLower(c);
			}
			this.Emit((ushort)c);
		}

		// Token: 0x0600293B RID: 10555 RVA: 0x0001CA9C File Offset: 0x0001AC9C
		public void EmitCategory(Category cat, bool negate, bool reverse)
		{
			this.Emit(OpCode.Category, PatternCompiler.MakeFlags(negate, false, reverse, false));
			this.Emit((ushort)cat);
		}

		// Token: 0x0600293C RID: 10556 RVA: 0x0001CAB5 File Offset: 0x0001ACB5
		public void EmitNotCategory(Category cat, bool negate, bool reverse)
		{
			this.Emit(OpCode.NotCategory, PatternCompiler.MakeFlags(negate, false, reverse, false));
			this.Emit((ushort)cat);
		}

		// Token: 0x0600293D RID: 10557 RVA: 0x0001CACE File Offset: 0x0001ACCE
		public void EmitRange(char lo, char hi, bool negate, bool ignore, bool reverse)
		{
			this.Emit(OpCode.Range, PatternCompiler.MakeFlags(negate, ignore, reverse, false));
			this.Emit((ushort)lo);
			this.Emit((ushort)hi);
		}

		// Token: 0x0600293E RID: 10558 RVA: 0x0007F590 File Offset: 0x0007D790
		public void EmitSet(char lo, BitArray set, bool negate, bool ignore, bool reverse)
		{
			this.Emit(OpCode.Set, PatternCompiler.MakeFlags(negate, ignore, reverse, false));
			this.Emit((ushort)lo);
			int num = set.Length + 15 >> 4;
			this.Emit((ushort)num);
			int num2 = 0;
			while (num-- != 0)
			{
				ushort num3 = 0;
				for (int i = 0; i < 16; i++)
				{
					if (num2 >= set.Length)
					{
						break;
					}
					if (set[num2++])
					{
						num3 |= (ushort)(1 << i);
					}
				}
				this.Emit(num3);
			}
		}

		// Token: 0x0600293F RID: 10559 RVA: 0x0007F624 File Offset: 0x0007D824
		public void EmitString(string str, bool ignore, bool reverse)
		{
			this.Emit(OpCode.String, PatternCompiler.MakeFlags(false, ignore, reverse, false));
			int length = str.Length;
			this.Emit((ushort)length);
			if (ignore)
			{
				str = str.ToLower();
			}
			for (int i = 0; i < length; i++)
			{
				this.Emit((ushort)str[i]);
			}
		}

		// Token: 0x06002940 RID: 10560 RVA: 0x0001CAF0 File Offset: 0x0001ACF0
		public void EmitPosition(Position pos)
		{
			this.Emit(OpCode.Position, OpFlags.None);
			this.Emit((ushort)pos);
		}

		// Token: 0x06002941 RID: 10561 RVA: 0x0001CB01 File Offset: 0x0001AD01
		public void EmitOpen(int gid)
		{
			this.Emit(OpCode.Open);
			this.Emit((ushort)gid);
		}

		// Token: 0x06002942 RID: 10562 RVA: 0x0001CB13 File Offset: 0x0001AD13
		public void EmitClose(int gid)
		{
			this.Emit(OpCode.Close);
			this.Emit((ushort)gid);
		}

		// Token: 0x06002943 RID: 10563 RVA: 0x0001CB25 File Offset: 0x0001AD25
		public void EmitBalanceStart(int gid, int balance, bool capture, LinkRef tail)
		{
			this.BeginLink(tail);
			this.Emit(OpCode.BalanceStart);
			this.Emit((ushort)gid);
			this.Emit((ushort)balance);
			this.Emit((!capture) ? 0 : 1);
			this.EmitLink(tail);
		}

		// Token: 0x06002944 RID: 10564 RVA: 0x0001CB63 File Offset: 0x0001AD63
		public void EmitBalance()
		{
			this.Emit(OpCode.Balance);
		}

		// Token: 0x06002945 RID: 10565 RVA: 0x0001CB6D File Offset: 0x0001AD6D
		public void EmitReference(int gid, bool ignore, bool reverse)
		{
			this.Emit(OpCode.Reference, PatternCompiler.MakeFlags(false, ignore, reverse, false));
			this.Emit((ushort)gid);
		}

		// Token: 0x06002946 RID: 10566 RVA: 0x0001CB87 File Offset: 0x0001AD87
		public void EmitIfDefined(int gid, LinkRef tail)
		{
			this.BeginLink(tail);
			this.Emit(OpCode.IfDefined);
			this.EmitLink(tail);
			this.Emit((ushort)gid);
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x0001CBA7 File Offset: 0x0001ADA7
		public void EmitSub(LinkRef tail)
		{
			this.BeginLink(tail);
			this.Emit(OpCode.Sub);
			this.EmitLink(tail);
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x0001CBBF File Offset: 0x0001ADBF
		public void EmitTest(LinkRef yes, LinkRef tail)
		{
			this.BeginLink(yes);
			this.BeginLink(tail);
			this.Emit(OpCode.Test);
			this.EmitLink(yes);
			this.EmitLink(tail);
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x0001CBE5 File Offset: 0x0001ADE5
		public void EmitBranch(LinkRef next)
		{
			this.BeginLink(next);
			this.Emit(OpCode.Branch, OpFlags.None);
			this.EmitLink(next);
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x0001CBFE File Offset: 0x0001ADFE
		public void EmitJump(LinkRef target)
		{
			this.BeginLink(target);
			this.Emit(OpCode.Jump, OpFlags.None);
			this.EmitLink(target);
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x0001CC17 File Offset: 0x0001AE17
		public void EmitRepeat(int min, int max, bool lazy, LinkRef until)
		{
			this.BeginLink(until);
			this.Emit(OpCode.Repeat, PatternCompiler.MakeFlags(false, false, false, lazy));
			this.EmitLink(until);
			this.EmitCount(min);
			this.EmitCount(max);
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x0001CC48 File Offset: 0x0001AE48
		public void EmitUntil(LinkRef repeat)
		{
			this.ResolveLink(repeat);
			this.Emit(OpCode.Until);
		}

		// Token: 0x0600294D RID: 10573 RVA: 0x0001CC59 File Offset: 0x0001AE59
		public void EmitFastRepeat(int min, int max, bool lazy, LinkRef tail)
		{
			this.BeginLink(tail);
			this.Emit(OpCode.FastRepeat, PatternCompiler.MakeFlags(false, false, false, lazy));
			this.EmitLink(tail);
			this.EmitCount(min);
			this.EmitCount(max);
		}

		// Token: 0x0600294E RID: 10574 RVA: 0x0001CC8A File Offset: 0x0001AE8A
		public void EmitIn(LinkRef tail)
		{
			this.BeginLink(tail);
			this.Emit(OpCode.In);
			this.EmitLink(tail);
		}

		// Token: 0x0600294F RID: 10575 RVA: 0x0001CCA2 File Offset: 0x0001AEA2
		public void EmitAnchor(bool reverse, int offset, LinkRef tail)
		{
			this.BeginLink(tail);
			this.Emit(OpCode.Anchor, PatternCompiler.MakeFlags(false, false, reverse, false));
			this.EmitLink(tail);
			this.Emit((ushort)offset);
		}

		// Token: 0x06002950 RID: 10576 RVA: 0x0001CCCB File Offset: 0x0001AECB
		public void EmitInfo(int count, int min, int max)
		{
			this.Emit(OpCode.Info);
			this.EmitCount(count);
			this.EmitCount(min);
			this.EmitCount(max);
		}

		// Token: 0x06002951 RID: 10577 RVA: 0x0001CCEA File Offset: 0x0001AEEA
		public LinkRef NewLink()
		{
			return new PatternCompiler.PatternLinkStack();
		}

		// Token: 0x06002952 RID: 10578 RVA: 0x0007F680 File Offset: 0x0007D880
		public void ResolveLink(LinkRef lref)
		{
			PatternCompiler.PatternLinkStack patternLinkStack = (PatternCompiler.PatternLinkStack)lref;
			while (patternLinkStack.Pop())
			{
				this.pgm[patternLinkStack.OffsetAddress] = (ushort)patternLinkStack.GetOffset(this.CurrentAddress);
			}
		}

		// Token: 0x06002953 RID: 10579 RVA: 0x000029F5 File Offset: 0x00000BF5
		public void EmitBranchEnd()
		{
		}

		// Token: 0x06002954 RID: 10580 RVA: 0x000029F5 File Offset: 0x00000BF5
		public void EmitAlternationEnd()
		{
		}

		// Token: 0x06002955 RID: 10581 RVA: 0x0007ACFC File Offset: 0x00078EFC
		private static OpFlags MakeFlags(bool negate, bool ignore, bool reverse, bool lazy)
		{
			OpFlags opFlags = OpFlags.None;
			if (negate)
			{
				opFlags |= OpFlags.Negate;
			}
			if (ignore)
			{
				opFlags |= OpFlags.IgnoreCase;
			}
			if (reverse)
			{
				opFlags |= OpFlags.RightToLeft;
			}
			if (lazy)
			{
				opFlags |= OpFlags.Lazy;
			}
			return opFlags;
		}

		// Token: 0x06002956 RID: 10582 RVA: 0x0001CCF1 File Offset: 0x0001AEF1
		private void Emit(OpCode op)
		{
			this.Emit(op, OpFlags.None);
		}

		// Token: 0x06002957 RID: 10583 RVA: 0x0001CCFB File Offset: 0x0001AEFB
		private void Emit(OpCode op, OpFlags flags)
		{
			this.Emit(PatternCompiler.EncodeOp(op, flags));
		}

		// Token: 0x06002958 RID: 10584 RVA: 0x0001CD0A File Offset: 0x0001AF0A
		private void Emit(ushort word)
		{
			this.pgm.Add(word);
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x06002959 RID: 10585 RVA: 0x0001CD1E File Offset: 0x0001AF1E
		private int CurrentAddress
		{
			get
			{
				return this.pgm.Count;
			}
		}

		// Token: 0x0600295A RID: 10586 RVA: 0x0007F6C8 File Offset: 0x0007D8C8
		private void BeginLink(LinkRef lref)
		{
			PatternCompiler.PatternLinkStack patternLinkStack = (PatternCompiler.PatternLinkStack)lref;
			patternLinkStack.BaseAddress = this.CurrentAddress;
		}

		// Token: 0x0600295B RID: 10587 RVA: 0x0007F6E8 File Offset: 0x0007D8E8
		private void EmitLink(LinkRef lref)
		{
			PatternCompiler.PatternLinkStack patternLinkStack = (PatternCompiler.PatternLinkStack)lref;
			patternLinkStack.OffsetAddress = this.CurrentAddress;
			this.Emit(0);
			patternLinkStack.Push();
		}

		// Token: 0x040019E6 RID: 6630
		private ArrayList pgm;

		// Token: 0x02000493 RID: 1171
		private class PatternLinkStack : LinkStack
		{
			// Token: 0x17000B65 RID: 2917
			// (set) Token: 0x0600295D RID: 10589 RVA: 0x0001CD33 File Offset: 0x0001AF33
			public int BaseAddress
			{
				set
				{
					this.link.base_addr = value;
				}
			}

			// Token: 0x17000B66 RID: 2918
			// (get) Token: 0x0600295E RID: 10590 RVA: 0x0001CD41 File Offset: 0x0001AF41
			// (set) Token: 0x0600295F RID: 10591 RVA: 0x0001CD4E File Offset: 0x0001AF4E
			public int OffsetAddress
			{
				get
				{
					return this.link.offset_addr;
				}
				set
				{
					this.link.offset_addr = value;
				}
			}

			// Token: 0x06002960 RID: 10592 RVA: 0x0001CD5C File Offset: 0x0001AF5C
			public int GetOffset(int target_addr)
			{
				return target_addr - this.link.base_addr;
			}

			// Token: 0x06002961 RID: 10593 RVA: 0x0001CD6B File Offset: 0x0001AF6B
			protected override object GetCurrent()
			{
				return this.link;
			}

			// Token: 0x06002962 RID: 10594 RVA: 0x0001CD78 File Offset: 0x0001AF78
			protected override void SetCurrent(object l)
			{
				this.link = (PatternCompiler.PatternLinkStack.Link)l;
			}

			// Token: 0x040019E7 RID: 6631
			private PatternCompiler.PatternLinkStack.Link link;

			// Token: 0x02000494 RID: 1172
			private struct Link
			{
				// Token: 0x040019E8 RID: 6632
				public int base_addr;

				// Token: 0x040019E9 RID: 6633
				public int offset_addr;
			}
		}
	}
}
