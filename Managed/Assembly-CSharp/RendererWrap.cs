using System;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;
using UnityEngine.Rendering;

public class RendererWrap
{
	private static Type classType = _200F_202C_202C_206A_200B_202D_206F_202E_200D_206C_206E_206C_200E_200E_202C_202C_206B_202C_202C_200C_206C_200E_200D_206B_202E_202C_202A_202D_202E_206B_200C_200E_200E_202A_202E_202E_200C_206E_202E_206F_202E(typeof(Renderer).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[6]
		{
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3243288323u), SetPropertyBlock),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3636656913u), GetPropertyBlock),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(987240308u), GetClosestReflectionProbes),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1657282774u), _200D_202E_206E_206B_200D_206F_202A_202D_206D_206B_206A_202B_202E_200B_200B_200E_200C_202A_200F_202E_200D_202C_202D_200E_206B_202B_202A_202E_202D_200F_202A_200F_202D_206A_202B_206F_206C_206F_200C_202C_202E),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2783592835u), GetClassType),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(60698966u), Lua_Eq)
		};
		LuaField[] fields = new LuaField[22]
		{
			new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2022075687u), get_isPartOfStaticBatch, null),
			new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1530521242u), get_worldToLocalMatrix, null),
			new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2606155275u), get_localToWorldMatrix, null),
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1867280171u), get_enabled, set_enabled),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1584992718u), get_shadowCastingMode, set_shadowCastingMode),
			new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2411462079u), get_receiveShadows, set_receiveShadows),
			new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(128930904u), get_material, set_material),
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(604567360u), get_sharedMaterial, set_sharedMaterial),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2634615471u), get_materials, set_materials),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1773670183u), get_sharedMaterials, set_sharedMaterials),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3168504564u), get_bounds, null),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3524362864u), get_lightmapIndex, set_lightmapIndex),
			new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3253554392u), get_realtimeLightmapIndex, set_realtimeLightmapIndex),
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4142366687u), get_lightmapScaleOffset, set_lightmapScaleOffset),
			new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2033792671u), get_realtimeLightmapScaleOffset, set_realtimeLightmapScaleOffset),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(576419936u), get_isVisible, null),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(425477964u), get_useLightProbes, set_useLightProbes),
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3563557518u), get_probeAnchor, set_probeAnchor),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2171596171u), get_reflectionProbeUsage, set_reflectionProbeUsage),
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3822097492u), get_sortingLayerName, set_sortingLayerName),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(227909198u), get_sortingLayerID, set_sortingLayerID),
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4080637466u), get_sortingOrder, set_sortingOrder)
		};
		while (true)
		{
			int num = -270591181;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1830328830)) % 3)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_0553;
				case 0u:
					return;
				}
				break;
				IL_0553:
				LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3653565927u), _200F_202C_202C_206A_200B_202D_206F_202E_200D_206C_206E_206C_200E_200E_202C_202C_206B_202C_202C_200C_206C_200E_200D_206B_202E_202C_202A_202D_202E_206B_200C_200E_200E_202A_202E_202E_200C_206E_202E_206F_202E(typeof(Renderer).TypeHandle), regs, fields, _200F_202C_202C_206A_200B_202D_206F_202E_200D_206C_206E_206C_200E_200E_202C_202C_206B_202C_202C_200C_206C_200E_200D_206B_202E_202C_202A_202D_202E_206B_200C_200E_200E_202A_202E_202E_200C_206E_202E_206F_202E(typeof(Component).TypeHandle));
				num = (int)(num2 * 284802357) ^ -1190072298;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _200D_202E_206E_206B_200D_206F_202A_202D_206D_206B_206A_202B_202E_200B_200B_200E_200C_202A_200F_202E_200D_202C_202D_200E_206B_202B_202A_202E_202D_200F_202A_200F_202D_206A_202B_206F_206C_206F_200C_202C_202E(IntPtr P_0)
	{
		int num = LuaDLL.lua_gettop(P_0);
		Renderer obj = default(Renderer);
		while (true)
		{
			int num2 = -1109608812;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -373707616)) % 7)
				{
				case 0u:
					break;
				case 1u:
				{
					int num4;
					int num5;
					if (num != 0)
					{
						num4 = 1738889756;
						num5 = num4;
					}
					else
					{
						num4 = 1752980548;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num3 * -246690457);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(P_0, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3729036913u));
					num2 = -723367298;
					continue;
				case 3u:
					LuaScriptMgr.Push(P_0, (Object)(object)obj);
					num2 = (int)((num3 * 2138003083) ^ 0x5795E38E);
					continue;
				case 4u:
					obj = _202B_200B_202B_202E_206A_202B_200E_202E_206A_206D_206F_200D_206B_202A_200F_200E_200C_206E_206F_206B_200B_206B_206B_206F_202E_200C_202D_206C_200F_202C_200D_202C_202C_202A_206B_200B_206B_202E_202C_202D_202E();
					num2 = ((int)num3 * -1451946936) ^ -488362470;
					continue;
				case 2u:
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
	private static int get_isPartOfStaticBatch(IntPtr L)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = default(Renderer);
		while (true)
		{
			int num = 890921591;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x28C147DE)) % 8)
				{
				case 6u:
					break;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(291127028u));
					num = ((int)num2 * -1066954365) ^ -836923316;
					continue;
				case 5u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -1054185529;
						num6 = num5;
					}
					else
					{
						num5 = -1517187606;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1134552382);
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (!_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = 2143332501;
						num4 = num3;
					}
					else
					{
						num3 = 370921531;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 108450968);
					continue;
				}
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4219598322u));
					num = 1170088661;
					continue;
				case 1u:
					val = (Renderer)luaObject;
					num = (int)((num2 * 1896417800) ^ 0x70D8E0E);
					continue;
				case 4u:
					num = ((int)num2 * -1616662182) ^ 0x7A9885D;
					continue;
				default:
					LuaScriptMgr.Push(L, _206B_206D_206B_206A_206E_206A_206B_206C_200D_200C_202C_200B_206C_202C_206F_206E_200F_202A_202C_206E_206C_200F_206C_202B_200B_202B_200F_200D_206B_206B_200C_200B_206F_202E_200B_206F_206C_200B_202B_206D_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_worldToLocalMatrix(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = (Renderer)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1556222596;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -527674090)) % 7)
				{
				case 0u:
					break;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2161173653u));
					num = -694057741;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -424617503;
						num6 = num5;
					}
					else
					{
						num5 = -330458194;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -604753776);
					continue;
				}
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(670940299u));
					num = (int)(num2 * 1987451716) ^ -243236973;
					continue;
				case 6u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 1446728039) ^ 0xC92D5A3);
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = 1406267287;
						num4 = num3;
					}
					else
					{
						num3 = 1798851807;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 291791146);
					continue;
				}
				default:
					LuaScriptMgr.PushValue(L, _200D_202D_202E_202A_202E_200B_206D_206C_206A_206D_206C_200C_206A_200F_202A_206A_206D_202D_202E_202A_200C_206C_206B_200F_200B_202A_206A_206F_206A_206B_202B_202A_206A_206C_202D_202D_202A_202E_206F_206A_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_localToWorldMatrix(IntPtr L)
	{
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		Renderer val = default(Renderer);
		while (true)
		{
			int num = 1546161158;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x30637E58)) % 9)
				{
				case 5u:
					break;
				case 7u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -968225757;
						num6 = num5;
					}
					else
					{
						num5 = -1230560331;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1599226185);
					continue;
				}
				case 1u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1852957680) ^ 0x7AC851;
					continue;
				case 3u:
				{
					val = (Renderer)luaObject;
					int num3;
					int num4;
					if (!_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = -1776386947;
						num4 = num3;
					}
					else
					{
						num3 = -713858615;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1254079393);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(229951362u));
					num = ((int)num2 * -1813017881) ^ -928948460;
					continue;
				case 8u:
					num = ((int)num2 * -2037646740) ^ 0x21F1AB7B;
					continue;
				case 2u:
					LuaScriptMgr.PushValue(L, _200F_206A_200F_200C_200F_206E_202C_206C_200B_202A_206D_206F_200D_202B_206F_206B_206C_202B_206E_202A_206E_206A_200E_200D_202B_200D_200C_200E_200D_202C_202B_206F_202C_202D_206C_206B_206E_206D_200B_206C_202E(val));
					num = 984484144;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1387016145u));
					num = 65956707;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_enabled(IntPtr L)
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = default(Renderer);
		while (true)
		{
			int num = -1873246923;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -737704642)) % 6)
				{
				case 0u:
					break;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3927089387u));
					num = (int)((num2 * 975710891) ^ 0x5EFA2576);
					continue;
				case 4u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -1676460551;
						num6 = num5;
					}
					else
					{
						num5 = -1540695418;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -713525086);
					continue;
				}
				case 3u:
				{
					val = (Renderer)luaObject;
					int num3;
					int num4;
					if (!_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = 1591361815;
						num4 = num3;
					}
					else
					{
						num3 = 1314789630;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1358231212);
					continue;
				}
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2562779632u));
					num = -360654733;
					continue;
				default:
					LuaScriptMgr.Push(L, _202E_200B_202A_202E_202B_202B_206C_206E_200B_206D_202E_206B_202D_202A_202A_202C_206E_206A_206A_206E_206B_206A_206F_202C_206F_206D_200B_202A_206E_206B_202E_200D_206A_202A_200B_202C_202D_206B_202E_206C_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_shadowCastingMode(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = (Renderer)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1118154575;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6BAAA1F0)) % 7)
				{
				case 5u:
					break;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1775139025u));
					num = 523564211;
					continue;
				case 1u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 1687055079) ^ 0x3336F75F);
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1373915522u));
					num = (int)(num2 * 1762710985) ^ -1493520828;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 534321723;
						num6 = num5;
					}
					else
					{
						num5 = 685841512;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 976711868);
					continue;
				}
				case 3u:
				{
					int num3;
					int num4;
					if (!_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = -1535246130;
						num4 = num3;
					}
					else
					{
						num3 = -1631141495;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 183797699);
					continue;
				}
				default:
					LuaScriptMgr.Push(L, (Enum)(object)_200F_202A_206C_202B_202D_200F_206B_200D_202D_206C_202E_206C_206B_202B_200B_202C_200B_206D_202D_200E_202A_200D_206F_202C_200F_200C_206B_206A_202C_200E_200B_200B_202E_200B_202A_202A_202D_202A_206A_206F_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_receiveShadows(IntPtr L)
	{
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = default(Renderer);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1389460122;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1618523000)) % 8)
				{
				case 0u:
					break;
				case 1u:
					LuaScriptMgr.Push(L, _200E_202C_206B_206D_200B_200E_200D_206D_200B_202A_202C_206E_202B_202B_200D_200D_200F_200F_206B_206D_206A_200C_206E_206E_200F_202D_202C_202A_200B_202E_200B_206D_206F_202D_206E_206A_200C_202E_202D_202C_202E(val));
					num = -394636502;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3716080341u));
					num = ((int)num2 * -1330518638) ^ 0x61678CCB;
					continue;
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1612429828) ^ -571388477;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -1585391180;
						num6 = num5;
					}
					else
					{
						num5 = -214771570;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -678956597);
					continue;
				}
				case 6u:
				{
					val = (Renderer)luaObject;
					int num3;
					int num4;
					if (_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = 864183000;
						num4 = num3;
					}
					else
					{
						num3 = 632189461;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1772284258);
					continue;
				}
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4057391286u));
					num = -1909102863;
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
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = default(Renderer);
		while (true)
		{
			int num = 627373104;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x41E52B3B)) % 9)
				{
				case 6u:
					break;
				case 8u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 1565879081;
						num6 = num5;
					}
					else
					{
						num5 = 443887881;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1301648551);
					continue;
				}
				case 5u:
					LuaScriptMgr.Push(L, (Object)(object)_206F_200E_202B_200F_202A_206B_200C_200F_206E_200E_202A_202E_202A_200B_206E_206C_202B_206C_202E_200E_202A_202C_200F_200D_202A_200B_202A_200D_200E_206F_200C_202C_202C_206A_206E_202C_200F_206C_206D_206E_202E(val));
					num = 374763368;
					continue;
				case 7u:
					val = (Renderer)luaObject;
					num = (int)(num2 * 75004847) ^ -1862029805;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3792488725u));
					num = ((int)num2 * -929279206) ^ 0x3060F129;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = 468581910;
						num4 = num3;
					}
					else
					{
						num3 = 649637121;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -693157030);
					continue;
				}
				case 1u:
					num = (int)(num2 * 266728320) ^ -461326140;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2612757698u));
					num = 991401412;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_sharedMaterial(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = (Renderer)luaObject;
		while (true)
		{
			int num = -956900656;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2133894311)) % 7)
				{
				case 5u:
					break;
				case 2u:
					LuaScriptMgr.Push(L, (Object)(object)_202D_200B_206D_200D_200E_200E_202B_200B_200F_200F_206E_206F_206F_202A_206C_200F_200C_200E_206E_200E_200E_206C_206F_200B_200B_200E_200C_200D_200E_202D_202A_202D_202C_200D_206D_200F_202D_202C_206D_202E_202E(val));
					num = -1595251323;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3142616129u));
					num = (int)((num2 * 527554230) ^ 0x6A8235BC);
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1243994421u));
					num = -1654002592;
					continue;
				case 3u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 431509848;
						num6 = num5;
					}
					else
					{
						num5 = 1783408392;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1993349085);
					continue;
				}
				case 4u:
				{
					int num3;
					int num4;
					if (_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = 524944960;
						num4 = num3;
					}
					else
					{
						num3 = 1688366414;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1116639806);
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
	private static int get_materials(IntPtr L)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = default(Renderer);
		while (true)
		{
			int num = -1847011423;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -577577520)) % 8)
				{
				case 3u:
					break;
				case 2u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 1708725280;
						num6 = num5;
					}
					else
					{
						num5 = 1849922054;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1721514559);
					continue;
				}
				case 4u:
				{
					int num3;
					int num4;
					if (_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = 579927690;
						num4 = num3;
					}
					else
					{
						num3 = 2139586661;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 389736788);
					continue;
				}
				case 1u:
					val = (Renderer)luaObject;
					num = ((int)num2 * -35610473) ^ -1231506653;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(198566389u));
					num = -1354332171;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3912670493u));
					num = ((int)num2 * -340205897) ^ -570090291;
					continue;
				case 7u:
					num = ((int)num2 * -200746083) ^ 0x4C1A29EE;
					continue;
				default:
					LuaScriptMgr.PushArray(L, _200F_200C_200B_202C_206C_206F_206C_200D_200D_200E_202E_200B_200F_202E_202E_206F_200C_202B_200D_200D_206B_200F_202E_200E_206F_200C_202E_202D_206D_202D_200D_200D_202C_202A_202E_200D_202A_200E_202A_202A_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_sharedMaterials(IntPtr L)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = default(Renderer);
		while (true)
		{
			int num = -1368008488;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -998142439)) % 8)
				{
				case 0u:
					break;
				case 3u:
					num = (int)((num2 * 921485019) ^ 0xA9528BD);
					continue;
				case 6u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 10989188;
						num6 = num5;
					}
					else
					{
						num5 = 524677055;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -975051805);
					continue;
				}
				case 1u:
				{
					val = (Renderer)luaObject;
					int num3;
					int num4;
					if (_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = 1973669257;
						num4 = num3;
					}
					else
					{
						num3 = 1965742602;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1877357018);
					continue;
				}
				case 5u:
					LuaScriptMgr.PushArray(L, _206B_200D_206B_200D_206C_202D_200D_202A_206D_200B_200D_206D_200B_200C_200C_200C_206D_202A_206E_202D_206E_206C_200D_200D_200F_200D_202E_202B_202E_200E_206A_200D_202C_202E_202C_206B_206E_200D_202B_200E_202E(val));
					num = -711611709;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1039531381u));
					num = ((int)num2 * -659267953) ^ -2030868373;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3431313213u));
					num = -204999508;
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
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = default(Renderer);
		while (true)
		{
			int num = 1602940177;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1B50F66D)) % 7)
				{
				case 5u:
					break;
				case 0u:
					LuaScriptMgr.Push(L, _206E_200D_200B_200B_202B_206A_200B_202A_202A_202E_200C_200E_202D_206D_200F_206B_200F_202A_206E_206B_206F_202C_206B_206F_200B_202E_202A_200C_206F_206D_206A_206B_200F_206F_200F_206B_200C_206C_206B_206C_202E(val));
					num = 864385903;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2869697905u));
					num = (int)((num2 * 1847300791) ^ 0xEED9A3C);
					continue;
				case 4u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 651114092;
						num6 = num5;
					}
					else
					{
						num5 = 549663590;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -237353301);
					continue;
				}
				case 1u:
				{
					val = (Renderer)luaObject;
					int num3;
					int num4;
					if (_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = -1478091147;
						num4 = num3;
					}
					else
					{
						num3 = -1240178381;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 796624516);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3078170260u));
					num = 360280771;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_lightmapIndex(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = default(Renderer);
		while (true)
		{
			int num = -1502282143;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1059533957)) % 8)
				{
				case 4u:
					break;
				case 2u:
					val = (Renderer)luaObject;
					num = (int)(num2 * 486317291) ^ -1143566469;
					continue;
				case 1u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 819125554;
						num6 = num5;
					}
					else
					{
						num5 = 1336373861;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1992971071);
					continue;
				}
				case 6u:
				{
					int num3;
					int num4;
					if (!_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = 915725464;
						num4 = num3;
					}
					else
					{
						num3 = 1885970308;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -231866507);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2098750966u));
					num = ((int)num2 * -1608964901) ^ 0x62C70688;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3590417469u));
					num = -1011130898;
					continue;
				case 3u:
					num = ((int)num2 * -1007913146) ^ -512672612;
					continue;
				default:
					LuaScriptMgr.Push(L, _202A_206D_202C_202D_206F_202E_206B_202A_200F_206D_202A_206A_206E_202E_202D_206B_206E_200D_200C_202E_206F_200F_200E_200D_202A_200D_202C_206E_206C_206C_202E_202A_200C_200E_206A_202E_202A_206A_202E_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_realtimeLightmapIndex(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = (Renderer)luaObject;
		while (true)
		{
			int num = -1384344299;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -710542651)) % 7)
				{
				case 6u:
					break;
				case 2u:
				{
					int num5;
					int num6;
					if (!_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num5 = -2085189107;
						num6 = num5;
					}
					else
					{
						num5 = -2065640184;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 2051554699);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2296236361u));
					num = ((int)num2 * -763265945) ^ -1479444540;
					continue;
				case 1u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 1799588897;
						num4 = num3;
					}
					else
					{
						num3 = 767950717;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -131412643);
					continue;
				}
				case 0u:
					num = (int)((num2 * 353470683) ^ 0x530D616F);
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1041760975u));
					num = -2088579075;
					continue;
				default:
					LuaScriptMgr.Push(L, _206D_206B_202A_200B_200B_206D_206E_202B_202E_206C_206C_206E_202A_206A_206C_202C_206E_206C_202A_206F_200B_202C_200E_200B_200E_200E_206B_202E_200D_202C_206D_202D_202B_206F_206A_206D_206B_206E_202D_206F_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_lightmapScaleOffset(IntPtr L)
	{
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = default(Renderer);
		while (true)
		{
			int num = 1134998824;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5456EF4F)) % 9)
				{
				case 0u:
					break;
				case 6u:
					val = (Renderer)luaObject;
					num = ((int)num2 * -1243314160) ^ -490139386;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num5 = -2694299;
						num6 = num5;
					}
					else
					{
						num5 = -1464884982;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1132093650);
					continue;
				}
				case 2u:
					num = (int)(num2 * 263046180) ^ -564361772;
					continue;
				case 4u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -1463076348;
						num4 = num3;
					}
					else
					{
						num3 = -413064862;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1889416458);
					continue;
				}
				case 1u:
					LuaScriptMgr.Push(L, _206D_206A_200D_206E_200E_206C_200B_200C_202D_206F_206C_206C_202D_200D_206A_202A_202D_202E_200B_200C_202D_206F_206A_206B_206C_200D_202B_202B_200D_206D_206C_206E_206C_202C_200B_202D_206D_200B_206B_202B_202E(val));
					num = 713027197;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1954202224u));
					num = 393252916;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4210568779u));
					num = ((int)num2 * -1448612822) ^ -588654711;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_realtimeLightmapScaleOffset(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = (Renderer)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -351116624;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -868518061)) % 7)
				{
				case 4u:
					break;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1998955806u));
					num = -1358233425;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 698774696;
						num6 = num5;
					}
					else
					{
						num5 = 1941864691;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 2049040360);
					continue;
				}
				case 3u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 32154603) ^ -1034677880;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = -587098981;
						num4 = num3;
					}
					else
					{
						num3 = -1896452782;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -192171361);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3769579842u));
					num = ((int)num2 * -1616192008) ^ -802755193;
					continue;
				default:
					LuaScriptMgr.Push(L, _206F_200F_206C_202C_200C_202E_202B_200D_206D_202D_202A_200E_200D_200E_200E_202A_202A_202D_206C_202D_200D_206B_200C_202D_200B_202D_202D_202B_202A_206D_206A_202D_206F_202B_202C_206D_206B_206E_202A_202C_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_isVisible(IntPtr L)
	{
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = default(Renderer);
		while (true)
		{
			int num = -460820411;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1187650365)) % 8)
				{
				case 5u:
					break;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(704878828u));
					num = (int)((num2 * 786277868) ^ 0x1DBD84D3);
					continue;
				case 0u:
					num = (int)((num2 * 1670756274) ^ 0x166B510A);
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1163023389u));
					num = -1479626214;
					continue;
				case 4u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 2001807037;
						num6 = num5;
					}
					else
					{
						num5 = 74365132;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -525930331);
					continue;
				}
				case 6u:
				{
					val = (Renderer)luaObject;
					int num3;
					int num4;
					if (_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = 1491568633;
						num4 = num3;
					}
					else
					{
						num3 = 1317711660;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1488863031);
					continue;
				}
				case 1u:
					LuaScriptMgr.Push(L, _202E_200E_206D_206D_202E_202A_200F_206F_206E_202B_206F_200E_200F_200F_206F_206C_206B_200F_206E_202D_202B_200F_206A_202D_206E_200B_206F_206E_202D_202D_200F_202A_202D_202B_202A_200B_206F_200D_202D_200D_202E(val));
					num = -129904068;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_useLightProbes(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = (Renderer)luaObject;
		if (_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
		{
			goto IL_001b;
		}
		goto IL_009b;
		IL_001b:
		int num = 400126059;
		goto IL_0020;
		IL_0020:
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x5C08C9B8)) % 7)
			{
			case 6u:
				break;
			case 2u:
				luaTypes = LuaDLL.lua_type(L, 1);
				num = (int)(num2 * 1630156409) ^ -1007508926;
				continue;
			case 3u:
			{
				int num3;
				int num4;
				if (luaTypes != LuaTypes.LUA_TTABLE)
				{
					num3 = -684924914;
					num4 = num3;
				}
				else
				{
					num3 = -1699290739;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -968409425);
				continue;
			}
			case 1u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3486741177u));
				num = 848262615;
				continue;
			case 4u:
				goto IL_009b;
			case 5u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3976020929u));
				num = (int)(num2 * 1270485487) ^ -434357039;
				continue;
			default:
				return 1;
			}
			break;
		}
		goto IL_001b;
		IL_009b:
		LuaScriptMgr.Push(L, _200E_200D_206E_206E_200F_202B_200D_202A_200C_206C_202B_206C_200F_206D_206E_206E_206C_202B_202B_206C_202B_202A_202D_206F_206C_202D_200B_200F_200B_202D_202E_206D_202C_202D_200D_200F_202B_202D_200F_202D_202E(val));
		num = 1339607737;
		goto IL_0020;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_probeAnchor(IntPtr L)
	{
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = default(Renderer);
		while (true)
		{
			int num = -396178048;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1703133447)) % 6)
				{
				case 5u:
					break;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2890797471u));
					num = -166961774;
					continue;
				case 4u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -891918333;
						num6 = num5;
					}
					else
					{
						num5 = -750830683;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1993266324);
					continue;
				}
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1081983811u));
					num = (int)((num2 * 1906947486) ^ 0x2A3D527A);
					continue;
				case 1u:
				{
					val = (Renderer)luaObject;
					int num3;
					int num4;
					if (!_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = -679671615;
						num4 = num3;
					}
					else
					{
						num3 = -2135636994;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -307892181);
					continue;
				}
				default:
					LuaScriptMgr.Push(L, (Object)(object)_202E_202C_200F_206A_200D_206D_206D_206F_206F_206A_202D_200F_200C_202C_202E_200F_206C_200F_202A_202B_206A_206A_206E_202D_202A_200F_206D_206C_200F_202E_200C_206B_202D_200B_200B_202A_202D_202C_202E_206A_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_reflectionProbeUsage(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = (Renderer)luaObject;
		while (true)
		{
			int num = 97677152;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3F244EF8)) % 7)
				{
				case 5u:
					break;
				case 1u:
				{
					int num5;
					int num6;
					if (_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num5 = 854422568;
						num6 = num5;
					}
					else
					{
						num5 = 1858670175;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1329487066);
					continue;
				}
				case 2u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -1278547248;
						num4 = num3;
					}
					else
					{
						num3 = -1876384608;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1769211755);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3690629731u));
					num = 625855183;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2132263152u));
					num = ((int)num2 * -2115203774) ^ 0x4462891F;
					continue;
				case 0u:
					LuaScriptMgr.Push(L, (Enum)(object)_200D_202D_206B_206A_202B_202E_200E_206E_200E_202C_202D_206F_200B_202E_206F_200B_206C_202E_206D_200D_200E_200F_202E_200D_200B_200B_200E_200E_200F_202C_200E_202C_200B_202C_202B_206D_206A_206E_200C_202D_202E(val));
					num = 1788696063;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_sortingLayerName(IntPtr L)
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = default(Renderer);
		while (true)
		{
			int num = -310910605;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -635872600)) % 8)
				{
				case 5u:
					break;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1523807792u));
					num = -1536016094;
					continue;
				case 2u:
					LuaScriptMgr.Push(L, _202E_206A_200C_200C_206F_206B_200E_202A_200F_202C_206C_206F_200B_202B_206B_200C_200D_206A_206B_202E_202B_202D_200E_206E_202C_200B_206C_206E_202B_200E_206B_206B_200E_202E_206E_206A_202D_200F_202E_202C_202E(val));
					num = -262500831;
					continue;
				case 7u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 1159506275;
						num6 = num5;
					}
					else
					{
						num5 = 1052186321;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1748568981);
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = 1695015639;
						num4 = num3;
					}
					else
					{
						num3 = 430105778;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -513375391);
					continue;
				}
				case 3u:
					val = (Renderer)luaObject;
					num = (int)(num2 * 1178336417) ^ -504365693;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1825097828u));
					num = ((int)num2 * -836270828) ^ 0x24650112;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_sortingLayerID(IntPtr L)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		Renderer val = default(Renderer);
		while (true)
		{
			int num = 885346428;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x72EE338C)) % 7)
				{
				case 6u:
					break;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2240188251u));
					num = 2024241372;
					continue;
				case 5u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 52975366) ^ -2025429503;
					continue;
				case 1u:
				{
					val = (Renderer)luaObject;
					int num5;
					int num6;
					if (!_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num5 = -1283562836;
						num6 = num5;
					}
					else
					{
						num5 = -1868101689;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 808704665);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3347114356u));
					num = ((int)num2 * -607655657) ^ 0x221C3662;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 1621547750;
						num4 = num3;
					}
					else
					{
						num3 = 846149990;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 570583272);
					continue;
				}
				default:
					LuaScriptMgr.Push(L, _206A_206E_206A_206B_200F_202D_200C_200B_202C_202D_202E_200B_200E_206D_200D_200F_206D_200D_206B_206D_200B_206C_206F_202E_202E_206F_206B_200C_202B_206D_202A_200E_206D_206C_202C_200F_206B_200C_202D_206D_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_sortingOrder(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = (Renderer)luaObject;
		while (true)
		{
			int num = 1338674463;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4641A23F)) % 7)
				{
				case 6u:
					break;
				case 5u:
					LuaScriptMgr.Push(L, _202D_206F_206E_202D_200B_202B_202C_206A_202C_202A_200D_200D_206D_206C_200F_200F_202B_206D_206C_200F_206F_202B_202B_202C_206D_200D_200B_206E_206F_206A_200D_206C_202E_200B_202B_206E_206A_200E_202E_200D_202E(val));
					num = 835623637;
					continue;
				case 0u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -1098022552;
						num6 = num5;
					}
					else
					{
						num5 = -22559321;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1526148587);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3968461873u));
					num = 853554979;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1565283412u));
					num = (int)(num2 * 1194157660) ^ -1492411365;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = 1121218270;
						num4 = num3;
					}
					else
					{
						num3 = 341324899;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1407538282);
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
	private static int set_enabled(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = default(Renderer);
		while (true)
		{
			int num = 1473346545;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3D389DAF)) % 7)
				{
				case 3u:
					break;
				case 4u:
				{
					val = (Renderer)luaObject;
					int num5;
					int num6;
					if (_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num5 = 754987647;
						num6 = num5;
					}
					else
					{
						num5 = 1526487950;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1974269826);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1416424057u));
					num = (int)(num2 * 1018037780) ^ -840245058;
					continue;
				case 5u:
					_206A_206A_206C_200C_200F_202D_202E_202C_206B_206D_202D_206B_206E_202A_200F_206D_206C_202A_202B_206A_202B_202A_200F_202D_206E_206B_206A_206D_200C_200F_206E_200B_202E_200C_206C_206B_206F_206E_206B_206C_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					num = 556916103;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2479177141u));
					num = 271583690;
					continue;
				case 2u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -792821306;
						num4 = num3;
					}
					else
					{
						num3 = -1271292034;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -339087678);
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
	private static int set_shadowCastingMode(IntPtr L)
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		Renderer val = default(Renderer);
		while (true)
		{
			int num = 1914415579;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x233852F7)) % 9)
				{
				case 8u:
					break;
				case 1u:
					num = (int)((num2 * 1260634832) ^ 0x556EBDF9);
					continue;
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 2009478277) ^ 0x527E58DA);
					continue;
				case 6u:
				{
					val = (Renderer)luaObject;
					int num5;
					int num6;
					if (_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num5 = 238855171;
						num6 = num5;
					}
					else
					{
						num5 = 544590377;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 993969792);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1373915522u));
					num = ((int)num2 * -2033795173) ^ 0xBC5F004;
					continue;
				case 2u:
					_202E_200C_200F_202C_200C_202D_200D_200E_200C_206F_206C_202D_200E_206E_202B_202A_200C_202E_206D_206F_202D_202A_202B_202E_202C_202E_202D_200D_206B_202D_202C_200C_206B_206E_202E_206E_202B_206D_202C_206D_202E(val, (ShadowCastingMode)(int)LuaScriptMgr.GetNetObject(L, 3, _200F_202C_202C_206A_200B_202D_206F_202E_200D_206C_206E_206C_200E_200E_202C_202C_206B_202C_202C_200C_206C_200E_200D_206B_202E_202C_202A_202D_202E_206B_200C_200E_200E_202A_202E_202E_200C_206E_202E_206F_202E(typeof(ShadowCastingMode).TypeHandle)));
					num = 173452759;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 1562465623;
						num4 = num3;
					}
					else
					{
						num3 = 754913948;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 238773893);
					continue;
				}
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3204690715u));
					num = 2124174377;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_receiveShadows(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = (Renderer)luaObject;
		if (_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
		{
			while (true)
			{
				int num = 2081733478;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x391EA137)) % 6)
					{
					case 2u:
						break;
					case 1u:
						num = ((int)num2 * -1926721037) ^ 0x1FF45F68;
						continue;
					case 5u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1387081215u));
						num = (int)((num2 * 1404747398) ^ 0x77DA7068);
						continue;
					case 4u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4057391286u));
						num = 607665851;
						continue;
					case 3u:
					{
						LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
						int num3;
						int num4;
						if (luaTypes != LuaTypes.LUA_TTABLE)
						{
							num3 = -1335333274;
							num4 = num3;
						}
						else
						{
							num3 = -1506524779;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 1252032775);
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
		_206E_202A_200F_200B_200F_206A_202C_200D_206A_202E_202B_202A_200D_200E_202D_202B_202B_200E_200C_202E_202E_202C_200B_206D_200F_202E_206C_202B_202B_206F_202E_206C_206C_202C_206F_200F_206A_206A_206A_202E(val, LuaScriptMgr.GetBoolean(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_material(IntPtr L)
	{
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		Renderer val = default(Renderer);
		while (true)
		{
			int num = 1025786193;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x32211F68)) % 9)
				{
				case 7u:
					break;
				case 2u:
					num = (int)(num2 * 81012388) ^ -1966398782;
					continue;
				case 0u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 1851217697) ^ -312019851;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3219064152u));
					num = 758822062;
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num5 = 1367032196;
						num6 = num5;
					}
					else
					{
						num5 = 364538949;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1660129137);
					continue;
				}
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(465708538u));
					num = ((int)num2 * -551817650) ^ 0x4DA7AEE3;
					continue;
				case 6u:
					val = (Renderer)luaObject;
					num = (int)(num2 * 1070256537) ^ -1313537636;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -400363931;
						num4 = num3;
					}
					else
					{
						num3 = -591273670;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1332930235);
					continue;
				}
				default:
					_206A_206B_200B_200B_200D_202C_202D_206A_206F_206E_206F_206E_206E_202D_206E_202A_206B_206E_200B_206C_202A_206C_200B_200D_206F_206A_202C_206D_206B_202B_200D_200B_200D_206C_202A_206A_202B_206C_200C_202E_202E(val, (Material)LuaScriptMgr.GetUnityObject(L, 3, _200F_202C_202C_206A_200B_202D_206F_202E_200D_206C_206E_206C_200E_200E_202C_202C_206B_202C_202C_200C_206C_200E_200D_206B_202E_202C_202A_202D_202E_206B_200C_200E_200E_202A_202E_202E_200C_206E_202E_206F_202E(typeof(Material).TypeHandle)));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_sharedMaterial(IntPtr L)
	{
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = default(Renderer);
		while (true)
		{
			int num = 2003403554;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x268346C5)) % 8)
				{
				case 5u:
					break;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1319465407u));
					num = (int)((num2 * 2005308032) ^ 0x3B6679F6);
					continue;
				case 1u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 1283365660;
						num6 = num5;
					}
					else
					{
						num5 = 330091112;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -987424031);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(304496065u));
					num = 465553063;
					continue;
				case 3u:
					num = ((int)num2 * -1526993503) ^ 0x21C392B4;
					continue;
				case 7u:
				{
					val = (Renderer)luaObject;
					int num3;
					int num4;
					if (!_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = -1449407361;
						num4 = num3;
					}
					else
					{
						num3 = -1516249116;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -404712600);
					continue;
				}
				case 2u:
					_200D_202C_206C_206A_206F_202A_200E_202D_202D_206A_202D_202B_202B_200D_200E_202E_202C_200F_200C_202E_200F_200B_200B_206A_206E_206F_200F_202C_202C_200D_206A_202A_202A_202D_200B_200C_200D_202B_206A_200D_202E(val, (Material)LuaScriptMgr.GetUnityObject(L, 3, _200F_202C_202C_206A_200B_202D_206F_202E_200D_206C_206E_206C_200E_200E_202C_202C_206B_202C_202C_200C_206C_200E_200D_206B_202E_202C_202A_202D_202E_206B_200C_200E_200E_202A_202E_202E_200C_206E_202E_206F_202E(typeof(Material).TypeHandle)));
					num = 305188555;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_materials(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = (Renderer)luaObject;
		while (true)
		{
			int num = -101438497;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1182587654)) % 8)
				{
				case 0u:
					break;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3912670493u));
					num = (int)(num2 * 1993311215) ^ -1459589699;
					continue;
				case 1u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -1151910186;
						num6 = num5;
					}
					else
					{
						num5 = -1421772710;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1361757743);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(888589409u));
					num = -251288290;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = -1940264322;
						num4 = num3;
					}
					else
					{
						num3 = -405727221;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1838752736);
					continue;
				}
				case 4u:
					_200D_202B_202D_200E_206E_202A_200E_202E_206D_200E_206F_206C_200E_206D_200B_202A_206B_206F_206D_200F_206D_202B_200B_202C_206D_202E_202B_200B_202D_200C_206B_206F_206C_202D_206A_206A_206D_202E_200D_200F_202E(val, LuaScriptMgr.GetArrayObject<Material>(L, 3));
					num = -1995413408;
					continue;
				case 6u:
					num = (int)((num2 * 515321593) ^ 0x203199F8);
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_sharedMaterials(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = (Renderer)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -884592560;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -305887538)) % 9)
				{
				case 3u:
					break;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2617986794u));
					num = -1811639095;
					continue;
				case 1u:
					num = ((int)num2 * -839152750) ^ 0x68E387EB;
					continue;
				case 5u:
					_202A_200F_200B_202E_202B_202A_202A_200C_206D_202A_206C_206A_202E_202A_206C_206F_200B_206B_202A_200F_206B_206A_200D_200C_200B_202D_206C_206D_202E_200D_200D_206B_202E_200B_202C_206D_200E_202A_206F_202B_202E(val, LuaScriptMgr.GetArrayObject<Material>(L, 3));
					num = -779595659;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 650040117;
						num6 = num5;
					}
					else
					{
						num5 = 1731238797;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1077684242);
					continue;
				}
				case 0u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -511585046) ^ -1820218493;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(921411843u));
					num = (int)(num2 * 707573790) ^ -2116940103;
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = 1501162783;
						num4 = num3;
					}
					else
					{
						num3 = 409539165;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1809592938);
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
	private static int set_lightmapIndex(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = (Renderer)luaObject;
		while (true)
		{
			int num = 2011774879;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x425E30F1)) % 8)
				{
				case 0u:
					break;
				case 4u:
					num = ((int)num2 * -1851511670) ^ -1185637741;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3420079011u));
					num = 632934171;
					continue;
				case 7u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -892409510;
						num6 = num5;
					}
					else
					{
						num5 = -2100160528;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 613410702);
					continue;
				}
				case 2u:
					_202D_200E_202B_202C_206F_202A_200F_206D_200F_200F_206E_200D_206A_200D_206B_206C_206D_206F_200F_202E_200F_206B_206C_200B_206F_206B_202B_206B_206E_202A_206D_206A_200C_206F_200D_206D_206B_200B_202B_206B_202E(val, (int)LuaScriptMgr.GetNumber(L, 3));
					num = 740274100;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3331877495u));
					num = (int)((num2 * 317405858) ^ 0x201D6683);
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = 400257916;
						num4 = num3;
					}
					else
					{
						num3 = 1352721497;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1200562841);
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
	private static int set_realtimeLightmapIndex(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = (Renderer)luaObject;
		if (_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
		{
			goto IL_0018;
		}
		goto IL_0051;
		IL_0018:
		int num = -1733047761;
		goto IL_001d;
		IL_001d:
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -13966856)) % 8)
			{
			case 2u:
				break;
			case 4u:
				goto IL_0051;
			case 0u:
			{
				int num3;
				int num4;
				if (luaTypes == LuaTypes.LUA_TTABLE)
				{
					num3 = 304835701;
					num4 = num3;
				}
				else
				{
					num3 = 946358523;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 1288243564);
				continue;
			}
			case 1u:
				num = (int)((num2 * 1160589409) ^ 0x38FF7D6D);
				continue;
			case 7u:
				luaTypes = LuaDLL.lua_type(L, 1);
				num = (int)(num2 * 480785628) ^ -361239228;
				continue;
			case 5u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2693014167u));
				num = ((int)num2 * -802042548) ^ -1086697107;
				continue;
			case 3u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2077660666u));
				num = -1760203964;
				continue;
			default:
				return 0;
			}
			break;
		}
		goto IL_0018;
		IL_0051:
		_200F_206E_202A_200C_206C_206C_200E_206F_202A_200E_206A_206A_202E_200C_206B_206D_200F_202E_206E_202C_202C_206F_206C_200F_206A_202B_200B_200B_202A_206B_202A_200B_200D_202C_202B_202E_206D_206B_206C_202C_202E(val, (int)LuaScriptMgr.GetNumber(L, 3));
		num = -540205778;
		goto IL_001d;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_lightmapScaleOffset(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = (Renderer)luaObject;
		if (_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
		{
			LuaTypes luaTypes = default(LuaTypes);
			while (true)
			{
				int num = 110958471;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x76263B41)) % 6)
					{
					case 5u:
						break;
					case 1u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3628798608u));
						num = (int)((num2 * 604696713) ^ 0x766AE5AA);
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (luaTypes != LuaTypes.LUA_TTABLE)
						{
							num3 = 166772594;
							num4 = num3;
						}
						else
						{
							num3 = 589642606;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 849972920);
						continue;
					}
					case 3u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2085278037u));
						num = 1139465341;
						continue;
					case 4u:
						luaTypes = LuaDLL.lua_type(L, 1);
						num = ((int)num2 * -1750978801) ^ 0x7DD02F19;
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
		_206B_202E_206D_202E_200F_200D_202B_206F_200C_206D_206A_206B_200E_206E_202C_200B_202D_202D_206C_202C_200B_202B_206B_206E_202E_206E_202E_200F_206D_206A_202C_206E_206C_200F_206D_200C_206E_200E_200C_202E_202E(val, LuaScriptMgr.GetVector4(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_realtimeLightmapScaleOffset(IntPtr L)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = default(Renderer);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -592691425;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -398376330)) % 9)
				{
				case 4u:
					break;
				case 2u:
					_202C_206F_206A_206E_206C_200E_200C_200F_206F_202D_206C_206C_202D_206B_202A_206B_200E_200B_202A_200B_206A_200B_206C_200F_206C_200C_200D_206E_202E_206C_202C_202E_202E_202C_200E_206A_202B_200B_200D_206A_202E(val, LuaScriptMgr.GetVector4(L, 3));
					num = -1802694080;
					continue;
				case 1u:
					num = (int)((num2 * 884637423) ^ 0x7C110934);
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(483784515u));
					num = ((int)num2 * -248570647) ^ 0x3DD48897;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3825711263u));
					num = -2073403000;
					continue;
				case 8u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 465632406) ^ -859161207;
					continue;
				case 3u:
				{
					val = (Renderer)luaObject;
					int num5;
					int num6;
					if (_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num5 = 437616053;
						num6 = num5;
					}
					else
					{
						num5 = 1062261573;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 771525061);
					continue;
				}
				case 5u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 2920168;
						num4 = num3;
					}
					else
					{
						num3 = 729703432;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1347736745);
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
	private static int set_useLightProbes(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = (Renderer)luaObject;
		while (true)
		{
			int num = -789446729;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1006421341)) % 8)
				{
				case 5u:
					break;
				case 2u:
					_206E_200F_206C_200D_200D_202C_202D_200B_206B_206E_206F_200C_200B_206D_200F_206E_200B_206A_200B_206E_200B_200D_202E_202A_206F_202E_200C_200F_206F_202B_206B_202A_206E_206E_202C_202E_206E_202D_206E_206D_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					num = -286974011;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2788237119u));
					num = ((int)num2 * -607227609) ^ -1049927049;
					continue;
				case 7u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -773520434;
						num6 = num5;
					}
					else
					{
						num5 = -588099881;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 2054799932);
					continue;
				}
				case 3u:
					num = ((int)num2 * -760588763) ^ 0x7A40FFDE;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = 1501704937;
						num4 = num3;
					}
					else
					{
						num3 = 12418020;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -749386184);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1290417654u));
					num = -1155488119;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_probeAnchor(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = (Renderer)luaObject;
		if (_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
		{
			goto IL_0018;
		}
		goto IL_0064;
		IL_0018:
		int num = 728412610;
		goto IL_001d;
		IL_001d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x4EFD6540)) % 7)
			{
			case 0u:
				break;
			case 4u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2890797471u));
				num = 719010480;
				continue;
			case 5u:
				goto IL_0064;
			case 2u:
			{
				LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
				int num3;
				int num4;
				if (luaTypes == LuaTypes.LUA_TTABLE)
				{
					num3 = 1910978102;
					num4 = num3;
				}
				else
				{
					num3 = 403722269;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 1850061918);
				continue;
			}
			case 6u:
				num = (int)(num2 * 871222427) ^ -1384531124;
				continue;
			case 3u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1014954290u));
				num = ((int)num2 * -1380791593) ^ 0x58AFAB52;
				continue;
			default:
				return 0;
			}
			break;
		}
		goto IL_0018;
		IL_0064:
		_200D_206E_206F_202A_202B_200D_200D_206E_200E_206F_202C_202A_202E_202A_206D_206C_206A_206C_206D_206C_200B_202B_200D_202C_206E_202C_206A_206A_202C_200C_206D_200F_206C_202E_200D_200C_206E_200E_206D_206B_202E(val, (Transform)LuaScriptMgr.GetUnityObject(L, 3, _200F_202C_202C_206A_200B_202D_206F_202E_200D_206C_206E_206C_200E_200E_202C_202C_206B_202C_202C_200C_206C_200E_200D_206B_202E_202C_202A_202D_202E_206B_200C_200E_200E_202A_202E_202E_200C_206E_202E_206F_202E(typeof(Transform).TypeHandle)));
		num = 965301614;
		goto IL_001d;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_reflectionProbeUsage(IntPtr L)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = default(Renderer);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1554714191;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1A29B67A)) % 9)
				{
				case 6u:
					break;
				case 1u:
					_200D_206F_202A_200D_206B_200B_200B_200C_202E_200C_206D_206B_202A_206D_206D_202B_202D_202D_206C_200C_206D_206F_202E_206F_206C_200C_200E_206F_200B_202A_202C_202C_202E_206C_202D_200E_206A_202D_206C_202B_202E(val, (ReflectionProbeUsage)(int)LuaScriptMgr.GetNetObject(L, 3, _200F_202C_202C_206A_200B_202D_206F_202E_200D_206C_206E_206C_200E_200E_202C_202C_206B_202C_202C_200C_206C_200E_200D_206B_202E_202C_202A_202D_202E_206B_200C_200E_200E_202A_202E_202E_200C_206E_202E_206F_202E(typeof(ReflectionProbeUsage).TypeHandle)));
					num = 1389335206;
					continue;
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2741035189u));
					num = (int)(num2 * 699805942) ^ -972834785;
					continue;
				case 5u:
				{
					val = (Renderer)luaObject;
					int num5;
					int num6;
					if (_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num5 = -1165945623;
						num6 = num5;
					}
					else
					{
						num5 = -1531796325;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 846397624);
					continue;
				}
				case 4u:
					num = (int)(num2 * 1004282159) ^ -1964415354;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4068136594u));
					num = 1668399747;
					continue;
				case 2u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1150702278) ^ 0x6CA8560;
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 806489281;
						num4 = num3;
					}
					else
					{
						num3 = 1646333459;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 67726847);
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
	private static int set_sortingLayerName(IntPtr L)
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		Renderer val = default(Renderer);
		while (true)
		{
			int num = 272267443;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6A97AC44)) % 10)
				{
				case 2u:
					break;
				case 6u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -1107227887;
						num6 = num5;
					}
					else
					{
						num5 = -1963476281;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 690303952);
					continue;
				}
				case 8u:
				{
					int num3;
					int num4;
					if (!_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num3 = 1422975255;
						num4 = num3;
					}
					else
					{
						num3 = 503232508;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1269504782);
					continue;
				}
				case 9u:
					val = (Renderer)luaObject;
					num = (int)(num2 * 1853223833) ^ -1154374007;
					continue;
				case 1u:
					num = (int)((num2 * 1871938672) ^ 0x27B9479B);
					continue;
				case 5u:
					_206E_200E_206D_206D_206F_206A_200F_200B_202C_202A_202C_200E_200F_200C_206B_200B_200B_200C_206E_202A_200E_202D_206C_200B_206C_202E_202A_202E_202D_206E_202B_202A_202D_206C_206B_206D_200C_200C_200E_202C_202E(val, LuaScriptMgr.GetString(L, 3));
					num = 628435246;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(809296341u));
					num = 1274314603;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1825097828u));
					num = (int)((num2 * 1513461847) ^ 0xA29BFD8);
					continue;
				case 0u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1817315050) ^ 0x19E7B3CE;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_sortingLayerID(IntPtr L)
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = default(Renderer);
		while (true)
		{
			int num = -1715298437;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1679084329)) % 8)
				{
				case 0u:
					break;
				case 6u:
					num = ((int)num2 * -1611254640) ^ -988833380;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3347114356u));
					num = ((int)num2 * -1228543581) ^ -1877206762;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1411513743u));
					num = -1606827908;
					continue;
				case 4u:
				{
					val = (Renderer)luaObject;
					int num5;
					int num6;
					if (!_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num5 = 12157368;
						num6 = num5;
					}
					else
					{
						num5 = 1372876281;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -860609773);
					continue;
				}
				case 2u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 922630540;
						num4 = num3;
					}
					else
					{
						num3 = 1175557166;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 677178726);
					continue;
				}
				case 3u:
					_202D_206F_202B_200B_202A_200F_206C_202D_206B_200C_200B_200E_202D_206C_200E_202B_200E_206B_202C_206A_206B_200F_202A_202B_200E_206A_200B_202B_202A_202C_206E_206D_206D_202A_200D_200F_202D_206F_202E_206E_202E(val, (int)LuaScriptMgr.GetNumber(L, 3));
					num = -1027547226;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_sortingOrder(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Renderer val = default(Renderer);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -337047768;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2142373509)) % 8)
				{
				case 0u:
					break;
				case 3u:
				{
					val = (Renderer)luaObject;
					int num5;
					int num6;
					if (_206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E((Object)(object)val, (Object)null))
					{
						num5 = -352570221;
						num6 = num5;
					}
					else
					{
						num5 = -760000412;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 324159262);
					continue;
				}
				case 4u:
					num = ((int)num2 * -1558655128) ^ 0x594BC1BE;
					continue;
				case 2u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1552469084) ^ 0x3B9F9E02;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 1414803042;
						num4 = num3;
					}
					else
					{
						num3 = 1706148043;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -24227105);
					continue;
				}
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(946902279u));
					num = ((int)num2 * -1968464853) ^ 0x744B6F12;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2315659237u));
					num = -1081560354;
					continue;
				default:
					_200B_202B_206D_206A_202C_202B_206F_200D_206F_206B_202E_202A_202B_202E_200E_202E_200C_200E_200C_200C_200D_206D_200E_206D_200C_200B_206E_206C_200F_206F_200B_206A_206B_206E_200D_200F_206C_202E_206A_202A_202E(val, (int)LuaScriptMgr.GetNumber(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SetPropertyBlock(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		Renderer val = (Renderer)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2945682621u));
		while (true)
		{
			int num = -852369064;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -442586112)) % 3)
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
				MaterialPropertyBlock val2 = (MaterialPropertyBlock)LuaScriptMgr.GetNetObject(L, 2, _200F_202C_202C_206A_200B_202D_206F_202E_200D_206C_206E_206C_200E_200E_202C_202C_206B_202C_202C_200C_206C_200E_200D_206B_202E_202C_202A_202D_202E_206B_200C_200E_200E_202A_202E_202E_200C_206E_202E_206F_202E(typeof(MaterialPropertyBlock).TypeHandle));
				_206F_206C_206B_202A_200B_200E_206C_200E_202B_202D_200F_200B_200D_200E_200D_206D_202E_200B_206C_202A_200B_200C_202B_202A_206B_200B_206A_200D_200B_202B_206C_202C_206F_200D_202C_200D_206C_200F_202E_202B_202E(val, val2);
				num = (int)(num2 * 1293882303) ^ -420101207;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetPropertyBlock(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		Renderer val = (Renderer)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(96781239u));
		MaterialPropertyBlock val2 = (MaterialPropertyBlock)LuaScriptMgr.GetNetObject(L, 2, _200F_202C_202C_206A_200B_202D_206F_202E_200D_206C_206E_206C_200E_200E_202C_202C_206B_202C_202C_200C_206C_200E_200D_206B_202E_202C_202A_202D_202E_206B_200C_200E_200E_202A_202E_202E_200C_206E_202E_206F_202E(typeof(MaterialPropertyBlock).TypeHandle));
		while (true)
		{
			int num = 1864217606;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x37229BB4)) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_0057;
				default:
					return 0;
				}
				break;
				IL_0057:
				_206A_202D_202B_202B_206F_200B_206C_206D_202A_200D_200F_200B_200D_200C_200D_206D_202E_206C_206E_206C_202B_206A_206C_200B_200D_200F_200C_200D_206B_200D_202E_202C_206C_206C_200C_206A_200C_200E_202D_206D_202E(val, val2);
				num = (int)(num2 * 1196931048) ^ -937930235;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetClosestReflectionProbes(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		Renderer val = default(Renderer);
		while (true)
		{
			int num = -869832185;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -379395379)) % 4)
				{
				case 3u:
					break;
				case 2u:
					val = (Renderer)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1158797172u));
					num = (int)((num2 * 483467196) ^ 0x689C954);
					continue;
				case 1u:
				{
					List<ReflectionProbeBlendInfo> list = (List<ReflectionProbeBlendInfo>)LuaScriptMgr.GetNetObject(L, 2, _200F_202C_202C_206A_200B_202D_206F_202E_200D_206C_206E_206C_200E_200E_202C_202C_206B_202C_202C_200C_206C_200E_200D_206B_202E_202C_202A_202D_202E_206B_200C_200E_200E_202A_202E_202E_200C_206E_202E_206F_202E(typeof(List<ReflectionProbeBlendInfo>).TypeHandle));
					_200F_202B_200B_200F_206C_200D_202B_200B_200C_200F_200E_202D_202C_200E_202A_206F_202E_206D_206F_206B_200C_202A_202A_200C_202D_206A_200B_200D_206E_206F_200F_202B_206F_200F_206C_200B_202E_202E_206A_202E_202E(val, list);
					num = ((int)num2 * -721900212) ^ -1454893211;
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
	private static int Lua_Eq(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Object val = (Object)((luaObject is Object) ? luaObject : null);
		object luaObject2 = LuaScriptMgr.GetLuaObject(L, 2);
		Object val2 = (Object)((luaObject2 is Object) ? luaObject2 : null);
		bool b = _206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E(val, val2);
		while (true)
		{
			int num = 1180099856;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x613F1AE4)) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_004b;
				default:
					return 1;
				}
				break;
				IL_004b:
				LuaScriptMgr.Push(L, b);
				num = (int)(num2 * 171882665) ^ -791063548;
			}
		}
	}

	static Type _200F_202C_202C_206A_200B_202D_206F_202E_200D_206C_206E_206C_200E_200E_202C_202C_206B_202C_202C_200C_206C_200E_200D_206B_202E_202C_202A_202D_202E_206B_200C_200E_200E_202A_202E_202E_200C_206E_202E_206F_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static Renderer _202B_200B_202B_202E_206A_202B_200E_202E_206A_206D_206F_200D_206B_202A_200F_200E_200C_206E_206F_206B_200B_206B_206B_206F_202E_200C_202D_206C_200F_202C_200D_202C_202C_202A_206B_200B_206B_202E_202C_202D_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Renderer();
	}

	static bool _206E_200C_202E_202A_202B_206A_206C_200E_200C_200B_200C_206D_206D_202E_206C_200F_202B_206E_200C_202E_200F_200C_200C_200C_202C_206C_206B_200D_202E_200E_206D_206D_202A_206C_202A_206D_200D_202A_206B_202C_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static bool _206B_206D_206B_206A_206E_206A_206B_206C_200D_200C_202C_200B_206C_202C_206F_206E_200F_202A_202C_206E_206C_200F_206C_202B_200B_202B_200F_200D_206B_206B_200C_200B_206F_202E_200B_206F_206C_200B_202B_206D_202E(Renderer P_0)
	{
		return P_0.isPartOfStaticBatch;
	}

	static Matrix4x4 _200D_202D_202E_202A_202E_200B_206D_206C_206A_206D_206C_200C_206A_200F_202A_206A_206D_202D_202E_202A_200C_206C_206B_200F_200B_202A_206A_206F_206A_206B_202B_202A_206A_206C_202D_202D_202A_202E_206F_206A_202E(Renderer P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.worldToLocalMatrix;
	}

	static Matrix4x4 _200F_206A_200F_200C_200F_206E_202C_206C_200B_202A_206D_206F_200D_202B_206F_206B_206C_202B_206E_202A_206E_206A_200E_200D_202B_200D_200C_200E_200D_202C_202B_206F_202C_202D_206C_206B_206E_206D_200B_206C_202E(Renderer P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.localToWorldMatrix;
	}

	static bool _202E_200B_202A_202E_202B_202B_206C_206E_200B_206D_202E_206B_202D_202A_202A_202C_206E_206A_206A_206E_206B_206A_206F_202C_206F_206D_200B_202A_206E_206B_202E_200D_206A_202A_200B_202C_202D_206B_202E_206C_202E(Renderer P_0)
	{
		return P_0.enabled;
	}

	static ShadowCastingMode _200F_202A_206C_202B_202D_200F_206B_200D_202D_206C_202E_206C_206B_202B_200B_202C_200B_206D_202D_200E_202A_200D_206F_202C_200F_200C_206B_206A_202C_200E_200B_200B_202E_200B_202A_202A_202D_202A_206A_206F_202E(Renderer P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.shadowCastingMode;
	}

	static bool _200E_202C_206B_206D_200B_200E_200D_206D_200B_202A_202C_206E_202B_202B_200D_200D_200F_200F_206B_206D_206A_200C_206E_206E_200F_202D_202C_202A_200B_202E_200B_206D_206F_202D_206E_206A_200C_202E_202D_202C_202E(Renderer P_0)
	{
		return P_0.receiveShadows;
	}

	static Material _206F_200E_202B_200F_202A_206B_200C_200F_206E_200E_202A_202E_202A_200B_206E_206C_202B_206C_202E_200E_202A_202C_200F_200D_202A_200B_202A_200D_200E_206F_200C_202C_202C_206A_206E_202C_200F_206C_206D_206E_202E(Renderer P_0)
	{
		return P_0.material;
	}

	static Material _202D_200B_206D_200D_200E_200E_202B_200B_200F_200F_206E_206F_206F_202A_206C_200F_200C_200E_206E_200E_200E_206C_206F_200B_200B_200E_200C_200D_200E_202D_202A_202D_202C_200D_206D_200F_202D_202C_206D_202E_202E(Renderer P_0)
	{
		return P_0.sharedMaterial;
	}

	static Material[] _200F_200C_200B_202C_206C_206F_206C_200D_200D_200E_202E_200B_200F_202E_202E_206F_200C_202B_200D_200D_206B_200F_202E_200E_206F_200C_202E_202D_206D_202D_200D_200D_202C_202A_202E_200D_202A_200E_202A_202A_202E(Renderer P_0)
	{
		return P_0.materials;
	}

	static Material[] _206B_200D_206B_200D_206C_202D_200D_202A_206D_200B_200D_206D_200B_200C_200C_200C_206D_202A_206E_202D_206E_206C_200D_200D_200F_200D_202E_202B_202E_200E_206A_200D_202C_202E_202C_206B_206E_200D_202B_200E_202E(Renderer P_0)
	{
		return P_0.sharedMaterials;
	}

	static Bounds _206E_200D_200B_200B_202B_206A_200B_202A_202A_202E_200C_200E_202D_206D_200F_206B_200F_202A_206E_206B_206F_202C_206B_206F_200B_202E_202A_200C_206F_206D_206A_206B_200F_206F_200F_206B_200C_206C_206B_206C_202E(Renderer P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.bounds;
	}

	static int _202A_206D_202C_202D_206F_202E_206B_202A_200F_206D_202A_206A_206E_202E_202D_206B_206E_200D_200C_202E_206F_200F_200E_200D_202A_200D_202C_206E_206C_206C_202E_202A_200C_200E_206A_202E_202A_206A_202E_202E(Renderer P_0)
	{
		return P_0.lightmapIndex;
	}

	static int _206D_206B_202A_200B_200B_206D_206E_202B_202E_206C_206C_206E_202A_206A_206C_202C_206E_206C_202A_206F_200B_202C_200E_200B_200E_200E_206B_202E_200D_202C_206D_202D_202B_206F_206A_206D_206B_206E_202D_206F_202E(Renderer P_0)
	{
		return P_0.realtimeLightmapIndex;
	}

	static Vector4 _206D_206A_200D_206E_200E_206C_200B_200C_202D_206F_206C_206C_202D_200D_206A_202A_202D_202E_200B_200C_202D_206F_206A_206B_206C_200D_202B_202B_200D_206D_206C_206E_206C_202C_200B_202D_206D_200B_206B_202B_202E(Renderer P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.lightmapScaleOffset;
	}

	static Vector4 _206F_200F_206C_202C_200C_202E_202B_200D_206D_202D_202A_200E_200D_200E_200E_202A_202A_202D_206C_202D_200D_206B_200C_202D_200B_202D_202D_202B_202A_206D_206A_202D_206F_202B_202C_206D_206B_206E_202A_202C_202E(Renderer P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.realtimeLightmapScaleOffset;
	}

	static bool _202E_200E_206D_206D_202E_202A_200F_206F_206E_202B_206F_200E_200F_200F_206F_206C_206B_200F_206E_202D_202B_200F_206A_202D_206E_200B_206F_206E_202D_202D_200F_202A_202D_202B_202A_200B_206F_200D_202D_200D_202E(Renderer P_0)
	{
		return P_0.isVisible;
	}

	static bool _200E_200D_206E_206E_200F_202B_200D_202A_200C_206C_202B_206C_200F_206D_206E_206E_206C_202B_202B_206C_202B_202A_202D_206F_206C_202D_200B_200F_200B_202D_202E_206D_202C_202D_200D_200F_202B_202D_200F_202D_202E(Renderer P_0)
	{
		return P_0.useLightProbes;
	}

	static Transform _202E_202C_200F_206A_200D_206D_206D_206F_206F_206A_202D_200F_200C_202C_202E_200F_206C_200F_202A_202B_206A_206A_206E_202D_202A_200F_206D_206C_200F_202E_200C_206B_202D_200B_200B_202A_202D_202C_202E_206A_202E(Renderer P_0)
	{
		return P_0.probeAnchor;
	}

	static ReflectionProbeUsage _200D_202D_206B_206A_202B_202E_200E_206E_200E_202C_202D_206F_200B_202E_206F_200B_206C_202E_206D_200D_200E_200F_202E_200D_200B_200B_200E_200E_200F_202C_200E_202C_200B_202C_202B_206D_206A_206E_200C_202D_202E(Renderer P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.reflectionProbeUsage;
	}

	static string _202E_206A_200C_200C_206F_206B_200E_202A_200F_202C_206C_206F_200B_202B_206B_200C_200D_206A_206B_202E_202B_202D_200E_206E_202C_200B_206C_206E_202B_200E_206B_206B_200E_202E_206E_206A_202D_200F_202E_202C_202E(Renderer P_0)
	{
		return P_0.sortingLayerName;
	}

	static int _206A_206E_206A_206B_200F_202D_200C_200B_202C_202D_202E_200B_200E_206D_200D_200F_206D_200D_206B_206D_200B_206C_206F_202E_202E_206F_206B_200C_202B_206D_202A_200E_206D_206C_202C_200F_206B_200C_202D_206D_202E(Renderer P_0)
	{
		return P_0.sortingLayerID;
	}

	static int _202D_206F_206E_202D_200B_202B_202C_206A_202C_202A_200D_200D_206D_206C_200F_200F_202B_206D_206C_200F_206F_202B_202B_202C_206D_200D_200B_206E_206F_206A_200D_206C_202E_200B_202B_206E_206A_200E_202E_200D_202E(Renderer P_0)
	{
		return P_0.sortingOrder;
	}

	static void _206A_206A_206C_200C_200F_202D_202E_202C_206B_206D_202D_206B_206E_202A_200F_206D_206C_202A_202B_206A_202B_202A_200F_202D_206E_206B_206A_206D_200C_200F_206E_200B_202E_200C_206C_206B_206F_206E_206B_206C_202E(Renderer P_0, bool P_1)
	{
		P_0.enabled = P_1;
	}

	static void _202E_200C_200F_202C_200C_202D_200D_200E_200C_206F_206C_202D_200E_206E_202B_202A_200C_202E_206D_206F_202D_202A_202B_202E_202C_202E_202D_200D_206B_202D_202C_200C_206B_206E_202E_206E_202B_206D_202C_206D_202E(Renderer P_0, ShadowCastingMode P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.shadowCastingMode = P_1;
	}

	static void _206E_202A_200F_200B_200F_206A_202C_200D_206A_202E_202B_202A_200D_200E_202D_202B_202B_200E_200C_202E_202E_202C_200B_206D_200F_202E_206C_202B_202B_206F_202E_206C_206C_202C_206F_200F_206A_206A_206A_202E(Renderer P_0, bool P_1)
	{
		P_0.receiveShadows = P_1;
	}

	static void _206A_206B_200B_200B_200D_202C_202D_206A_206F_206E_206F_206E_206E_202D_206E_202A_206B_206E_200B_206C_202A_206C_200B_200D_206F_206A_202C_206D_206B_202B_200D_200B_200D_206C_202A_206A_202B_206C_200C_202E_202E(Renderer P_0, Material P_1)
	{
		P_0.material = P_1;
	}

	static void _200D_202C_206C_206A_206F_202A_200E_202D_202D_206A_202D_202B_202B_200D_200E_202E_202C_200F_200C_202E_200F_200B_200B_206A_206E_206F_200F_202C_202C_200D_206A_202A_202A_202D_200B_200C_200D_202B_206A_200D_202E(Renderer P_0, Material P_1)
	{
		P_0.sharedMaterial = P_1;
	}

	static void _200D_202B_202D_200E_206E_202A_200E_202E_206D_200E_206F_206C_200E_206D_200B_202A_206B_206F_206D_200F_206D_202B_200B_202C_206D_202E_202B_200B_202D_200C_206B_206F_206C_202D_206A_206A_206D_202E_200D_200F_202E(Renderer P_0, Material[] P_1)
	{
		P_0.materials = P_1;
	}

	static void _202A_200F_200B_202E_202B_202A_202A_200C_206D_202A_206C_206A_202E_202A_206C_206F_200B_206B_202A_200F_206B_206A_200D_200C_200B_202D_206C_206D_202E_200D_200D_206B_202E_200B_202C_206D_200E_202A_206F_202B_202E(Renderer P_0, Material[] P_1)
	{
		P_0.sharedMaterials = P_1;
	}

	static void _202D_200E_202B_202C_206F_202A_200F_206D_200F_200F_206E_200D_206A_200D_206B_206C_206D_206F_200F_202E_200F_206B_206C_200B_206F_206B_202B_206B_206E_202A_206D_206A_200C_206F_200D_206D_206B_200B_202B_206B_202E(Renderer P_0, int P_1)
	{
		P_0.lightmapIndex = P_1;
	}

	static void _200F_206E_202A_200C_206C_206C_200E_206F_202A_200E_206A_206A_202E_200C_206B_206D_200F_202E_206E_202C_202C_206F_206C_200F_206A_202B_200B_200B_202A_206B_202A_200B_200D_202C_202B_202E_206D_206B_206C_202C_202E(Renderer P_0, int P_1)
	{
		P_0.realtimeLightmapIndex = P_1;
	}

	static void _206B_202E_206D_202E_200F_200D_202B_206F_200C_206D_206A_206B_200E_206E_202C_200B_202D_202D_206C_202C_200B_202B_206B_206E_202E_206E_202E_200F_206D_206A_202C_206E_206C_200F_206D_200C_206E_200E_200C_202E_202E(Renderer P_0, Vector4 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.lightmapScaleOffset = P_1;
	}

	static void _202C_206F_206A_206E_206C_200E_200C_200F_206F_202D_206C_206C_202D_206B_202A_206B_200E_200B_202A_200B_206A_200B_206C_200F_206C_200C_200D_206E_202E_206C_202C_202E_202E_202C_200E_206A_202B_200B_200D_206A_202E(Renderer P_0, Vector4 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.realtimeLightmapScaleOffset = P_1;
	}

	static void _206E_200F_206C_200D_200D_202C_202D_200B_206B_206E_206F_200C_200B_206D_200F_206E_200B_206A_200B_206E_200B_200D_202E_202A_206F_202E_200C_200F_206F_202B_206B_202A_206E_206E_202C_202E_206E_202D_206E_206D_202E(Renderer P_0, bool P_1)
	{
		P_0.useLightProbes = P_1;
	}

	static void _200D_206E_206F_202A_202B_200D_200D_206E_200E_206F_202C_202A_202E_202A_206D_206C_206A_206C_206D_206C_200B_202B_200D_202C_206E_202C_206A_206A_202C_200C_206D_200F_206C_202E_200D_200C_206E_200E_206D_206B_202E(Renderer P_0, Transform P_1)
	{
		P_0.probeAnchor = P_1;
	}

	static void _200D_206F_202A_200D_206B_200B_200B_200C_202E_200C_206D_206B_202A_206D_206D_202B_202D_202D_206C_200C_206D_206F_202E_206F_206C_200C_200E_206F_200B_202A_202C_202C_202E_206C_202D_200E_206A_202D_206C_202B_202E(Renderer P_0, ReflectionProbeUsage P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.reflectionProbeUsage = P_1;
	}

	static void _206E_200E_206D_206D_206F_206A_200F_200B_202C_202A_202C_200E_200F_200C_206B_200B_200B_200C_206E_202A_200E_202D_206C_200B_206C_202E_202A_202E_202D_206E_202B_202A_202D_206C_206B_206D_200C_200C_200E_202C_202E(Renderer P_0, string P_1)
	{
		P_0.sortingLayerName = P_1;
	}

	static void _202D_206F_202B_200B_202A_200F_206C_202D_206B_200C_200B_200E_202D_206C_200E_202B_200E_206B_202C_206A_206B_200F_202A_202B_200E_206A_200B_202B_202A_202C_206E_206D_206D_202A_200D_200F_202D_206F_202E_206E_202E(Renderer P_0, int P_1)
	{
		P_0.sortingLayerID = P_1;
	}

	static void _200B_202B_206D_206A_202C_202B_206F_200D_206F_206B_202E_202A_202B_202E_200E_202E_200C_200E_200C_200C_200D_206D_200E_206D_200C_200B_206E_206C_200F_206F_200B_206A_206B_206E_200D_200F_206C_202E_206A_202A_202E(Renderer P_0, int P_1)
	{
		P_0.sortingOrder = P_1;
	}

	static void _206F_206C_206B_202A_200B_200E_206C_200E_202B_202D_200F_200B_200D_200E_200D_206D_202E_200B_206C_202A_200B_200C_202B_202A_206B_200B_206A_200D_200B_202B_206C_202C_206F_200D_202C_200D_206C_200F_202E_202B_202E(Renderer P_0, MaterialPropertyBlock P_1)
	{
		P_0.SetPropertyBlock(P_1);
	}

	static void _206A_202D_202B_202B_206F_200B_206C_206D_202A_200D_200F_200B_200D_200C_200D_206D_202E_206C_206E_206C_202B_206A_206C_200B_200D_200F_200C_200D_206B_200D_202E_202C_206C_206C_200C_206A_200C_200E_202D_206D_202E(Renderer P_0, MaterialPropertyBlock P_1)
	{
		P_0.GetPropertyBlock(P_1);
	}

	static void _200F_202B_200B_200F_206C_200D_202B_200B_200C_200F_200E_202D_202C_200E_202A_206F_202E_206D_206F_206B_200C_202A_202A_200C_202D_206A_200B_200D_206E_206F_200F_202B_206F_200F_206C_200B_202E_202E_206A_202E_202E(Renderer P_0, List<ReflectionProbeBlendInfo> P_1)
	{
		P_0.GetClosestReflectionProbes(P_1);
	}
}
