using JyGame;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MapRoleUI : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	public const int MAP_ROLE_TIMECOST = 2;

	public static MapRoleUI currentRoleUI;

	private Sprite _202B_200B_200C_202C_200E_202C_200E_206B_200F_200B_206F_200D_202E_202D_206A_206E_202C_200C_200E_206C_206F_200D_200F_202D_202A_202D_200E_202E_200B_206E_200D_200E_200D_202D_200F_202E_202D_206D_202B_200C_202E;

	private MapUI _202E_206C_202C_206B_200B_206A_206C_206D_202C_202B_202D_202D_200B_206D_206A_206F_202B_202C_202D_206D_206F_200D_200E_206F_202C_206A_200F_200C_200F_206A_200C_202B_206A_202E_200D_202D_206B_200C_206F_200D_202E;

	private MapEvent _206C_202B_200D_202C_206C_200E_202B_202D_206C_200C_202C_200C_200E_202A_206D_206F_206A_202B_206F_200B_206C_200F_206F_206F_202C_200D_206F_202A_206A_200B_206F_202D_206F_200F_202E_202E_202C_202A_206C_206D_202E;

	private MapRole _200D_202A_206F_206E_202B_202B_200D_206F_206A_200E_206C_200F_200C_206C_206F_202A_206C_202C_202D_200B_202D_202E_200B_206D_206A_200F_200B_200D_200B_202E_200E_206D_202B_206C_202B_206D_200F_200C_200F_200E_202E;

	private string desc;

	private string mapRoleName;

	public static int mapRoleCount;

	private GameObject ToolTipPanel => _200C_206B_206B_202D_202B_202C_206D_206B_206D_202A_200B_206C_200C_206F_202A_200C_200E_200D_202D_202D_206C_206B_202E_200C_202E_200F_206D_200F_202B_200F_206D_200B_200F_200B_206E_202B_206B_202A_200D_206F_202E((Component)(object)_202E_202E_200B_206C_206B_200C_206C_202E_200D_200B_202C_202B_206A_200E_202E_206F_206A_206C_202E_200D_202C_202A_206E_200B_206F_202D_206F_200C_206C_200E_206A_202A_202C_200D_206C_206C_206A_206C_202C_202B_202E(_200F_206B_202A_202D_200C_202E_206F_206B_202A_206B_206A_206A_206D_202B_200D_206B_200B_202D_202B_206A_206B_206E_206E_200E_202C_206B_206B_200F_202E_206A_202B_200F_200C_202A_202E_202C_202A_206B_200E_202E_202E((Component)(object)this), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(54285261u)));

	static MapRoleUI()
	{
	}

	public void OnMapRoleClicked()
	{
		if (_206C_202B_200D_202C_206C_200E_202B_202D_206C_200C_202C_200C_200E_202A_206D_206F_206A_202B_206F_200B_206C_200F_206F_206F_202C_200D_206F_202A_206A_200B_206F_202D_206F_200F_202E_202E_202C_202A_206C_206D_202E == null)
		{
			return;
		}
		while (true)
		{
			int num = -432623804;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1379240043)) % 10)
				{
				case 9u:
					break;
				default:
					return;
				case 6u:
					_202E_206C_202C_206B_200B_206A_206C_206D_202C_202B_202D_202D_200B_206D_206A_206F_202B_202C_202D_206D_206F_200D_200E_206F_202C_206A_200F_200C_200F_206A_200C_202B_206A_202E_200D_202D_206B_200C_206F_200D_202E.ShowEventConfirmPanel(_202B_200B_200C_202C_200E_202C_200E_206B_200F_200B_206F_200D_202E_202D_206A_206E_202C_200C_200E_206C_206F_200D_200F_202D_202A_202D_200E_202E_200B_206E_200D_200E_200D_202D_200F_202E_202D_206D_202B_200C_202E, _206C_202B_200D_202C_206C_200E_202B_202D_206C_200C_202C_200C_200E_202A_206D_206F_206A_202B_206F_200B_206C_200F_206F_206F_202C_200D_206F_202A_206A_200B_206F_202D_206F_200F_202E_202E_202C_202A_206C_206D_202E, mapRoleName, desc, 2);
					return;
				case 2u:
					MapLocationUI.currentLocationUI = null;
					num = (int)(num2 * 1963731362) ^ -1519821281;
					continue;
				case 8u:
					currentRoleUI = this;
					MapLocationUI.currentLocationUI = null;
					Execute();
					num = -94597350;
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (CommonSettings.TOUCH_MODE)
					{
						num5 = 1496381329;
						num6 = num5;
					}
					else
					{
						num5 = 1213214517;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 975899928);
					continue;
				}
				case 0u:
				{
					int num7;
					int num8;
					if (_200D_200F_202A_200F_202E_206F_202D_202C_200C_200C_202E_202C_200B_202B_200B_206C_200E_200E_200E_200F_202B_200B_206C_202C_206F_202E_206A_200E_206C_206D_200F_202E_200B_200E_206D_206F_200C_206F_206D_200C_202E((Object)(object)currentRoleUI, (Object)(object)this))
					{
						num7 = 238799861;
						num8 = num7;
					}
					else
					{
						num7 = 2076387502;
						num8 = num7;
					}
					num = num7 ^ (int)(num2 * 1016387645);
					continue;
				}
				case 7u:
				{
					int num3;
					int num4;
					if (_202E_206C_202C_206B_200B_206A_206C_206D_202C_202B_202D_202D_200B_206D_206A_206F_202B_202C_202D_206D_206F_200D_200E_206F_202C_206A_200F_200C_200F_206A_200C_202B_206A_202E_200D_202D_206B_200C_206F_200D_202E.Working())
					{
						num3 = -555599920;
						num4 = num3;
					}
					else
					{
						num3 = -1514003456;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 840588970);
					continue;
				}
				case 5u:
					Execute();
					return;
				case 4u:
					currentRoleUI = this;
					num = ((int)num2 * -1991446641) ^ 0x1267B0E1;
					continue;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	internal void Execute()
	{
		_202E_206C_202C_206B_200B_206A_206C_206D_202C_202B_202D_202D_200B_206D_206A_206F_202B_202C_202D_206D_206F_200D_200E_206F_202C_206A_200F_200C_200F_206A_200C_202B_206A_202E_200D_202D_206B_200C_206F_200D_202E.HideEventConfirmPanel();
		while (true)
		{
			int num = 255901829;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7652BC65)) % 5)
				{
				case 3u:
					break;
				default:
					return;
				case 2u:
					RuntimeData.Instance.Date = RuntimeData.Instance.Date.AddHours(2.0);
					RuntimeData.Instance.gameEngine.SwitchGameScene(_206C_202B_200D_202C_206C_200E_202B_202D_206C_200C_202C_200C_200E_202A_206D_206F_206A_202B_206F_200B_206C_200F_206F_206F_202C_200D_206F_202A_206A_200B_206F_202D_206F_200F_202E_202E_202C_202A_206C_206D_202E.type, _206C_202B_200D_202C_206C_200E_202B_202D_206C_200C_202C_200C_200E_202A_206D_206F_206A_202B_206F_200B_206C_200F_206F_206F_202C_200D_206F_202A_206A_200B_206F_202D_206F_200F_202E_202E_202C_202A_206C_206D_202E.value);
					num = ((int)num2 * -1416223987) ^ 0x523C43E6;
					continue;
				case 1u:
					MapLocationUI.currentLocationUI = null;
					num = (int)(num2 * 1673026365) ^ -919410888;
					continue;
				case 4u:
					currentRoleUI = null;
					num = ((int)num2 * -2023494752) ^ -1340661711;
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public void Bind(MapUI mapUI, MapRole role, int index, MapEvent evt)
	{
		//IL_0956: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a92: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c69: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		HideToolTip();
		_206C_202B_200D_202C_206C_200E_202B_202D_206C_200C_202C_200C_200E_202A_206D_206F_206A_202B_206F_200B_206C_200F_206F_206F_202C_200D_206F_202A_206A_200B_206F_202D_206F_200F_202E_202E_202C_202A_206C_206D_202E = evt;
		_200D_202A_206F_206E_202B_202B_200D_206F_206A_200E_206C_200F_200C_206C_206F_202A_206C_202C_202D_200B_202D_202E_200B_206D_206A_200F_200B_200D_200B_202E_200E_206D_202B_206C_202B_206D_200F_200C_200F_200E_202E = role;
		_202E_206C_202C_206B_200B_206A_206C_206D_202C_202B_202D_202D_200B_206D_206A_206F_202B_202C_202D_206D_206F_200D_200E_206F_202C_206A_200F_200C_200F_206A_200C_202B_206A_202E_200D_202D_206B_200C_206F_200D_202E = mapUI;
		mapRoleName = role.Name;
		Transform val = default(Transform);
		bool active = default(bool);
		string modThumbnailPath = default(string);
		Sprite sprite = default(Sprite);
		string text = default(string);
		Role role2 = default(Role);
		while (true)
		{
			int num = -1210494268;
			while (true)
			{
				uint num2;
				string text2;
				int num6;
				int num9;
				int num10;
				int num14;
				int num17;
				int num39;
				int num40;
				int num41;
				switch ((num2 = (uint)(num ^ -1793265679)) % 93)
				{
				case 45u:
					break;
				default:
					return;
				case 86u:
					text2 = string.Empty;
					goto IL_01c4;
				case 31u:
					((Component)this).transform.localPosition = new Vector3((float)(-458 + index * 160), 200f, 0f);
					num = ((int)num2 * -123142367) ^ -298907171;
					continue;
				case 12u:
				{
					int num35;
					if (!RuntimeData.Instance.hasTask())
					{
						num = -414314565;
						num35 = num;
					}
					else
					{
						num = -2103714603;
						num35 = num;
					}
					continue;
				}
				case 68u:
					val.localScale = new Vector3(1f, 1f);
					num = ((int)num2 * -1145665559) ^ -145458947;
					continue;
				case 75u:
					num = ((int)num2 * -1772008272) ^ -1338963369;
					continue;
				case 10u:
					((Component)this).transform.localPosition = new Vector3((float)(-298 + index * 200), 200f, 0f);
					num = (int)((num2 * 382121813) ^ 0x2E94FE51);
					continue;
				case 35u:
					((Component)this).transform.localPosition = new Vector3((float)(-298 + (index - 5) * 200), 20f, 0f);
					num = -1818027818;
					continue;
				case 59u:
					((Component)((Component)this).transform.FindChild(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1120299142u))).gameObject.SetActive(false);
					num = (int)(num2 * 2143855395) ^ -1171478013;
					continue;
				case 37u:
				{
					int num7;
					if (index < 4)
					{
						num = -941175314;
						num7 = num;
					}
					else
					{
						num = -2063666217;
						num7 = num;
					}
					continue;
				}
				case 44u:
					goto IL_0331;
				case 54u:
					desc = _206C_202B_200D_202C_206C_200E_202B_202D_206C_200C_202C_200C_200E_202A_206D_206F_206A_202B_206F_200B_206C_200F_206F_206F_202C_200D_206F_202A_206A_200B_206F_202D_206F_200F_202E_202E_202C_202A_206C_206D_202E.description;
					num = (int)(num2 * 118215027) ^ -15304820;
					continue;
				case 41u:
					((Component)((Component)this).transform.FindChild(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3893901830u))).gameObject.SetActive(active);
					num = -686410797;
					continue;
				case 25u:
				{
					_202B_200B_200C_202C_200E_202C_200E_206B_200F_200B_206F_200D_202E_202D_206A_206E_202C_200C_200E_206C_206F_200D_200F_202D_202A_202D_200E_202E_200B_206E_200D_200E_200D_202D_200F_202E_202D_206D_202B_200C_202E = Resource.GetModThumbnailImage(modThumbnailPath);
					int num30;
					int num31;
					if (_200F_202B_206B_206A_206E_206F_202C_202D_206E_202D_202E_206A_202C_202A_206B_206F_200D_200F_202A_202B_202B_206F_206D_202B_202A_200D_200F_200B_202A_206B_206F_202D_202E_202A_202C_200F_202C_200C_206F_202B_202E((Object)(object)_202B_200B_200C_202C_200E_202C_200E_206B_200F_200B_206F_200D_202E_202D_206A_206E_202C_200C_200E_206C_206F_200D_200F_202D_202A_202D_200E_202E_200B_206E_200D_200E_200D_202D_200F_202E_202D_206D_202B_200C_202E, (Object)null))
					{
						num30 = -2087790261;
						num31 = num30;
					}
					else
					{
						num30 = -2140413604;
						num31 = num30;
					}
					num = num30 ^ (int)(num2 * 2033799933);
					continue;
				}
				case 32u:
					_202B_200B_200C_202C_200E_202C_200E_206B_200F_200B_206F_200D_202E_202D_206A_206E_202C_200C_200E_206C_206F_200D_200F_202D_202A_202D_200E_202E_200B_206E_200D_200E_200D_202D_200F_202E_202D_206D_202B_200C_202E = sprite;
					num = (int)(num2 * 599144732) ^ -1291723607;
					continue;
				case 50u:
				{
					int num18;
					int num19;
					if (index >= 17)
					{
						num18 = 1274248682;
						num19 = num18;
					}
					else
					{
						num18 = 488257435;
						num19 = num18;
					}
					num = num18 ^ (int)(num2 * 936989006);
					continue;
				}
				case 33u:
				{
					int num12;
					if (_200E_206A_206D_202E_202E_200E_200E_202E_200F_206D_202C_206B_206E_206B_200C_206E_206B_200C_206D_200B_202C_206A_202C_202D_200D_206F_202B_200C_200D_206E_202A_206D_202B_200B_200C_202C_200F_202D_202D_206C_202E(text))
					{
						num = -1324369135;
						num12 = num;
					}
					else
					{
						num = -772665336;
						num12 = num;
					}
					continue;
				}
				case 84u:
				{
					int num4;
					int num5;
					if (_206E_202D_202E_200D_202E_202A_202A_206C_202B_206E_206B_202E_202B_200F_200E_200B_200C_206B_202C_202D_200F_200F_202D_206A_202B_200D_202D_206D_200D_206A_202A_200D_206E_202D_200C_200B_202E_202A_200D_200F_202E(role.pic, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1245277517u)))
					{
						num4 = -357475984;
						num5 = num4;
					}
					else
					{
						num4 = -1481348268;
						num5 = num4;
					}
					num = num4 ^ (int)(num2 * 176400953);
					continue;
				}
				case 92u:
					text = role2.Head;
					num = ((int)num2 * -83882508) ^ -647328452;
					continue;
				case 82u:
					sprite = null;
					num = ((int)num2 * -394217607) ^ 0x3FEF79FC;
					continue;
				case 87u:
					((Component)this).transform.localPosition = new Vector3((float)(-298 + (index - 4) * 200), 20f, 0f);
					num = -1801322007;
					continue;
				case 73u:
					active = true;
					num = (int)(num2 * 1492562741) ^ -113520971;
					continue;
				case 27u:
				{
					int num38;
					if (index >= 8)
					{
						num = -1133757141;
						num38 = num;
					}
					else
					{
						num = -1475197562;
						num38 = num;
					}
					continue;
				}
				case 53u:
				{
					int num34;
					if (RuntimeData.Instance.isLocationInTask(role.Name))
					{
						num = -300394145;
						num34 = num;
					}
					else
					{
						num = -1656848198;
						num34 = num;
					}
					continue;
				}
				case 21u:
				{
					int num29;
					if (role2 != null)
					{
						num = -163111770;
						num29 = num;
					}
					else
					{
						num = -537022224;
						num29 = num;
					}
					continue;
				}
				case 58u:
				{
					active = false;
					int num25;
					int num26;
					if (_206C_202B_200D_202C_206C_200E_202B_202D_206C_200C_202C_200C_200E_202A_206D_206F_206A_202B_206F_200B_206C_200F_206F_206F_202C_200D_206F_202A_206A_200B_206F_202D_206F_200F_202E_202E_202C_202A_206C_206D_202E != null)
					{
						num25 = -659468978;
						num26 = num25;
					}
					else
					{
						num25 = -699358486;
						num26 = num25;
					}
					num = num25 ^ (int)(num2 * 1086192516);
					continue;
				}
				case 6u:
					((Component)this).transform.localPosition = new Vector3((float)(-298 + index * 200), 200f, 0f);
					num = ((int)num2 * -101298227) ^ 0x509207C7;
					continue;
				case 14u:
					text = string.Empty;
					num = ((int)num2 * -285890252) ^ -2053084864;
					continue;
				case 0u:
					switch (mapRoleCount)
					{
					case 8:
						break;
					case 6:
						goto IL_0331;
					default:
						goto IL_0623;
					case 7:
						goto IL_0681;
					case 14:
						goto IL_082d;
					case 12:
					case 13:
						goto IL_098a;
					case 9:
						goto IL_0a3a;
					case 24:
					case 25:
					case 26:
						goto IL_0d3e;
					case 15:
					case 16:
						goto IL_0d66;
					case 10:
					case 11:
						goto IL_0db4;
					case 17:
					case 18:
					case 19:
					case 20:
					case 21:
					case 22:
					case 23:
						goto IL_0ddf;
					}
					goto case 37u;
				case 71u:
				{
					int num36;
					int num37;
					if (role2 != null)
					{
						num36 = -1620139828;
						num37 = num36;
					}
					else
					{
						num36 = -1049375478;
						num37 = num36;
					}
					num = num36 ^ ((int)num2 * -1390920148);
					continue;
				}
				case 72u:
					((Component)((Component)this).transform.FindChild(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4115681001u))).gameObject.SetActive(true);
					num = (int)(num2 * 302571256) ^ -478286013;
					continue;
				case 79u:
					goto IL_0681;
				case 23u:
					desc = role.description;
					num = (int)(num2 * 132733491) ^ -1374494725;
					continue;
				case 91u:
				{
					int num32;
					int num33;
					if (!_200D_200F_202A_200F_202E_206F_202D_202C_200C_200C_202E_202C_200B_202B_200B_206C_200E_200E_200E_200F_202B_200B_206C_202C_206F_202E_206A_200E_206C_206D_200F_202E_200B_200E_206D_206F_200C_206F_206D_200C_202E((Object)(object)val, (Object)null))
					{
						num32 = -1129578158;
						num33 = num32;
					}
					else
					{
						num32 = -428718624;
						num33 = num32;
					}
					num = num32 ^ ((int)num2 * -1065740470);
					continue;
				}
				case 39u:
					num = (int)((num2 * 2021931984) ^ 0xA296A67);
					continue;
				case 65u:
					num = ((int)num2 * -138878528) ^ -1483244802;
					continue;
				case 40u:
					text = _206C_202B_200D_202C_206C_200E_202B_202D_206C_200C_202C_200C_200E_202A_206D_206F_206A_202B_206F_200B_206C_200F_206F_206F_202C_200D_206F_202A_206A_200B_206F_202D_206F_200F_202E_202E_202C_202A_206C_206D_202E.image;
					num = (int)((num2 * 55364884) ^ 0x623F759F);
					continue;
				case 69u:
					_200F_200C_202B_206E_202B_202E_200C_200E_202B_200D_202B_202B_202B_202A_200E_202C_206A_200E_202D_206F_202A_202B_202E_202A_206B_202B_200B_202C_202E_200B_202A_206F_202B_200C_206B_200B_200F_202A_202C_206E_202E(((Component)val).GetComponent<Image>(), _202B_200B_200C_202C_200E_202C_200E_206B_200F_200B_206F_200D_202E_202D_206A_206E_202C_200C_200E_206C_206F_200D_200F_202D_202A_202D_200E_202E_200B_206E_200D_200E_200D_202D_200F_202E_202D_206D_202B_200C_202E);
					num = (int)((num2 * 879842331) ^ 0x53DE3DB5);
					continue;
				case 67u:
					((Component)this).transform.localPosition = new Vector3((float)(-504 + index * 144), 200f, 0f);
					num = ((int)num2 * -807139202) ^ 0x3335E902;
					continue;
				case 70u:
					((Component)this).transform.localPosition = new Vector3((float)(-458 + (index - 7) * 160), 20f, 0f);
					num = -958836781;
					continue;
				case 47u:
					((Component)this).transform.localPosition = new Vector3((float)(-504 + (index - 7) * 144), 145f, 0f);
					num = (int)(num2 * 295094441) ^ -1386189722;
					continue;
				case 26u:
					val = _202E_202E_200B_206C_206B_200C_206C_202E_200D_200B_202C_202B_206A_200E_202E_206F_206A_206C_202E_200D_202C_202A_206E_200B_206F_202D_206F_200C_206C_200E_206A_202A_202C_200D_206C_206C_206A_206C_202C_202B_202E(_200F_206B_202A_202D_200C_202E_206F_206B_202A_206B_206A_206A_206D_202B_200D_206B_200B_202D_202B_206A_206B_206E_206E_200E_202C_206B_206B_200F_202E_206A_202B_200F_200C_202A_202E_202C_202A_206B_200E_202E_202E((Component)(object)this), global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2480512056u));
					num = -1972702520;
					continue;
				case 36u:
					goto IL_082d;
				case 17u:
					num = (int)(num2 * 502262714) ^ -138811829;
					continue;
				case 7u:
					((Component)this).transform.localPosition = new Vector3((float)(-298 + index * 200), 200f, 0f);
					num = (int)(num2 * 224022629) ^ -399617348;
					continue;
				case 55u:
					((Component)this).transform.localPosition = new Vector3((float)(-298 + index * 160), 200f, 0f);
					num = (int)((num2 * 603865461) ^ 0x4D6D29CD);
					continue;
				case 85u:
					num = (int)(num2 * 68201770) ^ -1688362299;
					continue;
				case 38u:
				{
					int num27;
					int num28;
					if (_200E_206A_206D_202E_202E_200E_200E_202E_200F_206D_202C_206B_206E_206B_200C_206E_206B_200C_206D_200B_202C_206A_202C_202D_200D_206F_202B_200C_200D_206E_202A_206D_202B_200B_200C_202C_200F_202D_202D_206C_202E(_206C_202B_200D_202C_206C_200E_202B_202D_206C_200C_202C_200C_200E_202A_206D_206F_206A_202B_206F_200B_206C_200F_206F_206F_202C_200D_206F_202A_206A_200B_206F_202D_206F_200F_202E_202E_202C_202A_206C_206D_202E.description))
					{
						num27 = 632820368;
						num28 = num27;
					}
					else
					{
						num27 = 1405275871;
						num28 = num27;
					}
					num = num27 ^ ((int)num2 * -1214458685);
					continue;
				}
				case 64u:
				{
					int num23;
					int num24;
					if (_200E_206A_206D_202E_202E_200E_200E_202E_200F_206D_202C_206B_206E_206B_200C_206E_206B_200C_206D_200B_202C_206A_202C_202D_200D_206F_202B_200C_200D_206E_202A_206D_202B_200B_200C_202C_200F_202D_202D_206C_202E(modThumbnailPath))
					{
						num23 = 1073830760;
						num24 = num23;
					}
					else
					{
						num23 = 1514361780;
						num24 = num23;
					}
					num = num23 ^ (int)(num2 * 24248483);
					continue;
				}
				case 1u:
					((Component)this).transform.localPosition = new Vector3((float)(-458 + (index - 6) * 160), 20f, 0f);
					num = -119229268;
					continue;
				case 62u:
					_202B_200B_200C_202C_200E_202C_200E_206B_200F_200B_206F_200D_202E_202D_206A_206E_202C_200C_200E_206C_206F_200D_200F_202D_202A_202D_200E_202E_200B_206E_200D_200E_200D_202D_200F_202E_202D_206D_202B_200C_202E = Resource.GetImage(text, forceLoadFromResource: false);
					num = ((int)num2 * -945894228) ^ 0x5CE5D428;
					continue;
				case 24u:
					goto IL_098a;
				case 60u:
					num = (int)(num2 * 940805542) ^ -321919861;
					continue;
				case 18u:
					((Component)((Component)this).transform.FindChild(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(410466760u))).GetComponent<Text>().text = mapRoleName;
					num = -1633883726;
					continue;
				case 46u:
				{
					int num21;
					int num22;
					if (!_200E_206A_206D_202E_202E_200E_200E_202E_200F_206D_202C_206B_206E_206B_200C_206E_206B_200C_206D_200B_202C_206A_202C_202D_200D_206F_202B_200C_200D_206E_202A_206D_202B_200B_200C_202C_200F_202D_202D_206C_202E(role2.Head))
					{
						num21 = -1722152246;
						num22 = num21;
					}
					else
					{
						num21 = -562951718;
						num22 = num21;
					}
					num = num21 ^ (int)(num2 * 1043795942);
					continue;
				}
				case 9u:
				{
					int num20;
					if (_202C_200B_202E_206A_200D_206B_202D_202B_206F_200B_206E_202A_206F_200D_202A_206D_202A_202E_202D_200F_200D_206D_206A_200E_206C_202D_202C_202D_202E_206D_206D_206D_206B_202A_202B_206B_206A_206B_202E_206E_202E(text, ResourceStrings.ResStrings[1105]))
					{
						num = -1892162729;
						num20 = num;
					}
					else
					{
						num = -2016905387;
						num20 = num;
					}
					continue;
				}
				case 52u:
					goto IL_0a3a;
				case 48u:
				{
					int num15;
					int num16;
					if (index < 15)
					{
						num15 = 1873223807;
						num16 = num15;
					}
					else
					{
						num15 = 1452576726;
						num16 = num15;
					}
					num = num15 ^ ((int)num2 * -2102845823);
					continue;
				}
				case 49u:
					((Component)this).transform.localPosition = new Vector3((float)(-360 + index * 144), 280f, 0f);
					num = ((int)num2 * -1036113507) ^ -527014056;
					continue;
				case 66u:
					role2 = ResourceManager.Get<Role>(role.roleKey);
					num = ((int)num2 * -1047536494) ^ -2050642054;
					continue;
				case 80u:
				{
					int num13;
					if (!_200E_206A_206D_202E_202E_200E_200E_202E_200F_206D_202C_206B_206E_206B_200C_206E_206B_200C_206D_200B_202C_206A_202C_202D_200D_206F_202B_200C_200D_206E_202A_206D_202B_200B_200C_202C_200F_202D_202D_206C_202E(_206C_202B_200D_202C_206C_200E_202B_202D_206C_200C_202C_200C_200E_202A_206D_206F_206A_202B_206F_200B_206C_200F_206F_206F_202C_200D_206F_202A_206A_200B_206F_202D_206F_200F_202E_202E_202C_202A_206C_206D_202E.image))
					{
						num = -1185355953;
						num13 = num;
					}
					else
					{
						num = -1601724089;
						num13 = num;
					}
					continue;
				}
				case 29u:
					((Component)this).transform.localPosition = new Vector3((float)(-376 + index * 128), 280f, 0f);
					num = (int)((num2 * 1895428403) ^ 0x760F19D);
					continue;
				case 76u:
					((Component)this).transform.localPosition = new Vector3((float)(-504 + (index - 8) * 144), 20f, 0f);
					num = -1912194254;
					continue;
				case 42u:
				{
					int num11;
					if (_206C_202B_200D_202C_206C_200E_202B_202D_206C_200C_202C_200C_200E_202A_206D_206F_206A_202B_206F_200B_206C_200F_206F_206F_202C_200D_206F_202A_206A_200B_206F_202D_206F_200F_202E_202E_202C_202A_206C_206D_202E.IsRepeatOnce)
					{
						num = -838856242;
						num11 = num;
					}
					else
					{
						num = -496271682;
						num11 = num;
					}
					continue;
				}
				case 28u:
					modThumbnailPath = Resource.GetModThumbnailPath(text, ref sprite);
					num = ((int)num2 * -414338684) ^ 0x5661131E;
					continue;
				case 63u:
					_202B_200B_200C_202C_200E_202C_200E_206B_200F_200B_206F_200D_202E_202D_206A_206E_202C_200C_200E_206C_206F_200D_200F_202D_202A_202D_200E_202E_200B_206E_200D_200E_200D_202D_200F_202E_202D_206D_202B_200C_202E = Resource.GetImage(text, forceLoadFromResource: false);
					num = -1374633696;
					continue;
				case 3u:
				{
					int num8;
					if (!_200D_200F_202A_200F_202E_206F_202D_202C_200C_200C_202E_202C_200B_202B_200B_206C_200E_200E_200E_200F_202B_200B_206C_202C_206F_202E_206A_200E_206C_206D_200F_202E_200B_200E_206D_206F_200C_206F_206D_200C_202E((Object)(object)sprite, (Object)null))
					{
						num = -1702883991;
						num8 = num;
					}
					else
					{
						num = -1089416337;
						num8 = num;
					}
					continue;
				}
				case 5u:
					num = (int)(num2 * 490355630) ^ -562703397;
					continue;
				case 22u:
					num = (int)(num2 * 717203841) ^ -423721531;
					continue;
				case 30u:
					num = ((int)num2 * -1609630667) ^ -987259265;
					continue;
				case 81u:
					num = ((int)num2 * -1563735976) ^ 0x494F6D97;
					continue;
				case 19u:
					num = ((int)num2 * -1517755104) ^ -1957399577;
					continue;
				case 43u:
					num = (int)(num2 * 1566235611) ^ -872083029;
					continue;
				case 56u:
					((Component)this).transform.localPosition = new Vector3((float)(-498 + (index - 5) * 200), 20f, 0f);
					num = -926332941;
					continue;
				case 15u:
					_202B_200B_200C_202C_200E_202C_200E_206B_200F_200B_206F_200D_202E_202D_206A_206E_202C_200C_200E_206C_206F_200D_200F_202D_202A_202D_200E_202E_200B_206E_200D_200E_200D_202D_200F_202E_202D_206D_202B_200C_202E = Resource.GetImage(text, forceLoadFromResource: false);
					num = -1374633696;
					continue;
				case 4u:
					((Component)this).transform.localPosition = new Vector3((float)(-504 + (index - 8) * 128), 145f, 0f);
					num = ((int)num2 * -1582216368) ^ -1794392681;
					continue;
				case 78u:
					((Component)this).transform.localPosition = new Vector3((float)(-504 + (index - 15) * 144), 10f, 0f);
					num = -1861127033;
					continue;
				case 89u:
					num = (int)((num2 * 1874802439) ^ 0x12F41A74);
					continue;
				case 2u:
					role2 = RuntimeData.Instance.GetTeamRole(role.roleKey);
					num = ((int)num2 * -280351050) ^ -1294213079;
					continue;
				case 83u:
					goto IL_0d3e;
				case 8u:
					text = string.Empty;
					num = -772665336;
					continue;
				case 51u:
					goto IL_0d66;
				case 88u:
					if (!_200E_206A_206D_202E_202E_200E_200E_202E_200F_206D_202C_206B_206E_206B_200C_206E_206B_200C_206D_200B_202C_206A_202C_202D_200D_206F_202B_200C_200D_206E_202A_206D_202B_200B_200C_202C_200F_202D_202D_206C_202E(role.pic))
					{
						text2 = role.pic;
						goto IL_01c4;
					}
					num = (int)(num2 * 615361661) ^ -1466014175;
					continue;
				case 16u:
					num = ((int)num2 * -21340207) ^ -454043200;
					continue;
				case 77u:
					goto IL_0db4;
				case 57u:
					num = (int)((num2 * 270267861) ^ 0x158A1D65);
					continue;
				case 13u:
					goto IL_0ddf;
				case 90u:
					num = (int)((num2 * 143927321) ^ 0x7FE64D3D);
					continue;
				case 34u:
					((Component)this).transform.localPosition = new Vector3((float)(-504 + (index - 17) * 128), 10f, 0f);
					num = -834390426;
					continue;
				case 11u:
					((Component)this).transform.localPosition = new Vector3((float)(-398 + index * 200), 90f, 0f);
					num = -1861127033;
					continue;
				case 61u:
					num = ((int)num2 * -68453812) ^ 0x689AB5E0;
					continue;
				case 74u:
				{
					int num3;
					if (index < 7)
					{
						num = -1818060511;
						num3 = num;
					}
					else
					{
						num = -1727363450;
						num3 = num;
					}
					continue;
				}
				case 20u:
					return;
					IL_0d3e:
					if (index < 8)
					{
						num = -1954251777;
						num6 = num;
					}
					else
					{
						num = -900794506;
						num6 = num;
					}
					continue;
					IL_01c4:
					text = text2;
					if (!_200E_206A_206D_202E_202E_200E_200E_202E_200F_206D_202C_206B_206E_206B_200C_206E_206B_200C_206D_200B_202C_206A_202C_202D_200D_206F_202B_200C_200D_206E_202A_206D_202B_200B_200C_202C_200F_202D_202D_206C_202E(text))
					{
						num = -772665336;
						num9 = num;
					}
					else
					{
						num = -1373575789;
						num9 = num;
					}
					continue;
					IL_0a3a:
					if (index < 5)
					{
						num = -63869007;
						num10 = num;
					}
					else
					{
						num = -2071505015;
						num10 = num;
					}
					continue;
					IL_0331:
					((Component)this).transform.localPosition = new Vector3((float)(-398 + index * 180), 90f, 0f);
					num = -1035704661;
					continue;
					IL_098a:
					if (index >= 6)
					{
						num = -510332675;
						num14 = num;
					}
					else
					{
						num = -885445869;
						num14 = num;
					}
					continue;
					IL_082d:
					if (index < 7)
					{
						num = -1205663335;
						num17 = num;
					}
					else
					{
						num = -1037571831;
						num17 = num;
					}
					continue;
					IL_0681:
					((Component)this).transform.localPosition = new Vector3((float)(-458 + index * 160), 90f, 0f);
					num = -1666854477;
					continue;
					IL_0623:
					num = -1139127039;
					continue;
					IL_0ddf:
					if (index >= 7)
					{
						num = -1928498;
						num39 = num;
					}
					else
					{
						num = -669317286;
						num39 = num;
					}
					continue;
					IL_0db4:
					if (index >= 5)
					{
						num = -1035716742;
						num40 = num;
					}
					else
					{
						num = -820162889;
						num40 = num;
					}
					continue;
					IL_0d66:
					if (index < 8)
					{
						num = -205522836;
						num41 = num;
					}
					else
					{
						num = -739579380;
						num41 = num;
					}
					continue;
				}
				break;
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
			int num = 785062866;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7C4DF236)) % 3)
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
				num = (int)((num2 * 1169550470) ^ 0x68A2CC23);
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
			int num = -209681026;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -370401853)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_0029;
				case 2u:
					return;
				}
				break;
				IL_0029:
				HideToolTip();
				num = (int)(num2 * 1541940838) ^ -560043616;
			}
		}
	}

	private void ShowToolTip()
	{
		_206A_206E_200D_202C_202A_206A_202B_200F_200B_206D_202C_200C_200C_206D_206A_202B_206C_200D_200D_200F_206D_200D_202E_206E_206F_206D_206F_202E_206D_202E_206D_200D_200C_200D_206E_200E_206F_200F_202B_202E(ToolTipPanel, true);
		_200F_202B_202C_200E_200C_206F_202C_200B_202E_206E_202A_202D_200B_206D_202E_200E_200D_206B_200C_200F_200F_206D_200F_200D_206D_200B_200F_200E_200C_202E_200D_202C_206B_202A_202B_200D_200F_202D_202A_200C_202E(((Component)_202E_202E_200B_206C_206B_200C_206C_202E_200D_200B_202C_202B_206A_200E_202E_206F_206A_206C_202E_200D_202C_202A_206E_200B_206F_202D_206F_200C_206C_200E_206A_202A_202C_200D_206C_206C_206A_206C_202C_202B_202E(_200C_200C_202A_200F_206B_206C_200C_206C_200F_202E_202E_206F_202A_206E_202E_206B_202C_200B_202A_202C_206E_200C_206F_200B_202C_202B_206F_200D_206C_206F_206B_200E_200D_200B_206F_206E_202A_206E_202E_200D_202E(ToolTipPanel), global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2905757779u))).GetComponent<Text>(), desc);
	}

	private void HideToolTip()
	{
		_206A_206E_200D_202C_202A_206A_202B_200F_200B_206D_202C_200C_200C_206D_206A_202B_206C_200D_200D_200F_206D_200D_202E_206E_206F_206D_206F_202E_206D_202E_206D_200D_200C_200D_206E_200E_206F_200F_202B_202E(ToolTipPanel, false);
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Bind2(MapUI mapUI, MapRole role, int index, MapEvent evt)
	{
		//IL_0e68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0936: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_0986: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0823: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		HideToolTip();
		string modThumbnailPath = default(string);
		Transform val = default(Transform);
		Sprite sprite = default(Sprite);
		string text = default(string);
		bool active = default(bool);
		Role role2 = default(Role);
		while (true)
		{
			int num = 1080694494;
			while (true)
			{
				uint num2;
				string text2;
				int num10;
				int num17;
				int num36;
				int num40;
				int num41;
				int num42;
				int num43;
				int num44;
				switch ((num2 = (uint)(num ^ 0x388A4993)) % 102)
				{
				case 48u:
					break;
				default:
					return;
				case 16u:
				{
					int num39;
					if (index < 7)
					{
						num = 1694206819;
						num39 = num;
					}
					else
					{
						num = 29419932;
						num39 = num;
					}
					continue;
				}
				case 15u:
				{
					int num29;
					int num30;
					if (_200E_206A_206D_202E_202E_200E_200E_202E_200F_206D_202C_206B_206E_206B_200C_206E_206B_200C_206D_200B_202C_206A_202C_202D_200D_206F_202B_200C_200D_206E_202A_206D_202B_200B_200C_202C_200F_202D_202D_206C_202E(modThumbnailPath))
					{
						num29 = -2094280679;
						num30 = num29;
					}
					else
					{
						num29 = -2011145632;
						num30 = num29;
					}
					num = num29 ^ ((int)num2 * -1023624870);
					continue;
				}
				case 38u:
					((Component)this).transform.localPosition = new Vector3((float)(-568 + (index - 19) * 128), 10f, 0f);
					num = 480282882;
					continue;
				case 40u:
				{
					int num31;
					int num32;
					if (_200D_200F_202A_200F_202E_206F_202D_202C_200C_200C_202E_202C_200B_202B_200B_206C_200E_200E_200E_200F_202B_200B_206C_202C_206F_202E_206A_200E_206C_206D_200F_202E_200B_200E_206D_206F_200C_206F_206D_200C_202E((Object)(object)val, (Object)null))
					{
						num31 = -634620502;
						num32 = num31;
					}
					else
					{
						num31 = -504072095;
						num32 = num31;
					}
					num = num31 ^ (int)(num2 * 927356335);
					continue;
				}
				case 14u:
					((Component)this).transform.localPosition = new Vector3((float)(-346 + index * 174), 200f, 0f);
					num = (int)((num2 * 1228932659) ^ 0xA744224);
					continue;
				case 66u:
					((Component)this).transform.localPosition = new Vector3((float)(-520 + (index - 6) * 174), 20f, 0f);
					num = 1152682992;
					continue;
				case 61u:
					desc = _206C_202B_200D_202C_206C_200E_202B_202D_206C_200C_202C_200C_200E_202A_206D_206F_206A_202B_206F_200B_206C_200F_206F_206F_202C_200D_206F_202A_206A_200B_206F_202D_206F_200F_202E_202E_202C_202A_206C_206D_202E.description;
					num = (int)(num2 * 162543472) ^ -1518327281;
					continue;
				case 96u:
				{
					int num38;
					if (index < 7)
					{
						num = 918770398;
						num38 = num;
					}
					else
					{
						num = 1735965964;
						num38 = num;
					}
					continue;
				}
				case 75u:
					_202B_200B_200C_202C_200E_202C_200E_206B_200F_200B_206F_200D_202E_202D_206A_206E_202C_200C_200E_206C_206F_200D_200F_202D_202A_202D_200E_202E_200B_206E_200D_200E_200D_202D_200F_202E_202D_206D_202B_200C_202E = sprite;
					num = ((int)num2 * -2001802509) ^ -158306722;
					continue;
				case 101u:
					((Component)this).transform.localPosition = new Vector3((float)(-552 + (index - 8) * 160), 20f, 0f);
					num = 1911928844;
					continue;
				case 46u:
				{
					int num20;
					if (!_200E_206A_206D_202E_202E_200E_200E_202E_200F_206D_202C_206B_206E_206B_200C_206E_206B_200C_206D_200B_202C_206A_202C_202D_200D_206F_202B_200C_200D_206E_202A_206D_202B_200B_200C_202C_200F_202D_202D_206C_202E(text))
					{
						num = 574371124;
						num20 = num;
					}
					else
					{
						num = 446240293;
						num20 = num;
					}
					continue;
				}
				case 74u:
				{
					int num14;
					if (_200E_206A_206D_202E_202E_200E_200E_202E_200F_206D_202C_206B_206E_206B_200C_206E_206B_200C_206D_200B_202C_206A_202C_202D_200D_206F_202B_200C_200D_206E_202A_206D_202B_200B_200C_202C_200F_202D_202D_206C_202E(_206C_202B_200D_202C_206C_200E_202B_202D_206C_200C_202C_200C_200E_202A_206D_206F_206A_202B_206F_200B_206C_200F_206F_206F_202C_200D_206F_202A_206A_200B_206F_202D_206F_200F_202E_202E_202C_202A_206C_206D_202E.image))
					{
						num = 1891136674;
						num14 = num;
					}
					else
					{
						num = 899241164;
						num14 = num;
					}
					continue;
				}
				case 58u:
					num = (int)((num2 * 416702473) ^ 0x2DC6960C);
					continue;
				case 65u:
					num = ((int)num2 * -2047452970) ^ -1730147870;
					continue;
				case 6u:
					num = ((int)num2 * -2145805059) ^ -1663963254;
					continue;
				case 35u:
					num = (int)(num2 * 50610052) ^ -676458148;
					continue;
				case 36u:
					((Component)((Component)this).transform.FindChild(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3270098211u))).gameObject.SetActive(true);
					num = (int)(num2 * 1692125335) ^ -167996446;
					continue;
				case 81u:
					((Component)this).transform.localPosition = new Vector3((float)(-298 + index * 200), 200f, 0f);
					num = ((int)num2 * -838731571) ^ -884149379;
					continue;
				case 78u:
					((Component)this).transform.localPosition = new Vector3((float)(-520 + index * 174), 200f, 0f);
					num = (int)(num2 * 48427211) ^ -677385696;
					continue;
				case 27u:
					active = false;
					num = ((int)num2 * -211907872) ^ 0x18DCC242;
					continue;
				case 52u:
					((Component)this).transform.localPosition = new Vector3((float)(-398 + index * 200), 90f, 0f);
					num = 1152682992;
					continue;
				case 60u:
					goto IL_04ca;
				case 22u:
					val = _202E_202E_200B_206C_206B_200C_206C_202E_200D_200B_202C_202B_206A_200E_202E_206F_206A_206C_202E_200D_202C_202A_206E_200B_206F_202D_206F_200C_206C_200E_206A_202A_202C_200D_206C_206C_206A_206C_202C_202B_202E(_200F_206B_202A_202D_200C_202E_206F_206B_202A_206B_206A_206A_206D_202B_200D_206B_200B_202D_202B_206A_206B_206E_206E_200E_202C_206B_206B_200F_202E_206A_202B_200F_200C_202A_202E_202C_202A_206B_200E_202E_202E((Component)(object)this), global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3506571602u));
					num = 1200135081;
					continue;
				case 64u:
					num = (int)((num2 * 1879560879) ^ 0x4A7506F1);
					continue;
				case 80u:
					_202B_200B_200C_202C_200E_202C_200E_206B_200F_200B_206F_200D_202E_202D_206A_206E_202C_200C_200E_206C_206F_200D_200F_202D_202A_202D_200E_202E_200B_206E_200D_200E_200D_202D_200F_202E_202D_206D_202B_200C_202E = Resource.GetImage(text, forceLoadFromResource: false);
					num = 2025844059;
					continue;
				case 5u:
					goto IL_052c;
				case 31u:
				{
					int num34;
					if (role2 == null)
					{
						num = 868972867;
						num34 = num;
					}
					else
					{
						num = 351220847;
						num34 = num;
					}
					continue;
				}
				case 43u:
					((Component)this).transform.localPosition = new Vector3((float)(-298 + index * 200), 200f, 0f);
					num = (int)((num2 * 2095221737) ^ 0xD818255);
					continue;
				case 79u:
				{
					int num26;
					if (!_206C_202B_200D_202C_206C_200E_202B_202D_206C_200C_202C_200C_200E_202A_206D_206F_206A_202B_206F_200B_206C_200F_206F_206F_202C_200D_206F_202A_206A_200B_206F_202D_206F_200F_202E_202E_202C_202A_206C_206D_202E.IsRepeatOnce)
					{
						num = 825538313;
						num26 = num;
					}
					else
					{
						num = 1026290515;
						num26 = num;
					}
					continue;
				}
				case 68u:
					num = (int)(num2 * 266506042) ^ -1919483076;
					continue;
				case 37u:
					_200F_200C_202B_206E_202B_202E_200C_200E_202B_200D_202B_202B_202B_202A_200E_202C_206A_200E_202D_206F_202A_202B_202E_202A_206B_202B_200B_202C_202E_200B_202A_206F_202B_200C_206B_200B_200F_202A_202C_206E_202E(((Component)val).GetComponent<Image>(), _202B_200B_200C_202C_200E_202C_200E_206B_200F_200B_206F_200D_202E_202D_206A_206E_202C_200C_200E_206C_206F_200D_200F_202D_202A_202D_200E_202E_200B_206E_200D_200E_200D_202D_200F_202E_202D_206D_202B_200C_202E);
					num = (int)((num2 * 1851592011) ^ 0x2FE57B65);
					continue;
				case 76u:
					((Component)this).transform.localPosition = new Vector3((float)(-504 + (index - 17) * 128), 10f, 0f);
					num = 1152682992;
					continue;
				case 32u:
					num = (int)((num2 * 1170406841) ^ 0x3664BE7A);
					continue;
				case 50u:
					_200D_202A_206F_206E_202B_202B_200D_206F_206A_200E_206C_200F_200C_206C_206F_202A_206C_202C_202D_200B_202D_202E_200B_206D_206A_200F_200B_200D_200B_202E_200E_206D_202B_206C_202B_206D_200F_200C_200F_200E_202E = role;
					num = ((int)num2 * -1436226836) ^ -1241117855;
					continue;
				case 99u:
					num = ((int)num2 * -6510649) ^ -1765677373;
					continue;
				case 98u:
					_202E_206C_202C_206B_200B_206A_206C_206D_202C_202B_202D_202D_200B_206D_206A_206F_202B_202C_202D_206D_206F_200D_200E_206F_202C_206A_200F_200C_200F_206A_200C_202B_206A_202E_200D_202D_206B_200C_206F_200D_202E = mapUI;
					num = (int)(num2 * 1864333559) ^ -887338195;
					continue;
				case 0u:
					mapRoleName = role.Name;
					num = (int)((num2 * 1905463260) ^ 0x74F409E0);
					continue;
				case 21u:
					num = (int)((num2 * 385511602) ^ 0x5F6AA026);
					continue;
				case 10u:
					((Component)this).transform.localPosition = new Vector3((float)(-362 + index * 200), 200f, 0f);
					num = (int)(num2 * 138969569) ^ -1803533342;
					continue;
				case 83u:
					goto IL_06eb;
				case 44u:
					((Component)this).transform.localPosition = new Vector3((float)(-440 + index * 128), 280f, 0f);
					num = (int)(num2 * 120845821) ^ -1590969675;
					continue;
				case 91u:
				{
					int num13;
					if (!_202C_200B_202E_206A_200D_206B_202D_202B_206F_200B_206E_202A_206F_200D_202A_206D_202A_202E_202D_200F_200D_206D_206A_200E_206C_202D_202C_202D_202E_206D_206D_206D_206B_202A_202B_206B_206A_206B_202E_206E_202E(text, ResourceStrings.ResStrings[1105]))
					{
						num = 255469041;
						num13 = num;
					}
					else
					{
						num = 468198389;
						num13 = num;
					}
					continue;
				}
				case 93u:
					num = ((int)num2 * -57791383) ^ -1060347906;
					continue;
				case 73u:
					goto IL_077c;
				case 95u:
					text = role2.Head;
					num = (int)(num2 * 867555266) ^ -1316739132;
					continue;
				case 57u:
					_206C_202B_200D_202C_206C_200E_202B_202D_206C_200C_202C_200C_200E_202A_206D_206F_206A_202B_206F_200B_206C_200F_206F_206F_202C_200D_206F_202A_206A_200B_206F_202D_206F_200F_202E_202E_202C_202A_206C_206D_202E = evt;
					num = ((int)num2 * -1091570727) ^ -2058610632;
					continue;
				case 69u:
					num = (int)((num2 * 244977922) ^ 0x42E1506E);
					continue;
				case 71u:
				{
					int num5;
					if (!RuntimeData.Instance.isLocationInTask(role.Name))
					{
						num = 1991730990;
						num5 = num;
					}
					else
					{
						num = 911844785;
						num5 = num;
					}
					continue;
				}
				case 94u:
					((Component)this).transform.localPosition = new Vector3((float)(-504 + (index - 7) * 144), 145f, 0f);
					num = ((int)num2 * -1759148193) ^ -159433750;
					continue;
				case 1u:
				{
					int num45;
					int num46;
					if (_206C_202B_200D_202C_206C_200E_202B_202D_206C_200C_202C_200C_200E_202A_206D_206F_206A_202B_206F_200B_206C_200F_206F_206F_202C_200D_206F_202A_206A_200B_206F_202D_206F_200F_202E_202E_202C_202A_206C_206D_202E == null)
					{
						num45 = 1402389101;
						num46 = num45;
					}
					else
					{
						num45 = 1519006149;
						num46 = num45;
					}
					num = num45 ^ ((int)num2 * -1307148892);
					continue;
				}
				case 11u:
					_202B_200B_200C_202C_200E_202C_200E_206B_200F_200B_206F_200D_202E_202D_206A_206E_202C_200C_200E_206C_206F_200D_200F_202D_202A_202D_200E_202E_200B_206E_200D_200E_200D_202D_200F_202E_202D_206D_202B_200C_202E = Resource.GetImage(text, forceLoadFromResource: false);
					num = ((int)num2 * -907433815) ^ 0x6547BD36;
					continue;
				case 55u:
					text2 = string.Empty;
					goto IL_0892;
				case 62u:
					switch (mapRoleCount)
					{
					case 14:
						break;
					case 10:
					case 11:
						goto IL_04ca;
					case 17:
					case 18:
					case 19:
					case 20:
					case 21:
					case 22:
					case 23:
						goto IL_052c;
					case 12:
					case 13:
						goto IL_06eb;
					case 8:
						goto IL_077c;
					default:
						goto IL_090b;
					case 7:
						goto IL_0a2c;
					case 24:
					case 25:
					case 26:
						goto IL_0b17;
					case 9:
						goto IL_0bbc;
					case 15:
					case 16:
						goto IL_0c83;
					case 27:
					case 28:
					case 29:
						goto IL_0ed9;
					case 6:
						goto IL_0fd5;
					}
					goto case 16u;
				case 18u:
					((Component)this).transform.localPosition = new Vector3((float)(-568 + (index - 9) * 128), 145f, 0f);
					num = ((int)num2 * -344074839) ^ -128340802;
					continue;
				case 53u:
					num = (int)(num2 * 859284021) ^ -949709485;
					continue;
				case 51u:
					((Component)this).transform.localPosition = new Vector3((float)(-520 + (index - 7) * 174), 20f, 0f);
					num = 1152682992;
					continue;
				case 17u:
				{
					int num37;
					if (RuntimeData.Instance.hasTask())
					{
						num = 1069978731;
						num37 = num;
					}
					else
					{
						num = 862776614;
						num37 = num;
					}
					continue;
				}
				case 20u:
				{
					int num35;
					if (index < 9)
					{
						num = 829397343;
						num35 = num;
					}
					else
					{
						num = 1111355637;
						num35 = num;
					}
					continue;
				}
				case 70u:
					((Component)this).transform.localPosition = new Vector3((float)(-552 + index * 160), 200f, 0f);
					num = (int)(num2 * 746426041) ^ -2027200020;
					continue;
				case 30u:
				{
					int num33;
					if (!_200D_200F_202A_200F_202E_206F_202D_202C_200C_200C_202E_202C_200B_202B_200B_206C_200E_200E_200E_200F_202B_200B_206C_202C_206F_202E_206A_200E_206C_206D_200F_202E_200B_200E_206D_206F_200C_206F_206D_200C_202E((Object)(object)sprite, (Object)null))
					{
						num = 191586736;
						num33 = num;
					}
					else
					{
						num = 63381940;
						num33 = num;
					}
					continue;
				}
				case 9u:
					goto IL_0a2c;
				case 82u:
				{
					int num27;
					int num28;
					if (index < 19)
					{
						num27 = -656251549;
						num28 = num27;
					}
					else
					{
						num27 = -861119427;
						num28 = num27;
					}
					num = num27 ^ ((int)num2 * -1474003701);
					continue;
				}
				case 8u:
					((Component)this).transform.localPosition = new Vector3((float)(-498 + (index - 5) * 200), 20f, 0f);
					num = 1469430927;
					continue;
				case 84u:
					((Component)this).transform.localPosition = new Vector3((float)(-376 + index * 128), 280f, 0f);
					num = (int)(num2 * 1566560304) ^ -2112094860;
					continue;
				case 7u:
					num = (int)(num2 * 465840895) ^ -2138762849;
					continue;
				case 34u:
					active = true;
					num = (int)(num2 * 1464683805) ^ -2062987063;
					continue;
				case 2u:
					goto IL_0b17;
				case 39u:
					num = (int)((num2 * 1116740105) ^ 0x3FCD2F67);
					continue;
				case 59u:
					val.localScale = new Vector3(1f, 1f);
					num = (int)(num2 * 762812839) ^ -2012894126;
					continue;
				case 86u:
					sprite = null;
					modThumbnailPath = Resource.GetModThumbnailPath(text, ref sprite);
					num = (int)(num2 * 1078959728) ^ -764102390;
					continue;
				case 3u:
					text = _206C_202B_200D_202C_206C_200E_202B_202D_206C_200C_202C_200C_200E_202A_206D_206F_206A_202B_206F_200B_206C_200F_206F_206F_202C_200D_206F_202A_206A_200B_206F_202D_206F_200F_202E_202E_202C_202A_206C_206D_202E.image;
					num = (int)((num2 * 196868612) ^ 0x18D84FDE);
					continue;
				case 88u:
					num = (int)((num2 * 1648445160) ^ 0xF025C7B);
					continue;
				case 41u:
					goto IL_0bbc;
				case 49u:
					num = (int)((num2 * 1825161136) ^ 0x76830C20);
					continue;
				case 45u:
					_202B_200B_200C_202C_200E_202C_200E_206B_200F_200B_206F_200D_202E_202D_206A_206E_202C_200C_200E_206C_206F_200D_200F_202D_202A_202D_200E_202E_200B_206E_200D_200E_200D_202D_200F_202E_202D_206D_202B_200C_202E = Resource.GetImage(text, forceLoadFromResource: false);
					num = 1841796071;
					continue;
				case 42u:
					((Component)((Component)this).transform.FindChild(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3270098211u))).gameObject.SetActive(false);
					num = ((int)num2 * -1203901588) ^ -1524365492;
					continue;
				case 87u:
					((Component)((Component)this).transform.FindChild(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(216562954u))).GetComponent<Text>().text = mapRoleName;
					num = 1756082748;
					continue;
				case 54u:
					if (!_200E_206A_206D_202E_202E_200E_200E_202E_200F_206D_202C_206B_206E_206B_200C_206E_206B_200C_206D_200B_202C_206A_202C_202D_200D_206F_202B_200C_200D_206E_202A_206D_202B_200B_200C_202C_200F_202D_202D_206C_202E(role.pic))
					{
						text2 = role.pic;
						goto IL_0892;
					}
					num = ((int)num2 * -410028084) ^ -1000472028;
					continue;
				case 28u:
					goto IL_0c83;
				case 25u:
					((Component)((Component)this).transform.FindChild(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1120299142u))).gameObject.SetActive(active);
					num = 1835813868;
					continue;
				case 26u:
					text = string.Empty;
					num = 574371124;
					continue;
				case 92u:
				{
					int num25;
					if (index >= 8)
					{
						num = 422800918;
						num25 = num;
					}
					else
					{
						num = 262288045;
						num25 = num;
					}
					continue;
				}
				case 33u:
				{
					int num23;
					int num24;
					if (index >= 17)
					{
						num23 = -1433784826;
						num24 = num23;
					}
					else
					{
						num23 = -180191931;
						num24 = num23;
					}
					num = num23 ^ (int)(num2 * 537408111);
					continue;
				}
				case 24u:
				{
					int num21;
					int num22;
					if (_206E_202D_202E_200D_202E_202A_202A_206C_202B_206E_206B_202E_202B_200F_200E_200B_200C_206B_202C_202D_200F_200F_202D_206A_202B_200D_202D_206D_200D_206A_202A_200D_206E_202D_200C_200B_202E_202A_200D_200F_202E(role.pic, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1245277517u)))
					{
						num21 = -1241990700;
						num22 = num21;
					}
					else
					{
						num21 = -375460263;
						num22 = num21;
					}
					num = num21 ^ ((int)num2 * -1872696676);
					continue;
				}
				case 12u:
				{
					int num18;
					int num19;
					if (!_200E_206A_206D_202E_202E_200E_200E_202E_200F_206D_202C_206B_206E_206B_200C_206E_206B_200C_206D_200B_202C_206A_202C_202D_200D_206F_202B_200C_200D_206E_202A_206D_202B_200B_200C_202C_200F_202D_202D_206C_202E(role2.Head))
					{
						num18 = 1959019820;
						num19 = num18;
					}
					else
					{
						num18 = 370824095;
						num19 = num18;
					}
					num = num18 ^ (int)(num2 * 798994633);
					continue;
				}
				case 90u:
				{
					int num15;
					int num16;
					if (!_200E_206A_206D_202E_202E_200E_200E_202E_200F_206D_202C_206B_206E_206B_200C_206E_206B_200C_206D_200B_202C_206A_202C_202D_200D_206F_202B_200C_200D_206E_202A_206D_202B_200B_200C_202C_200F_202D_202D_206C_202E(text))
					{
						num15 = -776130962;
						num16 = num15;
					}
					else
					{
						num15 = -1760774330;
						num16 = num15;
					}
					num = num15 ^ (int)(num2 * 1952948245);
					continue;
				}
				case 85u:
					((Component)this).transform.localPosition = new Vector3((float)(-504 + (index - 8) * 128), 145f, 0f);
					num = (int)((num2 * 1552793612) ^ 0x20FABA95);
					continue;
				case 97u:
					((Component)this).transform.localPosition = new Vector3((float)(-298 + (index - 4) * 200), 20f, 0f);
					num = 772903396;
					continue;
				case 63u:
				{
					role2 = RuntimeData.Instance.GetTeamRole(role.roleKey);
					int num11;
					int num12;
					if (role2 != null)
					{
						num11 = 1318006292;
						num12 = num11;
					}
					else
					{
						num11 = 96082942;
						num12 = num11;
					}
					num = num11 ^ ((int)num2 * -654830404);
					continue;
				}
				case 67u:
					num = (int)(num2 * 246634304) ^ -384498512;
					continue;
				case 4u:
					((Component)this).transform.localPosition = new Vector3((float)(-360 + index * 144), 280f, 0f);
					num = (int)((num2 * 1336398013) ^ 0x792FB95C);
					continue;
				case 13u:
					role2 = ResourceManager.Get<Role>(role.roleKey);
					num = (int)((num2 * 1902541980) ^ 0x5A6640EC);
					continue;
				case 56u:
					((Component)this).transform.localPosition = new Vector3((float)(-362 + (index - 5) * 200), 20f, 0f);
					num = 1152682992;
					continue;
				case 23u:
					goto IL_0ed9;
				case 77u:
				{
					int num8;
					int num9;
					if (index >= 15)
					{
						num8 = 1655651080;
						num9 = num8;
					}
					else
					{
						num8 = 864826029;
						num9 = num8;
					}
					num = num8 ^ ((int)num2 * -549920662);
					continue;
				}
				case 89u:
					((Component)this).transform.localPosition = new Vector3((float)(-504 + (index - 15) * 144), 10f, 0f);
					num = 419473805;
					continue;
				case 47u:
				{
					_202B_200B_200C_202C_200E_202C_200E_206B_200F_200B_206F_200D_202E_202D_206A_206E_202C_200C_200E_206C_206F_200D_200F_202D_202A_202D_200E_202E_200B_206E_200D_200E_200D_202D_200F_202E_202D_206D_202B_200C_202E = Resource.GetModThumbnailImage(modThumbnailPath);
					int num6;
					int num7;
					if (!_200F_202B_206B_206A_206E_206F_202C_202D_206E_202D_202E_206A_202C_202A_206B_206F_200D_200F_202A_202B_202B_206F_206D_202B_202A_200D_200F_200B_202A_206B_206F_202D_202E_202A_202C_200F_202C_200C_206F_202B_202E((Object)(object)_202B_200B_200C_202C_200E_202C_200E_206B_200F_200B_206F_200D_202E_202D_206A_206E_202C_200C_200E_206C_206F_200D_200F_202D_202A_202D_200E_202E_200B_206E_200D_200E_200D_202D_200F_202E_202D_206D_202B_200C_202E, (Object)null))
					{
						num6 = 503778917;
						num7 = num6;
					}
					else
					{
						num6 = 942655158;
						num7 = num6;
					}
					num = num6 ^ (int)(num2 * 1959540398);
					continue;
				}
				case 19u:
					desc = role.description;
					text = string.Empty;
					num = ((int)num2 * -1734555867) ^ 0x13002E47;
					continue;
				case 72u:
				{
					int num3;
					int num4;
					if (_200E_206A_206D_202E_202E_200E_200E_202E_200F_206D_202C_206B_206E_206B_200C_206E_206B_200C_206D_200B_202C_206A_202C_202D_200D_206F_202B_200C_200D_206E_202A_206D_202B_200B_200C_202C_200F_202D_202D_206C_202E(_206C_202B_200D_202C_206C_200E_202B_202D_206C_200C_202C_200C_200E_202A_206D_206F_206A_202B_206F_200B_206C_200F_206F_206F_202C_200D_206F_202A_206A_200B_206F_202D_206F_200F_202E_202E_202C_202A_206C_206D_202E.description))
					{
						num3 = -365336131;
						num4 = num3;
					}
					else
					{
						num3 = -1375139216;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 484593673);
					continue;
				}
				case 100u:
					goto IL_0fd5;
				case 29u:
					return;
					IL_077c:
					if (index < 4)
					{
						num = 1869123534;
						num10 = num;
					}
					else
					{
						num = 757583472;
						num10 = num;
					}
					continue;
					IL_06eb:
					if (index >= 6)
					{
						num = 655021069;
						num17 = num;
					}
					else
					{
						num = 1584331599;
						num17 = num;
					}
					continue;
					IL_052c:
					if (index >= 7)
					{
						num = 1792262231;
						num36 = num;
					}
					else
					{
						num = 1397820295;
						num36 = num;
					}
					continue;
					IL_0fd5:
					((Component)this).transform.localPosition = new Vector3((float)(-462 + index * 200), 90f, 0f);
					num = 694709448;
					continue;
					IL_0ed9:
					if (index < 9)
					{
						num = 1393517799;
						num40 = num;
					}
					else
					{
						num = 2000018251;
						num40 = num;
					}
					continue;
					IL_0c83:
					if (index >= 8)
					{
						num = 690817450;
						num41 = num;
					}
					else
					{
						num = 237405551;
						num41 = num;
					}
					continue;
					IL_04ca:
					if (index >= 5)
					{
						num = 1818160707;
						num42 = num;
					}
					else
					{
						num = 1823029074;
						num42 = num;
					}
					continue;
					IL_0bbc:
					if (index < 5)
					{
						num = 121022401;
						num43 = num;
					}
					else
					{
						num = 326784161;
						num43 = num;
					}
					continue;
					IL_0b17:
					if (index >= 8)
					{
						num = 2080879797;
						num44 = num;
					}
					else
					{
						num = 606378947;
						num44 = num;
					}
					continue;
					IL_0a2c:
					((Component)this).transform.localPosition = new Vector3((float)(-522 + index * 180), 90f, 0f);
					num = 1152682992;
					continue;
					IL_090b:
					num = 933657014;
					continue;
					IL_0892:
					text = text2;
					num = 820331489;
					continue;
				}
				break;
			}
		}
	}

	static bool _200D_200F_202A_200F_202E_206F_202D_202C_200C_200C_202E_202C_200B_202B_200B_206C_200E_200E_200E_200F_202B_200B_206C_202C_206F_202E_206A_200E_206C_206D_200F_202E_200B_200E_206D_206F_200C_206F_206D_200C_202E(Object P_0, Object P_1)
	{
		return P_0 != P_1;
	}

	static bool _200E_206A_206D_202E_202E_200E_200E_202E_200F_206D_202C_206B_206E_206B_200C_206E_206B_200C_206D_200B_202C_206A_202C_202D_200D_206F_202B_200C_200D_206E_202A_206D_202B_200B_200C_202C_200F_202D_202D_206C_202E(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}

	static bool _206E_202D_202E_200D_202E_202A_202A_206C_202B_206E_206B_202E_202B_200F_200E_200B_200C_206B_202C_202D_200F_200F_202D_206A_202B_200D_202D_206D_200D_206A_202A_200D_206E_202D_200C_200B_202E_202A_200D_200F_202E(string P_0, string P_1)
	{
		return P_0 == P_1;
	}

	static bool _202C_200B_202E_206A_200D_206B_202D_202B_206F_200B_206E_202A_206F_200D_202A_206D_202A_202E_202D_200F_200D_206D_206A_200E_206C_202D_202C_202D_202E_206D_206D_206D_206B_202A_202B_206B_206A_206B_202E_206E_202E(string P_0, string P_1)
	{
		return P_0.StartsWith(P_1);
	}

	static bool _200F_202B_206B_206A_206E_206F_202C_202D_206E_202D_202E_206A_202C_202A_206B_206F_200D_200F_202A_202B_202B_206F_206D_202B_202A_200D_200F_200B_202A_206B_206F_202D_202E_202A_202C_200F_202C_200C_206F_202B_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static Transform _200F_206B_202A_202D_200C_202E_206F_206B_202A_206B_206A_206A_206D_202B_200D_206B_200B_202D_202B_206A_206B_206E_206E_200E_202C_206B_206B_200F_202E_206A_202B_200F_200C_202A_202E_202C_202A_206B_200E_202E_202E(Component P_0)
	{
		return P_0.transform;
	}

	static Transform _202E_202E_200B_206C_206B_200C_206C_202E_200D_200B_202C_202B_206A_200E_202E_206F_206A_206C_202E_200D_202C_202A_206E_200B_206F_202D_206F_200C_206C_200E_206A_202A_202C_200D_206C_206C_206A_206C_202C_202B_202E(Transform P_0, string P_1)
	{
		return P_0.FindChild(P_1);
	}

	static void _200F_200C_202B_206E_202B_202E_200C_200E_202B_200D_202B_202B_202B_202A_200E_202C_206A_200E_202D_206F_202A_202B_202E_202A_206B_202B_200B_202C_202E_200B_202A_206F_202B_200C_206B_200B_200F_202A_202C_206E_202E(Image P_0, Sprite P_1)
	{
		P_0.sprite = P_1;
	}

	static GameObject _200C_206B_206B_202D_202B_202C_206D_206B_206D_202A_200B_206C_200C_206F_202A_200C_200E_200D_202D_202D_206C_206B_202E_200C_202E_200F_206D_200F_202B_200F_206D_200B_200F_200B_206E_202B_206B_202A_200D_206F_202E(Component P_0)
	{
		return P_0.gameObject;
	}

	static void _206A_206E_200D_202C_202A_206A_202B_200F_200B_206D_202C_200C_200C_206D_206A_202B_206C_200D_200D_200F_206D_200D_202E_206E_206F_206D_206F_202E_206D_202E_206D_200D_200C_200D_206E_200E_206F_200F_202B_202E(GameObject P_0, bool P_1)
	{
		P_0.SetActive(P_1);
	}

	static Transform _200C_200C_202A_200F_206B_206C_200C_206C_200F_202E_202E_206F_202A_206E_202E_206B_202C_200B_202A_202C_206E_200C_206F_200B_202C_202B_206F_200D_206C_206F_206B_200E_200D_200B_206F_206E_202A_206E_202E_200D_202E(GameObject P_0)
	{
		return P_0.transform;
	}

	static void _200F_202B_202C_200E_200C_206F_202C_200B_202E_206E_202A_202D_200B_206D_202E_200E_200D_206B_200C_200F_200F_206D_200F_200D_206D_200B_200F_200E_200C_202E_200D_202C_206B_202A_202B_200D_200F_202D_202A_200C_202E(Text P_0, string P_1)
	{
		P_0.text = P_1;
	}
}
