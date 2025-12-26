using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace JyGame;

public class UserDefinedAnimation : MonoBehaviour
{
	public Sprite[] stands;

	public Sprite[] attacks;

	public Sprite[] moves;

	public Sprite[] beattacks;

	public Sprite[] effects;

	public SpriteRenderer bindImage;

	public string currentState;

	private int currentIndex;

	private CommonSettings.VoidCallBack _206B_200B_200F_200D_206E_206C_206D_206D_206C_200C_206B_200B_206E_202A_206C_202D_202D_206C_206A_202B_206D_202D_200E_200F_202A_206E_200F_206F_200F_202C_202D_206E_202A_206D_206C_200C_206F_206A_202C_206C_202E;

	[CompilerGenerated]
	private static Dictionary<string, int> _202D_200C_200B_206B_206A_202D_202D_206E_206C_206D_206A_200E_200E_206B_200E_206D_202E_206F_206C_206B_200D_206E_200D_200E_206D_200C_200B_206F_202A_202C_202E_200C_206B_206A_206D_206A_202E_202C_206B_206F_202E;

	public void Play(string state, CommonSettings.VoidCallBack callback = null)
	{
		currentState = state;
		while (true)
		{
			int num = -536423737;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -158306422)) % 4)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					currentIndex = 0;
					num = (int)((num2 * 2122393665) ^ 0x415F15D9);
					continue;
				case 2u:
					_206B_200B_200F_200D_206E_206C_206D_206D_206C_200C_206B_200B_206E_202A_206C_202D_202D_206C_206A_202B_206D_202D_200E_200F_202A_206E_200F_206F_200F_202C_202D_206E_202A_206D_206C_200C_206F_206A_202C_206C_202E = callback;
					num = (int)((num2 * 281127248) ^ 0x698A4C55);
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
		if (_206E_202A_200E_206A_206B_206C_206C_206F_202C_200F_202C_202C_202D_206A_206F_202D_206B_206A_206C_206E_200C_202C_206D_200C_202E_206F_202D_206F_202C_202B_206B_202E_200F_206F_206B_202A_200E_202A_206F_202E_202E(currentState))
		{
			return;
		}
		while (true)
		{
			int num = 1618718894;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x502F644A)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_002f;
				case 1u:
					return;
				}
				break;
				IL_002f:
				_206F_202B_206B_202E_202E_206F_200D_200B_202B_202A_206C_202D_206E_200C_206D_200B_202A_200D_202E_202D_206F_202E_206E_200E_200D_202D_202A_206E_200F_200F_200E_206D_200B_206A_202C_206A_206B_206D_206E_200F_202E((MonoBehaviour)(object)this, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1215953517u), 1f / 6f, 1f / 6f);
				num = (int)(num2 * 1980686299) ^ -1808706810;
			}
		}
	}

	public void PlayNextFrame()
	{
		Sprite[] array = null;
		string text = currentState;
		if (text != null)
		{
			goto IL_000f;
		}
		goto IL_01dd;
		IL_000f:
		int num = 961111552;
		goto IL_0014;
		IL_0014:
		Dictionary<string, int> dictionary = default(Dictionary<string, int>);
		int value = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x20015B38)) % 31)
			{
			case 14u:
				break;
			default:
				return;
			case 6u:
				currentIndex++;
				num = ((int)num2 * -849068462) ^ -706971910;
				continue;
			case 7u:
				dictionary = new Dictionary<string, int>(5);
				num = (int)(num2 * 949614761) ^ -370238074;
				continue;
			case 11u:
				array = stands;
				num = 373800841;
				continue;
			case 17u:
				goto IL_0101;
			case 16u:
				dictionary.Add(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2884358572u), 3);
				dictionary.Add(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1151929481u), 4);
				_202D_200C_200B_206B_206A_202D_202D_206E_206C_206D_206A_200E_200E_206B_200E_206D_202E_206F_206C_206B_200D_206E_200D_200E_206D_200C_200B_206F_202A_202C_202E_200C_206B_206A_206D_206A_202E_202C_206B_206F_202E = dictionary;
				num = ((int)num2 * -1560342315) ^ -353610560;
				continue;
			case 28u:
			{
				int num9;
				int num10;
				if (_202D_200B_200F_202D_206F_206C_202E_202A_206D_202C_202D_202C_200D_206A_206B_200B_202C_206C_206E_202B_202E_200F_200D_206B_200D_200B_200F_200B_202B_202C_206A_202B_206B_206F_206A_206B_200D_202A_202B_200D_202E(currentState, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1791778390u)))
				{
					num9 = -1113388153;
					num10 = num9;
				}
				else
				{
					num9 = -1584675513;
					num10 = num9;
				}
				num = num9 ^ (int)(num2 * 1430053123);
				continue;
			}
			case 13u:
				goto IL_019b;
			case 9u:
				goto IL_01be;
			case 12u:
			case 22u:
				goto IL_01dd;
			case 3u:
			{
				int num5;
				int num6;
				if (_202D_200C_200B_206B_206A_202D_202D_206E_206C_206D_206A_200E_200E_206B_200E_206D_202E_206F_206C_206B_200D_206E_200D_200E_206D_200C_200B_206F_202A_202C_202E_200C_206B_206A_206D_206A_202E_202C_206B_206F_202E == null)
				{
					num5 = 901486155;
					num6 = num5;
				}
				else
				{
					num5 = 1939844743;
					num6 = num5;
				}
				num = num5 ^ ((int)num2 * -807164255);
				continue;
			}
			case 21u:
				goto IL_0218;
			case 10u:
				num = ((int)num2 * -716947929) ^ -2104369974;
				continue;
			case 18u:
				currentState = global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2407636847u);
				array = stands;
				num = 2047211595;
				continue;
			case 26u:
				num = ((int)num2 * -1668895631) ^ -2086587522;
				continue;
			case 20u:
			{
				currentIndex = 0;
				int num7;
				int num8;
				if (!_202D_200B_200F_202D_206F_206C_202E_202A_206D_202C_202D_202C_200D_206A_206B_200B_202C_206C_206E_202B_202E_200F_200D_206B_200D_200B_200F_200B_202B_202C_206A_202B_206B_206F_206A_206B_200D_202A_202B_200D_202E(currentState, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4216920819u)))
				{
					num7 = 1217140915;
					num8 = num7;
				}
				else
				{
					num7 = 1899854238;
					num8 = num7;
				}
				num = num7 ^ (int)(num2 * 61101782);
				continue;
			}
			case 8u:
				goto IL_02ab;
			case 1u:
				dictionary.Add(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2471351972u), 0);
				dictionary.Add(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2081569984u), 1);
				dictionary.Add(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(544411040u), 2);
				num = ((int)num2 * -479021380) ^ 0x2E71E9F7;
				continue;
			case 4u:
				goto IL_0302;
			case 15u:
			{
				Sprite val = array[currentIndex];
				_206F_202D_206A_206B_202E_202A_206E_202C_206D_202E_206E_202A_200D_206D_206C_200C_206C_202E_206D_200F_206B_200D_206A_202B_206D_200D_206C_206F_200C_202D_202B_206B_200C_206E_202B_200F_202D_200B_202A_206D_202E(bindImage, val);
				num = 1740644651;
				continue;
			}
			case 23u:
				_200C_206A_200B_206B_206C_206B_206D_206A_206B_202D_202E_202D_206D_200E_206E_202A_202C_206E_202D_202E_200D_206C_202C_202B_200B_200E_206D_206B_206F_200E_206A_202D_200E_200D_206D_202E_206B_200F_200E_206D_202E((Object)(object)_206B_202D_206B_200E_206A_206C_202E_202A_206E_200B_206E_206D_200D_206C_206B_202C_200D_206C_200D_206E_200E_206D_200E_206D_200E_206D_200E_206C_202B_202A_200E_200B_206D_202C_206F_202E_206B_202A_206E_202E_202E((Component)(object)this));
				num = 2047211595;
				continue;
			case 0u:
				num = (int)((num2 * 1569559389) ^ 0x2FB2FFA1);
				continue;
			case 19u:
				switch (value)
				{
				case 0:
					break;
				case 1:
					goto IL_0218;
				case 4:
					goto IL_02ab;
				case 3:
					goto IL_0302;
				default:
					goto IL_0375;
				case 2:
					goto IL_0405;
				}
				goto case 11u;
			case 24u:
			{
				int num3;
				int num4;
				if (_206B_200B_200F_200D_206E_206C_206D_206D_206C_200C_206B_200B_206E_202A_206C_202D_202D_206C_206A_202B_206D_202D_200E_200F_202A_206E_200F_206F_200F_202C_202D_206E_202A_206D_206C_200C_206F_206A_202C_206C_202E != null)
				{
					num3 = 249952953;
					num4 = num3;
				}
				else
				{
					num3 = 1292947419;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 1667914372);
				continue;
			}
			case 27u:
				return;
			case 29u:
				num = ((int)num2 * -1272966352) ^ 0xB40AF1A;
				continue;
			case 25u:
				_206B_200B_200F_200D_206E_206C_206D_206D_206C_200C_206B_200B_206E_202A_206C_202D_202D_206C_206A_202B_206D_202D_200E_200F_202A_206E_200F_206F_200F_202C_202D_206E_202A_206D_206C_200C_206F_206A_202C_206C_202E();
				num = ((int)num2 * -1469329282) ^ 0xB833015;
				continue;
			case 30u:
				num = (int)((num2 * 1116117737) ^ 0x7A70BB64);
				continue;
			case 5u:
				goto IL_0405;
			case 2u:
				return;
				IL_0405:
				array = moves;
				num = 1898228522;
				continue;
				IL_0375:
				num = (int)((num2 * 45657934) ^ 0x3F853D5F);
				continue;
				IL_0302:
				array = beattacks;
				num = 863656486;
				continue;
				IL_02ab:
				array = effects;
				num = 247893164;
				continue;
				IL_0218:
				array = attacks;
				num = 647417368;
				continue;
			}
			break;
			IL_01be:
			int num11;
			if (currentIndex < array.Length)
			{
				num = 2047211595;
				num11 = num;
			}
			else
			{
				num = 45322082;
				num11 = num;
			}
			continue;
			IL_019b:
			int num12;
			if (_202D_200C_200B_206B_206A_202D_202D_206E_206C_206D_206A_200E_200E_206B_200E_206D_202E_206F_206C_206B_200D_206E_200D_200E_206D_200C_200B_206F_202A_202C_202E_200C_206B_206A_206D_206A_202E_202C_206B_206F_202E.TryGetValue(text, out value))
			{
				num = 1305113443;
				num12 = num;
			}
			else
			{
				num = 1406089960;
				num12 = num;
			}
			continue;
			IL_0101:
			int num13;
			if (!_202D_200B_200F_202D_206F_206C_202E_202A_206D_202C_202D_202C_200D_206A_206B_200B_202C_206C_206E_202B_202E_200F_200D_206B_200D_200B_200F_200B_202B_202C_206A_202B_206B_206F_206A_206B_200D_202A_202B_200D_202E(currentState, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3377577262u)))
			{
				num = 2047211595;
				num13 = num;
			}
			else
			{
				num = 904432476;
				num13 = num;
			}
		}
		goto IL_000f;
		IL_01dd:
		int num14;
		if (array == null)
		{
			num = 856113100;
			num14 = num;
		}
		else
		{
			num = 1286352632;
			num14 = num;
		}
		goto IL_0014;
	}

	public void Play2(string state, float transparency = 1f, int index = 0, CommonSettings.VoidCallBack callback = null)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		if (transparency != 1f)
		{
			goto IL_000b;
		}
		goto IL_00a2;
		IL_000b:
		int num = 1113931355;
		goto IL_0010;
		IL_0010:
		Color val = default(Color);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x48E3FC44)) % 6)
			{
			case 2u:
				break;
			default:
				return;
			case 3u:
				val = _206C_202E_200C_200F_202D_200D_206D_202C_202E_206C_200E_202A_202D_206A_202B_206A_202D_206D_206D_202B_206E_202A_202A_206C_200D_200C_202A_202D_200C_202D_202A_202E_206B_200C_202A_200F_206A_206A_206E_200C_202E(_206A_200C_200E_200C_202C_206A_200F_200E_200B_206E_200E_200F_202A_202C_206B_200D_202A_200C_202D_200B_202A_206F_206D_202A_200C_202A_206E_200B_200C_200D_200E_206F_206C_200C_206B_200F_202C_206A_202C_206C_202E((Renderer)(object)bindImage));
				num = (int)(num2 * 493245696) ^ -642664808;
				continue;
			case 5u:
				currentIndex = index;
				_206B_200B_200F_200D_206E_206C_206D_206D_206C_200C_206B_200B_206E_202A_206C_202D_202D_206C_206A_202B_206D_202D_200E_200F_202A_206E_200F_206F_200F_202C_202D_206E_202A_206D_206C_200C_206F_206A_202C_206C_202E = callback;
				num = (int)(num2 * 1297543018) ^ -477996634;
				continue;
			case 4u:
				val.a = transparency;
				_206A_200B_202A_202A_202A_206A_200F_206F_202C_206A_200F_200C_202D_202D_206A_206C_206C_200C_202D_200C_200D_202D_200F_206C_206D_206F_202C_202A_206D_200B_200B_206A_202A_202C_200E_200E_200F_200B_206E_202E_202E(_206A_200C_200E_200C_202C_206A_200F_200E_200B_206E_200E_200F_202A_202C_206B_200D_202A_200C_202D_200B_202A_206F_206D_202A_200C_202A_206E_200B_200C_200D_200E_206F_206C_200C_206B_200F_202C_206A_202C_206C_202E((Renderer)(object)bindImage), val);
				num = (int)(num2 * 1866635598) ^ -90759381;
				continue;
			case 1u:
				goto IL_00a2;
			case 0u:
				return;
			}
			break;
		}
		goto IL_000b;
		IL_00a2:
		currentState = state;
		num = 1797572913;
		goto IL_0010;
	}

	public int GetIndex()
	{
		return currentIndex;
	}

	public void SetPos(int x, int y)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		_202D_202B_202B_202C_202D_202D_206B_206E_206F_202D_202C_202D_206C_202B_206F_202E_202E_206D_200E_200C_202D_202D_206F_202E_202A_202C_206E_200E_200F_202A_206C_202E_206C_206E_202D_202A_200E_206A_206E_202E((Component)(object)this).position = new Vector3(BattleField.ToScreenX(x), BattleField.ToScreenY(y), (float)(-200 + y));
	}

	static bool _206E_202A_200E_206A_206B_206C_206C_206F_202C_200F_202C_202C_202D_206A_206F_202D_206B_206A_206C_206E_200C_202C_206D_200C_202E_206F_202D_206F_202C_202B_206B_202E_200F_206F_206B_202A_200E_202A_206F_202E_202E(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}

	static void _206F_202B_206B_202E_202E_206F_200D_200B_202B_202A_206C_202D_206E_200C_206D_200B_202A_200D_202E_202D_206F_202E_206E_200E_200D_202D_202A_206E_200F_200F_200E_206D_200B_206A_202C_206A_206B_206D_206E_200F_202E(MonoBehaviour P_0, string P_1, float P_2, float P_3)
	{
		P_0.InvokeRepeating(P_1, P_2, P_3);
	}

	static bool _202D_200B_200F_202D_206F_206C_202E_202A_206D_202C_202D_202C_200D_206A_206B_200B_202C_206C_206E_202B_202E_200F_200D_206B_200D_200B_200F_200B_202B_202C_206A_202B_206B_206F_206A_206B_200D_202A_202B_200D_202E(string P_0, string P_1)
	{
		return P_0 == P_1;
	}

	static GameObject _206B_202D_206B_200E_206A_206C_202E_202A_206E_200B_206E_206D_200D_206C_206B_202C_200D_206C_200D_206E_200E_206D_200E_206D_200E_206D_200E_206C_202B_202A_200E_200B_206D_202C_206F_202E_206B_202A_206E_202E_202E(Component P_0)
	{
		return P_0.gameObject;
	}

	static void _200C_206A_200B_206B_206C_206B_206D_206A_206B_202D_202E_202D_206D_200E_206E_202A_202C_206E_202D_202E_200D_206C_202C_202B_200B_200E_206D_206B_206F_200E_206A_202D_200E_200D_206D_202E_206B_200F_200E_206D_202E(Object P_0)
	{
		Object.Destroy(P_0);
	}

	static void _206F_202D_206A_206B_202E_202A_206E_202C_206D_202E_206E_202A_200D_206D_206C_200C_206C_202E_206D_200F_206B_200D_206A_202B_206D_200D_206C_206F_200C_202D_202B_206B_200C_206E_202B_200F_202D_200B_202A_206D_202E(SpriteRenderer P_0, Sprite P_1)
	{
		P_0.sprite = P_1;
	}

	static Material _206A_200C_200E_200C_202C_206A_200F_200E_200B_206E_200E_200F_202A_202C_206B_200D_202A_200C_202D_200B_202A_206F_206D_202A_200C_202A_206E_200B_200C_200D_200E_206F_206C_200C_206B_200F_202C_206A_202C_206C_202E(Renderer P_0)
	{
		return P_0.material;
	}

	static Color _206C_202E_200C_200F_202D_200D_206D_202C_202E_206C_200E_202A_202D_206A_202B_206A_202D_206D_206D_202B_206E_202A_202A_206C_200D_200C_202A_202D_200C_202D_202A_202E_206B_200C_202A_200F_206A_206A_206E_200C_202E(Material P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.color;
	}

	static void _206A_200B_202A_202A_202A_206A_200F_206F_202C_206A_200F_200C_202D_202D_206A_206C_206C_200C_202D_200C_200D_202D_200F_206C_206D_206F_202C_202A_206D_200B_200B_206A_202A_202C_200E_200E_200F_200B_206E_202E_202E(Material P_0, Color P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.color = P_1;
	}

	static Transform _202D_202B_202B_202C_202D_202D_206B_206E_206F_202D_202C_202D_206C_202B_206F_202E_202E_206D_200E_200C_202D_202D_206F_202E_202A_202C_206E_200E_200F_202A_206C_202E_206C_206E_202D_202A_200E_206A_206E_202E(Component P_0)
	{
		return P_0.transform;
	}
}
