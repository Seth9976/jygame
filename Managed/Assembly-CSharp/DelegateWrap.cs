using System;
using System.Reflection;
using System.Runtime.Serialization;
using LuaInterface;

public class DelegateWrap
{
	private static Type classType = _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(Delegate).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[15]
		{
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3975941672u), CreateDelegate),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(123495267u), DynamicInvoke),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2626338238u), Clone),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3651406763u), GetObjectData),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(661811337u), GetInvocationList),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(186814796u), Combine),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2380042497u), Remove),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1621546331u), RemoveAll),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1470604359u), GetHashCode),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3594585358u), Equals),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2705981273u), _202D_206A_202A_200C_202D_206E_206F_202A_206F_206A_206A_200F_200C_206B_202E_200D_202C_202C_206B_200E_200E_206F_206A_206B_202C_206C_206E_200B_206D_200B_200E_200D_200C_200F_202E_206F_202D_202A_206C_206F_202E),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(215375861u), GetClassType),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2952574115u), Lua_Add),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(261471070u), Lua_Sub),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(396454614u), Lua_Eq)
		};
		while (true)
		{
			int num = -531898859;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1788237517)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_027c;
				case 1u:
					return;
				}
				break;
				IL_027c:
				LuaField[] fields = new LuaField[2]
				{
					new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2536537180u), get_Method, null),
					new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1761538898u), get_Target, null)
				};
				LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(415240739u), _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(Delegate).TypeHandle), regs, fields, _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(object).TypeHandle));
				num = (int)((num2 * 340424610) ^ 0x324CC0A7);
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _202D_206A_202A_200C_202D_206E_206F_202A_206F_206A_206A_200F_200C_206B_202E_200D_202C_202C_206B_200E_200E_206F_206A_206B_202C_206C_206E_200B_206D_200B_200E_200D_200C_200F_202E_206F_202D_202A_206C_206F_202E(IntPtr P_0)
	{
		LuaDLL.luaL_error(P_0, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2339726427u));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_Method(IntPtr L)
	{
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		Delegate obj = default(Delegate);
		while (true)
		{
			int num = -1976773112;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -226160591)) % 9)
				{
				case 4u:
					break;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(536315627u));
					num = -1229648222;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2552355482u));
					num = ((int)num2 * -1688701166) ^ 0x75FF15CD;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -1330150265;
						num6 = num5;
					}
					else
					{
						num5 = -1455174202;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1250501659);
					continue;
				}
				case 6u:
					num = (int)((num2 * 1437780550) ^ 0x2EF9FBA6);
					continue;
				case 8u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 1802797802) ^ 0x34342BDE);
					continue;
				case 5u:
					LuaScriptMgr.PushObject(L, _206C_206E_200E_206B_202B_200C_206F_206D_202A_202D_202B_206F_202C_200D_206C_206F_206F_200E_202D_206A_206C_202C_206F_202A_206F_206E_202E_202B_206A_206C_200E_200C_202E_200F_202D_202B_202E_202A_206F_200D_202E(obj));
					num = -1245049110;
					continue;
				case 1u:
				{
					obj = (Delegate)luaObject;
					int num3;
					int num4;
					if ((object)obj == null)
					{
						num3 = -1062346910;
						num4 = num3;
					}
					else
					{
						num3 = -1533644087;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -753567805);
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
	private static int get_Target(IntPtr L)
	{
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Delegate obj = default(Delegate);
		while (true)
		{
			int num = -483814746;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1451184764)) % 6)
				{
				case 0u:
					break;
				case 4u:
				{
					obj = (Delegate)luaObject;
					int num5;
					int num6;
					if ((object)obj == null)
					{
						num5 = -1923801525;
						num6 = num5;
					}
					else
					{
						num5 = -1955114059;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1405039452);
					continue;
				}
				case 5u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 600485236;
						num4 = num3;
					}
					else
					{
						num3 = 1717802109;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -64677202);
					continue;
				}
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(376313879u));
					num = -666051971;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3739942431u));
					num = (int)((num2 * 595996889) ^ 0xBCB537E);
					continue;
				default:
					LuaScriptMgr.PushVarObject(L, _206E_200E_202D_206C_200B_200E_200E_200D_206B_206E_202B_200D_200C_206C_202C_202C_202B_200E_200E_206F_206D_202A_202A_202E_206D_206F_202D_200C_200E_206D_200C_200C_206B_202B_206F_202A_202E_202D_206F_202E_202E(obj));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int CreateDelegate(IntPtr L)
	{
		int num = LuaDLL.lua_gettop(L);
		if (num == 2)
		{
			goto IL_000e;
		}
		goto IL_09de;
		IL_000e:
		int num2 = 1811650983;
		goto IL_0013;
		IL_0013:
		Delegate o3 = default(Delegate);
		string text2 = default(string);
		bool flag = default(bool);
		Type typeObject13 = default(Type);
		Type typeObject9 = default(Type);
		string text4 = default(string);
		bool flag8 = default(bool);
		bool flag5 = default(bool);
		MethodInfo methodInfo2 = default(MethodInfo);
		bool flag7 = default(bool);
		Delegate o10 = default(Delegate);
		Type typeObject = default(Type);
		Type typeObject12 = default(Type);
		Type typeObject2 = default(Type);
		Type typeObject10 = default(Type);
		object varObject4 = default(object);
		string text5 = default(string);
		Type typeObject6 = default(Type);
		string text = default(string);
		object varObject5 = default(object);
		MethodInfo methodInfo3 = default(MethodInfo);
		Type typeObject11 = default(Type);
		Delegate o8 = default(Delegate);
		Type typeObject8 = default(Type);
		object varObject = default(object);
		MethodInfo methodInfo4 = default(MethodInfo);
		bool flag3 = default(bool);
		Delegate o5 = default(Delegate);
		Type typeObject5 = default(Type);
		MethodInfo methodInfo = default(MethodInfo);
		bool flag4 = default(bool);
		Type typeObject3 = default(Type);
		object varObject2 = default(object);
		string text3 = default(string);
		bool flag2 = default(bool);
		object varObject3 = default(object);
		string text6 = default(string);
		Type typeObject7 = default(Type);
		Delegate o4 = default(Delegate);
		Type typeObject4 = default(Type);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ 0x62F227F0)) % 72)
			{
			case 6u:
				break;
			case 14u:
				LuaScriptMgr.Push(L, o3);
				num2 = ((int)num3 * -1109476522) ^ 0x7CB03967;
				continue;
			case 71u:
				goto IL_0164;
			case 24u:
				text2 = LuaScriptMgr.GetString(L, 3);
				flag = LuaDLL.lua_toboolean(L, 4);
				num2 = (int)((num3 * 927041676) ^ 0x22C57769);
				continue;
			case 7u:
				o3 = _200E_200E_202B_202C_206A_206A_202B_200B_206B_200C_206A_202B_200E_200B_206E_200C_206A_200F_200C_206C_206B_206E_206A_200C_206E_202E_206E_202C_200D_202D_200D_202D_200D_206F_200B_200D_202C_206A_200F_206F_202E(typeObject13, typeObject9, text4, flag8, flag5);
				num2 = (int)((num3 * 1546841651) ^ 0x134DCD73);
				continue;
			case 42u:
			{
				int num12;
				int num13;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(Type).TypeHandle), _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(object).TypeHandle), _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(string).TypeHandle), _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(bool).TypeHandle), _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(bool).TypeHandle)))
				{
					num12 = 1221455943;
					num13 = num12;
				}
				else
				{
					num12 = 64847364;
					num13 = num12;
				}
				num2 = num12 ^ ((int)num3 * -597833884);
				continue;
			}
			case 68u:
				typeObject9 = LuaScriptMgr.GetTypeObject(L, 2);
				num2 = ((int)num3 * -1493465439) ^ -1664229593;
				continue;
			case 53u:
				methodInfo2 = (MethodInfo)LuaScriptMgr.GetNetObject(L, 2, _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(MethodInfo).TypeHandle));
				num2 = (int)((num3 * 520960855) ^ 0x4BE34450);
				continue;
			case 5u:
			{
				int num18;
				int num19;
				if (LuaScriptMgr.CheckTypes(L, 1, _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(Type).TypeHandle), _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(Type).TypeHandle), _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(string).TypeHandle), _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(bool).TypeHandle)))
				{
					num18 = -743321731;
					num19 = num18;
				}
				else
				{
					num18 = -279994730;
					num19 = num18;
				}
				num2 = num18 ^ (int)(num3 * 1968860305);
				continue;
			}
			case 38u:
				flag7 = LuaDLL.lua_toboolean(L, 4);
				num2 = ((int)num3 * -1094071981) ^ 0x406D7B88;
				continue;
			case 67u:
				return 1;
			case 26u:
				goto IL_02e2;
			case 35u:
				LuaScriptMgr.Push(L, o10);
				return 1;
			case 30u:
				typeObject = LuaScriptMgr.GetTypeObject(L, 1);
				num2 = ((int)num3 * -1557609519) ^ 0x76FF1D76;
				continue;
			case 60u:
				typeObject12 = LuaScriptMgr.GetTypeObject(L, 1);
				num2 = ((int)num3 * -412773734) ^ -1253061740;
				continue;
			case 0u:
				typeObject2 = LuaScriptMgr.GetTypeObject(L, 2);
				num2 = ((int)num3 * -1800242200) ^ 0x43BA5681;
				continue;
			case 48u:
			{
				int num8;
				int num9;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(Type).TypeHandle), _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(object).TypeHandle), _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(string).TypeHandle)))
				{
					num8 = -1222766089;
					num9 = num8;
				}
				else
				{
					num8 = -2048474752;
					num9 = num8;
				}
				num2 = num8 ^ (int)(num3 * 521895194);
				continue;
			}
			case 58u:
				goto IL_03af;
			case 32u:
				typeObject10 = LuaScriptMgr.GetTypeObject(L, 1);
				varObject4 = LuaScriptMgr.GetVarObject(L, 2);
				text5 = LuaScriptMgr.GetString(L, 3);
				num2 = (int)((num3 * 911029936) ^ 0xC431839);
				continue;
			case 11u:
				goto IL_03f5;
			case 62u:
				typeObject6 = LuaScriptMgr.GetTypeObject(L, 1);
				num2 = ((int)num3 * -363989548) ^ 0x1A5041C3;
				continue;
			case 46u:
				goto IL_0429;
			case 66u:
			{
				int num20;
				int num21;
				if (LuaScriptMgr.CheckTypes(L, 1, _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(Type).TypeHandle), _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(MethodInfo).TypeHandle), _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(bool).TypeHandle)))
				{
					num20 = 1309656188;
					num21 = num20;
				}
				else
				{
					num20 = 1081792112;
					num21 = num20;
				}
				num2 = num20 ^ ((int)num3 * -738139867);
				continue;
			}
			case 49u:
				text = LuaScriptMgr.GetString(L, 3);
				num2 = (int)(num3 * 47256890) ^ -1707401862;
				continue;
			case 33u:
				return 1;
			case 13u:
				varObject5 = LuaScriptMgr.GetVarObject(L, 2);
				methodInfo3 = (MethodInfo)LuaScriptMgr.GetLuaObject(L, 3);
				num2 = ((int)num3 * -919608108) ^ -387770;
				continue;
			case 3u:
				flag8 = LuaDLL.lua_toboolean(L, 4);
				num2 = (int)(num3 * 1363600066) ^ -256283252;
				continue;
			case 47u:
				return 1;
			case 43u:
				goto IL_0511;
			case 41u:
				typeObject11 = LuaScriptMgr.GetTypeObject(L, 1);
				num2 = (int)((num3 * 1654715321) ^ 0x2CDC4594);
				continue;
			case 23u:
				LuaScriptMgr.Push(L, o8);
				num2 = (int)(num3 * 2109832051) ^ -1920027688;
				continue;
			case 28u:
			{
				int num16;
				int num17;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(Type).TypeHandle), _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(object).TypeHandle), _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(MethodInfo).TypeHandle), _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(bool).TypeHandle)))
				{
					num16 = 1888518134;
					num17 = num16;
				}
				else
				{
					num16 = 2034860701;
					num17 = num16;
				}
				num2 = num16 ^ ((int)num3 * -2055317690);
				continue;
			}
			case 17u:
				typeObject13 = LuaScriptMgr.GetTypeObject(L, 1);
				num2 = ((int)num3 * -1104101757) ^ -1867237673;
				continue;
			case 31u:
			{
				int num14;
				int num15;
				if (LuaScriptMgr.CheckTypes(L, 1, _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(Type).TypeHandle), _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(Type).TypeHandle), _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(string).TypeHandle), _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(bool).TypeHandle), _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(bool).TypeHandle)))
				{
					num14 = 1467384741;
					num15 = num14;
				}
				else
				{
					num14 = 1591590966;
					num15 = num14;
				}
				num2 = num14 ^ (int)(num3 * 1241483556);
				continue;
			}
			case 65u:
				o10 = _202C_202C_206A_206F_200E_202D_206F_206E_200B_206B_200B_206D_202A_206D_206E_200B_202E_206C_206C_200F_200E_200B_206B_200F_200C_206C_202E_206B_206B_200C_206C_206A_200C_206F_206B_202E_202A_200E_206E_202E(typeObject8, varObject, methodInfo4, flag3);
				num2 = (int)(num3 * 84722087) ^ -1355662900;
				continue;
			case 9u:
				o5 = _206A_206E_202A_202A_206C_206A_202D_206D_200E_200C_200F_206C_202B_206A_200B_200C_202B_206C_202A_202E_200C_206A_206D_200F_200F_200C_200C_206C_202B_206C_202A_200C_202E_202B_206F_202B_202D_202A_206C_200C_202E(typeObject10, varObject4, text5);
				num2 = ((int)num3 * -852423094) ^ -1203691659;
				continue;
			case 55u:
				typeObject5 = LuaScriptMgr.GetTypeObject(L, 1);
				num2 = (int)((num3 * 2090860859) ^ 0x516D6658);
				continue;
			case 54u:
				return 1;
			case 36u:
			{
				Delegate o9 = _206B_206C_206E_200F_200B_202C_206F_202E_206C_206E_206C_206C_202C_202D_206E_202E_206E_202E_200D_200B_206E_200F_206B_200F_206B_200E_206B_202A_200D_200D_200E_202A_206B_200F_200F_202D_202B_200D_202D_202E_202E(typeObject6, methodInfo, flag4);
				LuaScriptMgr.Push(L, o9);
				num2 = ((int)num3 * -449365615) ^ 0x34237B6B;
				continue;
			}
			case 57u:
				o8 = _200B_200C_202E_206F_206F_202E_202D_206F_206E_200F_202B_202E_200C_200D_206C_200C_202A_206B_206F_206F_206B_206E_200D_206C_202C_206A_206B_200B_202B_200E_200D_206A_206F_206A_206F_200D_200F_200E_202B_202A_202E(typeObject3, varObject2, text3, flag2);
				num2 = ((int)num3 * -468524894) ^ -1154006731;
				continue;
			case 2u:
			{
				bool flag6 = LuaDLL.lua_toboolean(L, 5);
				Delegate o7 = _206D_206C_206C_206C_206E_200D_202E_200F_206F_200B_202B_200C_202C_200E_202B_200B_206D_202E_206D_206B_202A_206D_206B_206A_200E_206F_202C_200E_202E_202E_206C_206E_206B_202A_202B_202B_206B_202D_206A_200D_202E(typeObject12, varObject3, text6, flag7, flag6);
				LuaScriptMgr.Push(L, o7);
				num2 = ((int)num3 * -288778469) ^ 0x59F13A0E;
				continue;
			}
			case 4u:
				goto IL_0713;
			case 12u:
				text6 = LuaScriptMgr.GetString(L, 3);
				num2 = ((int)num3 * -1354657577) ^ 0x2373FBFA;
				continue;
			case 15u:
				return 1;
			case 19u:
				return 1;
			case 39u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(43724145u));
				num2 = 1956828772;
				continue;
			case 18u:
				flag5 = LuaDLL.lua_toboolean(L, 5);
				num2 = (int)((num3 * 452328753) ^ 0x2F4A68CD);
				continue;
			case 34u:
				methodInfo4 = (MethodInfo)LuaScriptMgr.GetLuaObject(L, 3);
				num2 = (int)((num3 * 1508792219) ^ 0x51DC1607);
				continue;
			case 21u:
				return 1;
			case 10u:
			{
				Delegate o6 = _206B_200E_206C_206B_206F_206B_206C_200E_200B_206E_202B_200F_206D_206D_202B_202B_202E_200F_202C_200F_202C_202A_206C_206D_206B_206A_206F_200C_200D_202A_206D_206D_200F_206A_202A_206F_200F_200C_200F_206B_202E(typeObject11, varObject5, methodInfo3);
				LuaScriptMgr.Push(L, o6);
				num2 = ((int)num3 * -1653878292) ^ 0x2A5562D9;
				continue;
			}
			case 63u:
				LuaScriptMgr.Push(L, o5);
				return 1;
			case 40u:
				typeObject7 = LuaScriptMgr.GetTypeObject(L, 1);
				num2 = ((int)num3 * -2024274268) ^ -1293045504;
				continue;
			case 70u:
				LuaScriptMgr.Push(L, o4);
				num2 = (int)((num3 * 114337369) ^ 0x6DB16B68);
				continue;
			case 29u:
				flag4 = LuaDLL.lua_toboolean(L, 3);
				num2 = (int)((num3 * 971825570) ^ 0x643C4E1E);
				continue;
			case 25u:
				flag3 = LuaDLL.lua_toboolean(L, 4);
				num2 = ((int)num3 * -1011020939) ^ -303965180;
				continue;
			case 52u:
			{
				int num10;
				int num11;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(Type).TypeHandle), _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(Type).TypeHandle), _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(string).TypeHandle)))
				{
					num10 = -135221718;
					num11 = num10;
				}
				else
				{
					num10 = -1428464226;
					num11 = num10;
				}
				num2 = num10 ^ (int)(num3 * 2043208828);
				continue;
			}
			case 45u:
			{
				int num6;
				int num7;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(Type).TypeHandle), _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(object).TypeHandle), _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(MethodInfo).TypeHandle)))
				{
					num6 = 1279666925;
					num7 = num6;
				}
				else
				{
					num6 = 937444072;
					num7 = num6;
				}
				num2 = num6 ^ ((int)num3 * -1584796995);
				continue;
			}
			case 50u:
				goto IL_0919;
			case 44u:
				varObject3 = LuaScriptMgr.GetVarObject(L, 2);
				num2 = ((int)num3 * -1911025896) ^ -272439340;
				continue;
			case 59u:
				text4 = LuaScriptMgr.GetString(L, 3);
				num2 = ((int)num3 * -2105627961) ^ -905868586;
				continue;
			case 64u:
				varObject2 = LuaScriptMgr.GetVarObject(L, 2);
				text3 = LuaScriptMgr.GetString(L, 3);
				flag2 = LuaDLL.lua_toboolean(L, 4);
				num2 = ((int)num3 * -660545412) ^ -1612114055;
				continue;
			case 69u:
				typeObject8 = LuaScriptMgr.GetTypeObject(L, 1);
				varObject = LuaScriptMgr.GetVarObject(L, 2);
				num2 = ((int)num3 * -1234870842) ^ 0x685D745C;
				continue;
			case 1u:
				o4 = _202C_200D_200B_200F_202B_206D_200B_200B_200C_206D_206C_200F_206F_200D_202C_202E_206F_206A_206D_206A_202B_206E_202A_202B_206E_206E_206B_206E_200F_206D_200D_206D_200D_206D_202E_206F_200B_206B_200C_206F_202E(typeObject7, typeObject4, text2, flag);
				num2 = (int)(num3 * 1077247579) ^ -889190531;
				continue;
			case 61u:
				goto IL_09de;
			case 22u:
			{
				int num4;
				int num5;
				if (LuaScriptMgr.CheckTypes(L, 1, _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(Type).TypeHandle), _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(object).TypeHandle), _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(string).TypeHandle), _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(bool).TypeHandle)))
				{
					num4 = 1293659539;
					num5 = num4;
				}
				else
				{
					num4 = 1928655013;
					num5 = num4;
				}
				num2 = num4 ^ (int)(num3 * 2118755641);
				continue;
			}
			case 8u:
				return 1;
			case 51u:
			{
				Delegate o2 = _202B_200C_206C_206D_206E_202D_202B_206B_206C_200D_202B_200D_200C_206C_200F_206E_206B_202D_202C_202B_200B_206E_206D_206A_200C_200B_206C_202C_200E_202E_202B_206B_202C_200F_202C_206A_206A_202B_202C_202E(typeObject5, methodInfo2);
				LuaScriptMgr.Push(L, o2);
				num2 = ((int)num3 * -1755595461) ^ 0x3114CD6;
				continue;
			}
			case 27u:
				methodInfo = (MethodInfo)LuaScriptMgr.GetLuaObject(L, 2);
				num2 = ((int)num3 * -51614409) ^ -538051376;
				continue;
			case 56u:
				typeObject4 = LuaScriptMgr.GetTypeObject(L, 2);
				num2 = (int)((num3 * 776884259) ^ 0x4FE80FA8);
				continue;
			case 37u:
				typeObject3 = LuaScriptMgr.GetTypeObject(L, 1);
				num2 = ((int)num3 * -1228130953) ^ -969810517;
				continue;
			case 16u:
			{
				Delegate o = _206F_202C_206A_200E_206A_206B_206A_200F_206A_200E_202C_206F_206F_206C_206B_200E_200B_206B_200E_206C_200F_200B_202E_206F_202B_200B_206B_200C_200B_200E_206A_202A_200D_206A_200B_206B_200B_200F_202D_202D_202E(typeObject, typeObject2, text);
				LuaScriptMgr.Push(L, o);
				num2 = ((int)num3 * -1906613652) ^ -2067258597;
				continue;
			}
			default:
				return 0;
			}
			break;
			IL_0919:
			int num22;
			if (num != 5)
			{
				num2 = 208049679;
				num22 = num2;
			}
			else
			{
				num2 = 1281244946;
				num22 = num2;
			}
			continue;
			IL_02e2:
			int num23;
			if (num != 3)
			{
				num2 = 465340698;
				num23 = num2;
			}
			else
			{
				num2 = 2138244932;
				num23 = num2;
			}
			continue;
			IL_0429:
			int num24;
			if (num == 5)
			{
				num2 = 1065550871;
				num24 = num2;
			}
			else
			{
				num2 = 216361802;
				num24 = num2;
			}
			continue;
			IL_0713:
			int num25;
			if (num != 4)
			{
				num2 = 2113575019;
				num25 = num2;
			}
			else
			{
				num2 = 1731575389;
				num25 = num2;
			}
			continue;
			IL_0164:
			int num26;
			if (num == 3)
			{
				num2 = 398109789;
				num26 = num2;
			}
			else
			{
				num2 = 1050045012;
				num26 = num2;
			}
			continue;
			IL_03af:
			int num27;
			if (num != 3)
			{
				num2 = 443279447;
				num27 = num2;
			}
			else
			{
				num2 = 2076328928;
				num27 = num2;
			}
			continue;
			IL_0511:
			int num28;
			if (num == 4)
			{
				num2 = 669395110;
				num28 = num2;
			}
			else
			{
				num2 = 1881876611;
				num28 = num2;
			}
			continue;
			IL_03f5:
			int num29;
			if (num != 4)
			{
				num2 = 721702686;
				num29 = num2;
			}
			else
			{
				num2 = 366521100;
				num29 = num2;
			}
		}
		goto IL_000e;
		IL_09de:
		int num30;
		if (num != 3)
		{
			num2 = 1465682498;
			num30 = num2;
		}
		else
		{
			num2 = 841643578;
			num30 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int DynamicInvoke(IntPtr L)
	{
		int num = LuaDLL.lua_gettop(L);
		Delegate obj = (Delegate)LuaScriptMgr.GetNetObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2208149784u));
		object[] paramsObject = LuaScriptMgr.GetParamsObject(L, 2, num - 1);
		object o = _206A_206D_206D_206A_200F_206F_206C_206D_200E_200C_200D_200F_206D_206C_206E_200B_206B_206A_206C_206C_200E_200F_200D_206D_206F_202D_200D_200D_200B_200B_200E_202E_206B_206B_206C_206B_200C_200B_202B_202A_202E(obj, paramsObject);
		LuaScriptMgr.PushVarObject(L, o);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Clone(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		while (true)
		{
			int num = 707103257;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6D09E4F7)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_0029;
				default:
					return 1;
				}
				break;
				IL_0029:
				Delegate obj = (Delegate)LuaScriptMgr.GetNetObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2328103337u));
				object o = _202B_202B_206C_206D_206D_200F_200F_200F_206D_200D_200C_206D_202C_200D_206B_202B_200B_206C_202A_202D_202D_202C_202A_202A_206D_200D_202D_200E_200D_206E_206A_206C_206C_206F_200E_206F_206A_202B_202B_206F_202E(obj);
				LuaScriptMgr.PushVarObject(L, o);
				num = (int)(num2 * 134880581) ^ -1797414191;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetObjectData(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		Delegate obj = default(Delegate);
		SerializationInfo serializationInfo = default(SerializationInfo);
		StreamingContext streamingContext = default(StreamingContext);
		while (true)
		{
			int num = 1091752819;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2ECEDCDD)) % 4)
				{
				case 0u:
					break;
				case 2u:
					obj = (Delegate)LuaScriptMgr.GetNetObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1280722510u));
					num = (int)((num2 * 570494805) ^ 0x6E063C92);
					continue;
				case 1u:
					serializationInfo = (SerializationInfo)LuaScriptMgr.GetNetObject(L, 2, _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(SerializationInfo).TypeHandle));
					streamingContext = (StreamingContext)LuaScriptMgr.GetNetObject(L, 3, _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(StreamingContext).TypeHandle));
					num = (int)((num2 * 628454669) ^ 0x10BF7D33);
					continue;
				default:
					_202C_202D_206D_202E_206F_206B_202C_202C_200C_202E_200D_206D_200E_202B_206F_202C_206C_202A_206D_200B_206C_200E_206A_206C_202C_206C_202C_206A_206A_202E_202D_206C_202A_202B_200E_202A_202B_202A_200B_206C_202E(obj, serializationInfo, streamingContext);
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetInvocationList(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Delegate obj = (Delegate)LuaScriptMgr.GetNetObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2208149784u));
		while (true)
		{
			int num = 580359735;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x50DCCCB)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_0040;
				default:
					return 1;
				}
				break;
				IL_0040:
				Delegate[] o = _202A_206E_202B_200D_200D_202E_206D_200D_206C_206B_206C_202A_206E_206B_202B_206F_202C_206F_202E_200D_200E_200D_202E_206A_202C_202D_200B_206D_206C_200C_200F_202C_200B_200C_206A_206B_206B_206E_202C_202E_202E(obj);
				LuaScriptMgr.PushArray(L, o);
				num = ((int)num2 * -663540187) ^ -1574578025;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Combine(IntPtr L)
	{
		int num = LuaDLL.lua_gettop(L);
		Delegate obj = default(Delegate);
		Delegate obj2 = default(Delegate);
		while (true)
		{
			int num2 = 477312546;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x3FD25B7A)) % 9)
				{
				case 6u:
					break;
				case 2u:
					return 1;
				case 7u:
				{
					Delegate[] paramsObject = LuaScriptMgr.GetParamsObject<Delegate>(L, 1, num);
					Delegate o2 = _206A_206B_206B_206A_206F_206E_206F_202C_206B_202B_200C_200C_206D_202D_206E_200B_206C_206C_206E_200E_200D_200B_200F_202B_202B_200E_200E_206F_206A_200E_206A_200D_200E_202E_200D_200E_206F_202A_202E_202A_202E(paramsObject);
					LuaScriptMgr.Push(L, o2);
					return 1;
				}
				case 1u:
				{
					Delegate o = _206D_202A_200D_202A_206F_206E_200D_202C_206C_206E_202E_202E_206A_202B_206B_206E_200F_200C_202E_206A_206F_206C_202E_206B_206D_200C_206E_200C_206B_200B_200C_202C_206B_206C_206F_200F_200F_200D_206F_206A_202E(obj, obj2);
					LuaScriptMgr.Push(L, o);
					num2 = (int)((num3 * 912510219) ^ 0x5CFCE60F);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3878797005u));
					num2 = 994128171;
					continue;
				case 4u:
					obj = (Delegate)LuaScriptMgr.GetNetObject(L, 1, _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(Delegate).TypeHandle));
					obj2 = (Delegate)LuaScriptMgr.GetNetObject(L, 2, _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(Delegate).TypeHandle));
					num2 = ((int)num3 * -51348716) ^ 0x6541B66;
					continue;
				case 0u:
				{
					int num6;
					if (!LuaScriptMgr.CheckParamsType(L, _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(Delegate).TypeHandle), 1, num))
					{
						num2 = 385592891;
						num6 = num2;
					}
					else
					{
						num2 = 343750285;
						num6 = num2;
					}
					continue;
				}
				case 3u:
				{
					int num4;
					int num5;
					if (num == 2)
					{
						num4 = -818148912;
						num5 = num4;
					}
					else
					{
						num4 = -807056386;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num3 * -1149948247);
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
	private static int Remove(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Delegate obj2 = default(Delegate);
		while (true)
		{
			int num = 1895401419;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x451CB712)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_0029;
				default:
				{
					Delegate obj = (Delegate)LuaScriptMgr.GetNetObject(L, 2, _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(Delegate).TypeHandle));
					Delegate o = _202A_206A_202A_202E_206C_206B_206D_202B_206D_200E_206B_200C_206B_200B_202D_200C_200D_202D_206F_200D_206A_202C_202D_206B_200C_202A_202E_200F_206F_202E_206A_206A_200C_200B_200B_206A_202B_200D_202B_200F_202E(obj2, obj);
					LuaScriptMgr.Push(L, o);
					return 1;
				}
				}
				break;
				IL_0029:
				obj2 = (Delegate)LuaScriptMgr.GetNetObject(L, 1, _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(Delegate).TypeHandle));
				num = ((int)num2 * -2145012389) ^ -195234701;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int RemoveAll(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Delegate obj = (Delegate)LuaScriptMgr.GetNetObject(L, 1, _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(Delegate).TypeHandle));
		Delegate obj2 = (Delegate)LuaScriptMgr.GetNetObject(L, 2, _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(Delegate).TypeHandle));
		while (true)
		{
			int num = 1530573466;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x425604B4)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_0057;
				default:
					return 1;
				}
				break;
				IL_0057:
				Delegate o = _200B_206A_200D_202B_206D_202C_202A_206E_206D_202E_206E_206C_200D_202C_206B_200C_202E_206E_206E_202B_202A_202D_200B_206A_200C_202C_202C_202A_202C_200E_200D_200B_202D_206C_202B_200F_206D_202B_202D_206E_202E(obj, obj2);
				LuaScriptMgr.Push(L, o);
				num = (int)((num2 * 504497989) ^ 0x57A1F01B);
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Lua_Sub(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Delegate obj2 = default(Delegate);
		Delegate obj = default(Delegate);
		while (true)
		{
			int num = 1150782684;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x55101DAF)) % 5)
				{
				case 0u:
					break;
				case 2u:
					obj2 = (Delegate)LuaScriptMgr.GetNetObject(L, 1, _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(Delegate).TypeHandle));
					num = ((int)num2 * -323615774) ^ 0x3C3D57FE;
					continue;
				case 1u:
				{
					Delegate o = _202A_206A_202A_202E_206C_206B_206D_202B_206D_200E_206B_200C_206B_200B_202D_200C_200D_202D_206F_200D_206A_202C_202D_206B_200C_202A_202E_200F_206F_202E_206A_206A_200C_200B_200B_206A_202B_200D_202B_200F_202E(obj2, obj);
					LuaScriptMgr.Push(L, o);
					num = (int)(num2 * 739131091) ^ -1347770744;
					continue;
				}
				case 3u:
					obj = (Delegate)LuaScriptMgr.GetNetObject(L, 2, _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(typeof(Delegate).TypeHandle));
					num = (int)(num2 * 264340219) ^ -917384069;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Lua_Add(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Delegate o = default(Delegate);
		Delegate obj2 = default(Delegate);
		Delegate obj3 = default(Delegate);
		LuaFunction luaFunction = default(LuaFunction);
		Delegate o2 = default(Delegate);
		Delegate obj = default(Delegate);
		while (true)
		{
			int num = -613248529;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -185884575)) % 11)
				{
				case 0u:
					break;
				case 5u:
					LuaScriptMgr.Push(L, o);
					num = (int)(num2 * 436750465) ^ -1595374398;
					continue;
				case 8u:
					obj2 = DelegateFactory.CreateDelegate(_202C_202D_206E_200E_200D_206F_206E_200F_202A_206B_202E_200F_202E_202A_200F_202B_206D_202C_202E_202B_202B_202D_200B_200D_200C_206A_200E_202C_206F_200C_200C_200D_206E_206F_200F_200C_200E_206A_206B_206B_202E((object)obj3), luaFunction);
					num = (int)(num2 * 65767199) ^ -470125588;
					continue;
				case 6u:
					o2 = _206D_202A_200D_202A_206F_206E_200D_202C_206C_206E_202E_202E_206A_202B_206B_206E_200F_200C_202E_206A_206F_206C_202E_206B_206D_200C_206E_200C_206B_200B_200C_202C_206B_206C_206F_200F_200F_200D_206F_206A_202E(obj3, obj);
					num = (int)(num2 * 753270354) ^ -960122009;
					continue;
				case 9u:
					obj3 = LuaScriptMgr.GetLuaObject(L, 1) as Delegate;
					num = (int)((num2 * 705555321) ^ 0x1A074F0F);
					continue;
				case 7u:
					LuaScriptMgr.Push(L, o2);
					return 1;
				case 4u:
					o = _206D_202A_200D_202A_206F_206E_200D_202C_206C_206E_202E_202E_206A_202B_206B_206E_200F_200C_202E_206A_206F_206C_202E_206B_206D_200C_206E_200C_206B_200B_200C_202C_206B_206C_206F_200F_200F_200D_206F_206A_202E(obj3, obj2);
					num = ((int)num2 * -206975484) ^ 0x795FB427;
					continue;
				case 1u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 2);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TFUNCTION)
					{
						num3 = 758102325;
						num4 = num3;
					}
					else
					{
						num3 = 2031590861;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 762588538);
					continue;
				}
				case 2u:
					luaFunction = LuaScriptMgr.GetLuaFunction(L, 2);
					num = -819776973;
					continue;
				case 3u:
					obj = LuaScriptMgr.GetLuaObject(L, 2) as Delegate;
					num = (int)(num2 * 784269559) ^ -2066732138;
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
		Delegate obj = LuaScriptMgr.GetLuaObject(L, 1) as Delegate;
		Delegate obj2 = LuaScriptMgr.GetLuaObject(L, 2) as Delegate;
		bool b = _202A_202E_200D_206F_200E_202E_202E_202B_206F_202B_206E_200C_200D_206B_202A_202B_206C_202D_200C_202C_206F_202A_206C_202D_206C_206D_202B_206F_200B_202E_206D_202D_200B_200D_202B_200F_202C_200B_202B_202E_202E(obj, obj2);
		LuaScriptMgr.Push(L, b);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetHashCode(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Delegate obj = (Delegate)LuaScriptMgr.GetNetObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2328103337u));
		int d = _200B_202B_200D_200F_200D_206B_200F_206E_200E_206B_206D_206C_202E_202E_200C_200F_202B_202A_206F_202A_200D_206F_200F_206A_202C_202E_200F_202C_202A_206F_206D_202B_202E_206B_206D_200B_202E_200D_202D_200D_202E(obj);
		LuaScriptMgr.Push(L, d);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Equals(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Delegate obj = LuaScriptMgr.GetVarObject(L, 1) as Delegate;
		object varObject = LuaScriptMgr.GetVarObject(L, 2);
		bool b = default(bool);
		while (true)
		{
			int num = -1508969138;
			while (true)
			{
				uint num2;
				bool num3;
				switch ((num2 = (uint)(num ^ -1747617368)) % 5)
				{
				case 2u:
					break;
				case 3u:
					if ((object)obj != null)
					{
						num = (int)((num2 * 82661470) ^ 0x26C4127);
						continue;
					}
					num3 = varObject == null;
					goto IL_0065;
				case 4u:
					num3 = _206B_202E_200D_206F_206A_206E_206E_206C_206F_206D_202E_200C_202D_200C_200C_206A_202D_206F_206E_200C_206C_206D_200D_200F_206B_202D_200C_206F_200C_200D_202D_206F_206A_200C_206B_200D_206F_200C_206A_200E_202E(obj, varObject);
					goto IL_0065;
				case 1u:
					LuaScriptMgr.Push(L, b);
					num = ((int)num2 * -779229031) ^ -1338323104;
					continue;
				default:
					{
						return 1;
					}
					IL_0065:
					b = num3;
					num = -1283768002;
					continue;
				}
				break;
			}
		}
	}

	static Type _200F_206A_206E_202E_206D_202E_202C_206A_200D_200B_206B_200F_206A_206E_206C_206B_202E_206D_202A_202A_206B_202B_202A_200E_206B_200B_202D_206D_200D_206F_206A_200F_200D_200D_206F_202B_206E_202C_202E_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static MethodInfo _206C_206E_200E_206B_202B_200C_206F_206D_202A_202D_202B_206F_202C_200D_206C_206F_206F_200E_202D_206A_206C_202C_206F_202A_206F_206E_202E_202B_206A_206C_200E_200C_202E_200F_202D_202B_202E_202A_206F_200D_202E(Delegate P_0)
	{
		return P_0.Method;
	}

	static object _206E_200E_202D_206C_200B_200E_200E_200D_206B_206E_202B_200D_200C_206C_202C_202C_202B_200E_200E_206F_206D_202A_202A_202E_206D_206F_202D_200C_200E_206D_200C_200C_206B_202B_206F_202A_202E_202D_206F_202E_202E(Delegate P_0)
	{
		return P_0.Target;
	}

	static Delegate _202B_200C_206C_206D_206E_202D_202B_206B_206C_200D_202B_200D_200C_206C_200F_206E_206B_202D_202C_202B_200B_206E_206D_206A_200C_200B_206C_202C_200E_202E_202B_206B_202C_200F_202C_206A_206A_202B_202C_202E(Type P_0, MethodInfo P_1)
	{
		return Delegate.CreateDelegate(P_0, P_1);
	}

	static Delegate _206B_206C_206E_200F_200B_202C_206F_202E_206C_206E_206C_206C_202C_202D_206E_202E_206E_202E_200D_200B_206E_200F_206B_200F_206B_200E_206B_202A_200D_200D_200E_202A_206B_200F_200F_202D_202B_200D_202D_202E_202E(Type P_0, MethodInfo P_1, bool P_2)
	{
		return Delegate.CreateDelegate(P_0, P_1, P_2);
	}

	static Delegate _206F_202C_206A_200E_206A_206B_206A_200F_206A_200E_202C_206F_206F_206C_206B_200E_200B_206B_200E_206C_200F_200B_202E_206F_202B_200B_206B_200C_200B_200E_206A_202A_200D_206A_200B_206B_200B_200F_202D_202D_202E(Type P_0, Type P_1, string P_2)
	{
		return Delegate.CreateDelegate(P_0, P_1, P_2);
	}

	static Delegate _206A_206E_202A_202A_206C_206A_202D_206D_200E_200C_200F_206C_202B_206A_200B_200C_202B_206C_202A_202E_200C_206A_206D_200F_200F_200C_200C_206C_202B_206C_202A_200C_202E_202B_206F_202B_202D_202A_206C_200C_202E(Type P_0, object P_1, string P_2)
	{
		return Delegate.CreateDelegate(P_0, P_1, P_2);
	}

	static Delegate _206B_200E_206C_206B_206F_206B_206C_200E_200B_206E_202B_200F_206D_206D_202B_202B_202E_200F_202C_200F_202C_202A_206C_206D_206B_206A_206F_200C_200D_202A_206D_206D_200F_206A_202A_206F_200F_200C_200F_206B_202E(Type P_0, object P_1, MethodInfo P_2)
	{
		return Delegate.CreateDelegate(P_0, P_1, P_2);
	}

	static Delegate _202C_200D_200B_200F_202B_206D_200B_200B_200C_206D_206C_200F_206F_200D_202C_202E_206F_206A_206D_206A_202B_206E_202A_202B_206E_206E_206B_206E_200F_206D_200D_206D_200D_206D_202E_206F_200B_206B_200C_206F_202E(Type P_0, Type P_1, string P_2, bool P_3)
	{
		return Delegate.CreateDelegate(P_0, P_1, P_2, P_3);
	}

	static Delegate _200B_200C_202E_206F_206F_202E_202D_206F_206E_200F_202B_202E_200C_200D_206C_200C_202A_206B_206F_206F_206B_206E_200D_206C_202C_206A_206B_200B_202B_200E_200D_206A_206F_206A_206F_200D_200F_200E_202B_202A_202E(Type P_0, object P_1, string P_2, bool P_3)
	{
		return Delegate.CreateDelegate(P_0, P_1, P_2, P_3);
	}

	static Delegate _202C_202C_206A_206F_200E_202D_206F_206E_200B_206B_200B_206D_202A_206D_206E_200B_202E_206C_206C_200F_200E_200B_206B_200F_200C_206C_202E_206B_206B_200C_206C_206A_200C_206F_206B_202E_202A_200E_206E_202E(Type P_0, object P_1, MethodInfo P_2, bool P_3)
	{
		return Delegate.CreateDelegate(P_0, P_1, P_2, P_3);
	}

	static Delegate _200E_200E_202B_202C_206A_206A_202B_200B_206B_200C_206A_202B_200E_200B_206E_200C_206A_200F_200C_206C_206B_206E_206A_200C_206E_202E_206E_202C_200D_202D_200D_202D_200D_206F_200B_200D_202C_206A_200F_206F_202E(Type P_0, Type P_1, string P_2, bool P_3, bool P_4)
	{
		return Delegate.CreateDelegate(P_0, P_1, P_2, P_3, P_4);
	}

	static Delegate _206D_206C_206C_206C_206E_200D_202E_200F_206F_200B_202B_200C_202C_200E_202B_200B_206D_202E_206D_206B_202A_206D_206B_206A_200E_206F_202C_200E_202E_202E_206C_206E_206B_202A_202B_202B_206B_202D_206A_200D_202E(Type P_0, object P_1, string P_2, bool P_3, bool P_4)
	{
		return Delegate.CreateDelegate(P_0, P_1, P_2, P_3, P_4);
	}

	static object _206A_206D_206D_206A_200F_206F_206C_206D_200E_200C_200D_200F_206D_206C_206E_200B_206B_206A_206C_206C_200E_200F_200D_206D_206F_202D_200D_200D_200B_200B_200E_202E_206B_206B_206C_206B_200C_200B_202B_202A_202E(Delegate P_0, object[] P_1)
	{
		return P_0.DynamicInvoke(P_1);
	}

	static object _202B_202B_206C_206D_206D_200F_200F_200F_206D_200D_200C_206D_202C_200D_206B_202B_200B_206C_202A_202D_202D_202C_202A_202A_206D_200D_202D_200E_200D_206E_206A_206C_206C_206F_200E_206F_206A_202B_202B_206F_202E(Delegate P_0)
	{
		return P_0.Clone();
	}

	static void _202C_202D_206D_202E_206F_206B_202C_202C_200C_202E_200D_206D_200E_202B_206F_202C_206C_202A_206D_200B_206C_200E_206A_206C_202C_206C_202C_206A_206A_202E_202D_206C_202A_202B_200E_202A_202B_202A_200B_206C_202E(Delegate P_0, SerializationInfo P_1, StreamingContext P_2)
	{
		P_0.GetObjectData(P_1, P_2);
	}

	static Delegate[] _202A_206E_202B_200D_200D_202E_206D_200D_206C_206B_206C_202A_206E_206B_202B_206F_202C_206F_202E_200D_200E_200D_202E_206A_202C_202D_200B_206D_206C_200C_200F_202C_200B_200C_206A_206B_206B_206E_202C_202E_202E(Delegate P_0)
	{
		return P_0.GetInvocationList();
	}

	static Delegate _206D_202A_200D_202A_206F_206E_200D_202C_206C_206E_202E_202E_206A_202B_206B_206E_200F_200C_202E_206A_206F_206C_202E_206B_206D_200C_206E_200C_206B_200B_200C_202C_206B_206C_206F_200F_200F_200D_206F_206A_202E(Delegate P_0, Delegate P_1)
	{
		return Delegate.Combine(P_0, P_1);
	}

	static Delegate _206A_206B_206B_206A_206F_206E_206F_202C_206B_202B_200C_200C_206D_202D_206E_200B_206C_206C_206E_200E_200D_200B_200F_202B_202B_200E_200E_206F_206A_200E_206A_200D_200E_202E_200D_200E_206F_202A_202E_202A_202E(Delegate[] P_0)
	{
		return Delegate.Combine(P_0);
	}

	static Delegate _202A_206A_202A_202E_206C_206B_206D_202B_206D_200E_206B_200C_206B_200B_202D_200C_200D_202D_206F_200D_206A_202C_202D_206B_200C_202A_202E_200F_206F_202E_206A_206A_200C_200B_200B_206A_202B_200D_202B_200F_202E(Delegate P_0, Delegate P_1)
	{
		return Delegate.Remove(P_0, P_1);
	}

	static Delegate _200B_206A_200D_202B_206D_202C_202A_206E_206D_202E_206E_206C_200D_202C_206B_200C_202E_206E_206E_202B_202A_202D_200B_206A_200C_202C_202C_202A_202C_200E_200D_200B_202D_206C_202B_200F_206D_202B_202D_206E_202E(Delegate P_0, Delegate P_1)
	{
		return Delegate.RemoveAll(P_0, P_1);
	}

	static Type _202C_202D_206E_200E_200D_206F_206E_200F_202A_206B_202E_200F_202E_202A_200F_202B_206D_202C_202E_202B_202B_202D_200B_200D_200C_206A_200E_202C_206F_200C_200C_200D_206E_206F_200F_200C_200E_206A_206B_206B_202E(object P_0)
	{
		return P_0.GetType();
	}

	static bool _202A_202E_200D_206F_200E_202E_202E_202B_206F_202B_206E_200C_200D_206B_202A_202B_206C_202D_200C_202C_206F_202A_206C_202D_206C_206D_202B_206F_200B_202E_206D_202D_200B_200D_202B_200F_202C_200B_202B_202E_202E(Delegate P_0, Delegate P_1)
	{
		return P_0 == P_1;
	}

	static int _200B_202B_200D_200F_200D_206B_200F_206E_200E_206B_206D_206C_202E_202E_200C_200F_202B_202A_206F_202A_200D_206F_200F_206A_202C_202E_200F_202C_202A_206F_206D_202B_202E_206B_206D_200B_202E_200D_202D_200D_202E(Delegate P_0)
	{
		return P_0.GetHashCode();
	}

	static bool _206B_202E_200D_206F_206A_206E_206E_206C_206F_206D_202E_200C_202D_200C_200C_206A_202D_206F_206E_200C_206C_206D_200D_200F_206B_202D_200C_206F_200C_200D_202D_206F_206A_200C_206B_200D_206F_200C_206A_200E_202E(Delegate P_0, object P_1)
	{
		return P_0.Equals(P_1);
	}
}
