using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace JyGame;

[XmlType("role")]
public class BattleRole
{
	[XmlAttribute("key")]
	public string PredefinedKey;

	[XmlIgnore]
	public bool IsPlayerPickedRole;

	[XmlIgnore]
	private Role _200D_202A_206F_206E_202B_202B_200D_206F_206A_200E_206C_200F_200C_206C_206F_202A_206C_202C_202D_200B_202D_202E_200B_206D_206A_200F_200B_200D_200B_202E_200E_206D_202B_206C_202B_206D_200F_200C_200F_200E_202E;

	[XmlAttribute("team")]
	public int Team = 1;

	[XmlAttribute("x")]
	public int X;

	[XmlAttribute("y")]
	public int Y;

	[XmlAttribute("face")]
	public int Face = 1;

	[XmlAttribute("level")]
	public int Level;

	[XmlAttribute("name")]
	public string Name;

	[XmlAttribute("animation")]
	public string Animation;

	[XmlAttribute("boss")]
	public bool IsBoss;

	[XmlIgnore]
	public int random_level = -1;

	[XmlIgnore]
	public string random_name;

	[XmlAttribute("difficulty")]
	public string Difficulty;

	[XmlAttribute("customname")]
	public string CustomName;

	[XmlIgnore]
	public Role role
	{
		get
		{
			return _200D_202A_206F_206E_202B_202B_200D_206F_206A_200E_206C_200F_200C_206C_206F_202A_206C_202C_202D_200B_202D_202E_200B_206D_206A_200F_200B_200D_200B_202E_200E_206D_202B_206C_202B_206D_200F_200C_200F_200E_202E;
		}
		set
		{
			_200D_202A_206F_206E_202B_202B_200D_206F_206A_200E_206C_200F_200C_206C_206F_202A_206C_202C_202D_200B_202D_202E_200B_206D_206A_200F_200B_200D_200B_202E_200E_206D_202B_206C_202B_206D_200F_200C_200F_200E_202E = value;
		}
	}

	public bool FaceRight => Face == 1;

	public bool IsRandom => random_level != -1;

	[XmlIgnore]
	public List<string> RoleEffect
	{
		get
		{
			if (CommonSettings.MOD_KEY() == 1)
			{
				string text = default(string);
				while (true)
				{
					int num = 445287627;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ 0x7027846A)) % 18)
						{
						case 14u:
							break;
						case 2u:
							goto IL_006e;
						case 12u:
							text = _200B_206B_202A_202C_200E_206A_200C_206A_206E_206F_202A_206F_202B_206A_206C_202B_200C_206A_206C_202E_202B_206D_206A_206E_206E_202B_206C_202C_202A_202D_206C_206F_202C_206A_206E_202D_200F_202D_200C_202E_202E(ResourceStrings.ResStrings[1225], global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3056895177u));
							num = ((int)num2 * -1174909018) ^ -96004255;
							continue;
						case 13u:
							text = _200B_206B_202A_202C_200E_206A_200C_206A_206E_206F_202A_206F_202B_206A_206C_202B_200C_206A_206C_202E_202B_206D_206A_206E_206E_202B_206C_202C_202A_202D_206C_206F_202C_206A_206E_202D_200F_202D_200C_202E_202E(ResourceStrings.ResStrings[1226], global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(788187573u));
							num = (int)((num2 * 1749211074) ^ 0x6875C40F);
							continue;
						case 16u:
							goto IL_0102;
						case 3u:
							text = _200B_206B_202A_202C_200E_206A_200C_206A_206E_206F_202A_206F_202B_206A_206C_202B_200C_206A_206C_202E_202B_206D_206A_206E_206E_202B_206C_202C_202A_202D_206C_206F_202C_206A_206E_202D_200F_202D_200C_202E_202E(ResourceStrings.ResStrings[1228], global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(381486884u));
							num = (int)((num2 * 294930663) ^ 0x66D4F0DA);
							continue;
						case 9u:
							text = _200B_206B_202A_202C_200E_206A_200C_206A_206E_206F_202A_206F_202B_206A_206C_202B_200C_206A_206C_202E_202B_206D_206A_206E_206E_202B_206C_202C_202A_202D_206C_206F_202C_206A_206E_202D_200F_202D_200C_202E_202E(ResourceStrings.ResStrings[1227], global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2677286555u));
							num = ((int)num2 * -117341412) ^ -1909995062;
							continue;
						case 7u:
							text = null;
							num = (int)(num2 * 1995079529) ^ -650582999;
							continue;
						case 0u:
							goto IL_01ab;
						case 6u:
							num = ((int)num2 * -1708830670) ^ -1795440557;
							continue;
						case 15u:
							num = ((int)num2 * -2068315427) ^ -1617710216;
							continue;
						case 1u:
							goto IL_0201;
						case 8u:
						{
							int num3;
							int num4;
							if (!_200D_202A_206F_206E_202B_202B_200D_206F_206A_200E_206C_200F_200C_206C_206F_202A_206C_202C_202D_200B_202D_202E_200B_206D_206A_200F_200B_200D_200B_202E_200E_206D_202B_206C_202B_206D_200F_200C_200F_200E_202E.HasTalent(ResourceStrings.ResStrings[1224]))
							{
								num3 = 868251760;
								num4 = num3;
							}
							else
							{
								num3 = 1907841784;
								num4 = num3;
							}
							num = num3 ^ ((int)num2 * -1247112598);
							continue;
						}
						case 11u:
							num = (int)(num2 * 869840825) ^ -345190860;
							continue;
						case 4u:
							text = _200B_206B_202A_202C_200E_206A_200C_206A_206E_206F_202A_206F_202B_206A_206C_202B_200C_206A_206C_202E_202B_206D_206A_206E_206E_202B_206C_202C_202A_202D_206C_206F_202C_206A_206E_202D_200F_202D_200C_202E_202E(ResourceStrings.ResStrings[1224], global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3444952987u));
							num = ((int)num2 * -2078782368) ^ -1465274021;
							continue;
						case 17u:
							goto IL_029b;
						case 10u:
							return new List<string>(_200E_206C_202B_202E_202C_206C_206A_202A_200E_200F_202A_206C_206A_206F_206A_206D_202E_200E_206E_206C_200B_206C_202D_200C_206F_206C_200B_202D_202B_200F_202A_202D_202A_206A_200F_206D_202E_202A_206F_202A_202E(text, new char[1] { ',' }));
						default:
							goto end_IL_000b;
						}
						break;
						IL_029b:
						int num5;
						if (!_200D_202A_206F_206E_202B_202B_200D_206F_206A_200E_206C_200F_200C_206C_206F_202A_206C_202C_202D_200B_202D_202E_200B_206D_206A_200F_200B_200D_200B_202E_200E_206D_202B_206C_202B_206D_200F_200C_200F_200E_202E.HasTalent(ResourceStrings.ResStrings[1227]))
						{
							num = 209014934;
							num5 = num;
						}
						else
						{
							num = 892139989;
							num5 = num;
						}
						continue;
						IL_006e:
						int num6;
						if (!_200D_202A_206F_206E_202B_202B_200D_206F_206A_200E_206C_200F_200C_206C_206F_202A_206C_202C_202D_200B_202D_202E_200B_206D_206A_200F_200B_200D_200B_202E_200E_206D_202B_206C_202B_206D_200F_200C_200F_200E_202E.HasTalent(ResourceStrings.ResStrings[1226]))
						{
							num = 1207036785;
							num6 = num;
						}
						else
						{
							num = 356959019;
							num6 = num;
						}
						continue;
						IL_01ab:
						int num7;
						if (!_200D_202A_206F_206E_202B_202B_200D_206F_206A_200E_206C_200F_200C_206C_206F_202A_206C_202C_202D_200B_202D_202E_200B_206D_206A_200F_200B_200D_200B_202E_200E_206D_202B_206C_202B_206D_200F_200C_200F_200E_202E.HasTalent(ResourceStrings.ResStrings[1225]))
						{
							num = 710084396;
							num7 = num;
						}
						else
						{
							num = 191623892;
							num7 = num;
						}
						continue;
						IL_0201:
						int num8;
						if (!_206F_206D_202A_200F_200D_206E_202A_200E_200C_206E_200B_200C_206F_200F_202B_202B_202E_206E_200E_200E_206A_200B_206A_206C_202C_206A_202D_200C_206F_206B_206C_202D_200D_202D_202D_206E_206E_200E_206B_200E_202E(text))
						{
							num = 294349486;
							num8 = num;
						}
						else
						{
							num = 682648287;
							num8 = num;
						}
						continue;
						IL_0102:
						int num9;
						if (!_200D_202A_206F_206E_202B_202B_200D_206F_206A_200E_206C_200F_200C_206C_206F_202A_206C_202C_202D_200B_202D_202E_200B_206D_206A_200F_200B_200D_200B_202E_200E_206D_202B_206C_202B_206D_200F_200C_200F_200E_202E.HasTalent(ResourceStrings.ResStrings[1228]))
						{
							num = 1219456283;
							num9 = num;
						}
						else
						{
							num = 1665188733;
							num9 = num;
						}
					}
					continue;
					end_IL_000b:
					break;
				}
			}
			List<string> argvs = default(List<string>);
			using (List<Trigger>.Enumerator enumerator = _200D_202A_206F_206E_202B_202B_200D_206F_206A_200E_206C_200F_200C_206C_206F_202A_206C_202C_202D_200B_202D_202E_200B_206D_206A_200F_200B_200D_200B_202E_200E_206D_202B_206C_202B_206D_200F_200C_200F_200E_202E.EquippedInternalSkill.InternalSkill.Triggers.GetEnumerator())
			{
				Trigger current = default(Trigger);
				while (true)
				{
					IL_03c8:
					int num10;
					int num11;
					if (enumerator.MoveNext())
					{
						num10 = 1011769378;
						num11 = num10;
					}
					else
					{
						num10 = 1957553311;
						num11 = num10;
					}
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num10 ^ 0x7027846A)) % 6)
						{
						case 0u:
							num10 = 1011769378;
							continue;
						default:
							goto end_IL_031a;
						case 4u:
						{
							current = enumerator.Current;
							int num14;
							if (_206D_202C_200B_200C_206B_206E_202D_206C_200F_202B_206E_206D_200E_202C_200C_206B_200D_206B_206B_200C_206D_206C_200D_206A_202E_200D_200E_202D_206E_200C_206A_206E_200C_202E_200C_202A_206F_200E_200F_206D_202E(current.Name, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1491498244u)))
							{
								num10 = 1915272816;
								num14 = num10;
							}
							else
							{
								num10 = 935837761;
								num14 = num10;
							}
							continue;
						}
						case 5u:
							argvs = current.Argvs;
							goto IL_087f;
						case 2u:
						{
							int num12;
							int num13;
							if (_200D_202A_206F_206E_202B_202B_200D_206F_206A_200E_206C_200F_200C_206C_206F_202A_206C_202C_202D_200B_202D_202E_200B_206D_206A_200F_200B_200D_200B_202E_200E_206D_202B_206C_202B_206D_200F_200C_200F_200E_202E.EquippedInternalSkill.level >= current.Level)
							{
								num12 = 173121869;
								num13 = num12;
							}
							else
							{
								num12 = 1474214335;
								num13 = num12;
							}
							num10 = num12 ^ ((int)num2 * -1126893765);
							continue;
						}
						case 1u:
							break;
						case 3u:
							goto end_IL_031a;
						}
						goto IL_03c8;
						continue;
						end_IL_031a:
						break;
					}
					break;
				}
			}
			Trigger current3 = default(Trigger);
			foreach (InternalSkillInstance internalSkill in _200D_202A_206F_206E_202B_202B_200D_206F_206A_200E_206C_200F_200C_206C_206F_202A_206C_202C_202D_200B_202D_202E_200B_206D_206A_200F_200B_200D_200B_202E_200E_206D_202B_206C_202B_206D_200F_200C_200F_200E_202E.InternalSkills)
			{
				using List<Trigger>.Enumerator enumerator = internalSkill.InternalSkill.Triggers.GetEnumerator();
				while (true)
				{
					IL_045b:
					int num15;
					int num16;
					if (enumerator.MoveNext())
					{
						num15 = 1139089882;
						num16 = num15;
					}
					else
					{
						num15 = 2056741486;
						num16 = num15;
					}
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num15 ^ 0x7027846A)) % 6)
						{
						case 2u:
							num15 = 1139089882;
							continue;
						default:
							goto end_IL_042e;
						case 3u:
							break;
						case 5u:
						{
							int num18;
							int num19;
							if (internalSkill.level < current3.Level)
							{
								num18 = 900816862;
								num19 = num18;
							}
							else
							{
								num18 = 1241536924;
								num19 = num18;
							}
							num15 = num18 ^ ((int)num2 * -746131957);
							continue;
						}
						case 4u:
						{
							current3 = enumerator.Current;
							int num17;
							if (!_206D_202C_200B_200C_206B_206E_202D_206C_200F_202B_206E_206D_200E_202C_200C_206B_200D_206B_206B_200C_206D_206C_200D_206A_202E_200D_200E_202D_206E_200C_206A_206E_200C_202E_200C_202A_206F_200E_200F_206D_202E(current3.Name, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3878009085u)))
							{
								num15 = 1871646277;
								num17 = num15;
							}
							else
							{
								num15 = 538652891;
								num17 = num15;
							}
							continue;
						}
						case 1u:
							argvs = current3.Argvs;
							goto IL_087f;
						case 0u:
							goto end_IL_042e;
						}
						goto IL_045b;
						continue;
						end_IL_042e:
						break;
					}
					break;
				}
			}
			using (List<SkillInstance>.Enumerator enumerator3 = _200D_202A_206F_206E_202B_202B_200D_206F_206A_200E_206C_200F_200C_206C_206F_202A_206C_202C_202D_200B_202D_202E_200B_206D_206A_200F_200B_200D_200B_202E_200E_206D_202B_206C_202B_206D_200F_200C_200F_200E_202E.Skills.GetEnumerator())
			{
				Trigger current5 = default(Trigger);
				while (enumerator3.MoveNext())
				{
					SkillInstance current4;
					while (true)
					{
						current4 = enumerator3.Current;
						int num20 = 1236429953;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num20 ^ 0x7027846A)) % 3)
							{
							case 0u:
								num20 = 2031955415;
								continue;
							case 2u:
								break;
							default:
								goto end_IL_055a;
							}
							break;
						}
						continue;
						end_IL_055a:
						break;
					}
					using List<Trigger>.Enumerator enumerator = current4.Skill.Triggers.GetEnumerator();
					while (true)
					{
						IL_0675:
						int num21;
						int num22;
						if (enumerator.MoveNext())
						{
							num21 = 1908613134;
							num22 = num21;
						}
						else
						{
							num21 = 1549914729;
							num22 = num21;
						}
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num21 ^ 0x7027846A)) % 12)
							{
							case 9u:
								num21 = 1908613134;
								continue;
							default:
								goto end_IL_0586;
							case 8u:
							{
								int num25;
								if (!_206D_202C_200B_200C_206B_206E_202D_206C_200F_202B_206E_206D_200E_202C_200C_206B_200D_206B_206B_200C_206D_206C_200D_206A_202E_200D_200E_202D_206E_200C_206A_206E_200C_202E_200C_202A_206F_200E_200F_206D_202E(current5.Name, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2470956376u)))
								{
									num21 = 629398244;
									num25 = num21;
								}
								else
								{
									num21 = 523599084;
									num25 = num21;
								}
								continue;
							}
							case 0u:
							{
								int num28;
								int num29;
								if (current4.IsUsed)
								{
									num28 = 2102753487;
									num29 = num28;
								}
								else
								{
									num28 = 1842701934;
									num29 = num28;
								}
								num21 = num28 ^ ((int)num2 * -208203265);
								continue;
							}
							case 6u:
							{
								int num26;
								int num27;
								if (current4.level >= current5.Level)
								{
									num26 = -1974674275;
									num27 = num26;
								}
								else
								{
									num26 = -930884032;
									num27 = num26;
								}
								num21 = num26 ^ (int)(num2 * 1832442838);
								continue;
							}
							case 10u:
							{
								int num30;
								int num31;
								if (current4.level < current5.Level)
								{
									num30 = -1603514664;
									num31 = num30;
								}
								else
								{
									num30 = -326018497;
									num31 = num30;
								}
								num21 = num30 ^ ((int)num2 * -854320502);
								continue;
							}
							case 2u:
								break;
							case 5u:
								argvs = current5.Argvs;
								num21 = ((int)num2 * -1975551332) ^ -1592435979;
								continue;
							case 1u:
							{
								int num23;
								int num24;
								if (_206D_202C_200B_200C_206B_206E_202D_206C_200F_202B_206E_206D_200E_202C_200C_206B_200D_206B_206B_200C_206D_206C_200D_206A_202E_200D_200E_202D_206E_200C_206A_206E_200C_202E_200C_202A_206F_200E_200F_206D_202E(current5.Name, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1747539065u)))
								{
									num23 = -1096217499;
									num24 = num23;
								}
								else
								{
									num23 = -459056229;
									num24 = num23;
								}
								num21 = num23 ^ (int)(num2 * 257941201);
								continue;
							}
							case 3u:
								argvs = current5.Argvs;
								goto IL_087f;
							case 4u:
								current5 = enumerator.Current;
								num21 = 2125267486;
								continue;
							case 11u:
								goto end_IL_0586;
							case 7u:
								goto IL_087f;
							}
							goto IL_0675;
							continue;
							end_IL_0586:
							break;
						}
						break;
					}
				}
			}
			Trigger current6 = default(Trigger);
			foreach (ItemInstance item in _200D_202A_206F_206E_202B_202B_200D_206F_206A_200E_206C_200F_200C_206C_206F_202A_206C_202C_202D_200B_202D_202E_200B_206D_206A_200F_200B_200D_200B_202E_200E_206D_202B_206C_202B_206D_200F_200C_200F_200E_202E.Equipment)
			{
				IEnumerator<Trigger> enumerator5 = item.AllTriggers.GetEnumerator();
				try
				{
					while (true)
					{
						IL_07b0:
						int num32;
						int num33;
						if (_206E_206A_206F_206B_200F_200E_200E_200B_206B_202B_202D_200B_202C_202E_202C_200F_200B_200E_200C_200F_206E_202B_206A_206C_200D_206F_206B_206E_206F_206A_200B_200B_202E_200E_200F_200C_200E_202C_200C_200D_202E((IEnumerator)enumerator5))
						{
							num32 = 1179279971;
							num33 = num32;
						}
						else
						{
							num32 = 1778619092;
							num33 = num32;
						}
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num32 ^ 0x7027846A)) % 5)
							{
							case 0u:
								num32 = 1179279971;
								continue;
							default:
								goto end_IL_078a;
							case 3u:
								break;
							case 1u:
								argvs = current6.Argvs;
								goto IL_087f;
							case 2u:
							{
								current6 = enumerator5.Current;
								int num34;
								if (!_206D_202C_200B_200C_206B_206E_202D_206C_200F_202B_206E_206D_200E_202C_200C_206B_200D_206B_206B_200C_206D_206C_200D_206A_202E_200D_200E_202D_206E_200C_206A_206E_200C_202E_200C_202A_206F_200E_200F_206D_202E(current6.Name, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1924810249u)))
								{
									num32 = 2011303272;
									num34 = num32;
								}
								else
								{
									num32 = 766167662;
									num34 = num32;
								}
								continue;
							}
							case 4u:
								goto end_IL_078a;
							}
							goto IL_07b0;
							continue;
							end_IL_078a:
							break;
						}
						break;
					}
				}
				finally
				{
					if (enumerator5 != null)
					{
						while (true)
						{
							IL_0822:
							int num35 = 714842410;
							while (true)
							{
								uint num2;
								switch ((num2 = (uint)(num35 ^ 0x7027846A)) % 3)
								{
								case 2u:
									break;
								default:
									goto end_IL_0827;
								case 1u:
									goto IL_0845;
								case 0u:
									goto end_IL_0827;
								}
								goto IL_0822;
								IL_0845:
								_206D_206B_200F_202B_202B_200E_206C_202B_206F_206C_206F_200B_200F_202D_206D_202D_202D_202A_202E_200B_202E_200D_202D_202B_206E_200D_202D_200F_200D_206C_202A_202E_202B_202C_200F_202A_206B_206F_200D_206C_202E((IDisposable)enumerator5);
								num35 = ((int)num2 * -1483373140) ^ 0x7EF5AB6F;
								continue;
								end_IL_0827:
								break;
							}
							break;
						}
					}
				}
			}
			return new List<string>();
			IL_087f:
			return argvs;
		}
	}

	static string _200B_206B_202A_202C_200E_206A_200C_206A_206E_206F_202A_206F_202B_206A_206C_202B_200C_206A_206C_202E_202B_206D_206A_206E_206E_202B_206C_202C_202A_202D_206C_206F_202C_206A_206E_202D_200F_202D_200C_202E_202E(string P_0, string P_1)
	{
		return P_0 + P_1;
	}

	static bool _206F_206D_202A_200F_200D_206E_202A_200E_200C_206E_200B_200C_206F_200F_202B_202B_202E_206E_200E_200E_206A_200B_206A_206C_202C_206A_202D_200C_206F_206B_206C_202D_200D_202D_202D_206E_206E_200E_206B_200E_202E(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}

	static string[] _200E_206C_202B_202E_202C_206C_206A_202A_200E_200F_202A_206C_206A_206F_206A_206D_202E_200E_206E_206C_200B_206C_202D_200C_206F_206C_200B_202D_202B_200F_202A_202D_202A_206A_200F_206D_202E_202A_206F_202A_202E(string P_0, char[] P_1)
	{
		return P_0.Split(P_1);
	}

	static bool _206D_202C_200B_200C_206B_206E_202D_206C_200F_202B_206E_206D_200E_202C_200C_206B_200D_206B_206B_200C_206D_206C_200D_206A_202E_200D_200E_202D_206E_200C_206A_206E_200C_202E_200C_202A_206F_200E_200F_206D_202E(string P_0, string P_1)
	{
		return P_0 == P_1;
	}

	static bool _206E_206A_206F_206B_200F_200E_200E_200B_206B_202B_202D_200B_202C_202E_202C_200F_200B_200E_200C_200F_206E_202B_206A_206C_200D_206F_206B_206E_206F_206A_200B_200B_202E_200E_200F_200C_200E_202C_200C_200D_202E(IEnumerator P_0)
	{
		return P_0.MoveNext();
	}

	static void _206D_206B_200F_202B_202B_200E_206C_202B_206F_206C_206F_200B_200F_202D_206D_202D_202D_202A_202E_200B_202E_200D_202D_202B_206E_200D_202D_200F_200D_206C_202A_202E_202B_202C_200F_202A_206B_206F_200D_206C_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}
}
