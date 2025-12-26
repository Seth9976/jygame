using System.Collections.Generic;
using System.Xml.Serialization;

namespace JyGame;

[XmlType("special_skill")]
public class SpecialSkill : BasePojo
{
	[XmlAttribute("name")]
	public string Name;

	[XmlAttribute("info")]
	public string Info;

	[XmlAttribute("castsize")]
	public int CastSize;

	[XmlAttribute("coversize")]
	public int CoverSize;

	[XmlAttribute("audio")]
	public string Audio;

	[XmlAttribute("covertype")]
	public int CoverType;

	[XmlAttribute("animation")]
	public string Animation;

	[XmlAttribute("costMp")]
	public int CostMp;

	[XmlAttribute("cd")]
	public int Cd;

	[XmlAttribute("costball")]
	public int CostBall;

	[XmlAttribute("hitself")]
	public int HitSelfValue = -1;

	[XmlAttribute("buff")]
	public string BuffValue;

	[XmlAttribute]
	public string icon = string.Empty;

	[XmlAttribute]
	public int fullscreen;

	[XmlAttribute]
	public float attacktime;

	[XmlAttribute("audio2")]
	public string Audio2;

	[XmlAttribute("isnpc")]
	public bool IsNpc;

	public override string PK => Name;

	public bool HitSelf => HitSelfValue == 1;

	[XmlIgnore]
	public IEnumerable<Buff> Buffs => Buff.Parse(BuffValue);
}
