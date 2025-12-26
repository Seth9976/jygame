using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using UnityEngine;

namespace JyGame;

public abstract class SkillBox
{
	[XmlAttribute]
	public int equipped = 1;

	[XmlIgnore]
	public int CurrentCd;

	[XmlIgnore]
	public string ScreenEffect;

	[XmlIgnore]
	public bool IsScreenEffectFollowSprite;

	[CompilerGenerated]
	private Role _200D_200B_202B_206E_206C_206A_206D_206F_202C_200D_202A_200D_200D_202E_200D_200B_200B_206E_200B_206B_206C_200F_206F_200B_200F_206F_206D_206B_206E_200E_206B_200F_200D_206A_202E_202D_206C_206E_202D_206B_202E;

	[XmlIgnore]
	public int attackResult_Hp;

	[XmlIgnore]
	public int attackResult_Mp;

	[XmlIgnore]
	public bool FaceRight = true;

	[XmlIgnore]
	public string RoleEffect;

	[XmlIgnore]
	public float AttackTime;

	[XmlIgnore]
	public float PowerBattle;

	[XmlIgnore]
	public int CostMpBattle;

	[XmlIgnore]
	internal ItemInstance Item;

	[XmlIgnore]
	public virtual bool IsUsed => equipped > 0;

	public abstract string Name { get; }

	public abstract Color Color { get; }

	public abstract SkillType SkillType { get; }

	[XmlIgnore]
	public abstract string Icon { get; }

	[XmlIgnore]
	public Sprite IconSprite => Resource.GetIcon(Icon);

	[XmlIgnore]
	public Role Owner
	{
		[CompilerGenerated]
		get
		{
			return _200D_200B_202B_206E_206C_206A_206D_206F_202C_200D_202A_200D_200D_202E_200D_200B_200B_206E_200B_206B_206C_200F_206F_200B_200F_206F_206D_206B_206E_200E_206B_200F_200D_206A_202E_202D_206C_206E_202D_206B_202E;
		}
		[CompilerGenerated]
		set
		{
			_200D_200B_202B_206E_206C_206A_206D_206F_202C_200D_202A_200D_200D_202E_200D_200B_200B_206E_200B_206B_206C_200F_206F_200B_200F_206F_206D_206B_206E_200E_206B_200F_200D_206A_202E_202D_206C_206E_202D_206B_202E = value;
		}
	}

	public abstract int CostBall { get; }

	public abstract int CostMp { get; }

	public abstract int Cd { get; }

	public abstract int Type { get; }

	public abstract int CastSize { get; }

	public abstract SkillCoverType CoverType { get; }

	public abstract int Size { get; }

	public abstract string Animation { get; }

	public virtual int Level => 1;

	public virtual int MaxLevel => 1;

	public virtual bool HitSelf => false;

	public virtual string Audio => string.Empty;

	public bool IsAoyi => SkillType == SkillType.Aoyi;

	public bool IsUnique => SkillType == SkillType.Unique;

	public bool IsInternal => SkillType == SkillType.Internal;

	public bool IsSpecial => SkillType == SkillType.Special;

	[XmlIgnore]
	public virtual IEnumerable<Buff> Buffs
	{
		get
		{
			while (true)
			{
				int num = 158333731;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x514C96EA)) % 5)
					{
					case 4u:
						break;
					default:
						yield break;
					case 1u:
						num = 1237795117;
						continue;
					case 0u:
						yield break;
					case 3u:
					{
						int num3;
						num = ((num3 == 0) ? 215461330 : 1219817858) ^ ((int)num2 * -1860971698);
						continue;
					}
					}
					break;
				}
			}
		}
	}

	public virtual bool Tiaohe => false;

	public virtual float Suit => 0f;

	public virtual float Power => 0f;

	public virtual SkillStatus Status
	{
		get
		{
			if (Owner == null)
			{
				goto IL_000b;
			}
			goto IL_01e9;
			IL_000b:
			int num = 1965233653;
			goto IL_0010;
			IL_0010:
			BattleSprite sprite = default(BattleSprite);
			bool flag = default(bool);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2BE51AEC)) % 36)
				{
				case 19u:
					break;
				case 29u:
					goto IL_00b5;
				case 3u:
					return SkillStatus.NoBalls;
				case 33u:
					sprite = Owner.Sprite;
					num = 1485705366;
					continue;
				case 28u:
				{
					int num17;
					int num18;
					if (sprite.GetBuff(ResourceStrings.ResStrings[534]) != null)
					{
						num17 = 1267906556;
						num18 = num17;
					}
					else
					{
						num17 = 954350412;
						num18 = num17;
					}
					num = num17 ^ (int)(num2 * 1165692007);
					continue;
				}
				case 32u:
					return SkillStatus.Seal;
				case 0u:
					flag = true;
					num = 727955757;
					continue;
				case 18u:
				{
					int num11;
					int num12;
					if (_206E_202A_202D_206E_202A_200B_200F_206F_206B_206F_202A_202B_202A_206F_200C_202D_200D_202B_206F_202E_202B_202E_200D_202A_200E_200E_206A_202D_200D_206B_202D_206B_200C_202C_202B_200D_206F_206C_200D_200D_202E((Object)(object)sprite, (Object)null))
					{
						num11 = 904831949;
						num12 = num11;
					}
					else
					{
						num11 = 998026138;
						num12 = num11;
					}
					num = num11 ^ ((int)num2 * -1898173173);
					continue;
				}
				case 1u:
					num = ((int)num2 * -1172586670) ^ 0x2D8832DA;
					continue;
				case 9u:
				{
					int num13;
					int num14;
					if (sprite.Role.jiushen_count >= 0)
					{
						num13 = -1864122419;
						num14 = num13;
					}
					else
					{
						num13 = -963741516;
						num14 = num13;
					}
					num = num13 ^ (int)(num2 * 1755990396);
					continue;
				}
				case 15u:
				{
					int num5;
					int num6;
					if (sprite.GetBuff(ResourceStrings.ResStrings[539]) == null)
					{
						num5 = -883467258;
						num6 = num5;
					}
					else
					{
						num5 = -1780799996;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 542463316);
					continue;
				}
				case 11u:
					goto IL_01e9;
				case 7u:
					return SkillStatus.NoMp;
				case 24u:
					goto IL_0224;
				case 10u:
					flag = true;
					num = ((int)num2 * -1746181898) ^ -846277340;
					continue;
				case 31u:
					goto IL_0254;
				case 35u:
					goto IL_0271;
				case 12u:
				{
					flag = false;
					int num19;
					int num20;
					if (_200C_200E_206F_202C_202D_202E_202B_202A_202D_202A_202E_206F_202D_202E_202B_200E_200F_200E_200D_202A_200C_202C_206C_200E_206F_202B_202E_202C_202C_202D_206C_206A_202C_200E_206B_202B_206E_206D_202E_200E_202E(Name, ResourceStrings.ResStrings[1052]))
					{
						num19 = 55556136;
						num20 = num19;
					}
					else
					{
						num19 = 813112849;
						num20 = num19;
					}
					num = num19 ^ (int)(num2 * 1905206604);
					continue;
				}
				case 2u:
				{
					int num7;
					int num8;
					if (sprite.Role.jiushen_count < 9)
					{
						num7 = -179125269;
						num8 = num7;
					}
					else
					{
						num7 = -1736951290;
						num8 = num7;
					}
					num = num7 ^ ((int)num2 * -1621249405);
					continue;
				}
				case 4u:
				{
					int num23;
					int num24;
					if (sprite.GetBuff(ResourceStrings.ResStrings[528]) != null)
					{
						num23 = -1442650910;
						num24 = num23;
					}
					else
					{
						num23 = -337190884;
						num24 = num23;
					}
					num = num23 ^ (int)(num2 * 193966701);
					continue;
				}
				case 34u:
					goto IL_0326;
				case 6u:
				{
					int num21;
					int num22;
					if (sprite.GetBuff(ResourceStrings.ResStrings[536]) != null)
					{
						num21 = 1563939612;
						num22 = num21;
					}
					else
					{
						num21 = 115927943;
						num22 = num21;
					}
					num = num21 ^ ((int)num2 * -669243326);
					continue;
				}
				case 27u:
					goto IL_0376;
				case 16u:
					goto IL_0393;
				case 25u:
					return SkillStatus.NoCd;
				case 14u:
					goto IL_03c4;
				case 17u:
					return SkillStatus.Error;
				case 5u:
					goto IL_040e;
				case 26u:
				{
					int num15;
					int num16;
					if (sprite.GetBuff(ResourceStrings.ResStrings[533]) != null)
					{
						num15 = -1981995320;
						num16 = num15;
					}
					else
					{
						num15 = -823388460;
						num16 = num15;
					}
					num = num15 ^ ((int)num2 * -1718852712);
					continue;
				}
				case 8u:
					goto IL_045d;
				case 23u:
					return SkillStatus.Error;
				case 30u:
					return SkillStatus.Seal;
				case 13u:
				{
					int num9;
					int num10;
					if (sprite.GetBuff(ResourceStrings.ResStrings[535]) != null)
					{
						num9 = -1786308079;
						num10 = num9;
					}
					else
					{
						num9 = -1506784290;
						num10 = num9;
					}
					num = num9 ^ (int)(num2 * 1723851441);
					continue;
				}
				case 20u:
					goto IL_04d4;
				case 21u:
				{
					int num3;
					int num4;
					if (sprite.GetBuff(ResourceStrings.ResStrings[537]) != null)
					{
						num3 = -594463716;
						num4 = num3;
					}
					else
					{
						num3 = -919810285;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -107725388);
					continue;
				}
				default:
					return SkillStatus.Ok;
				}
				break;
				IL_04d4:
				int num25;
				if (flag)
				{
					num = 1730457914;
					num25 = num;
				}
				else
				{
					num = 143194138;
					num25 = num;
				}
				continue;
				IL_0326:
				int num26;
				if (CurrentCd > 0)
				{
					num = 1182273961;
					num26 = num;
				}
				else
				{
					num = 143904174;
					num26 = num;
				}
				continue;
				IL_0393:
				int num27;
				if (Type != 2)
				{
					num = 1706283991;
					num27 = num;
				}
				else
				{
					num = 867854901;
					num27 = num;
				}
				continue;
				IL_045d:
				int num28;
				if (IsSpecial)
				{
					num = 966553452;
					num28 = num;
				}
				else
				{
					num = 2077125961;
					num28 = num;
				}
				continue;
				IL_00b5:
				int num29;
				if (sprite.GetBuff(ResourceStrings.ResStrings[538]) == null)
				{
					num = 857751560;
					num29 = num;
				}
				else
				{
					num = 1561985038;
					num29 = num;
				}
				continue;
				IL_0254:
				int num30;
				if (Type == 3)
				{
					num = 430087945;
					num30 = num;
				}
				else
				{
					num = 1136228631;
					num30 = num;
				}
				continue;
				IL_040e:
				int num31;
				if (!IsUnique)
				{
					num = 848529042;
					num31 = num;
				}
				else
				{
					num = 288731652;
					num31 = num;
				}
				continue;
				IL_0376:
				int num32;
				if (Type == 5)
				{
					num = 1144872455;
					num32 = num;
				}
				else
				{
					num = 143194138;
					num32 = num;
				}
				continue;
				IL_0271:
				int num33;
				if (Type == 1)
				{
					num = 992261776;
					num33 = num;
				}
				else
				{
					num = 628362920;
					num33 = num;
				}
				continue;
				IL_03c4:
				int num34;
				if (CostMpBattle > Owner.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1678197155u)])
				{
					num = 1676153919;
					num34 = num;
				}
				else
				{
					num = 366142989;
					num34 = num;
				}
				continue;
				IL_0224:
				int num35;
				if (Type != 0)
				{
					num = 232503939;
					num35 = num;
				}
				else
				{
					num = 1150050990;
					num35 = num;
				}
			}
			goto IL_000b;
			IL_01e9:
			int num36;
			if (Owner.balls < CostBall)
			{
				num = 1980178899;
				num36 = num;
			}
			else
			{
				num = 1164538702;
				num36 = num;
			}
			goto IL_0010;
		}
	}

	[XmlIgnore]
	public virtual string DescriptionInRichtext => string.Empty;

	[XmlIgnore]
	public string DescriptionInRichtextBlackBg => _206B_200C_202C_200D_200D_202B_206C_206F_202A_200C_206C_202C_200F_206C_202D_202E_202E_206D_200C_200B_200B_200C_200C_206B_202E_206E_206F_202B_206B_202D_202D_206A_202C_202A_202E_200B_202A_202A_202D_206B_202E(DescriptionInRichtext, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(783698659u), global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3353173327u));

	public virtual float TiaoheScale => 0f;

	public virtual string Audio2 => string.Empty;

	public virtual int MaxLevel2 => 1;

	public virtual bool IsNpcSkill => false;

	public string GetSkillTypeChinese()
	{
		switch (SkillType)
		{
		default:
			while (true)
			{
				int num = -1714346748;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -371644518)) % 9)
					{
					case 0u:
						break;
					case 6u:
						goto end_IL_0031;
					case 8u:
						goto IL_0086;
					case 4u:
						goto IL_009d;
					case 3u:
						goto IL_00b4;
					case 2u:
						goto IL_00ce;
					case 1u:
						num = (int)(num2 * 437054217) ^ -915724710;
						continue;
					case 5u:
						goto IL_00fa;
					default:
						goto end_IL_0008;
					}
					break;
				}
				continue;
				end_IL_0031:
				break;
			}
			goto case SkillType.Internal;
		case SkillType.Internal:
			return ResourceStrings.ResStrings[562];
		case SkillType.Normal:
			goto IL_0086;
		case SkillType.Special:
			goto IL_009d;
		case SkillType.Aoyi:
			goto IL_00b4;
		case SkillType.Title:
			goto IL_00ce;
		case SkillType.Unique:
			goto IL_00fa;
		case SkillType.yuliu5:
		case SkillType.yuliu6:
		case SkillType.yuliu7:
			break;
			IL_00fa:
			return ResourceStrings.ResStrings[563];
			IL_00ce:
			return ResourceStrings.ResStrings[1064];
			IL_00b4:
			return ResourceStrings.ResStrings[565];
			IL_009d:
			return ResourceStrings.ResStrings[564];
			IL_0086:
			return ResourceStrings.ResStrings[561];
			end_IL_0008:
			break;
		}
		return global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(838598587u);
	}

	public string GetBuffsString()
	{
		string text = string.Empty;
		IEnumerator<Buff> enumerator = Buffs.GetEnumerator();
		try
		{
			Buff current = default(Buff);
			while (true)
			{
				IL_006e:
				int num;
				int num2;
				if (!_202E_202C_200E_202A_202D_202E_202C_200D_202D_206A_200F_206F_202C_202B_206C_202E_202B_200D_206C_200B_206B_200F_206D_202B_206D_202B_202E_206D_206B_200D_206B_206F_206D_200E_202C_206A_202A_202E_206C_200C_202E((IEnumerator)enumerator))
				{
					num = -1264026420;
					num2 = num;
				}
				else
				{
					num = -21201128;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -1738125358)) % 16)
					{
					case 15u:
						num = -21201128;
						continue;
					default:
						goto end_IL_0019;
					case 0u:
						break;
					case 3u:
					{
						int num8;
						if (current.Property < 0)
						{
							num = -1921202807;
							num8 = num;
						}
						else
						{
							num = -1640074554;
							num8 = num;
						}
						continue;
					}
					case 7u:
						text = _202D_200D_202C_202B_206E_206D_202D_206F_200B_200C_200B_206F_200C_202A_202D_202D_206A_200B_206B_200F_206E_200C_206E_206A_206A_206C_206C_200D_206B_202E_206F_200D_200C_200C_202B_200C_202A_200D_206E_206E_202E(text, _202C_202B_202C_206E_206C_200D_200B_206A_200E_202A_206D_202B_202A_202E_206D_202C_202C_206A_202C_200D_200F_206F_200B_206C_206E_206F_206C_206C_202A_202C_202C_206C_202E_206E_200E_206B_200D_202B_206E_200D_202E(ResourceStrings.ResStrings[568], new object[0]));
						num = ((int)num3 * -2036605659) ^ 0x77AB699C;
						continue;
					case 5u:
						text = _202D_200D_202C_202B_206E_206D_202D_206F_200B_200C_200B_206F_200C_202A_202D_202D_206A_200B_206B_200F_206E_200C_206E_206A_206A_206C_206C_200D_206B_202E_206F_200D_200C_200C_202B_200C_202A_200D_206E_206E_202E(text, _202C_202B_202C_206E_206C_200D_200B_206A_200E_202A_206D_202B_202A_202E_206D_202C_202C_206A_202C_200D_200F_206F_200B_206C_206E_206F_206C_206C_202A_202C_202C_206C_202E_206E_200E_206B_200D_202B_206E_200D_202E(ResourceStrings.ResStrings[571], new object[0]));
						num = -1377281073;
						continue;
					case 1u:
						num = ((int)num3 * -1999799974) ^ 0x6E0B46B5;
						continue;
					case 8u:
						num = ((int)num3 * -2141346308) ^ 0x18D4FAAF;
						continue;
					case 10u:
						current = enumerator.Current;
						text = _202D_200D_202C_202B_206E_206D_202D_206F_200B_200C_200B_206F_200C_202A_202D_202D_206A_200B_206B_200F_206E_200C_206E_206A_206A_206C_206C_200D_206B_202E_206F_200D_200C_200C_202B_200C_202A_200D_206E_206E_202E(text, _200E_206C_206E_202E_206F_200C_206C_200F_200D_202A_200D_200F_200B_206C_200E_200B_206C_206F_200D_206C_202A_206C_200F_202A_202B_206F_206F_200F_200C_206F_206A_200B_200F_206E_200B_206B_202C_200C_200C_206D_202E(ResourceStrings.ResStrings[566], (object)current.Name, (object)current.Level));
						num = -513365954;
						continue;
					case 9u:
					{
						int num7;
						if (current.Property == 100)
						{
							num = -1276343355;
							num7 = num;
						}
						else
						{
							num = -746713439;
							num7 = num;
						}
						continue;
					}
					case 11u:
					{
						int num6;
						if (current.Property != -1)
						{
							num = -1296637193;
							num6 = num;
						}
						else
						{
							num = -1286687308;
							num6 = num;
						}
						continue;
					}
					case 2u:
						text = _202D_200D_202C_202B_206E_206D_202D_206F_200B_200C_200B_206F_200C_202A_202D_202D_206A_200B_206B_200F_206E_200C_206E_206A_206A_206C_206C_200D_206B_202E_206F_200D_200C_200C_202B_200C_202A_200D_206E_206E_202E(text, _200C_202D_200C_206C_206F_202E_202B_202E_200B_206B_200E_202B_206D_202A_206B_202C_206A_202D_200B_200F_206C_200C_200B_200E_200E_202E_206D_206F_200D_206A_200D_206B_206B_200C_202E_206B_206E_206D_200E_200E_202E(ResourceStrings.ResStrings[567], (object)current.Round));
						num = (int)(num3 * 833491500) ^ -101358909;
						continue;
					case 4u:
						text = _202D_200D_202C_202B_206E_206D_202D_206F_200B_200C_200B_206F_200C_202A_202D_202D_206A_200B_206B_200F_206E_200C_206E_206A_206A_206C_206C_200D_206B_202E_206F_200D_200C_200C_202B_200C_202A_200D_206E_206E_202E(text, _200C_202D_200C_206C_206F_202E_202B_202E_200B_206B_200E_202B_206D_202A_206B_202C_206A_202D_200B_200F_206C_200C_200B_200E_200E_202E_206D_206F_200D_206A_200D_206B_206B_200C_202E_206B_206E_206D_200E_200E_202E(ResourceStrings.ResStrings[569], (object)current.Property));
						num = ((int)num3 * -745123886) ^ 0x3A379A12;
						continue;
					case 12u:
					{
						int num4;
						int num5;
						if (current.Round > 0)
						{
							num4 = -964193740;
							num5 = num4;
						}
						else
						{
							num4 = -430072897;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -17034037);
						continue;
					}
					case 13u:
						text = _202D_200D_202C_202B_206E_206D_202D_206F_200B_200C_200B_206F_200C_202A_202D_202D_206A_200B_206B_200F_206E_200C_206E_206A_206A_206C_206C_200D_206B_202E_206F_200D_200C_200C_202B_200C_202A_200D_206E_206E_202E(text, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2910989005u));
						num = -950909070;
						continue;
					case 6u:
						text = _202D_200D_202C_202B_206E_206D_202D_206F_200B_200C_200B_206F_200C_202A_202D_202D_206A_200B_206B_200F_206E_200C_206E_206A_206A_206C_206C_200D_206B_202E_206F_200D_200C_200C_202B_200C_202A_200D_206E_206E_202E(text, _202C_202B_202C_206E_206C_200D_200B_206A_200E_202A_206D_202B_202A_202E_206D_202C_202C_206A_202C_200D_200F_206F_200B_206C_206E_206F_206C_206C_202A_202C_202C_206C_202E_206E_200E_206B_200D_202B_206E_200D_202E(ResourceStrings.ResStrings[570], new object[0]));
						num = ((int)num3 * -2139213051) ^ -5523843;
						continue;
					case 14u:
						goto end_IL_0019;
					}
					goto IL_006e;
					continue;
					end_IL_0019:
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
					IL_0286:
					int num9 = -1271791278;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num9 ^ -1738125358)) % 3)
						{
						case 0u:
							break;
						default:
							goto end_IL_028b;
						case 1u:
							goto IL_02a8;
						case 2u:
							goto end_IL_028b;
						}
						goto IL_0286;
						IL_02a8:
						_206C_202E_206B_202C_206F_202C_200B_206B_200F_200D_200C_206A_202A_202D_206A_202C_200D_202E_206C_206B_202E_206B_200E_206F_200D_206B_202D_202B_200C_202E_200B_200C_206D_200D_202C_200E_206A_200D_206B_202E((IDisposable)enumerator);
						num9 = ((int)num3 * -387191492) ^ -1946041174;
						continue;
						end_IL_028b:
						break;
					}
					break;
				}
			}
		}
		return text;
	}

	public string GetSkillCoverTypeChinese()
	{
		return SkillCoverTypeHelper.GetSkillTypeChinese((int)CoverType);
	}

	public virtual void CastCd()
	{
		int num = Owner.addCdValue;
		while (true)
		{
			int num2 = 2128349027;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x43DC2D8A)) % 9)
				{
				case 4u:
					break;
				case 1u:
					num += Owner.addCdValue_Special;
					num2 = (int)((num3 * 905483230) ^ 0x24FAFAC4);
					continue;
				case 8u:
					num += Owner.addCdValue_Normal;
					num2 = (int)((num3 * 1966483900) ^ 0x3EBF23C0);
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (SkillType == SkillType.Normal)
					{
						num5 = -1045462684;
						num6 = num5;
					}
					else
					{
						num5 = -1488734063;
						num6 = num5;
					}
					num2 = num5 ^ (int)(num3 * 216443779);
					continue;
				}
				case 2u:
				{
					int num7;
					if (SkillType == SkillType.Unique)
					{
						num2 = 240337254;
						num7 = num2;
					}
					else
					{
						num2 = 1015507665;
						num7 = num2;
					}
					continue;
				}
				case 0u:
					num += Owner.addCdValue_Unique;
					num2 = ((int)num3 * -2037061676) ^ 0x919CCCD;
					continue;
				case 7u:
					num2 = (int)(num3 * 2065683516) ^ -2141664696;
					continue;
				case 5u:
				{
					int num4;
					if (SkillType != SkillType.Special)
					{
						num2 = 365808300;
						num4 = num2;
					}
					else
					{
						num2 = 2038612614;
						num4 = num2;
					}
					continue;
				}
				default:
					CurrentCd += _200C_200B_200C_206C_200E_202D_206E_200B_200E_202C_202A_202B_206E_200F_206B_206B_206A_202A_206E_202A_206D_200C_202B_202C_206A_202B_200B_200B_206B_202A_202A_200D_206C_206C_206D_202E_200D_202B_200E_202E_202E(0, Cd - num);
					return;
				}
				break;
			}
		}
	}

	public string GetStatusString()
	{
		SkillStatus status = Status;
		while (true)
		{
			int num = 196907843;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x50D7141D)) % 10)
				{
				case 3u:
					break;
				case 5u:
					return ResourceStrings.ResStrings[573];
				case 8u:
					num = (int)(num2 * 28803907) ^ -142846013;
					continue;
				case 2u:
					switch (status)
					{
					case SkillStatus.NoBalls:
						break;
					default:
						goto IL_008d;
					case SkillStatus.Error:
						goto IL_009f;
					case SkillStatus.Seal:
						goto IL_00b4;
					case SkillStatus.Ok:
						goto IL_00ce;
					case SkillStatus.NoMp:
						goto IL_00e8;
					case SkillStatus.NoCd:
						goto IL_0102;
					}
					goto case 5u;
				case 1u:
					goto IL_009f;
				case 4u:
					goto IL_00b4;
				case 6u:
					goto IL_00ce;
				case 7u:
					goto IL_00e8;
				case 9u:
					goto IL_0102;
				default:
					{
						return global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1184748534u);
					}
					IL_0102:
					return ResourceStrings.ResStrings[574];
					IL_00e8:
					return ResourceStrings.ResStrings[575];
					IL_00ce:
					return ResourceStrings.ResStrings[572];
					IL_00b4:
					return ResourceStrings.ResStrings[576];
					IL_009f:
					return global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1184748534u);
					IL_008d:
					num = ((int)num2 * -1506385885) ^ 0x69B1B7E7;
					continue;
				}
				break;
			}
		}
	}

	public virtual List<LocationBlock> GetSkillCastBlocks(int x, int y)
	{
		List<LocationBlock> list = new List<LocationBlock>();
		int mAX_Y = default(int);
		bool flag = default(bool);
		int num9 = default(int);
		int castSize = default(int);
		int num8 = default(int);
		int num7 = default(int);
		int num13 = default(int);
		int mAX_X = default(int);
		while (true)
		{
			int num = 1213123485;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x11D3F01F)) % 38)
				{
				case 12u:
					break;
				case 24u:
				{
					int num18;
					if (x + 1 < BattleField.MAX_X)
					{
						num = 2109258369;
						num18 = num;
					}
					else
					{
						num = 1564676762;
						num18 = num;
					}
					continue;
				}
				case 25u:
					mAX_Y = BattleField.MAX_Y;
					num = (int)((num2 * 1456758287) ^ 0x5428B1AA);
					continue;
				case 5u:
				{
					int num19;
					int num20;
					if (CoverType != SkillCoverType.FRONT)
					{
						num19 = 1400101696;
						num20 = num19;
					}
					else
					{
						num19 = 1258305948;
						num20 = num19;
					}
					num = num19 ^ ((int)num2 * -2048993969);
					continue;
				}
				case 4u:
					flag = true;
					num = 656819066;
					continue;
				case 1u:
				{
					int num26;
					if (num9 <= castSize)
					{
						num = 1818470222;
						num26 = num;
					}
					else
					{
						num = 962257820;
						num26 = num;
					}
					continue;
				}
				case 14u:
				{
					int num34;
					int num35;
					if (num8 >= mAX_Y)
					{
						num34 = 2142426137;
						num35 = num34;
					}
					else
					{
						num34 = 1316134139;
						num35 = num34;
					}
					num = num34 ^ (int)(num2 * 1169850347);
					continue;
				}
				case 6u:
					list.Add(new LocationBlock
					{
						X = x + 1,
						Y = y
					});
					num = (int)(num2 * 627828347) ^ -538714256;
					continue;
				case 16u:
					num7 = -castSize;
					num = ((int)num2 * -1099814272) ^ 0x50A2EA7D;
					continue;
				case 9u:
					num9 = -castSize;
					num = 1213108994;
					continue;
				case 21u:
				{
					int num24;
					if (_202D_206B_200F_200D_202A_202D_206D_200B_206D_202C_206F_206C_206D_200D_206E_206D_206E_206C_206E_202A_206A_206F_200B_206F_202E_202D_206B_206C_200F_200F_202B_206B_202A_206A_200C_206F_206B_200D_206A_202E_202E(num9) + _202D_206B_200F_200D_202A_202D_206D_200B_206D_202C_206F_206C_206D_200D_206E_206D_206E_206C_206E_202A_206A_206F_200B_206F_202E_202D_206B_206C_200F_200F_202B_206B_202A_206A_200C_206F_206B_200D_206A_202E_202E(num7) > castSize)
					{
						num = 193264681;
						num24 = num;
					}
					else
					{
						num = 1971925878;
						num24 = num;
					}
					continue;
				}
				case 31u:
				{
					int num14;
					int num15;
					if (num13 < mAX_X)
					{
						num14 = 1627964503;
						num15 = num14;
					}
					else
					{
						num14 = 880581658;
						num15 = num14;
					}
					num = num14 ^ ((int)num2 * -1555365090);
					continue;
				}
				case 8u:
					castSize = GetCastSize();
					num = 1304806559;
					continue;
				case 29u:
					num = ((int)num2 * -1933485328) ^ -595120244;
					continue;
				case 22u:
				{
					int num31;
					int num32;
					if (HitSelf)
					{
						num31 = 1235579187;
						num32 = num31;
					}
					else
					{
						num31 = 1870991662;
						num32 = num31;
					}
					num = num31 ^ ((int)num2 * -1343740810);
					continue;
				}
				case 23u:
				{
					int num28;
					if (y - 1 >= 0)
					{
						num = 34821652;
						num28 = num;
					}
					else
					{
						num = 1555153065;
						num28 = num;
					}
					continue;
				}
				case 34u:
				{
					int num22;
					int num23;
					if (num7 == 0)
					{
						num22 = 1844133021;
						num23 = num22;
					}
					else
					{
						num22 = 2035787202;
						num23 = num22;
					}
					num = num22 ^ (int)(num2 * 66928418);
					continue;
				}
				case 18u:
					list.Add(new LocationBlock
					{
						X = num13,
						Y = num8
					});
					num = ((int)num2 * -1913418256) ^ 0x4C71B6E9;
					continue;
				case 2u:
				{
					int num12;
					if (num7 > castSize)
					{
						num = 2036583344;
						num12 = num;
					}
					else
					{
						num = 929831763;
						num12 = num;
					}
					continue;
				}
				case 10u:
				{
					flag = false;
					int num5;
					int num6;
					if (CoverType == SkillCoverType.NORMAL)
					{
						num5 = -964609359;
						num6 = num5;
					}
					else
					{
						num5 = -1058994409;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1752530714);
					continue;
				}
				case 0u:
					num7++;
					num = 1583352879;
					continue;
				case 30u:
				{
					int num33;
					if (!flag)
					{
						num = 1416763365;
						num33 = num;
					}
					else
					{
						num = 523789686;
						num33 = num;
					}
					continue;
				}
				case 36u:
				{
					int num29;
					int num30;
					if (CoverType != SkillCoverType.LINE)
					{
						num29 = -1596877904;
						num30 = num29;
					}
					else
					{
						num29 = -1135092237;
						num30 = num29;
					}
					num = num29 ^ ((int)num2 * -345803450);
					continue;
				}
				case 20u:
					mAX_X = BattleField.MAX_X;
					num = (int)((num2 * 1171875049) ^ 0x54E53F4C);
					continue;
				case 37u:
				{
					int num27;
					if (y + 1 >= BattleField.MAX_Y)
					{
						num = 380447450;
						num27 = num;
					}
					else
					{
						num = 2116733090;
						num27 = num;
					}
					continue;
				}
				case 7u:
				{
					int num25;
					if (x - 1 < 0)
					{
						num = 146051580;
						num25 = num;
					}
					else
					{
						num = 1945293270;
						num25 = num;
					}
					continue;
				}
				case 32u:
					num = (int)(num2 * 1116388737) ^ -63494579;
					continue;
				case 19u:
					list.Add(new LocationBlock
					{
						X = x + -1,
						Y = y
					});
					num = ((int)num2 * -599241241) ^ -1222483805;
					continue;
				case 28u:
					return list;
				case 17u:
					list.Add(new LocationBlock
					{
						X = x,
						Y = y + 1
					});
					num = (int)((num2 * 923472934) ^ 0x34211AD4);
					continue;
				case 35u:
				{
					num13 = x + num9;
					int num21;
					if (num13 < 0)
					{
						num = 2036583344;
						num21 = num;
					}
					else
					{
						num = 1438872132;
						num21 = num;
					}
					continue;
				}
				case 33u:
					list.Add(new LocationBlock
					{
						X = x,
						Y = y - 1
					});
					num = (int)(num2 * 1935956005) ^ -1115289794;
					continue;
				case 3u:
				{
					int num16;
					int num17;
					if (num8 < 0)
					{
						num16 = -131151188;
						num17 = num16;
					}
					else
					{
						num16 = -1238869494;
						num17 = num16;
					}
					num = num16 ^ ((int)num2 * -261443053);
					continue;
				}
				case 15u:
					num9++;
					num = 835007164;
					continue;
				case 26u:
				{
					int num10;
					int num11;
					if (num9 != 0)
					{
						num10 = -2030751892;
						num11 = num10;
					}
					else
					{
						num10 = -2067997761;
						num11 = num10;
					}
					num = num10 ^ ((int)num2 * -1839932847);
					continue;
				}
				case 27u:
					num8 = y + num7;
					num = ((int)num2 * -1172667370) ^ -1794812130;
					continue;
				case 11u:
				{
					int num3;
					int num4;
					if (CoverType == SkillCoverType.FAN)
					{
						num3 = -1865528355;
						num4 = num3;
					}
					else
					{
						num3 = -850859376;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1905676042);
					continue;
				}
				default:
					return list;
				}
				break;
			}
		}
	}

	public virtual List<LocationBlock> GetSkillCoverBlocks(int x, int y, int spx, int spy)
	{
		return new SkillCoverTypeHelper(CoverType).GetSkillCoverBlocks(x, y, spx, spy, GetSize());
	}

	private int GetSize()
	{
		int num = Size;
		BuffInstance buff = default(BuffInstance);
		int num8 = default(int);
		while (true)
		{
			int num2 = 182911731;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x6F74BAD3)) % 30)
				{
				case 0u:
					break;
				case 19u:
					num2 = ((int)num3 * -1525234779) ^ 0x4C919E2F;
					continue;
				case 29u:
					num = 1;
					num2 = 1990381946;
					continue;
				case 10u:
					buff = Owner.Sprite.GetBuff(ResourceStrings.ResStrings[529]);
					num2 = 1473285277;
					continue;
				case 21u:
				{
					int num12;
					int num13;
					if (Owner.BuiltInTalents[23])
					{
						num12 = 1206331192;
						num13 = num12;
					}
					else
					{
						num12 = 394200799;
						num13 = num12;
					}
					num2 = num12 ^ (int)(num3 * 1198433218);
					continue;
				}
				case 20u:
					num = _200C_200B_200C_206C_200E_202D_206E_200B_200E_202C_202A_202B_206E_200F_206B_206B_206A_202A_206E_202A_206D_200C_202B_202C_206A_202B_200B_200B_206B_202A_202A_200D_206C_206C_206D_202E_200D_202B_200E_202E_202E(1, num8 - 1);
					num2 = 1726849498;
					continue;
				case 25u:
					num++;
					num2 = 1868289149;
					continue;
				case 8u:
				{
					int num25;
					if (CommonSettings.MOD_KEY() == 1)
					{
						num2 = 1800874751;
						num25 = num2;
					}
					else
					{
						num2 = 520581152;
						num25 = num2;
					}
					continue;
				}
				case 5u:
					num2 = (int)((num3 * 905630163) ^ 0x1F441491);
					continue;
				case 24u:
					num++;
					num2 = ((int)num3 * -1546438507) ^ -1333723809;
					continue;
				case 16u:
					num2 = ((int)num3 * -1415881146) ^ -452880179;
					continue;
				case 13u:
					num = 0;
					num2 = (int)((num3 * 1667957725) ^ 0x5EE7F277);
					continue;
				case 14u:
				{
					int num28;
					int num29;
					if (Owner == null)
					{
						num28 = 789143956;
						num29 = num28;
					}
					else
					{
						num28 = 2143178902;
						num29 = num28;
					}
					num2 = num28 ^ (int)(num3 * 119770368);
					continue;
				}
				case 22u:
				{
					int num23;
					int num24;
					if (buff == null)
					{
						num23 = -412663300;
						num24 = num23;
					}
					else
					{
						num23 = -914613916;
						num24 = num23;
					}
					num2 = num23 ^ ((int)num3 * -1903016139);
					continue;
				}
				case 27u:
				{
					int num20;
					if (Owner.BuiltInTalents[21])
					{
						num2 = 427015377;
						num20 = num2;
					}
					else
					{
						num2 = 1375190873;
						num20 = num2;
					}
					continue;
				}
				case 26u:
					num8 = num;
					num2 = ((int)num3 * -998825902) ^ 0x4FFEE786;
					continue;
				case 15u:
				{
					int num14;
					int num15;
					if (num8 <= 0)
					{
						num14 = 1159709697;
						num15 = num14;
					}
					else
					{
						num14 = 1958382269;
						num15 = num14;
					}
					num2 = num14 ^ (int)(num3 * 1200925173);
					continue;
				}
				case 11u:
				{
					int num9;
					int num10;
					if (_206E_202A_202D_206E_202A_200B_200F_206F_206B_206F_202A_202B_202A_206F_200C_202D_200D_202B_206F_202E_202B_202E_200D_202A_200E_200E_206A_202D_200D_206B_202D_206B_200C_202C_202B_200D_206F_206C_200D_200D_202E((Object)(object)Owner.Sprite, (Object)null))
					{
						num9 = -1457399179;
						num10 = num9;
					}
					else
					{
						num9 = -1395316388;
						num10 = num9;
					}
					num2 = num9 ^ ((int)num3 * -902655251);
					continue;
				}
				case 9u:
					_202D_202B_206B_202B_202E_202E_200C_200B_206C_200C_200C_200E_202B_202A_206A_200D_206F_200C_206F_202E_200F_202E_200E_200E_202C_200E_206A_206C_206C_206A_202E_202E_202E_200E_202A_206F_206F_206C_200F_202E((object)global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2169626371u));
					num2 = 934009955;
					continue;
				case 12u:
					num += 3;
					num2 = (int)((num3 * 890386392) ^ 0x61292DDC);
					continue;
				case 17u:
				{
					int num26;
					int num27;
					if (!_202E_200B_202C_200B_202D_200B_200E_202A_206B_206F_202D_206F_206B_206A_202D_206B_200F_200D_202C_202D_202C_202A_202A_202D_200B_200C_200F_206C_200C_206A_200E_206B_202A_202C_206A_200B_200D_202B_206E_206C_202E(Name, ResourceStrings.ResStrings[641]))
					{
						num26 = 1094970899;
						num27 = num26;
					}
					else
					{
						num26 = 1361872754;
						num27 = num26;
					}
					num2 = num26 ^ ((int)num3 * -2040170542);
					continue;
				}
				case 28u:
					num++;
					num2 = ((int)num3 * -317611052) ^ 0x273180F1;
					continue;
				case 23u:
				{
					num -= (int)((double)buff.Level * 1.5);
					int num21;
					int num22;
					if (num > 0)
					{
						num21 = -1959310323;
						num22 = num21;
					}
					else
					{
						num21 = -296512178;
						num22 = num21;
					}
					num2 = num21 ^ ((int)num3 * -939605774);
					continue;
				}
				case 7u:
				{
					int num18;
					int num19;
					if (Type == 1)
					{
						num18 = 1755002203;
						num19 = num18;
					}
					else
					{
						num18 = 1141021375;
						num19 = num18;
					}
					num2 = num18 ^ ((int)num3 * -975110018);
					continue;
				}
				case 1u:
				{
					int num16;
					int num17;
					if (!_202E_200B_202C_200B_202D_200B_200E_202A_206B_206F_202D_206F_206B_206A_202D_206B_200F_200D_202C_202D_202C_202A_202A_202D_200B_200C_200F_206C_200C_206A_200E_206B_202A_202C_206A_200B_200D_202B_206E_206C_202E(Name, ResourceStrings.ResStrings[640]))
					{
						num16 = 1761218369;
						num17 = num16;
					}
					else
					{
						num16 = 2070478583;
						num17 = num16;
					}
					num2 = num16 ^ (int)(num3 * 1547591441);
					continue;
				}
				case 3u:
				{
					int num11;
					if (Owner.BuiltInTalents[20])
					{
						num2 = 456331023;
						num11 = num2;
					}
					else
					{
						num2 = 1453038833;
						num11 = num2;
					}
					continue;
				}
				case 4u:
					return num;
				case 2u:
				{
					int num6;
					int num7;
					if (!Owner.BuiltInTalents[206])
					{
						num6 = 1865657277;
						num7 = num6;
					}
					else
					{
						num6 = 535604858;
						num7 = num6;
					}
					num2 = num6 ^ ((int)num3 * -727817653);
					continue;
				}
				case 18u:
				{
					int num4;
					int num5;
					if (Type == 3)
					{
						num4 = -40082671;
						num5 = num4;
					}
					else
					{
						num4 = -1320427171;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num3 * -823129427);
					continue;
				}
				default:
					return num;
				}
				break;
			}
		}
	}

	private int GetCastSize()
	{
		if (Owner != null)
		{
			BuffInstance buff = default(BuffInstance);
			int num8 = default(int);
			int num3 = default(int);
			while (true)
			{
				int num = 1297723711;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x77101CB9)) % 22)
					{
					case 17u:
						break;
					case 19u:
					{
						buff = Owner.Sprite.GetBuff(ResourceStrings.ResStrings[529]);
						int num11;
						int num12;
						if (buff != null)
						{
							num11 = 1736359270;
							num12 = num11;
						}
						else
						{
							num11 = 1761426692;
							num12 = num11;
						}
						num = num11 ^ (int)(num2 * 294961446);
						continue;
					}
					case 12u:
					{
						int num15;
						int num16;
						if (!_200C_200E_206F_202C_202D_202E_202B_202A_202D_202A_202E_206F_202D_202E_202B_200E_200F_200E_200D_202A_200C_202C_206C_200E_206F_202B_202E_202C_202C_202D_206C_206A_202C_200E_206B_202B_206E_206D_202E_200E_202E(Name, ResourceStrings.ResStrings[643]))
						{
							num15 = -773960280;
							num16 = num15;
						}
						else
						{
							num15 = -1480374771;
							num16 = num15;
						}
						num = num15 ^ (int)(num2 * 2145407944);
						continue;
					}
					case 16u:
					{
						int num13;
						int num14;
						if (!_206E_202A_202D_206E_202A_200B_200F_206F_206B_206F_202A_202B_202A_206F_200C_202D_200D_202B_206F_202E_202B_202E_200D_202A_200E_200E_206A_202D_200D_206B_202D_206B_200C_202C_202B_200D_206F_206C_200D_200D_202E((Object)(object)Owner.Sprite, (Object)null))
						{
							num13 = -1199713418;
							num14 = num13;
						}
						else
						{
							num13 = -1607225764;
							num14 = num13;
						}
						num = num13 ^ ((int)num2 * -1517002865);
						continue;
					}
					case 20u:
						num8 = num3;
						num = (int)((num2 * 857830706) ^ 0x632B11CF);
						continue;
					case 4u:
						num = ((int)num2 * -992768527) ^ 0x5565948A;
						continue;
					case 18u:
						num3 = _200C_200B_200C_206C_200E_202D_206E_200B_200E_202C_202A_202B_206E_200F_206B_206B_206A_202A_206E_202A_206D_200C_202B_202C_206A_202B_200B_200B_206B_202A_202A_200D_206C_206C_206D_202E_200D_202B_200E_202E_202E(1, num8 - 1);
						num = 1204897174;
						continue;
					case 9u:
					{
						int num6;
						int num7;
						if (!Owner.BuiltInTalents[23])
						{
							num6 = -1312591239;
							num7 = num6;
						}
						else
						{
							num6 = -717761216;
							num7 = num6;
						}
						num = num6 ^ ((int)num2 * -422110930);
						continue;
					}
					case 13u:
						goto IL_018d;
					case 0u:
						num3 -= (int)((double)buff.Level * 1.5);
						num = ((int)num2 * -1107307219) ^ -593942827;
						continue;
					case 2u:
						goto IL_01cb;
					case 3u:
						goto IL_01fa;
					case 21u:
						goto end_IL_000b;
					case 5u:
					{
						int num17;
						int num18;
						if (!_202E_200B_202C_200B_202D_200B_200E_202A_206B_206F_202D_206F_206B_206A_202D_206B_200F_200D_202C_202D_202C_202A_202A_202D_200B_200C_200F_206C_200C_206A_200E_206B_202A_202C_206A_200B_200D_202B_206E_206C_202E(Name, ResourceStrings.ResStrings[642]))
						{
							num17 = 1746032944;
							num18 = num17;
						}
						else
						{
							num17 = 557839263;
							num18 = num17;
						}
						num = num17 ^ ((int)num2 * -1900622282);
						continue;
					}
					case 11u:
						num3 = 1;
						num = (int)((num2 * 573639354) ^ 0x37E60F1B);
						continue;
					case 14u:
						num3 += 3;
						num = ((int)num2 * -1907256012) ^ 0x45193AA;
						continue;
					case 8u:
					{
						int num9;
						int num10;
						if (num3 > 0)
						{
							num9 = -1318495249;
							num10 = num9;
						}
						else
						{
							num9 = -125929580;
							num10 = num9;
						}
						num = num9 ^ (int)(num2 * 2086664445);
						continue;
					}
					case 7u:
						goto IL_02b2;
					case 1u:
						return LuaManager.CallWithIntReturn(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(960000407u), this, Owner, num3);
					case 10u:
						return 10;
					case 15u:
					{
						int num4;
						int num5;
						if (_200C_200E_206F_202C_202D_202E_202B_202A_202D_202A_202E_206F_202D_202E_202B_200E_200F_200E_200D_202A_200C_202C_206C_200E_206F_202B_202E_202C_202C_202D_206C_206A_202C_200E_206B_202B_206E_206D_202E_200E_202E(Name, ResourceStrings.ResStrings[644]))
						{
							num4 = 1268684858;
							num5 = num4;
						}
						else
						{
							num4 = 564833194;
							num5 = num4;
						}
						num = num4 ^ (int)(num2 * 728969159);
						continue;
					}
					default:
						return num3;
					}
					break;
					IL_02b2:
					int num19;
					if (!Owner.BuiltInTalents[25])
					{
						num = 1245963293;
						num19 = num;
					}
					else
					{
						num = 33721097;
						num19 = num;
					}
					continue;
					IL_01cb:
					num3 = CastSize;
					int num20;
					if (!Owner.BuiltInTalents[22])
					{
						num = 1770813146;
						num20 = num;
					}
					else
					{
						num = 1357251222;
						num20 = num;
					}
					continue;
					IL_018d:
					int num21;
					if (num3 == 0)
					{
						num = 1204897174;
						num21 = num;
					}
					else
					{
						num = 1226406282;
						num21 = num;
					}
					continue;
					IL_01fa:
					int num22;
					if (CommonSettings.MOD_KEY() != 0)
					{
						num = 2010956302;
						num22 = num;
					}
					else
					{
						num = 1719928067;
						num22 = num;
					}
				}
				continue;
				end_IL_000b:
				break;
			}
		}
		_202D_202B_206B_202B_202E_202E_200C_200B_206C_200C_200C_200E_202B_202A_206A_200D_206F_200C_206F_202E_200F_202E_200E_200E_202C_200E_206A_206C_206C_206A_202E_202E_202E_200E_202A_206F_206F_206C_200F_202E((object)global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3253068326u));
		return -1;
	}

	public virtual bool TryAddExp(int exp)
	{
		return false;
	}

	public string GetTypeChinese()
	{
		int type = Type;
		while (true)
		{
			int num = 1298305204;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)(num ^ 0x5146B10)) % 12)
				{
				case 6u:
					break;
				case 2u:
					return ResourceStrings.ResStrings[581];
				case 7u:
					return ResourceStrings.ResStrings[577];
				case 0u:
					goto IL_007f;
				case 1u:
					num = (int)((num2 * 497805003) ^ 0x77F416AC);
					continue;
				case 11u:
					goto IL_00ab;
				case 9u:
					goto IL_00c5;
				case 8u:
					switch (type)
					{
					case 0:
						break;
					case 5:
						goto IL_007f;
					case 2:
						goto IL_00ab;
					case 1:
						goto IL_00c5;
					default:
						goto IL_00fd;
					case 3:
						goto IL_010f;
					case 4:
						goto IL_0129;
					}
					goto case 7u;
				case 10u:
					goto IL_010f;
				case 5u:
					goto IL_0129;
				case 4u:
					return string.Empty;
				default:
					{
						return string.Empty;
					}
					IL_0129:
					if (SkillType != SkillType.Internal)
					{
						num = 1387439714;
						num3 = num;
					}
					else
					{
						num = 2059840264;
						num3 = num;
					}
					continue;
					IL_010f:
					return ResourceStrings.ResStrings[580];
					IL_00fd:
					num = (int)(num2 * 1699043647) ^ -1456678887;
					continue;
					IL_00c5:
					return ResourceStrings.ResStrings[578];
					IL_00ab:
					return ResourceStrings.ResStrings[579];
					IL_007f:
					return ResourceStrings.ResStrings[582];
				}
				break;
			}
		}
	}

	public virtual int GetCoverTypePower()
	{
		return new SkillCoverTypeHelper(CoverType).GetCoverTypePower();
	}

	static string _200E_206C_206E_202E_206F_200C_206C_200F_200D_202A_200D_200F_200B_206C_200E_200B_206C_206F_200D_206C_202A_206C_200F_202A_202B_206F_206F_200F_200C_206F_206A_200B_200F_206E_200B_206B_202C_200C_200C_206D_202E(string P_0, object P_1, object P_2)
	{
		return string.Format(P_0, P_1, P_2);
	}

	static string _202D_200D_202C_202B_206E_206D_202D_206F_200B_200C_200B_206F_200C_202A_202D_202D_206A_200B_206B_200F_206E_200C_206E_206A_206A_206C_206C_200D_206B_202E_206F_200D_200C_200C_202B_200C_202A_200D_206E_206E_202E(string P_0, string P_1)
	{
		return P_0 + P_1;
	}

	static string _200C_202D_200C_206C_206F_202E_202B_202E_200B_206B_200E_202B_206D_202A_206B_202C_206A_202D_200B_200F_206C_200C_200B_200E_200E_202E_206D_206F_200D_206A_200D_206B_206B_200C_202E_206B_206E_206D_200E_200E_202E(string P_0, object P_1)
	{
		return string.Format(P_0, P_1);
	}

	static string _202C_202B_202C_206E_206C_200D_200B_206A_200E_202A_206D_202B_202A_202E_206D_202C_202C_206A_202C_200D_200F_206F_200B_206C_206E_206F_206C_206C_202A_202C_202C_206C_202E_206E_200E_206B_200D_202B_206E_200D_202E(string P_0, object[] P_1)
	{
		return string.Format(P_0, P_1);
	}

	static bool _202E_202C_200E_202A_202D_202E_202C_200D_202D_206A_200F_206F_202C_202B_206C_202E_202B_200D_206C_200B_206B_200F_206D_202B_206D_202B_202E_206D_206B_200D_206B_206F_206D_200E_202C_206A_202A_202E_206C_200C_202E(IEnumerator P_0)
	{
		return P_0.MoveNext();
	}

	static void _206C_202E_206B_202C_206F_202C_200B_206B_200F_200D_200C_206A_202A_202D_206A_202C_200D_202E_206C_206B_202E_206B_200E_206F_200D_206B_202D_202B_200C_202E_200B_200C_206D_200D_202C_200E_206A_200D_206B_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}

	static int _200C_200B_200C_206C_200E_202D_206E_200B_200E_202C_202A_202B_206E_200F_206B_206B_206A_202A_206E_202A_206D_200C_202B_202C_206A_202B_200B_200B_206B_202A_202A_200D_206C_206C_206D_202E_200D_202B_200E_202E_202E(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	static bool _206E_202A_202D_206E_202A_200B_200F_206F_206B_206F_202A_202B_202A_206F_200C_202D_200D_202B_206F_202E_202B_202E_200D_202A_200E_200E_206A_202D_200D_206B_202D_206B_200C_202C_202B_200D_206F_206C_200D_200D_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static bool _200C_200E_206F_202C_202D_202E_202B_202A_202D_202A_202E_206F_202D_202E_202B_200E_200F_200E_200D_202A_200C_202C_206C_200E_206F_202B_202E_202C_202C_202D_206C_206A_202C_200E_206B_202B_206E_206D_202E_200E_202E(string P_0, string P_1)
	{
		return P_0 == P_1;
	}

	static int _202D_206B_200F_200D_202A_202D_206D_200B_206D_202C_206F_206C_206D_200D_206E_206D_206E_206C_206E_202A_206A_206F_200B_206F_202E_202D_206B_206C_200F_200F_202B_206B_202A_206A_200C_206F_206B_200D_206A_202E_202E(int P_0)
	{
		return Math.Abs(P_0);
	}

	static void _202D_202B_206B_202B_202E_202E_200C_200B_206C_200C_200C_200E_202B_202A_206A_200D_206F_200C_206F_202E_200F_202E_200E_200E_202C_200E_206A_206C_206C_206A_202E_202E_202E_200E_202A_206F_206F_206C_200F_202E(object P_0)
	{
		Debug.LogError(P_0);
	}

	static bool _202E_200B_202C_200B_202D_200B_200E_202A_206B_206F_202D_206F_206B_206A_202D_206B_200F_200D_202C_202D_202C_202A_202A_202D_200B_200C_200F_206C_200C_206A_200E_206B_202A_202C_206A_200B_200D_202B_206E_206C_202E(string P_0, string P_1)
	{
		return P_0.StartsWith(P_1);
	}

	static string _206B_200C_202C_200D_200D_202B_206C_206F_202A_200C_206C_202C_200F_206C_202D_202E_202E_206D_200C_200B_200B_200C_200C_206B_202E_206E_206F_202B_206B_202D_202D_206A_202C_202A_202E_200B_202A_202A_202D_206B_202E(string P_0, string P_1, string P_2)
	{
		return P_0.Replace(P_1, P_2);
	}
}
