using System;
using LuaInterface;
using UnityEngine;

public class MaterialWrap
{
	private static Type classType = _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[29]
		{
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2058586672u), SetColor),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(463410437u), GetColor),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(501145930u), SetVector),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3123950337u), GetVector),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(303375752u), SetTexture),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3084911980u), GetTexture),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3171486874u), SetTextureOffset),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1970576489u), GetTextureOffset),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(484810673u), SetTextureScale),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(438131154u), GetTextureScale),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2594260164u), SetMatrix),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(581221805u), GetMatrix),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4292109513u), SetFloat),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3955646851u), GetFloat),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3993382344u), SetInt),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4063328539u), GetInt),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(545173848u), SetBuffer),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3326710076u), HasProperty),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3980911867u), GetTag),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(311642177u), SetOverrideTag),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2682925618u), Lerp),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2253689447u), SetPass),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2221238180u), CopyPropertiesFromMaterial),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3971131561u), EnableKeyword),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3032462231u), DisableKeyword),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2278262613u), IsKeywordEnabled),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2705981273u), _202C_200F_202C_202C_206A_200F_206B_202C_206F_202A_200E_206A_202D_206A_202A_206A_202C_202C_206E_200E_202C_206B_206E_200F_206A_206C_200F_202A_202B_206B_206C_206D_200D_200F_202B_206E_206F_206F_200F_200C_202E),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2783592835u), GetClassType),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3465012375u), Lua_Eq)
		};
		LuaField[] fields = new LuaField[9]
		{
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(299847940u), get_shader, set_shader),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(772173287u), get_color, set_color),
			new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3209601357u), get_mainTexture, set_mainTexture),
			new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2202086902u), get_mainTextureOffset, set_mainTextureOffset),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1189595333u), get_mainTextureScale, set_mainTextureScale),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(75259842u), get_passCount, null),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2856796070u), get_renderQueue, set_renderQueue),
			new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3455601736u), get_shaderKeywords, set_shaderKeywords),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1455659051u), get_globalIlluminationFlags, set_globalIlluminationFlags)
		};
		LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3513106464u), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle), regs, fields, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Object).TypeHandle));
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _202C_200F_202C_202C_206A_200F_206B_202C_206F_202A_200E_206A_202D_206A_202A_206A_202C_202C_206E_200E_202C_206B_206E_200F_206A_206C_200F_202A_202B_206B_206C_206D_200D_200F_202B_206E_206F_206F_200F_200C_202E(IntPtr P_0)
	{
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(P_0);
		if (num == 1)
		{
			goto IL_000b;
		}
		goto IL_0056;
		IL_000b:
		int num2 = 873534938;
		goto IL_0010;
		IL_0010:
		Material val2 = default(Material);
		Material obj2 = default(Material);
		Shader val = default(Shader);
		Material obj = default(Material);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ 0x5730F50B)) % 12)
			{
			case 8u:
				break;
			case 9u:
				goto IL_0056;
			case 11u:
				val2 = (Material)LuaScriptMgr.GetUnityObject(P_0, 1, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle));
				num2 = (int)((num3 * 754930299) ^ 0xC7D854E);
				continue;
			case 4u:
				obj2 = _202C_202C_206C_200C_202A_202B_202D_200F_202D_202C_202A_200B_200F_200B_206B_202A_202B_206A_202B_202C_206F_200D_206F_206B_206F_202A_206E_202D_202B_200E_202C_206F_200E_206B_200C_200F_200B_202B_206F_206A_202E(val2);
				num2 = ((int)num3 * -2005843297) ^ -651832524;
				continue;
			case 2u:
				val = (Shader)LuaScriptMgr.GetUnityObject(P_0, 1, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Shader).TypeHandle));
				num2 = (int)((num3 * 805803033) ^ 0x75422245);
				continue;
			case 5u:
				LuaScriptMgr.Push(P_0, (Object)(object)obj);
				return 1;
			case 1u:
			{
				int num6;
				int num7;
				if (LuaScriptMgr.CheckTypes(P_0, 1, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle)))
				{
					num6 = 1074227200;
					num7 = num6;
				}
				else
				{
					num6 = 463982270;
					num7 = num6;
				}
				num2 = num6 ^ (int)(num3 * 1330466192);
				continue;
			}
			case 3u:
				LuaScriptMgr.Push(P_0, (Object)(object)obj2);
				num2 = (int)((num3 * 1774113890) ^ 0x43E0F596);
				continue;
			case 0u:
				obj = _200B_202A_206D_200C_200E_202B_206D_202E_202D_200D_200B_200E_200F_206C_202B_202A_202E_202B_202B_202D_200C_202E_200F_202D_206C_206D_200C_202B_206A_206C_200F_206C_206F_202D_200D_202C_206E_206C_202B_206C_202E(val);
				num2 = (int)((num3 * 1157654140) ^ 0x7F299672);
				continue;
			case 10u:
			{
				int num4;
				int num5;
				if (LuaScriptMgr.CheckTypes(P_0, 1, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Shader).TypeHandle)))
				{
					num4 = -1271491889;
					num5 = num4;
				}
				else
				{
					num4 = -1756557561;
					num5 = num4;
				}
				num2 = num4 ^ ((int)num3 * -478837941);
				continue;
			}
			case 7u:
				return 1;
			default:
				LuaDLL.luaL_error(P_0, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1955665722u));
				return 0;
			}
			break;
		}
		goto IL_000b;
		IL_0056:
		int num8;
		if (num != 1)
		{
			num2 = 1359367397;
			num8 = num2;
		}
		else
		{
			num2 = 833530221;
			num8 = num2;
		}
		goto IL_0010;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_shader(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Material val = default(Material);
		while (true)
		{
			int num = -1506712152;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -970527851)) % 7)
				{
				case 4u:
					break;
				case 1u:
					val = (Material)luaObject;
					num = ((int)num2 * -149080701) ^ -548890488;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1578121753u));
					num = ((int)num2 * -870509670) ^ 0x539E0E28;
					continue;
				case 6u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -796567850;
						num6 = num5;
					}
					else
					{
						num5 = -1605424391;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1839095460);
					continue;
				}
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2746280929u));
					num = -1592654026;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (_202C_200C_200D_206F_200F_202A_202A_206A_200D_202E_202E_202B_202A_206E_202B_202D_200C_206C_202A_200E_206C_206C_200F_202D_202E_202D_206B_206C_200B_200B_200E_202E_206F_200C_206B_202B_200F_202C_206D_202A_202E((Object)(object)val, (Object)null))
					{
						num3 = -207934721;
						num4 = num3;
					}
					else
					{
						num3 = -192575374;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1128210790);
					continue;
				}
				default:
					LuaScriptMgr.Push(L, (Object)(object)_206E_206A_202D_200C_202A_200D_206B_206E_200C_202B_202A_206C_200E_200E_206A_200D_202B_202A_202A_206B_200B_206C_202D_202D_202C_202B_206E_206A_200C_200F_206F_202E_206E_200C_206A_200E_206A_202B_200C_200F_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_color(IntPtr L)
	{
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		Material val = default(Material);
		while (true)
		{
			int num = 1005836860;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1D54779B)) % 7)
				{
				case 3u:
					break;
				case 5u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 1218265311;
						num6 = num5;
					}
					else
					{
						num5 = 409070878;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 315333189);
					continue;
				}
				case 1u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 1874851541) ^ 0x6BA74C2A);
					continue;
				case 6u:
				{
					val = (Material)luaObject;
					int num3;
					int num4;
					if (!_202C_200C_200D_206F_200F_202A_202A_206A_200D_202E_202E_202B_202A_206E_202B_202D_200C_206C_202A_200E_206C_206C_200F_202D_202E_202D_206B_206C_200B_200B_200E_202E_206F_200C_206B_202B_200F_202C_206D_202A_202E((Object)(object)val, (Object)null))
					{
						num3 = -2122523987;
						num4 = num3;
					}
					else
					{
						num3 = -791644436;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 895530647);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3460218148u));
					num = 847314220;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4212929657u));
					num = ((int)num2 * -2124271714) ^ 0x5E20390E;
					continue;
				default:
					LuaScriptMgr.Push(L, _206F_202D_200B_202C_200B_200F_206F_202A_206D_202E_206E_206F_206E_200F_202E_206B_200F_202A_200B_206F_206F_206C_202B_206B_200F_202C_206B_200F_206B_206F_202E_202D_200C_200E_200E_202E_206F_200D_206D_200D_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_mainTexture(IntPtr L)
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		Material val = default(Material);
		while (true)
		{
			int num = 1478915552;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x53C492AB)) % 8)
				{
				case 7u:
					break;
				case 1u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 1226633642;
						num6 = num5;
					}
					else
					{
						num5 = 1935974542;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1615704097);
					continue;
				}
				case 0u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 1772560744) ^ -40888454;
					continue;
				case 4u:
					num = (int)((num2 * 1493430606) ^ 0x22C1F8D6);
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3576656258u));
					num = ((int)num2 * -618031757) ^ -844291879;
					continue;
				case 3u:
				{
					val = (Material)luaObject;
					int num3;
					int num4;
					if (!_202C_200C_200D_206F_200F_202A_202A_206A_200D_202E_202E_202B_202A_206E_202B_202D_200C_206C_202A_200E_206C_206C_200F_202D_202E_202D_206B_206C_200B_200B_200E_202E_206F_200C_206B_202B_200F_202C_206D_202A_202E((Object)(object)val, (Object)null))
					{
						num3 = -682162125;
						num4 = num3;
					}
					else
					{
						num3 = -1585191522;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 502965511);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3654987224u));
					num = 668115518;
					continue;
				default:
					LuaScriptMgr.Push(L, (Object)(object)_202C_206E_200E_206F_206F_202C_202E_202E_200B_206E_202B_206F_202D_206D_206C_206A_202A_202D_202B_200D_200D_200C_202C_202A_206C_202C_206C_206C_200B_202D_206E_202E_202C_202E_202C_206D_200B_206A_202B_200E_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_mainTextureOffset(IntPtr L)
	{
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Material val = default(Material);
		while (true)
		{
			int num = 1515996733;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x16EAAEAB)) % 8)
				{
				case 4u:
					break;
				case 7u:
					LuaScriptMgr.Push(L, _206F_202C_200E_200B_200E_206F_200D_200F_206D_200B_200E_202A_200E_202E_200F_202D_202E_202C_202B_200C_200C_202C_206D_206D_200F_206C_200C_200D_206B_200D_206B_206B_206A_202B_202E_200D_200E_200E_202B_202D_202E(val));
					num = 453662058;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1287290546u));
					num = 975530196;
					continue;
				case 2u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 745007867;
						num6 = num5;
					}
					else
					{
						num5 = 777368214;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -669591500);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3170104278u));
					num = ((int)num2 * -394837311) ^ 0x7684FA01;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!_202C_200C_200D_206F_200F_202A_202A_206A_200D_202E_202E_202B_202A_206E_202B_202D_200C_206C_202A_200E_206C_206C_200F_202D_202E_202D_206B_206C_200B_200B_200E_202E_206F_200C_206B_202B_200F_202C_206D_202A_202E((Object)(object)val, (Object)null))
					{
						num3 = 1908707279;
						num4 = num3;
					}
					else
					{
						num3 = 37557314;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -840803167);
					continue;
				}
				case 6u:
					val = (Material)luaObject;
					num = (int)(num2 * 166970840) ^ -1353266176;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_mainTextureScale(IntPtr L)
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Material val = default(Material);
		while (true)
		{
			int num = 1440298480;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x608D51C1)) % 8)
				{
				case 7u:
					break;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(850951514u));
					num = 257314124;
					continue;
				case 6u:
					num = (int)((num2 * 83397644) ^ 0x510683A4);
					continue;
				case 5u:
					LuaScriptMgr.Push(L, _200C_206D_206B_200D_202A_200C_206A_200C_206E_200B_200F_200D_202E_206F_200F_202A_202C_200B_206D_200E_206B_206A_202D_202C_200D_202A_200E_200B_206D_202A_206C_200D_200C_206C_200C_202E_202B_202E_200C_206F_202E(val));
					num = 1225268802;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4289557972u));
					num = (int)(num2 * 443886509) ^ -1226238585;
					continue;
				case 1u:
				{
					val = (Material)luaObject;
					int num5;
					int num6;
					if (!_202C_200C_200D_206F_200F_202A_202A_206A_200D_202E_202E_202B_202A_206E_202B_202D_200C_206C_202A_200E_206C_206C_200F_202D_202E_202D_206B_206C_200B_200B_200E_202E_206F_200C_206B_202B_200F_202C_206D_202A_202E((Object)(object)val, (Object)null))
					{
						num5 = 1749778492;
						num6 = num5;
					}
					else
					{
						num5 = 1118779899;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -550799248);
					continue;
				}
				case 2u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 2057639297;
						num4 = num3;
					}
					else
					{
						num3 = 1110829397;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1034546716);
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
	private static int get_passCount(IntPtr L)
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		Material val = default(Material);
		while (true)
		{
			int num = 47491863;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x105BA427)) % 10)
				{
				case 7u:
					break;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(536568849u));
					num = 1737866308;
					continue;
				case 9u:
					num = ((int)num2 * -1454697429) ^ -1696502109;
					continue;
				case 8u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -308286922) ^ -1496168279;
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 580866467;
						num6 = num5;
					}
					else
					{
						num5 = 38557943;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 139326986);
					continue;
				}
				case 4u:
					val = (Material)luaObject;
					num = (int)(num2 * 1496278090) ^ -890883470;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (_202C_200C_200D_206F_200F_202A_202A_206A_200D_202E_202E_202B_202A_206E_202B_202D_200C_206C_202A_200E_206C_206C_200F_202D_202E_202D_206B_206C_200B_200B_200E_202E_206F_200C_206B_202B_200F_202C_206D_202A_202E((Object)(object)val, (Object)null))
					{
						num3 = 32819216;
						num4 = num3;
					}
					else
					{
						num3 = 1260466371;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -253731125);
					continue;
				}
				case 3u:
					LuaScriptMgr.Push(L, _202A_202D_206B_200F_206A_206C_202B_202A_200D_206A_200E_202A_202A_202B_200F_206E_206C_206F_206D_206B_206A_200B_206E_206B_200B_202D_202C_206C_206D_200F_200C_202E_200F_200B_202E_206F_202A_206A_206F_200E_202E(val));
					num = 1943353180;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2428357684u));
					num = (int)(num2 * 1670310766) ^ -235231718;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_renderQueue(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Material val = (Material)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1229937372;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7133D20F)) % 7)
				{
				case 0u:
					break;
				case 2u:
				{
					int num5;
					int num6;
					if (!_202C_200C_200D_206F_200F_202A_202A_206A_200D_202E_202E_202B_202A_206E_202B_202D_200C_206C_202A_200E_206C_206C_200F_202D_202E_202D_206B_206C_200B_200B_200E_202E_206F_200C_206B_202B_200F_202C_206D_202A_202E((Object)(object)val, (Object)null))
					{
						num5 = 1900620866;
						num6 = num5;
					}
					else
					{
						num5 = 1424323072;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1850415315);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1927828936u));
					num = ((int)num2 * -426295795) ^ -351305485;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -294169996;
						num4 = num3;
					}
					else
					{
						num3 = -1170590612;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1199983195);
					continue;
				}
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(370775016u));
					num = 1979670101;
					continue;
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -432653612) ^ 0x31D519C8;
					continue;
				default:
					LuaScriptMgr.Push(L, _206F_202E_202D_206B_206B_202E_200C_206C_202A_200D_202D_202A_206D_202D_202A_200B_200B_200C_206D_206D_206B_202B_200D_206A_206C_206A_202A_202E_206D_206F_202B_206E_206D_200F_206A_202E_206C_200F_200C_202A_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_shaderKeywords(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Material val = (Material)luaObject;
		while (true)
		{
			int num = -851219818;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -75826885)) % 6)
				{
				case 4u:
					break;
				case 5u:
				{
					int num5;
					int num6;
					if (_202C_200C_200D_206F_200F_202A_202A_206A_200D_202E_202E_202B_202A_206E_202B_202D_200C_206C_202A_200E_206C_206C_200F_202D_202E_202D_206B_206C_200B_200B_200E_202E_206F_200C_206B_202B_200F_202C_206D_202A_202E((Object)(object)val, (Object)null))
					{
						num5 = 784310842;
						num6 = num5;
					}
					else
					{
						num5 = 1510977439;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1848420827);
					continue;
				}
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2885989416u));
					num = ((int)num2 * -111061985) ^ -1029786265;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3584493474u));
					num = -1198859874;
					continue;
				case 2u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -2090157163;
						num4 = num3;
					}
					else
					{
						num3 = -1605673508;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 2042115803);
					continue;
				}
				default:
					LuaScriptMgr.PushArray(L, _206B_202C_202A_206B_206A_200C_202B_200F_202A_206D_202C_206D_206B_200B_200F_206A_206E_206F_206B_206A_202B_200B_206A_200D_206D_206E_200D_202D_202B_200D_200B_202D_200B_202D_202B_202B_200D_206B_206C_206A_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_globalIlluminationFlags(IntPtr L)
	{
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		Material val = default(Material);
		while (true)
		{
			int num = -1996312996;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1942594882)) % 8)
				{
				case 6u:
					break;
				case 7u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -884169071;
						num6 = num5;
					}
					else
					{
						num5 = -94472302;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1988107692);
					continue;
				}
				case 1u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 1286210751) ^ 0x34C06346);
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(655494525u));
					num = (int)((num2 * 2101854982) ^ 0x48A4EE88);
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(132396085u));
					num = -2057723814;
					continue;
				case 4u:
					LuaScriptMgr.Push(L, (Enum)(object)_200E_200D_202A_202C_202A_200D_200F_202B_202B_200E_206E_200D_202E_206F_206C_202E_202C_202C_202D_200F_202E_202D_200E_206B_202B_202C_206A_206B_200B_202C_202C_206B_200E_202E_206C_202C_206A_202C_200F_206E_202E(val));
					num = -949110357;
					continue;
				case 2u:
				{
					val = (Material)luaObject;
					int num3;
					int num4;
					if (!_202C_200C_200D_206F_200F_202A_202A_206A_200D_202E_202E_202B_202A_206E_202B_202D_200C_206C_202A_200E_206C_206C_200F_202D_202E_202D_206B_206C_200B_200B_200E_202E_206F_200C_206B_202B_200F_202C_206D_202A_202E((Object)(object)val, (Object)null))
					{
						num3 = 1651136836;
						num4 = num3;
					}
					else
					{
						num3 = 653305585;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -595499265);
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
	private static int set_shader(IntPtr L)
	{
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Material val = default(Material);
		while (true)
		{
			int num = 247474624;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x20F1E723)) % 7)
				{
				case 4u:
					break;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1364102812u));
					num = (int)(num2 * 2052383719) ^ -768762007;
					continue;
				case 0u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 232747819;
						num6 = num5;
					}
					else
					{
						num5 = 1198961255;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -891351143);
					continue;
				}
				case 5u:
				{
					val = (Material)luaObject;
					int num3;
					int num4;
					if (_202C_200C_200D_206F_200F_202A_202A_206A_200D_202E_202E_202B_202A_206E_202B_202D_200C_206C_202A_200E_206C_206C_200F_202D_202E_202D_206B_206C_200B_200B_200E_202E_206F_200C_206B_202B_200F_202C_206D_202A_202E((Object)(object)val, (Object)null))
					{
						num3 = -1137512290;
						num4 = num3;
					}
					else
					{
						num3 = -129315646;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -906967496);
					continue;
				}
				case 1u:
					_206B_202E_202A_200E_200E_202A_206B_206A_206E_200E_206F_200E_206C_202B_200D_202A_202B_202A_202E_202C_206E_200D_202B_206F_200C_206B_206A_202B_206C_206A_200E_206A_202B_202D_202B_200C_206C_206E_200E_202B_202E(val, (Shader)LuaScriptMgr.GetUnityObject(L, 3, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Shader).TypeHandle)));
					num = 236164430;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2746280929u));
					num = 686956394;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_color(IntPtr L)
	{
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Material val = default(Material);
		while (true)
		{
			int num = 1274731914;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x19058792)) % 7)
				{
				case 4u:
					break;
				case 3u:
					val = (Material)luaObject;
					num = ((int)num2 * -816686703) ^ 0x3D82C01E;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3750117099u));
					num = ((int)num2 * -1396375766) ^ 0x5D752CEC;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (_202C_200C_200D_206F_200F_202A_202A_206A_200D_202E_202E_202B_202A_206E_202B_202D_200C_206C_202A_200E_206C_206C_200F_202D_202E_202D_206B_206C_200B_200B_200E_202E_206F_200C_206B_202B_200F_202C_206D_202A_202E((Object)(object)val, (Object)null))
					{
						num5 = 224333853;
						num6 = num5;
					}
					else
					{
						num5 = 257620736;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1014758858);
					continue;
				}
				case 6u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -1098088451;
						num4 = num3;
					}
					else
					{
						num3 = -1056505467;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -303609133);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3460218148u));
					num = 1824376632;
					continue;
				default:
					_202B_206B_200D_206B_206C_200C_206F_206A_206A_202D_200D_206A_200E_206E_200F_202A_202E_202B_206C_202B_202B_200E_202A_206F_206B_206F_202D_200B_202B_206D_206B_206F_206F_200C_200B_200C_206D_206F_200E_200E_202E(val, LuaScriptMgr.GetColor(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_mainTexture(IntPtr L)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Material val = default(Material);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -535882652;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -838648312)) % 9)
				{
				case 8u:
					break;
				case 1u:
				{
					val = (Material)luaObject;
					int num5;
					int num6;
					if (!_202C_200C_200D_206F_200F_202A_202A_206A_200D_202E_202E_202B_202A_206E_202B_202D_200C_206C_202A_200E_206C_206C_200F_202D_202E_202D_206B_206C_200B_200B_200E_202E_206F_200C_206B_202B_200F_202C_206D_202A_202E((Object)(object)val, (Object)null))
					{
						num5 = -1588127971;
						num6 = num5;
					}
					else
					{
						num5 = -505898826;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1020552385);
					continue;
				}
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 193686390) ^ -373186321;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(523293714u));
					num = (int)((num2 * 334746861) ^ 0x739DE678);
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -2003036675;
						num4 = num3;
					}
					else
					{
						num3 = -2134196492;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -889121902);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3654987224u));
					num = -1215904887;
					continue;
				case 6u:
					_200D_206B_202E_206B_206A_200D_200B_200C_202B_200F_206A_202D_206E_206D_206D_200C_200B_206B_206A_200D_206F_202E_202D_206C_202D_200B_202A_206A_206F_202B_200D_206E_202B_202C_202E_206E_206C_200B_202A_200F_202E(val, (Texture)LuaScriptMgr.GetUnityObject(L, 3, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Texture).TypeHandle)));
					num = -1202510152;
					continue;
				case 0u:
					num = (int)((num2 * 971481025) ^ 0x4A52E42B);
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_mainTextureOffset(IntPtr L)
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Material val = default(Material);
		while (true)
		{
			int num = 180636295;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x22593CDE)) % 8)
				{
				case 6u:
					break;
				case 2u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 2066691824;
						num6 = num5;
					}
					else
					{
						num5 = 934829211;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 747330087);
					continue;
				}
				case 5u:
				{
					int num3;
					int num4;
					if (_202C_200C_200D_206F_200F_202A_202A_206A_200D_202E_202E_202B_202A_206E_202B_202D_200C_206C_202A_200E_206C_206C_200F_202D_202E_202D_206B_206C_200B_200B_200E_202E_206F_200C_206B_202B_200F_202C_206D_202A_202E((Object)(object)val, (Object)null))
					{
						num3 = -665383818;
						num4 = num3;
					}
					else
					{
						num3 = -1335987093;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 791915090);
					continue;
				}
				case 7u:
					_202C_206E_202E_206E_202A_202A_206B_202A_200F_202C_206E_200F_202A_200B_202B_206F_200D_206A_202B_200C_202B_202C_206E_206F_200F_206D_202A_206A_200E_202B_206A_202C_200D_200C_202A_202B_206D_200E_200D_200D_202E(val, LuaScriptMgr.GetVector2(L, 3));
					num = 1184329426;
					continue;
				case 1u:
					val = (Material)luaObject;
					num = ((int)num2 * -1031760550) ^ -1375730495;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2368611521u));
					num = (int)((num2 * 736816737) ^ 0x7C7B44CA);
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2765239831u));
					num = 1882675537;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_mainTextureScale(IntPtr L)
	{
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Material val = default(Material);
		while (true)
		{
			int num = 131318901;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x56376DBD)) % 7)
				{
				case 3u:
					break;
				case 4u:
					num = (int)((num2 * 32891726) ^ 0x5A09A881);
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4054082801u));
					num = (int)((num2 * 1245932831) ^ 0x5D63A9D7);
					continue;
				case 2u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -505837517;
						num6 = num5;
					}
					else
					{
						num5 = -808637840;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -497706349);
					continue;
				}
				case 6u:
				{
					val = (Material)luaObject;
					int num3;
					int num4;
					if (_202C_200C_200D_206F_200F_202A_202A_206A_200D_202E_202E_202B_202A_206E_202B_202D_200C_206C_202A_200E_206C_206C_200F_202D_202E_202D_206B_206C_200B_200B_200E_202E_206F_200C_206B_202B_200F_202C_206D_202A_202E((Object)(object)val, (Object)null))
					{
						num3 = -1811844131;
						num4 = num3;
					}
					else
					{
						num3 = -1138081409;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 741071492);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(850951514u));
					num = 1798937183;
					continue;
				default:
					_202D_200B_202B_200C_206E_200F_206D_206C_206D_206C_200F_206B_200B_200B_202A_206B_202E_206B_206F_202E_206F_200B_202D_200F_200D_202B_200C_202E_202C_206A_202A_200C_200F_200F_206E_200B_202D_206C_206D_200F_202E(val, LuaScriptMgr.GetVector2(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_renderQueue(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Material val = (Material)luaObject;
		if (_202C_200C_200D_206F_200F_202A_202A_206A_200D_202E_202E_202B_202A_206E_202B_202D_200C_206C_202A_200E_206C_206C_200F_202D_202E_202D_206B_206C_200B_200B_200E_202E_206F_200C_206B_202B_200F_202C_206D_202A_202E((Object)(object)val, (Object)null))
		{
			while (true)
			{
				int num = -799173463;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1123275344)) % 6)
					{
					case 2u:
						break;
					case 1u:
					{
						LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
						int num3;
						int num4;
						if (luaTypes == LuaTypes.LUA_TTABLE)
						{
							num3 = -1666774428;
							num4 = num3;
						}
						else
						{
							num3 = -1019965139;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -821582783);
						continue;
					}
					case 3u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3808756893u));
						num = (int)(num2 * 1747782577) ^ -320767158;
						continue;
					case 5u:
						num = ((int)num2 * -1951405455) ^ -1529454167;
						continue;
					case 4u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1108964239u));
						num = -1364401602;
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
		_206B_202A_202E_206F_206A_206E_202A_202D_202E_202E_206F_202D_206D_200D_206B_200B_202A_202A_200D_200D_200C_200C_202C_206D_202C_206A_202A_200D_202B_200E_202D_206E_202C_202E_206B_206A_200F_202E_202A_200D_202E(val, (int)LuaScriptMgr.GetNumber(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_shaderKeywords(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Material val = (Material)luaObject;
		if (_202C_200C_200D_206F_200F_202A_202A_206A_200D_202E_202E_202B_202A_206E_202B_202D_200C_206C_202A_200E_206C_206C_200F_202D_202E_202D_206B_206C_200B_200B_200E_202E_206F_200C_206B_202B_200F_202C_206D_202A_202E((Object)(object)val, (Object)null))
		{
			goto IL_0018;
		}
		goto IL_0064;
		IL_0018:
		int num = -1151233099;
		goto IL_001d;
		IL_001d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -411432946)) % 7)
			{
			case 0u:
				break;
			case 6u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3712069458u));
				num = -1327819637;
				continue;
			case 3u:
				goto IL_0064;
			case 1u:
			{
				LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
				int num3;
				int num4;
				if (luaTypes != LuaTypes.LUA_TTABLE)
				{
					num3 = -968220446;
					num4 = num3;
				}
				else
				{
					num3 = -1135404836;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 1767366148);
				continue;
			}
			case 5u:
				num = (int)((num2 * 2057734522) ^ 0xF90B96F);
				continue;
			case 4u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2885989416u));
				num = (int)(num2 * 721700670) ^ -266444848;
				continue;
			default:
				return 0;
			}
			break;
		}
		goto IL_0018;
		IL_0064:
		_200D_200E_202C_200D_206D_200D_200C_206F_200D_200E_200C_200E_200D_202E_200E_202C_202D_206C_202A_206D_202E_202C_200F_206B_206D_206C_206E_206F_200B_200C_202A_200B_200C_200E_200B_202D_200F_206C_206C_202A_202E(val, LuaScriptMgr.GetArrayString(L, 3));
		num = -353914038;
		goto IL_001d;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_globalIlluminationFlags(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Material val = (Material)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 380740253;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4A05AE6)) % 9)
				{
				case 3u:
					break;
				case 5u:
					num = ((int)num2 * -2082785936) ^ 0x45879815;
					continue;
				case 8u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 269136770) ^ 0x60E0724F);
					continue;
				case 7u:
					_200D_202A_206D_206F_206E_206A_206E_202E_206F_202E_206A_206C_206E_200E_202D_206F_206C_206F_200D_202C_200E_202D_200F_202A_202E_206A_206E_200F_200F_200D_206C_202E_200F_202B_206F_202D_200D_200E_200E_202D_202E(val, (MaterialGlobalIlluminationFlags)(int)LuaScriptMgr.GetNetObject(L, 3, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(MaterialGlobalIlluminationFlags).TypeHandle)));
					num = 1864711113;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(655494525u));
					num = ((int)num2 * -387557095) ^ 0x10AE271E;
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (!_202C_200C_200D_206F_200F_202A_202A_206A_200D_202E_202E_202B_202A_206E_202B_202D_200C_206C_202A_200E_206C_206C_200F_202D_202E_202D_206B_206C_200B_200B_200E_202E_206F_200C_206B_202B_200F_202C_206D_202A_202E((Object)(object)val, (Object)null))
					{
						num5 = -2070789355;
						num6 = num5;
					}
					else
					{
						num5 = -1207050919;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1002084288);
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -1211510858;
						num4 = num3;
					}
					else
					{
						num3 = -1720007495;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 866202964);
					continue;
				}
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(132396085u));
					num = 1912952277;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SetColor(IntPtr L)
	{
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		int num = LuaDLL.lua_gettop(L);
		if (num == 3)
		{
			goto IL_000e;
		}
		goto IL_00d4;
		IL_000e:
		int num2 = 2023876814;
		goto IL_0013;
		IL_0013:
		string text = default(string);
		Material val2 = default(Material);
		int num6 = default(int);
		Material val = default(Material);
		Color color = default(Color);
		Color color2 = default(Color);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ 0x555FF640)) % 13)
			{
			case 3u:
				break;
			case 1u:
				text = LuaScriptMgr.GetString(L, 2);
				num2 = ((int)num3 * -1913030494) ^ 0x75ACAE9;
				continue;
			case 9u:
				val2 = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3657169530u));
				num6 = (int)LuaDLL.lua_tonumber(L, 2);
				num2 = ((int)num3 * -46975478) ^ -1765005304;
				continue;
			case 11u:
				val = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2294193498u));
				num2 = ((int)num3 * -245441456) ^ -1681832536;
				continue;
			case 6u:
				goto IL_00d4;
			case 0u:
				return 0;
			case 4u:
				color = LuaScriptMgr.GetColor(L, 3);
				num2 = (int)((num3 * 471002185) ^ 0x66A2131F);
				continue;
			case 5u:
			{
				int num7;
				int num8;
				if (LuaScriptMgr.CheckTypes(L, 1, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(string).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(LuaTable).TypeHandle)))
				{
					num7 = 262733545;
					num8 = num7;
				}
				else
				{
					num7 = 661612840;
					num8 = num7;
				}
				num2 = num7 ^ (int)(num3 * 493718306);
				continue;
			}
			case 12u:
				color2 = LuaScriptMgr.GetColor(L, 3);
				num2 = ((int)num3 * -1478604345) ^ -1465830526;
				continue;
			case 8u:
				_200B_200F_200B_202C_200D_206A_206B_202B_206C_200C_202C_200C_206C_202D_206D_206B_200D_202D_202D_202C_200C_206E_206D_202C_200C_202C_206D_206D_202D_200B_206B_202E_200B_206A_200F_206A_206F_206C_200B_206A_202E(val2, num6, color);
				num2 = (int)(num3 * 1046297111) ^ -1392443695;
				continue;
			case 7u:
				_206D_200B_200F_206A_200C_206C_200B_202C_206C_202E_202A_200B_200B_202E_202C_200E_202B_206C_200E_202C_200E_202C_206B_206E_206B_202D_200C_206C_206B_202E_206F_200C_200C_202A_206B_202A_202C_202C_200B_200E_202E(val, text, color2);
				return 0;
			case 10u:
			{
				int num4;
				int num5;
				if (LuaScriptMgr.CheckTypes(L, 1, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(int).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(LuaTable).TypeHandle)))
				{
					num4 = -2099984188;
					num5 = num4;
				}
				else
				{
					num4 = -1861727241;
					num5 = num4;
				}
				num2 = num4 ^ (int)(num3 * 1788478824);
				continue;
			}
			default:
				LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2186368910u));
				return 0;
			}
			break;
		}
		goto IL_000e;
		IL_00d4:
		int num9;
		if (num != 3)
		{
			num2 = 1154329158;
			num9 = num2;
		}
		else
		{
			num2 = 501094535;
			num9 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetColor(IntPtr L)
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		Material val = default(Material);
		string text = default(string);
		Color clr = default(Color);
		while (true)
		{
			int num2 = -64754501;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -883880114)) % 12)
				{
				case 11u:
					break;
				case 10u:
				{
					int num10;
					int num11;
					if (!LuaScriptMgr.CheckTypes(L, 1, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(string).TypeHandle)))
					{
						num10 = -1452057070;
						num11 = num10;
					}
					else
					{
						num10 = -1754996901;
						num11 = num10;
					}
					num2 = num10 ^ ((int)num3 * -123823320);
					continue;
				}
				case 0u:
				{
					Color clr2 = _206B_200F_202B_202C_200D_200E_206A_202D_206C_202A_200D_206F_202A_200E_200D_202A_206B_200C_206B_206C_202A_202D_206B_200C_200D_206F_206C_206A_206A_202B_200E_206E_202E_202A_202A_200D_206B_202E_206E_200F_202E(val, text);
					LuaScriptMgr.Push(L, clr2);
					return 1;
				}
				case 2u:
				{
					Material val2 = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1137371893u));
					int num9 = (int)LuaDLL.lua_tonumber(L, 2);
					clr = _206E_202D_202D_206B_202A_206B_206C_202A_206C_206A_206E_206A_206A_200F_202B_200D_202C_200B_202E_202E_200F_202C_206E_200E_206B_202D_200C_202A_202C_202B_200F_200D_206A_206B_202C_202A_206C_200E_200C_200D_202E(val2, num9);
					num2 = ((int)num3 * -382263621) ^ -1437168089;
					continue;
				}
				case 6u:
					return 1;
				case 8u:
				{
					int num5;
					int num6;
					if (!LuaScriptMgr.CheckTypes(L, 1, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(int).TypeHandle)))
					{
						num5 = -1658764341;
						num6 = num5;
					}
					else
					{
						num5 = -503001544;
						num6 = num5;
					}
					num2 = num5 ^ ((int)num3 * -425540028);
					continue;
				}
				case 5u:
				{
					int num7;
					int num8;
					if (num != 2)
					{
						num7 = -2024411220;
						num8 = num7;
					}
					else
					{
						num7 = -799791691;
						num8 = num7;
					}
					num2 = num7 ^ (int)(num3 * 1365757211);
					continue;
				}
				case 1u:
				{
					int num4;
					if (num == 2)
					{
						num2 = -1471832480;
						num4 = num2;
					}
					else
					{
						num2 = -1326262494;
						num4 = num2;
					}
					continue;
				}
				case 7u:
					LuaScriptMgr.Push(L, clr);
					num2 = ((int)num3 * -2101390931) ^ -1498085337;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1916144677u));
					num2 = -1149367787;
					continue;
				case 9u:
					val = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2294193498u));
					text = LuaScriptMgr.GetString(L, 2);
					num2 = (int)((num3 * 847318012) ^ 0x77A4BB6A);
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SetVector(IntPtr L)
	{
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		int num = LuaDLL.lua_gettop(L);
		if (num == 3)
		{
			goto IL_000e;
		}
		goto IL_00bd;
		IL_000e:
		int num2 = -420044060;
		goto IL_0013;
		IL_0013:
		Material val2 = default(Material);
		string text = default(string);
		Material val = default(Material);
		int num4 = default(int);
		Vector4 vector = default(Vector4);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ -218578871)) % 13)
			{
			case 8u:
				break;
			case 7u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3393921059u));
				num2 = -339656860;
				continue;
			case 4u:
				val2 = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(756079760u));
				text = LuaScriptMgr.GetString(L, 2);
				num2 = (int)((num3 * 846811310) ^ 0x6BD610C7);
				continue;
			case 3u:
				return 0;
			case 5u:
				goto IL_00bd;
			case 6u:
			{
				int num7;
				int num8;
				if (LuaScriptMgr.CheckTypes(L, 1, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(string).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(LuaTable).TypeHandle)))
				{
					num7 = 244603348;
					num8 = num7;
				}
				else
				{
					num7 = 1990453275;
					num8 = num7;
				}
				num2 = num7 ^ ((int)num3 * -1459414437);
				continue;
			}
			case 12u:
			{
				int num5;
				int num6;
				if (LuaScriptMgr.CheckTypes(L, 1, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(int).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(LuaTable).TypeHandle)))
				{
					num5 = -378762719;
					num6 = num5;
				}
				else
				{
					num5 = -511460728;
					num6 = num5;
				}
				num2 = num5 ^ ((int)num3 * -1848550825);
				continue;
			}
			case 11u:
			{
				Vector4 vector2 = LuaScriptMgr.GetVector4(L, 3);
				_206A_206A_206D_200B_200E_200D_206D_202A_200F_200C_200F_206B_200D_202B_200B_200C_202C_206E_200D_202A_206C_202B_202D_206E_200B_206C_206B_206D_202D_202C_200F_200B_206E_200B_206B_206A_206E_206B_206E_200E_202E(val2, text, vector2);
				num2 = (int)(num3 * 248500849) ^ -4803080;
				continue;
			}
			case 0u:
				return 0;
			case 2u:
				val = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(756079760u));
				num2 = ((int)num3 * -1340242200) ^ 0x1BA38158;
				continue;
			case 10u:
				num4 = (int)LuaDLL.lua_tonumber(L, 2);
				vector = LuaScriptMgr.GetVector4(L, 3);
				num2 = ((int)num3 * -569950380) ^ 0x1E5BC0C9;
				continue;
			case 9u:
				_206C_200B_200C_206F_206E_202C_200D_202B_200B_200B_200E_206A_206A_200F_200F_206C_200B_202A_206B_206B_202B_202D_202B_202D_200F_200E_200F_206B_202B_206C_206D_200C_200B_202C_206D_202A_206C_202A_202A_200D_202E(val, num4, vector);
				num2 = (int)(num3 * 1213967389) ^ -536586865;
				continue;
			default:
				return 0;
			}
			break;
		}
		goto IL_000e;
		IL_00bd:
		int num9;
		if (num == 3)
		{
			num2 = -1095249622;
			num9 = num2;
		}
		else
		{
			num2 = -1045703638;
			num9 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetVector(IntPtr L)
	{
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		int num = LuaDLL.lua_gettop(L);
		if (num == 2)
		{
			goto IL_000e;
		}
		goto IL_00e5;
		IL_000e:
		int num2 = -1406976686;
		goto IL_0013;
		IL_0013:
		Vector4 v2 = default(Vector4);
		Material val2 = default(Material);
		int num4 = default(int);
		Vector4 v = default(Vector4);
		Material val = default(Material);
		string text = default(string);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ -752858255)) % 12)
			{
			case 9u:
				break;
			case 7u:
			{
				int num7;
				int num8;
				if (LuaScriptMgr.CheckTypes(L, 1, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(int).TypeHandle)))
				{
					num7 = 261723022;
					num8 = num7;
				}
				else
				{
					num7 = 439128462;
					num8 = num7;
				}
				num2 = num7 ^ (int)(num3 * 1138810528);
				continue;
			}
			case 4u:
			{
				int num5;
				int num6;
				if (LuaScriptMgr.CheckTypes(L, 1, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(string).TypeHandle)))
				{
					num5 = 1151888539;
					num6 = num5;
				}
				else
				{
					num5 = 13903951;
					num6 = num5;
				}
				num2 = num5 ^ (int)(num3 * 1351665422);
				continue;
			}
			case 8u:
				v2 = _206C_206E_206C_202B_206A_200D_200F_206F_200D_202D_200B_202D_200D_200C_200B_202C_202D_202B_202D_206C_206F_202C_202C_200F_206A_202E_200B_206F_202A_202A_200C_202A_206F_206E_206D_206D_202E_202B_206D_200E_202E(val2, num4);
				num2 = (int)(num3 * 1545292055) ^ -251771304;
				continue;
			case 11u:
				goto IL_00e5;
			case 10u:
				LuaScriptMgr.Push(L, v);
				return 1;
			case 3u:
				val2 = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2294193498u));
				num4 = (int)LuaDLL.lua_tonumber(L, 2);
				num2 = ((int)num3 * -81097822) ^ -1264163961;
				continue;
			case 2u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(932152081u));
				num2 = -1538217252;
				continue;
			case 6u:
				val = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2294193498u));
				text = LuaScriptMgr.GetString(L, 2);
				num2 = ((int)num3 * -1146122261) ^ -1095165321;
				continue;
			case 1u:
				LuaScriptMgr.Push(L, v2);
				return 1;
			case 0u:
				v = _206E_206B_200F_200E_202C_206D_206D_200D_206A_206E_200D_202B_202E_202D_206D_206E_206B_202C_206E_202C_200D_200C_206E_206A_206C_206C_202D_206E_200D_200C_200F_202D_206B_206C_206F_202B_202A_206D_206E_206F_202E(val, text);
				num2 = (int)(num3 * 170406140) ^ -881642789;
				continue;
			default:
				return 0;
			}
			break;
		}
		goto IL_000e;
		IL_00e5:
		int num9;
		if (num == 2)
		{
			num2 = -72665651;
			num9 = num2;
		}
		else
		{
			num2 = -1338951161;
			num9 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SetTexture(IntPtr L)
	{
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		Material val3 = default(Material);
		string text = default(string);
		Texture val4 = default(Texture);
		Texture val2 = default(Texture);
		int num4 = default(int);
		Material val = default(Material);
		while (true)
		{
			int num2 = -1361067671;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1221632808)) % 14)
				{
				case 7u:
					break;
				case 2u:
					_206C_206E_200C_200F_206E_202E_202A_206B_206E_200F_200F_200B_200F_202D_202C_202D_200E_206C_206B_202D_200C_200D_206D_200E_206A_202D_202B_200F_206A_202A_202B_202D_202D_200F_202B_200F_202A_206C_206A_200E_202E(val3, text, val4);
					return 0;
				case 9u:
				{
					int num8;
					int num9;
					if (LuaScriptMgr.CheckTypes(L, 1, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(int).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Texture).TypeHandle)))
					{
						num8 = 1356948432;
						num9 = num8;
					}
					else
					{
						num8 = 1675768838;
						num9 = num8;
					}
					num2 = num8 ^ (int)(num3 * 1017819364);
					continue;
				}
				case 4u:
				{
					int num7;
					if (num != 3)
					{
						num2 = -1457477013;
						num7 = num2;
					}
					else
					{
						num2 = -444839284;
						num7 = num2;
					}
					continue;
				}
				case 0u:
				{
					int num10;
					int num11;
					if (!LuaScriptMgr.CheckTypes(L, 1, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(string).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Texture).TypeHandle)))
					{
						num10 = -708335385;
						num11 = num10;
					}
					else
					{
						num10 = -946114860;
						num11 = num10;
					}
					num2 = num10 ^ ((int)num3 * -985436329);
					continue;
				}
				case 6u:
					val2 = (Texture)LuaScriptMgr.GetLuaObject(L, 3);
					num2 = (int)(num3 * 1730060083) ^ -1790481695;
					continue;
				case 12u:
					return 0;
				case 3u:
					num4 = (int)LuaDLL.lua_tonumber(L, 2);
					num2 = (int)(num3 * 252594073) ^ -285885823;
					continue;
				case 8u:
					val3 = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2294193498u));
					text = LuaScriptMgr.GetString(L, 2);
					num2 = ((int)num3 * -480427503) ^ -1779462661;
					continue;
				case 13u:
					val4 = (Texture)LuaScriptMgr.GetLuaObject(L, 3);
					num2 = (int)((num3 * 1405384462) ^ 0x57FF02D4);
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (num != 3)
					{
						num5 = -1215948282;
						num6 = num5;
					}
					else
					{
						num5 = -1320061005;
						num6 = num5;
					}
					num2 = num5 ^ (int)(num3 * 1141928252);
					continue;
				}
				case 11u:
					_202C_200D_206D_202E_200F_202D_200C_202E_200F_206B_206B_206B_206D_202C_200E_200D_206D_200F_200C_200B_206E_202A_200E_206A_206C_200D_202A_206C_200C_206A_202A_206B_206A_206B_200E_200F_200E_206D_202A_202D_202E(val, num4, val2);
					num2 = (int)((num3 * 2092747353) ^ 0x252F9905);
					continue;
				case 10u:
					val = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2294193498u));
					num2 = (int)(num3 * 1547382687) ^ -680241027;
					continue;
				default:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3731702970u));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetTexture(IntPtr L)
	{
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		int num4 = default(int);
		Texture obj = default(Texture);
		Material val = default(Material);
		while (true)
		{
			int num2 = 424494271;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x42BB042F)) % 14)
				{
				case 7u:
					break;
				case 2u:
					return 1;
				case 12u:
				{
					Material val2 = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(756079760u));
					string text = LuaScriptMgr.GetString(L, 2);
					Texture obj2 = _202C_200E_200E_200B_206D_200D_202D_206D_202D_200C_200C_206B_206E_206B_200D_200D_206F_202B_206D_206F_200E_206D_200E_206D_206C_206D_202D_200E_206E_206D_200C_200D_206A_200F_202C_200B_206A_206F_200D_206A_202E(val2, text);
					LuaScriptMgr.Push(L, (Object)(object)obj2);
					num2 = ((int)num3 * -144758313) ^ 0x1E7CEB6B;
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(418796038u));
					num2 = 1636694543;
					continue;
				case 0u:
				{
					int num10;
					int num11;
					if (LuaScriptMgr.CheckTypes(L, 1, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(int).TypeHandle)))
					{
						num10 = 620130744;
						num11 = num10;
					}
					else
					{
						num10 = 258136170;
						num11 = num10;
					}
					num2 = num10 ^ (int)(num3 * 785705525);
					continue;
				}
				case 11u:
				{
					int num7;
					int num8;
					if (!LuaScriptMgr.CheckTypes(L, 1, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(string).TypeHandle)))
					{
						num7 = -1914157476;
						num8 = num7;
					}
					else
					{
						num7 = -1972401273;
						num8 = num7;
					}
					num2 = num7 ^ (int)(num3 * 469894730);
					continue;
				}
				case 1u:
					num4 = (int)LuaDLL.lua_tonumber(L, 2);
					num2 = ((int)num3 * -1552720940) ^ -217687997;
					continue;
				case 13u:
				{
					int num9;
					if (num == 2)
					{
						num2 = 1157665010;
						num9 = num2;
					}
					else
					{
						num2 = 2056811454;
						num9 = num2;
					}
					continue;
				}
				case 10u:
				{
					int num5;
					int num6;
					if (num != 2)
					{
						num5 = -913988606;
						num6 = num5;
					}
					else
					{
						num5 = -1285742361;
						num6 = num5;
					}
					num2 = num5 ^ (int)(num3 * 1362370964);
					continue;
				}
				case 4u:
					obj = _200C_202B_202A_200D_202E_200E_202C_202C_200D_206F_206F_206C_200D_202D_206E_200E_200C_202C_206F_206D_206C_202C_206F_200F_206F_206B_202C_206D_202E_202E_206C_206E_206B_200D_202E_200D_206E_206F_200B_202D_202E(val, num4);
					num2 = ((int)num3 * -1605802507) ^ 0x77D06AF2;
					continue;
				case 3u:
					LuaScriptMgr.Push(L, (Object)(object)obj);
					num2 = ((int)num3 * -1557880952) ^ 0x1970302B;
					continue;
				case 6u:
					return 1;
				case 9u:
					val = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3282258027u));
					num2 = (int)(num3 * 1269417172) ^ -1489957852;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SetTextureOffset(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr.CheckArgsCount(L, 3);
		Material val = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2294193498u));
		string luaString = LuaScriptMgr.GetLuaString(L, 2);
		Vector2 vector = LuaScriptMgr.GetVector2(L, 3);
		while (true)
		{
			int num = -2040325102;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -209165030)) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_0050;
				default:
					return 0;
				}
				break;
				IL_0050:
				_202D_206D_206D_200F_200F_206E_200B_200E_206F_206B_206D_202A_200C_206D_200D_202E_200C_202B_206A_202B_200E_206C_200B_200F_206B_200E_200C_206E_200F_200F_206B_202E_202B_202E_202A_202E_202C_200B_206A_200E_202E(val, luaString, vector);
				num = (int)(num2 * 1886315742) ^ -1773764784;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetTextureOffset(IntPtr L)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr.CheckArgsCount(L, 2);
		Vector2 v = default(Vector2);
		Material val = default(Material);
		string luaString = default(string);
		while (true)
		{
			int num = -225004397;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -703887546)) % 6)
				{
				case 3u:
					break;
				case 2u:
					LuaScriptMgr.Push(L, v);
					num = (int)((num2 * 1013241696) ^ 0x6BD53668);
					continue;
				case 0u:
					v = _206A_206B_200D_206F_200B_206D_206C_202A_202D_202C_200F_206D_202C_202B_206C_202D_206D_202D_200D_202D_200F_200B_206E_202B_200B_206C_202C_200F_200B_202D_206B_202C_202A_206C_200B_206C_206B_200B_202C_202D_202E(val, luaString);
					num = (int)(num2 * 1517428358) ^ -1483714446;
					continue;
				case 5u:
					luaString = LuaScriptMgr.GetLuaString(L, 2);
					num = ((int)num2 * -1846962288) ^ -547728504;
					continue;
				case 1u:
					val = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3657169530u));
					num = ((int)num2 * -1110581532) ^ 0x797A75ED;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SetTextureScale(IntPtr L)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 3);
		Material val = default(Material);
		while (true)
		{
			int num = 443352021;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3C5F7FB5)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0029;
				default:
				{
					string luaString = LuaScriptMgr.GetLuaString(L, 2);
					Vector2 vector = LuaScriptMgr.GetVector2(L, 3);
					_200E_206F_200B_206D_202D_202D_206D_206B_200F_206E_206E_200E_200C_206F_200E_200C_202B_206F_200F_200B_206C_206E_200D_206C_202C_202B_206A_200D_202B_202E_200C_206B_206B_202E_206B_200E_202D_202B_206F_202D_202E(val, luaString, vector);
					return 0;
				}
				}
				break;
				IL_0029:
				val = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1137371893u));
				num = (int)((num2 * 650641816) ^ 0x5E2BABFB);
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetTextureScale(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr.CheckArgsCount(L, 2);
		Material val = default(Material);
		string luaString = default(string);
		while (true)
		{
			int num = 196017506;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6B1C5944)) % 5)
				{
				case 2u:
					break;
				case 1u:
					val = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3282258027u));
					num = ((int)num2 * -1200637585) ^ -1808653840;
					continue;
				case 3u:
				{
					Vector2 v = _200B_206B_202C_206A_206B_200F_200B_202D_206E_202B_202D_202A_206F_200B_206D_202D_206F_206C_200E_206C_200F_202B_200F_200B_202D_202B_206B_206E_200F_200C_202E_200F_206B_202E_202B_200D_202B_206A_206B_202B_202E(val, luaString);
					LuaScriptMgr.Push(L, v);
					num = (int)(num2 * 1142543678) ^ -1172686696;
					continue;
				}
				case 4u:
					luaString = LuaScriptMgr.GetLuaString(L, 2);
					num = (int)((num2 * 2107020450) ^ 0x3C722E20);
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SetMatrix(IntPtr L)
	{
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		int num = LuaDLL.lua_gettop(L);
		if (num == 3)
		{
			goto IL_000e;
		}
		goto IL_0092;
		IL_000e:
		int num2 = -1454917440;
		goto IL_0013;
		IL_0013:
		Material val = default(Material);
		string text = default(string);
		Matrix4x4 val2 = default(Matrix4x4);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ -63151253)) % 10)
			{
			case 6u:
				break;
			case 3u:
			{
				int num7;
				int num8;
				if (LuaScriptMgr.CheckTypes(L, 1, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(int).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Matrix4x4).TypeHandle)))
				{
					num7 = -509993999;
					num8 = num7;
				}
				else
				{
					num7 = -1677592816;
					num8 = num7;
				}
				num2 = num7 ^ (int)(num3 * 214538216);
				continue;
			}
			case 5u:
				goto IL_0092;
			case 8u:
			{
				int num5;
				int num6;
				if (LuaScriptMgr.CheckTypes(L, 1, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(string).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Matrix4x4).TypeHandle)))
				{
					num5 = -45591509;
					num6 = num5;
				}
				else
				{
					num5 = -1489694602;
					num6 = num5;
				}
				num2 = num5 ^ ((int)num3 * -1291237301);
				continue;
			}
			case 9u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2464756117u));
				num2 = -1107082317;
				continue;
			case 4u:
				val = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2294193498u));
				text = LuaScriptMgr.GetString(L, 2);
				val2 = (Matrix4x4)LuaScriptMgr.GetLuaObject(L, 3);
				num2 = (int)(num3 * 2128606696) ^ -402187630;
				continue;
			case 0u:
			{
				Material val3 = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(756079760u));
				int num4 = (int)LuaDLL.lua_tonumber(L, 2);
				Matrix4x4 val4 = (Matrix4x4)LuaScriptMgr.GetLuaObject(L, 3);
				_202A_206B_200F_206A_200C_202C_202D_202B_200D_200B_206D_200E_206D_206F_202E_206F_200E_200D_200F_202A_200C_200B_206E_202C_206B_206A_202C_202E_202E_202E_202E_206F_206A_202D_202A_206E_202C_206B_206C_202D_202E(val3, num4, val4);
				num2 = (int)((num3 * 2070841595) ^ 0x24EC888C);
				continue;
			}
			case 7u:
				_200F_206F_202C_202A_206C_206E_202E_206B_206D_202D_200B_200E_202B_202B_202E_206C_206E_200D_206D_206A_200E_200B_206D_200B_202B_202A_202E_206F_206B_202C_206F_206C_200F_202B_202D_202B_206C_200F_200D_200C_202E(val, text, val2);
				return 0;
			case 1u:
				return 0;
			default:
				return 0;
			}
			break;
		}
		goto IL_000e;
		IL_0092:
		int num9;
		if (num != 3)
		{
			num2 = -1986038198;
			num9 = num2;
		}
		else
		{
			num2 = -997284257;
			num9 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetMatrix(IntPtr L)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		if (num == 2)
		{
			goto IL_000b;
		}
		goto IL_007a;
		IL_000b:
		int num2 = 308088991;
		goto IL_0010;
		IL_0010:
		Material val4 = default(Material);
		int num8 = default(int);
		string text = default(string);
		Material val = default(Material);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ 0x5912E6BB)) % 12)
			{
			case 5u:
				break;
			case 0u:
			{
				Matrix4x4 val3 = _200C_200C_200B_200C_200D_202E_202B_202B_200F_200D_202E_200F_202C_202A_202A_206F_206F_206F_202C_202C_206A_200C_200E_206D_200E_202A_200C_206F_206C_200C_200F_206B_200F_206D_200D_200B_206A_206F_206C_206E_202E(val4, num8);
				LuaScriptMgr.PushValue(L, val3);
				num2 = (int)((num3 * 673273560) ^ 0x1C563131);
				continue;
			}
			case 11u:
				goto IL_007a;
			case 4u:
			{
				int num6;
				int num7;
				if (LuaScriptMgr.CheckTypes(L, 1, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(int).TypeHandle)))
				{
					num6 = 347119029;
					num7 = num6;
				}
				else
				{
					num6 = 1660966204;
					num7 = num6;
				}
				num2 = num6 ^ ((int)num3 * -519290550);
				continue;
			}
			case 10u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4057877949u));
				num2 = 1213480603;
				continue;
			case 3u:
				text = LuaScriptMgr.GetString(L, 2);
				num2 = ((int)num3 * -1926094272) ^ -1138897668;
				continue;
			case 6u:
				val4 = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1137371893u));
				num8 = (int)LuaDLL.lua_tonumber(L, 2);
				num2 = (int)(num3 * 1908185661) ^ -372227819;
				continue;
			case 1u:
			{
				int num4;
				int num5;
				if (LuaScriptMgr.CheckTypes(L, 1, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(string).TypeHandle)))
				{
					num4 = 1552776960;
					num5 = num4;
				}
				else
				{
					num4 = 1176993727;
					num5 = num4;
				}
				num2 = num4 ^ ((int)num3 * -550027790);
				continue;
			}
			case 7u:
			{
				Matrix4x4 val2 = _206F_200E_200E_200E_200F_206F_200B_206F_202D_206E_202C_206C_200F_200F_206C_206D_202C_202E_200E_202C_200D_202C_202D_202C_206D_202B_202D_200B_202D_202D_206C_200F_200D_200B_202D_200D_200C_206D_200F_200C_202E(val, text);
				LuaScriptMgr.PushValue(L, val2);
				return 1;
			}
			case 2u:
				return 1;
			case 9u:
				val = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1137371893u));
				num2 = (int)((num3 * 112208666) ^ 0x4750CEB2);
				continue;
			default:
				return 0;
			}
			break;
		}
		goto IL_000b;
		IL_007a:
		int num9;
		if (num == 2)
		{
			num2 = 1496978418;
			num9 = num2;
		}
		else
		{
			num2 = 1962818493;
			num9 = num2;
		}
		goto IL_0010;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SetFloat(IntPtr L)
	{
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		int num5 = default(int);
		float num6 = default(float);
		Material val = default(Material);
		Material val2 = default(Material);
		string text = default(string);
		while (true)
		{
			int num2 = 1256554709;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x34BFED21)) % 15)
				{
				case 12u:
					break;
				case 7u:
					return 0;
				case 8u:
				{
					int num9;
					int num10;
					if (LuaScriptMgr.CheckTypes(L, 1, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(int).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(float).TypeHandle)))
					{
						num9 = -879375396;
						num10 = num9;
					}
					else
					{
						num9 = -1245612811;
						num10 = num9;
					}
					num2 = num9 ^ (int)(num3 * 1741053661);
					continue;
				}
				case 2u:
					num5 = (int)LuaDLL.lua_tonumber(L, 2);
					num2 = ((int)num3 * -2007775750) ^ -578399959;
					continue;
				case 4u:
				{
					int num11;
					if (num == 3)
					{
						num2 = 958051594;
						num11 = num2;
					}
					else
					{
						num2 = 449683784;
						num11 = num2;
					}
					continue;
				}
				case 9u:
				{
					int num12;
					int num13;
					if (!LuaScriptMgr.CheckTypes(L, 1, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(string).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(float).TypeHandle)))
					{
						num12 = -1440158721;
						num13 = num12;
					}
					else
					{
						num12 = -513176203;
						num13 = num12;
					}
					num2 = num12 ^ ((int)num3 * -1864374875);
					continue;
				}
				case 11u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3998924995u));
					num2 = 208882271;
					continue;
				case 14u:
				{
					int num7;
					int num8;
					if (num != 3)
					{
						num7 = -574003458;
						num8 = num7;
					}
					else
					{
						num7 = -56067522;
						num8 = num7;
					}
					num2 = num7 ^ ((int)num3 * -1493335605);
					continue;
				}
				case 0u:
					return 0;
				case 10u:
					num6 = (float)LuaDLL.lua_tonumber(L, 3);
					num2 = (int)(num3 * 1476183434) ^ -1684035598;
					continue;
				case 6u:
					_202E_202C_206C_202D_206E_202C_202C_206B_200E_206B_206F_206A_200D_206A_206C_202B_206E_206C_200F_206E_202B_202E_206E_206C_202E_200F_202D_206A_202D_206E_200E_206B_200C_202A_200B_206E_200B_206F_206D_206C_202E(val, num5, num6);
					num2 = (int)((num3 * 1728923907) ^ 0x150DCBE);
					continue;
				case 5u:
				{
					float num4 = (float)LuaDLL.lua_tonumber(L, 3);
					_200E_200C_206B_200B_202D_206B_206D_206D_200D_206D_200E_202E_200D_200B_202D_206F_200B_200B_200F_200D_206B_200B_206E_200D_202A_206D_202A_206C_202B_200F_202C_200C_202A_200F_206F_206B_206D_202C_206D_202E_202E(val2, text, num4);
					num2 = ((int)num3 * -499189686) ^ -1155935497;
					continue;
				}
				case 1u:
					val2 = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(756079760u));
					text = LuaScriptMgr.GetString(L, 2);
					num2 = (int)((num3 * 1313068162) ^ 0x761E8424);
					continue;
				case 3u:
					val = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(756079760u));
					num2 = ((int)num3 * -362214800) ^ -1502348804;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetFloat(IntPtr L)
	{
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		if (num == 2)
		{
			goto IL_000e;
		}
		goto IL_018b;
		IL_000e:
		int num2 = 245975796;
		goto IL_0013;
		IL_0013:
		float d2 = default(float);
		Material val2 = default(Material);
		float d = default(float);
		Material val = default(Material);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ 0x3323FAF6)) % 13)
			{
			case 4u:
				break;
			case 7u:
			{
				int num6;
				int num7;
				if (!LuaScriptMgr.CheckTypes(L, 1, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(int).TypeHandle)))
				{
					num6 = -1812639035;
					num7 = num6;
				}
				else
				{
					num6 = -205808908;
					num7 = num6;
				}
				num2 = num6 ^ ((int)num3 * -975526310);
				continue;
			}
			case 5u:
				LuaScriptMgr.Push(L, d2);
				num2 = ((int)num3 * -1537999070) ^ -1163692544;
				continue;
			case 6u:
				val2 = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(756079760u));
				num2 = (int)((num3 * 1439908686) ^ 0x49D994D0);
				continue;
			case 0u:
			{
				string text = LuaScriptMgr.GetString(L, 2);
				d = _202D_206C_200D_200E_202B_200B_206F_206B_206E_206B_202D_200D_200F_206E_202A_206F_206A_200E_200C_200D_206D_200D_206B_206F_206D_202C_202A_206F_206F_206F_200E_206B_202B_202A_206C_200F_202C_206B_200D_206D_202E(val2, text);
				num2 = ((int)num3 * -1960589724) ^ 0x6F59F14C;
				continue;
			}
			case 3u:
			{
				int num8 = (int)LuaDLL.lua_tonumber(L, 2);
				d2 = _206F_200B_206C_200B_200D_200B_206C_200B_200F_206B_206C_202A_202A_202D_200D_200C_206C_202B_206B_202D_206F_200B_202C_200F_202E_206E_202B_200E_202A_206C_206D_200C_202B_200D_206A_202A_200F_200C_200E_202E_202E(val, num8);
				num2 = (int)((num3 * 1395439949) ^ 0xCA29091);
				continue;
			}
			case 10u:
				return 1;
			case 1u:
			{
				int num4;
				int num5;
				if (!LuaScriptMgr.CheckTypes(L, 1, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(string).TypeHandle)))
				{
					num4 = -259854741;
					num5 = num4;
				}
				else
				{
					num4 = -1303372265;
					num5 = num4;
				}
				num2 = num4 ^ ((int)num3 * -1408699023);
				continue;
			}
			case 2u:
				return 1;
			case 11u:
				goto IL_018b;
			case 8u:
				LuaScriptMgr.Push(L, d);
				num2 = ((int)num3 * -1081147695) ^ -710924346;
				continue;
			case 9u:
				val = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3657169530u));
				num2 = (int)((num3 * 1497898396) ^ 0xD32578D);
				continue;
			default:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2147749810u));
				return 0;
			}
			break;
		}
		goto IL_000e;
		IL_018b:
		int num9;
		if (num != 2)
		{
			num2 = 655681867;
			num9 = num2;
		}
		else
		{
			num2 = 1135580118;
			num9 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SetInt(IntPtr L)
	{
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		Material val = default(Material);
		string text = default(string);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		Material val2 = default(Material);
		while (true)
		{
			int num2 = -640095044;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -2081048104)) % 12)
				{
				case 9u:
					break;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4264988713u));
					num2 = -746530449;
					continue;
				case 0u:
					_206D_200B_200B_202B_206C_206A_206F_202A_200F_202D_202B_200C_206B_206B_202E_206A_206E_200B_206D_206A_202C_200C_202E_200D_206A_202C_202A_206E_206A_200D_202E_202D_206E_200F_202E_202C_202B_200F_202C_206E_202E(val, text, num5);
					return 0;
				case 10u:
				{
					int num10;
					int num11;
					if (!LuaScriptMgr.CheckTypes(L, 1, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(int).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(int).TypeHandle)))
					{
						num10 = -1084134247;
						num11 = num10;
					}
					else
					{
						num10 = -362057041;
						num11 = num10;
					}
					num2 = num10 ^ ((int)num3 * -1371997709);
					continue;
				}
				case 3u:
					val = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2294193498u));
					text = LuaScriptMgr.GetString(L, 2);
					num5 = (int)LuaDLL.lua_tonumber(L, 3);
					num2 = ((int)num3 * -624887611) ^ 0x7D049DBB;
					continue;
				case 1u:
					num6 = (int)LuaDLL.lua_tonumber(L, 2);
					num7 = (int)LuaDLL.lua_tonumber(L, 3);
					num2 = ((int)num3 * -1714362239) ^ 0x2317A82F;
					continue;
				case 8u:
				{
					int num12;
					int num13;
					if (num != 3)
					{
						num12 = 482188863;
						num13 = num12;
					}
					else
					{
						num12 = 1331528330;
						num13 = num12;
					}
					num2 = num12 ^ ((int)num3 * -1417093362);
					continue;
				}
				case 6u:
				{
					int num8;
					int num9;
					if (!LuaScriptMgr.CheckTypes(L, 1, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(string).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(int).TypeHandle)))
					{
						num8 = 736310328;
						num9 = num8;
					}
					else
					{
						num8 = 761528823;
						num9 = num8;
					}
					num2 = num8 ^ ((int)num3 * -1060196058);
					continue;
				}
				case 5u:
					val2 = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(756079760u));
					num2 = (int)((num3 * 1016258067) ^ 0x70450406);
					continue;
				case 2u:
					_200D_200C_202E_200F_206A_202A_202B_202D_206F_200C_202C_200B_200B_202E_202D_200E_200F_202E_206F_206E_202C_202E_200C_200F_206B_200E_206E_206F_200F_202E_206A_202B_202D_200C_206F_202E_206D_200D_202B_202B_202E(val2, num6, num7);
					return 0;
				case 7u:
				{
					int num4;
					if (num != 3)
					{
						num2 = -24574996;
						num4 = num2;
					}
					else
					{
						num2 = -780942986;
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
	private static int GetInt(IntPtr L)
	{
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		int num6 = default(int);
		int d = default(int);
		Material val = default(Material);
		string text = default(string);
		int d2 = default(int);
		Material val2 = default(Material);
		while (true)
		{
			int num2 = -293864696;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -188608756)) % 16)
				{
				case 2u:
					break;
				case 14u:
					num6 = (int)LuaDLL.lua_tonumber(L, 2);
					num2 = ((int)num3 * -966078116) ^ -958222319;
					continue;
				case 10u:
				{
					int num7;
					if (num != 2)
					{
						num2 = -1383171716;
						num7 = num2;
					}
					else
					{
						num2 = -816785311;
						num7 = num2;
					}
					continue;
				}
				case 3u:
					d = _206C_200F_202C_200E_206F_202A_206F_202C_206A_202B_200E_200B_200E_200C_202B_206E_202A_206B_206D_206E_202D_200E_206A_206F_202A_206F_200C_202D_202A_202E_206F_200E_202C_200F_200B_202C_200B_202C_200F_206A_202E(val, text);
					num2 = ((int)num3 * -263663839) ^ -78643756;
					continue;
				case 11u:
					LuaScriptMgr.Push(L, d);
					num2 = ((int)num3 * -855968509) ^ -918868868;
					continue;
				case 7u:
					LuaScriptMgr.Push(L, d2);
					num2 = (int)((num3 * 1648769676) ^ 0x274FCF71);
					continue;
				case 8u:
					text = LuaScriptMgr.GetString(L, 2);
					num2 = ((int)num3 * -742243854) ^ -1262081697;
					continue;
				case 13u:
				{
					int num10;
					int num11;
					if (!LuaScriptMgr.CheckTypes(L, 1, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(string).TypeHandle)))
					{
						num10 = -814818141;
						num11 = num10;
					}
					else
					{
						num10 = -1125946404;
						num11 = num10;
					}
					num2 = num10 ^ ((int)num3 * -1826986245);
					continue;
				}
				case 5u:
					d2 = _200E_202C_206A_202C_200B_202D_200E_202E_202A_202E_200D_202B_202B_206B_206D_206A_206E_202B_206A_200C_202D_200E_202A_202C_200D_200D_206B_200C_200D_206D_202D_200E_200D_206A_202E_200E_200F_202E_200B_206E_202E(val2, num6);
					num2 = (int)(num3 * 1430111599) ^ -51320480;
					continue;
				case 15u:
					val = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(756079760u));
					num2 = ((int)num3 * -2100557490) ^ -399589450;
					continue;
				case 9u:
					return 1;
				case 1u:
					return 1;
				case 4u:
				{
					int num8;
					int num9;
					if (num != 2)
					{
						num8 = -1131122706;
						num9 = num8;
					}
					else
					{
						num8 = -1648286974;
						num9 = num8;
					}
					num2 = num8 ^ (int)(num3 * 1032756814);
					continue;
				}
				case 12u:
					val2 = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3657169530u));
					num2 = (int)(num3 * 613571103) ^ -1500079210;
					continue;
				case 6u:
				{
					int num4;
					int num5;
					if (!LuaScriptMgr.CheckTypes(L, 1, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(int).TypeHandle)))
					{
						num4 = 1799543700;
						num5 = num4;
					}
					else
					{
						num4 = 973152066;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 1871391091);
					continue;
				}
				default:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2260956289u));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SetBuffer(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 3);
		Material val = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(756079760u));
		string luaString = default(string);
		ComputeBuffer val2 = default(ComputeBuffer);
		while (true)
		{
			int num = -85099499;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -533146561)) % 5)
				{
				case 3u:
					break;
				case 4u:
					luaString = LuaScriptMgr.GetLuaString(L, 2);
					num = (int)((num2 * 1275475391) ^ 0x23D62311);
					continue;
				case 0u:
					_202D_200D_200D_200D_200F_206F_200C_202D_206F_206F_202A_202E_206D_200B_206C_200F_206E_206A_202E_206F_206A_202E_200F_200C_202A_202B_202C_202E_202D_206F_206E_206F_202E_206E_206D_206F_200B_200B_202A_206B_202E(val, luaString, val2);
					num = ((int)num2 * -1304689397) ^ 0x3EAEBDE4;
					continue;
				case 1u:
					val2 = (ComputeBuffer)LuaScriptMgr.GetNetObject(L, 3, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(ComputeBuffer).TypeHandle));
					num = (int)(num2 * 1590772748) ^ -1800006623;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int HasProperty(IntPtr L)
	{
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		Material val = default(Material);
		string text = default(string);
		bool b = default(bool);
		while (true)
		{
			int num2 = -2045496124;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1485873365)) % 14)
				{
				case 12u:
					break;
				case 3u:
				{
					bool b2 = _202D_206E_206F_200D_202D_206F_202D_200B_200D_200F_200E_200D_200E_200F_202A_200F_202A_200F_200E_206C_202A_200C_200F_202B_200B_200F_200D_200E_202D_200F_202E_200C_200D_206E_206A_206B_202A_200C_206A_206A_202E(val, text);
					LuaScriptMgr.Push(L, b2);
					num2 = (int)((num3 * 1084808166) ^ 0x60558E2A);
					continue;
				}
				case 7u:
					val = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3657169530u));
					num2 = (int)(num3 * 422357488) ^ -461146186;
					continue;
				case 4u:
				{
					int num9;
					int num10;
					if (LuaScriptMgr.CheckTypes(L, 1, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(int).TypeHandle)))
					{
						num9 = -570640747;
						num10 = num9;
					}
					else
					{
						num9 = -2005029171;
						num10 = num9;
					}
					num2 = num9 ^ (int)(num3 * 207571784);
					continue;
				}
				case 11u:
					return 1;
				case 2u:
					LuaScriptMgr.Push(L, b);
					num2 = ((int)num3 * -785653242) ^ -1133664341;
					continue;
				case 6u:
					return 1;
				case 13u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2996883553u));
					num2 = -1884690364;
					continue;
				case 9u:
					text = LuaScriptMgr.GetString(L, 2);
					num2 = ((int)num3 * -364247048) ^ 0x784F64F0;
					continue;
				case 0u:
				{
					Material val2 = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(756079760u));
					int num11 = (int)LuaDLL.lua_tonumber(L, 2);
					b = _200E_206A_206B_206E_202A_206A_200D_200F_206D_206F_206B_206E_202B_200C_202D_200F_200D_202B_200D_202E_200D_202E_206F_202C_206F_206B_202E_200C_206B_202D_202D_202A_202D_206B_200F_202A_206E_200D_200E_206B_202E(val2, num11);
					num2 = ((int)num3 * -1724024690) ^ 0x7E3DD975;
					continue;
				}
				case 1u:
				{
					int num7;
					int num8;
					if (num == 2)
					{
						num7 = 1555113617;
						num8 = num7;
					}
					else
					{
						num7 = 655635485;
						num8 = num7;
					}
					num2 = num7 ^ ((int)num3 * -420357248);
					continue;
				}
				case 10u:
				{
					int num5;
					int num6;
					if (LuaScriptMgr.CheckTypes(L, 1, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle), _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(string).TypeHandle)))
					{
						num5 = -2098785876;
						num6 = num5;
					}
					else
					{
						num5 = -172242978;
						num6 = num5;
					}
					num2 = num5 ^ (int)(num3 * 1902687991);
					continue;
				}
				case 8u:
				{
					int num4;
					if (num == 2)
					{
						num2 = -1085683645;
						num4 = num2;
					}
					else
					{
						num2 = -761544058;
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
	private static int GetTag(IntPtr L)
	{
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		if (num == 3)
		{
			goto IL_000e;
		}
		goto IL_0130;
		IL_000e:
		int num2 = -1337983773;
		goto IL_0013;
		IL_0013:
		Material val2 = default(Material);
		string luaString3 = default(string);
		bool boolean2 = default(bool);
		string str2 = default(string);
		Material val = default(Material);
		string luaString = default(string);
		bool boolean = default(bool);
		string luaString2 = default(string);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ -880794866)) % 10)
			{
			case 8u:
				break;
			case 9u:
				val2 = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3282258027u));
				num2 = ((int)num3 * -1074863367) ^ 0x33ED510;
				continue;
			case 5u:
				luaString3 = LuaScriptMgr.GetLuaString(L, 2);
				boolean2 = LuaScriptMgr.GetBoolean(L, 3);
				num2 = (int)(num3 * 1283387385) ^ -600074915;
				continue;
			case 2u:
				str2 = _202C_206B_202E_202C_202B_200E_206C_200D_206C_206D_206C_200B_200E_202E_202A_202A_202B_200C_206E_206E_206C_202A_202B_206C_200E_202D_200F_202B_206A_206F_200D_200C_202E_206B_200F_206D_202A_200F_202A_206B_202E(val2, luaString3, boolean2);
				num2 = ((int)num3 * -1476828536) ^ -976028799;
				continue;
			case 0u:
				val = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1137371893u));
				luaString = LuaScriptMgr.GetLuaString(L, 2);
				boolean = LuaScriptMgr.GetBoolean(L, 3);
				luaString2 = LuaScriptMgr.GetLuaString(L, 4);
				num2 = (int)(num3 * 1587023843) ^ -702257781;
				continue;
			case 3u:
				LuaScriptMgr.Push(L, str2);
				return 1;
			case 6u:
				return 1;
			case 4u:
				goto IL_0130;
			case 7u:
			{
				string str = _202C_200D_200F_202D_200E_206C_206C_206C_206F_206E_202D_202E_206B_206E_202E_200B_202B_202E_202A_202B_202D_206D_202B_202B_206A_202D_206B_206D_206E_202C_200D_202A_206F_206A_202E_200D_202C_206C_202E_206C_202E(val, luaString, boolean, luaString2);
				LuaScriptMgr.Push(L, str);
				num2 = (int)((num3 * 93730381) ^ 0x4EAD0C53);
				continue;
			}
			default:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1156341463u));
				return 0;
			}
			break;
		}
		goto IL_000e;
		IL_0130:
		int num4;
		if (num != 4)
		{
			num2 = -25437683;
			num4 = num2;
		}
		else
		{
			num2 = -1191132136;
			num4 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SetOverrideTag(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 3);
		Material val = default(Material);
		string luaString2 = default(string);
		while (true)
		{
			int num = 21313898;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x379EB30C)) % 4)
				{
				case 0u:
					break;
				case 2u:
					val = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1137371893u));
					num = (int)((num2 * 1111938865) ^ 0x7C819C6B);
					continue;
				case 1u:
					luaString2 = LuaScriptMgr.GetLuaString(L, 2);
					num = (int)((num2 * 816155466) ^ 0x509F93C5);
					continue;
				default:
				{
					string luaString = LuaScriptMgr.GetLuaString(L, 3);
					_206E_200C_202B_206B_206C_202C_200C_206D_200B_206B_206F_202C_206B_206D_200F_202C_200E_200C_206D_200F_200C_200D_206F_206F_200F_200F_206B_202E_200F_202A_202C_206A_206C_206C_200D_206B_202C_206E_200E_206D_202E(val, luaString2, luaString);
					return 0;
				}
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Lerp(IntPtr L)
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 4);
		Material val = default(Material);
		Material val2 = default(Material);
		Material val3 = default(Material);
		float num3 = default(float);
		while (true)
		{
			int num = 1640605629;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2431E160)) % 5)
				{
				case 0u:
					break;
				case 3u:
					val = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1137371893u));
					num = ((int)num2 * -388134799) ^ 0x4676EC6D;
					continue;
				case 1u:
					val2 = (Material)LuaScriptMgr.GetUnityObject(L, 2, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle));
					num = ((int)num2 * -1360543089) ^ 0x320D7776;
					continue;
				case 2u:
					val3 = (Material)LuaScriptMgr.GetUnityObject(L, 3, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle));
					num3 = (float)LuaScriptMgr.GetNumber(L, 4);
					num = (int)(num2 * 1074474445) ^ -1802434052;
					continue;
				default:
					_206B_202A_206F_206E_200C_200E_206C_202E_202E_202B_202B_202C_200E_206F_202A_202D_202C_206A_200D_202A_206F_206B_202D_202B_202D_206D_200D_202B_202E_202C_200D_206A_206E_206B_200E_206A_206B_206D_200D_202E(val, val2, val3, num3);
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SetPass(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		Material val = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(756079760u));
		int num = (int)LuaScriptMgr.GetNumber(L, 2);
		bool b = _202B_200C_202E_200B_202A_200D_200D_206E_206D_206F_206B_200E_206A_206A_202C_202A_200D_200D_206A_206F_202B_206E_206B_202A_206C_200C_202D_202E_206D_206D_206F_200B_202B_206F_206A_206B_202A_200E_200D_202C_202E(val, num);
		LuaScriptMgr.Push(L, b);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int CopyPropertiesFromMaterial(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		Material val = default(Material);
		Material val2 = default(Material);
		while (true)
		{
			int num = 1517218123;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x764161DA)) % 4)
				{
				case 3u:
					break;
				case 1u:
					val = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1137371893u));
					num = ((int)num2 * -1624727298) ^ -207684974;
					continue;
				case 2u:
					val2 = (Material)LuaScriptMgr.GetUnityObject(L, 2, _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(typeof(Material).TypeHandle));
					num = (int)(num2 * 1864521007) ^ -1775172224;
					continue;
				default:
					_206C_200B_200C_206F_200D_202E_206E_202C_202C_206C_200B_200D_200D_200C_202D_202B_202E_200D_200B_206B_202E_206C_202E_206B_200E_200E_206A_206E_202C_200C_206A_206B_202B_200C_200F_206F_200B_206F_206C_200E_202E(val, val2);
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int EnableKeyword(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		Material val = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1137371893u));
		string luaString = LuaScriptMgr.GetLuaString(L, 2);
		_202E_206A_200D_200E_200F_206D_200C_206D_206C_200D_202D_200B_202A_202C_200B_206D_202D_206B_200D_206A_202B_206C_202E_206C_202B_206F_202E_202B_206C_200F_202A_200C_202D_202E_206E_200D_206F_200E_206C_200F_202E(val, luaString);
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int DisableKeyword(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		Material val = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2294193498u));
		string luaString = default(string);
		while (true)
		{
			int num = 1554114510;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x669C32F9)) % 4)
				{
				case 0u:
					break;
				case 3u:
					luaString = LuaScriptMgr.GetLuaString(L, 2);
					num = ((int)num2 * -1777407845) ^ 0x549947A1;
					continue;
				case 1u:
					_200F_200B_206D_202A_206B_206C_200D_206F_200B_202D_202B_202C_202A_206F_200B_206E_206F_202A_200E_202E_202D_206E_206E_206A_202A_200B_200B_200F_200B_206A_206C_206D_206C_206A_202C_206A_206F_202B_202B_202E(val, luaString);
					num = ((int)num2 * -137789778) ^ -369214131;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int IsKeywordEnabled(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		Material val = (Material)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3282258027u));
		bool b = default(bool);
		string luaString = default(string);
		while (true)
		{
			int num = 1279677163;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4ED4AECF)) % 5)
				{
				case 4u:
					break;
				case 0u:
					LuaScriptMgr.Push(L, b);
					num = ((int)num2 * -1094068388) ^ -1752247775;
					continue;
				case 3u:
					b = _206F_206D_206A_202A_200E_200B_206E_206A_202D_206F_206B_200D_202E_200E_200D_206A_206A_200F_202E_200C_202A_202D_206D_202D_206F_206F_200D_206B_202B_200F_202A_200D_200D_202A_202B_202E_202A_206F_206A_206C_202E(val, luaString);
					num = ((int)num2 * -322556377) ^ -352207018;
					continue;
				case 1u:
					luaString = LuaScriptMgr.GetLuaString(L, 2);
					num = ((int)num2 * -671222504) ^ 0xC753D70;
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
		Object val = default(Object);
		while (true)
		{
			int num = 437829672;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x707C72D)) % 5)
				{
				case 4u:
					break;
				case 0u:
					LuaScriptMgr.Push(L, b);
					num = (int)(num2 * 158343736) ^ -1097383389;
					continue;
				case 1u:
				{
					object luaObject2 = LuaScriptMgr.GetLuaObject(L, 2);
					Object val2 = (Object)((luaObject2 is Object) ? luaObject2 : null);
					b = _202C_200C_200D_206F_200F_202A_202A_206A_200D_202E_202E_202B_202A_206E_202B_202D_200C_206C_202A_200E_206C_206C_200F_202D_202E_202D_206B_206C_200B_200B_200E_202E_206F_200C_206B_202B_200F_202C_206D_202A_202E(val, val2);
					num = ((int)num2 * -1350344430) ^ 0x2BD03718;
					continue;
				}
				case 2u:
				{
					object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
					val = (Object)((luaObject is Object) ? luaObject : null);
					num = ((int)num2 * -1898845510) ^ 0x12785EAC;
					continue;
				}
				default:
					return 1;
				}
				break;
			}
		}
	}

	static Type _202A_202E_200C_200C_200C_202C_206C_202D_202E_202A_206B_202D_200B_206C_200F_206E_200E_206C_200F_202A_206D_206E_200D_200C_202E_200F_206F_202E_200C_200D_202A_200F_200B_206D_206B_200B_206B_202C_200B_202A_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static Material _202C_202C_206C_200C_202A_202B_202D_200F_202D_202C_202A_200B_200F_200B_206B_202A_202B_206A_202B_202C_206F_200D_206F_206B_206F_202A_206E_202D_202B_200E_202C_206F_200E_206B_200C_200F_200B_202B_206F_206A_202E(Material P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Material(P_0);
	}

	static Material _200B_202A_206D_200C_200E_202B_206D_202E_202D_200D_200B_200E_200F_206C_202B_202A_202E_202B_202B_202D_200C_202E_200F_202D_206C_206D_200C_202B_206A_206C_200F_206C_206F_202D_200D_202C_206E_206C_202B_206C_202E(Shader P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Material(P_0);
	}

	static bool _202C_200C_200D_206F_200F_202A_202A_206A_200D_202E_202E_202B_202A_206E_202B_202D_200C_206C_202A_200E_206C_206C_200F_202D_202E_202D_206B_206C_200B_200B_200E_202E_206F_200C_206B_202B_200F_202C_206D_202A_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static Shader _206E_206A_202D_200C_202A_200D_206B_206E_200C_202B_202A_206C_200E_200E_206A_200D_202B_202A_202A_206B_200B_206C_202D_202D_202C_202B_206E_206A_200C_200F_206F_202E_206E_200C_206A_200E_206A_202B_200C_200F_202E(Material P_0)
	{
		return P_0.shader;
	}

	static Color _206F_202D_200B_202C_200B_200F_206F_202A_206D_202E_206E_206F_206E_200F_202E_206B_200F_202A_200B_206F_206F_206C_202B_206B_200F_202C_206B_200F_206B_206F_202E_202D_200C_200E_200E_202E_206F_200D_206D_200D_202E(Material P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.color;
	}

	static Texture _202C_206E_200E_206F_206F_202C_202E_202E_200B_206E_202B_206F_202D_206D_206C_206A_202A_202D_202B_200D_200D_200C_202C_202A_206C_202C_206C_206C_200B_202D_206E_202E_202C_202E_202C_206D_200B_206A_202B_200E_202E(Material P_0)
	{
		return P_0.mainTexture;
	}

	static Vector2 _206F_202C_200E_200B_200E_206F_200D_200F_206D_200B_200E_202A_200E_202E_200F_202D_202E_202C_202B_200C_200C_202C_206D_206D_200F_206C_200C_200D_206B_200D_206B_206B_206A_202B_202E_200D_200E_200E_202B_202D_202E(Material P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.mainTextureOffset;
	}

	static Vector2 _200C_206D_206B_200D_202A_200C_206A_200C_206E_200B_200F_200D_202E_206F_200F_202A_202C_200B_206D_200E_206B_206A_202D_202C_200D_202A_200E_200B_206D_202A_206C_200D_200C_206C_200C_202E_202B_202E_200C_206F_202E(Material P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.mainTextureScale;
	}

	static int _202A_202D_206B_200F_206A_206C_202B_202A_200D_206A_200E_202A_202A_202B_200F_206E_206C_206F_206D_206B_206A_200B_206E_206B_200B_202D_202C_206C_206D_200F_200C_202E_200F_200B_202E_206F_202A_206A_206F_200E_202E(Material P_0)
	{
		return P_0.passCount;
	}

	static int _206F_202E_202D_206B_206B_202E_200C_206C_202A_200D_202D_202A_206D_202D_202A_200B_200B_200C_206D_206D_206B_202B_200D_206A_206C_206A_202A_202E_206D_206F_202B_206E_206D_200F_206A_202E_206C_200F_200C_202A_202E(Material P_0)
	{
		return P_0.renderQueue;
	}

	static string[] _206B_202C_202A_206B_206A_200C_202B_200F_202A_206D_202C_206D_206B_200B_200F_206A_206E_206F_206B_206A_202B_200B_206A_200D_206D_206E_200D_202D_202B_200D_200B_202D_200B_202D_202B_202B_200D_206B_206C_206A_202E(Material P_0)
	{
		return P_0.shaderKeywords;
	}

	static MaterialGlobalIlluminationFlags _200E_200D_202A_202C_202A_200D_200F_202B_202B_200E_206E_200D_202E_206F_206C_202E_202C_202C_202D_200F_202E_202D_200E_206B_202B_202C_206A_206B_200B_202C_202C_206B_200E_202E_206C_202C_206A_202C_200F_206E_202E(Material P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.globalIlluminationFlags;
	}

	static void _206B_202E_202A_200E_200E_202A_206B_206A_206E_200E_206F_200E_206C_202B_200D_202A_202B_202A_202E_202C_206E_200D_202B_206F_200C_206B_206A_202B_206C_206A_200E_206A_202B_202D_202B_200C_206C_206E_200E_202B_202E(Material P_0, Shader P_1)
	{
		P_0.shader = P_1;
	}

	static void _202B_206B_200D_206B_206C_200C_206F_206A_206A_202D_200D_206A_200E_206E_200F_202A_202E_202B_206C_202B_202B_200E_202A_206F_206B_206F_202D_200B_202B_206D_206B_206F_206F_200C_200B_200C_206D_206F_200E_200E_202E(Material P_0, Color P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.color = P_1;
	}

	static void _200D_206B_202E_206B_206A_200D_200B_200C_202B_200F_206A_202D_206E_206D_206D_200C_200B_206B_206A_200D_206F_202E_202D_206C_202D_200B_202A_206A_206F_202B_200D_206E_202B_202C_202E_206E_206C_200B_202A_200F_202E(Material P_0, Texture P_1)
	{
		P_0.mainTexture = P_1;
	}

	static void _202C_206E_202E_206E_202A_202A_206B_202A_200F_202C_206E_200F_202A_200B_202B_206F_200D_206A_202B_200C_202B_202C_206E_206F_200F_206D_202A_206A_200E_202B_206A_202C_200D_200C_202A_202B_206D_200E_200D_200D_202E(Material P_0, Vector2 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.mainTextureOffset = P_1;
	}

	static void _202D_200B_202B_200C_206E_200F_206D_206C_206D_206C_200F_206B_200B_200B_202A_206B_202E_206B_206F_202E_206F_200B_202D_200F_200D_202B_200C_202E_202C_206A_202A_200C_200F_200F_206E_200B_202D_206C_206D_200F_202E(Material P_0, Vector2 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.mainTextureScale = P_1;
	}

	static void _206B_202A_202E_206F_206A_206E_202A_202D_202E_202E_206F_202D_206D_200D_206B_200B_202A_202A_200D_200D_200C_200C_202C_206D_202C_206A_202A_200D_202B_200E_202D_206E_202C_202E_206B_206A_200F_202E_202A_200D_202E(Material P_0, int P_1)
	{
		P_0.renderQueue = P_1;
	}

	static void _200D_200E_202C_200D_206D_200D_200C_206F_200D_200E_200C_200E_200D_202E_200E_202C_202D_206C_202A_206D_202E_202C_200F_206B_206D_206C_206E_206F_200B_200C_202A_200B_200C_200E_200B_202D_200F_206C_206C_202A_202E(Material P_0, string[] P_1)
	{
		P_0.shaderKeywords = P_1;
	}

	static void _200D_202A_206D_206F_206E_206A_206E_202E_206F_202E_206A_206C_206E_200E_202D_206F_206C_206F_200D_202C_200E_202D_200F_202A_202E_206A_206E_200F_200F_200D_206C_202E_200F_202B_206F_202D_200D_200E_200E_202D_202E(Material P_0, MaterialGlobalIlluminationFlags P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.globalIlluminationFlags = P_1;
	}

	static void _200B_200F_200B_202C_200D_206A_206B_202B_206C_200C_202C_200C_206C_202D_206D_206B_200D_202D_202D_202C_200C_206E_206D_202C_200C_202C_206D_206D_202D_200B_206B_202E_200B_206A_200F_206A_206F_206C_200B_206A_202E(Material P_0, int P_1, Color P_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		P_0.SetColor(P_1, P_2);
	}

	static void _206D_200B_200F_206A_200C_206C_200B_202C_206C_202E_202A_200B_200B_202E_202C_200E_202B_206C_200E_202C_200E_202C_206B_206E_206B_202D_200C_206C_206B_202E_206F_200C_200C_202A_206B_202A_202C_202C_200B_200E_202E(Material P_0, string P_1, Color P_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		P_0.SetColor(P_1, P_2);
	}

	static Color _206E_202D_202D_206B_202A_206B_206C_202A_206C_206A_206E_206A_206A_200F_202B_200D_202C_200B_202E_202E_200F_202C_206E_200E_206B_202D_200C_202A_202C_202B_200F_200D_206A_206B_202C_202A_206C_200E_200C_200D_202E(Material P_0, int P_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return P_0.GetColor(P_1);
	}

	static Color _206B_200F_202B_202C_200D_200E_206A_202D_206C_202A_200D_206F_202A_200E_200D_202A_206B_200C_206B_206C_202A_202D_206B_200C_200D_206F_206C_206A_206A_202B_200E_206E_202E_202A_202A_200D_206B_202E_206E_200F_202E(Material P_0, string P_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return P_0.GetColor(P_1);
	}

	static void _206C_200B_200C_206F_206E_202C_200D_202B_200B_200B_200E_206A_206A_200F_200F_206C_200B_202A_206B_206B_202B_202D_202B_202D_200F_200E_200F_206B_202B_206C_206D_200C_200B_202C_206D_202A_206C_202A_202A_200D_202E(Material P_0, int P_1, Vector4 P_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		P_0.SetVector(P_1, P_2);
	}

	static void _206A_206A_206D_200B_200E_200D_206D_202A_200F_200C_200F_206B_200D_202B_200B_200C_202C_206E_200D_202A_206C_202B_202D_206E_200B_206C_206B_206D_202D_202C_200F_200B_206E_200B_206B_206A_206E_206B_206E_200E_202E(Material P_0, string P_1, Vector4 P_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		P_0.SetVector(P_1, P_2);
	}

	static Vector4 _206C_206E_206C_202B_206A_200D_200F_206F_200D_202D_200B_202D_200D_200C_200B_202C_202D_202B_202D_206C_206F_202C_202C_200F_206A_202E_200B_206F_202A_202A_200C_202A_206F_206E_206D_206D_202E_202B_206D_200E_202E(Material P_0, int P_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return P_0.GetVector(P_1);
	}

	static Vector4 _206E_206B_200F_200E_202C_206D_206D_200D_206A_206E_200D_202B_202E_202D_206D_206E_206B_202C_206E_202C_200D_200C_206E_206A_206C_206C_202D_206E_200D_200C_200F_202D_206B_206C_206F_202B_202A_206D_206E_206F_202E(Material P_0, string P_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return P_0.GetVector(P_1);
	}

	static void _202C_200D_206D_202E_200F_202D_200C_202E_200F_206B_206B_206B_206D_202C_200E_200D_206D_200F_200C_200B_206E_202A_200E_206A_206C_200D_202A_206C_200C_206A_202A_206B_206A_206B_200E_200F_200E_206D_202A_202D_202E(Material P_0, int P_1, Texture P_2)
	{
		P_0.SetTexture(P_1, P_2);
	}

	static void _206C_206E_200C_200F_206E_202E_202A_206B_206E_200F_200F_200B_200F_202D_202C_202D_200E_206C_206B_202D_200C_200D_206D_200E_206A_202D_202B_200F_206A_202A_202B_202D_202D_200F_202B_200F_202A_206C_206A_200E_202E(Material P_0, string P_1, Texture P_2)
	{
		P_0.SetTexture(P_1, P_2);
	}

	static Texture _200C_202B_202A_200D_202E_200E_202C_202C_200D_206F_206F_206C_200D_202D_206E_200E_200C_202C_206F_206D_206C_202C_206F_200F_206F_206B_202C_206D_202E_202E_206C_206E_206B_200D_202E_200D_206E_206F_200B_202D_202E(Material P_0, int P_1)
	{
		return P_0.GetTexture(P_1);
	}

	static Texture _202C_200E_200E_200B_206D_200D_202D_206D_202D_200C_200C_206B_206E_206B_200D_200D_206F_202B_206D_206F_200E_206D_200E_206D_206C_206D_202D_200E_206E_206D_200C_200D_206A_200F_202C_200B_206A_206F_200D_206A_202E(Material P_0, string P_1)
	{
		return P_0.GetTexture(P_1);
	}

	static void _202D_206D_206D_200F_200F_206E_200B_200E_206F_206B_206D_202A_200C_206D_200D_202E_200C_202B_206A_202B_200E_206C_200B_200F_206B_200E_200C_206E_200F_200F_206B_202E_202B_202E_202A_202E_202C_200B_206A_200E_202E(Material P_0, string P_1, Vector2 P_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		P_0.SetTextureOffset(P_1, P_2);
	}

	static Vector2 _206A_206B_200D_206F_200B_206D_206C_202A_202D_202C_200F_206D_202C_202B_206C_202D_206D_202D_200D_202D_200F_200B_206E_202B_200B_206C_202C_200F_200B_202D_206B_202C_202A_206C_200B_206C_206B_200B_202C_202D_202E(Material P_0, string P_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return P_0.GetTextureOffset(P_1);
	}

	static void _200E_206F_200B_206D_202D_202D_206D_206B_200F_206E_206E_200E_200C_206F_200E_200C_202B_206F_200F_200B_206C_206E_200D_206C_202C_202B_206A_200D_202B_202E_200C_206B_206B_202E_206B_200E_202D_202B_206F_202D_202E(Material P_0, string P_1, Vector2 P_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		P_0.SetTextureScale(P_1, P_2);
	}

	static Vector2 _200B_206B_202C_206A_206B_200F_200B_202D_206E_202B_202D_202A_206F_200B_206D_202D_206F_206C_200E_206C_200F_202B_200F_200B_202D_202B_206B_206E_200F_200C_202E_200F_206B_202E_202B_200D_202B_206A_206B_202B_202E(Material P_0, string P_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return P_0.GetTextureScale(P_1);
	}

	static void _202A_206B_200F_206A_200C_202C_202D_202B_200D_200B_206D_200E_206D_206F_202E_206F_200E_200D_200F_202A_200C_200B_206E_202C_206B_206A_202C_202E_202E_202E_202E_206F_206A_202D_202A_206E_202C_206B_206C_202D_202E(Material P_0, int P_1, Matrix4x4 P_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		P_0.SetMatrix(P_1, P_2);
	}

	static void _200F_206F_202C_202A_206C_206E_202E_206B_206D_202D_200B_200E_202B_202B_202E_206C_206E_200D_206D_206A_200E_200B_206D_200B_202B_202A_202E_206F_206B_202C_206F_206C_200F_202B_202D_202B_206C_200F_200D_200C_202E(Material P_0, string P_1, Matrix4x4 P_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		P_0.SetMatrix(P_1, P_2);
	}

	static Matrix4x4 _200C_200C_200B_200C_200D_202E_202B_202B_200F_200D_202E_200F_202C_202A_202A_206F_206F_206F_202C_202C_206A_200C_200E_206D_200E_202A_200C_206F_206C_200C_200F_206B_200F_206D_200D_200B_206A_206F_206C_206E_202E(Material P_0, int P_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return P_0.GetMatrix(P_1);
	}

	static Matrix4x4 _206F_200E_200E_200E_200F_206F_200B_206F_202D_206E_202C_206C_200F_200F_206C_206D_202C_202E_200E_202C_200D_202C_202D_202C_206D_202B_202D_200B_202D_202D_206C_200F_200D_200B_202D_200D_200C_206D_200F_200C_202E(Material P_0, string P_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return P_0.GetMatrix(P_1);
	}

	static void _202E_202C_206C_202D_206E_202C_202C_206B_200E_206B_206F_206A_200D_206A_206C_202B_206E_206C_200F_206E_202B_202E_206E_206C_202E_200F_202D_206A_202D_206E_200E_206B_200C_202A_200B_206E_200B_206F_206D_206C_202E(Material P_0, int P_1, float P_2)
	{
		P_0.SetFloat(P_1, P_2);
	}

	static void _200E_200C_206B_200B_202D_206B_206D_206D_200D_206D_200E_202E_200D_200B_202D_206F_200B_200B_200F_200D_206B_200B_206E_200D_202A_206D_202A_206C_202B_200F_202C_200C_202A_200F_206F_206B_206D_202C_206D_202E_202E(Material P_0, string P_1, float P_2)
	{
		P_0.SetFloat(P_1, P_2);
	}

	static float _206F_200B_206C_200B_200D_200B_206C_200B_200F_206B_206C_202A_202A_202D_200D_200C_206C_202B_206B_202D_206F_200B_202C_200F_202E_206E_202B_200E_202A_206C_206D_200C_202B_200D_206A_202A_200F_200C_200E_202E_202E(Material P_0, int P_1)
	{
		return P_0.GetFloat(P_1);
	}

	static float _202D_206C_200D_200E_202B_200B_206F_206B_206E_206B_202D_200D_200F_206E_202A_206F_206A_200E_200C_200D_206D_200D_206B_206F_206D_202C_202A_206F_206F_206F_200E_206B_202B_202A_206C_200F_202C_206B_200D_206D_202E(Material P_0, string P_1)
	{
		return P_0.GetFloat(P_1);
	}

	static void _200D_200C_202E_200F_206A_202A_202B_202D_206F_200C_202C_200B_200B_202E_202D_200E_200F_202E_206F_206E_202C_202E_200C_200F_206B_200E_206E_206F_200F_202E_206A_202B_202D_200C_206F_202E_206D_200D_202B_202B_202E(Material P_0, int P_1, int P_2)
	{
		P_0.SetInt(P_1, P_2);
	}

	static void _206D_200B_200B_202B_206C_206A_206F_202A_200F_202D_202B_200C_206B_206B_202E_206A_206E_200B_206D_206A_202C_200C_202E_200D_206A_202C_202A_206E_206A_200D_202E_202D_206E_200F_202E_202C_202B_200F_202C_206E_202E(Material P_0, string P_1, int P_2)
	{
		P_0.SetInt(P_1, P_2);
	}

	static int _200E_202C_206A_202C_200B_202D_200E_202E_202A_202E_200D_202B_202B_206B_206D_206A_206E_202B_206A_200C_202D_200E_202A_202C_200D_200D_206B_200C_200D_206D_202D_200E_200D_206A_202E_200E_200F_202E_200B_206E_202E(Material P_0, int P_1)
	{
		return P_0.GetInt(P_1);
	}

	static int _206C_200F_202C_200E_206F_202A_206F_202C_206A_202B_200E_200B_200E_200C_202B_206E_202A_206B_206D_206E_202D_200E_206A_206F_202A_206F_200C_202D_202A_202E_206F_200E_202C_200F_200B_202C_200B_202C_200F_206A_202E(Material P_0, string P_1)
	{
		return P_0.GetInt(P_1);
	}

	static void _202D_200D_200D_200D_200F_206F_200C_202D_206F_206F_202A_202E_206D_200B_206C_200F_206E_206A_202E_206F_206A_202E_200F_200C_202A_202B_202C_202E_202D_206F_206E_206F_202E_206E_206D_206F_200B_200B_202A_206B_202E(Material P_0, string P_1, ComputeBuffer P_2)
	{
		P_0.SetBuffer(P_1, P_2);
	}

	static bool _200E_206A_206B_206E_202A_206A_200D_200F_206D_206F_206B_206E_202B_200C_202D_200F_200D_202B_200D_202E_200D_202E_206F_202C_206F_206B_202E_200C_206B_202D_202D_202A_202D_206B_200F_202A_206E_200D_200E_206B_202E(Material P_0, int P_1)
	{
		return P_0.HasProperty(P_1);
	}

	static bool _202D_206E_206F_200D_202D_206F_202D_200B_200D_200F_200E_200D_200E_200F_202A_200F_202A_200F_200E_206C_202A_200C_200F_202B_200B_200F_200D_200E_202D_200F_202E_200C_200D_206E_206A_206B_202A_200C_206A_206A_202E(Material P_0, string P_1)
	{
		return P_0.HasProperty(P_1);
	}

	static string _202C_206B_202E_202C_202B_200E_206C_200D_206C_206D_206C_200B_200E_202E_202A_202A_202B_200C_206E_206E_206C_202A_202B_206C_200E_202D_200F_202B_206A_206F_200D_200C_202E_206B_200F_206D_202A_200F_202A_206B_202E(Material P_0, string P_1, bool P_2)
	{
		return P_0.GetTag(P_1, P_2);
	}

	static string _202C_200D_200F_202D_200E_206C_206C_206C_206F_206E_202D_202E_206B_206E_202E_200B_202B_202E_202A_202B_202D_206D_202B_202B_206A_202D_206B_206D_206E_202C_200D_202A_206F_206A_202E_200D_202C_206C_202E_206C_202E(Material P_0, string P_1, bool P_2, string P_3)
	{
		return P_0.GetTag(P_1, P_2, P_3);
	}

	static void _206E_200C_202B_206B_206C_202C_200C_206D_200B_206B_206F_202C_206B_206D_200F_202C_200E_200C_206D_200F_200C_200D_206F_206F_200F_200F_206B_202E_200F_202A_202C_206A_206C_206C_200D_206B_202C_206E_200E_206D_202E(Material P_0, string P_1, string P_2)
	{
		P_0.SetOverrideTag(P_1, P_2);
	}

	static void _206B_202A_206F_206E_200C_200E_206C_202E_202E_202B_202B_202C_200E_206F_202A_202D_202C_206A_200D_202A_206F_206B_202D_202B_202D_206D_200D_202B_202E_202C_200D_206A_206E_206B_200E_206A_206B_206D_200D_202E(Material P_0, Material P_1, Material P_2, float P_3)
	{
		P_0.Lerp(P_1, P_2, P_3);
	}

	static bool _202B_200C_202E_200B_202A_200D_200D_206E_206D_206F_206B_200E_206A_206A_202C_202A_200D_200D_206A_206F_202B_206E_206B_202A_206C_200C_202D_202E_206D_206D_206F_200B_202B_206F_206A_206B_202A_200E_200D_202C_202E(Material P_0, int P_1)
	{
		return P_0.SetPass(P_1);
	}

	static void _206C_200B_200C_206F_200D_202E_206E_202C_202C_206C_200B_200D_200D_200C_202D_202B_202E_200D_200B_206B_202E_206C_202E_206B_200E_200E_206A_206E_202C_200C_206A_206B_202B_200C_200F_206F_200B_206F_206C_200E_202E(Material P_0, Material P_1)
	{
		P_0.CopyPropertiesFromMaterial(P_1);
	}

	static void _202E_206A_200D_200E_200F_206D_200C_206D_206C_200D_202D_200B_202A_202C_200B_206D_202D_206B_200D_206A_202B_206C_202E_206C_202B_206F_202E_202B_206C_200F_202A_200C_202D_202E_206E_200D_206F_200E_206C_200F_202E(Material P_0, string P_1)
	{
		P_0.EnableKeyword(P_1);
	}

	static void _200F_200B_206D_202A_206B_206C_200D_206F_200B_202D_202B_202C_202A_206F_200B_206E_206F_202A_200E_202E_202D_206E_206E_206A_202A_200B_200B_200F_200B_206A_206C_206D_206C_206A_202C_206A_206F_202B_202B_202E(Material P_0, string P_1)
	{
		P_0.DisableKeyword(P_1);
	}

	static bool _206F_206D_206A_202A_200E_200B_206E_206A_202D_206F_206B_200D_202E_200E_200D_206A_206A_200F_202E_200C_202A_202D_206D_202D_206F_206F_200D_206B_202B_200F_202A_200D_200D_202A_202B_202E_202A_206F_206A_206C_202E(Material P_0, string P_1)
	{
		return P_0.IsKeywordEnabled(P_1);
	}
}
