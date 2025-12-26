using System;
using LuaInterface;
using UnityEngine;

public class ParticleRendererWrap
{
	private static Type classType = _200B_202A_202B_206E_200D_206B_206E_206E_202B_202D_202C_202D_200C_202C_206D_206F_200E_202D_202B_206E_200E_206C_202D_206A_200B_206A_206F_206E_206A_202C_200E_206E_200E_206C_200E_206F_200F_200E_206A_206C_202E(typeof(ParticleRenderer).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[3]
		{
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2705981273u), _200E_206A_200D_202A_202E_202C_200F_206F_200F_206B_200D_206B_202C_206A_200C_206C_202B_206E_202C_202E_206D_206A_206B_206D_202C_202E_200D_202D_206E_206C_200F_206F_202A_200B_206A_202D_200B_206B_202E_200E_202E),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(10103728u), GetClassType),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2206010212u), Lua_Eq)
		};
		LuaField[] fields = new LuaField[10]
		{
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(497071666u), get_particleRenderMode, set_particleRenderMode),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1008461292u), get_lengthScale, set_lengthScale),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3789997520u), get_velocityScale, set_velocityScale),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1492685597u), get_cameraVelocityScale, set_cameraVelocityScale),
			new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(473778281u), get_maxParticleSize, set_maxParticleSize),
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3905509339u), get_uvAnimationXTile, set_uvAnimationXTile),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3125597325u), get_uvAnimationYTile, set_uvAnimationYTile),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4056061238u), get_uvAnimationCycles, set_uvAnimationCycles),
			new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3125737082u), get_maxPartileSize, set_maxPartileSize),
			new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2917301080u), get_uvTiles, set_uvTiles)
		};
		LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2917851186u), _200B_202A_202B_206E_200D_206B_206E_206E_202B_202D_202C_202D_200C_202C_206D_206F_200E_202D_202B_206E_200E_206C_202D_206A_200B_206A_206F_206E_206A_202C_200E_206E_200E_206C_200E_206F_200F_200E_206A_206C_202E(typeof(ParticleRenderer).TypeHandle), regs, fields, _200B_202A_202B_206E_200D_206B_206E_206E_202B_202D_202C_202D_200C_202C_206D_206F_200E_202D_202B_206E_200E_206C_202D_206A_200B_206A_206F_206E_206A_202C_200E_206E_200E_206C_200E_206F_200F_200E_206A_206C_202E(typeof(Renderer).TypeHandle));
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _200E_206A_200D_202A_202E_202C_200F_206F_200F_206B_200D_206B_202C_206A_200C_206C_202B_206E_202C_202E_206D_206A_206B_206D_202C_202E_200D_202D_206E_206C_200F_206F_202A_200B_206A_202D_200B_206B_202E_200E_202E(IntPtr P_0)
	{
		int num = LuaDLL.lua_gettop(P_0);
		ParticleRenderer obj = default(ParticleRenderer);
		while (true)
		{
			int num2 = 1766494009;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x4C99C9E2)) % 7)
				{
				case 5u:
					break;
				case 4u:
					LuaDLL.luaL_error(P_0, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(374538875u));
					num2 = 756151382;
					continue;
				case 1u:
					obj = _206B_206A_202C_202D_202B_206A_202A_206E_202D_206D_202D_202E_200D_206F_206F_200E_200E_202A_200D_206F_202B_206E_206F_206F_202A_206B_200C_200C_202D_200C_200F_206D_206F_200D_206D_202D_200C_202E_200D_206B_202E();
					num2 = ((int)num3 * -155846629) ^ 0x35E6164;
					continue;
				case 0u:
					LuaScriptMgr.Push(P_0, (Object)(object)obj);
					num2 = ((int)num3 * -498569298) ^ -1189196666;
					continue;
				case 3u:
					return 1;
				case 6u:
				{
					int num4;
					int num5;
					if (num == 0)
					{
						num4 = -1865353647;
						num5 = num4;
					}
					else
					{
						num4 = -952946028;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 2063578893);
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
	private static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_particleRenderMode(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleRenderer val = (ParticleRenderer)luaObject;
		if (_206B_206C_206A_206A_202B_202E_200D_200C_206E_206E_206A_202E_200F_206A_206E_200B_202B_202D_206A_206F_200F_206C_206A_200D_206B_202D_206E_200E_200E_206C_206D_202B_202D_200D_206C_206F_206A_206B_202E_202C_202E((Object)(object)val, (Object)null))
		{
			goto IL_0018;
		}
		goto IL_0064;
		IL_0018:
		int num = -751996352;
		goto IL_001d;
		IL_001d:
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -396650771)) % 7)
			{
			case 4u:
				break;
			case 1u:
				luaTypes = LuaDLL.lua_type(L, 1);
				num = (int)((num2 * 1795737038) ^ 0x4EF4E9E0);
				continue;
			case 5u:
				goto IL_0064;
			case 6u:
			{
				int num3;
				int num4;
				if (luaTypes == LuaTypes.LUA_TTABLE)
				{
					num3 = -888911598;
					num4 = num3;
				}
				else
				{
					num3 = -715865825;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -1532066089);
				continue;
			}
			case 3u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(219964364u));
				num = (int)((num2 * 1321505001) ^ 0x4FB836A9);
				continue;
			case 0u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(374572548u));
				num = -1217345429;
				continue;
			default:
				return 1;
			}
			break;
		}
		goto IL_0018;
		IL_0064:
		LuaScriptMgr.Push(L, (Enum)(object)_206B_200D_202E_202A_206D_200C_206A_202C_202D_200B_200C_206B_206D_206E_206E_202C_202D_202D_200B_206C_206D_206F_200C_200D_206B_206C_200E_202E_200F_200B_206E_206E_202C_202B_200B_206A_200F_206F_206A_200D_202E(val));
		num = -241666616;
		goto IL_001d;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_lengthScale(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleRenderer val = (ParticleRenderer)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -425651851;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1658695253)) % 7)
				{
				case 0u:
					break;
				case 2u:
				{
					int num5;
					int num6;
					if (!_206B_206C_206A_206A_202B_202E_200D_200C_206E_206E_206A_202E_200F_206A_206E_200B_202B_202D_206A_206F_200F_206C_206A_200D_206B_202D_206E_200E_200E_206C_206D_202B_202D_200D_206C_206F_206A_206B_202E_202C_202E((Object)(object)val, (Object)null))
					{
						num5 = -1205711313;
						num6 = num5;
					}
					else
					{
						num5 = -1208564096;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1139055198);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1827390256u));
					num = -1764944981;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3398175578u));
					num = (int)((num2 * 407658357) ^ 0x3D7A5B4E);
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 385797259;
						num4 = num3;
					}
					else
					{
						num3 = 1645357830;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -325800177);
					continue;
				}
				case 6u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -494379788) ^ 0x1FDC7D38;
					continue;
				default:
					LuaScriptMgr.Push(L, _202E_206C_206D_206C_202C_206B_200D_206B_202C_200F_202B_202B_200D_206D_206C_206D_206A_200C_206F_206D_202C_206C_200C_202D_200D_200C_202C_206B_206F_200D_200F_202D_202A_206F_202D_206E_200F_200E_202E_206D_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_velocityScale(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleRenderer val = (ParticleRenderer)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 515589636;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5C1E0D92)) % 8)
				{
				case 2u:
					break;
				case 7u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -298137359;
						num6 = num5;
					}
					else
					{
						num5 = -1576137713;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 423663256);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1925778719u));
					num = ((int)num2 * -123581748) ^ 0x7BD3770F;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1288008384u));
					num = 1894720563;
					continue;
				case 1u:
					LuaScriptMgr.Push(L, _202D_206D_200D_206B_202D_206F_206E_200C_202D_202D_202C_206F_206F_200F_206D_202A_200F_206A_202C_200C_206F_206C_200C_202C_206B_206A_200E_206C_206B_200F_200F_206A_202D_200C_200B_206D_206A_202B_200E_206F_202E(val));
					num = 1418077474;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (_206B_206C_206A_206A_202B_202E_200D_200C_206E_206E_206A_202E_200F_206A_206E_200B_202B_202D_206A_206F_200F_206C_206A_200D_206B_202D_206E_200E_200E_206C_206D_202B_202D_200D_206C_206F_206A_206B_202E_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = -1430138064;
						num4 = num3;
					}
					else
					{
						num3 = -1239494147;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1500120107);
					continue;
				}
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -101716336) ^ -30996131;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_cameraVelocityScale(IntPtr L)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleRenderer val = default(ParticleRenderer);
		while (true)
		{
			int num = 1836621537;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4C55366D)) % 7)
				{
				case 5u:
					break;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2720792431u));
					num = (int)((num2 * 1912761786) ^ 0x2B61135D);
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3409851944u));
					num = 607553609;
					continue;
				case 3u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -481429805;
						num6 = num5;
					}
					else
					{
						num5 = -1868514769;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1839130268);
					continue;
				}
				case 4u:
					val = (ParticleRenderer)luaObject;
					num = ((int)num2 * -482827923) ^ -1461484372;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!_206B_206C_206A_206A_202B_202E_200D_200C_206E_206E_206A_202E_200F_206A_206E_200B_202B_202D_206A_206F_200F_206C_206A_200D_206B_202D_206E_200E_200E_206C_206D_202B_202D_200D_206C_206F_206A_206B_202E_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = -115461007;
						num4 = num3;
					}
					else
					{
						num3 = -1291052792;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 152416664);
					continue;
				}
				default:
					LuaScriptMgr.Push(L, _202E_206A_206A_202E_206A_202A_202D_200B_206C_200D_202B_206F_200D_200E_206C_206E_200E_206B_202E_202E_206D_206C_206F_206F_202B_200D_206D_206F_202E_200E_200F_206C_200D_206F_206B_206B_202B_200B_206E_200F_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_maxParticleSize(IntPtr L)
	{
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		ParticleRenderer val = default(ParticleRenderer);
		while (true)
		{
			int num = -1538865161;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -854380301)) % 10)
				{
				case 8u:
					break;
				case 0u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -1284884517;
						num6 = num5;
					}
					else
					{
						num5 = -64469350;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 751422754);
					continue;
				}
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1374808584) ^ 0x1D7F666F;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2740444464u));
					num = -119868272;
					continue;
				case 9u:
					LuaScriptMgr.Push(L, _200E_206A_200C_206D_200D_206D_200E_202C_206D_200F_200D_206E_206B_206B_202A_206C_206D_206A_200E_200E_200E_202E_206A_200C_200D_200F_206D_206B_206D_200B_200E_202E_206C_206D_200E_200D_200E_206B_200E_206E_202E(val));
					num = -952970980;
					continue;
				case 6u:
					val = (ParticleRenderer)luaObject;
					num = (int)(num2 * 887401598) ^ -1248401478;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!_206B_206C_206A_206A_202B_202E_200D_200C_206E_206E_206A_202E_200F_206A_206E_200B_202B_202D_206A_206F_200F_206C_206A_200D_206B_202D_206E_200E_200E_206C_206D_202B_202D_200D_206C_206F_206A_206B_202E_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = 921570358;
						num4 = num3;
					}
					else
					{
						num3 = 1111662669;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1805622138);
					continue;
				}
				case 1u:
					num = (int)((num2 * 970533260) ^ 0x6B4960CC);
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3953132878u));
					num = ((int)num2 * -1712350261) ^ 0x5EB63475;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_uvAnimationXTile(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleRenderer val = (ParticleRenderer)luaObject;
		while (true)
		{
			int num = -1686892840;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -711146302)) % 7)
				{
				case 0u:
					break;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(42818283u));
					num = ((int)num2 * -1634894600) ^ -1801584908;
					continue;
				case 3u:
					LuaScriptMgr.Push(L, _206D_202E_202D_206E_200B_200E_202A_206F_202C_200F_206F_206D_200C_200B_202E_202E_206D_202C_206E_206D_200D_200E_202D_206A_200F_206B_202A_206B_200C_202C_200D_206A_206D_202C_202C_206F_206B_206F_202C_206F_202E(val));
					num = -683896022;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (_206B_206C_206A_206A_202B_202E_200D_200C_206E_206E_206A_202E_200F_206A_206E_200B_202B_202D_206A_206F_200F_206C_206A_200D_206B_202D_206E_200E_200E_206C_206D_202B_202D_200D_206C_206F_206A_206B_202E_202C_202E((Object)(object)val, (Object)null))
					{
						num5 = 2126574412;
						num6 = num5;
					}
					else
					{
						num5 = 1933860930;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 2023785755);
					continue;
				}
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2892305461u));
					num = -1333218564;
					continue;
				case 5u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 1448188189;
						num4 = num3;
					}
					else
					{
						num3 = 1137724429;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1028468400);
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
	private static int get_uvAnimationYTile(IntPtr L)
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		ParticleRenderer val = default(ParticleRenderer);
		while (true)
		{
			int num = -1041636684;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1925660315)) % 9)
				{
				case 4u:
					break;
				case 6u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 1317758493;
						num6 = num5;
					}
					else
					{
						num5 = 1730719560;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 730897975);
					continue;
				}
				case 8u:
				{
					int num3;
					int num4;
					if (!_206B_206C_206A_206A_202B_202E_200D_200C_206E_206E_206A_202E_200F_206A_206E_200B_202B_202D_206A_206F_200F_206C_206A_200D_206B_202D_206E_200E_200E_206C_206D_202B_202D_200D_206C_206F_206A_206B_202E_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = -873287462;
						num4 = num3;
					}
					else
					{
						num3 = -400414969;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -2137084642);
					continue;
				}
				case 5u:
					num = (int)(num2 * 1923365302) ^ -1070424168;
					continue;
				case 1u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 2021982918) ^ -788733589;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3382866870u));
					num = -1022815116;
					continue;
				case 7u:
					val = (ParticleRenderer)luaObject;
					num = (int)((num2 * 1250591612) ^ 0x31EE66E0);
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1343436348u));
					num = ((int)num2 * -628738711) ^ 0x6EBBD3D8;
					continue;
				default:
					LuaScriptMgr.Push(L, _200C_200D_200F_206F_202C_200C_200E_206A_206B_202B_206D_202A_200C_206A_206D_200B_202B_200F_206E_202D_206F_202A_206D_200D_200F_202D_206A_200C_206B_202B_202B_206D_206E_202C_200D_200F_200C_202B_200B_202B_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_uvAnimationCycles(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleRenderer val = (ParticleRenderer)luaObject;
		while (true)
		{
			int num = -20973717;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1274168918)) % 6)
				{
				case 4u:
					break;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2992337593u));
					num = -1328957367;
					continue;
				case 3u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -1216862680;
						num6 = num5;
					}
					else
					{
						num5 = -1351881494;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -679877704);
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (_206B_206C_206A_206A_202B_202E_200D_200C_206E_206E_206A_202E_200F_206A_206E_200B_202B_202D_206A_206F_200F_206C_206A_200D_206B_202D_206E_200E_200E_206C_206D_202B_202D_200D_206C_206F_206A_206B_202E_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = 57419580;
						num4 = num3;
					}
					else
					{
						num3 = 648999372;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1489727429);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3345131377u));
					num = ((int)num2 * -115778588) ^ -1145738519;
					continue;
				default:
					LuaScriptMgr.Push(L, _202A_206B_202A_206B_200B_200E_202A_202C_206A_200F_202E_202B_200C_200B_206E_202E_200F_202D_202E_200E_202D_206F_200E_200F_202C_200C_200C_206F_202E_200E_206D_200E_200C_200E_206A_206D_200F_202C_206F_206C_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_maxPartileSize(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleRenderer val = (ParticleRenderer)luaObject;
		while (true)
		{
			int num = 2144302384;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7E83CFD9)) % 7)
				{
				case 0u:
					break;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3986634758u));
					num = 774956453;
					continue;
				case 4u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -1974681547;
						num6 = num5;
					}
					else
					{
						num5 = -844282681;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 340448527);
					continue;
				}
				case 2u:
					LuaScriptMgr.Push(L, _206C_206F_200C_206D_200F_202E_206F_206B_206B_202B_206A_200D_206D_200E_206C_202E_206C_202C_206D_206F_202D_200E_202E_206A_200E_206A_206D_202B_206C_202A_206B_206B_202C_202A_202D_206B_200C_206C_202C_206A_202E(val));
					num = 665686246;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!_206B_206C_206A_206A_202B_202E_200D_200C_206E_206E_206A_202E_200F_206A_206E_200B_202B_202D_206A_206F_200F_206C_206A_200D_206B_202D_206E_200E_200E_206C_206D_202B_202D_200D_206C_206F_206A_206B_202E_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = -1825055130;
						num4 = num3;
					}
					else
					{
						num3 = -1618632083;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1963572683);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2161072513u));
					num = ((int)num2 * -646675725) ^ 0x6BBDB44A;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_uvTiles(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleRenderer val = (ParticleRenderer)luaObject;
		while (true)
		{
			int num = 1670354509;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3E36DFC2)) % 8)
				{
				case 0u:
					break;
				case 7u:
				{
					int num5;
					int num6;
					if (!_206B_206C_206A_206A_202B_202E_200D_200C_206E_206E_206A_202E_200F_206A_206E_200B_202B_202D_206A_206F_200F_206C_206A_200D_206B_202D_206E_200E_200E_206C_206D_202B_202D_200D_206C_206F_206A_206B_202E_202C_202E((Object)(object)val, (Object)null))
					{
						num5 = -936499179;
						num6 = num5;
					}
					else
					{
						num5 = -408723221;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1884932787);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(398006516u));
					num = 394161384;
					continue;
				case 4u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -669854804;
						num4 = num3;
					}
					else
					{
						num3 = -2106032543;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1322685516);
					continue;
				}
				case 2u:
					LuaScriptMgr.PushArray(L, _200F_200F_200E_200E_200B_200F_200D_206A_206D_202B_200C_202E_200B_200D_202E_206D_200F_200E_200B_202A_206E_202A_206C_202B_206C_206B_206D_202E_206F_206F_200B_200C_206D_206F_206C_206D_200B_206E_206A_200F_202E(val));
					num = 205716427;
					continue;
				case 5u:
					num = ((int)num2 * -2098331789) ^ -1002647753;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1127810965u));
					num = ((int)num2 * -1458668814) ^ 0x367C9B51;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_particleRenderMode(IntPtr L)
	{
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		ParticleRenderer val = default(ParticleRenderer);
		while (true)
		{
			int num = 655343614;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2DB47E18)) % 8)
				{
				case 0u:
					break;
				case 1u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -346051294;
						num6 = num5;
					}
					else
					{
						num5 = -1902606097;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1243303931);
					continue;
				}
				case 3u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1256388587) ^ 0x78636A16;
					continue;
				case 5u:
					_202C_202B_200F_206D_200C_206D_200F_200F_200D_206E_206C_202B_206D_202A_200B_200F_200D_206F_202C_206C_200D_202E_202A_202C_200E_202A_200E_206D_202C_202B_206B_206E_206A_200C_206F_206C_202E_206F_206B_206B_202E(val, (ParticleRenderMode)(int)LuaScriptMgr.GetNetObject(L, 3, _200B_202A_202B_206E_200D_206B_206E_206E_202B_202D_202C_202D_200C_202C_206D_206F_200E_202D_202B_206E_200E_206C_202D_206A_200B_206A_206F_206E_206A_202C_200E_206E_200E_206C_200E_206F_200F_200E_206A_206C_202E(typeof(ParticleRenderMode).TypeHandle)));
					num = 756058788;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3461132120u));
					num = ((int)num2 * -1935562412) ^ 0x1235F135;
					continue;
				case 6u:
				{
					val = (ParticleRenderer)luaObject;
					int num3;
					int num4;
					if (_206B_206C_206A_206A_202B_202E_200D_200C_206E_206E_206A_202E_200F_206A_206E_200B_202B_202D_206A_206F_200F_206C_206A_200D_206B_202D_206E_200E_200E_206C_206D_202B_202D_200D_206C_206F_206A_206B_202E_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = 1667813551;
						num4 = num3;
					}
					else
					{
						num3 = 1229178761;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -654030834);
					continue;
				}
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(559583801u));
					num = 723946781;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_lengthScale(IntPtr L)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		ParticleRenderer val = default(ParticleRenderer);
		while (true)
		{
			int num = -207065515;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2126893044)) % 8)
				{
				case 3u:
					break;
				case 5u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 2120775462) ^ 0x3F056C88);
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (!_206B_206C_206A_206A_202B_202E_200D_200C_206E_206E_206A_202E_200F_206A_206E_200B_202B_202D_206A_206F_200F_206C_206A_200D_206B_202D_206E_200E_200E_206C_206D_202B_202D_200D_206C_206F_206A_206B_202E_202C_202E((Object)(object)val, (Object)null))
					{
						num5 = -278982102;
						num6 = num5;
					}
					else
					{
						num5 = -1123880391;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1375988334);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(937642863u));
					num = (int)(num2 * 1237180424) ^ -1426429726;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1678861835u));
					num = -101029214;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 1831378638;
						num4 = num3;
					}
					else
					{
						num3 = 304252329;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -531277439);
					continue;
				}
				case 1u:
					val = (ParticleRenderer)luaObject;
					num = (int)((num2 * 499356201) ^ 0x87C6991);
					continue;
				default:
					_200F_202C_202E_206B_202A_202D_200E_206C_202C_200B_206C_202C_200E_200D_202A_202A_202D_200D_200D_202D_206B_202E_200C_202B_200F_200D_206A_202B_200F_200F_202E_202C_200B_202B_200C_200E_202C_206F_202C_206A_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_velocityScale(IntPtr L)
	{
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleRenderer val = default(ParticleRenderer);
		while (true)
		{
			int num = 699526975;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x285ADA5D)) % 8)
				{
				case 4u:
					break;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2230231022u));
					num = ((int)num2 * -1567684430) ^ 0x627663AB;
					continue;
				case 0u:
					num = (int)((num2 * 244327918) ^ 0x1F02BD8A);
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3850881499u));
					num = 854717930;
					continue;
				case 7u:
					_206D_200D_206B_202D_206C_206C_206C_202A_202B_200E_202D_200C_200D_200F_200E_206D_200F_200D_202B_206D_206F_206E_200F_202E_200C_206D_206E_206F_202B_202D_200B_206A_200C_206A_202C_206A_200D_202E_206D_200E_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					num = 331061459;
					continue;
				case 2u:
				{
					val = (ParticleRenderer)luaObject;
					int num5;
					int num6;
					if (!_206B_206C_206A_206A_202B_202E_200D_200C_206E_206E_206A_202E_200F_206A_206E_200B_202B_202D_206A_206F_200F_206C_206A_200D_206B_202D_206E_200E_200E_206C_206D_202B_202D_200D_206C_206F_206A_206B_202E_202C_202E((Object)(object)val, (Object)null))
					{
						num5 = -769348690;
						num6 = num5;
					}
					else
					{
						num5 = -236952436;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1272576574);
					continue;
				}
				case 5u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -690396575;
						num4 = num3;
					}
					else
					{
						num3 = -656525685;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -695737687);
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
	private static int set_cameraVelocityScale(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleRenderer val = (ParticleRenderer)luaObject;
		if (_206B_206C_206A_206A_202B_202E_200D_200C_206E_206E_206A_202E_200F_206A_206E_200B_202B_202D_206A_206F_200F_206C_206A_200D_206B_202D_206E_200E_200E_206C_206D_202B_202D_200D_206C_206F_206A_206B_202E_202C_202E((Object)(object)val, (Object)null))
		{
			goto IL_0018;
		}
		goto IL_0046;
		IL_0018:
		int num = -198922656;
		goto IL_001d;
		IL_001d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -53642994)) % 6)
			{
			case 0u:
				break;
			case 1u:
				goto IL_0046;
			case 4u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2720792431u));
				num = (int)(num2 * 1740578590) ^ -905017263;
				continue;
			case 5u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3409851944u));
				num = -927763807;
				continue;
			case 2u:
			{
				LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
				int num3;
				int num4;
				if (luaTypes == LuaTypes.LUA_TTABLE)
				{
					num3 = -943723986;
					num4 = num3;
				}
				else
				{
					num3 = -928795463;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -723232116);
				continue;
			}
			default:
				return 0;
			}
			break;
		}
		goto IL_0018;
		IL_0046:
		_206E_206A_200B_200D_200F_206F_206D_200D_206C_202C_200E_206C_200D_202C_200D_206D_206D_206D_202D_206F_206A_200D_206D_200D_200F_200E_206D_202E_206F_206F_206A_206F_200D_202D_206E_202C_202A_202B_200B_202C_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
		num = -1028196999;
		goto IL_001d;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_maxParticleSize(IntPtr L)
	{
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleRenderer val = default(ParticleRenderer);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -498105120;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1900654965)) % 9)
				{
				case 0u:
					break;
				case 2u:
					_206F_200F_206E_202B_200D_206B_202D_206E_200F_202A_202D_200B_202A_202C_200B_200F_200E_206B_200B_206F_206E_206B_206F_202D_200E_206B_200C_206D_206B_202D_202B_206E_206C_206C_202B_202E_200B_200E_206E_202D_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					num = -90332926;
					continue;
				case 5u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 92710877) ^ -1123578492;
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -1320598858;
						num6 = num5;
					}
					else
					{
						num5 = -373443998;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1542731364);
					continue;
				}
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4251984875u));
					num = -124289371;
					continue;
				case 4u:
					num = (int)(num2 * 2121606528) ^ -1635531995;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3953132878u));
					num = (int)(num2 * 1566010076) ^ -1002229354;
					continue;
				case 3u:
				{
					val = (ParticleRenderer)luaObject;
					int num3;
					int num4;
					if (!_206B_206C_206A_206A_202B_202E_200D_200C_206E_206E_206A_202E_200F_206A_206E_200B_202B_202D_206A_206F_200F_206C_206A_200D_206B_202D_206E_200E_200E_206C_206D_202B_202D_200D_206C_206F_206A_206B_202E_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = 2045793855;
						num4 = num3;
					}
					else
					{
						num3 = 1214496800;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1820756914);
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
	private static int set_uvAnimationXTile(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleRenderer val = (ParticleRenderer)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -2100179027;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -601889060)) % 8)
				{
				case 7u:
					break;
				case 1u:
				{
					int num5;
					int num6;
					if (_206B_206C_206A_206A_202B_202E_200D_200C_206E_206E_206A_202E_200F_206A_206E_200B_202B_202D_206A_206F_200F_206C_206A_200D_206B_202D_206E_200E_200E_206C_206D_202B_202D_200D_206C_206F_206A_206B_202E_202C_202E((Object)(object)val, (Object)null))
					{
						num5 = -179844002;
						num6 = num5;
					}
					else
					{
						num5 = -1375477377;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1822750616);
					continue;
				}
				case 3u:
					_200F_202A_206C_206B_206C_206D_206C_200C_202E_206D_206D_202B_202A_200B_202B_206C_206B_200D_200E_202E_206D_206D_202E_202B_200E_202E_202B_206F_206D_206E_202B_202A_206A_200C_206E_202A_206A_206C_206C_202E(val, (int)LuaScriptMgr.GetNumber(L, 3));
					num = -20216896;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1065183396u));
					num = -1026866329;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2967776447u));
					num = (int)((num2 * 373570112) ^ 0x66268427);
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -284065966;
						num4 = num3;
					}
					else
					{
						num3 = -55454927;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -239801043);
					continue;
				}
				case 2u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 495652549) ^ -257582970;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_uvAnimationYTile(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleRenderer val = (ParticleRenderer)luaObject;
		while (true)
		{
			int num = 87744176;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x37B728C5)) % 8)
				{
				case 6u:
					break;
				case 7u:
					_202E_202B_206D_206F_206D_206F_206F_200E_202D_202D_206B_202C_202C_202B_206F_202B_202E_206E_200C_206E_200E_200C_200F_202C_200C_206B_202D_206C_200F_202E_202A_206B_206C_206D_202C_200D_206F_206C_206D_206C_202E(val, (int)LuaScriptMgr.GetNumber(L, 3));
					num = 1348724437;
					continue;
				case 1u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 417640110;
						num6 = num5;
					}
					else
					{
						num5 = 741439425;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1038487);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2959938615u));
					num = 2055676818;
					continue;
				case 2u:
					num = (int)((num2 * 526714790) ^ 0x1592716E);
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2221408646u));
					num = (int)((num2 * 798173983) ^ 0x3EC72DCB);
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (_206B_206C_206A_206A_202B_202E_200D_200C_206E_206E_206A_202E_200F_206A_206E_200B_202B_202D_206A_206F_200F_206C_206A_200D_206B_202D_206E_200E_200E_206C_206D_202B_202D_200D_206C_206F_206A_206B_202E_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = -452147801;
						num4 = num3;
					}
					else
					{
						num3 = -954970831;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1395057225);
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
	private static int set_uvAnimationCycles(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleRenderer val = (ParticleRenderer)luaObject;
		if (_206B_206C_206A_206A_202B_202E_200D_200C_206E_206E_206A_202E_200F_206A_206E_200B_202B_202D_206A_206F_200F_206C_206A_200D_206B_202D_206E_200E_200E_206C_206D_202B_202D_200D_206C_206F_206A_206B_202E_202C_202E((Object)(object)val, (Object)null))
		{
			goto IL_0018;
		}
		goto IL_0077;
		IL_0018:
		int num = 505898954;
		goto IL_001d;
		IL_001d:
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x62D51F6)) % 8)
			{
			case 0u:
				break;
			case 6u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2051839086u));
				num = 1804456949;
				continue;
			case 7u:
				num = ((int)num2 * -1438160604) ^ 0x1DBEEAA9;
				continue;
			case 3u:
				goto IL_0077;
			case 2u:
			{
				int num3;
				int num4;
				if (luaTypes == LuaTypes.LUA_TTABLE)
				{
					num3 = 1451316389;
					num4 = num3;
				}
				else
				{
					num3 = 1371089058;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -1665721483);
				continue;
			}
			case 4u:
				luaTypes = LuaDLL.lua_type(L, 1);
				num = ((int)num2 * -557119789) ^ 0x114EB480;
				continue;
			case 1u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3345131377u));
				num = (int)((num2 * 356966155) ^ 0x5DE3639A);
				continue;
			default:
				return 0;
			}
			break;
		}
		goto IL_0018;
		IL_0077:
		_200F_202D_200F_202E_200E_206F_206F_202E_206F_200C_206B_202C_202D_202C_206C_202C_200E_206D_200B_202B_200B_206F_206A_206B_202D_200F_200D_202E_200E_206F_202E_200E_206F_200E_200D_200E_202E_200B_200E_202E_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
		num = 1479708499;
		goto IL_001d;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_maxPartileSize(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleRenderer val = (ParticleRenderer)luaObject;
		while (true)
		{
			int num = -531942365;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1156862015)) % 6)
				{
				case 0u:
					break;
				case 2u:
				{
					int num5;
					int num6;
					if (_206B_206C_206A_206A_202B_202E_200D_200C_206E_206E_206A_202E_200F_206A_206E_200B_202B_202D_206A_206F_200F_206C_206A_200D_206B_202D_206E_200E_200E_206C_206D_202B_202D_200D_206C_206F_206A_206B_202E_202C_202E((Object)(object)val, (Object)null))
					{
						num5 = -385845416;
						num6 = num5;
					}
					else
					{
						num5 = -771535168;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -394247493);
					continue;
				}
				case 1u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -590964315;
						num4 = num3;
					}
					else
					{
						num3 = -516612996;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1684216348);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2429194016u));
					num = ((int)num2 * -1291428582) ^ -943363738;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3341937031u));
					num = -1017025322;
					continue;
				default:
					_200F_206C_200C_200D_202C_202C_202E_200E_206D_202A_200F_200E_200F_202A_202B_200F_206B_200F_200E_200F_200C_206C_206F_206D_206C_206D_206C_200D_202B_202C_200B_202A_202A_200B_200C_206C_202E_206F_202C_200C_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_uvTiles(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleRenderer val = (ParticleRenderer)luaObject;
		while (true)
		{
			int num = 353998841;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4938015D)) % 7)
				{
				case 0u:
					break;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1618462781u));
					num = 880053314;
					continue;
				case 1u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -1226092057;
						num6 = num5;
					}
					else
					{
						num5 = -766454381;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1635899104);
					continue;
				}
				case 5u:
				{
					int num3;
					int num4;
					if (!_206B_206C_206A_206A_202B_202E_200D_200C_206E_206E_206A_202E_200F_206A_206E_200B_202B_202D_206A_206F_200F_206C_206A_200D_206B_202D_206E_200E_200E_206C_206D_202B_202D_200D_206C_206F_206A_206B_202E_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = -875509058;
						num4 = num3;
					}
					else
					{
						num3 = -199849956;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1740115239);
					continue;
				}
				case 6u:
					num = ((int)num2 * -1026609025) ^ 0x3F2D8871;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3524814636u));
					num = (int)(num2 * 1385435513) ^ -87151570;
					continue;
				default:
					_206C_200D_206F_200D_200E_200E_206A_202C_206E_200E_202A_206C_206F_200F_202A_202E_206E_200C_200E_202B_200B_200F_200D_200B_200B_200B_200E_200F_206A_200E_202C_206B_206D_206D_202A_200B_200D_206C_202C_206A_202E(val, LuaScriptMgr.GetArrayObject<Rect>(L, 3));
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
		bool b = default(bool);
		while (true)
		{
			int num = -1737631319;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2015621062)) % 6)
				{
				case 5u:
					break;
				case 1u:
				{
					object luaObject2 = LuaScriptMgr.GetLuaObject(L, 1);
					val = (Object)((luaObject2 is Object) ? luaObject2 : null);
					num = (int)((num2 * 1941572938) ^ 0x5499E652);
					continue;
				}
				case 0u:
				{
					object luaObject = LuaScriptMgr.GetLuaObject(L, 2);
					val2 = (Object)((luaObject is Object) ? luaObject : null);
					num = ((int)num2 * -1331229267) ^ -1829934524;
					continue;
				}
				case 4u:
					b = _206B_206C_206A_206A_202B_202E_200D_200C_206E_206E_206A_202E_200F_206A_206E_200B_202B_202D_206A_206F_200F_206C_206A_200D_206B_202D_206E_200E_200E_206C_206D_202B_202D_200D_206C_206F_206A_206B_202E_202C_202E(val, val2);
					num = (int)(num2 * 1007013030) ^ -858479206;
					continue;
				case 2u:
					LuaScriptMgr.Push(L, b);
					num = (int)(num2 * 1391259724) ^ -1875225521;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	static Type _200B_202A_202B_206E_200D_206B_206E_206E_202B_202D_202C_202D_200C_202C_206D_206F_200E_202D_202B_206E_200E_206C_202D_206A_200B_206A_206F_206E_206A_202C_200E_206E_200E_206C_200E_206F_200F_200E_206A_206C_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static ParticleRenderer _206B_206A_202C_202D_202B_206A_202A_206E_202D_206D_202D_202E_200D_206F_206F_200E_200E_202A_200D_206F_202B_206E_206F_206F_202A_206B_200C_200C_202D_200C_200F_206D_206F_200D_206D_202D_200C_202E_200D_206B_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ParticleRenderer();
	}

	static bool _206B_206C_206A_206A_202B_202E_200D_200C_206E_206E_206A_202E_200F_206A_206E_200B_202B_202D_206A_206F_200F_206C_206A_200D_206B_202D_206E_200E_200E_206C_206D_202B_202D_200D_206C_206F_206A_206B_202E_202C_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static ParticleRenderMode _206B_200D_202E_202A_206D_200C_206A_202C_202D_200B_200C_206B_206D_206E_206E_202C_202D_202D_200B_206C_206D_206F_200C_200D_206B_206C_200E_202E_200F_200B_206E_206E_202C_202B_200B_206A_200F_206F_206A_200D_202E(ParticleRenderer P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.particleRenderMode;
	}

	static float _202E_206C_206D_206C_202C_206B_200D_206B_202C_200F_202B_202B_200D_206D_206C_206D_206A_200C_206F_206D_202C_206C_200C_202D_200D_200C_202C_206B_206F_200D_200F_202D_202A_206F_202D_206E_200F_200E_202E_206D_202E(ParticleRenderer P_0)
	{
		return P_0.lengthScale;
	}

	static float _202D_206D_200D_206B_202D_206F_206E_200C_202D_202D_202C_206F_206F_200F_206D_202A_200F_206A_202C_200C_206F_206C_200C_202C_206B_206A_200E_206C_206B_200F_200F_206A_202D_200C_200B_206D_206A_202B_200E_206F_202E(ParticleRenderer P_0)
	{
		return P_0.velocityScale;
	}

	static float _202E_206A_206A_202E_206A_202A_202D_200B_206C_200D_202B_206F_200D_200E_206C_206E_200E_206B_202E_202E_206D_206C_206F_206F_202B_200D_206D_206F_202E_200E_200F_206C_200D_206F_206B_206B_202B_200B_206E_200F_202E(ParticleRenderer P_0)
	{
		return P_0.cameraVelocityScale;
	}

	static float _200E_206A_200C_206D_200D_206D_200E_202C_206D_200F_200D_206E_206B_206B_202A_206C_206D_206A_200E_200E_200E_202E_206A_200C_200D_200F_206D_206B_206D_200B_200E_202E_206C_206D_200E_200D_200E_206B_200E_206E_202E(ParticleRenderer P_0)
	{
		return P_0.maxParticleSize;
	}

	static int _206D_202E_202D_206E_200B_200E_202A_206F_202C_200F_206F_206D_200C_200B_202E_202E_206D_202C_206E_206D_200D_200E_202D_206A_200F_206B_202A_206B_200C_202C_200D_206A_206D_202C_202C_206F_206B_206F_202C_206F_202E(ParticleRenderer P_0)
	{
		return P_0.uvAnimationXTile;
	}

	static int _200C_200D_200F_206F_202C_200C_200E_206A_206B_202B_206D_202A_200C_206A_206D_200B_202B_200F_206E_202D_206F_202A_206D_200D_200F_202D_206A_200C_206B_202B_202B_206D_206E_202C_200D_200F_200C_202B_200B_202B_202E(ParticleRenderer P_0)
	{
		return P_0.uvAnimationYTile;
	}

	static float _202A_206B_202A_206B_200B_200E_202A_202C_206A_200F_202E_202B_200C_200B_206E_202E_200F_202D_202E_200E_202D_206F_200E_200F_202C_200C_200C_206F_202E_200E_206D_200E_200C_200E_206A_206D_200F_202C_206F_206C_202E(ParticleRenderer P_0)
	{
		return P_0.uvAnimationCycles;
	}

	static float _206C_206F_200C_206D_200F_202E_206F_206B_206B_202B_206A_200D_206D_200E_206C_202E_206C_202C_206D_206F_202D_200E_202E_206A_200E_206A_206D_202B_206C_202A_206B_206B_202C_202A_202D_206B_200C_206C_202C_206A_202E(ParticleRenderer P_0)
	{
		return P_0.maxPartileSize;
	}

	static Rect[] _200F_200F_200E_200E_200B_200F_200D_206A_206D_202B_200C_202E_200B_200D_202E_206D_200F_200E_200B_202A_206E_202A_206C_202B_206C_206B_206D_202E_206F_206F_200B_200C_206D_206F_206C_206D_200B_206E_206A_200F_202E(ParticleRenderer P_0)
	{
		return P_0.uvTiles;
	}

	static void _202C_202B_200F_206D_200C_206D_200F_200F_200D_206E_206C_202B_206D_202A_200B_200F_200D_206F_202C_206C_200D_202E_202A_202C_200E_202A_200E_206D_202C_202B_206B_206E_206A_200C_206F_206C_202E_206F_206B_206B_202E(ParticleRenderer P_0, ParticleRenderMode P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.particleRenderMode = P_1;
	}

	static void _200F_202C_202E_206B_202A_202D_200E_206C_202C_200B_206C_202C_200E_200D_202A_202A_202D_200D_200D_202D_206B_202E_200C_202B_200F_200D_206A_202B_200F_200F_202E_202C_200B_202B_200C_200E_202C_206F_202C_206A_202E(ParticleRenderer P_0, float P_1)
	{
		P_0.lengthScale = P_1;
	}

	static void _206D_200D_206B_202D_206C_206C_206C_202A_202B_200E_202D_200C_200D_200F_200E_206D_200F_200D_202B_206D_206F_206E_200F_202E_200C_206D_206E_206F_202B_202D_200B_206A_200C_206A_202C_206A_200D_202E_206D_200E_202E(ParticleRenderer P_0, float P_1)
	{
		P_0.velocityScale = P_1;
	}

	static void _206E_206A_200B_200D_200F_206F_206D_200D_206C_202C_200E_206C_200D_202C_200D_206D_206D_206D_202D_206F_206A_200D_206D_200D_200F_200E_206D_202E_206F_206F_206A_206F_200D_202D_206E_202C_202A_202B_200B_202C_202E(ParticleRenderer P_0, float P_1)
	{
		P_0.cameraVelocityScale = P_1;
	}

	static void _206F_200F_206E_202B_200D_206B_202D_206E_200F_202A_202D_200B_202A_202C_200B_200F_200E_206B_200B_206F_206E_206B_206F_202D_200E_206B_200C_206D_206B_202D_202B_206E_206C_206C_202B_202E_200B_200E_206E_202D_202E(ParticleRenderer P_0, float P_1)
	{
		P_0.maxParticleSize = P_1;
	}

	static void _200F_202A_206C_206B_206C_206D_206C_200C_202E_206D_206D_202B_202A_200B_202B_206C_206B_200D_200E_202E_206D_206D_202E_202B_200E_202E_202B_206F_206D_206E_202B_202A_206A_200C_206E_202A_206A_206C_206C_202E(ParticleRenderer P_0, int P_1)
	{
		P_0.uvAnimationXTile = P_1;
	}

	static void _202E_202B_206D_206F_206D_206F_206F_200E_202D_202D_206B_202C_202C_202B_206F_202B_202E_206E_200C_206E_200E_200C_200F_202C_200C_206B_202D_206C_200F_202E_202A_206B_206C_206D_202C_200D_206F_206C_206D_206C_202E(ParticleRenderer P_0, int P_1)
	{
		P_0.uvAnimationYTile = P_1;
	}

	static void _200F_202D_200F_202E_200E_206F_206F_202E_206F_200C_206B_202C_202D_202C_206C_202C_200E_206D_200B_202B_200B_206F_206A_206B_202D_200F_200D_202E_200E_206F_202E_200E_206F_200E_200D_200E_202E_200B_200E_202E_202E(ParticleRenderer P_0, float P_1)
	{
		P_0.uvAnimationCycles = P_1;
	}

	static void _200F_206C_200C_200D_202C_202C_202E_200E_206D_202A_200F_200E_200F_202A_202B_200F_206B_200F_200E_200F_200C_206C_206F_206D_206C_206D_206C_200D_202B_202C_200B_202A_202A_200B_200C_206C_202E_206F_202C_200C_202E(ParticleRenderer P_0, float P_1)
	{
		P_0.maxPartileSize = P_1;
	}

	static void _206C_200D_206F_200D_200E_200E_206A_202C_206E_200E_202A_206C_206F_200F_202A_202E_206E_200C_200E_202B_200B_200F_200D_200B_200B_200B_200E_200F_206A_200E_202C_206B_206D_206D_202A_200B_200D_206C_202C_206A_202E(ParticleRenderer P_0, Rect[] P_1)
	{
		P_0.uvTiles = P_1;
	}
}
