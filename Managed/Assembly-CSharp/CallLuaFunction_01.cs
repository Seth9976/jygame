using LuaInterface;
using UnityEngine;

public class CallLuaFunction_01 : MonoBehaviour
{
	private string script = global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1816210885u);

	private void Start()
	{
		LuaState luaState = new LuaState();
		luaState.DoString(script);
		LuaFunction function = default(LuaFunction);
		object[] array = default(object[]);
		while (true)
		{
			int num = 459786841;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x547DA975)) % 5)
				{
				case 0u:
					break;
				default:
					return;
				case 3u:
					function = luaState.GetFunction(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2174445621u));
					num = (int)((num2 * 746680997) ^ 0x32E68C4F);
					continue;
				case 2u:
					array = function.Call(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4050900975u));
					num = ((int)num2 * -139227638) ^ -593199713;
					continue;
				case 1u:
					_200E_206C_200F_206D_202D_202A_206D_200B_200D_200B_206D_206F_202A_202C_200B_206D_202A_206A_200F_200E_202A_200D_206B_200C_206D_200B_200F_206B_206F_206C_206D_202A_202D_202C_202A_200C_202E_206F_200C_200C_202E(array[0]);
					num = (int)(num2 * 1461362016) ^ -1586472560;
					continue;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private void Update()
	{
	}

	static void _200E_206C_200F_206D_202D_202A_206D_200B_200D_200B_206D_206F_202A_202C_200B_206D_202A_206A_200F_200E_202A_200D_206B_200C_206D_200B_200F_206B_206F_206C_206D_202A_202D_202C_202A_200C_202E_206F_200C_200C_202E(object P_0)
	{
		MonoBehaviour.print(P_0);
	}
}
