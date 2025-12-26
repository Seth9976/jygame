using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace JyGame;

public class SkillCoverTypeHelper
{
	[CompilerGenerated]
	private sealed class _200C_202B_206C_206B_206D_200C_202C_200B_202B_200E_200C_202C_202A_202C_202E_200B_206B_202C_202C_206F_200C_206B_202A_202A_206E_200C_206E_206B_202C_200B_200B_206E_200E_200D_200F_200B_202C_200D_202A_206A_202E
	{
		internal int i;
	}

	[CompilerGenerated]
	private sealed class _200F_202E_202D_200C_206E_206C_206E_202E_200E_202A_200E_200E_206A_206A_200B_200E_200B_206D_206C_202B_206B_206F_206E_206F_200B_202B_200F_206B_206F_200B_206A_200B_200D_202D_200D_200E_206C_206B_206F_200F_202E
	{
		internal int j;

		internal _200C_202B_206C_206B_206D_200C_202C_200B_202B_200E_200C_202C_202A_202C_202E_200B_206B_202C_202C_206F_200C_206B_202A_202A_206E_200C_206E_206B_202C_200B_200B_206E_200E_200D_200F_200B_202C_200D_202A_206A_202E _202E_200C_202A_206F_200C_206B_206B_202E_200C_200C_202E_200F_206D_206A_206A_200E_202B_206F_202C_206E_206A_206B_202B_206D_206E_206E_200E_206F_202A_202A_206F_200E_200C_202D_206A_206D_202E_202E_202E_206C_202E;

		internal bool _206D_202D_202D_206E_206E_206C_206E_200C_206E_206B_206E_206F_200D_206B_200F_200C_200F_200D_200E_206D_202C_202E_202E_206D_202E_200D_206E_200E_206F_200D_202C_200D_202B_206E_202B_202D_206A_206F_206C_200F_202E(LocationBlock P_0)
		{
			return P_0.X == _202E_200C_202A_206F_200C_206B_206B_202E_200C_200C_202E_200F_206D_206A_206A_200E_202B_206F_202C_206E_206A_206B_202B_206D_206E_206E_200E_206F_202A_202A_206F_200E_200C_202D_206A_206D_202E_202E_202E_206C_202E.i && P_0.Y == j;
		}
	}

	private SkillCoverType _200E_200E_200C_206B_200C_206C_202D_202C_206B_206D_206C_202C_202A_202A_206A_202E_200E_206C_202A_200C_206D_202C_202E_200E_206C_200E_202C_206A_206C_206D_206D_202D_202C_202C_202D_200F_206C_206D_206A_206D_202E;

	private static string[] coverTypeInfoMap;

	private float[] dSizeMap;

	private int[] dBaseCaseSizeMap;

	private float[] dCastSizeMap;

	private int _typeCode => (int)_200E_200E_200C_206B_200C_206C_202D_202C_206B_206D_206C_202C_202A_202A_206A_202E_200E_206C_202A_200C_206D_202C_202E_200E_206C_200E_202C_206A_206C_206D_206D_202D_202C_202C_202D_200F_206C_206D_206A_206D_202E;

	public float dSize => dSizeMap[_typeCode];

	public int baseCastSize => dBaseCaseSizeMap[_typeCode];

	public float dCastSize => dCastSizeMap[_typeCode];

	public string CoverTypeInfo => GetSkillTypeChinese(_typeCode);

	public SkillCoverTypeHelper(SkillCoverType P_0)
	{
		float[] array = new float[9];
		_206D_206A_200C_206B_200D_200F_206D_202C_200E_206D_202B_206B_202B_206A_202A_202C_206B_202C_202E_206D_206A_206C_200C_206C_200C_206F_202A_200D_206D_206C_202B_206C_202C_206E_206E_200B_200D_206E_200D_206C_202E((Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		dSizeMap = array;
		int[] array2 = new int[9];
		_206D_206A_200C_206B_200D_200F_206D_202C_200E_206D_202B_206B_202B_206A_202A_202C_206B_202C_202E_206D_206A_206C_200C_206C_200C_206F_202A_200D_206D_206C_202B_206C_202C_206E_206E_200B_200D_206E_200D_206C_202E((Array)array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		dBaseCaseSizeMap = array2;
		dCastSizeMap = new float[9] { 0.25f, 0f, 0f, 0.2f, 0f, 0f, 0f, 0f, 0f };
		base._002Ector();
		while (true)
		{
			int num = 240469143;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x25BF2BBD)) % 3)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_0075;
				case 0u:
					return;
				}
				break;
				IL_0075:
				_200E_200E_200C_206B_200C_206C_202D_202C_206B_206D_206C_202C_202A_202A_206A_202E_200E_206C_202A_200C_206D_202C_202E_200E_206C_200E_202C_206A_206C_206D_206D_202D_202C_202C_202D_200F_206C_206D_206A_206D_202E = P_0;
				num = (int)((num2 * 1268917233) ^ 0x2705E8F0);
			}
		}
	}

	static SkillCoverTypeHelper()
	{
		coverTypeInfoMap = new string[9]
		{
			global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4181274665u),
			global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2667843597u),
			global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2477448404u),
			global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3884016u),
			global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4168405835u),
			global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4013182711u),
			global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1161053589u),
			global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1640820124u),
			global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3948969899u)
		};
	}

	public static string GetSkillTypeChinese(int type)
	{
		if (type == 0)
		{
			goto IL_0006;
		}
		goto IL_015d;
		IL_0006:
		int num = 1516138867;
		goto IL_000b;
		IL_000b:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x10A15009)) % 17)
			{
			case 15u:
				break;
			case 4u:
				goto IL_0064;
			case 10u:
				return ResourceStrings.ResStrings[1043];
			case 16u:
				goto IL_009b;
			case 8u:
				return ResourceStrings.ResStrings[1041];
			case 0u:
				return ResourceStrings.ResStrings[1048];
			case 1u:
				return ResourceStrings.ResStrings[1046];
			case 3u:
				return ResourceStrings.ResStrings[1042];
			case 12u:
				return ResourceStrings.ResStrings[1045];
			case 5u:
				goto IL_015d;
			case 6u:
				goto IL_0175;
			case 11u:
				return ResourceStrings.ResStrings[1044];
			case 7u:
				goto IL_01af;
			case 9u:
				goto IL_01c7;
			case 14u:
				goto IL_01df;
			case 2u:
				return ResourceStrings.ResStrings[1047];
			default:
				return ResourceStrings.ResStrings[1049];
			}
			break;
			IL_01df:
			int num3;
			if (type != 4)
			{
				num = 251013463;
				num3 = num;
			}
			else
			{
				num = 1589551692;
				num3 = num;
			}
			continue;
			IL_01af:
			int num4;
			if (type != 7)
			{
				num = 1911471735;
				num4 = num;
			}
			else
			{
				num = 144128216;
				num4 = num;
			}
			continue;
			IL_009b:
			int num5;
			if (type == 3)
			{
				num = 1346036221;
				num5 = num;
			}
			else
			{
				num = 1834318032;
				num5 = num;
			}
			continue;
			IL_01c7:
			int num6;
			if (type == 5)
			{
				num = 1107498465;
				num6 = num;
			}
			else
			{
				num = 2045413795;
				num6 = num;
			}
			continue;
			IL_0064:
			int num7;
			if (type == 2)
			{
				num = 1978739733;
				num7 = num;
			}
			else
			{
				num = 1412971829;
				num7 = num;
			}
			continue;
			IL_0175:
			int num8;
			if (type != 6)
			{
				num = 966205520;
				num8 = num;
			}
			else
			{
				num = 1058461937;
				num8 = num;
			}
		}
		goto IL_0006;
		IL_015d:
		int num9;
		if (type == 1)
		{
			num = 415288240;
			num9 = num;
		}
		else
		{
			num = 1967482388;
			num9 = num;
		}
		goto IL_000b;
	}

	public int CostMp(float power, int size)
	{
		SkillCoverType skillCoverType = _200E_200E_200C_206B_200C_206C_202D_202C_206B_206D_206C_202C_202A_202A_206A_202E_200E_206C_202A_200C_206D_202C_202E_200E_206C_200E_202C_206A_206C_206D_206D_202D_202C_202C_202D_200F_206C_206D_206A_206D_202E;
		while (true)
		{
			int num = 930661954;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x39AC77FD)) % 11)
				{
				case 7u:
					break;
				case 4u:
					return _200B_200D_206F_202E_202E_202A_206A_200E_206C_200E_202D_200B_200E_202E_200D_206A_206A_206E_202B_202B_206D_202D_200B_200F_206A_206B_202B_202A_206C_202B_202B_202E_206E_200C_200E_200B_202C_202D_200D_206D_202E(10, (int)(_206E_200F_200D_202C_202A_200C_206C_206C_206C_202A_202B_202B_206A_206C_202D_206A_206E_200E_200C_206A_206E_200E_202E_200E_202D_202B_206D_202B_202A_200F_200B_200E_206F_202C_206C_206B_206E_206A_202D_206C_202E((double)power, 0.99) * (double)size * 0.7 * 8.0));
				case 10u:
					goto IL_0084;
				case 9u:
					num = ((int)num2 * -1528374133) ^ -110423435;
					continue;
				case 3u:
					goto IL_00cd;
				case 5u:
					switch (skillCoverType)
					{
					case SkillCoverType.LINE:
						break;
					case SkillCoverType.FRONT:
						goto IL_0084;
					case SkillCoverType.NORMAL:
						goto IL_00cd;
					default:
						goto IL_012e;
					case SkillCoverType.STAR:
						goto IL_0140;
					case SkillCoverType.FACE:
						goto IL_017a;
					case SkillCoverType.FAN:
						goto IL_01b4;
					case SkillCoverType.CROSS:
					case SkillCoverType.X:
						goto IL_01ee;
					case SkillCoverType.RING:
						goto IL_021e;
					}
					goto case 4u;
				case 1u:
					goto IL_0140;
				case 8u:
					goto IL_017a;
				case 6u:
					goto IL_01b4;
				case 2u:
					goto IL_01ee;
				default:
					goto IL_021e;
					IL_021e:
					return _200B_200D_206F_202E_202E_202A_206A_200E_206C_200E_202D_200B_200E_202E_200D_206A_206A_206E_202B_202B_206D_202D_200B_200F_206A_206B_202B_202A_206C_202B_202B_202E_206E_200C_200E_200B_202C_202D_200D_206D_202E(10, (int)(_206E_200F_200D_202C_202A_200C_206C_206C_206C_202A_202B_202B_206A_206C_202D_206A_206E_200E_200C_206A_206E_200E_202E_200E_202D_202B_206D_202B_202A_200F_200B_200E_206F_202C_206C_206B_206E_206A_202D_206C_202E((double)power, 0.99) * (double)size * 1.3 * 8.0));
					IL_01ee:
					return _200B_200D_206F_202E_202E_202A_206A_200E_206C_200E_202D_200B_200E_202E_200D_206A_206A_206E_202B_202B_206D_202D_200B_200F_206A_206B_202B_202A_206C_202B_202B_202E_206E_200C_200E_200B_202C_202D_200D_206D_202E(10, (int)(_206E_200F_200D_202C_202A_200C_206C_206C_206C_202A_202B_202B_206A_206C_202D_206A_206E_200E_200C_206A_206E_200E_202E_200E_202D_202B_206D_202B_202A_200F_200B_200E_206F_202C_206C_206B_206E_206A_202D_206C_202E((double)power, 0.99) * (double)size * 8.0));
					IL_01b4:
					return _200B_200D_206F_202E_202E_202A_206A_200E_206C_200E_202D_200B_200E_202E_200D_206A_206A_206E_202B_202B_206D_202D_200B_200F_206A_206B_202B_202A_206C_202B_202B_202E_206E_200C_200E_200B_202C_202D_200D_206D_202E(10, (int)(_206E_200F_200D_202C_202A_200C_206C_206C_206C_202A_202B_202B_206A_206C_202D_206A_206E_200E_200C_206A_206E_200E_202E_200E_202D_202B_206D_202B_202A_200F_200B_200E_206F_202C_206C_206B_206E_206A_202D_206C_202E((double)power, 0.99) * (double)size * 2.0 * 8.0));
					IL_017a:
					return _200B_200D_206F_202E_202E_202A_206A_200E_206C_200E_202D_200B_200E_202E_200D_206A_206A_206E_202B_202B_206D_202D_200B_200F_206A_206B_202B_202A_206C_202B_202B_202E_206E_200C_200E_200B_202C_202D_200D_206D_202E(10, (int)(_206E_200F_200D_202C_202A_200C_206C_206C_206C_202A_202B_202B_206A_206C_202D_206A_206E_200E_200C_206A_206E_200E_202E_200E_202D_202B_206D_202B_202A_200F_200B_200E_206F_202C_206C_206B_206E_206A_202D_206C_202E((double)power, 0.99) * (double)size * 1.8 * 8.0));
					IL_0140:
					return _200B_200D_206F_202E_202E_202A_206A_200E_206C_200E_202D_200B_200E_202E_200D_206A_206A_206E_202B_202B_206D_202D_200B_200F_206A_206B_202B_202A_206C_202B_202B_202E_206E_200C_200E_200B_202C_202D_200D_206D_202E(10, (int)(_206E_200F_200D_202C_202A_200C_206C_206C_206C_202A_202B_202B_206A_206C_202D_206A_206E_200E_200C_206A_206E_200E_202E_200E_202D_202B_206D_202B_202A_200F_200B_200E_206F_202C_206C_206B_206E_206A_202D_206C_202E((double)power, 0.99) * (double)size * 1.5 * 8.0));
					IL_012e:
					num = (int)(num2 * 121520154) ^ -111392462;
					continue;
					IL_00cd:
					return _200B_200D_206F_202E_202E_202A_206A_200E_206C_200E_202D_200B_200E_202E_200D_206A_206A_206E_202B_202B_206D_202D_200B_200F_206A_206B_202B_202A_206C_202B_202B_202E_206E_200C_200E_200B_202C_202D_200D_206D_202E(10, (int)(_206E_200F_200D_202C_202A_200C_206C_206C_206C_202A_202B_202B_206A_206C_202D_206A_206E_200E_200C_206A_206E_200E_202E_200E_202D_202B_206D_202B_202A_200F_200B_200E_206F_202C_206C_206B_206E_206A_202D_206C_202E((double)power, 0.99) * 1.8 * 8.0));
					IL_0084:
					return _200B_200D_206F_202E_202E_202A_206A_200E_206C_200E_202D_200B_200E_202E_200D_206A_206A_206E_202B_202B_206D_202D_200B_200F_206A_206B_202B_202A_206C_202B_202B_202E_206E_200C_200E_200B_202C_202D_200D_206D_202E(10, (int)(_206E_200F_200D_202C_202A_200C_206C_206C_206C_202A_202B_202B_206A_206C_202D_206A_206E_200E_200C_206A_206E_200E_202E_200E_202D_202B_206D_202B_202A_200F_200B_200E_206F_202C_206C_206B_206E_206A_202D_206C_202E((double)power, 0.99) * 1.2 * 8.0));
				}
				break;
			}
		}
	}

	public List<LocationBlock> GetSkillCoverBlocks(int x, int y, int spx, int spy, int coversize)
	{
		int mAX_X = BattleField.MAX_X;
		int mAX_Y = BattleField.MAX_Y;
		SkillCoverType skillCoverType = default(SkillCoverType);
		int num16 = default(int);
		int num18 = default(int);
		List<LocationBlock> list2 = default(List<LocationBlock>);
		int num21 = default(int);
		int num19 = default(int);
		int num28 = default(int);
		int num20 = default(int);
		int num25 = default(int);
		int num27 = default(int);
		int num29 = default(int);
		int num41 = default(int);
		int num37 = default(int);
		int num15 = default(int);
		int num13 = default(int);
		int num30 = default(int);
		LocationBlock current = default(LocationBlock);
		while (true)
		{
			int num = 1660635845;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2856DC2D)) % 105)
				{
				case 90u:
					break;
				case 43u:
					num = (int)((num2 * 33246376) ^ 0x642EE081);
					continue;
				case 87u:
					skillCoverType = _200E_200E_200C_206B_200C_206C_202D_202C_206B_206D_206C_202C_202A_202A_206A_202E_200E_206C_202A_200C_206D_202C_202E_200E_206C_200E_202C_206A_206C_206D_206D_202D_202C_202C_202D_200F_206C_206D_206A_206D_202E;
					num = ((int)num2 * -1215265661) ^ -1587758413;
					continue;
				case 54u:
					num16 = -1;
					num = (int)((num2 * 1892847630) ^ 0x4420FDE4);
					continue;
				case 20u:
					num = ((int)num2 * -1927919474) ^ 0x5D0DAE3F;
					continue;
				case 95u:
					num18 = -1;
					num = ((int)num2 * -123423739) ^ 0x76F9CD11;
					continue;
				case 52u:
					list2.Add(new LocationBlock
					{
						X = x,
						Y = y
					});
					num = 1008171886;
					continue;
				case 30u:
					goto IL_025a;
				case 67u:
					num21++;
					num = 1009517855;
					continue;
				case 55u:
					num19++;
					num = (int)(num2 * 1579340514) ^ -1272123902;
					continue;
				case 96u:
					switch (skillCoverType)
					{
					case SkillCoverType.NORMAL:
						break;
					case SkillCoverType.FRONT:
						goto IL_025a;
					default:
						goto IL_02c4;
					case SkillCoverType.FAN:
						goto IL_07a0;
					case SkillCoverType.RING:
						goto IL_089b;
					case SkillCoverType.CROSS:
						goto IL_0933;
					case SkillCoverType.FACE:
						goto IL_0979;
					case SkillCoverType.STAR:
						goto IL_0a6a;
					case SkillCoverType.X:
						goto IL_0acc;
					case SkillCoverType.LINE:
						goto IL_0cc9;
					}
					goto case 52u;
				case 40u:
					num28++;
					num = 1001575018;
					continue;
				case 11u:
				{
					int num24;
					if (_202E_206E_206F_206A_202E_200B_200C_200D_202B_206E_200B_206C_200B_202E_202E_206C_200D_206D_206B_206B_206B_200F_206D_206A_200E_200D_200C_200F_206C_200E_200F_200B_206E_206C_202A_206E_202C_206B_206D_206B_202E(num20) + _202E_206E_206F_206A_202E_200B_200C_200D_202B_206E_200B_206C_200B_202E_202E_206C_200D_206D_206B_206B_206B_200F_206D_206A_200E_200D_200C_200F_206C_200E_200F_200B_206E_206C_202A_206E_202C_206B_206D_206B_202E(num21) == coversize)
					{
						num = 1855979124;
						num24 = num;
					}
					else
					{
						num = 202506;
						num24 = num;
					}
					continue;
				}
				case 61u:
					list2.Add(new LocationBlock
					{
						X = x,
						Y = y + num19
					});
					num = ((int)num2 * -1780631704) ^ -122896632;
					continue;
				case 66u:
				{
					num16 = 0;
					int num57;
					int num58;
					if (x >= spx)
					{
						num57 = 845419208;
						num58 = num57;
					}
					else
					{
						num57 = 74650562;
						num58 = num57;
					}
					num = num57 ^ ((int)num2 * -1177145732);
					continue;
				}
				case 27u:
				{
					int num54;
					if (x > spx)
					{
						num = 572223475;
						num54 = num;
					}
					else
					{
						num = 882752062;
						num54 = num;
					}
					continue;
				}
				case 7u:
				{
					int num50;
					if (y >= spy)
					{
						num = 508248604;
						num50 = num;
					}
					else
					{
						num = 2064798985;
						num50 = num;
					}
					continue;
				}
				case 97u:
					num25++;
					num = 1096752555;
					continue;
				case 33u:
				{
					int num47;
					if (num27 <= coversize)
					{
						num = 991470951;
						num47 = num;
					}
					else
					{
						num = 2118798194;
						num47 = num;
					}
					continue;
				}
				case 9u:
					num29++;
					num = ((int)num2 * -1066842470) ^ 0x1E59CCB5;
					continue;
				case 2u:
				{
					int num44;
					if (x > spx)
					{
						num = 172014590;
						num44 = num;
					}
					else
					{
						num = 2028603673;
						num44 = num;
					}
					continue;
				}
				case 45u:
					num = (int)(num2 * 76848596) ^ -1931069833;
					continue;
				case 100u:
					num41++;
					num = ((int)num2 * -704128110) ^ -791619730;
					continue;
				case 101u:
				{
					int num40;
					if (num37 >= coversize)
					{
						num = 1385003453;
						num40 = num;
					}
					else
					{
						num = 390023048;
						num40 = num;
					}
					continue;
				}
				case 77u:
				{
					int num38;
					if (num28 <= num27)
					{
						num = 498872299;
						num38 = num;
					}
					else
					{
						num = 1422765537;
						num38 = num;
					}
					continue;
				}
				case 51u:
					num18 = 0;
					num = (int)(num2 * 1123251305) ^ -1784737259;
					continue;
				case 47u:
					list2.Add(new LocationBlock
					{
						X = x + num15 * num27,
						Y = y + num16 * num27 - num28
					});
					num = (int)((num2 * 1705227496) ^ 0x3B19BCC2);
					continue;
				case 16u:
				{
					int num32;
					int num33;
					if (num13 >= mAX_Y)
					{
						num32 = -559428375;
						num33 = num32;
					}
					else
					{
						num32 = -1246340818;
						num33 = num32;
					}
					num = num32 ^ ((int)num2 * -434987913);
					continue;
				}
				case 49u:
					list2.Add(new LocationBlock
					{
						X = x + num15 * num27 + num28,
						Y = y + num16 * num27
					});
					num = (int)((num2 * 1725567277) ^ 0x31D15A27);
					continue;
				case 91u:
				{
					int num23;
					if (num20 > coversize)
					{
						num = 1250057903;
						num23 = num;
					}
					else
					{
						num = 2085250695;
						num23 = num;
					}
					continue;
				}
				case 5u:
				{
					int num14;
					if (num13 < y + coversize / 2 + 1)
					{
						num = 433462710;
						num14 = num;
					}
					else
					{
						num = 872977304;
						num14 = num;
					}
					continue;
				}
				case 80u:
				{
					int num55;
					int num56;
					if (num25 >= mAX_X)
					{
						num55 = -690943870;
						num56 = num55;
					}
					else
					{
						num55 = -1867946321;
						num56 = num55;
					}
					num = num55 ^ ((int)num2 * -1691160103);
					continue;
				}
				case 58u:
					num13 = y - coversize / 2;
					num = ((int)num2 * -1870300774) ^ 0x5CFBD16D;
					continue;
				case 12u:
					num = ((int)num2 * -1019740006) ^ -1543378979;
					continue;
				case 99u:
					list2.Add(new LocationBlock
					{
						X = x + num18 * num41,
						Y = y + num30 * num41
					});
					num = 342359622;
					continue;
				case 57u:
					num15 = 0;
					num = ((int)num2 * -1560195561) ^ 0x209CA8F4;
					continue;
				case 13u:
					num = (int)(num2 * 1013851694) ^ -1576295034;
					continue;
				case 88u:
					list2.Add(new LocationBlock
					{
						X = num25,
						Y = num13
					});
					num = ((int)num2 * -838975861) ^ 0x55589268;
					continue;
				case 4u:
					list2.Add(new LocationBlock
					{
						X = x + num20,
						Y = y + num21
					});
					num = (int)((num2 * 401681366) ^ 0x49B3BE6C);
					continue;
				case 6u:
				{
					num30 = 0;
					int num52;
					int num53;
					if (x < spx)
					{
						num52 = -980424682;
						num53 = num52;
					}
					else
					{
						num52 = -1078958794;
						num53 = num52;
					}
					num = num52 ^ ((int)num2 * -589950065);
					continue;
				}
				case 65u:
				{
					int num51;
					if (y <= spy)
					{
						num = 1799726889;
						num51 = num;
					}
					else
					{
						num = 536021440;
						num51 = num;
					}
					continue;
				}
				case 14u:
					list2.Add(new LocationBlock
					{
						X = x + num29,
						Y = y
					});
					num = 534797110;
					continue;
				case 64u:
					num28 = 1;
					num = (int)(num2 * 639368282) ^ -1043216004;
					continue;
				case 89u:
					list2.Add(new LocationBlock
					{
						X = x,
						Y = y + num19 * -1
					});
					list2.Add(new LocationBlock
					{
						X = x + num19,
						Y = y + num19
					});
					list2.Add(new LocationBlock
					{
						X = x + num19 * -1,
						Y = y + num19
					});
					list2.Add(new LocationBlock
					{
						X = x + num19,
						Y = y + num19 * -1
					});
					num = (int)((num2 * 1464392400) ^ 0x4A42C0C8);
					continue;
				case 26u:
					num27++;
					num = ((int)num2 * -802294982) ^ -2036023803;
					continue;
				case 86u:
					num = (int)(num2 * 45188652) ^ -1045395707;
					continue;
				case 3u:
					num = (int)((num2 * 2038077571) ^ 0x78E36812);
					continue;
				case 71u:
				{
					int num49;
					if (y > spy)
					{
						num = 1399795324;
						num49 = num;
					}
					else
					{
						num = 804228863;
						num49 = num;
					}
					continue;
				}
				case 22u:
					goto IL_07a0;
				case 81u:
					num29 = 1;
					num = ((int)num2 * -2139925422) ^ -52964162;
					continue;
				case 98u:
				{
					int num48;
					if (y != spy)
					{
						num = 734788575;
						num48 = num;
					}
					else
					{
						num = 1860277988;
						num48 = num;
					}
					continue;
				}
				case 46u:
					list2.Add(new LocationBlock
					{
						X = x + num15 * num27 - num28,
						Y = y + num16 * num27
					});
					num = (int)(num2 * 600345082) ^ -483475919;
					continue;
				case 103u:
					num = ((int)num2 * -2105327416) ^ 0x194B50A7;
					continue;
				case 93u:
					list2.Add(new LocationBlock(x, y - 1));
					num = ((int)num2 * -1166385446) ^ 0x5375D2B0;
					continue;
				case 0u:
				{
					int num46;
					if (num13 < 0)
					{
						num = 1700753063;
						num46 = num;
					}
					else
					{
						num = 1756415375;
						num46 = num;
					}
					continue;
				}
				case 21u:
				{
					int num45;
					if (num25 >= x + coversize / 2 + 1)
					{
						num = 741085453;
						num45 = num;
					}
					else
					{
						num = 701912836;
						num45 = num;
					}
					continue;
				}
				case 31u:
					goto IL_089b;
				case 8u:
					list2.Add(new LocationBlock
					{
						X = x + num37,
						Y = y + num37
					});
					list2.Add(new LocationBlock
					{
						X = x + num37,
						Y = y - num37
					});
					list2.Add(new LocationBlock
					{
						X = x - num37,
						Y = y + num37
					});
					num = 2128675515;
					continue;
				case 73u:
					list2.Add(new LocationBlock(x - 1, y));
					num = (int)((num2 * 1454545982) ^ 0xE69EF0E);
					continue;
				case 35u:
					goto IL_0933;
				case 79u:
					num15 = -1;
					num = ((int)num2 * -2012696629) ^ 0x7FCA0F8D;
					continue;
				case 19u:
					num41 = 1;
					num = 1874132328;
					continue;
				case 70u:
					goto IL_0979;
				case 83u:
					list2.Add(new LocationBlock(x, y + 1));
					num = (int)(num2 * 1095527321) ^ -1984471424;
					continue;
				case 94u:
					num = (int)((num2 * 1485747611) ^ 0x55E75F4E);
					continue;
				case 76u:
					list2.Add(new LocationBlock
					{
						X = x + num15 * num27,
						Y = y + num16 * num27 + num28
					});
					num = 1120476520;
					continue;
				case 92u:
					num19 = 1;
					num = ((int)num2 * -897830050) ^ -1570727630;
					continue;
				case 62u:
					num37++;
					num = ((int)num2 * -1279544749) ^ 0x11EAC4E3;
					continue;
				case 23u:
				{
					int num43;
					if (y >= spy)
					{
						num = 1908244784;
						num43 = num;
					}
					else
					{
						num = 281034804;
						num43 = num;
					}
					continue;
				}
				case 25u:
					num16 = 1;
					num = (int)((num2 * 1022035900) ^ 0x38743225);
					continue;
				case 24u:
				{
					int num42;
					if (num41 <= coversize)
					{
						num = 830397759;
						num42 = num;
					}
					else
					{
						num = 1981004912;
						num42 = num;
					}
					continue;
				}
				case 39u:
					goto IL_0a6a;
				case 44u:
					num = (int)(num2 * 409199347) ^ -1380154306;
					continue;
				case 50u:
					num27 = 1;
					num = ((int)num2 * -639121596) ^ -438741549;
					continue;
				case 38u:
					num15 = 1;
					num = ((int)num2 * -752967926) ^ -2090970478;
					continue;
				case 75u:
					goto IL_0acc;
				case 37u:
					num = ((int)num2 * -1473443511) ^ 0x614F445A;
					continue;
				case 104u:
					list2 = new List<LocationBlock>();
					num = ((int)num2 * -1888127137) ^ -1383667200;
					continue;
				case 63u:
					list2.Add(new LocationBlock(x + 1, y));
					num = (int)((num2 * 1133266324) ^ 0x54057788);
					continue;
				case 15u:
					num = ((int)num2 * -645908391) ^ 0x4C4693D8;
					continue;
				case 42u:
					num13++;
					num = 254228046;
					continue;
				case 68u:
					num30 = 1;
					num = ((int)num2 * -658603266) ^ -817495903;
					continue;
				case 53u:
				{
					int num39;
					if (num15 == 0)
					{
						num = 1606947372;
						num39 = num;
					}
					else
					{
						num = 1018278759;
						num39 = num;
					}
					continue;
				}
				case 29u:
					num = (int)(num2 * 187885273) ^ -852036831;
					continue;
				case 69u:
					list2.Add(new LocationBlock
					{
						X = x + num29 * -1,
						Y = y
					});
					num = ((int)num2 * -125738767) ^ 0x3060AB10;
					continue;
				case 85u:
					num18 = 1;
					num = (int)(num2 * 559239235) ^ -525069024;
					continue;
				case 41u:
					list2.Add(new LocationBlock
					{
						X = x - num37,
						Y = y - num37
					});
					num = ((int)num2 * -2014129701) ^ -366531359;
					continue;
				case 56u:
				{
					int num35;
					int num36;
					if (x == spx)
					{
						num35 = -1788092570;
						num36 = num35;
					}
					else
					{
						num35 = -2134307982;
						num36 = num35;
					}
					num = num35 ^ (int)(num2 * 1340789273);
					continue;
				}
				case 36u:
					if (list2.Count > 1)
					{
						num = 179569982;
						continue;
					}
					return list2;
				case 28u:
				{
					int num34;
					if (num19 <= coversize)
					{
						num = 975888927;
						num34 = num;
					}
					else
					{
						num = 526608106;
						num34 = num;
					}
					continue;
				}
				case 59u:
				{
					int num31;
					if (num29 <= coversize)
					{
						num = 637841488;
						num31 = num;
					}
					else
					{
						num = 1750196739;
						num31 = num;
					}
					continue;
				}
				case 74u:
					list2.Add(new LocationBlock
					{
						X = x + num19,
						Y = y
					});
					list2.Add(new LocationBlock
					{
						X = x + num19 * -1,
						Y = y
					});
					num = 536227891;
					continue;
				case 102u:
					num30 = -1;
					num = (int)(num2 * 877824572) ^ -154562836;
					continue;
				case 60u:
					goto IL_0cc9;
				case 10u:
					list2.Add(new LocationBlock
					{
						X = x + num19 * -1,
						Y = y + num19 * -1
					});
					num = ((int)num2 * -1362320450) ^ -904600208;
					continue;
				case 32u:
					num = (int)(num2 * 1895287251) ^ -876158498;
					continue;
				case 18u:
					num21 = -coversize;
					num = 1009517855;
					continue;
				case 17u:
					list2.Add(new LocationBlock
					{
						X = x,
						Y = y + num29
					});
					list2.Add(new LocationBlock
					{
						X = x,
						Y = y + num29 * -1
					});
					num = (int)(num2 * 502621867) ^ -701877170;
					continue;
				case 78u:
					return list2;
				case 82u:
					list2.Add(new LocationBlock
					{
						X = x + num15 * num27,
						Y = y + num16 * num27
					});
					num = 2146310586;
					continue;
				case 84u:
				{
					int num26;
					if (num25 < 0)
					{
						num = 872977304;
						num26 = num;
					}
					else
					{
						num = 1306375559;
						num26 = num;
					}
					continue;
				}
				case 34u:
				{
					int num22;
					if (num21 > coversize)
					{
						num = 1095151846;
						num22 = num;
					}
					else
					{
						num = 227036277;
						num22 = num;
					}
					continue;
				}
				case 72u:
					num20++;
					num = (int)((num2 * 537811127) ^ 0x45C06DC4);
					continue;
				case 48u:
				{
					int num17;
					if (num15 + num16 != 0)
					{
						num = 824362024;
						num17 = num;
					}
					else
					{
						num = 734788575;
						num17 = num;
					}
					continue;
				}
				default:
					{
						List<LocationBlock> list = new List<LocationBlock>();
						using (List<LocationBlock>.Enumerator enumerator = list2.GetEnumerator())
						{
							while (true)
							{
								IL_0e9c:
								int num3;
								int num4;
								if (enumerator.MoveNext())
								{
									num3 = 283087565;
									num4 = num3;
								}
								else
								{
									num3 = 981940928;
									num4 = num3;
								}
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ 0x2856DC2D)) % 9)
									{
									case 0u:
										num3 = 283087565;
										continue;
									default:
										goto end_IL_0e52;
									case 3u:
										current = enumerator.Current;
										num3 = 1034047425;
										continue;
									case 8u:
										break;
									case 7u:
										list.Add(current);
										num3 = (int)((num2 * 191571806) ^ 0x4DC3690D);
										continue;
									case 4u:
									{
										int num11;
										int num12;
										if (current.X < mAX_X)
										{
											num11 = 1762770081;
											num12 = num11;
										}
										else
										{
											num11 = 984182181;
											num12 = num11;
										}
										num3 = num11 ^ (int)(num2 * 526487692);
										continue;
									}
									case 2u:
									{
										int num7;
										int num8;
										if (current.Y >= mAX_Y)
										{
											num7 = -1494570607;
											num8 = num7;
										}
										else
										{
											num7 = -895373845;
											num8 = num7;
										}
										num3 = num7 ^ ((int)num2 * -311351868);
										continue;
									}
									case 5u:
									{
										int num9;
										int num10;
										if (current.Y < 0)
										{
											num9 = -199234263;
											num10 = num9;
										}
										else
										{
											num9 = -655036245;
											num10 = num9;
										}
										num3 = num9 ^ ((int)num2 * -1430397695);
										continue;
									}
									case 6u:
									{
										int num5;
										int num6;
										if (current.X < 0)
										{
											num5 = -1114258339;
											num6 = num5;
										}
										else
										{
											num5 = -799484480;
											num6 = num5;
										}
										num3 = num5 ^ ((int)num2 * -1914041329);
										continue;
									}
									case 1u:
										goto end_IL_0e52;
									}
									goto IL_0e9c;
									continue;
									end_IL_0e52:
									break;
								}
								break;
							}
						}
						return list;
					}
					IL_0cc9:
					list2.Add(new LocationBlock
					{
						X = x,
						Y = y
					});
					num = 115182485;
					continue;
					IL_0acc:
					num37 = 0;
					num = 92944400;
					continue;
					IL_0a6a:
					list2.Add(new LocationBlock
					{
						X = x,
						Y = y
					});
					num = 928822016;
					continue;
					IL_0979:
					num25 = x - coversize / 2;
					num = 1096752555;
					continue;
					IL_0933:
					list2.Add(new LocationBlock
					{
						X = x,
						Y = y
					});
					num = 662141882;
					continue;
					IL_089b:
					num20 = -coversize;
					num = 184330034;
					continue;
					IL_07a0:
					list2.Add(new LocationBlock
					{
						X = x,
						Y = y
					});
					num = 1385475816;
					continue;
					IL_02c4:
					num = ((int)num2 * -1798011299) ^ -522929505;
					continue;
					IL_025a:
					list2.Add(new LocationBlock(x, y));
					num = 606419491;
					continue;
				}
				break;
			}
		}
	}

	public int GetCoverTypePower()
	{
		SkillCoverType skillCoverType = _200E_200E_200C_206B_200C_206C_202D_202C_206B_206D_206C_202C_202A_202A_206A_202E_200E_206C_202A_200C_206D_202C_202E_200E_206C_200E_202C_206A_206C_206D_206D_202D_202C_202C_202D_200F_206C_206D_206A_206D_202E;
		while (true)
		{
			int num = 1086640141;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x68C7D249)) % 8)
				{
				case 5u:
					break;
				case 4u:
					switch (skillCoverType)
					{
					case SkillCoverType.FAN:
						goto IL_0072;
					case SkillCoverType.NORMAL:
					case SkillCoverType.CROSS:
					case SkillCoverType.LINE:
					case SkillCoverType.RING:
					case SkillCoverType.X:
						goto IL_008a;
					case SkillCoverType.FACE:
						goto IL_0096;
					case SkillCoverType.STAR:
						goto IL_00a2;
					}
					num = ((int)num2 * -74919244) ^ 0x53E35E0E;
					continue;
				case 0u:
					goto IL_0072;
				case 7u:
					num = ((int)num2 * -145822050) ^ -1258458246;
					continue;
				case 3u:
					goto IL_008a;
				case 6u:
					goto IL_0096;
				case 2u:
					goto IL_00a2;
				default:
					{
						return 0;
					}
					IL_00a2:
					return 3;
					IL_0096:
					return 4;
					IL_008a:
					return 1;
					IL_0072:
					return 2;
				}
				break;
			}
		}
	}

	static void _206D_206A_200C_206B_200D_200F_206D_202C_200E_206D_202B_206B_202B_206A_202A_202C_206B_202C_202E_206D_206A_206C_200C_206C_200C_206F_202A_200D_206D_206C_202B_206C_202C_206E_206E_200B_200D_206E_200D_206C_202E(Array P_0, RuntimeFieldHandle P_1)
	{
		RuntimeHelpers.InitializeArray(P_0, P_1);
	}

	static double _206E_200F_200D_202C_202A_200C_206C_206C_206C_202A_202B_202B_206A_206C_202D_206A_206E_200E_200C_206A_206E_200E_202E_200E_202D_202B_206D_202B_202A_200F_200B_200E_206F_202C_206C_206B_206E_206A_202D_206C_202E(double P_0, double P_1)
	{
		return Math.Pow(P_0, P_1);
	}

	static int _200B_200D_206F_202E_202E_202A_206A_200E_206C_200E_202D_200B_200E_202E_200D_206A_206A_206E_202B_202B_206D_202D_200B_200F_206A_206B_202B_202A_206C_202B_202B_202E_206E_200C_200E_200B_202C_202D_200D_206D_202E(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	static int _202E_206E_206F_206A_202E_200B_200C_200D_202B_206E_200B_206C_200B_202E_202E_206C_200D_206D_206B_206B_206B_200F_206D_206A_200E_200D_200C_200F_206C_200E_200F_200B_206E_206C_202A_206E_202C_206B_206D_206B_202E(int P_0)
	{
		return Math.Abs(P_0);
	}
}
