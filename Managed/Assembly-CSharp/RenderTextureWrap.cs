using System;
using LuaInterface;
using UnityEngine;

public class RenderTextureWrap
{
	private static Type classType = _200B_202E_206F_206D_202D_206A_206B_202B_202D_200C_206A_202A_206C_202E_202C_202C_206C_200E_202A_206A_206D_200C_200C_200D_206C_200D_206C_206E_202B_202B_206D_206F_206D_206D_206F_202B_202E_200D_202B_202E(typeof(RenderTexture).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[13]
		{
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(524075491u), GetTemporary),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1297063566u), ReleaseTemporary),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(974578644u), Create),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3403599231u), Release),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3264554145u), IsCreated),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3459247341u), DiscardContents),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(29136097u), MarkRestoreExpected),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3133180478u), SetGlobalShaderProperty),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(182905766u), GetTexelOffset),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1091261570u), SupportsStencil),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2705981273u), _200F_202B_206F_206F_200F_202C_206A_200C_206A_206C_200D_206D_206F_206E_200C_206F_202E_202C_200B_200B_206C_200E_200D_200F_206F_206C_200F_200D_206A_206E_202E_202D_206B_206B_202A_200D_206A_202C_206E_206E_202E),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(215375861u), GetClassType),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(60698966u), Lua_Eq)
		};
		LuaField[] fields = default(LuaField[]);
		while (true)
		{
			int num = 243870429;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x48B64308)) % 4)
				{
				case 3u:
					break;
				default:
					return;
				case 1u:
					fields = new LuaField[16]
					{
						new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1062086678u), get_width, set_width),
						new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2090464212u), get_height, set_height),
						new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(506514656u), get_depth, set_depth),
						new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3015541421u), get_isPowerOfTwo, set_isPowerOfTwo),
						new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(456597191u), get_sRGB, null),
						new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1277736624u), get_format, set_format),
						new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(596417306u), get_useMipMap, set_useMipMap),
						new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3494376486u), get_generateMips, set_generateMips),
						new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3860350717u), get_isCubemap, set_isCubemap),
						new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3533743182u), get_isVolume, set_isVolume),
						new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3571478675u), get_volumeDepth, set_volumeDepth),
						new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2144408847u), get_antiAliasing, set_antiAliasing),
						new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1928979553u), get_enableRandomWrite, set_enableRandomWrite),
						new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1851367991u), get_colorBuffer, null),
						new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1484883076u), get_depthBuffer, null),
						new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3797891633u), get_active, set_active)
					};
					num = ((int)num2 * -1245442441) ^ -58796251;
					continue;
				case 2u:
					LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2839312167u), _200B_202E_206F_206D_202D_206A_206B_202B_202D_200C_206A_202A_206C_202E_202C_202C_206C_200E_202A_206A_206D_200C_200C_200D_206C_200D_206C_206E_202B_202B_206D_206F_206D_206D_206F_202B_202E_200D_202B_202E(typeof(RenderTexture).TypeHandle), regs, fields, _200B_202E_206F_206D_202D_206A_206B_202B_202D_200C_206A_202A_206C_202E_202C_202C_206C_200E_202A_206A_206D_200C_200C_200D_206C_200D_206C_206E_202B_202B_206D_206F_206D_206D_206F_202B_202E_200D_202B_202E(typeof(Texture).TypeHandle));
					num = ((int)num2 * -395445026) ^ 0x2C3A9BA8;
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _200F_202B_206F_206F_200F_202C_206A_200C_206A_206C_200D_206D_206F_206E_200C_206F_202E_202C_200B_200B_206C_200E_200D_200F_206F_206C_200F_200D_206A_206E_202E_202D_206B_206B_202A_200D_206A_202C_206E_206E_202E(IntPtr P_0)
	{
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		int num = LuaDLL.lua_gettop(P_0);
		if (num == 3)
		{
			goto IL_000e;
		}
		goto IL_0161;
		IL_000e:
		int num2 = 575132592;
		goto IL_0013;
		IL_0013:
		int num5 = default(int);
		int num12 = default(int);
		int num11 = default(int);
		int num9 = default(int);
		int num10 = default(int);
		int num8 = default(int);
		int num7 = default(int);
		RenderTextureFormat val2 = default(RenderTextureFormat);
		RenderTextureReadWrite val3 = default(RenderTextureReadWrite);
		int num6 = default(int);
		int num4 = default(int);
		RenderTexture obj = default(RenderTexture);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ 0x1E050A46)) % 20)
			{
			case 17u:
				break;
			case 18u:
				goto IL_0079;
			case 11u:
				num5 = (int)LuaScriptMgr.GetNumber(P_0, 2);
				num2 = (int)((num3 * 1652676819) ^ 0xD12BE43);
				continue;
			case 7u:
				num12 = (int)LuaScriptMgr.GetNumber(P_0, 3);
				num2 = ((int)num3 * -598852549) ^ 0x147B54FA;
				continue;
			case 8u:
				num11 = (int)LuaScriptMgr.GetNumber(P_0, 1);
				num2 = (int)(num3 * 2137404679) ^ -1780514552;
				continue;
			case 4u:
				return 1;
			case 13u:
			{
				RenderTexture obj3 = _200F_200B_200C_202A_202B_200F_206A_206F_206F_202B_206D_200E_206C_206C_206F_206C_200B_206F_200D_200B_202C_200F_202E_202A_202A_200B_206F_200D_202B_200B_206E_206C_206C_200E_206A_200D_202A_202C_202B_206C_202E(num9, num10, num12);
				LuaScriptMgr.Push(P_0, (Object)(object)obj3);
				return 1;
			}
			case 10u:
			{
				RenderTexture obj2 = _200B_206F_200C_206A_202B_206C_206A_206B_206E_200D_206B_200D_202E_202D_200D_200C_202B_206E_206B_202D_202D_202C_202D_200D_200B_200D_206C_202E_202B_200F_200F_202E_200C_206A_200D_202A_200C_206F_206D_202A_202E(num11, num8, num7, val2, val3);
				LuaScriptMgr.Push(P_0, (Object)(object)obj2);
				num2 = ((int)num3 * -1801701597) ^ 0x417EB267;
				continue;
			}
			case 3u:
				return 1;
			case 15u:
				goto IL_0161;
			case 6u:
				num10 = (int)LuaScriptMgr.GetNumber(P_0, 2);
				num2 = (int)(num3 * 1196073456) ^ -1661080619;
				continue;
			case 12u:
				num6 = (int)LuaScriptMgr.GetNumber(P_0, 3);
				num2 = (int)(num3 * 236587854) ^ -345680921;
				continue;
			case 14u:
				num9 = (int)LuaScriptMgr.GetNumber(P_0, 1);
				num2 = ((int)num3 * -1038102896) ^ -1229105784;
				continue;
			case 5u:
				num4 = (int)LuaScriptMgr.GetNumber(P_0, 1);
				num2 = ((int)num3 * -2059249899) ^ -2094576788;
				continue;
			case 16u:
				LuaDLL.luaL_error(P_0, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2898601721u));
				num2 = 474803829;
				continue;
			case 0u:
				LuaScriptMgr.Push(P_0, (Object)(object)obj);
				num2 = ((int)num3 * -874208338) ^ 0x2503012;
				continue;
			case 2u:
				num8 = (int)LuaScriptMgr.GetNumber(P_0, 2);
				num2 = ((int)num3 * -479798271) ^ 0x6D3A259D;
				continue;
			case 1u:
				num7 = (int)LuaScriptMgr.GetNumber(P_0, 3);
				val2 = (RenderTextureFormat)(int)LuaScriptMgr.GetNetObject(P_0, 4, _200B_202E_206F_206D_202D_206A_206B_202B_202D_200C_206A_202A_206C_202E_202C_202C_206C_200E_202A_206A_206D_200C_200C_200D_206C_200D_206C_206E_202B_202B_206D_206F_206D_206D_206F_202B_202E_200D_202B_202E(typeof(RenderTextureFormat).TypeHandle));
				val3 = (RenderTextureReadWrite)(int)LuaScriptMgr.GetNetObject(P_0, 5, _200B_202E_206F_206D_202D_206A_206B_202B_202D_200C_206A_202A_206C_202E_202C_202C_206C_200E_202A_206A_206D_200C_200C_200D_206C_200D_206C_206E_202B_202B_206D_206F_206D_206D_206F_202B_202E_200D_202B_202E(typeof(RenderTextureReadWrite).TypeHandle));
				num2 = ((int)num3 * -1902997531) ^ -208234911;
				continue;
			case 9u:
			{
				RenderTextureFormat val = (RenderTextureFormat)(int)LuaScriptMgr.GetNetObject(P_0, 4, _200B_202E_206F_206D_202D_206A_206B_202B_202D_200C_206A_202A_206C_202E_202C_202C_206C_200E_202A_206A_206D_200C_200C_200D_206C_200D_206C_206E_202B_202B_206D_206F_206D_206D_206F_202B_202E_200D_202B_202E(typeof(RenderTextureFormat).TypeHandle));
				obj = _202A_200C_206A_200E_200C_206A_200F_200F_202B_202E_200D_206D_200B_206A_206A_206C_200E_206B_206B_200B_200B_200F_202E_202E_200C_200B_206D_206A_202A_202A_206A_200C_202B_200C_202E_200C_200B_206A_202A_202E_202E(num4, num5, num6, val);
				num2 = (int)((num3 * 39841090) ^ 0x2665EFB4);
				continue;
			}
			default:
				return 0;
			}
			break;
			IL_0079:
			int num13;
			if (num == 5)
			{
				num2 = 100498782;
				num13 = num2;
			}
			else
			{
				num2 = 1328948118;
				num13 = num2;
			}
		}
		goto IL_000e;
		IL_0161:
		int num14;
		if (num == 4)
		{
			num2 = 1254484767;
			num14 = num2;
		}
		else
		{
			num2 = 1998882200;
			num14 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_width(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		RenderTexture val = (RenderTexture)luaObject;
		while (true)
		{
			int num = -1256392419;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -631356206)) % 8)
				{
				case 6u:
					break;
				case 7u:
				{
					int num5;
					int num6;
					if (_200F_202B_200F_206F_200B_202C_200C_200B_200C_206E_206B_200B_200D_206C_200F_206F_206A_206A_200F_200F_200B_206B_206A_200B_200D_206E_200E_200C_200F_200D_202B_206A_206C_206B_206E_200F_206E_206E_206F_202E((Object)(object)val, (Object)null))
					{
						num5 = -1096677093;
						num6 = num5;
					}
					else
					{
						num5 = -1196052062;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1183539516);
					continue;
				}
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1643482095u));
					num = -1103013338;
					continue;
				case 5u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 24254033;
						num4 = num3;
					}
					else
					{
						num3 = 1171744619;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 2139793066);
					continue;
				}
				case 0u:
					num = (int)((num2 * 236169912) ^ 0x14DEDA66);
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3041692372u));
					num = (int)((num2 * 1107734386) ^ 0x5155D1EC);
					continue;
				case 4u:
					LuaScriptMgr.Push(L, _206D_206C_206A_202C_202B_200C_206A_206F_206D_202D_206D_200D_206C_202A_200C_206E_202D_206F_200E_202E_200D_202E_202B_202B_200C_200D_200D_202B_200D_202C_206D_200B_200F_206F_206F_200D_206F_202A_206E_200C_202E(val));
					num = -483479584;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_height(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		RenderTexture val = default(RenderTexture);
		while (true)
		{
			int num = 784184292;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x97B3679)) % 7)
				{
				case 2u:
					break;
				case 4u:
				{
					val = (RenderTexture)luaObject;
					int num5;
					int num6;
					if (_200F_202B_200F_206F_200B_202C_200C_200B_200C_206E_206B_200B_200D_206C_200F_206F_206A_206A_200F_200F_200B_206B_206A_200B_200D_206E_200E_200C_200F_200D_202B_206A_206C_206B_206E_200F_206E_206E_206F_202E((Object)(object)val, (Object)null))
					{
						num5 = 299382931;
						num6 = num5;
					}
					else
					{
						num5 = 1900630840;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1174702222);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3158219035u));
					num = ((int)num2 * -1906124400) ^ 0x259E5080;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1332601413u));
					num = 87763410;
					continue;
				case 3u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -1287564690;
						num4 = num3;
					}
					else
					{
						num3 = -1472089398;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 688108711);
					continue;
				}
				case 6u:
					num = ((int)num2 * -794864967) ^ -35486637;
					continue;
				default:
					LuaScriptMgr.Push(L, _200F_200D_202E_202B_206F_200F_202A_206A_200D_202D_206C_202B_206A_202D_206B_206E_200D_206D_202E_202A_202E_202A_200C_200E_200D_200E_206D_206C_202A_202D_200B_200F_206C_200D_206A_200F_202B_200D_200C_206A_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_depth(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		RenderTexture val = (RenderTexture)luaObject;
		if (_200F_202B_200F_206F_200B_202C_200C_200B_200C_206E_206B_200B_200D_206C_200F_206F_206A_206A_200F_200F_200B_206B_206A_200B_200D_206E_200E_200C_200F_200D_202B_206A_206C_206B_206E_200F_206E_206E_206F_202E((Object)(object)val, (Object)null))
		{
			goto IL_001b;
		}
		goto IL_009f;
		IL_001b:
		int num = -1842817670;
		goto IL_0020;
		IL_0020:
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -349809107)) % 8)
			{
			case 3u:
				break;
			case 2u:
				num = (int)(num2 * 605727722) ^ -854486916;
				continue;
			case 1u:
			{
				int num3;
				int num4;
				if (luaTypes == LuaTypes.LUA_TTABLE)
				{
					num3 = -1448596844;
					num4 = num3;
				}
				else
				{
					num3 = -1034692966;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 1734449359);
				continue;
			}
			case 6u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1284370568u));
				num = (int)((num2 * 805142302) ^ 0x76E19413);
				continue;
			case 5u:
				goto IL_009f;
			case 0u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3836972399u));
				num = -1897160392;
				continue;
			case 7u:
				luaTypes = LuaDLL.lua_type(L, 1);
				num = (int)((num2 * 1376034731) ^ 0x2EB32649);
				continue;
			default:
				return 1;
			}
			break;
		}
		goto IL_001b;
		IL_009f:
		LuaScriptMgr.Push(L, _202E_200E_200F_202A_206B_202E_206D_202E_206C_200F_202D_206A_200F_200B_206A_206B_206B_200C_206E_200D_206D_202C_202C_202B_206B_202B_202C_200D_202D_206F_206C_202A_206C_200B_206D_200F_202A_200E_200D_202C_202E(val));
		num = -703969567;
		goto IL_0020;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_isPowerOfTwo(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		RenderTexture val = (RenderTexture)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 456166391;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x434BDBB6)) % 8)
				{
				case 2u:
					break;
				case 1u:
				{
					int num5;
					int num6;
					if (_200F_202B_200F_206F_200B_202C_200C_200B_200C_206E_206B_200B_200D_206C_200F_206F_206A_206A_200F_200F_200B_206B_206A_200B_200D_206E_200E_200C_200F_200D_202B_206A_206C_206B_206E_200F_206E_206E_206F_202E((Object)(object)val, (Object)null))
					{
						num5 = -1508370429;
						num6 = num5;
					}
					else
					{
						num5 = -2145629300;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 309564361);
					continue;
				}
				case 3u:
					LuaScriptMgr.Push(L, _200F_200B_206B_200F_206A_206F_202D_202C_200F_202C_200F_206B_206E_202C_202A_200E_200F_206A_206E_200C_202E_206A_200C_200B_202A_202D_200D_206E_200E_202E_200E_206B_202D_206C_200E_200C_200E_206B_202D_200C_202E(val));
					num = 1659612891;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(867366475u));
					num = 1728454021;
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -841943642;
						num4 = num3;
					}
					else
					{
						num3 = -285331064;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1786246878);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(500829311u));
					num = ((int)num2 * -118555590) ^ -1867825783;
					continue;
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -729990438) ^ 0x657DC809;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_sRGB(IntPtr L)
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		RenderTexture val = default(RenderTexture);
		while (true)
		{
			int num = 1894729993;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2233E81)) % 9)
				{
				case 0u:
					break;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(367590173u));
					num = 250973961;
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -869642467;
						num6 = num5;
					}
					else
					{
						num5 = -2014214636;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 795658875);
					continue;
				}
				case 2u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 1306538873) ^ 0x1D55AD5F);
					continue;
				case 4u:
					num = (int)(num2 * 812508124) ^ -1103893767;
					continue;
				case 3u:
				{
					val = (RenderTexture)luaObject;
					int num3;
					int num4;
					if (_200F_202B_200F_206F_200B_202C_200C_200B_200C_206E_206B_200B_200D_206C_200F_206F_206A_206A_200F_200F_200B_206B_206A_200B_200D_206E_200E_200C_200F_200D_202B_206A_206C_206B_206E_200F_206E_206E_206F_202E((Object)(object)val, (Object)null))
					{
						num3 = 1364826544;
						num4 = num3;
					}
					else
					{
						num3 = 878968993;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -2024842427);
					continue;
				}
				case 5u:
					LuaScriptMgr.Push(L, _200D_200E_200C_202E_202D_202A_200C_206A_200C_202E_206A_206B_200F_202D_206D_200F_202C_202D_206A_206E_200F_206C_206E_200D_200E_200F_206E_206F_206C_206F_206E_206B_206C_206A_206E_206F_206A_202B_206D_206B_202E(val));
					num = 291484977;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1382820081u));
					num = (int)(num2 * 1442939366) ^ -222475995;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_format(IntPtr L)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		RenderTexture val = default(RenderTexture);
		while (true)
		{
			int num = 1369438962;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6D447509)) % 7)
				{
				case 0u:
					break;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(756508822u));
					num = 294117262;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (_200F_202B_200F_206F_200B_202C_200C_200B_200C_206E_206B_200B_200D_206C_200F_206F_206A_206A_200F_200F_200B_206B_206A_200B_200D_206E_200E_200C_200F_200D_202B_206A_206C_206B_206E_200F_206E_206E_206F_202E((Object)(object)val, (Object)null))
					{
						num5 = -1254629038;
						num6 = num5;
					}
					else
					{
						num5 = -1336870879;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -728260841);
					continue;
				}
				case 5u:
					val = (RenderTexture)luaObject;
					num = (int)((num2 * 85762921) ^ 0x189070D3);
					continue;
				case 2u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -422909994;
						num4 = num3;
					}
					else
					{
						num3 = -1564468911;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1038039753);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(725309044u));
					num = (int)((num2 * 1069900877) ^ 0x5297BD01);
					continue;
				default:
					LuaScriptMgr.Push(L, (Enum)(object)_202D_206D_206D_206D_200C_206B_206C_200D_200E_206D_206A_200D_202D_200B_202C_206A_202D_206C_202C_200B_200F_200C_206E_202E_206E_202A_202D_206F_202D_200F_206C_200E_206D_200D_202A_206A_206A_206F_200F_200C_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_useMipMap(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		RenderTexture val = (RenderTexture)luaObject;
		while (true)
		{
			int num = -432102974;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1789409315)) % 8)
				{
				case 3u:
					break;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3391193203u));
					num = -1418434733;
					continue;
				case 1u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 1025174448;
						num6 = num5;
					}
					else
					{
						num5 = 1877245076;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1669614443);
					continue;
				}
				case 5u:
					num = ((int)num2 * -1970648781) ^ -934591108;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1666994025u));
					num = (int)((num2 * 366627653) ^ 0x7C8AFFAC);
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (_200F_202B_200F_206F_200B_202C_200C_200B_200C_206E_206B_200B_200D_206C_200F_206F_206A_206A_200F_200F_200B_206B_206A_200B_200D_206E_200E_200C_200F_200D_202B_206A_206C_206B_206E_200F_206E_206E_206F_202E((Object)(object)val, (Object)null))
					{
						num3 = 767694501;
						num4 = num3;
					}
					else
					{
						num3 = 184076674;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 680258831);
					continue;
				}
				case 6u:
					LuaScriptMgr.Push(L, _206D_200C_200E_202C_206C_202C_206E_202B_206B_206B_200F_206C_200B_206B_200E_202D_206F_200E_202E_202A_200D_202E_206F_202D_200E_206B_200E_202E_200D_202C_200B_206A_206E_206D_202B_200D_206A_202A_206E_206C_202E(val));
					num = -1000057969;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_generateMips(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		RenderTexture val = default(RenderTexture);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1978142447;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -744853346)) % 8)
				{
				case 6u:
					break;
				case 7u:
				{
					val = (RenderTexture)luaObject;
					int num5;
					int num6;
					if (_200F_202B_200F_206F_200B_202C_200C_200B_200C_206E_206B_200B_200D_206C_200F_206F_206A_206A_200F_200F_200B_206B_206A_200B_200D_206E_200E_200C_200F_200D_202B_206A_206C_206B_206E_200F_206E_206E_206F_202E((Object)(object)val, (Object)null))
					{
						num5 = 1284590533;
						num6 = num5;
					}
					else
					{
						num5 = 1860848026;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 2000508393);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(349242478u));
					num = -1157091395;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -1996473973;
						num4 = num3;
					}
					else
					{
						num3 = -105923801;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1556423723);
					continue;
				}
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 74881189) ^ 0x2BA2B6AA);
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1658447649u));
					num = ((int)num2 * -191767346) ^ 0x6EB3C53;
					continue;
				case 3u:
					LuaScriptMgr.Push(L, _202C_200F_202B_200E_202C_206D_206B_200B_206C_200E_202C_206A_206D_200D_202B_200D_206C_200F_206F_200F_200D_206E_206F_206F_202C_206F_200E_206D_206C_206F_200C_206B_202D_202C_200B_200D_202A_206C_202A_202C_202E(val));
					num = -479621812;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_isCubemap(IntPtr L)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		RenderTexture val = default(RenderTexture);
		while (true)
		{
			int num = -1023978677;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -157350793)) % 8)
				{
				case 0u:
					break;
				case 3u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 1817452329;
						num6 = num5;
					}
					else
					{
						num5 = 385793314;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1402539653);
					continue;
				}
				case 7u:
					num = ((int)num2 * -662576008) ^ 0x3DFC7D31;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(727277453u));
					num = -1895177351;
					continue;
				case 5u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -2092721060) ^ 0x1A0014C0;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(996757543u));
					num = (int)(num2 * 216732471) ^ -1900924273;
					continue;
				case 4u:
				{
					val = (RenderTexture)luaObject;
					int num3;
					int num4;
					if (_200F_202B_200F_206F_200B_202C_200C_200B_200C_206E_206B_200B_200D_206C_200F_206F_206A_206A_200F_200F_200B_206B_206A_200B_200D_206E_200E_200C_200F_200D_202B_206A_206C_206B_206E_200F_206E_206E_206F_202E((Object)(object)val, (Object)null))
					{
						num3 = -850912558;
						num4 = num3;
					}
					else
					{
						num3 = -212751231;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1026558370);
					continue;
				}
				default:
					LuaScriptMgr.Push(L, _200E_200C_200B_200E_200D_200F_202B_200C_202B_206B_206E_202C_200F_200F_206B_206B_202C_206A_206D_202A_200D_206F_202C_202A_200E_202A_202E_200B_202E_200C_206F_202E_206C_200E_202E_206B_200B_206A_206A_202C_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_isVolume(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		RenderTexture val = (RenderTexture)luaObject;
		while (true)
		{
			int num = 823952311;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1EFCB41)) % 8)
				{
				case 5u:
					break;
				case 7u:
					num = ((int)num2 * -1444852933) ^ -564835681;
					continue;
				case 1u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -383701557;
						num6 = num5;
					}
					else
					{
						num5 = -311334801;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 982988746);
					continue;
				}
				case 6u:
				{
					int num3;
					int num4;
					if (_200F_202B_200F_206F_200B_202C_200C_200B_200C_206E_206B_200B_200D_206C_200F_206F_206A_206A_200F_200F_200B_206B_206A_200B_200D_206E_200E_200C_200F_200D_202B_206A_206C_206B_206E_200F_206E_206E_206F_202E((Object)(object)val, (Object)null))
					{
						num3 = -1054654796;
						num4 = num3;
					}
					else
					{
						num3 = -1448593026;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 790039514);
					continue;
				}
				case 3u:
					LuaScriptMgr.Push(L, _200F_206F_202D_206B_202E_200E_202B_202A_202E_202C_206D_202E_206F_200B_206B_200F_206C_200E_202E_200B_202D_202B_206B_206D_200F_200C_200B_206A_206A_202E_206F_200E_202C_200C_200B_202B_202D_206A_206C_202A_202E(val));
					num = 1109731899;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3821672334u));
					num = 1925220866;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1311357041u));
					num = (int)(num2 * 1465361838) ^ -2129477090;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_volumeDepth(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		RenderTexture val = (RenderTexture)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1648061988;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4910638)) % 9)
				{
				case 0u:
					break;
				case 8u:
				{
					int num5;
					int num6;
					if (_200F_202B_200F_206F_200B_202C_200C_200B_200C_206E_206B_200B_200D_206C_200F_206F_206A_206A_200F_200F_200B_206B_206A_200B_200D_206E_200E_200C_200F_200D_202B_206A_206C_206B_206E_200F_206E_206E_206F_202E((Object)(object)val, (Object)null))
					{
						num5 = 449863559;
						num6 = num5;
					}
					else
					{
						num5 = 1674846217;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1384044757);
					continue;
				}
				case 1u:
					num = (int)((num2 * 1890774868) ^ 0x22CB0D59);
					continue;
				case 5u:
					LuaScriptMgr.Push(L, _206C_200B_200D_200B_200C_202A_202B_200B_200F_200F_202C_200B_206C_202B_200E_206E_202E_206D_200C_200B_206E_206E_206C_200B_206C_206F_206E_200D_200F_202D_202C_202D_206C_200D_200E_202B_202E_206A_206B_206F_202E(val));
					num = 1852039919;
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -1083056979;
						num4 = num3;
					}
					else
					{
						num3 = -1270371849;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 183283363);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2264862703u));
					num = ((int)num2 * -2108937715) ^ -2114780326;
					continue;
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 222776426) ^ -473211890;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2367456139u));
					num = 180100933;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_antiAliasing(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		RenderTexture val = (RenderTexture)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -2081332430;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -634774328)) % 9)
				{
				case 8u:
					break;
				case 0u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 274591313;
						num6 = num5;
					}
					else
					{
						num5 = 777424986;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 158471132);
					continue;
				}
				case 2u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -271707479) ^ 0xE92231B;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (_200F_202B_200F_206F_200B_202C_200C_200B_200C_206E_206B_200B_200D_206C_200F_206F_206A_206A_200F_200F_200B_206B_206A_200B_200D_206E_200E_200C_200F_200D_202B_206A_206C_206B_206E_200F_206E_206E_206F_202E((Object)(object)val, (Object)null))
					{
						num3 = 416645038;
						num4 = num3;
					}
					else
					{
						num3 = 1677003679;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 252842507);
					continue;
				}
				case 5u:
					LuaScriptMgr.Push(L, _206B_206D_206C_206F_200C_200E_206C_202A_200B_202C_200F_206E_200F_202B_202E_202B_200E_206E_200C_206B_206F_202B_200D_206A_200D_200B_202C_206E_202C_202C_202A_200F_202E_206A_200B_202C_206B_202D_202C_206F_202E(val));
					num = -733742233;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1017495353u));
					num = -1829300191;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3686737532u));
					num = (int)(num2 * 132989832) ^ -1272900298;
					continue;
				case 7u:
					num = (int)((num2 * 1099985802) ^ 0x1C8DE7FD);
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_enableRandomWrite(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		RenderTexture val = (RenderTexture)luaObject;
		if (_200F_202B_200F_206F_200B_202C_200C_200B_200C_206E_206B_200B_200D_206C_200F_206F_206A_206A_200F_200F_200B_206B_206A_200B_200D_206E_200E_200C_200F_200D_202B_206A_206C_206B_206E_200F_206E_206E_206F_202E((Object)(object)val, (Object)null))
		{
			goto IL_0018;
		}
		goto IL_0064;
		IL_0018:
		int num = -552725589;
		goto IL_001d;
		IL_001d:
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1324230175)) % 7)
			{
			case 2u:
				break;
			case 6u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1763384654u));
				num = -1299027630;
				continue;
			case 0u:
				goto IL_0064;
			case 3u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(772169445u));
				num = ((int)num2 * -1462048200) ^ 0x1D75ACFA;
				continue;
			case 4u:
				luaTypes = LuaDLL.lua_type(L, 1);
				num = ((int)num2 * -1900612700) ^ 0x5D077110;
				continue;
			case 5u:
			{
				int num3;
				int num4;
				if (luaTypes != LuaTypes.LUA_TTABLE)
				{
					num3 = -1758477107;
					num4 = num3;
				}
				else
				{
					num3 = -776296284;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 734758998);
				continue;
			}
			default:
				return 1;
			}
			break;
		}
		goto IL_0018;
		IL_0064:
		LuaScriptMgr.Push(L, _206C_202A_200F_206B_200E_202E_200B_206D_200D_206B_206A_206D_200E_200B_202E_200C_206B_200F_202A_206C_206A_200B_206A_200F_202E_200B_206B_202D_206A_202B_206C_200E_206F_200E_200C_206B_200D_202B_206E_206F_202E(val));
		num = -653961741;
		goto IL_001d;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_colorBuffer(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		RenderTexture val = (RenderTexture)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 202105771;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1738271E)) % 7)
				{
				case 0u:
					break;
				case 5u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -2120772512;
						num6 = num5;
					}
					else
					{
						num5 = -1851370593;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -168114902);
					continue;
				}
				case 6u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 1376734087) ^ 0x3936049D);
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!_200F_202B_200F_206F_200B_202C_200C_200B_200C_206E_206B_200B_200D_206C_200F_206F_206A_206A_200F_200F_200B_206B_206A_200B_200D_206E_200E_200C_200F_200D_202B_206A_206C_206B_206E_200F_206E_206E_206F_202E((Object)(object)val, (Object)null))
					{
						num3 = -711265580;
						num4 = num3;
					}
					else
					{
						num3 = -1225607238;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1306127757);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1897162191u));
					num = 1030677915;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3007994529u));
					num = ((int)num2 * -1082626171) ^ -1341167199;
					continue;
				default:
					LuaScriptMgr.PushValue(L, _206F_200B_200E_200B_202E_206C_206B_206D_202D_202E_206A_206C_206B_200F_206C_206B_202D_200F_206D_206C_202B_202A_202B_200F_206E_200D_202E_206D_200D_202E_202C_200C_200D_202D_206E_202E_206E_202B_202B_206F_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_depthBuffer(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		RenderTexture val = default(RenderTexture);
		while (true)
		{
			int num = 463653761;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2F14F880)) % 8)
				{
				case 0u:
					break;
				case 1u:
				{
					val = (RenderTexture)luaObject;
					int num5;
					int num6;
					if (_200F_202B_200F_206F_200B_202C_200C_200B_200C_206E_206B_200B_200D_206C_200F_206F_206A_206A_200F_200F_200B_206B_206A_200B_200D_206E_200E_200C_200F_200D_202B_206A_206C_206B_206E_200F_206E_206E_206F_202E((Object)(object)val, (Object)null))
					{
						num5 = 172911612;
						num6 = num5;
					}
					else
					{
						num5 = 1833624489;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1964040142);
					continue;
				}
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(415192435u));
					num = ((int)num2 * -1043831939) ^ -68609391;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2861289907u));
					num = 1420817819;
					continue;
				case 2u:
					num = ((int)num2 * -1042477709) ^ 0xA458295;
					continue;
				case 3u:
					LuaScriptMgr.PushValue(L, _202D_200F_202D_206F_206E_200D_206A_202C_200F_206E_202A_202D_200C_202A_200D_206B_200B_202B_200F_200F_202E_202C_206B_202C_202A_200B_200C_206B_200E_206B_206E_200F_206F_200E_202C_200D_206B_202D_200C_206F_202E(val));
					num = 1296135380;
					continue;
				case 6u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 688009317;
						num4 = num3;
					}
					else
					{
						num3 = 2023629007;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -664951396);
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
	private static int get_active(IntPtr L)
	{
		LuaScriptMgr.Push(L, (Object)(object)_200E_202C_202C_206B_200C_206F_202E_206D_202E_202B_206E_206B_200C_200F_206B_200D_206E_206F_200F_200F_200B_206A_202E_206E_206F_200C_202D_200F_206D_200B_200B_206E_202E_206C_206E_202C_206B_200F_202D_200C_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_width(IntPtr L)
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		RenderTexture val = default(RenderTexture);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1634484075;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2946A4C8)) % 10)
				{
				case 3u:
					break;
				case 6u:
					_206A_206A_202B_202A_200B_206E_206B_200F_206C_200B_206D_200D_202B_202A_206A_200C_202C_202C_200F_200B_202B_202E_206F_206A_200E_206F_206A_202A_206D_202C_206B_206F_206B_200F_202E_200B_202C_200C_206A_206C_202E(val, (int)LuaScriptMgr.GetNumber(L, 3));
					num = 384230591;
					continue;
				case 0u:
				{
					int num5;
					int num6;
					if (_200F_202B_200F_206F_200B_202C_200C_200B_200C_206E_206B_200B_200D_206C_200F_206F_206A_206A_200F_200F_200B_206B_206A_200B_200D_206E_200E_200C_200F_200D_202B_206A_206C_206B_206E_200F_206E_206E_206F_202E((Object)(object)val, (Object)null))
					{
						num5 = -862007631;
						num6 = num5;
					}
					else
					{
						num5 = -1259326618;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1988099929);
					continue;
				}
				case 7u:
					val = (RenderTexture)luaObject;
					num = (int)(num2 * 85727078) ^ -820555600;
					continue;
				case 4u:
					num = (int)(num2 * 1861564020) ^ -98176016;
					continue;
				case 9u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 1368836955;
						num4 = num3;
					}
					else
					{
						num3 = 188651315;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1873953703);
					continue;
				}
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1080936137u));
					num = (int)((num2 * 2061163335) ^ 0x6E4DD81E);
					continue;
				case 5u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 1945889047) ^ 0x399695A2);
					continue;
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2411963921u));
					num = 531516512;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_height(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		RenderTexture val = (RenderTexture)luaObject;
		while (true)
		{
			int num = 1576781828;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2556697C)) % 7)
				{
				case 0u:
					break;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(194279523u));
					num = 620516562;
					continue;
				case 1u:
					num = (int)((num2 * 1632835335) ^ 0x4AC8DBC8);
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3158219035u));
					num = (int)((num2 * 157480699) ^ 0x76D83070);
					continue;
				case 6u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -235535128;
						num6 = num5;
					}
					else
					{
						num5 = -341610386;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -843826862);
					continue;
				}
				case 5u:
				{
					int num3;
					int num4;
					if (_200F_202B_200F_206F_200B_202C_200C_200B_200C_206E_206B_200B_200D_206C_200F_206F_206A_206A_200F_200F_200B_206B_206A_200B_200D_206E_200E_200C_200F_200D_202B_206A_206C_206B_206E_200F_206E_206E_206F_202E((Object)(object)val, (Object)null))
					{
						num3 = 2029662529;
						num4 = num3;
					}
					else
					{
						num3 = 1109111354;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -833617741);
					continue;
				}
				default:
					_200F_202A_200D_202A_200B_202D_200F_200F_206D_202C_202C_200F_200B_206F_202E_202B_206E_202D_202C_202D_200D_206B_206D_200B_206D_202D_202B_206E_206F_202C_206B_200D_200F_206F_206E_206D_200F_206F_206B_202C_202E(val, (int)LuaScriptMgr.GetNumber(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_depth(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		RenderTexture val = default(RenderTexture);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1954165038;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x42D714D8)) % 8)
				{
				case 3u:
					break;
				case 6u:
				{
					val = (RenderTexture)luaObject;
					int num5;
					int num6;
					if (!_200F_202B_200F_206F_200B_202C_200C_200B_200C_206E_206B_200B_200D_206C_200F_206F_206A_206A_200F_200F_200B_206B_206A_200B_200D_206E_200E_200C_200F_200D_202B_206A_206C_206B_206E_200F_206E_206E_206F_202E((Object)(object)val, (Object)null))
					{
						num5 = 771322183;
						num6 = num5;
					}
					else
					{
						num5 = 769719338;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 990595224);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4282593364u));
					num = (int)(num2 * 850330951) ^ -2060002100;
					continue;
				case 2u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -2115294617) ^ -695241229;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -1765389550;
						num4 = num3;
					}
					else
					{
						num3 = -92755009;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 649652663);
					continue;
				}
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3977329061u));
					num = 1358220119;
					continue;
				case 0u:
					num = ((int)num2 * -1669666202) ^ -622500473;
					continue;
				default:
					_206B_200D_202E_206C_200C_202A_206F_202C_200C_200D_200F_202C_200C_200F_200F_200B_200C_200F_202B_202B_206A_200F_206C_206E_202E_202C_206F_200C_200D_202D_200D_200C_202D_200E_206F_202A_200D_202E_206E_202B_202E(val, (int)LuaScriptMgr.GetNumber(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_isPowerOfTwo(IntPtr L)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		RenderTexture val = default(RenderTexture);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1017712243;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5D5E91F3)) % 9)
				{
				case 0u:
					break;
				case 7u:
					val = (RenderTexture)luaObject;
					num = ((int)num2 * -69157819) ^ 0x3FB90C3E;
					continue;
				case 8u:
					num = ((int)num2 * -1017429339) ^ -1285683050;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(161179993u));
					num = ((int)num2 * -509510786) ^ 0x55762E67;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (!_200F_202B_200F_206F_200B_202C_200C_200B_200C_206E_206B_200B_200D_206C_200F_206F_206A_206A_200F_200F_200B_206B_206A_200B_200D_206E_200E_200C_200F_200D_202B_206A_206C_206B_206E_200F_206E_206E_206F_202E((Object)(object)val, (Object)null))
					{
						num5 = 147361119;
						num6 = num5;
					}
					else
					{
						num5 = 1287986778;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1654923941);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2864789837u));
					num = 247252734;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 542299084;
						num4 = num3;
					}
					else
					{
						num3 = 178673166;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1578015127);
					continue;
				}
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 1055050333) ^ -1400304706;
					continue;
				default:
					_200F_202B_202E_206D_202A_200B_200E_206A_200B_206A_202A_202C_200E_206E_202A_200E_202C_206C_200F_202B_202E_200B_206B_206E_206A_206A_206D_200F_206E_206D_206B_200D_200C_202B_200B_206C_206A_200C_206B_206A_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_format(IntPtr L)
	{
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		RenderTexture val = default(RenderTexture);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 631365418;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x675E734F)) % 10)
				{
				case 6u:
					break;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1656647788u));
					num = 852092477;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(725309044u));
					num = (int)(num2 * 798101933) ^ -267888429;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (!_200F_202B_200F_206F_200B_202C_200C_200B_200C_206E_206B_200B_200D_206C_200F_206F_206A_206A_200F_200F_200B_206B_206A_200B_200D_206E_200E_200C_200F_200D_202B_206A_206C_206B_206E_200F_206E_206E_206F_202E((Object)(object)val, (Object)null))
					{
						num5 = -730332126;
						num6 = num5;
					}
					else
					{
						num5 = -1277487842;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1058487321);
					continue;
				}
				case 7u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 1979463261;
						num4 = num3;
					}
					else
					{
						num3 = 1852931394;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1542931664);
					continue;
				}
				case 4u:
					_206A_200F_206B_206B_202D_202B_206C_200C_200B_206C_202C_206E_202E_206E_202C_200E_202B_202E_200E_202B_206F_202A_202A_206D_206A_206A_202B_200E_206A_206B_202B_206F_200B_200E_206B_206D_202C_206C_202D_206F_202E(val, (RenderTextureFormat)(int)LuaScriptMgr.GetNetObject(L, 3, _200B_202E_206F_206D_202D_206A_206B_202B_202D_200C_206A_202A_206C_202E_202C_202C_206C_200E_202A_206A_206D_200C_200C_200D_206C_200D_206C_206E_202B_202B_206D_206F_206D_206D_206F_202B_202E_200D_202B_202E(typeof(RenderTextureFormat).TypeHandle)));
					num = 1603165542;
					continue;
				case 8u:
					num = (int)(num2 * 741007328) ^ -1496202883;
					continue;
				case 9u:
					val = (RenderTexture)luaObject;
					num = ((int)num2 * -1376269544) ^ -1876682178;
					continue;
				case 2u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -159010716) ^ 0x342028DC;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_useMipMap(IntPtr L)
	{
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		RenderTexture val = default(RenderTexture);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -268570378;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1056646734)) % 9)
				{
				case 2u:
					break;
				case 6u:
					_206B_206D_206F_202C_202C_206A_202C_206B_200B_200F_200E_202C_200B_202D_206C_206F_206F_202A_206A_202D_200D_202A_206F_200C_200D_206E_202E_200B_206E_206E_202E_200C_202B_200C_206C_206E_206B_202A_202D_202A_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					num = -71405162;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3933714472u));
					num = -672127037;
					continue;
				case 1u:
					num = (int)(num2 * 1712723587) ^ -1607118677;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1666994025u));
					num = (int)((num2 * 2018221187) ^ 0x74F437C9);
					continue;
				case 5u:
				{
					val = (RenderTexture)luaObject;
					int num5;
					int num6;
					if (_200F_202B_200F_206F_200B_202C_200C_200B_200C_206E_206B_200B_200D_206C_200F_206F_206A_206A_200F_200F_200B_206B_206A_200B_200D_206E_200E_200C_200F_200D_202B_206A_206C_206B_206E_200F_206E_206E_206F_202E((Object)(object)val, (Object)null))
					{
						num5 = -895225179;
						num6 = num5;
					}
					else
					{
						num5 = -717140805;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1322162046);
					continue;
				}
				case 8u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -2105230458) ^ 0x343B0D75;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 517483597;
						num4 = num3;
					}
					else
					{
						num3 = 666101757;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1424146906);
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
	private static int set_generateMips(IntPtr L)
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		RenderTexture val = default(RenderTexture);
		while (true)
		{
			int num = -424503363;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1733398026)) % 8)
				{
				case 0u:
					break;
				case 2u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -624575908;
						num6 = num5;
					}
					else
					{
						num5 = -356030498;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -775748730);
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (!_200F_202B_200F_206F_200B_202C_200C_200B_200C_206E_206B_200B_200D_206C_200F_206F_206A_206A_200F_200F_200B_206B_206A_200B_200D_206E_200E_200C_200F_200D_202B_206A_206C_206B_206E_200F_206E_206E_206F_202E((Object)(object)val, (Object)null))
					{
						num3 = -1110137185;
						num4 = num3;
					}
					else
					{
						num3 = -1753786870;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -86386954);
					continue;
				}
				case 7u:
					_200D_206E_200F_200E_206D_206D_206F_200E_200D_202B_206A_200E_200C_206B_206D_202D_206F_206B_206D_206F_202E_202A_202A_200C_206D_200B_202A_202B_200B_206C_202C_206B_206B_206D_206A_206D_200E_202C_200B_202C_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					num = -1625171037;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2075554127u));
					num = -202956295;
					continue;
				case 3u:
					val = (RenderTexture)luaObject;
					num = (int)((num2 * 1969930371) ^ 0x31BE7EBE);
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1533962166u));
					num = (int)(num2 * 643328425) ^ -236845217;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_isCubemap(IntPtr L)
	{
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		RenderTexture val = default(RenderTexture);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -2141554843;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -589242714)) % 10)
				{
				case 4u:
					break;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(534736629u));
					num = (int)(num2 * 1752864896) ^ -999523273;
					continue;
				case 9u:
					num = (int)(num2 * 1489078126) ^ -235124500;
					continue;
				case 2u:
					_206E_206A_200F_200F_206E_202B_200B_200D_206D_200D_206B_202C_202D_202C_202C_200C_206A_206E_200B_206C_202E_200E_200D_200E_200D_202B_202D_206B_200F_206E_206A_202A_200F_202A_206B_200C_200B_200D_202B_206B_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					num = -1743937259;
					continue;
				case 0u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 1602107485;
						num6 = num5;
					}
					else
					{
						num5 = 1688421434;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 582308581);
					continue;
				}
				case 3u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -2041615696) ^ 0x6E48B14E;
					continue;
				case 8u:
				{
					int num3;
					int num4;
					if (_200F_202B_200F_206F_200B_202C_200C_200B_200C_206E_206B_200B_200D_206C_200F_206F_206A_206A_200F_200F_200B_206B_206A_200B_200D_206E_200E_200C_200F_200D_202B_206A_206C_206B_206E_200F_206E_206E_206F_202E((Object)(object)val, (Object)null))
					{
						num3 = -477107127;
						num4 = num3;
					}
					else
					{
						num3 = -139147720;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 2004019077);
					continue;
				}
				case 7u:
					val = (RenderTexture)luaObject;
					num = ((int)num2 * -2067386877) ^ -652955715;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(727277453u));
					num = -1276333918;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_isVolume(IntPtr L)
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		RenderTexture val = default(RenderTexture);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 2033017749;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2C65446)) % 9)
				{
				case 8u:
					break;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2490644550u));
					num = ((int)num2 * -240144411) ^ 0x584139E9;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2909284188u));
					num = 1646740492;
					continue;
				case 3u:
					val = (RenderTexture)luaObject;
					num = ((int)num2 * -1230696309) ^ -85576156;
					continue;
				case 6u:
					num = ((int)num2 * -1275893225) ^ 0x34579BFB;
					continue;
				case 1u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1382428933) ^ -536681245;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 1260232187;
						num6 = num5;
					}
					else
					{
						num5 = 2048534192;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1269945188);
					continue;
				}
				case 7u:
				{
					int num3;
					int num4;
					if (_200F_202B_200F_206F_200B_202C_200C_200B_200C_206E_206B_200B_200D_206C_200F_206F_206A_206A_200F_200F_200B_206B_206A_200B_200D_206E_200E_200C_200F_200D_202B_206A_206C_206B_206E_200F_206E_206E_206F_202E((Object)(object)val, (Object)null))
					{
						num3 = -1585158134;
						num4 = num3;
					}
					else
					{
						num3 = -2094380481;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 110829249);
					continue;
				}
				default:
					_206D_206A_206C_200D_202B_200F_200E_206D_206C_206C_202C_202D_200B_202E_202C_200D_206D_206D_206B_200E_202C_206F_200F_206A_200D_202B_200B_202A_200F_200D_200E_206A_206A_206C_200D_200F_200E_200C_206A_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_volumeDepth(IntPtr L)
	{
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		RenderTexture val = default(RenderTexture);
		while (true)
		{
			int num = 535101715;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6BE3B21F)) % 10)
				{
				case 9u:
					break;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2100133562u));
					num = 1640330561;
					continue;
				case 7u:
					num = ((int)num2 * -242576885) ^ -1938216432;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4161291771u));
					num = ((int)num2 * -236495344) ^ 0xF9683DC;
					continue;
				case 2u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 1508801727) ^ 0x764EEB79);
					continue;
				case 8u:
					val = (RenderTexture)luaObject;
					num = ((int)num2 * -1564805074) ^ 0x571FA82;
					continue;
				case 6u:
					_206F_202C_206A_206B_200F_200C_200C_200C_202A_202C_206B_202C_206E_200B_202A_200C_200B_202A_202E_206F_206B_200F_206D_206D_200B_206A_202D_202E_200B_202A_200D_200C_200C_206B_206D_206F_200C_206E_202A_206F_202E(val, (int)LuaScriptMgr.GetNumber(L, 3));
					num = 90447227;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 835390796;
						num6 = num5;
					}
					else
					{
						num5 = 37106718;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1989247169);
					continue;
				}
				case 5u:
				{
					int num3;
					int num4;
					if (_200F_202B_200F_206F_200B_202C_200C_200B_200C_206E_206B_200B_200D_206C_200F_206F_206A_206A_200F_200F_200B_206B_206A_200B_200D_206E_200E_200C_200F_200D_202B_206A_206C_206B_206E_200F_206E_206E_206F_202E((Object)(object)val, (Object)null))
					{
						num3 = -1123298319;
						num4 = num3;
					}
					else
					{
						num3 = -838347631;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1130466448);
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
	private static int set_antiAliasing(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		RenderTexture val = (RenderTexture)luaObject;
		while (true)
		{
			int num = -536499395;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -791433151)) % 7)
				{
				case 6u:
					break;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3510307371u));
					num = -1520962254;
					continue;
				case 2u:
					_200D_202D_202D_202E_206E_200F_206F_200B_202B_206D_202C_206B_200E_206A_206F_206C_206C_202D_202E_200B_202D_200B_202D_206E_206B_202D_200D_206A_200E_202A_202B_202D_200C_202E_202C_200D_202D_206A_200F_200E_202E(val, (int)LuaScriptMgr.GetNumber(L, 3));
					num = -1672780882;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(544301241u));
					num = ((int)num2 * -1489037418) ^ -2138402582;
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (!_200F_202B_200F_206F_200B_202C_200C_200B_200C_206E_206B_200B_200D_206C_200F_206F_206A_206A_200F_200F_200B_206B_206A_200B_200D_206E_200E_200C_200F_200D_202B_206A_206C_206B_206E_200F_206E_206E_206F_202E((Object)(object)val, (Object)null))
					{
						num5 = 1292853194;
						num6 = num5;
					}
					else
					{
						num5 = 773620444;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1245283074);
					continue;
				}
				case 4u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 2061154849;
						num4 = num3;
					}
					else
					{
						num3 = 2027936697;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -785401772);
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
	private static int set_enableRandomWrite(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		RenderTexture val = (RenderTexture)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1619906110;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -210658783)) % 7)
				{
				case 0u:
					break;
				case 3u:
				{
					int num5;
					int num6;
					if (_200F_202B_200F_206F_200B_202C_200C_200B_200C_206E_206B_200B_200D_206C_200F_206F_206A_206A_200F_200F_200B_206B_206A_200B_200D_206E_200E_200C_200F_200D_202B_206A_206C_206B_206E_200F_206E_206E_206F_202E((Object)(object)val, (Object)null))
					{
						num5 = 1560225100;
						num6 = num5;
					}
					else
					{
						num5 = 1613497800;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1696829862);
					continue;
				}
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3044637999u));
					num = (int)(num2 * 1173456362) ^ -2070196314;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(928051647u));
					num = -1307184634;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 1299654175;
						num4 = num3;
					}
					else
					{
						num3 = 1734810041;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -2032489458);
					continue;
				}
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1739523646) ^ -1299515013;
					continue;
				default:
					_200D_206F_200C_200B_206C_206B_200E_206F_202D_200E_206A_206C_200B_206B_200B_202E_202C_206A_202C_202B_200B_202B_200F_202B_202B_206C_206F_202E_200C_202A_206E_202D_206B_200C_202A_200F_200E_206B_206B_206C_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_active(IntPtr L)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		_200D_200B_202D_200F_206E_202D_206C_206B_200C_202D_206F_202B_202A_200F_206C_202E_206D_202E_206D_200D_206C_200E_200D_206D_206B_202A_202B_206C_200E_200B_200B_200B_200D_206C_206C_200D_202B_206E_202B_200F_202E((RenderTexture)LuaScriptMgr.GetUnityObject(L, 3, _200B_202E_206F_206D_202D_206A_206B_202B_202D_200C_206A_202A_206C_202E_202C_202C_206C_200E_202A_206A_206D_200C_200C_200D_206C_200D_206C_206E_202B_202B_206D_206F_206D_206D_206F_202B_202E_200D_202B_202E(typeof(RenderTexture).TypeHandle)));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetTemporary(IntPtr L)
	{
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		int num = LuaDLL.lua_gettop(L);
		if (num == 2)
		{
			goto IL_000e;
		}
		goto IL_03e7;
		IL_000e:
		int num2 = 257505899;
		goto IL_0013;
		IL_0013:
		RenderTexture obj5 = default(RenderTexture);
		int num18 = default(int);
		int num4 = default(int);
		RenderTexture obj4 = default(RenderTexture);
		int num16 = default(int);
		int num17 = default(int);
		RenderTextureFormat val4 = default(RenderTextureFormat);
		int num15 = default(int);
		RenderTexture obj = default(RenderTexture);
		int num8 = default(int);
		RenderTexture obj2 = default(RenderTexture);
		int num13 = default(int);
		int num14 = default(int);
		RenderTextureReadWrite val2 = default(RenderTextureReadWrite);
		int num11 = default(int);
		int num12 = default(int);
		int num10 = default(int);
		RenderTextureFormat val3 = default(RenderTextureFormat);
		RenderTextureReadWrite val = default(RenderTextureReadWrite);
		int num9 = default(int);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ 0x3E7CC1D0)) % 29)
			{
			case 7u:
				break;
			case 8u:
				return 1;
			case 0u:
				obj5 = _200D_200D_202D_200D_206C_200D_202E_200F_202B_200F_200B_202B_200D_206D_206A_200F_200F_206F_206C_206D_200E_206B_206F_200C_206A_202E_206D_206A_206A_202A_200B_206D_200E_200D_206A_202C_206B_200B_202C_202D_202E(num18, num4);
				num2 = ((int)num3 * -1629170311) ^ 0x6A22F10;
				continue;
			case 15u:
				goto IL_00cd;
			case 14u:
				LuaScriptMgr.Push(L, (Object)(object)obj4);
				return 1;
			case 1u:
				num16 = (int)LuaScriptMgr.GetNumber(L, 1);
				num2 = ((int)num3 * -455846727) ^ -404500755;
				continue;
			case 25u:
				num18 = (int)LuaScriptMgr.GetNumber(L, 1);
				num2 = ((int)num3 * -1145574023) ^ -2008684008;
				continue;
			case 10u:
				num17 = (int)LuaScriptMgr.GetNumber(L, 3);
				num2 = (int)((num3 * 1691750684) ^ 0x75FBBA24);
				continue;
			case 3u:
				val4 = (RenderTextureFormat)(int)LuaScriptMgr.GetNetObject(L, 4, _200B_202E_206F_206D_202D_206A_206B_202B_202D_200C_206A_202A_206C_202E_202C_202C_206C_200E_202A_206A_206D_200C_200C_200D_206C_200D_206C_206E_202B_202B_206D_206F_206D_206D_206F_202B_202E_200D_202B_202E(typeof(RenderTextureFormat).TypeHandle));
				num2 = (int)((num3 * 1095808219) ^ 0x15A687D);
				continue;
			case 20u:
				num15 = (int)LuaScriptMgr.GetNumber(L, 3);
				num2 = ((int)num3 * -1804230659) ^ -344779231;
				continue;
			case 17u:
			{
				RenderTextureFormat val5 = (RenderTextureFormat)(int)LuaScriptMgr.GetNetObject(L, 4, _200B_202E_206F_206D_202D_206A_206B_202B_202D_200C_206A_202A_206C_202E_202C_202C_206C_200E_202A_206A_206D_200C_200C_200D_206C_200D_206C_206E_202B_202B_206D_206F_206D_206D_206F_202B_202E_200D_202B_202E(typeof(RenderTextureFormat).TypeHandle));
				obj = _202B_206E_200C_200F_206B_202D_200D_206B_202E_202A_206C_206D_200C_202A_206F_200F_202E_200F_206D_202A_206A_202D_200B_200E_200C_206F_206F_200E_206C_206B_202D_200B_206D_202C_200D_206B_202B_202B_206B_200D_202E(num16, num8, num17, val5);
				num2 = ((int)num3 * -1451784761) ^ -643898343;
				continue;
			}
			case 19u:
				obj2 = _202C_200D_206D_206A_206A_202D_206E_200E_202E_206B_200B_200E_206A_200C_202D_206D_206D_206E_200E_202C_206A_200E_206D_200E_202C_202A_200F_200F_202D_206E_206B_202D_202E_206D_202B_200B_200B_202B_200D_200C_202E(num13, num14, num15, val4, val2);
				num2 = (int)(num3 * 177652613) ^ -317921458;
				continue;
			case 21u:
				goto IL_01fe;
			case 13u:
				LuaScriptMgr.Push(L, (Object)(object)obj5);
				return 1;
			case 11u:
				obj4 = _206A_206C_202C_202D_200E_206F_206B_200C_206D_200D_200C_206C_200B_200B_200F_202C_202E_200B_200D_206E_202C_206A_206C_206C_206F_202A_200C_200F_200E_206D_200D_202D_202E_202B_206D_206B_206D_202E_206E_202E(num11, num12, num10, val3, val, num9);
				num2 = (int)(num3 * 540385999) ^ -1347064286;
				continue;
			case 27u:
				num13 = (int)LuaScriptMgr.GetNumber(L, 1);
				num14 = (int)LuaScriptMgr.GetNumber(L, 2);
				num2 = (int)((num3 * 1481256697) ^ 0x3F38956D);
				continue;
			case 5u:
				num11 = (int)LuaScriptMgr.GetNumber(L, 1);
				num12 = (int)LuaScriptMgr.GetNumber(L, 2);
				num2 = ((int)num3 * -99973139) ^ -1576341702;
				continue;
			case 18u:
				num10 = (int)LuaScriptMgr.GetNumber(L, 3);
				val3 = (RenderTextureFormat)(int)LuaScriptMgr.GetNetObject(L, 4, _200B_202E_206F_206D_202D_206A_206B_202B_202D_200C_206A_202A_206C_202E_202C_202C_206C_200E_202A_206A_206D_200C_200C_200D_206C_200D_206C_206E_202B_202B_206D_206F_206D_206D_206F_202B_202E_200D_202B_202E(typeof(RenderTextureFormat).TypeHandle));
				num2 = (int)(num3 * 267604584) ^ -1185213526;
				continue;
			case 4u:
				num9 = (int)LuaScriptMgr.GetNumber(L, 6);
				num2 = (int)(num3 * 183791516) ^ -283545752;
				continue;
			case 22u:
				val2 = (RenderTextureReadWrite)(int)LuaScriptMgr.GetNetObject(L, 5, _200B_202E_206F_206D_202D_206A_206B_202B_202D_200C_206A_202A_206C_202E_202C_202C_206C_200E_202A_206A_206D_200C_200C_200D_206C_200D_206C_206E_202B_202B_206D_206F_206D_206D_206F_202B_202E_200D_202B_202E(typeof(RenderTextureReadWrite).TypeHandle));
				num2 = ((int)num3 * -2101277311) ^ -1015612603;
				continue;
			case 16u:
				goto IL_0323;
			case 24u:
				num8 = (int)LuaScriptMgr.GetNumber(L, 2);
				num2 = ((int)num3 * -1167518540) ^ -496227320;
				continue;
			case 12u:
				val = (RenderTextureReadWrite)(int)LuaScriptMgr.GetNetObject(L, 5, _200B_202E_206F_206D_202D_206A_206B_202B_202D_200C_206A_202A_206C_202E_202C_202C_206C_200E_202A_206A_206D_200C_200C_200D_206C_200D_206C_206E_202B_202B_206D_206F_206D_206D_206F_202B_202E_200D_202B_202E(typeof(RenderTextureReadWrite).TypeHandle));
				num2 = (int)(num3 * 288047769) ^ -320756395;
				continue;
			case 23u:
			{
				int num5 = (int)LuaScriptMgr.GetNumber(L, 1);
				int num6 = (int)LuaScriptMgr.GetNumber(L, 2);
				int num7 = (int)LuaScriptMgr.GetNumber(L, 3);
				RenderTexture obj3 = _206C_200C_206E_202B_202E_206D_206B_202E_206E_206C_202A_206C_200D_200D_202C_206D_206D_206C_206D_206B_200D_200D_200F_206E_200B_200E_206C_206A_200B_202E_202B_200F_202D_206A_202D_206C_200D_202A_200F_200C_202E(num5, num6, num7);
				LuaScriptMgr.Push(L, (Object)(object)obj3);
				return 1;
			}
			case 9u:
				num4 = (int)LuaScriptMgr.GetNumber(L, 2);
				num2 = ((int)num3 * -614265830) ^ -1495358997;
				continue;
			case 28u:
				goto IL_03e7;
			case 26u:
				LuaScriptMgr.Push(L, (Object)(object)obj2);
				return 1;
			case 6u:
				LuaScriptMgr.Push(L, (Object)(object)obj);
				num2 = (int)(num3 * 1018207979) ^ -1332749546;
				continue;
			default:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2312252614u));
				return 0;
			}
			break;
			IL_0323:
			int num19;
			if (num == 6)
			{
				num2 = 66716581;
				num19 = num2;
			}
			else
			{
				num2 = 669309165;
				num19 = num2;
			}
			continue;
			IL_01fe:
			int num20;
			if (num == 4)
			{
				num2 = 1352069573;
				num20 = num2;
			}
			else
			{
				num2 = 2044745835;
				num20 = num2;
			}
			continue;
			IL_00cd:
			int num21;
			if (num == 5)
			{
				num2 = 1619570760;
				num21 = num2;
			}
			else
			{
				num2 = 1727293982;
				num21 = num2;
			}
		}
		goto IL_000e;
		IL_03e7:
		int num22;
		if (num != 3)
		{
			num2 = 1030640035;
			num22 = num2;
		}
		else
		{
			num2 = 849557995;
			num22 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int ReleaseTemporary(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 1);
		RenderTexture val = default(RenderTexture);
		while (true)
		{
			int num = 319933332;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3B6BB8C2)) % 4)
				{
				case 0u:
					break;
				case 2u:
					val = (RenderTexture)LuaScriptMgr.GetUnityObject(L, 1, _200B_202E_206F_206D_202D_206A_206B_202B_202D_200C_206A_202A_206C_202E_202C_202C_206C_200E_202A_206A_206D_200C_200C_200D_206C_200D_206C_206E_202B_202B_206D_206F_206D_206D_206F_202B_202E_200D_202B_202E(typeof(RenderTexture).TypeHandle));
					num = ((int)num2 * -368764321) ^ 0x506DD531;
					continue;
				case 1u:
					_206D_202B_200B_202C_202E_202B_202C_200D_200D_202D_200E_200E_202B_200F_202A_206D_200D_206C_206D_206D_202E_206D_206E_206F_200E_200F_202D_202D_200D_206A_202B_206E_206A_206D_202B_202D_202A_202A_206E_206D_202E(val);
					num = (int)((num2 * 672878470) ^ 0x72DF5C3B);
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Create(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 1);
		RenderTexture val = (RenderTexture)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2593139851u));
		bool b = _202A_206F_200D_202A_200C_206D_206E_206F_206F_206A_206B_202C_206B_206D_206C_206E_206A_206B_202C_200E_200D_206A_202A_202A_202A_200D_206A_206C_202A_202A_202C_202A_202B_202A_200F_200D_206A_200E_206A_202A_202E(val);
		while (true)
		{
			int num = -1047500383;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -904027546)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0047;
				default:
					return 1;
				}
				break;
				IL_0047:
				LuaScriptMgr.Push(L, b);
				num = ((int)num2 * -1560090584) ^ 0x79522653;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Release(IntPtr L)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 1);
		while (true)
		{
			int num = -1296520166;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -62423178)) % 3)
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
				RenderTexture val = (RenderTexture)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1179983374u));
				_202E_202D_202B_206A_200D_202E_200E_206C_200D_200D_202B_200D_200B_206C_206C_200D_200C_200F_206A_206D_200E_202E_206D_202D_206B_206D_200D_202E_206F_202D_206C_200D_200E_200E_202A_202B_202B_206A_200C_206F_202E(val);
				num = ((int)num2 * -811278816) ^ -834283157;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int IsCreated(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 1);
		RenderTexture val = (RenderTexture)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1051686177u));
		bool b = _206A_202E_206E_206A_206C_202A_200F_202C_206C_200F_202E_200F_206A_200C_200F_206F_202B_202A_206A_200C_206C_202C_206D_200C_200E_200D_200B_200D_202D_202B_202E_206D_200D_200D_202C_206C_200C_202B_200B_206C_202E(val);
		while (true)
		{
			int num = -666154003;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -780338818)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0047;
				default:
					return 1;
				}
				break;
				IL_0047:
				LuaScriptMgr.Push(L, b);
				num = (int)((num2 * 1632670552) ^ 0x7B050330);
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int DiscardContents(IntPtr L)
	{
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		RenderTexture val2 = default(RenderTexture);
		bool boolean = default(bool);
		bool boolean2 = default(bool);
		RenderTexture val = default(RenderTexture);
		while (true)
		{
			int num2 = -2033781668;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1198884192)) % 9)
				{
				case 5u:
					break;
				case 7u:
					val2 = (RenderTexture)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4103883646u));
					boolean = LuaScriptMgr.GetBoolean(L, 2);
					boolean2 = LuaScriptMgr.GetBoolean(L, 3);
					num2 = (int)(num3 * 867457193) ^ -725735245;
					continue;
				case 8u:
					_206E_202B_206A_200C_206E_200E_206D_202E_206A_206E_206A_206D_200E_206C_202C_200D_200F_206F_202E_200F_202E_202B_206E_206B_202C_202A_200B_200D_206E_200F_206F_200F_206D_200C_206B_200F_206B_200B_202C_202E_202E(val2, boolean, boolean2);
					return 0;
				case 6u:
					val = (RenderTexture)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1179983374u));
					num2 = ((int)num3 * -327831423) ^ 0xAEAF17F;
					continue;
				case 2u:
					_200B_206F_206E_200C_206A_202D_200B_206D_202E_202B_206A_206D_200C_202D_206A_202A_200C_202A_202C_202E_200C_206F_200B_202B_202B_202A_206E_200B_202C_206C_202B_200B_200F_202B_200E_202C_200D_200E_202D_206B_202E(val);
					return 0;
				case 1u:
				{
					int num5;
					int num6;
					if (num != 1)
					{
						num5 = 120967387;
						num6 = num5;
					}
					else
					{
						num5 = 1215133405;
						num6 = num5;
					}
					num2 = num5 ^ ((int)num3 * -579673720);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1132166802u));
					num2 = -508021331;
					continue;
				case 0u:
				{
					int num4;
					if (num != 3)
					{
						num2 = -737360957;
						num4 = num2;
					}
					else
					{
						num2 = -272798054;
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
	private static int MarkRestoreExpected(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 1);
		RenderTexture val = (RenderTexture)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1179983374u));
		_206C_206B_200C_200E_206C_202A_202C_200B_200E_202A_200F_202B_206F_202D_206F_200C_206F_200D_202E_206C_206E_200F_202D_202C_200F_206F_206E_206C_200B_206B_200B_202B_206A_200E_200F_202A_200B_202C_206F_202E(val);
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SetGlobalShaderProperty(IntPtr L)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		RenderTexture val = default(RenderTexture);
		string luaString = default(string);
		while (true)
		{
			int num = 1059487194;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x36DB0832)) % 5)
				{
				case 4u:
					break;
				case 3u:
					_206D_200F_200D_200B_200E_200F_202E_202A_200C_206A_202E_202C_202C_206A_200B_206C_202B_206C_206A_206E_206A_202C_202E_200B_206A_200F_202D_200E_200D_200C_200B_206A_206D_202E_202B_202E_206D_202C_202C_200F_202E(val, luaString);
					num = ((int)num2 * -1444254138) ^ -1656918098;
					continue;
				case 0u:
					luaString = LuaScriptMgr.GetLuaString(L, 2);
					num = (int)((num2 * 198341033) ^ 0x6918EEC9);
					continue;
				case 1u:
					val = (RenderTexture)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1179983374u));
					num = ((int)num2 * -1047466122) ^ 0x6733F0DC;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetTexelOffset(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr.CheckArgsCount(L, 1);
		RenderTexture val = (RenderTexture)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1179983374u));
		Vector2 v = _200B_202D_202E_206D_202E_202D_206E_206B_202A_200D_206D_206E_206A_206F_202D_200C_202D_202E_202E_202E_202C_206A_200F_202B_202E_202C_206F_206D_202A_202B_206C_202C_202D_200E_202B_206D_200C_206D_202A_202D_202E(val);
		LuaScriptMgr.Push(L, v);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SupportsStencil(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 1);
		bool b = default(bool);
		while (true)
		{
			int num = -1909993352;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -209326933)) % 4)
				{
				case 0u:
					break;
				case 3u:
				{
					RenderTexture val = (RenderTexture)LuaScriptMgr.GetUnityObject(L, 1, _200B_202E_206F_206D_202D_206A_206B_202B_202D_200C_206A_202A_206C_202E_202C_202C_206C_200E_202A_206A_206D_200C_200C_200D_206C_200D_206C_206E_202B_202B_206D_206F_206D_206D_206F_202B_202E_200D_202B_202E(typeof(RenderTexture).TypeHandle));
					b = _200B_206F_206A_206D_206E_206F_200B_206F_206A_206D_206E_202C_200E_202C_202C_200E_206C_206E_200F_200E_200D_200D_200B_202C_202B_200D_206E_206A_202B_206F_200D_206C_202C_206F_202B_206F_200C_202A_202A_200E_202E(val);
					num = ((int)num2 * -764078760) ^ -1490227455;
					continue;
				}
				case 2u:
					LuaScriptMgr.Push(L, b);
					num = ((int)num2 * -857544682) ^ 0x7BF1B666;
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
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Object val = (Object)((luaObject is Object) ? luaObject : null);
		Object val2 = default(Object);
		bool b = default(bool);
		while (true)
		{
			int num = 1593061580;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4E771BD1)) % 5)
				{
				case 0u:
					break;
				case 4u:
				{
					object luaObject2 = LuaScriptMgr.GetLuaObject(L, 2);
					val2 = (Object)((luaObject2 is Object) ? luaObject2 : null);
					num = ((int)num2 * -440576312) ^ -1913821992;
					continue;
				}
				case 2u:
					LuaScriptMgr.Push(L, b);
					num = ((int)num2 * -589145828) ^ -343756351;
					continue;
				case 3u:
					b = _200F_202B_200F_206F_200B_202C_200C_200B_200C_206E_206B_200B_200D_206C_200F_206F_206A_206A_200F_200F_200B_206B_206A_200B_200D_206E_200E_200C_200F_200D_202B_206A_206C_206B_206E_200F_206E_206E_206F_202E(val, val2);
					num = ((int)num2 * -269306877) ^ 0x7C76DB87;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	static Type _200B_202E_206F_206D_202D_206A_206B_202B_202D_200C_206A_202A_206C_202E_202C_202C_206C_200E_202A_206A_206D_200C_200C_200D_206C_200D_206C_206E_202B_202B_206D_206F_206D_206D_206F_202B_202E_200D_202B_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static RenderTexture _200F_200B_200C_202A_202B_200F_206A_206F_206F_202B_206D_200E_206C_206C_206F_206C_200B_206F_200D_200B_202C_200F_202E_202A_202A_200B_206F_200D_202B_200B_206E_206C_206C_200E_206A_200D_202A_202C_202B_206C_202E(int P_0, int P_1, int P_2)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return new RenderTexture(P_0, P_1, P_2);
	}

	static RenderTexture _202A_200C_206A_200E_200C_206A_200F_200F_202B_202E_200D_206D_200B_206A_206A_206C_200E_206B_206B_200B_200B_200F_202E_202E_200C_200B_206D_206A_202A_202A_206A_200C_202B_200C_202E_200C_200B_206A_202A_202E_202E(int P_0, int P_1, int P_2, RenderTextureFormat P_3)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		return new RenderTexture(P_0, P_1, P_2, P_3);
	}

	static RenderTexture _200B_206F_200C_206A_202B_206C_206A_206B_206E_200D_206B_200D_202E_202D_200D_200C_202B_206E_206B_202D_202D_202C_202D_200D_200B_200D_206C_202E_202B_200F_200F_202E_200C_206A_200D_202A_200C_206F_206D_202A_202E(int P_0, int P_1, int P_2, RenderTextureFormat P_3, RenderTextureReadWrite P_4)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new RenderTexture(P_0, P_1, P_2, P_3, P_4);
	}

	static bool _200F_202B_200F_206F_200B_202C_200C_200B_200C_206E_206B_200B_200D_206C_200F_206F_206A_206A_200F_200F_200B_206B_206A_200B_200D_206E_200E_200C_200F_200D_202B_206A_206C_206B_206E_200F_206E_206E_206F_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static int _206D_206C_206A_202C_202B_200C_206A_206F_206D_202D_206D_200D_206C_202A_200C_206E_202D_206F_200E_202E_200D_202E_202B_202B_200C_200D_200D_202B_200D_202C_206D_200B_200F_206F_206F_200D_206F_202A_206E_200C_202E(RenderTexture P_0)
	{
		return P_0.width;
	}

	static int _200F_200D_202E_202B_206F_200F_202A_206A_200D_202D_206C_202B_206A_202D_206B_206E_200D_206D_202E_202A_202E_202A_200C_200E_200D_200E_206D_206C_202A_202D_200B_200F_206C_200D_206A_200F_202B_200D_200C_206A_202E(RenderTexture P_0)
	{
		return P_0.height;
	}

	static int _202E_200E_200F_202A_206B_202E_206D_202E_206C_200F_202D_206A_200F_200B_206A_206B_206B_200C_206E_200D_206D_202C_202C_202B_206B_202B_202C_200D_202D_206F_206C_202A_206C_200B_206D_200F_202A_200E_200D_202C_202E(RenderTexture P_0)
	{
		return P_0.depth;
	}

	static bool _200F_200B_206B_200F_206A_206F_202D_202C_200F_202C_200F_206B_206E_202C_202A_200E_200F_206A_206E_200C_202E_206A_200C_200B_202A_202D_200D_206E_200E_202E_200E_206B_202D_206C_200E_200C_200E_206B_202D_200C_202E(RenderTexture P_0)
	{
		return P_0.isPowerOfTwo;
	}

	static bool _200D_200E_200C_202E_202D_202A_200C_206A_200C_202E_206A_206B_200F_202D_206D_200F_202C_202D_206A_206E_200F_206C_206E_200D_200E_200F_206E_206F_206C_206F_206E_206B_206C_206A_206E_206F_206A_202B_206D_206B_202E(RenderTexture P_0)
	{
		return P_0.sRGB;
	}

	static RenderTextureFormat _202D_206D_206D_206D_200C_206B_206C_200D_200E_206D_206A_200D_202D_200B_202C_206A_202D_206C_202C_200B_200F_200C_206E_202E_206E_202A_202D_206F_202D_200F_206C_200E_206D_200D_202A_206A_206A_206F_200F_200C_202E(RenderTexture P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.format;
	}

	static bool _206D_200C_200E_202C_206C_202C_206E_202B_206B_206B_200F_206C_200B_206B_200E_202D_206F_200E_202E_202A_200D_202E_206F_202D_200E_206B_200E_202E_200D_202C_200B_206A_206E_206D_202B_200D_206A_202A_206E_206C_202E(RenderTexture P_0)
	{
		return P_0.useMipMap;
	}

	static bool _202C_200F_202B_200E_202C_206D_206B_200B_206C_200E_202C_206A_206D_200D_202B_200D_206C_200F_206F_200F_200D_206E_206F_206F_202C_206F_200E_206D_206C_206F_200C_206B_202D_202C_200B_200D_202A_206C_202A_202C_202E(RenderTexture P_0)
	{
		return P_0.generateMips;
	}

	static bool _200E_200C_200B_200E_200D_200F_202B_200C_202B_206B_206E_202C_200F_200F_206B_206B_202C_206A_206D_202A_200D_206F_202C_202A_200E_202A_202E_200B_202E_200C_206F_202E_206C_200E_202E_206B_200B_206A_206A_202C_202E(RenderTexture P_0)
	{
		return P_0.isCubemap;
	}

	static bool _200F_206F_202D_206B_202E_200E_202B_202A_202E_202C_206D_202E_206F_200B_206B_200F_206C_200E_202E_200B_202D_202B_206B_206D_200F_200C_200B_206A_206A_202E_206F_200E_202C_200C_200B_202B_202D_206A_206C_202A_202E(RenderTexture P_0)
	{
		return P_0.isVolume;
	}

	static int _206C_200B_200D_200B_200C_202A_202B_200B_200F_200F_202C_200B_206C_202B_200E_206E_202E_206D_200C_200B_206E_206E_206C_200B_206C_206F_206E_200D_200F_202D_202C_202D_206C_200D_200E_202B_202E_206A_206B_206F_202E(RenderTexture P_0)
	{
		return P_0.volumeDepth;
	}

	static int _206B_206D_206C_206F_200C_200E_206C_202A_200B_202C_200F_206E_200F_202B_202E_202B_200E_206E_200C_206B_206F_202B_200D_206A_200D_200B_202C_206E_202C_202C_202A_200F_202E_206A_200B_202C_206B_202D_202C_206F_202E(RenderTexture P_0)
	{
		return P_0.antiAliasing;
	}

	static bool _206C_202A_200F_206B_200E_202E_200B_206D_200D_206B_206A_206D_200E_200B_202E_200C_206B_200F_202A_206C_206A_200B_206A_200F_202E_200B_206B_202D_206A_202B_206C_200E_206F_200E_200C_206B_200D_202B_206E_206F_202E(RenderTexture P_0)
	{
		return P_0.enableRandomWrite;
	}

	static RenderBuffer _206F_200B_200E_200B_202E_206C_206B_206D_202D_202E_206A_206C_206B_200F_206C_206B_202D_200F_206D_206C_202B_202A_202B_200F_206E_200D_202E_206D_200D_202E_202C_200C_200D_202D_206E_202E_206E_202B_202B_206F_202E(RenderTexture P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.colorBuffer;
	}

	static RenderBuffer _202D_200F_202D_206F_206E_200D_206A_202C_200F_206E_202A_202D_200C_202A_200D_206B_200B_202B_200F_200F_202E_202C_206B_202C_202A_200B_200C_206B_200E_206B_206E_200F_206F_200E_202C_200D_206B_202D_200C_206F_202E(RenderTexture P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.depthBuffer;
	}

	static RenderTexture _200E_202C_202C_206B_200C_206F_202E_206D_202E_202B_206E_206B_200C_200F_206B_200D_206E_206F_200F_200F_200B_206A_202E_206E_206F_200C_202D_200F_206D_200B_200B_206E_202E_206C_206E_202C_206B_200F_202D_200C_202E()
	{
		return RenderTexture.active;
	}

	static void _206A_206A_202B_202A_200B_206E_206B_200F_206C_200B_206D_200D_202B_202A_206A_200C_202C_202C_200F_200B_202B_202E_206F_206A_200E_206F_206A_202A_206D_202C_206B_206F_206B_200F_202E_200B_202C_200C_206A_206C_202E(RenderTexture P_0, int P_1)
	{
		P_0.width = P_1;
	}

	static void _200F_202A_200D_202A_200B_202D_200F_200F_206D_202C_202C_200F_200B_206F_202E_202B_206E_202D_202C_202D_200D_206B_206D_200B_206D_202D_202B_206E_206F_202C_206B_200D_200F_206F_206E_206D_200F_206F_206B_202C_202E(RenderTexture P_0, int P_1)
	{
		P_0.height = P_1;
	}

	static void _206B_200D_202E_206C_200C_202A_206F_202C_200C_200D_200F_202C_200C_200F_200F_200B_200C_200F_202B_202B_206A_200F_206C_206E_202E_202C_206F_200C_200D_202D_200D_200C_202D_200E_206F_202A_200D_202E_206E_202B_202E(RenderTexture P_0, int P_1)
	{
		P_0.depth = P_1;
	}

	static void _200F_202B_202E_206D_202A_200B_200E_206A_200B_206A_202A_202C_200E_206E_202A_200E_202C_206C_200F_202B_202E_200B_206B_206E_206A_206A_206D_200F_206E_206D_206B_200D_200C_202B_200B_206C_206A_200C_206B_206A_202E(RenderTexture P_0, bool P_1)
	{
		P_0.isPowerOfTwo = P_1;
	}

	static void _206A_200F_206B_206B_202D_202B_206C_200C_200B_206C_202C_206E_202E_206E_202C_200E_202B_202E_200E_202B_206F_202A_202A_206D_206A_206A_202B_200E_206A_206B_202B_206F_200B_200E_206B_206D_202C_206C_202D_206F_202E(RenderTexture P_0, RenderTextureFormat P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.format = P_1;
	}

	static void _206B_206D_206F_202C_202C_206A_202C_206B_200B_200F_200E_202C_200B_202D_206C_206F_206F_202A_206A_202D_200D_202A_206F_200C_200D_206E_202E_200B_206E_206E_202E_200C_202B_200C_206C_206E_206B_202A_202D_202A_202E(RenderTexture P_0, bool P_1)
	{
		P_0.useMipMap = P_1;
	}

	static void _200D_206E_200F_200E_206D_206D_206F_200E_200D_202B_206A_200E_200C_206B_206D_202D_206F_206B_206D_206F_202E_202A_202A_200C_206D_200B_202A_202B_200B_206C_202C_206B_206B_206D_206A_206D_200E_202C_200B_202C_202E(RenderTexture P_0, bool P_1)
	{
		P_0.generateMips = P_1;
	}

	static void _206E_206A_200F_200F_206E_202B_200B_200D_206D_200D_206B_202C_202D_202C_202C_200C_206A_206E_200B_206C_202E_200E_200D_200E_200D_202B_202D_206B_200F_206E_206A_202A_200F_202A_206B_200C_200B_200D_202B_206B_202E(RenderTexture P_0, bool P_1)
	{
		P_0.isCubemap = P_1;
	}

	static void _206D_206A_206C_200D_202B_200F_200E_206D_206C_206C_202C_202D_200B_202E_202C_200D_206D_206D_206B_200E_202C_206F_200F_206A_200D_202B_200B_202A_200F_200D_200E_206A_206A_206C_200D_200F_200E_200C_206A_202E(RenderTexture P_0, bool P_1)
	{
		P_0.isVolume = P_1;
	}

	static void _206F_202C_206A_206B_200F_200C_200C_200C_202A_202C_206B_202C_206E_200B_202A_200C_200B_202A_202E_206F_206B_200F_206D_206D_200B_206A_202D_202E_200B_202A_200D_200C_200C_206B_206D_206F_200C_206E_202A_206F_202E(RenderTexture P_0, int P_1)
	{
		P_0.volumeDepth = P_1;
	}

	static void _200D_202D_202D_202E_206E_200F_206F_200B_202B_206D_202C_206B_200E_206A_206F_206C_206C_202D_202E_200B_202D_200B_202D_206E_206B_202D_200D_206A_200E_202A_202B_202D_200C_202E_202C_200D_202D_206A_200F_200E_202E(RenderTexture P_0, int P_1)
	{
		P_0.antiAliasing = P_1;
	}

	static void _200D_206F_200C_200B_206C_206B_200E_206F_202D_200E_206A_206C_200B_206B_200B_202E_202C_206A_202C_202B_200B_202B_200F_202B_202B_206C_206F_202E_200C_202A_206E_202D_206B_200C_202A_200F_200E_206B_206B_206C_202E(RenderTexture P_0, bool P_1)
	{
		P_0.enableRandomWrite = P_1;
	}

	static void _200D_200B_202D_200F_206E_202D_206C_206B_200C_202D_206F_202B_202A_200F_206C_202E_206D_202E_206D_200D_206C_200E_200D_206D_206B_202A_202B_206C_200E_200B_200B_200B_200D_206C_206C_200D_202B_206E_202B_200F_202E(RenderTexture P_0)
	{
		RenderTexture.active = P_0;
	}

	static RenderTexture _200D_200D_202D_200D_206C_200D_202E_200F_202B_200F_200B_202B_200D_206D_206A_200F_200F_206F_206C_206D_200E_206B_206F_200C_206A_202E_206D_206A_206A_202A_200B_206D_200E_200D_206A_202C_206B_200B_202C_202D_202E(int P_0, int P_1)
	{
		return RenderTexture.GetTemporary(P_0, P_1);
	}

	static RenderTexture _206C_200C_206E_202B_202E_206D_206B_202E_206E_206C_202A_206C_200D_200D_202C_206D_206D_206C_206D_206B_200D_200D_200F_206E_200B_200E_206C_206A_200B_202E_202B_200F_202D_206A_202D_206C_200D_202A_200F_200C_202E(int P_0, int P_1, int P_2)
	{
		return RenderTexture.GetTemporary(P_0, P_1, P_2);
	}

	static RenderTexture _202B_206E_200C_200F_206B_202D_200D_206B_202E_202A_206C_206D_200C_202A_206F_200F_202E_200F_206D_202A_206A_202D_200B_200E_200C_206F_206F_200E_206C_206B_202D_200B_206D_202C_200D_206B_202B_202B_206B_200D_202E(int P_0, int P_1, int P_2, RenderTextureFormat P_3)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return RenderTexture.GetTemporary(P_0, P_1, P_2, P_3);
	}

	static RenderTexture _202C_200D_206D_206A_206A_202D_206E_200E_202E_206B_200B_200E_206A_200C_202D_206D_206D_206E_200E_202C_206A_200E_206D_200E_202C_202A_200F_200F_202D_206E_206B_202D_202E_206D_202B_200B_200B_202B_200D_200C_202E(int P_0, int P_1, int P_2, RenderTextureFormat P_3, RenderTextureReadWrite P_4)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return RenderTexture.GetTemporary(P_0, P_1, P_2, P_3, P_4);
	}

	static RenderTexture _206A_206C_202C_202D_200E_206F_206B_200C_206D_200D_200C_206C_200B_200B_200F_202C_202E_200B_200D_206E_202C_206A_206C_206C_206F_202A_200C_200F_200E_206D_200D_202D_202E_202B_206D_206B_206D_202E_206E_202E(int P_0, int P_1, int P_2, RenderTextureFormat P_3, RenderTextureReadWrite P_4, int P_5)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return RenderTexture.GetTemporary(P_0, P_1, P_2, P_3, P_4, P_5);
	}

	static void _206D_202B_200B_202C_202E_202B_202C_200D_200D_202D_200E_200E_202B_200F_202A_206D_200D_206C_206D_206D_202E_206D_206E_206F_200E_200F_202D_202D_200D_206A_202B_206E_206A_206D_202B_202D_202A_202A_206E_206D_202E(RenderTexture P_0)
	{
		RenderTexture.ReleaseTemporary(P_0);
	}

	static bool _202A_206F_200D_202A_200C_206D_206E_206F_206F_206A_206B_202C_206B_206D_206C_206E_206A_206B_202C_200E_200D_206A_202A_202A_202A_200D_206A_206C_202A_202A_202C_202A_202B_202A_200F_200D_206A_200E_206A_202A_202E(RenderTexture P_0)
	{
		return P_0.Create();
	}

	static void _202E_202D_202B_206A_200D_202E_200E_206C_200D_200D_202B_200D_200B_206C_206C_200D_200C_200F_206A_206D_200E_202E_206D_202D_206B_206D_200D_202E_206F_202D_206C_200D_200E_200E_202A_202B_202B_206A_200C_206F_202E(RenderTexture P_0)
	{
		P_0.Release();
	}

	static bool _206A_202E_206E_206A_206C_202A_200F_202C_206C_200F_202E_200F_206A_200C_200F_206F_202B_202A_206A_200C_206C_202C_206D_200C_200E_200D_200B_200D_202D_202B_202E_206D_200D_200D_202C_206C_200C_202B_200B_206C_202E(RenderTexture P_0)
	{
		return P_0.IsCreated();
	}

	static void _200B_206F_206E_200C_206A_202D_200B_206D_202E_202B_206A_206D_200C_202D_206A_202A_200C_202A_202C_202E_200C_206F_200B_202B_202B_202A_206E_200B_202C_206C_202B_200B_200F_202B_200E_202C_200D_200E_202D_206B_202E(RenderTexture P_0)
	{
		P_0.DiscardContents();
	}

	static void _206E_202B_206A_200C_206E_200E_206D_202E_206A_206E_206A_206D_200E_206C_202C_200D_200F_206F_202E_200F_202E_202B_206E_206B_202C_202A_200B_200D_206E_200F_206F_200F_206D_200C_206B_200F_206B_200B_202C_202E_202E(RenderTexture P_0, bool P_1, bool P_2)
	{
		P_0.DiscardContents(P_1, P_2);
	}

	static void _206C_206B_200C_200E_206C_202A_202C_200B_200E_202A_200F_202B_206F_202D_206F_200C_206F_200D_202E_206C_206E_200F_202D_202C_200F_206F_206E_206C_200B_206B_200B_202B_206A_200E_200F_202A_200B_202C_206F_202E(RenderTexture P_0)
	{
		P_0.MarkRestoreExpected();
	}

	static void _206D_200F_200D_200B_200E_200F_202E_202A_200C_206A_202E_202C_202C_206A_200B_206C_202B_206C_206A_206E_206A_202C_202E_200B_206A_200F_202D_200E_200D_200C_200B_206A_206D_202E_202B_202E_206D_202C_202C_200F_202E(RenderTexture P_0, string P_1)
	{
		P_0.SetGlobalShaderProperty(P_1);
	}

	static Vector2 _200B_202D_202E_206D_202E_202D_206E_206B_202A_200D_206D_206E_206A_206F_202D_200C_202D_202E_202E_202E_202C_206A_200F_202B_202E_202C_206F_206D_202A_202B_206C_202C_202D_200E_202B_206D_200C_206D_202A_202D_202E(RenderTexture P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.GetTexelOffset();
	}

	static bool _200B_206F_206A_206D_206E_206F_200B_206F_206A_206D_206E_202C_200E_202C_202C_200E_206C_206E_200F_200E_200D_200D_200B_202C_202B_200D_206E_206A_202B_206F_200D_206C_202C_206F_202B_206F_200C_202A_202A_200E_202E(RenderTexture P_0)
	{
		return RenderTexture.SupportsStencil(P_0);
	}
}
