using System;
using System.Xml.Serialization;

namespace JyGame;

[XmlType]
public class GameSaveRoleSkill
{
	[XmlAttribute]
	public int equipped;

	[XmlAttribute]
	public int level;

	[XmlAttribute]
	public int exp;

	[XmlAttribute]
	public string name;

	public SkillInstance GenerateSkill()
	{
		SkillInstance obj = new SkillInstance
		{
			equipped = equipped,
			Exp = exp,
			level = _206E_202D_206E_206A_206C_200E_206A_200C_200B_202A_202A_206A_206A_206B_206C_202B_200F_202B_202A_202C_206E_202C_202D_206D_206B_200B_202B_202D_200B_200B_206F_200E_200B_206D_202C_200B_202A_206A_202A_200E_202E(level, CommonSettings.MAX_SKILL_LEVEL)
		};
		obj.level2 = 0f - (float)obj.level;
		obj.name = name;
		obj.RefreshUniquSkills();
		return obj;
	}

	public InternalSkillInstance GenerateInternalSkill()
	{
		InternalSkillInstance obj = new InternalSkillInstance
		{
			equipped = equipped,
			Exp = exp,
			level = _206E_202D_206E_206A_206C_200E_206A_200C_200B_202A_202A_206A_206A_206B_206C_202B_200F_202B_202A_202C_206E_202C_202D_206D_206B_200B_202B_202D_200B_200B_206F_200E_200B_206D_202C_200B_202A_206A_202A_200E_202E(level, CommonSettings.MAX_INTERNALSKILL_LEVEL)
		};
		obj.level2 = 0f - (float)obj.level;
		obj.name = name;
		obj.RefreshUniquSkills();
		return obj;
	}

	public SpecialSkillInstance GenerateSpecialSkill()
	{
		SpecialSkillInstance specialSkillInstance = new SpecialSkillInstance();
		specialSkillInstance.equipped = equipped;
		specialSkillInstance.name = name;
		return specialSkillInstance;
	}

	public static GameSaveRoleSkill Create(SkillInstance s)
	{
		GameSaveRoleSkill gameSaveRoleSkill = new GameSaveRoleSkill();
		while (true)
		{
			int num = 1719399171;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x150F7EAD)) % 4)
				{
				case 0u:
					break;
				case 2u:
					gameSaveRoleSkill.name = s.Name;
					num = (int)((num2 * 1796402795) ^ 0x74DE01D8);
					continue;
				case 3u:
					gameSaveRoleSkill.level = s.level;
					gameSaveRoleSkill.exp = s.Exp;
					num = ((int)num2 * -1800921821) ^ -272019835;
					continue;
				default:
					gameSaveRoleSkill.equipped = s.equipped;
					return gameSaveRoleSkill;
				}
				break;
			}
		}
	}

	public static GameSaveRoleSkill Create(InternalSkillInstance s)
	{
		GameSaveRoleSkill gameSaveRoleSkill = new GameSaveRoleSkill();
		while (true)
		{
			int num = 645582809;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x732F7795)) % 6)
				{
				case 5u:
					break;
				case 2u:
					gameSaveRoleSkill.equipped = s.equipped;
					num = (int)((num2 * 1041408453) ^ 0x71095A99);
					continue;
				case 1u:
					gameSaveRoleSkill.level = s.level;
					num = (int)(num2 * 1042339352) ^ -2012761950;
					continue;
				case 3u:
					gameSaveRoleSkill.exp = s.Exp;
					num = ((int)num2 * -1369023674) ^ 0x2C4E99E5;
					continue;
				case 4u:
					gameSaveRoleSkill.name = s.Name;
					num = ((int)num2 * -1446410535) ^ 0x3D0240EA;
					continue;
				default:
					return gameSaveRoleSkill;
				}
				break;
			}
		}
	}

	public static GameSaveRoleSkill Create(SpecialSkillInstance s)
	{
		GameSaveRoleSkill gameSaveRoleSkill = new GameSaveRoleSkill();
		gameSaveRoleSkill.name = s.Name;
		gameSaveRoleSkill.equipped = s.equipped;
		return gameSaveRoleSkill;
	}

	public static GameSaveRoleSkill Create(TitleInstance s)
	{
		return new GameSaveRoleSkill
		{
			name = s.Name,
			equipped = s.equipped
		};
	}

	public TitleInstance GenerateTitle()
	{
		return new TitleInstance
		{
			equipped = equipped,
			name = name
		};
	}

	static int _206E_202D_206E_206A_206C_200E_206A_200C_200B_202A_202A_206A_206A_206B_206C_202B_200F_202B_202A_202C_206E_202C_202D_206D_206B_200B_202B_202D_200B_200B_206F_200E_200B_206D_202C_200B_202A_206A_202A_200E_202E(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}
}
