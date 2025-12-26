using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace JyGame;

[XmlType("location")]
public class MapLocation : MapRole
{
	[XmlAttribute]
	public int x;

	[XmlAttribute]
	public int y;

	[XmlAttribute]
	public double time;

	[XmlIgnore]
	public int X => x * 1140 * 2 / 800 + 18;

	[XmlIgnore]
	public int Y => -y * 640 * 2 / 600 - 8;

	public string getName()
	{
		if (_200B_200C_200D_206A_206F_200D_206A_202D_206F_202D_202E_200E_202E_206A_202B_200B_206D_202C_200E_200E_202D_206E_200E_206C_202D_200D_206B_206A_206B_200D_200B_202B_206C_206D_202D_206B_206E_206F_206C_200D_202E(name, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(831785341u)))
		{
			string key = default(string);
			Role role = default(Role);
			while (true)
			{
				int num = 1596556733;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x64569091)) % 8)
					{
					case 0u:
						break;
					case 4u:
						key = _200C_206B_200F_200F_200C_206C_200C_206E_206E_200B_200C_202C_202A_202A_200F_202A_202A_200C_206D_200C_206D_200B_202E_206A_206B_206C_202D_200F_202D_206B_206C_206F_206D_206C_202B_200C_200C_206D_206C_206E_202E(name, 1, _202C_202A_206C_200E_202B_200E_200E_206F_202B_200E_206F_202D_200E_206B_206D_206C_206A_200E_202E_200B_200D_202D_206C_202E_200E_202B_202B_202E_206C_206E_200D_206D_202C_206A_206B_206E_202C_206B_200D_202D_202E(name) - 1);
						num = (int)(num2 * 484646139) ^ -1299503697;
						continue;
					case 5u:
						role = ResourceManager.Get<Role>(key);
						num = (int)((num2 * 1578342425) ^ 0x276EC74A);
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (role != null)
						{
							num3 = 1461124860;
							num4 = num3;
						}
						else
						{
							num3 = 1931431407;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 1766276555);
						continue;
					}
					case 2u:
						role = RuntimeData.Instance.GetRole(key);
						num = ((int)num2 * -177848509) ^ -82123034;
						continue;
					case 7u:
						return role.Name;
					case 6u:
						goto IL_00e8;
					default:
						goto end_IL_001a;
					}
					break;
					IL_00e8:
					int num5;
					if (role == null)
					{
						num = 12704674;
						num5 = num;
					}
					else
					{
						num = 1800764934;
						num5 = num;
					}
				}
				continue;
				end_IL_001a:
				break;
			}
		}
		return name;
	}

	public string GetImageKey()
	{
		List<MapEvent>.Enumerator enumerator = Events.GetEnumerator();
		try
		{
			MapEvent current = default(MapEvent);
			string image = default(string);
			while (true)
			{
				IL_008b:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -1055981814;
					num2 = num;
				}
				else
				{
					num = -1765316399;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -326190532)) % 8)
					{
					case 4u:
						num = -1055981814;
						continue;
					default:
						goto end_IL_0013;
					case 0u:
					{
						int num6;
						int num7;
						if (!_200B_206C_200B_206E_202D_206B_206C_206A_202C_206D_200E_200B_206B_200C_202B_200B_206E_206D_206E_206B_202C_206B_206F_202A_202A_202B_202C_200C_206F_206C_206D_206A_200C_200F_206E_202D_206E_206D_202C_206B_202E(current.type, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(117271931u)))
						{
							num6 = 985921613;
							num7 = num6;
						}
						else
						{
							num6 = 759734974;
							num7 = num6;
						}
						num = num6 ^ (int)(num3 * 1927932733);
						continue;
					}
					case 1u:
						break;
					case 3u:
					{
						int num4;
						int num5;
						if (_200B_206C_206B_200C_206B_202C_202D_202A_206A_206E_206F_202B_206C_202B_206B_202E_200F_206F_202D_206B_206B_202E_202C_202E_202C_200E_200D_206A_202C_200E_202E_206D_206C_206F_200F_202A_202B_202D_206B_200D_202E(current.image))
						{
							num4 = 370250141;
							num5 = num4;
						}
						else
						{
							num4 = 1757446508;
							num5 = num4;
						}
						num = num4 ^ (int)(num3 * 145363920);
						continue;
					}
					case 2u:
						image = current.image;
						num = (int)(num3 * 1141247217) ^ -1370685655;
						continue;
					case 6u:
						current = enumerator.Current;
						num = -1528053001;
						continue;
					case 5u:
						goto end_IL_0013;
					case 7u:
						return image;
					}
					goto IL_008b;
					continue;
					end_IL_0013:
					break;
				}
				break;
			}
		}
		finally
		{
			_202A_206E_206D_206D_202B_206E_200E_206C_202A_206E_202B_206C_206E_200E_200E_206E_206E_202A_202A_206E_202B_202E_200F_200D_200D_206D_206E_202B_206C_206B_200B_202B_200B_206E_206E_202B_202D_202D_206F_206C_202E((IDisposable)enumerator);
		}
		return string.Empty;
	}

	static bool _200B_200C_200D_206A_206F_200D_206A_202D_206F_202D_202E_200E_202E_206A_202B_200B_206D_202C_200E_200E_202D_206E_200E_206C_202D_200D_206B_206A_206B_200D_200B_202B_206C_206D_202D_206B_206E_206F_206C_200D_202E(string P_0, string P_1)
	{
		return P_0.StartsWith(P_1);
	}

	static int _202C_202A_206C_200E_202B_200E_200E_206F_202B_200E_206F_202D_200E_206B_206D_206C_206A_200E_202E_200B_200D_202D_206C_202E_200E_202B_202B_202E_206C_206E_200D_206D_202C_206A_206B_206E_202C_206B_200D_202D_202E(string P_0)
	{
		return P_0.Length;
	}

	static string _200C_206B_200F_200F_200C_206C_200C_206E_206E_200B_200C_202C_202A_202A_200F_202A_202A_200C_206D_200C_206D_200B_202E_206A_206B_206C_202D_200F_202D_206B_206C_206F_206D_206C_202B_200C_200C_206D_206C_206E_202E(string P_0, int P_1, int P_2)
	{
		return P_0.Substring(P_1, P_2);
	}

	static bool _200B_206C_206B_200C_206B_202C_202D_202A_206A_206E_206F_202B_206C_202B_206B_202E_200F_206F_202D_206B_206B_202E_202C_202E_202C_200E_200D_206A_202C_200E_202E_206D_206C_206F_200F_202A_202B_202D_206B_200D_202E(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}

	static bool _200B_206C_200B_206E_202D_206B_206C_206A_202C_206D_200E_200B_206B_200C_202B_200B_206E_206D_206E_206B_202C_206B_206F_202A_202A_202B_202C_200C_206F_206C_206D_206A_200C_200F_206E_202D_206E_206D_202C_206B_202E(string P_0, string P_1)
	{
		return P_0 == P_1;
	}

	static void _202A_206E_206D_206D_202B_206E_200E_206C_202A_206E_202B_206C_206E_200E_200E_206E_206E_202A_202A_206E_202B_202E_200F_200D_200D_206D_206E_202B_206C_206B_200B_202B_200B_206E_206E_202B_202D_202D_206F_206C_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}
}
