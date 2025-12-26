using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;

namespace JyGame;

public class SaveManager
{
	private static string _206F_206A_202A_202D_206E_206F_206C_206C_200B_200C_206C_206C_206A_200D_202D_206E_200C_200C_202D_200D_206E_200D_202B_206D_202E_206C_200B_206A_200C_206F_206F_202E_206F_202B_200D_206B_200E_206E_206B_200E_202E;

	public static string SaveDir
	{
		get
		{
			string text = string.Empty;
			if (GlobalData.CurrentMod == null)
			{
				goto IL_000d;
			}
			goto IL_0066;
			IL_000d:
			int num = -707051282;
			goto IL_0012;
			IL_0012:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1029742871)) % 7)
				{
				case 0u:
					break;
				case 6u:
					text = _200D_202E_206E_206F_200F_206B_206C_200C_202E_202B_202D_206B_200E_206D_206F_206A_202A_206D_202C_206B_202A_202C_200B_202B_206B_202E_200F_200B_200E_206D_206B_206F_200F_200F_200C_202B_200B_206C_200F_206E_202E(CommonSettings.persistentDataPath, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2097627668u));
					num = (int)((num2 * 1887101542) ^ 0x161C8038);
					continue;
				case 5u:
					goto IL_0066;
				case 3u:
					goto IL_0099;
				case 2u:
					_202C_206B_200E_200D_202E_200C_206A_206C_202C_200E_202A_206D_200D_200E_202A_202E_200E_206C_202E_206C_206A_200D_200F_202B_206A_200D_200F_206E_202E_206D_206E_206C_202D_202B_206B_206E_200D_200D_206C_206F_202E(text);
					num = (int)(num2 * 1969429039) ^ -2089972874;
					continue;
				case 4u:
					num = (int)((num2 * 1241672743) ^ 0x3D63D09);
					continue;
				default:
					return text;
				}
				break;
				IL_0099:
				int num3;
				if (_206F_206F_206C_202D_206F_200D_202B_200E_202C_206F_200C_202E_202B_206B_206C_202B_200C_200D_200F_200B_200D_206D_200D_200C_202E_202B_202C_202D_202A_206C_206D_206A_200F_206E_202B_200D_200B_206D_206A_206F_202E(text))
				{
					num = -136685322;
					num3 = num;
				}
				else
				{
					num = -599696791;
					num3 = num;
				}
			}
			goto IL_000d;
			IL_0066:
			text = _202B_200F_202B_202E_206E_200E_206D_206B_200D_206B_206C_202A_202E_200F_200B_202B_200F_206E_200E_200E_206E_206E_202D_200E_206A_202C_202A_202E_202A_200C_202D_200E_200C_206D_206D_202A_200B_206B_200C_206A_202E(CommonSettings.persistentDataPath, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3105682201u), GlobalData.CurrentMod.key, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(172275819u));
			num = -1829879020;
			goto IL_0012;
		}
	}

	public static string GetSave(string saveName)
	{
		int num = SystemClass._200E_206C_206A_206E_202D_206D_206C_200D_206B_206B_206D_202E_206D_206C_206D_202E_200B_206F_206E_200C_206D_206E_206B_206D_202B_202A_202E_206B_200D_206F_202A_206C_202D_206D_206B_200F_202D_200D_200C_206C_202E();
		string path = default(string);
		while (true)
		{
			int num2 = -437267533;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1465487709)) % 7)
				{
				case 6u:
					break;
				case 1u:
				{
					int num8;
					int num9;
					if (!(num.ToString() != global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3556140356u)))
					{
						num8 = 1599967281;
						num9 = num8;
					}
					else
					{
						num8 = 520557466;
						num9 = num8;
					}
					num2 = num8 ^ ((int)num3 * -1304756369);
					continue;
				}
				case 4u:
					return string.Empty;
				case 3u:
				{
					int num10;
					int num11;
					if (File.Exists(path))
					{
						num10 = 2052897064;
						num11 = num10;
					}
					else
					{
						num10 = 826958068;
						num11 = num10;
					}
					num2 = num10 ^ ((int)num3 * -731850623);
					continue;
				}
				case 0u:
					return string.Empty;
				case 5u:
					RuntimeData.Instance.LastLoadingTime = new TimeSpan(DateTime.Now.Ticks);
					path = SaveDir + saveName;
					num2 = -895287999;
					continue;
				default:
				{
					ModData.Load();
					StreamReader streamReader = new StreamReader(path);
					string text;
					try
					{
						text = streamReader.ReadToEnd();
						num = CommonSettings.EN_SAVE();
						while (true)
						{
							IL_010f:
							int num4 = -2129631191;
							while (true)
							{
								switch ((num3 = (uint)(num4 ^ -1465487709)) % 4)
								{
								case 0u:
									break;
								default:
									goto end_IL_0114;
								case 2u:
								{
									int num5;
									int num6;
									if (num.ToString() != global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1303849581u))
									{
										num5 = -1578596730;
										num6 = num5;
									}
									else
									{
										num5 = -1622151532;
										num6 = num5;
									}
									num4 = num5 ^ ((int)num3 * -1167763839);
									continue;
								}
								case 3u:
									text = GetDecode(text);
									num4 = (int)(num3 * 1670949900) ^ -213182166;
									continue;
								case 1u:
									goto end_IL_0114;
								}
								goto IL_010f;
								continue;
								end_IL_0114:
								break;
							}
							break;
						}
					}
					finally
					{
						if (streamReader != null)
						{
							while (true)
							{
								IL_0186:
								int num7 = -835638359;
								while (true)
								{
									switch ((num3 = (uint)(num7 ^ -1465487709)) % 3)
									{
									case 0u:
										break;
									default:
										goto end_IL_018b;
									case 2u:
										goto IL_01a9;
									case 1u:
										goto end_IL_018b;
									}
									goto IL_0186;
									IL_01a9:
									((IDisposable)streamReader).Dispose();
									num7 = ((int)num3 * -1976414378) ^ -1292269187;
									continue;
									end_IL_018b:
									break;
								}
								break;
							}
						}
					}
					return text;
				}
				}
				break;
			}
		}
	}

	public static void SetSave(string saveName, string content)
	{
		int num = SystemClass._200E_206C_206A_206E_202D_206D_206C_200D_206B_206B_206D_202E_206D_206C_206D_202E_200B_206F_206E_200C_206D_206E_206B_206D_202B_202A_202E_206B_200D_206F_202A_206C_202D_206D_206B_200F_202D_200D_200C_206C_202E();
		while (true)
		{
			int num2 = 30043223;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x4EDC09C8)) % 11)
				{
				case 5u:
					break;
				case 1u:
				{
					int num13;
					int num14;
					if (!(num.ToString() == global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(838530381u)))
					{
						num13 = -1294014573;
						num14 = num13;
					}
					else
					{
						num13 = -735975323;
						num14 = num13;
					}
					num2 = num13 ^ (int)(num3 * 749596244);
					continue;
				}
				case 2u:
				{
					int num11;
					int num12;
					if (!SystemClass._202A_202D_200D_206C_206F_206C_202A_200E_206B_206D_206C_206F_202E_206F_202E_206D_200B_206D_206B_200D_206E_206A_200E_206F_200E_202B_206C_200D_200F_202A_206D_202A_202E_200F_202C_206F_206F_200E_206F_200E_202E())
					{
						num11 = 1345012386;
						num12 = num11;
					}
					else
					{
						num11 = 278206682;
						num12 = num11;
					}
					num2 = num11 ^ (int)(num3 * 2078201138);
					continue;
				}
				case 9u:
					Application.Quit();
					num2 = ((int)num3 * -560508501) ^ -1108509332;
					continue;
				case 7u:
					num = SystemClass._200E_206C_206A_206E_202D_206D_206C_200D_206B_206B_206D_202E_206D_206C_206D_202E_200B_206F_206E_200C_206D_206E_206B_206D_202B_202A_202E_206B_200D_206F_202A_206C_202D_206D_206B_200F_202D_200D_200C_206C_202E();
					num2 = (int)(num3 * 1363195718) ^ -1884849094;
					continue;
				case 0u:
				{
					int num10;
					if (saveName != global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3540223354u))
					{
						num2 = 1860039935;
						num10 = num2;
					}
					else
					{
						num2 = 1146071586;
						num10 = num2;
					}
					continue;
				}
				case 8u:
					return;
				case 3u:
					return;
				case 4u:
				{
					int num15;
					int num16;
					if (!Application.isMobilePlatform)
					{
						num15 = -251365644;
						num16 = num15;
					}
					else
					{
						num15 = -1675416738;
						num16 = num15;
					}
					num2 = num15 ^ (int)(num3 * 722675812);
					continue;
				}
				case 10u:
				{
					int num8;
					int num9;
					if (!(num.ToString() != global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2183687527u)))
					{
						num8 = 1270617502;
						num9 = num8;
					}
					else
					{
						num8 = 1910091010;
						num9 = num8;
					}
					num2 = num8 ^ ((int)num3 * -1195079122);
					continue;
				}
				default:
				{
					StreamWriter streamWriter = new StreamWriter(SaveDir + saveName);
					try
					{
						num = CommonSettings.EN_SAVE();
						while (true)
						{
							IL_0181:
							int num4 = 73363187;
							while (true)
							{
								switch ((num3 = (uint)(num4 ^ 0x4EDC09C8)) % 5)
								{
								case 0u:
									break;
								default:
									goto end_IL_0186;
								case 2u:
								{
									int num5;
									int num6;
									if (num.ToString() != global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2720456403u))
									{
										num5 = -2019016180;
										num6 = num5;
									}
									else
									{
										num5 = -1615603801;
										num6 = num5;
									}
									num4 = num5 ^ ((int)num3 * -636606738);
									continue;
								}
								case 4u:
									content = SetEncrypt(content);
									num4 = ((int)num3 * -928890230) ^ 0x3B3EDB51;
									continue;
								case 1u:
									streamWriter.Write(content);
									num4 = 91081000;
									continue;
								case 3u:
									goto end_IL_0186;
								}
								goto IL_0181;
								continue;
								end_IL_0186:
								break;
							}
							break;
						}
					}
					finally
					{
						if (streamWriter != null)
						{
							while (true)
							{
								IL_0206:
								int num7 = 1563370844;
								while (true)
								{
									switch ((num3 = (uint)(num7 ^ 0x4EDC09C8)) % 3)
									{
									case 0u:
										break;
									default:
										goto end_IL_020b;
									case 1u:
										goto IL_0228;
									case 2u:
										goto end_IL_020b;
									}
									goto IL_0206;
									IL_0228:
									((IDisposable)streamWriter).Dispose();
									num7 = (int)((num3 * 302417031) ^ 0x1ED99DEA);
									continue;
									end_IL_020b:
									break;
								}
								break;
							}
						}
					}
					ModData.Save();
					return;
				}
				}
				break;
			}
		}
	}

	public static void DeleteSave(string saveName)
	{
		string text = _200D_202E_206E_206F_200F_206B_206C_200C_202E_202B_202D_206B_200E_206D_206F_206A_202A_206D_202C_206B_202A_202C_200B_202B_206B_202E_200F_200B_200E_206D_206B_206F_200F_200F_200C_202B_200B_206C_200F_206E_202E(SaveDir, saveName);
		while (true)
		{
			int num = -2141463560;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -158089163)) % 4)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
				{
					int num3;
					int num4;
					if (_202B_206F_206D_202E_202E_206C_200B_200D_206C_202C_200B_202C_202D_202A_206D_206F_200F_202C_200E_206E_206C_206B_206E_202A_206B_206F_200B_200B_200D_200F_202A_206A_202E_202E_206B_200D_202C_206E_202B_202A_202E(text))
					{
						num3 = -574647860;
						num4 = num3;
					}
					else
					{
						num3 = -94100863;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1426918038);
					continue;
				}
				case 3u:
					_202C_206B_200E_200E_200D_202D_206E_206D_200F_206C_206A_206E_202D_202A_200D_202A_206C_202C_202C_202B_206F_200D_200F_202A_206E_200C_202B_206A_200D_206A_206F_206D_206C_202A_206D_206D_202C_206C_200F_206C_202E(text);
					num = (int)(num2 * 1791430764) ^ -869629433;
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public static bool ExistSave(string saveName)
	{
		string text = _200D_202E_206E_206F_200F_206B_206C_200C_202E_202B_202D_206B_200E_206D_206F_206A_202A_206D_202C_206B_202A_202C_200B_202B_206B_202E_200F_200B_200E_206D_206B_206F_200F_200F_200C_202B_200B_206C_200F_206E_202E(SaveDir, saveName);
		return _202B_206F_206D_202E_202E_206C_200B_200D_206C_202C_200B_202C_202D_202A_206D_206F_200F_202C_200E_206E_206C_206B_206E_202A_206B_206F_200B_200B_200D_200F_202A_206A_202E_202E_206B_200D_202C_206E_202B_202A_202E(text);
	}

	public static string crcjm(string input)
	{
		return null;
	}

	public static byte[] crcm(string input)
	{
		string[] array = _200E_206F_206A_206C_206A_206B_202D_206B_200D_202B_200B_202D_206E_206E_202B_200D_202D_202D_200F_200E_206A_206A_202A_202C_200D_202E_202C_202D_200F_206B_200D_202C_200C_206F_200E_202B_200C_206C_206D_202C_202E(input, new char[1] { '@' });
		byte[] array2 = default(byte[]);
		string text = default(string);
		while (true)
		{
			int num = -2106727949;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -47667531)) % 7)
				{
				case 5u:
					break;
				case 0u:
				{
					string text2 = CRC16_C(array2);
					int num5;
					int num6;
					if (_206F_202D_206B_202A_200D_200D_206F_202A_202E_200C_206B_202E_200F_206C_200F_206C_202A_202C_206C_202A_200E_202C_202D_202A_202D_206E_202D_202C_200D_202B_206F_206F_202B_206C_202B_206A_200E_206C_202E_202D_202E(text, text2))
					{
						num5 = 950861902;
						num6 = num5;
					}
					else
					{
						num5 = 2126410962;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -2086423451);
					continue;
				}
				case 2u:
					return new byte[1];
				case 6u:
					return new byte[1];
				case 3u:
				{
					int num3;
					int num4;
					if (array.Length == 2)
					{
						num3 = 23777570;
						num4 = num3;
					}
					else
					{
						num3 = 370123331;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1514579054);
					continue;
				}
				case 1u:
					text = array[0];
					array2 = m(array[1]);
					num = -1054123486;
					continue;
				default:
					return array2;
				}
				break;
			}
		}
	}

	private static string jm(string Message)
	{
		return null;
	}

	private static byte[] m(string Message)
	{
		UTF8Encoding uTF8Encoding = _202E_200C_200B_206F_206B_206A_202E_202C_200F_202C_202A_206C_206F_200E_202E_200D_206D_202B_206F_206F_206F_206B_206C_200D_202A_200D_206A_202D_200D_202B_202A_202A_200E_202C_206E_200C_206B_206D_202E_200E_202E();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = default(MD5CryptoServiceProvider);
		while (true)
		{
			int num = 305578351;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2C993B34)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0029;
				default:
				{
					byte[] array = _202E_200C_206B_206F_202B_200B_200F_200B_200C_200F_202A_202C_200E_206B_200B_200E_202E_202E_202C_202A_200C_200B_200D_206D_202D_200F_200D_200E_200D_206B_202C_202D_202D_206F_202D_202B_202B_200D_202D_202E((HashAlgorithm)mD5CryptoServiceProvider, _200B_202A_206F_200D_202B_200D_200E_206A_202B_206C_202B_200E_206E_202A_202B_206A_200B_202E_202A_202A_206C_206E_202E_200B_200E_200B_200D_200C_200D_202A_202E_206C_206B_206B_202E_202D_200E_200B_206C_200E_202E((Encoding)uTF8Encoding, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2781687021u)));
					TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = _202A_206B_206C_200C_206E_200D_202A_206E_206A_200B_200D_200E_206B_202D_206E_206A_202A_206D_206A_206F_200C_202E_206D_200B_200E_206C_200B_200D_206D_200B_206B_200B_206D_200F_200C_206C_200E_206A_206C_200D_202E();
					_202D_206B_200B_202C_202A_206C_202B_202C_202E_206D_206C_206D_200E_202B_206D_200B_200F_202A_202C_206B_206C_200C_206A_206F_202C_202E_202E_200D_200B_206D_200F_200E_206E_206A_206C_202C_206F_200D_202D_202A_202E((SymmetricAlgorithm)tripleDESCryptoServiceProvider, array);
					_206C_206C_206A_200C_200E_206E_206A_202E_200C_200B_202E_206D_200D_206D_206C_206A_206F_200E_206D_206F_202B_200F_206C_206B_206F_200F_206D_200D_200B_202D_206A_206C_202C_200D_206C_200C_202B_200C_202D_202A_202E((SymmetricAlgorithm)tripleDESCryptoServiceProvider, CipherMode.ECB);
					_206D_202A_206B_206D_200F_202E_202D_206A_206C_206E_206D_202B_200F_202E_202B_206D_206D_206E_202E_206F_202D_202A_206A_206D_206F_200F_202D_206F_200D_202D_200C_200D_200B_200C_202E_200E_202E_200F_202B_206A_202E((SymmetricAlgorithm)tripleDESCryptoServiceProvider, PaddingMode.PKCS7);
					TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider2 = tripleDESCryptoServiceProvider;
					byte[] array2 = _206A_206E_200D_206E_200F_200B_202D_202D_200F_202A_200B_200C_200B_202C_202E_202E_200F_206D_200F_206A_200F_206E_202E_206D_200C_202C_200D_200E_206F_202A_200E_206B_200F_200B_206E_202C_206D_202E_200E_202C_202E(Message);
					try
					{
						return _206E_206A_200C_202B_200E_202B_202A_202B_206C_200E_206A_206F_200E_206C_202C_202B_202C_206F_200E_202A_200B_206F_200E_206C_202E_206E_206E_206F_206A_202A_206E_200C_200C_206C_206F_202D_200B_200B_200D_200F_202E(_202E_202A_202D_202E_200F_202B_202C_200D_206E_206D_202E_202E_200D_200F_202C_202E_206B_200C_206F_202D_202D_206F_202D_206B_206C_206A_202A_200F_202B_206D_206E_200D_202A_202E_206E_206A_206E_202D_202E_202D_202E((SymmetricAlgorithm)tripleDESCryptoServiceProvider2), array2, 0, array2.Length);
					}
					finally
					{
						_206C_202B_202C_206D_206F_200C_200F_202C_202C_206C_200D_202C_200E_200F_206E_202C_206F_200C_200C_200E_200E_200B_202D_200B_202B_200F_206B_200F_200E_200B_200C_206B_200E_200E_206A_206E_200F_202B_200C_200C_202E((SymmetricAlgorithm)tripleDESCryptoServiceProvider2);
						_202B_206E_200D_200F_206A_206C_200B_206A_202B_200C_200D_200B_200C_200D_200B_202B_200E_206A_200D_206E_202B_200D_206B_206C_202C_200F_200C_202B_202D_200B_202A_202B_200B_202C_206E_206F_202B_200B_202B_206C_202E((HashAlgorithm)mD5CryptoServiceProvider);
					}
				}
				}
				break;
				IL_0029:
				mD5CryptoServiceProvider = _206A_206A_206C_206F_206D_202B_206F_200C_202D_206A_200D_202C_206E_200D_206C_206F_206A_206A_202C_206B_200E_202B_206B_200D_206F_206F_200E_202C_202C_206F_206E_202C_202E_202C_200B_202D_206E_202B_206B_206C_202E();
				num = (int)(num2 * 928185225) ^ -1168098073;
			}
		}
	}

	private static string CRC16_C(byte[] bytes)
	{
		byte b = byte.MaxValue;
		int num3 = default(int);
		byte[] array = default(byte[]);
		int num4 = default(int);
		byte b2 = default(byte);
		byte b4 = default(byte);
		byte b5 = default(byte);
		byte b3 = default(byte);
		while (true)
		{
			int num = 1379650164;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3BF57E0B)) % 17)
				{
				case 3u:
					break;
				case 5u:
				{
					int num6;
					if (num3 >= array.Length)
					{
						num = 1978414180;
						num6 = num;
					}
					else
					{
						num = 1637167285;
						num6 = num;
					}
					continue;
				}
				case 7u:
					array = bytes;
					num3 = 0;
					num = (int)((num2 * 1894211401) ^ 0x66F8F79F);
					continue;
				case 15u:
					num4 = 0;
					num = (int)((num2 * 248012664) ^ 0x4F9E32D2);
					continue;
				case 13u:
					b2 ^= b4;
					num = ((int)num2 * -1630466032) ^ -1527866613;
					continue;
				case 10u:
				{
					int num9;
					if ((b5 & 1) != 1)
					{
						num = 1837946326;
						num9 = num;
					}
					else
					{
						num = 1025416425;
						num9 = num;
					}
					continue;
				}
				case 4u:
					num4++;
					num = 655187786;
					continue;
				case 8u:
				{
					byte num7 = b2;
					b5 = b;
					b2 >>= 1;
					b >>= 1;
					int num8;
					if ((num7 & 1) != 1)
					{
						num = 377738163;
						num8 = num;
					}
					else
					{
						num = 1559614664;
						num8 = num;
					}
					continue;
				}
				case 14u:
					num3++;
					num = ((int)num2 * -1310788383) ^ 0x5C2F8BD7;
					continue;
				case 11u:
					num = ((int)num2 * -1572146457) ^ 0x754467C3;
					continue;
				case 0u:
				{
					int num5;
					if (num4 > 7)
					{
						num = 266017995;
						num5 = num;
					}
					else
					{
						num = 1409202771;
						num5 = num;
					}
					continue;
				}
				case 9u:
					b |= 0x80;
					num = (int)((num2 * 1717166670) ^ 0x1E3CFED9);
					continue;
				case 1u:
					b4 = 160;
					num = ((int)num2 * -929839697) ^ 0x5C1F0C19;
					continue;
				case 12u:
					b ^= array[num3];
					num = 1187346550;
					continue;
				case 2u:
					b ^= b3;
					num = ((int)num2 * -1828179444) ^ -461598634;
					continue;
				case 6u:
					b2 = byte.MaxValue;
					b3 = 1;
					num = (int)(num2 * 540410301) ^ -492701538;
					continue;
				default:
					return _200F_202E_202E_202C_202E_202A_202A_202E_202E_202B_206B_206D_200F_200E_200B_206C_202C_200E_206B_202B_200B_206E_206D_200C_202A_206C_202C_202B_202A_206A_202C_206B_200D_200C_206C_206C_206D_202C_202B_206C_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1266298867u), (object)b2, (object)b);
				}
				break;
			}
		}
	}

	private static string Encrypt(Encoding encode, string source)
	{
		string text = "";
		byte[] array = _200B_202A_206F_200D_202B_200D_200E_206A_202B_206C_202B_200E_206E_202A_202B_206A_200B_202E_202A_202A_206C_206E_202E_200B_200E_200B_200D_200C_200D_202A_202E_206C_206B_206B_202E_202D_200E_200B_206C_200E_202E(encode, source);
		try
		{
			text = _202A_200B_202A_200D_206A_206F_200E_200B_200B_206D_206E_206A_206F_206A_206A_200F_202E_202A_202C_200B_200E_200F_200D_206F_202A_200E_200B_206D_202A_206B_206D_206F_202E_202E_200D_202D_200E_206D_206F_206E_202E(array);
		}
		catch
		{
			text = source;
		}
		array = new byte[0];
		return text;
	}

	private static string Decode(Encoding encode, string result)
	{
		string result2 = "";
		try
		{
			byte[] array = _206A_206E_200D_206E_200F_200B_202D_202D_200F_202A_200B_200C_200B_202C_202E_202E_200F_206D_200F_206A_200F_206E_202E_206D_200C_202C_200D_200E_206F_202A_200E_206B_200F_200B_206E_202C_206D_202E_200E_202C_202E(result);
			result2 = _206D_202B_206B_200D_206F_202D_206C_206A_206D_202C_202C_206D_200C_202C_200F_206D_206F_202C_200B_200C_206D_202B_202D_206B_202D_206C_202D_202C_200F_200D_202C_200B_202E_200D_206F_200F_206F_200F_202A_206D_202E(encode, array);
			array = new byte[0];
		}
		catch
		{
			while (true)
			{
				IL_001f:
				int num = -534017232;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -230198581)) % 3)
					{
					case 0u:
						break;
					default:
						goto end_IL_0024;
					case 2u:
						goto IL_0041;
					case 1u:
						goto end_IL_0024;
					}
					goto IL_001f;
					IL_0041:
					result2 = string.Empty;
					num = (int)((num2 * 268296273) ^ 0x7BB8DC39);
					continue;
					end_IL_0024:
					break;
				}
				break;
			}
		}
		return result2;
	}

	private static string getResult(string zz)
	{
		StringBuilder stringBuilder = _206B_206A_206E_200E_206A_202B_206A_202B_202E_202C_200D_200C_200C_200D_200C_200E_200E_202E_206A_202B_200E_200B_200B_206C_200F_200F_200E_200D_200E_202E_206C_200B_206C_200E_200F_206B_200D_202C_206C_202B_202E();
		int num = 0;
		int num4 = default(int);
		while (true)
		{
			int num2 = -1687338543;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1960577470)) % 12)
				{
				case 8u:
					break;
				case 7u:
					num2 = (int)((num3 * 739514299) ^ 0x4588D9D9);
					continue;
				case 1u:
				{
					int num8;
					int num9;
					if (num4 <= 122)
					{
						num8 = -1550349867;
						num9 = num8;
					}
					else
					{
						num8 = -171537430;
						num9 = num8;
					}
					num2 = num8 ^ ((int)num3 * -1110133119);
					continue;
				}
				case 10u:
				{
					int num11;
					if (num < _206E_202A_200E_206D_200C_206F_202D_206F_200B_200B_200D_206E_200D_202A_206B_202D_200F_206F_202E_200D_206A_200C_202C_202C_200C_206F_206E_202E_202D_200C_202A_202C_200C_206B_200C_206C_206D_202C_206B_202A_202E(zz))
					{
						num2 = -213292817;
						num11 = num2;
					}
					else
					{
						num2 = -201706215;
						num11 = num2;
					}
					continue;
				}
				case 0u:
				{
					int num6;
					int num7;
					if (num4 > 90)
					{
						num6 = 1851289010;
						num7 = num6;
					}
					else
					{
						num6 = 1054212248;
						num7 = num6;
					}
					num2 = num6 ^ ((int)num3 * -322637267);
					continue;
				}
				case 4u:
				{
					int num10;
					if (num4 >= 97)
					{
						num2 = -113305597;
						num10 = num2;
					}
					else
					{
						num2 = -1458778325;
						num10 = num2;
					}
					continue;
				}
				case 5u:
				{
					num4 = _200E_206D_200E_200F_202A_200F_200C_202A_200E_202C_200E_200E_206C_200E_200B_200D_200B_200D_200C_200D_202D_206E_202E_202C_202B_202D_206D_206F_202B_200C_206A_200E_202D_206C_206A_206B_206F_202C_206C_202A_202E(zz, num);
					int num5;
					if (num4 < 65)
					{
						num2 = -1266921670;
						num5 = num2;
					}
					else
					{
						num2 = -282075158;
						num5 = num2;
					}
					continue;
				}
				case 6u:
					num4 -= 32;
					num2 = (int)((num3 * 1421523923) ^ 0x24D276C9);
					continue;
				case 2u:
					num4 += 32;
					num2 = (int)(num3 * 71911269) ^ -1411619201;
					continue;
				case 9u:
					_200F_206C_206D_206F_200B_200E_206B_200F_202B_202B_206A_202B_206C_202A_202C_206C_206D_202A_206B_200B_202A_202A_200F_202A_202B_200F_202E_206C_206E_206B_202E_202B_200F_202A_202E_200E_200F_200D_202A_206E_202E(stringBuilder, (char)num4);
					num++;
					num2 = -755854152;
					continue;
				case 3u:
					num2 = ((int)num3 * -54471694) ^ -666073739;
					continue;
				default:
					return _206D_200E_206E_200B_202C_206A_200F_202E_206A_202D_202E_206D_200B_206A_200F_206B_206A_202C_200C_206A_200F_206B_206C_206F_202E_206B_202A_200B_206A_206B_206E_200E_202D_202C_200F_202E_202A_202E_206F_202E_202E((object)stringBuilder);
				}
				break;
			}
		}
	}

	internal static string Encrypt_Save(string source)
	{
		string text = Encrypt(_206D_202C_202A_202D_200B_202E_202A_206F_200D_206D_206E_200B_202A_200C_206C_200D_202E_206C_202D_206A_206D_206A_202C_206C_206E_206D_206B_206C_200E_200B_202E_200B_206A_202D_200E_200D_202A_206C_202B_206A_202E(), source);
		if (_206A_202C_202B_202A_206F_206B_200B_200B_206E_200F_202D_202A_200D_202C_206D_202B_202D_206F_206C_206E_202B_200C_202E_200D_206D_200C_202A_202A_202E_202A_202E_200C_202E_200C_202E_200F_200D_202C_200D_206F_202E(_202C_206E_206A_202D_200F_200C_202D_206C_200E_206E_202B_200D_200E_202A_206D_200B_206E_202B_206B_202C_206B_200E_200B_202E_206B_206F_200B_200D_200E_202B_202E_200F_206E_202C_202B_206D_200B_206A_202D_200F_202E(text, _206E_202A_200E_206D_200C_206F_202D_206F_200B_200B_200D_206E_200D_202A_206B_202D_200F_206F_202E_200D_206A_200C_202C_202C_200C_206F_206E_202E_202D_200C_202A_202C_200C_206B_200C_206C_206D_202C_206B_202A_202E(text) - 1, 1), global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2222412869u)))
		{
			goto IL_002c;
		}
		goto IL_00a2;
		IL_002c:
		int num = 1671606683;
		goto IL_0031;
		IL_0031:
		int randomInt2 = default(int);
		int num3 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x6FF36C9C)) % 11)
			{
			case 9u:
				break;
			case 7u:
				text = _200D_202E_206E_206F_200F_206B_206C_200C_202E_202B_202D_206B_200E_206D_206F_206A_202A_206D_202C_206B_202A_202C_200B_202B_206B_202E_200F_200B_200E_206D_206B_206F_200F_200F_200C_202B_200B_206C_200F_206E_202E(_202C_206E_206A_202D_200F_200C_202D_206C_200E_206E_202B_200D_200E_202A_206D_200B_206E_202B_206B_202C_206B_200E_200B_202E_206B_206F_200B_200D_200E_202B_202E_200F_206E_202C_202B_206D_200B_206A_202D_200F_202E(text, 0, _206E_202A_200E_206D_200C_206F_202D_206F_200B_200B_200D_206E_200D_202A_206B_202D_200F_206F_202E_200D_206A_200C_202C_202C_200C_206F_206E_202E_202D_200C_202A_202C_200C_206B_200C_206C_206D_202C_206B_202A_202E(text) - 1), global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3653437088u));
				num = (int)((num2 * 1591723451) ^ 0x362F963A);
				continue;
			case 3u:
				goto IL_00a2;
			case 2u:
				randomInt2 = Tools.GetRandomInt(int.Parse(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(615657912u)), int.Parse(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3195878849u)));
				num = ((int)num2 * -384898351) ^ -540537632;
				continue;
			case 10u:
				num3 = 0;
				num = ((int)num2 * -1975220554) ^ 0x6286710D;
				continue;
			case 1u:
				num = (int)((num2 * 391610954) ^ 0x464DF9E5);
				continue;
			case 8u:
				goto IL_011c;
			case 6u:
				num3++;
				num = (int)((num2 * 1100105323) ^ 0x6D95FA2F);
				continue;
			case 5u:
			{
				int randomInt = Tools.GetRandomInt(1, _206E_202A_200E_206D_200C_206F_202D_206F_200B_200B_200D_206E_200D_202A_206B_202D_200F_206F_202E_200D_206A_200C_202C_202C_200C_206F_206E_202E_202D_200C_202A_202C_200C_206B_200C_206C_206D_202C_206B_202A_202E(text) - 2);
				text = _206E_202A_200D_206E_206D_200E_206B_200B_206E_202E_200F_202D_200E_200D_202A_206D_206F_202B_200E_200E_202B_206F_206E_206E_206E_202D_202A_206C_206C_200E_206B_202C_206A_206E_200B_206B_206E_206E_206A_200E_202E(text, randomInt, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2828931079u));
				num = 1920382476;
				continue;
			}
			case 4u:
				text = _200D_202D_206E_206E_202D_202D_202D_200B_206F_202A_200E_202D_200B_200D_202D_200D_206A_206D_202E_206F_200B_202E_200B_200B_206D_200E_202C_206C_202D_200B_206A_202D_202B_200D_200F_200B_206F_206D_206D_206D_202E(_200D_202D_206E_206E_202D_202D_202D_200B_206F_202A_200E_202D_200B_200D_202D_200D_206A_206D_202E_206F_200B_202E_200B_200B_206D_200E_202C_206C_202D_200B_206A_202D_202B_200D_200F_200B_206F_206D_206D_206D_202E(text, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3125426772u), global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3132559320u)), global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(842070870u), global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(88959744u));
				num = (int)(num2 * 1278553190) ^ -185136989;
				continue;
			default:
				return getResult(text);
			}
			break;
			IL_011c:
			int num4;
			if (num3 < randomInt2)
			{
				num = 308403710;
				num4 = num;
			}
			else
			{
				num = 1563627830;
				num4 = num;
			}
		}
		goto IL_002c;
		IL_00a2:
		text = _200D_202E_206E_206F_200F_206B_206C_200C_202E_202B_202D_206B_200E_206D_206F_206A_202A_206D_202C_206B_202A_202C_200B_202B_206B_202E_200F_200B_200E_206D_206B_206F_200F_200F_200C_202B_200B_206C_200F_206E_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1210261586u), text);
		num = 142923964;
		goto IL_0031;
	}

	internal static string Decode_Save(string result)
	{
		if (_206A_202C_202B_202A_206F_206B_200B_200B_206E_200F_202D_202A_200D_202C_206D_202B_202D_206F_206C_206E_202B_200C_202E_200D_206D_200C_202A_202A_202E_202A_202E_200C_202E_200C_202E_200F_200D_202C_200D_206F_202E(_202C_206E_206A_202D_200F_200C_202D_206C_200E_206E_202B_200D_200E_202A_206D_200B_206E_202B_206B_202C_206B_200E_200B_202E_206B_206F_200B_200D_200E_202B_202E_200F_206E_202C_202B_206D_200B_206A_202D_200F_202E(result, _206E_202A_200E_206D_200C_206F_202D_206F_200B_200B_200D_206E_200D_202A_206B_202D_200F_206F_202E_200D_206A_200C_202C_202C_200C_206F_206E_202E_202D_200C_202A_202C_200C_206B_200C_206C_206D_202C_206B_202A_202E(result) - 1, 1), global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1494385060u)))
		{
			goto IL_0023;
		}
		goto IL_00e2;
		IL_0023:
		int num = -1792728186;
		goto IL_0028;
		IL_0028:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -2029488134)) % 5)
			{
			case 4u:
				break;
			case 1u:
				result = _200D_202E_206E_206F_200F_206B_206C_200C_202E_202B_202D_206B_200E_206D_206F_206A_202A_206D_202C_206B_202A_202C_200B_202B_206B_202E_200F_200B_200E_206D_206B_206F_200F_200F_200C_202B_200B_206C_200F_206E_202E(_202C_206E_206A_202D_200F_200C_202D_206C_200E_206E_202B_200D_200E_202A_206D_200B_206E_202B_206B_202C_206B_200E_200B_202E_206B_206F_200B_200D_200E_202B_202E_200F_206E_202C_202B_206D_200B_206A_202D_200F_202E(result, 0, _206E_202A_200E_206D_200C_206F_202D_206F_200B_200B_200D_206E_200D_202A_206B_202D_200F_206F_202E_200D_206A_200C_202C_202C_200C_206F_206E_202E_202D_200C_202A_202C_200C_206B_200C_206C_206D_202C_206B_202A_202E(result) - 1), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2196444027u));
				num = (int)((num2 * 1115797848) ^ 0x7AD15828);
				continue;
			case 2u:
				result = getResult(result);
				result = _200D_202D_206E_206E_202D_202D_202D_200B_206F_202A_200E_202D_200B_200D_202D_200D_206A_206D_202E_206F_200B_202E_200B_200B_206D_200E_202C_206C_202D_200B_206A_202D_202B_200D_200F_200B_206F_206D_206D_206D_202E(_200D_202D_206E_206E_202D_202D_202D_200B_206F_202A_200E_202D_200B_200D_202D_200D_206A_206D_202E_206F_200B_202E_200B_200B_206D_200E_202C_206C_202D_200B_206A_202D_202B_200D_200F_200B_206F_206D_206D_206D_202E(_200D_202D_206E_206E_202D_202D_202D_200B_206F_202A_200E_202D_200B_200D_202D_200D_206A_206D_202E_206F_200B_202E_200B_200B_206D_200E_202C_206C_202D_200B_206A_202D_202B_200D_200F_200B_206F_206D_206D_206D_202E(result, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(951048603u), global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(11348182u)), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1583738914u), ""), global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(831785341u), global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(533767640u));
				num = ((int)num2 * -1755185820) ^ 0x55B98C38;
				continue;
			case 3u:
				goto IL_00e2;
			default:
				return Decode(_206D_202C_202A_202D_200B_202E_202A_206F_200D_206D_206E_200B_202A_200C_206C_200D_202E_206C_202D_206A_206D_206A_202C_206C_206E_206D_206B_206C_200E_200B_202E_200B_206A_202D_200E_200D_202A_206C_202B_206A_202E(), result);
			}
			break;
		}
		goto IL_0023;
		IL_00e2:
		result = _202C_206E_206A_202D_200F_200C_202D_206C_200E_206E_202B_200D_200E_202A_206D_200B_206E_202B_206B_202C_206B_200E_200B_202E_206B_206F_200B_200D_200E_202B_202E_200F_206E_202C_202B_206D_200B_206A_202D_200F_202E(result, 1, _206E_202A_200E_206D_200C_206F_202D_206F_200B_200B_200D_206E_200D_202A_206B_202D_200F_206F_202E_200D_206A_200C_202C_202C_200C_206F_206E_202E_202D_200C_202A_202C_200C_206B_200C_206C_206D_202C_206B_202A_202E(result) - 1);
		num = -1702397095;
		goto IL_0028;
	}

	public static string ExtractString(string str)
	{
		int num = getstr(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3185603339u));
		List<char> list = new List<char>();
		List<char> list2 = default(List<char>);
		string text2 = default(string);
		FileStream fileStream = default(FileStream);
		string text = default(string);
		FileStream fileStream2 = default(FileStream);
		int num5 = default(int);
		byte[] array = default(byte[]);
		int num16 = default(int);
		StringBuilder stringBuilder = default(StringBuilder);
		string text6 = default(string);
		string text3 = default(string);
		int num15 = default(int);
		string text4 = default(string);
		string text5 = default(string);
		byte[] array2 = default(byte[]);
		DESCryptoServiceProvider dESCryptoServiceProvider = default(DESCryptoServiceProvider);
		byte[] bytes2 = default(byte[]);
		string result = default(string);
		while (true)
		{
			int num2 = -886116471;
			while (true)
			{
				int num6;
				int num10;
				int num13;
				uint num3;
				switch ((num3 = (uint)(num2 ^ -804392543)) % 68)
				{
				case 10u:
					break;
				case 24u:
				{
					int num9;
					if (_206E_202A_200E_206D_200C_206F_202D_206F_200B_200B_200D_206E_200D_202A_206B_202D_200F_206F_202E_200D_206A_200C_202C_202C_200C_206F_206E_202E_202D_200C_202A_202C_200C_206B_200C_206C_206D_202C_206B_202A_202E(str) >= int.Parse(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4182824040u)))
					{
						num2 = -1390005294;
						num9 = num2;
					}
					else
					{
						num2 = -1514500674;
						num9 = num2;
					}
					continue;
				}
				case 55u:
					list.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(286952321u), num));
					num2 = -253843477;
					continue;
				case 60u:
					list.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3779958437u), num));
					num2 = ((int)num3 * -1776436698) ^ -1898104118;
					continue;
				case 17u:
					str = _200D_202D_206E_206E_202D_202D_202D_200B_206F_202A_200E_202D_200B_200D_202D_200D_206A_206D_202E_206F_200B_202E_200B_200B_206D_200E_202C_206C_202D_200B_206A_202D_202B_200D_200F_200B_206F_206D_206D_206D_202E(str, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1434420622u), "");
					num2 = ((int)num3 * -1919777851) ^ -1956546275;
					continue;
				case 67u:
				{
					int num35;
					if (_206E_202A_200E_206D_200C_206F_202D_206F_200B_200B_200D_206E_200D_202A_206B_202D_200F_206F_202E_200D_206A_200C_202C_202C_200C_206F_206E_202E_202D_200C_202A_202C_200C_206B_200C_206C_206D_202C_206B_202A_202E(str) >= int.Parse(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2361776119u)))
					{
						num2 = -270740667;
						num35 = num2;
					}
					else
					{
						num2 = -296226487;
						num35 = num2;
					}
					continue;
				}
				case 8u:
					num2 = ((int)num3 * -1896806635) ^ -519615035;
					continue;
				case 53u:
				{
					int num14;
					if (_206E_202A_200E_206D_200C_206F_202D_206F_200B_200B_200D_206E_200D_202A_206B_202D_200F_206F_202E_200D_206A_200C_202C_202C_200C_206F_206E_202E_202D_200C_202A_202C_200C_206B_200C_206C_206D_202C_206B_202A_202E(str) < int.Parse(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3207595833u)))
					{
						num2 = -831966341;
						num14 = num2;
					}
					else
					{
						num2 = -977691532;
						num14 = num2;
					}
					continue;
				}
				case 19u:
					list.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2210834147u), num));
					list2.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1731968239u), num));
					num2 = (int)(num3 * 1110663284) ^ -1077504853;
					continue;
				case 50u:
					list2.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2311773015u), num));
					num2 = ((int)num3 * -49403755) ^ 0x60A9FA3B;
					continue;
				case 44u:
					list.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2210803304u), num));
					list2.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(334960123u), num));
					num2 = (int)((num3 * 934340209) ^ 0x24CCCCFD);
					continue;
				case 15u:
					num2 = ((int)num3 * -2135825056) ^ -1825730103;
					continue;
				case 22u:
					list2.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3617332917u), num));
					num2 = (int)(num3 * 1477371243) ^ -723748276;
					continue;
				case 28u:
					text2 = null;
					num2 = -1326991969;
					continue;
				case 64u:
					list2 = new List<char>();
					num2 = ((int)num3 * -663736116) ^ -533369376;
					continue;
				case 4u:
					if (_206F_206A_202A_202D_206E_206F_206C_206C_200B_200C_206C_206C_206A_200D_202D_206E_200C_200C_202D_200D_206E_200D_202B_206D_202E_206C_200B_206A_200C_206F_206F_202E_206F_202B_200D_206B_200E_206E_206B_200E_202E == null)
					{
						num2 = ((int)num3 * -415910477) ^ 0x7DD35518;
						continue;
					}
					goto IL_1203;
				case 23u:
					list.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1352151979u), num));
					list2.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(571851872u), num));
					num2 = (int)((num3 * 1860964876) ^ 0x6C9A17A9);
					continue;
				case 59u:
					str = Decode(_206D_202C_202A_202D_200B_202E_202A_206F_200D_206D_206E_200B_202A_200C_206C_200D_202E_206C_202D_206A_206D_206A_202C_206C_206E_206D_206B_206C_200E_200B_202E_200B_206A_202D_200E_200D_202A_206C_202B_206A_202E(), _202C_206E_206A_202D_200F_200C_202D_206C_200E_206E_202B_200D_200E_202A_206D_200B_206E_202B_206B_202C_206B_200E_200B_202E_206B_206F_200B_200D_200E_202B_202E_200F_206E_202C_202B_206D_200B_206A_202D_200F_202E(str, int.Parse(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2561488174u)), _206E_202A_200E_206D_200C_206F_202D_206F_200B_200B_200D_206E_200D_202A_206B_202D_200F_206F_202E_200D_206A_200C_202C_202C_200C_206F_206E_202E_202D_200C_202A_202C_200C_206B_200C_206C_206D_202C_206B_202A_202E(str) - int.Parse(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3634177857u))));
					num2 = ((int)num3 * -1476690718) ^ 0x15200266;
					continue;
				case 20u:
					str = Decode(_206D_202C_202A_202D_200B_202E_202A_206F_200D_206D_206E_200B_202A_200C_206C_200D_202E_206C_202D_206A_206D_206A_202C_206C_206E_206D_206B_206C_200E_200B_202E_200B_206A_202D_200E_200D_202A_206C_202B_206A_202E(), _202C_206E_206A_202D_200F_200C_202D_206C_200E_206E_202B_200D_200E_202A_206D_200B_206E_202B_206B_202C_206B_200E_200B_202E_206B_206F_200B_200D_200E_202B_202E_200F_206E_202C_202B_206D_200B_206A_202D_200F_202E(str, int.Parse(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(297134813u)), _206E_202A_200E_206D_200C_206F_202D_206F_200B_200B_200D_206E_200D_202A_206B_202D_200F_206F_202E_200D_206A_200C_202C_202C_200C_206F_206E_202E_202D_200C_202A_202C_200C_206B_200C_206C_206D_202C_206B_202A_202E(str) - int.Parse(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3297365172u))));
					str = _202C_206E_206A_202D_200F_200C_202D_206C_200E_206E_202B_200D_200E_202A_206D_200B_206E_202B_206B_202C_206B_200E_200B_202E_206B_206F_200B_200D_200E_202B_202E_200F_206E_202C_202B_206D_200B_206A_202D_200F_202E(str, 0, _206E_202A_200E_206D_200C_206F_202D_206F_200B_200B_200D_206E_200D_202A_206B_202D_200F_206F_202E_200D_206A_200C_202C_202C_200C_206F_206E_202E_202D_200C_202A_202C_200C_206B_200C_206C_206D_202C_206B_202A_202E(str) - int.Parse(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(615657912u)));
					num2 = ((int)num3 * -1331963913) ^ 0x28DA29DA;
					continue;
				case 48u:
					list.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1335848704u), num));
					num2 = ((int)num3 * -1333988098) ^ -738833332;
					continue;
				case 43u:
					list2.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1586730736u), num));
					list.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3881481368u), num));
					list2.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3064530486u), num));
					ProcessChar(str, list, list2);
					str = Decode(_206D_202C_202A_202D_200B_202E_202A_206F_200D_206D_206E_200B_202A_200C_206C_200D_202E_206C_202D_206A_206D_206A_202C_206C_206E_206D_206B_206C_200E_200B_202E_200B_206A_202D_200E_200D_202A_206C_202B_206A_202E(), _202C_206E_206A_202D_200F_200C_202D_206C_200E_206E_202B_200D_200E_202A_206D_200B_206E_202B_206B_202C_206B_200E_200B_202E_206B_206F_200B_200D_200E_202B_202E_200F_206E_202C_202B_206D_200B_206A_202D_200F_202E(str, int.Parse(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2158003346u)), _206E_202A_200E_206D_200C_206F_202D_206F_200B_200B_200D_206E_200D_202A_206B_202D_200F_206F_202E_200D_206A_200C_202C_202C_200C_206F_206E_202E_202D_200C_202A_202C_200C_206B_200C_206C_206D_202C_206B_202A_202E(str) - int.Parse(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(899446058u))));
					str = _202C_206E_206A_202D_200F_200C_202D_206C_200E_206E_202B_200D_200E_202A_206D_200B_206E_202B_206B_202C_206B_200E_200B_202E_206B_206F_200B_200D_200E_202B_202E_200F_206E_202C_202B_206D_200B_206A_202D_200F_202E(str, 0, _206E_202A_200E_206D_200C_206F_202D_206F_200B_200B_200D_206E_200D_202A_206B_202D_200F_206F_202E_200D_206A_200C_202C_202C_200C_206F_206E_202E_202D_200C_202A_202C_200C_206B_200C_206C_206D_202C_206B_202A_202E(str) - int.Parse(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3107145481u)));
					num2 = (int)(num3 * 242340480) ^ -1663517952;
					continue;
				case 58u:
					ProcessChar(str, list, list2);
					str = Decode(_206D_202C_202A_202D_200B_202E_202A_206F_200D_206D_206E_200B_202A_200C_206C_200D_202E_206C_202D_206A_206D_206A_202C_206C_206E_206D_206B_206C_200E_200B_202E_200B_206A_202D_200E_200D_202A_206C_202B_206A_202E(), _202C_206E_206A_202D_200F_200C_202D_206C_200E_206E_202B_200D_200E_202A_206D_200B_206E_202B_206B_202C_206B_200E_200B_202E_206B_206F_200B_200D_200E_202B_202E_200F_206E_202C_202B_206D_200B_206A_202D_200F_202E(str, int.Parse(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3634177857u)), _206E_202A_200E_206D_200C_206F_202D_206F_200B_200B_200D_206E_200D_202A_206B_202D_200F_206F_202E_200D_206A_200C_202C_202C_200C_206F_206E_202E_202D_200C_202A_202C_200C_206B_200C_206C_206D_202C_206B_202A_202E(str) - int.Parse(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3405589176u))));
					num2 = (int)((num3 * 1972513695) ^ 0x29DFC89C);
					continue;
				case 39u:
					list2.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(571851872u), num));
					num2 = (int)((num3 * 1800417304) ^ 0x130D3F4C);
					continue;
				case 37u:
					num2 = (int)(num3 * 1620693094) ^ -1350212145;
					continue;
				case 47u:
					list.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3047750739u), num));
					num2 = (int)((num3 * 1583774270) ^ 0x62027373);
					continue;
				case 51u:
					list2.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(706933404u), num));
					num2 = ((int)num3 * -877869009) ^ -330622345;
					continue;
				case 35u:
				{
					int num12;
					if (_206E_202A_200E_206D_200C_206F_202D_206F_200B_200B_200D_206E_200D_202A_206B_202D_200F_206F_202E_200D_206A_200C_202C_202C_200C_206F_206E_202E_202D_200C_202A_202C_200C_206B_200C_206C_206D_202C_206B_202A_202E(str) < int.Parse(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(798341947u)))
					{
						num2 = -1534536926;
						num12 = num2;
					}
					else
					{
						num2 = -401404608;
						num12 = num2;
					}
					continue;
				}
				case 42u:
					list.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3144276304u), num));
					list2.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3919216861u), num));
					list.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1181690307u), num));
					num2 = ((int)num3 * -1420431321) ^ 0x26B2D91F;
					continue;
				case 30u:
					list.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1176699714u), num));
					num2 = (int)(num3 * 1962094436) ^ -1792904685;
					continue;
				case 40u:
					list2.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1634516223u), num));
					num2 = ((int)num3 * -1098008453) ^ -1180695873;
					continue;
				case 54u:
					num2 = (int)((num3 * 1205462938) ^ 0x732B68E5);
					continue;
				case 6u:
					list2.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1401287812u), num));
					list.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3791675421u), num));
					list2.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1124241436u), num));
					ProcessChar(str, list, list2);
					num2 = (int)((num3 * 60054465) ^ 0x6D9B478D);
					continue;
				case 16u:
					list.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3831560982u), num));
					num2 = ((int)num3 * -195456971) ^ 0x4A15FE3B;
					continue;
				case 33u:
					fileStream = _202C_206B_202B_200F_202E_202A_206B_200F_202B_206D_206D_206C_206A_200C_206A_202C_206C_200B_206D_202A_202A_200E_206E_206B_200C_200F_206A_202C_202C_202D_200F_206E_206A_206B_200F_202A_202A_200B_206A_206E_202E(text, FileMode.Open);
					num2 = ((int)num3 * -856042451) ^ 0x36E3234C;
					continue;
				case 13u:
				{
					int num11;
					if (_206E_202A_200E_206D_200C_206F_202D_206F_200B_200B_200D_206E_200D_202A_206B_202D_200F_206F_202E_200D_206A_200C_202C_202C_200C_206F_206E_202E_202D_200C_202A_202C_200C_206B_200C_206C_206D_202C_206B_202A_202E(str) < int.Parse(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3155993288u)))
					{
						num2 = -821512017;
						num11 = num2;
					}
					else
					{
						num2 = -1295876554;
						num11 = num2;
					}
					continue;
				}
				case 49u:
					list2.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2068745873u), num));
					ProcessChar(str, list, list2);
					num2 = (int)(num3 * 2018870615) ^ -2124658891;
					continue;
				case 5u:
					list.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3047750739u), num));
					num2 = ((int)num3 * -1132843570) ^ -278868249;
					continue;
				case 56u:
					list2.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(571851872u), num));
					num2 = (int)((num3 * 625066849) ^ 0x4C7CC4C6);
					continue;
				case 25u:
					num2 = ((int)num3 * -229433081) ^ -995802202;
					continue;
				case 18u:
					text = _202B_200F_202B_202E_206E_200E_206D_206B_200D_206B_206C_202A_202E_200F_200B_202B_200F_206E_200E_200E_206E_206E_202D_200E_206A_202C_202A_202E_202A_200C_202D_200E_200C_206D_206D_202A_200B_206B_200C_206A_202E(CommonSettings.persistentDataPath, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3105682201u), GlobalData.CurrentMod.key, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(677705088u));
					num2 = (int)((num3 * 920177554) ^ 0x3F61E09D);
					continue;
				case 65u:
					list.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2399511612u), num));
					num2 = (int)((num3 * 1170554637) ^ 0x7C66B621);
					continue;
				case 3u:
					ProcessChar(str, list, list2);
					num2 = (int)(num3 * 77272297) ^ -395397840;
					continue;
				case 41u:
					list2.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3338969500u), num));
					num2 = (int)(num3 * 192929041) ^ -591550729;
					continue;
				case 7u:
					list.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1408103265u), num));
					num2 = ((int)num3 * -1649459805) ^ -439645824;
					continue;
				case 0u:
					fileStream2 = getobject(fileStream);
					if (fileStream == fileStream2)
					{
						num2 = ((int)num3 * -1770874821) ^ 0x5DF9F788;
						continue;
					}
					goto IL_122b;
				case 1u:
					fileStream = _202C_206B_202B_200F_202E_202A_206B_200F_202B_206D_206D_206C_206A_200C_206A_202C_206C_200B_206D_202A_202A_200E_206E_206B_200C_200F_206A_202C_202C_202D_200F_206E_206A_206B_200F_202A_202A_200B_206A_206E_202E(text, FileMode.Create);
					num2 = ((int)num3 * -1589972005) ^ 0x55B7E93A;
					continue;
				case 29u:
					_206F_206F_200B_202E_200F_206F_206B_206C_206C_206F_206B_202B_206B_200E_200B_202B_200E_200E_202E_206A_206C_200B_200E_206A_202D_206C_202E_206E_200D_200B_206B_206B_200E_206F_202E_202D_202A_200B_206C_202D_202E((Stream)fileStream);
					num2 = (int)(num3 * 1888943014) ^ -1349467739;
					continue;
				case 66u:
					list.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2814602035u), num));
					num2 = ((int)num3 * -1758247926) ^ -1639976462;
					continue;
				case 57u:
					list2.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3825204083u), num));
					num2 = ((int)num3 * -597438475) ^ -1683515286;
					continue;
				case 11u:
					str = Decode(_206D_202C_202A_202D_200B_202E_202A_206F_200D_206D_206E_200B_202A_200C_206C_200D_202E_206C_202D_206A_206D_206A_202C_206C_206E_206D_206B_206C_200E_200B_202E_200B_206A_202D_200E_200D_202A_206C_202B_206A_202E(), _202C_206E_206A_202D_200F_200C_202D_206C_200E_206E_202B_200D_200E_202A_206D_200B_206E_202B_206B_202C_206B_200E_200B_202E_206B_206F_200B_200D_200E_202B_202E_200F_206E_202C_202B_206D_200B_206A_202D_200F_202E(str, int.Parse(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2658727182u)), _206E_202A_200E_206D_200C_206F_202D_206F_200B_200B_200D_206E_200D_202A_206B_202D_200F_206F_202E_200D_206A_200C_202C_202C_200C_206F_206E_202E_202D_200C_202A_202C_200C_206B_200C_206C_206D_202C_206B_202A_202E(str) - int.Parse(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2701395556u))));
					num2 = ((int)num3 * -260017386) ^ 0xA354DCB;
					continue;
				case 52u:
					list2.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2331525559u), num));
					num2 = ((int)num3 * -1264889128) ^ 0x60801ADF;
					continue;
				case 34u:
					str = Decode(_206D_202C_202A_202D_200B_202E_202A_206F_200D_206D_206E_200B_202A_200C_206C_200D_202E_206C_202D_206A_206D_206A_202C_206C_206E_206D_206B_206C_200E_200B_202E_200B_206A_202D_200E_200D_202A_206C_202B_206A_202E(), _202C_206E_206A_202D_200F_200C_202D_206C_200E_206E_202B_200D_200E_202A_206D_200B_206E_202B_206B_202C_206B_200E_200B_202E_206B_206F_200B_200D_200E_202B_202E_200F_206E_202C_202B_206D_200B_206A_202D_200F_202E(str, int.Parse(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3297365172u)), _206E_202A_200E_206D_200C_206F_202D_206F_200B_200B_200D_206E_200D_202A_206B_202D_200F_206F_202E_200D_206A_200C_202C_202C_200C_206F_206E_202E_202D_200C_202A_202C_200C_206B_200C_206C_206D_202C_206B_202A_202E(str) - int.Parse(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3924386257u))));
					str = _202C_206E_206A_202D_200F_200C_202D_206C_200E_206E_202B_200D_200E_202A_206D_200B_206E_202B_206B_202C_206B_200E_200B_202E_206B_206F_200B_200D_200E_202B_202E_200F_206E_202C_202B_206D_200B_206A_202D_200F_202E(str, 0, _206E_202A_200E_206D_200C_206F_202D_206F_200B_200B_200D_206E_200D_202A_206B_202D_200F_206F_202E_200D_206A_200C_202C_202C_200C_206F_206E_202E_202D_200C_202A_202C_200C_206B_200C_206C_206D_202C_206B_202A_202E(str) - int.Parse(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3107145481u)));
					num2 = (int)(num3 * 2062010392) ^ -329173169;
					continue;
				case 26u:
					list.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(20888603u), num));
					num2 = ((int)num3 * -486227892) ^ 0x9131AC2;
					continue;
				case 63u:
					list.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1414484887u), num));
					num2 = (int)((num3 * 2144286813) ^ 0x7CB70D0F);
					continue;
				case 9u:
					str = _202C_206E_206A_202D_200F_200C_202D_206C_200E_206E_202B_200D_200E_202A_206D_200B_206E_202B_206B_202C_206B_200E_200B_202E_206B_206F_200B_200D_200E_202B_202E_200F_206E_202C_202B_206D_200B_206A_202D_200F_202E(str, 0, _206E_202A_200E_206D_200C_206F_202D_206F_200B_200B_200D_206E_200D_202A_206B_202D_200F_206F_202E_200D_206A_200C_202C_202C_200C_206F_206E_202E_202D_200C_202A_202C_200C_206B_200C_206C_206D_202C_206B_202A_202E(str) - int.Parse(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3107145481u)));
					num2 = (int)(num3 * 1141014481) ^ -1222052512;
					continue;
				case 36u:
					list2.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3550873118u), num));
					num2 = ((int)num3 * -1303993254) ^ -1303517634;
					continue;
				case 12u:
					str = _202C_206E_206A_202D_200F_200C_202D_206C_200E_206E_202B_200D_200E_202A_206D_200B_206E_202B_206B_202C_206B_200E_200B_202E_206B_206F_200B_200D_200E_202B_202E_200F_206E_202C_202B_206D_200B_206A_202D_200F_202E(str, 0, _206E_202A_200E_206D_200C_206F_202D_206F_200B_200B_200D_206E_200D_202A_206B_202D_200F_206F_202E_200D_206A_200C_202C_202C_200C_206F_206E_202E_202D_200C_202A_202C_200C_206B_200C_206C_206D_202C_206B_202A_202E(str) - int.Parse(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(615657912u)));
					num2 = ((int)num3 * -571145251) ^ 0x8F87399;
					continue;
				case 14u:
					ProcessChar(str, list, list2);
					num2 = ((int)num3 * -11197331) ^ -145917557;
					continue;
				case 32u:
					fileStream2 = fileStream;
					_200E_206A_200D_202D_202E_200D_200C_206D_206C_200C_202A_200C_202D_206E_206E_200E_206B_206E_202C_202C_200D_206A_200D_200C_200E_206F_202D_206B_202B_206C_206A_202D_206C_206F_202C_206B_202E_200D_200C_206E_202E((HashAlgorithm)_206A_206A_206C_206F_206D_202B_206F_200C_202D_206A_200D_202C_206E_200D_206C_206F_206A_206A_202C_206B_200E_202B_206B_200D_206F_206F_200E_202C_202C_206F_206E_202C_202E_202C_200B_202D_206E_202B_206B_206C_202E(), (Stream)fileStream);
					num2 = ((int)num3 * -513154517) ^ 0x5C946E0C;
					continue;
				case 45u:
					str = _202C_206E_206A_202D_200F_200C_202D_206C_200E_206E_202B_200D_200E_202A_206D_200B_206E_202B_206B_202C_206B_200E_200B_202E_206B_206F_200B_200D_200E_202B_202E_200F_206E_202C_202B_206D_200B_206A_202D_200F_202E(str, 0, _206E_202A_200E_206D_200C_206F_202D_206F_200B_200B_200D_206E_200D_202A_206B_202D_200F_206F_202E_200D_206A_200C_202C_202C_200C_206F_206E_202E_202D_200C_202A_202C_200C_206B_200C_206C_206D_202C_206B_202A_202E(str) - int.Parse(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3297365172u)));
					num2 = (int)(num3 * 1370173968) ^ -443171960;
					continue;
				case 61u:
				{
					int num7;
					int num8;
					if (_206E_202A_200E_206D_200C_206F_202D_206F_200B_200B_200D_206E_200D_202A_206B_202D_200F_206F_202E_200D_206A_200C_202C_202C_200C_206F_206E_202E_202D_200C_202A_202C_200C_206B_200C_206C_206D_202C_206B_202A_202E(str) < int.Parse(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2324040626u)))
					{
						num7 = 1367672819;
						num8 = num7;
					}
					else
					{
						num7 = 2073834033;
						num8 = num7;
					}
					num2 = num7 ^ ((int)num3 * -1196430445);
					continue;
				}
				case 31u:
					ProcessChar(str, list, list2);
					num2 = ((int)num3 * -1005463646) ^ 0x6DF5CE30;
					continue;
				case 46u:
					list2.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3825204083u), num));
					num2 = ((int)num3 * -1532132064) ^ 0x1AF5B8B;
					continue;
				case 2u:
					str = Decode(_206D_202C_202A_202D_200B_202E_202A_206F_200D_206D_206E_200B_202A_200C_206C_200D_202E_206C_202D_206A_206D_206A_202C_206C_206E_206D_206B_206C_200E_200B_202E_200B_206A_202D_200E_200D_202A_206C_202B_206A_202E(), _202C_206E_206A_202D_200F_200C_202D_206C_200E_206E_202B_200D_200E_202A_206D_200B_206E_202B_206B_202C_206B_200E_200B_202E_206B_206F_200B_200D_200E_202B_202E_200F_206E_202C_202B_206D_200B_206A_202D_200F_202E(str, int.Parse(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(102125437u)), _206E_202A_200E_206D_200C_206F_202D_206F_200B_200B_200D_206E_200D_202A_206B_202D_200F_206F_202E_200D_206A_200C_202C_202C_200C_206F_206E_202E_202D_200C_202A_202C_200C_206B_200C_206C_206D_202C_206B_202A_202E(str) - int.Parse(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(179736999u))));
					num2 = ((int)num3 * -1726241317) ^ -735045558;
					continue;
				case 21u:
					list.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3821036182u), num));
					num2 = ((int)num3 * -458532229) ^ 0x1199F3AC;
					continue;
				case 27u:
					str = _202C_206E_206A_202D_200F_200C_202D_206C_200E_206E_202B_200D_200E_202A_206D_200B_206E_202B_206B_202C_206B_200E_200B_202E_206B_206F_200B_200D_200E_202B_202E_200F_206E_202C_202B_206D_200B_206A_202D_200F_202E(str, 0, _206E_202A_200E_206D_200C_206F_202D_206F_200B_200B_200D_206E_200D_202A_206B_202D_200F_206F_202E_200D_206A_200C_202C_202C_200C_206F_206E_202E_202D_200C_202A_202C_200C_206B_200C_206C_206D_202C_206B_202A_202E(str) - int.Parse(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3107145481u)));
					num2 = (int)(num3 * 1701048719) ^ -1148709896;
					continue;
				case 38u:
					list.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3853811799u), num));
					list2.Add((char)_206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1546845175u), num));
					num2 = (int)(num3 * 480668243) ^ -1733298262;
					continue;
				default:
					{
						_206B_206B_206A_200C_200E_202B_202D_200F_202A_200B_202D_202A_206C_206A_200C_202D_200B_202A_200F_200F_200F_206F_206F_202E_206F_200E_206B_202E_206C_202E_202D_206B_206A_206D_200C_200E_206B_202D_200E_200E_202E((Stream)fileStream);
						fileStream = null;
						try
						{
							_206F_206F_200B_202E_200F_206F_206B_206C_206C_206F_206B_202B_206B_200E_200B_202B_200E_200E_202E_206A_206C_200B_200E_206A_202D_206C_202E_206E_200D_200B_206B_206B_200E_206F_202E_202D_202A_200B_206C_202D_202E((Stream)fileStream2);
							while (true)
							{
								IL_0da8:
								int num4 = -576262461;
								while (true)
								{
									switch ((num3 = (uint)(num4 ^ -804392543)) % 4)
									{
									case 0u:
										break;
									default:
										goto end_IL_0dad;
									case 2u:
										_206B_206B_206A_200C_200E_202B_202D_200F_202A_200B_202D_202A_206C_206A_200C_202D_200B_202A_200F_200F_200F_206F_206F_202E_206F_200E_206B_202E_206C_202E_202D_206B_206A_206D_200C_200E_206B_202D_200E_200E_202E((Stream)fileStream2);
										num4 = (int)(num3 * 1429947952) ^ -1318478582;
										continue;
									case 3u:
										fileStream2 = null;
										num4 = (int)(num3 * 422878497) ^ -624141237;
										continue;
									case 1u:
										goto end_IL_0dad;
									}
									goto IL_0da8;
									continue;
									end_IL_0dad:
									break;
								}
								break;
							}
						}
						catch
						{
						}
						num5 = 0;
						goto IL_0eda;
					}
					IL_122b:
					array = _200E_206A_200D_202D_202E_200D_200C_206D_206C_200C_202A_200C_202D_206E_206E_200E_206B_206E_202C_202C_200D_206A_200D_200C_200E_206F_202D_206B_202B_206C_206A_202D_206C_206F_202C_206B_202E_200D_200C_206E_202E((HashAlgorithm)_206A_206A_206C_206F_206D_202B_206F_200C_202D_206A_200D_202C_206E_200D_206C_206F_206A_206A_202C_206B_200E_202B_206B_200D_206F_206F_200E_202C_202C_206F_206E_202C_202E_202C_200B_202D_206E_202B_206B_206C_202E(), (Stream)fileStream);
					num6 = -230010057;
					goto IL_0e0b;
					IL_0eda:
					if (num5 < 1000000)
					{
						num6 = -2019911610;
						num10 = num6;
					}
					else
					{
						num6 = -332169462;
						num10 = num6;
					}
					goto IL_0e0b;
					IL_1203:
					if (text2 == null)
					{
						num6 = -934753508;
						num13 = num6;
					}
					else
					{
						num6 = -94982092;
						num13 = num6;
					}
					goto IL_0e0b;
					IL_0e0b:
					while (true)
					{
						switch ((num3 = (uint)(num6 ^ -804392543)) % 33)
						{
						case 6u:
							num6 = -2019911610;
							continue;
						case 17u:
							break;
						case 23u:
							array = null;
							num6 = (int)(num3 * 1333911058) ^ -1352886331;
							continue;
						case 8u:
							goto end_IL_0e0b;
						case 24u:
							num16++;
							num6 = ((int)num3 * -1403857330) ^ 0x38836062;
							continue;
						case 19u:
							goto IL_0f10;
						case 25u:
							num5++;
							num6 = -797836903;
							continue;
						case 7u:
							goto IL_0f3d;
						case 1u:
							text = "";
							num6 = ((int)num3 * -1675742499) ^ 0x2AD51DA9;
							continue;
						case 31u:
						{
							int num19;
							int num20;
							if (num5 <= -1)
							{
								num19 = -386978409;
								num20 = num19;
							}
							else
							{
								num19 = -106849392;
								num20 = num19;
							}
							num6 = num19 ^ (int)(num3 * 1006919298);
							continue;
						}
						case 27u:
							text2 = null;
							_206F_206A_202A_202D_206E_206F_206C_206C_200B_200C_206C_206C_206A_200D_202D_206E_200C_200C_202D_200D_206E_200D_202B_206D_202E_206C_200B_206A_200C_206F_206F_202E_206F_202B_200D_206B_200E_206E_206B_200E_202E = stringBuilder.ToString().ToLower();
							stringBuilder = new StringBuilder();
							num6 = ((int)num3 * -652453347) ^ 0x899FDF;
							continue;
						case 21u:
						{
							text6 = RuntimeData.Instance.GetAsc2(text3).ToString();
							int num17;
							int num18;
							if (text6.Length <= int.Parse(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3297365172u)))
							{
								num17 = 1831828520;
								num18 = num17;
							}
							else
							{
								num17 = 906534013;
								num18 = num17;
							}
							num6 = num17 ^ ((int)num3 * -1801930115);
							continue;
						}
						case 15u:
							_206F_206F_200B_202E_200F_206F_206B_206C_206C_206F_206B_202B_206B_200E_200B_202B_200E_200E_202E_206A_206C_200B_200E_206A_202D_206C_202E_206E_200D_200B_206B_206B_200E_206F_202E_202D_202A_200B_206C_202D_202E((Stream)fileStream);
							_206B_206B_206A_200C_200E_202B_202D_200F_202A_200B_202D_202A_206C_206A_200C_202D_200B_202A_200F_200F_200F_206F_206F_202E_206F_200E_206B_202E_206C_202E_202D_206B_206A_206D_200C_200E_206B_202D_200E_200E_202E((Stream)fileStream);
							fileStream = null;
							num6 = (int)((num3 * 1014541181) ^ 0x1BB5A34B);
							continue;
						case 5u:
							stringBuilder = _206B_206A_206E_200E_206A_202B_206A_202B_202E_202C_200D_200C_200C_200D_200C_200E_200E_202E_206A_202B_200E_200B_200B_206C_200F_200F_200E_200D_200E_202E_206C_200B_206C_200E_200F_206B_200D_202C_206C_202B_202E();
							num6 = (int)(num3 * 2128488505) ^ -197026439;
							continue;
						case 14u:
							num6 = (int)(num3 * 1017358180) ^ -1026187640;
							continue;
						case 22u:
							num15++;
							num6 = -475415504;
							continue;
						case 3u:
							num6 = ((int)num3 * -567400072) ^ -2045960699;
							continue;
						case 4u:
							text2 = text.Remove(0, text.Length + int.Parse(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(454430411u)));
							num6 = ((int)num3 * -514791102) ^ 0x445801DA;
							continue;
						case 0u:
							text6 += global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2540932728u);
							num6 = -1992222067;
							continue;
						case 16u:
							text6 = text6.Substring(int.Parse(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3545379680u)), int.Parse(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3297365172u)));
							num6 = ((int)num3 * -250085003) ^ 0x3D4ADA63;
							continue;
						case 12u:
							goto IL_1151;
						case 29u:
							stringBuilder.Append(array[num16].ToString(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2332510825u)));
							num6 = -1732268488;
							continue;
						case 9u:
							num16 = 0;
							num6 = (int)(num3 * 1003677837) ^ -991380040;
							continue;
						case 13u:
							text3 = text;
							num6 = (int)((num3 * 2026666874) ^ 0x14D2865A);
							continue;
						case 28u:
							num6 = (int)(num3 * 713285323) ^ -568863563;
							continue;
						case 30u:
							goto IL_11d7;
						case 26u:
							goto IL_1203;
						case 20u:
							text4 = _206F_206A_202A_202D_206E_206F_206C_206C_200B_200C_206C_206C_206A_200D_202D_206E_200C_200C_202D_200D_206E_200D_202B_206D_202E_206C_200B_206A_200C_206F_206F_202E_206F_202B_200D_206B_200E_206E_206B_200E_202E;
							num6 = -1729565769;
							continue;
						case 11u:
							goto IL_122b;
						case 32u:
							text5 = text3;
							num15 = 0;
							num6 = ((int)num3 * -1572083360) ^ -1339421296;
							continue;
						case 10u:
							_206F_206A_202A_202D_206E_206F_206C_206C_200B_200C_206C_206C_206A_200D_202D_206E_200C_200C_202D_200D_206E_200D_202B_206D_202E_206C_200B_206A_200C_206F_206F_202E_206F_202B_200D_206B_200E_206E_206B_200E_202E = null;
							num6 = -1881804764;
							continue;
						case 18u:
							text3 += (char)(text4[num15] - int.Parse(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2516713222u)));
							num6 = ((int)num3 * -1918613876) ^ -805270102;
							continue;
						default:
							goto IL_12ac;
						}
						int num21;
						if (num15 >= text4.Length)
						{
							num6 = -1030775576;
							num21 = num6;
						}
						else
						{
							num6 = -755577844;
							num21 = num6;
						}
						continue;
						IL_11d7:
						int num22;
						if (text6.Length < int.Parse(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3107145481u)))
						{
							num6 = -722790099;
							num22 = num6;
						}
						else
						{
							num6 = -925699120;
							num22 = num6;
						}
						continue;
						IL_0f3d:
						text5 += (char)(num15 + int.Parse(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1606011768u)));
						int num23;
						if (text5.Length % int.Parse(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2237430000u)) == int.Parse(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2561488174u)))
						{
							num6 = -1632212857;
							num23 = num6;
						}
						else
						{
							num6 = -1261393566;
							num23 = num6;
						}
						continue;
						IL_0f10:
						int num24;
						if (num5 > 1000000)
						{
							num6 = -1633991133;
							num24 = num6;
						}
						else
						{
							num6 = -1576687365;
							num24 = num6;
						}
						continue;
						IL_1151:
						int num25;
						if (num16 < array.Length)
						{
							num6 = -2133802241;
							num25 = num6;
						}
						else
						{
							num6 = -389292634;
							num25 = num6;
						}
						continue;
						end_IL_0e0b:
						break;
					}
					goto IL_0eda;
					IL_12ac:
					if (str.IndexOf(text2, (int)((float)str.Length * 0.074f), StringComparison.Ordinal) > 0)
					{
						try
						{
							byte[] bytes = Encoding.UTF8.GetBytes(text6);
							while (true)
							{
								IL_12d6:
								int num26 = -1865986573;
								while (true)
								{
									switch ((num3 = (uint)(num26 ^ -804392543)) % 5)
									{
									case 3u:
										break;
									default:
										goto end_IL_12db;
									case 1u:
										array2 = Convert.FromBase64String(str);
										dESCryptoServiceProvider = new DESCryptoServiceProvider();
										num26 = ((int)num3 * -1869041547) ^ 0x3C7414A3;
										continue;
									case 4u:
									{
										MemoryStream memoryStream = new MemoryStream();
										CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateDecryptor(bytes, bytes), CryptoStreamMode.Write);
										cryptoStream.Write(array2, 0, array2.Length);
										cryptoStream.FlushFinalBlock();
										bytes2 = memoryStream.ToArray();
										cryptoStream.Close();
										memoryStream.Close();
										num26 = ((int)num3 * -1972900321) ^ -623368091;
										continue;
									}
									case 0u:
										result = Encoding.UTF8.GetString(bytes2);
										num26 = (int)(num3 * 306934989) ^ -1710593638;
										continue;
									case 2u:
										goto end_IL_12db;
									}
									goto IL_12d6;
									continue;
									end_IL_12db:
									break;
								}
								break;
							}
						}
						catch
						{
							while (true)
							{
								IL_139f:
								int num27 = -1077268645;
								while (true)
								{
									switch ((num3 = (uint)(num27 ^ -804392543)) % 3)
									{
									case 0u:
										break;
									default:
										goto end_IL_13a4;
									case 2u:
										goto IL_13c2;
									case 1u:
										goto end_IL_13a4;
									}
									goto IL_139f;
									IL_13c2:
									result = str;
									num27 = (int)(num3 * 643502294) ^ -445774862;
									continue;
									end_IL_13a4:
									break;
								}
								break;
							}
						}
					}
					else
					{
						string s = str.Substring(int.Parse(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1835911187u)), int.Parse(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2561488174u)));
						while (true)
						{
							int num28 = -1120362956;
							while (true)
							{
								switch ((num3 = (uint)(num28 ^ -804392543)) % 13)
								{
								case 10u:
									break;
								case 12u:
								{
									int num29;
									int num30;
									if (int.Parse(s) < int.Parse(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1785458195u)))
									{
										num29 = 209902390;
										num30 = num29;
									}
									else
									{
										num29 = 1462784290;
										num30 = num29;
									}
									num28 = num29 ^ ((int)num3 * -676129636);
									continue;
								}
								case 2u:
									return str.Replace(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4001997819u), global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(615657912u)) + global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1541154258u) + text6;
								case 4u:
									goto IL_14b7;
								case 11u:
									return str.Replace(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3299265572u), global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2403377855u)) + global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2057560981u) + text6;
								case 8u:
									return str.Replace(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(727785707u), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3299265572u)) + global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1583738914u) + text6;
								case 0u:
									goto IL_1561;
								case 5u:
									goto IL_158d;
								case 9u:
									return str + global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2471904275u) + text6;
								case 7u:
									return str.Replace(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(623834468u), global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(838530381u)) + global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2828931079u) + text6;
								case 3u:
									return str.Replace(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2577836733u), global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2274015414u)) + global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2057560981u) + text6;
								case 6u:
									goto IL_165d;
								default:
									goto end_IL_1400;
								}
								break;
								IL_165d:
								int num31;
								if (int.Parse(s) < int.Parse(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2775253196u)))
								{
									num28 = -1340000954;
									num31 = num28;
								}
								else
								{
									num28 = -1525663545;
									num31 = num28;
								}
								continue;
								IL_1561:
								int num32;
								if (int.Parse(s) < int.Parse(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3685954650u)))
								{
									num28 = -1043635367;
									num32 = num28;
								}
								else
								{
									num28 = -390367756;
									num32 = num28;
								}
								continue;
								IL_14b7:
								int num33;
								if (int.Parse(s) < int.Parse(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3740072876u)))
								{
									num28 = -361602632;
									num33 = num28;
								}
								else
								{
									num28 = -1159283271;
									num33 = num28;
								}
								continue;
								IL_158d:
								int num34;
								if (int.Parse(s) < int.Parse(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2663401806u)))
								{
									num28 = -951933112;
									num34 = num28;
								}
								else
								{
									num28 = -722397396;
									num34 = num28;
								}
							}
							continue;
							end_IL_1400:
							break;
						}
					}
					return result;
				}
				break;
			}
		}
	}

	public static string GetSaveForList(string saveName)
	{
		string text = _200D_202E_206E_206F_200F_206B_206C_200C_202E_202B_202D_206B_200E_206D_206F_206A_202A_206D_202C_206B_202A_202C_200B_202B_206B_202E_200F_200B_200E_206D_206B_206F_200F_200F_200C_202B_200B_206C_200F_206E_202E(SaveDir, saveName);
		if (!_202B_206F_206D_202E_202E_206C_200B_200D_206C_202C_200B_202C_202D_202A_206D_206F_200F_202C_200E_206E_206C_206B_206E_202A_206B_206F_200B_200B_200D_200F_202A_206A_202E_202E_206B_200D_202C_206E_202B_202A_202E(text))
		{
			while (true)
			{
				uint num;
				switch ((num = 37802659u) % 3)
				{
				case 2u:
					continue;
				case 1u:
					return string.Empty;
				}
				break;
			}
		}
		StreamReader streamReader = _206F_200C_202C_200C_206B_206F_206E_202D_206B_200B_206C_200C_200F_200C_200D_206D_202C_206E_202D_202B_206C_202E_200D_200C_202C_202E_202B_202D_206E_202C_200E_206D_206E_200D_202C_200C_202A_200B_202A_202E(text);
		string text2;
		try
		{
			text2 = _206A_202A_206E_200E_200C_206A_202E_200B_202D_202C_200E_202C_202E_206E_202C_202B_202B_202D_202E_206A_202D_202B_206F_200D_200E_202E_202B_200C_206E_200F_200D_202C_206E_206E_202C_202A_200D_202C_202A_202E((TextReader)streamReader);
			int num3 = default(int);
			while (true)
			{
				IL_005b:
				int num2 = -1434293853;
				while (true)
				{
					uint num;
					switch ((num = (uint)(num2 ^ -856101779)) % 8)
					{
					case 0u:
						break;
					default:
						goto end_IL_0060;
					case 6u:
						num3 = SavePanelUI.EN_SAVE();
						num2 = (int)(num * 32212469) ^ -731968698;
						continue;
					case 4u:
					{
						int num6;
						if (text2.StartsWith(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1494385060u)))
						{
							num2 = -1936088305;
							num6 = num2;
						}
						else
						{
							num2 = -786819990;
							num6 = num2;
						}
						continue;
					}
					case 2u:
						text2 = string.Empty;
						num2 = (int)((num * 1398403601) ^ 0x7388FDE8);
						continue;
					case 5u:
					{
						int num4;
						int num5;
						if (num3.ToString() != global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2720456403u))
						{
							num4 = 953500702;
							num5 = num4;
						}
						else
						{
							num4 = 2144610945;
							num5 = num4;
						}
						num2 = num4 ^ ((int)num * -225000816);
						continue;
					}
					case 1u:
						goto end_IL_0060;
					case 3u:
						text2 = GetDecode(text2, forList: true);
						num2 = (int)(num * 1370891956) ^ -959849728;
						continue;
					case 7u:
						goto end_IL_0060;
					}
					goto IL_005b;
					continue;
					end_IL_0060:
					break;
				}
				break;
			}
		}
		finally
		{
			if (streamReader != null)
			{
				while (true)
				{
					IL_0151:
					int num7 = -1130342406;
					while (true)
					{
						uint num;
						switch ((num = (uint)(num7 ^ -856101779)) % 3)
						{
						case 2u:
							break;
						default:
							goto end_IL_0156;
						case 1u:
							goto IL_0174;
						case 0u:
							goto end_IL_0156;
						}
						goto IL_0151;
						IL_0174:
						((IDisposable)streamReader).Dispose();
						num7 = (int)((num * 741558795) ^ 0x7C1DF0CC);
						continue;
						end_IL_0156:
						break;
					}
					break;
				}
			}
		}
		return text2;
	}

	private static string SetEncrypt(string content)
	{
		int num = _202D_206A_206D_206B_200E_200E_206E_200D_200D_200E_202C_206F_200C_206B_206B_202E_206F_206A_206B_200E_206C_200D_200E_200C_200F_206F_206A_200B_206B_206E_206E_200C_202D_202C_206F_200D_200B_202E_202E_206E_202E(content, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3466290132u));
		string text = _202C_206E_206A_202D_200F_200C_202D_206C_200E_206E_202B_200D_200E_202A_206D_200B_206E_202B_206B_202C_206B_200E_200B_202E_206B_206F_200B_200D_200E_202B_202E_200F_206E_202C_202B_206D_200B_206A_202D_200F_202E(content, 0, num + 1);
		int num2 = _202D_202B_200B_206E_200C_200C_202B_206E_202B_200E_200D_206E_206F_206A_202A_200E_206B_200C_206D_200F_206F_206C_206B_200F_200D_206D_200C_200D_202D_200B_202B_202A_200C_206B_206A_202E_200C_202E_206C_200F_202E(content, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2456803683u));
		string text2 = _202C_206E_206A_202D_200F_200C_202D_206C_200E_206E_202B_200D_200E_202A_206D_200B_206E_202B_206B_202C_206B_200E_200B_202E_206B_206F_200B_200D_200E_202B_202E_200F_206E_202C_202B_206D_200B_206A_202D_200F_202E(content, num2, _206E_202A_200E_206D_200C_206F_202D_206F_200B_200B_200D_206E_200D_202A_206B_202D_200F_206F_202E_200D_206A_200C_202C_202C_200C_206F_206E_202E_202D_200C_202A_202C_200C_206B_200C_206C_206D_202C_206B_202A_202E(content) - num2);
		content = _202C_206E_206A_202D_200F_200C_202D_206C_200E_206E_202B_200D_200E_202A_206D_200B_206E_202B_206B_202C_206B_200E_200B_202E_206B_206F_200B_200D_200E_202B_202E_200F_206E_202C_202B_206D_200B_206A_202D_200F_202E(content, num + 1, num2 - num - 1);
		content = Encrypt_Save(content);
		return _206F_200F_200B_200E_202C_206B_206A_206B_202D_206A_202C_200C_200D_202E_202B_202C_206A_206E_206C_202E_200B_206B_200B_202A_202E_200B_202B_200B_206E_200E_202A_200D_206C_202D_200C_206A_206C_200D_202C_206D_202E(text, content, text2);
	}

	private static string GetDecode(string content, bool forList = false)
	{
		string text = string.Empty;
		int num3 = default(int);
		string text2 = default(string);
		int num4 = default(int);
		while (true)
		{
			int num = -1987945948;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1503654601)) % 16)
				{
				case 8u:
					break;
				case 13u:
				{
					int num14;
					int num15;
					if (forList)
					{
						num14 = 667259650;
						num15 = num14;
					}
					else
					{
						num14 = 1975356486;
						num15 = num14;
					}
					num = num14 ^ (int)(num2 * 913146527);
					continue;
				}
				case 12u:
				{
					int num13;
					if (num3 != -1)
					{
						num = -1784305950;
						num13 = num;
					}
					else
					{
						num = -1342569200;
						num13 = num;
					}
					continue;
				}
				case 15u:
					text2 = _202C_206E_206A_202D_200F_200C_202D_206C_200E_206E_202B_200D_200E_202A_206D_200B_206E_202B_206B_202C_206B_200E_200B_202E_206B_206F_200B_200D_200E_202B_202E_200F_206E_202C_202B_206D_200B_206A_202D_200F_202E(content, num4, _206E_202A_200E_206D_200C_206F_202D_206F_200B_200B_200D_206E_200D_202A_206B_202D_200F_206F_202E_200D_206A_200C_202C_202C_200C_206F_206E_202E_202D_200C_202A_202C_200C_206B_200C_206C_206D_202C_206B_202A_202E(content) - num4);
					num = (int)((num2 * 1380859118) ^ 0x23C91AD9);
					continue;
				case 2u:
					num4 = _202D_202B_200B_206E_200C_200C_202B_206E_202B_200E_200D_206E_206F_206A_202A_200E_206B_200C_206D_200F_206F_206C_206B_200F_200D_206D_200C_200D_202D_200B_202B_202A_200C_206B_206A_202E_200C_202E_206C_200F_202E(content, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2123091716u));
					num = -1769874393;
					continue;
				case 3u:
				{
					num3 = _202D_206A_206D_206B_200E_200E_206E_200D_200D_200E_202C_206F_200C_206B_206B_202E_206F_206A_206B_200E_206C_200D_200E_200C_200F_206F_206A_200B_206B_206E_206E_200C_202D_202C_206F_200D_200B_202E_202E_206E_202E(content, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3889428671u));
					int num11;
					int num12;
					if (num3 != -1)
					{
						num11 = 1808129056;
						num12 = num11;
					}
					else
					{
						num11 = 1690928468;
						num12 = num11;
					}
					num = num11 ^ ((int)num2 * -1638726173);
					continue;
				}
				case 6u:
				{
					int num7;
					int num8;
					if (_202D_206A_206D_206B_200E_200E_206E_200D_200D_200E_202C_206F_200C_206B_206B_202E_206F_206A_206B_200E_206C_200D_200E_200C_200F_206F_206A_200B_206B_206E_206E_200C_202D_202C_206F_200D_200B_202E_202E_206E_202E(text, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3089226359u)) <= 22)
					{
						num7 = 195992213;
						num8 = num7;
					}
					else
					{
						num7 = 1767271910;
						num8 = num7;
					}
					num = num7 ^ ((int)num2 * -2118757888);
					continue;
				}
				case 10u:
					text2 = string.Empty;
					num = -293805446;
					continue;
				case 1u:
					content = string.Empty;
					num = (int)((num2 * 1206863586) ^ 0x645DD56C);
					continue;
				case 5u:
				{
					int num9;
					int num10;
					if (num4 == -1)
					{
						num9 = -1251233593;
						num10 = num9;
					}
					else
					{
						num9 = -959588325;
						num10 = num9;
					}
					num = num9 ^ ((int)num2 * -264024837);
					continue;
				}
				case 9u:
					num = ((int)num2 * -1291184417) ^ 0x7F0933F4;
					continue;
				case 11u:
					content = _202C_206E_206A_202D_200F_200C_202D_206C_200E_206E_202B_200D_200E_202A_206D_200B_206E_202B_206B_202C_206B_200E_200B_202E_206B_206F_200B_200D_200E_202B_202E_200F_206E_202C_202B_206D_200B_206A_202D_200F_202E(content, num3 + 1, num4 - num3 - 1);
					num = ((int)num2 * -1061595527) ^ -881119821;
					continue;
				case 0u:
				{
					int num5;
					int num6;
					if (num4 == -1)
					{
						num5 = 1234145579;
						num6 = num5;
					}
					else
					{
						num5 = 630426568;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 496599610);
					continue;
				}
				case 7u:
					content = Decode_Save(content);
					num = -154450189;
					continue;
				case 14u:
					text = _202C_206E_206A_202D_200F_200C_202D_206C_200E_206E_202B_200D_200E_202A_206D_200B_206E_202B_206B_202C_206B_200E_200B_202E_206B_206F_200B_200D_200E_202B_202E_200F_206E_202C_202B_206D_200B_206A_202D_200F_202E(content, 0, num3 + 1);
					num = ((int)num2 * -1485906913) ^ 0x4CD96A7F;
					continue;
				default:
					return _206F_200F_200B_200E_202C_206B_206A_206B_202D_206A_202C_200C_200D_202E_202B_202C_206A_206E_206C_202E_200B_206B_200B_202A_202E_200B_202B_200B_206E_200E_202A_200D_206C_202D_200C_206A_206C_200D_202C_206D_202E(text, content, text2);
				}
				break;
			}
		}
	}

	private static int getstr(string name)
	{
		string text = _202C_206E_206A_202D_200F_200C_202D_206C_200E_206E_202B_200D_200E_202A_206D_200B_206E_202B_206B_202C_206B_200E_200B_202E_206B_206F_200B_200D_200E_202B_202E_200F_206E_202C_202B_206D_200B_206A_202D_200F_202E(name, 0, int.Parse(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2403377855u)));
		while (true)
		{
			int num = 1043697236;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x20E00350)) % 27)
				{
				case 0u:
					break;
				case 3u:
					return int.Parse(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1285465951u));
				case 24u:
				{
					int num9;
					if (_206F_202D_206B_202A_200D_200D_206F_202A_202E_200C_206B_202E_200F_206C_200F_206C_202A_202C_206C_202A_200E_202C_202D_202A_202D_206E_202D_202C_200D_202B_206F_206F_202B_206C_202B_206A_200E_206C_202E_202D_202E(text, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3751789860u)))
					{
						num = 1123438578;
						num9 = num;
					}
					else
					{
						num = 454409821;
						num9 = num;
					}
					continue;
				}
				case 4u:
					return int.Parse(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2792198721u));
				case 17u:
				{
					int num4;
					if (_206F_202D_206B_202A_200D_200D_206F_202A_202E_200C_206B_202E_200F_206C_200F_206C_202A_202C_206C_202A_200E_202C_202D_202A_202D_206E_202D_202C_200D_202B_206F_206F_202B_206C_202B_206A_200E_206C_202E_202D_202E(text, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1783248415u)))
					{
						num = 820226348;
						num4 = num;
					}
					else
					{
						num = 1299029262;
						num4 = num;
					}
					continue;
				}
				case 26u:
					return int.Parse(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1705636853u));
				case 18u:
				{
					int num11;
					if (!_206A_202C_202B_202A_206F_206B_200B_200B_206E_200F_202D_202A_200D_202C_206D_202B_202D_206F_206C_206E_202B_200C_202E_200D_206D_200C_202A_202A_202E_202A_202E_200C_202E_200C_202E_200F_200D_202C_200D_206F_202E(name, _200E_202D_200D_200B_206B_200E_200D_200D_200E_200C_200B_206B_202A_206F_206E_202B_206F_206A_202A_202E_206B_206F_202D_200C_202E_200E_200F_206A_202C_206F_202A_206D_200D_206E_206B_202D_206C_206B_202C_202B_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3932871534u), 0, int.Parse(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3634177857u)))))
					{
						num = 1919131957;
						num11 = num;
					}
					else
					{
						num = 32753010;
						num11 = num;
					}
					continue;
				}
				case 20u:
					return int.Parse(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2540932728u));
				case 10u:
				{
					int num16;
					int num17;
					if (name != null)
					{
						num16 = -609771793;
						num17 = num16;
					}
					else
					{
						num16 = -1471677072;
						num17 = num16;
					}
					num = num16 ^ (int)(num2 * 23726740);
					continue;
				}
				case 2u:
				{
					int num13;
					if (_206F_202D_206B_202A_200D_200D_206F_202A_202E_200C_206B_202E_200F_206C_200F_206C_202A_202C_206C_202A_200E_202C_202D_202A_202D_206E_202D_202C_200D_202B_206F_206F_202B_206C_202B_206A_200E_206C_202E_202D_202E(text, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(548605692u)))
					{
						num = 1602193630;
						num13 = num;
					}
					else
					{
						num = 1876224957;
						num13 = num;
					}
					continue;
				}
				case 15u:
					return int.Parse(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3946483056u));
				case 19u:
				{
					int num8;
					if (!_206F_202D_206B_202A_200D_200D_206F_202A_202E_200C_206B_202E_200F_206C_200F_206C_202A_202C_206C_202A_200E_202C_202D_202A_202D_206E_202D_202C_200D_202B_206F_206F_202B_206C_202B_206A_200E_206C_202E_202D_202E(text, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(550472455u)))
					{
						num = 2128398568;
						num8 = num;
					}
					else
					{
						num = 90495902;
						num8 = num;
					}
					continue;
				}
				case 13u:
				{
					int num5;
					if (!_206F_202D_206B_202A_200D_200D_206F_202A_202E_200C_206B_202E_200F_206C_200F_206C_202A_202C_206C_202A_200E_202C_202D_202A_202D_206E_202D_202C_200D_202B_206F_206F_202B_206C_202B_206A_200E_206C_202E_202D_202E(text, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(40902152u)))
					{
						num = 94115680;
						num5 = num;
					}
					else
					{
						num = 2124608829;
						num5 = num;
					}
					continue;
				}
				case 7u:
				{
					int num15;
					if (!_206F_202D_206B_202A_200D_200D_206F_202A_202E_200C_206B_202E_200F_206C_200F_206C_202A_202C_206C_202A_200E_202C_202D_202A_202D_206E_202D_202C_200D_202B_206F_206F_202B_206C_202B_206A_200E_206C_202E_202D_202E(text, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1065685640u)))
					{
						num = 458098018;
						num15 = num;
					}
					else
					{
						num = 1428962928;
						num15 = num;
					}
					continue;
				}
				case 1u:
					return int.Parse(text);
				case 6u:
				{
					int num14;
					if (_206F_202D_206B_202A_200D_200D_206F_202A_202E_200C_206B_202E_200F_206C_200F_206C_202A_202C_206C_202A_200E_202C_202D_202A_202D_206E_202D_202C_200D_202B_206F_206F_202B_206C_202B_206A_200E_206C_202E_202D_202E(text, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(925971650u)))
					{
						num = 281676215;
						num14 = num;
					}
					else
					{
						num = 2125722728;
						num14 = num;
					}
					continue;
				}
				case 11u:
					return int.Parse(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(701414427u));
				case 16u:
					return int.Parse(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3280710054u));
				case 23u:
				{
					int num12;
					if (!_206F_202D_206B_202A_200D_200D_206F_202A_202E_200C_206B_202E_200F_206C_200F_206C_202A_202C_206C_202A_200E_202C_202D_202A_202D_206E_202D_202C_200D_202B_206F_206F_202B_206C_202B_206A_200E_206C_202E_202D_202E(text, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4191411508u)))
					{
						num = 1132315420;
						num12 = num;
					}
					else
					{
						num = 984717675;
						num12 = num;
					}
					continue;
				}
				case 22u:
					return int.Parse(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2432123196u));
				case 9u:
				{
					int num10;
					if (!_206F_202D_206B_202A_200D_200D_206F_202A_202E_200C_206B_202E_200F_206C_200F_206C_202A_202C_206C_202A_200E_202C_202D_202A_202D_206E_202D_202C_200D_202B_206F_206F_202B_206C_202B_206A_200E_206C_202E_202D_202E(text, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(613264756u)))
					{
						num = 1048839010;
						num10 = num;
					}
					else
					{
						num = 826743714;
						num10 = num;
					}
					continue;
				}
				case 12u:
					return int.Parse(name);
				case 21u:
					return int.Parse(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3409589759u));
				case 8u:
				{
					int num6;
					int num7;
					if (text == null)
					{
						num6 = 888930751;
						num7 = num6;
					}
					else
					{
						num6 = 482267112;
						num7 = num6;
					}
					num = num6 ^ (int)(num2 * 1762548817);
					continue;
				}
				case 14u:
					return int.Parse(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(413524160u));
				case 25u:
				{
					int num3;
					if (_206F_202D_206B_202A_200D_200D_206F_202A_202E_200C_206B_202E_200F_206C_200F_206C_202A_202C_206C_202A_200E_202C_202D_202A_202D_206E_202D_202C_200D_202B_206F_206F_202B_206C_202B_206A_200E_206C_202E_202D_202E(text, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2326529349u)))
					{
						num = 1552675974;
						num3 = num;
					}
					else
					{
						num = 2000245295;
						num3 = num;
					}
					continue;
				}
				default:
					return int.Parse(_200D_202D_206E_206E_202D_202D_202D_200B_206F_202A_200E_202D_200B_200D_202D_200D_206A_206D_202E_206F_200B_202E_200B_200B_206D_200E_202C_206C_202D_200B_206A_202D_202B_200D_200F_200B_206F_206D_206D_206D_202E(name, text, string.Empty));
				}
				break;
			}
		}
	}

	private static int getchar(int name)
	{
		int num = getstr(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3185603339u));
		while (true)
		{
			int num2 = -596336340;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -777095962)) % 14)
				{
				case 10u:
					break;
				case 9u:
					return name - _206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2210834147u), num);
				case 2u:
				{
					int num10;
					if (name >= _206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3259198378u), num))
					{
						num2 = -729119260;
						num10 = num2;
					}
					else
					{
						num2 = -1390498608;
						num10 = num2;
					}
					continue;
				}
				case 13u:
					return name - _206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4087739989u), num);
				case 7u:
					return name - _206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1306203761u), num);
				case 11u:
				{
					int num9;
					if (name < _206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(463851861u), num))
					{
						num2 = -195859843;
						num9 = num2;
					}
					else
					{
						num2 = -1173521339;
						num9 = num2;
					}
					continue;
				}
				case 12u:
				{
					int num5;
					int num6;
					if (name <= _206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3064505182u), num))
					{
						num5 = -828995981;
						num6 = num5;
					}
					else
					{
						num5 = -575271913;
						num6 = num5;
					}
					num2 = num5 ^ (int)(num3 * 2105568393);
					continue;
				}
				case 8u:
					return name - _206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(927827385u), num);
				case 4u:
					return name - _206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1078769357u), num);
				case 1u:
					return name;
				case 3u:
				{
					int num8;
					if (name < _206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(38098601u), num))
					{
						num2 = -726258565;
						num8 = num2;
					}
					else
					{
						num2 = -1368696624;
						num8 = num2;
					}
					continue;
				}
				case 5u:
				{
					int num7;
					if (name < _206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3843277966u), num))
					{
						num2 = -1237729662;
						num7 = num2;
					}
					else
					{
						num2 = -557892808;
						num7 = num2;
					}
					continue;
				}
				case 0u:
				{
					int num4;
					if (name < _206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1594388678u), num))
					{
						num2 = -2050433795;
						num4 = num2;
					}
					else
					{
						num2 = -1194324803;
						num4 = num2;
					}
					continue;
				}
				default:
					return name - _206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(774298109u), num);
				}
				break;
			}
		}
	}

	private static FileStream getobject(FileStream name)
	{
		string text = _200D_202E_206E_206F_200F_206B_206C_200C_202E_202B_202D_206B_200E_206D_206F_206A_202A_206D_202C_206B_202A_202C_200B_202B_206B_202E_200F_200B_200E_206D_206B_206F_200F_200F_200C_202B_200B_206C_200F_206E_202E(_206A_200D_206C_200C_200E_206B_206A_202B_206B_202E_200D_202E_206D_200C_206B_202B_202A_202D_202A_200D_206E_200B_206E_202C_202C_200E_202C_200D_200C_206E_206D_200B_200B_202D_206F_202C_200F_200C_206E_200E_202E(name), global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4037971162u));
		FileStream fileStream = null;
		try
		{
			fileStream = _202C_206B_202B_200F_202E_202A_206B_200F_202B_206D_206D_206C_206A_200C_206A_202C_206C_200B_206D_202A_202A_200E_206E_206B_200C_200F_206A_202C_202C_202D_200F_206E_206A_206B_200F_202A_202A_200B_206A_206E_202E(text, FileMode.Open);
		}
		catch
		{
		}
		bool flag = false;
		int num4 = default(int);
		while (true)
		{
			int num = 1273390684;
			while (true)
			{
				int num5;
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5493E841)) % 6)
				{
				case 2u:
					break;
				case 1u:
					num4 = 0;
					goto IL_0155;
				case 3u:
					flag = true;
					num = ((int)num2 * -575019029) ^ 0x19A9DF56;
					continue;
				case 5u:
				{
					int num6;
					if (!text.Contains(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3287999009u) + num4))
					{
						num = 1044936693;
						num6 = num;
					}
					else
					{
						num = 68084418;
						num6 = num;
					}
					continue;
				}
				default:
					try
					{
						if (fileStream.Name == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1783248415u))
						{
							while (true)
							{
								IL_00de:
								int num3 = 2101370460;
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ 0x5493E841)) % 4)
									{
									case 2u:
										break;
									default:
										goto end_IL_00e3;
									case 1u:
										goto IL_0105;
									case 3u:
										goto end_IL_00e3;
									case 0u:
										goto IL_0165;
									}
									goto IL_00de;
									IL_0105:
									flag = true;
									num3 = (int)(num2 * 678324971) ^ -776913370;
									continue;
									end_IL_00e3:
									break;
								}
								break;
							}
						}
					}
					catch
					{
					}
					num4++;
					goto IL_0132;
				case 0u:
					goto IL_0165;
					IL_0132:
					num5 = 1774965381;
					goto IL_0137;
					IL_0155:
					if (num4 < 10)
					{
						goto case 5u;
					}
					num5 = 1943555195;
					goto IL_0137;
					IL_0137:
					switch ((num2 = (uint)(num5 ^ 0x5493E841)) % 3)
					{
					case 2u:
						break;
					case 1u:
						goto IL_0155;
					default:
						goto IL_0165;
					}
					goto IL_0132;
					IL_0165:
					try
					{
						fileStream.Close();
					}
					catch
					{
					}
					if (!flag)
					{
						while (true)
						{
							switch ((num2 = 1087706692u) % 3)
							{
							case 0u:
								continue;
							case 1u:
								return fileStream;
							}
							break;
						}
					}
					return null;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.Unmanaged)]
	private static extern void ProcessChar(string str, List<char> oldChar, List<char> newChar);

	internal static byte[] GetXml()
	{
		if (_200F_202B_202A_206B_200E_200E_200F_202A_202C_200D_202B_202E_200F_206C_200B_200F_200D_202B_202D_200E_206A_200B_200D_202D_206A_200C_200F_206D_202E_202D_200E_202B_202E_202C_202D_206E_206D_200C_206B_206D_202E(_206F_206A_202A_202D_206E_206F_206C_206C_200B_200C_206C_206C_206A_200D_202D_206E_200C_200C_202D_200D_206E_200D_202B_206D_202E_206C_200B_206A_200C_206F_206F_202E_206F_202B_200D_206B_200E_206E_206B_200E_202E))
		{
			FileStream fileStream = default(FileStream);
			string text = default(string);
			FileStream fileStream2 = default(FileStream);
			byte[] array = default(byte[]);
			int num4 = default(int);
			StringBuilder stringBuilder = default(StringBuilder);
			byte[] array2 = default(byte[]);
			int num6 = default(int);
			while (true)
			{
				int num = 943639883;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x1366B01E)) % 6)
					{
					case 4u:
						break;
					case 5u:
						goto IL_0041;
					case 1u:
						fileStream = _202C_206B_202B_200F_202E_202A_206B_200F_202B_206D_206D_206C_206A_200C_206A_202C_206C_200B_206D_202A_202A_200E_206E_206B_200C_200F_206A_202C_202C_202D_200F_206E_206A_206B_200F_202A_202A_200B_206A_206E_202E(text, FileMode.Create);
						num = (int)(num2 * 1842907919) ^ -252567551;
						continue;
					case 0u:
						fileStream2 = fileStream;
						num = ((int)num2 * -1950848453) ^ 0x635646FF;
						continue;
					case 3u:
						array = _200E_206A_200D_202D_202E_200D_200C_206D_206C_200C_202A_200C_202D_206E_206E_200E_206B_206E_202C_202C_200D_206A_200D_200C_200E_206F_202D_206B_202B_206C_206A_202D_206C_206F_202C_206B_202E_200D_200C_206E_202E((HashAlgorithm)_206A_206A_206C_206F_206D_202B_206F_200C_202D_206A_200D_202C_206E_200D_206C_206F_206A_206A_202C_206B_200E_202B_206B_200D_206F_206F_200E_202C_202C_206F_206E_202C_202E_202C_200B_202D_206E_202B_206B_206C_202E(), (Stream)fileStream);
						_206F_206F_200B_202E_200F_206F_206B_206C_206C_206F_206B_202B_206B_200E_200B_202B_200E_200E_202E_206A_206C_200B_200E_206A_202D_206C_202E_206E_200D_200B_206B_206B_200E_206F_202E_202D_202A_200B_206C_202D_202E((Stream)fileStream);
						num = ((int)num2 * -1586942694) ^ -660904058;
						continue;
					default:
						goto IL_00e5;
					}
					break;
					IL_00e5:
					_206B_206B_206A_200C_200E_202B_202D_200F_202A_200B_202D_202A_206C_206A_200C_202D_200B_202A_200F_200F_200F_206F_206F_202E_206F_200E_206B_202E_206C_202E_202D_206B_206A_206D_200C_200E_206B_202D_200E_200E_202E((Stream)fileStream);
					fileStream = null;
					try
					{
						_206F_206A_202A_202D_206E_206F_206C_206C_200B_200C_206C_206C_206A_200D_202D_206E_200C_200C_202D_200D_206E_200D_202B_206D_202E_206C_200B_206A_200C_206F_206F_202E_206F_202B_200D_206B_200E_206E_206B_200E_202E = _206D_202B_206B_200D_206F_202D_206C_206A_206D_202C_202C_206D_200C_202C_200F_206D_206F_202C_200B_200C_206D_202B_202D_206B_202D_206C_202D_202C_200F_200D_202C_200B_202E_200D_206F_200F_206F_200F_202A_206D_202E(_206D_202C_202A_202D_200B_202E_202A_206F_200D_206D_206E_200B_202A_200C_206C_200D_202E_206C_202D_206A_206D_206A_202C_206C_206E_206D_206B_206C_200E_200B_202E_200B_206A_202D_200E_200D_202A_206C_202B_206A_202E(), array);
						_206F_206F_200B_202E_200F_206F_206B_206C_206C_206F_206B_202B_206B_200E_200B_202B_200E_200E_202E_206A_206C_200B_200E_206A_202D_206C_202E_206E_200D_200B_206B_206B_200E_206F_202E_202D_202A_200B_206C_202D_202E((Stream)fileStream2);
						while (true)
						{
							IL_0103:
							int num3 = 1571995719;
							while (true)
							{
								switch ((num2 = (uint)(num3 ^ 0x1366B01E)) % 4)
								{
								case 0u:
									break;
								default:
									goto end_IL_0108;
								case 1u:
									_206B_206B_206A_200C_200E_202B_202D_200F_202A_200B_202D_202A_206C_206A_200C_202D_200B_202A_200F_200F_200F_206F_206F_202E_206F_200E_206B_202E_206C_202E_202D_206B_206A_206D_200C_200E_206B_202D_200E_200E_202E((Stream)fileStream2);
									num3 = ((int)num2 * -1953520969) ^ -986149146;
									continue;
								case 3u:
									fileStream2 = null;
									num3 = ((int)num2 * -2044321532) ^ 0x698E185C;
									continue;
								case 2u:
									goto end_IL_0108;
								}
								goto IL_0103;
								continue;
								end_IL_0108:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num4 = 0;
					goto IL_015a;
					IL_015f:
					int num5;
					while (true)
					{
						switch ((num2 = (uint)(num5 ^ 0x1366B01E)) % 19)
						{
						case 6u:
							break;
						case 0u:
							fileStream = null;
							stringBuilder = _206B_206A_206E_200E_206A_202B_206A_202B_202E_202C_200D_200C_200C_200D_200C_200E_200E_202E_206A_202B_200E_200B_200B_206C_200F_200F_200E_200D_200E_202E_206C_200B_206C_200E_200F_206B_200D_202C_206C_202B_202E();
							num5 = (int)((num2 * 417882248) ^ 0x6E57B18F);
							continue;
						case 12u:
							goto IL_01da;
						case 18u:
							num4++;
							num5 = 1776402534;
							continue;
						case 15u:
							num5 = (int)((num2 * 1740567432) ^ 0x6D2FD229);
							continue;
						case 9u:
							stringBuilder = new StringBuilder();
							num5 = ((int)num2 * -667958630) ^ -419362371;
							continue;
						case 3u:
							goto IL_0233;
						case 17u:
							stringBuilder.Append(array2[num6].ToString(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1860929181u)));
							num6++;
							num5 = 1252190281;
							continue;
						case 14u:
							goto IL_027a;
						case 4u:
							num5 = (int)(num2 * 1468772526) ^ -226679499;
							continue;
						case 1u:
							_206F_206F_200B_202E_200F_206F_206B_206C_206C_206F_206B_202B_206B_200E_200B_202B_200E_200E_202E_206A_206C_200B_200E_206A_202D_206C_202E_206E_200D_200B_206B_206B_200E_206F_202E_202D_202A_200B_206C_202D_202E((Stream)fileStream);
							num5 = ((int)num2 * -15974829) ^ -1752313489;
							continue;
						case 8u:
							num5 = (int)((num2 * 1686390051) ^ 0x2CA2C97F);
							continue;
						case 13u:
							_206B_206B_206A_200C_200E_202B_202D_200F_202A_200B_202D_202A_206C_206A_200C_202D_200B_202A_200F_200F_200F_206F_206F_202E_206F_200E_206B_202E_206C_202E_202D_206B_206A_206D_200C_200E_206B_202D_200E_200E_202E((Stream)fileStream);
							num5 = ((int)num2 * -1772808431) ^ -229999472;
							continue;
						case 16u:
							goto IL_02ef;
						case 2u:
						{
							int num7;
							int num8;
							if (num4 > -1)
							{
								num7 = -1467326390;
								num8 = num7;
							}
							else
							{
								num7 = -30997979;
								num8 = num7;
							}
							num5 = num7 ^ ((int)num2 * -201142572);
							continue;
						}
						case 7u:
							array2 = null;
							_206F_206A_202A_202D_206E_206F_206C_206C_200B_200C_206C_206C_206A_200D_202D_206E_200C_200C_202D_200D_206E_200D_202B_206D_202E_206C_200B_206A_200C_206F_206F_202E_206F_202B_200D_206B_200E_206E_206B_200E_202E = stringBuilder.ToString().ToLower();
							num5 = ((int)num2 * -2038684128) ^ -321097939;
							continue;
						case 5u:
							num6 = 0;
							num5 = ((int)num2 * -974283420) ^ 0x2B360D6;
							continue;
						case 10u:
							_206F_206A_202A_202D_206E_206F_206C_206C_200B_200C_206C_206C_206A_200D_202D_206E_200C_200C_202D_200D_206E_200D_202B_206D_202E_206C_200B_206A_200C_206F_206F_202E_206F_202B_200D_206B_200E_206E_206B_200E_202E = null;
							num5 = 113206554;
							continue;
						default:
							goto end_IL_000f;
						}
						break;
						IL_02ef:
						int num9;
						if (num4 >= 1000000)
						{
							num5 = 1417692827;
							num9 = num5;
						}
						else
						{
							num5 = 804557711;
							num9 = num5;
						}
						continue;
						IL_027a:
						int num10;
						if (num4 > 1000000)
						{
							num5 = 1343358837;
							num10 = num5;
						}
						else
						{
							num5 = 228296858;
							num10 = num5;
						}
						continue;
						IL_01da:
						int num11;
						if (num6 >= array2.Length)
						{
							num5 = 1789619977;
							num11 = num5;
						}
						else
						{
							num5 = 1567345746;
							num11 = num5;
						}
					}
					goto IL_015a;
					IL_0041:
					text = _202B_200F_202B_202E_206E_200E_206D_206B_200D_206B_206C_202A_202E_200F_200B_202B_200F_206E_200E_200E_206E_206E_202D_200E_206A_202C_202A_202E_202A_200C_202D_200E_200C_206D_206D_202A_200B_206B_200C_206A_202E(CommonSettings.persistentDataPath, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1812586943u), GlobalData.CurrentMod.key, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(677705088u));
					fileStream = _202C_206B_202B_200F_202E_202A_206B_200F_202B_206D_206D_206C_206A_200C_206A_202C_206C_200B_206D_202A_202A_200E_206E_206B_200C_200F_206A_202C_202C_202D_200F_206E_206A_206B_200F_202A_202A_200B_206A_206E_202E(text, FileMode.Open);
					fileStream2 = getobject(fileStream);
					if (fileStream == fileStream2)
					{
						num = (int)(num2 * 1542097663) ^ -243258616;
						continue;
					}
					goto IL_0233;
					IL_015a:
					num5 = 1098449549;
					goto IL_015f;
					IL_0233:
					array2 = _200E_206A_200D_202D_202E_200D_200C_206D_206C_200C_202A_200C_202D_206E_206E_200E_206B_206E_202C_202C_200D_206A_200D_200C_200E_206F_202D_206B_202B_206C_206A_202D_206C_206F_202C_206B_202E_200D_200C_206E_202E((HashAlgorithm)_206A_206A_206C_206F_206D_202B_206F_200C_202D_206A_200D_202C_206E_200D_206C_206F_206A_206A_202C_206B_200E_202B_206B_200D_206F_206F_200E_202C_202C_206F_206E_202C_202E_202C_200B_202D_206E_202B_206B_206C_202E(), (Stream)fileStream);
					num5 = 565953220;
					goto IL_015f;
				}
				continue;
				end_IL_000f:
				break;
			}
		}
		return Encoding.UTF8.GetBytes(_206F_206A_202A_202D_206E_206F_206C_206C_200B_200C_206C_206C_206A_200D_202D_206E_200C_200C_202D_200D_206E_200D_202B_206D_202E_206C_200B_206A_200C_206F_206F_202E_206F_202B_200D_206B_200E_206E_206B_200E_202E);
	}

	static string _200D_202E_206E_206F_200F_206B_206C_200C_202E_202B_202D_206B_200E_206D_206F_206A_202A_206D_202C_206B_202A_202C_200B_202B_206B_202E_200F_200B_200E_206D_206B_206F_200F_200F_200C_202B_200B_206C_200F_206E_202E(string P_0, string P_1)
	{
		return P_0 + P_1;
	}

	static string _202B_200F_202B_202E_206E_200E_206D_206B_200D_206B_206C_202A_202E_200F_200B_202B_200F_206E_200E_200E_206E_206E_202D_200E_206A_202C_202A_202E_202A_200C_202D_200E_200C_206D_206D_202A_200B_206B_200C_206A_202E(string P_0, string P_1, string P_2, string P_3)
	{
		return P_0 + P_1 + P_2 + P_3;
	}

	static bool _206F_206F_206C_202D_206F_200D_202B_200E_202C_206F_200C_202E_202B_206B_206C_202B_200C_200D_200F_200B_200D_206D_200D_200C_202E_202B_202C_202D_202A_206C_206D_206A_200F_206E_202B_200D_200B_206D_206A_206F_202E(string P_0)
	{
		return Directory.Exists(P_0);
	}

	static DirectoryInfo _202C_206B_200E_200D_202E_200C_206A_206C_202C_200E_202A_206D_200D_200E_202A_202E_200E_206C_202E_206C_206A_200D_200F_202B_206A_200D_200F_206E_202E_206D_206E_206C_202D_202B_206B_206E_200D_200D_206C_206F_202E(string P_0)
	{
		return Directory.CreateDirectory(P_0);
	}

	static bool _202B_206F_206D_202E_202E_206C_200B_200D_206C_202C_200B_202C_202D_202A_206D_206F_200F_202C_200E_206E_206C_206B_206E_202A_206B_206F_200B_200B_200D_200F_202A_206A_202E_202E_206B_200D_202C_206E_202B_202A_202E(string P_0)
	{
		return File.Exists(P_0);
	}

	static void _202C_206B_200E_200E_200D_202D_206E_206D_200F_206C_206A_206E_202D_202A_200D_202A_206C_202C_202C_202B_206F_200D_200F_202A_206E_200C_202B_206A_200D_206A_206F_206D_206C_202A_206D_206D_202C_206C_200F_206C_202E(string P_0)
	{
		File.Delete(P_0);
	}

	static string[] _200E_206F_206A_206C_206A_206B_202D_206B_200D_202B_200B_202D_206E_206E_202B_200D_202D_202D_200F_200E_206A_206A_202A_202C_200D_202E_202C_202D_200F_206B_200D_202C_200C_206F_200E_202B_200C_206C_206D_202C_202E(string P_0, char[] P_1)
	{
		return P_0.Split(P_1);
	}

	static bool _206F_202D_206B_202A_200D_200D_206F_202A_202E_200C_206B_202E_200F_206C_200F_206C_202A_202C_206C_202A_200E_202C_202D_202A_202D_206E_202D_202C_200D_202B_206F_206F_202B_206C_202B_206A_200E_206C_202E_202D_202E(string P_0, string P_1)
	{
		return P_0 != P_1;
	}

	static UTF8Encoding _202E_200C_200B_206F_206B_206A_202E_202C_200F_202C_202A_206C_206F_200E_202E_200D_206D_202B_206F_206F_206F_206B_206C_200D_202A_200D_206A_202D_200D_202B_202A_202A_200E_202C_206E_200C_206B_206D_202E_200E_202E()
	{
		return new UTF8Encoding();
	}

	static MD5CryptoServiceProvider _206A_206A_206C_206F_206D_202B_206F_200C_202D_206A_200D_202C_206E_200D_206C_206F_206A_206A_202C_206B_200E_202B_206B_200D_206F_206F_200E_202C_202C_206F_206E_202C_202E_202C_200B_202D_206E_202B_206B_206C_202E()
	{
		return new MD5CryptoServiceProvider();
	}

	static byte[] _200B_202A_206F_200D_202B_200D_200E_206A_202B_206C_202B_200E_206E_202A_202B_206A_200B_202E_202A_202A_206C_206E_202E_200B_200E_200B_200D_200C_200D_202A_202E_206C_206B_206B_202E_202D_200E_200B_206C_200E_202E(Encoding P_0, string P_1)
	{
		return P_0.GetBytes(P_1);
	}

	static byte[] _202E_200C_206B_206F_202B_200B_200F_200B_200C_200F_202A_202C_200E_206B_200B_200E_202E_202E_202C_202A_200C_200B_200D_206D_202D_200F_200D_200E_200D_206B_202C_202D_202D_206F_202D_202B_202B_200D_202D_202E(HashAlgorithm P_0, byte[] P_1)
	{
		return P_0.ComputeHash(P_1);
	}

	static TripleDESCryptoServiceProvider _202A_206B_206C_200C_206E_200D_202A_206E_206A_200B_200D_200E_206B_202D_206E_206A_202A_206D_206A_206F_200C_202E_206D_200B_200E_206C_200B_200D_206D_200B_206B_200B_206D_200F_200C_206C_200E_206A_206C_200D_202E()
	{
		return new TripleDESCryptoServiceProvider();
	}

	static void _202D_206B_200B_202C_202A_206C_202B_202C_202E_206D_206C_206D_200E_202B_206D_200B_200F_202A_202C_206B_206C_200C_206A_206F_202C_202E_202E_200D_200B_206D_200F_200E_206E_206A_206C_202C_206F_200D_202D_202A_202E(SymmetricAlgorithm P_0, byte[] P_1)
	{
		P_0.Key = P_1;
	}

	static void _206C_206C_206A_200C_200E_206E_206A_202E_200C_200B_202E_206D_200D_206D_206C_206A_206F_200E_206D_206F_202B_200F_206C_206B_206F_200F_206D_200D_200B_202D_206A_206C_202C_200D_206C_200C_202B_200C_202D_202A_202E(SymmetricAlgorithm P_0, CipherMode P_1)
	{
		P_0.Mode = P_1;
	}

	static void _206D_202A_206B_206D_200F_202E_202D_206A_206C_206E_206D_202B_200F_202E_202B_206D_206D_206E_202E_206F_202D_202A_206A_206D_206F_200F_202D_206F_200D_202D_200C_200D_200B_200C_202E_200E_202E_200F_202B_206A_202E(SymmetricAlgorithm P_0, PaddingMode P_1)
	{
		P_0.Padding = P_1;
	}

	static byte[] _206A_206E_200D_206E_200F_200B_202D_202D_200F_202A_200B_200C_200B_202C_202E_202E_200F_206D_200F_206A_200F_206E_202E_206D_200C_202C_200D_200E_206F_202A_200E_206B_200F_200B_206E_202C_206D_202E_200E_202C_202E(string P_0)
	{
		return Convert.FromBase64String(P_0);
	}

	static ICryptoTransform _202E_202A_202D_202E_200F_202B_202C_200D_206E_206D_202E_202E_200D_200F_202C_202E_206B_200C_206F_202D_202D_206F_202D_206B_206C_206A_202A_200F_202B_206D_206E_200D_202A_202E_206E_206A_206E_202D_202E_202D_202E(SymmetricAlgorithm P_0)
	{
		return P_0.CreateDecryptor();
	}

	static byte[] _206E_206A_200C_202B_200E_202B_202A_202B_206C_200E_206A_206F_200E_206C_202C_202B_202C_206F_200E_202A_200B_206F_200E_206C_202E_206E_206E_206F_206A_202A_206E_200C_200C_206C_206F_202D_200B_200B_200D_200F_202E(ICryptoTransform P_0, byte[] P_1, int P_2, int P_3)
	{
		return P_0.TransformFinalBlock(P_1, P_2, P_3);
	}

	static void _206C_202B_202C_206D_206F_200C_200F_202C_202C_206C_200D_202C_200E_200F_206E_202C_206F_200C_200C_200E_200E_200B_202D_200B_202B_200F_206B_200F_200E_200B_200C_206B_200E_200E_206A_206E_200F_202B_200C_200C_202E(SymmetricAlgorithm P_0)
	{
		P_0.Clear();
	}

	static void _202B_206E_200D_200F_206A_206C_200B_206A_202B_200C_200D_200B_200C_200D_200B_202B_200E_206A_200D_206E_202B_200D_206B_206C_202C_200F_200C_202B_202D_200B_202A_202B_200B_202C_206E_206F_202B_200B_202B_206C_202E(HashAlgorithm P_0)
	{
		P_0.Clear();
	}

	static string _200F_202E_202E_202C_202E_202A_202A_202E_202E_202B_206B_206D_200F_200E_200B_206C_202C_200E_206B_202B_200B_206E_206D_200C_202A_206C_202C_202B_202A_206A_202C_206B_200D_200C_206C_206C_206D_202C_202B_206C_202E(string P_0, object P_1, object P_2)
	{
		return string.Format(P_0, P_1, P_2);
	}

	static string _202A_200B_202A_200D_206A_206F_200E_200B_200B_206D_206E_206A_206F_206A_206A_200F_202E_202A_202C_200B_200E_200F_200D_206F_202A_200E_200B_206D_202A_206B_206D_206F_202E_202E_200D_202D_200E_206D_206F_206E_202E(byte[] P_0)
	{
		return Convert.ToBase64String(P_0);
	}

	static string _206D_202B_206B_200D_206F_202D_206C_206A_206D_202C_202C_206D_200C_202C_200F_206D_206F_202C_200B_200C_206D_202B_202D_206B_202D_206C_202D_202C_200F_200D_202C_200B_202E_200D_206F_200F_206F_200F_202A_206D_202E(Encoding P_0, byte[] P_1)
	{
		return P_0.GetString(P_1);
	}

	static StringBuilder _206B_206A_206E_200E_206A_202B_206A_202B_202E_202C_200D_200C_200C_200D_200C_200E_200E_202E_206A_202B_200E_200B_200B_206C_200F_200F_200E_200D_200E_202E_206C_200B_206C_200E_200F_206B_200D_202C_206C_202B_202E()
	{
		return new StringBuilder();
	}

	static char _200E_206D_200E_200F_202A_200F_200C_202A_200E_202C_200E_200E_206C_200E_200B_200D_200B_200D_200C_200D_202D_206E_202E_202C_202B_202D_206D_206F_202B_200C_206A_200E_202D_206C_206A_206B_206F_202C_206C_202A_202E(string P_0, int P_1)
	{
		return P_0[P_1];
	}

	static StringBuilder _200F_206C_206D_206F_200B_200E_206B_200F_202B_202B_206A_202B_206C_202A_202C_206C_206D_202A_206B_200B_202A_202A_200F_202A_202B_200F_202E_206C_206E_206B_202E_202B_200F_202A_202E_200E_200F_200D_202A_206E_202E(StringBuilder P_0, char P_1)
	{
		return P_0.Append(P_1);
	}

	static int _206E_202A_200E_206D_200C_206F_202D_206F_200B_200B_200D_206E_200D_202A_206B_202D_200F_206F_202E_200D_206A_200C_202C_202C_200C_206F_206E_202E_202D_200C_202A_202C_200C_206B_200C_206C_206D_202C_206B_202A_202E(string P_0)
	{
		return P_0.Length;
	}

	static string _206D_200E_206E_200B_202C_206A_200F_202E_206A_202D_202E_206D_200B_206A_200F_206B_206A_202C_200C_206A_200F_206B_206C_206F_202E_206B_202A_200B_206A_206B_206E_200E_202D_202C_200F_202E_202A_202E_206F_202E_202E(object P_0)
	{
		return P_0.ToString();
	}

	static Encoding _206D_202C_202A_202D_200B_202E_202A_206F_200D_206D_206E_200B_202A_200C_206C_200D_202E_206C_202D_206A_206D_206A_202C_206C_206E_206D_206B_206C_200E_200B_202E_200B_206A_202D_200E_200D_202A_206C_202B_206A_202E()
	{
		return Encoding.UTF8;
	}

	static string _202C_206E_206A_202D_200F_200C_202D_206C_200E_206E_202B_200D_200E_202A_206D_200B_206E_202B_206B_202C_206B_200E_200B_202E_206B_206F_200B_200D_200E_202B_202E_200F_206E_202C_202B_206D_200B_206A_202D_200F_202E(string P_0, int P_1, int P_2)
	{
		return P_0.Substring(P_1, P_2);
	}

	static bool _206A_202C_202B_202A_206F_206B_200B_200B_206E_200F_202D_202A_200D_202C_206D_202B_202D_206F_206C_206E_202B_200C_202E_200D_206D_200C_202A_202A_202E_202A_202E_200C_202E_200C_202E_200F_200D_202C_200D_206F_202E(string P_0, string P_1)
	{
		return P_0 == P_1;
	}

	static string _206E_202A_200D_206E_206D_200E_206B_200B_206E_202E_200F_202D_200E_200D_202A_206D_206F_202B_200E_200E_202B_206F_206E_206E_206E_202D_202A_206C_206C_200E_206B_202C_206A_206E_200B_206B_206E_206E_206A_200E_202E(string P_0, int P_1, string P_2)
	{
		return P_0.Insert(P_1, P_2);
	}

	static string _200D_202D_206E_206E_202D_202D_202D_200B_206F_202A_200E_202D_200B_200D_202D_200D_206A_206D_202E_206F_200B_202E_200B_200B_206D_200E_202C_206C_202D_200B_206A_202D_202B_200D_200F_200B_206F_206D_206D_206D_202E(string P_0, string P_1, string P_2)
	{
		return P_0.Replace(P_1, P_2);
	}

	static int _206E_200D_206B_206D_200D_206D_206C_202D_200E_206D_200F_200B_200D_202B_202D_206F_200D_206B_206E_202E_206E_206F_202B_202B_200D_206A_202D_202C_200D_202C_202B_206F_202B_206F_206A_200B_206F_202A_202E_200C_202E(string P_0, int P_1)
	{
		return Convert.ToInt32(P_0, P_1);
	}

	static FileStream _202C_206B_202B_200F_202E_202A_206B_200F_202B_206D_206D_206C_206A_200C_206A_202C_206C_200B_206D_202A_202A_200E_206E_206B_200C_200F_206A_202C_202C_202D_200F_206E_206A_206B_200F_202A_202A_200B_206A_206E_202E(string P_0, FileMode P_1)
	{
		return new FileStream(P_0, P_1);
	}

	static byte[] _200E_206A_200D_202D_202E_200D_200C_206D_206C_200C_202A_200C_202D_206E_206E_200E_206B_206E_202C_202C_200D_206A_200D_200C_200E_206F_202D_206B_202B_206C_206A_202D_206C_206F_202C_206B_202E_200D_200C_206E_202E(HashAlgorithm P_0, Stream P_1)
	{
		return P_0.ComputeHash(P_1);
	}

	static void _206F_206F_200B_202E_200F_206F_206B_206C_206C_206F_206B_202B_206B_200E_200B_202B_200E_200E_202E_206A_206C_200B_200E_206A_202D_206C_202E_206E_200D_200B_206B_206B_200E_206F_202E_202D_202A_200B_206C_202D_202E(Stream P_0)
	{
		P_0.Close();
	}

	static void _206B_206B_206A_200C_200E_202B_202D_200F_202A_200B_202D_202A_206C_206A_200C_202D_200B_202A_200F_200F_200F_206F_206F_202E_206F_200E_206B_202E_206C_202E_202D_206B_206A_206D_200C_200E_206B_202D_200E_200E_202E(Stream P_0)
	{
		P_0.Dispose();
	}

	static StreamReader _206F_200C_202C_200C_206B_206F_206E_202D_206B_200B_206C_200C_200F_200C_200D_206D_202C_206E_202D_202B_206C_202E_200D_200C_202C_202E_202B_202D_206E_202C_200E_206D_206E_200D_202C_200C_202A_200B_202A_202E(string P_0)
	{
		return new StreamReader(P_0);
	}

	static string _206A_202A_206E_200E_200C_206A_202E_200B_202D_202C_200E_202C_202E_206E_202C_202B_202B_202D_202E_206A_202D_202B_206F_200D_200E_202E_202B_200C_206E_200F_200D_202C_206E_206E_202C_202A_200D_202C_202A_202E(TextReader P_0)
	{
		return P_0.ReadToEnd();
	}

	static int _202D_206A_206D_206B_200E_200E_206E_200D_200D_200E_202C_206F_200C_206B_206B_202E_206F_206A_206B_200E_206C_200D_200E_200C_200F_206F_206A_200B_206B_206E_206E_200C_202D_202C_206F_200D_200B_202E_202E_206E_202E(string P_0, string P_1)
	{
		return P_0.IndexOf(P_1);
	}

	static int _202D_202B_200B_206E_200C_200C_202B_206E_202B_200E_200D_206E_206F_206A_202A_200E_206B_200C_206D_200F_206F_206C_206B_200F_200D_206D_200C_200D_202D_200B_202B_202A_200C_206B_206A_202E_200C_202E_206C_200F_202E(string P_0, string P_1)
	{
		return P_0.LastIndexOf(P_1);
	}

	static string _206F_200F_200B_200E_202C_206B_206A_206B_202D_206A_202C_200C_200D_202E_202B_202C_206A_206E_206C_202E_200B_206B_200B_202A_202E_200B_202B_200B_206E_200E_202A_200D_206C_202D_200C_206A_206C_200D_202C_206D_202E(string P_0, string P_1, string P_2)
	{
		return P_0 + P_1 + P_2;
	}

	static string _200E_202D_200D_200B_206B_200E_200D_200D_200E_200C_200B_206B_202A_206F_206E_202B_206F_206A_202A_202E_206B_206F_202D_200C_202E_200E_200F_206A_202C_206F_202A_206D_200D_206E_206B_202D_206C_206B_202C_202B_202E(string P_0, int P_1, int P_2)
	{
		return P_0.Remove(P_1, P_2);
	}

	static string _206A_200D_206C_200C_200E_206B_206A_202B_206B_202E_200D_202E_206D_200C_206B_202B_202A_202D_202A_200D_206E_200B_206E_202C_202C_200E_202C_200D_200C_206E_206D_200B_200B_202D_206F_202C_200F_200C_206E_200E_202E(FileStream P_0)
	{
		return P_0.Name;
	}

	static int _200E_202A_206E_206D_200C_206F_206C_200B_200D_202E_200D_206F_202A_202B_206A_206C_206D_200F_206E_206E_206E_202E_202D_202B_206F_200E_206C_206C_200F_206D_200D_206C_206C_202E_206C_206F_202C_200B_202D_200C_202E()
	{
		return RuntimeHelpers.OffsetToStringData;
	}

	static bool _200F_202B_202A_206B_200E_200E_200F_202A_202C_200D_202B_202E_200F_206C_200B_200F_200D_202B_202D_200E_206A_200B_200D_202D_206A_200C_200F_206D_202E_202D_200E_202B_202E_202C_202D_206E_206D_200C_206B_206D_202E(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}
}
