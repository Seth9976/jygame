using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

namespace JyGame;

[XmlType("skill")]
public class SpecialSkillInstance : SkillBox
{
	[XmlAttribute]
	public string name;

	private SpecialSkill _202A_200E_200B_206A_202C_200C_206E_202E_206B_200C_202C_206F_202E_206C_206F_202B_206A_202D_206F_206E_206F_200B_202B_206B_202D_202D_202E_200F_206A_202C_200D_202D_202C_206E_202E_202C_206F_202C_200D_200C_202E;

	public override string Name => name;

	public override string Icon => SpecialSkill.icon;

	public override Color Color => new Color(0.337f, 0.584f, 1f);

	public override int Cd => SpecialSkill.Cd;

	public override int Type => -1;

	public override int CostMp => SpecialSkill.CostMp;

	public override int CostBall => SpecialSkill.CostBall;

	public override int CastSize => SpecialSkill.CastSize;

	public override int Size
	{
		get
		{
			if (SpecialSkill.CoverType == 0)
			{
				while (true)
				{
					uint num;
					switch ((num = 1887905128u) % 3)
					{
					case 0u:
						continue;
					case 1u:
						return _202E_206A_206F_200D_200D_202B_200D_200C_202B_206C_202D_206C_206D_206C_202D_200C_206A_200C_206C_206B_200C_206E_206B_200F_202B_202B_202A_202C_206A_206E_206E_202A_206C_206C_202E_202C_206D_200E_206C_200D_202E(1, SpecialSkill.CoverSize);
					}
					break;
				}
			}
			return SpecialSkill.CoverSize;
		}
	}

	public override bool HitSelf => SpecialSkill.HitSelf;

	public override SkillCoverType CoverType => (SkillCoverType)SpecialSkill.CoverType;

	public override string Animation => SpecialSkill.Animation;

	public override SkillType SkillType => SkillType.Special;

	public override string Audio => SpecialSkill.Audio;

	public override bool IsUsed => base.IsUsed;

	public override string DescriptionInRichtext
	{
		get
		{
			string text = _200D_200F_202E_202A_202D_206E_200B_206D_206A_202D_200C_206E_200B_206A_206D_200B_202B_206A_202B_202B_202D_202B_202A_200F_206E_202B_206B_200B_200E_200C_202C_200B_206A_206B_202E_206E_200C_202B_202E_200F_202E(ResourceStrings.ResStrings[405], new object[6]
			{
				SpecialSkill.Info,
				GetSkillCoverTypeChinese(),
				Size,
				CastSize,
				CostMp,
				CostBall
			});
			while (true)
			{
				int num = -1386412115;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1446176035)) % 5)
					{
					case 0u:
						break;
					case 2u:
						text = _202C_200D_206B_202D_200F_202A_202A_206D_200F_200C_206F_202E_202A_202C_200C_206C_206A_202D_200B_206B_206A_202E_200D_206D_200E_202C_202E_202B_206C_206C_206C_206F_202D_200C_202A_200F_202C_206D_202E_200C_202E(text, _200F_206A_200C_206C_202E_202C_206E_206B_202A_206B_206E_200C_206F_202C_206B_200F_202C_206F_206B_206D_206F_200D_200B_206A_206E_202A_202C_200F_202B_200D_202C_202E_206D_202D_202C_206B_206F_206B_202E_206E_202E(ResourceStrings.ResStrings[396], (object)CurrentCd, (object)Cd));
						num = -1718018356;
						continue;
					case 1u:
						text = _202C_200D_206B_202D_200F_202A_202A_206D_200F_200C_206F_202E_202A_202C_200C_206C_206A_202D_200B_206B_206A_202E_200D_206D_200E_202C_202E_202B_206C_206C_206C_206F_202D_200C_202A_200F_202C_206D_202E_200C_202E(text, _200F_206A_200C_206C_202E_202C_206E_206B_202A_206B_206E_200C_206F_202C_206B_200F_202C_206F_206B_206D_206F_200D_200B_206A_206E_202A_202C_200F_202B_200D_202C_202E_206D_202D_202C_206B_206F_206B_202E_206E_202E(ResourceStrings.ResStrings[395], (object)CurrentCd, (object)Cd));
						num = ((int)num2 * -1687696320) ^ 0x62F33D4C;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (CurrentCd != 0)
						{
							num3 = -968585834;
							num4 = num3;
						}
						else
						{
							num3 = -338277853;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 319240663);
						continue;
					}
					default:
						return _202C_200D_206B_202D_200F_202A_202A_206D_200F_200C_206F_202E_202A_202C_200C_206C_206A_202D_200B_206B_206A_202E_200D_206D_200E_202C_202E_202B_206C_206C_206C_206F_202D_200C_202A_200F_202C_206D_202E_200C_202E(text, GetBuffsString());
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public override IEnumerable<Buff> Buffs => SpecialSkill.Buffs;

	public SpecialSkill SpecialSkill
	{
		get
		{
			if (_202A_200E_200B_206A_202C_200C_206E_202E_206B_200C_202C_206F_202E_206C_206F_202B_206A_202D_206F_206E_206F_200B_202B_206B_202D_202D_202E_200F_206A_202C_200D_202D_202C_206E_202E_202C_206F_202C_200D_200C_202E == null)
			{
				while (true)
				{
					int num = 1525183709;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ 0x5BCDE60F)) % 3)
						{
						case 2u:
							break;
						case 1u:
							_202A_200E_200B_206A_202C_200C_206E_202E_206B_200C_202C_206F_202E_206C_206F_202B_206A_202D_206F_206E_206F_200B_202B_206B_202D_202D_202E_200F_206A_202C_200D_202D_202C_206E_202E_202C_206F_202C_200D_200C_202E = ResourceManager.Get<SpecialSkill>(name);
							AttackTime = _202A_200E_200B_206A_202C_200C_206E_202E_206B_200C_202C_206F_202E_206C_206F_202B_206A_202D_206F_206E_206F_200B_202B_206B_202D_202D_202E_200F_206A_202C_200D_202D_202C_206E_202E_202C_206F_202C_200D_200C_202E.attacktime;
							num = (int)((num2 * 1481608726) ^ 0x4A5E707);
							continue;
						default:
							goto end_IL_0008;
						}
						break;
					}
					continue;
					end_IL_0008:
					break;
				}
			}
			return _202A_200E_200B_206A_202C_200C_206E_202E_206B_200C_202C_206F_202E_206C_206F_202B_206A_202D_206F_206E_206F_200B_202B_206B_202D_202D_202E_200F_206A_202C_200D_202D_202C_206E_202E_202C_206F_202C_200D_200C_202E;
		}
	}

	public override string Audio2 => SpecialSkill.Audio2;

	public override bool IsNpcSkill => SpecialSkill.IsNpc;

	public void SkillVariables()
	{
		CostMpBattle = CostMp;
	}

	static int _202E_206A_206F_200D_200D_202B_200D_200C_202B_206C_202D_206C_206D_206C_202D_200C_206A_200C_206C_206B_200C_206E_206B_200F_202B_202B_202A_202C_206A_206E_206E_202A_206C_206C_202E_202C_206D_200E_206C_200D_202E(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	static string _200D_200F_202E_202A_202D_206E_200B_206D_206A_202D_200C_206E_200B_206A_206D_200B_202B_206A_202B_202B_202D_202B_202A_200F_206E_202B_206B_200B_200E_200C_202C_200B_206A_206B_202E_206E_200C_202B_202E_200F_202E(string P_0, object[] P_1)
	{
		return string.Format(P_0, P_1);
	}

	static string _200F_206A_200C_206C_202E_202C_206E_206B_202A_206B_206E_200C_206F_202C_206B_200F_202C_206F_206B_206D_206F_200D_200B_206A_206E_202A_202C_200F_202B_200D_202C_202E_206D_202D_202C_206B_206F_206B_202E_206E_202E(string P_0, object P_1, object P_2)
	{
		return string.Format(P_0, P_1, P_2);
	}

	static string _202C_200D_206B_202D_200F_202A_202A_206D_200F_200C_206F_202E_202A_202C_200C_206C_206A_202D_200B_206B_206A_202E_200D_206D_200E_202C_202E_202B_206C_206C_206C_206F_202D_200C_202A_200F_202C_206D_202E_200C_202E(string P_0, string P_1)
	{
		return P_0 + P_1;
	}
}
