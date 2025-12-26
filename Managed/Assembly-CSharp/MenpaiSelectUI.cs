using System.Collections.Generic;
using JyGame;
using UnityEngine;
using UnityEngine.UI;

public class MenpaiSelectUI : MonoBehaviour
{
	public GameObject HeadImageObj;

	public GameObject MenpaiNameTextObj;

	public GameObject MenpaiInfoTextObj;

	public GameObject MenpaiDescTextObj;

	public GameObject BackgroundObj;

	private List<Menpai> Menpais = new List<Menpai>();

	private int currentIndex;

	public void OnPrevButtonClicked()
	{
		currentIndex--;
		while (true)
		{
			int num = 125538745;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1273DD64)) % 5)
				{
				case 4u:
					break;
				default:
					return;
				case 1u:
				{
					int num3;
					int num4;
					if (currentIndex < 0)
					{
						num3 = 1539974179;
						num4 = num3;
					}
					else
					{
						num3 = 852071970;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1982322600);
					continue;
				}
				case 2u:
					Refresh();
					num = 772812229;
					continue;
				case 3u:
					currentIndex = Menpais.Count - 1;
					num = (int)(num2 * 1246940629) ^ -1662597231;
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public void OnNextButtonClicked()
	{
		currentIndex++;
		while (true)
		{
			int num = -1585159997;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1461787263)) % 4)
				{
				case 3u:
					break;
				case 2u:
				{
					int num3;
					int num4;
					if (currentIndex < Menpais.Count)
					{
						num3 = -90026317;
						num4 = num3;
					}
					else
					{
						num3 = -134003814;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 975135551);
					continue;
				}
				case 1u:
					currentIndex = 0;
					num = (int)((num2 * 1883579631) ^ 0x25FFF006);
					continue;
				default:
					Refresh();
					return;
				}
				break;
			}
		}
	}

	public void OnConfirmButtonClicked()
	{
		MapUI.SetPrevSprite(_206C_206F_202E_206A_200E_202C_200B_202E_202C_200D_206C_200E_202D_206A_206A_206B_206F_202C_200D_202D_206F_200C_206B_200C_200F_206A_206C_206D_202C_200E_202C_202A_200B_202D_200F_206E_206A_206F_206C_206B_202E(BackgroundObj.GetComponent<Image>()), forceReLoad: false);
		Menpai menpai = Menpais[currentIndex];
		RuntimeData.Instance.gameEngine.SwitchGameScene(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(511095977u), menpai.story);
	}

	private void Start()
	{
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		if (CommonSettings.ScreenScale >= 2f)
		{
			goto IL_000f;
		}
		goto IL_03d5;
		IL_000f:
		int num = -1513850501;
		goto IL_0014;
		IL_0014:
		Transform val2 = default(Transform);
		Transform val = default(Transform);
		Sprite val3 = default(Sprite);
		Text component2 = default(Text);
		Text component = default(Text);
		Menpai current = default(Menpai);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -401486654)) % 28)
			{
			case 12u:
				break;
			case 14u:
			{
				Transform obj = val2.FindChild(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1320187667u));
				obj.localPosition = new Vector3(-79f, 52f, 0f);
				val = obj.FindChild(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3683974799u));
				num = (int)(num2 * 1028160765) ^ -1866477500;
				continue;
			}
			case 8u:
			{
				int num8;
				int num9;
				if (CommonSettings.USE_SYSTEM_FONT)
				{
					num8 = -978806631;
					num9 = num8;
				}
				else
				{
					num8 = -882358224;
					num9 = num8;
				}
				num = num8 ^ (int)(num2 * 855893005);
				continue;
			}
			case 24u:
				HeadImageObj.GetComponent<RectTransform>().sizeDelta = new Vector2(144f, 144f);
				num = (int)(num2 * 383360852) ^ -893590884;
				continue;
			case 16u:
				val.SetParent(val2);
				num = ((int)num2 * -544012341) ^ 0x62E2EB;
				continue;
			case 2u:
				MenpaiDescTextObj.GetComponent<Text>().font = ModEditorResourceManager.GetFont(CommonSettings.SYSTEM_FONT_NAME);
				num = (int)((num2 * 68836033) ^ 0x2DEBC2CE);
				continue;
			case 26u:
				MenpaiNameTextObj.GetComponent<Text>().font = ModEditorResourceManager.GetFont(CommonSettings.SYSTEM_FONT_NAME);
				MenpaiInfoTextObj.GetComponent<Text>().font = ModEditorResourceManager.GetFont(CommonSettings.SYSTEM_FONT_NAME);
				num = ((int)num2 * -345375536) ^ -843428216;
				continue;
			case 25u:
				RuntimeData.Instance.Init();
				num = (int)((num2 * 1495245355) ^ 0x35CD8CD8);
				continue;
			case 6u:
				HeadImageObj.GetComponent<RectTransform>().sizeDelta = new Vector2(214f, 214f);
				num = ((int)num2 * -1699535838) ^ 0x3D841570;
				continue;
			case 1u:
				((Component)((Component)val).GetComponent<Mask>()).GetComponent<Image>().sprite = val3;
				num = ((int)num2 * -236477607) ^ -10149092;
				continue;
			case 13u:
				AudioManager.Instance.Play(ResourceStrings.ResStrings[1149]);
				num = -564373223;
				continue;
			case 21u:
				val.SetAsFirstSibling();
				num = (int)((num2 * 602877628) ^ 0x285181B);
				continue;
			case 20u:
			{
				val3 = ModEditorResourceManager.uiCache[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(323858097u)];
				int num6;
				int num7;
				if ((Object)(object)val3 != (Object)null)
				{
					num6 = -1064588797;
					num7 = num6;
				}
				else
				{
					num6 = -1684150670;
					num7 = num6;
				}
				num = num6 ^ (int)(num2 * 1035638090);
				continue;
			}
			case 11u:
				MenpaiDescTextObj.transform.SetParent(val2);
				MenpaiDescTextObj.GetComponent<RectTransform>().sizeDelta = new Vector2(-170f, -372.9f);
				MenpaiDescTextObj.transform.localPosition = new Vector3(-11.5f, -100f, 0f);
				num = (int)(num2 * 187041664) ^ -1347605750;
				continue;
			case 9u:
				((Component)val).GetComponent<Mask>().showMaskGraphic = false;
				Object.Destroy((Object)(object)((Component)MenpaiDescTextObj.transform.parent.parent.parent.FindChild(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2816899263u))).gameObject);
				num = ((int)num2 * -1528665297) ^ -281650854;
				continue;
			case 4u:
				val.localPosition = new Vector3(-324f, 124f, 0f);
				((Component)val).GetComponent<RectTransform>().sizeDelta = new Vector2(214f, 214f);
				num = -569993494;
				continue;
			case 3u:
				component2.text = ResourceStrings.ResStrings[1085];
				num = ((int)num2 * -631411825) ^ -2128532725;
				continue;
			case 27u:
				goto IL_03d5;
			case 10u:
				goto IL_03f5;
			case 23u:
				val.localScale = new Vector3(1.01f, 1.01f, 1.01f);
				num = ((int)num2 * -1951102307) ^ -2081952977;
				continue;
			case 18u:
				HeadImageObj.transform.localPosition = new Vector3(-3.1f, 0.5f, 0f);
				num = -2067415017;
				continue;
			case 5u:
				BackgroundObj.GetComponent<RectTransform>().sizeDelta = new Vector2(640f * CommonSettings.ScreenScale, 640f);
				num = ((int)num2 * -1583766825) ^ 0x6EC8262;
				continue;
			case 17u:
				((Component)val).gameObject.AddComponent<Mask>();
				((Component)val).gameObject.AddComponent<Image>();
				num = (int)((num2 * 352592028) ^ 0x7131D6A2);
				continue;
			case 0u:
				component = ((Component)val2.FindChild(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1622071611u)).FindChild(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3171486348u)).FindChild(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2510808305u))).GetComponent<Text>();
				component2 = ((Component)((Component)this).transform.FindChild(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2441533065u))).GetComponent<Text>();
				component.text = ResourceStrings.ResStrings[1138];
				num = ((int)num2 * -12366017) ^ 0x698E8079;
				continue;
			case 22u:
				val.localPosition = new Vector3(-324f, 124f, 0f);
				num = ((int)num2 * -170319308) ^ -1365942820;
				continue;
			case 7u:
				component2.font = ModEditorResourceManager.GetFont(CommonSettings.SYSTEM_FONT_NAME);
				num = ((int)num2 * -1069761645) ^ 0x62A75CD;
				continue;
			case 19u:
				component.font = ModEditorResourceManager.GetFont(CommonSettings.SYSTEM_FONT_NAME);
				num = ((int)num2 * -576951129) ^ -870076452;
				continue;
			default:
			{
				Menpais.Clear();
				IEnumerator<Menpai> enumerator = ResourceManager.GetAll<Menpai>().GetEnumerator();
				try
				{
					while (true)
					{
						IL_0630:
						int num3;
						int num4;
						if (!enumerator.MoveNext())
						{
							num3 = -583476100;
							num4 = num3;
						}
						else
						{
							num3 = -2060405905;
							num4 = num3;
						}
						while (true)
						{
							switch ((num2 = (uint)(num3 ^ -401486654)) % 5)
							{
							case 4u:
								num3 = -2060405905;
								continue;
							default:
								goto end_IL_05dd;
							case 2u:
								current = enumerator.Current;
								num3 = -1753257106;
								continue;
							case 1u:
								Menpais.Add(current);
								num3 = ((int)num2 * -2087381291) ^ -2069362781;
								continue;
							case 3u:
								break;
							case 0u:
								goto end_IL_05dd;
							}
							goto IL_0630;
							continue;
							end_IL_05dd:
							break;
						}
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						while (true)
						{
							IL_0650:
							int num5 = -507197085;
							while (true)
							{
								switch ((num2 = (uint)(num5 ^ -401486654)) % 3)
								{
								case 0u:
									break;
								default:
									goto end_IL_0655;
								case 1u:
									goto IL_0673;
								case 2u:
									goto end_IL_0655;
								}
								goto IL_0650;
								IL_0673:
								enumerator.Dispose();
								num5 = ((int)num2 * -1062019221) ^ -1717255199;
								continue;
								end_IL_0655:
								break;
							}
							break;
						}
					}
				}
				currentIndex = 0;
				Refresh();
				return;
			}
			}
			break;
			IL_03f5:
			int num10;
			if (RuntimeData.Instance.IsInited)
			{
				num = -1931358333;
				num10 = num;
			}
			else
			{
				num = -1233815725;
				num10 = num;
			}
		}
		goto IL_000f;
		IL_03d5:
		val2 = ((Component)this).transform.FindChild(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2000443676u));
		num = -1947564284;
		goto IL_0014;
	}

	private void Refresh()
	{
		_200D_202E_206A_200E_202B_202E_206A_202B_202D_200B_200E_202A_206A_202D_202E_206C_206C_206A_200C_206D_202E_202C_200F_206B_202D_206D_202E_202C_202B_200F_202E_206A_206B_202B_206E_202E_202D_200F_202E_202E(_206A_202A_200F_202D_206B_202B_206C_206A_206B_200F_200F_202B_206F_202B_202A_202D_206F_202E_200B_206B_206A_200B_206F_206B_206E_202A_202E_206B_200D_202D_202E_200E_200C_200F_200F_202A_200F_200E_202B_200C_202E((Component)(object)_206F_206E_206C_202E_206E_206A_202C_206F_200B_202E_200B_202A_200E_200B_206E_206F_200C_202E_206F_202B_200C_202B_202E_202D_202C_202C_206A_202E_206A_206B_202B_200E_200D_206A_206F_200E_200F_206C_200F_200C_202E(_206E_206F_206E_206D_202C_206C_206B_206F_202E_206F_206F_202A_200D_206E_202D_200B_202A_200E_206F_206C_206C_200E_202C_202E_206F_202D_200D_202C_202C_206C_202B_202C_206D_202A_200D_202B_206E_202C_206D_206F_202E((Component)(object)this), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(569019878u))), false);
		Menpai menpai = default(Menpai);
		while (true)
		{
			int num = -1048355783;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1681509475)) % 11)
				{
				case 5u:
					break;
				default:
					return;
				case 4u:
					_202D_202C_200D_206D_200D_202B_206B_206C_202C_206B_206B_200F_206C_202B_202E_202E_206E_206E_200F_206D_202A_206F_202B_202C_202A_202D_200C_202B_202C_206D_202B_206F_202D_200E_202D_202C_202E_200B_200D_202E_202E(HeadImageObj.GetComponent<Image>(), Resource.GetHeadImage(menpai.Pic, forceLoadFromResource: false));
					num = -1188801346;
					continue;
				case 10u:
					_202A_202A_206F_206E_206B_202C_206A_202D_206F_202C_200B_202A_200F_202D_200B_206C_200F_202B_200D_206B_206E_202D_206A_202A_206E_200B_200E_202E_202B_200D_206B_202A_200F_200D_206B_202A_206A_202B_206E_206D_202E(MenpaiNameTextObj.GetComponent<Text>(), menpai.Name);
					_202A_202A_206F_206E_206B_202C_206A_202D_206F_202C_200B_202A_200F_202D_200B_206C_200F_202B_200D_206B_206E_202D_206A_202A_206E_200B_200E_202E_202B_200D_206B_202A_200F_200D_206B_202A_206A_202B_206E_206D_202E(MenpaiInfoTextObj.GetComponent<Text>(), _200C_206F_206D_200B_206B_206F_202C_206B_202E_200B_202E_200D_200F_200F_206C_200D_206F_200B_206D_206C_200D_202D_200F_200E_206E_202C_202D_200F_200F_202C_206F_200C_206C_202D_206D_200D_206F_200C_206F_202E(ResourceStrings.ResStrings[1148], new object[4] { menpai.shifu, menpai.wuxue, menpai.zhuxiu, menpai.tedian }));
					_202A_202A_206F_206E_206B_202C_206A_202D_206F_202C_200B_202A_200F_202D_200B_206C_200F_202B_200D_206B_206E_202D_206A_202A_206E_200B_200E_202E_202B_200D_206B_202A_200F_200D_206B_202A_206A_202B_206E_206D_202E(MenpaiDescTextObj.GetComponent<Text>(), menpai.info);
					_200D_202E_206A_200E_202B_202E_206A_202B_202D_200B_200E_202A_206A_202D_202E_206C_206C_206A_200C_206D_202E_202C_200F_206B_202D_206D_202E_202C_202B_200F_202E_206A_206B_202B_206E_202E_202D_200F_202E_202E(_206A_202A_200F_202D_206B_202B_206C_206A_206B_200F_200F_202B_206F_202B_202A_202D_206F_202E_200B_206B_206A_200B_206F_206B_206E_202A_202E_206B_200D_202D_202E_200E_200C_200F_200F_202A_200F_200E_202B_200C_202E((Component)(object)_206F_206E_206C_202E_206E_206A_202C_206F_200B_202E_200B_202A_200E_200B_206E_206F_200C_202E_206F_202B_200C_202B_202E_202D_202C_202C_206A_202E_206A_206B_202B_200E_200D_206A_206F_200E_200F_206C_200F_200C_202E(_206E_206F_206E_206D_202C_206C_206B_206F_202E_206F_206F_202A_200D_206E_202D_200B_202A_200E_206F_206C_206C_200E_202C_202E_206F_202D_200D_202C_202C_206C_202B_202C_206D_202A_200D_202B_206E_202C_206D_206F_202E((Component)(object)this), global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4133172483u))), true);
					num = (int)((num2 * 1811622988) ^ 0x1E3D5DC5);
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (RuntimeData.Instance.Team.Count > 0)
					{
						num5 = -1917161641;
						num6 = num5;
					}
					else
					{
						num5 = -59827163;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1637566194);
					continue;
				}
				case 6u:
				{
					menpai = Menpais[currentIndex];
					int num3;
					int num4;
					if (_202B_206C_202E_202D_200F_206B_206B_202C_200B_202E_200D_200E_206D_206A_202D_206F_202A_206F_200D_200B_206D_206A_200B_206C_200C_206D_206B_200E_200F_206D_200F_206B_200E_200F_200C_206E_202E_200D_206A_206C_202E(menpai.Pic))
					{
						num3 = -1147397400;
						num4 = num3;
					}
					else
					{
						num3 = -959972171;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1659379214);
					continue;
				}
				case 2u:
					num = ((int)num2 * -797637093) ^ 0x6E5B8D3F;
					continue;
				case 9u:
					num = ((int)num2 * -1014274730) ^ -270998956;
					continue;
				case 7u:
					_202D_202C_200D_206D_200D_202B_206B_206C_202C_206B_206B_200F_206C_202B_202E_202E_206E_206E_200F_206D_202A_206F_202B_202C_202A_202D_200C_202B_202C_206D_202B_206F_202D_200E_202D_202C_202E_200B_200D_202E_202E(BackgroundObj.GetComponent<Image>(), Resource.GetImage(menpai.Background, forceLoadFromResource: false));
					num = -2075912353;
					continue;
				case 0u:
					_202D_202C_200D_206D_200D_202B_206B_206C_202C_206B_206B_200F_206C_202B_202E_202E_206E_206E_200F_206D_202A_206F_202B_202C_202A_202D_200C_202B_202C_206D_202B_206F_202D_200E_202D_202C_202E_200B_200D_202E_202E(HeadImageObj.GetComponent<Image>(), (Sprite)null);
					num = -2001397310;
					continue;
				case 8u:
					_202D_202C_200D_206D_200D_202B_206B_206C_202C_206B_206B_200F_206C_202B_202E_202E_206E_206E_200F_206D_202A_206F_202B_202C_202A_202D_200C_202B_202C_206D_202B_206F_202D_200E_202D_202C_202E_200B_200D_202E_202E(HeadImageObj.GetComponent<Image>(), Resource.GetZhujueHead());
					num = (int)((num2 * 1678667417) ^ 0xE6C4712);
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private void Update()
	{
	}

	static Sprite _206C_206F_202E_206A_200E_202C_200B_202E_202C_200D_206C_200E_202D_206A_206A_206B_206F_202C_200D_202D_206F_200C_206B_200C_200F_206A_206C_206D_202C_200E_202C_202A_200B_202D_200F_206E_206A_206F_206C_206B_202E(Image P_0)
	{
		return P_0.sprite;
	}

	static Transform _206E_206F_206E_206D_202C_206C_206B_206F_202E_206F_206F_202A_200D_206E_202D_200B_202A_200E_206F_206C_206C_200E_202C_202E_206F_202D_200D_202C_202C_206C_202B_202C_206D_202A_200D_202B_206E_202C_206D_206F_202E(Component P_0)
	{
		return P_0.transform;
	}

	static Transform _206F_206E_206C_202E_206E_206A_202C_206F_200B_202E_200B_202A_200E_200B_206E_206F_200C_202E_206F_202B_200C_202B_202E_202D_202C_202C_206A_202E_206A_206B_202B_200E_200D_206A_206F_200E_200F_206C_200F_200C_202E(Transform P_0, string P_1)
	{
		return P_0.FindChild(P_1);
	}

	static GameObject _206A_202A_200F_202D_206B_202B_206C_206A_206B_200F_200F_202B_206F_202B_202A_202D_206F_202E_200B_206B_206A_200B_206F_206B_206E_202A_202E_206B_200D_202D_202E_200E_200C_200F_200F_202A_200F_200E_202B_200C_202E(Component P_0)
	{
		return P_0.gameObject;
	}

	static void _200D_202E_206A_200E_202B_202E_206A_202B_202D_200B_200E_202A_206A_202D_202E_206C_206C_206A_200C_206D_202E_202C_200F_206B_202D_206D_202E_202C_202B_200F_202E_206A_206B_202B_206E_202E_202D_200F_202E_202E(GameObject P_0, bool P_1)
	{
		P_0.SetActive(P_1);
	}

	static bool _202B_206C_202E_202D_200F_206B_206B_202C_200B_202E_200D_200E_206D_206A_202D_206F_202A_206F_200D_200B_206D_206A_200B_206C_200C_206D_206B_200E_200F_206D_200F_206B_200E_200F_200C_206E_202E_200D_206A_206C_202E(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}

	static void _202D_202C_200D_206D_200D_202B_206B_206C_202C_206B_206B_200F_206C_202B_202E_202E_206E_206E_200F_206D_202A_206F_202B_202C_202A_202D_200C_202B_202C_206D_202B_206F_202D_200E_202D_202C_202E_200B_200D_202E_202E(Image P_0, Sprite P_1)
	{
		P_0.sprite = P_1;
	}

	static void _202A_202A_206F_206E_206B_202C_206A_202D_206F_202C_200B_202A_200F_202D_200B_206C_200F_202B_200D_206B_206E_202D_206A_202A_206E_200B_200E_202E_202B_200D_206B_202A_200F_200D_206B_202A_206A_202B_206E_206D_202E(Text P_0, string P_1)
	{
		P_0.text = P_1;
	}

	static string _200C_206F_206D_200B_206B_206F_202C_206B_202E_200B_202E_200D_200F_200F_206C_200D_206F_200B_206D_206C_200D_202D_200F_200E_206E_202C_202D_200F_200F_202C_206F_200C_206C_202D_206D_200D_206F_200C_206F_202E(string P_0, object[] P_1)
	{
		return string.Format(P_0, P_1);
	}
}
