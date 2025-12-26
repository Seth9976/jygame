using System;
using LuaInterface;
using UnityEngine;

public class ParticleAnimatorWrap
{
	private static Type classType = _206D_202E_202B_206D_206A_202E_202B_206E_202B_206A_206B_206A_202B_200C_200D_206C_200D_202C_202D_200F_206B_202A_206C_202C_200F_206C_202A_200D_200E_206C_200E_206A_206C_200E_206F_206A_202D_206B_200E_200D_202E(typeof(ParticleAnimator).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[3]
		{
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2904731379u), _200F_206F_202C_202C_206C_202C_200F_200E_206E_200C_200B_202A_206C_202E_206D_206E_200E_202D_200D_202B_202D_202E_206C_206B_200D_202B_206F_202B_206D_206D_200F_200E_206A_200F_200F_202E_206D_202C_200F_200E_202E),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3661446913u), GetClassType),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3747390401u), Lua_Eq)
		};
		LuaField[] fields = new LuaField[9]
		{
			new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3849189930u), get_doesAnimateColor, set_doesAnimateColor),
			new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2827073931u), get_worldRotationAxis, set_worldRotationAxis),
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(518898166u), get_localRotationAxis, set_localRotationAxis),
			new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3504106588u), get_sizeGrow, set_sizeGrow),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1906813684u), get_rndForce, set_rndForce),
			new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2075907101u), get_force, set_force),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1150098150u), get_damping, set_damping),
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3497919412u), get_autodestruct, set_autodestruct),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2576532385u), get_colorAnimation, set_colorAnimation)
		};
		while (true)
		{
			int num = -211207962;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1538749973)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_0271;
				case 2u:
					return;
				}
				break;
				IL_0271:
				LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2390407205u), _206D_202E_202B_206D_206A_202E_202B_206E_202B_206A_206B_206A_202B_200C_200D_206C_200D_202C_202D_200F_206B_202A_206C_202C_200F_206C_202A_200D_200E_206C_200E_206A_206C_200E_206F_206A_202D_206B_200E_200D_202E(typeof(ParticleAnimator).TypeHandle), regs, fields, _206D_202E_202B_206D_206A_202E_202B_206E_202B_206A_206B_206A_202B_200C_200D_206C_200D_202C_202D_200F_206B_202A_206C_202C_200F_206C_202A_200D_200E_206C_200E_206A_206C_200E_206F_206A_202D_206B_200E_200D_202E(typeof(Component).TypeHandle));
				num = ((int)num2 * -1045273951) ^ 0x6DF70F70;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _200F_206F_202C_202C_206C_202C_200F_200E_206E_200C_200B_202A_206C_202E_206D_206E_200E_202D_200D_202B_202D_202E_206C_206B_200D_202B_206F_202B_206D_206D_200F_200E_206A_200F_200F_202E_206D_202C_200F_200E_202E(IntPtr P_0)
	{
		int num = LuaDLL.lua_gettop(P_0);
		while (true)
		{
			int num2 = -733493933;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -2023072697)) % 6)
				{
				case 0u:
					break;
				case 4u:
				{
					int num4;
					int num5;
					if (num != 0)
					{
						num4 = -49564832;
						num5 = num4;
					}
					else
					{
						num4 = -1226565978;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num3 * -738978704);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(P_0, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1906675459u));
					num2 = -593360752;
					continue;
				case 2u:
					return 1;
				case 1u:
				{
					ParticleAnimator obj = _200B_200B_202A_202A_206B_206E_202E_202E_200E_200C_206C_206B_200F_206F_206E_206D_202E_206D_202E_206F_200E_200F_206F_200D_200C_200C_206B_206E_202B_202A_206F_206C_200B_200D_200F_206B_206B_202B_202E_202B_202E();
					LuaScriptMgr.Push(P_0, (Object)(object)obj);
					num2 = (int)(num3 * 1436200732) ^ -474937475;
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
	private static int get_doesAnimateColor(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleAnimator val = (ParticleAnimator)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -841256451;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1389272652)) % 9)
				{
				case 2u:
					break;
				case 6u:
					LuaScriptMgr.Push(L, _200B_200D_206B_206A_200D_200D_206F_202A_206B_200C_202D_202B_206E_202A_200D_202A_206C_200F_200C_206D_202E_200B_202B_202A_202C_202A_206B_200C_200E_200E_200C_200B_206F_202E_202A_202A_206C_202D_202C_206A_202E(val));
					num = -320569589;
					continue;
				case 0u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1862777305) ^ 0xF1D33E3;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2865188414u));
					num = (int)(num2 * 416721302) ^ -249248323;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(904772242u));
					num = -670791529;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 380627500;
						num6 = num5;
					}
					else
					{
						num5 = 1859051894;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -160698316);
					continue;
				}
				case 8u:
				{
					int num3;
					int num4;
					if (_202E_202D_206D_200C_202D_200D_202D_202A_200D_200C_202D_202B_200E_200B_206A_206D_202A_206A_202B_206E_206F_200B_202D_202C_200D_202C_200B_200C_200F_200B_200B_206B_206B_202D_206A_202B_206D_202E_200B_206B_202E((Object)(object)val, (Object)null))
					{
						num3 = -1398587530;
						num4 = num3;
					}
					else
					{
						num3 = -1485500447;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1541441594);
					continue;
				}
				case 7u:
					num = ((int)num2 * -922519836) ^ -1062487997;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_worldRotationAxis(IntPtr L)
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleAnimator val = default(ParticleAnimator);
		while (true)
		{
			int num = 2054327674;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x262F2A8B)) % 8)
				{
				case 6u:
					break;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(480509212u));
					num = 18265680;
					continue;
				case 3u:
					LuaScriptMgr.Push(L, _202A_206E_206B_200F_206A_200F_200C_206F_200C_200B_206A_202C_206B_202D_200F_206C_206C_206F_202E_206A_202B_206E_200C_200D_206D_206E_206F_206E_202D_206F_200F_200D_200C_202D_202E_200E_200B_206F_202D_202C_202E(val));
					num = 1032555273;
					continue;
				case 5u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -1072928574;
						num6 = num5;
					}
					else
					{
						num5 = -2089926171;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1709826955);
					continue;
				}
				case 1u:
					val = (ParticleAnimator)luaObject;
					num = (int)((num2 * 666759375) ^ 0x25BD5CF0);
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1672096702u));
					num = (int)((num2 * 536443556) ^ 0x4A1EB2F0);
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (_202E_202D_206D_200C_202D_200D_202D_202A_200D_200C_202D_202B_200E_200B_206A_206D_202A_206A_202B_206E_206F_200B_202D_202C_200D_202C_200B_200C_200F_200B_200B_206B_206B_202D_206A_202B_206D_202E_200B_206B_202E((Object)(object)val, (Object)null))
					{
						num3 = 736184846;
						num4 = num3;
					}
					else
					{
						num3 = 2048694568;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1911720146);
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
	private static int get_localRotationAxis(IntPtr L)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleAnimator val = default(ParticleAnimator);
		while (true)
		{
			int num = -1382373405;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1583091204)) % 6)
				{
				case 0u:
					break;
				case 3u:
				{
					val = (ParticleAnimator)luaObject;
					int num5;
					int num6;
					if (_202E_202D_206D_200C_202D_200D_202D_202A_200D_200C_202D_202B_200E_200B_206A_206D_202A_206A_202B_206E_206F_200B_202D_202C_200D_202C_200B_200C_200F_200B_200B_206B_206B_202D_206A_202B_206D_202E_200B_206B_202E((Object)(object)val, (Object)null))
					{
						num5 = -2080754752;
						num6 = num5;
					}
					else
					{
						num5 = -1625108495;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1200386901);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3424335466u));
					num = -495930044;
					continue;
				case 1u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -1570110283;
						num4 = num3;
					}
					else
					{
						num3 = -594603792;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1142258283);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2193615212u));
					num = (int)((num2 * 1330582845) ^ 0x5FBD2569);
					continue;
				default:
					LuaScriptMgr.Push(L, _206C_206B_200E_206A_200E_200D_206E_200D_206F_202A_200C_200C_202C_206A_200F_206B_206F_206C_206B_200C_202D_200D_200D_200E_206B_202C_200E_200C_202D_206A_206E_200B_202A_202C_202B_206A_200E_206F_200F_206E_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_sizeGrow(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleAnimator val = (ParticleAnimator)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -481456633;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -486243073)) % 9)
				{
				case 6u:
					break;
				case 7u:
				{
					int num5;
					int num6;
					if (_202E_202D_206D_200C_202D_200D_202D_202A_200D_200C_202D_202B_200E_200B_206A_206D_202A_206A_202B_206E_206F_200B_202D_202C_200D_202C_200B_200C_200F_200B_200B_206B_206B_202D_206A_202B_206D_202E_200B_206B_202E((Object)(object)val, (Object)null))
					{
						num5 = -2143348956;
						num6 = num5;
					}
					else
					{
						num5 = -1838803141;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1873953850);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3935010133u));
					num = -226511637;
					continue;
				case 4u:
					num = (int)((num2 * 148182123) ^ 0x4D2755EF);
					continue;
				case 1u:
					LuaScriptMgr.Push(L, _206B_200F_200B_202A_202A_206C_202A_206B_200D_200D_206C_200C_200E_206F_200B_202B_200C_202B_200C_206E_200E_200F_200B_200C_206B_202B_202D_200F_206A_200F_206D_206B_202A_206D_206C_202B_200F_200E_202E_206E_202E(val));
					num = -46237583;
					continue;
				case 3u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1863165470) ^ -1154430807;
					continue;
				case 8u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -1378642455;
						num4 = num3;
					}
					else
					{
						num3 = -1549768750;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -224628905);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2603982349u));
					num = ((int)num2 * -2131441335) ^ -796341611;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_rndForce(IntPtr L)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		ParticleAnimator val = default(ParticleAnimator);
		while (true)
		{
			int num = -571386911;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1489890187)) % 9)
				{
				case 3u:
					break;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(921982240u));
					num = -597247284;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3917845698u));
					num = (int)(num2 * 80273646) ^ -1710631417;
					continue;
				case 7u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 1935289094) ^ -937353933;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -1184599103;
						num6 = num5;
					}
					else
					{
						num5 = -246972824;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1877187972);
					continue;
				}
				case 1u:
					num = (int)((num2 * 1031840039) ^ 0x22CC5240);
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (_202E_202D_206D_200C_202D_200D_202D_202A_200D_200C_202D_202B_200E_200B_206A_206D_202A_206A_202B_206E_206F_200B_202D_202C_200D_202C_200B_200C_200F_200B_200B_206B_206B_202D_206A_202B_206D_202E_200B_206B_202E((Object)(object)val, (Object)null))
					{
						num3 = -896327135;
						num4 = num3;
					}
					else
					{
						num3 = -782434196;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -2099683440);
					continue;
				}
				case 2u:
					val = (ParticleAnimator)luaObject;
					num = (int)(num2 * 1832640297) ^ -1403032133;
					continue;
				default:
					LuaScriptMgr.Push(L, _200F_206A_200D_206C_202D_206D_200B_206C_202E_200D_202A_200B_206C_202D_202D_206A_200D_200E_200B_202C_202A_206B_200D_200E_200F_202B_206E_202D_200F_202D_200E_206E_206E_202D_202E_202D_206D_200E_206B_206C_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_force(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleAnimator val = default(ParticleAnimator);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1942275093;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1E7CEE84)) % 8)
				{
				case 6u:
					break;
				case 1u:
				{
					val = (ParticleAnimator)luaObject;
					int num5;
					int num6;
					if (!_202E_202D_206D_200C_202D_200D_202D_202A_200D_200C_202D_202B_200E_200B_206A_206D_202A_206A_202B_206E_206F_200B_202D_202C_200D_202C_200B_200C_200F_200B_200B_206B_206B_202D_206A_202B_206D_202E_200B_206B_202E((Object)(object)val, (Object)null))
					{
						num5 = -483142434;
						num6 = num5;
					}
					else
					{
						num5 = -171762998;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1353780790);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2323119259u));
					num = 375274568;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 1137138898;
						num4 = num3;
					}
					else
					{
						num3 = 1186467094;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1750005485);
					continue;
				}
				case 0u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 1946777684) ^ 0x59130E49);
					continue;
				case 2u:
					num = (int)(num2 * 527173561) ^ -1364279702;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3241359254u));
					num = ((int)num2 * -327611401) ^ 0x5F4C92BF;
					continue;
				default:
					LuaScriptMgr.Push(L, _206A_202E_202A_200F_200B_206D_202D_202D_206E_200C_206D_202E_202E_200E_206B_202A_200D_202A_206E_206C_200D_202D_200E_200D_206A_202A_206B_206E_202D_206D_206A_206B_202D_202E_200F_206A_202D_200D_206E_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_damping(IntPtr L)
	{
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleAnimator val = default(ParticleAnimator);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -374551263;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -79838314)) % 9)
				{
				case 6u:
					break;
				case 1u:
					LuaScriptMgr.Push(L, _206A_202D_202C_200E_200B_206C_202A_200C_200C_202E_202D_202A_206E_202A_202B_202D_206E_200E_200B_206A_202B_202D_202A_202E_206B_206B_200D_200E_200F_200C_206E_200B_202B_202C_202E_200B_200C_200F_206F_202A_202E(val));
					num = -2009798850;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1331261116u));
					num = ((int)num2 * -972892918) ^ -832912765;
					continue;
				case 8u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 1972303952) ^ -1414912675;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 1828996663;
						num6 = num5;
					}
					else
					{
						num5 = 764885966;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1615985329);
					continue;
				}
				case 7u:
				{
					int num3;
					int num4;
					if (!_202E_202D_206D_200C_202D_200D_202D_202A_200D_200C_202D_202B_200E_200B_206A_206D_202A_206A_202B_206E_206F_200B_202D_202C_200D_202C_200B_200C_200F_200B_200B_206B_206B_202D_206A_202B_206D_202E_200B_206B_202E((Object)(object)val, (Object)null))
					{
						num3 = 25326765;
						num4 = num3;
					}
					else
					{
						num3 = 365712052;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1295400968);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(251344096u));
					num = -136604707;
					continue;
				case 3u:
					val = (ParticleAnimator)luaObject;
					num = ((int)num2 * -1623025326) ^ -2031131366;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_autodestruct(IntPtr L)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleAnimator val = default(ParticleAnimator);
		while (true)
		{
			int num = -764835634;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1897510116)) % 7)
				{
				case 0u:
					break;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2528410780u));
					num = -538891414;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (_202E_202D_206D_200C_202D_200D_202D_202A_200D_200C_202D_202B_200E_200B_206A_206D_202A_206A_202B_206E_206F_200B_202D_202C_200D_202C_200B_200C_200F_200B_200B_206B_206B_202D_206A_202B_206D_202E_200B_206B_202E((Object)(object)val, (Object)null))
					{
						num5 = -73242435;
						num6 = num5;
					}
					else
					{
						num5 = -489620766;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 20968140);
					continue;
				}
				case 3u:
					val = (ParticleAnimator)luaObject;
					num = ((int)num2 * -1682542062) ^ 0x5EF5CCCE;
					continue;
				case 6u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -9512533;
						num4 = num3;
					}
					else
					{
						num3 = -1403180306;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1958296860);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1894352591u));
					num = (int)((num2 * 772557665) ^ 0x59216DC);
					continue;
				default:
					LuaScriptMgr.Push(L, _206C_206F_206E_202E_202A_202B_202B_206B_200B_202D_206F_206F_200C_202E_202A_206F_202C_200F_200B_202A_200E_202A_200F_200E_206A_206F_206E_200F_206E_202C_202C_206C_206D_206D_200D_200E_206D_202D_200D_200F_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_colorAnimation(IntPtr L)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		ParticleAnimator val = default(ParticleAnimator);
		while (true)
		{
			int num = 1910849013;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x63DEE872)) % 7)
				{
				case 2u:
					break;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(942720050u));
					num = (int)((num2 * 883764336) ^ 0x147596FB);
					continue;
				case 5u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 1133915468) ^ -1708677582;
					continue;
				case 3u:
				{
					val = (ParticleAnimator)luaObject;
					int num5;
					int num6;
					if (_202E_202D_206D_200C_202D_200D_202D_202A_200D_200C_202D_202B_200E_200B_206A_206D_202A_206A_202B_206E_206F_200B_202D_202C_200D_202C_200B_200C_200F_200B_200B_206B_206B_202D_206A_202B_206D_202E_200B_206B_202E((Object)(object)val, (Object)null))
					{
						num5 = 1710949772;
						num6 = num5;
					}
					else
					{
						num5 = 537376113;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -359762026);
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 1500224717;
						num4 = num3;
					}
					else
					{
						num3 = 481610731;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 871108338);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(528530234u));
					num = 1983212395;
					continue;
				default:
					LuaScriptMgr.PushArray(L, _200C_200E_206B_206D_200C_200E_206C_202D_200E_206F_202B_200D_206E_202D_200F_200B_200D_206F_206A_200F_200C_206B_206D_206B_206D_202C_200B_206C_206A_202A_200D_202A_202D_200C_206E_206B_202E_206D_200B_202E_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_doesAnimateColor(IntPtr L)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleAnimator val = default(ParticleAnimator);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 2014049098;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x732AE2D1)) % 10)
				{
				case 4u:
					break;
				case 1u:
					val = (ParticleAnimator)luaObject;
					num = (int)(num2 * 282878261) ^ -489144586;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 1036464968;
						num6 = num5;
					}
					else
					{
						num5 = 1506612439;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 826114370);
					continue;
				}
				case 5u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1325572740) ^ 0x301D8835;
					continue;
				case 7u:
					num = ((int)num2 * -527276205) ^ -1146305199;
					continue;
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(445545855u));
					num = ((int)num2 * -459605635) ^ 0x518442D0;
					continue;
				case 9u:
					_202C_200F_200B_202D_200C_200C_200F_206D_202B_206A_206F_202C_200E_200D_202B_202E_200D_200E_206F_206A_202E_202E_202A_200E_206C_206C_206A_200C_206F_206C_206C_200F_202E_206F_200F_200C_202A_206D_200D_206E_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					num = 715500521;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3853607419u));
					num = 713247900;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!_202E_202D_206D_200C_202D_200D_202D_202A_200D_200C_202D_202B_200E_200B_206A_206D_202A_206A_202B_206E_206F_200B_202D_202C_200D_202C_200B_200C_200F_200B_200B_206B_206B_202D_206A_202B_206D_202E_200B_206B_202E((Object)(object)val, (Object)null))
					{
						num3 = 664768716;
						num4 = num3;
					}
					else
					{
						num3 = 1272974816;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -713789481);
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
	private static int set_worldRotationAxis(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleAnimator val = (ParticleAnimator)luaObject;
		while (true)
		{
			int num = -527121326;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -273239472)) % 8)
				{
				case 3u:
					break;
				case 1u:
					num = ((int)num2 * -1134642541) ^ 0x7DDB5FDF;
					continue;
				case 4u:
					_200B_200B_200B_200D_202E_200F_202B_206E_200E_200E_206D_200B_202E_200B_200B_202B_206E_200D_202D_200D_206C_202C_206C_200F_200C_200F_200F_206A_202E_202A_202E_200D_206B_200C_200D_200D_200C_206D_200E_206A_202E(val, LuaScriptMgr.GetVector3(L, 3));
					num = -1196985928;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4042527537u));
					num = (int)(num2 * 871044648) ^ -1282191775;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(480509212u));
					num = -690158892;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (_202E_202D_206D_200C_202D_200D_202D_202A_200D_200C_202D_202B_200E_200B_206A_206D_202A_206A_202B_206E_206F_200B_202D_202C_200D_202C_200B_200C_200F_200B_200B_206B_206B_202D_206A_202B_206D_202E_200B_206B_202E((Object)(object)val, (Object)null))
					{
						num5 = -815631584;
						num6 = num5;
					}
					else
					{
						num5 = -1869046966;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1150871601);
					continue;
				}
				case 6u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 350530463;
						num4 = num3;
					}
					else
					{
						num3 = 1812494837;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 453529956);
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
	private static int set_localRotationAxis(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleAnimator val = (ParticleAnimator)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1776775142;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1497900713)) % 8)
				{
				case 6u:
					break;
				case 0u:
					_202B_200F_200B_202E_206A_206E_206A_206E_206F_206A_202C_202E_202A_206A_206A_206E_206F_200E_206D_200D_202D_206A_202E_200E_202C_206C_206E_202D_202D_202A_206C_202D_206C_202D_200E_200D_206E_202D_206B_206E_202E(val, LuaScriptMgr.GetVector3(L, 3));
					num = -494891824;
					continue;
				case 1u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -78360494) ^ 0x64F597E1;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 419001857;
						num6 = num5;
					}
					else
					{
						num5 = 1088986712;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1401771561);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3519919710u));
					num = ((int)num2 * -994746765) ^ -1753002026;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2452136426u));
					num = -1589091009;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (_202E_202D_206D_200C_202D_200D_202D_202A_200D_200C_202D_202B_200E_200B_206A_206D_202A_206A_202B_206E_206F_200B_202D_202C_200D_202C_200B_200C_200F_200B_200B_206B_206B_202D_206A_202B_206D_202E_200B_206B_202E((Object)(object)val, (Object)null))
					{
						num3 = 208659618;
						num4 = num3;
					}
					else
					{
						num3 = 1005211243;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -215413084);
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
	private static int set_sizeGrow(IntPtr L)
	{
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		ParticleAnimator val = default(ParticleAnimator);
		while (true)
		{
			int num = -405830196;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1166846402)) % 9)
				{
				case 7u:
					break;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3499246603u));
					num = ((int)num2 * -1429227278) ^ -1903491509;
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 260304970;
						num6 = num5;
					}
					else
					{
						num5 = 896913609;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1985161955);
					continue;
				}
				case 3u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 157692808) ^ -2075564665;
					continue;
				case 8u:
					num = (int)(num2 * 1195381636) ^ -1956046097;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1374198416u));
					num = -537348493;
					continue;
				case 4u:
					_200B_202A_200C_200B_200E_200E_202E_200F_202C_202B_206B_200E_202E_202C_206D_206C_206C_202E_200F_206D_200C_206E_202C_200C_206C_206C_202C_206E_206D_202A_206F_206D_200E_206E_200D_206D_202B_202C_202D_202B_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					num = -899098629;
					continue;
				case 2u:
				{
					val = (ParticleAnimator)luaObject;
					int num3;
					int num4;
					if (_202E_202D_206D_200C_202D_200D_202D_202A_200D_200C_202D_202B_200E_200B_206A_206D_202A_206A_202B_206E_206F_200B_202D_202C_200D_202C_200B_200C_200F_200B_200B_206B_206B_202D_206A_202B_206D_202E_200B_206B_202E((Object)(object)val, (Object)null))
					{
						num3 = 258621232;
						num4 = num3;
					}
					else
					{
						num3 = 1415552117;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 153720283);
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
	private static int set_rndForce(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleAnimator val = (ParticleAnimator)luaObject;
		while (true)
		{
			int num = -1072253618;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1687992871)) % 8)
				{
				case 2u:
					break;
				case 7u:
				{
					int num5;
					int num6;
					if (_202E_202D_206D_200C_202D_200D_202D_202A_200D_200C_202D_202B_200E_200B_206A_206D_202A_206A_202B_206E_206F_200B_202D_202C_200D_202C_200B_200C_200F_200B_200B_206B_206B_202D_206A_202B_206D_202E_200B_206B_202E((Object)(object)val, (Object)null))
					{
						num5 = -839737258;
						num6 = num5;
					}
					else
					{
						num5 = -944217900;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1932010204);
					continue;
				}
				case 1u:
					_202A_200B_200F_200C_206E_206E_206C_206E_206D_200B_202C_206F_200B_200C_206C_206A_206D_206E_200B_202C_200E_206E_200C_206E_202A_202C_200D_206D_200D_206E_200E_202C_202B_202C_202B_202D_202B_206C_200B_200C_202E(val, LuaScriptMgr.GetVector3(L, 3));
					num = -876380809;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(921982240u));
					num = -1751035672;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(639401906u));
					num = ((int)num2 * -1478203254) ^ 0x2C69ADBD;
					continue;
				case 4u:
					num = ((int)num2 * -111857001) ^ -1295298076;
					continue;
				case 3u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -1721545849;
						num4 = num3;
					}
					else
					{
						num3 = -1416744382;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1945051921);
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
	private static int set_force(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleAnimator val = (ParticleAnimator)luaObject;
		while (true)
		{
			int num = -2052482807;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -90556196)) % 7)
				{
				case 3u:
					break;
				case 1u:
				{
					int num5;
					int num6;
					if (_202E_202D_206D_200C_202D_200D_202D_202A_200D_200C_202D_202B_200E_200B_206A_206D_202A_206A_202B_206E_206F_200B_202D_202C_200D_202C_200B_200C_200F_200B_200B_206B_206B_202D_206A_202B_206D_202E_200B_206B_202E((Object)(object)val, (Object)null))
					{
						num5 = -1635108880;
						num6 = num5;
					}
					else
					{
						num5 = -1276958691;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1707373831);
					continue;
				}
				case 6u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 424239229;
						num4 = num3;
					}
					else
					{
						num3 = 1879584261;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -903423779);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3955581191u));
					num = ((int)num2 * -1593471339) ^ -857089358;
					continue;
				case 2u:
					num = (int)(num2 * 2047746525) ^ -1731901582;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1661517905u));
					num = -1332679218;
					continue;
				default:
					_206C_202C_206E_202E_202D_202A_202C_202A_202E_206C_200D_206C_200D_200E_200F_206D_206A_202E_206B_206E_206B_206E_202E_202D_206E_206F_200E_202B_200E_202C_206B_202C_202A_202E_202E_200F_206E_206F_206E_206E_202E(val, LuaScriptMgr.GetVector3(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_damping(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleAnimator val = default(ParticleAnimator);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1483102516;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6D93AC79)) % 8)
				{
				case 4u:
					break;
				case 5u:
				{
					val = (ParticleAnimator)luaObject;
					int num5;
					int num6;
					if (!_202E_202D_206D_200C_202D_200D_202D_202A_200D_200C_202D_202B_200E_200B_206A_206D_202A_206A_202B_206E_206F_200B_202D_202C_200D_202C_200B_200C_200F_200B_200B_206B_206B_202D_206A_202B_206D_202E_200B_206B_202E((Object)(object)val, (Object)null))
					{
						num5 = -285244235;
						num6 = num5;
					}
					else
					{
						num5 = -73985412;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1202023940);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(251344096u));
					num = 304115585;
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -1362337561;
						num4 = num3;
					}
					else
					{
						num3 = -983539158;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 137433312);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(750233267u));
					num = ((int)num2 * -276485485) ^ 0x7486649B;
					continue;
				case 1u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 1357686317) ^ -376202365;
					continue;
				case 0u:
					_200B_206F_202B_200E_206F_202B_206C_200E_200D_202D_206B_206D_202B_206E_200D_200C_206A_206E_206A_202E_206B_202E_206B_202D_200F_206F_202C_200F_200C_206A_206D_206C_202A_202A_202B_206D_200B_206D_200E_202E_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					num = 1080427163;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_autodestruct(IntPtr L)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleAnimator val = default(ParticleAnimator);
		while (true)
		{
			int num = 1520081085;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x728FBBC5)) % 9)
				{
				case 4u:
					break;
				case 6u:
					val = (ParticleAnimator)luaObject;
					num = ((int)num2 * -2078214977) ^ 0x53B7AE0C;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2528410780u));
					num = 1455557153;
					continue;
				case 8u:
					_206E_202D_202C_206D_200F_206D_200B_200E_200E_206F_200F_202D_200F_206C_206C_202D_206F_206B_202D_200F_206D_202A_202E_200C_200C_206E_202A_206A_200C_206D_200E_202E_206B_206A_206D_202B_200F_206B_200B_206E_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					num = 151998464;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (!_202E_202D_206D_200C_202D_200D_202D_202A_200D_200C_202D_202B_200E_200B_206A_206D_202A_206A_202B_206E_206F_200B_202D_202C_200D_202C_200B_200C_200F_200B_200B_206B_206B_202D_206A_202B_206D_202E_200B_206B_202E((Object)(object)val, (Object)null))
					{
						num5 = 25473650;
						num6 = num5;
					}
					else
					{
						num5 = 9722804;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 613489299);
					continue;
				}
				case 2u:
					num = ((int)num2 * -148994515) ^ -1982503839;
					continue;
				case 3u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -1823603227;
						num4 = num3;
					}
					else
					{
						num3 = -1243936985;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1227009453);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1894352591u));
					num = (int)(num2 * 2123111290) ^ -1291014155;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_colorAnimation(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleAnimator val = (ParticleAnimator)luaObject;
		while (true)
		{
			int num = 368294006;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6F45AD77)) % 8)
				{
				case 5u:
					break;
				case 1u:
				{
					int num5;
					int num6;
					if (_202E_202D_206D_200C_202D_200D_202D_202A_200D_200C_202D_202B_200E_200B_206A_206D_202A_206A_202B_206E_206F_200B_202D_202C_200D_202C_200B_200C_200F_200B_200B_206B_206B_202D_206A_202B_206D_202E_200B_206B_202E((Object)(object)val, (Object)null))
					{
						num5 = -1012149445;
						num6 = num5;
					}
					else
					{
						num5 = -1195364618;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1422396815);
					continue;
				}
				case 6u:
					_202C_200E_206C_200C_206C_200B_206A_202C_200F_206E_200E_206E_200D_200D_206F_200B_206E_206F_202A_206D_206B_202C_200B_200D_206B_200C_202D_206A_202E_206C_202C_200D_200D_206B_202D_200C_206E_200E_200B_206A_202E(val, LuaScriptMgr.GetArrayObject<Color>(L, 3));
					num = 340650103;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3304526400u));
					num = ((int)num2 * -68765960) ^ 0x6C6BA790;
					continue;
				case 7u:
					num = ((int)num2 * -1976853722) ^ -1917758349;
					continue;
				case 3u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 1238278318;
						num4 = num3;
					}
					else
					{
						num3 = 1632429208;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -588852199);
					continue;
				}
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4176940843u));
					num = 1062135417;
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
		Object val2 = default(Object);
		bool b = default(bool);
		while (true)
		{
			int num = 1055992236;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x20EDFDAD)) % 5)
				{
				case 0u:
					break;
				case 1u:
				{
					object luaObject2 = LuaScriptMgr.GetLuaObject(L, 1);
					val2 = (Object)((luaObject2 is Object) ? luaObject2 : null);
					num = ((int)num2 * -47470387) ^ -1523922918;
					continue;
				}
				case 2u:
					LuaScriptMgr.Push(L, b);
					num = ((int)num2 * -906537798) ^ -1974810106;
					continue;
				case 3u:
				{
					object luaObject = LuaScriptMgr.GetLuaObject(L, 2);
					Object val = (Object)((luaObject is Object) ? luaObject : null);
					b = _202E_202D_206D_200C_202D_200D_202D_202A_200D_200C_202D_202B_200E_200B_206A_206D_202A_206A_202B_206E_206F_200B_202D_202C_200D_202C_200B_200C_200F_200B_200B_206B_206B_202D_206A_202B_206D_202E_200B_206B_202E(val2, val);
					num = ((int)num2 * -2006791540) ^ 0x3B436BE3;
					continue;
				}
				default:
					return 1;
				}
				break;
			}
		}
	}

	static Type _206D_202E_202B_206D_206A_202E_202B_206E_202B_206A_206B_206A_202B_200C_200D_206C_200D_202C_202D_200F_206B_202A_206C_202C_200F_206C_202A_200D_200E_206C_200E_206A_206C_200E_206F_206A_202D_206B_200E_200D_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static ParticleAnimator _200B_200B_202A_202A_206B_206E_202E_202E_200E_200C_206C_206B_200F_206F_206E_206D_202E_206D_202E_206F_200E_200F_206F_200D_200C_200C_206B_206E_202B_202A_206F_206C_200B_200D_200F_206B_206B_202B_202E_202B_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ParticleAnimator();
	}

	static bool _202E_202D_206D_200C_202D_200D_202D_202A_200D_200C_202D_202B_200E_200B_206A_206D_202A_206A_202B_206E_206F_200B_202D_202C_200D_202C_200B_200C_200F_200B_200B_206B_206B_202D_206A_202B_206D_202E_200B_206B_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static bool _200B_200D_206B_206A_200D_200D_206F_202A_206B_200C_202D_202B_206E_202A_200D_202A_206C_200F_200C_206D_202E_200B_202B_202A_202C_202A_206B_200C_200E_200E_200C_200B_206F_202E_202A_202A_206C_202D_202C_206A_202E(ParticleAnimator P_0)
	{
		return P_0.doesAnimateColor;
	}

	static Vector3 _202A_206E_206B_200F_206A_200F_200C_206F_200C_200B_206A_202C_206B_202D_200F_206C_206C_206F_202E_206A_202B_206E_200C_200D_206D_206E_206F_206E_202D_206F_200F_200D_200C_202D_202E_200E_200B_206F_202D_202C_202E(ParticleAnimator P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.worldRotationAxis;
	}

	static Vector3 _206C_206B_200E_206A_200E_200D_206E_200D_206F_202A_200C_200C_202C_206A_200F_206B_206F_206C_206B_200C_202D_200D_200D_200E_206B_202C_200E_200C_202D_206A_206E_200B_202A_202C_202B_206A_200E_206F_200F_206E_202E(ParticleAnimator P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.localRotationAxis;
	}

	static float _206B_200F_200B_202A_202A_206C_202A_206B_200D_200D_206C_200C_200E_206F_200B_202B_200C_202B_200C_206E_200E_200F_200B_200C_206B_202B_202D_200F_206A_200F_206D_206B_202A_206D_206C_202B_200F_200E_202E_206E_202E(ParticleAnimator P_0)
	{
		return P_0.sizeGrow;
	}

	static Vector3 _200F_206A_200D_206C_202D_206D_200B_206C_202E_200D_202A_200B_206C_202D_202D_206A_200D_200E_200B_202C_202A_206B_200D_200E_200F_202B_206E_202D_200F_202D_200E_206E_206E_202D_202E_202D_206D_200E_206B_206C_202E(ParticleAnimator P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.rndForce;
	}

	static Vector3 _206A_202E_202A_200F_200B_206D_202D_202D_206E_200C_206D_202E_202E_200E_206B_202A_200D_202A_206E_206C_200D_202D_200E_200D_206A_202A_206B_206E_202D_206D_206A_206B_202D_202E_200F_206A_202D_200D_206E_202E(ParticleAnimator P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.force;
	}

	static float _206A_202D_202C_200E_200B_206C_202A_200C_200C_202E_202D_202A_206E_202A_202B_202D_206E_200E_200B_206A_202B_202D_202A_202E_206B_206B_200D_200E_200F_200C_206E_200B_202B_202C_202E_200B_200C_200F_206F_202A_202E(ParticleAnimator P_0)
	{
		return P_0.damping;
	}

	static bool _206C_206F_206E_202E_202A_202B_202B_206B_200B_202D_206F_206F_200C_202E_202A_206F_202C_200F_200B_202A_200E_202A_200F_200E_206A_206F_206E_200F_206E_202C_202C_206C_206D_206D_200D_200E_206D_202D_200D_200F_202E(ParticleAnimator P_0)
	{
		return P_0.autodestruct;
	}

	static Color[] _200C_200E_206B_206D_200C_200E_206C_202D_200E_206F_202B_200D_206E_202D_200F_200B_200D_206F_206A_200F_200C_206B_206D_206B_206D_202C_200B_206C_206A_202A_200D_202A_202D_200C_206E_206B_202E_206D_200B_202E_202E(ParticleAnimator P_0)
	{
		return P_0.colorAnimation;
	}

	static void _202C_200F_200B_202D_200C_200C_200F_206D_202B_206A_206F_202C_200E_200D_202B_202E_200D_200E_206F_206A_202E_202E_202A_200E_206C_206C_206A_200C_206F_206C_206C_200F_202E_206F_200F_200C_202A_206D_200D_206E_202E(ParticleAnimator P_0, bool P_1)
	{
		P_0.doesAnimateColor = P_1;
	}

	static void _200B_200B_200B_200D_202E_200F_202B_206E_200E_200E_206D_200B_202E_200B_200B_202B_206E_200D_202D_200D_206C_202C_206C_200F_200C_200F_200F_206A_202E_202A_202E_200D_206B_200C_200D_200D_200C_206D_200E_206A_202E(ParticleAnimator P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.worldRotationAxis = P_1;
	}

	static void _202B_200F_200B_202E_206A_206E_206A_206E_206F_206A_202C_202E_202A_206A_206A_206E_206F_200E_206D_200D_202D_206A_202E_200E_202C_206C_206E_202D_202D_202A_206C_202D_206C_202D_200E_200D_206E_202D_206B_206E_202E(ParticleAnimator P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.localRotationAxis = P_1;
	}

	static void _200B_202A_200C_200B_200E_200E_202E_200F_202C_202B_206B_200E_202E_202C_206D_206C_206C_202E_200F_206D_200C_206E_202C_200C_206C_206C_202C_206E_206D_202A_206F_206D_200E_206E_200D_206D_202B_202C_202D_202B_202E(ParticleAnimator P_0, float P_1)
	{
		P_0.sizeGrow = P_1;
	}

	static void _202A_200B_200F_200C_206E_206E_206C_206E_206D_200B_202C_206F_200B_200C_206C_206A_206D_206E_200B_202C_200E_206E_200C_206E_202A_202C_200D_206D_200D_206E_200E_202C_202B_202C_202B_202D_202B_206C_200B_200C_202E(ParticleAnimator P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.rndForce = P_1;
	}

	static void _206C_202C_206E_202E_202D_202A_202C_202A_202E_206C_200D_206C_200D_200E_200F_206D_206A_202E_206B_206E_206B_206E_202E_202D_206E_206F_200E_202B_200E_202C_206B_202C_202A_202E_202E_200F_206E_206F_206E_206E_202E(ParticleAnimator P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.force = P_1;
	}

	static void _200B_206F_202B_200E_206F_202B_206C_200E_200D_202D_206B_206D_202B_206E_200D_200C_206A_206E_206A_202E_206B_202E_206B_202D_200F_206F_202C_200F_200C_206A_206D_206C_202A_202A_202B_206D_200B_206D_200E_202E_202E(ParticleAnimator P_0, float P_1)
	{
		P_0.damping = P_1;
	}

	static void _206E_202D_202C_206D_200F_206D_200B_200E_200E_206F_200F_202D_200F_206C_206C_202D_206F_206B_202D_200F_206D_202A_202E_200C_200C_206E_202A_206A_200C_206D_200E_202E_206B_206A_206D_202B_200F_206B_200B_206E_202E(ParticleAnimator P_0, bool P_1)
	{
		P_0.autodestruct = P_1;
	}

	static void _202C_200E_206C_200C_206C_200B_206A_202C_200F_206E_200E_206E_200D_200D_206F_200B_206E_206F_202A_206D_206B_202C_200B_200D_206B_200C_202D_206A_202E_206C_202C_200D_200D_206B_202D_200C_206E_200E_200B_206A_202E(ParticleAnimator P_0, Color[] P_1)
	{
		P_0.colorAnimation = P_1;
	}
}
