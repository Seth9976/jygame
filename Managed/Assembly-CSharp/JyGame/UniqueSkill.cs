using System.Collections.Generic;
using System.Xml.Serialization;

namespace JyGame;

[XmlType("unique")]
public class UniqueSkill : BasePojo
{
	[XmlAttribute("name")]
	public string Name;

	[XmlAttribute("info")]
	public string Info;

	[XmlAttribute("hard")]
	public float Hard;

	[XmlAttribute("covertype")]
	public int CoverType;

	[XmlAttribute("coversize")]
	public int CoverSize;

	[XmlAttribute("castsize")]
	public int CastSize;

	[XmlAttribute("poweradd")]
	public float PowerAdd;

	[XmlAttribute("requirelv")]
	public int RequireLevel;

	[XmlAttribute("animation")]
	public string Animation;

	[XmlAttribute("cd")]
	public int CastCd;

	[XmlAttribute("costball")]
	public int CostBall;

	[XmlAttribute("audio")]
	public string Audio;

	[XmlAttribute("buff")]
	public string BuffsValue;

	[XmlAttribute]
	public string icon2 = string.Empty;

	[XmlAttribute]
	public int fullscreen;

	[XmlAttribute]
	public string roleanimation;

	[XmlAttribute]
	public float attacktime;

	[XmlAttribute]
	public string temp_animation;

	[XmlAttribute("audio2")]
	public string Audio2;

	[XmlAttribute("suit")]
	public float Suit;

	[XmlAttribute("tiaohe")]
	public int TiaoheValue = -1;

	[XmlAttribute("tiaohescale")]
	public float TiaoheScale;

	public override string PK => Name;

	[XmlIgnore]
	public IEnumerable<Buff> Buffs => Buff.Parse(BuffsValue);

	public bool Tiaohe => TiaoheValue == 1;
}
