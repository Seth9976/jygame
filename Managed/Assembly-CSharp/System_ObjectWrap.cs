using System;
using LuaInterface;

public class System_ObjectWrap
{
	private static Type classType = _202B_202C_202E_202C_206C_202B_200C_206B_202D_200B_202B_202A_206D_202C_202E_202A_202B_206B_200D_206D_206A_206A_206E_206E_200E_200E_202E_206F_206B_206B_202E_200F_200E_202C_206C_200E_206E_206D_202D_202A_202E(typeof(object).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[9]
		{
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(145972927u), Equals),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1396544371u), GetHashCode),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(228438169u), GetType),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4146417739u), ToString),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3650093644u), ReferenceEquals),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2713609837u), Destroy),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2705981273u), _206C_206C_206F_206E_206A_206E_206B_202B_206F_206C_202B_202C_206D_206B_202C_206C_206F_202E_202B_202E_206E_200F_206B_206D_200B_200B_206A_200B_202B_202D_200D_200E_202C_202E_202C_202E_206E_206F_202B_202E),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(215375861u), GetClassType),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3959348494u), Lua_ToString)
		};
		LuaField[] fields = new LuaField[0];
		LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1515284418u), _202B_202C_202E_202C_206C_202B_200C_206B_202D_200B_202B_202A_206D_202C_202E_202A_202B_206B_200D_206D_206A_206A_206E_206E_200E_200E_202E_206F_206B_206B_202E_200F_200E_202C_206C_200E_206E_206D_202D_202A_202E(typeof(object).TypeHandle), regs, fields, null);
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _206C_206C_206F_206E_206A_206E_206B_202B_206F_206C_202B_202C_206D_206B_202C_206C_206F_202E_202B_202E_206E_200F_206B_206D_200B_200B_206A_200B_202B_202D_200D_200E_202C_202E_202C_202E_206E_206F_202B_202E(IntPtr P_0)
	{
		int num = LuaDLL.lua_gettop(P_0);
		object o = default(object);
		while (true)
		{
			int num2 = 1388972323;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x5B713F6E)) % 7)
				{
				case 5u:
					break;
				case 6u:
					LuaDLL.luaL_error(P_0, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2971174225u));
					num2 = 1557350992;
					continue;
				case 1u:
					return 1;
				case 3u:
					LuaScriptMgr.PushVarObject(P_0, o);
					num2 = ((int)num3 * -1989262234) ^ 0x81454C5;
					continue;
				case 2u:
					o = _206C_206E_200C_202E_206A_200B_200B_200C_206F_206D_200D_200D_206A_206E_206F_206A_206B_202B_202A_202B_206B_200B_206F_202C_200B_206B_202A_202D_206F_202A_202B_206A_202D_202B_206E_202D_206A_202B_202D_206E_202E();
					num2 = ((int)num3 * -631868077) ^ -780500373;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (num != 0)
					{
						num4 = 387462771;
						num5 = num4;
					}
					else
					{
						num4 = 942790196;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 702680023);
					continue;
				}
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
	private static int Lua_ToString(IntPtr L)
	{
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		while (true)
		{
			int num = -744292138;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -407492037)) % 5)
				{
				case 3u:
					break;
				case 0u:
					LuaScriptMgr.Push(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1273958323u));
					num = -2082677458;
					continue;
				case 1u:
					LuaScriptMgr.Push(L, _200D_206A_202E_200E_200B_206D_200D_200B_200F_200E_200C_206F_206D_202A_200D_200C_200B_202D_206A_206E_206D_200C_202D_200F_202A_200E_200C_200D_206E_202C_200B_202D_206F_200F_206D_202D_206F_200F_206A_200D_202E(luaObject));
					num = (int)(num2 * 1833994391) ^ -1618379552;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (luaObject == null)
					{
						num3 = 1935822837;
						num4 = num3;
					}
					else
					{
						num3 = 383306349;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 902774404);
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
	private static int Equals(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		object varObject = default(object);
		object varObject2 = default(object);
		while (true)
		{
			int num = 859682327;
			while (true)
			{
				uint num2;
				bool num3;
				bool b;
				switch ((num2 = (uint)(num ^ 0x501076B5)) % 5)
				{
				case 4u:
					break;
				case 3u:
					varObject = LuaScriptMgr.GetVarObject(L, 1);
					varObject2 = LuaScriptMgr.GetVarObject(L, 2);
					num = (int)(num2 * 1580537307) ^ -1522567336;
					continue;
				case 2u:
					num3 = _206F_200C_206C_200E_206D_202C_202A_202D_206D_202D_200F_200D_206C_200E_206F_202A_202B_200F_202C_200E_202E_206C_202D_202C_202A_202A_200F_200E_202B_202B_202B_200C_200B_206E_206C_202D_202A_206E_202D_206D_202E(varObject, varObject2);
					goto IL_005d;
				case 1u:
					if (varObject == null)
					{
						num3 = varObject2 == null;
						goto IL_005d;
					}
					num = (int)(num2 * 1382056405) ^ -585401927;
					continue;
				default:
					{
						return 1;
					}
					IL_005d:
					b = num3;
					LuaScriptMgr.Push(L, b);
					num = 166500476;
					continue;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetHashCode(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		int d = default(int);
		while (true)
		{
			int num = 1734912961;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x765C849E)) % 4)
				{
				case 2u:
					break;
				case 3u:
				{
					object netObjectSelf = LuaScriptMgr.GetNetObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(631915089u));
					d = _202E_202D_200C_200C_202D_206F_206B_200D_206E_206E_202B_202D_202C_206C_202A_200C_202D_200B_206D_200C_206F_206D_206C_206D_202E_202E_200F_202B_200F_206B_200D_200D_206F_200D_200D_202A_206C_200F_206D_202C_202E(netObjectSelf);
					num = ((int)num2 * -149404710) ^ 0x20D26BDC;
					continue;
				}
				case 0u:
					LuaScriptMgr.Push(L, d);
					num = ((int)num2 * -1924845423) ^ 0x77A95C5B;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetType(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		object netObjectSelf = LuaScriptMgr.GetNetObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(697866560u));
		Type o = default(Type);
		while (true)
		{
			int num = 2062861030;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7DD08FE5)) % 4)
				{
				case 2u:
					break;
				case 3u:
					o = _206F_206B_206E_202C_200C_206C_206F_200F_200F_206B_202A_202C_200B_206D_206F_202E_200E_202E_202D_202B_206B_202E_206B_200F_200D_202A_202A_200E_206A_200C_206C_206E_200E_206E_200C_200F_202E_200D_202D_202D_202E(netObjectSelf);
					num = (int)(num2 * 205692640) ^ -211586751;
					continue;
				case 0u:
					LuaScriptMgr.Push(L, o);
					num = ((int)num2 * -1020266789) ^ -666611484;
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
		LuaScriptMgr.CheckArgsCount(L, 1);
		object netObjectSelf = LuaScriptMgr.GetNetObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(610231348u));
		string str = _200D_206A_202E_200E_200B_206D_200D_200B_200F_200E_200C_206F_206D_202A_200D_200C_200B_202D_206A_206E_206D_200C_202D_200F_202A_200E_200C_200D_206E_202C_200B_202D_206F_200F_206D_202D_206F_200F_206A_200D_202E(netObjectSelf);
		while (true)
		{
			int num = 636791447;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x54BD8EC8)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0042;
				default:
					return 1;
				}
				break;
				IL_0042:
				LuaScriptMgr.Push(L, str);
				num = ((int)num2 * -264665842) ^ 0x11970A89;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int ReferenceEquals(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		object varObject = default(object);
		object varObject2 = default(object);
		while (true)
		{
			int num = -1765318486;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -240791499)) % 5)
				{
				case 2u:
					break;
				case 3u:
				{
					bool b = _206B_200D_202B_202B_200B_200D_202A_202A_202B_200F_206B_200F_200C_200C_206D_206B_206B_200B_200D_206E_202A_202A_200F_202B_202D_200F_202C_206B_200D_206C_206A_200E_200E_206A_206B_206C_206B_202C_206E_202D_202E(varObject, varObject2);
					LuaScriptMgr.Push(L, b);
					num = (int)(num2 * 867916233) ^ -878545857;
					continue;
				}
				case 4u:
					varObject2 = LuaScriptMgr.GetVarObject(L, 2);
					num = (int)(num2 * 1717896443) ^ -1564673356;
					continue;
				case 1u:
					varObject = LuaScriptMgr.GetVarObject(L, 1);
					num = (int)((num2 * 1827644080) ^ 0x7626FF0A);
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Destroy(IntPtr L)
	{
		LuaScriptMgr.__gc(L);
		return 0;
	}

	static Type _202B_202C_202E_202C_206C_202B_200C_206B_202D_200B_202B_202A_206D_202C_202E_202A_202B_206B_200D_206D_206A_206A_206E_206E_200E_200E_202E_206F_206B_206B_202E_200F_200E_202C_206C_200E_206E_206D_202D_202A_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static object _206C_206E_200C_202E_206A_200B_200B_200C_206F_206D_200D_200D_206A_206E_206F_206A_206B_202B_202A_202B_206B_200B_206F_202C_200B_206B_202A_202D_206F_202A_202B_206A_202D_202B_206E_202D_206A_202B_202D_206E_202E()
	{
		return new object();
	}

	static string _200D_206A_202E_200E_200B_206D_200D_200B_200F_200E_200C_206F_206D_202A_200D_200C_200B_202D_206A_206E_206D_200C_202D_200F_202A_200E_200C_200D_206E_202C_200B_202D_206F_200F_206D_202D_206F_200F_206A_200D_202E(object P_0)
	{
		return P_0.ToString();
	}

	static bool _206F_200C_206C_200E_206D_202C_202A_202D_206D_202D_200F_200D_206C_200E_206F_202A_202B_200F_202C_200E_202E_206C_202D_202C_202A_202A_200F_200E_202B_202B_202B_200C_200B_206E_206C_202D_202A_206E_202D_206D_202E(object P_0, object P_1)
	{
		return P_0.Equals(P_1);
	}

	static int _202E_202D_200C_200C_202D_206F_206B_200D_206E_206E_202B_202D_202C_206C_202A_200C_202D_200B_206D_200C_206F_206D_206C_206D_202E_202E_200F_202B_200F_206B_200D_200D_206F_200D_200D_202A_206C_200F_206D_202C_202E(object P_0)
	{
		return P_0.GetHashCode();
	}

	static Type _206F_206B_206E_202C_200C_206C_206F_200F_200F_206B_202A_202C_200B_206D_206F_202E_200E_202E_202D_202B_206B_202E_206B_200F_200D_202A_202A_200E_206A_200C_206C_206E_200E_206E_200C_200F_202E_200D_202D_202D_202E(object P_0)
	{
		return P_0.GetType();
	}

	static bool _206B_200D_202B_202B_200B_200D_202A_202A_202B_200F_206B_200F_200C_200C_206D_206B_206B_200B_200D_206E_202A_202A_200F_202B_202D_200F_202C_206B_200D_206C_206A_200E_200E_206A_206B_206C_206B_202C_206E_202D_202E(object P_0, object P_1)
	{
		return object.ReferenceEquals(P_0, P_1);
	}
}
