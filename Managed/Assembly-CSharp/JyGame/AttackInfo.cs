using System.Runtime.CompilerServices;
using DG.Tweening;
using DG.Tweening.Core;
using UnityEngine;
using UnityEngine.UI;

namespace JyGame;

public class AttackInfo : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _202D_202C_206C_206F_202B_200B_206F_202D_206A_200F_200B_206B_200E_202B_206C_206C_206D_202B_202D_202C_202B_200C_206F_206E_206C_202B_202A_202B_202A_200D_200C_206A_206D_206E_206B_206A_200D_202E_202A_206A_202E
	{
		internal CommonSettings.VoidCallBack callback;

		internal AttackInfo _202A_202B_206D_202D_200C_202E_206F_200C_202B_202E_202E_206E_200D_206A_206F_206D_206F_200E_202C_206F_200B_206D_206B_202D_206C_206A_200D_200D_206D_200F_200F_206B_202A_202D_202A_200B_200F_200B_202C_202E_202E;

		internal void _202B_206F_202A_202A_200B_200E_202A_200C_202B_206C_202A_206E_200F_202D_206C_202A_206C_202E_202C_202C_206E_200F_200F_206A_202B_200F_202D_206C_202E_202B_200B_200D_206B_206D_200B_200C_206C_206C_200F_202E()
		{
			_202A_202C_206D_206C_200E_200B_202C_206C_202C_200F_202B_200D_206F_202B_206B_202A_200E_206D_202A_202A_200F_200D_200D_200E_206C_206E_200C_206F_206C_202A_206E_206E_206E_206C_200B_202A_202E_202A_202E_200D_202E((Object)(object)_202D_206C_206E_202C_200F_202D_200D_202B_200D_206A_200B_202A_200E_200B_200E_202B_206A_200B_200F_202A_206E_206B_202E_206E_206C_202A_202C_202B_202E_206D_200F_200F_202B_202B_200F_202C_202C_206A_206D_200C_202E((Component)(object)_202A_202B_206D_202D_200C_202E_206F_200C_202B_202E_202E_206E_200D_206A_206F_206D_206F_200E_202C_206F_200B_206D_206B_202D_206C_206A_200D_200D_206D_200F_200F_206B_202A_202D_202A_200B_200F_200B_202C_202E_202E));
			while (true)
			{
				int num = 1355622860;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x176621B9)) % 4)
					{
					case 0u:
						break;
					default:
						return;
					case 1u:
					{
						int num3;
						int num4;
						if (callback != null)
						{
							num3 = -659587602;
							num4 = num3;
						}
						else
						{
							num3 = -1597173813;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -555657548);
						continue;
					}
					case 3u:
						callback();
						num = ((int)num2 * -1178439332) ^ 0x57FB365B;
						continue;
					case 2u:
						return;
					}
					break;
				}
			}
		}

		static GameObject _202D_206C_206E_202C_200F_202D_200D_202B_200D_206A_200B_202A_200E_200B_200E_202B_206A_200B_200F_202A_206E_206B_202E_206E_206C_202A_202C_202B_202E_206D_200F_200F_202B_202B_200F_202C_202C_206A_206D_200C_202E(Component P_0)
		{
			return P_0.gameObject;
		}

		static void _202A_202C_206D_206C_200E_200B_202C_206C_202C_200F_202B_200D_206F_202B_206B_202A_200E_206D_202A_202A_200F_200D_200D_200E_206C_206E_200C_206F_206C_202A_206E_206E_206E_206C_200B_202A_202E_202A_202E_200D_202E(Object P_0)
		{
			Object.Destroy(P_0);
		}
	}

	[CompilerGenerated]
	private sealed class _202B_202C_206C_200C_206E_202B_206A_206E_200C_200D_200E_202B_202E_200C_200C_200B_200D_206E_200D_202B_202B_202E_206A_202C_206A_206A_200E_202E_200D_200D_200C_202D_206C_206A_206C_202D_206B_200F_206B_206F_202E
	{
		public CommonSettings.VoidCallBack callback;

		public AttackInfo _202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E;

		internal void _202B_202B_200C_202D_202B_202B_206D_202B_202C_206D_206C_206E_206E_202E_206F_206C_200B_202A_200F_200D_206E_200E_200B_202C_206B_202C_206C_200D_206D_206E_202D_200D_206D_202C_206C_202D_200E_200F_206F_206B_202E()
		{
			_200F_202A_206B_200B_206C_206D_202C_202C_206B_202D_206D_206A_202B_206A_206C_200D_202C_206D_202A_200C_206C_202A_206C_202C_202C_200C_202C_202A_206E_202B_200E_200B_206B_202E_206E_202E_200D_206E_200D_206A_202E((Object)(object)_206F_206F_202E_200F_202C_206E_202D_202E_200B_202A_206F_206F_200C_206B_206B_200D_202D_206A_202D_202B_206D_200E_206E_202E_200B_206D_206D_206F_200E_206A_200B_200C_202A_202A_202A_200C_200B_200B_202A_200D_202E((Component)(object)_202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E));
			while (true)
			{
				int num = -532322886;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1412513831)) % 4)
					{
					case 2u:
						break;
					default:
						return;
					case 3u:
					{
						int num3;
						int num4;
						if (callback == null)
						{
							num3 = -597933228;
							num4 = num3;
						}
						else
						{
							num3 = -1728195559;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -1117358204);
						continue;
					}
					case 0u:
						callback();
						num = (int)((num2 * 1117349606) ^ 0x4B328210);
						continue;
					case 1u:
						return;
					}
					break;
				}
			}
		}

		static GameObject _206F_206F_202E_200F_202C_206E_202D_202E_200B_202A_206F_206F_200C_206B_206B_200D_202D_206A_202D_202B_206D_200E_206E_202E_200B_206D_206D_206F_200E_206A_200B_200C_202A_202A_202A_200C_200B_200B_202A_200D_202E(Component P_0)
		{
			return P_0.gameObject;
		}

		static void _200F_202A_206B_200B_206C_206D_202C_202C_206B_202D_206D_206A_202B_206A_206C_200D_202C_206D_202A_200C_206C_202A_206C_202C_202C_200C_202C_202A_206E_202B_200E_200B_206B_202E_206E_202E_200D_206E_200D_206A_202E(Object P_0)
		{
			Object.Destroy(P_0);
		}
	}

	public void Display(int x, int y, string text, Color c, Transform parent, CommonSettings.VoidCallBack callback)
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		AttackInfo attackInfo = default(AttackInfo);
		CommonSettings.VoidCallBack callback2 = default(CommonSettings.VoidCallBack);
		while (true)
		{
			int num = 1861248131;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3E486122)) % 6)
				{
				case 5u:
					break;
				case 2u:
					_202B_206A_206D_206A_200C_200C_200D_202E_206B_200B_200C_206B_206A_206C_202E_202D_202A_200D_200D_200D_206E_200C_206A_200E_200B_206A_200E_202D_206D_202A_206E_202C_206D_202D_200D_206C_206D_200C_202B_202C_202E(_200E_202B_200F_202B_202A_202B_202E_202C_206A_202B_200F_206A_202B_206F_202A_200F_202D_202A_200E_206D_206F_200F_206D_206A_200F_202B_200C_200F_202E_200C_202D_206F_200E_200B_202D_206F_202C_206C_200B_206E_202E((Component)(object)this), parent);
					_200E_202B_200F_202B_202A_202B_202E_202C_206A_202B_200F_206A_202B_206F_202A_200F_202D_202A_200E_206D_206F_200F_206D_206A_200F_202B_200C_200F_202E_200C_202D_206F_200E_200B_202D_206F_202C_206C_200B_206E_202E((Component)(object)this).position = new Vector3(BattleField.ToScreenX(x), BattleField.ToScreenY(y) + 90f, 0f);
					num = (int)((num2 * 1646154578) ^ 0xB3138B);
					continue;
				case 4u:
					attackInfo = this;
					_206F_206A_202E_200C_206E_202E_206B_206E_200E_200F_206C_200F_200D_200C_202D_200B_206D_202C_206C_202D_206C_206C_200B_200E_206C_200B_200C_200D_206B_200E_202C_202B_206C_206C_206F_206E_206B_202B_202D_206A_202E(_202C_202D_206D_206B_200D_202B_202E_200F_202C_206A_200F_202A_202C_202C_202E_202C_206E_206C_206E_200F_206A_200D_206F_200F_202A_202D_202D_200F_200F_206C_202B_206E_206F_206B_202D_206C_206B_206A_206E_206C_202E((Component)(object)this).GetComponent<Text>(), text);
					num = ((int)num2 * -1578569717) ^ -2018069978;
					continue;
				case 1u:
					callback2 = callback;
					num = ((int)num2 * -344478841) ^ -17967297;
					continue;
				case 0u:
					_202B_202B_206E_206B_206B_202B_206C_200C_206F_202E_206D_206E_206D_202B_206E_202C_202D_200B_202C_206A_200C_206C_200E_200E_206D_202C_202E_200B_200C_206E_200D_206D_202E_200D_202D_206D_200B_202C_202A_202A_202E((Graphic)(object)_202C_202D_206D_206B_200D_202B_202E_200F_202C_206A_200F_202A_202C_202C_202E_202C_206E_206C_206E_200F_206A_200D_206F_200F_202A_202D_202D_200F_200F_206C_202B_206E_206F_206B_202D_206C_206B_206A_206E_206C_202E((Component)(object)this).GetComponent<Text>(), c);
					num = ((int)num2 * -1590253993) ^ 0x3A29C7B0;
					continue;
				default:
					TweenSettingsExtensions.OnComplete<Tweener>(TweenSettingsExtensions.SetEase<Tweener>(ShortcutExtensions.DOMove(((Component)this).transform, new Vector3(BattleField.ToScreenX(x) + (float)Tools.GetRandom(-50.0, 50.0), BattleField.ToScreenY(y) + 150f + (float)Tools.GetRandom(0.0, 50.0)), 1.5f, false), (Ease)24), (TweenCallback)delegate
					{
						_202D_202C_206C_206F_202B_200B_206F_202D_206A_200F_200B_206B_200E_202B_206C_206C_206D_202B_202D_202C_202B_200C_206F_206E_206C_202B_202A_202B_202A_200D_200C_206A_206D_206E_206B_206A_200D_202E_202A_206A_202E._202A_202C_206D_206C_200E_200B_202C_206C_202C_200F_202B_200D_206F_202B_206B_202A_200E_206D_202A_202A_200F_200D_200D_200E_206C_206E_200C_206F_206C_202A_206E_206E_206E_206C_200B_202A_202E_202A_202E_200D_202E((Object)(object)_202D_202C_206C_206F_202B_200B_206F_202D_206A_200F_200B_206B_200E_202B_206C_206C_206D_202B_202D_202C_202B_200C_206F_206E_206C_202B_202A_202B_202A_200D_200C_206A_206D_206E_206B_206A_200D_202E_202A_206A_202E._202D_206C_206E_202C_200F_202D_200D_202B_200D_206A_200B_202A_200E_200B_200E_202B_206A_200B_200F_202A_206E_206B_202E_206E_206C_202A_202C_202B_202E_206D_200F_200F_202B_202B_200F_202C_202C_206A_206D_200C_202E((Component)(object)attackInfo));
						while (true)
						{
							int num3 = 1355622860;
							while (true)
							{
								uint num4;
								switch ((num4 = (uint)(num3 ^ 0x176621B9)) % 4)
								{
								case 0u:
									break;
								default:
									return;
								case 1u:
								{
									int num5;
									int num6;
									if (callback2 != null)
									{
										num5 = -659587602;
										num6 = num5;
									}
									else
									{
										num5 = -1597173813;
										num6 = num5;
									}
									num3 = num5 ^ ((int)num4 * -555657548);
									continue;
								}
								case 3u:
									callback2();
									num3 = ((int)num4 * -1178439332) ^ 0x57FB365B;
									continue;
								case 2u:
									return;
								}
								break;
							}
						}
					});
					TweenSettingsExtensions.SetEase<Tweener>(ShortcutExtensions.DOScale(((Component)this).transform, new Vector3(1.3f, 1.3f), 1.5f), (Ease)18);
					return;
				}
				break;
			}
		}
	}

	public void DisplayPopinfo(string text, Color c, Transform parent)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		_206F_206A_202E_200C_206E_202E_206B_206E_200E_200F_206C_200F_200D_200C_202D_200B_206D_202C_206C_202D_206C_206C_200B_200E_206C_200B_200C_200D_206B_200E_202C_202B_206C_206C_206F_206E_206B_202B_202D_206A_202E(_202C_202D_206D_206B_200D_202B_202E_200F_202C_206A_200F_202A_202C_202C_202E_202C_206E_206C_206E_200F_206A_200D_206F_200F_202A_202D_202D_200F_200F_206C_202B_206E_206F_206B_202D_206C_206B_206A_206E_206C_202E((Component)(object)this).GetComponent<Text>(), text);
		while (true)
		{
			int num = -880345265;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1456092216)) % 6)
				{
				case 0u:
					break;
				default:
					return;
				case 4u:
					TweenSettingsExtensions.OnComplete<Tweener>(ShortcutExtensions.DOMoveY(((Component)this).transform, 100f, 2f, false), (TweenCallback)delegate
					{
						_206C_202D_206A_202C_202D_206B_206B_206A_200D_202D_206C_202C_202B_202E_202D_200B_206A_200D_206E_200C_202C_202E_202C_202C_200B_206E_202D_206D_200E_200B_206B_206D_200E_202E_200D_200B_200D_202A_200B_202D_202E((Object)(object)_202C_202D_206D_206B_200D_202B_202E_200F_202C_206A_200F_202A_202C_202C_202E_202C_206E_206C_206E_200F_206A_200D_206F_200F_202A_202D_202D_200F_200F_206C_202B_206E_206F_206B_202D_206C_206B_206A_206E_206C_202E((Component)(object)this));
					});
					num = ((int)num2 * -323463721) ^ 0x477E092D;
					continue;
				case 3u:
					_200E_202B_200F_202B_202A_202B_202E_202C_206A_202B_200F_206A_202B_206F_202A_200F_202D_202A_200E_206D_206F_200F_206D_206A_200F_202B_200C_200F_202E_200C_202D_206F_200E_200B_202D_206F_202C_206C_200B_206E_202E((Component)(object)this).position = new Vector3(0f, 0f);
					num = ((int)num2 * -1826626395) ^ 0x503F76D3;
					continue;
				case 2u:
					_202B_206A_206D_206A_200C_200C_200D_202E_206B_200B_200C_206B_206A_206C_202E_202D_202A_200D_200D_200D_206E_200C_206A_200E_200B_206A_200E_202D_206D_202A_206E_202C_206D_202D_200D_206C_206D_200C_202B_202C_202E(_200E_202B_200F_202B_202A_202B_202E_202C_206A_202B_200F_206A_202B_206F_202A_200F_202D_202A_200E_206D_206F_200F_206D_206A_200F_202B_200C_200F_202E_200C_202D_206F_200E_200B_202D_206F_202C_206C_200B_206E_202E((Component)(object)this), parent);
					num = (int)((num2 * 2141341392) ^ 0x66821C73);
					continue;
				case 5u:
					_202B_202B_206E_206B_206B_202B_206C_200C_206F_202E_206D_206E_206D_202B_206E_202C_202D_200B_202C_206A_200C_206C_200E_200E_206D_202C_202E_200B_200C_206E_200D_206D_202E_200D_202D_206D_200B_202C_202A_202A_202E((Graphic)(object)_202C_202D_206D_206B_200D_202B_202E_200F_202C_206A_200F_202A_202C_202C_202E_202C_206E_206C_206E_200F_206A_200D_206F_200F_202A_202D_202D_200F_200F_206C_202B_206E_206F_206B_202D_206C_206B_206A_206E_206C_202E((Component)(object)this).GetComponent<Text>(), c);
					_202D_206E_206B_200B_202C_200D_202D_206D_200B_200E_206F_202C_202A_200F_202A_202E_206D_206B_206D_206F_206C_202C_200B_200F_202A_200F_202B_202E_206D_206F_202C_206C_202D_200E_200E_200B_200B_202B_202E_206E_202E(_202C_202D_206D_206B_200D_202B_202E_200F_202C_206A_200F_202A_202C_202C_202E_202C_206E_206C_206E_200F_206A_200D_206F_200F_202A_202D_202D_200F_200F_206C_202B_206E_206F_206B_202D_206C_206B_206A_206E_206C_202E((Component)(object)this).GetComponent<Text>(), 30);
					num = (int)(num2 * 175482007) ^ -1541331019;
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	[CompilerGenerated]
	private void _206B_206D_206E_206A_206B_202B_206D_202E_206E_206D_200C_206E_206E_206E_202B_200F_206E_200C_206E_206B_206A_200B_200B_206D_206D_200D_202D_206C_202D_200F_202C_200B_206B_202D_200E_202C_206B_202B_202C_206B_202E()
	{
		_206C_202D_206A_202C_202D_206B_206B_206A_200D_202D_206C_202C_202B_202E_202D_200B_206A_200D_206E_200C_202C_202E_202C_202C_200B_206E_202D_206D_200E_200B_206B_206D_200E_202E_200D_200B_200D_202A_200B_202D_202E((Object)(object)_202C_202D_206D_206B_200D_202B_202E_200F_202C_206A_200F_202A_202C_202C_202E_202C_206E_206C_206E_200F_206A_200D_206F_200F_202A_202D_202D_200F_200F_206C_202B_206E_206F_206B_202D_206C_206B_206A_206E_206C_202E((Component)(object)this));
	}

	public void Display2(int x, int y, string text, Color c, Transform parent, int ease = 24, int ease2 = 18, CommonSettings.VoidCallBack callback = null)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		AttackInfo attackInfo = default(AttackInfo);
		CommonSettings.VoidCallBack callback2 = default(CommonSettings.VoidCallBack);
		while (true)
		{
			int num = 1516128839;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x243C622A)) % 15)
				{
				case 3u:
					break;
				case 1u:
					_202B_202B_206E_206B_206B_202B_206C_200C_206F_202E_206D_206E_206D_202B_206E_202C_202D_200B_202C_206A_200C_206C_200E_200E_206D_202C_202E_200B_200C_206E_200D_206D_202E_200D_202D_206D_200B_202C_202A_202A_202E((Graphic)(object)_202C_202D_206D_206B_200D_202B_202E_200F_202C_206A_200F_202A_202C_202C_202E_202C_206E_206C_206E_200F_206A_200D_206F_200F_202A_202D_202D_200F_200F_206C_202B_206E_206F_206B_202D_206C_206B_206A_206E_206C_202E((Component)(object)this).GetComponent<Text>(), c);
					_202B_206A_206D_206A_200C_200C_200D_202E_206B_200B_200C_206B_206A_206C_202E_202D_202A_200D_200D_200D_206E_200C_206A_200E_200B_206A_200E_202D_206D_202A_206E_202C_206D_202D_200D_206C_206D_200C_202B_202C_202E(_200E_202B_200F_202B_202A_202B_202E_202C_206A_202B_200F_206A_202B_206F_202A_200F_202D_202A_200E_206D_206F_200F_206D_206A_200F_202B_200C_200F_202E_200C_202D_206F_200E_200B_202D_206F_202C_206C_200B_206E_202E((Component)(object)this), parent);
					_200E_202B_200F_202B_202A_202B_202E_202C_206A_202B_200F_206A_202B_206F_202A_200F_202D_202A_200E_206D_206F_200F_206D_206A_200F_202B_200C_200F_202E_200C_202D_206F_200E_200B_202D_206F_202C_206C_200B_206E_202E((Component)(object)this).position = new Vector3(BattleField.ToScreenX(x), BattleField.ToScreenY(y) + 90f, 0f);
					num = ((int)num2 * -477281756) ^ 0x6CAFE1C5;
					continue;
				case 12u:
					ease2 = 0;
					num = ((int)num2 * -1254282873) ^ -537815590;
					continue;
				case 14u:
					num = (int)((num2 * 828360560) ^ 0x78757848);
					continue;
				case 0u:
				{
					int num6;
					if (ease <= 33)
					{
						num = 298182276;
						num6 = num;
					}
					else
					{
						num = 237951225;
						num6 = num;
					}
					continue;
				}
				case 11u:
					ease2 = 33;
					num = ((int)num2 * -101605012) ^ 0x314B1A40;
					continue;
				case 5u:
					_206F_206A_202E_200C_206E_202E_206B_206E_200E_200F_206C_200F_200D_200C_202D_200B_206D_202C_206C_202D_206C_206C_200B_200E_206C_200B_200C_200D_206B_200E_202C_202B_206C_206C_206F_206E_206B_202B_202D_206A_202E(_202C_202D_206D_206B_200D_202B_202E_200F_202C_206A_200F_202A_202C_202C_202E_202C_206E_206C_206E_200F_206A_200D_206F_200F_202A_202D_202D_200F_200F_206C_202B_206E_206F_206B_202D_206C_206B_206A_206E_206C_202E((Component)(object)this).GetComponent<Text>(), text);
					num = 857052151;
					continue;
				case 2u:
					TweenSettingsExtensions.OnComplete<Tweener>(TweenSettingsExtensions.SetEase<Tweener>(ShortcutExtensions.DOMove(((Component)this).transform, new Vector3(BattleField.ToScreenX(x) + (float)Tools.GetRandom(-50.0, 50.0), BattleField.ToScreenY(y) + 150f + (float)Tools.GetRandom(0.0, 50.0)), 1.5f, false), (Ease)ease), (TweenCallback)delegate
					{
						_202B_202C_206C_200C_206E_202B_206A_206E_200C_200D_200E_202B_202E_200C_200C_200B_200D_206E_200D_202B_202B_202E_206A_202C_206A_206A_200E_202E_200D_200D_200C_202D_206C_206A_206C_202D_206B_200F_206B_206F_202E._200F_202A_206B_200B_206C_206D_202C_202C_206B_202D_206D_206A_202B_206A_206C_200D_202C_206D_202A_200C_206C_202A_206C_202C_202C_200C_202C_202A_206E_202B_200E_200B_206B_202E_206E_202E_200D_206E_200D_206A_202E((Object)(object)_202B_202C_206C_200C_206E_202B_206A_206E_200C_200D_200E_202B_202E_200C_200C_200B_200D_206E_200D_202B_202B_202E_206A_202C_206A_206A_200E_202E_200D_200D_200C_202D_206C_206A_206C_202D_206B_200F_206B_206F_202E._206F_206F_202E_200F_202C_206E_202D_202E_200B_202A_206F_206F_200C_206B_206B_200D_202D_206A_202D_202B_206D_200E_206E_202E_200B_206D_206D_206F_200E_206A_200B_200C_202A_202A_202A_200C_200B_200B_202A_200D_202E((Component)(object)attackInfo));
						while (true)
						{
							int num8 = -532322886;
							while (true)
							{
								uint num9;
								switch ((num9 = (uint)(num8 ^ -1412513831)) % 4)
								{
								case 2u:
									break;
								default:
									return;
								case 3u:
								{
									int num10;
									int num11;
									if (callback2 == null)
									{
										num10 = -597933228;
										num11 = num10;
									}
									else
									{
										num10 = -1728195559;
										num11 = num10;
									}
									num8 = num10 ^ ((int)num9 * -1117358204);
									continue;
								}
								case 0u:
									callback2();
									num8 = (int)((num9 * 1117349606) ^ 0x4B328210);
									continue;
								case 1u:
									return;
								}
								break;
							}
						}
					});
					num = (int)((num2 * 1582940014) ^ 0x2DDA332C);
					continue;
				case 13u:
					attackInfo = this;
					num = (int)((num2 * 1973206265) ^ 0x69B5D589);
					continue;
				case 7u:
					ease = 33;
					num = (int)(num2 * 929559130) ^ -288111958;
					continue;
				case 9u:
				{
					int num7;
					if (ease2 <= 33)
					{
						num = 800761912;
						num7 = num;
					}
					else
					{
						num = 717011472;
						num7 = num;
					}
					continue;
				}
				case 6u:
				{
					callback2 = callback;
					int num4;
					int num5;
					if (ease >= 0)
					{
						num4 = 1079154623;
						num5 = num4;
					}
					else
					{
						num4 = 341655976;
						num5 = num4;
					}
					num = num4 ^ ((int)num2 * -412747008);
					continue;
				}
				case 4u:
					ease = 0;
					num = ((int)num2 * -37211086) ^ 0xF0B95E0;
					continue;
				case 8u:
				{
					int num3;
					if (ease2 >= 0)
					{
						num = 2101605795;
						num3 = num;
					}
					else
					{
						num = 1511239197;
						num3 = num;
					}
					continue;
				}
				default:
					TweenSettingsExtensions.SetEase<Tweener>(ShortcutExtensions.DOScale(((Component)this).transform, new Vector3(1.3f, 1.3f), 1.5f), (Ease)ease2);
					return;
				}
				break;
			}
		}
	}

	static GameObject _202C_202D_206D_206B_200D_202B_202E_200F_202C_206A_200F_202A_202C_202C_202E_202C_206E_206C_206E_200F_206A_200D_206F_200F_202A_202D_202D_200F_200F_206C_202B_206E_206F_206B_202D_206C_206B_206A_206E_206C_202E(Component P_0)
	{
		return P_0.gameObject;
	}

	static void _206F_206A_202E_200C_206E_202E_206B_206E_200E_200F_206C_200F_200D_200C_202D_200B_206D_202C_206C_202D_206C_206C_200B_200E_206C_200B_200C_200D_206B_200E_202C_202B_206C_206C_206F_206E_206B_202B_202D_206A_202E(Text P_0, string P_1)
	{
		P_0.text = P_1;
	}

	static void _202B_202B_206E_206B_206B_202B_206C_200C_206F_202E_206D_206E_206D_202B_206E_202C_202D_200B_202C_206A_200C_206C_200E_200E_206D_202C_202E_200B_200C_206E_200D_206D_202E_200D_202D_206D_200B_202C_202A_202A_202E(Graphic P_0, Color P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.color = P_1;
	}

	static Transform _200E_202B_200F_202B_202A_202B_202E_202C_206A_202B_200F_206A_202B_206F_202A_200F_202D_202A_200E_206D_206F_200F_206D_206A_200F_202B_200C_200F_202E_200C_202D_206F_200E_200B_202D_206F_202C_206C_200B_206E_202E(Component P_0)
	{
		return P_0.transform;
	}

	static void _202B_206A_206D_206A_200C_200C_200D_202E_206B_200B_200C_206B_206A_206C_202E_202D_202A_200D_200D_200D_206E_200C_206A_200E_200B_206A_200E_202D_206D_202A_206E_202C_206D_202D_200D_206C_206D_200C_202B_202C_202E(Transform P_0, Transform P_1)
	{
		P_0.SetParent(P_1);
	}

	static void _202D_206E_206B_200B_202C_200D_202D_206D_200B_200E_206F_202C_202A_200F_202A_202E_206D_206B_206D_206F_206C_202C_200B_200F_202A_200F_202B_202E_206D_206F_202C_206C_202D_200E_200E_200B_200B_202B_202E_206E_202E(Text P_0, int P_1)
	{
		P_0.fontSize = P_1;
	}

	static void _206C_202D_206A_202C_202D_206B_206B_206A_200D_202D_206C_202C_202B_202E_202D_200B_206A_200D_206E_200C_202C_202E_202C_202C_200B_206E_202D_206D_200E_200B_206B_206D_200E_202E_200D_200B_200D_202A_200B_202D_202E(Object P_0)
	{
		Object.Destroy(P_0);
	}
}
