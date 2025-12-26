using System.Xml.Serialization;

namespace JyGame;

[XmlType("globalsave")]
public class GlobalSave : BasePojo
{
	[XmlElement("n")]
	public string[] Nicks;

	[XmlElement("kv")]
	public GameSaveKeyValues[] KeyValues;

	[XmlElement("s")]
	public GlobalSkillMaxLevel[] SkillMaxLevels;

	[XmlIgnore]
	public override string PK => global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(538228243u);
}
