using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml.Serialization;
using UnityEngine;

namespace JyGame;

[XmlType("resource")]
public class Resource : BasePojo
{
	[CompilerGenerated]
	private sealed class _202B_200E_206E_206A_200F_200F_206A_206E_206A_200B_206E_202D_200D_202B_200B_206E_206D_202B_202D_206C_200B_206B_202C_200B_206C_202B_206B_200B_200F_206F_200B_206D_206E_200B_206C_200C_200F_206E_200F_200D_202E : IEnumerator<object>, IEnumerator, IDisposable
	{
		internal string url;

		internal WWW _202A_200D_202E_206C_200E_202E_200D_206F_202E_206B_200C_206B_202E_206A_200C_202B_202D_206E_202E_202E_206F_206F_206C_200E_206A_202E_206A_202B_202B_200B_200B_202A_202B_202D_200D_202E_206C_206F_202B_200C_202E;

		internal Action<Texture2D> cb;

		internal int _0024PC;

		internal object _0024current;

		internal string _206F_202E_202B_206E_202C_202E_202A_202E_206B_202B_202B_206D_200B_206D_206D_206F_200C_206A_200E_200D_206A_202A_206E_202C_206F_206C_202B_200F_200D_206E_206B_206B_200C_200C_200D_206C_202E_206D_202D_200E_202E;

		internal Action<Texture2D> _200B_202B_206C_206C_200D_200B_200B_202C_202D_202B_206B_206A_202A_200C_202B_202D_206D_206E_200C_206C_206B_200C_200C_202E_202C_200B_200C_206E_202C_200E_200C_202E_200E_202D_202C_202D_202E_200B_202C_200F_202E;

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
				int num2 = 1047178108;
				while (true)
				{
					uint num3;
					int num4;
					switch ((num3 = (uint)(num2 ^ 0x7AE75A0E)) % 12)
					{
					case 0u:
						break;
					case 11u:
						_202A_200D_202E_206C_200E_202E_200D_206F_202E_206B_200C_206B_202E_206A_200C_202B_202D_206E_202E_202E_206F_206F_206C_200E_206A_202E_206A_202B_202B_200B_200B_202A_202B_202D_200D_202E_206C_206F_202B_200C_202E = _200E_202D_200C_202A_202E_200F_206A_206B_206B_200B_200E_202E_200C_206E_200B_202E_200B_206A_206C_206F_206B_200E_202D_200C_202A_202D_206D_206B_200D_202E_202C_202A_202B_202D_206E_202E_200C_200C_200F_202E(url);
						num2 = 1967651899;
						continue;
					case 8u:
						return true;
					case 9u:
						return false;
					case 1u:
						_0024current = _202A_200D_202E_206C_200E_202E_200D_206F_202E_206B_200C_206B_202E_206A_200C_202B_202D_206E_202E_202E_206F_206F_206C_200E_206A_202E_206A_202B_202B_200B_200B_202A_202B_202D_200D_202E_206C_206F_202B_200C_202E;
						_0024PC = 1;
						num2 = (int)((num3 * 578082989) ^ 0x52A004B1);
						continue;
					case 2u:
						num2 = ((int)num3 * -362751431) ^ 0x2BB0F38C;
						continue;
					case 5u:
						num2 = ((int)num3 * -1101473518) ^ 0x7F717E25;
						continue;
					case 3u:
						goto IL_00c4;
					case 4u:
						_0024PC = -1;
						num2 = 1545278015;
						continue;
					case 6u:
						_0024PC = -1;
						switch (num)
						{
						case 0u:
							break;
						case 1u:
							goto IL_00c4;
						default:
							goto IL_0110;
						}
						goto case 11u;
					case 7u:
						cb(_200E_202A_202D_200D_206C_200F_206E_200E_202E_202A_202B_206A_200B_206A_206C_206A_206B_200B_200D_206F_202D_200E_202B_206B_202A_202E_206A_200E_206F_202A_206B_202D_202E_202C_200C_202A_202B_206A_200F_202E_202E(_202A_200D_202E_206C_200E_202E_200D_206F_202E_206B_200C_206B_202E_206A_200C_202B_202D_206E_202E_202E_206F_206F_206C_200E_206A_202E_206A_202B_202B_200B_200B_202A_202B_202D_200D_202E_206C_206F_202B_200C_202E));
						_202E_206F_200E_206D_200F_202E_206F_206F_200C_200B_206C_206C_202A_202C_200E_200D_206D_200B_202C_206A_206A_200B_202E_206E_202A_206E_206E_206D_206C_206B_200D_200D_206D_206D_206B_200C_206D_200F_206B_202B_202E(_202A_200D_202E_206C_200E_202E_200D_206F_202E_206B_200C_206B_202E_206A_200C_202B_202D_206E_202E_202E_206F_206F_206C_200E_206A_202E_206A_202B_202B_200B_200B_202A_202B_202D_200D_202E_206C_206F_202B_200C_202E);
						num2 = ((int)num3 * -1769850528) ^ 0x75DDAA32;
						continue;
					default:
						{
							return result;
						}
						IL_0110:
						num2 = (int)((num3 * 1833684214) ^ 0x5ADFC5E7);
						continue;
						IL_00c4:
						if (_200D_202C_206B_200F_200F_206B_206D_206C_200E_202D_206D_206F_206A_202D_200B_200E_202B_206D_206C_202B_202C_206E_206E_206B_200B_200E_202A_206C_202E_206F_206B_202E_200D_202B_200E_206D_206F_202B_202B_200C_202E(_202A_200B_206A_206E_206C_202B_206D_206F_200F_206E_200D_206C_200E_202E_206F_200C_202E_206A_206C_202C_206C_200C_206C_200D_206E_206A_206A_206A_206F_200B_206E_200C_206B_200F_202A_206A_206E_206A_206F_200D_202E(_202A_200D_202E_206C_200E_202E_200D_206F_202E_206B_200C_206B_202E_206A_200C_202B_202D_206E_202E_202E_206F_206F_206C_200E_206A_202E_206A_202B_202B_200B_200B_202A_202B_202D_200D_202E_206C_206F_202B_200C_202E)))
						{
							num2 = 1445722729;
							num4 = num2;
						}
						else
						{
							num2 = 1595719570;
							num4 = num2;
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
			throw _202D_206D_206E_206F_200D_202D_202B_200C_206F_200F_200F_200D_200E_202E_202E_202C_202C_200C_200F_206A_206D_202A_200C_202B_206C_202E_206A_206C_200F_206B_206A_200B_206B_200F_202E_200B_200D_202C_206C_200D_202E();
		}

		static WWW _200E_202D_200C_202A_202E_200F_206A_206B_206B_200B_200E_202E_200C_206E_200B_202E_200B_206A_206C_206F_206B_200E_202D_200C_202A_202D_206D_206B_200D_202E_202C_202A_202B_202D_206E_202E_200C_200C_200F_202E(string P_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Expected O, but got Unknown
			return new WWW(P_0);
		}

		static string _202A_200B_206A_206E_206C_202B_206D_206F_200F_206E_200D_206C_200E_202E_206F_200C_202E_206A_206C_202C_206C_200C_206C_200D_206E_206A_206A_206A_206F_200B_206E_200C_206B_200F_202A_206A_206E_206A_206F_200D_202E(WWW P_0)
		{
			return P_0.error;
		}

		static bool _200D_202C_206B_200F_200F_206B_206D_206C_200E_202D_206D_206F_206A_202D_200B_200E_202B_206D_206C_202B_202C_206E_206E_206B_200B_200E_202A_206C_202E_206F_206B_202E_200D_202B_200E_206D_206F_202B_202B_200C_202E(string P_0)
		{
			return string.IsNullOrEmpty(P_0);
		}

		static Texture2D _200E_202A_202D_200D_206C_200F_206E_200E_202E_202A_202B_206A_200B_206A_206C_206A_206B_200B_200D_206F_202D_200E_202B_206B_202A_202E_206A_200E_206F_202A_206B_202D_202E_202C_200C_202A_202B_206A_200F_202E_202E(WWW P_0)
		{
			return P_0.texture;
		}

		static void _202E_206F_200E_206D_200F_202E_206F_206F_200C_200B_206C_206C_202A_202C_200E_200D_206D_200B_202C_206A_206A_200B_202E_206E_202A_206E_206E_206D_206C_206B_200D_200D_206D_206D_206B_200C_206D_200F_206B_202B_202E(WWW P_0)
		{
			P_0.Dispose();
		}

		static NotSupportedException _202D_206D_206E_206F_200D_202D_202B_200C_206F_200F_200F_200D_200E_202E_202E_202C_202C_200C_200F_206A_206D_202A_200C_202B_206C_202E_206A_206C_200F_206B_206A_200B_206B_200F_202E_200B_200D_202C_206C_200D_202E()
		{
			return new NotSupportedException();
		}
	}

	[CompilerGenerated]
	private sealed class _202B_202C_206E_202D_200E_200F_200F_202E_200D_202E_200E_200B_206B_206A_200F_202C_200C_206E_206C_206B_206F_206B_202A_206D_206E_206C_202A_202A_200B_200F_206B_206C_202E_202B_206D_200E_206E_206C_202D_202A_202E
	{
		internal Action<AudioClip> callback;

		internal void _200D_200F_206D_206D_206C_206B_206B_200B_206E_200F_200E_202A_206C_200C_200F_202A_200B_200E_202D_206E_200C_206A_202C_200B_202B_202D_202A_200D_202C_206F_202D_202A_200D_206A_206F_200F_206F_206D_202C_206F_202E(AudioClip P_0)
		{
			callback(P_0);
		}
	}

	[CompilerGenerated]
	private sealed class _200E_202C_200E_202A_202C_202E_200F_202A_206D_202D_206E_202D_206A_206D_206C_202E_202E_200D_200C_202A_202E_202C_202C_202B_202D_206E_200C_200B_202E_200E_206D_200F_202D_206C_200C_206C_206E_206E_202B_206A_202E : IEnumerable<string>, IEnumerator<string>, IEnumerator, IDisposable, IEnumerable
	{
		private int _200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E;

		private string _200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E;

		private int _200B_202B_206E_200C_202C_200D_206F_202E_200F_206A_200C_202C_200B_202D_200F_206E_202D_206C_200B_202C_206C_206A_206E_206C_202B_206D_206E_200E_206E_202D_206E_202E_202E_202A_206D_206E_206D_202C_202D_202E;

		private string path;

		public string _206F_200B_206B_200D_206B_200D_206D_200C_202A_202B_200E_200F_206E_206E_206E_206E_202A_200F_200C_202B_200E_206D_206C_206F_202B_200E_200C_200F_200B_206D_202E_206D_206D_202A_202D_206F_202D_202A_202B_202D_202E;

		private Object[] _206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E;

		private int _200D_206A_202C_200E_206F_206B_202A_202D_200D_200E_202B_202A_206E_206E_202E_206B_200E_200F_202C_202D_202A_206C_202C_202A_200E_200C_206B_206B_206C_200D_206B_202A_202A_202D_200B_206E_206F_200F_202A_206A_202E;

		string IEnumerator<string>.Current
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
		public _200E_202C_200E_202A_202C_202E_200F_202A_206D_202D_206E_202D_206A_206D_206C_202E_202E_200D_200C_202A_202E_202C_202C_202B_202D_206E_200C_200B_202E_200E_206D_200F_202D_206C_200C_206C_206E_206E_202B_206A_202E(int P_0)
		{
			_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = P_0;
			_200B_202B_206E_200C_202C_200D_206F_202E_200F_206A_200C_202C_200B_202D_200F_206E_202D_206C_200B_202C_206C_206A_206E_206C_202B_206D_206E_200E_206E_202D_206E_202E_202E_202A_206D_206E_206D_202C_202D_202E = _202C_200F_200C_202D_200D_206B_200B_200B_206E_200F_206E_206D_202A_202B_202B_200E_206A_200E_206D_206D_200C_200C_206C_200E_200B_206C_200E_202A_202A_200D_200E_206E_202E_206C_206A_200B_202C_206A_206B_206C_202E(_200B_206C_206A_202D_202C_200C_206C_200D_202C_200E_202C_200B_200D_206F_206A_202C_200B_200C_202E_206A_202C_206B_206E_200E_200C_206C_200F_200C_206C_200F_202A_202C_202A_206D_206B_200F_206E_202D_200D_206E_202E());
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Expected O, but got Unknown
			int num = _200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E;
			if (num != 0)
			{
				goto IL_000d;
			}
			goto IL_011d;
			IL_000d:
			int num2 = -174438909;
			goto IL_0012;
			IL_0012:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -157112206)) % 12)
				{
				case 8u:
					break;
				case 5u:
				{
					int num4;
					int num5;
					if (num == 1)
					{
						num4 = 244692613;
						num5 = num4;
					}
					else
					{
						num4 = 2109723090;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 1821601987);
					continue;
				}
				case 4u:
					_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
					num2 = -411619522;
					continue;
				case 7u:
					return false;
				case 6u:
				{
					GameObject val = (GameObject)_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E[_200D_206A_202C_200E_206F_206B_202A_202D_200D_200E_202B_202A_206E_206E_202E_206B_200E_200F_202C_202D_202A_206C_202C_202A_200E_200C_206B_206B_206C_200D_206B_202A_202A_202D_200B_206E_206F_200F_202A_206A_202E];
					_200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E = _206E_206B_202A_200F_206F_200B_200C_206D_202D_202C_200E_206C_206A_206B_202E_206B_202D_202B_200E_200F_200E_202E_202D_202C_200E_200D_202B_206F_200D_200E_200E_202D_200E_200C_200D_200D_200F_200F_206E_200E_202E((Object)(object)val);
					_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 1;
					num2 = -2025314051;
					continue;
				}
				case 3u:
					return true;
				case 2u:
					_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E = _200B_200F_202C_206A_202B_200C_200F_206C_202B_206D_200C_202D_200D_200F_202E_206F_206C_202A_200B_202E_200F_200F_202C_206F_206C_202E_202A_200C_206B_202D_200F_202C_200B_206D_200F_200C_200F_202B_202E_200C_202E(path);
					_200D_206A_202C_200E_206F_206B_202A_202D_200D_200E_202B_202A_206E_206E_202E_206B_200E_200F_202C_202D_202A_206C_202C_202A_200E_200C_206B_206B_206C_200D_206B_202A_202A_202D_200B_206E_206F_200F_202A_206A_202E = 0;
					num2 = ((int)num3 * -1909903360) ^ 0x38F39A8B;
					continue;
				case 11u:
					_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E = null;
					num2 = ((int)num3 * -2040390642) ^ 0x32B17609;
					continue;
				case 10u:
					goto IL_011d;
				case 0u:
					_200D_206A_202C_200E_206F_206B_202A_202D_200D_200E_202B_202A_206E_206E_202E_206B_200E_200F_202C_202D_202A_206C_202C_202A_200E_200C_206B_206B_206C_200D_206B_202A_202A_202D_200B_206E_206F_200F_202A_206A_202E++;
					num2 = (int)(num3 * 518918174) ^ -374611869;
					continue;
				case 1u:
					goto IL_014e;
				default:
					return false;
				}
				break;
				IL_014e:
				int num6;
				if (_200D_206A_202C_200E_206F_206B_202A_202D_200D_200E_202B_202A_206E_206E_202E_206B_200E_200F_202C_202D_202A_206C_202C_202A_200E_200C_206B_206B_206C_200D_206B_202A_202A_202D_200B_206E_206F_200F_202A_206A_202E >= _206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E.Length)
				{
					num2 = -53318339;
					num6 = num2;
				}
				else
				{
					num2 = -1194120644;
					num6 = num2;
				}
			}
			goto IL_000d;
			IL_011d:
			_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
			num2 = -964003800;
			goto IL_0012;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw _206E_202C_202B_200B_206E_206B_200E_202C_200B_200F_206A_202D_200E_200C_202E_206A_200E_206A_206E_200C_200D_206F_206B_202B_200C_206D_200C_202B_200D_206D_206C_206B_202B_200C_200B_206B_206B_202D_206E_200F_202E();
		}

		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			if (_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E == -2)
			{
				goto IL_000a;
			}
			goto IL_0089;
			IL_000a:
			int num = -2132567133;
			goto IL_000f;
			IL_000f:
			_200E_202C_200E_202A_202C_202E_200F_202A_206D_202D_206E_202D_206A_206D_206C_202E_202E_200D_200C_202A_202E_202C_202C_202B_202D_206E_200C_200B_202E_200E_206D_200F_202D_206C_200C_206C_206E_206E_202B_206A_202E obj = default(_200E_202C_200E_202A_202C_202E_200F_202A_206D_202D_206E_202D_206A_206D_206C_202E_202E_200D_200C_202A_202E_202C_202C_202B_202D_206E_200C_200B_202E_200E_206D_200F_202D_206C_200C_206C_206E_206E_202B_206A_202E);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1602449473)) % 7)
				{
				case 0u:
					break;
				case 5u:
					num = ((int)num2 * -437752806) ^ -1134481723;
					continue;
				case 6u:
					obj.path = _206F_200B_206B_200D_206B_200D_206D_200C_202A_202B_200E_200F_206E_206E_206E_206E_202A_200F_200C_202B_200E_206D_206C_206F_202B_200E_200C_200F_200B_206D_202E_206D_206D_202A_202D_206F_202D_202A_202B_202D_202E;
					num = -1047092578;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (_200B_202B_206E_200C_202C_200D_206F_202E_200F_206A_200C_202C_200B_202D_200F_206E_202D_206C_200B_202C_206C_206A_206E_206C_202B_206D_206E_200E_206E_202D_206E_202E_202E_202A_206D_206E_206D_202C_202D_202E == _202C_200F_200C_202D_200D_206B_200B_200B_206E_200F_206E_206D_202A_202B_202B_200E_206A_200E_206D_206D_200C_200C_206C_200E_200B_206C_200E_202A_202A_200D_200E_206E_202E_206C_206A_200B_202C_206A_206B_206C_202E(_200B_206C_206A_202D_202C_200C_206C_200D_202C_200E_202C_200B_200D_206F_206A_202C_200B_200C_202E_206A_202C_206B_206E_200E_200C_206C_200F_200C_206C_200F_202A_202C_202A_206D_206B_200F_206E_202D_200D_206E_202E()))
					{
						num3 = -1389200403;
						num4 = num3;
					}
					else
					{
						num3 = -926103921;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -428047171);
					continue;
				}
				case 2u:
					goto IL_0089;
				case 4u:
					_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 0;
					obj = this;
					num = ((int)num2 * -1282462383) ^ -1686160613;
					continue;
				default:
					return obj;
				}
				break;
			}
			goto IL_000a;
			IL_0089:
			obj = new _200E_202C_200E_202A_202C_202E_200F_202A_206D_202D_206E_202D_206A_206D_206C_202E_202E_200D_200C_202A_202E_202C_202C_202B_202D_206E_200C_200B_202E_200E_206D_200F_202D_206C_200C_206C_206E_206E_202B_206A_202E(0);
			num = -865434719;
			goto IL_000f;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<string>)this).GetEnumerator();
		}

		static Thread _200B_206C_206A_202D_202C_200C_206C_200D_202C_200E_202C_200B_200D_206F_206A_202C_200B_200C_202E_206A_202C_206B_206E_200E_200C_206C_200F_200C_206C_200F_202A_202C_202A_206D_206B_200F_206E_202D_200D_206E_202E()
		{
			return Thread.CurrentThread;
		}

		static int _202C_200F_200C_202D_200D_206B_200B_200B_206E_200F_206E_206D_202A_202B_202B_200E_206A_200E_206D_206D_200C_200C_206C_200E_200B_206C_200E_202A_202A_200D_200E_206E_202E_206C_206A_200B_202C_206A_206B_206C_202E(Thread P_0)
		{
			return P_0.ManagedThreadId;
		}

		static Object[] _200B_200F_202C_206A_202B_200C_200F_206C_202B_206D_200C_202D_200D_200F_202E_206F_206C_202A_200B_202E_200F_200F_202C_206F_206C_202E_202A_200C_206B_202D_200F_202C_200B_206D_200F_200C_200F_202B_202E_200C_202E(string P_0)
		{
			return Resources.LoadAll(P_0);
		}

		static string _206E_206B_202A_200F_206F_200B_200C_206D_202D_202C_200E_206C_206A_206B_202E_206B_202D_202B_200E_200F_200E_202E_202D_202C_200E_200D_202B_206F_200D_200E_200E_202D_200E_200C_200D_200D_200F_200F_206E_200E_202E(Object P_0)
		{
			return P_0.name;
		}

		static NotSupportedException _206E_202C_202B_200B_206E_206B_200E_202C_200B_200F_206A_202D_200E_200C_202E_206A_200E_206A_206E_200C_200D_206F_206B_202B_200C_206D_200C_202B_200D_206D_206C_206B_202B_200C_200B_206B_206B_202D_206E_200F_202E()
		{
			return new NotSupportedException();
		}
	}

	[XmlAttribute("key")]
	public string Key;

	[XmlAttribute("value")]
	public string Value;

	[XmlAttribute("icon")]
	public string Icon;

	public override string PK => Key;

	static Resource()
	{
	}

	public static Sprite GetZhujueHead()
	{
		return GetHeadImage(RuntimeData.Instance.Team[0].Head, forceLoadFromResource: false);
	}

	public static Sprite GetIcon(string iconName)
	{
		if (_206E_202B_202C_206F_200B_206D_206A_202C_206C_202A_200C_206F_202C_206F_206A_206D_206F_202E_202D_200F_206E_202B_200C_200E_202B_202E_206E_200D_206F_206A_202E_200E_200F_202B_200E_206C_206F_206C_206B_206C_202E(iconName, ResourceStrings.ResStrings[1104]))
		{
			goto IL_0017;
		}
		goto IL_007b;
		IL_0017:
		int num = 1854881515;
		goto IL_001c;
		IL_001c:
		Sprite val = default(Sprite);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x5D5AB6DB)) % 10)
			{
			case 6u:
				break;
			case 4u:
			{
				int num5;
				int num6;
				if (!_206F_206A_202E_202E_206A_200E_206D_206C_202A_202E_202D_200F_206A_202D_202B_202B_202B_206B_206B_200E_206A_200B_206D_200C_200E_202C_206E_200F_200F_206C_200C_206B_200F_200F_202D_206B_200D_202D_202C_206D_202E((Object)(object)val, (Object)null))
				{
					num5 = 1754194004;
					num6 = num5;
				}
				else
				{
					num5 = 802527560;
					num6 = num5;
				}
				num = num5 ^ (int)(num2 * 1161046284);
				continue;
			}
			case 3u:
				goto IL_007b;
			case 2u:
				val = ModEditorResourceManager.GetSprite(_202A_202C_200B_206F_200D_202A_200C_206F_200F_200D_202A_206B_202D_202A_200E_206F_200C_202A_200C_202D_206F_202D_200B_206F_200F_200D_206B_200C_206D_206A_200E_200C_200D_206F_206F_200D_206C_202B_206B_202A_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(355047404u), iconName));
				num = (int)(num2 * 471723930) ^ -2022668899;
				continue;
			case 5u:
				val = Resources.Load<Sprite>(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(392782897u));
				num = ((int)num2 * -1554534223) ^ -1016028494;
				continue;
			case 8u:
				return GetImage(iconName, forceLoadFromResource: false);
			case 1u:
			{
				int num3;
				int num4;
				if (CommonSettings.MOD_KEY() < 0)
				{
					num3 = -541262275;
					num4 = num3;
				}
				else
				{
					num3 = -1603944766;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 860049569);
				continue;
			}
			case 9u:
				goto IL_010c;
			case 7u:
				return val;
			default:
				return val;
			}
			break;
			IL_010c:
			val = Resources.Load<Sprite>(_202A_202C_200B_206F_200D_202A_200C_206F_200F_200D_202A_206B_202D_202A_200E_206F_200C_202A_200C_202D_206F_202D_200B_206F_200F_200D_206B_200C_206D_206A_200E_200C_200D_206F_206F_200D_206C_202B_206B_202A_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3150437624u), iconName));
			int num7;
			if (_206D_206F_202B_202C_206A_200B_206A_206D_206D_202C_206F_202D_202C_202E_206F_202C_202C_202D_206D_206A_200C_206C_206C_206E_206D_206C_200F_202E_202D_202A_200D_200F_200E_202B_200B_200C_200D_200D_202A_202E((Object)(object)val, (Object)null))
			{
				num = 1273562026;
				num7 = num;
			}
			else
			{
				num = 404062611;
				num7 = num;
			}
		}
		goto IL_0017;
		IL_007b:
		val = null;
		num = 879246234;
		goto IL_001c;
	}

	public static Sprite GetBattleBg(string key)
	{
		Sprite val = null;
		if (CommonSettings.MOD_KEY() >= 0)
		{
			goto IL_000a;
		}
		goto IL_0043;
		IL_000a:
		int num = -142252196;
		goto IL_000f;
		IL_000f:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1626039632)) % 8)
			{
			case 3u:
				break;
			case 5u:
				goto IL_0043;
			case 6u:
			{
				int num5;
				int num6;
				if (_206F_206A_202E_202E_206A_200E_206D_206C_202A_202E_202D_200F_206A_202D_202B_202B_202B_206B_206B_200E_206A_200B_206D_200C_200E_202C_206E_200F_200F_206C_200C_206B_200F_200F_202D_206B_200D_202D_202C_206D_202E((Object)(object)val, (Object)null))
				{
					num5 = -1622063404;
					num6 = num5;
				}
				else
				{
					num5 = -519458911;
					num6 = num5;
				}
				num = num5 ^ ((int)num2 * -681504494);
				continue;
			}
			case 1u:
				val = AssetBundleManager.GetBattleBg(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(430324575u));
				num = (int)(num2 * 682121663) ^ -220488251;
				continue;
			case 7u:
			{
				int num3;
				int num4;
				if (!_206D_206F_202B_202C_206A_200B_206A_206D_206D_202C_206F_202D_202C_202E_206F_202C_202C_202D_206D_206A_200C_206C_206C_206E_206D_206C_200F_202E_202D_202A_200D_200F_200E_202B_200B_200C_200D_200D_202A_202E((Object)(object)val, (Object)null))
				{
					num3 = 2034951418;
					num4 = num3;
				}
				else
				{
					num3 = 417587249;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 1241288968);
				continue;
			}
			case 0u:
				return val;
			case 4u:
				val = ModEditorResourceManager.GetSprite(_202A_202C_200B_206F_200D_202A_200C_206F_200F_200D_202A_206B_202D_202A_200E_206F_200C_202A_200C_202D_206F_202D_200B_206F_200F_200D_206B_200C_206D_206A_200E_200C_200D_206F_206F_200D_206C_202B_206B_202A_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2709717042u), key));
				num = (int)((num2 * 1293056760) ^ 0x17A5C39E);
				continue;
			default:
				return val;
			}
			break;
		}
		goto IL_000a;
		IL_0043:
		val = AssetBundleManager.GetBattleBg(key);
		num = -550214985;
		goto IL_000f;
	}

	public static Sprite GetImage(string key, bool forceLoadFromResource)
	{
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		Resource resource = ResourceManager.Get<Resource>(key);
		if (resource == null)
		{
			goto IL_000d;
		}
		goto IL_00a2;
		IL_000d:
		int num = 151159390;
		goto IL_0012;
		IL_0012:
		Sprite val = default(Sprite);
		string text = default(string);
		bool flag = default(bool);
		int num3 = default(int);
		Texture2D val2 = default(Texture2D);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x3B7A15F8)) % 24)
			{
			case 18u:
				break;
			case 23u:
				val = ModEditorResourceManager.GetSprite(text);
				num = (int)((num2 * 310774257) ^ 0x7AF7092E);
				continue;
			case 3u:
				goto IL_00a2;
			case 20u:
			{
				int num14;
				int num15;
				if (!flag)
				{
					num14 = -905449357;
					num15 = num14;
				}
				else
				{
					num14 = -761161373;
					num15 = num14;
				}
				num = num14 ^ ((int)num2 * -1120295256);
				continue;
			}
			case 19u:
				val = Resources.Load<Sprite>(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3075409523u));
				num = ((int)num2 * -1891158946) ^ 0x4CE55A87;
				continue;
			case 4u:
				text = text.Substring(num3 + 1, text.Length - num3 - 1);
				num = (int)((num2 * 1916990726) ^ 0x69995136);
				continue;
			case 0u:
			{
				int num12;
				int num13;
				if (CommonSettings.MOD_KEY() >= 0)
				{
					num12 = -1691823064;
					num13 = num12;
				}
				else
				{
					num12 = -762649894;
					num13 = num12;
				}
				num = num12 ^ ((int)num2 * -613685733);
				continue;
			}
			case 12u:
				val = null;
				num = (int)((num2 * 1625289163) ^ 0x3D34856C);
				continue;
			case 7u:
				return val;
			case 6u:
				goto IL_017b;
			case 2u:
				goto IL_019b;
			case 5u:
			{
				int num6;
				int num7;
				if (num3 == -1)
				{
					num6 = -815164879;
					num7 = num6;
				}
				else
				{
					num6 = -1572210853;
					num7 = num6;
				}
				num = num6 ^ (int)(num2 * 1985917083);
				continue;
			}
			case 21u:
			{
				int num10;
				int num11;
				if (!((Object)(object)val == (Object)null))
				{
					num10 = 1312242429;
					num11 = num10;
				}
				else
				{
					num10 = 638992990;
					num11 = num10;
				}
				num = num10 ^ ((int)num2 * -1286406310);
				continue;
			}
			case 1u:
			{
				int num8;
				int num9;
				if ((Object)(object)val != (Object)null)
				{
					num8 = 808762265;
					num9 = num8;
				}
				else
				{
					num8 = 430511236;
					num9 = num8;
				}
				num = num8 ^ (int)(num2 * 52616390);
				continue;
			}
			case 8u:
			{
				int num4;
				int num5;
				if (!forceLoadFromResource)
				{
					num4 = -1122567497;
					num5 = num4;
				}
				else
				{
					num4 = -796832886;
					num5 = num4;
				}
				num = num4 ^ (int)(num2 * 746774129);
				continue;
			}
			case 22u:
				val2 = _202C_206D_206E_202D_202D_200C_206A_206F_200C_206D_200F_206F_202B_206A_202E_200F_200F_206B_202B_200F_202A_202B_200F_206B_202B_206F_202A_202D_206F_206D_200F_206F_206E_200F_200D_202E_200F_202D_200D_206A_202E(1, 1);
				_202B_200D_202C_206B_202B_202E_202D_202A_206F_202D_200E_202B_200D_200D_200C_202B_200E_202B_202D_202E_200D_200E_200E_206A_200F_200C_206A_200E_200F_206E_200C_200F_206F_206D_200B_206B_206B_200B_200B_206D_202E(val2, 0, 0, Color.white);
				num = ((int)num2 * -688678063) ^ -1118930225;
				continue;
			case 10u:
				return val;
			case 16u:
				val = Resources.Load<Sprite>(text);
				num = 1001854861;
				continue;
			case 9u:
				return Sprite.Create(val2, new Rect(0f, 0f, (float)_206E_206E_206C_200C_200B_206A_200E_206D_206D_206C_200C_206B_200D_206B_206C_206F_200E_202B_202C_202B_206E_206E_200B_200C_200F_206A_202A_206A_206A_202D_206B_202D_206D_202E_202A_200E_202E_200C_206C_202D_202E((Texture)(object)val2), (float)_206B_206A_202B_206B_202D_200B_202B_202C_206C_202A_202B_202D_202B_202A_200C_206F_200D_200E_206C_206A_200C_206A_206F_202A_206E_206C_206B_200F_202A_200D_202B_200D_200B_200C_202C_206D_206B_206D_206E_200D_202E((Texture)(object)val2)), new Vector2(0.5f, 0.5f));
			case 17u:
				num3 = text.LastIndexOf('/');
				num = (int)(num2 * 877917664) ^ -1298880635;
				continue;
			case 11u:
				val = Resources.Load<Sprite>(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2721747649u));
				num = 1539855071;
				continue;
			case 13u:
				num = (int)((num2 * 35152801) ^ 0x53E0C42A);
				continue;
			case 14u:
				goto IL_0339;
			default:
				return val;
			}
			break;
			IL_0339:
			val = AssetBundleManager.GetMap(text);
			int num16;
			if (!((Object)(object)val != (Object)null))
			{
				num = 1852853712;
				num16 = num;
			}
			else
			{
				num = 340160938;
				num16 = num;
			}
			continue;
			IL_019b:
			flag = key.StartsWith(ResourceStrings.ResStrings[1105]);
			int num17;
			if (flag)
			{
				num = 1178013553;
				num17 = num;
			}
			else
			{
				num = 1852853712;
				num17 = num;
			}
		}
		goto IL_000d;
		IL_00a2:
		num3 = resource.Value.LastIndexOf('.');
		if (num3 == -1)
		{
			num = 336130750;
			goto IL_0012;
		}
		string text2 = resource.Value.Substring(0, num3);
		goto IL_0190;
		IL_017b:
		text2 = resource.Value;
		goto IL_0190;
		IL_0190:
		text = text2;
		num = 2066753388;
		goto IL_0012;
	}

	[DebuggerHidden]
	private IEnumerator LoadTextureFromURL(string url, Action<Texture2D> cb)
	{
		_202B_200E_206E_206A_200F_200F_206A_206E_206A_200B_206E_202D_200D_202B_200B_206E_206D_202B_202D_206C_200B_206B_202C_200B_206C_202B_206B_200B_200F_206F_200B_206D_206E_200B_206C_200C_200F_206E_200F_200D_202E obj = new _202B_200E_206E_206A_200F_200F_206A_206E_206A_200B_206E_202D_200D_202B_200B_206E_206D_202B_202D_206C_200B_206B_202C_200B_206C_202B_206B_200B_200F_206F_200B_206D_206E_200B_206C_200C_200F_206E_200F_200D_202E();
		obj.url = url;
		obj.cb = cb;
		obj._206F_202E_202B_206E_202C_202E_202A_202E_206B_202B_202B_206D_200B_206D_206D_206F_200C_206A_200E_200D_206A_202A_206E_202C_206F_206C_202B_200F_200D_206E_206B_206B_200C_200C_200D_206C_202E_206D_202D_200E_202E = url;
		while (true)
		{
			int num = -75966515;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -977231790)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_003d;
				default:
					return obj;
				}
				break;
				IL_003d:
				obj._200B_202B_206C_206C_200D_200B_200B_202C_202D_202B_206B_206A_202A_200C_202B_202D_206D_206E_200C_206C_206B_200C_200C_202E_202C_200B_200C_206E_202C_200E_200C_202E_200E_202D_202C_202D_202E_200B_202C_200F_202E = cb;
				num = ((int)num2 * -908851777) ^ -1849525776;
			}
		}
	}

	public static void GetMusic(string key, Action<AudioClip> callback)
	{
		Resource resource = default(Resource);
		string url = default(string);
		Action<AudioClip> callback2 = default(Action<AudioClip>);
		string text2 = default(string);
		while (true)
		{
			int num = 1537052515;
			while (true)
			{
				uint num2;
				string text3;
				string text;
				int num7;
				switch ((num2 = (uint)(num ^ 0x46C627A6)) % 14)
				{
				case 0u:
					break;
				default:
					return;
				case 4u:
					num7 = _200E_206D_200E_206B_206E_200D_202A_200B_206A_200D_200D_206B_202C_206A_200E_206D_200F_202D_202E_200B_202B_200D_200F_200D_206E_206A_202D_206E_206C_200D_200B_200D_206E_202B_206A_200C_206E_200D_206D_202E_202E(resource.Value, '.');
					if (num7 == -1)
					{
						num = 1741225333;
						continue;
					}
					text3 = _206D_200E_202D_206F_200B_202E_200D_200D_202C_206A_202D_202E_206E_206E_200B_202E_202B_206B_206E_200D_202D_202D_206D_206F_202C_202E_206A_202B_206C_200B_206A_200D_206F_206B_202A_202A_202B_202B_202A_206F_202E(resource.Value, 0, num7);
					goto IL_0158;
				case 13u:
				{
					AudioClip audio = AssetBundleManager.GetAudio(url);
					callback2(audio);
					num = 874230023;
					continue;
				}
				case 10u:
				{
					int num5;
					int num6;
					if (CommonSettings.MOD_KEY() < 0)
					{
						num5 = 1582499221;
						num6 = num5;
					}
					else
					{
						num5 = 2021448338;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 376874409);
					continue;
				}
				case 11u:
					return;
				case 5u:
				{
					resource = ResourceManager.Get<Resource>(key);
					int num8;
					int num9;
					if (resource == null)
					{
						num8 = -579971159;
						num9 = num8;
					}
					else
					{
						num8 = -508115030;
						num9 = num8;
					}
					num = num8 ^ ((int)num2 * -1494671350);
					continue;
				}
				case 8u:
					ModEditorResourceManager.GetAudioClip(text2, delegate(AudioClip P_0)
					{
						callback2(P_0);
					});
					return;
				case 7u:
					_206E_206A_202E_206A_202D_200B_206A_206D_200F_202B_200B_200F_202E_206D_200B_200F_206F_206F_200E_206D_200E_206F_200B_200F_200B_206F_200B_200C_206A_206A_202B_202C_206F_206B_202A_206C_206F_206C_200B_202D_202E((object)_202A_202C_200B_206F_200D_202A_200C_206F_200F_200D_202A_206B_202D_202A_200E_206F_200C_202A_200C_202D_206F_202D_200B_206F_200F_200D_206B_200C_206D_206A_200E_200C_200D_206F_206F_200D_206C_202B_206B_202A_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2916440845u), key));
					num = (int)((num2 * 1766857291) ^ 0xB655255);
					continue;
				case 3u:
					text3 = resource.Value;
					goto IL_0158;
				case 6u:
				{
					int num3;
					int num4;
					if (ModEditorResourceManager.audios.ContainsKey(text2))
					{
						num3 = -1633322386;
						num4 = num3;
					}
					else
					{
						num3 = -1702731959;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -2133357765);
					continue;
				}
				case 12u:
					callback2(null);
					num = ((int)num2 * -2140517629) ^ -393715401;
					continue;
				case 9u:
					callback2 = callback;
					num = ((int)num2 * -1426599361) ^ 0x46EF69A0;
					continue;
				case 2u:
					text = text2;
					goto IL_01e9;
				case 1u:
					return;
					IL_0158:
					text2 = text3;
					num7 = _200E_206D_200E_206B_206E_200D_202A_200B_206A_200D_200D_206B_202C_206A_200E_206D_200F_202D_202E_200B_202B_200D_200F_200D_206E_206A_202D_206E_206C_200D_200B_200D_206E_202B_206A_200C_206E_200D_206D_202E_202E(text2, '/');
					if (num7 == -1)
					{
						num = 873641852;
						continue;
					}
					text = _206D_200E_202D_206F_200B_202E_200D_200D_202C_206A_202D_202E_206E_206E_200B_202E_202B_206B_206E_200D_202D_202D_206D_206F_202C_202E_206A_202B_206C_200B_206A_200D_206F_206B_202A_202A_202B_202B_202A_206F_202E(text2, num7 + 1, _200D_202A_200D_202A_200E_202A_206D_200F_200C_202B_200E_200D_202C_200C_206F_202B_206C_202C_200B_200E_202E_206C_206D_200C_202B_200F_202D_206F_200C_200C_200C_200F_206B_202A_206A_206D_206E_206E_200E_206A_202E(text2) - num7 - 1);
					goto IL_01e9;
					IL_01e9:
					url = text;
					num = 1867087190;
					continue;
				}
				break;
			}
		}
	}

	public static string GetLiezhuan(Role role)
	{
		if (_206D_200B_202D_206F_206A_200B_202B_200D_206F_200B_200D_200C_202B_202A_200B_206F_200C_200E_200C_202B_202A_206E_202C_200F_200F_206A_202D_206E_206A_202D_200D_202C_202A_200B_200B_202D_202B_200D_206F_206B_202E(role.Key, ResourceStrings.ResStrings[0]))
		{
			goto IL_0018;
		}
		goto IL_0089;
		IL_0018:
		int num = 391251976;
		goto IL_001d;
		IL_001d:
		Resource resource = default(Resource);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x2A83CDF1)) % 10)
			{
			case 2u:
				break;
			case 0u:
				resource = ResourceManager.Get<Resource>(_202A_202C_200B_206F_200D_202A_200C_206F_200F_200D_202A_206B_202D_202A_200E_206F_200C_202A_200C_202D_206F_202D_200B_206F_200F_200D_206B_200C_206D_206A_200E_200C_200D_206F_206F_200D_206C_202B_206B_202A_202E(ResourceStrings.ResStrings[1108], role.Key));
				num = (int)(num2 * 1686952562) ^ -1067156896;
				continue;
			case 4u:
				goto IL_0089;
			case 8u:
				goto IL_00b6;
			case 3u:
				resource = ResourceManager.Get<Resource>(_202A_202C_200B_206F_200D_202A_200C_206F_200F_200D_202A_206B_202D_202A_200E_206F_200C_202A_200C_202D_206F_202D_200B_206F_200F_200D_206B_200C_206D_206A_200E_200C_200D_206F_206F_200D_206C_202B_206B_202A_202E(ResourceStrings.ResStrings[1108], ResourceStrings.ResStrings[9]));
				num = (int)((num2 * 1067880006) ^ 0x82F8810);
				continue;
			case 9u:
				return null;
			case 1u:
				resource = ResourceManager.Get<Resource>(_202A_202C_200B_206F_200D_202A_200C_206F_200F_200D_202A_206B_202D_202A_200E_206F_200C_202A_200C_202D_206F_202D_200B_206F_200F_200D_206B_200C_206D_206A_200E_200C_200D_206F_206F_200D_206C_202B_206B_202A_202E(ResourceStrings.ResStrings[1108], ResourceStrings.ResStrings[0]));
				num = (int)(num2 * 1306599079) ^ -427640289;
				continue;
			case 5u:
				goto IL_0170;
			case 7u:
				num = ((int)num2 * -151645294) ^ 0x1771C6DE;
				continue;
			default:
				return resource.Value;
			}
			break;
			IL_0170:
			int num3;
			if (resource == null)
			{
				num = 386892754;
				num3 = num;
			}
			else
			{
				num = 1453766147;
				num3 = num;
			}
			continue;
			IL_00b6:
			resource = ResourceManager.Get<Resource>(_202A_202C_200B_206F_200D_202A_200C_206F_200F_200D_202A_206B_202D_202A_200E_206F_200C_202A_200C_202D_206F_202D_200B_206F_200F_200D_206B_200C_206D_206A_200E_200C_200D_206F_206F_200D_206C_202B_206B_202A_202E(ResourceStrings.ResStrings[1108], role.Name));
			int num4;
			if (resource != null)
			{
				num = 728164720;
				num4 = num;
			}
			else
			{
				num = 1124290617;
				num4 = num;
			}
		}
		goto IL_0018;
		IL_0089:
		int num5;
		if (!_206D_200B_202D_206F_206A_200B_202B_200D_206F_200B_200D_200C_202B_202A_200B_206F_200C_200E_200C_202B_202A_206E_202C_200F_200F_206A_202D_206E_206A_202D_200D_202C_202A_200B_200B_202D_202B_200D_206F_206B_202E(role.Key, ResourceStrings.ResStrings[9]))
		{
			num = 403535267;
			num5 = num;
		}
		else
		{
			num = 914635332;
			num5 = num;
		}
		goto IL_001d;
	}

	public static string GetTalentDesc(string talent)
	{
		Resource resource = ResourceManager.Get<Resource>(_202A_202C_200B_206F_200D_202A_200C_206F_200F_200D_202A_206B_202D_202A_200E_206F_200C_202A_200C_202D_206F_202D_200B_206F_200F_200D_206B_200C_206D_206A_200E_200C_200D_206F_206F_200D_206C_202B_206B_202A_202E(ResourceStrings.ResStrings[1107], talent));
		int num3 = default(int);
		while (true)
		{
			int num = -1605501956;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1727354069)) % 6)
				{
				case 4u:
					break;
				case 3u:
				{
					int num5;
					int num6;
					if (resource == null)
					{
						num5 = 1371717877;
						num6 = num5;
					}
					else
					{
						num5 = 1043980627;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1958250515);
					continue;
				}
				case 5u:
					return string.Empty;
				case 0u:
					return _206D_200E_202D_206F_200B_202E_200D_200D_202C_206A_202D_202E_206E_206E_200B_202E_202B_206B_206E_200D_202D_202D_206D_206F_202C_202E_206A_202B_206C_200B_206A_200D_206F_206B_202A_202A_202B_202B_202A_206F_202E(resource.Value, num3 + 1, _200D_202A_200D_202A_200E_202A_206D_200F_200C_202B_200E_200D_202C_200C_206F_202B_206C_202C_200B_200E_202E_206C_206D_200C_202B_200F_202D_206F_200C_200C_200C_200F_206B_202A_206A_206D_206E_206E_200E_206A_202E(resource.Value) - num3 - 1);
				case 1u:
				{
					num3 = _206D_202D_200C_202B_202D_206E_206C_206E_202D_200D_202B_202E_200C_200C_200C_206F_202E_202E_206E_202C_202B_206D_202B_206E_202B_206E_202C_206F_202B_206A_200C_206D_206B_200C_202C_206E_202E_202C_202A_200D_202E(resource.Value, '#');
					int num4;
					if (num3 == -1)
					{
						num = -1312151817;
						num4 = num;
					}
					else
					{
						num = -1312155591;
						num4 = num;
					}
					continue;
				}
				default:
					return string.Empty;
				}
				break;
			}
		}
	}

	public static int GetTalentCost(string talent)
	{
		Resource resource = ResourceManager.Get<Resource>(_202A_202C_200B_206F_200D_202A_200C_206F_200F_200D_202A_206B_202D_202A_200E_206F_200C_202A_200C_202D_206F_202D_200B_206F_200F_200D_206B_200C_206D_206A_200E_200C_200D_206F_206F_200D_206C_202B_206B_202A_202E(ResourceStrings.ResStrings[1107], talent));
		int num3 = default(int);
		while (true)
		{
			int num = 1023227726;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2230AF55)) % 6)
				{
				case 0u:
					break;
				case 3u:
				{
					int num5;
					int num6;
					if (resource != null)
					{
						num5 = -1402844003;
						num6 = num5;
					}
					else
					{
						num5 = -108458264;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1648354849);
					continue;
				}
				case 2u:
					return 0;
				case 5u:
				{
					num3 = _206D_202D_200C_202B_202D_206E_206C_206E_202D_200D_202B_202E_200C_200C_200C_206F_202E_202E_206E_202C_202B_206D_202B_206E_202B_206E_202C_206F_202B_206A_200C_206D_206B_200C_202C_206E_202E_202C_202A_200D_202E(resource.Value, '#');
					int num4;
					if (num3 != -1)
					{
						num = 2131590535;
						num4 = num;
					}
					else
					{
						num = 1506109110;
						num4 = num;
					}
					continue;
				}
				case 4u:
					return int.Parse(_206D_200E_202D_206F_200B_202E_200D_200D_202C_206A_202D_202E_206E_206E_200B_202E_202B_206B_206E_200D_202D_202D_206D_206F_202C_202E_206A_202B_206C_200B_206A_200D_206F_206B_202A_202A_202B_202B_202A_206F_202E(resource.Value, 0, num3));
				default:
					return 0;
				}
				break;
			}
		}
	}

	public static byte[] GetBytes(string path, bool loadFromAssetBundle = true)
	{
		if (loadFromAssetBundle)
		{
			while (true)
			{
				uint num;
				switch ((num = 246737882u) % 3)
				{
				case 0u:
					continue;
				case 2u:
					return null;
				}
				break;
			}
		}
		return _206D_202A_202E_202A_206F_206B_202B_202A_206A_206B_202B_200D_206C_200E_200F_200B_200B_202B_202A_202D_200F_202E_202D_200F_206E_206A_202A_206B_200E_202B_206B_206E_206C_200C_206E_206A_206E_206E_200E_202D_202E(Resources.Load<TextAsset>(path));
	}

	public static string GetTalentInfo(string name, bool displayCost = true)
	{
		string talentDesc = GetTalentDesc(name);
		while (true)
		{
			int num = -68278192;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)(num ^ -831082786)) % 4)
				{
				case 3u:
					break;
				case 2u:
				{
					int num4;
					if (!displayCost)
					{
						num3 = 868856124;
						num4 = num3;
					}
					else
					{
						num3 = 1769122325;
						num4 = num3;
					}
					goto IL_003e;
				}
				case 1u:
					return _202D_202C_200E_206B_206F_202E_206C_202A_206F_200E_202A_206A_202A_200E_206D_206B_206A_202E_200E_200C_206D_206D_202E_206A_206F_200C_206B_202B_206B_202D_206B_202A_202E_206F_200F_200C_200B_202D_200E_200F_202E(ResourceStrings.ResStrings[388], (object)name, (object)GetTalentCost(name), (object)talentDesc);
				default:
					return _202C_206B_200F_206E_200C_200C_206E_202C_206D_206A_200C_202E_202C_200C_202C_202A_200E_202A_200D_202A_206E_200E_200F_206F_206D_206B_202D_206B_200C_206A_206F_200B_200D_202D_200C_200C_202A_200C_200C_200E_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3552122978u), (object)name, (object)talentDesc);
				}
				break;
				IL_003e:
				num = num3 ^ (int)(num2 * 945189623);
			}
		}
	}

	public static Sprite GetHeadImage(string key, bool forceLoadFromResource)
	{
		Resource resource = ResourceManager.Get<Resource>(key);
		Sprite val = default(Sprite);
		string text2 = default(string);
		while (true)
		{
			int num = -1116587899;
			while (true)
			{
				uint num2;
				string text;
				int num9;
				switch ((num2 = (uint)(num ^ -2146952301)) % 14)
				{
				case 4u:
					break;
				case 1u:
					val = ModEditorResourceManager.LoadHeadSprite(ModEditorResourceManager.sprites[text2]);
					num = (int)(num2 * 2035822142) ^ -200784696;
					continue;
				case 0u:
				{
					val = Resources.Load<Sprite>(text2);
					int num8;
					if (_206D_206F_202B_202C_206A_200B_206A_206D_206D_202C_206F_202D_202C_202E_206F_202C_202C_202D_206D_206A_200C_206C_206C_206E_206D_206C_200F_202E_202D_202A_200D_200F_200E_202B_200B_200C_200D_200D_202A_202E((Object)(object)val, (Object)null))
					{
						num = -1355965696;
						num8 = num;
					}
					else
					{
						num = -743037840;
						num8 = num;
					}
					continue;
				}
				case 7u:
					return val;
				case 13u:
				{
					int num10;
					int num11;
					if (!_206F_206A_202E_202E_206A_200E_206D_206C_202A_202E_202D_200F_206A_202D_202B_202B_202B_206B_206B_200E_206A_200B_206D_200C_200E_202C_206E_200F_200F_206C_200C_206B_200F_200F_202D_206B_200D_202D_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num10 = -1612034168;
						num11 = num10;
					}
					else
					{
						num10 = -2127037803;
						num11 = num10;
					}
					num = num10 ^ (int)(num2 * 629094957);
					continue;
				}
				case 5u:
					return Resources.Load<Sprite>(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(564295927u));
				case 9u:
				{
					int num5 = _200E_206D_200E_206B_206E_200D_202A_200B_206A_200D_200D_206B_202C_206A_200E_206D_200F_202D_202E_200B_202B_200D_200F_200D_206E_206A_202D_206E_206C_200D_200B_200D_206E_202B_206A_200C_206E_200D_206D_202E_202E(resource.Value, '.');
					if (num5 == -1)
					{
						num = -1663552721;
						continue;
					}
					text = _206D_200E_202D_206F_200B_202E_200D_200D_202C_206A_202D_202E_206E_206E_200B_202E_202B_206B_206E_200D_202D_202D_206D_206F_202C_202E_206A_202B_206C_200B_206A_200D_206F_206B_202A_202A_202B_202B_202A_206F_202E(resource.Value, 0, num5);
					goto IL_01be;
				}
				case 6u:
				{
					int num12;
					int num13;
					if (forceLoadFromResource)
					{
						num12 = -1015025007;
						num13 = num12;
					}
					else
					{
						num12 = -41717347;
						num13 = num12;
					}
					num = num12 ^ (int)(num2 * 681954968);
					continue;
				}
				case 12u:
				{
					int num6;
					int num7;
					if (resource != null)
					{
						num6 = -2142121830;
						num7 = num6;
					}
					else
					{
						num6 = -1436785753;
						num7 = num6;
					}
					num = num6 ^ (int)(num2 * 825715333);
					continue;
				}
				case 3u:
					val = Resources.Load<Sprite>(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3421386793u));
					num = ((int)num2 * -3986334) ^ 0x8DB5836;
					continue;
				case 10u:
				{
					int num3;
					int num4;
					if (!ModEditorResourceManager.sprites.ContainsKey(text2))
					{
						num3 = 973294773;
						num4 = num3;
					}
					else
					{
						num3 = 545216346;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 613633582);
					continue;
				}
				case 8u:
					text = resource.Value;
					goto IL_01be;
				case 2u:
					_206E_206A_202E_206A_202D_200B_206A_206D_200F_202B_200B_200F_202E_206D_200B_200F_206F_206F_200E_206D_200E_206F_200B_200F_200B_206F_200B_200C_206A_206A_202B_202C_206F_206B_202A_206C_206F_206C_200B_202D_202E((object)_202A_202C_200B_206F_200D_202A_200C_206F_200F_200D_202A_206B_202D_202A_200E_206F_200C_202A_200C_202D_206F_202D_200B_206F_200F_200D_206B_200C_206D_206A_200E_200C_200D_206F_206F_200D_206C_202B_206B_202A_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(608602907u), key));
					num = (int)(num2 * 179252125) ^ -168822570;
					continue;
				default:
					{
						return val;
					}
					IL_01be:
					text2 = text;
					val = null;
					if (CommonSettings.MOD_KEY() >= 0)
					{
						num = -1171880985;
						num9 = num;
					}
					else
					{
						num = -1369166223;
						num9 = num;
					}
					continue;
				}
				break;
			}
		}
	}

	public static Sprite GetImage2(string key, bool forceLoadFromResource)
	{
		Resource resource = ResourceManager.Get<Resource>(key);
		Sprite val = default(Sprite);
		string text = default(string);
		int num4 = default(int);
		while (true)
		{
			int num = 2010640745;
			while (true)
			{
				uint num2;
				string text2;
				switch ((num2 = (uint)(num ^ 0x1A11FD83)) % 17)
				{
				case 2u:
					break;
				case 10u:
				{
					val = AssetBundleManager.GetMap(text);
					int num11;
					if (_206F_206A_202E_202E_206A_200E_206D_206C_202A_202E_202D_200F_206A_202D_202B_202B_202B_206B_206B_200E_206A_200B_206D_200C_200E_202C_206E_200F_200F_206C_200C_206B_200F_200F_202D_206B_200D_202D_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num = 1215631570;
						num11 = num;
					}
					else
					{
						num = 1154468534;
						num11 = num;
					}
					continue;
				}
				case 8u:
					return val;
				case 14u:
					if (num4 == -1)
					{
						num = ((int)num2 * -986235587) ^ 0x7E112000;
						continue;
					}
					text2 = _206D_200E_202D_206F_200B_202E_200D_200D_202C_206A_202D_202E_206E_206E_200B_202E_202B_206B_206E_200D_202D_202D_206D_206F_202C_202E_206A_202B_206C_200B_206A_200D_206F_206B_202A_202A_202B_202B_202A_206F_202E(resource.Value, 0, num4);
					goto IL_0203;
				case 7u:
					return val;
				case 4u:
				{
					int num12;
					int num13;
					if (!forceLoadFromResource)
					{
						num12 = 536800025;
						num13 = num12;
					}
					else
					{
						num12 = 310336467;
						num13 = num12;
					}
					num = num12 ^ ((int)num2 * -1640141350);
					continue;
				}
				case 5u:
					num4 = _200E_206D_200E_206B_206E_200D_202A_200B_206A_200D_200D_206B_202C_206A_200E_206D_200F_202D_202E_200B_202B_200D_200F_200D_206E_206A_202D_206E_206C_200D_200B_200D_206E_202B_206A_200C_206E_200D_206D_202E_202E(resource.Value, '.');
					num = 1722203684;
					continue;
				case 13u:
				{
					num4 = _200E_206D_200E_206B_206E_200D_202A_200B_206A_200D_200D_206B_202C_206A_200E_206D_200F_202D_202E_200B_202B_200D_200F_200D_206E_206A_202D_206E_206C_200D_200B_200D_206E_202B_206A_200C_206E_200D_206D_202E_202E(text, '/');
					int num5;
					int num6;
					if (num4 == -1)
					{
						num5 = 1316841975;
						num6 = num5;
					}
					else
					{
						num5 = 1604728638;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 208721066);
					continue;
				}
				case 3u:
					text = _206D_200E_202D_206F_200B_202E_200D_200D_202C_206A_202D_202E_206E_206E_200B_202E_202B_206B_206E_200D_202D_202D_206D_206F_202C_202E_206A_202B_206C_200B_206A_200D_206F_206B_202A_202A_202B_202B_202A_206F_202E(text, num4 + 1, _200D_202A_200D_202A_200E_202A_206D_200F_200C_202B_200E_200D_202C_200C_206F_202B_206C_202C_200B_200E_202E_206C_206D_200C_202B_200F_202D_206F_200C_200C_200C_200F_206B_202A_206A_206D_206E_206E_200E_206A_202E(text) - num4 - 1);
					num = (int)(num2 * 1001355763) ^ -1561575600;
					continue;
				case 6u:
				{
					int num9;
					int num10;
					if (CommonSettings.MOD_KEY() < 0)
					{
						num9 = 143624023;
						num10 = num9;
					}
					else
					{
						num9 = 1536286311;
						num10 = num9;
					}
					num = num9 ^ (int)(num2 * 1093543252);
					continue;
				}
				case 11u:
					return null;
				case 9u:
				{
					int num7;
					int num8;
					if (resource == null)
					{
						num7 = 1749798509;
						num8 = num7;
					}
					else
					{
						num7 = 291283402;
						num8 = num7;
					}
					num = num7 ^ ((int)num2 * -2107586313);
					continue;
				}
				case 0u:
				{
					int num3;
					if (!_206E_202B_202C_206F_200B_206D_206A_202C_206C_202A_200C_206F_202C_206F_206A_206D_206F_202E_202D_200F_206E_202B_200C_200E_202B_202E_206E_200D_206F_206A_202E_200E_200F_202B_200E_206C_206F_206C_206B_206C_202E(key, ResourceStrings.ResStrings[1105]))
					{
						num = 1154468534;
						num3 = num;
					}
					else
					{
						num = 387260491;
						num3 = num;
					}
					continue;
				}
				case 12u:
					val = null;
					num = ((int)num2 * -1564177940) ^ 0x1AA646AE;
					continue;
				case 15u:
					text2 = resource.Value;
					goto IL_0203;
				case 1u:
					val = ModEditorResourceManager.GetSprite2(text, checkexists: true);
					num = ((int)num2 * -684578068) ^ -522949694;
					continue;
				default:
					{
						return Resources.Load<Sprite>(text);
					}
					IL_0203:
					text = text2;
					num = 1759352771;
					continue;
				}
				break;
			}
		}
	}

	public static void CacheImage(string key)
	{
		Resource resource = ResourceManager.Get<Resource>(key);
		int num5 = default(int);
		string key2 = default(string);
		while (true)
		{
			int num = 1298359270;
			while (true)
			{
				uint num2;
				string text;
				switch ((num2 = (uint)(num ^ 0x6A7EE419)) % 9)
				{
				case 4u:
					break;
				default:
					return;
				case 0u:
					return;
				case 7u:
					num5 = _200E_206D_200E_206B_206E_200D_202A_200B_206A_200D_200D_206B_202C_206A_200E_206D_200F_202D_202E_200B_202B_200D_200F_200D_206E_206A_202D_206E_206C_200D_200B_200D_206E_202B_206A_200C_206E_200D_206D_202E_202E(resource.Value, '.');
					num = (int)((num2 * 1172705085) ^ 0x547C514A);
					continue;
				case 3u:
					ModEditorResourceManager.CacheSprite(ModEditorResourceManager.sprites[key2]);
					num = 344056085;
					continue;
				case 5u:
					text = resource.Value;
					goto IL_009e;
				case 6u:
				{
					int num6;
					int num7;
					if (!ModEditorResourceManager.sprites.ContainsKey(key2))
					{
						num6 = 1930439817;
						num7 = num6;
					}
					else
					{
						num6 = 1295840643;
						num7 = num6;
					}
					num = num6 ^ ((int)num2 * -116109095);
					continue;
				}
				case 1u:
					if (num5 != -1)
					{
						text = _206D_200E_202D_206F_200B_202E_200D_200D_202C_206A_202D_202E_206E_206E_200B_202E_202B_206B_206E_200D_202D_202D_206D_206F_202C_202E_206A_202B_206C_200B_206A_200D_206F_206B_202A_202A_202B_202B_202A_206F_202E(resource.Value, 0, num5);
						goto IL_009e;
					}
					num = ((int)num2 * -88745543) ^ -377202803;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (resource != null)
					{
						num3 = 1163537286;
						num4 = num3;
					}
					else
					{
						num3 = 1144916507;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -464870158);
					continue;
				}
				case 8u:
					return;
					IL_009e:
					key2 = text;
					num = 2104031669;
					continue;
				}
				break;
			}
		}
	}

	public static Sprite GetAni(string aniName)
	{
		Sprite result = null;
		while (true)
		{
			int num = -1409526040;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -32353279)) % 4)
				{
				case 2u:
					break;
				case 1u:
				{
					int num3;
					int num4;
					if (CommonSettings.MOD_KEY() < 0)
					{
						num3 = -1841255979;
						num4 = num3;
					}
					else
					{
						num3 = -1252110358;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -802525400);
					continue;
				}
				case 3u:
					result = ModEditorResourceManager.LoadSpriteWithCompress(_206F_200C_206D_202C_200F_200E_200C_206E_206D_200C_200C_202E_202E_200E_202A_206E_202D_200E_202A_202A_200F_200D_202B_202B_200E_206B_200B_202B_206F_200B_202A_200B_202B_200D_206B_206B_206B_202C_200D_206D_202E(GlobalData.CurrentMod.LocalDirPath, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3490499946u), aniName, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1395788810u)));
					num = ((int)num2 * -1759739789) ^ 0x433E0864;
					continue;
				default:
					return result;
				}
				break;
			}
		}
	}

	public static Texture2D GrayTexture(Texture2D orgin, int targetWidth = 0, int targetHeight = 0)
	{
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			int num = _206E_206E_206C_200C_200B_206A_200E_206D_206D_206C_200C_206B_200D_206B_206C_206F_200E_202B_202C_202B_206E_206E_200B_200C_200F_206A_202A_206A_206A_202D_206B_202D_206D_202E_202A_200E_202E_200C_206C_202D_202E((Texture)(object)orgin);
			int num2 = _206B_206A_202B_206B_202D_200B_202B_202C_206C_202A_202B_202D_202B_202A_200C_206F_200D_200E_206C_206A_200C_206A_206F_202A_206E_206C_206B_200F_202A_200D_202B_200D_200B_200C_202C_206D_206B_206D_206E_200D_202E((Texture)(object)orgin);
			int num11 = default(int);
			Texture2D val3 = default(Texture2D);
			Texture2D val = default(Texture2D);
			int num10 = default(int);
			int num9 = default(int);
			int num5 = default(int);
			Color val2 = default(Color);
			Color val4 = default(Color);
			Color val5 = default(Color);
			while (true)
			{
				int num3 = 1332924536;
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)(num3 ^ 0x788D06DD)) % 29)
					{
					case 8u:
						break;
					case 23u:
					{
						int num16;
						if (num11 < _206E_206E_206C_200C_200B_206A_200E_206D_206D_206C_200C_206B_200D_206B_206C_206F_200E_202B_202C_202B_206E_206E_200B_200C_200F_206A_202A_206A_206A_202D_206B_202D_206D_202E_202A_200E_202E_200C_206C_202D_202E((Texture)(object)val3))
						{
							num3 = 245651894;
							num16 = num3;
						}
						else
						{
							num3 = 615413891;
							num16 = num3;
						}
						continue;
					}
					case 24u:
						_200C_202A_206E_206B_200C_202E_206B_206A_202B_202E_200D_202C_200C_202B_200E_200D_206D_200C_202D_200C_202A_202D_202D_202A_200C_202D_200C_200C_200B_206A_200B_202D_200E_200E_200F_206E_206E_206B_200E_200E_202E(val);
						num3 = ((int)num4 * -1050198209) ^ 0x139C4F10;
						continue;
					case 20u:
						num3 = (int)(num4 * 799190016) ^ -1181889327;
						continue;
					case 9u:
						num11 = 0;
						num3 = 116784795;
						continue;
					case 2u:
					{
						int num15;
						if (num10 < num2)
						{
							num3 = 246552005;
							num15 = num3;
						}
						else
						{
							num3 = 536799585;
							num15 = num3;
						}
						continue;
					}
					case 21u:
					{
						int num19;
						if (num9 < _206B_206A_202B_206B_202D_200B_202B_202C_206C_202A_202B_202D_202B_202A_200C_206F_200D_200E_206C_206A_200C_206A_206F_202A_206E_206C_206B_200F_202A_200D_202B_200D_200B_200C_202C_206D_206B_206D_206E_200D_202E((Texture)(object)val3))
						{
							num3 = 1837857641;
							num19 = num3;
						}
						else
						{
							num3 = 345236726;
							num19 = num3;
						}
						continue;
					}
					case 13u:
						num5++;
						num3 = (int)(num4 * 1792227627) ^ -1824021435;
						continue;
					case 15u:
					{
						int num7;
						int num8;
						if ((double)_206E_202E_202E_200E_200F_200B_202C_200B_206E_200F_206B_202E_206F_202C_202B_202C_200F_206F_200E_206E_206E_200F_206E_200F_200B_200C_206A_206B_206D_200E_200C_206D_202A_200B_202C_202E_200C_206F_200C_206A_202E(val2.a) > 1E-06)
						{
							num7 = 1577837548;
							num8 = num7;
						}
						else
						{
							num7 = 833222724;
							num8 = num7;
						}
						num3 = num7 ^ (int)(num4 * 1232904579);
						continue;
					}
					case 7u:
						val2 = _202C_206B_200C_202A_202D_202B_200F_202A_200B_206A_206F_200E_202D_206C_200E_206A_202E_206D_202C_200C_200D_200F_202E_200F_200D_206E_206F_202B_206D_202B_206F_200B_200F_202B_206C_202A_200E_202D_202C_202A_202E(val, num5, num10);
						num3 = 1181838940;
						continue;
					case 28u:
					{
						int num17;
						int num18;
						if (targetWidth <= 0)
						{
							num17 = 221919960;
							num18 = num17;
						}
						else
						{
							num17 = 464726793;
							num18 = num17;
						}
						num3 = num17 ^ (int)(num4 * 1906588188);
						continue;
					}
					case 12u:
					{
						int num13;
						int num14;
						if (targetHeight > 0)
						{
							num13 = 2048208493;
							num14 = num13;
						}
						else
						{
							num13 = 2053272392;
							num14 = num13;
						}
						num3 = num13 ^ ((int)num4 * -919641848);
						continue;
					}
					case 16u:
						val = _202C_206D_206E_202D_202D_200C_206A_206F_200C_206D_200F_206F_202B_206A_202E_200F_200F_206B_202B_200F_202A_202B_200F_206B_202B_206F_202A_202D_206F_206D_200F_206F_206E_200F_200D_202E_200F_202D_200D_206A_202E(num, num2);
						_206E_206F_200F_206E_206B_206A_206C_206C_200D_202C_200E_206E_200F_200B_206C_200D_206F_200B_200C_202E_202D_206B_200C_206E_202A_200B_206B_206A_206D_206F_200B_206B_200F_200E_206B_206F_200D_206D_200E_200D_202E(val, _206C_206B_200F_200B_202B_200C_200D_200D_200E_202E_200E_202C_200E_206E_206D_202E_202B_202E_202C_206F_202A_200E_206E_202C_202D_206C_200E_206D_202B_202B_206E_206F_202B_202A_206A_200C_202C_200D_206D_206E_202E(orgin));
						num3 = (int)(num4 * 1136660383) ^ -760763419;
						continue;
					case 1u:
						val4 = _200D_206A_202B_202A_202C_200C_200B_200D_202C_200B_202D_202C_202C_202C_206B_206E_202B_200F_206F_206C_206D_202C_206A_202B_200B_206E_200D_206C_200D_200D_206F_202C_206B_200B_200F_206A_202B_206E_206B_206F_202E(val, (float)num11 / (float)_206E_206E_206C_200C_200B_206A_200E_206D_206D_206C_200C_206B_200D_206B_206C_206F_200E_202B_202C_202B_206E_206E_200B_200C_200F_206A_202A_206A_206A_202D_206B_202D_206D_202E_202A_200E_202E_200C_206C_202D_202E((Texture)(object)val3), (float)num9 / (float)_206B_206A_202B_206B_202D_200B_202B_202C_206C_202A_202B_202D_202B_202A_200C_206F_200D_200E_206C_206A_200C_206A_206F_202A_206E_206C_206B_200F_202A_200D_202B_200D_200B_200C_202C_206D_206B_206D_206E_200D_202E((Texture)(object)val3));
						num3 = 923367412;
						continue;
					case 22u:
						return val3;
					case 27u:
						num5 = 0;
						num3 = (int)((num4 * 1630328866) ^ 0x2E98BD0D);
						continue;
					case 19u:
						_202B_200D_202C_206B_202B_202E_202D_202A_206F_202D_200E_202B_200D_200D_200C_202B_200E_202B_202D_202E_200D_200E_200E_206A_200F_200C_206A_200E_200F_206E_200C_200F_206F_206D_200B_206B_206B_200B_200B_206D_202E(val, num5, num10, val5);
						num3 = (int)((num4 * 1428004700) ^ 0x10166DD3);
						continue;
					case 17u:
						val3 = _200F_202D_200F_206B_206D_200D_202C_200F_206A_206F_202D_206C_202C_206B_200D_200F_202C_202E_202D_200E_206F_206C_200F_202A_202C_206D_206B_202C_206E_200C_202E_206F_202A_200D_202E_206B_200B_200D_206D_200C_202E(targetWidth, targetHeight, _206E_200D_202E_200E_200C_206A_206F_206C_202B_206C_206F_200C_206C_206C_206A_206E_202A_200C_206D_206A_206C_206E_202C_206D_206C_200D_206B_206D_202D_202C_202C_206B_206D_200E_206D_206B_206F_200F_206A_200E_202E(val), false);
						_ = 1f / (float)targetWidth;
						_ = 1f / (float)targetHeight;
						num9 = 0;
						num3 = ((int)num4 * -2108556175) ^ 0x180780F2;
						continue;
					case 10u:
						num10++;
						num3 = 615491690;
						continue;
					case 3u:
						num11++;
						num3 = (int)((num4 * 1803455979) ^ 0x448364CC);
						continue;
					case 14u:
					{
						float num12 = (val2.r + val2.g + val2.b) / 3f;
						((Color)(ref val5))._002Ector(num12, num12, num12);
						num3 = ((int)num4 * -473114276) ^ -2088964666;
						continue;
					}
					case 0u:
						num3 = ((int)num4 * -1850700972) ^ -2037065360;
						continue;
					case 26u:
						num3 = (int)(num4 * 341260799) ^ -1463399059;
						continue;
					case 6u:
						_202B_200D_202C_206B_202B_202E_202D_202A_206F_202D_200E_202B_200D_200D_200C_202B_200E_202B_202D_202E_200D_200E_200E_206A_200F_200C_206A_200E_200F_206E_200C_200F_206F_206D_200B_206B_206B_200B_200B_206D_202E(val3, num11, num9, val4);
						num3 = (int)(num4 * 317592992) ^ -1636984143;
						continue;
					case 18u:
						num10 = 0;
						num3 = 615491690;
						continue;
					case 4u:
						num9++;
						num3 = (int)(num4 * 2055912670) ^ -880675416;
						continue;
					case 25u:
						_200C_202A_206E_206B_200C_202E_206B_206A_202B_202E_200D_202C_200C_202B_200E_200D_206D_200C_202D_200C_202A_202D_202D_202A_200C_202D_200C_200C_200B_206A_200B_202D_200E_200E_200F_206E_206E_206B_200E_200E_202E(val3);
						num3 = ((int)num4 * -1505651263) ^ -1200479826;
						continue;
					case 5u:
					{
						int num6;
						if (num5 < num)
						{
							num3 = 489401357;
							num6 = num3;
						}
						else
						{
							num3 = 1868473946;
							num6 = num3;
						}
						continue;
					}
					default:
						return val;
					}
					break;
				}
			}
		}
		catch
		{
			return orgin;
		}
	}

	public static Sprite GetGrayImage(string key, bool forceLoadFromResource, int targetWidth = 0, int targetHeight = 0)
	{
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		Resource resource = ResourceManager.Get<Resource>(key);
		if (resource == null)
		{
			goto IL_000d;
		}
		goto IL_0229;
		IL_000d:
		int num = 757926520;
		goto IL_0012;
		IL_0012:
		string text = default(string);
		Sprite val = default(Sprite);
		Texture2D val2 = default(Texture2D);
		int num11 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x4B0A9079)) % 15)
			{
			case 5u:
				break;
			case 3u:
				goto IL_0064;
			case 10u:
			{
				int num5;
				int num6;
				if (ModEditorResourceManager.sprites.ContainsKey(text))
				{
					num5 = -878354221;
					num6 = num5;
				}
				else
				{
					num5 = -1892020382;
					num6 = num5;
				}
				num = num5 ^ ((int)num2 * -1770056134);
				continue;
			}
			case 11u:
				_206E_206A_202E_206A_202D_200B_206A_206D_200F_202B_200B_200F_202E_206D_200B_200F_206F_206F_200E_206D_200E_206F_200B_200F_200B_206F_200B_200C_206A_206A_202B_202C_206F_206B_202A_206C_206F_206C_200B_202D_202E((object)_202A_202C_200B_206F_200D_202A_200C_206F_200F_200D_202A_206B_202D_202A_200E_206F_200C_202A_200C_202D_206F_202D_200B_206F_200F_200D_206B_200C_206D_206A_200E_200C_200D_206F_206F_200D_206C_202B_206B_202A_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(230621662u), key));
				num = (int)(num2 * 826221032) ^ -1537229338;
				continue;
			case 14u:
			{
				int num7;
				int num8;
				if (forceLoadFromResource)
				{
					num7 = 1029886684;
					num8 = num7;
				}
				else
				{
					num7 = 170321;
					num8 = num7;
				}
				num = num7 ^ (int)(num2 * 1128457199);
				continue;
			}
			case 7u:
			{
				int num9;
				int num10;
				if ((Object)(object)val == (Object)null)
				{
					num9 = 762910818;
					num10 = num9;
				}
				else
				{
					num9 = 2062719634;
					num10 = num9;
				}
				num = num9 ^ ((int)num2 * -534854106);
				continue;
			}
			case 8u:
				val = Resources.Load<Sprite>(text);
				num = 182623383;
				continue;
			case 2u:
				val = Resources.Load<Sprite>(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(564295927u));
				num = (int)(num2 * 1493152805) ^ -1920684115;
				continue;
			case 0u:
				val2 = GrayTexture(_206F_206F_206C_200F_200F_206F_202A_206C_202B_202E_202D_200B_206E_200F_200B_202A_206B_202D_206A_200B_206D_206A_200D_202B_206B_202D_202E_206D_202D_206B_202C_206E_202D_200D_202E_202D_206F_200C_200C_202C_202E(val), targetWidth, targetHeight);
				num = ((int)num2 * -1127545162) ^ 0x2CCB5F13;
				continue;
			case 1u:
			{
				val = ModEditorResourceManager.LoadHeadSprite(ModEditorResourceManager.sprites[text]);
				int num3;
				int num4;
				if (!_206F_206A_202E_202E_206A_200E_206D_206C_202A_202E_202D_200F_206A_202D_202B_202B_202B_206B_206B_200E_206A_200B_206D_200C_200E_202C_206E_200F_200F_206C_200C_206B_200F_200F_202D_206B_200D_202D_202C_206D_202E((Object)(object)val, (Object)null))
				{
					num3 = 1420921972;
					num4 = num3;
				}
				else
				{
					num3 = 534326569;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 148655135);
				continue;
			}
			case 12u:
				return Sprite.Create(val2, new Rect(0f, 0f, (float)_206E_206E_206C_200C_200B_206A_200E_206D_206D_206C_200C_206B_200D_206B_206C_206F_200E_202B_202C_202B_206E_206E_200B_200C_200F_206A_202A_206A_206A_202D_206B_202D_206D_202E_202A_200E_202E_200C_206C_202D_202E((Texture)(object)val2) - 1f, (float)_206B_206A_202B_206B_202D_200B_202B_202C_206C_202A_202B_202D_202B_202A_200C_206F_200D_200E_206C_206A_200C_206A_206F_202A_206E_206C_206B_200F_202A_200D_202B_200D_200B_200C_202C_206D_206B_206D_206E_200D_202E((Texture)(object)val2) - 1f), new Vector2(0.5f, 0.5f));
			case 13u:
				goto IL_01f5;
			case 9u:
				goto IL_0229;
			case 6u:
				return Resources.Load<Sprite>(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1876708067u));
			default:
				return val;
			}
			break;
			IL_01f5:
			string text2 = resource.Value;
			goto IL_020a;
			IL_0064:
			if (num11 == -1)
			{
				num = (int)(num2 * 1531233899) ^ -1255740082;
				continue;
			}
			text2 = _206D_200E_202D_206F_200B_202E_200D_200D_202C_206A_202D_202E_206E_206E_200B_202E_202B_206B_206E_200D_202D_202D_206D_206F_202C_202E_206A_202B_206C_200B_206A_200D_206F_206B_202A_202A_202B_202B_202A_206F_202E(resource.Value, 0, num11);
			goto IL_020a;
			IL_020a:
			text = text2;
			val = null;
			int num12;
			if (CommonSettings.MOD_KEY() >= 0)
			{
				num = 1284562671;
				num12 = num;
			}
			else
			{
				num = 1275638486;
				num12 = num;
			}
		}
		goto IL_000d;
		IL_0229:
		num11 = _200E_206D_200E_206B_206E_200D_202A_200B_206A_200D_200D_206B_202C_206A_200E_206D_200F_202D_202E_200B_202B_200D_200F_200D_206E_206A_202D_206E_206C_200D_200B_200D_206E_202B_206A_200C_206E_200D_206D_202E_202E(resource.Value, '.');
		num = 381923405;
		goto IL_0012;
	}

	public static string GetModThumbnailPath(string key, ref Sprite sprite)
	{
		if (CommonSettings.MOD_KEY() < 0)
		{
			goto IL_000b;
		}
		goto IL_008d;
		IL_000b:
		int num = 580679240;
		goto IL_0010;
		IL_0010:
		string key2 = default(string);
		string text = default(string);
		Resource resource = default(Resource);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			uint num2;
			string text2;
			switch ((num2 = (uint)(num ^ 0x7AA9DABA)) % 16)
			{
			case 5u:
				break;
			case 12u:
				sprite = ModEditorResourceManager.spriteCache[ModEditorResourceManager.sprites[key2]];
				num = (int)((num2 * 1056158833) ^ 0x53E41796);
				continue;
			case 15u:
				goto IL_008d;
			case 7u:
			{
				int num9;
				int num10;
				if (!ModEditorResourceManager.sprites.ContainsKey(key2))
				{
					num9 = -551126515;
					num10 = num9;
				}
				else
				{
					num9 = -853856410;
					num10 = num9;
				}
				num = num9 ^ ((int)num2 * -1907216534);
				continue;
			}
			case 10u:
			{
				int num5;
				int num6;
				if (ModEditorResourceManager.spriteCache.ContainsKey(ModEditorResourceManager.sprites[key2]))
				{
					num5 = -811080996;
					num6 = num5;
				}
				else
				{
					num5 = -1090300541;
					num6 = num5;
				}
				num = num5 ^ ((int)num2 * -399002335);
				continue;
			}
			case 13u:
				return text;
			case 6u:
			{
				int num7;
				int num8;
				if (resource == null)
				{
					num7 = 1781285588;
					num8 = num7;
				}
				else
				{
					num7 = 1257176779;
					num8 = num7;
				}
				num = num7 ^ (int)(num2 * 1414991999);
				continue;
			}
			case 8u:
				if (num3 == -1)
				{
					num = (int)(num2 * 489470007) ^ -1375989988;
					continue;
				}
				text2 = _206D_200E_202D_206F_200B_202E_200D_200D_202C_206A_202D_202E_206E_206E_200B_202E_202B_206B_206E_200D_202D_202D_206D_206F_202C_202E_206A_202B_206C_200B_206A_200D_206F_206B_202A_202A_202B_202B_202A_206F_202E(resource.Value, 0, num3);
				goto IL_0172;
			case 2u:
				return null;
			case 14u:
				text2 = resource.Value;
				goto IL_0172;
			case 4u:
				return null;
			case 9u:
				text = _202D_200C_206F_206D_206E_206E_206F_206C_200E_206B_202C_206F_206C_206F_206E_200C_202A_202A_200D_202D_202B_206A_206D_200D_202E_206E_206A_200B_206E_202E_206A_206D_202B_206E_202D_206E_206F_202A_202B_202D_202E(_206D_200E_202D_206F_200B_202E_200D_200D_202C_206A_202D_202E_206E_206E_200B_202E_202B_206B_206E_200D_202D_202D_206D_206F_202C_202E_206A_202B_206C_200B_206A_200D_206F_206B_202A_202A_202B_202B_202A_206F_202E(text, 0, num4), global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1009394446u), _206D_200E_202D_206F_200B_202E_200D_200D_202C_206A_202D_202E_206E_206E_200B_202E_202B_206B_206E_200D_202D_202D_206D_206F_202C_202E_206A_202B_206C_200B_206A_200D_206F_206B_202A_202A_202B_202B_202A_206F_202E(text, num4, _200D_202A_200D_202A_200E_202A_206D_200F_200C_202B_200E_200D_202C_200C_206F_202B_206C_202C_200B_200E_202E_206C_206D_200C_202B_200F_202D_206F_200C_200C_200C_200F_206B_202A_206A_206D_206E_206E_200E_206A_202E(text) - num4));
				num = ((int)num2 * -1992329073) ^ -1633909264;
				continue;
			case 3u:
				goto IL_01cf;
			case 0u:
				return null;
			case 11u:
				num3 = _200E_206D_200E_206B_206E_200D_202A_200B_206A_200D_200D_206B_202C_206A_200E_206D_200F_202D_202E_200B_202B_200D_200F_200D_206E_206A_202D_206E_206C_200D_200B_200D_206E_202B_206A_200C_206E_200D_206D_202E_202E(resource.Value, '.');
				num = 856114882;
				continue;
			default:
				{
					return null;
				}
				IL_0172:
				key2 = text2;
				num = 284635821;
				continue;
			}
			break;
			IL_01cf:
			text = _202A_202C_200B_206F_200D_202A_200C_206F_200F_200D_202A_206B_202D_202A_200E_206F_200C_202A_200C_202D_206F_202D_200B_206F_200F_200D_206B_200C_206D_206A_200E_200C_200D_206F_206F_200D_206C_202B_206B_202A_202E(ModManager.ModBaseUrlPath, ModEditorResourceManager.sprites[key2]);
			num4 = _200E_206D_200E_206B_206E_200D_202A_200B_206A_200D_200D_206B_202C_206A_200E_206D_200F_202D_202E_200B_202B_200D_200F_200D_206E_206A_202D_206E_206C_200D_200B_200D_206E_202B_206A_200C_206E_200D_206D_202E_202E(text, '/');
			int num11;
			if (num4 > 0)
			{
				num = 1631259187;
				num11 = num;
			}
			else
			{
				num = 1314924683;
				num11 = num;
			}
		}
		goto IL_000b;
		IL_008d:
		resource = ResourceManager.Get<Resource>(key);
		num = 968775852;
		goto IL_0010;
	}

	public static Sprite GetModThumbnailImage(string url)
	{
		int num = _200E_206D_200E_206B_206E_200D_202A_200B_206A_200D_200D_206B_202C_206A_200E_206D_200F_202D_202E_200B_202B_200D_200F_200D_206E_206A_202D_206E_206C_200D_200B_200D_206E_202B_206A_200C_206E_200D_206D_202E_202E(url, '/');
		string key = _202A_202C_200B_206F_200D_202A_200C_206F_200F_200D_202A_206B_202D_202A_200E_206F_200C_202A_200C_202D_206F_202D_200B_206F_200F_200D_206B_200C_206D_206A_200E_200C_200D_206F_206F_200D_206C_202B_206B_202A_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1204087642u), _206D_200E_202D_206F_200B_202E_200D_200D_202C_206A_202D_202E_206E_206E_200B_202E_202B_206B_206E_200D_202D_202D_206D_206F_202C_202E_206A_202B_206C_200B_206A_200D_206F_206B_202A_202A_202B_202B_202A_206F_202E(url, num, _200D_202A_200D_202A_200E_202A_206D_200F_200C_202B_200E_200D_202C_200C_206F_202B_206C_202C_200B_200E_202E_206C_206D_200C_202B_200F_202D_206F_200C_200C_200C_200F_206B_202A_206A_206D_206E_206E_200E_206A_202E(url) - num));
		Sprite val = default(Sprite);
		while (true)
		{
			int num2 = -701550254;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1323154247)) % 7)
				{
				case 5u:
					break;
				case 6u:
				{
					int num6;
					int num7;
					if (!ModEditorResourceManager.spriteCache.ContainsKey(key))
					{
						num6 = 2063901094;
						num7 = num6;
					}
					else
					{
						num6 = 794206130;
						num7 = num6;
					}
					num2 = num6 ^ (int)(num3 * 1274149689);
					continue;
				}
				case 3u:
					val = ModEditorResourceManager.LoadSpriteWithCompress(url);
					num2 = -415337969;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (!_206F_206A_202E_202E_206A_200E_206D_206C_202A_202E_202D_200F_206A_202D_202B_202B_202B_206B_206B_200E_206A_200B_206D_200C_200E_202C_206E_200F_200F_206C_200C_206B_200F_200F_202D_206B_200D_202D_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num4 = 1498333559;
						num5 = num4;
					}
					else
					{
						num4 = 508469179;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num3 * -1283330813);
					continue;
				}
				case 4u:
					return ModEditorResourceManager.spriteCache[key];
				case 0u:
					ModEditorResourceManager.spriteCache[key] = val;
					return val;
				default:
					return null;
				}
				break;
			}
		}
	}

	public static IEnumerable<string> LoadAllName(string path)
	{
		Object[] array = default(Object[]);
		int num3 = default(int);
		while (true)
		{
			int num = -964003800;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -157112206)) % 12)
				{
				case 8u:
					num = -174438909;
					continue;
				default:
					yield break;
				case 5u:
				{
					int num4;
					num = ((num4 != 1) ? 2109723090 : 244692613) ^ (int)(num2 * 1821601987);
					continue;
				}
				case 4u:
					num = -411619522;
					continue;
				case 7u:
					yield break;
				case 6u:
				{
					GameObject val = (GameObject)array[num3];
					yield return _200E_202C_200E_202A_202C_202E_200F_202A_206D_202D_206E_202D_206A_206D_206C_202E_202E_200D_200C_202A_202E_202C_202C_202B_202D_206E_200C_200B_202E_200E_206D_200F_202D_206C_200C_206C_206E_206E_202B_206A_202E._206E_206B_202A_200F_206F_200B_200C_206D_202D_202C_200E_206C_206A_206B_202E_206B_202D_202B_200E_200F_200E_202E_202D_202C_200E_200D_202B_206F_200D_200E_200E_202D_200E_200C_200D_200D_200F_200F_206E_200E_202E((Object)(object)val);
					/*Error: Unable to find 'return true' for yield return*/;
				}
				case 3u:
					/*Error near IL_00c7: Unexpected return in MoveNext()*/;
				case 2u:
					array = _200E_202C_200E_202A_202C_202E_200F_202A_206D_202D_206E_202D_206A_206D_206C_202E_202E_200D_200C_202A_202E_202C_202C_202B_202D_206E_200C_200B_202E_200E_206D_200F_202D_206C_200C_206C_206E_206E_202B_206A_202E._200B_200F_202C_206A_202B_200C_200F_206C_202B_206D_200C_202D_200D_200F_202E_206F_206C_202A_200B_202E_200F_200F_202C_206F_206C_202E_202A_200C_206B_202D_200F_202C_200B_206D_200F_200C_200F_202B_202E_200C_202E(path);
					num3 = 0;
					num = ((int)num2 * -1909903360) ^ 0x38F39A8B;
					continue;
				case 11u:
					array = null;
					num = ((int)num2 * -2040390642) ^ 0x32B17609;
					continue;
				case 10u:
					break;
				case 0u:
					num3++;
					num = (int)(num2 * 518918174) ^ -374611869;
					continue;
				case 1u:
					num = ((num3 < array.Length) ? (-1194120644) : (-53318339));
					continue;
				}
				break;
			}
		}
	}

	public static string Key2Url(string key)
	{
		Resource resource = ResourceManager.Get<Resource>(key);
		if (resource != null)
		{
			int num3 = default(int);
			string key2 = default(string);
			while (true)
			{
				int num = -1551166599;
				while (true)
				{
					uint num2;
					string text;
					switch ((num2 = (uint)(num ^ -474771006)) % 7)
					{
					case 4u:
						break;
					case 1u:
						num3 = _200E_206D_200E_206B_206E_200D_202A_200B_206A_200D_200D_206B_202C_206A_200E_206D_200F_202D_202E_200B_202B_200D_200F_200D_206E_206A_202D_206E_206C_200D_200B_200D_206E_202B_206A_200C_206E_200D_206D_202E_202E(resource.Value, '.');
						num = (int)(num2 * 243303578) ^ -773511045;
						continue;
					case 3u:
					{
						int num4;
						int num5;
						if (!ModEditorResourceManager.sprites.ContainsKey(key2))
						{
							num4 = 1962490255;
							num5 = num4;
						}
						else
						{
							num4 = 1786763670;
							num5 = num4;
						}
						num = num4 ^ (int)(num2 * 1249834394);
						continue;
					}
					case 2u:
						if (num3 == -1)
						{
							num = ((int)num2 * -1444207933) ^ -2014573717;
							continue;
						}
						text = _206D_200E_202D_206F_200B_202E_200D_200D_202C_206A_202D_202E_206E_206E_200B_202E_202B_206B_206E_200D_202D_202D_206D_206F_202C_202E_206A_202B_206C_200B_206A_200D_206F_206B_202A_202A_202B_202B_202A_206F_202E(resource.Value, 0, num3);
						goto IL_00b0;
					case 0u:
						text = resource.Value;
						goto IL_00b0;
					case 6u:
						return ModEditorResourceManager.sprites[key2];
					default:
						goto end_IL_000d;
						IL_00b0:
						key2 = text;
						num = -2053267916;
						continue;
					}
					break;
				}
				continue;
				end_IL_000d:
				break;
			}
		}
		return null;
	}

	static bool _206E_202B_202C_206F_200B_206D_206A_202C_206C_202A_200C_206F_202C_206F_206A_206D_206F_202E_202D_200F_206E_202B_200C_200E_202B_202E_206E_200D_206F_206A_202E_200E_200F_202B_200E_206C_206F_206C_206B_206C_202E(string P_0, string P_1)
	{
		return P_0.StartsWith(P_1);
	}

	static string _202A_202C_200B_206F_200D_202A_200C_206F_200F_200D_202A_206B_202D_202A_200E_206F_200C_202A_200C_202D_206F_202D_200B_206F_200F_200D_206B_200C_206D_206A_200E_200C_200D_206F_206F_200D_206C_202B_206B_202A_202E(string P_0, string P_1)
	{
		return P_0 + P_1;
	}

	static bool _206F_206A_202E_202E_206A_200E_206D_206C_202A_202E_202D_200F_206A_202D_202B_202B_202B_206B_206B_200E_206A_200B_206D_200C_200E_202C_206E_200F_200F_206C_200C_206B_200F_200F_202D_206B_200D_202D_202C_206D_202E(Object P_0, Object P_1)
	{
		return P_0 != P_1;
	}

	static bool _206D_206F_202B_202C_206A_200B_206A_206D_206D_202C_206F_202D_202C_202E_206F_202C_202C_202D_206D_206A_200C_206C_206C_206E_206D_206C_200F_202E_202D_202A_200D_200F_200E_202B_200B_200C_200D_200D_202A_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static Texture2D _202C_206D_206E_202D_202D_200C_206A_206F_200C_206D_200F_206F_202B_206A_202E_200F_200F_206B_202B_200F_202A_202B_200F_206B_202B_206F_202A_202D_206F_206D_200F_206F_206E_200F_200D_202E_200F_202D_200D_206A_202E(int P_0, int P_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new Texture2D(P_0, P_1);
	}

	static void _202B_200D_202C_206B_202B_202E_202D_202A_206F_202D_200E_202B_200D_200D_200C_202B_200E_202B_202D_202E_200D_200E_200E_206A_200F_200C_206A_200E_200F_206E_200C_200F_206F_206D_200B_206B_206B_200B_200B_206D_202E(Texture2D P_0, int P_1, int P_2, Color P_3)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		P_0.SetPixel(P_1, P_2, P_3);
	}

	static int _206E_206E_206C_200C_200B_206A_200E_206D_206D_206C_200C_206B_200D_206B_206C_206F_200E_202B_202C_202B_206E_206E_200B_200C_200F_206A_202A_206A_206A_202D_206B_202D_206D_202E_202A_200E_202E_200C_206C_202D_202E(Texture P_0)
	{
		return P_0.width;
	}

	static int _206B_206A_202B_206B_202D_200B_202B_202C_206C_202A_202B_202D_202B_202A_200C_206F_200D_200E_206C_206A_200C_206A_206F_202A_206E_206C_206B_200F_202A_200D_202B_200D_200B_200C_202C_206D_206B_206D_206E_200D_202E(Texture P_0)
	{
		return P_0.height;
	}

	static void _206E_206A_202E_206A_202D_200B_206A_206D_200F_202B_200B_200F_202E_206D_200B_200F_206F_206F_200E_206D_200E_206F_200B_200F_200B_206F_200B_200C_206A_206A_202B_202C_206F_206B_202A_206C_206F_206C_200B_202D_202E(object P_0)
	{
		Debug.LogError(P_0);
	}

	static int _200E_206D_200E_206B_206E_200D_202A_200B_206A_200D_200D_206B_202C_206A_200E_206D_200F_202D_202E_200B_202B_200D_200F_200D_206E_206A_202D_206E_206C_200D_200B_200D_206E_202B_206A_200C_206E_200D_206D_202E_202E(string P_0, char P_1)
	{
		return P_0.LastIndexOf(P_1);
	}

	static string _206D_200E_202D_206F_200B_202E_200D_200D_202C_206A_202D_202E_206E_206E_200B_202E_202B_206B_206E_200D_202D_202D_206D_206F_202C_202E_206A_202B_206C_200B_206A_200D_206F_206B_202A_202A_202B_202B_202A_206F_202E(string P_0, int P_1, int P_2)
	{
		return P_0.Substring(P_1, P_2);
	}

	static int _200D_202A_200D_202A_200E_202A_206D_200F_200C_202B_200E_200D_202C_200C_206F_202B_206C_202C_200B_200E_202E_206C_206D_200C_202B_200F_202D_206F_200C_200C_200C_200F_206B_202A_206A_206D_206E_206E_200E_206A_202E(string P_0)
	{
		return P_0.Length;
	}

	static bool _206D_200B_202D_206F_206A_200B_202B_200D_206F_200B_200D_200C_202B_202A_200B_206F_200C_200E_200C_202B_202A_206E_202C_200F_200F_206A_202D_206E_206A_202D_200D_202C_202A_200B_200B_202D_202B_200D_206F_206B_202E(string P_0, string P_1)
	{
		return P_0 == P_1;
	}

	static int _206D_202D_200C_202B_202D_206E_206C_206E_202D_200D_202B_202E_200C_200C_200C_206F_202E_202E_206E_202C_202B_206D_202B_206E_202B_206E_202C_206F_202B_206A_200C_206D_206B_200C_202C_206E_202E_202C_202A_200D_202E(string P_0, char P_1)
	{
		return P_0.IndexOf(P_1);
	}

	static byte[] _206D_202A_202E_202A_206F_206B_202B_202A_206A_206B_202B_200D_206C_200E_200F_200B_200B_202B_202A_202D_200F_202E_202D_200F_206E_206A_202A_206B_200E_202B_206B_206E_206C_200C_206E_206A_206E_206E_200E_202D_202E(TextAsset P_0)
	{
		return P_0.bytes;
	}

	static string _202D_202C_200E_206B_206F_202E_206C_202A_206F_200E_202A_206A_202A_200E_206D_206B_206A_202E_200E_200C_206D_206D_202E_206A_206F_200C_206B_202B_206B_202D_206B_202A_202E_206F_200F_200C_200B_202D_200E_200F_202E(string P_0, object P_1, object P_2, object P_3)
	{
		return string.Format(P_0, P_1, P_2, P_3);
	}

	static string _202C_206B_200F_206E_200C_200C_206E_202C_206D_206A_200C_202E_202C_200C_202C_202A_200E_202A_200D_202A_206E_200E_200F_206F_206D_206B_202D_206B_200C_206A_206F_200B_200D_202D_200C_200C_202A_200C_200C_200E_202E(string P_0, object P_1, object P_2)
	{
		return string.Format(P_0, P_1, P_2);
	}

	static string _206F_200C_206D_202C_200F_200E_200C_206E_206D_200C_200C_202E_202E_200E_202A_206E_202D_200E_202A_202A_200F_200D_202B_202B_200E_206B_200B_202B_206F_200B_202A_200B_202B_200D_206B_206B_206B_202C_200D_206D_202E(string P_0, string P_1, string P_2, string P_3)
	{
		return P_0 + P_1 + P_2 + P_3;
	}

	static byte[] _206C_206B_200F_200B_202B_200C_200D_200D_200E_202E_200E_202C_200E_206E_206D_202E_202B_202E_202C_206F_202A_200E_206E_202C_202D_206C_200E_206D_202B_202B_206E_206F_202B_202A_206A_200C_202C_200D_206D_206E_202E(Texture2D P_0)
	{
		return P_0.GetRawTextureData();
	}

	static void _206E_206F_200F_206E_206B_206A_206C_206C_200D_202C_200E_206E_200F_200B_206C_200D_206F_200B_200C_202E_202D_206B_200C_206E_202A_200B_206B_206A_206D_206F_200B_206B_200F_200E_206B_206F_200D_206D_200E_200D_202E(Texture2D P_0, byte[] P_1)
	{
		P_0.LoadRawTextureData(P_1);
	}

	static Color _202C_206B_200C_202A_202D_202B_200F_202A_200B_206A_206F_200E_202D_206C_200E_206A_202E_206D_202C_200C_200D_200F_202E_200F_200D_206E_206F_202B_206D_202B_206F_200B_200F_202B_206C_202A_200E_202D_202C_202A_202E(Texture2D P_0, int P_1, int P_2)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return P_0.GetPixel(P_1, P_2);
	}

	static float _206E_202E_202E_200E_200F_200B_202C_200B_206E_200F_206B_202E_206F_202C_202B_202C_200F_206F_200E_206E_206E_200F_206E_200F_200B_200C_206A_206B_206D_200E_200C_206D_202A_200B_202C_202E_200C_206F_200C_206A_202E(float P_0)
	{
		return Math.Abs(P_0);
	}

	static void _200C_202A_206E_206B_200C_202E_206B_206A_202B_202E_200D_202C_200C_202B_200E_200D_206D_200C_202D_200C_202A_202D_202D_202A_200C_202D_200C_200C_200B_206A_200B_202D_200E_200E_200F_206E_206E_206B_200E_200E_202E(Texture2D P_0)
	{
		P_0.Apply();
	}

	static TextureFormat _206E_200D_202E_200E_200C_206A_206F_206C_202B_206C_206F_200C_206C_206C_206A_206E_202A_200C_206D_206A_206C_206E_202C_206D_206C_200D_206B_206D_202D_202C_202C_206B_206D_200E_206D_206B_206F_200F_206A_200E_202E(Texture2D P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.format;
	}

	static Texture2D _200F_202D_200F_206B_206D_200D_202C_200F_206A_206F_202D_206C_202C_206B_200D_200F_202C_202E_202D_200E_206F_206C_200F_202A_202C_206D_206B_202C_206E_200C_202E_206F_202A_200D_202E_206B_200B_200D_206D_200C_202E(int P_0, int P_1, TextureFormat P_2, bool P_3)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		return new Texture2D(P_0, P_1, P_2, P_3);
	}

	static Color _200D_206A_202B_202A_202C_200C_200B_200D_202C_200B_202D_202C_202C_202C_206B_206E_202B_200F_206F_206C_206D_202C_206A_202B_200B_206E_200D_206C_200D_200D_206F_202C_206B_200B_200F_206A_202B_206E_206B_206F_202E(Texture2D P_0, float P_1, float P_2)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return P_0.GetPixelBilinear(P_1, P_2);
	}

	static Texture2D _206F_206F_206C_200F_200F_206F_202A_206C_202B_202E_202D_200B_206E_200F_200B_202A_206B_202D_206A_200B_206D_206A_200D_202B_206B_202D_202E_206D_202D_206B_202C_206E_202D_200D_202E_202D_206F_200C_200C_202C_202E(Sprite P_0)
	{
		return P_0.texture;
	}

	static string _202D_200C_206F_206D_206E_206E_206F_206C_200E_206B_202C_206F_206C_206F_206E_200C_202A_202A_200D_202D_202B_206A_206D_200D_202E_206E_206A_200B_206E_202E_206A_206D_202B_206E_202D_206E_206F_202A_202B_202D_202E(string P_0, string P_1, string P_2)
	{
		return P_0 + P_1 + P_2;
	}
}
