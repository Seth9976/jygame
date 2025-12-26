using System.Collections.Generic;
using UnityEngine;

namespace JyGame;

public class AttackResult
{
	public int Hp;

	public int Mp;

	public int costBall;

	public bool Critical;

	public int repeatTime = 1;

	public List<Buff> Debuff = new List<Buff>();

	public List<Buff> Buff = new List<Buff>();

	public int targetX;

	public int targetY;

	public List<AttackCastInfo> castInfo = new List<AttackCastInfo>();

	public void AddCastInfo(BattleSprite sprite, string info, float property = 1f)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		castInfo.Add(new AttackCastInfo(sprite, info, property, Color.white, AttackCastInfoType.SMALL_DIALOG));
	}

	public void AddCastInfo(BattleSprite sprite, string[] infos, float property = 1f)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		while (true)
		{
			int num2;
			int num3;
			if (num >= infos.Length)
			{
				num2 = 437167060;
				num3 = num2;
			}
			else
			{
				num2 = 118090029;
				num3 = num2;
			}
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)(num2 ^ 0x64E767E8)) % 5)
				{
				case 2u:
					num2 = 118090029;
					continue;
				default:
					return;
				case 4u:
					break;
				case 3u:
					num++;
					num2 = (int)(num4 * 735416797) ^ -1656767656;
					continue;
				case 1u:
				{
					string text = infos[num];
					castInfo.Add(new AttackCastInfo(sprite, text, property / (float)infos.Length, Color.white, AttackCastInfoType.SMALL_DIALOG));
					num2 = 532465493;
					continue;
				}
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public void AddAttackInfo(BattleSprite sprite, string info, Color color)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		castInfo.Add(new AttackCastInfo(sprite, info, 1f, color));
	}

	public void ClearInfo(BattleSprite sprite)
	{
		List<AttackCastInfo> list = new List<AttackCastInfo>();
		using (List<AttackCastInfo>.Enumerator enumerator = castInfo.GetEnumerator())
		{
			AttackCastInfo current = default(AttackCastInfo);
			while (true)
			{
				IL_007d:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -1044761733;
					num2 = num;
				}
				else
				{
					num = -791043992;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -1192636385)) % 5)
					{
					case 2u:
						num = -791043992;
						continue;
					default:
						goto end_IL_0019;
					case 3u:
					{
						current = enumerator.Current;
						int num4;
						if (_206D_206D_200B_202D_202B_200F_202E_200D_206C_202B_200B_200E_200E_200F_202C_200B_206E_200F_206A_200F_206C_206B_206A_206D_200B_200C_202A_200F_206A_202D_206B_202B_202B_202D_206A_206E_200D_206A_200E_202E_202E((Object)(object)current.sprite, (Object)(object)sprite))
						{
							num = -1831175768;
							num4 = num;
						}
						else
						{
							num = -1675980029;
							num4 = num;
						}
						continue;
					}
					case 0u:
						list.Add(current);
						num = (int)((num3 * 1836827114) ^ 0x60038B45);
						continue;
					case 4u:
						break;
					case 1u:
						goto end_IL_0019;
					}
					goto IL_007d;
					continue;
					end_IL_0019:
					break;
				}
				break;
			}
		}
		using List<AttackCastInfo>.Enumerator enumerator = list.GetEnumerator();
		AttackCastInfo current2 = default(AttackCastInfo);
		while (true)
		{
			int num5;
			int num6;
			if (enumerator.MoveNext())
			{
				num5 = -439705493;
				num6 = num5;
			}
			else
			{
				num5 = -1049961730;
				num6 = num5;
			}
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num5 ^ -1192636385)) % 5)
				{
				case 0u:
					num5 = -439705493;
					continue;
				default:
					return;
				case 1u:
					current2 = enumerator.Current;
					num5 = -11295064;
					continue;
				case 4u:
					break;
				case 3u:
					castInfo.Remove(current2);
					num5 = (int)((num3 * 1861744401) ^ 0x3CB3D7AB);
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public void ClearAllInfo()
	{
		castInfo.Clear();
	}

	public void AddBuff(string name, int level, int round, int property = -1)
	{
		Buff.Add(new Buff
		{
			Name = name,
			Level = level,
			Round = round,
			Property = property
		});
	}

	public void AddDebuff(string name, int level, int round, int property = -1)
	{
		Debuff.Add(new Buff
		{
			Name = name,
			Level = level,
			Round = round,
			Property = property
		});
	}

	public void AddAttackInfo2(BattleSprite sprite, string info, Color color, float attacktime = 0f, int ease = 24, int ease2 = 18)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		castInfo.Add(new AttackCastInfo(sprite, info, 1f, color, AttackCastInfoType.ATTACK_TEXT, attacktime, ease, ease2));
	}

	public void AddCastInfo2(BattleSprite sprite, string info, float property = 1f, float attacktime = 0f)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		string[] array = _206E_206F_200C_200B_200E_200D_202B_200D_206A_202C_206C_206B_206A_202A_200B_202C_206F_202A_200D_206B_206A_200E_200E_206C_206A_202B_206C_206A_202B_206F_206E_206E_202B_202B_202E_202C_200B_202A_202A_202D_202E(info, new char[1] { '#' });
		castInfo.Add(new AttackCastInfo(sprite, array[Tools.GetRandomInt(0, array.Length) % array.Length], property, Color.white, AttackCastInfoType.SMALL_DIALOG, attacktime));
	}

	public void AddCastInfo2(BattleSprite sprite, string[] infos, float property = 1f, float attacktime = 0f)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		castInfo.Add(new AttackCastInfo(sprite, infos[Tools.GetRandomInt(0, infos.Length) % infos.Length], property, Color.white, AttackCastInfoType.SMALL_DIALOG, attacktime));
	}

	static bool _206D_206D_200B_202D_202B_200F_202E_200D_206C_202B_200B_200E_200E_200F_202C_200B_206E_200F_206A_200F_206C_206B_206A_206D_200B_200C_202A_200F_206A_202D_206B_202B_202B_202D_206A_206E_200D_206A_200E_202E_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static string[] _206E_206F_200C_200B_200E_200D_202B_200D_206A_202C_206C_206B_206A_202A_200B_202C_206F_202A_200D_206B_206A_200E_200E_206C_206A_202B_206C_206A_202B_206F_206E_206E_202B_202B_202E_202C_200B_202A_202A_202D_202E(string P_0, char[] P_1)
	{
		return P_0.Split(P_1);
	}
}
