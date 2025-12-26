using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Key codes returned by Event.keyCode. These map directly to a physical key on the keyboard.</para>
	/// </summary>
	// Token: 0x020001C3 RID: 451
	public enum KeyCode
	{
		/// <summary>
		///   <para>Not assigned (never returned as the result of a keystroke).</para>
		/// </summary>
		// Token: 0x04000578 RID: 1400
		None,
		/// <summary>
		///   <para>The backspace key.</para>
		/// </summary>
		// Token: 0x04000579 RID: 1401
		Backspace = 8,
		/// <summary>
		///   <para>The forward delete key.</para>
		/// </summary>
		// Token: 0x0400057A RID: 1402
		Delete = 127,
		/// <summary>
		///   <para>The tab key.</para>
		/// </summary>
		// Token: 0x0400057B RID: 1403
		Tab = 9,
		/// <summary>
		///   <para>The Clear key.</para>
		/// </summary>
		// Token: 0x0400057C RID: 1404
		Clear = 12,
		/// <summary>
		///   <para>Return key.</para>
		/// </summary>
		// Token: 0x0400057D RID: 1405
		Return,
		/// <summary>
		///   <para>Pause on PC machines.</para>
		/// </summary>
		// Token: 0x0400057E RID: 1406
		Pause = 19,
		/// <summary>
		///   <para>Escape key.</para>
		/// </summary>
		// Token: 0x0400057F RID: 1407
		Escape = 27,
		/// <summary>
		///   <para>Space key.</para>
		/// </summary>
		// Token: 0x04000580 RID: 1408
		Space = 32,
		/// <summary>
		///   <para>Numeric keypad 0.</para>
		/// </summary>
		// Token: 0x04000581 RID: 1409
		Keypad0 = 256,
		/// <summary>
		///   <para>Numeric keypad 1.</para>
		/// </summary>
		// Token: 0x04000582 RID: 1410
		Keypad1,
		/// <summary>
		///   <para>Numeric keypad 2.</para>
		/// </summary>
		// Token: 0x04000583 RID: 1411
		Keypad2,
		/// <summary>
		///   <para>Numeric keypad 3.</para>
		/// </summary>
		// Token: 0x04000584 RID: 1412
		Keypad3,
		/// <summary>
		///   <para>Numeric keypad 4.</para>
		/// </summary>
		// Token: 0x04000585 RID: 1413
		Keypad4,
		/// <summary>
		///   <para>Numeric keypad 5.</para>
		/// </summary>
		// Token: 0x04000586 RID: 1414
		Keypad5,
		/// <summary>
		///   <para>Numeric keypad 6.</para>
		/// </summary>
		// Token: 0x04000587 RID: 1415
		Keypad6,
		/// <summary>
		///   <para>Numeric keypad 7.</para>
		/// </summary>
		// Token: 0x04000588 RID: 1416
		Keypad7,
		/// <summary>
		///   <para>Numeric keypad 8.</para>
		/// </summary>
		// Token: 0x04000589 RID: 1417
		Keypad8,
		/// <summary>
		///   <para>Numeric keypad 9.</para>
		/// </summary>
		// Token: 0x0400058A RID: 1418
		Keypad9,
		/// <summary>
		///   <para>Numeric keypad '.'.</para>
		/// </summary>
		// Token: 0x0400058B RID: 1419
		KeypadPeriod,
		/// <summary>
		///   <para>Numeric keypad '/'.</para>
		/// </summary>
		// Token: 0x0400058C RID: 1420
		KeypadDivide,
		/// <summary>
		///   <para>Numeric keypad '*'.</para>
		/// </summary>
		// Token: 0x0400058D RID: 1421
		KeypadMultiply,
		/// <summary>
		///   <para>Numeric keypad '-'.</para>
		/// </summary>
		// Token: 0x0400058E RID: 1422
		KeypadMinus,
		/// <summary>
		///   <para>Numeric keypad '+'.</para>
		/// </summary>
		// Token: 0x0400058F RID: 1423
		KeypadPlus,
		/// <summary>
		///   <para>Numeric keypad enter.</para>
		/// </summary>
		// Token: 0x04000590 RID: 1424
		KeypadEnter,
		/// <summary>
		///   <para>Numeric keypad '='.</para>
		/// </summary>
		// Token: 0x04000591 RID: 1425
		KeypadEquals,
		/// <summary>
		///   <para>Up arrow key.</para>
		/// </summary>
		// Token: 0x04000592 RID: 1426
		UpArrow,
		/// <summary>
		///   <para>Down arrow key.</para>
		/// </summary>
		// Token: 0x04000593 RID: 1427
		DownArrow,
		/// <summary>
		///   <para>Right arrow key.</para>
		/// </summary>
		// Token: 0x04000594 RID: 1428
		RightArrow,
		/// <summary>
		///   <para>Left arrow key.</para>
		/// </summary>
		// Token: 0x04000595 RID: 1429
		LeftArrow,
		/// <summary>
		///   <para>Insert key key.</para>
		/// </summary>
		// Token: 0x04000596 RID: 1430
		Insert,
		/// <summary>
		///   <para>Home key.</para>
		/// </summary>
		// Token: 0x04000597 RID: 1431
		Home,
		/// <summary>
		///   <para>End key.</para>
		/// </summary>
		// Token: 0x04000598 RID: 1432
		End,
		/// <summary>
		///   <para>Page up.</para>
		/// </summary>
		// Token: 0x04000599 RID: 1433
		PageUp,
		/// <summary>
		///   <para>Page down.</para>
		/// </summary>
		// Token: 0x0400059A RID: 1434
		PageDown,
		/// <summary>
		///   <para>F1 function key.</para>
		/// </summary>
		// Token: 0x0400059B RID: 1435
		F1,
		/// <summary>
		///   <para>F2 function key.</para>
		/// </summary>
		// Token: 0x0400059C RID: 1436
		F2,
		/// <summary>
		///   <para>F3 function key.</para>
		/// </summary>
		// Token: 0x0400059D RID: 1437
		F3,
		/// <summary>
		///   <para>F4 function key.</para>
		/// </summary>
		// Token: 0x0400059E RID: 1438
		F4,
		/// <summary>
		///   <para>F5 function key.</para>
		/// </summary>
		// Token: 0x0400059F RID: 1439
		F5,
		/// <summary>
		///   <para>F6 function key.</para>
		/// </summary>
		// Token: 0x040005A0 RID: 1440
		F6,
		/// <summary>
		///   <para>F7 function key.</para>
		/// </summary>
		// Token: 0x040005A1 RID: 1441
		F7,
		/// <summary>
		///   <para>F8 function key.</para>
		/// </summary>
		// Token: 0x040005A2 RID: 1442
		F8,
		/// <summary>
		///   <para>F9 function key.</para>
		/// </summary>
		// Token: 0x040005A3 RID: 1443
		F9,
		/// <summary>
		///   <para>F10 function key.</para>
		/// </summary>
		// Token: 0x040005A4 RID: 1444
		F10,
		/// <summary>
		///   <para>F11 function key.</para>
		/// </summary>
		// Token: 0x040005A5 RID: 1445
		F11,
		/// <summary>
		///   <para>F12 function key.</para>
		/// </summary>
		// Token: 0x040005A6 RID: 1446
		F12,
		/// <summary>
		///   <para>F13 function key.</para>
		/// </summary>
		// Token: 0x040005A7 RID: 1447
		F13,
		/// <summary>
		///   <para>F14 function key.</para>
		/// </summary>
		// Token: 0x040005A8 RID: 1448
		F14,
		/// <summary>
		///   <para>F15 function key.</para>
		/// </summary>
		// Token: 0x040005A9 RID: 1449
		F15,
		/// <summary>
		///   <para>The '0' key on the top of the alphanumeric keyboard.</para>
		/// </summary>
		// Token: 0x040005AA RID: 1450
		Alpha0 = 48,
		/// <summary>
		///   <para>The '1' key on the top of the alphanumeric keyboard.</para>
		/// </summary>
		// Token: 0x040005AB RID: 1451
		Alpha1,
		/// <summary>
		///   <para>The '2' key on the top of the alphanumeric keyboard.</para>
		/// </summary>
		// Token: 0x040005AC RID: 1452
		Alpha2,
		/// <summary>
		///   <para>The '3' key on the top of the alphanumeric keyboard.</para>
		/// </summary>
		// Token: 0x040005AD RID: 1453
		Alpha3,
		/// <summary>
		///   <para>The '4' key on the top of the alphanumeric keyboard.</para>
		/// </summary>
		// Token: 0x040005AE RID: 1454
		Alpha4,
		/// <summary>
		///   <para>The '5' key on the top of the alphanumeric keyboard.</para>
		/// </summary>
		// Token: 0x040005AF RID: 1455
		Alpha5,
		/// <summary>
		///   <para>The '6' key on the top of the alphanumeric keyboard.</para>
		/// </summary>
		// Token: 0x040005B0 RID: 1456
		Alpha6,
		/// <summary>
		///   <para>The '7' key on the top of the alphanumeric keyboard.</para>
		/// </summary>
		// Token: 0x040005B1 RID: 1457
		Alpha7,
		/// <summary>
		///   <para>The '8' key on the top of the alphanumeric keyboard.</para>
		/// </summary>
		// Token: 0x040005B2 RID: 1458
		Alpha8,
		/// <summary>
		///   <para>The '9' key on the top of the alphanumeric keyboard.</para>
		/// </summary>
		// Token: 0x040005B3 RID: 1459
		Alpha9,
		/// <summary>
		///   <para>Exclamation mark key '!'.</para>
		/// </summary>
		// Token: 0x040005B4 RID: 1460
		Exclaim = 33,
		/// <summary>
		///   <para>Double quote key '"'.</para>
		/// </summary>
		// Token: 0x040005B5 RID: 1461
		DoubleQuote,
		/// <summary>
		///   <para>Hash key '#'.</para>
		/// </summary>
		// Token: 0x040005B6 RID: 1462
		Hash,
		/// <summary>
		///   <para>Dollar sign key '$'.</para>
		/// </summary>
		// Token: 0x040005B7 RID: 1463
		Dollar,
		/// <summary>
		///   <para>Ampersand key '&amp;'.</para>
		/// </summary>
		// Token: 0x040005B8 RID: 1464
		Ampersand = 38,
		/// <summary>
		///   <para>Quote key '.</para>
		/// </summary>
		// Token: 0x040005B9 RID: 1465
		Quote,
		/// <summary>
		///   <para>Left Parenthesis key '('.</para>
		/// </summary>
		// Token: 0x040005BA RID: 1466
		LeftParen,
		/// <summary>
		///   <para>Right Parenthesis key ')'.</para>
		/// </summary>
		// Token: 0x040005BB RID: 1467
		RightParen,
		/// <summary>
		///   <para>Asterisk key '*'.</para>
		/// </summary>
		// Token: 0x040005BC RID: 1468
		Asterisk,
		/// <summary>
		///   <para>Plus key '+'.</para>
		/// </summary>
		// Token: 0x040005BD RID: 1469
		Plus,
		/// <summary>
		///   <para>Comma ',' key.</para>
		/// </summary>
		// Token: 0x040005BE RID: 1470
		Comma,
		/// <summary>
		///   <para>Minus '-' key.</para>
		/// </summary>
		// Token: 0x040005BF RID: 1471
		Minus,
		/// <summary>
		///   <para>Period '.' key.</para>
		/// </summary>
		// Token: 0x040005C0 RID: 1472
		Period,
		/// <summary>
		///   <para>Slash '/' key.</para>
		/// </summary>
		// Token: 0x040005C1 RID: 1473
		Slash,
		/// <summary>
		///   <para>Colon ':' key.</para>
		/// </summary>
		// Token: 0x040005C2 RID: 1474
		Colon = 58,
		/// <summary>
		///   <para>Semicolon ';' key.</para>
		/// </summary>
		// Token: 0x040005C3 RID: 1475
		Semicolon,
		/// <summary>
		///   <para>Less than '&lt;' key.</para>
		/// </summary>
		// Token: 0x040005C4 RID: 1476
		Less,
		/// <summary>
		///   <para>Equals '=' key.</para>
		/// </summary>
		// Token: 0x040005C5 RID: 1477
		Equals,
		/// <summary>
		///   <para>Greater than '&gt;' key.</para>
		/// </summary>
		// Token: 0x040005C6 RID: 1478
		Greater,
		/// <summary>
		///   <para>Question mark '?' key.</para>
		/// </summary>
		// Token: 0x040005C7 RID: 1479
		Question,
		/// <summary>
		///   <para>At key '@'.</para>
		/// </summary>
		// Token: 0x040005C8 RID: 1480
		At,
		/// <summary>
		///   <para>Left square bracket key '['.</para>
		/// </summary>
		// Token: 0x040005C9 RID: 1481
		LeftBracket = 91,
		/// <summary>
		///   <para>Backslash key '\'.</para>
		/// </summary>
		// Token: 0x040005CA RID: 1482
		Backslash,
		/// <summary>
		///   <para>Right square bracket key ']'.</para>
		/// </summary>
		// Token: 0x040005CB RID: 1483
		RightBracket,
		/// <summary>
		///   <para>Caret key '^'.</para>
		/// </summary>
		// Token: 0x040005CC RID: 1484
		Caret,
		/// <summary>
		///   <para>Underscore '_' key.</para>
		/// </summary>
		// Token: 0x040005CD RID: 1485
		Underscore,
		/// <summary>
		///   <para>Back quote key '`'.</para>
		/// </summary>
		// Token: 0x040005CE RID: 1486
		BackQuote,
		/// <summary>
		///   <para>'a' key.</para>
		/// </summary>
		// Token: 0x040005CF RID: 1487
		A,
		/// <summary>
		///   <para>'b' key.</para>
		/// </summary>
		// Token: 0x040005D0 RID: 1488
		B,
		/// <summary>
		///   <para>'c' key.</para>
		/// </summary>
		// Token: 0x040005D1 RID: 1489
		C,
		/// <summary>
		///   <para>'d' key.</para>
		/// </summary>
		// Token: 0x040005D2 RID: 1490
		D,
		/// <summary>
		///   <para>'e' key.</para>
		/// </summary>
		// Token: 0x040005D3 RID: 1491
		E,
		/// <summary>
		///   <para>'f' key.</para>
		/// </summary>
		// Token: 0x040005D4 RID: 1492
		F,
		/// <summary>
		///   <para>'g' key.</para>
		/// </summary>
		// Token: 0x040005D5 RID: 1493
		G,
		/// <summary>
		///   <para>'h' key.</para>
		/// </summary>
		// Token: 0x040005D6 RID: 1494
		H,
		/// <summary>
		///   <para>'i' key.</para>
		/// </summary>
		// Token: 0x040005D7 RID: 1495
		I,
		/// <summary>
		///   <para>'j' key.</para>
		/// </summary>
		// Token: 0x040005D8 RID: 1496
		J,
		/// <summary>
		///   <para>'k' key.</para>
		/// </summary>
		// Token: 0x040005D9 RID: 1497
		K,
		/// <summary>
		///   <para>'l' key.</para>
		/// </summary>
		// Token: 0x040005DA RID: 1498
		L,
		/// <summary>
		///   <para>'m' key.</para>
		/// </summary>
		// Token: 0x040005DB RID: 1499
		M,
		/// <summary>
		///   <para>'n' key.</para>
		/// </summary>
		// Token: 0x040005DC RID: 1500
		N,
		/// <summary>
		///   <para>'o' key.</para>
		/// </summary>
		// Token: 0x040005DD RID: 1501
		O,
		/// <summary>
		///   <para>'p' key.</para>
		/// </summary>
		// Token: 0x040005DE RID: 1502
		P,
		/// <summary>
		///   <para>'q' key.</para>
		/// </summary>
		// Token: 0x040005DF RID: 1503
		Q,
		/// <summary>
		///   <para>'r' key.</para>
		/// </summary>
		// Token: 0x040005E0 RID: 1504
		R,
		/// <summary>
		///   <para>'s' key.</para>
		/// </summary>
		// Token: 0x040005E1 RID: 1505
		S,
		/// <summary>
		///   <para>'t' key.</para>
		/// </summary>
		// Token: 0x040005E2 RID: 1506
		T,
		/// <summary>
		///   <para>'u' key.</para>
		/// </summary>
		// Token: 0x040005E3 RID: 1507
		U,
		/// <summary>
		///   <para>'v' key.</para>
		/// </summary>
		// Token: 0x040005E4 RID: 1508
		V,
		/// <summary>
		///   <para>'w' key.</para>
		/// </summary>
		// Token: 0x040005E5 RID: 1509
		W,
		/// <summary>
		///   <para>'x' key.</para>
		/// </summary>
		// Token: 0x040005E6 RID: 1510
		X,
		/// <summary>
		///   <para>'y' key.</para>
		/// </summary>
		// Token: 0x040005E7 RID: 1511
		Y,
		/// <summary>
		///   <para>'z' key.</para>
		/// </summary>
		// Token: 0x040005E8 RID: 1512
		Z,
		/// <summary>
		///   <para>Numlock key.</para>
		/// </summary>
		// Token: 0x040005E9 RID: 1513
		Numlock = 300,
		/// <summary>
		///   <para>Capslock key.</para>
		/// </summary>
		// Token: 0x040005EA RID: 1514
		CapsLock,
		/// <summary>
		///   <para>Scroll lock key.</para>
		/// </summary>
		// Token: 0x040005EB RID: 1515
		ScrollLock,
		/// <summary>
		///   <para>Right shift key.</para>
		/// </summary>
		// Token: 0x040005EC RID: 1516
		RightShift,
		/// <summary>
		///   <para>Left shift key.</para>
		/// </summary>
		// Token: 0x040005ED RID: 1517
		LeftShift,
		/// <summary>
		///   <para>Right Control key.</para>
		/// </summary>
		// Token: 0x040005EE RID: 1518
		RightControl,
		/// <summary>
		///   <para>Left Control key.</para>
		/// </summary>
		// Token: 0x040005EF RID: 1519
		LeftControl,
		/// <summary>
		///   <para>Right Alt key.</para>
		/// </summary>
		// Token: 0x040005F0 RID: 1520
		RightAlt,
		/// <summary>
		///   <para>Left Alt key.</para>
		/// </summary>
		// Token: 0x040005F1 RID: 1521
		LeftAlt,
		/// <summary>
		///   <para>Left Command key.</para>
		/// </summary>
		// Token: 0x040005F2 RID: 1522
		LeftCommand = 310,
		/// <summary>
		///   <para>Left Command key.</para>
		/// </summary>
		// Token: 0x040005F3 RID: 1523
		LeftApple = 310,
		/// <summary>
		///   <para>Left Windows key.</para>
		/// </summary>
		// Token: 0x040005F4 RID: 1524
		LeftWindows,
		/// <summary>
		///   <para>Right Command key.</para>
		/// </summary>
		// Token: 0x040005F5 RID: 1525
		RightCommand = 309,
		/// <summary>
		///   <para>Right Command key.</para>
		/// </summary>
		// Token: 0x040005F6 RID: 1526
		RightApple = 309,
		/// <summary>
		///   <para>Right Windows key.</para>
		/// </summary>
		// Token: 0x040005F7 RID: 1527
		RightWindows = 312,
		/// <summary>
		///   <para>Alt Gr key.</para>
		/// </summary>
		// Token: 0x040005F8 RID: 1528
		AltGr,
		/// <summary>
		///   <para>Help key.</para>
		/// </summary>
		// Token: 0x040005F9 RID: 1529
		Help = 315,
		/// <summary>
		///   <para>Print key.</para>
		/// </summary>
		// Token: 0x040005FA RID: 1530
		Print,
		/// <summary>
		///   <para>Sys Req key.</para>
		/// </summary>
		// Token: 0x040005FB RID: 1531
		SysReq,
		/// <summary>
		///   <para>Break key.</para>
		/// </summary>
		// Token: 0x040005FC RID: 1532
		Break,
		/// <summary>
		///   <para>Menu key.</para>
		/// </summary>
		// Token: 0x040005FD RID: 1533
		Menu,
		/// <summary>
		///   <para>First (primary) mouse button.</para>
		/// </summary>
		// Token: 0x040005FE RID: 1534
		Mouse0 = 323,
		/// <summary>
		///   <para>Second (secondary) mouse button.</para>
		/// </summary>
		// Token: 0x040005FF RID: 1535
		Mouse1,
		/// <summary>
		///   <para>Third mouse button.</para>
		/// </summary>
		// Token: 0x04000600 RID: 1536
		Mouse2,
		/// <summary>
		///   <para>Fourth mouse button.</para>
		/// </summary>
		// Token: 0x04000601 RID: 1537
		Mouse3,
		/// <summary>
		///   <para>Fifth mouse button.</para>
		/// </summary>
		// Token: 0x04000602 RID: 1538
		Mouse4,
		/// <summary>
		///   <para>Sixth mouse button.</para>
		/// </summary>
		// Token: 0x04000603 RID: 1539
		Mouse5,
		/// <summary>
		///   <para>Seventh mouse button.</para>
		/// </summary>
		// Token: 0x04000604 RID: 1540
		Mouse6,
		/// <summary>
		///   <para>Button 0 on any joystick.</para>
		/// </summary>
		// Token: 0x04000605 RID: 1541
		JoystickButton0,
		/// <summary>
		///   <para>Button 1 on any joystick.</para>
		/// </summary>
		// Token: 0x04000606 RID: 1542
		JoystickButton1,
		/// <summary>
		///   <para>Button 2 on any joystick.</para>
		/// </summary>
		// Token: 0x04000607 RID: 1543
		JoystickButton2,
		/// <summary>
		///   <para>Button 3 on any joystick.</para>
		/// </summary>
		// Token: 0x04000608 RID: 1544
		JoystickButton3,
		/// <summary>
		///   <para>Button 4 on any joystick.</para>
		/// </summary>
		// Token: 0x04000609 RID: 1545
		JoystickButton4,
		/// <summary>
		///   <para>Button 5 on any joystick.</para>
		/// </summary>
		// Token: 0x0400060A RID: 1546
		JoystickButton5,
		/// <summary>
		///   <para>Button 6 on any joystick.</para>
		/// </summary>
		// Token: 0x0400060B RID: 1547
		JoystickButton6,
		/// <summary>
		///   <para>Button 7 on any joystick.</para>
		/// </summary>
		// Token: 0x0400060C RID: 1548
		JoystickButton7,
		/// <summary>
		///   <para>Button 8 on any joystick.</para>
		/// </summary>
		// Token: 0x0400060D RID: 1549
		JoystickButton8,
		/// <summary>
		///   <para>Button 9 on any joystick.</para>
		/// </summary>
		// Token: 0x0400060E RID: 1550
		JoystickButton9,
		/// <summary>
		///   <para>Button 10 on any joystick.</para>
		/// </summary>
		// Token: 0x0400060F RID: 1551
		JoystickButton10,
		/// <summary>
		///   <para>Button 11 on any joystick.</para>
		/// </summary>
		// Token: 0x04000610 RID: 1552
		JoystickButton11,
		/// <summary>
		///   <para>Button 12 on any joystick.</para>
		/// </summary>
		// Token: 0x04000611 RID: 1553
		JoystickButton12,
		/// <summary>
		///   <para>Button 13 on any joystick.</para>
		/// </summary>
		// Token: 0x04000612 RID: 1554
		JoystickButton13,
		/// <summary>
		///   <para>Button 14 on any joystick.</para>
		/// </summary>
		// Token: 0x04000613 RID: 1555
		JoystickButton14,
		/// <summary>
		///   <para>Button 15 on any joystick.</para>
		/// </summary>
		// Token: 0x04000614 RID: 1556
		JoystickButton15,
		/// <summary>
		///   <para>Button 16 on any joystick.</para>
		/// </summary>
		// Token: 0x04000615 RID: 1557
		JoystickButton16,
		/// <summary>
		///   <para>Button 17 on any joystick.</para>
		/// </summary>
		// Token: 0x04000616 RID: 1558
		JoystickButton17,
		/// <summary>
		///   <para>Button 18 on any joystick.</para>
		/// </summary>
		// Token: 0x04000617 RID: 1559
		JoystickButton18,
		/// <summary>
		///   <para>Button 19 on any joystick.</para>
		/// </summary>
		// Token: 0x04000618 RID: 1560
		JoystickButton19,
		/// <summary>
		///   <para>Button 0 on first joystick.</para>
		/// </summary>
		// Token: 0x04000619 RID: 1561
		Joystick1Button0,
		/// <summary>
		///   <para>Button 1 on first joystick.</para>
		/// </summary>
		// Token: 0x0400061A RID: 1562
		Joystick1Button1,
		/// <summary>
		///   <para>Button 2 on first joystick.</para>
		/// </summary>
		// Token: 0x0400061B RID: 1563
		Joystick1Button2,
		/// <summary>
		///   <para>Button 3 on first joystick.</para>
		/// </summary>
		// Token: 0x0400061C RID: 1564
		Joystick1Button3,
		/// <summary>
		///   <para>Button 4 on first joystick.</para>
		/// </summary>
		// Token: 0x0400061D RID: 1565
		Joystick1Button4,
		/// <summary>
		///   <para>Button 5 on first joystick.</para>
		/// </summary>
		// Token: 0x0400061E RID: 1566
		Joystick1Button5,
		/// <summary>
		///   <para>Button 6 on first joystick.</para>
		/// </summary>
		// Token: 0x0400061F RID: 1567
		Joystick1Button6,
		/// <summary>
		///   <para>Button 7 on first joystick.</para>
		/// </summary>
		// Token: 0x04000620 RID: 1568
		Joystick1Button7,
		/// <summary>
		///   <para>Button 8 on first joystick.</para>
		/// </summary>
		// Token: 0x04000621 RID: 1569
		Joystick1Button8,
		/// <summary>
		///   <para>Button 9 on first joystick.</para>
		/// </summary>
		// Token: 0x04000622 RID: 1570
		Joystick1Button9,
		/// <summary>
		///   <para>Button 10 on first joystick.</para>
		/// </summary>
		// Token: 0x04000623 RID: 1571
		Joystick1Button10,
		/// <summary>
		///   <para>Button 11 on first joystick.</para>
		/// </summary>
		// Token: 0x04000624 RID: 1572
		Joystick1Button11,
		/// <summary>
		///   <para>Button 12 on first joystick.</para>
		/// </summary>
		// Token: 0x04000625 RID: 1573
		Joystick1Button12,
		/// <summary>
		///   <para>Button 13 on first joystick.</para>
		/// </summary>
		// Token: 0x04000626 RID: 1574
		Joystick1Button13,
		/// <summary>
		///   <para>Button 14 on first joystick.</para>
		/// </summary>
		// Token: 0x04000627 RID: 1575
		Joystick1Button14,
		/// <summary>
		///   <para>Button 15 on first joystick.</para>
		/// </summary>
		// Token: 0x04000628 RID: 1576
		Joystick1Button15,
		/// <summary>
		///   <para>Button 16 on first joystick.</para>
		/// </summary>
		// Token: 0x04000629 RID: 1577
		Joystick1Button16,
		/// <summary>
		///   <para>Button 17 on first joystick.</para>
		/// </summary>
		// Token: 0x0400062A RID: 1578
		Joystick1Button17,
		/// <summary>
		///   <para>Button 18 on first joystick.</para>
		/// </summary>
		// Token: 0x0400062B RID: 1579
		Joystick1Button18,
		/// <summary>
		///   <para>Button 19 on first joystick.</para>
		/// </summary>
		// Token: 0x0400062C RID: 1580
		Joystick1Button19,
		/// <summary>
		///   <para>Button 0 on second joystick.</para>
		/// </summary>
		// Token: 0x0400062D RID: 1581
		Joystick2Button0,
		/// <summary>
		///   <para>Button 1 on second joystick.</para>
		/// </summary>
		// Token: 0x0400062E RID: 1582
		Joystick2Button1,
		/// <summary>
		///   <para>Button 2 on second joystick.</para>
		/// </summary>
		// Token: 0x0400062F RID: 1583
		Joystick2Button2,
		/// <summary>
		///   <para>Button 3 on second joystick.</para>
		/// </summary>
		// Token: 0x04000630 RID: 1584
		Joystick2Button3,
		/// <summary>
		///   <para>Button 4 on second joystick.</para>
		/// </summary>
		// Token: 0x04000631 RID: 1585
		Joystick2Button4,
		/// <summary>
		///   <para>Button 5 on second joystick.</para>
		/// </summary>
		// Token: 0x04000632 RID: 1586
		Joystick2Button5,
		/// <summary>
		///   <para>Button 6 on second joystick.</para>
		/// </summary>
		// Token: 0x04000633 RID: 1587
		Joystick2Button6,
		/// <summary>
		///   <para>Button 7 on second joystick.</para>
		/// </summary>
		// Token: 0x04000634 RID: 1588
		Joystick2Button7,
		/// <summary>
		///   <para>Button 8 on second joystick.</para>
		/// </summary>
		// Token: 0x04000635 RID: 1589
		Joystick2Button8,
		/// <summary>
		///   <para>Button 9 on second joystick.</para>
		/// </summary>
		// Token: 0x04000636 RID: 1590
		Joystick2Button9,
		/// <summary>
		///   <para>Button 10 on second joystick.</para>
		/// </summary>
		// Token: 0x04000637 RID: 1591
		Joystick2Button10,
		/// <summary>
		///   <para>Button 11 on second joystick.</para>
		/// </summary>
		// Token: 0x04000638 RID: 1592
		Joystick2Button11,
		/// <summary>
		///   <para>Button 12 on second joystick.</para>
		/// </summary>
		// Token: 0x04000639 RID: 1593
		Joystick2Button12,
		/// <summary>
		///   <para>Button 13 on second joystick.</para>
		/// </summary>
		// Token: 0x0400063A RID: 1594
		Joystick2Button13,
		/// <summary>
		///   <para>Button 14 on second joystick.</para>
		/// </summary>
		// Token: 0x0400063B RID: 1595
		Joystick2Button14,
		/// <summary>
		///   <para>Button 15 on second joystick.</para>
		/// </summary>
		// Token: 0x0400063C RID: 1596
		Joystick2Button15,
		/// <summary>
		///   <para>Button 16 on second joystick.</para>
		/// </summary>
		// Token: 0x0400063D RID: 1597
		Joystick2Button16,
		/// <summary>
		///   <para>Button 17 on second joystick.</para>
		/// </summary>
		// Token: 0x0400063E RID: 1598
		Joystick2Button17,
		/// <summary>
		///   <para>Button 18 on second joystick.</para>
		/// </summary>
		// Token: 0x0400063F RID: 1599
		Joystick2Button18,
		/// <summary>
		///   <para>Button 19 on second joystick.</para>
		/// </summary>
		// Token: 0x04000640 RID: 1600
		Joystick2Button19,
		/// <summary>
		///   <para>Button 0 on third joystick.</para>
		/// </summary>
		// Token: 0x04000641 RID: 1601
		Joystick3Button0,
		/// <summary>
		///   <para>Button 1 on third joystick.</para>
		/// </summary>
		// Token: 0x04000642 RID: 1602
		Joystick3Button1,
		/// <summary>
		///   <para>Button 2 on third joystick.</para>
		/// </summary>
		// Token: 0x04000643 RID: 1603
		Joystick3Button2,
		/// <summary>
		///   <para>Button 3 on third joystick.</para>
		/// </summary>
		// Token: 0x04000644 RID: 1604
		Joystick3Button3,
		/// <summary>
		///   <para>Button 4 on third joystick.</para>
		/// </summary>
		// Token: 0x04000645 RID: 1605
		Joystick3Button4,
		/// <summary>
		///   <para>Button 5 on third joystick.</para>
		/// </summary>
		// Token: 0x04000646 RID: 1606
		Joystick3Button5,
		/// <summary>
		///   <para>Button 6 on third joystick.</para>
		/// </summary>
		// Token: 0x04000647 RID: 1607
		Joystick3Button6,
		/// <summary>
		///   <para>Button 7 on third joystick.</para>
		/// </summary>
		// Token: 0x04000648 RID: 1608
		Joystick3Button7,
		/// <summary>
		///   <para>Button 8 on third joystick.</para>
		/// </summary>
		// Token: 0x04000649 RID: 1609
		Joystick3Button8,
		/// <summary>
		///   <para>Button 9 on third joystick.</para>
		/// </summary>
		// Token: 0x0400064A RID: 1610
		Joystick3Button9,
		/// <summary>
		///   <para>Button 10 on third joystick.</para>
		/// </summary>
		// Token: 0x0400064B RID: 1611
		Joystick3Button10,
		/// <summary>
		///   <para>Button 11 on third joystick.</para>
		/// </summary>
		// Token: 0x0400064C RID: 1612
		Joystick3Button11,
		/// <summary>
		///   <para>Button 12 on third joystick.</para>
		/// </summary>
		// Token: 0x0400064D RID: 1613
		Joystick3Button12,
		/// <summary>
		///   <para>Button 13 on third joystick.</para>
		/// </summary>
		// Token: 0x0400064E RID: 1614
		Joystick3Button13,
		/// <summary>
		///   <para>Button 14 on third joystick.</para>
		/// </summary>
		// Token: 0x0400064F RID: 1615
		Joystick3Button14,
		/// <summary>
		///   <para>Button 15 on third joystick.</para>
		/// </summary>
		// Token: 0x04000650 RID: 1616
		Joystick3Button15,
		/// <summary>
		///   <para>Button 16 on third joystick.</para>
		/// </summary>
		// Token: 0x04000651 RID: 1617
		Joystick3Button16,
		/// <summary>
		///   <para>Button 17 on third joystick.</para>
		/// </summary>
		// Token: 0x04000652 RID: 1618
		Joystick3Button17,
		/// <summary>
		///   <para>Button 18 on third joystick.</para>
		/// </summary>
		// Token: 0x04000653 RID: 1619
		Joystick3Button18,
		/// <summary>
		///   <para>Button 19 on third joystick.</para>
		/// </summary>
		// Token: 0x04000654 RID: 1620
		Joystick3Button19,
		/// <summary>
		///   <para>Button 0 on forth joystick.</para>
		/// </summary>
		// Token: 0x04000655 RID: 1621
		Joystick4Button0,
		/// <summary>
		///   <para>Button 1 on forth joystick.</para>
		/// </summary>
		// Token: 0x04000656 RID: 1622
		Joystick4Button1,
		/// <summary>
		///   <para>Button 2 on forth joystick.</para>
		/// </summary>
		// Token: 0x04000657 RID: 1623
		Joystick4Button2,
		/// <summary>
		///   <para>Button 3 on forth joystick.</para>
		/// </summary>
		// Token: 0x04000658 RID: 1624
		Joystick4Button3,
		/// <summary>
		///   <para>Button 4 on forth joystick.</para>
		/// </summary>
		// Token: 0x04000659 RID: 1625
		Joystick4Button4,
		/// <summary>
		///   <para>Button 5 on forth joystick.</para>
		/// </summary>
		// Token: 0x0400065A RID: 1626
		Joystick4Button5,
		/// <summary>
		///   <para>Button 6 on forth joystick.</para>
		/// </summary>
		// Token: 0x0400065B RID: 1627
		Joystick4Button6,
		/// <summary>
		///   <para>Button 7 on forth joystick.</para>
		/// </summary>
		// Token: 0x0400065C RID: 1628
		Joystick4Button7,
		/// <summary>
		///   <para>Button 8 on forth joystick.</para>
		/// </summary>
		// Token: 0x0400065D RID: 1629
		Joystick4Button8,
		/// <summary>
		///   <para>Button 9 on forth joystick.</para>
		/// </summary>
		// Token: 0x0400065E RID: 1630
		Joystick4Button9,
		/// <summary>
		///   <para>Button 10 on forth joystick.</para>
		/// </summary>
		// Token: 0x0400065F RID: 1631
		Joystick4Button10,
		/// <summary>
		///   <para>Button 11 on forth joystick.</para>
		/// </summary>
		// Token: 0x04000660 RID: 1632
		Joystick4Button11,
		/// <summary>
		///   <para>Button 12 on forth joystick.</para>
		/// </summary>
		// Token: 0x04000661 RID: 1633
		Joystick4Button12,
		/// <summary>
		///   <para>Button 13 on forth joystick.</para>
		/// </summary>
		// Token: 0x04000662 RID: 1634
		Joystick4Button13,
		/// <summary>
		///   <para>Button 14 on forth joystick.</para>
		/// </summary>
		// Token: 0x04000663 RID: 1635
		Joystick4Button14,
		/// <summary>
		///   <para>Button 15 on forth joystick.</para>
		/// </summary>
		// Token: 0x04000664 RID: 1636
		Joystick4Button15,
		/// <summary>
		///   <para>Button 16 on forth joystick.</para>
		/// </summary>
		// Token: 0x04000665 RID: 1637
		Joystick4Button16,
		/// <summary>
		///   <para>Button 17 on forth joystick.</para>
		/// </summary>
		// Token: 0x04000666 RID: 1638
		Joystick4Button17,
		/// <summary>
		///   <para>Button 18 on forth joystick.</para>
		/// </summary>
		// Token: 0x04000667 RID: 1639
		Joystick4Button18,
		/// <summary>
		///   <para>Button 19 on forth joystick.</para>
		/// </summary>
		// Token: 0x04000668 RID: 1640
		Joystick4Button19,
		/// <summary>
		///   <para>Button 0 on fifth joystick.</para>
		/// </summary>
		// Token: 0x04000669 RID: 1641
		Joystick5Button0,
		/// <summary>
		///   <para>Button 1 on fifth joystick.</para>
		/// </summary>
		// Token: 0x0400066A RID: 1642
		Joystick5Button1,
		/// <summary>
		///   <para>Button 2 on fifth joystick.</para>
		/// </summary>
		// Token: 0x0400066B RID: 1643
		Joystick5Button2,
		/// <summary>
		///   <para>Button 3 on fifth joystick.</para>
		/// </summary>
		// Token: 0x0400066C RID: 1644
		Joystick5Button3,
		/// <summary>
		///   <para>Button 4 on fifth joystick.</para>
		/// </summary>
		// Token: 0x0400066D RID: 1645
		Joystick5Button4,
		/// <summary>
		///   <para>Button 5 on fifth joystick.</para>
		/// </summary>
		// Token: 0x0400066E RID: 1646
		Joystick5Button5,
		/// <summary>
		///   <para>Button 6 on fifth joystick.</para>
		/// </summary>
		// Token: 0x0400066F RID: 1647
		Joystick5Button6,
		/// <summary>
		///   <para>Button 7 on fifth joystick.</para>
		/// </summary>
		// Token: 0x04000670 RID: 1648
		Joystick5Button7,
		/// <summary>
		///   <para>Button 8 on fifth joystick.</para>
		/// </summary>
		// Token: 0x04000671 RID: 1649
		Joystick5Button8,
		/// <summary>
		///   <para>Button 9 on fifth joystick.</para>
		/// </summary>
		// Token: 0x04000672 RID: 1650
		Joystick5Button9,
		/// <summary>
		///   <para>Button 10 on fifth joystick.</para>
		/// </summary>
		// Token: 0x04000673 RID: 1651
		Joystick5Button10,
		/// <summary>
		///   <para>Button 11 on fifth joystick.</para>
		/// </summary>
		// Token: 0x04000674 RID: 1652
		Joystick5Button11,
		/// <summary>
		///   <para>Button 12 on fifth joystick.</para>
		/// </summary>
		// Token: 0x04000675 RID: 1653
		Joystick5Button12,
		/// <summary>
		///   <para>Button 13 on fifth joystick.</para>
		/// </summary>
		// Token: 0x04000676 RID: 1654
		Joystick5Button13,
		/// <summary>
		///   <para>Button 14 on fifth joystick.</para>
		/// </summary>
		// Token: 0x04000677 RID: 1655
		Joystick5Button14,
		/// <summary>
		///   <para>Button 15 on fifth joystick.</para>
		/// </summary>
		// Token: 0x04000678 RID: 1656
		Joystick5Button15,
		/// <summary>
		///   <para>Button 16 on fifth joystick.</para>
		/// </summary>
		// Token: 0x04000679 RID: 1657
		Joystick5Button16,
		/// <summary>
		///   <para>Button 17 on fifth joystick.</para>
		/// </summary>
		// Token: 0x0400067A RID: 1658
		Joystick5Button17,
		/// <summary>
		///   <para>Button 18 on fifth joystick.</para>
		/// </summary>
		// Token: 0x0400067B RID: 1659
		Joystick5Button18,
		/// <summary>
		///   <para>Button 19 on fifth joystick.</para>
		/// </summary>
		// Token: 0x0400067C RID: 1660
		Joystick5Button19,
		/// <summary>
		///   <para>Button 0 on sixth joystick.</para>
		/// </summary>
		// Token: 0x0400067D RID: 1661
		Joystick6Button0,
		/// <summary>
		///   <para>Button 1 on sixth joystick.</para>
		/// </summary>
		// Token: 0x0400067E RID: 1662
		Joystick6Button1,
		/// <summary>
		///   <para>Button 2 on sixth joystick.</para>
		/// </summary>
		// Token: 0x0400067F RID: 1663
		Joystick6Button2,
		/// <summary>
		///   <para>Button 3 on sixth joystick.</para>
		/// </summary>
		// Token: 0x04000680 RID: 1664
		Joystick6Button3,
		/// <summary>
		///   <para>Button 4 on sixth joystick.</para>
		/// </summary>
		// Token: 0x04000681 RID: 1665
		Joystick6Button4,
		/// <summary>
		///   <para>Button 5 on sixth joystick.</para>
		/// </summary>
		// Token: 0x04000682 RID: 1666
		Joystick6Button5,
		/// <summary>
		///   <para>Button 6 on sixth joystick.</para>
		/// </summary>
		// Token: 0x04000683 RID: 1667
		Joystick6Button6,
		/// <summary>
		///   <para>Button 7 on sixth joystick.</para>
		/// </summary>
		// Token: 0x04000684 RID: 1668
		Joystick6Button7,
		/// <summary>
		///   <para>Button 8 on sixth joystick.</para>
		/// </summary>
		// Token: 0x04000685 RID: 1669
		Joystick6Button8,
		/// <summary>
		///   <para>Button 9 on sixth joystick.</para>
		/// </summary>
		// Token: 0x04000686 RID: 1670
		Joystick6Button9,
		/// <summary>
		///   <para>Button 10 on sixth joystick.</para>
		/// </summary>
		// Token: 0x04000687 RID: 1671
		Joystick6Button10,
		/// <summary>
		///   <para>Button 11 on sixth joystick.</para>
		/// </summary>
		// Token: 0x04000688 RID: 1672
		Joystick6Button11,
		/// <summary>
		///   <para>Button 12 on sixth joystick.</para>
		/// </summary>
		// Token: 0x04000689 RID: 1673
		Joystick6Button12,
		/// <summary>
		///   <para>Button 13 on sixth joystick.</para>
		/// </summary>
		// Token: 0x0400068A RID: 1674
		Joystick6Button13,
		/// <summary>
		///   <para>Button 14 on sixth joystick.</para>
		/// </summary>
		// Token: 0x0400068B RID: 1675
		Joystick6Button14,
		/// <summary>
		///   <para>Button 15 on sixth joystick.</para>
		/// </summary>
		// Token: 0x0400068C RID: 1676
		Joystick6Button15,
		/// <summary>
		///   <para>Button 16 on sixth joystick.</para>
		/// </summary>
		// Token: 0x0400068D RID: 1677
		Joystick6Button16,
		/// <summary>
		///   <para>Button 17 on sixth joystick.</para>
		/// </summary>
		// Token: 0x0400068E RID: 1678
		Joystick6Button17,
		/// <summary>
		///   <para>Button 18 on sixth joystick.</para>
		/// </summary>
		// Token: 0x0400068F RID: 1679
		Joystick6Button18,
		/// <summary>
		///   <para>Button 19 on sixth joystick.</para>
		/// </summary>
		// Token: 0x04000690 RID: 1680
		Joystick6Button19,
		/// <summary>
		///   <para>Button 0 on seventh joystick.</para>
		/// </summary>
		// Token: 0x04000691 RID: 1681
		Joystick7Button0,
		/// <summary>
		///   <para>Button 1 on seventh joystick.</para>
		/// </summary>
		// Token: 0x04000692 RID: 1682
		Joystick7Button1,
		/// <summary>
		///   <para>Button 2 on seventh joystick.</para>
		/// </summary>
		// Token: 0x04000693 RID: 1683
		Joystick7Button2,
		/// <summary>
		///   <para>Button 3 on seventh joystick.</para>
		/// </summary>
		// Token: 0x04000694 RID: 1684
		Joystick7Button3,
		/// <summary>
		///   <para>Button 4 on seventh joystick.</para>
		/// </summary>
		// Token: 0x04000695 RID: 1685
		Joystick7Button4,
		/// <summary>
		///   <para>Button 5 on seventh joystick.</para>
		/// </summary>
		// Token: 0x04000696 RID: 1686
		Joystick7Button5,
		/// <summary>
		///   <para>Button 6 on seventh joystick.</para>
		/// </summary>
		// Token: 0x04000697 RID: 1687
		Joystick7Button6,
		/// <summary>
		///   <para>Button 7 on seventh joystick.</para>
		/// </summary>
		// Token: 0x04000698 RID: 1688
		Joystick7Button7,
		/// <summary>
		///   <para>Button 8 on seventh joystick.</para>
		/// </summary>
		// Token: 0x04000699 RID: 1689
		Joystick7Button8,
		/// <summary>
		///   <para>Button 9 on seventh joystick.</para>
		/// </summary>
		// Token: 0x0400069A RID: 1690
		Joystick7Button9,
		/// <summary>
		///   <para>Button 10 on seventh joystick.</para>
		/// </summary>
		// Token: 0x0400069B RID: 1691
		Joystick7Button10,
		/// <summary>
		///   <para>Button 11 on seventh joystick.</para>
		/// </summary>
		// Token: 0x0400069C RID: 1692
		Joystick7Button11,
		/// <summary>
		///   <para>Button 12 on seventh joystick.</para>
		/// </summary>
		// Token: 0x0400069D RID: 1693
		Joystick7Button12,
		/// <summary>
		///   <para>Button 13 on seventh joystick.</para>
		/// </summary>
		// Token: 0x0400069E RID: 1694
		Joystick7Button13,
		/// <summary>
		///   <para>Button 14 on seventh joystick.</para>
		/// </summary>
		// Token: 0x0400069F RID: 1695
		Joystick7Button14,
		/// <summary>
		///   <para>Button 15 on seventh joystick.</para>
		/// </summary>
		// Token: 0x040006A0 RID: 1696
		Joystick7Button15,
		/// <summary>
		///   <para>Button 16 on seventh joystick.</para>
		/// </summary>
		// Token: 0x040006A1 RID: 1697
		Joystick7Button16,
		/// <summary>
		///   <para>Button 17 on seventh joystick.</para>
		/// </summary>
		// Token: 0x040006A2 RID: 1698
		Joystick7Button17,
		/// <summary>
		///   <para>Button 18 on seventh joystick.</para>
		/// </summary>
		// Token: 0x040006A3 RID: 1699
		Joystick7Button18,
		/// <summary>
		///   <para>Button 19 on seventh joystick.</para>
		/// </summary>
		// Token: 0x040006A4 RID: 1700
		Joystick7Button19,
		/// <summary>
		///   <para>Button 0 on eighth joystick.</para>
		/// </summary>
		// Token: 0x040006A5 RID: 1701
		Joystick8Button0,
		/// <summary>
		///   <para>Button 1 on eighth joystick.</para>
		/// </summary>
		// Token: 0x040006A6 RID: 1702
		Joystick8Button1,
		/// <summary>
		///   <para>Button 2 on eighth joystick.</para>
		/// </summary>
		// Token: 0x040006A7 RID: 1703
		Joystick8Button2,
		/// <summary>
		///   <para>Button 3 on eighth joystick.</para>
		/// </summary>
		// Token: 0x040006A8 RID: 1704
		Joystick8Button3,
		/// <summary>
		///   <para>Button 4 on eighth joystick.</para>
		/// </summary>
		// Token: 0x040006A9 RID: 1705
		Joystick8Button4,
		/// <summary>
		///   <para>Button 5 on eighth joystick.</para>
		/// </summary>
		// Token: 0x040006AA RID: 1706
		Joystick8Button5,
		/// <summary>
		///   <para>Button 6 on eighth joystick.</para>
		/// </summary>
		// Token: 0x040006AB RID: 1707
		Joystick8Button6,
		/// <summary>
		///   <para>Button 7 on eighth joystick.</para>
		/// </summary>
		// Token: 0x040006AC RID: 1708
		Joystick8Button7,
		/// <summary>
		///   <para>Button 8 on eighth joystick.</para>
		/// </summary>
		// Token: 0x040006AD RID: 1709
		Joystick8Button8,
		/// <summary>
		///   <para>Button 9 on eighth joystick.</para>
		/// </summary>
		// Token: 0x040006AE RID: 1710
		Joystick8Button9,
		/// <summary>
		///   <para>Button 10 on eighth joystick.</para>
		/// </summary>
		// Token: 0x040006AF RID: 1711
		Joystick8Button10,
		/// <summary>
		///   <para>Button 11 on eighth joystick.</para>
		/// </summary>
		// Token: 0x040006B0 RID: 1712
		Joystick8Button11,
		/// <summary>
		///   <para>Button 12 on eighth joystick.</para>
		/// </summary>
		// Token: 0x040006B1 RID: 1713
		Joystick8Button12,
		/// <summary>
		///   <para>Button 13 on eighth joystick.</para>
		/// </summary>
		// Token: 0x040006B2 RID: 1714
		Joystick8Button13,
		/// <summary>
		///   <para>Button 14 on eighth joystick.</para>
		/// </summary>
		// Token: 0x040006B3 RID: 1715
		Joystick8Button14,
		/// <summary>
		///   <para>Button 15 on eighth joystick.</para>
		/// </summary>
		// Token: 0x040006B4 RID: 1716
		Joystick8Button15,
		/// <summary>
		///   <para>Button 16 on eighth joystick.</para>
		/// </summary>
		// Token: 0x040006B5 RID: 1717
		Joystick8Button16,
		/// <summary>
		///   <para>Button 17 on eighth joystick.</para>
		/// </summary>
		// Token: 0x040006B6 RID: 1718
		Joystick8Button17,
		/// <summary>
		///   <para>Button 18 on eighth joystick.</para>
		/// </summary>
		// Token: 0x040006B7 RID: 1719
		Joystick8Button18,
		/// <summary>
		///   <para>Button 19 on eighth joystick.</para>
		/// </summary>
		// Token: 0x040006B8 RID: 1720
		Joystick8Button19
	}
}
