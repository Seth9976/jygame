using System;
using System.Collections;
using JyGame;
using UnityEngine;
using UnityEngine.UI;

public class BattleSkillSelectPanelUI : MonoBehaviour
{
	public GameObject ParentBattleField;

	public GameObject CurrentSkillImage;

	public Transform selectContent => _206E_202C_200F_206E_202E_206C_206A_206B_206E_202A_200B_202C_200B_202D_206F_200F_206E_200E_202E_206E_206C_206E_200B_206C_206B_202D_200B_202B_206A_200F_202D_202B_200C_200F_206B_200B_200B_206A_206D_202C_202E((Component)(object)_206D_200F_202A_200C_206B_206D_200E_206B_202B_202B_202B_202C_206A_206C_200F_200F_202A_206E_202B_202B_206B_202D_206B_202C_206C_200E_200F_202E_200F_202B_200D_200B_200F_206A_202E_206C_206D_200D_200D_202E(_206D_200F_202A_200C_206B_206D_200E_206B_202B_202B_202B_202C_206A_206C_200F_200F_202A_206E_202B_202B_206B_202D_206B_202C_206C_200E_200F_202E_200F_202B_200D_200B_200F_206A_202E_206C_206D_200D_200D_202E(_200E_200F_206D_200C_200C_206F_200C_206B_206F_200E_200D_206D_206C_200F_202D_200D_200C_206C_206B_202C_200B_206E_202E_200F_200F_200E_200C_202A_202D_206B_202D_200E_202A_202D_202C_206B_200C_200E_200D_200D_202E((Component)(object)this), global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(995287636u)), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2034797658u)));

	private ScrollRect scrollRect => ((Component)_206D_200F_202A_200C_206B_206D_200E_206B_202B_202B_202B_202C_206A_206C_200F_200F_202A_206E_202B_202B_206B_202D_206B_202C_206C_200E_200F_202E_200F_202B_200D_200B_200F_206A_202E_206C_206D_200D_200D_202E(_200E_200F_206D_200C_200C_206F_200C_206B_206F_200E_200D_206D_206C_200F_202D_200D_200C_206C_206B_202C_200B_206E_202E_200F_200F_200E_200C_202A_202D_206B_202D_200E_202A_202D_202C_206B_200C_200E_200D_200D_202E((Component)(object)this), global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1253920575u))).GetComponent<ScrollRect>();

	public void Clear()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		Transform val = selectContent;
		IEnumerator enumerator = _200B_200D_200B_202A_206F_206F_200D_206A_206E_206C_200C_202E_202D_206E_200D_202D_202C_202B_202D_206D_200F_206F_200C_200E_202D_200C_206B_200D_206A_206D_206F_206B_206C_206D_202D_200C_200B_206A_206B_200F_202E(val);
		try
		{
			while (true)
			{
				IL_0052:
				int num;
				int num2;
				if (_200F_200E_202D_202E_206B_206A_202C_202A_202E_202C_200D_202E_206D_206E_202A_202D_202E_206F_206A_206B_206D_202D_206C_206A_202C_206D_202E_202D_200C_200F_200F_206D_200F_206B_200B_200E_202E_202C_206E_200C_202E(enumerator))
				{
					num = -181534928;
					num2 = num;
				}
				else
				{
					num = -1992028818;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -1419487762)) % 4)
					{
					case 3u:
						num = -181534928;
						continue;
					default:
						goto end_IL_0015;
					case 2u:
						_200D_206B_200E_200D_202B_200C_202D_206B_206E_206D_200F_202C_206F_202B_202B_202C_206D_206F_206D_200E_206A_200D_206C_200E_200F_202D_200C_202D_202A_206E_200C_200C_206D_200F_206C_200F_202D_202E_200C_200D_202E((Object)(object)_200C_200E_200D_202B_206E_202B_206B_202E_206F_206C_200F_202D_206A_206A_202D_206D_202A_202E_200D_206D_200F_206C_200D_200C_202B_206B_200B_202C_206D_202D_200E_206F_202B_202A_206E_200B_202D_206A_202C_202D_202E((Component)(Transform)_200B_200C_206A_202C_202E_200B_200C_206B_202A_200C_200C_206E_200D_200E_202B_202D_206C_202A_200E_200D_206F_200D_202A_202E_206B_206C_206B_206E_200B_202A_206F_206A_206D_202A_206D_202C_202E_206A_202A_206D_202E(enumerator)));
						num = -2096715573;
						continue;
					case 1u:
						break;
					case 0u:
						goto end_IL_0015;
					}
					goto IL_0052;
					continue;
					end_IL_0015:
					break;
				}
				break;
			}
		}
		finally
		{
			if (enumerator is IDisposable disposable)
			{
				while (true)
				{
					IL_0077:
					int num4 = -1973369374;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num4 ^ -1419487762)) % 3)
						{
						case 2u:
							break;
						default:
							goto end_IL_007c;
						case 1u:
							goto IL_0099;
						case 0u:
							goto end_IL_007c;
						}
						goto IL_0077;
						IL_0099:
						_200C_202B_206F_200C_202D_206E_206C_202A_206D_202C_200E_202A_206B_206A_202D_200D_206B_202E_206B_200E_206D_200B_206D_200D_202D_200F_200C_202C_200B_206B_202A_200C_200E_202B_202D_206D_202B_202B_202C_206C_202E(disposable);
						num4 = ((int)num3 * -9664295) ^ -1498577708;
						continue;
						end_IL_007c:
						break;
					}
					break;
				}
			}
		}
		_200B_206C_206F_206F_206F_206E_202B_206D_202E_206D_202C_206A_206A_206C_200C_206E_206F_200C_200B_202E_200C_202C_202C_200F_202E_202A_206B_200C_206A_200F_206A_206F_206A_206A_206B_202D_202E_200E_206C_202E_202E(val);
	}

	public void AddItem(GameObject item)
	{
		_206B_206C_200C_200D_202E_206B_200F_206C_202A_200D_206B_200B_200E_200C_206C_200E_206B_200E_202A_200D_200F_202D_200B_202A_200C_202B_200D_206E_206A_206D_200C_202A_200B_200C_202D_206A_206A_200F_200D_202E(_202B_206A_202D_206F_200B_206E_206F_206B_206A_206F_206A_206D_202C_200D_206D_206D_202C_206B_206E_206F_202D_206F_206E_206D_206C_200E_200B_206D_202E_200B_202D_200D_202C_202B_200B_202E_206E_202D_200D_202B_202E(item), selectContent);
	}

	public void SetCurrent(SkillBox cs)
	{
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		IEnumerator enumerator = _200B_200D_200B_202A_206F_206F_200D_206A_206E_206C_200C_202E_202D_206E_200D_202D_202C_202B_202D_206D_200F_206F_200C_200E_202D_200C_206B_200D_206A_206D_206F_206B_206C_206D_202D_200C_200B_206A_206B_200F_202E(selectContent);
		try
		{
			BattleSkillSelectItemUI component = default(BattleSkillSelectItemUI);
			while (true)
			{
				IL_0130:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -870076377;
					num2 = num;
				}
				else
				{
					num = -1661362748;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -1676503819)) % 14)
					{
					case 3u:
						num = -1661362748;
						continue;
					default:
						goto end_IL_0016;
					case 12u:
						((Graphic)((Component)((Component)component).transform.FindChild(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3951456742u))).GetComponent<Image>()).color = new Color(1f, 1f, 1f, 1f);
						num = ((int)num3 * -495286816) ^ -1008331141;
						continue;
					case 5u:
					{
						int num12;
						if (!component.isOn)
						{
							num = -82673497;
							num12 = num;
						}
						else
						{
							num = -1925955653;
							num12 = num;
						}
						continue;
					}
					case 6u:
					{
						int num10;
						int num11;
						if (component.Skill == cs)
						{
							num10 = 1708620788;
							num11 = num10;
						}
						else
						{
							num10 = 1743729663;
							num11 = num10;
						}
						num = num10 ^ ((int)num3 * -1998930606);
						continue;
					}
					case 10u:
					{
						int num6;
						int num7;
						if (!component.isOn)
						{
							num6 = 1133631562;
							num7 = num6;
						}
						else
						{
							num6 = 1753926778;
							num7 = num6;
						}
						num = num6 ^ (int)(num3 * 1161715999);
						continue;
					}
					case 2u:
						component.isOn = false;
						num = ((int)num3 * -1969226902) ^ -72883043;
						continue;
					case 8u:
						break;
					case 11u:
						num = ((int)num3 * -1739995631) ^ 0x7DE7F644;
						continue;
					case 1u:
					{
						int num8;
						int num9;
						if (_202B_206C_200B_206E_206A_200B_206B_202C_202E_206C_202A_202B_202B_206E_206C_202B_206A_200E_202E_200C_202D_206C_202C_206F_202E_202A_200E_206B_202C_200C_206C_202B_206C_206A_202D_206D_200E_206A_202C_200C_202E((Object)(object)component, (Object)null))
						{
							num8 = -615372600;
							num9 = num8;
						}
						else
						{
							num8 = -2075795138;
							num9 = num8;
						}
						num = num8 ^ ((int)num3 * -2145608953);
						continue;
					}
					case 7u:
					{
						int num4;
						int num5;
						if (component.Skill != cs)
						{
							num4 = 114765861;
							num5 = num4;
						}
						else
						{
							num4 = 1894453204;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -800947334);
						continue;
					}
					case 4u:
						((Graphic)((Component)_206D_200F_202A_200C_206B_206D_200E_206B_202B_202B_202B_202C_206A_206C_200F_200F_202A_206E_202B_202B_206B_202D_206B_202C_206C_200E_200F_202E_200F_202B_200D_200B_200F_206A_202E_206C_206D_200D_200D_202E(_206E_202C_200F_206E_202E_206C_206A_206B_206E_202A_200B_202C_200B_202D_206F_200F_206E_200E_202E_206E_206C_206E_200B_206C_206B_202D_200B_202B_206A_200F_202D_202B_200C_200F_206B_200B_200B_206A_206D_202C_202E((Component)(object)component), global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(536648983u))).GetComponent<Image>()).color = new Color(0.5f, 0.5f, 0.5f, 1f);
						num = (int)((num3 * 1030676670) ^ 0x5675D122);
						continue;
					case 9u:
					{
						Transform val = (Transform)_200B_200C_206A_202C_202E_200B_200C_206B_202A_200C_200C_206E_200D_200E_202B_202D_206C_202A_200E_200D_206F_200D_202A_202E_206B_206C_206B_206E_200B_202A_206F_206A_206D_202A_206D_202C_202E_206A_202A_206D_202E(enumerator);
						component = ((Component)val).GetComponent<BattleSkillSelectItemUI>();
						num = -521605146;
						continue;
					}
					case 13u:
						component.isOn = true;
						num = (int)(num3 * 1678912203) ^ -1920850096;
						continue;
					case 0u:
						goto end_IL_0016;
					}
					goto IL_0130;
					continue;
					end_IL_0016:
					break;
				}
				break;
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			while (true)
			{
				IL_0236:
				int num13 = -356475961;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num13 ^ -1676503819)) % 5)
					{
					case 0u:
						break;
					default:
						goto end_IL_023b;
					case 4u:
						disposable.Dispose();
						num13 = -784234203;
						continue;
					case 1u:
						goto end_IL_023b;
					case 3u:
					{
						int num14;
						int num15;
						if (disposable == null)
						{
							num14 = 921439199;
							num15 = num14;
						}
						else
						{
							num14 = 1406830640;
							num15 = num14;
						}
						num13 = num14 ^ ((int)num3 * -1963913896);
						continue;
					}
					case 2u:
						goto end_IL_023b;
					}
					goto IL_0236;
					continue;
					end_IL_023b:
					break;
				}
				break;
			}
		}
		CurrentSkillImage.GetComponent<CurrentSkillImageUI>().Bind(cs);
		while (true)
		{
			int num16 = -1743940178;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num16 ^ -1676503819)) % 3)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_02d1;
				case 0u:
					return;
				}
				break;
				IL_02d1:
				ParentBattleField.GetComponent<BattleField>().ShowCurrentAttackRange();
				num16 = ((int)num3 * -1312968363) ^ 0x27B5CF29;
			}
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SetCurrent2(SkillBox cs, bool showCurrentAttackRange = false)
	{
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		if (cs == null)
		{
			while (true)
			{
				uint num;
				switch ((num = 720159379u) % 3)
				{
				case 0u:
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
		IEnumerator enumerator = _200B_200D_200B_202A_206F_206F_200D_206A_206E_206C_200C_202E_202D_206E_200D_202D_202C_202B_202D_206D_200F_206F_200C_200E_202D_200C_206B_200D_206A_206D_206F_206B_206C_206D_202D_200C_200B_206A_206B_200F_202E(selectContent);
		try
		{
			BattleSkillSelectItemUI component = default(BattleSkillSelectItemUI);
			while (true)
			{
				IL_0206:
				int num2;
				int num3;
				if (!enumerator.MoveNext())
				{
					num2 = 234776660;
					num3 = num2;
				}
				else
				{
					num2 = 628948463;
					num3 = num2;
				}
				while (true)
				{
					uint num;
					switch ((num = (uint)(num2 ^ 0x789CA2C5)) % 13)
					{
					case 3u:
						num2 = 628948463;
						continue;
					default:
						goto end_IL_004b;
					case 12u:
						num2 = (int)(num * 1094027429) ^ -486064216;
						continue;
					case 0u:
					{
						int num5;
						int num6;
						if (component.isOn)
						{
							num5 = 1382246619;
							num6 = num5;
						}
						else
						{
							num5 = 1534659835;
							num6 = num5;
						}
						num2 = num5 ^ (int)(num * 1289238384);
						continue;
					}
					case 7u:
						component.isOn = false;
						((Graphic)((Component)_206D_200F_202A_200C_206B_206D_200E_206B_202B_202B_202B_202C_206A_206C_200F_200F_202A_206E_202B_202B_206B_202D_206B_202C_206C_200E_200F_202E_200F_202B_200D_200B_200F_206A_202E_206C_206D_200D_200D_202E(_206E_202C_200F_206E_202E_206C_206A_206B_206E_202A_200B_202C_200B_202D_206F_200F_206E_200E_202E_206E_206C_206E_200B_206C_206B_202D_200B_202B_206A_200F_202D_202B_200C_200F_206B_200B_200B_206A_206D_202C_202E((Component)(object)component), global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3284137417u))).GetComponent<Image>()).color = new Color(0.5f, 0.5f, 0.5f, 1f);
						num2 = (int)((num * 1192427086) ^ 0xF30A717);
						continue;
					case 6u:
						component.RefreshCoolDownImage(component.Skill);
						num2 = 7772982;
						continue;
					case 1u:
					{
						int num9;
						int num10;
						if (component.Skill != cs)
						{
							num9 = -1579722486;
							num10 = num9;
						}
						else
						{
							num9 = -1925758423;
							num10 = num9;
						}
						num2 = num9 ^ ((int)num * -290154569);
						continue;
					}
					case 9u:
					{
						int num11;
						int num12;
						if (component.Skill == cs)
						{
							num11 = 182503132;
							num12 = num11;
						}
						else
						{
							num11 = 1457686816;
							num12 = num11;
						}
						num2 = num11 ^ ((int)num * -96828103);
						continue;
					}
					case 10u:
					{
						int num7;
						int num8;
						if (!_202B_206C_200B_206E_206A_200B_206B_202C_202E_206C_202A_202B_202B_206E_206C_202B_206A_200E_202E_200C_202D_206C_202C_206F_202E_202A_200E_206B_202C_200C_206C_202B_206C_206A_202D_206D_200E_206A_202C_200C_202E((Object)(object)component, (Object)null))
						{
							num7 = -250374870;
							num8 = num7;
						}
						else
						{
							num7 = -902764964;
							num8 = num7;
						}
						num2 = num7 ^ ((int)num * -1428030574);
						continue;
					}
					case 11u:
						component = ((Component)(Transform)_200B_200C_206A_202C_202E_200B_200C_206B_202A_200C_200C_206E_200D_200E_202B_202D_206C_202A_200E_200D_206F_200D_202A_202E_206B_206C_206B_206E_200B_202A_206F_206A_206D_202A_206D_202C_202E_206A_202A_206D_202E(enumerator)).GetComponent<BattleSkillSelectItemUI>();
						num2 = 2139725659;
						continue;
					case 2u:
						component.isOn = true;
						((Graphic)((Component)((Component)component).transform.FindChild(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3284137417u))).GetComponent<Image>()).color = new Color(1f, 1f, 1f, 1f);
						num2 = (int)((num * 1137932577) ^ 0x11D5C759);
						continue;
					case 5u:
						break;
					case 4u:
					{
						int num4;
						if (component.isOn)
						{
							num2 = 1338048988;
							num4 = num2;
						}
						else
						{
							num2 = 1213320729;
							num4 = num2;
						}
						continue;
					}
					case 8u:
						goto end_IL_004b;
					}
					goto IL_0206;
					continue;
					end_IL_004b:
					break;
				}
				break;
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			while (true)
			{
				IL_0247:
				int num13 = 1676517655;
				while (true)
				{
					uint num;
					switch ((num = (uint)(num13 ^ 0x789CA2C5)) % 4)
					{
					case 0u:
						break;
					default:
						goto end_IL_024c;
					case 2u:
					{
						int num14;
						int num15;
						if (disposable != null)
						{
							num14 = 484335328;
							num15 = num14;
						}
						else
						{
							num14 = 478274742;
							num15 = num14;
						}
						num13 = num14 ^ ((int)num * -1778620197);
						continue;
					}
					case 3u:
						disposable.Dispose();
						num13 = (int)((num * 717643130) ^ 0x7BA7157E);
						continue;
					case 1u:
						goto end_IL_024c;
					}
					goto IL_0247;
					continue;
					end_IL_024c:
					break;
				}
				break;
			}
		}
		if (!showCurrentAttackRange)
		{
			return;
		}
		while (true)
		{
			int num16 = 388345409;
			while (true)
			{
				uint num;
				switch ((num = (uint)(num16 ^ 0x789CA2C5)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_02c4;
				case 1u:
					return;
				}
				break;
				IL_02c4:
				CurrentSkillImage.GetComponent<CurrentSkillImageUI>().Bind(cs);
				ParentBattleField.GetComponent<BattleField>().ShowCurrentAttackRange();
				num16 = ((int)num * -1048972230) ^ 0x7742E5B3;
			}
		}
	}

	static Transform _200E_200F_206D_200C_200C_206F_200C_206B_206F_200E_200D_206D_206C_200F_202D_200D_200C_206C_206B_202C_200B_206E_202E_200F_200F_200E_200C_202A_202D_206B_202D_200E_202A_202D_202C_206B_200C_200E_200D_200D_202E(Component P_0)
	{
		return P_0.transform;
	}

	static Transform _206D_200F_202A_200C_206B_206D_200E_206B_202B_202B_202B_202C_206A_206C_200F_200F_202A_206E_202B_202B_206B_202D_206B_202C_206C_200E_200F_202E_200F_202B_200D_200B_200F_206A_202E_206C_206D_200D_200D_202E(Transform P_0, string P_1)
	{
		return P_0.FindChild(P_1);
	}

	static Transform _206E_202C_200F_206E_202E_206C_206A_206B_206E_202A_200B_202C_200B_202D_206F_200F_206E_200E_202E_206E_206C_206E_200B_206C_206B_202D_200B_202B_206A_200F_202D_202B_200C_200F_206B_200B_200B_206A_206D_202C_202E(Component P_0)
	{
		return P_0.transform;
	}

	static IEnumerator _200B_200D_200B_202A_206F_206F_200D_206A_206E_206C_200C_202E_202D_206E_200D_202D_202C_202B_202D_206D_200F_206F_200C_200E_202D_200C_206B_200D_206A_206D_206F_206B_206C_206D_202D_200C_200B_206A_206B_200F_202E(Transform P_0)
	{
		return P_0.GetEnumerator();
	}

	static object _200B_200C_206A_202C_202E_200B_200C_206B_202A_200C_200C_206E_200D_200E_202B_202D_206C_202A_200E_200D_206F_200D_202A_202E_206B_206C_206B_206E_200B_202A_206F_206A_206D_202A_206D_202C_202E_206A_202A_206D_202E(IEnumerator P_0)
	{
		return P_0.Current;
	}

	static GameObject _200C_200E_200D_202B_206E_202B_206B_202E_206F_206C_200F_202D_206A_206A_202D_206D_202A_202E_200D_206D_200F_206C_200D_200C_202B_206B_200B_202C_206D_202D_200E_206F_202B_202A_206E_200B_202D_206A_202C_202D_202E(Component P_0)
	{
		return P_0.gameObject;
	}

	static void _200D_206B_200E_200D_202B_200C_202D_206B_206E_206D_200F_202C_206F_202B_202B_202C_206D_206F_206D_200E_206A_200D_206C_200E_200F_202D_200C_202D_202A_206E_200C_200C_206D_200F_206C_200F_202D_202E_200C_200D_202E(Object P_0)
	{
		Object.Destroy(P_0);
	}

	static bool _200F_200E_202D_202E_206B_206A_202C_202A_202E_202C_200D_202E_206D_206E_202A_202D_202E_206F_206A_206B_206D_202D_206C_206A_202C_206D_202E_202D_200C_200F_200F_206D_200F_206B_200B_200E_202E_202C_206E_200C_202E(IEnumerator P_0)
	{
		return P_0.MoveNext();
	}

	static void _200C_202B_206F_200C_202D_206E_206C_202A_206D_202C_200E_202A_206B_206A_202D_200D_206B_202E_206B_200E_206D_200B_206D_200D_202D_200F_200C_202C_200B_206B_202A_200C_200E_202B_202D_206D_202B_202B_202C_206C_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}

	static void _200B_206C_206F_206F_206F_206E_202B_206D_202E_206D_202C_206A_206A_206C_200C_206E_206F_200C_200B_202E_200C_202C_202C_200F_202E_202A_206B_200C_206A_200F_206A_206F_206A_206A_206B_202D_202E_200E_206C_202E_202E(Transform P_0)
	{
		P_0.DetachChildren();
	}

	static Transform _202B_206A_202D_206F_200B_206E_206F_206B_206A_206F_206A_206D_202C_200D_206D_206D_202C_206B_206E_206F_202D_206F_206E_206D_206C_200E_200B_206D_202E_200B_202D_200D_202C_202B_200B_202E_206E_202D_200D_202B_202E(GameObject P_0)
	{
		return P_0.transform;
	}

	static void _206B_206C_200C_200D_202E_206B_200F_206C_202A_200D_206B_200B_200E_200C_206C_200E_206B_200E_202A_200D_200F_202D_200B_202A_200C_202B_200D_206E_206A_206D_200C_202A_200B_200C_202D_206A_206A_200F_200D_202E(Transform P_0, Transform P_1)
	{
		P_0.SetParent(P_1);
	}

	static bool _202B_206C_200B_206E_206A_200B_206B_202C_202E_206C_202A_202B_202B_206E_206C_202B_206A_200E_202E_200C_202D_206C_202C_206F_202E_202A_200E_206B_202C_200C_206C_202B_206C_206A_202D_206D_200E_206A_202C_200C_202E(Object P_0, Object P_1)
	{
		return P_0 != P_1;
	}
}
