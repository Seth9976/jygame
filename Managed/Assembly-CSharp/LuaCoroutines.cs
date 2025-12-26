using LuaInterface;
using UnityEngine;

public class LuaCoroutines : MonoBehaviour
{
	private string script = global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4022612635u);

	private LuaScriptMgr lua;

	private void Awake()
	{
		lua = new LuaScriptMgr();
		LuaFunction luaFunction = default(LuaFunction);
		while (true)
		{
			int num = 413947716;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x40AC9E22)) % 4)
				{
				case 0u:
					break;
				case 2u:
					lua.Start();
					lua.DoString(script);
					num = (int)((num2 * 109483816) ^ 0x52FC7991);
					continue;
				case 3u:
					luaFunction = lua.GetLuaFunction(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3064942505u));
					num = (int)(num2 * 1519507477) ^ -955402340;
					continue;
				default:
					luaFunction.Call();
					luaFunction.Release();
					return;
				}
				break;
			}
		}
	}

	private void Update()
	{
		lua.Update();
	}

	private void LateUpdate()
	{
		lua.LateUpate();
	}

	private void FixedUpdate()
	{
		lua.FixedUpdate();
	}
}
