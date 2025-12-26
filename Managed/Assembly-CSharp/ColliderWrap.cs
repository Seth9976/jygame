using System;
using LuaInterface;
using UnityEngine;

public class ColliderWrap
{
	private static Type classType = _202B_200C_206F_206E_206B_206C_202B_202B_200E_200C_202B_200B_202D_200F_200B_206E_200C_200C_202D_200E_202E_206E_200C_206C_200C_206D_202A_206F_200E_202B_202D_202E_206E_202E_200C_200D_200D_200B_206A_200C_202E(typeof(Collider).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[5]
		{
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4113451952u), ClosestPointOnBounds),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3016402527u), Raycast),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2705981273u), _200F_200E_202B_202C_202D_202C_200B_206E_202A_202B_202D_200C_206A_202A_206A_206E_200D_206B_202B_202D_206A_206A_202D_200C_206B_206B_206C_200F_200B_206D_206D_202D_200E_200F_202D_200C_200E_200C_202B_200F_202E),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2567984228u), GetClassType),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3465012375u), Lua_Eq)
		};
		LuaField[] fields = new LuaField[7]
		{
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2776085456u), get_enabled, set_enabled),
			new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1383881589u), get_attachedRigidbody, null),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(91358573u), get_isTrigger, set_isTrigger),
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1256728840u), get_contactOffset, set_contactOffset),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2866620620u), get_material, set_material),
			new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2082385647u), get_sharedMaterial, set_sharedMaterial),
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2892944085u), get_bounds, null)
		};
		while (true)
		{
			int num = -982264056;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1230895343)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0242;
				case 1u:
					return;
				}
				break;
				IL_0242:
				LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(874730424u), _202B_200C_206F_206E_206B_206C_202B_202B_200E_200C_202B_200B_202D_200F_200B_206E_200C_200C_202D_200E_202E_206E_200C_206C_200C_206D_202A_206F_200E_202B_202D_202E_206E_202E_200C_200D_200D_200B_206A_200C_202E(typeof(Collider).TypeHandle), regs, fields, _202B_200C_206F_206E_206B_206C_202B_202B_200E_200C_202B_200B_202D_200F_200B_206E_200C_200C_202D_200E_202E_206E_200C_206C_200C_206D_202A_206F_200E_202B_202D_202E_206E_202E_200C_200D_200D_200B_206A_200C_202E(typeof(Component).TypeHandle));
				num = (int)(num2 * 2071505910) ^ -970563149;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _200F_200E_202B_202C_202D_202C_200B_206E_202A_202B_202D_200C_206A_202A_206A_206E_200D_206B_202B_202D_206A_206A_202D_200C_206B_206B_206C_200F_200B_206D_206D_202D_200E_200F_202D_200C_200E_200C_202B_200F_202E(IntPtr P_0)
	{
		int num = LuaDLL.lua_gettop(P_0);
		while (true)
		{
			int num2 = -787188770;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -59849543)) % 5)
				{
				case 2u:
					break;
				case 4u:
					LuaDLL.luaL_error(P_0, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3606834786u));
					num2 = -1649040138;
					continue;
				case 0u:
				{
					Collider obj = _200E_202A_200D_206E_200F_206E_200D_206B_206F_206F_200D_200F_206C_200C_200F_200E_200B_206D_200C_206F_206B_202A_200B_202C_202D_200B_200B_206F_200D_206C_206C_202B_202D_206D_200F_200F_206C_202B_202C_206D_202E();
					LuaScriptMgr.Push(P_0, (Object)(object)obj);
					return 1;
				}
				case 3u:
				{
					int num4;
					int num5;
					if (num != 0)
					{
						num4 = 140546546;
						num5 = num4;
					}
					else
					{
						num4 = 1923251860;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 2004203813);
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
	private static int get_enabled(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Collider val = (Collider)luaObject;
		if (_200C_206D_206C_206B_202B_206A_206D_200B_206D_200D_200B_202A_200C_200D_206F_206F_200F_202D_206B_202C_206B_200B_202D_206F_202D_206E_206A_200F_202B_206A_206F_200B_202D_200C_206F_206B_206F_202D_200C_206D_202E((Object)(object)val, (Object)null))
		{
			goto IL_001b;
		}
		goto IL_00bd;
		IL_001b:
		int num = 19568058;
		goto IL_0020;
		IL_0020:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x2EA2C3F8)) % 7)
			{
			case 5u:
				break;
			case 4u:
				num = ((int)num2 * -1453437733) ^ -151440808;
				continue;
			case 3u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2684529217u));
				num = 869768182;
				continue;
			case 1u:
			{
				LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
				int num3;
				int num4;
				if (luaTypes != LuaTypes.LUA_TTABLE)
				{
					num3 = -185605787;
					num4 = num3;
				}
				else
				{
					num3 = -1389699041;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 1790246111);
				continue;
			}
			case 2u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3927089387u));
				num = ((int)num2 * -300092483) ^ -1974635161;
				continue;
			case 6u:
				goto IL_00bd;
			default:
				return 1;
			}
			break;
		}
		goto IL_001b;
		IL_00bd:
		LuaScriptMgr.Push(L, _202C_202C_202A_202B_200B_206E_206F_202E_202E_202E_206E_206F_206B_202E_202A_202E_200E_200D_206D_206B_200D_206B_202C_202D_206A_206B_206D_202E_202E_200B_200E_206C_200D_206F_206B_206F_202E_200B_206B_200D_202E(val));
		num = 212961814;
		goto IL_0020;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_attachedRigidbody(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Collider val = (Collider)luaObject;
		if (_200C_206D_206C_206B_202B_206A_206D_200B_206D_200D_200B_202A_200C_200D_206F_206F_200F_202D_206B_202C_206B_200B_202D_206F_202D_206E_206A_200F_202B_206A_206F_200B_202D_200C_206F_206B_206F_202D_200C_206D_202E((Object)(object)val, (Object)null))
		{
			goto IL_0018;
		}
		goto IL_0064;
		IL_0018:
		int num = 2047919505;
		goto IL_001d;
		IL_001d:
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x73D23FDB)) % 7)
			{
			case 6u:
				break;
			case 2u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2139360724u));
				num = 1219289810;
				continue;
			case 0u:
				goto IL_0064;
			case 4u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(918212217u));
				num = (int)(num2 * 2015820115) ^ -1878074350;
				continue;
			case 1u:
				luaTypes = LuaDLL.lua_type(L, 1);
				num = (int)(num2 * 1200418276) ^ -1849765450;
				continue;
			case 3u:
			{
				int num3;
				int num4;
				if (luaTypes == LuaTypes.LUA_TTABLE)
				{
					num3 = 1071407415;
					num4 = num3;
				}
				else
				{
					num3 = 572878118;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 463456188);
				continue;
			}
			default:
				return 1;
			}
			break;
		}
		goto IL_0018;
		IL_0064:
		LuaScriptMgr.Push(L, (Object)(object)_206C_202E_202B_202A_202C_206A_206B_206E_200B_206B_202A_206A_200E_202D_206B_206D_202A_200D_206E_202E_200E_202C_200C_200B_202A_200B_206C_206F_206D_206C_206A_206C_200D_200D_200F_202C_202B_202D_202D_206C_202E(val));
		num = 68145540;
		goto IL_001d;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_isTrigger(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Collider val = (Collider)luaObject;
		while (true)
		{
			int num = 892296809;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7BF7F563)) % 6)
				{
				case 0u:
					break;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(820488240u));
					num = 1426518426;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(195729828u));
					num = (int)((num2 * 1094491924) ^ 0x4DCB2C6E);
					continue;
				case 2u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -638445378;
						num6 = num5;
					}
					else
					{
						num5 = -323122562;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1784149402);
					continue;
				}
				case 4u:
				{
					int num3;
					int num4;
					if (!_200C_206D_206C_206B_202B_206A_206D_200B_206D_200D_200B_202A_200C_200D_206F_206F_200F_202D_206B_202C_206B_200B_202D_206F_202D_206E_206A_200F_202B_206A_206F_200B_202D_200C_206F_206B_206F_202D_200C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = -131424680;
						num4 = num3;
					}
					else
					{
						num3 = -1238518121;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1849701971);
					continue;
				}
				default:
					LuaScriptMgr.Push(L, _206B_206B_206E_200E_200E_202D_200C_206E_202B_200C_202A_200F_206C_200E_206D_206B_206A_202C_200B_200D_206E_202D_206B_202A_206F_206B_206F_202A_200E_202C_202A_202E_200F_202E_200B_200C_206E_200D_202D_206C_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_contactOffset(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Collider val = default(Collider);
		while (true)
		{
			int num = -566087930;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -64056898)) % 7)
				{
				case 6u:
					break;
				case 4u:
				{
					val = (Collider)luaObject;
					int num5;
					int num6;
					if (!_200C_206D_206C_206B_202B_206A_206D_200B_206D_200D_200B_202A_200C_200D_206F_206F_200F_202D_206B_202C_206B_200B_202D_206F_202D_206E_206A_200F_202B_206A_206F_200B_202D_200C_206F_206B_206F_202D_200C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = -932985337;
						num6 = num5;
					}
					else
					{
						num5 = -595363185;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 546936553);
					continue;
				}
				case 5u:
					LuaScriptMgr.Push(L, _206B_200E_200F_200F_202A_206E_200E_206F_202D_200F_200E_206B_206B_200E_202B_200B_206F_206B_206A_202E_200E_202D_206D_200C_202E_202E_200E_206A_206C_202B_202D_200B_206A_202E_206C_206B_206E_200B_202A_202E(val));
					num = -1691631822;
					continue;
				case 2u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -1400315434;
						num4 = num3;
					}
					else
					{
						num3 = -1529507823;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1581447880);
					continue;
				}
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(717283150u));
					num = -1059937409;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2183340612u));
					num = ((int)num2 * -1109201051) ^ -241475796;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_material(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Collider val = (Collider)luaObject;
		while (true)
		{
			int num = 1646989259;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0xE6BDFC6)) % 6)
				{
				case 4u:
					break;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3025432925u));
					num = 121607066;
					continue;
				case 1u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 1377892333;
						num6 = num5;
					}
					else
					{
						num5 = 1585415360;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1758239824);
					continue;
				}
				case 3u:
				{
					int num3;
					int num4;
					if (!_200C_206D_206C_206B_202B_206A_206D_200B_206D_200D_200B_202A_200C_200D_206F_206F_200F_202D_206B_202C_206B_200B_202D_206F_202D_206E_206A_200F_202B_206A_206F_200B_202D_200C_206F_206B_206F_202D_200C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = -1378526846;
						num4 = num3;
					}
					else
					{
						num3 = -173055745;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -216443784);
					continue;
				}
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2667657626u));
					num = (int)(num2 * 946060331) ^ -671181080;
					continue;
				default:
					LuaScriptMgr.Push(L, (Object)(object)_206B_206D_206B_206E_200E_200D_202B_202D_202B_200E_206C_206C_200F_206C_206F_202E_202E_206E_200E_202E_200C_206B_202A_202E_206F_202E_206E_206A_206B_200B_206D_206A_202B_200D_200B_200C_202D_206D_206F_206C_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_sharedMaterial(IntPtr L)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Collider val = default(Collider);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -429710331;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -334815418)) % 9)
				{
				case 7u:
					break;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(339613742u));
					num = (int)(num2 * 452536125) ^ -623008804;
					continue;
				case 5u:
					LuaScriptMgr.Push(L, (Object)(object)_200D_206F_206F_202D_202E_206D_202C_206A_200C_206D_200E_202C_200B_200E_206C_206A_202E_206A_200E_202A_206C_206A_202A_200C_206E_202B_202B_206F_200B_202B_202A_202E_206D_200B_202E_200C_206A_206D_200C_200C_202E(val));
					num = -793588829;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2000364400u));
					num = -483973132;
					continue;
				case 4u:
					num = (int)((num2 * 1908123629) ^ 0x62501563);
					continue;
				case 6u:
				{
					val = (Collider)luaObject;
					int num5;
					int num6;
					if (_200C_206D_206C_206B_202B_206A_206D_200B_206D_200D_200B_202A_200C_200D_206F_206F_200F_202D_206B_202C_206B_200B_202D_206F_202D_206E_206A_200F_202B_206A_206F_200B_202D_200C_206F_206B_206F_202D_200C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = -1361596825;
						num6 = num5;
					}
					else
					{
						num5 = -128728416;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1845473764);
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 327054043;
						num4 = num3;
					}
					else
					{
						num3 = 1613401795;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1633584912);
					continue;
				}
				case 8u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -848884194) ^ -1559628166;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_bounds(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Collider val = (Collider)luaObject;
		if (_200C_206D_206C_206B_202B_206A_206D_200B_206D_200D_200B_202A_200C_200D_206F_206F_200F_202D_206B_202C_206B_200B_202D_206F_202D_206E_206A_200F_202B_206A_206F_200B_202D_200C_206F_206B_206F_202D_200C_206D_202E((Object)(object)val, (Object)null))
		{
			LuaTypes luaTypes = default(LuaTypes);
			while (true)
			{
				int num = 1837138123;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x6A4ED828)) % 6)
					{
					case 4u:
						break;
					case 3u:
						luaTypes = LuaDLL.lua_type(L, 1);
						num = ((int)num2 * -751617850) ^ -723387840;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (luaTypes == LuaTypes.LUA_TTABLE)
						{
							num3 = 1995707785;
							num4 = num3;
						}
						else
						{
							num3 = 1674101026;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -846764082);
						continue;
					}
					case 5u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(458265734u));
						num = (int)((num2 * 27475419) ^ 0xF358A78);
						continue;
					case 2u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3078170260u));
						num = 1648739303;
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
		LuaScriptMgr.Push(L, _200C_200F_206E_200D_202A_206C_206C_202A_200E_200C_202C_200B_206B_206A_202B_202D_202C_206B_200D_206A_200B_200F_202C_200D_200D_200F_206D_200D_206A_206B_206A_206E_202B_200E_202B_206D_200B_206E_202C_206E_202E(val));
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_enabled(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Collider val = (Collider)luaObject;
		if (_200C_206D_206C_206B_202B_206A_206D_200B_206D_200D_200B_202A_200C_200D_206F_206F_200F_202D_206B_202C_206B_200B_202D_206F_202D_206E_206A_200F_202B_206A_206F_200B_202D_200C_206F_206B_206F_202D_200C_206D_202E((Object)(object)val, (Object)null))
		{
			goto IL_001b;
		}
		goto IL_00ae;
		IL_001b:
		int num = -1201099093;
		goto IL_0020;
		IL_0020:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -2092243122)) % 7)
			{
			case 6u:
				break;
			case 2u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2562779632u));
				num = -2079836805;
				continue;
			case 1u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3927089387u));
				num = ((int)num2 * -1907376075) ^ 0x75383416;
				continue;
			case 4u:
			{
				LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
				int num3;
				int num4;
				if (luaTypes != LuaTypes.LUA_TTABLE)
				{
					num3 = -1892414180;
					num4 = num3;
				}
				else
				{
					num3 = -579188907;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -2044174916);
				continue;
			}
			case 3u:
				goto IL_00ae;
			case 0u:
				num = ((int)num2 * -305798608) ^ 0x4163446B;
				continue;
			default:
				return 0;
			}
			break;
		}
		goto IL_001b;
		IL_00ae:
		_202A_206D_200D_206E_202A_200F_206E_206E_206F_206A_206F_206F_200D_200D_206C_200B_202C_206E_202C_206C_206D_202B_202C_206F_200F_202E_206E_200F_200E_206A_202E_202E_206E_200F_200F_206B_200C_202D_202B_206F_202E(val, LuaScriptMgr.GetBoolean(L, 3));
		num = -1323959770;
		goto IL_0020;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_isTrigger(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Collider val = (Collider)luaObject;
		if (_200C_206D_206C_206B_202B_206A_206D_200B_206D_200D_200B_202A_200C_200D_206F_206F_200F_202D_206B_202C_206B_200B_202D_206F_202D_206E_206A_200F_202B_206A_206F_200B_202D_200C_206F_206B_206F_202D_200C_206D_202E((Object)(object)val, (Object)null))
		{
			goto IL_0018;
		}
		goto IL_0072;
		IL_0018:
		int num = 295100206;
		goto IL_001d;
		IL_001d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x7355E260)) % 7)
			{
			case 0u:
				break;
			case 5u:
			{
				LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
				int num3;
				int num4;
				if (luaTypes != LuaTypes.LUA_TTABLE)
				{
					num3 = 1809035136;
					num4 = num3;
				}
				else
				{
					num3 = 1764702311;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 467336372);
				continue;
			}
			case 6u:
				goto IL_0072;
			case 2u:
				num = (int)(num2 * 71627191) ^ -205841698;
				continue;
			case 4u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(883803926u));
				num = ((int)num2 * -1092979947) ^ -1466273577;
				continue;
			case 3u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2598908289u));
				num = 4938234;
				continue;
			default:
				return 0;
			}
			break;
		}
		goto IL_0018;
		IL_0072:
		_202B_202A_202C_206B_206E_206A_206B_206C_206B_200F_202A_202D_206C_200C_200F_206B_202E_200B_202C_202C_200B_206A_206B_206C_200D_206D_206D_206A_206E_200E_200C_206E_200D_202B_200F_206B_200C_200F_200E_206D_202E(val, LuaScriptMgr.GetBoolean(L, 3));
		num = 2120191216;
		goto IL_001d;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_contactOffset(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Collider val = (Collider)luaObject;
		if (_200C_206D_206C_206B_202B_206A_206D_200B_206D_200D_200B_202A_200C_200D_206F_206F_200F_202D_206B_202C_206B_200B_202D_206F_202D_206E_206A_200F_202B_206A_206F_200B_202D_200C_206F_206B_206F_202D_200C_206D_202E((Object)(object)val, (Object)null))
		{
			goto IL_001b;
		}
		goto IL_00b1;
		IL_001b:
		int num = -1614175197;
		goto IL_0020;
		IL_0020:
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -582914694)) % 8)
			{
			case 4u:
				break;
			case 0u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(210945854u));
				num = -172281145;
				continue;
			case 6u:
			{
				int num3;
				int num4;
				if (luaTypes != LuaTypes.LUA_TTABLE)
				{
					num3 = -799004230;
					num4 = num3;
				}
				else
				{
					num3 = -803632195;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -1261257892);
				continue;
			}
			case 1u:
				luaTypes = LuaDLL.lua_type(L, 1);
				num = (int)((num2 * 109636338) ^ 0x4E46ECAE);
				continue;
			case 3u:
				num = (int)(num2 * 1734058295) ^ -756406814;
				continue;
			case 5u:
				goto IL_00b1;
			case 7u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4247373176u));
				num = ((int)num2 * -149822185) ^ -189849792;
				continue;
			default:
				return 0;
			}
			break;
		}
		goto IL_001b;
		IL_00b1:
		_202A_206A_202C_202C_200E_202B_200D_200B_206E_202C_206C_206D_206C_202B_206D_200E_206C_206A_202A_206A_206E_206F_206C_206D_206D_202E_206A_206F_206E_200E_202D_200C_206D_202A_202C_202E_200E_200E_202D_206B_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
		num = -92528848;
		goto IL_0020;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_material(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Collider val = (Collider)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1292806288;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x75EB4C79)) % 8)
				{
				case 2u:
					break;
				case 1u:
				{
					int num5;
					int num6;
					if (!_200C_206D_206C_206B_202B_206A_206D_200B_206D_200D_200B_202A_200C_200D_206F_206F_200F_202D_206B_202C_206B_200B_202D_206F_202D_206E_206A_200F_202B_206A_206F_200B_202D_200C_206F_206B_206F_202D_200C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = 619190987;
						num6 = num5;
					}
					else
					{
						num5 = 2032848729;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -10072427);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3025432925u));
					num = 1368073046;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -251908854;
						num4 = num3;
					}
					else
					{
						num3 = -330218921;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -196610994);
					continue;
				}
				case 7u:
					_202B_202E_202E_202A_200B_206B_202A_202B_206B_202E_200E_202C_206F_202C_202A_200F_206E_200B_202B_200F_206B_202B_206A_202D_206B_202D_200C_202A_200F_202A_200D_202D_200D_200D_200B_202D_202A_200B_200E_206D_202E(val, (PhysicMaterial)LuaScriptMgr.GetUnityObject(L, 3, _202B_200C_206F_206E_206B_206C_202B_202B_200E_200C_202B_200B_202D_200F_200B_206E_200C_200C_202D_200E_202E_206E_200C_206C_200C_206D_202A_206F_200E_202B_202D_202E_206E_202E_200C_200D_200D_200B_206A_200C_202E(typeof(PhysicMaterial).TypeHandle)));
					num = 936805993;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2667657626u));
					num = (int)(num2 * 1091676253) ^ -16202104;
					continue;
				case 5u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -9147100) ^ 0x9BE8A99;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_sharedMaterial(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Collider val = default(Collider);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -24230570;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1047598539)) % 7)
				{
				case 6u:
					break;
				case 1u:
				{
					val = (Collider)luaObject;
					int num5;
					int num6;
					if (_200C_206D_206C_206B_202B_206A_206D_200B_206D_200D_200B_202A_200C_200D_206F_206F_200F_202D_206B_202C_206B_200B_202D_206F_202D_206E_206A_200F_202B_206A_206F_200B_202D_200C_206F_206B_206F_202D_200C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = -258162125;
						num6 = num5;
					}
					else
					{
						num5 = -1047276950;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 2021482251);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1319465407u));
					num = ((int)num2 * -2119594475) ^ 0x713A25FD;
					continue;
				case 0u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -679427910) ^ 0x350ACDA8;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2000364400u));
					num = -1058565077;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -1687498796;
						num4 = num3;
					}
					else
					{
						num3 = -22782765;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 992915645);
					continue;
				}
				default:
					_200D_202D_206C_206B_206D_206B_202A_202A_206D_206E_202B_206A_202A_202C_202B_202A_206D_202B_200C_206C_200F_206C_202E_206E_206B_202D_202C_202D_206F_200B_206E_206A_202A_206C_206D_202B_202A_206C_200F_202C_202E(val, (PhysicMaterial)LuaScriptMgr.GetUnityObject(L, 3, _202B_200C_206F_206E_206B_206C_202B_202B_200E_200C_202B_200B_202D_200F_200B_206E_200C_200C_202D_200E_202E_206E_200C_206C_200C_206D_202A_206F_200E_202B_202D_202E_206E_202E_200C_200D_200D_200B_206A_200C_202E(typeof(PhysicMaterial).TypeHandle)));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int ClosestPointOnBounds(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr.CheckArgsCount(L, 2);
		Collider val = (Collider)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(214850581u));
		Vector3 vector = default(Vector3);
		Vector3 v = default(Vector3);
		while (true)
		{
			int num = -1489750963;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1556901751)) % 5)
				{
				case 2u:
					break;
				case 1u:
					vector = LuaScriptMgr.GetVector3(L, 2);
					num = (int)((num2 * 988570145) ^ 0x576FF097);
					continue;
				case 3u:
					v = _202D_202A_202B_202C_206E_200D_202D_200B_206C_206D_200B_200F_202C_202D_200C_206F_200B_202A_202B_202B_200B_206A_200E_202C_200F_206F_206D_202D_206A_206F_206A_206F_206E_200B_206C_202A_200E_206E_200D_202D_202E(val, vector);
					num = ((int)num2 * -1970541216) ^ -1619868810;
					continue;
				case 0u:
					LuaScriptMgr.Push(L, v);
					num = ((int)num2 * -154924804) ^ -162210784;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Raycast(IntPtr L)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr.CheckArgsCount(L, 4);
		bool b = default(bool);
		Collider val = default(Collider);
		Ray ray = default(Ray);
		RaycastHit hit = default(RaycastHit);
		float num3 = default(float);
		while (true)
		{
			int num = -1306042658;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1271961375)) % 5)
				{
				case 3u:
					break;
				case 4u:
					LuaScriptMgr.Push(L, b);
					num = (int)((num2 * 1780045484) ^ 0x23D441A1);
					continue;
				case 0u:
					b = _206D_200F_206A_206D_202A_206E_200B_206B_200D_202B_206F_200D_202B_202D_206A_202D_206B_200F_200C_202B_200F_202A_206A_202B_206E_206F_202C_206B_202B_206F_200E_200C_202A_206A_206D_200E_206F_200F_202A_202E_202E(val, ray, ref hit, num3);
					num = ((int)num2 * -82818564) ^ 0x2C6C3E2E;
					continue;
				case 1u:
					val = (Collider)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3842128580u));
					ray = LuaScriptMgr.GetRay(L, 2);
					num3 = (float)LuaScriptMgr.GetNumber(L, 4);
					num = ((int)num2 * -1662390888) ^ 0x11AE425C;
					continue;
				default:
					LuaScriptMgr.Push(L, hit);
					return 2;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Lua_Eq(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Object val2 = default(Object);
		bool b = default(bool);
		while (true)
		{
			int num = 755369454;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5A74A505)) % 4)
				{
				case 0u:
					break;
				case 3u:
				{
					object luaObject2 = LuaScriptMgr.GetLuaObject(L, 1);
					val2 = (Object)((luaObject2 is Object) ? luaObject2 : null);
					num = ((int)num2 * -1228773057) ^ 0x1D23144A;
					continue;
				}
				case 2u:
				{
					object luaObject = LuaScriptMgr.GetLuaObject(L, 2);
					Object val = (Object)((luaObject is Object) ? luaObject : null);
					b = _200C_206D_206C_206B_202B_206A_206D_200B_206D_200D_200B_202A_200C_200D_206F_206F_200F_202D_206B_202C_206B_200B_202D_206F_202D_206E_206A_200F_202B_206A_206F_200B_202D_200C_206F_206B_206F_202D_200C_206D_202E(val2, val);
					num = ((int)num2 * -1120648314) ^ -1355304660;
					continue;
				}
				default:
					LuaScriptMgr.Push(L, b);
					return 1;
				}
				break;
			}
		}
	}

	static Type _202B_200C_206F_206E_206B_206C_202B_202B_200E_200C_202B_200B_202D_200F_200B_206E_200C_200C_202D_200E_202E_206E_200C_206C_200C_206D_202A_206F_200E_202B_202D_202E_206E_202E_200C_200D_200D_200B_206A_200C_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static Collider _200E_202A_200D_206E_200F_206E_200D_206B_206F_206F_200D_200F_206C_200C_200F_200E_200B_206D_200C_206F_206B_202A_200B_202C_202D_200B_200B_206F_200D_206C_206C_202B_202D_206D_200F_200F_206C_202B_202C_206D_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Collider();
	}

	static bool _200C_206D_206C_206B_202B_206A_206D_200B_206D_200D_200B_202A_200C_200D_206F_206F_200F_202D_206B_202C_206B_200B_202D_206F_202D_206E_206A_200F_202B_206A_206F_200B_202D_200C_206F_206B_206F_202D_200C_206D_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static bool _202C_202C_202A_202B_200B_206E_206F_202E_202E_202E_206E_206F_206B_202E_202A_202E_200E_200D_206D_206B_200D_206B_202C_202D_206A_206B_206D_202E_202E_200B_200E_206C_200D_206F_206B_206F_202E_200B_206B_200D_202E(Collider P_0)
	{
		return P_0.enabled;
	}

	static Rigidbody _206C_202E_202B_202A_202C_206A_206B_206E_200B_206B_202A_206A_200E_202D_206B_206D_202A_200D_206E_202E_200E_202C_200C_200B_202A_200B_206C_206F_206D_206C_206A_206C_200D_200D_200F_202C_202B_202D_202D_206C_202E(Collider P_0)
	{
		return P_0.attachedRigidbody;
	}

	static bool _206B_206B_206E_200E_200E_202D_200C_206E_202B_200C_202A_200F_206C_200E_206D_206B_206A_202C_200B_200D_206E_202D_206B_202A_206F_206B_206F_202A_200E_202C_202A_202E_200F_202E_200B_200C_206E_200D_202D_206C_202E(Collider P_0)
	{
		return P_0.isTrigger;
	}

	static float _206B_200E_200F_200F_202A_206E_200E_206F_202D_200F_200E_206B_206B_200E_202B_200B_206F_206B_206A_202E_200E_202D_206D_200C_202E_202E_200E_206A_206C_202B_202D_200B_206A_202E_206C_206B_206E_200B_202A_202E(Collider P_0)
	{
		return P_0.contactOffset;
	}

	static PhysicMaterial _206B_206D_206B_206E_200E_200D_202B_202D_202B_200E_206C_206C_200F_206C_206F_202E_202E_206E_200E_202E_200C_206B_202A_202E_206F_202E_206E_206A_206B_200B_206D_206A_202B_200D_200B_200C_202D_206D_206F_206C_202E(Collider P_0)
	{
		return P_0.material;
	}

	static PhysicMaterial _200D_206F_206F_202D_202E_206D_202C_206A_200C_206D_200E_202C_200B_200E_206C_206A_202E_206A_200E_202A_206C_206A_202A_200C_206E_202B_202B_206F_200B_202B_202A_202E_206D_200B_202E_200C_206A_206D_200C_200C_202E(Collider P_0)
	{
		return P_0.sharedMaterial;
	}

	static Bounds _200C_200F_206E_200D_202A_206C_206C_202A_200E_200C_202C_200B_206B_206A_202B_202D_202C_206B_200D_206A_200B_200F_202C_200D_200D_200F_206D_200D_206A_206B_206A_206E_202B_200E_202B_206D_200B_206E_202C_206E_202E(Collider P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.bounds;
	}

	static void _202A_206D_200D_206E_202A_200F_206E_206E_206F_206A_206F_206F_200D_200D_206C_200B_202C_206E_202C_206C_206D_202B_202C_206F_200F_202E_206E_200F_200E_206A_202E_202E_206E_200F_200F_206B_200C_202D_202B_206F_202E(Collider P_0, bool P_1)
	{
		P_0.enabled = P_1;
	}

	static void _202B_202A_202C_206B_206E_206A_206B_206C_206B_200F_202A_202D_206C_200C_200F_206B_202E_200B_202C_202C_200B_206A_206B_206C_200D_206D_206D_206A_206E_200E_200C_206E_200D_202B_200F_206B_200C_200F_200E_206D_202E(Collider P_0, bool P_1)
	{
		P_0.isTrigger = P_1;
	}

	static void _202A_206A_202C_202C_200E_202B_200D_200B_206E_202C_206C_206D_206C_202B_206D_200E_206C_206A_202A_206A_206E_206F_206C_206D_206D_202E_206A_206F_206E_200E_202D_200C_206D_202A_202C_202E_200E_200E_202D_206B_202E(Collider P_0, float P_1)
	{
		P_0.contactOffset = P_1;
	}

	static void _202B_202E_202E_202A_200B_206B_202A_202B_206B_202E_200E_202C_206F_202C_202A_200F_206E_200B_202B_200F_206B_202B_206A_202D_206B_202D_200C_202A_200F_202A_200D_202D_200D_200D_200B_202D_202A_200B_200E_206D_202E(Collider P_0, PhysicMaterial P_1)
	{
		P_0.material = P_1;
	}

	static void _200D_202D_206C_206B_206D_206B_202A_202A_206D_206E_202B_206A_202A_202C_202B_202A_206D_202B_200C_206C_200F_206C_202E_206E_206B_202D_202C_202D_206F_200B_206E_206A_202A_206C_206D_202B_202A_206C_200F_202C_202E(Collider P_0, PhysicMaterial P_1)
	{
		P_0.sharedMaterial = P_1;
	}

	static Vector3 _202D_202A_202B_202C_206E_200D_202D_200B_206C_206D_200B_200F_202C_202D_200C_206F_200B_202A_202B_202B_200B_206A_200E_202C_200F_206F_206D_202D_206A_206F_206A_206F_206E_200B_206C_202A_200E_206E_200D_202D_202E(Collider P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return P_0.ClosestPointOnBounds(P_1);
	}

	static bool _206D_200F_206A_206D_202A_206E_200B_206B_200D_202B_206F_200D_202B_202D_206A_202D_206B_200F_200C_202B_200F_202A_206A_202B_206E_206F_202C_206B_202B_206F_200E_200C_202A_206A_206D_200E_206F_200F_202A_202E_202E(Collider P_0, Ray P_1, ref RaycastHit P_2, float P_3)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.Raycast(P_1, ref P_2, P_3);
	}
}
