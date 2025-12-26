using System;
using LuaInterface;
using UnityEngine;

public class CallLuaFunction_02 : MonoBehaviour
{
	private string script = global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1097774551u);

	private LuaFunction func;

	private void Start()
	{
		LuaScriptMgr luaScriptMgr = new LuaScriptMgr();
		int num3 = default(int);
		object[] array = default(object[]);
		while (true)
		{
			int num = -1764562406;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1322448517)) % 8)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					luaScriptMgr.DoString(script);
					num = ((int)num2 * -59570591) ^ 0x783EEEE6;
					continue;
				case 2u:
					_206F_200C_202A_202A_200F_200F_206F_206C_206F_206C_202A_202A_206B_202A_202C_202B_200E_206A_200F_206F_200E_202E_206E_202A_200D_200D_206C_200B_200F_202C_206A_202A_200F_206F_200D_206B_206E_202A_202E_200E_202E((object)num3);
					num = ((int)num2 * -592253891) ^ 0x7A6D2827;
					continue;
				case 5u:
					array = func.Call(123456.0);
					num = ((int)num2 * -577267589) ^ -1442074649;
					continue;
				case 3u:
					_206F_200C_202A_202A_200F_200F_206F_206C_206F_206C_202A_202A_206B_202A_202C_202B_200E_206A_200F_206F_200E_202E_206E_202A_200D_200D_206C_200B_200F_202C_206A_202A_200F_206F_200D_206B_206E_202A_202E_200E_202E(array[0]);
					num = ((int)num2 * -1372908978) ^ 0x655C0DE6;
					continue;
				case 4u:
					func = luaScriptMgr.GetLuaFunction(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2174445621u));
					num = ((int)num2 * -902151098) ^ -968494034;
					continue;
				case 7u:
					num3 = CallFunc();
					num = (int)((num2 * 1866511144) ^ 0x6B3C79C9);
					continue;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	private void OnDestroy()
	{
		if (func == null)
		{
			return;
		}
		while (true)
		{
			int num = 1838457867;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x58F4C123)) % 3)
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
				func.Release();
				num = ((int)num2 * -1369022109) ^ -613536891;
			}
		}
	}

	private int CallFunc()
	{
		int oldTop = func.BeginPCall();
		IntPtr luaState = default(IntPtr);
		int result = default(int);
		while (true)
		{
			int num = -1544819586;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1143671269)) % 5)
				{
				case 2u:
					break;
				case 0u:
					func.EndPCall(oldTop);
					num = ((int)num2 * -969010159) ^ 0x70155183;
					continue;
				case 3u:
					LuaScriptMgr.Push(luaState, 123456);
					func.PCall(oldTop, 1);
					result = (int)LuaScriptMgr.GetNumber(luaState, -1);
					num = (int)(num2 * 737207299) ^ -129445675;
					continue;
				case 4u:
					luaState = func.GetLuaState();
					num = (int)(num2 * 1352235614) ^ -1136250350;
					continue;
				default:
					return result;
				}
				break;
			}
		}
	}

	private void Update()
	{
	}

	static void _206F_200C_202A_202A_200F_200F_206F_206C_206F_206C_202A_202A_206B_202A_202C_202B_200E_206A_200F_206F_200E_202E_206E_202A_200D_200D_206C_200B_200F_202C_206A_202A_200F_206F_200D_206B_206E_202A_202E_200E_202E(object P_0)
	{
		MonoBehaviour.print(P_0);
	}
}
