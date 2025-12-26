using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ayscTest : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _206B_200B_206C_202E_202C_206B_202C_206E_202C_202B_202C_202C_202D_202E_206F_202B_202E_206A_206A_202B_200E_206C_206D_200B_200B_206C_206B_200C_200B_202A_200E_206F_200D_202A_202E_202A_202D_202D_206C_206B_202E : IEnumerator<object>, IEnumerator, IDisposable
	{
		internal WWW _202A_200D_202E_206C_200E_202E_200D_206F_202E_206B_200C_206B_202E_206A_200C_202B_202D_206E_202E_202E_206F_206F_206C_200E_206A_202E_206A_202B_202B_200B_200B_202A_202B_202D_200D_202E_206C_206F_202B_200C_202E;

		internal Texture2D t;

		internal int _0024PC;

		internal object _0024current;

		internal Texture2D _200E_206D_200D_200B_202E_206C_202D_200C_206E_200F_206D_200E_202E_202E_202E_202C_206C_202B_206B_206F_202D_202A_200F_200B_200C_206A_202E_202E_206E_202C_202E_206D_202C_206A_206D_206A_206F_202E_206A_202D_202E;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _0024current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _0024current;
			}
		}

		public bool MoveNext()
		{
			uint num = (uint)_0024PC;
			bool result = default(bool);
			while (true)
			{
				int num2 = 1884810572;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num2 ^ 0x4CE554B4)) % 10)
					{
					case 0u:
						break;
					case 5u:
						return false;
					case 4u:
						_0024PC = -1;
						num2 = ((int)num3 * -1382888541) ^ 0x243721D9;
						continue;
					case 7u:
						_202A_200D_202E_206C_200E_202E_200D_206F_202E_206B_200C_206B_202E_206A_200C_202B_202D_206E_202E_202E_206F_206F_206C_200E_206A_202E_206A_202B_202B_200B_200B_202A_202B_202D_200D_202E_206C_206F_202B_200C_202E = _206D_202E_200E_202E_200B_200C_200E_206C_202C_202D_202B_206D_202E_202B_202A_206E_200C_200F_206B_202A_202D_206C_202C_202B_206E_206C_206E_206A_206D_200F_202D_202E_206B_202B_202E_200E_206C_206F_206E_206A_202E(_206E_200F_200F_206B_206A_202E_200F_202D_200B_206B_200D_206C_206C_206A_206F_206F_200B_200B_200B_200D_200D_206C_200C_202B_202E_202C_202E_202B_200E_200B_206A_202D_206B_206B_200B_200C_206F_202B_200E_202D_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(643345515u), _206F_202A_206B_200B_200E_200E_200C_202D_206F_200B_200D_206F_206A_206A_202D_206A_202D_200D_206E_200D_200C_202E_202B_200F_206F_202C_202D_206F_206D_202B_206F_200D_206A_206C_206F_200B_206E_200C_200C_202E_202E(), global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1304327735u)));
						num2 = 248401550;
						continue;
					case 6u:
						_0024PC = -1;
						switch (num)
						{
						case 0u:
							break;
						default:
							goto IL_00b0;
						case 1u:
							goto IL_0105;
						}
						goto case 7u;
					case 9u:
						num2 = (int)(num3 * 1167386971) ^ -1341007980;
						continue;
					case 3u:
						return true;
					case 8u:
						_0024current = _202A_200D_202E_206C_200E_202E_200D_206F_202E_206B_200C_206B_202E_206A_200C_202B_202D_206E_202E_202E_206F_206F_206C_200E_206A_202E_206A_202B_202B_200B_200B_202A_202B_202D_200D_202E_206C_206F_202B_200C_202E;
						_0024PC = 1;
						num2 = (int)((num3 * 543355788) ^ 0x2542FA51);
						continue;
					case 2u:
						goto IL_0105;
					default:
						{
							return result;
						}
						IL_0105:
						_202C_202E_200F_202D_206D_202E_202E_200E_200F_202C_200C_206D_202E_206F_200E_200C_206A_200D_206A_202A_202C_202A_202C_200F_202D_200F_206C_200F_202B_202E_202A_200C_206C_202B_206D_206F_206C_206F_200F_202E_202E(_202A_200D_202E_206C_200E_202E_200D_206F_202E_206B_200C_206B_202E_206A_200C_202B_202D_206E_202E_202E_206F_206F_206C_200E_206A_202E_206A_202B_202B_200B_200B_202A_202B_202D_200D_202E_206C_206F_202B_200C_202E, t);
						num2 = 248939718;
						continue;
						IL_00b0:
						num2 = ((int)num3 * -30281891) ^ -265038547;
						continue;
					}
					break;
				}
			}
		}

		[DebuggerHidden]
		public void Dispose()
		{
			_0024PC = -1;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw _206B_206D_200B_202D_202C_202C_200E_206D_206D_206F_206A_202B_206D_206D_202A_200B_200C_200E_202E_202E_202A_202E_206C_206C_200F_202E_202C_202E_200E_206F_200C_206B_200E_202A_202D_200F_206F_200B_206A_202E();
		}

		static string _206F_202A_206B_200B_200E_200E_200C_202D_206F_200B_200D_206F_206A_206A_202D_206A_202D_200D_206E_200D_200C_202E_202B_200F_206F_202C_202D_206F_206D_202B_206F_200D_206A_206C_206F_200B_206E_200C_200C_202E_202E()
		{
			return Application.dataPath;
		}

		static string _206E_200F_200F_206B_206A_202E_200F_202D_200B_206B_200D_206C_206C_206A_206F_206F_200B_200B_200B_200D_200D_206C_200C_202B_202E_202C_202E_202B_200E_200B_206A_202D_206B_206B_200B_200C_206F_202B_200E_202D_202E(string P_0, string P_1, string P_2)
		{
			return P_0 + P_1 + P_2;
		}

		static WWW _206D_202E_200E_202E_200B_200C_200E_206C_202C_202D_202B_206D_202E_202B_202A_206E_200C_200F_206B_202A_202D_206C_202C_202B_206E_206C_206E_206A_206D_200F_202D_202E_206B_202B_202E_200E_206C_206F_206E_206A_202E(string P_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Expected O, but got Unknown
			return new WWW(P_0);
		}

		static void _202C_202E_200F_202D_206D_202E_202E_200E_200F_202C_200C_206D_202E_206F_200E_200C_206A_200D_206A_202A_202C_202A_202C_200F_202D_200F_206C_200F_202B_202E_202A_200C_206C_202B_206D_206F_206C_206F_200F_202E_202E(WWW P_0, Texture2D P_1)
		{
			P_0.LoadImageIntoTexture(P_1);
		}

		static NotSupportedException _206B_206D_200B_202D_202C_202C_200E_206D_206D_206F_206A_202B_206D_206D_202A_200B_200C_200E_202E_202E_202A_202E_206C_206C_200F_202E_202C_202E_200E_206F_200C_206B_200E_202A_202D_200F_206F_200B_206A_202E()
		{
			return new NotSupportedException();
		}
	}

	public Image asycImage;

	public void OnTest()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		Texture2D val = _202A_200F_206A_206D_202E_206F_202A_200F_200D_200B_206E_200B_202E_202A_206C_202D_200C_206E_206E_206C_200E_206F_206D_200C_202D_206E_206F_200E_200C_206C_206E_200C_200E_202C_206D_200D_202E_202B_202C_202B_202E(1, 1);
		Sprite sprite = default(Sprite);
		while (true)
		{
			int num = -2003149548;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1294333318)) % 5)
				{
				case 0u:
					break;
				default:
					return;
				case 4u:
					sprite = Sprite.Create(val, new Rect(0f, 0f, 1f, 1f), new Vector2(0.5f, 0.5f));
					num = ((int)num2 * -246816827) ^ -45367847;
					continue;
				case 1u:
					((MonoBehaviour)this).StartCoroutine(startDownloadImage(val));
					num = ((int)num2 * -1431510360) ^ 0x17264645;
					continue;
				case 3u:
					asycImage.sprite = sprite;
					num = (int)(num2 * 447269944) ^ -304652605;
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private IEnumerator startDownloadImage(Texture2D t)
	{
		WWW val = default(WWW);
		while (true)
		{
			int num = 1884810572;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4CE554B4)) % 10)
				{
				case 0u:
					break;
				case 5u:
					yield break;
				case 4u:
					num = ((int)num2 * -1382888541) ^ 0x243721D9;
					continue;
				case 7u:
					val = _206B_200B_206C_202E_202C_206B_202C_206E_202C_202B_202C_202C_202D_202E_206F_202B_202E_206A_206A_202B_200E_206C_206D_200B_200B_206C_206B_200C_200B_202A_200E_206F_200D_202A_202E_202A_202D_202D_206C_206B_202E._206D_202E_200E_202E_200B_200C_200E_206C_202C_202D_202B_206D_202E_202B_202A_206E_200C_200F_206B_202A_202D_206C_202C_202B_206E_206C_206E_206A_206D_200F_202D_202E_206B_202B_202E_200E_206C_206F_206E_206A_202E(_206B_200B_206C_202E_202C_206B_202C_206E_202C_202B_202C_202C_202D_202E_206F_202B_202E_206A_206A_202B_200E_206C_206D_200B_200B_206C_206B_200C_200B_202A_200E_206F_200D_202A_202E_202A_202D_202D_206C_206B_202E._206E_200F_200F_206B_206A_202E_200F_202D_200B_206B_200D_206C_206C_206A_206F_206F_200B_200B_200B_200D_200D_206C_200C_202B_202E_202C_202E_202B_200E_200B_206A_202D_206B_206B_200B_200C_206F_202B_200E_202D_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(643345515u), _206B_200B_206C_202E_202C_206B_202C_206E_202C_202B_202C_202C_202D_202E_206F_202B_202E_206A_206A_202B_200E_206C_206D_200B_200B_206C_206B_200C_200B_202A_200E_206F_200D_202A_202E_202A_202D_202D_206C_206B_202E._206F_202A_206B_200B_200E_200E_200C_202D_206F_200B_200D_206F_206A_206A_202D_206A_202D_200D_206E_200D_200C_202E_202B_200F_206F_202C_202D_206F_206D_202B_206F_200D_206A_206C_206F_200B_206E_200C_200C_202E_202E(), global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1304327735u)));
					num = 248401550;
					continue;
				case 6u:
				{
					uint num3;
					switch (num3)
					{
					case 0u:
						break;
					default:
						goto IL_00b0;
					case 1u:
						goto IL_0105;
					}
					goto case 7u;
				}
				case 9u:
					num = (int)(num2 * 1167386971) ^ -1341007980;
					continue;
				case 3u:
					/*Error near IL_00d5: Unexpected return in MoveNext()*/;
				case 8u:
					yield return val;
					/*Error: Unable to find 'return true' for yield return*/;
				case 2u:
					goto IL_0105;
				default:
					yield break;
				case 1u:
					yield break;
					IL_0105:
					_206B_200B_206C_202E_202C_206B_202C_206E_202C_202B_202C_202C_202D_202E_206F_202B_202E_206A_206A_202B_200E_206C_206D_200B_200B_206C_206B_200C_200B_202A_200E_206F_200D_202A_202E_202A_202D_202D_206C_206B_202E._202C_202E_200F_202D_206D_202E_202E_200E_200F_202C_200C_206D_202E_206F_200E_200C_206A_200D_206A_202A_202C_202A_202C_200F_202D_200F_206C_200F_202B_202E_202A_200C_206C_202B_206D_206F_206C_206F_200F_202E_202E(val, t);
					num = 248939718;
					continue;
					IL_00b0:
					num = ((int)num2 * -30281891) ^ -265038547;
					continue;
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

	static Texture2D _202A_200F_206A_206D_202E_206F_202A_200F_200D_200B_206E_200B_202E_202A_206C_202D_200C_206E_206E_206C_200E_206F_206D_200C_202D_206E_206F_200E_200C_206C_206E_200C_200E_202C_206D_200D_202E_202B_202C_202B_202E(int P_0, int P_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new Texture2D(P_0, P_1);
	}
}
