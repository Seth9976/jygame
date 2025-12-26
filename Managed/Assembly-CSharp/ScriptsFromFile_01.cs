using LuaInterface;
using UnityEngine;

public class ScriptsFromFile_01 : MonoBehaviour
{
	public TextAsset scriptFile;

	private void Start()
	{
		LuaState luaState = new LuaState();
		luaState.DoString(_206C_200C_200B_206C_200C_200E_202E_202E_200B_202D_202C_200C_200C_206D_206F_206F_202C_202B_206A_206B_200B_206E_202C_200E_206C_206F_200C_200E_206B_202A_200E_200F_202E_200D_206D_206E_202C_206E_200B_206B_202E(scriptFile));
	}

	private void Update()
	{
	}

	static string _206C_200C_200B_206C_200C_200E_202E_202E_200B_202D_202C_200C_200C_206D_206F_206F_202C_202B_206A_206B_200B_206E_202C_200E_206C_206F_200C_200E_206B_202A_200E_200F_202E_200D_206D_206E_202C_206E_200B_206B_202E(TextAsset P_0)
	{
		return P_0.text;
	}
}
