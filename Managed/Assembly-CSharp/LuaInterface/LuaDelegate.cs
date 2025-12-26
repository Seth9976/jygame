using System;

namespace LuaInterface;

public class LuaDelegate
{
	public Type[] returnTypes;

	public LuaFunction function;

	public LuaDelegate()
	{
		while (true)
		{
			int num = 1421203432;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4F95F718)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_0028;
				default:
					returnTypes = null;
					return;
				}
				break;
				IL_0028:
				function = null;
				num = ((int)num2 * -65903934) ^ 0x4F391161;
			}
		}
	}

	public object callFunction(object[] args, object[] inArgs, int[] outArgs)
	{
		object[] array = function.call(inArgs, returnTypes);
		int num4 = default(int);
		int num3 = default(int);
		object result = default(object);
		while (true)
		{
			int num = 683366689;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3ACC739)) % 13)
				{
				case 4u:
					break;
				case 1u:
					num = (int)((num2 * 2007261708) ^ 0x1AF1A5D8);
					continue;
				case 9u:
					num4++;
					num = ((int)num2 * -1088669738) ^ -37541587;
					continue;
				case 11u:
				{
					int num6;
					int num7;
					if (returnTypes[0] != _202D_206E_206B_206C_206A_200C_200B_202D_206B_202E_206B_202D_206C_202C_206A_206B_200B_206B_202D_202D_200C_206C_200D_200E_206E_206B_206E_202B_200E_200C_206A_200E_206D_206E_206A_200D_206E_206E_202D_206D_202E(typeof(void).TypeHandle))
					{
						num6 = -1574789244;
						num7 = num6;
					}
					else
					{
						num6 = -1817775;
						num7 = num6;
					}
					num = num6 ^ (int)(num2 * 2055686947);
					continue;
				}
				case 10u:
					num4 = 0;
					num = ((int)num2 * -797832789) ^ -546744710;
					continue;
				case 0u:
					num3 = 0;
					num = 514704291;
					continue;
				case 2u:
				{
					int num5;
					if (num3 >= outArgs.Length)
					{
						num = 2106687762;
						num5 = num;
					}
					else
					{
						num = 327847227;
						num5 = num;
					}
					continue;
				}
				case 6u:
					result = array[0];
					num = 2115115059;
					continue;
				case 8u:
					num4 = 1;
					num = ((int)num2 * -2110452894) ^ -1326245191;
					continue;
				case 12u:
					num3++;
					num = (int)((num2 * 199209738) ^ 0x21828840);
					continue;
				case 3u:
					result = null;
					num = (int)((num2 * 1981747449) ^ 0x5F40475C);
					continue;
				case 5u:
					args[outArgs[num3]] = array[num4];
					num = 856828991;
					continue;
				default:
					return result;
				}
				break;
			}
		}
	}

	static Type _202D_206E_206B_206C_206A_200C_200B_202D_206B_202E_206B_202D_206C_202C_206A_206B_200B_206B_202D_202D_200C_206C_200D_200E_206E_206B_206E_202B_200E_200C_206A_200E_206D_206E_206A_200D_206E_206E_202D_206D_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
