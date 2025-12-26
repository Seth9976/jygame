using System;
using LuaInterface;
using UnityEngine;

public class AnimationClipWrap
{
	private static Type classType = _200E_206B_200D_202B_206B_206A_200F_202C_202E_202E_200D_202B_200F_200C_206B_206C_202D_206F_206E_206B_202B_200B_206E_206D_206A_206B_206A_202B_206A_200F_206B_202E_206A_200F_206A_200E_200F_202C_206B_200D_202E(typeof(AnimationClip).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[8]
		{
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2515911696u), SampleAnimation),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1939946494u), SetCurve),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1582326537u), EnsureQuaternionContinuity),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1359469504u), ClearCurves),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2685019041u), AddEvent),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2705981273u), _202D_200B_202E_202A_202B_202D_200B_200D_206C_206F_206B_206A_200E_202C_200C_200B_200B_206A_202D_202E_200C_200C_202C_202A_202B_206D_202B_206E_206A_202D_206D_200E_206E_202D_202A_202E_206B_206D_202A_200C_202E),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2567984228u), GetClassType),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2206010212u), Lua_Eq)
		};
		LuaField[] fields = default(LuaField[]);
		while (true)
		{
			int num = 643863550;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x55E13CD)) % 4)
				{
				case 0u:
					break;
				default:
					return;
				case 3u:
					fields = new LuaField[7]
					{
						new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2949167492u), get_length, null),
						new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2722321876u), get_frameRate, set_frameRate),
						new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4178903076u), get_wrapMode, set_wrapMode),
						new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1960684304u), get_localBounds, set_localBounds),
						new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3083013959u), get_legacy, set_legacy),
						new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1731346187u), get_humanMotion, null),
						new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2871169507u), get_events, set_events)
					};
					num = ((int)num2 * -9704820) ^ -1939856764;
					continue;
				case 1u:
					LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3341553933u), _200E_206B_200D_202B_206B_206A_200F_202C_202E_202E_200D_202B_200F_200C_206B_206C_202D_206F_206E_206B_202B_200B_206E_206D_206A_206B_206A_202B_206A_200F_206B_202E_206A_200F_206A_200E_200F_202C_206B_200D_202E(typeof(AnimationClip).TypeHandle), regs, fields, _200E_206B_200D_202B_206B_206A_200F_202C_202E_202E_200D_202B_200F_200C_206B_206C_202D_206F_206E_206B_202B_200B_206E_206D_206A_206B_206A_202B_206A_200F_206B_202E_206A_200F_206A_200E_200F_202C_206B_200D_202E(typeof(Object).TypeHandle));
					num = ((int)num2 * -1484711227) ^ 0x3EAB7546;
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _202D_200B_202E_202A_202B_202D_200B_200D_206C_206F_206B_206A_200E_202C_200C_200B_200B_206A_202D_202E_200C_200C_202C_202A_202B_206D_202B_206E_206A_202D_206D_200E_206E_202D_202A_202E_206B_206D_202A_200C_202E(IntPtr P_0)
	{
		if (LuaDLL.lua_gettop(P_0) == 0)
		{
			goto IL_000a;
		}
		goto IL_0049;
		IL_000a:
		int num = 578535446;
		goto IL_000f;
		IL_000f:
		AnimationClip obj = default(AnimationClip);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x152AA25E)) % 5)
			{
			case 0u:
				break;
			case 1u:
				obj = _206E_200E_200C_206F_202D_200C_202B_206A_206B_200E_206F_206C_206E_206F_200D_206F_200F_206E_200C_206F_206E_206B_206F_202C_206F_206B_206B_202E_202C_202D_206B_200F_202B_202E_202E_206A_202C_202E_206C_206C_202E();
				num = ((int)num2 * -2007675187) ^ -1354302331;
				continue;
			case 4u:
				goto IL_0049;
			case 2u:
				LuaScriptMgr.Push(P_0, (Object)(object)obj);
				return 1;
			default:
				return 0;
			}
			break;
		}
		goto IL_000a;
		IL_0049:
		LuaDLL.luaL_error(P_0, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3740179090u));
		num = 2112454549;
		goto IL_000f;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_length(IntPtr L)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AnimationClip val = default(AnimationClip);
		while (true)
		{
			int num = 1419937467;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x17F8277A)) % 8)
				{
				case 6u:
					break;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(489208614u));
					num = 230655741;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3515199887u));
					num = (int)((num2 * 1101984810) ^ 0x33CEEA9F);
					continue;
				case 4u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -176252499;
						num6 = num5;
					}
					else
					{
						num5 = -1701076621;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 16370081);
					continue;
				}
				case 7u:
					LuaScriptMgr.Push(L, _206C_202C_202D_202E_202C_202D_202B_202C_206A_200C_206D_206F_206D_206D_200D_202B_206F_200D_200B_200F_206D_200E_200D_200B_200F_206C_202C_202E_206E_202B_206D_206D_202C_206E_202A_202A_206A_200B_206D_202A_202E(val));
					num = 146604530;
					continue;
				case 1u:
					val = (AnimationClip)luaObject;
					num = ((int)num2 * -1448725174) ^ -1112865390;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (_206F_206F_200B_200D_206D_200B_202C_200B_200F_202C_202D_202D_200B_206D_202A_202C_206C_206F_200D_202E_206B_206D_202D_206A_200D_206D_202C_206F_206C_206D_202D_206A_202B_206F_200B_200F_202E_202C_206D_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = -964772448;
						num4 = num3;
					}
					else
					{
						num3 = -831774205;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1637792881);
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
	private static int get_frameRate(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AnimationClip val = (AnimationClip)luaObject;
		while (true)
		{
			int num = 1002905103;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7BB6D7C2)) % 8)
				{
				case 0u:
					break;
				case 5u:
				{
					int num5;
					int num6;
					if (!_206F_206F_200B_200D_206D_200B_202C_200B_200F_202C_202D_202D_200B_206D_202A_202C_206C_206F_200D_202E_206B_206D_202D_206A_200D_206D_202C_206F_206C_206D_202D_206A_202B_206F_200B_200F_202E_202C_206D_202C_202E((Object)(object)val, (Object)null))
					{
						num5 = 1014806385;
						num6 = num5;
					}
					else
					{
						num5 = 1160269157;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -573822076);
					continue;
				}
				case 1u:
					num = (int)((num2 * 390336) ^ 0x46784705);
					continue;
				case 3u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -889133287;
						num4 = num3;
					}
					else
					{
						num3 = -1804805835;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 594504707);
					continue;
				}
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1462674594u));
					num = 596757445;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2285463488u));
					num = ((int)num2 * -720991844) ^ 0x58A4906B;
					continue;
				case 7u:
					LuaScriptMgr.Push(L, _206A_206A_200D_200E_206D_206A_206A_206A_202D_206E_202E_202C_206E_206E_206A_200C_202D_200F_206B_202C_202C_206A_206B_202E_200C_202D_206E_202E_202A_206E_206C_202B_202C_202D_200C_202E_202E_206C_200B_206A_202E(val));
					num = 1680322294;
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
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AnimationClip val = (AnimationClip)luaObject;
		if (_206F_206F_200B_200D_206D_200B_202C_200B_200F_202C_202D_202D_200B_206D_202A_202C_206C_206F_200D_202E_206B_206D_202D_206A_200D_206D_202C_206F_206C_206D_202D_206A_202B_206F_200B_200F_202E_202C_206D_202C_202E((Object)(object)val, (Object)null))
		{
			LuaTypes luaTypes = default(LuaTypes);
			while (true)
			{
				int num = 1204914262;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x7A5B88D7)) % 7)
					{
					case 6u:
						break;
					case 1u:
						num = (int)(num2 * 1331185257) ^ -56089780;
						continue;
					case 5u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2046754182u));
						num = (int)(num2 * 693600142) ^ -2028779955;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (luaTypes == LuaTypes.LUA_TTABLE)
						{
							num3 = -1565261593;
							num4 = num3;
						}
						else
						{
							num3 = -2011425235;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -753055756);
						continue;
					}
					case 4u:
						luaTypes = LuaDLL.lua_type(L, 1);
						num = (int)(num2 * 3735309) ^ -1356274095;
						continue;
					case 3u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(621760715u));
						num = 1200216142;
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
		LuaScriptMgr.Push(L, (Enum)(object)_202D_202D_202A_202C_200D_206B_202A_206E_206D_200C_200C_206A_202D_206A_202D_202B_206F_206C_202A_200D_206E_206B_206A_206E_200D_206C_200B_202C_202C_200F_206C_206F_206F_202D_202B_206D_200C_200E_202C_202A_202E(val));
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_localBounds(IntPtr L)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AnimationClip val = default(AnimationClip);
		while (true)
		{
			int num = 2034213311;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3F36006C)) % 9)
				{
				case 0u:
					break;
				case 7u:
					val = (AnimationClip)luaObject;
					num = (int)((num2 * 1178782630) ^ 0x623323CA);
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(906472586u));
					num = 461661442;
					continue;
				case 4u:
					num = ((int)num2 * -311219356) ^ -1102201086;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (!_206F_206F_200B_200D_206D_200B_202C_200B_200F_202C_202D_202D_200B_206D_202A_202C_206C_206F_200D_202E_206B_206D_202D_206A_200D_206D_202C_206F_206C_206D_202D_206A_202B_206F_200B_200F_202E_202C_206D_202C_202E((Object)(object)val, (Object)null))
					{
						num5 = -323327262;
						num6 = num5;
					}
					else
					{
						num5 = -1312360285;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -2008106408);
					continue;
				}
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1192763756u));
					num = ((int)num2 * -509823669) ^ 0x62487299;
					continue;
				case 6u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -294300217;
						num4 = num3;
					}
					else
					{
						num3 = -1618670574;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -804515924);
					continue;
				}
				case 5u:
					LuaScriptMgr.Push(L, _200F_200D_206C_200F_200D_202B_206D_200E_206B_206F_206C_202C_206F_206E_206E_200B_206E_202D_206F_202E_202A_206C_200C_206C_206E_200D_200C_202A_202B_206F_206C_200E_206B_200D_200D_200B_200D_200E_206E_202E_202E(val));
					num = 1113786529;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_legacy(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AnimationClip val = (AnimationClip)luaObject;
		while (true)
		{
			int num = 1223400974;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3A4E59BD)) % 8)
				{
				case 0u:
					break;
				case 6u:
					LuaScriptMgr.Push(L, _200B_202A_202B_206E_202A_206E_206D_200D_200C_200D_206E_202C_200C_202D_206C_202A_206D_202B_202C_202C_202C_200C_200D_206F_206E_206D_206F_202C_202B_200C_202C_206A_202A_202A_200F_202C_202E_206B_200C_200D_202E(val));
					num = 876540698;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2447857558u));
					num = 1137101331;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2837243950u));
					num = ((int)num2 * -655747659) ^ 0x7BAFCFE3;
					continue;
				case 2u:
					num = ((int)num2 * -1779990151) ^ -359069599;
					continue;
				case 5u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -28939577;
						num6 = num5;
					}
					else
					{
						num5 = -1808559582;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 993260206);
					continue;
				}
				case 3u:
				{
					int num3;
					int num4;
					if (!_206F_206F_200B_200D_206D_200B_202C_200B_200F_202C_202D_202D_200B_206D_202A_202C_206C_206F_200D_202E_206B_206D_202D_206A_200D_206D_202C_206F_206C_206D_202D_206A_202B_206F_200B_200F_202E_202C_206D_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = -985636424;
						num4 = num3;
					}
					else
					{
						num3 = -1488548805;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -582512599);
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
	private static int get_humanMotion(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AnimationClip val = (AnimationClip)luaObject;
		if (_206F_206F_200B_200D_206D_200B_202C_200B_200F_202C_202D_202D_200B_206D_202A_202C_206C_206F_200D_202E_206B_206D_202D_206A_200D_206D_202C_206F_206C_206D_202D_206A_202B_206F_200B_200F_202E_202C_206D_202C_202E((Object)(object)val, (Object)null))
		{
			LuaTypes luaTypes = default(LuaTypes);
			while (true)
			{
				int num = 700045927;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x2AA02962)) % 6)
					{
					case 0u:
						break;
					case 1u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(346117963u));
						num = (int)(num2 * 179856156) ^ -1850515714;
						continue;
					case 4u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(848958293u));
						num = 2534738;
						continue;
					case 3u:
						luaTypes = LuaDLL.lua_type(L, 1);
						num = ((int)num2 * -947038428) ^ -1215688545;
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (luaTypes == LuaTypes.LUA_TTABLE)
						{
							num3 = -1871812992;
							num4 = num3;
						}
						else
						{
							num3 = -934407;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -74352025);
						continue;
					}
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
		LuaScriptMgr.Push(L, _206C_200E_206E_200C_202A_202A_200E_200E_206C_202E_200E_202D_200E_200E_200D_202C_206C_202C_202B_206C_202B_206B_202B_202E_202D_206D_206F_200B_202A_200E_202D_206E_202D_200C_202D_206E_206F_206F_202C_206B_202E(val));
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_events(IntPtr L)
	{
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		AnimationClip val = default(AnimationClip);
		while (true)
		{
			int num = 1098112522;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1BE5DE3B)) % 9)
				{
				case 8u:
					break;
				case 2u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 93705545;
						num6 = num5;
					}
					else
					{
						num5 = 1207566583;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -526332299);
					continue;
				}
				case 6u:
				{
					int num3;
					int num4;
					if (!_206F_206F_200B_200D_206D_200B_202C_200B_200F_202C_202D_202D_200B_206D_202A_202C_206C_206F_200D_202E_206B_206D_202D_206A_200D_206D_202C_206F_206C_206D_202D_206A_202B_206F_200B_200F_202E_202C_206D_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = -1273740939;
						num4 = num3;
					}
					else
					{
						num3 = -1203894105;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 80774812);
					continue;
				}
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(72842673u));
					num = 1558081385;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4005403126u));
					num = (int)(num2 * 362067355) ^ -1188269279;
					continue;
				case 0u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -691084277) ^ 0x43BDBFF9;
					continue;
				case 5u:
					LuaScriptMgr.PushArray(L, _202D_202A_200E_206D_202E_202D_200F_202A_200C_202B_206B_200C_200D_202A_206B_202A_206C_202E_206B_202A_206B_200B_202C_200E_200E_200B_202E_206C_200D_200D_202E_202B_200F_206C_200C_200F_202B_206D_200C_200C_202E(val));
					num = 210089298;
					continue;
				case 1u:
					val = (AnimationClip)luaObject;
					num = (int)(num2 * 1589475984) ^ -299276150;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_frameRate(IntPtr L)
	{
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AnimationClip val = default(AnimationClip);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -262729990;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2006946065)) % 9)
				{
				case 7u:
					break;
				case 3u:
					_206D_206C_206A_206B_206D_202A_206A_206F_200F_206F_200C_202E_202A_202D_202E_206F_202D_200B_206D_206E_200C_206E_202C_206B_206A_202E_202C_202B_206B_200C_206A_200C_200B_200F_200B_206C_206A_206D_206E_206B_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					num = -2082137044;
					continue;
				case 6u:
					num = (int)((num2 * 894887525) ^ 0x82B6C27);
					continue;
				case 2u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -88782914) ^ -186949494;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -742812661;
						num6 = num5;
					}
					else
					{
						num5 = -1744352317;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1269891942);
					continue;
				}
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3893948759u));
					num = -2055975007;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2285463488u));
					num = (int)(num2 * 847199445) ^ -689902589;
					continue;
				case 1u:
				{
					val = (AnimationClip)luaObject;
					int num3;
					int num4;
					if (_206F_206F_200B_200D_206D_200B_202C_200B_200F_202C_202D_202D_200B_206D_202A_202C_206C_206F_200D_202E_206B_206D_202D_206A_200D_206D_202C_206F_206C_206D_202D_206A_202B_206F_200B_200F_202E_202C_206D_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = 1665596439;
						num4 = num3;
					}
					else
					{
						num3 = 1782981542;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1519503019);
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
	private static int set_wrapMode(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AnimationClip val = (AnimationClip)luaObject;
		if (_206F_206F_200B_200D_206D_200B_202C_200B_200F_202C_202D_202D_200B_206D_202A_202C_206C_206F_200D_202E_206B_206D_202D_206A_200D_206D_202C_206F_206C_206D_202D_206A_202B_206F_200B_200F_202E_202C_206D_202C_202E((Object)(object)val, (Object)null))
		{
			LuaTypes luaTypes = default(LuaTypes);
			while (true)
			{
				int num = -410483912;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1877739894)) % 7)
					{
					case 3u:
						break;
					case 4u:
						luaTypes = LuaDLL.lua_type(L, 1);
						num = (int)(num2 * 999258890) ^ -1300830003;
						continue;
					case 0u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3817083831u));
						num = ((int)num2 * -625071506) ^ 0x6AC026E5;
						continue;
					case 5u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(621760715u));
						num = -1670404477;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (luaTypes == LuaTypes.LUA_TTABLE)
						{
							num3 = -1831133321;
							num4 = num3;
						}
						else
						{
							num3 = -2103869665;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 618748851);
						continue;
					}
					case 6u:
						num = ((int)num2 * -811399003) ^ 0x1AE0AB30;
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
		_200F_202C_206E_202B_200B_202C_206D_202D_202C_200C_202C_202B_202D_206C_200C_202E_202E_206C_206E_202D_202B_200C_200C_206A_206C_202A_206E_202C_202D_202A_202E_200C_200B_206E_206C_206A_202E_200D_206A_206B_202E(val, (WrapMode)(int)LuaScriptMgr.GetNetObject(L, 3, _200E_206B_200D_202B_206B_206A_200F_202C_202E_202E_200D_202B_200F_200C_206B_206C_202D_206F_206E_206B_202B_200B_206E_206D_206A_206B_206A_202B_206A_200F_206B_202E_206A_200F_206A_200E_200F_202C_206B_200D_202E(typeof(WrapMode).TypeHandle)));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_localBounds(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AnimationClip val = (AnimationClip)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1611535377;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x20CD79D0)) % 8)
				{
				case 2u:
					break;
				case 3u:
					num = ((int)num2 * -2073556806) ^ 0x2B743816;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -1610112338;
						num6 = num5;
					}
					else
					{
						num5 = -1607774804;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1595492832);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3850595491u));
					num = ((int)num2 * -536164233) ^ 0x15071091;
					continue;
				case 7u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 1519189695) ^ 0x15AC1174);
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(906472586u));
					num = 1833294872;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (_206F_206F_200B_200D_206D_200B_202C_200B_200F_202C_202D_202D_200B_206D_202A_202C_206C_206F_200D_202E_206B_206D_202D_206A_200D_206D_202C_206F_206C_206D_202D_206A_202B_206F_200B_200F_202E_202C_206D_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = -803578569;
						num4 = num3;
					}
					else
					{
						num3 = -544785416;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 2090377184);
					continue;
				}
				default:
					_200D_200B_200D_202B_202E_206A_200D_206E_200F_206F_200F_206E_202A_202C_206E_206F_202A_206A_202D_206B_200E_202E_206F_200C_200B_200F_206A_206E_206A_202C_202A_202E_206D_202E_202C_202C_206A_206E_206B_202B_202E(val, LuaScriptMgr.GetBounds(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_legacy(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AnimationClip val = (AnimationClip)luaObject;
		while (true)
		{
			int num = -1033345984;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1372850977)) % 7)
				{
				case 2u:
					break;
				case 4u:
				{
					int num5;
					int num6;
					if (_206F_206F_200B_200D_206D_200B_202C_200B_200F_202C_202D_202D_200B_206D_202A_202C_206C_206F_200D_202E_206B_206D_202D_206A_200D_206D_202C_206F_206C_206D_202D_206A_202B_206F_200B_200F_202E_202C_206D_202C_202E((Object)(object)val, (Object)null))
					{
						num5 = 810084489;
						num6 = num5;
					}
					else
					{
						num5 = 797658507;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1631391108);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2866858905u));
					num = -644159113;
					continue;
				case 6u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 431015134;
						num4 = num3;
					}
					else
					{
						num3 = 66620338;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 268941537);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1844862443u));
					num = (int)((num2 * 548379513) ^ 0xA7A89E4);
					continue;
				case 1u:
					_200E_200C_206F_200E_206B_200D_200F_200E_206E_202E_206A_206B_206A_202D_206C_202C_200D_206D_200D_202B_206D_202C_200E_206D_202A_206C_206A_206A_200C_202B_202A_202E_202C_202E_200B_202B_206D_206D_200C_200E_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					num = -574186780;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_events(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AnimationClip val = (AnimationClip)luaObject;
		while (true)
		{
			int num = -1192395140;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1349314753)) % 7)
				{
				case 5u:
					break;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4032198454u));
					num = ((int)num2 * -779386155) ^ 0x19E99205;
					continue;
				case 4u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -724624997;
						num6 = num5;
					}
					else
					{
						num5 = -1288697004;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -943476997);
					continue;
				}
				case 6u:
				{
					int num3;
					int num4;
					if (!_206F_206F_200B_200D_206D_200B_202C_200B_200F_202C_202D_202D_200B_206D_202A_202C_206C_206F_200D_202E_206B_206D_202D_206A_200D_206D_202C_206F_206C_206D_202D_206A_202B_206F_200B_200F_202E_202C_206D_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = 524633547;
						num4 = num3;
					}
					else
					{
						num3 = 1277453955;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1987638787);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3238347326u));
					num = -431171582;
					continue;
				case 0u:
					num = ((int)num2 * -1985127679) ^ -1765910025;
					continue;
				default:
					_202C_202B_202C_202A_200E_200E_202C_206B_206E_206D_200F_206F_202E_206A_202E_202A_206C_200B_200B_206B_200D_200E_206F_200D_206C_202C_206D_200E_206A_206F_202A_202C_200F_200B_200C_202A_200E_202A_206A_206A_202E(val, LuaScriptMgr.GetArrayObject<AnimationEvent>(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SampleAnimation(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 3);
		AnimationClip val = (AnimationClip)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2026297416u));
		GameObject val2 = default(GameObject);
		float num3 = default(float);
		while (true)
		{
			int num = -865489163;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -220816194)) % 5)
				{
				case 0u:
					break;
				case 3u:
					val2 = (GameObject)LuaScriptMgr.GetUnityObject(L, 2, _200E_206B_200D_202B_206B_206A_200F_202C_202E_202E_200D_202B_200F_200C_206B_206C_202D_206F_206E_206B_202B_200B_206E_206D_206A_206B_206A_202B_206A_200F_206B_202E_206A_200F_206A_200E_200F_202C_206B_200D_202E(typeof(GameObject).TypeHandle));
					num = (int)(num2 * 1684483431) ^ -945003297;
					continue;
				case 1u:
					_200C_202E_200D_200E_200F_202E_200E_200B_200E_202B_200F_206B_206C_202C_202D_202D_206F_206B_200E_200E_200E_202B_200C_206A_206D_200F_200E_202C_200D_206D_202D_200C_206D_202E_202E_206E_206A_202E_202E_200C_202E(val, val2, num3);
					num = ((int)num2 * -54128020) ^ 0x5A8F7970;
					continue;
				case 4u:
					num3 = (float)LuaScriptMgr.GetNumber(L, 3);
					num = ((int)num2 * -984381688) ^ 0x561359A1;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SetCurve(IntPtr L)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 5);
		AnimationClip val2 = default(AnimationClip);
		string luaString = default(string);
		Type typeObject = default(Type);
		while (true)
		{
			int num = 2049474104;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6E1A7EA4)) % 5)
				{
				case 3u:
					break;
				case 1u:
					val2 = (AnimationClip)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(410603932u));
					num = ((int)num2 * -553132334) ^ -232231902;
					continue;
				case 2u:
				{
					string luaString2 = LuaScriptMgr.GetLuaString(L, 4);
					AnimationCurve val = (AnimationCurve)LuaScriptMgr.GetNetObject(L, 5, _200E_206B_200D_202B_206B_206A_200F_202C_202E_202E_200D_202B_200F_200C_206B_206C_202D_206F_206E_206B_202B_200B_206E_206D_206A_206B_206A_202B_206A_200F_206B_202E_206A_200F_206A_200E_200F_202C_206B_200D_202E(typeof(AnimationCurve).TypeHandle));
					_206F_206C_206C_202A_206D_200E_206C_200B_200C_206D_200D_202B_200C_206F_206F_200B_202A_206F_200D_202D_200D_200C_202E_206E_206F_200E_200D_200E_200E_200B_202E_206D_206D_206C_206F_200D_206C_206D_206A_202D_202E(val2, luaString, typeObject, luaString2, val);
					num = ((int)num2 * -380046206) ^ -427250932;
					continue;
				}
				case 0u:
					luaString = LuaScriptMgr.GetLuaString(L, 2);
					typeObject = LuaScriptMgr.GetTypeObject(L, 3);
					num = (int)((num2 * 1624617122) ^ 0x46CF6A77);
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int EnsureQuaternionContinuity(IntPtr L)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 1);
		while (true)
		{
			int num = 930387679;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x367A8FDC)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_0029;
				default:
					return 0;
				}
				break;
				IL_0029:
				AnimationClip val = (AnimationClip)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(410603932u));
				_202E_202D_206B_200F_202D_202D_200B_200F_200F_202E_200C_206C_200F_206A_200D_202C_206B_200E_206A_206B_202E_206C_202B_206A_206C_202E_200B_202E_202E_200C_202A_200F_200B_206B_200F_206C_202B_200F_202D_206F_202E(val);
				num = ((int)num2 * -143505820) ^ 0x21AD46F8;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int ClearCurves(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 1);
		AnimationClip val = default(AnimationClip);
		while (true)
		{
			int num = -599231234;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -823434673)) % 4)
				{
				case 3u:
					break;
				case 1u:
					val = (AnimationClip)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3874029459u));
					num = (int)(num2 * 401418265) ^ -1325645472;
					continue;
				case 2u:
					_206E_206C_206E_202C_206A_202E_200D_206F_206D_206B_206C_202B_202A_206D_206E_206A_206E_200D_200B_206A_202C_202A_200D_200E_206A_202E_206A_200E_200C_202C_202C_202D_202D_200E_202B_206D_206E_202C_200E_200D_202E(val);
					num = (int)(num2 * 1373189455) ^ -1635156231;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int AddEvent(IntPtr L)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		while (true)
		{
			int num = 531445519;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0xEB80A62)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_0029;
				default:
					return 0;
				}
				break;
				IL_0029:
				AnimationClip val = (AnimationClip)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(410603932u));
				AnimationEvent val2 = (AnimationEvent)LuaScriptMgr.GetNetObject(L, 2, _200E_206B_200D_202B_206B_206A_200F_202C_202E_202E_200D_202B_200F_200C_206B_206C_202D_206F_206E_206B_202B_200B_206E_206D_206A_206B_206A_202B_206A_200F_206B_202E_206A_200F_206A_200E_200F_202C_206B_200D_202E(typeof(AnimationEvent).TypeHandle));
				_200D_206C_206C_200E_200C_206B_206B_202B_202C_200C_202C_202A_200F_206E_200C_200C_200D_206A_200F_200B_202D_206C_202C_206C_200D_200B_202A_206E_200E_200F_202C_200C_200D_202A_206E_202B_200D_200F_206F_206B_202E(val, val2);
				num = (int)(num2 * 1184184610) ^ -804575678;
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
			int num = 1956426240;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7E0D606B)) % 5)
				{
				case 3u:
					break;
				case 4u:
				{
					bool b = _206F_206F_200B_200D_206D_200B_202C_200B_200F_202C_202D_202D_200B_206D_202A_202C_206C_206F_200D_202E_206B_206D_202D_206A_200D_206D_202C_206F_206C_206D_202D_206A_202B_206F_200B_200F_202E_202C_206D_202C_202E(val, val2);
					LuaScriptMgr.Push(L, b);
					num = ((int)num2 * -398131516) ^ -1353184317;
					continue;
				}
				case 1u:
				{
					object luaObject2 = LuaScriptMgr.GetLuaObject(L, 2);
					val2 = (Object)((luaObject2 is Object) ? luaObject2 : null);
					num = (int)((num2 * 407441630) ^ 0x3F932D49);
					continue;
				}
				case 2u:
				{
					object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
					val = (Object)((luaObject is Object) ? luaObject : null);
					num = (int)(num2 * 1810284561) ^ -1214390494;
					continue;
				}
				default:
					return 1;
				}
				break;
			}
		}
	}

	static Type _200E_206B_200D_202B_206B_206A_200F_202C_202E_202E_200D_202B_200F_200C_206B_206C_202D_206F_206E_206B_202B_200B_206E_206D_206A_206B_206A_202B_206A_200F_206B_202E_206A_200F_206A_200E_200F_202C_206B_200D_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static AnimationClip _206E_200E_200C_206F_202D_200C_202B_206A_206B_200E_206F_206C_206E_206F_200D_206F_200F_206E_200C_206F_206E_206B_206F_202C_206F_206B_206B_202E_202C_202D_206B_200F_202B_202E_202E_206A_202C_202E_206C_206C_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new AnimationClip();
	}

	static bool _206F_206F_200B_200D_206D_200B_202C_200B_200F_202C_202D_202D_200B_206D_202A_202C_206C_206F_200D_202E_206B_206D_202D_206A_200D_206D_202C_206F_206C_206D_202D_206A_202B_206F_200B_200F_202E_202C_206D_202C_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static float _206C_202C_202D_202E_202C_202D_202B_202C_206A_200C_206D_206F_206D_206D_200D_202B_206F_200D_200B_200F_206D_200E_200D_200B_200F_206C_202C_202E_206E_202B_206D_206D_202C_206E_202A_202A_206A_200B_206D_202A_202E(AnimationClip P_0)
	{
		return P_0.length;
	}

	static float _206A_206A_200D_200E_206D_206A_206A_206A_202D_206E_202E_202C_206E_206E_206A_200C_202D_200F_206B_202C_202C_206A_206B_202E_200C_202D_206E_202E_202A_206E_206C_202B_202C_202D_200C_202E_202E_206C_200B_206A_202E(AnimationClip P_0)
	{
		return P_0.frameRate;
	}

	static WrapMode _202D_202D_202A_202C_200D_206B_202A_206E_206D_200C_200C_206A_202D_206A_202D_202B_206F_206C_202A_200D_206E_206B_206A_206E_200D_206C_200B_202C_202C_200F_206C_206F_206F_202D_202B_206D_200C_200E_202C_202A_202E(AnimationClip P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.wrapMode;
	}

	static Bounds _200F_200D_206C_200F_200D_202B_206D_200E_206B_206F_206C_202C_206F_206E_206E_200B_206E_202D_206F_202E_202A_206C_200C_206C_206E_200D_200C_202A_202B_206F_206C_200E_206B_200D_200D_200B_200D_200E_206E_202E_202E(AnimationClip P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.localBounds;
	}

	static bool _200B_202A_202B_206E_202A_206E_206D_200D_200C_200D_206E_202C_200C_202D_206C_202A_206D_202B_202C_202C_202C_200C_200D_206F_206E_206D_206F_202C_202B_200C_202C_206A_202A_202A_200F_202C_202E_206B_200C_200D_202E(AnimationClip P_0)
	{
		return P_0.legacy;
	}

	static bool _206C_200E_206E_200C_202A_202A_200E_200E_206C_202E_200E_202D_200E_200E_200D_202C_206C_202C_202B_206C_202B_206B_202B_202E_202D_206D_206F_200B_202A_200E_202D_206E_202D_200C_202D_206E_206F_206F_202C_206B_202E(AnimationClip P_0)
	{
		return P_0.humanMotion;
	}

	static AnimationEvent[] _202D_202A_200E_206D_202E_202D_200F_202A_200C_202B_206B_200C_200D_202A_206B_202A_206C_202E_206B_202A_206B_200B_202C_200E_200E_200B_202E_206C_200D_200D_202E_202B_200F_206C_200C_200F_202B_206D_200C_200C_202E(AnimationClip P_0)
	{
		return P_0.events;
	}

	static void _206D_206C_206A_206B_206D_202A_206A_206F_200F_206F_200C_202E_202A_202D_202E_206F_202D_200B_206D_206E_200C_206E_202C_206B_206A_202E_202C_202B_206B_200C_206A_200C_200B_200F_200B_206C_206A_206D_206E_206B_202E(AnimationClip P_0, float P_1)
	{
		P_0.frameRate = P_1;
	}

	static void _200F_202C_206E_202B_200B_202C_206D_202D_202C_200C_202C_202B_202D_206C_200C_202E_202E_206C_206E_202D_202B_200C_200C_206A_206C_202A_206E_202C_202D_202A_202E_200C_200B_206E_206C_206A_202E_200D_206A_206B_202E(AnimationClip P_0, WrapMode P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.wrapMode = P_1;
	}

	static void _200D_200B_200D_202B_202E_206A_200D_206E_200F_206F_200F_206E_202A_202C_206E_206F_202A_206A_202D_206B_200E_202E_206F_200C_200B_200F_206A_206E_206A_202C_202A_202E_206D_202E_202C_202C_206A_206E_206B_202B_202E(AnimationClip P_0, Bounds P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.localBounds = P_1;
	}

	static void _200E_200C_206F_200E_206B_200D_200F_200E_206E_202E_206A_206B_206A_202D_206C_202C_200D_206D_200D_202B_206D_202C_200E_206D_202A_206C_206A_206A_200C_202B_202A_202E_202C_202E_200B_202B_206D_206D_200C_200E_202E(AnimationClip P_0, bool P_1)
	{
		P_0.legacy = P_1;
	}

	static void _202C_202B_202C_202A_200E_200E_202C_206B_206E_206D_200F_206F_202E_206A_202E_202A_206C_200B_200B_206B_200D_200E_206F_200D_206C_202C_206D_200E_206A_206F_202A_202C_200F_200B_200C_202A_200E_202A_206A_206A_202E(AnimationClip P_0, AnimationEvent[] P_1)
	{
		P_0.events = P_1;
	}

	static void _200C_202E_200D_200E_200F_202E_200E_200B_200E_202B_200F_206B_206C_202C_202D_202D_206F_206B_200E_200E_200E_202B_200C_206A_206D_200F_200E_202C_200D_206D_202D_200C_206D_202E_202E_206E_206A_202E_202E_200C_202E(AnimationClip P_0, GameObject P_1, float P_2)
	{
		P_0.SampleAnimation(P_1, P_2);
	}

	static void _206F_206C_206C_202A_206D_200E_206C_200B_200C_206D_200D_202B_200C_206F_206F_200B_202A_206F_200D_202D_200D_200C_202E_206E_206F_200E_200D_200E_200E_200B_202E_206D_206D_206C_206F_200D_206C_206D_206A_202D_202E(AnimationClip P_0, string P_1, Type P_2, string P_3, AnimationCurve P_4)
	{
		P_0.SetCurve(P_1, P_2, P_3, P_4);
	}

	static void _202E_202D_206B_200F_202D_202D_200B_200F_200F_202E_200C_206C_200F_206A_200D_202C_206B_200E_206A_206B_202E_206C_202B_206A_206C_202E_200B_202E_202E_200C_202A_200F_200B_206B_200F_206C_202B_200F_202D_206F_202E(AnimationClip P_0)
	{
		P_0.EnsureQuaternionContinuity();
	}

	static void _206E_206C_206E_202C_206A_202E_200D_206F_206D_206B_206C_202B_202A_206D_206E_206A_206E_200D_200B_206A_202C_202A_200D_200E_206A_202E_206A_200E_200C_202C_202C_202D_202D_200E_202B_206D_206E_202C_200E_200D_202E(AnimationClip P_0)
	{
		P_0.ClearCurves();
	}

	static void _200D_206C_206C_200E_200C_206B_206B_202B_202C_200C_202C_202A_200F_206E_200C_200C_200D_206A_200F_200B_202D_206C_202C_206C_200D_200B_202A_206E_200E_200F_202C_200C_200D_202A_206E_202B_200D_200F_206F_206B_202E(AnimationClip P_0, AnimationEvent P_1)
	{
		P_0.AddEvent(P_1);
	}
}
