namespace LuaInterface;

internal sealed class LuaIndexes
{
	public static int LUA_REGISTRYINDEX = -10000;

	public static int LUA_ENVIRONINDEX;

	public static int LUA_GLOBALSINDEX;

	static LuaIndexes()
	{
		while (true)
		{
			int num = 908595089;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x566DBF5F)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_002c;
				default:
					LUA_GLOBALSINDEX = -10002;
					return;
				}
				break;
				IL_002c:
				LUA_ENVIRONINDEX = -10001;
				num = ((int)num2 * -62061991) ^ -2011288100;
			}
		}
	}
}
