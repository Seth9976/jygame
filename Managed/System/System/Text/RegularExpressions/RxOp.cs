using System;

namespace System.Text.RegularExpressions
{
	// Token: 0x020004B3 RID: 1203
	internal enum RxOp : byte
	{
		// Token: 0x04001A7C RID: 6780
		Info,
		// Token: 0x04001A7D RID: 6781
		False,
		// Token: 0x04001A7E RID: 6782
		True,
		// Token: 0x04001A7F RID: 6783
		AnyPosition,
		// Token: 0x04001A80 RID: 6784
		StartOfString,
		// Token: 0x04001A81 RID: 6785
		StartOfLine,
		// Token: 0x04001A82 RID: 6786
		StartOfScan,
		// Token: 0x04001A83 RID: 6787
		EndOfString,
		// Token: 0x04001A84 RID: 6788
		EndOfLine,
		// Token: 0x04001A85 RID: 6789
		End,
		// Token: 0x04001A86 RID: 6790
		WordBoundary,
		// Token: 0x04001A87 RID: 6791
		NoWordBoundary,
		// Token: 0x04001A88 RID: 6792
		String,
		// Token: 0x04001A89 RID: 6793
		StringIgnoreCase,
		// Token: 0x04001A8A RID: 6794
		StringReverse,
		// Token: 0x04001A8B RID: 6795
		StringIgnoreCaseReverse,
		// Token: 0x04001A8C RID: 6796
		UnicodeString,
		// Token: 0x04001A8D RID: 6797
		UnicodeStringIgnoreCase,
		// Token: 0x04001A8E RID: 6798
		UnicodeStringReverse,
		// Token: 0x04001A8F RID: 6799
		UnicodeStringIgnoreCaseReverse,
		// Token: 0x04001A90 RID: 6800
		Char,
		// Token: 0x04001A91 RID: 6801
		NoChar,
		// Token: 0x04001A92 RID: 6802
		CharIgnoreCase,
		// Token: 0x04001A93 RID: 6803
		NoCharIgnoreCase,
		// Token: 0x04001A94 RID: 6804
		CharReverse,
		// Token: 0x04001A95 RID: 6805
		NoCharReverse,
		// Token: 0x04001A96 RID: 6806
		CharIgnoreCaseReverse,
		// Token: 0x04001A97 RID: 6807
		NoCharIgnoreCaseReverse,
		// Token: 0x04001A98 RID: 6808
		Range,
		// Token: 0x04001A99 RID: 6809
		NoRange,
		// Token: 0x04001A9A RID: 6810
		RangeIgnoreCase,
		// Token: 0x04001A9B RID: 6811
		NoRangeIgnoreCase,
		// Token: 0x04001A9C RID: 6812
		RangeReverse,
		// Token: 0x04001A9D RID: 6813
		NoRangeReverse,
		// Token: 0x04001A9E RID: 6814
		RangeIgnoreCaseReverse,
		// Token: 0x04001A9F RID: 6815
		NoRangeIgnoreCaseReverse,
		// Token: 0x04001AA0 RID: 6816
		Bitmap,
		// Token: 0x04001AA1 RID: 6817
		NoBitmap,
		// Token: 0x04001AA2 RID: 6818
		BitmapIgnoreCase,
		// Token: 0x04001AA3 RID: 6819
		NoBitmapIgnoreCase,
		// Token: 0x04001AA4 RID: 6820
		BitmapReverse,
		// Token: 0x04001AA5 RID: 6821
		NoBitmapReverse,
		// Token: 0x04001AA6 RID: 6822
		BitmapIgnoreCaseReverse,
		// Token: 0x04001AA7 RID: 6823
		NoBitmapIgnoreCaseReverse,
		// Token: 0x04001AA8 RID: 6824
		UnicodeChar,
		// Token: 0x04001AA9 RID: 6825
		NoUnicodeChar,
		// Token: 0x04001AAA RID: 6826
		UnicodeCharIgnoreCase,
		// Token: 0x04001AAB RID: 6827
		NoUnicodeCharIgnoreCase,
		// Token: 0x04001AAC RID: 6828
		UnicodeCharReverse,
		// Token: 0x04001AAD RID: 6829
		NoUnicodeCharReverse,
		// Token: 0x04001AAE RID: 6830
		UnicodeCharIgnoreCaseReverse,
		// Token: 0x04001AAF RID: 6831
		NoUnicodeCharIgnoreCaseReverse,
		// Token: 0x04001AB0 RID: 6832
		UnicodeRange,
		// Token: 0x04001AB1 RID: 6833
		NoUnicodeRange,
		// Token: 0x04001AB2 RID: 6834
		UnicodeRangeIgnoreCase,
		// Token: 0x04001AB3 RID: 6835
		NoUnicodeRangeIgnoreCase,
		// Token: 0x04001AB4 RID: 6836
		UnicodeRangeReverse,
		// Token: 0x04001AB5 RID: 6837
		NoUnicodeRangeReverse,
		// Token: 0x04001AB6 RID: 6838
		UnicodeRangeIgnoreCaseReverse,
		// Token: 0x04001AB7 RID: 6839
		NoUnicodeRangeIgnoreCaseReverse,
		// Token: 0x04001AB8 RID: 6840
		UnicodeBitmap,
		// Token: 0x04001AB9 RID: 6841
		NoUnicodeBitmap,
		// Token: 0x04001ABA RID: 6842
		UnicodeBitmapIgnoreCase,
		// Token: 0x04001ABB RID: 6843
		NoUnicodeBitmapIgnoreCase,
		// Token: 0x04001ABC RID: 6844
		UnicodeBitmapReverse,
		// Token: 0x04001ABD RID: 6845
		NoUnicodeBitmapReverse,
		// Token: 0x04001ABE RID: 6846
		UnicodeBitmapIgnoreCaseReverse,
		// Token: 0x04001ABF RID: 6847
		NoUnicodeBitmapIgnoreCaseReverse,
		// Token: 0x04001AC0 RID: 6848
		CategoryAny,
		// Token: 0x04001AC1 RID: 6849
		NoCategoryAny,
		// Token: 0x04001AC2 RID: 6850
		CategoryAnyReverse,
		// Token: 0x04001AC3 RID: 6851
		NoCategoryAnyReverse,
		// Token: 0x04001AC4 RID: 6852
		CategoryAnySingleline,
		// Token: 0x04001AC5 RID: 6853
		NoCategoryAnySingleline,
		// Token: 0x04001AC6 RID: 6854
		CategoryAnySinglelineReverse,
		// Token: 0x04001AC7 RID: 6855
		NoCategoryAnySinglelineReverse,
		// Token: 0x04001AC8 RID: 6856
		CategoryDigit,
		// Token: 0x04001AC9 RID: 6857
		NoCategoryDigit,
		// Token: 0x04001ACA RID: 6858
		CategoryDigitReverse,
		// Token: 0x04001ACB RID: 6859
		NoCategoryDigitReverse,
		// Token: 0x04001ACC RID: 6860
		CategoryWord,
		// Token: 0x04001ACD RID: 6861
		NoCategoryWord,
		// Token: 0x04001ACE RID: 6862
		CategoryWordReverse,
		// Token: 0x04001ACF RID: 6863
		NoCategoryWordReverse,
		// Token: 0x04001AD0 RID: 6864
		CategoryWhiteSpace,
		// Token: 0x04001AD1 RID: 6865
		NoCategoryWhiteSpace,
		// Token: 0x04001AD2 RID: 6866
		CategoryWhiteSpaceReverse,
		// Token: 0x04001AD3 RID: 6867
		NoCategoryWhiteSpaceReverse,
		// Token: 0x04001AD4 RID: 6868
		CategoryEcmaWord,
		// Token: 0x04001AD5 RID: 6869
		NoCategoryEcmaWord,
		// Token: 0x04001AD6 RID: 6870
		CategoryEcmaWordReverse,
		// Token: 0x04001AD7 RID: 6871
		NoCategoryEcmaWordReverse,
		// Token: 0x04001AD8 RID: 6872
		CategoryEcmaWhiteSpace,
		// Token: 0x04001AD9 RID: 6873
		NoCategoryEcmaWhiteSpace,
		// Token: 0x04001ADA RID: 6874
		CategoryEcmaWhiteSpaceReverse,
		// Token: 0x04001ADB RID: 6875
		NoCategoryEcmaWhiteSpaceReverse,
		// Token: 0x04001ADC RID: 6876
		CategoryUnicode,
		// Token: 0x04001ADD RID: 6877
		NoCategoryUnicode,
		// Token: 0x04001ADE RID: 6878
		CategoryUnicodeReverse,
		// Token: 0x04001ADF RID: 6879
		NoCategoryUnicodeReverse,
		// Token: 0x04001AE0 RID: 6880
		CategoryUnicodeLetter,
		// Token: 0x04001AE1 RID: 6881
		NoCategoryUnicodeLetter,
		// Token: 0x04001AE2 RID: 6882
		CategoryUnicodeLetterReverse,
		// Token: 0x04001AE3 RID: 6883
		NoCategoryUnicodeLetterReverse,
		// Token: 0x04001AE4 RID: 6884
		CategoryUnicodeMark,
		// Token: 0x04001AE5 RID: 6885
		NoCategoryUnicodeMark,
		// Token: 0x04001AE6 RID: 6886
		CategoryUnicodeMarkReverse,
		// Token: 0x04001AE7 RID: 6887
		NoCategoryUnicodeMarkReverse,
		// Token: 0x04001AE8 RID: 6888
		CategoryUnicodeNumber,
		// Token: 0x04001AE9 RID: 6889
		NoCategoryUnicodeNumber,
		// Token: 0x04001AEA RID: 6890
		CategoryUnicodeNumberReverse,
		// Token: 0x04001AEB RID: 6891
		NoCategoryUnicodeNumberReverse,
		// Token: 0x04001AEC RID: 6892
		CategoryUnicodeSeparator,
		// Token: 0x04001AED RID: 6893
		NoCategoryUnicodeSeparator,
		// Token: 0x04001AEE RID: 6894
		CategoryUnicodeSeparatorReverse,
		// Token: 0x04001AEF RID: 6895
		NoCategoryUnicodeSeparatorReverse,
		// Token: 0x04001AF0 RID: 6896
		CategoryUnicodePunctuation,
		// Token: 0x04001AF1 RID: 6897
		NoCategoryUnicodePunctuation,
		// Token: 0x04001AF2 RID: 6898
		CategoryUnicodePunctuationReverse,
		// Token: 0x04001AF3 RID: 6899
		NoCategoryUnicodePunctuationReverse,
		// Token: 0x04001AF4 RID: 6900
		CategoryUnicodeSymbol,
		// Token: 0x04001AF5 RID: 6901
		NoCategoryUnicodeSymbol,
		// Token: 0x04001AF6 RID: 6902
		CategoryUnicodeSymbolReverse,
		// Token: 0x04001AF7 RID: 6903
		NoCategoryUnicodeSymbolReverse,
		// Token: 0x04001AF8 RID: 6904
		CategoryUnicodeSpecials,
		// Token: 0x04001AF9 RID: 6905
		NoCategoryUnicodeSpecials,
		// Token: 0x04001AFA RID: 6906
		CategoryUnicodeSpecialsReverse,
		// Token: 0x04001AFB RID: 6907
		NoCategoryUnicodeSpecialsReverse,
		// Token: 0x04001AFC RID: 6908
		CategoryUnicodeOther,
		// Token: 0x04001AFD RID: 6909
		NoCategoryUnicodeOther,
		// Token: 0x04001AFE RID: 6910
		CategoryUnicodeOtherReverse,
		// Token: 0x04001AFF RID: 6911
		NoCategoryUnicodeOtherReverse,
		// Token: 0x04001B00 RID: 6912
		CategoryGeneral,
		// Token: 0x04001B01 RID: 6913
		NoCategoryGeneral,
		// Token: 0x04001B02 RID: 6914
		CategoryGeneralReverse,
		// Token: 0x04001B03 RID: 6915
		NoCategoryGeneralReverse,
		// Token: 0x04001B04 RID: 6916
		Reference,
		// Token: 0x04001B05 RID: 6917
		ReferenceIgnoreCase,
		// Token: 0x04001B06 RID: 6918
		ReferenceReverse,
		// Token: 0x04001B07 RID: 6919
		ReferenceIgnoreCaseReverse,
		// Token: 0x04001B08 RID: 6920
		OpenGroup,
		// Token: 0x04001B09 RID: 6921
		CloseGroup,
		// Token: 0x04001B0A RID: 6922
		BalanceStart,
		// Token: 0x04001B0B RID: 6923
		Balance,
		// Token: 0x04001B0C RID: 6924
		IfDefined,
		// Token: 0x04001B0D RID: 6925
		Jump,
		// Token: 0x04001B0E RID: 6926
		SubExpression,
		// Token: 0x04001B0F RID: 6927
		Test,
		// Token: 0x04001B10 RID: 6928
		Branch,
		// Token: 0x04001B11 RID: 6929
		TestCharGroup,
		// Token: 0x04001B12 RID: 6930
		Anchor,
		// Token: 0x04001B13 RID: 6931
		AnchorReverse,
		// Token: 0x04001B14 RID: 6932
		Repeat,
		// Token: 0x04001B15 RID: 6933
		RepeatLazy,
		// Token: 0x04001B16 RID: 6934
		Until,
		// Token: 0x04001B17 RID: 6935
		FastRepeat,
		// Token: 0x04001B18 RID: 6936
		FastRepeatLazy,
		// Token: 0x04001B19 RID: 6937
		RepeatInfinite,
		// Token: 0x04001B1A RID: 6938
		RepeatInfiniteLazy
	}
}
