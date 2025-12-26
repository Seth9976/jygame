using LuaInterface;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
	private void Start()
	{
		LuaState luaState = new LuaState();
		string chunk = default(string);
		while (true)
		{
			int num = 568319388;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0xC74CFF7)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0028;
				default:
					luaState.DoString(chunk);
					return;
				}
				break;
				IL_0028:
				chunk = global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3949797816u);
				num = (int)((num2 * 1074650967) ^ 0x5FA80E6);
			}
		}
	}

	private void Update()
	{
	}
}
