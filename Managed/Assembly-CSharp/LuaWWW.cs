using UnityEngine;

public class LuaWWW : MonoBehaviour
{
	private LuaScriptMgr lua;

	private string script = global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3562835050u);

	private void Start()
	{
		lua = new LuaScriptMgr();
		while (true)
		{
			int num = -1341168965;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1137796374)) % 4)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					lua.Start();
					num = ((int)num2 * -1340729340) ^ -477298840;
					continue;
				case 2u:
					lua.DoString(script);
					num = (int)((num2 * 397304061) ^ 0x4D59A417);
					continue;
				case 3u:
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
