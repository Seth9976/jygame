using System;
using System.Collections;
using LuaInterface;
using UnityEngine;

public class AnimationWrap
{
	private static Type classType = _202E_206E_206E_200B_200F_200B_206D_202A_206F_206F_202D_202C_206B_200E_200C_202C_200F_200B_200D_202D_206A_202D_206E_202A_200F_202E_206D_206F_206A_202C_206F_202D_206C_200D_200F_206F_202A_200E_206C_206E_202E(typeof(Animation).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[19]
		{
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(534828820u), Stop),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1445530274u), Rewind),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(857169727u), Sample),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3590867853u), IsPlaying),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(29660475u), get_Item),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(604550717u), Play),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(416180790u), CrossFade),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(712070387u), Blend),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(610873986u), CrossFadeQueued),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2919023761u), PlayQueued),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3113716957u), AddClip),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3180070345u), RemoveClip),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3749399090u), GetClipCount),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2138719595u), SyncLayer),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(622590970u), GetEnumerator),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2091733662u), GetClip),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2254933974u), _200F_200B_206B_200C_202E_206C_206E_202C_202A_200D_206B_202A_200E_200C_206B_202D_202B_200B_206F_206A_200E_206F_206D_202C_206D_202E_202C_202D_206A_206E_200E_206C_206C_200F_200C_200F_206C_200E_200B_202A_202E),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(10103728u), GetClassType),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(396454614u), Lua_Eq)
		};
		LuaField[] fields = new LuaField[7]
		{
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2571812562u), get_clip, set_clip),
			new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(233204578u), get_playAutomatically, set_playAutomatically),
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4178903076u), get_wrapMode, set_wrapMode),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1914131497u), get_isPlaying, null),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(400700429u), get_animatePhysics, set_animatePhysics),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2318146620u), get_cullingType, set_cullingType),
			new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3552697205u), get_localBounds, set_localBounds)
		};
		LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(978556457u), _202E_206E_206E_200B_200F_200B_206D_202A_206F_206F_202D_202C_206B_200E_200C_202C_200F_200B_200D_202D_206A_202D_206E_202A_200F_202E_206D_206F_206A_202C_206F_202D_206C_200D_200F_206F_202A_200E_206C_206E_202E(typeof(Animation).TypeHandle), regs, fields, _202E_206E_206E_200B_200F_200B_206D_202A_206F_206F_202D_202C_206B_200E_200C_202C_200F_200B_200D_202D_206A_202D_206E_202A_200F_202E_206D_206F_206A_202C_206F_202D_206C_200D_200F_206F_202A_200E_206C_206E_202E(typeof(Behaviour).TypeHandle));
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _200F_200B_206B_200C_202E_206C_206E_202C_202A_200D_206B_202A_200E_200C_206B_202D_202B_200B_206F_206A_200E_206F_206D_202C_206D_202E_202C_202D_206A_206E_200E_206C_206C_200F_200C_200F_206C_200E_200B_202A_202E(IntPtr P_0)
	{
		int num = LuaDLL.lua_gettop(P_0);
		while (true)
		{
			int num2 = -133466481;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1855934752)) % 5)
				{
				case 3u:
					break;
				case 4u:
				{
					int num4;
					int num5;
					if (num != 0)
					{
						num4 = 1200979230;
						num5 = num4;
					}
					else
					{
						num4 = 1688643723;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 750554531);
					continue;
				}
				case 1u:
				{
					Animation obj = _200E_202E_202D_202C_202C_202B_200C_202E_202D_206D_202D_202A_200D_206E_202C_200F_202A_206C_202E_206D_200C_202B_202C_206E_206F_200D_206D_202E_200C_206D_206D_206B_202B_200D_200B_202C_202E_200D_206A_200F_202E();
					LuaScriptMgr.Push(P_0, (Object)(object)obj);
					return 1;
				}
				case 0u:
					LuaDLL.luaL_error(P_0, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2159457405u));
					num2 = -648747474;
					continue;
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
	private static int get_clip(IntPtr L)
	{
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Animation val = default(Animation);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -896752942;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1161982005)) % 10)
				{
				case 6u:
					break;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(829138815u));
					num = -1256177268;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (_206E_206C_202A_206B_202D_200F_206E_202A_206C_200F_202C_200B_200C_200F_206A_202A_206F_202D_206C_206E_200C_202E_200E_206E_206D_202B_200C_202D_202E_202C_200B_206A_206E_202D_202C_206B_200B_202B_200E_206B_202E((Object)(object)val, (Object)null))
					{
						num5 = 1707367562;
						num6 = num5;
					}
					else
					{
						num5 = 1692148928;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -161727670);
					continue;
				}
				case 0u:
					num = (int)(num2 * 1522751153) ^ -941408382;
					continue;
				case 7u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -424552981) ^ -565637512;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 228947131;
						num4 = num3;
					}
					else
					{
						num3 = 847390376;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -604104998);
					continue;
				}
				case 1u:
					val = (Animation)luaObject;
					num = (int)((num2 * 319786172) ^ 0x6E8976B9);
					continue;
				case 9u:
					LuaScriptMgr.Push(L, (Object)(object)_200D_206B_206E_200E_206C_200C_202D_206E_202D_206D_200E_200F_206D_202C_202B_206A_202D_200E_200F_206D_202C_206E_200F_202A_206B_200F_200E_206B_206E_202B_206D_206F_200E_202C_206F_202D_202A_206F_206D_202A_202E(val));
					num = -343978660;
					continue;
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(864889178u));
					num = (int)(num2 * 364093358) ^ -923786091;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_playAutomatically(IntPtr L)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Animation val = default(Animation);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -510557808;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -258944973)) % 9)
				{
				case 0u:
					break;
				case 7u:
					val = (Animation)luaObject;
					num = ((int)num2 * -208379050) ^ -10521186;
					continue;
				case 4u:
					LuaScriptMgr.Push(L, _206B_206A_206A_206C_202C_200E_200B_200C_200E_200B_206C_202B_200F_206C_206B_202D_200D_206A_206B_200F_206C_206A_200C_200C_200D_202B_206D_200E_206C_206B_202C_200B_202A_206B_202A_206A_202C_200B_202E_200F_202E(val));
					num = -1757450168;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2879138200u));
					num = ((int)num2 * -972944253) ^ -1609803438;
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -1433825852;
						num6 = num5;
					}
					else
					{
						num5 = -951103786;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1694911108);
					continue;
				}
				case 2u:
				{
					int num3;
					int num4;
					if (!_206E_206C_202A_206B_202D_200F_206E_202A_206C_200F_202C_200B_200C_200F_206A_202A_206F_202D_206C_206E_200C_202E_200E_206E_206D_202B_200C_202D_202E_202C_200B_206A_206E_202D_202C_206B_200B_202B_200E_206B_202E((Object)(object)val, (Object)null))
					{
						num3 = -1246845207;
						num4 = num3;
					}
					else
					{
						num3 = -1411578518;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -870556552);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4177471306u));
					num = -700236063;
					continue;
				case 8u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 270976022) ^ -660001000;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_wrapMode(IntPtr L)
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Animation val = default(Animation);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1381243958;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x69A56147)) % 10)
				{
				case 9u:
					break;
				case 7u:
					LuaScriptMgr.Push(L, (Enum)(object)_200C_206F_202A_202B_202A_200C_202E_202E_206E_200C_202B_200F_202C_206C_206A_206C_202A_202A_206A_202A_202C_202A_206F_206D_202E_200B_206E_206C_206E_200F_200B_206F_200D_200F_200F_206D_206F_202A_206F_200F_202E(val));
					num = 711395673;
					continue;
				case 2u:
					num = (int)((num2 * 1942835290) ^ 0x532ED7E);
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (_206E_206C_202A_206B_202D_200F_206E_202A_206C_200F_202C_200B_200C_200F_206A_202A_206F_202D_206C_206E_200C_202E_200E_206E_206D_202B_200C_202D_202E_202C_200B_206A_206E_202D_202C_206B_200B_202B_200E_206B_202E((Object)(object)val, (Object)null))
					{
						num5 = -1990756717;
						num6 = num5;
					}
					else
					{
						num5 = -872656448;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1226571306);
					continue;
				}
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2143406057u));
					num = ((int)num2 * -1402477101) ^ -817734470;
					continue;
				case 3u:
					val = (Animation)luaObject;
					num = ((int)num2 * -692644107) ^ 0x5670047D;
					continue;
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -120217014) ^ 0x2BFE4599;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -1258885169;
						num4 = num3;
					}
					else
					{
						num3 = -460852468;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1714557412);
					continue;
				}
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(621760715u));
					num = 606294742;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_isPlaying(IntPtr L)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Animation val = default(Animation);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 198948426;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x762A125F)) % 9)
				{
				case 6u:
					break;
				case 5u:
					val = (Animation)luaObject;
					num = ((int)num2 * -80406712) ^ -11202107;
					continue;
				case 0u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -374552915;
						num6 = num5;
					}
					else
					{
						num5 = -1187637729;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1882286186);
					continue;
				}
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1198891583u));
					num = 61336957;
					continue;
				case 3u:
					num = ((int)num2 * -1243347392) ^ -1025367299;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3581293848u));
					num = ((int)num2 * -1932940295) ^ -116829021;
					continue;
				case 2u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -2089456599) ^ 0x79DDBB62;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!_206E_206C_202A_206B_202D_200F_206E_202A_206C_200F_202C_200B_200C_200F_206A_202A_206F_202D_206C_206E_200C_202E_200E_206E_206D_202B_200C_202D_202E_202C_200B_206A_206E_202D_202C_206B_200B_202B_200E_206B_202E((Object)(object)val, (Object)null))
					{
						num3 = 1957664765;
						num4 = num3;
					}
					else
					{
						num3 = 145027695;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 273729344);
					continue;
				}
				default:
					LuaScriptMgr.Push(L, _202B_200F_202A_200D_202A_206F_202A_202D_202A_206B_200B_200F_206E_202E_206D_206B_200C_200C_206D_206A_206B_206D_206B_206D_200B_202D_206A_206C_200B_206B_206A_206A_206E_206E_206F_206E_206F_202C_202B_202E_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_animatePhysics(IntPtr L)
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		Animation val = default(Animation);
		while (true)
		{
			int num = 247073299;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2FBCD9CB)) % 9)
				{
				case 6u:
					break;
				case 7u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -1879275267;
						num6 = num5;
					}
					else
					{
						num5 = -570644406;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1792331599);
					continue;
				}
				case 2u:
				{
					int num3;
					int num4;
					if (!_206E_206C_202A_206B_202D_200F_206E_202A_206C_200F_202C_200B_200C_200F_206A_202A_206F_202D_206C_206E_200C_202E_200E_206E_206D_202B_200C_202D_202E_202C_200B_206A_206E_202D_202C_206B_200B_202B_200E_206B_202E((Object)(object)val, (Object)null))
					{
						num3 = 2046203373;
						num4 = num3;
					}
					else
					{
						num3 = 1002337206;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -446442359);
					continue;
				}
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(153219427u));
					num = 943700063;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(176112331u));
					num = ((int)num2 * -1375623043) ^ -2051373520;
					continue;
				case 5u:
					num = ((int)num2 * -1989793198) ^ 0x4E0E4BC1;
					continue;
				case 1u:
					val = (Animation)luaObject;
					num = ((int)num2 * -1999949837) ^ 0x1121061;
					continue;
				case 3u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 1512094470) ^ 0x43C52FA2);
					continue;
				default:
					LuaScriptMgr.Push(L, _202E_206E_206A_202A_200B_202E_206A_206B_206D_202C_200F_200D_200B_202E_206D_206E_202C_202E_200C_206D_206B_202E_202B_202E_202C_206A_200C_202C_206B_206F_200C_206F_206E_200C_206F_200C_200D_206C_202C_206F_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_cullingType(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Animation val = (Animation)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1599690288;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x90687A1)) % 9)
				{
				case 0u:
					break;
				case 7u:
					num = (int)(num2 * 225963356) ^ -1223629168;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1472390225u));
					num = ((int)num2 * -2116601150) ^ 0x19698ECA;
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -683472208;
						num6 = num5;
					}
					else
					{
						num5 = -338179616;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1514796112);
					continue;
				}
				case 1u:
					LuaScriptMgr.Push(L, (Enum)(object)_206B_200D_200F_202B_206F_202B_206A_200F_202D_200F_202E_200F_202D_206B_206C_202E_200E_202B_206F_202A_206A_200C_200D_200C_206F_202A_202A_202E_202A_200C_206F_202C_200D_202B_200C_202C_200C_200E_206C_200C_202E(val));
					num = 726636469;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(488614465u));
					num = 103221548;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (_206E_206C_202A_206B_202D_200F_206E_202A_206C_200F_202C_200B_200C_200F_206A_202A_206F_202D_206C_206E_200C_202E_200E_206E_206D_202B_200C_202D_202E_202C_200B_206A_206E_202D_202C_206B_200B_202B_200E_206B_202E((Object)(object)val, (Object)null))
					{
						num3 = -1801583982;
						num4 = num3;
					}
					else
					{
						num3 = -1778197422;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 494640798);
					continue;
				}
				case 5u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1639539860) ^ -1427895467;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_localBounds(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Animation val = (Animation)luaObject;
		while (true)
		{
			int num = 427549610;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x40B98AC6)) % 8)
				{
				case 3u:
					break;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2268223642u));
					num = ((int)num2 * -300749165) ^ 0x5C93CA69;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(906472586u));
					num = 1983776107;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (_206E_206C_202A_206B_202D_200F_206E_202A_206C_200F_202C_200B_200C_200F_206A_202A_206F_202D_206C_206E_200C_202E_200E_206E_206D_202B_200C_202D_202E_202C_200B_206A_206E_202D_202C_206B_200B_202B_200E_206B_202E((Object)(object)val, (Object)null))
					{
						num5 = 1843115609;
						num6 = num5;
					}
					else
					{
						num5 = 2138788587;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1993811872);
					continue;
				}
				case 5u:
					LuaScriptMgr.Push(L, _206B_200D_206C_206E_202B_200B_200C_200F_202B_200B_200C_202C_200B_202A_206A_206A_206C_200E_206C_200D_202A_200E_206E_202A_200E_206C_200C_200B_200B_206D_202C_206B_202A_202E_202E_200F_206D_206F_206A_206C_202E(val));
					num = 577447352;
					continue;
				case 7u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -1707977005;
						num4 = num3;
					}
					else
					{
						num3 = -154378351;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1755599393);
					continue;
				}
				case 1u:
					num = (int)((num2 * 1326500953) ^ 0x78D204A2);
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_clip(IntPtr L)
	{
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		Animation val = default(Animation);
		while (true)
		{
			int num = 843673353;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x352533F9)) % 9)
				{
				case 0u:
					break;
				case 5u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1207885417) ^ 0x5E26C299;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (!_206E_206C_202A_206B_202D_200F_206E_202A_206C_200F_202C_200B_200C_200F_206A_202A_206F_202D_206C_206E_200C_202E_200E_206E_206D_202B_200C_202D_202E_202C_200B_206A_206E_202D_202C_206B_200B_202B_200E_206B_202E((Object)(object)val, (Object)null))
					{
						num5 = -2010527661;
						num6 = num5;
					}
					else
					{
						num5 = -2055010366;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1905128524);
					continue;
				}
				case 3u:
					val = (Animation)luaObject;
					num = (int)(num2 * 1868941434) ^ -847548537;
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -1245709729;
						num4 = num3;
					}
					else
					{
						num3 = -562307274;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1416435985);
					continue;
				}
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3336578730u));
					num = 595926859;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2700189840u));
					num = (int)(num2 * 1309416226) ^ -1497730443;
					continue;
				case 4u:
					num = (int)(num2 * 1227705993) ^ -1572622383;
					continue;
				default:
					_206E_200D_206B_202A_206D_206B_206D_200F_200F_202D_206D_202E_206E_202D_206E_206C_200C_202A_200F_206D_206B_200D_206E_206A_206F_202B_206D_200F_202B_202C_202D_206D_200F_200E_206D_206D_202E_206F_206E_202E_202E(val, (AnimationClip)LuaScriptMgr.GetUnityObject(L, 3, _202E_206E_206E_200B_200F_200B_206D_202A_206F_206F_202D_202C_206B_200E_200C_202C_200F_200B_200D_202D_206A_202D_206E_202A_200F_202E_206D_206F_206A_202C_206F_202D_206C_200D_200F_206F_202A_200E_206C_206E_202E(typeof(AnimationClip).TypeHandle)));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_playAutomatically(IntPtr L)
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		Animation val = default(Animation);
		while (true)
		{
			int num = 517526072;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4E5228A0)) % 9)
				{
				case 3u:
					break;
				case 0u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 1977472111;
						num6 = num5;
					}
					else
					{
						num5 = 1567546972;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1090465576);
					continue;
				}
				case 8u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 755651031) ^ -1288525965;
					continue;
				case 2u:
				{
					val = (Animation)luaObject;
					int num3;
					int num4;
					if (_206E_206C_202A_206B_202D_200F_206E_202A_206C_200F_202C_200B_200C_200F_206A_202A_206F_202D_206C_206E_200C_202E_200E_206E_206D_202B_200C_202D_202E_202C_200B_206A_206E_202D_202C_206B_200B_202B_200E_206B_202E((Object)(object)val, (Object)null))
					{
						num3 = 1535137416;
						num4 = num3;
					}
					else
					{
						num3 = 300832377;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -2048752845);
					continue;
				}
				case 4u:
					num = ((int)num2 * -1659404371) ^ -1895542771;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2691584841u));
					num = (int)((num2 * 2099645337) ^ 0x38FCADD3);
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1311185632u));
					num = 1307959857;
					continue;
				case 1u:
					_206A_200B_206C_206F_202A_206C_202D_200B_200C_200D_200C_206E_206E_202C_206E_202D_202A_202C_200F_200C_202B_202C_206A_202E_200E_206B_200B_206A_202D_202B_202B_202D_200E_206C_202D_200C_206E_206E_206C_206D_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					num = 211202386;
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
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Animation val = (Animation)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 242139145;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x69B92F7E)) % 9)
				{
				case 0u:
					break;
				case 4u:
					_206E_206E_200B_202C_202C_200F_202B_200D_200C_202C_200B_200F_206F_200D_200D_206D_206F_202A_202B_202B_202B_206D_206F_206D_200D_200F_206F_202D_206C_206C_206C_200C_206D_206A_200F_202D_202E_200E_206C_206D_202E(val, (WrapMode)(int)LuaScriptMgr.GetNetObject(L, 3, _202E_206E_206E_200B_200F_200B_206D_202A_206F_206F_202D_202C_206B_200E_200C_202C_200F_200B_200D_202D_206A_202D_206E_202A_200F_202E_206D_206F_206A_202C_206F_202D_206C_200D_200F_206F_202A_200E_206C_206E_202E(typeof(WrapMode).TypeHandle)));
					num = 806318028;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(621760715u));
					num = 81968929;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 732533849;
						num6 = num5;
					}
					else
					{
						num5 = 324494142;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1041012712);
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (_206E_206C_202A_206B_202D_200F_206E_202A_206C_200F_202C_200B_200C_200F_206A_202A_206F_202D_206C_206E_200C_202E_200E_206E_206D_202B_200C_202D_202E_202C_200B_206A_206E_202D_202C_206B_200B_202B_200E_206B_202E((Object)(object)val, (Object)null))
					{
						num3 = 517568189;
						num4 = num3;
					}
					else
					{
						num3 = 152507716;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -892337149);
					continue;
				}
				case 2u:
					num = (int)(num2 * 244059665) ^ -1456629025;
					continue;
				case 8u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 81303838) ^ 0x5A29642A);
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(131108899u));
					num = ((int)num2 * -384494210) ^ 0x30FE9552;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_animatePhysics(IntPtr L)
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Animation val = default(Animation);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1660298823;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6C3F2B76)) % 8)
				{
				case 7u:
					break;
				case 5u:
					num = ((int)num2 * -1515106204) ^ -1430881914;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(524007391u));
					num = (int)((num2 * 336981300) ^ 0x2EB6842B);
					continue;
				case 1u:
				{
					val = (Animation)luaObject;
					int num5;
					int num6;
					if (!_206E_206C_202A_206B_202D_200F_206E_202A_206C_200F_202C_200B_200C_200F_206A_202A_206F_202D_206C_206E_200C_202E_200E_206E_206D_202B_200C_202D_202E_202C_200B_206A_206E_202D_202C_206B_200B_202B_200E_206B_202E((Object)(object)val, (Object)null))
					{
						num5 = 1026612187;
						num6 = num5;
					}
					else
					{
						num5 = 1942723567;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1761133895);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1680824068u));
					num = 1118730674;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 1304106950;
						num4 = num3;
					}
					else
					{
						num3 = 271252722;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -647729730);
					continue;
				}
				case 0u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1297469151) ^ 0x6F9E8A8D;
					continue;
				default:
					_202B_206D_202E_200C_206A_202C_206B_206E_200D_200D_200C_206A_206F_206D_202A_200B_200E_200E_200F_200C_206F_200E_206D_202A_206F_200E_200D_202A_200C_206F_206B_206B_202A_202D_200D_202D_202A_206E_206F_200E_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_cullingType(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Animation val = (Animation)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -607154929;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -404605046)) % 8)
				{
				case 6u:
					break;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(488614465u));
					num = -1221311935;
					continue;
				case 1u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1168669956) ^ -916807006;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -2034213326;
						num6 = num5;
					}
					else
					{
						num5 = -850587832;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 301017524);
					continue;
				}
				case 5u:
				{
					int num3;
					int num4;
					if (_206E_206C_202A_206B_202D_200F_206E_202A_206C_200F_202C_200B_200C_200F_206A_202A_206F_202D_206C_206E_200C_202E_200E_206E_206D_202B_200C_202D_202E_202C_200B_206A_206E_202D_202C_206B_200B_202B_200E_206B_202E((Object)(object)val, (Object)null))
					{
						num3 = -866467694;
						num4 = num3;
					}
					else
					{
						num3 = -1797107584;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 71389709);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3228639031u));
					num = (int)((num2 * 540244533) ^ 0x30ECD509);
					continue;
				case 3u:
					_202B_206F_200E_200E_202C_200F_202C_206E_206C_206D_200C_202B_200F_200C_202C_202B_202B_202C_200E_200F_206F_200F_206A_200C_206B_202C_200E_206C_206A_206D_202C_200B_200B_206D_206D_206A_200C_200D_202C_206B_202E(val, (AnimationCullingType)(int)LuaScriptMgr.GetNetObject(L, 3, _202E_206E_206E_200B_200F_200B_206D_202A_206F_206F_202D_202C_206B_200E_200C_202C_200F_200B_200D_202D_206A_202D_206E_202A_200F_202E_206D_206F_206A_202C_206F_202D_206C_200D_200F_206F_202A_200E_206C_206E_202E(typeof(AnimationCullingType).TypeHandle)));
					num = -1228417307;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_localBounds(IntPtr L)
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		Animation val = default(Animation);
		while (true)
		{
			int num = 1318284824;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4408E774)) % 9)
				{
				case 2u:
					break;
				case 4u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -1692535137;
						num6 = num5;
					}
					else
					{
						num5 = -642414400;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1051358095);
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (_206E_206C_202A_206B_202D_200F_206E_202A_206C_200F_202C_200B_200C_200F_206A_202A_206F_202D_206C_206E_200C_202E_200E_206E_206D_202B_200C_202D_202E_202C_200B_206A_206E_202D_202C_206B_200B_202B_200E_206B_202E((Object)(object)val, (Object)null))
					{
						num3 = -662208968;
						num4 = num3;
					}
					else
					{
						num3 = -1341457459;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1300912527);
					continue;
				}
				case 5u:
					val = (Animation)luaObject;
					num = ((int)num2 * -1305224265) ^ 0x72332CB0;
					continue;
				case 3u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -774738021) ^ 0x6D439C0B;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(906472586u));
					num = 5029693;
					continue;
				case 8u:
					num = (int)((num2 * 576444213) ^ 0x636E8C35);
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1192763756u));
					num = (int)(num2 * 1244117072) ^ -1390501940;
					continue;
				default:
					_206E_200F_200E_202C_206C_206A_206C_206E_206F_202D_200C_206A_200E_206C_202A_202D_202C_200D_200D_202D_206F_200D_202D_202B_200E_200C_206A_200B_206D_202C_206B_206C_202D_200F_202C_200F_202B_202B_202C_206D_202E(val, LuaScriptMgr.GetBounds(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Stop(IntPtr L)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		if (num == 1)
		{
			goto IL_000e;
		}
		goto IL_00ef;
		IL_000e:
		int num2 = 1192642396;
		goto IL_0013;
		IL_0013:
		Animation val = default(Animation);
		Animation val2 = default(Animation);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ 0x62AA7943)) % 8)
			{
			case 3u:
				break;
			case 6u:
				val = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3355522354u));
				num2 = (int)(num3 * 386369985) ^ -2036548780;
				continue;
			case 2u:
				_206F_206D_206A_200C_202D_200E_200B_200B_200F_200B_200C_202E_200E_206F_206D_206B_206D_206A_206A_202A_206E_206A_200E_206F_206D_206B_206C_202D_206C_206C_200F_200E_206F_200E_200F_202A_202B_200E_202E_202B_202E(val2);
				return 0;
			case 7u:
				val2 = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1153888151u));
				num2 = (int)(num3 * 1545538996) ^ -526410243;
				continue;
			case 1u:
			{
				string luaString = LuaScriptMgr.GetLuaString(L, 2);
				_200E_206E_200B_206C_200D_206F_206B_200E_202D_206C_202B_206F_200F_206F_202C_200E_202B_200E_206C_200E_200D_200F_202D_206E_202C_200E_206F_202C_200C_202E_202C_206B_200B_200B_202A_202D_200D_202D_206C_202B_202E(val, luaString);
				return 0;
			}
			case 0u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1804282510u));
				num2 = 676423118;
				continue;
			case 4u:
				goto IL_00ef;
			default:
				return 0;
			}
			break;
		}
		goto IL_000e;
		IL_00ef:
		int num4;
		if (num == 2)
		{
			num2 = 1508005421;
			num4 = num2;
		}
		else
		{
			num2 = 1955313691;
			num4 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Rewind(IntPtr L)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		Animation val = default(Animation);
		string luaString = default(string);
		while (true)
		{
			int num2 = -812173542;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -2114193580)) % 9)
				{
				case 7u:
					break;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2973523938u));
					num2 = -419041430;
					continue;
				case 3u:
					return 0;
				case 2u:
					_206A_206D_202A_200E_206D_206B_206D_202D_200F_202A_206C_206D_202A_200D_206C_202E_202C_206A_202A_206F_206B_200D_200B_200E_202C_206C_206F_206F_202A_206A_206E_200E_200F_202E_202B_200E_206E_206D_202E_202E_202E(val, luaString);
					num2 = (int)((num3 * 1337964140) ^ 0x2A3A4624);
					continue;
				case 1u:
					val = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(22945093u));
					luaString = LuaScriptMgr.GetLuaString(L, 2);
					num2 = (int)((num3 * 583298510) ^ 0x757832CA);
					continue;
				case 8u:
				{
					Animation val2 = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1153888151u));
					_206D_206A_206D_206E_200C_202C_202A_202D_202D_202E_200E_206D_202C_206E_202C_206E_206B_200C_202D_206F_202B_206C_200D_200E_202B_200F_206B_200D_202E_202B_206B_202E_202D_202D_202E_202C_206B_202C_200B_206B_202E(val2);
					return 0;
				}
				case 5u:
				{
					int num6;
					if (num != 2)
					{
						num2 = -1773627027;
						num6 = num2;
					}
					else
					{
						num2 = -1396335333;
						num6 = num2;
					}
					continue;
				}
				case 6u:
				{
					int num4;
					int num5;
					if (num == 1)
					{
						num4 = 2032805062;
						num5 = num4;
					}
					else
					{
						num4 = 1258742263;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 957618336);
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
	private static int Sample(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 1);
		Animation val = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2592956898u));
		while (true)
		{
			int num = -646151352;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -450392407)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0040;
				default:
					return 0;
				}
				break;
				IL_0040:
				_202B_206A_202A_200F_202C_200E_206E_202D_200C_202C_202A_202C_202E_206D_206D_202C_206F_206C_200D_206E_200E_200B_206F_200D_200E_200C_202C_206B_200E_202C_200C_202E_200C_200C_206F_200E_202B_206D_206F_206E_202E(val);
				num = (int)((num2 * 200252210) ^ 0x4A65AEC5);
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int IsPlaying(IntPtr L)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		while (true)
		{
			int num = 2065874565;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1A38A612)) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_0029;
				default:
					return 1;
				}
				break;
				IL_0029:
				Animation val = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2592956898u));
				string luaString = LuaScriptMgr.GetLuaString(L, 2);
				bool b = _206C_206C_202A_200F_200D_206C_200E_206F_206F_202B_200C_202A_206D_200B_206E_200F_200E_200B_206B_200E_206E_200F_202D_202B_206E_200C_200C_206E_202D_200F_206E_202A_200E_206B_200F_206E_202C_200D_200D_206D_202E(val, luaString);
				LuaScriptMgr.Push(L, b);
				num = ((int)num2 * -1893532146) ^ -1360663682;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_Item(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		Animation val = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2592956898u));
		string luaString = default(string);
		AnimationState obj = default(AnimationState);
		while (true)
		{
			int num = 601691783;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x19298B5E)) % 4)
				{
				case 3u:
					break;
				case 1u:
					luaString = LuaScriptMgr.GetLuaString(L, 2);
					num = (int)(num2 * 1876143569) ^ -818557213;
					continue;
				case 0u:
					obj = _202D_202A_200B_206E_206B_206F_202A_206F_206C_202C_206A_206A_202B_200E_206C_200E_202B_202D_206E_200E_202B_206A_200E_206C_206D_200E_202A_200B_206C_206E_206B_202C_206B_200E_206A_202E_206B_200F_202C_200D_202E(val, luaString);
					num = ((int)num2 * -1938529721) ^ 0x4DE94288;
					continue;
				default:
					LuaScriptMgr.Push(L, (TrackedReference)(object)obj);
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Play(IntPtr L)
	{
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		bool b2 = default(bool);
		PlayMode val3 = default(PlayMode);
		Animation val6 = default(Animation);
		string luaString = default(string);
		Animation val = default(Animation);
		PlayMode val2 = default(PlayMode);
		bool b = default(bool);
		Animation val4 = default(Animation);
		string text = default(string);
		Animation val5 = default(Animation);
		while (true)
		{
			int num2 = -2063424748;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1058446440)) % 22)
				{
				case 10u:
					break;
				case 12u:
					LuaScriptMgr.Push(L, b2);
					num2 = (int)((num3 * 491428767) ^ 0x128A543);
					continue;
				case 14u:
					val3 = (PlayMode)(int)LuaScriptMgr.GetNetObject(L, 3, _202E_206E_206E_200B_200F_200B_206D_202A_206F_206F_202D_202C_206B_200E_200C_202C_200F_200B_200D_202D_206A_202D_206E_202A_200F_202E_206D_206F_206A_202C_206F_202D_206C_200D_200F_206F_202A_200E_206C_206E_202E(typeof(PlayMode).TypeHandle));
					num2 = ((int)num3 * -493181742) ^ 0x3246A83A;
					continue;
				case 6u:
					b2 = _200F_202C_200D_206C_202C_202B_202A_202D_202E_200D_206D_206C_202E_202E_200F_206F_206F_200C_202C_202A_200E_202A_206D_206D_200C_206C_202D_206F_202B_202E_202B_200C_202E_206E_206A_206E_206D_200B_206E_200E_202E(val6, luaString, val3);
					num2 = ((int)num3 * -2044260359) ^ 0xAA5CA2;
					continue;
				case 9u:
					val = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2592956898u));
					val2 = (PlayMode)(int)LuaScriptMgr.GetLuaObject(L, 2);
					num2 = (int)((num3 * 355830807) ^ 0x5E435AAB);
					continue;
				case 2u:
					LuaScriptMgr.Push(L, b);
					num2 = ((int)num3 * -1762208810) ^ -564680869;
					continue;
				case 19u:
					val6 = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2592956898u));
					luaString = LuaScriptMgr.GetLuaString(L, 2);
					num2 = ((int)num3 * -429516858) ^ -1017291626;
					continue;
				case 8u:
				{
					int num9;
					int num10;
					if (num != 1)
					{
						num9 = -98477093;
						num10 = num9;
					}
					else
					{
						num9 = -1250396261;
						num10 = num9;
					}
					num2 = num9 ^ (int)(num3 * 1790788405);
					continue;
				}
				case 7u:
				{
					int num6;
					if (num == 3)
					{
						num2 = -25979301;
						num6 = num2;
					}
					else
					{
						num2 = -943012004;
						num6 = num2;
					}
					continue;
				}
				case 15u:
					return 1;
				case 0u:
					return 1;
				case 18u:
				{
					int num12;
					if (num != 2)
					{
						num2 = -1180682509;
						num12 = num2;
					}
					else
					{
						num2 = -1651143193;
						num12 = num2;
					}
					continue;
				}
				case 20u:
				{
					bool b4 = _202E_200B_206F_202A_206B_206C_200E_206B_206E_206A_200E_200D_206F_202C_200C_202C_200F_202C_200D_206B_200B_202D_202B_206F_206D_202C_200B_202A_202E_206B_202A_200D_206C_206F_202E_202B_206E_206F_200F_202A_202E(val4, text);
					LuaScriptMgr.Push(L, b4);
					return 1;
				}
				case 1u:
				{
					bool b3 = _206F_202A_202D_206A_202B_206F_200B_202D_202B_206A_206F_202E_206A_202C_200D_202A_206E_206A_200E_206A_200F_202E_202C_202C_200C_206A_206F_202D_200D_206E_202A_200B_202D_206C_200D_200C_202D_200D_206D_202E_202E(val5);
					LuaScriptMgr.Push(L, b3);
					num2 = (int)(num3 * 1781963195) ^ -1422554901;
					continue;
				}
				case 11u:
					val5 = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1951077219u));
					num2 = (int)((num3 * 1044572384) ^ 0x4E7EFB5);
					continue;
				case 16u:
					b = _206F_202A_200F_200C_200C_202B_206E_200E_200E_206E_200F_200B_206E_206D_206B_200B_206F_202C_200D_200D_206B_206C_200B_200C_206A_200B_206A_200B_200B_202E_206F_200B_206C_202E_200C_206C_206D_200F_206C_206B_202E(val, val2);
					num2 = (int)(num3 * 571366812) ^ -540053660;
					continue;
				case 5u:
					val4 = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(22945093u));
					text = LuaScriptMgr.GetString(L, 2);
					num2 = ((int)num3 * -148957096) ^ -369288354;
					continue;
				case 3u:
				{
					int num11;
					if (num == 2)
					{
						num2 = -464228825;
						num11 = num2;
					}
					else
					{
						num2 = -983308456;
						num11 = num2;
					}
					continue;
				}
				case 13u:
				{
					int num7;
					int num8;
					if (!LuaScriptMgr.CheckTypes(L, 1, _202E_206E_206E_200B_200F_200B_206D_202A_206F_206F_202D_202C_206B_200E_200C_202C_200F_200B_200D_202D_206A_202D_206E_202A_200F_202E_206D_206F_206A_202C_206F_202D_206C_200D_200F_206F_202A_200E_206C_206E_202E(typeof(Animation).TypeHandle), _202E_206E_206E_200B_200F_200B_206D_202A_206F_206F_202D_202C_206B_200E_200C_202C_200F_200B_200D_202D_206A_202D_206E_202A_200F_202E_206D_206F_206A_202C_206F_202D_206C_200D_200F_206F_202A_200E_206C_206E_202E(typeof(PlayMode).TypeHandle)))
					{
						num7 = -2066800585;
						num8 = num7;
					}
					else
					{
						num7 = -941398633;
						num8 = num7;
					}
					num2 = num7 ^ (int)(num3 * 1852985148);
					continue;
				}
				case 17u:
					return 1;
				case 21u:
				{
					int num4;
					int num5;
					if (LuaScriptMgr.CheckTypes(L, 1, _202E_206E_206E_200B_200F_200B_206D_202A_206F_206F_202D_202C_206B_200E_200C_202C_200F_200B_200D_202D_206A_202D_206E_202A_200F_202E_206D_206F_206A_202C_206F_202D_206C_200D_200F_206F_202A_200E_206C_206E_202E(typeof(Animation).TypeHandle), _202E_206E_206E_200B_200F_200B_206D_202A_206F_206F_202D_202C_206B_200E_200C_202C_200F_200B_200D_202D_206A_202D_206E_202A_200F_202E_206D_206F_206A_202C_206F_202D_206C_200D_200F_206F_202A_200E_206C_206E_202E(typeof(string).TypeHandle)))
					{
						num4 = -633106446;
						num5 = num4;
					}
					else
					{
						num4 = -536817593;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 1372253857);
					continue;
				}
				default:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1122672654u));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int CrossFade(IntPtr L)
	{
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		int num = LuaDLL.lua_gettop(L);
		if (num == 2)
		{
			goto IL_000e;
		}
		goto IL_00c7;
		IL_000e:
		int num2 = 1347919825;
		goto IL_0013;
		IL_0013:
		Animation val = default(Animation);
		string luaString2 = default(string);
		Animation val3 = default(Animation);
		float num4 = default(float);
		Animation val2 = default(Animation);
		string luaString3 = default(string);
		string luaString = default(string);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ 0x7B0F5A12)) % 12)
			{
			case 8u:
				break;
			case 10u:
			{
				float num5 = (float)LuaScriptMgr.GetNumber(L, 3);
				PlayMode val4 = (PlayMode)(int)LuaScriptMgr.GetNetObject(L, 4, _202E_206E_206E_200B_200F_200B_206D_202A_206F_206F_202D_202C_206B_200E_200C_202C_200F_200B_200D_202D_206A_202D_206E_202A_200F_202E_206D_206F_206A_202C_206F_202D_206C_200D_200F_206F_202A_200E_206C_206E_202E(typeof(PlayMode).TypeHandle));
				_206D_200D_202A_202E_202B_206F_206B_202B_202E_206C_206B_206B_202A_206F_202A_206B_202A_202B_206E_202E_202C_202D_206A_206C_200D_200E_200E_200F_206C_200E_202B_202A_200F_206F_206F_206F_206D_200D_206A_200F_202E(val, luaString2, num5, val4);
				return 0;
			}
			case 2u:
				val3 = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1951077219u));
				num2 = ((int)num3 * -85219969) ^ -1494460547;
				continue;
			case 11u:
				goto IL_00c7;
			case 5u:
				num4 = (float)LuaScriptMgr.GetNumber(L, 3);
				num2 = ((int)num3 * -1747435184) ^ 0x5BA982FD;
				continue;
			case 0u:
				goto IL_00fc;
			case 4u:
				_202A_206E_202E_200B_202A_202B_200D_200B_202A_206D_202A_202D_206B_200D_200D_202E_200F_200B_200C_206C_200B_200F_200D_206D_202B_200F_200B_202A_206F_200D_206E_200F_200F_200F_202A_200F_206D_200B_202B_206D_202E(val2, luaString3);
				return 0;
			case 3u:
				_202B_206A_206C_202A_200F_200C_206C_202C_206A_202D_200C_202C_202D_206D_206A_202B_206C_200E_206A_206D_206A_202D_200B_206A_206D_200D_202D_206A_206D_206B_200D_200B_202C_200C_206F_200E_206C_200E_202A_206F_202E(val3, luaString, num4);
				return 0;
			case 7u:
				val2 = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1951077219u));
				luaString3 = LuaScriptMgr.GetLuaString(L, 2);
				num2 = (int)(num3 * 1192525092) ^ -1708360030;
				continue;
			case 6u:
				val = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(22945093u));
				luaString2 = LuaScriptMgr.GetLuaString(L, 2);
				num2 = ((int)num3 * -756296453) ^ -151521446;
				continue;
			case 9u:
				luaString = LuaScriptMgr.GetLuaString(L, 2);
				num2 = (int)(num3 * 1750475726) ^ -1727927855;
				continue;
			default:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3710185586u));
				return 0;
			}
			break;
			IL_00fc:
			int num6;
			if (num == 4)
			{
				num2 = 284909360;
				num6 = num2;
			}
			else
			{
				num2 = 935571039;
				num6 = num2;
			}
		}
		goto IL_000e;
		IL_00c7:
		int num7;
		if (num == 3)
		{
			num2 = 1270616236;
			num7 = num2;
		}
		else
		{
			num2 = 1316290554;
			num7 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Blend(IntPtr L)
	{
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		Animation val3 = default(Animation);
		Animation val2 = default(Animation);
		string luaString2 = default(string);
		float num7 = default(float);
		float num8 = default(float);
		float num4 = default(float);
		string luaString3 = default(string);
		Animation val = default(Animation);
		string luaString = default(string);
		while (true)
		{
			int num2 = 71180095;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x44549D2A)) % 18)
				{
				case 11u:
					break;
				case 17u:
				{
					int num10;
					if (num != 3)
					{
						num2 = 1007073904;
						num10 = num2;
					}
					else
					{
						num2 = 1302423743;
						num10 = num2;
					}
					continue;
				}
				case 2u:
					val3 = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(22945093u));
					num2 = ((int)num3 * -538310548) ^ 0x5DDA89DB;
					continue;
				case 1u:
					_202E_206C_206C_202C_202B_202C_206D_206D_200C_202D_200D_200D_200D_200B_200D_200E_202E_202C_206D_206F_206D_202B_202D_200C_202B_200C_206F_206B_200B_206A_206A_206B_206C_202C_200E_200D_206B_206B_206F_200C_202E(val2, luaString2, num7, num8);
					num2 = (int)((num3 * 1611698555) ^ 0xE74987C);
					continue;
				case 3u:
					return 0;
				case 0u:
					val2 = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(22945093u));
					num2 = ((int)num3 * -612169274) ^ 0x59A0057A;
					continue;
				case 12u:
					num4 = (float)LuaScriptMgr.GetNumber(L, 3);
					num2 = ((int)num3 * -150674132) ^ 0x5F0897FE;
					continue;
				case 10u:
					_206C_206F_202D_206F_206B_206D_200D_206F_202C_206E_200E_206A_200B_206E_202D_202E_202D_202D_206C_202D_202B_200F_200E_202D_202A_202E_200C_202C_202A_206B_200D_200B_206B_200B_200F_206C_206F_206B_206C_202D_202E(val3, luaString3);
					return 0;
				case 8u:
					luaString2 = LuaScriptMgr.GetLuaString(L, 2);
					num7 = (float)LuaScriptMgr.GetNumber(L, 3);
					num2 = (int)((num3 * 827783012) ^ 0x22993540);
					continue;
				case 9u:
					val = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(22945093u));
					luaString = LuaScriptMgr.GetLuaString(L, 2);
					num2 = ((int)num3 * -444773267) ^ 0x6C7E3C21;
					continue;
				case 14u:
					num8 = (float)LuaScriptMgr.GetNumber(L, 4);
					num2 = ((int)num3 * -973483749) ^ -1118728687;
					continue;
				case 7u:
					luaString3 = LuaScriptMgr.GetLuaString(L, 2);
					num2 = (int)((num3 * 1169331980) ^ 0x472B75B4);
					continue;
				case 4u:
				{
					int num9;
					if (num != 4)
					{
						num2 = 427173055;
						num9 = num2;
					}
					else
					{
						num2 = 1113565778;
						num9 = num2;
					}
					continue;
				}
				case 15u:
				{
					int num5;
					int num6;
					if (num != 2)
					{
						num5 = 1848662647;
						num6 = num5;
					}
					else
					{
						num5 = 993768570;
						num6 = num5;
					}
					num2 = num5 ^ (int)(num3 * 1918004694);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2174657836u));
					num2 = 295631768;
					continue;
				case 16u:
					_202B_202E_202D_206C_202A_200B_202A_202C_206E_200D_200D_206D_206F_202C_200E_206D_206A_202C_206A_206E_200E_202E_200C_206C_206F_206C_206C_206E_202C_202B_206C_206D_202E_206D_202B_202D_200D_200D_200B_206A_202E(val, luaString, num4);
					num2 = (int)((num3 * 7177285) ^ 0x61EB8FED);
					continue;
				case 13u:
					return 0;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int CrossFadeQueued(IntPtr L)
	{
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		int num = LuaDLL.lua_gettop(L);
		float num9 = default(float);
		Animation val3 = default(Animation);
		string luaString = default(string);
		AnimationState obj = default(AnimationState);
		Animation val = default(Animation);
		QueueMode val7 = default(QueueMode);
		Animation val2 = default(Animation);
		string luaString4 = default(string);
		Animation val4 = default(Animation);
		string luaString2 = default(string);
		float num6 = default(float);
		QueueMode val5 = default(QueueMode);
		PlayMode val6 = default(PlayMode);
		string luaString3 = default(string);
		float num5 = default(float);
		AnimationState obj2 = default(AnimationState);
		while (true)
		{
			int num2 = 1711846165;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x774F6FC5)) % 28)
				{
				case 19u:
					break;
				case 23u:
					num9 = (float)LuaScriptMgr.GetNumber(L, 3);
					num2 = ((int)num3 * -994438512) ^ -26301082;
					continue;
				case 6u:
					val3 = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(22945093u));
					num2 = (int)((num3 * 921429536) ^ 0x5F55D76A);
					continue;
				case 1u:
					luaString = LuaScriptMgr.GetLuaString(L, 2);
					num2 = ((int)num3 * -1803266735) ^ -1871728853;
					continue;
				case 5u:
					obj = _206A_200E_206E_202A_200C_206B_202E_200F_206D_206F_206F_202E_202B_200B_202A_206B_202E_202C_202E_200E_202A_200E_206C_202E_206B_202C_206B_206C_206E_206B_202A_206F_206A_202B_200B_202B_206F_206D_206C_206E_202E(val, luaString, num9, val7);
					num2 = (int)((num3 * 725620808) ^ 0x46A8ED24);
					continue;
				case 22u:
				{
					int num10;
					if (num != 3)
					{
						num2 = 445573337;
						num10 = num2;
					}
					else
					{
						num2 = 486990483;
						num10 = num2;
					}
					continue;
				}
				case 4u:
					val2 = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2592956898u));
					num2 = (int)(num3 * 341996158) ^ -28626996;
					continue;
				case 20u:
				{
					int num11;
					if (num != 4)
					{
						num2 = 2018479023;
						num11 = num2;
					}
					else
					{
						num2 = 921439327;
						num11 = num2;
					}
					continue;
				}
				case 14u:
					return 1;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2781258065u));
					num2 = 404496780;
					continue;
				case 8u:
				{
					int num7;
					int num8;
					if (num == 2)
					{
						num7 = 1526726113;
						num8 = num7;
					}
					else
					{
						num7 = 497289027;
						num8 = num7;
					}
					num2 = num7 ^ ((int)num3 * -745082061);
					continue;
				}
				case 17u:
					luaString4 = LuaScriptMgr.GetLuaString(L, 2);
					num2 = (int)((num3 * 737946146) ^ 0x27F46DEB);
					continue;
				case 3u:
					val7 = (QueueMode)(int)LuaScriptMgr.GetNetObject(L, 4, _202E_206E_206E_200B_200F_200B_206D_202A_206F_206F_202D_202C_206B_200E_200C_202C_200F_200B_200D_202D_206A_202D_206E_202A_200F_202E_206D_206F_206A_202C_206F_202D_206C_200D_200F_206F_202A_200E_206C_206E_202E(typeof(QueueMode).TypeHandle));
					num2 = ((int)num3 * -1765654917) ^ 0x18059A1;
					continue;
				case 11u:
				{
					AnimationState obj4 = _206E_202B_202B_200C_200C_202C_202B_202D_206C_202D_200C_200E_202B_206C_202A_206B_202E_200C_206B_200D_200E_206B_202B_206B_206C_206A_202D_202D_200E_202B_200F_206A_202B_206C_200F_206E_202A_200D_206B_206B_202E(val4, luaString2, num6, val5, val6);
					LuaScriptMgr.Push(L, (TrackedReference)(object)obj4);
					num2 = (int)((num3 * 1784357529) ^ 0x41293900);
					continue;
				}
				case 7u:
					luaString3 = LuaScriptMgr.GetLuaString(L, 2);
					num2 = ((int)num3 * -2122376514) ^ 0x285B7CFC;
					continue;
				case 15u:
					num6 = (float)LuaScriptMgr.GetNumber(L, 3);
					num2 = ((int)num3 * -793774474) ^ -945567066;
					continue;
				case 27u:
					num5 = (float)LuaScriptMgr.GetNumber(L, 3);
					num2 = ((int)num3 * -1992902308) ^ 0x58B46707;
					continue;
				case 12u:
					val6 = (PlayMode)(int)LuaScriptMgr.GetNetObject(L, 5, _202E_206E_206E_200B_200F_200B_206D_202A_206F_206F_202D_202C_206B_200E_200C_202C_200F_200B_200D_202D_206A_202D_206E_202A_200F_202E_206D_206F_206A_202C_206F_202D_206C_200D_200F_206F_202A_200E_206C_206E_202E(typeof(PlayMode).TypeHandle));
					num2 = (int)((num3 * 1862028427) ^ 0x6253A62E);
					continue;
				case 21u:
					val5 = (QueueMode)(int)LuaScriptMgr.GetNetObject(L, 4, _202E_206E_206E_200B_200F_200B_206D_202A_206F_206F_202D_202C_206B_200E_200C_202C_200F_200B_200D_202D_206A_202D_206E_202A_200F_202E_206D_206F_206A_202C_206F_202D_206C_200D_200F_206F_202A_200E_206C_206E_202E(typeof(QueueMode).TypeHandle));
					num2 = ((int)num3 * -430978162) ^ 0x2EFC299F;
					continue;
				case 24u:
				{
					AnimationState obj3 = _200E_202D_206D_200C_200E_206D_202B_200F_206C_206E_202D_206F_206E_206B_200F_202C_206C_206C_202A_206D_206F_200E_200F_206A_202B_202B_206C_202A_200C_202A_202E_202C_202E_206E_206A_202C_202E_206D_200E_202A_202E(val2, luaString4);
					LuaScriptMgr.Push(L, (TrackedReference)(object)obj3);
					return 1;
				}
				case 2u:
					val4 = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(22945093u));
					num2 = ((int)num3 * -2060565403) ^ -948165693;
					continue;
				case 13u:
					LuaScriptMgr.Push(L, (TrackedReference)(object)obj2);
					return 1;
				case 26u:
					obj2 = _206A_200C_206D_202D_200B_206E_202A_200C_206F_200F_206D_206C_200B_206B_202A_202B_200F_200F_202B_200E_202B_200F_206E_206D_206A_200D_206C_200C_202B_202D_206D_206C_202D_206E_206F_200D_206C_200D_206F_206F_202E(val3, luaString3, num5);
					num2 = ((int)num3 * -1843154794) ^ -1797286752;
					continue;
				case 16u:
					luaString2 = LuaScriptMgr.GetLuaString(L, 2);
					num2 = (int)((num3 * 360516850) ^ 0x5ABB56F2);
					continue;
				case 9u:
					LuaScriptMgr.Push(L, (TrackedReference)(object)obj);
					return 1;
				case 18u:
				{
					int num4;
					if (num != 5)
					{
						num2 = 738758045;
						num4 = num2;
					}
					else
					{
						num2 = 1623230047;
						num4 = num2;
					}
					continue;
				}
				case 10u:
					val = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3355522354u));
					num2 = (int)(num3 * 403729435) ^ -382752558;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int PlayQueued(IntPtr L)
	{
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		int num = LuaDLL.lua_gettop(L);
		if (num == 2)
		{
			goto IL_000e;
		}
		goto IL_01df;
		IL_000e:
		int num2 = 208384840;
		goto IL_0013;
		IL_0013:
		AnimationState obj2 = default(AnimationState);
		Animation val3 = default(Animation);
		Animation val4 = default(Animation);
		string luaString2 = default(string);
		QueueMode val5 = default(QueueMode);
		PlayMode val6 = default(PlayMode);
		AnimationState obj = default(AnimationState);
		Animation val = default(Animation);
		string luaString = default(string);
		QueueMode val2 = default(QueueMode);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ 0x4737456E)) % 16)
			{
			case 8u:
				break;
			case 9u:
				LuaScriptMgr.Push(L, (TrackedReference)(object)obj2);
				return 1;
			case 5u:
			{
				string luaString3 = LuaScriptMgr.GetLuaString(L, 2);
				AnimationState obj3 = _202B_206B_206F_200D_202E_206A_200C_202E_206D_202C_202C_200F_202D_200B_206D_202A_206E_206B_200E_200B_202B_202A_200F_200F_206B_202C_206D_202D_200B_206A_200B_202D_200B_206A_206B_206F_200D_206D_202C_200F_202E(val3, luaString3);
				LuaScriptMgr.Push(L, (TrackedReference)(object)obj3);
				return 1;
			}
			case 2u:
				obj2 = _206D_200F_200E_206F_206F_202C_206A_200C_202A_200E_200E_200D_200F_200F_200E_206A_202B_202D_206E_202E_206A_206A_200D_206E_206C_206C_206A_206F_202C_206A_206E_206E_206F_206C_206D_200D_202E_202D_206D_202D_202E(val4, luaString2, val5, val6);
				num2 = ((int)num3 * -1946034568) ^ 0x17EC1C27;
				continue;
			case 12u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1595848667u));
				num2 = 890783518;
				continue;
			case 1u:
				obj = _206A_206F_202C_202B_200F_206A_206D_206F_202E_202C_206F_200B_206A_206F_206B_206E_202A_206E_206B_200D_200C_206C_206F_206C_200D_202B_200B_202C_206D_202C_200B_202B_202B_206B_206E_200D_202B_206C_202B_206C_202E(val, luaString, val2);
				num2 = (int)(num3 * 2061425356) ^ -493641320;
				continue;
			case 10u:
				LuaScriptMgr.Push(L, (TrackedReference)(object)obj);
				num2 = (int)(num3 * 1616685452) ^ -1439997879;
				continue;
			case 13u:
				val6 = (PlayMode)(int)LuaScriptMgr.GetNetObject(L, 4, _202E_206E_206E_200B_200F_200B_206D_202A_206F_206F_202D_202C_206B_200E_200C_202C_200F_200B_200D_202D_206A_202D_206E_202A_200F_202E_206D_206F_206A_202C_206F_202D_206C_200D_200F_206F_202A_200E_206C_206E_202E(typeof(PlayMode).TypeHandle));
				num2 = ((int)num3 * -511036586) ^ 0x280BFFD2;
				continue;
			case 11u:
				val4 = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1951077219u));
				luaString2 = LuaScriptMgr.GetLuaString(L, 2);
				val5 = (QueueMode)(int)LuaScriptMgr.GetNetObject(L, 3, _202E_206E_206E_200B_200F_200B_206D_202A_206F_206F_202D_202C_206B_200E_200C_202C_200F_200B_200D_202D_206A_202D_206E_202A_200F_202E_206D_206F_206A_202C_206F_202D_206C_200D_200F_206F_202A_200E_206C_206E_202E(typeof(QueueMode).TypeHandle));
				num2 = (int)(num3 * 1356933003) ^ -594448982;
				continue;
			case 6u:
				val3 = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(22945093u));
				num2 = ((int)num3 * -1015272041) ^ -62930063;
				continue;
			case 4u:
				goto IL_01c7;
			case 3u:
				goto IL_01df;
			case 15u:
				return 1;
			case 14u:
				val2 = (QueueMode)(int)LuaScriptMgr.GetNetObject(L, 3, _202E_206E_206E_200B_200F_200B_206D_202A_206F_206F_202D_202C_206B_200E_200C_202C_200F_200B_200D_202D_206A_202D_206E_202A_200F_202E_206D_206F_206A_202C_206F_202D_206C_200D_200F_206F_202A_200E_206C_206E_202E(typeof(QueueMode).TypeHandle));
				num2 = ((int)num3 * -1086567612) ^ 0x3FB02B47;
				continue;
			case 7u:
				val = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1951077219u));
				luaString = LuaScriptMgr.GetLuaString(L, 2);
				num2 = (int)((num3 * 109443975) ^ 0x23A7811);
				continue;
			default:
				return 0;
			}
			break;
			IL_01c7:
			int num4;
			if (num != 4)
			{
				num2 = 41723058;
				num4 = num2;
			}
			else
			{
				num2 = 932385749;
				num4 = num2;
			}
		}
		goto IL_000e;
		IL_01df:
		int num5;
		if (num == 3)
		{
			num2 = 1764083625;
			num5 = num2;
		}
		else
		{
			num2 = 2128435770;
			num5 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int AddClip(IntPtr L)
	{
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		Animation val4 = default(Animation);
		AnimationClip val5 = default(AnimationClip);
		Animation val2 = default(Animation);
		string luaString2 = default(string);
		int num6 = default(int);
		int num7 = default(int);
		bool boolean = default(bool);
		Animation val6 = default(Animation);
		AnimationClip val3 = default(AnimationClip);
		string luaString3 = default(string);
		int num4 = default(int);
		int num11 = default(int);
		while (true)
		{
			int num2 = -364441451;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -669328940)) % 20)
				{
				case 4u:
					break;
				case 5u:
					val4 = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3355522354u));
					val5 = (AnimationClip)LuaScriptMgr.GetUnityObject(L, 2, _202E_206E_206E_200B_200F_200B_206D_202A_206F_206F_202D_202C_206B_200E_200C_202C_200F_200B_200D_202D_206A_202D_206E_202A_200F_202E_206D_206F_206A_202C_206F_202D_206C_200D_200F_206F_202A_200E_206C_206E_202E(typeof(AnimationClip).TypeHandle));
					num2 = ((int)num3 * -427313532) ^ 0x72076184;
					continue;
				case 6u:
				{
					int num10;
					if (num == 5)
					{
						num2 = -782690645;
						num10 = num2;
					}
					else
					{
						num2 = -826569178;
						num10 = num2;
					}
					continue;
				}
				case 13u:
					val2 = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(22945093u));
					num2 = (int)((num3 * 2009232336) ^ 0x5E20ED42);
					continue;
				case 19u:
					_202A_202C_202C_206E_206C_206B_200C_202B_200E_206B_202D_202B_206C_206B_202B_206C_202A_202C_200B_200D_200B_200C_206E_206B_202E_202B_200B_200F_202D_202B_200D_206C_202D_202B_200C_200F_206A_202D_206E_200F_202E(val4, val5, luaString2, num6, num7, boolean);
					return 0;
				case 8u:
					num6 = (int)LuaScriptMgr.GetNumber(L, 4);
					num7 = (int)LuaScriptMgr.GetNumber(L, 5);
					num2 = ((int)num3 * -957665679) ^ 0xFA6D017;
					continue;
				case 7u:
					_200B_202E_206C_202D_200F_206E_206C_202C_202B_200C_200F_200C_202E_200C_202B_200D_200E_200E_202B_206A_206B_206D_202B_206A_206E_202C_200C_206E_206B_206F_200F_200E_206F_206A_202B_202C_206C_206B_206C_200E_202E(val6, val3, luaString3, num4, num11);
					num2 = (int)((num3 * 441926840) ^ 0xC5AED05);
					continue;
				case 11u:
					num11 = (int)LuaScriptMgr.GetNumber(L, 5);
					num2 = ((int)num3 * -1660608565) ^ 0x2E14A486;
					continue;
				case 17u:
					return 0;
				case 15u:
					val6 = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3355522354u));
					num2 = (int)((num3 * 83668957) ^ 0x615C6CEA);
					continue;
				case 9u:
				{
					int num8;
					int num9;
					if (num != 3)
					{
						num8 = -1874588069;
						num9 = num8;
					}
					else
					{
						num8 = -289665304;
						num9 = num8;
					}
					num2 = num8 ^ ((int)num3 * -35276807);
					continue;
				}
				case 2u:
				{
					int num5;
					if (num == 6)
					{
						num2 = -1445378787;
						num5 = num2;
					}
					else
					{
						num2 = -1064722678;
						num5 = num2;
					}
					continue;
				}
				case 1u:
					val3 = (AnimationClip)LuaScriptMgr.GetUnityObject(L, 2, _202E_206E_206E_200B_200F_200B_206D_202A_206F_206F_202D_202C_206B_200E_200C_202C_200F_200B_200D_202D_206A_202D_206E_202A_200F_202E_206D_206F_206A_202C_206F_202D_206C_200D_200F_206F_202A_200E_206C_206E_202E(typeof(AnimationClip).TypeHandle));
					luaString3 = LuaScriptMgr.GetLuaString(L, 3);
					num2 = ((int)num3 * -825311085) ^ -741745597;
					continue;
				case 18u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3675791549u));
					num2 = -1168467254;
					continue;
				case 0u:
					return 0;
				case 3u:
					boolean = LuaScriptMgr.GetBoolean(L, 6);
					num2 = (int)((num3 * 731192447) ^ 0x2EFCB262);
					continue;
				case 12u:
					luaString2 = LuaScriptMgr.GetLuaString(L, 3);
					num2 = ((int)num3 * -289558639) ^ -57846948;
					continue;
				case 10u:
				{
					AnimationClip val = (AnimationClip)LuaScriptMgr.GetUnityObject(L, 2, _202E_206E_206E_200B_200F_200B_206D_202A_206F_206F_202D_202C_206B_200E_200C_202C_200F_200B_200D_202D_206A_202D_206E_202A_200F_202E_206D_206F_206A_202C_206F_202D_206C_200D_200F_206F_202A_200E_206C_206E_202E(typeof(AnimationClip).TypeHandle));
					string luaString = LuaScriptMgr.GetLuaString(L, 3);
					_200F_206D_200D_202B_202A_200E_206E_200E_200C_206E_206F_202D_200B_202B_202B_206F_200F_202E_206D_202D_200F_206F_206A_200D_206B_206B_202E_200B_206D_202D_200E_200E_202C_202B_200C_200C_200C_206F_200F_200E_202E(val2, val, luaString);
					num2 = ((int)num3 * -126210084) ^ -1767810484;
					continue;
				}
				case 16u:
					num4 = (int)LuaScriptMgr.GetNumber(L, 4);
					num2 = (int)((num3 * 1801720582) ^ 0x63B08CF);
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int RemoveClip(IntPtr L)
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		AnimationClip val = default(AnimationClip);
		Animation val2 = default(Animation);
		while (true)
		{
			int num2 = -2002733768;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1848763161)) % 11)
				{
				case 7u:
					break;
				case 6u:
				{
					int num6;
					int num7;
					if (!LuaScriptMgr.CheckTypes(L, 1, _202E_206E_206E_200B_200F_200B_206D_202A_206F_206F_202D_202C_206B_200E_200C_202C_200F_200B_200D_202D_206A_202D_206E_202A_200F_202E_206D_206F_206A_202C_206F_202D_206C_200D_200F_206F_202A_200E_206C_206E_202E(typeof(Animation).TypeHandle), _202E_206E_206E_200B_200F_200B_206D_202A_206F_206F_202D_202C_206B_200E_200C_202C_200F_200B_200D_202D_206A_202D_206E_202A_200F_202E_206D_206F_206A_202C_206F_202D_206C_200D_200F_206F_202A_200E_206C_206E_202E(typeof(AnimationClip).TypeHandle)))
					{
						num6 = 2112799420;
						num7 = num6;
					}
					else
					{
						num6 = 619916004;
						num7 = num6;
					}
					num2 = num6 ^ ((int)num3 * -811461452);
					continue;
				}
				case 9u:
					val = (AnimationClip)LuaScriptMgr.GetLuaObject(L, 2);
					num2 = ((int)num3 * -1438577559) ^ -1947391622;
					continue;
				case 2u:
					return 0;
				case 4u:
				{
					Animation val3 = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3355522354u));
					string text = LuaScriptMgr.GetString(L, 2);
					_200B_206D_202E_206D_200B_206B_200E_202B_200B_200D_202A_206C_206A_202D_200C_202C_202B_200B_202E_202A_202E_206D_206B_206B_206B_206C_202E_206F_206D_200E_206D_202C_202C_206C_202C_202B_206A_206B_200F_202C_202E(val3, text);
					num2 = (int)(num3 * 1493785453) ^ -527078036;
					continue;
				}
				case 10u:
					val2 = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2592956898u));
					num2 = (int)((num3 * 338617231) ^ 0x4C422652);
					continue;
				case 8u:
				{
					int num9;
					int num10;
					if (num != 2)
					{
						num9 = 634695209;
						num10 = num9;
					}
					else
					{
						num9 = 1329505300;
						num10 = num9;
					}
					num2 = num9 ^ ((int)num3 * -1722250323);
					continue;
				}
				case 1u:
					_200C_202C_206A_206B_202A_200E_200F_200D_200B_206A_202E_200C_206B_200E_200C_202A_206B_206A_206F_206F_200C_200D_202D_202E_206B_200F_206D_200D_200F_206C_200F_200C_206F_206E_206E_206E_200B_200D_202E_206E_202E(val2, val);
					return 0;
				case 0u:
				{
					int num8;
					if (num != 2)
					{
						num2 = -574512152;
						num8 = num2;
					}
					else
					{
						num2 = -783584210;
						num8 = num2;
					}
					continue;
				}
				case 5u:
				{
					int num4;
					int num5;
					if (LuaScriptMgr.CheckTypes(L, 1, _202E_206E_206E_200B_200F_200B_206D_202A_206F_206F_202D_202C_206B_200E_200C_202C_200F_200B_200D_202D_206A_202D_206E_202A_200F_202E_206D_206F_206A_202C_206F_202D_206C_200D_200F_206F_202A_200E_206C_206E_202E(typeof(Animation).TypeHandle), _202E_206E_206E_200B_200F_200B_206D_202A_206F_206F_202D_202C_206B_200E_200C_202C_200F_200B_200D_202D_206A_202D_206E_202A_200F_202E_206D_206F_206A_202C_206F_202D_206C_200D_200F_206F_202A_200E_206C_206E_202E(typeof(string).TypeHandle)))
					{
						num4 = 37123366;
						num5 = num4;
					}
					else
					{
						num4 = 1072602010;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num3 * -585836588);
					continue;
				}
				default:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2952771095u));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetClipCount(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 1);
		Animation val = default(Animation);
		int d = default(int);
		while (true)
		{
			int num = -32008653;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -92561886)) % 5)
				{
				case 4u:
					break;
				case 2u:
					val = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2592956898u));
					num = (int)(num2 * 1586376033) ^ -104149927;
					continue;
				case 3u:
					d = _206D_202D_206D_202D_200C_202B_202C_206F_206C_200D_200B_200E_206F_200B_202B_200E_202C_200B_202E_200D_202D_200F_206E_202A_200F_202A_206A_202D_202C_202C_202C_200B_202B_200F_206B_202A_200C_202D_202A_206A_202E(val);
					num = ((int)num2 * -61690755) ^ 0x7B3C2CE0;
					continue;
				case 1u:
					LuaScriptMgr.Push(L, d);
					num = ((int)num2 * -1782004915) ^ -280787641;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SyncLayer(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		Animation val = default(Animation);
		int num3 = default(int);
		while (true)
		{
			int num = 1751604958;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x304EA96E)) % 5)
				{
				case 3u:
					break;
				case 2u:
					val = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1951077219u));
					num = ((int)num2 * -1810393372) ^ 0x2DC1EB3;
					continue;
				case 1u:
					num3 = (int)LuaScriptMgr.GetNumber(L, 2);
					num = (int)(num2 * 1248885993) ^ -386735361;
					continue;
				case 4u:
					_202A_206F_206D_206C_202A_206F_200D_202B_202A_202B_206E_206B_200E_206D_202A_206D_202D_200E_202D_206E_200C_206F_206F_200F_200B_206F_202E_202E_206B_200D_206E_206A_200D_200F_202B_206B_206B_202A_202A_206E_202E(val, num3);
					num = (int)((num2 * 192157831) ^ 0x7422C593);
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetEnumerator(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 1);
		Animation val = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1153888151u));
		IEnumerator o = _200E_200E_206A_200E_200F_200C_200F_200E_202B_206E_200E_206C_202D_202A_200D_202A_206B_206D_200D_200D_206C_200C_202E_206A_200B_200E_202C_206F_202B_206D_202D_200F_202E_202D_202A_200F_206A_202D_206D_206C_202E(val);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetClip(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		Animation val = (Animation)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3355522354u));
		string luaString = LuaScriptMgr.GetLuaString(L, 2);
		AnimationClip obj = _206C_202B_202E_202A_206F_206D_202E_200B_202C_200D_200D_200C_200C_202C_206E_202D_202D_206C_202D_202A_200B_200C_202A_206B_202A_206C_200D_206A_200E_206A_206C_202E_206B_206A_206F_202B_206D_202A_202D_200F_202E(val, luaString);
		LuaScriptMgr.Push(L, (Object)(object)obj);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Lua_Eq(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		bool b = default(bool);
		while (true)
		{
			int num = 1311167219;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7E28F9A4)) % 4)
				{
				case 0u:
					break;
				case 3u:
				{
					object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
					Object val = (Object)((luaObject is Object) ? luaObject : null);
					object luaObject2 = LuaScriptMgr.GetLuaObject(L, 2);
					Object val2 = (Object)((luaObject2 is Object) ? luaObject2 : null);
					b = _206E_206C_202A_206B_202D_200F_206E_202A_206C_200F_202C_200B_200C_200F_206A_202A_206F_202D_206C_206E_200C_202E_200E_206E_206D_202B_200C_202D_202E_202C_200B_206A_206E_202D_202C_206B_200B_202B_200E_206B_202E(val, val2);
					num = ((int)num2 * -1892452570) ^ -1336181268;
					continue;
				}
				case 2u:
					LuaScriptMgr.Push(L, b);
					num = (int)(num2 * 160788746) ^ -689748779;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	static Type _202E_206E_206E_200B_200F_200B_206D_202A_206F_206F_202D_202C_206B_200E_200C_202C_200F_200B_200D_202D_206A_202D_206E_202A_200F_202E_206D_206F_206A_202C_206F_202D_206C_200D_200F_206F_202A_200E_206C_206E_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static Animation _200E_202E_202D_202C_202C_202B_200C_202E_202D_206D_202D_202A_200D_206E_202C_200F_202A_206C_202E_206D_200C_202B_202C_206E_206F_200D_206D_202E_200C_206D_206D_206B_202B_200D_200B_202C_202E_200D_206A_200F_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Animation();
	}

	static bool _206E_206C_202A_206B_202D_200F_206E_202A_206C_200F_202C_200B_200C_200F_206A_202A_206F_202D_206C_206E_200C_202E_200E_206E_206D_202B_200C_202D_202E_202C_200B_206A_206E_202D_202C_206B_200B_202B_200E_206B_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static AnimationClip _200D_206B_206E_200E_206C_200C_202D_206E_202D_206D_200E_200F_206D_202C_202B_206A_202D_200E_200F_206D_202C_206E_200F_202A_206B_200F_200E_206B_206E_202B_206D_206F_200E_202C_206F_202D_202A_206F_206D_202A_202E(Animation P_0)
	{
		return P_0.clip;
	}

	static bool _206B_206A_206A_206C_202C_200E_200B_200C_200E_200B_206C_202B_200F_206C_206B_202D_200D_206A_206B_200F_206C_206A_200C_200C_200D_202B_206D_200E_206C_206B_202C_200B_202A_206B_202A_206A_202C_200B_202E_200F_202E(Animation P_0)
	{
		return P_0.playAutomatically;
	}

	static WrapMode _200C_206F_202A_202B_202A_200C_202E_202E_206E_200C_202B_200F_202C_206C_206A_206C_202A_202A_206A_202A_202C_202A_206F_206D_202E_200B_206E_206C_206E_200F_200B_206F_200D_200F_200F_206D_206F_202A_206F_200F_202E(Animation P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.wrapMode;
	}

	static bool _202B_200F_202A_200D_202A_206F_202A_202D_202A_206B_200B_200F_206E_202E_206D_206B_200C_200C_206D_206A_206B_206D_206B_206D_200B_202D_206A_206C_200B_206B_206A_206A_206E_206E_206F_206E_206F_202C_202B_202E_202E(Animation P_0)
	{
		return P_0.isPlaying;
	}

	static bool _202E_206E_206A_202A_200B_202E_206A_206B_206D_202C_200F_200D_200B_202E_206D_206E_202C_202E_200C_206D_206B_202E_202B_202E_202C_206A_200C_202C_206B_206F_200C_206F_206E_200C_206F_200C_200D_206C_202C_206F_202E(Animation P_0)
	{
		return P_0.animatePhysics;
	}

	static AnimationCullingType _206B_200D_200F_202B_206F_202B_206A_200F_202D_200F_202E_200F_202D_206B_206C_202E_200E_202B_206F_202A_206A_200C_200D_200C_206F_202A_202A_202E_202A_200C_206F_202C_200D_202B_200C_202C_200C_200E_206C_200C_202E(Animation P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.cullingType;
	}

	static Bounds _206B_200D_206C_206E_202B_200B_200C_200F_202B_200B_200C_202C_200B_202A_206A_206A_206C_200E_206C_200D_202A_200E_206E_202A_200E_206C_200C_200B_200B_206D_202C_206B_202A_202E_202E_200F_206D_206F_206A_206C_202E(Animation P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.localBounds;
	}

	static void _206E_200D_206B_202A_206D_206B_206D_200F_200F_202D_206D_202E_206E_202D_206E_206C_200C_202A_200F_206D_206B_200D_206E_206A_206F_202B_206D_200F_202B_202C_202D_206D_200F_200E_206D_206D_202E_206F_206E_202E_202E(Animation P_0, AnimationClip P_1)
	{
		P_0.clip = P_1;
	}

	static void _206A_200B_206C_206F_202A_206C_202D_200B_200C_200D_200C_206E_206E_202C_206E_202D_202A_202C_200F_200C_202B_202C_206A_202E_200E_206B_200B_206A_202D_202B_202B_202D_200E_206C_202D_200C_206E_206E_206C_206D_202E(Animation P_0, bool P_1)
	{
		P_0.playAutomatically = P_1;
	}

	static void _206E_206E_200B_202C_202C_200F_202B_200D_200C_202C_200B_200F_206F_200D_200D_206D_206F_202A_202B_202B_202B_206D_206F_206D_200D_200F_206F_202D_206C_206C_206C_200C_206D_206A_200F_202D_202E_200E_206C_206D_202E(Animation P_0, WrapMode P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.wrapMode = P_1;
	}

	static void _202B_206D_202E_200C_206A_202C_206B_206E_200D_200D_200C_206A_206F_206D_202A_200B_200E_200E_200F_200C_206F_200E_206D_202A_206F_200E_200D_202A_200C_206F_206B_206B_202A_202D_200D_202D_202A_206E_206F_200E_202E(Animation P_0, bool P_1)
	{
		P_0.animatePhysics = P_1;
	}

	static void _202B_206F_200E_200E_202C_200F_202C_206E_206C_206D_200C_202B_200F_200C_202C_202B_202B_202C_200E_200F_206F_200F_206A_200C_206B_202C_200E_206C_206A_206D_202C_200B_200B_206D_206D_206A_200C_200D_202C_206B_202E(Animation P_0, AnimationCullingType P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.cullingType = P_1;
	}

	static void _206E_200F_200E_202C_206C_206A_206C_206E_206F_202D_200C_206A_200E_206C_202A_202D_202C_200D_200D_202D_206F_200D_202D_202B_200E_200C_206A_200B_206D_202C_206B_206C_202D_200F_202C_200F_202B_202B_202C_206D_202E(Animation P_0, Bounds P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.localBounds = P_1;
	}

	static void _206F_206D_206A_200C_202D_200E_200B_200B_200F_200B_200C_202E_200E_206F_206D_206B_206D_206A_206A_202A_206E_206A_200E_206F_206D_206B_206C_202D_206C_206C_200F_200E_206F_200E_200F_202A_202B_200E_202E_202B_202E(Animation P_0)
	{
		P_0.Stop();
	}

	static void _200E_206E_200B_206C_200D_206F_206B_200E_202D_206C_202B_206F_200F_206F_202C_200E_202B_200E_206C_200E_200D_200F_202D_206E_202C_200E_206F_202C_200C_202E_202C_206B_200B_200B_202A_202D_200D_202D_206C_202B_202E(Animation P_0, string P_1)
	{
		P_0.Stop(P_1);
	}

	static void _206D_206A_206D_206E_200C_202C_202A_202D_202D_202E_200E_206D_202C_206E_202C_206E_206B_200C_202D_206F_202B_206C_200D_200E_202B_200F_206B_200D_202E_202B_206B_202E_202D_202D_202E_202C_206B_202C_200B_206B_202E(Animation P_0)
	{
		P_0.Rewind();
	}

	static void _206A_206D_202A_200E_206D_206B_206D_202D_200F_202A_206C_206D_202A_200D_206C_202E_202C_206A_202A_206F_206B_200D_200B_200E_202C_206C_206F_206F_202A_206A_206E_200E_200F_202E_202B_200E_206E_206D_202E_202E_202E(Animation P_0, string P_1)
	{
		P_0.Rewind(P_1);
	}

	static void _202B_206A_202A_200F_202C_200E_206E_202D_200C_202C_202A_202C_202E_206D_206D_202C_206F_206C_200D_206E_200E_200B_206F_200D_200E_200C_202C_206B_200E_202C_200C_202E_200C_200C_206F_200E_202B_206D_206F_206E_202E(Animation P_0)
	{
		P_0.Sample();
	}

	static bool _206C_206C_202A_200F_200D_206C_200E_206F_206F_202B_200C_202A_206D_200B_206E_200F_200E_200B_206B_200E_206E_200F_202D_202B_206E_200C_200C_206E_202D_200F_206E_202A_200E_206B_200F_206E_202C_200D_200D_206D_202E(Animation P_0, string P_1)
	{
		return P_0.IsPlaying(P_1);
	}

	static AnimationState _202D_202A_200B_206E_206B_206F_202A_206F_206C_202C_206A_206A_202B_200E_206C_200E_202B_202D_206E_200E_202B_206A_200E_206C_206D_200E_202A_200B_206C_206E_206B_202C_206B_200E_206A_202E_206B_200F_202C_200D_202E(Animation P_0, string P_1)
	{
		return P_0[P_1];
	}

	static bool _206F_202A_202D_206A_202B_206F_200B_202D_202B_206A_206F_202E_206A_202C_200D_202A_206E_206A_200E_206A_200F_202E_202C_202C_200C_206A_206F_202D_200D_206E_202A_200B_202D_206C_200D_200C_202D_200D_206D_202E_202E(Animation P_0)
	{
		return P_0.Play();
	}

	static bool _202E_200B_206F_202A_206B_206C_200E_206B_206E_206A_200E_200D_206F_202C_200C_202C_200F_202C_200D_206B_200B_202D_202B_206F_206D_202C_200B_202A_202E_206B_202A_200D_206C_206F_202E_202B_206E_206F_200F_202A_202E(Animation P_0, string P_1)
	{
		return P_0.Play(P_1);
	}

	static bool _206F_202A_200F_200C_200C_202B_206E_200E_200E_206E_200F_200B_206E_206D_206B_200B_206F_202C_200D_200D_206B_206C_200B_200C_206A_200B_206A_200B_200B_202E_206F_200B_206C_202E_200C_206C_206D_200F_206C_206B_202E(Animation P_0, PlayMode P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.Play(P_1);
	}

	static bool _200F_202C_200D_206C_202C_202B_202A_202D_202E_200D_206D_206C_202E_202E_200F_206F_206F_200C_202C_202A_200E_202A_206D_206D_200C_206C_202D_206F_202B_202E_202B_200C_202E_206E_206A_206E_206D_200B_206E_200E_202E(Animation P_0, string P_1, PlayMode P_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return P_0.Play(P_1, P_2);
	}

	static void _202A_206E_202E_200B_202A_202B_200D_200B_202A_206D_202A_202D_206B_200D_200D_202E_200F_200B_200C_206C_200B_200F_200D_206D_202B_200F_200B_202A_206F_200D_206E_200F_200F_200F_202A_200F_206D_200B_202B_206D_202E(Animation P_0, string P_1)
	{
		P_0.CrossFade(P_1);
	}

	static void _202B_206A_206C_202A_200F_200C_206C_202C_206A_202D_200C_202C_202D_206D_206A_202B_206C_200E_206A_206D_206A_202D_200B_206A_206D_200D_202D_206A_206D_206B_200D_200B_202C_200C_206F_200E_206C_200E_202A_206F_202E(Animation P_0, string P_1, float P_2)
	{
		P_0.CrossFade(P_1, P_2);
	}

	static void _206D_200D_202A_202E_202B_206F_206B_202B_202E_206C_206B_206B_202A_206F_202A_206B_202A_202B_206E_202E_202C_202D_206A_206C_200D_200E_200E_200F_206C_200E_202B_202A_200F_206F_206F_206F_206D_200D_206A_200F_202E(Animation P_0, string P_1, float P_2, PlayMode P_3)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		P_0.CrossFade(P_1, P_2, P_3);
	}

	static void _206C_206F_202D_206F_206B_206D_200D_206F_202C_206E_200E_206A_200B_206E_202D_202E_202D_202D_206C_202D_202B_200F_200E_202D_202A_202E_200C_202C_202A_206B_200D_200B_206B_200B_200F_206C_206F_206B_206C_202D_202E(Animation P_0, string P_1)
	{
		P_0.Blend(P_1);
	}

	static void _202B_202E_202D_206C_202A_200B_202A_202C_206E_200D_200D_206D_206F_202C_200E_206D_206A_202C_206A_206E_200E_202E_200C_206C_206F_206C_206C_206E_202C_202B_206C_206D_202E_206D_202B_202D_200D_200D_200B_206A_202E(Animation P_0, string P_1, float P_2)
	{
		P_0.Blend(P_1, P_2);
	}

	static void _202E_206C_206C_202C_202B_202C_206D_206D_200C_202D_200D_200D_200D_200B_200D_200E_202E_202C_206D_206F_206D_202B_202D_200C_202B_200C_206F_206B_200B_206A_206A_206B_206C_202C_200E_200D_206B_206B_206F_200C_202E(Animation P_0, string P_1, float P_2, float P_3)
	{
		P_0.Blend(P_1, P_2, P_3);
	}

	static AnimationState _200E_202D_206D_200C_200E_206D_202B_200F_206C_206E_202D_206F_206E_206B_200F_202C_206C_206C_202A_206D_206F_200E_200F_206A_202B_202B_206C_202A_200C_202A_202E_202C_202E_206E_206A_202C_202E_206D_200E_202A_202E(Animation P_0, string P_1)
	{
		return P_0.CrossFadeQueued(P_1);
	}

	static AnimationState _206A_200C_206D_202D_200B_206E_202A_200C_206F_200F_206D_206C_200B_206B_202A_202B_200F_200F_202B_200E_202B_200F_206E_206D_206A_200D_206C_200C_202B_202D_206D_206C_202D_206E_206F_200D_206C_200D_206F_206F_202E(Animation P_0, string P_1, float P_2)
	{
		return P_0.CrossFadeQueued(P_1, P_2);
	}

	static AnimationState _206A_200E_206E_202A_200C_206B_202E_200F_206D_206F_206F_202E_202B_200B_202A_206B_202E_202C_202E_200E_202A_200E_206C_202E_206B_202C_206B_206C_206E_206B_202A_206F_206A_202B_200B_202B_206F_206D_206C_206E_202E(Animation P_0, string P_1, float P_2, QueueMode P_3)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return P_0.CrossFadeQueued(P_1, P_2, P_3);
	}

	static AnimationState _206E_202B_202B_200C_200C_202C_202B_202D_206C_202D_200C_200E_202B_206C_202A_206B_202E_200C_206B_200D_200E_206B_202B_206B_206C_206A_202D_202D_200E_202B_200F_206A_202B_206C_200F_206E_202A_200D_206B_206B_202E(Animation P_0, string P_1, float P_2, QueueMode P_3, PlayMode P_4)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return P_0.CrossFadeQueued(P_1, P_2, P_3, P_4);
	}

	static AnimationState _202B_206B_206F_200D_202E_206A_200C_202E_206D_202C_202C_200F_202D_200B_206D_202A_206E_206B_200E_200B_202B_202A_200F_200F_206B_202C_206D_202D_200B_206A_200B_202D_200B_206A_206B_206F_200D_206D_202C_200F_202E(Animation P_0, string P_1)
	{
		return P_0.PlayQueued(P_1);
	}

	static AnimationState _206A_206F_202C_202B_200F_206A_206D_206F_202E_202C_206F_200B_206A_206F_206B_206E_202A_206E_206B_200D_200C_206C_206F_206C_200D_202B_200B_202C_206D_202C_200B_202B_202B_206B_206E_200D_202B_206C_202B_206C_202E(Animation P_0, string P_1, QueueMode P_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return P_0.PlayQueued(P_1, P_2);
	}

	static AnimationState _206D_200F_200E_206F_206F_202C_206A_200C_202A_200E_200E_200D_200F_200F_200E_206A_202B_202D_206E_202E_206A_206A_200D_206E_206C_206C_206A_206F_202C_206A_206E_206E_206F_206C_206D_200D_202E_202D_206D_202D_202E(Animation P_0, string P_1, QueueMode P_2, PlayMode P_3)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return P_0.PlayQueued(P_1, P_2, P_3);
	}

	static void _200F_206D_200D_202B_202A_200E_206E_200E_200C_206E_206F_202D_200B_202B_202B_206F_200F_202E_206D_202D_200F_206F_206A_200D_206B_206B_202E_200B_206D_202D_200E_200E_202C_202B_200C_200C_200C_206F_200F_200E_202E(Animation P_0, AnimationClip P_1, string P_2)
	{
		P_0.AddClip(P_1, P_2);
	}

	static void _200B_202E_206C_202D_200F_206E_206C_202C_202B_200C_200F_200C_202E_200C_202B_200D_200E_200E_202B_206A_206B_206D_202B_206A_206E_202C_200C_206E_206B_206F_200F_200E_206F_206A_202B_202C_206C_206B_206C_200E_202E(Animation P_0, AnimationClip P_1, string P_2, int P_3, int P_4)
	{
		P_0.AddClip(P_1, P_2, P_3, P_4);
	}

	static void _202A_202C_202C_206E_206C_206B_200C_202B_200E_206B_202D_202B_206C_206B_202B_206C_202A_202C_200B_200D_200B_200C_206E_206B_202E_202B_200B_200F_202D_202B_200D_206C_202D_202B_200C_200F_206A_202D_206E_200F_202E(Animation P_0, AnimationClip P_1, string P_2, int P_3, int P_4, bool P_5)
	{
		P_0.AddClip(P_1, P_2, P_3, P_4, P_5);
	}

	static void _200B_206D_202E_206D_200B_206B_200E_202B_200B_200D_202A_206C_206A_202D_200C_202C_202B_200B_202E_202A_202E_206D_206B_206B_206B_206C_202E_206F_206D_200E_206D_202C_202C_206C_202C_202B_206A_206B_200F_202C_202E(Animation P_0, string P_1)
	{
		P_0.RemoveClip(P_1);
	}

	static void _200C_202C_206A_206B_202A_200E_200F_200D_200B_206A_202E_200C_206B_200E_200C_202A_206B_206A_206F_206F_200C_200D_202D_202E_206B_200F_206D_200D_200F_206C_200F_200C_206F_206E_206E_206E_200B_200D_202E_206E_202E(Animation P_0, AnimationClip P_1)
	{
		P_0.RemoveClip(P_1);
	}

	static int _206D_202D_206D_202D_200C_202B_202C_206F_206C_200D_200B_200E_206F_200B_202B_200E_202C_200B_202E_200D_202D_200F_206E_202A_200F_202A_206A_202D_202C_202C_202C_200B_202B_200F_206B_202A_200C_202D_202A_206A_202E(Animation P_0)
	{
		return P_0.GetClipCount();
	}

	static void _202A_206F_206D_206C_202A_206F_200D_202B_202A_202B_206E_206B_200E_206D_202A_206D_202D_200E_202D_206E_200C_206F_206F_200F_200B_206F_202E_202E_206B_200D_206E_206A_200D_200F_202B_206B_206B_202A_202A_206E_202E(Animation P_0, int P_1)
	{
		P_0.SyncLayer(P_1);
	}

	static IEnumerator _200E_200E_206A_200E_200F_200C_200F_200E_202B_206E_200E_206C_202D_202A_200D_202A_206B_206D_200D_200D_206C_200C_202E_206A_200B_200E_202C_206F_202B_206D_202D_200F_202E_202D_202A_200F_206A_202D_206D_206C_202E(Animation P_0)
	{
		return P_0.GetEnumerator();
	}

	static AnimationClip _206C_202B_202E_202A_206F_206D_202E_200B_202C_200D_200D_200C_200C_202C_206E_202D_202D_206C_202D_202A_200B_200C_202A_206B_202A_206C_200D_206A_200E_206A_206C_202E_206B_206A_206F_202B_206D_202A_202D_200F_202E(Animation P_0, string P_1)
	{
		return P_0.GetClip(P_1);
	}
}
