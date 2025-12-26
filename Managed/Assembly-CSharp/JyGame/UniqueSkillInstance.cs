using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

namespace JyGame;

public class UniqueSkillInstance : SkillBox
{
	private SkillBox _200B_200F_206D_200B_206A_200D_206E_202D_206D_206B_200E_206F_200B_200E_206A_200E_200F_200D_200C_202A_200E_206E_206B_202D_200F_206C_200C_200C_202A_206D_200E_206A_206F_200E_202A_200E_206A_206F_202E_206E_202E;

	private UniqueSkill _206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E;

	public override string Name => _206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E.Name;

	public override string Icon
	{
		get
		{
			if (!_202E_206C_202C_200C_206E_206B_206F_206D_202D_202B_202A_206C_200D_202B_202C_206F_206F_206F_200C_200F_200D_202A_206B_206E_206A_206B_206C_206B_200F_200D_200F_206D_206A_206D_200F_206A_202D_202A_202C_202B_202E(_206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E.icon2))
			{
				while (true)
				{
					uint num;
					switch ((num = 1991578991u) % 3)
					{
					case 0u:
						continue;
					case 2u:
						return _206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E.icon2;
					}
					break;
				}
			}
			return _200B_200F_206D_200B_206A_200D_206E_202D_206D_206B_200E_206F_200B_200E_206A_200E_200F_200D_200C_202A_200E_206E_206B_202D_200F_206C_200C_200C_202A_206D_200E_206A_206F_200E_202A_200E_206A_206F_202E_206E_202E.Icon;
		}
	}

	public override Color Color => Color.red;

	public override int Cd => UniqueSkill.CastCd;

	public override int Type => _200B_200F_206D_200B_206A_200D_206E_202D_206D_206B_200E_206F_200B_200E_206A_200E_200F_200D_200C_202A_200E_206E_206B_202D_200F_206C_200C_200C_202A_206D_200E_206A_206F_200E_202A_200E_206A_206F_202E_206E_202E.Type;

	public override int CostMp => new SkillCoverTypeHelper(CoverType).CostMp(Power, Size);

	public override int CostBall => UniqueSkill.CostBall;

	public override int CastSize => UniqueSkill.CastSize;

	public override int Size
	{
		get
		{
			if (UniqueSkill.CoverType == 0)
			{
				while (true)
				{
					uint num;
					switch ((num = 890668948u) % 3)
					{
					case 0u:
						continue;
					case 1u:
						return _206E_200F_200D_202A_206A_206E_206C_202B_202D_202A_202D_206B_202E_202E_200E_206F_206D_202A_202C_206B_206F_206F_206D_200F_202B_200C_202E_202D_200F_206E_200E_206D_200B_200C_202D_206E_200F_206F_206F_202C_202E(1, UniqueSkill.CoverSize);
					}
					break;
				}
			}
			return UniqueSkill.CoverSize;
		}
	}

	public override SkillCoverType CoverType => (SkillCoverType)UniqueSkill.CoverType;

	public override string Animation => UniqueSkill.Animation;

	public override SkillType SkillType => SkillType.Unique;

	public override int Level => _200B_200F_206D_200B_206A_200D_206E_202D_206D_206B_200E_206F_200B_200E_206A_200E_200F_200D_200C_202A_200E_206E_206B_202D_200F_206C_200C_200C_202A_206D_200E_206A_206F_200E_202A_200E_206A_206F_202E_206E_202E.Level;

	public override float Suit
	{
		get
		{
			if (_206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E.Suit != 0f)
			{
				while (true)
				{
					uint num;
					switch ((num = 1954048138u) % 3)
					{
					case 0u:
						continue;
					case 1u:
						return _206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E.Suit;
					}
					break;
				}
			}
			return _200B_200F_206D_200B_206A_200D_206E_202D_206D_206B_200E_206F_200B_200E_206A_200E_200F_200D_200C_202A_200E_206E_206B_202D_200F_206C_200C_200C_202A_206D_200E_206A_206F_200E_202A_200E_206A_206F_202E_206E_202E.Suit;
		}
	}

	public override float Power
	{
		get
		{
			double num = 0.0;
			if (base.Owner != null)
			{
				IEnumerator<Trigger> enumerator = base.Owner.GetTriggers(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1569168729u)).GetEnumerator();
				try
				{
					Trigger current = default(Trigger);
					while (true)
					{
						IL_0063:
						int num2;
						int num3;
						if (!_202E_200C_200D_202B_202B_206D_200B_206B_202A_206D_206C_202D_202D_200C_206A_200C_200F_206F_202E_206D_206D_202E_206F_206D_206D_206E_200B_202B_200D_200B_206E_202A_206A_202B_206E_206D_200D_202D_206A_202E_202E((IEnumerator)enumerator))
						{
							num2 = -1485204800;
							num3 = num2;
						}
						else
						{
							num2 = -1731439979;
							num3 = num2;
						}
						while (true)
						{
							uint num4;
							switch ((num4 = (uint)(num2 ^ -527934831)) % 6)
							{
							case 0u:
								num2 = -1731439979;
								continue;
							default:
								goto end_IL_0037;
							case 4u:
								break;
							case 1u:
							{
								int num5;
								int num6;
								if (!_206B_202A_202B_206D_200E_202A_200C_200E_200B_202A_202B_206B_200F_200C_202E_202C_202C_202D_200E_202C_202D_206C_202C_206C_206C_202A_200E_200C_202E_200B_200E_200E_206D_202E_206D_202E_200F_206B_202E_200C_202E(current.Argvs[0], Name))
								{
									num5 = -829418182;
									num6 = num5;
								}
								else
								{
									num5 = -823019413;
									num6 = num5;
								}
								num2 = num5 ^ (int)(num4 * 2039859637);
								continue;
							}
							case 2u:
								current = enumerator.Current;
								num2 = -2092031792;
								continue;
							case 3u:
								num += double.Parse(current.Argvs[1]);
								num2 = ((int)num4 * -1849538837) ^ 0x52F6E80A;
								continue;
							case 5u:
								goto end_IL_0037;
							}
							goto IL_0063;
							continue;
							end_IL_0037:
							break;
						}
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						while (true)
						{
							IL_00ea:
							int num7 = -770628161;
							while (true)
							{
								uint num4;
								switch ((num4 = (uint)(num7 ^ -527934831)) % 3)
								{
								case 2u:
									break;
								default:
									goto end_IL_00ef;
								case 1u:
									goto IL_010c;
								case 0u:
									goto end_IL_00ef;
								}
								goto IL_00ea;
								IL_010c:
								_202D_206F_202B_202A_202B_206C_200F_200D_202E_202B_200E_206E_202A_202B_200F_206C_206A_206D_206B_202A_206F_200F_206B_206D_202B_206C_202C_200E_206E_206A_202C_200E_200F_200C_206E_200D_206E_206C_206B_206E_202E((IDisposable)enumerator);
								num7 = ((int)num4 * -1891989770) ^ -2142269721;
								continue;
								end_IL_00ef:
								break;
							}
							break;
						}
					}
				}
			}
			return (float)((double)(_200B_200F_206D_200B_206A_200D_206E_202D_206D_206B_200E_206F_200B_200E_206A_200E_200F_200D_200C_202A_200E_206E_206B_202D_200F_206C_200C_200C_202A_206D_200E_206A_206F_200E_202A_200E_206A_206F_202E_206E_202E.Power + UniqueSkill.PowerAdd) * (1.0 + num / 100.0));
		}
	}

	public override string Audio
	{
		get
		{
			if (!_202E_206C_202C_200C_206E_206B_206F_206D_202D_202B_202A_206C_200D_202B_202C_206F_206F_206F_200C_200F_200D_202A_206B_206E_206A_206B_206C_206B_200F_200D_200F_206D_206A_206D_200F_206A_202D_202A_202C_202B_202E(UniqueSkill.Audio))
			{
				while (true)
				{
					uint num;
					switch ((num = 1489710640u) % 3)
					{
					case 2u:
						continue;
					case 1u:
						return UniqueSkill.Audio;
					}
					break;
				}
			}
			return _200B_200F_206D_200B_206A_200D_206E_202D_206D_206B_200E_206F_200B_200E_206A_200E_200F_200D_200C_202A_200E_206E_206B_202D_200F_206C_200C_200C_202A_206D_200E_206A_206F_200E_202A_200E_206A_206F_202E_206E_202E.Audio;
		}
	}

	[XmlIgnore]
	public override string DescriptionInRichtext
	{
		get
		{
			string text = _202E_200F_206A_206F_200C_200C_206C_200C_206B_202A_200F_206A_206F_200E_202D_206C_206E_206D_206E_206C_200E_206C_202B_206D_202C_200B_200F_202A_200B_206F_200C_200C_200E_202A_206E_202C_200B_202B_206D_202E_202E(ResourceStrings.ResStrings[404], new object[9]
			{
				_200B_200F_206D_200B_206A_200D_206E_202D_206D_206B_200E_206F_200B_200E_206A_200E_200F_200D_200C_202A_200E_206E_206B_202D_200F_206C_200C_200C_202A_206D_200E_206A_206F_200E_202A_200E_206A_206F_202E_206E_202E.Name,
				RequireLevel,
				UniqueSkill.Info,
				UniqueSkill.PowerAdd + _200B_200F_206D_200B_206A_200D_206E_202D_206D_206B_200E_206F_200B_200E_206A_200E_200F_200D_200C_202A_200E_206E_206B_202D_200F_206C_200C_200C_202A_206D_200E_206A_206F_200E_202A_200E_206A_206F_202E_206E_202E.Power,
				GetSkillCoverTypeChinese(),
				Size,
				CastSize,
				CostMp,
				CostBall
			});
			float num4 = default(float);
			float num7 = default(float);
			while (true)
			{
				int num = 1184038555;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x4CD6C4CB)) % 21)
					{
					case 10u:
						break;
					case 0u:
						text = _206B_200B_206C_206B_202D_206A_200E_202D_202B_206E_200D_200B_206F_202A_202B_206C_206F_200B_202A_202C_206D_202C_200C_200B_200F_206B_200E_200E_200E_202B_200F_200F_202B_200D_206C_202D_200F_206C_202D_206A_202E(text, _206B_202B_206B_202E_202D_202C_200E_206D_202C_200E_206C_200F_206E_200E_200B_202A_206F_206A_206A_206A_200B_202C_206E_206C_202C_202C_200C_200B_200B_202A_202E_206C_202B_200D_206C_206A_206F_206C_200C_206E_202E(ResourceStrings.ResStrings[738], (object)num4, (object)num7));
						num = 1747186749;
						continue;
					case 1u:
					{
						int num14;
						int num15;
						if (TiaoheScale >= 1.001f)
						{
							num14 = 783259491;
							num15 = num14;
						}
						else
						{
							num14 = 848105751;
							num15 = num14;
						}
						num = num14 ^ (int)(num2 * 369162321);
						continue;
					}
					case 11u:
						text = _206B_200B_206C_206B_202D_206A_200E_202D_202B_206E_200D_200B_206F_202A_202B_206C_206F_200B_202A_202C_206D_202C_200C_200B_200F_206B_200E_200E_200E_202B_200F_200F_202B_200D_206C_202D_200F_206C_202D_206A_202E(text, _202E_200F_206A_206F_200C_200C_206C_200C_206B_202A_200F_206A_206F_200E_202D_206C_206E_206D_206E_206C_200E_206C_202B_206D_202C_200B_200F_202A_200B_206F_200C_200C_200E_202A_206E_202C_200B_202B_206D_202E_202E(ResourceStrings.ResStrings[397], new object[0]));
						num = 124862538;
						continue;
					case 15u:
					{
						int num8;
						if (Tiaohe)
						{
							num = 553428209;
							num8 = num;
						}
						else
						{
							num = 856069590;
							num8 = num;
						}
						continue;
					}
					case 4u:
						num4 = 100f;
						num7 = 100f;
						num = (int)(num2 * 1168467769) ^ -391337090;
						continue;
					case 17u:
					{
						int num10;
						int num11;
						if (num7 == 100f)
						{
							num10 = -554000013;
							num11 = num10;
						}
						else
						{
							num10 = -441041275;
							num11 = num10;
						}
						num = num10 ^ ((int)num2 * -1543920745);
						continue;
					}
					case 9u:
						text = _206B_200B_206C_206B_202D_206A_200E_202D_202B_206E_200D_200B_206F_202A_202B_206C_206F_200B_202A_202C_206D_202C_200C_200B_200F_206B_200E_200E_200E_202B_200F_200F_202B_200D_206C_202D_200F_206C_202D_206A_202E(text, _206B_202B_206B_202E_202D_202C_200E_206D_202C_200E_206C_200F_206E_200E_200B_202A_206F_206A_206A_206A_200B_202C_206E_206C_202C_202C_200C_200B_200B_202A_202E_206C_202B_200D_206C_206A_206F_206C_200C_206E_202E(ResourceStrings.ResStrings[396], (object)CurrentCd, (object)Cd));
						num = 930095267;
						continue;
					case 7u:
					{
						int num5;
						if (Suit != 0f)
						{
							num = 191045302;
							num5 = num;
						}
						else
						{
							num = 2133376850;
							num5 = num;
						}
						continue;
					}
					case 12u:
						num4 = (int)((TiaoheScale + 1E-05f) % 1f * 1000f);
						num = (int)(num2 * 917418365) ^ -1902829420;
						continue;
					case 18u:
						num7 = _206E_200F_200D_202A_206A_206E_206C_202B_202D_202A_202D_206B_202E_202E_200E_206F_206D_202A_202C_206B_206F_206F_206D_200F_202B_200C_202E_202D_200F_206E_200E_206D_200B_200C_202D_206E_200F_206F_206F_202C_202E(999, (int)TiaoheScale);
						num = ((int)num2 * -1142475346) ^ -1408954880;
						continue;
					case 3u:
					{
						int num12;
						int num13;
						if (CurrentCd == 0)
						{
							num12 = -498289161;
							num13 = num12;
						}
						else
						{
							num12 = -1909701896;
							num13 = num12;
						}
						num = num12 ^ ((int)num2 * -1418293915);
						continue;
					}
					case 19u:
					{
						int num9;
						if (num4 != 100f)
						{
							num = 338166542;
							num9 = num;
						}
						else
						{
							num = 1414537446;
							num9 = num;
						}
						continue;
					}
					case 8u:
						text = _206B_200B_206C_206B_202D_206A_200E_202D_202B_206E_200D_200B_206F_202A_202B_206C_206F_200B_202A_202C_206D_202C_200C_200B_200F_206B_200E_200E_200E_202B_200F_200F_202B_200D_206C_202D_200F_206C_202D_206A_202E(text, _202C_206F_206F_200B_200F_202C_202A_206B_206A_202C_200E_206B_202E_206C_202B_206C_206D_206B_202B_200E_206E_206B_206E_206A_206F_206D_206B_202B_200D_206D_206F_202E_206E_206F_206A_200F_200C_200C_206C_200E_202E(ResourceStrings.ResStrings[399], (object)(Suit * 100f)));
						num = ((int)num2 * -1695595640) ^ 0x56C35902;
						continue;
					case 20u:
					{
						int num6;
						if (Suit >= 0f)
						{
							num = 124862538;
							num6 = num;
						}
						else
						{
							num = 359285390;
							num6 = num;
						}
						continue;
					}
					case 16u:
					{
						int num3;
						if (Suit <= 0f)
						{
							num = 2083496434;
							num3 = num;
						}
						else
						{
							num = 1195402994;
							num3 = num;
						}
						continue;
					}
					case 13u:
						text = _206B_200B_206C_206B_202D_206A_200E_202D_202B_206E_200D_200B_206F_202A_202B_206C_206F_200B_202A_202C_206D_202C_200C_200B_200F_206B_200E_200E_200E_202B_200F_200F_202B_200D_206C_202D_200F_206C_202D_206A_202E(text, _206B_202B_206B_202E_202D_202C_200E_206D_202C_200E_206C_200F_206E_200E_200B_202A_206F_206A_206A_206A_200B_202C_206E_206C_202C_202C_200C_200B_200B_202A_202E_206C_202B_200D_206C_206A_206F_206C_200C_206E_202E(ResourceStrings.ResStrings[395], (object)CurrentCd, (object)Cd));
						num = (int)((num2 * 1846418135) ^ 0x246F88D7);
						continue;
					case 14u:
						text = _206B_200B_206C_206B_202D_206A_200E_202D_202B_206E_200D_200B_206F_202A_202B_206C_206F_200B_202A_202C_206D_202C_200C_200B_200F_206B_200E_200E_200E_202B_200F_200F_202B_200D_206C_202D_200F_206C_202D_206A_202E(text, _202E_200F_206A_206F_200C_200C_206C_200C_206B_202A_200F_206A_206F_200E_202D_206C_206E_206D_206E_206C_200E_206C_202B_206D_202C_200B_200F_202A_200B_206F_200C_200C_200E_202A_206E_202C_200B_202B_206D_202E_202E(ResourceStrings.ResStrings[398], new object[0]));
						num = ((int)num2 * -82329571) ^ -650870753;
						continue;
					case 5u:
						num = (int)((num2 * 1184946984) ^ 0x6383583A);
						continue;
					case 6u:
						text = _206B_200B_206C_206B_202D_206A_200E_202D_202B_206E_200D_200B_206F_202A_202B_206C_206F_200B_202A_202C_206D_202C_200C_200B_200F_206B_200E_200E_200E_202B_200F_200F_202B_200D_206C_202D_200F_206C_202D_206A_202E(text, _202C_206F_206F_200B_200F_202C_202A_206B_206A_202C_200E_206B_202E_206C_202B_206C_206D_206B_202B_200E_206E_206B_206E_206A_206F_206D_206B_202B_200D_206D_206F_202E_206E_206F_206A_200F_200C_200C_206C_200E_202E(ResourceStrings.ResStrings[400], (object)((0f - Suit) * 100f)));
						num = ((int)num2 * -797954707) ^ 0x207E0C2B;
						continue;
					default:
						return _206B_200B_206C_206B_202D_206A_200E_202D_202B_206E_200D_200B_206F_202A_202B_206C_206F_200B_202A_202C_206D_202C_200C_200B_200F_206B_200E_200E_200E_202B_200F_200F_202B_200D_206C_202D_200F_206C_202D_206A_202E(text, GetBuffsString());
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public override IEnumerable<Buff> Buffs => UniqueSkill.Buffs;

	public override bool Tiaohe
	{
		get
		{
			if (!_200B_200F_206D_200B_206A_200D_206E_202D_206D_206B_200E_206F_200B_200E_206A_200E_200F_200D_200C_202A_200E_206E_206B_202D_200F_206C_200C_200C_202A_206D_200E_206A_206F_200E_202A_200E_206A_206F_202E_206E_202E.IsInternal)
			{
				goto IL_000d;
			}
			goto IL_0061;
			IL_000d:
			int num = 1868043937;
			goto IL_0012;
			IL_0012:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6364FA76)) % 6)
				{
				case 0u:
					break;
				case 1u:
				{
					int num3;
					int num4;
					if (!_200B_200F_206D_200B_206A_200D_206E_202D_206D_206B_200E_206F_200B_200E_206A_200E_200F_200D_200C_202A_200E_206E_206B_202D_200F_206C_200C_200C_202A_206D_200E_206A_206F_200E_202A_200E_206A_206F_202E_206E_202E.Tiaohe)
					{
						num3 = 543001950;
						num4 = num3;
					}
					else
					{
						num3 = 1029339649;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1774955924);
					continue;
				}
				case 5u:
					goto IL_0061;
				case 2u:
					return true;
				case 4u:
					goto IL_0088;
				default:
					return false;
				}
				break;
				IL_0088:
				int num5;
				if (_206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E.TiaoheValue != 1)
				{
					num = 1126323931;
					num5 = num;
				}
				else
				{
					num = 1294798520;
					num5 = num;
				}
			}
			goto IL_000d;
			IL_0061:
			int num6;
			if (_206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E.TiaoheValue == 0)
			{
				num = 480164370;
				num6 = num;
			}
			else
			{
				num = 1294798520;
				num6 = num;
			}
			goto IL_0012;
		}
	}

	public UniqueSkill UniqueSkill => _206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E;

	[XmlIgnore]
	public int RequireLevel => UniqueSkill.RequireLevel;

	public SkillBox Parent => _200B_200F_206D_200B_206A_200D_206E_202D_206D_206B_200E_206F_200B_200E_206A_200E_200F_200D_200C_202A_200E_206E_206B_202D_200F_206C_200C_200C_202A_206D_200E_206A_206F_200E_202A_200E_206A_206F_202E_206E_202E;

	public override string Audio2
	{
		get
		{
			if (!_202E_206C_202C_200C_206E_206B_206F_206D_202D_202B_202A_206C_200D_202B_202C_206F_206F_206F_200C_200F_200D_202A_206B_206E_206A_206B_206C_206B_200F_200D_200F_206D_206A_206D_200F_206A_202D_202A_202C_202B_202E(UniqueSkill.Audio2))
			{
				while (true)
				{
					uint num;
					switch ((num = 1305832697u) % 3)
					{
					case 0u:
						continue;
					case 2u:
						return UniqueSkill.Audio2;
					}
					break;
				}
			}
			return _200B_200F_206D_200B_206A_200D_206E_202D_206D_206B_200E_206F_200B_200E_206A_200E_200F_200D_200C_202A_200E_206E_206B_202D_200F_206C_200C_200C_202A_206D_200E_206A_206F_200E_202A_200E_206A_206F_202E_206E_202E.Audio2;
		}
	}

	public override float TiaoheScale
	{
		get
		{
			if (_206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E.TiaoheScale >= 1.001f)
			{
				while (true)
				{
					uint num;
					switch ((num = 809791889u) % 3)
					{
					case 0u:
						continue;
					case 2u:
						return _206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E.TiaoheScale;
					}
					break;
				}
			}
			return _200B_200F_206D_200B_206A_200D_206E_202D_206D_206B_200E_206F_200B_200E_206A_200E_200F_200D_200C_202A_200E_206E_206B_202D_200F_206C_200C_200C_202A_206D_200E_206A_206F_200E_202A_200E_206A_206F_202E_206E_202E.TiaoheScale;
		}
	}

	public override bool IsNpcSkill => _200B_200F_206D_200B_206A_200D_206E_202D_206D_206B_200E_206F_200B_200E_206A_200E_200F_200D_200C_202A_200E_206E_206B_202D_200F_206C_200C_200C_202A_206D_200E_206A_206F_200E_202A_200E_206A_206F_202E_206E_202E.IsNpcSkill;

	public UniqueSkillInstance(UniqueSkill P_0, SkillBox P_1)
	{
		while (true)
		{
			int num = 80160817;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3E1E984F)) % 4)
				{
				case 3u:
					break;
				case 2u:
					base.Owner = P_1.Owner;
					_200B_200F_206D_200B_206A_200D_206E_202D_206D_206B_200E_206F_200B_200E_206A_200E_200F_200D_200C_202A_200E_206E_206B_202D_200F_206C_200C_200C_202A_206D_200E_206A_206F_200E_202A_200E_206A_206F_202E_206E_202E = P_1;
					num = (int)((num2 * 239123583) ^ 0x86FD3C8);
					continue;
				case 1u:
					_206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E = P_0;
					RoleEffect = P_0.roleanimation;
					num = ((int)num2 * -583849885) ^ -1113683780;
					continue;
				default:
					AttackTime = P_0.attacktime;
					return;
				}
				break;
			}
		}
	}

	public override bool TryAddExp(int exp)
	{
		return _200B_200F_206D_200B_206A_200D_206E_202D_206D_206B_200E_206F_200B_200E_206A_200E_200F_200D_200C_202A_200E_206E_206B_202D_200F_206C_200C_200C_202A_206D_200E_206A_206F_200E_202A_200E_206A_206F_202E_206E_202E.TryAddExp(exp);
	}

	static bool _202E_206C_202C_200C_206E_206B_206F_206D_202D_202B_202A_206C_200D_202B_202C_206F_206F_206F_200C_200F_200D_202A_206B_206E_206A_206B_206C_206B_200F_200D_200F_206D_206A_206D_200F_206A_202D_202A_202C_202B_202E(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}

	static int _206E_200F_200D_202A_206A_206E_206C_202B_202D_202A_202D_206B_202E_202E_200E_206F_206D_202A_202C_206B_206F_206F_206D_200F_202B_200C_202E_202D_200F_206E_200E_206D_200B_200C_202D_206E_200F_206F_206F_202C_202E(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	static bool _206B_202A_202B_206D_200E_202A_200C_200E_200B_202A_202B_206B_200F_200C_202E_202C_202C_202D_200E_202C_202D_206C_202C_206C_206C_202A_200E_200C_202E_200B_200E_200E_206D_202E_206D_202E_200F_206B_202E_200C_202E(string P_0, string P_1)
	{
		return P_0 == P_1;
	}

	static bool _202E_200C_200D_202B_202B_206D_200B_206B_202A_206D_206C_202D_202D_200C_206A_200C_200F_206F_202E_206D_206D_202E_206F_206D_206D_206E_200B_202B_200D_200B_206E_202A_206A_202B_206E_206D_200D_202D_206A_202E_202E(IEnumerator P_0)
	{
		return P_0.MoveNext();
	}

	static void _202D_206F_202B_202A_202B_206C_200F_200D_202E_202B_200E_206E_202A_202B_200F_206C_206A_206D_206B_202A_206F_200F_206B_206D_202B_206C_202C_200E_206E_206A_202C_200E_200F_200C_206E_200D_206E_206C_206B_206E_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}

	static string _202E_200F_206A_206F_200C_200C_206C_200C_206B_202A_200F_206A_206F_200E_202D_206C_206E_206D_206E_206C_200E_206C_202B_206D_202C_200B_200F_202A_200B_206F_200C_200C_200E_202A_206E_202C_200B_202B_206D_202E_202E(string P_0, object[] P_1)
	{
		return string.Format(P_0, P_1);
	}

	static string _206B_202B_206B_202E_202D_202C_200E_206D_202C_200E_206C_200F_206E_200E_200B_202A_206F_206A_206A_206A_200B_202C_206E_206C_202C_202C_200C_200B_200B_202A_202E_206C_202B_200D_206C_206A_206F_206C_200C_206E_202E(string P_0, object P_1, object P_2)
	{
		return string.Format(P_0, P_1, P_2);
	}

	static string _206B_200B_206C_206B_202D_206A_200E_202D_202B_206E_200D_200B_206F_202A_202B_206C_206F_200B_202A_202C_206D_202C_200C_200B_200F_206B_200E_200E_200E_202B_200F_200F_202B_200D_206C_202D_200F_206C_202D_206A_202E(string P_0, string P_1)
	{
		return P_0 + P_1;
	}

	static string _202C_206F_206F_200B_200F_202C_202A_206B_206A_202C_200E_206B_202E_206C_202B_206C_206D_206B_202B_200E_206E_206B_206E_206A_206F_206D_206B_202B_200D_206D_206F_202E_206E_206F_206A_200F_200C_200C_206C_200E_202E(string P_0, object P_1)
	{
		return string.Format(P_0, P_1);
	}
}
