using System;
using LuaInterface;
using UnityEngine;

public class BoxColliderWrap
{
	private static Type classType = _206F_202A_206E_200C_206B_200E_206E_200B_202D_202D_200B_206A_202A_206F_202D_202B_206B_200E_200F_200E_206A_200C_200E_200B_202A_200D_202A_206E_200F_206C_206E_200B_206C_200C_202D_200D_202D_200D_200E_202A_202E(typeof(BoxCollider).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[3]
		{
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2254933974u), _206F_202C_200D_206B_202C_200E_202B_202C_202D_202E_202D_206D_200B_206F_206D_200F_202E_200F_206E_202B_206C_206C_200C_202A_202C_206C_202C_206A_202C_206D_200D_202A_200E_202A_200B_202C_206D_200E_202A_202E_202E),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(10103728u), GetClassType),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3465012375u), Lua_Eq)
		};
		LuaField[] fields = new LuaField[2]
		{
			new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(231674043u), get_center, set_center),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(804991977u), get_size, set_size)
		};
		while (true)
		{
			int num = -418156198;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -305210965)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_010b;
				case 2u:
					return;
				}
				break;
				IL_010b:
				LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3112186422u), _206F_202A_206E_200C_206B_200E_206E_200B_202D_202D_200B_206A_202A_206F_202D_202B_206B_200E_200F_200E_206A_200C_200E_200B_202A_200D_202A_206E_200F_206C_206E_200B_206C_200C_202D_200D_202D_200D_200E_202A_202E(typeof(BoxCollider).TypeHandle), regs, fields, _206F_202A_206E_200C_206B_200E_206E_200B_202D_202D_200B_206A_202A_206F_202D_202B_206B_200E_200F_200E_206A_200C_200E_200B_202A_200D_202A_206E_200F_206C_206E_200B_206C_200C_202D_200D_202D_200D_200E_202A_202E(typeof(Collider).TypeHandle));
				num = (int)(num2 * 1886862603) ^ -2134503498;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _206F_202C_200D_206B_202C_200E_202B_202C_202D_202E_202D_206D_200B_206F_206D_200F_202E_200F_206E_202B_206C_206C_200C_202A_202C_206C_202C_206A_202C_206D_200D_202A_200E_202A_200B_202C_206D_200E_202A_202E_202E(IntPtr P_0)
	{
		if (LuaDLL.lua_gettop(P_0) == 0)
		{
			BoxCollider obj = default(BoxCollider);
			while (true)
			{
				int num = -627017740;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -862713258)) % 5)
					{
					case 3u:
						break;
					case 1u:
						obj = _202C_202B_200F_206F_206C_206A_206B_206F_202E_200E_202E_206D_200B_200C_202C_206E_206D_202C_200F_200C_202A_206A_200E_200F_202E_200D_200B_202C_206E_200B_200F_200C_206A_202E_206E_200B_206A_200F_200E_206C_202E();
						num = ((int)num2 * -1422107556) ^ -892599106;
						continue;
					case 0u:
						return 1;
					case 2u:
						LuaScriptMgr.Push(P_0, (Object)(object)obj);
						num = ((int)num2 * -2084738022) ^ -1118538391;
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
		LuaDLL.luaL_error(P_0, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(36980847u));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_center(IntPtr L)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		BoxCollider val = default(BoxCollider);
		while (true)
		{
			int num = 1137210765;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6747B071)) % 8)
				{
				case 0u:
					break;
				case 2u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 423476881;
						num6 = num5;
					}
					else
					{
						num5 = 1569783484;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 129553775);
					continue;
				}
				case 7u:
					LuaScriptMgr.Push(L, _200C_200D_202A_202D_206C_206B_202B_206B_200C_206F_202E_206C_200D_202A_202E_200F_202D_206E_200F_202A_206C_202B_200C_200F_206B_206E_202A_202B_206E_202E_200E_206B_206A_202B_200D_200E_200E_206E_200D_202C_202E(val));
					num = 80763420;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2980812755u));
					num = ((int)num2 * -50139453) ^ -1614098884;
					continue;
				case 4u:
					val = (BoxCollider)luaObject;
					num = (int)((num2 * 1585122647) ^ 0x6101C644);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (_206D_206B_206C_206D_202D_200E_206F_200C_200E_200E_206D_206C_202E_206D_202C_202A_200E_206E_202D_202E_206F_200C_206B_206D_206F_202A_200D_202C_206D_206A_200C_200F_206B_200D_202E_206C_200F_206B_202B_202B_202E((Object)(object)val, (Object)null))
					{
						num3 = 2047738063;
						num4 = num3;
					}
					else
					{
						num3 = 1340878442;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1921726084);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4210481920u));
					num = 963921582;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_size(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		BoxCollider val = (BoxCollider)luaObject;
		if (_206D_206B_206C_206D_202D_200E_206F_200C_200E_200E_206D_206C_202E_206D_202C_202A_200E_206E_202D_202E_206F_200C_206B_206D_206F_202A_200D_202C_206D_206A_200C_200F_206B_200D_202E_206C_200F_206B_202B_202B_202E((Object)(object)val, (Object)null))
		{
			while (true)
			{
				int num = 284884976;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x6F6E6F23)) % 6)
					{
					case 4u:
						break;
					case 3u:
					{
						LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
						int num3;
						int num4;
						if (luaTypes == LuaTypes.LUA_TTABLE)
						{
							num3 = -1248369128;
							num4 = num3;
						}
						else
						{
							num3 = -1227297415;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -1502343228);
						continue;
					}
					case 1u:
						num = (int)(num2 * 1476905810) ^ -911418003;
						continue;
					case 2u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3072300861u));
						num = 1455078799;
						continue;
					case 5u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(750092049u));
						num = ((int)num2 * -232968236) ^ 0x7EC37226;
						continue;
					default:
						goto end_IL_001b;
					}
					break;
				}
				continue;
				end_IL_001b:
				break;
			}
		}
		LuaScriptMgr.Push(L, _200D_206E_206F_202D_202B_206F_202E_206D_202C_206D_200C_202E_202E_206B_200C_206D_200E_200D_202C_206C_200B_202D_206E_202D_202C_202B_206D_206A_200C_206A_200B_200D_206D_202B_202B_206C_200B_200D_200E_200D_202E(val));
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_center(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		BoxCollider val = (BoxCollider)luaObject;
		while (true)
		{
			int num = -1902979446;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1742547897)) % 8)
				{
				case 2u:
					break;
				case 7u:
					num = (int)((num2 * 1855460149) ^ 0x160BDBF0);
					continue;
				case 0u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 128799817;
						num6 = num5;
					}
					else
					{
						num5 = 2061920214;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -763041584);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4148971931u));
					num = -880485565;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3374412124u));
					num = ((int)num2 * -752882779) ^ -914350475;
					continue;
				case 4u:
					_206E_200D_206C_202B_206C_206A_202C_206E_200E_200C_200F_200E_206B_200B_202E_202A_202E_202A_202E_200E_202D_200B_202A_200E_206D_206B_206F_206A_202D_200E_200C_206C_206E_200F_206D_206D_200F_200E_206C_206A_202E(val, LuaScriptMgr.GetVector3(L, 3));
					num = -1330009636;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!_206D_206B_206C_206D_202D_200E_206F_200C_200E_200E_206D_206C_202E_206D_202C_202A_200E_206E_202D_202E_206F_200C_206B_206D_206F_202A_200D_202C_206D_206A_200C_200F_206B_200D_202E_206C_200F_206B_202B_202B_202E((Object)(object)val, (Object)null))
					{
						num3 = 2007646099;
						num4 = num3;
					}
					else
					{
						num3 = 1516912471;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1348888560);
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
	private static int set_size(IntPtr L)
	{
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		BoxCollider val = default(BoxCollider);
		while (true)
		{
			int num = 207162096;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1AB55E3B)) % 9)
				{
				case 4u:
					break;
				case 8u:
					val = (BoxCollider)luaObject;
					num = (int)((num2 * 1620730678) ^ 0xCC3CCC1);
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (!_206D_206B_206C_206D_202D_200E_206F_200C_200E_200E_206D_206C_202E_206D_202C_202A_200E_206E_202D_202E_206F_200C_206B_206D_206F_202A_200D_202C_206D_206A_200C_200F_206B_200D_202E_206C_200F_206B_202B_202B_202E((Object)(object)val, (Object)null))
					{
						num5 = 511642226;
						num6 = num5;
					}
					else
					{
						num5 = 1630212270;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -750410097);
					continue;
				}
				case 5u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -1591990914;
						num4 = num3;
					}
					else
					{
						num3 = -621684999;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1793131309);
					continue;
				}
				case 2u:
					num = ((int)num2 * -335931286) ^ 0x35E12602;
					continue;
				case 0u:
					_206F_206C_200E_202E_202C_206C_200C_200B_200B_202A_202C_206A_202D_206D_206E_206B_206E_206C_202E_200C_200B_202B_206F_202D_206D_202B_206B_202D_200C_200F_200D_202D_202D_200D_206F_200F_202B_202C_206F_206A_202E(val, LuaScriptMgr.GetVector3(L, 3));
					num = 404219908;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(750092049u));
					num = ((int)num2 * -1118664155) ^ -445413464;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3902709026u));
					num = 423997226;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Lua_Eq(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Object val = (Object)((luaObject is Object) ? luaObject : null);
		Object val2 = default(Object);
		bool b = default(bool);
		while (true)
		{
			int num = -481605590;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1668731620)) % 4)
				{
				case 3u:
					break;
				case 2u:
				{
					object luaObject2 = LuaScriptMgr.GetLuaObject(L, 2);
					val2 = (Object)((luaObject2 is Object) ? luaObject2 : null);
					num = (int)(num2 * 1222531558) ^ -369738067;
					continue;
				}
				case 1u:
					b = _206D_206B_206C_206D_202D_200E_206F_200C_200E_200E_206D_206C_202E_206D_202C_202A_200E_206E_202D_202E_206F_200C_206B_206D_206F_202A_200D_202C_206D_206A_200C_200F_206B_200D_202E_206C_200F_206B_202B_202B_202E(val, val2);
					num = (int)(num2 * 2134446636) ^ -1874677104;
					continue;
				default:
					LuaScriptMgr.Push(L, b);
					return 1;
				}
				break;
			}
		}
	}

	static Type _206F_202A_206E_200C_206B_200E_206E_200B_202D_202D_200B_206A_202A_206F_202D_202B_206B_200E_200F_200E_206A_200C_200E_200B_202A_200D_202A_206E_200F_206C_206E_200B_206C_200C_202D_200D_202D_200D_200E_202A_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static BoxCollider _202C_202B_200F_206F_206C_206A_206B_206F_202E_200E_202E_206D_200B_200C_202C_206E_206D_202C_200F_200C_202A_206A_200E_200F_202E_200D_200B_202C_206E_200B_200F_200C_206A_202E_206E_200B_206A_200F_200E_206C_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new BoxCollider();
	}

	static bool _206D_206B_206C_206D_202D_200E_206F_200C_200E_200E_206D_206C_202E_206D_202C_202A_200E_206E_202D_202E_206F_200C_206B_206D_206F_202A_200D_202C_206D_206A_200C_200F_206B_200D_202E_206C_200F_206B_202B_202B_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static Vector3 _200C_200D_202A_202D_206C_206B_202B_206B_200C_206F_202E_206C_200D_202A_202E_200F_202D_206E_200F_202A_206C_202B_200C_200F_206B_206E_202A_202B_206E_202E_200E_206B_206A_202B_200D_200E_200E_206E_200D_202C_202E(BoxCollider P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.center;
	}

	static Vector3 _200D_206E_206F_202D_202B_206F_202E_206D_202C_206D_200C_202E_202E_206B_200C_206D_200E_200D_202C_206C_200B_202D_206E_202D_202C_202B_206D_206A_200C_206A_200B_200D_206D_202B_202B_206C_200B_200D_200E_200D_202E(BoxCollider P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.size;
	}

	static void _206E_200D_206C_202B_206C_206A_202C_206E_200E_200C_200F_200E_206B_200B_202E_202A_202E_202A_202E_200E_202D_200B_202A_200E_206D_206B_206F_206A_202D_200E_200C_206C_206E_200F_206D_206D_200F_200E_206C_206A_202E(BoxCollider P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.center = P_1;
	}

	static void _206F_206C_200E_202E_202C_206C_200C_200B_200B_202A_202C_206A_202D_206D_206E_206B_206E_206C_202E_200C_200B_202B_206F_202D_206D_202B_206B_202D_200C_200F_200D_202D_202D_200D_206F_200F_202B_202C_206F_206A_202E(BoxCollider P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.size = P_1;
	}
}
