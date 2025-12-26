using LuaInterface;
using UnityEngine;

public class LuaDelegate02 : MonoBehaviour
{
	private string script = global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3512055904u);

	private void Start()
	{
		LuaScriptMgr luaScriptMgr = new LuaScriptMgr();
		luaScriptMgr.Start();
		LuaFunction luaFunction = default(LuaFunction);
		TestEventListener testEventListener = default(TestEventListener);
		while (true)
		{
			int num = -1683252427;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1840163731)) % 9)
				{
				case 0u:
					break;
				case 5u:
					luaFunction = luaScriptMgr.GetLuaFunction(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2436516467u));
					num = ((int)num2 * -1877591123) ^ 0x15A4BF62;
					continue;
				case 3u:
					testEventListener = _200E_206D_206E_200E_202D_206B_202D_206E_202E_206E_206F_200B_200B_206B_200B_202A_206C_206C_200C_202E_202C_206C_206B_202A_206E_206D_200C_200C_200F_200D_200B_206F_200E_200E_202D_206A_200C_200C_200C_206C_202E((Component)(object)this).AddComponent<TestEventListener>();
					num = ((int)num2 * -1374057923) ^ 0x5903A380;
					continue;
				case 6u:
					luaFunction.Call(testEventListener);
					testEventListener.OnClick(_200E_206D_206E_200E_202D_206B_202D_206E_202E_206E_206F_200B_200B_206B_200B_202A_206C_206C_200C_202E_202C_206C_206B_202A_206E_206D_200C_200C_200F_200D_200B_206F_200E_200E_202D_206A_200C_200C_200C_206C_202E((Component)(object)this));
					num = (int)(num2 * 1708135070) ^ -770325543;
					continue;
				case 2u:
					luaScriptMgr.DoString(script);
					num = ((int)num2 * -549796539) ^ -339085905;
					continue;
				case 4u:
					luaFunction.Release();
					num = ((int)num2 * -1588560059) ^ -2138611067;
					continue;
				case 7u:
					_202C_206E_206B_206B_200C_202C_206B_202A_200C_202A_206F_200E_202A_206B_200B_206A_200D_206B_206A_206E_206B_206C_206E_202D_200F_200C_202B_200F_206B_200C_206D_202C_206C_206D_202E_202C_202A_206C_200B_200C_202E((object)global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4257919375u));
					luaFunction = luaScriptMgr.GetLuaFunction(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1857707298u));
					num = ((int)num2 * -957483923) ^ -1912998019;
					continue;
				case 1u:
					luaFunction.Call(testEventListener);
					testEventListener.OnClick(_200E_206D_206E_200E_202D_206B_202D_206E_202E_206E_206F_200B_200B_206B_200B_202A_206C_206C_200C_202E_202C_206C_206B_202A_206E_206D_200C_200C_200F_200D_200B_206F_200E_200E_202D_206A_200C_200C_200C_206C_202E((Component)(object)this));
					num = ((int)num2 * -1220434878) ^ -2060845380;
					continue;
				default:
					luaFunction.Release();
					return;
				}
				break;
			}
		}
	}

	static GameObject _200E_206D_206E_200E_202D_206B_202D_206E_202E_206E_206F_200B_200B_206B_200B_202A_206C_206C_200C_202E_202C_206C_206B_202A_206E_206D_200C_200C_200F_200D_200B_206F_200E_200E_202D_206A_200C_200C_200C_206C_202E(Component P_0)
	{
		return P_0.gameObject;
	}

	static void _202C_206E_206B_206B_200C_202C_206B_202A_200C_202A_206F_200E_202A_206B_200B_206A_200D_206B_206A_206E_206B_206C_206E_202D_200F_200C_202B_200F_206B_200C_206D_202C_206C_206D_202E_202C_202A_206C_200B_200C_202E(object P_0)
	{
		Debug.Log(P_0);
	}
}
