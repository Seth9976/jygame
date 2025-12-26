using System;
using System.Runtime.InteropServices;

public class LuaStringBuffer
{
	public byte[] buffer;

	public LuaStringBuffer(IntPtr P_0, int P_1)
	{
		while (true)
		{
			int num = -918075773;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1598313679)) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_0028;
				default:
					_206E_202E_206A_200E_206E_202B_202E_202E_200F_206F_202B_202B_206E_206F_206A_200E_206F_206B_206B_200F_200F_206D_202D_202A_202D_200F_200F_200C_206D_202E_200F_206F_206B_200E_202D_200E_206C_202A_202D_206B_202E(P_0, buffer, 0, P_1);
					return;
				}
				break;
				IL_0028:
				buffer = new byte[P_1];
				num = (int)(num2 * 1970766363) ^ -1491676341;
			}
		}
	}

	public LuaStringBuffer(byte[] P_0)
	{
		buffer = P_0;
	}

	static void _206E_202E_206A_200E_206E_202B_202E_202E_200F_206F_202B_202B_206E_206F_206A_200E_206F_206B_206B_200F_200F_206D_202D_202A_202D_200F_200F_200C_206D_202E_200F_206F_206B_200E_202D_200E_206C_202A_202D_206B_202E(IntPtr P_0, byte[] P_1, int P_2, int P_3)
	{
		Marshal.Copy(P_0, P_1, P_2, P_3);
	}
}
