using System;
using System.Collections;
using LuaInterface;
using UnityEngine;

public class TransformWrap
{
	private static Type classType = _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(Transform).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[24]
		{
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3831892203u), SetParent),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4253420262u), Translate),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1779855874u), Rotate),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3875271775u), RotateAround),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2335733440u), LookAt),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1773532180u), TransformDirection),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2500864419u), InverseTransformDirection),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(502167914u), TransformVector),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2111748159u), InverseTransformVector),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1332090315u), TransformPoint),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(255872173u), InverseTransformPoint),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(891554306u), DetachChildren),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3710557958u), SetAsFirstSibling),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1149567031u), SetAsLastSibling),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2747848435u), SetSiblingIndex),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2223583511u), GetSiblingIndex),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3474098585u), Find),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1643233609u), IsChildOf),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1492291637u), FindChild),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(625288527u), GetEnumerator),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1757103215u), GetChild),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1621874631u), _202B_202D_202D_206B_202C_206E_200D_202C_206F_202B_206C_206B_200D_202C_202E_206D_206F_202C_200C_200B_206F_200E_202D_200B_202B_200B_200C_202C_200B_200B_200B_206C_200D_200E_206F_206A_206E_206C_202C_202D_202E),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(10103728u), GetClassType),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3465012375u), Lua_Eq)
		};
		LuaField[] fields = new LuaField[17]
		{
			new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(462282353u), get_position, set_position),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3464127871u), get_localPosition, set_localPosition),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1680969102u), get_eulerAngles, set_eulerAngles),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3162938858u), get_localEulerAngles, set_localEulerAngles),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3198064153u), get_right, set_right),
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2358665043u), get_up, set_up),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2058324032u), get_forward, set_forward),
			new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3926874320u), get_rotation, set_rotation),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(500883290u), get_localRotation, set_localRotation),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(765031741u), get_localScale, set_localScale),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2247001497u), get_parent, set_parent),
			new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3877519541u), get_worldToLocalMatrix, null),
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(646265493u), get_localToWorldMatrix, null),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(651825262u), get_root, null),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3540293788u), get_childCount, null),
			new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1940056799u), get_lossyScale, null),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3842177732u), get_hasChanged, set_hasChanged)
		};
		while (true)
		{
			int num = -203723925;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -425808895)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_071d;
				case 1u:
					return;
				}
				break;
				IL_071d:
				LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1770268908u), _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(Transform).TypeHandle), regs, fields, _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(Component).TypeHandle));
				num = (int)((num2 * 300078730) ^ 0x18D8C7CC);
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _202B_202D_202D_206B_202C_206E_200D_202C_206F_202B_206C_206B_200D_202C_202E_206D_206F_202C_200C_200B_206F_200E_202D_200B_202B_200B_200C_202C_200B_200B_200B_206C_200D_200E_206F_206A_206E_206C_202C_202D_202E(IntPtr P_0)
	{
		LuaDLL.luaL_error(P_0, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3568500527u));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_position(IntPtr L)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Transform val = default(Transform);
		while (true)
		{
			int num = 1232935438;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x53BFD44D)) % 6)
				{
				case 2u:
					break;
				case 1u:
				{
					val = (Transform)luaObject;
					int num5;
					int num6;
					if (_202D_200F_202B_206E_202E_206C_206D_202E_202A_202A_202E_202B_200C_202E_202D_200C_200B_202E_206C_206F_206A_200B_206C_206B_206E_206A_202D_200E_200B_206B_206C_200C_206E_200C_206A_200E_206F_206E_200F_206F_202E((Object)(object)val, (Object)null))
					{
						num5 = -600543425;
						num6 = num5;
					}
					else
					{
						num5 = -1194697155;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -62893654);
					continue;
				}
				case 0u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 159888510;
						num4 = num3;
					}
					else
					{
						num3 = 2048680384;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1102829383);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3640693018u));
					num = 1437234499;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1992172423u));
					num = (int)((num2 * 180310962) ^ 0x1644DECD);
					continue;
				default:
					LuaScriptMgr.Push(L, _202D_202B_202D_206C_202A_202D_202A_200E_206A_200D_200F_202C_206A_202B_206C_202D_202A_202B_206C_206E_202B_202C_206D_206C_202D_202D_206B_200F_202C_200F_200E_206C_200F_206B_206A_200E_200B_206D_206C_202C_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_localPosition(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Transform val = (Transform)luaObject;
		while (true)
		{
			int num = 2089708525;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x16FE91CC)) % 8)
				{
				case 4u:
					break;
				case 1u:
				{
					int num5;
					int num6;
					if (_202D_200F_202B_206E_202E_206C_206D_202E_202A_202A_202E_202B_200C_202E_202D_200C_200B_202E_206C_206F_206A_200B_206C_206B_206E_206A_202D_200E_200B_206B_206C_200C_206E_200C_206A_200E_206F_206E_200F_206F_202E((Object)(object)val, (Object)null))
					{
						num5 = 825160110;
						num6 = num5;
					}
					else
					{
						num5 = 159430724;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 916086776);
					continue;
				}
				case 0u:
					LuaScriptMgr.Push(L, _200C_202C_202D_206E_202C_200C_200C_206C_200C_202E_206F_200E_200F_206C_206F_206F_202E_200B_206A_200E_200D_202C_206A_200D_202A_206B_206D_202C_206B_206B_206D_200B_200E_200E_202C_206D_200F_206E_206D_202A_202E(val));
					num = 274503171;
					continue;
				case 5u:
					num = (int)((num2 * 1363673371) ^ 0x6F542FAB);
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1331064136u));
					num = (int)((num2 * 74896765) ^ 0x613943DE);
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2531721006u));
					num = 1906194108;
					continue;
				case 2u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -1974237358;
						num4 = num3;
					}
					else
					{
						num3 = -2055712577;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1780184640);
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
	private static int get_eulerAngles(IntPtr L)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Transform val = default(Transform);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1937614370;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1681455982)) % 8)
				{
				case 5u:
					break;
				case 6u:
					LuaScriptMgr.Push(L, _206F_202A_202B_206A_202E_200C_202D_206F_200C_202C_202B_200E_202A_200C_206B_200E_206F_202C_200D_206B_206A_206E_202E_206B_206B_206A_206F_200D_200E_200B_206F_202E_206A_206F_200C_202C_200D_200E_206F_206D_202E(val));
					num = -1214207835;
					continue;
				case 0u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1252378088) ^ 0x70CBFC3B;
					continue;
				case 4u:
				{
					val = (Transform)luaObject;
					int num5;
					int num6;
					if (_202D_200F_202B_206E_202E_206C_206D_202E_202A_202A_202E_202B_200C_202E_202D_200C_200B_202E_206C_206F_206A_200B_206C_206B_206E_206A_202D_200E_200B_206B_206C_200C_206E_200C_206A_200E_206F_206E_200F_206F_202E((Object)(object)val, (Object)null))
					{
						num5 = 89193558;
						num6 = num5;
					}
					else
					{
						num5 = 756847128;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 2062187155);
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 519309249;
						num4 = num3;
					}
					else
					{
						num3 = 487385928;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 870459281);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3566389512u));
					num = (int)((num2 * 1528421926) ^ 0x75D5300E);
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(611773214u));
					num = -941729604;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_localEulerAngles(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Transform val = (Transform)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1227067703;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1CE06816)) % 8)
				{
				case 3u:
					break;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(514015955u));
					num = 1947705809;
					continue;
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -2035790345) ^ 0x7D9DC49A;
					continue;
				case 7u:
					LuaScriptMgr.Push(L, _206D_202E_202B_202E_200D_202E_206E_202C_202B_200B_202B_202C_200D_202D_202A_206C_206B_200B_202D_202C_202A_206E_206B_200C_200B_202B_206D_200E_202E_202A_206C_206B_206C_206C_200B_200B_200F_200E_202D_206F_202E(val));
					num = 1441095171;
					continue;
				case 0u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -148276760;
						num6 = num5;
					}
					else
					{
						num5 = -1836680548;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 191476792);
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (_202D_200F_202B_206E_202E_206C_206D_202E_202A_202A_202E_202B_200C_202E_202D_200C_200B_202E_206C_206F_206A_200B_206C_206B_206E_206A_202D_200E_200B_206B_206C_200C_206E_200C_206A_200E_206F_206E_200F_206F_202E((Object)(object)val, (Object)null))
					{
						num3 = 753332840;
						num4 = num3;
					}
					else
					{
						num3 = 183828619;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 221041690);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(96078396u));
					num = (int)((num2 * 1557827025) ^ 0x2D6E9E0F);
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_right(IntPtr L)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Transform val = default(Transform);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 696805847;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0xFA6A1DD)) % 10)
				{
				case 7u:
					break;
				case 4u:
					val = (Transform)luaObject;
					num = (int)(num2 * 30075479) ^ -1272922184;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (!_202D_200F_202B_206E_202E_206C_206D_202E_202A_202A_202E_202B_200C_202E_202D_200C_200B_202E_206C_206F_206A_200B_206C_206B_206E_206A_202D_200E_200B_206B_206C_200C_206E_200C_206A_200E_206F_206E_200F_206F_202E((Object)(object)val, (Object)null))
					{
						num5 = 1611529719;
						num6 = num5;
					}
					else
					{
						num5 = 1243406435;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1285577803);
					continue;
				}
				case 2u:
					num = (int)((num2 * 617274341) ^ 0x1DFD1E00);
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(835217152u));
					num = 736517608;
					continue;
				case 1u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 1729214085) ^ 0x7D1F9FEA);
					continue;
				case 8u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -1779247527;
						num4 = num3;
					}
					else
					{
						num3 = -643289503;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -539687227);
					continue;
				}
				case 5u:
					LuaScriptMgr.Push(L, _206F_200C_202E_200D_202C_200C_206F_202A_206E_200B_202B_206D_206F_202D_202E_206D_202D_202C_206D_206E_206C_206B_202C_206D_200D_206B_202A_206B_202A_200F_206A_202B_206B_200C_206D_200C_206D_206C_206A_200D_202E(val));
					num = 1170867262;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2126985020u));
					num = (int)((num2 * 1398616690) ^ 0x55EFE0C9);
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_up(IntPtr L)
	{
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Transform val = default(Transform);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1215471534;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -909732681)) % 10)
				{
				case 8u:
					break;
				case 9u:
					val = (Transform)luaObject;
					num = ((int)num2 * -1693340845) ^ 0x181B10E6;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2144080547u));
					num = -1298600750;
					continue;
				case 7u:
					num = ((int)num2 * -2145504432) ^ -458518622;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (_202D_200F_202B_206E_202E_206C_206D_202E_202A_202A_202E_202B_200C_202E_202D_200C_200B_202E_206C_206F_206A_200B_206C_206B_206E_206A_202D_200E_200B_206B_206C_200C_206E_200C_206A_200E_206F_206E_200F_206F_202E((Object)(object)val, (Object)null))
					{
						num5 = 1502038064;
						num6 = num5;
					}
					else
					{
						num5 = 1986942468;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -647984915);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2257287026u));
					num = (int)((num2 * 1015789335) ^ 0x3EB3EA7C);
					continue;
				case 5u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1469311251) ^ 0x4A8E8470;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -604372176;
						num4 = num3;
					}
					else
					{
						num3 = -1288320411;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1632383829);
					continue;
				}
				case 3u:
					LuaScriptMgr.Push(L, _206C_202D_200F_200E_202A_202A_200E_206A_200E_200C_206F_200B_200D_202D_206B_202B_200F_200F_202B_206B_200D_206D_202D_200E_202C_206C_200E_206B_202B_202D_202D_206C_206E_202C_202B_200F_202B_200D_206C_206F_202E(val));
					num = -1842586997;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_forward(IntPtr L)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		Transform val = default(Transform);
		while (true)
		{
			int num = 140341609;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5A778510)) % 8)
				{
				case 4u:
					break;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2587455916u));
					num = 684867438;
					continue;
				case 0u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 674146232) ^ -759175619;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (!_202D_200F_202B_206E_202E_206C_206D_202E_202A_202A_202E_202B_200C_202E_202D_200C_200B_202E_206C_206F_206A_200B_206C_206B_206E_206A_202D_200E_200B_206B_206C_200C_206E_200C_206A_200E_206F_206E_200F_206F_202E((Object)(object)val, (Object)null))
					{
						num5 = 882058800;
						num6 = num5;
					}
					else
					{
						num5 = 2019815838;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1173498982);
					continue;
				}
				case 5u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 899264949;
						num4 = num3;
					}
					else
					{
						num3 = 1753753304;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1046163622);
					continue;
				}
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(295628877u));
					num = ((int)num2 * -874847829) ^ -568017872;
					continue;
				case 1u:
					val = (Transform)luaObject;
					num = (int)((num2 * 65119816) ^ 0x114F9973);
					continue;
				default:
					LuaScriptMgr.Push(L, _206A_202C_206C_202B_202E_200D_200D_206E_200B_200C_206D_200C_200C_206D_206B_202E_206A_202E_206F_200B_202A_206F_202D_200F_200F_202D_200D_202D_200B_200D_206C_206A_202D_202A_202B_206E_202C_200C_200E_202B_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_rotation(IntPtr L)
	{
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Transform val = default(Transform);
		while (true)
		{
			int num = -730482990;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1069188775)) % 8)
				{
				case 0u:
					break;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1022301286u));
					num = -1450065564;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1077201214u));
					num = (int)(num2 * 779327217) ^ -1223156114;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (_202D_200F_202B_206E_202E_206C_206D_202E_202A_202A_202E_202B_200C_202E_202D_200C_200B_202E_206C_206F_206A_200B_206C_206B_206E_206A_202D_200E_200B_206B_206C_200C_206E_200C_206A_200E_206F_206E_200F_206F_202E((Object)(object)val, (Object)null))
					{
						num5 = 1151900320;
						num6 = num5;
					}
					else
					{
						num5 = 1749313492;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 144693332);
					continue;
				}
				case 1u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -794687862;
						num4 = num3;
					}
					else
					{
						num3 = -464394290;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1663802801);
					continue;
				}
				case 5u:
					LuaScriptMgr.Push(L, _200B_206A_206C_200C_202A_202D_200B_200B_206B_202C_206D_202A_206C_200D_200B_202A_200E_202E_202A_206B_202C_200F_206B_200C_206B_200B_206C_202C_200B_200B_200B_200B_200E_200B_200E_206B_202A_202A_202D_202C_202E(val));
					num = -1388652106;
					continue;
				case 3u:
					val = (Transform)luaObject;
					num = (int)(num2 * 624675857) ^ -1286714210;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_localRotation(IntPtr L)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Transform val = default(Transform);
		while (true)
		{
			int num = -1357004051;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1770857641)) % 6)
				{
				case 0u:
					break;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2391064563u));
					num = ((int)num2 * -882082068) ^ 0x23F28329;
					continue;
				case 3u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -381567124;
						num6 = num5;
					}
					else
					{
						num5 = -1714349176;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -2060219802);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1286449737u));
					num = -1556043403;
					continue;
				case 4u:
				{
					val = (Transform)luaObject;
					int num3;
					int num4;
					if (_202D_200F_202B_206E_202E_206C_206D_202E_202A_202A_202E_202B_200C_202E_202D_200C_200B_202E_206C_206F_206A_200B_206C_206B_206E_206A_202D_200E_200B_206B_206C_200C_206E_200C_206A_200E_206F_206E_200F_206F_202E((Object)(object)val, (Object)null))
					{
						num3 = -1860902948;
						num4 = num3;
					}
					else
					{
						num3 = -48248295;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -983119314);
					continue;
				}
				default:
					LuaScriptMgr.Push(L, _200C_206E_202B_202B_202E_202C_206B_200F_200D_200B_206E_200D_202D_202C_200F_206C_200E_206A_206A_206D_200E_206D_206A_202E_202B_206A_206E_206B_200F_206C_200E_206A_206F_206A_200D_206E_202C_206C_206C_206A_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_localScale(IntPtr L)
	{
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		Transform val = default(Transform);
		while (true)
		{
			int num = 1394607521;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3E28F57A)) % 8)
				{
				case 0u:
					break;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4071846370u));
					num = 1975486623;
					continue;
				case 7u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 654015614) ^ 0x36381B99);
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -647128121;
						num6 = num5;
					}
					else
					{
						num5 = -771192325;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1411972689);
					continue;
				}
				case 4u:
					num = (int)((num2 * 668767489) ^ 0x17BCC41B);
					continue;
				case 3u:
				{
					val = (Transform)luaObject;
					int num3;
					int num4;
					if (!_202D_200F_202B_206E_202E_206C_206D_202E_202A_202A_202E_202B_200C_202E_202D_200C_200B_202E_206C_206F_206A_200B_206C_206B_206E_206A_202D_200E_200B_206B_206C_200C_206E_200C_206A_200E_206F_206E_200F_206F_202E((Object)(object)val, (Object)null))
					{
						num3 = -1086787327;
						num4 = num3;
					}
					else
					{
						num3 = -266231133;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1908619322);
					continue;
				}
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2881625972u));
					num = ((int)num2 * -1069160774) ^ 0x31C0ED4A;
					continue;
				default:
					LuaScriptMgr.Push(L, _200D_200E_200C_200F_202B_200F_200E_206E_200C_200F_206B_206E_202C_200F_200F_202B_206E_200B_202B_200B_200E_206D_200D_206F_206F_200D_202A_206F_200F_202E_200D_202E_202A_202C_202E_206B_206C_202A_206D_206D_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_parent(IntPtr L)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Transform val = default(Transform);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1676677204;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -546024852)) % 10)
				{
				case 8u:
					break;
				case 6u:
					val = (Transform)luaObject;
					num = (int)(num2 * 464857546) ^ -1251635307;
					continue;
				case 5u:
					num = ((int)num2 * -230634571) ^ 0x7839BEF3;
					continue;
				case 2u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1959943653) ^ 0x5CAAF294;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1814746639u));
					num = -693209128;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (!_202D_200F_202B_206E_202E_206C_206D_202E_202A_202A_202E_202B_200C_202E_202D_200C_200B_202E_206C_206F_206A_200B_206C_206B_206E_206A_202D_200E_200B_206B_206C_200C_206E_200C_206A_200E_206F_206E_200F_206F_202E((Object)(object)val, (Object)null))
					{
						num5 = 724829954;
						num6 = num5;
					}
					else
					{
						num5 = 1662664644;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1008739030);
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -1896518141;
						num4 = num3;
					}
					else
					{
						num3 = -851606549;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -811255080);
					continue;
				}
				case 4u:
					LuaScriptMgr.Push(L, (Object)(object)_200C_206F_200F_202D_200F_200F_202A_202A_202E_202C_206A_206B_206E_200B_202C_202E_202D_200F_200B_206D_206E_200D_206D_206C_206E_200E_200C_202A_200C_202A_206E_206B_202B_202E_200B_202C_202D_206F_200D_200D_202E(val));
					num = -618751743;
					continue;
				case 9u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1512862695u));
					num = ((int)num2 * -429357639) ^ -49860172;
					continue;
				default:
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
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Transform val = (Transform)luaObject;
		if (_202D_200F_202B_206E_202E_206C_206D_202E_202A_202A_202E_202B_200C_202E_202D_200C_200B_202E_206C_206F_206A_200B_206C_206B_206E_206A_202D_200E_200B_206B_206C_200C_206E_200C_206A_200E_206F_206E_200F_206F_202E((Object)(object)val, (Object)null))
		{
			goto IL_0018;
		}
		goto IL_006c;
		IL_0018:
		int num = 1348577129;
		goto IL_001d;
		IL_001d:
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x4D44E94D)) % 7)
			{
			case 2u:
				break;
			case 5u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(883297360u));
				num = (int)(num2 * 1919174246) ^ -1739970249;
				continue;
			case 4u:
				goto IL_006c;
			case 3u:
				luaTypes = LuaDLL.lua_type(L, 1);
				num = ((int)num2 * -393000638) ^ -1291586375;
				continue;
			case 1u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2161173653u));
				num = 1498575973;
				continue;
			case 0u:
			{
				int num3;
				int num4;
				if (luaTypes != LuaTypes.LUA_TTABLE)
				{
					num3 = 1389945253;
					num4 = num3;
				}
				else
				{
					num3 = 1293093410;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 245198393);
				continue;
			}
			default:
				return 1;
			}
			break;
		}
		goto IL_0018;
		IL_006c:
		LuaScriptMgr.PushValue(L, _202A_200F_202B_202D_206B_206C_200F_200C_206F_200F_200E_202A_206A_206A_200E_206C_202D_202C_200C_202E_200B_202B_206E_206E_200B_200E_202A_200E_206D_206A_202D_206F_202C_200D_202A_202E_206E_202D_206C_202C_202E(val));
		num = 367936299;
		goto IL_001d;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_localToWorldMatrix(IntPtr L)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Transform val = default(Transform);
		while (true)
		{
			int num = -836933250;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -188341700)) % 8)
				{
				case 3u:
					break;
				case 6u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -1383759625;
						num6 = num5;
					}
					else
					{
						num5 = -891905659;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -395085751);
					continue;
				}
				case 0u:
					num = ((int)num2 * -1338686955) ^ 0x34866B40;
					continue;
				case 2u:
					val = (Transform)luaObject;
					num = ((int)num2 * -1830777189) ^ 0x4598EAC3;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (_202D_200F_202B_206E_202E_206C_206D_202E_202A_202A_202E_202B_200C_202E_202D_200C_200B_202E_206C_206F_206A_200B_206C_206B_206E_206A_202D_200E_200B_206B_206C_200C_206E_200C_206A_200E_206F_206E_200F_206F_202E((Object)(object)val, (Object)null))
					{
						num3 = 1447418665;
						num4 = num3;
					}
					else
					{
						num3 = 904753603;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -716510821);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3060083568u));
					num = -2015087696;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(229951362u));
					num = ((int)num2 * -226956813) ^ 0x41DE6D11;
					continue;
				default:
					LuaScriptMgr.PushValue(L, _200D_202E_200D_200B_206D_206E_206B_206A_206D_206D_202B_200B_206E_206D_202C_200C_202E_202D_202A_200F_200E_200E_200F_206A_200B_200B_202E_200D_206A_202C_200F_202B_200E_200B_206E_202B_200C_200D_200F_202D_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_root(IntPtr L)
	{
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		Transform val = default(Transform);
		while (true)
		{
			int num = 1610547653;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4440711E)) % 8)
				{
				case 0u:
					break;
				case 5u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 2031012796;
						num6 = num5;
					}
					else
					{
						num5 = 747692409;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -390883144);
					continue;
				}
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 1084046931) ^ -911303441;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3469791021u));
					num = (int)(num2 * 929890646) ^ -2011459988;
					continue;
				case 6u:
					LuaScriptMgr.Push(L, (Object)(object)_200F_206E_200D_206C_206B_206F_202C_206F_202C_206F_200D_202C_202D_206F_200B_202D_202C_200F_200E_200E_202C_202D_206F_200E_200F_206D_206C_202A_206A_206E_200B_206A_202C_200F_200F_206B_202C_206A_200D_200F_202E(val));
					num = 1515124999;
					continue;
				case 3u:
				{
					val = (Transform)luaObject;
					int num3;
					int num4;
					if (!_202D_200F_202B_206E_202E_206C_206D_202E_202A_202A_202E_202B_200C_202E_202D_200C_200B_202E_206C_206F_206A_200B_206C_206B_206E_206A_202D_200E_200B_206B_206C_200C_206E_200C_206A_200E_206F_206E_200F_206F_202E((Object)(object)val, (Object)null))
					{
						num3 = 102245306;
						num4 = num3;
					}
					else
					{
						num3 = 492915936;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -541516386);
					continue;
				}
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2050858041u));
					num = 623596944;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_childCount(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Transform val = (Transform)luaObject;
		if (_202D_200F_202B_206E_202E_206C_206D_202E_202A_202A_202E_202B_200C_202E_202D_200C_200B_202E_206C_206F_206A_200B_206C_206B_206E_206A_202D_200E_200B_206B_206C_200C_206E_200C_206A_200E_206F_206E_200F_206F_202E((Object)(object)val, (Object)null))
		{
			goto IL_0018;
		}
		goto IL_0068;
		IL_0018:
		int num = -1558919188;
		goto IL_001d;
		IL_001d:
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -2020814915)) % 8)
			{
			case 6u:
				break;
			case 1u:
				luaTypes = LuaDLL.lua_type(L, 1);
				num = (int)(num2 * 341006432) ^ -250307695;
				continue;
			case 2u:
				goto IL_0068;
			case 4u:
			{
				int num3;
				int num4;
				if (luaTypes != LuaTypes.LUA_TTABLE)
				{
					num3 = 1318246362;
					num4 = num3;
				}
				else
				{
					num3 = 994994022;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -1609074959);
				continue;
			}
			case 3u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2261389053u));
				num = -1742667089;
				continue;
			case 0u:
				num = (int)(num2 * 1070640763) ^ -1016795569;
				continue;
			case 7u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3531520242u));
				num = ((int)num2 * -313942781) ^ 0x6304A818;
				continue;
			default:
				return 1;
			}
			break;
		}
		goto IL_0018;
		IL_0068:
		LuaScriptMgr.Push(L, _206D_200D_206B_200D_200F_202D_200E_200B_206C_200C_200B_202C_202B_206D_206B_202C_206F_206F_202C_200E_206E_206F_206D_200D_206B_200D_202B_200B_206D_206D_206C_200D_206A_202A_200C_206A_202E_202D_202E_200E_202E(val));
		num = -1816752696;
		goto IL_001d;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_lossyScale(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Transform val = (Transform)luaObject;
		if (_202D_200F_202B_206E_202E_206C_206D_202E_202A_202A_202E_202B_200C_202E_202D_200C_200B_202E_206C_206F_206A_200B_206C_206B_206E_206A_202D_200E_200B_206B_206C_200C_206E_200C_206A_200E_206F_206E_200F_206F_202E((Object)(object)val, (Object)null))
		{
			goto IL_0018;
		}
		goto IL_0051;
		IL_0018:
		int num = 1051955412;
		goto IL_001d;
		IL_001d:
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x53352B99)) % 8)
			{
			case 0u:
				break;
			case 1u:
				goto IL_0051;
			case 6u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(220606711u));
				num = ((int)num2 * -169499623) ^ 0x127D496D;
				continue;
			case 3u:
			{
				int num3;
				int num4;
				if (luaTypes != LuaTypes.LUA_TTABLE)
				{
					num3 = -380212101;
					num4 = num3;
				}
				else
				{
					num3 = -15669799;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 861658738);
				continue;
			}
			case 4u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4096416545u));
				num = 454227112;
				continue;
			case 2u:
				num = ((int)num2 * -1137442754) ^ 0x482072B4;
				continue;
			case 5u:
				luaTypes = LuaDLL.lua_type(L, 1);
				num = (int)((num2 * 228729400) ^ 0xA700512);
				continue;
			default:
				return 1;
			}
			break;
		}
		goto IL_0018;
		IL_0051:
		LuaScriptMgr.Push(L, _202D_206E_206D_206D_200C_202C_202B_202E_202C_200C_200D_200E_206F_206B_200E_200B_206D_200E_206F_202E_200C_206B_200C_206C_202D_206F_202C_206A_206A_202A_206D_206D_206A_206B_206A_202B_200E_200D_200B_202A_202E(val));
		num = 847377158;
		goto IL_001d;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_hasChanged(IntPtr L)
	{
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Transform val = default(Transform);
		while (true)
		{
			int num = 580834354;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x42D389FD)) % 7)
				{
				case 0u:
					break;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1181414296u));
					num = (int)((num2 * 1721890444) ^ 0x3593F71F);
					continue;
				case 2u:
					num = ((int)num2 * -1094224880) ^ -1565600212;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(73902089u));
					num = 2111175180;
					continue;
				case 4u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 1512720860;
						num6 = num5;
					}
					else
					{
						num5 = 65966809;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 939421173);
					continue;
				}
				case 3u:
				{
					val = (Transform)luaObject;
					int num3;
					int num4;
					if (_202D_200F_202B_206E_202E_206C_206D_202E_202A_202A_202E_202B_200C_202E_202D_200C_200B_202E_206C_206F_206A_200B_206C_206B_206E_206A_202D_200E_200B_206B_206C_200C_206E_200C_206A_200E_206F_206E_200F_206F_202E((Object)(object)val, (Object)null))
					{
						num3 = 536481007;
						num4 = num3;
					}
					else
					{
						num3 = 1796615986;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1455270814);
					continue;
				}
				default:
					LuaScriptMgr.Push(L, _200C_202A_206D_202A_206F_202D_202A_200B_202B_202C_202C_206E_206C_200B_206E_202D_202B_200C_206F_206C_206F_200F_206B_200E_202E_200B_200C_200C_206D_206A_206B_200D_200E_206C_206C_200B_202D_202D_202A_206A_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_position(IntPtr L)
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		Transform val = default(Transform);
		while (true)
		{
			int num = 1619335156;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x318706CC)) % 9)
				{
				case 2u:
					break;
				case 4u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -1984926793;
						num6 = num5;
					}
					else
					{
						num5 = -581506706;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1417027698);
					continue;
				}
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2482824239u));
					num = 1194381763;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2472533842u));
					num = ((int)num2 * -881972162) ^ -2100665984;
					continue;
				case 3u:
				{
					val = (Transform)luaObject;
					int num3;
					int num4;
					if (!_202D_200F_202B_206E_202E_206C_206D_202E_202A_202A_202E_202B_200C_202E_202D_200C_200B_202E_206C_206F_206A_200B_206C_206B_206E_206A_202D_200E_200B_206B_206C_200C_206E_200C_206A_200E_206F_206E_200F_206F_202E((Object)(object)val, (Object)null))
					{
						num3 = 451561379;
						num4 = num3;
					}
					else
					{
						num3 = 1808759511;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1748382292);
					continue;
				}
				case 1u:
					num = ((int)num2 * -1044622700) ^ 0x725D1A2B;
					continue;
				case 0u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1402761975) ^ -587720668;
					continue;
				case 6u:
					_200D_200C_202C_202C_202D_200C_206F_202B_206A_206C_200E_202D_206B_202B_200D_206C_202D_202E_200D_206E_206D_202D_200B_206B_200E_200B_206A_200D_206A_206D_202B_206B_202D_206C_202D_200B_206B_202C_202E_200D_202E(val, LuaScriptMgr.GetVector3(L, 3));
					num = 1813302665;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_localPosition(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Transform val = (Transform)luaObject;
		if (_202D_200F_202B_206E_202E_206C_206D_202E_202A_202A_202E_202B_200C_202E_202D_200C_200B_202E_206C_206F_206A_200B_206C_206B_206E_206A_202D_200E_200B_206B_206C_200C_206E_200C_206A_200E_206F_206E_200F_206F_202E((Object)(object)val, (Object)null))
		{
			while (true)
			{
				int num = 162753336;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x5153CA97)) % 5)
					{
					case 0u:
						break;
					case 3u:
					{
						LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
						int num3;
						int num4;
						if (luaTypes != LuaTypes.LUA_TTABLE)
						{
							num3 = 931786610;
							num4 = num3;
						}
						else
						{
							num3 = 690501280;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 83147613);
						continue;
					}
					case 1u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4276375151u));
						num = (int)((num2 * 963590726) ^ 0xDDFD70D);
						continue;
					case 4u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3904699068u));
						num = 1857222101;
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
		_202C_202C_202B_202D_202B_200D_206B_206D_202C_202B_206D_202C_200B_206C_206A_206B_202A_202E_206A_206B_206F_202C_206E_200B_200E_200E_206A_200C_200C_206B_206E_202D_200D_202A_206B_200D_202E_202A_206C_200F_202E(val, LuaScriptMgr.GetVector3(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_eulerAngles(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Transform val = (Transform)luaObject;
		if (_202D_200F_202B_206E_202E_206C_206D_202E_202A_202A_202E_202B_200C_202E_202D_200C_200B_202E_206C_206F_206A_200B_206C_206B_206E_206A_202D_200E_200B_206B_206C_200C_206E_200C_206A_200E_206F_206E_200F_206F_202E((Object)(object)val, (Object)null))
		{
			goto IL_001b;
		}
		goto IL_00b9;
		IL_001b:
		int num = -1597597921;
		goto IL_0020;
		IL_0020:
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -2101179914)) % 8)
			{
			case 3u:
				break;
			case 0u:
				num = (int)((num2 * 1776936658) ^ 0x327F8A6A);
				continue;
			case 7u:
			{
				int num3;
				int num4;
				if (luaTypes == LuaTypes.LUA_TTABLE)
				{
					num3 = -1833217072;
					num4 = num3;
				}
				else
				{
					num3 = -386311628;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -274079576);
				continue;
			}
			case 1u:
				luaTypes = LuaDLL.lua_type(L, 1);
				num = (int)(num2 * 293067408) ^ -333465919;
				continue;
			case 6u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4016993117u));
				num = ((int)num2 * -670175814) ^ 0x48032D82;
				continue;
			case 4u:
				goto IL_00b9;
			case 2u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3898705743u));
				num = -1013445606;
				continue;
			default:
				return 0;
			}
			break;
		}
		goto IL_001b;
		IL_00b9:
		_206A_202D_206C_206E_206F_200C_206B_200F_202D_202A_202D_200B_206D_206E_206F_202E_200E_202A_200F_200D_206F_202E_206C_202E_202E_202D_206E_200E_206B_206B_202A_200E_202E_206C_206A_202C_200E_202C_200B_200E_202E(val, LuaScriptMgr.GetVector3(L, 3));
		num = -1951992365;
		goto IL_0020;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_localEulerAngles(IntPtr L)
	{
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Transform val = default(Transform);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1009993558;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4D33EFF5)) % 8)
				{
				case 5u:
					break;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(96078396u));
					num = ((int)num2 * -565811806) ^ -2004914509;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3606615010u));
					num = 822477053;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (!_202D_200F_202B_206E_202E_206C_206D_202E_202A_202A_202E_202B_200C_202E_202D_200C_200B_202E_206C_206F_206A_200B_206C_206B_206E_206A_202D_200E_200B_206B_206C_200C_206E_200C_206A_200E_206F_206E_200F_206F_202E((Object)(object)val, (Object)null))
					{
						num5 = -1646321075;
						num6 = num5;
					}
					else
					{
						num5 = -1532910809;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 288943348);
					continue;
				}
				case 2u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -353956558) ^ -954975017;
					continue;
				case 3u:
					val = (Transform)luaObject;
					num = (int)((num2 * 1933081511) ^ 0x1A345ABC);
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -684452102;
						num4 = num3;
					}
					else
					{
						num3 = -830650732;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1324074604);
					continue;
				}
				default:
					_202B_200D_200B_200E_202B_206F_202D_202B_202C_206B_206A_206A_202B_200D_200C_200F_206B_202C_202C_200F_202E_206B_202C_202D_200B_206A_202D_200E_200F_200B_202D_200C_206D_202B_202C_202C_206F_200B_206A_206E_202E(val, LuaScriptMgr.GetVector3(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_right(IntPtr L)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Transform val = default(Transform);
		while (true)
		{
			int num = 590778102;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x481E27F8)) % 9)
				{
				case 0u:
					break;
				case 6u:
					val = (Transform)luaObject;
					num = (int)(num2 * 1264281194) ^ -352529486;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1474823540u));
					num = 1824200793;
					continue;
				case 2u:
					_202E_202A_206B_206D_206C_200C_202D_200E_206A_206B_200E_200E_206E_206C_206C_206F_200B_200B_206C_202B_202D_202E_202B_202D_200E_206F_202E_206F_202C_202C_200E_200D_202C_202C_200E_200C_206F_202A_206C_206F_202E(val, LuaScriptMgr.GetVector3(L, 3));
					num = 293911418;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (!_202D_200F_202B_206E_202E_206C_206D_202E_202A_202A_202E_202B_200C_202E_202D_200C_200B_202E_206C_206F_206A_200B_206C_206B_206E_206A_202D_200E_200B_206B_206C_200C_206E_200C_206A_200E_206F_206E_200F_206F_202E((Object)(object)val, (Object)null))
					{
						num5 = 268400611;
						num6 = num5;
					}
					else
					{
						num5 = 381328513;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1270166561);
					continue;
				}
				case 5u:
					num = (int)(num2 * 1655759740) ^ -657288475;
					continue;
				case 8u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 1471080265;
						num4 = num3;
					}
					else
					{
						num3 = 1055054922;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -85597535);
					continue;
				}
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1031606601u));
					num = (int)(num2 * 578734802) ^ -672701893;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_up(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Transform val = default(Transform);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1689319004;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1986480707)) % 8)
				{
				case 7u:
					break;
				case 1u:
				{
					val = (Transform)luaObject;
					int num5;
					int num6;
					if (!_202D_200F_202B_206E_202E_206C_206D_202E_202A_202A_202E_202B_200C_202E_202D_200C_200B_202E_206C_206F_206A_200B_206C_206B_206E_206A_202D_200E_200B_206B_206C_200C_206E_200C_206A_200E_206F_206E_200F_206F_202E((Object)(object)val, (Object)null))
					{
						num5 = -1966121972;
						num6 = num5;
					}
					else
					{
						num5 = -571529581;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1961776101);
					continue;
				}
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3417831245u));
					num = ((int)num2 * -440630730) ^ 0x45473B1D;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1081202034u));
					num = -1963327151;
					continue;
				case 4u:
					_200C_200F_202A_202B_202C_200F_202A_206F_206E_200D_206C_200B_202B_202C_206B_200F_202C_206F_206B_200F_200E_200C_202B_206E_200D_200B_200C_200E_202C_200C_200F_200D_206F_206D_206B_200B_206A_202D_206D_202D_202E(val, LuaScriptMgr.GetVector3(L, 3));
					num = -2136273579;
					continue;
				case 3u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -943148131) ^ -271611444;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -976672554;
						num4 = num3;
					}
					else
					{
						num3 = -699627647;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1749851445);
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
	private static int set_forward(IntPtr L)
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Transform val = default(Transform);
		while (true)
		{
			int num = 111543841;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x578A09C0)) % 8)
				{
				case 3u:
					break;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2370493505u));
					num = 348282183;
					continue;
				case 6u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 1913643712;
						num6 = num5;
					}
					else
					{
						num5 = 347542508;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1965551068);
					continue;
				}
				case 2u:
					num = (int)((num2 * 130643278) ^ 0x4A132D6B);
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!_202D_200F_202B_206E_202E_206C_206D_202E_202A_202A_202E_202B_200C_202E_202D_200C_200B_202E_206C_206F_206A_200B_206C_206B_206E_206A_202D_200E_200B_206B_206C_200C_206E_200C_206A_200E_206F_206E_200F_206F_202E((Object)(object)val, (Object)null))
					{
						num3 = -256822;
						num4 = num3;
					}
					else
					{
						num3 = -1299452309;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 305794913);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1039465721u));
					num = (int)((num2 * 441976436) ^ 0x7B46CE1A);
					continue;
				case 1u:
					val = (Transform)luaObject;
					num = ((int)num2 * -535574766) ^ 0x787B08BF;
					continue;
				default:
					_206E_206B_202B_202A_202D_202D_202B_206B_206D_206D_202C_200F_202C_206C_202C_202D_206B_200F_206C_200F_206B_206C_206F_200E_200F_206A_200F_206D_202E_206D_206D_202C_202A_206A_202D_200E_202E_206B_206C_200C_202E(val, LuaScriptMgr.GetVector3(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_rotation(IntPtr L)
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Transform val = default(Transform);
		while (true)
		{
			int num = 556711395;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2707F9EE)) % 8)
				{
				case 3u:
					break;
				case 5u:
				{
					val = (Transform)luaObject;
					int num5;
					int num6;
					if (!_202D_200F_202B_206E_202E_206C_206D_202E_202A_202A_202E_202B_200C_202E_202D_200C_200B_202E_206C_206F_206A_200B_206C_206B_206E_206A_202D_200E_200B_206B_206C_200C_206E_200C_206A_200E_206F_206E_200F_206F_202E((Object)(object)val, (Object)null))
					{
						num5 = 1238830363;
						num6 = num5;
					}
					else
					{
						num5 = 1156868625;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1986742133);
					continue;
				}
				case 2u:
					_202C_200B_200C_200F_206F_200C_200B_202A_200D_200D_206E_202B_206D_200E_200C_206D_200C_202C_200D_206B_200E_206B_206F_200B_206D_206F_200C_206D_206A_206D_206F_206B_206D_202B_206D_200F_206B_206E_202C_206F_202E(val, LuaScriptMgr.GetQuaternion(L, 3));
					num = 1140180688;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(759936006u));
					num = 67257876;
					continue;
				case 7u:
					num = (int)(num2 * 1322666405) ^ -1410209153;
					continue;
				case 0u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -220628049;
						num4 = num3;
					}
					else
					{
						num3 = -124112590;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -426157171);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(96329929u));
					num = (int)((num2 * 2023539903) ^ 0x42350535);
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_localRotation(IntPtr L)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Transform val = default(Transform);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1850821873;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -940662300)) % 9)
				{
				case 6u:
					break;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2391064563u));
					num = ((int)num2 * -2019353805) ^ 0x65DD14BF;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (!_202D_200F_202B_206E_202E_206C_206D_202E_202A_202A_202E_202B_200C_202E_202D_200C_200B_202E_206C_206F_206A_200B_206C_206B_206E_206A_202D_200E_200B_206B_206C_200C_206E_200C_206A_200E_206F_206E_200F_206F_202E((Object)(object)val, (Object)null))
					{
						num5 = -2139083277;
						num6 = num5;
					}
					else
					{
						num5 = -1932127243;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1552866075);
					continue;
				}
				case 7u:
					num = ((int)num2 * -282361945) ^ 0x166D0965;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 1260810772;
						num4 = num3;
					}
					else
					{
						num3 = 1141526388;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -986510929);
					continue;
				}
				case 0u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 886691155) ^ -291907534;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3377945684u));
					num = -2081318825;
					continue;
				case 4u:
					val = (Transform)luaObject;
					num = ((int)num2 * -1328222870) ^ -370029186;
					continue;
				default:
					_200B_206B_200E_202C_206B_206D_200F_206D_202D_206C_202D_202C_206E_202A_200D_206E_206C_200B_206D_202B_206C_200E_200D_202B_202C_200D_206D_206B_206B_202D_202D_200D_206D_200E_202E_202D_202D_200F_200F_206B_202E(val, LuaScriptMgr.GetQuaternion(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_localScale(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Transform val = (Transform)luaObject;
		while (true)
		{
			int num = 700785344;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5A4BA3C5)) % 7)
				{
				case 0u:
					break;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1161159509u));
					num = 2042588626;
					continue;
				case 5u:
					_200E_200F_202A_206D_200F_200E_206B_206A_202E_200E_202C_200F_206F_206D_202D_206D_200E_206A_200C_200B_200B_206C_202E_200F_202E_206A_202A_206D_206C_200F_206E_200C_200E_200F_206A_206E_206E_202A_200C_202C_202E(val, LuaScriptMgr.GetVector3(L, 3));
					num = 253346238;
					continue;
				case 4u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 983393574;
						num6 = num5;
					}
					else
					{
						num5 = 2084892946;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -140800931);
					continue;
				}
				case 3u:
				{
					int num3;
					int num4;
					if (_202D_200F_202B_206E_202E_206C_206D_202E_202A_202A_202E_202B_200C_202E_202D_200C_200B_202E_206C_206F_206A_200B_206C_206B_206E_206A_202D_200E_200B_206B_206C_200C_206E_200C_206A_200E_206F_206E_200F_206F_202E((Object)(object)val, (Object)null))
					{
						num3 = 1799028487;
						num4 = num3;
					}
					else
					{
						num3 = 699482204;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -966859594);
					continue;
				}
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3890729872u));
					num = ((int)num2 * -575269456) ^ -1985081470;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_parent(IntPtr L)
	{
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		Transform val = default(Transform);
		while (true)
		{
			int num = -1780831411;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -845506397)) % 9)
				{
				case 7u:
					break;
				case 1u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -215341771;
						num6 = num5;
					}
					else
					{
						num5 = -366838506;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 2037216);
					continue;
				}
				case 5u:
					num = ((int)num2 * -367949463) ^ 0x40903305;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(385043889u));
					num = -1578759369;
					continue;
				case 6u:
					val = (Transform)luaObject;
					num = (int)((num2 * 409713602) ^ 0x24A77EDD);
					continue;
				case 8u:
				{
					int num3;
					int num4;
					if (_202D_200F_202B_206E_202E_206C_206D_202E_202A_202A_202E_202B_200C_202E_202D_200C_200B_202E_206C_206F_206A_200B_206C_206B_206E_206A_202D_200E_200B_206B_206C_200C_206E_200C_206A_200E_206F_206E_200F_206F_202E((Object)(object)val, (Object)null))
					{
						num3 = 77551583;
						num4 = num3;
					}
					else
					{
						num3 = 502061415;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -2019223896);
					continue;
				}
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -517473237) ^ 0x1BE6B9C;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2301274614u));
					num = (int)((num2 * 836467036) ^ 0x7AD07E4D);
					continue;
				default:
					_202D_200E_206F_200F_206E_202E_202A_206B_200D_200E_200E_200B_202A_200E_206B_206E_206A_202D_206F_200D_202B_202C_206A_200B_202E_206A_202E_206A_206B_206E_206E_200D_202E_206A_200C_202E_200D_200B_200F_202D_202E(val, (Transform)LuaScriptMgr.GetUnityObject(L, 3, _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(Transform).TypeHandle)));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_hasChanged(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Transform val = (Transform)luaObject;
		while (true)
		{
			int num = -1133130944;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -856038636)) % 8)
				{
				case 0u:
					break;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(333576685u));
					num = ((int)num2 * -1794456792) ^ 0x40907857;
					continue;
				case 5u:
					_202B_206A_202D_202C_206E_200F_202A_202D_206B_202C_206C_206A_206F_202A_206E_200D_206F_200C_200E_206D_202B_200D_206E_200C_202D_200D_200C_200D_202B_206E_206C_206C_206C_200E_206E_202A_206F_200D_202D_202E_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					num = -2020530429;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3544470303u));
					num = -894546847;
					continue;
				case 6u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 400415951;
						num6 = num5;
					}
					else
					{
						num5 = 238797788;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -982412013);
					continue;
				}
				case 4u:
				{
					int num3;
					int num4;
					if (!_202D_200F_202B_206E_202E_206C_206D_202E_202A_202A_202E_202B_200C_202E_202D_200C_200B_202E_206C_206F_206A_200B_206C_206B_206E_206A_202D_200E_200B_206B_206C_200C_206E_200C_206A_200E_206F_206E_200F_206F_202E((Object)(object)val, (Object)null))
					{
						num3 = -1818088295;
						num4 = num3;
					}
					else
					{
						num3 = -356016670;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 613620934);
					continue;
				}
				case 3u:
					num = ((int)num2 * -1438678059) ^ 0x5BA530E6;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SetParent(IntPtr L)
	{
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		Transform val3 = default(Transform);
		Transform val2 = default(Transform);
		Transform val4 = default(Transform);
		Transform val = default(Transform);
		bool boolean = default(bool);
		while (true)
		{
			int num2 = 1091672902;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x16CA3B9E)) % 12)
				{
				case 10u:
					break;
				case 11u:
					return 0;
				case 8u:
				{
					int num6;
					if (num != 3)
					{
						num2 = 312688411;
						num6 = num2;
					}
					else
					{
						num2 = 816112879;
						num6 = num2;
					}
					continue;
				}
				case 1u:
					val3 = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2401350092u));
					num2 = (int)(num3 * 1009125452) ^ -1678910216;
					continue;
				case 7u:
					_200D_202A_206C_200B_200C_200D_200B_206A_200F_202E_200E_200D_200E_200D_206C_200C_202E_202D_200B_200E_200D_206F_202D_206E_200B_202A_206D_200B_202E_206E_200E_200D_202E_202E_206F_206E_206D_202B_200F_202A_202E(val2, val4);
					num2 = (int)(num3 * 592629872) ^ -1692120651;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (num != 2)
					{
						num4 = -316132042;
						num5 = num4;
					}
					else
					{
						num4 = -1670382886;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 252894566);
					continue;
				}
				case 5u:
					return 0;
				case 6u:
					val4 = (Transform)LuaScriptMgr.GetUnityObject(L, 2, _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(Transform).TypeHandle));
					num2 = ((int)num3 * -772831601) ^ -1357987157;
					continue;
				case 3u:
					_206D_200D_206A_202A_202C_200F_200D_200D_202B_206A_206F_202B_206E_200C_202E_202E_206F_206B_206E_200D_200E_206B_206C_206F_206A_202A_200C_202B_200D_202D_206C_206E_200D_206C_206A_202D_202A_200D_200D_200D_202E(val3, val, boolean);
					num2 = (int)(num3 * 345535994) ^ -591225427;
					continue;
				case 0u:
					val2 = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(200544826u));
					num2 = (int)(num3 * 1068301502) ^ -705965512;
					continue;
				case 2u:
					val = (Transform)LuaScriptMgr.GetUnityObject(L, 2, _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(Transform).TypeHandle));
					boolean = LuaScriptMgr.GetBoolean(L, 3);
					num2 = (int)((num3 * 1499343429) ^ 0x65D6111F);
					continue;
				default:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3883319848u));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Translate(IntPtr L)
	{
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected O, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected O, but got Unknown
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected O, but got Unknown
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		Transform val7 = default(Transform);
		Vector3 vector3 = default(Vector3);
		Space val8 = default(Space);
		Transform val5 = default(Transform);
		float num9 = default(float);
		float num10 = default(float);
		Transform val3 = default(Transform);
		Vector3 vector = default(Vector3);
		Transform val4 = default(Transform);
		float num13 = default(float);
		Vector3 vector2 = default(Vector3);
		Transform val6 = default(Transform);
		Transform val9 = default(Transform);
		float num16 = default(float);
		float num17 = default(float);
		float num6 = default(float);
		Transform val2 = default(Transform);
		Transform val = default(Transform);
		float num4 = default(float);
		float num5 = default(float);
		while (true)
		{
			int num2 = -858506257;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -2132796695)) % 31)
				{
				case 0u:
					break;
				case 9u:
				{
					int num23;
					int num24;
					if (num != 2)
					{
						num23 = -1812295740;
						num24 = num23;
					}
					else
					{
						num23 = -597296099;
						num24 = num23;
					}
					num2 = num23 ^ (int)(num3 * 476469085);
					continue;
				}
				case 22u:
				{
					int num21;
					int num22;
					if (!LuaScriptMgr.CheckTypes(L, 1, _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(Transform).TypeHandle), _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(LuaTable).TypeHandle), _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(Space).TypeHandle)))
					{
						num21 = 575067537;
						num22 = num21;
					}
					else
					{
						num21 = 1647292967;
						num22 = num21;
					}
					num2 = num21 ^ ((int)num3 * -285964981);
					continue;
				}
				case 11u:
					val7 = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1820166488u));
					vector3 = LuaScriptMgr.GetVector3(L, 2);
					val8 = (Space)(int)LuaScriptMgr.GetLuaObject(L, 3);
					num2 = (int)((num3 * 919185198) ^ 0x29C023B7);
					continue;
				case 19u:
					_206A_206A_202D_202D_200F_206C_200D_206A_206B_200C_202D_206D_202E_202B_206A_206E_206C_200C_206D_206A_206E_202C_202E_200D_206F_200E_200C_200F_206B_200D_202C_206F_206A_202D_202E_206C_200D_200D_202D_200D_202E(val7, vector3, val8);
					num2 = (int)((num3 * 1709934563) ^ 0x6D04385D);
					continue;
				case 17u:
				{
					float num8 = (float)LuaScriptMgr.GetNumber(L, 4);
					_206F_200C_206F_202B_200D_202D_200F_206F_200B_200E_206A_202E_202B_200B_200E_200C_206B_202A_200F_200E_202B_206D_200F_200B_202B_202C_202D_202B_200C_206F_206C_202B_206D_206C_206C_202A_206F_206E_206B_202D_202E(val5, num9, num10, num8);
					return 0;
				}
				case 5u:
					_200E_202A_202A_206D_202D_206C_202E_200D_200C_200B_206E_206A_200D_206C_202E_202D_206B_206B_202B_202B_202B_206F_200D_206D_202E_206A_200C_206C_200F_200C_200C_200D_206E_200D_206C_202B_206A_202D_206F_202D_202E(val3, vector, val4);
					return 0;
				case 1u:
					num13 = (float)LuaDLL.lua_tonumber(L, 4);
					num2 = (int)((num3 * 1791028293) ^ 0x17D97517);
					continue;
				case 6u:
				{
					int num25;
					if (num == 3)
					{
						num2 = -1281325379;
						num25 = num2;
					}
					else
					{
						num2 = -1764963634;
						num25 = num2;
					}
					continue;
				}
				case 8u:
					return 0;
				case 4u:
				{
					int num15;
					if (num == 3)
					{
						num2 = -1140568302;
						num15 = num2;
					}
					else
					{
						num2 = -427146728;
						num15 = num2;
					}
					continue;
				}
				case 28u:
					val5 = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(200544826u));
					num9 = (float)LuaScriptMgr.GetNumber(L, 2);
					num10 = (float)LuaScriptMgr.GetNumber(L, 3);
					num2 = ((int)num3 * -1790057545) ^ -1894373799;
					continue;
				case 2u:
					vector2 = LuaScriptMgr.GetVector3(L, 2);
					num2 = ((int)num3 * -1409696914) ^ -236097959;
					continue;
				case 13u:
				{
					int num26;
					int num27;
					if (LuaScriptMgr.CheckTypes(L, 1, _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(Transform).TypeHandle), _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(LuaTable).TypeHandle), _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(Transform).TypeHandle)))
					{
						num26 = 681882650;
						num27 = num26;
					}
					else
					{
						num26 = 427679518;
						num27 = num26;
					}
					num2 = num26 ^ (int)(num3 * 1163218084);
					continue;
				}
				case 29u:
					val6 = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4128549891u));
					num2 = (int)(num3 * 785504543) ^ -2089804523;
					continue;
				case 10u:
					val3 = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1243143517u));
					vector = LuaScriptMgr.GetVector3(L, 2);
					num2 = (int)((num3 * 1157029079) ^ 0x7D71A2B6);
					continue;
				case 25u:
				{
					Space val10 = (Space)(int)LuaScriptMgr.GetLuaObject(L, 5);
					_200F_202C_200F_200B_206E_200B_200B_206A_206B_206C_202A_200D_200D_206C_200B_202A_202E_200F_206D_206C_206A_202A_206A_202C_200C_200D_200B_200C_200C_206A_200B_206A_206B_206D_206B_202D_202B_202A_202B_206B_202E(val9, num16, num17, num13, val10);
					return 0;
				}
				case 21u:
					num6 = (float)LuaDLL.lua_tonumber(L, 4);
					val2 = (Transform)LuaScriptMgr.GetLuaObject(L, 5);
					num2 = ((int)num3 * -571810418) ^ -1590776592;
					continue;
				case 16u:
					val4 = (Transform)LuaScriptMgr.GetLuaObject(L, 3);
					num2 = (int)((num3 * 466144948) ^ 0x1B76B32B);
					continue;
				case 3u:
				{
					int num19;
					int num20;
					if (!LuaScriptMgr.CheckTypes(L, 1, _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(Transform).TypeHandle), _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(float).TypeHandle), _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(float).TypeHandle), _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(float).TypeHandle), _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(Transform).TypeHandle)))
					{
						num19 = 1927970384;
						num20 = num19;
					}
					else
					{
						num19 = 155850293;
						num20 = num19;
					}
					num2 = num19 ^ (int)(num3 * 1903381597);
					continue;
				}
				case 27u:
					val = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4128549891u));
					num4 = (float)LuaDLL.lua_tonumber(L, 2);
					num5 = (float)LuaDLL.lua_tonumber(L, 3);
					num2 = ((int)num3 * -1039261878) ^ 0x23265079;
					continue;
				case 18u:
				{
					int num18;
					if (num == 5)
					{
						num2 = -1148050852;
						num18 = num2;
					}
					else
					{
						num2 = -1387713647;
						num18 = num2;
					}
					continue;
				}
				case 7u:
					val9 = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1243143517u));
					num16 = (float)LuaDLL.lua_tonumber(L, 2);
					num17 = (float)LuaDLL.lua_tonumber(L, 3);
					num2 = ((int)num3 * -374527227) ^ 0x7F49A55E;
					continue;
				case 26u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1833332181u));
					num2 = -916800862;
					continue;
				case 14u:
					return 0;
				case 20u:
				{
					int num14;
					if (num == 5)
					{
						num2 = -1768378104;
						num14 = num2;
					}
					else
					{
						num2 = -1045740733;
						num14 = num2;
					}
					continue;
				}
				case 15u:
				{
					int num11;
					int num12;
					if (LuaScriptMgr.CheckTypes(L, 1, _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(Transform).TypeHandle), _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(float).TypeHandle), _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(float).TypeHandle), _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(float).TypeHandle), _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(Space).TypeHandle)))
					{
						num11 = -171113650;
						num12 = num11;
					}
					else
					{
						num11 = -690586416;
						num12 = num11;
					}
					num2 = num11 ^ (int)(num3 * 1917663731);
					continue;
				}
				case 24u:
					_202D_202C_202D_206D_202C_206A_200B_202C_206D_202B_202C_200B_202E_202E_202D_202A_200E_202E_200C_206B_206F_206D_202A_202E_206C_200D_200D_200B_206C_206E_202C_202B_202C_206F_202E_200D_202C_202A_206F_206B_202E(val6, vector2);
					return 0;
				case 30u:
				{
					int num7;
					if (num == 4)
					{
						num2 = -711970736;
						num7 = num2;
					}
					else
					{
						num2 = -294902805;
						num7 = num2;
					}
					continue;
				}
				case 23u:
					_202A_200E_206D_202D_202D_202D_200E_200D_200F_206F_200C_202C_206E_202E_202B_202C_202C_200E_202D_202E_202C_206C_202E_200E_206F_202E_206A_200F_202B_206A_200F_200F_202A_202E_200B_202D_200F_206A_206F_202E_202E(val, num4, num5, num6, val2);
					num2 = ((int)num3 * -216371196) ^ -1291523108;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Rotate(IntPtr L)
	{
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected O, but got Unknown
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected O, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected O, but got Unknown
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected O, but got Unknown
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Expected O, but got Unknown
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		int num = LuaDLL.lua_gettop(L);
		float num13 = default(float);
		Transform val7 = default(Transform);
		float num14 = default(float);
		float num17 = default(float);
		float num18 = default(float);
		Transform val = default(Transform);
		Vector3 vector = default(Vector3);
		Vector3 vector4 = default(Vector3);
		Transform val3 = default(Transform);
		Transform val2 = default(Transform);
		Space val5 = default(Space);
		Transform val6 = default(Transform);
		float num19 = default(float);
		float num20 = default(float);
		float num21 = default(float);
		Space val9 = default(Space);
		Transform val8 = default(Transform);
		Vector3 vector3 = default(Vector3);
		Vector3 vector2 = default(Vector3);
		Space val4 = default(Space);
		while (true)
		{
			int num2 = 581726002;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x6127BA3E)) % 39)
				{
				case 13u:
					break;
				case 25u:
					num13 = (float)LuaDLL.lua_tonumber(L, 4);
					num2 = ((int)num3 * -1325821470) ^ -1920425099;
					continue;
				case 22u:
					_202A_206F_202D_206C_200F_202B_206D_200D_206D_202B_200C_206E_200C_202C_202A_206C_206B_206A_202E_200C_200E_200B_202B_202D_200F_200D_206A_206B_202C_206A_200E_200B_200E_200C_206F_202B_200F_202E_202E_202E(val7, num14, num17, num13);
					num2 = (int)(num3 * 19306293) ^ -1210800893;
					continue;
				case 7u:
				{
					int num16;
					if (num == 5)
					{
						num2 = 2100281454;
						num16 = num2;
					}
					else
					{
						num2 = 352840166;
						num16 = num2;
					}
					continue;
				}
				case 14u:
				{
					int num7;
					if (num != 4)
					{
						num2 = 1822330295;
						num7 = num2;
					}
					else
					{
						num2 = 339020369;
						num7 = num2;
					}
					continue;
				}
				case 11u:
					num18 = (float)LuaDLL.lua_tonumber(L, 3);
					num2 = (int)(num3 * 1640880392) ^ -1985489781;
					continue;
				case 5u:
				{
					float num6 = (float)LuaDLL.lua_tonumber(L, 3);
					_206D_202A_206F_206F_206D_202A_206B_206E_206B_202C_202C_202D_206A_206B_200E_200C_200F_206D_206C_202A_200C_202D_200D_200B_200C_202B_200E_206C_206B_206E_200F_206C_206D_206B_200D_200D_206C_202B_200D_206A_202E(val, vector, num6);
					num2 = (int)((num3 * 1926356053) ^ 0x17FB7653);
					continue;
				}
				case 3u:
					vector4 = LuaScriptMgr.GetVector3(L, 2);
					num2 = ((int)num3 * -798738644) ^ -101574149;
					continue;
				case 9u:
					return 0;
				case 10u:
					num17 = (float)LuaDLL.lua_tonumber(L, 3);
					num2 = (int)(num3 * 1710225265) ^ -687389835;
					continue;
				case 29u:
					val3 = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2401350092u));
					num2 = ((int)num3 * -175047927) ^ -2061022186;
					continue;
				case 19u:
					_206B_206E_202B_202D_200D_200D_200F_206D_206A_202B_200C_206F_202D_206E_202A_206F_206A_206B_206B_206B_202B_206C_200B_206D_206C_206F_200D_206F_202A_200B_206A_200D_206B_200C_200B_202C_206D_202D_202A_202B_202E(val2, vector4);
					return 0;
				case 38u:
				{
					int num11;
					int num12;
					if (LuaScriptMgr.CheckTypes(L, 1, _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(Transform).TypeHandle), _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(float).TypeHandle), _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(float).TypeHandle), _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(float).TypeHandle)))
					{
						num11 = -545890245;
						num12 = num11;
					}
					else
					{
						num11 = -1409919563;
						num12 = num11;
					}
					num2 = num11 ^ ((int)num3 * -1898123934);
					continue;
				}
				case 12u:
					val5 = (Space)(int)LuaScriptMgr.GetLuaObject(L, 4);
					num2 = ((int)num3 * -1537956412) ^ -1275090705;
					continue;
				case 31u:
					return 0;
				case 15u:
					val = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(200544826u));
					num2 = (int)((num3 * 373853787) ^ 0x1A4213B8);
					continue;
				case 21u:
					return 0;
				case 20u:
				{
					int num25;
					int num26;
					if (LuaScriptMgr.CheckTypes(L, 1, _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(Transform).TypeHandle), _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(LuaTable).TypeHandle), _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(float).TypeHandle), _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(Space).TypeHandle)))
					{
						num25 = 1021155576;
						num26 = num25;
					}
					else
					{
						num25 = 290003058;
						num26 = num25;
					}
					num2 = num25 ^ (int)(num3 * 1480888075);
					continue;
				}
				case 18u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2778705022u));
					num2 = 2127569071;
					continue;
				case 16u:
				{
					int num23;
					int num24;
					if (LuaScriptMgr.CheckTypes(L, 1, _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(Transform).TypeHandle), _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(LuaTable).TypeHandle), _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(float).TypeHandle)))
					{
						num23 = 1366929759;
						num24 = num23;
					}
					else
					{
						num23 = 441390765;
						num24 = num23;
					}
					num2 = num23 ^ (int)(num3 * 1349819945);
					continue;
				}
				case 6u:
					_202D_202B_202A_202A_202E_200C_200D_200F_206C_206E_206F_206F_206A_200B_202C_206F_202A_200F_202A_200F_206E_206B_206F_200E_200F_202C_202A_206F_206C_206E_206B_206B_202A_202D_206A_200C_206E_200B_200D_202C_202E(val6, num19, num20, num21, val9);
					num2 = (int)((num3 * 1025851365) ^ 0x7B24F1C5);
					continue;
				case 30u:
				{
					int num22;
					if (num != 4)
					{
						num2 = 624464035;
						num22 = num2;
					}
					else
					{
						num2 = 624445893;
						num22 = num2;
					}
					continue;
				}
				case 32u:
					return 0;
				case 26u:
					val9 = (Space)(int)LuaScriptMgr.GetNetObject(L, 5, _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(Space).TypeHandle));
					num2 = ((int)num3 * -294699667) ^ -1760869688;
					continue;
				case 33u:
					num19 = (float)LuaScriptMgr.GetNumber(L, 2);
					num20 = (float)LuaScriptMgr.GetNumber(L, 3);
					num21 = (float)LuaScriptMgr.GetNumber(L, 4);
					num2 = ((int)num3 * -748577579) ^ 0x1CD74E04;
					continue;
				case 23u:
					val8 = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(200544826u));
					vector3 = LuaScriptMgr.GetVector3(L, 2);
					num2 = (int)(num3 * 1085008678) ^ -798280798;
					continue;
				case 37u:
					_202C_202C_200F_200E_200B_206C_200E_200C_206B_206A_206F_206D_200C_200F_200D_202E_206D_200F_200F_202D_202C_202E_206A_202B_202B_200C_202A_206E_202E_200B_200D_206E_200B_200E_200C_206E_202D_202D_202D_202E(val8, vector3, num18, val5);
					num2 = ((int)num3 * -404676644) ^ -438390702;
					continue;
				case 27u:
					vector = LuaScriptMgr.GetVector3(L, 2);
					num2 = ((int)num3 * -668044516) ^ 0x6B607B3D;
					continue;
				case 4u:
				{
					int num15;
					if (num == 3)
					{
						num2 = 1536637041;
						num15 = num2;
					}
					else
					{
						num2 = 1551212967;
						num15 = num2;
					}
					continue;
				}
				case 17u:
					val7 = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4128549891u));
					num2 = (int)((num3 * 721165680) ^ 0x7D3D246E);
					continue;
				case 34u:
					val6 = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4128549891u));
					num2 = ((int)num3 * -1465559792) ^ -1164260778;
					continue;
				case 1u:
					num14 = (float)LuaDLL.lua_tonumber(L, 2);
					num2 = (int)(num3 * 657244372) ^ -1769609701;
					continue;
				case 35u:
				{
					int num10;
					if (num != 3)
					{
						num2 = 1009482104;
						num10 = num2;
					}
					else
					{
						num2 = 1398610931;
						num10 = num2;
					}
					continue;
				}
				case 24u:
					vector2 = LuaScriptMgr.GetVector3(L, 2);
					val4 = (Space)(int)LuaScriptMgr.GetLuaObject(L, 3);
					num2 = (int)((num3 * 822460953) ^ 0x2B850674);
					continue;
				case 8u:
				{
					int num8;
					int num9;
					if (num == 2)
					{
						num8 = 71719272;
						num9 = num8;
					}
					else
					{
						num8 = 1092935876;
						num9 = num8;
					}
					num2 = num8 ^ ((int)num3 * -1516355526);
					continue;
				}
				case 0u:
					_206C_200C_206D_206D_200F_202D_202B_202C_206E_202A_206F_202E_202B_200C_206A_200E_206D_206B_200F_200D_206A_206E_200D_206B_200F_206F_200E_202C_206C_206E_206C_200F_200C_200F_206F_202A_206C_206D_202B_200E_202E(val3, vector2, val4);
					return 0;
				case 36u:
					val2 = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2401350092u));
					num2 = (int)((num3 * 2088994409) ^ 0x1D0F265D);
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (LuaScriptMgr.CheckTypes(L, 1, _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(Transform).TypeHandle), _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(LuaTable).TypeHandle), _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(Space).TypeHandle)))
					{
						num4 = -19644199;
						num5 = num4;
					}
					else
					{
						num4 = -2013775634;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 2022358247);
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
	private static int RotateAround(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr.CheckArgsCount(L, 4);
		Transform val = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2401350092u));
		float num3 = default(float);
		Vector3 vector2 = default(Vector3);
		Vector3 vector = default(Vector3);
		while (true)
		{
			int num = -759860558;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1292665761)) % 6)
				{
				case 0u:
					break;
				case 5u:
					num3 = (float)LuaScriptMgr.GetNumber(L, 4);
					num = (int)((num2 * 1783320507) ^ 0x29E0FCBB);
					continue;
				case 1u:
					_200F_202B_200B_206A_206B_200B_200E_200D_200D_206E_202D_200F_202B_200C_206C_206C_206C_206A_202D_200D_206D_200B_206E_206B_206A_206E_206C_202C_206A_206A_202C_200F_206F_206C_206B_202E_200C_206F_202E_200D_202E(val, vector2, vector, num3);
					num = (int)(num2 * 960606516) ^ -956789875;
					continue;
				case 3u:
					vector2 = LuaScriptMgr.GetVector3(L, 2);
					num = (int)((num2 * 482900471) ^ 0x785656A2);
					continue;
				case 2u:
					vector = LuaScriptMgr.GetVector3(L, 3);
					num = (int)(num2 * 1667331771) ^ -1582284988;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int LookAt(IntPtr L)
	{
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected O, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected O, but got Unknown
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		if (num == 2)
		{
			goto IL_000e;
		}
		goto IL_0169;
		IL_000e:
		int num2 = -1063856762;
		goto IL_0013;
		IL_0013:
		Transform val6 = default(Transform);
		Vector3 vector4 = default(Vector3);
		Transform val4 = default(Transform);
		Transform val = default(Transform);
		Vector3 vector2 = default(Vector3);
		Vector3 vector3 = default(Vector3);
		Transform val2 = default(Transform);
		Transform val3 = default(Transform);
		Vector3 vector = default(Vector3);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ -1132514144)) % 21)
			{
			case 14u:
				break;
			case 10u:
			{
				int num8;
				int num9;
				if (LuaScriptMgr.CheckTypes(L, 1, _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(Transform).TypeHandle), _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(Transform).TypeHandle)))
				{
					num8 = -977296668;
					num9 = num8;
				}
				else
				{
					num8 = -239175279;
					num9 = num8;
				}
				num2 = num8 ^ ((int)num3 * -1269701933);
				continue;
			}
			case 7u:
			{
				int num6;
				int num7;
				if (LuaScriptMgr.CheckTypes(L, 1, _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(Transform).TypeHandle), _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(LuaTable).TypeHandle), _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(LuaTable).TypeHandle)))
				{
					num6 = -1539505576;
					num7 = num6;
				}
				else
				{
					num6 = -888971399;
					num7 = num6;
				}
				num2 = num6 ^ ((int)num3 * -1067281295);
				continue;
			}
			case 15u:
			{
				int num10;
				int num11;
				if (LuaScriptMgr.CheckTypes(L, 1, _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(Transform).TypeHandle), _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(Transform).TypeHandle), _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(LuaTable).TypeHandle)))
				{
					num10 = 1822289352;
					num11 = num10;
				}
				else
				{
					num10 = 934690163;
					num11 = num10;
				}
				num2 = num10 ^ ((int)num3 * -1857997960);
				continue;
			}
			case 6u:
				val6 = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4128549891u));
				num2 = ((int)num3 * -1378471276) ^ -2094675473;
				continue;
			case 12u:
				goto IL_0169;
			case 11u:
				vector4 = LuaScriptMgr.GetVector3(L, 3);
				num2 = ((int)num3 * -1999020933) ^ -880778935;
				continue;
			case 19u:
				val4 = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(200544826u));
				num2 = (int)(num3 * 1530720473) ^ -285404000;
				continue;
			case 16u:
			{
				Transform val5 = (Transform)LuaScriptMgr.GetLuaObject(L, 2);
				_202D_202C_200B_202E_206B_202A_200E_200F_206D_206F_202A_202D_202C_206E_200C_206B_200F_206D_206C_200B_202A_202B_206B_202A_202D_200C_200B_200B_206B_206A_200F_206E_200B_202B_202D_202E_206F_206E_200C_206F_202E(val6, val5);
				num2 = ((int)num3 * -89663269) ^ 0x36822528;
				continue;
			}
			case 0u:
				goto IL_01f1;
			case 1u:
				_206E_206F_200D_202B_206A_200D_200E_206E_200F_206A_206F_200B_206D_200D_200D_206F_200D_206F_202C_206B_206E_206F_202A_206C_200E_206E_206F_202C_202D_202B_202A_206D_200C_202A_206A_206A_206D_200E_202D_200E_202E(val, vector2);
				return 0;
			case 17u:
				goto IL_0225;
			case 9u:
				return 0;
			case 3u:
				_206C_206D_206A_200C_202C_206B_200C_200D_200D_200D_206C_202E_202C_200B_200E_200D_206E_206A_206D_200B_200F_200C_202A_206C_202B_206D_202E_206E_206F_206E_206C_202D_200C_206C_206C_200F_200D_202D_202A_202E_202E(val4, vector3, vector4);
				return 0;
			case 18u:
				vector3 = LuaScriptMgr.GetVector3(L, 2);
				num2 = (int)((num3 * 1502854442) ^ 0x685DAF9C);
				continue;
			case 13u:
				_206B_200E_202D_206D_202A_200E_202A_202C_206A_200B_202D_202B_206E_200B_200E_206C_200D_202D_200B_206E_200E_200B_206D_206C_202B_206C_202A_200B_202B_200F_202C_206C_206B_206F_200F_202A_200F_202C_202D_206F_202E(val2, val3, vector);
				return 0;
			case 8u:
				vector2 = LuaScriptMgr.GetVector3(L, 2);
				num2 = (int)(num3 * 1050852698) ^ -364464809;
				continue;
			case 5u:
				val2 = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(200544826u));
				val3 = (Transform)LuaScriptMgr.GetLuaObject(L, 2);
				vector = LuaScriptMgr.GetVector3(L, 3);
				num2 = (int)(num3 * 976993612) ^ -1980992426;
				continue;
			case 4u:
				val = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1820166488u));
				num2 = (int)(num3 * 585320496) ^ -331101614;
				continue;
			case 2u:
			{
				int num4;
				int num5;
				if (LuaScriptMgr.CheckTypes(L, 1, _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(Transform).TypeHandle), _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(LuaTable).TypeHandle)))
				{
					num4 = -700512142;
					num5 = num4;
				}
				else
				{
					num4 = -2004753459;
					num5 = num4;
				}
				num2 = num4 ^ ((int)num3 * -878033944);
				continue;
			}
			default:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1711825689u));
				return 0;
			}
			break;
			IL_0225:
			int num12;
			if (num == 3)
			{
				num2 = -273707480;
				num12 = num2;
			}
			else
			{
				num2 = -670324367;
				num12 = num2;
			}
			continue;
			IL_01f1:
			int num13;
			if (num != 3)
			{
				num2 = -261965005;
				num13 = num2;
			}
			else
			{
				num2 = -71324904;
				num13 = num2;
			}
		}
		goto IL_000e;
		IL_0169:
		int num14;
		if (num != 2)
		{
			num2 = -522925414;
			num14 = num2;
		}
		else
		{
			num2 = -1011732663;
			num14 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int TransformDirection(IntPtr L)
	{
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		if (num == 2)
		{
			goto IL_000b;
		}
		goto IL_004e;
		IL_000b:
		int num2 = -1386815873;
		goto IL_0010;
		IL_0010:
		float num5 = default(float);
		float num6 = default(float);
		Transform val = default(Transform);
		Vector3 vector = default(Vector3);
		Transform val2 = default(Transform);
		Vector3 v = default(Vector3);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ -575642652)) % 10)
			{
			case 2u:
				break;
			case 8u:
				goto IL_004e;
			case 6u:
				num5 = (float)LuaScriptMgr.GetNumber(L, 2);
				num6 = (float)LuaScriptMgr.GetNumber(L, 3);
				num2 = ((int)num3 * -1242531336) ^ 0x32410ECC;
				continue;
			case 4u:
				return 1;
			case 1u:
				val = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1243143517u));
				vector = LuaScriptMgr.GetVector3(L, 2);
				num2 = (int)(num3 * 1703037089) ^ -1447122530;
				continue;
			case 9u:
				val2 = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(200544826u));
				num2 = (int)(num3 * 105900047) ^ -1857614811;
				continue;
			case 7u:
				LuaScriptMgr.Push(L, v);
				num2 = (int)(num3 * 136327395) ^ -839306723;
				continue;
			case 0u:
			{
				float num4 = (float)LuaScriptMgr.GetNumber(L, 4);
				Vector3 v2 = _200D_200C_200E_200F_206E_200D_200F_206F_200D_206A_200E_206A_206F_206F_206B_200E_206D_202D_200B_200E_200D_206D_200C_206C_202C_206E_202B_200C_202A_200F_206A_202C_200F_200C_202C_206F_206D_206C_200D_206A_202E(val2, num5, num6, num4);
				LuaScriptMgr.Push(L, v2);
				return 1;
			}
			case 3u:
				v = _206B_206D_206D_202D_200F_206C_206D_202D_206E_206D_200B_202B_206B_202C_200F_206D_200F_202B_200F_200B_200E_206B_200C_206F_206B_200E_200B_202C_202A_206D_206B_200E_202D_202A_202C_202B_206B_206F_202E_206E_202E(val, vector);
				num2 = ((int)num3 * -849587590) ^ 0x487D028F;
				continue;
			default:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3307001924u));
				return 0;
			}
			break;
		}
		goto IL_000b;
		IL_004e:
		int num7;
		if (num != 4)
		{
			num2 = -318994913;
			num7 = num2;
		}
		else
		{
			num2 = -488847481;
			num7 = num2;
		}
		goto IL_0010;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int InverseTransformDirection(IntPtr L)
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		int num = LuaDLL.lua_gettop(L);
		Vector3 v = default(Vector3);
		Vector3 v2 = default(Vector3);
		while (true)
		{
			int num2 = -950978951;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -653779670)) % 10)
				{
				case 2u:
					break;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3801010018u));
					num2 = -868941650;
					continue;
				case 0u:
				{
					Transform val2 = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2401350092u));
					Vector3 vector = LuaScriptMgr.GetVector3(L, 2);
					v = _206C_202E_202D_200C_206B_206E_206E_200C_202D_206A_200E_200E_202A_206F_206F_202C_200E_206C_200C_202D_200C_202E_206D_206B_200C_206F_206E_202C_202E_206E_206A_202A_202D_202A_202C_200E_200B_206F_206A_206E_202E(val2, vector);
					num2 = ((int)num3 * -1418768901) ^ -2083292951;
					continue;
				}
				case 7u:
					LuaScriptMgr.Push(L, v);
					return 1;
				case 9u:
				{
					Transform val = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1243143517u));
					float num5 = (float)LuaScriptMgr.GetNumber(L, 2);
					float num6 = (float)LuaScriptMgr.GetNumber(L, 3);
					float num7 = (float)LuaScriptMgr.GetNumber(L, 4);
					v2 = _206E_200C_206A_202E_202D_206E_206E_202B_200B_200F_202C_202A_202B_206C_200D_200C_206F_206A_202B_202E_202C_200D_200B_202A_206B_206E_206D_202C_202C_206B_200B_206E_206D_200D_202B_206A_206C_202C_202D_200C_202E(val, num5, num6, num7);
					num2 = ((int)num3 * -1057510242) ^ -2065014133;
					continue;
				}
				case 5u:
				{
					int num8;
					int num9;
					if (num == 2)
					{
						num8 = -1924002216;
						num9 = num8;
					}
					else
					{
						num8 = -1919455337;
						num9 = num8;
					}
					num2 = num8 ^ (int)(num3 * 724315376);
					continue;
				}
				case 3u:
					LuaScriptMgr.Push(L, v2);
					num2 = ((int)num3 * -1780429588) ^ -2015841826;
					continue;
				case 1u:
				{
					int num4;
					if (num == 4)
					{
						num2 = -1017927731;
						num4 = num2;
					}
					else
					{
						num2 = -995850638;
						num4 = num2;
					}
					continue;
				}
				case 6u:
					return 1;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int TransformVector(IntPtr L)
	{
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		if (num == 2)
		{
			goto IL_000e;
		}
		goto IL_0143;
		IL_000e:
		int num2 = -968130814;
		goto IL_0013;
		IL_0013:
		float num5 = default(float);
		float num6 = default(float);
		Transform val2 = default(Transform);
		float num4 = default(float);
		Transform val = default(Transform);
		Vector3 vector = default(Vector3);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ -1012092015)) % 11)
			{
			case 9u:
				break;
			case 2u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(281100941u));
				num2 = -891119308;
				continue;
			case 7u:
				num5 = (float)LuaScriptMgr.GetNumber(L, 3);
				num6 = (float)LuaScriptMgr.GetNumber(L, 4);
				num2 = (int)(num3 * 456193005) ^ -608800555;
				continue;
			case 1u:
			{
				Vector3 v2 = _206F_200F_202A_206A_202B_202B_206B_200D_200D_206D_206C_200F_200E_206D_206D_200D_202E_200E_200C_200C_200B_206D_206F_202B_202B_202D_200E_200B_206E_202D_200B_206A_202E_206E_206E_200C_200E_202E_200B_202B_202E(val2, num4, num5, num6);
				LuaScriptMgr.Push(L, v2);
				num2 = (int)(num3 * 672973658) ^ -45871041;
				continue;
			}
			case 10u:
				val2 = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(200544826u));
				num4 = (float)LuaScriptMgr.GetNumber(L, 2);
				num2 = ((int)num3 * -1433172668) ^ 0x91A0AF5;
				continue;
			case 5u:
			{
				Vector3 v = _200D_202B_202D_200E_206A_206E_202D_202A_206A_206B_206B_206C_200F_202B_200E_202D_202B_202E_202C_206F_200E_202D_202D_202A_206C_206F_200B_200C_200D_202C_206B_200B_206B_200C_200D_206D_202A_202C_200E_202A_202E(val, vector);
				LuaScriptMgr.Push(L, v);
				return 1;
			}
			case 0u:
				vector = LuaScriptMgr.GetVector3(L, 2);
				num2 = ((int)num3 * -1329070843) ^ -185066835;
				continue;
			case 8u:
				return 1;
			case 6u:
				goto IL_0143;
			case 3u:
				val = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1243143517u));
				num2 = ((int)num3 * -610810931) ^ 0x72A6F004;
				continue;
			default:
				return 0;
			}
			break;
		}
		goto IL_000e;
		IL_0143:
		int num7;
		if (num == 4)
		{
			num2 = -418141199;
			num7 = num2;
		}
		else
		{
			num2 = -1206614639;
			num7 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int InverseTransformVector(IntPtr L)
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		int num = LuaDLL.lua_gettop(L);
		if (num == 2)
		{
			goto IL_000e;
		}
		goto IL_00dd;
		IL_000e:
		int num2 = -1607211651;
		goto IL_0013;
		IL_0013:
		float num6 = default(float);
		Transform val2 = default(Transform);
		float num5 = default(float);
		Transform val = default(Transform);
		float num4 = default(float);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ -629285946)) % 13)
			{
			case 12u:
				break;
			case 10u:
				return 1;
			case 2u:
				num6 = (float)LuaScriptMgr.GetNumber(L, 4);
				num2 = ((int)num3 * -954434308) ^ -683979892;
				continue;
			case 9u:
				val2 = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1243143517u));
				num2 = (int)((num3 * 2027315803) ^ 0x31940B72);
				continue;
			case 11u:
			{
				Vector3 vector = LuaScriptMgr.GetVector3(L, 2);
				Vector3 v2 = _206A_200C_202D_206C_206C_206F_202C_200B_202E_206C_206D_202D_206E_206B_200F_206B_206A_206D_200B_206B_206F_200B_206C_200E_202A_206D_200C_206A_202B_206A_200D_200F_200D_200D_206B_206D_202E_200D_206A_206F_202E(val2, vector);
				LuaScriptMgr.Push(L, v2);
				num2 = ((int)num3 * -82031937) ^ -2005857455;
				continue;
			}
			case 3u:
				goto IL_00dd;
			case 5u:
				num5 = (float)LuaScriptMgr.GetNumber(L, 3);
				num2 = ((int)num3 * -93302577) ^ 0x55A337B1;
				continue;
			case 1u:
				val = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4128549891u));
				num2 = ((int)num3 * -610646938) ^ -1120381131;
				continue;
			case 6u:
				num4 = (float)LuaScriptMgr.GetNumber(L, 2);
				num2 = (int)((num3 * 1107708518) ^ 0x2DF42973);
				continue;
			case 7u:
			{
				Vector3 v = _202D_202E_202B_206F_206D_202E_206B_206A_202C_200C_206F_206A_202A_200B_206C_202A_206F_200C_202E_200D_202B_206C_202E_202E_200C_202A_200D_202E_202D_200B_206A_200F_202D_202D_206D_202C_200B_206A_206C_200D_202E(val, num4, num5, num6);
				LuaScriptMgr.Push(L, v);
				num2 = ((int)num3 * -615434505) ^ 0x1ED8EC7F;
				continue;
			}
			case 4u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(254207541u));
				num2 = -116683180;
				continue;
			case 8u:
				return 1;
			default:
				return 0;
			}
			break;
		}
		goto IL_000e;
		IL_00dd:
		int num7;
		if (num != 4)
		{
			num2 = -607929461;
			num7 = num2;
		}
		else
		{
			num2 = -1247161468;
			num7 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int TransformPoint(IntPtr L)
	{
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		int num = LuaDLL.lua_gettop(L);
		if (num == 2)
		{
			goto IL_000e;
		}
		goto IL_013f;
		IL_000e:
		int num2 = -1464662916;
		goto IL_0013;
		IL_0013:
		Vector3 v = default(Vector3);
		Transform val = default(Transform);
		float num4 = default(float);
		float num5 = default(float);
		float num6 = default(float);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ -1475997896)) % 9)
			{
			case 6u:
				break;
			case 0u:
				return 1;
			case 8u:
				LuaScriptMgr.Push(L, v);
				num2 = (int)((num3 * 564753796) ^ 0x67D44AEC);
				continue;
			case 2u:
			{
				Transform val2 = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1243143517u));
				Vector3 vector = LuaScriptMgr.GetVector3(L, 2);
				Vector3 v2 = _200C_200E_202E_206D_200E_202B_206A_200C_206E_202C_206A_200D_202B_206A_200B_202D_206F_206F_202A_206D_206A_206F_200D_200B_206E_206F_202B_202B_206A_200F_206A_200E_206F_200F_200D_206C_206F_200F_202A_202C_202E(val2, vector);
				LuaScriptMgr.Push(L, v2);
				return 1;
			}
			case 7u:
				v = _206A_202C_200E_200F_206B_206C_202A_202E_206E_202A_202A_200F_202E_206E_202A_206A_202E_202D_206F_206B_206D_202E_200B_200C_206C_202B_200C_206B_200E_200C_200B_200F_206E_202C_206E_206B_206A_206C_200B_206C_202E(val, num4, num5, num6);
				num2 = (int)((num3 * 304713186) ^ 0x5C56EF76);
				continue;
			case 4u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(315936762u));
				num2 = -1205416642;
				continue;
			case 1u:
				val = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1243143517u));
				num4 = (float)LuaScriptMgr.GetNumber(L, 2);
				num5 = (float)LuaScriptMgr.GetNumber(L, 3);
				num6 = (float)LuaScriptMgr.GetNumber(L, 4);
				num2 = (int)((num3 * 2065494320) ^ 0x3DECF28A);
				continue;
			case 3u:
				goto IL_013f;
			default:
				return 0;
			}
			break;
		}
		goto IL_000e;
		IL_013f:
		int num7;
		if (num != 4)
		{
			num2 = -241192324;
			num7 = num2;
		}
		else
		{
			num2 = -1704285714;
			num7 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int InverseTransformPoint(IntPtr L)
	{
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		int num = LuaDLL.lua_gettop(L);
		if (num == 2)
		{
			goto IL_000e;
		}
		goto IL_00fb;
		IL_000e:
		int num2 = 147190918;
		goto IL_0013;
		IL_0013:
		Transform val = default(Transform);
		Vector3 v = default(Vector3);
		Transform val2 = default(Transform);
		Vector3 vector = default(Vector3);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ 0x4DBF3A8F)) % 10)
			{
			case 4u:
				break;
			case 5u:
				val = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4128549891u));
				num2 = ((int)num3 * -1748541599) ^ 0x230AD0A9;
				continue;
			case 9u:
				LuaScriptMgr.Push(L, v);
				return 1;
			case 1u:
				val2 = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(200544826u));
				num2 = ((int)num3 * -148093556) ^ 0x76E303F9;
				continue;
			case 2u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2862853461u));
				num2 = 185574655;
				continue;
			case 3u:
			{
				Vector3 v2 = _202E_206C_202D_200F_202D_202A_200D_206E_206E_200E_202A_200B_206D_200B_202E_206F_200C_206E_200B_200C_206B_200F_200D_206B_206F_206B_206E_206D_206B_202E_206A_200F_200B_206F_206D_206E_200E_202D_206B_202E(val2, vector);
				LuaScriptMgr.Push(L, v2);
				return 1;
			}
			case 0u:
				goto IL_00fb;
			case 7u:
			{
				float num4 = (float)LuaScriptMgr.GetNumber(L, 2);
				float num5 = (float)LuaScriptMgr.GetNumber(L, 3);
				float num6 = (float)LuaScriptMgr.GetNumber(L, 4);
				v = _200E_200E_206E_206F_200B_202E_200B_206F_200B_202B_206C_202E_206C_206C_202A_206B_206F_200E_202C_200E_200C_206C_206E_202E_202D_200B_200E_206B_202A_206E_206B_206C_200B_206C_206F_202D_202D_202E_206F_200F_202E(val, num4, num5, num6);
				num2 = ((int)num3 * -1241080058) ^ 0x616B1010;
				continue;
			}
			case 8u:
				vector = LuaScriptMgr.GetVector3(L, 2);
				num2 = ((int)num3 * -1975994793) ^ -1271627274;
				continue;
			default:
				return 0;
			}
			break;
		}
		goto IL_000e;
		IL_00fb:
		int num7;
		if (num != 4)
		{
			num2 = 1506874283;
			num7 = num2;
		}
		else
		{
			num2 = 651924450;
			num7 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int DetachChildren(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 1);
		Transform val = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2401350092u));
		_202D_200C_206B_200E_206E_206E_206E_202B_200B_200C_202A_200C_206B_202A_200F_200F_202A_200B_206D_200E_202D_200F_202B_202E_206E_202B_200E_200B_206E_200C_206B_202D_200D_206A_202E_206E_202A_206D_206D_206D_202E(val);
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SetAsFirstSibling(IntPtr L)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 1);
		while (true)
		{
			int num = 1467638071;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2A8730EE)) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_0029;
				default:
					return 0;
				}
				break;
				IL_0029:
				Transform val = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1243143517u));
				_202A_200E_206A_206A_202E_200F_206B_206C_206D_206B_206E_200F_206E_200E_200E_200C_202B_200B_206C_206A_202E_200F_200B_202C_206C_206A_200E_206C_202C_206C_200E_200E_200C_206D_206F_206B_202C_206C_206A_200E_202E(val);
				num = (int)((num2 * 1696304361) ^ 0x2566A89D);
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SetAsLastSibling(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 1);
		Transform val = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4128549891u));
		_202B_200F_200F_202E_206F_200B_200C_206C_206A_206A_206F_202E_200F_206F_206B_206D_202A_200E_206B_206E_206A_202B_202B_206C_202E_206A_202B_202B_202D_202E_206E_202D_200E_206D_200F_202C_206B_200F_206C_200F_202E(val);
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SetSiblingIndex(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		Transform val = default(Transform);
		while (true)
		{
			int num = -1365364355;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -26881858)) % 4)
				{
				case 0u:
					break;
				case 3u:
					val = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2401350092u));
					num = ((int)num2 * -1064173262) ^ 0x4B09C3E5;
					continue;
				case 1u:
				{
					int num3 = (int)LuaScriptMgr.GetNumber(L, 2);
					_206D_206F_202A_202B_200E_202E_200D_202A_206E_200E_206B_200D_206B_206F_200E_206F_202B_206F_200E_202E_200C_202D_202E_206D_200F_206A_202C_206F_200B_202D_200D_206D_202B_202A_202D_200C_200E_206B_202B_200C_202E(val, num3);
					num = (int)((num2 * 13389428) ^ 0xFDA974C);
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
	private static int GetSiblingIndex(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 1);
		int d = default(int);
		while (true)
		{
			int num = -862749722;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1107542799)) % 4)
				{
				case 0u:
					break;
				case 3u:
				{
					Transform val = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1243143517u));
					d = _202C_202E_202E_200B_206B_202C_206B_202D_200C_206E_206F_206D_202D_200C_200D_200B_202B_200D_200C_200E_202B_206C_206D_206B_206F_200B_200C_200B_206C_200D_202E_202A_202D_202C_200D_202E_200D_206E_206C_206F_202E(val);
					num = ((int)num2 * -1830327186) ^ 0x595C0212;
					continue;
				}
				case 1u:
					LuaScriptMgr.Push(L, d);
					num = (int)((num2 * 40867921) ^ 0x15A2439E);
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Find(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		Transform val = default(Transform);
		string luaString = default(string);
		while (true)
		{
			int num = 340212540;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x457330FE)) % 4)
				{
				case 0u:
					break;
				case 2u:
					val = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1820166488u));
					num = ((int)num2 * -1952517247) ^ -1751898443;
					continue;
				case 1u:
					luaString = LuaScriptMgr.GetLuaString(L, 2);
					num = (int)(num2 * 793151303) ^ -1585245270;
					continue;
				default:
				{
					Transform obj = _206D_200D_206C_202A_206E_200F_206B_206A_202B_206F_202E_206D_200E_206B_206E_206A_202C_206D_206C_202D_206A_202C_202A_200D_202B_202B_200E_202D_202E_200F_200D_206B_202E_206F_202E_200D_202A_206D_206D_202B_202E(val, luaString);
					LuaScriptMgr.Push(L, (Object)(object)obj);
					return 1;
				}
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int IsChildOf(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		Transform val = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1243143517u));
		bool b = default(bool);
		Transform val2 = default(Transform);
		while (true)
		{
			int num = 1409596473;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0xBE3CD87)) % 5)
				{
				case 0u:
					break;
				case 1u:
					LuaScriptMgr.Push(L, b);
					num = ((int)num2 * -301743089) ^ -1885761754;
					continue;
				case 2u:
					b = _200B_200C_202A_200B_206B_202E_202D_200D_202D_202D_202D_206A_200B_202A_202B_206C_202C_200C_200D_206E_206F_206F_202A_202E_206C_206D_200B_206E_206C_206A_202D_206E_202D_206C_200F_206C_200E_202B_200B_202D_202E(val, val2);
					num = ((int)num2 * -1168050989) ^ -1572213147;
					continue;
				case 4u:
					val2 = (Transform)LuaScriptMgr.GetUnityObject(L, 2, _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(typeof(Transform).TypeHandle));
					num = ((int)num2 * -131724504) ^ -2001958459;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int FindChild(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		Transform val = default(Transform);
		Transform obj = default(Transform);
		while (true)
		{
			int num = 1733990403;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x38F2B97E)) % 5)
				{
				case 4u:
					break;
				case 1u:
					val = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2401350092u));
					num = (int)(num2 * 1170207637) ^ -1150267872;
					continue;
				case 2u:
					LuaScriptMgr.Push(L, (Object)(object)obj);
					num = (int)((num2 * 610728978) ^ 0x6EF31731);
					continue;
				case 0u:
				{
					string luaString = LuaScriptMgr.GetLuaString(L, 2);
					obj = _200E_206A_200E_206D_206D_206C_202C_206C_206F_202A_206D_206F_202A_206A_206A_202C_200C_202A_206B_206F_200E_206A_206D_202B_200B_200F_206E_200D_202C_200E_206E_202B_202D_206D_202B_202E_202A_200C_202D_200D_202E(val, luaString);
					num = (int)((num2 * 1358126275) ^ 0x7A404BCD);
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
	private static int GetEnumerator(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 1);
		Transform val = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(200544826u));
		IEnumerator o = default(IEnumerator);
		while (true)
		{
			int num = 1169935044;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x289D5919)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0040;
				default:
					LuaScriptMgr.Push(L, o);
					return 1;
				}
				break;
				IL_0040:
				o = _206E_202A_206C_200B_206F_200E_206C_206A_206A_206D_206C_200E_202A_206B_200E_206D_206F_202C_206E_202E_206C_202E_200F_202C_200F_206C_202D_206B_206E_200D_206A_206C_200B_202E_200D_200B_200B_200C_200D_202C_202E(val);
				num = ((int)num2 * -1667558756) ^ 0x488C0F;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetChild(IntPtr L)
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		Transform obj = default(Transform);
		Transform val = default(Transform);
		int num3 = default(int);
		while (true)
		{
			int num = 1277517704;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x205DE7F3)) % 6)
				{
				case 4u:
					break;
				case 2u:
					obj = _202A_202E_202C_200E_206F_200F_200E_206B_200B_202B_202A_206A_206C_202E_206A_206C_202D_202B_202B_206F_206B_206D_202E_206B_202D_200F_206C_206E_206F_200F_200D_202D_200E_202A_206F_206E_206D_206B_206E_200D_202E(val, num3);
					num = ((int)num2 * -356279581) ^ 0x67238E8E;
					continue;
				case 5u:
					num3 = (int)LuaScriptMgr.GetNumber(L, 2);
					num = (int)((num2 * 814965251) ^ 0x70860D00);
					continue;
				case 3u:
					LuaScriptMgr.Push(L, (Object)(object)obj);
					num = ((int)num2 * -70590122) ^ 0x515549B;
					continue;
				case 1u:
					val = (Transform)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2401350092u));
					num = ((int)num2 * -1912204705) ^ 0x55E3EAA5;
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
		while (true)
		{
			int num = 407027984;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6FB70153)) % 4)
				{
				case 0u:
					break;
				case 3u:
				{
					object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
					val = (Object)((luaObject is Object) ? luaObject : null);
					object luaObject2 = LuaScriptMgr.GetLuaObject(L, 2);
					val2 = (Object)((luaObject2 is Object) ? luaObject2 : null);
					num = ((int)num2 * -1059729571) ^ -2116010418;
					continue;
				}
				case 2u:
				{
					bool b = _202D_200F_202B_206E_202E_206C_206D_202E_202A_202A_202E_202B_200C_202E_202D_200C_200B_202E_206C_206F_206A_200B_206C_206B_206E_206A_202D_200E_200B_206B_206C_200C_206E_200C_206A_200E_206F_206E_200F_206F_202E(val, val2);
					LuaScriptMgr.Push(L, b);
					num = ((int)num2 * -349680575) ^ 0x3092D1C;
					continue;
				}
				default:
					return 1;
				}
				break;
			}
		}
	}

	static Type _200C_202C_200D_200C_202C_200B_200F_206C_202B_202C_200C_206B_206B_206D_202B_206E_206C_202B_206A_202C_200B_206A_202B_202B_202D_206F_206E_206E_202D_200D_206D_202B_200D_202E_200B_200B_200B_202B_202B_202C_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static bool _202D_200F_202B_206E_202E_206C_206D_202E_202A_202A_202E_202B_200C_202E_202D_200C_200B_202E_206C_206F_206A_200B_206C_206B_206E_206A_202D_200E_200B_206B_206C_200C_206E_200C_206A_200E_206F_206E_200F_206F_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static Vector3 _202D_202B_202D_206C_202A_202D_202A_200E_206A_200D_200F_202C_206A_202B_206C_202D_202A_202B_206C_206E_202B_202C_206D_206C_202D_202D_206B_200F_202C_200F_200E_206C_200F_206B_206A_200E_200B_206D_206C_202C_202E(Transform P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.position;
	}

	static Vector3 _200C_202C_202D_206E_202C_200C_200C_206C_200C_202E_206F_200E_200F_206C_206F_206F_202E_200B_206A_200E_200D_202C_206A_200D_202A_206B_206D_202C_206B_206B_206D_200B_200E_200E_202C_206D_200F_206E_206D_202A_202E(Transform P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.localPosition;
	}

	static Vector3 _206F_202A_202B_206A_202E_200C_202D_206F_200C_202C_202B_200E_202A_200C_206B_200E_206F_202C_200D_206B_206A_206E_202E_206B_206B_206A_206F_200D_200E_200B_206F_202E_206A_206F_200C_202C_200D_200E_206F_206D_202E(Transform P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.eulerAngles;
	}

	static Vector3 _206D_202E_202B_202E_200D_202E_206E_202C_202B_200B_202B_202C_200D_202D_202A_206C_206B_200B_202D_202C_202A_206E_206B_200C_200B_202B_206D_200E_202E_202A_206C_206B_206C_206C_200B_200B_200F_200E_202D_206F_202E(Transform P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.localEulerAngles;
	}

	static Vector3 _206F_200C_202E_200D_202C_200C_206F_202A_206E_200B_202B_206D_206F_202D_202E_206D_202D_202C_206D_206E_206C_206B_202C_206D_200D_206B_202A_206B_202A_200F_206A_202B_206B_200C_206D_200C_206D_206C_206A_200D_202E(Transform P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.right;
	}

	static Vector3 _206C_202D_200F_200E_202A_202A_200E_206A_200E_200C_206F_200B_200D_202D_206B_202B_200F_200F_202B_206B_200D_206D_202D_200E_202C_206C_200E_206B_202B_202D_202D_206C_206E_202C_202B_200F_202B_200D_206C_206F_202E(Transform P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.up;
	}

	static Vector3 _206A_202C_206C_202B_202E_200D_200D_206E_200B_200C_206D_200C_200C_206D_206B_202E_206A_202E_206F_200B_202A_206F_202D_200F_200F_202D_200D_202D_200B_200D_206C_206A_202D_202A_202B_206E_202C_200C_200E_202B_202E(Transform P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.forward;
	}

	static Quaternion _200B_206A_206C_200C_202A_202D_200B_200B_206B_202C_206D_202A_206C_200D_200B_202A_200E_202E_202A_206B_202C_200F_206B_200C_206B_200B_206C_202C_200B_200B_200B_200B_200E_200B_200E_206B_202A_202A_202D_202C_202E(Transform P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.rotation;
	}

	static Quaternion _200C_206E_202B_202B_202E_202C_206B_200F_200D_200B_206E_200D_202D_202C_200F_206C_200E_206A_206A_206D_200E_206D_206A_202E_202B_206A_206E_206B_200F_206C_200E_206A_206F_206A_200D_206E_202C_206C_206C_206A_202E(Transform P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.localRotation;
	}

	static Vector3 _200D_200E_200C_200F_202B_200F_200E_206E_200C_200F_206B_206E_202C_200F_200F_202B_206E_200B_202B_200B_200E_206D_200D_206F_206F_200D_202A_206F_200F_202E_200D_202E_202A_202C_202E_206B_206C_202A_206D_206D_202E(Transform P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.localScale;
	}

	static Transform _200C_206F_200F_202D_200F_200F_202A_202A_202E_202C_206A_206B_206E_200B_202C_202E_202D_200F_200B_206D_206E_200D_206D_206C_206E_200E_200C_202A_200C_202A_206E_206B_202B_202E_200B_202C_202D_206F_200D_200D_202E(Transform P_0)
	{
		return P_0.parent;
	}

	static Matrix4x4 _202A_200F_202B_202D_206B_206C_200F_200C_206F_200F_200E_202A_206A_206A_200E_206C_202D_202C_200C_202E_200B_202B_206E_206E_200B_200E_202A_200E_206D_206A_202D_206F_202C_200D_202A_202E_206E_202D_206C_202C_202E(Transform P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.worldToLocalMatrix;
	}

	static Matrix4x4 _200D_202E_200D_200B_206D_206E_206B_206A_206D_206D_202B_200B_206E_206D_202C_200C_202E_202D_202A_200F_200E_200E_200F_206A_200B_200B_202E_200D_206A_202C_200F_202B_200E_200B_206E_202B_200C_200D_200F_202D_202E(Transform P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.localToWorldMatrix;
	}

	static Transform _200F_206E_200D_206C_206B_206F_202C_206F_202C_206F_200D_202C_202D_206F_200B_202D_202C_200F_200E_200E_202C_202D_206F_200E_200F_206D_206C_202A_206A_206E_200B_206A_202C_200F_200F_206B_202C_206A_200D_200F_202E(Transform P_0)
	{
		return P_0.root;
	}

	static int _206D_200D_206B_200D_200F_202D_200E_200B_206C_200C_200B_202C_202B_206D_206B_202C_206F_206F_202C_200E_206E_206F_206D_200D_206B_200D_202B_200B_206D_206D_206C_200D_206A_202A_200C_206A_202E_202D_202E_200E_202E(Transform P_0)
	{
		return P_0.childCount;
	}

	static Vector3 _202D_206E_206D_206D_200C_202C_202B_202E_202C_200C_200D_200E_206F_206B_200E_200B_206D_200E_206F_202E_200C_206B_200C_206C_202D_206F_202C_206A_206A_202A_206D_206D_206A_206B_206A_202B_200E_200D_200B_202A_202E(Transform P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.lossyScale;
	}

	static bool _200C_202A_206D_202A_206F_202D_202A_200B_202B_202C_202C_206E_206C_200B_206E_202D_202B_200C_206F_206C_206F_200F_206B_200E_202E_200B_200C_200C_206D_206A_206B_200D_200E_206C_206C_200B_202D_202D_202A_206A_202E(Transform P_0)
	{
		return P_0.hasChanged;
	}

	static void _200D_200C_202C_202C_202D_200C_206F_202B_206A_206C_200E_202D_206B_202B_200D_206C_202D_202E_200D_206E_206D_202D_200B_206B_200E_200B_206A_200D_206A_206D_202B_206B_202D_206C_202D_200B_206B_202C_202E_200D_202E(Transform P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.position = P_1;
	}

	static void _202C_202C_202B_202D_202B_200D_206B_206D_202C_202B_206D_202C_200B_206C_206A_206B_202A_202E_206A_206B_206F_202C_206E_200B_200E_200E_206A_200C_200C_206B_206E_202D_200D_202A_206B_200D_202E_202A_206C_200F_202E(Transform P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.localPosition = P_1;
	}

	static void _206A_202D_206C_206E_206F_200C_206B_200F_202D_202A_202D_200B_206D_206E_206F_202E_200E_202A_200F_200D_206F_202E_206C_202E_202E_202D_206E_200E_206B_206B_202A_200E_202E_206C_206A_202C_200E_202C_200B_200E_202E(Transform P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.eulerAngles = P_1;
	}

	static void _202B_200D_200B_200E_202B_206F_202D_202B_202C_206B_206A_206A_202B_200D_200C_200F_206B_202C_202C_200F_202E_206B_202C_202D_200B_206A_202D_200E_200F_200B_202D_200C_206D_202B_202C_202C_206F_200B_206A_206E_202E(Transform P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.localEulerAngles = P_1;
	}

	static void _202E_202A_206B_206D_206C_200C_202D_200E_206A_206B_200E_200E_206E_206C_206C_206F_200B_200B_206C_202B_202D_202E_202B_202D_200E_206F_202E_206F_202C_202C_200E_200D_202C_202C_200E_200C_206F_202A_206C_206F_202E(Transform P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.right = P_1;
	}

	static void _200C_200F_202A_202B_202C_200F_202A_206F_206E_200D_206C_200B_202B_202C_206B_200F_202C_206F_206B_200F_200E_200C_202B_206E_200D_200B_200C_200E_202C_200C_200F_200D_206F_206D_206B_200B_206A_202D_206D_202D_202E(Transform P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.up = P_1;
	}

	static void _206E_206B_202B_202A_202D_202D_202B_206B_206D_206D_202C_200F_202C_206C_202C_202D_206B_200F_206C_200F_206B_206C_206F_200E_200F_206A_200F_206D_202E_206D_206D_202C_202A_206A_202D_200E_202E_206B_206C_200C_202E(Transform P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.forward = P_1;
	}

	static void _202C_200B_200C_200F_206F_200C_200B_202A_200D_200D_206E_202B_206D_200E_200C_206D_200C_202C_200D_206B_200E_206B_206F_200B_206D_206F_200C_206D_206A_206D_206F_206B_206D_202B_206D_200F_206B_206E_202C_206F_202E(Transform P_0, Quaternion P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.rotation = P_1;
	}

	static void _200B_206B_200E_202C_206B_206D_200F_206D_202D_206C_202D_202C_206E_202A_200D_206E_206C_200B_206D_202B_206C_200E_200D_202B_202C_200D_206D_206B_206B_202D_202D_200D_206D_200E_202E_202D_202D_200F_200F_206B_202E(Transform P_0, Quaternion P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.localRotation = P_1;
	}

	static void _200E_200F_202A_206D_200F_200E_206B_206A_202E_200E_202C_200F_206F_206D_202D_206D_200E_206A_200C_200B_200B_206C_202E_200F_202E_206A_202A_206D_206C_200F_206E_200C_200E_200F_206A_206E_206E_202A_200C_202C_202E(Transform P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.localScale = P_1;
	}

	static void _202D_200E_206F_200F_206E_202E_202A_206B_200D_200E_200E_200B_202A_200E_206B_206E_206A_202D_206F_200D_202B_202C_206A_200B_202E_206A_202E_206A_206B_206E_206E_200D_202E_206A_200C_202E_200D_200B_200F_202D_202E(Transform P_0, Transform P_1)
	{
		P_0.parent = P_1;
	}

	static void _202B_206A_202D_202C_206E_200F_202A_202D_206B_202C_206C_206A_206F_202A_206E_200D_206F_200C_200E_206D_202B_200D_206E_200C_202D_200D_200C_200D_202B_206E_206C_206C_206C_200E_206E_202A_206F_200D_202D_202E_202E(Transform P_0, bool P_1)
	{
		P_0.hasChanged = P_1;
	}

	static void _200D_202A_206C_200B_200C_200D_200B_206A_200F_202E_200E_200D_200E_200D_206C_200C_202E_202D_200B_200E_200D_206F_202D_206E_200B_202A_206D_200B_202E_206E_200E_200D_202E_202E_206F_206E_206D_202B_200F_202A_202E(Transform P_0, Transform P_1)
	{
		P_0.SetParent(P_1);
	}

	static void _206D_200D_206A_202A_202C_200F_200D_200D_202B_206A_206F_202B_206E_200C_202E_202E_206F_206B_206E_200D_200E_206B_206C_206F_206A_202A_200C_202B_200D_202D_206C_206E_200D_206C_206A_202D_202A_200D_200D_200D_202E(Transform P_0, Transform P_1, bool P_2)
	{
		P_0.SetParent(P_1, P_2);
	}

	static void _202D_202C_202D_206D_202C_206A_200B_202C_206D_202B_202C_200B_202E_202E_202D_202A_200E_202E_200C_206B_206F_206D_202A_202E_206C_200D_200D_200B_206C_206E_202C_202B_202C_206F_202E_200D_202C_202A_206F_206B_202E(Transform P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.Translate(P_1);
	}

	static void _200E_202A_202A_206D_202D_206C_202E_200D_200C_200B_206E_206A_200D_206C_202E_202D_206B_206B_202B_202B_202B_206F_200D_206D_202E_206A_200C_206C_200F_200C_200C_200D_206E_200D_206C_202B_206A_202D_206F_202D_202E(Transform P_0, Vector3 P_1, Transform P_2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.Translate(P_1, P_2);
	}

	static void _206A_206A_202D_202D_200F_206C_200D_206A_206B_200C_202D_206D_202E_202B_206A_206E_206C_200C_206D_206A_206E_202C_202E_200D_206F_200E_200C_200F_206B_200D_202C_206F_206A_202D_202E_206C_200D_200D_202D_200D_202E(Transform P_0, Vector3 P_1, Space P_2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		P_0.Translate(P_1, P_2);
	}

	static void _206F_200C_206F_202B_200D_202D_200F_206F_200B_200E_206A_202E_202B_200B_200E_200C_206B_202A_200F_200E_202B_206D_200F_200B_202B_202C_202D_202B_200C_206F_206C_202B_206D_206C_206C_202A_206F_206E_206B_202D_202E(Transform P_0, float P_1, float P_2, float P_3)
	{
		P_0.Translate(P_1, P_2, P_3);
	}

	static void _202A_200E_206D_202D_202D_202D_200E_200D_200F_206F_200C_202C_206E_202E_202B_202C_202C_200E_202D_202E_202C_206C_202E_200E_206F_202E_206A_200F_202B_206A_200F_200F_202A_202E_200B_202D_200F_206A_206F_202E_202E(Transform P_0, float P_1, float P_2, float P_3, Transform P_4)
	{
		P_0.Translate(P_1, P_2, P_3, P_4);
	}

	static void _200F_202C_200F_200B_206E_200B_200B_206A_206B_206C_202A_200D_200D_206C_200B_202A_202E_200F_206D_206C_206A_202A_206A_202C_200C_200D_200B_200C_200C_206A_200B_206A_206B_206D_206B_202D_202B_202A_202B_206B_202E(Transform P_0, float P_1, float P_2, float P_3, Space P_4)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		P_0.Translate(P_1, P_2, P_3, P_4);
	}

	static void _206B_206E_202B_202D_200D_200D_200F_206D_206A_202B_200C_206F_202D_206E_202A_206F_206A_206B_206B_206B_202B_206C_200B_206D_206C_206F_200D_206F_202A_200B_206A_200D_206B_200C_200B_202C_206D_202D_202A_202B_202E(Transform P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.Rotate(P_1);
	}

	static void _206D_202A_206F_206F_206D_202A_206B_206E_206B_202C_202C_202D_206A_206B_200E_200C_200F_206D_206C_202A_200C_202D_200D_200B_200C_202B_200E_206C_206B_206E_200F_206C_206D_206B_200D_200D_206C_202B_200D_206A_202E(Transform P_0, Vector3 P_1, float P_2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.Rotate(P_1, P_2);
	}

	static void _206C_200C_206D_206D_200F_202D_202B_202C_206E_202A_206F_202E_202B_200C_206A_200E_206D_206B_200F_200D_206A_206E_200D_206B_200F_206F_200E_202C_206C_206E_206C_200F_200C_200F_206F_202A_206C_206D_202B_200E_202E(Transform P_0, Vector3 P_1, Space P_2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		P_0.Rotate(P_1, P_2);
	}

	static void _202C_202C_200F_200E_200B_206C_200E_200C_206B_206A_206F_206D_200C_200F_200D_202E_206D_200F_200F_202D_202C_202E_206A_202B_202B_200C_202A_206E_202E_200B_200D_206E_200B_200E_200C_206E_202D_202D_202D_202E(Transform P_0, Vector3 P_1, float P_2, Space P_3)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		P_0.Rotate(P_1, P_2, P_3);
	}

	static void _202A_206F_202D_206C_200F_202B_206D_200D_206D_202B_200C_206E_200C_202C_202A_206C_206B_206A_202E_200C_200E_200B_202B_202D_200F_200D_206A_206B_202C_206A_200E_200B_200E_200C_206F_202B_200F_202E_202E_202E(Transform P_0, float P_1, float P_2, float P_3)
	{
		P_0.Rotate(P_1, P_2, P_3);
	}

	static void _202D_202B_202A_202A_202E_200C_200D_200F_206C_206E_206F_206F_206A_200B_202C_206F_202A_200F_202A_200F_206E_206B_206F_200E_200F_202C_202A_206F_206C_206E_206B_206B_202A_202D_206A_200C_206E_200B_200D_202C_202E(Transform P_0, float P_1, float P_2, float P_3, Space P_4)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		P_0.Rotate(P_1, P_2, P_3, P_4);
	}

	static void _200F_202B_200B_206A_206B_200B_200E_200D_200D_206E_202D_200F_202B_200C_206C_206C_206C_206A_202D_200D_206D_200B_206E_206B_206A_206E_206C_202C_206A_206A_202C_200F_206F_206C_206B_202E_200C_206F_202E_200D_202E(Transform P_0, Vector3 P_1, Vector3 P_2, float P_3)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		P_0.RotateAround(P_1, P_2, P_3);
	}

	static void _206E_206F_200D_202B_206A_200D_200E_206E_200F_206A_206F_200B_206D_200D_200D_206F_200D_206F_202C_206B_206E_206F_202A_206C_200E_206E_206F_202C_202D_202B_202A_206D_200C_202A_206A_206A_206D_200E_202D_200E_202E(Transform P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.LookAt(P_1);
	}

	static void _202D_202C_200B_202E_206B_202A_200E_200F_206D_206F_202A_202D_202C_206E_200C_206B_200F_206D_206C_200B_202A_202B_206B_202A_202D_200C_200B_200B_206B_206A_200F_206E_200B_202B_202D_202E_206F_206E_200C_206F_202E(Transform P_0, Transform P_1)
	{
		P_0.LookAt(P_1);
	}

	static void _206C_206D_206A_200C_202C_206B_200C_200D_200D_200D_206C_202E_202C_200B_200E_200D_206E_206A_206D_200B_200F_200C_202A_206C_202B_206D_202E_206E_206F_206E_206C_202D_200C_206C_206C_200F_200D_202D_202A_202E_202E(Transform P_0, Vector3 P_1, Vector3 P_2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		P_0.LookAt(P_1, P_2);
	}

	static void _206B_200E_202D_206D_202A_200E_202A_202C_206A_200B_202D_202B_206E_200B_200E_206C_200D_202D_200B_206E_200E_200B_206D_206C_202B_206C_202A_200B_202B_200F_202C_206C_206B_206F_200F_202A_200F_202C_202D_206F_202E(Transform P_0, Transform P_1, Vector3 P_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		P_0.LookAt(P_1, P_2);
	}

	static Vector3 _206B_206D_206D_202D_200F_206C_206D_202D_206E_206D_200B_202B_206B_202C_200F_206D_200F_202B_200F_200B_200E_206B_200C_206F_206B_200E_200B_202C_202A_206D_206B_200E_202D_202A_202C_202B_206B_206F_202E_206E_202E(Transform P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return P_0.TransformDirection(P_1);
	}

	static Vector3 _200D_200C_200E_200F_206E_200D_200F_206F_200D_206A_200E_206A_206F_206F_206B_200E_206D_202D_200B_200E_200D_206D_200C_206C_202C_206E_202B_200C_202A_200F_206A_202C_200F_200C_202C_206F_206D_206C_200D_206A_202E(Transform P_0, float P_1, float P_2, float P_3)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return P_0.TransformDirection(P_1, P_2, P_3);
	}

	static Vector3 _206C_202E_202D_200C_206B_206E_206E_200C_202D_206A_200E_200E_202A_206F_206F_202C_200E_206C_200C_202D_200C_202E_206D_206B_200C_206F_206E_202C_202E_206E_206A_202A_202D_202A_202C_200E_200B_206F_206A_206E_202E(Transform P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return P_0.InverseTransformDirection(P_1);
	}

	static Vector3 _206E_200C_206A_202E_202D_206E_206E_202B_200B_200F_202C_202A_202B_206C_200D_200C_206F_206A_202B_202E_202C_200D_200B_202A_206B_206E_206D_202C_202C_206B_200B_206E_206D_200D_202B_206A_206C_202C_202D_200C_202E(Transform P_0, float P_1, float P_2, float P_3)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return P_0.InverseTransformDirection(P_1, P_2, P_3);
	}

	static Vector3 _200D_202B_202D_200E_206A_206E_202D_202A_206A_206B_206B_206C_200F_202B_200E_202D_202B_202E_202C_206F_200E_202D_202D_202A_206C_206F_200B_200C_200D_202C_206B_200B_206B_200C_200D_206D_202A_202C_200E_202A_202E(Transform P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return P_0.TransformVector(P_1);
	}

	static Vector3 _206F_200F_202A_206A_202B_202B_206B_200D_200D_206D_206C_200F_200E_206D_206D_200D_202E_200E_200C_200C_200B_206D_206F_202B_202B_202D_200E_200B_206E_202D_200B_206A_202E_206E_206E_200C_200E_202E_200B_202B_202E(Transform P_0, float P_1, float P_2, float P_3)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return P_0.TransformVector(P_1, P_2, P_3);
	}

	static Vector3 _206A_200C_202D_206C_206C_206F_202C_200B_202E_206C_206D_202D_206E_206B_200F_206B_206A_206D_200B_206B_206F_200B_206C_200E_202A_206D_200C_206A_202B_206A_200D_200F_200D_200D_206B_206D_202E_200D_206A_206F_202E(Transform P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return P_0.InverseTransformVector(P_1);
	}

	static Vector3 _202D_202E_202B_206F_206D_202E_206B_206A_202C_200C_206F_206A_202A_200B_206C_202A_206F_200C_202E_200D_202B_206C_202E_202E_200C_202A_200D_202E_202D_200B_206A_200F_202D_202D_206D_202C_200B_206A_206C_200D_202E(Transform P_0, float P_1, float P_2, float P_3)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return P_0.InverseTransformVector(P_1, P_2, P_3);
	}

	static Vector3 _200C_200E_202E_206D_200E_202B_206A_200C_206E_202C_206A_200D_202B_206A_200B_202D_206F_206F_202A_206D_206A_206F_200D_200B_206E_206F_202B_202B_206A_200F_206A_200E_206F_200F_200D_206C_206F_200F_202A_202C_202E(Transform P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return P_0.TransformPoint(P_1);
	}

	static Vector3 _206A_202C_200E_200F_206B_206C_202A_202E_206E_202A_202A_200F_202E_206E_202A_206A_202E_202D_206F_206B_206D_202E_200B_200C_206C_202B_200C_206B_200E_200C_200B_200F_206E_202C_206E_206B_206A_206C_200B_206C_202E(Transform P_0, float P_1, float P_2, float P_3)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return P_0.TransformPoint(P_1, P_2, P_3);
	}

	static Vector3 _202E_206C_202D_200F_202D_202A_200D_206E_206E_200E_202A_200B_206D_200B_202E_206F_200C_206E_200B_200C_206B_200F_200D_206B_206F_206B_206E_206D_206B_202E_206A_200F_200B_206F_206D_206E_200E_202D_206B_202E(Transform P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return P_0.InverseTransformPoint(P_1);
	}

	static Vector3 _200E_200E_206E_206F_200B_202E_200B_206F_200B_202B_206C_202E_206C_206C_202A_206B_206F_200E_202C_200E_200C_206C_206E_202E_202D_200B_200E_206B_202A_206E_206B_206C_200B_206C_206F_202D_202D_202E_206F_200F_202E(Transform P_0, float P_1, float P_2, float P_3)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return P_0.InverseTransformPoint(P_1, P_2, P_3);
	}

	static void _202D_200C_206B_200E_206E_206E_206E_202B_200B_200C_202A_200C_206B_202A_200F_200F_202A_200B_206D_200E_202D_200F_202B_202E_206E_202B_200E_200B_206E_200C_206B_202D_200D_206A_202E_206E_202A_206D_206D_206D_202E(Transform P_0)
	{
		P_0.DetachChildren();
	}

	static void _202A_200E_206A_206A_202E_200F_206B_206C_206D_206B_206E_200F_206E_200E_200E_200C_202B_200B_206C_206A_202E_200F_200B_202C_206C_206A_200E_206C_202C_206C_200E_200E_200C_206D_206F_206B_202C_206C_206A_200E_202E(Transform P_0)
	{
		P_0.SetAsFirstSibling();
	}

	static void _202B_200F_200F_202E_206F_200B_200C_206C_206A_206A_206F_202E_200F_206F_206B_206D_202A_200E_206B_206E_206A_202B_202B_206C_202E_206A_202B_202B_202D_202E_206E_202D_200E_206D_200F_202C_206B_200F_206C_200F_202E(Transform P_0)
	{
		P_0.SetAsLastSibling();
	}

	static void _206D_206F_202A_202B_200E_202E_200D_202A_206E_200E_206B_200D_206B_206F_200E_206F_202B_206F_200E_202E_200C_202D_202E_206D_200F_206A_202C_206F_200B_202D_200D_206D_202B_202A_202D_200C_200E_206B_202B_200C_202E(Transform P_0, int P_1)
	{
		P_0.SetSiblingIndex(P_1);
	}

	static int _202C_202E_202E_200B_206B_202C_206B_202D_200C_206E_206F_206D_202D_200C_200D_200B_202B_200D_200C_200E_202B_206C_206D_206B_206F_200B_200C_200B_206C_200D_202E_202A_202D_202C_200D_202E_200D_206E_206C_206F_202E(Transform P_0)
	{
		return P_0.GetSiblingIndex();
	}

	static Transform _206D_200D_206C_202A_206E_200F_206B_206A_202B_206F_202E_206D_200E_206B_206E_206A_202C_206D_206C_202D_206A_202C_202A_200D_202B_202B_200E_202D_202E_200F_200D_206B_202E_206F_202E_200D_202A_206D_206D_202B_202E(Transform P_0, string P_1)
	{
		return P_0.Find(P_1);
	}

	static bool _200B_200C_202A_200B_206B_202E_202D_200D_202D_202D_202D_206A_200B_202A_202B_206C_202C_200C_200D_206E_206F_206F_202A_202E_206C_206D_200B_206E_206C_206A_202D_206E_202D_206C_200F_206C_200E_202B_200B_202D_202E(Transform P_0, Transform P_1)
	{
		return P_0.IsChildOf(P_1);
	}

	static Transform _200E_206A_200E_206D_206D_206C_202C_206C_206F_202A_206D_206F_202A_206A_206A_202C_200C_202A_206B_206F_200E_206A_206D_202B_200B_200F_206E_200D_202C_200E_206E_202B_202D_206D_202B_202E_202A_200C_202D_200D_202E(Transform P_0, string P_1)
	{
		return P_0.FindChild(P_1);
	}

	static IEnumerator _206E_202A_206C_200B_206F_200E_206C_206A_206A_206D_206C_200E_202A_206B_200E_206D_206F_202C_206E_202E_206C_202E_200F_202C_200F_206C_202D_206B_206E_200D_206A_206C_200B_202E_200D_200B_200B_200C_200D_202C_202E(Transform P_0)
	{
		return P_0.GetEnumerator();
	}

	static Transform _202A_202E_202C_200E_206F_200F_200E_206B_200B_202B_202A_206A_206C_202E_206A_206C_202D_202B_202B_206F_206B_206D_202E_206B_202D_200F_206C_206E_206F_200F_200D_202D_200E_202A_206F_206E_206D_206B_206E_200D_202E(Transform P_0, int P_1)
	{
		return P_0.GetChild(P_1);
	}
}
