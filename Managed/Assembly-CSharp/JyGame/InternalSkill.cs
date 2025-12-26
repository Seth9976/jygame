using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace JyGame;

[XmlType("internal_skill")]
public class InternalSkill : BasePojo
{
	[XmlAttribute("name")]
	public string Name;

	[XmlAttribute("info")]
	public string Info;

	[XmlAttribute("yin")]
	public int Yin;

	[XmlAttribute("yang")]
	public int Yang;

	[XmlAttribute("attack")]
	public float Attack;

	[XmlAttribute("critical")]
	public float Critical;

	[XmlAttribute("defence")]
	public float Defence;

	[XmlAttribute("hard")]
	public float Hard;

	[XmlAttribute]
	public string icon = string.Empty;

	[XmlElement("trigger")]
	public List<Trigger> Triggers = new List<Trigger>();

	[XmlElement("unique")]
	public List<UniqueSkill> UniqueSkills = new List<UniqueSkill>();

	[XmlAttribute("isnpc")]
	public bool IsNpc;

	public override string PK => Name;

	public override void InitBind()
	{
		List<UniqueSkill>.Enumerator enumerator = UniqueSkills.GetEnumerator();
		try
		{
			UniqueSkill current = default(UniqueSkill);
			while (true)
			{
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 1505475398;
					num2 = num;
				}
				else
				{
					num = 750697880;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x52A91D59)) % 5)
					{
					case 0u:
						num = 750697880;
						continue;
					default:
						return;
					case 4u:
						break;
					case 3u:
						ResourceManager.Add<UniqueSkill>(current.PK, current);
						num = (int)(num3 * 1688792956) ^ -1412337491;
						continue;
					case 2u:
						current = enumerator.Current;
						num = 565979963;
						continue;
					case 1u:
						return;
					}
					break;
				}
			}
		}
		finally
		{
			_206D_202A_200B_206B_200F_206D_200F_206F_206B_200F_202B_202E_206A_202B_206D_202A_202B_202D_202B_206E_202A_206C_206F_200B_200F_202D_200C_200B_206B_202E_206A_202B_206E_200C_202E_202D_202D_202C_206A_202A_202E((IDisposable)enumerator);
		}
	}

	static void _206D_202A_200B_206B_200F_206D_200F_206F_206B_200F_202B_202E_206A_202B_206D_202A_202B_202D_202B_206E_202A_206C_206F_200B_200F_202D_200C_200B_206B_202E_206A_202B_206E_200C_202E_202D_202D_202C_206A_202A_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}
}
