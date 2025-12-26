using System;

namespace LuaInterface;

public class LuaClassHelper
{
	public static LuaFunction getTableFunction(LuaTable luaTable, string name)
	{
		object obj = luaTable.rawget(name);
		if (obj is LuaFunction)
		{
			while (true)
			{
				uint num;
				switch ((num = 1734867664u) % 3)
				{
				case 2u:
					continue;
				case 1u:
					return (LuaFunction)obj;
				}
				break;
			}
		}
		return null;
	}

	public static object callFunction(LuaFunction function, object[] args, Type[] returnTypes, object[] inArgs, int[] outArgs)
	{
		object[] array = function.call(inArgs, returnTypes);
		if (returnTypes[0] == _200C_200F_200B_202D_202E_206C_206B_200B_202E_202C_206B_206F_202E_202A_202A_200F_202D_202C_206D_206F_200E_206B_200C_206F_202B_200F_200B_202D_202A_200C_206F_202C_206F_202A_200D_202E_206A_206D_202C_206D_202E(typeof(void).TypeHandle))
		{
			goto IL_001b;
		}
		goto IL_00a6;
		IL_001b:
		int num = -130190187;
		goto IL_0020;
		IL_0020:
		int num4 = default(int);
		int num3 = default(int);
		object result = default(object);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1551415611)) % 10)
			{
			case 3u:
				break;
			case 0u:
				goto IL_005e;
			case 1u:
				num4++;
				num = (int)((num2 * 2107694453) ^ 0xFB95444);
				continue;
			case 9u:
				args[outArgs[num3]] = array[num4];
				num = -345722722;
				continue;
			case 4u:
				num3 = 0;
				num = -971136121;
				continue;
			case 5u:
				goto IL_00a6;
			case 8u:
				num4 = 1;
				num = ((int)num2 * -1994885018) ^ -1118165713;
				continue;
			case 2u:
				result = null;
				num4 = 0;
				num = ((int)num2 * -1709873845) ^ 0x4BD42F8F;
				continue;
			case 6u:
				num3++;
				num = ((int)num2 * -1921509880) ^ -221894857;
				continue;
			default:
				return result;
			}
			break;
			IL_005e:
			int num5;
			if (num3 < outArgs.Length)
			{
				num = -1698465036;
				num5 = num;
			}
			else
			{
				num = -1065827352;
				num5 = num;
			}
		}
		goto IL_001b;
		IL_00a6:
		result = array[0];
		num = -1173151043;
		goto IL_0020;
	}

	static Type _200C_200F_200B_202D_202E_206C_206B_200B_202E_202C_206B_206F_202E_202A_202A_200F_202D_202C_206D_206F_200E_206B_200C_206F_202B_200F_200B_202D_202A_200C_206F_202C_206F_202A_200D_202E_206A_206D_202C_206D_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
