using System;
using LuaInterface;
using UnityEngine;

public class QualitySettingsWrap
{
	private static Type classType = _200E_202B_206D_200B_206F_200C_206E_200B_202E_202E_202C_200F_202D_202A_206C_202D_200D_202E_200E_202A_206A_202D_206C_202C_206F_202B_200D_206B_200F_202D_200C_202C_206F_206C_202D_202D_200F_206C_200E_200C_202E(typeof(QualitySettings).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[7]
		{
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1419540084u), GetQualityLevel),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1179266143u), SetQualityLevel),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1678080058u), IncreaseLevel),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3044132239u), DecreaseLevel),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1657282774u), _200C_206D_200C_200F_202B_202C_200E_206C_200D_200E_206B_206F_200E_202B_206D_206C_202D_206E_206F_202B_206D_202C_202E_200E_202B_202B_206E_206C_206D_206A_202A_202C_200E_206E_202C_202C_202E_206F_206F_200C_202E),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(10103728u), GetClassType),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(396454614u), Lua_Eq)
		};
		LuaField[] fields = new LuaField[22]
		{
			new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1848602799u), get_names, null),
			new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(881367857u), get_pixelLightCount, set_pixelLightCount),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1369127929u), get_shadowProjection, set_shadowProjection),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2662420220u), get_shadowCascades, set_shadowCascades),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3114683851u), get_shadowDistance, set_shadowDistance),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1557805394u), get_shadowNearPlaneOffset, set_shadowNearPlaneOffset),
			new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2490515970u), get_shadowCascade2Split, set_shadowCascade2Split),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2796197757u), get_shadowCascade4Split, set_shadowCascade4Split),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2955836995u), get_masterTextureLimit, set_masterTextureLimit),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2199121461u), get_anisotropicFiltering, set_anisotropicFiltering),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1933057743u), get_lodBias, set_lodBias),
			new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2123699756u), get_maximumLODLevel, set_maximumLODLevel),
			new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2112846562u), get_particleRaycastBudget, set_particleRaycastBudget),
			new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4111381067u), get_softVegetation, set_softVegetation),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3733290339u), get_realtimeReflectionProbes, set_realtimeReflectionProbes),
			new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4245543316u), get_billboardsFaceCameraPosition, set_billboardsFaceCameraPosition),
			new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(789879751u), get_maxQueuedFrames, set_maxQueuedFrames),
			new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2602534821u), get_vSyncCount, set_vSyncCount),
			new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1205526705u), get_antiAliasing, set_antiAliasing),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1729207455u), get_desiredColorSpace, null),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(972491921u), get_activeColorSpace, null),
			new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3539018463u), get_blendWeights, set_blendWeights)
		};
		while (true)
		{
			int num = 369183892;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x77723774)) % 3)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_0590;
				case 0u:
					return;
				}
				break;
				IL_0590:
				LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4090320192u), _200E_202B_206D_200B_206F_200C_206E_200B_202E_202E_202C_200F_202D_202A_206C_202D_200D_202E_200E_202A_206A_202D_206C_202C_206F_202B_200D_206B_200F_202D_200C_202C_206F_206C_202D_202D_200F_206C_200E_200C_202E(typeof(QualitySettings).TypeHandle), regs, fields, _200E_202B_206D_200B_206F_200C_206E_200B_202E_202E_202C_200F_202D_202A_206C_202D_200D_202E_200E_202A_206A_202D_206C_202C_206F_202B_200D_206B_200F_202D_200C_202C_206F_206C_202D_202D_200F_206C_200E_200C_202E(typeof(Object).TypeHandle));
				num = (int)((num2 * 286548867) ^ 0x26215023);
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _200C_206D_200C_200F_202B_202C_200E_206C_200D_200E_206B_206F_200E_202B_206D_206C_202D_206E_206F_202B_206D_202C_202E_200E_202B_202B_206E_206C_206D_206A_202A_202C_200E_206E_202C_202C_202E_206F_206F_200C_202E(IntPtr P_0)
	{
		int num = LuaDLL.lua_gettop(P_0);
		QualitySettings obj = default(QualitySettings);
		while (true)
		{
			int num2 = 299151717;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x724559FD)) % 6)
				{
				case 3u:
					break;
				case 4u:
				{
					int num4;
					int num5;
					if (num == 0)
					{
						num4 = 1306817567;
						num5 = num4;
					}
					else
					{
						num4 = 1381271732;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num3 * -41439998);
					continue;
				}
				case 2u:
					obj = _200E_206E_200D_202B_200D_206F_200B_200F_206F_202E_202C_200F_202A_206C_200F_206A_202C_206D_206F_206F_200D_206E_202D_202B_202E_202B_202D_202D_202E_202B_206B_200C_206F_206E_200C_200C_202C_202B_206F_202B_202E();
					num2 = ((int)num3 * -149153548) ^ 0x1060073D;
					continue;
				case 0u:
					LuaScriptMgr.Push(P_0, (Object)(object)obj);
					num2 = (int)((num3 * 425075527) ^ 0x4DED9716);
					continue;
				case 1u:
					return 1;
				default:
					LuaDLL.luaL_error(P_0, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2110184605u));
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
	private static int get_names(IntPtr L)
	{
		LuaScriptMgr.PushArray(L, _202E_200B_202C_200E_202B_202D_202B_200D_202B_206D_202D_200D_202D_202C_200D_200C_200B_200D_206F_200B_200E_202D_206D_202D_200D_206E_200E_206F_202C_206F_206A_206A_206B_206B_200B_200D_202C_202A_206C_206F_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_pixelLightCount(IntPtr L)
	{
		LuaScriptMgr.Push(L, _200F_206F_200F_202C_202C_202B_206C_200D_202D_206F_206E_200B_202D_200F_206D_200E_206A_202E_200C_200F_202C_200D_200F_200F_200F_200E_206D_200F_200B_200F_202D_202B_202E_206C_202E_200E_200B_206B_202E_202D_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_shadowProjection(IntPtr L)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr.Push(L, (Enum)(object)_200B_202C_206D_200F_200D_202E_200E_206D_206A_206C_200D_206B_206F_200D_202D_200C_200E_206A_206E_202C_206C_200E_206F_202C_202E_202A_206C_202B_202D_206D_202B_200F_200F_202B_202B_206F_206B_200B_202E_200E_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_shadowCascades(IntPtr L)
	{
		LuaScriptMgr.Push(L, _206A_202B_206F_202C_200D_206F_202E_200F_202D_206A_200F_202A_202D_202E_202A_206F_206A_202C_206E_202A_200D_206F_200F_202D_202A_206F_202A_202E_206B_202B_202A_200F_206D_200C_202E_200E_206C_200F_200B_202A_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_shadowDistance(IntPtr L)
	{
		LuaScriptMgr.Push(L, _206F_206F_206C_202A_202D_200D_200C_202A_202E_206F_202C_200E_200F_200C_202B_200B_206F_200B_206D_206B_200C_202B_202A_200B_202C_206D_200F_200C_206C_206E_200D_206F_200D_206B_202E_206A_200E_202B_206F_200D_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_shadowNearPlaneOffset(IntPtr L)
	{
		LuaScriptMgr.Push(L, _200E_206D_200D_202E_200C_206A_200D_200E_206D_200C_200D_206B_200F_200C_202B_202A_200E_206C_200E_206B_206E_206D_200B_206D_206C_206D_200C_206B_200B_206B_202A_200F_206B_202C_200D_206A_206A_202B_202C_202C_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_shadowCascade2Split(IntPtr L)
	{
		LuaScriptMgr.Push(L, _206A_202C_202B_200E_202D_200F_206B_202B_206B_206C_206B_202D_206E_206F_206C_206B_202E_202A_200D_206B_206F_206B_206D_206E_202D_200F_200C_206E_200E_206D_206A_202C_202D_206E_206D_206D_206A_200C_202A_206F_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_shadowCascade4Split(IntPtr L)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr.Push(L, _200C_202A_200D_206B_206C_206D_206D_202D_206F_200D_206F_206D_202D_200B_206B_202B_206C_202A_206F_206A_202A_202B_200E_206D_202A_206C_202D_200E_206A_200C_206C_202C_202E_200D_200D_202B_206C_200F_200E_202A_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_masterTextureLimit(IntPtr L)
	{
		LuaScriptMgr.Push(L, _206C_200C_206B_200C_206A_202C_206C_206A_200F_202D_200D_200B_200E_200E_206A_206B_202B_202A_202D_202D_200E_202D_200B_200F_200D_200F_200C_200E_202B_200C_200D_206B_206F_200C_202D_202E_206A_200B_206D_206D_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_anisotropicFiltering(IntPtr L)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr.Push(L, (Enum)(object)_200F_200D_200B_200C_206C_200D_206D_206D_200F_206F_206E_202B_206A_202D_206E_202E_202B_206E_206E_200F_200D_200E_202B_206C_200F_200C_200D_200E_200F_202E_206F_202D_206F_206F_200E_200F_206F_202A_200B_200D_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_lodBias(IntPtr L)
	{
		LuaScriptMgr.Push(L, _200E_206F_200F_206E_202E_200C_202D_206D_200D_202D_206A_206B_202C_206C_202B_202B_200C_202C_200C_206C_206D_200F_206E_206F_202C_206E_202D_200C_206E_206D_206C_202D_202E_206C_200B_200C_202D_206C_200C_202C_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_maximumLODLevel(IntPtr L)
	{
		LuaScriptMgr.Push(L, _202C_202A_206E_202A_206C_206E_206B_206D_206A_206E_206E_206C_200D_206B_206E_206C_206C_206A_206D_200B_202D_200C_202D_206C_206D_200F_202B_200C_206D_206C_206B_206D_200D_200E_206A_206A_200F_202E_206A_202A_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_particleRaycastBudget(IntPtr L)
	{
		LuaScriptMgr.Push(L, _206C_206D_200F_202E_206D_202C_206A_206A_200C_200D_202A_206B_202D_200C_200D_200F_200C_202A_202A_206D_202A_200D_200C_200B_202C_202C_200F_206D_200F_206C_206A_202D_200B_200D_200B_206C_202A_202E_200D_202C_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_softVegetation(IntPtr L)
	{
		LuaScriptMgr.Push(L, _200F_200F_202C_202B_200B_200D_206B_206C_200C_200D_202A_200D_206C_206D_202A_202A_206A_206D_206A_200F_202C_206A_206F_202C_206B_206C_200F_202D_200C_206B_206D_200B_206A_202E_206B_200B_206A_202B_206D_200D_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_realtimeReflectionProbes(IntPtr L)
	{
		LuaScriptMgr.Push(L, _200E_206D_206B_206D_202A_200B_200F_200B_200C_206C_202E_202B_206B_200B_202A_206D_206F_202D_206C_206C_202B_200D_200D_206B_206C_206C_202B_206F_206E_200F_202E_202C_206D_206A_202D_200C_202E_202C_206C_200F_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_billboardsFaceCameraPosition(IntPtr L)
	{
		LuaScriptMgr.Push(L, _202C_202B_206C_202E_206E_202E_200D_202E_200C_206E_200C_202D_206F_202D_200B_206A_200D_202B_202A_200C_202B_206D_206C_206C_206D_202D_200B_202B_206D_206C_200F_206A_206C_206A_200E_202B_206F_206A_200F_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_maxQueuedFrames(IntPtr L)
	{
		LuaScriptMgr.Push(L, _200C_202D_200C_202B_202C_206F_202E_200B_206C_202B_206D_200C_200E_202E_206E_200B_200E_200D_200F_206A_202A_206C_202E_206B_200E_202E_200B_200F_206D_202A_200E_206B_202C_202D_206D_202E_206F_200D_200F_206C_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_vSyncCount(IntPtr L)
	{
		LuaScriptMgr.Push(L, _202D_206D_206A_206F_206C_200F_206E_206E_206C_200E_206C_206D_200B_202D_200E_202E_200D_206E_202B_200D_206F_206C_200C_200D_200B_202B_200B_200C_200C_206A_206C_206F_206E_202D_202E_200E_202B_206B_206D_206B_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_antiAliasing(IntPtr L)
	{
		LuaScriptMgr.Push(L, _200C_202D_206B_200D_200B_202B_206B_200C_206C_202D_200D_206B_206E_202A_202D_202E_202A_200E_202B_200C_206D_200D_202A_202E_200B_202E_206F_206F_206D_206E_202E_206C_202B_206A_200F_206C_202A_206F_200E_206B_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_desiredColorSpace(IntPtr L)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr.Push(L, (Enum)(object)_206F_206C_202A_202D_206A_202E_206C_206F_206E_200D_202A_200D_202E_202D_206F_206A_206A_200D_206B_200C_206D_200F_202E_200C_202D_206B_200E_202E_202E_206F_206A_206F_206E_206D_200F_206E_202E_206E_202D_206C_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_activeColorSpace(IntPtr L)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr.Push(L, (Enum)(object)_200D_206E_200E_206B_200B_202B_202A_206C_200D_206F_202E_200B_200F_206F_202B_202E_206D_202E_200D_202D_200B_202C_202C_206D_200B_200F_206B_202E_202A_206B_202D_200E_200E_206F_200E_206F_206D_200F_200F_206A_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_blendWeights(IntPtr L)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr.Push(L, (Enum)(object)_200D_206E_206A_202E_206D_202D_202E_202B_202D_206A_200E_202D_206A_200D_200D_200B_206F_202B_200B_206D_200B_202A_206D_206A_206F_202D_206B_200D_200E_200D_200E_200C_202E_202C_202B_200C_202C_206A_206C_206C_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_pixelLightCount(IntPtr L)
	{
		_202A_200F_202C_206D_206E_200F_202E_200F_206F_200B_206A_206F_202C_206C_206A_200B_206B_206A_206F_206A_202D_206B_200E_206E_200D_206B_200D_206C_206F_202B_202E_206F_200C_200C_200E_202A_206F_206D_206D_206D_202E((int)LuaScriptMgr.GetNumber(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_shadowProjection(IntPtr L)
	{
		_202C_200B_200C_206F_206B_206F_206D_202A_206C_206B_206E_206C_202A_206C_200F_206B_200F_206B_206D_200E_200E_200C_200F_206A_206E_206D_200C_206B_200E_202B_202D_206C_200C_202A_200D_200E_206A_202C_200F_206C_202E((ShadowProjection)(int)LuaScriptMgr.GetNetObject(L, 3, _200E_202B_206D_200B_206F_200C_206E_200B_202E_202E_202C_200F_202D_202A_206C_202D_200D_202E_200E_202A_206A_202D_206C_202C_206F_202B_200D_206B_200F_202D_200C_202C_206F_206C_202D_202D_200F_206C_200E_200C_202E(typeof(ShadowProjection).TypeHandle)));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_shadowCascades(IntPtr L)
	{
		_202B_202D_202D_202B_206B_200B_200F_202E_202C_200D_206A_206A_200C_200B_206F_206A_202A_200E_206D_200B_202D_200D_206F_206E_202A_206C_202C_206D_206D_200C_206C_206A_206B_206C_200D_200F_206D_202C_206A_200C_202E((int)LuaScriptMgr.GetNumber(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_shadowDistance(IntPtr L)
	{
		_206C_200C_206C_206D_202E_206C_202A_200E_202E_200C_200B_206F_206D_200B_206D_202B_200C_200C_200F_202E_200D_206B_206F_200F_206E_206D_200C_202B_202B_200F_206C_206E_206F_202B_200F_202C_206E_206A_200D_200E_202E((float)LuaScriptMgr.GetNumber(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_shadowNearPlaneOffset(IntPtr L)
	{
		_202E_202D_202D_202A_206D_206E_202B_200E_206C_206B_202D_206B_200B_206C_200D_200F_200C_202E_206B_200D_200C_206F_200C_202C_206E_202C_202D_206F_206F_200E_200B_202C_202C_206A_200C_206D_200D_206F_200F_206F_202E((float)LuaScriptMgr.GetNumber(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_shadowCascade2Split(IntPtr L)
	{
		_202A_206C_200B_206E_202C_200F_206A_206D_206D_202E_206E_206C_200C_206C_206F_200F_202B_206B_200F_206F_200F_200B_206D_206E_206C_200D_200F_206F_200C_202E_202D_200E_206D_206A_206A_200B_206C_200E_200E_200C_202E((float)LuaScriptMgr.GetNumber(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_shadowCascade4Split(IntPtr L)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_202E_206C_202B_206C_200F_202B_200E_200D_200C_206E_206A_206E_200E_202E_206F_202D_202A_206C_206A_202D_206C_200B_202C_202D_206A_206C_200E_206F_202D_202C_206D_206A_200F_202A_200C_200B_206B_202B_202C_206C_202E(LuaScriptMgr.GetVector3(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_masterTextureLimit(IntPtr L)
	{
		_200C_202B_206F_206D_200D_206F_206A_206C_206B_200F_200F_200E_206D_206C_206A_200D_206B_200F_202B_206B_202A_206F_206A_202D_202E_200E_200C_202E_206B_202D_206B_202E_206D_206E_202A_200D_200B_206E_202E_202A_202E((int)LuaScriptMgr.GetNumber(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_anisotropicFiltering(IntPtr L)
	{
		_200D_200E_202D_206F_202D_200E_206F_206B_206D_202A_202A_206B_202C_202B_206A_206C_200C_202C_202A_200F_202B_200F_200F_206D_200C_202D_200D_200D_200F_202D_200C_202B_202C_200F_200D_206D_202E_200B_202D_202E((AnisotropicFiltering)(int)LuaScriptMgr.GetNetObject(L, 3, _200E_202B_206D_200B_206F_200C_206E_200B_202E_202E_202C_200F_202D_202A_206C_202D_200D_202E_200E_202A_206A_202D_206C_202C_206F_202B_200D_206B_200F_202D_200C_202C_206F_206C_202D_202D_200F_206C_200E_200C_202E(typeof(AnisotropicFiltering).TypeHandle)));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_lodBias(IntPtr L)
	{
		_202A_206D_200C_206E_206C_200E_206F_200B_206E_200D_200D_206C_206B_202E_206E_206E_206E_202B_202B_202E_200E_206C_206C_206C_200C_206E_202A_200D_202C_206F_200F_202E_206E_206D_200D_206A_206B_206A_202A_206F_202E((float)LuaScriptMgr.GetNumber(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_maximumLODLevel(IntPtr L)
	{
		_202C_202C_200C_206F_202A_202D_206B_206B_202C_202B_206F_202A_206D_200E_200D_202C_200E_206B_206E_202C_200B_200F_202D_200D_206A_206B_202A_202E_202B_202A_202D_200E_200C_206C_206B_200D_202E_206D_202E_200C_202E((int)LuaScriptMgr.GetNumber(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_particleRaycastBudget(IntPtr L)
	{
		_202B_202B_202A_202A_206F_202C_200B_206F_202C_206C_200D_200C_202B_206C_200F_200B_202E_206D_206F_202C_206B_200D_200C_200B_202C_200C_206E_206A_200B_206B_200D_202B_206B_200E_202A_200B_206C_200F_206F_202E_202E((int)LuaScriptMgr.GetNumber(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_softVegetation(IntPtr L)
	{
		_200C_200B_200E_206A_202E_200D_202A_206E_202B_206D_200D_202B_200E_206F_206A_202D_202E_206A_202B_206D_200D_206E_202D_206F_200D_202B_206F_206D_206C_200C_206B_202B_206D_200C_206E_206C_200B_206B_202E_200F_202E(LuaScriptMgr.GetBoolean(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_realtimeReflectionProbes(IntPtr L)
	{
		_206B_200C_200B_200D_202E_206A_202B_206B_206C_202D_202E_206A_200B_202C_202B_200F_206A_202C_200C_206B_202A_202C_206F_206A_200E_202E_200E_206F_202B_206D_200F_202C_206D_200D_206E_200B_200D_200D_200F_202B_202E(LuaScriptMgr.GetBoolean(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_billboardsFaceCameraPosition(IntPtr L)
	{
		_202A_202E_206F_200D_206F_206D_200F_202D_202E_202E_202B_202B_202E_206E_200C_202E_202D_206C_200D_202D_200B_206B_206D_200E_206B_206E_202D_200B_206B_202D_202C_206D_200F_202D_202E_206A_200F_200C_206E_202A_202E(LuaScriptMgr.GetBoolean(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_maxQueuedFrames(IntPtr L)
	{
		_206B_200E_202C_206F_206C_206F_200E_206E_202A_202A_200F_206E_206B_202D_200E_206A_200C_202B_206D_202B_202C_206B_200D_202E_202A_206D_202D_206A_202B_206D_206C_200C_206D_206A_206C_200E_200B_200D_206C_206B_202E((int)LuaScriptMgr.GetNumber(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_vSyncCount(IntPtr L)
	{
		_206E_202D_200C_200C_200F_200D_206E_206D_200E_206F_206C_206E_202A_206C_206E_206F_200E_202D_200D_206E_202D_206D_206B_200E_206A_200D_202E_206F_200B_206A_202B_200B_202D_200F_202C_200D_200D_202A_200C_206C_202E((int)LuaScriptMgr.GetNumber(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_antiAliasing(IntPtr L)
	{
		_200F_202D_200B_200C_200B_200D_202E_200C_202A_202C_202B_206E_200C_206B_200D_202D_202C_200C_206E_206E_202B_200D_202D_202D_200D_202C_206A_206D_200B_200C_202A_200B_206D_200C_206D_200D_200E_202D_200C_206B_202E((int)LuaScriptMgr.GetNumber(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_blendWeights(IntPtr L)
	{
		_206E_200E_202B_200E_200F_200D_206B_202B_200F_202B_200C_206D_206B_200D_200C_202C_202A_202D_200D_200B_202E_202C_206C_200C_202D_206D_200F_202E_200F_200D_202D_202D_202B_202D_200B_200F_202E_200E_200B_202E_202E((BlendWeights)(int)LuaScriptMgr.GetNetObject(L, 3, _200E_202B_206D_200B_206F_200C_206E_200B_202E_202E_202C_200F_202D_202A_206C_202D_200D_202E_200E_202A_206A_202D_206C_202C_206F_202B_200D_206B_200F_202D_200C_202C_206F_206C_202D_202D_200F_206C_200E_200C_202E(typeof(BlendWeights).TypeHandle)));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetQualityLevel(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		int d = default(int);
		while (true)
		{
			int num = -1547404562;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1088837977)) % 4)
				{
				case 3u:
					break;
				case 1u:
					d = _200C_202D_200E_206C_202C_202D_200C_206A_200E_206B_206E_202E_202B_200E_206E_206D_200B_200D_206A_206C_202A_200C_200F_202E_206A_202C_200E_202E_200E_200F_202D_206D_206A_202C_200E_206F_202E_200B_202C_206A_202E();
					num = (int)((num2 * 1676337509) ^ 0x8B9D388);
					continue;
				case 2u:
					LuaScriptMgr.Push(L, d);
					num = ((int)num2 * -474479282) ^ -1355192829;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SetQualityLevel(IntPtr L)
	{
		int num = LuaDLL.lua_gettop(L);
		int num7 = default(int);
		int num4 = default(int);
		bool boolean = default(bool);
		while (true)
		{
			int num2 = 458690570;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x60556FFB)) % 11)
				{
				case 3u:
					break;
				case 0u:
					_206F_206C_206A_202E_206A_200B_200E_206A_206E_200D_200C_202B_202A_206B_206A_200D_206B_202E_206D_200F_200F_202B_200C_206A_200F_200E_202B_202B_202A_202C_200F_206E_200B_200E_202B_200B_206A_200F_200B_206E_202E(num7);
					num2 = (int)((num3 * 1173492808) ^ 0x485768BF);
					continue;
				case 7u:
					return 0;
				case 4u:
				{
					int num8;
					if (num == 2)
					{
						num2 = 1781100864;
						num8 = num2;
					}
					else
					{
						num2 = 1539099232;
						num8 = num2;
					}
					continue;
				}
				case 9u:
					num7 = (int)LuaScriptMgr.GetNumber(L, 1);
					num2 = ((int)num3 * -26335336) ^ -235792257;
					continue;
				case 8u:
					_202B_206C_206B_202A_206E_202C_200C_206E_202A_200B_200D_206E_202A_202A_206D_202E_206A_200F_206D_206D_206E_202B_200B_200C_206C_202C_206C_202E_206C_200B_202A_200F_206A_200F_200F_202B_206B_202B_200C_200C_202E(num4, boolean);
					num2 = ((int)num3 * -1547663378) ^ -2067533188;
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (num == 1)
					{
						num5 = -841487702;
						num6 = num5;
					}
					else
					{
						num5 = -2019723466;
						num6 = num5;
					}
					num2 = num5 ^ ((int)num3 * -1257905405);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3876802310u));
					num2 = 1769785804;
					continue;
				case 5u:
					return 0;
				case 2u:
					num4 = (int)LuaScriptMgr.GetNumber(L, 1);
					boolean = LuaScriptMgr.GetBoolean(L, 2);
					num2 = (int)((num3 * 1816669858) ^ 0x645E1DF0);
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int IncreaseLevel(IntPtr L)
	{
		int num = LuaDLL.lua_gettop(L);
		bool boolean = default(bool);
		while (true)
		{
			int num2 = -2037038472;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -439543438)) % 8)
				{
				case 0u:
					break;
				case 3u:
				{
					int num6;
					if (num == 1)
					{
						num2 = -1466018892;
						num6 = num2;
					}
					else
					{
						num2 = -413998329;
						num6 = num2;
					}
					continue;
				}
				case 7u:
					_206E_200B_206D_200C_202D_206B_202E_206D_202E_202D_202D_206F_200F_206D_206F_202D_200C_202C_202C_202D_202E_206E_206D_206B_202E_202E_206A_202C_202E_202E_202C_202B_202C_200C_200E_206F_200F_200E_200E_202D_202E(boolean);
					return 0;
				case 2u:
				{
					int num4;
					int num5;
					if (num != 0)
					{
						num4 = 1165854857;
						num5 = num4;
					}
					else
					{
						num4 = 992815787;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num3 * -1313140592);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(274187961u));
					num2 = -1259267266;
					continue;
				case 6u:
					boolean = LuaScriptMgr.GetBoolean(L, 1);
					num2 = ((int)num3 * -946799420) ^ -251170275;
					continue;
				case 1u:
					_200D_202D_200E_200C_206C_202B_202A_206D_200B_206D_202D_200D_200C_202B_202B_206F_202D_200B_200B_206A_200F_202D_206C_202B_206E_202E_206F_202D_206E_202B_206C_202E_202D_206F_206C_200C_200E_206F_202B_206D_202E();
					return 0;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int DecreaseLevel(IntPtr L)
	{
		int num = LuaDLL.lua_gettop(L);
		if (num == 0)
		{
			goto IL_000a;
		}
		goto IL_0073;
		IL_000a:
		int num2 = -853385137;
		goto IL_000f;
		IL_000f:
		bool boolean = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ -225352215)) % 9)
			{
			case 0u:
				break;
			case 8u:
				_200E_202C_202A_206C_206C_200B_206F_206C_202E_200C_206B_200E_202C_206D_200E_206B_202C_202A_200C_202C_202E_200D_202D_206D_200E_206D_206A_206E_206F_202D_206E_206C_206D_202C_202E_200E_202C_206C_206D_202B_202E();
				num2 = (int)((num3 * 92437822) ^ 0x732D3634);
				continue;
			case 7u:
				boolean = LuaScriptMgr.GetBoolean(L, 1);
				num2 = (int)(num3 * 1848567876) ^ -1235113603;
				continue;
			case 1u:
				goto IL_0073;
			case 2u:
				return 0;
			case 3u:
				return 0;
			case 5u:
				_206B_202C_202D_206D_206E_202C_202D_200B_200D_202E_206B_206C_206B_206B_200D_206B_202A_206C_200E_200B_206D_206A_202A_206C_202E_202A_202B_206B_200E_206A_202E_202B_202B_200E_200C_200D_202B_206D_206A_200F_202E(boolean);
				num2 = (int)((num3 * 85143329) ^ 0x7AABC5E0);
				continue;
			case 6u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1060365079u));
				num2 = -784890450;
				continue;
			default:
				return 0;
			}
			break;
		}
		goto IL_000a;
		IL_0073:
		int num4;
		if (num == 1)
		{
			num2 = -823325540;
			num4 = num2;
		}
		else
		{
			num2 = -1296609943;
			num4 = num2;
		}
		goto IL_000f;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Lua_Eq(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Object val = default(Object);
		Object val2 = default(Object);
		while (true)
		{
			int num = -1481485365;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -370010676)) % 5)
				{
				case 3u:
					break;
				case 0u:
				{
					bool b = _206B_202D_200F_206E_202A_200B_202C_200F_200C_206F_200E_202E_200B_202C_206A_200C_200D_202C_200D_202E_202A_206F_206F_206C_202C_206A_200B_200B_200F_206D_206C_206C_202D_202C_200B_206C_202A_206A_202C_206E_202E(val, val2);
					LuaScriptMgr.Push(L, b);
					num = ((int)num2 * -136757252) ^ -1401092968;
					continue;
				}
				case 2u:
				{
					object luaObject2 = LuaScriptMgr.GetLuaObject(L, 2);
					val2 = (Object)((luaObject2 is Object) ? luaObject2 : null);
					num = ((int)num2 * -164305924) ^ 0x6C5C3B2D;
					continue;
				}
				case 4u:
				{
					object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
					val = (Object)((luaObject is Object) ? luaObject : null);
					num = (int)((num2 * 417294126) ^ 0x28167509);
					continue;
				}
				default:
					return 1;
				}
				break;
			}
		}
	}

	static Type _200E_202B_206D_200B_206F_200C_206E_200B_202E_202E_202C_200F_202D_202A_206C_202D_200D_202E_200E_202A_206A_202D_206C_202C_206F_202B_200D_206B_200F_202D_200C_202C_206F_206C_202D_202D_200F_206C_200E_200C_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static QualitySettings _200E_206E_200D_202B_200D_206F_200B_200F_206F_202E_202C_200F_202A_206C_200F_206A_202C_206D_206F_206F_200D_206E_202D_202B_202E_202B_202D_202D_202E_202B_206B_200C_206F_206E_200C_200C_202C_202B_206F_202B_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new QualitySettings();
	}

	static string[] _202E_200B_202C_200E_202B_202D_202B_200D_202B_206D_202D_200D_202D_202C_200D_200C_200B_200D_206F_200B_200E_202D_206D_202D_200D_206E_200E_206F_202C_206F_206A_206A_206B_206B_200B_200D_202C_202A_206C_206F_202E()
	{
		return QualitySettings.names;
	}

	static int _200F_206F_200F_202C_202C_202B_206C_200D_202D_206F_206E_200B_202D_200F_206D_200E_206A_202E_200C_200F_202C_200D_200F_200F_200F_200E_206D_200F_200B_200F_202D_202B_202E_206C_202E_200E_200B_206B_202E_202D_202E()
	{
		return QualitySettings.pixelLightCount;
	}

	static ShadowProjection _200B_202C_206D_200F_200D_202E_200E_206D_206A_206C_200D_206B_206F_200D_202D_200C_200E_206A_206E_202C_206C_200E_206F_202C_202E_202A_206C_202B_202D_206D_202B_200F_200F_202B_202B_206F_206B_200B_202E_200E_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return QualitySettings.shadowProjection;
	}

	static int _206A_202B_206F_202C_200D_206F_202E_200F_202D_206A_200F_202A_202D_202E_202A_206F_206A_202C_206E_202A_200D_206F_200F_202D_202A_206F_202A_202E_206B_202B_202A_200F_206D_200C_202E_200E_206C_200F_200B_202A_202E()
	{
		return QualitySettings.shadowCascades;
	}

	static float _206F_206F_206C_202A_202D_200D_200C_202A_202E_206F_202C_200E_200F_200C_202B_200B_206F_200B_206D_206B_200C_202B_202A_200B_202C_206D_200F_200C_206C_206E_200D_206F_200D_206B_202E_206A_200E_202B_206F_200D_202E()
	{
		return QualitySettings.shadowDistance;
	}

	static float _200E_206D_200D_202E_200C_206A_200D_200E_206D_200C_200D_206B_200F_200C_202B_202A_200E_206C_200E_206B_206E_206D_200B_206D_206C_206D_200C_206B_200B_206B_202A_200F_206B_202C_200D_206A_206A_202B_202C_202C_202E()
	{
		return QualitySettings.shadowNearPlaneOffset;
	}

	static float _206A_202C_202B_200E_202D_200F_206B_202B_206B_206C_206B_202D_206E_206F_206C_206B_202E_202A_200D_206B_206F_206B_206D_206E_202D_200F_200C_206E_200E_206D_206A_202C_202D_206E_206D_206D_206A_200C_202A_206F_202E()
	{
		return QualitySettings.shadowCascade2Split;
	}

	static Vector3 _200C_202A_200D_206B_206C_206D_206D_202D_206F_200D_206F_206D_202D_200B_206B_202B_206C_202A_206F_206A_202A_202B_200E_206D_202A_206C_202D_200E_206A_200C_206C_202C_202E_200D_200D_202B_206C_200F_200E_202A_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return QualitySettings.shadowCascade4Split;
	}

	static int _206C_200C_206B_200C_206A_202C_206C_206A_200F_202D_200D_200B_200E_200E_206A_206B_202B_202A_202D_202D_200E_202D_200B_200F_200D_200F_200C_200E_202B_200C_200D_206B_206F_200C_202D_202E_206A_200B_206D_206D_202E()
	{
		return QualitySettings.masterTextureLimit;
	}

	static AnisotropicFiltering _200F_200D_200B_200C_206C_200D_206D_206D_200F_206F_206E_202B_206A_202D_206E_202E_202B_206E_206E_200F_200D_200E_202B_206C_200F_200C_200D_200E_200F_202E_206F_202D_206F_206F_200E_200F_206F_202A_200B_200D_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return QualitySettings.anisotropicFiltering;
	}

	static float _200E_206F_200F_206E_202E_200C_202D_206D_200D_202D_206A_206B_202C_206C_202B_202B_200C_202C_200C_206C_206D_200F_206E_206F_202C_206E_202D_200C_206E_206D_206C_202D_202E_206C_200B_200C_202D_206C_200C_202C_202E()
	{
		return QualitySettings.lodBias;
	}

	static int _202C_202A_206E_202A_206C_206E_206B_206D_206A_206E_206E_206C_200D_206B_206E_206C_206C_206A_206D_200B_202D_200C_202D_206C_206D_200F_202B_200C_206D_206C_206B_206D_200D_200E_206A_206A_200F_202E_206A_202A_202E()
	{
		return QualitySettings.maximumLODLevel;
	}

	static int _206C_206D_200F_202E_206D_202C_206A_206A_200C_200D_202A_206B_202D_200C_200D_200F_200C_202A_202A_206D_202A_200D_200C_200B_202C_202C_200F_206D_200F_206C_206A_202D_200B_200D_200B_206C_202A_202E_200D_202C_202E()
	{
		return QualitySettings.particleRaycastBudget;
	}

	static bool _200F_200F_202C_202B_200B_200D_206B_206C_200C_200D_202A_200D_206C_206D_202A_202A_206A_206D_206A_200F_202C_206A_206F_202C_206B_206C_200F_202D_200C_206B_206D_200B_206A_202E_206B_200B_206A_202B_206D_200D_202E()
	{
		return QualitySettings.softVegetation;
	}

	static bool _200E_206D_206B_206D_202A_200B_200F_200B_200C_206C_202E_202B_206B_200B_202A_206D_206F_202D_206C_206C_202B_200D_200D_206B_206C_206C_202B_206F_206E_200F_202E_202C_206D_206A_202D_200C_202E_202C_206C_200F_202E()
	{
		return QualitySettings.realtimeReflectionProbes;
	}

	static bool _202C_202B_206C_202E_206E_202E_200D_202E_200C_206E_200C_202D_206F_202D_200B_206A_200D_202B_202A_200C_202B_206D_206C_206C_206D_202D_200B_202B_206D_206C_200F_206A_206C_206A_200E_202B_206F_206A_200F_202E()
	{
		return QualitySettings.billboardsFaceCameraPosition;
	}

	static int _200C_202D_200C_202B_202C_206F_202E_200B_206C_202B_206D_200C_200E_202E_206E_200B_200E_200D_200F_206A_202A_206C_202E_206B_200E_202E_200B_200F_206D_202A_200E_206B_202C_202D_206D_202E_206F_200D_200F_206C_202E()
	{
		return QualitySettings.maxQueuedFrames;
	}

	static int _202D_206D_206A_206F_206C_200F_206E_206E_206C_200E_206C_206D_200B_202D_200E_202E_200D_206E_202B_200D_206F_206C_200C_200D_200B_202B_200B_200C_200C_206A_206C_206F_206E_202D_202E_200E_202B_206B_206D_206B_202E()
	{
		return QualitySettings.vSyncCount;
	}

	static int _200C_202D_206B_200D_200B_202B_206B_200C_206C_202D_200D_206B_206E_202A_202D_202E_202A_200E_202B_200C_206D_200D_202A_202E_200B_202E_206F_206F_206D_206E_202E_206C_202B_206A_200F_206C_202A_206F_200E_206B_202E()
	{
		return QualitySettings.antiAliasing;
	}

	static ColorSpace _206F_206C_202A_202D_206A_202E_206C_206F_206E_200D_202A_200D_202E_202D_206F_206A_206A_200D_206B_200C_206D_200F_202E_200C_202D_206B_200E_202E_202E_206F_206A_206F_206E_206D_200F_206E_202E_206E_202D_206C_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return QualitySettings.desiredColorSpace;
	}

	static ColorSpace _200D_206E_200E_206B_200B_202B_202A_206C_200D_206F_202E_200B_200F_206F_202B_202E_206D_202E_200D_202D_200B_202C_202C_206D_200B_200F_206B_202E_202A_206B_202D_200E_200E_206F_200E_206F_206D_200F_200F_206A_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return QualitySettings.activeColorSpace;
	}

	static BlendWeights _200D_206E_206A_202E_206D_202D_202E_202B_202D_206A_200E_202D_206A_200D_200D_200B_206F_202B_200B_206D_200B_202A_206D_206A_206F_202D_206B_200D_200E_200D_200E_200C_202E_202C_202B_200C_202C_206A_206C_206C_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return QualitySettings.blendWeights;
	}

	static void _202A_200F_202C_206D_206E_200F_202E_200F_206F_200B_206A_206F_202C_206C_206A_200B_206B_206A_206F_206A_202D_206B_200E_206E_200D_206B_200D_206C_206F_202B_202E_206F_200C_200C_200E_202A_206F_206D_206D_206D_202E(int P_0)
	{
		QualitySettings.pixelLightCount = P_0;
	}

	static void _202C_200B_200C_206F_206B_206F_206D_202A_206C_206B_206E_206C_202A_206C_200F_206B_200F_206B_206D_200E_200E_200C_200F_206A_206E_206D_200C_206B_200E_202B_202D_206C_200C_202A_200D_200E_206A_202C_200F_206C_202E(ShadowProjection P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		QualitySettings.shadowProjection = P_0;
	}

	static void _202B_202D_202D_202B_206B_200B_200F_202E_202C_200D_206A_206A_200C_200B_206F_206A_202A_200E_206D_200B_202D_200D_206F_206E_202A_206C_202C_206D_206D_200C_206C_206A_206B_206C_200D_200F_206D_202C_206A_200C_202E(int P_0)
	{
		QualitySettings.shadowCascades = P_0;
	}

	static void _206C_200C_206C_206D_202E_206C_202A_200E_202E_200C_200B_206F_206D_200B_206D_202B_200C_200C_200F_202E_200D_206B_206F_200F_206E_206D_200C_202B_202B_200F_206C_206E_206F_202B_200F_202C_206E_206A_200D_200E_202E(float P_0)
	{
		QualitySettings.shadowDistance = P_0;
	}

	static void _202E_202D_202D_202A_206D_206E_202B_200E_206C_206B_202D_206B_200B_206C_200D_200F_200C_202E_206B_200D_200C_206F_200C_202C_206E_202C_202D_206F_206F_200E_200B_202C_202C_206A_200C_206D_200D_206F_200F_206F_202E(float P_0)
	{
		QualitySettings.shadowNearPlaneOffset = P_0;
	}

	static void _202A_206C_200B_206E_202C_200F_206A_206D_206D_202E_206E_206C_200C_206C_206F_200F_202B_206B_200F_206F_200F_200B_206D_206E_206C_200D_200F_206F_200C_202E_202D_200E_206D_206A_206A_200B_206C_200E_200E_200C_202E(float P_0)
	{
		QualitySettings.shadowCascade2Split = P_0;
	}

	static void _202E_206C_202B_206C_200F_202B_200E_200D_200C_206E_206A_206E_200E_202E_206F_202D_202A_206C_206A_202D_206C_200B_202C_202D_206A_206C_200E_206F_202D_202C_206D_206A_200F_202A_200C_200B_206B_202B_202C_206C_202E(Vector3 P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		QualitySettings.shadowCascade4Split = P_0;
	}

	static void _200C_202B_206F_206D_200D_206F_206A_206C_206B_200F_200F_200E_206D_206C_206A_200D_206B_200F_202B_206B_202A_206F_206A_202D_202E_200E_200C_202E_206B_202D_206B_202E_206D_206E_202A_200D_200B_206E_202E_202A_202E(int P_0)
	{
		QualitySettings.masterTextureLimit = P_0;
	}

	static void _200D_200E_202D_206F_202D_200E_206F_206B_206D_202A_202A_206B_202C_202B_206A_206C_200C_202C_202A_200F_202B_200F_200F_206D_200C_202D_200D_200D_200F_202D_200C_202B_202C_200F_200D_206D_202E_200B_202D_202E(AnisotropicFiltering P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		QualitySettings.anisotropicFiltering = P_0;
	}

	static void _202A_206D_200C_206E_206C_200E_206F_200B_206E_200D_200D_206C_206B_202E_206E_206E_206E_202B_202B_202E_200E_206C_206C_206C_200C_206E_202A_200D_202C_206F_200F_202E_206E_206D_200D_206A_206B_206A_202A_206F_202E(float P_0)
	{
		QualitySettings.lodBias = P_0;
	}

	static void _202C_202C_200C_206F_202A_202D_206B_206B_202C_202B_206F_202A_206D_200E_200D_202C_200E_206B_206E_202C_200B_200F_202D_200D_206A_206B_202A_202E_202B_202A_202D_200E_200C_206C_206B_200D_202E_206D_202E_200C_202E(int P_0)
	{
		QualitySettings.maximumLODLevel = P_0;
	}

	static void _202B_202B_202A_202A_206F_202C_200B_206F_202C_206C_200D_200C_202B_206C_200F_200B_202E_206D_206F_202C_206B_200D_200C_200B_202C_200C_206E_206A_200B_206B_200D_202B_206B_200E_202A_200B_206C_200F_206F_202E_202E(int P_0)
	{
		QualitySettings.particleRaycastBudget = P_0;
	}

	static void _200C_200B_200E_206A_202E_200D_202A_206E_202B_206D_200D_202B_200E_206F_206A_202D_202E_206A_202B_206D_200D_206E_202D_206F_200D_202B_206F_206D_206C_200C_206B_202B_206D_200C_206E_206C_200B_206B_202E_200F_202E(bool P_0)
	{
		QualitySettings.softVegetation = P_0;
	}

	static void _206B_200C_200B_200D_202E_206A_202B_206B_206C_202D_202E_206A_200B_202C_202B_200F_206A_202C_200C_206B_202A_202C_206F_206A_200E_202E_200E_206F_202B_206D_200F_202C_206D_200D_206E_200B_200D_200D_200F_202B_202E(bool P_0)
	{
		QualitySettings.realtimeReflectionProbes = P_0;
	}

	static void _202A_202E_206F_200D_206F_206D_200F_202D_202E_202E_202B_202B_202E_206E_200C_202E_202D_206C_200D_202D_200B_206B_206D_200E_206B_206E_202D_200B_206B_202D_202C_206D_200F_202D_202E_206A_200F_200C_206E_202A_202E(bool P_0)
	{
		QualitySettings.billboardsFaceCameraPosition = P_0;
	}

	static void _206B_200E_202C_206F_206C_206F_200E_206E_202A_202A_200F_206E_206B_202D_200E_206A_200C_202B_206D_202B_202C_206B_200D_202E_202A_206D_202D_206A_202B_206D_206C_200C_206D_206A_206C_200E_200B_200D_206C_206B_202E(int P_0)
	{
		QualitySettings.maxQueuedFrames = P_0;
	}

	static void _206E_202D_200C_200C_200F_200D_206E_206D_200E_206F_206C_206E_202A_206C_206E_206F_200E_202D_200D_206E_202D_206D_206B_200E_206A_200D_202E_206F_200B_206A_202B_200B_202D_200F_202C_200D_200D_202A_200C_206C_202E(int P_0)
	{
		QualitySettings.vSyncCount = P_0;
	}

	static void _200F_202D_200B_200C_200B_200D_202E_200C_202A_202C_202B_206E_200C_206B_200D_202D_202C_200C_206E_206E_202B_200D_202D_202D_200D_202C_206A_206D_200B_200C_202A_200B_206D_200C_206D_200D_200E_202D_200C_206B_202E(int P_0)
	{
		QualitySettings.antiAliasing = P_0;
	}

	static void _206E_200E_202B_200E_200F_200D_206B_202B_200F_202B_200C_206D_206B_200D_200C_202C_202A_202D_200D_200B_202E_202C_206C_200C_202D_206D_200F_202E_200F_200D_202D_202D_202B_202D_200B_200F_202E_200E_200B_202E_202E(BlendWeights P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		QualitySettings.blendWeights = P_0;
	}

	static int _200C_202D_200E_206C_202C_202D_200C_206A_200E_206B_206E_202E_202B_200E_206E_206D_200B_200D_206A_206C_202A_200C_200F_202E_206A_202C_200E_202E_200E_200F_202D_206D_206A_202C_200E_206F_202E_200B_202C_206A_202E()
	{
		return QualitySettings.GetQualityLevel();
	}

	static void _206F_206C_206A_202E_206A_200B_200E_206A_206E_200D_200C_202B_202A_206B_206A_200D_206B_202E_206D_200F_200F_202B_200C_206A_200F_200E_202B_202B_202A_202C_200F_206E_200B_200E_202B_200B_206A_200F_200B_206E_202E(int P_0)
	{
		QualitySettings.SetQualityLevel(P_0);
	}

	static void _202B_206C_206B_202A_206E_202C_200C_206E_202A_200B_200D_206E_202A_202A_206D_202E_206A_200F_206D_206D_206E_202B_200B_200C_206C_202C_206C_202E_206C_200B_202A_200F_206A_200F_200F_202B_206B_202B_200C_200C_202E(int P_0, bool P_1)
	{
		QualitySettings.SetQualityLevel(P_0, P_1);
	}

	static void _200D_202D_200E_200C_206C_202B_202A_206D_200B_206D_202D_200D_200C_202B_202B_206F_202D_200B_200B_206A_200F_202D_206C_202B_206E_202E_206F_202D_206E_202B_206C_202E_202D_206F_206C_200C_200E_206F_202B_206D_202E()
	{
		QualitySettings.IncreaseLevel();
	}

	static void _206E_200B_206D_200C_202D_206B_202E_206D_202E_202D_202D_206F_200F_206D_206F_202D_200C_202C_202C_202D_202E_206E_206D_206B_202E_202E_206A_202C_202E_202E_202C_202B_202C_200C_200E_206F_200F_200E_200E_202D_202E(bool P_0)
	{
		QualitySettings.IncreaseLevel(P_0);
	}

	static void _200E_202C_202A_206C_206C_200B_206F_206C_202E_200C_206B_200E_202C_206D_200E_206B_202C_202A_200C_202C_202E_200D_202D_206D_200E_206D_206A_206E_206F_202D_206E_206C_206D_202C_202E_200E_202C_206C_206D_202B_202E()
	{
		QualitySettings.DecreaseLevel();
	}

	static void _206B_202C_202D_206D_206E_202C_202D_200B_200D_202E_206B_206C_206B_206B_200D_206B_202A_206C_200E_200B_206D_206A_202A_206C_202E_202A_202B_206B_200E_206A_202E_202B_202B_200E_200C_200D_202B_206D_206A_200F_202E(bool P_0)
	{
		QualitySettings.DecreaseLevel(P_0);
	}

	static bool _206B_202D_200F_206E_202A_200B_202C_200F_200C_206F_200E_202E_200B_202C_206A_200C_200D_202C_200D_202E_202A_206F_206F_206C_202C_206A_200B_200B_200F_206D_206C_206C_202D_202C_200B_206C_202A_206A_202C_206E_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}
}
