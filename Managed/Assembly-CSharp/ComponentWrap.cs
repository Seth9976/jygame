using System;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;

public class ComponentWrap
{
	private static Type classType = _206A_202C_206E_202C_200C_206A_206D_200F_200C_202D_200B_200B_202D_200E_206A_200C_200D_206C_206F_200D_202E_202E_206F_202A_200F_200E_206D_200D_206D_202C_202D_206A_202D_206D_200E_200D_200E_202C_200C_202A_202E(typeof(Component).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[13]
		{
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3621451194u), GetComponent),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2224443078u), GetComponentInChildren),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3254261079u), GetComponentsInChildren),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1836385268u), GetComponentInParent),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2237760520u), GetComponentsInParent),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1221859570u), GetComponents),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2769887956u), CompareTag),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1467887357u), SendMessageUpwards),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2262852732u), SendMessage),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3128638015u), BroadcastMessage),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2904731379u), _206D_206E_206E_200B_200F_206A_206D_206F_206D_202C_206A_202A_202C_206A_200F_202D_200D_202C_206E_206D_206F_202A_200E_206B_206B_200E_206F_202E_202B_206C_202E_206C_206B_202C_206B_206D_206B_206A_200E_200E_202E),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(10103728u), GetClassType),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(60698966u), Lua_Eq)
		};
		LuaField[] fields = default(LuaField[]);
		while (true)
		{
			int num = 1826844854;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4D2F7DC3)) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_022c;
				default:
					LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(637512028u), _206A_202C_206E_202C_200C_206A_206D_200F_200C_202D_200B_200B_202D_200E_206A_200C_200D_206C_206F_200D_202E_202E_206F_202A_200F_200E_206D_200D_206D_202C_202D_206A_202D_206D_200E_200D_200E_202C_200C_202A_202E(typeof(Component).TypeHandle), regs, fields, _206A_202C_206E_202C_200C_206A_206D_200F_200C_202D_200B_200B_202D_200E_206A_200C_200D_206C_206F_200D_202E_202E_206F_202A_200F_200E_206D_200D_206D_202C_202D_206A_202D_206D_200E_200D_200E_202C_200C_202A_202E(typeof(Object).TypeHandle));
					return;
				}
				break;
				IL_022c:
				fields = new LuaField[3]
				{
					new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4008970939u), get_transform, null),
					new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1880140563u), get_gameObject, null),
					new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(366709495u), get_tag, set_tag)
				};
				num = ((int)num2 * -1476768418) ^ 0x260A9C78;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _206D_206E_206E_200B_200F_206A_206D_206F_206D_202C_206A_202A_202C_206A_200F_202D_200D_202C_206E_206D_206F_202A_200E_206B_206B_200E_206F_202E_202B_206C_202E_206C_206B_202C_206B_206D_206B_206A_200E_200E_202E(IntPtr P_0)
	{
		if (LuaDLL.lua_gettop(P_0) == 0)
		{
			goto IL_000a;
		}
		goto IL_0034;
		IL_000a:
		int num = -281129391;
		goto IL_000f;
		IL_000f:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1165028621)) % 5)
			{
			case 3u:
				break;
			case 4u:
				goto IL_0034;
			case 2u:
				return 1;
			case 1u:
			{
				Component obj = _200D_202D_206A_202B_200E_200F_200F_200E_202E_206E_206E_202B_200B_206F_202E_206A_202C_202A_200B_200B_202A_200E_200F_206A_206B_202D_202E_202E_206B_206E_202A_202E_202B_202D_200F_200F_202E_202B_206F_202E();
				LuaScriptMgr.Push(P_0, (Object)(object)obj);
				num = (int)((num2 * 1124540107) ^ 0x591B569A);
				continue;
			}
			default:
				return 0;
			}
			break;
		}
		goto IL_000a;
		IL_0034:
		LuaDLL.luaL_error(P_0, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2434365762u));
		num = -1595687583;
		goto IL_000f;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_transform(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Component val = (Component)luaObject;
		if (_200B_206F_202B_206F_202C_206F_200C_206B_200D_206B_202D_202C_206C_200C_206F_206C_206B_206C_200B_206F_206F_202A_206F_202E_200B_206E_200C_202B_202C_206C_200C_200B_200B_200F_200B_206B_206D_200D_200E_206C_202E((Object)(object)val, (Object)null))
		{
			LuaTypes luaTypes = default(LuaTypes);
			while (true)
			{
				int num = 1135603079;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x1EB798FF)) % 7)
					{
					case 3u:
						break;
					case 1u:
						luaTypes = LuaDLL.lua_type(L, 1);
						num = (int)((num2 * 303871825) ^ 0x51696901);
						continue;
					case 5u:
						num = (int)(num2 * 1822732597) ^ -1569888235;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (luaTypes != LuaTypes.LUA_TTABLE)
						{
							num3 = 1207130718;
							num4 = num3;
						}
						else
						{
							num3 = 502875312;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 1007175441);
						continue;
					}
					case 6u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1065602485u));
						num = 318848447;
						continue;
					case 0u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2585307734u));
						num = (int)((num2 * 1707246670) ^ 0x62C28C3);
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
		LuaScriptMgr.Push(L, (Object)(object)_202B_206C_206A_200E_202D_202D_202B_202B_200F_200B_200B_200E_200E_206A_202C_206C_200E_206B_206A_202E_202B_202A_200E_202E_202D_206C_206A_200C_202C_206D_202B_206C_202B_202E_202A_206E_200F_200B_202C_202B_202E(val));
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_gameObject(IntPtr L)
	{
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Component val = default(Component);
		while (true)
		{
			int num = 1486276713;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x74838E01)) % 6)
				{
				case 4u:
					break;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1874499751u));
					num = (int)((num2 * 2006414026) ^ 0x18892554);
					continue;
				case 3u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 417090988;
						num6 = num5;
					}
					else
					{
						num5 = 353274073;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1254352801);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1329750936u));
					num = 89729310;
					continue;
				case 2u:
				{
					val = (Component)luaObject;
					int num3;
					int num4;
					if (!_200B_206F_202B_206F_202C_206F_200C_206B_200D_206B_202D_202C_206C_200C_206F_206C_206B_206C_200B_206F_206F_202A_206F_202E_200B_206E_200C_202B_202C_206C_200C_200B_200B_200F_200B_206B_206D_200D_200E_206C_202E((Object)(object)val, (Object)null))
					{
						num3 = -1778111242;
						num4 = num3;
					}
					else
					{
						num3 = -2040642450;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -946563151);
					continue;
				}
				default:
					LuaScriptMgr.Push(L, (Object)(object)_202A_206B_200F_200D_200F_200F_206C_200E_202E_206A_202A_206C_202E_206D_200C_202C_200F_200E_206D_206C_206F_206E_202E_206C_206B_206B_206B_200C_200E_206F_202C_202B_200E_202A_200C_202C_206E_202D_202C_200C_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_tag(IntPtr L)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Component val = default(Component);
		while (true)
		{
			int num = 1650355950;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x73DBEB5B)) % 9)
				{
				case 6u:
					break;
				case 5u:
					val = (Component)luaObject;
					num = ((int)num2 * -694717513) ^ -1506751847;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1942353993u));
					num = 833452366;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3813405018u));
					num = (int)(num2 * 585557795) ^ -1448940764;
					continue;
				case 1u:
					num = (int)(num2 * 988316386) ^ -1021795986;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (!_200B_206F_202B_206F_202C_206F_200C_206B_200D_206B_202D_202C_206C_200C_206F_206C_206B_206C_200B_206F_206F_202A_206F_202E_200B_206E_200C_202B_202C_206C_200C_200B_200B_200F_200B_206B_206D_200D_200E_206C_202E((Object)(object)val, (Object)null))
					{
						num5 = -1395745898;
						num6 = num5;
					}
					else
					{
						num5 = -1159741148;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 693816280);
					continue;
				}
				case 8u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 746017783;
						num4 = num3;
					}
					else
					{
						num3 = 1320075259;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1682548975);
					continue;
				}
				case 3u:
					LuaScriptMgr.Push(L, _200B_202C_202B_206C_206F_202B_202B_200D_206E_202C_206A_206F_200B_200C_206F_200D_202B_200F_206C_200D_202B_202A_202C_206E_200D_202D_202D_200E_200F_202B_200C_206C_202B_200E_206B_202B_202D_200B_202D_206D_202E(val));
					num = 1221451293;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_tag(IntPtr L)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		Component val = default(Component);
		while (true)
		{
			int num = -1075705514;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -364881335)) % 9)
				{
				case 2u:
					break;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(231491256u));
					num = ((int)num2 * -614985674) ^ 0x3DC2254;
					continue;
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 327126013) ^ -757493256;
					continue;
				case 6u:
					num = ((int)num2 * -1810515464) ^ -1131123955;
					continue;
				case 7u:
				{
					val = (Component)luaObject;
					int num5;
					int num6;
					if (_200B_206F_202B_206F_202C_206F_200C_206B_200D_206B_202D_202C_206C_200C_206F_206C_206B_206C_200B_206F_206F_202A_206F_202E_200B_206E_200C_202B_202C_206C_200C_200B_200B_200F_200B_206B_206D_200D_200E_206C_202E((Object)(object)val, (Object)null))
					{
						num5 = -1198430515;
						num6 = num5;
					}
					else
					{
						num5 = -998831458;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1024476875);
					continue;
				}
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(422993468u));
					num = -454387979;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -1951098159;
						num4 = num3;
					}
					else
					{
						num3 = -1961183238;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -590989015);
					continue;
				}
				case 3u:
					_206D_202D_200B_202B_202B_202B_200B_200F_200C_206F_202D_206F_202E_206C_202D_202D_200B_206C_200F_202E_200C_200C_202E_206F_202A_206F_202D_206A_200F_206A_206A_202A_202D_206E_206F_202B_200E_200B_200F_206A_202E(val, LuaScriptMgr.GetString(L, 3));
					num = -1468734448;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetComponent(IntPtr L)
	{
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		if (num == 2)
		{
			goto IL_000e;
		}
		goto IL_00a1;
		IL_000e:
		int num2 = -1385636740;
		goto IL_0013;
		IL_0013:
		Component val = default(Component);
		string text = default(string);
		Component obj = default(Component);
		Component val2 = default(Component);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ -868153175)) % 13)
			{
			case 7u:
				break;
			case 3u:
				return 1;
			case 9u:
				val = (Component)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(681533442u));
				text = LuaScriptMgr.GetString(L, 2);
				num2 = ((int)num3 * -1481657764) ^ 0x5DFAFF72;
				continue;
			case 11u:
				goto IL_00a1;
			case 2u:
				obj = _202C_200E_206D_200B_202E_202E_202E_200F_202B_206F_200D_206F_202D_206E_206B_202D_202A_202A_206F_200F_200C_202C_206E_206A_202A_202B_206E_206D_200F_206B_206D_202A_206A_206F_202E_202E_200E_200D_202C_206F_202E(val, text);
				num2 = (int)(num3 * 2029196442) ^ -931345453;
				continue;
			case 12u:
			{
				int num6;
				int num7;
				if (!LuaScriptMgr.CheckTypes(L, 1, _206A_202C_206E_202C_200C_206A_206D_200F_200C_202D_200B_200B_202D_200E_206A_200C_200D_206C_206F_200D_202E_202E_206F_202A_200F_200E_206D_200D_206D_202C_202D_206A_202D_206D_200E_200D_200E_202C_200C_202A_202E(typeof(Component).TypeHandle), _206A_202C_206E_202C_200C_206A_206D_200F_200C_202D_200B_200B_202D_200E_206A_200C_200D_206C_206F_200D_202E_202E_206F_202A_200F_200E_206D_200D_206D_202C_202D_206A_202D_206D_200E_200D_200E_202C_200C_202A_202E(typeof(Type).TypeHandle)))
				{
					num6 = -747519974;
					num7 = num6;
				}
				else
				{
					num6 = -1761378827;
					num7 = num6;
				}
				num2 = num6 ^ (int)(num3 * 1415516155);
				continue;
			}
			case 0u:
			{
				Type typeObject = LuaScriptMgr.GetTypeObject(L, 2);
				Component obj2 = _206C_202A_206A_202D_206D_206B_206B_200B_200F_206A_200D_200C_206D_202D_200B_202D_206E_200B_206A_200E_202A_206C_206C_206A_200C_202E_202B_206C_202D_200D_200E_206A_202B_200C_202A_200E_200D_206B_202A_206B_202E(val2, typeObject);
				LuaScriptMgr.Push(L, (Object)(object)obj2);
				num2 = ((int)num3 * -345074364) ^ 0x7ACB5F3F;
				continue;
			}
			case 10u:
				return 1;
			case 4u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2944395435u));
				num2 = -811826102;
				continue;
			case 6u:
				val2 = (Component)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(681533442u));
				num2 = ((int)num3 * -1807392572) ^ -1629714079;
				continue;
			case 1u:
			{
				int num4;
				int num5;
				if (!LuaScriptMgr.CheckTypes(L, 1, _206A_202C_206E_202C_200C_206A_206D_200F_200C_202D_200B_200B_202D_200E_206A_200C_200D_206C_206F_200D_202E_202E_206F_202A_200F_200E_206D_200D_206D_202C_202D_206A_202D_206D_200E_200D_200E_202C_200C_202A_202E(typeof(Component).TypeHandle), _206A_202C_206E_202C_200C_206A_206D_200F_200C_202D_200B_200B_202D_200E_206A_200C_200D_206C_206F_200D_202E_202E_206F_202A_200F_200E_206D_200D_206D_202C_202D_206A_202D_206D_200E_200D_200E_202C_200C_202A_202E(typeof(string).TypeHandle)))
				{
					num4 = 674864004;
					num5 = num4;
				}
				else
				{
					num4 = 542538126;
					num5 = num4;
				}
				num2 = num4 ^ ((int)num3 * -542415809);
				continue;
			}
			case 5u:
				LuaScriptMgr.Push(L, (Object)(object)obj);
				num2 = ((int)num3 * -83517605) ^ 0x68DD19E;
				continue;
			default:
				return 0;
			}
			break;
		}
		goto IL_000e;
		IL_00a1:
		int num8;
		if (num != 2)
		{
			num2 = -1088556593;
			num8 = num2;
		}
		else
		{
			num2 = -2030795578;
			num8 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetComponentInChildren(IntPtr L)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		Component val = default(Component);
		while (true)
		{
			int num = 1671134445;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x637062DC)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0029;
				default:
				{
					Type typeObject = LuaScriptMgr.GetTypeObject(L, 2);
					Component obj = _206B_200B_202E_200C_206F_200E_206D_202B_206D_206F_200D_200E_206E_200B_200F_202D_206A_200C_206B_202C_202A_206D_200C_200B_200B_202B_200E_202A_202D_206A_200E_202B_200F_206F_206D_202C_200D_202B_202C_200F_202E(val, typeObject);
					LuaScriptMgr.Push(L, (Object)(object)obj);
					return 1;
				}
				}
				break;
				IL_0029:
				val = (Component)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(244656949u));
				num = ((int)num2 * -667834986) ^ 0x77426CC9;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetComponentsInChildren(IntPtr L)
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		bool boolean = default(bool);
		Component val2 = default(Component);
		Type typeObject2 = default(Type);
		Component[] o = default(Component[]);
		Type typeObject = default(Type);
		Component[] o2 = default(Component[]);
		Component val = default(Component);
		while (true)
		{
			int num2 = 2092570640;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x6F4F5A69)) % 14)
				{
				case 3u:
					break;
				case 13u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(287911936u));
					num2 = 2120145187;
					continue;
				case 2u:
				{
					int num6;
					if (num != 3)
					{
						num2 = 1248069366;
						num6 = num2;
					}
					else
					{
						num2 = 1003407099;
						num6 = num2;
					}
					continue;
				}
				case 1u:
					boolean = LuaScriptMgr.GetBoolean(L, 3);
					num2 = (int)((num3 * 1265103957) ^ 0x2F17D7C8);
					continue;
				case 6u:
					val2 = (Component)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2905776242u));
					typeObject2 = LuaScriptMgr.GetTypeObject(L, 2);
					num2 = ((int)num3 * -835989636) ^ -215545318;
					continue;
				case 11u:
					return 1;
				case 8u:
					o = _200B_206D_206A_206D_206D_200C_206F_206A_202E_202B_200D_200B_200B_202E_202E_200F_200E_202E_202C_200C_206E_202C_202D_200C_200B_202D_202A_206C_206E_206D_202C_200B_200D_200E_202D_206D_206A_202E_206D_202B_202E(val2, typeObject2, boolean);
					num2 = (int)((num3 * 1668413860) ^ 0x19212441);
					continue;
				case 10u:
					typeObject = LuaScriptMgr.GetTypeObject(L, 2);
					num2 = ((int)num3 * -1401303126) ^ -914376206;
					continue;
				case 4u:
					LuaScriptMgr.PushArray(L, o2);
					return 1;
				case 9u:
					val = (Component)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(940312551u));
					num2 = ((int)num3 * -1032760966) ^ -2083688343;
					continue;
				case 7u:
					o2 = _202E_206F_202B_206D_200B_200D_202C_202A_202D_202C_200D_200D_202A_200E_206A_200D_202C_202C_202B_200E_206D_206C_200F_200B_200E_206D_202A_206C_202E_206B_200B_202A_206F_200B_202B_202D_200C_200E_202B_202E_202E(val, typeObject);
					num2 = (int)((num3 * 945870551) ^ 0x29F94A56);
					continue;
				case 0u:
					LuaScriptMgr.PushArray(L, o);
					num2 = (int)((num3 * 101604118) ^ 0x4B322B2);
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (num != 2)
					{
						num4 = -1190218921;
						num5 = num4;
					}
					else
					{
						num4 = -2001645848;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num3 * -581844744);
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
	private static int GetComponentInParent(IntPtr L)
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		Component obj = default(Component);
		Component val = default(Component);
		Type typeObject = default(Type);
		while (true)
		{
			int num = -2118776997;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -843231993)) % 6)
				{
				case 5u:
					break;
				case 1u:
					obj = _202D_200E_200C_202C_206B_202B_200B_202B_202E_200B_206F_200D_200E_200C_206F_202D_206D_202E_206C_200C_202D_202B_206C_202D_206B_202B_200D_206E_200E_200F_206C_206E_200C_206A_200F_202D_200F_206E_206E_200F_202E(val, typeObject);
					num = (int)(num2 * 1333435395) ^ -230422991;
					continue;
				case 3u:
					LuaScriptMgr.Push(L, (Object)(object)obj);
					num = ((int)num2 * -1277969497) ^ 0x4D661C54;
					continue;
				case 4u:
					val = (Component)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(262871603u));
					num = (int)(num2 * 923664715) ^ -965214687;
					continue;
				case 2u:
					typeObject = LuaScriptMgr.GetTypeObject(L, 2);
					num = (int)(num2 * 381530967) ^ -987211106;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetComponentsInParent(IntPtr L)
	{
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		Component[] o = default(Component[]);
		Component val = default(Component);
		Type typeObject = default(Type);
		bool boolean = default(bool);
		Component[] o2 = default(Component[]);
		Component val2 = default(Component);
		Type typeObject2 = default(Type);
		while (true)
		{
			int num2 = 1364143050;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x3DD5F829)) % 13)
				{
				case 3u:
					break;
				case 4u:
					o = _206E_202E_202B_200B_202E_202D_200C_206C_200B_202E_202A_200D_200D_202D_206A_202A_202B_202D_206C_202D_200D_206F_206F_200C_206D_202E_200E_200E_200D_206B_202D_206B_206F_200B_200D_202B_206E_200D_206E_206F_202E(val, typeObject, boolean);
					num2 = (int)((num3 * 1862589892) ^ 0x71736012);
					continue;
				case 12u:
					val = (Component)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(681533442u));
					typeObject = LuaScriptMgr.GetTypeObject(L, 2);
					num2 = ((int)num3 * -1008231759) ^ 0x74049F90;
					continue;
				case 9u:
					return 1;
				case 5u:
				{
					int num5;
					int num6;
					if (num != 2)
					{
						num5 = 1999201022;
						num6 = num5;
					}
					else
					{
						num5 = 1142501623;
						num6 = num5;
					}
					num2 = num5 ^ ((int)num3 * -1190151592);
					continue;
				}
				case 2u:
					boolean = LuaScriptMgr.GetBoolean(L, 3);
					num2 = (int)(num3 * 1417007511) ^ -1911903888;
					continue;
				case 7u:
					LuaScriptMgr.PushArray(L, o2);
					num2 = (int)((num3 * 1175980030) ^ 0x42ABE1A4);
					continue;
				case 1u:
					val2 = (Component)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(262871603u));
					typeObject2 = LuaScriptMgr.GetTypeObject(L, 2);
					num2 = (int)(num3 * 623661955) ^ -1892527680;
					continue;
				case 10u:
					o2 = _202E_200D_206C_200D_200F_200D_200E_206C_200D_202B_200F_200F_206E_206C_206B_202A_206F_202E_202B_206B_200F_206E_202C_200B_206F_202E_206D_206D_206F_202E_200C_206D_200B_200D_200C_200C_206D_202E_200D_202B_202E(val2, typeObject2);
					num2 = (int)(num3 * 1301067495) ^ -167019070;
					continue;
				case 6u:
					LuaScriptMgr.PushArray(L, o);
					return 1;
				case 11u:
				{
					int num4;
					if (num != 3)
					{
						num2 = 1482308059;
						num4 = num2;
					}
					else
					{
						num2 = 1147781942;
						num4 = num2;
					}
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3566430552u));
					num2 = 2136385651;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetComponents(IntPtr L)
	{
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		if (num == 2)
		{
			goto IL_000e;
		}
		goto IL_00f3;
		IL_000e:
		int num2 = 174481351;
		goto IL_0013;
		IL_0013:
		Component val = default(Component);
		Component val2 = default(Component);
		Type typeObject2 = default(Type);
		Type typeObject = default(Type);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ 0x5399BF72)) % 9)
			{
			case 6u:
				break;
			case 8u:
				val = (Component)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(244656949u));
				num2 = ((int)num3 * -84411606) ^ 0x1A9E392A;
				continue;
			case 4u:
			{
				List<Component> list = (List<Component>)LuaScriptMgr.GetNetObject(L, 3, _206A_202C_206E_202C_200C_206A_206D_200F_200C_202D_200B_200B_202D_200E_206A_200C_200D_206C_206F_200D_202E_202E_206F_202A_200F_200E_206D_200D_206D_202C_202D_206A_202D_206D_200E_200D_200E_202C_200C_202A_202E(typeof(List<Component>).TypeHandle));
				_200E_206E_206D_206C_206C_202E_202A_202A_206E_206A_202D_202B_200C_202C_200F_206E_206C_202E_206C_200F_200C_206C_200D_206C_200D_206C_202A_206A_202A_206B_206F_206D_206A_200C_202C_206C_206E_206D_202D_206B_202E(val2, typeObject2, list);
				return 0;
			}
			case 0u:
				typeObject2 = LuaScriptMgr.GetTypeObject(L, 2);
				num2 = ((int)num3 * -2068601498) ^ -1368829692;
				continue;
			case 1u:
				val2 = (Component)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(244656949u));
				num2 = (int)(num3 * 824486813) ^ -282784807;
				continue;
			case 7u:
				goto IL_00f3;
			case 2u:
			{
				Component[] o = _202D_206A_202C_206D_200E_206D_202D_202C_200E_206A_206A_202D_202E_206D_202E_200C_202A_206C_206C_206D_206B_206C_202C_200F_200D_202E_202A_200B_202D_200E_206A_202A_206A_206D_206A_200D_202A_202D_206B_206B_202E(val, typeObject);
				LuaScriptMgr.PushArray(L, o);
				return 1;
			}
			case 5u:
				typeObject = LuaScriptMgr.GetTypeObject(L, 2);
				num2 = ((int)num3 * -992488379) ^ -269865674;
				continue;
			default:
				LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2441207129u));
				return 0;
			}
			break;
		}
		goto IL_000e;
		IL_00f3:
		int num4;
		if (num != 3)
		{
			num2 = 860481787;
			num4 = num2;
		}
		else
		{
			num2 = 831279220;
			num4 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int CompareTag(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		Component val = default(Component);
		string luaString = default(string);
		bool b = default(bool);
		while (true)
		{
			int num = 1883359366;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x51AFDF3D)) % 4)
				{
				case 0u:
					break;
				case 3u:
					val = (Component)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2905776242u));
					luaString = LuaScriptMgr.GetLuaString(L, 2);
					num = (int)(num2 * 2106889986) ^ -839998811;
					continue;
				case 2u:
					b = _206D_202D_200B_206D_206F_206F_206F_200D_200C_206F_206B_202B_206E_206F_200C_202A_206B_206F_206F_206B_200D_202D_202A_206D_200D_202C_200D_200B_202B_202E_200F_202E_200F_206D_206F_206A_206B_200B_200F_202E_202E(val, luaString);
					num = (int)((num2 * 2083771106) ^ 0x302AEDCC);
					continue;
				default:
					LuaScriptMgr.Push(L, b);
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SendMessageUpwards(IntPtr L)
	{
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected O, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		Component val = default(Component);
		Component val6 = default(Component);
		string text2 = default(string);
		SendMessageOptions val5 = default(SendMessageOptions);
		Component val2 = default(Component);
		string luaString = default(string);
		while (true)
		{
			int num2 = -1215376795;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -819300640)) % 19)
				{
				case 0u:
					break;
				case 1u:
				{
					int num8;
					int num9;
					if (num == 2)
					{
						num8 = -15580162;
						num9 = num8;
					}
					else
					{
						num8 = -703902751;
						num9 = num8;
					}
					num2 = num8 ^ ((int)num3 * -462962739);
					continue;
				}
				case 11u:
				{
					string text = LuaScriptMgr.GetString(L, 2);
					object varObject = LuaScriptMgr.GetVarObject(L, 3);
					_202B_206B_206D_200B_206D_206E_206A_206E_200D_206D_206E_206B_206D_206C_200C_200D_202A_200C_200E_200F_206D_206F_202A_202E_202A_202C_200E_206B_202C_206E_202D_200D_200D_202C_206B_206F_202E_206A_200B_200D_202E(val, text, varObject);
					num2 = ((int)num3 * -2061913332) ^ -1928278518;
					continue;
				}
				case 2u:
				{
					int num12;
					if (num == 4)
					{
						num2 = -105559765;
						num12 = num2;
					}
					else
					{
						num2 = -1227501214;
						num12 = num2;
					}
					continue;
				}
				case 17u:
					return 0;
				case 18u:
					val6 = (Component)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(940312551u));
					num2 = ((int)num3 * -887775402) ^ -1633691087;
					continue;
				case 16u:
					_206C_202B_200B_206C_202A_200B_200E_200D_200C_202B_200F_206F_202B_206D_206B_200E_206B_206A_200D_200C_200F_206D_202A_206A_200D_202E_202E_200D_200B_202C_200D_200D_206B_206D_206B_200D_206D_206C_200C_200E_202E(val6, text2, val5);
					return 0;
				case 13u:
				{
					int num6;
					if (num == 3)
					{
						num2 = -1244756366;
						num6 = num2;
					}
					else
					{
						num2 = -30794334;
						num6 = num2;
					}
					continue;
				}
				case 8u:
					val2 = (Component)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(940312551u));
					luaString = LuaScriptMgr.GetLuaString(L, 2);
					num2 = (int)((num3 * 1319054238) ^ 0x49C069FC);
					continue;
				case 3u:
					return 0;
				case 10u:
					_202C_202C_200D_202E_200C_206E_200B_206C_202D_202B_206B_206E_200C_206B_206C_200C_206B_206D_200C_202E_202E_202D_202D_200C_202E_206B_200B_206D_202C_200B_206B_200F_202C_200E_200D_200D_206D_200E_202A_206C_202E(val2, luaString);
					num2 = (int)((num3 * 2066167432) ^ 0x181CD8CF);
					continue;
				case 9u:
				{
					int num10;
					int num11;
					if (!LuaScriptMgr.CheckTypes(L, 1, _206A_202C_206E_202C_200C_206A_206D_200F_200C_202D_200B_200B_202D_200E_206A_200C_200D_206C_206F_200D_202E_202E_206F_202A_200F_200E_206D_200D_206D_202C_202D_206A_202D_206D_200E_200D_200E_202C_200C_202A_202E(typeof(Component).TypeHandle), _206A_202C_206E_202C_200C_206A_206D_200F_200C_202D_200B_200B_202D_200E_206A_200C_200D_206C_206F_200D_202E_202E_206F_202A_200F_200E_206D_200D_206D_202C_202D_206A_202D_206D_200E_200D_200E_202C_200C_202A_202E(typeof(string).TypeHandle), _206A_202C_206E_202C_200C_206A_206D_200F_200C_202D_200B_200B_202D_200E_206A_200C_200D_206C_206F_200D_202E_202E_206F_202A_200F_200E_206D_200D_206D_202C_202D_206A_202D_206D_200E_200D_200E_202C_200C_202A_202E(typeof(object).TypeHandle)))
					{
						num10 = -638039095;
						num11 = num10;
					}
					else
					{
						num10 = -2025741369;
						num11 = num10;
					}
					num2 = num10 ^ (int)(num3 * 931306563);
					continue;
				}
				case 4u:
				{
					int num7;
					if (num == 3)
					{
						num2 = -1260505751;
						num7 = num2;
					}
					else
					{
						num2 = -580951278;
						num7 = num2;
					}
					continue;
				}
				case 7u:
					text2 = LuaScriptMgr.GetString(L, 2);
					val5 = (SendMessageOptions)(int)LuaScriptMgr.GetLuaObject(L, 3);
					num2 = (int)(num3 * 235081571) ^ -807829781;
					continue;
				case 5u:
				{
					Component val3 = (Component)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(262871603u));
					string luaString2 = LuaScriptMgr.GetLuaString(L, 2);
					object varObject2 = LuaScriptMgr.GetVarObject(L, 3);
					SendMessageOptions val4 = (SendMessageOptions)(int)LuaScriptMgr.GetNetObject(L, 4, _206A_202C_206E_202C_200C_206A_206D_200F_200C_202D_200B_200B_202D_200E_206A_200C_200D_206C_206F_200D_202E_202E_206F_202A_200F_200E_206D_200D_206D_202C_202D_206A_202D_206D_200E_200D_200E_202C_200C_202A_202E(typeof(SendMessageOptions).TypeHandle));
					_200E_200B_200D_206E_200C_200F_202B_200D_202C_206E_202A_206B_202A_202E_200C_206C_206F_200F_202D_202A_200D_200E_206C_206D_200F_202B_206B_202C_206E_202B_202A_200C_206F_200B_202E_206D_202B_202E_202C_202A_202E(val3, luaString2, varObject2, val4);
					return 0;
				}
				case 12u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1671213088u));
					num2 = -1466944082;
					continue;
				case 15u:
					val = (Component)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(244656949u));
					num2 = (int)(num3 * 724050556) ^ -1820616658;
					continue;
				case 6u:
				{
					int num4;
					int num5;
					if (LuaScriptMgr.CheckTypes(L, 1, _206A_202C_206E_202C_200C_206A_206D_200F_200C_202D_200B_200B_202D_200E_206A_200C_200D_206C_206F_200D_202E_202E_206F_202A_200F_200E_206D_200D_206D_202C_202D_206A_202D_206D_200E_200D_200E_202C_200C_202A_202E(typeof(Component).TypeHandle), _206A_202C_206E_202C_200C_206A_206D_200F_200C_202D_200B_200B_202D_200E_206A_200C_200D_206C_206F_200D_202E_202E_206F_202A_200F_200E_206D_200D_206D_202C_202D_206A_202D_206D_200E_200D_200E_202C_200C_202A_202E(typeof(string).TypeHandle), _206A_202C_206E_202C_200C_206A_206D_200F_200C_202D_200B_200B_202D_200E_206A_200C_200D_206C_206F_200D_202E_202E_206F_202A_200F_200E_206D_200D_206D_202C_202D_206A_202D_206D_200E_200D_200E_202C_200C_202A_202E(typeof(SendMessageOptions).TypeHandle)))
					{
						num4 = -1029559429;
						num5 = num4;
					}
					else
					{
						num4 = -1273935082;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 1093285002);
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
	private static int SendMessage(IntPtr L)
	{
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		if (num == 2)
		{
			goto IL_000e;
		}
		goto IL_0180;
		IL_000e:
		int num2 = -717494353;
		goto IL_0013;
		IL_0013:
		Component val5 = default(Component);
		string luaString = default(string);
		object varObject2 = default(object);
		string text2 = default(string);
		string text = default(string);
		Component val = default(Component);
		SendMessageOptions val3 = default(SendMessageOptions);
		object varObject = default(object);
		Component val2 = default(Component);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ -608818055)) % 22)
			{
			case 12u:
				break;
			case 5u:
				goto IL_0081;
			case 3u:
			{
				int num6;
				int num7;
				if (!LuaScriptMgr.CheckTypes(L, 1, _206A_202C_206E_202C_200C_206A_206D_200F_200C_202D_200B_200B_202D_200E_206A_200C_200D_206C_206F_200D_202E_202E_206F_202A_200F_200E_206D_200D_206D_202C_202D_206A_202D_206D_200E_200D_200E_202C_200C_202A_202E(typeof(Component).TypeHandle), _206A_202C_206E_202C_200C_206A_206D_200F_200C_202D_200B_200B_202D_200E_206A_200C_200D_206C_206F_200D_202E_202E_206F_202A_200F_200E_206D_200D_206D_202C_202D_206A_202D_206D_200E_200D_200E_202C_200C_202A_202E(typeof(string).TypeHandle), _206A_202C_206E_202C_200C_206A_206D_200F_200C_202D_200B_200B_202D_200E_206A_200C_200D_206C_206F_200D_202E_202E_206F_202A_200F_200E_206D_200D_206D_202C_202D_206A_202D_206D_200E_200D_200E_202C_200C_202A_202E(typeof(SendMessageOptions).TypeHandle)))
				{
					num6 = -1099500316;
					num7 = num6;
				}
				else
				{
					num6 = -2074033220;
					num7 = num6;
				}
				num2 = num6 ^ ((int)num3 * -1856301332);
				continue;
			}
			case 13u:
			{
				SendMessageOptions val4 = (SendMessageOptions)(int)LuaScriptMgr.GetNetObject(L, 4, _206A_202C_206E_202C_200C_206A_206D_200F_200C_202D_200B_200B_202D_200E_206A_200C_200D_206C_206F_200D_202E_202E_206F_202A_200F_200E_206D_200D_206D_202C_202D_206A_202D_206D_200E_200D_200E_202C_200C_202A_202E(typeof(SendMessageOptions).TypeHandle));
				_206C_200F_200D_200B_206D_206E_202D_200C_206C_206D_200B_202A_206A_200F_200B_206B_206E_200F_200B_202A_206F_206E_200D_200B_206A_202A_206A_202C_200B_200D_200C_200D_206E_206F_202E_202A_200C_206F_202C_206C_202E(val5, luaString, varObject2, val4);
				return 0;
			}
			case 4u:
				varObject2 = LuaScriptMgr.GetVarObject(L, 3);
				num2 = (int)(num3 * 1245405837) ^ -883631524;
				continue;
			case 10u:
				text2 = LuaScriptMgr.GetString(L, 2);
				num2 = (int)((num3 * 1805887938) ^ 0x39023EF1);
				continue;
			case 15u:
				text = LuaScriptMgr.GetString(L, 2);
				num2 = (int)(num3 * 546173400) ^ -735081621;
				continue;
			case 0u:
				return 0;
			case 20u:
				goto IL_0180;
			case 1u:
				_206A_200D_206F_206C_206D_202A_200C_202C_200F_200D_200D_206F_206C_206C_202C_206F_202C_200B_200B_202B_202E_206B_202B_202A_202E_200F_206B_206F_206C_200D_206A_200D_200B_200B_200E_206D_206A_206B_200C_202C_202E(val, text2, val3);
				num2 = ((int)num3 * -1402979931) ^ 0x2FBB3FF3;
				continue;
			case 18u:
				val5 = (Component)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(244656949u));
				luaString = LuaScriptMgr.GetLuaString(L, 2);
				num2 = (int)(num3 * 1537300023) ^ -2104317997;
				continue;
			case 6u:
			{
				Component val6 = (Component)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(262871603u));
				string luaString2 = LuaScriptMgr.GetLuaString(L, 2);
				_200D_206C_202D_200D_206E_206A_206A_200D_206D_206F_206D_202D_200C_206C_206F_202C_206E_200E_200E_206B_206B_202A_200C_206C_200C_202C_202E_200B_202E_206A_200D_200C_206D_200B_202D_200B_202A_200F_200B_206A_202E(val6, luaString2);
				num2 = ((int)num3 * -396898280) ^ 0x465A3C19;
				continue;
			}
			case 14u:
			{
				int num4;
				int num5;
				if (!LuaScriptMgr.CheckTypes(L, 1, _206A_202C_206E_202C_200C_206A_206D_200F_200C_202D_200B_200B_202D_200E_206A_200C_200D_206C_206F_200D_202E_202E_206F_202A_200F_200E_206D_200D_206D_202C_202D_206A_202D_206D_200E_200D_200E_202C_200C_202A_202E(typeof(Component).TypeHandle), _206A_202C_206E_202C_200C_206A_206D_200F_200C_202D_200B_200B_202D_200E_206A_200C_200D_206C_206F_200D_202E_202E_206F_202A_200F_200E_206D_200D_206D_202C_202D_206A_202D_206D_200E_200D_200E_202C_200C_202A_202E(typeof(string).TypeHandle), _206A_202C_206E_202C_200C_206A_206D_200F_200C_202D_200B_200B_202D_200E_206A_200C_200D_206C_206F_200D_202E_202E_206F_202A_200F_200E_206D_200D_206D_202C_202D_206A_202D_206D_200E_200D_200E_202C_200C_202A_202E(typeof(object).TypeHandle)))
				{
					num4 = 1329003196;
					num5 = num4;
				}
				else
				{
					num4 = 71320448;
					num5 = num4;
				}
				num2 = num4 ^ (int)(num3 * 458669315);
				continue;
			}
			case 8u:
				val3 = (SendMessageOptions)(int)LuaScriptMgr.GetLuaObject(L, 3);
				num2 = ((int)num3 * -1531836720) ^ 0x21C0410E;
				continue;
			case 7u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1193731179u));
				num2 = -48744048;
				continue;
			case 16u:
				varObject = LuaScriptMgr.GetVarObject(L, 3);
				num2 = (int)(num3 * 542896487) ^ -1476416497;
				continue;
			case 19u:
				val2 = (Component)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(262871603u));
				num2 = (int)(num3 * 1916220957) ^ -165570275;
				continue;
			case 11u:
				goto IL_02e8;
			case 2u:
				_202B_202C_206A_206B_206E_206B_206C_206A_200D_206A_206C_202B_206F_200B_200E_206F_202C_206D_202D_206C_200B_200F_202C_206C_202C_206A_206D_202C_206F_206A_202E_206E_206F_202B_202A_206E_206D_200C_202D_206F_202E(val2, text, varObject);
				return 0;
			case 21u:
				return 0;
			case 9u:
				val = (Component)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(681533442u));
				num2 = ((int)num3 * -1289111655) ^ -1972755500;
				continue;
			default:
				return 0;
			}
			break;
			IL_02e8:
			int num8;
			if (num != 3)
			{
				num2 = -1874891674;
				num8 = num2;
			}
			else
			{
				num2 = -863204889;
				num8 = num2;
			}
			continue;
			IL_0081:
			int num9;
			if (num == 4)
			{
				num2 = -493256303;
				num9 = num2;
			}
			else
			{
				num2 = -725407134;
				num9 = num2;
			}
		}
		goto IL_000e;
		IL_0180:
		int num10;
		if (num == 3)
		{
			num2 = -981509128;
			num10 = num2;
		}
		else
		{
			num2 = -2085833720;
			num10 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int BroadcastMessage(IntPtr L)
	{
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		Component val3 = default(Component);
		string luaString = default(string);
		string luaString2 = default(string);
		object varObject = default(object);
		Component val = default(Component);
		Component val6 = default(Component);
		string text2 = default(string);
		Component val4 = default(Component);
		while (true)
		{
			int num2 = -1401654848;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1951785603)) % 21)
				{
				case 16u:
					break;
				case 8u:
					val3 = (Component)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(262871603u));
					luaString = LuaScriptMgr.GetLuaString(L, 2);
					num2 = ((int)num3 * -1926067626) ^ 0x2CABD7EA;
					continue;
				case 9u:
					luaString2 = LuaScriptMgr.GetLuaString(L, 2);
					num2 = (int)(num3 * 1782562557) ^ -1540179231;
					continue;
				case 13u:
					varObject = LuaScriptMgr.GetVarObject(L, 3);
					num2 = (int)(num3 * 1998162080) ^ -1536862115;
					continue;
				case 0u:
				{
					string text = LuaScriptMgr.GetString(L, 2);
					SendMessageOptions val5 = (SendMessageOptions)(int)LuaScriptMgr.GetLuaObject(L, 3);
					_200E_206C_200D_202D_206B_206D_206C_202D_200B_206F_206E_200D_200B_206B_206A_202D_200B_200C_206F_200E_206E_206F_200F_200B_200C_200B_206F_206A_202C_206B_202A_200C_202C_200B_206F_200C_202B_202C_206F_202E_202E(val, text, val5);
					num2 = (int)(num3 * 2626310) ^ -721701423;
					continue;
				}
				case 4u:
					val6 = (Component)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(940312551u));
					text2 = LuaScriptMgr.GetString(L, 2);
					num2 = (int)(num3 * 2081745714) ^ -2105483740;
					continue;
				case 11u:
					return 0;
				case 10u:
				{
					int num11;
					if (num == 3)
					{
						num2 = -1045640104;
						num11 = num2;
					}
					else
					{
						num2 = -255536432;
						num11 = num2;
					}
					continue;
				}
				case 12u:
				{
					int num7;
					int num8;
					if (num != 2)
					{
						num7 = 689369871;
						num8 = num7;
					}
					else
					{
						num7 = 1503681023;
						num8 = num7;
					}
					num2 = num7 ^ ((int)num3 * -754406212);
					continue;
				}
				case 3u:
					val = (Component)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(940312551u));
					num2 = ((int)num3 * -2141440472) ^ 0x51D8C2AA;
					continue;
				case 5u:
					return 0;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4195998605u));
					num2 = -2137955714;
					continue;
				case 18u:
				{
					object varObject2 = LuaScriptMgr.GetVarObject(L, 3);
					_200B_206C_206A_206D_206D_206F_206D_206B_202D_200E_202D_206D_206C_202E_206F_206F_206C_206E_200B_202C_202C_202C_202C_200E_200D_200C_206C_206F_206B_202A_206D_200D_202C_206A_200C_200D_206C_200F_200B_202C_202E(val6, text2, varObject2);
					num2 = ((int)num3 * -402373286) ^ 0x51E7A935;
					continue;
				}
				case 19u:
				{
					int num12;
					if (num == 4)
					{
						num2 = -1773855194;
						num12 = num2;
					}
					else
					{
						num2 = -1604661117;
						num12 = num2;
					}
					continue;
				}
				case 14u:
				{
					int num9;
					int num10;
					if (!LuaScriptMgr.CheckTypes(L, 1, _206A_202C_206E_202C_200C_206A_206D_200F_200C_202D_200B_200B_202D_200E_206A_200C_200D_206C_206F_200D_202E_202E_206F_202A_200F_200E_206D_200D_206D_202C_202D_206A_202D_206D_200E_200D_200E_202C_200C_202A_202E(typeof(Component).TypeHandle), _206A_202C_206E_202C_200C_206A_206D_200F_200C_202D_200B_200B_202D_200E_206A_200C_200D_206C_206F_200D_202E_202E_206F_202A_200F_200E_206D_200D_206D_202C_202D_206A_202D_206D_200E_200D_200E_202C_200C_202A_202E(typeof(string).TypeHandle), _206A_202C_206E_202C_200C_206A_206D_200F_200C_202D_200B_200B_202D_200E_206A_200C_200D_206C_206F_200D_202E_202E_206F_202A_200F_200E_206D_200D_206D_202C_202D_206A_202D_206D_200E_200D_200E_202C_200C_202A_202E(typeof(SendMessageOptions).TypeHandle)))
					{
						num9 = -148463489;
						num10 = num9;
					}
					else
					{
						num9 = -1495058694;
						num10 = num9;
					}
					num2 = num9 ^ ((int)num3 * -938738109);
					continue;
				}
				case 6u:
					_206C_206C_200D_200E_200E_206C_202C_200E_202B_202D_200B_200E_206C_200F_202A_200C_206D_206C_206D_202A_200B_202E_200C_202A_200E_206F_206D_200F_206D_206D_202E_200D_202A_200F_200C_206B_206C_202D_202E_206A_202E(val4, luaString2);
					return 0;
				case 2u:
				{
					int num5;
					int num6;
					if (LuaScriptMgr.CheckTypes(L, 1, _206A_202C_206E_202C_200C_206A_206D_200F_200C_202D_200B_200B_202D_200E_206A_200C_200D_206C_206F_200D_202E_202E_206F_202A_200F_200E_206D_200D_206D_202C_202D_206A_202D_206D_200E_200D_200E_202C_200C_202A_202E(typeof(Component).TypeHandle), _206A_202C_206E_202C_200C_206A_206D_200F_200C_202D_200B_200B_202D_200E_206A_200C_200D_206C_206F_200D_202E_202E_206F_202A_200F_200E_206D_200D_206D_202C_202D_206A_202D_206D_200E_200D_200E_202C_200C_202A_202E(typeof(string).TypeHandle), _206A_202C_206E_202C_200C_206A_206D_200F_200C_202D_200B_200B_202D_200E_206A_200C_200D_206C_206F_200D_202E_202E_206F_202A_200F_200E_206D_200D_206D_202C_202D_206A_202D_206D_200E_200D_200E_202C_200C_202A_202E(typeof(object).TypeHandle)))
					{
						num5 = -1664523495;
						num6 = num5;
					}
					else
					{
						num5 = -853396780;
						num6 = num5;
					}
					num2 = num5 ^ (int)(num3 * 808505398);
					continue;
				}
				case 20u:
					val4 = (Component)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(940312551u));
					num2 = ((int)num3 * -1174431130) ^ -64132470;
					continue;
				case 15u:
				{
					SendMessageOptions val2 = (SendMessageOptions)(int)LuaScriptMgr.GetNetObject(L, 4, _206A_202C_206E_202C_200C_206A_206D_200F_200C_202D_200B_200B_202D_200E_206A_200C_200D_206C_206F_200D_202E_202E_206F_202A_200F_200E_206D_200D_206D_202C_202D_206A_202D_206D_200E_200D_200E_202C_200C_202A_202E(typeof(SendMessageOptions).TypeHandle));
					_200B_200E_200C_202D_202C_202C_206B_200E_200F_200F_200B_200C_200F_202A_206D_200C_202B_202B_202E_206A_200B_206D_206F_206D_200E_202D_202D_206B_200C_200D_206E_200F_200D_206A_202D_206F_200C_206F_200F_202E(val3, luaString, varObject, val2);
					return 0;
				}
				case 7u:
				{
					int num4;
					if (num != 3)
					{
						num2 = -1555246344;
						num4 = num2;
					}
					else
					{
						num2 = -1019379489;
						num4 = num2;
					}
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
	private static int Lua_Eq(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Object val = default(Object);
		Object val2 = default(Object);
		while (true)
		{
			int num = 1566106531;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x473F3999)) % 4)
				{
				case 0u:
					break;
				case 2u:
				{
					object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
					val = (Object)((luaObject is Object) ? luaObject : null);
					object luaObject2 = LuaScriptMgr.GetLuaObject(L, 2);
					val2 = (Object)((luaObject2 is Object) ? luaObject2 : null);
					num = (int)(num2 * 1159166967) ^ -1685709638;
					continue;
				}
				case 1u:
				{
					bool b = _200B_206F_202B_206F_202C_206F_200C_206B_200D_206B_202D_202C_206C_200C_206F_206C_206B_206C_200B_206F_206F_202A_206F_202E_200B_206E_200C_202B_202C_206C_200C_200B_200B_200F_200B_206B_206D_200D_200E_206C_202E(val, val2);
					LuaScriptMgr.Push(L, b);
					num = ((int)num2 * -91290097) ^ -1058365683;
					continue;
				}
				default:
					return 1;
				}
				break;
			}
		}
	}

	static Type _206A_202C_206E_202C_200C_206A_206D_200F_200C_202D_200B_200B_202D_200E_206A_200C_200D_206C_206F_200D_202E_202E_206F_202A_200F_200E_206D_200D_206D_202C_202D_206A_202D_206D_200E_200D_200E_202C_200C_202A_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static Component _200D_202D_206A_202B_200E_200F_200F_200E_202E_206E_206E_202B_200B_206F_202E_206A_202C_202A_200B_200B_202A_200E_200F_206A_206B_202D_202E_202E_206B_206E_202A_202E_202B_202D_200F_200F_202E_202B_206F_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Component();
	}

	static bool _200B_206F_202B_206F_202C_206F_200C_206B_200D_206B_202D_202C_206C_200C_206F_206C_206B_206C_200B_206F_206F_202A_206F_202E_200B_206E_200C_202B_202C_206C_200C_200B_200B_200F_200B_206B_206D_200D_200E_206C_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static Transform _202B_206C_206A_200E_202D_202D_202B_202B_200F_200B_200B_200E_200E_206A_202C_206C_200E_206B_206A_202E_202B_202A_200E_202E_202D_206C_206A_200C_202C_206D_202B_206C_202B_202E_202A_206E_200F_200B_202C_202B_202E(Component P_0)
	{
		return P_0.transform;
	}

	static GameObject _202A_206B_200F_200D_200F_200F_206C_200E_202E_206A_202A_206C_202E_206D_200C_202C_200F_200E_206D_206C_206F_206E_202E_206C_206B_206B_206B_200C_200E_206F_202C_202B_200E_202A_200C_202C_206E_202D_202C_200C_202E(Component P_0)
	{
		return P_0.gameObject;
	}

	static string _200B_202C_202B_206C_206F_202B_202B_200D_206E_202C_206A_206F_200B_200C_206F_200D_202B_200F_206C_200D_202B_202A_202C_206E_200D_202D_202D_200E_200F_202B_200C_206C_202B_200E_206B_202B_202D_200B_202D_206D_202E(Component P_0)
	{
		return P_0.tag;
	}

	static void _206D_202D_200B_202B_202B_202B_200B_200F_200C_206F_202D_206F_202E_206C_202D_202D_200B_206C_200F_202E_200C_200C_202E_206F_202A_206F_202D_206A_200F_206A_206A_202A_202D_206E_206F_202B_200E_200B_200F_206A_202E(Component P_0, string P_1)
	{
		P_0.tag = P_1;
	}

	static Component _202C_200E_206D_200B_202E_202E_202E_200F_202B_206F_200D_206F_202D_206E_206B_202D_202A_202A_206F_200F_200C_202C_206E_206A_202A_202B_206E_206D_200F_206B_206D_202A_206A_206F_202E_202E_200E_200D_202C_206F_202E(Component P_0, string P_1)
	{
		return P_0.GetComponent(P_1);
	}

	static Component _206C_202A_206A_202D_206D_206B_206B_200B_200F_206A_200D_200C_206D_202D_200B_202D_206E_200B_206A_200E_202A_206C_206C_206A_200C_202E_202B_206C_202D_200D_200E_206A_202B_200C_202A_200E_200D_206B_202A_206B_202E(Component P_0, Type P_1)
	{
		return P_0.GetComponent(P_1);
	}

	static Component _206B_200B_202E_200C_206F_200E_206D_202B_206D_206F_200D_200E_206E_200B_200F_202D_206A_200C_206B_202C_202A_206D_200C_200B_200B_202B_200E_202A_202D_206A_200E_202B_200F_206F_206D_202C_200D_202B_202C_200F_202E(Component P_0, Type P_1)
	{
		return P_0.GetComponentInChildren(P_1);
	}

	static Component[] _202E_206F_202B_206D_200B_200D_202C_202A_202D_202C_200D_200D_202A_200E_206A_200D_202C_202C_202B_200E_206D_206C_200F_200B_200E_206D_202A_206C_202E_206B_200B_202A_206F_200B_202B_202D_200C_200E_202B_202E_202E(Component P_0, Type P_1)
	{
		return P_0.GetComponentsInChildren(P_1);
	}

	static Component[] _200B_206D_206A_206D_206D_200C_206F_206A_202E_202B_200D_200B_200B_202E_202E_200F_200E_202E_202C_200C_206E_202C_202D_200C_200B_202D_202A_206C_206E_206D_202C_200B_200D_200E_202D_206D_206A_202E_206D_202B_202E(Component P_0, Type P_1, bool P_2)
	{
		return P_0.GetComponentsInChildren(P_1, P_2);
	}

	static Component _202D_200E_200C_202C_206B_202B_200B_202B_202E_200B_206F_200D_200E_200C_206F_202D_206D_202E_206C_200C_202D_202B_206C_202D_206B_202B_200D_206E_200E_200F_206C_206E_200C_206A_200F_202D_200F_206E_206E_200F_202E(Component P_0, Type P_1)
	{
		return P_0.GetComponentInParent(P_1);
	}

	static Component[] _202E_200D_206C_200D_200F_200D_200E_206C_200D_202B_200F_200F_206E_206C_206B_202A_206F_202E_202B_206B_200F_206E_202C_200B_206F_202E_206D_206D_206F_202E_200C_206D_200B_200D_200C_200C_206D_202E_200D_202B_202E(Component P_0, Type P_1)
	{
		return P_0.GetComponentsInParent(P_1);
	}

	static Component[] _206E_202E_202B_200B_202E_202D_200C_206C_200B_202E_202A_200D_200D_202D_206A_202A_202B_202D_206C_202D_200D_206F_206F_200C_206D_202E_200E_200E_200D_206B_202D_206B_206F_200B_200D_202B_206E_200D_206E_206F_202E(Component P_0, Type P_1, bool P_2)
	{
		return P_0.GetComponentsInParent(P_1, P_2);
	}

	static Component[] _202D_206A_202C_206D_200E_206D_202D_202C_200E_206A_206A_202D_202E_206D_202E_200C_202A_206C_206C_206D_206B_206C_202C_200F_200D_202E_202A_200B_202D_200E_206A_202A_206A_206D_206A_200D_202A_202D_206B_206B_202E(Component P_0, Type P_1)
	{
		return P_0.GetComponents(P_1);
	}

	static void _200E_206E_206D_206C_206C_202E_202A_202A_206E_206A_202D_202B_200C_202C_200F_206E_206C_202E_206C_200F_200C_206C_200D_206C_200D_206C_202A_206A_202A_206B_206F_206D_206A_200C_202C_206C_206E_206D_202D_206B_202E(Component P_0, Type P_1, List<Component> P_2)
	{
		P_0.GetComponents(P_1, P_2);
	}

	static bool _206D_202D_200B_206D_206F_206F_206F_200D_200C_206F_206B_202B_206E_206F_200C_202A_206B_206F_206F_206B_200D_202D_202A_206D_200D_202C_200D_200B_202B_202E_200F_202E_200F_206D_206F_206A_206B_200B_200F_202E_202E(Component P_0, string P_1)
	{
		return P_0.CompareTag(P_1);
	}

	static void _202C_202C_200D_202E_200C_206E_200B_206C_202D_202B_206B_206E_200C_206B_206C_200C_206B_206D_200C_202E_202E_202D_202D_200C_202E_206B_200B_206D_202C_200B_206B_200F_202C_200E_200D_200D_206D_200E_202A_206C_202E(Component P_0, string P_1)
	{
		P_0.SendMessageUpwards(P_1);
	}

	static void _206C_202B_200B_206C_202A_200B_200E_200D_200C_202B_200F_206F_202B_206D_206B_200E_206B_206A_200D_200C_200F_206D_202A_206A_200D_202E_202E_200D_200B_202C_200D_200D_206B_206D_206B_200D_206D_206C_200C_200E_202E(Component P_0, string P_1, SendMessageOptions P_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		P_0.SendMessageUpwards(P_1, P_2);
	}

	static void _202B_206B_206D_200B_206D_206E_206A_206E_200D_206D_206E_206B_206D_206C_200C_200D_202A_200C_200E_200F_206D_206F_202A_202E_202A_202C_200E_206B_202C_206E_202D_200D_200D_202C_206B_206F_202E_206A_200B_200D_202E(Component P_0, string P_1, object P_2)
	{
		P_0.SendMessageUpwards(P_1, P_2);
	}

	static void _200E_200B_200D_206E_200C_200F_202B_200D_202C_206E_202A_206B_202A_202E_200C_206C_206F_200F_202D_202A_200D_200E_206C_206D_200F_202B_206B_202C_206E_202B_202A_200C_206F_200B_202E_206D_202B_202E_202C_202A_202E(Component P_0, string P_1, object P_2, SendMessageOptions P_3)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		P_0.SendMessageUpwards(P_1, P_2, P_3);
	}

	static void _200D_206C_202D_200D_206E_206A_206A_200D_206D_206F_206D_202D_200C_206C_206F_202C_206E_200E_200E_206B_206B_202A_200C_206C_200C_202C_202E_200B_202E_206A_200D_200C_206D_200B_202D_200B_202A_200F_200B_206A_202E(Component P_0, string P_1)
	{
		P_0.SendMessage(P_1);
	}

	static void _206A_200D_206F_206C_206D_202A_200C_202C_200F_200D_200D_206F_206C_206C_202C_206F_202C_200B_200B_202B_202E_206B_202B_202A_202E_200F_206B_206F_206C_200D_206A_200D_200B_200B_200E_206D_206A_206B_200C_202C_202E(Component P_0, string P_1, SendMessageOptions P_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		P_0.SendMessage(P_1, P_2);
	}

	static void _202B_202C_206A_206B_206E_206B_206C_206A_200D_206A_206C_202B_206F_200B_200E_206F_202C_206D_202D_206C_200B_200F_202C_206C_202C_206A_206D_202C_206F_206A_202E_206E_206F_202B_202A_206E_206D_200C_202D_206F_202E(Component P_0, string P_1, object P_2)
	{
		P_0.SendMessage(P_1, P_2);
	}

	static void _206C_200F_200D_200B_206D_206E_202D_200C_206C_206D_200B_202A_206A_200F_200B_206B_206E_200F_200B_202A_206F_206E_200D_200B_206A_202A_206A_202C_200B_200D_200C_200D_206E_206F_202E_202A_200C_206F_202C_206C_202E(Component P_0, string P_1, object P_2, SendMessageOptions P_3)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		P_0.SendMessage(P_1, P_2, P_3);
	}

	static void _206C_206C_200D_200E_200E_206C_202C_200E_202B_202D_200B_200E_206C_200F_202A_200C_206D_206C_206D_202A_200B_202E_200C_202A_200E_206F_206D_200F_206D_206D_202E_200D_202A_200F_200C_206B_206C_202D_202E_206A_202E(Component P_0, string P_1)
	{
		P_0.BroadcastMessage(P_1);
	}

	static void _200E_206C_200D_202D_206B_206D_206C_202D_200B_206F_206E_200D_200B_206B_206A_202D_200B_200C_206F_200E_206E_206F_200F_200B_200C_200B_206F_206A_202C_206B_202A_200C_202C_200B_206F_200C_202B_202C_206F_202E_202E(Component P_0, string P_1, SendMessageOptions P_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		P_0.BroadcastMessage(P_1, P_2);
	}

	static void _200B_206C_206A_206D_206D_206F_206D_206B_202D_200E_202D_206D_206C_202E_206F_206F_206C_206E_200B_202C_202C_202C_202C_200E_200D_200C_206C_206F_206B_202A_206D_200D_202C_206A_200C_200D_206C_200F_200B_202C_202E(Component P_0, string P_1, object P_2)
	{
		P_0.BroadcastMessage(P_1, P_2);
	}

	static void _200B_200E_200C_202D_202C_202C_206B_200E_200F_200F_200B_200C_200F_202A_206D_200C_202B_202B_202E_206A_200B_206D_206F_206D_200E_202D_202D_206B_200C_200D_206E_200F_200D_206A_202D_206F_200C_206F_200F_202E(Component P_0, string P_1, object P_2, SendMessageOptions P_3)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		P_0.BroadcastMessage(P_1, P_2, P_3);
	}
}
