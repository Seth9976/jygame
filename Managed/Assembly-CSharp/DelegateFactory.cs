using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using LuaInterface;
using UnityEngine;
using UnityEngine.Events;

public static class DelegateFactory
{
	private delegate Delegate DelegateValue(LuaFunction func);

	[CompilerGenerated]
	private sealed class _206E_200B_200F_206E_200D_202C_206E_200C_206B_200E_202C_200E_202C_206F_206D_206C_206C_200F_206F_206E_202B_206E_202C_202E_202E_200D_206D_206E_206E_200E_202A_200E_206E_206B_202D_202E_200B_200D_200F_202A_202E
	{
		internal LuaFunction func;

		internal void _206C_200E_202E_206C_202C_206B_202D_202C_200B_200D_200B_206B_200B_200C_202B_202C_200F_202B_206C_206A_200D_202D_202A_200B_202E_200E_206E_206E_206E_206B_206A_200D_200D_206E_200C_202E_200C_206E_200F_206B_202E(GameObject P_0)
		{
			int oldTop = func.BeginPCall();
			while (true)
			{
				int num = 988529499;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x169CC775)) % 5)
					{
					case 0u:
						break;
					default:
						return;
					case 1u:
						func.EndPCall(oldTop);
						num = (int)(num2 * 725542370) ^ -1107702422;
						continue;
					case 4u:
						func.PCall(oldTop, 1);
						num = ((int)num2 * -28224323) ^ -1455633247;
						continue;
					case 3u:
					{
						IntPtr luaState = func.GetLuaState();
						LuaScriptMgr.Push(luaState, (Object)(object)P_0);
						num = ((int)num2 * -1947216449) ^ 0x6460EA4;
						continue;
					}
					case 2u:
						return;
					}
					break;
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class _202A_202C_206A_206B_202E_200F_202B_202A_206C_202E_206C_200C_200E_200B_206F_202D_206D_206E_200C_206A_202D_206A_200C_202B_206D_206D_202D_206E_200B_200F_200F_206A_206D_200C_206C_206C_200E_206D_206A_202B_202E
	{
		internal LuaFunction func;

		internal void _202D_202B_202E_200D_206E_206C_206D_206D_206B_206C_202A_202E_202C_202D_200B_200B_200E_200F_200B_200B_206B_202D_206D_206F_206B_206B_206B_206C_200E_200C_202D_206E_206A_206B_200C_206B_206A_202B_200F_200F_202E()
		{
			func.Call();
		}
	}

	[CompilerGenerated]
	private sealed class _200F_202E_202B_200B_202E_202A_202C_200D_202C_200D_202B_200E_200C_206E_202A_206F_202D_206C_200B_200E_200F_202A_202A_202E_206F_202D_206E_206E_200F_200E_202E_202E_200B_200B_202B_206D_200D_202D_206D_202D_202E
	{
		internal LuaFunction func;

		internal void _202D_202E_202B_200D_202D_200D_206F_206A_202A_202C_206D_202D_206A_200D_206E_206C_206F_200C_200F_202A_202B_206B_206A_206E_202E_206B_200F_202C_200B_200B_202E_206A_202B_202E_206B_202C_206F_206F_200D_206C_202E()
		{
			func.Call();
		}
	}

	[CompilerGenerated]
	private sealed class _200B_200B_202D_202C_200D_202C_202E_200F_200F_200F_200B_200D_206A_202D_206D_202B_202D_200B_200E_202C_206A_200D_206C_200E_206D_200E_202C_206D_206F_202D_202B_202C_206E_202B_200D_202D_202B_206F_202C_206B_202E
	{
		internal LuaFunction func;

		internal bool _206C_206E_200C_200C_206A_202C_206A_200D_206D_206B_206B_202A_206E_202D_202A_206F_206A_200E_202D_200B_200D_206D_200D_206D_202B_202B_202B_200E_202C_202C_200C_202C_206C_202A_202C_206A_206C_200B_206C_200D_202E(MemberInfo P_0, object P_1)
		{
			int oldTop = func.BeginPCall();
			IntPtr luaState = func.GetLuaState();
			object[] array = default(object[]);
			while (true)
			{
				int num = 795750324;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x78016710)) % 7)
					{
					case 2u:
						break;
					case 6u:
						array = func.PopValues(oldTop);
						num = (int)(num2 * 361515732) ^ -309417603;
						continue;
					case 1u:
						func.EndPCall(oldTop);
						num = ((int)num2 * -2050600725) ^ 0x3F97FE4D;
						continue;
					case 5u:
						LuaScriptMgr.PushObject(luaState, P_0);
						num = ((int)num2 * -1372953480) ^ -1660226082;
						continue;
					case 4u:
						func.PCall(oldTop, 2);
						num = ((int)num2 * -932488953) ^ -388662379;
						continue;
					case 3u:
						LuaScriptMgr.PushVarObject(luaState, P_1);
						num = (int)((num2 * 1703253306) ^ 0x427023D0);
						continue;
					default:
						return (bool)array[0];
					}
					break;
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class _202D_200D_202B_206B_200F_200F_202D_206D_200D_206F_202C_206E_202D_200C_200E_200D_202A_200C_200C_206B_200D_202E_206B_206C_206F_206F_206D_202B_202A_202D_202E_206D_202D_200C_200B_200E_200F_206D_206B_200D_202E
	{
		internal LuaFunction func;

		internal bool _200D_202E_202A_206C_202E_206E_200F_206A_206B_202E_206C_202B_206D_202E_202E_200D_200B_200B_200C_206A_200E_202D_202C_206D_200E_200D_202D_206F_206B_206B_206A_200F_200B_200D_206C_200E_202E_206E_202C_200D_202E(Type P_0, object P_1)
		{
			int oldTop = func.BeginPCall();
			IntPtr luaState = default(IntPtr);
			object[] array = default(object[]);
			while (true)
			{
				int num = 2080732385;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x677399BE)) % 6)
					{
					case 4u:
						break;
					case 3u:
						luaState = func.GetLuaState();
						LuaScriptMgr.Push(luaState, P_0);
						num = ((int)num2 * -1623765929) ^ -432680480;
						continue;
					case 5u:
						LuaScriptMgr.PushVarObject(luaState, P_1);
						num = ((int)num2 * -389179698) ^ -387332716;
						continue;
					case 0u:
						array = func.PopValues(oldTop);
						func.EndPCall(oldTop);
						num = (int)((num2 * 528944346) ^ 0x2DCDE90F);
						continue;
					case 2u:
						func.PCall(oldTop, 2);
						num = (int)(num2 * 1718746241) ^ -568473370;
						continue;
					default:
						return (bool)array[0];
					}
					break;
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class _206F_206A_202E_202B_206C_202D_206E_202D_206F_200D_202C_202D_200F_200F_206C_206B_206F_206E_202B_206F_202B_200B_202D_200C_202A_202B_202E_206B_206E_206E_206E_202B_200B_206F_202E_206E_202E_206B_206D_202B_202E
	{
		internal LuaFunction func;

		internal void _202E_200C_206E_202C_200D_202C_200C_206F_200D_200B_202A_206A_200F_202A_202C_200F_202E_206F_206C_206B_202C_206E_202A_202D_200C_206F_202D_206C_206F_206A_200B_206C_200E_200B_200C_206C_200C_206C_202B_200C_202E(GameObject P_0)
		{
			int oldTop = func.BeginPCall();
			IntPtr luaState = func.GetLuaState();
			while (true)
			{
				int num = 1314113040;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x76A6EC5)) % 5)
					{
					case 2u:
						break;
					default:
						return;
					case 0u:
						func.EndPCall(oldTop);
						num = (int)(num2 * 2043899685) ^ -180637351;
						continue;
					case 3u:
						func.PCall(oldTop, 1);
						num = (int)((num2 * 1870990754) ^ 0x2767CC5);
						continue;
					case 1u:
						LuaScriptMgr.Push(luaState, (Object)(object)P_0);
						num = ((int)num2 * -516911706) ^ 0x68F4D523;
						continue;
					case 4u:
						return;
					}
					break;
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class _200E_200E_206E_202E_202C_200E_200B_200F_206B_202E_200C_206D_200D_202E_206C_200E_206C_202C_200E_202E_200B_206F_206B_200E_206A_200E_200B_206B_200E_206A_202A_206E_206B_202B_202B_206E_202A_206D_206C_206A_202E
	{
		internal LuaFunction func;

		internal void _202E_202B_202A_206A_200D_206D_202C_206D_200B_202C_202E_200D_202B_206A_202A_206F_206E_202E_200E_206D_202A_202E_200E_202C_206B_206A_202D_202B_202A_200C_202C_206B_202C_206B_200C_202D_200F_202E_206E_202E_202E(Camera P_0)
		{
			int oldTop = func.BeginPCall();
			while (true)
			{
				int num = -170671225;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1960963571)) % 5)
					{
					case 0u:
						break;
					default:
						return;
					case 3u:
					{
						IntPtr luaState = func.GetLuaState();
						LuaScriptMgr.Push(luaState, (Object)(object)P_0);
						num = (int)(num2 * 1788780669) ^ -1302596986;
						continue;
					}
					case 2u:
						func.EndPCall(oldTop);
						num = (int)(num2 * 2132567835) ^ -1353486268;
						continue;
					case 4u:
						func.PCall(oldTop, 1);
						num = (int)((num2 * 226091355) ^ 0x65101A5D);
						continue;
					case 1u:
						return;
					}
					break;
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class _202A_200C_202A_206C_206F_202D_200F_202E_202E_202E_206C_206F_206A_200F_200D_206C_206D_200F_206A_202A_206F_206A_206F_200C_206F_206A_206E_202D_202E_200F_206D_206F_200D_202B_202D_200D_202C_202C_200E_206C_202E
	{
		internal LuaFunction func;

		internal void _206B_206F_200F_206C_202C_202B_206A_202A_206B_202B_200E_206B_202E_206C_202A_206B_206E_206F_202D_202D_206C_200C_202C_202C_200C_202E_206E_200F_200C_200E_200C_206A_206C_200E_202A_206C_202B_202D_202C_206A_202E(float[] P_0)
		{
			int oldTop = func.BeginPCall();
			while (true)
			{
				int num = 77572154;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x64E2AACB)) % 3)
					{
					case 0u:
						break;
					case 2u:
						goto IL_002e;
					default:
						func.PCall(oldTop, 1);
						func.EndPCall(oldTop);
						return;
					}
					break;
					IL_002e:
					IntPtr luaState = func.GetLuaState();
					LuaScriptMgr.PushArray(luaState, P_0);
					num = (int)((num2 * 935429608) ^ 0x46413090);
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class _202E_200D_202A_200B_202E_206F_202B_200E_200F_202D_200B_206C_206D_202D_206A_200B_206C_200E_200F_202B_206D_206F_202B_206A_206E_206A_200D_206C_206B_202A_200E_202B_200D_200E_202A_200D_200E_200C_206E_206F_202E
	{
		internal LuaFunction func;

		internal void _206B_202B_200E_202B_200D_200E_202E_206A_200F_206D_206E_200F_200D_202A_202D_200E_202C_202B_206A_202B_200C_202D_206F_200D_200B_202C_200F_206C_202C_206A_206A_206C_200B_206C_206D_200C_206E_200E_206F_206E_202E(int P_0)
		{
			int oldTop = func.BeginPCall();
			IntPtr luaState = func.GetLuaState();
			LuaScriptMgr.Push(luaState, P_0);
			func.PCall(oldTop, 1);
			func.EndPCall(oldTop);
		}
	}

	[CompilerGenerated]
	private sealed class _200F_202E_202A_200B_200B_206E_206C_202C_200F_202E_206C_206B_202E_202C_206F_202A_206D_202E_202E_206C_206F_206B_200B_200E_206A_202E_200F_200C_206D_202A_200F_202B_202A_202D_200B_200E_200D_200C_206B_202C_202E
	{
		internal LuaFunction func;

		internal void _202C_202D_206D_206F_202B_206C_206A_202E_206F_206B_200C_200C_206A_206A_206D_200E_206A_200B_202A_200D_206A_206E_206E_206D_200F_202E_202B_206C_200E_206E_200E_206F_206A_202A_206D_202C_206D_206C_200E_202B_202E(string P_0, string P_1, LogType P_2)
		{
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			int oldTop = func.BeginPCall();
			IntPtr luaState = func.GetLuaState();
			while (true)
			{
				int num = -2094919166;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1277963802)) % 5)
					{
					case 3u:
						break;
					case 2u:
						LuaScriptMgr.Push(luaState, P_0);
						num = ((int)num2 * -1782740882) ^ 0x7C67CFEA;
						continue;
					case 4u:
						LuaScriptMgr.Push(luaState, (Enum)(object)P_2);
						func.PCall(oldTop, 3);
						num = (int)(num2 * 1025420128) ^ -1515038475;
						continue;
					case 1u:
						LuaScriptMgr.Push(luaState, P_1);
						num = ((int)num2 * -1066210012) ^ -1036511327;
						continue;
					default:
						func.EndPCall(oldTop);
						return;
					}
					break;
				}
			}
		}
	}

	private static Dictionary<Type, DelegateValue> dict = new Dictionary<Type, DelegateValue>();

	[NoToLua]
	public static void Register(IntPtr L)
	{
		dict.Add(_200D_206A_206E_206B_206E_200B_200D_202A_206A_200D_206E_206A_200F_200E_206F_206F_200E_206C_202B_206A_200B_206A_206A_202C_200D_206E_206B_200B_206C_202E_206C_206C_206B_200F_202B_202D_202C_200D_202B_200E_202E(typeof(Action<GameObject>).TypeHandle), Action_GameObject);
		while (true)
		{
			int num = 282301613;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5A0D37B7)) % 7)
				{
				case 4u:
					break;
				default:
					return;
				case 6u:
					dict.Add(_200D_206A_206E_206B_206E_200B_200D_202A_206A_200D_206E_206A_200F_200E_206F_206F_200E_206C_202B_206A_200B_206A_206A_202C_200D_206E_206B_200B_206C_202E_206C_206C_206B_200F_202B_202D_202C_200D_202B_200E_202E(typeof(Action).TypeHandle), Action);
					num = ((int)num2 * -1514073176) ^ 0x38E5A09;
					continue;
				case 0u:
					dict.Add(_200D_206A_206E_206B_206E_200B_200D_202A_206A_200D_206E_206A_200F_200E_206F_206F_200E_206C_202B_206A_200B_206A_206A_202C_200D_206E_206B_200B_206C_202E_206C_206C_206B_200F_202B_202D_202C_200D_202B_200E_202E(typeof(CameraCallback).TypeHandle), Camera_CameraCallback);
					dict.Add(_200D_206A_206E_206B_206E_200B_200D_202A_206A_200D_206E_206A_200F_200E_206F_206F_200E_206C_202B_206A_200B_206A_206A_202C_200D_206E_206B_200B_206C_202E_206C_206C_206B_200F_202B_202D_202C_200D_202B_200E_202E(typeof(PCMReaderCallback).TypeHandle), AudioClip_PCMReaderCallback);
					num = (int)(num2 * 471675688) ^ -1701163340;
					continue;
				case 1u:
					dict.Add(_200D_206A_206E_206B_206E_200B_200D_202A_206A_200D_206E_206A_200F_200E_206F_206F_200E_206C_202B_206A_200B_206A_206A_202C_200D_206E_206B_200B_206C_202E_206C_206C_206B_200F_202B_202D_202C_200D_202B_200E_202E(typeof(PCMSetPositionCallback).TypeHandle), AudioClip_PCMSetPositionCallback);
					dict.Add(_200D_206A_206E_206B_206E_200B_200D_202A_206A_200D_206E_206A_200F_200E_206F_206F_200E_206C_202B_206A_200B_206A_206A_202C_200D_206E_206B_200B_206C_202E_206C_206C_206B_200F_202B_202D_202C_200D_202B_200E_202E(typeof(LogCallback).TypeHandle), Application_LogCallback);
					num = (int)((num2 * 1372098321) ^ 0x5DEF57AA);
					continue;
				case 2u:
					dict.Add(_200D_206A_206E_206B_206E_200B_200D_202A_206A_200D_206E_206A_200F_200E_206F_206F_200E_206C_202B_206A_200B_206A_206A_202C_200D_206E_206B_200B_206C_202E_206C_206C_206B_200F_202B_202D_202C_200D_202B_200E_202E(typeof(TestLuaDelegate.VoidDelegate).TypeHandle), TestLuaDelegate_VoidDelegate);
					num = (int)((num2 * 708105643) ^ 0x277FECB8);
					continue;
				case 5u:
					dict.Add(_200D_206A_206E_206B_206E_200B_200D_202A_206A_200D_206E_206A_200F_200E_206F_206F_200E_206C_202B_206A_200B_206A_206A_202C_200D_206E_206B_200B_206C_202E_206C_206C_206B_200F_202B_202D_202C_200D_202B_200E_202E(typeof(UnityAction).TypeHandle), UnityEngine_Events_UnityAction);
					dict.Add(_200D_206A_206E_206B_206E_200B_200D_202A_206A_200D_206E_206A_200F_200E_206F_206F_200E_206C_202B_206A_200B_206A_206A_202C_200D_206E_206B_200B_206C_202E_206C_206C_206B_200F_202B_202D_202C_200D_202B_200E_202E(typeof(MemberFilter).TypeHandle), System_Reflection_MemberFilter);
					dict.Add(_200D_206A_206E_206B_206E_200B_200D_202A_206A_200D_206E_206A_200F_200E_206F_206F_200E_206C_202B_206A_200B_206A_206A_202C_200D_206E_206B_200B_206C_202E_206C_206C_206B_200F_202B_202D_202C_200D_202B_200E_202E(typeof(TypeFilter).TypeHandle), System_Reflection_TypeFilter);
					num = (int)(num2 * 1886392990) ^ -1400252682;
					continue;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	[NoToLua]
	public static Delegate CreateDelegate(Type t, LuaFunction func)
	{
		DelegateValue value = null;
		if (!dict.TryGetValue(t, out value))
		{
			while (true)
			{
				int num = 1724579537;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x7C72F5D6)) % 4)
					{
					case 0u:
						break;
					case 3u:
						Debugger.LogError(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3254320765u), _206D_202C_202E_206E_206B_200D_206F_206C_206C_200D_206E_202B_200B_200D_206F_200D_202D_200D_202B_200F_202D_206A_206D_206C_206B_202B_202B_200F_206F_202C_200B_202D_206B_200E_206F_202B_206A_202A_206F_202C_202E(t));
						num = ((int)num2 * -1997342232) ^ 0xF49B2C;
						continue;
					case 2u:
						return null;
					default:
						goto end_IL_0011;
					}
					break;
				}
				continue;
				end_IL_0011:
				break;
			}
		}
		return value(func);
	}

	public static Delegate Action_GameObject(LuaFunction func)
	{
		return (Action<GameObject>)delegate(GameObject P_0)
		{
			int oldTop = func.BeginPCall();
			while (true)
			{
				int num = 988529499;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x169CC775)) % 5)
					{
					case 0u:
						break;
					default:
						return;
					case 1u:
						func.EndPCall(oldTop);
						num = (int)(num2 * 725542370) ^ -1107702422;
						continue;
					case 4u:
						func.PCall(oldTop, 1);
						num = ((int)num2 * -28224323) ^ -1455633247;
						continue;
					case 3u:
					{
						IntPtr luaState = func.GetLuaState();
						LuaScriptMgr.Push(luaState, (Object)(object)P_0);
						num = ((int)num2 * -1947216449) ^ 0x6460EA4;
						continue;
					}
					case 2u:
						return;
					}
					break;
				}
			}
		};
	}

	public static Delegate Action(LuaFunction func)
	{
		return (Action)delegate
		{
			func.Call();
		};
	}

	public static Delegate UnityEngine_Events_UnityAction(LuaFunction func)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Delegate)(UnityAction)delegate
		{
			func.Call();
		};
	}

	public static Delegate System_Reflection_MemberFilter(LuaFunction func)
	{
		return (MemberFilter)delegate(MemberInfo P_0, object P_1)
		{
			int oldTop = func.BeginPCall();
			IntPtr luaState = func.GetLuaState();
			object[] array = default(object[]);
			while (true)
			{
				int num = 795750324;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x78016710)) % 7)
					{
					case 2u:
						break;
					case 6u:
						array = func.PopValues(oldTop);
						num = (int)(num2 * 361515732) ^ -309417603;
						continue;
					case 1u:
						func.EndPCall(oldTop);
						num = ((int)num2 * -2050600725) ^ 0x3F97FE4D;
						continue;
					case 5u:
						LuaScriptMgr.PushObject(luaState, P_0);
						num = ((int)num2 * -1372953480) ^ -1660226082;
						continue;
					case 4u:
						func.PCall(oldTop, 2);
						num = ((int)num2 * -932488953) ^ -388662379;
						continue;
					case 3u:
						LuaScriptMgr.PushVarObject(luaState, P_1);
						num = (int)((num2 * 1703253306) ^ 0x427023D0);
						continue;
					default:
						return (bool)array[0];
					}
					break;
				}
			}
		};
	}

	public static Delegate System_Reflection_TypeFilter(LuaFunction func)
	{
		LuaFunction func2 = default(LuaFunction);
		TypeFilter result = default(TypeFilter);
		while (true)
		{
			int num = 1677537462;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3C900468)) % 4)
				{
				case 0u:
					break;
				case 2u:
					func2 = func;
					num = ((int)num2 * -1711139780) ^ -792348283;
					continue;
				case 1u:
					result = delegate(Type P_0, object P_1)
					{
						int oldTop = func2.BeginPCall();
						IntPtr luaState = default(IntPtr);
						object[] array = default(object[]);
						while (true)
						{
							int num3 = 2080732385;
							while (true)
							{
								uint num4;
								switch ((num4 = (uint)(num3 ^ 0x677399BE)) % 6)
								{
								case 4u:
									break;
								case 3u:
									luaState = func2.GetLuaState();
									LuaScriptMgr.Push(luaState, P_0);
									num3 = ((int)num4 * -1623765929) ^ -432680480;
									continue;
								case 5u:
									LuaScriptMgr.PushVarObject(luaState, P_1);
									num3 = ((int)num4 * -389179698) ^ -387332716;
									continue;
								case 0u:
									array = func2.PopValues(oldTop);
									func2.EndPCall(oldTop);
									num3 = (int)((num4 * 528944346) ^ 0x2DCDE90F);
									continue;
								case 2u:
									func2.PCall(oldTop, 2);
									num3 = (int)(num4 * 1718746241) ^ -568473370;
									continue;
								default:
									return (bool)array[0];
								}
								break;
							}
						}
					};
					num = (int)(num2 * 1038309633) ^ -1402085738;
					continue;
				default:
					return result;
				}
				break;
			}
		}
	}

	public static Delegate TestLuaDelegate_VoidDelegate(LuaFunction func)
	{
		return (TestLuaDelegate.VoidDelegate)delegate(GameObject P_0)
		{
			int oldTop = func.BeginPCall();
			IntPtr luaState = func.GetLuaState();
			while (true)
			{
				int num = 1314113040;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x76A6EC5)) % 5)
					{
					case 2u:
						break;
					default:
						return;
					case 0u:
						func.EndPCall(oldTop);
						num = (int)(num2 * 2043899685) ^ -180637351;
						continue;
					case 3u:
						func.PCall(oldTop, 1);
						num = (int)((num2 * 1870990754) ^ 0x2767CC5);
						continue;
					case 1u:
						LuaScriptMgr.Push(luaState, (Object)(object)P_0);
						num = ((int)num2 * -516911706) ^ 0x68F4D523;
						continue;
					case 4u:
						return;
					}
					break;
				}
			}
		};
	}

	public static Delegate Camera_CameraCallback(LuaFunction func)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Delegate)(CameraCallback)delegate(Camera P_0)
		{
			int oldTop = func.BeginPCall();
			while (true)
			{
				int num = -170671225;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1960963571)) % 5)
					{
					case 0u:
						break;
					default:
						return;
					case 3u:
					{
						IntPtr luaState = func.GetLuaState();
						LuaScriptMgr.Push(luaState, (Object)(object)P_0);
						num = (int)(num2 * 1788780669) ^ -1302596986;
						continue;
					}
					case 2u:
						func.EndPCall(oldTop);
						num = (int)(num2 * 2132567835) ^ -1353486268;
						continue;
					case 4u:
						func.PCall(oldTop, 1);
						num = (int)((num2 * 226091355) ^ 0x65101A5D);
						continue;
					case 1u:
						return;
					}
					break;
				}
			}
		};
	}

	public static Delegate AudioClip_PCMReaderCallback(LuaFunction func)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		LuaFunction func2 = default(LuaFunction);
		PCMReaderCallback result = default(PCMReaderCallback);
		while (true)
		{
			int num = 218743966;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x39969197)) % 4)
				{
				case 2u:
					break;
				case 1u:
					func2 = func;
					num = ((int)num2 * -1758519850) ^ -243862899;
					continue;
				case 0u:
					result = (PCMReaderCallback)delegate(float[] P_0)
					{
						int oldTop = func2.BeginPCall();
						while (true)
						{
							int num3 = 77572154;
							while (true)
							{
								uint num4;
								switch ((num4 = (uint)(num3 ^ 0x64E2AACB)) % 3)
								{
								case 0u:
									break;
								case 2u:
									goto IL_002e;
								default:
									func2.PCall(oldTop, 1);
									func2.EndPCall(oldTop);
									return;
								}
								break;
								IL_002e:
								IntPtr luaState = func2.GetLuaState();
								LuaScriptMgr.PushArray(luaState, P_0);
								num3 = (int)((num4 * 935429608) ^ 0x46413090);
							}
						}
					};
					num = ((int)num2 * -1848586829) ^ -273027008;
					continue;
				default:
					return (Delegate)(object)result;
				}
				break;
			}
		}
	}

	public static Delegate AudioClip_PCMSetPositionCallback(LuaFunction func)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		PCMSetPositionCallback result = default(PCMSetPositionCallback);
		while (true)
		{
			int num = -284997079;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -162988788)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_002f;
				default:
					return (Delegate)(object)result;
				}
				break;
				IL_002f:
				result = (PCMSetPositionCallback)delegate(int P_0)
				{
					int oldTop = func.BeginPCall();
					IntPtr luaState = func.GetLuaState();
					LuaScriptMgr.Push(luaState, P_0);
					func.PCall(oldTop, 1);
					func.EndPCall(oldTop);
				};
				num = (int)(num2 * 1837619504) ^ -1944085345;
			}
		}
	}

	public static Delegate Application_LogCallback(LuaFunction func)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		LogCallback result = default(LogCallback);
		while (true)
		{
			int num = -2100411276;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -208033398)) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_002f;
				default:
					return (Delegate)(object)result;
				}
				break;
				IL_002f:
				result = (LogCallback)delegate(string P_0, string P_1, LogType P_2)
				{
					//IL_0059: Unknown result type (might be due to invalid IL or missing references)
					int oldTop = func.BeginPCall();
					IntPtr luaState = func.GetLuaState();
					while (true)
					{
						int num3 = -2094919166;
						while (true)
						{
							uint num4;
							switch ((num4 = (uint)(num3 ^ -1277963802)) % 5)
							{
							case 3u:
								break;
							case 2u:
								LuaScriptMgr.Push(luaState, P_0);
								num3 = ((int)num4 * -1782740882) ^ 0x7C67CFEA;
								continue;
							case 4u:
								LuaScriptMgr.Push(luaState, (Enum)(object)P_2);
								func.PCall(oldTop, 3);
								num3 = (int)(num4 * 1025420128) ^ -1515038475;
								continue;
							case 1u:
								LuaScriptMgr.Push(luaState, P_1);
								num3 = ((int)num4 * -1066210012) ^ -1036511327;
								continue;
							default:
								func.EndPCall(oldTop);
								return;
							}
							break;
						}
					}
				};
				num = (int)((num2 * 1578812104) ^ 0x5937B961);
			}
		}
	}

	public static void Clear()
	{
		dict.Clear();
	}

	static Type _200D_206A_206E_206B_206E_200B_200D_202A_206A_200D_206E_206A_200F_200E_206F_206F_200E_206C_202B_206A_200B_206A_206A_202C_200D_206E_206B_200B_206C_202E_206C_206C_206B_200F_202B_202D_202C_200D_202B_200E_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static string _206D_202C_202E_206E_206B_200D_206F_206C_206C_200D_206E_202B_200B_200D_206F_200D_202D_200D_202B_200F_202D_206A_206D_206C_206B_202B_202B_200F_206F_202C_200B_202D_206B_200E_206F_202B_206A_202A_206F_202C_202E(Type P_0)
	{
		return P_0.FullName;
	}
}
