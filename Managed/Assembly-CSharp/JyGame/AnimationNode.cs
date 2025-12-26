using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace JyGame;

[XmlType("animation")]
public class AnimationNode : BasePojo
{
	[XmlAttribute]
	public string name;

	[XmlElement("group")]
	public List<AnimationGroup> groups;

	public override string PK => name;

	public AnimationGroup GetGroup(string name)
	{
		List<AnimationGroup>.Enumerator enumerator = groups.GetEnumerator();
		try
		{
			AnimationGroup current = default(AnimationGroup);
			AnimationGroup result = default(AnimationGroup);
			while (true)
			{
				IL_008c:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -1762288430;
					num2 = num;
				}
				else
				{
					num = -828794925;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -2139265900)) % 7)
					{
					case 4u:
						num = -828794925;
						continue;
					default:
						goto end_IL_0013;
					case 6u:
					{
						int num4;
						int num5;
						if (_202C_206A_202A_202B_202D_206E_206A_206F_206B_202D_202E_202C_200D_206E_202E_202C_206A_206B_200C_202C_202E_202B_206A_200C_200F_202E_200E_206D_200B_200F_206A_206B_206C_206C_200E_202A_206E_202D_200B_206D_202E(current.name, name))
						{
							num4 = 880507532;
							num5 = num4;
						}
						else
						{
							num4 = 1668568709;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -810150246);
						continue;
					}
					case 0u:
						result = current;
						num = (int)(num3 * 1471675359) ^ -169607157;
						continue;
					case 1u:
						break;
					case 2u:
						current = enumerator.Current;
						num = -291329839;
						continue;
					case 5u:
						goto end_IL_0013;
					case 3u:
						return result;
					}
					goto IL_008c;
					continue;
					end_IL_0013:
					break;
				}
				break;
			}
		}
		finally
		{
			_202A_206D_200E_206F_202E_200E_200F_206F_200C_200F_206A_200E_202A_206E_202E_206E_206C_200E_202B_200F_200F_206C_206B_202C_200D_202E_206B_202C_206B_202C_202D_200B_202A_206F_206E_202D_200D_200D_202B_200F_202E((IDisposable)enumerator);
		}
		return null;
	}

	static bool _202C_206A_202A_202B_202D_206E_206A_206F_206B_202D_202E_202C_200D_206E_202E_202C_206A_206B_200C_202C_202E_202B_206A_200C_200F_202E_200E_206D_200B_200F_206A_206B_206C_206C_200E_202A_206E_202D_200B_206D_202E(string P_0, string P_1)
	{
		return P_0 == P_1;
	}

	static void _202A_206D_200E_206F_202E_200E_200F_206F_200C_200F_206A_200E_202A_206E_202E_206E_206C_200E_202B_200F_200F_206C_206B_202C_200D_202E_206B_202C_206B_202C_202D_200B_202A_206F_206E_202D_200D_200D_202B_200F_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}
}
