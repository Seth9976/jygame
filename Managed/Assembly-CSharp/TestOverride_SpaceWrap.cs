using System;
using LuaInterface;

public class TestOverride_SpaceWrap
{
	private static LuaMethod[] enums = new LuaMethod[2]
	{
		new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(186622783u), GetWorld),
		new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2966529941u), IntToEnum)
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4284779326u), _206B_202E_200F_206A_202A_200E_200C_206F_200D_206D_206F_206A_206F_206D_202E_206C_206C_200D_200D_200F_200F_202D_202C_202B_200B_206C_206F_200E_206D_200C_200D_206F_200C_202E_206E_200B_206C_202B_202E_202D_202E(typeof(TestOverride.Space).TypeHandle), enums);
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetWorld(IntPtr L)
	{
		LuaScriptMgr.Push(L, (Enum)TestOverride.Space.World);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int IntToEnum(IntPtr L)
	{
		int num = (int)LuaDLL.lua_tonumber(L, 1);
		TestOverride.Space space = default(TestOverride.Space);
		while (true)
		{
			int num2 = -781349821;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1330956543)) % 4)
				{
				case 0u:
					break;
				case 2u:
					space = (TestOverride.Space)num;
					num2 = (int)((num3 * 2119923747) ^ 0x649373D6);
					continue;
				case 1u:
					LuaScriptMgr.Push(L, (Enum)space);
					num2 = ((int)num3 * -1586927617) ^ 0x146A535D;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	static Type _206B_202E_200F_206A_202A_200E_200C_206F_200D_206D_206F_206A_206F_206D_202E_206C_206C_200D_200D_200F_200F_202D_202C_202B_200B_206C_206F_200E_206D_200C_200D_206F_200C_202E_206E_200B_206C_202B_202E_202D_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
