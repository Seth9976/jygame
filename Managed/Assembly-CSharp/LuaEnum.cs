using UnityEngine;

public class LuaEnum : MonoBehaviour
{
	private const string source = "\n        local type = LuaEnumType.IntToEnum(1);\n        print(type == LuaEnumType.AAA);\n    ";

	private void Start()
	{
		LuaScriptMgr luaScriptMgr = new LuaScriptMgr();
		while (true)
		{
			int num = -20072912;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1784993063)) % 4)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					luaScriptMgr.Start();
					num = (int)((num2 * 1616290902) ^ 0x1A4F885B);
					continue;
				case 0u:
					luaScriptMgr.lua.DoString(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1904916863u));
					num = ((int)num2 * -830256865) ^ 0x201EDCDE;
					continue;
				case 3u:
					return;
				}
				break;
			}
		}
	}
}
