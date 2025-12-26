using System;
using System.Collections;
using JyGame;
using UnityEngine;
using UnityEngine.UI;

public class SelectMenu : MonoBehaviour
{
	private const SelectMenuMode Mode = SelectMenuMode.Grid;

	private CommonSettings.VoidCallBack _206E_200E_202A_200C_202E_206A_206D_200D_206A_202D_202E_200C_206C_200D_200C_206F_200C_200E_206C_202B_202D_202B_206E_206D_206E_202B_206C_200B_206A_206D_202C_200E_200D_206C_200B_206C_200F_202E_200F_206D_202E;

	public Transform selectContent => _202A_206E_206F_200D_200C_206D_200C_200C_200D_200B_206C_202D_202C_206C_200D_206D_200B_202A_206D_206F_200E_202A_202E_206C_202E_202A_206D_200F_200D_206A_200B_202E_200E_202A_200B_202A_202B_202E_206C_200F_202E((Component)(object)_200B_200B_202C_202E_206C_202E_200B_206A_206A_200C_202C_200D_202A_206E_206A_202C_200E_206B_206B_200F_200F_202E_202E_202E_200E_200F_200D_202B_200C_202C_200D_202B_202D_206C_206A_202C_206B_202D_206D_206D_202E(_200B_200B_202C_202E_206C_202E_200B_206A_206A_200C_202C_200D_202A_206E_206A_202C_200E_206B_206B_200F_200F_202E_202E_202E_200E_200F_200D_202B_200C_202C_200D_202B_202D_206C_206A_202C_206B_202D_206D_206D_202E(_206B_200B_202D_202C_200C_200B_200D_202A_206F_206B_206B_200C_202A_206C_206A_200E_200B_206E_200F_202E_206D_202A_206C_200F_202A_200D_202A_206A_206C_200B_202E_206F_202A_206A_202A_200F_200C_202C_200D_206D_202E((Component)(object)this), global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1253920575u)), global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3756763546u)));

	private ScrollRect scrollRect => ((Component)_200B_200B_202C_202E_206C_202E_200B_206A_206A_200C_202C_200D_202A_206E_206A_202C_200E_206B_206B_200F_200F_202E_202E_202E_200E_200F_200D_202B_200C_202C_200D_202B_202D_206C_206A_202C_206B_202D_206D_206D_202E(_206B_200B_202D_202C_200C_200B_200D_202A_206F_206B_206B_200C_202A_206C_206A_200E_200B_206E_200F_202E_206D_202A_206C_200F_202A_200D_202A_206A_206C_200B_202E_206F_202A_206A_202A_200F_200C_202C_200D_206D_202E((Component)(object)this), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(691991657u))).GetComponent<ScrollRect>();

	public void Clear()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		IEnumerator enumerator = _202E_206F_206D_206F_202E_200E_206C_206B_202E_202C_202C_200E_206F_206E_202D_202C_206F_202A_202A_206B_202C_206F_200B_202A_202E_202E_206B_202A_206C_206C_202E_200C_202E_206B_202C_206D_206D_206F_206D_202E_202E(selectContent);
		try
		{
			while (true)
			{
				IL_0052:
				int num;
				int num2;
				if (!_200F_206E_206C_202C_206E_200D_200E_202B_200C_200F_202B_206F_200D_202C_206D_206C_206B_200D_200B_200B_202D_206D_202D_202C_200F_200E_200F_206D_200F_206C_206C_202A_202E_202A_200B_202D_200C_200C_202C_206D_202E(enumerator))
				{
					num = 54428364;
					num2 = num;
				}
				else
				{
					num = 1457646749;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0xF9BE0C)) % 4)
					{
					case 2u:
						num = 1457646749;
						continue;
					default:
						goto end_IL_0013;
					case 1u:
					{
						Transform val = (Transform)_206E_200E_202E_206C_200D_200C_206A_200B_200E_206F_202E_202B_200C_202D_202A_206B_200C_206F_206A_202B_202A_200D_200B_202D_202E_206E_202E_206C_200B_202C_206B_200B_200D_206A_206C_200D_206A_206E_202D_202D_202E(enumerator);
						_206A_200C_200F_206D_200D_202B_202B_202B_206D_202B_200E_200D_200E_206A_200F_202D_200C_206C_202D_202C_202A_206D_200F_200E_206C_200C_200C_206A_200F_206B_200D_202A_206C_200B_206C_200D_206B_206A_202D_202E((Object)(object)_206B_200C_200D_206F_206D_200D_206C_200F_202B_206D_200B_206F_202A_200E_200D_202D_206C_206F_202D_200C_202D_206A_206A_206A_200D_202B_202B_206D_202C_200F_206C_200E_200E_206F_202D_202B_200E_206E_202A_206D_202E((Component)(object)val));
						num = 1400447687;
						continue;
					}
					case 3u:
						break;
					case 0u:
						goto end_IL_0013;
					}
					goto IL_0052;
					continue;
					end_IL_0013:
					break;
				}
				break;
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			if (disposable == null)
			{
				goto IL_0077;
			}
			goto IL_00ad;
			IL_0077:
			int num4 = 745517729;
			goto IL_007c;
			IL_007c:
			uint num3;
			switch ((num3 = (uint)(num4 ^ 0xF9BE0C)) % 4)
			{
			case 0u:
				break;
			default:
				goto end_IL_006d;
			case 1u:
				goto end_IL_006d;
			case 2u:
				goto IL_00ad;
			case 3u:
				goto end_IL_006d;
			}
			goto IL_0077;
			IL_00ad:
			_200C_200D_200F_206A_202E_200F_200C_202A_200F_206D_202D_202C_202A_206E_206C_202D_200E_206E_202D_206E_200E_206A_200D_206C_200D_202E_206C_200E_200E_206E_206F_202D_202A_202C_202A_206F_206B_206B_202D_202E_202E(disposable);
			num4 = 560849611;
			goto IL_007c;
			end_IL_006d:;
		}
		_206C_206E_200E_202C_200B_200B_206A_202E_206B_202D_202B_206D_200C_206D_206A_200B_200F_206E_202A_202E_206C_206B_200C_202C_206C_200C_200B_202D_206E_200F_202E_206F_206B_206E_202C_206A_200D_206E_206B_206D_202E(selectContent);
	}

	public void ShowWithSpacing(float spacing, CommonSettings.VoidCallBack cancelCallback = null)
	{
		_202A_200C_202D_202A_202B_202D_200F_206B_202A_206E_202B_206B_200F_206D_200D_202A_206A_202B_202B_202C_200E_200F_200E_206A_200F_200E_202A_206C_202C_200E_206A_202D_200F_206F_202D_202A_202D_206F_206A_202B_202E((HorizontalOrVerticalLayoutGroup)(object)((Component)selectContent).GetComponent<VerticalLayoutGroup>(), spacing);
		while (true)
		{
			int num = 964689897;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7995E4A1)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_0033;
				case 2u:
					return;
				}
				break;
				IL_0033:
				Show(cancelCallback);
				num = (int)(num2 * 1323721439) ^ -1677010220;
			}
		}
	}

	public void Show(CommonSettings.VoidCallBack cancelCallback = null)
	{
		_206E_200E_202A_200C_202E_206A_206D_200D_206A_202D_202E_200C_206C_200D_200C_206F_200C_200E_206C_202B_202D_202B_206E_206D_206E_202B_206C_200B_206A_206D_202C_200E_200D_206C_200B_206C_200F_202E_200F_206D_202E = cancelCallback;
		while (true)
		{
			int num = -19818919;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -141729230)) % 5)
				{
				case 4u:
					break;
				default:
					return;
				case 3u:
					_206A_200F_202D_206E_206A_206B_206E_206D_202E_202B_206E_206D_206C_202D_200B_200B_206E_202D_202B_202C_200E_206F_206D_206F_200F_206D_200F_200B_202D_200B_200F_206A_202C_206D_202A_206F_206A_206D_206B_206D_202E(_206B_200C_200D_206F_206D_200D_206C_200F_202B_206D_200B_206F_202A_200E_200D_202D_206C_206F_202D_200C_202D_206A_206A_206A_200D_202B_202B_206D_202C_200F_206C_200E_200E_206F_202D_202B_200E_206E_202A_206D_202E((Component)(object)_200B_200B_202C_202E_206C_202E_200B_206A_206A_200C_202C_200D_202A_206E_206A_202C_200E_206B_206B_200F_200F_202E_202E_202E_200E_200F_200D_202B_200C_202C_200D_202B_202D_206C_206A_202C_206B_202D_206D_206D_202E(_206B_200B_202D_202C_200C_200B_200D_202A_206F_206B_206B_200C_202A_206C_206A_200E_200B_206E_200F_202E_206D_202A_206C_200F_202A_200D_202A_206A_206C_200B_202E_206F_202A_206A_202A_200F_200C_202C_200D_206D_202E((Component)(object)this), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1031111484u))), true);
					num = (int)((num2 * 256700241) ^ 0xB58357D);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (cancelCallback != null)
					{
						num3 = -1774296727;
						num4 = num3;
					}
					else
					{
						num3 = -744069178;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1141786407);
					continue;
				}
				case 2u:
					_206A_200F_202D_206E_206A_206B_206E_206D_202E_202B_206E_206D_206C_202D_200B_200B_206E_202D_202B_202C_200E_206F_206D_206F_200F_206D_200F_200B_202D_200B_200F_206A_202C_206D_202A_206F_206A_206D_206B_206D_202E(_200E_206A_202C_202D_202D_202B_206B_206E_206F_202B_206C_200F_202B_206D_206B_200E_206B_202C_200F_206A_200E_206B_200D_202C_206A_206E_202B_202B_200B_206E_200F_200B_206E_200B_200B_202A_206B_202D_202C_200F_202E((Component)(object)this), true);
					num = (int)(num2 * 1073006411) ^ -1952589900;
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public void Hide()
	{
		_206A_200F_202D_206E_206A_206B_206E_206D_202E_202B_206E_206D_206C_202D_200B_200B_206E_202D_202B_202C_200E_206F_206D_206F_200F_206D_200F_200B_202D_200B_200F_206A_202C_206D_202A_206F_206A_206D_206B_206D_202E(_200E_206A_202C_202D_202D_202B_206B_206E_206F_202B_206C_200F_202B_206D_206B_200E_206B_202C_200F_206A_200E_206B_200D_202C_206A_206E_202B_202B_200B_206E_200F_200B_206E_200B_200B_202A_206B_202D_202C_200F_202E((Component)(object)this), false);
	}

	public void AddItem(GameObject item)
	{
		_200C_206F_202B_206B_202E_206F_206E_206A_206A_206D_202A_202E_202C_206D_200E_202E_206B_206D_202C_200E_200D_206B_206D_202A_200F_202E_202D_202C_200E_202E_200F_202E_202D_206D_202D_206C_206A_206B_206F_206B_202E(_202A_206E_202B_200D_202C_206D_200F_202A_202C_200B_202B_202E_206E_200C_206C_206D_200B_206F_200D_200C_206F_202D_206E_206C_206C_202C_206E_202D_202E_206A_206D_202E_206E_206A_200B_202D_200F_206F_202A_206A_202E(item), selectContent);
	}

	public void CancelButtonClicked()
	{
		if (_206E_200E_202A_200C_202E_206A_206D_200D_206A_202D_202E_200C_206C_200D_200C_206F_200C_200E_206C_202B_202D_202B_206E_206D_206E_202B_206C_200B_206A_206D_202C_200E_200D_206C_200B_206C_200F_202E_200F_206D_202E == null)
		{
			return;
		}
		while (true)
		{
			int num = -631378787;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1874686957)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_002a;
				case 2u:
					return;
				}
				break;
				IL_002a:
				_206E_200E_202A_200C_202E_206A_206D_200D_206A_202D_202E_200C_206C_200D_200C_206F_200C_200E_206C_202B_202D_202B_206E_206D_206E_202B_206C_200B_206A_206D_202C_200E_200D_206C_200B_206C_200F_202E_200F_206D_202E();
				num = (int)(num2 * 350057045) ^ -2117550768;
			}
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private bool RefreshTransform(Transform transform, bool refreshImage, bool refreshText, int teamCount)
	{
		if (_206D_206D_202D_200E_206E_202A_200E_200F_200F_202E_206D_206D_206D_202E_206E_206F_200D_202B_206E_200F_202A_206E_200B_200F_202D_202C_200D_200E_200D_206D_206F_206C_200E_206A_206E_202C_200C_200F_200B_202C_202E((Object)(object)transform, (Object)null))
		{
			while (true)
			{
				int num = -1936580150;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -247948060)) % 4)
					{
					case 0u:
						break;
					case 2u:
					{
						int num3;
						int num4;
						if (_206C_202E_202B_206A_202B_200B_202E_200E_202A_202E_206E_202E_202C_206C_200B_202E_200D_202B_202A_202B_200E_200B_200C_206D_206B_206B_206E_202D_206F_200B_200B_206C_202E_202D_200B_202E_200B_200D_202D_200C_202E(selectContent) == teamCount)
						{
							num3 = 491809123;
							num4 = num3;
						}
						else
						{
							num3 = 1613018145;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 374332536);
						continue;
					}
					case 3u:
						((Component)transform).GetComponent<TeamRoleItemUI>().Refresh2(refreshImage, refreshText);
						return true;
					default:
						goto end_IL_0009;
					}
					break;
				}
				continue;
				end_IL_0009:
				break;
			}
		}
		return false;
	}

	private bool RemoveTransform(Transform item)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		Transform val = null;
		IEnumerator enumerator = _202E_206F_206D_206F_202E_200E_206C_206B_202E_202C_202C_200E_206F_206E_202D_202C_206F_202A_202A_206B_202C_206F_200B_202A_202E_202E_206B_202A_206C_206C_202E_200C_202E_206B_202C_206D_206D_206F_206D_202E_202E(selectContent);
		try
		{
			Transform val2 = default(Transform);
			while (true)
			{
				IL_008c:
				int num;
				int num2;
				if (_200F_206E_206C_202C_206E_200D_200E_202B_200C_200F_202B_206F_200D_202C_206D_206C_206B_200D_200B_200B_202D_206D_202D_202C_200F_200E_200F_206D_200F_206C_206C_202A_202E_202A_200B_202D_200C_200C_202C_206D_202E(enumerator))
				{
					num = 2140695995;
					num2 = num;
				}
				else
				{
					num = 1647665175;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0xE7652D)) % 6)
					{
					case 3u:
						num = 2140695995;
						continue;
					default:
						goto end_IL_0015;
					case 4u:
					{
						val2 = (Transform)_206E_200E_202E_206C_200D_200C_206A_200B_200E_206F_202E_202B_200C_202D_202A_206B_200C_206F_206A_202B_202A_200D_200B_202D_202E_206E_202E_206C_200B_202C_206B_200B_200D_206A_206C_200D_206A_206E_202D_202D_202E(enumerator);
						int num4;
						if (!_200B_202A_206F_206C_202E_202B_206E_206C_206F_202A_200C_206D_206D_202C_200E_206E_202D_200F_200F_202D_200E_202D_206A_206E_206C_206D_206E_202C_200F_200D_200F_206A_206D_206B_206E_206D_202B_202B_202E_206A_202E((object)val2, (object)item))
						{
							num = 1240229652;
							num4 = num;
						}
						else
						{
							num = 1811103882;
							num4 = num;
						}
						continue;
					}
					case 0u:
						goto end_IL_0015;
					case 1u:
						val = val2;
						num = (int)((num3 * 1139895266) ^ 0x4F32EF);
						continue;
					case 5u:
						break;
					case 2u:
						goto end_IL_0015;
					}
					goto IL_008c;
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
					IL_00b4:
					int num5 = 1953918864;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num5 ^ 0xE7652D)) % 3)
						{
						case 2u:
							break;
						default:
							goto end_IL_00b9;
						case 1u:
							goto IL_00d7;
						case 0u:
							goto end_IL_00b9;
						}
						goto IL_00b4;
						IL_00d7:
						_200C_200D_200F_206A_202E_200F_200C_202A_200F_206D_202D_202C_202A_206E_206C_202D_200E_206E_202D_206E_200E_206A_200D_206C_200D_202E_206C_200E_200E_206E_206F_202D_202A_202C_202A_206F_206B_206B_202D_202E_202E(disposable);
						num5 = ((int)num3 * -1173210028) ^ 0x3D468215;
						continue;
						end_IL_00b9:
						break;
					}
					break;
				}
			}
		}
		if (_206D_206D_202D_200E_206E_202A_200E_200F_200F_202E_206D_206D_206D_202E_206E_206F_200D_202B_206E_200F_202A_206E_200B_200F_202D_202C_200D_200E_200D_206D_206F_206C_200E_206A_206E_202C_200C_200F_200B_202C_202E((Object)(object)val, (Object)null))
		{
			while (true)
			{
				int num6 = 1276416460;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num6 ^ 0xE7652D)) % 4)
					{
					case 2u:
						break;
					case 1u:
						_206B_200C_200D_206F_206D_200D_206C_200F_202B_206D_200B_206F_202A_200E_200D_202D_206C_206F_202D_200C_202D_206A_206A_206A_200D_202B_202B_206D_202C_200F_206C_200E_200E_206F_202D_202B_200E_206E_202A_206D_202E((Component)(object)val).GetComponent<TeamRoleItemUI>().SetParent(null);
						_200C_206F_202B_206B_202E_206F_206E_206A_206A_206D_202A_202E_202C_206D_200E_202E_206B_206D_202C_200E_200D_206B_206D_202A_200F_202E_202D_202C_200E_202E_200F_202E_202D_206D_202D_206C_206A_206B_206F_206B_202E(val, (Transform)null);
						num6 = (int)(num3 * 2004649511) ^ -108048871;
						continue;
					case 3u:
						_206A_200C_200F_206D_200D_202B_202B_202B_206D_202B_200E_200D_200E_206A_200F_202D_200C_206C_202D_202C_202A_206D_200F_200E_206C_200C_200C_206A_200F_206B_200D_202A_206C_200B_206C_200D_206B_206A_202D_202E((Object)(object)_206B_200C_200D_206F_206D_200D_206C_200F_202B_206D_200B_206F_202A_200E_200D_202D_206C_206F_202D_200C_202D_206A_206A_206A_200D_202B_202B_206D_202C_200F_206C_200E_200E_206F_202D_202B_200E_206E_202A_206D_202E((Component)(object)val));
						return true;
					default:
						goto end_IL_00f7;
					}
					break;
				}
				continue;
				end_IL_00f7:
				break;
			}
		}
		return false;
	}

	private bool SetTransformIndex(Transform item, int index)
	{
		if (_206D_206D_202D_200E_206E_202A_200E_200F_200F_202E_206D_206D_206D_202E_206E_206F_200D_202B_206E_200F_202A_206E_200B_200F_202D_202C_200D_200E_200D_206D_206F_206C_200E_206A_206E_202C_200C_200F_200B_202C_202E((Object)(object)item, (Object)null))
		{
			while (true)
			{
				int num = -404509778;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1847325996)) % 7)
					{
					case 0u:
						break;
					case 4u:
						_202A_206A_206D_206A_200F_206E_200E_206E_206F_202B_202C_202D_200D_202A_206E_206A_206F_206D_202E_202D_206A_202C_206A_200B_200B_206F_202A_206E_200D_202D_202C_200F_206E_200D_206A_200D_202B_200D_206A_202E(item, index);
						return true;
					case 5u:
						index = 0;
						num = (int)(num2 * 1410303248) ^ -981607284;
						continue;
					case 3u:
						index = _206C_202E_202B_206A_202B_200B_202E_200E_202A_202E_206E_202E_202C_206C_200B_202E_200D_202B_202A_202B_200E_200B_200C_206D_206B_206B_206E_202D_206F_200B_200B_206C_202E_202D_200B_202E_200B_200D_202D_200C_202E(selectContent) - 1;
						num = (int)((num2 * 1548440398) ^ 0x5874058C);
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (index < 0)
						{
							num3 = 1495034140;
							num4 = num3;
						}
						else
						{
							num3 = 1894224086;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 247877506);
						continue;
					}
					case 6u:
						goto IL_00a1;
					default:
						goto end_IL_000c;
					}
					break;
					IL_00a1:
					int num5;
					if (index <= _206C_202E_202B_206A_202B_200B_202E_200E_202A_202E_206E_202E_202C_206C_200B_202E_200D_202B_202A_202B_200E_200B_200C_206D_206B_206B_206E_202D_206F_200B_200B_206C_202E_202D_200B_202E_200B_200D_202D_200C_202E(selectContent) - 1)
					{
						num = -1099934900;
						num5 = num;
					}
					else
					{
						num = -1087295628;
						num5 = num;
					}
				}
				continue;
				end_IL_000c:
				break;
			}
		}
		return false;
	}

	public void ResetItemsIndex()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		int num = 0;
		IEnumerator enumerator = _202E_206F_206D_206F_202E_200E_206C_206B_202E_202C_202C_200E_206F_206E_202D_202C_206F_202A_202A_206B_202C_206F_200B_202A_202E_202E_206B_202A_206C_206C_202E_200C_202E_206B_202C_206D_206D_206F_206D_202E_202E(selectContent);
		try
		{
			while (true)
			{
				int num2;
				int num3;
				if (_200F_206E_206C_202C_206E_200D_200E_202B_200C_200F_202B_206F_200D_202C_206D_206C_206B_200D_200B_200B_202D_206D_202D_202C_200F_200E_200F_206D_200F_206C_206C_202A_202E_202A_200B_202D_200C_200C_202C_206D_202E(enumerator))
				{
					num2 = 475213335;
					num3 = num2;
				}
				else
				{
					num2 = 130253046;
					num3 = num2;
				}
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)(num2 ^ 0x6E177B6F)) % 5)
					{
					case 0u:
						num2 = 475213335;
						continue;
					default:
						return;
					case 2u:
						_206B_200C_200D_206F_206D_200D_206C_200F_202B_206D_200B_206F_202A_200E_200D_202D_206C_206F_202D_200C_202D_206A_206A_206A_200D_202B_202B_206D_202C_200F_206C_200E_200E_206F_202D_202B_200E_206E_202A_206D_202E((Component)(Transform)_206E_200E_202E_206C_200D_200C_206A_200B_200E_206F_202E_202B_200C_202D_202A_206B_200C_206F_206A_202B_202A_200D_200B_202D_202E_206E_202E_206C_200B_202C_206B_200B_200D_206A_206C_200D_206A_206E_202D_202D_202E(enumerator)).GetComponent<TeamRoleItemUI>().SetIndex(num);
						num2 = 1902541059;
						continue;
					case 4u:
						num++;
						num2 = ((int)num4 * -1604797852) ^ -884834657;
						continue;
					case 3u:
						break;
					case 1u:
						return;
					}
					break;
				}
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			while (true)
			{
				IL_0091:
				int num5 = 2095334722;
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)(num5 ^ 0x6E177B6F)) % 4)
					{
					case 0u:
						break;
					default:
						goto end_IL_0096;
					case 1u:
					{
						int num6;
						int num7;
						if (disposable == null)
						{
							num6 = -1686418981;
							num7 = num6;
						}
						else
						{
							num6 = -1949785554;
							num7 = num6;
						}
						num5 = num6 ^ ((int)num4 * -785336949);
						continue;
					}
					case 2u:
						_200C_200D_200F_206A_202E_200F_200C_202A_200F_206D_202D_202C_202A_206E_206C_202D_200E_206E_202D_206E_200E_206A_200D_206C_200D_202E_206C_200E_200E_206E_206F_202D_202A_202C_202A_206F_206B_206B_202D_202E_202E(disposable);
						num5 = ((int)num4 * -982049024) ^ 0x125E48B4;
						continue;
					case 3u:
						goto end_IL_0096;
					}
					goto IL_0091;
					continue;
					end_IL_0096:
					break;
				}
				break;
			}
		}
	}

	private Transform GetTransformShop(ItemInstance item)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		IEnumerator enumerator = _202E_206F_206D_206F_202E_200E_206C_206B_202E_202C_202C_200E_206F_206E_202D_202C_206F_202A_202A_206B_202C_206F_200B_202A_202E_202E_206B_202A_206C_206C_202E_200C_202E_206B_202C_206D_206D_206F_206D_202E_202E(selectContent);
		try
		{
			Transform val = default(Transform);
			while (true)
			{
				IL_009c:
				int num;
				int num2;
				if (_200F_206E_206C_202C_206E_200D_200E_202B_200C_200F_202B_206F_200D_202C_206D_206C_206B_200D_200B_200B_202D_206D_202D_202C_200F_200E_200F_206D_200F_206C_206C_202A_202E_202A_200B_202D_200C_200C_202C_206D_202E(enumerator))
				{
					num = 1269763887;
					num2 = num;
				}
				else
				{
					num = 1452728756;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x1FF677AF)) % 7)
					{
					case 0u:
						num = 1269763887;
						continue;
					default:
						goto end_IL_0016;
					case 2u:
						val = (Transform)_206E_200E_202E_206C_200D_200C_206A_200B_200E_206F_202E_202B_200C_202D_202A_206B_200C_206F_206A_202B_202A_200D_200B_202D_202E_206E_202E_206C_200B_202C_206B_200B_200D_206A_206C_200D_206A_206E_202D_202D_202E(enumerator);
						num = 1375097330;
						continue;
					case 6u:
						return val;
					case 1u:
					{
						int num4;
						int num5;
						if (((Component)val).GetComponent<ItemUI>().GetItem() != item)
						{
							num4 = -1952881378;
							num5 = num4;
						}
						else
						{
							num4 = -1909735727;
							num5 = num4;
						}
						num = num4 ^ (int)(num3 * 1580956021);
						continue;
					}
					case 4u:
						break;
					case 5u:
						((Component)val).GetComponent<ItemUI>().Hide_previewPanel();
						num = ((int)num3 * -1623527681) ^ 0x1FFF4BE8;
						continue;
					case 3u:
						goto end_IL_0016;
					}
					goto IL_009c;
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
				IL_00df:
				int num6 = 442213922;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num6 ^ 0x1FF677AF)) % 4)
					{
					case 3u:
						break;
					default:
						goto end_IL_00e4;
					case 1u:
					{
						int num7;
						int num8;
						if (disposable != null)
						{
							num7 = -115514305;
							num8 = num7;
						}
						else
						{
							num7 = -930107639;
							num8 = num7;
						}
						num6 = num7 ^ ((int)num3 * -1896322348);
						continue;
					}
					case 0u:
						_200C_200D_200F_206A_202E_200F_200C_202A_200F_206D_202D_202C_202A_206E_206C_202D_200E_206E_202D_206E_200E_206A_200D_206C_200D_202E_206C_200E_200E_206E_206F_202D_202A_202C_202A_206F_206B_206B_202D_202E_202E(disposable);
						num6 = ((int)num3 * -1148008893) ^ 0x6B07D31;
						continue;
					case 2u:
						goto end_IL_00e4;
					}
					goto IL_00df;
					continue;
					end_IL_00e4:
					break;
				}
				break;
			}
		}
		return null;
	}

	private bool RefreshTransformShop(Transform transform, int count)
	{
		if (_206D_206D_202D_200E_206E_202A_200E_200F_200F_202E_206D_206D_206D_202E_206E_206F_200D_202B_206E_200F_202A_206E_200B_200F_202D_202C_200D_200E_200D_206D_206F_206C_200E_206A_206E_202C_200C_200F_200B_202C_202E((Object)(object)transform, (Object)null))
		{
			while (true)
			{
				uint num;
				switch ((num = 519763175u) % 3)
				{
				case 0u:
					continue;
				case 2u:
					((Component)transform).GetComponent<ItemUI>().Refresh2(count);
					return true;
				}
				break;
			}
		}
		return false;
	}

	private bool RemoveTransformShop(Transform item)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		Transform val = null;
		IEnumerator enumerator = _202E_206F_206D_206F_202E_200E_206C_206B_202E_202C_202C_200E_206F_206E_202D_202C_206F_202A_202A_206B_202C_206F_200B_202A_202E_202E_206B_202A_206C_206C_202E_200C_202E_206B_202C_206D_206D_206F_206D_202E_202E(selectContent);
		try
		{
			Transform val2 = default(Transform);
			while (true)
			{
				IL_0077:
				int num;
				int num2;
				if (_200F_206E_206C_202C_206E_200D_200E_202B_200C_200F_202B_206F_200D_202C_206D_206C_206B_200D_200B_200B_202D_206D_202D_202C_200F_200E_200F_206D_200F_206C_206C_202A_202E_202A_200B_202D_200C_200C_202C_206D_202E(enumerator))
				{
					num = -826847792;
					num2 = num;
				}
				else
				{
					num = -266970857;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -1637178364)) % 6)
					{
					case 4u:
						num = -826847792;
						continue;
					default:
						goto end_IL_0015;
					case 2u:
					{
						val2 = (Transform)_206E_200E_202E_206C_200D_200C_206A_200B_200E_206F_202E_202B_200C_202D_202A_206B_200C_206F_206A_202B_202A_200D_200B_202D_202E_206E_202E_206C_200B_202C_206B_200B_200D_206A_206C_200D_206A_206E_202D_202D_202E(enumerator);
						int num4;
						if (_200B_202A_206F_206C_202E_202B_206E_206C_206F_202A_200C_206D_206D_202C_200E_206E_202D_200F_200F_202D_200E_202D_206A_206E_206C_206D_206E_202C_200F_200D_200F_206A_206D_206B_206E_206D_202B_202B_202E_206A_202E((object)val2, (object)item))
						{
							num = -9279607;
							num4 = num;
						}
						else
						{
							num = -2096104696;
							num4 = num;
						}
						continue;
					}
					case 1u:
						val = val2;
						num = ((int)num3 * -1442016856) ^ 0x70CE0D97;
						continue;
					case 0u:
						break;
					case 3u:
						goto end_IL_0015;
					case 5u:
						goto end_IL_0015;
					}
					goto IL_0077;
					continue;
					end_IL_0015:
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
				IL_00ae:
				int num5 = -251945719;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num5 ^ -1637178364)) % 4)
					{
					case 3u:
						break;
					default:
						goto end_IL_00b3;
					case 1u:
					{
						int num6;
						int num7;
						if (disposable == null)
						{
							num6 = 1545832883;
							num7 = num6;
						}
						else
						{
							num6 = 1742290653;
							num7 = num6;
						}
						num5 = num6 ^ (int)(num3 * 530323449);
						continue;
					}
					case 0u:
						_200C_200D_200F_206A_202E_200F_200C_202A_200F_206D_202D_202C_202A_206E_206C_202D_200E_206E_202D_206E_200E_206A_200D_206C_200D_202E_206C_200E_200E_206E_206F_202D_202A_202C_202A_206F_206B_206B_202D_202E_202E(disposable);
						num5 = ((int)num3 * -632461791) ^ 0x3F21C8EA;
						continue;
					case 2u:
						goto end_IL_00b3;
					}
					goto IL_00ae;
					continue;
					end_IL_00b3:
					break;
				}
				break;
			}
		}
		if (_206D_206D_202D_200E_206E_202A_200E_200F_200F_202E_206D_206D_206D_202E_206E_206F_200D_202B_206E_200F_202A_206E_200B_200F_202D_202C_200D_200E_200D_206D_206F_206C_200E_206A_206E_202C_200C_200F_200B_202C_202E((Object)(object)val, (Object)null))
		{
			while (true)
			{
				uint num3;
				switch ((num3 = 1473445759u) % 3)
				{
				case 0u:
					continue;
				case 1u:
					_200C_206F_202B_206B_202E_206F_206E_206A_206A_206D_202A_202E_202C_206D_200E_202E_206B_206D_202C_200E_200D_206B_206D_202A_200F_202E_202D_202C_200E_202E_200F_202E_202D_206D_202D_206C_206A_206B_206F_206B_202E(val, (Transform)null);
					_206A_200C_200F_206D_200D_202B_202B_202B_206D_202B_200E_200D_200E_206A_200F_202D_200C_206C_202D_202C_202A_206D_200F_200E_206C_200C_200C_206A_200F_206B_200D_202A_206C_200B_206C_200D_206B_206A_202D_202E((Object)(object)_206B_200C_200D_206F_206D_200D_206C_200F_202B_206D_200B_206F_202A_200E_200D_202D_206C_206F_202D_200C_202D_206A_206A_206A_200D_202B_202B_206D_202C_200F_206C_200E_200E_206F_202D_202B_200E_206E_202A_206D_202E((Component)(object)val));
					return true;
				}
				break;
			}
		}
		return false;
	}

	public bool RefreshItemShop(ItemInstance item, int count)
	{
		Transform transformShop = GetTransformShop(item);
		return RefreshTransformShop(transformShop, count);
	}

	public bool RemoveItemShop(ItemInstance item)
	{
		Transform transformShop = GetTransformShop(item);
		bool num = RemoveTransformShop(transformShop);
		if (num && _202D_200D_202E_200E_206C_202A_200B_206F_206E_200F_202B_206E_202C_206B_206C_202E_200C_200E_206D_200D_206B_200E_200E_202B_206B_200E_200D_206A_206E_202A_200D_206E_202B_202E_202C_200E_206A_202A_206F_206E_202E(_200E_206A_202C_202D_202D_202B_206B_206E_206F_202B_206C_200F_202B_206D_206B_200E_206B_202C_200F_206A_200E_206B_200D_202C_206A_206E_202B_202B_200B_206E_200F_200B_206E_200B_200B_202A_206B_202D_202C_200F_202E((Component)(object)this)))
		{
			_206A_200F_202D_206E_206A_206B_206E_206D_202E_202B_206E_206D_206C_202D_200B_200B_206E_202D_202B_202C_200E_206F_206D_206F_200F_206D_200F_200B_202D_200B_200F_206A_202C_206D_202A_206F_206A_206D_206B_206D_202E(_200E_206A_202C_202D_202D_202B_206B_206E_206F_202B_206C_200F_202B_206D_206B_200E_206B_202C_200F_206A_200E_206B_200D_202C_206A_206E_202B_202B_200B_206E_200F_200B_206E_200B_200B_202A_206B_202D_202C_200F_202E((Component)(object)this), false);
			_206A_200F_202D_206E_206A_206B_206E_206D_202E_202B_206E_206D_206C_202D_200B_200B_206E_202D_202B_202C_200E_206F_206D_206F_200F_206D_200F_200B_202D_200B_200F_206A_202C_206D_202A_206F_206A_206D_206B_206D_202E(_200E_206A_202C_202D_202D_202B_206B_206E_206F_202B_206C_200F_202B_206D_206B_200E_206B_202C_200F_206A_200E_206B_200D_202C_206A_206E_202B_202B_200B_206E_200F_200B_206E_200B_200B_202A_206B_202D_202C_200F_202E((Component)(object)this), true);
		}
		return num;
	}

	private Transform GetTransform(Role role)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		IEnumerator enumerator = _202E_206F_206D_206F_202E_200E_206C_206B_202E_202C_202C_200E_206F_206E_202D_202C_206F_202A_202A_206B_202C_206F_200B_202A_202E_202E_206B_202A_206C_206C_202E_200C_202E_206B_202C_206D_206D_206F_206D_202E_202E(selectContent);
		try
		{
			Transform val = default(Transform);
			while (true)
			{
				IL_0067:
				int num;
				int num2;
				if (_200F_206E_206C_202C_206E_200D_200E_202B_200C_200F_202B_206F_200D_202C_206D_206C_206B_200D_200B_200B_202D_206D_202D_202C_200F_200E_200F_206D_200F_206C_206C_202A_202E_202A_200B_202D_200C_200C_202C_206D_202E(enumerator))
				{
					num = -1758547627;
					num2 = num;
				}
				else
				{
					num = -543018684;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -1781685530)) % 6)
					{
					case 3u:
						num = -1758547627;
						continue;
					default:
						goto end_IL_0013;
					case 1u:
						val = (Transform)_206E_200E_202E_206C_200D_200C_206A_200B_200E_206F_202E_202B_200C_202D_202A_206B_200C_206F_206A_202B_202A_200D_200B_202D_202E_206E_202E_206C_200B_202C_206B_200B_200D_206A_206C_200D_206A_206E_202D_202D_202E(enumerator);
						num = -657033040;
						continue;
					case 4u:
						return val;
					case 5u:
						break;
					case 0u:
					{
						int num4;
						int num5;
						if (((Component)val).GetComponent<TeamRoleItemUI>().GetRole() == role)
						{
							num4 = 827083980;
							num5 = num4;
						}
						else
						{
							num4 = 1705145107;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -1716957185);
						continue;
					}
					case 2u:
						goto end_IL_0013;
					}
					goto IL_0067;
					continue;
					end_IL_0013:
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
				IL_00b4:
				int num6 = -1192153877;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num6 ^ -1781685530)) % 4)
					{
					case 2u:
						break;
					default:
						goto end_IL_00b9;
					case 1u:
					{
						int num7;
						int num8;
						if (disposable != null)
						{
							num7 = -531273181;
							num8 = num7;
						}
						else
						{
							num7 = -1940140764;
							num8 = num7;
						}
						num6 = num7 ^ (int)(num3 * 362947933);
						continue;
					}
					case 0u:
						_200C_200D_200F_206A_202E_200F_200C_202A_200F_206D_202D_202C_202A_206E_206C_202D_200E_206E_202D_206E_200E_206A_200D_206C_200D_202E_206C_200E_200E_206E_206F_202D_202A_202C_202A_206F_206B_206B_202D_202E_202E(disposable);
						num6 = ((int)num3 * -748583921) ^ -1840004391;
						continue;
					case 3u:
						goto end_IL_00b9;
					}
					goto IL_00b4;
					continue;
					end_IL_00b9:
					break;
				}
				break;
			}
		}
		return null;
	}

	public bool RefreshItem(Role role, bool refreshImage, bool refreshText, int teamCount)
	{
		Transform transform = GetTransform(role);
		return RefreshTransform(transform, refreshImage, refreshText, teamCount);
	}

	public bool RemoveItem(Role role)
	{
		Transform transform = GetTransform(role);
		bool num = RemoveTransform(transform);
		if (num)
		{
			ResetItemsIndex();
		}
		return num;
	}

	public bool SetItemIndex(Role role, int index)
	{
		Transform transform = GetTransform(role);
		bool num = SetTransformIndex(transform, index);
		if (num)
		{
			ResetItemsIndex();
		}
		return num;
	}

	static Transform _206B_200B_202D_202C_200C_200B_200D_202A_206F_206B_206B_200C_202A_206C_206A_200E_200B_206E_200F_202E_206D_202A_206C_200F_202A_200D_202A_206A_206C_200B_202E_206F_202A_206A_202A_200F_200C_202C_200D_206D_202E(Component P_0)
	{
		return P_0.transform;
	}

	static Transform _200B_200B_202C_202E_206C_202E_200B_206A_206A_200C_202C_200D_202A_206E_206A_202C_200E_206B_206B_200F_200F_202E_202E_202E_200E_200F_200D_202B_200C_202C_200D_202B_202D_206C_206A_202C_206B_202D_206D_206D_202E(Transform P_0, string P_1)
	{
		return P_0.FindChild(P_1);
	}

	static Transform _202A_206E_206F_200D_200C_206D_200C_200C_200D_200B_206C_202D_202C_206C_200D_206D_200B_202A_206D_206F_200E_202A_202E_206C_202E_202A_206D_200F_200D_206A_200B_202E_200E_202A_200B_202A_202B_202E_206C_200F_202E(Component P_0)
	{
		return P_0.transform;
	}

	static IEnumerator _202E_206F_206D_206F_202E_200E_206C_206B_202E_202C_202C_200E_206F_206E_202D_202C_206F_202A_202A_206B_202C_206F_200B_202A_202E_202E_206B_202A_206C_206C_202E_200C_202E_206B_202C_206D_206D_206F_206D_202E_202E(Transform P_0)
	{
		return P_0.GetEnumerator();
	}

	static object _206E_200E_202E_206C_200D_200C_206A_200B_200E_206F_202E_202B_200C_202D_202A_206B_200C_206F_206A_202B_202A_200D_200B_202D_202E_206E_202E_206C_200B_202C_206B_200B_200D_206A_206C_200D_206A_206E_202D_202D_202E(IEnumerator P_0)
	{
		return P_0.Current;
	}

	static GameObject _206B_200C_200D_206F_206D_200D_206C_200F_202B_206D_200B_206F_202A_200E_200D_202D_206C_206F_202D_200C_202D_206A_206A_206A_200D_202B_202B_206D_202C_200F_206C_200E_200E_206F_202D_202B_200E_206E_202A_206D_202E(Component P_0)
	{
		return P_0.gameObject;
	}

	static void _206A_200C_200F_206D_200D_202B_202B_202B_206D_202B_200E_200D_200E_206A_200F_202D_200C_206C_202D_202C_202A_206D_200F_200E_206C_200C_200C_206A_200F_206B_200D_202A_206C_200B_206C_200D_206B_206A_202D_202E(Object P_0)
	{
		Object.Destroy(P_0);
	}

	static bool _200F_206E_206C_202C_206E_200D_200E_202B_200C_200F_202B_206F_200D_202C_206D_206C_206B_200D_200B_200B_202D_206D_202D_202C_200F_200E_200F_206D_200F_206C_206C_202A_202E_202A_200B_202D_200C_200C_202C_206D_202E(IEnumerator P_0)
	{
		return P_0.MoveNext();
	}

	static void _200C_200D_200F_206A_202E_200F_200C_202A_200F_206D_202D_202C_202A_206E_206C_202D_200E_206E_202D_206E_200E_206A_200D_206C_200D_202E_206C_200E_200E_206E_206F_202D_202A_202C_202A_206F_206B_206B_202D_202E_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}

	static void _206C_206E_200E_202C_200B_200B_206A_202E_206B_202D_202B_206D_200C_206D_206A_200B_200F_206E_202A_202E_206C_206B_200C_202C_206C_200C_200B_202D_206E_200F_202E_206F_206B_206E_202C_206A_200D_206E_206B_206D_202E(Transform P_0)
	{
		P_0.DetachChildren();
	}

	static void _202A_200C_202D_202A_202B_202D_200F_206B_202A_206E_202B_206B_200F_206D_200D_202A_206A_202B_202B_202C_200E_200F_200E_206A_200F_200E_202A_206C_202C_200E_206A_202D_200F_206F_202D_202A_202D_206F_206A_202B_202E(HorizontalOrVerticalLayoutGroup P_0, float P_1)
	{
		P_0.spacing = P_1;
	}

	static GameObject _200E_206A_202C_202D_202D_202B_206B_206E_206F_202B_206C_200F_202B_206D_206B_200E_206B_202C_200F_206A_200E_206B_200D_202C_206A_206E_202B_202B_200B_206E_200F_200B_206E_200B_200B_202A_206B_202D_202C_200F_202E(Component P_0)
	{
		return P_0.gameObject;
	}

	static void _206A_200F_202D_206E_206A_206B_206E_206D_202E_202B_206E_206D_206C_202D_200B_200B_206E_202D_202B_202C_200E_206F_206D_206F_200F_206D_200F_200B_202D_200B_200F_206A_202C_206D_202A_206F_206A_206D_206B_206D_202E(GameObject P_0, bool P_1)
	{
		P_0.SetActive(P_1);
	}

	static Transform _202A_206E_202B_200D_202C_206D_200F_202A_202C_200B_202B_202E_206E_200C_206C_206D_200B_206F_200D_200C_206F_202D_206E_206C_206C_202C_206E_202D_202E_206A_206D_202E_206E_206A_200B_202D_200F_206F_202A_206A_202E(GameObject P_0)
	{
		return P_0.transform;
	}

	static void _200C_206F_202B_206B_202E_206F_206E_206A_206A_206D_202A_202E_202C_206D_200E_202E_206B_206D_202C_200E_200D_206B_206D_202A_200F_202E_202D_202C_200E_202E_200F_202E_202D_206D_202D_206C_206A_206B_206F_206B_202E(Transform P_0, Transform P_1)
	{
		P_0.SetParent(P_1);
	}

	static bool _206D_206D_202D_200E_206E_202A_200E_200F_200F_202E_206D_206D_206D_202E_206E_206F_200D_202B_206E_200F_202A_206E_200B_200F_202D_202C_200D_200E_200D_206D_206F_206C_200E_206A_206E_202C_200C_200F_200B_202C_202E(Object P_0, Object P_1)
	{
		return P_0 != P_1;
	}

	static int _206C_202E_202B_206A_202B_200B_202E_200E_202A_202E_206E_202E_202C_206C_200B_202E_200D_202B_202A_202B_200E_200B_200C_206D_206B_206B_206E_202D_206F_200B_200B_206C_202E_202D_200B_202E_200B_200D_202D_200C_202E(Transform P_0)
	{
		return P_0.childCount;
	}

	static bool _200B_202A_206F_206C_202E_202B_206E_206C_206F_202A_200C_206D_206D_202C_200E_206E_202D_200F_200F_202D_200E_202D_206A_206E_206C_206D_206E_202C_200F_200D_200F_206A_206D_206B_206E_206D_202B_202B_202E_206A_202E(object P_0, object P_1)
	{
		return P_0.Equals(P_1);
	}

	static void _202A_206A_206D_206A_200F_206E_200E_206E_206F_202B_202C_202D_200D_202A_206E_206A_206F_206D_202E_202D_206A_202C_206A_200B_200B_206F_202A_206E_200D_202D_202C_200F_206E_200D_206A_200D_202B_200D_206A_202E(Transform P_0, int P_1)
	{
		P_0.SetSiblingIndex(P_1);
	}

	static bool _202D_200D_202E_200E_206C_202A_200B_206F_206E_200F_202B_206E_202C_206B_206C_202E_200C_200E_206D_200D_206B_200E_200E_202B_206B_200E_200D_206A_206E_202A_200D_206E_202B_202E_202C_200E_206A_202A_206F_206E_202E(GameObject P_0)
	{
		return P_0.activeSelf;
	}
}
