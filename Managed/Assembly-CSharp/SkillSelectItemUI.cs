using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JyGame;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SkillSelectItemUI : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
	[CompilerGenerated]
	private sealed class _206B_202C_200B_202C_202C_200B_206E_202C_206B_206C_206C_206D_206F_206B_202D_200C_200C_206E_202B_202E_206B_206B_200D_202C_206E_200C_200E_206C_202B_202D_206E_202E_200C_206C_202E_200E_202D_200C_202D_206D_202E
	{
		public Role role;

		internal void _202D_200D_200F_200C_202D_206B_200C_202B_202D_206C_200D_200F_200F_202B_206C_200C_206B_206E_202C_206F_200B_200F_202C_202C_206D_202E_200B_200D_200B_206F_206C_200C_206E_202E_206A_200F_206B_206D_206C_200E_202E()
		{
			RuntimeData.Instance.RefreshTeamMemberPanel(role, refreshImage: false, refreshText: true);
		}
	}

	public GameObject DetailPanelObj;

	private SkillBox _206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E;

	private SelectItemMode _206A_202C_206D_202B_200F_200D_206D_202B_202A_206B_202E_202D_206A_200E_200C_200C_202A_202B_202E_206B_206E_202C_206E_202C_200B_202D_202B_202E_200E_202C_202E_206E_206D_206E_200E_202E_200B_206A_202D_202D_202E;

	private GameObject _202B_200F_200F_206D_200E_200D_202D_206B_202D_206B_202C_200C_202E_206D_200C_202A_200F_206A_206E_206C_202C_200E_206E_200F_206E_206F_200D_206E_200E_202A_202B_200C_202A_200F_200F_206A_200E_206A_202E_200E_202E;

	private bool isBind;

	private Role _200D_202A_206F_206E_202B_202B_200D_206F_206A_200E_206C_200F_200C_206C_206F_202A_206C_202C_202D_200B_202D_202E_200B_206D_206A_200F_200B_200D_200B_202E_200E_206D_202B_206C_202B_206D_200F_200C_200F_200E_202E;

	private ItemSkillDetailPanelUI DetailPanel => DetailPanelObj.GetComponent<ItemSkillDetailPanelUI>();

	public SkillBox GetSkill()
	{
		return _206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E;
	}

	public void SetMode(SelectItemMode mode)
	{
		_206A_202C_206D_202B_200F_200D_206D_202B_202A_206B_202E_202D_206A_200E_200C_200C_202A_202B_202E_206B_206E_202C_206E_202C_200B_202D_202B_202E_200E_202C_202E_206E_206D_206E_200E_202E_200B_206A_202D_202D_202E = mode;
	}

	public void OnPointerEnter(PointerEventData data)
	{
		if (CommonSettings.TOUCH_MODE)
		{
			return;
		}
		while (true)
		{
			int num = -1643311767;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1210247704)) % 4)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
				{
					int num3;
					int num4;
					if (!_202C_202D_202B_202B_206E_206F_200E_202C_206E_202D_206A_206A_206D_200E_202C_200D_202E_202B_202B_206C_206F_200F_206F_206C_200F_202E_206F_206C_200C_202B_206A_206C_200F_200F_206C_202C_202E_202A_206E_202D_202E((Object)(object)_202B_200F_200F_206D_200E_200D_202D_206B_202D_206B_202C_200C_202E_206D_200C_202A_200F_206A_206E_206C_202C_200E_206E_200F_206E_206F_200D_206E_200E_202A_202B_200C_202A_200F_200F_206A_200E_206A_202E_200E_202E, (Object)null))
					{
						num3 = -1931902430;
						num4 = num3;
					}
					else
					{
						num3 = -1436446009;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1050693651);
					continue;
				}
				case 2u:
					_202B_200F_200F_206D_200E_200D_202D_206B_202D_206B_202C_200C_202E_206D_200C_202A_200F_206A_206E_206C_202C_200E_206E_200F_206E_206F_200D_206E_200E_202A_202B_200C_202A_200F_200F_206A_200E_206A_202E_200E_202E.GetComponent<ItemPreviewPanelUI>().Show(_202D_202B_200B_202E_206F_200B_206F_200D_206E_206D_200F_206A_202E_206C_202E_200B_206A_202E_202A_200D_202C_202D_200B_206F_206E_202D_206F_206B_202E_200C_202A_206F_202D_202B_206E_202B_202A_202E_202D_202B_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1617625233u), _206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E.Name, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2484039868u), RuntimeData.Instance.strReplace_JyGame(_206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E.DescriptionInRichtextBlackBg)));
					num = ((int)num2 * -305498880) ^ -1102875057;
					continue;
				case 3u:
					return;
				}
				break;
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
			int num = -1380423732;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -105386626)) % 4)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
				{
					int num3;
					int num4;
					if (!_202C_202D_202B_202B_206E_206F_200E_202C_206E_202D_206A_206A_206D_200E_202C_200D_202E_202B_202B_206C_206F_200F_206F_206C_200F_202E_206F_206C_200C_202B_206A_206C_200F_200F_206C_202C_202E_202A_206E_202D_202E((Object)(object)_202B_200F_200F_206D_200E_200D_202D_206B_202D_206B_202C_200C_202E_206D_200C_202A_200F_206A_206E_206C_202C_200E_206E_200F_206E_206F_200D_206E_200E_202A_202B_200C_202A_200F_200F_206A_200E_206A_202E_200E_202E, (Object)null))
					{
						num3 = 228479613;
						num4 = num3;
					}
					else
					{
						num3 = 1830730583;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 807261725);
					continue;
				}
				case 3u:
					_202B_200F_200F_206D_200E_200D_202D_206B_202D_206B_202C_200C_202E_206D_200C_202A_200F_206A_206E_206C_202C_200E_206E_200F_206E_206F_200D_206E_200E_202A_202B_200C_202A_200F_200F_206A_200E_206A_202E_200E_202E.GetComponent<ItemPreviewPanelUI>().Hide();
					num = (int)(num2 * 1434307732) ^ -256891413;
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public void OnPointerDown(PointerEventData data)
	{
	}

	public void OnPointerUp(PointerEventData data)
	{
	}

	public void Bind(SkillBox skill, bool isActive = true, GameObject previewPanel = null)
	{
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		_206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E = skill;
		_202B_200F_200F_206D_200E_200D_202D_206B_202D_206B_202C_200C_202E_206D_200C_202A_200F_206A_206E_206C_202C_200E_206E_200F_206E_206F_200D_206E_200E_202A_202B_200C_202A_200F_200F_206A_200E_206A_202E_200E_202E = previewPanel;
		Text component = ((Component)_200F_206D_200E_206E_206C_202A_206A_200F_202B_200E_202E_202D_202D_202D_202A_200C_202B_200D_206B_202E_200D_206D_202E_202E_206C_200D_206C_202E_206B_206E_200D_202A_206A_200E_200F_200B_206D_202A_200E_200F_202E(_206A_200E_206C_206F_206E_206D_202E_206C_206D_200E_200E_202C_200D_206F_206E_200F_206A_206F_200E_200C_200E_202B_200D_200E_206D_200B_200D_202A_206E_206E_206D_206F_206F_206C_206D_206D_206A_206D_200F_200F_202E((Component)(object)this), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1024370605u))).GetComponent<Text>();
		string text = default(string);
		string text2 = default(string);
		while (true)
		{
			int num = -824904432;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1813556984)) % 22)
				{
				case 18u:
					break;
				case 12u:
					_200C_206B_200D_200B_206A_202A_206A_200D_206C_200C_206E_202C_206C_200D_206B_200E_200C_206C_202B_206B_206E_202C_202B_206D_200E_206A_206C_202E_206D_202D_206A_200B_200C_202E_202D_202D_202A_202E_200F_206A_202E(component, _206E_200F_206D_202B_200F_202B_200F_200B_202E_206B_206F_200B_206A_202E_206D_200B_200D_200C_202B_200E_202B_200E_206A_200E_206C_206C_200C_202A_206C_200B_206D_202A_206B_206E_202B_206C_200E_202B_206E_206A_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1244651021u), (object)(skill as UniqueSkillInstance).Parent.Name));
					num = ((int)num2 * -527505592) ^ -242870236;
					continue;
				case 16u:
				{
					_200C_206B_200D_200B_206A_202A_206A_200D_206C_200C_206E_202C_206C_200D_206B_200E_200C_206C_202B_206B_206E_202C_202B_206D_200E_206A_206C_202E_206D_202D_206A_200B_200C_202E_202D_202D_202A_202E_200F_206A_202E(((Component)_200F_206D_200E_206E_206C_202A_206A_200F_202B_200E_202E_202D_202D_202D_202A_200C_202B_200D_206B_202E_200D_206D_202E_202E_206C_200D_206C_202E_206B_206E_200D_202A_206A_200E_200F_200B_206D_202A_200E_200F_202E(_206A_200E_206C_206F_206E_206D_202E_206C_206D_200E_200E_202C_200D_206F_206E_200F_206A_206F_200E_200C_200E_202B_200D_200E_206D_200B_200D_202A_206E_206E_206D_206F_206F_206C_206D_206D_206A_206D_200F_200F_202E((Component)(object)this), global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3376456949u))).GetComponent<Text>(), string.Empty);
					int num6;
					if (skill.IsUnique)
					{
						num = -301834365;
						num6 = num;
					}
					else
					{
						num = -1849823649;
						num6 = num;
					}
					continue;
				}
				case 5u:
					text = _202B_202E_206A_200F_202C_206A_200B_202B_202A_202B_200B_206F_206B_202A_202D_202B_202D_206A_202E_206E_202E_202D_206A_202A_200F_206D_200D_200B_202A_202E_200C_200E_206A_202D_200E_202B_200D_202B_206B_202C_202E(skill.Name, 0, _202D_206B_206B_202C_206A_202C_206A_200B_206B_200F_202A_206F_206D_202A_202E_200F_202B_200F_202A_206C_202D_206A_200C_202B_206D_206E_206C_200F_200E_206C_200E_200E_200B_200B_206C_202C_200F_206F_206B_200F_202E(text2));
					num = ((int)num2 * -1629802778) ^ 0xC8D5902;
					continue;
				case 9u:
				{
					int num7;
					int num8;
					if (!_200C_200C_200E_200C_202D_206A_200B_202E_202D_202D_200F_206D_206D_202C_206A_200C_206E_200E_200F_202A_206A_202D_206F_200E_200B_202E_200E_206F_202D_200D_202E_200B_206D_206B_200B_200F_202A_206A_202E_202C_202E(skill.Name, text2))
					{
						num7 = -2023972242;
						num8 = num7;
					}
					else
					{
						num7 = -1019411503;
						num8 = num7;
					}
					num = num7 ^ (int)(num2 * 782067010);
					continue;
				}
				case 10u:
				{
					int num13;
					int num14;
					if (!skill.IsUnique)
					{
						num13 = 2037179983;
						num14 = num13;
					}
					else
					{
						num13 = 914504804;
						num14 = num13;
					}
					num = num13 ^ ((int)num2 * -1963223091);
					continue;
				}
				case 20u:
				{
					int num9;
					int num10;
					if (skill.IsUnique)
					{
						num9 = -1308995254;
						num10 = num9;
					}
					else
					{
						num9 = -2053587279;
						num10 = num9;
					}
					num = num9 ^ (int)(num2 * 1952434625);
					continue;
				}
				case 21u:
				{
					int num11;
					int num12;
					if (skill.SkillType == SkillType.Title)
					{
						num11 = 1481570090;
						num12 = num11;
					}
					else
					{
						num11 = 939573667;
						num12 = num11;
					}
					num = num11 ^ (int)(num2 * 1196234862);
					continue;
				}
				case 13u:
					_200C_206B_200D_200B_206A_202A_206A_200D_206C_200C_206E_202C_206C_200D_206B_200E_200C_206C_202B_206B_206E_202C_202B_206D_200E_206A_206C_202E_206D_202D_206A_200B_200C_202E_202D_202D_202A_202E_200F_206A_202E(component, skill.Name);
					num = -492913419;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if ((skill as UniqueSkillInstance).Parent is InternalSkillInstance)
					{
						num4 = -109806880;
						num5 = num4;
					}
					else
					{
						num4 = -952048749;
						num5 = num4;
					}
					num = num4 ^ (int)(num2 * 2122875594);
					continue;
				}
				case 7u:
					_202B_202A_202B_206B_200E_202A_206A_206D_200E_206D_200B_206B_200D_202A_206A_202C_206B_202E_200E_206E_206D_202E_202D_200C_200D_202D_200F_206D_202A_202A_206E_200E_206E_202A_202E_206E_200F_202E_206B_200E_202E(_202C_200F_202C_202B_200E_202B_202C_202C_206A_202E_206F_202B_202B_202E_206B_200C_206B_202A_206F_206D_206E_206E_206E_200E_202C_200D_202B_206E_200C_202B_202A_202D_202C_206A_200D_206D_202D_202A_200B_202C_202E((Component)(object)_200F_206D_200E_206E_206C_202A_206A_200F_202B_200E_202E_202D_202D_202D_202A_200C_202B_200D_206B_202E_200D_206D_202E_202E_206C_200D_206C_202E_206B_206E_200D_202A_206A_200E_200F_200B_206D_202A_200E_200F_202E(_206A_200E_206C_206F_206E_206D_202E_206C_206D_200E_200E_202C_200D_206F_206E_200F_206A_206F_200E_200C_200E_202B_200D_200E_206D_200B_200D_202A_206E_206E_206D_206F_206F_206C_206D_206D_206A_206D_200F_200F_202E((Component)(object)this), global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4229838264u))), false);
					num = ((int)num2 * -1900047631) ^ -1335856014;
					continue;
				case 1u:
					_200C_206B_200D_200B_206A_202A_206A_200D_206C_200C_206E_202C_206C_200D_206B_200E_200C_206C_202B_206B_206E_202C_202B_206D_200E_206A_206C_202E_206D_202D_206A_200B_200C_202E_202D_202D_202A_202E_200F_206A_202E(component, _206E_200F_206D_202B_200F_202B_200F_200B_202E_206B_206F_200B_206A_202E_206D_200B_200D_200C_202B_200E_202B_200E_206A_200E_206C_206C_200C_202A_206C_200B_206D_202A_206B_206E_202B_206C_200E_202B_206E_206A_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2772532067u), (object)(skill as UniqueSkillInstance).Parent.Name));
					num = -15766236;
					continue;
				case 11u:
					_202B_206E_206D_200C_206D_202D_206D_206A_206B_206A_200F_200B_202E_202D_206E_206C_202A_206F_206C_200B_200C_200B_202B_206B_200B_200D_202E_206E_202C_202D_202E_200B_206F_202D_206F_200D_200D_202B_200C_206F_202E((Graphic)(object)component, skill.Color);
					num = ((int)num2 * -1077835444) ^ -1363612668;
					continue;
				case 17u:
					_202E_202D_200E_200C_206A_200B_206F_200C_202E_202D_206C_200C_200C_206A_202B_202C_202A_202A_200E_202C_200C_202D_206F_200F_200F_206B_200E_206E_200E_200E_206A_206B_206F_206F_206E_206D_200E_206D_206E_206B_202E(((Component)_200F_206D_200E_206E_206C_202A_206A_200F_202B_200E_202E_202D_202D_202D_202A_200C_202B_200D_206B_202E_200D_206D_202E_202E_206C_200D_206C_202E_206B_206E_200D_202A_206A_200E_200F_200B_206D_202A_200E_200F_202E(_206A_200E_206C_206F_206E_206D_202E_206C_206D_200E_200E_202C_200D_206F_206E_200F_206A_206F_200E_200C_200E_202B_200D_200E_206D_200B_200D_202A_206E_206E_206D_206F_206F_206C_206D_206D_206A_206D_200F_200F_202E((Component)(object)this), global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(648958214u))).GetComponent<Image>(), Resource.GetIcon(skill.Icon));
					num = -1866298572;
					continue;
				case 3u:
					_202B_206E_206D_200C_206D_202D_206D_206A_206B_206A_200F_200B_202E_202D_206E_206C_202A_206F_206C_200B_200C_200B_202B_206B_200B_200D_202E_206E_202C_202D_202E_200B_206F_202D_206F_200D_200D_202B_200C_206F_202E((Graphic)(object)component, skill.Color);
					num = (int)(num2 * 2108565040) ^ -1797264024;
					continue;
				case 15u:
					num = (int)(num2 * 1752762272) ^ -1103411713;
					continue;
				case 8u:
				{
					int num3;
					if (skill.IsSpecial)
					{
						num = -2012384576;
						num3 = num;
					}
					else
					{
						num = -1183673598;
						num3 = num;
					}
					continue;
				}
				case 0u:
					_200C_206B_200D_200B_206A_202A_206A_200D_206C_200C_206E_202C_206C_200D_206B_200E_200C_206C_202B_206B_206E_202C_202B_206D_200E_206A_206C_202E_206D_202D_206A_200B_200C_202E_202D_202D_202A_202E_200F_206A_202E(component, _202D_206C_206F_202B_206C_202D_200B_200F_202C_206D_202D_202C_200D_202D_202D_202D_206A_200E_200F_206D_206B_202C_206E_202A_200D_206E_202C_200F_200C_200F_200B_206C_206F_202C_202B_200D_202B_200E_206F_206B_202E(_202A_200F_202C_200D_206C_206F_206D_202D_206B_202B_200F_200F_206A_206C_200D_200D_206A_206F_202E_202C_206C_206A_202A_200B_206A_200E_200D_202D_202A_200C_206E_206B_206B_202D_200D_200B_200F_202C_202E_202E_202E(component), global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2910989005u), text));
					num = -316303627;
					continue;
				case 14u:
					text2 = _202A_202A_206B_206C_206E_206C_206A_206B_206D_200B_200F_206B_206E_206C_200F_202B_206A_200C_200E_206D_206E_202C_202C_202C_206D_200C_200D_202A_206C_206A_206D_202C_200D_200D_200C_206F_206D_200C_200C_206D_202E((skill as UniqueSkillInstance).Parent.Name, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1911841291u));
					num = -2122035155;
					continue;
				case 4u:
					text = skill.Name;
					num = -779427440;
					continue;
				case 19u:
					_200C_206B_200D_200B_206A_202A_206A_200D_206C_200C_206E_202C_206C_200D_206B_200E_200C_206C_202B_206B_206E_202C_202B_206D_200E_206A_206C_202E_206D_202D_206A_200B_200C_202E_202D_202D_202A_202E_200F_206A_202E(((Component)_200F_206D_200E_206E_206C_202A_206A_200F_202B_200E_202E_202D_202D_202D_202A_200C_202B_200D_206B_202E_200D_206D_202E_202E_206C_200D_206C_202E_206B_206E_200D_202A_206A_200E_200F_200B_206D_202A_200E_200F_202E(_206A_200E_206C_206F_206E_206D_202E_206C_206D_200E_200E_202C_200D_206F_206E_200F_206A_206F_200E_200C_200E_202B_200D_200E_206D_200B_200D_202A_206E_206E_206D_206F_206F_206C_206D_206D_206A_206D_200F_200F_202E((Component)(object)this), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3301124240u))).GetComponent<Text>(), _206E_200F_206D_202B_200F_202B_200F_200B_202E_206B_206F_200B_206A_202E_206D_200B_200D_200C_202B_200E_202B_200E_206A_200E_206C_206C_200C_202A_206C_200B_206D_202A_206B_206E_202B_206C_200E_202B_206E_206A_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(905711202u), (object)skill.Level));
					num = -1849823649;
					continue;
				default:
					isBind = true;
					IsOn(skill.IsUsed);
					isBind = false;
					_200D_200B_200C_200B_202B_206E_206A_206C_206A_202C_206B_206B_202E_206C_206E_200D_200B_200F_200E_206E_200F_200E_206D_206B_200E_206E_206F_206B_206B_206B_200E_206C_200E_206C_206F_202E_206F_202D_206A_200F_202E((Selectable)(object)((Component)_200F_206D_200E_206E_206C_202A_206A_200F_202B_200E_202E_202D_202D_202D_202A_200C_202B_200D_206B_202E_200D_206D_202E_202E_206C_200D_206C_202E_206B_206E_200D_202A_206A_200E_200F_200B_206D_202A_200E_200F_202E(_206A_200E_206C_206F_206E_206D_202E_206C_206D_200E_200E_202C_200D_206F_206E_200F_206A_206F_200E_200C_200E_202B_200D_200E_206D_200B_200D_202A_206E_206E_206D_206F_206F_206C_206D_206D_206A_206D_200F_200F_202E((Component)(object)this), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1816097149u))).GetComponent<Toggle>(), isActive);
					return;
				}
				break;
			}
		}
	}

	public void IsOn(bool isOn)
	{
		_206F_202E_202E_200B_200E_202A_206C_206F_202C_200C_200D_200F_202E_202B_200D_200B_202E_206A_200D_202E_200C_206E_202A_200E_206A_200E_202C_200E_206D_200D_202B_202B_200D_202D_206B_202E_202D_202A_200C_206F_202E(((Component)_200F_206D_200E_206E_206C_202A_206A_200F_202B_200E_202E_202D_202D_202D_202A_200C_202B_200D_206B_202E_200D_206D_202E_202E_206C_200D_206C_202E_206B_206E_200D_202A_206A_200E_200F_200B_206D_202A_200E_200F_202E(_206A_200E_206C_206F_206E_206D_202E_206C_206D_200E_200E_202C_200D_206F_206E_200F_206A_206F_200E_200C_200E_202B_200D_200E_206D_200B_200D_202A_206E_206E_206D_206F_206F_206C_206D_206D_206A_206D_200F_200F_202E((Component)(object)this), global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(774194531u))).GetComponent<Toggle>(), isOn);
	}

	public void OnToggleValuedChanged()
	{
		if (isBind)
		{
			goto IL_000b;
		}
		goto IL_0254;
		IL_000b:
		int num = 329094373;
		goto IL_0010;
		IL_0010:
		SkillBox skillBox = default(SkillBox);
		bool flag2 = default(bool);
		SkillSelectItemUI[] componentsInChildren = default(SkillSelectItemUI[]);
		int num9 = default(int);
		SkillSelectItemUI skillSelectItemUI = default(SkillSelectItemUI);
		SkillInstance current = default(SkillInstance);
		bool flag3 = default(bool);
		SkillSelectItemUI skillSelectItemUI2 = default(SkillSelectItemUI);
		RolePanelUI componentInParent = default(RolePanelUI);
		while (true)
		{
			uint num2;
			int num10;
			int num27;
			int num28;
			switch ((num2 = (uint)(num ^ 0x7F7CB1E5)) % 24)
			{
			case 19u:
				break;
			case 14u:
				isBind = false;
				if (!skillBox.IsSpecial)
				{
					num = ((int)num2 * -1119257233) ^ 0xA562543;
					continue;
				}
				goto IL_05c7;
			case 17u:
				goto IL_00ab;
			case 5u:
			{
				int num23;
				int num24;
				if (!flag2)
				{
					num23 = 1575760103;
					num24 = num23;
				}
				else
				{
					num23 = 1617708722;
					num24 = num23;
				}
				num = num23 ^ ((int)num2 * -1532358037);
				continue;
			}
			case 20u:
				goto IL_00f4;
			case 16u:
				return;
			case 18u:
				componentsInChildren = ((Component)_206B_200D_206E_202A_206C_206A_206F_200D_202C_206B_206C_200B_202A_200F_200E_200E_202E_206E_200C_202A_202D_206E_202B_202B_206E_200E_200C_200E_206A_206C_202B_206C_200F_206F_206D_202C_202D_200B_206A_206F_202E(_206A_200E_206C_206F_206E_206D_202E_206C_206D_200E_200E_202C_200D_206F_206E_200F_206A_206F_200E_200C_200E_202B_200D_200E_206D_200B_200D_202A_206E_206E_206D_206F_206F_206C_206D_206D_206A_206D_200F_200F_202E((Component)(object)this))).GetComponentsInChildren<SkillSelectItemUI>();
				num = ((int)num2 * -1667374570) ^ -1822859540;
				continue;
			case 22u:
				num9++;
				num = 816863665;
				continue;
			case 13u:
				skillBox.Owner.SetEquippedTitle(null);
				num = 781386830;
				continue;
			case 0u:
				if (!skillBox.IsInternal)
				{
					num = ((int)num2 * -673038885) ^ 0x74B624DF;
					continue;
				}
				goto IL_0665;
			case 21u:
				num9 = 0;
				num = ((int)num2 * -1421012401) ^ 0x7C6AC5DA;
				continue;
			case 3u:
				if (_202C_202D_202B_202B_206E_206F_200E_202C_206E_202D_206A_206A_206D_200E_202C_200D_202E_202B_202B_206C_206F_200F_206F_206C_200F_202E_206F_206C_200C_202B_206A_206C_200F_200F_206C_202C_202E_202A_206E_202D_202E((Object)(object)_206B_200D_206E_202A_206C_206A_206F_200D_202C_206B_206C_200B_202A_200F_200E_200E_202E_206E_200C_202A_202D_206E_202B_202B_206E_200E_200C_200E_206A_206C_202B_206C_200F_206F_206D_202C_202D_200B_206A_206F_202E(_206A_200E_206C_206F_206E_206D_202E_206C_206D_200E_200E_202C_200D_206F_206E_200F_206A_206F_200E_200C_200E_202B_200D_200E_206D_200B_200D_202A_206E_206E_206D_206F_206F_206C_206D_206D_206A_206D_200F_200F_202E((Component)(object)this)), (Object)null))
				{
					num = 1513126631;
					continue;
				}
				goto IL_05c7;
			case 1u:
				isBind = true;
				IsOn(flag2);
				num = (int)((num2 * 237059581) ^ 0x4C4809EE);
				continue;
			case 7u:
			{
				int num25;
				int num26;
				if (skillSelectItemUI.GetSkill() == skillBox)
				{
					num25 = 997810892;
					num26 = num25;
				}
				else
				{
					num25 = 1578470406;
					num26 = num25;
				}
				num = num25 ^ (int)(num2 * 2101678785);
				continue;
			}
			case 15u:
				flag2 = _202D_202D_206C_200C_202C_200D_202A_206C_200B_202A_200C_202C_200F_206D_200E_206E_202E_206A_202A_202C_202B_202D_200F_206C_202A_206F_206A_206A_202C_202C_206C_206B_202D_202D_200F_202B_200B_202E_202A_200F_202E(((Component)_200F_206D_200E_206E_206C_202A_206A_200F_202B_200E_202E_202D_202D_202D_202A_200C_202B_200D_206B_202E_200D_206D_202E_202E_206C_200D_206C_202E_206B_206E_200D_202A_206A_200E_200F_200B_206D_202A_200E_200F_202E(_206A_200E_206C_206F_206E_206D_202E_206C_206D_200E_200E_202C_200D_206F_206E_200F_206A_206F_200E_200C_200E_202B_200D_200E_206D_200B_200D_202A_206E_206E_206D_206F_206F_206C_206D_206D_206A_206D_200F_200F_202E((Component)(object)this), global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(774194531u))).GetComponent<Toggle>());
				num = (int)((num2 * 1560719065) ^ 0x21A9ED7A);
				continue;
			case 9u:
				goto IL_0254;
			case 4u:
			{
				int num21;
				int num22;
				if (skillBox.SkillType != SkillType.Title)
				{
					num21 = 1928603478;
					num22 = num21;
				}
				else
				{
					num21 = 1137177052;
					num22 = num21;
				}
				num = num21 ^ (int)(num2 * 786948501);
				continue;
			}
			case 11u:
				goto IL_0293;
			case 2u:
				skillBox.equipped = (flag2 ? 1 : 0);
				num = 1404003772;
				continue;
			case 8u:
				skillBox.Owner.SetEquippedTitle(skillBox as TitleInstance);
				num = ((int)num2 * -45968005) ^ 0x18774C06;
				continue;
			case 10u:
				skillSelectItemUI.IsOn(skillSelectItemUI.GetSkill().equipped > 0);
				skillSelectItemUI.SetIsBind(isBind: false);
				num = (int)((num2 * 1376803150) ^ 0x6062269F);
				continue;
			case 12u:
				skillSelectItemUI.SetIsBind(isBind: true);
				num = ((int)num2 * -1198274951) ^ 0x76C3576B;
				continue;
			default:
			{
				bool flag = false;
				using (List<SkillInstance>.Enumerator enumerator = skillBox.Owner.Skills.GetEnumerator())
				{
					while (true)
					{
						IL_0399:
						int num3;
						int num4;
						if (enumerator.MoveNext())
						{
							num3 = 1905760287;
							num4 = num3;
						}
						else
						{
							num3 = 501908251;
							num4 = num3;
						}
						while (true)
						{
							switch ((num2 = (uint)(num3 ^ 0x7F7CB1E5)) % 7)
							{
							case 3u:
								num3 = 1905760287;
								continue;
							default:
								goto end_IL_0345;
							case 0u:
							{
								int num7;
								int num8;
								if (current.IsUsed)
								{
									num7 = -1855511866;
									num8 = num7;
								}
								else
								{
									num7 = -353993229;
									num8 = num7;
								}
								num3 = num7 ^ (int)(num2 * 1967649542);
								continue;
							}
							case 6u:
								break;
							case 4u:
								flag = true;
								goto end_IL_0345;
							case 2u:
								current = enumerator.Current;
								num3 = 632579546;
								continue;
							case 1u:
							{
								int num5;
								int num6;
								if (current == null)
								{
									num5 = -2040437528;
									num6 = num5;
								}
								else
								{
									num5 = -1900510124;
									num6 = num5;
								}
								num3 = num5 ^ ((int)num2 * -2140542831);
								continue;
							}
							case 5u:
								goto end_IL_0345;
							}
							goto IL_0399;
							continue;
							end_IL_0345:
							break;
						}
						break;
					}
				}
				if (!flag)
				{
					goto IL_0416;
				}
				goto IL_05c7;
			}
			case 6u:
				goto IL_05c7;
				IL_041b:
				while (true)
				{
					switch ((num2 = (uint)(num10 ^ 0x7F7CB1E5)) % 24)
					{
					case 21u:
						break;
					default:
						return;
					case 22u:
						num10 = (int)((num2 * 749369473) ^ 0x6BF13C89);
						continue;
					case 20u:
						IsOn(isOn: true);
						num10 = (int)(num2 * 1110113310) ^ -963883726;
						continue;
					case 15u:
						num10 = ((int)num2 * -1211864604) ^ 0x1D7B4E9B;
						continue;
					case 23u:
						isBind = false;
						flag3 = false;
						num10 = ((int)num2 * -427176803) ^ 0x5C1470D9;
						continue;
					case 11u:
						skillBox.equipped = 1;
						isBind = true;
						num10 = (int)(num2 * 853170580) ^ -621770155;
						continue;
					case 5u:
						skillBox.Owner.SetEquippedInternalSkill(skillBox as InternalSkillInstance);
						num10 = 88131134;
						continue;
					case 9u:
						goto IL_0529;
					case 4u:
						skillBox.Owner.SetEquippedInternalSkill(skillBox as InternalSkillInstance);
						num10 = ((int)num2 * -1939098084) ^ 0x13C7E98;
						continue;
					case 3u:
						skillSelectItemUI2.SetIsBind(isBind: true);
						skillSelectItemUI2.IsOn(isOn: false);
						skillSelectItemUI2.SetIsBind(isBind: false);
						num10 = ((int)num2 * -9652790) ^ 0x520EE454;
						continue;
					case 16u:
					{
						int num13;
						int num14;
						if (skillSelectItemUI2.GetSkill() == skillBox)
						{
							num13 = -1858148886;
							num14 = num13;
						}
						else
						{
							num13 = -1572991338;
							num14 = num13;
						}
						num10 = num13 ^ (int)(num2 * 1778890616);
						continue;
					}
					case 18u:
						goto IL_05c7;
					case 13u:
						isBind = true;
						IsOn(isOn: true);
						isBind = false;
						flag3 = false;
						num10 = ((int)num2 * -352210009) ^ -934643152;
						continue;
					case 8u:
					{
						int num17;
						int num18;
						if (!_202C_202D_202B_202B_206E_206F_200E_202C_206E_202D_206A_206A_206D_200E_202C_200D_202E_202B_202B_206C_206F_200F_206F_206C_200F_202E_206F_206C_200C_202B_206A_206C_200F_200F_206C_202C_202E_202A_206E_202D_202E((Object)(object)componentInParent, (Object)null))
						{
							num17 = 1540872799;
							num18 = num17;
						}
						else
						{
							num17 = 1427151604;
							num18 = num17;
						}
						num10 = num17 ^ (int)(num2 * 833872909);
						continue;
					}
					case 6u:
						goto IL_062f;
					case 14u:
						componentInParent = ((Component)this).GetComponentInParent<RolePanelUI>();
						num10 = ((int)num2 * -565729598) ^ -152015399;
						continue;
					case 2u:
						goto IL_0665;
					case 7u:
						num9++;
						num10 = 2037298883;
						continue;
					case 0u:
						componentsInChildren = ((Component)_206B_200D_206E_202A_206C_206A_206F_200D_202C_206B_206C_200B_202A_200F_200E_200E_202E_206E_200C_202A_202D_206E_202B_202B_206E_200E_200C_200E_206A_206C_202B_206C_200F_206F_206D_202C_202D_200B_206A_206F_202E(_206A_200E_206C_206F_206E_206D_202E_206C_206D_200E_200E_202C_200D_206F_206E_200F_206A_206F_200E_200C_200E_202B_200D_200E_206D_200B_200D_202A_206E_206E_206D_206F_206F_206C_206D_206D_206A_206D_200F_200F_202E((Component)(object)this))).GetComponentsInChildren<SkillSelectItemUI>();
						num9 = 0;
						num10 = (int)(num2 * 1925580695) ^ -1971850869;
						continue;
					case 17u:
						componentInParent.Refresh2(refreshImage: false, refreshText: true, refreshZhuangbei: false, refreshSkills: false, refreshTalents: true);
						num10 = (int)(num2 * 1302935403) ^ -802106460;
						continue;
					case 12u:
					{
						int num15;
						int num16;
						if (skillBox == skillBox.Owner.GetEquippedInternalSkill())
						{
							num15 = 1700466845;
							num16 = num15;
						}
						else
						{
							num15 = 370918131;
							num16 = num15;
						}
						num10 = num15 ^ (int)(num2 * 1415537357);
						continue;
					}
					case 10u:
						RuntimeData.Instance.RefreshTeamMemberPanel(skillBox.Owner, refreshImage: false, refreshText: true);
						num10 = 645566748;
						continue;
					case 19u:
					{
						int num11;
						int num12;
						if (!_202C_202D_202B_202B_206E_206F_200E_202C_206E_202D_206A_206A_206D_200E_202C_200D_202E_202B_202B_206C_206F_200F_206F_206C_200F_202E_206F_206C_200C_202B_206A_206C_200F_200F_206C_202C_202E_202A_206E_202D_202E((Object)(object)_206B_200D_206E_202A_206C_206A_206F_200D_202C_206B_206C_200B_202A_200F_200E_200E_202E_206E_200C_202A_202D_206E_202B_202B_206E_200E_200C_200E_206A_206C_202B_206C_200F_206F_206D_202C_202D_200B_206A_206F_202E(_206A_200E_206C_206F_206E_206D_202E_206C_206D_200E_200E_202C_200D_206F_206E_200F_206A_206F_200E_200C_200E_202B_200D_200E_206D_200B_200D_202A_206E_206E_206D_206F_206F_206C_206D_206D_206A_206D_200F_200F_202E((Component)(object)this)), (Object)null))
						{
							num11 = 1431061944;
							num12 = num11;
						}
						else
						{
							num11 = 511396258;
							num12 = num11;
						}
						num10 = num11 ^ (int)(num2 * 143665901);
						continue;
					}
					case 1u:
						return;
					}
					break;
					IL_062f:
					int num19;
					if (num9 >= componentsInChildren.Length)
					{
						num10 = 228107783;
						num19 = num10;
					}
					else
					{
						num10 = 196757660;
						num19 = num10;
					}
					continue;
					IL_0529:
					skillSelectItemUI2 = componentsInChildren[num9];
					int num20;
					if (!skillSelectItemUI2.GetSkill().IsInternal)
					{
						num10 = 480231402;
						num20 = num10;
					}
					else
					{
						num10 = 1099446565;
						num20 = num10;
					}
				}
				goto IL_0416;
				IL_0416:
				num10 = 490348598;
				goto IL_041b;
				IL_05c7:
				if (!flag3)
				{
					num10 = 645566748;
					num27 = num10;
				}
				else
				{
					num10 = 843744771;
					num27 = num10;
				}
				goto IL_041b;
				IL_0665:
				if (!flag2)
				{
					num10 = 848720161;
					num28 = num10;
				}
				else
				{
					num10 = 2062809912;
					num28 = num10;
				}
				goto IL_041b;
			}
			break;
			IL_00f4:
			int num29;
			if (num9 < componentsInChildren.Length)
			{
				num = 400831412;
				num29 = num;
			}
			else
			{
				num = 1170838779;
				num29 = num;
			}
			continue;
			IL_00ab:
			skillSelectItemUI = componentsInChildren[num9];
			int num30;
			if (skillSelectItemUI.GetSkill().SkillType == SkillType.Title)
			{
				num = 1802113002;
				num30 = num;
			}
			else
			{
				num = 1895052675;
				num30 = num;
			}
		}
		goto IL_000b;
		IL_0297:
		int num31;
		flag3 = (byte)num31 != 0;
		num = 1555431930;
		goto IL_0010;
		IL_0293:
		num31 = 0;
		goto IL_0297;
		IL_0254:
		skillBox = _206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E;
		if (skillBox.IsSpecial)
		{
			num = 96067654;
			goto IL_0010;
		}
		num31 = 1;
		goto IL_0297;
	}

	public void OnSkillInfoClicked()
	{
		if (_206A_202C_206D_202B_200F_200D_206D_202B_202A_206B_202E_202D_206A_200E_200C_200C_202A_202B_202E_206B_206E_202C_206E_202C_200B_202D_202B_202E_200E_202C_202E_206E_206D_206E_200E_202E_200B_206A_202D_202D_202E != SelectItemMode.SEEDETAIL)
		{
			return;
		}
		while (true)
		{
			int num = 991615460;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x79CD871)) % 5)
				{
				case 3u:
					break;
				default:
					return;
				case 0u:
					DetailPanel.Show(_206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E, delegate
					{
						GameObject rolePanel = RuntimeData.Instance.mapUI.RolePanel;
						if (_202C_202D_202B_202B_206E_206F_200E_202C_206E_202D_206A_206A_206D_200E_202C_200D_202E_202B_202B_206C_206F_200F_206F_206C_200F_202E_206F_206C_200C_202B_206A_206C_200F_200F_206C_202C_202E_202A_206E_202D_202E((Object)(object)rolePanel, (Object)null))
						{
							while (true)
							{
								int num5 = -994093040;
								while (true)
								{
									uint num6;
									switch ((num6 = (uint)(num5 ^ -1516853187)) % 7)
									{
									case 0u:
										break;
									default:
										return;
									case 4u:
										rolePanel.GetComponent<RolePanelUI>().ConfirmPanelObj.GetComponent<ConfirmPanel>().Show(_206E_200F_206D_202B_200F_202B_200F_200B_202E_206B_206F_200B_206A_202E_206D_200B_200D_200C_202B_200E_202B_200E_206A_200E_206C_206C_200C_202A_206C_200B_206D_202A_206B_206E_202B_206C_200E_202B_206E_206A_202E(ResourceStrings.ResStrings[1350], (object)_206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E.Name), delegate
										{
											try
											{
												_202B_206F_202B_200C_206D_202E_202E_202A_202A_202D_200D_202D_206A_206F_202E_200F_200C_202D_206A_200C_202A_200C_202D_206C_206B_206E_200E_202C_200F_200D_202E_200D_206E_202D_202A_202D_202B_206A_206C_202A_202E((MonoBehaviour)(object)this, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(300745180u), 0f);
											}
											catch
											{
											}
										});
										num5 = -904256718;
										continue;
									case 6u:
										_206F_206E_200F_206F_200B_202B_206C_200F_202D_206F_206A_200D_206A_200F_206C_206E_202B_200E_202C_206B_200D_200F_202C_206F_200D_202D_206F_202A_200E_202C_206E_206B_202C_202B_206F_200E_202E_206D_200C_200F_202E((Object)(object)rolePanel.GetComponent<RolePanelUI>().ConfirmPanelObj, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2564646171u));
										num5 = ((int)num6 * -1137471481) ^ -2132988831;
										continue;
									case 2u:
									{
										ref GameObject confirmPanelObj = ref rolePanel.GetComponent<RolePanelUI>().ConfirmPanelObj;
										Object obj = _200B_200F_206B_202A_206D_202D_206B_206D_206E_202E_202A_202B_200F_206E_202C_202A_202A_206A_200F_206A_200F_200C_206D_200F_200C_202A_206E_200D_200F_206B_206E_200C_200B_200C_200E_200C_202A_206B_202E_200E_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2299931625u));
										confirmPanelObj = Object.Instantiate<GameObject>((GameObject)(object)((obj is GameObject) ? obj : null));
										num5 = ((int)num6 * -374067158) ^ 0x71FEDC72;
										continue;
									}
									case 1u:
									{
										int num7;
										int num8;
										if (_206E_200C_206E_200F_200C_206B_206D_202D_200F_206B_202E_202C_202B_206C_206A_200F_206C_206D_200F_200B_202C_206A_200E_206E_206B_202B_202A_200E_202D_206F_206A_202E_200F_206B_202A_206C_206E_206E_202C_200E_202E((Object)(object)rolePanel.GetComponent<RolePanelUI>().ConfirmPanelObj, (Object)null))
										{
											num7 = 1399665978;
											num8 = num7;
										}
										else
										{
											num7 = 817729923;
											num8 = num7;
										}
										num5 = num7 ^ (int)(num6 * 1640392248);
										continue;
									}
									case 5u:
										_202C_200B_206A_200B_206B_200C_202E_202D_202C_202A_202B_206D_202D_206B_206E_206F_206E_200C_202A_202A_202D_202C_206C_206D_206C_202E_206F_200F_202C_206F_200E_200B_200D_206D_200E_202C_202D_206A_206B_206B_202E(_202C_206E_206A_202D_200F_206C_202C_200D_206E_200C_200C_200F_206B_206B_206F_200C_200D_206A_206B_206C_206E_206C_200C_202A_200D_202E_200E_206F_206D_200E_200C_200E_200C_202C_206D_200D_200B_200C_200C_200C_202E(rolePanel.GetComponent<RolePanelUI>().ConfirmPanelObj), _200F_206D_200E_206E_206C_202A_206A_200F_202B_200E_202E_202D_202D_202D_202A_200C_202B_200D_206B_202E_200D_206D_202E_202E_206C_200D_206C_202E_206B_206E_200D_202A_206A_200E_200F_200B_206D_202A_200E_200F_202E(_206F_202C_206E_206B_202D_202E_206A_200E_202C_202D_206A_200B_200F_202E_206C_206C_202A_206A_206A_202A_206C_206D_206F_202C_206E_202C_202B_202D_200D_206A_202D_206A_202B_206F_200B_202B_202A_206D_200C_206E_202E((Component)(object)RuntimeData.Instance.mapUI), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3549014450u)));
										_202B_202A_202B_206B_200E_202A_206A_206D_200E_206D_200B_206B_200D_202A_206A_202C_206B_202E_200E_206E_206D_202E_202D_200C_200D_202D_200F_206D_202A_202A_206E_200E_206E_202A_202E_206E_200F_202E_206B_200E_202E(rolePanel.GetComponent<RolePanelUI>().ConfirmPanelObj, false);
										num5 = ((int)num6 * -1053195092) ^ -386374113;
										continue;
									case 3u:
										return;
									}
									break;
								}
							}
						}
					});
					num = 1515945796;
					continue;
				case 1u:
					DetailPanel.Show(_206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E);
					return;
				case 4u:
				{
					int num3;
					int num4;
					if (_200C_202D_200E_206C_206E_206B_206F_202A_202B_206B_202B_202E_206F_200D_206D_200B_202E_202E_200B_202A_206A_206D_202C_202A_206E_200D_202A_200F_206B_202C_202E_202D_206C_202E_206F_202B_202E_202D_206B_202B_202E(_200D_202B_200D_206C_202B_206D_206B_200E_202A_202E_202B_202C_202C_206E_200F_206A_202B_206C_200C_202B_200F_200D_200C_200E_200B_200B_200C_200F_206E_200E_200F_206D_206C_206F_206E_202B_206A_200F_206F_206F_202E(), global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2652122091u)))
					{
						num3 = -1825607200;
						num4 = num3;
					}
					else
					{
						num3 = -960445073;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -419184514);
					continue;
				}
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void Start()
	{
		if (!CommonSettings.USE_SYSTEM_FONT)
		{
			return;
		}
		while (true)
		{
			int num = -244678152;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1714396067)) % 4)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					_202C_202A_202D_200C_202B_202A_200F_202B_206A_206A_200B_200B_202E_206E_202A_206F_206C_206A_200E_206C_206E_202B_202C_200C_206B_202E_200D_200C_206D_206B_206E_202E_202E_202A_206A_206C_206C_206F_206C_200F_202E(((Component)_200F_206D_200E_206E_206C_202A_206A_200F_202B_200E_202E_202D_202D_202D_202A_200C_202B_200D_206B_202E_200D_206D_202E_202E_206C_200D_206C_202E_206B_206E_200D_202A_206A_200E_200F_200B_206D_202A_200E_200F_202E(_206A_200E_206C_206F_206E_206D_202E_206C_206D_200E_200E_202C_200D_206F_206E_200F_206A_206F_200E_200C_200E_202B_200D_200E_206D_200B_200D_202A_206E_206E_206D_206F_206F_206C_206D_206D_206A_206D_200F_200F_202E((Component)(object)this), global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3511071004u))).GetComponent<Text>(), ModEditorResourceManager.GetFont(CommonSettings.SYSTEM_FONT_NAME));
					num = (int)((num2 * 968890224) ^ 0x2C01B346);
					continue;
				case 3u:
					_202C_202A_202D_200C_202B_202A_200F_202B_206A_206A_200B_200B_202E_206E_202A_206F_206C_206A_200E_206C_206E_202B_202C_200C_206B_202E_200D_200C_206D_206B_206E_202E_202E_202A_206A_206C_206C_206F_206C_200F_202E(((Component)_200F_206D_200E_206E_206C_202A_206A_200F_202B_200E_202E_202D_202D_202D_202A_200C_202B_200D_206B_202E_200D_206D_202E_202E_206C_200D_206C_202E_206B_206E_200D_202A_206A_200E_200F_200B_206D_202A_200E_200F_202E(_206A_200E_206C_206F_206E_206D_202E_206C_206D_200E_200E_202C_200D_206F_206E_200F_206A_206F_200E_200C_200E_202B_200D_200E_206D_200B_200D_202A_206E_206E_206D_206F_206F_206C_206D_206D_206A_206D_200F_200F_202E((Component)(object)this), global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3548806497u))).GetComponent<Text>(), ModEditorResourceManager.GetFont(CommonSettings.SYSTEM_FONT_NAME));
					num = (int)((num2 * 115314442) ^ 0x5FFDDFDB);
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void Update()
	{
	}

	public void SetIsBind(bool isBind)
	{
		this.isBind = isBind;
	}

	private void removeSkill()
	{
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		if (_206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E == null)
		{
			goto IL_0011;
		}
		goto IL_0128;
		IL_0011:
		int num = -1001641310;
		goto IL_0016;
		IL_0016:
		GameObject rolePanel = default(GameObject);
		string name = default(string);
		bool flag = default(bool);
		Role role = default(Role);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1126113945)) % 20)
			{
			case 2u:
				break;
			default:
				return;
			case 8u:
				goto IL_007c;
			case 11u:
				rolePanel = RuntimeData.Instance.mapUI.RolePanel;
				num = (int)((num2 * 955857249) ^ 0x70E1EC17);
				continue;
			case 14u:
				num = (int)(num2 * 1564012395) ^ -63415463;
				continue;
			case 4u:
				goto IL_00d4;
			case 15u:
			{
				int num5;
				int num6;
				if (_206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E.IsInternal)
				{
					num5 = -67353386;
					num6 = num5;
				}
				else
				{
					num5 = -1245994743;
					num6 = num5;
				}
				num = num5 ^ ((int)num2 * -1676441303);
				continue;
			}
			case 13u:
				num = (int)(num2 * 1406649685) ^ -1610455894;
				continue;
			case 19u:
				goto IL_0128;
			case 5u:
				goto IL_0145;
			case 1u:
				return;
			case 7u:
			{
				int num7;
				int num8;
				if (!_206B_206B_206A_206B_206C_206D_206B_206E_202C_206B_200D_200E_206A_200B_200D_202A_202C_202B_200F_202B_206A_206D_200B_202D_206C_200D_200D_206A_206C_202E_200E_200C_206D_200D_202C_202D_202E_206E_202C_200F_202E(rolePanel))
				{
					num7 = -455044757;
					num8 = num7;
				}
				else
				{
					num7 = -469403710;
					num8 = num7;
				}
				num = num7 ^ ((int)num2 * -2014790676);
				continue;
			}
			case 9u:
				rolePanel.GetComponent<RolePanelUI>().Refresh2(refreshImage: false, refreshText: true, refreshZhuangbei: false, refreshSkills: true, refreshTalents: true);
				num = ((int)num2 * -769603155) ^ 0x654FF8E2;
				continue;
			case 0u:
				name = _206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E.Name;
				num = (int)((num2 * 565218582) ^ 0x17DFE40C);
				continue;
			case 3u:
				flag = true;
				num = (int)(num2 * 2123835018) ^ -431750860;
				continue;
			case 6u:
			{
				int num3;
				int num4;
				if (_202C_202D_202B_202B_206E_206F_200E_202C_206E_202D_206A_206A_206D_200E_202C_200D_202E_202B_202B_206C_206F_200F_206F_206C_200F_202E_206F_206C_200C_202B_206A_206C_200F_200F_206C_202C_202E_202A_206E_202D_202E((Object)(object)RuntimeData.Instance.mapUI, (Object)null))
				{
					num3 = 1451666520;
					num4 = num3;
				}
				else
				{
					num3 = 624198295;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 792874704);
				continue;
			}
			case 17u:
			{
				SkillInstance item = (SkillInstance)_206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E;
				role.Skills.Remove(item);
				flag = true;
				num = ((int)num2 * -855772843) ^ 0x7F54B21E;
				continue;
			}
			case 18u:
				role.InternalSkills.Remove((InternalSkillInstance)_206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E);
				num = (int)((num2 * 718405471) ^ 0x1D53F6EA);
				continue;
			case 16u:
				RuntimeData.Instance.mapUI.messageBox.Show(ResourceStrings.ResStrings[6], _202C_200F_200B_202B_200C_206F_200D_200D_206E_202D_200F_202E_202C_200F_202D_202E_200E_200B_200D_200B_200C_206D_200D_206F_206C_206D_200C_202D_202B_206D_202B_206C_200C_206E_202C_202D_206E_206C_206D_200E_202E(ResourceStrings.ResStrings[107], (object)role.Name, (object)name), Color.white, delegate
				{
					RuntimeData.Instance.RefreshTeamMemberPanel(role, refreshImage: false, refreshText: true);
				}, ResourceStrings.ResStrings[75]);
				num = -951361609;
				continue;
			case 10u:
				role.SpecialSkills.Remove((SpecialSkillInstance)_206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E);
				flag = true;
				num = (int)(num2 * 7076229) ^ -946545585;
				continue;
			case 12u:
				return;
			}
			break;
			IL_0145:
			int num9;
			if (_206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E.IsSpecial)
			{
				num = -1534943647;
				num9 = num;
			}
			else
			{
				num = -1970856557;
				num9 = num;
			}
			continue;
			IL_00d4:
			int num10;
			if (!flag)
			{
				num = -951361609;
				num10 = num;
			}
			else
			{
				num = -1723997763;
				num10 = num;
			}
			continue;
			IL_007c:
			int num11;
			if (_206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E.SkillType != SkillType.Normal)
			{
				num = -1412335413;
				num11 = num;
			}
			else
			{
				num = -2073121050;
				num11 = num;
			}
		}
		goto IL_0011;
		IL_0128:
		flag = false;
		role = _206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E.Owner;
		num = -1489742069;
		goto IL_0016;
	}

	[CompilerGenerated]
	private void _206E_200D_202E_200B_206C_206D_200F_202A_206D_206C_206E_206D_200F_200F_202E_200F_202A_202B_202A_202B_202D_200F_206C_206C_206A_206D_202B_206B_202B_206B_206F_206A_202A_200C_206C_200B_200C_202A_200E_200F_202E()
	{
		GameObject rolePanel = RuntimeData.Instance.mapUI.RolePanel;
		if (!_202C_202D_202B_202B_206E_206F_200E_202C_206E_202D_206A_206A_206D_200E_202C_200D_202E_202B_202B_206C_206F_200F_206F_206C_200F_202E_206F_206C_200C_202B_206A_206C_200F_200F_206C_202C_202E_202A_206E_202D_202E((Object)(object)rolePanel, (Object)null))
		{
			return;
		}
		while (true)
		{
			int num = -994093040;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1516853187)) % 7)
				{
				case 0u:
					break;
				default:
					return;
				case 4u:
					rolePanel.GetComponent<RolePanelUI>().ConfirmPanelObj.GetComponent<ConfirmPanel>().Show(_206E_200F_206D_202B_200F_202B_200F_200B_202E_206B_206F_200B_206A_202E_206D_200B_200D_200C_202B_200E_202B_200E_206A_200E_206C_206C_200C_202A_206C_200B_206D_202A_206B_206E_202B_206C_200E_202B_206E_206A_202E(ResourceStrings.ResStrings[1350], (object)_206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E.Name), delegate
					{
						try
						{
							_202B_206F_202B_200C_206D_202E_202E_202A_202A_202D_200D_202D_206A_206F_202E_200F_200C_202D_206A_200C_202A_200C_202D_206C_206B_206E_200E_202C_200F_200D_202E_200D_206E_202D_202A_202D_202B_206A_206C_202A_202E((MonoBehaviour)(object)this, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(300745180u), 0f);
						}
						catch
						{
						}
					});
					num = -904256718;
					continue;
				case 6u:
					_206F_206E_200F_206F_200B_202B_206C_200F_202D_206F_206A_200D_206A_200F_206C_206E_202B_200E_202C_206B_200D_200F_202C_206F_200D_202D_206F_202A_200E_202C_206E_206B_202C_202B_206F_200E_202E_206D_200C_200F_202E((Object)(object)rolePanel.GetComponent<RolePanelUI>().ConfirmPanelObj, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2564646171u));
					num = ((int)num2 * -1137471481) ^ -2132988831;
					continue;
				case 2u:
				{
					ref GameObject confirmPanelObj = ref rolePanel.GetComponent<RolePanelUI>().ConfirmPanelObj;
					Object obj = _200B_200F_206B_202A_206D_202D_206B_206D_206E_202E_202A_202B_200F_206E_202C_202A_202A_206A_200F_206A_200F_200C_206D_200F_200C_202A_206E_200D_200F_206B_206E_200C_200B_200C_200E_200C_202A_206B_202E_200E_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2299931625u));
					confirmPanelObj = Object.Instantiate<GameObject>((GameObject)(object)((obj is GameObject) ? obj : null));
					num = ((int)num2 * -374067158) ^ 0x71FEDC72;
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (_206E_200C_206E_200F_200C_206B_206D_202D_200F_206B_202E_202C_202B_206C_206A_200F_206C_206D_200F_200B_202C_206A_200E_206E_206B_202B_202A_200E_202D_206F_206A_202E_200F_206B_202A_206C_206E_206E_202C_200E_202E((Object)(object)rolePanel.GetComponent<RolePanelUI>().ConfirmPanelObj, (Object)null))
					{
						num3 = 1399665978;
						num4 = num3;
					}
					else
					{
						num3 = 817729923;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1640392248);
					continue;
				}
				case 5u:
					_202C_200B_206A_200B_206B_200C_202E_202D_202C_202A_202B_206D_202D_206B_206E_206F_206E_200C_202A_202A_202D_202C_206C_206D_206C_202E_206F_200F_202C_206F_200E_200B_200D_206D_200E_202C_202D_206A_206B_206B_202E(_202C_206E_206A_202D_200F_206C_202C_200D_206E_200C_200C_200F_206B_206B_206F_200C_200D_206A_206B_206C_206E_206C_200C_202A_200D_202E_200E_206F_206D_200E_200C_200E_200C_202C_206D_200D_200B_200C_200C_200C_202E(rolePanel.GetComponent<RolePanelUI>().ConfirmPanelObj), _200F_206D_200E_206E_206C_202A_206A_200F_202B_200E_202E_202D_202D_202D_202A_200C_202B_200D_206B_202E_200D_206D_202E_202E_206C_200D_206C_202E_206B_206E_200D_202A_206A_200E_200F_200B_206D_202A_200E_200F_202E(_206F_202C_206E_206B_202D_202E_206A_200E_202C_202D_206A_200B_200F_202E_206C_206C_202A_206A_206A_202A_206C_206D_206F_202C_206E_202C_202B_202D_200D_206A_202D_206A_202B_206F_200B_202B_202A_206D_200C_206E_202E((Component)(object)RuntimeData.Instance.mapUI), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3549014450u)));
					_202B_202A_202B_206B_200E_202A_206A_206D_200E_206D_200B_206B_200D_202A_206A_202C_206B_202E_200E_206E_206D_202E_202D_200C_200D_202D_200F_206D_202A_202A_206E_200E_206E_202A_202E_206E_200F_202E_206B_200E_202E(rolePanel.GetComponent<RolePanelUI>().ConfirmPanelObj, false);
					num = ((int)num2 * -1053195092) ^ -386374113;
					continue;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private void _202D_206B_202E_200F_206A_206C_200F_206B_206A_200F_206F_202E_200B_202C_202B_206A_202C_206E_200F_206D_200C_200B_200D_206C_206C_202E_206E_206D_200C_200B_200D_200B_202D_202C_206C_206D_200C_200F_200D_202E_202E()
	{
		try
		{
			_202B_206F_202B_200C_206D_202E_202E_202A_202A_202D_200D_202D_206A_206F_202E_200F_200C_202D_206A_200C_202A_200C_202D_206C_206B_206E_200E_202C_200F_200D_202E_200D_206E_202D_202A_202D_202B_206A_206C_202A_202E((MonoBehaviour)(object)this, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(300745180u), 0f);
		}
		catch
		{
		}
	}

	public void Bind2(Role role, bool isActive = true, GameObject previewPanel = null)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		_200D_202A_206F_206E_202B_202B_200D_206F_206A_200E_206C_200F_200C_206C_206F_202A_206C_202C_202D_200B_202D_202E_200B_206D_206A_200F_200B_200D_200B_202E_200E_206D_202B_206C_202B_206D_200F_200C_200F_200E_202E = role;
		_202B_200F_200F_206D_200E_200D_202D_206B_202D_206B_202C_200C_202E_206D_200C_202A_200F_206A_206E_206C_202C_200E_206E_200F_206E_206F_200D_206E_200E_202A_202B_200C_202A_200F_200F_206A_200E_206A_202E_200E_202E = previewPanel;
		while (true)
		{
			int num = -1478811268;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1392803932)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0030;
				default:
					_202E_202D_200E_200C_206A_200B_206F_200C_202E_202D_206C_200C_200C_206A_202B_202C_202A_202A_200E_202C_200C_202D_206F_200F_200F_206B_200E_206E_200E_200E_206A_206B_206F_206F_206E_206D_200E_206D_206E_206B_202E(((Component)_200F_206D_200E_206E_206C_202A_206A_200F_202B_200E_202E_202D_202D_202D_202A_200C_202B_200D_206B_202E_200D_206D_202E_202E_206C_200D_206C_202E_206B_206E_200D_202A_206A_200E_200F_200B_206D_202A_200E_200F_202E(_206A_200E_206C_206F_206E_206D_202E_206C_206D_200E_200E_202C_200D_206F_206E_200F_206A_206F_200E_200C_200E_202B_200D_200E_206D_200B_200D_202A_206E_206E_206D_206F_206F_206C_206D_206D_206A_206D_200F_200F_202E((Component)(object)this), global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(648958214u))).GetComponent<Image>(), Resource.GetHeadImage(role.Head, forceLoadFromResource: false));
					return;
				}
				break;
				IL_0030:
				Text component = ((Component)_200F_206D_200E_206E_206C_202A_206A_200F_202B_200E_202E_202D_202D_202D_202A_200C_202B_200D_206B_202E_200D_206D_202E_202E_206C_200D_206C_202E_206B_206E_200D_202A_206A_200E_200F_200B_206D_202A_200E_200F_202E(_206A_200E_206C_206F_206E_206D_202E_206C_206D_200E_200E_202C_200D_206F_206E_200F_206A_206F_200E_200C_200E_202B_200D_200E_206D_200B_200D_202A_206E_206E_206D_206F_206F_206C_206D_206D_206A_206D_200F_200F_202E((Component)(object)this), global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(410466760u))).GetComponent<Text>();
				_200C_206B_200D_200B_206A_202A_206A_200D_206C_200C_206E_202C_206C_200D_206B_200E_200C_206C_202B_206B_206E_202C_202B_206D_200E_206A_206C_202E_206D_202D_206A_200B_200C_202E_202D_202D_202A_202E_200F_206A_202E(component, role.Name);
				_202B_206E_206D_200C_206D_202D_206D_206A_206B_206A_200F_200B_202E_202D_206E_206C_202A_206F_206C_200B_200C_200B_202B_206B_200B_200D_202E_206E_202C_202D_202E_200B_206F_202D_206F_200D_200D_202B_200C_206F_202E((Graphic)(object)component, role.GetColor());
				num = ((int)num2 * -1090470681) ^ 0x31D0FA8E;
			}
		}
	}

	public Role GetRole()
	{
		return _200D_202A_206F_206E_202B_202B_200D_206F_206A_200E_206C_200F_200C_206C_206F_202A_206C_202C_202D_200B_202D_202E_200B_206D_206A_200F_200B_200D_200B_202E_200E_206D_202B_206C_202B_206D_200F_200C_200F_200E_202E;
	}

	static bool _202C_202D_202B_202B_206E_206F_200E_202C_206E_202D_206A_206A_206D_200E_202C_200D_202E_202B_202B_206C_206F_200F_206F_206C_200F_202E_206F_206C_200C_202B_206A_206C_200F_200F_206C_202C_202E_202A_206E_202D_202E(Object P_0, Object P_1)
	{
		return P_0 != P_1;
	}

	static string _202D_202B_200B_202E_206F_200B_206F_200D_206E_206D_200F_206A_202E_206C_202E_200B_206A_202E_202A_200D_202C_202D_200B_206F_206E_202D_206F_206B_202E_200C_202A_206F_202D_202B_206E_202B_202A_202E_202D_202B_202E(string P_0, string P_1, string P_2, string P_3)
	{
		return P_0 + P_1 + P_2 + P_3;
	}

	static Transform _206A_200E_206C_206F_206E_206D_202E_206C_206D_200E_200E_202C_200D_206F_206E_200F_206A_206F_200E_200C_200E_202B_200D_200E_206D_200B_200D_202A_206E_206E_206D_206F_206F_206C_206D_206D_206A_206D_200F_200F_202E(Component P_0)
	{
		return P_0.transform;
	}

	static Transform _200F_206D_200E_206E_206C_202A_206A_200F_202B_200E_202E_202D_202D_202D_202A_200C_202B_200D_206B_202E_200D_206D_202E_202E_206C_200D_206C_202E_206B_206E_200D_202A_206A_200E_200F_200B_206D_202A_200E_200F_202E(Transform P_0, string P_1)
	{
		return P_0.FindChild(P_1);
	}

	static string _206E_200F_206D_202B_200F_202B_200F_200B_202E_206B_206F_200B_206A_202E_206D_200B_200D_200C_202B_200E_202B_200E_206A_200E_206C_206C_200C_202A_206C_200B_206D_202A_206B_206E_202B_206C_200E_202B_206E_206A_202E(string P_0, object P_1)
	{
		return string.Format(P_0, P_1);
	}

	static void _200C_206B_200D_200B_206A_202A_206A_200D_206C_200C_206E_202C_206C_200D_206B_200E_200C_206C_202B_206B_206E_202C_202B_206D_200E_206A_206C_202E_206D_202D_206A_200B_200C_202E_202D_202D_202A_202E_200F_206A_202E(Text P_0, string P_1)
	{
		P_0.text = P_1;
	}

	static string _202A_202A_206B_206C_206E_206C_206A_206B_206D_200B_200F_206B_206E_206C_200F_202B_206A_200C_200E_206D_206E_202C_202C_202C_206D_200C_200D_202A_206C_206A_206D_202C_200D_200D_200C_206F_206D_200C_200C_206D_202E(string P_0, string P_1)
	{
		return P_0 + P_1;
	}

	static bool _200C_200C_200E_200C_202D_206A_200B_202E_202D_202D_200F_206D_206D_202C_206A_200C_206E_200E_200F_202A_206A_202D_206F_200E_200B_202E_200E_206F_202D_200D_202E_200B_206D_206B_200B_200F_202A_206A_202E_202C_202E(string P_0, string P_1)
	{
		return P_0.StartsWith(P_1);
	}

	static int _202D_206B_206B_202C_206A_202C_206A_200B_206B_200F_202A_206F_206D_202A_202E_200F_202B_200F_202A_206C_202D_206A_200C_202B_206D_206E_206C_200F_200E_206C_200E_200E_200B_200B_206C_202C_200F_206F_206B_200F_202E(string P_0)
	{
		return P_0.Length;
	}

	static string _202B_202E_206A_200F_202C_206A_200B_202B_202A_202B_200B_206F_206B_202A_202D_202B_202D_206A_202E_206E_202E_202D_206A_202A_200F_206D_200D_200B_202A_202E_200C_200E_206A_202D_200E_202B_200D_202B_206B_202C_202E(string P_0, int P_1, int P_2)
	{
		return P_0.Remove(P_1, P_2);
	}

	static string _202A_200F_202C_200D_206C_206F_206D_202D_206B_202B_200F_200F_206A_206C_200D_200D_206A_206F_202E_202C_206C_206A_202A_200B_206A_200E_200D_202D_202A_200C_206E_206B_206B_202D_200D_200B_200F_202C_202E_202E_202E(Text P_0)
	{
		return P_0.text;
	}

	static string _202D_206C_206F_202B_206C_202D_200B_200F_202C_206D_202D_202C_200D_202D_202D_202D_206A_200E_200F_206D_206B_202C_206E_202A_200D_206E_202C_200F_200C_200F_200B_206C_206F_202C_202B_200D_202B_200E_206F_206B_202E(string P_0, string P_1, string P_2)
	{
		return P_0 + P_1 + P_2;
	}

	static void _202B_206E_206D_200C_206D_202D_206D_206A_206B_206A_200F_200B_202E_202D_206E_206C_202A_206F_206C_200B_200C_200B_202B_206B_200B_200D_202E_206E_202C_202D_202E_200B_206F_202D_206F_200D_200D_202B_200C_206F_202E(Graphic P_0, Color P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.color = P_1;
	}

	static GameObject _202C_200F_202C_202B_200E_202B_202C_202C_206A_202E_206F_202B_202B_202E_206B_200C_206B_202A_206F_206D_206E_206E_206E_200E_202C_200D_202B_206E_200C_202B_202A_202D_202C_206A_200D_206D_202D_202A_200B_202C_202E(Component P_0)
	{
		return P_0.gameObject;
	}

	static void _202B_202A_202B_206B_200E_202A_206A_206D_200E_206D_200B_206B_200D_202A_206A_202C_206B_202E_200E_206E_206D_202E_202D_200C_200D_202D_200F_206D_202A_202A_206E_200E_206E_202A_202E_206E_200F_202E_206B_200E_202E(GameObject P_0, bool P_1)
	{
		P_0.SetActive(P_1);
	}

	static void _202E_202D_200E_200C_206A_200B_206F_200C_202E_202D_206C_200C_200C_206A_202B_202C_202A_202A_200E_202C_200C_202D_206F_200F_200F_206B_200E_206E_200E_200E_206A_206B_206F_206F_206E_206D_200E_206D_206E_206B_202E(Image P_0, Sprite P_1)
	{
		P_0.sprite = P_1;
	}

	static void _200D_200B_200C_200B_202B_206E_206A_206C_206A_202C_206B_206B_202E_206C_206E_200D_200B_200F_200E_206E_200F_200E_206D_206B_200E_206E_206F_206B_206B_206B_200E_206C_200E_206C_206F_202E_206F_202D_206A_200F_202E(Selectable P_0, bool P_1)
	{
		P_0.interactable = P_1;
	}

	static void _206F_202E_202E_200B_200E_202A_206C_206F_202C_200C_200D_200F_202E_202B_200D_200B_202E_206A_200D_202E_200C_206E_202A_200E_206A_200E_202C_200E_206D_200D_202B_202B_200D_202D_206B_202E_202D_202A_200C_206F_202E(Toggle P_0, bool P_1)
	{
		P_0.isOn = P_1;
	}

	static bool _202D_202D_206C_200C_202C_200D_202A_206C_200B_202A_200C_202C_200F_206D_200E_206E_202E_206A_202A_202C_202B_202D_200F_206C_202A_206F_206A_206A_202C_202C_206C_206B_202D_202D_200F_202B_200B_202E_202A_200F_202E(Toggle P_0)
	{
		return P_0.isOn;
	}

	static Transform _206B_200D_206E_202A_206C_206A_206F_200D_202C_206B_206C_200B_202A_200F_200E_200E_202E_206E_200C_202A_202D_206E_202B_202B_206E_200E_200C_200E_206A_206C_202B_206C_200F_206F_206D_202C_202D_200B_206A_206F_202E(Transform P_0)
	{
		return P_0.parent;
	}

	static string _200D_202B_200D_206C_202B_206D_206B_200E_202A_202E_202B_202C_202C_206E_200F_206A_202B_206C_200C_202B_200F_200D_200C_200E_200B_200B_200C_200F_206E_200E_200F_206D_206C_206F_206E_202B_206A_200F_206F_206F_202E()
	{
		return Application.loadedLevelName;
	}

	static bool _200C_202D_200E_206C_206E_206B_206F_202A_202B_206B_202B_202E_206F_200D_206D_200B_202E_202E_200B_202A_206A_206D_202C_202A_206E_200D_202A_200F_206B_202C_202E_202D_206C_202E_206F_202B_202E_202D_206B_202B_202E(string P_0, string P_1)
	{
		return P_0 != P_1;
	}

	static void _202C_202A_202D_200C_202B_202A_200F_202B_206A_206A_200B_200B_202E_206E_202A_206F_206C_206A_200E_206C_206E_202B_202C_200C_206B_202E_200D_200C_206D_206B_206E_202E_202E_202A_206A_206C_206C_206F_206C_200F_202E(Text P_0, Font P_1)
	{
		P_0.font = P_1;
	}

	static bool _206B_206B_206A_206B_206C_206D_206B_206E_202C_206B_200D_200E_206A_200B_200D_202A_202C_202B_200F_202B_206A_206D_200B_202D_206C_200D_200D_206A_206C_202E_200E_200C_206D_200D_202C_202D_202E_206E_202C_200F_202E(GameObject P_0)
	{
		return P_0.activeSelf;
	}

	static string _202C_200F_200B_202B_200C_206F_200D_200D_206E_202D_200F_202E_202C_200F_202D_202E_200E_200B_200D_200B_200C_206D_200D_206F_206C_206D_200C_202D_202B_206D_202B_206C_200C_206E_202C_202D_206E_206C_206D_200E_202E(string P_0, object P_1, object P_2)
	{
		return string.Format(P_0, P_1, P_2);
	}

	static bool _206E_200C_206E_200F_200C_206B_206D_202D_200F_206B_202E_202C_202B_206C_206A_200F_206C_206D_200F_200B_202C_206A_200E_206E_206B_202B_202A_200E_202D_206F_206A_202E_200F_206B_202A_206C_206E_206E_202C_200E_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static Object _200B_200F_206B_202A_206D_202D_206B_206D_206E_202E_202A_202B_200F_206E_202C_202A_202A_206A_200F_206A_200F_200C_206D_200F_200C_202A_206E_200D_200F_206B_206E_200C_200B_200C_200E_200C_202A_206B_202E_200E_202E(string P_0)
	{
		return Resources.Load(P_0);
	}

	static void _206F_206E_200F_206F_200B_202B_206C_200F_202D_206F_206A_200D_206A_200F_206C_206E_202B_200E_202C_206B_200D_200F_202C_206F_200D_202D_206F_202A_200E_202C_206E_206B_202C_202B_206F_200E_202E_206D_200C_200F_202E(Object P_0, string P_1)
	{
		P_0.name = P_1;
	}

	static Transform _202C_206E_206A_202D_200F_206C_202C_200D_206E_200C_200C_200F_206B_206B_206F_200C_200D_206A_206B_206C_206E_206C_200C_202A_200D_202E_200E_206F_206D_200E_200C_200E_200C_202C_206D_200D_200B_200C_200C_200C_202E(GameObject P_0)
	{
		return P_0.transform;
	}

	static Transform _206F_202C_206E_206B_202D_202E_206A_200E_202C_202D_206A_200B_200F_202E_206C_206C_202A_206A_206A_202A_206C_206D_206F_202C_206E_202C_202B_202D_200D_206A_202D_206A_202B_206F_200B_202B_202A_206D_200C_206E_202E(Component P_0)
	{
		return P_0.transform;
	}

	static void _202C_200B_206A_200B_206B_200C_202E_202D_202C_202A_202B_206D_202D_206B_206E_206F_206E_200C_202A_202A_202D_202C_206C_206D_206C_202E_206F_200F_202C_206F_200E_200B_200D_206D_200E_202C_202D_206A_206B_206B_202E(Transform P_0, Transform P_1)
	{
		P_0.SetParent(P_1);
	}

	static void _202B_206F_202B_200C_206D_202E_202E_202A_202A_202D_200D_202D_206A_206F_202E_200F_200C_202D_206A_200C_202A_200C_202D_206C_206B_206E_200E_202C_200F_200D_202E_200D_206E_202D_202A_202D_202B_206A_206C_202A_202E(MonoBehaviour P_0, string P_1, float P_2)
	{
		P_0.Invoke(P_1, P_2);
	}
}
