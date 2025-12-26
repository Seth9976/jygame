using System;
using System.Runtime.CompilerServices;

namespace JyGame;

public class CRC32
{
	private static uint[] crcTable;

	internal static uint GetCRC32(byte[] bytes)
	{
		uint num = (uint)bytes.Length;
		uint num4 = default(uint);
		uint num5 = default(uint);
		while (true)
		{
			int num2 = 1062823459;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x1F7A67A)) % 6)
				{
				case 4u:
					break;
				case 1u:
					num4 = uint.MaxValue;
					num5 = 0u;
					num2 = (int)((num3 * 1585421510) ^ 0x77AA82F5);
					continue;
				case 5u:
					num5++;
					num2 = (int)((num3 * 1602598279) ^ 0x159A641C);
					continue;
				case 2u:
					num4 = (num4 << 8) ^ crcTable[(num4 >> 24) ^ bytes[num5]];
					num2 = 825676275;
					continue;
				case 3u:
				{
					int num6;
					if (num5 >= num)
					{
						num2 = 270266466;
						num6 = num2;
					}
					else
					{
						num2 = 1273129374;
						num6 = num2;
					}
					continue;
				}
				default:
					return num4;
				}
				break;
			}
		}
	}

	static CRC32()
	{
		uint[] array = new uint[256];
		_200E_206F_202C_206E_206A_202E_200D_206C_200E_200C_206D_202B_202B_202C_202A_206B_200B_202B_206A_206E_200F_202B_200B_206D_200C_206F_202E_200C_206D_200E_206B_202C_206E_202C_206A_206D_202B_206C_200E_202E_202E((Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		crcTable = array;
	}

	static void _200E_206F_202C_206E_206A_202E_200D_206C_200E_200C_206D_202B_202B_202C_202A_206B_200B_202B_206A_206E_200F_202B_200B_206D_200C_206F_202E_200C_206D_200E_206B_202C_206E_202C_206A_206D_202B_206C_200E_202E_202E(Array P_0, RuntimeFieldHandle P_1)
	{
		RuntimeHelpers.InitializeArray(P_0, P_1);
	}
}
