using System;
using LuaInterface;
using UnityEngine;

public class CharacterControllerWrap
{
	private static Type classType = _202C_206B_200B_206D_202B_200F_200C_202B_202B_200E_206C_202A_200C_200E_206D_202D_200C_200D_200D_206A_200B_202C_200C_206E_200D_206E_200C_202C_200D_200C_206E_206A_202B_200F_206B_200B_202B_200D_200E_206D_202E(typeof(CharacterController).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[5]
		{
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3185668999u), SimpleMove),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1655598178u), Move),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2904731379u), _206E_200F_200D_200F_200C_200E_202B_202D_206B_202D_200E_200F_202D_202A_200C_202C_200B_200F_206E_202B_206E_206E_206C_206A_206B_200B_200E_200C_200C_202A_206E_202C_202D_206F_206B_206A_202C_200C_206B_200F_202E),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2783592835u), GetClassType),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3747390401u), Lua_Eq)
		};
		LuaField[] fields = default(LuaField[]);
		while (true)
		{
			int num = 43321715;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x495F4D14)) % 4)
				{
				case 2u:
					break;
				default:
					return;
				case 3u:
					fields = new LuaField[10]
					{
						new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2346526757u), get_isGrounded, null),
						new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3033973237u), get_velocity, null),
						new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2742625692u), get_collisionFlags, null),
						new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4013727494u), get_radius, set_radius),
						new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2090464212u), get_height, set_height),
						new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4107921568u), get_center, set_center),
						new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(230149824u), get_slopeLimit, set_slopeLimit),
						new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(72250551u), get_stepOffset, set_stepOffset),
						new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2997793506u), get_skinWidth, set_skinWidth),
						new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3600759422u), get_detectCollisions, set_detectCollisions)
					};
					num = ((int)num2 * -108450269) ^ 0x1FB5FCE5;
					continue;
				case 0u:
					LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3123980101u), _202C_206B_200B_206D_202B_200F_200C_202B_202B_200E_206C_202A_200C_200E_206D_202D_200C_200D_200D_206A_200B_202C_200C_206E_200D_206E_200C_202C_200D_200C_206E_206A_202B_200F_206B_200B_202B_200D_200E_206D_202E(typeof(CharacterController).TypeHandle), regs, fields, _202C_206B_200B_206D_202B_200F_200C_202B_202B_200E_206C_202A_200C_200E_206D_202D_200C_200D_200D_206A_200B_202C_200C_206E_200D_206E_200C_202C_200D_200C_206E_206A_202B_200F_206B_200B_202B_200D_200E_206D_202E(typeof(Collider).TypeHandle));
					num = (int)(num2 * 2081925309) ^ -755391795;
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _206E_200F_200D_200F_200C_200E_202B_202D_206B_202D_200E_200F_202D_202A_200C_202C_200B_200F_206E_202B_206E_206E_206C_206A_206B_200B_200E_200C_200C_202A_206E_202C_202D_206F_206B_206A_202C_200C_206B_200F_202E(IntPtr P_0)
	{
		int num = LuaDLL.lua_gettop(P_0);
		CharacterController obj = default(CharacterController);
		while (true)
		{
			int num2 = -656590855;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1165291055)) % 6)
				{
				case 0u:
					break;
				case 4u:
				{
					int num4;
					int num5;
					if (num != 0)
					{
						num4 = -1445370188;
						num5 = num4;
					}
					else
					{
						num4 = -1063058664;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 704438918);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(P_0, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3471156471u));
					num2 = -942662537;
					continue;
				case 1u:
					obj = _200C_202B_200D_200D_200E_200D_206B_200D_200B_200F_200C_202B_200D_200C_202E_200F_202C_200D_206C_202A_202B_200C_202E_202D_202B_200E_200E_206C_206E_202A_200B_202A_206E_202D_202D_206E_202D_200B_200E_206A_202E();
					num2 = ((int)num3 * -56688646) ^ -1524465480;
					continue;
				case 5u:
					LuaScriptMgr.Push(P_0, (Object)(object)obj);
					return 1;
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
	private static int get_isGrounded(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		CharacterController val = (CharacterController)luaObject;
		while (true)
		{
			int num = -763178029;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -539382764)) % 8)
				{
				case 0u:
					break;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(590644092u));
					num = -1950522704;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2657650291u));
					num = ((int)num2 * -943336714) ^ 0x354998C5;
					continue;
				case 2u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 1469459670;
						num6 = num5;
					}
					else
					{
						num5 = 1058194307;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1484703694);
					continue;
				}
				case 5u:
					num = ((int)num2 * -920781803) ^ -786752903;
					continue;
				case 4u:
					LuaScriptMgr.Push(L, _202A_206B_202B_206A_200F_200D_202E_206A_206C_206F_202C_206A_202E_206C_200E_202D_202E_206D_200C_206F_202A_202A_206F_206E_206C_206F_200C_206C_202C_206B_202C_200B_202D_206B_202B_206D_200B_200F_206B_202E_202E(val));
					num = -1461144947;
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (!_200B_200B_206D_202A_200D_200D_206A_206F_200B_200C_200C_202C_206A_206E_206C_206F_202D_200C_202C_206E_202A_206D_206D_200D_202D_202D_200E_202B_206E_202A_206D_206A_202C_206A_200B_202B_206D_206C_206C_200E_202E((Object)(object)val, (Object)null))
					{
						num3 = -1826814144;
						num4 = num3;
					}
					else
					{
						num3 = -1711981698;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1308576400);
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
	private static int get_velocity(IntPtr L)
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		CharacterController val = default(CharacterController);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 657406506;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x49210EBC)) % 10)
				{
				case 2u:
					break;
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3784794907u));
					num = (int)((num2 * 1537662800) ^ 0x1CCCD5D5);
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (_200B_200B_206D_202A_200D_200D_206A_206F_200B_200C_200C_202C_206A_206E_206C_206F_202D_200C_202C_206E_202A_206D_206D_200D_202D_202D_200E_202B_206E_202A_206D_206A_202C_206A_200B_202B_206D_206C_206C_200E_202E((Object)(object)val, (Object)null))
					{
						num5 = -95634401;
						num6 = num5;
					}
					else
					{
						num5 = -1023046874;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1920064007);
					continue;
				}
				case 1u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1958724918) ^ 0x778E93EF;
					continue;
				case 0u:
					LuaScriptMgr.Push(L, _202D_200C_206F_202C_202D_202E_200F_206A_202B_206B_202C_206B_200B_202A_206F_206D_206D_206D_206B_206A_200C_200D_206E_206C_200E_200D_200F_202E_206F_202E_202A_202A_200E_200B_200B_202A_206E_202B_206D_200C_202E(val));
					num = 963288637;
					continue;
				case 6u:
					val = (CharacterController)luaObject;
					num = ((int)num2 * -8427806) ^ 0x7D0ABEBE;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4286877202u));
					num = 859939876;
					continue;
				case 9u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -1067062670;
						num4 = num3;
					}
					else
					{
						num3 = -1833584141;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1849418369);
					continue;
				}
				case 3u:
					num = (int)(num2 * 393120425) ^ -399959211;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_collisionFlags(IntPtr L)
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		CharacterController val = default(CharacterController);
		while (true)
		{
			int num = -1247233744;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1462356012)) % 8)
				{
				case 2u:
					break;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2654066095u));
					num = -767138563;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(138593585u));
					num = (int)((num2 * 1813056789) ^ 0x3D072A5C);
					continue;
				case 0u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1004748201) ^ -1611409889;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -1985241671;
						num6 = num5;
					}
					else
					{
						num5 = -1308839134;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -220401671);
					continue;
				}
				case 1u:
					LuaScriptMgr.Push(L, (Enum)(object)_206C_206A_206F_200F_200F_202E_202E_202C_206C_206D_206E_202D_206E_206F_200B_206E_202E_206C_200E_202B_206A_200C_200B_200E_206D_202D_200D_202B_206B_202D_202C_206B_202E_200C_200E_200F_200E_200B_206E_202A_202E(val));
					num = -1689830149;
					continue;
				case 4u:
				{
					val = (CharacterController)luaObject;
					int num3;
					int num4;
					if (_200B_200B_206D_202A_200D_200D_206A_206F_200B_200C_200C_202C_206A_206E_206C_206F_202D_200C_202C_206E_202A_206D_206D_200D_202D_202D_200E_202B_206E_202A_206D_206A_202C_206A_200B_202B_206D_206C_206C_200E_202E((Object)(object)val, (Object)null))
					{
						num3 = 1785876880;
						num4 = num3;
					}
					else
					{
						num3 = 272746625;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -55991913);
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
	private static int get_radius(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		CharacterController val = (CharacterController)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -575481928;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1306647422)) % 8)
				{
				case 5u:
					break;
				case 2u:
				{
					int num5;
					int num6;
					if (_200B_200B_206D_202A_200D_200D_206A_206F_200B_200C_200C_202C_206A_206E_206C_206F_202D_200C_202C_206E_202A_206D_206D_200D_202D_202D_200E_202B_206E_202A_206D_206A_202C_206A_200B_202B_206D_206C_206C_200E_202E((Object)(object)val, (Object)null))
					{
						num5 = 1142785954;
						num6 = num5;
					}
					else
					{
						num5 = 1384688392;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -928999149);
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 1091610419;
						num4 = num3;
					}
					else
					{
						num3 = 1446175129;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1955724848);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(566084319u));
					num = -1443161018;
					continue;
				case 6u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 33419355) ^ -64311000;
					continue;
				case 4u:
					LuaScriptMgr.Push(L, _200D_206C_202D_206F_206F_206F_202D_206D_206B_202D_206F_200D_202B_206C_202D_206B_202E_206A_202E_202A_206E_206A_206A_202D_200C_202E_200B_202B_206C_202A_206F_206B_202E_206C_202B_200B_202E_206E_206F_200E_202E(val));
					num = -1040186467;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1487571814u));
					num = (int)((num2 * 1373601193) ^ 0x6858F9F);
					continue;
				default:
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
		CharacterController val = (CharacterController)luaObject;
		if (_200B_200B_206D_202A_200D_200D_206A_206F_200B_200C_200C_202C_206A_206E_206C_206F_202D_200C_202C_206E_202A_206D_206D_200D_202D_202D_200E_202B_206E_202A_206D_206A_202C_206A_200B_202B_206D_206C_206C_200E_202E((Object)(object)val, (Object)null))
		{
			goto IL_001b;
		}
		goto IL_00a6;
		IL_001b:
		int num = -330444963;
		goto IL_0020;
		IL_0020:
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1809209512)) % 7)
			{
			case 5u:
				break;
			case 3u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(109769594u));
				num = (int)(num2 * 994864988) ^ -1895058425;
				continue;
			case 4u:
			{
				int num3;
				int num4;
				if (luaTypes != LuaTypes.LUA_TTABLE)
				{
					num3 = 394894394;
					num4 = num3;
				}
				else
				{
					num3 = 1502272447;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 268100523);
				continue;
			}
			case 2u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4253976215u));
				num = -2131849933;
				continue;
			case 0u:
				goto IL_00a6;
			case 6u:
				luaTypes = LuaDLL.lua_type(L, 1);
				num = ((int)num2 * -733128763) ^ -1916697003;
				continue;
			default:
				return 1;
			}
			break;
		}
		goto IL_001b;
		IL_00a6:
		LuaScriptMgr.Push(L, _200E_206E_202C_200B_202A_202C_206F_200C_202E_200E_206B_206F_206E_202A_202A_200D_202B_202A_200B_206F_200F_200C_202D_202D_200B_202E_200E_202A_200F_206D_206C_202D_200F_202E_200B_202E_206E_206A_206C_200F_202E(val));
		num = -1653842221;
		goto IL_0020;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_center(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		CharacterController val = (CharacterController)luaObject;
		if (_200B_200B_206D_202A_200D_200D_206A_206F_200B_200C_200C_202C_206A_206E_206C_206F_202D_200C_202C_206E_202A_206D_206D_200D_202D_202D_200E_202B_206E_202A_206D_206A_202C_206A_200B_202B_206D_206C_206C_200E_202E((Object)(object)val, (Object)null))
		{
			goto IL_0018;
		}
		goto IL_0089;
		IL_0018:
		int num = -740680533;
		goto IL_001d;
		IL_001d:
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -87806014)) % 7)
			{
			case 0u:
				break;
			case 3u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3279143176u));
				num = ((int)num2 * -1527604046) ^ 0x3B89BB22;
				continue;
			case 1u:
			{
				int num3;
				int num4;
				if (luaTypes != LuaTypes.LUA_TTABLE)
				{
					num3 = 672758466;
					num4 = num3;
				}
				else
				{
					num3 = 2092296251;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -81769608);
				continue;
			}
			case 2u:
				goto IL_0089;
			case 5u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4210481920u));
				num = -1422994768;
				continue;
			case 4u:
				luaTypes = LuaDLL.lua_type(L, 1);
				num = (int)((num2 * 888691186) ^ 0x7DF6658F);
				continue;
			default:
				return 1;
			}
			break;
		}
		goto IL_0018;
		IL_0089:
		LuaScriptMgr.Push(L, _200F_206A_200C_206E_206C_200E_206E_206A_206A_206C_200B_202E_200F_206A_200F_200C_200B_200D_200F_202D_200F_206F_202C_206A_206B_202D_206D_200B_200E_200B_202B_206D_206E_200C_202C_202E_200D_202A_206D_202A_202E(val));
		num = -2046691240;
		goto IL_001d;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_slopeLimit(IntPtr L)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		CharacterController val = default(CharacterController);
		while (true)
		{
			int num = 1079111139;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6C408121)) % 9)
				{
				case 7u:
					break;
				case 1u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 107549585;
						num6 = num5;
					}
					else
					{
						num5 = 1278231216;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 648946131);
					continue;
				}
				case 2u:
				{
					int num3;
					int num4;
					if (!_200B_200B_206D_202A_200D_200D_206A_206F_200B_200C_200C_202C_206A_206E_206C_206F_202D_200C_202C_206E_202A_206D_206D_200D_202D_202D_200E_202B_206E_202A_206D_206A_202C_206A_200B_202B_206D_206C_206C_200E_202E((Object)(object)val, (Object)null))
					{
						num3 = 55014264;
						num4 = num3;
					}
					else
					{
						num3 = 1036622520;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1997699381);
					continue;
				}
				case 5u:
					num = (int)((num2 * 1586306497) ^ 0x318F246B);
					continue;
				case 8u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 761625659) ^ -1193831859;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(533898960u));
					num = ((int)num2 * -496253870) ^ -1783381934;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(556485793u));
					num = 1917437438;
					continue;
				case 6u:
					val = (CharacterController)luaObject;
					num = ((int)num2 * -1515171528) ^ -895467133;
					continue;
				default:
					LuaScriptMgr.Push(L, _202C_202C_206E_202B_200D_202C_202E_206D_202C_202E_206E_206B_202B_202B_206A_206F_202D_202E_200F_206A_200D_206F_206E_206C_202D_206E_206B_202D_206A_202C_200D_206F_206B_206B_206C_200C_206A_202D_206B_206C_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_stepOffset(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		CharacterController val = (CharacterController)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 471803830;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x747B8A2D)) % 8)
				{
				case 6u:
					break;
				case 0u:
					LuaScriptMgr.Push(L, _206F_202E_206A_206E_200C_200E_200E_202C_206A_200C_202B_202C_206F_202B_200B_200E_200B_200B_206D_200C_206B_202D_202A_206F_202D_206B_206D_202C_206F_200E_200E_206A_206D_200B_200C_202B_202C_200F_202A_202B_202E(val));
					num = 1381328754;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(90816421u));
					num = (int)((num2 * 399374442) ^ 0x6E41FAD5);
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(911253890u));
					num = 1117022173;
					continue;
				case 1u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -272220402) ^ -1315215770;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -1417513339;
						num6 = num5;
					}
					else
					{
						num5 = -742113781;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1733851370);
					continue;
				}
				case 3u:
				{
					int num3;
					int num4;
					if (_200B_200B_206D_202A_200D_200D_206A_206F_200B_200C_200C_202C_206A_206E_206C_206F_202D_200C_202C_206E_202A_206D_206D_200D_202D_202D_200E_202B_206E_202A_206D_206A_202C_206A_200B_202B_206D_206C_206C_200E_202E((Object)(object)val, (Object)null))
					{
						num3 = 1317467460;
						num4 = num3;
					}
					else
					{
						num3 = 1266757029;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 664945384);
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
	private static int get_skinWidth(IntPtr L)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		CharacterController val = default(CharacterController);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1612920301;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x28DED81C)) % 9)
				{
				case 0u:
					break;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1062195862u));
					num = ((int)num2 * -513334171) ^ -805716863;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (!_200B_200B_206D_202A_200D_200D_206A_206F_200B_200C_200C_202C_206A_206E_206C_206F_202D_200C_202C_206E_202A_206D_206D_200D_202D_202D_200E_202B_206E_202A_206D_206A_202C_206A_200B_202B_206D_206C_206C_200E_202E((Object)(object)val, (Object)null))
					{
						num5 = 2082790393;
						num6 = num5;
					}
					else
					{
						num5 = 1476641220;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1611820923);
					continue;
				}
				case 8u:
					val = (CharacterController)luaObject;
					num = (int)((num2 * 116581052) ^ 0x31CE433A);
					continue;
				case 3u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1019827807) ^ -1743156799;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 1770878830;
						num4 = num3;
					}
					else
					{
						num3 = 1437208596;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 508463348);
					continue;
				}
				case 6u:
					LuaScriptMgr.Push(L, _206C_202C_200D_206C_202C_200D_200D_202E_200D_200F_200F_202D_202D_202D_202E_202C_206E_200B_202A_200B_200F_200C_202A_206A_206E_202C_200B_206F_200F_206C_202D_202C_206E_206A_202D_202B_200D_206D_202C_200C_202E(val));
					num = 141974433;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3376833411u));
					num = 1531981383;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_detectCollisions(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		CharacterController val = default(CharacterController);
		while (true)
		{
			int num = 1239263861;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2C6B6681)) % 7)
				{
				case 0u:
					break;
				case 6u:
				{
					val = (CharacterController)luaObject;
					int num5;
					int num6;
					if (!_200B_200B_206D_202A_200D_200D_206A_206F_200B_200C_200C_202C_206A_206E_206C_206F_202D_200C_202C_206E_202A_206D_206D_200D_202D_202D_200E_202B_206E_202A_206D_206A_202C_206A_200B_202B_206D_206C_206C_200E_202E((Object)(object)val, (Object)null))
					{
						num5 = -835918835;
						num6 = num5;
					}
					else
					{
						num5 = -1667632646;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -893706244);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2652498126u));
					num = 1322494013;
					continue;
				case 3u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 1129539908;
						num4 = num3;
					}
					else
					{
						num3 = 365322704;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 730801009);
					continue;
				}
				case 2u:
					num = ((int)num2 * -1196799546) ^ -361774715;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1669379047u));
					num = ((int)num2 * -314430770) ^ 0x5F273651;
					continue;
				default:
					LuaScriptMgr.Push(L, _202B_206D_202A_206B_202A_200F_200B_206A_202E_202D_202E_202D_200B_200C_206D_202B_202C_202C_202C_206C_202B_206D_200B_202B_200E_206C_202B_200D_202C_202A_206F_200B_206E_200E_206D_202A_202B_206F_202A_202A_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_radius(IntPtr L)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		CharacterController val = default(CharacterController);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -513695873;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1679648556)) % 10)
				{
				case 4u:
					break;
				case 1u:
					val = (CharacterController)luaObject;
					num = (int)(num2 * 1735147941) ^ -247538742;
					continue;
				case 3u:
					num = (int)(num2 * 1132399380) ^ -1427940298;
					continue;
				case 7u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 641149205) ^ -75922575;
					continue;
				case 8u:
					_206B_202E_206A_202E_202B_202C_206D_200B_202C_202A_200D_206F_202A_206E_200E_206F_200B_206E_202C_202D_202A_206E_202A_200D_202D_202B_200E_202E_200E_200F_206D_200E_200D_202B_200B_200B_206B_200F_200E_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					num = -1824762438;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1487571814u));
					num = (int)((num2 * 1473770075) ^ 0x4DA3DB39);
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 1620135852;
						num6 = num5;
					}
					else
					{
						num5 = 1274204881;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1731841968);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2016815993u));
					num = -1798904110;
					continue;
				case 9u:
				{
					int num3;
					int num4;
					if (_200B_200B_206D_202A_200D_200D_206A_206F_200B_200C_200C_202C_206A_206E_206C_206F_202D_200C_202C_206E_202A_206D_206D_200D_202D_202D_200E_202B_206E_202A_206D_206A_202C_206A_200B_202B_206D_206C_206C_200E_202E((Object)(object)val, (Object)null))
					{
						num3 = -1069548303;
						num4 = num3;
					}
					else
					{
						num3 = -1238706216;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -2113729542);
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
		CharacterController val = (CharacterController)luaObject;
		if (_200B_200B_206D_202A_200D_200D_206A_206F_200B_200C_200C_202C_206A_206E_206C_206F_202D_200C_202C_206E_202A_206D_206D_200D_202D_202D_200E_202B_206E_202A_206D_206A_202C_206A_200B_202B_206D_206C_206C_200E_202E((Object)(object)val, (Object)null))
		{
			LuaTypes luaTypes = default(LuaTypes);
			while (true)
			{
				int num = -200626478;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -255160849)) % 7)
					{
					case 0u:
						break;
					case 4u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1538514994u));
						num = -1067550161;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (luaTypes != LuaTypes.LUA_TTABLE)
						{
							num3 = 1560106170;
							num4 = num3;
						}
						else
						{
							num3 = 1907094090;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -651448272);
						continue;
					}
					case 3u:
						num = ((int)num2 * -1078162876) ^ -377108821;
						continue;
					case 1u:
						luaTypes = LuaDLL.lua_type(L, 1);
						num = (int)(num2 * 1772802577) ^ -1971073336;
						continue;
					case 6u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3158219035u));
						num = ((int)num2 * -882013256) ^ -1475719450;
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
		_200C_206B_206A_200F_200D_206B_206D_206A_202B_202A_200B_206D_202A_202A_202E_200D_206B_200D_206E_202A_200B_202C_202E_206D_202C_206E_206E_202C_202D_200D_202D_202A_200F_206E_200C_202E_200B_200E_206B_200F_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_center(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		CharacterController val = (CharacterController)luaObject;
		if (_200B_200B_206D_202A_200D_200D_206A_206F_200B_200C_200C_202C_206A_206E_206C_206F_202D_200C_202C_206E_202A_206D_206D_200D_202D_202D_200E_202B_206E_202A_206D_206A_202C_206A_200B_202B_206D_206C_206C_200E_202E((Object)(object)val, (Object)null))
		{
			LuaTypes luaTypes = default(LuaTypes);
			while (true)
			{
				int num = 1302344052;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x393B0ECD)) % 6)
					{
					case 0u:
						break;
					case 3u:
						luaTypes = LuaDLL.lua_type(L, 1);
						num = (int)((num2 * 1506733338) ^ 0x7A65F238);
						continue;
					case 4u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(293089261u));
						num = ((int)num2 * -1781974353) ^ 0x768619B3;
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (luaTypes == LuaTypes.LUA_TTABLE)
						{
							num3 = -374700403;
							num4 = num3;
						}
						else
						{
							num3 = -499360600;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -1210052924);
						continue;
					}
					case 1u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4148971931u));
						num = 1486554999;
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
		_200C_200E_202E_202A_202C_202D_206C_200B_202E_206C_202A_202D_200C_206D_206C_206E_206F_206E_200C_202C_202C_200D_206C_200F_200B_200F_206F_206E_202B_206B_200F_206D_200F_200C_200C_202D_206A_202C_200F_206E_202E(val, LuaScriptMgr.GetVector3(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_slopeLimit(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		CharacterController val = default(CharacterController);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1092552680;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x755BC319)) % 8)
				{
				case 4u:
					break;
				case 1u:
				{
					val = (CharacterController)luaObject;
					int num5;
					int num6;
					if (!_200B_200B_206D_202A_200D_200D_206A_206F_200B_200C_200C_202C_206A_206E_206C_206F_202D_200C_202C_206E_202A_206D_206D_200D_202D_202D_200E_202B_206E_202A_206D_206A_202C_206A_200B_202B_206D_206C_206C_200E_202E((Object)(object)val, (Object)null))
					{
						num5 = 236477692;
						num6 = num5;
					}
					else
					{
						num5 = 324558223;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 227970949);
					continue;
				}
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2264028785u));
					num = (int)((num2 * 1594024054) ^ 0x9DEB933);
					continue;
				case 0u:
					_202E_206E_206B_200D_206D_200D_202D_206D_200F_202E_202C_200B_200D_206F_206C_200B_206D_202D_202E_206D_202C_200C_206E_202B_206F_200F_200F_200E_206C_200F_202D_200B_202D_200C_206F_200F_206E_200C_202B_202B_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					num = 869100091;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -1193873950;
						num4 = num3;
					}
					else
					{
						num3 = -932671816;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 519008698);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1472621966u));
					num = 1038789833;
					continue;
				case 3u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 1815396073) ^ -636080380;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_stepOffset(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		CharacterController val = (CharacterController)luaObject;
		if (_200B_200B_206D_202A_200D_200D_206A_206F_200B_200C_200C_202C_206A_206E_206C_206F_202D_200C_202C_206E_202A_206D_206D_200D_202D_202D_200E_202B_206E_202A_206D_206A_202C_206A_200B_202B_206D_206C_206C_200E_202E((Object)(object)val, (Object)null))
		{
			while (true)
			{
				int num = -1735625855;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -2103615511)) % 6)
					{
					case 5u:
						break;
					case 2u:
					{
						LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
						int num3;
						int num4;
						if (luaTypes != LuaTypes.LUA_TTABLE)
						{
							num3 = -592293684;
							num4 = num3;
						}
						else
						{
							num3 = -1493828157;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -854667102);
						continue;
					}
					case 4u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(90816421u));
						num = (int)((num2 * 342176781) ^ 0x5B5DB764);
						continue;
					case 3u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2403663000u));
						num = -237348001;
						continue;
					case 1u:
						num = ((int)num2 * -1126832211) ^ -1457276468;
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
		_200D_206B_206C_202E_202A_202D_206E_200D_202A_206F_206B_206B_200D_202C_202E_202C_200F_200F_200C_206B_200D_206D_206C_202B_206E_202B_202D_200B_202D_200C_202C_206D_206D_206A_202C_206C_202B_206E_206B_202C_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_skinWidth(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		CharacterController val = default(CharacterController);
		while (true)
		{
			int num = 2059844587;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3FFBB82E)) % 7)
				{
				case 2u:
					break;
				case 1u:
				{
					val = (CharacterController)luaObject;
					int num5;
					int num6;
					if (!_200B_200B_206D_202A_200D_200D_206A_206F_200B_200C_200C_202C_206A_206E_206C_206F_202D_200C_202C_206E_202A_206D_206D_200D_202D_202D_200E_202B_206E_202A_206D_206A_202C_206A_200B_202B_206D_206C_206C_200E_202E((Object)(object)val, (Object)null))
					{
						num5 = -558030660;
						num6 = num5;
					}
					else
					{
						num5 = -1462827774;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1206646023);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1380883748u));
					num = (int)(num2 * 312259058) ^ -879954225;
					continue;
				case 0u:
					num = (int)((num2 * 232029333) ^ 0x6885DF44);
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3837457909u));
					num = 1130331169;
					continue;
				case 3u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 377572219;
						num4 = num3;
					}
					else
					{
						num3 = 483283049;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 13837551);
					continue;
				}
				default:
					_202B_200F_202A_200B_202A_206D_202E_206B_206B_206E_200F_200C_206A_202E_202D_200C_200F_206E_206C_206E_202A_202B_200E_200C_202C_200E_200E_200D_202B_200C_200F_206B_202C_206D_202B_200E_206F_206E_206D_202A_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_detectCollisions(IntPtr L)
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		CharacterController val = default(CharacterController);
		while (true)
		{
			int num = -1290419303;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -330127503)) % 7)
				{
				case 4u:
					break;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2652498126u));
					num = -419115470;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1669379047u));
					num = ((int)num2 * -963490374) ^ 0x1E63434;
					continue;
				case 6u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -494954828;
						num6 = num5;
					}
					else
					{
						num5 = -457053063;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -910978063);
					continue;
				}
				case 5u:
					_200B_206A_206F_202A_202B_200F_200E_206A_206D_200B_206B_200E_206C_200B_206D_206F_200E_202E_200C_206D_202A_202B_206F_206C_202B_202B_206D_202C_206B_206C_202D_206F_206D_200D_202C_202B_206A_206D_200E_206F_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					num = -1420612787;
					continue;
				case 1u:
				{
					val = (CharacterController)luaObject;
					int num3;
					int num4;
					if (_200B_200B_206D_202A_200D_200D_206A_206F_200B_200C_200C_202C_206A_206E_206C_206F_202D_200C_202C_206E_202A_206D_206D_200D_202D_202D_200E_202B_206E_202A_206D_206A_202C_206A_200B_202B_206D_206C_206C_200E_202E((Object)(object)val, (Object)null))
					{
						num3 = 1141790699;
						num4 = num3;
					}
					else
					{
						num3 = 1394167442;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1215368668);
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
	private static int SimpleMove(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr.CheckArgsCount(L, 2);
		CharacterController val = default(CharacterController);
		bool b = default(bool);
		while (true)
		{
			int num = 889421550;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x466B0289)) % 5)
				{
				case 4u:
					break;
				case 1u:
					val = (CharacterController)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2846049562u));
					num = (int)(num2 * 1416601420) ^ -1023923261;
					continue;
				case 0u:
					LuaScriptMgr.Push(L, b);
					num = ((int)num2 * -305915097) ^ 0x25E2A4E6;
					continue;
				case 2u:
				{
					Vector3 vector = LuaScriptMgr.GetVector3(L, 2);
					b = _206E_202B_200C_200D_200B_206C_206D_206E_200D_200F_206D_206C_200D_206B_206D_202D_206D_206E_206C_202D_200E_202C_206E_206E_206C_200B_202E_200D_202D_202C_202B_202A_200B_202D_202B_200C_202C_206C_206A_206C_202E(val, vector);
					num = ((int)num2 * -1409835970) ^ 0x6C652A31;
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
	private static int Move(IntPtr L)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr.CheckArgsCount(L, 2);
		CollisionFlags val2 = default(CollisionFlags);
		CharacterController val = default(CharacterController);
		Vector3 vector = default(Vector3);
		while (true)
		{
			int num = -898125095;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1548065042)) % 5)
				{
				case 4u:
					break;
				case 1u:
					LuaScriptMgr.Push(L, (Enum)(object)val2);
					num = (int)((num2 * 36241109) ^ 0x7076100B);
					continue;
				case 3u:
					val2 = _206A_206D_206F_202A_202C_206B_200D_200F_200F_202C_202C_202B_206B_202C_200F_206E_200F_202B_200E_202B_200B_206F_206B_202D_200C_206F_202C_206B_202C_202D_202C_206E_206E_202E_202C_206B_200E_206F_200C_206D_202E(val, vector);
					num = (int)((num2 * 2121178187) ^ 0x46C1E177);
					continue;
				case 2u:
					val = (CharacterController)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2769485643u));
					vector = LuaScriptMgr.GetVector3(L, 2);
					num = ((int)num2 * -1679186359) ^ -1002944867;
					continue;
				default:
					return 1;
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
		object luaObject2 = LuaScriptMgr.GetLuaObject(L, 2);
		Object val2 = (Object)((luaObject2 is Object) ? luaObject2 : null);
		bool b = default(bool);
		while (true)
		{
			int num = -1382959680;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1711059774)) % 4)
				{
				case 0u:
					break;
				case 2u:
					b = _200B_200B_206D_202A_200D_200D_206A_206F_200B_200C_200C_202C_206A_206E_206C_206F_202D_200C_202C_206E_202A_206D_206D_200D_202D_202D_200E_202B_206E_202A_206D_206A_202C_206A_200B_202B_206D_206C_206C_200E_202E(val, val2);
					num = ((int)num2 * -753036499) ^ -1217938907;
					continue;
				case 1u:
					LuaScriptMgr.Push(L, b);
					num = ((int)num2 * -1245838341) ^ 0x666E93D6;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	static Type _202C_206B_200B_206D_202B_200F_200C_202B_202B_200E_206C_202A_200C_200E_206D_202D_200C_200D_200D_206A_200B_202C_200C_206E_200D_206E_200C_202C_200D_200C_206E_206A_202B_200F_206B_200B_202B_200D_200E_206D_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static CharacterController _200C_202B_200D_200D_200E_200D_206B_200D_200B_200F_200C_202B_200D_200C_202E_200F_202C_200D_206C_202A_202B_200C_202E_202D_202B_200E_200E_206C_206E_202A_200B_202A_206E_202D_202D_206E_202D_200B_200E_206A_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new CharacterController();
	}

	static bool _200B_200B_206D_202A_200D_200D_206A_206F_200B_200C_200C_202C_206A_206E_206C_206F_202D_200C_202C_206E_202A_206D_206D_200D_202D_202D_200E_202B_206E_202A_206D_206A_202C_206A_200B_202B_206D_206C_206C_200E_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static bool _202A_206B_202B_206A_200F_200D_202E_206A_206C_206F_202C_206A_202E_206C_200E_202D_202E_206D_200C_206F_202A_202A_206F_206E_206C_206F_200C_206C_202C_206B_202C_200B_202D_206B_202B_206D_200B_200F_206B_202E_202E(CharacterController P_0)
	{
		return P_0.isGrounded;
	}

	static Vector3 _202D_200C_206F_202C_202D_202E_200F_206A_202B_206B_202C_206B_200B_202A_206F_206D_206D_206D_206B_206A_200C_200D_206E_206C_200E_200D_200F_202E_206F_202E_202A_202A_200E_200B_200B_202A_206E_202B_206D_200C_202E(CharacterController P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.velocity;
	}

	static CollisionFlags _206C_206A_206F_200F_200F_202E_202E_202C_206C_206D_206E_202D_206E_206F_200B_206E_202E_206C_200E_202B_206A_200C_200B_200E_206D_202D_200D_202B_206B_202D_202C_206B_202E_200C_200E_200F_200E_200B_206E_202A_202E(CharacterController P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.collisionFlags;
	}

	static float _200D_206C_202D_206F_206F_206F_202D_206D_206B_202D_206F_200D_202B_206C_202D_206B_202E_206A_202E_202A_206E_206A_206A_202D_200C_202E_200B_202B_206C_202A_206F_206B_202E_206C_202B_200B_202E_206E_206F_200E_202E(CharacterController P_0)
	{
		return P_0.radius;
	}

	static float _200E_206E_202C_200B_202A_202C_206F_200C_202E_200E_206B_206F_206E_202A_202A_200D_202B_202A_200B_206F_200F_200C_202D_202D_200B_202E_200E_202A_200F_206D_206C_202D_200F_202E_200B_202E_206E_206A_206C_200F_202E(CharacterController P_0)
	{
		return P_0.height;
	}

	static Vector3 _200F_206A_200C_206E_206C_200E_206E_206A_206A_206C_200B_202E_200F_206A_200F_200C_200B_200D_200F_202D_200F_206F_202C_206A_206B_202D_206D_200B_200E_200B_202B_206D_206E_200C_202C_202E_200D_202A_206D_202A_202E(CharacterController P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.center;
	}

	static float _202C_202C_206E_202B_200D_202C_202E_206D_202C_202E_206E_206B_202B_202B_206A_206F_202D_202E_200F_206A_200D_206F_206E_206C_202D_206E_206B_202D_206A_202C_200D_206F_206B_206B_206C_200C_206A_202D_206B_206C_202E(CharacterController P_0)
	{
		return P_0.slopeLimit;
	}

	static float _206F_202E_206A_206E_200C_200E_200E_202C_206A_200C_202B_202C_206F_202B_200B_200E_200B_200B_206D_200C_206B_202D_202A_206F_202D_206B_206D_202C_206F_200E_200E_206A_206D_200B_200C_202B_202C_200F_202A_202B_202E(CharacterController P_0)
	{
		return P_0.stepOffset;
	}

	static float _206C_202C_200D_206C_202C_200D_200D_202E_200D_200F_200F_202D_202D_202D_202E_202C_206E_200B_202A_200B_200F_200C_202A_206A_206E_202C_200B_206F_200F_206C_202D_202C_206E_206A_202D_202B_200D_206D_202C_200C_202E(CharacterController P_0)
	{
		return P_0.skinWidth;
	}

	static bool _202B_206D_202A_206B_202A_200F_200B_206A_202E_202D_202E_202D_200B_200C_206D_202B_202C_202C_202C_206C_202B_206D_200B_202B_200E_206C_202B_200D_202C_202A_206F_200B_206E_200E_206D_202A_202B_206F_202A_202A_202E(CharacterController P_0)
	{
		return P_0.detectCollisions;
	}

	static void _206B_202E_206A_202E_202B_202C_206D_200B_202C_202A_200D_206F_202A_206E_200E_206F_200B_206E_202C_202D_202A_206E_202A_200D_202D_202B_200E_202E_200E_200F_206D_200E_200D_202B_200B_200B_206B_200F_200E_202E(CharacterController P_0, float P_1)
	{
		P_0.radius = P_1;
	}

	static void _200C_206B_206A_200F_200D_206B_206D_206A_202B_202A_200B_206D_202A_202A_202E_200D_206B_200D_206E_202A_200B_202C_202E_206D_202C_206E_206E_202C_202D_200D_202D_202A_200F_206E_200C_202E_200B_200E_206B_200F_202E(CharacterController P_0, float P_1)
	{
		P_0.height = P_1;
	}

	static void _200C_200E_202E_202A_202C_202D_206C_200B_202E_206C_202A_202D_200C_206D_206C_206E_206F_206E_200C_202C_202C_200D_206C_200F_200B_200F_206F_206E_202B_206B_200F_206D_200F_200C_200C_202D_206A_202C_200F_206E_202E(CharacterController P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.center = P_1;
	}

	static void _202E_206E_206B_200D_206D_200D_202D_206D_200F_202E_202C_200B_200D_206F_206C_200B_206D_202D_202E_206D_202C_200C_206E_202B_206F_200F_200F_200E_206C_200F_202D_200B_202D_200C_206F_200F_206E_200C_202B_202B_202E(CharacterController P_0, float P_1)
	{
		P_0.slopeLimit = P_1;
	}

	static void _200D_206B_206C_202E_202A_202D_206E_200D_202A_206F_206B_206B_200D_202C_202E_202C_200F_200F_200C_206B_200D_206D_206C_202B_206E_202B_202D_200B_202D_200C_202C_206D_206D_206A_202C_206C_202B_206E_206B_202C_202E(CharacterController P_0, float P_1)
	{
		P_0.stepOffset = P_1;
	}

	static void _202B_200F_202A_200B_202A_206D_202E_206B_206B_206E_200F_200C_206A_202E_202D_200C_200F_206E_206C_206E_202A_202B_200E_200C_202C_200E_200E_200D_202B_200C_200F_206B_202C_206D_202B_200E_206F_206E_206D_202A_202E(CharacterController P_0, float P_1)
	{
		P_0.skinWidth = P_1;
	}

	static void _200B_206A_206F_202A_202B_200F_200E_206A_206D_200B_206B_200E_206C_200B_206D_206F_200E_202E_200C_206D_202A_202B_206F_206C_202B_202B_206D_202C_206B_206C_202D_206F_206D_200D_202C_202B_206A_206D_200E_206F_202E(CharacterController P_0, bool P_1)
	{
		P_0.detectCollisions = P_1;
	}

	static bool _206E_202B_200C_200D_200B_206C_206D_206E_200D_200F_206D_206C_200D_206B_206D_202D_206D_206E_206C_202D_200E_202C_206E_206E_206C_200B_202E_200D_202D_202C_202B_202A_200B_202D_202B_200C_202C_206C_206A_206C_202E(CharacterController P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.SimpleMove(P_1);
	}

	static CollisionFlags _206A_206D_206F_202A_202C_206B_200D_200F_200F_202C_202C_202B_206B_202C_200F_206E_200F_202B_200E_202B_200B_206F_206B_202D_200C_206F_202C_206B_202C_202D_202C_206E_206E_202E_202C_206B_200E_206F_200C_206D_202E(CharacterController P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return P_0.Move(P_1);
	}
}
