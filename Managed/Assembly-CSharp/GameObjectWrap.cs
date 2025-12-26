using System;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;

public class GameObjectWrap
{
	private static Type classType = _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(typeof(GameObject).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[20]
		{
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4257504027u), CreatePrimitive),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2512011u), GetComponent),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4010615889u), GetComponentInChildren),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1836385268u), GetComponentInParent),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2074175267u), GetComponents),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3254261079u), GetComponentsInChildren),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2187381746u), GetComponentsInParent),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2598169661u), SetActive),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(982658086u), CompareTag),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1139263806u), FindGameObjectWithTag),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4207317774u), FindWithTag),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3670909338u), FindGameObjectsWithTag),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3820293474u), SendMessageUpwards),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(749823400u), SendMessage),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1295211881u), BroadcastMessage),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2180699820u), AddComponent),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3474098585u), Find),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1621874631u), _200E_206A_206F_200D_206C_206E_202A_202C_206C_206E_202C_200C_206F_206F_202B_200E_202D_206F_202D_200D_200F_202B_202D_202B_200B_202D_200B_202E_202E_202D_200B_200E_200B_206D_206F_202D_206C_202E_202A_200E_202E),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3661446913u), GetClassType),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2206010212u), Lua_Eq)
		};
		while (true)
		{
			int num = -471307659;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -305384984)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_0344;
				case 2u:
					return;
				}
				break;
				IL_0344:
				LuaField[] fields = new LuaField[7]
				{
					new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3557005325u), get_transform, null),
					new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2534077069u), get_layer, set_layer),
					new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3462475495u), get_activeSelf, null),
					new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3143168536u), get_activeInHierarchy, null),
					new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4270057672u), get_isStatic, set_isStatic),
					new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1045031427u), get_tag, set_tag),
					new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3401782201u), get_gameObject, null)
				};
				LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(611352140u), _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(typeof(GameObject).TypeHandle), regs, fields, _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(typeof(Object).TypeHandle));
				num = (int)((num2 * 1104037379) ^ 0x625C3041);
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _200E_206A_206F_200D_206C_206E_202A_202C_206C_206E_202C_200C_206F_206F_202B_200E_202D_206F_202D_200D_200F_202B_202D_202B_200B_202D_200B_202E_202E_202D_200B_200E_200B_206D_206F_202D_206C_202E_202A_200E_202E(IntPtr P_0)
	{
		int num = LuaDLL.lua_gettop(P_0);
		string text2 = default(string);
		string text = default(string);
		while (true)
		{
			int num2 = 385472039;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x2B371A16)) % 13)
				{
				case 2u:
					break;
				case 4u:
				{
					GameObject obj3 = _202D_206D_202C_202C_206B_206A_206E_202E_202B_202E_200D_200C_202E_202C_202C_206F_206E_200D_200F_202C_206D_202B_206E_202B_206F_206D_200E_200F_200B_202A_200B_200B_206E_200B_206F_202A_202C_200E_200F_202E(text2);
					LuaScriptMgr.Push(P_0, (Object)(object)obj3);
					num2 = ((int)num3 * -635502006) ^ 0x78BFC5DC;
					continue;
				}
				case 11u:
				{
					int num5;
					if (!LuaScriptMgr.CheckTypes(P_0, 1, _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(typeof(string).TypeHandle)))
					{
						num2 = 127638461;
						num5 = num2;
					}
					else
					{
						num2 = 1116626637;
						num5 = num2;
					}
					continue;
				}
				case 8u:
					return 1;
				case 9u:
				{
					int num6;
					int num7;
					if (!LuaScriptMgr.CheckParamsType(P_0, _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(typeof(Type).TypeHandle), 2, num - 1))
					{
						num6 = -254904414;
						num7 = num6;
					}
					else
					{
						num6 = -1337850372;
						num7 = num6;
					}
					num2 = num6 ^ ((int)num3 * -758819059);
					continue;
				}
				case 3u:
				{
					int num8;
					int num9;
					if (num != 0)
					{
						num8 = 1208649672;
						num9 = num8;
					}
					else
					{
						num8 = 799549362;
						num9 = num8;
					}
					num2 = num8 ^ (int)(num3 * 786596961);
					continue;
				}
				case 12u:
				{
					int num4;
					if (num == 1)
					{
						num2 = 1831822648;
						num4 = num2;
					}
					else
					{
						num2 = 668068635;
						num4 = num2;
					}
					continue;
				}
				case 5u:
					text2 = LuaScriptMgr.GetString(P_0, 1);
					num2 = ((int)num3 * -1298345050) ^ 0x42CD4C11;
					continue;
				case 0u:
				{
					GameObject obj2 = _202D_202C_206F_206E_206C_206E_206D_202D_206B_200B_206D_200D_206E_202D_206C_202B_202A_206B_200C_200B_206C_200B_202D_202E_206B_206D_206C_202A_202E_206A_202A_202B_200D_200E_202C_202B_206E_206A_200E_200F_202E();
					LuaScriptMgr.Push(P_0, (Object)(object)obj2);
					return 1;
				}
				case 6u:
				{
					Type[] paramsObject = LuaScriptMgr.GetParamsObject<Type>(P_0, 2, num - 1);
					GameObject obj = _206B_202A_206E_202A_206F_200B_200E_206F_206D_200D_206F_202E_200C_206D_206D_206C_200D_202B_206A_202D_202D_206E_206E_206E_206A_202C_206D_202E_202B_202A_206A_200B_202E_206C_206B_202A_200F_202B_200C_200E_202E(text, paramsObject);
					LuaScriptMgr.Push(P_0, (Object)(object)obj);
					num2 = (int)((num3 * 924953258) ^ 0x8800B02);
					continue;
				}
				case 1u:
					return 1;
				case 10u:
					text = LuaScriptMgr.GetString(P_0, 1);
					num2 = ((int)num3 * -106507594) ^ 0x2DE4C0BE;
					continue;
				default:
					LuaDLL.luaL_error(P_0, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(673594434u));
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
	private static int get_transform(IntPtr L)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		GameObject val = default(GameObject);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 697754800;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x283736B9)) % 8)
				{
				case 3u:
					break;
				case 0u:
					LuaScriptMgr.Push(L, (Object)(object)_200B_206B_206F_206B_206C_200C_200C_206A_200E_206E_202E_200B_202C_206F_206C_200B_202A_202B_206A_206D_200C_200F_200E_200F_206E_200F_206B_206C_200B_206A_200B_206F_200E_202A_200B_200F_200E_206C_200E_200D_202E(val));
					num = 1701066107;
					continue;
				case 7u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -387693566) ^ -277423974;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2969910167u));
					num = (int)((num2 * 441674012) ^ 0x3D4B7721);
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -814796795;
						num6 = num5;
					}
					else
					{
						num5 = -2007301665;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1197593912);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1065602485u));
					num = 29302249;
					continue;
				case 1u:
				{
					val = (GameObject)luaObject;
					int num3;
					int num4;
					if (!_202B_200F_202A_206F_206F_206C_200E_200B_200C_206F_200F_206B_202B_206C_200E_206F_200C_202B_206A_206F_202E_206A_206E_206A_202A_206D_206E_200E_206C_200D_200D_206E_202C_200B_200F_200D_206C_200C_202D_202E((Object)(object)val, (Object)null))
					{
						num3 = 157452275;
						num4 = num3;
					}
					else
					{
						num3 = 1743332756;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1738889270);
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
	private static int get_layer(IntPtr L)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		GameObject val = default(GameObject);
		while (true)
		{
			int num = 1792091345;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3B74B01E)) % 9)
				{
				case 6u:
					break;
				case 1u:
					val = (GameObject)luaObject;
					num = ((int)num2 * -885341987) ^ -214130678;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3245090624u));
					num = (int)((num2 * 1719611962) ^ 0xA9AD4BB);
					continue;
				case 0u:
					num = ((int)num2 * -404791132) ^ -1548883996;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (!_202B_200F_202A_206F_206F_206C_200E_200B_200C_206F_200F_206B_202B_206C_200E_206F_200C_202B_206A_206F_202E_206A_206E_206A_202A_206D_206E_200E_206C_200D_200D_206E_202C_200B_200F_200D_206C_200C_202D_202E((Object)(object)val, (Object)null))
					{
						num5 = -1524340219;
						num6 = num5;
					}
					else
					{
						num5 = -219478267;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 993930379);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2383332077u));
					num = 1472944808;
					continue;
				case 7u:
					LuaScriptMgr.Push(L, _200C_202E_206B_206C_200F_206B_206E_206F_200C_206C_200B_202C_202D_206D_200B_206D_202D_206F_200D_202A_206A_200E_206B_202E_202E_202D_202A_206D_206E_202D_200C_202E_200C_206B_200C_200F_202D_206D_200C_206F_202E(val));
					num = 795323377;
					continue;
				case 8u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -1993556586;
						num4 = num3;
					}
					else
					{
						num3 = -1686972471;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -2034302118);
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
	private static int get_activeSelf(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		GameObject val = (GameObject)luaObject;
		if (_202B_200F_202A_206F_206F_206C_200E_200B_200C_206F_200F_206B_202B_206C_200E_206F_200C_202B_206A_206F_202E_206A_206E_206A_202A_206D_206E_200E_206C_200D_200D_206E_202C_200B_200F_200D_206C_200C_202D_202E((Object)(object)val, (Object)null))
		{
			while (true)
			{
				int num = 828357686;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x2EED32B8)) % 6)
					{
					case 2u:
						break;
					case 4u:
					{
						LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
						int num3;
						int num4;
						if (luaTypes == LuaTypes.LUA_TTABLE)
						{
							num3 = -767474563;
							num4 = num3;
						}
						else
						{
							num3 = -1389388531;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 559034177);
						continue;
					}
					case 0u:
						num = ((int)num2 * -1450209166) ^ 0x7F12D4C5;
						continue;
					case 5u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1974204512u));
						num = 592766881;
						continue;
					case 3u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1139085652u));
						num = ((int)num2 * -295376056) ^ -1484209182;
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
		LuaScriptMgr.Push(L, _206B_202C_206F_206B_202C_206C_200F_202B_202A_206E_202C_202E_206E_200B_202A_200E_206F_200B_202B_206C_202E_200F_200B_200D_206E_202C_206B_202A_202D_200E_200C_206C_206D_202E_206A_202B_200E_200F_200B_206A_202E(val));
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_activeInHierarchy(IntPtr L)
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		GameObject val = default(GameObject);
		while (true)
		{
			int num = 1531172632;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6AA1D4E0)) % 9)
				{
				case 6u:
					break;
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1331728401) ^ -1955423452;
					continue;
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2519484861u));
					num = ((int)num2 * -1436959848) ^ 0x25DE01B8;
					continue;
				case 0u:
					num = (int)((num2 * 293665841) ^ 0x16017611);
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (_202B_200F_202A_206F_206F_206C_200E_200B_200C_206F_200F_206B_202B_206C_200E_206F_200C_202B_206A_206F_202E_206A_206E_206A_202A_206D_206E_200E_206C_200D_200D_206E_202C_200B_200F_200D_206C_200C_202D_202E((Object)(object)val, (Object)null))
					{
						num5 = -92577275;
						num6 = num5;
					}
					else
					{
						num5 = -533433675;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 986776855);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2281253638u));
					num = 128394593;
					continue;
				case 1u:
					val = (GameObject)luaObject;
					num = (int)(num2 * 290569894) ^ -1909553796;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 1258224422;
						num4 = num3;
					}
					else
					{
						num3 = 1310646850;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -184905549);
					continue;
				}
				default:
					LuaScriptMgr.Push(L, _206B_206C_206D_200E_202A_206E_202A_202D_202B_202A_206E_200D_202C_206F_206A_200C_206C_206B_206F_206F_200B_206D_206D_200E_200B_206A_200D_202D_202C_200D_200B_200D_206E_202D_202B_200E_206B_200E_200D_202B_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_isStatic(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		GameObject val = (GameObject)luaObject;
		if (_202B_200F_202A_206F_206F_206C_200E_200B_200C_206F_200F_206B_202B_206C_200E_206F_200C_202B_206A_206F_202E_206A_206E_206A_202A_206D_206E_200E_206C_200D_200D_206E_202C_200B_200F_200D_206C_200C_202D_202E((Object)(object)val, (Object)null))
		{
			goto IL_001b;
		}
		goto IL_00bd;
		IL_001b:
		int num = -610554801;
		goto IL_0020;
		IL_0020:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -286330997)) % 7)
			{
			case 5u:
				break;
			case 3u:
				num = (int)(num2 * 265734705) ^ -1445750363;
				continue;
			case 0u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2824534572u));
				num = -1582002253;
				continue;
			case 2u:
			{
				LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
				int num3;
				int num4;
				if (luaTypes != LuaTypes.LUA_TTABLE)
				{
					num3 = -1264378804;
					num4 = num3;
				}
				else
				{
					num3 = -920939922;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 549350702);
				continue;
			}
			case 1u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(766159775u));
				num = ((int)num2 * -1114823163) ^ 0x5CA4A2C;
				continue;
			case 6u:
				goto IL_00bd;
			default:
				return 1;
			}
			break;
		}
		goto IL_001b;
		IL_00bd:
		LuaScriptMgr.Push(L, _202E_206D_202B_200F_202E_206C_206B_200C_202C_200C_206D_200B_200D_200D_200B_202D_206D_200F_206D_200E_200F_202C_206A_202A_206A_200B_200C_200F_202D_200B_202B_202E_202D_202C_206A_206F_200B_206B_206A_206B_202E(val));
		num = -393600796;
		goto IL_0020;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_tag(IntPtr L)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		GameObject val = default(GameObject);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1138668474;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -746071502)) % 10)
				{
				case 5u:
					break;
				case 1u:
					LuaScriptMgr.Push(L, _206F_202E_206A_202E_200E_206A_206B_200D_200B_202C_206A_202C_206C_200C_200D_206B_202C_206E_200E_206D_206C_200E_200C_202E_202C_202A_202C_206F_206F_206A_202E_202C_206A_200F_200C_200B_206C_206F_206E_206D_202E(val));
					num = -931320409;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1942353993u));
					num = -1922500109;
					continue;
				case 8u:
					val = (GameObject)luaObject;
					num = (int)(num2 * 1358424951) ^ -308123369;
					continue;
				case 9u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 1294398117) ^ -1562517513;
					continue;
				case 6u:
					num = ((int)num2 * -716082397) ^ 0x2DCD99B;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 1731651570;
						num6 = num5;
					}
					else
					{
						num5 = 1209457732;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -243693909);
					continue;
				}
				case 7u:
				{
					int num3;
					int num4;
					if (_202B_200F_202A_206F_206F_206C_200E_200B_200C_206F_200F_206B_202B_206C_200E_206F_200C_202B_206A_206F_202E_206A_206E_206A_202A_206D_206E_200E_206C_200D_200D_206E_202C_200B_200F_200D_206C_200C_202D_202E((Object)(object)val, (Object)null))
					{
						num3 = 1016806912;
						num4 = num3;
					}
					else
					{
						num3 = 64444612;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 32025087);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3813405018u));
					num = (int)((num2 * 1407901118) ^ 0x57520776);
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_gameObject(IntPtr L)
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		GameObject val = default(GameObject);
		while (true)
		{
			int num = 599686188;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x176FB263)) % 9)
				{
				case 0u:
					break;
				case 2u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -696335579;
						num6 = num5;
					}
					else
					{
						num5 = -197147043;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -583153436);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3946436877u));
					num = ((int)num2 * -1301502580) ^ 0x646CED1B;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!_202B_200F_202A_206F_206F_206C_200E_200B_200C_206F_200F_206B_202B_206C_200E_206F_200C_202B_206A_206F_202E_206A_206E_206A_202A_206D_206E_200E_206C_200D_200D_206E_202C_200B_200F_200D_206C_200C_202D_202E((Object)(object)val, (Object)null))
					{
						num3 = 1080205430;
						num4 = num3;
					}
					else
					{
						num3 = 1192189271;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1885554973);
					continue;
				}
				case 6u:
					val = (GameObject)luaObject;
					num = (int)(num2 * 1462923714) ^ -1307709062;
					continue;
				case 3u:
					LuaScriptMgr.Push(L, (Object)(object)_202E_206A_202D_200B_200C_206B_206A_206C_200C_200F_206C_206B_206C_202E_202A_200E_200B_206D_200F_200E_200D_206F_200E_200E_206B_200E_202B_200D_202B_206F_202D_200E_206D_200E_202E_200E_202B_202A_202A_202E_202E(val));
					num = 952363536;
					continue;
				case 7u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1836190086) ^ 0x530716F0;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(372887337u));
					num = 226904323;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_layer(IntPtr L)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		GameObject val = default(GameObject);
		while (true)
		{
			int num = -1341416079;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -616676165)) % 8)
				{
				case 3u:
					break;
				case 5u:
					_206C_200D_206D_202C_202B_200C_202A_202B_200C_200B_202E_200D_206C_202E_200D_200E_206C_202B_206C_200E_206B_206B_202B_200C_206D_202D_206F_200C_202B_200F_200F_206F_202C_206E_206F_206D_202B_202A_206C_202B_202E(val, (int)LuaScriptMgr.GetNumber(L, 3));
					num = -1294226510;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4080589049u));
					num = -410525762;
					continue;
				case 0u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -265588011;
						num6 = num5;
					}
					else
					{
						num5 = -2130699948;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1067683562);
					continue;
				}
				case 2u:
					val = (GameObject)luaObject;
					num = (int)(num2 * 1968196505) ^ -1336315211;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (_202B_200F_202A_206F_206F_206C_200E_200B_200C_206F_200F_206B_202B_206C_200E_206F_200C_202B_206A_206F_202E_206A_206E_206A_202A_206D_206E_200E_206C_200D_200D_206E_202C_200B_200F_200D_206C_200C_202D_202E((Object)(object)val, (Object)null))
					{
						num3 = -1630759761;
						num4 = num3;
					}
					else
					{
						num3 = -1453600814;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1041970777);
					continue;
				}
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3143474740u));
					num = ((int)num2 * -1516648123) ^ 0x43F58F25;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_isStatic(IntPtr L)
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		GameObject val = default(GameObject);
		while (true)
		{
			int num = -1955830613;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -163428130)) % 8)
				{
				case 6u:
					break;
				case 4u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -659175642;
						num6 = num5;
					}
					else
					{
						num5 = -1742876001;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -698479848);
					continue;
				}
				case 2u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 1260582900) ^ 0x29829C82);
					continue;
				case 3u:
					_202B_200D_200D_206F_206F_206D_202B_206E_200F_202A_206D_200F_200D_202C_200B_200F_200E_200F_202B_206E_206E_202E_202B_200C_202D_206B_202D_200E_206E_200C_206B_202D_202A_202A_202C_202A_200B_200E_206C_202E_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					num = -1125032871;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(766159775u));
					num = ((int)num2 * -355534976) ^ -852816699;
					continue;
				case 5u:
				{
					val = (GameObject)luaObject;
					int num3;
					int num4;
					if (_202B_200F_202A_206F_206F_206C_200E_200B_200C_206F_200F_206B_202B_206C_200E_206F_200C_202B_206A_206F_202E_206A_206E_206A_202A_206D_206E_200E_206C_200D_200D_206E_202C_200B_200F_200D_206C_200C_202D_202E((Object)(object)val, (Object)null))
					{
						num3 = -763020961;
						num4 = num3;
					}
					else
					{
						num3 = -448755642;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -159045097);
					continue;
				}
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2824534572u));
					num = -1132807995;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_tag(IntPtr L)
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		GameObject val = default(GameObject);
		while (true)
		{
			int num = 1086478726;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1441B504)) % 8)
				{
				case 3u:
					break;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1480692908u));
					num = (int)(num2 * 1346450391) ^ -1194688437;
					continue;
				case 6u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 1231458547;
						num6 = num5;
					}
					else
					{
						num5 = 548203789;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1575396);
					continue;
				}
				case 0u:
					_202C_200D_200F_200E_202B_206C_202C_200B_200D_206E_206F_206D_202E_206D_200B_200C_206F_202C_200F_200B_202A_200C_202C_206F_200B_202B_202C_202E_200C_206E_202E_202D_202A_202A_206B_206B_200C_206A_202E_202E_202E(val, LuaScriptMgr.GetString(L, 3));
					num = 2006149016;
					continue;
				case 2u:
					val = (GameObject)luaObject;
					num = (int)(num2 * 1805397067) ^ -414564113;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(338342589u));
					num = 1111300748;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!_202B_200F_202A_206F_206F_206C_200E_200B_200C_206F_200F_206B_202B_206C_200E_206F_200C_202B_206A_206F_202E_206A_206E_206A_202A_206D_206E_200E_206C_200D_200D_206E_202C_200B_200F_200D_206C_200C_202D_202E((Object)(object)val, (Object)null))
					{
						num3 = -1513730803;
						num4 = num3;
					}
					else
					{
						num3 = -1425726253;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -169325867);
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
	private static int CreatePrimitive(IntPtr L)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr.CheckArgsCount(L, 1);
		PrimitiveType val = (PrimitiveType)(int)LuaScriptMgr.GetNetObject(L, 1, _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(typeof(PrimitiveType).TypeHandle));
		GameObject obj = _200B_202E_202C_202D_202C_200F_206A_206E_206B_206D_202A_202C_202E_202C_206C_202B_202A_200D_200E_200C_202B_206D_200B_206A_206E_200C_206E_202E_200D_200E_202E_200C_206D_206F_200C_202C_200D_202B_200C_206F_202E(val);
		LuaScriptMgr.Push(L, (Object)(object)obj);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetComponent(IntPtr L)
	{
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		Component obj = default(Component);
		GameObject val = default(GameObject);
		Type typeObject = default(Type);
		while (true)
		{
			int num2 = -1728542506;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -588812009)) % 12)
				{
				case 11u:
					break;
				case 9u:
				{
					int num8;
					if (num != 2)
					{
						num2 = -1451455316;
						num8 = num2;
					}
					else
					{
						num2 = -518482757;
						num8 = num2;
					}
					continue;
				}
				case 4u:
				{
					int num6;
					int num7;
					if (LuaScriptMgr.CheckTypes(L, 1, _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(typeof(GameObject).TypeHandle), _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(typeof(string).TypeHandle)))
					{
						num6 = -1222439732;
						num7 = num6;
					}
					else
					{
						num6 = -845182838;
						num7 = num6;
					}
					num2 = num6 ^ ((int)num3 * -567736413);
					continue;
				}
				case 1u:
				{
					int num9;
					int num10;
					if (num != 2)
					{
						num9 = -1197267034;
						num10 = num9;
					}
					else
					{
						num9 = -174422757;
						num10 = num9;
					}
					num2 = num9 ^ (int)(num3 * 540701084);
					continue;
				}
				case 3u:
				{
					GameObject val2 = (GameObject)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3383417257u));
					string text = LuaScriptMgr.GetString(L, 2);
					Component obj2 = _206B_200B_202C_202A_202D_202D_206A_206E_202D_200C_202B_202E_202B_202C_202E_202B_200F_202E_206C_200E_206D_200B_202B_202D_206D_206A_202B_200D_206D_200C_200C_206F_200C_200D_202A_202D_200F_206B_206F_202E_202E(val2, text);
					LuaScriptMgr.Push(L, (Object)(object)obj2);
					num2 = (int)(num3 * 1845915259) ^ -1097803980;
					continue;
				}
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3371071161u));
					num2 = -505960622;
					continue;
				case 8u:
					obj = _202B_202A_206B_206A_200F_206E_206C_206A_206A_200B_200E_200B_200F_206A_202D_206E_200C_206D_200D_206C_202E_206A_206B_200C_200D_202E_200C_200D_202E_202C_200E_200D_200C_206A_200D_202B_206C_206D_202E_200F_202E(val, typeObject);
					num2 = (int)(num3 * 1918220245) ^ -1928531023;
					continue;
				case 6u:
					LuaScriptMgr.Push(L, (Object)(object)obj);
					return 1;
				case 10u:
					val = (GameObject)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1889101405u));
					typeObject = LuaScriptMgr.GetTypeObject(L, 2);
					num2 = ((int)num3 * -1669224396) ^ -1336677469;
					continue;
				case 2u:
					return 1;
				case 0u:
				{
					int num4;
					int num5;
					if (LuaScriptMgr.CheckTypes(L, 1, _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(typeof(GameObject).TypeHandle), _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(typeof(Type).TypeHandle)))
					{
						num4 = 350311005;
						num5 = num4;
					}
					else
					{
						num4 = 2052637412;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num3 * -1413864138);
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
	private static int GetComponentInChildren(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		GameObject val = default(GameObject);
		Component obj = default(Component);
		Type typeObject = default(Type);
		while (true)
		{
			int num = 715574769;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x74AA7EAD)) % 5)
				{
				case 3u:
					break;
				case 2u:
					val = (GameObject)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1889101405u));
					num = (int)((num2 * 2083830014) ^ 0x21378ACD);
					continue;
				case 4u:
					obj = _202A_206B_202C_206F_206F_202B_206E_206E_200C_206A_206F_200C_200B_200B_206A_202E_206D_200F_200D_202C_206F_200C_202E_202A_206D_206C_206F_202B_206B_206A_200C_206D_202E_202D_206F_202D_206A_202D_202D_206B_202E(val, typeObject);
					num = ((int)num2 * -1579241768) ^ 0x559F62E4;
					continue;
				case 1u:
					typeObject = LuaScriptMgr.GetTypeObject(L, 2);
					num = (int)(num2 * 587918097) ^ -1419202004;
					continue;
				default:
					LuaScriptMgr.Push(L, (Object)(object)obj);
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetComponentInParent(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		GameObject val = default(GameObject);
		while (true)
		{
			int num = 932802155;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x392A4189)) % 4)
				{
				case 0u:
					break;
				case 2u:
					val = (GameObject)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3383417257u));
					num = (int)(num2 * 1542498652) ^ -860220280;
					continue;
				case 1u:
				{
					Type typeObject = LuaScriptMgr.GetTypeObject(L, 2);
					Component obj = _200D_206D_200C_202E_206A_206C_202B_202D_200F_206E_202A_206F_202C_206F_206C_206A_206E_202E_206A_200F_206D_200D_206D_206B_202A_206D_200C_206B_206F_206E_202D_202A_206B_206C_200E_206E_202A_200B_202C_206B_202E(val, typeObject);
					LuaScriptMgr.Push(L, (Object)(object)obj);
					num = (int)((num2 * 169900199) ^ 0x53A11BAD);
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
	private static int GetComponents(IntPtr L)
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		GameObject val2 = default(GameObject);
		Type typeObject2 = default(Type);
		List<Component> list = default(List<Component>);
		while (true)
		{
			int num2 = -955068337;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -113376860)) % 9)
				{
				case 6u:
					break;
				case 1u:
				{
					int num5;
					int num6;
					if (num == 2)
					{
						num5 = 98498725;
						num6 = num5;
					}
					else
					{
						num5 = 795536242;
						num6 = num5;
					}
					num2 = num5 ^ (int)(num3 * 2093535996);
					continue;
				}
				case 3u:
					_200E_200D_200C_200B_202D_202D_200D_206C_202A_200B_206B_206F_200F_202C_200F_202A_202E_206B_202D_200E_200B_206C_200B_206A_206B_206F_202D_206C_206C_206E_202B_200F_200C_200B_202A_200B_202A_206E_200C_202A_202E(val2, typeObject2, list);
					return 0;
				case 4u:
					list = (List<Component>)LuaScriptMgr.GetNetObject(L, 3, _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(typeof(List<Component>).TypeHandle));
					num2 = (int)(num3 * 373170782) ^ -625439773;
					continue;
				case 7u:
					val2 = (GameObject)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3383417257u));
					typeObject2 = LuaScriptMgr.GetTypeObject(L, 2);
					num2 = ((int)num3 * -538732196) ^ -427872630;
					continue;
				case 8u:
				{
					int num4;
					if (num == 3)
					{
						num2 = -313839279;
						num4 = num2;
					}
					else
					{
						num2 = -1252975552;
						num4 = num2;
					}
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1826260250u));
					num2 = -1572471331;
					continue;
				case 5u:
				{
					GameObject val = (GameObject)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1889101405u));
					Type typeObject = LuaScriptMgr.GetTypeObject(L, 2);
					Component[] o = _202A_206C_202A_202D_202E_200E_202B_202C_200D_200F_200D_200C_202B_202D_206D_206E_202A_206D_200B_202B_202C_202C_206E_200F_200B_200F_202C_202B_202C_202A_202A_202E_206B_200B_202C_206B_202E_202B_202C_202D_202E(val, typeObject);
					LuaScriptMgr.PushArray(L, o);
					return 1;
				}
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetComponentsInChildren(IntPtr L)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		if (num == 2)
		{
			goto IL_000e;
		}
		goto IL_00b8;
		IL_000e:
		int num2 = -450269702;
		goto IL_0013;
		IL_0013:
		Component[] o2 = default(Component[]);
		GameObject val2 = default(GameObject);
		Type typeObject2 = default(Type);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ -1124354079)) % 7)
			{
			case 4u:
				break;
			case 2u:
				LuaScriptMgr.PushArray(L, o2);
				return 1;
			case 0u:
				val2 = (GameObject)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3225758075u));
				typeObject2 = LuaScriptMgr.GetTypeObject(L, 2);
				num2 = ((int)num3 * -672817828) ^ 0x3929E487;
				continue;
			case 6u:
			{
				bool boolean = LuaScriptMgr.GetBoolean(L, 3);
				o2 = _206B_202A_202A_200D_202A_206F_206D_206A_206D_206C_206C_200B_206F_206B_206C_206C_200C_206D_200B_202C_206E_202A_206F_206C_200D_206A_206A_206F_202D_200B_202B_206B_200B_202D_206A_202A_200E_206A_200C_202C_202E(val2, typeObject2, boolean);
				num2 = (int)(num3 * 52200845) ^ -763540046;
				continue;
			}
			case 3u:
				goto IL_00b8;
			case 1u:
			{
				GameObject val = (GameObject)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2219881756u));
				Type typeObject = LuaScriptMgr.GetTypeObject(L, 2);
				Component[] o = _202C_206E_202B_200D_202C_200F_200D_200B_202C_202A_202E_200C_200D_206F_200E_200E_202B_200F_206F_200F_200B_200E_200E_200D_206D_200F_202D_200D_202D_206A_206A_200C_200C_206E_206E_200D_206C_200E_206D_200F_202E(val, typeObject);
				LuaScriptMgr.PushArray(L, o);
				return 1;
			}
			default:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2304191828u));
				return 0;
			}
			break;
		}
		goto IL_000e;
		IL_00b8:
		int num4;
		if (num != 3)
		{
			num2 = -1233358618;
			num4 = num2;
		}
		else
		{
			num2 = -787152046;
			num4 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetComponentsInParent(IntPtr L)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		if (num == 2)
		{
			goto IL_000e;
		}
		goto IL_0091;
		IL_000e:
		int num2 = 1800979815;
		goto IL_0013;
		IL_0013:
		GameObject val2 = default(GameObject);
		Component[] o2 = default(Component[]);
		GameObject val = default(GameObject);
		Type typeObject = default(Type);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ 0x7B7A6D2C)) % 10)
			{
			case 4u:
				break;
			case 3u:
				val2 = (GameObject)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1889101405u));
				num2 = (int)((num3 * 1219414837) ^ 0x748BB205);
				continue;
			case 5u:
				LuaScriptMgr.PushArray(L, o2);
				return 1;
			case 7u:
				goto IL_0091;
			case 8u:
				val = (GameObject)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3383417257u));
				typeObject = LuaScriptMgr.GetTypeObject(L, 2);
				num2 = ((int)num3 * -392482964) ^ 0x30F80051;
				continue;
			case 1u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3649480975u));
				num2 = 1654413428;
				continue;
			case 0u:
			{
				Type typeObject2 = LuaScriptMgr.GetTypeObject(L, 2);
				o2 = _200B_206E_202C_202B_206C_200C_202A_202A_200B_200D_202C_202A_206C_206E_200F_202A_206D_202E_200F_200C_200C_206E_200E_200C_202C_206A_202D_202A_200B_202B_200C_200F_202D_202B_200C_206B_206F_202C_200F_202B_202E(val2, typeObject2);
				num2 = (int)(num3 * 1391970109) ^ -1233773803;
				continue;
			}
			case 9u:
			{
				bool boolean = LuaScriptMgr.GetBoolean(L, 3);
				Component[] o = _206C_200E_206C_202C_206C_200D_202E_202E_200D_206C_202C_202A_206B_202E_206D_202A_200E_200D_200F_200D_200B_202C_202D_202C_202C_202D_200D_206A_206C_202C_206B_206C_206B_206D_206F_200D_206C_206F_202E_202A_202E(val, typeObject, boolean);
				LuaScriptMgr.PushArray(L, o);
				num2 = (int)(num3 * 921783545) ^ -445090759;
				continue;
			}
			case 2u:
				return 1;
			default:
				return 0;
			}
			break;
		}
		goto IL_000e;
		IL_0091:
		int num4;
		if (num == 3)
		{
			num2 = 832363472;
			num4 = num2;
		}
		else
		{
			num2 = 1426894735;
			num4 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SetActive(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		GameObject val = (GameObject)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2219881756u));
		bool boolean = LuaScriptMgr.GetBoolean(L, 2);
		while (true)
		{
			int num = -1095173037;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1369586710)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_0048;
				default:
					return 0;
				}
				break;
				IL_0048:
				_200C_206B_202B_200F_206C_206C_202E_202D_202E_206B_202C_202C_206D_206F_202A_202E_200F_202C_206A_200C_206E_202B_206A_202D_206B_206E_202A_202C_206B_200B_202C_206E_200D_202C_202A_202E_202E_200F_202C_202B_202E(val, boolean);
				num = ((int)num2 * -1121197866) ^ -1513618309;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int CompareTag(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		GameObject val = (GameObject)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3225758075u));
		string luaString = LuaScriptMgr.GetLuaString(L, 2);
		bool b = default(bool);
		while (true)
		{
			int num = 364580778;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2F377DAB)) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_0048;
				default:
					LuaScriptMgr.Push(L, b);
					return 1;
				}
				break;
				IL_0048:
				b = _202D_206B_206D_206A_200C_206A_202B_200C_206C_206B_200C_200F_200F_202D_202C_202D_206C_206F_202C_202C_200E_200C_206D_200C_200E_206B_202A_202B_202E_206B_202A_206E_200D_200B_206B_202A_206F_200E_202B_206A_202E(val, luaString);
				num = (int)((num2 * 386942082) ^ 0x35A86B9F);
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int FindGameObjectWithTag(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string luaString = default(string);
		while (true)
		{
			int num = -1280514757;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -875026186)) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_0029;
				default:
				{
					GameObject obj = _206D_202B_202B_202E_200B_206C_206E_200C_202B_202C_202C_202C_202E_200F_202A_206B_200D_202D_200D_200E_200C_200E_206E_202B_200E_202C_206C_200F_206C_206A_202E_202C_200F_206F_202A_200D_202B_202E_200C_202E_202E(luaString);
					LuaScriptMgr.Push(L, (Object)(object)obj);
					return 1;
				}
				}
				break;
				IL_0029:
				luaString = LuaScriptMgr.GetLuaString(L, 1);
				num = ((int)num2 * -1559900918) ^ 0x3AB5F67;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int FindWithTag(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string luaString = default(string);
		GameObject obj = default(GameObject);
		while (true)
		{
			int num = 1112950508;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2A6004E5)) % 5)
				{
				case 4u:
					break;
				case 3u:
					luaString = LuaScriptMgr.GetLuaString(L, 1);
					num = (int)(num2 * 1254146176) ^ -2013769806;
					continue;
				case 1u:
					LuaScriptMgr.Push(L, (Object)(object)obj);
					num = (int)(num2 * 585031818) ^ -1353394548;
					continue;
				case 2u:
					obj = _206B_206D_206C_202E_206B_206F_202C_200D_206A_206C_206F_202E_206E_202C_200C_202A_206B_200B_206B_200F_202C_202D_206C_206F_202D_200C_200F_206D_206B_206B_200F_202B_206D_200B_206F_206F_206D_200C_206B_200F_202E(luaString);
					num = ((int)num2 * -462735759) ^ 0x2949E07;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int FindGameObjectsWithTag(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string luaString = LuaScriptMgr.GetLuaString(L, 1);
		GameObject[] o = _200F_200D_202E_206C_206A_200C_200F_206F_200F_202D_202B_206E_202B_206F_200C_206A_206B_206E_206B_202E_200B_200C_206C_206C_200D_202B_200E_202A_206B_200D_200F_202E_206D_206A_206E_206A_206B_200E_200E_206E_202E(luaString);
		LuaScriptMgr.PushArray(L, o);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SendMessageUpwards(IntPtr L)
	{
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		if (num == 2)
		{
			goto IL_000e;
		}
		goto IL_013c;
		IL_000e:
		int num2 = 1622239565;
		goto IL_0013;
		IL_0013:
		GameObject val = default(GameObject);
		string luaString = default(string);
		object varObject = default(object);
		SendMessageOptions val4 = default(SendMessageOptions);
		GameObject val6 = default(GameObject);
		string luaString2 = default(string);
		string text2 = default(string);
		object varObject2 = default(object);
		GameObject val2 = default(GameObject);
		GameObject val3 = default(GameObject);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ 0x3DED5813)) % 20)
			{
			case 19u:
				break;
			case 7u:
				goto IL_0079;
			case 5u:
			{
				int num6;
				int num7;
				if (!LuaScriptMgr.CheckTypes(L, 1, _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(typeof(GameObject).TypeHandle), _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(typeof(string).TypeHandle), _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(typeof(SendMessageOptions).TypeHandle)))
				{
					num6 = -184491653;
					num7 = num6;
				}
				else
				{
					num6 = -344958468;
					num7 = num6;
				}
				num2 = num6 ^ ((int)num3 * -1184078912);
				continue;
			}
			case 13u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1842830845u));
				num2 = 1194756394;
				continue;
			case 8u:
				_200C_202E_206C_202C_202D_206A_200D_202D_202D_200D_200E_206E_206E_206C_206F_202A_206A_200D_206E_202A_206F_200B_206F_202A_206C_200B_202B_200D_200B_206C_200E_206F_206F_206D_202A_202C_206B_206C_200C_206F_202E(val, luaString);
				return 0;
			case 15u:
				varObject = LuaScriptMgr.GetVarObject(L, 3);
				val4 = (SendMessageOptions)(int)LuaScriptMgr.GetNetObject(L, 4, _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(typeof(SendMessageOptions).TypeHandle));
				num2 = (int)((num3 * 872505249) ^ 0x6E31A586);
				continue;
			case 9u:
				goto IL_013c;
			case 11u:
				val6 = (GameObject)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3383417257u));
				num2 = ((int)num3 * -1673958898) ^ 0x7DA5F439;
				continue;
			case 3u:
				luaString2 = LuaScriptMgr.GetLuaString(L, 2);
				num2 = (int)(num3 * 1491758300) ^ -1604474104;
				continue;
			case 14u:
				text2 = LuaScriptMgr.GetString(L, 2);
				varObject2 = LuaScriptMgr.GetVarObject(L, 3);
				num2 = (int)((num3 * 1303294548) ^ 0x27D7D723);
				continue;
			case 12u:
				goto IL_01bf;
			case 0u:
				_200B_200D_200B_206C_206D_206D_200F_200C_206E_206D_200F_200B_206C_206F_202A_202C_200C_200C_200D_202C_202B_200D_202B_202C_206C_206E_202A_202D_200B_200C_200C_206D_200E_200F_202B_206B_200B_202C_200B_206B_202E(val2, text2, varObject2);
				return 0;
			case 1u:
				return 0;
			case 4u:
			{
				string text = LuaScriptMgr.GetString(L, 2);
				SendMessageOptions val5 = (SendMessageOptions)(int)LuaScriptMgr.GetLuaObject(L, 3);
				_206E_206C_202E_206A_206C_200D_206C_206B_202B_206A_206E_200E_206E_206D_202D_206F_200E_200B_202C_206A_206F_206B_202D_202D_202D_202C_202A_200D_206F_200C_200E_200F_202C_206F_200D_206D_200C_200C_206B_202C_202E(val6, text, val5);
				num2 = (int)((num3 * 1580065531) ^ 0x6228DDF2);
				continue;
			}
			case 2u:
				val3 = (GameObject)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1889101405u));
				num2 = (int)((num3 * 1243357479) ^ 0x37B9BFE6);
				continue;
			case 16u:
			{
				int num4;
				int num5;
				if (!LuaScriptMgr.CheckTypes(L, 1, _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(typeof(GameObject).TypeHandle), _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(typeof(string).TypeHandle), _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(typeof(object).TypeHandle)))
				{
					num4 = 458459184;
					num5 = num4;
				}
				else
				{
					num4 = 701034441;
					num5 = num4;
				}
				num2 = num4 ^ (int)(num3 * 1836504001);
				continue;
			}
			case 6u:
				_202A_206B_206F_206E_202B_200D_200C_200F_206B_202D_206B_206B_200C_202E_206D_200F_202C_202A_202B_206A_206E_206C_202D_200D_202C_202E_206E_202C_200E_202A_206C_206F_206D_200D_200F_202E_206F_206D_200C_206C_202E(val3, luaString2, varObject, val4);
				return 0;
			case 10u:
				val2 = (GameObject)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3543467064u));
				num2 = ((int)num3 * -841523195) ^ -1790869765;
				continue;
			case 18u:
				val = (GameObject)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3543467064u));
				luaString = LuaScriptMgr.GetLuaString(L, 2);
				num2 = (int)((num3 * 1636617206) ^ 0xAA6ACCB);
				continue;
			default:
				return 0;
			}
			break;
			IL_01bf:
			int num8;
			if (num != 3)
			{
				num2 = 2001366916;
				num8 = num2;
			}
			else
			{
				num2 = 1297308839;
				num8 = num2;
			}
			continue;
			IL_0079:
			int num9;
			if (num != 4)
			{
				num2 = 530717258;
				num9 = num2;
			}
			else
			{
				num2 = 41194613;
				num9 = num2;
			}
		}
		goto IL_000e;
		IL_013c:
		int num10;
		if (num == 3)
		{
			num2 = 1937282062;
			num10 = num2;
		}
		else
		{
			num2 = 444902843;
			num10 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SendMessage(IntPtr L)
	{
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		string text2 = default(string);
		GameObject val = default(GameObject);
		string text = default(string);
		object varObject2 = default(object);
		GameObject val2 = default(GameObject);
		SendMessageOptions val3 = default(SendMessageOptions);
		object varObject = default(object);
		GameObject val4 = default(GameObject);
		string luaString = default(string);
		while (true)
		{
			int num2 = 1993622896;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x5E689469)) % 23)
				{
				case 5u:
					break;
				case 6u:
					text2 = LuaScriptMgr.GetString(L, 2);
					num2 = (int)(num3 * 570961023) ^ -475285949;
					continue;
				case 16u:
				{
					int num12;
					if (num != 3)
					{
						num2 = 1814355616;
						num12 = num2;
					}
					else
					{
						num2 = 1046945972;
						num12 = num2;
					}
					continue;
				}
				case 1u:
					_206A_206D_202D_206C_202D_202C_202B_206B_206D_206C_202B_202A_206A_200C_202D_200F_206C_202D_202B_200F_202C_206B_206F_206C_202E_206B_206F_200F_200F_202B_202B_200C_206B_200B_200D_202E_202D_206E_202A_206F_202E(val, text, varObject2);
					return 0;
				case 4u:
					_206C_200D_206D_206C_206A_202A_202E_202B_200B_202A_206B_202D_206E_206D_200D_206F_200F_200F_200B_206E_206A_206D_206E_206B_206A_200B_200D_200D_202E_202C_202A_206A_206E_206D_200E_202D_200C_206C_202B_206B_202E(val2, text2, val3);
					num2 = (int)(num3 * 763361755) ^ -1562755571;
					continue;
				case 3u:
				{
					int num11;
					if (num != 4)
					{
						num2 = 1717381840;
						num11 = num2;
					}
					else
					{
						num2 = 2023362960;
						num11 = num2;
					}
					continue;
				}
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(448584979u));
					num2 = 282954972;
					continue;
				case 20u:
				{
					int num5;
					int num6;
					if (num == 2)
					{
						num5 = 126969299;
						num6 = num5;
					}
					else
					{
						num5 = 46252454;
						num6 = num5;
					}
					num2 = num5 ^ ((int)num3 * -433049606);
					continue;
				}
				case 12u:
					varObject = LuaScriptMgr.GetVarObject(L, 3);
					num2 = (int)((num3 * 1330207057) ^ 0x56A85AA7);
					continue;
				case 22u:
					val2 = (GameObject)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3383417257u));
					num2 = ((int)num3 * -1173788170) ^ 0x62D1D817;
					continue;
				case 0u:
				{
					SendMessageOptions val6 = (SendMessageOptions)(int)LuaScriptMgr.GetNetObject(L, 4, _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(typeof(SendMessageOptions).TypeHandle));
					_200F_202A_202A_206D_206C_202C_206F_206A_206A_202B_202D_202E_202D_202E_206B_206B_202E_206E_200B_206F_200D_202E_200D_206A_202C_206C_206F_206F_202C_202A_202C_200D_206F_206F_206E_200B_200B_202C_200F_202C_202E(val4, luaString, varObject, val6);
					num2 = ((int)num3 * -945418153) ^ -1772989648;
					continue;
				}
				case 15u:
				{
					int num9;
					int num10;
					if (LuaScriptMgr.CheckTypes(L, 1, _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(typeof(GameObject).TypeHandle), _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(typeof(string).TypeHandle), _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(typeof(SendMessageOptions).TypeHandle)))
					{
						num9 = -73074796;
						num10 = num9;
					}
					else
					{
						num9 = -2045734686;
						num10 = num9;
					}
					num2 = num9 ^ (int)(num3 * 63965738);
					continue;
				}
				case 8u:
					varObject2 = LuaScriptMgr.GetVarObject(L, 3);
					num2 = ((int)num3 * -1640913727) ^ -1467157891;
					continue;
				case 17u:
				{
					GameObject val5 = (GameObject)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2219881756u));
					string luaString2 = LuaScriptMgr.GetLuaString(L, 2);
					_206C_206A_206D_200D_200B_206A_200B_200B_200F_202E_202A_200F_202B_200F_206F_206B_206D_202B_200B_202D_206E_202E_206A_200E_200B_200D_206B_200E_200E_206C_202B_206B_206A_200B_206E_202B_200D_200F_202A_202E_202E(val5, luaString2);
					return 0;
				}
				case 11u:
					val4 = (GameObject)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3543467064u));
					luaString = LuaScriptMgr.GetLuaString(L, 2);
					num2 = ((int)num3 * -2054045866) ^ 0x3D4712BA;
					continue;
				case 10u:
					val = (GameObject)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2219881756u));
					num2 = (int)(num3 * 1803220754) ^ -112609779;
					continue;
				case 21u:
					return 0;
				case 18u:
					return 0;
				case 13u:
					text = LuaScriptMgr.GetString(L, 2);
					num2 = (int)((num3 * 900875855) ^ 0x443695EB);
					continue;
				case 2u:
					val3 = (SendMessageOptions)(int)LuaScriptMgr.GetLuaObject(L, 3);
					num2 = ((int)num3 * -517604412) ^ 0x428EA238;
					continue;
				case 14u:
				{
					int num7;
					int num8;
					if (LuaScriptMgr.CheckTypes(L, 1, _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(typeof(GameObject).TypeHandle), _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(typeof(string).TypeHandle), _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(typeof(object).TypeHandle)))
					{
						num7 = -1840719294;
						num8 = num7;
					}
					else
					{
						num7 = -494848838;
						num8 = num7;
					}
					num2 = num7 ^ (int)(num3 * 764044325);
					continue;
				}
				case 19u:
				{
					int num4;
					if (num != 3)
					{
						num2 = 1723086427;
						num4 = num2;
					}
					else
					{
						num2 = 1211940196;
						num4 = num2;
					}
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
	private static int BroadcastMessage(IntPtr L)
	{
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		if (num == 2)
		{
			goto IL_000e;
		}
		goto IL_00eb;
		IL_000e:
		int num2 = 306976038;
		goto IL_0013;
		IL_0013:
		GameObject val5 = default(GameObject);
		string luaString = default(string);
		object varObject = default(object);
		string luaString2 = default(string);
		string text2 = default(string);
		GameObject val6 = default(GameObject);
		SendMessageOptions val2 = default(SendMessageOptions);
		GameObject val3 = default(GameObject);
		string text = default(string);
		object varObject2 = default(object);
		GameObject val = default(GameObject);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ 0x1FF86FFD)) % 25)
			{
			case 16u:
				break;
			case 3u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3320605291u));
				num2 = 2088199291;
				continue;
			case 6u:
			{
				int num6;
				int num7;
				if (!LuaScriptMgr.CheckTypes(L, 1, _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(typeof(GameObject).TypeHandle), _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(typeof(string).TypeHandle), _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(typeof(SendMessageOptions).TypeHandle)))
				{
					num6 = -880733756;
					num7 = num6;
				}
				else
				{
					num6 = -1749342402;
					num7 = num6;
				}
				num2 = num6 ^ (int)(num3 * 1647329576);
				continue;
			}
			case 10u:
				goto IL_00eb;
			case 23u:
				val5 = (GameObject)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2219881756u));
				num2 = (int)(num3 * 22836446) ^ -2053328396;
				continue;
			case 5u:
				luaString = LuaScriptMgr.GetLuaString(L, 2);
				varObject = LuaScriptMgr.GetVarObject(L, 3);
				num2 = ((int)num3 * -846444492) ^ -1115904891;
				continue;
			case 1u:
				luaString2 = LuaScriptMgr.GetLuaString(L, 2);
				num2 = ((int)num3 * -626148239) ^ 0x22922E3E;
				continue;
			case 20u:
				text2 = LuaScriptMgr.GetString(L, 2);
				num2 = ((int)num3 * -671815897) ^ 0x1799578F;
				continue;
			case 15u:
				_202C_200D_206D_200B_200B_202D_206D_202E_206A_206F_200E_200B_206E_200C_206C_206F_206C_206A_202B_202C_200B_200F_202B_206F_202A_202D_206F_206C_202E_200E_206D_206B_200F_200C_202B_200D_200F_200C_202A_206C_202E(val6, text2, val2);
				return 0;
			case 24u:
				return 0;
			case 2u:
				_206A_206E_206A_206B_202C_202B_206C_200C_202B_202E_202C_206D_200C_200E_206C_206F_202D_202C_200F_202E_200D_206A_200E_200E_206C_200B_206B_202B_200E_202E_206A_200D_206C_206F_206D_200E_206B_200B_206F_206D_202E(val3, luaString2);
				num2 = (int)((num3 * 61044112) ^ 0x5137F919);
				continue;
			case 11u:
				return 0;
			case 19u:
				val6 = (GameObject)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3383417257u));
				num2 = ((int)num3 * -1818758914) ^ 0x7F2BCC2A;
				continue;
			case 21u:
				goto IL_0217;
			case 12u:
				goto IL_022f;
			case 22u:
			{
				int num4;
				int num5;
				if (LuaScriptMgr.CheckTypes(L, 1, _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(typeof(GameObject).TypeHandle), _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(typeof(string).TypeHandle), _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(typeof(object).TypeHandle)))
				{
					num4 = -1911607262;
					num5 = num4;
				}
				else
				{
					num4 = -1559748295;
					num5 = num4;
				}
				num2 = num4 ^ (int)(num3 * 543575534);
				continue;
			}
			case 9u:
				_200B_202D_206A_202D_202C_202A_200D_206B_200B_206D_200B_200F_206C_206B_206F_202B_202C_206B_202E_200F_206D_206F_206E_202D_200F_202E_200B_202A_206B_200F_200C_200B_202C_206C_202E_206B_206C_202E_200F_202E(val5, text, varObject2);
				num2 = (int)((num3 * 8220878) ^ 0x6804B135);
				continue;
			case 17u:
				varObject2 = LuaScriptMgr.GetVarObject(L, 3);
				num2 = ((int)num3 * -743228663) ^ 0x61FCF592;
				continue;
			case 8u:
				text = LuaScriptMgr.GetString(L, 2);
				num2 = (int)(num3 * 139407946) ^ -682617258;
				continue;
			case 4u:
			{
				SendMessageOptions val4 = (SendMessageOptions)(int)LuaScriptMgr.GetNetObject(L, 4, _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(typeof(SendMessageOptions).TypeHandle));
				_202A_206C_200C_200D_200C_200B_206A_206D_200B_202B_206F_202A_202D_206A_202D_206A_200E_202E_202E_206B_200C_206D_202E_202D_206E_200D_200D_202B_206F_202D_200F_200D_206F_202A_200D_202A_202C_206B_206E_202A_202E(val, luaString, varObject, val4);
				num2 = ((int)num3 * -626406509) ^ -99545748;
				continue;
			}
			case 14u:
				val3 = (GameObject)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2219881756u));
				num2 = (int)(num3 * 923679032) ^ -1070599163;
				continue;
			case 13u:
				return 0;
			case 0u:
				val2 = (SendMessageOptions)(int)LuaScriptMgr.GetLuaObject(L, 3);
				num2 = ((int)num3 * -1529389539) ^ -523990244;
				continue;
			case 18u:
				val = (GameObject)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1889101405u));
				num2 = ((int)num3 * -689811734) ^ -894691014;
				continue;
			default:
				return 0;
			}
			break;
			IL_022f:
			int num8;
			if (num == 4)
			{
				num2 = 631765510;
				num8 = num2;
			}
			else
			{
				num2 = 1376398611;
				num8 = num2;
			}
			continue;
			IL_0217:
			int num9;
			if (num != 3)
			{
				num2 = 206857523;
				num9 = num2;
			}
			else
			{
				num2 = 2110503966;
				num9 = num2;
			}
		}
		goto IL_000e;
		IL_00eb:
		int num10;
		if (num != 3)
		{
			num2 = 1847402804;
			num10 = num2;
		}
		else
		{
			num2 = 500708283;
			num10 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int AddComponent(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		GameObject val = default(GameObject);
		Type typeObject = default(Type);
		Component obj = default(Component);
		while (true)
		{
			int num = -1352877730;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2103065049)) % 4)
				{
				case 3u:
					break;
				case 1u:
					val = (GameObject)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3383417257u));
					typeObject = LuaScriptMgr.GetTypeObject(L, 2);
					num = (int)((num2 * 1772744659) ^ 0x2659C082);
					continue;
				case 2u:
					obj = _200B_202D_206C_206D_200D_206E_200F_202C_200C_206C_206B_206D_206F_200E_200E_206B_202D_200C_206A_200F_202A_200D_200D_200B_206A_202A_202A_202D_202B_202C_202E_202A_202A_200F_202B_200C_200F_206D_206D_206D_202E(val, typeObject);
					num = ((int)num2 * -933807184) ^ -1151022537;
					continue;
				default:
					LuaScriptMgr.Push(L, (Object)(object)obj);
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Find(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string luaString = default(string);
		GameObject obj = default(GameObject);
		while (true)
		{
			int num = -1950306515;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -844559693)) % 5)
				{
				case 0u:
					break;
				case 3u:
					luaString = LuaScriptMgr.GetLuaString(L, 1);
					num = ((int)num2 * -2131300387) ^ 0x1D71B37A;
					continue;
				case 4u:
					obj = _200F_206B_200C_202A_202C_202B_206E_206D_200C_200C_200E_206F_200D_202A_206D_206E_200C_202E_206F_206F_202D_202A_200C_200D_206A_202C_206A_202E_202C_206D_206F_202B_200E_202C_206E_202E_206D_200F_200D_202D_202E(luaString);
					num = ((int)num2 * -2035361413) ^ -1860078740;
					continue;
				case 1u:
					LuaScriptMgr.Push(L, (Object)(object)obj);
					num = ((int)num2 * -526859790) ^ 0x2B0D20AA;
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
		bool b = default(bool);
		while (true)
		{
			int num = -1816480181;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -758840694)) % 4)
				{
				case 3u:
					break;
				case 1u:
				{
					object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
					Object val = (Object)((luaObject is Object) ? luaObject : null);
					object luaObject2 = LuaScriptMgr.GetLuaObject(L, 2);
					Object val2 = (Object)((luaObject2 is Object) ? luaObject2 : null);
					b = _202B_200F_202A_206F_206F_206C_200E_200B_200C_206F_200F_206B_202B_206C_200E_206F_200C_202B_206A_206F_202E_206A_206E_206A_202A_206D_206E_200E_206C_200D_200D_206E_202C_200B_200F_200D_206C_200C_202D_202E(val, val2);
					num = (int)((num2 * 1438122502) ^ 0x479AF1E4);
					continue;
				}
				case 0u:
					LuaScriptMgr.Push(L, b);
					num = (int)(num2 * 553732789) ^ -865555772;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	static Type _206F_206D_202D_202A_202E_200F_200F_200D_202B_202B_206F_202D_202A_206A_202D_206E_200E_206B_202C_206F_202D_206F_202A_206F_206B_206B_202B_200F_202D_206C_206E_206D_202A_202B_200C_202C_202A_202B_202D_200D_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static GameObject _202D_202C_206F_206E_206C_206E_206D_202D_206B_200B_206D_200D_206E_202D_206C_202B_202A_206B_200C_200B_206C_200B_202D_202E_206B_206D_206C_202A_202E_206A_202A_202B_200D_200E_202C_202B_206E_206A_200E_200F_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new GameObject();
	}

	static GameObject _202D_206D_202C_202C_206B_206A_206E_202E_202B_202E_200D_200C_202E_202C_202C_206F_206E_200D_200F_202C_206D_202B_206E_202B_206F_206D_200E_200F_200B_202A_200B_200B_206E_200B_206F_202A_202C_200E_200F_202E(string P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new GameObject(P_0);
	}

	static GameObject _206B_202A_206E_202A_206F_200B_200E_206F_206D_200D_206F_202E_200C_206D_206D_206C_200D_202B_206A_202D_202D_206E_206E_206E_206A_202C_206D_202E_202B_202A_206A_200B_202E_206C_206B_202A_200F_202B_200C_200E_202E(string P_0, Type[] P_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new GameObject(P_0, P_1);
	}

	static bool _202B_200F_202A_206F_206F_206C_200E_200B_200C_206F_200F_206B_202B_206C_200E_206F_200C_202B_206A_206F_202E_206A_206E_206A_202A_206D_206E_200E_206C_200D_200D_206E_202C_200B_200F_200D_206C_200C_202D_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static Transform _200B_206B_206F_206B_206C_200C_200C_206A_200E_206E_202E_200B_202C_206F_206C_200B_202A_202B_206A_206D_200C_200F_200E_200F_206E_200F_206B_206C_200B_206A_200B_206F_200E_202A_200B_200F_200E_206C_200E_200D_202E(GameObject P_0)
	{
		return P_0.transform;
	}

	static int _200C_202E_206B_206C_200F_206B_206E_206F_200C_206C_200B_202C_202D_206D_200B_206D_202D_206F_200D_202A_206A_200E_206B_202E_202E_202D_202A_206D_206E_202D_200C_202E_200C_206B_200C_200F_202D_206D_200C_206F_202E(GameObject P_0)
	{
		return P_0.layer;
	}

	static bool _206B_202C_206F_206B_202C_206C_200F_202B_202A_206E_202C_202E_206E_200B_202A_200E_206F_200B_202B_206C_202E_200F_200B_200D_206E_202C_206B_202A_202D_200E_200C_206C_206D_202E_206A_202B_200E_200F_200B_206A_202E(GameObject P_0)
	{
		return P_0.activeSelf;
	}

	static bool _206B_206C_206D_200E_202A_206E_202A_202D_202B_202A_206E_200D_202C_206F_206A_200C_206C_206B_206F_206F_200B_206D_206D_200E_200B_206A_200D_202D_202C_200D_200B_200D_206E_202D_202B_200E_206B_200E_200D_202B_202E(GameObject P_0)
	{
		return P_0.activeInHierarchy;
	}

	static bool _202E_206D_202B_200F_202E_206C_206B_200C_202C_200C_206D_200B_200D_200D_200B_202D_206D_200F_206D_200E_200F_202C_206A_202A_206A_200B_200C_200F_202D_200B_202B_202E_202D_202C_206A_206F_200B_206B_206A_206B_202E(GameObject P_0)
	{
		return P_0.isStatic;
	}

	static string _206F_202E_206A_202E_200E_206A_206B_200D_200B_202C_206A_202C_206C_200C_200D_206B_202C_206E_200E_206D_206C_200E_200C_202E_202C_202A_202C_206F_206F_206A_202E_202C_206A_200F_200C_200B_206C_206F_206E_206D_202E(GameObject P_0)
	{
		return P_0.tag;
	}

	static GameObject _202E_206A_202D_200B_200C_206B_206A_206C_200C_200F_206C_206B_206C_202E_202A_200E_200B_206D_200F_200E_200D_206F_200E_200E_206B_200E_202B_200D_202B_206F_202D_200E_206D_200E_202E_200E_202B_202A_202A_202E_202E(GameObject P_0)
	{
		return P_0.gameObject;
	}

	static void _206C_200D_206D_202C_202B_200C_202A_202B_200C_200B_202E_200D_206C_202E_200D_200E_206C_202B_206C_200E_206B_206B_202B_200C_206D_202D_206F_200C_202B_200F_200F_206F_202C_206E_206F_206D_202B_202A_206C_202B_202E(GameObject P_0, int P_1)
	{
		P_0.layer = P_1;
	}

	static void _202B_200D_200D_206F_206F_206D_202B_206E_200F_202A_206D_200F_200D_202C_200B_200F_200E_200F_202B_206E_206E_202E_202B_200C_202D_206B_202D_200E_206E_200C_206B_202D_202A_202A_202C_202A_200B_200E_206C_202E_202E(GameObject P_0, bool P_1)
	{
		P_0.isStatic = P_1;
	}

	static void _202C_200D_200F_200E_202B_206C_202C_200B_200D_206E_206F_206D_202E_206D_200B_200C_206F_202C_200F_200B_202A_200C_202C_206F_200B_202B_202C_202E_200C_206E_202E_202D_202A_202A_206B_206B_200C_206A_202E_202E_202E(GameObject P_0, string P_1)
	{
		P_0.tag = P_1;
	}

	static GameObject _200B_202E_202C_202D_202C_200F_206A_206E_206B_206D_202A_202C_202E_202C_206C_202B_202A_200D_200E_200C_202B_206D_200B_206A_206E_200C_206E_202E_200D_200E_202E_200C_206D_206F_200C_202C_200D_202B_200C_206F_202E(PrimitiveType P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return GameObject.CreatePrimitive(P_0);
	}

	static Component _206B_200B_202C_202A_202D_202D_206A_206E_202D_200C_202B_202E_202B_202C_202E_202B_200F_202E_206C_200E_206D_200B_202B_202D_206D_206A_202B_200D_206D_200C_200C_206F_200C_200D_202A_202D_200F_206B_206F_202E_202E(GameObject P_0, string P_1)
	{
		return P_0.GetComponent(P_1);
	}

	static Component _202B_202A_206B_206A_200F_206E_206C_206A_206A_200B_200E_200B_200F_206A_202D_206E_200C_206D_200D_206C_202E_206A_206B_200C_200D_202E_200C_200D_202E_202C_200E_200D_200C_206A_200D_202B_206C_206D_202E_200F_202E(GameObject P_0, Type P_1)
	{
		return P_0.GetComponent(P_1);
	}

	static Component _202A_206B_202C_206F_206F_202B_206E_206E_200C_206A_206F_200C_200B_200B_206A_202E_206D_200F_200D_202C_206F_200C_202E_202A_206D_206C_206F_202B_206B_206A_200C_206D_202E_202D_206F_202D_206A_202D_202D_206B_202E(GameObject P_0, Type P_1)
	{
		return P_0.GetComponentInChildren(P_1);
	}

	static Component _200D_206D_200C_202E_206A_206C_202B_202D_200F_206E_202A_206F_202C_206F_206C_206A_206E_202E_206A_200F_206D_200D_206D_206B_202A_206D_200C_206B_206F_206E_202D_202A_206B_206C_200E_206E_202A_200B_202C_206B_202E(GameObject P_0, Type P_1)
	{
		return P_0.GetComponentInParent(P_1);
	}

	static Component[] _202A_206C_202A_202D_202E_200E_202B_202C_200D_200F_200D_200C_202B_202D_206D_206E_202A_206D_200B_202B_202C_202C_206E_200F_200B_200F_202C_202B_202C_202A_202A_202E_206B_200B_202C_206B_202E_202B_202C_202D_202E(GameObject P_0, Type P_1)
	{
		return P_0.GetComponents(P_1);
	}

	static void _200E_200D_200C_200B_202D_202D_200D_206C_202A_200B_206B_206F_200F_202C_200F_202A_202E_206B_202D_200E_200B_206C_200B_206A_206B_206F_202D_206C_206C_206E_202B_200F_200C_200B_202A_200B_202A_206E_200C_202A_202E(GameObject P_0, Type P_1, List<Component> P_2)
	{
		P_0.GetComponents(P_1, P_2);
	}

	static Component[] _202C_206E_202B_200D_202C_200F_200D_200B_202C_202A_202E_200C_200D_206F_200E_200E_202B_200F_206F_200F_200B_200E_200E_200D_206D_200F_202D_200D_202D_206A_206A_200C_200C_206E_206E_200D_206C_200E_206D_200F_202E(GameObject P_0, Type P_1)
	{
		return P_0.GetComponentsInChildren(P_1);
	}

	static Component[] _206B_202A_202A_200D_202A_206F_206D_206A_206D_206C_206C_200B_206F_206B_206C_206C_200C_206D_200B_202C_206E_202A_206F_206C_200D_206A_206A_206F_202D_200B_202B_206B_200B_202D_206A_202A_200E_206A_200C_202C_202E(GameObject P_0, Type P_1, bool P_2)
	{
		return P_0.GetComponentsInChildren(P_1, P_2);
	}

	static Component[] _200B_206E_202C_202B_206C_200C_202A_202A_200B_200D_202C_202A_206C_206E_200F_202A_206D_202E_200F_200C_200C_206E_200E_200C_202C_206A_202D_202A_200B_202B_200C_200F_202D_202B_200C_206B_206F_202C_200F_202B_202E(GameObject P_0, Type P_1)
	{
		return P_0.GetComponentsInParent(P_1);
	}

	static Component[] _206C_200E_206C_202C_206C_200D_202E_202E_200D_206C_202C_202A_206B_202E_206D_202A_200E_200D_200F_200D_200B_202C_202D_202C_202C_202D_200D_206A_206C_202C_206B_206C_206B_206D_206F_200D_206C_206F_202E_202A_202E(GameObject P_0, Type P_1, bool P_2)
	{
		return P_0.GetComponentsInParent(P_1, P_2);
	}

	static void _200C_206B_202B_200F_206C_206C_202E_202D_202E_206B_202C_202C_206D_206F_202A_202E_200F_202C_206A_200C_206E_202B_206A_202D_206B_206E_202A_202C_206B_200B_202C_206E_200D_202C_202A_202E_202E_200F_202C_202B_202E(GameObject P_0, bool P_1)
	{
		P_0.SetActive(P_1);
	}

	static bool _202D_206B_206D_206A_200C_206A_202B_200C_206C_206B_200C_200F_200F_202D_202C_202D_206C_206F_202C_202C_200E_200C_206D_200C_200E_206B_202A_202B_202E_206B_202A_206E_200D_200B_206B_202A_206F_200E_202B_206A_202E(GameObject P_0, string P_1)
	{
		return P_0.CompareTag(P_1);
	}

	static GameObject _206D_202B_202B_202E_200B_206C_206E_200C_202B_202C_202C_202C_202E_200F_202A_206B_200D_202D_200D_200E_200C_200E_206E_202B_200E_202C_206C_200F_206C_206A_202E_202C_200F_206F_202A_200D_202B_202E_200C_202E_202E(string P_0)
	{
		return GameObject.FindGameObjectWithTag(P_0);
	}

	static GameObject _206B_206D_206C_202E_206B_206F_202C_200D_206A_206C_206F_202E_206E_202C_200C_202A_206B_200B_206B_200F_202C_202D_206C_206F_202D_200C_200F_206D_206B_206B_200F_202B_206D_200B_206F_206F_206D_200C_206B_200F_202E(string P_0)
	{
		return GameObject.FindWithTag(P_0);
	}

	static GameObject[] _200F_200D_202E_206C_206A_200C_200F_206F_200F_202D_202B_206E_202B_206F_200C_206A_206B_206E_206B_202E_200B_200C_206C_206C_200D_202B_200E_202A_206B_200D_200F_202E_206D_206A_206E_206A_206B_200E_200E_206E_202E(string P_0)
	{
		return GameObject.FindGameObjectsWithTag(P_0);
	}

	static void _200C_202E_206C_202C_202D_206A_200D_202D_202D_200D_200E_206E_206E_206C_206F_202A_206A_200D_206E_202A_206F_200B_206F_202A_206C_200B_202B_200D_200B_206C_200E_206F_206F_206D_202A_202C_206B_206C_200C_206F_202E(GameObject P_0, string P_1)
	{
		P_0.SendMessageUpwards(P_1);
	}

	static void _206E_206C_202E_206A_206C_200D_206C_206B_202B_206A_206E_200E_206E_206D_202D_206F_200E_200B_202C_206A_206F_206B_202D_202D_202D_202C_202A_200D_206F_200C_200E_200F_202C_206F_200D_206D_200C_200C_206B_202C_202E(GameObject P_0, string P_1, SendMessageOptions P_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		P_0.SendMessageUpwards(P_1, P_2);
	}

	static void _200B_200D_200B_206C_206D_206D_200F_200C_206E_206D_200F_200B_206C_206F_202A_202C_200C_200C_200D_202C_202B_200D_202B_202C_206C_206E_202A_202D_200B_200C_200C_206D_200E_200F_202B_206B_200B_202C_200B_206B_202E(GameObject P_0, string P_1, object P_2)
	{
		P_0.SendMessageUpwards(P_1, P_2);
	}

	static void _202A_206B_206F_206E_202B_200D_200C_200F_206B_202D_206B_206B_200C_202E_206D_200F_202C_202A_202B_206A_206E_206C_202D_200D_202C_202E_206E_202C_200E_202A_206C_206F_206D_200D_200F_202E_206F_206D_200C_206C_202E(GameObject P_0, string P_1, object P_2, SendMessageOptions P_3)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		P_0.SendMessageUpwards(P_1, P_2, P_3);
	}

	static void _206C_206A_206D_200D_200B_206A_200B_200B_200F_202E_202A_200F_202B_200F_206F_206B_206D_202B_200B_202D_206E_202E_206A_200E_200B_200D_206B_200E_200E_206C_202B_206B_206A_200B_206E_202B_200D_200F_202A_202E_202E(GameObject P_0, string P_1)
	{
		P_0.SendMessage(P_1);
	}

	static void _206C_200D_206D_206C_206A_202A_202E_202B_200B_202A_206B_202D_206E_206D_200D_206F_200F_200F_200B_206E_206A_206D_206E_206B_206A_200B_200D_200D_202E_202C_202A_206A_206E_206D_200E_202D_200C_206C_202B_206B_202E(GameObject P_0, string P_1, SendMessageOptions P_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		P_0.SendMessage(P_1, P_2);
	}

	static void _206A_206D_202D_206C_202D_202C_202B_206B_206D_206C_202B_202A_206A_200C_202D_200F_206C_202D_202B_200F_202C_206B_206F_206C_202E_206B_206F_200F_200F_202B_202B_200C_206B_200B_200D_202E_202D_206E_202A_206F_202E(GameObject P_0, string P_1, object P_2)
	{
		P_0.SendMessage(P_1, P_2);
	}

	static void _200F_202A_202A_206D_206C_202C_206F_206A_206A_202B_202D_202E_202D_202E_206B_206B_202E_206E_200B_206F_200D_202E_200D_206A_202C_206C_206F_206F_202C_202A_202C_200D_206F_206F_206E_200B_200B_202C_200F_202C_202E(GameObject P_0, string P_1, object P_2, SendMessageOptions P_3)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		P_0.SendMessage(P_1, P_2, P_3);
	}

	static void _206A_206E_206A_206B_202C_202B_206C_200C_202B_202E_202C_206D_200C_200E_206C_206F_202D_202C_200F_202E_200D_206A_200E_200E_206C_200B_206B_202B_200E_202E_206A_200D_206C_206F_206D_200E_206B_200B_206F_206D_202E(GameObject P_0, string P_1)
	{
		P_0.BroadcastMessage(P_1);
	}

	static void _202C_200D_206D_200B_200B_202D_206D_202E_206A_206F_200E_200B_206E_200C_206C_206F_206C_206A_202B_202C_200B_200F_202B_206F_202A_202D_206F_206C_202E_200E_206D_206B_200F_200C_202B_200D_200F_200C_202A_206C_202E(GameObject P_0, string P_1, SendMessageOptions P_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		P_0.BroadcastMessage(P_1, P_2);
	}

	static void _200B_202D_206A_202D_202C_202A_200D_206B_200B_206D_200B_200F_206C_206B_206F_202B_202C_206B_202E_200F_206D_206F_206E_202D_200F_202E_200B_202A_206B_200F_200C_200B_202C_206C_202E_206B_206C_202E_200F_202E(GameObject P_0, string P_1, object P_2)
	{
		P_0.BroadcastMessage(P_1, P_2);
	}

	static void _202A_206C_200C_200D_200C_200B_206A_206D_200B_202B_206F_202A_202D_206A_202D_206A_200E_202E_202E_206B_200C_206D_202E_202D_206E_200D_200D_202B_206F_202D_200F_200D_206F_202A_200D_202A_202C_206B_206E_202A_202E(GameObject P_0, string P_1, object P_2, SendMessageOptions P_3)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		P_0.BroadcastMessage(P_1, P_2, P_3);
	}

	static Component _200B_202D_206C_206D_200D_206E_200F_202C_200C_206C_206B_206D_206F_200E_200E_206B_202D_200C_206A_200F_202A_200D_200D_200B_206A_202A_202A_202D_202B_202C_202E_202A_202A_200F_202B_200C_200F_206D_206D_206D_202E(GameObject P_0, Type P_1)
	{
		return P_0.AddComponent(P_1);
	}

	static GameObject _200F_206B_200C_202A_202C_202B_206E_206D_200C_200C_200E_206F_200D_202A_206D_206E_200C_202E_206F_206F_202D_202A_200C_200D_206A_202C_206A_202E_202C_206D_206F_202B_200E_202C_206E_202E_206D_200F_200D_202D_202E(string P_0)
	{
		return GameObject.Find(P_0);
	}
}
