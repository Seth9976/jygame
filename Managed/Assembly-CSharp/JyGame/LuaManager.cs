using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using LuaInterface;
using UnityEngine;

namespace JyGame;

public static class LuaManager
{
	private static string[] files;

	private static bool _200D_200E_206D_202C_200C_200D_202E_206F_202C_200F_206A_202A_202D_206D_202E_202C_206C_200D_202C_202A_206C_202B_200C_202B_202B_206C_202A_202C_200F_202C_202C_206D_200B_206C_202E_200E_200F_200F_202B_202E_202E;

	public static LuaScriptMgr luamgr;

	private static Dictionary<string, object> _202E_206F_202C_202D_202E_206E_200F_202B_206A_202E_206F_200E_206F_200B_200C_200B_206C_202E_202E_202B_200C_202A_206C_206E_202D_200F_202B_200C_206C_202D_200B_200B_206B_202D_202D_206B_206F_200E_202C_200E_202E;

	static LuaManager()
	{
		files = new string[2]
		{
			global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(458197353u),
			global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2722098344u)
		};
		while (true)
		{
			int num = -636566941;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1789519122)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0047;
				case 1u:
					return;
				}
				break;
				IL_0047:
				_200D_200E_206D_202C_200C_200D_202E_206F_202C_200F_206A_202A_202D_206D_202E_202C_206C_200D_202C_202A_206C_202B_200C_202B_202B_206C_202A_202C_200F_202C_202C_206D_200B_206C_202E_200E_200F_200F_202B_202E_202E = false;
				num = ((int)num2 * -106910410) ^ -1089016356;
			}
		}
	}

	public static byte[] JyGameLuaLoader(string path)
	{
		byte[] result = default(byte[]);
		string text = default(string);
		if (CommonSettings.MOD_KEY() >= 0)
		{
			while (true)
			{
				int num = 598486894;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x66BB86D6)) % 3)
					{
					case 0u:
						break;
					case 1u:
						if (_200E_200F_202B_200B_206E_202C_206F_206C_200C_202E_200C_206E_202A_206A_202B_200D_206C_202B_206A_200C_200D_206D_206E_202E_206D_202D_206C_202C_206D_206C_200D_202D_200C_200C_200E_202C_202D_200F_206B_202E(path, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3879503765u)))
						{
							goto IL_0043;
						}
						return Resource.GetBytes(_202E_202A_202D_206B_206C_200F_200D_206F_202C_206E_200C_202B_200C_200E_206D_206C_206A_206E_206B_206E_206B_206A_206A_200F_202B_200C_202A_206D_202B_200E_200E_202D_206E_202E_200F_202E_200C_206D_206E_202B_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3642780947u), path), loadFromAssetBundle: false);
					default:
					{
						StreamReader streamReader = _206F_206B_202C_200C_202A_206B_206E_200B_206F_200C_202A_206B_200B_202A_202E_200E_202E_206C_206F_202D_200C_206E_206F_200D_202A_202B_206C_206E_206C_200F_206E_206D_200C_202C_200C_202B_206D_206C_200E_200D_202E(_200D_200E_200C_206A_202B_206A_200F_200D_200C_206A_206C_206F_206B_206B_200E_202B_200E_200B_200B_202D_200E_202A_202E_202C_200F_206E_200D_206E_206B_202E_202C_206B_202D_200E_202C_206D_200E_200E_202C_206F_202E(ModManager.ModBaseUrlPath, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1821378039u), _206C_202B_202B_206A_200C_202B_206E_206F_206B_200C_202D_206A_200D_202B_206A_200E_206B_202E_200E_206A_206B_202B_200E_206B_200C_202C_202B_200F_200F_200D_206C_206E_200C_206C_200D_202A_202C_202D_200D_202E_202E(path, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2031019820u), string.Empty)));
						try
						{
							if (GlobalData.CurrentMod.enc)
							{
								goto IL_0091;
							}
							goto IL_01ed;
							IL_0091:
							int num3 = 978399219;
							goto IL_0096;
							IL_0096:
							while (true)
							{
								switch ((num2 = (uint)(num3 ^ 0x66BB86D6)) % 12)
								{
								case 8u:
									break;
								case 10u:
									result = _202C_202C_200B_202B_206F_200D_206C_206C_202C_202D_202C_206E_200B_202E_206A_206E_206A_200C_202A_206A_206A_200F_200C_202D_202B_200E_202C_202E_202E_200C_206F_206A_202B_200D_200B_202A_206E_202E_206F_202E(_202E_202A_202D_206B_206C_200F_200D_206F_202C_206E_200C_202B_200C_200E_206D_206C_206A_206E_206B_206E_206B_206A_206A_200F_202B_200C_202A_206D_202B_200E_200E_202D_206E_202E_200F_202E_200C_206D_206E_202B_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2732079493u), _202A_200B_200B_202E_206C_206B_200B_202D_200E_200B_206C_206D_200D_202E_206D_206F_206C_202E_200D_206B_202A_202E_200F_206B_202E_200D_206E_200E_206E_206A_206A_202E_202C_200F_200E_206A_200B_206B_200F_206B_202E((TextReader)streamReader)));
									num3 = 386420500;
									continue;
								case 9u:
								{
									int num6;
									int num7;
									if (_200E_200F_202B_200B_206E_202C_206F_206C_200C_202E_200C_206E_202A_206A_202B_200D_206C_202B_206A_200C_200D_206D_206E_202E_206D_202D_206C_202C_206D_206C_200D_202D_200C_200C_200E_202C_202D_200F_206B_202E(text, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2732079493u)))
									{
										num6 = -1492908285;
										num7 = num6;
									}
									else
									{
										num6 = -20196703;
										num7 = num6;
									}
									num3 = num6 ^ ((int)num2 * -1790171588);
									continue;
								}
								case 5u:
									result = _202C_202C_200B_202B_206F_200D_206C_206C_202C_202D_202C_206E_200B_202E_206A_206E_206A_200C_202A_206A_206A_200F_200C_202D_202B_200E_202C_202E_202E_200C_206F_206A_202B_200D_200B_202A_206E_202E_206F_202E(_202E_202A_202D_206B_206C_200F_200D_206F_202C_206E_200C_202B_200C_200E_206D_206C_206A_206E_206B_206E_206B_206A_206A_200F_202B_200C_202A_206D_202B_200E_200E_202D_206E_202E_200F_202E_200C_206D_206E_202B_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2732079493u), text));
									num3 = (int)(num2 * 341519504) ^ -1998717663;
									continue;
								case 11u:
									num3 = ((int)num2 * -1657756846) ^ -288925516;
									continue;
								case 7u:
									result = SaveManager.crcm(_202A_200B_200B_202E_206C_206B_200B_202D_200E_200B_206C_206D_200D_202E_206D_206F_206C_202E_200D_206B_202A_202E_200F_206B_202E_200D_206E_200E_206E_206A_206A_202E_202C_200F_200E_206A_200B_206B_200F_206B_202E((TextReader)streamReader));
									num3 = ((int)num2 * -1196912864) ^ -702518156;
									continue;
								case 2u:
									num3 = ((int)num2 * -1502302537) ^ -303176732;
									continue;
								case 3u:
									result = _202C_206B_206C_200F_202D_206E_206F_206B_200E_202D_206B_200B_206B_202A_200B_200E_200F_202A_202E_202A_206B_200F_202B_206D_206C_206E_202B_206A_206F_206A_200C_200B_206E_202B_206D_206E_206B_206F_206C_200F_202E(_202C_200D_206E_200D_200C_200F_200F_200D_206C_206E_202B_206E_200B_200F_200F_202E_200C_206E_200C_206C_202D_200F_206B_206E_206C_200E_202E_206A_206B_200C_200F_206D_206C_200F_206F_206C_202B_206C_206A_200F_202E(), text);
									num3 = 400876618;
									continue;
								case 6u:
									num3 = ((int)num2 * -802717815) ^ 0x7138D298;
									continue;
								case 1u:
								{
									int num4;
									int num5;
									if (!GlobalData.CurrentMod.oldenc)
									{
										num4 = 1623961994;
										num5 = num4;
									}
									else
									{
										num4 = 1446970179;
										num5 = num4;
									}
									num3 = num4 ^ (int)(num2 * 2056422238);
									continue;
								}
								case 4u:
									goto IL_01ed;
								default:
									return result;
								}
								break;
							}
							goto IL_0091;
							IL_01ed:
							text = _202A_200B_200B_202E_206C_206B_200B_202D_200E_200B_206C_206D_200D_202E_206D_206F_206C_202E_200D_206B_202A_202E_200F_206B_202E_200D_206E_200E_206E_206A_206A_202E_202C_200F_200E_206A_200B_206B_200F_206B_202E((TextReader)streamReader);
							int num8;
							if (_202E_202B_202D_200E_200C_202E_206F_200B_206A_206F_200C_200F_206A_200D_202E_200C_206E_200D_200D_202C_200D_206C_202A_200E_200E_200B_202D_200D_200C_202D_206C_202C_200B_200F_202D_206E_202D_202A_202E_202A_202E(text) > 88)
							{
								num3 = 1493817475;
								num8 = num3;
							}
							else
							{
								num3 = 482437965;
								num8 = num3;
							}
							goto IL_0096;
						}
						finally
						{
							if (streamReader != null)
							{
								while (true)
								{
									IL_021c:
									int num9 = 1332119245;
									while (true)
									{
										switch ((num2 = (uint)(num9 ^ 0x66BB86D6)) % 3)
										{
										case 0u:
											break;
										default:
											goto end_IL_0221;
										case 1u:
											goto IL_023f;
										case 2u:
											goto end_IL_0221;
										}
										goto IL_021c;
										IL_023f:
										_206A_206C_200E_206E_206F_202A_200E_202E_206F_206A_202E_206C_206B_202B_202A_206D_206D_200E_202A_202B_206E_202C_200B_206F_202B_206A_206D_202B_202A_202D_202C_206E_202C_206F_202A_206B_206A_200B_206E_206D_202E((IDisposable)streamReader);
										num9 = ((int)num2 * -1653833219) ^ 0x6D37F5D7;
										continue;
										end_IL_0221:
										break;
									}
									break;
								}
							}
						}
					}
					}
					break;
					IL_0043:
					num = ((int)num2 * -1138480044) ^ -1134227913;
				}
			}
		}
		return Resource.GetBytes(_202E_202A_202D_206B_206C_200F_200D_206F_202C_206E_200C_202B_200C_200E_206D_206C_206A_206E_206B_206E_206B_206A_206A_200F_202B_200C_202A_206D_202B_200E_200E_202D_206E_202E_200F_202E_200C_206D_206E_202B_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3642780947u), path), loadFromAssetBundle: false);
	}

	public static void Reload()
	{
		_202E_206F_202C_202D_202E_206E_200F_202B_206A_202E_206F_200E_206F_200B_200C_200B_206C_202E_202E_202B_200C_202A_206C_206E_202D_200F_202B_200C_206C_202D_200B_200B_206B_202D_202D_206B_206F_200E_202C_200E_202E = null;
		Init(forceReset: true);
	}

	public static void Init(bool forceReset = false)
	{
		if (forceReset)
		{
			goto IL_0003;
		}
		goto IL_0074;
		IL_0003:
		int num = -571672880;
		goto IL_0008;
		IL_0008:
		string text = default(string);
		int num4 = default(int);
		string text2 = default(string);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -548004457)) % 8)
			{
			case 0u:
				break;
			case 7u:
				_200D_200E_206D_202C_200C_200D_202E_206F_202C_200F_206A_202A_202D_206D_202E_202C_206C_200D_202C_202A_206C_202B_200C_202B_202B_206C_202A_202C_200F_202C_202C_206D_200B_206C_202E_200E_200F_200F_202B_202E_202E = false;
				num = ((int)num2 * -1072600108) ^ -1900080337;
				continue;
			case 4u:
			{
				int num9;
				int num10;
				if (luamgr == null)
				{
					num9 = -1418081207;
					num10 = num9;
				}
				else
				{
					num9 = -429359394;
					num10 = num9;
				}
				num = num9 ^ ((int)num2 * -1802023964);
				continue;
			}
			case 6u:
				goto IL_0074;
			case 1u:
				luamgr.Destroy();
				num = (int)((num2 * 1506259646) ^ 0x32D17797);
				continue;
			case 2u:
				luamgr = new LuaScriptMgr();
				num = -1914337036;
				continue;
			case 5u:
				return;
			default:
			{
				luamgr.Start();
				try
				{
					string[] array = files;
					while (true)
					{
						IL_00e4:
						int num3 = -2021851189;
						while (true)
						{
							switch ((num2 = (uint)(num3 ^ -548004457)) % 6)
							{
							case 2u:
								break;
							default:
								goto end_IL_00e9;
							case 1u:
								luamgr.DoFile(_202E_202A_202D_206B_206C_200F_200D_206F_202C_206E_200C_202B_200C_200E_206D_206C_206A_206E_206B_206E_206B_206A_206A_200F_202B_200C_202A_206D_202B_200E_200E_202D_206E_202E_200F_202E_200C_206D_206E_202B_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1366027312u), text));
								num4++;
								num3 = (int)(num2 * 1402759416) ^ -879874446;
								continue;
							case 3u:
							{
								int num5;
								if (num4 < array.Length)
								{
									num3 = -804513591;
									num5 = num3;
								}
								else
								{
									num3 = -1940062866;
									num5 = num3;
								}
								continue;
							}
							case 4u:
								num4 = 0;
								num3 = (int)((num2 * 1604158956) ^ 0x7964E51A);
								continue;
							case 0u:
								text = array[num4];
								num3 = -150540738;
								continue;
							case 5u:
								goto end_IL_00e9;
							}
							goto IL_00e4;
							continue;
							end_IL_00e9:
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					_202B_200B_200C_206B_206A_200B_200E_202B_200F_202C_206C_200C_200B_206D_206A_206B_200B_202D_206C_206E_206A_202A_206C_200B_202B_202D_202C_206D_202C_202D_202C_200C_206A_206D_206C_200D_206A_206B_200F_206B_202E((object)_206E_202A_206B_202C_202A_202B_200E_200F_202E_202C_200C_202B_206F_200C_206D_206E_202A_202C_200C_206C_202D_202C_200B_202D_200E_206D_206F_206B_200B_206E_202B_206D_202C_202A_206A_202D_200B_206E_206C_202E_202E(ex));
					FileLogger.instance.LogError(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1156701411u));
					FileLogger.instance.LogError(_206E_202A_206B_202C_202A_202B_200E_200F_202E_202C_200C_202B_206F_200C_206D_206E_202A_202C_200C_206C_202D_202C_200B_202D_200E_206D_206F_206B_200B_206E_202B_206D_202C_202A_206A_202D_200B_206E_206C_202E_202E(ex));
				}
				_200D_200E_206D_202C_200C_200D_202E_206F_202C_200F_206A_202A_202D_206D_202E_202C_206C_200D_202C_202A_206C_202B_200C_202B_202B_206C_202A_202C_200F_202C_202C_206D_200B_206C_202E_200E_200F_200F_202B_202E_202E = true;
				LuaTable luaTable = Call<LuaTable>(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(793592391u), new object[0]);
				try
				{
					IEnumerator enumerator = _202E_206D_202D_206E_200D_206A_206B_200F_206E_200B_202E_202A_202B_206A_200B_202D_200F_206C_206D_200D_202B_206C_206F_206E_202E_202C_206B_206D_206B_200D_206A_202C_206A_200C_202B_200E_200B_202A_200E_200E_202E((IEnumerable)luaTable.Values);
					try
					{
						while (true)
						{
							IL_021d:
							int num6;
							int num7;
							if (!_206E_206B_202D_206E_206C_202B_202D_206D_200D_200B_200D_200B_206F_206D_202E_206A_206D_206F_206F_200E_202C_202D_200C_200C_202E_206C_200E_206A_202E_206A_202E_206B_206C_206E_202B_200E_206A_206A_202A_206D_202E(enumerator))
							{
								num6 = -1105392572;
								num7 = num6;
							}
							else
							{
								num6 = -1254245144;
								num7 = num6;
							}
							while (true)
							{
								switch ((num2 = (uint)(num6 ^ -548004457)) % 5)
								{
								case 4u:
									num6 = -1254245144;
									continue;
								default:
									goto end_IL_01e2;
								case 1u:
									text2 = (string)_206A_206C_206D_200F_202D_206D_202E_206F_200F_206E_206B_202E_202B_206D_202B_206B_206B_206B_200C_200F_202E_200E_206C_206C_202E_202E_206B_206A_206E_202A_206F_206E_206E_200B_202C_206E_200C_200E_206A_206F_202E(enumerator);
									num6 = -1984321839;
									continue;
								case 3u:
									break;
								case 2u:
									luamgr.DoFile(_202E_202A_202D_206B_206C_200F_200D_206F_202C_206E_200C_202B_200C_200E_206D_206C_206A_206E_206B_206E_206B_206A_206A_200F_202B_200C_202A_206D_202B_200E_200E_202D_206E_202E_200F_202E_200C_206D_206E_202B_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1230236609u), text2));
									num6 = (int)(num2 * 1772692401) ^ -274206814;
									continue;
								case 0u:
									goto end_IL_01e2;
								}
								goto IL_021d;
								continue;
								end_IL_01e2:
								break;
							}
							break;
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						if (disposable != null)
						{
							goto IL_02a9;
						}
						while (true)
						{
							switch ((num2 = 1298008765u) % 3)
							{
							case 2u:
								continue;
							case 1u:
								goto end_IL_0275;
							}
							goto IL_02a9;
							continue;
							end_IL_0275:
							break;
						}
						goto end_IL_0268;
						IL_02a9:
						_206A_206C_200E_206E_206F_202A_200E_202E_206F_206A_202E_206C_206B_202B_202A_206D_206D_200E_202A_202B_206E_202C_200B_206F_202B_206A_206D_202B_202A_202D_202C_206E_202C_206F_202A_206B_206A_200B_206E_206D_202E(disposable);
						end_IL_0268:;
					}
				}
				catch (Exception ex2)
				{
					_202B_200B_200C_206B_206A_200B_200E_202B_200F_202C_206C_200C_200B_206D_206A_206B_200B_202D_206C_206E_206A_202A_206C_200B_202B_202D_202C_206D_202C_202D_202C_200C_206A_206D_206C_200D_206A_206B_200F_206B_202E((object)_206E_202A_206B_202C_202A_202B_200E_200F_202E_202C_200C_202B_206F_200C_206D_206E_202A_202C_200C_206C_202D_202C_200B_202D_200E_206D_206F_206B_200B_206E_202B_206D_202C_202A_206A_202D_200B_206E_206C_202E_202E(ex2));
					while (true)
					{
						IL_02c1:
						int num8 = -2117735512;
						while (true)
						{
							switch ((num2 = (uint)(num8 ^ -548004457)) % 3)
							{
							case 2u:
								break;
							default:
								goto end_IL_02c6;
							case 1u:
								goto IL_02e4;
							case 0u:
								goto end_IL_02c6;
							}
							goto IL_02c1;
							IL_02e4:
							FileLogger.instance.LogError(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1156701411u));
							FileLogger.instance.LogError(_206E_202A_206B_202C_202A_202B_200E_200F_202E_202C_200C_202B_206F_200C_206D_206E_202A_202C_200C_206C_202D_202C_200B_202D_200E_206D_206F_206B_200B_206E_202B_206D_202C_202A_206A_202D_200B_206E_206C_202E_202E(ex2));
							num8 = (int)((num2 * 2125775407) ^ 0x205E26E9);
							continue;
							end_IL_02c6:
							break;
						}
						break;
					}
				}
				CommonSettings.SetTriggersXml();
				TriggerLogic.InitluaExtensionConditions();
				return;
			}
			}
			break;
		}
		goto IL_0003;
		IL_0074:
		int num11;
		if (!_200D_200E_206D_202C_200C_200D_202E_206F_202C_200F_206A_202A_202D_206D_202E_202C_206C_200D_202C_202A_206C_202B_200C_202B_202B_206C_202A_202C_200F_202C_202C_206D_200B_206C_202E_200E_200F_200F_202B_202E_202E)
		{
			num = -841633667;
			num11 = num;
		}
		else
		{
			num = -1624239534;
			num11 = num;
		}
		goto IL_0008;
	}

	public static object[] Call(string functionName, params object[] paras)
	{
		if (!_200D_200E_206D_202C_200C_200D_202E_206F_202C_200F_206A_202A_202D_206D_202E_202C_206C_200D_202C_202A_206C_202B_200C_202B_202B_206C_202A_202C_200F_202C_202C_206D_200B_206C_202E_200E_200F_200F_202B_202E_202E)
		{
			goto IL_0007;
		}
		goto IL_0051;
		IL_0007:
		int num = 239857779;
		goto IL_000c;
		IL_000c:
		LuaFunction luaFunction = default(LuaFunction);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x29032C56)) % 6)
			{
			case 3u:
				break;
			case 0u:
			{
				int num3;
				int num4;
				if (luaFunction == null)
				{
					num3 = 432504544;
					num4 = num3;
				}
				else
				{
					num3 = 2097168764;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -1753206363);
				continue;
			}
			case 1u:
				goto IL_0051;
			case 4u:
				_202B_200B_200C_206B_206A_200B_200E_202B_200F_202C_206C_200C_200B_206D_206A_206B_200B_202D_206C_206E_206A_202A_206C_200B_202B_202D_202C_206D_202C_202D_202C_200C_206A_206D_206C_200D_206A_206B_200F_206B_202E((object)_202E_202A_202D_206B_206C_200F_200D_206F_202C_206E_200C_202B_200C_200E_206D_206C_206A_206E_206B_206E_206B_206A_206A_200F_202B_200C_202A_206D_202B_200E_200E_202D_206E_202E_200F_202E_200C_206D_206E_202B_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4148237805u), functionName));
				return null;
			case 5u:
				Init();
				num = (int)(num2 * 629411718) ^ -1669525713;
				continue;
			default:
				return luaFunction.Call(paras);
			}
			break;
		}
		goto IL_0007;
		IL_0051:
		luaFunction = luamgr.GetLuaFunction(functionName);
		num = 1828472118;
		goto IL_000c;
	}

	public static T Call<T>(string functionName, params object[] paras)
	{
		if (!_200D_200E_206D_202C_200C_200D_202E_206F_202C_200F_206A_202A_202D_206D_202E_202C_206C_200D_202C_202A_206C_202B_200C_202B_202B_206C_202A_202C_200F_202C_202C_206D_200B_206C_202E_200E_200F_200F_202B_202E_202E)
		{
			goto IL_000a;
		}
		goto IL_00e5;
		IL_000a:
		int num = -1905883662;
		goto IL_000f;
		IL_000f:
		T result = default(T);
		object[] array = default(object[]);
		LuaFunction luaFunction = default(LuaFunction);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -52688325)) % 12)
			{
			case 4u:
				break;
			case 6u:
				result = default(T);
				num = -2019086573;
				continue;
			case 8u:
				return result;
			case 7u:
				array = luaFunction.Call(paras);
				num = -1270453744;
				continue;
			case 2u:
			{
				int num9;
				int num10;
				if (luaFunction == null)
				{
					num9 = 923993323;
					num10 = num9;
				}
				else
				{
					num9 = 1721335336;
					num10 = num9;
				}
				num = num9 ^ ((int)num2 * -609633582);
				continue;
			}
			case 10u:
			{
				int num5;
				int num6;
				if (!(bool)array[0])
				{
					num5 = 925936007;
					num6 = num5;
				}
				else
				{
					num5 = 528580588;
					num6 = num5;
				}
				num = num5 ^ (int)(num2 * 1252944783);
				continue;
			}
			case 5u:
				Init();
				num = (int)(num2 * 1710264852) ^ -192260476;
				continue;
			case 3u:
				goto IL_00e5;
			case 0u:
				_202B_200B_200C_206B_206A_200B_200E_202B_200F_202C_206C_200C_200B_206D_206A_206B_200B_202D_206C_206E_206A_202A_206C_200B_202B_202D_202C_206D_202C_202D_202C_200C_206A_206D_206C_200D_206A_206B_200F_206B_202E((object)_202E_202A_202D_206B_206C_200F_200D_206F_202C_206E_200C_202B_200C_200E_206D_206C_206A_206E_206B_206E_206B_206A_206A_200F_202B_200C_202A_206D_202B_200E_200E_202D_206E_202E_200F_202E_200C_206D_206E_202B_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2824658696u), functionName));
				return default(T);
			case 11u:
			{
				int num7;
				int num8;
				if (array.Length != 0)
				{
					num7 = -1029067828;
					num8 = num7;
				}
				else
				{
					num7 = -663587325;
					num8 = num7;
				}
				num = num7 ^ (int)(num2 * 1663608910);
				continue;
			}
			case 1u:
			{
				int num3;
				int num4;
				if (!(array[0] is bool))
				{
					num3 = 650723017;
					num4 = num3;
				}
				else
				{
					num3 = 124949762;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 479893063);
				continue;
			}
			default:
				return (T)array[0];
			}
			break;
		}
		goto IL_000a;
		IL_00e5:
		luaFunction = luamgr.GetLuaFunction(functionName);
		num = -893336219;
		goto IL_000f;
	}

	public static int CallWithIntReturn(string functionName, params object[] paras)
	{
		if (!_200D_200E_206D_202C_200C_200D_202E_206F_202C_200F_206A_202A_202D_206D_202E_202C_206C_200D_202C_202A_206C_202B_200C_202B_202B_206C_202A_202C_200F_202C_202C_206D_200B_206C_202E_200E_200F_200F_202B_202E_202E)
		{
			goto IL_0007;
		}
		goto IL_0044;
		IL_0007:
		int num = -1626091125;
		goto IL_000c;
		IL_000c:
		object[] array = default(object[]);
		LuaFunction luaFunction = default(LuaFunction);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1007641912)) % 6)
			{
			case 2u:
				break;
			case 1u:
				array = luaFunction.Call(paras);
				num = -658334969;
				continue;
			case 0u:
				goto IL_0044;
			case 5u:
				Init();
				num = (int)((num2 * 259035279) ^ 0x600141A9);
				continue;
			case 4u:
				_202B_200B_200C_206B_206A_200B_200E_202B_200F_202C_206C_200C_200B_206D_206A_206B_200B_202D_206C_206E_206A_202A_206C_200B_202B_202D_202C_206D_202C_202D_202C_200C_206A_206D_206C_200D_206A_206B_200F_206B_202E((object)_202E_202A_202D_206B_206C_200F_200D_206F_202C_206E_200C_202B_200C_200E_206D_206C_206A_206E_206B_206E_206B_206A_206A_200F_202B_200C_202A_206D_202B_200E_200E_202D_206E_202E_200F_202E_200C_206D_206E_202B_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4148237805u), functionName));
				return -1;
			default:
				return _200C_206A_200D_200C_206A_200E_206F_200E_206F_200E_200C_206E_206C_202D_202B_206C_206C_200B_206C_202B_200F_206C_200D_206F_200E_206D_206B_202C_206E_206F_206E_200F_200E_200B_206A_200C_206A_206E_200E_202D_202E(array[0]);
			}
			break;
		}
		goto IL_0007;
		IL_0044:
		luaFunction = luamgr.GetLuaFunction(functionName);
		int num3;
		if (luaFunction != null)
		{
			num = -1960924211;
			num3 = num;
		}
		else
		{
			num = -1351264922;
			num3 = num;
		}
		goto IL_000c;
	}

	public static T GetConfig<T>(string key)
	{
		init_luaConfig();
		if (_202E_206F_202C_202D_202E_206E_200F_202B_206A_202E_206F_200E_206F_200B_200C_200B_206C_202E_202E_202B_200C_202A_206C_206E_202D_200F_202B_200C_206C_202D_200B_200B_206B_202D_202D_206B_206F_200E_202C_200E_202E.ContainsKey(key))
		{
			goto IL_0012;
		}
		goto IL_0058;
		IL_0012:
		int num = 807763274;
		goto IL_0017;
		IL_0017:
		uint num2;
		T result = default(T);
		switch ((num2 = (uint)(num ^ 0x23B02CB)) % 4)
		{
		case 2u:
			break;
		case 1u:
			return (T)_202E_206F_202C_202D_202E_206E_200F_202B_206A_202E_206F_200E_206F_200B_200C_200B_206C_202E_202E_202B_200C_202A_206C_206E_202D_200F_202B_200C_206C_202D_200B_200B_206B_202D_202D_206B_206F_200E_202C_200E_202E[key];
		case 0u:
			goto IL_0058;
		default:
			return result;
		}
		goto IL_0012;
		IL_0058:
		result = default(T);
		num = 32713540;
		goto IL_0017;
	}

	public static string GetConfig(string key)
	{
		if (existKey_luaConfig(key))
		{
			while (true)
			{
				uint num;
				switch ((num = 2018308519u) % 3)
				{
				case 2u:
					continue;
				case 1u:
					return GetConfig<string>(key);
				}
				break;
			}
		}
		return string.Empty;
	}

	public static int GetConfigInt(string key)
	{
		if (existKey_luaConfig(key))
		{
			while (true)
			{
				uint num;
				switch ((num = 2051543182u) % 3)
				{
				case 0u:
					continue;
				case 1u:
					return _200C_206A_200D_200C_206A_200E_206F_200E_206F_200E_200C_206E_206C_202D_202B_206C_206C_200B_206C_202B_200F_206C_200D_206F_200E_206D_206B_202C_206E_206F_206E_200F_200E_200B_206A_200C_206A_206E_200E_202D_202E(GetConfig<object>(key));
				}
				break;
			}
		}
		return 0;
	}

	public static double GetConfigDouble(string key)
	{
		if (existKey_luaConfig(key))
		{
			while (true)
			{
				uint num;
				switch ((num = 1950283316u) % 3)
				{
				case 0u:
					continue;
				case 2u:
					return _206E_202C_206B_202E_200C_206D_206B_200B_206A_206C_202A_206C_206B_202A_202E_206D_206C_206C_206B_200D_200D_206B_206E_206E_200C_200F_206F_206B_202B_206E_200E_202C_200B_200B_200F_202B_200C_202B_202D_206E_202E(GetConfig<object>(key));
				}
				break;
			}
		}
		return 0.0;
	}

	public static string CallWithStringReturn(string functionName, params object[] paras)
	{
		if (!_200D_200E_206D_202C_200C_200D_202E_206F_202C_200F_206A_202A_202D_206D_202E_202C_206C_200D_202C_202A_206C_202B_200C_202B_202B_206C_202A_202C_200F_202C_202C_206D_200B_206C_202E_200E_200F_200F_202B_202E_202E)
		{
			goto IL_0007;
		}
		goto IL_0060;
		IL_0007:
		int num = -112225555;
		goto IL_000c;
		IL_000c:
		LuaFunction luaFunction = default(LuaFunction);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1723327004)) % 7)
			{
			case 2u:
				break;
			case 3u:
				_202B_200B_200C_206B_206A_200B_200E_202B_200F_202C_206C_200C_200B_206D_206A_206B_200B_202D_206C_206E_206A_202A_206C_200B_202B_202D_202C_206D_202C_202D_202C_200C_206A_206D_206C_200D_206A_206B_200F_206B_202E((object)_202E_202A_202D_206B_206C_200F_200D_206F_202C_206E_200C_202B_200C_200E_206D_206C_206A_206E_206B_206E_206B_206A_206A_200F_202B_200C_202A_206D_202B_200E_200E_202D_206E_202E_200F_202E_200C_206D_206E_202B_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2824658696u), functionName));
				num = (int)((num2 * 1772646166) ^ 0x13E76DC3);
				continue;
			case 4u:
				goto IL_0060;
			case 5u:
				Init();
				num = ((int)num2 * -191438976) ^ 0x6BED213E;
				continue;
			case 6u:
			{
				int num3;
				int num4;
				if (luaFunction != null)
				{
					num3 = -662370316;
					num4 = num3;
				}
				else
				{
					num3 = -1848409782;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 1153909975);
				continue;
			}
			case 1u:
				return string.Empty;
			default:
				return _206C_206E_206C_200D_200D_202B_200C_200B_206F_206B_202D_200F_206D_202C_200D_202C_200D_206F_206F_202A_202C_200B_206B_200F_202B_206A_200D_200E_200B_202C_202C_206E_206D_206C_202A_202B_202D_206D_206A_202A_202E(luaFunction.Call(paras)[0]);
			}
			break;
		}
		goto IL_0007;
		IL_0060:
		luaFunction = luamgr.GetLuaFunction(functionName);
		num = -512984010;
		goto IL_000c;
	}

	public static void null_luaConfig()
	{
		_202E_206F_202C_202D_202E_206E_200F_202B_206A_202E_206F_200E_206F_200B_200C_200B_206C_202E_202E_202B_200C_202A_206C_206E_202D_200F_202B_200C_206C_202D_200B_200B_206B_202D_202D_206B_206F_200E_202C_200E_202E = null;
	}

	private static string _200B_206B_206A_200B_200E_202B_206A_202A_206D_200B_206B_206E_200B_202B_200F_206E_206A_206F_206B_200F_202D_200E_200C_206B_206F_206B_202E_206E_200C_200D_200F_200E_200F_202B_200F_200C_206C_202A_202C_200F_202E(string P_0)
	{
		if (_200E_200F_202B_200B_206E_202C_206F_206C_200C_202E_200C_206E_202A_206A_202B_200D_206C_202B_206A_200C_200D_206D_206E_202E_206D_202D_206C_202C_206D_206C_200D_202D_200C_200C_200E_202C_202D_200F_206B_202E(P_0, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1336873325u)))
		{
			goto IL_0015;
		}
		goto IL_02ea;
		IL_0015:
		int num = -2032373495;
		goto IL_001a;
		IL_001a:
		int num6 = default(int);
		int num10 = default(int);
		string[] array2 = default(string[]);
		int num9 = default(int);
		StringBuilder stringBuilder = default(StringBuilder);
		int num8 = default(int);
		int num11 = default(int);
		int num5 = default(int);
		int num7 = default(int);
		bool flag = default(bool);
		int num4 = default(int);
		int num3 = default(int);
		string[] array = default(string[]);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -610547015)) % 25)
			{
			case 3u:
				break;
			case 6u:
				num6++;
				num = (int)(num2 * 1520604699) ^ -1627466076;
				continue;
			case 11u:
				goto IL_00ad;
			case 19u:
				num6 = 0;
				num = (int)((num2 * 104069148) ^ 0x74D2E494);
				continue;
			case 22u:
				num10 = -int.Parse(array[array.Length - 1]);
				num = ((int)num2 * -1513206565) ^ 0xF98C75C;
				continue;
			case 12u:
				array2 = _202A_206F_202C_202B_206F_206D_200C_202A_200C_202E_206A_206D_200D_200B_206F_202A_202A_202A_202A_206D_200E_200E_200B_200F_202E_200B_200C_206C_200E_202C_200B_206A_206F_200B_206A_206D_206C_200C_206E_202E_202E(array[num9], new char[1] { (char)_200B_202A_200C_200E_206F_202E_206B_202C_206D_206F_206A_200E_200B_202C_206B_206A_200D_202D_206E_202E_200B_202A_206F_200D_200B_200E_202D_200F_206D_206D_206D_200B_200D_200D_202D_206F_206F_200C_200C_206B_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1364031255u), 16) });
				num = -1414809;
				continue;
			case 0u:
				goto IL_0132;
			case 2u:
				num = (int)((num2 * 1656116076) ^ 0x61767DDF);
				continue;
			case 9u:
				num = ((int)num2 * -131327422) ^ 0x737CB493;
				continue;
			case 18u:
				num9++;
				num = ((int)num2 * -473869794) ^ -1931557143;
				continue;
			case 1u:
				_200D_202D_206E_206E_206E_200C_202C_206C_206C_200D_206F_206B_206E_202B_206F_202B_200B_206D_202B_202A_202B_202A_202C_206F_200E_202C_202D_202D_200B_200F_206C_200C_200C_200F_206A_206C_200B_206C_206D_206E_202E(stringBuilder, (char)(num8 + num11 + num10));
				num = (int)(num2 * 490683885) ^ -1442146444;
				continue;
			case 16u:
				_206C_200C_202C_202A_202C_202E_202B_202B_206A_206D_206A_206D_202D_206A_200B_200C_206B_206B_200E_206B_200D_200B_200C_206C_202B_200D_206B_202D_206D_202C_202A_206C_200F_200C_200B_206E_206E_206E_202E_206E_202E((Array)array, 0, array.Length);
				num = (int)(num2 * 679800402) ^ -182902230;
				continue;
			case 7u:
				_200D_202D_206E_206E_206E_200C_202C_206C_206C_200D_206F_206B_206E_202B_206F_202B_200B_206D_202B_202A_202B_202A_202C_206F_200E_202C_202D_202D_200B_200F_206C_200C_200C_200F_206A_206C_200B_206C_206D_206E_202E(stringBuilder, (char)(num8 + int.Parse(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2658727182u)) - int.Parse(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4001997819u)) + num10));
				num = -784673037;
				continue;
			case 24u:
				stringBuilder = _206A_200B_200B_206B_206E_202B_202D_202A_202C_202A_202C_200E_200F_206B_206C_206F_202D_202D_200F_200E_202B_200E_202E_202A_200C_206A_206A_202B_206C_206D_200D_206F_200C_202D_202E_200D_202E_206A_206D_202C_202E();
				num9 = 0;
				num = ((int)num2 * -1487984423) ^ 0x4C9DD48A;
				continue;
			case 5u:
				num5 = int.Parse(_206E_206B_202B_202C_206F_200D_202B_200E_202E_200D_206E_202B_200E_206C_206A_200D_206E_200D_206A_200B_202E_202D_202D_206E_200B_206F_200D_206F_202A_200B_202A_202A_200B_202B_202E_202E_200B_200F_206A_206D_202E(array2[num6], 0, _202E_202B_202D_200E_200C_202E_206F_200B_206A_206F_200C_200F_206A_200D_202E_200C_206E_200D_200D_202C_200D_206C_202A_200E_200E_200B_202D_200D_200C_202D_206C_202C_200B_200F_202D_206E_202D_202A_202E_202A_202E(array2[num6]) + num7)) + int.Parse(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1104038639u));
				num8 = int.Parse(_206C_202B_206C_206E_200F_202C_206C_206E_200E_200E_200F_206C_200B_202A_202C_200B_206D_206B_202C_206C_206D_206E_200D_206D_202A_202A_200F_202E_206E_202B_206C_200B_206D_202E_200F_206A_206E_200B_202C_200C_202E(array2[num6], 0, _202E_202B_202D_200E_200C_202E_206F_200B_206A_206F_200C_200F_206A_200D_202E_200C_206E_200D_200D_202C_200D_206C_202A_200E_200E_200B_202D_200D_200C_202D_206C_202C_200B_200F_202D_206E_202D_202A_202E_202A_202E(array2[num6]) + num7));
				flag = !flag;
				num = -903168098;
				continue;
			case 21u:
				goto IL_027d;
			case 23u:
				num4++;
				num = -36621339;
				continue;
			case 10u:
				num4 = 0;
				num = ((int)num2 * -2130379326) ^ -786538132;
				continue;
			case 17u:
				num3 = 0;
				num = (int)(num2 * 1759354024) ^ -1232482637;
				continue;
			case 8u:
				goto IL_02d0;
			case 15u:
				goto IL_02ea;
			case 4u:
				goto IL_033d;
			case 13u:
				num = (int)(num2 * 1993936953) ^ -834480630;
				continue;
			case 20u:
				P_0 = _202E_202A_202D_206B_206C_200F_200D_206F_202C_206E_200C_202B_200C_200E_206D_206C_206A_206E_206B_206E_206B_206A_206A_200F_202B_200C_202A_206D_202B_200E_200E_202D_206E_202E_200F_202E_200C_206D_206E_202B_202E(P_0, _206B_206E_206F_206F_200F_202A_202D_202B_200B_202B_202B_200C_206B_206F_206F_202A_200C_206F_206F_202C_200D_200C_202D_206C_202E_206C_202E_206B_200E_200B_206A_200E_206F_202C_202B_202D_200E_202C_202D_206C_202E(P_0, num3, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(533767640u)));
				num3++;
				num = -1024744141;
				continue;
			default:
				array = null;
				return _206F_202A_206B_200D_200D_202C_200D_206D_200B_200B_206C_200C_206A_206F_202A_200F_206C_206F_206C_200C_202B_202B_200E_206D_200C_206E_206E_200C_206F_200D_200F_206A_202A_202A_200F_200E_206B_202B_206E_206C_202E((object)stringBuilder);
			}
			break;
			IL_033d:
			int num12;
			if (num9 < array.Length - 1)
			{
				num = -1770094445;
				num12 = num;
			}
			else
			{
				num = -282423691;
				num12 = num;
			}
			continue;
			IL_00ad:
			int num13;
			if (num3 < 1000)
			{
				num = -171399303;
				num13 = num;
			}
			else
			{
				num = -845590710;
				num13 = num;
			}
			continue;
			IL_027d:
			int num14;
			if (!flag)
			{
				num = -479028345;
				num14 = num;
			}
			else
			{
				num = -1460043;
				num14 = num;
			}
			continue;
			IL_02d0:
			int num15;
			if (num4 >= num5)
			{
				num = -1486391215;
				num15 = num;
			}
			else
			{
				num = -1916812215;
				num15 = num;
			}
			continue;
			IL_0132:
			int num16;
			if (num6 >= array2.Length)
			{
				num = -894438712;
				num16 = num;
			}
			else
			{
				num = -1280505908;
				num16 = num;
			}
		}
		goto IL_0015;
		IL_02ea:
		array = _202A_206F_202C_202B_206F_206D_200C_202A_200C_202E_206A_206D_200D_200B_206F_202A_202A_202A_202A_206D_200E_200E_200B_200F_202E_200B_200C_206C_200E_202C_200B_206A_206F_200B_206A_206D_206C_200C_206E_202E_202E(SaveManager.ExtractString(P_0), new char[1] { (char)_200B_202A_200C_200E_206F_202E_206B_202C_206D_206F_206A_200E_200B_202C_206B_206A_200D_202D_206E_202E_200B_202A_206F_200D_200B_200E_202D_200F_206D_206D_206D_200B_200D_200D_202D_206F_206F_200C_200C_206B_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(852641629u), 16) });
		num7 = int.Parse(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2877462323u));
		num11 = int.Parse(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4290218165u));
		flag = false;
		num = -1832999360;
		goto IL_001a;
	}

	private static byte[] _202E_200F_206D_206B_202A_206C_202A_200F_206D_200E_206B_200C_202B_200E_206B_202D_202D_200E_200E_202B_206A_202A_200B_200E_200F_200F_200B_200E_200E_202D_200D_202D_206D_200F_206F_206E_206A_206D_202C_202E(string P_0, byte[] P_1, byte[] P_2)
	{
		if (_202D_200D_206F_202D_200B_206C_206E_206D_200E_206E_202D_200F_202B_202C_200C_206B_202B_202C_206E_202A_206F_206C_206C_206C_202B_202A_200F_202B_202A_206F_200F_200F_206F_202C_206E_202B_200D_202B_206C_202D_202E(P_0))
		{
			goto IL_000b;
		}
		goto IL_00a5;
		IL_000b:
		int num = 1522311928;
		goto IL_0010;
		IL_0010:
		byte[] array = default(byte[]);
		byte[] result = default(byte[]);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x68BB4A2A)) % 11)
			{
			case 0u:
				break;
			case 8u:
			{
				int num9;
				int num10;
				if (P_1.Length != 32)
				{
					num9 = 289855430;
					num10 = num9;
				}
				else
				{
					num9 = 490244029;
					num10 = num9;
				}
				num = num9 ^ (int)(num2 * 1359587027);
				continue;
			}
			case 5u:
			{
				int num11;
				int num12;
				if (P_1.Length != 24)
				{
					num11 = 188010366;
					num12 = num11;
				}
				else
				{
					num11 = 1769986205;
					num12 = num11;
				}
				num = num11 ^ (int)(num2 * 1514415709);
				continue;
			}
			case 4u:
				array = _202D_202C_200D_200D_206C_202B_206A_202D_202E_200C_200C_206B_202A_206A_206D_202E_202B_206A_200B_200F_200B_200F_206A_200D_202A_202D_202B_200B_200E_200C_200D_206C_202E_200E_206A_202D_202D_202A_202C_200F_202E(P_0);
				num = 923825982;
				continue;
			case 1u:
				goto IL_00a5;
			case 2u:
			{
				int num5;
				int num6;
				if (P_1.Length == 16)
				{
					num5 = 1083399813;
					num6 = num5;
				}
				else
				{
					num5 = 1401105882;
					num6 = num5;
				}
				num = num5 ^ (int)(num2 * 1417983514);
				continue;
			}
			case 7u:
			{
				int num7;
				int num8;
				if (P_2 == null)
				{
					num7 = -1687051128;
					num8 = num7;
				}
				else
				{
					num7 = -1167206051;
					num8 = num7;
				}
				num = num7 ^ ((int)num2 * -397613022);
				continue;
			}
			case 3u:
				goto IL_00fe;
			case 9u:
				return new byte[0];
			case 10u:
				return new byte[0];
			default:
			{
				RijndaelManaged rijndaelManaged = _206C_200C_206A_202C_202A_206A_202B_200D_202E_202B_200E_200E_200E_202A_200E_202C_200B_206D_206A_202E_206A_206B_202E_202A_200B_202A_206F_200B_206F_200F_202E_206C_206C_200D_200F_202C_200F_200E_200D_202B_202E();
				try
				{
					_202B_202C_200B_206A_206C_206B_202E_206C_206D_206D_202D_206D_200F_206A_202A_206B_206F_202B_206F_202D_200F_206D_200C_200E_202A_200F_206D_202E_206D_200C_200D_206B_200F_202B_200E_202A_200B_200B_200C_206E_202E((SymmetricAlgorithm)rijndaelManaged, P_2);
					while (true)
					{
						IL_0150:
						int num3 = 1682961281;
						while (true)
						{
							switch ((num2 = (uint)(num3 ^ 0x68BB4A2A)) % 5)
							{
							case 0u:
								break;
							default:
								goto end_IL_0155;
							case 4u:
								result = _206F_206B_200B_206D_202E_206F_206F_206D_206B_206F_200F_202B_202C_206F_202D_202E_202E_200C_206D_202B_200D_200B_202A_202D_200F_206E_200B_202C_206A_200F_200D_202E_206A_202C_202A_206F_206B_206D_202C_202C_202E(_206E_206E_202C_202E_200C_206D_202B_206C_202B_202D_202E_206F_206F_200C_206C_200C_200F_202D_206E_200B_200B_206B_206B_206B_200C_200C_202C_202D_206D_206F_202A_206F_206F_206E_202B_200E_200D_200D_206D_202A_202E((SymmetricAlgorithm)rijndaelManaged), array, 0, array.Length);
								num3 = ((int)num2 * -794172725) ^ -454780039;
								continue;
							case 1u:
								_206E_206C_206C_202C_202D_206E_202D_202D_206E_202B_202D_200F_202A_206C_200F_200E_200D_202B_202C_200D_200D_206B_202C_206F_200B_202B_202B_202E_200B_202C_202D_206C_206F_200F_206E_200D_206B_200F_202C_202B_202E((SymmetricAlgorithm)rijndaelManaged, CipherMode.CBC);
								_202A_200B_206E_206E_200F_200D_200E_202D_206A_206C_206C_202C_200D_202D_206A_200C_202A_200E_206D_206A_206A_206A_206D_200B_200B_200E_202B_200C_202A_206A_202D_202A_202B_206D_206B_200D_202B_206F_202D_200F_202E((SymmetricAlgorithm)rijndaelManaged, PaddingMode.PKCS7);
								num3 = (int)((num2 * 2133586177) ^ 0x486DE788);
								continue;
							case 2u:
								_206F_202A_200F_202B_202C_202B_206B_200B_200E_202D_202C_206D_206C_202C_206D_200C_200F_206A_206E_202D_206A_200C_202A_200E_206E_200F_202D_202B_200B_200B_200D_206C_200C_206D_200D_206C_202A_206B_206E_200D_202E((SymmetricAlgorithm)rijndaelManaged, P_1);
								num3 = (int)(num2 * 327278398) ^ -249362504;
								continue;
							case 3u:
								goto end_IL_0155;
							}
							goto IL_0150;
							continue;
							end_IL_0155:
							break;
						}
						break;
					}
				}
				finally
				{
					if (rijndaelManaged != null)
					{
						while (true)
						{
							IL_01d2:
							int num4 = 1409139063;
							while (true)
							{
								switch ((num2 = (uint)(num4 ^ 0x68BB4A2A)) % 3)
								{
								case 2u:
									break;
								default:
									goto end_IL_01d7;
								case 1u:
									goto IL_01f4;
								case 0u:
									goto end_IL_01d7;
								}
								goto IL_01d2;
								IL_01f4:
								_206A_206C_200E_206E_206F_202A_200E_202E_206F_206A_202E_206C_206B_202B_202A_206D_206D_200E_202A_202B_206E_202C_200B_206F_202B_206A_206D_202B_202A_202D_202C_206E_202C_206F_202A_206B_206A_200B_206E_206D_202E((IDisposable)rijndaelManaged);
								num4 = (int)((num2 * 1179866723) ^ 0x3BA29E27);
								continue;
								end_IL_01d7:
								break;
							}
							break;
						}
					}
				}
				return result;
			}
			}
			break;
			IL_00fe:
			int num13;
			if (P_2.Length < 16)
			{
				num = 1995013416;
				num13 = num;
			}
			else
			{
				num = 1036452372;
				num13 = num;
			}
		}
		goto IL_000b;
		IL_00a5:
		int num14;
		if (P_1 == null)
		{
			num = 1995013416;
			num14 = num;
		}
		else
		{
			num = 804546042;
			num14 = num;
		}
		goto IL_0010;
	}

	private static byte[] _202C_202C_200B_202B_206F_200D_206C_206C_202C_202D_202C_206E_200B_202E_206A_206E_206A_200C_202A_206A_206A_200F_200C_202D_202B_200E_202C_202E_202E_200C_206F_206A_202B_200D_200B_202A_206E_202E_206F_202E(string P_0)
	{
		byte[] xml = SaveManager.GetXml();
		string[] array = default(string[]);
		int num7 = default(int);
		uint cRC = default(uint);
		int num3 = default(int);
		byte[] array2 = default(byte[]);
		byte[] array3 = default(byte[]);
		int num10 = default(int);
		while (true)
		{
			int num = -757402308;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1641332721)) % 19)
				{
				case 10u:
					break;
				case 9u:
				{
					P_0 = _206E_206B_202B_202C_206F_200D_202B_200E_202E_200D_206E_202B_200E_206C_206A_200D_206E_200D_206A_200B_202E_202D_202D_206E_200B_206F_200D_206F_202A_200B_202A_202A_200B_202B_202E_202E_200B_200F_206A_206D_202E(P_0, 0, 1);
					array = _202A_206F_202C_202B_206F_206D_200C_202A_200C_202E_206A_206D_200D_200B_206F_202A_202A_202A_202A_206D_200E_200E_200B_200F_202E_200B_200C_206C_200E_202C_200B_206A_206F_200B_206A_206D_206C_200C_206E_202E_202E(P_0, new char[1] { (char)_200B_202A_200C_200E_206F_202E_206B_202C_206D_206F_206A_200E_200B_202C_206B_206A_200D_202D_206E_202E_200B_202A_206F_200D_200B_200E_202D_200F_206D_206D_206D_200B_200D_200D_202D_206F_206F_200C_200C_206B_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1414484887u), 16) });
					int num6;
					if (array.Length != 2)
					{
						num = -1560301042;
						num6 = num;
					}
					else
					{
						num = -546097476;
						num6 = num;
					}
					continue;
				}
				case 3u:
				{
					int num9;
					if (num7 % 2 == 1)
					{
						num = -1590864864;
						num9 = num;
					}
					else
					{
						num = -1653917872;
						num9 = num;
					}
					continue;
				}
				case 1u:
					P_0 = _200B_206B_206A_200B_200E_202B_206A_202A_206D_200B_206B_206E_200B_202B_200F_206E_206A_206F_206B_200F_202D_200E_200C_206B_206F_206B_202E_206E_200C_200D_200F_200E_200F_202B_200F_200C_206C_202A_202C_200F_202E(P_0);
					num = (int)((num2 * 614818340) ^ 0x41E8BC13);
					continue;
				case 8u:
					cRC = CRC32.GetCRC32(xml);
					num = (int)(num2 * 1030161183) ^ -1287490266;
					continue;
				case 0u:
				{
					int num8;
					if (num7 < xml.Length)
					{
						num = -667043899;
						num8 = num;
					}
					else
					{
						num = -1659318441;
						num8 = num;
					}
					continue;
				}
				case 4u:
				{
					int num13;
					if (num7 != 0)
					{
						num = -1722527138;
						num13 = num;
					}
					else
					{
						num = -186884291;
						num13 = num;
					}
					continue;
				}
				case 15u:
				{
					int num14;
					int num15;
					if ((num7 + 1) % 4 == 0)
					{
						num14 = -426112924;
						num15 = num14;
					}
					else
					{
						num14 = -1179747129;
						num15 = num14;
					}
					num = num14 ^ (int)(num2 * 1844321242);
					continue;
				}
				case 18u:
					num3 = 0;
					num7 = 0;
					num = (int)((num2 * 107155718) ^ 0x6D48F319);
					continue;
				case 2u:
				{
					int num11;
					int num12;
					if (!(cRC.ToString() == array[1]))
					{
						num11 = -2136777134;
						num12 = num11;
					}
					else
					{
						num11 = -82048371;
						num12 = num11;
					}
					num = num11 ^ ((int)num2 * -1984210569);
					continue;
				}
				case 12u:
					return _202E_200F_206D_206B_202A_206C_202A_200F_206D_200E_206B_200C_202B_200E_206B_202D_202D_200E_200E_202B_206A_202A_200B_200E_200F_200F_200B_200E_200E_202D_200D_202D_206D_200F_206F_206E_206A_206D_202C_202E(array[0].Substring(1, array[0].Length - 1), array2, array3);
				case 7u:
					array2[num10] = xml[num7];
					num10++;
					num = -1410847842;
					continue;
				case 14u:
					array3[num3] = xml[num3];
					num3++;
					num = ((int)num2 * -1884268125) ^ -1034418243;
					continue;
				case 13u:
					num = (int)(num2 * 1978801911) ^ -1158453286;
					continue;
				case 16u:
					array3 = new byte[int.Parse(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3769163133u))];
					num = (int)((num2 * 63692374) ^ 0x4A1FA926);
					continue;
				case 5u:
					array2 = new byte[int.Parse(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1779104569u))];
					num10 = 0;
					num = (int)((num2 * 348354899) ^ 0x70EF60C2);
					continue;
				case 6u:
					num7++;
					num = -808115960;
					continue;
				case 17u:
				{
					int num4;
					int num5;
					if (num3 != 0)
					{
						num4 = 542695671;
						num5 = num4;
					}
					else
					{
						num4 = 95941872;
						num5 = num4;
					}
					num = num4 ^ (int)(num2 * 2118010489);
					continue;
				}
				default:
					return Encoding.UTF8.GetBytes(P_0);
				}
				break;
			}
		}
	}

	private static void init_luaConfig()
	{
		if (_202E_206F_202C_202D_202E_206E_200F_202B_206A_202E_206F_200E_206F_200B_200C_200B_206C_202E_202E_202B_200C_202A_206C_206E_202D_200F_202B_200C_206C_202D_200B_200B_206B_202D_202D_206B_206F_200E_202C_200E_202E != null)
		{
			return;
		}
		LuaTable luaTable = Call<LuaTable>(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(966065734u), new object[0]);
		_202E_206F_202C_202D_202E_206E_200F_202B_206A_202E_206F_200E_206F_200B_200C_200B_206C_202E_202E_202B_200C_202A_206C_206E_202D_200F_202B_200C_206C_202D_200B_200B_206B_202D_202D_206B_206F_200E_202C_200E_202E = new Dictionary<string, object>();
		IDictionaryEnumerator enumerator = luaTable.GetEnumerator();
		try
		{
			while (true)
			{
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 732747189;
					num2 = num;
				}
				else
				{
					num = 971383544;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x9C5ED6E)) % 4)
					{
					case 0u:
						num = 732747189;
						continue;
					default:
						return;
					case 3u:
					{
						DictionaryEntry dictionaryEntry = (DictionaryEntry)_206A_206C_206D_200F_202D_206D_202E_206F_200F_206E_206B_202E_202B_206D_202B_206B_206B_206B_200C_200F_202E_200E_206C_206C_202E_202E_206B_206A_206E_202A_206F_206E_206E_200B_202C_206E_200C_200E_206A_206F_202E((IEnumerator)enumerator);
						_202E_206F_202C_202D_202E_206E_200F_202B_206A_202E_206F_200E_206F_200B_200C_200B_206C_202E_202E_202B_200C_202A_206C_206E_202D_200F_202B_200C_206C_202D_200B_200B_206B_202D_202D_206B_206F_200E_202C_200E_202E.Add(dictionaryEntry.Key.ToString(), dictionaryEntry.Value);
						num = 1328538583;
						continue;
					}
					case 1u:
						break;
					case 2u:
						return;
					}
					break;
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable disposable)
			{
				while (true)
				{
					IL_00ac:
					int num4 = 1813551177;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num4 ^ 0x9C5ED6E)) % 3)
						{
						case 2u:
							break;
						default:
							goto end_IL_00b1;
						case 1u:
							goto IL_00ce;
						case 0u:
							goto end_IL_00b1;
						}
						goto IL_00ac;
						IL_00ce:
						disposable.Dispose();
						num4 = (int)(num3 * 871954696) ^ -21419556;
						continue;
						end_IL_00b1:
						break;
					}
					break;
				}
			}
		}
	}

	private static bool existKey_luaConfig(string key)
	{
		init_luaConfig();
		return _202E_206F_202C_202D_202E_206E_200F_202B_206A_202E_206F_200E_206F_200B_200C_200B_206C_202E_202E_202B_200C_202A_206C_206E_202D_200F_202B_200C_206C_202D_200B_200B_206B_202D_202D_206B_206F_200E_202C_200E_202E.ContainsKey(key);
	}

	public static float GetConfigFloat(string key, float init = 0f)
	{
		if (existKey_luaConfig(key))
		{
			while (true)
			{
				uint num;
				switch ((num = 227114518u) % 3)
				{
				case 0u:
					continue;
				case 1u:
					return _200C_202A_200E_202D_206C_200C_206B_206F_202C_202A_200B_206A_206C_202A_206B_206D_202E_202D_200E_200B_206D_206E_206A_206A_200B_200F_206E_200E_202A_200B_206F_202E_206A_206A_202A_200D_206A_206C_200E_206E_202E(GetConfig<object>(key));
				}
				break;
			}
		}
		return init;
	}

	static bool _200E_200F_202B_200B_206E_202C_206F_206C_200C_202E_200C_206E_202A_206A_202B_200D_206C_202B_206A_200C_200D_206D_206E_202E_206D_202D_206C_202C_206D_206C_200D_202D_200C_200C_200E_202C_202D_200F_206B_202E(string P_0, string P_1)
	{
		return P_0.StartsWith(P_1);
	}

	static string _206C_202B_202B_206A_200C_202B_206E_206F_206B_200C_202D_206A_200D_202B_206A_200E_206B_202E_200E_206A_206B_202B_200E_206B_200C_202C_202B_200F_200F_200D_206C_206E_200C_206C_200D_202A_202C_202D_200D_202E_202E(string P_0, string P_1, string P_2)
	{
		return P_0.Replace(P_1, P_2);
	}

	static string _200D_200E_200C_206A_202B_206A_200F_200D_200C_206A_206C_206F_206B_206B_200E_202B_200E_200B_200B_202D_200E_202A_202E_202C_200F_206E_200D_206E_206B_202E_202C_206B_202D_200E_202C_206D_200E_200E_202C_206F_202E(string P_0, string P_1, string P_2)
	{
		return P_0 + P_1 + P_2;
	}

	static StreamReader _206F_206B_202C_200C_202A_206B_206E_200B_206F_200C_202A_206B_200B_202A_202E_200E_202E_206C_206F_202D_200C_206E_206F_200D_202A_202B_206C_206E_206C_200F_206E_206D_200C_202C_200C_202B_206D_206C_200E_200D_202E(string P_0)
	{
		return new StreamReader(P_0);
	}

	static string _202A_200B_200B_202E_206C_206B_200B_202D_200E_200B_206C_206D_200D_202E_206D_206F_206C_202E_200D_206B_202A_202E_200F_206B_202E_200D_206E_200E_206E_206A_206A_202E_202C_200F_200E_206A_200B_206B_200F_206B_202E(TextReader P_0)
	{
		return P_0.ReadToEnd();
	}

	static string _202E_202A_202D_206B_206C_200F_200D_206F_202C_206E_200C_202B_200C_200E_206D_206C_206A_206E_206B_206E_206B_206A_206A_200F_202B_200C_202A_206D_202B_200E_200E_202D_206E_202E_200F_202E_200C_206D_206E_202B_202E(string P_0, string P_1)
	{
		return P_0 + P_1;
	}

	static int _202E_202B_202D_200E_200C_202E_206F_200B_206A_206F_200C_200F_206A_200D_202E_200C_206E_200D_200D_202C_200D_206C_202A_200E_200E_200B_202D_200D_200C_202D_206C_202C_200B_200F_202D_206E_202D_202A_202E_202A_202E(string P_0)
	{
		return P_0.Length;
	}

	static Encoding _202C_200D_206E_200D_200C_200F_200F_200D_206C_206E_202B_206E_200B_200F_200F_202E_200C_206E_200C_206C_202D_200F_206B_206E_206C_200E_202E_206A_206B_200C_200F_206D_206C_200F_206F_206C_202B_206C_206A_200F_202E()
	{
		return Encoding.UTF8;
	}

	static byte[] _202C_206B_206C_200F_202D_206E_206F_206B_200E_202D_206B_200B_206B_202A_200B_200E_200F_202A_202E_202A_206B_200F_202B_206D_206C_206E_202B_206A_206F_206A_200C_200B_206E_202B_206D_206E_206B_206F_206C_200F_202E(Encoding P_0, string P_1)
	{
		return P_0.GetBytes(P_1);
	}

	static void _206A_206C_200E_206E_206F_202A_200E_202E_206F_206A_202E_206C_206B_202B_202A_206D_206D_200E_202A_202B_206E_202C_200B_206F_202B_206A_206D_202B_202A_202D_202C_206E_202C_206F_202A_206B_206A_200B_206E_206D_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}

	static string _206E_202A_206B_202C_202A_202B_200E_200F_202E_202C_200C_202B_206F_200C_206D_206E_202A_202C_200C_206C_202D_202C_200B_202D_200E_206D_206F_206B_200B_206E_202B_206D_202C_202A_206A_202D_200B_206E_206C_202E_202E(Exception P_0)
	{
		return P_0.ToString();
	}

	static void _202B_200B_200C_206B_206A_200B_200E_202B_200F_202C_206C_200C_200B_206D_206A_206B_200B_202D_206C_206E_206A_202A_206C_200B_202B_202D_202C_206D_202C_202D_202C_200C_206A_206D_206C_200D_206A_206B_200F_206B_202E(object P_0)
	{
		Debug.LogError(P_0);
	}

	static IEnumerator _202E_206D_202D_206E_200D_206A_206B_200F_206E_200B_202E_202A_202B_206A_200B_202D_200F_206C_206D_200D_202B_206C_206F_206E_202E_202C_206B_206D_206B_200D_206A_202C_206A_200C_202B_200E_200B_202A_200E_200E_202E(IEnumerable P_0)
	{
		return P_0.GetEnumerator();
	}

	static object _206A_206C_206D_200F_202D_206D_202E_206F_200F_206E_206B_202E_202B_206D_202B_206B_206B_206B_200C_200F_202E_200E_206C_206C_202E_202E_206B_206A_206E_202A_206F_206E_206E_200B_202C_206E_200C_200E_206A_206F_202E(IEnumerator P_0)
	{
		return P_0.Current;
	}

	static bool _206E_206B_202D_206E_206C_202B_202D_206D_200D_200B_200D_200B_206F_206D_202E_206A_206D_206F_206F_200E_202C_202D_200C_200C_202E_206C_200E_206A_202E_206A_202E_206B_206C_206E_202B_200E_206A_206A_202A_206D_202E(IEnumerator P_0)
	{
		return P_0.MoveNext();
	}

	static int _200C_206A_200D_200C_206A_200E_206F_200E_206F_200E_200C_206E_206C_202D_202B_206C_206C_200B_206C_202B_200F_206C_200D_206F_200E_206D_206B_202C_206E_206F_206E_200F_200E_200B_206A_200C_206A_206E_200E_202D_202E(object P_0)
	{
		return Convert.ToInt32(P_0);
	}

	static double _206E_202C_206B_202E_200C_206D_206B_200B_206A_206C_202A_206C_206B_202A_202E_206D_206C_206C_206B_200D_200D_206B_206E_206E_200C_200F_206F_206B_202B_206E_200E_202C_200B_200B_200F_202B_200C_202B_202D_206E_202E(object P_0)
	{
		return Convert.ToDouble(P_0);
	}

	static string _206C_206E_206C_200D_200D_202B_200C_200B_206F_206B_202D_200F_206D_202C_200D_202C_200D_206F_206F_202A_202C_200B_206B_200F_202B_206A_200D_200E_200B_202C_202C_206E_206D_206C_202A_202B_202D_206D_206A_202A_202E(object P_0)
	{
		return Convert.ToString(P_0);
	}

	static string _206B_206E_206F_206F_200F_202A_202D_202B_200B_202B_202B_200C_206B_206F_206F_202A_200C_206F_206F_202C_200D_200C_202D_206C_202E_206C_202E_206B_200E_200B_206A_200E_206F_202C_202B_202D_200E_202C_202D_206C_202E(string P_0, int P_1, string P_2)
	{
		return P_0.Insert(P_1, P_2);
	}

	static int _200B_202A_200C_200E_206F_202E_206B_202C_206D_206F_206A_200E_200B_202C_206B_206A_200D_202D_206E_202E_200B_202A_206F_200D_200B_200E_202D_200F_206D_206D_206D_200B_200D_200D_202D_206F_206F_200C_200C_206B_202E(string P_0, int P_1)
	{
		return Convert.ToInt32(P_0, P_1);
	}

	static string[] _202A_206F_202C_202B_206F_206D_200C_202A_200C_202E_206A_206D_200D_200B_206F_202A_202A_202A_202A_206D_200E_200E_200B_200F_202E_200B_200C_206C_200E_202C_200B_206A_206F_200B_206A_206D_206C_200C_206E_202E_202E(string P_0, char[] P_1)
	{
		return P_0.Split(P_1);
	}

	static StringBuilder _206A_200B_200B_206B_206E_202B_202D_202A_202C_202A_202C_200E_200F_206B_206C_206F_202D_202D_200F_200E_202B_200E_202E_202A_200C_206A_206A_202B_206C_206D_200D_206F_200C_202D_202E_200D_202E_206A_206D_202C_202E()
	{
		return new StringBuilder();
	}

	static string _206E_206B_202B_202C_206F_200D_202B_200E_202E_200D_206E_202B_200E_206C_206A_200D_206E_200D_206A_200B_202E_202D_202D_206E_200B_206F_200D_206F_202A_200B_202A_202A_200B_202B_202E_202E_200B_200F_206A_206D_202E(string P_0, int P_1, int P_2)
	{
		return P_0.Remove(P_1, P_2);
	}

	static string _206C_202B_206C_206E_200F_202C_206C_206E_200E_200E_200F_206C_200B_202A_202C_200B_206D_206B_202C_206C_206D_206E_200D_206D_202A_202A_200F_202E_206E_202B_206C_200B_206D_202E_200F_206A_206E_200B_202C_200C_202E(string P_0, int P_1, int P_2)
	{
		return P_0.Substring(P_1, P_2);
	}

	static StringBuilder _200D_202D_206E_206E_206E_200C_202C_206C_206C_200D_206F_206B_206E_202B_206F_202B_200B_206D_202B_202A_202B_202A_202C_206F_200E_202C_202D_202D_200B_200F_206C_200C_200C_200F_206A_206C_200B_206C_206D_206E_202E(StringBuilder P_0, char P_1)
	{
		return P_0.Append(P_1);
	}

	static void _206C_200C_202C_202A_202C_202E_202B_202B_206A_206D_206A_206D_202D_206A_200B_200C_206B_206B_200E_206B_200D_200B_200C_206C_202B_200D_206B_202D_206D_202C_202A_206C_200F_200C_200B_206E_206E_206E_202E_206E_202E(Array P_0, int P_1, int P_2)
	{
		Array.Clear(P_0, P_1, P_2);
	}

	static string _206F_202A_206B_200D_200D_202C_200D_206D_200B_200B_206C_200C_206A_206F_202A_200F_206C_206F_206C_200C_202B_202B_200E_206D_200C_206E_206E_200C_206F_200D_200F_206A_202A_202A_200F_200E_206B_202B_206E_206C_202E(object P_0)
	{
		return P_0.ToString();
	}

	static bool _202D_200D_206F_202D_200B_206C_206E_206D_200E_206E_202D_200F_202B_202C_200C_206B_202B_202C_206E_202A_206F_206C_206C_206C_202B_202A_200F_202B_202A_206F_200F_200F_206F_202C_206E_202B_200D_202B_206C_202D_202E(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}

	static byte[] _202D_202C_200D_200D_206C_202B_206A_202D_202E_200C_200C_206B_202A_206A_206D_202E_202B_206A_200B_200F_200B_200F_206A_200D_202A_202D_202B_200B_200E_200C_200D_206C_202E_200E_206A_202D_202D_202A_202C_200F_202E(string P_0)
	{
		return Convert.FromBase64String(P_0);
	}

	static RijndaelManaged _206C_200C_206A_202C_202A_206A_202B_200D_202E_202B_200E_200E_200E_202A_200E_202C_200B_206D_206A_202E_206A_206B_202E_202A_200B_202A_206F_200B_206F_200F_202E_206C_206C_200D_200F_202C_200F_200E_200D_202B_202E()
	{
		return new RijndaelManaged();
	}

	static void _202B_202C_200B_206A_206C_206B_202E_206C_206D_206D_202D_206D_200F_206A_202A_206B_206F_202B_206F_202D_200F_206D_200C_200E_202A_200F_206D_202E_206D_200C_200D_206B_200F_202B_200E_202A_200B_200B_200C_206E_202E(SymmetricAlgorithm P_0, byte[] P_1)
	{
		P_0.IV = P_1;
	}

	static void _206F_202A_200F_202B_202C_202B_206B_200B_200E_202D_202C_206D_206C_202C_206D_200C_200F_206A_206E_202D_206A_200C_202A_200E_206E_200F_202D_202B_200B_200B_200D_206C_200C_206D_200D_206C_202A_206B_206E_200D_202E(SymmetricAlgorithm P_0, byte[] P_1)
	{
		P_0.Key = P_1;
	}

	static void _206E_206C_206C_202C_202D_206E_202D_202D_206E_202B_202D_200F_202A_206C_200F_200E_200D_202B_202C_200D_200D_206B_202C_206F_200B_202B_202B_202E_200B_202C_202D_206C_206F_200F_206E_200D_206B_200F_202C_202B_202E(SymmetricAlgorithm P_0, CipherMode P_1)
	{
		P_0.Mode = P_1;
	}

	static void _202A_200B_206E_206E_200F_200D_200E_202D_206A_206C_206C_202C_200D_202D_206A_200C_202A_200E_206D_206A_206A_206A_206D_200B_200B_200E_202B_200C_202A_206A_202D_202A_202B_206D_206B_200D_202B_206F_202D_200F_202E(SymmetricAlgorithm P_0, PaddingMode P_1)
	{
		P_0.Padding = P_1;
	}

	static ICryptoTransform _206E_206E_202C_202E_200C_206D_202B_206C_202B_202D_202E_206F_206F_200C_206C_200C_200F_202D_206E_200B_200B_206B_206B_206B_200C_200C_202C_202D_206D_206F_202A_206F_206F_206E_202B_200E_200D_200D_206D_202A_202E(SymmetricAlgorithm P_0)
	{
		return P_0.CreateDecryptor();
	}

	static byte[] _206F_206B_200B_206D_202E_206F_206F_206D_206B_206F_200F_202B_202C_206F_202D_202E_202E_200C_206D_202B_200D_200B_202A_202D_200F_206E_200B_202C_206A_200F_200D_202E_206A_202C_202A_206F_206B_206D_202C_202C_202E(ICryptoTransform P_0, byte[] P_1, int P_2, int P_3)
	{
		return P_0.TransformFinalBlock(P_1, P_2, P_3);
	}

	static float _200C_202A_200E_202D_206C_200C_206B_206F_202C_202A_200B_206A_206C_202A_206B_206D_202E_202D_200E_200B_206D_206E_206A_206A_200B_200F_206E_200E_202A_200B_206F_202E_206A_206A_202A_200D_206A_206C_200E_206E_202E(object P_0)
	{
		return Convert.ToSingle(P_0);
	}
}
