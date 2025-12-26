using JyGame;
using UnityEngine;
using UnityEngine.EventSystems;

public class ToolTipUI : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
	public GameObject TooltipObj;

	public GameObject[] OtherTooltipObjs;

	public bool IsTouchEnable = true;

	private BattleSprite battleSprite;

	public void OnPointerDown(PointerEventData data)
	{
		if (!CommonSettings.TOUCH_MODE)
		{
			return;
		}
		while (true)
		{
			int num = -82507083;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1215385187)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0029;
				case 1u:
					return;
				}
				break;
				IL_0029:
				ShowToolTip();
				num = (int)((num2 * 70169509) ^ 0x39A2A1DF);
			}
		}
	}

	public void OnPointerUp(PointerEventData data)
	{
		if (!CommonSettings.TOUCH_MODE)
		{
			return;
		}
		while (true)
		{
			int num = 1394372619;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7C249513)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0029;
				case 1u:
					return;
				}
				break;
				IL_0029:
				HideToolTip();
				num = ((int)num2 * -241170237) ^ -1491421773;
			}
		}
	}

	public void OnPointerEnter(PointerEventData data)
	{
		if (CommonSettings.TOUCH_MODE)
		{
			return;
		}
		while (true)
		{
			int num = 1335972038;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x34991658)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0029;
				case 1u:
					return;
				}
				break;
				IL_0029:
				ShowToolTip();
				num = ((int)num2 * -228902073) ^ -615656269;
			}
		}
	}

	public void OnPointerExit(PointerEventData data)
	{
		if (CommonSettings.TOUCH_MODE)
		{
			return;
		}
		while (true)
		{
			int num = 983920806;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x304DBBE3)) % 3)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_0029;
				case 0u:
					return;
				}
				break;
				IL_0029:
				HideToolTip();
				num = ((int)num2 * -190361949) ^ 0x5BBAEA04;
			}
		}
	}

	public void ShowToolTip()
	{
		if (!_206B_206D_200E_200C_200D_200B_206A_200E_206C_206C_200D_200B_200C_206E_206C_200B_200C_206F_200D_206C_200B_200D_206E_200B_202A_206A_202D_202B_202B_202B_202C_206D_206D_202A_200C_206B_202E_202E_206F_206B_202E((Object)(object)TooltipObj, (Object)null))
		{
			return;
		}
		GameObject[] otherTooltipObjs = default(GameObject[]);
		int num5 = default(int);
		while (true)
		{
			int num = -1383167606;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1526192446)) % 13)
				{
				case 7u:
					break;
				default:
					return;
				case 2u:
					_206B_202C_202E_206C_200E_200F_202E_200F_202C_206E_206B_206D_206E_206A_202D_206F_200D_206C_206F_200E_202E_200C_206B_202D_200B_202D_200B_202E_200F_200C_200F_200E_206C_202D_202A_200C_202E_200E_206C_206E_202E(TooltipObj, true);
					num = -790559848;
					continue;
				case 12u:
					battleSprite.Refresh2();
					num = (int)((num2 * 77673628) ^ 0x1E8536CD);
					continue;
				case 1u:
					num = (int)(num2 * 1559517854) ^ -1328309107;
					continue;
				case 0u:
					_206B_202C_202E_206C_200E_200F_202E_200F_202C_206E_206B_206D_206E_206A_202D_206F_200D_206C_206F_200E_202E_200C_206B_202D_200B_202D_200B_202E_200F_200C_200F_200E_206C_202D_202A_200C_202E_200E_206C_206E_202E(otherTooltipObjs[num5], true);
					num = -1279542608;
					continue;
				case 6u:
				{
					int num8;
					if (num5 >= otherTooltipObjs.Length)
					{
						num = -1946925795;
						num8 = num;
					}
					else
					{
						num = -1360316619;
						num8 = num;
					}
					continue;
				}
				case 9u:
					otherTooltipObjs = OtherTooltipObjs;
					num = (int)((num2 * 198547112) ^ 0x4346E548);
					continue;
				case 3u:
				{
					int num9;
					int num10;
					if (!_206B_206D_200E_200C_200D_200B_206A_200E_206C_206C_200D_200B_200C_206E_206C_200B_200C_206F_200D_206C_200B_200D_206E_200B_202A_206A_202D_202B_202B_202B_202C_206D_206D_202A_200C_206B_202E_202E_206F_206B_202E((Object)(object)battleSprite, (Object)null))
					{
						num9 = 1385219297;
						num10 = num9;
					}
					else
					{
						num9 = 1356218749;
						num10 = num9;
					}
					num = num9 ^ (int)(num2 * 73789565);
					continue;
				}
				case 11u:
					num5 = 0;
					num = ((int)num2 * -121364933) ^ 0xE1675B6;
					continue;
				case 10u:
					num5++;
					num = ((int)num2 * -332023400) ^ 0x2B984411;
					continue;
				case 8u:
				{
					int num6;
					int num7;
					if (OtherTooltipObjs.Length != 0)
					{
						num6 = 2267256;
						num7 = num6;
					}
					else
					{
						num6 = 36290445;
						num7 = num6;
					}
					num = num6 ^ ((int)num2 * -1468072120);
					continue;
				}
				case 4u:
				{
					int num3;
					int num4;
					if (OtherTooltipObjs != null)
					{
						num3 = 1587196296;
						num4 = num3;
					}
					else
					{
						num3 = 539034069;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 304766068);
					continue;
				}
				case 5u:
					return;
				}
				break;
			}
		}
	}

	public void HideToolTip()
	{
		if (!_206B_206D_200E_200C_200D_200B_206A_200E_206C_206C_200D_200B_200C_206E_206C_200B_200C_206F_200D_206C_200B_200D_206E_200B_202A_206A_202D_202B_202B_202B_202C_206D_206D_202A_200C_206B_202E_202E_206F_206B_202E((Object)(object)TooltipObj, (Object)null))
		{
			return;
		}
		int num3 = default(int);
		GameObject[] otherTooltipObjs = default(GameObject[]);
		while (true)
		{
			int num = 671495326;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x32F27132)) % 10)
				{
				case 7u:
					break;
				default:
					return;
				case 4u:
				{
					int num6;
					if (num3 < otherTooltipObjs.Length)
					{
						num = 276242347;
						num6 = num;
					}
					else
					{
						num = 2052336887;
						num6 = num;
					}
					continue;
				}
				case 8u:
					num3++;
					num = (int)((num2 * 1970821728) ^ 0x59EE314A);
					continue;
				case 6u:
					_206B_202C_202E_206C_200E_200F_202E_200F_202C_206E_206B_206D_206E_206A_202D_206F_200D_206C_206F_200E_202E_200C_206B_202D_200B_202D_200B_202E_200F_200C_200F_200E_206C_202D_202A_200C_202E_200E_206C_206E_202E(TooltipObj, false);
					num = ((int)num2 * -1716706544) ^ -1423281517;
					continue;
				case 5u:
					_206B_202C_202E_206C_200E_200F_202E_200F_202C_206E_206B_206D_206E_206A_202D_206F_200D_206C_206F_200E_202E_200C_206B_202D_200B_202D_200B_202E_200F_200C_200F_200E_206C_202D_202A_200C_202E_200E_206C_206E_202E(otherTooltipObjs[num3], false);
					num = 690679722;
					continue;
				case 1u:
				{
					int num7;
					int num8;
					if (OtherTooltipObjs == null)
					{
						num7 = 493652056;
						num8 = num7;
					}
					else
					{
						num7 = 688837304;
						num8 = num7;
					}
					num = num7 ^ ((int)num2 * -1422054385);
					continue;
				}
				case 9u:
				{
					int num4;
					int num5;
					if (OtherTooltipObjs.Length == 0)
					{
						num4 = -1957902509;
						num5 = num4;
					}
					else
					{
						num4 = -871634940;
						num5 = num4;
					}
					num = num4 ^ (int)(num2 * 646163924);
					continue;
				}
				case 2u:
					num3 = 0;
					num = (int)((num2 * 871202018) ^ 0x310F8396);
					continue;
				case 0u:
					otherTooltipObjs = OtherTooltipObjs;
					num = ((int)num2 * -1082225217) ^ 0x41954A12;
					continue;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	private void Start()
	{
		if (_200C_206F_202A_206B_206D_206C_206C_206F_200F_202A_200E_200E_200B_202C_200C_200D_202C_206D_206F_206B_202A_206F_206E_200C_200E_202D_202C_202C_206B_200C_200D_202B_206B_200C_200F_206A_202C_202B_206B_200D_202E((Object)(object)TooltipObj, (Object)null))
		{
			goto IL_000e;
		}
		goto IL_008b;
		IL_000e:
		int num = 390300828;
		goto IL_0013;
		IL_0013:
		Transform val = default(Transform);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x440F234E)) % 5)
			{
			case 4u:
				break;
			default:
				return;
			case 1u:
			{
				val = _200B_202E_202D_206B_206C_202C_202B_206D_202D_206D_206D_202E_200D_202E_206F_202E_200B_200E_202D_200B_200C_206B_200F_206C_202B_206D_202D_200E_200B_200C_202B_206D_202B_206E_206A_202C_200E_200D_202E(_206D_206D_202D_206D_206A_202A_206F_206D_206F_206B_200F_206E_202C_200E_206D_206E_206E_200F_206D_206F_206D_202E_206A_202B_202E_200E_200B_202A_202E_200F_206E_202B_200D_200E_206B_200D_202A_206B_200B_202D_202E((Component)(object)this), global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(675277663u));
				int num3;
				int num4;
				if (_206B_206D_200E_200C_200D_200B_206A_200E_206C_206C_200D_200B_200C_206E_206C_200B_200C_206F_200D_206C_200B_200D_206E_200B_202A_206A_202D_202B_202B_202B_202C_206D_206D_202A_200C_206B_202E_202E_206F_206B_202E((Object)(object)val, (Object)null))
				{
					num3 = 378102300;
					num4 = num3;
				}
				else
				{
					num3 = 663053165;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -929312110);
				continue;
			}
			case 3u:
				TooltipObj = _206B_202C_206E_206F_202B_202E_206D_206D_202E_202E_206C_200B_200B_202B_200F_206C_206F_206A_202A_206B_202B_200B_202B_200D_200F_200E_202C_200E_206A_200D_200C_200C_202B_200F_206E_202A_200C_206A_202C_206A_202E((Component)(object)val);
				num = ((int)num2 * -1963315284) ^ -997911455;
				continue;
			case 2u:
				goto IL_008b;
			case 0u:
				return;
			}
			break;
		}
		goto IL_000e;
		IL_008b:
		HideToolTip();
		num = 1399549508;
		goto IL_0013;
	}

	private void Update()
	{
	}

	public void SetBattleSprite(BattleSprite battleSprite)
	{
		this.battleSprite = battleSprite;
	}

	static bool _206B_206D_200E_200C_200D_200B_206A_200E_206C_206C_200D_200B_200C_206E_206C_200B_200C_206F_200D_206C_200B_200D_206E_200B_202A_206A_202D_202B_202B_202B_202C_206D_206D_202A_200C_206B_202E_202E_206F_206B_202E(Object P_0, Object P_1)
	{
		return P_0 != P_1;
	}

	static void _206B_202C_202E_206C_200E_200F_202E_200F_202C_206E_206B_206D_206E_206A_202D_206F_200D_206C_206F_200E_202E_200C_206B_202D_200B_202D_200B_202E_200F_200C_200F_200E_206C_202D_202A_200C_202E_200E_206C_206E_202E(GameObject P_0, bool P_1)
	{
		P_0.SetActive(P_1);
	}

	static bool _200C_206F_202A_206B_206D_206C_206C_206F_200F_202A_200E_200E_200B_202C_200C_200D_202C_206D_206F_206B_202A_206F_206E_200C_200E_202D_202C_202C_206B_200C_200D_202B_206B_200C_200F_206A_202C_202B_206B_200D_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static Transform _206D_206D_202D_206D_206A_202A_206F_206D_206F_206B_200F_206E_202C_200E_206D_206E_206E_200F_206D_206F_206D_202E_206A_202B_202E_200E_200B_202A_202E_200F_206E_202B_200D_200E_206B_200D_202A_206B_200B_202D_202E(Component P_0)
	{
		return P_0.transform;
	}

	static Transform _200B_202E_202D_206B_206C_202C_202B_206D_202D_206D_206D_202E_200D_202E_206F_202E_200B_200E_202D_200B_200C_206B_200F_206C_202B_206D_202D_200E_200B_200C_202B_206D_202B_206E_206A_202C_200E_200D_202E(Transform P_0, string P_1)
	{
		return P_0.FindChild(P_1);
	}

	static GameObject _206B_202C_206E_206F_202B_202E_206D_206D_202E_202E_206C_200B_200B_202B_200F_206C_206F_206A_202A_206B_202B_200B_202B_200D_200F_200E_202C_200E_206A_200D_200C_200C_202B_200F_206E_202A_200C_206A_202C_206A_202E(Component P_0)
	{
		return P_0.gameObject;
	}
}
