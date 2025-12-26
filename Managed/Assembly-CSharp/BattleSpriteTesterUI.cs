using System.Runtime.CompilerServices;
using JyGame;
using UnityEngine;
using UnityEngine.UI;

public class BattleSpriteTesterUI : MonoBehaviour
{
	public GameObject SpeedSlider;

	[CompilerGenerated]
	private static CommonSettings.VoidCallBack _206F_202B_206E_202D_202E_202B_202E_202C_202B_202A_200C_202A_202B_202E_202D_200F_206B_200E_202C_202C_206F_206C_200D_206B_200C_200C_202B_202E_206F_202D_200D_202C_202D_206C_206A_206B_202E_200D_206C_206D_202E;

	[CompilerGenerated]
	private static CommonSettings.VoidCallBack _206B_202A_202B_206A_206C_202B_206F_202C_200C_206A_200E_206F_202A_206D_200D_206D_200C_202C_206A_200E_206B_200B_200B_206F_200F_202B_206B_206E_202D_206E_206C_206C_206F_206B_200C_206A_206F_206F_206D_206B_202E;

	public void Stand()
	{
		Animator[] array = Object.FindObjectsOfType<Animator>();
		Animator[] array2 = array;
		UserDefinedAnimation[] array3 = default(UserDefinedAnimation[]);
		int num3 = default(int);
		Animator val = default(Animator);
		int num4 = default(int);
		UserDefinedAnimation userDefinedAnimation = default(UserDefinedAnimation);
		while (true)
		{
			int num = 163832716;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7A1E20A7)) % 14)
				{
				case 11u:
					break;
				default:
					return;
				case 13u:
				{
					UserDefinedAnimation[] array4 = Object.FindObjectsOfType<UserDefinedAnimation>();
					array3 = array4;
					num = (int)((num2 * 332625958) ^ 0x71B5BAB5);
					continue;
				}
				case 0u:
					num3++;
					num = (int)(num2 * 469907414) ^ -1993560600;
					continue;
				case 12u:
					num = (int)((num2 * 101539326) ^ 0x2D9575F0);
					continue;
				case 9u:
					_200C_206D_202C_206B_206F_202E_202A_200B_206A_206F_202E_200F_200F_206F_206E_202C_202E_206C_200C_200E_206E_200D_206A_200E_202B_206C_202D_206B_202B_200F_206B_206F_202D_206E_206D_200F_200C_202E_202C_202E(val, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2564145736u));
					num = (int)(num2 * 102320731) ^ -1538668754;
					continue;
				case 4u:
					num4++;
					num = ((int)num2 * -1335692608) ^ -1251887939;
					continue;
				case 3u:
				{
					int num6;
					if (num3 < array2.Length)
					{
						num = 334446769;
						num6 = num;
					}
					else
					{
						num = 685945400;
						num6 = num;
					}
					continue;
				}
				case 2u:
					num4 = 0;
					num = ((int)num2 * -1308486110) ^ 0x39BD35AD;
					continue;
				case 8u:
				{
					int num5;
					if (num4 >= array3.Length)
					{
						num = 2099768097;
						num5 = num;
					}
					else
					{
						num = 629497486;
						num5 = num;
					}
					continue;
				}
				case 7u:
					userDefinedAnimation.Play(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2855833049u));
					num = ((int)num2 * -1163216181) ^ -1889326994;
					continue;
				case 5u:
					userDefinedAnimation = array3[num4];
					num = 1266828312;
					continue;
				case 6u:
					val = array2[num3];
					num = 1033746738;
					continue;
				case 1u:
					num3 = 0;
					num = (int)(num2 * 779193633) ^ -1467859594;
					continue;
				case 10u:
					return;
				}
				break;
			}
		}
	}

	public void Move()
	{
		Animator[] array = Object.FindObjectsOfType<Animator>();
		UserDefinedAnimation[] array3 = default(UserDefinedAnimation[]);
		int num3 = default(int);
		UserDefinedAnimation[] array2 = default(UserDefinedAnimation[]);
		int num4 = default(int);
		Animator val = default(Animator);
		Animator[] array4 = default(Animator[]);
		UserDefinedAnimation userDefinedAnimation = default(UserDefinedAnimation);
		while (true)
		{
			int num = 228287533;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0xDA454D5)) % 14)
				{
				case 5u:
					break;
				default:
					return;
				case 11u:
					array3 = Object.FindObjectsOfType<UserDefinedAnimation>();
					num = (int)(num2 * 1530311603) ^ -723515194;
					continue;
				case 9u:
				{
					int num6;
					if (num3 < array2.Length)
					{
						num = 1740070775;
						num6 = num;
					}
					else
					{
						num = 2018194574;
						num6 = num;
					}
					continue;
				}
				case 12u:
					num4 = 0;
					num = ((int)num2 * -898025816) ^ -186146395;
					continue;
				case 3u:
					val = array4[num4];
					num = 1324042172;
					continue;
				case 7u:
					_200C_206D_202C_206B_206F_202E_202A_200B_206A_206F_202E_200F_200F_206F_206E_202C_202E_206C_200C_200E_206E_200D_206A_200E_202B_206C_202D_206B_202B_200F_206B_206F_202D_206E_206D_200F_200C_202E_202C_202E(val, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(544411040u));
					num = (int)((num2 * 511383918) ^ 0x5BE38BDB);
					continue;
				case 10u:
				{
					int num5;
					if (num4 >= array4.Length)
					{
						num = 523033932;
						num5 = num;
					}
					else
					{
						num = 1478093732;
						num5 = num;
					}
					continue;
				}
				case 6u:
					array4 = array;
					num = (int)(num2 * 2113762955) ^ -1609236125;
					continue;
				case 0u:
					userDefinedAnimation = array2[num3];
					num = 477208878;
					continue;
				case 1u:
					userDefinedAnimation.Play(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1875408266u));
					num3++;
					num = ((int)num2 * -1213525217) ^ -592850931;
					continue;
				case 8u:
					num4++;
					num = ((int)num2 * -351029325) ^ 0x7F26F77F;
					continue;
				case 2u:
					array2 = array3;
					num3 = 0;
					num = ((int)num2 * -150508225) ^ -732221584;
					continue;
				case 4u:
					num = ((int)num2 * -2096943121) ^ -1608319473;
					continue;
				case 13u:
					return;
				}
				break;
			}
		}
	}

	public void Attack()
	{
		Animator[] array = Object.FindObjectsOfType<Animator>();
		Animator[] array4 = default(Animator[]);
		int num5 = default(int);
		UserDefinedAnimation[] array2 = default(UserDefinedAnimation[]);
		int num3 = default(int);
		UserDefinedAnimation[] array3 = default(UserDefinedAnimation[]);
		while (true)
		{
			int num = -1311975062;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -174341805)) % 13)
				{
				case 12u:
					break;
				default:
					return;
				case 0u:
					num = ((int)num2 * -47888257) ^ -1681652004;
					continue;
				case 11u:
				{
					Animator val = array4[num5];
					_200C_206D_202C_206B_206F_202E_202A_200B_206A_206F_202E_200F_200F_206F_206E_202C_202E_206C_200C_200E_206E_200D_206A_200E_202B_206C_202D_206B_202B_200F_206B_206F_202D_206E_206D_200F_200C_202E_202C_202E(val, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(914069573u));
					num5++;
					num = -861850620;
					continue;
				}
				case 1u:
				{
					int num6;
					if (num5 >= array4.Length)
					{
						num = -537618355;
						num6 = num;
					}
					else
					{
						num = -1096586698;
						num6 = num;
					}
					continue;
				}
				case 5u:
					num5 = 0;
					num = ((int)num2 * -813621252) ^ -1249910937;
					continue;
				case 2u:
				{
					UserDefinedAnimation userDefinedAnimation = array2[num3];
					userDefinedAnimation.Play(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3558100660u));
					num = -2016547808;
					continue;
				}
				case 7u:
					num = ((int)num2 * -1321644708) ^ -1051831292;
					continue;
				case 9u:
				{
					int num4;
					if (num3 < array2.Length)
					{
						num = -796469992;
						num4 = num;
					}
					else
					{
						num = -785576397;
						num4 = num;
					}
					continue;
				}
				case 4u:
					array4 = array;
					num = ((int)num2 * -1882054256) ^ -1020108678;
					continue;
				case 10u:
					array3 = Object.FindObjectsOfType<UserDefinedAnimation>();
					num = ((int)num2 * -749289435) ^ -147815071;
					continue;
				case 3u:
					array2 = array3;
					num3 = 0;
					num = (int)((num2 * 1829669716) ^ 0x49EDFD5A);
					continue;
				case 8u:
					num3++;
					num = ((int)num2 * -1866246935) ^ 0x4E5C2F53;
					continue;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	public void BeAttack()
	{
		Animator[] array = Object.FindObjectsOfType<Animator>();
		UserDefinedAnimation[] array4 = default(UserDefinedAnimation[]);
		int num5 = default(int);
		UserDefinedAnimation[] array3 = default(UserDefinedAnimation[]);
		int num3 = default(int);
		Animator[] array2 = default(Animator[]);
		Animator val = default(Animator);
		while (true)
		{
			int num = -554629173;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1874363343)) % 16)
				{
				case 6u:
					break;
				default:
					return;
				case 8u:
					array4 = Object.FindObjectsOfType<UserDefinedAnimation>();
					num = (int)(num2 * 1252839389) ^ -1827106999;
					continue;
				case 1u:
				{
					int num6;
					if (num5 >= array3.Length)
					{
						num = -1417680742;
						num6 = num;
					}
					else
					{
						num = -214696874;
						num6 = num;
					}
					continue;
				}
				case 7u:
				{
					UserDefinedAnimation userDefinedAnimation = array3[num5];
					userDefinedAnimation.Play(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4271991361u));
					num = -363522516;
					continue;
				}
				case 15u:
					num3++;
					num = ((int)num2 * -1447242760) ^ -1631036948;
					continue;
				case 10u:
					array2 = array;
					num = ((int)num2 * -404157864) ^ 0x32CA5F8;
					continue;
				case 0u:
					array3 = array4;
					num = ((int)num2 * -2006693485) ^ 0x55D687C2;
					continue;
				case 9u:
					num3 = 0;
					num = (int)(num2 * 913748136) ^ -412546985;
					continue;
				case 2u:
					val = array2[num3];
					num = -514931875;
					continue;
				case 13u:
					num5++;
					num = ((int)num2 * -630614541) ^ 0x2476A137;
					continue;
				case 14u:
					num = (int)(num2 * 999705171) ^ -1458245394;
					continue;
				case 3u:
					num5 = 0;
					num = ((int)num2 * -1088498263) ^ 0x1F27AA5E;
					continue;
				case 4u:
					num = ((int)num2 * -1222557779) ^ 0x64465684;
					continue;
				case 12u:
					_200C_206D_202C_206B_206F_202E_202A_200B_206A_206F_202E_200F_200F_206F_206E_202C_202E_206C_200C_200E_206E_200D_206A_200E_202B_206C_202D_206B_202B_200F_206B_206F_202D_206E_206D_200F_200C_202E_202C_202E(val, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4142157536u));
					num = (int)((num2 * 378159686) ^ 0x4F34EB96);
					continue;
				case 5u:
				{
					int num4;
					if (num3 < array2.Length)
					{
						num = -1990895565;
						num4 = num;
					}
					else
					{
						num = -325850519;
						num4 = num;
					}
					continue;
				}
				case 11u:
					return;
				}
				break;
			}
		}
	}

	public int GetStateNumberFromPrefab(Animator animator)
	{
		return 4;
	}

	public void OnSpeedChange()
	{
		float num = _200C_202B_202A_202D_206E_200C_206F_206F_200C_206A_202B_202D_200F_206E_200F_206A_200B_200D_202C_200B_202D_206E_200D_206F_202B_200D_206C_202D_200F_202A_206A_202A_200F_200C_202D_202E_206E_200D_202D_202B_202E(SpeedSlider.GetComponent<Slider>());
		while (true)
		{
			int num2 = 740082467;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x33DB7CF6)) % 3)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_0033;
				case 0u:
					return;
				}
				break;
				IL_0033:
				_200B_206A_206A_202C_206F_200D_200E_206C_202C_206A_202D_202D_202E_206B_202C_200D_202C_200B_206F_200E_202B_202B_206E_202D_206F_200D_202B_202E_206C_202B_202C_202B_202E_202C_202E_206A_206D_202E_200B_206B_202E(num);
				num2 = ((int)num3 * -1337034956) ^ 0x5287F690;
			}
		}
	}

	public void TestUserDefinedAnimations()
	{
		UserDefinedAnimationManager.instance._parent = (MonoBehaviour)(object)this;
		while (true)
		{
			int num = 1176666934;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4EF13380)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_002d;
				case 2u:
					return;
				}
				break;
				IL_002d:
				UserDefinedAnimationManager.instance.Init(delegate
				{
					GameObject val = UserDefinedAnimationManager.instance.GenerateObject(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1874729630u), global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3281915115u));
					GameObject val2 = default(GameObject);
					SkillAnimation skillAnimation = default(SkillAnimation);
					while (true)
					{
						int num3 = 636290366;
						while (true)
						{
							uint num4;
							switch ((num4 = (uint)(num3 ^ 0x1F3D3485)) % 7)
							{
							case 0u:
								break;
							case 3u:
								_200F_200C_200B_206C_206C_202D_202A_202D_200E_202C_206C_202A_202D_206C_202E_200F_202D_202E_202B_202B_206E_202D_206B_202C_206D_206A_202E_202D_200F_200B_200E_206C_206A_206B_206E_206C_200B_206A_202A_202B_202E((Object)(object)val, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1911417824u));
								num3 = (int)((num4 * 529267619) ^ 0x780469D9);
								continue;
							case 6u:
								_206A_206E_200F_206E_200D_202D_200F_200D_200E_202A_202A_200E_206C_202B_206F_206B_206E_200D_206C_202D_206C_200E_200C_200D_206D_200B_206D_202C_200C_206E_200F_206E_200D_200D_206D_206A_206E_200B_202E_206D_202E(_200B_206E_206E_206F_206F_202C_200B_200D_202B_200B_206E_202D_202D_202C_206F_200B_200F_206D_200D_206B_200E_202B_206C_200F_202B_206A_200E_200C_202D_202B_202A_200E_202A_200F_202D_206B_202B_206A_206E_206A_202E(val), _206C_206E_200C_202A_206B_200B_200D_200F_200F_202E_206D_202C_202B_202B_206D_202B_206E_200C_202B_202D_202A_206D_206D_206A_202A_206D_206E_206E_202E_202A_202A_202C_202C_200D_200F_206D_202E_200E_200C_206A_202E((Component)(object)this));
								num3 = ((int)num4 * -464211079) ^ 0x4034FC7F;
								continue;
							case 5u:
								val2 = UserDefinedAnimationManager.instance.GenerateObject(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2286699093u), global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2224505140u));
								num3 = (int)((num4 * 1137833521) ^ 0x720A740B);
								continue;
							case 2u:
								val2.GetComponent<UserDefinedAnimation>().Play(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3087221919u), delegate
								{
									_200B_202E_202B_202C_206B_206C_206F_202B_206D_206F_206B_206A_206D_206A_206B_202E_206D_206C_206C_200D_200B_200B_200B_200E_206F_206C_206B_206C_200D_200D_200E_202B_202B_202B_200F_202C_206E_200F_202B_202A_202E((object)global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2094286705u));
								});
								skillAnimation.DisplayEffectNotFollowSprite();
								num3 = 208418110;
								continue;
							case 4u:
								skillAnimation = val2.AddComponent<SkillAnimation>();
								skillAnimation.SetCallback(delegate
								{
									_200B_202E_202B_202C_206B_206C_206F_202B_206D_206F_206B_206A_206D_206A_206B_202E_206D_206C_206C_200D_200B_200B_200B_200E_206F_206C_206B_206C_200D_200D_200E_202B_202B_202B_200F_202C_206E_200F_202B_202A_202E((object)global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2004662739u));
								});
								num3 = 504063838;
								continue;
							default:
								_206A_206E_200F_206E_200D_202D_200F_200D_200E_202A_202A_200E_206C_202B_206F_206B_206E_200D_206C_202D_206C_200E_200C_200D_206D_200B_206D_202C_200C_206E_200F_206E_200D_200D_206D_206A_206E_200B_202E_206D_202E(_200B_206E_206E_206F_206F_202C_200B_200D_202B_200B_206E_202D_202D_202C_206F_200B_200F_206D_200D_206B_200E_202B_206C_200F_202B_206A_200E_200C_202D_202B_202A_200E_202A_200F_202D_206B_202B_206A_206E_206A_202E(val2), _206C_206E_200C_202A_206B_200B_200D_200F_200F_202E_206D_202C_202B_202B_206D_202B_206E_200C_202B_202D_202A_206D_206D_206A_202A_206D_206E_206E_202E_202A_202A_202C_202C_200D_200F_206D_202E_200E_200C_206A_202E((Component)(object)this));
								return;
							}
							break;
						}
					}
				});
				num = ((int)num2 * -486874078) ^ -1910938951;
			}
		}
	}

	private void Start()
	{
		if (CommonSettings.MOD_KEY() < 0)
		{
			return;
		}
		while (true)
		{
			int num = -210338887;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -883376097)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_002a;
				case 1u:
					return;
				}
				break;
				IL_002a:
				TestUserDefinedAnimations();
				num = ((int)num2 * -309032165) ^ -6918161;
			}
		}
	}

	private void Update()
	{
	}

	[CompilerGenerated]
	private void _206A_206D_202E_202B_206B_206A_200D_200F_206E_200E_200E_200D_202B_206B_202E_200E_206D_200E_202B_202E_202B_206E_200C_206C_202C_202B_200B_200C_202A_202E_206B_206C_202E_206C_200F_202A_200D_202E_200B_202A_202E()
	{
		GameObject val = UserDefinedAnimationManager.instance.GenerateObject(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1874729630u), global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3281915115u));
		GameObject val2 = default(GameObject);
		SkillAnimation skillAnimation = default(SkillAnimation);
		while (true)
		{
			int num = 636290366;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1F3D3485)) % 7)
				{
				case 0u:
					break;
				case 3u:
					_200F_200C_200B_206C_206C_202D_202A_202D_200E_202C_206C_202A_202D_206C_202E_200F_202D_202E_202B_202B_206E_202D_206B_202C_206D_206A_202E_202D_200F_200B_200E_206C_206A_206B_206E_206C_200B_206A_202A_202B_202E((Object)(object)val, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1911417824u));
					num = (int)((num2 * 529267619) ^ 0x780469D9);
					continue;
				case 6u:
					_206A_206E_200F_206E_200D_202D_200F_200D_200E_202A_202A_200E_206C_202B_206F_206B_206E_200D_206C_202D_206C_200E_200C_200D_206D_200B_206D_202C_200C_206E_200F_206E_200D_200D_206D_206A_206E_200B_202E_206D_202E(_200B_206E_206E_206F_206F_202C_200B_200D_202B_200B_206E_202D_202D_202C_206F_200B_200F_206D_200D_206B_200E_202B_206C_200F_202B_206A_200E_200C_202D_202B_202A_200E_202A_200F_202D_206B_202B_206A_206E_206A_202E(val), _206C_206E_200C_202A_206B_200B_200D_200F_200F_202E_206D_202C_202B_202B_206D_202B_206E_200C_202B_202D_202A_206D_206D_206A_202A_206D_206E_206E_202E_202A_202A_202C_202C_200D_200F_206D_202E_200E_200C_206A_202E((Component)(object)this));
					num = ((int)num2 * -464211079) ^ 0x4034FC7F;
					continue;
				case 5u:
					val2 = UserDefinedAnimationManager.instance.GenerateObject(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2286699093u), global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2224505140u));
					num = (int)((num2 * 1137833521) ^ 0x720A740B);
					continue;
				case 2u:
					val2.GetComponent<UserDefinedAnimation>().Play(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3087221919u), delegate
					{
						_200B_202E_202B_202C_206B_206C_206F_202B_206D_206F_206B_206A_206D_206A_206B_202E_206D_206C_206C_200D_200B_200B_200B_200E_206F_206C_206B_206C_200D_200D_200E_202B_202B_202B_200F_202C_206E_200F_202B_202A_202E((object)global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2094286705u));
					});
					skillAnimation.DisplayEffectNotFollowSprite();
					num = 208418110;
					continue;
				case 4u:
					skillAnimation = val2.AddComponent<SkillAnimation>();
					skillAnimation.SetCallback(delegate
					{
						_200B_202E_202B_202C_206B_206C_206F_202B_206D_206F_206B_206A_206D_206A_206B_202E_206D_206C_206C_200D_200B_200B_200B_200E_206F_206C_206B_206C_200D_200D_200E_202B_202B_202B_200F_202C_206E_200F_202B_202A_202E((object)global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2004662739u));
					});
					num = 504063838;
					continue;
				default:
					_206A_206E_200F_206E_200D_202D_200F_200D_200E_202A_202A_200E_206C_202B_206F_206B_206E_200D_206C_202D_206C_200E_200C_200D_206D_200B_206D_202C_200C_206E_200F_206E_200D_200D_206D_206A_206E_200B_202E_206D_202E(_200B_206E_206E_206F_206F_202C_200B_200D_202B_200B_206E_202D_202D_202C_206F_200B_200F_206D_200D_206B_200E_202B_206C_200F_202B_206A_200E_200C_202D_202B_202A_200E_202A_200F_202D_206B_202B_206A_206E_206A_202E(val2), _206C_206E_200C_202A_206B_200B_200D_200F_200F_202E_206D_202C_202B_202B_206D_202B_206E_200C_202B_202D_202A_206D_206D_206A_202A_206D_206E_206E_202E_202A_202A_202C_202C_200D_200F_206D_202E_200E_200C_206A_202E((Component)(object)this));
					return;
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private static void _202A_200D_206E_202D_202C_200E_206C_202D_202D_206D_202B_200D_206F_206A_202C_206F_206B_200F_206D_206A_200F_202C_202B_200E_200D_200D_202E_206C_202D_206A_200E_206F_202B_200D_200E_206F_206D_202C_202D_202E_202E()
	{
		_200B_202E_202B_202C_206B_206C_206F_202B_206D_206F_206B_206A_206D_206A_206B_202E_206D_206C_206C_200D_200B_200B_200B_200E_206F_206C_206B_206C_200D_200D_200E_202B_202B_202B_200F_202C_206E_200F_202B_202A_202E((object)global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2004662739u));
	}

	[CompilerGenerated]
	private static void _206D_202C_202B_206C_206B_200C_206D_200E_206F_200D_206A_202E_202A_202B_206A_202D_206A_206D_202A_200F_202B_202E_202A_202D_202B_200B_206B_202D_202D_202E_206B_200C_206F_202A_202D_200B_200D_206B_206F_202D_202E()
	{
		_200B_202E_202B_202C_206B_206C_206F_202B_206D_206F_206B_206A_206D_206A_206B_202E_206D_206C_206C_200D_200B_200B_200B_200E_206F_206C_206B_206C_200D_200D_200E_202B_202B_202B_200F_202C_206E_200F_202B_202A_202E((object)global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2094286705u));
	}

	static void _200C_206D_202C_206B_206F_202E_202A_200B_206A_206F_202E_200F_200F_206F_206E_202C_202E_206C_200C_200E_206E_200D_206A_200E_202B_206C_202D_206B_202B_200F_206B_206F_202D_206E_206D_200F_200C_202E_202C_202E(Animator P_0, string P_1)
	{
		P_0.Play(P_1);
	}

	static float _200C_202B_202A_202D_206E_200C_206F_206F_200C_206A_202B_202D_200F_206E_200F_206A_200B_200D_202C_200B_202D_206E_200D_206F_202B_200D_206C_202D_200F_202A_206A_202A_200F_200C_202D_202E_206E_200D_202D_202B_202E(Slider P_0)
	{
		return P_0.value;
	}

	static void _200B_206A_206A_202C_206F_200D_200E_206C_202C_206A_202D_202D_202E_206B_202C_200D_202C_200B_206F_200E_202B_202B_206E_202D_206F_200D_202B_202E_206C_202B_202C_202B_202E_202C_202E_206A_206D_202E_200B_206B_202E(float P_0)
	{
		Time.timeScale = P_0;
	}

	static void _200F_200C_200B_206C_206C_202D_202A_202D_200E_202C_206C_202A_202D_206C_202E_200F_202D_202E_202B_202B_206E_202D_206B_202C_206D_206A_202E_202D_200F_200B_200E_206C_206A_206B_206E_206C_200B_206A_202A_202B_202E(Object P_0, string P_1)
	{
		P_0.name = P_1;
	}

	static Transform _200B_206E_206E_206F_206F_202C_200B_200D_202B_200B_206E_202D_202D_202C_206F_200B_200F_206D_200D_206B_200E_202B_206C_200F_202B_206A_200E_200C_202D_202B_202A_200E_202A_200F_202D_206B_202B_206A_206E_206A_202E(GameObject P_0)
	{
		return P_0.transform;
	}

	static Transform _206C_206E_200C_202A_206B_200B_200D_200F_200F_202E_206D_202C_202B_202B_206D_202B_206E_200C_202B_202D_202A_206D_206D_206A_202A_206D_206E_206E_202E_202A_202A_202C_202C_200D_200F_206D_202E_200E_200C_206A_202E(Component P_0)
	{
		return P_0.transform;
	}

	static void _206A_206E_200F_206E_200D_202D_200F_200D_200E_202A_202A_200E_206C_202B_206F_206B_206E_200D_206C_202D_206C_200E_200C_200D_206D_200B_206D_202C_200C_206E_200F_206E_200D_200D_206D_206A_206E_200B_202E_206D_202E(Transform P_0, Transform P_1)
	{
		P_0.SetParent(P_1);
	}

	static void _200B_202E_202B_202C_206B_206C_206F_202B_206D_206F_206B_206A_206D_206A_206B_202E_206D_206C_206C_200D_200B_200B_200B_200E_206F_206C_206B_206C_200D_200D_200E_202B_202B_202B_200F_202C_206E_200F_202B_202A_202E(object P_0)
	{
		Debug.Log(P_0);
	}
}
