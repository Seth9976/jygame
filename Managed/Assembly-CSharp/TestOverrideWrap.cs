using System;
using LuaInterface;

public class TestOverrideWrap
{
	private static Type classType = _206C_202E_202E_200B_206D_200E_206A_200B_202B_202D_200E_202A_206C_206D_206F_200F_206C_206F_202D_200D_200D_206B_202C_200F_202B_206A_202E_206F_206F_206F_200F_202B_200D_202A_206B_202D_206A_200B_200F_202C_202E(typeof(TestOverride).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[3]
		{
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2254860190u), Test),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2254933974u), _202C_206D_206A_200B_202E_200C_206D_202A_206D_202D_202D_206D_202A_202E_206A_206B_206C_202D_200D_202B_200C_200F_206A_206D_200F_200B_200D_206D_206E_202B_202C_200C_202C_200B_200C_206F_206E_202C_200D_200C_202E),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3661446913u), GetClassType)
		};
		while (true)
		{
			int num = 694634650;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x16C54F3)) % 3)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_009e;
				case 0u:
					return;
				}
				break;
				IL_009e:
				LuaField[] fields = new LuaField[0];
				LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4188497162u), _206C_202E_202E_200B_206D_200E_206A_200B_202B_202D_200E_202A_206C_206D_206F_200F_206C_206F_202D_200D_200D_206B_202C_200F_202B_206A_202E_206F_206F_206F_200F_202B_200D_202A_206B_202D_206A_200B_200F_202C_202E(typeof(TestOverride).TypeHandle), regs, fields, _206C_202E_202E_200B_206D_200E_206A_200B_202B_202D_200E_202A_206C_206D_206F_200F_206C_206F_202D_200D_200D_206B_202C_200F_202B_206A_202E_206F_206F_206F_200F_202B_200D_202A_206B_202D_206A_200B_200F_202C_202E(typeof(object).TypeHandle));
				num = (int)((num2 * 724673250) ^ 0x620258F7);
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _202C_206D_206A_200B_202E_200C_206D_202A_206D_202D_202D_206D_202A_202E_206A_206B_206C_202D_200D_202B_200C_200F_206A_206D_200F_200B_200D_206D_206E_202B_202C_200C_202C_200B_200C_206F_206E_202C_200D_200C_202E(IntPtr P_0)
	{
		int num = LuaDLL.lua_gettop(P_0);
		while (true)
		{
			int num2 = 2102780589;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x565481A8)) % 6)
				{
				case 4u:
					break;
				case 2u:
					LuaDLL.luaL_error(P_0, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2675066094u));
					num2 = 1723675993;
					continue;
				case 0u:
				{
					TestOverride o = new TestOverride();
					LuaScriptMgr.PushObject(P_0, o);
					num2 = (int)(num3 * 1361282362) ^ -1117864143;
					continue;
				}
				case 1u:
				{
					int num4;
					int num5;
					if (num != 0)
					{
						num4 = -957385655;
						num5 = num4;
					}
					else
					{
						num4 = -210508547;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num3 * -397314813);
					continue;
				}
				case 5u:
					return 1;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Test(IntPtr L)
	{
		int num = LuaDLL.lua_gettop(L);
		int d6 = default(int);
		TestOverride testOverride = default(TestOverride);
		object[] paramsObject = default(object[]);
		TestOverride testOverride5 = default(TestOverride);
		string str4 = default(string);
		int d5 = default(int);
		TestOverride testOverride6 = default(TestOverride);
		string str = default(string);
		TestOverride testOverride2 = default(TestOverride);
		int d7 = default(int);
		int i = default(int);
		int j = default(int);
		TestOverride testOverride3 = default(TestOverride);
		int d = default(int);
		object varObject = default(object);
		string str3 = default(string);
		TestOverride testOverride4 = default(TestOverride);
		while (true)
		{
			int num2 = 1985327810;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x284B6A4E)) % 46)
				{
				case 28u:
					break;
				case 32u:
				{
					int num23;
					int num24;
					if (!LuaScriptMgr.CheckTypes(L, 1, _206C_202E_202E_200B_206D_200E_206A_200B_202B_202D_200E_202A_206C_206D_206F_200F_206C_206F_202D_200D_200D_206B_202C_200F_202B_206A_202E_206F_206F_206F_200F_202B_200D_202A_206B_202D_206A_200B_200F_202C_202E(typeof(TestOverride).TypeHandle), _206C_202E_202E_200B_206D_200E_206A_200B_202B_202D_200E_202A_206C_206D_206F_200F_206C_206F_202D_200D_200D_206B_202C_200F_202B_206A_202E_206F_206F_206F_200F_202B_200D_202A_206B_202D_206A_200B_200F_202C_202E(typeof(int).TypeHandle), _206C_202E_202E_200B_206D_200E_206A_200B_202B_202D_200E_202A_206C_206D_206F_200F_206C_206F_202D_200D_200D_206B_202C_200F_202B_206A_202E_206F_206F_206F_200F_202B_200D_202A_206B_202D_206A_200B_200F_202C_202E(typeof(int).TypeHandle)))
					{
						num23 = -1228096058;
						num24 = num23;
					}
					else
					{
						num23 = -1351784363;
						num24 = num23;
					}
					num2 = num23 ^ ((int)num3 * -593289026);
					continue;
				}
				case 10u:
				{
					int num25;
					if (num != 3)
					{
						num2 = 1818109570;
						num25 = num2;
					}
					else
					{
						num2 = 311805904;
						num25 = num2;
					}
					continue;
				}
				case 3u:
					LuaScriptMgr.Push(L, d6);
					num2 = (int)(num3 * 962929422) ^ -1371741663;
					continue;
				case 29u:
					testOverride = (TestOverride)LuaScriptMgr.GetNetObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1415089427u));
					paramsObject = LuaScriptMgr.GetParamsObject(L, 2, num - 1);
					num2 = (int)(num3 * 52523897) ^ -1315400418;
					continue;
				case 44u:
					return 1;
				case 6u:
					testOverride5 = (TestOverride)LuaScriptMgr.GetNetObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1415089427u));
					str4 = LuaScriptMgr.GetString(L, 2);
					num2 = (int)((num3 * 1521468696) ^ 0x6866F068);
					continue;
				case 41u:
				{
					object varObject2 = LuaScriptMgr.GetVarObject(L, 2);
					d5 = testOverride6.Test(varObject2);
					num2 = (int)(num3 * 1985769420) ^ -1369925556;
					continue;
				}
				case 31u:
					return 1;
				case 45u:
					return 1;
				case 37u:
					str = LuaScriptMgr.GetString(L, 1);
					num2 = ((int)num3 * -1225429331) ^ -674110222;
					continue;
				case 12u:
				{
					TestOverride testOverride7 = (TestOverride)LuaScriptMgr.GetNetObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2332471752u));
					TestOverride.Space e = (TestOverride.Space)(int)LuaScriptMgr.GetLuaObject(L, 2);
					int d9 = testOverride7.Test(e);
					LuaScriptMgr.Push(L, d9);
					num2 = (int)((num3 * 1519537102) ^ 0x33E953A2);
					continue;
				}
				case 40u:
					testOverride6 = (TestOverride)LuaScriptMgr.GetNetObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2332471752u));
					num2 = (int)(num3 * 252026602) ^ -403240501;
					continue;
				case 30u:
				{
					int num20;
					if (num != 2)
					{
						num2 = 1732162408;
						num20 = num2;
					}
					else
					{
						num2 = 668494774;
						num20 = num2;
					}
					continue;
				}
				case 23u:
					testOverride2 = (TestOverride)LuaScriptMgr.GetNetObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3429706012u));
					num2 = ((int)num3 * -1244078561) ^ -1704784622;
					continue;
				case 38u:
				{
					int num17;
					if (num == 2)
					{
						num2 = 249763191;
						num17 = num2;
					}
					else
					{
						num2 = 2107627268;
						num17 = num2;
					}
					continue;
				}
				case 35u:
					return 1;
				case 43u:
					LuaScriptMgr.Push(L, d7);
					num2 = ((int)num3 * -1774235097) ^ -474882788;
					continue;
				case 16u:
				{
					int num12;
					int num13;
					if (LuaScriptMgr.CheckTypes(L, 1, _206C_202E_202E_200B_206D_200E_206A_200B_202B_202D_200E_202A_206C_206D_206F_200F_206C_206F_202D_200D_200D_206B_202C_200F_202B_206A_202E_206F_206F_206F_200F_202B_200D_202A_206B_202D_206A_200B_200F_202C_202E(typeof(TestOverride).TypeHandle), _206C_202E_202E_200B_206D_200E_206A_200B_202B_202D_200E_202A_206C_206D_206F_200F_206C_206F_202D_200D_200D_206B_202C_200F_202B_206A_202E_206F_206F_206F_200F_202B_200D_202A_206B_202D_206A_200B_200F_202C_202E(typeof(object).TypeHandle), _206C_202E_202E_200B_206D_200E_206A_200B_202B_202D_200E_202A_206C_206D_206F_200F_206C_206F_202D_200D_200D_206B_202C_200F_202B_206A_202E_206F_206F_206F_200F_202B_200D_202A_206B_202D_206A_200B_200F_202C_202E(typeof(string).TypeHandle)))
					{
						num12 = -589137327;
						num13 = num12;
					}
					else
					{
						num12 = -999321064;
						num13 = num12;
					}
					num2 = num12 ^ (int)(num3 * 1518075728);
					continue;
				}
				case 19u:
					i = (int)LuaDLL.lua_tonumber(L, 2);
					j = (int)LuaDLL.lua_tonumber(L, 3);
					num2 = ((int)num3 * -725821510) ^ 0x1FBA5A29;
					continue;
				case 0u:
				{
					int num8;
					if (LuaScriptMgr.CheckParamsType(L, _206C_202E_202E_200B_206D_200E_206A_200B_202B_202D_200E_202A_206C_206D_206F_200F_206C_206F_202D_200D_200D_206B_202C_200F_202B_206A_202E_206F_206F_206F_200F_202B_200D_202A_206B_202D_206A_200B_200F_202C_202E(typeof(object).TypeHandle), 2, num - 1))
					{
						num2 = 1118050683;
						num8 = num2;
					}
					else
					{
						num2 = 1056644135;
						num8 = num2;
					}
					continue;
				}
				case 33u:
					testOverride3 = (TestOverride)LuaScriptMgr.GetNetObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1415089427u));
					num2 = ((int)num3 * -557325678) ^ -1597052683;
					continue;
				case 13u:
				{
					double d2 = LuaDLL.lua_tonumber(L, 2);
					int d3 = testOverride2.Test(d2);
					LuaScriptMgr.Push(L, d3);
					num2 = (int)(num3 * 292158700) ^ -523308264;
					continue;
				}
				case 25u:
					d = testOverride.Test(paramsObject);
					num2 = ((int)num3 * -1228542005) ^ 0x4767E189;
					continue;
				case 14u:
				{
					int num26;
					if (num == 2)
					{
						num2 = 1450742499;
						num26 = num2;
					}
					else
					{
						num2 = 1649734258;
						num26 = num2;
					}
					continue;
				}
				case 26u:
				{
					int num21;
					int num22;
					if (!LuaScriptMgr.CheckTypes(L, 1, _206C_202E_202E_200B_206D_200E_206A_200B_202B_202D_200E_202A_206C_206D_206F_200F_206C_206F_202D_200D_200D_206B_202C_200F_202B_206A_202E_206F_206F_206F_200F_202B_200D_202A_206B_202D_206A_200B_200F_202C_202E(typeof(TestOverride).TypeHandle), _206C_202E_202E_200B_206D_200E_206A_200B_202B_202D_200E_202A_206C_206D_206F_200F_206C_206F_202D_200D_200D_206B_202C_200F_202B_206A_202E_206F_206F_206F_200F_202B_200D_202A_206B_202D_206A_200B_200F_202C_202E(typeof(TestOverride.Space).TypeHandle)))
					{
						num21 = -822454344;
						num22 = num21;
					}
					else
					{
						num21 = -1119876514;
						num22 = num21;
					}
					num2 = num21 ^ (int)(num3 * 1498309318);
					continue;
				}
				case 11u:
					return 1;
				case 18u:
					d7 = testOverride5.Test(str4);
					num2 = ((int)num3 * -922151322) ^ 0x1D7ACACB;
					continue;
				case 4u:
				{
					int num18;
					int num19;
					if (!LuaScriptMgr.CheckTypes(L, 1, _206C_202E_202E_200B_206D_200E_206A_200B_202B_202D_200E_202A_206C_206D_206F_200F_206C_206F_202D_200D_200D_206B_202C_200F_202B_206A_202E_206F_206F_206F_200F_202B_200D_202A_206B_202D_206A_200B_200F_202C_202E(typeof(TestOverride).TypeHandle), _206C_202E_202E_200B_206D_200E_206A_200B_202B_202D_200E_202A_206C_206D_206F_200F_206C_206F_202D_200D_200D_206B_202C_200F_202B_206A_202E_206F_206F_206F_200F_202B_200D_202A_206B_202D_206A_200B_200F_202C_202E(typeof(string).TypeHandle)))
					{
						num18 = -1267633708;
						num19 = num18;
					}
					else
					{
						num18 = -1045662386;
						num19 = num18;
					}
					num2 = num18 ^ (int)(num3 * 812400533);
					continue;
				}
				case 17u:
				{
					int num15;
					int num16;
					if (!LuaScriptMgr.CheckTypes(L, 1, _206C_202E_202E_200B_206D_200E_206A_200B_202B_202D_200E_202A_206C_206D_206F_200F_206C_206F_202D_200D_200D_206B_202C_200F_202B_206A_202E_206F_206F_206F_200F_202B_200D_202A_206B_202D_206A_200B_200F_202C_202E(typeof(TestOverride).TypeHandle), _206C_202E_202E_200B_206D_200E_206A_200B_202B_202D_200E_202A_206C_206D_206F_200F_206C_206F_202D_200D_200D_206B_202C_200F_202B_206A_202E_206F_206F_206F_200F_202B_200D_202A_206B_202D_206A_200B_200F_202C_202E(typeof(object).TypeHandle)))
					{
						num15 = -346383940;
						num16 = num15;
					}
					else
					{
						num15 = -203260042;
						num16 = num15;
					}
					num2 = num15 ^ (int)(num3 * 1132539590);
					continue;
				}
				case 22u:
				{
					int d8 = testOverride3.Test(varObject, str3);
					LuaScriptMgr.Push(L, d8);
					return 1;
				}
				case 34u:
				{
					int num14;
					if (num != 2)
					{
						num2 = 1850930948;
						num14 = num2;
					}
					else
					{
						num2 = 1362604484;
						num14 = num2;
					}
					continue;
				}
				case 9u:
				{
					int num10;
					int num11;
					if (!LuaScriptMgr.CheckTypes(L, 1, _206C_202E_202E_200B_206D_200E_206A_200B_202B_202D_200E_202A_206C_206D_206F_200F_206C_206F_202D_200D_200D_206B_202C_200F_202B_206A_202E_206F_206F_206F_200F_202B_200D_202A_206B_202D_206A_200B_200F_202C_202E(typeof(TestOverride).TypeHandle), _206C_202E_202E_200B_206D_200E_206A_200B_202B_202D_200E_202A_206C_206D_206F_200F_206C_206F_202D_200D_200D_206B_202C_200F_202B_206A_202E_206F_206F_206F_200F_202B_200D_202A_206B_202D_206A_200B_200F_202C_202E(typeof(double).TypeHandle)))
					{
						num10 = -1274199907;
						num11 = num10;
					}
					else
					{
						num10 = -1476234210;
						num11 = num10;
					}
					num2 = num10 ^ ((int)num3 * -1989510303);
					continue;
				}
				case 5u:
					d6 = testOverride4.Test(i, j);
					num2 = ((int)num3 * -1432637002) ^ -1653463271;
					continue;
				case 42u:
				{
					int num9;
					if (num != 3)
					{
						num2 = 1590687608;
						num9 = num2;
					}
					else
					{
						num2 = 1099018096;
						num9 = num2;
					}
					continue;
				}
				case 36u:
					return 1;
				case 27u:
					str3 = LuaScriptMgr.GetString(L, 3);
					num2 = ((int)num3 * -1223079822) ^ 0xD11AFD2;
					continue;
				case 39u:
					testOverride4 = (TestOverride)LuaScriptMgr.GetNetObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3429706012u));
					num2 = (int)(num3 * 9306147) ^ -623922276;
					continue;
				case 15u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2845374834u));
					num2 = 1210999701;
					continue;
				case 24u:
				{
					int num6;
					int num7;
					if (!LuaScriptMgr.CheckTypes(L, 1, _206C_202E_202E_200B_206D_200E_206A_200B_202B_202D_200E_202A_206C_206D_206F_200F_206C_206F_202D_200D_200D_206B_202C_200F_202B_206A_202E_206F_206F_206F_200F_202B_200D_202A_206B_202D_206A_200B_200F_202C_202E(typeof(string).TypeHandle), _206C_202E_202E_200B_206D_200E_206A_200B_202B_202D_200E_202A_206C_206D_206F_200F_206C_206F_202D_200D_200D_206B_202C_200F_202B_206A_202E_206F_206F_206F_200F_202B_200D_202A_206B_202D_206A_200B_200F_202C_202E(typeof(string).TypeHandle)))
					{
						num6 = -2031857640;
						num7 = num6;
					}
					else
					{
						num6 = -1165142477;
						num7 = num6;
					}
					num2 = num6 ^ ((int)num3 * -936810478);
					continue;
				}
				case 20u:
					LuaScriptMgr.Push(L, d5);
					return 1;
				case 7u:
					varObject = LuaScriptMgr.GetVarObject(L, 2);
					num2 = (int)(num3 * 110573201) ^ -1713776932;
					continue;
				case 1u:
				{
					string str2 = LuaScriptMgr.GetString(L, 2);
					int d4 = TestOverride.Test(str, str2);
					LuaScriptMgr.Push(L, d4);
					num2 = ((int)num3 * -549884796) ^ -1399807215;
					continue;
				}
				case 2u:
					LuaScriptMgr.Push(L, d);
					num2 = (int)(num3 * 1152083040) ^ -1190282315;
					continue;
				case 8u:
				{
					int num4;
					int num5;
					if (num == 2)
					{
						num4 = 1216877546;
						num5 = num4;
					}
					else
					{
						num4 = 1101743552;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num3 * -110159226);
					continue;
				}
				default:
					return 0;
				}
				break;
			}
		}
	}

	static Type _206C_202E_202E_200B_206D_200E_206A_200B_202B_202D_200E_202A_206C_206D_206F_200F_206C_206F_202D_200D_200D_206B_202C_200F_202B_206A_202E_206F_206F_206F_200F_202B_200D_202A_206B_202D_206A_200B_200F_202C_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
