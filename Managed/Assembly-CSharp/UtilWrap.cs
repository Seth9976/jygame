using System;
using LuaInterface;

public class UtilWrap
{
	private static Type classType = _202E_202E_202D_206B_200E_206B_202C_200C_202A_200E_206B_202E_202C_206D_206A_200F_206D_200D_206B_200E_200F_202A_202D_206C_206B_202E_206A_206F_202D_202A_202B_200E_206A_206A_202A_206B_202C_200E_202B_202E(typeof(Util).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[8]
		{
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4163461766u), LuaPath),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3347026372u), Log),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(290813879u), LogWarning),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(266585918u), LogError),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(864345378u), ClearMemory),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3683402189u), CheckEnvironment),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2705981273u), _206C_206E_200F_202C_202D_206D_202B_206B_206E_206D_200F_202C_206E_202E_206F_202E_200D_206D_206F_206B_202C_202D_200F_206C_206E_206D_200E_202A_202C_206A_202D_200E_202D_206C_200C_202A_202D_206E_202E_202A_202E),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(10103728u), GetClassType)
		};
		LuaField[] fields = default(LuaField[]);
		while (true)
		{
			int num = 635271449;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2973221F)) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_0161;
				default:
					LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3941942163u), _202E_202E_202D_206B_200E_206B_202C_200C_202A_200E_206B_202E_202C_206D_206A_200F_206D_200D_206B_200E_200F_202A_202D_206C_206B_202E_206A_206F_202D_202A_202B_200E_206A_206A_202A_206B_202C_200E_202B_202E(typeof(Util).TypeHandle), regs, fields, _202E_202E_202D_206B_200E_206B_202C_200C_202A_200E_206B_202E_202C_206D_206A_200F_206D_200D_206B_200E_200F_202A_202D_206C_206B_202E_206A_206F_202D_202A_202B_200E_206A_206A_202A_206B_202C_200E_202B_202E(typeof(object).TypeHandle));
					return;
				}
				break;
				IL_0161:
				fields = new LuaField[1]
				{
					new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3398815691u), get_isApplePlatform, null)
				};
				num = ((int)num2 * -617893013) ^ -895374449;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _206C_206E_200F_202C_202D_206D_202B_206B_206E_206D_200F_202C_206E_202E_206F_202E_200D_206D_206F_206B_202C_202D_200F_206C_206E_206D_200E_202A_202C_206A_202D_200E_202D_206C_200C_202A_202D_206E_202E_202A_202E(IntPtr P_0)
	{
		if (LuaDLL.lua_gettop(P_0) == 0)
		{
			Util o = default(Util);
			while (true)
			{
				int num = 1688361872;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x74E3864D)) % 4)
					{
					case 2u:
						break;
					case 1u:
						o = new Util();
						num = (int)((num2 * 697850811) ^ 0x8AD9C65);
						continue;
					case 3u:
						LuaScriptMgr.PushObject(P_0, o);
						return 1;
					default:
						goto end_IL_000a;
					}
					break;
				}
				continue;
				end_IL_000a:
				break;
			}
		}
		LuaDLL.luaL_error(P_0, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2319131520u));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_isApplePlatform(IntPtr L)
	{
		LuaScriptMgr.Push(L, Util.isApplePlatform);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int LuaPath(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string luaString = LuaScriptMgr.GetLuaString(L, 1);
		string str = Util.LuaPath(luaString);
		LuaScriptMgr.Push(L, str);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Log(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string luaString = default(string);
		while (true)
		{
			int num = 178956089;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2E65D0D9)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_0029;
				default:
					Util.Log(luaString);
					return 0;
				}
				break;
				IL_0029:
				luaString = LuaScriptMgr.GetLuaString(L, 1);
				num = ((int)num2 * -1542382504) ^ -2118151110;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int LogWarning(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string luaString = default(string);
		while (true)
		{
			int num = 306961549;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x479C3BD2)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0029;
				default:
					Util.LogWarning(luaString);
					return 0;
				}
				break;
				IL_0029:
				luaString = LuaScriptMgr.GetLuaString(L, 1);
				num = (int)((num2 * 702157685) ^ 0x58F478B1);
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int LogError(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string luaString = default(string);
		while (true)
		{
			int num = -1466765152;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -764011795)) % 4)
				{
				case 3u:
					break;
				case 1u:
					luaString = LuaScriptMgr.GetLuaString(L, 1);
					num = (int)((num2 * 913256258) ^ 0x79A91EDF);
					continue;
				case 0u:
					Util.LogError(luaString);
					num = (int)(num2 * 2121877572) ^ -902872485;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int ClearMemory(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		Util.ClearMemory();
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int CheckEnvironment(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		bool b = Util.CheckEnvironment();
		LuaScriptMgr.Push(L, b);
		return 1;
	}

	static Type _202E_202E_202D_206B_200E_206B_202C_200C_202A_200E_206B_202E_202C_206D_206A_200F_206D_200D_206B_200E_200F_202A_202D_206C_206B_202E_206A_206F_202D_202A_202B_200E_206A_206A_202A_206B_202C_200E_202B_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
