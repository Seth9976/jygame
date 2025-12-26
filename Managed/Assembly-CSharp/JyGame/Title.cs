using System.Collections.Generic;
using System.Xml.Serialization;

namespace JyGame;

[XmlType("title")]
public class Title : BasePojo
{
	[XmlAttribute("name")]
	public string Name;

	[XmlAttribute("info")]
	public string Info;

	[XmlAttribute("attack")]
	public float Attack;

	[XmlAttribute("defence")]
	public float Defence;

	[XmlAttribute("hard")]
	public float Hard;

	[XmlAttribute("aoyiprobability")]
	public float AoyiProbabilityAdd;

	[XmlAttribute("aoyipower")]
	public float AoyiPowerAdd;

	[XmlAttribute]
	public string icon = string.Empty;

	[XmlElement("trigger")]
	public List<Trigger> Triggers = new List<Trigger>();

	[XmlAttribute("isnpc")]
	public bool IsNpc;

	public override string PK => Name;

	public override void InitBind()
	{
	}
}
