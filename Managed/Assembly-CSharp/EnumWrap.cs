using System;
using LuaInterface;

public class EnumWrap
{
	private static Type classType = _206B_206B_202E_202E_202B_202B_206B_206A_202C_202A_206F_206C_200C_200D_202B_200F_206A_200E_206C_206E_200D_206C_200B_200E_200B_200B_206F_200D_202C_206B_202A_202E_206F_200C_202A_202D_202C_200C_200F_206E_202E(typeof(Enum).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[17]
		{
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1010372068u), GetTypeCode),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3908331248u), GetValues),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3744261649u), GetNames),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3949964689u), GetName),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3365050314u), IsDefined),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(444827521u), GetUnderlyingType),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(79033324u), Parse),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4180680949u), CompareTo),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2829693887u), ToString),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1367683409u), ToObject),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3038330630u), Format),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3015724630u), GetHashCode),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(145972927u), Equals),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2254933974u), _206C_206E_206F_200B_202B_200C_202E_202C_202C_202D_200E_200C_206B_202A_202E_202D_202D_200E_202E_202D_206C_200E_206C_206E_206F_200B_202D_202D_206E_206A_206E_202E_206D_206E_202A_202B_202D_200C_202B_202E),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3661446913u), GetClassType),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(44125471u), Lua_ToString),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(60698966u), Lua_Eq)
		};
		LuaField[] fields = default(LuaField[]);
		while (true)
		{
			int num = -1682641816;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -258992509)) % 4)
				{
				case 0u:
					break;
				default:
					return;
				case 3u:
					fields = new LuaField[0];
					num = ((int)num2 * -1991190280) ^ -1527969530;
					continue;
				case 1u:
					LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3076066123u), _206B_206B_202E_202E_202B_202B_206B_206A_202C_202A_206F_206C_200C_200D_202B_200F_206A_200E_206C_206E_200D_206C_200B_200E_200B_200B_206F_200D_202C_206B_202A_202E_206F_200C_202A_202D_202C_200C_200F_206E_202E(typeof(Enum).TypeHandle), regs, fields, null);
					num = ((int)num2 * -753631317) ^ -780765114;
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _206C_206E_206F_200B_202B_200C_202E_202C_202C_202D_200E_200C_206B_202A_202E_202D_202D_200E_202E_202D_206C_200E_206C_206E_206F_200B_202D_202D_206E_206A_206E_202E_206D_206E_202A_202B_202D_200C_202B_202E(IntPtr P_0)
	{
		LuaDLL.luaL_error(P_0, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2925124151u));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Lua_ToString(IntPtr L)
	{
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		while (true)
		{
			int num = 1101579672;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1E906C8D)) % 6)
				{
				case 3u:
					break;
				case 5u:
				{
					int num3;
					int num4;
					if (luaObject != null)
					{
						num3 = 546384770;
						num4 = num3;
					}
					else
					{
						num3 = 475764026;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1250607053);
					continue;
				}
				case 2u:
					LuaScriptMgr.Push(L, _200C_200E_202B_206F_200F_206F_206C_200B_200C_202B_206D_206A_200F_200F_202A_206F_200D_202A_202D_206A_200D_206C_202E_206E_206A_202E_206D_202C_202D_200B_202C_202C_202A_200B_206F_202D_206B_206E_206F_200D_202E(luaObject));
					num = ((int)num2 * -978199012) ^ -258325861;
					continue;
				case 4u:
					num = ((int)num2 * -766774293) ^ 0x14E55D6;
					continue;
				case 0u:
					LuaScriptMgr.Push(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4137883155u));
					num = 856264548;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetTypeCode(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Enum obj = default(Enum);
		TypeCode typeCode = default(TypeCode);
		while (true)
		{
			int num = -193702961;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1259301424)) % 4)
				{
				case 0u:
					break;
				case 3u:
					obj = (Enum)LuaScriptMgr.GetNetObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2575020221u));
					num = (int)((num2 * 785120544) ^ 0xDEEE2D5);
					continue;
				case 1u:
					typeCode = _200E_200F_202C_200E_206D_206A_206A_200C_206F_202A_206E_200C_200F_200C_206E_206A_200C_206D_206A_206D_200F_206B_202D_202E_200B_206A_200F_200B_200C_202D_206E_200B_200D_200E_206D_206A_206A_200E_202A_206C_202E(obj);
					num = (int)(num2 * 463002156) ^ -186210638;
					continue;
				default:
					LuaScriptMgr.Push(L, (Enum)typeCode);
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetValues(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Type typeObject = LuaScriptMgr.GetTypeObject(L, 1);
		Array o = default(Array);
		while (true)
		{
			int num = 1659339809;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x72810A94)) % 4)
				{
				case 3u:
					break;
				case 1u:
					o = _206B_206D_200B_200D_206B_206E_202D_200C_200D_200D_200B_200D_206D_206C_200D_200E_206D_206F_206B_202E_200D_202C_206F_206D_202A_200D_200E_200E_202B_200F_206F_206B_206C_202E_200B_206F_200C_206D_202D_202D_202E(typeObject);
					num = ((int)num2 * -1985441764) ^ -802576708;
					continue;
				case 0u:
					LuaScriptMgr.PushObject(L, o);
					num = (int)(num2 * 287416234) ^ -1399106726;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetNames(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Type typeObject = LuaScriptMgr.GetTypeObject(L, 1);
		string[] o = _206E_206F_206D_206F_206D_206E_202D_200D_206F_200C_200B_206C_206E_202B_200D_200D_202C_206E_206B_200D_206A_206F_202D_206C_202C_206B_200E_200E_206A_202E_200F_202D_200F_202C_202A_206D_202B_200D_206F_202E_202E(typeObject);
		while (true)
		{
			int num = 849056420;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7A5C2ABE)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_0038;
				default:
					return 1;
				}
				break;
				IL_0038:
				LuaScriptMgr.PushArray(L, o);
				num = ((int)num2 * -2054543618) ^ -1420375790;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetName(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Type typeObject = default(Type);
		object varObject = default(object);
		string str = default(string);
		while (true)
		{
			int num = 285569491;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x35E9E198)) % 4)
				{
				case 0u:
					break;
				case 3u:
					typeObject = LuaScriptMgr.GetTypeObject(L, 1);
					varObject = LuaScriptMgr.GetVarObject(L, 2);
					num = ((int)num2 * -1263104539) ^ -1363305778;
					continue;
				case 1u:
					str = _206F_206F_206D_202D_202E_202D_202B_206C_200E_206B_206D_202C_206F_206F_200F_202C_200B_206B_206D_202D_206D_200D_206D_202E_206D_200E_200E_202C_206C_200B_200B_202D_200E_200C_206D_206F_200C_200D_202E(typeObject, varObject);
					num = ((int)num2 * -598386070) ^ -1241745656;
					continue;
				default:
					LuaScriptMgr.Push(L, str);
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int IsDefined(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Type typeObject = LuaScriptMgr.GetTypeObject(L, 1);
		object varObject = default(object);
		while (true)
		{
			int num = -1347908360;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1065203619)) % 4)
				{
				case 2u:
					break;
				case 1u:
					varObject = LuaScriptMgr.GetVarObject(L, 2);
					num = ((int)num2 * -903741882) ^ -1466393984;
					continue;
				case 3u:
				{
					bool b = _206D_202E_200C_200B_202A_202E_206D_206B_206C_206E_200E_200B_206B_202C_206F_206C_206A_202D_206A_206A_200D_206D_202D_200B_202C_206C_202D_200B_206B_206C_206E_206E_202E_206D_200D_206F_206C_206F_200B_202E_202E(typeObject, varObject);
					LuaScriptMgr.Push(L, b);
					num = ((int)num2 * -1055294861) ^ -938716436;
					continue;
				}
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetUnderlyingType(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Type typeObject = default(Type);
		Type o = default(Type);
		while (true)
		{
			int num = 314535501;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3ED57D0B)) % 4)
				{
				case 0u:
					break;
				case 2u:
					typeObject = LuaScriptMgr.GetTypeObject(L, 1);
					num = (int)(num2 * 1377219003) ^ -918954652;
					continue;
				case 1u:
					o = _200F_200C_202D_200E_202D_206B_206A_202A_200F_200C_200D_202A_202B_200C_206C_206E_202A_202D_200B_200C_202A_202E_206C_202D_200F_206F_200D_200D_202B_206C_200D_202A_202E_200D_206D_206B_206A_206F_202E_206B_202E(typeObject);
					num = (int)(num2 * 72368733) ^ -539122915;
					continue;
				default:
					LuaScriptMgr.Push(L, o);
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Parse(IntPtr L)
	{
		int num = LuaDLL.lua_gettop(L);
		if (num == 2)
		{
			goto IL_000e;
		}
		goto IL_00ae;
		IL_000e:
		int num2 = 95341280;
		goto IL_0013;
		IL_0013:
		object o = default(object);
		Type typeObject2 = default(Type);
		string luaString2 = default(string);
		Type typeObject = default(Type);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ 0x114029D7)) % 10)
			{
			case 3u:
				break;
			case 7u:
				LuaScriptMgr.PushVarObject(L, o);
				num2 = ((int)num3 * -1021102609) ^ 0x8617E46;
				continue;
			case 0u:
			{
				bool boolean = LuaScriptMgr.GetBoolean(L, 3);
				object o2 = _202E_206C_202A_200D_206E_200E_200D_206D_200D_206E_202A_200E_206F_206C_206D_206E_200D_206C_200E_202A_202B_200E_202E_200B_206C_206D_200B_206A_202D_200E_200D_202B_200C_206F_206F_200D_202A_202A_202A_206D_202E(typeObject2, luaString2, boolean);
				LuaScriptMgr.PushVarObject(L, o2);
				num2 = (int)((num3 * 840086387) ^ 0x2E46D33F);
				continue;
			}
			case 4u:
				return 1;
			case 1u:
				goto IL_00ae;
			case 2u:
				typeObject2 = LuaScriptMgr.GetTypeObject(L, 1);
				luaString2 = LuaScriptMgr.GetLuaString(L, 2);
				num2 = (int)(num3 * 59406453) ^ -591995969;
				continue;
			case 9u:
			{
				string luaString = LuaScriptMgr.GetLuaString(L, 2);
				o = _200F_200E_202C_202A_206A_202E_206B_202A_206E_206B_200F_206E_202C_202C_206D_202D_202D_200C_206E_200E_206D_206D_206D_202E_202A_200C_206E_202B_206A_200D_200E_206F_206F_202A_200B_202D_200D_206C_200F_206A_202E(typeObject, luaString);
				num2 = (int)(num3 * 48584501) ^ -1020250219;
				continue;
			}
			case 8u:
				return 1;
			case 5u:
				typeObject = LuaScriptMgr.GetTypeObject(L, 1);
				num2 = (int)((num3 * 1562074092) ^ 0x8CBE5B2);
				continue;
			default:
				LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3837670640u));
				return 0;
			}
			break;
		}
		goto IL_000e;
		IL_00ae:
		int num4;
		if (num == 3)
		{
			num2 = 1097059415;
			num4 = num2;
		}
		else
		{
			num2 = 540135993;
			num4 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int CompareTo(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Enum obj = (Enum)LuaScriptMgr.GetNetObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3663123747u));
		object varObject = default(object);
		int d = default(int);
		while (true)
		{
			int num = 614379994;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x76F9CE67)) % 5)
				{
				case 0u:
					break;
				case 1u:
					varObject = LuaScriptMgr.GetVarObject(L, 2);
					num = (int)((num2 * 180132777) ^ 0x22602A5B);
					continue;
				case 3u:
					LuaScriptMgr.Push(L, d);
					num = ((int)num2 * -1483031270) ^ -835267889;
					continue;
				case 2u:
					d = _202D_202D_200C_202C_206B_200D_202E_202C_206E_206A_202A_202B_200C_202C_206C_206E_206E_200D_200F_202E_200B_206A_200B_202C_206D_206E_202E_206A_202D_200B_200C_200D_206B_202C_206F_206E_206C_202A_206E_202C_202E(obj, varObject);
					num = (int)((num2 * 1280718646) ^ 0x15A0ECFE);
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int ToString(IntPtr L)
	{
		int num = LuaDLL.lua_gettop(L);
		if (num == 1)
		{
			goto IL_000e;
		}
		goto IL_00d7;
		IL_000e:
		int num2 = -328286694;
		goto IL_0013;
		IL_0013:
		Enum obj = default(Enum);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ -575097333)) % 8)
			{
			case 3u:
				break;
			case 1u:
				obj = (Enum)LuaScriptMgr.GetNetObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(300804076u));
				num2 = ((int)num3 * -1926078740) ^ -1877255931;
				continue;
			case 4u:
			{
				Enum obj2 = (Enum)LuaScriptMgr.GetNetObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2575020221u));
				string luaString = LuaScriptMgr.GetLuaString(L, 2);
				string str2 = _200C_202E_206D_206B_206A_202C_200F_202E_200B_206C_202A_202E_206A_206E_202C_200E_206D_202B_206E_200E_206E_206D_200E_200B_202C_200D_200E_202C_202D_206E_202B_200B_200F_206C_206C_202B_202B_202D_206E_202E_202E(obj2, luaString);
				LuaScriptMgr.Push(L, str2);
				num2 = (int)((num3 * 1300457016) ^ 0x46DDCD55);
				continue;
			}
			case 2u:
			{
				string str = _206E_206D_206B_200D_200E_202D_206E_206C_206D_202D_206C_200F_200B_202B_202A_202E_206B_206F_202A_206B_202A_202A_206D_206B_202E_206B_202B_206C_200F_200D_202B_206F_202D_202B_206D_206F_206F_202B_206F_206C_202E(obj);
				LuaScriptMgr.Push(L, str);
				return 1;
			}
			case 5u:
				goto IL_00d7;
			case 0u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(453188547u));
				num2 = -1314201396;
				continue;
			case 6u:
				return 1;
			default:
				return 0;
			}
			break;
		}
		goto IL_000e;
		IL_00d7:
		int num4;
		if (num != 2)
		{
			num2 = -971937797;
			num4 = num2;
		}
		else
		{
			num2 = -1773281305;
			num4 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int ToObject(IntPtr L)
	{
		int num = LuaDLL.lua_gettop(L);
		if (num == 2)
		{
			goto IL_000e;
		}
		goto IL_0134;
		IL_000e:
		int num2 = -766662862;
		goto IL_0013;
		IL_0013:
		object o2 = default(object);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ -822735193)) % 10)
			{
			case 8u:
				break;
			case 9u:
				return 1;
			case 1u:
			{
				Type typeObject = LuaScriptMgr.GetTypeObject(L, 1);
				long num6 = (long)LuaDLL.lua_tonumber(L, 2);
				object o = _200F_202B_202D_206B_206F_202E_202B_202D_202A_206E_202E_206A_206C_206C_200E_202A_206B_206A_206D_202E_202B_206C_206D_200E_206D_206D_202C_206B_202B_206B_206F_202B_206A_206D_206C_202D_206B_206C_200B_206C_202E(typeObject, num6);
				LuaScriptMgr.PushVarObject(L, o);
				num2 = ((int)num3 * -1159843257) ^ 0x4FEDF2BF;
				continue;
			}
			case 5u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3323050139u));
				num2 = -1058391977;
				continue;
			case 3u:
			{
				int num7;
				int num8;
				if (!LuaScriptMgr.CheckTypes(L, 1, _206B_206B_202E_202E_202B_202B_206B_206A_202C_202A_206F_206C_200C_200D_202B_200F_206A_200E_206C_206E_200D_206C_200B_200E_200B_200B_206F_200D_202C_206B_202A_202E_206F_200C_202A_202D_202C_200C_200F_206E_202E(typeof(Type).TypeHandle), _206B_206B_202E_202E_202B_202B_206B_206A_202C_202A_206F_206C_200C_200D_202B_200F_206A_200E_206C_206E_200D_206C_200B_200E_200B_200B_206F_200D_202C_206B_202A_202E_206F_200C_202A_202D_202C_200C_200F_206E_202E(typeof(long).TypeHandle)))
				{
					num7 = -1299645312;
					num8 = num7;
				}
				else
				{
					num7 = -1905863020;
					num8 = num7;
				}
				num2 = num7 ^ ((int)num3 * -937017042);
				continue;
			}
			case 2u:
				LuaScriptMgr.PushVarObject(L, o2);
				return 1;
			case 4u:
			{
				Type typeObject2 = LuaScriptMgr.GetTypeObject(L, 1);
				object varObject = LuaScriptMgr.GetVarObject(L, 2);
				o2 = _200B_206E_200C_206D_202E_206A_202B_202E_200D_206A_202A_200C_202A_206A_202D_202C_206B_206A_202C_202D_200B_200F_200C_202E_200D_206D_200F_202C_200E_202B_202E_202A_206D_206B_202D_206A_200F_202E_200C_206C_202E(typeObject2, varObject);
				num2 = ((int)num3 * -1687222034) ^ 0x46995CC7;
				continue;
			}
			case 7u:
				goto IL_0134;
			case 0u:
			{
				int num4;
				int num5;
				if (!LuaScriptMgr.CheckTypes(L, 1, _206B_206B_202E_202E_202B_202B_206B_206A_202C_202A_206F_206C_200C_200D_202B_200F_206A_200E_206C_206E_200D_206C_200B_200E_200B_200B_206F_200D_202C_206B_202A_202E_206F_200C_202A_202D_202C_200C_200F_206E_202E(typeof(Type).TypeHandle), _206B_206B_202E_202E_202B_202B_206B_206A_202C_202A_206F_206C_200C_200D_202B_200F_206A_200E_206C_206E_200D_206C_200B_200E_200B_200B_206F_200D_202C_206B_202A_202E_206F_200C_202A_202D_202C_200C_200F_206E_202E(typeof(object).TypeHandle)))
				{
					num4 = 130058766;
					num5 = num4;
				}
				else
				{
					num4 = 1128460667;
					num5 = num4;
				}
				num2 = num4 ^ (int)(num3 * 1971163511);
				continue;
			}
			default:
				return 0;
			}
			break;
		}
		goto IL_000e;
		IL_0134:
		int num9;
		if (num == 2)
		{
			num2 = -1991808471;
			num9 = num2;
		}
		else
		{
			num2 = -889149940;
			num9 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Format(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		Type typeObject = LuaScriptMgr.GetTypeObject(L, 1);
		object varObject = default(object);
		string luaString = default(string);
		string str = default(string);
		while (true)
		{
			int num = -628393948;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -776229290)) % 5)
				{
				case 0u:
					break;
				case 2u:
					varObject = LuaScriptMgr.GetVarObject(L, 2);
					num = (int)((num2 * 1901787684) ^ 0x5ED96070);
					continue;
				case 4u:
					luaString = LuaScriptMgr.GetLuaString(L, 3);
					num = ((int)num2 * -1309935945) ^ -304136897;
					continue;
				case 3u:
					str = _206B_202B_200B_206F_200C_200F_202A_200E_206C_200C_200B_200E_202B_202A_200E_202C_202D_202D_200D_202D_206A_200F_200B_202C_200D_206D_200C_206A_200F_200E_200E_200B_206F_200C_206D_206B_200C_206A_202A_200D_202E(typeObject, varObject, luaString);
					num = (int)(num2 * 120923294) ^ -917967090;
					continue;
				default:
					LuaScriptMgr.Push(L, str);
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Lua_Eq(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Enum obj2 = default(Enum);
		while (true)
		{
			int num = -163018817;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1732056154)) % 4)
				{
				case 2u:
					break;
				case 1u:
					obj2 = LuaScriptMgr.GetLuaObject(L, 1) as Enum;
					num = (int)((num2 * 883663700) ^ 0x4E80AA2D);
					continue;
				case 3u:
				{
					Enum obj = LuaScriptMgr.GetLuaObject(L, 2) as Enum;
					bool b = obj2 == obj;
					LuaScriptMgr.Push(L, b);
					num = ((int)num2 * -145837879) ^ 0x282B0841;
					continue;
				}
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetHashCode(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Enum obj = (Enum)LuaScriptMgr.GetNetObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3663123747u));
		int d = _206E_202B_202C_200D_202B_202A_200E_206B_200D_200B_202B_200E_202E_206E_202D_202D_206A_202D_200F_202E_200F_200E_206C_200D_206B_202A_206D_206E_202D_202D_200F_200F_206C_206C_202C_202D_202D_206F_206A_202A_202E(obj);
		LuaScriptMgr.Push(L, d);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Equals(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Enum obj = default(Enum);
		object varObject = default(object);
		while (true)
		{
			int num = 257888224;
			while (true)
			{
				uint num2;
				bool num3;
				bool b;
				switch ((num2 = (uint)(num ^ 0x5C1125A)) % 6)
				{
				case 0u:
					break;
				case 2u:
					obj = LuaScriptMgr.GetVarObject(L, 1) as Enum;
					num = ((int)num2 * -1898623490) ^ -2047531477;
					continue;
				case 3u:
					if (obj != null)
					{
						num = ((int)num2 * -1869440938) ^ -1990280010;
						continue;
					}
					num3 = varObject == null;
					goto IL_0087;
				case 5u:
					varObject = LuaScriptMgr.GetVarObject(L, 2);
					num = ((int)num2 * -37601744) ^ 0x72A27E7;
					continue;
				case 4u:
					num3 = _202A_202E_206F_202C_200D_200E_206F_206B_202B_206F_200C_202D_200C_206E_202C_206A_200D_200F_202B_202E_202E_200C_206F_206C_202B_200E_202E_200B_206F_202E_206F_200C_206C_206E_202A_206F_202D_202C_206F_202E(obj, varObject);
					goto IL_0087;
				default:
					{
						return 1;
					}
					IL_0087:
					b = num3;
					LuaScriptMgr.Push(L, b);
					num = 1823454565;
					continue;
				}
				break;
			}
		}
	}

	static Type _206B_206B_202E_202E_202B_202B_206B_206A_202C_202A_206F_206C_200C_200D_202B_200F_206A_200E_206C_206E_200D_206C_200B_200E_200B_200B_206F_200D_202C_206B_202A_202E_206F_200C_202A_202D_202C_200C_200F_206E_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static string _200C_200E_202B_206F_200F_206F_206C_200B_200C_202B_206D_206A_200F_200F_202A_206F_200D_202A_202D_206A_200D_206C_202E_206E_206A_202E_206D_202C_202D_200B_202C_202C_202A_200B_206F_202D_206B_206E_206F_200D_202E(object P_0)
	{
		return P_0.ToString();
	}

	static TypeCode _200E_200F_202C_200E_206D_206A_206A_200C_206F_202A_206E_200C_200F_200C_206E_206A_200C_206D_206A_206D_200F_206B_202D_202E_200B_206A_200F_200B_200C_202D_206E_200B_200D_200E_206D_206A_206A_200E_202A_206C_202E(Enum P_0)
	{
		return P_0.GetTypeCode();
	}

	static Array _206B_206D_200B_200D_206B_206E_202D_200C_200D_200D_200B_200D_206D_206C_200D_200E_206D_206F_206B_202E_200D_202C_206F_206D_202A_200D_200E_200E_202B_200F_206F_206B_206C_202E_200B_206F_200C_206D_202D_202D_202E(Type P_0)
	{
		return Enum.GetValues(P_0);
	}

	static string[] _206E_206F_206D_206F_206D_206E_202D_200D_206F_200C_200B_206C_206E_202B_200D_200D_202C_206E_206B_200D_206A_206F_202D_206C_202C_206B_200E_200E_206A_202E_200F_202D_200F_202C_202A_206D_202B_200D_206F_202E_202E(Type P_0)
	{
		return Enum.GetNames(P_0);
	}

	static string _206F_206F_206D_202D_202E_202D_202B_206C_200E_206B_206D_202C_206F_206F_200F_202C_200B_206B_206D_202D_206D_200D_206D_202E_206D_200E_200E_202C_206C_200B_200B_202D_200E_200C_206D_206F_200C_200D_202E(Type P_0, object P_1)
	{
		return Enum.GetName(P_0, P_1);
	}

	static bool _206D_202E_200C_200B_202A_202E_206D_206B_206C_206E_200E_200B_206B_202C_206F_206C_206A_202D_206A_206A_200D_206D_202D_200B_202C_206C_202D_200B_206B_206C_206E_206E_202E_206D_200D_206F_206C_206F_200B_202E_202E(Type P_0, object P_1)
	{
		return Enum.IsDefined(P_0, P_1);
	}

	static Type _200F_200C_202D_200E_202D_206B_206A_202A_200F_200C_200D_202A_202B_200C_206C_206E_202A_202D_200B_200C_202A_202E_206C_202D_200F_206F_200D_200D_202B_206C_200D_202A_202E_200D_206D_206B_206A_206F_202E_206B_202E(Type P_0)
	{
		return Enum.GetUnderlyingType(P_0);
	}

	static object _200F_200E_202C_202A_206A_202E_206B_202A_206E_206B_200F_206E_202C_202C_206D_202D_202D_200C_206E_200E_206D_206D_206D_202E_202A_200C_206E_202B_206A_200D_200E_206F_206F_202A_200B_202D_200D_206C_200F_206A_202E(Type P_0, string P_1)
	{
		return Enum.Parse(P_0, P_1);
	}

	static object _202E_206C_202A_200D_206E_200E_200D_206D_200D_206E_202A_200E_206F_206C_206D_206E_200D_206C_200E_202A_202B_200E_202E_200B_206C_206D_200B_206A_202D_200E_200D_202B_200C_206F_206F_200D_202A_202A_202A_206D_202E(Type P_0, string P_1, bool P_2)
	{
		return Enum.Parse(P_0, P_1, P_2);
	}

	static int _202D_202D_200C_202C_206B_200D_202E_202C_206E_206A_202A_202B_200C_202C_206C_206E_206E_200D_200F_202E_200B_206A_200B_202C_206D_206E_202E_206A_202D_200B_200C_200D_206B_202C_206F_206E_206C_202A_206E_202C_202E(Enum P_0, object P_1)
	{
		return P_0.CompareTo(P_1);
	}

	static string _206E_206D_206B_200D_200E_202D_206E_206C_206D_202D_206C_200F_200B_202B_202A_202E_206B_206F_202A_206B_202A_202A_206D_206B_202E_206B_202B_206C_200F_200D_202B_206F_202D_202B_206D_206F_206F_202B_206F_206C_202E(Enum P_0)
	{
		return P_0.ToString();
	}

	static string _200C_202E_206D_206B_206A_202C_200F_202E_200B_206C_202A_202E_206A_206E_202C_200E_206D_202B_206E_200E_206E_206D_200E_200B_202C_200D_200E_202C_202D_206E_202B_200B_200F_206C_206C_202B_202B_202D_206E_202E_202E(Enum P_0, string P_1)
	{
		return P_0.ToString(P_1);
	}

	static object _200F_202B_202D_206B_206F_202E_202B_202D_202A_206E_202E_206A_206C_206C_200E_202A_206B_206A_206D_202E_202B_206C_206D_200E_206D_206D_202C_206B_202B_206B_206F_202B_206A_206D_206C_202D_206B_206C_200B_206C_202E(Type P_0, long P_1)
	{
		return Enum.ToObject(P_0, P_1);
	}

	static object _200B_206E_200C_206D_202E_206A_202B_202E_200D_206A_202A_200C_202A_206A_202D_202C_206B_206A_202C_202D_200B_200F_200C_202E_200D_206D_200F_202C_200E_202B_202E_202A_206D_206B_202D_206A_200F_202E_200C_206C_202E(Type P_0, object P_1)
	{
		return Enum.ToObject(P_0, P_1);
	}

	static string _206B_202B_200B_206F_200C_200F_202A_200E_206C_200C_200B_200E_202B_202A_200E_202C_202D_202D_200D_202D_206A_200F_200B_202C_200D_206D_200C_206A_200F_200E_200E_200B_206F_200C_206D_206B_200C_206A_202A_200D_202E(Type P_0, object P_1, string P_2)
	{
		return Enum.Format(P_0, P_1, P_2);
	}

	static int _206E_202B_202C_200D_202B_202A_200E_206B_200D_200B_202B_200E_202E_206E_202D_202D_206A_202D_200F_202E_200F_200E_206C_200D_206B_202A_206D_206E_202D_202D_200F_200F_206C_206C_202C_202D_202D_206F_206A_202A_202E(Enum P_0)
	{
		return P_0.GetHashCode();
	}

	static bool _202A_202E_206F_202C_200D_200E_206F_206B_202B_206F_200C_202D_200C_206E_202C_206A_200D_200F_202B_202E_202E_200C_206F_206C_202B_200E_202E_200B_206F_202E_206F_200C_206C_206E_202A_206F_202D_202C_206F_202E(Enum P_0, object P_1)
	{
		return P_0.Equals(P_1);
	}
}
