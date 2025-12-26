using LuaInterface;
using UnityEngine;

public class TestLuaArray : MonoBehaviour
{
	private string script = global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1357488141u);

	private string[] objs = new string[3]
	{
		global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1130313780u),
		global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(287637204u),
		global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3911850008u)
	};

	private void Start()
	{
		LuaScriptMgr luaScriptMgr = new LuaScriptMgr();
		int num3 = default(int);
		object[] array = default(object[]);
		LuaFunction luaFunction = default(LuaFunction);
		while (true)
		{
			int num = -1247866362;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1188943575)) % 11)
				{
				case 6u:
					break;
				default:
					return;
				case 10u:
					num3 = 0;
					num = (int)((num2 * 1088837653) ^ 0x4B7E85C1);
					continue;
				case 3u:
					luaScriptMgr.DoString(script);
					num = (int)((num2 * 1034137307) ^ 0x29B4DC83);
					continue;
				case 8u:
					_206C_200F_200C_202E_200B_206E_202C_206B_206D_200E_200F_202C_206E_206C_200E_200B_200C_206D_202B_200B_200E_202C_206C_206E_200E_200E_200D_202C_206E_206F_202E_200B_202B_200B_206D_206B_206C_206F_202B_206C_202E((object)_200C_206C_202D_202E_206D_202B_206E_200B_206D_206E_202E_206C_206D_200F_206F_206C_202C_200D_206A_206A_206D_206F_200E_200F_200E_200C_206D_202B_200F_200F_200F_206C_200D_200B_206A_206F_206A_206A_200D_206B_202E(array[num3]));
					num3++;
					num = -1409017826;
					continue;
				case 5u:
					luaScriptMgr.Start();
					num = (int)((num2 * 1531509518) ^ 0x792765A2);
					continue;
				case 7u:
					num = ((int)num2 * -1959787600) ^ 0x35E3C1CE;
					continue;
				case 0u:
				{
					int num4;
					if (num3 < objs.Length)
					{
						num = -1226400197;
						num4 = num;
					}
					else
					{
						num = -494654350;
						num4 = num;
					}
					continue;
				}
				case 1u:
					array = luaFunction.Call(new object[1] { objs });
					num = ((int)num2 * -134029014) ^ 0x54ABC1A;
					continue;
				case 2u:
					luaFunction = luaScriptMgr.GetLuaFunction(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(246006673u));
					num = ((int)num2 * -1218112971) ^ -1471039805;
					continue;
				case 4u:
					luaFunction.Release();
					num = (int)(num2 * 1917888846) ^ -1695833348;
					continue;
				case 9u:
					return;
				}
				break;
			}
		}
	}

	static string _200C_206C_202D_202E_206D_202B_206E_200B_206D_206E_202E_206C_206D_200F_206F_206C_202C_200D_206A_206A_206D_206F_200E_200F_200E_200C_206D_202B_200F_200F_200F_206C_200D_200B_206A_206F_206A_206A_200D_206B_202E(object P_0)
	{
		return P_0.ToString();
	}

	static void _206C_200F_200C_202E_200B_206E_202C_206B_206D_200E_200F_202C_206E_206C_200E_200B_200C_206D_202B_200B_200E_202C_206C_206E_200E_200E_200D_202C_206E_206F_202E_200B_202B_200B_206D_206B_206C_206F_202B_206C_202E(object P_0)
	{
		Debug.Log(P_0);
	}
}
