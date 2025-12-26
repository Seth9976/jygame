using System.Collections.Generic;
using System.Xml.Serialization;

namespace JyGame;

[XmlType("story")]
public class BattleStory
{
	[XmlAttribute("name")]
	public string Name;

	[XmlAttribute("repeat")]
	public int Repeat;

	[XmlElement("condition")]
	public List<Condition> Conditions = new List<Condition>();

	[XmlElement("action")]
	public List<StoryAction> Actions = new List<StoryAction>();

	private int _202D_202B_206E_200D_200D_200B_202E_200E_200E_202B_200B_206B_206D_206B_206A_206D_202B_200F_200F_202B_206C_200D_206D_200B_206D_202C_200E_200E_202D_202C_200B_206C_200F_206C_202A_202A_206E_206C_202E_206E_202E;

	[XmlIgnore]
	public bool IsActive
	{
		get
		{
			if (_202D_202B_206E_200D_200D_200B_202E_200E_200E_202B_200B_206B_206D_206B_206A_206D_202B_200F_200F_202B_206C_200D_206D_200B_206D_202C_200E_200E_202D_202C_200B_206C_200F_206C_202A_202A_206E_206C_202E_206E_202E > Repeat)
			{
				while (true)
				{
					uint num;
					switch ((num = 1941357932u) % 3)
					{
					case 0u:
						continue;
					case 2u:
						return false;
					}
					break;
				}
			}
			using (List<Condition>.Enumerator enumerator = Conditions.GetEnumerator())
			{
				while (true)
				{
					IL_0079:
					int num2;
					int num3;
					if (enumerator.MoveNext())
					{
						num2 = 769203705;
						num3 = num2;
					}
					else
					{
						num2 = 831876075;
						num3 = num2;
					}
					while (true)
					{
						uint num;
						switch ((num = (uint)(num2 ^ 0x24089DA9)) % 5)
						{
						case 3u:
							num2 = 769203705;
							continue;
						default:
							goto end_IL_0054;
						case 2u:
							break;
						case 4u:
							return false;
						case 1u:
						{
							int num4;
							if (!TriggerLogic.judgeBattle(enumerator.Current))
							{
								num2 = 235678472;
								num4 = num2;
							}
							else
							{
								num2 = 1395881565;
								num4 = num2;
							}
							continue;
						}
						case 0u:
							goto end_IL_0054;
						}
						goto IL_0079;
						continue;
						end_IL_0054:
						break;
					}
					break;
				}
			}
			_202D_202B_206E_200D_200D_200B_202E_200E_200E_202B_200B_206B_206D_206B_206A_206D_202B_200F_200F_202B_206C_200D_206D_200B_206D_202C_200E_200E_202D_202C_200B_206C_200F_206C_202A_202A_206E_206C_202E_206E_202E++;
			return true;
		}
	}

	internal void Init()
	{
		if (_206B_206B_206E_200F_202D_200F_206D_200B_200F_206F_200E_206A_206B_202B_202E_206D_202C_200B_200B_206D_200B_206F_202C_206F_206A_202B_206E_200B_200E_202A_200D_202B_206D_206C_206B_202A_206E_200C_202A_200C_202E(Name))
		{
			while (true)
			{
				int num = -506121485;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -2117944070)) % 4)
					{
					case 2u:
						break;
					case 1u:
						_202D_202B_206E_200D_200D_200B_202E_200E_200E_202B_200B_206B_206D_206B_206A_206D_202B_200F_200F_202B_206C_200D_206D_200B_206D_202C_200E_200E_202D_202C_200B_206C_200F_206C_202A_202A_206E_206C_202E_206E_202E = int.MaxValue;
						num = (int)(num2 * 1299030955) ^ -277049359;
						continue;
					case 0u:
						return;
					default:
						goto end_IL_000d;
					}
					break;
				}
				continue;
				end_IL_000d:
				break;
			}
		}
		_202D_202B_206E_200D_200D_200B_202E_200E_200E_202B_200B_206B_206D_206B_206A_206D_202B_200F_200F_202B_206C_200D_206D_200B_206D_202C_200E_200E_202D_202C_200B_206C_200F_206C_202A_202A_206E_206C_202E_206E_202E = 0;
	}

	static bool _206B_206B_206E_200F_202D_200F_206D_200B_200F_206F_200E_206A_206B_202B_202E_206D_202C_200B_200B_206D_200B_206F_202C_206F_206A_202B_206E_200B_200E_202A_200D_202B_206D_206C_206B_202A_206E_200C_202A_200C_202E(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}
}
