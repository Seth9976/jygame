using System;
using System.Collections.Generic;
using UnityEngine;

namespace Umeng;

public class Analytics
{
	private static string _206E_200D_202C_200D_202D_202B_206B_200F_206A_200B_200E_206E_206A_206A_200B_202C_206E_202C_206F_202D_200F_202D_206E_202D_202B_206F_202E_206E_206B_202A_202E_202C_200B_200E_202A_200F_202D_206E_206E_206B_202E;

	private static string _200F_200D_202D_206C_200E_206E_206D_202E_202A_206A_206A_206B_206E_206B_202C_206C_206B_202E_202E_200D_200F_206A_202B_202D_202C_206D_202C_202B_206C_206F_200C_202B_200C_206A_206F_202B_200F_200E_206F_202E_202E;

	public static string AppKey => _206E_200D_202C_200D_202D_202B_206B_200F_206A_200B_200E_206E_206A_206A_200B_202C_206E_202C_206F_202D_200F_202D_206E_202D_202B_206F_202E_206E_206B_202A_202E_202C_200B_200E_202A_200F_202D_206E_206E_206B_202E;

	public static string ChannelId => _200F_200D_202D_206C_200E_206E_206D_202E_202A_206A_206A_206B_206E_206B_202C_206C_206B_202E_202E_200D_200F_206A_202B_202D_202C_206D_202C_202B_206C_206F_200C_202B_200C_206A_206F_202B_200F_200E_206F_202E_202E;

	public static void StartWithAppKeyAndChannelId(string appKey, string channelId)
	{
	}

	public static void SetLogEnabled(bool value)
	{
	}

	public static void Event(string eventId)
	{
	}

	public static void Event(string eventId, string label)
	{
	}

	public static void Event(string eventId, Dictionary<string, string> attributes)
	{
	}

	public static void EventBegin(string eventId)
	{
	}

	public static void EventEnd(string eventId)
	{
	}

	public static void EventBegin(string eventId, string label)
	{
	}

	public static void EventEnd(string eventId, string label)
	{
	}

	public static void EventBeginWithPrimarykeyAndAttributes(string eventId, string primaryKey, Dictionary<string, string> attributes)
	{
	}

	public static void EventEndWithPrimarykey(string eventId, string primaryKey)
	{
	}

	public static void EventDuration(string eventId, int milliseconds)
	{
	}

	public static void EventDuration(string eventId, string label, int milliseconds)
	{
	}

	public static void EventDuration(string eventId, Dictionary<string, string> attributes, int milliseconds)
	{
	}

	public static void PageBegin(string pageName)
	{
	}

	public static void PageEnd(string pageName)
	{
	}

	public static void Event(string eventId, Dictionary<string, string> attributes, int value)
	{
		try
		{
			if (attributes == null)
			{
				goto IL_0003;
			}
			goto IL_0074;
			IL_0003:
			int num = 2123032374;
			goto IL_0008;
			IL_0008:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6319C6C1)) % 10)
				{
				case 6u:
					break;
				default:
					return;
				case 2u:
					num = ((int)num2 * -894991127) ^ 0x491D2D3A;
					continue;
				case 9u:
					attributes.Remove(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1358000628u));
					num = ((int)num2 * -516780862) ^ -1555845764;
					continue;
				case 7u:
					goto IL_0074;
				case 4u:
					Event(eventId, attributes);
					num = ((int)num2 * -2052175184) ^ 0x38AC3AA6;
					continue;
				case 1u:
					attributes = new Dictionary<string, string>();
					num = (int)((num2 * 903157355) ^ 0x39B5C40B);
					continue;
				case 8u:
					attributes.Add(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(898152678u), value.ToString());
					num = 491132493;
					continue;
				case 3u:
					Event(eventId, attributes);
					num = (int)((num2 * 1713728139) ^ 0x31C465A0);
					continue;
				case 0u:
					attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(898152678u)] = value.ToString();
					num = (int)(num2 * 40717040) ^ -827723494;
					continue;
				case 5u:
					return;
				}
				break;
			}
			goto IL_0003;
			IL_0074:
			int num3;
			if (attributes.ContainsKey(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4093448081u)))
			{
				num = 1023203201;
				num3 = num;
			}
			else
			{
				num = 1435268273;
				num3 = num;
			}
			goto IL_0008;
		}
		catch (Exception)
		{
		}
	}

	public static void UpdateOnlineConfig()
	{
	}

	public static string GetConfigParamForKey(string key)
	{
		return null;
	}

	public static string GetDeviceInfo()
	{
		return null;
	}

	public static void SetLogEncryptEnabled(bool value)
	{
	}

	public static void SetLatency(int value)
	{
	}

	private static void CreateUmengManger()
	{
		GameObject val = _206F_200D_200F_200C_200D_206F_202D_206E_202C_206B_202D_206A_206E_200E_202C_200C_200D_206E_200F_202A_202A_202C_202E_202C_202B_200D_202B_200D_202C_206A_202B_206B_206D_206B_202C_200E_200F_200E_202B_200F_202E();
		while (true)
		{
			int num = 1816491325;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4B5BF47D)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_0028;
				case 2u:
					return;
				}
				break;
				IL_0028:
				val.AddComponent<UmengManager>();
				_200E_200E_206A_206C_202A_202E_206C_206D_200C_206D_200B_206F_206D_200D_200F_202A_206C_200F_206E_206D_206B_202E_206A_202A_206D_202B_206D_202A_202D_206D_200F_206B_202D_206E_206D_206B_206D_200B_202A_202E_202E((Object)(object)val, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3003984157u));
				num = ((int)num2 * -606537097) ^ -613009482;
			}
		}
	}

	static GameObject _206F_200D_200F_200C_200D_206F_202D_206E_202C_206B_202D_206A_206E_200E_202C_200C_200D_206E_200F_202A_202A_202C_202E_202C_202B_200D_202B_200D_202C_206A_202B_206B_206D_206B_202C_200E_200F_200E_202B_200F_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new GameObject();
	}

	static void _200E_200E_206A_206C_202A_202E_206C_206D_200C_206D_200B_206F_206D_200D_200F_202A_206C_200F_206E_206D_206B_202E_206A_202A_206D_202B_206D_202A_202D_206D_200F_206B_202D_206E_206D_206B_206D_200B_202A_202E_202E(Object P_0, string P_1)
	{
		P_0.name = P_1;
	}
}
