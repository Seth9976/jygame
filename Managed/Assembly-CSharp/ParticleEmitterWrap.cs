using System;
using LuaInterface;
using UnityEngine;

public class ParticleEmitterWrap
{
	private static Type classType = _200F_206A_202D_202D_200E_200F_206E_202E_206D_200D_200E_200C_206C_202A_200E_200F_202D_206E_206F_200D_206B_200E_200D_206E_202E_206B_206A_200D_206B_202A_200C_206D_200B_202C_206C_202D_200D_200D_206F_202C_202E(typeof(ParticleEmitter).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[6]
		{
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3339591700u), ClearParticles),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(410676585u), Emit),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1985129846u), Simulate),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2705981273u), _206B_200C_202A_206C_206D_200F_200C_200D_202D_206A_200D_200B_202B_206F_202A_206F_200D_202D_200D_200D_206D_206F_202E_206F_200C_202D_206D_206F_200B_202C_206C_200F_206E_206C_200E_206D_206C_202D_200E_200D_202E),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2567984228u), GetClassType),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(396454614u), Lua_Eq)
		};
		LuaField[] fields = default(LuaField[]);
		while (true)
		{
			int num = -353986240;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -273153513)) % 4)
				{
				case 0u:
					break;
				default:
					return;
				case 3u:
					fields = new LuaField[18]
					{
						new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2267893274u), get_emit, set_emit),
						new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(213865832u), get_minSize, set_minSize),
						new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(669216559u), get_maxSize, set_maxSize),
						new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2350119427u), get_minEnergy, set_minEnergy),
						new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(916757886u), get_maxEnergy, set_maxEnergy),
						new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3142048223u), get_minEmission, set_minEmission),
						new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(527371494u), get_maxEmission, set_maxEmission),
						new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(719322690u), get_emitterVelocityScale, set_emitterVelocityScale),
						new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3451427052u), get_worldVelocity, set_worldVelocity),
						new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2915292391u), get_localVelocity, set_localVelocity),
						new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1873943063u), get_rndVelocity, set_rndVelocity),
						new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4079073199u), get_useWorldSpace, set_useWorldSpace),
						new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1643928125u), get_rndRotation, set_rndRotation),
						new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1059848537u), get_angularVelocity, set_angularVelocity),
						new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(34780012u), get_rndAngularVelocity, set_rndAngularVelocity),
						new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3068655422u), get_particles, set_particles),
						new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2799359949u), get_particleCount, null),
						new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(637016890u), get_enabled, set_enabled)
					};
					num = (int)((num2 * 1559115322) ^ 0x4E7A1680);
					continue;
				case 1u:
					LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1838621321u), _200F_206A_202D_202D_200E_200F_206E_202E_206D_200D_200E_200C_206C_202A_200E_200F_202D_206E_206F_200D_206B_200E_200D_206E_202E_206B_206A_200D_206B_202A_200C_206D_200B_202C_206C_202D_200D_200D_206F_202C_202E(typeof(ParticleEmitter).TypeHandle), regs, fields, _200F_206A_202D_202D_200E_200F_206E_202E_206D_200D_200E_200C_206C_202A_200E_200F_202D_206E_206F_200D_206B_200E_200D_206E_202E_206B_206A_200D_206B_202A_200C_206D_200B_202C_206C_202D_200D_200D_206F_202C_202E(typeof(Component).TypeHandle));
					num = ((int)num2 * -1635786110) ^ -364876957;
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _206B_200C_202A_206C_206D_200F_200C_200D_202D_206A_200D_200B_202B_206F_202A_206F_200D_202D_200D_200D_206D_206F_202E_206F_200C_202D_206D_206F_200B_202C_206C_200F_206E_206C_200E_206D_206C_202D_200E_200D_202E(IntPtr P_0)
	{
		LuaDLL.luaL_error(P_0, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2467373287u));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_emit(IntPtr L)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleEmitter val = default(ParticleEmitter);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1398646656;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5BF10133)) % 9)
				{
				case 5u:
					break;
				case 3u:
					val = (ParticleEmitter)luaObject;
					num = ((int)num2 * -1355348998) ^ -1869903571;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1402351833u));
					num = 1480224140;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
					{
						num5 = -820922611;
						num6 = num5;
					}
					else
					{
						num5 = -1758890052;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 131342303);
					continue;
				}
				case 4u:
					LuaScriptMgr.Push(L, _202B_206F_206B_200F_202C_202E_202E_202A_206A_200E_200E_202E_206F_202B_202C_206B_200B_202D_202C_200D_200C_202C_206F_200D_202C_206C_200B_202A_206C_206E_202C_206B_200D_200C_202A_200D_206F_200D_202C_202E(val));
					num = 1738385653;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 231293524;
						num4 = num3;
					}
					else
					{
						num3 = 226957587;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1413721005);
					continue;
				}
				case 1u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 1973772674) ^ 0x5F86BC78);
					continue;
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1832108054u));
					num = ((int)num2 * -556668815) ^ 0x58114337;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_minSize(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleEmitter val = (ParticleEmitter)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1554046478;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x557DD82A)) % 9)
				{
				case 3u:
					break;
				case 8u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 1625777844;
						num6 = num5;
					}
					else
					{
						num5 = 515286288;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 359858884);
					continue;
				}
				case 0u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 431749694) ^ -1976552170;
					continue;
				case 1u:
					num = (int)((num2 * 1098368761) ^ 0x12796757);
					continue;
				case 2u:
					LuaScriptMgr.Push(L, _200F_206B_206B_206F_206E_202C_202C_200D_200D_206D_206A_202A_200B_200E_206B_206F_206F_206F_206A_202D_206E_202C_200C_206F_206E_202B_202E_202A_202E_200D_200E_202D_202E_200E_202E_202E_206E_206A_206E_200F_202E(val));
					num = 2141594978;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1945314533u));
					num = 84042745;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
					{
						num3 = 491007023;
						num4 = num3;
					}
					else
					{
						num3 = 865605817;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -981728176);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1409349368u));
					num = ((int)num2 * -1991259027) ^ 0x7CFFB59E;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_maxSize(IntPtr L)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleEmitter val = default(ParticleEmitter);
		while (true)
		{
			int num = -989737788;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -623819925)) % 7)
				{
				case 6u:
					break;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3213190677u));
					num = -1108893354;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
					{
						num5 = 1855680233;
						num6 = num5;
					}
					else
					{
						num5 = 805059334;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 104975880);
					continue;
				}
				case 1u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -1622610861;
						num4 = num3;
					}
					else
					{
						num3 = -929303519;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -21929622);
					continue;
				}
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3602577069u));
					num = (int)(num2 * 1464005824) ^ -1670879146;
					continue;
				case 4u:
					val = (ParticleEmitter)luaObject;
					num = (int)(num2 * 1976352064) ^ -1549173663;
					continue;
				default:
					LuaScriptMgr.Push(L, _200B_202E_200F_200B_200E_202D_206F_200C_202B_200F_200D_206D_202E_200F_200E_200F_202B_202D_200C_200B_202D_200D_206E_200B_200E_206F_200B_200C_200E_200E_200D_200F_206D_200C_200D_206E_206F_202C_200B_202B_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_minEnergy(IntPtr L)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleEmitter val = default(ParticleEmitter);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -537495560;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -42493065)) % 9)
				{
				case 7u:
					break;
				case 8u:
					val = (ParticleEmitter)luaObject;
					num = (int)((num2 * 1316655834) ^ 0x1FC684F9);
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (!_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
					{
						num5 = -668272721;
						num6 = num5;
					}
					else
					{
						num5 = -1239179535;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1002515223);
					continue;
				}
				case 5u:
					num = ((int)num2 * -514706391) ^ 0x779A0D87;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -829310906;
						num4 = num3;
					}
					else
					{
						num3 = -2059034035;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 2070564015);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(110108900u));
					num = -362296873;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2854787913u));
					num = ((int)num2 * -2085695971) ^ 0x5CF5840F;
					continue;
				case 3u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 771115742) ^ 0x4E9FC69D);
					continue;
				default:
					LuaScriptMgr.Push(L, _206A_202B_206C_206A_202C_202C_202B_202A_200F_206E_206D_206E_206B_202A_206B_202E_200C_206B_206C_200C_202A_202C_202D_200E_206F_206F_200C_200B_206D_200C_200D_206B_200E_202D_200B_200F_200B_200D_206C_202E_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_maxEnergy(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleEmitter val = (ParticleEmitter)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 53612732;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x41DC47CF)) % 7)
				{
				case 5u:
					break;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1094759609u));
					num = 1917910306;
					continue;
				case 6u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 44128638) ^ 0x295C6294);
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 677445816;
						num6 = num5;
					}
					else
					{
						num5 = 628456251;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1656102375);
					continue;
				}
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1936852725u));
					num = (int)(num2 * 1192273701) ^ -275264142;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
					{
						num3 = 129234841;
						num4 = num3;
					}
					else
					{
						num3 = 1883232807;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1050959257);
					continue;
				}
				default:
					LuaScriptMgr.Push(L, _202D_200F_206A_200B_206E_200E_200E_200D_202A_202B_202A_202C_202C_202E_200F_202C_202E_202B_200E_200B_202D_206B_200E_206F_200B_206D_206B_206A_206F_200F_206E_200D_206F_200B_202C_206B_200C_206B_200F_202A_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_minEmission(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleEmitter val = (ParticleEmitter)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -949170187;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -486734325)) % 8)
				{
				case 7u:
					break;
				case 6u:
				{
					int num5;
					int num6;
					if (_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
					{
						num5 = 1846082771;
						num6 = num5;
					}
					else
					{
						num5 = 298579693;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 839794755);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2912382938u));
					num = -29316201;
					continue;
				case 2u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1275662620) ^ 0x6888138A;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -2022106788;
						num4 = num3;
					}
					else
					{
						num3 = -250264838;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1652173398);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1245701581u));
					num = (int)((num2 * 2027156575) ^ 0x23E0658);
					continue;
				case 0u:
					num = ((int)num2 * -506422773) ^ 0x25E29737;
					continue;
				default:
					LuaScriptMgr.Push(L, _202E_206F_206E_202A_200E_200D_200E_200F_200C_202A_202A_202D_206D_202D_206E_200E_200F_202B_206C_200F_200D_202D_206D_202C_202D_202E_202C_206A_202C_202B_206F_206B_200C_200E_206D_200C_202E_200D_202D_200F_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_maxEmission(IntPtr L)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleEmitter val = default(ParticleEmitter);
		while (true)
		{
			int num = 946792656;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x777BEC75)) % 8)
				{
				case 2u:
					break;
				case 6u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 1985560601;
						num6 = num5;
					}
					else
					{
						num5 = 572801396;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 477331980);
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (!_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
					{
						num3 = 1693964310;
						num4 = num3;
					}
					else
					{
						num3 = 1171118419;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1604905839);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1623056511u));
					num = 1605866518;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2790342044u));
					num = ((int)num2 * -1188777709) ^ -1010968579;
					continue;
				case 5u:
					val = (ParticleEmitter)luaObject;
					num = (int)((num2 * 654522159) ^ 0x46C02D3E);
					continue;
				case 3u:
					LuaScriptMgr.Push(L, _206E_206B_202B_200E_206A_202C_200B_200E_202D_206B_202B_206B_202E_206C_206F_200C_206F_200F_202D_200C_202A_202E_202B_206B_200C_200C_202B_202B_202B_200F_202E_202E_202A_202B_206F_202A_200D_206B_202E_202B_202E(val));
					num = 2037388610;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_emitterVelocityScale(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleEmitter val = (ParticleEmitter)luaObject;
		if (_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
		{
			goto IL_0018;
		}
		goto IL_0051;
		IL_0018:
		int num = -282342926;
		goto IL_001d;
		IL_001d:
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1118711588)) % 8)
			{
			case 7u:
				break;
			case 1u:
				goto IL_0051;
			case 3u:
			{
				int num3;
				int num4;
				if (luaTypes == LuaTypes.LUA_TTABLE)
				{
					num3 = -854376573;
					num4 = num3;
				}
				else
				{
					num3 = -1699594983;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 598411005);
				continue;
			}
			case 5u:
				num = ((int)num2 * -1734167782) ^ -47374905;
				continue;
			case 6u:
				luaTypes = LuaDLL.lua_type(L, 1);
				num = (int)((num2 * 1799838523) ^ 0x3BBC1B8D);
				continue;
			case 0u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4141797410u));
				num = (int)((num2 * 1777782944) ^ 0x48EFA111);
				continue;
			case 2u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(480706192u));
				num = -1946023915;
				continue;
			default:
				return 1;
			}
			break;
		}
		goto IL_0018;
		IL_0051:
		LuaScriptMgr.Push(L, _200D_206D_200D_206E_200C_206A_200E_206F_200D_202A_206E_200E_200D_200B_200E_206E_206F_206E_206A_206F_206C_206C_200C_206C_206B_206F_200D_206B_206C_202B_202B_202C_202C_202A_206D_206A_200E_202B_200E_206E_202E(val));
		num = -1796589408;
		goto IL_001d;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_worldVelocity(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleEmitter val = (ParticleEmitter)luaObject;
		while (true)
		{
			int num = 935763868;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x642D113)) % 8)
				{
				case 0u:
					break;
				case 7u:
				{
					int num5;
					int num6;
					if (_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
					{
						num5 = -550035752;
						num6 = num5;
					}
					else
					{
						num5 = -1288326946;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -318190776);
					continue;
				}
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2953858558u));
					num = 499961318;
					continue;
				case 4u:
					num = ((int)num2 * -1580015692) ^ 0x2748DB96;
					continue;
				case 5u:
					LuaScriptMgr.Push(L, _202A_206C_206F_206E_200B_202D_206A_200B_202E_206F_202E_206F_200E_200B_206E_206B_202D_206A_206E_202D_200C_206E_202E_202B_206E_206F_206B_200F_206F_202D_200F_206F_206B_202E_200C_206F_200E_200C_206D_202A_202E(val));
					num = 128864229;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(768693549u));
					num = ((int)num2 * -1934185141) ^ -560243031;
					continue;
				case 3u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -320934447;
						num4 = num3;
					}
					else
					{
						num3 = -494770622;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1063359809);
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
	private static int get_localVelocity(IntPtr L)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleEmitter val = default(ParticleEmitter);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1472456134;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -906180491)) % 10)
				{
				case 2u:
					break;
				case 3u:
					val = (ParticleEmitter)luaObject;
					num = (int)((num2 * 951469294) ^ 0x17D9BF4D);
					continue;
				case 8u:
					LuaScriptMgr.Push(L, _202B_206C_206D_206C_202C_206C_202C_202A_202C_200C_202C_206A_206D_202B_202E_206D_202D_202B_206C_206F_202D_202A_202A_200B_202B_206D_200C_200C_206D_202B_202B_200F_206D_200B_200F_200E_206C_206E_200F_206E_202E(val));
					num = -636673829;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(482760456u));
					num = -851645385;
					continue;
				case 7u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1218968517) ^ 0x40AD6AB8;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -697688220;
						num6 = num5;
					}
					else
					{
						num5 = -8476150;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -374828401);
					continue;
				}
				case 9u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(388070771u));
					num = (int)(num2 * 1800713586) ^ -1310804956;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
					{
						num3 = 1913992378;
						num4 = num3;
					}
					else
					{
						num3 = 1290375257;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 272605995);
					continue;
				}
				case 5u:
					num = (int)((num2 * 1368739098) ^ 0x204583E1);
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_rndVelocity(IntPtr L)
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleEmitter val = default(ParticleEmitter);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -29883147;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -303006018)) % 10)
				{
				case 6u:
					break;
				case 1u:
					val = (ParticleEmitter)luaObject;
					num = (int)(num2 * 1726264652) ^ -909815970;
					continue;
				case 9u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2832866402u));
					num = -1738442054;
					continue;
				case 3u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 1076440040) ^ 0x2CB1DDE1);
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -507971865;
						num6 = num5;
					}
					else
					{
						num5 = -1888038815;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1251819298);
					continue;
				}
				case 0u:
					LuaScriptMgr.Push(L, _200C_206D_202C_202B_202D_206B_202E_200E_202B_206A_206B_200C_200C_202E_202D_200E_200F_202E_202C_200E_200E_202B_206D_200D_200E_206A_202D_206B_200F_206B_200D_200E_206B_202D_206B_206A_202C_200F_202D_202A_202E(val));
					num = -1452257474;
					continue;
				case 2u:
					num = ((int)num2 * -388763137) ^ -1324026436;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2118975701u));
					num = ((int)num2 * -1953783389) ^ 0x5D390FF7;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
					{
						num3 = 203280753;
						num4 = num3;
					}
					else
					{
						num3 = 1726057770;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 114947908);
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
	private static int get_useWorldSpace(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleEmitter val = (ParticleEmitter)luaObject;
		while (true)
		{
			int num = 1595536409;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x23E63555)) % 7)
				{
				case 4u:
					break;
				case 5u:
				{
					int num5;
					int num6;
					if (_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
					{
						num5 = 2013975910;
						num6 = num5;
					}
					else
					{
						num5 = 727394331;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -62167421);
					continue;
				}
				case 0u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -859305829;
						num4 = num3;
					}
					else
					{
						num3 = -955241614;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 679399717);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3804836199u));
					num = (int)((num2 * 1861612499) ^ 0x6EC216D8);
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3672639896u));
					num = 1685264895;
					continue;
				case 1u:
					LuaScriptMgr.Push(L, _200B_200D_200D_202E_202D_206B_200D_200B_206F_206D_202E_202B_202A_202C_202A_202A_200C_200E_202E_200B_202C_200C_206B_206F_202B_202D_206C_200C_202A_200B_206B_206C_200F_206C_200E_206F_206B_200E_200D_206B_202E(val));
					num = 1928753907;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_rndRotation(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleEmitter val = (ParticleEmitter)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -815801369;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1889151611)) % 8)
				{
				case 3u:
					break;
				case 6u:
					num = (int)(num2 * 661961698) ^ -216706840;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3527461614u));
					num = (int)((num2 * 1258156669) ^ 0x316B873B);
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(471137366u));
					num = -1171508924;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 1159670506;
						num6 = num5;
					}
					else
					{
						num5 = 863430310;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1435160607);
					continue;
				}
				case 2u:
				{
					int num3;
					int num4;
					if (!_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
					{
						num3 = 408750166;
						num4 = num3;
					}
					else
					{
						num3 = 967649808;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 31245529);
					continue;
				}
				case 7u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1789573836) ^ 0x1B9B397C;
					continue;
				default:
					LuaScriptMgr.Push(L, _206C_200E_206D_202D_200D_200B_206B_206E_206F_202D_202D_202E_200B_200E_202D_206C_206F_206B_206A_206E_202C_200F_200C_200D_206B_202D_206F_206D_202C_206E_202D_200C_206C_206C_206B_206F_206C_202E_206A_206F_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_angularVelocity(IntPtr L)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleEmitter val = default(ParticleEmitter);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 467316125;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x42827CBB)) % 10)
				{
				case 8u:
					break;
				case 4u:
					val = (ParticleEmitter)luaObject;
					num = (int)(num2 * 72764693) ^ -1509356092;
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 1641853242;
						num6 = num5;
					}
					else
					{
						num5 = 851890500;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1159674855);
					continue;
				}
				case 9u:
					LuaScriptMgr.Push(L, _202D_202A_206E_200F_206E_202C_206D_200B_202A_202D_206D_202D_206D_206C_206E_206B_206C_206A_202B_202C_206E_202D_202B_202C_200B_206B_206B_200C_206B_206A_200B_202E_206E_206C_206C_202A_202E_202D_200F_200F_202E(val));
					num = 1550353837;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3374741610u));
					num = (int)(num2 * 2035869887) ^ -221826720;
					continue;
				case 2u:
					num = ((int)num2 * -740662613) ^ 0x19E6ABB2;
					continue;
				case 3u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 24577581) ^ -495408440;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(740524972u));
					num = 1720480016;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
					{
						num3 = -519092801;
						num4 = num3;
					}
					else
					{
						num3 = -1164653473;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1735119535);
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
	private static int get_rndAngularVelocity(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleEmitter val = default(ParticleEmitter);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1710795943;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x35ABB3E)) % 8)
				{
				case 4u:
					break;
				case 1u:
					val = (ParticleEmitter)luaObject;
					num = (int)(num2 * 542065700) ^ -600210758;
					continue;
				case 0u:
				{
					int num5;
					int num6;
					if (!_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
					{
						num5 = 441903049;
						num6 = num5;
					}
					else
					{
						num5 = 1896235851;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -369643030);
					continue;
				}
				case 5u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 1308499573) ^ 0xE8AF659);
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 858352259;
						num4 = num3;
					}
					else
					{
						num3 = 541860842;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 653051257);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1784284012u));
					num = ((int)num2 * -129020966) ^ -498273305;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(343301997u));
					num = 114204617;
					continue;
				default:
					LuaScriptMgr.Push(L, _202B_200B_202A_206A_200C_202B_206C_200F_200F_200F_206B_202E_202D_206F_202C_202A_206E_206E_200E_206E_200D_200F_206E_200D_206E_200E_202B_202D_200D_202C_200E_206A_206B_202B_202E_202E_206D_206D_206E_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_particles(IntPtr L)
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		ParticleEmitter val = default(ParticleEmitter);
		while (true)
		{
			int num = -2100217689;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1390664394)) % 8)
				{
				case 3u:
					break;
				case 5u:
					num = ((int)num2 * -1592431074) ^ 0x786CFA44;
					continue;
				case 7u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 2010608360) ^ 0x3CCC7F96);
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2022377210u));
					num = (int)((num2 * 2057347983) ^ 0x7CCFD609);
					continue;
				case 1u:
				{
					val = (ParticleEmitter)luaObject;
					int num5;
					int num6;
					if (_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
					{
						num5 = 2122135006;
						num6 = num5;
					}
					else
					{
						num5 = 782260685;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -149204465);
					continue;
				}
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2556124762u));
					num = -1419217742;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 2105750488;
						num4 = num3;
					}
					else
					{
						num3 = 1885613812;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 983021693);
					continue;
				}
				default:
					LuaScriptMgr.PushArray(L, _200F_202D_202D_202C_202B_206F_206F_200F_200E_200B_200B_202A_200E_202C_206E_202B_200D_206C_202B_200C_202A_200E_202E_206F_206D_202D_202C_202B_200D_202C_202E_200F_202A_200C_206C_206C_206D_202B_200F_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_particleCount(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleEmitter val = (ParticleEmitter)luaObject;
		if (_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
		{
			LuaTypes luaTypes = default(LuaTypes);
			while (true)
			{
				int num = -524770083;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -336014234)) % 7)
					{
					case 6u:
						break;
					case 4u:
						luaTypes = LuaDLL.lua_type(L, 1);
						num = ((int)num2 * -2095129085) ^ 0x68F7FAD0;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (luaTypes != LuaTypes.LUA_TTABLE)
						{
							num3 = 1306976497;
							num4 = num3;
						}
						else
						{
							num3 = 1269355073;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 1525319448);
						continue;
					}
					case 0u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1868798587u));
						num = -621667154;
						continue;
					case 2u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2945469657u));
						num = (int)((num2 * 1808017740) ^ 0x689DB14F);
						continue;
					case 3u:
						num = (int)(num2 * 1492817225) ^ -2132642005;
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
		LuaScriptMgr.Push(L, _202E_202E_206D_206B_202D_206A_200B_202C_202D_206B_202C_206F_206A_200C_202E_200E_202A_206D_202D_202B_202B_200E_200F_206B_206D_206B_202B_206C_206C_200C_200B_206F_206C_200D_206F_206C_202D_202E_200E_202E_202E(val));
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_enabled(IntPtr L)
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleEmitter val = default(ParticleEmitter);
		while (true)
		{
			int num = 1120114945;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6D4CFCAB)) % 9)
				{
				case 0u:
					break;
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2562779632u));
					num = 1247940998;
					continue;
				case 6u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -1817513222;
						num6 = num5;
					}
					else
					{
						num5 = -475852150;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1217988589);
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (!_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
					{
						num3 = 1546148174;
						num4 = num3;
					}
					else
					{
						num3 = 514786622;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -371357864);
					continue;
				}
				case 2u:
					val = (ParticleEmitter)luaObject;
					num = ((int)num2 * -695977217) ^ 0x1F4C79F6;
					continue;
				case 4u:
					LuaScriptMgr.Push(L, _202D_200F_200F_200F_202D_206D_200F_200C_200F_206C_206F_206C_202C_206C_202C_206F_200C_206F_206F_200B_206E_206A_202D_206E_200F_206A_206A_202B_206B_202D_206A_202D_202C_200B_206F_200E_202C_206E_200E_200F_202E(val));
					num = 1166386579;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1141766380u));
					num = ((int)num2 * -1917943189) ^ 0x17357C06;
					continue;
				case 3u:
					num = (int)((num2 * 868309823) ^ 0x367B91FD);
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_emit(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleEmitter val = default(ParticleEmitter);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1512519659;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2F8D767C)) % 8)
				{
				case 2u:
					break;
				case 7u:
					val = (ParticleEmitter)luaObject;
					num = ((int)num2 * -1355375924) ^ 0x60E25778;
					continue;
				case 0u:
				{
					int num5;
					int num6;
					if (_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
					{
						num5 = -912889185;
						num6 = num5;
					}
					else
					{
						num5 = -207276528;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 449041628);
					continue;
				}
				case 3u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1537281911) ^ -803998294;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1402351833u));
					num = 1976831696;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1832108054u));
					num = (int)(num2 * 19538648) ^ -1037779712;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 131241200;
						num4 = num3;
					}
					else
					{
						num3 = 1608850231;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -211921223);
					continue;
				}
				default:
					_202B_206F_200E_200C_200C_206E_206A_206D_202A_200D_202E_202D_200C_206D_200D_200E_206B_206F_206B_206E_200E_200C_200D_206B_202A_200F_206F_202C_200C_206D_202C_206E_200D_206D_200E_202A_200C_206C_202A_202B_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_minSize(IntPtr L)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		ParticleEmitter val = default(ParticleEmitter);
		while (true)
		{
			int num = -1253407674;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -663683624)) % 8)
				{
				case 7u:
					break;
				case 2u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -373591820;
						num6 = num5;
					}
					else
					{
						num5 = -1180938711;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 849582800);
					continue;
				}
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(614286749u));
					num = (int)(num2 * 1176204778) ^ -1888773017;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3912253203u));
					num = -329998227;
					continue;
				case 3u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 2019717549) ^ 0x6703C5E5);
					continue;
				case 6u:
				{
					val = (ParticleEmitter)luaObject;
					int num3;
					int num4;
					if (_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
					{
						num3 = -1673608147;
						num4 = num3;
					}
					else
					{
						num3 = -886846885;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1756761589);
					continue;
				}
				case 5u:
					_206F_202C_202E_200B_206B_202A_200B_202D_202E_206D_202C_202D_202E_200E_206D_206B_202C_206B_200B_200B_202A_202E_202C_206C_202A_202B_202C_202B_206D_200D_202A_206A_202A_202D_202B_206A_200F_200F_206E_202D_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					num = -454595192;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_maxSize(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleEmitter val = default(ParticleEmitter);
		while (true)
		{
			int num = -1799760153;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -364237687)) % 8)
				{
				case 0u:
					break;
				case 6u:
				{
					val = (ParticleEmitter)luaObject;
					int num5;
					int num6;
					if (!_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
					{
						num5 = 1061439604;
						num6 = num5;
					}
					else
					{
						num5 = 191706944;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1008798999);
					continue;
				}
				case 4u:
					num = (int)(num2 * 445517651) ^ -808432438;
					continue;
				case 3u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 951325336;
						num4 = num3;
					}
					else
					{
						num3 = 742695587;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 489182641);
					continue;
				}
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1298131859u));
					num = (int)(num2 * 2003192432) ^ -1258525619;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3213190677u));
					num = -459973226;
					continue;
				case 7u:
					_200F_202B_206E_206A_206C_200E_200B_202B_206A_200C_206B_200C_206E_200C_206A_200F_206B_202B_200D_206D_206A_202A_200D_202B_206E_200C_206F_200E_200C_200E_206A_200C_206C_202E_200B_202C_206A_202A_206F_202E_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					num = -1190286044;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_minEnergy(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleEmitter val = default(ParticleEmitter);
		while (true)
		{
			int num = 1279244191;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x46BEA781)) % 8)
				{
				case 3u:
					break;
				case 6u:
					val = (ParticleEmitter)luaObject;
					num = ((int)num2 * -886447539) ^ 0x40CD27E8;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4292782147u));
					num = ((int)num2 * -508226516) ^ -2033002732;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
					{
						num5 = 1019585908;
						num6 = num5;
					}
					else
					{
						num5 = 1441347986;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 808365783);
					continue;
				}
				case 4u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 281528309;
						num4 = num3;
					}
					else
					{
						num3 = 62839524;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 210105761);
					continue;
				}
				case 5u:
					num = (int)((num2 * 1962040627) ^ 0x51EA9D24);
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(830611158u));
					num = 1531743147;
					continue;
				default:
					_206C_206D_206C_206A_200D_202C_200F_202E_202E_206E_200E_206A_202A_200F_202E_206C_200D_202B_202A_206C_202A_206F_206D_200C_202C_202C_206C_206B_206B_200B_206D_200E_202A_206F_202C_206C_206A_200E_200C_202A_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_maxEnergy(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleEmitter val = (ParticleEmitter)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 962631297;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7FB2EDBB)) % 7)
				{
				case 0u:
					break;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1094759609u));
					num = 1283123181;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(309195883u));
					num = ((int)num2 * -1926785781) ^ 0x1E57F4E8;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
					{
						num5 = 654118859;
						num6 = num5;
					}
					else
					{
						num5 = 1989056207;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 976694917);
					continue;
				}
				case 2u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -904154658) ^ 0x417D0721;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -2106870458;
						num4 = num3;
					}
					else
					{
						num3 = -140110697;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -45172125);
					continue;
				}
				default:
					_206A_206F_200D_202D_200E_202C_202C_206A_200F_202D_202E_202C_206E_202E_200D_200F_206A_206B_202A_202C_202B_200F_200E_202E_202D_202C_202C_200E_200C_206D_200C_206B_200D_206C_206D_202C_202A_206C_200B_200D_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_minEmission(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleEmitter val = default(ParticleEmitter);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1122871362;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x341D591)) % 8)
				{
				case 6u:
					break;
				case 3u:
				{
					val = (ParticleEmitter)luaObject;
					int num5;
					int num6;
					if (_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
					{
						num5 = -1105319683;
						num6 = num5;
					}
					else
					{
						num5 = -832591960;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -650704145);
					continue;
				}
				case 5u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -872499689;
						num4 = num3;
					}
					else
					{
						num3 = -822436243;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -294131578);
					continue;
				}
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1054874851u));
					num = 1041699413;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3114652556u));
					num = (int)((num2 * 1270982098) ^ 0x4BC9D565);
					continue;
				case 4u:
					_202A_200E_206A_202B_200C_206A_206F_200D_200B_206B_206D_200F_202B_200B_206B_206E_202D_200D_206C_202A_206F_200C_202D_202D_206B_200E_202A_200D_206F_206C_200B_202D_202D_200E_200F_206F_206F_202C_200E_206D_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					num = 769731238;
					continue;
				case 1u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -324105970) ^ -527278886;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_maxEmission(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleEmitter val = (ParticleEmitter)luaObject;
		if (_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
		{
			LuaTypes luaTypes = default(LuaTypes);
			while (true)
			{
				int num = -37258371;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1742301842)) % 6)
					{
					case 4u:
						break;
					case 1u:
						luaTypes = LuaDLL.lua_type(L, 1);
						num = (int)(num2 * 367403678) ^ -1236349341;
						continue;
					case 0u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2043373355u));
						num = -1431206608;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (luaTypes == LuaTypes.LUA_TTABLE)
						{
							num3 = 28234107;
							num4 = num3;
						}
						else
						{
							num3 = 436708392;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -752812832);
						continue;
					}
					case 5u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1509850032u));
						num = (int)((num2 * 984753671) ^ 0x5FEF1A43);
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
		_206F_200D_202E_200B_200B_202C_200B_206B_200C_200B_202E_200B_206C_206A_206D_206A_206D_200B_202A_200D_202E_202E_206F_206D_206F_202E_200B_200E_200D_206E_202A_202D_200F_200C_200D_202A_202B_200C_202A_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_emitterVelocityScale(IntPtr L)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleEmitter val = default(ParticleEmitter);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1140269116;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2B525CDB)) % 9)
				{
				case 0u:
					break;
				case 6u:
					val = (ParticleEmitter)luaObject;
					num = (int)((num2 * 1313513855) ^ 0x2077FA02);
					continue;
				case 7u:
					_206F_200F_200E_206B_200C_202D_206B_202A_206F_206A_206C_202B_206A_202D_206B_206A_206C_202A_206E_206D_202C_206E_206E_206C_206B_202D_200D_200E_200B_200E_202B_206E_200C_200D_200C_206A_206F_206E_206F_202B_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					num = 182359082;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4141797410u));
					num = ((int)num2 * -1004378670) ^ -985879053;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (!_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
					{
						num5 = 1178319755;
						num6 = num5;
					}
					else
					{
						num5 = 1197223057;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1478660307);
					continue;
				}
				case 4u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 442211442;
						num4 = num3;
					}
					else
					{
						num3 = 310042647;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -94880697);
					continue;
				}
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(480706192u));
					num = 591744587;
					continue;
				case 5u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 521178437) ^ -1726318614;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_worldVelocity(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleEmitter val = (ParticleEmitter)luaObject;
		while (true)
		{
			int num = -242921058;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1328682007)) % 7)
				{
				case 0u:
					break;
				case 4u:
					num = ((int)num2 * -2135944220) ^ 0x498CE3C8;
					continue;
				case 5u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 1838571251;
						num6 = num5;
					}
					else
					{
						num5 = 547577801;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -837301255);
					continue;
				}
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(768693549u));
					num = ((int)num2 * -960356016) ^ -1447243652;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2953858558u));
					num = -1532459204;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
					{
						num3 = -298882040;
						num4 = num3;
					}
					else
					{
						num3 = -139322410;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 528816870);
					continue;
				}
				default:
					_200D_202B_202B_206C_202D_206A_202B_202B_202E_200E_206A_206E_202B_200C_206A_200E_202D_200F_202B_200B_206E_202C_200D_206E_202C_206C_200E_202D_200D_206A_200D_206C_200B_206D_206C_202A_206B_206B_202D_200E_202E(val, LuaScriptMgr.GetVector3(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_localVelocity(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleEmitter val = (ParticleEmitter)luaObject;
		if (_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
		{
			LuaTypes luaTypes = default(LuaTypes);
			while (true)
			{
				int num = -2119266675;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -791113411)) % 7)
					{
					case 6u:
						break;
					case 4u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3466229716u));
						num = -1208003389;
						continue;
					case 0u:
						num = (int)((num2 * 1825507938) ^ 0x7B325FCF);
						continue;
					case 3u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1594197159u));
						num = ((int)num2 * -1126155510) ^ 0x5C8152CD;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (luaTypes != LuaTypes.LUA_TTABLE)
						{
							num3 = -764934505;
							num4 = num3;
						}
						else
						{
							num3 = -2114048290;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 23268794);
						continue;
					}
					case 1u:
						luaTypes = LuaDLL.lua_type(L, 1);
						num = ((int)num2 * -1524647339) ^ -1547318109;
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
		_202B_206D_206F_202C_206E_206E_200F_200F_202B_206E_206C_206D_202B_200C_200F_200E_206A_206E_200E_202A_206F_200E_202C_200D_200F_202A_202E_202C_202E_206A_202E_202E_202A_200C_206A_200D_202A_200C_206D_202C_202E(val, LuaScriptMgr.GetVector3(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_rndVelocity(IntPtr L)
	{
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleEmitter val = default(ParticleEmitter);
		while (true)
		{
			int num = 21040331;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6CCC45B8)) % 8)
				{
				case 5u:
					break;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1805479058u));
					num = 315409140;
					continue;
				case 0u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 307886138;
						num6 = num5;
					}
					else
					{
						num5 = 103697185;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 125902499);
					continue;
				}
				case 4u:
					_206D_200D_200B_200B_206F_206F_200B_200C_206C_206D_202C_202E_206C_200D_200C_200F_200B_200D_200C_206B_200F_206B_206D_202E_206F_206D_202E_202C_206B_200D_202B_206C_202B_202A_202C_206A_206C_206C_202E_200C_202E(val, LuaScriptMgr.GetVector3(L, 3));
					num = 1348304647;
					continue;
				case 6u:
					num = ((int)num2 * -695497210) ^ 0x6A889E90;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(564555536u));
					num = (int)((num2 * 1758298585) ^ 0x10402EC7);
					continue;
				case 3u:
				{
					val = (ParticleEmitter)luaObject;
					int num3;
					int num4;
					if (!_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
					{
						num3 = 1981737353;
						num4 = num3;
					}
					else
					{
						num3 = 1302219661;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 2043231055);
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
	private static int set_useWorldSpace(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleEmitter val = (ParticleEmitter)luaObject;
		while (true)
		{
			int num = 1981439261;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1912C787)) % 6)
				{
				case 5u:
					break;
				case 4u:
				{
					int num5;
					int num6;
					if (_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
					{
						num5 = 397346983;
						num6 = num5;
					}
					else
					{
						num5 = 287697569;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1451405140);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1431448411u));
					num = 1617696217;
					continue;
				case 0u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 2137999324;
						num4 = num3;
					}
					else
					{
						num3 = 54932984;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -528509882);
					continue;
				}
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2389558646u));
					num = (int)((num2 * 372636657) ^ 0x5BD8F242);
					continue;
				default:
					_202D_206E_202E_202C_202B_200F_200B_206B_206E_206E_200D_202D_200C_202A_206A_202C_202E_202B_206F_206C_202A_202A_200E_202E_206C_202C_206B_202D_202D_202A_200F_200D_206A_200C_200E_200E_200D_200D_200B_206D_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_rndRotation(IntPtr L)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleEmitter val = default(ParticleEmitter);
		while (true)
		{
			int num = 1731304030;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6A203157)) % 8)
				{
				case 2u:
					break;
				case 0u:
					num = ((int)num2 * -1362916029) ^ 0x19868D8A;
					continue;
				case 4u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 641089188;
						num6 = num5;
					}
					else
					{
						num5 = 337479528;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -2074924507);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3152068468u));
					num = (int)(num2 * 248668465) ^ -1617038684;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(471137366u));
					num = 1200121346;
					continue;
				case 1u:
				{
					val = (ParticleEmitter)luaObject;
					int num3;
					int num4;
					if (_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
					{
						num3 = 1089746153;
						num4 = num3;
					}
					else
					{
						num3 = 854322152;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -853575910);
					continue;
				}
				case 5u:
					_206C_206F_206C_206B_206E_200F_202D_202A_202D_200F_202B_206C_200C_206E_206E_200D_206D_200B_200E_200C_200D_206A_202B_206E_206B_202C_202C_206F_202E_202E_200B_200E_200C_206A_202A_202B_200F_206E_200B_202D_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					num = 1867531817;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_angularVelocity(IntPtr L)
	{
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		ParticleEmitter val = default(ParticleEmitter);
		while (true)
		{
			int num = -887416611;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1963586466)) % 8)
				{
				case 2u:
					break;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(264578763u));
					num = (int)(num2 * 1271094140) ^ -1695587334;
					continue;
				case 6u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -421205662) ^ -1249260329;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -952643477;
						num6 = num5;
					}
					else
					{
						num5 = -879525246;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -817763996);
					continue;
				}
				case 3u:
				{
					val = (ParticleEmitter)luaObject;
					int num3;
					int num4;
					if (_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
					{
						num3 = 1432948108;
						num4 = num3;
					}
					else
					{
						num3 = 849185038;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 372379612);
					continue;
				}
				case 4u:
					_202C_206B_206A_202D_206C_202C_200D_202C_200C_200E_202B_200D_202B_202B_202A_206A_202B_206F_202D_200B_200C_206A_200F_206F_200B_206E_200F_202A_200C_206B_206D_200E_202A_200D_200F_202A_206E_202B_200D_206A_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					num = -1544125447;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(388305429u));
					num = -48577382;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_rndAngularVelocity(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleEmitter val = default(ParticleEmitter);
		while (true)
		{
			int num = 778147800;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6B65E402)) % 8)
				{
				case 0u:
					break;
				case 2u:
					val = (ParticleEmitter)luaObject;
					num = (int)(num2 * 2072683070) ^ -303285301;
					continue;
				case 4u:
					_206B_200D_202B_206D_202E_202C_200B_200D_202A_202E_206D_200E_206D_200F_200D_206F_206F_206C_206C_206A_200B_200E_200E_206B_202E_206C_202A_206E_202B_202B_200C_202E_200F_206D_206B_200B_200E_200D_200E_200F_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					num = 1267878443;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
					{
						num5 = 1063559194;
						num6 = num5;
					}
					else
					{
						num5 = 204258417;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -896902149);
					continue;
				}
				case 7u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -44375278;
						num4 = num3;
					}
					else
					{
						num3 = -1744801889;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 767118885);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1767119577u));
					num = 152749718;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(299536035u));
					num = (int)(num2 * 1132276270) ^ -1623840020;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_particles(IntPtr L)
	{
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleEmitter val = default(ParticleEmitter);
		while (true)
		{
			int num = 437383044;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0xCA54AE8)) % 8)
				{
				case 6u:
					break;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1345343439u));
					num = (int)(num2 * 381332351) ^ -2114333235;
					continue;
				case 3u:
					_206F_200E_202D_202C_200F_200F_200C_200C_206C_206C_202C_200F_206F_202D_206A_202B_206A_202C_206E_206D_200E_202C_206A_202E_206C_206C_206D_206D_206F_206A_200B_202D_202B_202A_202C_206B_200D_206A_206D_202E_202E(val, LuaScriptMgr.GetArrayObject<Particle>(L, 3));
					num = 1480178717;
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
					{
						num5 = 1943767966;
						num6 = num5;
					}
					else
					{
						num5 = 1189777594;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -796235695);
					continue;
				}
				case 4u:
					val = (ParticleEmitter)luaObject;
					num = ((int)num2 * -1420905360) ^ 0x62D78771;
					continue;
				case 7u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 1366530074;
						num4 = num3;
					}
					else
					{
						num3 = 1646717512;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1427500222);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2361390069u));
					num = 955719187;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_enabled(IntPtr L)
	{
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		ParticleEmitter val = default(ParticleEmitter);
		while (true)
		{
			int num = 1458003369;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3E30B369)) % 9)
				{
				case 0u:
					break;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(489604900u));
					num = 1875778682;
					continue;
				case 2u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 529199934) ^ 0x30FEE529);
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (!_206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E((Object)(object)val, (Object)null))
					{
						num5 = -98062826;
						num6 = num5;
					}
					else
					{
						num5 = -11610072;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1378256681);
					continue;
				}
				case 4u:
					_202A_206E_200B_200D_202E_202D_202B_206B_206B_200F_206F_200D_206E_202E_200C_202E_202E_200C_202D_206F_206D_206F_202D_200B_200F_206E_202D_202A_202C_202B_200C_200E_206E_202A_202B_202A_202E_206B_206B_200E_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					num = 771191566;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1148149357u));
					num = ((int)num2 * -2082213921) ^ -865765720;
					continue;
				case 8u:
					val = (ParticleEmitter)luaObject;
					num = (int)(num2 * 1261114262) ^ -179576675;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 36144317;
						num4 = num3;
					}
					else
					{
						num3 = 1132251108;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1857886193);
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
	private static int ClearParticles(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 1);
		ParticleEmitter val = (ParticleEmitter)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3982255166u));
		while (true)
		{
			int num = 2019880170;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x62DB2B7F)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_0040;
				default:
					return 0;
				}
				break;
				IL_0040:
				_202E_202D_206A_200B_200E_206B_200F_206A_200D_202E_202A_202C_202D_202C_200B_202C_200B_200E_206C_206E_200D_202D_202E_202E_202E_206F_202B_202A_206D_206C_202D_206B_202A_206F_200D_200D_206E_206E_206F_200D_202E(val);
				num = (int)(num2 * 491025849) ^ -1310719888;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Emit(IntPtr L)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected O, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		int num = LuaDLL.lua_gettop(L);
		if (num == 1)
		{
			goto IL_000e;
		}
		goto IL_01f5;
		IL_000e:
		int num2 = 123958686;
		goto IL_0013;
		IL_0013:
		float num9 = default(float);
		Color color2 = default(Color);
		ParticleEmitter val3 = default(ParticleEmitter);
		Vector3 vector4 = default(Vector3);
		float num10 = default(float);
		float num8 = default(float);
		ParticleEmitter val4 = default(ParticleEmitter);
		Vector3 vector3 = default(Vector3);
		float num7 = default(float);
		Color color = default(Color);
		float num5 = default(float);
		float num6 = default(float);
		ParticleEmitter val2 = default(ParticleEmitter);
		Vector3 vector = default(Vector3);
		Vector3 vector2 = default(Vector3);
		int num4 = default(int);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ 0x43F5BD46)) % 22)
			{
			case 8u:
				break;
			case 19u:
				goto IL_0081;
			case 0u:
				num9 = (float)LuaScriptMgr.GetNumber(L, 5);
				color2 = LuaScriptMgr.GetColor(L, 6);
				num2 = ((int)num3 * -1024735285) ^ -1193837449;
				continue;
			case 10u:
				val3 = (ParticleEmitter)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3982255166u));
				num2 = (int)((num3 * 177219313) ^ 0x39114F8A);
				continue;
			case 11u:
				vector4 = LuaScriptMgr.GetVector3(L, 3);
				num10 = (float)LuaScriptMgr.GetNumber(L, 4);
				num2 = ((int)num3 * -1365469005) ^ 0xE078638;
				continue;
			case 16u:
				return 0;
			case 13u:
				num8 = (float)LuaScriptMgr.GetNumber(L, 4);
				num2 = ((int)num3 * -1699748834) ^ -2147288528;
				continue;
			case 6u:
				_206F_200F_200B_200C_206E_206B_206D_206C_206C_202A_206C_206C_202A_200F_200D_206A_200D_200F_202A_202B_202D_200B_206A_200D_202C_202E_206A_206F_200D_206F_206D_202A_202A_206C_202C_200F_206C_206C_200E_206C_202E(val4, vector3, vector4, num10, num7, color, num5, num6);
				num2 = ((int)num3 * -1225562607) ^ 0x95B4F0;
				continue;
			case 7u:
				_206E_200F_200B_200D_206E_206D_200C_206D_202E_202C_200B_200E_206C_206C_202B_200C_200E_202E_200F_206B_206E_202B_202A_200C_206C_200C_200E_200F_206A_206A_206C_200F_202C_202E_200C_200E_206A_206D_202C_202A_202E(val2, vector, vector2, num8, num9, color2);
				return 0;
			case 5u:
				return 0;
			case 3u:
				num7 = (float)LuaScriptMgr.GetNumber(L, 5);
				num2 = (int)(num3 * 166831273) ^ -1871587387;
				continue;
			case 21u:
				val4 = (ParticleEmitter)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3928328207u));
				vector3 = LuaScriptMgr.GetVector3(L, 2);
				num2 = (int)(num3 * 846646821) ^ -747833540;
				continue;
			case 17u:
				goto IL_01f5;
			case 9u:
				_200C_202B_200D_206A_202D_202E_202D_202E_206F_200D_202D_206D_202C_200B_202E_200C_200C_200E_206C_200E_202C_202D_206E_200E_202D_202B_200C_202B_200E_200C_200F_200D_200C_200D_206A_200E_200C_200D_206B_206F_202E(val3, num4);
				num2 = (int)((num3 * 781068264) ^ 0x13ED73F5);
				continue;
			case 18u:
				val2 = (ParticleEmitter)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(582972718u));
				num2 = (int)(num3 * 40959046) ^ -38588520;
				continue;
			case 20u:
			{
				ParticleEmitter val = (ParticleEmitter)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(582972718u));
				_200F_202C_206F_202A_200F_206A_206C_202D_206F_200C_202D_202E_200E_200F_206F_200E_202E_206A_206C_202C_206A_200E_200D_200D_206F_206C_206B_202A_206D_200C_206F_202E_200D_206C_202B_202C_206F_200B_202C_200C_202E(val);
				return 0;
			}
			case 1u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3151879837u));
				num2 = 888865044;
				continue;
			case 12u:
				color = LuaScriptMgr.GetColor(L, 6);
				num5 = (float)LuaScriptMgr.GetNumber(L, 7);
				num6 = (float)LuaScriptMgr.GetNumber(L, 8);
				num2 = ((int)num3 * -956881384) ^ -417877106;
				continue;
			case 15u:
				goto IL_02ce;
			case 2u:
				num4 = (int)LuaScriptMgr.GetNumber(L, 2);
				num2 = (int)(num3 * 344782157) ^ -1536950457;
				continue;
			case 4u:
				vector = LuaScriptMgr.GetVector3(L, 2);
				vector2 = LuaScriptMgr.GetVector3(L, 3);
				num2 = ((int)num3 * -1959460916) ^ -2076619367;
				continue;
			default:
				return 0;
			}
			break;
			IL_02ce:
			int num11;
			if (num == 6)
			{
				num2 = 852417874;
				num11 = num2;
			}
			else
			{
				num2 = 367953409;
				num11 = num2;
			}
			continue;
			IL_0081:
			int num12;
			if (num == 8)
			{
				num2 = 897701725;
				num12 = num2;
			}
			else
			{
				num2 = 2059542499;
				num12 = num2;
			}
		}
		goto IL_000e;
		IL_01f5:
		int num13;
		if (num == 2)
		{
			num2 = 333138636;
			num13 = num2;
		}
		else
		{
			num2 = 1400955559;
			num13 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Simulate(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		ParticleEmitter val = default(ParticleEmitter);
		float num3 = default(float);
		while (true)
		{
			int num = -918579722;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -840784781)) % 5)
				{
				case 4u:
					break;
				case 2u:
					val = (ParticleEmitter)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(582972718u));
					num = (int)((num2 * 951771993) ^ 0x7EAFD13F);
					continue;
				case 3u:
					_206C_206C_206D_206F_200C_206F_202D_200C_202E_200B_202E_202B_200E_206A_202B_202A_200F_202A_206B_200F_202A_200C_206F_202B_206C_206B_202D_202E_202B_202E_206E_206A_206B_206C_202A_202B_200F_206B_206E_202C_202E(val, num3);
					num = (int)((num2 * 2003908071) ^ 0x199DAA36);
					continue;
				case 1u:
					num3 = (float)LuaScriptMgr.GetNumber(L, 2);
					num = (int)(num2 * 695462162) ^ -187093609;
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
		bool b = default(bool);
		while (true)
		{
			int num = 926954364;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7B1EF3F7)) % 4)
				{
				case 0u:
					break;
				case 3u:
				{
					object luaObject2 = LuaScriptMgr.GetLuaObject(L, 2);
					val2 = (Object)((luaObject2 is Object) ? luaObject2 : null);
					num = (int)(num2 * 217471847) ^ -1361415868;
					continue;
				}
				case 2u:
					b = _206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E(val, val2);
					num = (int)((num2 * 1142865791) ^ 0x469D7BE8);
					continue;
				default:
					LuaScriptMgr.Push(L, b);
					return 1;
				}
				break;
			}
		}
	}

	static Type _200F_206A_202D_202D_200E_200F_206E_202E_206D_200D_200E_200C_206C_202A_200E_200F_202D_206E_206F_200D_206B_200E_200D_206E_202E_206B_206A_200D_206B_202A_200C_206D_200B_202C_206C_202D_200D_200D_206F_202C_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static bool _206D_202D_206E_202D_202C_206E_200F_200C_200C_200C_206F_202A_200D_206A_206E_200F_206B_202D_200B_202B_200D_200E_202B_200D_200B_206E_202C_200C_206E_206B_206D_202A_200C_202A_200C_206B_200B_202B_202B_200F_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static bool _202B_206F_206B_200F_202C_202E_202E_202A_206A_200E_200E_202E_206F_202B_202C_206B_200B_202D_202C_200D_200C_202C_206F_200D_202C_206C_200B_202A_206C_206E_202C_206B_200D_200C_202A_200D_206F_200D_202C_202E(ParticleEmitter P_0)
	{
		return P_0.emit;
	}

	static float _200F_206B_206B_206F_206E_202C_202C_200D_200D_206D_206A_202A_200B_200E_206B_206F_206F_206F_206A_202D_206E_202C_200C_206F_206E_202B_202E_202A_202E_200D_200E_202D_202E_200E_202E_202E_206E_206A_206E_200F_202E(ParticleEmitter P_0)
	{
		return P_0.minSize;
	}

	static float _200B_202E_200F_200B_200E_202D_206F_200C_202B_200F_200D_206D_202E_200F_200E_200F_202B_202D_200C_200B_202D_200D_206E_200B_200E_206F_200B_200C_200E_200E_200D_200F_206D_200C_200D_206E_206F_202C_200B_202B_202E(ParticleEmitter P_0)
	{
		return P_0.maxSize;
	}

	static float _206A_202B_206C_206A_202C_202C_202B_202A_200F_206E_206D_206E_206B_202A_206B_202E_200C_206B_206C_200C_202A_202C_202D_200E_206F_206F_200C_200B_206D_200C_200D_206B_200E_202D_200B_200F_200B_200D_206C_202E_202E(ParticleEmitter P_0)
	{
		return P_0.minEnergy;
	}

	static float _202D_200F_206A_200B_206E_200E_200E_200D_202A_202B_202A_202C_202C_202E_200F_202C_202E_202B_200E_200B_202D_206B_200E_206F_200B_206D_206B_206A_206F_200F_206E_200D_206F_200B_202C_206B_200C_206B_200F_202A_202E(ParticleEmitter P_0)
	{
		return P_0.maxEnergy;
	}

	static float _202E_206F_206E_202A_200E_200D_200E_200F_200C_202A_202A_202D_206D_202D_206E_200E_200F_202B_206C_200F_200D_202D_206D_202C_202D_202E_202C_206A_202C_202B_206F_206B_200C_200E_206D_200C_202E_200D_202D_200F_202E(ParticleEmitter P_0)
	{
		return P_0.minEmission;
	}

	static float _206E_206B_202B_200E_206A_202C_200B_200E_202D_206B_202B_206B_202E_206C_206F_200C_206F_200F_202D_200C_202A_202E_202B_206B_200C_200C_202B_202B_202B_200F_202E_202E_202A_202B_206F_202A_200D_206B_202E_202B_202E(ParticleEmitter P_0)
	{
		return P_0.maxEmission;
	}

	static float _200D_206D_200D_206E_200C_206A_200E_206F_200D_202A_206E_200E_200D_200B_200E_206E_206F_206E_206A_206F_206C_206C_200C_206C_206B_206F_200D_206B_206C_202B_202B_202C_202C_202A_206D_206A_200E_202B_200E_206E_202E(ParticleEmitter P_0)
	{
		return P_0.emitterVelocityScale;
	}

	static Vector3 _202A_206C_206F_206E_200B_202D_206A_200B_202E_206F_202E_206F_200E_200B_206E_206B_202D_206A_206E_202D_200C_206E_202E_202B_206E_206F_206B_200F_206F_202D_200F_206F_206B_202E_200C_206F_200E_200C_206D_202A_202E(ParticleEmitter P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.worldVelocity;
	}

	static Vector3 _202B_206C_206D_206C_202C_206C_202C_202A_202C_200C_202C_206A_206D_202B_202E_206D_202D_202B_206C_206F_202D_202A_202A_200B_202B_206D_200C_200C_206D_202B_202B_200F_206D_200B_200F_200E_206C_206E_200F_206E_202E(ParticleEmitter P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.localVelocity;
	}

	static Vector3 _200C_206D_202C_202B_202D_206B_202E_200E_202B_206A_206B_200C_200C_202E_202D_200E_200F_202E_202C_200E_200E_202B_206D_200D_200E_206A_202D_206B_200F_206B_200D_200E_206B_202D_206B_206A_202C_200F_202D_202A_202E(ParticleEmitter P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.rndVelocity;
	}

	static bool _200B_200D_200D_202E_202D_206B_200D_200B_206F_206D_202E_202B_202A_202C_202A_202A_200C_200E_202E_200B_202C_200C_206B_206F_202B_202D_206C_200C_202A_200B_206B_206C_200F_206C_200E_206F_206B_200E_200D_206B_202E(ParticleEmitter P_0)
	{
		return P_0.useWorldSpace;
	}

	static bool _206C_200E_206D_202D_200D_200B_206B_206E_206F_202D_202D_202E_200B_200E_202D_206C_206F_206B_206A_206E_202C_200F_200C_200D_206B_202D_206F_206D_202C_206E_202D_200C_206C_206C_206B_206F_206C_202E_206A_206F_202E(ParticleEmitter P_0)
	{
		return P_0.rndRotation;
	}

	static float _202D_202A_206E_200F_206E_202C_206D_200B_202A_202D_206D_202D_206D_206C_206E_206B_206C_206A_202B_202C_206E_202D_202B_202C_200B_206B_206B_200C_206B_206A_200B_202E_206E_206C_206C_202A_202E_202D_200F_200F_202E(ParticleEmitter P_0)
	{
		return P_0.angularVelocity;
	}

	static float _202B_200B_202A_206A_200C_202B_206C_200F_200F_200F_206B_202E_202D_206F_202C_202A_206E_206E_200E_206E_200D_200F_206E_200D_206E_200E_202B_202D_200D_202C_200E_206A_206B_202B_202E_202E_206D_206D_206E_202E(ParticleEmitter P_0)
	{
		return P_0.rndAngularVelocity;
	}

	static Particle[] _200F_202D_202D_202C_202B_206F_206F_200F_200E_200B_200B_202A_200E_202C_206E_202B_200D_206C_202B_200C_202A_200E_202E_206F_206D_202D_202C_202B_200D_202C_202E_200F_202A_200C_206C_206C_206D_202B_200F_202E(ParticleEmitter P_0)
	{
		return P_0.particles;
	}

	static int _202E_202E_206D_206B_202D_206A_200B_202C_202D_206B_202C_206F_206A_200C_202E_200E_202A_206D_202D_202B_202B_200E_200F_206B_206D_206B_202B_206C_206C_200C_200B_206F_206C_200D_206F_206C_202D_202E_200E_202E_202E(ParticleEmitter P_0)
	{
		return P_0.particleCount;
	}

	static bool _202D_200F_200F_200F_202D_206D_200F_200C_200F_206C_206F_206C_202C_206C_202C_206F_200C_206F_206F_200B_206E_206A_202D_206E_200F_206A_206A_202B_206B_202D_206A_202D_202C_200B_206F_200E_202C_206E_200E_200F_202E(ParticleEmitter P_0)
	{
		return P_0.enabled;
	}

	static void _202B_206F_200E_200C_200C_206E_206A_206D_202A_200D_202E_202D_200C_206D_200D_200E_206B_206F_206B_206E_200E_200C_200D_206B_202A_200F_206F_202C_200C_206D_202C_206E_200D_206D_200E_202A_200C_206C_202A_202B_202E(ParticleEmitter P_0, bool P_1)
	{
		P_0.emit = P_1;
	}

	static void _206F_202C_202E_200B_206B_202A_200B_202D_202E_206D_202C_202D_202E_200E_206D_206B_202C_206B_200B_200B_202A_202E_202C_206C_202A_202B_202C_202B_206D_200D_202A_206A_202A_202D_202B_206A_200F_200F_206E_202D_202E(ParticleEmitter P_0, float P_1)
	{
		P_0.minSize = P_1;
	}

	static void _200F_202B_206E_206A_206C_200E_200B_202B_206A_200C_206B_200C_206E_200C_206A_200F_206B_202B_200D_206D_206A_202A_200D_202B_206E_200C_206F_200E_200C_200E_206A_200C_206C_202E_200B_202C_206A_202A_206F_202E_202E(ParticleEmitter P_0, float P_1)
	{
		P_0.maxSize = P_1;
	}

	static void _206C_206D_206C_206A_200D_202C_200F_202E_202E_206E_200E_206A_202A_200F_202E_206C_200D_202B_202A_206C_202A_206F_206D_200C_202C_202C_206C_206B_206B_200B_206D_200E_202A_206F_202C_206C_206A_200E_200C_202A_202E(ParticleEmitter P_0, float P_1)
	{
		P_0.minEnergy = P_1;
	}

	static void _206A_206F_200D_202D_200E_202C_202C_206A_200F_202D_202E_202C_206E_202E_200D_200F_206A_206B_202A_202C_202B_200F_200E_202E_202D_202C_202C_200E_200C_206D_200C_206B_200D_206C_206D_202C_202A_206C_200B_200D_202E(ParticleEmitter P_0, float P_1)
	{
		P_0.maxEnergy = P_1;
	}

	static void _202A_200E_206A_202B_200C_206A_206F_200D_200B_206B_206D_200F_202B_200B_206B_206E_202D_200D_206C_202A_206F_200C_202D_202D_206B_200E_202A_200D_206F_206C_200B_202D_202D_200E_200F_206F_206F_202C_200E_206D_202E(ParticleEmitter P_0, float P_1)
	{
		P_0.minEmission = P_1;
	}

	static void _206F_200D_202E_200B_200B_202C_200B_206B_200C_200B_202E_200B_206C_206A_206D_206A_206D_200B_202A_200D_202E_202E_206F_206D_206F_202E_200B_200E_200D_206E_202A_202D_200F_200C_200D_202A_202B_200C_202A_202E(ParticleEmitter P_0, float P_1)
	{
		P_0.maxEmission = P_1;
	}

	static void _206F_200F_200E_206B_200C_202D_206B_202A_206F_206A_206C_202B_206A_202D_206B_206A_206C_202A_206E_206D_202C_206E_206E_206C_206B_202D_200D_200E_200B_200E_202B_206E_200C_200D_200C_206A_206F_206E_206F_202B_202E(ParticleEmitter P_0, float P_1)
	{
		P_0.emitterVelocityScale = P_1;
	}

	static void _200D_202B_202B_206C_202D_206A_202B_202B_202E_200E_206A_206E_202B_200C_206A_200E_202D_200F_202B_200B_206E_202C_200D_206E_202C_206C_200E_202D_200D_206A_200D_206C_200B_206D_206C_202A_206B_206B_202D_200E_202E(ParticleEmitter P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.worldVelocity = P_1;
	}

	static void _202B_206D_206F_202C_206E_206E_200F_200F_202B_206E_206C_206D_202B_200C_200F_200E_206A_206E_200E_202A_206F_200E_202C_200D_200F_202A_202E_202C_202E_206A_202E_202E_202A_200C_206A_200D_202A_200C_206D_202C_202E(ParticleEmitter P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.localVelocity = P_1;
	}

	static void _206D_200D_200B_200B_206F_206F_200B_200C_206C_206D_202C_202E_206C_200D_200C_200F_200B_200D_200C_206B_200F_206B_206D_202E_206F_206D_202E_202C_206B_200D_202B_206C_202B_202A_202C_206A_206C_206C_202E_200C_202E(ParticleEmitter P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.rndVelocity = P_1;
	}

	static void _202D_206E_202E_202C_202B_200F_200B_206B_206E_206E_200D_202D_200C_202A_206A_202C_202E_202B_206F_206C_202A_202A_200E_202E_206C_202C_206B_202D_202D_202A_200F_200D_206A_200C_200E_200E_200D_200D_200B_206D_202E(ParticleEmitter P_0, bool P_1)
	{
		P_0.useWorldSpace = P_1;
	}

	static void _206C_206F_206C_206B_206E_200F_202D_202A_202D_200F_202B_206C_200C_206E_206E_200D_206D_200B_200E_200C_200D_206A_202B_206E_206B_202C_202C_206F_202E_202E_200B_200E_200C_206A_202A_202B_200F_206E_200B_202D_202E(ParticleEmitter P_0, bool P_1)
	{
		P_0.rndRotation = P_1;
	}

	static void _202C_206B_206A_202D_206C_202C_200D_202C_200C_200E_202B_200D_202B_202B_202A_206A_202B_206F_202D_200B_200C_206A_200F_206F_200B_206E_200F_202A_200C_206B_206D_200E_202A_200D_200F_202A_206E_202B_200D_206A_202E(ParticleEmitter P_0, float P_1)
	{
		P_0.angularVelocity = P_1;
	}

	static void _206B_200D_202B_206D_202E_202C_200B_200D_202A_202E_206D_200E_206D_200F_200D_206F_206F_206C_206C_206A_200B_200E_200E_206B_202E_206C_202A_206E_202B_202B_200C_202E_200F_206D_206B_200B_200E_200D_200E_200F_202E(ParticleEmitter P_0, float P_1)
	{
		P_0.rndAngularVelocity = P_1;
	}

	static void _206F_200E_202D_202C_200F_200F_200C_200C_206C_206C_202C_200F_206F_202D_206A_202B_206A_202C_206E_206D_200E_202C_206A_202E_206C_206C_206D_206D_206F_206A_200B_202D_202B_202A_202C_206B_200D_206A_206D_202E_202E(ParticleEmitter P_0, Particle[] P_1)
	{
		P_0.particles = P_1;
	}

	static void _202A_206E_200B_200D_202E_202D_202B_206B_206B_200F_206F_200D_206E_202E_200C_202E_202E_200C_202D_206F_206D_206F_202D_200B_200F_206E_202D_202A_202C_202B_200C_200E_206E_202A_202B_202A_202E_206B_206B_200E_202E(ParticleEmitter P_0, bool P_1)
	{
		P_0.enabled = P_1;
	}

	static void _202E_202D_206A_200B_200E_206B_200F_206A_200D_202E_202A_202C_202D_202C_200B_202C_200B_200E_206C_206E_200D_202D_202E_202E_202E_206F_202B_202A_206D_206C_202D_206B_202A_206F_200D_200D_206E_206E_206F_200D_202E(ParticleEmitter P_0)
	{
		P_0.ClearParticles();
	}

	static void _200F_202C_206F_202A_200F_206A_206C_202D_206F_200C_202D_202E_200E_200F_206F_200E_202E_206A_206C_202C_206A_200E_200D_200D_206F_206C_206B_202A_206D_200C_206F_202E_200D_206C_202B_202C_206F_200B_202C_200C_202E(ParticleEmitter P_0)
	{
		P_0.Emit();
	}

	static void _200C_202B_200D_206A_202D_202E_202D_202E_206F_200D_202D_206D_202C_200B_202E_200C_200C_200E_206C_200E_202C_202D_206E_200E_202D_202B_200C_202B_200E_200C_200F_200D_200C_200D_206A_200E_200C_200D_206B_206F_202E(ParticleEmitter P_0, int P_1)
	{
		P_0.Emit(P_1);
	}

	static void _206E_200F_200B_200D_206E_206D_200C_206D_202E_202C_200B_200E_206C_206C_202B_200C_200E_202E_200F_206B_206E_202B_202A_200C_206C_200C_200E_200F_206A_206A_206C_200F_202C_202E_200C_200E_206A_206D_202C_202A_202E(ParticleEmitter P_0, Vector3 P_1, Vector3 P_2, float P_3, float P_4, Color P_5)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		P_0.Emit(P_1, P_2, P_3, P_4, P_5);
	}

	static void _206F_200F_200B_200C_206E_206B_206D_206C_206C_202A_206C_206C_202A_200F_200D_206A_200D_200F_202A_202B_202D_200B_206A_200D_202C_202E_206A_206F_200D_206F_206D_202A_202A_206C_202C_200F_206C_206C_200E_206C_202E(ParticleEmitter P_0, Vector3 P_1, Vector3 P_2, float P_3, float P_4, Color P_5, float P_6, float P_7)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		P_0.Emit(P_1, P_2, P_3, P_4, P_5, P_6, P_7);
	}

	static void _206C_206C_206D_206F_200C_206F_202D_200C_202E_200B_202E_202B_200E_206A_202B_202A_200F_202A_206B_200F_202A_200C_206F_202B_206C_206B_202D_202E_202B_202E_206E_206A_206B_206C_202A_202B_200F_206B_206E_202C_202E(ParticleEmitter P_0, float P_1)
	{
		P_0.Simulate(P_1);
	}
}
