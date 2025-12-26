using System;
using LuaInterface;
using UnityEngine;

public class PhysicsWrap
{
	private static Type classType = _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(Physics).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[15]
		{
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2445138620u), Raycast),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3571921649u), RaycastAll),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4128858104u), Linecast),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2993784803u), OverlapSphere),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3670993002u), CapsuleCast),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2490907190u), SphereCast),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(250420333u), CapsuleCastAll),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3040518468u), SphereCastAll),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3932331876u), CheckSphere),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1010681717u), CheckCapsule),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2380100636u), IgnoreCollision),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4024627570u), IgnoreLayerCollision),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2905997613u), GetIgnoreLayerCollision),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1621874631u), _206A_206D_206B_202C_202B_200E_200E_206D_206E_202C_202B_206D_206B_200B_206E_202E_206E_200B_206B_200F_200B_206C_206C_206A_206C_202D_200E_202A_206E_206F_206F_206C_202D_202E_200E_202A_206C_206E_206E_206C_202E),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(215375861u), GetClassType)
		};
		LuaField[] fields = new LuaField[9]
		{
			new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3583638633u), get_IgnoreRaycastLayer, null),
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(875600185u), get_DefaultRaycastLayers, null),
			new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(651523709u), get_AllLayers, null),
			new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(67444121u), get_gravity, set_gravity),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3035260423u), get_defaultContactOffset, set_defaultContactOffset),
			new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4023109131u), get_bounceThreshold, set_bounceThreshold),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3904270006u), get_solverIterationCount, set_solverIterationCount),
			new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1371150330u), get_sleepThreshold, set_sleepThreshold),
			new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3504776987u), get_queriesHitTriggers, set_queriesHitTriggers)
		};
		while (true)
		{
			int num = -915965961;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -625367848)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_042b;
				case 2u:
					return;
				}
				break;
				IL_042b:
				LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3116719177u), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(Physics).TypeHandle), regs, fields, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(object).TypeHandle));
				num = ((int)num2 * -1553331766) ^ 0x24E0D2D3;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _206A_206D_206B_202C_202B_200E_200E_206D_206E_202C_202B_206D_206B_200B_206E_202E_206E_200B_206B_200F_200B_206C_206C_206A_206C_202D_200E_202A_206E_206F_206F_206C_202D_202E_200E_202A_206C_206E_206E_206C_202E(IntPtr P_0)
	{
		int num = LuaDLL.lua_gettop(P_0);
		Physics o = default(Physics);
		while (true)
		{
			int num2 = 2077510556;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x5FAD25FB)) % 6)
				{
				case 0u:
					break;
				case 1u:
				{
					int num4;
					int num5;
					if (num == 0)
					{
						num4 = -1751791212;
						num5 = num4;
					}
					else
					{
						num4 = -1395404515;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num3 * -1707443931);
					continue;
				}
				case 2u:
					o = _200E_206F_202D_200D_206A_206B_200D_206F_202B_202C_206C_206A_202E_206A_206E_200C_206A_200E_206E_202D_200D_202B_206F_200E_202E_206B_200F_200D_202D_206B_202A_200D_202B_200B_206D_206F_200F_200E_206A_206A_202E();
					num2 = (int)((num3 * 1741468656) ^ 0x35394DE);
					continue;
				case 5u:
					LuaDLL.luaL_error(P_0, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2959673484u));
					num2 = 1672439699;
					continue;
				case 3u:
					LuaScriptMgr.PushObject(P_0, o);
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
	private static int get_IgnoreRaycastLayer(IntPtr L)
	{
		LuaScriptMgr.Push(L, 4);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_DefaultRaycastLayers(IntPtr L)
	{
		LuaScriptMgr.Push(L, -5);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_AllLayers(IntPtr L)
	{
		LuaScriptMgr.Push(L, -1);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_gravity(IntPtr L)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr.Push(L, _202A_202C_200F_206B_202D_206D_206B_200F_202B_202B_200D_200D_206B_200E_200D_206B_206A_200F_206C_202C_206E_200C_206E_202A_202B_202B_200E_206A_202D_202E_206A_202D_206E_202C_206C_206C_202A_202C_202A_202E_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_defaultContactOffset(IntPtr L)
	{
		LuaScriptMgr.Push(L, _206E_206E_200D_200F_200F_202C_200E_202E_206B_202D_202B_200D_206B_200C_200F_206E_206E_206F_206F_206F_200F_200D_202E_200C_200E_200F_202E_200F_202E_206C_206B_202E_206F_206A_206E_200B_206B_206E_202B_200E_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_bounceThreshold(IntPtr L)
	{
		LuaScriptMgr.Push(L, _202A_200D_202A_206F_200B_200E_206B_206C_200E_206A_200D_206F_202A_202D_200C_200F_200C_202D_200B_200E_206C_200C_202E_202C_206F_206D_202C_200C_206B_206A_200D_206E_202C_206B_206D_206C_200D_202D_202D_206D_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_solverIterationCount(IntPtr L)
	{
		LuaScriptMgr.Push(L, _200C_206B_206A_200B_206B_202C_200D_202B_206D_200E_202D_202A_206E_202A_202E_200D_206F_206B_202C_206C_200D_206F_206E_200C_202C_200C_206F_206B_200E_200D_202A_200B_202B_202A_206F_202A_202E_206D_202A_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_sleepThreshold(IntPtr L)
	{
		LuaScriptMgr.Push(L, _206E_206F_202E_206A_202E_200C_206C_202C_200F_202A_206D_206C_206A_206F_200C_206E_206B_202B_206C_206E_206B_206D_206B_200C_206E_200C_206E_200E_202B_206A_206B_202D_202A_202B_206B_200F_202C_202A_202E_200F_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_queriesHitTriggers(IntPtr L)
	{
		LuaScriptMgr.Push(L, _206D_200C_202D_206A_202D_202D_206F_200D_200E_200B_206B_202C_200E_206C_206F_202B_200C_200D_200E_206C_202A_200E_206D_200C_202B_200E_206D_200D_200E_200B_200B_200F_206E_202E_200D_200B_200C_200C_200D_206A_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_gravity(IntPtr L)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_200F_206D_206E_206C_200F_202C_202D_200E_202D_206B_206F_200E_202A_202A_206E_202E_202E_206D_202B_206C_202A_206E_200F_206D_202A_202D_200B_206F_206C_206F_202D_200F_202E_200F_206A_202D_200C_202A_202E_200D_202E(LuaScriptMgr.GetVector3(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_defaultContactOffset(IntPtr L)
	{
		_200B_202D_206F_206E_202C_206F_206E_202C_206A_206D_206E_206F_206D_200E_200F_206A_202D_200B_200B_202D_202C_206A_200F_202B_206D_206F_200E_200B_200B_206F_200D_200C_202B_206B_206F_202D_200C_202D_202E_202E((float)LuaScriptMgr.GetNumber(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_bounceThreshold(IntPtr L)
	{
		_202D_200B_206A_202C_200D_206E_200D_200B_202C_206B_206B_202E_200E_206A_206B_202E_206A_202E_200D_206C_202A_200C_206C_202D_200F_202D_206F_206B_206F_206A_206A_206B_202C_200B_206C_202A_206D_200C_202C_200F_202E((float)LuaScriptMgr.GetNumber(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_solverIterationCount(IntPtr L)
	{
		_200D_206D_200E_206F_200F_200D_206B_206D_206A_206C_206B_206E_202E_202D_206F_202C_202C_200E_202A_202B_202A_202A_200F_206E_206B_206C_200C_200F_206B_202E_206C_202B_202E_200E_206C_202A_202C_202E_200F_202A_202E((int)LuaScriptMgr.GetNumber(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_sleepThreshold(IntPtr L)
	{
		_200B_202A_202A_200B_202B_206A_202D_200F_200D_200E_206B_200B_202A_200F_206E_200E_202D_202A_200D_202E_206C_206B_202A_200D_200F_200E_200E_206E_202A_206A_200F_202D_200F_202B_200F_200F_206E_206D_200B_206D_202E((float)LuaScriptMgr.GetNumber(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_queriesHitTriggers(IntPtr L)
	{
		_200C_206A_200B_200E_200F_202C_206D_206E_206B_200F_200D_202D_206D_206F_200E_200F_206F_206B_206D_202D_200F_200F_202B_206F_200D_206B_202B_206A_206E_200E_200E_206D_200B_206F_202C_206B_202E_200D_206F_202B_202E(LuaScriptMgr.GetBoolean(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Raycast(IntPtr L)
	{
		//IL_09e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_0726: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0905: Unknown result type (might be due to invalid IL or missing references)
		//IL_090a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0866: Unknown result type (might be due to invalid IL or missing references)
		//IL_0868: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_1002: Unknown result type (might be due to invalid IL or missing references)
		//IL_1007: Unknown result type (might be due to invalid IL or missing references)
		//IL_089b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be0: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_0750: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07df: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0832: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0952: Unknown result type (might be due to invalid IL or missing references)
		//IL_0957: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0982: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_101d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b51: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0921: Unknown result type (might be due to invalid IL or missing references)
		//IL_0926: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		int num = LuaDLL.lua_gettop(L);
		if (num == 1)
		{
			goto IL_000e;
		}
		goto IL_0d42;
		IL_000e:
		int num2 = -205492732;
		goto IL_0013;
		IL_0013:
		float num30 = default(float);
		Ray ray6 = default(Ray);
		RaycastHit hit4 = default(RaycastHit);
		float num24 = default(float);
		int num25 = default(int);
		QueryTriggerInteraction val3 = default(QueryTriggerInteraction);
		bool b4 = default(bool);
		Ray ray8 = default(Ray);
		bool b3 = default(bool);
		Vector3 vector12 = default(Vector3);
		Vector3 vector13 = default(Vector3);
		float num38 = default(float);
		int num39 = default(int);
		int num11 = default(int);
		bool b = default(bool);
		RaycastHit hit = default(RaycastHit);
		Vector3 vector4 = default(Vector3);
		float num5 = default(float);
		Vector3 vector8 = default(Vector3);
		Ray ray5 = default(Ray);
		float num18 = default(float);
		Vector3 vector3 = default(Vector3);
		bool b2 = default(bool);
		Vector3 vector16 = default(Vector3);
		Vector3 vector7 = default(Vector3);
		RaycastHit hit8 = default(RaycastHit);
		Vector3 vector14 = default(Vector3);
		Vector3 vector15 = default(Vector3);
		int num6 = default(int);
		bool b11 = default(bool);
		RaycastHit hit3 = default(RaycastHit);
		float num7 = default(float);
		float num14 = default(float);
		int num15 = default(int);
		bool b5 = default(bool);
		Ray ray4 = default(Ray);
		RaycastHit hit7 = default(RaycastHit);
		Vector3 vector9 = default(Vector3);
		float num31 = default(float);
		int num32 = default(int);
		Vector3 vector11 = default(Vector3);
		Vector3 vector10 = default(Vector3);
		Ray ray = default(Ray);
		Vector3 vector = default(Vector3);
		int num19 = default(int);
		RaycastHit hit6 = default(RaycastHit);
		bool b12 = default(bool);
		RaycastHit hit5 = default(RaycastHit);
		bool b15 = default(bool);
		bool b14 = default(bool);
		Vector3 vector6 = default(Vector3);
		float num35 = default(float);
		QueryTriggerInteraction val4 = default(QueryTriggerInteraction);
		Ray ray3 = default(Ray);
		float num8 = default(float);
		QueryTriggerInteraction val2 = default(QueryTriggerInteraction);
		Vector3 vector5 = default(Vector3);
		bool b8 = default(bool);
		RaycastHit hit2 = default(RaycastHit);
		float num4 = default(float);
		Vector3 vector2 = default(Vector3);
		bool b6 = default(bool);
		bool b7 = default(bool);
		Ray ray2 = default(Ray);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ -966151702)) % 109)
			{
			case 40u:
				break;
			case 44u:
				num30 = (float)LuaDLL.lua_tonumber(L, 2);
				num2 = ((int)num3 * -1449683296) ^ -1297834554;
				continue;
			case 84u:
			{
				bool b10 = _202A_206C_200B_206A_206E_200E_206E_202E_206D_202A_206F_206F_200E_206E_202E_206D_200E_206D_202C_206A_206D_206F_206D_206A_202C_200F_202E_206E_206F_206F_200E_202E_200C_202E_202A_202C_206A_200F_200E_206E_202E(ray6, ref hit4, num24, num25, val3);
				LuaScriptMgr.Push(L, b10);
				LuaScriptMgr.Push(L, hit4);
				num2 = (int)((num3 * 7593242) ^ 0x56C28FD);
				continue;
			}
			case 6u:
				goto IL_022e;
			case 3u:
			{
				int num44;
				int num45;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), null, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(int).TypeHandle)))
				{
					num44 = 1402085717;
					num45 = num44;
				}
				else
				{
					num44 = 1306811576;
					num45 = num44;
				}
				num2 = num44 ^ (int)(num3 * 855820496);
				continue;
			}
			case 37u:
				b4 = _206B_200F_206B_206F_200C_202E_206C_200B_206A_200B_202D_206A_206C_200D_202D_206A_200E_206C_206A_202C_206C_200D_200E_206B_200C_202D_202A_206F_206F_202D_202E_206A_206B_206D_206C_200B_202B_202E_200D_200C_202E(ray8, num30);
				num2 = ((int)num3 * -1393752688) ^ 0x9CCB799;
				continue;
			case 36u:
				b3 = _206B_202D_200E_206C_200C_206E_206B_200D_200E_200B_206F_202C_202C_200E_202C_202A_202A_200E_202E_202D_206D_206D_200E_206C_206B_202C_200B_200B_206E_202E_202B_200E_206C_206E_200C_200F_200D_200D_206B_206F_202E(vector12, vector13, num38, num39);
				num2 = (int)(num3 * 1632054188) ^ -964471663;
				continue;
			case 57u:
			{
				int num28;
				int num29;
				if (LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), null))
				{
					num28 = -1399191119;
					num29 = num28;
				}
				else
				{
					num28 = -1166021111;
					num29 = num28;
				}
				num2 = num28 ^ ((int)num3 * -1892871023);
				continue;
			}
			case 55u:
				num11 = (int)LuaDLL.lua_tonumber(L, 3);
				num2 = ((int)num3 * -1862194271) ^ -1198439100;
				continue;
			case 11u:
				LuaScriptMgr.Push(L, b);
				LuaScriptMgr.Push(L, hit);
				return 2;
			case 10u:
				vector4 = LuaScriptMgr.GetVector3(L, 2);
				num5 = (float)LuaDLL.lua_tonumber(L, 3);
				num2 = (int)((num3 * 448869583) ^ 0x535D315E);
				continue;
			case 108u:
				vector8 = LuaScriptMgr.GetVector3(L, 1);
				num2 = ((int)num3 * -1011992523) ^ 0x5580C9CE;
				continue;
			case 85u:
				goto IL_0394;
			case 106u:
				ray5 = LuaScriptMgr.GetRay(L, 1);
				num18 = (float)LuaDLL.lua_tonumber(L, 2);
				num2 = (int)(num3 * 1343537236) ^ -1455963824;
				continue;
			case 1u:
				return 1;
			case 97u:
				return 1;
			case 103u:
				vector3 = LuaScriptMgr.GetVector3(L, 1);
				num2 = ((int)num3 * -1263710927) ^ 0x52EBE62B;
				continue;
			case 43u:
				b2 = _200B_206B_200F_200D_202C_200B_206B_200B_200D_202E_202C_202E_202E_206F_206B_206A_200D_206A_200E_206A_202D_202E_202E_200C_206F_206B_202A_202D_202C_206F_206F_206E_206B_200D_206C_206B_200F_202D_206D_206F_202E(vector16, vector7, ref hit8);
				num2 = ((int)num3 * -1380249084) ^ -1241329876;
				continue;
			case 31u:
				vector14 = LuaScriptMgr.GetVector3(L, 1);
				vector15 = LuaScriptMgr.GetVector3(L, 2);
				num2 = ((int)num3 * -1166829503) ^ 0x5E5E7B3B;
				continue;
			case 88u:
				goto IL_045d;
			case 26u:
				num6 = (int)LuaDLL.lua_tonumber(L, 4);
				num2 = ((int)num3 * -392232578) ^ -1828747359;
				continue;
			case 58u:
			{
				int num40;
				int num41;
				if (LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), null, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle)))
				{
					num40 = -923110053;
					num41 = num40;
				}
				else
				{
					num40 = -597066035;
					num41 = num40;
				}
				num2 = num40 ^ (int)(num3 * 363235819);
				continue;
			}
			case 20u:
				vector7 = LuaScriptMgr.GetVector3(L, 2);
				num2 = ((int)num3 * -1595050332) ^ -319483353;
				continue;
			case 77u:
			{
				int num22;
				int num23;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), null))
				{
					num22 = -1806615413;
					num23 = num22;
				}
				else
				{
					num22 = -520003686;
					num23 = num22;
				}
				num2 = num22 ^ ((int)num3 * -324927073);
				continue;
			}
			case 102u:
				LuaScriptMgr.Push(L, b11);
				return 1;
			case 83u:
				return 1;
			case 100u:
				LuaScriptMgr.Push(L, hit3);
				return 2;
			case 2u:
				num7 = (float)LuaDLL.lua_tonumber(L, 3);
				num2 = ((int)num3 * -248865197) ^ 0x5F339746;
				continue;
			case 90u:
				num14 = (float)LuaDLL.lua_tonumber(L, 4);
				num15 = (int)LuaDLL.lua_tonumber(L, 5);
				num2 = ((int)num3 * -426462000) ^ 0x717DAB9A;
				continue;
			case 19u:
				LuaScriptMgr.Push(L, b5);
				return 1;
			case 22u:
				ray4 = LuaScriptMgr.GetRay(L, 1);
				num2 = (int)((num3 * 1665834105) ^ 0x61A62F8);
				continue;
			case 51u:
				goto IL_05f0;
			case 41u:
			{
				int num50;
				int num51;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), null, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle)))
				{
					num50 = -1041517356;
					num51 = num50;
				}
				else
				{
					num50 = -1644618133;
					num51 = num50;
				}
				num2 = num50 ^ (int)(num3 * 1780255905);
				continue;
			}
			case 17u:
			{
				int num48;
				int num49;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(int).TypeHandle)))
				{
					num48 = 441489933;
					num49 = num48;
				}
				else
				{
					num48 = 617081244;
					num49 = num48;
				}
				num2 = num48 ^ (int)(num3 * 88824563);
				continue;
			}
			case 30u:
			{
				int num46;
				int num47;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle)))
				{
					num46 = -687587556;
					num47 = num46;
				}
				else
				{
					num46 = -858228854;
					num47 = num46;
				}
				num2 = num46 ^ ((int)num3 * -870954528);
				continue;
			}
			case 104u:
				vector16 = LuaScriptMgr.GetVector3(L, 1);
				num2 = (int)((num3 * 1699223023) ^ 0x5C330F97);
				continue;
			case 69u:
				LuaScriptMgr.Push(L, hit7);
				num2 = (int)((num3 * 1558807100) ^ 0x214F0B40);
				continue;
			case 21u:
				num38 = (float)LuaDLL.lua_tonumber(L, 3);
				num2 = ((int)num3 * -1503826842) ^ -1568070544;
				continue;
			case 9u:
				vector9 = LuaScriptMgr.GetVector3(L, 2);
				num31 = (float)LuaScriptMgr.GetNumber(L, 4);
				num32 = (int)LuaScriptMgr.GetNumber(L, 5);
				num2 = (int)(num3 * 1409551299) ^ -1270726295;
				continue;
			case 39u:
				LuaScriptMgr.Push(L, hit8);
				return 2;
			case 92u:
				vector13 = LuaScriptMgr.GetVector3(L, 2);
				num2 = (int)(num3 * 1886048009) ^ -1285985409;
				continue;
			case 107u:
				num24 = (float)LuaDLL.lua_tonumber(L, 3);
				num2 = ((int)num3 * -826167194) ^ 0xAF3A2A7;
				continue;
			case 61u:
				vector11 = LuaScriptMgr.GetVector3(L, 2);
				num2 = (int)((num3 * 63365758) ^ 0x7D073F94);
				continue;
			case 46u:
				vector10 = LuaScriptMgr.GetVector3(L, 1);
				num2 = (int)((num3 * 170509805) ^ 0x3F944E8B);
				continue;
			case 48u:
				ray = LuaScriptMgr.GetRay(L, 1);
				num2 = ((int)num3 * -127966800) ^ 0x74D828C4;
				continue;
			case 95u:
				vector = LuaScriptMgr.GetVector3(L, 1);
				num2 = ((int)num3 * -1285419671) ^ -938751090;
				continue;
			case 27u:
				num19 = (int)LuaDLL.lua_tonumber(L, 3);
				num2 = ((int)num3 * -69768423) ^ 0x50E95C3F;
				continue;
			case 60u:
				LuaScriptMgr.Push(L, hit6);
				return 2;
			case 91u:
				goto IL_084e;
			case 18u:
			{
				bool b16 = _206D_202C_202A_202E_200F_206F_200E_200D_200C_206F_200F_202B_202C_200E_200E_206C_202C_200D_200F_202A_206B_202C_202C_206F_200D_202E_202C_202C_200E_202D_200F_206B_202E_200B_206A_202C_202E_206B_202E_206F_202E(vector14, vector15, ref hit7, num14, num15);
				LuaScriptMgr.Push(L, b16);
				num2 = ((int)num3 * -1581804592) ^ -277776039;
				continue;
			}
			case 28u:
				LuaScriptMgr.Push(L, b12);
				LuaScriptMgr.Push(L, hit5);
				num2 = ((int)num3 * -2096421754) ^ -2065917659;
				continue;
			case 89u:
				goto IL_08b5;
			case 35u:
				LuaScriptMgr.Push(L, b15);
				num2 = ((int)num3 * -716545797) ^ -816865943;
				continue;
			case 93u:
				LuaScriptMgr.Push(L, b14);
				num2 = ((int)num3 * -97852990) ^ 0x79DC645D;
				continue;
			case 13u:
				vector6 = LuaScriptMgr.GetVector3(L, 2);
				num2 = (int)(num3 * 1847981819) ^ -1502660125;
				continue;
			case 105u:
				vector12 = LuaScriptMgr.GetVector3(L, 1);
				num2 = ((int)num3 * -808195826) ^ -2070456086;
				continue;
			case 98u:
				return 2;
			case 63u:
				ray8 = LuaScriptMgr.GetRay(L, 1);
				num2 = (int)(num3 * 593507198) ^ -917031263;
				continue;
			case 70u:
				num25 = (int)LuaDLL.lua_tonumber(L, 4);
				val3 = (QueryTriggerInteraction)(int)LuaScriptMgr.GetLuaObject(L, 5);
				num2 = (int)((num3 * 2009920130) ^ 0x701D6513);
				continue;
			case 64u:
				num39 = (int)LuaDLL.lua_tonumber(L, 4);
				num2 = ((int)num3 * -1585650606) ^ 0x1CA91F2E;
				continue;
			case 56u:
				num35 = (float)LuaDLL.lua_tonumber(L, 3);
				num2 = (int)((num3 * 326296459) ^ 0x6362F984);
				continue;
			case 0u:
				val4 = (QueryTriggerInteraction)(int)LuaScriptMgr.GetNetObject(L, 6, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(QueryTriggerInteraction).TypeHandle));
				num2 = ((int)num3 * -1380259096) ^ 0x25291968;
				continue;
			case 86u:
				ray6 = LuaScriptMgr.GetRay(L, 1);
				num2 = (int)(num3 * 1149497924) ^ -1074979814;
				continue;
			case 5u:
			{
				int num42;
				int num43;
				if (LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(int).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(QueryTriggerInteraction).TypeHandle)))
				{
					num42 = 744561135;
					num43 = num42;
				}
				else
				{
					num42 = 1756737565;
					num43 = num42;
				}
				num2 = num42 ^ ((int)num3 * -1083654779);
				continue;
			}
			case 8u:
			{
				int num36;
				int num37;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle)))
				{
					num36 = 1527011111;
					num37 = num36;
				}
				else
				{
					num36 = 352301530;
					num37 = num36;
				}
				num2 = num36 ^ (int)(num3 * 419701902);
				continue;
			}
			case 45u:
				b11 = _202E_202C_202E_200F_206C_202A_206A_206C_202C_206B_206B_206B_202E_206E_200C_206A_202C_206A_202C_206C_200B_202C_202C_206C_202D_202B_202D_202B_206C_202A_200F_202E_206E_202A_202A_206C_206D_202C_200B_202D_202E(ray3, num8, num11, val2);
				num2 = (int)(num3 * 221217545) ^ -735378850;
				continue;
			case 52u:
			{
				int num34 = (int)LuaDLL.lua_tonumber(L, 4);
				b15 = _200E_206E_206D_200D_200B_200B_206D_200D_200B_200D_206E_206B_206B_202E_200D_200D_200B_206D_206B_202B_200F_202D_206F_202C_200B_202A_202D_202D_200D_202C_202C_206E_200F_202D_206F_202D_206A_206C_200B_206A_202E(ray4, ref hit6, num35, num34);
				num2 = (int)(num3 * 1048125595) ^ -665181258;
				continue;
			}
			case 66u:
				goto IL_0aee;
			case 96u:
			{
				float num33 = (float)LuaDLL.lua_tonumber(L, 3);
				b14 = _206B_202A_206C_202C_202C_202A_206F_206A_202B_206A_202D_202A_206D_200B_206F_202B_200E_200B_202C_206D_200E_206C_202C_200C_200C_206F_200C_202E_202D_200F_206D_202B_206D_200E_200C_200B_206C_200F_202D_206A_202E(vector10, vector11, num33);
				num2 = (int)((num3 * 1047686016) ^ 0x50BA020D);
				continue;
			}
			case 32u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1628933806u));
				num2 = -1668022310;
				continue;
			case 82u:
				vector5 = LuaScriptMgr.GetVector3(L, 1);
				num2 = ((int)num3 * -577200018) ^ -1508218105;
				continue;
			case 73u:
			{
				Ray ray7 = LuaScriptMgr.GetRay(L, 1);
				bool b13 = _202C_200D_200E_206B_206B_200B_202E_202D_200F_200C_200B_202C_200C_200E_202B_200E_206D_202A_206F_206D_202E_206D_200D_206C_200E_200F_202D_200F_202C_202E_202D_200D_202B_206A_200D_206C_206B_202B_202B_200F_202E(ray7);
				LuaScriptMgr.Push(L, b13);
				return 1;
			}
			case 79u:
				return 1;
			case 87u:
				goto IL_0ba6;
			case 76u:
				goto IL_0bbe;
			case 29u:
				b12 = _200F_206E_202A_206F_202E_200D_206A_206E_202C_202A_200C_200E_202C_206C_206B_206D_206C_206F_200B_206D_200E_206C_200B_202D_200C_206A_206E_200D_206C_200F_206B_200E_200F_200C_206B_206B_206E_200F_202B_206E_202E(vector8, vector9, ref hit5, num31, num32, val4);
				num2 = (int)((num3 * 1408405090) ^ 0x62D8100E);
				continue;
			case 50u:
				goto IL_0bfc;
			case 74u:
				return 1;
			case 72u:
			{
				int num26;
				int num27;
				if (LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), null, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(int).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(QueryTriggerInteraction).TypeHandle)))
				{
					num26 = 485200166;
					num27 = num26;
				}
				else
				{
					num26 = 1913121857;
					num27 = num26;
				}
				num2 = num26 ^ ((int)num3 * -780737635);
				continue;
			}
			case 7u:
				b8 = _202D_200D_202C_200F_200D_206D_202D_202C_206B_202A_206C_202C_206E_206A_202B_206C_200F_206E_206A_206F_202E_202B_200E_206B_200F_206D_206E_202D_206B_202E_206D_202E_202B_202B_202E_206F_200D_200B_206D_206B_202E(vector5, vector6, ref hit2, num4);
				num2 = (int)((num3 * 1549730236) ^ 0x1DBB4AC5);
				continue;
			case 23u:
				goto IL_0c9a;
			case 49u:
				vector2 = LuaScriptMgr.GetVector3(L, 2);
				num2 = (int)(num3 * 1130398064) ^ -1641284646;
				continue;
			case 16u:
				goto IL_0cce;
			case 47u:
				goto IL_0ce6;
			case 42u:
			{
				int num20;
				int num21;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(int).TypeHandle)))
				{
					num20 = -1294537436;
					num21 = num20;
				}
				else
				{
					num20 = -277482224;
					num21 = num20;
				}
				num2 = num20 ^ ((int)num3 * -107594422);
				continue;
			}
			case 62u:
				goto IL_0d42;
			case 54u:
			{
				bool b9 = _200E_206F_200B_206D_200B_200B_202B_206A_206C_206D_202A_202E_202C_206A_202D_206A_200B_202C_206D_200C_200C_200C_200F_206D_206D_202B_200D_202D_206B_200B_202D_200F_200F_202A_200E_200D_206F_200F_202C_200C_202E(ray5, num18, num19);
				LuaScriptMgr.Push(L, b9);
				num2 = (int)(num3 * 2039955534) ^ -104918243;
				continue;
			}
			case 67u:
			{
				int num16;
				int num17;
				if (LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(int).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(QueryTriggerInteraction).TypeHandle)))
				{
					num16 = -838280825;
					num17 = num16;
				}
				else
				{
					num16 = -2024928826;
					num17 = num16;
				}
				num2 = num16 ^ (int)(num3 * 2023085928);
				continue;
			}
			case 80u:
			{
				int num12;
				int num13;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), null, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(int).TypeHandle)))
				{
					num12 = 1749306254;
					num13 = num12;
				}
				else
				{
					num12 = 160091098;
					num13 = num12;
				}
				num2 = num12 ^ ((int)num3 * -580230326);
				continue;
			}
			case 99u:
				LuaScriptMgr.Push(L, b6);
				num2 = ((int)num3 * -2090693087) ^ -1523086819;
				continue;
			case 59u:
				val2 = (QueryTriggerInteraction)(int)LuaScriptMgr.GetLuaObject(L, 4);
				num2 = ((int)num3 * -604454931) ^ -27508735;
				continue;
			case 101u:
				goto IL_0e5b;
			case 14u:
				LuaScriptMgr.Push(L, b7);
				num2 = ((int)num3 * -264153729) ^ -866133662;
				continue;
			case 33u:
				LuaScriptMgr.Push(L, b8);
				num2 = (int)((num3 * 658146049) ^ 0x41E95A32);
				continue;
			case 65u:
			{
				int num9;
				int num10;
				if (LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle)))
				{
					num9 = -629407754;
					num10 = num9;
				}
				else
				{
					num9 = -800361670;
					num10 = num9;
				}
				num2 = num9 ^ ((int)num3 * -461513229);
				continue;
			}
			case 53u:
				ray3 = LuaScriptMgr.GetRay(L, 1);
				num8 = (float)LuaDLL.lua_tonumber(L, 2);
				num2 = (int)(num3 * 827332886) ^ -1037198533;
				continue;
			case 12u:
				b7 = _206A_202D_202A_202A_202D_202E_202A_202D_206E_206F_200F_206C_200E_202E_206D_206D_200E_206B_206C_200C_206E_202E_202D_200E_202C_202D_200E_200B_206F_206F_206E_200B_206C_202D_202A_206D_206E_200D_206F_200D_202E(ray2, ref hit3, num7);
				num2 = (int)((num3 * 1524145741) ^ 0x647100CE);
				continue;
			case 4u:
				return 2;
			case 34u:
			{
				QueryTriggerInteraction val = (QueryTriggerInteraction)(int)LuaScriptMgr.GetLuaObject(L, 5);
				b6 = _202B_200D_206A_202E_202C_200F_202D_202E_206C_202D_202E_206E_200F_200E_202B_200E_206A_200F_206B_200C_200B_206D_202C_200F_202A_206D_206C_200E_202E_202A_200E_206A_206A_202E_200B_206B_206C_202D_206E_200C_202E(vector3, vector4, num5, num6, val);
				num2 = ((int)num3 * -387310577) ^ 0x790E4733;
				continue;
			}
			case 94u:
				return 2;
			case 68u:
				num4 = (float)LuaDLL.lua_tonumber(L, 4);
				num2 = (int)((num3 * 1616612356) ^ 0x5365A189);
				continue;
			case 71u:
				b5 = _200E_206B_202D_202C_200D_200C_202D_200E_202D_202E_200D_206C_202C_202B_206B_200E_202D_206C_200F_206E_200E_202B_202C_202D_200D_200D_206C_200F_200C_206F_200D_206A_206E_202C_206E_206E_202C_200F_206C_200D_202E(vector, vector2);
				num2 = ((int)num3 * -1205451354) ^ 0x6610DFF1;
				continue;
			case 75u:
				LuaScriptMgr.Push(L, b4);
				num2 = (int)((num3 * 762365517) ^ 0x9E59B80);
				continue;
			case 25u:
				LuaScriptMgr.Push(L, b3);
				num2 = (int)((num3 * 1669085821) ^ 0x4255638C);
				continue;
			case 24u:
				ray2 = LuaScriptMgr.GetRay(L, 1);
				num2 = (int)(num3 * 1786482422) ^ -1136701674;
				continue;
			case 81u:
				LuaScriptMgr.Push(L, hit2);
				return 2;
			case 38u:
				LuaScriptMgr.Push(L, b2);
				num2 = ((int)num3 * -730023425) ^ 0x6C4321A3;
				continue;
			case 15u:
				b = _202B_206E_206D_202C_200C_202B_200F_206F_206F_206C_200B_202C_206F_206F_202E_200E_200C_202A_200C_200B_202A_202D_200E_200E_206C_200B_200E_206F_200D_200F_200C_202C_200E_202E_200B_200E_202C_202E_202C_206D_202E(ray, ref hit);
				num2 = ((int)num3 * -348695374) ^ 0x780B311E;
				continue;
			default:
				return 0;
			}
			break;
			IL_0e5b:
			int num52;
			if (num == 4)
			{
				num2 = -105610726;
				num52 = num2;
			}
			else
			{
				num2 = -635266834;
				num52 = num2;
			}
			continue;
			IL_045d:
			int num53;
			if (num == 2)
			{
				num2 = -1335888565;
				num53 = num2;
			}
			else
			{
				num2 = -840447236;
				num53 = num2;
			}
			continue;
			IL_0bbe:
			int num54;
			if (num != 3)
			{
				num2 = -1589064666;
				num54 = num2;
			}
			else
			{
				num2 = -1609786539;
				num54 = num2;
			}
			continue;
			IL_0ce6:
			int num55;
			if (num == 4)
			{
				num2 = -514626908;
				num55 = num2;
			}
			else
			{
				num2 = -1064210345;
				num55 = num2;
			}
			continue;
			IL_08b5:
			int num56;
			if (num != 5)
			{
				num2 = -573546112;
				num56 = num2;
			}
			else
			{
				num2 = -658259297;
				num56 = num2;
			}
			continue;
			IL_05f0:
			int num57;
			if (num != 5)
			{
				num2 = -525680642;
				num57 = num2;
			}
			else
			{
				num2 = -336424983;
				num57 = num2;
			}
			continue;
			IL_0cce:
			int num58;
			if (num != 3)
			{
				num2 = -1938179989;
				num58 = num2;
			}
			else
			{
				num2 = -141852863;
				num58 = num2;
			}
			continue;
			IL_0ba6:
			int num59;
			if (num != 2)
			{
				num2 = -940473671;
				num59 = num2;
			}
			else
			{
				num2 = -1317638445;
				num59 = num2;
			}
			continue;
			IL_0394:
			int num60;
			if (num == 4)
			{
				num2 = -1042786415;
				num60 = num2;
			}
			else
			{
				num2 = -717734662;
				num60 = num2;
			}
			continue;
			IL_0c9a:
			int num61;
			if (num != 4)
			{
				num2 = -314642562;
				num61 = num2;
			}
			else
			{
				num2 = -1673287061;
				num61 = num2;
			}
			continue;
			IL_084e:
			int num62;
			if (num == 3)
			{
				num2 = -375823515;
				num62 = num2;
			}
			else
			{
				num2 = -690672837;
				num62 = num2;
			}
			continue;
			IL_0aee:
			int num63;
			if (num == 3)
			{
				num2 = -869496729;
				num63 = num2;
			}
			else
			{
				num2 = -427698458;
				num63 = num2;
			}
			continue;
			IL_0bfc:
			int num64;
			if (num == 6)
			{
				num2 = -1061958035;
				num64 = num2;
			}
			else
			{
				num2 = -1890760586;
				num64 = num2;
			}
			continue;
			IL_022e:
			int num65;
			if (num == 5)
			{
				num2 = -1790299929;
				num65 = num2;
			}
			else
			{
				num2 = -1319689275;
				num65 = num2;
			}
		}
		goto IL_000e;
		IL_0d42:
		int num66;
		if (num == 2)
		{
			num2 = -576174285;
			num66 = num2;
		}
		else
		{
			num2 = -728754868;
			num66 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int RaycastAll(IntPtr L)
	{
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_069e: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		int num = LuaDLL.lua_gettop(L);
		if (num == 1)
		{
			goto IL_000e;
		}
		goto IL_05a5;
		IL_000e:
		int num2 = -753887702;
		goto IL_0013;
		IL_0013:
		Vector3 vector3 = default(Vector3);
		Ray ray4 = default(Ray);
		RaycastHit[] o7 = default(RaycastHit[]);
		Vector3 vector2 = default(Vector3);
		float num11 = default(float);
		int num12 = default(int);
		QueryTriggerInteraction val2 = default(QueryTriggerInteraction);
		RaycastHit[] o2 = default(RaycastHit[]);
		Ray ray2 = default(Ray);
		float num7 = default(float);
		int num8 = default(int);
		RaycastHit[] o6 = default(RaycastHit[]);
		Vector3 vector7 = default(Vector3);
		Vector3 vector8 = default(Vector3);
		Vector3 vector5 = default(Vector3);
		Ray ray = default(Ray);
		Vector3 vector6 = default(Vector3);
		float num15 = default(float);
		RaycastHit[] o4 = default(RaycastHit[]);
		Vector3 vector = default(Vector3);
		float num9 = default(float);
		int num10 = default(int);
		Vector3 vector4 = default(Vector3);
		float num5 = default(float);
		int num6 = default(int);
		RaycastHit[] o3 = default(RaycastHit[]);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ -1715740782)) % 47)
			{
			case 46u:
				break;
			case 15u:
				vector3 = LuaScriptMgr.GetVector3(L, 2);
				num2 = ((int)num3 * -1455356602) ^ -517498748;
				continue;
			case 2u:
				ray4 = LuaScriptMgr.GetRay(L, 1);
				num2 = ((int)num3 * -225709346) ^ 0x6352015;
				continue;
			case 21u:
				LuaScriptMgr.PushArray(L, o7);
				num2 = ((int)num3 * -31884708) ^ 0x69D811A4;
				continue;
			case 11u:
				goto IL_0138;
			case 45u:
				vector2 = LuaScriptMgr.GetVector3(L, 1);
				num2 = ((int)num3 * -2074943374) ^ -1053161403;
				continue;
			case 9u:
			{
				RaycastHit[] o8 = _206A_206A_206F_202D_200B_200D_202A_202C_206F_206A_202D_206D_202D_202A_206E_200B_200E_202D_202B_200E_206F_206E_200B_200F_206C_202C_206F_206D_200F_202B_202A_206B_202A_202A_206E_202E_200D_200E_206A_202E_202E(ray4, num11, num12, val2);
				LuaScriptMgr.PushArray(L, o8);
				return 1;
			}
			case 28u:
				o2 = _206B_206A_200E_206D_200E_200F_202E_206A_206F_200D_206B_206C_206C_206A_206B_206F_206D_206B_200B_200F_200F_200D_200D_202D_202A_202B_206D_202E_206D_200F_206E_202A_206D_206B_200B_202C_200B_202C_206F_202E(ray2, num7, num8);
				num2 = ((int)num3 * -901162302) ^ -313531700;
				continue;
			case 19u:
			{
				int num20;
				int num21;
				if (LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(int).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(QueryTriggerInteraction).TypeHandle)))
				{
					num20 = 668189356;
					num21 = num20;
				}
				else
				{
					num20 = 692757333;
					num21 = num20;
				}
				num2 = num20 ^ ((int)num3 * -1352351487);
				continue;
			}
			case 33u:
				goto IL_0206;
			case 3u:
				LuaScriptMgr.PushArray(L, o6);
				num2 = (int)((num3 * 774995421) ^ 0x7D5F9EEA);
				continue;
			case 31u:
				vector7 = LuaScriptMgr.GetVector3(L, 1);
				vector8 = LuaScriptMgr.GetVector3(L, 2);
				num2 = (int)(num3 * 732891513) ^ -1886223925;
				continue;
			case 4u:
				return 1;
			case 0u:
				vector5 = LuaScriptMgr.GetVector3(L, 2);
				num2 = ((int)num3 * -322389226) ^ 0x684E7B51;
				continue;
			case 23u:
				ray = LuaScriptMgr.GetRay(L, 1);
				num2 = (int)(num3 * 880268813) ^ -80307578;
				continue;
			case 42u:
				vector6 = LuaScriptMgr.GetVector3(L, 2);
				num15 = (float)LuaDLL.lua_tonumber(L, 3);
				num2 = (int)(num3 * 126691827) ^ -1079664199;
				continue;
			case 18u:
				return 1;
			case 22u:
				return 1;
			case 10u:
			{
				int num24;
				int num25;
				if (LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle)))
				{
					num24 = 1225743107;
					num25 = num24;
				}
				else
				{
					num24 = 337002061;
					num25 = num24;
				}
				num2 = num24 ^ ((int)num3 * -1665915709);
				continue;
			}
			case 26u:
			{
				int num22;
				int num23;
				if (LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(int).TypeHandle)))
				{
					num22 = 844726801;
					num23 = num22;
				}
				else
				{
					num22 = 855995667;
					num23 = num22;
				}
				num2 = num22 ^ (int)(num3 * 579718621);
				continue;
			}
			case 38u:
				o4 = _206B_206C_200C_200B_200E_206C_206D_202D_200C_206F_202E_206C_200E_200B_202B_202C_206E_200F_202A_200F_200E_202D_206B_206A_206D_202C_200C_200C_206A_200C_202B_202A_206F_202C_200B_202B_206E_200E_202E_200C_202E(vector, vector6, num15);
				num2 = ((int)num3 * -1491851772) ^ 0x44F1CA0E;
				continue;
			case 27u:
				num9 = (float)LuaDLL.lua_tonumber(L, 3);
				num10 = (int)LuaDLL.lua_tonumber(L, 4);
				num2 = (int)((num3 * 2102894974) ^ 0xEDC95DF);
				continue;
			case 20u:
				goto IL_03be;
			case 6u:
				o7 = _202D_206F_202C_202E_202E_200F_200C_200F_206B_200C_200C_206E_202D_206E_206A_202B_202C_200E_200F_200F_206B_202D_202E_206F_206F_200E_206D_200B_200F_202A_202A_202D_206C_200E_200B_200E_206C_206B_206A_206A_202E(vector7, vector8);
				num2 = (int)(num3 * 1869068382) ^ -27265072;
				continue;
			case 16u:
				goto IL_03f3;
			case 25u:
			{
				int num18;
				int num19;
				if (LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle)))
				{
					num18 = -458013667;
					num19 = num18;
				}
				else
				{
					num18 = -1105512078;
					num19 = num18;
				}
				num2 = num18 ^ (int)(num3 * 70368164);
				continue;
			}
			case 43u:
			{
				int num16;
				int num17;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(int).TypeHandle)))
				{
					num16 = -1352561244;
					num17 = num16;
				}
				else
				{
					num16 = -1585189941;
					num17 = num16;
				}
				num2 = num16 ^ ((int)num3 * -1738976396);
				continue;
			}
			case 12u:
				vector4 = LuaScriptMgr.GetVector3(L, 1);
				num2 = ((int)num3 * -1948028230) ^ -566981202;
				continue;
			case 29u:
				return 1;
			case 30u:
			{
				int num13;
				int num14;
				if (LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle)))
				{
					num13 = -1712876420;
					num14 = num13;
				}
				else
				{
					num13 = -572009098;
					num14 = num13;
				}
				num2 = num13 ^ ((int)num3 * -26515999);
				continue;
			}
			case 36u:
				return 1;
			case 34u:
				goto IL_051d;
			case 40u:
				num5 = (float)LuaScriptMgr.GetNumber(L, 3);
				num6 = (int)LuaScriptMgr.GetNumber(L, 4);
				num2 = (int)((num3 * 1680331221) ^ 0x28B3A8DA);
				continue;
			case 8u:
			{
				Ray ray3 = LuaScriptMgr.GetRay(L, 1);
				o6 = _202B_202A_202E_200C_202E_202C_206F_202A_202B_200D_202B_200C_202A_202B_200C_200C_202D_200B_200F_202B_206B_202E_202D_206D_202A_202D_200F_200C_202D_200F_200F_206B_206A_202E_206F_206E_202B_206A_202E_206F_202E(ray3);
				num2 = ((int)num3 * -1768118779) ^ -1988723247;
				continue;
			}
			case 32u:
				num11 = (float)LuaDLL.lua_tonumber(L, 2);
				num12 = (int)LuaDLL.lua_tonumber(L, 3);
				num2 = ((int)num3 * -436663669) ^ -2083210754;
				continue;
			case 35u:
				goto IL_05a5;
			case 44u:
			{
				RaycastHit[] o5 = _200E_206D_202C_202A_200E_206E_200E_206B_206D_206A_200B_206C_206E_206D_202B_200E_202C_200D_200C_202B_202D_200E_206B_200B_202B_206E_200E_206A_200C_202C_206A_202B_200D_200D_206B_200E_206C_200D_202B_206C_202E(vector4, vector5, num9, num10);
				LuaScriptMgr.PushArray(L, o5);
				num2 = ((int)num3 * -2076322865) ^ -1939077224;
				continue;
			}
			case 13u:
				val2 = (QueryTriggerInteraction)(int)LuaScriptMgr.GetLuaObject(L, 4);
				num2 = ((int)num3 * -562321583) ^ -1216539382;
				continue;
			case 1u:
				ray2 = LuaScriptMgr.GetRay(L, 1);
				num7 = (float)LuaDLL.lua_tonumber(L, 2);
				num8 = (int)LuaDLL.lua_tonumber(L, 3);
				num2 = ((int)num3 * -304951661) ^ 0x56CBAA08;
				continue;
			case 7u:
				LuaScriptMgr.PushArray(L, o4);
				return 1;
			case 41u:
				goto IL_0655;
			case 37u:
				LuaScriptMgr.PushArray(L, o3);
				num2 = (int)((num3 * 687868295) ^ 0x24F58366);
				continue;
			case 24u:
			{
				QueryTriggerInteraction val = (QueryTriggerInteraction)(int)LuaScriptMgr.GetNetObject(L, 5, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(QueryTriggerInteraction).TypeHandle));
				o3 = _200C_202B_200D_200C_206B_206B_202A_202D_202A_206F_202B_206C_202D_206D_206B_206B_206D_202B_206E_200C_206F_200F_202D_202E_206A_200E_206E_200F_200E_206A_200B_200E_200E_206D_202B_200C_202D_206F_206E_202E(vector2, vector3, num5, num6, val);
				num2 = ((int)num3 * -1529235432) ^ 0x5E0E6B9E;
				continue;
			}
			case 17u:
				vector = LuaScriptMgr.GetVector3(L, 1);
				num2 = (int)((num3 * 739251320) ^ 0x6691F3A0);
				continue;
			case 5u:
				LuaScriptMgr.PushArray(L, o2);
				num2 = ((int)num3 * -5718405) ^ -420083563;
				continue;
			case 39u:
			{
				float num4 = (float)LuaDLL.lua_tonumber(L, 2);
				RaycastHit[] o = _202B_200F_206A_202A_202A_206E_200E_202B_200F_206D_200C_200F_206E_200B_206A_200F_202D_206B_200E_202E_206E_200F_202D_202A_202A_206F_200E_202D_200B_206E_206E_202C_200F_206C_202D_200B_202A_202B_206F_202E_202E(ray, num4);
				LuaScriptMgr.PushArray(L, o);
				return 1;
			}
			default:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1831399869u));
				return 0;
			}
			break;
			IL_0655:
			int num26;
			if (num != 2)
			{
				num2 = -1992761067;
				num26 = num2;
			}
			else
			{
				num2 = -107739823;
				num26 = num2;
			}
			continue;
			IL_03f3:
			int num27;
			if (num != 4)
			{
				num2 = -469217632;
				num27 = num2;
			}
			else
			{
				num2 = -874564441;
				num27 = num2;
			}
			continue;
			IL_0206:
			int num28;
			if (num != 5)
			{
				num2 = -474380339;
				num28 = num2;
			}
			else
			{
				num2 = -419305063;
				num28 = num2;
			}
			continue;
			IL_051d:
			int num29;
			if (num != 4)
			{
				num2 = -2091402033;
				num29 = num2;
			}
			else
			{
				num2 = -368584184;
				num29 = num2;
			}
			continue;
			IL_0138:
			int num30;
			if (num != 3)
			{
				num2 = -1900069661;
				num30 = num2;
			}
			else
			{
				num2 = -896305886;
				num30 = num2;
			}
			continue;
			IL_03be:
			int num31;
			if (num == 3)
			{
				num2 = -583330857;
				num31 = num2;
			}
			else
			{
				num2 = -1695188410;
				num31 = num2;
			}
		}
		goto IL_000e;
		IL_05a5:
		int num32;
		if (num != 2)
		{
			num2 = -886251791;
			num32 = num2;
		}
		else
		{
			num2 = -1425916154;
			num32 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Linecast(IntPtr L)
	{
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		int num = LuaDLL.lua_gettop(L);
		if (num == 2)
		{
			goto IL_000e;
		}
		goto IL_0504;
		IL_000e:
		int num2 = 419578521;
		goto IL_0013;
		IL_0013:
		bool b = default(bool);
		RaycastHit hit = default(RaycastHit);
		Vector3 vector3 = default(Vector3);
		Vector3 vector = default(Vector3);
		Vector3 vector2 = default(Vector3);
		int num6 = default(int);
		Vector3 vector11 = default(Vector3);
		Vector3 vector12 = default(Vector3);
		int num7 = default(int);
		QueryTriggerInteraction val = default(QueryTriggerInteraction);
		Vector3 vector8 = default(Vector3);
		int num8 = default(int);
		Vector3 vector9 = default(Vector3);
		Vector3 vector10 = default(Vector3);
		RaycastHit hit3 = default(RaycastHit);
		Vector3 vector7 = default(Vector3);
		bool b4 = default(bool);
		RaycastHit hit2 = default(RaycastHit);
		Vector3 vector4 = default(Vector3);
		Vector3 vector6 = default(Vector3);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ 0x42D33AFE)) % 35)
			{
			case 4u:
				break;
			case 29u:
				LuaScriptMgr.Push(L, b);
				LuaScriptMgr.Push(L, hit);
				return 2;
			case 9u:
				vector3 = LuaScriptMgr.GetVector3(L, 2);
				num2 = (int)(num3 * 1056454485) ^ -1396853895;
				continue;
			case 15u:
				vector = LuaScriptMgr.GetVector3(L, 1);
				vector2 = LuaScriptMgr.GetVector3(L, 2);
				num6 = (int)LuaDLL.lua_tonumber(L, 3);
				num2 = (int)((num3 * 2082012142) ^ 0x738A6A04);
				continue;
			case 12u:
			{
				bool b6 = _206E_206E_202A_202B_200C_206B_206C_200E_202B_202D_202B_200E_206B_200F_206C_200E_200E_202B_200F_206F_200B_206B_206D_202A_206C_202A_202E_206C_206B_200D_202C_200D_206E_200D_200B_206A_200F_200F_200B_206E_202E(vector11, vector12, num7, val);
				LuaScriptMgr.Push(L, b6);
				num2 = (int)((num3 * 982627717) ^ 0x3CBA326E);
				continue;
			}
			case 27u:
				goto IL_014f;
			case 0u:
				vector8 = LuaScriptMgr.GetVector3(L, 1);
				num2 = (int)(num3 * 233158015) ^ -308689520;
				continue;
			case 25u:
				num8 = (int)LuaDLL.lua_tonumber(L, 4);
				num2 = ((int)num3 * -207206537) ^ 0x1BDA5220;
				continue;
			case 26u:
			{
				int num11 = (int)LuaScriptMgr.GetNumber(L, 4);
				QueryTriggerInteraction val2 = (QueryTriggerInteraction)(int)LuaScriptMgr.GetNetObject(L, 5, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(QueryTriggerInteraction).TypeHandle));
				bool b5 = _202E_200E_202B_200E_206A_200F_200C_206A_202B_202A_206A_202E_206D_200C_206A_206F_200B_202E_206A_200D_206D_206F_200D_206B_206B_202D_202B_202C_202E_206E_200D_202B_200D_200D_202E_206A_206F_200E_206D_206F_202E(vector9, vector10, ref hit3, num11, val2);
				LuaScriptMgr.Push(L, b5);
				LuaScriptMgr.Push(L, hit3);
				num2 = (int)((num3 * 1870395357) ^ 0x1965D3F4);
				continue;
			}
			case 3u:
				goto IL_01f6;
			case 21u:
				return 2;
			case 20u:
				vector11 = LuaScriptMgr.GetVector3(L, 1);
				vector12 = LuaScriptMgr.GetVector3(L, 2);
				num2 = ((int)num3 * -1964700372) ^ 0x7A28688D;
				continue;
			case 11u:
			{
				int num14;
				int num15;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(int).TypeHandle)))
				{
					num14 = 1889182686;
					num15 = num14;
				}
				else
				{
					num14 = 1226809571;
					num15 = num14;
				}
				num2 = num14 ^ (int)(num3 * 907215601);
				continue;
			}
			case 14u:
				return 1;
			case 6u:
				vector9 = LuaScriptMgr.GetVector3(L, 1);
				vector10 = LuaScriptMgr.GetVector3(L, 2);
				num2 = (int)((num3 * 1384431669) ^ 0x7C1AD23F);
				continue;
			case 16u:
				return 1;
			case 32u:
				vector7 = LuaScriptMgr.GetVector3(L, 2);
				num2 = ((int)num3 * -48914365) ^ -1729764405;
				continue;
			case 18u:
				LuaScriptMgr.Push(L, b4);
				LuaScriptMgr.Push(L, hit2);
				num2 = ((int)num3 * -288163937) ^ -1789879796;
				continue;
			case 7u:
			{
				int num12;
				int num13;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), null))
				{
					num12 = -571400180;
					num13 = num12;
				}
				else
				{
					num12 = -1104293627;
					num13 = num12;
				}
				num2 = num12 ^ ((int)num3 * -1190948237);
				continue;
			}
			case 22u:
			{
				int num9;
				int num10;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), null, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(int).TypeHandle)))
				{
					num9 = 217286769;
					num10 = num9;
				}
				else
				{
					num9 = 1466155185;
					num10 = num9;
				}
				num2 = num9 ^ ((int)num3 * -675360775);
				continue;
			}
			case 8u:
				b4 = _200C_200F_200F_202E_206E_206B_202C_206C_202A_202E_206A_202B_200D_202C_202B_200D_202C_200D_206C_206B_202A_200D_206C_202B_206A_206A_200B_200E_202D_206A_200E_202E_202C_202E_202B_200E_200D_206F_206D_206A_202E(vector8, vector3, ref hit2, num8);
				num2 = (int)((num3 * 1437962435) ^ 0xD42A327);
				continue;
			case 34u:
			{
				bool b3 = _200F_206C_206A_202B_202E_200C_202B_206E_202E_202B_206F_206C_206F_202B_202E_200E_200D_200C_206B_202B_206F_206F_206F_200E_202C_200E_202D_206D_200D_200F_202D_202D_200E_206E_206C_206E_206B_202B_200C_200C_202E(vector4, vector7);
				LuaScriptMgr.Push(L, b3);
				num2 = (int)((num3 * 21628846) ^ 0x645B51BC);
				continue;
			}
			case 5u:
				vector6 = LuaScriptMgr.GetVector3(L, 1);
				num2 = (int)(num3 * 1305535042) ^ -2070631810;
				continue;
			case 2u:
			{
				Vector3 vector5 = LuaScriptMgr.GetVector3(L, 2);
				b = _202C_202C_200E_202E_202D_202E_206E_202A_206D_202C_202C_202C_202E_202C_206F_202D_206E_206E_206A_206D_206C_202B_206E_206E_202E_206A_202D_202E_206B_206B_200F_202E_202A_202E_206C_206C_206D_200D_206D_202A_202E(vector6, vector5, ref hit);
				num2 = ((int)num3 * -382442353) ^ 0x6F9F087A;
				continue;
			}
			case 28u:
				vector4 = LuaScriptMgr.GetVector3(L, 1);
				num2 = ((int)num3 * -1463000169) ^ -1433328502;
				continue;
			case 33u:
			{
				bool b2 = _200E_206A_206E_206A_206C_202D_202C_206D_200D_206C_200B_206C_200C_206A_206A_202C_200B_200D_200F_206A_200D_206D_206E_206D_206F_200F_206F_200F_206B_202B_206D_202C_206E_200F_200E_202C_200C_206A_202A_202C_202E(vector, vector2, num6);
				LuaScriptMgr.Push(L, b2);
				num2 = (int)(num3 * 780879643) ^ -770650077;
				continue;
			}
			case 24u:
				return 2;
			case 19u:
				goto IL_047a;
			case 10u:
				return 1;
			case 13u:
				num7 = (int)LuaDLL.lua_tonumber(L, 3);
				val = (QueryTriggerInteraction)(int)LuaScriptMgr.GetLuaObject(L, 4);
				num2 = ((int)num3 * -436600787) ^ 0x47FF5659;
				continue;
			case 1u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1195717736u));
				num2 = 812990615;
				continue;
			case 23u:
				goto IL_04ec;
			case 30u:
				goto IL_0504;
			case 31u:
			{
				int num4;
				int num5;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(int).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(QueryTriggerInteraction).TypeHandle)))
				{
					num4 = -1030020167;
					num5 = num4;
				}
				else
				{
					num4 = -870616254;
					num5 = num4;
				}
				num2 = num4 ^ ((int)num3 * -2047002417);
				continue;
			}
			default:
				return 0;
			}
			break;
			IL_04ec:
			int num16;
			if (num != 4)
			{
				num2 = 342767919;
				num16 = num2;
			}
			else
			{
				num2 = 385611056;
				num16 = num2;
			}
			continue;
			IL_01f6:
			int num17;
			if (num == 3)
			{
				num2 = 373907219;
				num17 = num2;
			}
			else
			{
				num2 = 405171651;
				num17 = num2;
			}
			continue;
			IL_014f:
			int num18;
			if (num != 4)
			{
				num2 = 1197416082;
				num18 = num2;
			}
			else
			{
				num2 = 1248390683;
				num18 = num2;
			}
			continue;
			IL_047a:
			int num19;
			if (num != 5)
			{
				num2 = 1754302464;
				num19 = num2;
			}
			else
			{
				num2 = 931662329;
				num19 = num2;
			}
		}
		goto IL_000e;
		IL_0504:
		int num20;
		if (num == 3)
		{
			num2 = 1053449015;
			num20 = num2;
		}
		else
		{
			num2 = 1115139911;
			num20 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int OverlapSphere(IntPtr L)
	{
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		int num = LuaDLL.lua_gettop(L);
		QueryTriggerInteraction val = default(QueryTriggerInteraction);
		Vector3 vector2 = default(Vector3);
		float num7 = default(float);
		Vector3 vector = default(Vector3);
		Collider[] o = default(Collider[]);
		Collider[] o3 = default(Collider[]);
		int num12 = default(int);
		float num4 = default(float);
		Vector3 vector3 = default(Vector3);
		float num10 = default(float);
		int num11 = default(int);
		while (true)
		{
			int num2 = 1741988383;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x1A1784C5)) % 17)
				{
				case 0u:
					break;
				case 8u:
					val = (QueryTriggerInteraction)(int)LuaScriptMgr.GetNetObject(L, 4, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(QueryTriggerInteraction).TypeHandle));
					num2 = ((int)num3 * -730910634) ^ 0x5BC858CE;
					continue;
				case 16u:
				{
					int num9;
					if (num != 3)
					{
						num2 = 288932935;
						num9 = num2;
					}
					else
					{
						num2 = 443485200;
						num9 = num2;
					}
					continue;
				}
				case 10u:
					vector2 = LuaScriptMgr.GetVector3(L, 1);
					num7 = (float)LuaScriptMgr.GetNumber(L, 2);
					num2 = (int)(num3 * 1889539304) ^ -436297193;
					continue;
				case 3u:
					vector = LuaScriptMgr.GetVector3(L, 1);
					num2 = (int)((num3 * 1589712709) ^ 0x3F6B4601);
					continue;
				case 5u:
					LuaScriptMgr.PushArray(L, o);
					return 1;
				case 9u:
					o3 = _206E_202B_206B_200B_206D_206C_200B_202B_202D_202D_202D_202C_206A_202B_202E_206C_202E_206B_206B_206A_200C_200B_206A_200D_206C_200C_206F_206C_206E_206F_200E_206E_200B_206A_206B_200F_202D_206A_200D_202E(vector2, num7, num12);
					num2 = ((int)num3 * -412486101) ^ 0x1172454D;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2877962942u));
					num2 = 1000336232;
					continue;
				case 6u:
					o = _200B_200F_202C_200F_206A_206D_200B_202D_200F_200B_202A_200B_200F_206B_200B_202A_206B_202D_200D_200B_202A_200D_202E_202E_200B_202A_202C_206D_202D_202A_200E_202C_200E_200C_206C_200E_200B_206E_202E_206F_202E(vector, num4);
					num2 = (int)((num3 * 1863919474) ^ 0x2B1F3051);
					continue;
				case 12u:
					num12 = (int)LuaScriptMgr.GetNumber(L, 3);
					num2 = ((int)num3 * -1344799768) ^ -1935578368;
					continue;
				case 13u:
					LuaScriptMgr.PushArray(L, o3);
					return 1;
				case 7u:
					vector3 = LuaScriptMgr.GetVector3(L, 1);
					num10 = (float)LuaScriptMgr.GetNumber(L, 2);
					num11 = (int)LuaScriptMgr.GetNumber(L, 3);
					num2 = ((int)num3 * -1441027256) ^ -892843849;
					continue;
				case 4u:
				{
					Collider[] o2 = _200C_206C_202B_202D_206F_206E_200B_206A_200C_206B_200C_202E_202D_206A_200E_206A_200B_200E_206D_206F_200F_202D_202A_200B_200B_202A_206B_206F_200F_200D_200F_206F_206F_202C_206F_202A_200F_206C_200C_202E(vector3, num10, num11, val);
					LuaScriptMgr.PushArray(L, o2);
					return 1;
				}
				case 14u:
				{
					int num8;
					if (num == 4)
					{
						num2 = 1398450890;
						num8 = num2;
					}
					else
					{
						num2 = 1216336881;
						num8 = num2;
					}
					continue;
				}
				case 15u:
				{
					int num5;
					int num6;
					if (num != 2)
					{
						num5 = 1302645794;
						num6 = num5;
					}
					else
					{
						num5 = 1270330744;
						num6 = num5;
					}
					num2 = num5 ^ ((int)num3 * -1254249302);
					continue;
				}
				case 1u:
					num4 = (float)LuaScriptMgr.GetNumber(L, 2);
					num2 = (int)(num3 * 1239931294) ^ -357352494;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int CapsuleCast(IntPtr L)
	{
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08db: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0670: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Unknown result type (might be due to invalid IL or missing references)
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_078a: Unknown result type (might be due to invalid IL or missing references)
		//IL_078f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0826: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0963: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a89: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_094d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0803: Unknown result type (might be due to invalid IL or missing references)
		//IL_0808: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Unknown result type (might be due to invalid IL or missing references)
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a30: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0840: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Unknown result type (might be due to invalid IL or missing references)
		//IL_0846: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_0716: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Unknown result type (might be due to invalid IL or missing references)
		int num = LuaDLL.lua_gettop(L);
		if (num == 4)
		{
			goto IL_000e;
		}
		goto IL_04ab;
		IL_000e:
		int num2 = 156260444;
		goto IL_0013;
		IL_0013:
		Vector3 vector23 = default(Vector3);
		Vector3 vector24 = default(Vector3);
		float num28 = default(float);
		Vector3 vector3 = default(Vector3);
		QueryTriggerInteraction val2 = default(QueryTriggerInteraction);
		float num21 = default(float);
		Vector3 vector21 = default(Vector3);
		float num22 = default(float);
		int num23 = default(int);
		Vector3 vector22 = default(Vector3);
		float num16 = default(float);
		int num18 = default(int);
		float num12 = default(float);
		Vector3 vector14 = default(Vector3);
		Vector3 vector10 = default(Vector3);
		Vector3 vector9 = default(Vector3);
		Vector3 vector4 = default(Vector3);
		bool b7 = default(bool);
		Vector3 vector15 = default(Vector3);
		float num9 = default(float);
		RaycastHit hit4 = default(RaycastHit);
		float num24 = default(float);
		Vector3 vector13 = default(Vector3);
		bool b5 = default(bool);
		Vector3 vector6 = default(Vector3);
		float num15 = default(float);
		Vector3 vector16 = default(Vector3);
		RaycastHit hit3 = default(RaycastHit);
		Vector3 vector17 = default(Vector3);
		Vector3 vector20 = default(Vector3);
		Vector3 vector18 = default(Vector3);
		bool b4 = default(bool);
		Vector3 vector11 = default(Vector3);
		bool b2 = default(bool);
		Vector3 vector19 = default(Vector3);
		float num17 = default(float);
		Vector3 vector12 = default(Vector3);
		float num8 = default(float);
		float num5 = default(float);
		Vector3 vector = default(Vector3);
		RaycastHit hit2 = default(RaycastHit);
		int num7 = default(int);
		QueryTriggerInteraction val = default(QueryTriggerInteraction);
		Vector3 vector5 = default(Vector3);
		bool b = default(bool);
		RaycastHit hit = default(RaycastHit);
		bool b3 = default(bool);
		Vector3 vector7 = default(Vector3);
		Vector3 vector8 = default(Vector3);
		Vector3 vector2 = default(Vector3);
		float num6 = default(float);
		float num4 = default(float);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ 0x5B2D61A2)) % 67)
			{
			case 43u:
				break;
			case 25u:
				vector23 = LuaScriptMgr.GetVector3(L, 1);
				vector24 = LuaScriptMgr.GetVector3(L, 2);
				num28 = (float)LuaScriptMgr.GetNumber(L, 3);
				num2 = ((int)num3 * -1176716774) ^ -1507333153;
				continue;
			case 27u:
			{
				int num32;
				int num33;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), null, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(int).TypeHandle)))
				{
					num32 = -673553899;
					num33 = num32;
				}
				else
				{
					num32 = -582107362;
					num33 = num32;
				}
				num2 = num32 ^ ((int)num3 * -944265678);
				continue;
			}
			case 33u:
				goto IL_01c4;
			case 63u:
				goto IL_01dc;
			case 5u:
				vector3 = LuaScriptMgr.GetVector3(L, 1);
				num2 = ((int)num3 * -707182610) ^ -18016416;
				continue;
			case 59u:
				val2 = (QueryTriggerInteraction)(int)LuaScriptMgr.GetLuaObject(L, 7);
				num2 = (int)(num3 * 1014754476) ^ -20674107;
				continue;
			case 8u:
				num21 = (float)LuaDLL.lua_tonumber(L, 3);
				vector21 = LuaScriptMgr.GetVector3(L, 4);
				num22 = (float)LuaDLL.lua_tonumber(L, 5);
				num23 = (int)LuaDLL.lua_tonumber(L, 6);
				num2 = (int)(num3 * 1953381849) ^ -1775300471;
				continue;
			case 22u:
				vector22 = LuaScriptMgr.GetVector3(L, 1);
				num2 = (int)((num3 * 1551226805) ^ 0x715A379);
				continue;
			case 52u:
				num16 = (float)LuaScriptMgr.GetNumber(L, 6);
				num2 = (int)(num3 * 75082417) ^ -1979149374;
				continue;
			case 53u:
				return 1;
			case 60u:
				num18 = (int)LuaDLL.lua_tonumber(L, 6);
				num2 = ((int)num3 * -564752211) ^ 0x3720BAE1;
				continue;
			case 17u:
				return 2;
			case 45u:
				num12 = (float)LuaDLL.lua_tonumber(L, 3);
				num2 = (int)((num3 * 852035132) ^ 0x24D2137A);
				continue;
			case 21u:
				vector14 = LuaScriptMgr.GetVector3(L, 2);
				num2 = ((int)num3 * -711319005) ^ 0x6626FD95;
				continue;
			case 36u:
				goto IL_0324;
			case 34u:
				vector10 = LuaScriptMgr.GetVector3(L, 4);
				num2 = (int)(num3 * 1345589121) ^ -1958645745;
				continue;
			case 54u:
				vector9 = LuaScriptMgr.GetVector3(L, 2);
				num2 = ((int)num3 * -271086298) ^ 0x2504567A;
				continue;
			case 19u:
				vector4 = LuaScriptMgr.GetVector3(L, 2);
				num2 = (int)((num3 * 124922815) ^ 0x45F21460);
				continue;
			case 24u:
			{
				int num30;
				int num31;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(int).TypeHandle)))
				{
					num30 = -788090912;
					num31 = num30;
				}
				else
				{
					num30 = -987277794;
					num31 = num30;
				}
				num2 = num30 ^ ((int)num3 * -451457075);
				continue;
			}
			case 31u:
			{
				int num29 = (int)LuaDLL.lua_tonumber(L, 7);
				b7 = _206E_202C_202D_202C_202E_202E_202C_202D_200C_200B_202E_206C_206F_200C_200E_202B_206E_202C_206E_202C_206D_200B_206D_206A_202D_206D_206D_202E_202C_202B_206F_202E_206E_200B_206C_200D_200B_200C_200C_202D_202E(vector22, vector15, num9, vector10, ref hit4, num24, num29);
				num2 = ((int)num3 * -182955196) ^ -1432189598;
				continue;
			}
			case 28u:
			{
				bool b8 = _200D_202C_202B_202E_206F_200D_206D_200E_202C_202D_206F_202E_206E_200D_202D_200D_200B_206F_206E_202C_206F_200D_202D_202A_206B_206C_202C_206F_206E_202D_200E_200F_202D_206E_202E_202B_202D_202A_202D_206E_202E(vector23, vector24, num28, vector13);
				LuaScriptMgr.Push(L, b8);
				num2 = (int)(num3 * 309238489) ^ -1244416199;
				continue;
			}
			case 39u:
				goto IL_044b;
			case 16u:
				goto IL_0463;
			case 15u:
			{
				float num27 = (float)LuaDLL.lua_tonumber(L, 6);
				b5 = _200C_206E_200F_202C_202B_200B_202A_202B_200F_206A_206A_200F_200F_200B_200B_200F_206F_200D_202B_200C_202D_200D_200F_206F_206E_206A_202E_200C_200D_206C_200C_206B_202A_200F_202D_206B_202C_202D_202B_206D_202E(vector6, vector9, num15, vector16, ref hit3, num27);
				num2 = ((int)num3 * -914309714) ^ -153804293;
				continue;
			}
			case 18u:
				goto IL_04ab;
			case 30u:
				vector17 = LuaScriptMgr.GetVector3(L, 1);
				num2 = ((int)num3 * -355283618) ^ 0x4BA3388C;
				continue;
			case 58u:
			{
				int num25;
				int num26;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(int).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(QueryTriggerInteraction).TypeHandle)))
				{
					num25 = 1283412575;
					num26 = num25;
				}
				else
				{
					num25 = 1279837092;
					num26 = num25;
				}
				num2 = num25 ^ (int)(num3 * 1970062446);
				continue;
			}
			case 40u:
				return 1;
			case 23u:
				return 1;
			case 0u:
				vector20 = LuaScriptMgr.GetVector3(L, 1);
				num2 = (int)(num3 * 1137978833) ^ -1538978443;
				continue;
			case 61u:
				vector18 = LuaScriptMgr.GetVector3(L, 2);
				num2 = ((int)num3 * -1330906462) ^ -1068107120;
				continue;
			case 11u:
				num24 = (float)LuaDLL.lua_tonumber(L, 6);
				num2 = (int)((num3 * 1056631676) ^ 0x35788D87);
				continue;
			case 3u:
				b4 = _202D_202D_202B_206F_206E_200F_206A_200E_206E_202C_200F_200F_202A_206D_206B_202C_202C_206D_206E_202B_206C_200F_202B_200F_202B_202B_202D_206B_206D_200F_200E_202D_206D_200D_206D_202C_200C_202E_206A_206C_202E(vector11, vector14, num21, vector21, num22, num23, val2);
				num2 = (int)(num3 * 2105367018) ^ -1114904575;
				continue;
			case 51u:
			{
				int num19;
				int num20;
				if (LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), null, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle)))
				{
					num19 = 1189711847;
					num20 = num19;
				}
				else
				{
					num19 = 652716859;
					num20 = num19;
				}
				num2 = num19 ^ (int)(num3 * 1380591052);
				continue;
			}
			case 65u:
				LuaScriptMgr.Push(L, b7);
				LuaScriptMgr.Push(L, hit4);
				return 2;
			case 4u:
				b2 = _202A_206A_206D_206C_200D_202A_202A_206E_206B_202E_202E_200D_206F_200C_206D_206C_200D_202A_200B_202E_200B_202E_202E_200D_200F_200F_206B_206D_200F_206F_200B_200C_200F_206A_202A_200E_202B_206C_206F_202D_202E(vector20, vector19, num17, vector12, num8, num18);
				num2 = ((int)num3 * -1044875326) ^ -304321426;
				continue;
			case 46u:
				vector19 = LuaScriptMgr.GetVector3(L, 2);
				num17 = (float)LuaDLL.lua_tonumber(L, 3);
				num2 = ((int)num3 * -1315699337) ^ 0x7D1480B7;
				continue;
			case 49u:
			{
				bool b6 = _206E_202D_206C_206A_200F_206C_200C_206D_200B_202D_206A_200F_206E_202B_202E_200D_206E_202E_206B_202A_202D_200C_202A_200D_200B_200C_202B_200E_200C_202B_206E_202D_200E_200C_206F_206E_206D_206F_206F_202E(vector17, vector18, num5, vector, ref hit2, num16, num7, val);
				LuaScriptMgr.Push(L, b6);
				num2 = ((int)num3 * -1777211820) ^ -1496431181;
				continue;
			}
			case 42u:
				num15 = (float)LuaDLL.lua_tonumber(L, 3);
				vector16 = LuaScriptMgr.GetVector3(L, 4);
				num2 = (int)((num3 * 86480225) ^ 0x58C47C6C);
				continue;
			case 62u:
				vector15 = LuaScriptMgr.GetVector3(L, 2);
				num2 = ((int)num3 * -491892711) ^ -2056532094;
				continue;
			case 7u:
			{
				int num13;
				int num14;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle)))
				{
					num13 = -801218324;
					num14 = num13;
				}
				else
				{
					num13 = -802458761;
					num14 = num13;
				}
				num2 = num13 ^ ((int)num3 * -575707022);
				continue;
			}
			case 9u:
				vector13 = LuaScriptMgr.GetVector3(L, 4);
				num2 = ((int)num3 * -1888360330) ^ 0x731D8870;
				continue;
			case 26u:
				vector5 = LuaScriptMgr.GetVector3(L, 4);
				num2 = (int)((num3 * 526443168) ^ 0x4EF2ABE6);
				continue;
			case 50u:
				LuaScriptMgr.Push(L, b);
				LuaScriptMgr.Push(L, hit);
				return 2;
			case 64u:
				vector12 = LuaScriptMgr.GetVector3(L, 4);
				num2 = (int)(num3 * 1420990107) ^ -878264617;
				continue;
			case 37u:
				vector11 = LuaScriptMgr.GetVector3(L, 1);
				num2 = (int)((num3 * 241834909) ^ 0x6D3F58FC);
				continue;
			case 12u:
				LuaScriptMgr.Push(L, b5);
				LuaScriptMgr.Push(L, hit3);
				num2 = ((int)num3 * -1699650732) ^ 0x6B1DE578;
				continue;
			case 56u:
				b3 = _202A_202A_200D_206A_200F_206B_200F_206A_200E_200B_200F_202A_206A_206A_200C_200B_206A_202C_206C_202E_206A_200E_202D_202A_202C_202A_206A_202C_200F_202B_200D_206A_200B_206A_200E_200D_200F_202E_202E_206C_202E(vector7, vector8, num12, vector2, num6);
				num2 = ((int)num3 * -1972695191) ^ -2005811998;
				continue;
			case 44u:
			{
				int num10;
				int num11;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), null))
				{
					num10 = 1957429798;
					num11 = num10;
				}
				else
				{
					num10 = 1054583367;
					num11 = num10;
				}
				num2 = num10 ^ ((int)num3 * -761174410);
				continue;
			}
			case 32u:
				num9 = (float)LuaDLL.lua_tonumber(L, 3);
				num2 = ((int)num3 * -1663513547) ^ 0x79F9084D;
				continue;
			case 2u:
				vector7 = LuaScriptMgr.GetVector3(L, 1);
				vector8 = LuaScriptMgr.GetVector3(L, 2);
				num2 = ((int)num3 * -1672915974) ^ -702901673;
				continue;
			case 38u:
				num8 = (float)LuaDLL.lua_tonumber(L, 5);
				num2 = (int)((num3 * 438256152) ^ 0x1DB51FD8);
				continue;
			case 20u:
				LuaScriptMgr.Push(L, b4);
				num2 = (int)((num3 * 613469029) ^ 0x7AB0D166);
				continue;
			case 35u:
				num7 = (int)LuaScriptMgr.GetNumber(L, 7);
				val = (QueryTriggerInteraction)(int)LuaScriptMgr.GetNetObject(L, 8, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(QueryTriggerInteraction).TypeHandle));
				num2 = ((int)num3 * -1515303181) ^ 0x492B8EF5;
				continue;
			case 14u:
				LuaScriptMgr.Push(L, hit2);
				return 2;
			case 41u:
				LuaScriptMgr.Push(L, b3);
				num2 = ((int)num3 * -421776684) ^ -85453708;
				continue;
			case 66u:
				num6 = (float)LuaDLL.lua_tonumber(L, 5);
				num2 = ((int)num3 * -585712465) ^ -659643554;
				continue;
			case 48u:
				num4 = (float)LuaDLL.lua_tonumber(L, 3);
				num2 = ((int)num3 * -710743092) ^ -1993104995;
				continue;
			case 1u:
				LuaScriptMgr.Push(L, b2);
				return 1;
			case 13u:
				vector6 = LuaScriptMgr.GetVector3(L, 1);
				num2 = (int)(num3 * 1618840829) ^ -504930285;
				continue;
			case 10u:
				num5 = (float)LuaScriptMgr.GetNumber(L, 3);
				num2 = ((int)num3 * -2124079610) ^ 0x2B590752;
				continue;
			case 47u:
				b = _200F_202D_206C_206C_202A_200E_202B_200F_206F_202E_202A_202A_206E_206E_206B_202D_200F_206A_200E_206E_206A_206E_206B_202B_202E_200D_202D_206E_206E_200E_200B_206B_202E_206A_202D_202E_202D_202A_206B_202A_202E(vector3, vector4, num4, vector5, ref hit);
				num2 = (int)((num3 * 213817268) ^ 0x166D514B);
				continue;
			case 55u:
				vector2 = LuaScriptMgr.GetVector3(L, 4);
				num2 = ((int)num3 * -8673841) ^ -2089750130;
				continue;
			case 6u:
				goto IL_0a6a;
			case 29u:
				vector = LuaScriptMgr.GetVector3(L, 4);
				num2 = (int)(num3 * 1074058694) ^ -297143724;
				continue;
			default:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1064344069u));
				return 0;
			}
			break;
			IL_0a6a:
			int num34;
			if (num != 5)
			{
				num2 = 82666844;
				num34 = num2;
			}
			else
			{
				num2 = 1898571834;
				num34 = num2;
			}
			continue;
			IL_044b:
			int num35;
			if (num != 6)
			{
				num2 = 2036826527;
				num35 = num2;
			}
			else
			{
				num2 = 737338833;
				num35 = num2;
			}
			continue;
			IL_01dc:
			int num36;
			if (num != 6)
			{
				num2 = 1067890669;
				num36 = num2;
			}
			else
			{
				num2 = 1670138083;
				num36 = num2;
			}
			continue;
			IL_0463:
			int num37;
			if (num != 8)
			{
				num2 = 49247398;
				num37 = num2;
			}
			else
			{
				num2 = 827662062;
				num37 = num2;
			}
			continue;
			IL_01c4:
			int num38;
			if (num == 7)
			{
				num2 = 2014904682;
				num38 = num2;
			}
			else
			{
				num2 = 981854127;
				num38 = num2;
			}
			continue;
			IL_0324:
			int num39;
			if (num == 7)
			{
				num2 = 878887748;
				num39 = num2;
			}
			else
			{
				num2 = 1245878009;
				num39 = num2;
			}
		}
		goto IL_000e;
		IL_04ab:
		int num40;
		if (num == 5)
		{
			num2 = 363697862;
			num40 = num2;
		}
		else
		{
			num2 = 1531699774;
			num40 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SphereCast(IntPtr L)
	{
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b38: Unknown result type (might be due to invalid IL or missing references)
		//IL_085c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0861: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0778: Unknown result type (might be due to invalid IL or missing references)
		//IL_077d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0793: Unknown result type (might be due to invalid IL or missing references)
		//IL_0797: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acc: Unknown result type (might be due to invalid IL or missing references)
		//IL_095b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0928: Unknown result type (might be due to invalid IL or missing references)
		//IL_092d: Unknown result type (might be due to invalid IL or missing references)
		//IL_092f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0933: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a16: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_0877: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b70: Unknown result type (might be due to invalid IL or missing references)
		//IL_073f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0744: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0709: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0825: Unknown result type (might be due to invalid IL or missing references)
		//IL_082a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		int num = LuaDLL.lua_gettop(L);
		if (num == 2)
		{
			goto IL_000e;
		}
		goto IL_0447;
		IL_000e:
		int num2 = -1252945073;
		goto IL_0013;
		IL_0013:
		Vector3 vector8 = default(Vector3);
		float num43 = default(float);
		float num39 = default(float);
		float num36 = default(float);
		RaycastHit hit7 = default(RaycastHit);
		bool b12 = default(bool);
		Vector3 vector6 = default(Vector3);
		RaycastHit hit8 = default(RaycastHit);
		float num28 = default(float);
		int num44 = default(int);
		QueryTriggerInteraction val3 = default(QueryTriggerInteraction);
		bool b4 = default(bool);
		Ray ray7 = default(Ray);
		float num26 = default(float);
		RaycastHit hit5 = default(RaycastHit);
		RaycastHit hit3 = default(RaycastHit);
		bool b11 = default(bool);
		Ray ray8 = default(Ray);
		float num9 = default(float);
		float num29 = default(float);
		int num22 = default(int);
		Vector3 vector3 = default(Vector3);
		float num25 = default(float);
		bool b5 = default(bool);
		Ray ray2 = default(Ray);
		float num21 = default(float);
		Ray ray3 = default(Ray);
		float num11 = default(float);
		Ray ray5 = default(Ray);
		float num18 = default(float);
		bool b10 = default(bool);
		Ray ray6 = default(Ray);
		Vector3 vector = default(Vector3);
		bool b3 = default(bool);
		RaycastHit hit2 = default(RaycastHit);
		bool b9 = default(bool);
		Vector3 vector5 = default(Vector3);
		Ray ray4 = default(Ray);
		RaycastHit hit6 = default(RaycastHit);
		bool b6 = default(bool);
		RaycastHit hit4 = default(RaycastHit);
		Ray ray = default(Ray);
		float num15 = default(float);
		float num14 = default(float);
		Vector3 vector2 = default(Vector3);
		float num16 = default(float);
		float num12 = default(float);
		int num13 = default(int);
		RaycastHit hit = default(RaycastHit);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ -1878539029)) % 79)
			{
			case 21u:
				break;
			case 36u:
				vector8 = LuaScriptMgr.GetVector3(L, 1);
				num43 = (float)LuaScriptMgr.GetNumber(L, 2);
				num2 = (int)(num3 * 397153073) ^ -984365241;
				continue;
			case 61u:
			{
				int num47;
				int num48;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), null, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(int).TypeHandle)))
				{
					num47 = -149061842;
					num48 = num47;
				}
				else
				{
					num47 = -589552700;
					num48 = num47;
				}
				num2 = num47 ^ ((int)num3 * -1685520681);
				continue;
			}
			case 39u:
				num39 = (float)LuaDLL.lua_tonumber(L, 2);
				num2 = (int)(num3 * 367592227) ^ -136481885;
				continue;
			case 42u:
				num36 = (float)LuaDLL.lua_tonumber(L, 2);
				num2 = ((int)num3 * -810976888) ^ 0x2793162A;
				continue;
			case 13u:
				LuaScriptMgr.Push(L, hit7);
				return 2;
			case 25u:
			{
				int num49;
				int num50;
				if (LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle)))
				{
					num49 = 596416230;
					num50 = num49;
				}
				else
				{
					num49 = 1006296691;
					num50 = num49;
				}
				num2 = num49 ^ ((int)num3 * -1258489764);
				continue;
			}
			case 43u:
				b12 = _200D_202A_206A_202C_206E_200B_202C_200C_200C_200C_202E_206C_206F_202C_206B_202D_202D_200C_206B_206E_200E_202C_200D_200E_206F_202B_202B_200E_206E_200B_202C_202C_200B_200F_200D_206F_202D_206D_206C_200C_202E(vector8, num43, vector6, ref hit8, num28, num44, val3);
				num2 = (int)((num3 * 1933622273) ^ 0x6BE10755);
				continue;
			case 66u:
				goto IL_02a7;
			case 59u:
				b4 = _206D_200F_202B_200B_202B_202C_206F_202B_200C_200F_202B_206C_200F_206F_202B_200E_206D_200D_202C_206F_200F_200E_202A_206E_200E_202A_202C_202A_202E_206B_202E_202C_200D_200E_200C_206A_206D_206A_206F_206F_202E(ray7, num26, ref hit5);
				num2 = (int)(num3 * 1677064786) ^ -525751924;
				continue;
			case 70u:
				LuaScriptMgr.Push(L, hit3);
				return 2;
			case 63u:
			{
				QueryTriggerInteraction val2 = (QueryTriggerInteraction)(int)LuaScriptMgr.GetLuaObject(L, 5);
				b11 = _200C_206C_202C_206C_200F_206C_200F_202E_206E_200F_206D_206F_206C_200B_206C_202B_200F_206F_200E_206E_206C_202A_200D_200D_206F_202E_202E_206A_202B_206B_202A_202B_206B_202E_206E_206E_202E_202D_202A_202A_202E(ray8, num9, num29, num22, val2);
				num2 = ((int)num3 * -253929574) ^ 0x61F2B8E0;
				continue;
			}
			case 72u:
			{
				int num32;
				int num33;
				if (LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), null, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle)))
				{
					num32 = -1055228639;
					num33 = num32;
				}
				else
				{
					num32 = -1884167178;
					num33 = num32;
				}
				num2 = num32 ^ (int)(num3 * 1743622727);
				continue;
			}
			case 12u:
				ray7 = LuaScriptMgr.GetRay(L, 1);
				num2 = ((int)num3 * -674967298) ^ 0x12EE7DC2;
				continue;
			case 57u:
				goto IL_038f;
			case 10u:
				goto IL_03a7;
			case 16u:
				vector3 = LuaScriptMgr.GetVector3(L, 1);
				num2 = ((int)num3 * -1202875580) ^ -998801205;
				continue;
			case 31u:
				goto IL_03db;
			case 6u:
				num25 = (float)LuaDLL.lua_tonumber(L, 3);
				num2 = (int)(num3 * 1499388957) ^ -264830237;
				continue;
			case 78u:
				LuaScriptMgr.Push(L, b5);
				num2 = ((int)num3 * -581315909) ^ 0x2818B7AA;
				continue;
			case 44u:
				ray2 = LuaScriptMgr.GetRay(L, 1);
				num2 = (int)((num3 * 381214674) ^ 0x6367B4C5);
				continue;
			case 15u:
				goto IL_0447;
			case 37u:
				LuaScriptMgr.Push(L, hit5);
				num2 = ((int)num3 * -1301749176) ^ 0x7E8597F3;
				continue;
			case 48u:
				num21 = (float)LuaDLL.lua_tonumber(L, 2);
				num2 = (int)(num3 * 716615225) ^ -2085737254;
				continue;
			case 20u:
			{
				float num10 = (float)LuaScriptMgr.GetNumber(L, 2);
				bool b2 = _202C_202A_206E_206D_200F_202A_200E_202A_202D_200B_202D_206C_202E_206D_206E_206D_202E_200C_200D_200D_200C_202B_200E_200E_206A_202D_202A_206E_202E_206F_202B_206F_206E_200F_206C_202D_202A_206A_206B_202D_202E(ray3, num10);
				LuaScriptMgr.Push(L, b2);
				return 1;
			}
			case 56u:
				num9 = (float)LuaDLL.lua_tonumber(L, 2);
				num2 = ((int)num3 * -380706994) ^ 0xE6ACCF5;
				continue;
			case 3u:
				num11 = (float)LuaDLL.lua_tonumber(L, 2);
				num2 = ((int)num3 * -1556142277) ^ 0x2D509415;
				continue;
			case 76u:
				ray5 = LuaScriptMgr.GetRay(L, 1);
				num18 = (float)LuaDLL.lua_tonumber(L, 2);
				num2 = (int)((num3 * 221405089) ^ 0x303EC3CA);
				continue;
			case 77u:
			{
				int num45;
				int num46;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), null, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(int).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(QueryTriggerInteraction).TypeHandle)))
				{
					num45 = 1726632614;
					num46 = num45;
				}
				else
				{
					num45 = 132540145;
					num46 = num45;
				}
				num2 = num45 ^ ((int)num3 * -2004340090);
				continue;
			}
			case 41u:
				goto IL_057d;
			case 22u:
				return 1;
			case 8u:
				num44 = (int)LuaScriptMgr.GetNumber(L, 6);
				val3 = (QueryTriggerInteraction)(int)LuaScriptMgr.GetNetObject(L, 7, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(QueryTriggerInteraction).TypeHandle));
				num2 = (int)((num3 * 705202165) ^ 0x75B71997);
				continue;
			case 19u:
				goto IL_05df;
			case 23u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4058633461u));
				num2 = -1664503532;
				continue;
			case 60u:
			{
				int num41;
				int num42;
				if (LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), null, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(int).TypeHandle)))
				{
					num41 = -402013371;
					num42 = num41;
				}
				else
				{
					num41 = -466366047;
					num42 = num41;
				}
				num2 = num41 ^ (int)(num3 * 481953374);
				continue;
			}
			case 35u:
			{
				int num40 = (int)LuaDLL.lua_tonumber(L, 4);
				b10 = _200E_202C_200B_202A_206B_206E_200E_200B_206A_202B_206A_200C_206E_200C_206C_200B_202B_202A_202E_206B_202D_206E_206F_202B_206D_202D_200C_206D_206B_200D_200F_202B_202E_206B_206A_200F_206D_202A_206B_206F_202E(ray6, num39, num25, num40);
				num2 = ((int)num3 * -1345974977) ^ -2058280007;
				continue;
			}
			case 53u:
			{
				int num37;
				int num38;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(int).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(QueryTriggerInteraction).TypeHandle)))
				{
					num37 = -1971386233;
					num38 = num37;
				}
				else
				{
					num37 = -179824526;
					num38 = num37;
				}
				num2 = num37 ^ ((int)num3 * -60921578);
				continue;
			}
			case 47u:
				vector = LuaScriptMgr.GetVector3(L, 1);
				num2 = ((int)num3 * -514272912) ^ -136888948;
				continue;
			case 65u:
				LuaScriptMgr.Push(L, b12);
				LuaScriptMgr.Push(L, hit8);
				return 2;
			case 71u:
				goto IL_0725;
			case 51u:
				ray8 = LuaScriptMgr.GetRay(L, 1);
				num2 = (int)(num3 * 959628551) ^ -535324794;
				continue;
			case 2u:
				LuaScriptMgr.Push(L, b11);
				return 1;
			case 27u:
			{
				Vector3 vector7 = LuaScriptMgr.GetVector3(L, 3);
				float num34 = (float)LuaDLL.lua_tonumber(L, 5);
				int num35 = (int)LuaDLL.lua_tonumber(L, 6);
				b3 = _200E_206B_206F_206C_202D_202A_202A_206B_206F_200E_200D_202A_200E_206A_200E_202D_200E_200C_202E_202D_206B_202B_206E_206B_200E_202D_206C_202B_202A_202B_202E_206A_200C_202D_206C_206D_200F_200E_200F_202E_202E(vector3, num36, vector7, ref hit2, num34, num35);
				num2 = ((int)num3 * -2071726173) ^ 0x70CC7F6B;
				continue;
			}
			case 7u:
			{
				int num30;
				int num31;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), null, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle)))
				{
					num30 = -1695599444;
					num31 = num30;
				}
				else
				{
					num30 = -812863174;
					num31 = num30;
				}
				num2 = num30 ^ (int)(num3 * 306380585);
				continue;
			}
			case 0u:
				LuaScriptMgr.Push(L, b9);
				num2 = (int)(num3 * 1419861836) ^ -828067796;
				continue;
			case 75u:
				vector5 = LuaScriptMgr.GetVector3(L, 1);
				num2 = ((int)num3 * -70356675) ^ 0x30BE057C;
				continue;
			case 45u:
				LuaScriptMgr.Push(L, b10);
				num2 = (int)(num3 * 1283920115) ^ -1840920616;
				continue;
			case 11u:
				ray4 = LuaScriptMgr.GetRay(L, 1);
				num2 = (int)((num3 * 912934549) ^ 0x20A81292);
				continue;
			case 38u:
				LuaScriptMgr.Push(L, hit6);
				num2 = ((int)num3 * -2092743760) ^ -923143497;
				continue;
			case 52u:
				num29 = (float)LuaDLL.lua_tonumber(L, 3);
				num2 = ((int)num3 * -1182783441) ^ -509241470;
				continue;
			case 24u:
				goto IL_08ae;
			case 14u:
				LuaScriptMgr.Push(L, b6);
				LuaScriptMgr.Push(L, hit4);
				return 2;
			case 28u:
				vector6 = LuaScriptMgr.GetVector3(L, 3);
				num28 = (float)LuaScriptMgr.GetNumber(L, 5);
				num2 = ((int)num3 * -1958713992) ^ 0x216166FA;
				continue;
			case 55u:
				return 2;
			case 33u:
			{
				Vector3 vector4 = LuaScriptMgr.GetVector3(L, 3);
				b9 = _202B_202C_202D_202A_206E_200F_202E_206F_206A_206F_206D_206F_202B_200C_200C_202C_206E_202A_206B_202D_206F_200E_206D_200E_202B_200E_206D_206B_202B_200B_200B_206C_202D_206E_202D_206C_202D_202E_206A_202B_202E(vector5, num21, vector4, ref hit7);
				num2 = (int)((num3 * 1086807905) ^ 0x3C32C140);
				continue;
			}
			case 32u:
			{
				float num27 = (float)LuaDLL.lua_tonumber(L, 4);
				bool b8 = _202D_206D_206F_200F_206F_206D_200D_206D_206F_200B_206F_206E_202E_206D_206E_206E_206A_200E_202A_202B_206E_200D_206D_200E_206A_206A_206E_200C_200D_206E_206B_200D_200F_200B_202E_206D_200D_202E_200E_200D_202E(ray, num11, ref hit6, num27);
				LuaScriptMgr.Push(L, b8);
				num2 = (int)((num3 * 1960537595) ^ 0x7F1A499C);
				continue;
			}
			case 4u:
				num26 = (float)LuaDLL.lua_tonumber(L, 2);
				num2 = (int)(num3 * 288803493) ^ -693737433;
				continue;
			case 62u:
			{
				int num23;
				int num24;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), null))
				{
					num23 = 613313075;
					num24 = num23;
				}
				else
				{
					num23 = 473178492;
					num24 = num23;
				}
				num2 = num23 ^ ((int)num3 * -360257428);
				continue;
			}
			case 18u:
				num15 = (float)LuaDLL.lua_tonumber(L, 2);
				num2 = ((int)num3 * -1986543291) ^ -876056043;
				continue;
			case 64u:
				return 2;
			case 34u:
				ray3 = LuaScriptMgr.GetRay(L, 1);
				num2 = (int)((num3 * 1816899429) ^ 0x7351A30E);
				continue;
			case 73u:
				ray6 = LuaScriptMgr.GetRay(L, 1);
				num2 = (int)((num3 * 2022118360) ^ 0x5D4026C2);
				continue;
			case 74u:
				num14 = (float)LuaDLL.lua_tonumber(L, 2);
				num2 = ((int)num3 * -1575934811) ^ -1844244011;
				continue;
			case 49u:
				num22 = (int)LuaDLL.lua_tonumber(L, 4);
				num2 = (int)(num3 * 1048485819) ^ -1159691163;
				continue;
			case 40u:
			{
				int num19;
				int num20;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), null))
				{
					num19 = -1590802405;
					num20 = num19;
				}
				else
				{
					num19 = -1103101174;
					num20 = num19;
				}
				num2 = num19 ^ ((int)num3 * -1142015087);
				continue;
			}
			case 29u:
				vector2 = LuaScriptMgr.GetVector3(L, 3);
				num16 = (float)LuaDLL.lua_tonumber(L, 5);
				num2 = (int)((num3 * 1815864925) ^ 0x6A15D7DC);
				continue;
			case 68u:
			{
				float num17 = (float)LuaDLL.lua_tonumber(L, 3);
				bool b7 = _202B_202C_206F_206E_206A_206A_206F_200E_206B_200B_202D_202C_206A_202E_206B_206B_200B_200D_200E_206C_202B_200D_202C_200B_200E_206F_206A_206D_206B_206A_206C_202A_202A_206B_202D_200D_200C_206B_206C_200E_202E(ray5, num18, num17);
				LuaScriptMgr.Push(L, b7);
				return 1;
			}
			case 30u:
				return 2;
			case 9u:
				b6 = _202A_200F_206F_202C_206D_202C_206D_200D_202B_202A_200C_206B_200F_202D_200F_202A_206D_200B_206A_206C_206E_200B_206E_200D_202D_206E_200B_200C_200C_200E_206D_206C_200B_202D_206E_206C_206F_206B_206A_206F_202E(vector, num15, vector2, ref hit4, num16);
				num2 = ((int)num3 * -406305009) ^ 0x604BC9C4;
				continue;
			case 50u:
			{
				QueryTriggerInteraction val = (QueryTriggerInteraction)(int)LuaScriptMgr.GetLuaObject(L, 6);
				b5 = _206A_202E_206F_206A_200C_202B_206E_200B_202E_202A_200E_206A_200B_206F_202C_206D_202B_202C_202A_206F_202D_202D_202C_200B_202D_202C_200B_202D_200E_200B_202C_200E_206E_200D_202B_206E_206E_202A_200D_206D_202E(ray4, num14, ref hit3, num12, num13, val);
				num2 = ((int)num3 * -1064956439) ^ -1766326860;
				continue;
			}
			case 17u:
				LuaScriptMgr.Push(L, b4);
				num2 = (int)((num3 * 950591000) ^ 0x286C3C3D);
				continue;
			case 58u:
				LuaScriptMgr.Push(L, b3);
				LuaScriptMgr.Push(L, hit2);
				num2 = ((int)num3 * -1051134741) ^ 0x2243C593;
				continue;
			case 5u:
				goto IL_0bca;
			case 69u:
				num12 = (float)LuaDLL.lua_tonumber(L, 4);
				num13 = (int)LuaDLL.lua_tonumber(L, 5);
				num2 = ((int)num3 * -488727642) ^ 0x42EC6869;
				continue;
			case 1u:
				goto IL_0c09;
			case 26u:
			{
				int num7;
				int num8;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(int).TypeHandle)))
				{
					num7 = 632833215;
					num8 = num7;
				}
				else
				{
					num7 = 1050357404;
					num8 = num7;
				}
				num2 = num7 ^ (int)(num3 * 753166097);
				continue;
			}
			case 67u:
			{
				float num4 = (float)LuaDLL.lua_tonumber(L, 2);
				float num5 = (float)LuaDLL.lua_tonumber(L, 4);
				int num6 = (int)LuaDLL.lua_tonumber(L, 5);
				bool b = _200B_206E_206D_200E_200D_200C_202D_200B_206C_206F_206D_202A_200E_206C_202E_200B_206C_202D_202E_206D_206A_206E_200D_206E_206E_200F_206D_206D_206C_206F_206D_202D_206A_200F_206B_202B_202A_200B_202E_200E_202E(ray2, num4, ref hit, num5, num6);
				LuaScriptMgr.Push(L, b);
				LuaScriptMgr.Push(L, hit);
				return 2;
			}
			case 54u:
				ray = LuaScriptMgr.GetRay(L, 1);
				num2 = (int)((num3 * 1459193767) ^ 0x2F8FEA16);
				continue;
			default:
				return 0;
			}
			break;
			IL_0c09:
			int num51;
			if (num == 6)
			{
				num2 = -235367515;
				num51 = num2;
			}
			else
			{
				num2 = -1697727374;
				num51 = num2;
			}
			continue;
			IL_02a7:
			int num52;
			if (num != 5)
			{
				num2 = -530926617;
				num52 = num2;
			}
			else
			{
				num2 = -320365573;
				num52 = num2;
			}
			continue;
			IL_03a7:
			int num53;
			if (num != 4)
			{
				num2 = -1550311492;
				num53 = num2;
			}
			else
			{
				num2 = -739153779;
				num53 = num2;
			}
			continue;
			IL_0bca:
			int num54;
			if (num == 3)
			{
				num2 = -1567929947;
				num54 = num2;
			}
			else
			{
				num2 = -761256229;
				num54 = num2;
			}
			continue;
			IL_05df:
			int num55;
			if (num != 4)
			{
				num2 = -1732740299;
				num55 = num2;
			}
			else
			{
				num2 = -88429055;
				num55 = num2;
			}
			continue;
			IL_03db:
			int num56;
			if (num == 4)
			{
				num2 = -666984398;
				num56 = num2;
			}
			else
			{
				num2 = -967808526;
				num56 = num2;
			}
			continue;
			IL_08ae:
			int num57;
			if (num != 5)
			{
				num2 = -1499439479;
				num57 = num2;
			}
			else
			{
				num2 = -2045618105;
				num57 = num2;
			}
			continue;
			IL_038f:
			int num58;
			if (num != 6)
			{
				num2 = -1230941517;
				num58 = num2;
			}
			else
			{
				num2 = -1386420160;
				num58 = num2;
			}
			continue;
			IL_057d:
			int num59;
			if (num == 7)
			{
				num2 = -466890765;
				num59 = num2;
			}
			else
			{
				num2 = -1836908098;
				num59 = num2;
			}
			continue;
			IL_0725:
			int num60;
			if (num == 5)
			{
				num2 = -410198791;
				num60 = num2;
			}
			else
			{
				num2 = -1341391794;
				num60 = num2;
			}
		}
		goto IL_000e;
		IL_0447:
		int num61;
		if (num == 3)
		{
			num2 = -1338136410;
			num61 = num2;
		}
		else
		{
			num2 = -699441697;
			num61 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int CapsuleCastAll(IntPtr L)
	{
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		int num = LuaDLL.lua_gettop(L);
		float num10 = default(float);
		Vector3 vector7 = default(Vector3);
		Vector3 vector4 = default(Vector3);
		Vector3 vector3 = default(Vector3);
		float num7 = default(float);
		float num8 = default(float);
		Vector3 vector6 = default(Vector3);
		Vector3 vector10 = default(Vector3);
		Vector3 vector11 = default(Vector3);
		Vector3 vector5 = default(Vector3);
		Vector3 vector12 = default(Vector3);
		float num13 = default(float);
		Vector3 vector8 = default(Vector3);
		Vector3 vector = default(Vector3);
		float num5 = default(float);
		int num4 = default(int);
		RaycastHit[] o3 = default(RaycastHit[]);
		float num9 = default(float);
		Vector3 vector9 = default(Vector3);
		float num12 = default(float);
		Vector3 vector2 = default(Vector3);
		QueryTriggerInteraction val = default(QueryTriggerInteraction);
		int num6 = default(int);
		while (true)
		{
			int num2 = -1728921831;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -581350506)) % 30)
				{
				case 28u:
					break;
				case 9u:
					num10 = (float)LuaScriptMgr.GetNumber(L, 3);
					vector7 = LuaScriptMgr.GetVector3(L, 4);
					num2 = (int)(num3 * 1262961265) ^ -868165887;
					continue;
				case 21u:
					vector4 = LuaScriptMgr.GetVector3(L, 4);
					num2 = ((int)num3 * -2048609273) ^ -841105762;
					continue;
				case 17u:
					vector3 = LuaScriptMgr.GetVector3(L, 2);
					num7 = (float)LuaScriptMgr.GetNumber(L, 3);
					num2 = ((int)num3 * -1876834088) ^ 0x12AFB1AB;
					continue;
				case 27u:
				{
					int num15;
					int num16;
					if (num == 4)
					{
						num15 = 963974510;
						num16 = num15;
					}
					else
					{
						num15 = 549692612;
						num16 = num15;
					}
					num2 = num15 ^ ((int)num3 * -1247027708);
					continue;
				}
				case 15u:
					num8 = (float)LuaScriptMgr.GetNumber(L, 5);
					num2 = ((int)num3 * -514017242) ^ 0xD29D1C3;
					continue;
				case 2u:
					vector6 = LuaScriptMgr.GetVector3(L, 2);
					num2 = ((int)num3 * -1922823623) ^ 0xFBA5237;
					continue;
				case 0u:
				{
					int num17;
					if (num != 5)
					{
						num2 = -1792311566;
						num17 = num2;
					}
					else
					{
						num2 = -778445654;
						num17 = num2;
					}
					continue;
				}
				case 10u:
					vector10 = LuaScriptMgr.GetVector3(L, 1);
					vector11 = LuaScriptMgr.GetVector3(L, 2);
					num2 = ((int)num3 * -1091208517) ^ -1416546136;
					continue;
				case 16u:
				{
					int num14;
					if (num == 7)
					{
						num2 = -1013720059;
						num14 = num2;
					}
					else
					{
						num2 = -1885742149;
						num14 = num2;
					}
					continue;
				}
				case 18u:
					vector5 = LuaScriptMgr.GetVector3(L, 1);
					num2 = ((int)num3 * -2053518148) ^ -2092263048;
					continue;
				case 19u:
					vector12 = LuaScriptMgr.GetVector3(L, 2);
					num13 = (float)LuaScriptMgr.GetNumber(L, 3);
					num2 = ((int)num3 * -1856050276) ^ -887464597;
					continue;
				case 26u:
				{
					RaycastHit[] o4 = _202A_202B_200B_206E_202A_206A_206F_200D_206C_200B_202C_202C_200B_206F_202D_202A_200B_206D_202D_202A_202B_200F_206C_200E_202A_202E_200F_206A_202E_200B_202D_206E_202D_206D_206B_206B_200F_200E_202B_200C_202E(vector8, vector12, num13, vector, num5, num4);
					LuaScriptMgr.PushArray(L, o4);
					return 1;
				}
				case 4u:
					o3 = _200C_202A_202E_206C_200E_200F_206B_206C_200F_202E_200D_200D_206B_206D_202E_202E_206A_206F_202D_200D_202B_200B_200C_206C_202A_202C_206F_206E_206C_200C_202A_202B_202D_200F_206F_206B_206B_206B_206D_206D_202E(vector10, vector11, num9, vector9, num12);
					num2 = (int)((num3 * 798716538) ^ 0x1CF61CF2);
					continue;
				case 12u:
					num12 = (float)LuaScriptMgr.GetNumber(L, 5);
					num2 = (int)((num3 * 1212351963) ^ 0x1345972A);
					continue;
				case 23u:
					vector9 = LuaScriptMgr.GetVector3(L, 4);
					num2 = ((int)num3 * -1859065272) ^ -2057820116;
					continue;
				case 24u:
				{
					int num11;
					if (num == 6)
					{
						num2 = -51252628;
						num11 = num2;
					}
					else
					{
						num2 = -1907821412;
						num11 = num2;
					}
					continue;
				}
				case 6u:
					vector8 = LuaScriptMgr.GetVector3(L, 1);
					num2 = (int)((num3 * 1361887064) ^ 0x515A0327);
					continue;
				case 29u:
					return 1;
				case 5u:
					vector2 = LuaScriptMgr.GetVector3(L, 1);
					num2 = (int)((num3 * 1453294830) ^ 0x1AAE4FEB);
					continue;
				case 8u:
					LuaScriptMgr.PushArray(L, o3);
					num2 = (int)(num3 * 511197130) ^ -21459595;
					continue;
				case 14u:
				{
					RaycastHit[] o2 = _200B_202D_200F_200E_202E_202A_202B_200E_202E_206C_200C_206B_200F_200D_200C_206D_202E_206C_202B_206B_206D_206F_202A_202E_202A_200D_206E_202A_206D_206D_206D_206F_206B_200E_202B_202C_206A_202C_206F_200C_202E(vector5, vector6, num10, vector7);
					LuaScriptMgr.PushArray(L, o2);
					return 1;
				}
				case 20u:
					num9 = (float)LuaScriptMgr.GetNumber(L, 3);
					num2 = (int)((num3 * 1305459379) ^ 0x251D69A1);
					continue;
				case 22u:
					val = (QueryTriggerInteraction)(int)LuaScriptMgr.GetNetObject(L, 7, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(QueryTriggerInteraction).TypeHandle));
					num2 = ((int)num3 * -1490218514) ^ -1567639765;
					continue;
				case 25u:
				{
					RaycastHit[] o = _200C_200F_202A_202E_200C_200D_202B_200B_200D_200D_206F_200E_206E_202E_202B_202B_202D_202B_206A_206A_200F_200B_206A_200F_202C_200C_202D_200D_202C_202C_202D_200C_202C_200F_206B_206C_200D_202B_202B_202E(vector2, vector3, num7, vector4, num8, num6, val);
					LuaScriptMgr.PushArray(L, o);
					num2 = ((int)num3 * -1805195045) ^ 0x65925AE0;
					continue;
				}
				case 1u:
					num6 = (int)LuaScriptMgr.GetNumber(L, 6);
					num2 = (int)((num3 * 131875334) ^ 0x79065F24);
					continue;
				case 11u:
					vector = LuaScriptMgr.GetVector3(L, 4);
					num5 = (float)LuaScriptMgr.GetNumber(L, 5);
					num2 = ((int)num3 * -426916539) ^ 0xA91AE10;
					continue;
				case 7u:
					return 1;
				case 3u:
					num4 = (int)LuaScriptMgr.GetNumber(L, 6);
					num2 = ((int)num3 * -1825783139) ^ -345186463;
					continue;
				default:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1406007494u));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SphereCastAll(IntPtr L)
	{
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_077c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0780: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_072e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0732: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Unknown result type (might be due to invalid IL or missing references)
		//IL_075c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_079e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		int num = LuaDLL.lua_gettop(L);
		Vector3 vector4 = default(Vector3);
		Vector3 vector = default(Vector3);
		float num6 = default(float);
		Vector3 vector2 = default(Vector3);
		float num7 = default(float);
		int num8 = default(int);
		QueryTriggerInteraction val = default(QueryTriggerInteraction);
		float num13 = default(float);
		Vector3 vector5 = default(Vector3);
		RaycastHit[] o2 = default(RaycastHit[]);
		Ray ray = default(Ray);
		float num12 = default(float);
		RaycastHit[] o4 = default(RaycastHit[]);
		RaycastHit[] o5 = default(RaycastHit[]);
		RaycastHit[] o7 = default(RaycastHit[]);
		Vector3 vector3 = default(Vector3);
		Vector3 vector8 = default(Vector3);
		float num32 = default(float);
		float num38 = default(float);
		Ray ray4 = default(Ray);
		RaycastHit[] o3 = default(RaycastHit[]);
		Ray ray2 = default(Ray);
		float num15 = default(float);
		float num19 = default(float);
		float num10 = default(float);
		int num11 = default(int);
		float num16 = default(float);
		Vector3 vector7 = default(Vector3);
		Vector3 vector6 = default(Vector3);
		Ray ray3 = default(Ray);
		float num20 = default(float);
		float num21 = default(float);
		int num22 = default(int);
		float num17 = default(float);
		int num18 = default(int);
		while (true)
		{
			int num2 = 722941342;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x180E8FB7)) % 53)
				{
				case 8u:
					break;
				case 41u:
					vector4 = LuaScriptMgr.GetVector3(L, 1);
					num2 = ((int)num3 * -724199916) ^ -658417842;
					continue;
				case 4u:
				{
					RaycastHit[] o = _202B_200F_200E_200C_200B_202A_202A_202E_206A_200C_202B_206A_200B_206F_202B_200D_200C_200C_200E_202B_206A_206D_206E_202E_206B_202B_202A_206F_200E_202A_200D_200E_202C_206F_202C_206F_206F_206D_202D_206E_202E(vector, num6, vector2, num7, num8, val);
					LuaScriptMgr.PushArray(L, o);
					num2 = (int)((num3 * 1656312131) ^ 0x622DB78F);
					continue;
				}
				case 9u:
					num13 = (float)LuaDLL.lua_tonumber(L, 2);
					vector5 = LuaScriptMgr.GetVector3(L, 3);
					num2 = ((int)num3 * -220348313) ^ -1200803678;
					continue;
				case 27u:
					o2 = _202C_202D_200E_200F_202A_206C_200F_206A_200D_200D_206E_206A_202D_202E_202A_202C_206D_206A_202E_206C_206F_206C_206C_202B_206F_200C_206F_202A_206D_206F_206D_206B_206D_206E_200E_200D_200E_206D_202C_206E_202E(ray, num12);
					num2 = ((int)num3 * -414798531) ^ 0x656011E2;
					continue;
				case 42u:
					return 1;
				case 50u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3790048813u));
					num2 = 407519897;
					continue;
				case 31u:
					num8 = (int)LuaScriptMgr.GetNumber(L, 5);
					val = (QueryTriggerInteraction)(int)LuaScriptMgr.GetNetObject(L, 6, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(QueryTriggerInteraction).TypeHandle));
					num2 = ((int)num3 * -786568184) ^ -994853167;
					continue;
				case 10u:
					LuaScriptMgr.PushArray(L, o4);
					num2 = ((int)num3 * -435973818) ^ 0x1B758A53;
					continue;
				case 17u:
					LuaScriptMgr.PushArray(L, o5);
					return 1;
				case 51u:
					LuaScriptMgr.PushArray(L, o7);
					return 1;
				case 49u:
					num7 = (float)LuaScriptMgr.GetNumber(L, 4);
					num2 = ((int)num3 * -959749865) ^ 0x3AC45D74;
					continue;
				case 30u:
				{
					int num9;
					if (num == 3)
					{
						num2 = 65902033;
						num9 = num2;
					}
					else
					{
						num2 = 1551935555;
						num9 = num2;
					}
					continue;
				}
				case 45u:
					vector3 = LuaScriptMgr.GetVector3(L, 3);
					num2 = (int)((num3 * 1065121977) ^ 0x27E4B104);
					continue;
				case 0u:
				{
					int num39;
					if (num == 6)
					{
						num2 = 2135901363;
						num39 = num2;
					}
					else
					{
						num2 = 1704297716;
						num39 = num2;
					}
					continue;
				}
				case 26u:
					o7 = _200D_200E_206C_206D_206F_200F_206C_206B_206B_206B_206D_206D_202B_200C_200D_202E_202E_202B_206E_202D_206F_206D_202A_206F_202A_202C_202D_202A_206F_202E_206A_200F_202D_206E_200F_206F_206E_202B_206D_202A_202E(vector8, num32, vector3, num38);
					num2 = ((int)num3 * -1847896264) ^ -856439936;
					continue;
				case 21u:
				{
					int num35;
					if (num != 5)
					{
						num2 = 1592209007;
						num35 = num2;
					}
					else
					{
						num2 = 49752256;
						num35 = num2;
					}
					continue;
				}
				case 35u:
					ray4 = LuaScriptMgr.GetRay(L, 1);
					num2 = ((int)num3 * -1952824826) ^ 0x3783FC2E;
					continue;
				case 40u:
				{
					int num30;
					int num31;
					if (LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(int).TypeHandle)))
					{
						num30 = -1719612888;
						num31 = num30;
					}
					else
					{
						num30 = -1776361095;
						num31 = num30;
					}
					num2 = num30 ^ (int)(num3 * 1285105994);
					continue;
				}
				case 39u:
					return 1;
				case 33u:
				{
					int num25;
					int num26;
					if (!LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle)))
					{
						num25 = 102825820;
						num26 = num25;
					}
					else
					{
						num25 = 492729330;
						num26 = num25;
					}
					num2 = num25 ^ (int)(num3 * 469869020);
					continue;
				}
				case 20u:
				{
					int num41;
					int num42;
					if (!LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(int).TypeHandle)))
					{
						num41 = -1011468323;
						num42 = num41;
					}
					else
					{
						num41 = -719088535;
						num42 = num41;
					}
					num2 = num41 ^ (int)(num3 * 1947746899);
					continue;
				}
				case 16u:
					num38 = (float)LuaDLL.lua_tonumber(L, 4);
					num2 = (int)(num3 * 390117666) ^ -1116747252;
					continue;
				case 13u:
					LuaScriptMgr.PushArray(L, o3);
					return 1;
				case 46u:
					ray2 = LuaScriptMgr.GetRay(L, 1);
					num15 = (float)LuaDLL.lua_tonumber(L, 2);
					num2 = (int)(num3 * 1910141840) ^ -1540339280;
					continue;
				case 23u:
				{
					RaycastHit[] o8 = _206B_206D_206B_206E_206A_200F_202B_202B_200F_206D_200E_202D_206D_206E_206E_200B_202B_202A_206B_200B_206A_206F_202A_200B_206B_206B_200D_206B_202E_206F_202D_206A_202E_202B_206A_202C_200C_200B_202E_202E(ray4, num19, num10, num11);
					LuaScriptMgr.PushArray(L, o8);
					return 1;
				}
				case 29u:
				{
					int num40;
					if (num == 4)
					{
						num2 = 1693651462;
						num40 = num2;
					}
					else
					{
						num2 = 474419027;
						num40 = num2;
					}
					continue;
				}
				case 36u:
				{
					int num37;
					if (num == 3)
					{
						num2 = 1962060680;
						num37 = num2;
					}
					else
					{
						num2 = 1733085442;
						num37 = num2;
					}
					continue;
				}
				case 6u:
				{
					int num36;
					if (num != 4)
					{
						num2 = 209192596;
						num36 = num2;
					}
					else
					{
						num2 = 1060121641;
						num36 = num2;
					}
					continue;
				}
				case 37u:
				{
					int num33;
					int num34;
					if (!LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle)))
					{
						num33 = -52339809;
						num34 = num33;
					}
					else
					{
						num33 = -751278723;
						num34 = num33;
					}
					num2 = num33 ^ ((int)num3 * -779361757);
					continue;
				}
				case 38u:
					vector8 = LuaScriptMgr.GetVector3(L, 1);
					num32 = (float)LuaDLL.lua_tonumber(L, 2);
					num2 = (int)((num3 * 1489185168) ^ 0x1408B46D);
					continue;
				case 47u:
					return 1;
				case 11u:
					vector = LuaScriptMgr.GetVector3(L, 1);
					num2 = ((int)num3 * -1346946016) ^ 0x36CDC387;
					continue;
				case 14u:
					num16 = (float)LuaDLL.lua_tonumber(L, 2);
					vector7 = LuaScriptMgr.GetVector3(L, 3);
					num2 = ((int)num3 * -1240259788) ^ -1744747806;
					continue;
				case 48u:
				{
					int num28;
					int num29;
					if (num == 2)
					{
						num28 = -35449600;
						num29 = num28;
					}
					else
					{
						num28 = -23383217;
						num29 = num28;
					}
					num2 = num28 ^ (int)(num3 * 1686478803);
					continue;
				}
				case 1u:
					vector6 = LuaScriptMgr.GetVector3(L, 1);
					num2 = ((int)num3 * -33838590) ^ -1504035413;
					continue;
				case 5u:
					ray3 = LuaScriptMgr.GetRay(L, 1);
					num20 = (float)LuaDLL.lua_tonumber(L, 2);
					num21 = (float)LuaDLL.lua_tonumber(L, 3);
					num22 = (int)LuaDLL.lua_tonumber(L, 4);
					num2 = (int)((num3 * 577029949) ^ 0x48027EFD);
					continue;
				case 34u:
				{
					int num27;
					if (num != 5)
					{
						num2 = 1762523160;
						num27 = num2;
					}
					else
					{
						num2 = 2058591536;
						num27 = num2;
					}
					continue;
				}
				case 15u:
					num6 = (float)LuaScriptMgr.GetNumber(L, 2);
					num2 = ((int)num3 * -1644618027) ^ 0x5BAB78E3;
					continue;
				case 43u:
				{
					int num23;
					int num24;
					if (!LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(int).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(QueryTriggerInteraction).TypeHandle)))
					{
						num23 = 1700436195;
						num24 = num23;
					}
					else
					{
						num23 = 184158640;
						num24 = num23;
					}
					num2 = num23 ^ ((int)num3 * -1412745004);
					continue;
				}
				case 12u:
				{
					QueryTriggerInteraction val2 = (QueryTriggerInteraction)(int)LuaScriptMgr.GetLuaObject(L, 5);
					RaycastHit[] o6 = _200B_206B_200D_202E_206B_200D_200F_200E_202D_200E_200B_200E_200E_202B_200C_206F_206C_206C_200B_200B_202E_200E_206A_200C_200C_202B_202A_206A_206A_202E_206D_200D_206B_200C_206D_200D_206C_206A_206E_202B_202E(ray3, num20, num21, num22, val2);
					LuaScriptMgr.PushArray(L, o6);
					num2 = ((int)num3 * -467831240) ^ 0x2A9E8D92;
					continue;
				}
				case 18u:
					num19 = (float)LuaDLL.lua_tonumber(L, 2);
					num2 = ((int)num3 * -849259595) ^ -412040381;
					continue;
				case 44u:
					return 1;
				case 25u:
					num17 = (float)LuaDLL.lua_tonumber(L, 4);
					num18 = (int)LuaDLL.lua_tonumber(L, 5);
					num2 = (int)(num3 * 2006611653) ^ -351269448;
					continue;
				case 7u:
					o5 = _206D_200E_206A_202B_200C_206C_206F_200D_206B_200D_202E_202B_206E_202A_200F_206F_200D_202D_202D_200C_200C_202A_200D_206E_200D_200E_202D_202B_202B_206B_202D_202D_202B_206E_206C_202B_206B_206C_200D_206E_202E(vector6, num16, vector7, num17, num18);
					num2 = ((int)num3 * -2067864276) ^ 0x2D2DCEB0;
					continue;
				case 19u:
				{
					float num14 = (float)LuaDLL.lua_tonumber(L, 3);
					o4 = _202B_202B_200C_202A_200B_202D_202C_202C_206F_206F_206F_200D_202D_200F_206A_206E_202B_202C_206C_200D_206D_206F_200D_206F_202A_206E_200C_200E_206F_200D_200F_200D_202B_206C_206A_206F_202C_200C_200F_202B_202E(ray2, num15, num14);
					num2 = (int)((num3 * 1940686732) ^ 0x1B823277);
					continue;
				}
				case 2u:
					o3 = _202E_202E_206E_200F_202A_206E_202B_202E_206D_206F_202C_202C_206F_200F_206B_202D_206C_206A_200F_202D_202C_202B_200E_202C_200E_202E_206C_200E_202B_202A_202D_200F_202C_200E_200D_206E_200D_206A_200E_206D_202E(vector4, num13, vector5);
					num2 = (int)((num3 * 1670929247) ^ 0x6AA5C563);
					continue;
				case 32u:
					ray = LuaScriptMgr.GetRay(L, 1);
					num12 = (float)LuaScriptMgr.GetNumber(L, 2);
					num2 = ((int)num3 * -36263081) ^ -2094777743;
					continue;
				case 28u:
					num10 = (float)LuaDLL.lua_tonumber(L, 3);
					num11 = (int)LuaDLL.lua_tonumber(L, 4);
					num2 = (int)(num3 * 181440664) ^ -1703028234;
					continue;
				case 24u:
					vector2 = LuaScriptMgr.GetVector3(L, 3);
					num2 = ((int)num3 * -934380214) ^ -1197823158;
					continue;
				case 22u:
					LuaScriptMgr.PushArray(L, o2);
					num2 = ((int)num3 * -591322661) ^ 0xE922B09;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (LuaScriptMgr.CheckTypes(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(LuaTable).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle), _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(float).TypeHandle)))
					{
						num4 = 159163119;
						num5 = num4;
					}
					else
					{
						num4 = 1985708337;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 1671962211);
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
	private static int CheckSphere(IntPtr L)
	{
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		int num = LuaDLL.lua_gettop(L);
		if (num == 2)
		{
			goto IL_000e;
		}
		goto IL_009d;
		IL_000e:
		int num2 = 1491248213;
		goto IL_0013;
		IL_0013:
		bool b = default(bool);
		Vector3 vector2 = default(Vector3);
		float num6 = default(float);
		int num7 = default(int);
		QueryTriggerInteraction val = default(QueryTriggerInteraction);
		bool b2 = default(bool);
		Vector3 vector = default(Vector3);
		float num4 = default(float);
		int num5 = default(int);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ 0x73CE6021)) % 16)
			{
			case 10u:
				break;
			case 6u:
				return 1;
			case 15u:
				b = _202D_200B_206B_202D_202E_200F_206D_202B_206C_200E_200E_202B_200B_202A_206B_202D_200C_206A_200F_206C_202A_200B_206F_206E_202D_206C_206D_206C_206C_202C_206D_200D_206C_202B_200F_200F_206A_202C_206D_202C_202E(vector2, num6, num7, val);
				num2 = (int)((num3 * 197941780) ^ 0x49703250);
				continue;
			case 8u:
				goto IL_009d;
			case 4u:
			{
				Vector3 vector3 = LuaScriptMgr.GetVector3(L, 1);
				float num8 = (float)LuaScriptMgr.GetNumber(L, 2);
				bool b3 = _200C_206A_202B_200C_200B_202A_202B_206F_200F_206F_206C_206B_206A_200B_206B_202D_200B_202E_202B_206C_200D_206E_202B_206A_206F_206E_200C_206D_200B_200C_206E_200B_200C_200D_202B_206D_200D_202D_202A_202C_202E(vector3, num8);
				LuaScriptMgr.Push(L, b3);
				return 1;
			}
			case 0u:
				num7 = (int)LuaScriptMgr.GetNumber(L, 3);
				val = (QueryTriggerInteraction)(int)LuaScriptMgr.GetNetObject(L, 4, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(QueryTriggerInteraction).TypeHandle));
				num2 = ((int)num3 * -1937757788) ^ -1792483346;
				continue;
			case 14u:
				LuaScriptMgr.Push(L, b2);
				num2 = (int)(num3 * 362685150) ^ -594171225;
				continue;
			case 2u:
				return 1;
			case 1u:
				b2 = _206A_200B_206C_206D_200C_200C_202E_202C_200C_200C_206B_200E_202D_202B_202C_206C_206F_202A_206A_206D_202B_202A_200C_200E_202A_206A_200C_200C_200D_200C_202C_202D_202C_202A_202A_206E_206A_200D_206C_206C_202E(vector, num4, num5);
				num2 = ((int)num3 * -934413059) ^ -1688767742;
				continue;
			case 12u:
				vector2 = LuaScriptMgr.GetVector3(L, 1);
				num6 = (float)LuaScriptMgr.GetNumber(L, 2);
				num2 = ((int)num3 * -683178930) ^ -2018047447;
				continue;
			case 5u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(123856660u));
				num2 = 196630168;
				continue;
			case 7u:
				goto IL_01af;
			case 3u:
				vector = LuaScriptMgr.GetVector3(L, 1);
				num2 = ((int)num3 * -815185590) ^ 0x21FE6454;
				continue;
			case 11u:
				num4 = (float)LuaScriptMgr.GetNumber(L, 2);
				num5 = (int)LuaScriptMgr.GetNumber(L, 3);
				num2 = (int)(num3 * 1581756778) ^ -1533592466;
				continue;
			case 13u:
				LuaScriptMgr.Push(L, b);
				num2 = (int)(num3 * 2044004230) ^ -40937207;
				continue;
			default:
				return 0;
			}
			break;
			IL_01af:
			int num9;
			if (num == 4)
			{
				num2 = 238960429;
				num9 = num2;
			}
			else
			{
				num2 = 652778468;
				num9 = num2;
			}
		}
		goto IL_000e;
		IL_009d:
		int num10;
		if (num == 3)
		{
			num2 = 1811158610;
			num10 = num2;
		}
		else
		{
			num2 = 1942055670;
			num10 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int CheckCapsule(IntPtr L)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		int num = LuaDLL.lua_gettop(L);
		Vector3 vector5 = default(Vector3);
		bool b2 = default(bool);
		Vector3 vector = default(Vector3);
		Vector3 vector2 = default(Vector3);
		float num8 = default(float);
		float num4 = default(float);
		int num5 = default(int);
		QueryTriggerInteraction val = default(QueryTriggerInteraction);
		Vector3 vector3 = default(Vector3);
		Vector3 vector4 = default(Vector3);
		int num6 = default(int);
		while (true)
		{
			int num2 = -661843672;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1793128497)) % 19)
				{
				case 6u:
					break;
				case 14u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(779001694u));
					num2 = -2009978995;
					continue;
				case 13u:
					return 1;
				case 2u:
					vector5 = LuaScriptMgr.GetVector3(L, 1);
					num2 = (int)(num3 * 610161944) ^ -2001938741;
					continue;
				case 18u:
					LuaScriptMgr.Push(L, b2);
					return 1;
				case 15u:
					vector = LuaScriptMgr.GetVector3(L, 1);
					vector2 = LuaScriptMgr.GetVector3(L, 2);
					num2 = ((int)num3 * -440315828) ^ 0x315A03D8;
					continue;
				case 9u:
				{
					int num12;
					if (num == 4)
					{
						num2 = -680458554;
						num12 = num2;
					}
					else
					{
						num2 = -572578749;
						num12 = num2;
					}
					continue;
				}
				case 10u:
					num8 = (float)LuaScriptMgr.GetNumber(L, 3);
					num2 = ((int)num3 * -1797372679) ^ 0x6AAB78D7;
					continue;
				case 8u:
				{
					Vector3 vector6 = LuaScriptMgr.GetVector3(L, 2);
					float num11 = (float)LuaScriptMgr.GetNumber(L, 3);
					bool b3 = _206E_202C_206E_206F_206E_202A_206A_200E_206D_202B_200C_200D_206B_202A_202B_206B_206D_200F_202E_200E_206D_206A_200E_202B_206F_202D_206F_206D_200F_206E_202C_206D_202E_206D_200E_206A_202E_200C_206F_206C_202E(vector5, vector6, num11);
					LuaScriptMgr.Push(L, b3);
					num2 = (int)((num3 * 2121276993) ^ 0x7D8A8128);
					continue;
				}
				case 12u:
					num4 = (float)LuaScriptMgr.GetNumber(L, 3);
					num2 = ((int)num3 * -788655059) ^ -1662179726;
					continue;
				case 7u:
				{
					int num9;
					int num10;
					if (num == 3)
					{
						num9 = -730288553;
						num10 = num9;
					}
					else
					{
						num9 = -1074069338;
						num10 = num9;
					}
					num2 = num9 ^ (int)(num3 * 1910558260);
					continue;
				}
				case 5u:
					num5 = (int)LuaScriptMgr.GetNumber(L, 4);
					val = (QueryTriggerInteraction)(int)LuaScriptMgr.GetNetObject(L, 5, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(QueryTriggerInteraction).TypeHandle));
					num2 = (int)((num3 * 1706985685) ^ 0x4336D951);
					continue;
				case 4u:
					vector3 = LuaScriptMgr.GetVector3(L, 1);
					vector4 = LuaScriptMgr.GetVector3(L, 2);
					num2 = (int)(num3 * 1389974622) ^ -1966775714;
					continue;
				case 16u:
					b2 = _206A_202E_200F_200B_202E_200F_206F_206C_206D_200E_202C_200F_206C_202E_206D_206F_200B_200D_200E_202C_200D_200D_200E_206B_206D_200C_206D_202D_202E_206A_200C_206A_206A_206A_200D_200B_200B_202D_206C_202E(vector3, vector4, num8, num6);
					num2 = ((int)num3 * -1139780296) ^ 0x144DCBC4;
					continue;
				case 0u:
				{
					int num7;
					if (num != 5)
					{
						num2 = -1876965664;
						num7 = num2;
					}
					else
					{
						num2 = -1301848022;
						num7 = num2;
					}
					continue;
				}
				case 1u:
					num6 = (int)LuaScriptMgr.GetNumber(L, 4);
					num2 = (int)(num3 * 270073541) ^ -198044917;
					continue;
				case 11u:
				{
					bool b = _202C_206F_202C_200E_206F_200C_200B_206C_200B_206D_200C_202C_206B_200B_206C_206A_200E_200B_206A_206D_206E_206E_202B_200B_206E_206E_206F_206B_202C_206B_206D_206F_200D_200E_206D_200F_202B_200B_202B_202E(vector, vector2, num4, num5, val);
					LuaScriptMgr.Push(L, b);
					num2 = ((int)num3 * -561984434) ^ -349062926;
					continue;
				}
				case 17u:
					return 1;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int IgnoreCollision(IntPtr L)
	{
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		Collider val4 = default(Collider);
		Collider val3 = default(Collider);
		bool boolean = default(bool);
		while (true)
		{
			int num2 = -1325225269;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1832630667)) % 10)
				{
				case 3u:
					break;
				case 4u:
				{
					int num5;
					int num6;
					if (num == 2)
					{
						num5 = -969539102;
						num6 = num5;
					}
					else
					{
						num5 = -1735269228;
						num6 = num5;
					}
					num2 = num5 ^ (int)(num3 * 1210924731);
					continue;
				}
				case 6u:
					val4 = (Collider)LuaScriptMgr.GetUnityObject(L, 2, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(Collider).TypeHandle));
					num2 = ((int)num3 * -483617764) ^ -2029218679;
					continue;
				case 7u:
					_200E_206B_202D_206F_202B_206F_202A_206F_200F_200B_200C_206E_202B_200C_200E_206F_206F_202A_206B_200F_200E_206B_200F_200F_206E_202C_206B_202E_206D_200B_202A_200F_206E_206C_200E_202E_202E_206E_202D_206C_202E(val3, val4, boolean);
					return 0;
				case 5u:
				{
					int num4;
					if (num != 3)
					{
						num2 = -1594119438;
						num4 = num2;
					}
					else
					{
						num2 = -1976544525;
						num4 = num2;
					}
					continue;
				}
				case 2u:
					val3 = (Collider)LuaScriptMgr.GetUnityObject(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(Collider).TypeHandle));
					num2 = (int)(num3 * 1689074653) ^ -1307202739;
					continue;
				case 0u:
					return 0;
				case 1u:
				{
					Collider val = (Collider)LuaScriptMgr.GetUnityObject(L, 1, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(Collider).TypeHandle));
					Collider val2 = (Collider)LuaScriptMgr.GetUnityObject(L, 2, _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(typeof(Collider).TypeHandle));
					_206A_206A_200B_200D_202E_206F_202A_200D_202E_202D_206F_200D_200C_206B_200C_202D_200E_200C_202D_206A_202C_206A_206A_200F_206F_202D_200E_206F_206C_200C_206D_200E_206D_202B_206E_202D_206E_200C_206D_202E_202E(val, val2);
					num2 = (int)((num3 * 894690184) ^ 0x71427BA9);
					continue;
				}
				case 8u:
					boolean = LuaScriptMgr.GetBoolean(L, 3);
					num2 = ((int)num3 * -623163433) ^ -1599255122;
					continue;
				default:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1803231292u));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int IgnoreLayerCollision(IntPtr L)
	{
		int num = LuaDLL.lua_gettop(L);
		int num5 = default(int);
		int num7 = default(int);
		while (true)
		{
			int num2 = -1110792857;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1393063031)) % 10)
				{
				case 5u:
					break;
				case 9u:
					num5 = (int)LuaScriptMgr.GetNumber(L, 1);
					num2 = ((int)num3 * -1260629743) ^ -505662582;
					continue;
				case 7u:
					num7 = (int)LuaScriptMgr.GetNumber(L, 1);
					num2 = ((int)num3 * -1750692456) ^ -1940050345;
					continue;
				case 2u:
				{
					int num9;
					int num10;
					if (num == 2)
					{
						num9 = 1206229556;
						num10 = num9;
					}
					else
					{
						num9 = 509085997;
						num10 = num9;
					}
					num2 = num9 ^ ((int)num3 * -368094903);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1566244706u));
					num2 = -1956879612;
					continue;
				case 1u:
					return 0;
				case 6u:
				{
					int num8 = (int)LuaScriptMgr.GetNumber(L, 2);
					_202A_206A_206E_200D_206F_200E_202D_202D_206D_202E_206A_206E_200D_202C_206D_206C_206A_200C_206C_200D_200D_202A_202A_202E_202C_206F_202D_202A_202B_206A_206D_202A_206E_206A_202E_206B_206C_206F_202D_202A_202E(num7, num8);
					return 0;
				}
				case 0u:
				{
					int num6;
					if (num == 3)
					{
						num2 = -1948842178;
						num6 = num2;
					}
					else
					{
						num2 = -244642357;
						num6 = num2;
					}
					continue;
				}
				case 8u:
				{
					int num4 = (int)LuaScriptMgr.GetNumber(L, 2);
					bool boolean = LuaScriptMgr.GetBoolean(L, 3);
					_206F_206F_206F_200B_206B_206B_200F_200C_200D_200C_202A_202E_206D_202C_202C_206C_202B_202D_202D_202E_200D_202D_202C_206F_206D_202C_206E_206C_202D_206B_200E_202E_206F_206C_202B_206C_206F_202C_206E_206C_202E(num5, num4, boolean);
					num2 = ((int)num3 * -984396442) ^ -765043098;
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
	private static int GetIgnoreLayerCollision(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		int num = (int)LuaScriptMgr.GetNumber(L, 1);
		bool b = default(bool);
		while (true)
		{
			int num2 = 1077043763;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x2F785801)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0032;
				default:
					LuaScriptMgr.Push(L, b);
					return 1;
				}
				break;
				IL_0032:
				int num4 = (int)LuaScriptMgr.GetNumber(L, 2);
				b = _206E_206E_202E_200F_200D_202C_202E_206F_200D_202E_200C_200B_206F_206C_206C_206C_200F_206D_200E_200F_200B_202A_202B_206C_206D_206B_200E_202C_200C_202D_206F_206F_206F_200D_200B_206D_206F_202D_206C_202E_202E(num, num4);
				num2 = (int)((num3 * 1832316859) ^ 0x338F7278);
			}
		}
	}

	static Type _200D_200F_200C_206E_202D_200C_202B_206F_206A_206F_206A_200C_206C_202C_200B_206C_206E_202D_202E_202E_200E_206E_206E_202A_202D_206F_200B_200C_202C_202E_200C_200E_200E_202A_206A_200F_200B_206E_206E_200D_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static Physics _200E_206F_202D_200D_206A_206B_200D_206F_202B_202C_206C_206A_202E_206A_206E_200C_206A_200E_206E_202D_200D_202B_206F_200E_202E_206B_200F_200D_202D_206B_202A_200D_202B_200B_206D_206F_200F_200E_206A_206A_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Physics();
	}

	static Vector3 _202A_202C_200F_206B_202D_206D_206B_200F_202B_202B_200D_200D_206B_200E_200D_206B_206A_200F_206C_202C_206E_200C_206E_202A_202B_202B_200E_206A_202D_202E_206A_202D_206E_202C_206C_206C_202A_202C_202A_202E_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Physics.gravity;
	}

	static float _206E_206E_200D_200F_200F_202C_200E_202E_206B_202D_202B_200D_206B_200C_200F_206E_206E_206F_206F_206F_200F_200D_202E_200C_200E_200F_202E_200F_202E_206C_206B_202E_206F_206A_206E_200B_206B_206E_202B_200E_202E()
	{
		return Physics.defaultContactOffset;
	}

	static float _202A_200D_202A_206F_200B_200E_206B_206C_200E_206A_200D_206F_202A_202D_200C_200F_200C_202D_200B_200E_206C_200C_202E_202C_206F_206D_202C_200C_206B_206A_200D_206E_202C_206B_206D_206C_200D_202D_202D_206D_202E()
	{
		return Physics.bounceThreshold;
	}

	static int _200C_206B_206A_200B_206B_202C_200D_202B_206D_200E_202D_202A_206E_202A_202E_200D_206F_206B_202C_206C_200D_206F_206E_200C_202C_200C_206F_206B_200E_200D_202A_200B_202B_202A_206F_202A_202E_206D_202A_202E()
	{
		return Physics.solverIterationCount;
	}

	static float _206E_206F_202E_206A_202E_200C_206C_202C_200F_202A_206D_206C_206A_206F_200C_206E_206B_202B_206C_206E_206B_206D_206B_200C_206E_200C_206E_200E_202B_206A_206B_202D_202A_202B_206B_200F_202C_202A_202E_200F_202E()
	{
		return Physics.sleepThreshold;
	}

	static bool _206D_200C_202D_206A_202D_202D_206F_200D_200E_200B_206B_202C_200E_206C_206F_202B_200C_200D_200E_206C_202A_200E_206D_200C_202B_200E_206D_200D_200E_200B_200B_200F_206E_202E_200D_200B_200C_200C_200D_206A_202E()
	{
		return Physics.queriesHitTriggers;
	}

	static void _200F_206D_206E_206C_200F_202C_202D_200E_202D_206B_206F_200E_202A_202A_206E_202E_202E_206D_202B_206C_202A_206E_200F_206D_202A_202D_200B_206F_206C_206F_202D_200F_202E_200F_206A_202D_200C_202A_202E_200D_202E(Vector3 P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		Physics.gravity = P_0;
	}

	static void _200B_202D_206F_206E_202C_206F_206E_202C_206A_206D_206E_206F_206D_200E_200F_206A_202D_200B_200B_202D_202C_206A_200F_202B_206D_206F_200E_200B_200B_206F_200D_200C_202B_206B_206F_202D_200C_202D_202E_202E(float P_0)
	{
		Physics.defaultContactOffset = P_0;
	}

	static void _202D_200B_206A_202C_200D_206E_200D_200B_202C_206B_206B_202E_200E_206A_206B_202E_206A_202E_200D_206C_202A_200C_206C_202D_200F_202D_206F_206B_206F_206A_206A_206B_202C_200B_206C_202A_206D_200C_202C_200F_202E(float P_0)
	{
		Physics.bounceThreshold = P_0;
	}

	static void _200D_206D_200E_206F_200F_200D_206B_206D_206A_206C_206B_206E_202E_202D_206F_202C_202C_200E_202A_202B_202A_202A_200F_206E_206B_206C_200C_200F_206B_202E_206C_202B_202E_200E_206C_202A_202C_202E_200F_202A_202E(int P_0)
	{
		Physics.solverIterationCount = P_0;
	}

	static void _200B_202A_202A_200B_202B_206A_202D_200F_200D_200E_206B_200B_202A_200F_206E_200E_202D_202A_200D_202E_206C_206B_202A_200D_200F_200E_200E_206E_202A_206A_200F_202D_200F_202B_200F_200F_206E_206D_200B_206D_202E(float P_0)
	{
		Physics.sleepThreshold = P_0;
	}

	static void _200C_206A_200B_200E_200F_202C_206D_206E_206B_200F_200D_202D_206D_206F_200E_200F_206F_206B_206D_202D_200F_200F_202B_206F_200D_206B_202B_206A_206E_200E_200E_206D_200B_206F_202C_206B_202E_200D_206F_202B_202E(bool P_0)
	{
		Physics.queriesHitTriggers = P_0;
	}

	static bool _202C_200D_200E_206B_206B_200B_202E_202D_200F_200C_200B_202C_200C_200E_202B_200E_206D_202A_206F_206D_202E_206D_200D_206C_200E_200F_202D_200F_202C_202E_202D_200D_202B_206A_200D_206C_206B_202B_202B_200F_202E(Ray P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Physics.Raycast(P_0);
	}

	static bool _202B_206E_206D_202C_200C_202B_200F_206F_206F_206C_200B_202C_206F_206F_202E_200E_200C_202A_200C_200B_202A_202D_200E_200E_206C_200B_200E_206F_200D_200F_200C_202C_200E_202E_200B_200E_202C_202E_202C_206D_202E(Ray P_0, ref RaycastHit P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Physics.Raycast(P_0, ref P_1);
	}

	static bool _200E_206B_202D_202C_200D_200C_202D_200E_202D_202E_200D_206C_202C_202B_206B_200E_202D_206C_200F_206E_200E_202B_202C_202D_200D_200D_206C_200F_200C_206F_200D_206A_206E_202C_206E_206E_202C_200F_206C_200D_202E(Vector3 P_0, Vector3 P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return Physics.Raycast(P_0, P_1);
	}

	static bool _206B_200F_206B_206F_200C_202E_206C_200B_206A_200B_202D_206A_206C_200D_202D_206A_200E_206C_206A_202C_206C_200D_200E_206B_200C_202D_202A_206F_206F_202D_202E_206A_206B_206D_206C_200B_202B_202E_200D_200C_202E(Ray P_0, float P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Physics.Raycast(P_0, P_1);
	}

	static bool _200E_206F_200B_206D_200B_200B_202B_206A_206C_206D_202A_202E_202C_206A_202D_206A_200B_202C_206D_200C_200C_200C_200F_206D_206D_202B_200D_202D_206B_200B_202D_200F_200F_202A_200E_200D_206F_200F_202C_200C_202E(Ray P_0, float P_1, int P_2)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Physics.Raycast(P_0, P_1, P_2);
	}

	static bool _200B_206B_200F_200D_202C_200B_206B_200B_200D_202E_202C_202E_202E_206F_206B_206A_200D_206A_200E_206A_202D_202E_202E_200C_206F_206B_202A_202D_202C_206F_206F_206E_206B_200D_206C_206B_200F_202D_206D_206F_202E(Vector3 P_0, Vector3 P_1, ref RaycastHit P_2)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return Physics.Raycast(P_0, P_1, ref P_2);
	}

	static bool _206B_202A_206C_202C_202C_202A_206F_206A_202B_206A_202D_202A_206D_200B_206F_202B_200E_200B_202C_206D_200E_206C_202C_200C_200C_206F_200C_202E_202D_200F_206D_202B_206D_200E_200C_200B_206C_200F_202D_206A_202E(Vector3 P_0, Vector3 P_1, float P_2)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return Physics.Raycast(P_0, P_1, P_2);
	}

	static bool _206A_202D_202A_202A_202D_202E_202A_202D_206E_206F_200F_206C_200E_202E_206D_206D_200E_206B_206C_200C_206E_202E_202D_200E_202C_202D_200E_200B_206F_206F_206E_200B_206C_202D_202A_206D_206E_200D_206F_200D_202E(Ray P_0, ref RaycastHit P_1, float P_2)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Physics.Raycast(P_0, ref P_1, P_2);
	}

	static bool _202E_202C_202E_200F_206C_202A_206A_206C_202C_206B_206B_206B_202E_206E_200C_206A_202C_206A_202C_206C_200B_202C_202C_206C_202D_202B_202D_202B_206C_202A_200F_202E_206E_202A_202A_206C_206D_202C_200B_202D_202E(Ray P_0, float P_1, int P_2, QueryTriggerInteraction P_3)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return Physics.Raycast(P_0, P_1, P_2, P_3);
	}

	static bool _206B_202D_200E_206C_200C_206E_206B_200D_200E_200B_206F_202C_202C_200E_202C_202A_202A_200E_202E_202D_206D_206D_200E_206C_206B_202C_200B_200B_206E_202E_202B_200E_206C_206E_200C_200F_200D_200D_206B_206F_202E(Vector3 P_0, Vector3 P_1, float P_2, int P_3)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return Physics.Raycast(P_0, P_1, P_2, P_3);
	}

	static bool _202D_200D_202C_200F_200D_206D_202D_202C_206B_202A_206C_202C_206E_206A_202B_206C_200F_206E_206A_206F_202E_202B_200E_206B_200F_206D_206E_202D_206B_202E_206D_202E_202B_202B_202E_206F_200D_200B_206D_206B_202E(Vector3 P_0, Vector3 P_1, ref RaycastHit P_2, float P_3)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return Physics.Raycast(P_0, P_1, ref P_2, P_3);
	}

	static bool _200E_206E_206D_200D_200B_200B_206D_200D_200B_200D_206E_206B_206B_202E_200D_200D_200B_206D_206B_202B_200F_202D_206F_202C_200B_202A_202D_202D_200D_202C_202C_206E_200F_202D_206F_202D_206A_206C_200B_206A_202E(Ray P_0, ref RaycastHit P_1, float P_2, int P_3)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Physics.Raycast(P_0, ref P_1, P_2, P_3);
	}

	static bool _202B_200D_206A_202E_202C_200F_202D_202E_206C_202D_202E_206E_200F_200E_202B_200E_206A_200F_206B_200C_200B_206D_202C_200F_202A_206D_206C_200E_202E_202A_200E_206A_206A_202E_200B_206B_206C_202D_206E_200C_202E(Vector3 P_0, Vector3 P_1, float P_2, int P_3, QueryTriggerInteraction P_4)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return Physics.Raycast(P_0, P_1, P_2, P_3, P_4);
	}

	static bool _206D_202C_202A_202E_200F_206F_200E_200D_200C_206F_200F_202B_202C_200E_200E_206C_202C_200D_200F_202A_206B_202C_202C_206F_200D_202E_202C_202C_200E_202D_200F_206B_202E_200B_206A_202C_202E_206B_202E_206F_202E(Vector3 P_0, Vector3 P_1, ref RaycastHit P_2, float P_3, int P_4)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return Physics.Raycast(P_0, P_1, ref P_2, P_3, P_4);
	}

	static bool _202A_206C_200B_206A_206E_200E_206E_202E_206D_202A_206F_206F_200E_206E_202E_206D_200E_206D_202C_206A_206D_206F_206D_206A_202C_200F_202E_206E_206F_206F_200E_202E_200C_202E_202A_202C_206A_200F_200E_206E_202E(Ray P_0, ref RaycastHit P_1, float P_2, int P_3, QueryTriggerInteraction P_4)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return Physics.Raycast(P_0, ref P_1, P_2, P_3, P_4);
	}

	static bool _200F_206E_202A_206F_202E_200D_206A_206E_202C_202A_200C_200E_202C_206C_206B_206D_206C_206F_200B_206D_200E_206C_200B_202D_200C_206A_206E_200D_206C_200F_206B_200E_200F_200C_206B_206B_206E_200F_202B_206E_202E(Vector3 P_0, Vector3 P_1, ref RaycastHit P_2, float P_3, int P_4, QueryTriggerInteraction P_5)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return Physics.Raycast(P_0, P_1, ref P_2, P_3, P_4, P_5);
	}

	static RaycastHit[] _202B_202A_202E_200C_202E_202C_206F_202A_202B_200D_202B_200C_202A_202B_200C_200C_202D_200B_200F_202B_206B_202E_202D_206D_202A_202D_200F_200C_202D_200F_200F_206B_206A_202E_206F_206E_202B_206A_202E_206F_202E(Ray P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Physics.RaycastAll(P_0);
	}

	static RaycastHit[] _202D_206F_202C_202E_202E_200F_200C_200F_206B_200C_200C_206E_202D_206E_206A_202B_202C_200E_200F_200F_206B_202D_202E_206F_206F_200E_206D_200B_200F_202A_202A_202D_206C_200E_200B_200E_206C_206B_206A_206A_202E(Vector3 P_0, Vector3 P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return Physics.RaycastAll(P_0, P_1);
	}

	static RaycastHit[] _202B_200F_206A_202A_202A_206E_200E_202B_200F_206D_200C_200F_206E_200B_206A_200F_202D_206B_200E_202E_206E_200F_202D_202A_202A_206F_200E_202D_200B_206E_206E_202C_200F_206C_202D_200B_202A_202B_206F_202E_202E(Ray P_0, float P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Physics.RaycastAll(P_0, P_1);
	}

	static RaycastHit[] _206B_206C_200C_200B_200E_206C_206D_202D_200C_206F_202E_206C_200E_200B_202B_202C_206E_200F_202A_200F_200E_202D_206B_206A_206D_202C_200C_200C_206A_200C_202B_202A_206F_202C_200B_202B_206E_200E_202E_200C_202E(Vector3 P_0, Vector3 P_1, float P_2)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return Physics.RaycastAll(P_0, P_1, P_2);
	}

	static RaycastHit[] _206B_206A_200E_206D_200E_200F_202E_206A_206F_200D_206B_206C_206C_206A_206B_206F_206D_206B_200B_200F_200F_200D_200D_202D_202A_202B_206D_202E_206D_200F_206E_202A_206D_206B_200B_202C_200B_202C_206F_202E(Ray P_0, float P_1, int P_2)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Physics.RaycastAll(P_0, P_1, P_2);
	}

	static RaycastHit[] _200E_206D_202C_202A_200E_206E_200E_206B_206D_206A_200B_206C_206E_206D_202B_200E_202C_200D_200C_202B_202D_200E_206B_200B_202B_206E_200E_206A_200C_202C_206A_202B_200D_200D_206B_200E_206C_200D_202B_206C_202E(Vector3 P_0, Vector3 P_1, float P_2, int P_3)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return Physics.RaycastAll(P_0, P_1, P_2, P_3);
	}

	static RaycastHit[] _206A_206A_206F_202D_200B_200D_202A_202C_206F_206A_202D_206D_202D_202A_206E_200B_200E_202D_202B_200E_206F_206E_200B_200F_206C_202C_206F_206D_200F_202B_202A_206B_202A_202A_206E_202E_200D_200E_206A_202E_202E(Ray P_0, float P_1, int P_2, QueryTriggerInteraction P_3)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return Physics.RaycastAll(P_0, P_1, P_2, P_3);
	}

	static RaycastHit[] _200C_202B_200D_200C_206B_206B_202A_202D_202A_206F_202B_206C_202D_206D_206B_206B_206D_202B_206E_200C_206F_200F_202D_202E_206A_200E_206E_200F_200E_206A_200B_200E_200E_206D_202B_200C_202D_206F_206E_202E(Vector3 P_0, Vector3 P_1, float P_2, int P_3, QueryTriggerInteraction P_4)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return Physics.RaycastAll(P_0, P_1, P_2, P_3, P_4);
	}

	static bool _200F_206C_206A_202B_202E_200C_202B_206E_202E_202B_206F_206C_206F_202B_202E_200E_200D_200C_206B_202B_206F_206F_206F_200E_202C_200E_202D_206D_200D_200F_202D_202D_200E_206E_206C_206E_206B_202B_200C_200C_202E(Vector3 P_0, Vector3 P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return Physics.Linecast(P_0, P_1);
	}

	static bool _202C_202C_200E_202E_202D_202E_206E_202A_206D_202C_202C_202C_202E_202C_206F_202D_206E_206E_206A_206D_206C_202B_206E_206E_202E_206A_202D_202E_206B_206B_200F_202E_202A_202E_206C_206C_206D_200D_206D_202A_202E(Vector3 P_0, Vector3 P_1, ref RaycastHit P_2)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return Physics.Linecast(P_0, P_1, ref P_2);
	}

	static bool _200E_206A_206E_206A_206C_202D_202C_206D_200D_206C_200B_206C_200C_206A_206A_202C_200B_200D_200F_206A_200D_206D_206E_206D_206F_200F_206F_200F_206B_202B_206D_202C_206E_200F_200E_202C_200C_206A_202A_202C_202E(Vector3 P_0, Vector3 P_1, int P_2)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return Physics.Linecast(P_0, P_1, P_2);
	}

	static bool _200C_200F_200F_202E_206E_206B_202C_206C_202A_202E_206A_202B_200D_202C_202B_200D_202C_200D_206C_206B_202A_200D_206C_202B_206A_206A_200B_200E_202D_206A_200E_202E_202C_202E_202B_200E_200D_206F_206D_206A_202E(Vector3 P_0, Vector3 P_1, ref RaycastHit P_2, int P_3)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return Physics.Linecast(P_0, P_1, ref P_2, P_3);
	}

	static bool _206E_206E_202A_202B_200C_206B_206C_200E_202B_202D_202B_200E_206B_200F_206C_200E_200E_202B_200F_206F_200B_206B_206D_202A_206C_202A_202E_206C_206B_200D_202C_200D_206E_200D_200B_206A_200F_200F_200B_206E_202E(Vector3 P_0, Vector3 P_1, int P_2, QueryTriggerInteraction P_3)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return Physics.Linecast(P_0, P_1, P_2, P_3);
	}

	static bool _202E_200E_202B_200E_206A_200F_200C_206A_202B_202A_206A_202E_206D_200C_206A_206F_200B_202E_206A_200D_206D_206F_200D_206B_206B_202D_202B_202C_202E_206E_200D_202B_200D_200D_202E_206A_206F_200E_206D_206F_202E(Vector3 P_0, Vector3 P_1, ref RaycastHit P_2, int P_3, QueryTriggerInteraction P_4)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return Physics.Linecast(P_0, P_1, ref P_2, P_3, P_4);
	}

	static Collider[] _200B_200F_202C_200F_206A_206D_200B_202D_200F_200B_202A_200B_200F_206B_200B_202A_206B_202D_200D_200B_202A_200D_202E_202E_200B_202A_202C_206D_202D_202A_200E_202C_200E_200C_206C_200E_200B_206E_202E_206F_202E(Vector3 P_0, float P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Physics.OverlapSphere(P_0, P_1);
	}

	static Collider[] _206E_202B_206B_200B_206D_206C_200B_202B_202D_202D_202D_202C_206A_202B_202E_206C_202E_206B_206B_206A_200C_200B_206A_200D_206C_200C_206F_206C_206E_206F_200E_206E_200B_206A_206B_200F_202D_206A_200D_202E(Vector3 P_0, float P_1, int P_2)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Physics.OverlapSphere(P_0, P_1, P_2);
	}

	static Collider[] _200C_206C_202B_202D_206F_206E_200B_206A_200C_206B_200C_202E_202D_206A_200E_206A_200B_200E_206D_206F_200F_202D_202A_200B_200B_202A_206B_206F_200F_200D_200F_206F_206F_202C_206F_202A_200F_206C_200C_202E(Vector3 P_0, float P_1, int P_2, QueryTriggerInteraction P_3)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return Physics.OverlapSphere(P_0, P_1, P_2, P_3);
	}

	static bool _200D_202C_202B_202E_206F_200D_206D_200E_202C_202D_206F_202E_206E_200D_202D_200D_200B_206F_206E_202C_206F_200D_202D_202A_206B_206C_202C_206F_206E_202D_200E_200F_202D_206E_202E_202B_202D_202A_202D_206E_202E(Vector3 P_0, Vector3 P_1, float P_2, Vector3 P_3)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return Physics.CapsuleCast(P_0, P_1, P_2, P_3);
	}

	static bool _200F_202D_206C_206C_202A_200E_202B_200F_206F_202E_202A_202A_206E_206E_206B_202D_200F_206A_200E_206E_206A_206E_206B_202B_202E_200D_202D_206E_206E_200E_200B_206B_202E_206A_202D_202E_202D_202A_206B_202A_202E(Vector3 P_0, Vector3 P_1, float P_2, Vector3 P_3, ref RaycastHit P_4)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return Physics.CapsuleCast(P_0, P_1, P_2, P_3, ref P_4);
	}

	static bool _202A_202A_200D_206A_200F_206B_200F_206A_200E_200B_200F_202A_206A_206A_200C_200B_206A_202C_206C_202E_206A_200E_202D_202A_202C_202A_206A_202C_200F_202B_200D_206A_200B_206A_200E_200D_200F_202E_202E_206C_202E(Vector3 P_0, Vector3 P_1, float P_2, Vector3 P_3, float P_4)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return Physics.CapsuleCast(P_0, P_1, P_2, P_3, P_4);
	}

	static bool _200C_206E_200F_202C_202B_200B_202A_202B_200F_206A_206A_200F_200F_200B_200B_200F_206F_200D_202B_200C_202D_200D_200F_206F_206E_206A_202E_200C_200D_206C_200C_206B_202A_200F_202D_206B_202C_202D_202B_206D_202E(Vector3 P_0, Vector3 P_1, float P_2, Vector3 P_3, ref RaycastHit P_4, float P_5)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return Physics.CapsuleCast(P_0, P_1, P_2, P_3, ref P_4, P_5);
	}

	static bool _202A_206A_206D_206C_200D_202A_202A_206E_206B_202E_202E_200D_206F_200C_206D_206C_200D_202A_200B_202E_200B_202E_202E_200D_200F_200F_206B_206D_200F_206F_200B_200C_200F_206A_202A_200E_202B_206C_206F_202D_202E(Vector3 P_0, Vector3 P_1, float P_2, Vector3 P_3, float P_4, int P_5)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return Physics.CapsuleCast(P_0, P_1, P_2, P_3, P_4, P_5);
	}

	static bool _202D_202D_202B_206F_206E_200F_206A_200E_206E_202C_200F_200F_202A_206D_206B_202C_202C_206D_206E_202B_206C_200F_202B_200F_202B_202B_202D_206B_206D_200F_200E_202D_206D_200D_206D_202C_200C_202E_206A_206C_202E(Vector3 P_0, Vector3 P_1, float P_2, Vector3 P_3, float P_4, int P_5, QueryTriggerInteraction P_6)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return Physics.CapsuleCast(P_0, P_1, P_2, P_3, P_4, P_5, P_6);
	}

	static bool _206E_202C_202D_202C_202E_202E_202C_202D_200C_200B_202E_206C_206F_200C_200E_202B_206E_202C_206E_202C_206D_200B_206D_206A_202D_206D_206D_202E_202C_202B_206F_202E_206E_200B_206C_200D_200B_200C_200C_202D_202E(Vector3 P_0, Vector3 P_1, float P_2, Vector3 P_3, ref RaycastHit P_4, float P_5, int P_6)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return Physics.CapsuleCast(P_0, P_1, P_2, P_3, ref P_4, P_5, P_6);
	}

	static bool _206E_202D_206C_206A_200F_206C_200C_206D_200B_202D_206A_200F_206E_202B_202E_200D_206E_202E_206B_202A_202D_200C_202A_200D_200B_200C_202B_200E_200C_202B_206E_202D_200E_200C_206F_206E_206D_206F_206F_202E(Vector3 P_0, Vector3 P_1, float P_2, Vector3 P_3, ref RaycastHit P_4, float P_5, int P_6, QueryTriggerInteraction P_7)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return Physics.CapsuleCast(P_0, P_1, P_2, P_3, ref P_4, P_5, P_6, P_7);
	}

	static bool _202C_202A_206E_206D_200F_202A_200E_202A_202D_200B_202D_206C_202E_206D_206E_206D_202E_200C_200D_200D_200C_202B_200E_200E_206A_202D_202A_206E_202E_206F_202B_206F_206E_200F_206C_202D_202A_206A_206B_202D_202E(Ray P_0, float P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Physics.SphereCast(P_0, P_1);
	}

	static bool _202B_202C_206F_206E_206A_206A_206F_200E_206B_200B_202D_202C_206A_202E_206B_206B_200B_200D_200E_206C_202B_200D_202C_200B_200E_206F_206A_206D_206B_206A_206C_202A_202A_206B_202D_200D_200C_206B_206C_200E_202E(Ray P_0, float P_1, float P_2)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Physics.SphereCast(P_0, P_1, P_2);
	}

	static bool _206D_200F_202B_200B_202B_202C_206F_202B_200C_200F_202B_206C_200F_206F_202B_200E_206D_200D_202C_206F_200F_200E_202A_206E_200E_202A_202C_202A_202E_206B_202E_202C_200D_200E_200C_206A_206D_206A_206F_206F_202E(Ray P_0, float P_1, ref RaycastHit P_2)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Physics.SphereCast(P_0, P_1, ref P_2);
	}

	static bool _202B_202C_202D_202A_206E_200F_202E_206F_206A_206F_206D_206F_202B_200C_200C_202C_206E_202A_206B_202D_206F_200E_206D_200E_202B_200E_206D_206B_202B_200B_200B_206C_202D_206E_202D_206C_202D_202E_206A_202B_202E(Vector3 P_0, float P_1, Vector3 P_2, ref RaycastHit P_3)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return Physics.SphereCast(P_0, P_1, P_2, ref P_3);
	}

	static bool _200E_202C_200B_202A_206B_206E_200E_200B_206A_202B_206A_200C_206E_200C_206C_200B_202B_202A_202E_206B_202D_206E_206F_202B_206D_202D_200C_206D_206B_200D_200F_202B_202E_206B_206A_200F_206D_202A_206B_206F_202E(Ray P_0, float P_1, float P_2, int P_3)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Physics.SphereCast(P_0, P_1, P_2, P_3);
	}

	static bool _202D_206D_206F_200F_206F_206D_200D_206D_206F_200B_206F_206E_202E_206D_206E_206E_206A_200E_202A_202B_206E_200D_206D_200E_206A_206A_206E_200C_200D_206E_206B_200D_200F_200B_202E_206D_200D_202E_200E_200D_202E(Ray P_0, float P_1, ref RaycastHit P_2, float P_3)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Physics.SphereCast(P_0, P_1, ref P_2, P_3);
	}

	static bool _200B_206E_206D_200E_200D_200C_202D_200B_206C_206F_206D_202A_200E_206C_202E_200B_206C_202D_202E_206D_206A_206E_200D_206E_206E_200F_206D_206D_206C_206F_206D_202D_206A_200F_206B_202B_202A_200B_202E_200E_202E(Ray P_0, float P_1, ref RaycastHit P_2, float P_3, int P_4)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Physics.SphereCast(P_0, P_1, ref P_2, P_3, P_4);
	}

	static bool _200C_206C_202C_206C_200F_206C_200F_202E_206E_200F_206D_206F_206C_200B_206C_202B_200F_206F_200E_206E_206C_202A_200D_200D_206F_202E_202E_206A_202B_206B_202A_202B_206B_202E_206E_206E_202E_202D_202A_202A_202E(Ray P_0, float P_1, float P_2, int P_3, QueryTriggerInteraction P_4)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return Physics.SphereCast(P_0, P_1, P_2, P_3, P_4);
	}

	static bool _202A_200F_206F_202C_206D_202C_206D_200D_202B_202A_200C_206B_200F_202D_200F_202A_206D_200B_206A_206C_206E_200B_206E_200D_202D_206E_200B_200C_200C_200E_206D_206C_200B_202D_206E_206C_206F_206B_206A_206F_202E(Vector3 P_0, float P_1, Vector3 P_2, ref RaycastHit P_3, float P_4)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return Physics.SphereCast(P_0, P_1, P_2, ref P_3, P_4);
	}

	static bool _200E_206B_206F_206C_202D_202A_202A_206B_206F_200E_200D_202A_200E_206A_200E_202D_200E_200C_202E_202D_206B_202B_206E_206B_200E_202D_206C_202B_202A_202B_202E_206A_200C_202D_206C_206D_200F_200E_200F_202E_202E(Vector3 P_0, float P_1, Vector3 P_2, ref RaycastHit P_3, float P_4, int P_5)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return Physics.SphereCast(P_0, P_1, P_2, ref P_3, P_4, P_5);
	}

	static bool _206A_202E_206F_206A_200C_202B_206E_200B_202E_202A_200E_206A_200B_206F_202C_206D_202B_202C_202A_206F_202D_202D_202C_200B_202D_202C_200B_202D_200E_200B_202C_200E_206E_200D_202B_206E_206E_202A_200D_206D_202E(Ray P_0, float P_1, ref RaycastHit P_2, float P_3, int P_4, QueryTriggerInteraction P_5)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return Physics.SphereCast(P_0, P_1, ref P_2, P_3, P_4, P_5);
	}

	static bool _200D_202A_206A_202C_206E_200B_202C_200C_200C_200C_202E_206C_206F_202C_206B_202D_202D_200C_206B_206E_200E_202C_200D_200E_206F_202B_202B_200E_206E_200B_202C_202C_200B_200F_200D_206F_202D_206D_206C_200C_202E(Vector3 P_0, float P_1, Vector3 P_2, ref RaycastHit P_3, float P_4, int P_5, QueryTriggerInteraction P_6)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return Physics.SphereCast(P_0, P_1, P_2, ref P_3, P_4, P_5, P_6);
	}

	static RaycastHit[] _200B_202D_200F_200E_202E_202A_202B_200E_202E_206C_200C_206B_200F_200D_200C_206D_202E_206C_202B_206B_206D_206F_202A_202E_202A_200D_206E_202A_206D_206D_206D_206F_206B_200E_202B_202C_206A_202C_206F_200C_202E(Vector3 P_0, Vector3 P_1, float P_2, Vector3 P_3)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return Physics.CapsuleCastAll(P_0, P_1, P_2, P_3);
	}

	static RaycastHit[] _200C_202A_202E_206C_200E_200F_206B_206C_200F_202E_200D_200D_206B_206D_202E_202E_206A_206F_202D_200D_202B_200B_200C_206C_202A_202C_206F_206E_206C_200C_202A_202B_202D_200F_206F_206B_206B_206B_206D_206D_202E(Vector3 P_0, Vector3 P_1, float P_2, Vector3 P_3, float P_4)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return Physics.CapsuleCastAll(P_0, P_1, P_2, P_3, P_4);
	}

	static RaycastHit[] _202A_202B_200B_206E_202A_206A_206F_200D_206C_200B_202C_202C_200B_206F_202D_202A_200B_206D_202D_202A_202B_200F_206C_200E_202A_202E_200F_206A_202E_200B_202D_206E_202D_206D_206B_206B_200F_200E_202B_200C_202E(Vector3 P_0, Vector3 P_1, float P_2, Vector3 P_3, float P_4, int P_5)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return Physics.CapsuleCastAll(P_0, P_1, P_2, P_3, P_4, P_5);
	}

	static RaycastHit[] _200C_200F_202A_202E_200C_200D_202B_200B_200D_200D_206F_200E_206E_202E_202B_202B_202D_202B_206A_206A_200F_200B_206A_200F_202C_200C_202D_200D_202C_202C_202D_200C_202C_200F_206B_206C_200D_202B_202B_202E(Vector3 P_0, Vector3 P_1, float P_2, Vector3 P_3, float P_4, int P_5, QueryTriggerInteraction P_6)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return Physics.CapsuleCastAll(P_0, P_1, P_2, P_3, P_4, P_5, P_6);
	}

	static RaycastHit[] _202C_202D_200E_200F_202A_206C_200F_206A_200D_200D_206E_206A_202D_202E_202A_202C_206D_206A_202E_206C_206F_206C_206C_202B_206F_200C_206F_202A_206D_206F_206D_206B_206D_206E_200E_200D_200E_206D_202C_206E_202E(Ray P_0, float P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Physics.SphereCastAll(P_0, P_1);
	}

	static RaycastHit[] _202B_202B_200C_202A_200B_202D_202C_202C_206F_206F_206F_200D_202D_200F_206A_206E_202B_202C_206C_200D_206D_206F_200D_206F_202A_206E_200C_200E_206F_200D_200F_200D_202B_206C_206A_206F_202C_200C_200F_202B_202E(Ray P_0, float P_1, float P_2)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Physics.SphereCastAll(P_0, P_1, P_2);
	}

	static RaycastHit[] _202E_202E_206E_200F_202A_206E_202B_202E_206D_206F_202C_202C_206F_200F_206B_202D_206C_206A_200F_202D_202C_202B_200E_202C_200E_202E_206C_200E_202B_202A_202D_200F_202C_200E_200D_206E_200D_206A_200E_206D_202E(Vector3 P_0, float P_1, Vector3 P_2)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return Physics.SphereCastAll(P_0, P_1, P_2);
	}

	static RaycastHit[] _206B_206D_206B_206E_206A_200F_202B_202B_200F_206D_200E_202D_206D_206E_206E_200B_202B_202A_206B_200B_206A_206F_202A_200B_206B_206B_200D_206B_202E_206F_202D_206A_202E_202B_206A_202C_200C_200B_202E_202E(Ray P_0, float P_1, float P_2, int P_3)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Physics.SphereCastAll(P_0, P_1, P_2, P_3);
	}

	static RaycastHit[] _200D_200E_206C_206D_206F_200F_206C_206B_206B_206B_206D_206D_202B_200C_200D_202E_202E_202B_206E_202D_206F_206D_202A_206F_202A_202C_202D_202A_206F_202E_206A_200F_202D_206E_200F_206F_206E_202B_206D_202A_202E(Vector3 P_0, float P_1, Vector3 P_2, float P_3)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return Physics.SphereCastAll(P_0, P_1, P_2, P_3);
	}

	static RaycastHit[] _206D_200E_206A_202B_200C_206C_206F_200D_206B_200D_202E_202B_206E_202A_200F_206F_200D_202D_202D_200C_200C_202A_200D_206E_200D_200E_202D_202B_202B_206B_202D_202D_202B_206E_206C_202B_206B_206C_200D_206E_202E(Vector3 P_0, float P_1, Vector3 P_2, float P_3, int P_4)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return Physics.SphereCastAll(P_0, P_1, P_2, P_3, P_4);
	}

	static RaycastHit[] _200B_206B_200D_202E_206B_200D_200F_200E_202D_200E_200B_200E_200E_202B_200C_206F_206C_206C_200B_200B_202E_200E_206A_200C_200C_202B_202A_206A_206A_202E_206D_200D_206B_200C_206D_200D_206C_206A_206E_202B_202E(Ray P_0, float P_1, float P_2, int P_3, QueryTriggerInteraction P_4)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return Physics.SphereCastAll(P_0, P_1, P_2, P_3, P_4);
	}

	static RaycastHit[] _202B_200F_200E_200C_200B_202A_202A_202E_206A_200C_202B_206A_200B_206F_202B_200D_200C_200C_200E_202B_206A_206D_206E_202E_206B_202B_202A_206F_200E_202A_200D_200E_202C_206F_202C_206F_206F_206D_202D_206E_202E(Vector3 P_0, float P_1, Vector3 P_2, float P_3, int P_4, QueryTriggerInteraction P_5)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return Physics.SphereCastAll(P_0, P_1, P_2, P_3, P_4, P_5);
	}

	static bool _200C_206A_202B_200C_200B_202A_202B_206F_200F_206F_206C_206B_206A_200B_206B_202D_200B_202E_202B_206C_200D_206E_202B_206A_206F_206E_200C_206D_200B_200C_206E_200B_200C_200D_202B_206D_200D_202D_202A_202C_202E(Vector3 P_0, float P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Physics.CheckSphere(P_0, P_1);
	}

	static bool _206A_200B_206C_206D_200C_200C_202E_202C_200C_200C_206B_200E_202D_202B_202C_206C_206F_202A_206A_206D_202B_202A_200C_200E_202A_206A_200C_200C_200D_200C_202C_202D_202C_202A_202A_206E_206A_200D_206C_206C_202E(Vector3 P_0, float P_1, int P_2)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Physics.CheckSphere(P_0, P_1, P_2);
	}

	static bool _202D_200B_206B_202D_202E_200F_206D_202B_206C_200E_200E_202B_200B_202A_206B_202D_200C_206A_200F_206C_202A_200B_206F_206E_202D_206C_206D_206C_206C_202C_206D_200D_206C_202B_200F_200F_206A_202C_206D_202C_202E(Vector3 P_0, float P_1, int P_2, QueryTriggerInteraction P_3)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return Physics.CheckSphere(P_0, P_1, P_2, P_3);
	}

	static bool _206E_202C_206E_206F_206E_202A_206A_200E_206D_202B_200C_200D_206B_202A_202B_206B_206D_200F_202E_200E_206D_206A_200E_202B_206F_202D_206F_206D_200F_206E_202C_206D_202E_206D_200E_206A_202E_200C_206F_206C_202E(Vector3 P_0, Vector3 P_1, float P_2)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return Physics.CheckCapsule(P_0, P_1, P_2);
	}

	static bool _206A_202E_200F_200B_202E_200F_206F_206C_206D_200E_202C_200F_206C_202E_206D_206F_200B_200D_200E_202C_200D_200D_200E_206B_206D_200C_206D_202D_202E_206A_200C_206A_206A_206A_200D_200B_200B_202D_206C_202E(Vector3 P_0, Vector3 P_1, float P_2, int P_3)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return Physics.CheckCapsule(P_0, P_1, P_2, P_3);
	}

	static bool _202C_206F_202C_200E_206F_200C_200B_206C_200B_206D_200C_202C_206B_200B_206C_206A_200E_200B_206A_206D_206E_206E_202B_200B_206E_206E_206F_206B_202C_206B_206D_206F_200D_200E_206D_200F_202B_200B_202B_202E(Vector3 P_0, Vector3 P_1, float P_2, int P_3, QueryTriggerInteraction P_4)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return Physics.CheckCapsule(P_0, P_1, P_2, P_3, P_4);
	}

	static void _206A_206A_200B_200D_202E_206F_202A_200D_202E_202D_206F_200D_200C_206B_200C_202D_200E_200C_202D_206A_202C_206A_206A_200F_206F_202D_200E_206F_206C_200C_206D_200E_206D_202B_206E_202D_206E_200C_206D_202E_202E(Collider P_0, Collider P_1)
	{
		Physics.IgnoreCollision(P_0, P_1);
	}

	static void _200E_206B_202D_206F_202B_206F_202A_206F_200F_200B_200C_206E_202B_200C_200E_206F_206F_202A_206B_200F_200E_206B_200F_200F_206E_202C_206B_202E_206D_200B_202A_200F_206E_206C_200E_202E_202E_206E_202D_206C_202E(Collider P_0, Collider P_1, bool P_2)
	{
		Physics.IgnoreCollision(P_0, P_1, P_2);
	}

	static void _202A_206A_206E_200D_206F_200E_202D_202D_206D_202E_206A_206E_200D_202C_206D_206C_206A_200C_206C_200D_200D_202A_202A_202E_202C_206F_202D_202A_202B_206A_206D_202A_206E_206A_202E_206B_206C_206F_202D_202A_202E(int P_0, int P_1)
	{
		Physics.IgnoreLayerCollision(P_0, P_1);
	}

	static void _206F_206F_206F_200B_206B_206B_200F_200C_200D_200C_202A_202E_206D_202C_202C_206C_202B_202D_202D_202E_200D_202D_202C_206F_206D_202C_206E_206C_202D_206B_200E_202E_206F_206C_202B_206C_206F_202C_206E_206C_202E(int P_0, int P_1, bool P_2)
	{
		Physics.IgnoreLayerCollision(P_0, P_1, P_2);
	}

	static bool _206E_206E_202E_200F_200D_202C_202E_206F_200D_202E_200C_200B_206F_206C_206C_206C_200F_206D_200E_200F_200B_202A_202B_206C_206D_206B_200E_202C_200C_202D_206F_206F_206F_200D_200B_206D_206F_202D_206C_202E_202E(int P_0, int P_1)
	{
		return Physics.GetIgnoreLayerCollision(P_0, P_1);
	}
}
