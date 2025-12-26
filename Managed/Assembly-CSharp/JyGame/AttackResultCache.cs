using System.Collections.Generic;

namespace JyGame;

public class AttackResultCache
{
	private BattleSprite source;

	private BattleField field;

	public static Dictionary<SkillBox, Dictionary<BattleSprite, AttackResult>> cache;

	public static Dictionary<string, Dictionary<BattleSprite, AttackResult>> cacheV2;

	private string sourceInfo;

	public AttackResultCache(BattleSprite P_0, BattleField P_1)
	{
		source = P_0;
		field = P_1;
		sourceInfo = source.Role.Key + source.Team;
	}

	public AttackResult GetAttackResult(SkillBox skill, BattleSprite target)
	{
		string key = sourceInfo + skill.Name + skill.Level;
		if (cacheV2.ContainsKey(key))
		{
			goto IL_0030;
		}
		goto IL_00fd;
		IL_0030:
		int num = 430200758;
		goto IL_0035;
		IL_0035:
		AttackResult attackResult_AttackAnalog = default(AttackResult);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x29141027)) % 7)
			{
			case 0u:
				break;
			case 4u:
				cacheV2.Add(key, new Dictionary<BattleSprite, AttackResult>());
				num = ((int)num2 * -426174567) ^ -815976009;
				continue;
			case 2u:
				return cacheV2[key][target];
			case 6u:
			{
				int num5;
				int num6;
				if (!cacheV2.ContainsKey(key))
				{
					num5 = -1646780757;
					num6 = num5;
				}
				else
				{
					num5 = -1413003957;
					num6 = num5;
				}
				num = num5 ^ ((int)num2 * -309657967);
				continue;
			}
			case 3u:
			{
				int num3;
				int num4;
				if (cacheV2[key].ContainsKey(target))
				{
					num3 = 1331324463;
					num4 = num3;
				}
				else
				{
					num3 = 970124467;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -1077761243);
				continue;
			}
			case 1u:
				goto IL_00fd;
			default:
				cacheV2[key].Add(target, attackResult_AttackAnalog);
				return attackResult_AttackAnalog;
			}
			break;
		}
		goto IL_0030;
		IL_00fd:
		attackResult_AttackAnalog = AttackLogic.GetAttackResult_AttackAnalog(skill, source, target, field);
		attackResult_AttackAnalog.ClearAllInfo();
		num = 1117395989;
		goto IL_0035;
	}

	static AttackResultCache()
	{
		cacheV2 = new Dictionary<string, Dictionary<BattleSprite, AttackResult>>();
	}
}
