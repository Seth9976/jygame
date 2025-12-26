using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JyGame;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class BattleRoleListPanelUI : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _202D_206F_206C_202C_202D_202A_200B_200E_206D_200D_200B_202B_200C_206A_206B_206B_202D_202E_202D_200E_206F_206D_202E_200F_202A_200C_202E_202B_202E_200E_206C_200E_202D_200D_206A_206A_200F_202B_200E_200F_202E
	{
		internal Role role;

		internal BattleRoleListPanelUI _202A_202B_206D_202D_200C_202E_206F_200C_202B_202E_202E_206E_200D_206A_206F_206D_206F_200E_202C_206F_200B_206D_206B_202D_206C_206A_200D_200D_206D_200F_200F_206B_202A_202D_202A_200B_200F_200B_202C_202E_202E;

		internal void _206A_206C_202E_206E_200B_200B_200E_200D_206F_202E_202D_202E_206E_200F_206F_200E_200D_206C_202B_200E_206C_200B_200D_200C_202E_200C_202C_206E_202E_206B_202A_200D_206D_200B_202C_206E_206E_206F_206E_206A_202E()
		{
			_202A_202B_206D_202D_200C_202E_206F_200C_202B_202E_202E_206E_200D_206A_206F_206D_206F_200E_202C_206F_200B_206D_206B_202D_206C_206A_200D_200D_206D_200F_200F_206B_202A_202D_202A_200B_200F_200B_202C_202E_202E.RolePanelObj.GetComponent<RolePanelUI>().Show(role, null, isActive: false);
		}
	}

	[CompilerGenerated]
	private sealed class _206B_202E_202E_200E_200B_206B_206C_206C_200B_200C_206D_202A_202E_202E_206C_200C_200F_206A_202C_206A_202B_200F_200C_206E_206E_206F_202C_200E_200B_200C_202D_202D_206E_200F_202E_202D_202E_202B_202D_206A_202E
	{
		public Role role;

		public BattleRoleListPanelUI _202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E;

		internal void _206B_202C_206D_202E_206D_200E_206C_202C_206F_200B_206E_206E_200E_200F_206B_202A_206C_206D_206F_200F_200B_200F_200E_202E_202A_200F_206F_202A_200E_202A_200E_202E_200C_206B_206A_206F_202D_200D_206C_200C_202E()
		{
			_202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E.isShowRolePanel = true;
			_202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E.RolePanelObj.GetComponent<RolePanelUI>().Show(role, delegate
			{
				BattleRoleListPanelUI._206D_202B_206E_206B_202C_206B_206C_200E_206B_200F_202E_202C_206C_202C_202C_206D_202C_202A_206F_206F_202A_206C_200F_206B_206E_202B_200E_206C_202B_200C_200C_200B_206E_202B_206A_200F_202D_206E_202D_200F_202E((MonoBehaviour)(object)_202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3650005353u), 0.03f);
			}, isActive: false);
		}
	}

	public GameObject RoleItemObj;

	public GameObject SelectMenuObj;

	public GameObject RolePanelObj;

	private bool isShowRolePanel;

	private bool _200D_200E_206D_202C_200C_200D_202E_206F_202C_200F_206A_202A_202D_206D_202E_202C_206C_200D_202C_202A_206C_202B_200C_202B_202B_206C_202A_202C_200F_202C_202C_206D_200B_206C_202E_200E_200F_200F_202B_202E_202E;

	public void Show(IEnumerable<BattleSprite> sprites)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected O, but got Unknown
		if (!_200D_200E_206D_202C_200C_200D_202E_206F_202C_200F_206A_202A_202D_206D_202E_202C_206C_200D_202C_202A_206C_202B_200C_202B_202B_206C_202A_202C_200F_202C_202C_206D_200B_206C_202E_200E_200F_200F_202B_202E_202E)
		{
			goto IL_000b;
		}
		goto IL_0125;
		IL_000b:
		int num = 1539849143;
		goto IL_0010;
		IL_0010:
		SelectMenu component2 = default(SelectMenu);
		BattleSprite current = default(BattleSprite);
		_206B_202E_202E_200E_200B_206B_206C_206C_200B_200C_206D_202A_202E_202E_206C_200C_200F_206A_202C_206A_202B_200F_200C_206E_206E_206F_202C_200E_200B_200C_202D_202D_206E_200F_202E_202D_202E_202B_202D_206A_202E obj = default(_206B_202E_202E_200E_200B_206B_206C_206C_200B_200C_206D_202A_202E_202E_206C_200C_200F_206A_202C_206A_202B_200F_200C_206E_206E_206F_202C_200E_200B_200C_202D_202D_206E_200F_202E_202D_202E_202B_202D_206A_202E);
		GameObject val = default(GameObject);
		Text component = default(Text);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x5F9E7145)) % 9)
			{
			case 6u:
				break;
			case 7u:
				component2.Clear();
				num = ((int)num2 * -1983020082) ^ -441195970;
				continue;
			case 2u:
				((Component)_206B_200D_206E_206F_200F_202C_200F_202A_202B_202A_206B_206C_206A_206B_200E_200F_206A_202A_202A_202D_200C_202C_206B_206F_206B_202A_206E_200D_202E_202C_200F_202D_202C_200F_200B_202B_200E_200E_200C_206B_202E(_200F_206E_206C_206B_200D_200B_206B_200D_206A_206F_206B_200B_206D_200D_202A_206D_206A_206D_200D_200E_200E_206B_206F_206C_206E_206E_202B_206F_200D_206C_206A_200F_200F_202B_202D_202D_202A_206B_206E_202E(RoleItemObj), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2123386830u))).GetComponent<RectTransform>().sizeDelta = new Vector2(102.3f, 98.4f);
				num = ((int)num2 * -20173078) ^ -1850352438;
				continue;
			case 0u:
			{
				int num9;
				int num10;
				if (!CommonSettings.USE_SYSTEM_FONT)
				{
					num9 = 1830854377;
					num10 = num9;
				}
				else
				{
					num9 = 1601291105;
					num10 = num9;
				}
				num = num9 ^ (int)(num2 * 38505527);
				continue;
			}
			case 1u:
				_200D_200E_206D_202C_200C_200D_202E_206F_202C_200F_206A_202A_202D_206D_202E_202C_206C_200D_202C_202A_206C_202B_200C_202B_202B_206C_202A_202C_200F_202C_202C_206D_200B_206C_202E_200E_200F_200F_202B_202E_202E = true;
				num = ((int)num2 * -1848487383) ^ -840783219;
				continue;
			case 5u:
				((Component)RoleItemObj.transform.FindChild(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2510808305u))).GetComponent<Text>().font = ModEditorResourceManager.GetFont(CommonSettings.SYSTEM_FONT_NAME);
				num = (int)(num2 * 1908722498) ^ -656435674;
				continue;
			case 3u:
				goto IL_0125;
			case 8u:
				isShowRolePanel = false;
				num = (int)(num2 * 801754274) ^ -1817134858;
				continue;
			default:
			{
				IEnumerator<BattleSprite> enumerator = sprites.GetEnumerator();
				try
				{
					while (true)
					{
						IL_01dd:
						int num3;
						int num4;
						if (enumerator.MoveNext())
						{
							num3 = 289440196;
							num4 = num3;
						}
						else
						{
							num3 = 369490865;
							num4 = num3;
						}
						while (true)
						{
							switch ((num2 = (uint)(num3 ^ 0x5F9E7145)) % 14)
							{
							case 2u:
								num3 = 289440196;
								continue;
							default:
								goto end_IL_0163;
							case 1u:
								current = enumerator.Current;
								obj = new _206B_202E_202E_200E_200B_206B_206C_206C_200B_200C_206D_202A_202E_202E_206C_200C_200F_206A_202C_206A_202B_200F_200C_206E_206E_206F_202C_200E_200B_200C_202D_202D_206E_200F_202E_202D_202E_202B_202D_206A_202E();
								num3 = 664040433;
								continue;
							case 8u:
								component2.AddItem(val);
								num3 = ((int)num2 * -1483813671) ^ 0x4845EB49;
								continue;
							case 4u:
								break;
							case 3u:
								component.text = obj.role.Name.Substring(0, 6);
								num3 = ((int)num2 * -1312097021) ^ -513291309;
								continue;
							case 7u:
								obj.role = current.Role;
								val = Object.Instantiate<GameObject>(RoleItemObj);
								num3 = (int)(num2 * 1067495011) ^ -774247666;
								continue;
							case 6u:
								obj._202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E = this;
								num3 = ((int)num2 * -262588276) ^ -67996822;
								continue;
							case 0u:
								((Component)val.transform.FindChild(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2123386830u))).GetComponent<Image>().sprite = Resource.GetHeadImage(obj.role.Head, forceLoadFromResource: false);
								component = ((Component)val.transform.FindChild(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2712075045u))).GetComponent<Text>();
								num3 = ((int)num2 * -2049985634) ^ 0x797A562A;
								continue;
							case 13u:
								((Graphic)component).color = ((current.Team != 1) ? Color.red : Color.yellow);
								((UnityEvent)val.GetComponent<Button>().onClick).AddListener(new UnityAction(obj._206B_202C_206D_202E_206D_200E_206C_202C_206F_200B_206E_206E_200E_200F_206B_202A_206C_206D_206F_200F_200B_200F_200E_202E_202A_200F_206F_202A_200E_202A_200E_202E_200C_206B_206A_206F_202D_200D_206C_200C_202E));
								num3 = 1292740287;
								continue;
							case 12u:
								component.text = obj.role.Name;
								num3 = 2068745414;
								continue;
							case 9u:
							{
								int num5;
								int num6;
								if (obj.role.Name.Length <= 5)
								{
									num5 = 439554762;
									num6 = num5;
								}
								else
								{
									num5 = 231664291;
									num6 = num5;
								}
								num3 = num5 ^ (int)(num2 * 1794436609);
								continue;
							}
							case 5u:
								num3 = ((int)num2 * -475908210) ^ -865621940;
								continue;
							case 11u:
								component.fontSize = 22;
								num3 = (int)(num2 * 1781462070) ^ -1516503584;
								continue;
							case 10u:
								goto end_IL_0163;
							}
							goto IL_01dd;
							continue;
							end_IL_0163:
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
							IL_038f:
							int num7 = 326277676;
							while (true)
							{
								switch ((num2 = (uint)(num7 ^ 0x5F9E7145)) % 3)
								{
								case 0u:
									break;
								default:
									goto end_IL_0394;
								case 1u:
									goto IL_03b2;
								case 2u:
									goto end_IL_0394;
								}
								goto IL_038f;
								IL_03b2:
								enumerator.Dispose();
								num7 = ((int)num2 * -1112895365) ^ 0x1C57E9F5;
								continue;
								end_IL_0394:
								break;
							}
							break;
						}
					}
				}
				component2.Show(delegate
				{
					_206B_206D_206D_206A_206C_200E_206A_200C_200C_206C_202B_200E_206C_202D_202C_200D_200C_206C_206F_202D_206B_206F_200F_200E_202D_206A_200E_202C_202E_200D_200C_206A_206A_200D_200D_206C_202C_200D_202C_200D_202E(_206C_200D_202E_206A_206C_202B_200F_200C_206B_206E_200F_200C_206D_200B_206E_202B_206B_202E_200B_206E_202A_200B_206B_206B_202E_206A_202C_206C_206D_202E_206C_200F_202C_206D_200C_206D_200B_206D_206F_202E_202E((Component)(object)this), false);
				});
				while (true)
				{
					int num8 = 533835044;
					while (true)
					{
						switch ((num2 = (uint)(num8 ^ 0x5F9E7145)) % 3)
						{
						case 0u:
							break;
						default:
							return;
						case 1u:
							goto IL_03fe;
						case 2u:
							return;
						}
						break;
						IL_03fe:
						((Component)this).gameObject.SetActive(true);
						num8 = (int)(num2 * 870793373) ^ -1192745146;
					}
				}
			}
			}
			break;
		}
		goto IL_000b;
		IL_0125:
		component2 = SelectMenuObj.GetComponent<SelectMenu>();
		num = 963974973;
		goto IL_0010;
	}

	private void Start()
	{
	}

	private void Update()
	{
		if (!_206A_202C_206E_206B_202A_202E_206E_206D_206B_206F_206B_206B_206E_202A_202E_202B_202E_206E_206E_206F_202C_202C_206A_200F_202B_206F_206A_206E_206B_200D_200F_206E_202E_200F_202E_206E_202B_202B_202B_202E_202E((KeyCode)27))
		{
			goto IL_0009;
		}
		goto IL_0055;
		IL_0009:
		int num = -713025107;
		goto IL_000e;
		IL_000e:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1692850893)) % 6)
			{
			case 3u:
				break;
			default:
				return;
			case 5u:
				_206B_206D_206D_206A_206C_200E_206A_200C_200C_206C_202B_200E_206C_202D_202C_200D_200C_206C_206F_202D_206B_206F_200F_200E_202D_206A_200E_202C_202E_200D_200C_206A_206A_200D_200D_206C_202C_200D_202C_200D_202E(_206C_200D_202E_206A_206C_202B_200F_200C_206B_206E_200F_200C_206D_200B_206E_202B_206B_202E_200B_206E_202A_200B_206B_206B_202E_206A_202C_206C_206D_202E_206C_200F_202C_206D_200C_206D_200B_206D_206F_202E_202E((Component)(object)this), false);
				num = ((int)num2 * -692601411) ^ 0x4CDB9DB2;
				continue;
			case 1u:
				goto IL_0055;
			case 4u:
			{
				int num5;
				int num6;
				if (!isShowRolePanel)
				{
					num5 = 181977832;
					num6 = num5;
				}
				else
				{
					num5 = 258919773;
					num6 = num5;
				}
				num = num5 ^ (int)(num2 * 1105728434);
				continue;
			}
			case 2u:
			{
				int num3;
				int num4;
				if (_202D_202D_202A_206E_202D_200B_202E_200B_206C_202D_206C_202E_206C_200B_202C_202C_206D_206F_202B_202A_206F_206E_206E_206F_206C_202B_200D_202D_206C_202A_206C_206E_206A_202A_206C_200C_200F_206F_206E_202B_202E(1))
				{
					num3 = -819631268;
					num4 = num3;
				}
				else
				{
					num3 = -903245609;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 72257159);
				continue;
			}
			case 0u:
				return;
			}
			break;
		}
		goto IL_0009;
		IL_0055:
		int num7;
		if (!_206E_202A_206A_200B_202B_202D_206B_202B_206C_202B_200C_202D_202D_202D_200B_206F_200B_200E_206F_206D_206C_200D_202E_206A_200C_202E_206F_202A_200F_200D_202C_200E_206B_202A_200F_200E_200E_200D_206B_202B_202E(_206C_200D_202E_206A_206C_202B_200F_200C_206B_206E_200F_200C_206D_200B_206E_202B_206B_202E_200B_206E_202A_200B_206B_206B_202E_206A_202C_206C_206D_202E_206C_200F_202C_206D_200C_206D_200B_206D_206F_202E_202E((Component)(object)this)))
		{
			num = -1464136827;
			num7 = num;
		}
		else
		{
			num = -2046334337;
			num7 = num;
		}
		goto IL_000e;
	}

	[CompilerGenerated]
	private void _202A_206B_206E_200D_200C_206E_202E_206C_202B_206A_200F_206C_202B_200C_206F_206C_202C_206D_202E_202B_202A_200E_206F_202B_206A_200C_206E_206A_206C_206B_200D_202A_200C_206A_202A_202A_202E_202B_206E_206D_202E()
	{
		_206B_206D_206D_206A_206C_200E_206A_200C_200C_206C_202B_200E_206C_202D_202C_200D_200C_206C_206F_202D_206B_206F_200F_200E_202D_206A_200E_202C_202E_200D_200C_206A_206A_200D_200D_206C_202C_200D_202C_200D_202E(_206C_200D_202E_206A_206C_202B_200F_200C_206B_206E_200F_200C_206D_200B_206E_202B_206B_202E_200B_206E_202A_200B_206B_206B_202E_206A_202C_206C_206D_202E_206C_200F_202C_206D_200C_206D_200B_206D_206F_202E_202E((Component)(object)this), false);
	}

	private void RolePanelClosed()
	{
		isShowRolePanel = false;
	}

	[CompilerGenerated]
	private void _206C_200E_202D_206C_202A_202A_206E_200D_206E_206E_206D_206B_202E_200F_206D_200B_202A_200D_206B_200D_202E_200E_200B_206A_200C_206E_202D_206D_206A_202D_206F_206D_202B_206D_206C_206D_206C_202A_206D_206D_202E()
	{
		_206D_202B_206E_206B_202C_206B_206C_200E_206B_200F_202E_202C_206C_202C_202C_206D_202C_202A_206F_206F_202A_206C_200F_206B_206E_202B_200E_206C_202B_200C_200C_200B_206E_202B_206A_200F_202D_206E_202D_200F_202E((MonoBehaviour)(object)this, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3650005353u), 0.03f);
	}

	[CompilerGenerated]
	private void _200F_200E_206E_202D_200D_206A_206D_206F_202A_202C_202C_200D_200C_202E_206C_206F_200C_206B_206E_206F_200F_206D_206A_202E_206F_206D_200F_202C_200F_202D_202E_206F_206D_206C_200B_206A_206D_202B_202C_206F_202E()
	{
		_206B_206D_206D_206A_206C_200E_206A_200C_200C_206C_202B_200E_206C_202D_202C_200D_200C_206C_206F_202D_206B_206F_200F_200E_202D_206A_200E_202C_202E_200D_200C_206A_206A_200D_200D_206C_202C_200D_202C_200D_202E(_206C_200D_202E_206A_206C_202B_200F_200C_206B_206E_200F_200C_206D_200B_206E_202B_206B_202E_200B_206E_202A_200B_206B_206B_202E_206A_202C_206C_206D_202E_206C_200F_202C_206D_200C_206D_200B_206D_206F_202E_202E((Component)(object)this), false);
	}

	static Transform _200F_206E_206C_206B_200D_200B_206B_200D_206A_206F_206B_200B_206D_200D_202A_206D_206A_206D_200D_200E_200E_206B_206F_206C_206E_206E_202B_206F_200D_206C_206A_200F_200F_202B_202D_202D_202A_206B_206E_202E(GameObject P_0)
	{
		return P_0.transform;
	}

	static Transform _206B_200D_206E_206F_200F_202C_200F_202A_202B_202A_206B_206C_206A_206B_200E_200F_206A_202A_202A_202D_200C_202C_206B_206F_206B_202A_206E_200D_202E_202C_200F_202D_202C_200F_200B_202B_200E_200E_200C_206B_202E(Transform P_0, string P_1)
	{
		return P_0.FindChild(P_1);
	}

	static bool _206A_202C_206E_206B_202A_202E_206E_206D_206B_206F_206B_206B_206E_202A_202E_202B_202E_206E_206E_206F_202C_202C_206A_200F_202B_206F_206A_206E_206B_200D_200F_206E_202E_200F_202E_206E_202B_202B_202B_202E_202E(KeyCode P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Input.GetKeyDown(P_0);
	}

	static bool _202D_202D_202A_206E_202D_200B_202E_200B_206C_202D_206C_202E_206C_200B_202C_202C_206D_206F_202B_202A_206F_206E_206E_206F_206C_202B_200D_202D_206C_202A_206C_206E_206A_202A_206C_200C_200F_206F_206E_202B_202E(int P_0)
	{
		return Input.GetMouseButtonDown(P_0);
	}

	static GameObject _206C_200D_202E_206A_206C_202B_200F_200C_206B_206E_200F_200C_206D_200B_206E_202B_206B_202E_200B_206E_202A_200B_206B_206B_202E_206A_202C_206C_206D_202E_206C_200F_202C_206D_200C_206D_200B_206D_206F_202E_202E(Component P_0)
	{
		return P_0.gameObject;
	}

	static bool _206E_202A_206A_200B_202B_202D_206B_202B_206C_202B_200C_202D_202D_202D_200B_206F_200B_200E_206F_206D_206C_200D_202E_206A_200C_202E_206F_202A_200F_200D_202C_200E_206B_202A_200F_200E_200E_200D_206B_202B_202E(GameObject P_0)
	{
		return P_0.activeSelf;
	}

	static void _206B_206D_206D_206A_206C_200E_206A_200C_200C_206C_202B_200E_206C_202D_202C_200D_200C_206C_206F_202D_206B_206F_200F_200E_202D_206A_200E_202C_202E_200D_200C_206A_206A_200D_200D_206C_202C_200D_202C_200D_202E(GameObject P_0, bool P_1)
	{
		P_0.SetActive(P_1);
	}

	static void _206D_202B_206E_206B_202C_206B_206C_200E_206B_200F_202E_202C_206C_202C_202C_206D_202C_202A_206F_206F_202A_206C_200F_206B_206E_202B_200E_206C_202B_200C_200C_200B_206E_202B_206A_200F_202D_206E_202D_200F_202E(MonoBehaviour P_0, string P_1, float P_2)
	{
		P_0.Invoke(P_1, P_2);
	}
}
