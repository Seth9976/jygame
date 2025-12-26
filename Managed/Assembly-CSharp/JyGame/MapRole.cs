using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace JyGame;

[XmlType("maprole")]
public class MapRole
{
	[XmlAttribute]
	public string description;

	[XmlElement("event")]
	public List<MapEvent> Events = new List<MapEvent>();

	[XmlAttribute]
	public string pic;

	[XmlAttribute]
	public string name;

	[XmlIgnore]
	public bool IsActive => GetActiveEvent() != null;

	[XmlIgnore]
	public string Name
	{
		get
		{
			Role role = RuntimeData.Instance.GetRole(name);
			while (true)
			{
				int num = -968244431;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1826655453)) % 6)
					{
					case 4u:
						break;
					case 2u:
					{
						int num4;
						int num5;
						if (role == null)
						{
							num4 = -435830462;
							num5 = num4;
						}
						else
						{
							num4 = -2052826450;
							num5 = num4;
						}
						num = num4 ^ (int)(num2 * 332807064);
						continue;
					}
					case 1u:
						role = ResourceManager.Get<Role>(name);
						num = (int)(num2 * 653389077) ^ -1858448837;
						continue;
					case 5u:
						return role.Name;
					case 3u:
					{
						int num3;
						if (role != null)
						{
							num = -1131635930;
							num3 = num;
						}
						else
						{
							num = -1808236429;
							num3 = num;
						}
						continue;
					}
					default:
					{
						string text = name;
						char[] array = new char[10];
						_206C_202D_200F_206F_202A_206C_206F_206D_202E_202E_200E_202A_202D_206A_206D_200C_200F_206A_202C_206B_206D_206F_202B_206E_206A_206E_200F_206C_200E_206C_202E_202D_200D_202E_200C_202D_200D_200B_206E_200D_202E((Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						return _206C_206C_202E_202D_206F_206F_206D_200D_206E_200C_206F_206E_202C_200B_200B_200C_200D_202B_202A_200B_202E_206D_206F_206D_200B_206D_200C_202E_202B_200C_202E_200B_206E_206B_206A_200E_202A_202E_202E_202D_202E(text, array);
					}
					}
					break;
				}
			}
		}
		set
		{
			name = value;
		}
	}

	[XmlIgnore]
	public string roleKey => name;

	public MapEvent GetActiveEvent()
	{
		List<MapEvent>.Enumerator enumerator = Events.GetEnumerator();
		try
		{
			MapEvent current = default(MapEvent);
			while (true)
			{
				IL_0038:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -642434090;
					num2 = num;
				}
				else
				{
					num = -173875383;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -1147389282)) % 5)
					{
					case 3u:
						num = -173875383;
						continue;
					default:
						goto end_IL_0013;
					case 0u:
						break;
					case 1u:
						return current;
					case 4u:
					{
						current = enumerator.Current;
						int num4;
						if (!current.IsActive)
						{
							num = -844090044;
							num4 = num;
						}
						else
						{
							num = -678188723;
							num4 = num;
						}
						continue;
					}
					case 2u:
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
			_202D_202C_202E_206B_200C_202B_202A_206C_200C_202B_206E_202B_202C_202A_202D_202C_202D_206F_200E_200B_206E_206E_202E_206E_206A_206F_200D_200C_202A_206C_206D_200D_200E_202D_202B_202B_202B_200C_202C_206F_202E((IDisposable)enumerator);
		}
		return null;
	}

	static void _202D_202C_202E_206B_200C_202B_202A_206C_200C_202B_206E_202B_202C_202A_202D_202C_202D_206F_200E_200B_206E_206E_202E_206E_206A_206F_200D_200C_202A_206C_206D_200D_200E_202D_202B_202B_202B_200C_202C_206F_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}

	static void _206C_202D_200F_206F_202A_206C_206F_206D_202E_202E_200E_202A_202D_206A_206D_200C_200F_206A_202C_206B_206D_206F_202B_206E_206A_206E_200F_206C_200E_206C_202E_202D_200D_202E_200C_202D_200D_200B_206E_200D_202E(Array P_0, RuntimeFieldHandle P_1)
	{
		RuntimeHelpers.InitializeArray(P_0, P_1);
	}

	static string _206C_206C_202E_202D_206F_206F_206D_200D_206E_200C_206F_206E_202C_200B_200B_200C_200D_202B_202A_200B_202E_206D_206F_206D_200B_206D_200C_202E_202B_200C_202E_200B_206E_206B_206A_200E_202A_202E_202E_202D_202E(string P_0, char[] P_1)
	{
		return P_0.TrimEnd(P_1);
	}
}
