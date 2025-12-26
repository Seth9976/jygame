using System;
using System.IO;
using JyGame;
using UnityEngine;

namespace LuaInterface;

public static class LuaStatic
{
	public static ReadLuaFile Load;

	public static string init_luanet;

	static LuaStatic()
	{
		init_luanet = global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2570947982u);
		while (true)
		{
			int num = -1018852273;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -770539942)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_0031;
				case 2u:
					return;
				}
				break;
				IL_0031:
				Load = LuaManager.JyGameLuaLoader;
				num = (int)((num2 * 1305909969) ^ 0x24052B32);
			}
		}
	}

	public static byte[] DefaultLoader(string path)
	{
		byte[] result = null;
		if (_206B_206B_202C_200B_206E_200C_200C_200D_202E_206C_200B_202C_206E_202C_202B_200D_206B_200B_200E_206B_200E_206F_200B_200B_202D_202A_202C_202A_206B_206D_200F_202E_202E_202E_206F_206F_202B_202E_202E_202A_202E(path))
		{
			while (true)
			{
				int num = -568767700;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1312697682)) % 3)
					{
					case 0u:
						break;
					case 1u:
						result = _200F_200F_206D_202A_202B_200C_200D_202C_200D_202C_206D_206F_206B_202A_202B_202C_206C_202B_200E_206C_206C_200F_202D_200E_200D_202E_202A_200C_206F_202D_200B_200E_206E_200F_202A_202C_202A_200E_202C_202B_202E(path);
						num = ((int)num2 * -677338253) ^ -70328944;
						continue;
					default:
						goto end_IL_000a;
					}
					break;
				}
				continue;
				end_IL_000a:
				break;
			}
		}
		return result;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int panic(IntPtr L)
	{
		string text = _202B_202E_202B_200B_206C_202C_206A_200F_200B_206B_206A_202C_206A_206F_200C_206E_206F_206F_200E_202D_202E_202E_206B_206D_206F_200E_206E_206D_202D_202B_200D_202E_200F_206F_206D_200D_202A_200E_200E_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1862343508u), (object)LuaDLL.lua_tostring(L, -1));
		LuaDLL.lua_pop(L, 1);
		throw new LuaException(text);
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int traceback(IntPtr L)
	{
		LuaDLL.lua_getglobal(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1227228444u));
		LuaDLL.lua_getfield(L, -1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(849556498u));
		while (true)
		{
			int num = 479748803;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7CFB5454)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_0043;
				default:
					return 1;
				}
				break;
				IL_0043:
				LuaDLL.lua_pushvalue(L, 1);
				LuaDLL.lua_pushnumber(L, 2.0);
				LuaDLL.lua_call(L, 2, 1);
				num = ((int)num2 * -816593034) ^ 0x58D0F824;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int print(IntPtr L)
	{
		int num = LuaDLL.lua_gettop(L);
		string text = default(string);
		int num4 = default(int);
		while (true)
		{
			int num2 = -1869270325;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1302486358)) % 14)
				{
				case 10u:
					break;
				case 1u:
					text = string.Empty;
					num2 = (int)((num3 * 1467071639) ^ 0x4AF427BA);
					continue;
				case 0u:
					LuaDLL.lua_pop(L, 1);
					num2 = (int)(num3 * 2141666000) ^ -746098264;
					continue;
				case 11u:
					text = _200B_202A_202C_200E_200B_200F_206E_200B_200F_206C_206F_206E_202A_202C_202B_202B_206D_200B_202B_206C_206C_200E_206E_206B_206D_206F_206F_200B_202D_200E_206C_200C_200E_206F_200E_200E_202C_206A_202B_200C_202E(text, LuaDLL.lua_tostring(L, -1));
					num2 = -2016159682;
					continue;
				case 13u:
					_206E_202E_206E_200D_206E_202A_206C_206F_206E_206F_202B_202D_206C_200F_206F_202E_202A_200D_202C_200B_202B_200E_206E_200C_202D_200B_200C_206F_200D_200E_206A_202C_206D_200C_202D_206E_200F_206F_206C_200D_202E((object)_200B_202A_202C_200E_200B_200F_206E_200B_200F_206C_206F_206E_202A_202C_202B_202B_206D_200B_202B_206C_206C_200E_206E_206B_206D_206F_206F_200B_202D_200E_206C_200C_200E_206F_200E_200E_202C_206A_202B_200C_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(948750677u), text));
					num2 = (int)((num3 * 1483060707) ^ 0x6D7DE3A3);
					continue;
				case 5u:
					LuaDLL.lua_getglobal(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3503982079u));
					num4 = 1;
					num2 = ((int)num3 * -1606226958) ^ -682207631;
					continue;
				case 4u:
					LuaDLL.lua_pushvalue(L, -1);
					num2 = -608973324;
					continue;
				case 6u:
					LuaDLL.lua_pushvalue(L, num4);
					LuaDLL.lua_call(L, 1, 1);
					num2 = ((int)num3 * -583526525) ^ -938294707;
					continue;
				case 8u:
				{
					int num7;
					if (num4 <= num)
					{
						num2 = -1532824916;
						num7 = num2;
					}
					else
					{
						num2 = -69491083;
						num7 = num2;
					}
					continue;
				}
				case 7u:
				{
					int num5;
					int num6;
					if (num4 > 1)
					{
						num5 = -826007592;
						num6 = num5;
					}
					else
					{
						num5 = -1682727212;
						num6 = num5;
					}
					num2 = num5 ^ (int)(num3 * 1822591859);
					continue;
				}
				case 9u:
					text = _200B_202A_202C_200E_200B_200F_206E_200B_200F_206C_206F_206E_202A_202C_202B_202B_206D_200B_202B_206C_206C_200E_206E_206B_206D_206F_206F_200B_202D_200E_206C_200C_200E_206F_200E_200E_202C_206A_202B_200C_202E(text, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2647788117u));
					num2 = ((int)num3 * -1055238529) ^ 0x6D7BD4D8;
					continue;
				case 12u:
					num4++;
					num2 = (int)(num3 * 1252683849) ^ -1830782750;
					continue;
				case 3u:
					num2 = ((int)num3 * -110617355) ^ 0x1329DCF9;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int loader(IntPtr L)
	{
		string text = string.Empty;
		string text2 = default(string);
		int oldTop = default(int);
		byte[] array = default(byte[]);
		LuaScriptMgr mgrFromLuaState = default(LuaScriptMgr);
		while (true)
		{
			int num = 544025560;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5A63B753)) % 18)
				{
				case 3u:
					break;
				case 2u:
				{
					int num7;
					int num8;
					if (!_202B_206F_202D_202C_200F_202B_202A_206C_206C_200B_202D_206D_206A_206F_202A_200F_206D_202C_202B_202E_202E_206D_206D_206E_202C_202C_206F_206B_206F_200B_200E_206F_202A_202E_206A_202D_200E_202D_206E_200E_202E(text, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2774838779u)))
					{
						num7 = 2038942188;
						num8 = num7;
					}
					else
					{
						num7 = 1871313469;
						num8 = num7;
					}
					num = num7 ^ ((int)num2 * -202064384);
					continue;
				}
				case 4u:
					LuaDLL.lua_pop(L, 1);
					num = (int)((num2 * 248098284) ^ 0x7F2495E8);
					continue;
				case 6u:
					LuaDLL.lua_pop(L, 1);
					num = 615758303;
					continue;
				case 9u:
					text2 = _206A_206F_202D_200F_202B_202B_202A_206E_202B_202C_206A_200B_206C_206D_200F_202C_206B_202B_202A_202E_200E_200E_206C_206A_200E_206C_202A_200C_200E_200E_206C_200F_202E_200F_200B_206F_200D_200F_206B_202E_202E(text);
					num = ((int)num2 * -1230188676) ^ -729904925;
					continue;
				case 12u:
					oldTop = LuaDLL.lua_gettop(L);
					array = Load(text);
					num = (int)(num2 * 1406398509) ^ -1248908489;
					continue;
				case 10u:
				{
					int num4;
					int num5;
					if (array != null)
					{
						num4 = 2094522692;
						num5 = num4;
					}
					else
					{
						num4 = 759957735;
						num5 = num4;
					}
					num = num4 ^ ((int)num2 * -261259393);
					continue;
				}
				case 11u:
					text = LuaDLL.lua_tostring(L, 1);
					num = ((int)num2 * -783472862) ^ 0x1FF050BA;
					continue;
				case 8u:
				{
					int num11 = _202A_202B_206D_202B_206C_202D_202C_206D_206C_206D_202E_200C_206E_206A_202D_202A_206B_202E_206E_202A_206C_200E_200F_200D_202A_202A_202D_202D_202C_206A_202B_202E_200F_200B_206E_202A_202B_202C_200D_202E_202E(text, '.');
					text = _200E_202A_202E_206D_206D_202B_200B_206B_206C_202B_206F_202A_200F_206B_206C_200B_202D_206D_202C_202D_202B_202E_202E_200F_200D_200F_206C_206C_200B_200C_206E_202E_206A_206C_200D_200E_206C_200D_202C_202B_202E(text, 0, num11);
					num = ((int)num2 * -947298352) ^ 0x40FFC3A2;
					continue;
				}
				case 0u:
				{
					int num9;
					int num10;
					if (!_206D_200C_202D_206A_206F_206D_206B_200B_202A_202C_200D_200D_202A_202C_206E_202D_206C_206E_200C_200D_200C_200E_206B_200F_200D_206C_206F_202C_202C_206A_202C_206E_200D_206A_200C_206C_202C_206F_206E_202B_202E(text2, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2851820599u)))
					{
						num9 = 319839730;
						num10 = num9;
					}
					else
					{
						num9 = 24720943;
						num10 = num9;
					}
					num = num9 ^ (int)(num2 * 1748834932);
					continue;
				}
				case 14u:
					return 0;
				case 16u:
					LuaDLL.lua_pushstdcallcfunction(L, mgrFromLuaState.lua.tracebackFunction);
					num = 1606545939;
					continue;
				case 1u:
					Debugger.LogError(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1506693110u), text);
					num = ((int)num2 * -812416300) ^ 0x79CFFE11;
					continue;
				case 7u:
					mgrFromLuaState.lua.ThrowExceptionFromError(oldTop);
					num = ((int)num2 * -2024043700) ^ 0x575394DB;
					continue;
				case 13u:
				{
					text = _200B_202A_202C_200E_200B_200F_206E_200B_200F_206C_206F_206E_202A_202C_202B_202B_206D_200B_202B_206C_206C_200E_206E_206B_206D_206F_206F_200B_202D_200E_206C_200C_200E_206F_200E_200E_202C_206A_202B_200C_202E(_206C_206C_200C_206F_202D_206F_200B_202E_200B_202B_206A_200D_200D_206F_200E_200D_202C_206D_206B_202C_206A_200C_206A_200F_200C_200F_202E_200B_206B_202C_202E_206C_206F_200B_200E_206B_202E_206C_206C_202B_202E(text, '.', '/'), global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1817760260u));
					mgrFromLuaState = LuaScriptMgr.GetMgrFromLuaState(L);
					int num6;
					if (mgrFromLuaState != null)
					{
						num = 803877335;
						num6 = num;
					}
					else
					{
						num = 1378688972;
						num6 = num;
					}
					continue;
				}
				case 17u:
					return 0;
				case 5u:
				{
					int num3;
					if (LuaDLL.luaL_loadbuffer(L, array, array.Length, text) == 0)
					{
						num = 1371824696;
						num3 = num;
					}
					else
					{
						num = 1409902100;
						num3 = num;
					}
					continue;
				}
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int dofile(IntPtr L)
	{
		string text = string.Empty;
		byte[] array = default(byte[]);
		int num8 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 802015776;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x109BBE)) % 11)
				{
				case 5u:
					break;
				case 1u:
				{
					int num6;
					int num7;
					if (array == null)
					{
						num6 = 1039784334;
						num7 = num6;
					}
					else
					{
						num6 = 1498812166;
						num7 = num6;
					}
					num = num6 ^ ((int)num2 * -1542728076);
					continue;
				}
				case 4u:
					LuaDLL.lua_call(L, 0, LuaDLL.LUA_MULTRET);
					num = ((int)num2 * -800634797) ^ 0xF8CD7E0;
					continue;
				case 10u:
					num8 = _202A_202B_206D_202B_206C_202D_202C_206D_206C_206D_202E_200C_206E_206A_202D_202A_206B_202E_206E_202A_206C_200E_200F_200D_202A_202A_202D_202D_202C_206A_202B_202E_200F_200B_206E_202A_202B_202C_200D_202E_202E(text, '.');
					num = (int)(num2 * 1094462181) ^ -1343443589;
					continue;
				case 3u:
				{
					int num9;
					if (LuaDLL.luaL_loadbuffer(L, array, array.Length, text) == 0)
					{
						num = 1091666651;
						num9 = num;
					}
					else
					{
						num = 1913549919;
						num9 = num;
					}
					continue;
				}
				case 8u:
					text = _200B_202A_202C_200E_200B_200F_206E_200B_200F_206C_206F_206E_202A_202C_202B_202B_206D_200B_202B_206C_206C_200E_206E_206B_206D_206F_206F_200B_202D_200E_206C_200C_200E_206F_200E_200E_202C_206A_202B_200C_202E(_206C_206C_200C_206F_202D_206F_200B_202E_200B_202B_206A_200D_200D_206F_200E_200D_202C_206D_206B_202C_206A_200C_206A_200F_200C_200F_202E_200B_206B_202C_202E_206C_206F_200B_200E_206B_202E_206C_206C_202B_202E(text, '.', '/'), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2851820599u));
					num3 = LuaDLL.lua_gettop(L);
					array = Load(text);
					num = 29026686;
					continue;
				case 7u:
					text = LuaDLL.lua_tostring(L, 1);
					num = (int)(num2 * 1162714122) ^ -554079075;
					continue;
				case 6u:
					return LuaDLL.lua_gettop(L) - num3;
				case 2u:
					text = _200E_202A_202E_206D_206D_202B_200B_206B_206C_202B_206F_202A_200F_206B_206C_200B_202D_206D_202C_202D_202B_202E_202E_200F_200D_200F_206C_206C_200B_200C_206E_202E_206A_206C_200D_200E_206C_200D_202C_202B_202E(text, 0, num8);
					num = (int)((num2 * 970801843) ^ 0x7B7AAC1E);
					continue;
				case 9u:
				{
					string text2 = _206A_206F_202D_200F_202B_202B_202A_206E_202B_202C_206A_200B_206C_206D_200F_202C_206B_202B_202A_202E_200E_200E_206C_206A_200E_206C_202A_200C_200E_200E_206C_200F_202E_200F_200B_206F_200D_200F_206B_202E_202E(text);
					int num4;
					int num5;
					if (_206D_200C_202D_206A_206F_206D_206B_200B_202A_202C_200D_200D_202A_202C_206E_202D_206C_206E_200C_200D_200C_200E_206B_200F_200D_206C_206F_202C_202C_206A_202C_206E_200D_206A_200C_206C_202C_206F_206E_202B_202E(text2, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2023535542u)))
					{
						num4 = 1876565329;
						num5 = num4;
					}
					else
					{
						num4 = 1515231596;
						num5 = num4;
					}
					num = num4 ^ (int)(num2 * 1644678876);
					continue;
				}
				default:
					return LuaDLL.lua_gettop(L) - num3;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int loadfile(IntPtr L)
	{
		return loader(L);
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int importWrap(IntPtr L)
	{
		string text = string.Empty;
		while (true)
		{
			int num = -2068752001;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -628573681)) % 6)
				{
				case 3u:
					break;
				case 4u:
					text = LuaDLL.lua_tostring(L, 1);
					num = ((int)num2 * -1067722498) ^ -659132140;
					continue;
				case 5u:
					text = _206C_206C_200C_206F_202D_206F_200B_202E_200B_202B_206A_200D_200D_206F_200E_200D_202C_206D_206B_202C_206A_200C_206A_200F_200C_200F_202E_200B_206B_202C_202E_206C_206F_200B_200E_206B_202E_206C_206C_202B_202E(text, '.', '_');
					num = ((int)num2 * -1204640416) ^ -2073107367;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (_202D_206E_202A_202B_202B_200D_206E_206F_206F_206C_206D_202E_200F_200B_206A_202B_202B_200F_202B_202E_202E_200F_206A_206E_200F_206A_202A_202D_200C_202A_202E_206E_206D_200E_206B_206B_200F_202A_206F_202C_202E(text))
					{
						num3 = 1834785534;
						num4 = num3;
					}
					else
					{
						num3 = 1295557825;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 408600783);
					continue;
				}
				case 2u:
					LuaBinder.Bind(L, text);
					num = ((int)num2 * -1029833821) ^ -821510920;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	static bool _206B_206B_202C_200B_206E_200C_200C_200D_202E_206C_200B_202C_206E_202C_202B_200D_206B_200B_200E_206B_200E_206F_200B_200B_202D_202A_202C_202A_206B_206D_200F_202E_202E_202E_206F_206F_202B_202E_202E_202A_202E(string P_0)
	{
		return File.Exists(P_0);
	}

	static byte[] _200F_200F_206D_202A_202B_200C_200D_202C_200D_202C_206D_206F_206B_202A_202B_202C_206C_202B_200E_206C_206C_200F_202D_200E_200D_202E_202A_200C_206F_202D_200B_200E_206E_200F_202A_202C_202A_200E_202C_202B_202E(string P_0)
	{
		return File.ReadAllBytes(P_0);
	}

	static string _202B_202E_202B_200B_206C_202C_206A_200F_200B_206B_206A_202C_206A_206F_200C_206E_206F_206F_200E_202D_202E_202E_206B_206D_206F_200E_206E_206D_202D_202B_200D_202E_200F_206F_206D_200D_202A_200E_200E_202E(string P_0, object P_1)
	{
		return string.Format(P_0, P_1);
	}

	static string _200B_202A_202C_200E_200B_200F_206E_200B_200F_206C_206F_206E_202A_202C_202B_202B_206D_200B_202B_206C_206C_200E_206E_206B_206D_206F_206F_200B_202D_200E_206C_200C_200E_206F_200E_200E_202C_206A_202B_200C_202E(string P_0, string P_1)
	{
		return P_0 + P_1;
	}

	static void _206E_202E_206E_200D_206E_202A_206C_206F_206E_206F_202B_202D_206C_200F_206F_202E_202A_200D_202C_200B_202B_200E_206E_200C_202D_200B_200C_206F_200D_200E_206A_202C_206D_200C_202D_206E_200F_206F_206C_200D_202E(object P_0)
	{
		Debug.Log(P_0);
	}

	static string _206A_206F_202D_200F_202B_202B_202A_206E_202B_202C_206A_200B_206C_206D_200F_202C_206B_202B_202A_202E_200E_200E_206C_206A_200E_206C_202A_200C_200E_200E_206C_200F_202E_200F_200B_206F_200D_200F_206B_202E_202E(string P_0)
	{
		return P_0.ToLower();
	}

	static bool _206D_200C_202D_206A_206F_206D_206B_200B_202A_202C_200D_200D_202A_202C_206E_202D_206C_206E_200C_200D_200C_200E_206B_200F_200D_206C_206F_202C_202C_206A_202C_206E_200D_206A_200C_206C_202C_206F_206E_202B_202E(string P_0, string P_1)
	{
		return P_0.EndsWith(P_1);
	}

	static int _202A_202B_206D_202B_206C_202D_202C_206D_206C_206D_202E_200C_206E_206A_202D_202A_206B_202E_206E_202A_206C_200E_200F_200D_202A_202A_202D_202D_202C_206A_202B_202E_200F_200B_206E_202A_202B_202C_200D_202E_202E(string P_0, char P_1)
	{
		return P_0.LastIndexOf(P_1);
	}

	static string _200E_202A_202E_206D_206D_202B_200B_206B_206C_202B_206F_202A_200F_206B_206C_200B_202D_206D_202C_202D_202B_202E_202E_200F_200D_200F_206C_206C_200B_200C_206E_202E_206A_206C_200D_200E_206C_200D_202C_202B_202E(string P_0, int P_1, int P_2)
	{
		return P_0.Substring(P_1, P_2);
	}

	static string _206C_206C_200C_206F_202D_206F_200B_202E_200B_202B_206A_200D_200D_206F_200E_200D_202C_206D_206B_202C_206A_200C_206A_200F_200C_200F_202E_200B_206B_202C_202E_206C_206F_200B_200E_206B_202E_206C_206C_202B_202E(string P_0, char P_1, char P_2)
	{
		return P_0.Replace(P_1, P_2);
	}

	static bool _202B_206F_202D_202C_200F_202B_202A_206C_206C_200B_202D_206D_206A_206F_202A_200F_206D_202C_202B_202E_202E_206D_206D_206E_202C_202C_206F_206B_206F_200B_200E_206F_202A_202E_206A_202D_200E_202D_206E_200E_202E(string P_0, string P_1)
	{
		return P_0.Contains(P_1);
	}

	static bool _202D_206E_202A_202B_202B_200D_206E_206F_206F_206C_206D_202E_200F_200B_206A_202B_202B_200F_202B_202E_202E_200F_206A_206E_200F_206A_202A_202D_200C_202A_202E_206E_206D_200E_206B_206B_200F_202A_206F_202C_202E(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}
}
