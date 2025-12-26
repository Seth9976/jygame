using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using UnityEngine;

namespace JyGame;

internal class SystemClass
{
	private static TimeSpan _202A_200C_206F_202C_200F_200B_202C_200B_206A_202A_206F_206C_206C_202D_202D_202D_200F_202B_206A_206E_202A_200B_206A_206C_202D_206F_200F_206D_200E_200C_200D_202C_200F_202B_206D_200B_202B_200E_206C_200F_202E;

	private static int _202A_202B_200B_206A_206F_202C_200F_202E_200F_206C_202D_206D_202E_200D_200B_206B_206F_200D_200F_206C_206C_206B_202B_206E_206E_200B_202C_206A_200B_206F_206D_202A_202C_200C_206C_206D_200B_202C_202B_206C_202E;

	private static bool _206C_200E_200F_202D_202D_206E_202D_200C_206B_202C_206D_202A_200B_206B_206F_200F_206F_202A_206F_202A_202D_202A_202E_206C_200B_200B_202B_206E_200F_202A_206C_206D_202C_200D_202E_206F_200F_206C_206D_200F_202E()
	{
		return true;
	}

	private static List<string> _202C_202B_206B_206E_200C_200D_200D_200C_206B_206A_200E_206A_202D_200F_202D_200F_200D_206D_200C_202D_200E_200C_200D_200C_202E_206E_202D_200E_202D_202B_202C_206F_206E_202D_202E_206D_202C_202A_200D_206A_202E()
	{
		List<string> list = new List<string>();
		int num3 = default(int);
		Process[] array = default(Process[]);
		while (true)
		{
			int num = 773037560;
			while (true)
			{
				int num7;
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6A2F05CB)) % 6)
				{
				case 5u:
					break;
				case 3u:
					num3 = 0;
					num = ((int)num2 * -1553227421) ^ -141097906;
					continue;
				case 2u:
					array = _206D_206C_206B_206B_206E_206B_200E_200B_206E_202B_200E_200F_206F_202C_202A_202A_200B_206E_200E_200C_206D_206A_200B_206B_200E_200E_206B_206B_206A_206E_206D_202A_206A_200F_200C_200B_200D_206D_206E_206B_202E();
					num = (int)((num2 * 1320733559) ^ 0x77C1D332);
					continue;
				case 1u:
					if (_206C_200E_200F_202D_202D_206E_202D_200C_206B_202C_206D_202A_200B_206B_206F_200F_206F_202A_206F_202A_202D_202A_202E_206C_200B_200B_202B_206E_200F_202A_206C_206D_202C_200D_202E_206F_200F_206C_206D_200F_202E())
					{
						num = ((int)num2 * -1086798456) ^ 0x6F7066FD;
						continue;
					}
					goto IL_013f;
				default:
				{
					Process process = array[num3];
					try
					{
						string item = _200E_202B_200E_200C_200F_206F_206F_202C_200F_206A_202C_206A_206B_202A_200B_206E_202C_202B_202E_200C_200D_200F_206F_202E_200B_202D_206B_206C_206B_202B_202E_206C_200D_202B_200B_206B_200C_200F_206E_202E_202E(_202C_206D_206C_206D_206F_206B_202B_206F_206C_200B_202E_206A_202B_200C_206E_202A_200B_206A_206B_206B_206D_206E_206F_206C_206A_200E_202D_202E_202C_206A_202B_206F_206B_202E_206A_200E_200B_206A_202C_200E_202E(process));
						while (true)
						{
							IL_00a0:
							int num4 = 1904194872;
							while (true)
							{
								switch ((num2 = (uint)(num4 ^ 0x6A2F05CB)) % 4)
								{
								case 2u:
									break;
								default:
									goto end_IL_00a5;
								case 3u:
								{
									int num5;
									int num6;
									if (list.Contains(item))
									{
										num5 = 327216696;
										num6 = num5;
									}
									else
									{
										num5 = 2118746649;
										num6 = num5;
									}
									num4 = num5 ^ ((int)num2 * -1320280598);
									continue;
								}
								case 0u:
									list.Add(item);
									num4 = (int)(num2 * 804162194) ^ -1520649346;
									continue;
								case 1u:
									goto end_IL_00a5;
								}
								goto IL_00a0;
								continue;
								end_IL_00a5:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3++;
					goto IL_010c;
				}
				case 4u:
					goto IL_012f;
					IL_013f:
					return list;
					IL_010c:
					num7 = 374338006;
					goto IL_0111;
					IL_0111:
					switch ((num2 = (uint)(num7 ^ 0x6A2F05CB)) % 3)
					{
					case 0u:
						break;
					case 1u:
						goto IL_012f;
					default:
						goto IL_013f;
					}
					goto IL_010c;
					IL_012f:
					if (num3 < array.Length)
					{
						goto default;
					}
					num7 = 1216469680;
					goto IL_0111;
				}
				break;
			}
		}
	}

	private static long _200D_206F_206C_202E_200D_206A_200D_206A_202E_206B_206E_202E_206C_206C_200F_200C_202B_206F_200B_202C_200D_202C_200E_202B_200D_200C_200C_206D_206A_200B_206E_202C_202D_206E_200C_200B_202E_202A_206A_200D_202E(string P_0)
	{
		if (_206E_206B_202A_206B_200B_200B_206B_202A_202C_202A_206B_200F_200D_200E_202D_202B_206A_202C_202C_200C_206E_202D_206A_206B_202A_206A_200C_206F_202B_206C_202E_200F_206A_202E_206F_206F_200E_200F_202C_206B_202E(P_0))
		{
			while (true)
			{
				uint num;
				switch ((num = 1655443810u) % 3)
				{
				case 2u:
					continue;
				case 1u:
					return _202A_200F_200C_200D_200E_202A_202A_206B_202E_206A_202D_200F_206E_202C_202E_206E_200C_200C_206F_200D_206F_206E_206E_200B_200F_206E_200D_206B_202A_202C_206A_202B_206C_202C_202B_200B_202C_202C_202C_206D_202E(_206D_206E_206F_206B_206C_200F_200E_206A_202C_206E_206A_206E_202E_200D_200E_200B_206C_206E_206D_202E_202A_200D_202E_200E_206E_200B_206A_200F_200F_200F_202D_200E_202A_206C_202C_202A_202D_202E_206D_202E(P_0));
				}
				break;
			}
		}
		return -1L;
	}

	private static bool _200D_200C_206C_200C_200B_202D_206A_202C_202A_200B_200D_206F_200E_202E_202B_202C_202D_206C_202D_202B_202B_202C_206D_200D_200C_200D_202E_202D_200C_202B_206B_202B_206D_206B_202D_200D_206D_200C_206B_202E(string P_0)
	{
		long num = _200D_206F_206C_202E_200D_206A_200D_206A_202E_206B_206E_202E_206C_206C_200F_200C_202B_206F_200B_202C_200D_202C_200E_202B_200D_200C_200C_206D_206A_200B_206E_202C_202D_206E_200C_200B_202E_202A_206A_200D_202E(P_0);
		while (true)
		{
			int num2 = -212060971;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -298440761)) % 6)
				{
				case 5u:
					break;
				case 1u:
					return true;
				case 3u:
				{
					int num6;
					int num7;
					if (num == 5138432)
					{
						num6 = 212305049;
						num7 = num6;
					}
					else
					{
						num6 = 903789860;
						num7 = num6;
					}
					num2 = num6 ^ ((int)num3 * -1981024819);
					continue;
				}
				case 2u:
				{
					int num8;
					int num9;
					if (num == 4532224)
					{
						num8 = 305361110;
						num9 = num8;
					}
					else
					{
						num8 = 2131937516;
						num9 = num8;
					}
					num2 = num8 ^ (int)(num3 * 1487126820);
					continue;
				}
				case 4u:
				{
					int num4;
					int num5;
					if (num == 1192960)
					{
						num4 = 1036326428;
						num5 = num4;
					}
					else
					{
						num4 = 1703920243;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 668652353);
					continue;
				}
				default:
					return false;
				}
				break;
			}
		}
	}

	private static bool _202D_200C_206B_200B_202D_202E_206A_200D_206D_206C_206C_202A_206D_202D_206E_202B_202D_206A_200B_200C_206B_206E_202D_202B_206B_206B_202D_206C_202C_206D_206D_202E_202B_206E_206C_206B_200E_200B_200B_202A_202E(string P_0)
	{
		if (!_200F_206D_206A_206F_200F_202E_200E_202D_200F_200B_200E_202A_200C_206D_202E_200C_200C_200D_200E_206B_202C_202D_202A_202C_202A_206D_200B_206B_206B_206B_202C_200C_200E_202E_200C_206B_206C_200C_200D_206D_202E(P_0, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(432300401u)))
		{
			goto IL_0012;
		}
		goto IL_004d;
		IL_0012:
		int num = -1827701620;
		goto IL_0017;
		IL_0017:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -539417476)) % 5)
			{
			case 4u:
				break;
			case 1u:
				return true;
			case 2u:
				goto IL_004d;
			case 3u:
			{
				int num3;
				int num4;
				if (!_200F_206D_206A_206F_200F_202E_200E_202D_200F_200B_200E_202A_200C_206D_202E_200C_200C_200D_200E_206B_202C_202D_202A_202C_202A_206D_200B_206B_206B_206B_202C_200C_200E_202E_200C_206B_206C_200C_200D_206D_202E(P_0, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2339439938u)))
				{
					num3 = 63502307;
					num4 = num3;
				}
				else
				{
					num3 = 1934998827;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 2038011345);
				continue;
			}
			default:
				return false;
			}
			break;
		}
		goto IL_0012;
		IL_004d:
		int num5;
		if (_200F_206D_206A_206F_200F_202E_200E_202D_200F_200B_200E_202A_200C_206D_202E_200C_200C_200D_200E_206B_202C_202D_202A_202C_202A_206D_200B_206B_206B_206B_202C_200C_200E_202E_200C_206B_206C_200C_200D_206D_202E(P_0, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3774336692u)))
		{
			num = -289786369;
			num5 = num;
		}
		else
		{
			num = -168117229;
			num5 = num;
		}
		goto IL_0017;
	}

	internal static bool _202A_202D_200D_206C_206F_206C_202A_200E_206B_206D_206C_206F_202E_206F_202E_206D_200B_206D_206B_200D_206E_206A_200E_206F_200E_202B_206C_200D_200F_202A_206D_202A_202E_200F_202C_206F_206F_200E_206F_200E_202E()
	{
		if (_202A_202B_200B_206A_206F_202C_200F_202E_200F_206C_202D_206D_202E_200D_200B_206B_206F_200D_200F_206C_206C_206B_202B_206E_206E_200B_202C_206A_200B_206F_206D_202A_202C_200C_206C_206D_200B_202C_202B_206C_202E != 0)
		{
			goto IL_0007;
		}
		goto IL_003e;
		IL_0007:
		int num = -1583378441;
		goto IL_000c;
		IL_000c:
		uint num2;
		DateTime now = default(DateTime);
		switch ((num2 = (uint)(num ^ -970427266)) % 4)
		{
		case 0u:
			break;
		case 1u:
			return true;
		case 2u:
			goto IL_003e;
		default:
			_202A_200C_206F_202C_200F_200B_202C_200B_206A_202A_206F_206C_206C_202D_202D_202D_200F_202B_206A_206E_202A_200B_206A_206C_202D_206F_200F_206D_200E_200C_200D_202C_200F_202B_206D_200B_202B_200E_206C_200F_202E = new TimeSpan(now.Ticks);
			return false;
		}
		goto IL_0007;
		IL_003e:
		now = DateTime.Now;
		num = -721877123;
		goto IL_000c;
	}

	static SystemClass()
	{
		_202A_200C_206F_202C_200F_200B_202C_200B_206A_202A_206F_206C_206C_202D_202D_202D_200F_202B_206A_206E_202A_200B_206A_206C_202D_206F_200F_206D_200E_200C_200D_202C_200F_202B_206D_200B_202B_200E_206C_200F_202E = new TimeSpan(0L);
	}

	internal static void _202D_202A_202A_200C_202D_206A_206C_206E_206C_200D_206C_206F_200E_200F_202D_202C_202B_206F_202C_200C_200D_202D_206A_206E_202E_202B_202D_206F_202C_202A_202A_202A_206B_200E_206F_206D_206D_200E_200B_206F_202E()
	{
		float num = _202A_202B_200B_206A_206F_202C_200F_202E_200F_206C_202D_206D_202E_200D_200B_206B_206F_200D_200F_206C_206C_206B_202B_206E_206E_200B_202C_206A_200B_206F_206D_202A_202C_200C_206C_206D_200B_202C_202B_206C_202E;
		_202A_202B_200B_206A_206F_202C_200F_202E_200F_206C_202D_206D_202E_200D_200B_206B_206F_200D_200F_206C_206C_206B_202B_206E_206E_200B_202C_206A_200B_206F_206D_202A_202C_200C_206C_206D_200B_202C_202B_206C_202E++;
		while (true)
		{
			int num2 = -409010888;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -127313519)) % 5)
				{
				case 4u:
					break;
				default:
					return;
				case 3u:
					_206B_200B_200D_206C_206B_200D_202B_202C_200C_206C_202C_202C_206A_202B_202D_200B_200F_202C_202D_206E_202A_200E_206F_200E_202B_206D_206E_206A_200F_206B_206D_206E_200F_200E_200E_200C_200D_206D_202A_202D_202E();
					num2 = -966214201;
					continue;
				case 0u:
				{
					int num6;
					int num7;
					if (_202A_202B_200B_206A_206F_202C_200F_202E_200F_206C_202D_206D_202E_200D_200B_206B_206F_200D_200F_206C_206C_206B_202B_206E_206E_200B_202C_206A_200B_206F_206D_202A_202C_200C_206C_206D_200B_202C_202B_206C_202E != (int)num)
					{
						num6 = 1077727399;
						num7 = num6;
					}
					else
					{
						num6 = 254852251;
						num7 = num6;
					}
					num2 = num6 ^ ((int)num3 * -2062060843);
					continue;
				}
				case 1u:
				{
					int num4;
					int num5;
					if (_202A_202B_200B_206A_206F_202C_200F_202E_200F_206C_202D_206D_202E_200D_200B_206B_206F_200D_200F_206C_206C_206B_202B_206E_206E_200B_202C_206A_200B_206F_206D_202A_202C_200C_206C_206D_200B_202C_202B_206C_202E != 0)
					{
						num4 = -534344666;
						num5 = num4;
					}
					else
					{
						num4 = -891247700;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 1171439359);
					continue;
				}
				case 2u:
					return;
				}
				break;
			}
		}
	}

	internal static int _200E_206C_206A_206E_202D_206D_206C_200D_206B_206B_206D_202E_206D_206C_206D_202E_200B_206F_206E_200C_206D_206E_206B_206D_202B_202A_202E_206B_200D_206F_202A_206C_202D_206D_206B_200F_202D_200D_200C_206C_202E()
	{
		return _202A_202B_200B_206A_206F_202C_200F_202E_200F_206C_202D_206D_202E_200D_200B_206B_206F_200D_200F_206C_206C_206B_202B_206E_206E_200B_202C_206A_200B_206F_206D_202A_202C_200C_206C_206D_200B_202C_202B_206C_202E;
	}

	static Process[] _206D_206C_206B_206B_206E_206B_200E_200B_206E_202B_200E_200F_206F_202C_202A_202A_200B_206E_200E_200C_206D_206A_200B_206B_200E_200E_206B_206B_206A_206E_206D_202A_206A_200F_200C_200B_200D_206D_206E_206B_202E()
	{
		return Process.GetProcesses();
	}

	static ProcessModule _202C_206D_206C_206D_206F_206B_202B_206F_206C_200B_202E_206A_202B_200C_206E_202A_200B_206A_206B_206B_206D_206E_206F_206C_206A_200E_202D_202E_202C_206A_202B_206F_206B_202E_206A_200E_200B_206A_202C_200E_202E(Process P_0)
	{
		return P_0.MainModule;
	}

	static string _200E_202B_200E_200C_200F_206F_206F_202C_200F_206A_202C_206A_206B_202A_200B_206E_202C_202B_202E_200C_200D_200F_206F_202E_200B_202D_206B_206C_206B_202B_202E_206C_200D_202B_200B_206B_200C_200F_206E_202E_202E(ProcessModule P_0)
	{
		return P_0.FileName;
	}

	static bool _206E_206B_202A_206B_200B_200B_206B_202A_202C_202A_206B_200F_200D_200E_202D_202B_206A_202C_202C_200C_206E_202D_206A_206B_202A_206A_200C_206F_202B_206C_202E_200F_206A_202E_206F_206F_200E_200F_202C_206B_202E(string P_0)
	{
		return File.Exists(P_0);
	}

	static FileInfo _206D_206E_206F_206B_206C_200F_200E_206A_202C_206E_206A_206E_202E_200D_200E_200B_206C_206E_206D_202E_202A_200D_202E_200E_206E_200B_206A_200F_200F_200F_202D_200E_202A_206C_202C_202A_202D_202E_206D_202E(string P_0)
	{
		return new FileInfo(P_0);
	}

	static long _202A_200F_200C_200D_200E_202A_202A_206B_202E_206A_202D_200F_206E_202C_202E_206E_200C_200C_206F_200D_206F_206E_206E_200B_200F_206E_200D_206B_202A_202C_206A_202B_206C_202C_202B_200B_202C_202C_202C_206D_202E(FileInfo P_0)
	{
		return P_0.Length;
	}

	static bool _200F_206D_206A_206F_200F_202E_200E_202D_200F_200B_200E_202A_200C_206D_202E_200C_200C_200D_200E_206B_202C_202D_202A_202C_202A_206D_200B_206B_206B_206B_202C_200C_200E_202E_200C_206B_206C_200C_200D_206D_202E(string P_0, string P_1)
	{
		return P_0.Contains(P_1);
	}

	static void _206B_200B_200D_206C_206B_200D_202B_202C_200C_206C_202C_202C_206A_202B_202D_200B_200F_202C_202D_206E_202A_200E_206F_200E_202B_206D_206E_206A_200F_206B_206D_206E_200F_200E_200E_200C_200D_206D_202A_202D_202E()
	{
		Application.Quit();
	}
}
