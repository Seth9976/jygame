using System;
using LuaInterface;
using UnityEngine;

public class AnimationStateWrap
{
	private static Type classType = _206A_200C_202D_202C_206A_202C_202D_202A_200E_202E_202E_206A_202A_202C_200B_200E_200D_200B_200D_202C_206E_206B_200F_202E_202B_200C_202E_206F_200C_200E_202A_202A_202D_206E_202E_206C_206B_200C_206D_200E_202E(typeof(AnimationState).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[5]
		{
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1153389470u), AddMixingTransform),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2643053597u), RemoveMixingTransform),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2705981273u), _202A_202C_206A_200F_202C_202E_206C_202C_200C_200F_206D_200D_200B_206F_200B_206B_202C_200C_202E_200C_202A_202E_202C_200B_202D_202D_200C_200C_200E_202A_206D_202C_202A_202D_206D_202B_206E_200D_200F_206C_202E),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2567984228u), GetClassType),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(60698966u), Lua_Eq)
		};
		LuaField[] fields = new LuaField[12]
		{
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1867280171u), get_enabled, set_enabled),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2418465499u), get_weight, set_weight),
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4178903076u), get_wrapMode, set_wrapMode),
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1226741781u), get_time, set_time),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(526676664u), get_normalizedTime, set_normalizedTime),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2232193125u), get_speed, set_speed),
			new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3576131173u), get_normalizedSpeed, set_normalizedSpeed),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2949167492u), get_length, null),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2534077069u), get_layer, set_layer),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2571812562u), get_clip, null),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3042149174u), get_name, set_name),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2420870590u), get_blendMode, set_blendMode)
		};
		LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(180958795u), _206A_200C_202D_202C_206A_202C_202D_202A_200E_202E_202E_206A_202A_202C_200B_200E_200D_200B_200D_202C_206E_206B_200F_202E_202B_200C_202E_206F_200C_200E_202A_202A_202D_206E_202E_206C_206B_200C_206D_200E_202E(typeof(AnimationState).TypeHandle), regs, fields, _206A_200C_202D_202C_206A_202C_202D_202A_200E_202E_202E_206A_202A_202C_200B_200E_200D_200B_200D_202C_206E_206B_200F_202E_202B_200C_202E_206F_200C_200E_202A_202A_202D_206E_202E_206C_206B_200C_206D_200E_202E(typeof(TrackedReference).TypeHandle));
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _202A_202C_206A_200F_202C_202E_206C_202C_200C_200F_206D_200D_200B_206F_200B_206B_202C_200C_202E_200C_202A_202E_202C_200B_202D_202D_200C_200C_200E_202A_206D_202C_202A_202D_206D_202B_206E_200D_200F_206C_202E(IntPtr P_0)
	{
		int num = LuaDLL.lua_gettop(P_0);
		AnimationState obj = default(AnimationState);
		while (true)
		{
			int num2 = 458497066;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x6860E8B9)) % 5)
				{
				case 2u:
					break;
				case 3u:
				{
					int num4;
					int num5;
					if (num != 0)
					{
						num4 = 105243989;
						num5 = num4;
					}
					else
					{
						num4 = 1326838701;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 2073404023);
					continue;
				}
				case 0u:
					obj = _206A_202A_206D_206B_200F_206A_200C_200D_200C_206F_206F_206A_200F_206B_200B_206E_202C_200E_206B_206A_202C_206F_200F_200C_200F_206D_200B_206B_200D_200B_202A_202D_200E_200C_200E_206F_206A_202C_202B_206F_202E();
					num2 = (int)(num3 * 761980052) ^ -525430701;
					continue;
				case 1u:
					LuaScriptMgr.Push(P_0, (TrackedReference)(object)obj);
					return 1;
				default:
					LuaDLL.luaL_error(P_0, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3587848157u));
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
		AnimationState val = (AnimationState)luaObject;
		if (_200B_206E_200E_202D_206D_206C_202E_202E_200C_202A_200E_202C_200E_202C_206D_206B_206D_202D_206B_202A_206A_206E_200C_200F_200E_206F_200F_200E_202A_206B_206C_202C_200B_202D_200E_200C_206F_202B_206B_206A_202E((TrackedReference)(object)val, (TrackedReference)null))
		{
			goto IL_0018;
		}
		goto IL_0072;
		IL_0018:
		int num = 349549174;
		goto IL_001d;
		IL_001d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x5E353936)) % 7)
			{
			case 0u:
				break;
			case 1u:
			{
				LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
				int num3;
				int num4;
				if (luaTypes != LuaTypes.LUA_TTABLE)
				{
					num3 = 1492652493;
					num4 = num3;
				}
				else
				{
					num3 = 2136962248;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 170785392);
				continue;
			}
			case 5u:
				goto IL_0072;
			case 2u:
				num = (int)((num2 * 2082909922) ^ 0x799291F8);
				continue;
			case 6u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3927089387u));
				num = ((int)num2 * -521217330) ^ -1673331355;
				continue;
			case 3u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3616643139u));
				num = 1682474870;
				continue;
			default:
				return 1;
			}
			break;
		}
		goto IL_0018;
		IL_0072:
		LuaScriptMgr.Push(L, _202B_200B_202D_202C_200E_206A_202C_200C_200C_206B_206F_200F_202D_206F_202C_200C_200E_200E_202C_200F_200C_202E_202B_202E_200F_206D_202A_200C_206B_200C_206C_202C_200B_202A_200E_200E_200D_206A_206D_200F_202E(val));
		num = 62506662;
		goto IL_001d;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_weight(IntPtr L)
	{
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		AnimationState val = default(AnimationState);
		while (true)
		{
			int num = -1843465850;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -742307951)) % 10)
				{
				case 4u:
					break;
				case 9u:
					num = ((int)num2 * -513809795) ^ -1197609118;
					continue;
				case 6u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 469955846) ^ -1895856576;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -1069293160;
						num6 = num5;
					}
					else
					{
						num5 = -339343656;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 600914509);
					continue;
				}
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3707420394u));
					num = -301692021;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (_200B_206E_200E_202D_206D_206C_202E_202E_200C_202A_200E_202C_200E_202C_206D_206B_206D_202D_206B_202A_206A_206E_200C_200F_200E_206F_200F_200E_202A_206B_206C_202C_200B_202D_200E_200C_206F_202B_206B_206A_202E((TrackedReference)(object)val, (TrackedReference)null))
					{
						num3 = -1455495710;
						num4 = num3;
					}
					else
					{
						num3 = -2096974266;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1458619619);
					continue;
				}
				case 3u:
					val = (AnimationState)luaObject;
					num = ((int)num2 * -126529629) ^ -1728671675;
					continue;
				case 8u:
					LuaScriptMgr.Push(L, _200B_206F_206D_206B_200B_202A_200F_202D_202E_202A_202D_202C_206F_206F_206F_202A_200F_206E_206F_202E_200C_202D_202A_202A_202B_200E_200F_202E_206E_206D_200E_206C_206E_206D_200B_206A_202B_206B_200E_202A_202E(val));
					num = -1493157142;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1215118691u));
					num = ((int)num2 * -1321798007) ^ -596404316;
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
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		AnimationState val = default(AnimationState);
		while (true)
		{
			int num = -332021468;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -303020832)) % 9)
				{
				case 0u:
					break;
				case 6u:
					num = (int)((num2 * 896667973) ^ 0x273592DA);
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -1998377175;
						num6 = num5;
					}
					else
					{
						num5 = -721709043;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1369789023);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(131108899u));
					num = ((int)num2 * -926849260) ^ 0x2629A244;
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (_200B_206E_200E_202D_206D_206C_202E_202E_200C_202A_200E_202C_200E_202C_206D_206B_206D_202D_206B_202A_206A_206E_200C_200F_200E_206F_200F_200E_202A_206B_206C_202C_200B_202D_200E_200C_206F_202B_206B_206A_202E((TrackedReference)(object)val, (TrackedReference)null))
					{
						num3 = -687974559;
						num4 = num3;
					}
					else
					{
						num3 = -1665168652;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1359199151);
					continue;
				}
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1912953029) ^ -1170276468;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3074744801u));
					num = -1422791154;
					continue;
				case 2u:
					val = (AnimationState)luaObject;
					num = ((int)num2 * -39578553) ^ -1463391590;
					continue;
				default:
					LuaScriptMgr.Push(L, (Enum)(object)_202C_200D_202D_202A_200C_202D_206B_200B_200F_202A_202C_206C_206A_202D_200B_206A_206F_200D_202B_206D_206B_206D_202C_202B_200D_200D_206A_206E_202B_206F_202A_206D_200B_202D_206E_202B_202D_200E_206A_206C_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_time(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AnimationState val = (AnimationState)luaObject;
		if (_200B_206E_200E_202D_206D_206C_202E_202E_200C_202A_200E_202C_200E_202C_206D_206B_206D_202D_206B_202A_206A_206E_200C_200F_200E_206F_200F_200E_202A_206B_206C_202C_200B_202D_200E_200C_206F_202B_206B_206A_202E((TrackedReference)(object)val, (TrackedReference)null))
		{
			goto IL_0018;
		}
		goto IL_005d;
		IL_0018:
		int num = -1253405844;
		goto IL_001d;
		IL_001d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -173408573)) % 6)
			{
			case 3u:
				break;
			case 2u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(169335705u));
				num = -1254160568;
				continue;
			case 5u:
				goto IL_005d;
			case 1u:
			{
				LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
				int num3;
				int num4;
				if (luaTypes == LuaTypes.LUA_TTABLE)
				{
					num3 = 167711458;
					num4 = num3;
				}
				else
				{
					num3 = 1990566376;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -783302085);
				continue;
			}
			case 4u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2856532071u));
				num = ((int)num2 * -1911601168) ^ 0x6AE08F88;
				continue;
			default:
				return 1;
			}
			break;
		}
		goto IL_0018;
		IL_005d:
		LuaScriptMgr.Push(L, _202C_200B_200D_200E_200F_206A_200F_206D_206D_206D_202B_202A_206D_206D_202B_206A_200B_202D_200C_200D_206D_206C_206D_202E_202A_202C_202B_206F_200C_202C_200E_206D_206A_206B_206F_202C_206F_206B_206A_200E_202E(val));
		num = -525962609;
		goto IL_001d;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_normalizedTime(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AnimationState val = (AnimationState)luaObject;
		while (true)
		{
			int num = 220669386;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x44DDCD7E)) % 8)
				{
				case 0u:
					break;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2592972978u));
					num = 1872789687;
					continue;
				case 2u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -1668248432;
						num6 = num5;
					}
					else
					{
						num5 = -673767975;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1800917168);
					continue;
				}
				case 5u:
					num = (int)(num2 * 463126050) ^ -1444429619;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3800518431u));
					num = (int)(num2 * 935876174) ^ -920784591;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!_200B_206E_200E_202D_206D_206C_202E_202E_200C_202A_200E_202C_200E_202C_206D_206B_206D_202D_206B_202A_206A_206E_200C_200F_200E_206F_200F_200E_202A_206B_206C_202C_200B_202D_200E_200C_206F_202B_206B_206A_202E((TrackedReference)(object)val, (TrackedReference)null))
					{
						num3 = -357296453;
						num4 = num3;
					}
					else
					{
						num3 = -1881733504;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 884710511);
					continue;
				}
				case 1u:
					LuaScriptMgr.Push(L, _200E_200E_206E_200E_200B_200D_202E_202D_206C_206E_206F_202B_200C_206D_200C_206D_206E_206B_206F_200D_206B_200B_206F_200D_200D_202D_206F_200E_206F_202B_200F_206E_200D_200C_206B_200C_206B_200F_202A_202E_202E(val));
					num = 1424373061;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_speed(IntPtr L)
	{
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		AnimationState val = default(AnimationState);
		while (true)
		{
			int num = -1309796993;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1079803480)) % 9)
				{
				case 4u:
					break;
				case 6u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 1785912666;
						num6 = num5;
					}
					else
					{
						num5 = 625140433;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 738025579);
					continue;
				}
				case 5u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 101598295) ^ 0x2EBCB3CB);
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3798197649u));
					num = ((int)num2 * -359046804) ^ 0xB7B5244;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3487751401u));
					num = -239676275;
					continue;
				case 1u:
				{
					val = (AnimationState)luaObject;
					int num3;
					int num4;
					if (_200B_206E_200E_202D_206D_206C_202E_202E_200C_202A_200E_202C_200E_202C_206D_206B_206D_202D_206B_202A_206A_206E_200C_200F_200E_206F_200F_200E_202A_206B_206C_202C_200B_202D_200E_200C_206F_202B_206B_206A_202E((TrackedReference)(object)val, (TrackedReference)null))
					{
						num3 = -1931922129;
						num4 = num3;
					}
					else
					{
						num3 = -914752545;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 870600446);
					continue;
				}
				case 3u:
					num = ((int)num2 * -68846783) ^ 0x4A1A3479;
					continue;
				case 8u:
					LuaScriptMgr.Push(L, _200D_206A_200B_202C_202E_202D_206A_200B_200F_202B_200D_206D_202A_200D_206B_202D_206B_200D_206C_206F_202B_202C_206A_206E_202E_206E_206D_200E_202E_206C_206E_200C_200B_200D_200F_202C_200D_206D_200B_202C_202E(val));
					num = -820069968;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_normalizedSpeed(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AnimationState val = (AnimationState)luaObject;
		while (true)
		{
			int num = -948741853;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1191107366)) % 8)
				{
				case 6u:
					break;
				case 7u:
					LuaScriptMgr.Push(L, _206F_206F_206A_206A_202E_202C_200D_206A_206A_202B_202A_202D_206C_206B_200E_206C_202E_206A_200E_202A_202B_202D_202B_200B_202B_202D_206E_202E_206D_200D_200E_200E_200F_202D_200B_206F_202D_206E_202B_206C_202E(val));
					num = -1823282713;
					continue;
				case 3u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 1887294737;
						num6 = num5;
					}
					else
					{
						num5 = 941139031;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 981616285);
					continue;
				}
				case 0u:
					num = (int)((num2 * 522868884) ^ 0x77E31125);
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3370426322u));
					num = ((int)num2 * -1789905461) ^ 0x2F42EB44;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (_200B_206E_200E_202D_206D_206C_202E_202E_200C_202A_200E_202C_200E_202C_206D_206B_206D_202D_206B_202A_206A_206E_200C_200F_200E_206F_200F_200E_202A_206B_206C_202C_200B_202D_200E_200C_206F_202B_206B_206A_202E((TrackedReference)(object)val, (TrackedReference)null))
					{
						num3 = 136167907;
						num4 = num3;
					}
					else
					{
						num3 = 174888967;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1338018926);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1844742906u));
					num = -1236980987;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_length(IntPtr L)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		AnimationState val = default(AnimationState);
		while (true)
		{
			int num = -128294104;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1694420798)) % 8)
				{
				case 6u:
					break;
				case 5u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 81875326;
						num6 = num5;
					}
					else
					{
						num5 = 1672270330;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1863747749);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3650200038u));
					num = -414475582;
					continue;
				case 0u:
					LuaScriptMgr.Push(L, _206D_206F_202B_206F_202D_206C_202A_202C_206C_206F_200F_206A_202B_206C_202D_202E_206B_200D_206F_200E_206B_206A_202E_202E_200E_206D_202D_200D_200D_200C_206F_202D_200B_206D_200B_206D_202D_202A_202A_206B_202E(val));
					num = -494380682;
					continue;
				case 2u:
				{
					val = (AnimationState)luaObject;
					int num3;
					int num4;
					if (_200B_206E_200E_202D_206D_206C_202E_202E_200C_202A_200E_202C_200E_202C_206D_206B_206D_202D_206B_202A_206A_206E_200C_200F_200E_206F_200F_200E_202A_206B_206C_202C_200B_202D_200E_200C_206F_202B_206B_206A_202E((TrackedReference)(object)val, (TrackedReference)null))
					{
						num3 = -996352125;
						num4 = num3;
					}
					else
					{
						num3 = -1799688782;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 2033050072);
					continue;
				}
				case 1u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 1664721773) ^ 0x41163FEA);
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3695637297u));
					num = ((int)num2 * -1300689498) ^ 0x552679B8;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_layer(IntPtr L)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AnimationState val = default(AnimationState);
		while (true)
		{
			int num = -1826552285;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1078538446)) % 7)
				{
				case 6u:
					break;
				case 1u:
					num = (int)(num2 * 349328813) ^ -741838911;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2491313260u));
					num = -855424816;
					continue;
				case 3u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 2007964630;
						num6 = num5;
					}
					else
					{
						num5 = 2046238299;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 836330075);
					continue;
				}
				case 5u:
				{
					val = (AnimationState)luaObject;
					int num3;
					int num4;
					if (!_200B_206E_200E_202D_206D_206C_202E_202E_200C_202A_200E_202C_200E_202C_206D_206B_206D_202D_206B_202A_206A_206E_200C_200F_200E_206F_200F_200E_202A_206B_206C_202C_200B_202D_200E_200C_206F_202B_206B_206A_202E((TrackedReference)(object)val, (TrackedReference)null))
					{
						num3 = -1934117789;
						num4 = num3;
					}
					else
					{
						num3 = -1524172770;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1413480835);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2081448133u));
					num = ((int)num2 * -1156920089) ^ -548346688;
					continue;
				default:
					LuaScriptMgr.Push(L, _206A_206E_202C_206F_202C_202D_202B_200F_202C_202A_202C_206F_200E_200F_206E_202B_206C_206C_200C_206B_202A_206C_200D_206E_202E_206C_202E_202B_206F_202D_206D_200F_202C_200C_200F_200D_202D_206A_202B_206D_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_clip(IntPtr L)
	{
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AnimationState val = default(AnimationState);
		while (true)
		{
			int num = -1228056943;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -997278918)) % 9)
				{
				case 4u:
					break;
				case 2u:
					LuaScriptMgr.Push(L, (Object)(object)_202A_200C_202A_200F_200E_200B_200F_206A_206B_206F_202B_200D_200C_206E_202E_200F_206D_206B_200D_206A_206A_206B_206E_200D_200E_200D_200E_202A_206A_206C_200D_200E_200C_200C_200D_206E_200B_206A_200E_202E_202E(val));
					num = -854275103;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2609745035u));
					num = -835630311;
					continue;
				case 7u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 1869367384;
						num6 = num5;
					}
					else
					{
						num5 = 1710967866;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1487881248);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1143351029u));
					num = ((int)num2 * -79310124) ^ -428519227;
					continue;
				case 3u:
					num = (int)(num2 * 1758408998) ^ -1392006413;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (_200B_206E_200E_202D_206D_206C_202E_202E_200C_202A_200E_202C_200E_202C_206D_206B_206D_202D_206B_202A_206A_206E_200C_200F_200E_206F_200F_200E_202A_206B_206C_202C_200B_202D_200E_200C_206F_202B_206B_206A_202E((TrackedReference)(object)val, (TrackedReference)null))
					{
						num3 = 4855408;
						num4 = num3;
					}
					else
					{
						num3 = 1243300844;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1971770781);
					continue;
				}
				case 1u:
					val = (AnimationState)luaObject;
					num = (int)((num2 * 1382930709) ^ 0x6384404);
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_name(IntPtr L)
	{
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AnimationState val = default(AnimationState);
		while (true)
		{
			int num = -1082888258;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1113286824)) % 8)
				{
				case 5u:
					break;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3278556272u));
					num = ((int)num2 * -1579379581) ^ 0x1DB8ED66;
					continue;
				case 3u:
					num = ((int)num2 * -572648053) ^ 0x39764BE8;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (_200B_206E_200E_202D_206D_206C_202E_202E_200C_202A_200E_202C_200E_202C_206D_206B_206D_202D_206B_202A_206A_206E_200C_200F_200E_206F_200F_200E_202A_206B_206C_202C_200B_202D_200E_200C_206F_202B_206B_206A_202E((TrackedReference)(object)val, (TrackedReference)null))
					{
						num5 = -1665343236;
						num6 = num5;
					}
					else
					{
						num5 = -1069253459;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1383820962);
					continue;
				}
				case 6u:
					val = (AnimationState)luaObject;
					num = ((int)num2 * -572204338) ^ -1672204986;
					continue;
				case 0u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 1440781847;
						num4 = num3;
					}
					else
					{
						num3 = 1828944020;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -801017024);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4228517730u));
					num = -480998151;
					continue;
				default:
					LuaScriptMgr.Push(L, _202B_206D_202B_202A_206A_200E_202E_206B_202D_206B_202E_200E_206D_202E_200F_202E_202B_200E_202C_202D_202E_206F_202D_206B_200F_206F_202D_202D_206D_202C_200F_202B_200E_206F_200F_200C_202D_206E_206D_206B_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_blendMode(IntPtr L)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AnimationState val = default(AnimationState);
		while (true)
		{
			int num = -1866213803;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1625348546)) % 6)
				{
				case 4u:
					break;
				case 3u:
				{
					val = (AnimationState)luaObject;
					int num5;
					int num6;
					if (_200B_206E_200E_202D_206D_206C_202E_202E_200C_202A_200E_202C_200E_202C_206D_206B_206D_202D_206B_202A_206A_206E_200C_200F_200E_206F_200F_200E_202A_206B_206C_202C_200B_202D_200E_200C_206F_202B_206B_206A_202E((TrackedReference)(object)val, (TrackedReference)null))
					{
						num5 = 58809314;
						num6 = num5;
					}
					else
					{
						num5 = 769027175;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -509150738);
					continue;
				}
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1518882585u));
					num = ((int)num2 * -1498188677) ^ -1868286678;
					continue;
				case 2u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -1698256816;
						num4 = num3;
					}
					else
					{
						num3 = -872319435;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -103801371);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(93161091u));
					num = -1200096739;
					continue;
				default:
					LuaScriptMgr.Push(L, (Enum)(object)_200F_202A_202A_202E_200D_200D_200E_200B_206F_202B_206F_200D_200B_206C_202B_200C_206C_200F_200E_200D_200B_200C_202E_206C_202D_202D_206F_200E_206B_202D_202E_200D_206D_206E_206E_202D_202B_206B_200D_200D_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_enabled(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AnimationState val = default(AnimationState);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 412629361;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x26D13618)) % 8)
				{
				case 6u:
					break;
				case 1u:
				{
					val = (AnimationState)luaObject;
					int num5;
					int num6;
					if (_200B_206E_200E_202D_206D_206C_202E_202E_200C_202A_200E_202C_200E_202C_206D_206B_206D_202D_206B_202A_206A_206E_200C_200F_200E_206F_200F_200E_202A_206B_206C_202C_200B_202D_200E_200C_206F_202B_206B_206A_202E((TrackedReference)(object)val, (TrackedReference)null))
					{
						num5 = 875351391;
						num6 = num5;
					}
					else
					{
						num5 = 2123852825;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -300597555);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2479177141u));
					num = 223258892;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -2127893128;
						num4 = num3;
					}
					else
					{
						num3 = -1919704065;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1247801352);
					continue;
				}
				case 2u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 1491669327) ^ 0x5CE0BB0B);
					continue;
				case 3u:
					num = (int)((num2 * 79438277) ^ 0x2DF6145B);
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1416424057u));
					num = ((int)num2 * -1531868715) ^ 0x19D89558;
					continue;
				default:
					_200B_206A_206E_202D_202C_200F_206C_206D_200C_206A_206C_202D_206E_206D_202E_200B_206A_200F_202A_206B_200E_200C_200E_200B_200B_202C_202C_206D_202B_202E_200E_202C_206E_200B_200F_206E_202D_202E_202D_202B_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_weight(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AnimationState val = default(AnimationState);
		while (true)
		{
			int num = -362884720;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1750416701)) % 7)
				{
				case 3u:
					break;
				case 2u:
					val = (AnimationState)luaObject;
					num = (int)((num2 * 1462230995) ^ 0x15BE1FBE);
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (!_200B_206E_200E_202D_206D_206C_202E_202E_200C_202A_200E_202C_200E_202C_206D_206B_206D_202D_206B_202A_206A_206E_200C_200F_200E_206F_200F_200E_202A_206B_206C_202C_200B_202D_200E_200C_206F_202B_206B_206A_202E((TrackedReference)(object)val, (TrackedReference)null))
					{
						num5 = -2041564129;
						num6 = num5;
					}
					else
					{
						num5 = -1785937398;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -842143525);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(461040037u));
					num = -769000957;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2818796578u));
					num = ((int)num2 * -881783337) ^ 0x6DF7BE2C;
					continue;
				case 4u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 1302952544;
						num4 = num3;
					}
					else
					{
						num3 = 1641600949;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -794018910);
					continue;
				}
				default:
					_202D_202D_200C_200F_200F_202D_206C_200D_202A_206C_200B_200C_206D_206A_200D_202A_200F_206E_200E_206A_202A_206E_202C_206D_206D_202C_206F_200E_200D_206C_206B_206F_206E_206C_206B_206F_202A_206C_206A_206B_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_wrapMode(IntPtr L)
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		AnimationState val = default(AnimationState);
		while (true)
		{
			int num = -1774344611;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1676567973)) % 9)
				{
				case 7u:
					break;
				case 3u:
					num = (int)((num2 * 325926242) ^ 0x7B1FFBD9);
					continue;
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -2146535829) ^ -1846806740;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (!_200B_206E_200E_202D_206D_206C_202E_202E_200C_202A_200E_202C_200E_202C_206D_206B_206D_202D_206B_202A_206A_206E_200C_200F_200E_206F_200F_200E_202A_206B_206C_202C_200B_202D_200E_200C_206F_202B_206B_206A_202E((TrackedReference)(object)val, (TrackedReference)null))
					{
						num5 = 1155338002;
						num6 = num5;
					}
					else
					{
						num5 = 2080834139;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1341780021);
					continue;
				}
				case 6u:
					val = (AnimationState)luaObject;
					num = (int)((num2 * 1635891083) ^ 0x2792DC6A);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -1684136837;
						num4 = num3;
					}
					else
					{
						num3 = -117615036;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 839170632);
					continue;
				}
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(131108899u));
					num = (int)((num2 * 1351210824) ^ 0x6D63ACC1);
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(621760715u));
					num = -24939043;
					continue;
				default:
					_206B_200C_206C_206C_206F_206F_200F_206A_202E_202A_206F_202A_206C_202E_202E_200E_202B_200D_206E_202B_200E_202D_202D_200D_200B_202A_202B_200C_202D_202C_200B_202A_200F_202B_202E_200E_200F_206F_202A_200C_202E(val, (WrapMode)(int)LuaScriptMgr.GetNetObject(L, 3, _206A_200C_202D_202C_206A_202C_202D_202A_200E_202E_202E_206A_202A_202C_200B_200E_200D_200B_200D_202C_206E_206B_200F_202E_202B_200C_202E_206F_200C_200E_202A_202A_202D_206E_202E_206C_206B_200C_206D_200E_202E(typeof(WrapMode).TypeHandle)));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_time(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AnimationState val = (AnimationState)luaObject;
		while (true)
		{
			int num = -1189687823;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -103834228)) % 7)
				{
				case 0u:
					break;
				case 5u:
				{
					int num5;
					int num6;
					if (!_200B_206E_200E_202D_206D_206C_202E_202E_200C_202A_200E_202C_200E_202C_206D_206B_206D_202D_206B_202A_206A_206E_200C_200F_200E_206F_200F_200E_202A_206B_206C_202C_200B_202D_200E_200C_206F_202B_206B_206A_202E((TrackedReference)(object)val, (TrackedReference)null))
					{
						num5 = 1921087273;
						num6 = num5;
					}
					else
					{
						num5 = 180365978;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 904088809);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1570193726u));
					num = -1157158164;
					continue;
				case 2u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 503704758;
						num4 = num3;
					}
					else
					{
						num3 = 1928101141;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 2097479732);
					continue;
				}
				case 4u:
					num = ((int)num2 * -1428722957) ^ 0x68C8909D;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2070188150u));
					num = ((int)num2 * -1503943365) ^ 0x50982F85;
					continue;
				default:
					_202A_200D_200D_206B_202C_206E_206A_200B_200C_206F_200F_200F_200E_202E_200C_200D_202C_202D_202B_200D_202B_206A_206E_200E_200F_206F_200B_200F_206C_206F_206C_200B_200B_206E_206A_206A_206F_206E_200B_202E_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_normalizedTime(IntPtr L)
	{
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		AnimationState val = default(AnimationState);
		while (true)
		{
			int num = -1578498059;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -563745346)) % 9)
				{
				case 4u:
					break;
				case 3u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 81818338;
						num6 = num5;
					}
					else
					{
						num5 = 759375674;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 2068705766);
					continue;
				}
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1345605628u));
					num = (int)((num2 * 1895034275) ^ 0x4F85C495);
					continue;
				case 2u:
					_202C_206E_206E_200C_202B_206E_206F_206D_206D_200F_202D_206B_200B_200D_200B_206F_206E_202B_206A_206E_200E_200B_200B_202D_202B_202B_206E_202C_206F_200B_206B_202E_202E_202D_202D_206C_202C_200B_200B_202E_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					num = -91132114;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4059058405u));
					num = -1184271824;
					continue;
				case 0u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 2121368377) ^ -1912041977;
					continue;
				case 8u:
					num = ((int)num2 * -831838680) ^ -949047080;
					continue;
				case 6u:
				{
					val = (AnimationState)luaObject;
					int num3;
					int num4;
					if (!_200B_206E_200E_202D_206D_206C_202E_202E_200C_202A_200E_202C_200E_202C_206D_206B_206D_202D_206B_202A_206A_206E_200C_200F_200E_206F_200F_200E_202A_206B_206C_202C_200B_202D_200E_200C_206F_202B_206B_206A_202E((TrackedReference)(object)val, (TrackedReference)null))
					{
						num3 = 534256244;
						num4 = num3;
					}
					else
					{
						num3 = 1034245768;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -23114164);
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
	private static int set_speed(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AnimationState val = (AnimationState)luaObject;
		while (true)
		{
			int num = -362167932;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1888690053)) % 6)
				{
				case 5u:
					break;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1233311579u));
					num = ((int)num2 * -1771632963) ^ 0x1E97DC7B;
					continue;
				case 3u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -896281341;
						num6 = num5;
					}
					else
					{
						num5 = -1675609487;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1017134334);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3487751401u));
					num = -1053262723;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!_200B_206E_200E_202D_206D_206C_202E_202E_200C_202A_200E_202C_200E_202C_206D_206B_206D_202D_206B_202A_206A_206E_200C_200F_200E_206F_200F_200E_202A_206B_206C_202C_200B_202D_200E_200C_206F_202B_206B_206A_202E((TrackedReference)(object)val, (TrackedReference)null))
					{
						num3 = -231780045;
						num4 = num3;
					}
					else
					{
						num3 = -2045562808;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1948677810);
					continue;
				}
				default:
					_200C_206C_206F_200E_206F_206D_200F_200E_206B_202B_206C_202C_200D_202B_206C_202B_200D_200F_202D_202A_200C_202E_200E_206B_200B_202C_206C_200B_206E_206E_200D_200C_202A_206F_202C_202B_202D_202D_202D_200D_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_normalizedSpeed(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AnimationState val = (AnimationState)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -648734641;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1453231003)) % 8)
				{
				case 3u:
					break;
				case 6u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -2045459746;
						num6 = num5;
					}
					else
					{
						num5 = -124830136;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -52334473);
					continue;
				}
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1476362974) ^ -1535189725;
					continue;
				case 5u:
					num = (int)((num2 * 1652396927) ^ 0x2EDF425E);
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2368384880u));
					num = -1044691011;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!_200B_206E_200E_202D_206D_206C_202E_202E_200C_202A_200E_202C_200E_202C_206D_206B_206D_202D_206B_202A_206A_206E_200C_200F_200E_206F_200F_200E_202A_206B_206C_202C_200B_202D_200E_200C_206F_202B_206B_206A_202E((TrackedReference)(object)val, (TrackedReference)null))
					{
						num3 = 1908214927;
						num4 = num3;
					}
					else
					{
						num3 = 885364667;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1109407349);
					continue;
				}
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3370426322u));
					num = ((int)num2 * -1243675839) ^ -2019344015;
					continue;
				default:
					_206A_200F_202B_202A_206E_202D_200B_202C_206C_200B_202E_206F_202A_200E_206D_202A_202E_200F_200D_202C_206D_206D_206A_202B_202D_200C_200F_200C_200E_206A_206A_202E_206E_202A_200F_202E_202C_200F_202C_200C_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_layer(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AnimationState val = (AnimationState)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -524053558;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1675562544)) % 8)
				{
				case 3u:
					break;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(118282504u));
					num = -1717768001;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2081448133u));
					num = (int)((num2 * 992975759) ^ 0x287E2368);
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (!_200B_206E_200E_202D_206D_206C_202E_202E_200C_202A_200E_202C_200E_202C_206D_206B_206D_202D_206B_202A_206A_206E_200C_200F_200E_206F_200F_200E_202A_206B_206C_202C_200B_202D_200E_200C_206F_202B_206B_206A_202E((TrackedReference)(object)val, (TrackedReference)null))
					{
						num5 = -537380511;
						num6 = num5;
					}
					else
					{
						num5 = -648306110;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 623171307);
					continue;
				}
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 1318675479) ^ 0x6FAA0CF9);
					continue;
				case 7u:
					_206A_202E_200F_200B_200F_206F_200B_202B_200D_206D_200E_206E_206A_206E_200C_206E_206F_200E_206E_202E_202C_206F_200B_200E_206C_200C_202C_206E_202C_200C_200F_206F_200B_202A_206E_202B_202E_202A_202B_202E(val, (int)LuaScriptMgr.GetNumber(L, 3));
					num = -1588744418;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 1829425182;
						num4 = num3;
					}
					else
					{
						num3 = 294930231;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 664830134);
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
	private static int set_name(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AnimationState val = default(AnimationState);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -377623240;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1760060283)) % 8)
				{
				case 2u:
					break;
				case 5u:
				{
					val = (AnimationState)luaObject;
					int num5;
					int num6;
					if (_200B_206E_200E_202D_206D_206C_202E_202E_200C_202A_200E_202C_200E_202C_206D_206B_206D_202D_206B_202A_206A_206E_200C_200F_200E_206F_200F_200E_202A_206B_206C_202C_200B_202D_200E_200C_206F_202B_206B_206A_202E((TrackedReference)(object)val, (TrackedReference)null))
					{
						num5 = 1854162172;
						num6 = num5;
					}
					else
					{
						num5 = 564321490;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -2102521061);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2534274049u));
					num = (int)((num2 * 785189296) ^ 0x4FE6912D);
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1391923730u));
					num = -1518085827;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -148367830;
						num4 = num3;
					}
					else
					{
						num3 = -2124319024;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -18719455);
					continue;
				}
				case 0u:
					_206A_202D_200F_206E_202B_202B_200C_202A_206B_200F_206E_202D_200C_200E_200E_200B_206C_202E_202D_206F_206E_206E_200D_202C_202C_202D_202D_206C_202E_200C_202D_206E_206D_202E_206E_206C_206F_200B_206D_206F_202E(val, LuaScriptMgr.GetString(L, 3));
					num = -633990726;
					continue;
				case 6u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -634414385) ^ 0x5BDC8AF3;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_blendMode(IntPtr L)
	{
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		AnimationState val = default(AnimationState);
		while (true)
		{
			int num = -1454118510;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -380944271)) % 9)
				{
				case 2u:
					break;
				case 6u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 1857743304;
						num6 = num5;
					}
					else
					{
						num5 = 1043344218;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1539262157);
					continue;
				}
				case 0u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 995178567) ^ -1945417966;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(24327689u));
					num = -519531440;
					continue;
				case 8u:
					_200E_206F_200D_206E_206F_206D_202A_206A_200F_206A_206D_200B_206C_202C_206C_206E_206F_200D_202C_202C_202C_200C_202C_200D_202D_200D_206A_206F_202B_202D_206B_200F_200B_206A_206B_206A_202C_206B_202D_206A_202E(val, (AnimationBlendMode)(int)LuaScriptMgr.GetNetObject(L, 3, _206A_200C_202D_202C_206A_202C_202D_202A_200E_202E_202E_206A_202A_202C_200B_200E_200D_200B_200D_202C_206E_206B_200F_202E_202B_200C_202E_206F_200C_200E_202A_202A_202D_206E_202E_206C_206B_200C_206D_200E_202E(typeof(AnimationBlendMode).TypeHandle)));
					num = -1572078456;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(456066351u));
					num = (int)((num2 * 1132830122) ^ 0x420ECCFB);
					continue;
				case 1u:
				{
					val = (AnimationState)luaObject;
					int num3;
					int num4;
					if (_200B_206E_200E_202D_206D_206C_202E_202E_200C_202A_200E_202C_200E_202C_206D_206B_206D_202D_206B_202A_206A_206E_200C_200F_200E_206F_200F_200E_202A_206B_206C_202C_200B_202D_200E_200C_206F_202B_206B_206A_202E((TrackedReference)(object)val, (TrackedReference)null))
					{
						num3 = -70168099;
						num4 = num3;
					}
					else
					{
						num3 = -936739504;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1169571072);
					continue;
				}
				case 4u:
					num = (int)(num2 * 2046679653) ^ -1380862942;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int AddMixingTransform(IntPtr L)
	{
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		if (num == 2)
		{
			goto IL_000e;
		}
		goto IL_014b;
		IL_000e:
		int num2 = -1179764764;
		goto IL_0013;
		IL_0013:
		AnimationState val4 = default(AnimationState);
		Transform val3 = default(Transform);
		AnimationState val2 = default(AnimationState);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ -61501997)) % 10)
			{
			case 3u:
				break;
			case 7u:
				return 0;
			case 5u:
			{
				bool boolean = LuaScriptMgr.GetBoolean(L, 3);
				_200F_202C_206B_206D_200F_200B_202B_206D_202E_202D_206D_202D_202C_206E_202A_206E_206C_200E_206A_202C_202A_200F_202E_206A_202B_200E_202D_202A_202A_202B_202C_206D_200E_200F_206E_206D_202D_202E_200F_200C_202E(val4, val3, boolean);
				num2 = (int)((num3 * 1921601319) ^ 0x7C0C2665);
				continue;
			}
			case 4u:
				val4 = (AnimationState)LuaScriptMgr.GetTrackedObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3213512923u));
				num2 = (int)((num3 * 30862000) ^ 0x4A13B09);
				continue;
			case 1u:
				val2 = (AnimationState)LuaScriptMgr.GetTrackedObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(800443309u));
				num2 = ((int)num3 * -1520090010) ^ 0x40E55D15;
				continue;
			case 9u:
				return 0;
			case 0u:
				val3 = (Transform)LuaScriptMgr.GetUnityObject(L, 2, _206A_200C_202D_202C_206A_202C_202D_202A_200E_202E_202E_206A_202A_202C_200B_200E_200D_200B_200D_202C_206E_206B_200F_202E_202B_200C_202E_206F_200C_200E_202A_202A_202D_206E_202E_206C_206B_200C_206D_200E_202E(typeof(Transform).TypeHandle));
				num2 = (int)((num3 * 511971165) ^ 0x550DDD70);
				continue;
			case 2u:
			{
				Transform val = (Transform)LuaScriptMgr.GetUnityObject(L, 2, _206A_200C_202D_202C_206A_202C_202D_202A_200E_202E_202E_206A_202A_202C_200B_200E_200D_200B_200D_202C_206E_206B_200F_202E_202B_200C_202E_206F_200C_200E_202A_202A_202D_206E_202E_206C_206B_200C_206D_200E_202E(typeof(Transform).TypeHandle));
				_206D_206C_202D_200D_200B_206D_202B_202E_206B_206C_206E_206C_200B_206B_200C_206D_200D_206A_200F_206C_206C_202B_202E_202A_206F_200F_206C_206E_200E_200C_202B_202D_202C_200D_206A_202D_206D_202B_200F_206E_202E(val2, val);
				num2 = ((int)num3 * -1426350923) ^ -1560756962;
				continue;
			}
			case 6u:
				goto IL_014b;
			default:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(211837918u));
				return 0;
			}
			break;
		}
		goto IL_000e;
		IL_014b:
		int num4;
		if (num != 3)
		{
			num2 = -1519272567;
			num4 = num2;
		}
		else
		{
			num2 = -62650941;
			num4 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int RemoveMixingTransform(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		AnimationState val = (AnimationState)LuaScriptMgr.GetTrackedObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(800443309u));
		Transform val2 = default(Transform);
		while (true)
		{
			int num = 262023347;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0xEC69221)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_0040;
				default:
					_202E_200F_202D_200B_202C_200C_202D_200F_206F_202C_200E_206A_202A_200D_202B_202B_202C_200C_200F_206D_206A_206D_200C_202E_206F_206A_200C_202E_200C_206E_202E_202D_200C_206B_202D_202E_206B_206B_200C_202B_202E(val, val2);
					return 0;
				}
				break;
				IL_0040:
				val2 = (Transform)LuaScriptMgr.GetUnityObject(L, 2, _206A_200C_202D_202C_206A_202C_202D_202A_200E_202E_202E_206A_202A_202C_200B_200E_200D_200B_200D_202C_206E_206B_200F_202E_202B_200C_202E_206F_200C_200E_202A_202A_202D_206E_202E_206C_206B_200C_206D_200E_202E(typeof(Transform).TypeHandle));
				num = (int)(num2 * 50362281) ^ -773566095;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Lua_Eq(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		TrackedReference val = (TrackedReference)((luaObject is TrackedReference) ? luaObject : null);
		TrackedReference val2 = default(TrackedReference);
		while (true)
		{
			int num = -714874540;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -931823527)) % 4)
				{
				case 2u:
					break;
				case 1u:
				{
					object luaObject2 = LuaScriptMgr.GetLuaObject(L, 2);
					val2 = (TrackedReference)((luaObject2 is TrackedReference) ? luaObject2 : null);
					num = (int)(num2 * 1569803059) ^ -1316704242;
					continue;
				}
				case 0u:
				{
					bool b = _200B_206E_200E_202D_206D_206C_202E_202E_200C_202A_200E_202C_200E_202C_206D_206B_206D_202D_206B_202A_206A_206E_200C_200F_200E_206F_200F_200E_202A_206B_206C_202C_200B_202D_200E_200C_206F_202B_206B_206A_202E(val, val2);
					LuaScriptMgr.Push(L, b);
					num = (int)((num2 * 592537333) ^ 0x5E5C2ADA);
					continue;
				}
				default:
					return 1;
				}
				break;
			}
		}
	}

	static Type _206A_200C_202D_202C_206A_202C_202D_202A_200E_202E_202E_206A_202A_202C_200B_200E_200D_200B_200D_202C_206E_206B_200F_202E_202B_200C_202E_206F_200C_200E_202A_202A_202D_206E_202E_206C_206B_200C_206D_200E_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static AnimationState _206A_202A_206D_206B_200F_206A_200C_200D_200C_206F_206F_206A_200F_206B_200B_206E_202C_200E_206B_206A_202C_206F_200F_200C_200F_206D_200B_206B_200D_200B_202A_202D_200E_200C_200E_206F_206A_202C_202B_206F_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new AnimationState();
	}

	static bool _200B_206E_200E_202D_206D_206C_202E_202E_200C_202A_200E_202C_200E_202C_206D_206B_206D_202D_206B_202A_206A_206E_200C_200F_200E_206F_200F_200E_202A_206B_206C_202C_200B_202D_200E_200C_206F_202B_206B_206A_202E(TrackedReference P_0, TrackedReference P_1)
	{
		return P_0 == P_1;
	}

	static bool _202B_200B_202D_202C_200E_206A_202C_200C_200C_206B_206F_200F_202D_206F_202C_200C_200E_200E_202C_200F_200C_202E_202B_202E_200F_206D_202A_200C_206B_200C_206C_202C_200B_202A_200E_200E_200D_206A_206D_200F_202E(AnimationState P_0)
	{
		return P_0.enabled;
	}

	static float _200B_206F_206D_206B_200B_202A_200F_202D_202E_202A_202D_202C_206F_206F_206F_202A_200F_206E_206F_202E_200C_202D_202A_202A_202B_200E_200F_202E_206E_206D_200E_206C_206E_206D_200B_206A_202B_206B_200E_202A_202E(AnimationState P_0)
	{
		return P_0.weight;
	}

	static WrapMode _202C_200D_202D_202A_200C_202D_206B_200B_200F_202A_202C_206C_206A_202D_200B_206A_206F_200D_202B_206D_206B_206D_202C_202B_200D_200D_206A_206E_202B_206F_202A_206D_200B_202D_206E_202B_202D_200E_206A_206C_202E(AnimationState P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.wrapMode;
	}

	static float _202C_200B_200D_200E_200F_206A_200F_206D_206D_206D_202B_202A_206D_206D_202B_206A_200B_202D_200C_200D_206D_206C_206D_202E_202A_202C_202B_206F_200C_202C_200E_206D_206A_206B_206F_202C_206F_206B_206A_200E_202E(AnimationState P_0)
	{
		return P_0.time;
	}

	static float _200E_200E_206E_200E_200B_200D_202E_202D_206C_206E_206F_202B_200C_206D_200C_206D_206E_206B_206F_200D_206B_200B_206F_200D_200D_202D_206F_200E_206F_202B_200F_206E_200D_200C_206B_200C_206B_200F_202A_202E_202E(AnimationState P_0)
	{
		return P_0.normalizedTime;
	}

	static float _200D_206A_200B_202C_202E_202D_206A_200B_200F_202B_200D_206D_202A_200D_206B_202D_206B_200D_206C_206F_202B_202C_206A_206E_202E_206E_206D_200E_202E_206C_206E_200C_200B_200D_200F_202C_200D_206D_200B_202C_202E(AnimationState P_0)
	{
		return P_0.speed;
	}

	static float _206F_206F_206A_206A_202E_202C_200D_206A_206A_202B_202A_202D_206C_206B_200E_206C_202E_206A_200E_202A_202B_202D_202B_200B_202B_202D_206E_202E_206D_200D_200E_200E_200F_202D_200B_206F_202D_206E_202B_206C_202E(AnimationState P_0)
	{
		return P_0.normalizedSpeed;
	}

	static float _206D_206F_202B_206F_202D_206C_202A_202C_206C_206F_200F_206A_202B_206C_202D_202E_206B_200D_206F_200E_206B_206A_202E_202E_200E_206D_202D_200D_200D_200C_206F_202D_200B_206D_200B_206D_202D_202A_202A_206B_202E(AnimationState P_0)
	{
		return P_0.length;
	}

	static int _206A_206E_202C_206F_202C_202D_202B_200F_202C_202A_202C_206F_200E_200F_206E_202B_206C_206C_200C_206B_202A_206C_200D_206E_202E_206C_202E_202B_206F_202D_206D_200F_202C_200C_200F_200D_202D_206A_202B_206D_202E(AnimationState P_0)
	{
		return P_0.layer;
	}

	static AnimationClip _202A_200C_202A_200F_200E_200B_200F_206A_206B_206F_202B_200D_200C_206E_202E_200F_206D_206B_200D_206A_206A_206B_206E_200D_200E_200D_200E_202A_206A_206C_200D_200E_200C_200C_200D_206E_200B_206A_200E_202E_202E(AnimationState P_0)
	{
		return P_0.clip;
	}

	static string _202B_206D_202B_202A_206A_200E_202E_206B_202D_206B_202E_200E_206D_202E_200F_202E_202B_200E_202C_202D_202E_206F_202D_206B_200F_206F_202D_202D_206D_202C_200F_202B_200E_206F_200F_200C_202D_206E_206D_206B_202E(AnimationState P_0)
	{
		return P_0.name;
	}

	static AnimationBlendMode _200F_202A_202A_202E_200D_200D_200E_200B_206F_202B_206F_200D_200B_206C_202B_200C_206C_200F_200E_200D_200B_200C_202E_206C_202D_202D_206F_200E_206B_202D_202E_200D_206D_206E_206E_202D_202B_206B_200D_200D_202E(AnimationState P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.blendMode;
	}

	static void _200B_206A_206E_202D_202C_200F_206C_206D_200C_206A_206C_202D_206E_206D_202E_200B_206A_200F_202A_206B_200E_200C_200E_200B_200B_202C_202C_206D_202B_202E_200E_202C_206E_200B_200F_206E_202D_202E_202D_202B_202E(AnimationState P_0, bool P_1)
	{
		P_0.enabled = P_1;
	}

	static void _202D_202D_200C_200F_200F_202D_206C_200D_202A_206C_200B_200C_206D_206A_200D_202A_200F_206E_200E_206A_202A_206E_202C_206D_206D_202C_206F_200E_200D_206C_206B_206F_206E_206C_206B_206F_202A_206C_206A_206B_202E(AnimationState P_0, float P_1)
	{
		P_0.weight = P_1;
	}

	static void _206B_200C_206C_206C_206F_206F_200F_206A_202E_202A_206F_202A_206C_202E_202E_200E_202B_200D_206E_202B_200E_202D_202D_200D_200B_202A_202B_200C_202D_202C_200B_202A_200F_202B_202E_200E_200F_206F_202A_200C_202E(AnimationState P_0, WrapMode P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.wrapMode = P_1;
	}

	static void _202A_200D_200D_206B_202C_206E_206A_200B_200C_206F_200F_200F_200E_202E_200C_200D_202C_202D_202B_200D_202B_206A_206E_200E_200F_206F_200B_200F_206C_206F_206C_200B_200B_206E_206A_206A_206F_206E_200B_202E_202E(AnimationState P_0, float P_1)
	{
		P_0.time = P_1;
	}

	static void _202C_206E_206E_200C_202B_206E_206F_206D_206D_200F_202D_206B_200B_200D_200B_206F_206E_202B_206A_206E_200E_200B_200B_202D_202B_202B_206E_202C_206F_200B_206B_202E_202E_202D_202D_206C_202C_200B_200B_202E_202E(AnimationState P_0, float P_1)
	{
		P_0.normalizedTime = P_1;
	}

	static void _200C_206C_206F_200E_206F_206D_200F_200E_206B_202B_206C_202C_200D_202B_206C_202B_200D_200F_202D_202A_200C_202E_200E_206B_200B_202C_206C_200B_206E_206E_200D_200C_202A_206F_202C_202B_202D_202D_202D_200D_202E(AnimationState P_0, float P_1)
	{
		P_0.speed = P_1;
	}

	static void _206A_200F_202B_202A_206E_202D_200B_202C_206C_200B_202E_206F_202A_200E_206D_202A_202E_200F_200D_202C_206D_206D_206A_202B_202D_200C_200F_200C_200E_206A_206A_202E_206E_202A_200F_202E_202C_200F_202C_200C_202E(AnimationState P_0, float P_1)
	{
		P_0.normalizedSpeed = P_1;
	}

	static void _206A_202E_200F_200B_200F_206F_200B_202B_200D_206D_200E_206E_206A_206E_200C_206E_206F_200E_206E_202E_202C_206F_200B_200E_206C_200C_202C_206E_202C_200C_200F_206F_200B_202A_206E_202B_202E_202A_202B_202E(AnimationState P_0, int P_1)
	{
		P_0.layer = P_1;
	}

	static void _206A_202D_200F_206E_202B_202B_200C_202A_206B_200F_206E_202D_200C_200E_200E_200B_206C_202E_202D_206F_206E_206E_200D_202C_202C_202D_202D_206C_202E_200C_202D_206E_206D_202E_206E_206C_206F_200B_206D_206F_202E(AnimationState P_0, string P_1)
	{
		P_0.name = P_1;
	}

	static void _200E_206F_200D_206E_206F_206D_202A_206A_200F_206A_206D_200B_206C_202C_206C_206E_206F_200D_202C_202C_202C_200C_202C_200D_202D_200D_206A_206F_202B_202D_206B_200F_200B_206A_206B_206A_202C_206B_202D_206A_202E(AnimationState P_0, AnimationBlendMode P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.blendMode = P_1;
	}

	static void _206D_206C_202D_200D_200B_206D_202B_202E_206B_206C_206E_206C_200B_206B_200C_206D_200D_206A_200F_206C_206C_202B_202E_202A_206F_200F_206C_206E_200E_200C_202B_202D_202C_200D_206A_202D_206D_202B_200F_206E_202E(AnimationState P_0, Transform P_1)
	{
		P_0.AddMixingTransform(P_1);
	}

	static void _200F_202C_206B_206D_200F_200B_202B_206D_202E_202D_206D_202D_202C_206E_202A_206E_206C_200E_206A_202C_202A_200F_202E_206A_202B_200E_202D_202A_202A_202B_202C_206D_200E_200F_206E_206D_202D_202E_200F_200C_202E(AnimationState P_0, Transform P_1, bool P_2)
	{
		P_0.AddMixingTransform(P_1, P_2);
	}

	static void _202E_200F_202D_200B_202C_200C_202D_200F_206F_202C_200E_206A_202A_200D_202B_202B_202C_200C_200F_206D_206A_206D_200C_202E_206F_206A_200C_202E_200C_206E_202E_202D_200C_206B_202D_202E_206B_206B_200C_202B_202E(AnimationState P_0, Transform P_1)
	{
		P_0.RemoveMixingTransform(P_1);
	}
}
