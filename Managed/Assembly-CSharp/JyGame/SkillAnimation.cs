using UnityEngine;

namespace JyGame;

public class SkillAnimation : MonoBehaviour
{
	private CommonSettings.VoidCallBack _206B_200B_200F_200D_206E_206C_206D_206D_206C_200C_206B_200B_206E_202A_206C_202D_202D_206C_206A_202B_206D_202D_200E_200F_202A_206E_200F_206F_200F_202C_202D_206E_202A_206D_206C_200C_206F_206A_202C_206C_202E;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Display(int x, int y, CommonSettings.VoidCallBack callback = null)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		_202A_206C_206E_200B_206F_202C_202C_200F_200D_202C_202A_202D_202D_200F_200F_202A_206D_206C_202A_200B_200D_202E_200B_202E_200F_202C_206F_206D_200D_202A_202B_206A_200B_202A_200C_202B_202E_202C_206C_200C_202E((Component)(object)this).position = new Vector3(BattleField.ToScreenX(x), BattleField.ToScreenY(y), (float)(-200 + y));
		while (true)
		{
			int num = 99748138;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1769F7CD)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_0048;
				case 2u:
					return;
				}
				break;
				IL_0048:
				_206B_200B_200F_200D_206E_206C_206D_206D_206C_200C_206B_200B_206E_202A_206C_202D_202D_206C_206A_202B_206D_202D_200E_200F_202A_206E_200F_206F_200F_202C_202D_206E_202A_206D_206C_200C_206F_206A_202C_206C_202E = callback;
				num = ((int)num2 * -1920473078) ^ -333258422;
			}
		}
	}

	public void DisplayEffectNotFollowSprite()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		_202A_206C_206E_200B_206F_202C_202C_200F_200D_202C_202A_202D_202D_200F_200F_202A_206D_206C_202A_200B_200D_202E_200B_202E_200F_202C_206F_206D_200D_202A_202B_206A_200B_202A_200C_202B_202E_202C_206C_200C_202E((Component)(object)this).position = new Vector3(0f, 0f, -1f);
		while (true)
		{
			int num = -1862600688;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1886527867)) % 4)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
				{
					int num3;
					int num4;
					if (CommonSettings.ScreenScale < 2f)
					{
						num3 = 432577057;
						num4 = num3;
					}
					else
					{
						num3 = 1328761458;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1388047459);
					continue;
				}
				case 0u:
				{
					Vector3 localScale = ((Component)this).transform.localScale;
					((Component)this).transform.localScale = new Vector3(localScale.x * (640f * CommonSettings.ScreenScale / 1140f), localScale.y, localScale.z);
					num = (int)((num2 * 1171941830) ^ 0x3D41F7CE);
					continue;
				}
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public void DisplayEffect(int x, int y)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		_202A_206C_206E_200B_206F_202C_202C_200F_200D_202C_202A_202D_202D_200F_200F_202A_206D_206C_202A_200B_200D_202E_200B_202E_200F_202C_206F_206D_200D_202A_202B_206A_200B_202A_200C_202B_202E_202C_206C_200C_202E((Component)(object)this).position = new Vector3(BattleField.ToScreenX(x), BattleField.ToScreenY(y) + 50f, -1f);
	}

	public void SetCallback(CommonSettings.VoidCallBack callback)
	{
		_206B_200B_200F_200D_206E_206C_206D_206D_206C_200C_206B_200B_206E_202A_206C_202D_202D_206C_206A_202B_206D_202D_200E_200F_202A_206E_200F_206F_200F_202C_202D_206E_202A_206D_206C_200C_206F_206A_202C_206C_202E = callback;
	}

	private void Clear()
	{
		_206D_202A_206A_206B_200B_202E_202D_206C_202B_202E_206F_200F_206E_202B_206C_206C_206A_200D_200E_200F_206D_206B_206E_202C_200E_200F_206C_200D_206C_206B_202C_206D_200D_200E_200C_200C_200C_206D_200C_206A_202E((Object)(object)_200B_202A_202A_200D_206B_200B_200D_202E_200E_200E_200B_202A_200C_206A_202E_206D_206D_206A_206F_206F_206C_206D_200F_206C_202B_200F_202D_206D_200C_206A_200F_202D_206B_200B_200D_200B_200F_202A_202E_202E_202E((Component)(object)this));
		if (_206B_200B_200F_200D_206E_206C_206D_206D_206C_200C_206B_200B_206E_202A_206C_202D_202D_206C_206A_202B_206D_202D_200E_200F_202A_206E_200F_206F_200F_202C_202D_206E_202A_206D_206C_200C_206F_206A_202C_206C_202E == null)
		{
			return;
		}
		while (true)
		{
			int num = -311085039;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -193621190)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0035;
				case 1u:
					return;
				}
				break;
				IL_0035:
				_206B_200B_200F_200D_206E_206C_206D_206D_206C_200C_206B_200B_206E_202A_206C_202D_202D_206C_206A_202B_206D_202D_200E_200F_202A_206E_200F_206F_200F_202C_202D_206E_202A_206D_206C_200C_206F_206A_202C_206C_202E();
				num = (int)((num2 * 957980117) ^ 0x1A1E8FCE);
			}
		}
	}

	static Transform _202A_206C_206E_200B_206F_202C_202C_200F_200D_202C_202A_202D_202D_200F_200F_202A_206D_206C_202A_200B_200D_202E_200B_202E_200F_202C_206F_206D_200D_202A_202B_206A_200B_202A_200C_202B_202E_202C_206C_200C_202E(Component P_0)
	{
		return P_0.transform;
	}

	static GameObject _200B_202A_202A_200D_206B_200B_200D_202E_200E_200E_200B_202A_200C_206A_202E_206D_206D_206A_206F_206F_206C_206D_200F_206C_202B_200F_202D_206D_200C_206A_200F_202D_206B_200B_200D_200B_200F_202A_202E_202E_202E(Component P_0)
	{
		return P_0.gameObject;
	}

	static void _206D_202A_206A_206B_200B_202E_202D_206C_202B_202E_206F_200F_206E_202B_206C_206C_206A_200D_200E_200F_206D_206B_206E_202C_200E_200F_206C_200D_206C_206B_202C_206D_200D_200E_200C_200C_200C_206D_200C_206A_202E(Object P_0)
	{
		Object.Destroy(P_0);
	}
}
