using System;
using LuaInterface;
using UnityEngine;

public class MeshColliderWrap
{
	private static Type classType = _200B_206E_206F_206B_206D_200B_202E_202B_206D_202A_206E_206A_200F_206A_206C_206E_200E_206C_206A_206F_202B_202D_206F_206A_200D_200B_206D_200E_206D_206F_206F_206B_206F_200C_200C_200E_202A_202E_206B_200F_202E(typeof(MeshCollider).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[3]
		{
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2254933974u), _206E_200B_200D_202B_202B_200D_202C_200F_200E_206C_206A_200C_206F_206B_206E_200D_206A_202C_200B_206E_202B_202D_206E_200B_202B_206C_202B_202B_202D_200D_200E_200D_206A_202B_206A_200D_200E_200F_200B_202D_202E),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3661446913u), GetClassType),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(60698966u), Lua_Eq)
		};
		LuaField[] fields = new LuaField[2]
		{
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2940195163u), get_sharedMesh, set_sharedMesh),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3017621363u), get_convex, set_convex)
		};
		LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2826988684u), _200B_206E_206F_206B_206D_200B_202E_202B_206D_202A_206E_206A_200F_206A_206C_206E_200E_206C_206A_206F_202B_202D_206F_206A_200D_200B_206D_200E_206D_206F_206F_206B_206F_200C_200C_200E_202A_202E_206B_200F_202E(typeof(MeshCollider).TypeHandle), regs, fields, _200B_206E_206F_206B_206D_200B_202E_202B_206D_202A_206E_206A_200F_206A_206C_206E_200E_206C_206A_206F_202B_202D_206F_206A_200D_200B_206D_200E_206D_206F_206F_206B_206F_200C_200C_200E_202A_202E_206B_200F_202E(typeof(Collider).TypeHandle));
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _206E_200B_200D_202B_202B_200D_202C_200F_200E_206C_206A_200C_206F_206B_206E_200D_206A_202C_200B_206E_202B_202D_206E_200B_202B_206C_202B_202B_202D_200D_200E_200D_206A_202B_206A_200D_200E_200F_200B_202D_202E(IntPtr P_0)
	{
		if (LuaDLL.lua_gettop(P_0) == 0)
		{
			goto IL_000a;
		}
		goto IL_004e;
		IL_000a:
		int num = -1422666960;
		goto IL_000f;
		IL_000f:
		uint num2;
		switch ((num2 = (uint)(num ^ -1968506781)) % 4)
		{
		case 0u:
			break;
		case 3u:
		{
			MeshCollider obj = _206C_202D_200B_202E_200E_206B_206F_202B_202C_202B_206C_200F_206B_206A_202B_200F_202D_200E_202A_202B_202E_206E_206B_200B_202D_206F_206C_200D_200F_206A_202B_200D_202A_206B_206D_200B_206E_200B_206C_202B_202E();
			LuaScriptMgr.Push(P_0, (Object)(object)obj);
			return 1;
		}
		case 2u:
			goto IL_004e;
		default:
			return 0;
		}
		goto IL_000a;
		IL_004e:
		LuaDLL.luaL_error(P_0, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1272077499u));
		num = -771985970;
		goto IL_000f;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_sharedMesh(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		MeshCollider val = default(MeshCollider);
		while (true)
		{
			int num = -1862896791;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -891432477)) % 7)
				{
				case 0u:
					break;
				case 3u:
				{
					val = (MeshCollider)luaObject;
					int num5;
					int num6;
					if (!_206F_202C_200B_200F_202D_200E_206D_202B_202D_202A_200B_202E_202C_202B_202C_206A_200F_200E_200E_200F_202D_206A_206D_206B_200F_206A_200E_206D_200D_206A_206B_200C_202D_200C_200B_200C_202E_200E_206E_206A_202E((Object)(object)val, (Object)null))
					{
						num5 = 2008066792;
						num6 = num5;
					}
					else
					{
						num5 = 617170441;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1168774512);
					continue;
				}
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1760109351u));
					num = -1587594424;
					continue;
				case 5u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -1840369723;
						num4 = num3;
					}
					else
					{
						num3 = -1968424239;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1428782341);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1043987433u));
					num = (int)(num2 * 1641885480) ^ -1726190765;
					continue;
				case 2u:
					num = (int)((num2 * 1577000747) ^ 0x186536D8);
					continue;
				default:
					LuaScriptMgr.Push(L, (Object)(object)_206D_200D_202E_200C_200C_200D_206F_200B_202C_202D_202A_202C_206A_206B_200E_200C_202B_206B_200C_206F_202C_202C_206D_202D_200D_202A_202B_200E_200E_202B_200E_206C_206C_206D_206B_202A_202C_206C_206B_200F_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_convex(IntPtr L)
	{
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		MeshCollider val = default(MeshCollider);
		while (true)
		{
			int num = -668952645;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2112221686)) % 10)
				{
				case 5u:
					break;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1745988391u));
					num = -961685356;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1141803165u));
					num = (int)((num2 * 56617130) ^ 0x327CFF4C);
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 327116999;
						num6 = num5;
					}
					else
					{
						num5 = 1222276857;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1770146385);
					continue;
				}
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -592923056) ^ 0xF00DE49;
					continue;
				case 8u:
					LuaScriptMgr.Push(L, _206E_206F_202A_206E_202D_202A_206C_200E_200B_202B_202B_202E_202A_202E_206D_200D_200D_206B_202D_206D_202C_206D_202E_206B_206A_206C_202C_200C_206D_202E_200D_202E_202B_206A_200B_206B_206A_206C_200C_202D_202E(val));
					num = -1049807127;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!_206F_202C_200B_200F_202D_200E_206D_202B_202D_202A_200B_202E_202C_202B_202C_206A_200F_200E_200E_200F_202D_206A_206D_206B_200F_206A_200E_206D_200D_206A_206B_200C_202D_200C_200B_200C_202E_200E_206E_206A_202E((Object)(object)val, (Object)null))
					{
						num3 = 1557518236;
						num4 = num3;
					}
					else
					{
						num3 = 16987202;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 2104333208);
					continue;
				}
				case 3u:
					val = (MeshCollider)luaObject;
					num = ((int)num2 * -1960940576) ^ 0x21DA1AB1;
					continue;
				case 0u:
					num = (int)(num2 * 569320034) ^ -1463351464;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_sharedMesh(IntPtr L)
	{
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		MeshCollider val = default(MeshCollider);
		while (true)
		{
			int num = -2080533076;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2003664001)) % 10)
				{
				case 0u:
					break;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1043987433u));
					num = ((int)num2 * -790806181) ^ -1257496960;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -192230116;
						num6 = num5;
					}
					else
					{
						num5 = -1845094908;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 714141069);
					continue;
				}
				case 5u:
					val = (MeshCollider)luaObject;
					num = (int)((num2 * 1593619021) ^ 0x3A4D0234);
					continue;
				case 8u:
				{
					int num3;
					int num4;
					if (_206F_202C_200B_200F_202D_200E_206D_202B_202D_202A_200B_202E_202C_202B_202C_206A_200F_200E_200E_200F_202D_206A_206D_206B_200F_206A_200E_206D_200D_206A_206B_200C_202D_200C_200B_200C_202E_200E_206E_206A_202E((Object)(object)val, (Object)null))
					{
						num3 = -1730460584;
						num4 = num3;
					}
					else
					{
						num3 = -1677705705;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1134759980);
					continue;
				}
				case 6u:
					num = ((int)num2 * -659327361) ^ -110213407;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2769953974u));
					num = -547431353;
					continue;
				case 7u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -817694737) ^ 0x6FD4DE6A;
					continue;
				case 2u:
					_206B_206A_206D_206C_202D_206A_200D_202B_200E_206A_200D_206B_202E_206D_206F_206D_206C_206A_200C_200C_200D_202C_202B_200D_202E_206C_202E_200C_200C_206E_202C_206F_202B_202E_202E_206E_202D_206D_206C_206E_202E(val, (Mesh)LuaScriptMgr.GetUnityObject(L, 3, _200B_206E_206F_206B_206D_200B_202E_202B_206D_202A_206E_206A_200F_206A_206C_206E_200E_206C_206A_206F_202B_202D_206F_206A_200D_200B_206D_200E_206D_206F_206F_206B_206F_200C_200C_200E_202A_202E_206B_200F_202E(typeof(Mesh).TypeHandle)));
					num = -819760472;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_convex(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		MeshCollider val = (MeshCollider)luaObject;
		while (true)
		{
			int num = -518778179;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -182869231)) % 8)
				{
				case 7u:
					break;
				case 4u:
				{
					int num5;
					int num6;
					if (!_206F_202C_200B_200F_202D_200E_206D_202B_202D_202A_200B_202E_202C_202B_202C_206A_200F_200E_200E_200F_202D_206A_206D_206B_200F_206A_200E_206D_200D_206A_206B_200C_202D_200C_200B_200C_202E_200E_206E_206A_202E((Object)(object)val, (Object)null))
					{
						num5 = -1028036130;
						num6 = num5;
					}
					else
					{
						num5 = -1289685371;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 2127663307);
					continue;
				}
				case 0u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -1055556964;
						num4 = num3;
					}
					else
					{
						num3 = -1600156513;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 683535426);
					continue;
				}
				case 1u:
					num = (int)(num2 * 811907303) ^ -1895391163;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1808204978u));
					num = -1836987718;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2004795018u));
					num = ((int)num2 * -2071705114) ^ -1275119658;
					continue;
				case 3u:
					_202C_206D_202C_202C_206C_202B_206B_206C_202A_202C_202E_206D_200E_200E_206A_200C_202B_206D_206C_202E_206D_206F_206D_200C_202D_206D_202E_200C_200D_202C_200C_206E_200D_202C_206B_200E_200F_200F_202E_202A_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					num = -883240597;
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
		while (true)
		{
			int num = -487856370;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1569468915)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0036;
				default:
				{
					bool b = _206F_202C_200B_200F_202D_200E_206D_202B_202D_202A_200B_202E_202C_202B_202C_206A_200F_200E_200E_200F_202D_206A_206D_206B_200F_206A_200E_206D_200D_206A_206B_200C_202D_200C_200B_200C_202E_200E_206E_206A_202E(val, val2);
					LuaScriptMgr.Push(L, b);
					return 1;
				}
				}
				break;
				IL_0036:
				object luaObject2 = LuaScriptMgr.GetLuaObject(L, 2);
				val2 = (Object)((luaObject2 is Object) ? luaObject2 : null);
				num = ((int)num2 * -1162378595) ^ -384217459;
			}
		}
	}

	static Type _200B_206E_206F_206B_206D_200B_202E_202B_206D_202A_206E_206A_200F_206A_206C_206E_200E_206C_206A_206F_202B_202D_206F_206A_200D_200B_206D_200E_206D_206F_206F_206B_206F_200C_200C_200E_202A_202E_206B_200F_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static MeshCollider _206C_202D_200B_202E_200E_206B_206F_202B_202C_202B_206C_200F_206B_206A_202B_200F_202D_200E_202A_202B_202E_206E_206B_200B_202D_206F_206C_200D_200F_206A_202B_200D_202A_206B_206D_200B_206E_200B_206C_202B_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new MeshCollider();
	}

	static bool _206F_202C_200B_200F_202D_200E_206D_202B_202D_202A_200B_202E_202C_202B_202C_206A_200F_200E_200E_200F_202D_206A_206D_206B_200F_206A_200E_206D_200D_206A_206B_200C_202D_200C_200B_200C_202E_200E_206E_206A_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static Mesh _206D_200D_202E_200C_200C_200D_206F_200B_202C_202D_202A_202C_206A_206B_200E_200C_202B_206B_200C_206F_202C_202C_206D_202D_200D_202A_202B_200E_200E_202B_200E_206C_206C_206D_206B_202A_202C_206C_206B_200F_202E(MeshCollider P_0)
	{
		return P_0.sharedMesh;
	}

	static bool _206E_206F_202A_206E_202D_202A_206C_200E_200B_202B_202B_202E_202A_202E_206D_200D_200D_206B_202D_206D_202C_206D_202E_206B_206A_206C_202C_200C_206D_202E_200D_202E_202B_206A_200B_206B_206A_206C_200C_202D_202E(MeshCollider P_0)
	{
		return P_0.convex;
	}

	static void _206B_206A_206D_206C_202D_206A_200D_202B_200E_206A_200D_206B_202E_206D_206F_206D_206C_206A_200C_200C_200D_202C_202B_200D_202E_206C_202E_200C_200C_206E_202C_206F_202B_202E_202E_206E_202D_206D_206C_206E_202E(MeshCollider P_0, Mesh P_1)
	{
		P_0.sharedMesh = P_1;
	}

	static void _202C_206D_202C_202C_206C_202B_206B_206C_202A_202C_202E_206D_200E_200E_206A_200C_202B_206D_206C_202E_206D_206F_206D_200C_202D_206D_202E_200C_200D_202C_200C_206E_200D_202C_206B_200E_200F_200F_202E_202A_202E(MeshCollider P_0, bool P_1)
	{
		P_0.convex = P_1;
	}
}
