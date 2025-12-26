using LuaInterface;
using UnityEngine;

public class TestOverride01 : MonoBehaviour
{
	private string script = global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(211779299u);

	private void Start()
	{
		LuaScriptMgr luaScriptMgr = new LuaScriptMgr();
		TestOverride testOverride = default(TestOverride);
		LuaFunction luaFunction = default(LuaFunction);
		while (true)
		{
			int num = 1743007936;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x41806568)) % 7)
				{
				case 0u:
					break;
				default:
					return;
				case 5u:
					luaScriptMgr.DoString(script);
					testOverride = new TestOverride();
					num = ((int)num2 * -1110783641) ^ 0x406532F0;
					continue;
				case 2u:
					TestOverride_SpaceWrap.Register(luaScriptMgr.GetL());
					num = (int)(num2 * 455264297) ^ -976717966;
					continue;
				case 4u:
					luaScriptMgr.Start();
					TestOverrideWrap.Register(luaScriptMgr.GetL());
					num = ((int)num2 * -324053518) ^ 0x6F66694F;
					continue;
				case 3u:
					luaFunction.Call(testOverride);
					num = (int)((num2 * 43241191) ^ 0x1B4E8F94);
					continue;
				case 6u:
					luaFunction = luaScriptMgr.GetLuaFunction(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1872944159u));
					num = (int)((num2 * 1913463181) ^ 0x341105DC);
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
	}
}
