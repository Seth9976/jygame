using LuaInterface;
using UnityEngine;

public class LuaProtoBuffer01 : MonoBehaviour
{
	private string script = global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1740439059u);

	private void Start()
	{
		LuaScriptMgr luaScriptMgr = new LuaScriptMgr();
		luaScriptMgr.Start();
		TestProtolWrap.Register(luaScriptMgr.GetL());
		LuaFunction luaFunction = default(LuaFunction);
		while (true)
		{
			int num = 473805836;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2A991D01)) % 8)
				{
				case 2u:
					break;
				default:
					return;
				case 6u:
					luaFunction.Release();
					num = (int)(num2 * 563322629) ^ -793999608;
					continue;
				case 0u:
					luaFunction.Call();
					num = (int)(num2 * 685487449) ^ -2105610523;
					continue;
				case 5u:
					luaScriptMgr.DoFile(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3416956461u));
					luaScriptMgr.DoString(script);
					luaFunction = luaScriptMgr.GetLuaFunction(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3094039083u));
					num = ((int)num2 * -1961378460) ^ 0x2F273025;
					continue;
				case 4u:
					luaFunction.Release();
					num = ((int)num2 * -1866002493) ^ 0x7D6B59C4;
					continue;
				case 1u:
					luaFunction = luaScriptMgr.GetLuaFunction(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(752526530u));
					num = ((int)num2 * -1496073567) ^ 0x20CFCD3B;
					continue;
				case 3u:
					luaFunction.Call();
					num = ((int)num2 * -1753685365) ^ -603785482;
					continue;
				case 7u:
					return;
				}
				break;
			}
		}
	}
}
