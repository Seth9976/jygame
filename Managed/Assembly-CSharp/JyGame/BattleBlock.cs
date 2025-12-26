using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace JyGame;

public class BattleBlock : MonoBehaviour
{
	private BattleBlockStatus _206F_202E_202E_200C_202B_206B_206E_206D_202A_202D_202A_200F_200D_206F_206E_202E_206D_206F_202B_200C_206F_200E_206E_200D_202E_202A_202C_206D_206A_206A_202D_206B_202D_206D_202D_206B_206F_206F_202E_206D_202E;

	[CompilerGenerated]
	private bool _202D_206F_202B_202B_202B_202A_206E_202A_202A_206A_206B_200E_202B_202A_202B_206B_200E_202B_200C_202B_206E_200B_202E_202B_202D_206F_200F_202D_206F_200F_206F_206C_206E_206C_200E_206B_206E_202A_202B_200D_202E;

	[CompilerGenerated]
	private List<LocationBlock> _206B_202D_200D_202E_202C_200E_202D_202C_200D_202B_200C_206B_206B_202B_200E_202B_202E_200C_206C_202D_200F_202A_200C_206C_202C_206A_206D_202E_206E_200D_200C_202D_206B_206A_206E_200B_200B_200B_200F_206C_202E;

	private static float MOVEBLOCK_SCALE;

	private static float MOVEBLOCK_SCALE_Y_X_RATIO;

	public static float BASIC_SCALE => _206D_202E_206B_200C_206D_206B_206F_202D_200E_202C_202A_206F_206A_206A_202A_202D_202B_200D_202B_200B_202A_202C_206A_202E_206B_200B_206A_200D_202B_200F_206C_200F_200C_206D_202D_206E_200E_206C_200E_206B_202E(LuaManager.GetConfigDouble(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2713234739u)));

	public BattleBlockStatus Status
	{
		get
		{
			return _206F_202E_202E_200C_202B_206B_206E_206D_202A_202D_202A_200F_200D_206F_206E_202E_206D_206F_202B_200C_206F_200E_206E_200D_202E_202A_202C_206D_206A_206A_202D_206B_202D_206D_202D_206B_206F_206F_202E_206D_202E;
		}
		set
		{
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0165: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			_206F_202E_202E_200C_202B_206B_206E_206D_202A_202D_202A_200F_200D_206F_206E_202E_206D_206F_202B_200C_206F_200E_206E_200D_202E_202A_202C_206D_206A_206A_202D_206B_202D_206D_202D_206B_206F_206F_202E_206D_202E = value;
			BattleBlockStatus battleBlockStatus = _206F_202E_202E_200C_202B_206B_206E_206D_202A_202D_202A_200F_200D_206F_206E_202E_206D_206F_202B_200C_206F_200E_206E_200D_202E_202A_202C_206D_206A_206A_202D_206B_202D_206D_202D_206B_206F_206F_202E_206D_202E;
			while (true)
			{
				int num = -695586627;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -909415345)) % 18)
					{
					case 14u:
						break;
					default:
						return;
					case 9u:
						num = (int)(num2 * 1831397110) ^ -1161474917;
						continue;
					case 5u:
						num = (int)((num2 * 1609967395) ^ 0x2D6FC2D8);
						continue;
					case 15u:
						_206D_202C_200E_200B_202D_202E_202B_200F_202D_200F_202E_200D_206A_206C_206B_200D_200C_206E_202E_206C_206B_202B_206D_200B_202B_200D_202B_202B_200F_206A_202C_200F_202A_200F_206A_200C_206C_206C_202B_206F_202E(((Component)this).GetComponent<SpriteRenderer>(), Color.green);
						num = -60029071;
						continue;
					case 6u:
						num = ((int)num2 * -294465901) ^ 0x183D43B5;
						continue;
					case 1u:
						num = (int)((num2 * 915557343) ^ 0x141DBEB4);
						continue;
					case 2u:
						_206F_200D_206F_206F_202E_200E_202B_206F_206B_202A_206D_202D_202B_202C_202E_202D_200E_206D_202A_206E_206C_206F_206D_200C_200F_202B_200E_206A_202E_200F_202D_202E_200C_202B_206B_202D_200F_206A_202D_202A_202E(_206E_206C_202E_206B_206C_206C_200B_202C_200C_200C_200E_206E_206D_202B_206A_200D_206E_206F_202E_200B_202A_202A_202D_206C_202E_202E_206E_206C_202D_200B_206B_202A_206E_206C_200C_200E_200D_200F_202E_206B_202E((Component)(object)this), true);
						num = ((int)num2 * -1731773629) ^ 0x1E9F83D2;
						continue;
					case 12u:
						goto IL_00ea;
					case 7u:
						goto IL_0118;
					case 3u:
						return;
					case 4u:
						((Component)this).gameObject.SetActive(true);
						num = ((int)num2 * -2054181554) ^ 0x573860CE;
						continue;
					case 8u:
						goto IL_015f;
					case 16u:
						switch (battleBlockStatus)
						{
						case BattleBlockStatus.HighLightGreen:
							break;
						case BattleBlockStatus.HighLightRed:
							goto IL_00ea;
						case BattleBlockStatus.Normal:
							goto IL_0118;
						case BattleBlockStatus.HighLightBlue:
							goto IL_015f;
						default:
							goto IL_0193;
						case BattleBlockStatus.Hide:
							goto IL_01c3;
						}
						goto case 15u;
					case 0u:
						_206F_200D_206F_206F_202E_200E_202B_206F_206B_202A_206D_202D_202B_202C_202E_202D_200E_206D_202A_206E_206C_206F_206D_200C_200F_202B_200E_206A_202E_200F_202D_202E_200C_202B_206B_202D_200F_206A_202D_202A_202E(_206E_206C_202E_206B_206C_206C_200B_202C_200C_200C_200E_206E_206D_202B_206A_200D_206E_206F_202E_200B_202A_202A_202D_206C_202E_202E_206E_206C_202D_200B_206B_202A_206E_206C_200C_200E_200D_200F_202E_206B_202E((Component)(object)this), true);
						num = ((int)num2 * -1886323837) ^ -622537410;
						continue;
					case 11u:
						goto IL_01c3;
					case 17u:
						num = ((int)num2 * -336492478) ^ -2145770576;
						continue;
					case 13u:
						((Component)this).gameObject.SetActive(true);
						num = (int)((num2 * 1171962213) ^ 0x829607C);
						continue;
					case 10u:
						return;
						IL_01c3:
						_206F_200D_206F_206F_202E_200E_202B_206F_206B_202A_206D_202D_202B_202C_202E_202D_200E_206D_202A_206E_206C_206F_206D_200C_200F_202B_200E_206A_202E_200F_202D_202E_200C_202B_206B_202D_200F_206A_202D_202A_202E(_206E_206C_202E_206B_206C_206C_200B_202C_200C_200C_200E_206E_206D_202B_206A_200D_206E_206F_202E_200B_202A_202A_202D_206C_202E_202E_206E_206C_202D_200B_206B_202A_206E_206C_200C_200E_200D_200F_202E_206B_202E((Component)(object)this), false);
						num = -1328684787;
						continue;
						IL_0193:
						num = ((int)num2 * -1433482762) ^ 0x655E3F30;
						continue;
						IL_015f:
						((Component)this).GetComponent<SpriteRenderer>().color = Color.blue;
						num = -23121936;
						continue;
						IL_0118:
						_206D_202C_200E_200B_202D_202E_202B_200F_202D_200F_202E_200D_206A_206C_206B_200D_200C_206E_202E_206C_206B_202B_206D_200B_202B_200D_202B_202B_200F_206A_202C_200F_202A_200F_206A_200C_206C_206C_202B_206F_202E(((Component)this).GetComponent<SpriteRenderer>(), Color.white);
						num = -111496195;
						continue;
						IL_00ea:
						((Component)this).GetComponent<SpriteRenderer>().color = new Color(1f, 0.3882f, 0.2784f, 1f);
						num = -1146832057;
						continue;
					}
					break;
				}
			}
		}
	}

	public bool IsActive
	{
		[CompilerGenerated]
		get
		{
			return _202D_206F_202B_202B_202B_202A_206E_202A_202A_206A_206B_200E_202B_202A_202B_206B_200E_202B_200C_202B_206E_200B_202E_202B_202D_206F_200F_202D_206F_200F_206F_206C_206E_206C_200E_206B_206E_202A_202B_200D_202E;
		}
		[CompilerGenerated]
		set
		{
			_202D_206F_202B_202B_202B_202A_206E_202A_202A_206A_206B_200E_202B_202A_202B_206B_200E_202B_200C_202B_206E_200B_202E_202B_202D_206F_200F_202D_206F_200F_206F_206C_206E_206C_200E_206B_206E_202A_202B_200D_202E = value;
		}
	}

	public List<LocationBlock> RelatedBlocks
	{
		[CompilerGenerated]
		get
		{
			return _206B_202D_200D_202E_202C_200E_202D_202C_200D_202B_200C_206B_206B_202B_200E_202B_202E_200C_206C_202D_200F_202A_200C_206C_202C_206A_206D_202E_206E_200D_200C_202D_206B_206A_206E_200B_200B_200B_200F_206C_202E;
		}
		[CompilerGenerated]
		set
		{
			_206B_202D_200D_202E_202C_200E_202D_202C_200D_202B_200C_206B_206B_202B_200E_202B_202E_200C_206C_202D_200F_202A_200C_206C_202C_206A_206D_202E_206E_200D_200C_202D_206B_206A_206E_200B_200B_200B_200F_206C_202E = value;
		}
	}

	public void Reset()
	{
		IsActive = false;
		SetFocus(isFocus: false);
		Status = BattleBlockStatus.Hide;
	}

	public void SetFocus(bool isFocus)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		if (isFocus)
		{
			goto IL_0003;
		}
		goto IL_0030;
		IL_0003:
		int num = 1249476526;
		goto IL_0008;
		IL_0008:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x3FF1EC59)) % 5)
			{
			case 3u:
				break;
			default:
				return;
			case 4u:
				goto IL_0030;
			case 1u:
				return;
			case 2u:
				_202A_200F_202B_200B_200F_200D_200F_200B_200E_202E_200B_206E_206C_200B_200D_202A_206C_206A_202B_206F_202E_206D_206E_202D_206F_200E_206F_202D_202B_200D_202C_206B_200F_206F_206A_206F_202B_206A_206E_202E_202E((Component)(object)this).localScale = new Vector3(MOVEBLOCK_SCALE * 2f, MOVEBLOCK_SCALE * 2f * MOVEBLOCK_SCALE_Y_X_RATIO, 0f);
				num = (int)(num2 * 1137041266) ^ -1579659569;
				continue;
			case 0u:
				return;
			}
			break;
		}
		goto IL_0003;
		IL_0030:
		((Component)this).transform.localScale = new Vector3(MOVEBLOCK_SCALE * 1f, MOVEBLOCK_SCALE * 1f * MOVEBLOCK_SCALE_Y_X_RATIO, 0f);
		num = 1849365572;
		goto IL_0008;
	}

	private void Start()
	{
		Reset();
	}

	private void Update()
	{
	}

	internal static void initVar()
	{
		MOVEBLOCK_SCALE = BASIC_SCALE;
		MOVEBLOCK_SCALE_Y_X_RATIO = (float)BattleField.MOVEBLOCK_WIDTH / (float)BattleField.MOVEBLOCK_LENGTH;
	}

	static float _206D_202E_206B_200C_206D_206B_206F_202D_200E_202C_202A_206F_206A_206A_202A_202D_202B_200D_202B_200B_202A_202C_206A_202E_206B_200B_206A_200D_202B_200F_206C_200F_200C_206D_202D_206E_200E_206C_200E_206B_202E(double P_0)
	{
		return Convert.ToSingle(P_0);
	}

	static GameObject _206E_206C_202E_206B_206C_206C_200B_202C_200C_200C_200E_206E_206D_202B_206A_200D_206E_206F_202E_200B_202A_202A_202D_206C_202E_202E_206E_206C_202D_200B_206B_202A_206E_206C_200C_200E_200D_200F_202E_206B_202E(Component P_0)
	{
		return P_0.gameObject;
	}

	static void _206F_200D_206F_206F_202E_200E_202B_206F_206B_202A_206D_202D_202B_202C_202E_202D_200E_206D_202A_206E_206C_206F_206D_200C_200F_202B_200E_206A_202E_200F_202D_202E_200C_202B_206B_202D_200F_206A_202D_202A_202E(GameObject P_0, bool P_1)
	{
		P_0.SetActive(P_1);
	}

	static void _206D_202C_200E_200B_202D_202E_202B_200F_202D_200F_202E_200D_206A_206C_206B_200D_200C_206E_202E_206C_206B_202B_206D_200B_202B_200D_202B_202B_200F_206A_202C_200F_202A_200F_206A_200C_206C_206C_202B_206F_202E(SpriteRenderer P_0, Color P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.color = P_1;
	}

	static Transform _202A_200F_202B_200B_200F_200D_200F_200B_200E_202E_200B_206E_206C_200B_200D_202A_206C_206A_202B_206F_202E_206D_206E_202D_206F_200E_206F_202D_202B_200D_202C_206B_200F_206F_206A_206F_202B_206A_206E_202E_202E(Component P_0)
	{
		return P_0.transform;
	}
}
