using System;
using System.Collections;

namespace System.Text.RegularExpressions
{
	// Token: 0x02000490 RID: 1168
	internal interface ICompiler
	{
		// Token: 0x0600290A RID: 10506
		void Reset();

		// Token: 0x0600290B RID: 10507
		IMachineFactory GetMachineFactory();

		// Token: 0x0600290C RID: 10508
		void EmitFalse();

		// Token: 0x0600290D RID: 10509
		void EmitTrue();

		// Token: 0x0600290E RID: 10510
		void EmitCharacter(char c, bool negate, bool ignore, bool reverse);

		// Token: 0x0600290F RID: 10511
		void EmitCategory(Category cat, bool negate, bool reverse);

		// Token: 0x06002910 RID: 10512
		void EmitNotCategory(Category cat, bool negate, bool reverse);

		// Token: 0x06002911 RID: 10513
		void EmitRange(char lo, char hi, bool negate, bool ignore, bool reverse);

		// Token: 0x06002912 RID: 10514
		void EmitSet(char lo, BitArray set, bool negate, bool ignore, bool reverse);

		// Token: 0x06002913 RID: 10515
		void EmitString(string str, bool ignore, bool reverse);

		// Token: 0x06002914 RID: 10516
		void EmitPosition(Position pos);

		// Token: 0x06002915 RID: 10517
		void EmitOpen(int gid);

		// Token: 0x06002916 RID: 10518
		void EmitClose(int gid);

		// Token: 0x06002917 RID: 10519
		void EmitBalanceStart(int gid, int balance, bool capture, LinkRef tail);

		// Token: 0x06002918 RID: 10520
		void EmitBalance();

		// Token: 0x06002919 RID: 10521
		void EmitReference(int gid, bool ignore, bool reverse);

		// Token: 0x0600291A RID: 10522
		void EmitIfDefined(int gid, LinkRef tail);

		// Token: 0x0600291B RID: 10523
		void EmitSub(LinkRef tail);

		// Token: 0x0600291C RID: 10524
		void EmitTest(LinkRef yes, LinkRef tail);

		// Token: 0x0600291D RID: 10525
		void EmitBranch(LinkRef next);

		// Token: 0x0600291E RID: 10526
		void EmitJump(LinkRef target);

		// Token: 0x0600291F RID: 10527
		void EmitRepeat(int min, int max, bool lazy, LinkRef until);

		// Token: 0x06002920 RID: 10528
		void EmitUntil(LinkRef repeat);

		// Token: 0x06002921 RID: 10529
		void EmitIn(LinkRef tail);

		// Token: 0x06002922 RID: 10530
		void EmitInfo(int count, int min, int max);

		// Token: 0x06002923 RID: 10531
		void EmitFastRepeat(int min, int max, bool lazy, LinkRef tail);

		// Token: 0x06002924 RID: 10532
		void EmitAnchor(bool reverse, int offset, LinkRef tail);

		// Token: 0x06002925 RID: 10533
		void EmitBranchEnd();

		// Token: 0x06002926 RID: 10534
		void EmitAlternationEnd();

		// Token: 0x06002927 RID: 10535
		LinkRef NewLink();

		// Token: 0x06002928 RID: 10536
		void ResolveLink(LinkRef link);
	}
}
