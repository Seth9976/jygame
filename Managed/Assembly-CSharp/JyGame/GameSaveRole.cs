using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace JyGame;

[XmlType]
public class GameSaveRole
{
	[XmlAttribute]
	public string key;

	[XmlAttribute]
	public string animation;

	[XmlAttribute]
	public string name;

	[XmlAttribute]
	public string head;

	[XmlAttribute]
	public int maxhp;

	[XmlAttribute]
	public int maxmp;

	[XmlAttribute]
	public int wuxing;

	[XmlAttribute]
	public int shenfa;

	[XmlAttribute]
	public int bili;

	[XmlAttribute]
	public int gengu;

	[XmlAttribute]
	public int fuyuan;

	[XmlAttribute]
	public int dingli;

	[XmlAttribute]
	public int quanzhang;

	[XmlAttribute]
	public int jianfa;

	[XmlAttribute]
	public int daofa;

	[XmlAttribute]
	public int qimen;

	[XmlAttribute]
	public string currentSkillName;

	[XmlAttribute]
	public int exp;

	[XmlAttribute]
	public int female;

	[XmlAttribute]
	public int leftpoint;

	[XmlAttribute]
	public string grow_template;

	[XmlAttribute]
	public int level;

	[XmlAttribute]
	public string talent;

	[XmlElement("sk")]
	public GameSaveRoleSkill[] skills;

	[XmlElement("i")]
	public GameSaveRoleSkill[] internalSkills;

	[XmlElement("sp")]
	public GameSaveRoleSkill[] specialSkills;

	[XmlElement("e")]
	public GameSaveItem[] equippments;

	[XmlAttribute]
	public int jiushen_count;

	[XmlAttribute]
	public int isharem;

	[XmlAttribute]
	public int character;

	[XmlAttribute]
	public int character2;

	[XmlElement("ti")]
	public GameSaveRoleSkill[] titles;

	[XmlAttribute]
	public string anqi;

	public Role GenerateRole()
	{
		Role role = new Role();
		int num3 = default(int);
		GameSaveItem[] array = default(GameSaveItem[]);
		int num8 = default(int);
		ItemInstance itemInstance = default(ItemInstance);
		while (true)
		{
			int num = -1322993501;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1016701108)) % 53)
				{
				case 33u:
					break;
				case 38u:
				{
					int num13;
					if (role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2186305609u)] <= num3)
					{
						num = -1922944785;
						num13 = num;
					}
					else
					{
						num = -1941246312;
						num13 = num;
					}
					continue;
				}
				case 25u:
				{
					int num14;
					if (role.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(655417903u)] <= num3)
					{
						num = -1198404825;
						num14 = num;
					}
					else
					{
						num = -2133416743;
						num14 = num;
					}
					continue;
				}
				case 35u:
					role.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3905690180u)] = maxhp;
					num = (int)((num2 * 1684306315) ^ 0x56E34C92);
					continue;
				case 27u:
					role.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(424952987u)] = quanzhang;
					num = ((int)num2 * -725303879) ^ -1703120749;
					continue;
				case 22u:
					role.TalentValue = talent;
					role.Skills = GetSkills();
					role.InternalSkills = GetInternalSkills();
					num = (int)((num2 * 872652816) ^ 0xCCDDB45);
					continue;
				case 37u:
					role.Name = name;
					num = ((int)num2 * -1701180060) ^ -1548967697;
					continue;
				case 43u:
					role.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(430829805u)] = num3;
					num = ((int)num2 * -28298190) ^ 0x59595B5A;
					continue;
				case 20u:
				{
					int num10;
					if (role.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2223184606u)] <= num3)
					{
						num = -1388091417;
						num10 = num;
					}
					else
					{
						num = -683360129;
						num10 = num;
					}
					continue;
				}
				case 51u:
					role.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1412133437u)] = fuyuan;
					role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3406067330u)] = dingli;
					num = ((int)num2 * -2016411446) ^ 0x6582FBA5;
					continue;
				case 26u:
				{
					int num22;
					if (role.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1412133437u)] > num3)
					{
						num = -1725178672;
						num22 = num;
					}
					else
					{
						num = -47905557;
						num22 = num;
					}
					continue;
				}
				case 4u:
				{
					int num19;
					int num20;
					if (role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1368077529u)] > num3)
					{
						num19 = 1878103302;
						num20 = num19;
					}
					else
					{
						num19 = 62813144;
						num20 = num19;
					}
					num = num19 ^ ((int)num2 * -807118977);
					continue;
				}
				case 52u:
					role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(136168559u)] = wuxing;
					num = ((int)num2 * -1191590104) ^ 0x2E8C56B2;
					continue;
				case 8u:
					array = equippments;
					num8 = 0;
					num = ((int)num2 * -1865978507) ^ 0x429869F8;
					continue;
				case 3u:
					role.jiushen_count = jiushen_count;
					role.isharem = isharem;
					num = ((int)num2 * -90186349) ^ 0x51F82D0D;
					continue;
				case 41u:
					role.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(701808387u)] = num3;
					num = ((int)num2 * -681777763) ^ -881745720;
					continue;
				case 5u:
					num8++;
					num = -1448520043;
					continue;
				case 49u:
				{
					int num9;
					if (num8 >= array.Length)
					{
						num = -927770230;
						num9 = num;
					}
					else
					{
						num = -1371396429;
						num9 = num;
					}
					continue;
				}
				case 31u:
					role.exp2 = 0.0 - (double)exp;
					role.SetLevel(level);
					num = (int)((num2 * 211900247) ^ 0x506AF6E2);
					continue;
				case 16u:
				{
					int num5;
					if (role.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1923523063u)] > num3)
					{
						num = -1568732262;
						num5 = num;
					}
					else
					{
						num = -1490692618;
						num5 = num;
					}
					continue;
				}
				case 1u:
					itemInstance = array[num8].Generate();
					num = -222529852;
					continue;
				case 23u:
					num3 = _200F_200D_202C_200D_202E_206C_200D_200E_202C_200E_202A_202A_206E_202B_202D_206E_206F_202A_206E_200D_200E_200F_206C_200E_202B_206A_200B_202B_206E_206B_202A_206D_206A_206B_200B_200D_200B_202A_200B_202C_202E(3000, CommonSettings.MAX_ATTRIBUTE);
					num = -61118357;
					continue;
				case 18u:
					role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2249625138u)] = qimen;
					role.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2145573044u)] = female;
					role.currentSkillName = currentSkillName;
					role.leftpoint = leftpoint;
					num = (int)((num2 * 1617862408) ^ 0x670205CD);
					continue;
				case 7u:
					num = (int)(num2 * 158180314) ^ -244525085;
					continue;
				case 2u:
				{
					int num23;
					if (role.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(430829805u)] > num3)
					{
						num = -986909470;
						num23 = num;
					}
					else
					{
						num = -158497626;
						num23 = num;
					}
					continue;
				}
				case 28u:
					role.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1790491204u)] = num3;
					num = (int)((num2 * 1530767129) ^ 0x51709CA8);
					continue;
				case 29u:
				{
					int num21;
					if (role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2575692001u)] > num3)
					{
						num = -256258927;
						num21 = num;
					}
					else
					{
						num = -444397763;
						num21 = num;
					}
					continue;
				}
				case 45u:
					role.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1940200750u)] = daofa;
					num = (int)(num2 * 1705379879) ^ -1889717459;
					continue;
				case 42u:
				{
					int num17;
					int num18;
					if (itemInstance != null)
					{
						num17 = 2088652723;
						num18 = num17;
					}
					else
					{
						num17 = 1527962826;
						num18 = num17;
					}
					num = num17 ^ (int)(num2 * 439862042);
					continue;
				}
				case 46u:
					role.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2741516750u)] = shenfa;
					role.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(655417903u)] = bili;
					role.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1790491204u)] = gengu;
					num = ((int)num2 * -315323854) ^ -540190875;
					continue;
				case 6u:
					role.Key = key;
					num = ((int)num2 * -1939186117) ^ 0x56EEE811;
					continue;
				case 30u:
					role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2186305609u)] = num3;
					num = ((int)num2 * -1984652369) ^ 0x212ADB03;
					continue;
				case 44u:
					role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1029863417u)] = num3;
					num = (int)(num2 * 1023799723) ^ -524468746;
					continue;
				case 39u:
					role.Head = head;
					role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(592457607u)] = maxhp;
					num = ((int)num2 * -1915187287) ^ -73695226;
					continue;
				case 21u:
					role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(248942232u)] = jianfa;
					num = (int)(num2 * 1408525482) ^ -751264613;
					continue;
				case 24u:
					role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1550623476u)] = num3;
					num = (int)((num2 * 644644479) ^ 0x5C2E168F);
					continue;
				case 19u:
					role.Titles = GetTitles();
					num = ((int)num2 * -1551562196) ^ -1241223399;
					continue;
				case 15u:
					role.Animation = animation;
					num = (int)(num2 * 1770072989) ^ -305539719;
					continue;
				case 50u:
				{
					int num16;
					if (CommonSettings.MOD_KEY() >= 0)
					{
						num = -1783603069;
						num16 = num;
					}
					else
					{
						num = -326314293;
						num16 = num;
					}
					continue;
				}
				case 17u:
					role.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(11946387u)] = maxmp;
					role.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1678197155u)] = maxmp;
					num = (int)((num2 * 1292973728) ^ 0x5EBCB96A);
					continue;
				case 32u:
					role.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(655417903u)] = num3;
					num = (int)((num2 * 773164608) ^ 0x39954067);
					continue;
				case 11u:
					role.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1944260873u)] = num3;
					num = ((int)num2 * -1167988079) ^ -800823376;
					continue;
				case 10u:
					role.leftpoint2 = leftpoint;
					role.GrowTemplateValue = grow_template;
					role.exp = exp;
					num = (int)(num2 * 1664632181) ^ -1695741100;
					continue;
				case 36u:
					role.Equipment.Add(itemInstance);
					num = ((int)num2 * -1026672048) ^ 0x45D877AA;
					continue;
				case 0u:
				{
					int num15;
					if (role.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2053407229u)] <= num3)
					{
						num = -1084558897;
						num15 = num;
					}
					else
					{
						num = -844757181;
						num15 = num;
					}
					continue;
				}
				case 40u:
					role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1368077529u)] = num3;
					num = ((int)num2 * -159810351) ^ -947346430;
					continue;
				case 47u:
					role.HiddenWeapon = anqi;
					num = (int)((num2 * 944549758) ^ 0x6FC60A1);
					continue;
				case 14u:
				{
					role.character2 = character2;
					int num11;
					int num12;
					if (anqi != null)
					{
						num11 = -1200846435;
						num12 = num11;
					}
					else
					{
						num11 = -475731439;
						num12 = num11;
					}
					num = num11 ^ (int)(num2 * 654304214);
					continue;
				}
				case 34u:
					role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2249625138u)] = num3;
					num = (int)(num2 * 206554939) ^ -118613412;
					continue;
				case 48u:
				{
					role.SpecialSkills = GetSpecialSkills();
					int num6;
					int num7;
					if (equippments == null)
					{
						num6 = 799701263;
						num7 = num6;
					}
					else
					{
						num6 = 195574286;
						num7 = num6;
					}
					num = num6 ^ (int)(num2 * 357538317);
					continue;
				}
				case 13u:
				{
					int num4;
					if (role.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1977936243u)] <= num3)
					{
						num = -1436038161;
						num4 = num;
					}
					else
					{
						num = -2031814491;
						num4 = num;
					}
					continue;
				}
				case 9u:
					role.character = character;
					num = (int)(num2 * 1285038587) ^ -554853011;
					continue;
				default:
					role.InitBind();
					return role;
				}
				break;
			}
		}
	}

	public static GameSaveRole[] Create(List<Role> roles)
	{
		GameSaveRole[] array = new GameSaveRole[roles.Count];
		int num = 0;
		while (true)
		{
			int num2;
			int num3;
			if (num < roles.Count)
			{
				num2 = 2130516438;
				num3 = num2;
			}
			else
			{
				num2 = 783840354;
				num3 = num2;
			}
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)(num2 ^ 0x286B7FEE)) % 5)
				{
				case 2u:
					num2 = 2130516438;
					continue;
				case 4u:
					array[num] = Create(roles[num]);
					num2 = 1758947883;
					continue;
				case 0u:
					num++;
					num2 = (int)(num4 * 1966964366) ^ -694323304;
					continue;
				case 1u:
					break;
				default:
					return array;
				}
				break;
			}
		}
	}

	public static GameSaveRole Create(Role r)
	{
		GameSaveRole gameSaveRole = new GameSaveRole();
		gameSaveRole.key = r.Key;
		int num3 = default(int);
		int num5 = default(int);
		int num12 = default(int);
		int num11 = default(int);
		int num20 = default(int);
		ItemInstance itemInstance = default(ItemInstance);
		int num18 = default(int);
		GameSaveItem gameSaveItem = default(GameSaveItem);
		while (true)
		{
			int num = 2092526250;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1A03440A)) % 82)
				{
				case 39u:
					break;
				case 13u:
				{
					int num14;
					if (gameSaveRole.shenfa <= num3)
					{
						num = 2092648428;
						num14 = num;
					}
					else
					{
						num = 1659050891;
						num14 = num;
					}
					continue;
				}
				case 6u:
				{
					int num10;
					if (gameSaveRole.qimen <= num3)
					{
						num = 7991413;
						num10 = num;
					}
					else
					{
						num = 592776247;
						num10 = num;
					}
					continue;
				}
				case 47u:
					num5 = 0;
					num = ((int)num2 * -655528935) ^ 0x5FF7DE6F;
					continue;
				case 60u:
					gameSaveRole.name = r.Name;
					num = (int)((num2 * 827473464) ^ 0x49FAD7C);
					continue;
				case 31u:
					gameSaveRole.daofa = r.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2077292732u)];
					gameSaveRole.qimen = r.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2249625138u)];
					gameSaveRole.female = r.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2145573044u)];
					num = (int)((num2 * 1790369721) ^ 0x6F7F39A8);
					continue;
				case 78u:
					gameSaveRole.shenfa = r.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3058596364u)];
					gameSaveRole.bili = r.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(710450445u)];
					gameSaveRole.gengu = r.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3051962998u)];
					gameSaveRole.fuyuan = r.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1412133437u)];
					gameSaveRole.dingli = r.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(912726802u)];
					num = ((int)num2 * -419354700) ^ 0x4079129F;
					continue;
				case 52u:
					gameSaveRole.gengu = num3;
					num = ((int)num2 * -1627536490) ^ -653979770;
					continue;
				case 54u:
					num12 = 0;
					num = (int)((num2 * 2047216721) ^ 0x1876A6ED);
					continue;
				case 4u:
					gameSaveRole.titles[num11] = GameSaveRoleSkill.Create(r.Titles[num11]);
					num = 671936071;
					continue;
				case 18u:
					gameSaveRole.maxmp = r.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(187771104u)];
					num = (int)((num2 * 741392930) ^ 0xBA4B04C);
					continue;
				case 75u:
					num = (int)((num2 * 824863039) ^ 0x36A74563);
					continue;
				case 1u:
				{
					int num15;
					if (gameSaveRole.daofa <= num3)
					{
						num = 720273186;
						num15 = num;
					}
					else
					{
						num = 588893803;
						num15 = num;
					}
					continue;
				}
				case 81u:
				{
					int num38;
					if (num11 >= r.Titles.Count)
					{
						num = 1918743720;
						num38 = num;
					}
					else
					{
						num = 1607919116;
						num38 = num;
					}
					continue;
				}
				case 7u:
				{
					int num34;
					int num35;
					if (gameSaveRole.wuxing <= num3)
					{
						num34 = -959712332;
						num35 = num34;
					}
					else
					{
						num34 = -1406370656;
						num35 = num34;
					}
					num = num34 ^ (int)(num2 * 604872263);
					continue;
				}
				case 28u:
					num12++;
					num = 691940770;
					continue;
				case 22u:
					gameSaveRole.character2 = r.character2;
					num = (int)((num2 * 1667267199) ^ 0x6E7CC51D);
					continue;
				case 37u:
					gameSaveRole.bili = num3;
					num = (int)(num2 * 1181942708) ^ -2087638039;
					continue;
				case 45u:
					gameSaveRole.grow_template = r.GrowTemplateValue;
					num = 194259953;
					continue;
				case 35u:
					gameSaveRole.wuxing = num3;
					num = (int)((num2 * 1083652895) ^ 0x2D611140);
					continue;
				case 65u:
					gameSaveRole.quanzhang = r.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2722506620u)];
					num = ((int)num2 * -1592921890) ^ -832060336;
					continue;
				case 32u:
					gameSaveRole.jianfa = r.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(430829805u)];
					num = ((int)num2 * -91673822) ^ 0x468ACECF;
					continue;
				case 21u:
					num = ((int)num2 * -1199880668) ^ -105689274;
					continue;
				case 64u:
				{
					int num27;
					if (r.InternalSkills.Count > 0)
					{
						num = 1983121188;
						num27 = num;
					}
					else
					{
						num = 1629874397;
						num27 = num;
					}
					continue;
				}
				case 62u:
					gameSaveRole.specialSkills[num20] = GameSaveRoleSkill.Create(r.SpecialSkills[num20]);
					num = 1277965575;
					continue;
				case 80u:
					num = ((int)num2 * -1776793226) ^ -809471310;
					continue;
				case 36u:
				{
					int num23;
					if (gameSaveRole.quanzhang > num3)
					{
						num = 1857512296;
						num23 = num;
					}
					else
					{
						num = 2034379283;
						num23 = num;
					}
					continue;
				}
				case 48u:
					num20 = 0;
					num = (int)((num2 * 1441259362) ^ 0x224DBB36);
					continue;
				case 0u:
					gameSaveRole.internalSkills[num12] = GameSaveRoleSkill.Create(r.InternalSkills[num12]);
					num = (int)((num2 * 1187474543) ^ 0x3954ED0);
					continue;
				case 20u:
					num3 = _200F_200D_202C_200D_202E_206C_200D_200E_202C_200E_202A_202A_206E_202B_202D_206E_206F_202A_206E_200D_200E_200F_206C_200E_202B_206A_200B_202B_206E_206B_202A_206D_206A_206B_200B_200D_200B_202A_200B_202C_202E(3000, CommonSettings.MAX_ATTRIBUTE);
					num = 1849114611;
					continue;
				case 3u:
					num20++;
					num = ((int)num2 * -2121828242) ^ 0x3286AB99;
					continue;
				case 61u:
					gameSaveRole.shenfa = num3;
					num = ((int)num2 * -1429710692) ^ 0x6CEDCD70;
					continue;
				case 41u:
					itemInstance = r.Equipment[num18];
					num = 596472129;
					continue;
				case 2u:
					gameSaveRole.head = r.Head;
					gameSaveRole.maxhp = r.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1796919217u)];
					num = (int)((num2 * 531678295) ^ 0x2408B548);
					continue;
				case 73u:
					gameSaveRole.anqi = r.HiddenWeapon;
					num = ((int)num2 * -1117733137) ^ -1468846899;
					continue;
				case 63u:
					gameSaveRole.fuyuan = num3;
					num = (int)(num2 * 264440645) ^ -1621223204;
					continue;
				case 50u:
				{
					int num8;
					int num9;
					if (r.Skills.Count <= 0)
					{
						num8 = -874679246;
						num9 = num8;
					}
					else
					{
						num8 = -1546401487;
						num9 = num8;
					}
					num = num8 ^ ((int)num2 * -163093575);
					continue;
				}
				case 58u:
					gameSaveRole.character = r.character;
					num = (int)((num2 * 885362005) ^ 0x5188D9C4);
					continue;
				case 8u:
					gameSaveRole.quanzhang = num3;
					num = ((int)num2 * -251353447) ^ 0x9FF3F81;
					continue;
				case 33u:
				{
					int num39;
					if (gameSaveRole.gengu > num3)
					{
						num = 1749805932;
						num39 = num;
					}
					else
					{
						num = 1190819906;
						num39 = num;
					}
					continue;
				}
				case 74u:
				{
					int num37;
					if (num5 < r.Skills.Count)
					{
						num = 2056925674;
						num37 = num;
					}
					else
					{
						num = 1548934058;
						num37 = num;
					}
					continue;
				}
				case 10u:
					num18++;
					num = ((int)num2 * -69461051) ^ -130798712;
					continue;
				case 17u:
					gameSaveRole.skills[num5] = GameSaveRoleSkill.Create(r.Skills[num5]);
					num = ((int)num2 * -1014153029) ^ -540032946;
					continue;
				case 51u:
					gameSaveRole.exp = r.exp;
					num = (int)(num2 * 741771216) ^ -790754501;
					continue;
				case 79u:
					gameSaveRole.skills = new GameSaveRoleSkill[r.Skills.Count];
					num = ((int)num2 * -2038395656) ^ -257159333;
					continue;
				case 70u:
					num = ((int)num2 * -699253829) ^ 0x21302F81;
					continue;
				case 38u:
				{
					int num36;
					if (gameSaveRole.bili <= num3)
					{
						num = 1988871901;
						num36 = num;
					}
					else
					{
						num = 1589392363;
						num36 = num;
					}
					continue;
				}
				case 14u:
					gameSaveRole.jiushen_count = r.jiushen_count;
					num = 716268011;
					continue;
				case 42u:
				{
					int num32;
					int num33;
					if (r.Titles == null)
					{
						num32 = -1326188574;
						num33 = num32;
					}
					else
					{
						num32 = -150705133;
						num33 = num32;
					}
					num = num32 ^ (int)(num2 * 212719733);
					continue;
				}
				case 19u:
				{
					int num31;
					if (num20 < r.SpecialSkills.Count)
					{
						num = 1604681976;
						num31 = num;
					}
					else
					{
						num = 738998682;
						num31 = num;
					}
					continue;
				}
				case 27u:
				{
					int num29;
					int num30;
					if (r.Titles.Count <= 0)
					{
						num29 = -1701637989;
						num30 = num29;
					}
					else
					{
						num29 = -1665669201;
						num30 = num29;
					}
					num = num29 ^ ((int)num2 * -739924063);
					continue;
				}
				case 49u:
					num5++;
					num = 33810378;
					continue;
				case 26u:
				{
					int num28;
					if (r.Skills[num5].level == -(int)r.Skills[num5].level2)
					{
						num = 563150571;
						num28 = num;
					}
					else
					{
						num = 457245205;
						num28 = num;
					}
					continue;
				}
				case 30u:
				{
					int num26;
					if (CommonSettings.MOD_KEY() >= 0)
					{
						num = 22657256;
						num26 = num;
					}
					else
					{
						num = 1101931020;
						num26 = num;
					}
					continue;
				}
				case 71u:
					gameSaveRole.specialSkills = new GameSaveRoleSkill[r.SpecialSkills.Count];
					num = ((int)num2 * -1872495614) ^ -1921634856;
					continue;
				case 66u:
				{
					int num25;
					if (gameSaveRole.fuyuan <= num3)
					{
						num = 886318767;
						num25 = num;
					}
					else
					{
						num = 1589519965;
						num25 = num;
					}
					continue;
				}
				case 77u:
				{
					int num24;
					if (r.SpecialSkills.Count <= 0)
					{
						num = 738998682;
						num24 = num;
					}
					else
					{
						num = 121621307;
						num24 = num;
					}
					continue;
				}
				case 43u:
					gameSaveRole.qimen = num3;
					num = ((int)num2 * -1819989155) ^ -514683556;
					continue;
				case 40u:
					gameSaveRole.equippments = new GameSaveItem[r.Equipment.Count];
					num18 = 0;
					num = (int)((num2 * 809992021) ^ 0x11459DEB);
					continue;
				case 53u:
					gameSaveRole.leftpoint = r.leftpoint;
					num = (int)((num2 * 282767840) ^ 0x307A496B);
					continue;
				case 5u:
					gameSaveRole.level = r.level;
					gameSaveRole.talent = r.TalentValue;
					num = ((int)num2 * -241316072) ^ 0x7F9A98DA;
					continue;
				case 24u:
					gameSaveRole.animation = r.Animation;
					num = (int)(num2 * 67334456) ^ -3844132;
					continue;
				case 59u:
					num11++;
					num = (int)((num2 * 1932545913) ^ 0x502A350A);
					continue;
				case 44u:
				{
					int num22;
					if (num18 >= r.Equipment.Count)
					{
						num = 1491484984;
						num22 = num;
					}
					else
					{
						num = 1759791609;
						num22 = num;
					}
					continue;
				}
				case 9u:
					gameSaveRole.equippments[num18] = gameSaveItem;
					num = ((int)num2 * -307161985) ^ 0x38EBBCF5;
					continue;
				case 72u:
					gameSaveRole.internalSkills = new GameSaveRoleSkill[r.InternalSkills.Count];
					num = (int)(num2 * 1561283023) ^ -1712508338;
					continue;
				case 67u:
				{
					int num21;
					if (r.leftpoint != (int)r.leftpoint2)
					{
						num = 1589576651;
						num21 = num;
					}
					else
					{
						num = 430650321;
						num21 = num;
					}
					continue;
				}
				case 15u:
					gameSaveRole.dingli = num3;
					num = ((int)num2 * -1212531822) ^ 0x5EB2CD50;
					continue;
				case 34u:
					gameSaveRole.jianfa = num3;
					num = (int)(num2 * 120321103) ^ -7569771;
					continue;
				case 16u:
				{
					int num19;
					if (num12 >= r.InternalSkills.Count)
					{
						num = 1629874397;
						num19 = num;
					}
					else
					{
						num = 1736678532;
						num19 = num;
					}
					continue;
				}
				case 11u:
				{
					int num17;
					if (gameSaveRole.dingli <= num3)
					{
						num = 2050773350;
						num17 = num;
					}
					else
					{
						num = 1900079817;
						num17 = num;
					}
					continue;
				}
				case 56u:
					gameSaveRole.wuxing = r.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2663905188u)];
					num = (int)(num2 * 1166013786) ^ -699514698;
					continue;
				case 57u:
					gameSaveRole.isharem = r.isharem;
					num = (int)(num2 * 2114064066) ^ -490760634;
					continue;
				case 12u:
					num = ((int)num2 * -686786770) ^ -455661433;
					continue;
				case 69u:
					gameSaveRole.daofa = num3;
					num = ((int)num2 * -673189529) ^ -576749275;
					continue;
				case 55u:
					gameSaveItem = new GameSaveItem
					{
						name = itemInstance.Name,
						triggers = itemInstance.AdditionTriggers.ToArray(),
						count = 1
					};
					num = (int)((num2 * 239879860) ^ 0x51302757);
					continue;
				case 68u:
				{
					int num16;
					if (r.Equipment.Count <= 0)
					{
						num = 1491484984;
						num16 = num;
					}
					else
					{
						num = 1301785998;
						num16 = num;
					}
					continue;
				}
				case 46u:
				{
					int num13;
					if (r.InternalSkills[num12].level == -(int)r.InternalSkills[num12].level2)
					{
						num = 1814169792;
						num13 = num;
					}
					else
					{
						num = 844025158;
						num13 = num;
					}
					continue;
				}
				case 76u:
					gameSaveRole.titles = new GameSaveRoleSkill[r.Titles.Count];
					num11 = 0;
					num = ((int)num2 * -188050817) ^ 0x3FC928A;
					continue;
				case 23u:
				{
					gameSaveRole.currentSkillName = r.currentSkillName;
					int num6;
					int num7;
					if (r.exp != -(int)r.exp2)
					{
						num6 = 1596713962;
						num7 = num6;
					}
					else
					{
						num6 = 1254017300;
						num7 = num6;
					}
					num = num6 ^ ((int)num2 * -1851531769);
					continue;
				}
				case 25u:
				{
					int num4;
					if (gameSaveRole.jianfa <= num3)
					{
						num = 1490256175;
						num4 = num;
					}
					else
					{
						num = 1439481900;
						num4 = num;
					}
					continue;
				}
				default:
					return gameSaveRole;
				}
				break;
			}
		}
	}

	public List<SkillInstance> GetSkills()
	{
		List<SkillInstance> list = new List<SkillInstance>();
		int num5 = default(int);
		GameSaveRoleSkill[] array = default(GameSaveRoleSkill[]);
		GameSaveRoleSkill gameSaveRoleSkill = default(GameSaveRoleSkill);
		Skill skill = default(Skill);
		while (true)
		{
			int num = 1092195407;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x148F67B8)) % 12)
				{
				case 8u:
					break;
				case 10u:
					num5 = 0;
					num = ((int)num2 * -1501210152) ^ 0x75DDF81F;
					continue;
				case 6u:
					array = skills;
					num = 1961261278;
					continue;
				case 7u:
					num = (int)((num2 * 793453644) ^ 0x63C7D9DC);
					continue;
				case 1u:
					num5++;
					num = 495284104;
					continue;
				case 9u:
					return list;
				case 0u:
				{
					int num6;
					if (num5 < array.Length)
					{
						num = 870023573;
						num6 = num;
					}
					else
					{
						num = 368377843;
						num6 = num;
					}
					continue;
				}
				case 5u:
				{
					gameSaveRoleSkill = array[num5];
					skill = ResourceManager.Get<Skill>(gameSaveRoleSkill.name);
					int num9;
					if (skill == null)
					{
						num = 636265825;
						num9 = num;
					}
					else
					{
						num = 1654856390;
						num9 = num;
					}
					continue;
				}
				case 2u:
				{
					int num7;
					int num8;
					if (skill.IsNpc)
					{
						num7 = -1496760449;
						num8 = num7;
					}
					else
					{
						num7 = -385959830;
						num8 = num7;
					}
					num = num7 ^ ((int)num2 * -1364961871);
					continue;
				}
				case 4u:
					list.Add(gameSaveRoleSkill.GenerateSkill());
					num = (int)((num2 * 1373296345) ^ 0x7993148D);
					continue;
				case 11u:
				{
					int num3;
					int num4;
					if (skills == null)
					{
						num3 = -832444260;
						num4 = num3;
					}
					else
					{
						num3 = -48132153;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -147310373);
					continue;
				}
				default:
					return list;
				}
				break;
			}
		}
	}

	public List<InternalSkillInstance> GetInternalSkills()
	{
		List<InternalSkillInstance> list = new List<InternalSkillInstance>();
		if (internalSkills == null)
		{
			goto IL_0011;
		}
		goto IL_00c3;
		IL_0011:
		int num = -1415017871;
		goto IL_0016;
		IL_0016:
		GameSaveRoleSkill gameSaveRoleSkill = default(GameSaveRoleSkill);
		GameSaveRoleSkill[] array = default(GameSaveRoleSkill[]);
		int num3 = default(int);
		InternalSkill internalSkill = default(InternalSkill);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -62227561)) % 10)
			{
			case 2u:
				break;
			case 1u:
				gameSaveRoleSkill = array[num3];
				internalSkill = ResourceManager.Get<InternalSkill>(gameSaveRoleSkill.name);
				num = -954771823;
				continue;
			case 5u:
				goto IL_006c;
			case 8u:
			{
				int num6;
				int num7;
				if (internalSkill != null)
				{
					num6 = 1966710089;
					num7 = num6;
				}
				else
				{
					num6 = 109911242;
					num7 = num6;
				}
				num = num6 ^ ((int)num2 * -1188964516);
				continue;
			}
			case 7u:
				list.Add(gameSaveRoleSkill.GenerateInternalSkill());
				num = ((int)num2 * -722240437) ^ -1449289295;
				continue;
			case 0u:
				goto IL_00c3;
			case 4u:
				return list;
			case 6u:
			{
				int num4;
				int num5;
				if (internalSkill.IsNpc)
				{
					num4 = 1481911056;
					num5 = num4;
				}
				else
				{
					num4 = 337640060;
					num5 = num4;
				}
				num = num4 ^ ((int)num2 * -1561398757);
				continue;
			}
			case 9u:
				num3++;
				num = -1132506282;
				continue;
			default:
				return list;
			}
			break;
			IL_006c:
			int num8;
			if (num3 >= array.Length)
			{
				num = -1903560378;
				num8 = num;
			}
			else
			{
				num = -934211260;
				num8 = num;
			}
		}
		goto IL_0011;
		IL_00c3:
		array = internalSkills;
		num3 = 0;
		num = -1132506282;
		goto IL_0016;
	}

	public List<SpecialSkillInstance> GetSpecialSkills()
	{
		List<SpecialSkillInstance> list = new List<SpecialSkillInstance>();
		int num3 = default(int);
		GameSaveRoleSkill[] array = default(GameSaveRoleSkill[]);
		GameSaveRoleSkill gameSaveRoleSkill = default(GameSaveRoleSkill);
		SpecialSkill specialSkill = default(SpecialSkill);
		while (true)
		{
			int num = 452385240;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x52D067A)) % 12)
				{
				case 4u:
					break;
				case 8u:
				{
					int num8;
					if (num3 >= array.Length)
					{
						num = 1711796263;
						num8 = num;
					}
					else
					{
						num = 1047648827;
						num8 = num;
					}
					continue;
				}
				case 11u:
					list.Add(gameSaveRoleSkill.GenerateSpecialSkill());
					num = (int)(num2 * 727043570) ^ -306513093;
					continue;
				case 2u:
				{
					int num6;
					int num7;
					if (specialSkills == null)
					{
						num6 = -1925519597;
						num7 = num6;
					}
					else
					{
						num6 = -1317250502;
						num7 = num6;
					}
					num = num6 ^ ((int)num2 * -442192045);
					continue;
				}
				case 0u:
					num3 = 0;
					num = (int)((num2 * 480525673) ^ 0x5535F08E);
					continue;
				case 5u:
				{
					int num9;
					int num10;
					if (!specialSkill.IsNpc)
					{
						num9 = -680308292;
						num10 = num9;
					}
					else
					{
						num9 = -2030936504;
						num10 = num9;
					}
					num = num9 ^ ((int)num2 * -671805891);
					continue;
				}
				case 10u:
					array = specialSkills;
					num = 1449957610;
					continue;
				case 6u:
				{
					specialSkill = ResourceManager.Get<SpecialSkill>(gameSaveRoleSkill.name);
					int num4;
					int num5;
					if (specialSkill == null)
					{
						num4 = -1588926067;
						num5 = num4;
					}
					else
					{
						num4 = -395987821;
						num5 = num4;
					}
					num = num4 ^ (int)(num2 * 840403088);
					continue;
				}
				case 7u:
					num3++;
					num = 1237821854;
					continue;
				case 3u:
					return list;
				case 1u:
					gameSaveRoleSkill = array[num3];
					num = 1499594416;
					continue;
				default:
					return list;
				}
				break;
			}
		}
	}

	private List<TitleInstance> GetTitles()
	{
		List<TitleInstance> list = new List<TitleInstance>();
		Title title = default(Title);
		GameSaveRoleSkill gameSaveRoleSkill = default(GameSaveRoleSkill);
		GameSaveRoleSkill[] array = default(GameSaveRoleSkill[]);
		int num3 = default(int);
		while (true)
		{
			int num = -1813062039;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -646066616)) % 14)
				{
				case 4u:
					break;
				case 6u:
				{
					int num5;
					int num6;
					if (title != null)
					{
						num5 = -694076798;
						num6 = num5;
					}
					else
					{
						num5 = -2047756141;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 678097480);
					continue;
				}
				case 10u:
					return list;
				case 5u:
					gameSaveRoleSkill = array[num3];
					num = -1180130151;
					continue;
				case 13u:
					list.Add(gameSaveRoleSkill.GenerateTitle());
					num = ((int)num2 * -2142467658) ^ -613477907;
					continue;
				case 7u:
					title = ResourceManager.Get<Title>(gameSaveRoleSkill.name);
					num = ((int)num2 * -630958797) ^ 0x5A326F53;
					continue;
				case 1u:
					num3++;
					num = -555200157;
					continue;
				case 8u:
				{
					int num9;
					int num10;
					if (title.IsNpc)
					{
						num9 = -1421398265;
						num10 = num9;
					}
					else
					{
						num9 = -549480239;
						num10 = num9;
					}
					num = num9 ^ (int)(num2 * 309038242);
					continue;
				}
				case 12u:
					array = titles;
					num = -1622449270;
					continue;
				case 0u:
					num3 = 0;
					num = ((int)num2 * -1613197025) ^ 0x411EAEA8;
					continue;
				case 3u:
				{
					int num7;
					int num8;
					if (titles != null)
					{
						num7 = 687273741;
						num8 = num7;
					}
					else
					{
						num7 = 879447515;
						num8 = num7;
					}
					num = num7 ^ (int)(num2 * 543897641);
					continue;
				}
				case 2u:
					num = (int)((num2 * 1919442741) ^ 0xB75EFD5);
					continue;
				case 11u:
				{
					int num4;
					if (num3 < array.Length)
					{
						num = -973583329;
						num4 = num;
					}
					else
					{
						num = -433481801;
						num4 = num;
					}
					continue;
				}
				default:
					return list;
				}
				break;
			}
		}
	}

	public Role GenerateRole2()
	{
		Role role = new Role();
		int num3 = default(int);
		GameSaveItem[] array = default(GameSaveItem[]);
		ItemInstance itemInstance = default(ItemInstance);
		int num5 = default(int);
		while (true)
		{
			int num = 2038754557;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3CB71B74)) % 55)
				{
				case 43u:
					break;
				case 23u:
				{
					role.InternalSkills = GetInternalSkills();
					role.SpecialSkills = GetSpecialSkills();
					int num20;
					int num21;
					if (equippments == null)
					{
						num20 = -694523160;
						num21 = num20;
					}
					else
					{
						num20 = -1304276946;
						num21 = num20;
					}
					num = num20 ^ ((int)num2 * -1606725724);
					continue;
				}
				case 8u:
					role.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(424952987u)] = num3;
					num = (int)((num2 * 1102802563) ^ 0x3ACC08C);
					continue;
				case 29u:
					array = equippments;
					num = ((int)num2 * -178825244) ^ 0x4D47DF05;
					continue;
				case 31u:
					role.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(788062007u)] = fuyuan;
					num = ((int)num2 * -1626854449) ^ 0x21346CA8;
					continue;
				case 0u:
					role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(248942232u)] = jianfa;
					num = ((int)num2 * -1306648586) ^ -399161412;
					continue;
				case 28u:
					role.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2077292732u)] = num3;
					num = (int)(num2 * 822515494) ^ -350810953;
					continue;
				case 1u:
				{
					num3 = _200F_200D_202C_200D_202E_206C_200D_200E_202C_200E_202A_202A_206E_202B_202D_206E_206F_202A_206E_200D_200E_200F_206C_200E_202B_206A_200B_202B_206E_206B_202A_206D_206A_206B_200B_200D_200B_202A_200B_202C_202E(3000, CommonSettings.MAX_ATTRIBUTE);
					int num18;
					if (role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1368077529u)] > num3)
					{
						num = 1071392949;
						num18 = num;
					}
					else
					{
						num = 40500009;
						num18 = num;
					}
					continue;
				}
				case 10u:
					role.HiddenWeapon = anqi;
					num = ((int)num2 * -1261888195) ^ 0x1D831C49;
					continue;
				case 18u:
					role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(187771104u)] = maxmp;
					role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(395646854u)] = maxmp;
					num = ((int)num2 * -1093084298) ^ 0x6A873945;
					continue;
				case 45u:
					role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(248942232u)] = num3;
					num = ((int)num2 * -91062657) ^ 0x1A379050;
					continue;
				case 51u:
				{
					int num15;
					if (role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3795453722u)] <= num3)
					{
						num = 1226131564;
						num15 = num;
					}
					else
					{
						num = 1243611048;
						num15 = num;
					}
					continue;
				}
				case 39u:
					role.character2 = character2;
					num = ((int)num2 * -356390654) ^ -925576569;
					continue;
				case 20u:
					role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3406067330u)] = num3;
					num = ((int)num2 * -1958572409) ^ 0x283775F3;
					continue;
				case 42u:
					role.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1940200750u)] = daofa;
					num = ((int)num2 * -1211968206) ^ -522398440;
					continue;
				case 30u:
					role.Equipment.Add(itemInstance);
					num = (int)(num2 * 1432798451) ^ -187927443;
					continue;
				case 4u:
					role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1368077529u)] = num3;
					num = (int)((num2 * 1686146306) ^ 0x54BE4FAB);
					continue;
				case 48u:
					role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3406067330u)] = dingli;
					role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(199488088u)] = quanzhang;
					num = (int)(num2 * 1802468641) ^ -953604746;
					continue;
				case 27u:
					role.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(942219431u)] = qimen;
					role.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2145573044u)] = female;
					num = ((int)num2 * -1207179592) ^ -1632897681;
					continue;
				case 2u:
					role.Head = head;
					role.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2431070502u)] = maxhp;
					num = ((int)num2 * -1967487308) ^ -262479998;
					continue;
				case 11u:
				{
					int num7;
					if (num5 < array.Length)
					{
						num = 529056661;
						num7 = num;
					}
					else
					{
						num = 388211532;
						num7 = num;
					}
					continue;
				}
				case 3u:
					role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2575692001u)] = num3;
					num = (int)((num2 * 695499746) ^ 0x6BB54EA3);
					continue;
				case 49u:
					role.Name = name;
					num = (int)((num2 * 1588662449) ^ 0x3EEAC0E3);
					continue;
				case 36u:
					num5++;
					num = 1189608091;
					continue;
				case 37u:
					role.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1977936243u)] = num3;
					num = ((int)num2 * -1617816752) ^ 0x248E033F;
					continue;
				case 26u:
				{
					int num19;
					if (role.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3058596364u)] <= num3)
					{
						num = 2021468523;
						num19 = num;
					}
					else
					{
						num = 1070521837;
						num19 = num;
					}
					continue;
				}
				case 46u:
					role.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(710450445u)] = bili;
					role.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3051962998u)] = gengu;
					num = (int)(num2 * 215262144) ^ -267774746;
					continue;
				case 5u:
				{
					int num17;
					if (role.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1412133437u)] > num3)
					{
						num = 150144622;
						num17 = num;
					}
					else
					{
						num = 743192630;
						num17 = num;
					}
					continue;
				}
				case 24u:
					num5 = 0;
					num = ((int)num2 * -1959901972) ^ -493175337;
					continue;
				case 47u:
					role.isharem = isharem;
					num = ((int)num2 * -1825819024) ^ 0x2AF1B1C6;
					continue;
				case 6u:
				{
					int num16;
					if (role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2575692001u)] <= num3)
					{
						num = 2015318121;
						num16 = num;
					}
					else
					{
						num = 772841409;
						num16 = num;
					}
					continue;
				}
				case 38u:
				{
					int num13;
					int num14;
					if (anqi != null)
					{
						num13 = -254892476;
						num14 = num13;
					}
					else
					{
						num13 = -1446579447;
						num14 = num13;
					}
					num = num13 ^ ((int)num2 * -1970270004);
					continue;
				}
				case 32u:
					role.exp = exp;
					role.exp2 = 0.0 - (double)exp;
					num = ((int)num2 * -1248739079) ^ -117157757;
					continue;
				case 50u:
					role.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2259249129u)] = num3;
					num = (int)(num2 * 217682948) ^ -1805564834;
					continue;
				case 19u:
					role.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2301880830u)] = wuxing;
					role.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(664072894u)] = shenfa;
					num = (int)(num2 * 412516412) ^ -580427801;
					continue;
				case 34u:
					role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2873590287u)] = maxhp;
					num = ((int)num2 * -1541983393) ^ -133825031;
					continue;
				case 13u:
				{
					int num12;
					if (role.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(701808387u)] <= num3)
					{
						num = 1983463591;
						num12 = num;
					}
					else
					{
						num = 1801460344;
						num12 = num;
					}
					continue;
				}
				case 21u:
				{
					int num11;
					if (CommonSettings.MOD_KEY() >= 0)
					{
						num = 1407440454;
						num11 = num;
					}
					else
					{
						num = 1390564613;
						num11 = num;
					}
					continue;
				}
				case 41u:
					role.GrowTemplateValue = grow_template;
					num = ((int)num2 * -949542486) ^ 0x6D35B8BA;
					continue;
				case 12u:
				{
					int num10;
					if (role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2249625138u)] > num3)
					{
						num = 456220247;
						num10 = num;
					}
					else
					{
						num = 1484992719;
						num10 = num;
					}
					continue;
				}
				case 17u:
					role.leftpoint2 = leftpoint;
					num = ((int)num2 * -1908266007) ^ 0x42F1598C;
					continue;
				case 40u:
					role.Titles = GetTitles();
					role.jiushen_count = jiushen_count;
					num = ((int)num2 * -1934410500) ^ 0x63769348;
					continue;
				case 25u:
					role.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2741516750u)] = num3;
					num = (int)((num2 * 1891073334) ^ 0x617AB02D);
					continue;
				case 54u:
					role.Key = key;
					num = ((int)num2 * -1410205479) ^ -1185165313;
					continue;
				case 16u:
					role.Animation = animation;
					num = (int)((num2 * 9809501) ^ 0xBD9A9F4);
					continue;
				case 22u:
				{
					int num9;
					if (role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(394181284u)] <= num3)
					{
						num = 71209508;
						num9 = num;
					}
					else
					{
						num = 346337528;
						num9 = num;
					}
					continue;
				}
				case 9u:
				{
					itemInstance = array[num5].Generate2();
					int num8;
					if (itemInstance == null)
					{
						num = 1673733360;
						num8 = num;
					}
					else
					{
						num = 750986075;
						num8 = num;
					}
					continue;
				}
				case 33u:
					role.SetLevel(level);
					role.TalentValue = talent;
					num = ((int)num2 * -2128152521) ^ 0x17EE78E;
					continue;
				case 44u:
					role.Skills = GetSkills();
					num = ((int)num2 * -1829571657) ^ 0x492D0122;
					continue;
				case 7u:
					role.character = character;
					num = ((int)num2 * -646857638) ^ -760333151;
					continue;
				case 35u:
				{
					int num6;
					if (role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1029863417u)] > num3)
					{
						num = 218606601;
						num6 = num;
					}
					else
					{
						num = 1031076665;
						num6 = num;
					}
					continue;
				}
				case 53u:
				{
					int num4;
					if (role.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2053407229u)] <= num3)
					{
						num = 2006160137;
						num4 = num;
					}
					else
					{
						num = 805440547;
						num4 = num;
					}
					continue;
				}
				case 14u:
					role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1564888282u)] = num3;
					num = (int)(num2 * 1458784957) ^ -658913792;
					continue;
				case 15u:
					role.currentSkillName = currentSkillName;
					role.leftpoint = leftpoint;
					num = (int)((num2 * 1168389029) ^ 0x27860799);
					continue;
				default:
					role.InitBind();
					return role;
				}
				break;
			}
		}
	}

	static int _200F_200D_202C_200D_202E_206C_200D_200E_202C_200E_202A_202A_206E_202B_202D_206E_206F_202A_206E_200D_200E_200F_206C_200E_202B_206A_200B_202B_206E_206B_202A_206D_206A_206B_200B_200D_200B_202A_200B_202C_202E(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}
}
