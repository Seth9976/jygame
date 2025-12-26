using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace JyGame;

[XmlType("aoyi")]
public class Aoyi : BasePojo
{
	private string _206E_200B_202E_200B_200C_202A_206B_206F_202A_206A_202C_202A_206E_206B_206B_202A_202E_206D_206C_200D_202B_206F_206A_202C_206C_206D_202A_202A_202B_200F_206B_202C_206E_206D_206C_200C_206E_206D_202E_202C_202E;

	[XmlAttribute("name")]
	public string Name;

	[XmlAttribute]
	public string start;

	[XmlAttribute]
	public int level;

	[XmlAttribute]
	public float probability;

	[XmlAttribute]
	public string buff;

	[XmlAttribute]
	public string animation;

	[XmlAttribute]
	public float addPower;

	[XmlElement("condition")]
	public List<AoyiCondition> Conditions = new List<AoyiCondition>();

	[XmlAttribute]
	public int fullscreen;

	[XmlIgnore]
	public float attacktime;

	[XmlAttribute("displayname")]
	public string DisplayName;

	public override string PK => _206E_200B_202E_200B_200C_202A_206B_206F_202A_206A_202C_202A_206E_206B_206B_202A_202E_206D_206C_200D_202B_206F_206A_202C_206C_206D_202A_202A_202B_200F_206B_202C_206E_206D_206C_200C_206E_206D_202E_202C_202E;

	[XmlIgnore]
	public IEnumerable<Buff> Buffs => Buff.Parse(buff);

	public Aoyi()
	{
		while (true)
		{
			int num = -1151287775;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -622392995)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0033;
				case 1u:
					return;
				}
				break;
				IL_0033:
				_206E_200B_202E_200B_200C_202A_206B_206F_202A_206A_202C_202A_206E_206B_206B_202A_202E_206D_206C_200D_202B_206F_206A_202C_206C_206D_202A_202A_202B_200F_206B_202C_206E_206D_206C_200C_206E_206D_202E_202C_202E = Guid.NewGuid().ToString();
				num = (int)(num2 * 1279362677) ^ -1887473239;
			}
		}
	}

	public float GetStartSkillHard()
	{
		Skill skill = ResourceManager.Get<Skill>(start);
		UniqueSkill uniqueSkill = default(UniqueSkill);
		while (true)
		{
			int num = -396215216;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -929174182)) % 6)
				{
				case 5u:
					break;
				case 2u:
				{
					int num4;
					int num5;
					if (skill != null)
					{
						num4 = 1344596987;
						num5 = num4;
					}
					else
					{
						num4 = 141928951;
						num5 = num4;
					}
					num = num4 ^ ((int)num2 * -521449246);
					continue;
				}
				case 3u:
				{
					uniqueSkill = ResourceManager.Get<UniqueSkill>(start);
					int num3;
					if (uniqueSkill != null)
					{
						num = -1951066258;
						num3 = num;
					}
					else
					{
						num = -107051276;
						num3 = num;
					}
					continue;
				}
				case 4u:
					return uniqueSkill.Hard;
				case 1u:
					return skill.Hard;
				default:
					return 100f;
				}
				break;
			}
		}
	}
}
