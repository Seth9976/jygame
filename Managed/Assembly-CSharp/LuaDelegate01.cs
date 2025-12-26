using LuaInterface;
using UnityEngine;

public class LuaDelegate01 : MonoBehaviour
{
	private const string script = "\n        local func1 = function() print('测试委托1'); end\n        local func2 = function(gameObj) print('测试委托2:>'..gameObj.name); end        \n        \n        function testDelegate(go) \n            local ev = go:AddComponent(TestDelegateListener.GetClassType());\n        \n            ---直接赋值模式---\n            ev.onClick = func1;\n\n            ---C#的加减模式---\n            local delegate = DelegateFactory.TestLuaDelegate_VoidDelegate(func2);\n            ev.onEvClick = ev.onEvClick + delegate;\n            --ev.onEvClick = ev.onEvClick - delegate;\n        end\n    ";

	private void Start()
	{
		LuaScriptMgr luaScriptMgr = new LuaScriptMgr();
		LuaFunction luaFunction = default(LuaFunction);
		while (true)
		{
			int num = -1030451068;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1682428521)) % 6)
				{
				case 0u:
					break;
				default:
					return;
				case 5u:
					luaScriptMgr.Start();
					num = ((int)num2 * -1365812409) ^ -1756482019;
					continue;
				case 4u:
					luaFunction.Call(_200F_206C_200D_206C_202E_206A_200F_206F_206D_200B_206D_202B_206A_206F_206C_200D_206A_202B_206E_200F_200E_206B_206B_206C_200B_206C_206F_202D_206F_202D_202E_200E_202D_206D_200F_200D_206D_206E_206F_206E_202E((Component)(object)this));
					num = ((int)num2 * -173173077) ^ 0x6665143;
					continue;
				case 3u:
					luaFunction = luaScriptMgr.GetLuaFunction(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3804326238u));
					num = ((int)num2 * -182096864) ^ 0x5198AB13;
					continue;
				case 1u:
					luaScriptMgr.DoString(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(931967163u));
					num = ((int)num2 * -2078726875) ^ 0x33C30EB3;
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	static GameObject _200F_206C_200D_206C_202E_206A_200F_206F_206D_200B_206D_202B_206A_206F_206C_200D_206A_202B_206E_200F_200E_206B_206B_206C_200B_206C_206F_202D_206F_202D_202E_200E_202D_206D_200F_200D_206D_206E_206F_206E_202E(Component P_0)
	{
		return P_0.gameObject;
	}
}
