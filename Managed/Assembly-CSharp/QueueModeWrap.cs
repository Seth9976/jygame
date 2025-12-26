using System;
using LuaInterface;
using UnityEngine;

public class QueueModeWrap
{
	private static LuaMethod[] enums = new LuaMethod[3]
	{
		new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(376748313u), GetCompleteOthers),
		new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2098561515u), GetPlayNow),
		new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2966529941u), IntToEnum)
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2995160751u), _202C_206D_206C_202B_206A_206A_202A_206B_206F_200E_200C_202E_206C_200E_206D_206B_202B_200D_202A_206A_200C_206F_202A_206E_202B_206D_202B_206F_206B_206C_206F_202B_206E_206C_200D_206B_200D_202A_206C_206B_202E(typeof(QueueMode).TypeHandle), enums);
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetCompleteOthers(IntPtr L)
	{
		LuaScriptMgr.Push(L, (Enum)(object)(QueueMode)0);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetPlayNow(IntPtr L)
	{
		LuaScriptMgr.Push(L, (Enum)(object)(QueueMode)2);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int IntToEnum(IntPtr L)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		int num = (int)LuaDLL.lua_tonumber(L, 1);
		QueueMode val = default(QueueMode);
		while (true)
		{
			int num2 = 2110422900;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x687070BA)) % 4)
				{
				case 3u:
					break;
				case 2u:
					val = (QueueMode)num;
					num2 = (int)((num3 * 1224764937) ^ 0x486F9999);
					continue;
				case 1u:
					LuaScriptMgr.Push(L, (Enum)(object)val);
					num2 = (int)(num3 * 1350008017) ^ -2068735417;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	static Type _202C_206D_206C_202B_206A_206A_202A_206B_206F_200E_200C_202E_206C_200E_206D_206B_202B_200D_202A_206A_200C_206F_202A_206E_202B_206D_202B_206F_206B_206C_206F_202B_206E_206C_200D_206B_200D_202A_206C_206B_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
