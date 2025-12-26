using System;
using LuaInterface;
using UnityEngine;
using UnityEngine.Rendering;

public class LightWrap
{
	private static Type classType = _206B_200F_206A_202A_206C_200C_202A_206A_202B_206A_206E_206A_200B_202E_200C_200C_200B_206E_206E_202B_202A_206B_200E_206F_200E_200C_200B_206D_202E_200D_200D_200F_206B_202E_206C_202C_206E_206E_200B_200D_202E(typeof(Light).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[9]
		{
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2356847606u), AddCommandBuffer),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(663464587u), RemoveCommandBuffer),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4101672020u), RemoveCommandBuffers),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2544231278u), RemoveAllCommandBuffers),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1401880959u), GetCommandBuffers),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(886441498u), GetLights),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1621874631u), _206C_202B_202A_202B_202E_202B_202A_206A_202E_206D_200B_202B_206B_206C_200E_202E_200D_200B_206C_202D_206A_200F_206C_202D_202C_202C_202D_200C_206A_200E_202A_202B_200C_200E_200D_206A_202C_202E_200B_206B_202E),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3661446913u), GetClassType),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3465012375u), Lua_Eq)
		};
		while (true)
		{
			int num = 1747534720;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0xB900F17)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_018c;
				case 2u:
					return;
				}
				break;
				IL_018c:
				LuaField[] fields = new LuaField[17]
				{
					new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1961445347u), get_type, set_type),
					new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2391959251u), get_color, set_color),
					new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2770317018u), get_intensity, set_intensity),
					new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(689630745u), get_bounceIntensity, set_bounceIntensity),
					new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2556026987u), get_shadows, set_shadows),
					new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1805718135u), get_shadowStrength, set_shadowStrength),
					new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3887054771u), get_shadowBias, set_shadowBias),
					new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1901307435u), get_shadowNormalBias, set_shadowNormalBias),
					new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(534353869u), get_range, set_range),
					new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(206316633u), get_spotAngle, set_spotAngle),
					new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(51093509u), get_cookieSize, set_cookieSize),
					new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(920003803u), get_cookie, set_cookie),
					new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4197355029u), get_flare, set_flare),
					new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2179141368u), get_renderMode, set_renderMode),
					new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4000544276u), get_alreadyLightmapped, set_alreadyLightmapped),
					new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3244041210u), get_cullingMask, set_cullingMask),
					new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1366930033u), get_commandBufferCount, null)
				};
				LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2922274766u), _206B_200F_206A_202A_206C_200C_202A_206A_202B_206A_206E_206A_200B_202E_200C_200C_200B_206E_206E_202B_202A_206B_200E_206F_200E_200C_200B_206D_202E_200D_200D_200F_206B_202E_206C_202C_206E_206E_200B_200D_202E(typeof(Light).TypeHandle), regs, fields, _206B_200F_206A_202A_206C_200C_202A_206A_202B_206A_206E_206A_200B_202E_200C_200C_200B_206E_206E_202B_202A_206B_200E_206F_200E_200C_200B_206D_202E_200D_200D_200F_206B_202E_206C_202C_206E_206E_200B_200D_202E(typeof(Behaviour).TypeHandle));
				num = ((int)num2 * -1637077591) ^ -2032824443;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _206C_202B_202A_202B_202E_202B_202A_206A_202E_206D_200B_202B_206B_206C_200E_202E_200D_200B_206C_202D_206A_200F_206C_202D_202C_202C_202D_200C_206A_200E_202A_202B_200C_200E_200D_206A_202C_202E_200B_206B_202E(IntPtr P_0)
	{
		int num = LuaDLL.lua_gettop(P_0);
		Light obj = default(Light);
		while (true)
		{
			int num2 = 463583766;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x1180FA61)) % 6)
				{
				case 0u:
					break;
				case 2u:
					LuaDLL.luaL_error(P_0, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3492333623u));
					num2 = 1431933358;
					continue;
				case 4u:
					LuaScriptMgr.Push(P_0, (Object)(object)obj);
					return 1;
				case 3u:
					obj = _200B_206C_200F_202E_200E_200F_206C_206C_202A_206D_200E_202A_200F_206E_200F_206A_206E_206A_202D_200E_206B_200B_202A_206F_206C_206C_200C_202A_200B_206E_200D_202B_200D_200B_202A_200B_202E_202A_200E_206E_202E();
					num2 = ((int)num3 * -1186363940) ^ 0x5D502F49;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (num == 0)
					{
						num4 = 1743807476;
						num5 = num4;
					}
					else
					{
						num4 = 585446707;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 1541949398);
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
	private static int get_type(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Light val = (Light)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 716565496;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x749DC766)) % 8)
				{
				case 2u:
					break;
				case 6u:
				{
					int num5;
					int num6;
					if (_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
					{
						num5 = 1659061180;
						num6 = num5;
					}
					else
					{
						num5 = 106741637;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1032678979);
					continue;
				}
				case 4u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 1695747895;
						num4 = num3;
					}
					else
					{
						num3 = 1043836009;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1486860983);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1376446182u));
					num = 652816095;
					continue;
				case 0u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 1466518530) ^ 0x6091549A);
					continue;
				case 7u:
					num = ((int)num2 * -1550693907) ^ -1307002204;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(942935174u));
					num = (int)((num2 * 806045666) ^ 0x1BA9D327);
					continue;
				default:
					LuaScriptMgr.Push(L, (Enum)(object)_202C_206C_200B_206C_206D_206A_200B_206E_206E_206B_202A_200F_206B_206C_206D_202E_202A_202A_200B_206F_200E_202E_206C_202D_200E_200C_206B_206C_200E_200F_206B_206C_206B_206C_206F_200B_202D_202C_206F_200D_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_color(IntPtr L)
	{
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Light val = default(Light);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -714824753;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -169515349)) % 9)
				{
				case 4u:
					break;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4212929657u));
					num = (int)((num2 * 233519893) ^ 0x403A9923);
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (!_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
					{
						num5 = 323390748;
						num6 = num5;
					}
					else
					{
						num5 = 1039266093;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1977771568);
					continue;
				}
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4205356016u));
					num = -133065924;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -1522063129;
						num4 = num3;
					}
					else
					{
						num3 = -1195726544;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1462592082);
					continue;
				}
				case 5u:
					val = (Light)luaObject;
					num = ((int)num2 * -2115588172) ^ -82006991;
					continue;
				case 3u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -212954409) ^ 0x50703625;
					continue;
				case 8u:
					LuaScriptMgr.Push(L, _206A_206A_200C_202B_202A_200D_200E_206F_200B_206C_202D_200D_202E_202A_206C_206F_206B_206C_206E_206E_202A_202B_206F_200C_202C_200E_200E_206A_202B_200E_200C_202E_206F_206A_200D_200D_200E_202C_202C_200C_202E(val));
					num = -178940045;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_intensity(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Light val = (Light)luaObject;
		if (_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
		{
			while (true)
			{
				int num = 1141981067;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x3362B06D)) % 5)
					{
					case 4u:
						break;
					case 3u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2986300117u));
						num = 343895403;
						continue;
					case 1u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(583121656u));
						num = (int)((num2 * 609783603) ^ 0x4BA8796);
						continue;
					case 2u:
					{
						LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
						int num3;
						int num4;
						if (luaTypes != LuaTypes.LUA_TTABLE)
						{
							num3 = 772152154;
							num4 = num3;
						}
						else
						{
							num3 = 216208112;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -582671277);
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
		LuaScriptMgr.Push(L, _200D_202A_206E_202B_206D_202A_202D_206F_202C_206B_200F_200E_206E_200F_202A_202C_200C_206B_200D_200B_200C_202C_200B_202D_200E_202C_202C_202A_202D_200C_206E_206B_206D_202E_200B_202B_206A_202B_200D_206D_202E(val));
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_bounceIntensity(IntPtr L)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Light val = default(Light);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -920467500;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1628628589)) % 9)
				{
				case 5u:
					break;
				case 2u:
					val = (Light)luaObject;
					num = (int)(num2 * 726618691) ^ -1736448200;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3140401930u));
					num = -1975568573;
					continue;
				case 7u:
					num = ((int)num2 * -1258533469) ^ 0x3EB570D3;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
					{
						num5 = 1894523774;
						num6 = num5;
					}
					else
					{
						num5 = 1465702481;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -480863913);
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 1018463159;
						num4 = num3;
					}
					else
					{
						num3 = 1226385765;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1681170);
					continue;
				}
				case 8u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -193435043) ^ 0x202B27F2;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3482249877u));
					num = (int)(num2 * 1337194727) ^ -23763221;
					continue;
				default:
					LuaScriptMgr.Push(L, _206A_202B_206B_200B_200D_200F_200D_200C_202E_206A_206F_200D_200F_202E_200D_202B_200F_206D_200B_206E_202C_202A_206A_202C_202E_206F_200E_202D_202C_206F_202B_202E_206D_200D_206B_206A_200C_206C_202C_202B_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_shadows(IntPtr L)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Light val = default(Light);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 482194715;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5E722863)) % 9)
				{
				case 6u:
					break;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1008871774u));
					num = 1372415069;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3972811286u));
					num = ((int)num2 * -1705014992) ^ -671440576;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (!_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
					{
						num5 = -1195247430;
						num6 = num5;
					}
					else
					{
						num5 = -1058941369;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1166940217);
					continue;
				}
				case 0u:
					num = ((int)num2 * -125257936) ^ -460461363;
					continue;
				case 1u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 1285138810) ^ 0x3203513F);
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 938241105;
						num4 = num3;
					}
					else
					{
						num3 = 1075784912;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1975157060);
					continue;
				}
				case 4u:
					val = (Light)luaObject;
					num = (int)(num2 * 749264050) ^ -1410706190;
					continue;
				default:
					LuaScriptMgr.Push(L, (Enum)(object)_200D_202B_200E_200B_206C_202C_206B_200B_200D_206E_206D_202D_200F_206F_200D_202D_206F_200E_200C_202D_202C_200C_206E_206D_200F_202A_202D_206A_200E_206C_206C_206A_206E_202D_202B_200F_202C_202A_200B_202D_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_shadowStrength(IntPtr L)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		Light val = default(Light);
		while (true)
		{
			int num = 505276345;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x35533D6D)) % 8)
				{
				case 6u:
					break;
				case 7u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -1983016742;
						num6 = num5;
					}
					else
					{
						num5 = -181893417;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1664857090);
					continue;
				}
				case 3u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1849936052) ^ -185833810;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
					{
						num3 = 1150111313;
						num4 = num3;
					}
					else
					{
						num3 = 1004047008;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -2086332025);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3977298096u));
					num = 92811495;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3466002237u));
					num = (int)((num2 * 2055418343) ^ 0x7E48BC24);
					continue;
				case 4u:
					val = (Light)luaObject;
					num = (int)(num2 * 1910079187) ^ -1269759856;
					continue;
				default:
					LuaScriptMgr.Push(L, _200B_202C_202E_206C_206A_202A_206D_202D_206B_200F_200C_206A_200B_200C_206A_202B_206E_202E_200B_202D_202B_206D_200E_206D_202B_202B_206D_202B_202A_206D_202D_200C_202C_202D_200D_206C_202E_200E_202C_202B_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_shadowBias(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Light val = (Light)luaObject;
		if (_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
		{
			goto IL_0018;
		}
		goto IL_0051;
		IL_0018:
		int num = 918125384;
		goto IL_001d;
		IL_001d:
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x6E0E7FAC)) % 8)
			{
			case 5u:
				break;
			case 0u:
				goto IL_0051;
			case 7u:
			{
				int num3;
				int num4;
				if (luaTypes == LuaTypes.LUA_TTABLE)
				{
					num3 = -673189906;
					num4 = num3;
				}
				else
				{
					num3 = -275155509;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -1559232340);
				continue;
			}
			case 6u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1900605304u));
				num = ((int)num2 * -230835919) ^ -1736278181;
				continue;
			case 1u:
				num = (int)(num2 * 238311656) ^ -1050104836;
				continue;
			case 3u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(25310794u));
				num = 544943380;
				continue;
			case 4u:
				luaTypes = LuaDLL.lua_type(L, 1);
				num = (int)(num2 * 940685329) ^ -942051913;
				continue;
			default:
				return 1;
			}
			break;
		}
		goto IL_0018;
		IL_0051:
		LuaScriptMgr.Push(L, _202B_200E_202A_200C_206D_202A_206C_202E_206C_206B_200E_200C_202D_200C_202A_202E_206C_200E_206F_206C_206C_202E_206D_206A_202B_202D_200D_206F_202B_200B_206D_200F_202E_200C_206F_206C_200E_202C_200D_200F_202E(val));
		num = 1120394878;
		goto IL_001d;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_shadowNormalBias(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Light val = (Light)luaObject;
		if (_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
		{
			while (true)
			{
				int num = -498843945;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1084562534)) % 5)
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
							num3 = 485234871;
							num4 = num3;
						}
						else
						{
							num3 = 953750569;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -1679381695);
						continue;
					}
					case 2u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(609390382u));
						num = (int)(num2 * 1947465887) ^ -1591625133;
						continue;
					case 4u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1615569060u));
						num = -763333423;
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
		LuaScriptMgr.Push(L, _206E_206C_206E_200D_202E_202A_202B_202B_202C_202E_206D_200E_206D_200C_202D_202D_200B_206D_200D_206D_200F_202A_202C_206B_200F_206A_202B_200E_202B_206C_206E_202A_202E_202B_200F_202E_200F_206C_200B_200C_202E(val));
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_range(IntPtr L)
	{
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		Light val = default(Light);
		while (true)
		{
			int num = -1677030541;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -861002282)) % 9)
				{
				case 7u:
					break;
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2607924887u));
					num = (int)(num2 * 1893163574) ^ -1236505163;
					continue;
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -139022669) ^ -300838615;
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (!_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
					{
						num5 = -1267699379;
						num6 = num5;
					}
					else
					{
						num5 = -1341053069;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -856822910);
					continue;
				}
				case 3u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -389211977;
						num4 = num3;
					}
					else
					{
						num3 = -60147017;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 2089060098);
					continue;
				}
				case 1u:
					val = (Light)luaObject;
					num = ((int)num2 * -51182947) ^ 0x376A8124;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3197818260u));
					num = -1229646005;
					continue;
				case 2u:
					LuaScriptMgr.Push(L, _200B_200C_206D_206F_206E_202E_202C_206E_200B_202B_206A_200D_202D_206F_202D_206A_202D_200F_202A_206D_200B_206C_200B_206F_202B_202B_200C_202E_200F_200E_206F_206F_200D_206C_202E_206D_200E_202A_206C_206A_202E(val));
					num = -670550284;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_spotAngle(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Light val = (Light)luaObject;
		while (true)
		{
			int num = 104362156;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3484D03D)) % 8)
				{
				case 4u:
					break;
				case 0u:
					num = (int)(num2 * 136910642) ^ -1677840750;
					continue;
				case 7u:
					LuaScriptMgr.Push(L, _206A_206B_202E_202B_200E_202B_202B_206F_202D_206A_206B_202B_200B_202D_202E_206E_202E_206D_206C_206B_200D_200B_206E_200E_206E_206C_200F_202C_206D_202D_200E_200B_202D_202E_206E_202C_200C_206D_200C_206E_202E(val));
					num = 1004491904;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(332718561u));
					num = (int)(num2 * 1111079982) ^ -208142159;
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (!_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
					{
						num5 = -819846680;
						num6 = num5;
					}
					else
					{
						num5 = -809772747;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1448719542);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2194378229u));
					num = 196396290;
					continue;
				case 2u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -1551179223;
						num4 = num3;
					}
					else
					{
						num3 = -2095198988;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 967771165);
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
	private static int get_cookieSize(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Light val = (Light)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1615116508;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1460427400)) % 8)
				{
				case 2u:
					break;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4077510358u));
					num = -240558003;
					continue;
				case 3u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1177677552) ^ -1247796712;
					continue;
				case 5u:
					LuaScriptMgr.Push(L, _202C_206E_200F_206A_206A_200F_206C_202B_206A_200E_206A_206B_202C_206B_200F_200F_200B_200C_200D_206B_200F_202E_200C_202C_206C_202D_202D_202E_200F_206B_206C_202D_206B_206F_200B_206A_206F_200E_200B_206A_202E(val));
					num = -792615618;
					continue;
				case 0u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 1613023;
						num6 = num5;
					}
					else
					{
						num5 = 835702009;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -389024396);
					continue;
				}
				case 4u:
				{
					int num3;
					int num4;
					if (!_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
					{
						num3 = -802843171;
						num4 = num3;
					}
					else
					{
						num3 = -1520895349;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 652678716);
					continue;
				}
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1840869087u));
					num = (int)(num2 * 400007443) ^ -1079777432;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_cookie(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Light val = (Light)luaObject;
		while (true)
		{
			int num = -1909319984;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -683993284)) % 7)
				{
				case 0u:
					break;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1221947554u));
					num = -319483695;
					continue;
				case 5u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -783300642;
						num6 = num5;
					}
					else
					{
						num5 = -1294242907;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1698879738);
					continue;
				}
				case 1u:
					LuaScriptMgr.Push(L, (Object)(object)_200D_206A_206B_206C_200D_202D_200D_202D_200D_206A_200D_200B_202C_202E_202E_200F_202A_202C_200E_200D_202C_206B_206C_206B_202B_200E_200B_206E_200E_206A_200C_206C_206D_206C_206F_200C_200F_202B_206E_200F_202E(val));
					num = -711561732;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
					{
						num3 = -1431989747;
						num4 = num3;
					}
					else
					{
						num3 = -700368689;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -971451915);
					continue;
				}
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1874109034u));
					num = ((int)num2 * -31156758) ^ 0x2189CE6F;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_flare(IntPtr L)
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Light val = default(Light);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 317778304;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x18E15BB)) % 8)
				{
				case 5u:
					break;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(271606535u));
					num = ((int)num2 * -26902040) ^ -1170848929;
					continue;
				case 4u:
					num = ((int)num2 * -1532444582) ^ 0x3EF16B29;
					continue;
				case 3u:
				{
					val = (Light)luaObject;
					int num5;
					int num6;
					if (_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
					{
						num5 = -149916357;
						num6 = num5;
					}
					else
					{
						num5 = -610342074;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 127080293);
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 1893727486;
						num4 = num3;
					}
					else
					{
						num3 = 806456296;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1731650603);
					continue;
				}
				case 7u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -786822181) ^ -884607809;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4171774280u));
					num = 1463630593;
					continue;
				default:
					LuaScriptMgr.Push(L, (Object)(object)_200F_202B_202C_200F_206C_200C_206B_202A_202C_200E_206E_202C_202A_206C_200D_200B_206D_200D_200B_202B_206D_200D_200C_200E_200C_200B_202A_200D_206C_202E_200E_200D_200B_206F_206F_202A_200B_202E_206D_206D_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_renderMode(IntPtr L)
	{
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Light val = default(Light);
		while (true)
		{
			int num = 491327112;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3C2B8DF5)) % 8)
				{
				case 6u:
					break;
				case 3u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 1259712641;
						num6 = num5;
					}
					else
					{
						num5 = 730734930;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1783885479);
					continue;
				}
				case 2u:
				{
					int num3;
					int num4;
					if (_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
					{
						num3 = 665361866;
						num4 = num3;
					}
					else
					{
						num3 = 188286105;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 996690770);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(906321617u));
					num = ((int)num2 * -210413214) ^ 0x5D815964;
					continue;
				case 1u:
					num = ((int)num2 * -1694795925) ^ 0x7B58C7AE;
					continue;
				case 5u:
					val = (Light)luaObject;
					num = ((int)num2 * -292902455) ^ 0x4C6945E2;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1903370496u));
					num = 1127935645;
					continue;
				default:
					LuaScriptMgr.Push(L, (Enum)(object)_200B_200F_200F_206A_206E_200C_200F_206F_200D_202C_206D_200B_206D_206E_206B_206B_202C_200E_206A_202D_200D_202C_206D_202A_200C_206F_206F_202E_200B_206A_206B_206C_202C_206B_206A_200C_206C_202D_200F_202B_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_alreadyLightmapped(IntPtr L)
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Light val = default(Light);
		while (true)
		{
			int num = -715967928;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1328688599)) % 8)
				{
				case 4u:
					break;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1113698848u));
					num = -8130709;
					continue;
				case 6u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -1429154058;
						num6 = num5;
					}
					else
					{
						num5 = -1835698011;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 2077813290);
					continue;
				}
				case 7u:
				{
					int num3;
					int num4;
					if (!_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
					{
						num3 = -726318038;
						num4 = num3;
					}
					else
					{
						num3 = -1963599418;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -285236137);
					continue;
				}
				case 5u:
					num = (int)(num2 * 1672638821) ^ -1072180886;
					continue;
				case 1u:
					val = (Light)luaObject;
					num = (int)(num2 * 1435948944) ^ -2140974690;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2785846568u));
					num = ((int)num2 * -917412836) ^ -1499900860;
					continue;
				default:
					LuaScriptMgr.Push(L, _202B_206D_206C_206C_200F_202A_200B_200C_200F_206D_202C_202B_206A_206A_200D_202A_206A_206D_202C_200D_202C_202B_200E_206A_206D_206D_200C_200B_206B_202B_200E_202E_206F_202D_202A_202A_206D_206D_206F_202C_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_cullingMask(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Light val = (Light)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1359665467;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3BBE91C2)) % 8)
				{
				case 6u:
					break;
				case 1u:
				{
					int num5;
					int num6;
					if (_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
					{
						num5 = 244775885;
						num6 = num5;
					}
					else
					{
						num5 = 222197131;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1834160732);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3151634034u));
					num = 1097281807;
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -859606054;
						num4 = num3;
					}
					else
					{
						num3 = -1569718922;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -910181620);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2517575845u));
					num = (int)((num2 * 1872513440) ^ 0x1589DE8F);
					continue;
				case 3u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -488767878) ^ 0x568C0DA3;
					continue;
				case 5u:
					LuaScriptMgr.Push(L, _206D_206E_206A_200C_206D_202B_206E_202C_202E_206B_206D_200F_200D_206F_206B_202C_202E_200C_200F_206E_206D_200E_200E_206A_200D_200D_206D_200D_202D_200B_206B_200B_202A_200B_202A_206C_200E_202A_202E_200C_202E(val));
					num = 106919072;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_commandBufferCount(IntPtr L)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Light val = default(Light);
		while (true)
		{
			int num = -1383440542;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -278335125)) % 8)
				{
				case 4u:
					break;
				case 7u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -1854707014;
						num6 = num5;
					}
					else
					{
						num5 = -83259940;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 2120435081);
					continue;
				}
				case 5u:
					LuaScriptMgr.Push(L, _206F_206F_200D_202E_202A_200C_206F_202C_202C_202E_206F_202C_200D_206D_200C_200F_200D_206B_200B_200D_206C_200D_200D_206C_206D_200D_202E_202B_202C_202E_206E_200C_206C_200C_202A_200D_200D_200B_200E_200D_202E(val));
					num = -1878475600;
					continue;
				case 1u:
					val = (Light)luaObject;
					num = ((int)num2 * -1922127329) ^ -1907184322;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
					{
						num3 = 1124906942;
						num4 = num3;
					}
					else
					{
						num3 = 1315115652;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1306556756);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2754248782u));
					num = (int)((num2 * 451577336) ^ 0x3631A1D6);
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2557438029u));
					num = -512070634;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_type(IntPtr L)
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Light val = default(Light);
		while (true)
		{
			int num = -362781624;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1978942918)) % 6)
				{
				case 0u:
					break;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(103219942u));
					num = (int)(num2 * 1761082263) ^ -1290583626;
					continue;
				case 5u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -823208534;
						num6 = num5;
					}
					else
					{
						num5 = -1763770659;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -41356902);
					continue;
				}
				case 2u:
				{
					val = (Light)luaObject;
					int num3;
					int num4;
					if (_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
					{
						num3 = -1390542157;
						num4 = num3;
					}
					else
					{
						num3 = -1470984903;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1799052946);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1376446182u));
					num = -724186171;
					continue;
				default:
					_206F_202B_206E_202C_206B_200D_202B_200C_202E_206E_206C_200E_202A_202A_206D_200B_206A_206E_202C_200C_206D_200E_206B_202E_202D_206B_200E_206A_202C_206D_200D_200B_200B_206B_202B_206B_202C_206E_200B_206A_202E(val, (LightType)(int)LuaScriptMgr.GetNetObject(L, 3, _206B_200F_206A_202A_206C_200C_202A_206A_202B_206A_206E_206A_200B_202E_200C_200C_200B_206E_206E_202B_202A_206B_200E_206F_200E_200C_200B_206D_202E_200D_200D_200F_206B_202E_206C_202C_206E_206E_200B_200D_202E(typeof(LightType).TypeHandle)));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_color(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Light val = (Light)luaObject;
		if (_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
		{
			goto IL_0018;
		}
		goto IL_007b;
		IL_0018:
		int num = 1124341647;
		goto IL_001d;
		IL_001d:
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x5F6A7157)) % 7)
			{
			case 6u:
				break;
			case 4u:
				luaTypes = LuaDLL.lua_type(L, 1);
				num = (int)((num2 * 1037627938) ^ 0x394EB1F4);
				continue;
			case 1u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1186067521u));
				num = 1591962719;
				continue;
			case 0u:
				goto IL_007b;
			case 3u:
			{
				int num3;
				int num4;
				if (luaTypes == LuaTypes.LUA_TTABLE)
				{
					num3 = 1439702903;
					num4 = num3;
				}
				else
				{
					num3 = 1125972091;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -1040265996);
				continue;
			}
			case 5u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4112379628u));
				num = ((int)num2 * -1563364539) ^ -743165837;
				continue;
			default:
				return 0;
			}
			break;
		}
		goto IL_0018;
		IL_007b:
		_206F_206D_202D_202B_202E_202E_206D_202C_200E_202E_200D_200E_200E_206D_200C_202B_200F_200C_202E_206B_206A_200E_202D_206C_206B_206C_206A_200B_202D_200C_200F_206B_206A_206A_202B_200B_206B_200B_202E_206C_202E(val, LuaScriptMgr.GetColor(L, 3));
		num = 1290500084;
		goto IL_001d;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_intensity(IntPtr L)
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Light val = default(Light);
		while (true)
		{
			int num = -1566647969;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -680032045)) % 7)
				{
				case 2u:
					break;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3840894354u));
					num = (int)(num2 * 546970464) ^ -1243125587;
					continue;
				case 0u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 2019366475;
						num6 = num5;
					}
					else
					{
						num5 = 1584502170;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -675761399);
					continue;
				}
				case 4u:
				{
					val = (Light)luaObject;
					int num3;
					int num4;
					if (!_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
					{
						num3 = 845760005;
						num4 = num3;
					}
					else
					{
						num3 = 1229041342;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1856639674);
					continue;
				}
				case 1u:
					_200E_206E_206C_200D_206D_200C_200F_202B_200F_206F_206D_202B_200F_200C_202C_200C_200F_200D_202C_202A_206F_206A_206E_200F_202B_200E_206E_206F_200D_206F_206B_200B_206D_202C_202D_206A_202B_206F_206C_202A_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					num = -687967854;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1421770239u));
					num = -1347441075;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_bounceIntensity(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Light val = (Light)luaObject;
		if (_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
		{
			while (true)
			{
				int num = -954115308;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -617927688)) % 6)
					{
					case 0u:
						break;
					case 4u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1738932767u));
						num = -1197940087;
						continue;
					case 5u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1467934288u));
						num = ((int)num2 * -1860193388) ^ 0x69AD0E87;
						continue;
					case 3u:
						num = (int)(num2 * 1254470427) ^ -1397684000;
						continue;
					case 2u:
					{
						LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
						int num3;
						int num4;
						if (luaTypes != LuaTypes.LUA_TTABLE)
						{
							num3 = 2111956500;
							num4 = num3;
						}
						else
						{
							num3 = 550590497;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 1004816676);
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
		_200C_206A_206C_200F_202A_206A_206C_200C_202C_206D_202B_200F_206D_206D_202A_202E_206B_200B_202D_206E_202D_206E_202C_206E_206E_200F_200C_206E_206A_202A_200B_200B_200B_202E_206D_200C_202B_200C_200F_200C_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_shadows(IntPtr L)
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		Light val = default(Light);
		while (true)
		{
			int num = -1477156390;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1400921971)) % 8)
				{
				case 2u:
					break;
				case 6u:
					num = (int)((num2 * 2003865073) ^ 0x75D22782);
					continue;
				case 5u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 2000673658) ^ 0x3B3AD4FC);
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 813811442;
						num6 = num5;
					}
					else
					{
						num5 = 1295034926;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -591393683);
					continue;
				}
				case 7u:
				{
					val = (Light)luaObject;
					int num3;
					int num4;
					if (!_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
					{
						num3 = 64696995;
						num4 = num3;
					}
					else
					{
						num3 = 492390495;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -79632351);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3972811286u));
					num = (int)(num2 * 1806962734) ^ -2054900445;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1008871774u));
					num = -987629932;
					continue;
				default:
					_202D_200D_206A_206F_202E_202A_202E_202D_206A_206E_206B_202B_206D_206E_206F_206D_202A_200F_200D_202A_200E_202A_206B_200E_206F_202A_206F_200F_202B_200C_200D_206B_202D_206F_202B_206E_202D_200E_200E_206E_202E(val, (LightShadows)(int)LuaScriptMgr.GetNetObject(L, 3, _206B_200F_206A_202A_206C_200C_202A_206A_202B_206A_206E_206A_200B_202E_200C_200C_200B_206E_206E_202B_202A_206B_200E_206F_200E_200C_200B_206D_202E_200D_200D_200F_206B_202E_206C_202C_206E_206E_200B_200D_202E(typeof(LightShadows).TypeHandle)));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_shadowStrength(IntPtr L)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Light val = default(Light);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1653574058;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x57D98430)) % 9)
				{
				case 8u:
					break;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1273020225u));
					num = 130671118;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (!_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
					{
						num5 = 2051667626;
						num6 = num5;
					}
					else
					{
						num5 = 1671724629;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 496188734);
					continue;
				}
				case 3u:
					num = (int)((num2 * 838657587) ^ 0x1B9668ED);
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 1991874742;
						num4 = num3;
					}
					else
					{
						num3 = 1686247966;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 2094210252);
					continue;
				}
				case 6u:
					val = (Light)luaObject;
					num = (int)(num2 * 529770381) ^ -702830196;
					continue;
				case 1u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 1008511392) ^ 0x44AC05F7);
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1348491211u));
					num = ((int)num2 * -44597966) ^ 0x2BEE625;
					continue;
				default:
					_200C_202D_206A_206C_200F_202A_200E_202C_206F_206A_202A_200E_200D_202C_202A_202A_202E_200F_202A_206E_206C_200F_200D_200E_206C_206E_202B_202A_206F_206C_202C_202D_200D_200F_202B_206C_202E_206A_206E_202E_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_shadowBias(IntPtr L)
	{
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Light val = default(Light);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1273542385;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1421897823)) % 10)
				{
				case 0u:
					break;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(25310794u));
					num = -1656114819;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3140069786u));
					num = ((int)num2 * -270163984) ^ -1009910813;
					continue;
				case 4u:
					_202D_202A_200C_200D_206B_206D_200F_202A_202A_200C_206A_206D_206E_200D_200D_206E_202A_200E_206E_202D_202D_200C_206F_202A_200D_206B_200C_206C_206F_202E_206E_202D_206E_206E_200D_202D_202C_206C_206A_206A_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					num = -960912692;
					continue;
				case 9u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 1799840950;
						num6 = num5;
					}
					else
					{
						num5 = 1703245117;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 535702017);
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (!_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
					{
						num3 = 1877182393;
						num4 = num3;
					}
					else
					{
						num3 = 1205829280;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1179916444);
					continue;
				}
				case 5u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 1960641519) ^ 0x1C7D3649);
					continue;
				case 6u:
					num = (int)((num2 * 7937390) ^ 0x634FECA1);
					continue;
				case 8u:
					val = (Light)luaObject;
					num = ((int)num2 * -1488430375) ^ -958081352;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_shadowNormalBias(IntPtr L)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		Light val = default(Light);
		while (true)
		{
			int num = 1041301624;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x46805E29)) % 10)
				{
				case 6u:
					break;
				case 2u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 653744946) ^ -1765668048;
					continue;
				case 3u:
					_200F_202E_206A_206A_206C_206A_202E_202D_200E_200B_200B_206A_206A_200E_200E_206F_206E_206B_200E_202C_200E_202D_200F_202C_206D_202C_206D_206E_202C_200F_202A_200C_202A_206D_206F_206A_202B_206B_206B_206B_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					num = 1445403215;
					continue;
				case 9u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 704436883;
						num6 = num5;
					}
					else
					{
						num5 = 170317951;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1943741127);
					continue;
				}
				case 5u:
					val = (Light)luaObject;
					num = ((int)num2 * -279479727) ^ 0x217D56DC;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
					{
						num3 = -1966386301;
						num4 = num3;
					}
					else
					{
						num3 = -1785487328;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 349662758);
					continue;
				}
				case 0u:
					num = (int)(num2 * 1920301391) ^ -874867872;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2270141040u));
					num = 49134168;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1825411819u));
					num = (int)(num2 * 465170699) ^ -684803298;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_range(IntPtr L)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Light val = default(Light);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1542473419;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -853279801)) % 8)
				{
				case 0u:
					break;
				case 6u:
					_200B_206D_200F_202A_202A_206B_206A_206A_206F_202A_206C_200C_202C_200F_200C_202E_202C_202B_202A_206B_206C_206D_200C_200C_206A_206C_200E_202D_206B_206F_200B_206F_206E_202D_202E_202C_206A_202D_202B_202D_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					num = -411345525;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4004002182u));
					num = (int)(num2 * 1415008295) ^ -1337998806;
					continue;
				case 2u:
				{
					val = (Light)luaObject;
					int num5;
					int num6;
					if (_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
					{
						num5 = 1899721416;
						num6 = num5;
					}
					else
					{
						num5 = 1655272597;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1098444306);
					continue;
				}
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3197818260u));
					num = -1012974999;
					continue;
				case 3u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 1698841710) ^ -1370794678;
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -117959535;
						num4 = num3;
					}
					else
					{
						num3 = -1519580763;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -2141885951);
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
	private static int set_spotAngle(IntPtr L)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Light val = default(Light);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1093939870;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1038409972)) % 9)
				{
				case 3u:
					break;
				case 1u:
					val = (Light)luaObject;
					num = ((int)num2 * -434744790) ^ -408058345;
					continue;
				case 2u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 473835538) ^ -216283236;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
					{
						num5 = 962321573;
						num6 = num5;
					}
					else
					{
						num5 = 1112154404;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 217185540);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4224214980u));
					num = (int)((num2 * 1934711272) ^ 0x1FD35BA0);
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 597121716;
						num4 = num3;
					}
					else
					{
						num3 = 1466938887;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -336347658);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2421702640u));
					num = -99613064;
					continue;
				case 7u:
					_206D_202C_206A_206F_202B_202D_206F_206E_200C_202B_200B_200F_202B_206E_200C_202E_200D_202A_202C_200F_200F_202E_202B_202B_200C_202D_202B_202D_202C_202B_200D_206B_202B_200D_206E_206E_202B_206D_200D_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					num = -1450422640;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_cookieSize(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Light val = default(Light);
		while (true)
		{
			int num = -979420942;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1338624945)) % 7)
				{
				case 5u:
					break;
				case 6u:
				{
					val = (Light)luaObject;
					int num5;
					int num6;
					if (!_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
					{
						num5 = 293105859;
						num6 = num5;
					}
					else
					{
						num5 = 695138351;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1163259020);
					continue;
				}
				case 2u:
					_202D_200F_206B_206E_206B_202C_200D_206B_202C_206C_200B_200D_200D_202A_206C_200D_200C_200F_200D_202D_206A_202B_200E_202B_206A_202E_206B_202E_202D_206C_200D_202C_206C_202B_202A_200D_202E_202A_200F_206C_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					num = -457013563;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3363619657u));
					num = (int)(num2 * 917858050) ^ -254095677;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4077510358u));
					num = -1250575257;
					continue;
				case 0u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 1568716041;
						num4 = num3;
					}
					else
					{
						num3 = 1857371372;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -869210411);
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
	private static int set_cookie(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Light val = (Light)luaObject;
		while (true)
		{
			int num = 1634907729;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x71C8E0FB)) % 8)
				{
				case 5u:
					break;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2745314581u));
					num = 2130837981;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(885583807u));
					num = ((int)num2 * -61628726) ^ -691617024;
					continue;
				case 6u:
					_206C_202E_202A_206B_206F_206E_200C_202A_200C_206B_206D_200D_200C_206A_200B_202B_200B_206C_202B_206B_200E_202B_200C_206C_202B_202D_206C_200F_200F_206F_200F_206E_200D_206F_200D_200D_202A_206A_202B_206C_202E(val, (Texture)LuaScriptMgr.GetUnityObject(L, 3, _206B_200F_206A_202A_206C_200C_202A_206A_202B_206A_206E_206A_200B_202E_200C_200C_200B_206E_206E_202B_202A_206B_200E_206F_200E_200C_200B_206D_202E_200D_200D_200F_206B_202E_206C_202C_206E_206E_200B_200D_202E(typeof(Texture).TypeHandle)));
					num = 1669981815;
					continue;
				case 3u:
					num = ((int)num2 * -419009611) ^ -118190502;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
					{
						num5 = 1246279566;
						num6 = num5;
					}
					else
					{
						num5 = 140303953;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 2097417390);
					continue;
				}
				case 1u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 1348032252;
						num4 = num3;
					}
					else
					{
						num3 = 1898366179;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1152933088);
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
	private static int set_flare(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Light val = (Light)luaObject;
		if (_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
		{
			goto IL_001b;
		}
		goto IL_00aa;
		IL_001b:
		int num = -1549758371;
		goto IL_0020;
		IL_0020:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -2103414401)) % 6)
			{
			case 0u:
				break;
			case 4u:
			{
				LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
				int num3;
				int num4;
				if (luaTypes == LuaTypes.LUA_TTABLE)
				{
					num3 = 2045899926;
					num4 = num3;
				}
				else
				{
					num3 = 1504501765;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -1928139214);
				continue;
			}
			case 3u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1645587020u));
				num = (int)((num2 * 1915379353) ^ 0x495C7A5B);
				continue;
			case 2u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1335140772u));
				num = -1242634402;
				continue;
			case 1u:
				goto IL_00aa;
			default:
				return 0;
			}
			break;
		}
		goto IL_001b;
		IL_00aa:
		_202C_206C_206A_200E_206B_202B_200C_202C_200B_206F_206F_206A_202D_206D_200B_200E_206B_200E_206C_202E_200D_200E_200B_202B_200F_206B_202B_206B_206D_202E_206E_200F_206B_206C_202E_200F_206A_202B_206C_202A_202E(val, (Flare)LuaScriptMgr.GetUnityObject(L, 3, _206B_200F_206A_202A_206C_200C_202A_206A_202B_206A_206E_206A_200B_202E_200C_200C_200B_206E_206E_202B_202A_206B_200E_206F_200E_200C_200B_206D_202E_200D_200D_200F_206B_202E_206C_202C_206E_206E_200B_200D_202E(typeof(Flare).TypeHandle)));
		num = -560002820;
		goto IL_0020;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_renderMode(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Light val = default(Light);
		while (true)
		{
			int num = 897465877;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x63F34BC2)) % 7)
				{
				case 5u:
					break;
				case 1u:
					val = (Light)luaObject;
					num = ((int)num2 * -1393062991) ^ -1600901887;
					continue;
				case 6u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 1535148831;
						num6 = num5;
					}
					else
					{
						num5 = 1455540950;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 2119070528);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1075242932u));
					num = ((int)num2 * -242489042) ^ -1942118914;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
					{
						num3 = -516797596;
						num4 = num3;
					}
					else
					{
						num3 = -465254624;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -780437910);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4267816324u));
					num = 655861320;
					continue;
				default:
					_202C_202E_206F_206F_200E_202C_202C_202C_202C_200D_200E_202D_202D_206A_202B_202E_206F_202D_200B_202C_202B_202A_200E_202E_200C_200E_202C_200F_206C_206C_206D_202E_202D_202B_202B_200F_206F_202E_206C_202C_202E(val, (LightRenderMode)(int)LuaScriptMgr.GetNetObject(L, 3, _206B_200F_206A_202A_206C_200C_202A_206A_202B_206A_206E_206A_200B_202E_200C_200C_200B_206E_206E_202B_202A_206B_200E_206F_200E_200C_200B_206D_202E_200D_200D_200F_206B_202E_206C_202C_206E_206E_200B_200D_202E(typeof(LightRenderMode).TypeHandle)));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_alreadyLightmapped(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Light val = (Light)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 341158401;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x25126347)) % 9)
				{
				case 5u:
					break;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1136972153u));
					num = (int)((num2 * 1656071557) ^ 0x2CBFC226);
					continue;
				case 0u:
					num = (int)((num2 * 110262118) ^ 0x6F274794);
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (!_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
					{
						num5 = 1926968156;
						num6 = num5;
					}
					else
					{
						num5 = 1526646264;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1509193128);
					continue;
				}
				case 2u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -1977618695;
						num4 = num3;
					}
					else
					{
						num3 = -1215164010;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -50874412);
					continue;
				}
				case 6u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1728805901) ^ 0x4BACE27A;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1492554277u));
					num = 537534636;
					continue;
				case 1u:
					_200C_202E_200D_202E_202E_202E_206A_202B_202E_206C_202E_202A_200D_202A_206E_200B_200C_200C_206C_206F_200B_206F_206B_202A_202B_202C_202E_202D_206A_202C_202E_200D_202A_200E_200C_206E_200B_206E_202D_202C_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					num = 2003171403;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_cullingMask(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Light val = (Light)luaObject;
		if (_200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E((Object)(object)val, (Object)null))
		{
			goto IL_001b;
		}
		goto IL_00b1;
		IL_001b:
		int num = 1161988188;
		goto IL_0020;
		IL_0020:
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x7A05BA3A)) % 8)
			{
			case 0u:
				break;
			case 6u:
				luaTypes = LuaDLL.lua_type(L, 1);
				num = (int)((num2 * 2072057076) ^ 0x2C04A29B);
				continue;
			case 5u:
				num = (int)((num2 * 2076543685) ^ 0x7BAEB7C9);
				continue;
			case 3u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3151634034u));
				num = 1453168168;
				continue;
			case 1u:
			{
				int num3;
				int num4;
				if (luaTypes == LuaTypes.LUA_TTABLE)
				{
					num3 = 1816987065;
					num4 = num3;
				}
				else
				{
					num3 = 501886469;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -518091836);
				continue;
			}
			case 2u:
				goto IL_00b1;
			case 7u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(235487299u));
				num = ((int)num2 * -381544905) ^ 0x4A31B4B6;
				continue;
			default:
				return 0;
			}
			break;
		}
		goto IL_001b;
		IL_00b1:
		_202D_200F_202E_200E_200F_206B_200B_200C_200E_206A_202A_206D_200D_202A_206A_200F_202E_206F_200D_206C_202B_200E_206F_206C_206D_200F_200D_202E_206F_200D_200D_200E_206A_202A_200D_202E_200B_206A_200C_202D_202E(val, (int)LuaScriptMgr.GetNumber(L, 3));
		num = 980610446;
		goto IL_0020;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int AddCommandBuffer(IntPtr L)
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 3);
		Light val = default(Light);
		CommandBuffer val3 = default(CommandBuffer);
		LightEvent val2 = default(LightEvent);
		while (true)
		{
			int num = -1418917412;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1227815552)) % 5)
				{
				case 4u:
					break;
				case 1u:
					val = (Light)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2382205561u));
					num = (int)(num2 * 2129966716) ^ -212242676;
					continue;
				case 3u:
					val3 = (CommandBuffer)LuaScriptMgr.GetNetObject(L, 3, _206B_200F_206A_202A_206C_200C_202A_206A_202B_206A_206E_206A_200B_202E_200C_200C_200B_206E_206E_202B_202A_206B_200E_206F_200E_200C_200B_206D_202E_200D_200D_200F_206B_202E_206C_202C_206E_206E_200B_200D_202E(typeof(CommandBuffer).TypeHandle));
					num = (int)((num2 * 1393721753) ^ 0x547AA09E);
					continue;
				case 2u:
					val2 = (LightEvent)(int)LuaScriptMgr.GetNetObject(L, 2, _206B_200F_206A_202A_206C_200C_202A_206A_202B_206A_206E_206A_200B_202E_200C_200C_200B_206E_206E_202B_202A_206B_200E_206F_200E_200C_200B_206D_202E_200D_200D_200F_206B_202E_206C_202C_206E_206E_200B_200D_202E(typeof(LightEvent).TypeHandle));
					num = ((int)num2 * -120855565) ^ 0x5D28CE8B;
					continue;
				default:
					_200D_206E_202B_206D_202A_202B_202A_202D_200D_202C_200D_206D_200B_206B_202B_206E_202D_200E_202A_200B_202B_202A_206D_202D_200B_200E_200F_206B_200F_206B_202A_200E_200D_202E_206C_200E_200C_200F_206B_202C_202E(val, val2, val3);
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int RemoveCommandBuffer(IntPtr L)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 3);
		Light val = default(Light);
		LightEvent val2 = default(LightEvent);
		CommandBuffer val3 = default(CommandBuffer);
		while (true)
		{
			int num = 1566633391;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0xDE8E511)) % 5)
				{
				case 0u:
					break;
				case 2u:
					_206A_202C_200D_202A_202C_202E_200B_200F_200E_200B_206D_206C_200B_202C_200B_202E_206B_206F_200B_206C_200B_202A_206B_202A_200F_206B_200D_206F_200E_206D_200D_202A_202B_206A_202A_202B_200B_206F_200C_202A_202E(val, val2, val3);
					num = (int)(num2 * 1788597328) ^ -1655108966;
					continue;
				case 3u:
					val2 = (LightEvent)(int)LuaScriptMgr.GetNetObject(L, 2, _206B_200F_206A_202A_206C_200C_202A_206A_202B_206A_206E_206A_200B_202E_200C_200C_200B_206E_206E_202B_202A_206B_200E_206F_200E_200C_200B_206D_202E_200D_200D_200F_206B_202E_206C_202C_206E_206E_200B_200D_202E(typeof(LightEvent).TypeHandle));
					val3 = (CommandBuffer)LuaScriptMgr.GetNetObject(L, 3, _206B_200F_206A_202A_206C_200C_202A_206A_202B_206A_206E_206A_200B_202E_200C_200C_200B_206E_206E_202B_202A_206B_200E_206F_200E_200C_200B_206D_202E_200D_200D_200F_206B_202E_206C_202C_206E_206E_200B_200D_202E(typeof(CommandBuffer).TypeHandle));
					num = ((int)num2 * -2130546663) ^ -828705034;
					continue;
				case 4u:
					val = (Light)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2685816403u));
					num = (int)((num2 * 466119610) ^ 0x46C925F1);
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int RemoveCommandBuffers(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr.CheckArgsCount(L, 2);
		Light val = (Light)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1468864438u));
		LightEvent val2 = (LightEvent)(int)LuaScriptMgr.GetNetObject(L, 2, _206B_200F_206A_202A_206C_200C_202A_206A_202B_206A_206E_206A_200B_202E_200C_200C_200B_206E_206E_202B_202A_206B_200E_206F_200E_200C_200B_206D_202E_200D_200D_200F_206B_202E_206C_202C_206E_206E_200B_200D_202E(typeof(LightEvent).TypeHandle));
		_200C_200D_200E_202A_200D_202C_206E_200D_200C_202E_200C_200F_202E_202B_200D_202A_202A_206E_200E_200C_202B_200C_202A_206A_202A_206C_202D_206B_202B_200C_206A_206D_202C_200C_200C_200C_206B_202D_200D_206B_202E(val, val2);
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int RemoveAllCommandBuffers(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 1);
		Light val = (Light)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(236997479u));
		_206A_202A_206D_202D_206F_202A_200F_202C_206C_202D_202A_206E_206C_200B_202D_206A_202C_206D_202E_202D_206E_206E_206C_202E_206D_206B_206E_200B_200F_200C_202E_202A_206E_206A_206C_200D_200D_206E_206E_200D_202E(val);
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetCommandBuffers(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr.CheckArgsCount(L, 2);
		Light val = (Light)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(236997479u));
		CommandBuffer[] o = default(CommandBuffer[]);
		while (true)
		{
			int num = 1497181598;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x421EC7C8)) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_0040;
				default:
					LuaScriptMgr.PushArray(L, o);
					return 1;
				}
				break;
				IL_0040:
				LightEvent val2 = (LightEvent)(int)LuaScriptMgr.GetNetObject(L, 2, _206B_200F_206A_202A_206C_200C_202A_206A_202B_206A_206E_206A_200B_202E_200C_200C_200B_206E_206E_202B_202A_206B_200E_206F_200E_200C_200B_206D_202E_200D_200D_200F_206B_202E_206C_202C_206E_206E_200B_200D_202E(typeof(LightEvent).TypeHandle));
				o = _202C_202A_206B_206C_200E_206B_200D_200C_206E_206F_202E_206B_202E_200E_202B_202D_206D_206B_202E_202E_206C_200B_206B_206F_206B_206B_200D_206D_202C_206C_206F_202E_200D_202A_206D_206D_202E_200E_206D_206B_202E(val, val2);
				num = ((int)num2 * -1341597893) ^ -925906460;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetLights(IntPtr L)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr.CheckArgsCount(L, 2);
		LightType val = default(LightType);
		Light[] o = default(Light[]);
		int num3 = default(int);
		while (true)
		{
			int num = 2000754099;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x33623795)) % 6)
				{
				case 3u:
					break;
				case 4u:
					val = (LightType)(int)LuaScriptMgr.GetNetObject(L, 1, _206B_200F_206A_202A_206C_200C_202A_206A_202B_206A_206E_206A_200B_202E_200C_200C_200B_206E_206E_202B_202A_206B_200E_206F_200E_200C_200B_206D_202E_200D_200D_200F_206B_202E_206C_202C_206E_206E_200B_200D_202E(typeof(LightType).TypeHandle));
					num = (int)(num2 * 868260962) ^ -1081893963;
					continue;
				case 1u:
					LuaScriptMgr.PushArray(L, o);
					num = (int)(num2 * 730177438) ^ -212908348;
					continue;
				case 2u:
					num3 = (int)LuaScriptMgr.GetNumber(L, 2);
					num = (int)(num2 * 297643828) ^ -1039918651;
					continue;
				case 0u:
					o = _206D_202C_200F_202E_206F_200B_206A_200B_202C_202E_206D_200F_206A_206E_200E_200C_206A_200D_202C_202E_200F_206D_206B_206A_206A_200E_200B_206C_206D_202B_200B_200E_200B_206A_202E_206D_206E_206F_206F_200F_202E(val, num3);
					num = ((int)num2 * -402405666) ^ -2054284796;
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
		Object val = default(Object);
		Object val2 = default(Object);
		bool b = default(bool);
		while (true)
		{
			int num = -2139696721;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -200589483)) % 4)
				{
				case 0u:
					break;
				case 2u:
				{
					object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
					val = (Object)((luaObject is Object) ? luaObject : null);
					object luaObject2 = LuaScriptMgr.GetLuaObject(L, 2);
					val2 = (Object)((luaObject2 is Object) ? luaObject2 : null);
					num = ((int)num2 * -427192169) ^ -308245986;
					continue;
				}
				case 1u:
					b = _200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E(val, val2);
					num = ((int)num2 * -2073360663) ^ 0x2338F17B;
					continue;
				default:
					LuaScriptMgr.Push(L, b);
					return 1;
				}
				break;
			}
		}
	}

	static Type _206B_200F_206A_202A_206C_200C_202A_206A_202B_206A_206E_206A_200B_202E_200C_200C_200B_206E_206E_202B_202A_206B_200E_206F_200E_200C_200B_206D_202E_200D_200D_200F_206B_202E_206C_202C_206E_206E_200B_200D_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static Light _200B_206C_200F_202E_200E_200F_206C_206C_202A_206D_200E_202A_200F_206E_200F_206A_206E_206A_202D_200E_206B_200B_202A_206F_206C_206C_200C_202A_200B_206E_200D_202B_200D_200B_202A_200B_202E_202A_200E_206E_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Light();
	}

	static bool _200D_206D_206A_200C_206B_206F_200E_200F_206D_200F_200E_202D_206C_200F_200F_202A_202B_200C_206A_200B_206C_202A_202D_206A_206A_200B_200B_202E_206C_206F_202B_202B_202D_200F_202B_200B_200B_206D_202E_206C_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static LightType _202C_206C_200B_206C_206D_206A_200B_206E_206E_206B_202A_200F_206B_206C_206D_202E_202A_202A_200B_206F_200E_202E_206C_202D_200E_200C_206B_206C_200E_200F_206B_206C_206B_206C_206F_200B_202D_202C_206F_200D_202E(Light P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.type;
	}

	static Color _206A_206A_200C_202B_202A_200D_200E_206F_200B_206C_202D_200D_202E_202A_206C_206F_206B_206C_206E_206E_202A_202B_206F_200C_202C_200E_200E_206A_202B_200E_200C_202E_206F_206A_200D_200D_200E_202C_202C_200C_202E(Light P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.color;
	}

	static float _200D_202A_206E_202B_206D_202A_202D_206F_202C_206B_200F_200E_206E_200F_202A_202C_200C_206B_200D_200B_200C_202C_200B_202D_200E_202C_202C_202A_202D_200C_206E_206B_206D_202E_200B_202B_206A_202B_200D_206D_202E(Light P_0)
	{
		return P_0.intensity;
	}

	static float _206A_202B_206B_200B_200D_200F_200D_200C_202E_206A_206F_200D_200F_202E_200D_202B_200F_206D_200B_206E_202C_202A_206A_202C_202E_206F_200E_202D_202C_206F_202B_202E_206D_200D_206B_206A_200C_206C_202C_202B_202E(Light P_0)
	{
		return P_0.bounceIntensity;
	}

	static LightShadows _200D_202B_200E_200B_206C_202C_206B_200B_200D_206E_206D_202D_200F_206F_200D_202D_206F_200E_200C_202D_202C_200C_206E_206D_200F_202A_202D_206A_200E_206C_206C_206A_206E_202D_202B_200F_202C_202A_200B_202D_202E(Light P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.shadows;
	}

	static float _200B_202C_202E_206C_206A_202A_206D_202D_206B_200F_200C_206A_200B_200C_206A_202B_206E_202E_200B_202D_202B_206D_200E_206D_202B_202B_206D_202B_202A_206D_202D_200C_202C_202D_200D_206C_202E_200E_202C_202B_202E(Light P_0)
	{
		return P_0.shadowStrength;
	}

	static float _202B_200E_202A_200C_206D_202A_206C_202E_206C_206B_200E_200C_202D_200C_202A_202E_206C_200E_206F_206C_206C_202E_206D_206A_202B_202D_200D_206F_202B_200B_206D_200F_202E_200C_206F_206C_200E_202C_200D_200F_202E(Light P_0)
	{
		return P_0.shadowBias;
	}

	static float _206E_206C_206E_200D_202E_202A_202B_202B_202C_202E_206D_200E_206D_200C_202D_202D_200B_206D_200D_206D_200F_202A_202C_206B_200F_206A_202B_200E_202B_206C_206E_202A_202E_202B_200F_202E_200F_206C_200B_200C_202E(Light P_0)
	{
		return P_0.shadowNormalBias;
	}

	static float _200B_200C_206D_206F_206E_202E_202C_206E_200B_202B_206A_200D_202D_206F_202D_206A_202D_200F_202A_206D_200B_206C_200B_206F_202B_202B_200C_202E_200F_200E_206F_206F_200D_206C_202E_206D_200E_202A_206C_206A_202E(Light P_0)
	{
		return P_0.range;
	}

	static float _206A_206B_202E_202B_200E_202B_202B_206F_202D_206A_206B_202B_200B_202D_202E_206E_202E_206D_206C_206B_200D_200B_206E_200E_206E_206C_200F_202C_206D_202D_200E_200B_202D_202E_206E_202C_200C_206D_200C_206E_202E(Light P_0)
	{
		return P_0.spotAngle;
	}

	static float _202C_206E_200F_206A_206A_200F_206C_202B_206A_200E_206A_206B_202C_206B_200F_200F_200B_200C_200D_206B_200F_202E_200C_202C_206C_202D_202D_202E_200F_206B_206C_202D_206B_206F_200B_206A_206F_200E_200B_206A_202E(Light P_0)
	{
		return P_0.cookieSize;
	}

	static Texture _200D_206A_206B_206C_200D_202D_200D_202D_200D_206A_200D_200B_202C_202E_202E_200F_202A_202C_200E_200D_202C_206B_206C_206B_202B_200E_200B_206E_200E_206A_200C_206C_206D_206C_206F_200C_200F_202B_206E_200F_202E(Light P_0)
	{
		return P_0.cookie;
	}

	static Flare _200F_202B_202C_200F_206C_200C_206B_202A_202C_200E_206E_202C_202A_206C_200D_200B_206D_200D_200B_202B_206D_200D_200C_200E_200C_200B_202A_200D_206C_202E_200E_200D_200B_206F_206F_202A_200B_202E_206D_206D_202E(Light P_0)
	{
		return P_0.flare;
	}

	static LightRenderMode _200B_200F_200F_206A_206E_200C_200F_206F_200D_202C_206D_200B_206D_206E_206B_206B_202C_200E_206A_202D_200D_202C_206D_202A_200C_206F_206F_202E_200B_206A_206B_206C_202C_206B_206A_200C_206C_202D_200F_202B_202E(Light P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.renderMode;
	}

	static bool _202B_206D_206C_206C_200F_202A_200B_200C_200F_206D_202C_202B_206A_206A_200D_202A_206A_206D_202C_200D_202C_202B_200E_206A_206D_206D_200C_200B_206B_202B_200E_202E_206F_202D_202A_202A_206D_206D_206F_202C_202E(Light P_0)
	{
		return P_0.alreadyLightmapped;
	}

	static int _206D_206E_206A_200C_206D_202B_206E_202C_202E_206B_206D_200F_200D_206F_206B_202C_202E_200C_200F_206E_206D_200E_200E_206A_200D_200D_206D_200D_202D_200B_206B_200B_202A_200B_202A_206C_200E_202A_202E_200C_202E(Light P_0)
	{
		return P_0.cullingMask;
	}

	static int _206F_206F_200D_202E_202A_200C_206F_202C_202C_202E_206F_202C_200D_206D_200C_200F_200D_206B_200B_200D_206C_200D_200D_206C_206D_200D_202E_202B_202C_202E_206E_200C_206C_200C_202A_200D_200D_200B_200E_200D_202E(Light P_0)
	{
		return P_0.commandBufferCount;
	}

	static void _206F_202B_206E_202C_206B_200D_202B_200C_202E_206E_206C_200E_202A_202A_206D_200B_206A_206E_202C_200C_206D_200E_206B_202E_202D_206B_200E_206A_202C_206D_200D_200B_200B_206B_202B_206B_202C_206E_200B_206A_202E(Light P_0, LightType P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.type = P_1;
	}

	static void _206F_206D_202D_202B_202E_202E_206D_202C_200E_202E_200D_200E_200E_206D_200C_202B_200F_200C_202E_206B_206A_200E_202D_206C_206B_206C_206A_200B_202D_200C_200F_206B_206A_206A_202B_200B_206B_200B_202E_206C_202E(Light P_0, Color P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.color = P_1;
	}

	static void _200E_206E_206C_200D_206D_200C_200F_202B_200F_206F_206D_202B_200F_200C_202C_200C_200F_200D_202C_202A_206F_206A_206E_200F_202B_200E_206E_206F_200D_206F_206B_200B_206D_202C_202D_206A_202B_206F_206C_202A_202E(Light P_0, float P_1)
	{
		P_0.intensity = P_1;
	}

	static void _200C_206A_206C_200F_202A_206A_206C_200C_202C_206D_202B_200F_206D_206D_202A_202E_206B_200B_202D_206E_202D_206E_202C_206E_206E_200F_200C_206E_206A_202A_200B_200B_200B_202E_206D_200C_202B_200C_200F_200C_202E(Light P_0, float P_1)
	{
		P_0.bounceIntensity = P_1;
	}

	static void _202D_200D_206A_206F_202E_202A_202E_202D_206A_206E_206B_202B_206D_206E_206F_206D_202A_200F_200D_202A_200E_202A_206B_200E_206F_202A_206F_200F_202B_200C_200D_206B_202D_206F_202B_206E_202D_200E_200E_206E_202E(Light P_0, LightShadows P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.shadows = P_1;
	}

	static void _200C_202D_206A_206C_200F_202A_200E_202C_206F_206A_202A_200E_200D_202C_202A_202A_202E_200F_202A_206E_206C_200F_200D_200E_206C_206E_202B_202A_206F_206C_202C_202D_200D_200F_202B_206C_202E_206A_206E_202E_202E(Light P_0, float P_1)
	{
		P_0.shadowStrength = P_1;
	}

	static void _202D_202A_200C_200D_206B_206D_200F_202A_202A_200C_206A_206D_206E_200D_200D_206E_202A_200E_206E_202D_202D_200C_206F_202A_200D_206B_200C_206C_206F_202E_206E_202D_206E_206E_200D_202D_202C_206C_206A_206A_202E(Light P_0, float P_1)
	{
		P_0.shadowBias = P_1;
	}

	static void _200F_202E_206A_206A_206C_206A_202E_202D_200E_200B_200B_206A_206A_200E_200E_206F_206E_206B_200E_202C_200E_202D_200F_202C_206D_202C_206D_206E_202C_200F_202A_200C_202A_206D_206F_206A_202B_206B_206B_206B_202E(Light P_0, float P_1)
	{
		P_0.shadowNormalBias = P_1;
	}

	static void _200B_206D_200F_202A_202A_206B_206A_206A_206F_202A_206C_200C_202C_200F_200C_202E_202C_202B_202A_206B_206C_206D_200C_200C_206A_206C_200E_202D_206B_206F_200B_206F_206E_202D_202E_202C_206A_202D_202B_202D_202E(Light P_0, float P_1)
	{
		P_0.range = P_1;
	}

	static void _206D_202C_206A_206F_202B_202D_206F_206E_200C_202B_200B_200F_202B_206E_200C_202E_200D_202A_202C_200F_200F_202E_202B_202B_200C_202D_202B_202D_202C_202B_200D_206B_202B_200D_206E_206E_202B_206D_200D_202E(Light P_0, float P_1)
	{
		P_0.spotAngle = P_1;
	}

	static void _202D_200F_206B_206E_206B_202C_200D_206B_202C_206C_200B_200D_200D_202A_206C_200D_200C_200F_200D_202D_206A_202B_200E_202B_206A_202E_206B_202E_202D_206C_200D_202C_206C_202B_202A_200D_202E_202A_200F_206C_202E(Light P_0, float P_1)
	{
		P_0.cookieSize = P_1;
	}

	static void _206C_202E_202A_206B_206F_206E_200C_202A_200C_206B_206D_200D_200C_206A_200B_202B_200B_206C_202B_206B_200E_202B_200C_206C_202B_202D_206C_200F_200F_206F_200F_206E_200D_206F_200D_200D_202A_206A_202B_206C_202E(Light P_0, Texture P_1)
	{
		P_0.cookie = P_1;
	}

	static void _202C_206C_206A_200E_206B_202B_200C_202C_200B_206F_206F_206A_202D_206D_200B_200E_206B_200E_206C_202E_200D_200E_200B_202B_200F_206B_202B_206B_206D_202E_206E_200F_206B_206C_202E_200F_206A_202B_206C_202A_202E(Light P_0, Flare P_1)
	{
		P_0.flare = P_1;
	}

	static void _202C_202E_206F_206F_200E_202C_202C_202C_202C_200D_200E_202D_202D_206A_202B_202E_206F_202D_200B_202C_202B_202A_200E_202E_200C_200E_202C_200F_206C_206C_206D_202E_202D_202B_202B_200F_206F_202E_206C_202C_202E(Light P_0, LightRenderMode P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.renderMode = P_1;
	}

	static void _200C_202E_200D_202E_202E_202E_206A_202B_202E_206C_202E_202A_200D_202A_206E_200B_200C_200C_206C_206F_200B_206F_206B_202A_202B_202C_202E_202D_206A_202C_202E_200D_202A_200E_200C_206E_200B_206E_202D_202C_202E(Light P_0, bool P_1)
	{
		P_0.alreadyLightmapped = P_1;
	}

	static void _202D_200F_202E_200E_200F_206B_200B_200C_200E_206A_202A_206D_200D_202A_206A_200F_202E_206F_200D_206C_202B_200E_206F_206C_206D_200F_200D_202E_206F_200D_200D_200E_206A_202A_200D_202E_200B_206A_200C_202D_202E(Light P_0, int P_1)
	{
		P_0.cullingMask = P_1;
	}

	static void _200D_206E_202B_206D_202A_202B_202A_202D_200D_202C_200D_206D_200B_206B_202B_206E_202D_200E_202A_200B_202B_202A_206D_202D_200B_200E_200F_206B_200F_206B_202A_200E_200D_202E_206C_200E_200C_200F_206B_202C_202E(Light P_0, LightEvent P_1, CommandBuffer P_2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.AddCommandBuffer(P_1, P_2);
	}

	static void _206A_202C_200D_202A_202C_202E_200B_200F_200E_200B_206D_206C_200B_202C_200B_202E_206B_206F_200B_206C_200B_202A_206B_202A_200F_206B_200D_206F_200E_206D_200D_202A_202B_206A_202A_202B_200B_206F_200C_202A_202E(Light P_0, LightEvent P_1, CommandBuffer P_2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.RemoveCommandBuffer(P_1, P_2);
	}

	static void _200C_200D_200E_202A_200D_202C_206E_200D_200C_202E_200C_200F_202E_202B_200D_202A_202A_206E_200E_200C_202B_200C_202A_206A_202A_206C_202D_206B_202B_200C_206A_206D_202C_200C_200C_200C_206B_202D_200D_206B_202E(Light P_0, LightEvent P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.RemoveCommandBuffers(P_1);
	}

	static void _206A_202A_206D_202D_206F_202A_200F_202C_206C_202D_202A_206E_206C_200B_202D_206A_202C_206D_202E_202D_206E_206E_206C_202E_206D_206B_206E_200B_200F_200C_202E_202A_206E_206A_206C_200D_200D_206E_206E_200D_202E(Light P_0)
	{
		P_0.RemoveAllCommandBuffers();
	}

	static CommandBuffer[] _202C_202A_206B_206C_200E_206B_200D_200C_206E_206F_202E_206B_202E_200E_202B_202D_206D_206B_202E_202E_206C_200B_206B_206F_206B_206B_200D_206D_202C_206C_206F_202E_200D_202A_206D_206D_202E_200E_206D_206B_202E(Light P_0, LightEvent P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.GetCommandBuffers(P_1);
	}

	static Light[] _206D_202C_200F_202E_206F_200B_206A_200B_202C_202E_206D_200F_206A_206E_200E_200C_206A_200D_202C_202E_200F_206D_206B_206A_206A_200E_200B_206C_206D_202B_200B_200E_200B_206A_202E_206D_206E_206F_206F_200F_202E(LightType P_0, int P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Light.GetLights(P_0, P_1);
	}
}
