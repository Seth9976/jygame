using System;
using LuaInterface;
using UnityEngine;

public class BlendWeightsWrap
{
	private static LuaMethod[] enums = new LuaMethod[4]
	{
		new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2871598569u), GetOneBone),
		new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2022813282u), GetTwoBones),
		new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3368708998u), GetFourBones),
		new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3844796435u), IntToEnum)
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1869557127u), _206E_202B_200F_206C_200E_202A_206A_206E_206D_200E_202E_202D_200F_202B_206E_206C_200B_206C_200D_202C_200C_202B_206A_202B_200B_202C_206D_206A_206D_206B_206E_206E_206D_206B_202B_206C_206D_200F_200C_202C_202E(typeof(BlendWeights).TypeHandle), enums);
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetOneBone(IntPtr L)
	{
		LuaScriptMgr.Push(L, (Enum)(object)(BlendWeights)1);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetTwoBones(IntPtr L)
	{
		LuaScriptMgr.Push(L, (Enum)(object)(BlendWeights)2);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetFourBones(IntPtr L)
	{
		LuaScriptMgr.Push(L, (Enum)(object)(BlendWeights)4);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int IntToEnum(IntPtr L)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		int num = (int)LuaDLL.lua_tonumber(L, 1);
		BlendWeights val = default(BlendWeights);
		while (true)
		{
			int num2 = -1998991969;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1379082225)) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_002b;
				default:
					LuaScriptMgr.Push(L, (Enum)(object)val);
					return 1;
				}
				break;
				IL_002b:
				val = (BlendWeights)num;
				num2 = ((int)num3 * -1477989804) ^ -405643084;
			}
		}
	}

	static Type _206E_202B_200F_206C_200E_202A_206A_206E_206D_200E_202E_202D_200F_202B_206E_206C_200B_206C_200D_202C_200C_202B_206A_202B_200B_202C_206D_206A_206D_206B_206E_206E_206D_206B_202B_206C_206D_200F_200C_202C_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
