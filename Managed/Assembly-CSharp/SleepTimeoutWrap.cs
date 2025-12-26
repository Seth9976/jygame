using System;
using LuaInterface;
using UnityEngine;

public class SleepTimeoutWrap
{
	private static Type classType = _200B_206A_202D_202C_202A_200B_206D_200F_202B_200F_202C_200C_206C_206B_206E_202A_206A_206B_202E_200B_202C_200F_206E_202C_202C_202C_202E_206E_200D_202C_200B_200D_202C_200C_206F_206D_200B_206B_200D_206F_202E(typeof(SleepTimeout).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[2]
		{
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2705981273u), _206D_202C_206E_200C_206B_202B_200D_202D_200C_202C_202E_202B_206D_206D_200C_200D_200D_206A_200C_206E_202C_206F_202E_200B_206B_200B_202C_202E_206F_202C_206E_200C_202C_202A_206B_206E_206A_206E_206A_206D_202E),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(10103728u), GetClassType)
		};
		LuaField[] fields = default(LuaField[]);
		while (true)
		{
			int num = -1294433099;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1805765374)) % 4)
				{
				case 0u:
					break;
				default:
					return;
				case 3u:
					fields = new LuaField[2]
					{
						new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1511674981u), get_NeverSleep, null),
						new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(627847581u), get_SystemSetting, null)
					};
					num = (int)((num2 * 2098244971) ^ 0x38B7B692);
					continue;
				case 1u:
					LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4284675761u), _200B_206A_202D_202C_202A_200B_206D_200F_202B_200F_202C_200C_206C_206B_206E_202A_206A_206B_202E_200B_202C_200F_206E_202C_202C_202C_202E_206E_200D_202C_200B_200D_202C_200C_206F_206D_200B_206B_200D_206F_202E(typeof(SleepTimeout).TypeHandle), regs, fields, _200B_206A_202D_202C_202A_200B_206D_200F_202B_200F_202C_200C_206C_206B_206E_202A_206A_206B_202E_200B_202C_200F_206E_202C_202C_202C_202E_206E_200D_202C_200B_200D_202C_200C_206F_206D_200B_206B_200D_206F_202E(typeof(object).TypeHandle));
					num = ((int)num2 * -1027528523) ^ -2125846795;
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _206D_202C_206E_200C_206B_202B_200D_202D_200C_202C_202E_202B_206D_206D_200C_200D_200D_206A_200C_206E_202C_206F_202E_200B_206B_200B_202C_202E_206F_202C_206E_200C_202C_202A_206B_206E_206A_206E_206A_206D_202E(IntPtr P_0)
	{
		int num = LuaDLL.lua_gettop(P_0);
		SleepTimeout o = default(SleepTimeout);
		while (true)
		{
			int num2 = -29022025;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -200358576)) % 6)
				{
				case 0u:
					break;
				case 4u:
					return 1;
				case 5u:
					o = _206C_206F_200E_206E_202D_206F_206E_206B_206C_200F_206E_206F_200D_200C_206E_200B_200B_202E_202B_206C_200B_200C_206F_202A_206F_206D_202E_202C_202E_200B_200E_206E_206A_202D_202E_200F_202C_202B_206B_200D_202E();
					num2 = ((int)num3 * -1374160083) ^ -1166080702;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (num == 0)
					{
						num4 = 1900838279;
						num5 = num4;
					}
					else
					{
						num4 = 576650288;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num3 * -693794524);
					continue;
				}
				case 3u:
					LuaScriptMgr.PushObject(P_0, o);
					num2 = (int)(num3 * 1249986893) ^ -668874559;
					continue;
				default:
					LuaDLL.luaL_error(P_0, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(530371349u));
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
	private static int get_NeverSleep(IntPtr L)
	{
		LuaScriptMgr.Push(L, -1);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_SystemSetting(IntPtr L)
	{
		LuaScriptMgr.Push(L, -2);
		return 1;
	}

	static Type _200B_206A_202D_202C_202A_200B_206D_200F_202B_200F_202C_200C_206C_206B_206E_202A_206A_206B_202E_200B_202C_200F_206E_202C_202C_202C_202E_206E_200D_202C_200B_200D_202C_200C_206F_206D_200B_206B_200D_206F_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static SleepTimeout _206C_206F_200E_206E_202D_206F_206E_206B_206C_200F_206E_206F_200D_200C_206E_200B_200B_202E_202B_206C_200B_200C_206F_202A_206F_206D_202E_202C_202E_200B_200E_206E_206A_202D_202E_200F_202C_202B_206B_200D_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new SleepTimeout();
	}
}
