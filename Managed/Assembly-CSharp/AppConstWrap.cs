using System;
using LuaInterface;

public class AppConstWrap
{
	private static Type classType = _200B_206E_206A_202E_206E_206A_200B_206A_200B_206E_206F_202B_200F_200F_200B_206A_206C_202B_206F_202C_202A_200F_200D_206A_206D_200B_206F_206B_200E_202D_200D_202D_200F_206C_202E_200B_200D_202C_206A_206C_202E(typeof(AppConst).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[2]
		{
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1621874631u), _200E_200B_202C_200C_206D_206D_206D_206A_206D_202D_202C_202D_206E_206C_206F_206E_200E_206B_200F_202B_200C_200F_200F_202D_206C_206B_206A_200B_202B_200D_206E_202B_202B_206A_200B_200B_206A_200F_206E_206E_202E),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(10103728u), GetClassType)
		};
		LuaField[] fields = default(LuaField[]);
		while (true)
		{
			int num = 2041384978;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x49059465)) % 4)
				{
				case 0u:
					break;
				default:
					return;
				case 3u:
					fields = new LuaField[7]
					{
						new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1083175575u), get_UsePbc, null),
						new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1734949790u), get_UseLpeg, null),
						new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4263701527u), get_UsePbLua, null),
						new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(347091998u), get_UseCJson, null),
						new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3481067997u), get_UseSproto, null),
						new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2771008269u), get_AutoWrapMode, null),
						new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3360242259u), get_uLuaPath, null)
					};
					num = ((int)num2 * -1534181201) ^ 0x16183355;
					continue;
				case 1u:
					LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1018729706u), _200B_206E_206A_202E_206E_206A_200B_206A_200B_206E_206F_202B_200F_200F_200B_206A_206C_202B_206F_202C_202A_200F_200D_206A_206D_200B_206F_206B_200E_202D_200D_202D_200F_206C_202E_200B_200D_202C_206A_206C_202E(typeof(AppConst).TypeHandle), regs, fields, _200B_206E_206A_202E_206E_206A_200B_206A_200B_206E_206F_202B_200F_200F_200B_206A_206C_202B_206F_202C_202A_200F_200D_206A_206D_200B_206F_206B_200E_202D_200D_202D_200F_206C_202E_200B_200D_202C_206A_206C_202E(typeof(object).TypeHandle));
					num = ((int)num2 * -1840636364) ^ 0x4EA193AB;
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _200E_200B_202C_200C_206D_206D_206D_206A_206D_202D_202C_202D_206E_206C_206F_206E_200E_206B_200F_202B_200C_200F_200F_202D_206C_206B_206A_200B_202B_200D_206E_202B_202B_206A_200B_200B_206A_200F_206E_206E_202E(IntPtr P_0)
	{
		int num = LuaDLL.lua_gettop(P_0);
		while (true)
		{
			int num2 = -1826671295;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -585476711)) % 6)
				{
				case 3u:
					break;
				case 0u:
					LuaDLL.luaL_error(P_0, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(991513483u));
					num2 = -233341130;
					continue;
				case 5u:
				{
					AppConst o = new AppConst();
					LuaScriptMgr.PushObject(P_0, o);
					num2 = (int)((num3 * 1949293253) ^ 0x7F093DAC);
					continue;
				}
				case 4u:
					return 1;
				case 2u:
				{
					int num4;
					int num5;
					if (num != 0)
					{
						num4 = 1426766919;
						num5 = num4;
					}
					else
					{
						num4 = 84434568;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 1226444911);
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
	private static int get_UsePbc(IntPtr L)
	{
		LuaScriptMgr.Push(L, b: true);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_UseLpeg(IntPtr L)
	{
		LuaScriptMgr.Push(L, b: true);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_UsePbLua(IntPtr L)
	{
		LuaScriptMgr.Push(L, b: true);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_UseCJson(IntPtr L)
	{
		LuaScriptMgr.Push(L, b: true);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_UseSproto(IntPtr L)
	{
		LuaScriptMgr.Push(L, b: true);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_AutoWrapMode(IntPtr L)
	{
		LuaScriptMgr.Push(L, b: true);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_uLuaPath(IntPtr L)
	{
		LuaScriptMgr.Push(L, AppConst.uLuaPath);
		return 1;
	}

	static Type _200B_206E_206A_202E_206E_206A_200B_206A_200B_206E_206F_202B_200F_200F_200B_206A_206C_202B_206F_202C_202A_200F_200D_206A_206D_200B_206F_206B_200E_202D_200D_202D_200F_206C_202E_200B_200D_202C_206A_206C_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
