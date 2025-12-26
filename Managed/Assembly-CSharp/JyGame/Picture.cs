using System.Collections.Generic;
using System.Xml.Serialization;

namespace JyGame;

[XmlType("picture")]
public class Picture
{
	[XmlAttribute("name")]
	public string Name;

	[XmlAttribute("desc")]
	public string Desc;

	[XmlElement("condition")]
	public List<Condition> Conditions = new List<Condition>();

	[XmlIgnore]
	public bool IsActive
	{
		get
		{
			using (List<Condition>.Enumerator enumerator = Conditions.GetEnumerator())
			{
				while (true)
				{
					IL_0038:
					int num;
					int num2;
					if (enumerator.MoveNext())
					{
						num = -510074408;
						num2 = num;
					}
					else
					{
						num = -1899713719;
						num2 = num;
					}
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num ^ -409039969)) % 5)
						{
						case 0u:
							num = -510074408;
							continue;
						default:
							goto end_IL_0013;
						case 3u:
							break;
						case 2u:
							return false;
						case 4u:
						{
							int num4;
							if (!TriggerLogic.judge(enumerator.Current))
							{
								num = -1176661496;
								num4 = num;
							}
							else
							{
								num = -528258615;
								num4 = num;
							}
							continue;
						}
						case 1u:
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
			return true;
		}
	}
}
