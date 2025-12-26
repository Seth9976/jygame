using UnityEngine;

public class LuaClass : MonoBehaviour
{
	private const string source = "\n        Account = { balance = 0 };\n        \n        function Account:new(o)    \n            o = o or {};\n            setmetatable(o, { __index = self });     \n            return o;  \n        end  \n  \n        function Account.deposit(self, v)  \n            self.balance = self.balance + v;  \n        end  \n  \n        function Account:withdraw(v)  \n            if (v) > self.balance then error 'insufficient funds'; end  \n            self.balance = self.balance - v;  \n        end \n\n        SpecialAccount = Account:new();\n\n        function SpecialAccount:withdraw(v)  \n            if v - self.balance >= self:getLimit() then  \n                error 'insufficient funds';  \n            end  \n            self.balance = self.balance - v;  \n        end  \n  \n        function SpecialAccount.getLimit(self)  \n            return self.limit or 0;  \n        end  \n\n        s = SpecialAccount:new{ limit = 1000 };\n        print(s.balance);  \n        s:deposit(100.00);\n\n        print (s.limit);  \n        print (s.getLimit(s))  \n        print (s.balance)  \n    ";

	private void Start()
	{
		LuaScriptMgr luaScriptMgr = new LuaScriptMgr();
		luaScriptMgr.Start();
		while (true)
		{
			int num = -362101288;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1446443717)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_002e;
				case 2u:
					return;
				}
				break;
				IL_002e:
				luaScriptMgr.lua.DoString(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1958021785u));
				num = ((int)num2 * -415088278) ^ -1990240304;
			}
		}
	}

	private void Update()
	{
	}
}
