using UnityEngine;

public class Client : MonoBehaviour
{
	private LuaScriptMgr luaMgr;

	private void Start()
	{
		luaMgr = new LuaScriptMgr();
		luaMgr.Start();
		luaMgr.DoFile(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2887471646u));
	}

	private void Update()
	{
		if (luaMgr == null)
		{
			return;
		}
		while (true)
		{
			int num = -1441715495;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2113365307)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_002a;
				case 1u:
					return;
				}
				break;
				IL_002a:
				luaMgr.Update();
				num = ((int)num2 * -1356510543) ^ 0x584C97B4;
			}
		}
	}

	private void LateUpdate()
	{
		if (luaMgr == null)
		{
			return;
		}
		while (true)
		{
			int num = -35924717;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2108955738)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_002a;
				case 1u:
					return;
				}
				break;
				IL_002a:
				luaMgr.LateUpate();
				num = (int)(num2 * 1878123773) ^ -181807239;
			}
		}
	}

	private void FixedUpdate()
	{
		if (luaMgr == null)
		{
			return;
		}
		while (true)
		{
			int num = -1193047135;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1481841989)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_002a;
				case 2u:
					return;
				}
				break;
				IL_002a:
				luaMgr.FixedUpdate();
				num = ((int)num2 * -1930630873) ^ -1387435355;
			}
		}
	}

	private void OnGUI()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected O, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Expected O, but got Unknown
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_063d: Unknown result type (might be due to invalid IL or missing references)
		if (GUI.Button(new Rect(10f, 10f, 120f, 50f), global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3431781628u)))
		{
			goto IL_002d;
		}
		goto IL_00f4;
		IL_002d:
		int num = 932380761;
		goto IL_0032;
		IL_0032:
		float realtimeSinceStartup3 = default(float);
		float realtimeSinceStartup = default(float);
		float realtimeSinceStartup5 = default(float);
		SkinnedMeshRenderer component = default(SkinnedMeshRenderer);
		float realtimeSinceStartup2 = default(float);
		int num6 = default(int);
		int num7 = default(int);
		int num5 = default(int);
		int num3 = default(int);
		GameObject val = default(GameObject);
		float realtimeSinceStartup4 = default(float);
		Vector3 one2 = default(Vector3);
		int num4 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x6137C47B)) % 43)
			{
			case 10u:
				break;
			default:
				return;
			case 39u:
				goto IL_00f4;
			case 29u:
				goto IL_0132;
			case 17u:
				goto IL_014f;
			case 30u:
				goto IL_016c;
			case 37u:
				Debug.Log((object)(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2341711759u) + (Time.realtimeSinceStartup - realtimeSinceStartup3)));
				num = (int)((num2 * 508189364) ^ 0x5CD0A3B7);
				continue;
			case 34u:
				realtimeSinceStartup = Time.realtimeSinceStartup;
				num = (int)(num2 * 210514693) ^ -1765079344;
				continue;
			case 12u:
				Debug.Log((object)(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2341711759u) + (Time.realtimeSinceStartup - realtimeSinceStartup5)));
				((Component)this).transform.position = Vector3.zero;
				num = (int)((num2 * 1933993632) ^ 0x636792B9);
				continue;
			case 16u:
				goto IL_023b;
			case 22u:
				((Renderer)component).castShadows = false;
				num = ((int)num2 * -110793425) ^ 0xC5D339D;
				continue;
			case 36u:
				luaMgr.CallLuaFunction(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1460581470u), ((Component)this).transform);
				num = (int)(num2 * 1839408110) ^ -236939334;
				continue;
			case 20u:
				luaMgr.CallLuaFunction(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3431781628u));
				num = (int)((num2 * 228272898) ^ 0x12BB48);
				continue;
			case 7u:
				realtimeSinceStartup2 = Time.realtimeSinceStartup;
				num = ((int)num2 * -51167214) ^ 0x4C3307AE;
				continue;
			case 5u:
				goto IL_02f2;
			case 41u:
				goto IL_0330;
			case 33u:
				((Component)this).transform.Rotate(Vector3.up, 1f);
				num6++;
				num = 2123191354;
				continue;
			case 9u:
				num7 = 0;
				num = (int)((num2 * 1597255826) ^ 0x7EE8B547);
				continue;
			case 11u:
				num = (int)(num2 * 1654197843) ^ -1985528150;
				continue;
			case 13u:
			{
				GameObject val2 = new GameObject();
				num7++;
				num = 1979235989;
				continue;
			}
			case 42u:
				num = ((int)num2 * -650339276) ^ -984102168;
				continue;
			case 2u:
				num = ((int)num2 * -1831381334) ^ -690165829;
				continue;
			case 8u:
				luaMgr.CallLuaFunction(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3609816919u), ((Component)this).transform);
				num = ((int)num2 * -1898806100) ^ 0x8854D36;
				continue;
			case 32u:
				num5 = 0;
				num = ((int)num2 * -436297881) ^ 0x3C8D4275;
				continue;
			case 18u:
			{
				Vector3 one = ((Component)this).transform.position;
				((Component)this).transform.position = Vector3.one;
				num3++;
				num = 1810881300;
				continue;
			}
			case 40u:
				realtimeSinceStartup5 = Time.realtimeSinceStartup;
				num = ((int)num2 * -463924943) ^ -1227063554;
				continue;
			case 1u:
				component = val.GetComponent<SkinnedMeshRenderer>();
				num = ((int)num2 * -103034049) ^ -588996357;
				continue;
			case 19u:
				num6 = 0;
				num = (int)((num2 * 708960918) ^ 0x79229C4D);
				continue;
			case 4u:
				realtimeSinceStartup4 = Time.realtimeSinceStartup;
				num = (int)(num2 * 424966155) ^ -1549550637;
				continue;
			case 35u:
				((Vector3)(ref one2))._002Ector((float)num5, (float)num5, (float)num5);
				num5++;
				num = 396477915;
				continue;
			case 21u:
				((Renderer)component).receiveShadows = false;
				num = ((int)num2 * -1300475922) ^ 0x21BAB749;
				continue;
			case 27u:
				Debug.Log((object)(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2450962989u) + (Time.realtimeSinceStartup - realtimeSinceStartup4)));
				num = ((int)num2 * -633081671) ^ -1446727570;
				continue;
			case 6u:
				goto IL_0524;
			case 23u:
				val.AddComponent<SkinnedMeshRenderer>();
				num = ((int)num2 * -313846776) ^ -4098024;
				continue;
			case 25u:
				one2 = Vector3.one;
				num = ((int)num2 * -1270822813) ^ -247721647;
				continue;
			case 26u:
				luaMgr.CallLuaFunction(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(821120187u), ((Component)this).transform);
				num = (int)(num2 * 1069309863) ^ -826293600;
				continue;
			case 31u:
				realtimeSinceStartup3 = Time.realtimeSinceStartup;
				num4 = 0;
				num = ((int)num2 * -629699616) ^ 0x6AC482EB;
				continue;
			case 3u:
				Debug.Log((object)(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(167289179u) + (Time.realtimeSinceStartup - realtimeSinceStartup2)));
				num = ((int)num2 * -443515054) ^ -1282856461;
				continue;
			case 14u:
				num4++;
				num = (int)(num2 * 1880969914) ^ -1732241501;
				continue;
			case 38u:
			{
				Vector3 one = Vector3.one;
				num3 = 0;
				num = (int)(num2 * 1906400009) ^ -2111794689;
				continue;
			}
			case 24u:
				val = new GameObject();
				num = 909365697;
				continue;
			case 0u:
				Debug.Log((object)(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3500616506u) + (Time.realtimeSinceStartup - realtimeSinceStartup)));
				luaMgr.CallLuaFunction(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3988174686u), ((Component)this).transform);
				num = ((int)num2 * -788462410) ^ -1109447134;
				continue;
			case 15u:
				goto IL_06bd;
			case 28u:
				return;
			}
			break;
			IL_06bd:
			int num8;
			if (num6 >= 200000)
			{
				num = 1003080617;
				num8 = num;
			}
			else
			{
				num = 575844557;
				num8 = num;
			}
			continue;
			IL_014f:
			int num9;
			if (num7 < 200000)
			{
				num = 564232727;
				num9 = num;
			}
			else
			{
				num = 322866563;
				num9 = num;
			}
			continue;
			IL_02f2:
			int num10;
			if (GUI.Button(new Rect(10f, 190f, 120f, 50f), global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1536052456u)))
			{
				num = 1281370233;
				num10 = num;
			}
			else
			{
				num = 1147492466;
				num10 = num;
			}
			continue;
			IL_0524:
			int num11;
			if (GUI.Button(new Rect(10f, 130f, 120f, 50f), global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2140516741u)))
			{
				num = 1283085435;
				num11 = num;
			}
			else
			{
				num = 1268882890;
				num11 = num;
			}
			continue;
			IL_0132:
			int num12;
			if (num5 < 200000)
			{
				num = 1435670801;
				num12 = num;
			}
			else
			{
				num = 2011089939;
				num12 = num;
			}
			continue;
			IL_016c:
			int num13;
			if (GUI.Button(new Rect(10f, 250f, 120f, 50f), global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(821120187u)))
			{
				num = 1819920529;
				num13 = num;
			}
			else
			{
				num = 571975472;
				num13 = num;
			}
			continue;
			IL_0330:
			int num14;
			if (num4 >= 20000)
			{
				num = 609881936;
				num14 = num;
			}
			else
			{
				num = 277681699;
				num14 = num;
			}
			continue;
			IL_023b:
			int num15;
			if (num3 >= 200000)
			{
				num = 623564449;
				num15 = num;
			}
			else
			{
				num = 870312061;
				num15 = num;
			}
		}
		goto IL_002d;
		IL_00f4:
		int num16;
		if (GUI.Button(new Rect(10f, 70f, 120f, 50f), global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1460581470u)))
		{
			num = 535302709;
			num16 = num;
		}
		else
		{
			num = 378620434;
			num16 = num;
		}
		goto IL_0032;
	}
}
