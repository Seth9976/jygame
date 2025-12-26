using System.Xml.Serialization;

namespace JyGame;

[XmlType("param")]
public class ITParam
{
	[XmlAttribute("min")]
	public double Min = -1.0;

	[XmlAttribute("max")]
	public double Max = -1.0;

	[XmlAttribute("pool")]
	public string Pool = string.Empty;

	[XmlAttribute("min2")]
	public double Min2 = -1.0;

	[XmlAttribute("max2")]
	public double Max2 = -1.0;
}
