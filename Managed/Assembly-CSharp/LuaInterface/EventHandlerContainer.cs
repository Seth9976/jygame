using System;
using System.Collections.Generic;

namespace LuaInterface;

internal class EventHandlerContainer : IDisposable
{
	private Dictionary<Delegate, RegisterEventHandler> dict = new Dictionary<Delegate, RegisterEventHandler>();

	public void Add(Delegate handler, RegisterEventHandler eventInfo)
	{
		dict.Add(handler, eventInfo);
	}

	public void Remove(Delegate handler)
	{
		bool flag = dict.Remove(handler);
	}

	public void Dispose()
	{
		Dictionary<Delegate, RegisterEventHandler>.Enumerator enumerator = dict.GetEnumerator();
		try
		{
			KeyValuePair<Delegate, RegisterEventHandler> current = default(KeyValuePair<Delegate, RegisterEventHandler>);
			while (true)
			{
				IL_0038:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -863395802;
					num2 = num;
				}
				else
				{
					num = -1687681035;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -318524716)) % 5)
					{
					case 0u:
						num = -863395802;
						continue;
					default:
						goto end_IL_0013;
					case 2u:
						break;
					case 3u:
						current.Value.RemovePending(current.Key);
						num = ((int)num3 * -306097514) ^ 0x73141489;
						continue;
					case 1u:
						current = enumerator.Current;
						num = -1673397415;
						continue;
					case 4u:
						goto end_IL_0013;
					}
					goto IL_0038;
					continue;
					end_IL_0013:
					break;
				}
				break;
			}
		}
		finally
		{
			_202D_202C_200D_200F_202D_202A_206E_202C_202C_202E_202E_206B_200C_206F_206F_202B_206E_202E_202C_202B_200E_200C_206D_206A_202D_206A_202C_202B_200F_206F_200B_200F_206E_200B_202D_202B_206D_206E_200C_200F_202E((IDisposable)enumerator);
		}
		dict.Clear();
	}

	static void _202D_202C_200D_200F_202D_202A_206E_202C_202C_202E_202E_206B_200C_206F_206F_202B_206E_202E_202C_202B_200E_200C_206D_206A_202D_206A_202C_202B_200F_206F_200B_200F_206E_200B_202D_202B_206D_206E_200C_200F_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}
}
