using System.Xml.Serialization;

namespace JyGame;

[XmlType("image")]
public class AnimationImage
{
	[XmlAttribute]
	public int anchorx;

	[XmlAttribute]
	public int anchory;

	[XmlAttribute]
	public int w;

	[XmlAttribute]
	public int h;

	public override string ToString()
	{
		return _200E_202B_202D_206F_206B_206B_200C_202C_200E_202C_202B_206F_202C_206F_200E_202A_206F_206A_202D_206E_206C_206B_202A_206A_206E_206D_202D_206C_206A_202D_206F_200F_206B_206B_206D_202A_206F_206F_206C_206A_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2543509018u), new object[4] { anchorx, anchory, w, h });
	}

	static string _200E_202B_202D_206F_206B_206B_200C_202C_200E_202C_202B_206F_202C_206F_200E_202A_206F_206A_202D_206E_206C_206B_202A_206A_206E_206D_202D_206C_206A_202D_206F_200F_206B_206B_206D_202A_206F_206F_206C_206A_202E(string P_0, object[] P_1)
	{
		return string.Format(P_0, P_1);
	}
}
