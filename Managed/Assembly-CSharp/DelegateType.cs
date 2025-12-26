using System;

public class DelegateType
{
	public string name;

	public Type type;

	public string strType = string.Empty;

	public DelegateType(Type P_0)
	{
		while (true)
		{
			int num = 1623033160;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2C1F870D)) % 7)
				{
				case 4u:
					break;
				default:
					return;
				case 1u:
					type = P_0;
					num = (int)(num2 * 727300770) ^ -1666169084;
					continue;
				case 3u:
					strType = ToLuaExport.GetTypeStr(P_0);
					num = (int)((num2 * 1150706695) ^ 0x1214CC9D);
					continue;
				case 2u:
					name = ToLuaExport.GetGenericLibName(P_0);
					num = (int)((num2 * 1194901343) ^ 0x4799B762);
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (_200C_202E_202E_202D_200E_200E_200D_206A_200C_200B_200E_200F_206F_200C_206C_200E_206B_206B_206A_202B_202A_206F_202B_206E_200E_200B_200C_200F_206B_206E_206A_200C_202A_206E_200E_206B_202E_202E_206D_200E_202E(P_0))
					{
						num3 = -479137334;
						num4 = num3;
					}
					else
					{
						num3 = -2096789010;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -756243373);
					continue;
				}
				case 0u:
					name = ToLuaExport.GetTypeStr(P_0);
					name = _206E_200D_200F_200D_200D_206E_206C_202C_202C_200C_206A_206F_200D_206E_206C_202E_200E_202A_200D_202D_202C_202B_202B_206F_206E_200F_202E_206E_200C_200B_202C_200C_206A_202C_206C_206A_206D_206C_200D_206D_202E(name, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1911841291u), global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3407436709u));
					num = 933332842;
					continue;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	public DelegateType SetName(string str)
	{
		name = str;
		return this;
	}

	static bool _200C_202E_202E_202D_200E_200E_200D_206A_200C_200B_200E_200F_206F_200C_206C_200E_206B_206B_206A_202B_202A_206F_202B_206E_200E_200B_200C_200F_206B_206E_206A_200C_202A_206E_200E_206B_202E_202E_206D_200E_202E(Type P_0)
	{
		return P_0.IsGenericType;
	}

	static string _206E_200D_200F_200D_200D_206E_206C_202C_202C_200C_206A_206F_200D_206E_206C_202E_200E_202A_200D_202D_202C_202B_202B_206F_206E_200F_202E_206E_200C_200B_202C_200C_206A_202C_206C_206A_206D_206C_200D_206D_202E(string P_0, string P_1, string P_2)
	{
		return P_0.Replace(P_1, P_2);
	}
}
