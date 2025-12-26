using System;
using LuaInterface;
using UnityEngine;

public class SkinnedMeshRendererWrap
{
	private static Type classType = _202A_200E_202A_202D_200B_202D_206C_206D_206F_206C_200D_202B_202E_206E_200F_206B_202C_202A_202E_200B_200B_206B_206E_202D_202C_206C_206E_202A_206A_206C_200F_200E_200E_206C_206C_200F_200F_200D_200B_200D_202E(typeof(SkinnedMeshRenderer).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[6]
		{
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2061796315u), BakeMesh),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2099531808u), GetBlendShapeWeight),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(542091066u), SetBlendShapeWeight),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1657282774u), _206A_206C_200B_202B_200C_202A_200D_202D_202C_200E_202E_200C_206D_202D_202E_206F_202E_206C_206F_200C_200F_202C_206E_206C_202D_202D_206C_206E_200F_206F_206F_202C_200F_202D_202A_200E_202B_206E_200B_200C_202E),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2783592835u), GetClassType),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(396454614u), Lua_Eq)
		};
		LuaField[] fields = new LuaField[6]
		{
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2250473780u), get_bones, set_bones),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2288209273u), get_rootBone, set_rootBone),
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1157593469u), get_quality, set_quality),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(236085135u), get_sharedMesh, set_sharedMesh),
			new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2101516158u), get_updateWhenOffscreen, set_updateWhenOffscreen),
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(339286507u), get_localBounds, set_localBounds)
		};
		LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1325321791u), _202A_200E_202A_202D_200B_202D_206C_206D_206F_206C_200D_202B_202E_206E_200F_206B_202C_202A_202E_200B_200B_206B_206E_202D_202C_206C_206E_202A_206A_206C_200F_200E_200E_206C_206C_200F_200F_200D_200B_200D_202E(typeof(SkinnedMeshRenderer).TypeHandle), regs, fields, _202A_200E_202A_202D_200B_202D_206C_206D_206F_206C_200D_202B_202E_206E_200F_206B_202C_202A_202E_200B_200B_206B_206E_202D_202C_206C_206E_202A_206A_206C_200F_200E_200E_206C_206C_200F_200F_200D_200B_200D_202E(typeof(Renderer).TypeHandle));
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _206A_206C_200B_202B_200C_202A_200D_202D_202C_200E_202E_200C_206D_202D_202E_206F_202E_206C_206F_200C_200F_202C_206E_206C_202D_202D_206C_206E_200F_206F_206F_202C_200F_202D_202A_200E_202B_206E_200B_200C_202E(IntPtr P_0)
	{
		int num = LuaDLL.lua_gettop(P_0);
		while (true)
		{
			int num2 = 1038244922;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x9F1FC62)) % 6)
				{
				case 0u:
					break;
				case 5u:
					LuaDLL.luaL_error(P_0, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(884332854u));
					num2 = 602886975;
					continue;
				case 3u:
				{
					SkinnedMeshRenderer obj = _202D_200F_206C_200B_200C_202C_202A_200D_202D_206C_200E_200B_202D_206F_206C_206D_206A_206F_202C_202E_200B_202C_206F_200D_206F_206E_202C_206B_200B_206C_200F_202A_206F_200B_206F_202E_200E_206C_206E_200C_202E();
					LuaScriptMgr.Push(P_0, (Object)(object)obj);
					num2 = (int)(num3 * 953481051) ^ -876643055;
					continue;
				}
				case 4u:
				{
					int num4;
					int num5;
					if (num != 0)
					{
						num4 = -422932501;
						num5 = num4;
					}
					else
					{
						num4 = -1991780069;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 1922582641);
					continue;
				}
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
	private static int get_bones(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		SkinnedMeshRenderer val = (SkinnedMeshRenderer)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -345190445;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -436532716)) % 7)
				{
				case 4u:
					break;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(902281561u));
					num = (int)(num2 * 441452108) ^ -84853870;
					continue;
				case 5u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 613770621) ^ 0x49AA5A9A);
					continue;
				case 0u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -1835566179;
						num6 = num5;
					}
					else
					{
						num5 = -739168917;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1467377127);
					continue;
				}
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2233309345u));
					num = -1108214022;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (_202C_206D_206F_206A_206B_200C_206B_202D_206D_206E_206B_202C_202D_206A_202A_202D_202A_200C_200E_202C_206C_200D_200B_206C_200C_206F_202C_200D_202C_202B_206E_206C_200D_202A_200B_200C_206F_202D_202D_206F_202E((Object)(object)val, (Object)null))
					{
						num3 = -1378037330;
						num4 = num3;
					}
					else
					{
						num3 = -614183603;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -975969647);
					continue;
				}
				default:
					LuaScriptMgr.PushArray(L, _200B_206C_200E_202A_206B_200F_200C_206B_206F_206F_200B_200E_206F_206A_202E_206E_200C_200B_200B_200F_200E_202A_200B_206D_200E_206E_200C_202D_200B_206E_202B_206D_202C_206E_206E_202A_202C_206A_206D_200F_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_rootBone(IntPtr L)
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		SkinnedMeshRenderer val = default(SkinnedMeshRenderer);
		while (true)
		{
			int num = 1368292106;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x308DA3AB)) % 8)
				{
				case 0u:
					break;
				case 6u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 1829923876;
						num6 = num5;
					}
					else
					{
						num5 = 1480027624;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1851248632);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1272737766u));
					num = 166322831;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(940017054u));
					num = (int)((num2 * 1436016429) ^ 0x6F546CB5);
					continue;
				case 1u:
					val = (SkinnedMeshRenderer)luaObject;
					num = ((int)num2 * -2007249418) ^ -1449195529;
					continue;
				case 5u:
					num = ((int)num2 * -1377569226) ^ -502821455;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!_202C_206D_206F_206A_206B_200C_206B_202D_206D_206E_206B_202C_202D_206A_202A_202D_202A_200C_200E_202C_206C_200D_200B_206C_200C_206F_202C_200D_202C_202B_206E_206C_200D_202A_200B_200C_206F_202D_202D_206F_202E((Object)(object)val, (Object)null))
					{
						num3 = 1721243951;
						num4 = num3;
					}
					else
					{
						num3 = 523023429;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -728083312);
					continue;
				}
				default:
					LuaScriptMgr.Push(L, (Object)(object)_202C_200E_200E_202C_202D_200C_206B_202C_206D_200E_200D_206D_206D_202A_206F_202A_200E_202A_202D_206C_200B_206A_200C_202E_200F_206A_206E_202D_202A_206B_202E_206E_200B_200B_206F_200C_200D_202B_206E_200C_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_quality(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		SkinnedMeshRenderer val = (SkinnedMeshRenderer)luaObject;
		if (_202C_206D_206F_206A_206B_200C_206B_202D_206D_206E_206B_202C_202D_206A_202A_202D_202A_200C_200E_202C_206C_200D_200B_206C_200C_206F_202C_200D_202C_202B_206E_206C_200D_202A_200B_200C_206F_202D_202D_206F_202E((Object)(object)val, (Object)null))
		{
			goto IL_001b;
		}
		goto IL_00d6;
		IL_001b:
		int num = -455814341;
		goto IL_0020;
		IL_0020:
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1399609977)) % 8)
			{
			case 5u:
				break;
			case 3u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2912548219u));
				num = -1487494640;
				continue;
			case 0u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2610664275u));
				num = (int)((num2 * 343845701) ^ 0x66C4614D);
				continue;
			case 1u:
			{
				int num3;
				int num4;
				if (luaTypes == LuaTypes.LUA_TTABLE)
				{
					num3 = -463346373;
					num4 = num3;
				}
				else
				{
					num3 = -1185852624;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 746691356);
				continue;
			}
			case 4u:
				luaTypes = LuaDLL.lua_type(L, 1);
				num = ((int)num2 * -1728351768) ^ -616245650;
				continue;
			case 2u:
				num = ((int)num2 * -1764971590) ^ -186799020;
				continue;
			case 7u:
				goto IL_00d6;
			default:
				return 1;
			}
			break;
		}
		goto IL_001b;
		IL_00d6:
		LuaScriptMgr.Push(L, (Enum)(object)_206D_200C_200E_200D_206D_206A_206A_200F_206D_200D_202B_206D_202A_202C_200C_206C_206B_200B_206F_206F_206A_206C_202A_202C_206E_200D_200B_202A_202D_202C_202D_202A_206E_206C_206D_200F_202A_206F_202E_206A_202E(val));
		num = -1900592207;
		goto IL_0020;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_sharedMesh(IntPtr L)
	{
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		SkinnedMeshRenderer val = default(SkinnedMeshRenderer);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1335099637;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -949835231)) % 9)
				{
				case 7u:
					break;
				case 5u:
					LuaScriptMgr.Push(L, (Object)(object)_206E_200E_206E_206F_202E_202B_200B_206F_200E_202A_206B_200E_202E_200B_200B_206E_206D_200E_200B_206D_206E_202A_206A_200B_202E_200C_200B_206D_206D_200C_202B_206B_206F_206F_200D_202D_206C_202E_202C_202E(val));
					num = -766126012;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2769953974u));
					num = -396728240;
					continue;
				case 8u:
					num = (int)(num2 * 311920166) ^ -1187196120;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2992697556u));
					num = (int)((num2 * 721007343) ^ 0x31966BEA);
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -1916985170;
						num6 = num5;
					}
					else
					{
						num5 = -300745993;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 962410254);
					continue;
				}
				case 1u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -594911460) ^ 0x1EC8B7E4;
					continue;
				case 6u:
				{
					val = (SkinnedMeshRenderer)luaObject;
					int num3;
					int num4;
					if (_202C_206D_206F_206A_206B_200C_206B_202D_206D_206E_206B_202C_202D_206A_202A_202D_202A_200C_200E_202C_206C_200D_200B_206C_200C_206F_202C_200D_202C_202B_206E_206C_200D_202A_200B_200C_206F_202D_202D_206F_202E((Object)(object)val, (Object)null))
					{
						num3 = -2137586714;
						num4 = num3;
					}
					else
					{
						num3 = -1580817210;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1075219105);
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
	private static int get_updateWhenOffscreen(IntPtr L)
	{
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		SkinnedMeshRenderer val = default(SkinnedMeshRenderer);
		while (true)
		{
			int num = 683572598;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x40B54079)) % 10)
				{
				case 3u:
					break;
				case 4u:
					num = (int)(num2 * 99156590) ^ -1463875618;
					continue;
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3250515865u));
					num = ((int)num2 * -1129023288) ^ -2120576263;
					continue;
				case 9u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2988019205u));
					num = 944213086;
					continue;
				case 2u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 1914828303) ^ 0x75ED2DAD);
					continue;
				case 5u:
					LuaScriptMgr.Push(L, _200E_206B_200C_206C_206B_200D_202C_202D_206F_206D_200E_202D_200B_200E_200C_206F_200F_200B_202A_202E_202D_202B_206A_200B_200F_200F_206C_206E_206C_206E_200C_202E_206B_206C_206E_202E_200E_202C_202D_200C_202E(val));
					num = 8899179;
					continue;
				case 1u:
					val = (SkinnedMeshRenderer)luaObject;
					num = ((int)num2 * -820538222) ^ 0x163A34C4;
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -261407190;
						num6 = num5;
					}
					else
					{
						num5 = -36388601;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1124782457);
					continue;
				}
				case 7u:
				{
					int num3;
					int num4;
					if (!_202C_206D_206F_206A_206B_200C_206B_202D_206D_206E_206B_202C_202D_206A_202A_202D_202A_200C_200E_202C_206C_200D_200B_206C_200C_206F_202C_200D_202C_202B_206E_206C_200D_202A_200B_200C_206F_202D_202D_206F_202E((Object)(object)val, (Object)null))
					{
						num3 = -1139280190;
						num4 = num3;
					}
					else
					{
						num3 = -1416113413;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1780758260);
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
	private static int get_localBounds(IntPtr L)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		SkinnedMeshRenderer val = default(SkinnedMeshRenderer);
		while (true)
		{
			int num = 1190952919;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x43765674)) % 10)
				{
				case 0u:
					break;
				case 5u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 2108604887) ^ 0x3436044D);
					continue;
				case 9u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2582098091u));
					num = 1939248166;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -884256685;
						num6 = num5;
					}
					else
					{
						num5 = -1106052604;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 2147315337);
					continue;
				}
				case 7u:
					val = (SkinnedMeshRenderer)luaObject;
					num = ((int)num2 * -1673995331) ^ -1623433954;
					continue;
				case 3u:
					num = (int)(num2 * 61833362) ^ -615427156;
					continue;
				case 8u:
					LuaScriptMgr.Push(L, _206B_200E_206E_200D_202B_200C_206D_206D_200B_206F_200D_206D_202A_202A_206B_206A_202C_206E_200D_206F_202E_206A_206D_206D_200F_202B_202C_206B_206E_206C_206E_202C_202B_200B_202D_206E_206D_200D_202A_202B_202E(val));
					num = 836931582;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!_202C_206D_206F_206A_206B_200C_206B_202D_206D_206E_206B_202C_202D_206A_202A_202D_202A_200C_200E_202C_206C_200D_200B_206C_200C_206F_202C_200D_202C_202B_206E_206C_200D_202A_200B_200C_206F_202D_202D_206F_202E((Object)(object)val, (Object)null))
					{
						num3 = 276050191;
						num4 = num3;
					}
					else
					{
						num3 = 1958114776;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1092979107);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2268223642u));
					num = ((int)num2 * -1382862647) ^ -2033306733;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_bones(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		SkinnedMeshRenderer val = (SkinnedMeshRenderer)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1747391748;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x35ECDB9)) % 8)
				{
				case 0u:
					break;
				case 5u:
				{
					int num5;
					int num6;
					if (_202C_206D_206F_206A_206B_200C_206B_202D_206D_206E_206B_202C_202D_206A_202A_202D_202A_200C_200E_202C_206C_200D_200B_206C_200C_206F_202C_200D_202C_202B_206E_206C_200D_202A_200B_200C_206F_202D_202D_206F_202E((Object)(object)val, (Object)null))
					{
						num5 = 2119140983;
						num6 = num5;
					}
					else
					{
						num5 = 735965089;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -8918243);
					continue;
				}
				case 7u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 1657387046) ^ 0x2F804588);
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(902281561u));
					num = (int)((num2 * 968512570) ^ 0x34277E79);
					continue;
				case 4u:
					num = ((int)num2 * -166305791) ^ -1041868268;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2401543632u));
					num = 574874568;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -184288747;
						num4 = num3;
					}
					else
					{
						num3 = -1710576735;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 628705690);
					continue;
				}
				default:
					_200D_202E_200B_206F_202C_202C_200B_206A_206D_202B_206E_206A_200E_202B_202C_202E_202A_202D_200C_200F_206E_206B_202A_202D_202D_206C_206C_206F_200C_200E_200F_202A_200F_200D_202C_206C_200C_206E_206D_206D_202E(val, LuaScriptMgr.GetArrayObject<Transform>(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_rootBone(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		SkinnedMeshRenderer val = (SkinnedMeshRenderer)luaObject;
		while (true)
		{
			int num = -1857757363;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -922900296)) % 6)
				{
				case 0u:
					break;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(940017054u));
					num = ((int)num2 * -760429719) ^ -1775057234;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1241900998u));
					num = -1522774333;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (!_202C_206D_206F_206A_206B_200C_206B_202D_206D_206E_206B_202C_202D_206A_202A_202D_202A_200C_200E_202C_206C_200D_200B_206C_200C_206F_202C_200D_202C_202B_206E_206C_200D_202A_200B_200C_206F_202D_202D_206F_202E((Object)(object)val, (Object)null))
					{
						num5 = -1814455142;
						num6 = num5;
					}
					else
					{
						num5 = -435189877;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -520862123);
					continue;
				}
				case 4u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 1906922564;
						num4 = num3;
					}
					else
					{
						num3 = 1132013533;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1081667968);
					continue;
				}
				default:
					_202E_202A_206C_206A_200B_206D_200B_200D_206B_206B_206A_202E_200D_202A_200B_200D_206E_206B_200E_206B_202B_200B_200F_200C_200C_202A_200D_206C_206A_206E_202B_202D_202D_200F_202A_206B_200C_202E_200F_200D_202E(val, (Transform)LuaScriptMgr.GetUnityObject(L, 3, _202A_200E_202A_202D_200B_202D_206C_206D_206F_206C_200D_202B_202E_206E_200F_206B_202C_202A_202E_200B_200B_206B_206E_202D_202C_206C_206E_202A_206A_206C_200F_200E_200E_206C_206C_200F_200F_200D_200B_200D_202E(typeof(Transform).TypeHandle)));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_quality(IntPtr L)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		SkinnedMeshRenderer val = default(SkinnedMeshRenderer);
		while (true)
		{
			int num = -1398167313;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1204119755)) % 9)
				{
				case 2u:
					break;
				case 7u:
					val = (SkinnedMeshRenderer)luaObject;
					num = ((int)num2 * -1148872037) ^ -1177398395;
					continue;
				case 8u:
					_206A_206B_200B_202E_200E_202B_206A_206C_206E_202C_202C_200B_206C_202C_202D_200C_200E_206F_202B_200D_206E_206E_206C_200E_206B_200E_206B_206D_206A_200C_202B_200D_200F_200E_206C_202C_200D_206F_206A_206B_202E(val, (SkinQuality)(int)LuaScriptMgr.GetNetObject(L, 3, _202A_200E_202A_202D_200B_202D_206C_206D_206F_206C_200D_202B_202E_206E_200F_206B_202C_202A_202E_200B_200B_206B_206E_202D_202C_206C_206E_202A_206A_206C_200F_200E_200E_206C_206C_200F_200F_200D_200B_200D_202E(typeof(SkinQuality).TypeHandle)));
					num = -1679433342;
					continue;
				case 6u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -1239647099;
						num6 = num5;
					}
					else
					{
						num5 = -939336114;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -213662972);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4099488098u));
					num = ((int)num2 * -1132513895) ^ 0x66902208;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (_202C_206D_206F_206A_206B_200C_206B_202D_206D_206E_206B_202C_202D_206A_202A_202D_202A_200C_200E_202C_206C_200D_200B_206C_200C_206F_202C_200D_202C_202B_206E_206C_200D_202A_200B_200C_206F_202D_202D_206F_202E((Object)(object)val, (Object)null))
					{
						num3 = 818533175;
						num4 = num3;
					}
					else
					{
						num3 = 1033384336;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -2023563933);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2648288602u));
					num = -1461666374;
					continue;
				case 5u:
					num = (int)((num2 * 1610367531) ^ 0x30ECE3F0);
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_sharedMesh(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		SkinnedMeshRenderer val = (SkinnedMeshRenderer)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1458853822;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2FD31193)) % 7)
				{
				case 5u:
					break;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1760109351u));
					num = 188549905;
					continue;
				case 2u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 1415619855) ^ -1810125812;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1043987433u));
					num = (int)(num2 * 2053716302) ^ -1946620413;
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (!_202C_206D_206F_206A_206B_200C_206B_202D_206D_206E_206B_202C_202D_206A_202A_202D_202A_200C_200E_202C_206C_200D_200B_206C_200C_206F_202C_200D_202C_202B_206E_206C_200D_202A_200B_200C_206F_202D_202D_206F_202E((Object)(object)val, (Object)null))
					{
						num5 = 1783893947;
						num6 = num5;
					}
					else
					{
						num5 = 1422072703;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 318069650);
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -191284440;
						num4 = num3;
					}
					else
					{
						num3 = -706167232;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 755159140);
					continue;
				}
				default:
					_206C_206A_200F_206F_200D_202D_200E_200E_200E_202B_202B_200B_206E_200F_202B_200D_200B_206D_206C_200E_200B_200D_206A_206E_206A_206A_206A_206C_206D_200D_206C_206C_206F_200E_202C_202A_202D_200D_200C_206E_202E(val, (Mesh)LuaScriptMgr.GetUnityObject(L, 3, _202A_200E_202A_202D_200B_202D_206C_206D_206F_206C_200D_202B_202E_206E_200F_206B_202C_202A_202E_200B_200B_206B_206E_202D_202C_206C_206E_202A_206A_206C_200F_200E_200E_206C_206C_200F_200F_200D_200B_200D_202E(typeof(Mesh).TypeHandle)));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_updateWhenOffscreen(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		SkinnedMeshRenderer val = default(SkinnedMeshRenderer);
		while (true)
		{
			int num = 434513812;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3C08945F)) % 7)
				{
				case 2u:
					break;
				case 4u:
				{
					val = (SkinnedMeshRenderer)luaObject;
					int num5;
					int num6;
					if (!_202C_206D_206F_206A_206B_200C_206B_202D_206D_206E_206B_202C_202D_206A_202A_202D_202A_200C_200E_202C_206C_200D_200B_206C_200C_206F_202C_200D_202C_202B_206E_206C_200D_202A_200B_200C_206F_202D_202D_206F_202E((Object)(object)val, (Object)null))
					{
						num5 = -1175493273;
						num6 = num5;
					}
					else
					{
						num5 = -1101476595;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1524693853);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2988019205u));
					num = 946879704;
					continue;
				case 3u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 250721469;
						num4 = num3;
					}
					else
					{
						num3 = 655022260;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1164171524);
					continue;
				}
				case 6u:
					num = (int)(num2 * 896297365) ^ -508605883;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(355863870u));
					num = (int)(num2 * 1052127995) ^ -1652858580;
					continue;
				default:
					_200E_206B_202E_206F_202B_202C_206F_202E_202D_206E_202E_202D_206D_202A_200D_200C_206B_200F_202C_200B_202E_200F_202D_202A_202A_200F_200C_200E_206B_206C_202B_206F_202E_206F_206A_202A_206E_200D_206C_206D_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_localBounds(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		SkinnedMeshRenderer val = (SkinnedMeshRenderer)luaObject;
		if (_202C_206D_206F_206A_206B_200C_206B_202D_206D_206E_206B_202C_202D_206A_202A_202D_202A_200C_200E_202C_206C_200D_200B_206C_200C_206F_202C_200D_202C_202B_206E_206C_200D_202A_200B_200C_206F_202D_202D_206F_202E((Object)(object)val, (Object)null))
		{
			goto IL_0018;
		}
		goto IL_0060;
		IL_0018:
		int num = -1747766704;
		goto IL_001d;
		IL_001d:
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1429948631)) % 8)
			{
			case 6u:
				break;
			case 2u:
				num = (int)(num2 * 103031063) ^ -147859016;
				continue;
			case 7u:
				goto IL_0060;
			case 0u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2867641695u));
				num = -1987730938;
				continue;
			case 1u:
				luaTypes = LuaDLL.lua_type(L, 1);
				num = ((int)num2 * -380569527) ^ -618323325;
				continue;
			case 4u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1114906429u));
				num = ((int)num2 * -1726306441) ^ 0x2022373F;
				continue;
			case 3u:
			{
				int num3;
				int num4;
				if (luaTypes == LuaTypes.LUA_TTABLE)
				{
					num3 = 1466852799;
					num4 = num3;
				}
				else
				{
					num3 = 46677595;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 2136271358);
				continue;
			}
			default:
				return 0;
			}
			break;
		}
		goto IL_0018;
		IL_0060:
		_206C_206F_200C_200B_200F_202B_200F_202B_206A_202B_202E_202B_202A_206D_206B_206F_206D_200C_202E_202B_202C_206D_200D_206A_202A_206E_202B_206C_200F_202E_202D_206F_206A_202B_206A_202D_206C_202B_200C_206E_202E(val, LuaScriptMgr.GetBounds(L, 3));
		num = -1943686868;
		goto IL_001d;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int BakeMesh(IntPtr L)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		SkinnedMeshRenderer val2 = default(SkinnedMeshRenderer);
		while (true)
		{
			int num = 183742563;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4BDFAAA6)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0029;
				default:
				{
					Mesh val = (Mesh)LuaScriptMgr.GetUnityObject(L, 2, _202A_200E_202A_202D_200B_202D_206C_206D_206F_206C_200D_202B_202E_206E_200F_206B_202C_202A_202E_200B_200B_206B_206E_202D_202C_206C_206E_202A_206A_206C_200F_200E_200E_206C_206C_200F_200F_200D_200B_200D_202E(typeof(Mesh).TypeHandle));
					_206A_206A_206C_206C_206C_206C_200C_200E_202A_206E_200C_206E_202A_200E_206A_206D_206F_200B_206D_200C_200F_206A_200F_206D_202B_202B_200F_206F_200F_202A_202C_202A_206F_200B_200F_206A_202A_200D_200E_202E_202E(val2, val);
					return 0;
				}
				}
				break;
				IL_0029:
				val2 = (SkinnedMeshRenderer)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1732462407u));
				num = (int)((num2 * 2069929115) ^ 0x5ADB25B9);
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetBlendShapeWeight(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		SkinnedMeshRenderer val = (SkinnedMeshRenderer)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1686539606u));
		int num = (int)LuaScriptMgr.GetNumber(L, 2);
		float d = default(float);
		while (true)
		{
			int num2 = -439050517;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -394064615)) % 4)
				{
				case 0u:
					break;
				case 2u:
					d = _202A_202B_200F_206D_200F_202B_200C_206F_206A_206D_206A_200D_206D_202C_206E_202B_202E_202D_200F_200C_202C_206C_206E_206D_200D_202E_206C_206B_206A_200E_206F_202B_200C_202E_202D_206C_200C_206A_206D_206F_202E(val, num);
					num2 = ((int)num3 * -658763118) ^ 0x5463DC9C;
					continue;
				case 1u:
					LuaScriptMgr.Push(L, d);
					num2 = ((int)num3 * -1232112448) ^ 0x5999A112;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SetBlendShapeWeight(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 3);
		SkinnedMeshRenderer val = default(SkinnedMeshRenderer);
		int num4 = default(int);
		float num3 = default(float);
		while (true)
		{
			int num = 1941893812;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5EAF5F59)) % 5)
				{
				case 0u:
					break;
				case 2u:
					val = (SkinnedMeshRenderer)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2450076889u));
					num4 = (int)LuaScriptMgr.GetNumber(L, 2);
					num = (int)((num2 * 746634272) ^ 0x3C84486D);
					continue;
				case 4u:
					_206D_206B_200F_202B_202B_206E_202D_200C_206C_206A_206E_202E_206E_200D_206D_200D_202D_202A_206B_206A_200C_206F_206A_200B_206B_202B_206B_200B_200E_206B_200E_202B_206A_202A_202D_202E_206A_202A_202D_200C_202E(val, num4, num3);
					num = ((int)num2 * -259165522) ^ 0x59FECDF4;
					continue;
				case 3u:
					num3 = (float)LuaScriptMgr.GetNumber(L, 3);
					num = (int)(num2 * 536309078) ^ -1008099683;
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
		object luaObject2 = LuaScriptMgr.GetLuaObject(L, 2);
		Object val2 = (Object)((luaObject2 is Object) ? luaObject2 : null);
		bool b = _202C_206D_206F_206A_206B_200C_206B_202D_206D_206E_206B_202C_202D_206A_202A_202D_202A_200C_200E_202C_206C_200D_200B_206C_200C_206F_202C_200D_202C_202B_206E_206C_200D_202A_200B_200C_206F_202D_202D_206F_202E(val, val2);
		LuaScriptMgr.Push(L, b);
		return 1;
	}

	static Type _202A_200E_202A_202D_200B_202D_206C_206D_206F_206C_200D_202B_202E_206E_200F_206B_202C_202A_202E_200B_200B_206B_206E_202D_202C_206C_206E_202A_206A_206C_200F_200E_200E_206C_206C_200F_200F_200D_200B_200D_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static SkinnedMeshRenderer _202D_200F_206C_200B_200C_202C_202A_200D_202D_206C_200E_200B_202D_206F_206C_206D_206A_206F_202C_202E_200B_202C_206F_200D_206F_206E_202C_206B_200B_206C_200F_202A_206F_200B_206F_202E_200E_206C_206E_200C_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new SkinnedMeshRenderer();
	}

	static bool _202C_206D_206F_206A_206B_200C_206B_202D_206D_206E_206B_202C_202D_206A_202A_202D_202A_200C_200E_202C_206C_200D_200B_206C_200C_206F_202C_200D_202C_202B_206E_206C_200D_202A_200B_200C_206F_202D_202D_206F_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static Transform[] _200B_206C_200E_202A_206B_200F_200C_206B_206F_206F_200B_200E_206F_206A_202E_206E_200C_200B_200B_200F_200E_202A_200B_206D_200E_206E_200C_202D_200B_206E_202B_206D_202C_206E_206E_202A_202C_206A_206D_200F_202E(SkinnedMeshRenderer P_0)
	{
		return P_0.bones;
	}

	static Transform _202C_200E_200E_202C_202D_200C_206B_202C_206D_200E_200D_206D_206D_202A_206F_202A_200E_202A_202D_206C_200B_206A_200C_202E_200F_206A_206E_202D_202A_206B_202E_206E_200B_200B_206F_200C_200D_202B_206E_200C_202E(SkinnedMeshRenderer P_0)
	{
		return P_0.rootBone;
	}

	static SkinQuality _206D_200C_200E_200D_206D_206A_206A_200F_206D_200D_202B_206D_202A_202C_200C_206C_206B_200B_206F_206F_206A_206C_202A_202C_206E_200D_200B_202A_202D_202C_202D_202A_206E_206C_206D_200F_202A_206F_202E_206A_202E(SkinnedMeshRenderer P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.quality;
	}

	static Mesh _206E_200E_206E_206F_202E_202B_200B_206F_200E_202A_206B_200E_202E_200B_200B_206E_206D_200E_200B_206D_206E_202A_206A_200B_202E_200C_200B_206D_206D_200C_202B_206B_206F_206F_200D_202D_206C_202E_202C_202E(SkinnedMeshRenderer P_0)
	{
		return P_0.sharedMesh;
	}

	static bool _200E_206B_200C_206C_206B_200D_202C_202D_206F_206D_200E_202D_200B_200E_200C_206F_200F_200B_202A_202E_202D_202B_206A_200B_200F_200F_206C_206E_206C_206E_200C_202E_206B_206C_206E_202E_200E_202C_202D_200C_202E(SkinnedMeshRenderer P_0)
	{
		return P_0.updateWhenOffscreen;
	}

	static Bounds _206B_200E_206E_200D_202B_200C_206D_206D_200B_206F_200D_206D_202A_202A_206B_206A_202C_206E_200D_206F_202E_206A_206D_206D_200F_202B_202C_206B_206E_206C_206E_202C_202B_200B_202D_206E_206D_200D_202A_202B_202E(SkinnedMeshRenderer P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.localBounds;
	}

	static void _200D_202E_200B_206F_202C_202C_200B_206A_206D_202B_206E_206A_200E_202B_202C_202E_202A_202D_200C_200F_206E_206B_202A_202D_202D_206C_206C_206F_200C_200E_200F_202A_200F_200D_202C_206C_200C_206E_206D_206D_202E(SkinnedMeshRenderer P_0, Transform[] P_1)
	{
		P_0.bones = P_1;
	}

	static void _202E_202A_206C_206A_200B_206D_200B_200D_206B_206B_206A_202E_200D_202A_200B_200D_206E_206B_200E_206B_202B_200B_200F_200C_200C_202A_200D_206C_206A_206E_202B_202D_202D_200F_202A_206B_200C_202E_200F_200D_202E(SkinnedMeshRenderer P_0, Transform P_1)
	{
		P_0.rootBone = P_1;
	}

	static void _206A_206B_200B_202E_200E_202B_206A_206C_206E_202C_202C_200B_206C_202C_202D_200C_200E_206F_202B_200D_206E_206E_206C_200E_206B_200E_206B_206D_206A_200C_202B_200D_200F_200E_206C_202C_200D_206F_206A_206B_202E(SkinnedMeshRenderer P_0, SkinQuality P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.quality = P_1;
	}

	static void _206C_206A_200F_206F_200D_202D_200E_200E_200E_202B_202B_200B_206E_200F_202B_200D_200B_206D_206C_200E_200B_200D_206A_206E_206A_206A_206A_206C_206D_200D_206C_206C_206F_200E_202C_202A_202D_200D_200C_206E_202E(SkinnedMeshRenderer P_0, Mesh P_1)
	{
		P_0.sharedMesh = P_1;
	}

	static void _200E_206B_202E_206F_202B_202C_206F_202E_202D_206E_202E_202D_206D_202A_200D_200C_206B_200F_202C_200B_202E_200F_202D_202A_202A_200F_200C_200E_206B_206C_202B_206F_202E_206F_206A_202A_206E_200D_206C_206D_202E(SkinnedMeshRenderer P_0, bool P_1)
	{
		P_0.updateWhenOffscreen = P_1;
	}

	static void _206C_206F_200C_200B_200F_202B_200F_202B_206A_202B_202E_202B_202A_206D_206B_206F_206D_200C_202E_202B_202C_206D_200D_206A_202A_206E_202B_206C_200F_202E_202D_206F_206A_202B_206A_202D_206C_202B_200C_206E_202E(SkinnedMeshRenderer P_0, Bounds P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.localBounds = P_1;
	}

	static void _206A_206A_206C_206C_206C_206C_200C_200E_202A_206E_200C_206E_202A_200E_206A_206D_206F_200B_206D_200C_200F_206A_200F_206D_202B_202B_200F_206F_200F_202A_202C_202A_206F_200B_200F_206A_202A_200D_200E_202E_202E(SkinnedMeshRenderer P_0, Mesh P_1)
	{
		P_0.BakeMesh(P_1);
	}

	static float _202A_202B_200F_206D_200F_202B_200C_206F_206A_206D_206A_200D_206D_202C_206E_202B_202E_202D_200F_200C_202C_206C_206E_206D_200D_202E_206C_206B_206A_200E_206F_202B_200C_202E_202D_206C_200C_206A_206D_206F_202E(SkinnedMeshRenderer P_0, int P_1)
	{
		return P_0.GetBlendShapeWeight(P_1);
	}

	static void _206D_206B_200F_202B_202B_206E_202D_200C_206C_206A_206E_202E_206E_200D_206D_200D_202D_202A_206B_206A_200C_206F_206A_200B_206B_202B_206B_200B_200E_206B_200E_202B_206A_202A_202D_202E_206A_202A_202D_200C_202E(SkinnedMeshRenderer P_0, int P_1, float P_2)
	{
		P_0.SetBlendShapeWeight(P_1, P_2);
	}
}
