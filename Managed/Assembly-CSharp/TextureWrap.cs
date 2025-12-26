using System;
using LuaInterface;
using UnityEngine;

public class TextureWrap
{
	private static Type classType = _200C_206E_202C_200D_200E_200E_202C_202A_200E_206E_206D_206E_202B_206B_206C_206A_200E_202B_202E_206C_202E_206D_202B_202A_202A_206A_200C_206E_202A_200D_202A_206C_200F_200F_202A_206C_206E_200F_206C_206C_202E(typeof(Texture).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[5]
		{
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3387414902u), SetGlobalAnisotropicFilteringLimits),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2479173467u), GetNativeTexturePtr),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1657282774u), _206C_200F_202D_202E_200F_200F_200F_206E_200E_206F_200C_202C_206C_200F_200D_206D_206D_206A_200B_202C_202E_206C_206E_200B_206A_206D_202A_200C_206B_206C_200B_200B_200F_206B_200B_206E_202D_206A_202C_206C_202E),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(10103728u), GetClassType),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3465012375u), Lua_Eq)
		};
		LuaField[] fields = default(LuaField[]);
		while (true)
		{
			int num = -223807161;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1266784575)) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_00ef;
				default:
					LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2712008153u), _200C_206E_202C_200D_200E_200E_202C_202A_200E_206E_206D_206E_202B_206B_206C_206A_200E_202B_202E_206C_202E_206D_202B_202A_202A_206A_200C_206E_202A_200D_202A_206C_200F_200F_202A_206C_206E_200F_206C_206C_202E(typeof(Texture).TypeHandle), regs, fields, _200C_206E_202C_200D_200E_200E_202C_202A_200E_206E_206D_206E_202B_206B_206C_206A_200E_202B_202E_206C_202E_206D_202B_202A_202A_206A_200C_206E_202A_200D_202A_206C_200F_200F_202A_206C_206E_200F_206C_206C_202E(typeof(Object).TypeHandle));
					return;
				}
				break;
				IL_00ef:
				fields = new LuaField[9]
				{
					new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1238757015u), get_masterTextureLimit, set_masterTextureLimit),
					new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1314228001u), get_anisotropicFiltering, set_anisotropicFiltering),
					new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(569803670u), get_width, set_width),
					new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3412081957u), get_height, set_height),
					new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1988644611u), get_filterMode, set_filterMode),
					new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1224736563u), get_anisoLevel, set_anisoLevel),
					new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2835961013u), get_wrapMode, set_wrapMode),
					new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2479296427u), get_mipMapBias, set_mipMapBias),
					new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3593825082u), get_texelSize, null)
				};
				num = (int)((num2 * 1573860126) ^ 0x1B55664A);
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _206C_200F_202D_202E_200F_200F_200F_206E_200E_206F_200C_202C_206C_200F_200D_206D_206D_206A_200B_202C_202E_206C_206E_200B_206A_206D_202A_200C_206B_206C_200B_200B_200F_206B_200B_206E_202D_206A_202C_206C_202E(IntPtr P_0)
	{
		if (LuaDLL.lua_gettop(P_0) == 0)
		{
			Texture obj = default(Texture);
			while (true)
			{
				int num = 398216729;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x617A7AED)) % 5)
					{
					case 0u:
						break;
					case 4u:
						return 1;
					case 3u:
						LuaScriptMgr.Push(P_0, (Object)(object)obj);
						num = ((int)num2 * -2054665998) ^ 0x443BD370;
						continue;
					case 2u:
						obj = _200B_202A_206D_206C_202B_200E_200E_206A_200F_202D_202E_206D_200B_200F_202A_202B_206C_206B_200D_202A_202E_200C_200F_202B_206F_206B_206B_200E_206C_202D_202E_202C_206C_202C_202E_200F_206B_206D_200F_200E_202E();
						num = ((int)num2 * -1526115835) ^ -654659703;
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
		LuaDLL.luaL_error(P_0, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2634396591u));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_masterTextureLimit(IntPtr L)
	{
		LuaScriptMgr.Push(L, _200C_206A_202D_202E_200C_200C_206F_202B_206F_202A_202B_206B_200B_202D_202B_202A_206A_200B_200F_200B_202C_206E_202D_206B_202C_202B_202E_200D_200E_206D_206B_206A_202B_202B_206C_200E_206C_202C_206A_202B_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_anisotropicFiltering(IntPtr L)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr.Push(L, (Enum)(object)_202C_200F_206A_202C_202B_206A_206F_206E_200E_206A_202A_200B_202B_200E_200F_206F_206F_206B_200E_200B_202E_200F_202A_206A_200E_206D_202E_202A_200C_200B_202B_200E_202D_206A_206B_206D_202C_206A_206B_202A_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_width(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Texture val = (Texture)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -570246348;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -156875539)) % 7)
				{
				case 0u:
					break;
				case 4u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 1789370310;
						num6 = num5;
					}
					else
					{
						num5 = 302559944;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1051080317);
					continue;
				}
				case 6u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 106776076) ^ 0x4E5E00B);
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (_200F_206B_202A_200E_200B_206B_206D_202E_206D_206B_206A_200E_206A_206F_202B_206C_206D_202A_202C_200B_200E_202C_200C_206D_202C_202A_206D_206D_200C_202C_206F_206C_206E_206A_202B_202D_202B_200F_202B_202E((Object)(object)val, (Object)null))
					{
						num3 = -1326754897;
						num4 = num3;
					}
					else
					{
						num3 = -905523209;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1456186495);
					continue;
				}
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(427477000u));
					num = ((int)num2 * -26341597) ^ 0x511C85A9;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1643482095u));
					num = -1859272530;
					continue;
				default:
					LuaScriptMgr.Push(L, _206D_206F_206B_202C_202A_202B_206D_200C_202D_202A_200C_206F_202E_200B_202E_206F_202D_200B_200C_200F_206C_200C_206D_202D_206E_202B_206E_202A_200C_202C_206C_200F_206F_202B_202C_202E_206E_206E_206D_206E_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_height(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Texture val = (Texture)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1605245765;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -77260393)) % 9)
				{
				case 5u:
					break;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1643047661u));
					num = (int)(num2 * 1866407048) ^ -1979487532;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(194279523u));
					num = -1895952830;
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 2072111179;
						num6 = num5;
					}
					else
					{
						num5 = 1034024421;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1239419925);
					continue;
				}
				case 6u:
					num = ((int)num2 * -2093949413) ^ 0x4BDB7B53;
					continue;
				case 4u:
					LuaScriptMgr.Push(L, _200C_202B_206D_202A_202A_202E_200C_202C_206C_200C_200D_200E_200B_200F_206F_202E_200E_202A_200D_202E_206D_200C_206A_206E_202D_202D_206B_202C_202E_202B_206D_206D_200D_206A_200D_202E_202C_200B_206A_206B_202E(val));
					num = -2006869945;
					continue;
				case 0u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -401983413) ^ 0x3F83327B;
					continue;
				case 8u:
				{
					int num3;
					int num4;
					if (!_200F_206B_202A_200E_200B_206B_206D_202E_206D_206B_206A_200E_206A_206F_202B_206C_206D_202A_202C_200B_200E_202C_200C_206D_202C_202A_206D_206D_200C_202C_206F_206C_206E_206A_202B_202D_202B_200F_202B_202E((Object)(object)val, (Object)null))
					{
						num3 = 1988483810;
						num4 = num3;
					}
					else
					{
						num3 = 323315519;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1978375800);
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
	private static int get_filterMode(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Texture val = default(Texture);
		while (true)
		{
			int num = 1687323196;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1C2DD0EC)) % 7)
				{
				case 0u:
					break;
				case 2u:
				{
					val = (Texture)luaObject;
					int num5;
					int num6;
					if (!_200F_206B_202A_200E_200B_206B_206D_202E_206D_206B_206A_200E_206A_206F_202B_206C_206D_202A_202C_200B_200E_202C_200C_206D_202C_202A_206D_206D_200C_202C_206F_206C_206E_206A_202B_202D_202B_200F_202B_202E((Object)(object)val, (Object)null))
					{
						num5 = -619422984;
						num6 = num5;
					}
					else
					{
						num5 = -331921676;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 424285452);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2219969740u));
					num = 1106684728;
					continue;
				case 1u:
					num = ((int)num2 * -2087786173) ^ -1476279613;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2763449753u));
					num = (int)(num2 * 1310598011) ^ -1893380728;
					continue;
				case 5u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 1670849683;
						num4 = num3;
					}
					else
					{
						num3 = 825210220;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -664310841);
					continue;
				}
				default:
					LuaScriptMgr.Push(L, (Enum)(object)_200C_202A_200D_202D_202C_200C_206F_202E_202A_200E_206B_200B_200F_206E_200E_200C_200C_202E_202B_200E_202E_206E_200D_200D_202C_200C_206D_206B_200D_206B_202D_200C_206F_200D_206D_202D_200F_202E_200C_200E_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_anisoLevel(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Texture val = (Texture)luaObject;
		if (_200F_206B_202A_200E_200B_206B_206D_202E_206D_206B_206A_200E_206A_206F_202B_206C_206D_202A_202C_200B_200E_202C_200C_206D_202C_202A_206D_206D_200C_202C_206F_206C_206E_206A_202B_202D_202B_200F_202B_202E((Object)(object)val, (Object)null))
		{
			goto IL_0018;
		}
		goto IL_0077;
		IL_0018:
		int num = 157557861;
		goto IL_001d;
		IL_001d:
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x2201BEA2)) % 8)
			{
			case 2u:
				break;
			case 7u:
				luaTypes = LuaDLL.lua_type(L, 1);
				num = (int)((num2 * 470611512) ^ 0x1F052B71);
				continue;
			case 5u:
				num = ((int)num2 * -478637316) ^ -595710914;
				continue;
			case 0u:
				goto IL_0077;
			case 6u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(725029687u));
				num = 2011015122;
				continue;
			case 4u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3389211168u));
				num = (int)((num2 * 680417984) ^ 0x16C4167);
				continue;
			case 3u:
			{
				int num3;
				int num4;
				if (luaTypes == LuaTypes.LUA_TTABLE)
				{
					num3 = 897334494;
					num4 = num3;
				}
				else
				{
					num3 = 1512772972;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 1773700648);
				continue;
			}
			default:
				return 1;
			}
			break;
		}
		goto IL_0018;
		IL_0077:
		LuaScriptMgr.Push(L, _206C_200F_206B_206A_206D_202C_200C_202D_206D_202A_202B_206A_200C_202E_202D_202B_200F_206A_206B_206F_206B_200E_200B_206C_202C_200D_206F_202E_206A_202C_202D_206D_206C_200B_200D_206B_202A_200F_200E_206A_202E(val));
		num = 281167731;
		goto IL_001d;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_wrapMode(IntPtr L)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Texture val = default(Texture);
		while (true)
		{
			int num = 1278166620;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3294F94F)) % 7)
				{
				case 4u:
					break;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1963878662u));
					num = (int)(num2 * 603164401) ^ -182478395;
					continue;
				case 0u:
					LuaScriptMgr.Push(L, (Enum)(object)_206F_206A_202B_202A_206C_206C_206B_200B_202C_202B_206D_206B_202A_202A_202E_206F_206E_206D_202B_206F_202C_202B_200E_200F_200E_200E_200E_206E_202D_206F_206E_200F_202D_200B_200B_202C_200F_202B_206B_202C_202E(val));
					num = 2018236192;
					continue;
				case 2u:
				{
					val = (Texture)luaObject;
					int num5;
					int num6;
					if (!_200F_206B_202A_200E_200B_206B_206D_202E_206D_206B_206A_200E_206A_206F_202B_206C_206D_202A_202C_200B_200E_202C_200C_206D_202C_202A_206D_206D_200C_202C_206F_206C_206E_206A_202B_202D_202B_200F_202B_202E((Object)(object)val, (Object)null))
					{
						num5 = 1301373855;
						num6 = num5;
					}
					else
					{
						num5 = 1227417051;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1480009257);
					continue;
				}
				case 6u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 2069906202;
						num4 = num3;
					}
					else
					{
						num3 = 901305128;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -120986632);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3214913358u));
					num = 233697386;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_mipMapBias(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Texture val = (Texture)luaObject;
		if (_200F_206B_202A_200E_200B_206B_206D_202E_206D_206B_206A_200E_206A_206F_202B_206C_206D_202A_202C_200B_200E_202C_200C_206D_202C_202A_206D_206D_200C_202C_206F_206C_206E_206A_202B_202D_202B_200F_202B_202E((Object)(object)val, (Object)null))
		{
			goto IL_001b;
		}
		goto IL_00b9;
		IL_001b:
		int num = -1886978860;
		goto IL_0020;
		IL_0020:
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1489130609)) % 8)
			{
			case 4u:
				break;
			case 3u:
				luaTypes = LuaDLL.lua_type(L, 1);
				num = ((int)num2 * -2116293272) ^ 0x73B0F865;
				continue;
			case 6u:
				num = ((int)num2 * -878928504) ^ 0x347633B7;
				continue;
			case 1u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2528615845u));
				num = ((int)num2 * -1434501079) ^ -1049093048;
				continue;
			case 2u:
			{
				int num3;
				int num4;
				if (luaTypes != LuaTypes.LUA_TTABLE)
				{
					num3 = -31443474;
					num4 = num3;
				}
				else
				{
					num3 = -1496878304;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 166275919);
				continue;
			}
			case 0u:
				goto IL_00b9;
			case 7u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1417560389u));
				num = -1612551481;
				continue;
			default:
				return 1;
			}
			break;
		}
		goto IL_001b;
		IL_00b9:
		LuaScriptMgr.Push(L, _200D_202B_202C_200E_206D_202B_206D_206B_200C_206D_200D_206C_202D_200D_200F_202B_200F_206D_206F_202A_202D_202A_200C_200D_202D_200F_206D_206B_200B_202C_202C_206D_206E_200E_202D_202B_206D_202B_200D_202E_202E(val));
		num = -1516746430;
		goto IL_0020;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_texelSize(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Texture val = (Texture)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 125883654;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7287493A)) % 9)
				{
				case 6u:
					break;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(816517793u));
					num = 2043585661;
					continue;
				case 0u:
					num = (int)((num2 * 1460801932) ^ 0x47650BD9);
					continue;
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(673427142u));
					num = ((int)num2 * -1191738847) ^ -398979442;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 215858616;
						num6 = num5;
					}
					else
					{
						num5 = 185888985;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1915883679);
					continue;
				}
				case 1u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 1370669403) ^ -425640378;
					continue;
				case 2u:
					LuaScriptMgr.Push(L, _200C_206E_202B_206C_202C_202A_202C_200D_206C_202A_202D_202C_206F_206E_206F_200D_200D_200B_200E_202B_202A_202D_200F_206A_206C_202C_206D_206A_202E_206E_206F_200B_202C_202D_206F_206E_200E_200C_206B_200F_202E(val));
					num = 1887192947;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!_200F_206B_202A_200E_200B_206B_206D_202E_206D_206B_206A_200E_206A_206F_202B_206C_206D_202A_202C_200B_200E_202C_200C_206D_202C_202A_206D_206D_200C_202C_206F_206C_206E_206A_202B_202D_202B_200F_202B_202E((Object)(object)val, (Object)null))
					{
						num3 = -1525115287;
						num4 = num3;
					}
					else
					{
						num3 = -1987831810;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1473744085);
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
	private static int set_masterTextureLimit(IntPtr L)
	{
		_206C_202E_202C_200C_206D_202E_202C_202A_206B_202B_202A_200E_200E_202A_206A_206F_200D_200D_200E_200E_202E_200D_206D_202E_202A_206B_206B_202E_202E_202D_200F_206C_206E_202D_206D_200C_200E_206A_200F_200D_202E((int)LuaScriptMgr.GetNumber(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_anisotropicFiltering(IntPtr L)
	{
		_200B_206D_206A_200E_206E_202B_200F_202E_206A_202D_206D_206C_202A_206E_200D_206F_202C_206D_206C_200E_200F_200E_200F_200B_200B_206D_202D_206B_206C_200C_206E_200E_202B_206E_202D_200B_200D_200D_200B_206B_202E((AnisotropicFiltering)(int)LuaScriptMgr.GetNetObject(L, 3, _200C_206E_202C_200D_200E_200E_202C_202A_200E_206E_206D_206E_202B_206B_206C_206A_200E_202B_202E_206C_202E_206D_202B_202A_202A_206A_200C_206E_202A_200D_202A_206C_200F_200F_202A_206C_206E_200F_206C_206C_202E(typeof(AnisotropicFiltering).TypeHandle)));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_width(IntPtr L)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Texture val = default(Texture);
		while (true)
		{
			int num = -613548106;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1428493205)) % 9)
				{
				case 6u:
					break;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3874927197u));
					num = ((int)num2 * -1821781835) ^ 0x5EF95E68;
					continue;
				case 5u:
					_200C_200D_202A_202C_202B_200F_200B_206A_202A_202B_202C_200F_206E_200D_202B_206B_202D_202C_206A_206F_200F_200C_200B_206B_200B_200C_200D_206F_206D_202B_206A_202C_202D_200B_200D_202A_202A_200B_200D_202E_202E(val, (int)LuaScriptMgr.GetNumber(L, 3));
					num = -119455466;
					continue;
				case 2u:
					num = ((int)num2 * -115475448) ^ -177154944;
					continue;
				case 3u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 1676251673;
						num6 = num5;
					}
					else
					{
						num5 = 1311308153;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -18279680);
					continue;
				}
				case 8u:
					val = (Texture)luaObject;
					num = ((int)num2 * -1776831538) ^ 0x34B808F5;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(848065061u));
					num = -1924852408;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (_200F_206B_202A_200E_200B_206B_206D_202E_206D_206B_206A_200E_206A_206F_202B_206C_206D_202A_202C_200B_200E_202C_200C_206D_202C_202A_206D_206D_200C_202C_206F_206C_206E_206A_202B_202D_202B_200F_202B_202E((Object)(object)val, (Object)null))
					{
						num3 = -1403405610;
						num4 = num3;
					}
					else
					{
						num3 = -1262124600;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1998722576);
					continue;
				}
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_height(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Texture val = (Texture)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1942103316;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x408CBFD8)) % 9)
				{
				case 5u:
					break;
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1332601413u));
					num = 1145346220;
					continue;
				case 3u:
					num = (int)(num2 * 1346790281) ^ -1174637222;
					continue;
				case 7u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -2076587664) ^ 0x58ED4442;
					continue;
				case 0u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -2105934903;
						num6 = num5;
					}
					else
					{
						num5 = -952309734;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1962433472);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2190676474u));
					num = ((int)num2 * -1788203698) ^ -1387200464;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!_200F_206B_202A_200E_200B_206B_206D_202E_206D_206B_206A_200E_206A_206F_202B_206C_206D_202A_202C_200B_200E_202C_200C_206D_202C_202A_206D_206D_200C_202C_206F_206C_206E_206A_202B_202D_202B_200F_202B_202E((Object)(object)val, (Object)null))
					{
						num3 = -1608389536;
						num4 = num3;
					}
					else
					{
						num3 = -1492162879;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1383420031);
					continue;
				}
				case 2u:
					_206E_200C_206B_206B_202B_206E_200C_206E_206B_206C_200C_200D_202A_206E_206B_206B_200E_202D_200B_206D_202E_200B_200E_202A_200D_202C_206C_206E_206F_202D_206C_206A_202C_206B_200D_200F_206B_200B_206E_202B_202E(val, (int)LuaScriptMgr.GetNumber(L, 3));
					num = 1191140396;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_filterMode(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Texture val = (Texture)luaObject;
		while (true)
		{
			int num = 1988444965;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4C28BCA2)) % 7)
				{
				case 0u:
					break;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1506079039u));
					num = ((int)num2 * -553022629) ^ 0x28756D51;
					continue;
				case 3u:
					_202E_206C_202A_200D_202A_202C_202C_206D_206A_202B_202D_200D_202B_200F_206D_206F_202B_200F_206A_202D_202C_200C_206A_200C_202A_206D_200F_206B_202A_206D_206E_206D_206F_206F_202B_202A_202D_206F_202E_200D_202E(val, (FilterMode)(int)LuaScriptMgr.GetNetObject(L, 3, _200C_206E_202C_200D_200E_200E_202C_202A_200E_206E_206D_206E_202B_206B_206C_206A_200E_202B_202E_206C_202E_206D_202B_202A_202A_206A_200C_206E_202A_200D_202A_206C_200F_200F_202A_206C_206E_200F_206C_206C_202E(typeof(FilterMode).TypeHandle)));
					num = 1286007213;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (!_200F_206B_202A_200E_200B_206B_206D_202E_206D_206B_206A_200E_206A_206F_202B_206C_206D_202A_202C_200B_200E_202C_200C_206D_202C_202A_206D_206D_200C_202C_206F_206C_206E_206A_202B_202D_202B_200F_202B_202E((Object)(object)val, (Object)null))
					{
						num5 = 393453548;
						num6 = num5;
					}
					else
					{
						num5 = 1933336673;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1214204229);
					continue;
				}
				case 1u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 2012983096;
						num4 = num3;
					}
					else
					{
						num3 = 110033837;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -873420001);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1858280971u));
					num = 783270287;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_anisoLevel(IntPtr L)
	{
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Texture val = default(Texture);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1965867595;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4CD187B2)) % 10)
				{
				case 7u:
					break;
				case 5u:
					_200F_200E_206B_206E_206C_206C_206B_206A_206D_202E_202A_206C_202E_206D_206F_206D_200D_202A_200F_200B_206E_202A_200D_202D_206A_206A_206A_200C_206F_200F_202E_206C_206F_202D_202A_202B_206F_200B_202C_206C_202E(val, (int)LuaScriptMgr.GetNumber(L, 3));
					num = 1836808307;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3389211168u));
					num = ((int)num2 * -263621109) ^ 0x5D10CA48;
					continue;
				case 9u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 1528353245;
						num6 = num5;
					}
					else
					{
						num5 = 493245971;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1493172797);
					continue;
				}
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3371015132u));
					num = 99120635;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (_200F_206B_202A_200E_200B_206B_206D_202E_206D_206B_206A_200E_206A_206F_202B_206C_206D_202A_202C_200B_200E_202C_200C_206D_202C_202A_206D_206D_200C_202C_206F_206C_206E_206A_202B_202D_202B_200F_202B_202E((Object)(object)val, (Object)null))
					{
						num3 = 1038116012;
						num4 = num3;
					}
					else
					{
						num3 = 955936699;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -286740941);
					continue;
				}
				case 3u:
					val = (Texture)luaObject;
					num = (int)(num2 * 479919819) ^ -418729727;
					continue;
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 1253605404) ^ -482620547;
					continue;
				case 6u:
					num = (int)((num2 * 1482194366) ^ 0x6CF92523);
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_wrapMode(IntPtr L)
	{
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Texture val = default(Texture);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1510625167;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3DC2EDC5)) % 10)
				{
				case 9u:
					break;
				case 6u:
					_206F_206B_200C_200B_202E_200D_202E_206B_206F_200F_200F_206C_200F_200F_200C_202B_200C_206E_200C_206B_202C_202E_202D_200E_202E_206B_206F_206D_200F_200D_202A_202C_200C_202C_200D_202D_206C_200B_200E_206B_202E(val, (TextureWrapMode)(int)LuaScriptMgr.GetNetObject(L, 3, _200C_206E_202C_200D_200E_200E_202C_202A_200E_206E_206D_206E_202B_206B_206C_206A_200E_202B_202E_206C_202E_206D_202B_202A_202A_206A_200C_206E_202A_200D_202A_206C_200F_200F_202A_206C_206E_200F_206C_206C_202E(typeof(TextureWrapMode).TypeHandle)));
					num = 686518887;
					continue;
				case 5u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 1177391779) ^ 0xD8E6463);
					continue;
				case 0u:
				{
					int num5;
					int num6;
					if (_200F_206B_202A_200E_200B_206B_206D_202E_206D_206B_206A_200E_206A_206F_202B_206C_206D_202A_202C_200B_200E_202C_200C_206D_202C_202A_206D_206D_200C_202C_206F_206C_206E_206A_202B_202D_202B_200F_202B_202E((Object)(object)val, (Object)null))
					{
						num5 = -120796792;
						num6 = num5;
					}
					else
					{
						num5 = -421010013;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1994137953);
					continue;
				}
				case 2u:
					num = (int)((num2 * 1592111021) ^ 0x264D1977);
					continue;
				case 4u:
					val = (Texture)luaObject;
					num = (int)((num2 * 1853549748) ^ 0x4847E569);
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1963878662u));
					num = ((int)num2 * -2110731176) ^ 0xE69D9CD;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4118967775u));
					num = 1341971335;
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 1257104657;
						num4 = num3;
					}
					else
					{
						num3 = 411433863;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 2086396083);
					continue;
				}
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_mipMapBias(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Texture val = (Texture)luaObject;
		if (_200F_206B_202A_200E_200B_206B_206D_202E_206D_206B_206A_200E_206A_206F_202B_206C_206D_202A_202C_200B_200E_202C_200C_206D_202C_202A_206D_206D_200C_202C_206F_206C_206E_206A_202B_202D_202B_200F_202B_202E((Object)(object)val, (Object)null))
		{
			goto IL_001b;
		}
		goto IL_00d6;
		IL_001b:
		int num = -481096953;
		goto IL_0020;
		IL_0020:
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -2147373448)) % 8)
			{
			case 6u:
				break;
			case 7u:
				luaTypes = LuaDLL.lua_type(L, 1);
				num = (int)(num2 * 434537785) ^ -85191374;
				continue;
			case 2u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1309109275u));
				num = (int)(num2 * 1784713738) ^ -1163664828;
				continue;
			case 5u:
			{
				int num3;
				int num4;
				if (luaTypes == LuaTypes.LUA_TTABLE)
				{
					num3 = -139163220;
					num4 = num3;
				}
				else
				{
					num3 = -1121323798;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -1410632410);
				continue;
			}
			case 0u:
				num = (int)(num2 * 837018116) ^ -2130793317;
				continue;
			case 4u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1417560389u));
				num = -473580165;
				continue;
			case 3u:
				goto IL_00d6;
			default:
				return 0;
			}
			break;
		}
		goto IL_001b;
		IL_00d6:
		_206A_200B_200C_206C_206D_200D_206B_202A_206F_200B_206C_206C_200C_200E_202D_206D_202C_200B_202E_202B_200F_206B_200D_202A_206D_200D_200E_202A_200B_206F_200C_202A_202D_200F_202A_202D_200F_200F_200D_206E_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
		num = -2027250559;
		goto IL_0020;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SetGlobalAnisotropicFilteringLimits(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		while (true)
		{
			int num = 978000877;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x54ACE23A)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_0029;
				default:
					return 0;
				}
				break;
				IL_0029:
				int num3 = (int)LuaScriptMgr.GetNumber(L, 1);
				int num4 = (int)LuaScriptMgr.GetNumber(L, 2);
				_206A_200C_200B_206A_200E_202D_206E_206B_200E_206C_200B_202A_202B_206D_202B_206A_206F_206D_206E_202B_200D_202B_202D_200F_206B_200E_206A_202D_202E_206C_200C_200D_200E_200D_200C_206F_202E_202C_200C_206F_202E(num3, num4);
				num = (int)(num2 * 791024589) ^ -586313201;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetNativeTexturePtr(IntPtr L)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 1);
		while (true)
		{
			int num = -518108552;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -41068169)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0029;
				default:
					return 1;
				}
				break;
				IL_0029:
				Texture val = (Texture)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(621824597u));
				IntPtr p = _206E_200C_200F_202A_206F_202D_200B_206E_202D_202C_206B_200E_206A_206B_202C_200B_200C_206F_202E_202A_206E_206B_202A_206C_200B_202B_200E_206A_202C_200D_202A_200F_206D_202A_200E_206A_200F_206C_206F_206B_202E(val);
				LuaScriptMgr.Push(L, p);
				num = (int)((num2 * 1701790491) ^ 0xEA9961);
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Lua_Eq(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Object val = (Object)((luaObject is Object) ? luaObject : null);
		object luaObject2 = LuaScriptMgr.GetLuaObject(L, 2);
		Object val2 = (Object)((luaObject2 is Object) ? luaObject2 : null);
		bool b = default(bool);
		while (true)
		{
			int num = -152166204;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1360752317)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0043;
				default:
					LuaScriptMgr.Push(L, b);
					return 1;
				}
				break;
				IL_0043:
				b = _200F_206B_202A_200E_200B_206B_206D_202E_206D_206B_206A_200E_206A_206F_202B_206C_206D_202A_202C_200B_200E_202C_200C_206D_202C_202A_206D_206D_200C_202C_206F_206C_206E_206A_202B_202D_202B_200F_202B_202E(val, val2);
				num = (int)(num2 * 782604786) ^ -1326952711;
			}
		}
	}

	static Type _200C_206E_202C_200D_200E_200E_202C_202A_200E_206E_206D_206E_202B_206B_206C_206A_200E_202B_202E_206C_202E_206D_202B_202A_202A_206A_200C_206E_202A_200D_202A_206C_200F_200F_202A_206C_206E_200F_206C_206C_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static Texture _200B_202A_206D_206C_202B_200E_200E_206A_200F_202D_202E_206D_200B_200F_202A_202B_206C_206B_200D_202A_202E_200C_200F_202B_206F_206B_206B_200E_206C_202D_202E_202C_206C_202C_202E_200F_206B_206D_200F_200E_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Texture();
	}

	static int _200C_206A_202D_202E_200C_200C_206F_202B_206F_202A_202B_206B_200B_202D_202B_202A_206A_200B_200F_200B_202C_206E_202D_206B_202C_202B_202E_200D_200E_206D_206B_206A_202B_202B_206C_200E_206C_202C_206A_202B_202E()
	{
		return Texture.masterTextureLimit;
	}

	static AnisotropicFiltering _202C_200F_206A_202C_202B_206A_206F_206E_200E_206A_202A_200B_202B_200E_200F_206F_206F_206B_200E_200B_202E_200F_202A_206A_200E_206D_202E_202A_200C_200B_202B_200E_202D_206A_206B_206D_202C_206A_206B_202A_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Texture.anisotropicFiltering;
	}

	static bool _200F_206B_202A_200E_200B_206B_206D_202E_206D_206B_206A_200E_206A_206F_202B_206C_206D_202A_202C_200B_200E_202C_200C_206D_202C_202A_206D_206D_200C_202C_206F_206C_206E_206A_202B_202D_202B_200F_202B_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static int _206D_206F_206B_202C_202A_202B_206D_200C_202D_202A_200C_206F_202E_200B_202E_206F_202D_200B_200C_200F_206C_200C_206D_202D_206E_202B_206E_202A_200C_202C_206C_200F_206F_202B_202C_202E_206E_206E_206D_206E_202E(Texture P_0)
	{
		return P_0.width;
	}

	static int _200C_202B_206D_202A_202A_202E_200C_202C_206C_200C_200D_200E_200B_200F_206F_202E_200E_202A_200D_202E_206D_200C_206A_206E_202D_202D_206B_202C_202E_202B_206D_206D_200D_206A_200D_202E_202C_200B_206A_206B_202E(Texture P_0)
	{
		return P_0.height;
	}

	static FilterMode _200C_202A_200D_202D_202C_200C_206F_202E_202A_200E_206B_200B_200F_206E_200E_200C_200C_202E_202B_200E_202E_206E_200D_200D_202C_200C_206D_206B_200D_206B_202D_200C_206F_200D_206D_202D_200F_202E_200C_200E_202E(Texture P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.filterMode;
	}

	static int _206C_200F_206B_206A_206D_202C_200C_202D_206D_202A_202B_206A_200C_202E_202D_202B_200F_206A_206B_206F_206B_200E_200B_206C_202C_200D_206F_202E_206A_202C_202D_206D_206C_200B_200D_206B_202A_200F_200E_206A_202E(Texture P_0)
	{
		return P_0.anisoLevel;
	}

	static TextureWrapMode _206F_206A_202B_202A_206C_206C_206B_200B_202C_202B_206D_206B_202A_202A_202E_206F_206E_206D_202B_206F_202C_202B_200E_200F_200E_200E_200E_206E_202D_206F_206E_200F_202D_200B_200B_202C_200F_202B_206B_202C_202E(Texture P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.wrapMode;
	}

	static float _200D_202B_202C_200E_206D_202B_206D_206B_200C_206D_200D_206C_202D_200D_200F_202B_200F_206D_206F_202A_202D_202A_200C_200D_202D_200F_206D_206B_200B_202C_202C_206D_206E_200E_202D_202B_206D_202B_200D_202E_202E(Texture P_0)
	{
		return P_0.mipMapBias;
	}

	static Vector2 _200C_206E_202B_206C_202C_202A_202C_200D_206C_202A_202D_202C_206F_206E_206F_200D_200D_200B_200E_202B_202A_202D_200F_206A_206C_202C_206D_206A_202E_206E_206F_200B_202C_202D_206F_206E_200E_200C_206B_200F_202E(Texture P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.texelSize;
	}

	static void _206C_202E_202C_200C_206D_202E_202C_202A_206B_202B_202A_200E_200E_202A_206A_206F_200D_200D_200E_200E_202E_200D_206D_202E_202A_206B_206B_202E_202E_202D_200F_206C_206E_202D_206D_200C_200E_206A_200F_200D_202E(int P_0)
	{
		Texture.masterTextureLimit = P_0;
	}

	static void _200B_206D_206A_200E_206E_202B_200F_202E_206A_202D_206D_206C_202A_206E_200D_206F_202C_206D_206C_200E_200F_200E_200F_200B_200B_206D_202D_206B_206C_200C_206E_200E_202B_206E_202D_200B_200D_200D_200B_206B_202E(AnisotropicFiltering P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		Texture.anisotropicFiltering = P_0;
	}

	static void _200C_200D_202A_202C_202B_200F_200B_206A_202A_202B_202C_200F_206E_200D_202B_206B_202D_202C_206A_206F_200F_200C_200B_206B_200B_200C_200D_206F_206D_202B_206A_202C_202D_200B_200D_202A_202A_200B_200D_202E_202E(Texture P_0, int P_1)
	{
		P_0.width = P_1;
	}

	static void _206E_200C_206B_206B_202B_206E_200C_206E_206B_206C_200C_200D_202A_206E_206B_206B_200E_202D_200B_206D_202E_200B_200E_202A_200D_202C_206C_206E_206F_202D_206C_206A_202C_206B_200D_200F_206B_200B_206E_202B_202E(Texture P_0, int P_1)
	{
		P_0.height = P_1;
	}

	static void _202E_206C_202A_200D_202A_202C_202C_206D_206A_202B_202D_200D_202B_200F_206D_206F_202B_200F_206A_202D_202C_200C_206A_200C_202A_206D_200F_206B_202A_206D_206E_206D_206F_206F_202B_202A_202D_206F_202E_200D_202E(Texture P_0, FilterMode P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.filterMode = P_1;
	}

	static void _200F_200E_206B_206E_206C_206C_206B_206A_206D_202E_202A_206C_202E_206D_206F_206D_200D_202A_200F_200B_206E_202A_200D_202D_206A_206A_206A_200C_206F_200F_202E_206C_206F_202D_202A_202B_206F_200B_202C_206C_202E(Texture P_0, int P_1)
	{
		P_0.anisoLevel = P_1;
	}

	static void _206F_206B_200C_200B_202E_200D_202E_206B_206F_200F_200F_206C_200F_200F_200C_202B_200C_206E_200C_206B_202C_202E_202D_200E_202E_206B_206F_206D_200F_200D_202A_202C_200C_202C_200D_202D_206C_200B_200E_206B_202E(Texture P_0, TextureWrapMode P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.wrapMode = P_1;
	}

	static void _206A_200B_200C_206C_206D_200D_206B_202A_206F_200B_206C_206C_200C_200E_202D_206D_202C_200B_202E_202B_200F_206B_200D_202A_206D_200D_200E_202A_200B_206F_200C_202A_202D_200F_202A_202D_200F_200F_200D_206E_202E(Texture P_0, float P_1)
	{
		P_0.mipMapBias = P_1;
	}

	static void _206A_200C_200B_206A_200E_202D_206E_206B_200E_206C_200B_202A_202B_206D_202B_206A_206F_206D_206E_202B_200D_202B_202D_200F_206B_200E_206A_202D_202E_206C_200C_200D_200E_200D_200C_206F_202E_202C_200C_206F_202E(int P_0, int P_1)
	{
		Texture.SetGlobalAnisotropicFilteringLimits(P_0, P_1);
	}

	static IntPtr _206E_200C_200F_202A_206F_202D_200B_206E_202D_202C_206B_200E_206A_206B_202C_200B_200C_206F_202E_202A_206E_206B_202A_206C_200B_202B_200E_206A_202C_200D_202A_200F_206D_202A_200E_206A_200F_206C_206F_206B_202E(Texture P_0)
	{
		return P_0.GetNativeTexturePtr();
	}
}
