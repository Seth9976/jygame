using System.Collections.Generic;
using System.Xml.Serialization;

namespace JyGame;

[XmlType("music")]
public class Music
{
	[XmlAttribute("name")]
	public string Name;

	[XmlAttribute("mode")]
	public int PlayMode;

	[XmlElement("condition")]
	public List<Condition> Conditions = new List<Condition>();

	[XmlIgnore]
	public bool IsActive
	{
		get
		{
			using (List<Condition>.Enumerator enumerator = Conditions.GetEnumerator())
			{
				bool result = default(bool);
				while (true)
				{
					IL_006c:
					int num;
					int num2;
					if (!enumerator.MoveNext())
					{
						num = 938454794;
						num2 = num;
					}
					else
					{
						num = 840767271;
						num2 = num;
					}
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num ^ 0x4259ACFB)) % 6)
						{
						case 4u:
							num = 840767271;
							continue;
						default:
							goto end_IL_0013;
						case 2u:
						{
							int num4;
							if (TriggerLogic.judge(enumerator.Current))
							{
								num = 1107142656;
								num4 = num;
							}
							else
							{
								num = 1297298370;
								num4 = num;
							}
							continue;
						}
						case 1u:
							result = false;
							num = (int)((num3 * 1109386098) ^ 0x65382067);
							continue;
						case 5u:
							break;
						case 3u:
							goto end_IL_0013;
						case 0u:
							return result;
						}
						goto IL_006c;
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
