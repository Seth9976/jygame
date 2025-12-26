using LuaInterface;
using UnityEngine;

public class CreateGameObject01 : MonoBehaviour
{
	private string script = global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3956784170u);

	private void Start()
	{
		LuaState luaState = new LuaState();
		luaState.DoString(script);
	}

	private void Update()
	{
	}
}
