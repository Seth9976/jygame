using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace JyGame;

public class ModEditorResourceManager
{
	[CompilerGenerated]
	private sealed class _202E_202A_200B_206D_200D_206F_202E_202C_202D_200B_206B_206D_206C_206C_200D_206B_206B_202D_200D_206E_206B_206D_206B_200D_202E_202B_200F_206B_202D_200F_200C_200D_202D_200D_206A_200C_206C_202E_206D_206C_202E : IEnumerator<object>, IEnumerator, IDisposable
	{
		internal string path;

		internal WWW _202A_200D_202E_206C_200E_202E_200D_206F_202E_206B_200C_206B_202E_206A_200C_202B_202D_206E_202E_202E_206F_206F_206C_200E_206A_202E_206A_202B_202B_200B_200B_202A_202B_202D_200D_202E_206C_206F_202B_200C_202E;

		internal string _202B_202D_206E_202A_202B_206A_202E_200C_200C_206C_202A_202B_206B_200E_200C_206A_202B_202D_202E_202A_202B_200E_200B_200B_200B_200E_206E_206D_200B_206F_206B_200C_206A_200C_202D_200F_206F_202B_202D_200F_202E;

		internal CommonSettings.VoidCallBack callback;

		internal int _0024PC;

		internal object _0024current;

		internal string _206C_202A_206B_202E_202E_202C_200D_206D_200E_202B_206C_206C_202B_200E_206E_202B_206A_202D_206C_200C_200D_200E_206B_206D_200B_200B_202E_206A_200D_206C_200D_200C_202E_206B_206E_200B_200F_200F_200B_202B_202E;

		internal CommonSettings.VoidCallBack _206A_202A_200B_206C_206D_206E_206A_200D_202E_206D_200F_200B_202A_206C_200B_206A_206D_202C_202D_206C_206C_200C_206E_206D_200C_200F_206C_200F_200E_202E_206E_200D_200E_206D_206F_206C_206D_200C_202E_202B_202E;

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
				int num2 = -1122099282;
				while (true)
				{
					uint num3;
					int num5;
					switch ((num3 = (uint)(num2 ^ -780083310)) % 17)
					{
					case 7u:
						break;
					case 14u:
						num2 = (int)(num3 * 1923318923) ^ -1100186542;
						continue;
					case 1u:
						_202A_200D_202E_206C_200E_202E_200D_206F_202E_206B_200C_206B_202E_206A_200C_202B_202D_206E_202E_202E_206F_206F_206C_200E_206A_202E_206A_202B_202B_200B_200B_202A_202B_202D_200D_202E_206C_206F_202B_200C_202E = _202D_200C_206A_202D_202B_206E_200F_200D_206F_202E_200D_206B_200D_200E_202E_206A_206A_202C_206B_202A_200C_206E_202C_206E_200E_206D_202E_200C_200C_202D_200F_200D_206C_200B_200E_206A_202A_206C_206F_200C_202E(_202C_200D_206C_206F_206A_206F_202C_206E_200F_206E_206F_200E_202A_206E_206F_206A_202D_206E_200F_202E_200E_200E_200C_202D_206D_202B_200F_202D_200C_206B_206B_202E_202B_206B_202C_206B_206B_206A_202D_200D_202E(ModManager.ModBaseUrl, path));
						num2 = -38793632;
						continue;
					case 6u:
						return true;
					case 11u:
						goto IL_00a5;
					case 5u:
						switch (num)
						{
						case 0u:
							break;
						case 1u:
							goto IL_00a5;
						default:
							goto IL_00d9;
						}
						goto case 1u;
					case 12u:
						_202D_206C_200D_200D_206F_206F_206C_206D_206D_200D_202B_200E_206F_202A_206E_202B_200D_200C_202D_202A_200D_202D_202C_206C_200F_206D_200D_200B_202A_206A_206B_206C_202C_206D_202A_202E_206F_202C_200F_206A_202E((object)_206C_206A_206D_200C_200C_202D_200C_200F_202E_200C_200E_200E_202C_206C_200B_206F_206C_202C_202E_206F_206C_206A_206F_202E_202D_206F_200D_200F_202A_206D_206B_206B_206A_206F_200C_206E_202B_200B_202B_206F_202E(_202A_200D_202E_206C_200E_202E_200D_206F_202E_206B_200C_206B_202E_206A_200C_202B_202D_206E_202E_202E_206F_206F_206C_200E_206A_202E_206A_202B_202B_200B_200B_202A_202B_202D_200D_202E_206C_206F_202B_200C_202E));
						num2 = (int)((num3 * 19883536) ^ 0x6C676476);
						continue;
					case 4u:
						return false;
					case 15u:
						_200F_206E_200B_200B_202E_200D_202C_202A_202D_200D_206B_206F_200C_206D_206D_200B_200B_202E_206F_206B_202D_202C_206F_200F_200C_206D_206D_202A_202B_202C_206A_200B_202D_202A_202D_206C_202C_206D_200C_202A_202E(_202A_200D_202E_206C_200E_202E_200D_206F_202E_206B_200C_206B_202E_206A_200C_202B_202D_206E_202E_202E_206F_206F_206C_200E_206A_202E_206A_202B_202B_200B_200B_202A_202B_202D_200D_202E_206C_206F_202B_200C_202E);
						num2 = -1962449716;
						continue;
					case 0u:
						xmls.Add(_202B_202D_206E_202A_202B_206A_202E_200C_200C_206C_202A_202B_206B_200E_200C_206A_202B_202D_202E_202A_202B_200E_200B_200B_200B_200E_206E_206D_200B_206F_206B_200C_206A_200C_202D_200F_206F_202B_202D_200F_202E, _206D_200D_206D_202B_202D_202A_200E_206A_206C_206E_206C_206D_200E_202E_202C_202B_200D_206B_206F_206A_200C_202D_200B_200F_202B_202B_200B_200F_202D_202B_200C_200C_202E_206A_202E_200C_206C_206D_200C_206F_202E(_202A_200D_202E_206C_200E_202E_200D_206F_202E_206B_200C_206B_202E_206A_200C_202B_202D_206E_202E_202E_206F_206F_206C_200E_206A_202E_206A_202B_202B_200B_200B_202A_202B_202D_200D_202E_206C_206F_202B_200C_202E));
						num2 = ((int)num3 * -953376212) ^ -1575223738;
						continue;
					case 13u:
						_0024PC = -1;
						num2 = (int)((num3 * 1891882121) ^ 0x6C8EF9C1);
						continue;
					case 10u:
					{
						_202B_202D_206E_202A_202B_206A_202E_200C_200C_206C_202A_202B_206B_200E_200C_206A_202B_202D_202E_202A_202B_200E_200B_200B_200B_200E_206E_206D_200B_206F_206B_200C_206A_200C_202D_200F_206F_202B_202D_200F_202E = _200B_200E_206A_206C_206C_202C_202D_206F_206B_200E_200B_200D_202B_202D_200B_202A_200F_206A_200D_202B_206F_206C_200F_206B_206F_206E_200E_202A_206A_206D_206B_200D_200B_206E_200E_206A_206A_206A_202C_202E_202E(path, new char[1] { '.' })[0];
						int num4;
						if (!xmls.ContainsKey(_202B_202D_206E_202A_202B_206A_202E_200C_200C_206C_202A_202B_206B_200E_200C_206A_202B_202D_202E_202A_202B_200E_200B_200B_200B_200E_206E_206D_200B_206F_206B_200C_206A_200C_202D_200F_206F_202B_202D_200F_202E))
						{
							num2 = -2130897585;
							num4 = num2;
						}
						else
						{
							num2 = -421443142;
							num4 = num2;
						}
						continue;
					}
					case 9u:
						num2 = (int)((num3 * 101971245) ^ 0x131DCDB7);
						continue;
					case 16u:
						_0024current = _202A_200D_202E_206C_200E_202E_200D_206F_202E_206B_200C_206B_202E_206A_200C_202B_202D_206E_202E_202E_206F_206F_206C_200E_206A_202E_206A_202B_202B_200B_200B_202A_202B_202D_200D_202E_206C_206F_202B_200C_202E;
						_0024PC = 1;
						num2 = (int)(num3 * 1909484407) ^ -18042798;
						continue;
					case 2u:
						callback();
						num2 = -1607017370;
						continue;
					case 8u:
						_0024PC = -1;
						num2 = ((int)num3 * -1629252486) ^ -1202066534;
						continue;
					default:
						{
							return result;
						}
						IL_00d9:
						num2 = (int)((num3 * 278940241) ^ 0x50761B1A);
						continue;
						IL_00a5:
						if (_206B_206E_202B_200E_200C_202E_200D_202E_202E_202D_206A_200F_206F_202B_202D_206A_202A_200D_206A_202A_200F_202A_206B_200B_200C_206D_206C_202C_200C_206F_202D_206A_202B_202D_200D_206E_206B_200F_202E_202B_202E(_206C_206A_206D_200C_200C_202D_200C_200F_202E_200C_200E_200E_202C_206C_200B_206F_206C_202C_202E_206F_206C_206A_206F_202E_202D_206F_200D_200F_202A_206D_206B_206B_206A_206F_200C_206E_202B_200B_202B_206F_202E(_202A_200D_202E_206C_200E_202E_200D_206F_202E_206B_200C_206B_202E_206A_200C_202B_202D_206E_202E_202E_206F_206F_206C_200E_206A_202E_206A_202B_202B_200B_200B_202A_202B_202D_200D_202E_206C_206F_202B_200C_202E)))
						{
							num2 = -1167421812;
							num5 = num2;
						}
						else
						{
							num2 = -2003884365;
							num5 = num2;
						}
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
			throw _202C_206C_202B_206C_200C_200E_202E_206B_206D_200B_206A_202B_200D_206E_206E_202B_202A_202D_206C_206C_206D_200E_206E_206E_202C_202B_202D_206A_206D_206B_200B_200E_202D_202A_206D_206B_206C_202E_202B_206A_202E();
		}

		static string _202C_200D_206C_206F_206A_206F_202C_206E_200F_206E_206F_200E_202A_206E_206F_206A_202D_206E_200F_202E_200E_200E_200C_202D_206D_202B_200F_202D_200C_206B_206B_202E_202B_206B_202C_206B_206B_206A_202D_200D_202E(string P_0, string P_1)
		{
			return P_0 + P_1;
		}

		static WWW _202D_200C_206A_202D_202B_206E_200F_200D_206F_202E_200D_206B_200D_200E_202E_206A_206A_202C_206B_202A_200C_206E_202C_206E_200E_206D_202E_200C_200C_202D_200F_200D_206C_200B_200E_206A_202A_206C_206F_200C_202E(string P_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Expected O, but got Unknown
			return new WWW(P_0);
		}

		static string _206C_206A_206D_200C_200C_202D_200C_200F_202E_200C_200E_200E_202C_206C_200B_206F_206C_202C_202E_206F_206C_206A_206F_202E_202D_206F_200D_200F_202A_206D_206B_206B_206A_206F_200C_206E_202B_200B_202B_206F_202E(WWW P_0)
		{
			return P_0.error;
		}

		static bool _206B_206E_202B_200E_200C_202E_200D_202E_202E_202D_206A_200F_206F_202B_202D_206A_202A_200D_206A_202A_200F_202A_206B_200B_200C_206D_206C_202C_200C_206F_202D_206A_202B_202D_200D_206E_206B_200F_202E_202B_202E(string P_0)
		{
			return string.IsNullOrEmpty(P_0);
		}

		static void _202D_206C_200D_200D_206F_206F_206C_206D_206D_200D_202B_200E_206F_202A_206E_202B_200D_200C_202D_202A_200D_202D_202C_206C_200F_206D_200D_200B_202A_206A_206B_206C_202C_206D_202A_202E_206F_202C_200F_206A_202E(object P_0)
		{
			Debug.LogError(P_0);
		}

		static string[] _200B_200E_206A_206C_206C_202C_202D_206F_206B_200E_200B_200D_202B_202D_200B_202A_200F_206A_200D_202B_206F_206C_200F_206B_206F_206E_200E_202A_206A_206D_206B_200D_200B_206E_200E_206A_206A_206A_202C_202E_202E(string P_0, char[] P_1)
		{
			return P_0.Split(P_1);
		}

		static string _206D_200D_206D_202B_202D_202A_200E_206A_206C_206E_206C_206D_200E_202E_202C_202B_200D_206B_206F_206A_200C_202D_200B_200F_202B_202B_200B_200F_202D_202B_200C_200C_202E_206A_202E_200C_206C_206D_200C_206F_202E(WWW P_0)
		{
			return P_0.text;
		}

		static void _200F_206E_200B_200B_202E_200D_202C_202A_202D_200D_206B_206F_200C_206D_206D_200B_200B_202E_206F_206B_202D_202C_206F_200F_200C_206D_206D_202A_202B_202C_206A_200B_202D_202A_202D_206C_202C_206D_200C_202A_202E(WWW P_0)
		{
			P_0.Dispose();
		}

		static NotSupportedException _202C_206C_202B_206C_200C_200E_202E_206B_206D_200B_206A_202B_200D_206E_206E_202B_202A_202D_206C_206C_206D_200E_206E_206E_202C_202B_202D_206A_206D_206B_200B_200E_202D_202A_206D_206B_206C_202E_202B_206A_202E()
		{
			return new NotSupportedException();
		}
	}

	[CompilerGenerated]
	private sealed class _206D_202D_206D_200C_200F_202B_206E_202C_206E_200C_202E_202D_202D_206B_202C_202B_206C_206C_202A_200D_206D_200B_202B_206F_206B_206F_202E_206C_202E_202A_202D_202B_202C_200E_206F_200D_206D_200E_206B_200E_202E
	{
		public string path;
	}

	[CompilerGenerated]
	private sealed class _206C_200E_200D_200E_202E_200C_202E_200C_206D_200E_206A_200D_202D_200F_206E_202D_206E_206F_202C_206C_200E_206A_200F_200D_200E_202B_206D_206A_202A_206B_202C_202E_202D_206E_200E_206D_206B_200E_202C_206D_202E
	{
		public Sprite result;

		public _206D_202D_206D_200C_200F_202B_206E_202C_206E_200C_202E_202D_202D_206B_202C_202B_206C_206C_202A_200D_206D_200B_202B_206F_206B_206F_202E_206C_202E_202A_202D_202B_202C_200E_206F_200D_206D_200E_206B_200E_202E CS_0024_003C_003E8__locals1;

		internal void _202B_202A_206F_202E_202B_206A_206A_206A_206B_206F_206B_206E_206E_206F_206B_206D_206C_200C_200F_206E_206E_206D_206C_202E_206D_206E_202E_200E_206B_202E_200B_202E_206B_202D_206D_202D_206A_200D_202C_206F_202E()
		{
			spriteCache[CS_0024_003C_003E8__locals1.path] = result;
		}
	}

	[CompilerGenerated]
	private sealed class _200C_202D_206C_206A_202D_202E_200E_202A_206D_202A_202A_206D_206B_206D_206F_200F_206B_202E_206D_206D_202D_202E_200C_200B_200C_200D_200B_200E_200B_206B_202A_202C_202A_206C_206E_206E_202E_206D_206E_200C_202E
	{
		public string path;
	}

	[CompilerGenerated]
	private sealed class _200E_206B_200D_202E_200F_206D_202B_202C_200B_202A_202B_200E_200C_202D_202B_206E_200C_200B_206C_206E_206B_200B_202A_202D_206A_200E_202C_206A_206E_206D_200C_200D_202E_200F_200B_200C_206A_202A_202D_202A_202E
	{
		public Sprite result;

		public _200C_202D_206C_206A_202D_202E_200E_202A_206D_202A_202A_206D_206B_206D_206F_200F_206B_202E_206D_206D_202D_202E_200C_200B_200C_200D_200B_200E_200B_206B_202A_202C_202A_206C_206E_206E_202E_206D_206E_200C_202E CS_0024_003C_003E8__locals1;

		internal void _202D_200C_202C_202E_200B_202C_202B_202D_206C_206A_206B_206F_200F_202E_200D_206C_200D_206A_206C_200F_206A_202D_200F_200D_202D_202B_200D_202D_202C_206F_206A_206B_200F_206C_206D_200F_202D_206C_200C_200D_202E()
		{
			spriteCache[CS_0024_003C_003E8__locals1.path] = result;
		}
	}

	[CompilerGenerated]
	private sealed class _206B_202A_206F_200C_206D_206C_202E_200E_206D_206A_200C_202C_202E_200F_200C_200F_200F_206D_206D_202E_202B_206C_202A_202E_206F_200B_200B_200B_206E_200D_206D_206F_206D_200B_206E_206D_200C_206B_206F_200C_202E
	{
		public string path;
	}

	[CompilerGenerated]
	private sealed class _206E_202C_200E_200E_200F_202D_206B_206D_202A_206B_206A_202B_206F_206F_202D_200F_202C_206C_200E_206B_200B_202A_206E_202A_206A_200B_202B_200D_206D_200B_202E_202C_206E_202C_202E_202B_200F_202B_200E_200C_202E
	{
		public Sprite result;

		public _206B_202A_206F_200C_206D_206C_202E_200E_206D_206A_200C_202C_202E_200F_200C_200F_200F_206D_206D_202E_202B_206C_202A_202E_206F_200B_200B_200B_206E_200D_206D_206F_206D_200B_206E_206D_200C_206B_206F_200C_202E CS_0024_003C_003E8__locals1;

		internal void _200D_202A_206C_206E_200F_206C_200C_200D_202A_202C_202E_206D_200C_200C_206A_202C_206D_206A_200E_202E_200C_206B_206E_202E_200F_202B_200C_202E_202C_206D_206E_206F_206E_200C_202C_206A_200E_202C_200E_200E_202E()
		{
			spriteCache[CS_0024_003C_003E8__locals1.path] = result;
		}
	}

	[CompilerGenerated]
	private sealed class _206E_202C_206E_200E_206E_206D_202A_206E_202D_206A_200F_202C_206F_200C_200B_200D_206B_206E_202D_202D_200B_206C_202D_200B_206C_202D_202E_200E_206C_200F_200D_200F_202E_200F_206C_206F_206E_206C_202A_202D_202E : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E;

		private object _200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E;

		public string path;

		public CommonSettings.VoidCallBack callback;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E;
			}
		}

		[DebuggerHidden]
		public _206E_202C_206E_200E_206E_206D_202A_206E_202D_206A_200F_202C_206F_200C_200B_200D_206B_206E_202D_202D_200B_206C_202D_200B_206C_202D_202E_200E_206C_200F_200D_200F_202E_200F_206C_206F_206E_206C_202A_202D_202E(int P_0)
		{
			_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = P_0;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E;
			string key = default(string);
			int num8 = default(int);
			while (true)
			{
				int num2 = -920600724;
				while (true)
				{
					uint num3;
					string text;
					switch ((num3 = (uint)(num2 ^ -137856963)) % 14)
					{
					case 8u:
						break;
					case 12u:
						_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
						num2 = -919296863;
						continue;
					case 10u:
					{
						int num6;
						int num7;
						if (xmls.ContainsKey(key))
						{
							num6 = 172972080;
							num7 = num6;
						}
						else
						{
							num6 = 1089968578;
							num7 = num6;
						}
						num2 = num6 ^ ((int)num3 * -1797332638);
						continue;
					}
					case 7u:
						text = path;
						goto IL_00a5;
					case 11u:
						_200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E = 0;
						num2 = -1474369593;
						continue;
					case 4u:
					{
						int num9;
						int num10;
						if (num == 1)
						{
							num9 = 1315452443;
							num10 = num9;
						}
						else
						{
							num9 = 218370558;
							num10 = num9;
						}
						num2 = num9 ^ (int)(num3 * 388062530);
						continue;
					}
					case 13u:
						if (num8 != -1)
						{
							text = _206C_200D_206D_206C_200D_206D_202D_206D_202E_202C_202A_206C_202B_206A_200D_206E_206C_206B_202C_206C_206C_200C_202C_202E_200D_206F_202B_202A_202A_202D_202D_200E_202E_206C_202A_200F_200C_200E_202E_200C_202E(path, 0, num8);
							goto IL_00a5;
						}
						num2 = (int)(num3 * 744007580) ^ -1178982392;
						continue;
					case 1u:
						return false;
					case 2u:
						_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 1;
						return true;
					case 5u:
						xmls.Add(key, _206E_202A_206C_200D_200F_200B_200B_206E_202C_200E_200D_200D_200C_202B_206F_202E_200E_206B_200D_206A_206B_202D_206D_202A_206B_206C_206E_200C_206E_206A_206C_206D_202D_202B_206F_200B_200B_202A_200F_202E_202E(ModManager.ModBaseUrlPath, path));
						num2 = (int)(num3 * 96067988) ^ -1711149464;
						continue;
					case 0u:
						_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
						num2 = -1621606754;
						continue;
					case 6u:
						num8 = _206C_202E_202E_200F_206F_202D_206E_206F_206A_206E_206A_202C_202A_202D_206B_200C_202C_200B_206E_206F_200C_206F_206E_200F_200B_202E_206F_200F_202B_206E_202D_200B_206C_202E_200F_206D_200C_206E_206C_202B_202E(path, '.');
						num2 = ((int)num3 * -1637383973) ^ -952600942;
						continue;
					case 3u:
					{
						int num4;
						int num5;
						if (num == 0)
						{
							num4 = -370266475;
							num5 = num4;
						}
						else
						{
							num4 = -175293365;
							num5 = num4;
						}
						num2 = num4 ^ (int)(num3 * 1194777712);
						continue;
					}
					default:
						{
							callback();
							return false;
						}
						IL_00a5:
						key = text;
						num2 = -569195649;
						continue;
					}
					break;
				}
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw _200C_202B_206D_200D_202D_206C_200D_200C_206F_206B_206B_200C_206E_206D_206A_200D_200D_200D_200F_200C_206A_206A_200D_200F_202B_206C_200E_200F_202E_206D_200E_206D_206F_206F_202E_206D_206A_206F_200D_206D_202E();
		}

		static int _206C_202E_202E_200F_206F_202D_206E_206F_206A_206E_206A_202C_202A_202D_206B_200C_202C_200B_206E_206F_200C_206F_206E_200F_200B_202E_206F_200F_202B_206E_202D_200B_206C_202E_200F_206D_200C_206E_206C_202B_202E(string P_0, char P_1)
		{
			return P_0.LastIndexOf(P_1);
		}

		static string _206C_200D_206D_206C_200D_206D_202D_206D_202E_202C_202A_206C_202B_206A_200D_206E_206C_206B_202C_206C_206C_200C_202C_202E_200D_206F_202B_202A_202A_202D_202D_200E_202E_206C_202A_200F_200C_200E_202E_200C_202E(string P_0, int P_1, int P_2)
		{
			return P_0.Substring(P_1, P_2);
		}

		static string _206E_202A_206C_200D_200F_200B_200B_206E_202C_200E_200D_200D_200C_202B_206F_202E_200E_206B_200D_206A_206B_202D_206D_202A_206B_206C_206E_200C_206E_206A_206C_206D_202D_202B_206F_200B_200B_202A_200F_202E_202E(string P_0, string P_1)
		{
			return P_0 + P_1;
		}

		static NotSupportedException _200C_202B_206D_200D_202D_206C_200D_200C_206F_206B_206B_200C_206E_206D_206A_200D_200D_200D_200F_200C_206A_206A_200D_200F_202B_206C_200E_200F_202E_206D_200E_206D_206F_206F_202E_206D_206A_206F_200D_206D_202E()
		{
			return new NotSupportedException();
		}
	}

	private static AudioClip acCache;

	public static Dictionary<string, string> sprites;

	public static Dictionary<string, string> audios;

	public static Dictionary<string, string> xmls;

	public static Dictionary<string, Sprite> spriteCache;

	internal static bool PreCacheSpritesLoaded;

	public static Sprite LogoCache;

	public static Dictionary<string, Sprite> uiCache;

	public static Dictionary<string, Font> fontCache;

	static ModEditorResourceManager()
	{
		acCache = null;
		sprites = new Dictionary<string, string>();
		while (true)
		{
			int num = -1379371282;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -798894292)) % 5)
				{
				case 0u:
					break;
				case 4u:
					audios = new Dictionary<string, string>();
					num = ((int)num2 * -1792728078) ^ -488335248;
					continue;
				case 1u:
					xmls = new Dictionary<string, string>();
					num = (int)((num2 * 1016973895) ^ 0x430B7AD4);
					continue;
				case 2u:
					spriteCache = new Dictionary<string, Sprite>();
					num = (int)((num2 * 996343736) ^ 0x6AD97AEE);
					continue;
				default:
					uiCache = new Dictionary<string, Sprite>();
					fontCache = new Dictionary<string, Font>();
					return;
				}
				break;
			}
		}
	}

	public static Sprite GetSprite(string key)
	{
		if (!sprites.ContainsKey(key))
		{
			while (true)
			{
				uint num;
				switch ((num = 2129487349u) % 3)
				{
				case 0u:
					continue;
				case 1u:
					return null;
				}
				break;
			}
		}
		return LoadSprite(sprites[key]);
	}

	public static void GetAudioClip(string key, Action<AudioClip> callback)
	{
		if (!audios.ContainsKey(key))
		{
			while (true)
			{
				uint num;
				switch ((num = 399978478u) % 3)
				{
				case 0u:
					continue;
				case 1u:
					callback(null);
					return;
				}
				break;
			}
		}
		LoadAudio(audios[key], callback);
	}

	internal static string GetXml(string path)
	{
		if (xmls.ContainsKey(path))
		{
			while (true)
			{
				int num = 1888673812;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x3871FE98)) % 3)
					{
					case 2u:
						break;
					case 1u:
						goto IL_0032;
					default:
					{
						StreamReader streamReader = _202B_200B_200C_202A_200B_202A_202E_200D_200F_206C_202A_206C_200F_202B_200C_206C_206A_202A_200E_200D_200F_202D_202E_200D_200B_202C_202A_206E_200F_206A_206E_200C_200D_206C_206E_200E_206D_200B_206B_206D_202E(xmls[path]);
						try
						{
							return _200B_206B_206B_200E_200F_200D_200F_202D_202C_202A_202A_200E_206D_206B_206D_206C_202C_200E_202E_200C_200B_200E_206E_200E_202A_206E_206B_206E_206B_202E_206D_202E_200B_200D_200B_206D_202C_200D_206C_206B_202E((TextReader)streamReader);
						}
						finally
						{
							if (streamReader != null)
							{
								while (true)
								{
									IL_0073:
									int num3 = 988077158;
									while (true)
									{
										switch ((num2 = (uint)(num3 ^ 0x3871FE98)) % 3)
										{
										case 0u:
											break;
										default:
											goto end_IL_0078;
										case 1u:
											goto IL_0095;
										case 2u:
											goto end_IL_0078;
										}
										goto IL_0073;
										IL_0095:
										_200C_202E_202D_206F_202C_206E_200F_202D_206D_202C_206F_206C_202E_206A_200F_206D_200F_206F_200B_206A_202B_200E_206C_206E_206D_200C_206B_200E_206C_202E_200F_200E_206D_202E_206B_202C_202A_200C_202B_206F_202E((IDisposable)streamReader);
										num3 = (int)((num2 * 370719814) ^ 0x3E146F5B);
										continue;
										end_IL_0078:
										break;
									}
									break;
								}
							}
						}
					}
					}
					break;
					IL_0032:
					if (!_206F_202D_200C_202C_202B_200C_206A_202A_206F_202D_206A_206D_202C_200D_200B_206F_206D_202B_206E_206A_206C_206C_200D_202D_200B_200C_200F_200C_200F_206D_200C_200F_202E_200D_202A_200C_206E_200D_200E_206D_202E(xmls[path]))
					{
						goto end_IL_0010;
					}
					num = (int)(num2 * 790103475) ^ -2126598102;
				}
				continue;
				end_IL_0010:
				break;
			}
			while (true)
			{
				WWW val = _200F_206A_200E_206C_200E_206B_200C_202B_206F_206A_200B_206A_206B_202C_202D_202C_206A_202E_202B_206A_206A_202E_200F_202E_200D_206E_206B_202B_202A_202E_206C_202A_206D_202E_202B_202C_202C_206A_202B_206E_202E(_202E_206E_200E_202E_202A_200C_202C_206B_202B_206A_202A_206D_206D_206D_200B_206F_200D_206B_200B_206F_202B_202D_206A_202C_202D_206A_200F_206A_202E_202C_206D_202A_202D_206F_200F_206B_206A_200B_206B_202E_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2365642362u), xmls[path]));
				int num4 = 1923354590;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num4 ^ 0x3871FE98)) % 6)
					{
					case 5u:
						num4 = 462164523;
						continue;
					case 1u:
						break;
					case 4u:
					{
						int num5;
						int num6;
						if (_206E_206D_200C_202A_206F_206E_200C_200F_206C_206A_200F_200E_200F_206A_200C_206A_206A_202E_206F_202D_206E_206E_200C_200E_200C_200E_200C_202A_200C_200F_202A_202E_206D_206B_200B_206D_206D_206A_202B_200E_202E(_206B_202B_200B_202C_206D_202D_202A_200C_200E_202D_200C_206C_200B_202C_206B_202D_206B_200B_206A_202A_206A_200C_200C_200B_200D_200B_202A_202D_200C_200E_202B_202C_202C_206B_202E_200E_202A_206E_206E_200C_202E(val)))
						{
							num5 = 261710125;
							num6 = num5;
						}
						else
						{
							num5 = 1049485758;
							num6 = num5;
						}
						num4 = num5 ^ ((int)num2 * -1928284656);
						continue;
					}
					case 2u:
						_202B_200C_202E_206F_206F_202C_206D_202E_206E_202E_200B_206D_200D_202E_202A_202C_202A_200D_202D_200C_200E_206D_202B_206F_202D_206F_206D_200B_206E_206C_202D_200E_206B_206F_202C_206E_200D_202D_206F_202E_202E((object)_206B_202B_200B_202C_206D_202D_202A_200C_200E_202D_200C_206C_200B_202C_206B_202D_206B_200B_206A_202A_206A_200C_200C_200B_200D_200B_202A_202D_200C_200E_202B_202C_202C_206B_202E_200E_202A_206E_206E_200C_202E(val));
						num4 = 1629276980;
						continue;
					case 3u:
						return _206C_206C_200B_200F_200C_202A_206C_200B_206A_200B_206C_200D_202D_206C_202D_206D_206C_200C_200E_200F_202E_200B_200D_200C_202E_206A_202C_202C_206A_202E_200E_200B_200F_206B_202B_200E_206D_206F_206E_200D_202E(val);
					default:
						goto end_IL_00db;
					}
					break;
				}
				continue;
				end_IL_00db:
				break;
			}
		}
		return null;
	}

	public static void Clear()
	{
		sprites.Clear();
		audios.Clear();
		xmls.Clear();
	}

	public static void AddSprite(string key, string path)
	{
		if (sprites.ContainsKey(key))
		{
			return;
		}
		while (true)
		{
			int num = 502054328;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x37CA9C5B)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_002f;
				case 2u:
					return;
				}
				break;
				IL_002f:
				sprites.Add(key, path);
				num = (int)((num2 * 2065211544) ^ 0x3DBA74BE);
			}
		}
	}

	public static void AddAudio(string key, string path)
	{
		if (audios.ContainsKey(key))
		{
			return;
		}
		while (true)
		{
			int num = -1780938988;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -641368225)) % 3)
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
				audios.Add(key, path);
				num = ((int)num2 * -26812877) ^ -608642825;
			}
		}
	}

	[DebuggerHidden]
	public static IEnumerator LoadXml(LoadingUI ui, string path, CommonSettings.VoidCallBack callback)
	{
		_202E_202A_200B_206D_200D_206F_202E_202C_202D_200B_206B_206D_206C_206C_200D_206B_206B_202D_200D_206E_206B_206D_206B_200D_202E_202B_200F_206B_202D_200F_200C_200D_202D_200D_206A_200C_206C_202E_206D_206C_202E obj = new _202E_202A_200B_206D_200D_206F_202E_202C_202D_200B_206B_206D_206C_206C_200D_206B_206B_202D_200D_206E_206B_206D_206B_200D_202E_202B_200F_206B_202D_200F_200C_200D_202D_200D_206A_200C_206C_202E_206D_206C_202E();
		obj.path = path;
		obj.callback = callback;
		while (true)
		{
			int num = 723449606;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5D1AA4B4)) % 4)
				{
				case 0u:
					break;
				case 2u:
					obj._206C_202A_206B_202E_202E_202C_200D_206D_200E_202B_206C_206C_202B_200E_206E_202B_206A_202D_206C_200C_200D_200E_206B_206D_200B_200B_202E_206A_200D_206C_200D_200C_202E_206B_206E_200B_200F_200F_200B_202B_202E = path;
					num = (int)((num2 * 1933439508) ^ 0x50D3BF7B);
					continue;
				case 3u:
					obj._206A_202A_200B_206C_206D_206E_206A_200D_202E_206D_200F_200B_202A_206C_200B_206A_206D_202C_202D_206C_206C_200C_206E_206D_200C_200F_206C_200F_200E_202E_206E_200D_200E_206D_206F_206C_206D_200C_202E_202B_202E = callback;
					num = ((int)num2 * -809113891) ^ -307421322;
					continue;
				default:
					return obj;
				}
				break;
			}
		}
	}

	public static Sprite LoadSprite(string path)
	{
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		_206D_202D_206D_200C_200F_202B_206E_202C_206E_200C_202E_202D_202D_206B_202C_202B_206C_206C_202A_200D_206D_200B_202B_206F_206B_206F_202E_206C_202E_202A_202D_202B_202C_200E_206F_200D_206D_200E_206B_200E_202E obj = new _206D_202D_206D_200C_200F_202B_206E_202C_206E_200C_202E_202D_202D_206B_202C_202B_206C_206C_202A_200D_206D_200B_202B_206F_206B_206F_202E_206C_202E_202A_202D_202B_202C_200E_206F_200D_206D_200E_206B_200E_202E();
		int num5 = default(int);
		AssetBundleManager.ModResourceData[] data = default(AssetBundleManager.ModResourceData[]);
		_206C_200E_200D_200E_202E_200C_202E_200C_206D_200E_206A_200D_202D_200F_206E_202D_206E_206F_202C_206C_200E_206A_200F_200D_200E_202B_206D_206A_202A_206B_202C_202E_202D_206E_200E_206D_206B_200E_202C_206D_202E obj2 = default(_206C_200E_200D_200E_202E_200C_202E_200C_206D_200E_206A_200D_202D_200F_206E_202D_206E_206F_202C_206C_200E_206A_200F_200D_200E_202B_206D_206A_202A_206B_202C_202E_202D_206E_200E_206D_206B_200E_202C_206D_202E);
		AssetBundleManager.ModResourceData modResourceData = default(AssetBundleManager.ModResourceData);
		Texture2D val = default(Texture2D);
		while (true)
		{
			int num = 1808145803;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x54C3CCCB)) % 17)
				{
				case 8u:
					break;
				case 13u:
				{
					int num6;
					if (num5 >= data.Length)
					{
						num = 2066217559;
						num6 = num;
					}
					else
					{
						num = 76943842;
						num6 = num;
					}
					continue;
				}
				case 4u:
					obj2 = new _206C_200E_200D_200E_202E_200C_202E_200C_206D_200E_206A_200D_202D_200F_206E_202D_206E_206F_202C_206C_200E_206A_200F_200D_200E_202B_206D_206A_202A_206B_202C_202E_202D_206E_200E_206D_206B_200E_202C_206D_202E();
					num = (int)((num2 * 1608519452) ^ 0xF3F6DD1);
					continue;
				case 3u:
					spriteCache.Add(obj2.CS_0024_003C_003E8__locals1.path, obj2.result);
					num = ((int)num2 * -1319150132) ^ 0x2027C80D;
					continue;
				case 2u:
				{
					modResourceData = data[num5];
					int num7;
					if (_206E_202C_202D_206A_206C_200B_206A_202B_206E_202E_206B_206B_202A_200F_200F_206D_202C_200D_202B_202B_200C_202B_200B_200B_206E_206A_200F_206C_200F_202E_206F_200E_202A_202E_200C_200D_200E_202A_202B_202A_202E(modResourceData.url, obj.path))
					{
						num = 1002350976;
						num7 = num;
					}
					else
					{
						num = 1544736489;
						num7 = num;
					}
					continue;
				}
				case 7u:
					_206B_202D_206C_202B_202C_200C_206F_202C_206F_206A_200B_206D_200F_206F_200B_206C_200F_206C_200B_206F_206C_206D_202D_202B_202D_206D_202E_206C_200B_202B_206F_200B_206C_200B_206F_202A_206D_206A_200C_202E(val, 0, 0, Color.white);
					num = ((int)num2 * -1316103065) ^ 0x514915E0;
					continue;
				case 16u:
					return obj2.result;
				case 6u:
					data = AssetBundleManager.data.data;
					num = 1992712141;
					continue;
				case 0u:
					num = (int)(num2 * 566239997) ^ -1660971464;
					continue;
				case 15u:
					num5++;
					num = 1692704666;
					continue;
				case 10u:
					obj2.result = Sprite.Create(val, new Rect(0f, 0f, (float)_206D_200B_202E_200B_202D_200E_206E_206F_202D_206A_206E_202B_202B_206C_200F_206F_202E_200C_206A_200F_206B_200B_202E_206E_200F_200B_206F_200B_202A_202E_206B_206C_202A_200D_206E_206E_206A_206E_202B_206F_202E((Texture)(object)val), (float)_200C_200C_200F_200D_200F_206A_206B_200B_206B_206E_200D_206F_200C_206D_200C_206D_202B_202D_200B_202A_206E_206E_206E_200C_202E_202C_206C_200E_200D_206B_206C_206A_202D_202D_202E_202E_200B_206F_200B_202C_202E((Texture)(object)val)), new Vector2(0.5f, 0.5f));
					num = ((int)num2 * -1603003610) ^ 0x2881AD49;
					continue;
				case 12u:
					return spriteCache[obj.path];
				case 5u:
					num5 = 0;
					num = (int)((num2 * 989717681) ^ 0x8E1B527);
					continue;
				case 11u:
					obj2.CS_0024_003C_003E8__locals1 = obj;
					val = _202E_200B_200D_206A_200F_200E_206E_202B_206B_206F_206C_202B_206C_206F_202C_206B_200F_202B_200D_202D_202B_206C_206A_206A_206E_202B_206C_206E_206F_206E_200F_206A_202E_206A_200C_200B_202D_202B_202B_202A_202E(modResourceData.w, modResourceData.h);
					num = (int)(num2 * 776512035) ^ -1294511521;
					continue;
				case 14u:
					((MonoBehaviour)AudioManager.Instance).StartCoroutine(Tools.DownloadIntoTexture(val, ModManager.ModBaseUrl + obj2.CS_0024_003C_003E8__locals1.path, obj2._202B_202A_206F_202E_202B_206A_206A_206A_206B_206F_206B_206E_206E_206F_206B_206D_206C_200C_200F_206E_206E_206D_206C_202E_206D_206E_202E_200E_206B_202E_200B_202E_206B_202D_206D_202D_206A_200D_202C_206F_202E));
					num = (int)((num2 * 1541713206) ^ 0x5CC7196C);
					continue;
				case 1u:
				{
					obj.path = path;
					int num3;
					int num4;
					if (!spriteCache.ContainsKey(obj.path))
					{
						num3 = 207839748;
						num4 = num3;
					}
					else
					{
						num3 = 203633218;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -2113569009);
					continue;
				}
				default:
					return null;
				}
				break;
			}
		}
	}

	public static void LoadAudio(string path, Action<AudioClip> callback)
	{
		WWW val = _200F_206A_200E_206C_200E_206B_200C_202B_206F_206A_200B_206A_206B_202C_202D_202C_206A_202E_202B_206A_206A_202E_200F_202E_200D_206E_206B_202B_202A_202E_206C_202A_206D_202E_202B_202C_202C_206A_202B_206E_202E(_202E_206E_200E_202E_202A_200C_202C_206B_202B_206A_202A_206D_206D_206D_200B_206F_200D_206B_200B_206F_202B_202D_206A_202C_202D_206A_200F_206A_202E_202C_206D_202A_202D_206F_200F_206B_206A_200B_206B_202E_202E(ModManager.ModBaseUrl, path));
		AudioClip obj = default(AudioClip);
		while (true)
		{
			int num = 543170472;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2BA04D2E)) % 4)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					obj = _200F_200F_202C_202E_206D_200E_200C_200B_200D_200B_206F_200C_200B_202D_200D_206E_206C_202E_206C_206D_200F_206D_206E_202C_200F_206D_202A_200C_202B_206F_206B_206C_200F_206E_200B_202A_202D_202B_206F_200D_202E(val, true, true);
					num = ((int)num2 * -1342743676) ^ -1006248419;
					continue;
				case 3u:
					callback(obj);
					num = ((int)num2 * -49303125) ^ 0x7566B66E;
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public static void ClearSpriteCache()
	{
		uint num3;
		if (spriteCache.Count > 0)
		{
			using (Dictionary<string, Sprite>.ValueCollection.Enumerator enumerator = spriteCache.Values.GetEnumerator())
			{
				while (true)
				{
					IL_005b:
					int num;
					int num2;
					if (enumerator.MoveNext())
					{
						num = -1091150821;
						num2 = num;
					}
					else
					{
						num = -1759924539;
						num2 = num;
					}
					while (true)
					{
						switch ((num3 = (uint)(num ^ -323230534)) % 4)
						{
						case 2u:
							num = -1091150821;
							continue;
						default:
							goto end_IL_0027;
						case 1u:
							_200E_202E_206A_200D_200F_202D_206C_206A_202B_202A_206D_202B_206F_206D_206B_200E_206F_202D_202E_202C_202D_206B_202C_202E_206C_206D_202B_200F_206B_202B_200F_200E_202D_206E_200C_202E_200C_206D_206D_202E((Object)(object)enumerator.Current);
							num = -2074778486;
							continue;
						case 0u:
							break;
						case 3u:
							goto end_IL_0027;
						}
						goto IL_005b;
						continue;
						end_IL_0027:
						break;
					}
					break;
				}
			}
			spriteCache.Clear();
			goto IL_008f;
		}
		goto IL_00b1;
		IL_0094:
		int num4;
		switch ((num3 = (uint)(num4 ^ -323230534)) % 3)
		{
		case 0u:
			break;
		default:
			return;
		case 1u:
			goto IL_00b1;
		case 2u:
			return;
		}
		goto IL_008f;
		IL_00b1:
		PreCacheSpritesLoaded = false;
		num4 = -86204756;
		goto IL_0094;
		IL_008f:
		num4 = -1704358208;
		goto IL_0094;
	}

	public static void preCacheSprite(AssetBundleManager.ModResourceData modResourceData)
	{
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		if (!modResourceData.cache)
		{
			return;
		}
		Texture2D val2 = default(Texture2D);
		byte[] array = default(byte[]);
		Sprite val = default(Sprite);
		FileStream fileStream = default(FileStream);
		while (true)
		{
			int num = 905519447;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2586E794)) % 3)
				{
				case 0u:
					break;
				case 2u:
					if (modResourceData.w > 127)
					{
						goto IL_003b;
					}
					return;
				default:
					if (modResourceData.h <= 7)
					{
						return;
					}
					try
					{
						string text = _202E_206E_200E_202E_202A_200C_202C_206B_202B_206A_202A_206D_206D_206D_200B_206F_200D_206B_200B_206F_202B_202D_206A_202C_202D_206A_200F_206A_202E_202C_206D_202A_202D_206F_200F_206B_206A_200B_206B_202E_202E(ModManager.ModBaseUrlPath, modResourceData.url);
						while (true)
						{
							int num3 = 684632202;
							while (true)
							{
								switch ((num2 = (uint)(num3 ^ 0x2586E794)) % 12)
								{
								case 9u:
									break;
								default:
									return;
								case 6u:
									_206B_200F_206C_200F_200D_202D_206C_202B_200D_206B_206B_206C_206E_200E_200F_200B_200C_202D_206F_206E_202E_202B_200E_200E_200F_206F_202D_200F_206C_200B_200B_200E_202D_202E_206B_206A_206B_206E_202D_206E_202E(val2, array);
									num3 = (int)(num2 * 1927751640) ^ -580500111;
									continue;
								case 1u:
									spriteCache[modResourceData.url] = val;
									num3 = ((int)num2 * -471882843) ^ -495733030;
									continue;
								case 4u:
									_206B_206E_202C_200C_202B_200B_206B_206E_200C_202A_200D_200C_202A_206E_206C_200B_200C_206E_202D_206E_206D_202A_200F_202D_202E_206C_200C_206F_206A_200E_206D_206B_202D_202B_206F_200B_200D_200C_202C_206B_202E((Stream)fileStream, array, 0, (int)_202E_200C_206A_200B_206F_206A_206D_202B_202B_206F_202B_206E_202D_200D_202D_202C_206F_206A_206B_202D_202C_200C_202B_206A_200F_200D_202D_206F_202B_202B_206B_202B_206E_202B_206E_206F_202B_202B_202A_200D_202E((Stream)fileStream));
									_200E_200E_206B_202E_202E_200B_202C_206D_202D_202B_202E_202D_200C_206D_200F_206F_206E_206E_200F_206B_202C_202E_206D_200B_206D_202D_206C_200C_200B_200C_202B_202D_200C_206E_206D_206D_206F_206D_200C_202C_202E((Stream)fileStream);
									_202D_206B_202A_206A_200F_206A_206E_206C_202C_202B_206B_200D_200F_200C_200E_200C_206A_206D_202C_200E_202A_200C_206B_200C_202D_200D_202E_200C_206F_200F_200C_206A_206A_202D_200C_206B_202D_200E_206D_200C_202E((Stream)fileStream);
									fileStream = null;
									val2 = _202E_200B_200D_206A_200F_200E_206E_202B_206B_206F_206C_202B_206C_206F_202C_206B_200F_202B_200D_202D_202B_206C_206A_206A_206E_202B_206C_206E_206F_206E_200F_206A_202E_206A_200C_200B_202D_202B_202B_202A_202E(modResourceData.w, modResourceData.h);
									num3 = ((int)num2 * -1270495522) ^ -1580040598;
									continue;
								case 7u:
									_202B_200C_202E_206F_206F_202C_206D_202E_206E_202E_200B_206D_200D_202E_202A_202C_202A_200D_202D_200C_200E_206D_202B_206F_202D_206F_206D_200B_206E_206C_202D_200E_206B_206F_202C_206E_200D_202D_206F_202E_202E((object)_202E_206E_200E_202E_202A_200C_202C_206B_202B_206A_202A_206D_206D_206D_200B_206F_200D_206B_200B_206F_202B_202D_206A_202C_202D_206A_200F_206A_202E_202C_206D_202A_202D_206F_200F_206B_206A_200B_206B_202E_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(588396326u), text));
									num3 = (int)(num2 * 323751869) ^ -686589600;
									continue;
								case 8u:
									array = new byte[_202E_200C_206A_200B_206F_206A_206D_202B_202B_206F_202B_206E_202D_200D_202D_202C_206F_206A_206B_202D_202C_200C_202B_206A_200F_200D_202D_206F_202B_202B_206B_202B_206E_202B_206E_206F_202B_202B_202A_200D_202E((Stream)fileStream)];
									num3 = ((int)num2 * -961225320) ^ 0x53A380B8;
									continue;
								case 0u:
									((Texture)val.texture).mipMapBias = 0f;
									num3 = (int)((num2 * 1818233655) ^ 0x32F871F9);
									continue;
								case 2u:
								{
									int num4;
									int num5;
									if (!_206F_202D_200C_202C_202B_200C_206A_202A_206F_202D_206A_206D_202C_200D_200B_206F_206D_202B_206E_206A_206C_206C_200D_202D_200B_200C_200F_200C_200F_206D_200C_200F_202E_200D_202A_200C_206E_200D_200E_206D_202E(text))
									{
										num4 = 1109750633;
										num5 = num4;
									}
									else
									{
										num4 = 1770105304;
										num5 = num4;
									}
									num3 = num4 ^ (int)(num2 * 884343807);
									continue;
								}
								case 3u:
									num3 = ((int)num2 * -1821369700) ^ -1164961369;
									continue;
								case 5u:
									val = Sprite.Create(val2, new Rect(0f, 0f, (float)_206D_200B_202E_200B_202D_200E_206E_206F_202D_206A_206E_202B_202B_206C_200F_206F_202E_200C_206A_200F_206B_200B_202E_206E_200F_200B_206F_200B_202A_202E_206B_206C_202A_200D_206E_206E_206A_206E_202B_206F_202E((Texture)(object)val2), (float)_200C_200C_200F_200D_200F_206A_206B_200B_206B_206E_200D_206F_200C_206D_200C_206D_202B_202D_200B_202A_206E_206E_206E_200C_202E_202C_206C_200E_200D_206B_206C_206A_202D_202D_202E_202E_200B_206F_200B_202C_202E((Texture)(object)val2)), new Vector2(0.5f, 0.5f));
									num3 = (int)(num2 * 1076616513) ^ -1607474119;
									continue;
								case 10u:
									fileStream = _202B_202C_202B_202A_206F_206E_202A_206A_200F_200C_202A_206A_202E_202B_206B_200E_202C_200E_206D_206F_206D_206C_200D_202E_202B_202B_206D_206A_206A_206C_206B_206B_200C_206A_202B_202A_206D_202D_206F_202E_202E(text, FileMode.Open, FileAccess.Read);
									_206D_206C_206A_202A_200C_200D_202B_200C_206D_200F_206F_200E_206C_202D_200D_200C_206C_206B_200B_200B_206D_202E_202E_200F_206D_200C_200B_206B_200C_200E_202A_202D_200D_202A_206E_202A_202A_206F_200D_200F_202E((Stream)fileStream, 0L, SeekOrigin.Begin);
									num3 = 559391800;
									continue;
								case 11u:
									return;
								}
								break;
							}
						}
					}
					catch
					{
						while (true)
						{
							int num6 = 622961577;
							while (true)
							{
								switch ((num2 = (uint)(num6 ^ 0x2586E794)) % 3)
								{
								case 0u:
									break;
								default:
									return;
								case 2u:
									goto IL_025e;
								case 1u:
									return;
								}
								break;
								IL_025e:
								ClearSpriteCache();
								num6 = ((int)num2 * -910030837) ^ -897245532;
							}
						}
					}
				}
				break;
				IL_003b:
				num = (int)(num2 * 1901390938) ^ -1192234627;
			}
		}
	}

	public static Sprite LoadHeadSprite(string path)
	{
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		_200C_202D_206C_206A_202D_202E_200E_202A_206D_202A_202A_206D_206B_206D_206F_200F_206B_202E_206D_206D_202D_202E_200C_200B_200C_200D_200B_200E_200B_206B_202A_202C_202A_206C_206E_206E_202E_206D_206E_200C_202E obj = new _200C_202D_206C_206A_202D_202E_200E_202A_206D_202A_202A_206D_206B_206D_206F_200F_206B_202E_206D_206D_202D_202E_200C_200B_200C_200D_200B_200E_200B_206B_202A_202C_202A_206C_206E_206E_202E_206D_206E_200C_202E();
		AssetBundleManager.ModResourceData modResourceData = default(AssetBundleManager.ModResourceData);
		AssetBundleManager.ModResourceData[] data = default(AssetBundleManager.ModResourceData[]);
		int num3 = default(int);
		_200E_206B_200D_202E_200F_206D_202B_202C_200B_202A_202B_200E_200C_202D_202B_206E_200C_200B_206C_206E_206B_200B_202A_202D_206A_200E_202C_206A_206E_206D_200C_200D_202E_200F_200B_200C_206A_202A_202D_202A_202E obj2 = default(_200E_206B_200D_202E_200F_206D_202B_202C_200B_202A_202B_200E_200C_202D_202B_206E_200C_200B_206C_206E_206B_200B_202A_202D_206A_200E_202C_206A_206E_206D_200C_200D_202E_200F_200B_200C_206A_202A_202D_202A_202E);
		while (true)
		{
			int num = -1397752495;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1394717103)) % 14)
				{
				case 12u:
					break;
				case 4u:
					obj.path = path;
					num = (int)(num2 * 752684376) ^ -915077552;
					continue;
				case 8u:
					modResourceData = data[num3];
					num = -847832493;
					continue;
				case 1u:
					return obj2.result;
				case 6u:
					num3 = 0;
					num = ((int)num2 * -357181135) ^ -2112291330;
					continue;
				case 7u:
					obj2 = new _200E_206B_200D_202E_200F_206D_202B_202C_200B_202A_202B_200E_200C_202D_202B_206E_200C_200B_206C_206E_206B_200B_202A_202D_206A_200E_202C_206A_206E_206D_200C_200D_202E_200F_200B_200C_206A_202A_202D_202A_202E();
					obj2.CS_0024_003C_003E8__locals1 = obj;
					num = (int)(num2 * 1270151932) ^ -1637480720;
					continue;
				case 5u:
					data = AssetBundleManager.data.data;
					num = -941593807;
					continue;
				case 9u:
				{
					int num8;
					if (num3 < data.Length)
					{
						num = -1353969315;
						num8 = num;
					}
					else
					{
						num = -1118774809;
						num8 = num;
					}
					continue;
				}
				case 13u:
				{
					int num6;
					int num7;
					if (spriteCache.ContainsKey(obj.path))
					{
						num6 = 1978647696;
						num7 = num6;
					}
					else
					{
						num6 = 1983243554;
						num7 = num6;
					}
					num = num6 ^ (int)(num2 * 1992352440);
					continue;
				}
				case 10u:
				{
					int num4;
					int num5;
					if (_206E_202C_202D_206A_206C_200B_206A_202B_206E_202E_206B_206B_202A_200F_200F_206D_202C_200D_202B_202B_200C_202B_200B_200B_206E_206A_200F_206C_200F_202E_206F_200E_202A_202E_200C_200D_200E_202A_202B_202A_202E(modResourceData.url, obj.path))
					{
						num4 = -558619060;
						num5 = num4;
					}
					else
					{
						num4 = -1429224467;
						num5 = num4;
					}
					num = num4 ^ (int)(num2 * 1013437279);
					continue;
				}
				case 11u:
				{
					Texture2D val = _202E_200B_200D_206A_200F_200E_206E_202B_206B_206F_206C_202B_206C_206F_202C_206B_200F_202B_200D_202D_202B_206C_206A_206A_206E_202B_206C_206E_206F_206E_200F_206A_202E_206A_200C_200B_202D_202B_202B_202A_202E(modResourceData.w, modResourceData.h);
					_206B_202D_206C_202B_202C_200C_206F_202C_206F_206A_200B_206D_200F_206F_200B_206C_200F_206C_200B_206F_206C_206D_202D_202B_202D_206D_202E_206C_200B_202B_206F_200B_206C_200B_206F_202A_206D_206A_200C_202E(val, 0, 0, Color.white);
					obj2.result = Sprite.Create(val, new Rect(0f, 0f, (float)_206D_200B_202E_200B_202D_200E_206E_206F_202D_206A_206E_202B_202B_206C_200F_206F_202E_200C_206A_200F_206B_200B_202E_206E_200F_200B_206F_200B_202A_202E_206B_206C_202A_200D_206E_206E_206A_206E_202B_206F_202E((Texture)(object)val) - 2f, (float)_200C_200C_200F_200D_200F_206A_206B_200B_206B_206E_200D_206F_200C_206D_200C_206D_202B_202D_200B_202A_206E_206E_206E_200C_202E_202C_206C_200E_200D_206B_206C_206A_202D_202D_202E_202E_200B_206F_200B_202C_202E((Texture)(object)val) - 3f), new Vector2(0.5f, 0.5f));
					spriteCache.Add(obj2.CS_0024_003C_003E8__locals1.path, obj2.result);
					((MonoBehaviour)AudioManager.Instance).StartCoroutine(Tools.DownloadIntoTexture(val, ModManager.ModBaseUrl + obj2.CS_0024_003C_003E8__locals1.path, obj2._202D_200C_202C_202E_200B_202C_202B_202D_206C_206A_206B_206F_200F_202E_200D_206C_200D_206A_206C_200F_206A_202D_200F_200D_202D_202B_200D_202D_202C_206F_206A_206B_200F_206C_206D_200F_202D_206C_200C_200D_202E));
					num = ((int)num2 * -370166292) ^ 0x73E7D578;
					continue;
				}
				case 0u:
					num3++;
					num = -479495522;
					continue;
				case 3u:
					return spriteCache[obj.path];
				default:
					return null;
				}
				break;
			}
		}
	}

	public static Sprite LoadSpriteFromFile(string url, Vector2 pivot, float pixerPerUnit = 1f)
	{
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		if (!_206F_202D_200C_202C_202B_200C_206A_202A_206F_202D_206A_206D_202C_200D_200B_206F_206D_202B_206E_206A_206C_206C_200D_202D_200B_200C_200F_200C_200F_206D_200C_200F_202E_200D_202A_200C_206E_200D_200E_206D_202E(url))
		{
			while (true)
			{
				uint num;
				switch ((num = 1913130337u) % 3)
				{
				case 0u:
					continue;
				case 1u:
					return null;
				}
				break;
			}
		}
		try
		{
			FileStream fileStream = _202B_202C_202B_202A_206F_206E_202A_206A_200F_200C_202A_206A_202E_202B_206B_200E_202C_200E_206D_206F_206D_206C_200D_202E_202B_202B_206D_206A_206A_206C_206B_206B_200C_206A_202B_202A_206D_202D_206F_202E_202E(url, FileMode.Open, FileAccess.Read);
			byte[] array = default(byte[]);
			Texture2D val = default(Texture2D);
			while (true)
			{
				int num2 = 85879856;
				while (true)
				{
					uint num;
					switch ((num = (uint)(num2 ^ 0x7068C301)) % 7)
					{
					case 0u:
						break;
					case 5u:
						_202D_206B_202A_206A_200F_206A_206E_206C_202C_202B_206B_200D_200F_200C_200E_200C_206A_206D_202C_200E_202A_200C_206B_200C_202D_200D_202E_200C_206F_200F_200C_206A_206A_202D_200C_206B_202D_200E_206D_200C_202E((Stream)fileStream);
						num2 = (int)(num * 1254834180) ^ -2008774163;
						continue;
					case 6u:
						_200E_200E_206B_202E_202E_200B_202C_206D_202D_202B_202E_202D_200C_206D_200F_206F_206E_206E_200F_206B_202C_202E_206D_200B_206D_202D_206C_200C_200B_200C_202B_202D_200C_206E_206D_206D_206F_206D_200C_202C_202E((Stream)fileStream);
						num2 = ((int)num * -1527838492) ^ 0x3CE219C2;
						continue;
					case 1u:
						array = new byte[_202E_200C_206A_200B_206F_206A_206D_202B_202B_206F_202B_206E_202D_200D_202D_202C_206F_206A_206B_202D_202C_200C_202B_206A_200F_200D_202D_206F_202B_202B_206B_202B_206E_202B_206E_206F_202B_202B_202A_200D_202E((Stream)fileStream)];
						_206B_206E_202C_200C_202B_200B_206B_206E_200C_202A_200D_200C_202A_206E_206C_200B_200C_206E_202D_206E_206D_202A_200F_202D_202E_206C_200C_206F_206A_200E_206D_206B_202D_202B_206F_200B_200D_200C_202C_206B_202E((Stream)fileStream, array, 0, (int)_202E_200C_206A_200B_206F_206A_206D_202B_202B_206F_202B_206E_202D_200D_202D_202C_206F_206A_206B_202D_202C_200C_202B_206A_200F_200D_202D_206F_202B_202B_206B_202B_206E_202B_206E_206F_202B_202B_202A_200D_202E((Stream)fileStream));
						num2 = (int)((num * 1011402551) ^ 0x4F9AECF8);
						continue;
					case 3u:
						_206D_206C_206A_202A_200C_200D_202B_200C_206D_200F_206F_200E_206C_202D_200D_200C_206C_206B_200B_200B_206D_202E_202E_200F_206D_200C_200B_206B_200C_200E_202A_202D_200D_202A_206E_202A_202A_206F_200D_200F_202E((Stream)fileStream, 0L, SeekOrigin.Begin);
						num2 = ((int)num * -1871773400) ^ 0x3BD312EA;
						continue;
					case 2u:
						fileStream = null;
						val = _202E_200B_200D_206A_200F_200E_206E_202B_206B_206F_206C_202B_206C_206F_202C_206B_200F_202B_200D_202D_202B_206C_206A_206A_206E_202B_206C_206E_206F_206E_200F_206A_202E_206A_200C_200B_202D_202B_202B_202A_202E(1, 1);
						num2 = (int)((num * 506001498) ^ 0x1347E33);
						continue;
					default:
					{
						_206B_200F_206C_200F_200D_202D_206C_202B_200D_206B_206B_206C_206E_200E_200F_200B_200C_202D_206F_206E_202E_202B_200E_200E_200F_206F_202D_200F_206C_200B_200B_200E_202D_202E_206B_206A_206B_206E_202D_206E_202E(val, array);
						Sprite obj = Sprite.Create(val, new Rect(0f, 0f, (float)_206D_200B_202E_200B_202D_200E_206E_206F_202D_206A_206E_202B_202B_206C_200F_206F_202E_200C_206A_200F_206B_200B_202E_206E_200F_200B_206F_200B_202A_202E_206B_206C_202A_200D_206E_206E_206A_206E_202B_206F_202E((Texture)(object)val), (float)_200C_200C_200F_200D_200F_206A_206B_200B_206B_206E_200D_206F_200C_206D_200C_206D_202B_202D_200B_202A_206E_206E_206E_200C_202E_202C_206C_200E_200D_206B_206C_206A_202D_202D_202E_202E_200B_206F_200B_202C_202E((Texture)(object)val)), pivot, pixerPerUnit);
						((Texture)obj.texture).mipMapBias = 0f;
						return obj;
					}
					}
					break;
				}
			}
		}
		catch
		{
			Debug.LogError((object)(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(900902701u) + url));
		}
		return null;
	}

	public static Sprite GetSprite2(string key, bool checkexists = false)
	{
		if (!sprites.ContainsKey(key))
		{
			goto IL_0010;
		}
		goto IL_0094;
		IL_0010:
		int num = -1927141772;
		goto IL_0015;
		IL_0015:
		string text2 = default(string);
		string text = default(string);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -386358383)) % 12)
			{
			case 0u:
				break;
			case 7u:
				_202B_200C_202E_206F_206F_202C_206D_202E_206E_202E_200B_206D_200D_202E_202A_202C_202A_200D_202D_200C_200E_206D_202B_206F_202D_206F_206D_200B_206E_206C_202D_200E_206B_206F_202C_206E_200D_202D_206F_202E_202E((object)global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3417306160u));
				num = (int)(num2 * 332270784) ^ -1754092525;
				continue;
			case 1u:
			{
				int num5;
				int num6;
				if (checkexists)
				{
					num5 = 1672274503;
					num6 = num5;
				}
				else
				{
					num5 = 862684074;
					num6 = num5;
				}
				num = num5 ^ ((int)num2 * -1810444643);
				continue;
			}
			case 3u:
				goto IL_0094;
			case 6u:
			{
				int num7;
				int num8;
				if (_206F_202D_200C_202C_202B_200C_206A_202A_206F_202D_206A_206D_202C_200D_200B_206F_206D_202B_206E_206A_206C_206C_200D_202D_200B_200C_200F_200C_200F_206D_200C_200F_202E_200D_202A_200C_206E_200D_200E_206D_202E(text2))
				{
					num7 = -875263749;
					num8 = num7;
				}
				else
				{
					num7 = -793936767;
					num8 = num7;
				}
				num = num7 ^ ((int)num2 * -771362572);
				continue;
			}
			case 2u:
				return null;
			case 4u:
				_202B_200C_202E_206F_206F_202C_206D_202E_206E_202E_200B_206D_200D_202E_202A_202C_202A_200D_202D_200C_200E_206D_202B_206F_202D_206F_206D_200B_206E_206C_202D_200E_206B_206F_202C_206E_200D_202D_206F_202E_202E((object)_202E_206E_200E_202E_202A_200C_202C_206B_202B_206A_202A_206D_206D_206D_200B_206F_200D_206B_200B_206F_202B_202D_206A_202C_202D_206A_200F_206A_202E_202C_206D_202A_202D_206F_200F_206B_206A_200B_206B_202E_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2673612035u), text2));
				num = (int)((num2 * 1476891878) ^ 0xB19C314);
				continue;
			case 5u:
				return null;
			case 8u:
				text2 = _202E_206E_200E_202E_202A_200C_202C_206B_202B_206A_202A_206D_206D_206D_200B_206F_200D_206B_200B_206F_202B_202D_206A_202C_202D_206A_200F_206A_202E_202C_206D_202A_202D_206F_200F_206B_206A_200B_206B_202E_202E(ModManager.ModBaseUrlPath, text);
				num = -1257809669;
				continue;
			case 9u:
				return null;
			case 11u:
			{
				int num3;
				int num4;
				if (_206E_206D_200C_202A_206F_206E_200C_200F_206C_206A_200F_200E_200F_206A_200C_206A_206A_202E_206F_202D_206E_206E_200C_200E_200C_200E_200C_202A_200C_200F_202A_202E_206D_206B_200B_206D_206D_206A_202B_200E_202E(text))
				{
					num3 = 1498659251;
					num4 = num3;
				}
				else
				{
					num3 = 686657588;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -588427517);
				continue;
			}
			default:
				return LoadSprite(text);
			}
			break;
		}
		goto IL_0010;
		IL_0094:
		text = sprites[key];
		num = -1075413892;
		goto IL_0015;
	}

	public static IEnumerator preCacheSpriteCoroutine(List<AssetBundleManager.ModResourceData> modResourceDataList)
	{
		while (true)
		{
			int num = -2096097564;
			while (true)
			{
				uint num2;
				int num4;
				switch ((num2 = (uint)(num ^ -486192307)) % 6)
				{
				case 4u:
					break;
				case 0u:
					num = -1821698424;
					continue;
				case 3u:
					if (num4 != 1)
					{
						num = (int)((num2 * 1927623562) ^ 0x6909D80F);
						continue;
					}
					while (true)
					{
						int num5 = -1713226586;
						while (true)
						{
							switch ((uint)(num5 ^ -486192307) % 4u)
							{
							case 0u:
								goto IL_0115;
							default:
								yield break;
							case 2u:
								/*Error near IL_013c: Unexpected return in MoveNext()*/;
							case 1u:
								break;
							}
							break;
							IL_0115:
							num5 = -991913629;
						}
					}
				case 2u:
					yield break;
				case 1u:
					num = ((num4 != 0) ? (-1826399529) : (-1410688982)) ^ ((int)num2 * -428005503);
					continue;
				default:
				{
					using (List<AssetBundleManager.ModResourceData>.Enumerator enumerator = modResourceDataList.GetEnumerator())
					{
						while (true)
						{
							IL_00cd:
							int num3 = (enumerator.MoveNext() ? (-901868588) : (-980081886));
							while (true)
							{
								switch ((uint)(num3 ^ -486192307) % 4u)
								{
								case 2u:
									num3 = -901868588;
									continue;
								default:
									goto end_IL_0099;
								case 1u:
									preCacheSprite(enumerator.Current);
									num3 = -2028683987;
									continue;
								case 0u:
									break;
								}
								goto IL_00cd;
								continue;
								end_IL_0099:
								break;
							}
							break;
						}
					}
					modResourceDataList.Clear();
					yield return 0;
					/*Error: Unable to find 'return true' for yield return*/;
				}
				}
				break;
			}
		}
	}

	public static void DeleteXml(string path)
	{
		if (!xmls.ContainsKey(path))
		{
			return;
		}
		while (true)
		{
			int num = -1589692841;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1995921426)) % 4)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
				{
					int num3;
					int num4;
					if (_200D_202C_200E_206F_200F_206C_206E_206C_202E_200D_206B_202E_200D_200D_202C_200B_200E_200E_202D_200B_206C_202C_200F_206A_206C_206B_200E_206A_202A_206E_200C_202A_202E_202D_200D_200B_202E_206C_206C_202C_202E(path, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2571549922u)))
					{
						num3 = -810201956;
						num4 = num3;
					}
					else
					{
						num3 = -104242507;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 17904020);
					continue;
				}
				case 3u:
					xmls[path] = null;
					xmls.Remove(path);
					num = ((int)num2 * -1369847206) ^ -990434066;
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public static void CacheSprite(string path)
	{
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		_206B_202A_206F_200C_206D_206C_202E_200E_206D_206A_200C_202C_202E_200F_200C_200F_200F_206D_206D_202E_202B_206C_202A_202E_206F_200B_200B_200B_206E_200D_206D_206F_206D_200B_206E_206D_200C_206B_206F_200C_202E obj = new _206B_202A_206F_200C_206D_206C_202E_200E_206D_206A_200C_202C_202E_200F_200C_200F_200F_206D_206D_202E_202B_206C_202A_202E_206F_200B_200B_200B_206E_200D_206D_206F_206D_200B_206E_206D_200C_206B_206F_200C_202E();
		obj.path = path;
		AssetBundleManager.ModResourceData modResourceData = default(AssetBundleManager.ModResourceData);
		AssetBundleManager.ModResourceData[] data = default(AssetBundleManager.ModResourceData[]);
		int num3 = default(int);
		Texture2D val = default(Texture2D);
		_206E_202C_200E_200E_200F_202D_206B_206D_202A_206B_206A_202B_206F_206F_202D_200F_202C_206C_200E_206B_200B_202A_206E_202A_206A_200B_202B_200D_206D_200B_202E_202C_206E_202C_202E_202B_200F_202B_200E_200C_202E obj2 = default(_206E_202C_200E_200E_200F_202D_206B_206D_202A_206B_206A_202B_206F_206F_202D_200F_202C_206C_200E_206B_200B_202A_206E_202A_206A_200B_202B_200D_206D_200B_202E_202C_206E_202C_202E_202B_200F_202B_200E_200C_202E);
		while (true)
		{
			int num = -796579213;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -57424859)) % 16)
				{
				case 2u:
					break;
				default:
					return;
				case 3u:
				{
					int num7;
					int num8;
					if (_206E_202C_202D_206A_206C_200B_206A_202B_206E_202E_206B_206B_202A_200F_200F_206D_202C_200D_202B_202B_200C_202B_200B_200B_206E_206A_200F_206C_200F_202E_206F_200E_202A_202E_200C_200D_200E_202A_202B_202A_202E(modResourceData.url, obj.path))
					{
						num7 = -1939890288;
						num8 = num7;
					}
					else
					{
						num7 = -817204145;
						num8 = num7;
					}
					num = num7 ^ (int)(num2 * 1623420539);
					continue;
				}
				case 12u:
					num = (int)((num2 * 1516637258) ^ 0x7D4EA657);
					continue;
				case 8u:
					data = AssetBundleManager.data.data;
					num3 = 0;
					num = ((int)num2 * -1333367544) ^ -546522375;
					continue;
				case 15u:
					((MonoBehaviour)AudioManager.Instance).StartCoroutine(Tools.DownloadIntoTexture(val, ModManager.ModBaseUrl + obj2.CS_0024_003C_003E8__locals1.path, obj2._200D_202A_206C_206E_200F_206C_200C_200D_202A_202C_202E_206D_200C_200C_206A_202C_206D_206A_200E_202E_200C_206B_206E_202E_200F_202B_200C_202E_202C_206D_206E_206F_206E_200C_202C_206A_200E_202C_200E_200E_202E));
					num = ((int)num2 * -1231873236) ^ 0x5B00DAB1;
					continue;
				case 1u:
					spriteCache.Add(obj2.CS_0024_003C_003E8__locals1.path, obj2.result);
					num = (int)(num2 * 841504285) ^ -731611033;
					continue;
				case 13u:
					_206B_202D_206C_202B_202C_200C_206F_202C_206F_206A_200B_206D_200F_206F_200B_206C_200F_206C_200B_206F_206C_206D_202D_202B_202D_206D_202E_206C_200B_202B_206F_200B_206C_200B_206F_202A_206D_206A_200C_202E(val, 0, 0, Color.white);
					num = (int)(num2 * 1187861563) ^ -1130357219;
					continue;
				case 7u:
					obj2.result = Sprite.Create(val, new Rect(0f, 0f, (float)_206D_200B_202E_200B_202D_200E_206E_206F_202D_206A_206E_202B_202B_206C_200F_206F_202E_200C_206A_200F_206B_200B_202E_206E_200F_200B_206F_200B_202A_202E_206B_206C_202A_200D_206E_206E_206A_206E_202B_206F_202E((Texture)(object)val), (float)_200C_200C_200F_200D_200F_206A_206B_200B_206B_206E_200D_206F_200C_206D_200C_206D_202B_202D_200B_202A_206E_206E_206E_200C_202E_202C_206C_200E_200D_206B_206C_206A_202D_202D_202E_202E_200B_206F_200B_202C_202E((Texture)(object)val)), new Vector2(0.5f, 0.5f));
					num = (int)(num2 * 932969479) ^ -1850534667;
					continue;
				case 14u:
					modResourceData = data[num3];
					num = -2006835018;
					continue;
				case 11u:
					num3++;
					num = -1894431153;
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (!spriteCache.ContainsKey(obj.path))
					{
						num5 = -813897617;
						num6 = num5;
					}
					else
					{
						num5 = -1283601966;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1833840795);
					continue;
				}
				case 4u:
					obj2 = new _206E_202C_200E_200E_200F_202D_206B_206D_202A_206B_206A_202B_206F_206F_202D_200F_202C_206C_200E_206B_200B_202A_206E_202A_206A_200B_202B_200D_206D_200B_202E_202C_206E_202C_202E_202B_200F_202B_200E_200C_202E();
					num = (int)(num2 * 510051696) ^ -1189386260;
					continue;
				case 10u:
				{
					int num4;
					if (num3 < data.Length)
					{
						num = -831855125;
						num4 = num;
					}
					else
					{
						num = -1984190528;
						num4 = num;
					}
					continue;
				}
				case 9u:
					obj2.CS_0024_003C_003E8__locals1 = obj;
					val = _202E_200B_200D_206A_200F_200E_206E_202B_206B_206F_206C_202B_206C_206F_202C_206B_200F_202B_200D_202D_202B_206C_206A_206A_206E_202B_206C_206E_206F_206E_200F_206A_202E_206A_200C_200B_202D_202B_202B_202A_202E(modResourceData.w, modResourceData.h);
					num = (int)((num2 * 1915053257) ^ 0x23E78469);
					continue;
				case 0u:
					return;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	public static IEnumerator LoadXmlText(LoadingUI ui, string path, CommonSettings.VoidCallBack callback)
	{
		string key = default(string);
		int num4 = default(int);
		while (true)
		{
			int num = -920600724;
			while (true)
			{
				uint num2;
				string text;
				int num3;
				switch ((num2 = (uint)(num ^ -137856963)) % 14)
				{
				case 8u:
					break;
				case 12u:
					num = -919296863;
					continue;
				case 10u:
					num = ((!xmls.ContainsKey(key)) ? 1089968578 : 172972080) ^ ((int)num2 * -1797332638);
					continue;
				case 7u:
					text = path;
					goto IL_00a5;
				case 11u:
					yield return 0;
					/*Error: Unable to find new state assignment for yield return*/;
				case 4u:
					num = ((num3 != 1) ? 218370558 : 1315452443) ^ (int)(num2 * 388062530);
					continue;
				case 13u:
					if (num4 != -1)
					{
						text = _206E_202C_206E_200E_206E_206D_202A_206E_202D_206A_200F_202C_206F_200C_200B_200D_206B_206E_202D_202D_200B_206C_202D_200B_206C_202D_202E_200E_206C_200F_200D_200F_202E_200F_206C_206F_206E_206C_202A_202D_202E._206C_200D_206D_206C_200D_206D_202D_206D_202E_202C_202A_206C_202B_206A_200D_206E_206C_206B_202C_206C_206C_200C_202C_202E_200D_206F_202B_202A_202A_202D_202D_200E_202E_206C_202A_200F_200C_200E_202E_200C_202E(path, 0, num4);
						goto IL_00a5;
					}
					num = (int)(num2 * 744007580) ^ -1178982392;
					continue;
				case 1u:
					yield break;
				case 2u:
					try
					{
						/*Error near IL_0118: Unexpected return in MoveNext()*/;
					}
					finally
					{
						/*Error: Could not find finallyMethod for state=1.
Possibly this method is affected by a C# compiler bug that causes the finally body
not to run in case of an exception or early 'break;' out of a loop consuming this iterable.*/;
					}
				case 5u:
					xmls.Add(key, _206E_202C_206E_200E_206E_206D_202A_206E_202D_206A_200F_202C_206F_200C_200B_200D_206B_206E_202D_202D_200B_206C_202D_200B_206C_202D_202E_200E_206C_200F_200D_200F_202E_200F_206C_206F_206E_206C_202A_202D_202E._206E_202A_206C_200D_200F_200B_200B_206E_202C_200E_200D_200D_200C_202B_206F_202E_200E_206B_200D_206A_206B_202D_206D_202A_206B_206C_206E_200C_206E_206A_206C_206D_202D_202B_206F_200B_200B_202A_200F_202E_202E(ModManager.ModBaseUrlPath, path));
					num = (int)(num2 * 96067988) ^ -1711149464;
					continue;
				case 0u:
					num = -1621606754;
					continue;
				case 6u:
					num4 = _206E_202C_206E_200E_206E_206D_202A_206E_202D_206A_200F_202C_206F_200C_200B_200D_206B_206E_202D_202D_200B_206C_202D_200B_206C_202D_202E_200E_206C_200F_200D_200F_202E_200F_206C_206F_206E_206C_202A_202D_202E._206C_202E_202E_200F_206F_202D_206E_206F_206A_206E_206A_202C_202A_202D_206B_200C_202C_200B_206E_206F_200C_206F_206E_200F_200B_202E_206F_200F_202B_206E_202D_200B_206C_202E_200F_206D_200C_206E_206C_202B_202E(path, '.');
					num = ((int)num2 * -1637383973) ^ -952600942;
					continue;
				case 3u:
					num = ((num3 != 0) ? (-175293365) : (-370266475)) ^ (int)(num2 * 1194777712);
					continue;
				default:
					{
						callback();
						yield break;
					}
					IL_00a5:
					key = text;
					num = -569195649;
					continue;
				}
				break;
			}
		}
	}

	public static void LoadUIpic()
	{
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0718: Unknown result type (might be due to invalid IL or missing references)
		if (!uiCache.ContainsKey(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2145941894u)))
		{
			goto IL_0019;
		}
		goto IL_05fc;
		IL_0019:
		int num = 131975356;
		goto IL_001e;
		IL_001e:
		string persistentDataPath = default(string);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x2B6B0A15)) % 23)
			{
			case 20u:
				break;
			default:
				return;
			case 4u:
				uiCache.Add(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3584665497u), LoadSpriteFromFile(persistentDataPath + global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4154172482u), Vector2.zero));
				num = ((int)num2 * -502339108) ^ 0x4D548C78;
				continue;
			case 19u:
				uiCache.Add(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4207795928u), LoadSpriteFromFile(_202E_206E_200E_202E_202A_200C_202C_206B_202B_206A_202A_206D_206D_206D_200B_206F_200D_206B_200B_206F_202B_202D_206A_202C_202D_206A_200F_206A_202E_202C_206D_202A_202D_206F_200F_206B_206A_200B_206B_202E_202E(persistentDataPath, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3923148764u)), Vector2.zero));
				uiCache.Add(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2562128691u), LoadSpriteFromFile(_202E_206E_200E_202E_202A_200C_202C_206B_202B_206A_202A_206D_206D_206D_200B_206F_200D_206B_200B_206F_202B_202D_206A_202C_202D_206A_200F_206A_202E_202C_206D_202A_202D_206F_200F_206B_206A_200B_206B_202E_202E(persistentDataPath, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(302215024u)), Vector2.zero));
				uiCache.Add(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1525241647u), LoadSpriteFromFile(_202E_206E_200E_202E_202A_200C_202C_206B_202B_206A_202A_206D_206D_206D_200B_206F_200D_206B_200B_206F_202B_202D_206A_202C_202D_206A_200F_206A_202E_202C_206D_202A_202D_206F_200F_206B_206A_200B_206B_202E_202E(persistentDataPath, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3909897642u)), Vector2.zero));
				uiCache.Add(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2177434814u), LoadSpriteFromFile(_202E_206E_200E_202E_202A_200C_202C_206B_202B_206A_202A_206D_206D_206D_200B_206F_200D_206B_200B_206F_202B_202D_206A_202C_202D_206A_200F_206A_202E_202C_206D_202A_202D_206F_200F_206B_206A_200B_206B_202E_202E(persistentDataPath, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1527968795u)), Vector2.zero));
				num = (int)(num2 * 302959385) ^ -1476453656;
				continue;
			case 15u:
				uiCache.Add(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(25107666u), LoadSpriteFromFile(_202E_206E_200E_202E_202A_200C_202C_206B_202B_206A_202A_206D_206D_206D_200B_206F_200D_206B_200B_206F_202B_202D_206A_202C_202D_206A_200F_206A_202E_202C_206D_202A_202D_206F_200F_206B_206A_200B_206B_202E_202E(persistentDataPath, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1202786645u)), Vector2.zero));
				num = (int)(num2 * 288470854) ^ -1424215649;
				continue;
			case 5u:
				Resource.CacheImage(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3809942285u));
				num = (int)((num2 * 2143632294) ^ 0x1A7CDB69);
				continue;
			case 16u:
				uiCache.Add(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4064705277u), LoadSpriteFromFile(_202E_206E_200E_202E_202A_200C_202C_206B_202B_206A_202A_206D_206D_206D_200B_206F_200D_206B_200B_206F_202B_202D_206A_202C_202D_206A_200F_206A_202E_202C_206D_202A_202D_206F_200F_206B_206A_200B_206B_202E_202E(persistentDataPath, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2242216014u)), Vector2.zero));
				num = (int)(num2 * 347448807) ^ -623890290;
				continue;
			case 17u:
				uiCache.Add(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2805057995u), LoadSpriteFromFile(persistentDataPath + global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1246182641u), Vector2.zero));
				uiCache.Add(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1585296274u), LoadSpriteFromFile(persistentDataPath + global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1610998162u), Vector2.zero));
				num = (int)((num2 * 540182369) ^ 0x71633513);
				continue;
			case 12u:
				persistentDataPath = CommonSettings.persistentDataPath;
				uiCache.Add(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(976373687u), LoadSpriteFromFile(_202E_206E_200E_202E_202A_200C_202C_206B_202B_206A_202A_206D_206D_206D_200B_206F_200D_206B_200B_206F_202B_202D_206A_202C_202D_206A_200F_206A_202E_202C_206D_202A_202D_206F_200F_206B_206A_200B_206B_202E_202E(persistentDataPath, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1559276544u)), Vector2.zero));
				num = (int)(num2 * 1350304966) ^ -1204180716;
				continue;
			case 3u:
			{
				int num3;
				int num4;
				if (CommonSettings.MOD_KEY() != 0)
				{
					num3 = -293267991;
					num4 = num3;
				}
				else
				{
					num3 = -1799272835;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 686224583);
				continue;
			}
			case 0u:
				Resource.CacheImage(ResourceStrings.ResStrings[1105] + ResourceStrings.ResStrings[2]);
				num = ((int)num2 * -996985928) ^ 0x1B5D9280;
				continue;
			case 14u:
				uiCache.Add(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(873452737u), LoadSpriteFromFile(_202E_206E_200E_202E_202A_200C_202C_206B_202B_206A_202A_206D_206D_206D_200B_206F_200D_206B_200B_206F_202B_202D_206A_202C_202D_206A_200F_206A_202E_202C_206D_202A_202D_206F_200F_206B_206A_200B_206B_202E_202E(persistentDataPath, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2427047159u)), Vector2.zero));
				uiCache.Add(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(469980450u), LoadSpriteFromFile(_202E_206E_200E_202E_202A_200C_202C_206B_202B_206A_202A_206D_206D_206D_200B_206F_200D_206B_200B_206F_202B_202D_206A_202C_202D_206A_200F_206A_202E_202C_206D_202A_202D_206F_200F_206B_206A_200B_206B_202E_202E(persistentDataPath, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2501046755u)), Vector2.zero));
				num = ((int)num2 * -1535573268) ^ 0x13C0A369;
				continue;
			case 10u:
				uiCache.Add(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(748952579u), LoadSpriteFromFile(persistentDataPath + global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1452599370u), Vector2.zero));
				num = (int)((num2 * 1680227418) ^ 0x2DC5CDD2);
				continue;
			case 18u:
				uiCache.Add(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2220908027u), LoadSpriteFromFile(_202E_206E_200E_202E_202A_200C_202C_206B_202B_206A_202A_206D_206D_206D_200B_206F_200D_206B_200B_206F_202B_202D_206A_202C_202D_206A_200F_206A_202E_202C_206D_202A_202D_206F_200F_206B_206A_200B_206B_202E_202E(persistentDataPath, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2477153290u)), Vector2.zero));
				uiCache.Add(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4091392478u), LoadSpriteFromFile(_202E_206E_200E_202E_202A_200C_202C_206B_202B_206A_202A_206D_206D_206D_200B_206F_200D_206B_200B_206F_202B_202D_206A_202C_202D_206A_200F_206A_202E_202C_206D_202A_202D_206F_200F_206B_206A_200B_206B_202E_202E(persistentDataPath, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(27750706u)), new Vector2(0.5f, 0.5f)));
				uiCache.Add(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3979665003u), LoadSpriteFromFile(persistentDataPath + global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(417317678u), Vector2.zero));
				num = (int)(num2 * 758571756) ^ -1618264673;
				continue;
			case 7u:
				uiCache.Add(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3179420901u), LoadSpriteFromFile(persistentDataPath + global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1791706454u), Vector2.zero));
				num = (int)(num2 * 29809692) ^ -1358771807;
				continue;
			case 2u:
				Resource.CacheImage(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2908263085u));
				num = ((int)num2 * -687178518) ^ 0x208F5E2;
				continue;
			case 21u:
				uiCache.Add(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2249146984u), LoadSpriteFromFile(_202E_206E_200E_202E_202A_200C_202C_206B_202B_206A_202A_206D_206D_206D_200B_206F_200D_206B_200B_206F_202B_202D_206A_202C_202D_206A_200F_206A_202E_202C_206D_202A_202D_206F_200F_206B_206A_200B_206B_202E_202E(persistentDataPath, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1786508769u)), Vector2.zero));
				uiCache.Add(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2643104186u), LoadSpriteFromFile(_202E_206E_200E_202E_202A_200C_202C_206B_202B_206A_202A_206D_206D_206D_200B_206F_200D_206B_200B_206F_202B_202D_206A_202C_202D_206A_200F_206A_202E_202C_206D_202A_202D_206F_200F_206B_206A_200B_206B_202E_202E(persistentDataPath, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3432385499u)), Vector2.zero));
				uiCache.Add(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3044327689u), LoadSpriteFromFile(_202E_206E_200E_202E_202A_200C_202C_206B_202B_206A_202A_206D_206D_206D_200B_206F_200D_206B_200B_206F_202B_202D_206A_202C_202D_206A_200F_206A_202E_202C_206D_202A_202D_206F_200F_206B_206A_200B_206B_202E_202E(persistentDataPath, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2117773317u)), Vector2.zero));
				num = ((int)num2 * -2036130937) ^ 0x2DACEECB;
				continue;
			case 13u:
				goto IL_05fc;
			case 8u:
				Resource.CacheImage(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3966663913u));
				num = ((int)num2 * -1525351329) ^ 0x2A900B06;
				continue;
			case 9u:
				uiCache.Add(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1442993394u), LoadSpriteFromFile(_202E_206E_200E_202E_202A_200C_202C_206B_202B_206A_202A_206D_206D_206D_200B_206F_200D_206B_200B_206F_202B_202D_206A_202C_202D_206A_200F_206A_202E_202C_206D_202A_202D_206F_200F_206B_206A_200B_206B_202E_202E(persistentDataPath, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2112988945u)), Vector2.zero));
				num = ((int)num2 * -137261920) ^ -1176688904;
				continue;
			case 1u:
				uiCache.Add(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4259781295u), LoadSpriteFromFile(persistentDataPath + global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(715035384u), Vector2.zero));
				uiCache.Add(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3418194758u), null);
				num = (int)(num2 * 462425546) ^ -1574510779;
				continue;
			case 11u:
				Resource.CacheImage(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2319492245u));
				num = (int)((num2 * 648879037) ^ 0x10DE4935);
				continue;
			case 22u:
				uiCache.Add(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1944600128u), LoadSpriteFromFile(_202E_206E_200E_202E_202A_200C_202C_206B_202B_206A_202A_206D_206D_206D_200B_206F_200D_206B_200B_206F_202B_202D_206A_202C_202D_206A_200F_206A_202E_202C_206D_202A_202D_206F_200F_206B_206A_200B_206B_202E_202E(persistentDataPath, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1289685014u)), Vector2.zero));
				num = ((int)num2 * -950758732) ^ -1164810252;
				continue;
			case 6u:
				return;
			}
			break;
		}
		goto IL_0019;
		IL_05fc:
		int num5;
		if (CommonSettings.MOD_KEY() < 0)
		{
			num = 1112748322;
			num5 = num;
		}
		else
		{
			num = 2005047050;
			num5 = num;
		}
		goto IL_001e;
	}

	public static Sprite LoadSpriteWithCompress(string url, bool compress = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		Sprite val = LoadSpriteFromFile(url, Vector2.zero);
		while (true)
		{
			int num = -2010289343;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2091260441)) % 4)
				{
				case 0u:
					break;
				case 2u:
				{
					int num3;
					int num4;
					if (!(_202A_200C_200F_202E_200B_206F_202C_200C_200D_200B_200F_202E_206A_202E_206C_206A_206C_200F_206C_200C_200F_202E_202D_206D_206B_202E_200E_206E_206C_202D_202B_206A_202E_206D_200F_206E_202C_206D_206B_202E_202E((Object)(object)val, (Object)null) && compress))
					{
						num3 = 2012768624;
						num4 = num3;
					}
					else
					{
						num3 = 883316910;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -892150299);
					continue;
				}
				case 3u:
					_206F_200E_200C_200B_202E_202A_202A_202A_202D_206A_206D_202B_202E_200C_200D_202B_200B_200D_206B_206A_206D_200C_202D_206F_202A_202A_206B_200E_202E_200C_200E_206C_202D_206A_200C_202C_200D_206D_202A_206D_202E(_202E_206B_200F_200C_202A_206E_200B_206D_206A_206B_206F_200F_200B_200C_200D_200C_200B_202E_202C_200B_202B_206A_206C_200D_200E_206A_202A_200C_202C_202E_200B_202B_206C_202C_206C_206E_202C_200E_200D_200E_202E(val), true);
					num = ((int)num2 * -1648672022) ^ -1423076536;
					continue;
				default:
					return val;
				}
				break;
			}
		}
	}

	public static Font GetFont(string key = "Arial")
	{
		if (!fontCache.ContainsKey(key))
		{
			while (true)
			{
				int num = -1026961413;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -2079415054)) % 4)
					{
					case 2u:
						break;
					case 1u:
						fontCache.Add(key, _206C_202E_206A_202A_200E_206C_202A_200E_200E_200F_206E_202B_202B_206F_200D_202D_206D_202E_206F_206C_206B_202D_200E_202D_202D_202D_202E_200C_202C_200E_200C_206C_202B_206C_206B_206E_202C_202D_206E_200D_202E(key, 12));
						num = (int)((num2 * 1844732609) ^ 0x12F89813);
						continue;
					case 0u:
						LoadingUI.IsFontTextureLoaded = false;
						num = (int)(num2 * 6055673) ^ -408655759;
						continue;
					default:
						goto end_IL_000d;
					}
					break;
				}
				continue;
				end_IL_000d:
				break;
			}
		}
		return fontCache[key];
	}

	public static void SetFontTexture(string key = "Arial")
	{
		if (LoadingUI.IsFontTextureLoaded)
		{
			return;
		}
		while (true)
		{
			int num = 1877268681;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x411B168A)) % 5)
				{
				case 2u:
					break;
				default:
					return;
				case 3u:
					_206A_202C_206B_200B_202E_200F_206E_200F_206F_202B_206C_206B_202D_202C_200C_202E_206C_200E_200C_206D_200C_202B_200F_200C_200E_200F_206D_202A_206D_206F_200E_202C_202C_200E_202A_200E_202C_202C_206C_200C_202E(fontCache[key], global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2252501543u));
					num = ((int)num2 * -1626270350) ^ -1725474417;
					continue;
				case 0u:
					LoadingUI.IsFontTextureLoaded = true;
					num = (int)((num2 * 160907980) ^ 0x4EEA8FD);
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (fontCache.ContainsKey(key))
					{
						num3 = -2138376001;
						num4 = num3;
					}
					else
					{
						num3 = -693797572;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -712126097);
					continue;
				}
				case 1u:
					return;
				}
				break;
			}
		}
	}

	static bool _206F_202D_200C_202C_202B_200C_206A_202A_206F_202D_206A_206D_202C_200D_200B_206F_206D_202B_206E_206A_206C_206C_200D_202D_200B_200C_200F_200C_200F_206D_200C_200F_202E_200D_202A_200C_206E_200D_200E_206D_202E(string P_0)
	{
		return File.Exists(P_0);
	}

	static StreamReader _202B_200B_200C_202A_200B_202A_202E_200D_200F_206C_202A_206C_200F_202B_200C_206C_206A_202A_200E_200D_200F_202D_202E_200D_200B_202C_202A_206E_200F_206A_206E_200C_200D_206C_206E_200E_206D_200B_206B_206D_202E(string P_0)
	{
		return new StreamReader(P_0);
	}

	static string _200B_206B_206B_200E_200F_200D_200F_202D_202C_202A_202A_200E_206D_206B_206D_206C_202C_200E_202E_200C_200B_200E_206E_200E_202A_206E_206B_206E_206B_202E_206D_202E_200B_200D_200B_206D_202C_200D_206C_206B_202E(TextReader P_0)
	{
		return P_0.ReadToEnd();
	}

	static void _200C_202E_202D_206F_202C_206E_200F_202D_206D_202C_206F_206C_202E_206A_200F_206D_200F_206F_200B_206A_202B_200E_206C_206E_206D_200C_206B_200E_206C_202E_200F_200E_206D_202E_206B_202C_202A_200C_202B_206F_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}

	static string _202E_206E_200E_202E_202A_200C_202C_206B_202B_206A_202A_206D_206D_206D_200B_206F_200D_206B_200B_206F_202B_202D_206A_202C_202D_206A_200F_206A_202E_202C_206D_202A_202D_206F_200F_206B_206A_200B_206B_202E_202E(string P_0, string P_1)
	{
		return P_0 + P_1;
	}

	static WWW _200F_206A_200E_206C_200E_206B_200C_202B_206F_206A_200B_206A_206B_202C_202D_202C_206A_202E_202B_206A_206A_202E_200F_202E_200D_206E_206B_202B_202A_202E_206C_202A_206D_202E_202B_202C_202C_206A_202B_206E_202E(string P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new WWW(P_0);
	}

	static string _206B_202B_200B_202C_206D_202D_202A_200C_200E_202D_200C_206C_200B_202C_206B_202D_206B_200B_206A_202A_206A_200C_200C_200B_200D_200B_202A_202D_200C_200E_202B_202C_202C_206B_202E_200E_202A_206E_206E_200C_202E(WWW P_0)
	{
		return P_0.error;
	}

	static bool _206E_206D_200C_202A_206F_206E_200C_200F_206C_206A_200F_200E_200F_206A_200C_206A_206A_202E_206F_202D_206E_206E_200C_200E_200C_200E_200C_202A_200C_200F_202A_202E_206D_206B_200B_206D_206D_206A_202B_200E_202E(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}

	static string _206C_206C_200B_200F_200C_202A_206C_200B_206A_200B_206C_200D_202D_206C_202D_206D_206C_200C_200E_200F_202E_200B_200D_200C_202E_206A_202C_202C_206A_202E_200E_200B_200F_206B_202B_200E_206D_206F_206E_200D_202E(WWW P_0)
	{
		return P_0.text;
	}

	static void _202B_200C_202E_206F_206F_202C_206D_202E_206E_202E_200B_206D_200D_202E_202A_202C_202A_200D_202D_200C_200E_206D_202B_206F_202D_206F_206D_200B_206E_206C_202D_200E_206B_206F_202C_206E_200D_202D_206F_202E_202E(object P_0)
	{
		Debug.LogError(P_0);
	}

	static bool _206E_202C_202D_206A_206C_200B_206A_202B_206E_202E_206B_206B_202A_200F_200F_206D_202C_200D_202B_202B_200C_202B_200B_200B_206E_206A_200F_206C_200F_202E_206F_200E_202A_202E_200C_200D_200E_202A_202B_202A_202E(string P_0, string P_1)
	{
		return P_0.Equals(P_1);
	}

	static Texture2D _202E_200B_200D_206A_200F_200E_206E_202B_206B_206F_206C_202B_206C_206F_202C_206B_200F_202B_200D_202D_202B_206C_206A_206A_206E_202B_206C_206E_206F_206E_200F_206A_202E_206A_200C_200B_202D_202B_202B_202A_202E(int P_0, int P_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new Texture2D(P_0, P_1);
	}

	static void _206B_202D_206C_202B_202C_200C_206F_202C_206F_206A_200B_206D_200F_206F_200B_206C_200F_206C_200B_206F_206C_206D_202D_202B_202D_206D_202E_206C_200B_202B_206F_200B_206C_200B_206F_202A_206D_206A_200C_202E(Texture2D P_0, int P_1, int P_2, Color P_3)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		P_0.SetPixel(P_1, P_2, P_3);
	}

	static int _206D_200B_202E_200B_202D_200E_206E_206F_202D_206A_206E_202B_202B_206C_200F_206F_202E_200C_206A_200F_206B_200B_202E_206E_200F_200B_206F_200B_202A_202E_206B_206C_202A_200D_206E_206E_206A_206E_202B_206F_202E(Texture P_0)
	{
		return P_0.width;
	}

	static int _200C_200C_200F_200D_200F_206A_206B_200B_206B_206E_200D_206F_200C_206D_200C_206D_202B_202D_200B_202A_206E_206E_206E_200C_202E_202C_206C_200E_200D_206B_206C_206A_202D_202D_202E_202E_200B_206F_200B_202C_202E(Texture P_0)
	{
		return P_0.height;
	}

	static AudioClip _200F_200F_202C_202E_206D_200E_200C_200B_200D_200B_206F_200C_200B_202D_200D_206E_206C_202E_206C_206D_200F_206D_206E_202C_200F_206D_202A_200C_202B_206F_206B_206C_200F_206E_200B_202A_202D_202B_206F_200D_202E(WWW P_0, bool P_1, bool P_2)
	{
		return P_0.GetAudioClip(P_1, P_2);
	}

	static void _200E_202E_206A_200D_200F_202D_206C_206A_202B_202A_206D_202B_206F_206D_206B_200E_206F_202D_202E_202C_202D_206B_202C_202E_206C_206D_202B_200F_206B_202B_200F_200E_202D_206E_200C_202E_200C_206D_206D_202E(Object P_0)
	{
		Object.DestroyImmediate(P_0);
	}

	static FileStream _202B_202C_202B_202A_206F_206E_202A_206A_200F_200C_202A_206A_202E_202B_206B_200E_202C_200E_206D_206F_206D_206C_200D_202E_202B_202B_206D_206A_206A_206C_206B_206B_200C_206A_202B_202A_206D_202D_206F_202E_202E(string P_0, FileMode P_1, FileAccess P_2)
	{
		return new FileStream(P_0, P_1, P_2);
	}

	static long _206D_206C_206A_202A_200C_200D_202B_200C_206D_200F_206F_200E_206C_202D_200D_200C_206C_206B_200B_200B_206D_202E_202E_200F_206D_200C_200B_206B_200C_200E_202A_202D_200D_202A_206E_202A_202A_206F_200D_200F_202E(Stream P_0, long P_1, SeekOrigin P_2)
	{
		return P_0.Seek(P_1, P_2);
	}

	static long _202E_200C_206A_200B_206F_206A_206D_202B_202B_206F_202B_206E_202D_200D_202D_202C_206F_206A_206B_202D_202C_200C_202B_206A_200F_200D_202D_206F_202B_202B_206B_202B_206E_202B_206E_206F_202B_202B_202A_200D_202E(Stream P_0)
	{
		return P_0.Length;
	}

	static int _206B_206E_202C_200C_202B_200B_206B_206E_200C_202A_200D_200C_202A_206E_206C_200B_200C_206E_202D_206E_206D_202A_200F_202D_202E_206C_200C_206F_206A_200E_206D_206B_202D_202B_206F_200B_200D_200C_202C_206B_202E(Stream P_0, byte[] P_1, int P_2, int P_3)
	{
		return P_0.Read(P_1, P_2, P_3);
	}

	static void _200E_200E_206B_202E_202E_200B_202C_206D_202D_202B_202E_202D_200C_206D_200F_206F_206E_206E_200F_206B_202C_202E_206D_200B_206D_202D_206C_200C_200B_200C_202B_202D_200C_206E_206D_206D_206F_206D_200C_202C_202E(Stream P_0)
	{
		P_0.Close();
	}

	static void _202D_206B_202A_206A_200F_206A_206E_206C_202C_202B_206B_200D_200F_200C_200E_200C_206A_206D_202C_200E_202A_200C_206B_200C_202D_200D_202E_200C_206F_200F_200C_206A_206A_202D_200C_206B_202D_200E_206D_200C_202E(Stream P_0)
	{
		P_0.Dispose();
	}

	static bool _206B_200F_206C_200F_200D_202D_206C_202B_200D_206B_206B_206C_206E_200E_200F_200B_200C_202D_206F_206E_202E_202B_200E_200E_200F_206F_202D_200F_206C_200B_200B_200E_202D_202E_206B_206A_206B_206E_202D_206E_202E(Texture2D P_0, byte[] P_1)
	{
		return P_0.LoadImage(P_1);
	}

	static bool _200D_202C_200E_206F_200F_206C_206E_206C_202E_200D_206B_202E_200D_200D_202C_200B_200E_200E_202D_200B_206C_202C_200F_206A_206C_206B_200E_206A_202A_206E_200C_202A_202E_202D_200D_200B_202E_206C_206C_202C_202E(string P_0, string P_1)
	{
		return P_0.EndsWith(P_1);
	}

	static bool _202A_200C_200F_202E_200B_206F_202C_200C_200D_200B_200F_202E_206A_202E_206C_206A_206C_200F_206C_200C_200F_202E_202D_206D_206B_202E_200E_206E_206C_202D_202B_206A_202E_206D_200F_206E_202C_206D_206B_202E_202E(Object P_0, Object P_1)
	{
		return P_0 != P_1;
	}

	static Texture2D _202E_206B_200F_200C_202A_206E_200B_206D_206A_206B_206F_200F_200B_200C_200D_200C_200B_202E_202C_200B_202B_206A_206C_200D_200E_206A_202A_200C_202C_202E_200B_202B_206C_202C_206C_206E_202C_200E_200D_200E_202E(Sprite P_0)
	{
		return P_0.texture;
	}

	static void _206F_200E_200C_200B_202E_202A_202A_202A_202D_206A_206D_202B_202E_200C_200D_202B_200B_200D_206B_206A_206D_200C_202D_206F_202A_202A_206B_200E_202E_200C_200E_206C_202D_206A_200C_202C_200D_206D_202A_206D_202E(Texture2D P_0, bool P_1)
	{
		P_0.Compress(P_1);
	}

	static Font _206C_202E_206A_202A_200E_206C_202A_200E_200E_200F_206E_202B_202B_206F_200D_202D_206D_202E_206F_206C_206B_202D_200E_202D_202D_202D_202E_200C_202C_200E_200C_206C_202B_206C_206B_206E_202C_202D_206E_200D_202E(string P_0, int P_1)
	{
		return Font.CreateDynamicFontFromOSFont(P_0, P_1);
	}

	static void _206A_202C_206B_200B_202E_200F_206E_200F_206F_202B_206C_206B_202D_202C_200C_202E_206C_200E_200C_206D_200C_202B_200F_200C_200E_200F_206D_202A_206D_206F_200E_202C_202C_200E_202A_200E_202C_202C_206C_200C_202E(Font P_0, string P_1)
	{
		P_0.RequestCharactersInTexture(P_1);
	}
}
