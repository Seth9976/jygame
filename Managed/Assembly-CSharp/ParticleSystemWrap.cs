using System;
using LuaInterface;
using UnityEngine;

public class ParticleSystemWrap
{
	private static Type classType = _206A_200D_202B_200E_202B_206E_202D_200E_202C_206D_202D_206F_200E_206B_200B_206F_200C_202E_206B_200F_206E_200C_202B_200F_200E_200C_202D_206F_200D_206A_202B_200B_202C_202D_202D_206B_200E_202A_202A_206A_202E(typeof(ParticleSystem).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[12]
		{
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(266632849u), SetParticles),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1632369475u), GetParticles),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1321378039u), Simulate),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1704070248u), Play),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1687545056u), Stop),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3624903641u), Pause),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3688662255u), Clear),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3024559326u), IsAlive),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(754943192u), Emit),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2705981273u), _200E_206C_206B_206D_206F_200D_206E_206E_206D_202A_202A_206B_206B_200D_206D_200B_200C_200E_202B_200E_206E_202C_200B_206A_206E_200B_206F_202C_200D_202D_206E_206F_202D_202B_206E_206D_202B_200D_206F_200E_202E),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2783592835u), GetClassType),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(396454614u), Lua_Eq)
		};
		LuaField[] fields = new LuaField[21]
		{
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1435558722u), get_startDelay, set_startDelay),
			new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3256807608u), get_isPlaying, null),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2789384511u), get_isStopped, null),
			new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1614385517u), get_isPaused, null),
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2702579097u), get_loop, set_loop),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3950992688u), get_playOnAwake, set_playOnAwake),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2345399604u), get_time, set_time),
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1238747969u), get_duration, null),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(882485057u), get_playbackSpeed, set_playbackSpeed),
			new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3447769434u), get_particleCount, null),
			new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3567840260u), get_enableEmission, set_enableEmission),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1609298699u), get_emissionRate, set_emissionRate),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3439433187u), get_startSpeed, set_startSpeed),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1926002119u), get_startSize, set_startSize),
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1570640254u), get_startColor, set_startColor),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3242210427u), get_startRotation, set_startRotation),
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(463128047u), get_startLifetime, set_startLifetime),
			new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(139765839u), get_gravityModifier, set_gravityModifier),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3327139138u), get_maxParticles, set_maxParticles),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(617890352u), get_simulationSpace, set_simulationSpace),
			new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2276884338u), get_randomSeed, set_randomSeed)
		};
		while (true)
		{
			int num = 144477329;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3910F061)) % 3)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_060d;
				case 0u:
					return;
				}
				break;
				IL_060d:
				LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(731096831u), _206A_200D_202B_200E_202B_206E_202D_200E_202C_206D_202D_206F_200E_206B_200B_206F_200C_202E_206B_200F_206E_200C_202B_200F_200E_200C_202D_206F_200D_206A_202B_200B_202C_202D_202D_206B_200E_202A_202A_206A_202E(typeof(ParticleSystem).TypeHandle), regs, fields, _206A_200D_202B_200E_202B_206E_202D_200E_202C_206D_202D_206F_200E_206B_200B_206F_200C_202E_206B_200F_206E_200C_202B_200F_200E_200C_202D_206F_200D_206A_202B_200B_202C_202D_202D_206B_200E_202A_202A_206A_202E(typeof(Component).TypeHandle));
				num = ((int)num2 * -1531939855) ^ 0x7C298AE7;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _200E_206C_206B_206D_206F_200D_206E_206E_206D_202A_202A_206B_206B_200D_206D_200B_200C_200E_202B_200E_206E_202C_200B_206A_206E_200B_206F_202C_200D_202D_206E_206F_202D_202B_206E_206D_202B_200D_206F_200E_202E(IntPtr P_0)
	{
		if (LuaDLL.lua_gettop(P_0) == 0)
		{
			ParticleSystem obj = default(ParticleSystem);
			while (true)
			{
				int num = -33690214;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1423017196)) % 4)
					{
					case 0u:
						break;
					case 2u:
						obj = _200E_202D_206A_200B_200B_206F_202B_206D_206E_200E_200E_206E_200D_200E_200D_206B_200F_202B_206D_202B_200E_206D_202A_202E_202E_206C_202A_202B_206D_202E_202B_200B_202B_202C_200B_202D_202C_202E_206D_206D_202E();
						num = ((int)num2 * -391834949) ^ -344966513;
						continue;
					case 1u:
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
		LuaDLL.luaL_error(P_0, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3270559705u));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_startDelay(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystem val = default(ParticleSystem);
		while (true)
		{
			int num = -1090697243;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -324835926)) % 7)
				{
				case 4u:
					break;
				case 2u:
				{
					val = (ParticleSystem)luaObject;
					int num5;
					int num6;
					if (_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = -1370921479;
						num6 = num5;
					}
					else
					{
						num5 = -917196289;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -2138884790);
					continue;
				}
				case 5u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -1303410907;
						num4 = num3;
					}
					else
					{
						num3 = -1394719329;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1365476941);
					continue;
				}
				case 6u:
					LuaScriptMgr.Push(L, _206F_200F_200D_206D_206E_206E_206D_206F_200E_200C_202E_202E_206B_206D_202A_200C_200F_200E_206F_200B_200E_200F_206C_206D_202D_200F_200F_206B_206C_206B_206B_202E_200F_200C_202E_202C_206E_206A_202E_200C_202E(val));
					num = -472002969;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4237624341u));
					num = -1813384151;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3749394770u));
					num = (int)(num2 * 424328439) ^ -499648817;
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
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystem val = (ParticleSystem)luaObject;
		while (true)
		{
			int num = -1478988608;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -778183147)) % 8)
				{
				case 4u:
					break;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2911794717u));
					num = (int)(num2 * 1588361247) ^ -1891365520;
					continue;
				case 3u:
					LuaScriptMgr.Push(L, _206D_202A_200B_206A_202D_200F_206A_200E_202A_206A_202B_202A_200B_200F_202E_206E_200D_200F_202A_202C_200E_200C_200E_206A_202C_200C_202B_200C_206F_206D_206D_200B_202E_202C_202C_200D_206A_200B_206D_206A_202E(val));
					num = -1538811371;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (!_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = 205239672;
						num6 = num5;
					}
					else
					{
						num5 = 667662385;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1445517202);
					continue;
				}
				case 7u:
					num = ((int)num2 * -260508811) ^ -368684267;
					continue;
				case 2u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 980710594;
						num4 = num3;
					}
					else
					{
						num3 = 1260725405;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1930497385);
					continue;
				}
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1198891583u));
					num = -1879266562;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_isStopped(IntPtr L)
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		ParticleSystem val = default(ParticleSystem);
		while (true)
		{
			int num = -1020763659;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1229629094)) % 9)
				{
				case 7u:
					break;
				case 1u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 597429556;
						num6 = num5;
					}
					else
					{
						num5 = 1800258897;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 812254633);
					continue;
				}
				case 3u:
				{
					int num3;
					int num4;
					if (!_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = -1338705839;
						num4 = num3;
					}
					else
					{
						num3 = -204197676;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -706720320);
					continue;
				}
				case 8u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 340565804) ^ 0x650559F5);
					continue;
				case 4u:
					val = (ParticleSystem)luaObject;
					num = (int)(num2 * 1228115456) ^ -1566300750;
					continue;
				case 2u:
					LuaScriptMgr.Push(L, _206C_206F_200C_202C_200D_206B_200B_200C_206A_202D_206B_206A_200E_206F_206C_200B_206D_206F_202E_206B_202B_200C_200F_206A_202B_200C_202A_206A_200D_206C_206F_202D_202E_200F_206C_200D_202C_200B_206D_206B_202E(val));
					num = -26059819;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2173679248u));
					num = (int)(num2 * 212454513) ^ -921825296;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3171986229u));
					num = -19263919;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_isPaused(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystem val = (ParticleSystem)luaObject;
		if (_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
		{
			while (true)
			{
				int num = -636402646;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -919711380)) % 6)
					{
					case 5u:
						break;
					case 3u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4130697824u));
						num = -1345568250;
						continue;
					case 1u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(46260361u));
						num = (int)((num2 * 1841510319) ^ 0x2AB3B69);
						continue;
					case 2u:
					{
						LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
						int num3;
						int num4;
						if (luaTypes == LuaTypes.LUA_TTABLE)
						{
							num3 = -1689348931;
							num4 = num3;
						}
						else
						{
							num3 = -1798574903;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 47574668);
						continue;
					}
					case 4u:
						num = ((int)num2 * -1544028108) ^ 0x25A8B7AE;
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
		LuaScriptMgr.Push(L, _206A_202E_200F_206A_200C_206C_202C_200B_206F_202B_206E_202A_206E_206A_206D_202E_206C_206E_206D_206A_206E_200B_200E_200B_206E_202A_202B_202A_206F_200B_206D_200C_202D_206B_202E_202A_202D_202B_206B_206A_202E(val));
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_loop(IntPtr L)
	{
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystem val = default(ParticleSystem);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -738668799;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1970717649)) % 10)
				{
				case 0u:
					break;
				case 2u:
					LuaScriptMgr.Push(L, _200D_200D_206B_206F_200C_206D_200B_200D_200B_202A_202A_202D_200E_200C_200C_200D_202E_200D_206C_206D_202B_202B_200B_206E_206C_206F_202D_202A_206D_202E_206B_206E_202B_206B_202A_200E_206D_202C_200E_202A_202E(val));
					num = -379248513;
					continue;
				case 3u:
					num = (int)(num2 * 1839003587) ^ -2122717270;
					continue;
				case 5u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 720152148) ^ -948476749;
					continue;
				case 9u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(157352958u));
					num = -1735364755;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 1478600566;
						num6 = num5;
					}
					else
					{
						num5 = 1623994306;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -966695070);
					continue;
				}
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3862073398u));
					num = (int)(num2 * 94471613) ^ -770343765;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = -667836848;
						num4 = num3;
					}
					else
					{
						num3 = -946946993;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 760324323);
					continue;
				}
				case 6u:
					val = (ParticleSystem)luaObject;
					num = ((int)num2 * -1041825016) ^ -836550656;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_playOnAwake(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystem val = (ParticleSystem)luaObject;
		if (_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
		{
			LuaTypes luaTypes = default(LuaTypes);
			while (true)
			{
				int num = 1927544522;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x2A8F8B2B)) % 7)
					{
					case 6u:
						break;
					case 2u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2850205691u));
						num = ((int)num2 * -912837867) ^ 0x73E7699;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (luaTypes != LuaTypes.LUA_TTABLE)
						{
							num3 = -985910741;
							num4 = num3;
						}
						else
						{
							num3 = -881575043;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 1380988273);
						continue;
					}
					case 4u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2791168269u));
						num = 1540408199;
						continue;
					case 5u:
						num = (int)((num2 * 1565464672) ^ 0x99B8147);
						continue;
					case 3u:
						luaTypes = LuaDLL.lua_type(L, 1);
						num = ((int)num2 * -158913504) ^ 0x21F553D;
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
		LuaScriptMgr.Push(L, _206B_200C_200D_202D_206F_206A_200B_202D_202C_206B_202A_200B_200E_200F_206A_200B_200D_202B_200C_200C_206C_206E_200D_202D_202B_200F_206A_202E_200E_202D_206F_200E_206C_206F_202E_206B_202C_200C_206E_202B_202E(val));
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_time(IntPtr L)
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		ParticleSystem val = default(ParticleSystem);
		while (true)
		{
			int num = -810670281;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1465278765)) % 9)
				{
				case 2u:
					break;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(169335705u));
					num = -2136880714;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2187549366u));
					num = ((int)num2 * -1608066884) ^ -1417755850;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -1720062960;
						num6 = num5;
					}
					else
					{
						num5 = -2085090408;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -187438035);
					continue;
				}
				case 4u:
					val = (ParticleSystem)luaObject;
					num = (int)(num2 * 1282354250) ^ -1074447367;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = -860217139;
						num4 = num3;
					}
					else
					{
						num3 = -1149669544;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1412242985);
					continue;
				}
				case 7u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -930590454) ^ 0xE744CB9;
					continue;
				case 3u:
					num = (int)(num2 * 122569390) ^ -522744376;
					continue;
				default:
					LuaScriptMgr.Push(L, _202A_202D_202E_206F_202D_200D_206D_200F_206F_206C_200B_206D_206D_200B_206A_200B_202A_200C_202B_202B_202B_206B_206A_200D_206D_206B_202B_206C_206C_206B_206C_202D_206F_200E_202A_206D_202A_206D_202C_202D_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_duration(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystem val = (ParticleSystem)luaObject;
		if (_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
		{
			goto IL_001b;
		}
		goto IL_00d6;
		IL_001b:
		int num = -1011180353;
		goto IL_0020;
		IL_0020:
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1649001164)) % 8)
			{
			case 2u:
				break;
			case 0u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4168433317u));
				num = -680816038;
				continue;
			case 5u:
			{
				int num3;
				int num4;
				if (luaTypes == LuaTypes.LUA_TTABLE)
				{
					num3 = 1023604960;
					num4 = num3;
				}
				else
				{
					num3 = 1911700079;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -1288023305);
				continue;
			}
			case 7u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(656715387u));
				num = ((int)num2 * -1071257054) ^ 0x4E24DAA3;
				continue;
			case 1u:
				num = ((int)num2 * -734133728) ^ 0x708A997A;
				continue;
			case 3u:
				luaTypes = LuaDLL.lua_type(L, 1);
				num = ((int)num2 * -91586980) ^ 0x4BA80C6D;
				continue;
			case 6u:
				goto IL_00d6;
			default:
				return 1;
			}
			break;
		}
		goto IL_001b;
		IL_00d6:
		LuaScriptMgr.Push(L, _206D_206D_200B_200B_202C_206B_206E_202D_202C_206C_206F_200F_200F_206E_206B_200C_200D_202C_202D_206C_206B_206E_206C_202D_200D_200B_200D_200E_202E_206D_202E_206C_206A_200F_206A_202B_200C_206F_206A_202B_202E(val));
		num = -24586672;
		goto IL_0020;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_playbackSpeed(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystem val = (ParticleSystem)luaObject;
		if (_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
		{
			while (true)
			{
				int num = 268021084;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x22550363)) % 6)
					{
					case 4u:
						break;
					case 5u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(137614472u));
						num = 1976481581;
						continue;
					case 0u:
						num = (int)(num2 * 1901014281) ^ -609257027;
						continue;
					case 3u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1092043347u));
						num = (int)(num2 * 1923237732) ^ -2122990033;
						continue;
					case 1u:
					{
						LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
						int num3;
						int num4;
						if (luaTypes != LuaTypes.LUA_TTABLE)
						{
							num3 = 680963537;
							num4 = num3;
						}
						else
						{
							num3 = 689138247;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -1934085067);
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
		LuaScriptMgr.Push(L, _202C_206F_202A_200E_206F_206E_206F_202D_206C_202D_202C_206F_200C_200D_202A_200E_202B_206A_202B_200C_202A_202E_202D_202C_206E_206D_202B_200F_200F_202A_200F_202C_202B_206F_202C_202A_200F_206A_200B_202D_202E(val));
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_particleCount(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystem val = default(ParticleSystem);
		while (true)
		{
			int num = 155710309;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0xA888475)) % 7)
				{
				case 5u:
					break;
				case 6u:
				{
					val = (ParticleSystem)luaObject;
					int num5;
					int num6;
					if (_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = -345145203;
						num6 = num5;
					}
					else
					{
						num5 = -1699552462;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1073351960);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3264970949u));
					num = 2136204722;
					continue;
				case 0u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 740426585;
						num4 = num3;
					}
					else
					{
						num3 = 639532004;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 808370767);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3006430975u));
					num = (int)(num2 * 1687028522) ^ -1357431557;
					continue;
				case 2u:
					num = (int)(num2 * 2127425233) ^ -83173900;
					continue;
				default:
					LuaScriptMgr.Push(L, _206C_202B_202B_206C_200D_206D_206A_206C_202E_202C_206E_202C_202C_206D_202E_200B_202E_200D_200F_206A_200B_202A_200D_202D_206A_206D_202E_202A_200E_200E_200E_200C_200D_206A_206D_200D_202A_202A_206C_206E_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_enableEmission(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystem val = (ParticleSystem)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1658675241;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1508831683)) % 9)
				{
				case 4u:
					break;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(341669362u));
					num = ((int)num2 * -864994872) ^ 0x1FD235B1;
					continue;
				case 8u:
					LuaScriptMgr.Push(L, _200C_202D_200E_202A_206F_206E_202A_202E_200C_200E_200E_206B_202E_202E_206B_200D_200F_206E_200F_200C_206D_206A_206E_202A_200C_206A_206F_206C_202C_200C_202B_200D_206A_200E_206F_200C_200F_200B_202C_202B_202E(val));
					num = -800153273;
					continue;
				case 7u:
					num = (int)((num2 * 897656506) ^ 0x6A525909);
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (!_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = 1793636431;
						num6 = num5;
					}
					else
					{
						num5 = 459900891;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 169217235);
					continue;
				}
				case 5u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 578397406) ^ -1169748546;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3559965588u));
					num = -1902345327;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 507214302;
						num4 = num3;
					}
					else
					{
						num3 = 976480006;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 158250527);
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
	private static int get_emissionRate(IntPtr L)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystem val = default(ParticleSystem);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1980661066;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1978444952)) % 9)
				{
				case 5u:
					break;
				case 6u:
				{
					val = (ParticleSystem)luaObject;
					int num5;
					int num6;
					if (_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = 794624842;
						num6 = num5;
					}
					else
					{
						num5 = 1585232708;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1852739170);
					continue;
				}
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(703646867u));
					num = -2132950600;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -1795191232;
						num4 = num3;
					}
					else
					{
						num3 = -459136770;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 157410083);
					continue;
				}
				case 3u:
					LuaScriptMgr.Push(L, _200F_202D_200B_206B_200D_206D_202E_206F_200E_206D_206C_206E_206F_200F_200E_202A_202C_202D_206D_200F_202B_200F_202E_200B_202D_202D_202B_206A_206B_206B_200F_202C_200E_206F_202C_206A_202A_202E_202A_206E_202E(val));
					num = -1761667589;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3118976651u));
					num = ((int)num2 * -11381312) ^ -1900978316;
					continue;
				case 8u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1156221724) ^ -734920331;
					continue;
				case 0u:
					num = (int)(num2 * 681081075) ^ -667833620;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_startSpeed(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystem val = (ParticleSystem)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 909640127;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0xA23BFF3)) % 7)
				{
				case 3u:
					break;
				case 5u:
				{
					int num5;
					int num6;
					if (!_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = -564402274;
						num6 = num5;
					}
					else
					{
						num5 = -372844074;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1663832226);
					continue;
				}
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2446472438u));
					num = ((int)num2 * -2129621575) ^ -1676517152;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(691170193u));
					num = 14207878;
					continue;
				case 6u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 2001627571) ^ -1556706621;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -587278397;
						num4 = num3;
					}
					else
					{
						num3 = -244226538;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1357362614);
					continue;
				}
				default:
					LuaScriptMgr.Push(L, _206A_202B_200E_202E_206E_202E_202B_206E_206D_200F_200C_202B_202D_200F_206C_206A_202A_200D_206C_206E_206A_202E_206F_206B_206D_206F_200D_206A_206B_202A_202A_200F_206F_200C_206C_202E_202B_202C_200E_206D_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_startSize(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystem val = default(ParticleSystem);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1536842541;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1691234910)) % 8)
				{
				case 2u:
					break;
				case 1u:
				{
					val = (ParticleSystem)luaObject;
					int num5;
					int num6;
					if (!_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = 737278824;
						num6 = num5;
					}
					else
					{
						num5 = 2022130001;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -830071961);
					continue;
				}
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1585877115u));
					num = ((int)num2 * -1453479776) ^ -710867350;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 1635072763;
						num4 = num3;
					}
					else
					{
						num3 = 1720249082;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -852844403);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2508071625u));
					num = -1429558241;
					continue;
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 172688341) ^ -1867454915;
					continue;
				case 0u:
					num = (int)((num2 * 370680492) ^ 0x3A42D0FF);
					continue;
				default:
					LuaScriptMgr.Push(L, _202B_202B_200D_206F_202D_200C_206F_206D_206A_202E_202C_202E_202A_200E_202B_200F_200C_206F_202A_202A_206C_200F_200D_202B_200B_202E_202A_206A_202A_200E_200E_200D_200F_206C_200E_202D_200F_206A_200E_206E_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_startColor(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystem val = (ParticleSystem)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1277841755;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1848456713)) % 9)
				{
				case 2u:
					break;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1139308348u));
					num = -2127357288;
					continue;
				case 3u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1014705939) ^ -1068633998;
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -2057130510;
						num6 = num5;
					}
					else
					{
						num5 = -416148709;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1209737619);
					continue;
				}
				case 5u:
					num = ((int)num2 * -944476444) ^ -1784974144;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = 97706704;
						num4 = num3;
					}
					else
					{
						num3 = 1031149538;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1524813436);
					continue;
				}
				case 8u:
					LuaScriptMgr.Push(L, _206E_206B_200C_206C_202D_206D_200D_202C_206C_202D_200E_206C_206C_206D_202A_200F_202D_200E_200B_206F_200B_206D_202C_200D_206D_206C_206D_200B_200C_202A_202B_202C_202A_206C_206A_202E_206D_200D_202E_202B_202E(val));
					num = -1211516587;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2659013597u));
					num = (int)(num2 * 1971780672) ^ -862054671;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_startRotation(IntPtr L)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystem val = default(ParticleSystem);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1758970066;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1969462705)) % 9)
				{
				case 2u:
					break;
				case 6u:
					num = ((int)num2 * -959985928) ^ 0x519F0AFC;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (!_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = -1460335368;
						num6 = num5;
					}
					else
					{
						num5 = -808562062;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1487074876);
					continue;
				}
				case 3u:
					val = (ParticleSystem)luaObject;
					num = ((int)num2 * -1182606968) ^ -414928716;
					continue;
				case 7u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 117410107) ^ -950331732;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1871046353u));
					num = -754513908;
					continue;
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3980846860u));
					num = (int)((num2 * 2056838036) ^ 0x3AA31CE1);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 672206024;
						num4 = num3;
					}
					else
					{
						num3 = 2113524195;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -369577467);
					continue;
				}
				default:
					LuaScriptMgr.Push(L, _206B_206E_206F_202E_200B_206B_200E_202A_206D_200F_206E_206F_206B_202D_202E_202E_202D_200C_206B_206F_206F_206A_200D_202A_202B_200D_200D_206D_202D_206C_202E_202E_206E_200D_202A_200E_206F_200B_200D_206B_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_startLifetime(IntPtr L)
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystem val = default(ParticleSystem);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1415214873;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x969E043)) % 9)
				{
				case 2u:
					break;
				case 0u:
					LuaScriptMgr.Push(L, _202A_200C_206F_200C_200F_206C_206D_202B_206A_200D_202A_200F_206D_200E_206E_200B_206B_206C_202C_206C_202A_202E_206F_202A_202A_202C_206D_206E_202D_202B_206C_202B_200F_206F_206F_200F_202B_206D_202D_200F_202E(val));
					num = 412076468;
					continue;
				case 6u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 49376622) ^ 0x3054FBEC);
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 1039699801;
						num6 = num5;
					}
					else
					{
						num5 = 145731092;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1989650020);
					continue;
				}
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4050984051u));
					num = 2025000154;
					continue;
				case 3u:
					num = (int)(num2 * 1746945982) ^ -2005096450;
					continue;
				case 1u:
				{
					val = (ParticleSystem)luaObject;
					int num3;
					int num4;
					if (!_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = 2117512254;
						num4 = num3;
					}
					else
					{
						num3 = 1123893851;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1355726970);
					continue;
				}
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2029604752u));
					num = (int)((num2 * 1913991468) ^ 0x7B18C65);
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_gravityModifier(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystem val = (ParticleSystem)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1141382079;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1075598603)) % 8)
				{
				case 2u:
					break;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(565938132u));
					num = -1987257350;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3924359971u));
					num = (int)(num2 * 1342754319) ^ -1460146678;
					continue;
				case 0u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 1193114280) ^ -641673938;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 2021457495;
						num6 = num5;
					}
					else
					{
						num5 = 1941689416;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1856269372);
					continue;
				}
				case 5u:
					num = (int)(num2 * 1287799678) ^ -351585876;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = 383329754;
						num4 = num3;
					}
					else
					{
						num3 = 2104708853;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1506127528);
					continue;
				}
				default:
					LuaScriptMgr.Push(L, _202A_202B_200C_206E_206D_202B_202E_202C_206D_202D_200F_202D_206D_202E_202E_202D_206F_202C_206D_206C_202E_206E_202B_206C_202D_200E_200F_202A_202B_200F_200B_200C_202D_200B_202C_206B_206D_202B_200D_206D_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_maxParticles(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystem val = default(ParticleSystem);
		while (true)
		{
			int num = 172552464;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7E60E4F3)) % 8)
				{
				case 0u:
					break;
				case 3u:
					val = (ParticleSystem)luaObject;
					num = (int)((num2 * 1944135997) ^ 0x3B783C11);
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3315006327u));
					num = ((int)num2 * -481673257) ^ 0x4973899D;
					continue;
				case 2u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -468385355;
						num6 = num5;
					}
					else
					{
						num5 = -1156265886;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1079769000);
					continue;
				}
				case 5u:
				{
					int num3;
					int num4;
					if (_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = 319038492;
						num4 = num3;
					}
					else
					{
						num3 = 471850225;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 2042270625);
					continue;
				}
				case 4u:
					num = (int)((num2 * 1258696753) ^ 0x1C92B1F0);
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4144284253u));
					num = 1182470116;
					continue;
				default:
					LuaScriptMgr.Push(L, _206C_200D_202A_200B_202D_206E_202B_206B_202E_202D_200F_206A_200D_200C_206E_200E_202C_200B_202B_206B_200B_202A_206D_206B_202C_206A_206C_206E_202A_206B_200C_206C_200E_200E_202C_200F_202A_206C_200C_200E_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_simulationSpace(IntPtr L)
	{
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystem val = default(ParticleSystem);
		while (true)
		{
			int num = 590273818;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6EAEAD24)) % 8)
				{
				case 4u:
					break;
				case 6u:
				{
					val = (ParticleSystem)luaObject;
					int num5;
					int num6;
					if (_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = 1754115985;
						num6 = num5;
					}
					else
					{
						num5 = 733327114;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -276028746);
					continue;
				}
				case 5u:
					num = (int)((num2 * 466071210) ^ 0x2B6CDFCC);
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2094147203u));
					num = 1200989982;
					continue;
				case 1u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 1990673626;
						num4 = num3;
					}
					else
					{
						num3 = 791846485;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1222103762);
					continue;
				}
				case 2u:
					LuaScriptMgr.Push(L, (Enum)(object)_206A_200D_200F_206C_206F_206E_200D_206C_206E_200B_206A_206A_202E_202C_206C_206E_202A_202E_202B_200C_202C_202D_206F_202E_202C_200F_202A_206C_206F_202C_206F_206F_206C_202D_202C_200B_206A_206A_202B_202A_202E(val));
					num = 1090398711;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(433396545u));
					num = (int)(num2 * 1795520959) ^ -926549487;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_randomSeed(IntPtr L)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystem val = default(ParticleSystem);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1923711813;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1563688205)) % 10)
				{
				case 9u:
					break;
				case 4u:
					val = (ParticleSystem)luaObject;
					num = ((int)num2 * -69584325) ^ -540503713;
					continue;
				case 8u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 1981323929) ^ 0x4F74AAA6);
					continue;
				case 1u:
					LuaScriptMgr.Push(L, _202A_200D_202B_200E_202A_202D_206A_200B_202B_206E_206B_200B_206C_200D_206D_206B_206B_202E_202A_200E_200D_202A_202E_200F_200F_200D_200D_200D_206B_200D_206B_206D_206A_200C_202C_206D_202E_200F_202D_206B_202E(val));
					num = -1470847653;
					continue;
				case 7u:
					num = ((int)num2 * -194218703) ^ -1721124637;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1990942113u));
					num = -1655952526;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 167257061;
						num6 = num5;
					}
					else
					{
						num5 = 200570882;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1329036126);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(530588841u));
					num = ((int)num2 * -1927973663) ^ 0x5F456922;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = 1694317857;
						num4 = num3;
					}
					else
					{
						num3 = 2018110982;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1379899567);
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
	private static int set_startDelay(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystem val = default(ParticleSystem);
		while (true)
		{
			int num = 1358626290;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7B4B2523)) % 8)
				{
				case 7u:
					break;
				case 1u:
					val = (ParticleSystem)luaObject;
					num = (int)((num2 * 1313589026) ^ 0x717C26C5);
					continue;
				case 0u:
					num = (int)((num2 * 875339404) ^ 0x146893C8);
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3198747773u));
					num = (int)((num2 * 331936953) ^ 0x1D553AD1);
					continue;
				case 5u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -1358708486;
						num6 = num5;
					}
					else
					{
						num5 = -337879226;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -247995865);
					continue;
				}
				case 4u:
				{
					int num3;
					int num4;
					if (!_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = 2040825824;
						num4 = num3;
					}
					else
					{
						num3 = 122120014;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1652962226);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4032581552u));
					num = 1561456872;
					continue;
				default:
					_200E_202D_206F_206B_206C_202C_206E_206B_206F_206B_206F_202C_206E_206A_200C_206F_202C_200F_200D_206A_206A_202D_200C_206B_206B_202E_200D_206D_202B_200E_202A_202E_200D_202D_202B_202E_200E_206C_200C_206C_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_loop(IntPtr L)
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		ParticleSystem val = default(ParticleSystem);
		while (true)
		{
			int num = -1685799706;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2054297419)) % 8)
				{
				case 7u:
					break;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(157352958u));
					num = -232661595;
					continue;
				case 2u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 2107437436) ^ -1196182412;
					continue;
				case 3u:
				{
					val = (ParticleSystem)luaObject;
					int num5;
					int num6;
					if (!_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = 122781336;
						num6 = num5;
					}
					else
					{
						num5 = 1641524698;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1835517905);
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -424152858;
						num4 = num3;
					}
					else
					{
						num3 = -791511425;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 140391902);
					continue;
				}
				case 6u:
					num = ((int)num2 * -485953042) ^ 0x67307CD1;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3862073398u));
					num = (int)(num2 * 439204953) ^ -862291545;
					continue;
				default:
					_200D_206D_200D_202D_202E_202A_206B_200E_200B_202D_206D_206E_206F_202B_206D_202A_200D_202A_200E_206C_200E_202E_202B_206F_200F_202C_206E_206E_200B_200D_200B_206C_202C_202C_200C_206F_206B_206C_206E_206D_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_playOnAwake(IntPtr L)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystem val = default(ParticleSystem);
		while (true)
		{
			int num = 1016753900;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x16F73419)) % 6)
				{
				case 4u:
					break;
				case 3u:
				{
					val = (ParticleSystem)luaObject;
					int num5;
					int num6;
					if (_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = -1288027915;
						num6 = num5;
					}
					else
					{
						num5 = -1878141474;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -981855587);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1697148637u));
					num = ((int)num2 * -342804284) ^ 0x7F193F33;
					continue;
				case 1u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -1313556758;
						num4 = num3;
					}
					else
					{
						num3 = -1252165603;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -672164216);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1466933738u));
					num = 120969119;
					continue;
				default:
					_200F_200D_202D_200C_200E_206D_206D_202E_202D_202E_206F_200C_206F_200D_200D_200D_202A_200E_202E_200D_200B_202C_206E_200B_202D_200D_200C_206D_206E_202A_200D_206D_206E_202E_200B_206B_202B_202B_200B_206D_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_time(IntPtr L)
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		ParticleSystem val = default(ParticleSystem);
		while (true)
		{
			int num = -1230439695;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1267673680)) % 9)
				{
				case 8u:
					break;
				case 6u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 90600965;
						num6 = num5;
					}
					else
					{
						num5 = 1336514315;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1727958345);
					continue;
				}
				case 5u:
					_200E_200D_202B_202E_206A_202A_200F_200B_206B_202A_202E_200C_200C_206B_202B_200D_202C_200B_206D_206E_206A_200E_200D_206E_200D_202E_200D_206E_206F_206C_202E_206C_206D_200B_206B_202B_206C_202D_200F_200E_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					num = -1208362109;
					continue;
				case 1u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 662595136) ^ -869733644;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3289949871u));
					num = -1586415376;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2187549366u));
					num = (int)(num2 * 1357955611) ^ -1891520989;
					continue;
				case 3u:
					val = (ParticleSystem)luaObject;
					num = ((int)num2 * -286571705) ^ -1115771252;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = 201814568;
						num4 = num3;
					}
					else
					{
						num3 = 1131736942;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -2125245688);
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
	private static int set_playbackSpeed(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystem val = default(ParticleSystem);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1941708356;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1CBA7039)) % 7)
				{
				case 6u:
					break;
				case 2u:
				{
					val = (ParticleSystem)luaObject;
					int num5;
					int num6;
					if (!_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = -1191182755;
						num6 = num5;
					}
					else
					{
						num5 = -1464579908;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -781920950);
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -166473172;
						num4 = num3;
					}
					else
					{
						num3 = -982393443;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1716370807);
					continue;
				}
				case 3u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1099253406) ^ 0x6B6998FE;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2523180079u));
					num = 526520191;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(213085458u));
					num = ((int)num2 * -1181371908) ^ 0x29795F0F;
					continue;
				default:
					_202B_200C_206F_202E_202B_202C_206C_206C_206A_202C_202B_200C_206C_202E_202C_200B_200F_200E_206D_200C_202D_206E_200D_206C_206A_206B_200D_202B_202A_200F_202A_206B_200B_200E_200B_206E_202A_206F_200F_202A_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_enableEmission(IntPtr L)
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystem val = default(ParticleSystem);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1876283658;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1678557441)) % 9)
				{
				case 5u:
					break;
				case 0u:
					_206D_202D_206E_206A_200C_202C_202D_200B_206B_206F_206F_202D_206F_206C_200C_200B_206E_206C_202E_202E_200B_202E_200E_200B_206C_206D_200F_206D_202C_206B_206C_200F_202B_200F_200F_202B_206E_206D_206E_202C_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					num = -275950152;
					continue;
				case 7u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1340220411) ^ -657740957;
					continue;
				case 1u:
				{
					val = (ParticleSystem)luaObject;
					int num5;
					int num6;
					if (_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = 617172826;
						num6 = num5;
					}
					else
					{
						num5 = 1237492081;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 591066045);
					continue;
				}
				case 6u:
					num = (int)((num2 * 1369034294) ^ 0x67B484DC);
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3211317277u));
					num = -280903468;
					continue;
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1963949927u));
					num = (int)(num2 * 1477863071) ^ -312597209;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 2041913215;
						num4 = num3;
					}
					else
					{
						num3 = 942278900;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 408054573);
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
	private static int set_emissionRate(IntPtr L)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		ParticleSystem val = default(ParticleSystem);
		while (true)
		{
			int num = 1715792917;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x245B9F67)) % 8)
				{
				case 0u:
					break;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1899214930u));
					num = 239084600;
					continue;
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 1136330839) ^ -1000723202;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -1418474363;
						num6 = num5;
					}
					else
					{
						num5 = -893137865;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1700293303);
					continue;
				}
				case 6u:
				{
					int num3;
					int num4;
					if (_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = 1051651627;
						num4 = num3;
					}
					else
					{
						num3 = 1111472728;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1385510224);
					continue;
				}
				case 2u:
					val = (ParticleSystem)luaObject;
					num = (int)((num2 * 204919017) ^ 0x19D913EB);
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(563340309u));
					num = ((int)num2 * -1502456796) ^ -681823628;
					continue;
				default:
					_206E_206D_206E_202B_206B_200D_202A_200F_206E_202D_206E_206F_200B_206D_206E_206D_206C_206F_206A_206C_200C_206F_200E_200D_202C_200C_202B_200D_206A_200B_206A_206A_200F_206C_200D_206A_206E_206B_206F_202B_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_startSpeed(IntPtr L)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystem val = default(ParticleSystem);
		while (true)
		{
			int num = -890789114;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -166572712)) % 6)
				{
				case 0u:
					break;
				case 4u:
				{
					val = (ParticleSystem)luaObject;
					int num5;
					int num6;
					if (!_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = -692644001;
						num6 = num5;
					}
					else
					{
						num5 = -367131605;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -525626869);
					continue;
				}
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(691170193u));
					num = -1879323307;
					continue;
				case 5u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -953664998;
						num4 = num3;
					}
					else
					{
						num3 = -2114196663;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1670287935);
					continue;
				}
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(854588839u));
					num = (int)((num2 * 121375578) ^ 0x607E6E97);
					continue;
				default:
					_202B_206D_200B_200E_200E_202B_206B_206A_200E_206E_202A_200C_200C_202A_202C_200F_202B_206B_202B_200B_206A_202B_202A_202B_202D_206B_200E_202B_202A_206F_202B_200D_202B_206D_206D_206E_206A_206F_202E_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_startSize(IntPtr L)
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		ParticleSystem val = default(ParticleSystem);
		while (true)
		{
			int num = 1836150758;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1E583DF5)) % 8)
				{
				case 0u:
					break;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2508071625u));
					num = 1077071876;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1585877115u));
					num = (int)(num2 * 1590841375) ^ -888731426;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 944172175;
						num6 = num5;
					}
					else
					{
						num5 = 138737547;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -107045044);
					continue;
				}
				case 7u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1814005017) ^ 0x72599D69;
					continue;
				case 1u:
					_206E_200D_206C_200B_202C_202B_206C_200C_200D_202B_202E_202A_202B_200E_206F_200C_206C_200D_206F_200C_202A_206D_200C_202D_200D_206E_206B_206A_202D_202B_206C_200C_206F_202D_206E_206C_206C_202B_200C_206F_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					num = 2064324153;
					continue;
				case 3u:
				{
					val = (ParticleSystem)luaObject;
					int num3;
					int num4;
					if (!_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = 1706910935;
						num4 = num3;
					}
					else
					{
						num3 = 72866353;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1236112831);
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
	private static int set_startColor(IntPtr L)
	{
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystem val = default(ParticleSystem);
		while (true)
		{
			int num = 1940808814;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x13CE2755)) % 8)
				{
				case 7u:
					break;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3909466419u));
					num = 756628589;
					continue;
				case 1u:
					num = ((int)num2 * -1253567380) ^ -1533805951;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1028954040u));
					num = (int)(num2 * 1439103281) ^ -199068042;
					continue;
				case 3u:
					val = (ParticleSystem)luaObject;
					num = ((int)num2 * -1561128468) ^ 0x467E329D;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (!_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = 505260653;
						num6 = num5;
					}
					else
					{
						num5 = 499587515;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -240045952);
					continue;
				}
				case 6u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 389785396;
						num4 = num3;
					}
					else
					{
						num3 = 1017584995;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 2060565926);
					continue;
				}
				default:
					_206F_200F_206E_200B_202A_206F_202A_206F_202D_206D_206C_206D_206D_200E_206A_206C_206E_202B_202A_200F_202E_206F_202E_206E_206F_200B_202A_202E_200C_200C_200D_206D_202E_202E_202B_200C_200E_200B_202E_206A_202E(val, LuaScriptMgr.GetColor(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_startRotation(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystem val = (ParticleSystem)luaObject;
		if (_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
		{
			while (true)
			{
				int num = -513835749;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1369179262)) % 6)
					{
					case 5u:
						break;
					case 1u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(645764148u));
						num = -2077042796;
						continue;
					case 2u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2923162048u));
						num = ((int)num2 * -1685553528) ^ -611167344;
						continue;
					case 4u:
						num = ((int)num2 * -1131894062) ^ -1754740816;
						continue;
					case 3u:
					{
						LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
						int num3;
						int num4;
						if (luaTypes != LuaTypes.LUA_TTABLE)
						{
							num3 = -948839107;
							num4 = num3;
						}
						else
						{
							num3 = -984081554;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 1077829014);
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
		_200E_206B_206B_202D_200B_206B_200E_200E_206A_200B_206F_202D_206D_202B_206F_202E_206C_202D_200E_206C_206B_202D_206A_206C_200E_206E_202E_202A_202E_206D_206A_202A_200E_202B_206E_206D_200B_202D_206F_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_startLifetime(IntPtr L)
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystem val = default(ParticleSystem);
		while (true)
		{
			int num = 598530929;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x44EADC4A)) % 7)
				{
				case 2u:
					break;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(147900001u));
					num = ((int)num2 * -2007470691) ^ 0x57ACD85C;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = -1087552584;
						num6 = num5;
					}
					else
					{
						num5 = -2125408746;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 2087418094);
					continue;
				}
				case 4u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -1585558454;
						num4 = num3;
					}
					else
					{
						num3 = -1454785510;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 171498241);
					continue;
				}
				case 1u:
					val = (ParticleSystem)luaObject;
					num = ((int)num2 * -841367519) ^ 0x61778EC7;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2288144726u));
					num = 588872290;
					continue;
				default:
					_202D_200D_206E_202E_206E_206B_202A_202C_200D_206B_202D_200B_202A_200C_200E_200D_206B_206F_200D_206D_200C_202A_200C_200F_200F_202D_202C_202C_200F_206C_206F_202C_206F_206A_200B_200F_200F_206B_206C_206F_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_gravityModifier(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystem val = (ParticleSystem)luaObject;
		if (_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
		{
			goto IL_0018;
		}
		goto IL_004d;
		IL_0018:
		int num = -1052156315;
		goto IL_001d;
		IL_001d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1800269957)) % 7)
			{
			case 0u:
				break;
			case 1u:
				goto IL_004d;
			case 5u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4182899945u));
				num = -2010812359;
				continue;
			case 3u:
			{
				LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
				int num3;
				int num4;
				if (luaTypes != LuaTypes.LUA_TTABLE)
				{
					num3 = 570986540;
					num4 = num3;
				}
				else
				{
					num3 = 1438113078;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -753764029);
				continue;
			}
			case 2u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(638461410u));
				num = (int)(num2 * 253801555) ^ -1726272511;
				continue;
			case 6u:
				num = (int)((num2 * 853116194) ^ 0x3CD3FFC7);
				continue;
			default:
				return 0;
			}
			break;
		}
		goto IL_0018;
		IL_004d:
		_200E_200B_202B_202A_206C_206E_202A_200E_206A_202B_200F_206F_200B_200B_202C_202A_206C_202B_206D_206D_200F_200F_200E_202E_202C_206A_200F_206B_206A_200F_206C_202B_200F_202D_202C_202A_206B_200B_202D_200D_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
		num = -1536544252;
		goto IL_001d;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_maxParticles(IntPtr L)
	{
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		ParticleSystem val = default(ParticleSystem);
		while (true)
		{
			int num = -398272313;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1440146141)) % 9)
				{
				case 6u:
					break;
				case 5u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1202762843) ^ 0x74AA8CB;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = -1531052266;
						num6 = num5;
					}
					else
					{
						num5 = -567159286;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1426524798);
					continue;
				}
				case 7u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -1325404069;
						num4 = num3;
					}
					else
					{
						num3 = -785752520;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1948735860);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2158166659u));
					num = ((int)num2 * -2038105488) ^ 0x3EC41CF0;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4113886386u));
					num = -549814816;
					continue;
				case 1u:
					_202D_200E_206E_206E_206F_202C_202C_200B_202C_202D_202E_202D_200E_200B_202B_202C_200F_200B_206A_200E_202A_202E_206C_206B_206D_200D_200B_206E_206B_206C_206B_206A_202C_202A_206D_206E_200C_206E_206F_206D_202E(val, (int)LuaScriptMgr.GetNumber(L, 3));
					num = -1948932753;
					continue;
				case 4u:
					val = (ParticleSystem)luaObject;
					num = ((int)num2 * -1990309455) ^ -180901966;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_simulationSpace(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystem val = (ParticleSystem)luaObject;
		while (true)
		{
			int num = 1945545202;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6B0237DE)) % 7)
				{
				case 4u:
					break;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(433396545u));
					num = ((int)num2 * -875964449) ^ 0x158667DA;
					continue;
				case 1u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -2080905284;
						num6 = num5;
					}
					else
					{
						num5 = -135693479;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -323664749);
					continue;
				}
				case 5u:
				{
					int num3;
					int num4;
					if (!_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = -1856263807;
						num4 = num3;
					}
					else
					{
						num3 = -426402418;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -377077566);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1821170909u));
					num = 1990816985;
					continue;
				case 0u:
					num = ((int)num2 * -848291746) ^ -382554353;
					continue;
				default:
					_202C_200C_200D_200D_202E_200E_206E_206D_202B_206F_202C_200C_206B_202A_202C_206B_202C_206A_206F_202D_202B_200D_202D_206E_206B_206D_202E_206D_202B_206D_202A_206F_206A_202E_202D_202C_206F_206F_202E_202A_202E(val, (ParticleSystemSimulationSpace)(int)LuaScriptMgr.GetNetObject(L, 3, _206A_200D_202B_200E_202B_206E_202D_200E_202C_206D_202D_206F_200E_206B_200B_206F_200C_202E_206B_200F_206E_200C_202B_200F_200E_200C_202D_206F_200D_206A_202B_200B_202C_202D_202D_206B_200E_202A_202A_206A_202E(typeof(ParticleSystemSimulationSpace).TypeHandle)));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_randomSeed(IntPtr L)
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		ParticleSystem val = default(ParticleSystem);
		while (true)
		{
			int num = -937312107;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -137726982)) % 7)
				{
				case 0u:
					break;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4178938723u));
					num = ((int)num2 * -640356369) ^ -2015684492;
					continue;
				case 6u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -766596383;
						num6 = num5;
					}
					else
					{
						num5 = -514496287;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 291316382);
					continue;
				}
				case 3u:
				{
					int num3;
					int num4;
					if (_202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = -1871366791;
						num4 = num3;
					}
					else
					{
						num3 = -283469445;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1043601106);
					continue;
				}
				case 2u:
					val = (ParticleSystem)luaObject;
					num = ((int)num2 * -1755871312) ^ 0xCB685A;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2669299126u));
					num = -926459493;
					continue;
				default:
					_206E_202C_200D_206E_202D_202E_200F_202D_206F_202D_200B_200F_206D_200F_206C_202E_206F_206D_206E_206D_202B_202A_202E_200C_202A_202A_206A_200F_202C_200C_200F_206B_202C_202B_206C_202D_202C_202D_200E_200F_202E(val, (uint)LuaScriptMgr.GetNumber(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SetParticles(IntPtr L)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 3);
		ParticleSystem val = default(ParticleSystem);
		Particle[] arrayObject = default(Particle[]);
		int num3 = default(int);
		while (true)
		{
			int num = -1385218687;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1993464299)) % 5)
				{
				case 4u:
					break;
				case 2u:
					_202B_202B_200B_202D_206D_202B_206C_202B_202E_200C_200B_206D_200B_202B_206B_206F_206C_206C_206A_202C_206A_202A_206F_206B_202B_200C_202C_202D_206A_202C_202D_206B_206A_200F_206E_206C_202C_206A_202A_200E_202E(val, arrayObject, num3);
					num = ((int)num2 * -1154764924) ^ -750284508;
					continue;
				case 0u:
					arrayObject = LuaScriptMgr.GetArrayObject<Particle>(L, 2);
					num3 = (int)LuaScriptMgr.GetNumber(L, 3);
					num = ((int)num2 * -1011323246) ^ -349536642;
					continue;
				case 1u:
					val = (ParticleSystem)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3182547642u));
					num = (int)(num2 * 881028148) ^ -312485531;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetParticles(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		ParticleSystem val = (ParticleSystem)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3182547642u));
		Particle[] arrayObject = LuaScriptMgr.GetArrayObject<Particle>(L, 2);
		while (true)
		{
			int num = -860155398;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2023611891)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0048;
				default:
					return 1;
				}
				break;
				IL_0048:
				int d = _200E_200C_202E_200B_202D_202D_206E_200D_206E_200C_202E_200D_206E_206B_200B_200D_200B_200F_206B_206F_206A_200E_206C_200B_200E_200B_206D_200C_206C_206C_200B_202B_200F_202E_200B_206E_202E_202E_206A_202C_202E(val, arrayObject);
				LuaScriptMgr.Push(L, d);
				num = ((int)num2 * -1426320790) ^ 0x2C6BE9DF;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Simulate(IntPtr L)
	{
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		ParticleSystem val3 = default(ParticleSystem);
		ParticleSystem val2 = default(ParticleSystem);
		float num5 = default(float);
		bool boolean = default(bool);
		bool boolean3 = default(bool);
		ParticleSystem val = default(ParticleSystem);
		float num4 = default(float);
		while (true)
		{
			int num2 = -1535040272;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1984744461)) % 16)
				{
				case 12u:
					break;
				case 3u:
				{
					int num7;
					int num8;
					if (num == 2)
					{
						num7 = 84198467;
						num8 = num7;
					}
					else
					{
						num7 = 1951648114;
						num8 = num7;
					}
					num2 = num7 ^ ((int)num3 * -2056218827);
					continue;
				}
				case 7u:
				{
					float num10 = (float)LuaScriptMgr.GetNumber(L, 2);
					_200D_206E_202D_202D_206A_206B_202B_200D_202D_200F_202A_202A_200D_200C_200B_200E_200C_200F_206F_200B_200C_202C_200D_206D_206D_206A_200D_200F_206F_202E_206E_206E_206B_206A_202B_200C_206D_202B_202D_202A_202E(val3, num10);
					return 0;
				}
				case 11u:
					_202A_206E_206D_200D_206D_200B_202E_202A_202A_200D_202C_202D_202D_202D_206A_206E_200D_206D_200F_206F_206E_200B_200B_206C_206B_206C_206F_206A_206C_206D_206E_206A_200B_206A_200E_202E_202C_206A_206A_206F_202E(val2, num5, boolean);
					return 0;
				case 1u:
				{
					int num9;
					if (num == 4)
					{
						num2 = -560361478;
						num9 = num2;
					}
					else
					{
						num2 = -1850792253;
						num9 = num2;
					}
					continue;
				}
				case 15u:
					val3 = (ParticleSystem)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4045906864u));
					num2 = ((int)num3 * -283325220) ^ -2072548032;
					continue;
				case 5u:
					boolean3 = LuaScriptMgr.GetBoolean(L, 3);
					num2 = ((int)num3 * -1858779580) ^ 0x527D1825;
					continue;
				case 14u:
				{
					int num6;
					if (num != 3)
					{
						num2 = -1187104686;
						num6 = num2;
					}
					else
					{
						num2 = -1021050722;
						num6 = num2;
					}
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1451477821u));
					num2 = -1966544921;
					continue;
				case 13u:
					val2 = (ParticleSystem)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1045550987u));
					num5 = (float)LuaScriptMgr.GetNumber(L, 2);
					num2 = ((int)num3 * -317273160) ^ 0x370B8651;
					continue;
				case 9u:
					val = (ParticleSystem)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3182547642u));
					num2 = ((int)num3 * -2101732001) ^ -404672404;
					continue;
				case 2u:
				{
					bool boolean2 = LuaScriptMgr.GetBoolean(L, 4);
					_200C_200F_206F_206C_206F_206B_206B_202E_206A_202B_200C_206A_200D_202C_200D_200B_200F_206B_202B_200F_202C_200F_206D_200F_202C_200B_202A_206B_200C_202A_200E_200D_206C_200B_206B_206A_200D_202E_202A_206A_202E(val, num4, boolean3, boolean2);
					num2 = ((int)num3 * -1035971187) ^ 0x1AE6C4BF;
					continue;
				}
				case 10u:
					boolean = LuaScriptMgr.GetBoolean(L, 3);
					num2 = ((int)num3 * -1090895591) ^ 0x18612642;
					continue;
				case 6u:
					return 0;
				case 8u:
					num4 = (float)LuaScriptMgr.GetNumber(L, 2);
					num2 = ((int)num3 * -642789728) ^ 0x10C360E6;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Play(IntPtr L)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		ParticleSystem val = default(ParticleSystem);
		ParticleSystem val2 = default(ParticleSystem);
		bool boolean = default(bool);
		while (true)
		{
			int num2 = -911710582;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1858476264)) % 10)
				{
				case 5u:
					break;
				case 7u:
				{
					int num6;
					if (num != 2)
					{
						num2 = -708565944;
						num6 = num2;
					}
					else
					{
						num2 = -967961008;
						num6 = num2;
					}
					continue;
				}
				case 4u:
					val = (ParticleSystem)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1796248917u));
					num2 = ((int)num3 * -1621501253) ^ 0x5C79DAAE;
					continue;
				case 0u:
					val2 = (ParticleSystem)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1045550987u));
					num2 = (int)(num3 * 183266748) ^ -7361151;
					continue;
				case 9u:
					return 0;
				case 3u:
					_206A_206B_206C_200B_200C_200C_202A_206A_206F_200B_206D_200F_202A_200D_206D_202A_200C_202A_206D_206B_202A_200B_202C_200C_206B_206B_200E_206B_206E_206C_200F_206A_206B_206C_200C_206D_200B_202C_200D_200D_202E(val, boolean);
					return 0;
				case 1u:
					_200E_200F_200B_206B_206A_202E_202D_200B_202D_200B_206B_206C_200D_206F_206D_206F_202A_200D_200F_202D_200B_206B_200B_200F_206A_200E_200E_206D_202B_200C_202B_206B_200F_206F_206B_202D_202E_200E_206C_200D_202E(val2);
					num2 = (int)((num3 * 1847318768) ^ 0x7C3A5D5F);
					continue;
				case 2u:
					boolean = LuaScriptMgr.GetBoolean(L, 2);
					num2 = (int)((num3 * 1652550691) ^ 0x10940C2F);
					continue;
				case 8u:
				{
					int num4;
					int num5;
					if (num != 1)
					{
						num4 = -1012380373;
						num5 = num4;
					}
					else
					{
						num4 = -1926716782;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num3 * -1801620236);
					continue;
				}
				default:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2638341230u));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Stop(IntPtr L)
	{
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		if (num == 1)
		{
			goto IL_000e;
		}
		goto IL_00ef;
		IL_000e:
		int num2 = -1209089791;
		goto IL_0013;
		IL_0013:
		ParticleSystem val2 = default(ParticleSystem);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ -2039519115)) % 9)
			{
			case 8u:
				break;
			case 6u:
				return 0;
			case 2u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1418579509u));
				num2 = -1219291474;
				continue;
			case 1u:
				_200E_206C_202B_206F_202A_200C_202E_202B_202D_206C_206F_202A_206B_202C_202B_200E_200D_202D_202B_202E_206E_202A_202B_202C_202A_200E_206C_200C_200F_200F_200F_202A_202B_200E_206E_206B_206C_202D_202B_206B_202E(val2);
				num2 = ((int)num3 * -1969231980) ^ 0x5372F6C9;
				continue;
			case 7u:
				val2 = (ParticleSystem)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1045550987u));
				num2 = (int)(num3 * 1693942151) ^ -1922266749;
				continue;
			case 0u:
			{
				ParticleSystem val = (ParticleSystem)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4045906864u));
				bool boolean = LuaScriptMgr.GetBoolean(L, 2);
				_206D_200F_200E_200E_200B_206C_200F_202C_206C_202D_206F_202E_200B_206B_206B_202E_200C_200C_206D_206E_202A_202A_202B_206F_202D_202C_200D_202C_202D_206C_202A_200E_206B_202A_202A_202E_202C_206D_206F_202E(val, boolean);
				num2 = (int)(num3 * 1512496028) ^ -1072854403;
				continue;
			}
			case 3u:
				goto IL_00ef;
			case 5u:
				return 0;
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
			num2 = -1953283953;
			num4 = num2;
		}
		else
		{
			num2 = -1527899769;
			num4 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Pause(IntPtr L)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		if (num == 1)
		{
			goto IL_000e;
		}
		goto IL_00a9;
		IL_000e:
		int num2 = -270115774;
		goto IL_0013;
		IL_0013:
		ParticleSystem val = default(ParticleSystem);
		ParticleSystem val2 = default(ParticleSystem);
		bool boolean = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ -1511405769)) % 8)
			{
			case 7u:
				break;
			case 6u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2195593649u));
				num2 = -32947529;
				continue;
			case 1u:
				_206B_206B_202D_206E_200F_202C_206C_200F_206F_206B_206F_202C_202E_202E_202B_200B_200E_206E_202A_202C_200E_202E_202C_200E_206B_206E_202B_206C_200C_206E_206F_200E_206E_200E_206D_202E_200B_206A_202A_206C_202E(val);
				return 0;
			case 2u:
				val2 = (ParticleSystem)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1187329370u));
				boolean = LuaScriptMgr.GetBoolean(L, 2);
				num2 = ((int)num3 * -1592791114) ^ -211809409;
				continue;
			case 3u:
				goto IL_00a9;
			case 4u:
				_206F_206C_206D_202A_202C_206E_202E_206D_206C_200E_206A_202A_202A_206C_200B_200C_206C_202D_206D_206E_206D_202C_206D_206B_202A_206D_206F_200E_200F_206B_200E_202E_206A_202C_200C_200F_206A_206A_206D_206B_202E(val2, boolean);
				return 0;
			case 5u:
				val = (ParticleSystem)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1796248917u));
				num2 = (int)((num3 * 1098153102) ^ 0x455ABC98);
				continue;
			default:
				return 0;
			}
			break;
		}
		goto IL_000e;
		IL_00a9:
		int num4;
		if (num == 2)
		{
			num2 = -1286608867;
			num4 = num2;
		}
		else
		{
			num2 = -1045619463;
			num4 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Clear(IntPtr L)
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		while (true)
		{
			int num2 = 779250282;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x59C01AD2)) % 9)
				{
				case 7u:
					break;
				case 8u:
				{
					int num5;
					int num6;
					if (num != 1)
					{
						num5 = 1878193941;
						num6 = num5;
					}
					else
					{
						num5 = 1512110361;
						num6 = num5;
					}
					num2 = num5 ^ ((int)num3 * -1619989979);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3052141558u));
					num2 = 1978243719;
					continue;
				case 4u:
					return 0;
				case 3u:
				{
					int num4;
					if (num != 2)
					{
						num2 = 616871381;
						num4 = num2;
					}
					else
					{
						num2 = 1504449314;
						num4 = num2;
					}
					continue;
				}
				case 0u:
				{
					ParticleSystem val2 = (ParticleSystem)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4045906864u));
					_200F_202E_206C_200C_206D_206D_202B_200E_206F_202C_206D_200C_202A_200B_206A_206B_206B_200C_202C_200E_206F_202B_202D_202B_206E_206F_206B_206A_202A_206B_202E_206C_206A_206E_202A_200B_200B_202B_206C_200F_202E(val2);
					num2 = (int)(num3 * 1925331379) ^ -1911567872;
					continue;
				}
				case 6u:
				{
					ParticleSystem val = (ParticleSystem)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1045550987u));
					bool boolean = LuaScriptMgr.GetBoolean(L, 2);
					_200B_202E_206B_206C_206A_202D_200C_206D_206A_202C_202B_200E_200D_202B_202B_206B_206A_200F_202B_202D_206A_200F_202E_200C_200B_202A_202A_200B_206D_202E_200F_200F_200C_206A_200B_206C_202D_202A_206A_202C_202E(val, boolean);
					num2 = (int)((num3 * 1576452427) ^ 0x3A680264);
					continue;
				}
				case 2u:
					return 0;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int IsAlive(IntPtr L)
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		bool boolean = default(bool);
		ParticleSystem val = default(ParticleSystem);
		bool b = default(bool);
		while (true)
		{
			int num2 = -1369504481;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -741275046)) % 12)
				{
				case 4u:
					break;
				case 9u:
				{
					int num5;
					int num6;
					if (num != 1)
					{
						num5 = -1376613176;
						num6 = num5;
					}
					else
					{
						num5 = -131143782;
						num6 = num5;
					}
					num2 = num5 ^ (int)(num3 * 482683336);
					continue;
				}
				case 3u:
					return 1;
				case 8u:
					boolean = LuaScriptMgr.GetBoolean(L, 2);
					num2 = (int)(num3 * 849990903) ^ -1845073308;
					continue;
				case 2u:
				{
					bool b2 = _202E_202C_202B_200B_206D_202B_206C_206C_206D_206B_206F_206A_206B_206E_206A_200D_200D_206F_200F_206E_200E_202B_200B_206C_206F_206B_200E_200F_200D_200F_200D_200C_206F_200D_206F_206C_202C_200F_206E_202E_202E(val, boolean);
					LuaScriptMgr.Push(L, b2);
					num2 = (int)((num3 * 945757747) ^ 0x53AE8F43);
					continue;
				}
				case 0u:
				{
					ParticleSystem val2 = (ParticleSystem)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1045550987u));
					b = _206E_206C_200C_202B_206B_206A_202B_200B_202D_200D_200C_200E_200F_200C_206A_202A_206F_200F_200D_202D_202E_202C_206E_202C_200F_202B_206A_202C_206C_200C_206A_206B_206A_206E_206B_206F_206D_206F_206A_206F_202E(val2);
					num2 = (int)((num3 * 1972693068) ^ 0x10CF606F);
					continue;
				}
				case 11u:
					val = (ParticleSystem)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1796248917u));
					num2 = (int)(num3 * 1331987768) ^ -648519562;
					continue;
				case 10u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(518376025u));
					num2 = -1762674845;
					continue;
				case 6u:
				{
					int num4;
					if (num != 2)
					{
						num2 = -1239594064;
						num4 = num2;
					}
					else
					{
						num2 = -2083360659;
						num4 = num2;
					}
					continue;
				}
				case 1u:
					LuaScriptMgr.Push(L, b);
					num2 = (int)(num3 * 286387860) ^ -1247460147;
					continue;
				case 7u:
					return 1;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Emit(IntPtr L)
	{
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		int num = LuaDLL.lua_gettop(L);
		ParticleSystem val2 = default(ParticleSystem);
		ParticleSystem val = default(ParticleSystem);
		int num12 = default(int);
		Vector3 vector = default(Vector3);
		Vector3 vector2 = default(Vector3);
		while (true)
		{
			int num2 = 1359856026;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x7B2FEF21)) % 17)
				{
				case 11u:
					break;
				case 10u:
					val2 = (ParticleSystem)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3182547642u));
					num2 = ((int)num3 * -1563960834) ^ -1008488777;
					continue;
				case 5u:
				{
					int num8;
					int num9;
					if (!LuaScriptMgr.CheckTypes(L, 1, _206A_200D_202B_200E_202B_206E_202D_200E_202C_206D_202D_206F_200E_206B_200B_206F_200C_202E_206B_200F_206E_200C_202B_200F_200E_200C_202D_206F_200D_206A_202B_200B_202C_202D_202D_206B_200E_202A_202A_206A_202E(typeof(ParticleSystem).TypeHandle), _206A_200D_202B_200E_202B_206E_202D_200E_202C_206D_202D_206F_200E_206B_200B_206F_200C_202E_206B_200F_206E_200C_202B_200F_200E_200C_202D_206F_200D_206A_202B_200B_202C_202D_202D_206B_200E_202A_202A_206A_202E(typeof(int).TypeHandle)))
					{
						num8 = 1054881611;
						num9 = num8;
					}
					else
					{
						num8 = 1549044997;
						num9 = num8;
					}
					num2 = num8 ^ ((int)num3 * -340525662);
					continue;
				}
				case 2u:
					return 0;
				case 14u:
					_200E_200E_200D_200C_200B_206E_206F_202C_200E_206E_202E_200B_200C_200D_200C_206C_206A_206C_206F_206D_200D_200F_202A_206F_200D_200D_200E_202A_200E_200E_200F_206A_200E_206E_200C_206E_206F_206B_200C_200C_202E(val, num12);
					num2 = (int)(num3 * 1135500309) ^ -2105733770;
					continue;
				case 16u:
					return 0;
				case 9u:
				{
					int num6;
					if (num != 6)
					{
						num2 = 215129496;
						num6 = num2;
					}
					else
					{
						num2 = 1471873800;
						num6 = num2;
					}
					continue;
				}
				case 13u:
					val = (ParticleSystem)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3182547642u));
					num2 = ((int)num3 * -1962329221) ^ -1558419166;
					continue;
				case 15u:
					vector = LuaScriptMgr.GetVector3(L, 3);
					num2 = (int)(num3 * 1608191832) ^ -1498298180;
					continue;
				case 12u:
					vector2 = LuaScriptMgr.GetVector3(L, 2);
					num2 = (int)(num3 * 1048887699) ^ -1523850446;
					continue;
				case 1u:
				{
					int num13;
					int num14;
					if (!LuaScriptMgr.CheckTypes(L, 1, _206A_200D_202B_200E_202B_206E_202D_200E_202C_206D_202D_206F_200E_206B_200B_206F_200C_202E_206B_200F_206E_200C_202B_200F_200E_200C_202D_206F_200D_206A_202B_200B_202C_202D_202D_206B_200E_202A_202A_206A_202E(typeof(ParticleSystem).TypeHandle), _206A_200D_202B_200E_202B_206E_202D_200E_202C_206D_202D_206F_200E_206B_200B_206F_200C_202E_206B_200F_206E_200C_202B_200F_200E_200C_202D_206F_200D_206A_202B_200B_202C_202D_202D_206B_200E_202A_202A_206A_202E(typeof(Particle).TypeHandle)))
					{
						num13 = -176687799;
						num14 = num13;
					}
					else
					{
						num13 = -2047543784;
						num14 = num13;
					}
					num2 = num13 ^ (int)(num3 * 1708807754);
					continue;
				}
				case 7u:
				{
					ParticleSystem val4 = (ParticleSystem)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1796248917u));
					Particle val5 = (Particle)LuaScriptMgr.GetLuaObject(L, 2);
					_206F_206C_206B_200F_206A_206D_200D_206D_200C_206A_200F_206B_202E_202E_206F_200F_206D_200E_200C_200F_200F_200F_200E_200B_206A_200E_200B_206B_202E_202E_206D_200B_206C_200C_202D_202C_206B_200C_200B_202B_202E(val4, val5);
					return 0;
				}
				case 6u:
					num12 = (int)LuaDLL.lua_tonumber(L, 2);
					num2 = (int)((num3 * 920945719) ^ 0xDE2610D);
					continue;
				case 4u:
				{
					float num10 = (float)LuaScriptMgr.GetNumber(L, 4);
					float num11 = (float)LuaScriptMgr.GetNumber(L, 5);
					Color32 val3 = (Color32)LuaScriptMgr.GetNetObject(L, 6, _206A_200D_202B_200E_202B_206E_202D_200E_202C_206D_202D_206F_200E_206B_200B_206F_200C_202E_206B_200F_206E_200C_202B_200F_200E_200C_202D_206F_200D_206A_202B_200B_202C_202D_202D_206B_200E_202A_202A_206A_202E(typeof(Color32).TypeHandle));
					_202E_206D_200E_202D_202A_200C_202A_206D_202B_200C_202E_202C_202D_202E_202B_206D_202E_206B_200C_200E_202E_206B_200D_202C_202D_206A_202A_202B_202D_202D_206C_202D_206A_206D_206D_200F_206A_202D_202C_206E_202E(val2, vector2, vector, num10, num11, val3);
					num2 = ((int)num3 * -439185547) ^ 0xB6DC9C;
					continue;
				}
				case 0u:
				{
					int num7;
					if (num != 2)
					{
						num2 = 1511035691;
						num7 = num2;
					}
					else
					{
						num2 = 1887400977;
						num7 = num2;
					}
					continue;
				}
				case 3u:
				{
					int num4;
					int num5;
					if (num != 2)
					{
						num4 = -1735131553;
						num5 = num4;
					}
					else
					{
						num4 = -905102184;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num3 * -1970687492);
					continue;
				}
				default:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3557786523u));
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
		object luaObject2 = LuaScriptMgr.GetLuaObject(L, 2);
		Object val2 = (Object)((luaObject2 is Object) ? luaObject2 : null);
		bool b = default(bool);
		while (true)
		{
			int num = 198590795;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0xE3F0FD1)) % 4)
				{
				case 0u:
					break;
				case 2u:
					b = _202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E(val, val2);
					num = ((int)num2 * -820430478) ^ -1537534232;
					continue;
				case 1u:
					LuaScriptMgr.Push(L, b);
					num = (int)((num2 * 608149645) ^ 0x6D1A1E47);
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	static Type _206A_200D_202B_200E_202B_206E_202D_200E_202C_206D_202D_206F_200E_206B_200B_206F_200C_202E_206B_200F_206E_200C_202B_200F_200E_200C_202D_206F_200D_206A_202B_200B_202C_202D_202D_206B_200E_202A_202A_206A_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static ParticleSystem _200E_202D_206A_200B_200B_206F_202B_206D_206E_200E_200E_206E_200D_200E_200D_206B_200F_202B_206D_202B_200E_206D_202A_202E_202E_206C_202A_202B_206D_202E_202B_200B_202B_202C_200B_202D_202C_202E_206D_206D_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ParticleSystem();
	}

	static bool _202E_206B_200E_200C_200E_206E_206B_200E_202C_200C_200B_206C_200E_200E_206E_206E_202A_200C_202C_200E_206E_206A_206B_206F_206B_200B_206B_206C_200F_206E_202E_206B_206D_200D_206C_200D_202B_206F_202C_206D_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static float _206F_200F_200D_206D_206E_206E_206D_206F_200E_200C_202E_202E_206B_206D_202A_200C_200F_200E_206F_200B_200E_200F_206C_206D_202D_200F_200F_206B_206C_206B_206B_202E_200F_200C_202E_202C_206E_206A_202E_200C_202E(ParticleSystem P_0)
	{
		return P_0.startDelay;
	}

	static bool _206D_202A_200B_206A_202D_200F_206A_200E_202A_206A_202B_202A_200B_200F_202E_206E_200D_200F_202A_202C_200E_200C_200E_206A_202C_200C_202B_200C_206F_206D_206D_200B_202E_202C_202C_200D_206A_200B_206D_206A_202E(ParticleSystem P_0)
	{
		return P_0.isPlaying;
	}

	static bool _206C_206F_200C_202C_200D_206B_200B_200C_206A_202D_206B_206A_200E_206F_206C_200B_206D_206F_202E_206B_202B_200C_200F_206A_202B_200C_202A_206A_200D_206C_206F_202D_202E_200F_206C_200D_202C_200B_206D_206B_202E(ParticleSystem P_0)
	{
		return P_0.isStopped;
	}

	static bool _206A_202E_200F_206A_200C_206C_202C_200B_206F_202B_206E_202A_206E_206A_206D_202E_206C_206E_206D_206A_206E_200B_200E_200B_206E_202A_202B_202A_206F_200B_206D_200C_202D_206B_202E_202A_202D_202B_206B_206A_202E(ParticleSystem P_0)
	{
		return P_0.isPaused;
	}

	static bool _200D_200D_206B_206F_200C_206D_200B_200D_200B_202A_202A_202D_200E_200C_200C_200D_202E_200D_206C_206D_202B_202B_200B_206E_206C_206F_202D_202A_206D_202E_206B_206E_202B_206B_202A_200E_206D_202C_200E_202A_202E(ParticleSystem P_0)
	{
		return P_0.loop;
	}

	static bool _206B_200C_200D_202D_206F_206A_200B_202D_202C_206B_202A_200B_200E_200F_206A_200B_200D_202B_200C_200C_206C_206E_200D_202D_202B_200F_206A_202E_200E_202D_206F_200E_206C_206F_202E_206B_202C_200C_206E_202B_202E(ParticleSystem P_0)
	{
		return P_0.playOnAwake;
	}

	static float _202A_202D_202E_206F_202D_200D_206D_200F_206F_206C_200B_206D_206D_200B_206A_200B_202A_200C_202B_202B_202B_206B_206A_200D_206D_206B_202B_206C_206C_206B_206C_202D_206F_200E_202A_206D_202A_206D_202C_202D_202E(ParticleSystem P_0)
	{
		return P_0.time;
	}

	static float _206D_206D_200B_200B_202C_206B_206E_202D_202C_206C_206F_200F_200F_206E_206B_200C_200D_202C_202D_206C_206B_206E_206C_202D_200D_200B_200D_200E_202E_206D_202E_206C_206A_200F_206A_202B_200C_206F_206A_202B_202E(ParticleSystem P_0)
	{
		return P_0.duration;
	}

	static float _202C_206F_202A_200E_206F_206E_206F_202D_206C_202D_202C_206F_200C_200D_202A_200E_202B_206A_202B_200C_202A_202E_202D_202C_206E_206D_202B_200F_200F_202A_200F_202C_202B_206F_202C_202A_200F_206A_200B_202D_202E(ParticleSystem P_0)
	{
		return P_0.playbackSpeed;
	}

	static int _206C_202B_202B_206C_200D_206D_206A_206C_202E_202C_206E_202C_202C_206D_202E_200B_202E_200D_200F_206A_200B_202A_200D_202D_206A_206D_202E_202A_200E_200E_200E_200C_200D_206A_206D_200D_202A_202A_206C_206E_202E(ParticleSystem P_0)
	{
		return P_0.particleCount;
	}

	static bool _200C_202D_200E_202A_206F_206E_202A_202E_200C_200E_200E_206B_202E_202E_206B_200D_200F_206E_200F_200C_206D_206A_206E_202A_200C_206A_206F_206C_202C_200C_202B_200D_206A_200E_206F_200C_200F_200B_202C_202B_202E(ParticleSystem P_0)
	{
		return P_0.enableEmission;
	}

	static float _200F_202D_200B_206B_200D_206D_202E_206F_200E_206D_206C_206E_206F_200F_200E_202A_202C_202D_206D_200F_202B_200F_202E_200B_202D_202D_202B_206A_206B_206B_200F_202C_200E_206F_202C_206A_202A_202E_202A_206E_202E(ParticleSystem P_0)
	{
		return P_0.emissionRate;
	}

	static float _206A_202B_200E_202E_206E_202E_202B_206E_206D_200F_200C_202B_202D_200F_206C_206A_202A_200D_206C_206E_206A_202E_206F_206B_206D_206F_200D_206A_206B_202A_202A_200F_206F_200C_206C_202E_202B_202C_200E_206D_202E(ParticleSystem P_0)
	{
		return P_0.startSpeed;
	}

	static float _202B_202B_200D_206F_202D_200C_206F_206D_206A_202E_202C_202E_202A_200E_202B_200F_200C_206F_202A_202A_206C_200F_200D_202B_200B_202E_202A_206A_202A_200E_200E_200D_200F_206C_200E_202D_200F_206A_200E_206E_202E(ParticleSystem P_0)
	{
		return P_0.startSize;
	}

	static Color _206E_206B_200C_206C_202D_206D_200D_202C_206C_202D_200E_206C_206C_206D_202A_200F_202D_200E_200B_206F_200B_206D_202C_200D_206D_206C_206D_200B_200C_202A_202B_202C_202A_206C_206A_202E_206D_200D_202E_202B_202E(ParticleSystem P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.startColor;
	}

	static float _206B_206E_206F_202E_200B_206B_200E_202A_206D_200F_206E_206F_206B_202D_202E_202E_202D_200C_206B_206F_206F_206A_200D_202A_202B_200D_200D_206D_202D_206C_202E_202E_206E_200D_202A_200E_206F_200B_200D_206B_202E(ParticleSystem P_0)
	{
		return P_0.startRotation;
	}

	static float _202A_200C_206F_200C_200F_206C_206D_202B_206A_200D_202A_200F_206D_200E_206E_200B_206B_206C_202C_206C_202A_202E_206F_202A_202A_202C_206D_206E_202D_202B_206C_202B_200F_206F_206F_200F_202B_206D_202D_200F_202E(ParticleSystem P_0)
	{
		return P_0.startLifetime;
	}

	static float _202A_202B_200C_206E_206D_202B_202E_202C_206D_202D_200F_202D_206D_202E_202E_202D_206F_202C_206D_206C_202E_206E_202B_206C_202D_200E_200F_202A_202B_200F_200B_200C_202D_200B_202C_206B_206D_202B_200D_206D_202E(ParticleSystem P_0)
	{
		return P_0.gravityModifier;
	}

	static int _206C_200D_202A_200B_202D_206E_202B_206B_202E_202D_200F_206A_200D_200C_206E_200E_202C_200B_202B_206B_200B_202A_206D_206B_202C_206A_206C_206E_202A_206B_200C_206C_200E_200E_202C_200F_202A_206C_200C_200E_202E(ParticleSystem P_0)
	{
		return P_0.maxParticles;
	}

	static ParticleSystemSimulationSpace _206A_200D_200F_206C_206F_206E_200D_206C_206E_200B_206A_206A_202E_202C_206C_206E_202A_202E_202B_200C_202C_202D_206F_202E_202C_200F_202A_206C_206F_202C_206F_206F_206C_202D_202C_200B_206A_206A_202B_202A_202E(ParticleSystem P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.simulationSpace;
	}

	static uint _202A_200D_202B_200E_202A_202D_206A_200B_202B_206E_206B_200B_206C_200D_206D_206B_206B_202E_202A_200E_200D_202A_202E_200F_200F_200D_200D_200D_206B_200D_206B_206D_206A_200C_202C_206D_202E_200F_202D_206B_202E(ParticleSystem P_0)
	{
		return P_0.randomSeed;
	}

	static void _200E_202D_206F_206B_206C_202C_206E_206B_206F_206B_206F_202C_206E_206A_200C_206F_202C_200F_200D_206A_206A_202D_200C_206B_206B_202E_200D_206D_202B_200E_202A_202E_200D_202D_202B_202E_200E_206C_200C_206C_202E(ParticleSystem P_0, float P_1)
	{
		P_0.startDelay = P_1;
	}

	static void _200D_206D_200D_202D_202E_202A_206B_200E_200B_202D_206D_206E_206F_202B_206D_202A_200D_202A_200E_206C_200E_202E_202B_206F_200F_202C_206E_206E_200B_200D_200B_206C_202C_202C_200C_206F_206B_206C_206E_206D_202E(ParticleSystem P_0, bool P_1)
	{
		P_0.loop = P_1;
	}

	static void _200F_200D_202D_200C_200E_206D_206D_202E_202D_202E_206F_200C_206F_200D_200D_200D_202A_200E_202E_200D_200B_202C_206E_200B_202D_200D_200C_206D_206E_202A_200D_206D_206E_202E_200B_206B_202B_202B_200B_206D_202E(ParticleSystem P_0, bool P_1)
	{
		P_0.playOnAwake = P_1;
	}

	static void _200E_200D_202B_202E_206A_202A_200F_200B_206B_202A_202E_200C_200C_206B_202B_200D_202C_200B_206D_206E_206A_200E_200D_206E_200D_202E_200D_206E_206F_206C_202E_206C_206D_200B_206B_202B_206C_202D_200F_200E_202E(ParticleSystem P_0, float P_1)
	{
		P_0.time = P_1;
	}

	static void _202B_200C_206F_202E_202B_202C_206C_206C_206A_202C_202B_200C_206C_202E_202C_200B_200F_200E_206D_200C_202D_206E_200D_206C_206A_206B_200D_202B_202A_200F_202A_206B_200B_200E_200B_206E_202A_206F_200F_202A_202E(ParticleSystem P_0, float P_1)
	{
		P_0.playbackSpeed = P_1;
	}

	static void _206D_202D_206E_206A_200C_202C_202D_200B_206B_206F_206F_202D_206F_206C_200C_200B_206E_206C_202E_202E_200B_202E_200E_200B_206C_206D_200F_206D_202C_206B_206C_200F_202B_200F_200F_202B_206E_206D_206E_202C_202E(ParticleSystem P_0, bool P_1)
	{
		P_0.enableEmission = P_1;
	}

	static void _206E_206D_206E_202B_206B_200D_202A_200F_206E_202D_206E_206F_200B_206D_206E_206D_206C_206F_206A_206C_200C_206F_200E_200D_202C_200C_202B_200D_206A_200B_206A_206A_200F_206C_200D_206A_206E_206B_206F_202B_202E(ParticleSystem P_0, float P_1)
	{
		P_0.emissionRate = P_1;
	}

	static void _202B_206D_200B_200E_200E_202B_206B_206A_200E_206E_202A_200C_200C_202A_202C_200F_202B_206B_202B_200B_206A_202B_202A_202B_202D_206B_200E_202B_202A_206F_202B_200D_202B_206D_206D_206E_206A_206F_202E_202E(ParticleSystem P_0, float P_1)
	{
		P_0.startSpeed = P_1;
	}

	static void _206E_200D_206C_200B_202C_202B_206C_200C_200D_202B_202E_202A_202B_200E_206F_200C_206C_200D_206F_200C_202A_206D_200C_202D_200D_206E_206B_206A_202D_202B_206C_200C_206F_202D_206E_206C_206C_202B_200C_206F_202E(ParticleSystem P_0, float P_1)
	{
		P_0.startSize = P_1;
	}

	static void _206F_200F_206E_200B_202A_206F_202A_206F_202D_206D_206C_206D_206D_200E_206A_206C_206E_202B_202A_200F_202E_206F_202E_206E_206F_200B_202A_202E_200C_200C_200D_206D_202E_202E_202B_200C_200E_200B_202E_206A_202E(ParticleSystem P_0, Color P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.startColor = P_1;
	}

	static void _200E_206B_206B_202D_200B_206B_200E_200E_206A_200B_206F_202D_206D_202B_206F_202E_206C_202D_200E_206C_206B_202D_206A_206C_200E_206E_202E_202A_202E_206D_206A_202A_200E_202B_206E_206D_200B_202D_206F_202E(ParticleSystem P_0, float P_1)
	{
		P_0.startRotation = P_1;
	}

	static void _202D_200D_206E_202E_206E_206B_202A_202C_200D_206B_202D_200B_202A_200C_200E_200D_206B_206F_200D_206D_200C_202A_200C_200F_200F_202D_202C_202C_200F_206C_206F_202C_206F_206A_200B_200F_200F_206B_206C_206F_202E(ParticleSystem P_0, float P_1)
	{
		P_0.startLifetime = P_1;
	}

	static void _200E_200B_202B_202A_206C_206E_202A_200E_206A_202B_200F_206F_200B_200B_202C_202A_206C_202B_206D_206D_200F_200F_200E_202E_202C_206A_200F_206B_206A_200F_206C_202B_200F_202D_202C_202A_206B_200B_202D_200D_202E(ParticleSystem P_0, float P_1)
	{
		P_0.gravityModifier = P_1;
	}

	static void _202D_200E_206E_206E_206F_202C_202C_200B_202C_202D_202E_202D_200E_200B_202B_202C_200F_200B_206A_200E_202A_202E_206C_206B_206D_200D_200B_206E_206B_206C_206B_206A_202C_202A_206D_206E_200C_206E_206F_206D_202E(ParticleSystem P_0, int P_1)
	{
		P_0.maxParticles = P_1;
	}

	static void _202C_200C_200D_200D_202E_200E_206E_206D_202B_206F_202C_200C_206B_202A_202C_206B_202C_206A_206F_202D_202B_200D_202D_206E_206B_206D_202E_206D_202B_206D_202A_206F_206A_202E_202D_202C_206F_206F_202E_202A_202E(ParticleSystem P_0, ParticleSystemSimulationSpace P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.simulationSpace = P_1;
	}

	static void _206E_202C_200D_206E_202D_202E_200F_202D_206F_202D_200B_200F_206D_200F_206C_202E_206F_206D_206E_206D_202B_202A_202E_200C_202A_202A_206A_200F_202C_200C_200F_206B_202C_202B_206C_202D_202C_202D_200E_200F_202E(ParticleSystem P_0, uint P_1)
	{
		P_0.randomSeed = P_1;
	}

	static void _202B_202B_200B_202D_206D_202B_206C_202B_202E_200C_200B_206D_200B_202B_206B_206F_206C_206C_206A_202C_206A_202A_206F_206B_202B_200C_202C_202D_206A_202C_202D_206B_206A_200F_206E_206C_202C_206A_202A_200E_202E(ParticleSystem P_0, Particle[] P_1, int P_2)
	{
		P_0.SetParticles(P_1, P_2);
	}

	static int _200E_200C_202E_200B_202D_202D_206E_200D_206E_200C_202E_200D_206E_206B_200B_200D_200B_200F_206B_206F_206A_200E_206C_200B_200E_200B_206D_200C_206C_206C_200B_202B_200F_202E_200B_206E_202E_202E_206A_202C_202E(ParticleSystem P_0, Particle[] P_1)
	{
		return P_0.GetParticles(P_1);
	}

	static void _200D_206E_202D_202D_206A_206B_202B_200D_202D_200F_202A_202A_200D_200C_200B_200E_200C_200F_206F_200B_200C_202C_200D_206D_206D_206A_200D_200F_206F_202E_206E_206E_206B_206A_202B_200C_206D_202B_202D_202A_202E(ParticleSystem P_0, float P_1)
	{
		P_0.Simulate(P_1);
	}

	static void _202A_206E_206D_200D_206D_200B_202E_202A_202A_200D_202C_202D_202D_202D_206A_206E_200D_206D_200F_206F_206E_200B_200B_206C_206B_206C_206F_206A_206C_206D_206E_206A_200B_206A_200E_202E_202C_206A_206A_206F_202E(ParticleSystem P_0, float P_1, bool P_2)
	{
		P_0.Simulate(P_1, P_2);
	}

	static void _200C_200F_206F_206C_206F_206B_206B_202E_206A_202B_200C_206A_200D_202C_200D_200B_200F_206B_202B_200F_202C_200F_206D_200F_202C_200B_202A_206B_200C_202A_200E_200D_206C_200B_206B_206A_200D_202E_202A_206A_202E(ParticleSystem P_0, float P_1, bool P_2, bool P_3)
	{
		P_0.Simulate(P_1, P_2, P_3);
	}

	static void _200E_200F_200B_206B_206A_202E_202D_200B_202D_200B_206B_206C_200D_206F_206D_206F_202A_200D_200F_202D_200B_206B_200B_200F_206A_200E_200E_206D_202B_200C_202B_206B_200F_206F_206B_202D_202E_200E_206C_200D_202E(ParticleSystem P_0)
	{
		P_0.Play();
	}

	static void _206A_206B_206C_200B_200C_200C_202A_206A_206F_200B_206D_200F_202A_200D_206D_202A_200C_202A_206D_206B_202A_200B_202C_200C_206B_206B_200E_206B_206E_206C_200F_206A_206B_206C_200C_206D_200B_202C_200D_200D_202E(ParticleSystem P_0, bool P_1)
	{
		P_0.Play(P_1);
	}

	static void _200E_206C_202B_206F_202A_200C_202E_202B_202D_206C_206F_202A_206B_202C_202B_200E_200D_202D_202B_202E_206E_202A_202B_202C_202A_200E_206C_200C_200F_200F_200F_202A_202B_200E_206E_206B_206C_202D_202B_206B_202E(ParticleSystem P_0)
	{
		P_0.Stop();
	}

	static void _206D_200F_200E_200E_200B_206C_200F_202C_206C_202D_206F_202E_200B_206B_206B_202E_200C_200C_206D_206E_202A_202A_202B_206F_202D_202C_200D_202C_202D_206C_202A_200E_206B_202A_202A_202E_202C_206D_206F_202E(ParticleSystem P_0, bool P_1)
	{
		P_0.Stop(P_1);
	}

	static void _206B_206B_202D_206E_200F_202C_206C_200F_206F_206B_206F_202C_202E_202E_202B_200B_200E_206E_202A_202C_200E_202E_202C_200E_206B_206E_202B_206C_200C_206E_206F_200E_206E_200E_206D_202E_200B_206A_202A_206C_202E(ParticleSystem P_0)
	{
		P_0.Pause();
	}

	static void _206F_206C_206D_202A_202C_206E_202E_206D_206C_200E_206A_202A_202A_206C_200B_200C_206C_202D_206D_206E_206D_202C_206D_206B_202A_206D_206F_200E_200F_206B_200E_202E_206A_202C_200C_200F_206A_206A_206D_206B_202E(ParticleSystem P_0, bool P_1)
	{
		P_0.Pause(P_1);
	}

	static void _200F_202E_206C_200C_206D_206D_202B_200E_206F_202C_206D_200C_202A_200B_206A_206B_206B_200C_202C_200E_206F_202B_202D_202B_206E_206F_206B_206A_202A_206B_202E_206C_206A_206E_202A_200B_200B_202B_206C_200F_202E(ParticleSystem P_0)
	{
		P_0.Clear();
	}

	static void _200B_202E_206B_206C_206A_202D_200C_206D_206A_202C_202B_200E_200D_202B_202B_206B_206A_200F_202B_202D_206A_200F_202E_200C_200B_202A_202A_200B_206D_202E_200F_200F_200C_206A_200B_206C_202D_202A_206A_202C_202E(ParticleSystem P_0, bool P_1)
	{
		P_0.Clear(P_1);
	}

	static bool _206E_206C_200C_202B_206B_206A_202B_200B_202D_200D_200C_200E_200F_200C_206A_202A_206F_200F_200D_202D_202E_202C_206E_202C_200F_202B_206A_202C_206C_200C_206A_206B_206A_206E_206B_206F_206D_206F_206A_206F_202E(ParticleSystem P_0)
	{
		return P_0.IsAlive();
	}

	static bool _202E_202C_202B_200B_206D_202B_206C_206C_206D_206B_206F_206A_206B_206E_206A_200D_200D_206F_200F_206E_200E_202B_200B_206C_206F_206B_200E_200F_200D_200F_200D_200C_206F_200D_206F_206C_202C_200F_206E_202E_202E(ParticleSystem P_0, bool P_1)
	{
		return P_0.IsAlive(P_1);
	}

	static void _206F_206C_206B_200F_206A_206D_200D_206D_200C_206A_200F_206B_202E_202E_206F_200F_206D_200E_200C_200F_200F_200F_200E_200B_206A_200E_200B_206B_202E_202E_206D_200B_206C_200C_202D_202C_206B_200C_200B_202B_202E(ParticleSystem P_0, Particle P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.Emit(P_1);
	}

	static void _200E_200E_200D_200C_200B_206E_206F_202C_200E_206E_202E_200B_200C_200D_200C_206C_206A_206C_206F_206D_200D_200F_202A_206F_200D_200D_200E_202A_200E_200E_200F_206A_200E_206E_200C_206E_206F_206B_200C_200C_202E(ParticleSystem P_0, int P_1)
	{
		P_0.Emit(P_1);
	}

	static void _202E_206D_200E_202D_202A_200C_202A_206D_202B_200C_202E_202C_202D_202E_202B_206D_202E_206B_200C_200E_202E_206B_200D_202C_202D_206A_202A_202B_202D_202D_206C_202D_206A_206D_206D_200F_206A_202D_202C_206E_202E(ParticleSystem P_0, Vector3 P_1, Vector3 P_2, float P_3, float P_4, Color32 P_5)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		P_0.Emit(P_1, P_2, P_3, P_4, P_5);
	}
}
