using System;
using UnityEngine;

namespace Umeng;

public class GA : Analytics
{
	public enum Gender
	{
		Unknown,
		Male,
		Female
	}

	public enum PaySource
	{
		AppStore = 1,
		支付宝,
		网银,
		财付通,
		移动,
		联通,
		电信,
		Paypal,
		Source9,
		Source10,
		Source11,
		Source12,
		Source13,
		Source14,
		Source15,
		Source16,
		Source17,
		Source18,
		Source19,
		Source20
	}

	public enum BonusSource
	{
		玩家赠送 = 1,
		Source2,
		Source3,
		Source4,
		Source5,
		Source6,
		Source7,
		Source8,
		Source9,
		Source10
	}

	public static void SetUserLevel(int level)
	{
	}

	[Obsolete("SetUserLevel(string level) 已弃用, 请使用 SetUserLevel(int level)")]
	public static void SetUserLevel(string level)
	{
		_202C_206A_200D_206C_202D_202A_202E_206C_206C_206D_202B_206B_200D_206F_206E_206B_200C_202D_206D_202A_206D_202C_202B_202D_200C_206D_200E_200D_200E_202D_200F_206D_202C_200E_206B_202A_200C_200F_206A_200E_202E((object)global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3084769062u));
	}

	[Obsolete("SetUserInfo已弃用, 请使用ProfileSignIn")]
	public static void SetUserInfo(string userId, Gender gender, int age, string platform)
	{
	}

	public static void StartLevel(string level)
	{
	}

	public static void FinishLevel(string level)
	{
	}

	public static void FailLevel(string level)
	{
	}

	public static void Pay(double cash, PaySource source, double coin)
	{
	}

	public static void Pay(double cash, int source, double coin)
	{
		if (source >= 1)
		{
			while (true)
			{
				int num = -522157087;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -269121417)) % 4)
					{
					case 0u:
						break;
					default:
						return;
					case 2u:
					{
						int num3;
						int num4;
						if (source > 100)
						{
							num3 = 743886092;
							num4 = num3;
						}
						else
						{
							num3 = 1827490342;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -2127939314);
						continue;
					}
					case 3u:
						goto end_IL_0004;
					case 1u:
						return;
					}
					break;
				}
				continue;
				end_IL_0004:
				break;
			}
		}
		throw _202D_206B_200F_200D_206F_202B_202C_200B_202A_200D_206E_200D_202A_200E_206A_200C_200E_206C_206A_202D_202E_206E_202C_206F_206D_200F_202D_206D_200D_202E_200B_202E_200D_200D_200B_200F_202C_200E_200B_206D_202E();
	}

	public static void Pay(double cash, PaySource source, string item, int amount, double price)
	{
	}

	public static void Buy(string item, int amount, double price)
	{
	}

	public static void Use(string item, int amount, double price)
	{
	}

	public static void Bonus(double coin, BonusSource source)
	{
	}

	public static void Bonus(string item, int amount, double price, BonusSource source)
	{
	}

	public static void ProfileSignIn(string userId)
	{
	}

	public static void ProfileSignIn(string userId, string provider)
	{
	}

	public static void ProfileSignOff()
	{
	}

	static void _202C_206A_200D_206C_202D_202A_202E_206C_206C_206D_202B_206B_200D_206F_206E_206B_200C_202D_206D_202A_206D_202C_202B_202D_200C_206D_200E_200D_200E_202D_200F_206D_202C_200E_206B_202A_200C_200F_206A_200E_202E(object P_0)
	{
		Debug.Log(P_0);
	}

	static ArgumentException _202D_206B_200F_200D_206F_202B_202C_200B_202A_200D_206E_200D_202A_200E_206A_200C_200E_206C_206A_202D_202E_206E_202C_206F_206D_200F_202D_206D_200D_202E_200B_202E_200D_200D_200B_200F_202C_200E_200B_206D_202E()
	{
		return new ArgumentException();
	}
}
