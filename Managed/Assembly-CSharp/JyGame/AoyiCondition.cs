using System.Xml.Serialization;

namespace JyGame;

[XmlType("condition")]
public class AoyiCondition
{
	[XmlAttribute]
	public string type;

	[XmlAttribute]
	public string value;

	[XmlAttribute("level")]
	public string levelValue;

	[XmlIgnore]
	public int level
	{
		get
		{
			if (_200D_202A_206D_200F_202E_206B_202B_206B_206A_206D_206F_206A_200C_200C_206C_202B_202C_200F_202D_206E_200E_202A_202C_202E_200B_202C_200B_200F_206B_206D_200D_206C_206E_206A_202D_206E_200B_200F_202A_202E_202E(levelValue))
			{
				while (true)
				{
					uint num;
					switch ((num = 1859195008u) % 3)
					{
					case 2u:
						continue;
					case 1u:
						return 0;
					}
					break;
				}
			}
			return int.Parse(levelValue);
		}
	}

	static bool _200D_202A_206D_200F_202E_206B_202B_206B_206A_206D_206F_206A_200C_200C_206C_202B_202C_200F_202D_206E_200E_202A_202C_202E_200B_202C_200B_200F_206B_206D_200D_206C_206E_206A_202D_206E_200B_200F_202A_202E_202E(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}
}
