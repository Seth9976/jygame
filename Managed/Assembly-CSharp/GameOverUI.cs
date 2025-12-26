using JyGame;
using UnityEngine;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
	public GameObject headImageObj;

	public GameObject deadTextObj;

	private Transform _200F_202A_202D_206C_206E_206D_200B_200F_200B_200D_206E_206B_202E_202B_200C_200C_202E_206B_202B_202B_206B_202B_206E_202C_202D_200E_206D_206C_200C_206E_206B_200F_202D_200B_202E_200C_202B_200B_202A_202E;

	public void MenuClicked()
	{
		bool flag = true;
		string saveName = default(string);
		int num4 = default(int);
		string save = default(string);
		while (true)
		{
			int num = 1588194381;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7D6CF43C)) % 18)
				{
				case 4u:
					break;
				default:
					return;
				case 10u:
					ModData.Load();
					RuntimeData.Instance.Round = 1;
					_200E_200C_202E_200D_202A_206A_200F_200D_202D_202B_202E_202C_202B_200B_206B_200C_202B_206C_206A_206A_206E_200E_202D_202A_200C_200F_202D_202E_202D_206D_206E_206E_202D_200B_200C_200F_200C_206D_200C_206B_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(12283984u));
					num = (int)(num2 * 1604432152) ^ -397336281;
					continue;
				case 13u:
					saveName = global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1566252443u);
					num = (int)(num2 * 401915617) ^ -592303402;
					continue;
				case 0u:
					flag = false;
					num = 349199411;
					continue;
				case 7u:
				{
					int num12;
					if (num4 > 20)
					{
						num = 1908335848;
						num12 = num;
					}
					else
					{
						num = 1599571759;
						num12 = num;
					}
					continue;
				}
				case 16u:
				{
					int num13;
					int num14;
					if (num4 < 1)
					{
						num13 = 249572374;
						num14 = num13;
					}
					else
					{
						num13 = 1403223557;
						num14 = num13;
					}
					num = num13 ^ (int)(num2 * 1322215977);
					continue;
				}
				case 17u:
				{
					int num9;
					if (!Configer.IsAutoSave)
					{
						num = 1149061140;
						num9 = num;
					}
					else
					{
						num = 1442532691;
						num9 = num;
					}
					continue;
				}
				case 11u:
				{
					int num6;
					if (!flag)
					{
						num = 388036758;
						num6 = num;
					}
					else
					{
						num = 1889376471;
						num6 = num;
					}
					continue;
				}
				case 5u:
					flag = false;
					num = ((int)num2 * -17444591) ^ -779848047;
					continue;
				case 2u:
					num4 = 1;
					num = ((int)num2 * -202759240) ^ -1377583681;
					continue;
				case 3u:
				{
					num4 = ModData.GetParam(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3505189006u));
					int num10;
					int num11;
					if (num4 != 0)
					{
						num10 = -1571576198;
						num11 = num10;
					}
					else
					{
						num10 = -1634238873;
						num11 = num10;
					}
					num = num10 ^ (int)(num2 * 1530980988);
					continue;
				}
				case 15u:
				{
					int num7;
					int num8;
					if (RuntimeData.Instance.Load(save))
					{
						num7 = -5224411;
						num8 = num7;
					}
					else
					{
						num7 = -1836405543;
						num8 = num7;
					}
					num = num7 ^ ((int)num2 * -22314395);
					continue;
				}
				case 14u:
					saveName = _202A_206E_202B_206C_206E_200B_202B_200C_200F_202C_202C_200F_200C_206C_206A_206B_200B_202D_202D_206A_206C_206E_202B_200C_200F_202C_206C_206D_202A_200E_202B_206B_202C_200E_206E_206C_206B_202E_202E_202E_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(145536241u), (object)(num4 - 1));
					num = 594835033;
					continue;
				case 8u:
				{
					int num5;
					if (!flag)
					{
						num = 349199411;
						num5 = num;
					}
					else
					{
						num = 1259410248;
						num5 = num;
					}
					continue;
				}
				case 6u:
					RuntimeData.Instance.gameEngine.SwitchGameScene(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4092172572u), RuntimeData.Instance.CurrentBigMap);
					num = ((int)num2 * -1937289218) ^ 0x6BAA2933;
					continue;
				case 12u:
					num4 = 20;
					num = ((int)num2 * -983219869) ^ 0x4C71D2D3;
					continue;
				case 1u:
				{
					save = SaveManager.GetSave(saveName);
					int num3;
					if (_202A_206D_200E_206E_200D_206B_206C_206F_206F_206C_202E_200B_200B_200E_200E_200B_200C_206B_206F_206D_200D_206A_206E_202E_206A_206E_202D_200E_206E_202A_202C_206E_200D_202A_206C_202E_206F_202D_200E_202E(save) > 10)
					{
						num = 272070937;
						num3 = num;
					}
					else
					{
						num = 839439680;
						num3 = num;
					}
					continue;
				}
				case 9u:
					return;
				}
				break;
			}
		}
	}

	private void Start()
	{
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		if (_206A_206E_200C_202A_200D_202A_206B_200E_206D_206D_200D_200E_200F_202B_206C_206B_206F_202E_200E_200D_206F_206F_202D_202E_200C_206A_202C_200E_206F_202A_202D_200D_200B_200C_202B_200D_206B_202B_200C_206D_202E((Object)(object)_200F_202A_202D_206C_206E_206D_200B_200F_200B_200D_206E_206B_202E_202B_200C_200C_202E_206B_202B_202B_206B_202B_206E_202C_202D_200E_206D_206C_200C_206E_206B_200F_202D_200B_202E_200C_202B_200B_202A_202E, (Object)null))
		{
			goto IL_0011;
		}
		goto IL_020b;
		IL_0011:
		int num = -2025905419;
		goto IL_0016;
		IL_0016:
		Text component3 = default(Text);
		Transform val2 = default(Transform);
		int param = default(int);
		Text component = default(Text);
		Vector3 val = default(Vector3);
		Text component2 = default(Text);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1314875410)) % 23)
			{
			case 12u:
				break;
			default:
				return;
			case 19u:
				_202E_200D_202D_206B_202D_206B_206E_200C_200F_202A_200F_200F_200D_206A_200B_200E_200B_202C_200E_202B_202E_202B_202A_200D_200B_206D_206A_206B_200E_202B_206A_200B_202E_206B_206E_206D_206E_206A_206B_202D_202E((Component)(object)component3).localPosition = new Vector3(0f, 270f, 0f);
				num = ((int)num2 * -1097030236) ^ -710852974;
				continue;
			case 18u:
			{
				int num5;
				int num6;
				if (_206E_202E_200C_200E_206A_202B_202C_206D_200F_202E_206B_206B_206B_202E_200F_206D_200E_206A_206E_202C_202D_202C_206D_202B_206F_202E_206A_206C_200C_202C_202E_200B_200B_200E_202D_202E_200B_206E_200F_202C_202E((Object)(object)_200F_202A_202D_206C_206E_206D_200B_200F_200B_200D_206E_206B_202E_202B_200C_200C_202E_206B_202B_202B_206B_202B_206E_202C_202D_200E_206D_206C_200C_206E_206B_200F_202D_200B_202E_200C_202B_200B_202A_202E, (Object)null))
				{
					num5 = -1760085402;
					num6 = num5;
				}
				else
				{
					num5 = -1918881793;
					num6 = num5;
				}
				num = num5 ^ (int)(num2 * 597326810);
				continue;
			}
			case 2u:
				component3.font = ModEditorResourceManager.GetFont(CommonSettings.SYSTEM_FONT_NAME);
				num = (int)((num2 * 826013223) ^ 0x7BC23273);
				continue;
			case 9u:
				val2 = _206B_202C_202A_206F_202C_206B_200F_200D_202E_206D_206E_200C_206D_202D_206E_206A_200E_200E_206A_202B_206D_202A_202E_200D_206B_202E_202E_200C_202E_206B_206C_202E_200F_206E_206C_206C_206B_202E_206F_206B_202E(_200D_202B_202C_206B_206E_200F_202E_206B_206E_206D_202B_200C_206D_200F_202D_206F_202B_202A_206F_202B_206E_206E_202B_200B_202B_206F_206C_206C_200E_206B_206F_200B_206F_200E_202E_202C_206E_202E_200C_206D_202E((Component)(object)this), global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(431580002u));
				_200F_202A_202D_206C_206E_206D_200B_200F_200B_200D_206E_206B_202E_202B_200C_200C_202E_206B_202B_202B_206B_202B_206E_202C_202D_200E_206D_206C_200C_206E_206B_200F_202D_200B_202E_200C_202B_200B_202A_202E = _206B_202C_202A_206F_202C_206B_200F_200D_202E_206D_206E_200C_206D_202D_206E_206A_200E_200E_206A_202B_206D_202A_202E_200D_206B_202E_202E_200C_202E_206B_206C_202E_200F_206E_206C_206C_206B_202E_206F_206B_202E(val2, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1952957766u));
				num = ((int)num2 * -1893995045) ^ 0x5310E8E0;
				continue;
			case 10u:
			{
				int num3;
				int num4;
				if (CommonSettings.USE_SYSTEM_FONT)
				{
					num3 = 604224287;
					num4 = num3;
				}
				else
				{
					num3 = 1623867337;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -541147361);
				continue;
			}
			case 0u:
				ModData.ParamAdd(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(8238043u), 1);
				num = (int)((num2 * 1946602378) ^ 0x1BD3709C);
				continue;
			case 16u:
				ModData.Save();
				ModData.SetParam(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1514299518u), param);
				num = (int)(num2 * 1982443220) ^ -1655703680;
				continue;
			case 11u:
				AudioManager.Instance.Play(ResourceStrings.ResStrings[1150]);
				num = (int)((num2 * 196509791) ^ 0x7F8C0D81);
				continue;
			case 6u:
				component3.text = ResourceStrings.ResStrings[1086];
				num = (int)((num2 * 512438230) ^ 0x4E44E49C);
				continue;
			case 7u:
				goto IL_020b;
			case 13u:
				((Component)((Component)component3).transform).GetComponent<RectTransform>().sizeDelta = new Vector2(1140f, 80f);
				num = (int)((num2 * 318503102) ^ 0x1CAA3AA6);
				continue;
			case 1u:
				goto IL_025c;
			case 17u:
				component.text = ResourceStrings.ResStrings[1087];
				num = ((int)num2 * -1659715196) ^ 0x70F4249C;
				continue;
			case 15u:
				((Component)((Component)val2).transform.FindChild(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1564899956u))).GetComponent<RectTransform>().sizeDelta = new Vector2(640f * CommonSettings.ScreenScale, 640f);
				num = (int)(num2 * 137201412) ^ -1063476915;
				continue;
			case 22u:
				headImageObj.GetComponent<Image>().sprite = Resource.GetGrayImage(RuntimeData.Instance.Team[0].Head, forceLoadFromResource: false, 150, 150);
				deadTextObj.GetComponent<Text>().text = string.Format(ResourceStrings.ResStrings[1151], ModData.GetParam(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3807302834u)));
				num = ((int)num2 * -1067890217) ^ 0x4D94E774;
				continue;
			case 5u:
				component3.alignment = (TextAnchor)1;
				num = (int)(num2 * 981805485) ^ -128991703;
				continue;
			case 3u:
				val = _200B_200B_202D_206F_202E_202D_206E_206C_206F_206E_202E_206A_200F_200E_206C_202D_202E_206F_206C_206B_200C_202C_200B_206D_200B_206C_202A_202E_202C_202E_202E_206B_206E_206B_202B_200E_206D_202B_202B_206E_202E(_200F_202A_202D_206C_206E_206D_200B_200F_200B_200D_206E_206B_202E_202B_200C_200C_202E_206B_202B_202B_206B_202B_206E_202C_202D_200E_206D_206C_200C_206E_206B_200F_202D_200B_202E_200C_202B_200B_202A_202E);
				num = (int)(num2 * 1201893735) ^ -1980298307;
				continue;
			case 8u:
				component2.text = ResourceStrings.ResStrings[1088];
				num = ((int)num2 * -511501402) ^ 0x363E4787;
				continue;
			case 4u:
				_200F_200E_206B_200B_202A_202E_206F_206B_206B_206D_206C_202B_200E_206B_206C_202D_206F_202C_200C_202A_202E_202D_206E_206C_200E_200F_202E_206A_200D_202B_206A_206E_200B_200E_200D_202A_202C_202A_206F_206E_202E(_200F_202A_202D_206C_206E_206D_200B_200F_200B_200D_206E_206B_202E_202B_200C_200C_202E_206B_202B_202B_206B_202B_206E_202C_202D_200E_206D_206C_200C_206E_206B_200F_202D_200B_202E_200C_202B_200B_202A_202E, val);
				component3 = ((Component)_206B_202C_202A_206F_202C_206B_200F_200D_202E_206D_206E_200C_206D_202D_206E_206A_200E_200E_206A_202B_206D_202A_202E_200D_206B_202E_202E_200C_202E_206B_206C_202E_200F_206E_206C_206C_206B_202E_206F_206B_202E(val2, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1853918955u))).GetComponent<Text>();
				component = ((Component)_206B_202C_202A_206F_202C_206B_200F_200D_202E_206D_206E_200C_206D_202D_206E_206A_200E_200E_206A_202B_206D_202A_202E_200D_206B_202E_202E_200C_202E_206B_206C_202E_200F_206E_206C_206C_206B_202E_206F_206B_202E(val2, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1702976983u))).GetComponent<Text>();
				component2 = ((Component)_206B_202C_202A_206F_202C_206B_200F_200D_202E_206D_206E_200C_206D_202D_206E_206A_200E_200E_206A_202B_206D_202A_202E_200D_206B_202E_202E_200C_202E_206B_206C_202E_200F_206E_206C_206C_206B_202E_206F_206B_202E(_206B_202C_202A_206F_202C_206B_200F_200D_202E_206D_206E_200C_206D_202D_206E_206A_200E_200E_206A_202B_206D_202A_202E_200D_206B_202E_202E_200C_202E_206B_206C_202E_200F_206E_206C_206C_206B_202E_206F_206B_202E(val2, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(529268397u)), global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2510808305u))).GetComponent<Text>();
				num = ((int)num2 * -1923765677) ^ 0x159F4D2;
				continue;
			case 14u:
				val.y = (int)val.y - 3;
				num = ((int)num2 * -1550609831) ^ 0x4DA46C15;
				continue;
			case 21u:
				component.font = ModEditorResourceManager.GetFont(CommonSettings.SYSTEM_FONT_NAME);
				component2.font = ModEditorResourceManager.GetFont(CommonSettings.SYSTEM_FONT_NAME);
				deadTextObj.GetComponent<Text>().font = ModEditorResourceManager.GetFont(CommonSettings.SYSTEM_FONT_NAME);
				num = ((int)num2 * -1516555368) ^ 0x76D1699A;
				continue;
			case 20u:
				return;
			}
			break;
			IL_025c:
			int num7;
			if (CommonSettings.ScreenScale < 2f)
			{
				num = -965256343;
				num7 = num;
			}
			else
			{
				num = -1776408281;
				num7 = num;
			}
		}
		goto IL_0011;
		IL_020b:
		param = ModData.GetParam(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2241351305u));
		ModData.Load();
		num = -2090160458;
		goto IL_0016;
	}

	private void Update()
	{
		if (!_202D_206D_206B_206E_206D_200C_202C_206F_206F_200D_202D_206B_206A_206F_206E_202B_200E_206C_202C_206D_206B_206B_200D_200C_206E_202E_200E_200D_200F_206D_202C_202A_200B_202D_200F_200F_206F_206B_206D_200C_202E((KeyCode)27))
		{
			goto IL_0009;
		}
		goto IL_0050;
		IL_0009:
		int num = -738605523;
		goto IL_000e;
		IL_000e:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -425974854)) % 4)
			{
			case 0u:
				break;
			default:
				return;
			case 3u:
			{
				int num3;
				int num4;
				if (_200C_206A_202E_200E_200E_202D_202C_206C_202D_200D_202A_206C_202A_202C_202E_202A_202B_206A_202B_202B_200F_206C_202A_202A_200E_206F_202A_202D_206B_202C_200C_200E_206F_202A_202C_200C_200E_202E_206E_202B_202E(1))
				{
					num3 = 703601161;
					num4 = num3;
				}
				else
				{
					num3 = 167229234;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -656890302);
				continue;
			}
			case 1u:
				goto IL_0050;
			case 2u:
				return;
			}
			break;
		}
		goto IL_0009;
		IL_0050:
		MenuClicked();
		num = -8737316;
		goto IL_000e;
	}

	static string _202A_206E_202B_206C_206E_200B_202B_200C_200F_202C_202C_200F_200C_206C_206A_206B_200B_202D_202D_206A_206C_206E_202B_200C_200F_202C_206C_206D_202A_200E_202B_206B_202C_200E_206E_206C_206B_202E_202E_202E_202E(string P_0, object P_1)
	{
		return string.Format(P_0, P_1);
	}

	static int _202A_206D_200E_206E_200D_206B_206C_206F_206F_206C_202E_200B_200B_200E_200E_200B_200C_206B_206F_206D_200D_206A_206E_202E_206A_206E_202D_200E_206E_202A_202C_206E_200D_202A_206C_202E_206F_202D_200E_202E(string P_0)
	{
		return P_0.Length;
	}

	static void _200E_200C_202E_200D_202A_206A_200F_200D_202D_202B_202E_202C_202B_200B_206B_200C_202B_206C_206A_206A_206E_200E_202D_202A_200C_200F_202D_202E_202D_206D_206E_206E_202D_200B_200C_200F_200C_206D_200C_206B_202E(string P_0)
	{
		Application.LoadLevel(P_0);
	}

	static bool _206A_206E_200C_202A_200D_202A_206B_200E_206D_206D_200D_200E_200F_202B_206C_206B_206F_202E_200E_200D_206F_206F_202D_202E_200C_206A_202C_200E_206F_202A_202D_200D_200B_200C_202B_200D_206B_202B_200C_206D_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static Transform _200D_202B_202C_206B_206E_200F_202E_206B_206E_206D_202B_200C_206D_200F_202D_206F_202B_202A_206F_202B_206E_206E_202B_200B_202B_206F_206C_206C_200E_206B_206F_200B_206F_200E_202E_202C_206E_202E_200C_206D_202E(Component P_0)
	{
		return P_0.transform;
	}

	static Transform _206B_202C_202A_206F_202C_206B_200F_200D_202E_206D_206E_200C_206D_202D_206E_206A_200E_200E_206A_202B_206D_202A_202E_200D_206B_202E_202E_200C_202E_206B_206C_202E_200F_206E_206C_206C_206B_202E_206F_206B_202E(Transform P_0, string P_1)
	{
		return P_0.FindChild(P_1);
	}

	static bool _206E_202E_200C_200E_206A_202B_202C_206D_200F_202E_206B_206B_206B_202E_200F_206D_200E_206A_206E_202C_202D_202C_206D_202B_206F_202E_206A_206C_200C_202C_202E_200B_200B_200E_202D_202E_200B_206E_200F_202C_202E(Object P_0, Object P_1)
	{
		return P_0 != P_1;
	}

	static Vector3 _200B_200B_202D_206F_202E_202D_206E_206C_206F_206E_202E_206A_200F_200E_206C_202D_202E_206F_206C_206B_200C_202C_200B_206D_200B_206C_202A_202E_202C_202E_202E_206B_206E_206B_202B_200E_206D_202B_202B_206E_202E(Transform P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.localPosition;
	}

	static void _200F_200E_206B_200B_202A_202E_206F_206B_206B_206D_206C_202B_200E_206B_206C_202D_206F_202C_200C_202A_202E_202D_206E_206C_200E_200F_202E_206A_200D_202B_206A_206E_200B_200E_200D_202A_202C_202A_206F_206E_202E(Transform P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.localPosition = P_1;
	}

	static Transform _202E_200D_202D_206B_202D_206B_206E_200C_200F_202A_200F_200F_200D_206A_200B_200E_200B_202C_200E_202B_202E_202B_202A_200D_200B_206D_206A_206B_200E_202B_206A_200B_202E_206B_206E_206D_206E_206A_206B_202D_202E(Component P_0)
	{
		return P_0.transform;
	}

	static bool _202D_206D_206B_206E_206D_200C_202C_206F_206F_200D_202D_206B_206A_206F_206E_202B_200E_206C_202C_206D_206B_206B_200D_200C_206E_202E_200E_200D_200F_206D_202C_202A_200B_202D_200F_200F_206F_206B_206D_200C_202E(KeyCode P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Input.GetKeyDown(P_0);
	}

	static bool _200C_206A_202E_200E_200E_202D_202C_206C_202D_200D_202A_206C_202A_202C_202E_202A_202B_206A_202B_202B_200F_206C_202A_202A_200E_206F_202A_202D_206B_202C_200C_200E_206F_202A_202C_200C_200E_202E_206E_202B_202E(int P_0)
	{
		return Input.GetMouseButtonDown(P_0);
	}
}
