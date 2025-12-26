using UnityEngine;

namespace JyGame;

public class AttackCastInfo
{
	public string info;

	public float property;

	public Color color;

	public AttackCastInfoType type;

	public BattleSprite sprite;

	public float attacktime;

	public int ease;

	public int ease2;

	public AttackCastInfo(BattleSprite P_0, string P_1, float P_2, Color P_3, AttackCastInfoType P_4 = AttackCastInfoType.ATTACK_TEXT, float P_5 = 0f, int P_6 = 24, int P_7 = 18)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = -534634996;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -782036124)) % 5)
				{
				case 2u:
					break;
				case 1u:
					sprite = P_0;
					num = ((int)num2 * -1026548306) ^ 0x5D30C8A1;
					continue;
				case 0u:
					info = P_1;
					property = P_2;
					color = P_3;
					num = (int)((num2 * 581716396) ^ 0x4879BD84);
					continue;
				case 4u:
					type = P_4;
					attacktime = P_5;
					ease = P_6;
					num = ((int)num2 * -1997661345) ^ -1489244703;
					continue;
				default:
					ease2 = P_7;
					return;
				}
				break;
			}
		}
	}
}
