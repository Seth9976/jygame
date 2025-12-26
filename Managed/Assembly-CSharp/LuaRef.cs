using System;

public class LuaRef
{
	public IntPtr L;

	public int reference;

	public LuaRef(IntPtr P_0, int P_1)
	{
		while (true)
		{
			int num = 1394338861;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x553A84A0)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0028;
				default:
					reference = P_1;
					return;
				}
				break;
				IL_0028:
				L = P_0;
				num = ((int)num2 * -1469931311) ^ 0x651118FB;
			}
		}
	}
}
