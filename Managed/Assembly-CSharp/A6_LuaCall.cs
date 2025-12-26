using LuaInterface;
using UnityEngine;

public class A6_LuaCall : MonoBehaviour
{
	private const string script = "\n        A6_LuaCall = luanet.import_type('A6_LuaCall')  \n\n        LuaClass = {}\n        LuaClass.__index = LuaClass\n\n        function LuaClass:New() \n            local self = {};   \n            setmetatable(self, LuaClass); \n            return self;    \n        end\n\n        function LuaClass:test() \n            A6_LuaCall.OnSharpCall(self, self.callback);\n        end\n\n        function LuaClass:callback()\n            print('test--->>>');\n        end\n\n        LuaClass:New():test();\n    ";

	private void Start()
	{
		LuaState luaState = new LuaState();
		luaState.DoString(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(366971684u));
	}

	public static void OnSharpCall(LuaTable self, LuaFunction func)
	{
		func.Call(self);
	}
}
