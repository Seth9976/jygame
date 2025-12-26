using LuaInterface;
using UnityEngine;

public class ScriptsFromFile_02 : MonoBehaviour
{
	private void Start()
	{
		LuaState luaState = new LuaState();
		string fileName = default(string);
		while (true)
		{
			int num = 1030684577;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3B6B9022)) % 4)
				{
				case 0u:
					break;
				default:
					return;
				case 3u:
					fileName = _200B_202C_206C_202E_200F_200F_206B_206E_200E_200E_206B_202D_206E_206B_206F_200B_206F_200C_206B_206A_200B_206B_206E_206D_206F_200D_202B_200F_206D_206D_202A_206F_206A_206E_202E_202B_200C_202E_202A_200F_202E(_206A_206C_202B_206D_206A_202C_202E_200E_206D_206E_200B_206C_202A_202A_206A_202E_206C_200B_206C_206A_200C_202A_206E_200C_200B_206B_200B_200D_206C_206B_202A_206B_206A_202D_200F_206E_202C_206A_206D_206B_202E(), global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(369987096u));
					num = (int)(num2 * 1469417240) ^ -893619720;
					continue;
				case 2u:
					luaState.DoFile(fileName);
					num = (int)(num2 * 1187483357) ^ -1141000451;
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private void Update()
	{
	}

	static string _206A_206C_202B_206D_206A_202C_202E_200E_206D_206E_200B_206C_202A_202A_206A_202E_206C_200B_206C_206A_200C_202A_206E_200C_200B_206B_200B_200D_206C_206B_202A_206B_206A_202D_200F_206E_202C_206A_206D_206B_202E()
	{
		return Application.dataPath;
	}

	static string _200B_202C_206C_202E_200F_200F_206B_206E_200E_200E_206B_202D_206E_206B_206F_200B_206F_200C_206B_206A_200B_206B_206E_206D_206F_200D_202B_200F_206D_206D_202A_206F_206A_206E_202E_202B_200C_202E_202A_200F_202E(string P_0, string P_1)
	{
		return P_0 + P_1;
	}
}
