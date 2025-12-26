using System;
using LuaInterface;

public class DelegateFactoryWrap
{
	private static Type classType = _206C_200F_200F_206C_202C_206D_206E_202E_202E_202A_200E_202E_200D_202E_202B_206F_202A_202B_200D_206A_200B_202E_206C_206A_200B_200E_202B_206D_200C_202C_200D_202A_206F_202A_200E_200E_206D_206F_202B_206F_202E(typeof(DelegateFactory).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[13]
		{
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1799938267u), Action_GameObject),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4111023204u), Action),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(280233018u), UnityEngine_Events_UnityAction),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1907621880u), System_Reflection_MemberFilter),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(800109673u), System_Reflection_TypeFilter),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(147948193u), TestLuaDelegate_VoidDelegate),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3790754009u), Camera_CameraCallback),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(640423513u), AudioClip_PCMReaderCallback),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3067769759u), AudioClip_PCMSetPositionCallback),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3444996583u), Application_LogCallback),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3379889445u), Clear),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2904731379u), _206F_202A_206D_202B_200F_200C_206D_200C_202E_206D_200D_206B_202D_202C_200E_202E_200F_200C_206A_206D_206C_202E_202A_200F_200B_206E_202E_200B_200C_200D_202B_200C_202C_206C_200C_206E_206E_200E_200C_206F_202E),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(10103728u), GetClassType)
		};
		LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(105364710u), regs);
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _206F_202A_206D_202B_200F_200C_206D_200C_202E_206D_200D_206B_202D_202C_200E_202E_200F_200C_206A_206D_206C_202E_202A_200F_200B_206E_202E_200B_200C_200D_202B_200C_202C_206C_200C_206E_206E_200E_200C_206F_202E(IntPtr P_0)
	{
		LuaDLL.luaL_error(P_0, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(953870596u));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Action_GameObject(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		LuaFunction luaFunction = LuaScriptMgr.GetLuaFunction(L, 1);
		Delegate o = default(Delegate);
		while (true)
		{
			int num = -2112713228;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1219993737)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_0031;
				default:
					LuaScriptMgr.Push(L, o);
					return 1;
				}
				break;
				IL_0031:
				o = DelegateFactory.Action_GameObject(luaFunction);
				num = (int)((num2 * 1380044535) ^ 0x5FAF33A3);
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Action(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Delegate o = default(Delegate);
		while (true)
		{
			int num = -1257327430;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -165931599)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0029;
				default:
					LuaScriptMgr.Push(L, o);
					return 1;
				}
				break;
				IL_0029:
				LuaFunction luaFunction = LuaScriptMgr.GetLuaFunction(L, 1);
				o = DelegateFactory.Action(luaFunction);
				num = (int)((num2 * 2001784031) ^ 0x3CFBE4F9);
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int UnityEngine_Events_UnityAction(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		LuaFunction luaFunction = default(LuaFunction);
		Delegate o = default(Delegate);
		while (true)
		{
			int num = 1281638207;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x256B646F)) % 5)
				{
				case 3u:
					break;
				case 1u:
					luaFunction = LuaScriptMgr.GetLuaFunction(L, 1);
					num = ((int)num2 * -540745455) ^ 0x12989042;
					continue;
				case 0u:
					LuaScriptMgr.Push(L, o);
					num = (int)(num2 * 1525730092) ^ -78880276;
					continue;
				case 2u:
					o = DelegateFactory.UnityEngine_Events_UnityAction(luaFunction);
					num = ((int)num2 * -328105149) ^ -1462649051;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int System_Reflection_MemberFilter(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		LuaFunction luaFunction = LuaScriptMgr.GetLuaFunction(L, 1);
		Delegate o = default(Delegate);
		while (true)
		{
			int num = 955872459;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2BD6E68F)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_0031;
				default:
					LuaScriptMgr.Push(L, o);
					return 1;
				}
				break;
				IL_0031:
				o = DelegateFactory.System_Reflection_MemberFilter(luaFunction);
				num = (int)((num2 * 1789007032) ^ 0x62ED3FAB);
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int System_Reflection_TypeFilter(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		LuaFunction luaFunction = default(LuaFunction);
		Delegate o = default(Delegate);
		while (true)
		{
			int num = 1591265686;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3D58739B)) % 5)
				{
				case 4u:
					break;
				case 1u:
					luaFunction = LuaScriptMgr.GetLuaFunction(L, 1);
					num = ((int)num2 * -778469877) ^ 0x1C214638;
					continue;
				case 0u:
					LuaScriptMgr.Push(L, o);
					num = (int)((num2 * 1914145955) ^ 0x48F42660);
					continue;
				case 2u:
					o = DelegateFactory.System_Reflection_TypeFilter(luaFunction);
					num = (int)(num2 * 1552456031) ^ -341278069;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int TestLuaDelegate_VoidDelegate(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		LuaFunction luaFunction = LuaScriptMgr.GetLuaFunction(L, 1);
		while (true)
		{
			int num = -1205545108;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -269889146)) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_0031;
				default:
					return 1;
				}
				break;
				IL_0031:
				Delegate o = DelegateFactory.TestLuaDelegate_VoidDelegate(luaFunction);
				LuaScriptMgr.Push(L, o);
				num = (int)((num2 * 602341803) ^ 0xE555B99);
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Camera_CameraCallback(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		LuaFunction luaFunction = LuaScriptMgr.GetLuaFunction(L, 1);
		Delegate o = default(Delegate);
		while (true)
		{
			int num = -1337130372;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -236779055)) % 4)
				{
				case 2u:
					break;
				case 1u:
					o = DelegateFactory.Camera_CameraCallback(luaFunction);
					num = ((int)num2 * -800874587) ^ -1549098352;
					continue;
				case 0u:
					LuaScriptMgr.Push(L, o);
					num = (int)((num2 * 319296909) ^ 0x2548D07E);
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int AudioClip_PCMReaderCallback(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		LuaFunction luaFunction = LuaScriptMgr.GetLuaFunction(L, 1);
		Delegate o = DelegateFactory.AudioClip_PCMReaderCallback(luaFunction);
		while (true)
		{
			int num = -1043948807;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -346273329)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0038;
				default:
					return 1;
				}
				break;
				IL_0038:
				LuaScriptMgr.Push(L, o);
				num = (int)((num2 * 1665888570) ^ 0x7492BC08);
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int AudioClip_PCMSetPositionCallback(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Delegate o = default(Delegate);
		while (true)
		{
			int num = -861176049;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -565255732)) % 4)
				{
				case 2u:
					break;
				case 3u:
				{
					LuaFunction luaFunction = LuaScriptMgr.GetLuaFunction(L, 1);
					o = DelegateFactory.AudioClip_PCMSetPositionCallback(luaFunction);
					num = (int)((num2 * 1302744199) ^ 0x1B1EC5C5);
					continue;
				}
				case 0u:
					LuaScriptMgr.Push(L, o);
					num = ((int)num2 * -1134453042) ^ 0x1722C811;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Application_LogCallback(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		LuaFunction luaFunction = default(LuaFunction);
		Delegate o = default(Delegate);
		while (true)
		{
			int num = -1277458706;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1898905899)) % 4)
				{
				case 0u:
					break;
				case 3u:
					luaFunction = LuaScriptMgr.GetLuaFunction(L, 1);
					num = ((int)num2 * -435514921) ^ -1940637374;
					continue;
				case 2u:
					o = DelegateFactory.Application_LogCallback(luaFunction);
					num = ((int)num2 * -1923792915) ^ 0x4AD3E3F2;
					continue;
				default:
					LuaScriptMgr.Push(L, o);
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Clear(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		DelegateFactory.Clear();
		return 0;
	}

	static Type _206C_200F_200F_206C_202C_206D_206E_202E_202E_202A_200E_202E_200D_202E_202B_206F_202A_202B_200D_206A_200B_202E_206C_206A_200B_200E_202B_206D_200C_202C_200D_202A_206F_202A_200E_200E_206D_206F_202B_206F_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
