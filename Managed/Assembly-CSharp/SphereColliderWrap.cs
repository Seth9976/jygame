using System;
using LuaInterface;
using UnityEngine;

public class SphereColliderWrap
{
	private static Type classType = _202A_200E_206F_206E_206C_206E_202C_206F_200D_202A_200C_206D_202D_202C_200D_202A_206E_202D_202D_206F_200E_200F_202B_202A_206E_202E_202E_200F_200F_206B_206B_202A_200F_206F_200B_206A_202C_202A_202C_202B_202E(typeof(SphereCollider).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[3]
		{
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2705981273u), _200E_200F_206C_202E_206E_202C_202A_206D_206F_202D_200F_202C_206C_202B_206B_206A_200C_200C_200F_206D_200B_200D_206C_202A_202B_202B_202A_200B_202D_202D_200E_206C_200E_206F_202C_202B_202E_206B_206A_200F_202E),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(215375861u), GetClassType),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3747390401u), Lua_Eq)
		};
		LuaField[] fields = default(LuaField[]);
		while (true)
		{
			int num = 1373823679;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3BCBDC96)) % 4)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					fields = new LuaField[2]
					{
						new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4251997778u), get_center, set_center),
						new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4108677873u), get_radius, set_radius)
					};
					num = (int)(num2 * 1597063366) ^ -919421348;
					continue;
				case 0u:
					LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2181892912u), _202A_200E_206F_206E_206C_206E_202C_206F_200D_202A_200C_206D_202D_202C_200D_202A_206E_202D_202D_206F_200E_200F_202B_202A_206E_202E_202E_200F_200F_206B_206B_202A_200F_206F_200B_206A_202C_202A_202C_202B_202E(typeof(SphereCollider).TypeHandle), regs, fields, _202A_200E_206F_206E_206C_206E_202C_206F_200D_202A_200C_206D_202D_202C_200D_202A_206E_202D_202D_206F_200E_200F_202B_202A_206E_202E_202E_200F_200F_206B_206B_202A_200F_206F_200B_206A_202C_202A_202C_202B_202E(typeof(Collider).TypeHandle));
					num = (int)((num2 * 647393035) ^ 0x72542B39);
					continue;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _200E_200F_206C_202E_206E_202C_202A_206D_206F_202D_200F_202C_206C_202B_206B_206A_200C_200C_200F_206D_200B_200D_206C_202A_202B_202B_202A_200B_202D_202D_200E_206C_200E_206F_202C_202B_202E_206B_206A_200F_202E(IntPtr P_0)
	{
		if (LuaDLL.lua_gettop(P_0) == 0)
		{
			SphereCollider obj = default(SphereCollider);
			while (true)
			{
				int num = -794386748;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1345048374)) % 4)
					{
					case 0u:
						break;
					case 2u:
						obj = _206E_206D_200B_206B_200F_206B_202D_200F_206A_202B_206A_202C_206C_200F_206B_200C_200B_200C_206F_206B_200C_200E_202D_206F_206A_206E_206D_202C_206E_206F_206C_202B_202E_206F_206B_200B_200D_206A_206A_202A_202E();
						num = (int)((num2 * 1772749667) ^ 0x219D5AAB);
						continue;
					case 3u:
						LuaScriptMgr.Push(P_0, (Object)(object)obj);
						return 1;
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
		LuaDLL.luaL_error(P_0, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1871446664u));
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
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		SphereCollider val = default(SphereCollider);
		while (true)
		{
			int num = -2054236686;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1906520154)) % 7)
				{
				case 2u:
					break;
				case 3u:
				{
					val = (SphereCollider)luaObject;
					int num5;
					int num6;
					if (!_202B_206C_206F_202D_202E_200F_206A_202C_200E_206B_200B_200D_200C_206B_202C_200B_200D_200B_202C_206A_206C_200E_206B_200B_206B_200D_200B_200C_200D_202E_206C_202B_202B_200C_200F_206F_206E_206D_202D_206E_202E((Object)(object)val, (Object)null))
					{
						num5 = 119975182;
						num6 = num5;
					}
					else
					{
						num5 = 1147864030;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1236189176);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4210481920u));
					num = -157319250;
					continue;
				case 4u:
					LuaScriptMgr.Push(L, _206A_202A_202A_200D_200E_202A_206C_202E_206F_206C_206E_202A_200D_202C_206D_200B_206C_202B_202C_202B_200E_200F_206D_202D_200E_202B_200D_206E_200C_200C_206C_206E_206B_202B_202C_206F_206D_206E_206A_206E_202E(val));
					num = -542654908;
					continue;
				case 0u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 464079259;
						num4 = num3;
					}
					else
					{
						num3 = 1050525202;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1726042062);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3374412124u));
					num = ((int)num2 * -1375718616) ^ -1695398898;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_radius(IntPtr L)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		SphereCollider val = default(SphereCollider);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1008415923;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0xEBFB75D)) % 9)
				{
				case 4u:
					break;
				case 7u:
				{
					val = (SphereCollider)luaObject;
					int num5;
					int num6;
					if (_202B_206C_206F_202D_202E_200F_206A_202C_200E_206B_200B_200D_200C_206B_202C_200B_200D_200B_202C_206A_206C_200E_206B_200B_206B_200D_200B_200C_200D_202E_206C_202B_202B_200C_200F_206F_206E_206D_202D_206E_202E((Object)(object)val, (Object)null))
					{
						num5 = -1344226907;
						num6 = num5;
					}
					else
					{
						num5 = -2034127042;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1149865747);
					continue;
				}
				case 0u:
					num = (int)((num2 * 2093611733) ^ 0x558FDD1A);
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2362187380u));
					num = (int)((num2 * 472085582) ^ 0x1CDFD81);
					continue;
				case 8u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 1992470228;
						num4 = num3;
					}
					else
					{
						num3 = 439171691;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -846077525);
					continue;
				}
				case 2u:
					LuaScriptMgr.Push(L, _202B_206B_206C_202A_206E_202B_206E_200F_206E_206B_200C_200B_200F_200D_200D_200D_200E_206F_202B_202A_202A_206F_206D_202B_200B_202E_206B_200F_206C_202B_200F_200F_206C_202D_206A_202C_202E_206F_206A_200E_202E(val));
					num = 89679569;
					continue;
				case 6u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -651641330) ^ -12867819;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3053221470u));
					num = 58453096;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_center(IntPtr L)
	{
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		SphereCollider val = default(SphereCollider);
		while (true)
		{
			int num = 1480176489;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x42D06AE5)) % 9)
				{
				case 5u:
					break;
				case 2u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 152245321;
						num6 = num5;
					}
					else
					{
						num5 = 1410135068;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1708522250);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4210481920u));
					num = 201618231;
					continue;
				case 8u:
				{
					int num3;
					int num4;
					if (!_202B_206C_206F_202D_202E_200F_206A_202C_200E_206B_200B_200D_200C_206B_202C_200B_200D_200B_202C_206A_206C_200E_206B_200B_206B_200D_200B_200C_200D_202E_206C_202B_202B_200C_200F_206F_206E_206D_202D_206E_202E((Object)(object)val, (Object)null))
					{
						num3 = -98025007;
						num4 = num3;
					}
					else
					{
						num3 = -1836389098;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1446829222);
					continue;
				}
				case 1u:
					val = (SphereCollider)luaObject;
					num = (int)((num2 * 562919384) ^ 0x486CCCA4);
					continue;
				case 0u:
					_206D_202E_206E_202E_206B_206C_202C_202C_206E_200C_200D_202D_200C_206C_202D_202C_200E_202E_200E_202D_200C_200E_200D_206F_206E_206F_202C_200F_200F_206A_202A_202B_206A_202C_202D_202E_202B_206A_202A_206F_202E(val, LuaScriptMgr.GetVector3(L, 3));
					num = 1555653779;
					continue;
				case 7u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -570089102) ^ 0x3B5A1C6B;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(293089261u));
					num = ((int)num2 * -2038575907) ^ 0x3C2B022A;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_radius(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		SphereCollider val = (SphereCollider)luaObject;
		if (_202B_206C_206F_202D_202E_200F_206A_202C_200E_206B_200B_200D_200C_206B_202C_200B_200D_200B_202C_206A_206C_200E_206B_200B_206B_200D_200B_200C_200D_202E_206C_202B_202B_200C_200F_206F_206E_206D_202D_206E_202E((Object)(object)val, (Object)null))
		{
			goto IL_0018;
		}
		goto IL_008e;
		IL_0018:
		int num = -1064557394;
		goto IL_001d;
		IL_001d:
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -782716529)) % 8)
			{
			case 6u:
				break;
			case 2u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3630292540u));
				num = -687305185;
				continue;
			case 3u:
				num = (int)(num2 * 1264409628) ^ -39681109;
				continue;
			case 1u:
				luaTypes = LuaDLL.lua_type(L, 1);
				num = (int)((num2 * 1943201935) ^ 0x3E0FBFF4);
				continue;
			case 0u:
				goto IL_008e;
			case 5u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2362187380u));
				num = (int)(num2 * 325498173) ^ -1991633699;
				continue;
			case 4u:
			{
				int num3;
				int num4;
				if (luaTypes == LuaTypes.LUA_TTABLE)
				{
					num3 = 138573922;
					num4 = num3;
				}
				else
				{
					num3 = 384462093;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -1431129552);
				continue;
			}
			default:
				return 0;
			}
			break;
		}
		goto IL_0018;
		IL_008e:
		_200E_206D_206A_206D_206F_206A_206A_202D_202B_200B_202A_200B_206F_202E_200E_202A_206B_206F_206E_202B_200B_206D_206D_206B_200E_206E_202A_202C_202E_202D_202C_206B_200C_202C_206C_202B_200C_202D_202B_206A_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
		num = -433197024;
		goto IL_001d;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Lua_Eq(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		while (true)
		{
			int num = 1990367469;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1435176A)) % 3)
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
				object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
				Object val = (Object)((luaObject is Object) ? luaObject : null);
				object luaObject2 = LuaScriptMgr.GetLuaObject(L, 2);
				Object val2 = (Object)((luaObject2 is Object) ? luaObject2 : null);
				bool b = _202B_206C_206F_202D_202E_200F_206A_202C_200E_206B_200B_200D_200C_206B_202C_200B_200D_200B_202C_206A_206C_200E_206B_200B_206B_200D_200B_200C_200D_202E_206C_202B_202B_200C_200F_206F_206E_206D_202D_206E_202E(val, val2);
				LuaScriptMgr.Push(L, b);
				num = (int)(num2 * 1215910510) ^ -910135560;
			}
		}
	}

	static Type _202A_200E_206F_206E_206C_206E_202C_206F_200D_202A_200C_206D_202D_202C_200D_202A_206E_202D_202D_206F_200E_200F_202B_202A_206E_202E_202E_200F_200F_206B_206B_202A_200F_206F_200B_206A_202C_202A_202C_202B_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static SphereCollider _206E_206D_200B_206B_200F_206B_202D_200F_206A_202B_206A_202C_206C_200F_206B_200C_200B_200C_206F_206B_200C_200E_202D_206F_206A_206E_206D_202C_206E_206F_206C_202B_202E_206F_206B_200B_200D_206A_206A_202A_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new SphereCollider();
	}

	static bool _202B_206C_206F_202D_202E_200F_206A_202C_200E_206B_200B_200D_200C_206B_202C_200B_200D_200B_202C_206A_206C_200E_206B_200B_206B_200D_200B_200C_200D_202E_206C_202B_202B_200C_200F_206F_206E_206D_202D_206E_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static Vector3 _206A_202A_202A_200D_200E_202A_206C_202E_206F_206C_206E_202A_200D_202C_206D_200B_206C_202B_202C_202B_200E_200F_206D_202D_200E_202B_200D_206E_200C_200C_206C_206E_206B_202B_202C_206F_206D_206E_206A_206E_202E(SphereCollider P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.center;
	}

	static float _202B_206B_206C_202A_206E_202B_206E_200F_206E_206B_200C_200B_200F_200D_200D_200D_200E_206F_202B_202A_202A_206F_206D_202B_200B_202E_206B_200F_206C_202B_200F_200F_206C_202D_206A_202C_202E_206F_206A_200E_202E(SphereCollider P_0)
	{
		return P_0.radius;
	}

	static void _206D_202E_206E_202E_206B_206C_202C_202C_206E_200C_200D_202D_200C_206C_202D_202C_200E_202E_200E_202D_200C_200E_200D_206F_206E_206F_202C_200F_200F_206A_202A_202B_206A_202C_202D_202E_202B_206A_202A_206F_202E(SphereCollider P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.center = P_1;
	}

	static void _200E_206D_206A_206D_206F_206A_206A_202D_202B_200B_202A_200B_206F_202E_200E_202A_206B_206F_206E_202B_200B_206D_206D_206B_200E_206E_202A_202C_202E_202D_202C_206B_200C_202C_206C_202B_200C_202D_202B_206A_202E(SphereCollider P_0, float P_1)
	{
		P_0.radius = P_1;
	}
}
