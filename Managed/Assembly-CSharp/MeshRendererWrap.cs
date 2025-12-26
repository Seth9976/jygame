using System;
using LuaInterface;
using UnityEngine;

public class MeshRendererWrap
{
	private static Type classType = _202B_206A_202C_200B_200C_202B_202A_202E_206C_206F_202A_206B_206B_206E_200E_200B_202C_200B_200E_200D_200E_202A_202A_206E_206D_202E_202D_206E_202E_200F_202E_206E_200D_206B_200E_202C_206D_202A_202B_206B_202E(typeof(MeshRenderer).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[3]
		{
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2254933974u), _202E_206C_206A_202E_202C_202B_206F_200C_200D_202A_206F_200E_200C_202B_206D_200F_202E_206A_206D_200C_200F_206F_206F_200D_206C_206A_206E_206F_202B_200F_206B_206A_200E_200E_202D_206C_202C_206F_200B_200D_202E),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(215375861u), GetClassType),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3747390401u), Lua_Eq)
		};
		while (true)
		{
			int num = -1789800619;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1940524421)) % 3)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_009e;
				case 0u:
					return;
				}
				break;
				IL_009e:
				LuaField[] fields = new LuaField[1]
				{
					new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(562859104u), get_additionalVertexStreams, set_additionalVertexStreams)
				};
				LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4261460901u), _202B_206A_202C_200B_200C_202B_202A_202E_206C_206F_202A_206B_206B_206E_200E_200B_202C_200B_200E_200D_200E_202A_202A_206E_206D_202E_202D_206E_202E_200F_202E_206E_200D_206B_200E_202C_206D_202A_202B_206B_202E(typeof(MeshRenderer).TypeHandle), regs, fields, _202B_206A_202C_200B_200C_202B_202A_202E_206C_206F_202A_206B_206B_206E_200E_200B_202C_200B_200E_200D_200E_202A_202A_206E_206D_202E_202D_206E_202E_200F_202E_206E_200D_206B_200E_202C_206D_202A_202B_206B_202E(typeof(Renderer).TypeHandle));
				num = ((int)num2 * -1398266494) ^ -1669949364;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _202E_206C_206A_202E_202C_202B_206F_200C_200D_202A_206F_200E_200C_202B_206D_200F_202E_206A_206D_200C_200F_206F_206F_200D_206C_206A_206E_206F_202B_200F_206B_206A_200E_200E_202D_206C_202C_206F_200B_200D_202E(IntPtr P_0)
	{
		int num = LuaDLL.lua_gettop(P_0);
		MeshRenderer obj = default(MeshRenderer);
		while (true)
		{
			int num2 = 2131224728;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x1EC5F185)) % 7)
				{
				case 3u:
					break;
				case 5u:
				{
					int num4;
					int num5;
					if (num != 0)
					{
						num4 = 534181380;
						num5 = num4;
					}
					else
					{
						num4 = 91729829;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num3 * -2073866780);
					continue;
				}
				case 0u:
					return 1;
				case 6u:
					obj = _202D_200E_202B_200F_206D_200C_206E_206F_206C_202B_200E_200B_200F_206D_202E_200F_206D_206B_206D_202A_200B_206A_200B_200C_202B_200D_200B_206A_200B_202D_202A_200B_200D_200C_200B_202A_200B_202C_206F_200D_202E();
					num2 = (int)(num3 * 2139028546) ^ -1737276001;
					continue;
				case 2u:
					LuaDLL.luaL_error(P_0, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2730068413u));
					num2 = 858375861;
					continue;
				case 4u:
					LuaScriptMgr.Push(P_0, (Object)(object)obj);
					num2 = (int)(num3 * 696037751) ^ -478250351;
					continue;
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
	private static int get_additionalVertexStreams(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		MeshRenderer val = (MeshRenderer)luaObject;
		while (true)
		{
			int num = -1696418086;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1416670496)) % 8)
				{
				case 5u:
					break;
				case 7u:
					LuaScriptMgr.Push(L, (Object)(object)_200D_206C_200B_202A_206A_202C_200B_206F_202E_202B_202E_202D_206D_206E_200C_206C_202D_202D_200E_200F_200B_200C_200E_206D_206C_202D_202E_202D_200B_200B_200F_202A_206D_206F_202D_200F_206E_200D_206A_200E_202E(val));
					num = -2112905162;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(989272857u));
					num = (int)(num2 * 1428533243) ^ -590101269;
					continue;
				case 3u:
					num = (int)((num2 * 1829823697) ^ 0x3D8E95FC);
					continue;
				case 1u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -2060523178;
						num6 = num5;
					}
					else
					{
						num5 = -1516716334;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1664651246);
					continue;
				}
				case 2u:
				{
					int num3;
					int num4;
					if (!_202B_202E_202C_200C_202B_200B_200C_206B_202A_206B_200B_200E_206B_206D_200E_200B_200B_206D_200F_200C_202D_202B_200D_206F_206D_200B_206D_202B_200E_202B_206C_206C_200C_206F_200E_206B_200D_206D_200C_206A_202E((Object)(object)val, (Object)null))
					{
						num3 = -1661747813;
						num4 = num3;
					}
					else
					{
						num3 = -1046270611;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -509305178);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3715476081u));
					num = -1816759289;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_additionalVertexStreams(IntPtr L)
	{
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		MeshRenderer val = default(MeshRenderer);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 2086738749;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7DDCB6A7)) % 10)
				{
				case 3u:
					break;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2094386280u));
					num = (int)(num2 * 2085713886) ^ -437443990;
					continue;
				case 8u:
					_202A_206E_202B_206D_200E_200F_206C_200C_206E_200B_200B_200B_206A_200E_206A_206F_206D_206E_200B_200C_200E_200F_206F_206F_206F_206B_202E_200D_202A_202B_200E_202D_202D_206B_202C_206E_202A_200F_206B_206A_202E(val, (Mesh)LuaScriptMgr.GetUnityObject(L, 3, _202B_206A_202C_200B_200C_202B_202A_202E_206C_206F_202A_206B_206B_206E_200E_200B_202C_200B_200E_200D_200E_202A_202A_206E_206D_202E_202D_206E_202E_200F_202E_206E_200D_206B_200E_202C_206D_202A_202B_206B_202E(typeof(Mesh).TypeHandle)));
					num = 126525275;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (_202B_202E_202C_200C_202B_200B_200C_206B_202A_206B_200B_200E_206B_206D_200E_200B_200B_206D_200F_200C_202D_202B_200D_206F_206D_200B_206D_202B_200E_202B_206C_206C_200C_206F_200E_206B_200D_206D_200C_206A_202E((Object)(object)val, (Object)null))
					{
						num5 = 835771797;
						num6 = num5;
					}
					else
					{
						num5 = 1897245371;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 130760856);
					continue;
				}
				case 9u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3567657952u));
					num = 256821603;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 297515352;
						num4 = num3;
					}
					else
					{
						num3 = 1160921674;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 667518262);
					continue;
				}
				case 2u:
					val = (MeshRenderer)luaObject;
					num = ((int)num2 * -1882680452) ^ 0x174374C6;
					continue;
				case 1u:
					num = (int)((num2 * 417600550) ^ 0x5AA9F771);
					continue;
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 560453452) ^ -1002434779;
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
		Object val2 = default(Object);
		while (true)
		{
			int num = 981799346;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2D60BFC0)) % 4)
				{
				case 0u:
					break;
				case 2u:
				{
					object luaObject2 = LuaScriptMgr.GetLuaObject(L, 1);
					val2 = (Object)((luaObject2 is Object) ? luaObject2 : null);
					num = ((int)num2 * -690178459) ^ -446266677;
					continue;
				}
				case 1u:
				{
					object luaObject = LuaScriptMgr.GetLuaObject(L, 2);
					Object val = (Object)((luaObject is Object) ? luaObject : null);
					bool b = _202B_202E_202C_200C_202B_200B_200C_206B_202A_206B_200B_200E_206B_206D_200E_200B_200B_206D_200F_200C_202D_202B_200D_206F_206D_200B_206D_202B_200E_202B_206C_206C_200C_206F_200E_206B_200D_206D_200C_206A_202E(val2, val);
					LuaScriptMgr.Push(L, b);
					num = ((int)num2 * -862947193) ^ -1101253768;
					continue;
				}
				default:
					return 1;
				}
				break;
			}
		}
	}

	static Type _202B_206A_202C_200B_200C_202B_202A_202E_206C_206F_202A_206B_206B_206E_200E_200B_202C_200B_200E_200D_200E_202A_202A_206E_206D_202E_202D_206E_202E_200F_202E_206E_200D_206B_200E_202C_206D_202A_202B_206B_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static MeshRenderer _202D_200E_202B_200F_206D_200C_206E_206F_206C_202B_200E_200B_200F_206D_202E_200F_206D_206B_206D_202A_200B_206A_200B_200C_202B_200D_200B_206A_200B_202D_202A_200B_200D_200C_200B_202A_200B_202C_206F_200D_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new MeshRenderer();
	}

	static bool _202B_202E_202C_200C_202B_200B_200C_206B_202A_206B_200B_200E_206B_206D_200E_200B_200B_206D_200F_200C_202D_202B_200D_206F_206D_200B_206D_202B_200E_202B_206C_206C_200C_206F_200E_206B_200D_206D_200C_206A_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static Mesh _200D_206C_200B_202A_206A_202C_200B_206F_202E_202B_202E_202D_206D_206E_200C_206C_202D_202D_200E_200F_200B_200C_200E_206D_206C_202D_202E_202D_200B_200B_200F_202A_206D_206F_202D_200F_206E_200D_206A_200E_202E(MeshRenderer P_0)
	{
		return P_0.additionalVertexStreams;
	}

	static void _202A_206E_202B_206D_200E_200F_206C_200C_206E_200B_200B_200B_206A_200E_206A_206F_206D_206E_200B_200C_200E_200F_206F_206F_206F_206B_202E_200D_202A_202B_200E_202D_202D_206B_202C_206E_202A_200F_206B_206A_202E(MeshRenderer P_0, Mesh P_1)
	{
		P_0.additionalVertexStreams = P_1;
	}
}
