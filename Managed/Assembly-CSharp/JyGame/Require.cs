using System.Xml.Serialization;

namespace JyGame;

[XmlType("require")]
public class Require : BasePojo
{
	[XmlAttribute("name")]
	public string Name;

	[XmlAttribute("argvs")]
	public string ArgvsString;

	public override string PK => _206D_206A_200B_202A_206B_206A_206E_206A_202D_206C_206C_200F_206F_202A_202A_200D_202A_206D_206A_200F_206D_202A_202B_206E_202C_202D_200E_206F_202E_206C_200C_200D_206B_200F_200B_200D_206A_206D_202C_206A_202E(Name, ArgvsString);

	static string _206D_206A_200B_202A_206B_206A_206E_206A_202D_206C_206C_200F_206F_202A_202A_200D_202A_206D_206A_200F_206D_202A_202B_206E_202C_202D_200E_206F_202E_206C_200C_200D_206B_200F_200B_200D_206A_206D_202C_206A_202E(string P_0, string P_1)
	{
		return P_0 + P_1;
	}
}
