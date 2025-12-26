using LuaInterface;
using UnityEngine;

public class LuaArray : MonoBehaviour
{
	private string source = global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1065588596u);

	private string[] objs = new string[3]
	{
		global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(79688401u),
		global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1887029314u),
		global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3630272515u)
	};

	private void Start()
	{
		LuaScriptMgr luaScriptMgr = new LuaScriptMgr();
		luaScriptMgr.Start();
		object[] array2 = default(object[]);
		LuaFunction function = default(LuaFunction);
		LuaState lua = default(LuaState);
		object obj = default(object);
		object[] array = default(object[]);
		int num3 = default(int);
		while (true)
		{
			int num = -7110871;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -260550786)) % 12)
				{
				case 2u:
					break;
				default:
					return;
				case 6u:
					array2 = function.Call(objs, objs.Length);
					function.Release();
					num = ((int)num2 * -548168659) ^ -226191644;
					continue;
				case 4u:
					lua.DoString(source);
					num = (int)(num2 * 1746499243) ^ -835162748;
					continue;
				case 5u:
					obj = array[num3];
					num = -13449569;
					continue;
				case 7u:
					lua = luaScriptMgr.lua;
					num = (int)(num2 * 2012280713) ^ -997488059;
					continue;
				case 8u:
					array = array2;
					num = ((int)num2 * -1711472611) ^ 0x343E9ADA;
					continue;
				case 10u:
					function = lua.GetFunction(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2174445621u));
					num = (int)(num2 * 1315858952) ^ -1705870244;
					continue;
				case 3u:
				{
					int num4;
					if (num3 < array.Length)
					{
						num = -936860649;
						num4 = num;
					}
					else
					{
						num = -1051774783;
						num4 = num;
					}
					continue;
				}
				case 9u:
					num3++;
					num = (int)((num2 * 910484441) ^ 0x4922ECC);
					continue;
				case 1u:
					_202D_200E_200F_206A_206F_206E_202A_202E_202B_200D_202A_202B_202A_206B_202B_206F_202A_200D_206B_200E_200F_206B_200F_200D_200C_202E_202E_200B_206C_206B_200E_206A_206C_200F_200B_202C_206C_200B_206C_202E((object)_202E_202B_202B_200D_200F_200D_206E_202A_206E_200B_200F_202D_200B_206A_200E_202B_202B_206C_206D_206A_206E_202E_206D_206E_200D_202C_202E_200E_200B_206D_200C_206B_200D_200E_206C_206A_200B_206F_202D_206D_202E(obj));
					num = (int)(num2 * 1734413795) ^ -2053432308;
					continue;
				case 0u:
					num3 = 0;
					num = (int)(num2 * 1826690208) ^ -2109353723;
					continue;
				case 11u:
					return;
				}
				break;
			}
		}
	}

	static string _202E_202B_202B_200D_200F_200D_206E_202A_206E_200B_200F_202D_200B_206A_200E_202B_202B_206C_206D_206A_206E_202E_206D_206E_200D_202C_202E_200E_200B_206D_200C_206B_200D_200E_206C_206A_200B_206F_202D_206D_202E(object P_0)
	{
		return P_0.ToString();
	}

	static void _202D_200E_200F_206A_206F_206E_202A_202E_202B_200D_202A_202B_202A_206B_202B_206F_202A_200D_206B_200E_200F_206B_200F_200D_200C_202E_202E_200B_206C_206B_200E_206A_206C_200F_200B_202C_206C_200B_206C_202E(object P_0)
	{
		Debug.Log(P_0);
	}
}
