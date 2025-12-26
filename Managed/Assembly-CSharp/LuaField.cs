using LuaInterface;

public struct LuaField
{
	public string name;

	public LuaCSFunction getter;

	public LuaCSFunction setter;

	public LuaField(string P_0, LuaCSFunction P_1, LuaCSFunction P_2)
	{
		name = P_0;
		getter = P_1;
		setter = P_2;
	}
}
