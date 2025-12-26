using System;

namespace System.Text.RegularExpressions
{
	// Token: 0x0200048D RID: 1165
	internal enum Category : ushort
	{
		// Token: 0x04001951 RID: 6481
		None,
		// Token: 0x04001952 RID: 6482
		Any,
		// Token: 0x04001953 RID: 6483
		AnySingleline,
		// Token: 0x04001954 RID: 6484
		Word,
		// Token: 0x04001955 RID: 6485
		Digit,
		// Token: 0x04001956 RID: 6486
		WhiteSpace,
		// Token: 0x04001957 RID: 6487
		EcmaAny,
		// Token: 0x04001958 RID: 6488
		EcmaAnySingleline,
		// Token: 0x04001959 RID: 6489
		EcmaWord,
		// Token: 0x0400195A RID: 6490
		EcmaDigit,
		// Token: 0x0400195B RID: 6491
		EcmaWhiteSpace,
		// Token: 0x0400195C RID: 6492
		UnicodeL,
		// Token: 0x0400195D RID: 6493
		UnicodeM,
		// Token: 0x0400195E RID: 6494
		UnicodeN,
		// Token: 0x0400195F RID: 6495
		UnicodeZ,
		// Token: 0x04001960 RID: 6496
		UnicodeP,
		// Token: 0x04001961 RID: 6497
		UnicodeS,
		// Token: 0x04001962 RID: 6498
		UnicodeC,
		// Token: 0x04001963 RID: 6499
		UnicodeLu,
		// Token: 0x04001964 RID: 6500
		UnicodeLl,
		// Token: 0x04001965 RID: 6501
		UnicodeLt,
		// Token: 0x04001966 RID: 6502
		UnicodeLm,
		// Token: 0x04001967 RID: 6503
		UnicodeLo,
		// Token: 0x04001968 RID: 6504
		UnicodeMn,
		// Token: 0x04001969 RID: 6505
		UnicodeMe,
		// Token: 0x0400196A RID: 6506
		UnicodeMc,
		// Token: 0x0400196B RID: 6507
		UnicodeNd,
		// Token: 0x0400196C RID: 6508
		UnicodeNl,
		// Token: 0x0400196D RID: 6509
		UnicodeNo,
		// Token: 0x0400196E RID: 6510
		UnicodeZs,
		// Token: 0x0400196F RID: 6511
		UnicodeZl,
		// Token: 0x04001970 RID: 6512
		UnicodeZp,
		// Token: 0x04001971 RID: 6513
		UnicodePd,
		// Token: 0x04001972 RID: 6514
		UnicodePs,
		// Token: 0x04001973 RID: 6515
		UnicodePi,
		// Token: 0x04001974 RID: 6516
		UnicodePe,
		// Token: 0x04001975 RID: 6517
		UnicodePf,
		// Token: 0x04001976 RID: 6518
		UnicodePc,
		// Token: 0x04001977 RID: 6519
		UnicodePo,
		// Token: 0x04001978 RID: 6520
		UnicodeSm,
		// Token: 0x04001979 RID: 6521
		UnicodeSc,
		// Token: 0x0400197A RID: 6522
		UnicodeSk,
		// Token: 0x0400197B RID: 6523
		UnicodeSo,
		// Token: 0x0400197C RID: 6524
		UnicodeCc,
		// Token: 0x0400197D RID: 6525
		UnicodeCf,
		// Token: 0x0400197E RID: 6526
		UnicodeCo,
		// Token: 0x0400197F RID: 6527
		UnicodeCs,
		// Token: 0x04001980 RID: 6528
		UnicodeCn,
		// Token: 0x04001981 RID: 6529
		UnicodeBasicLatin,
		// Token: 0x04001982 RID: 6530
		UnicodeLatin1Supplement,
		// Token: 0x04001983 RID: 6531
		UnicodeLatinExtendedA,
		// Token: 0x04001984 RID: 6532
		UnicodeLatinExtendedB,
		// Token: 0x04001985 RID: 6533
		UnicodeIPAExtensions,
		// Token: 0x04001986 RID: 6534
		UnicodeSpacingModifierLetters,
		// Token: 0x04001987 RID: 6535
		UnicodeCombiningDiacriticalMarks,
		// Token: 0x04001988 RID: 6536
		UnicodeGreek,
		// Token: 0x04001989 RID: 6537
		UnicodeCyrillic,
		// Token: 0x0400198A RID: 6538
		UnicodeArmenian,
		// Token: 0x0400198B RID: 6539
		UnicodeHebrew,
		// Token: 0x0400198C RID: 6540
		UnicodeArabic,
		// Token: 0x0400198D RID: 6541
		UnicodeSyriac,
		// Token: 0x0400198E RID: 6542
		UnicodeThaana,
		// Token: 0x0400198F RID: 6543
		UnicodeDevanagari,
		// Token: 0x04001990 RID: 6544
		UnicodeBengali,
		// Token: 0x04001991 RID: 6545
		UnicodeGurmukhi,
		// Token: 0x04001992 RID: 6546
		UnicodeGujarati,
		// Token: 0x04001993 RID: 6547
		UnicodeOriya,
		// Token: 0x04001994 RID: 6548
		UnicodeTamil,
		// Token: 0x04001995 RID: 6549
		UnicodeTelugu,
		// Token: 0x04001996 RID: 6550
		UnicodeKannada,
		// Token: 0x04001997 RID: 6551
		UnicodeMalayalam,
		// Token: 0x04001998 RID: 6552
		UnicodeSinhala,
		// Token: 0x04001999 RID: 6553
		UnicodeThai,
		// Token: 0x0400199A RID: 6554
		UnicodeLao,
		// Token: 0x0400199B RID: 6555
		UnicodeTibetan,
		// Token: 0x0400199C RID: 6556
		UnicodeMyanmar,
		// Token: 0x0400199D RID: 6557
		UnicodeGeorgian,
		// Token: 0x0400199E RID: 6558
		UnicodeHangulJamo,
		// Token: 0x0400199F RID: 6559
		UnicodeEthiopic,
		// Token: 0x040019A0 RID: 6560
		UnicodeCherokee,
		// Token: 0x040019A1 RID: 6561
		UnicodeUnifiedCanadianAboriginalSyllabics,
		// Token: 0x040019A2 RID: 6562
		UnicodeOgham,
		// Token: 0x040019A3 RID: 6563
		UnicodeRunic,
		// Token: 0x040019A4 RID: 6564
		UnicodeKhmer,
		// Token: 0x040019A5 RID: 6565
		UnicodeMongolian,
		// Token: 0x040019A6 RID: 6566
		UnicodeLatinExtendedAdditional,
		// Token: 0x040019A7 RID: 6567
		UnicodeGreekExtended,
		// Token: 0x040019A8 RID: 6568
		UnicodeGeneralPunctuation,
		// Token: 0x040019A9 RID: 6569
		UnicodeSuperscriptsandSubscripts,
		// Token: 0x040019AA RID: 6570
		UnicodeCurrencySymbols,
		// Token: 0x040019AB RID: 6571
		UnicodeCombiningMarksforSymbols,
		// Token: 0x040019AC RID: 6572
		UnicodeLetterlikeSymbols,
		// Token: 0x040019AD RID: 6573
		UnicodeNumberForms,
		// Token: 0x040019AE RID: 6574
		UnicodeArrows,
		// Token: 0x040019AF RID: 6575
		UnicodeMathematicalOperators,
		// Token: 0x040019B0 RID: 6576
		UnicodeMiscellaneousTechnical,
		// Token: 0x040019B1 RID: 6577
		UnicodeControlPictures,
		// Token: 0x040019B2 RID: 6578
		UnicodeOpticalCharacterRecognition,
		// Token: 0x040019B3 RID: 6579
		UnicodeEnclosedAlphanumerics,
		// Token: 0x040019B4 RID: 6580
		UnicodeBoxDrawing,
		// Token: 0x040019B5 RID: 6581
		UnicodeBlockElements,
		// Token: 0x040019B6 RID: 6582
		UnicodeGeometricShapes,
		// Token: 0x040019B7 RID: 6583
		UnicodeMiscellaneousSymbols,
		// Token: 0x040019B8 RID: 6584
		UnicodeDingbats,
		// Token: 0x040019B9 RID: 6585
		UnicodeBraillePatterns,
		// Token: 0x040019BA RID: 6586
		UnicodeCJKRadicalsSupplement,
		// Token: 0x040019BB RID: 6587
		UnicodeKangxiRadicals,
		// Token: 0x040019BC RID: 6588
		UnicodeIdeographicDescriptionCharacters,
		// Token: 0x040019BD RID: 6589
		UnicodeCJKSymbolsandPunctuation,
		// Token: 0x040019BE RID: 6590
		UnicodeHiragana,
		// Token: 0x040019BF RID: 6591
		UnicodeKatakana,
		// Token: 0x040019C0 RID: 6592
		UnicodeBopomofo,
		// Token: 0x040019C1 RID: 6593
		UnicodeHangulCompatibilityJamo,
		// Token: 0x040019C2 RID: 6594
		UnicodeKanbun,
		// Token: 0x040019C3 RID: 6595
		UnicodeBopomofoExtended,
		// Token: 0x040019C4 RID: 6596
		UnicodeEnclosedCJKLettersandMonths,
		// Token: 0x040019C5 RID: 6597
		UnicodeCJKCompatibility,
		// Token: 0x040019C6 RID: 6598
		UnicodeCJKUnifiedIdeographsExtensionA,
		// Token: 0x040019C7 RID: 6599
		UnicodeCJKUnifiedIdeographs,
		// Token: 0x040019C8 RID: 6600
		UnicodeYiSyllables,
		// Token: 0x040019C9 RID: 6601
		UnicodeYiRadicals,
		// Token: 0x040019CA RID: 6602
		UnicodeHangulSyllables,
		// Token: 0x040019CB RID: 6603
		UnicodeHighSurrogates,
		// Token: 0x040019CC RID: 6604
		UnicodeHighPrivateUseSurrogates,
		// Token: 0x040019CD RID: 6605
		UnicodeLowSurrogates,
		// Token: 0x040019CE RID: 6606
		UnicodePrivateUse,
		// Token: 0x040019CF RID: 6607
		UnicodeCJKCompatibilityIdeographs,
		// Token: 0x040019D0 RID: 6608
		UnicodeAlphabeticPresentationForms,
		// Token: 0x040019D1 RID: 6609
		UnicodeArabicPresentationFormsA,
		// Token: 0x040019D2 RID: 6610
		UnicodeCombiningHalfMarks,
		// Token: 0x040019D3 RID: 6611
		UnicodeCJKCompatibilityForms,
		// Token: 0x040019D4 RID: 6612
		UnicodeSmallFormVariants,
		// Token: 0x040019D5 RID: 6613
		UnicodeArabicPresentationFormsB,
		// Token: 0x040019D6 RID: 6614
		UnicodeSpecials,
		// Token: 0x040019D7 RID: 6615
		UnicodeHalfwidthandFullwidthForms,
		// Token: 0x040019D8 RID: 6616
		UnicodeOldItalic,
		// Token: 0x040019D9 RID: 6617
		UnicodeGothic,
		// Token: 0x040019DA RID: 6618
		UnicodeDeseret,
		// Token: 0x040019DB RID: 6619
		UnicodeByzantineMusicalSymbols,
		// Token: 0x040019DC RID: 6620
		UnicodeMusicalSymbols,
		// Token: 0x040019DD RID: 6621
		UnicodeMathematicalAlphanumericSymbols,
		// Token: 0x040019DE RID: 6622
		UnicodeCJKUnifiedIdeographsExtensionB,
		// Token: 0x040019DF RID: 6623
		UnicodeCJKCompatibilityIdeographsSupplement,
		// Token: 0x040019E0 RID: 6624
		UnicodeTags,
		// Token: 0x040019E1 RID: 6625
		LastValue
	}
}
