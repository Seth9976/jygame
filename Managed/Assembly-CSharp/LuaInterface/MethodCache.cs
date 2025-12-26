using System;
using System.Reflection;

namespace LuaInterface;

internal struct MethodCache
{
	private MethodBase _202C_200C_206B_206C_200D_202D_202E_202B_200B_202E_202A_202E_200E_206F_202A_206F_202A_202B_202D_206E_206E_206C_200D_200C_202A_206C_206E_202E_206E_202D_202E_206E_202E_206B_206F_200D_206C_202B_202B_206C_202E;

	public bool IsReturnVoid;

	public object[] args;

	public int[] outList;

	public MethodArgs[] argTypes;

	public MethodBase cachedMethod
	{
		get
		{
			return _202C_200C_206B_206C_200D_202D_202E_202B_200B_202E_202A_202E_200E_206F_202A_206F_202A_202B_202D_206E_206E_206C_200D_200C_202A_206C_206E_202E_206E_202D_202E_206E_202E_206B_206F_200D_206C_202B_202B_206C_202E;
		}
		set
		{
			_202C_200C_206B_206C_200D_202D_202E_202B_200B_202E_202A_202E_200E_206F_202A_206F_202A_202B_202D_206E_206E_206C_200D_200C_202A_206C_206E_202E_206E_202D_202E_206E_202E_206B_206F_200D_206C_202B_202B_206C_202E = value;
			MethodInfo methodInfo = value as MethodInfo;
			while (true)
			{
				int num = -319274312;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -667340762)) % 4)
					{
					case 0u:
						break;
					default:
						return;
					case 2u:
					{
						int num3;
						int num4;
						if (methodInfo == null)
						{
							num3 = 476211095;
							num4 = num3;
						}
						else
						{
							num3 = 1064729693;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -762622082);
						continue;
					}
					case 3u:
						IsReturnVoid = _202B_200F_202E_206A_202A_200B_206D_206A_200E_200C_206D_202C_200D_200E_202D_206D_200B_200D_206C_202C_200D_200D_200B_206E_202C_206A_206F_206F_202D_206F_202A_206C_206D_200D_206F_206D_206A_206D_200F_200D_202E(methodInfo) == _202B_202D_202A_200F_200D_200D_206E_206D_206E_202C_200D_200E_202E_206C_200B_202C_206D_202B_202E_200F_202D_202C_206D_206E_206F_206F_206A_206C_200B_206F_200D_202A_200F_202D_202D_200E_206D_206C_206C_200F_202E(typeof(void).TypeHandle);
						num = (int)(num2 * 672078794) ^ -1389802011;
						continue;
					case 1u:
						return;
					}
					break;
				}
			}
		}
	}

	static Type _202B_200F_202E_206A_202A_200B_206D_206A_200E_200C_206D_202C_200D_200E_202D_206D_200B_200D_206C_202C_200D_200D_200B_206E_202C_206A_206F_206F_202D_206F_202A_206C_206D_200D_206F_206D_206A_206D_200F_200D_202E(MethodInfo P_0)
	{
		return P_0.ReturnType;
	}

	static Type _202B_202D_202A_200F_200D_200D_206E_206D_206E_202C_200D_200E_202E_206C_200B_202C_206D_202B_202E_200F_202D_202C_206D_206E_206F_206F_206A_206C_200B_206F_200D_202A_200F_202D_202D_200E_206D_206C_206C_200F_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
