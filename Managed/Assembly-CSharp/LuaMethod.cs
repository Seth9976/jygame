using LuaInterface;

public struct LuaMethod
{
	public string name;

	public LuaCSFunction func;

	public LuaMethod(string P_0, LuaCSFunction P_1)
	{
		name = P_0;
		func = P_1;
	}
}
