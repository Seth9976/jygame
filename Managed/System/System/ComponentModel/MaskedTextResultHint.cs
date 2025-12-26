using System;

namespace System.ComponentModel
{
	/// <summary>Specifies values that succinctly describe the results of a masked text parsing operation.</summary>
	// Token: 0x0200018E RID: 398
	public enum MaskedTextResultHint
	{
		/// <summary>Operation did not succeed. The specified position is not in the range of the target string; typically it is either less than zero or greater then the length of the target string.</summary>
		// Token: 0x040003EA RID: 1002
		PositionOutOfRange = -55,
		/// <summary>Operation did not succeed. The current position in the formatted string is a literal character. </summary>
		// Token: 0x040003EB RID: 1003
		NonEditPosition,
		/// <summary>Operation did not succeed. There were not enough edit positions available to fulfill the request.</summary>
		// Token: 0x040003EC RID: 1004
		UnavailableEditPosition,
		/// <summary>Operation did not succeed. The prompt character is not valid at input, perhaps because the <see cref="P:System.ComponentModel.MaskedTextProvider.AllowPromptAsInput" /> property is set to false. </summary>
		// Token: 0x040003ED RID: 1005
		PromptCharNotAllowed,
		/// <summary>Operation did not succeed. The program encountered an  input character that was not valid. For more information about characters that are not valid, see the <see cref="M:System.ComponentModel.MaskedTextProvider.IsValidInputChar(System.Char)" /> method.</summary>
		// Token: 0x040003EE RID: 1006
		InvalidInput,
		/// <summary>Operation did not succeed. An input character was encountered that was not a signed digit.</summary>
		// Token: 0x040003EF RID: 1007
		SignedDigitExpected = -5,
		/// <summary>Operation did not succeed. An input character was encountered that was not a letter.</summary>
		// Token: 0x040003F0 RID: 1008
		LetterExpected,
		/// <summary>Operation did not succeed. An input character was encountered that was not a digit.</summary>
		// Token: 0x040003F1 RID: 1009
		DigitExpected,
		/// <summary>Operation did not succeed.An input character was encountered that was not alphanumeric. .</summary>
		// Token: 0x040003F2 RID: 1010
		AlphanumericCharacterExpected,
		/// <summary>Operation did not succeed.An input character was encountered that was not a member of the ASCII character set.</summary>
		// Token: 0x040003F3 RID: 1011
		AsciiCharacterExpected,
		/// <summary>Unknown. The result of the operation could not be determined.</summary>
		// Token: 0x040003F4 RID: 1012
		Unknown,
		/// <summary>Success. The operation succeeded because a literal, prompt or space character was an escaped character. For more information about escaped characters, see the <see cref="M:System.ComponentModel.MaskedTextProvider.VerifyEscapeChar(System.Char,System.Int32)" /> method.</summary>
		// Token: 0x040003F5 RID: 1013
		CharacterEscaped,
		/// <summary>Success. The primary operation was not performed because it was not needed; therefore, no side effect was produced.</summary>
		// Token: 0x040003F6 RID: 1014
		NoEffect,
		/// <summary>Success. The primary operation was not performed because it was not needed, but the method produced a side effect. For example, the <see cref="Overload:System.ComponentModel.MaskedTextProvider.RemoveAt" /> method can delete an unassigned edit position, which causes left-shifting of subsequent characters in the formatted string. </summary>
		// Token: 0x040003F7 RID: 1015
		SideEffect,
		/// <summary>Success. The primary operation succeeded.</summary>
		// Token: 0x040003F8 RID: 1016
		Success
	}
}
