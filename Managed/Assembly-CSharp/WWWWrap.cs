using System;
using System.Collections.Generic;
using System.Text;
using LuaInterface;
using UnityEngine;

public class WWWWrap
{
	private static Type classType = _200C_206B_206F_206E_200E_202D_200E_206D_202C_206A_200C_206A_206D_206E_206B_206F_206D_202B_202A_206A_200D_200E_206E_202A_200F_200D_206F_200D_206B_200E_202C_202A_200C_202E_202D_206A_206C_202D_200D_200F_202E(typeof(WWW).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[10]
		{
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2728579209u), Dispose),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1745841757u), InitWWW),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1993007255u), EscapeURL),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2381523890u), UnEscapeURL),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3730620651u), GetAudioClip),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1570142445u), GetAudioClipCompressed),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3678820312u), LoadImageIntoTexture),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2370959252u), LoadFromCacheOrDownload),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1657282774u), _206C_206D_206B_202D_206C_202A_206E_206A_200F_206F_206D_206A_206D_206C_200F_202C_200C_206A_206D_200D_206A_200D_200F_206D_202B_200B_202A_202E_200C_206A_202B_202C_206C_200C_206C_202A_202B_202A_202B_200D_202E),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(10103728u), GetClassType)
		};
		LuaField[] fields = default(LuaField[]);
		while (true)
		{
			int num = 1523846523;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x66DC528A)) % 4)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					fields = new LuaField[15]
					{
						new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1204955590u), get_responseHeaders, null),
						new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2571007771u), get_text, null),
						new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3481709225u), get_bytes, null),
						new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1153684584u), get_size, null),
						new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4154215885u), get_error, null),
						new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2514646882u), get_texture, null),
						new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(173134329u), get_textureNonReadable, null),
						new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2473011996u), get_audioClip, null),
						new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4003288286u), get_isDone, null),
						new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2810934514u), get_progress, null),
						new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4283485897u), get_uploadProgress, null),
						new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2391697062u), get_bytesDownloaded, null),
						new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3706545661u), get_url, null),
						new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3790355330u), get_assetBundle, null),
						new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(239898734u), get_threadPriority, set_threadPriority)
					};
					num = ((int)num2 * -1478097112) ^ 0x209929F2;
					continue;
				case 0u:
					LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2682843123u), _200C_206B_206F_206E_200E_202D_200E_206D_202C_206A_200C_206A_206D_206E_206B_206F_206D_202B_202A_206A_200D_200E_206E_202A_200F_200D_206F_200D_206B_200E_202C_202A_200C_202E_202D_206A_206C_202D_200D_200F_202E(typeof(WWW).TypeHandle), regs, fields, _200C_206B_206F_206E_200E_202D_200E_206D_202C_206A_200C_206A_206D_206E_206B_206F_206D_202B_202A_206A_200D_200E_206E_202A_200F_200D_206F_200D_206B_200E_202C_202A_200C_202E_202D_206A_206C_202D_200D_200F_202E(typeof(object).TypeHandle));
					num = (int)(num2 * 1721479349) ^ -1425388431;
					continue;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _206C_206D_206B_202D_206C_202A_206E_206A_200F_206F_206D_206A_206D_206C_200F_202C_200C_206A_206D_200D_206A_200D_200F_206D_202B_200B_202A_202E_200C_206A_202B_202C_206C_200C_206C_202A_202B_202A_202B_200D_202E(IntPtr P_0)
	{
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(P_0);
		if (num == 1)
		{
			goto IL_000e;
		}
		goto IL_00f1;
		IL_000e:
		int num2 = -946437866;
		goto IL_0013;
		IL_0013:
		byte[] arrayNumber = default(byte[]);
		string text2 = default(string);
		WWWForm val = default(WWWForm);
		WWW o2 = default(WWW);
		WWW o = default(WWW);
		string text4 = default(string);
		byte[] arrayNumber2 = default(byte[]);
		string text3 = default(string);
		Dictionary<string, string> dictionary = default(Dictionary<string, string>);
		string text = default(string);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ -1393329439)) % 20)
			{
			case 18u:
				break;
			case 12u:
				arrayNumber = LuaScriptMgr.GetArrayNumber<byte>(P_0, 2);
				num2 = (int)((num3 * 1966375909) ^ 0x6ECB94A0);
				continue;
			case 13u:
				text2 = LuaScriptMgr.GetString(P_0, 1);
				num2 = ((int)num3 * -129177276) ^ 0x23D80C35;
				continue;
			case 14u:
				val = (WWWForm)LuaScriptMgr.GetNetObject(P_0, 2, _200C_206B_206F_206E_200E_202D_200E_206D_202C_206A_200C_206A_206D_206E_206B_206F_206D_202B_202A_206A_200D_200E_206E_202A_200F_200D_206F_200D_206B_200E_202C_202A_200C_202E_202D_206A_206C_202D_200D_200F_202E(typeof(WWWForm).TypeHandle));
				num2 = (int)((num3 * 193472647) ^ 0x5BBFB7A6);
				continue;
			case 10u:
				goto IL_00d9;
			case 3u:
				goto IL_00f1;
			case 8u:
				LuaScriptMgr.PushObject(P_0, o2);
				return 1;
			case 0u:
			{
				int num6;
				int num7;
				if (!LuaScriptMgr.CheckTypes(P_0, 1, _200C_206B_206F_206E_200E_202D_200E_206D_202C_206A_200C_206A_206D_206E_206B_206F_206D_202B_202A_206A_200D_200E_206E_202A_200F_200D_206F_200D_206B_200E_202C_202A_200C_202E_202D_206A_206C_202D_200D_200F_202E(typeof(string).TypeHandle), _200C_206B_206F_206E_200E_202D_200E_206D_202C_206A_200C_206A_206D_206E_206B_206F_206D_202B_202A_206A_200D_200E_206E_202A_200F_200D_206F_200D_206B_200E_202C_202A_200C_202E_202D_206A_206C_202D_200D_200F_202E(typeof(byte[]).TypeHandle)))
				{
					num6 = 1486811235;
					num7 = num6;
				}
				else
				{
					num6 = 1184052302;
					num7 = num6;
				}
				num2 = num6 ^ ((int)num3 * -511460548);
				continue;
			}
			case 16u:
				LuaScriptMgr.PushObject(P_0, o);
				return 1;
			case 7u:
				text4 = LuaScriptMgr.GetString(P_0, 1);
				arrayNumber2 = LuaScriptMgr.GetArrayNumber<byte>(P_0, 2);
				num2 = (int)((num3 * 724806830) ^ 0x1EF067F3);
				continue;
			case 4u:
			{
				WWW o4 = _206B_200D_200F_200C_200B_206E_206D_200E_200E_200C_200B_202B_200D_206D_206A_200C_206E_202A_200C_206E_206B_202C_202A_206A_200D_202D_206B_206F_202B_206C_202D_206B_200D_202A_202E_202E_206D_200B_206B_202E_202E(text4, arrayNumber2);
				LuaScriptMgr.PushObject(P_0, o4);
				return 1;
			}
			case 1u:
				goto IL_01c8;
			case 19u:
			{
				int num4;
				int num5;
				if (LuaScriptMgr.CheckTypes(P_0, 1, _200C_206B_206F_206E_200E_202D_200E_206D_202C_206A_200C_206A_206D_206E_206B_206F_206D_202B_202A_206A_200D_200E_206E_202A_200F_200D_206F_200D_206B_200E_202C_202A_200C_202E_202D_206A_206C_202D_200D_200F_202E(typeof(string).TypeHandle), _200C_206B_206F_206E_200E_202D_200E_206D_202C_206A_200C_206A_206D_206E_206B_206F_206D_202B_202A_206A_200D_200E_206E_202A_200F_200D_206F_200D_206B_200E_202C_202A_200C_202E_202D_206A_206C_202D_200D_200F_202E(typeof(WWWForm).TypeHandle)))
				{
					num4 = 917352258;
					num5 = num4;
				}
				else
				{
					num4 = 215180916;
					num5 = num4;
				}
				num2 = num4 ^ (int)(num3 * 1306151512);
				continue;
			}
			case 6u:
			{
				WWW o3 = _202B_200F_206C_200B_202D_206F_206F_206F_202D_200D_206C_206B_202B_202B_206D_200C_202C_200C_200F_200F_200C_206F_206B_200F_202D_200E_200D_206F_206D_200F_202D_206B_206B_200F_200D_206C_202B_206B_206B_200C_202E(text3);
				LuaScriptMgr.PushObject(P_0, o3);
				return 1;
			}
			case 9u:
				dictionary = (Dictionary<string, string>)LuaScriptMgr.GetNetObject(P_0, 3, _200C_206B_206F_206E_200E_202D_200E_206D_202C_206A_200C_206A_206D_206E_206B_206F_206D_202B_202A_206A_200D_200E_206E_202A_200F_200D_206F_200D_206B_200E_202C_202A_200C_202E_202D_206A_206C_202D_200D_200F_202E(typeof(Dictionary<string, string>).TypeHandle));
				num2 = (int)(num3 * 738001581) ^ -740456198;
				continue;
			case 11u:
				text3 = LuaScriptMgr.GetString(P_0, 1);
				num2 = ((int)num3 * -1373366869) ^ -1293014582;
				continue;
			case 15u:
				text = LuaScriptMgr.GetString(P_0, 1);
				num2 = (int)((num3 * 91141564) ^ 0xA858B7F);
				continue;
			case 2u:
				o2 = _206B_200F_202C_206F_206A_200F_200F_202B_200E_200D_206A_200E_200F_202A_206A_200D_206D_206F_200F_200D_200D_202B_206B_202C_202A_206E_206A_200E_200B_206A_202C_200F_206E_206C_200F_200F_206D_200B_206C_200F_202E(text2, arrayNumber, dictionary);
				num2 = (int)((num3 * 1660286153) ^ 0x3DC11097);
				continue;
			case 5u:
				o = _206E_200B_206F_200D_206A_202A_200F_206C_206D_200E_202C_200E_200F_200E_200C_202D_202E_206D_206F_200B_200B_206D_200B_202C_206E_202A_200F_200E_206B_200D_202E_200C_202E_206C_200F_200D_200E_206C_202A_202B_202E(text, val);
				num2 = (int)((num3 * 1868003582) ^ 0x28E32223);
				continue;
			default:
				LuaDLL.luaL_error(P_0, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3303928195u));
				return 0;
			}
			break;
			IL_01c8:
			int num8;
			if (num == 3)
			{
				num2 = -896485788;
				num8 = num2;
			}
			else
			{
				num2 = -381522992;
				num8 = num2;
			}
			continue;
			IL_00d9:
			int num9;
			if (num == 2)
			{
				num2 = -1092250530;
				num9 = num2;
			}
			else
			{
				num2 = -1772609060;
				num9 = num2;
			}
		}
		goto IL_000e;
		IL_00f1:
		int num10;
		if (num == 2)
		{
			num2 = -489212663;
			num10 = num2;
		}
		else
		{
			num2 = -100154877;
			num10 = num2;
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
	private static int get_responseHeaders(IntPtr L)
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		WWW val = default(WWW);
		while (true)
		{
			int num = 628449126;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4B6A7019)) % 9)
				{
				case 6u:
					break;
				case 7u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 574655035) ^ 0x6C891ADC);
					continue;
				case 0u:
				{
					int num5;
					int num6;
					if (val == null)
					{
						num5 = 1205046732;
						num6 = num5;
					}
					else
					{
						num5 = 1132705849;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1178350055);
					continue;
				}
				case 8u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 555070894;
						num4 = num3;
					}
					else
					{
						num3 = 895135154;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1982928341);
					continue;
				}
				case 2u:
					num = (int)(num2 * 1353196215) ^ -52515291;
					continue;
				case 3u:
					val = (WWW)luaObject;
					num = ((int)num2 * -728849179) ^ 0x157DF5C2;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1213364714u));
					num = (int)(num2 * 1440709639) ^ -148356090;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1286027583u));
					num = 588373241;
					continue;
				default:
					LuaScriptMgr.PushObject(L, _202E_206C_202E_202C_206C_202D_200F_206A_206F_202A_200B_202C_206E_200C_206E_200F_202D_206D_206C_206A_200B_202D_206C_202E_202D_202A_206B_200D_200C_206E_202E_206C_206A_200B_200E_206E_202E_200F_206C_206D_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_text(IntPtr L)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		WWW val = default(WWW);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1607260055;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x64CBD367)) % 9)
				{
				case 5u:
					break;
				case 4u:
				{
					val = (WWW)luaObject;
					int num5;
					int num6;
					if (val == null)
					{
						num5 = -2076352615;
						num6 = num5;
					}
					else
					{
						num5 = -829711270;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 2058069342);
					continue;
				}
				case 8u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -187274197;
						num4 = num3;
					}
					else
					{
						num3 = -1444433908;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 617719531);
					continue;
				}
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2691139160u));
					num = 295246970;
					continue;
				case 0u:
					LuaScriptMgr.Push(L, _206E_202C_200D_202D_206D_206F_206D_202E_202E_202B_206A_206F_206D_200D_206A_200B_206E_206F_206C_206D_206F_200B_206A_202B_200F_200B_202A_206C_206C_200F_206A_202E_206F_200E_200C_206F_202C_202B_202D_202D_202E(val));
					num = 1788007015;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3728626109u));
					num = ((int)num2 * -1915344004) ^ 0x143AC283;
					continue;
				case 6u:
					num = (int)((num2 * 210000497) ^ 0x78EEAB5E);
					continue;
				case 3u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1955919146) ^ 0x6F744F77;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_bytes(IntPtr L)
	{
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		WWW val = default(WWW);
		while (true)
		{
			int num = 1706326243;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2798A509)) % 9)
				{
				case 4u:
					break;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(446308914u));
					num = (int)(num2 * 484412055) ^ -157066937;
					continue;
				case 1u:
					num = (int)(num2 * 79915761) ^ -1434417034;
					continue;
				case 3u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -288952673) ^ 0x5DCE050F;
					continue;
				case 2u:
					LuaScriptMgr.PushArray(L, _200C_200B_200D_202D_206B_202D_200F_206F_202B_202E_200D_206F_206A_206D_202D_206D_206A_206D_206A_206C_202C_200D_206D_206F_206A_202A_202A_202B_200F_202D_206A_206F_202E_206E_202E_206D_200B_200B_206E_202E(val));
					num = 1398515507;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 88457542;
						num6 = num5;
					}
					else
					{
						num5 = 2089432142;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1155414602);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2215869306u));
					num = 1347466055;
					continue;
				case 7u:
				{
					val = (WWW)luaObject;
					int num3;
					int num4;
					if (val != null)
					{
						num3 = -452241933;
						num4 = num3;
					}
					else
					{
						num3 = -1802450590;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1211595186);
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
	private static int get_size(IntPtr L)
	{
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		WWW val = default(WWW);
		while (true)
		{
			int num = -1300223575;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1654057014)) % 8)
				{
				case 7u:
					break;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3902709026u));
					num = -732405638;
					continue;
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1412597689) ^ 0xA51C647;
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 431542926;
						num6 = num5;
					}
					else
					{
						num5 = 623613578;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1130683034);
					continue;
				}
				case 5u:
					num = (int)((num2 * 1645559655) ^ 0xCCCFD1);
					continue;
				case 3u:
				{
					val = (WWW)luaObject;
					int num3;
					int num4;
					if (val != null)
					{
						num3 = -8911683;
						num4 = num3;
					}
					else
					{
						num3 = -1003236767;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1695929523);
					continue;
				}
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1558523119u));
					num = (int)((num2 * 1897259592) ^ 0x591A2207);
					continue;
				default:
					LuaScriptMgr.Push(L, _206C_202D_206E_202B_206A_200E_200E_206D_202B_206C_202E_206C_202E_206F_202A_202B_200F_206D_202A_202E_206D_206C_200E_202C_206B_206D_206D_202E_206C_202B_206D_200D_200B_206D_206A_202E_202D_206F_206F_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_error(IntPtr L)
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		WWW val = default(WWW);
		while (true)
		{
			int num = -1528288443;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -690225293)) % 9)
				{
				case 2u:
					break;
				case 6u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 154766404;
						num6 = num5;
					}
					else
					{
						num5 = 1776694177;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -726954564);
					continue;
				}
				case 3u:
					num = ((int)num2 * -477853382) ^ 0x5B7D0963;
					continue;
				case 8u:
				{
					int num3;
					int num4;
					if (val != null)
					{
						num3 = -329150333;
						num4 = num3;
					}
					else
					{
						num3 = -1889722647;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1614462040);
					continue;
				}
				case 5u:
					val = (WWW)luaObject;
					num = ((int)num2 * -1125049283) ^ -296721657;
					continue;
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1299494332) ^ -2083442281;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(974148944u));
					num = -51453197;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4195769860u));
					num = ((int)num2 * -567215264) ^ 0x12E9E2BB;
					continue;
				default:
					LuaScriptMgr.Push(L, _206F_202D_200C_200D_206A_202E_200C_200F_206D_202C_206B_200E_202E_202A_202B_202E_206A_202D_202D_206B_200F_202C_200B_200F_200F_206F_202B_206B_202C_206D_202D_206C_206C_206E_200C_206A_206C_206C_202B_200F_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_texture(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		WWW val = (WWW)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -753641937;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -301785093)) % 8)
				{
				case 0u:
					break;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(343103824u));
					num = -2133407268;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1233364811u));
					num = ((int)num2 * -311617482) ^ 0x171F5E16;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -1515536951;
						num6 = num5;
					}
					else
					{
						num5 = -307273182;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -330498968);
					continue;
				}
				case 6u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 1942647355) ^ 0x242AF984);
					continue;
				case 3u:
					num = ((int)num2 * -364897300) ^ 0x4A5AB5B8;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (val == null)
					{
						num3 = -928286331;
						num4 = num3;
					}
					else
					{
						num3 = -1062403060;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 788959012);
					continue;
				}
				default:
					LuaScriptMgr.Push(L, (Object)(object)_202E_206A_200D_202B_206E_202D_200C_200B_200D_206B_200E_206F_206F_200C_202D_202A_206C_206C_202A_206D_200F_200B_202E_202B_202E_200C_206B_202E_206D_206F_202A_200D_206D_200F_202B_200C_206B_206E_206B_206F_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_textureNonReadable(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		WWW val = (WWW)luaObject;
		if (val == null)
		{
			goto IL_0015;
		}
		goto IL_00ad;
		IL_0015:
		int num = 93183980;
		goto IL_001a;
		IL_001a:
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x2EFFFDFE)) % 8)
			{
			case 0u:
				break;
			case 1u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1351503874u));
				num = ((int)num2 * -6456426) ^ -807027849;
				continue;
			case 7u:
				num = (int)(num2 * 12953969) ^ -587426731;
				continue;
			case 2u:
				luaTypes = LuaDLL.lua_type(L, 1);
				num = ((int)num2 * -422870962) ^ 0x16F41507;
				continue;
			case 6u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(58211583u));
				num = 1740917802;
				continue;
			case 4u:
				goto IL_00ad;
			case 5u:
			{
				int num3;
				int num4;
				if (luaTypes != LuaTypes.LUA_TTABLE)
				{
					num3 = 514558593;
					num4 = num3;
				}
				else
				{
					num3 = 1545845478;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -1054996243);
				continue;
			}
			default:
				return 1;
			}
			break;
		}
		goto IL_0015;
		IL_00ad:
		LuaScriptMgr.Push(L, (Object)(object)_206B_206C_202B_200C_206D_202D_206D_202B_206E_202B_206D_206A_206B_202C_202A_206A_200E_200B_202C_200E_202C_200F_200E_206E_200C_206F_206F_202B_200D_200F_200D_200F_202D_202B_206E_206F_202E_206A_206B_206E_202E(val));
		num = 672696085;
		goto IL_001a;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_audioClip(IntPtr L)
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		WWW val = default(WWW);
		while (true)
		{
			int num = 622510820;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x56A3FCC9)) % 9)
				{
				case 0u:
					break;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3210828560u));
					num = 1925411953;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (val != null)
					{
						num5 = -2117848962;
						num6 = num5;
					}
					else
					{
						num5 = -280826318;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 992355571);
					continue;
				}
				case 4u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 1878211746;
						num4 = num3;
					}
					else
					{
						num3 = 1179295453;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1430690319);
					continue;
				}
				case 2u:
					val = (WWW)luaObject;
					num = ((int)num2 * -526747489) ^ 0x66D5124F;
					continue;
				case 5u:
					LuaScriptMgr.Push(L, (Object)(object)_202C_206D_202D_206D_202B_202B_202C_202C_206F_202E_206F_200E_202E_200D_206A_206A_206D_202C_206D_200C_202A_206B_202B_206B_200E_206B_206F_202A_202B_206F_206C_206E_202B_202C_202D_206B_206D_206A_200F_202D_202E(val));
					num = 1886926416;
					continue;
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(316795749u));
					num = (int)(num2 * 1083768781) ^ -324953328;
					continue;
				case 1u:
					num = ((int)num2 * -1117586582) ^ 0x168762D5;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_isDone(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		WWW val = (WWW)luaObject;
		if (val == null)
		{
			goto IL_0012;
		}
		goto IL_0047;
		IL_0012:
		int num = 848223052;
		goto IL_0017;
		IL_0017:
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x580649D5)) % 7)
			{
			case 0u:
				break;
			case 3u:
				goto IL_0047;
			case 1u:
			{
				int num3;
				int num4;
				if (luaTypes != LuaTypes.LUA_TTABLE)
				{
					num3 = 1438441985;
					num4 = num3;
				}
				else
				{
					num3 = 2009582403;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -1199336521);
				continue;
			}
			case 2u:
				luaTypes = LuaDLL.lua_type(L, 1);
				num = ((int)num2 * -801499048) ^ -1097333973;
				continue;
			case 5u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2027815746u));
				num = 1620738812;
				continue;
			case 4u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2417202138u));
				num = ((int)num2 * -1506854774) ^ 0x6100FC24;
				continue;
			default:
				return 1;
			}
			break;
		}
		goto IL_0012;
		IL_0047:
		LuaScriptMgr.Push(L, _206C_202D_200B_206B_202D_202D_206D_206B_206E_206F_202D_206A_206E_200E_200C_200B_200C_200C_200D_206A_202D_206A_202C_200D_202C_202D_202E_200C_200E_206B_200F_206E_206E_202A_206F_200E_202C_206B_202B_206F_202E(val));
		num = 402825855;
		goto IL_0017;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_progress(IntPtr L)
	{
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		WWW val = default(WWW);
		while (true)
		{
			int num = 1485664553;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7D4AAD06)) % 10)
				{
				case 6u:
					break;
				case 1u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 759566290) ^ 0x3EBCBC1A);
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1050591476u));
					num = 1631388338;
					continue;
				case 2u:
					LuaScriptMgr.Push(L, _200E_206B_206B_206B_202B_202C_206D_202B_200F_200E_200B_206A_202D_202B_202A_202E_202A_200C_200C_206C_206B_202B_206E_206C_202A_202A_200F_200F_206D_206F_200E_200C_200F_206F_206B_206E_200F_202E_202A_202B_202E(val));
					num = 1617973863;
					continue;
				case 5u:
					num = ((int)num2 * -216556892) ^ -157665810;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -461343080;
						num6 = num5;
					}
					else
					{
						num5 = -692815198;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1366302502);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1093653158u));
					num = (int)(num2 * 427463051) ^ -1430152175;
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (val == null)
					{
						num3 = 351109255;
						num4 = num3;
					}
					else
					{
						num3 = 812878376;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1861544754);
					continue;
				}
				case 3u:
					val = (WWW)luaObject;
					num = ((int)num2 * -951938866) ^ 0x229483FF;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_uploadProgress(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		WWW val = default(WWW);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 862725131;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4A3AFE9D)) % 8)
				{
				case 7u:
					break;
				case 6u:
				{
					val = (WWW)luaObject;
					int num5;
					int num6;
					if (val != null)
					{
						num5 = -1188931395;
						num6 = num5;
					}
					else
					{
						num5 = -957023993;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1086589544);
					continue;
				}
				case 2u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1870471606) ^ -1491934558;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 1941672631;
						num4 = num3;
					}
					else
					{
						num3 = 1285794450;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 998037105);
					continue;
				}
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4254143088u));
					num = 864612429;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(936084256u));
					num = (int)((num2 * 876614649) ^ 0x26CEA64C);
					continue;
				case 5u:
					num = (int)(num2 * 1762371800) ^ -483787275;
					continue;
				default:
					LuaScriptMgr.Push(L, _202B_200F_202E_206A_206C_206D_206F_202C_202A_206B_202D_200F_206C_202C_200E_200C_202D_202A_206F_200B_200F_206E_202B_202A_202E_206A_200D_202B_206E_200C_206D_200C_202B_206A_202D_206E_206B_206D_206D_202B_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_bytesDownloaded(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		WWW val = (WWW)luaObject;
		if (val == null)
		{
			goto IL_0012;
		}
		goto IL_0057;
		IL_0012:
		int num = 953736018;
		goto IL_0017;
		IL_0017:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x28F9D236)) % 6)
			{
			case 4u:
				break;
			case 5u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(371220218u));
				num = 538075390;
				continue;
			case 0u:
				goto IL_0057;
			case 2u:
			{
				LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
				int num3;
				int num4;
				if (luaTypes != LuaTypes.LUA_TTABLE)
				{
					num3 = 584755515;
					num4 = num3;
				}
				else
				{
					num3 = 2052238827;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -1929689138);
				continue;
			}
			case 1u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(229724613u));
				num = (int)((num2 * 1000579817) ^ 0x1BB35DD3);
				continue;
			default:
				return 1;
			}
			break;
		}
		goto IL_0012;
		IL_0057:
		LuaScriptMgr.Push(L, _200D_200E_206D_202D_200F_206E_206C_200D_200F_200E_206C_200D_202E_202D_202B_200D_202C_200E_202B_206D_200C_202A_206F_206D_200D_200C_202D_200E_202A_202A_206B_206A_206B_206B_206B_202A_200B_200D_200D_202E(val));
		num = 1450312265;
		goto IL_0017;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_url(IntPtr L)
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		WWW val = default(WWW);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -811363982;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -166084729)) % 9)
				{
				case 7u:
					break;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(446299796u));
					num = ((int)num2 * -1598279642) ^ 0x3F5AD3A7;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (val != null)
					{
						num5 = 1841342212;
						num6 = num5;
					}
					else
					{
						num5 = 1171163048;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 86970017);
					continue;
				}
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2092762723u));
					num = -960523625;
					continue;
				case 0u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 1967046271) ^ -1869403198;
					continue;
				case 2u:
					LuaScriptMgr.Push(L, _200C_200D_206E_202B_202E_202A_202B_200B_202A_202C_200F_206A_202D_202B_200D_202A_206E_206E_206F_200E_202E_206A_202A_202E_202D_206C_202A_206E_202E_206B_206F_202E_200F_200F_202C_202C_206F_206B_202B_202B_202E(val));
					num = -1061334531;
					continue;
				case 6u:
					val = (WWW)luaObject;
					num = ((int)num2 * -1930265946) ^ 0x344190EA;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -1656102394;
						num4 = num3;
					}
					else
					{
						num3 = -2144332126;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1384632713);
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
	private static int get_assetBundle(IntPtr L)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		WWW val = default(WWW);
		while (true)
		{
			int num = 2122786164;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x43D88329)) % 8)
				{
				case 3u:
					break;
				case 0u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -873290659;
						num6 = num5;
					}
					else
					{
						num5 = -1146221624;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1176092993);
					continue;
				}
				case 2u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1743463697) ^ -1321781897;
					continue;
				case 5u:
				{
					val = (WWW)luaObject;
					int num3;
					int num4;
					if (val != null)
					{
						num3 = 679759779;
						num4 = num3;
					}
					else
					{
						num3 = 1747438239;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -417013484);
					continue;
				}
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1677787619u));
					num = 71365607;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1905537483u));
					num = (int)((num2 * 1435275182) ^ 0x3AF4166E);
					continue;
				case 7u:
					num = (int)((num2 * 577112907) ^ 0x7D6F3D2);
					continue;
				default:
					LuaScriptMgr.Push(L, (Object)(object)_200C_206C_200D_200D_200D_202D_200B_202B_206C_202C_206F_206E_202A_206E_202A_206F_206D_206F_200B_202B_206B_200F_206F_206A_200B_200F_202A_206D_206B_200F_206C_200C_202E_206C_200F_200F_206F_206D_200F_206E_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_threadPriority(IntPtr L)
	{
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		WWW val = default(WWW);
		while (true)
		{
			int num = 446987901;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x66D150A4)) % 8)
				{
				case 7u:
					break;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(467037606u));
					num = (int)((num2 * 2008272167) ^ 0xC7140DC);
					continue;
				case 0u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 267579640) ^ 0x59A46247);
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 1349021570;
						num6 = num5;
					}
					else
					{
						num5 = 242390977;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 138408280);
					continue;
				}
				case 2u:
					LuaScriptMgr.Push(L, (Enum)(object)_200B_206B_202B_200B_200E_200B_206F_200C_206E_202B_206F_200D_202A_200C_202E_200E_206A_206D_202D_202A_202D_200E_200F_200C_206D_206C_206F_202A_206B_202A_200B_206C_206C_206A_202D_200E_202A_200D_200D_200E_202E(val));
					num = 100209336;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1324053910u));
					num = 121358302;
					continue;
				case 1u:
				{
					val = (WWW)luaObject;
					int num3;
					int num4;
					if (val != null)
					{
						num3 = 656064776;
						num4 = num3;
					}
					else
					{
						num3 = 30190162;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 379339718);
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
	private static int set_threadPriority(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		WWW val = default(WWW);
		while (true)
		{
			int num = 101163819;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x73E2D611)) % 8)
				{
				case 0u:
					break;
				case 2u:
					val = (WWW)luaObject;
					num = (int)((num2 * 1227503037) ^ 0x5929C506);
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2073926300u));
					num = (int)(num2 * 1551922781) ^ -1693217146;
					continue;
				case 1u:
					num = (int)(num2 * 1765926439) ^ -1078657358;
					continue;
				case 3u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 416672379;
						num6 = num5;
					}
					else
					{
						num5 = 1124370682;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1239902324);
					continue;
				}
				case 5u:
				{
					int num3;
					int num4;
					if (val == null)
					{
						num3 = 1896712136;
						num4 = num3;
					}
					else
					{
						num3 = 776608167;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1762791338);
					continue;
				}
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1467109335u));
					num = 611639413;
					continue;
				default:
					_206B_200D_206E_206C_202E_202B_200D_200C_206F_206C_202B_202E_202B_200C_200D_202E_200E_206D_202D_200C_202E_206C_200B_206D_206F_202A_202A_200D_206F_206B_206E_202A_200B_202A_206F_202D_206E_200E_202E_202A_202E(val, (ThreadPriority)(int)LuaScriptMgr.GetNetObject(L, 3, _200C_206B_206F_206E_200E_202D_200E_206D_202C_206A_200C_206A_206D_206E_206B_206F_206D_202B_202A_206A_200D_200E_206E_202A_200F_200D_206F_200D_206B_200E_202C_202A_200C_202E_202D_206A_206C_202D_200D_200F_202E(typeof(ThreadPriority).TypeHandle)));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Dispose(IntPtr L)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 1);
		WWW val = default(WWW);
		while (true)
		{
			int num = -223866348;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1419511986)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0029;
				default:
					_200E_202A_200B_206A_202A_200F_202A_200C_202C_206D_206C_206C_200D_200C_206F_206F_200D_202E_200D_206C_206B_200C_206C_200D_200C_200D_202A_200F_200F_202E_202E_202D_202B_206D_200D_206F_202E_202E_200E_206C_202E(val);
					return 0;
				}
				break;
				IL_0029:
				val = (WWW)LuaScriptMgr.GetNetObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3872257509u));
				num = ((int)num2 * -238135205) ^ -119487670;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int InitWWW(IntPtr L)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 4);
		WWW val = default(WWW);
		while (true)
		{
			int num = 1303777412;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0xB4D786E)) % 4)
				{
				case 3u:
					break;
				case 2u:
					val = (WWW)LuaScriptMgr.GetNetObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4002402944u));
					num = (int)((num2 * 557804707) ^ 0x2F753C61);
					continue;
				case 1u:
				{
					string luaString = LuaScriptMgr.GetLuaString(L, 2);
					byte[] arrayNumber = LuaScriptMgr.GetArrayNumber<byte>(L, 3);
					string[] arrayString = LuaScriptMgr.GetArrayString(L, 4);
					_206F_202C_202E_206A_202B_202A_206F_200F_206D_200D_206D_200F_200D_200B_200C_206C_202A_202A_200B_202C_206C_202A_202B_202B_206C_200C_202D_206F_200B_206B_206C_206B_202C_200C_200B_200F_202B_200C_202B_202E_202E(val, luaString, arrayNumber, arrayString);
					num = ((int)num2 * -1973866119) ^ -1233455553;
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
	private static int EscapeURL(IntPtr L)
	{
		int num = LuaDLL.lua_gettop(L);
		if (num == 1)
		{
			goto IL_000b;
		}
		goto IL_0052;
		IL_000b:
		int num2 = -1200249553;
		goto IL_0010;
		IL_0010:
		string str2 = default(string);
		string luaString = default(string);
		Encoding encoding = default(Encoding);
		string str = default(string);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ -2141245500)) % 11)
			{
			case 8u:
				break;
			case 0u:
				goto IL_0052;
			case 5u:
				LuaScriptMgr.Push(L, str2);
				num2 = (int)(num3 * 1020423123) ^ -1154794969;
				continue;
			case 6u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1443208862u));
				num2 = -1389364620;
				continue;
			case 9u:
			{
				string luaString2 = LuaScriptMgr.GetLuaString(L, 1);
				str2 = _202A_206F_202D_206D_206E_206A_200E_202C_206A_200E_200E_206A_200C_202D_202D_202C_206A_202C_200B_202B_206B_206B_206B_200E_206F_200C_202C_202B_206A_206F_206A_206E_200C_206B_202E_202E_206D_202D_200F_200D_202E(luaString2);
				num2 = ((int)num3 * -252539411) ^ -755205070;
				continue;
			}
			case 3u:
				luaString = LuaScriptMgr.GetLuaString(L, 1);
				encoding = (Encoding)LuaScriptMgr.GetNetObject(L, 2, _200C_206B_206F_206E_200E_202D_200E_206D_202C_206A_200C_206A_206D_206E_206B_206F_206D_202B_202A_206A_200D_200E_206E_202A_200F_200D_206F_200D_206B_200E_202C_202A_200C_202E_202D_206A_206C_202D_200D_200F_202E(typeof(Encoding).TypeHandle));
				num2 = ((int)num3 * -516040649) ^ 0xFAB92A3;
				continue;
			case 10u:
				str = _202C_200E_206F_206B_206D_200B_206D_206E_200B_200D_200F_200B_206A_206D_202B_200D_206A_200F_200C_202C_206F_206F_200E_206E_206D_202A_202B_200E_202C_200E_200B_200E_202C_206C_202A_206C_206A_202B_200F_206B_202E(luaString, encoding);
				num2 = (int)((num3 * 225812317) ^ 0xE254E7);
				continue;
			case 4u:
				LuaScriptMgr.Push(L, str);
				num2 = (int)(num3 * 1987744338) ^ -210809787;
				continue;
			case 1u:
				return 1;
			case 7u:
				return 1;
			default:
				return 0;
			}
			break;
		}
		goto IL_000b;
		IL_0052:
		int num4;
		if (num == 2)
		{
			num2 = -1131663453;
			num4 = num2;
		}
		else
		{
			num2 = -626887785;
			num4 = num2;
		}
		goto IL_0010;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int UnEscapeURL(IntPtr L)
	{
		int num = LuaDLL.lua_gettop(L);
		string str = default(string);
		string luaString2 = default(string);
		string str2 = default(string);
		while (true)
		{
			int num2 = -1860567938;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1693708402)) % 9)
				{
				case 4u:
					break;
				case 1u:
				{
					int num5;
					int num6;
					if (num != 1)
					{
						num5 = -694319460;
						num6 = num5;
					}
					else
					{
						num5 = -197561532;
						num6 = num5;
					}
					num2 = num5 ^ ((int)num3 * -1528497698);
					continue;
				}
				case 2u:
				{
					string luaString = LuaScriptMgr.GetLuaString(L, 1);
					Encoding encoding = (Encoding)LuaScriptMgr.GetNetObject(L, 2, _200C_206B_206F_206E_200E_202D_200E_206D_202C_206A_200C_206A_206D_206E_206B_206F_206D_202B_202A_206A_200D_200E_206E_202A_200F_200D_206F_200D_206B_200E_202C_202A_200C_202E_202D_206A_206C_202D_200D_200F_202E(typeof(Encoding).TypeHandle));
					str = _202C_202E_200F_202B_200F_202D_206F_200D_206F_202C_200C_206A_202A_206E_200E_206D_200C_200D_202E_200B_200B_202B_200E_202E_206C_202B_206C_206D_200E_202B_202D_202A_206D_200D_202D_202E_206C_202A_202C_200E_202E(luaString, encoding);
					num2 = (int)((num3 * 498271210) ^ 0x1AF44FE1);
					continue;
				}
				case 3u:
					LuaScriptMgr.Push(L, str);
					return 1;
				case 0u:
					luaString2 = LuaScriptMgr.GetLuaString(L, 1);
					num2 = ((int)num3 * -484077622) ^ -954898510;
					continue;
				case 7u:
					str2 = _202C_200F_202D_202B_206C_200C_206D_200C_200C_202B_200F_206F_200B_206B_200D_206C_202A_206E_202A_202B_206C_206F_202D_200B_200D_200E_200D_202B_200F_202D_200F_202A_206E_206B_200B_202D_202E_202E_200B_202B_202E(luaString2);
					num2 = ((int)num3 * -850258888) ^ 0x1B7A5F2E;
					continue;
				case 8u:
					LuaScriptMgr.Push(L, str2);
					return 1;
				case 5u:
				{
					int num4;
					if (num == 2)
					{
						num2 = -965161646;
						num4 = num2;
					}
					else
					{
						num2 = -1860993102;
						num4 = num2;
					}
					continue;
				}
				default:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1248515666u));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetAudioClip(IntPtr L)
	{
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		int num = LuaDLL.lua_gettop(L);
		AudioClip obj2 = default(AudioClip);
		WWW val4 = default(WWW);
		bool boolean4 = default(bool);
		bool boolean5 = default(bool);
		bool boolean3 = default(bool);
		AudioClip obj3 = default(AudioClip);
		WWW val = default(WWW);
		while (true)
		{
			int num2 = -1875950248;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1768693271)) % 14)
				{
				case 13u:
					break;
				case 10u:
					LuaScriptMgr.Push(L, (Object)(object)obj2);
					return 1;
				case 8u:
					val4 = (WWW)LuaScriptMgr.GetNetObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4002402944u));
					boolean4 = LuaScriptMgr.GetBoolean(L, 2);
					boolean5 = LuaScriptMgr.GetBoolean(L, 3);
					num2 = (int)(num3 * 862617317) ^ -245481975;
					continue;
				case 3u:
					boolean3 = LuaScriptMgr.GetBoolean(L, 2);
					num2 = ((int)num3 * -2045648656) ^ 0x405253E4;
					continue;
				case 7u:
					return 1;
				case 12u:
				{
					AudioType val3 = (AudioType)(int)LuaScriptMgr.GetNetObject(L, 4, _200C_206B_206F_206E_200E_202D_200E_206D_202C_206A_200C_206A_206D_206E_206B_206F_206D_202B_202A_206A_200D_200E_206E_202A_200F_200D_206F_200D_206B_200E_202C_202A_200C_202E_202D_206A_206C_202D_200D_200F_202E(typeof(AudioType).TypeHandle));
					obj3 = _200F_200C_202C_200E_200D_202A_202D_202A_206E_206F_206E_202B_200C_206C_206A_200D_202C_200D_200B_202A_200F_206F_200D_206E_202D_206E_202A_206B_200F_200C_206A_200F_206B_206D_202D_200C_206C_200F_200B_200E_202E(val4, boolean4, boolean5, val3);
					num2 = ((int)num3 * -1227241688) ^ 0x1F83BE6F;
					continue;
				}
				case 11u:
				{
					int num6;
					int num7;
					if (num == 2)
					{
						num6 = 1149010143;
						num7 = num6;
					}
					else
					{
						num6 = 352660422;
						num7 = num6;
					}
					num2 = num6 ^ (int)(num3 * 956390132);
					continue;
				}
				case 5u:
					obj2 = _200B_202C_206B_202D_202E_206A_206E_200B_202C_206E_202C_202C_200D_206D_206C_202A_202C_202A_200F_200F_206C_200D_202E_200E_200E_200C_206D_206B_206A_200E_206B_200E_202C_206B_206A_202E_206D_206E_206B_200C_202E(val, boolean3);
					num2 = (int)((num3 * 684250608) ^ 0x5E789AED);
					continue;
				case 4u:
				{
					int num5;
					if (num != 4)
					{
						num2 = -438464319;
						num5 = num2;
					}
					else
					{
						num2 = -772689807;
						num5 = num2;
					}
					continue;
				}
				case 6u:
					LuaScriptMgr.Push(L, (Object)(object)obj3);
					num2 = (int)((num3 * 340629056) ^ 0x77A05866);
					continue;
				case 9u:
				{
					int num4;
					if (num == 3)
					{
						num2 = -900638678;
						num4 = num2;
					}
					else
					{
						num2 = -1366067055;
						num4 = num2;
					}
					continue;
				}
				case 1u:
				{
					WWW val2 = (WWW)LuaScriptMgr.GetNetObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3872257509u));
					bool boolean = LuaScriptMgr.GetBoolean(L, 2);
					bool boolean2 = LuaScriptMgr.GetBoolean(L, 3);
					AudioClip obj = _202D_206F_202A_206F_206C_200B_200E_206C_200F_200F_200B_200F_202A_200B_200B_202C_200E_206A_200C_202A_200E_206F_202A_206C_202E_202D_206A_200C_202E_202C_206D_206B_206A_206F_202B_206E_202C_200E_200D_206D_202E(val2, boolean, boolean2);
					LuaScriptMgr.Push(L, (Object)(object)obj);
					return 1;
				}
				case 2u:
					val = (WWW)LuaScriptMgr.GetNetObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3872257509u));
					num2 = ((int)num3 * -1561268699) ^ 0x33635C92;
					continue;
				default:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1111459091u));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetAudioClipCompressed(IntPtr L)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		WWW val3 = default(WWW);
		bool boolean2 = default(bool);
		AudioType val4 = default(AudioType);
		WWW val2 = default(WWW);
		bool boolean = default(bool);
		AudioClip obj = default(AudioClip);
		AudioClip obj2 = default(AudioClip);
		WWW val = default(WWW);
		while (true)
		{
			int num2 = 1993306718;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x3458851F)) % 15)
				{
				case 7u:
					break;
				case 3u:
					return 1;
				case 0u:
					val3 = (WWW)LuaScriptMgr.GetNetObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1286318417u));
					boolean2 = LuaScriptMgr.GetBoolean(L, 2);
					val4 = (AudioType)(int)LuaScriptMgr.GetNetObject(L, 3, _200C_206B_206F_206E_200E_202D_200E_206D_202C_206A_200C_206A_206D_206E_206B_206F_206D_202B_202A_206A_200D_200E_206E_202A_200F_200D_206F_200D_206B_200E_202C_202A_200C_202E_202D_206A_206C_202D_200D_200F_202E(typeof(AudioType).TypeHandle));
					num2 = (int)((num3 * 364534767) ^ 0x21BC7F8D);
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (num == 1)
					{
						num5 = 1770213082;
						num6 = num5;
					}
					else
					{
						num5 = 2100043437;
						num6 = num5;
					}
					num2 = num5 ^ (int)(num3 * 1617967863);
					continue;
				}
				case 6u:
					return 1;
				case 11u:
					val2 = (WWW)LuaScriptMgr.GetNetObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3872257509u));
					boolean = LuaScriptMgr.GetBoolean(L, 2);
					num2 = (int)(num3 * 38825812) ^ -618563110;
					continue;
				case 12u:
					LuaScriptMgr.Push(L, (Object)(object)obj);
					num2 = (int)((num3 * 1833739300) ^ 0x6991126C);
					continue;
				case 10u:
				{
					int num7;
					if (num != 3)
					{
						num2 = 1041673834;
						num7 = num2;
					}
					else
					{
						num2 = 2034219401;
						num7 = num2;
					}
					continue;
				}
				case 9u:
					LuaScriptMgr.Push(L, (Object)(object)obj2);
					return 1;
				case 13u:
					val = (WWW)LuaScriptMgr.GetNetObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(198083119u));
					num2 = ((int)num3 * -1084522499) ^ -1381094511;
					continue;
				case 5u:
				{
					int num4;
					if (num != 2)
					{
						num2 = 920011842;
						num4 = num2;
					}
					else
					{
						num2 = 18634124;
						num4 = num2;
					}
					continue;
				}
				case 1u:
				{
					AudioClip obj3 = _206C_202D_200F_206F_202E_206C_200D_206F_206E_200F_206B_206D_200C_202D_206D_206C_200E_200E_202B_200E_200B_206A_202C_206B_202C_202D_200C_200E_206A_200D_206B_200F_200C_202C_202B_206C_206F_206C_202E_202A_202E(val3, boolean2, val4);
					LuaScriptMgr.Push(L, (Object)(object)obj3);
					num2 = (int)((num3 * 1504039522) ^ 0x25FBC44D);
					continue;
				}
				case 14u:
					obj2 = _202B_206B_202B_202D_202B_202B_200F_206D_202E_202B_200F_206E_206A_202E_206E_206C_200F_206D_206E_206C_206C_202D_202D_200E_200C_206A_200E_202E_206B_206A_206E_206B_206D_200E_200F_200F_202C_200C_206B_206A_202E(val2, boolean);
					num2 = ((int)num3 * -2139186763) ^ 0x6049F57F;
					continue;
				case 2u:
					obj = _200E_202C_202E_202E_200D_202A_206F_206E_200D_200C_200E_206F_206F_200C_206D_206A_200B_200E_200F_206F_206D_206B_202B_206F_200E_202C_200B_202D_202D_206D_206F_206F_200B_202A_200C_206B_206F_202D_202C_206A_202E(val);
					num2 = (int)(num3 * 11602997) ^ -1318866902;
					continue;
				default:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3670510659u));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int LoadImageIntoTexture(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		WWW val = (WWW)LuaScriptMgr.GetNetObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3872257509u));
		Texture2D val2 = (Texture2D)LuaScriptMgr.GetUnityObject(L, 2, _200C_206B_206F_206E_200E_202D_200E_206D_202C_206A_200C_206A_206D_206E_206B_206F_206D_202B_202A_206A_200D_200E_206E_202A_200F_200D_206F_200D_206B_200E_202C_202A_200C_202E_202D_206A_206C_202D_200D_200F_202E(typeof(Texture2D).TypeHandle));
		_206B_202E_206C_202B_202B_202D_200F_206B_200F_206A_206A_202E_200D_206C_202E_200F_206D_202C_200F_200B_206B_206D_200E_200D_206B_202D_200F_200C_206D_206E_202B_206E_200C_202E_202B_200B_202B_206D_200D_206A_202E(val, val2);
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int LoadFromCacheOrDownload(IntPtr L)
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		int num = LuaDLL.lua_gettop(L);
		if (num == 2)
		{
			goto IL_000e;
		}
		goto IL_0131;
		IL_000e:
		int num2 = 760217074;
		goto IL_0013;
		IL_0013:
		WWW o2 = default(WWW);
		string text4 = default(string);
		Hash128 val2 = default(Hash128);
		uint num9 = default(uint);
		int num10 = default(int);
		uint num11 = default(uint);
		string text = default(string);
		int num8 = default(int);
		WWW o = default(WWW);
		string text2 = default(string);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ 0x58BF293D)) % 23)
			{
			case 3u:
				break;
			case 7u:
				return 1;
			case 14u:
				goto IL_009a;
			case 1u:
				LuaScriptMgr.PushObject(L, o2);
				num2 = (int)(num3 * 1551738190) ^ -43636801;
				continue;
			case 5u:
			{
				WWW o4 = _200F_206F_202B_202C_202C_202D_202D_200F_202E_202D_200E_206B_202A_206B_206D_202C_202B_200B_202A_200D_200D_200F_206E_206A_206F_202C_206A_206C_206F_206D_200B_200E_206E_200F_200D_200C_202E_206D_202A_200F_202E(text4, val2, num9);
				LuaScriptMgr.PushObject(L, o4);
				num2 = (int)((num3 * 605807074) ^ 0x57ECF486);
				continue;
			}
			case 19u:
				num10 = (int)LuaDLL.lua_tonumber(L, 2);
				num11 = (uint)LuaDLL.lua_tonumber(L, 3);
				num2 = ((int)num3 * -600606547) ^ -926759846;
				continue;
			case 18u:
				return 1;
			case 16u:
				goto IL_0131;
			case 10u:
				text = LuaScriptMgr.GetString(L, 1);
				num8 = (int)LuaDLL.lua_tonumber(L, 2);
				num2 = ((int)num3 * -851265636) ^ -851524811;
				continue;
			case 2u:
			{
				int num6;
				int num7;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200C_206B_206F_206E_200E_202D_200E_206D_202C_206A_200C_206A_206D_206E_206B_206F_206D_202B_202A_206A_200D_200E_206E_202A_200F_200D_206F_200D_206B_200E_202C_202A_200C_202E_202D_206A_206C_202D_200D_200F_202E(typeof(string).TypeHandle), _200C_206B_206F_206E_200E_202D_200E_206D_202C_206A_200C_206A_206D_206E_206B_206F_206D_202B_202A_206A_200D_200E_206E_202A_200F_200D_206F_200D_206B_200E_202C_202A_200C_202E_202D_206A_206C_202D_200D_200F_202E(typeof(Hash128).TypeHandle), _200C_206B_206F_206E_200E_202D_200E_206D_202C_206A_200C_206A_206D_206E_206B_206F_206D_202B_202A_206A_200D_200E_206E_202A_200F_200D_206F_200D_206B_200E_202C_202A_200C_202E_202D_206A_206C_202D_200D_200F_202E(typeof(uint).TypeHandle)))
				{
					num6 = -1959228264;
					num7 = num6;
				}
				else
				{
					num6 = -1380712380;
					num7 = num6;
				}
				num2 = num6 ^ ((int)num3 * -1429847337);
				continue;
			}
			case 13u:
				LuaScriptMgr.PushObject(L, o);
				return 1;
			case 8u:
			{
				int num14;
				int num15;
				if (LuaScriptMgr.CheckTypes(L, 1, _200C_206B_206F_206E_200E_202D_200E_206D_202C_206A_200C_206A_206D_206E_206B_206F_206D_202B_202A_206A_200D_200E_206E_202A_200F_200D_206F_200D_206B_200E_202C_202A_200C_202E_202D_206A_206C_202D_200D_200F_202E(typeof(string).TypeHandle), _200C_206B_206F_206E_200E_202D_200E_206D_202C_206A_200C_206A_206D_206E_206B_206F_206D_202B_202A_206A_200D_200E_206E_202A_200F_200D_206F_200D_206B_200E_202C_202A_200C_202E_202D_206A_206C_202D_200D_200F_202E(typeof(int).TypeHandle)))
				{
					num14 = -6112069;
					num15 = num14;
				}
				else
				{
					num14 = -108174729;
					num15 = num14;
				}
				num2 = num14 ^ (int)(num3 * 1222860952);
				continue;
			}
			case 22u:
				val2 = (Hash128)LuaScriptMgr.GetLuaObject(L, 2);
				num2 = ((int)num3 * -1808016627) ^ -1073330875;
				continue;
			case 17u:
				text4 = LuaScriptMgr.GetString(L, 1);
				num2 = (int)(num3 * 497410799) ^ -372146579;
				continue;
			case 20u:
			{
				int num12;
				int num13;
				if (LuaScriptMgr.CheckTypes(L, 1, _200C_206B_206F_206E_200E_202D_200E_206D_202C_206A_200C_206A_206D_206E_206B_206F_206D_202B_202A_206A_200D_200E_206E_202A_200F_200D_206F_200D_206B_200E_202C_202A_200C_202E_202D_206A_206C_202D_200D_200F_202E(typeof(string).TypeHandle), _200C_206B_206F_206E_200E_202D_200E_206D_202C_206A_200C_206A_206D_206E_206B_206F_206D_202B_202A_206A_200D_200E_206E_202A_200F_200D_206F_200D_206B_200E_202C_202A_200C_202E_202D_206A_206C_202D_200D_200F_202E(typeof(int).TypeHandle), _200C_206B_206F_206E_200E_202D_200E_206D_202C_206A_200C_206A_206D_206E_206B_206F_206D_202B_202A_206A_200D_200E_206E_202A_200F_200D_206F_200D_206B_200E_202C_202A_200C_202E_202D_206A_206C_202D_200D_200F_202E(typeof(uint).TypeHandle)))
				{
					num12 = -1116828032;
					num13 = num12;
				}
				else
				{
					num12 = -49129544;
					num13 = num12;
				}
				num2 = num12 ^ ((int)num3 * -1823123801);
				continue;
			}
			case 11u:
				text2 = LuaScriptMgr.GetString(L, 1);
				num2 = (int)((num3 * 199509623) ^ 0x52FAB99E);
				continue;
			case 12u:
			{
				string text3 = LuaScriptMgr.GetString(L, 1);
				Hash128 val = (Hash128)LuaScriptMgr.GetLuaObject(L, 2);
				WWW o3 = _206E_200E_206A_202A_206B_202E_206A_206E_202A_202C_200D_200D_206B_200D_200F_206B_200C_202B_206F_202D_200F_206A_206E_206D_206D_200B_202C_202D_206F_202D_206E_202A_200F_206F_206B_206B_206F_200C_206C_200E_202E(text3, val);
				LuaScriptMgr.PushObject(L, o3);
				return 1;
			}
			case 9u:
				o = _206B_206E_206C_200E_200B_206A_206E_202A_202C_206E_200D_206C_200C_202D_206B_202C_202B_206A_202A_200D_200F_200E_206A_202A_206B_200E_202A_206D_202B_200E_206A_206B_202A_200F_202E_206A_202E_200D_206C_206C_202E(text2, num10, num11);
				num2 = ((int)num3 * -851837527) ^ -660409281;
				continue;
			case 15u:
				o2 = _202D_200F_206C_200D_202A_200B_200B_202A_200C_200E_206C_206A_200E_200E_200F_206E_202C_206A_206F_206D_206C_202D_200B_202E_206F_206E_206D_206D_206A_202D_206C_202D_206D_200B_206E_206C_206E_200F_202B_202B_202E(text, num8);
				num2 = ((int)num3 * -579632835) ^ -2131926014;
				continue;
			case 0u:
				goto IL_031e;
			case 6u:
				num9 = (uint)LuaDLL.lua_tonumber(L, 3);
				num2 = ((int)num3 * -1061358586) ^ 0x20A39390;
				continue;
			case 21u:
			{
				int num4;
				int num5;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200C_206B_206F_206E_200E_202D_200E_206D_202C_206A_200C_206A_206D_206E_206B_206F_206D_202B_202A_206A_200D_200E_206E_202A_200F_200D_206F_200D_206B_200E_202C_202A_200C_202E_202D_206A_206C_202D_200D_200F_202E(typeof(string).TypeHandle), _200C_206B_206F_206E_200E_202D_200E_206D_202C_206A_200C_206A_206D_206E_206B_206F_206D_202B_202A_206A_200D_200E_206E_202A_200F_200D_206F_200D_206B_200E_202C_202A_200C_202E_202D_206A_206C_202D_200D_200F_202E(typeof(Hash128).TypeHandle)))
				{
					num4 = 1167313425;
					num5 = num4;
				}
				else
				{
					num4 = 457554264;
					num5 = num4;
				}
				num2 = num4 ^ (int)(num3 * 953597135);
				continue;
			}
			default:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3241685147u));
				return 0;
			}
			break;
			IL_031e:
			int num16;
			if (num == 3)
			{
				num2 = 828371819;
				num16 = num2;
			}
			else
			{
				num2 = 1436354210;
				num16 = num2;
			}
			continue;
			IL_009a:
			int num17;
			if (num == 3)
			{
				num2 = 2002518008;
				num17 = num2;
			}
			else
			{
				num2 = 1908743995;
				num17 = num2;
			}
		}
		goto IL_000e;
		IL_0131:
		int num18;
		if (num == 2)
		{
			num2 = 1200146816;
			num18 = num2;
		}
		else
		{
			num2 = 344339023;
			num18 = num2;
		}
		goto IL_0013;
	}

	static Type _200C_206B_206F_206E_200E_202D_200E_206D_202C_206A_200C_206A_206D_206E_206B_206F_206D_202B_202A_206A_200D_200E_206E_202A_200F_200D_206F_200D_206B_200E_202C_202A_200C_202E_202D_206A_206C_202D_200D_200F_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static WWW _202B_200F_206C_200B_202D_206F_206F_206F_202D_200D_206C_206B_202B_202B_206D_200C_202C_200C_200F_200F_200C_206F_206B_200F_202D_200E_200D_206F_206D_200F_202D_206B_206B_200F_200D_206C_202B_206B_206B_200C_202E(string P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new WWW(P_0);
	}

	static WWW _206B_200D_200F_200C_200B_206E_206D_200E_200E_200C_200B_202B_200D_206D_206A_200C_206E_202A_200C_206E_206B_202C_202A_206A_200D_202D_206B_206F_202B_206C_202D_206B_200D_202A_202E_202E_206D_200B_206B_202E_202E(string P_0, byte[] P_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new WWW(P_0, P_1);
	}

	static WWW _206E_200B_206F_200D_206A_202A_200F_206C_206D_200E_202C_200E_200F_200E_200C_202D_202E_206D_206F_200B_200B_206D_200B_202C_206E_202A_200F_200E_206B_200D_202E_200C_202E_206C_200F_200D_200E_206C_202A_202B_202E(string P_0, WWWForm P_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new WWW(P_0, P_1);
	}

	static WWW _206B_200F_202C_206F_206A_200F_200F_202B_200E_200D_206A_200E_200F_202A_206A_200D_206D_206F_200F_200D_200D_202B_206B_202C_202A_206E_206A_200E_200B_206A_202C_200F_206E_206C_200F_200F_206D_200B_206C_200F_202E(string P_0, byte[] P_1, Dictionary<string, string> P_2)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return new WWW(P_0, P_1, P_2);
	}

	static Dictionary<string, string> _202E_206C_202E_202C_206C_202D_200F_206A_206F_202A_200B_202C_206E_200C_206E_200F_202D_206D_206C_206A_200B_202D_206C_202E_202D_202A_206B_200D_200C_206E_202E_206C_206A_200B_200E_206E_202E_200F_206C_206D_202E(WWW P_0)
	{
		return P_0.responseHeaders;
	}

	static string _206E_202C_200D_202D_206D_206F_206D_202E_202E_202B_206A_206F_206D_200D_206A_200B_206E_206F_206C_206D_206F_200B_206A_202B_200F_200B_202A_206C_206C_200F_206A_202E_206F_200E_200C_206F_202C_202B_202D_202D_202E(WWW P_0)
	{
		return P_0.text;
	}

	static byte[] _200C_200B_200D_202D_206B_202D_200F_206F_202B_202E_200D_206F_206A_206D_202D_206D_206A_206D_206A_206C_202C_200D_206D_206F_206A_202A_202A_202B_200F_202D_206A_206F_202E_206E_202E_206D_200B_200B_206E_202E(WWW P_0)
	{
		return P_0.bytes;
	}

	static int _206C_202D_206E_202B_206A_200E_200E_206D_202B_206C_202E_206C_202E_206F_202A_202B_200F_206D_202A_202E_206D_206C_200E_202C_206B_206D_206D_202E_206C_202B_206D_200D_200B_206D_206A_202E_202D_206F_206F_202E(WWW P_0)
	{
		return P_0.size;
	}

	static string _206F_202D_200C_200D_206A_202E_200C_200F_206D_202C_206B_200E_202E_202A_202B_202E_206A_202D_202D_206B_200F_202C_200B_200F_200F_206F_202B_206B_202C_206D_202D_206C_206C_206E_200C_206A_206C_206C_202B_200F_202E(WWW P_0)
	{
		return P_0.error;
	}

	static Texture2D _202E_206A_200D_202B_206E_202D_200C_200B_200D_206B_200E_206F_206F_200C_202D_202A_206C_206C_202A_206D_200F_200B_202E_202B_202E_200C_206B_202E_206D_206F_202A_200D_206D_200F_202B_200C_206B_206E_206B_206F_202E(WWW P_0)
	{
		return P_0.texture;
	}

	static Texture2D _206B_206C_202B_200C_206D_202D_206D_202B_206E_202B_206D_206A_206B_202C_202A_206A_200E_200B_202C_200E_202C_200F_200E_206E_200C_206F_206F_202B_200D_200F_200D_200F_202D_202B_206E_206F_202E_206A_206B_206E_202E(WWW P_0)
	{
		return P_0.textureNonReadable;
	}

	static AudioClip _202C_206D_202D_206D_202B_202B_202C_202C_206F_202E_206F_200E_202E_200D_206A_206A_206D_202C_206D_200C_202A_206B_202B_206B_200E_206B_206F_202A_202B_206F_206C_206E_202B_202C_202D_206B_206D_206A_200F_202D_202E(WWW P_0)
	{
		return P_0.audioClip;
	}

	static bool _206C_202D_200B_206B_202D_202D_206D_206B_206E_206F_202D_206A_206E_200E_200C_200B_200C_200C_200D_206A_202D_206A_202C_200D_202C_202D_202E_200C_200E_206B_200F_206E_206E_202A_206F_200E_202C_206B_202B_206F_202E(WWW P_0)
	{
		return P_0.isDone;
	}

	static float _200E_206B_206B_206B_202B_202C_206D_202B_200F_200E_200B_206A_202D_202B_202A_202E_202A_200C_200C_206C_206B_202B_206E_206C_202A_202A_200F_200F_206D_206F_200E_200C_200F_206F_206B_206E_200F_202E_202A_202B_202E(WWW P_0)
	{
		return P_0.progress;
	}

	static float _202B_200F_202E_206A_206C_206D_206F_202C_202A_206B_202D_200F_206C_202C_200E_200C_202D_202A_206F_200B_200F_206E_202B_202A_202E_206A_200D_202B_206E_200C_206D_200C_202B_206A_202D_206E_206B_206D_206D_202B_202E(WWW P_0)
	{
		return P_0.uploadProgress;
	}

	static int _200D_200E_206D_202D_200F_206E_206C_200D_200F_200E_206C_200D_202E_202D_202B_200D_202C_200E_202B_206D_200C_202A_206F_206D_200D_200C_202D_200E_202A_202A_206B_206A_206B_206B_206B_202A_200B_200D_200D_202E(WWW P_0)
	{
		return P_0.bytesDownloaded;
	}

	static string _200C_200D_206E_202B_202E_202A_202B_200B_202A_202C_200F_206A_202D_202B_200D_202A_206E_206E_206F_200E_202E_206A_202A_202E_202D_206C_202A_206E_202E_206B_206F_202E_200F_200F_202C_202C_206F_206B_202B_202B_202E(WWW P_0)
	{
		return P_0.url;
	}

	static AssetBundle _200C_206C_200D_200D_200D_202D_200B_202B_206C_202C_206F_206E_202A_206E_202A_206F_206D_206F_200B_202B_206B_200F_206F_206A_200B_200F_202A_206D_206B_200F_206C_200C_202E_206C_200F_200F_206F_206D_200F_206E_202E(WWW P_0)
	{
		return P_0.assetBundle;
	}

	static ThreadPriority _200B_206B_202B_200B_200E_200B_206F_200C_206E_202B_206F_200D_202A_200C_202E_200E_206A_206D_202D_202A_202D_200E_200F_200C_206D_206C_206F_202A_206B_202A_200B_206C_206C_206A_202D_200E_202A_200D_200D_200E_202E(WWW P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.threadPriority;
	}

	static void _206B_200D_206E_206C_202E_202B_200D_200C_206F_206C_202B_202E_202B_200C_200D_202E_200E_206D_202D_200C_202E_206C_200B_206D_206F_202A_202A_200D_206F_206B_206E_202A_200B_202A_206F_202D_206E_200E_202E_202A_202E(WWW P_0, ThreadPriority P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.threadPriority = P_1;
	}

	static void _200E_202A_200B_206A_202A_200F_202A_200C_202C_206D_206C_206C_200D_200C_206F_206F_200D_202E_200D_206C_206B_200C_206C_200D_200C_200D_202A_200F_200F_202E_202E_202D_202B_206D_200D_206F_202E_202E_200E_206C_202E(WWW P_0)
	{
		P_0.Dispose();
	}

	static void _206F_202C_202E_206A_202B_202A_206F_200F_206D_200D_206D_200F_200D_200B_200C_206C_202A_202A_200B_202C_206C_202A_202B_202B_206C_200C_202D_206F_200B_206B_206C_206B_202C_200C_200B_200F_202B_200C_202B_202E_202E(WWW P_0, string P_1, byte[] P_2, string[] P_3)
	{
		P_0.InitWWW(P_1, P_2, P_3);
	}

	static string _202A_206F_202D_206D_206E_206A_200E_202C_206A_200E_200E_206A_200C_202D_202D_202C_206A_202C_200B_202B_206B_206B_206B_200E_206F_200C_202C_202B_206A_206F_206A_206E_200C_206B_202E_202E_206D_202D_200F_200D_202E(string P_0)
	{
		return WWW.EscapeURL(P_0);
	}

	static string _202C_200E_206F_206B_206D_200B_206D_206E_200B_200D_200F_200B_206A_206D_202B_200D_206A_200F_200C_202C_206F_206F_200E_206E_206D_202A_202B_200E_202C_200E_200B_200E_202C_206C_202A_206C_206A_202B_200F_206B_202E(string P_0, Encoding P_1)
	{
		return WWW.EscapeURL(P_0, P_1);
	}

	static string _202C_200F_202D_202B_206C_200C_206D_200C_200C_202B_200F_206F_200B_206B_200D_206C_202A_206E_202A_202B_206C_206F_202D_200B_200D_200E_200D_202B_200F_202D_200F_202A_206E_206B_200B_202D_202E_202E_200B_202B_202E(string P_0)
	{
		return WWW.UnEscapeURL(P_0);
	}

	static string _202C_202E_200F_202B_200F_202D_206F_200D_206F_202C_200C_206A_202A_206E_200E_206D_200C_200D_202E_200B_200B_202B_200E_202E_206C_202B_206C_206D_200E_202B_202D_202A_206D_200D_202D_202E_206C_202A_202C_200E_202E(string P_0, Encoding P_1)
	{
		return WWW.UnEscapeURL(P_0, P_1);
	}

	static AudioClip _200B_202C_206B_202D_202E_206A_206E_200B_202C_206E_202C_202C_200D_206D_206C_202A_202C_202A_200F_200F_206C_200D_202E_200E_200E_200C_206D_206B_206A_200E_206B_200E_202C_206B_206A_202E_206D_206E_206B_200C_202E(WWW P_0, bool P_1)
	{
		return P_0.GetAudioClip(P_1);
	}

	static AudioClip _202D_206F_202A_206F_206C_200B_200E_206C_200F_200F_200B_200F_202A_200B_200B_202C_200E_206A_200C_202A_200E_206F_202A_206C_202E_202D_206A_200C_202E_202C_206D_206B_206A_206F_202B_206E_202C_200E_200D_206D_202E(WWW P_0, bool P_1, bool P_2)
	{
		return P_0.GetAudioClip(P_1, P_2);
	}

	static AudioClip _200F_200C_202C_200E_200D_202A_202D_202A_206E_206F_206E_202B_200C_206C_206A_200D_202C_200D_200B_202A_200F_206F_200D_206E_202D_206E_202A_206B_200F_200C_206A_200F_206B_206D_202D_200C_206C_200F_200B_200E_202E(WWW P_0, bool P_1, bool P_2, AudioType P_3)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return P_0.GetAudioClip(P_1, P_2, P_3);
	}

	static AudioClip _200E_202C_202E_202E_200D_202A_206F_206E_200D_200C_200E_206F_206F_200C_206D_206A_200B_200E_200F_206F_206D_206B_202B_206F_200E_202C_200B_202D_202D_206D_206F_206F_200B_202A_200C_206B_206F_202D_202C_206A_202E(WWW P_0)
	{
		return P_0.GetAudioClipCompressed();
	}

	static AudioClip _202B_206B_202B_202D_202B_202B_200F_206D_202E_202B_200F_206E_206A_202E_206E_206C_200F_206D_206E_206C_206C_202D_202D_200E_200C_206A_200E_202E_206B_206A_206E_206B_206D_200E_200F_200F_202C_200C_206B_206A_202E(WWW P_0, bool P_1)
	{
		return P_0.GetAudioClipCompressed(P_1);
	}

	static AudioClip _206C_202D_200F_206F_202E_206C_200D_206F_206E_200F_206B_206D_200C_202D_206D_206C_200E_200E_202B_200E_200B_206A_202C_206B_202C_202D_200C_200E_206A_200D_206B_200F_200C_202C_202B_206C_206F_206C_202E_202A_202E(WWW P_0, bool P_1, AudioType P_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return P_0.GetAudioClipCompressed(P_1, P_2);
	}

	static void _206B_202E_206C_202B_202B_202D_200F_206B_200F_206A_206A_202E_200D_206C_202E_200F_206D_202C_200F_200B_206B_206D_200E_200D_206B_202D_200F_200C_206D_206E_202B_206E_200C_202E_202B_200B_202B_206D_200D_206A_202E(WWW P_0, Texture2D P_1)
	{
		P_0.LoadImageIntoTexture(P_1);
	}

	static WWW _206E_200E_206A_202A_206B_202E_206A_206E_202A_202C_200D_200D_206B_200D_200F_206B_200C_202B_206F_202D_200F_206A_206E_206D_206D_200B_202C_202D_206F_202D_206E_202A_200F_206F_206B_206B_206F_200C_206C_200E_202E(string P_0, Hash128 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return WWW.LoadFromCacheOrDownload(P_0, P_1);
	}

	static WWW _202D_200F_206C_200D_202A_200B_200B_202A_200C_200E_206C_206A_200E_200E_200F_206E_202C_206A_206F_206D_206C_202D_200B_202E_206F_206E_206D_206D_206A_202D_206C_202D_206D_200B_206E_206C_206E_200F_202B_202B_202E(string P_0, int P_1)
	{
		return WWW.LoadFromCacheOrDownload(P_0, P_1);
	}

	static WWW _200F_206F_202B_202C_202C_202D_202D_200F_202E_202D_200E_206B_202A_206B_206D_202C_202B_200B_202A_200D_200D_200F_206E_206A_206F_202C_206A_206C_206F_206D_200B_200E_206E_200F_200D_200C_202E_206D_202A_200F_202E(string P_0, Hash128 P_1, uint P_2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return WWW.LoadFromCacheOrDownload(P_0, P_1, P_2);
	}

	static WWW _206B_206E_206C_200E_200B_206A_206E_202A_202C_206E_200D_206C_200C_202D_206B_202C_202B_206A_202A_200D_200F_200E_206A_202A_206B_200E_202A_206D_202B_200E_206A_206B_202A_200F_202E_206A_202E_200D_206C_206C_202E(string P_0, int P_1, uint P_2)
	{
		return WWW.LoadFromCacheOrDownload(P_0, P_1, P_2);
	}
}
