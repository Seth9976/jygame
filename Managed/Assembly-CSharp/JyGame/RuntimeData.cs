using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using UnityEngine;

namespace JyGame;

public class RuntimeData
{
	[CompilerGenerated]
	private sealed class _202B_202A_200B_200E_200D_206B_202C_200C_206B_202B_206A_202E_202C_206E_200D_202B_202A_202B_206E_206B_206A_206E_206C_206D_202D_200F_202D_206F_202A_202B_200D_200E_202B_200E_206E_202C_206E_202A_206C_206B_202E : IEnumerable<Role>, IEnumerator<Role>, IEnumerator, IDisposable, IEnumerable
	{
		private int _200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E;

		private Role _200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E;

		private int _200B_202B_206E_200C_202C_200D_206F_202E_200F_206A_200C_202C_200B_202D_200F_206E_202D_206C_200B_202C_206C_206A_206E_206C_202B_206D_206E_200E_206E_202D_206E_202E_202E_202A_206D_206E_206D_202C_202D_202E;

		public RuntimeData _202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E;

		private List<Role>.Enumerator _206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E;

		Role IEnumerator<Role>.Current
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
		public _202B_202A_200B_200E_200D_206B_202C_200C_206B_202B_206A_202E_202C_206E_200D_202B_202A_202B_206E_206B_206A_206E_206C_206D_202D_200F_202D_206F_202A_202B_200D_200E_202B_200E_206E_202C_206E_202A_206C_206B_202E(int P_0)
		{
			_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = P_0;
			_200B_202B_206E_200C_202C_200D_206F_202E_200F_206A_200C_202C_200B_202D_200F_206E_202D_206C_200B_202C_206C_206A_206E_206C_202B_206D_206E_200E_206E_202D_206E_202E_202E_202A_206D_206E_206D_202C_202D_202E = _200B_202A_206E_200F_206C_206B_200C_200F_206F_202A_200D_206C_202C_202E_202B_202D_200E_200F_200E_206C_206D_200F_206D_202B_206C_200B_206A_206E_202E_202B_202C_206E_200F_206C_206D_202A_200C_202A_200F_202A_202E(_202B_200F_202D_202A_200C_206C_202B_202B_202A_202E_206F_200D_206A_200B_206E_202D_200B_200C_202B_206C_202B_202A_202B_206C_200E_200F_206E_206F_202E_206D_200B_206B_202C_206C_202E_202D_202B_200E_206A_202E());
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			switch (_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E)
			{
			default:
				while (true)
				{
					uint num;
					switch ((num = 611817211u) % 3)
					{
					case 2u:
						continue;
					case 1u:
						return;
					}
					break;
				}
				goto case -3;
			case -3:
			case 1:
				try
				{
					break;
				}
				finally
				{
					_202D_202A_202A_200E_206E_202E_206C_202C_206F_202C_200C_202E_202A_206E_202B_202D_202C_206F_206C_206A_202A_200F_206A_200F_206D_200B_200C_202C_202B_206E_200E_206C_202D_200D_202E_202D_206D_206D_202B_202C_202E();
				}
			case -4:
			case 2:
				try
				{
					break;
				}
				finally
				{
					_200D_206E_202A_206D_200B_206A_200B_200D_202E_200C_200D_206A_202A_200B_202D_200E_202D_200B_206A_200B_200D_206F_200F_202D_202D_200C_206E_206D_206B_202C_206B_202D_206A_206B_200E_200D_200D_202A_202C_206E_202E();
				}
			case -5:
			case 3:
				try
				{
					break;
				}
				finally
				{
					_206E_202C_200F_206C_200F_206A_206D_206F_206A_206C_200B_202E_202C_202B_206B_200C_206D_206F_206B_202A_202D_202B_206C_202A_202C_200D_202B_200E_200C_206E_202C_202A_200D_200F_206E_202D_200F_202D_202E_206A_202E();
				}
			case -2:
			case -1:
			case 0:
				break;
			}
		}

		private bool MoveNext()
		{
			bool result = default(bool);
			try
			{
				int num = _200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E;
				RuntimeData runtimeData = _202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E;
				Role current = default(Role);
				Role current2 = default(Role);
				while (true)
				{
					IL_000e:
					int num2 = -26968977;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num2 ^ -1563042563)) % 30)
						{
						case 4u:
							break;
						case 28u:
							goto end_IL_0013;
						case 9u:
							_200D_206E_202A_206D_200B_206A_200B_200D_202E_200C_200D_206A_202A_200B_202D_200E_202D_200B_206A_200B_200D_206F_200F_202D_202D_200C_206E_206D_206B_202C_206B_202D_206A_206B_200E_200D_200D_202A_202C_206E_202E();
							num2 = ((int)num3 * -96996233) ^ -1433605187;
							continue;
						case 26u:
						{
							Role current3 = _206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E.Current;
							_200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E = current3;
							num2 = -1429627271;
							continue;
						}
						case 18u:
							num2 = (int)(num3 * 662953599) ^ -650454471;
							continue;
						case 15u:
							result = true;
							goto end_IL_0013;
						case 0u:
							_202D_202A_202A_200E_206E_202E_206C_202C_206F_202C_200C_202E_202A_206E_202B_202D_202C_206F_206C_206A_202A_200F_206A_200F_206D_200B_200C_202C_202B_206E_200E_206C_202D_200D_202E_202D_206D_206D_202B_202C_202E();
							_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E = default(List<Role>.Enumerator);
							num2 = (int)((num3 * 2092936688) ^ 0x2E183994);
							continue;
						case 7u:
							_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E = runtimeData.Temp.GetEnumerator();
							num2 = (int)(num3 * 298289311) ^ -219294497;
							continue;
						case 3u:
						{
							int num6;
							if (!_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E.MoveNext())
							{
								num2 = -1183404986;
								num6 = num2;
							}
							else
							{
								num2 = -259012186;
								num6 = num2;
							}
							continue;
						}
						case 12u:
							_206E_202C_200F_206C_200F_206A_206D_206F_206A_206C_200B_202E_202C_202B_206B_200C_206D_206F_206B_202A_202D_202B_206C_202A_202C_200D_202B_200E_200C_206E_202C_202A_200D_200F_206E_202D_200F_202D_202E_206A_202E();
							_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E = default(List<Role>.Enumerator);
							num2 = (int)((num3 * 336223177) ^ 0x2766CD2);
							continue;
						case 6u:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -5;
							num2 = -1594119847;
							continue;
						case 24u:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 1;
							result = true;
							num2 = ((int)num3 * -1922236986) ^ 0x3E4FA989;
							continue;
						case 14u:
						{
							int num5;
							if (_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E.MoveNext())
							{
								num2 = -1218946538;
								num5 = num2;
							}
							else
							{
								num2 = -774102989;
								num5 = num2;
							}
							continue;
						}
						case 19u:
						{
							int num4;
							if (!_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E.MoveNext())
							{
								num2 = -112196269;
								num4 = num2;
							}
							else
							{
								num2 = -166562723;
								num4 = num2;
							}
							continue;
						}
						case 23u:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -5;
							num2 = ((int)num3 * -1651153423) ^ 0x393F4252;
							continue;
						case 22u:
							result = false;
							goto end_IL_0013;
						case 10u:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -3;
							num2 = (int)((num3 * 1393803774) ^ 0x50BF15A7);
							continue;
						case 11u:
							_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E = default(List<Role>.Enumerator);
							num2 = (int)((num3 * 882823289) ^ 0x5D50783B);
							continue;
						case 29u:
							current = _206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E.Current;
							num2 = -888458726;
							continue;
						case 20u:
							switch (num)
							{
							case 3:
								break;
							default:
								goto IL_02b7;
							case 2:
								goto IL_0306;
							case 1:
								goto IL_0364;
							case 0:
								goto IL_0376;
							}
							goto case 6u;
						case 8u:
							result = true;
							goto end_IL_0013;
						case 13u:
							_200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E = current2;
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 3;
							num2 = (int)((num3 * 2082949847) ^ 0x2B96109A);
							continue;
						case 17u:
							goto IL_0306;
						case 21u:
							current2 = _206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E.Current;
							num2 = -1343098772;
							continue;
						case 1u:
							_200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E = current;
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 2;
							num2 = ((int)num3 * -460072821) ^ 0xCB88AEF;
							continue;
						case 2u:
							num2 = ((int)num3 * -530603289) ^ -573970518;
							continue;
						case 16u:
							goto IL_0364;
						case 27u:
							goto IL_0376;
						case 5u:
							_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E = runtimeData.Follow.GetEnumerator();
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -4;
							num2 = ((int)num3 * -1443928835) ^ -590633001;
							continue;
						default:
							{
								result = false;
								goto end_IL_0013;
							}
							IL_0376:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
							_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E = runtimeData.Team.GetEnumerator();
							num2 = -1857508867;
							continue;
							IL_0364:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -3;
							num2 = -356476516;
							continue;
							IL_0306:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -4;
							num2 = -125546510;
							continue;
							IL_02b7:
							num2 = (int)((num3 * 2081303410) ^ 0x18B4597D);
							continue;
						}
						goto IL_000e;
						continue;
						end_IL_0013:
						break;
					}
					break;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
			}
			return result;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _202D_202A_202A_200E_206E_202E_206C_202C_206F_202C_200C_202E_202A_206E_202B_202D_202C_206F_206C_206A_202A_200F_206A_200F_206D_200B_200C_202C_202B_206E_200E_206C_202D_200D_202E_202D_206D_206D_202B_202C_202E()
		{
			_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
			while (true)
			{
				int num = -1139138113;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1302715276)) % 3)
					{
					case 2u:
						break;
					default:
						return;
					case 1u:
						goto IL_0029;
					case 0u:
						return;
					}
					break;
					IL_0029:
					((IDisposable)_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E/*cast due to .constrained prefix*/).Dispose();
					num = (int)(num2 * 1364926552) ^ -936614078;
				}
			}
		}

		private void _200D_206E_202A_206D_200B_206A_200B_200D_202E_200C_200D_206A_202A_200B_202D_200E_202D_200B_206A_200B_200D_206F_200F_202D_202D_200C_206E_206D_206B_202C_206B_202D_206A_206B_200E_200D_200D_202A_202C_206E_202E()
		{
			_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
			((IDisposable)_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E/*cast due to .constrained prefix*/).Dispose();
		}

		private void _206E_202C_200F_206C_200F_206A_206D_206F_206A_206C_200B_202E_202C_202B_206B_200C_206D_206F_206B_202A_202D_202B_206C_202A_202C_200D_202B_200E_200C_206E_202C_202A_200D_200F_206E_202D_200F_202D_202E_206A_202E()
		{
			_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
			((IDisposable)_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E/*cast due to .constrained prefix*/).Dispose();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw _202B_206E_206C_202B_200D_206B_200F_206F_206C_200E_206F_206E_202B_206A_202D_206A_202D_202D_200B_206E_200C_200B_202E_200B_202C_206E_200D_200F_200F_200C_206A_202A_206E_206D_202E_200C_200E_206F_206B_206D_202E();
		}

		[DebuggerHidden]
		IEnumerator<Role> IEnumerable<Role>.GetEnumerator()
		{
			if (_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E == -2)
			{
				goto IL_000a;
			}
			goto IL_0047;
			IL_000a:
			int num = 851828711;
			goto IL_000f;
			IL_000f:
			_202B_202A_200B_200E_200D_206B_202C_200C_206B_202B_206A_202E_202C_206E_200D_202B_202A_202B_206E_206B_206A_206E_206C_206D_202D_200F_202D_206F_202A_202B_200D_200E_202B_200E_206E_202C_206E_202A_206C_206B_202E result = default(_202B_202A_200B_200E_200D_206B_202C_200C_206B_202B_206A_202E_202C_206E_200D_202B_202A_202B_206E_206B_206A_206E_206C_206D_202D_200F_202D_206F_202A_202B_200D_200E_202B_200E_206E_202C_206E_202A_206C_206B_202E);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3E666170)) % 6)
				{
				case 5u:
					break;
				case 1u:
					num = ((int)num2 * -636576266) ^ -471837666;
					continue;
				case 0u:
					goto IL_0047;
				case 3u:
				{
					int num3;
					int num4;
					if (_200B_202B_206E_200C_202C_200D_206F_202E_200F_206A_200C_202C_200B_202D_200F_206E_202D_206C_200B_202C_206C_206A_206E_206C_202B_206D_206E_200E_206E_202D_206E_202E_202E_202A_206D_206E_206D_202C_202D_202E == _200B_202A_206E_200F_206C_206B_200C_200F_206F_202A_200D_206C_202C_202E_202B_202D_200E_200F_200E_206C_206D_200F_206D_202B_206C_200B_206A_206E_202E_202B_202C_206E_200F_206C_206D_202A_200C_202A_200F_202A_202E(_202B_200F_202D_202A_200C_206C_202B_202B_202A_202E_206F_200D_206A_200B_206E_202D_200B_200C_202B_206C_202B_202A_202B_206C_200E_200F_206E_206F_202E_206D_200B_206B_202C_206C_202E_202D_202B_200E_206A_202E()))
					{
						num3 = 298023712;
						num4 = num3;
					}
					else
					{
						num3 = 95873374;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -412963410);
					continue;
				}
				case 2u:
					_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 0;
					result = this;
					num = (int)(num2 * 2046592344) ^ -229331181;
					continue;
				default:
					return result;
				}
				break;
			}
			goto IL_000a;
			IL_0047:
			result = new _202B_202A_200B_200E_200D_206B_202C_200C_206B_202B_206A_202E_202C_206E_200D_202B_202A_202B_206E_206B_206A_206E_206C_206D_202D_200F_202D_206F_202A_202B_200D_200E_202B_200E_206E_202C_206E_202A_206C_206B_202E(0)
			{
				_202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E = _202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E
			};
			num = 243088604;
			goto IL_000f;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<Role>)this).GetEnumerator();
		}

		static Thread _202B_200F_202D_202A_200C_206C_202B_202B_202A_202E_206F_200D_206A_200B_206E_202D_200B_200C_202B_206C_202B_202A_202B_206C_200E_200F_206E_206F_202E_206D_200B_206B_202C_206C_202E_202D_202B_200E_206A_202E()
		{
			return Thread.CurrentThread;
		}

		static int _200B_202A_206E_200F_206C_206B_200C_200F_206F_202A_200D_206C_202C_202E_202B_202D_200E_200F_200E_206C_206D_200F_206D_202B_206C_200B_206A_206E_202E_202B_202C_206E_200F_206C_206D_202A_200C_202A_200F_202A_202E(Thread P_0)
		{
			return P_0.ManagedThreadId;
		}

		static NotSupportedException _202B_206E_206C_202B_200D_206B_200F_206F_206C_200E_206F_206E_202B_206A_202D_206A_202D_202D_200B_206E_200C_200B_202E_200B_202C_206E_200D_200F_200F_200C_206A_202A_206E_206D_202E_200C_200E_206F_206B_206D_202E()
		{
			return new NotSupportedException();
		}
	}

	public const string TIMEKEY_PREF = "TIMEKEY_";

	public const string FLAG_PREF = "FLAG_";

	public bool IsInited;

	private static RuntimeData _206B_200F_200B_206F_206F_200F_200D_206A_200B_206C_200F_200C_206E_206B_206D_206F_202E_206F_202A_202D_200C_206C_206E_202E_206F_206E_206E_206E_206A_202E_206F_200F_202B_206E_202E_206B_206D_202B_202E_202A_202E;

	public GameEngine gameEngine;

	public MapUI mapUI;

	public RoleSelectUI roleSelectUI;

	public BattleField battleFieldUI;

	public List<Role> Team = new List<Role>();

	public List<Role> Follow = new List<Role>();

	public string NewbieTask = string.Empty;

	public Dictionary<ItemInstance, int> Xiangzi = new Dictionary<ItemInstance, int>();

	public Dictionary<ItemInstance, int> Items = new Dictionary<ItemInstance, int>();

	public Dictionary<string, string> KeyValues = new Dictionary<string, string>();

	internal string hash1 = string.Empty;

	internal string hash2 = string.Empty;

	public List<Role> Temp = new List<Role>();

	private int isTeamPanelRefreshed_int;

	private bool isAttackAnalog_bool;

	internal bool isBattle;

	internal int isItemsPanelRefreshed;

	internal TimeSpan LastLoadingTime;

	public bool HideCloud;

	internal int LAST_COST_MONEY;

	private List<string> _200F_206F_206E_202D_202E_206B_206D_206A_202B_202B_206F_206C_200F_200D_202B_200E_200B_202C_206D_200C_200D_202B_206A_202B_202A_202A_200F_202D_200C_206E_206C_200F_206D_202B_202D_202C_206E_202D_202B_206F_202E = new List<string>();

	private Dictionary<string, string> BattleKeyValues = new Dictionary<string, string>();

	private List<string> _202D_206E_206C_200D_206C_206D_202E_200D_202A_206F_202B_206C_206E_202B_202D_206F_200F_206D_202A_206C_202E_206E_206B_206E_200F_202B_200C_206D_206B_206E_200B_206C_200D_206C_200C_200D_200B_200B_206E_202E;

	private Dictionary<int, List<int>> VerifiedRealTimeFlags = new Dictionary<int, List<int>>();

	internal string MAINMENU_STORY;

	public MainMenu mainMenu;

	public static RuntimeData Instance
	{
		get
		{
			if (_206B_200F_200B_206F_206F_200F_200D_206A_200B_206C_200F_200C_206E_206B_206D_206F_202E_206F_202A_202D_200C_206C_206E_202E_206F_206E_206E_206E_206A_202E_206F_200F_202B_206E_202E_206B_206D_202B_202E_202A_202E == null)
			{
				while (true)
				{
					int num = 542991119;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ 0x104B07EC)) % 3)
						{
						case 2u:
							break;
						case 1u:
							_206B_200F_200B_206F_206F_200F_200D_206A_200B_206C_200F_200C_206E_206B_206D_206F_202E_206F_202A_202D_200C_206C_206E_202E_206F_206E_206E_206E_206A_202E_206F_200F_202B_206E_202E_206B_206D_202B_202E_202A_202E = new RuntimeData();
							num = ((int)num2 * -1300327834) ^ 0x89ED96C;
							continue;
						default:
							goto end_IL_0007;
						}
						break;
					}
					continue;
					end_IL_0007:
					break;
				}
			}
			return _206B_200F_200B_206F_206F_200F_200D_206A_200B_206C_200F_200C_206E_206B_206D_206F_202E_206F_202A_202D_200C_206C_206E_202E_206F_206E_206E_206E_206A_202E_206F_200F_202B_206E_202E_206B_206D_202B_202E_202A_202E;
		}
	}

	public bool IsCheat
	{
		get
		{
			bool result = default(bool);
			if (CommonSettings.MOD_KEY() >= 0)
			{
				using (List<Role>.Enumerator enumerator = Team.GetEnumerator())
				{
					Role current = default(Role);
					while (true)
					{
						IL_0272:
						int num;
						int num2;
						if (enumerator.MoveNext())
						{
							num = -2006825304;
							num2 = num;
						}
						else
						{
							num = -1218615762;
							num2 = num;
						}
						while (true)
						{
							uint num3;
							switch ((num3 = (uint)(num ^ -452460516)) % 17)
							{
							case 11u:
								num = -2006825304;
								continue;
							default:
								goto end_IL_0021;
							case 8u:
							{
								int num24;
								int num25;
								if (current.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2053407229u)] > 3000)
								{
									num24 = 360793072;
									num25 = num24;
								}
								else
								{
									num24 = 1729033257;
									num25 = num24;
								}
								num = num24 ^ ((int)num3 * -489580339);
								continue;
							}
							case 4u:
							{
								int num14;
								int num15;
								if (current.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(664072894u)] <= 3000)
								{
									num14 = -134574755;
									num15 = num14;
								}
								else
								{
									num14 = -1038931534;
									num15 = num14;
								}
								num = num14 ^ ((int)num3 * -2064539977);
								continue;
							}
							case 5u:
								result = true;
								goto IL_069c;
							case 1u:
							{
								int num18;
								int num19;
								if (current.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(136168559u)] > 3000)
								{
									num18 = -1485293425;
									num19 = num18;
								}
								else
								{
									num18 = -1567285665;
									num19 = num18;
								}
								num = num18 ^ ((int)num3 * -180832493);
								continue;
							}
							case 6u:
								current = enumerator.Current;
								num = -84505708;
								continue;
							case 7u:
							{
								int num22;
								int num23;
								if (current.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1564888282u)] <= 3000)
								{
									num22 = 1356316292;
									num23 = num22;
								}
								else
								{
									num22 = 2050120135;
									num23 = num22;
								}
								num = num22 ^ ((int)num3 * -925209230);
								continue;
							}
							case 2u:
							{
								int num8;
								int num9;
								if (current.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(400004197u)] <= 3000)
								{
									num8 = 1882535580;
									num9 = num8;
								}
								else
								{
									num8 = 1874156427;
									num9 = num8;
								}
								num = num8 ^ ((int)num3 * -630312859);
								continue;
							}
							case 9u:
							{
								int num10;
								int num11;
								if (current.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2223184606u)] > 3000)
								{
									num10 = -500724343;
									num11 = num10;
								}
								else
								{
									num10 = -569920484;
									num11 = num10;
								}
								num = num10 ^ (int)(num3 * 1066018244);
								continue;
							}
							case 16u:
							{
								int num16;
								int num17;
								if (current.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1796919217u)] <= CommonSettings.MAX_HPMP + 2000)
								{
									num16 = -662147477;
									num17 = num16;
								}
								else
								{
									num16 = -1987749883;
									num17 = num16;
								}
								num = num16 ^ ((int)num3 * -1787151624);
								continue;
							}
							case 10u:
							{
								int num6;
								int num7;
								if (current.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1306348308u)] <= CommonSettings.MAX_HPMP + 2000)
								{
									num6 = -1665417866;
									num7 = num6;
								}
								else
								{
									num6 = -1965149375;
									num7 = num6;
								}
								num = num6 ^ (int)(num3 * 1683575708);
								continue;
							}
							case 3u:
								break;
							case 15u:
							{
								int num26;
								int num27;
								if (current.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(269729863u)] > 3000)
								{
									num26 = 899506117;
									num27 = num26;
								}
								else
								{
									num26 = 1911684959;
									num27 = num26;
								}
								num = num26 ^ (int)(num3 * 1815005299);
								continue;
							}
							case 0u:
							{
								int num20;
								int num21;
								if (current.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1790491204u)] <= 3000)
								{
									num20 = -1107213485;
									num21 = num20;
								}
								else
								{
									num20 = -247450621;
									num21 = num20;
								}
								num = num20 ^ (int)(num3 * 1216404341);
								continue;
							}
							case 12u:
							{
								int num12;
								int num13;
								if (current.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2259249129u)] > 3000)
								{
									num12 = -247069369;
									num13 = num12;
								}
								else
								{
									num12 = -504425249;
									num13 = num12;
								}
								num = num12 ^ (int)(num3 * 1066346181);
								continue;
							}
							case 14u:
							{
								int num4;
								int num5;
								if (current.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1977936243u)] <= 3000)
								{
									num4 = -607007435;
									num5 = num4;
								}
								else
								{
									num4 = -1089552827;
									num5 = num4;
								}
								num = num4 ^ ((int)num3 * -512616672);
								continue;
							}
							case 13u:
								goto end_IL_0021;
							}
							goto IL_0272;
							continue;
							end_IL_0021:
							break;
						}
						break;
					}
				}
				return false;
			}
			using (List<Role>.Enumerator enumerator = Team.GetEnumerator())
			{
				SkillInstance current3 = default(SkillInstance);
				InternalSkillInstance current4 = default(InternalSkillInstance);
				while (enumerator.MoveNext())
				{
					while (true)
					{
						Role current2 = enumerator.Current;
						int num28 = -547381501;
						while (true)
						{
							uint num3;
							switch ((num3 = (uint)(num28 ^ -452460516)) % 8)
							{
							case 0u:
								num28 = -1048624271;
								continue;
							case 3u:
							{
								int num31;
								int num32;
								if (current2.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1796919217u)] == 1)
								{
									num31 = -2005630979;
									num32 = num31;
								}
								else
								{
									num31 = -547744085;
									num32 = num31;
								}
								num28 = num31 ^ ((int)num3 * -73311367);
								continue;
							}
							case 2u:
								result = true;
								num28 = -322323755;
								continue;
							case 4u:
							{
								int num33;
								int num34;
								if (current2.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2434912689u)] <= CommonSettings.MAX_HPMP + 2000)
								{
									num33 = 1577613610;
									num34 = num33;
								}
								else
								{
									num33 = 2106729190;
									num34 = num33;
								}
								num28 = num33 ^ ((int)num3 * -966666306);
								continue;
							}
							case 5u:
								break;
							case 7u:
							{
								int num29;
								int num30;
								if (current2.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(31734228u)] <= CommonSettings.MAX_HPMP + 2000)
								{
									num29 = -1060491775;
									num30 = num29;
								}
								else
								{
									num29 = -1945597512;
									num30 = num29;
								}
								num28 = num29 ^ ((int)num3 * -977078918);
								continue;
							}
							default:
								goto IL_04b3;
							case 1u:
								goto end_IL_0462;
							}
							break;
						}
						continue;
						IL_04b3:
						using (List<SkillInstance>.Enumerator enumerator2 = current2.Skills.GetEnumerator())
						{
							while (true)
							{
								IL_053d:
								int num35;
								int num36;
								if (enumerator2.MoveNext())
								{
									num35 = -1493720232;
									num36 = num35;
								}
								else
								{
									num35 = -45743460;
									num36 = num35;
								}
								while (true)
								{
									uint num3;
									switch ((num3 = (uint)(num35 ^ -452460516)) % 7)
									{
									case 0u:
										num35 = -1493720232;
										continue;
									default:
										goto end_IL_04c7;
									case 2u:
									{
										current3 = enumerator2.Current;
										int num39;
										if (current3 != null)
										{
											num35 = -311785375;
											num39 = num35;
										}
										else
										{
											num35 = -1760720794;
											num39 = num35;
										}
										continue;
									}
									case 4u:
										result = true;
										num35 = (int)((num3 * 1351164585) ^ 0x6107AAC6);
										continue;
									case 6u:
										break;
									case 5u:
									{
										int num37;
										int num38;
										if (current3.Level <= CommonSettings.MAX_SKILL_LEVEL + 3)
										{
											num37 = 415418838;
											num38 = num37;
										}
										else
										{
											num37 = 610352710;
											num38 = num37;
										}
										num35 = num37 ^ (int)(num3 * 242394992);
										continue;
									}
									case 1u:
										goto end_IL_04c7;
									case 3u:
										goto end_IL_0462;
									}
									goto IL_053d;
									continue;
									end_IL_04c7:
									break;
								}
								break;
							}
						}
						using (List<InternalSkillInstance>.Enumerator enumerator3 = current2.InternalSkills.GetEnumerator())
						{
							while (true)
							{
								IL_063c:
								int num40;
								int num41;
								if (enumerator3.MoveNext())
								{
									num40 = -1118592479;
									num41 = num40;
								}
								else
								{
									num40 = -722879072;
									num41 = num40;
								}
								while (true)
								{
									uint num3;
									switch ((num3 = (uint)(num40 ^ -452460516)) % 7)
									{
									case 0u:
										num40 = -1118592479;
										continue;
									default:
										goto end_IL_05ae;
									case 6u:
									{
										current4 = enumerator3.Current;
										int num44;
										if (current4 == null)
										{
											num40 = -170072356;
											num44 = num40;
										}
										else
										{
											num40 = -414437892;
											num44 = num40;
										}
										continue;
									}
									case 3u:
									{
										int num42;
										int num43;
										if (current4.Level > CommonSettings.MAX_INTERNALSKILL_LEVEL + 3)
										{
											num42 = 2017942812;
											num43 = num42;
										}
										else
										{
											num42 = 876664732;
											num43 = num42;
										}
										num40 = num42 ^ ((int)num3 * -1659036138);
										continue;
									}
									case 2u:
										result = true;
										num40 = (int)((num3 * 1331471475) ^ 0x1BD1A418);
										continue;
									case 5u:
										break;
									case 1u:
										goto end_IL_05ae;
									case 4u:
										goto end_IL_0462;
									}
									goto IL_063c;
									continue;
									end_IL_05ae:
									break;
								}
								break;
							}
						}
						goto IL_067e;
						continue;
						end_IL_0462:
						break;
					}
					goto IL_069c;
					IL_067e:;
				}
			}
			return false;
			IL_069c:
			return result;
		}
	}

	public int XiangziCount
	{
		get
		{
			int num = 0;
			using (Dictionary<ItemInstance, int>.Enumerator enumerator = Xiangzi.GetEnumerator())
			{
				KeyValuePair<ItemInstance, int> current = default(KeyValuePair<ItemInstance, int>);
				while (true)
				{
					IL_0049:
					int num2;
					int num3;
					if (enumerator.MoveNext())
					{
						num2 = -107156445;
						num3 = num2;
					}
					else
					{
						num2 = -723191672;
						num3 = num2;
					}
					while (true)
					{
						uint num4;
						switch ((num4 = (uint)(num2 ^ -2143363491)) % 5)
						{
						case 0u:
							num2 = -107156445;
							continue;
						default:
							goto end_IL_0015;
						case 4u:
							current = enumerator.Current;
							num2 = -2000838943;
							continue;
						case 2u:
							break;
						case 1u:
							num += num_decode(current.Value);
							num2 = (int)(num4 * 1284177531) ^ -1061066793;
							continue;
						case 3u:
							goto end_IL_0015;
						}
						goto IL_0049;
						continue;
						end_IL_0015:
						break;
					}
					break;
				}
			}
			return num;
		}
	}

	public int MaxXiangziItemCount => LuaManager.GetConfigInt(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3324232701u));

	public string CurrentNick
	{
		get
		{
			return getDataOrInit(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1137943272u), ResourceStrings.ResStrings[1073]);
		}
		set
		{
			KeyValues[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1939172493u)] = _200C_206D_202D_202B_206C_202D_202D_202E_206A_200B_202E_200D_200C_206A_206D_202A_206C_200B_206E_202E_200E_206C_206E_206C_206B_200E_200E_200B_200B_202D_206B_202D_206B_202C_202B_200C_206A_202E_200E_206C_202E((object)value);
		}
	}

	public string PrevStory
	{
		get
		{
			return getDataOrInit(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4155030606u), string.Empty);
		}
		set
		{
			KeyValues[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(982720148u)] = _200C_206D_202D_202B_206C_202D_202D_202E_206A_200B_202E_200D_200C_206A_206D_202A_206C_200B_206E_202E_200E_206C_206E_206C_206B_200E_200E_200B_200B_202D_206B_202D_206B_202C_202B_200C_206A_202E_200E_206C_202E((object)value);
		}
	}

	public int Round
	{
		get
		{
			return int.Parse(getDataOrInit(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(355178724u), global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2403377855u)));
		}
		set
		{
			if (value < 1)
			{
				goto IL_0004;
			}
			goto IL_0057;
			IL_0004:
			int num = -1699456796;
			goto IL_0009;
			IL_0009:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -217897862)) % 7)
				{
				case 0u:
					break;
				case 5u:
					value = 1;
					num = ((int)num2 * -1733654757) ^ -1474780743;
					continue;
				case 3u:
					num = (int)(num2 * 1968076037) ^ -529224442;
					continue;
				case 2u:
					goto IL_0057;
				case 6u:
					KeyValues[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2069282016u)] = value.ToString();
					num = -1072548549;
					continue;
				case 4u:
					value = 99;
					num = ((int)num2 * -1438368816) ^ -1479680229;
					continue;
				default:
					LuaManager.null_luaConfig();
					return;
				}
				break;
			}
			goto IL_0004;
			IL_0057:
			int num3;
			if (value > 99)
			{
				num = -910803153;
				num3 = num;
			}
			else
			{
				num = -2100620533;
				num3 = num;
			}
			goto IL_0009;
		}
	}

	public string UUID
	{
		get
		{
			if (KeyValues.ContainsKey(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3132251354u)))
			{
				while (true)
				{
					uint num;
					switch ((num = 918278923u) % 3)
					{
					case 2u:
						continue;
					case 1u:
						return KeyValues[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1758835768u)];
					}
					break;
				}
			}
			return string.Empty;
		}
		set
		{
			KeyValues[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(634849533u)] = _200C_206D_202D_202B_206C_202D_202D_202E_206A_200B_202E_200D_200C_206A_206D_202A_206C_200B_206E_202E_200E_206C_206E_206C_206B_200E_200E_200B_200B_202D_206B_202D_206B_202C_202B_200C_206A_202E_200E_206C_202E((object)value);
		}
	}

	public int Daode
	{
		get
		{
			return int.Parse(getDataOrInit(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(279707738u), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4019115375u)));
		}
		set
		{
			KeyValues[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(862104752u)] = value.ToString();
		}
	}

	public string femaleName
	{
		get
		{
			return getDataOrInit(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3436722750u), ResourceStrings.ResStrings[66]);
		}
		set
		{
			KeyValues[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2899980078u)] = _200C_206D_202D_202B_206C_202D_202D_202E_206A_200B_202E_200D_200C_206A_206D_202A_206C_200B_206E_202E_200E_206C_206E_206C_206B_200E_200E_200B_200B_202D_206B_202D_206B_202C_202B_200C_206A_202E_200E_206C_202E((object)value);
		}
	}

	public string maleName
	{
		get
		{
			return getDataOrInit(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3432324715u), ResourceStrings.ResStrings[112]);
		}
		set
		{
			KeyValues[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3432324715u)] = _200C_206D_202D_202B_206C_202D_202D_202E_206A_200B_202E_200D_200C_206A_206D_202A_206C_200B_206E_202E_200E_206C_206E_206C_206B_200E_200E_200B_200B_202D_206B_202D_206B_202C_202B_200C_206A_202E_200E_206C_202E((object)value);
		}
	}

	public int Money
	{
		get
		{
			return int.Parse(getDataOrInit(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(361517175u), global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2183687527u)));
		}
		set
		{
			if (value < 0)
			{
				while (true)
				{
					int num = -811739368;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ -1501255262)) % 3)
						{
						case 0u:
							break;
						case 1u:
							value = 0;
							num = (int)(num2 * 1117505124) ^ -1155842910;
							continue;
						default:
							goto end_IL_0004;
						}
						break;
					}
					continue;
					end_IL_0004:
					break;
				}
			}
			KeyValues[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(361517175u)] = value.ToString();
		}
	}

	public int Yuanbao
	{
		get
		{
			return ModData.Yuanbao;
		}
		set
		{
			if (value < 0)
			{
				goto IL_0004;
			}
			goto IL_003c;
			IL_0004:
			int num = 1211115200;
			goto IL_0009;
			IL_0009:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6D2C511F)) % 4)
				{
				case 0u:
					break;
				default:
					return;
				case 3u:
					value = 0;
					num = ((int)num2 * -1018565745) ^ -1161563936;
					continue;
				case 2u:
					goto IL_003c;
				case 1u:
					return;
				}
				break;
			}
			goto IL_0004;
			IL_003c:
			ModData.Yuanbao = value;
			num = 1989778846;
			goto IL_0009;
		}
	}

	public DateTime Date
	{
		get
		{
			if (!KeyValues.ContainsKey(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3158520052u)))
			{
				goto IL_0017;
			}
			goto IL_006a;
			IL_0017:
			int num = -1544722112;
			goto IL_001c;
			IL_001c:
			string s = default(string);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -513206172)) % 5)
				{
				case 0u:
					break;
				case 2u:
					s = global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4069221506u);
					num = ((int)num2 * -402216234) ^ 0x70111107;
					continue;
				case 4u:
					num = ((int)num2 * -676467703) ^ 0x237C375B;
					continue;
				case 1u:
					goto IL_006a;
				default:
					return Tools.GetDateTime(long.Parse(s));
				}
				break;
			}
			goto IL_0017;
			IL_006a:
			s = KeyValues[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(802506112u)];
			num = -771444216;
			goto IL_001c;
		}
		set
		{
			if (!KeyValues.ContainsKey(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2004836147u)))
			{
				goto IL_0017;
			}
			goto IL_006b;
			IL_0017:
			int num = -925746617;
			goto IL_001c;
			IL_001c:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -757425152)) % 4)
				{
				case 2u:
					break;
				default:
					return;
				case 3u:
					KeyValues.Add(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(802506112u), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4069221506u));
					num = (int)((num2 * 1863246848) ^ 0x1D88C2B4);
					continue;
				case 0u:
					goto IL_006b;
				case 1u:
					return;
				}
				break;
			}
			goto IL_0017;
			IL_006b:
			KeyValues[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1874883973u)] = Tools.GetTimeStamp(value).ToString();
			num = -1983498711;
			goto IL_001c;
		}
	}

	public string GameMode
	{
		get
		{
			return getDataOrInit(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3583266687u), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2506358572u));
		}
		set
		{
			KeyValues[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4215495534u)] = _200C_206D_202D_202B_206C_202D_202D_202E_206A_200B_202E_200D_200C_206A_206D_202A_206C_200B_206E_202E_200E_206C_206E_206C_206B_200E_200E_200B_200B_202D_206B_202D_206B_202C_202B_200C_206A_202E_200E_206C_202E((object)value);
		}
	}

	public bool AutoSaveOnly
	{
		get
		{
			return bool.Parse(getDataOrInit(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3385120205u), global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3152989164u)));
		}
		set
		{
			KeyValues[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3385120205u)] = value.ToString();
		}
	}

	public string GameModeChinese
	{
		get
		{
			if (AutoSaveOnly)
			{
				goto IL_000b;
			}
			goto IL_0103;
			IL_000b:
			int num = 619670141;
			goto IL_0010;
			IL_0010:
			string gameMode = default(string);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1769A300)) % 9)
				{
				case 4u:
					break;
				case 3u:
					goto IL_0049;
				case 7u:
					return global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2139032424u);
				case 2u:
					return global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3035061610u);
				case 1u:
					return global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4020802338u);
				case 6u:
					goto IL_00c0;
				case 8u:
					return global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(146864838u);
				case 0u:
					goto IL_0103;
				default:
					return global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1016847949u);
				}
				break;
				IL_00c0:
				int num3;
				if (!_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(gameMode, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2143033974u)))
				{
					num = 846849632;
					num3 = num;
				}
				else
				{
					num = 731448074;
					num3 = num;
				}
				continue;
				IL_0049:
				int num4;
				if (!_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(gameMode, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2038653673u)))
				{
					num = 2048148881;
					num4 = num;
				}
				else
				{
					num = 1112126422;
					num4 = num;
				}
			}
			goto IL_000b;
			IL_0103:
			gameMode = GameMode;
			int num5;
			if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(gameMode, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3019957305u)))
			{
				num = 887253849;
				num5 = num;
			}
			else
			{
				num = 593288218;
				num5 = num;
			}
			goto IL_0010;
		}
	}

	public bool FriendlyFire
	{
		get
		{
			return bool.Parse(getDataOrInit(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1793327765u), global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3797410649u)));
		}
		set
		{
			KeyValues[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2327709889u)] = value.ToString();
		}
	}

	public string Menpai
	{
		get
		{
			return getDataOrInit(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(854191004u), string.Empty);
		}
		set
		{
			KeyValues[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(854191004u)] = _200C_206D_202D_202B_206C_202D_202D_202E_206A_200B_202E_200D_200C_206A_206D_202A_206C_200B_206E_202E_200E_206C_206E_206C_206B_200E_200E_200B_200B_202D_206B_202D_206B_202C_202B_200C_206A_202E_200E_206C_202E((object)value);
		}
	}

	public string Log
	{
		get
		{
			return getDataOrInit(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1275387923u), string.Empty);
		}
		set
		{
			KeyValues[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3647844642u)] = _200C_206D_202D_202B_206C_202D_202D_202E_206A_200B_202E_200D_200C_206A_206D_202A_206C_200B_206E_202E_200E_206C_206E_206C_206B_200E_200E_200B_200B_202D_206B_202D_206B_202C_202B_200C_206A_202E_200E_206C_202E((object)value);
		}
	}

	public int DodgePoint
	{
		get
		{
			return int.Parse(getDataOrInit(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4073828096u), global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(838530381u)));
		}
		set
		{
			KeyValues[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2697835527u)] = value.ToString();
		}
	}

	public int biliPoint
	{
		get
		{
			return int.Parse(getDataOrInit(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(392190746u), global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(91161593u)));
		}
		set
		{
			KeyValues[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(392190746u)] = value.ToString();
		}
	}

	public int Rank
	{
		get
		{
			return int.Parse(getDataOrInit(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1533927897u), global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(838530381u)));
		}
		set
		{
			KeyValues[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1109888584u)] = value.ToString();
		}
	}

	public string CurrentBigMap
	{
		get
		{
			return getDataOrInit(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3129512498u), ResourceStrings.ResStrings[2]);
		}
		set
		{
			KeyValues[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3786223581u)] = _200C_206D_202D_202B_206C_202D_202D_202E_206A_200B_202E_200D_200C_206A_206D_202A_206C_200B_206E_202E_200E_206C_206E_206C_206B_200E_200E_200B_200B_202D_206B_202D_206B_202C_202B_200C_206A_202E_200E_206C_202E((object)value);
		}
	}

	public string TrialRoles
	{
		get
		{
			return getDataOrInit(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4084212177u), string.Empty);
		}
		set
		{
			KeyValues[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(865611507u)] = _200C_206D_202D_202B_206C_202D_202D_202E_206A_200B_202E_200D_200C_206A_206D_202A_206C_200B_206E_202E_200E_206C_206E_206C_206B_200E_200E_200B_200B_202D_206B_202D_206B_202C_202B_200C_206A_202E_200E_206C_202E((object)value);
		}
	}

	internal int isTeamPanelRefreshed
	{
		get
		{
			return isTeamPanelRefreshed_int;
		}
		set
		{
			isTeamPanelRefreshed_int = value;
		}
	}

	public bool isAttackAnalog
	{
		get
		{
			return isAttackAnalog_bool;
		}
		internal set
		{
			isAttackAnalog_bool = value;
		}
	}

	public string TrialPalRoles
	{
		get
		{
			return getDataOrInit(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1629407887u), string.Empty);
		}
		set
		{
			KeyValues[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2190263089u)] = _200C_206D_202D_202B_206C_202D_202D_202E_206A_200B_202E_200D_200C_206A_206D_202A_206C_200B_206E_202E_200E_206C_206E_206C_206B_200E_200E_200B_200B_202D_206B_202D_206B_202C_202B_200C_206A_202E_200E_206C_202E((object)value);
		}
	}

	private RuntimeData()
	{
	}

	static RuntimeData()
	{
	}

	public void Init()
	{
		if (_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(hash1))
		{
			goto IL_000d;
		}
		goto IL_0081;
		IL_000d:
		int num = 381226313;
		goto IL_0012;
		IL_0012:
		string text = default(string);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x458F2B0A)) % 9)
			{
			case 0u:
				break;
			case 4u:
				text = ResourceStrings.ResStrings[329];
				num = (int)((num2 * 951831653) ^ 0x6B29FA5);
				continue;
			case 8u:
				Money = 100;
				num = ((int)num2 * -958741909) ^ -1203109126;
				continue;
			case 2u:
				goto IL_0081;
			case 3u:
				SetLocation(ResourceStrings.ResStrings[2], text);
				num = 1142946605;
				continue;
			case 1u:
			{
				int num3;
				int num4;
				if (_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(text))
				{
					num3 = -274306244;
					num4 = num3;
				}
				else
				{
					num3 = -286111281;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 1493810529);
				continue;
			}
			case 5u:
				return;
			case 6u:
				Clear();
				text = LuaManager.GetConfig(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3377556107u));
				num = ((int)num2 * -898148598) ^ 0x3173257D;
				continue;
			default:
				LastLoadingTime = new TimeSpan(DateTime.Now.Ticks);
				HideCloud = ModData.HideCloud == 1;
				IsInited = true;
				return;
			}
			break;
		}
		goto IL_000d;
		IL_0081:
		gameEngine = new GameEngine();
		num = 1669478171;
		goto IL_0012;
	}

	public void Clear()
	{
		IsInited = false;
		Team.Clear();
		while (true)
		{
			int num = 1125846499;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x68D2F104)) % 11)
				{
				case 9u:
					break;
				default:
					return;
				case 0u:
					Items.Clear();
					Xiangzi.Clear();
					num = ((int)num2 * -340732865) ^ -779926592;
					continue;
				case 1u:
					Temp.Clear();
					num = (int)((num2 * 581298152) ^ 0x6B7A16);
					continue;
				case 10u:
					VerifiedRealTimeFlags.Clear();
					InitRoleValues();
					num = ((int)num2 * -1448861018) ^ 0x448B5DE7;
					continue;
				case 2u:
					_200F_206F_206E_202D_202E_206B_206D_206A_202B_202B_206F_206C_200F_200D_202B_200E_200B_202C_206D_200C_200D_202B_206A_202B_202A_202A_200F_202D_200C_206E_206C_200F_206D_202B_202D_202C_206E_202D_202B_206F_202E.Clear();
					num = ((int)num2 * -935400805) ^ -1692844580;
					continue;
				case 3u:
					MapRoleUI.currentRoleUI = null;
					num = ((int)num2 * -751517834) ^ 0x78E45A2D;
					continue;
				case 4u:
					HideCloud = false;
					MapLocationUI.currentLocationUI = null;
					num = (int)((num2 * 837335987) ^ 0x6915ADBA);
					continue;
				case 8u:
					Follow.Clear();
					num = (int)((num2 * 2089645813) ^ 0x3809C784);
					continue;
				case 7u:
					KeyValues.Clear();
					BattleKeyValues.Clear();
					num = (int)((num2 * 1026507941) ^ 0xCD4F522);
					continue;
				case 6u:
					TrialRoles = string.Empty;
					TrialPalRoles = string.Empty;
					NewbieTask = string.Empty;
					Rank = 0;
					num = ((int)num2 * -1537170637) ^ 0xC12BF30;
					continue;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	public bool InTeam(string roleKey)
	{
		bool result = default(bool);
		using (List<Role>.Enumerator enumerator = Team.GetEnumerator())
		{
			while (true)
			{
				IL_0086:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 1007643633;
					num2 = num;
				}
				else
				{
					num = 843345951;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x255EC782)) % 6)
					{
					case 2u:
						num = 1007643633;
						continue;
					default:
						goto end_IL_0013;
					case 3u:
					{
						int num4;
						if (!_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(enumerator.Current.Key, roleKey))
						{
							num = 1276412623;
							num4 = num;
						}
						else
						{
							num = 846383934;
							num4 = num;
						}
						continue;
					}
					case 0u:
						result = true;
						num = (int)((num3 * 2069393875) ^ 0x12C994C);
						continue;
					case 1u:
						break;
					case 5u:
						goto end_IL_0013;
					case 4u:
						goto IL_014f;
					}
					goto IL_0086;
					continue;
					end_IL_0013:
					break;
				}
				break;
			}
		}
		using (List<Role>.Enumerator enumerator2 = Follow.GetEnumerator())
		{
			while (true)
			{
				IL_00eb:
				int num5;
				int num6;
				if (!enumerator2.MoveNext())
				{
					num5 = 1571305824;
					num6 = num5;
				}
				else
				{
					num5 = 271197821;
					num6 = num5;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num5 ^ 0x255EC782)) % 5)
					{
					case 3u:
						num5 = 271197821;
						continue;
					default:
						goto end_IL_00c6;
					case 0u:
						break;
					case 2u:
						result = true;
						goto IL_014f;
					case 4u:
					{
						int num7;
						if (_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(enumerator2.Current.Key, roleKey))
						{
							num5 = 296021643;
							num7 = num5;
						}
						else
						{
							num5 = 1017238598;
							num7 = num5;
						}
						continue;
					}
					case 1u:
						goto end_IL_00c6;
					}
					goto IL_00eb;
					continue;
					end_IL_00c6:
					break;
				}
				break;
			}
		}
		return false;
		IL_014f:
		return result;
	}

	public void ResetTeam()
	{
		using List<Role>.Enumerator enumerator = Team.GetEnumerator();
		while (true)
		{
			int num;
			int num2;
			if (!enumerator.MoveNext())
			{
				num = 583620237;
				num2 = num;
			}
			else
			{
				num = 729054598;
				num2 = num;
			}
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num ^ 0x670B1904)) % 4)
				{
				case 0u:
					num = 729054598;
					continue;
				default:
					return;
				case 2u:
					enumerator.Current.Reset();
					num = 117335591;
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

	public bool NameInTeam(string roleName)
	{
		bool result = default(bool);
		using (List<Role>.Enumerator enumerator = Team.GetEnumerator())
		{
			while (true)
			{
				IL_003c:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -1342416176;
					num2 = num;
				}
				else
				{
					num = -1029039936;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -1663172753)) % 6)
					{
					case 4u:
						num = -1029039936;
						continue;
					default:
						goto end_IL_0013;
					case 3u:
						break;
					case 2u:
						result = true;
						num = ((int)num3 * -1342964873) ^ 0x59CE19AB;
						continue;
					case 1u:
					{
						int num4;
						if (_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(enumerator.Current.Name, roleName))
						{
							num = -2103599919;
							num4 = num;
						}
						else
						{
							num = -1384430448;
							num4 = num;
						}
						continue;
					}
					case 5u:
						goto end_IL_0013;
					case 0u:
						goto IL_0165;
					}
					goto IL_003c;
					continue;
					end_IL_0013:
					break;
				}
				break;
			}
		}
		using (List<Role>.Enumerator enumerator2 = Follow.GetEnumerator())
		{
			while (true)
			{
				IL_0125:
				int num5;
				int num6;
				if (!enumerator2.MoveNext())
				{
					num5 = -2035891559;
					num6 = num5;
				}
				else
				{
					num5 = -525553866;
					num6 = num5;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num5 ^ -1663172753)) % 6)
					{
					case 3u:
						num5 = -525553866;
						continue;
					default:
						goto end_IL_00c6;
					case 1u:
					{
						int num7;
						if (!_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(enumerator2.Current.Name, roleName))
						{
							num5 = -1025484175;
							num7 = num5;
						}
						else
						{
							num5 = -1221398702;
							num7 = num5;
						}
						continue;
					}
					case 2u:
						break;
					case 5u:
						result = true;
						num5 = ((int)num3 * -1365045827) ^ -2099691414;
						continue;
					case 0u:
						goto end_IL_00c6;
					case 4u:
						goto IL_0165;
					}
					goto IL_0125;
					continue;
					end_IL_00c6:
					break;
				}
				break;
			}
		}
		return false;
		IL_0165:
		return result;
	}

	public Role GetTeamRole(string roleKey)
	{
		using (List<Role>.Enumerator enumerator = Team.GetEnumerator())
		{
			Role current = default(Role);
			while (true)
			{
				IL_005e:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -575358257;
					num2 = num;
				}
				else
				{
					num = -1694190490;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -245583885)) % 6)
					{
					case 3u:
						num = -1694190490;
						continue;
					default:
						goto end_IL_0013;
					case 1u:
						current = enumerator.Current;
						num = -1396156987;
						continue;
					case 5u:
						return current;
					case 4u:
						break;
					case 2u:
					{
						int num4;
						int num5;
						if (!_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current.Key, roleKey))
						{
							num4 = -2124105107;
							num5 = num4;
						}
						else
						{
							num4 = -1765327550;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -1339827641);
						continue;
					}
					case 0u:
						goto end_IL_0013;
					}
					goto IL_005e;
					continue;
					end_IL_0013:
					break;
				}
				break;
			}
		}
		return null;
	}

	public Role GetFollowRole(string roleKey)
	{
		using (List<Role>.Enumerator enumerator = Follow.GetEnumerator())
		{
			Role current = default(Role);
			Role result = default(Role);
			while (true)
			{
				IL_0085:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -1338347428;
					num2 = num;
				}
				else
				{
					num = -1965548762;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -187463247)) % 6)
					{
					case 2u:
						num = -1338347428;
						continue;
					default:
						goto end_IL_0013;
					case 1u:
					{
						current = enumerator.Current;
						int num4;
						if (_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current.Key, roleKey))
						{
							num = -1575711359;
							num4 = num;
						}
						else
						{
							num = -165577008;
							num4 = num;
						}
						continue;
					}
					case 4u:
						result = current;
						num = ((int)num3 * -94798586) ^ 0x1FE38861;
						continue;
					case 3u:
						break;
					case 5u:
						goto end_IL_0013;
					case 0u:
						return result;
					}
					goto IL_0085;
					continue;
					end_IL_0013:
					break;
				}
				break;
			}
		}
		return null;
	}

	public void addTeamMember(string roleKey)
	{
		if (addTeamMemberFromTemp(roleKey))
		{
			goto IL_0009;
		}
		goto IL_0067;
		IL_0009:
		int num = -1311905747;
		goto IL_000e;
		IL_000e:
		Role role = default(Role);
		Role role2 = default(Role);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1007567957)) % 13)
			{
			case 10u:
				break;
			default:
				return;
			case 2u:
				return;
			case 12u:
				goto IL_0067;
			case 9u:
			{
				int num5;
				int num6;
				if (role.Skills.Count > 0)
				{
					num5 = 1535873437;
					num6 = num5;
				}
				else
				{
					num5 = 66146099;
					num6 = num5;
				}
				num = num5 ^ (int)(num2 * 660667089);
				continue;
			}
			case 4u:
			{
				int num9;
				int num10;
				if (role2.EquippedInternalSkill != null)
				{
					num9 = -29586259;
					num10 = num9;
				}
				else
				{
					num9 = -1708056647;
					num10 = num9;
				}
				num = num9 ^ ((int)num2 * -1207797737);
				continue;
			}
			case 0u:
				goto IL_00cf;
			case 3u:
				role2 = role.Clone();
				num = (int)((num2 * 141481592) ^ 0x18039CE3);
				continue;
			case 8u:
				Team.Add(role2);
				num = (int)((num2 * 504630007) ^ 0x50D46653);
				continue;
			case 7u:
			{
				int num7;
				int num8;
				if (role == null)
				{
					num7 = 300122353;
					num8 = num7;
				}
				else
				{
					num7 = 2007882017;
					num8 = num7;
				}
				num = num7 ^ ((int)num2 * -591837530);
				continue;
			}
			case 5u:
				return;
			case 6u:
			{
				int num3;
				int num4;
				if (role.InternalSkills.Count <= 0)
				{
					num3 = 397404443;
					num4 = num3;
				}
				else
				{
					num3 = 286982883;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -1651584975);
				continue;
			}
			case 1u:
				role = ResourceManager.Get<Role>(roleKey);
				num = ((int)num2 * -621898175) ^ -410280787;
				continue;
			case 11u:
				return;
			}
			break;
			IL_00cf:
			int num11;
			if (!InTeamOnly(roleKey))
			{
				num = -765297259;
				num11 = num;
			}
			else
			{
				num = -2048959583;
				num11 = num;
			}
		}
		goto IL_0009;
		IL_0067:
		int num12;
		if (!addTeamMemberFromFollow(roleKey))
		{
			num = -552530326;
			num12 = num;
		}
		else
		{
			num = -1062305136;
			num12 = num;
		}
		goto IL_000e;
	}

	public void addTeamMember(string roleKey, string changeName)
	{
		Role role = null;
		bool flag = false;
		Role role2 = default(Role);
		while (true)
		{
			int num = 145544416;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7A2CF9D0)) % 23)
				{
				case 16u:
					break;
				default:
					return;
				case 22u:
				{
					int num19;
					if (flag)
					{
						num = 676723781;
						num19 = num;
					}
					else
					{
						num = 1925814940;
						num19 = num;
					}
					continue;
				}
				case 2u:
				{
					role2 = ResourceManager.Get<Role>(roleKey);
					int num4;
					int num5;
					if (role2 == null)
					{
						num4 = -13090699;
						num5 = num4;
					}
					else
					{
						num4 = -1023007595;
						num5 = num4;
					}
					num = num4 ^ (int)(num2 * 1914222552);
					continue;
				}
				case 15u:
				{
					int num9;
					int num10;
					if (role2.InternalSkills.Count <= 0)
					{
						num9 = 708818332;
						num10 = num9;
					}
					else
					{
						num9 = 338812046;
						num10 = num9;
					}
					num = num9 ^ (int)(num2 * 977237589);
					continue;
				}
				case 14u:
					role.Name = changeName;
					num = (int)((num2 * 1141489210) ^ 0x13857A73);
					continue;
				case 20u:
				{
					int num20;
					int num21;
					if (!addTeamMemberFromTemp(roleKey))
					{
						num20 = -1321126704;
						num21 = num20;
					}
					else
					{
						num20 = -1146811206;
						num21 = num20;
					}
					num = num20 ^ (int)(num2 * 1359448813);
					continue;
				}
				case 13u:
				{
					int num12;
					if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(roleKey, ResourceStrings.ResStrings[9]))
					{
						num = 701816151;
						num12 = num;
					}
					else
					{
						num = 552612150;
						num12 = num;
					}
					continue;
				}
				case 7u:
				{
					int num15;
					int num16;
					if (role2.Skills.Count > 0)
					{
						num15 = -1666877956;
						num16 = num15;
					}
					else
					{
						num15 = -2127613545;
						num16 = num15;
					}
					num = num15 ^ ((int)num2 * -691095010);
					continue;
				}
				case 18u:
					maleName = changeName;
					num = ((int)num2 * -1246817743) ^ 0x3D675D33;
					continue;
				case 8u:
					role = role2.Clone();
					num = ((int)num2 * -1335443895) ^ 0x497F3C5C;
					continue;
				case 11u:
					changeName = role.Name;
					num = 1882675129;
					continue;
				case 12u:
				{
					int num6;
					int num7;
					if (role.EquippedInternalSkill == null)
					{
						num6 = 483584453;
						num7 = num6;
					}
					else
					{
						num6 = 549809794;
						num7 = num6;
					}
					num = num6 ^ (int)(num2 * 2083231424);
					continue;
				}
				case 5u:
				{
					int num17;
					int num18;
					if (!InTeamOnly(roleKey))
					{
						num17 = 1555806838;
						num18 = num17;
					}
					else
					{
						num17 = 1954289745;
						num18 = num17;
					}
					num = num17 ^ ((int)num2 * -1586774073);
					continue;
				}
				case 4u:
					role = GetTeamRole(roleKey);
					num = (int)(num2 * 1278062107) ^ -1485959643;
					continue;
				case 3u:
				{
					int num13;
					int num14;
					if (!_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(changeName))
					{
						num13 = -1558260879;
						num14 = num13;
					}
					else
					{
						num13 = -861376638;
						num14 = num13;
					}
					num = num13 ^ ((int)num2 * -170754264);
					continue;
				}
				case 17u:
				{
					int num11;
					if (flag)
					{
						num = 1212173109;
						num11 = num;
					}
					else
					{
						num = 1942498146;
						num11 = num;
					}
					continue;
				}
				case 1u:
					femaleName = changeName;
					return;
				case 0u:
				{
					int num8;
					if (!addTeamMemberFromFollow(roleKey))
					{
						num = 367940387;
						num8 = num;
					}
					else
					{
						num = 1972164405;
						num8 = num;
					}
					continue;
				}
				case 10u:
					flag = true;
					num = ((int)num2 * -254421040) ^ -1488950397;
					continue;
				case 19u:
				{
					int num3;
					if (!_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(roleKey, ResourceStrings.ResStrings[0]))
					{
						num = 1942498146;
						num3 = num;
					}
					else
					{
						num = 744916977;
						num3 = num;
					}
					continue;
				}
				case 9u:
					role = GetTeamRole(roleKey);
					flag = true;
					num = (int)((num2 * 196405149) ^ 0x3CDC96D1);
					continue;
				case 6u:
					flag = true;
					Team.Add(role);
					num = ((int)num2 * -210237386) ^ 0x4F83D409;
					continue;
				case 21u:
					return;
				}
				break;
			}
		}
	}

	public void addFollowMember(string roleKey)
	{
		if (addFollowMemberFromTemp(roleKey))
		{
			goto IL_0009;
		}
		goto IL_0068;
		IL_0009:
		int num = 2035500786;
		goto IL_000e;
		IL_000e:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x574D0BB9)) % 5)
			{
			case 0u:
				break;
			default:
				return;
			case 3u:
				return;
			case 2u:
				Follow.Add(ResourceManager.Get<Role>(roleKey).Clone());
				num = (int)(num2 * 1100975272) ^ -1931432892;
				continue;
			case 4u:
				goto IL_0068;
			case 1u:
				return;
			}
			break;
		}
		goto IL_0009;
		IL_0068:
		int num3;
		if (InTeam(roleKey))
		{
			num = 1318618948;
			num3 = num;
		}
		else
		{
			num = 1601657945;
			num3 = num;
		}
		goto IL_000e;
	}

	public void addFollowMember(string roleKey, string changeName)
	{
		if (addFollowMemberFromTemp(roleKey))
		{
			goto IL_000c;
		}
		goto IL_011c;
		IL_000c:
		int num = -1220498762;
		goto IL_0011;
		IL_0011:
		Role role = default(Role);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1216015519)) % 13)
			{
			case 2u:
				break;
			default:
				return;
			case 5u:
				femaleName = changeName;
				num = (int)(num2 * 1031237363) ^ -225818820;
				continue;
			case 4u:
				role.Name = changeName;
				num = ((int)num2 * -565371112) ^ -375864802;
				continue;
			case 0u:
			{
				int num9;
				int num10;
				if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(roleKey, ResourceStrings.ResStrings[9]))
				{
					num9 = 194503208;
					num10 = num9;
				}
				else
				{
					num9 = 90249167;
					num10 = num9;
				}
				num = num9 ^ ((int)num2 * -21715194);
				continue;
			}
			case 11u:
				femaleName = changeName;
				num = (int)(num2 * 1896804344) ^ -1495399923;
				continue;
			case 8u:
			{
				int num5;
				int num6;
				if (!_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(changeName))
				{
					num5 = 1091297855;
					num6 = num5;
				}
				else
				{
					num5 = 1454348559;
					num6 = num5;
				}
				num = num5 ^ ((int)num2 * -2016259772);
				continue;
			}
			case 6u:
				return;
			case 10u:
				role = ResourceManager.Get<Role>(roleKey).Clone();
				num = (int)(num2 * 1605972876) ^ -2002837841;
				continue;
			case 12u:
				goto IL_011c;
			case 7u:
			{
				GetFollowRole(roleKey).Name = changeName;
				int num7;
				int num8;
				if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(roleKey, ResourceStrings.ResStrings[9]))
				{
					num7 = 203858283;
					num8 = num7;
				}
				else
				{
					num7 = 1111391443;
					num8 = num7;
				}
				num = num7 ^ (int)(num2 * 2105046955);
				continue;
			}
			case 3u:
				Follow.Add(role);
				num = (int)((num2 * 934019428) ^ 0x2F7295F6);
				continue;
			case 1u:
			{
				int num3;
				int num4;
				if (!_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(changeName))
				{
					num3 = 1016492913;
					num4 = num3;
				}
				else
				{
					num3 = 1603297351;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 490174438);
				continue;
			}
			case 9u:
				return;
			}
			break;
		}
		goto IL_000c;
		IL_011c:
		int num11;
		if (InTeam(roleKey))
		{
			num = -181070877;
			num11 = num;
		}
		else
		{
			num = -2050995280;
			num11 = num;
		}
		goto IL_0011;
	}

	public void removeTeamMember(string roleKey)
	{
		Role role = null;
		using (List<Role>.Enumerator enumerator = Team.GetEnumerator())
		{
			Role current = default(Role);
			while (true)
			{
				IL_003b:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -303787536;
					num2 = num;
				}
				else
				{
					num = -164240915;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -1266124962)) % 5)
					{
					case 2u:
						num = -164240915;
						continue;
					default:
						goto end_IL_0015;
					case 0u:
						break;
					case 3u:
						role = current;
						goto end_IL_0015;
					case 4u:
					{
						current = enumerator.Current;
						int num4;
						if (!_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current.Key, roleKey))
						{
							num = -1391787531;
							num4 = num;
						}
						else
						{
							num = -1755387050;
							num4 = num;
						}
						continue;
					}
					case 1u:
						goto end_IL_0015;
					}
					goto IL_003b;
					continue;
					end_IL_0015:
					break;
				}
				break;
			}
		}
		if (role == null)
		{
			return;
		}
		using (List<ItemInstance>.Enumerator enumerator2 = role.Equipment.GetEnumerator())
		{
			ItemInstance current2 = default(ItemInstance);
			while (true)
			{
				IL_00df:
				int num5;
				int num6;
				if (enumerator2.MoveNext())
				{
					num5 = -334855504;
					num6 = num5;
				}
				else
				{
					num5 = -1523437855;
					num6 = num5;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num5 ^ -1266124962)) % 5)
					{
					case 2u:
						num5 = -334855504;
						continue;
					default:
						goto end_IL_00b9;
					case 0u:
						break;
					case 4u:
						addItem(current2);
						num5 = ((int)num3 * -2088055957) ^ -2045892421;
						continue;
					case 1u:
						current2 = enumerator2.Current;
						num5 = -2117665178;
						continue;
					case 3u:
						goto end_IL_00b9;
					}
					goto IL_00df;
					continue;
					end_IL_00b9:
					break;
				}
				break;
			}
		}
		Team.Remove(role);
	}

	public void removeAllTeamMember()
	{
		isTeamPanelRefreshed = 0;
		Role item = null;
		using (List<Role>.Enumerator enumerator = Team.GetEnumerator())
		{
			ItemInstance current2 = default(ItemInstance);
			while (enumerator.MoveNext())
			{
				while (true)
				{
					Role current = enumerator.Current;
					int num;
					int num2;
					if (_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current.Key, ResourceStrings.ResStrings[0]))
					{
						num = 1055335737;
						num2 = num;
					}
					else
					{
						num = 1071020702;
						num2 = num;
					}
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num ^ 0x33139AF5)) % 4)
						{
						case 2u:
							num = 1470411648;
							continue;
						case 1u:
							break;
						case 0u:
							goto IL_0072;
						default:
							goto IL_0089;
						}
						break;
					}
					continue;
					IL_0089:
					using (List<ItemInstance>.Enumerator enumerator2 = current.Equipment.GetEnumerator())
					{
						while (true)
						{
							IL_00eb:
							int num4;
							int num5;
							if (enumerator2.MoveNext())
							{
								num4 = 1467076306;
								num5 = num4;
							}
							else
							{
								num4 = 1784605289;
								num5 = num4;
							}
							while (true)
							{
								uint num3;
								switch ((num3 = (uint)(num4 ^ 0x33139AF5)) % 5)
								{
								case 0u:
									num4 = 1467076306;
									continue;
								default:
									goto end_IL_009c;
								case 1u:
									current2 = enumerator2.Current;
									num4 = 172751986;
									continue;
								case 2u:
									addItem(current2);
									num4 = ((int)num3 * -502063969) ^ 0x756806C5;
									continue;
								case 3u:
									break;
								case 4u:
									goto end_IL_009c;
								}
								goto IL_00eb;
								continue;
								end_IL_009c:
								break;
							}
							break;
						}
					}
					break;
					IL_0072:
					item = current;
					break;
				}
			}
		}
		Team.Clear();
		Team.Add(item);
	}

	public void removeFollowMember(string roleKey)
	{
		Role role = null;
		using (List<Role>.Enumerator enumerator = Follow.GetEnumerator())
		{
			Role current = default(Role);
			while (true)
			{
				IL_003e:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -80413611;
					num2 = num;
				}
				else
				{
					num = -1398139754;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -205296544)) % 6)
					{
					case 4u:
						num = -1398139754;
						continue;
					default:
						goto end_IL_0015;
					case 0u:
						break;
					case 3u:
						goto end_IL_0015;
					case 1u:
						role = current;
						num = ((int)num3 * -1329343203) ^ -686636238;
						continue;
					case 2u:
					{
						current = enumerator.Current;
						int num4;
						if (_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current.Key, roleKey))
						{
							num = -2029215755;
							num4 = num;
						}
						else
						{
							num = -2014712624;
							num4 = num;
						}
						continue;
					}
					case 5u:
						goto end_IL_0015;
					}
					goto IL_003e;
					continue;
					end_IL_0015:
					break;
				}
				break;
			}
		}
		if (role == null)
		{
			return;
		}
		while (true)
		{
			int num5 = -2025349644;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num5 ^ -205296544)) % 3)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_00d9;
				case 0u:
					return;
				}
				break;
				IL_00d9:
				Follow.Remove(role);
				num5 = (int)(num3 * 822701711) ^ -793243030;
			}
		}
	}

	public bool isLocationInTask(string location)
	{
		if (_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(NewbieTask))
		{
			goto IL_000d;
		}
		goto IL_006f;
		IL_000d:
		int num = -517818882;
		goto IL_0012;
		IL_0012:
		Task task = default(Task);
		TaskLocation current = default(TaskLocation);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1884222249)) % 7)
			{
			case 6u:
				break;
			case 2u:
				return false;
			case 1u:
			{
				int num10;
				int num11;
				if (task == null)
				{
					num10 = 871479869;
					num11 = num10;
				}
				else
				{
					num10 = 1409536950;
					num11 = num10;
				}
				num = num10 ^ (int)(num2 * 2005597883);
				continue;
			}
			case 5u:
				goto IL_006f;
			case 4u:
				return false;
			case 3u:
			{
				int num8;
				int num9;
				if (task.Locations == null)
				{
					num8 = 1630636599;
					num9 = num8;
				}
				else
				{
					num8 = 1774961199;
					num9 = num8;
				}
				num = num8 ^ (int)(num2 * 1921564982);
				continue;
			}
			default:
			{
				using (List<TaskLocation>.Enumerator enumerator = task.Locations.GetEnumerator())
				{
					while (true)
					{
						IL_0109:
						int num3;
						int num4;
						if (enumerator.MoveNext())
						{
							num3 = -933359222;
							num4 = num3;
						}
						else
						{
							num3 = -880518559;
							num4 = num3;
						}
						while (true)
						{
							switch ((num2 = (uint)(num3 ^ -1884222249)) % 6)
							{
							case 4u:
								num3 = -933359222;
								continue;
							default:
								goto end_IL_00c3;
							case 3u:
							{
								current = enumerator.Current;
								int num7;
								if (current == null)
								{
									num3 = -109318633;
									num7 = num3;
								}
								else
								{
									num3 = -1897180352;
									num7 = num3;
								}
								continue;
							}
							case 0u:
								break;
							case 5u:
								return true;
							case 1u:
							{
								int num5;
								int num6;
								if (!_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current.name, location))
								{
									num5 = -116007805;
									num6 = num5;
								}
								else
								{
									num5 = -2112452106;
									num6 = num5;
								}
								num3 = num5 ^ (int)(num2 * 1007350924);
								continue;
							}
							case 2u:
								goto end_IL_00c3;
							}
							goto IL_0109;
							continue;
							end_IL_00c3:
							break;
						}
						break;
					}
				}
				return false;
			}
			}
			break;
		}
		goto IL_000d;
		IL_006f:
		task = ResourceManager.Get<Task>(NewbieTask);
		num = -2025096741;
		goto IL_0012;
	}

	public void setTask(string task)
	{
		NewbieTask = task;
	}

	public void removeTask(string task)
	{
		NewbieTask = string.Empty;
	}

	public bool hasTask()
	{
		if (NewbieTask != null)
		{
			while (true)
			{
				uint num;
				switch ((num = 875063780u) % 3)
				{
				case 0u:
					continue;
				case 2u:
					return !_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(NewbieTask, string.Empty);
				}
				break;
			}
		}
		return false;
	}

	public bool judgeFinishTask()
	{
		if (_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(NewbieTask))
		{
			goto IL_000d;
		}
		goto IL_007d;
		IL_000d:
		int num = 240274326;
		goto IL_0012;
		IL_0012:
		Task task = default(Task);
		Condition current2 = default(Condition);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x7806E7EC)) % 7)
			{
			case 0u:
				break;
			case 6u:
				return false;
			case 5u:
			{
				int num14;
				int num15;
				if (task.Finishes != null)
				{
					num14 = -1654490856;
					num15 = num14;
				}
				else
				{
					num14 = -400445709;
					num15 = num14;
				}
				num = num14 ^ ((int)num2 * -885029880);
				continue;
			}
			case 4u:
				return false;
			case 1u:
				goto IL_007d;
			case 3u:
			{
				int num12;
				int num13;
				if (task != null)
				{
					num12 = -1224959273;
					num13 = num12;
				}
				else
				{
					num12 = -1266189957;
					num13 = num12;
				}
				num = num12 ^ (int)(num2 * 1259660686);
				continue;
			}
			default:
			{
				using (List<TaskFinish>.Enumerator enumerator = task.Finishes.GetEnumerator())
				{
					while (true)
					{
						IL_0226:
						if (enumerator.MoveNext())
						{
							bool flag;
							while (true)
							{
								TaskFinish current = enumerator.Current;
								flag = true;
								int num3 = 686791678;
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ 0x7806E7EC)) % 4)
									{
									case 0u:
										num3 = 667467225;
										continue;
									case 1u:
										break;
									case 2u:
										goto IL_00f9;
									default:
										goto IL_0114;
									}
									break;
									IL_0114:
									using (List<Condition>.Enumerator enumerator2 = current.Conditions.GetEnumerator())
									{
										while (true)
										{
											IL_0180:
											int num4;
											int num5;
											if (!enumerator2.MoveNext())
											{
												num4 = 1957404798;
												num5 = num4;
											}
											else
											{
												num4 = 197131107;
												num5 = num4;
											}
											while (true)
											{
												switch ((num2 = (uint)(num4 ^ 0x7806E7EC)) % 7)
												{
												case 0u:
													num4 = 197131107;
													continue;
												default:
													goto end_IL_0128;
												case 1u:
													goto end_IL_0128;
												case 6u:
													flag = false;
													num4 = (int)(num2 * 553271321) ^ -1353357574;
													continue;
												case 2u:
													break;
												case 5u:
												{
													current2 = enumerator2.Current;
													int num8;
													if (current2 == null)
													{
														num4 = 514442001;
														num8 = num4;
													}
													else
													{
														num4 = 1157322902;
														num8 = num4;
													}
													continue;
												}
												case 3u:
												{
													int num6;
													int num7;
													if (TriggerLogic.judge(current2))
													{
														num6 = -472917049;
														num7 = num6;
													}
													else
													{
														num6 = -894388824;
														num7 = num6;
													}
													num4 = num6 ^ ((int)num2 * -697603257);
													continue;
												}
												case 4u:
													goto end_IL_0128;
												}
												goto IL_0180;
												continue;
												end_IL_0128:
												break;
											}
											break;
										}
									}
									goto end_IL_00e8;
									IL_00f9:
									if (current.Conditions == null)
									{
										goto end_IL_00e8;
									}
									num3 = ((int)num2 * -909929542) ^ 0x6A6F0977;
								}
								continue;
								end_IL_00e8:
								break;
							}
							if (!flag)
							{
								continue;
							}
							goto IL_01f4;
						}
						int num9 = 55186539;
						goto IL_01f9;
						IL_01f9:
						while (true)
						{
							switch ((num2 = (uint)(num9 ^ 0x7806E7EC)) % 6)
							{
							case 3u:
								break;
							default:
								goto end_IL_0226;
							case 2u:
								goto IL_0226;
							case 0u:
								gameEngine.SwitchGameScene(task.Result.type, task.Result.value);
								num9 = ((int)num2 * -1217702862) ^ -1418636380;
								continue;
							case 5u:
							{
								NewbieTask = string.Empty;
								int num10;
								int num11;
								if (task.Result != null)
								{
									num10 = -1362912524;
									num11 = num10;
								}
								else
								{
									num10 = -1435292744;
									num11 = num10;
								}
								num9 = num10 ^ (int)(num2 * 1907780844);
								continue;
							}
							case 4u:
								return true;
							case 1u:
								goto end_IL_0226;
							}
							break;
						}
						goto IL_01f4;
						IL_01f4:
						num9 = 544533639;
						goto IL_01f9;
						continue;
						end_IL_0226:
						break;
					}
				}
				return false;
			}
			}
			break;
		}
		goto IL_000d;
		IL_007d:
		task = ResourceManager.Get<Task>(NewbieTask);
		num = 1326172596;
		goto IL_0012;
	}

	public Dictionary<ItemInstance, int> GetItems(ItemType type)
	{
		Dictionary<ItemInstance, int> dictionary = new Dictionary<ItemInstance, int>();
		List<ItemType> list = default(List<ItemType>);
		ItemInstance current = default(ItemInstance);
		while (true)
		{
			int num = -88017314;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -673657459)) % 5)
				{
				case 0u:
					break;
				case 4u:
					list = new List<ItemType>();
					list.Add(type);
					num = ((int)num2 * -501747455) ^ 0x1090F220;
					continue;
				case 1u:
					list.Add(ItemType.Book2);
					num = ((int)num2 * -831606053) ^ -1922329247;
					continue;
				case 3u:
				{
					int num6;
					int num7;
					if (type == ItemType.Book)
					{
						num6 = 861127695;
						num7 = num6;
					}
					else
					{
						num6 = 106981207;
						num7 = num6;
					}
					num = num6 ^ ((int)num2 * -800731134);
					continue;
				}
				default:
				{
					using (Dictionary<ItemInstance, int>.KeyCollection.Enumerator enumerator = Items.Keys.GetEnumerator())
					{
						while (true)
						{
							IL_00c2:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -1006635310;
								num4 = num3;
							}
							else
							{
								num3 = -581101597;
								num4 = num3;
							}
							while (true)
							{
								switch ((num2 = (uint)(num3 ^ -673657459)) % 5)
								{
								case 0u:
									num3 = -1006635310;
									continue;
								default:
									goto end_IL_009c;
								case 4u:
									break;
								case 2u:
									dictionary.Add(current, Items[current]);
									num3 = (int)(num2 * 179599526) ^ -1534005865;
									continue;
								case 3u:
								{
									current = enumerator.Current;
									int num5;
									if (list.Contains(current.Type))
									{
										num3 = -1248103194;
										num5 = num3;
									}
									else
									{
										num3 = -1602187531;
										num5 = num3;
									}
									continue;
								}
								case 1u:
									goto end_IL_009c;
								}
								goto IL_00c2;
								continue;
								end_IL_009c:
								break;
							}
							break;
						}
					}
					return dictionary;
				}
				}
				break;
			}
		}
	}

	public ItemInstance GetItem(string pk)
	{
		using (Dictionary<ItemInstance, int>.Enumerator enumerator = Items.GetEnumerator())
		{
			KeyValuePair<ItemInstance, int> current = default(KeyValuePair<ItemInstance, int>);
			ItemInstance key = default(ItemInstance);
			while (true)
			{
				IL_0094:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -545983967;
					num2 = num;
				}
				else
				{
					num = -1253596016;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -954238113)) % 6)
					{
					case 0u:
						num = -545983967;
						continue;
					default:
						goto end_IL_0016;
					case 4u:
					{
						current = enumerator.Current;
						int num4;
						if (!_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(current.Key.PK, pk))
						{
							num = -999828421;
							num4 = num;
						}
						else
						{
							num = -1518033492;
							num4 = num;
						}
						continue;
					}
					case 1u:
						key = current.Key;
						num = (int)((num3 * 233555049) ^ 0x3AEC57C3);
						continue;
					case 2u:
						break;
					case 5u:
						goto end_IL_0016;
					case 3u:
						return key;
					}
					goto IL_0094;
					continue;
					end_IL_0016:
					break;
				}
				break;
			}
		}
		return null;
	}

	public Dictionary<ItemInstance, int> GetItems(ItemType[] types)
	{
		Dictionary<ItemInstance, int> dictionary = new Dictionary<ItemInstance, int>();
		using (Dictionary<ItemInstance, int>.KeyCollection.Enumerator enumerator = Items.Keys.GetEnumerator())
		{
			ItemInstance current = default(ItemInstance);
			int num4 = default(int);
			while (true)
			{
				IL_0098:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -597986306;
					num2 = num;
				}
				else
				{
					num = -1400453260;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -112092176)) % 9)
					{
					case 4u:
						num = -597986306;
						continue;
					default:
						goto end_IL_001e;
					case 8u:
						dictionary.Add(current, Items[current]);
						num = (int)(num3 * 1098869126) ^ -985038408;
						continue;
					case 3u:
						num4++;
						num = -741726749;
						continue;
					case 6u:
						num4 = 0;
						num = (int)((num3 * 326490639) ^ 0x35B2D3C2);
						continue;
					case 0u:
						break;
					case 1u:
					{
						int num6;
						if (types[num4] != current.Type)
						{
							num = -549159816;
							num6 = num;
						}
						else
						{
							num = -1681126320;
							num6 = num;
						}
						continue;
					}
					case 7u:
					{
						int num5;
						if (num4 >= types.Length)
						{
							num = -1751698554;
							num5 = num;
						}
						else
						{
							num = -1717929803;
							num5 = num;
						}
						continue;
					}
					case 5u:
						current = enumerator.Current;
						num = -1052932289;
						continue;
					case 2u:
						goto end_IL_001e;
					}
					goto IL_0098;
					continue;
					end_IL_001e:
					break;
				}
				break;
			}
		}
		return dictionary;
	}

	public void addItem(Item item, int number = 1)
	{
		if (item == null)
		{
			return;
		}
		while (true)
		{
			int num = -1375086040;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1845985256)) % 3)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_0025;
				case 0u:
					return;
				}
				break;
				IL_0025:
				addItem(ItemInstance.Generate2(item), number);
				num = (int)(num2 * 45980501) ^ -780444725;
			}
		}
	}

	public void addItem(ItemInstance item, int number = 1)
	{
		isItemsPanelRefreshed = 0;
		int num6 = default(int);
		int num9 = default(int);
		int num3 = default(int);
		Dictionary<ItemInstance, int> items2 = default(Dictionary<ItemInstance, int>);
		Dictionary<ItemInstance, int> items = default(Dictionary<ItemInstance, int>);
		while (true)
		{
			int num = 2060590688;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0xA8A1885)) % 24)
				{
				case 2u:
					break;
				default:
					return;
				case 11u:
					num6 += num9;
					num = ((int)num2 * -189808288) ^ -482799906;
					continue;
				case 10u:
					num3 = num_decode(num3);
					num = ((int)num2 * -1321641316) ^ 0x3AFB8B88;
					continue;
				case 8u:
					num9--;
					num = (int)(num2 * 2116705987) ^ -126311395;
					continue;
				case 13u:
					num3 += num9;
					num = ((int)num2 * -1402575363) ^ -1989920069;
					continue;
				case 6u:
				{
					int num12;
					int num13;
					if (!Items.ContainsKey(item))
					{
						num12 = 1707584437;
						num13 = num12;
					}
					else
					{
						num12 = 1049008487;
						num13 = num12;
					}
					num = num12 ^ ((int)num2 * -414431035);
					continue;
				}
				case 14u:
					Items.Remove(item);
					return;
				case 9u:
					items2 = Items;
					num6 = items2[item];
					num = (int)(num2 * 946542819) ^ -950741630;
					continue;
				case 17u:
				{
					int num16;
					if (!Items.ContainsKey(item))
					{
						num = 182826931;
						num16 = num;
					}
					else
					{
						num = 100558828;
						num16 = num;
					}
					continue;
				}
				case 3u:
				{
					int num7;
					int num8;
					if (num6 <= 0)
					{
						num7 = 223563873;
						num8 = num7;
					}
					else
					{
						num7 = 1397302299;
						num8 = num7;
					}
					num = num7 ^ (int)(num2 * 1439135734);
					continue;
				}
				case 12u:
					num3 = items[item];
					num = ((int)num2 * -479615832) ^ -1241550089;
					continue;
				case 0u:
				{
					int num17;
					if (num9 <= 0)
					{
						num = 182826931;
						num17 = num;
					}
					else
					{
						num = 532228299;
						num17 = num;
					}
					continue;
				}
				case 23u:
				{
					int num14;
					int num15;
					if (Items.ContainsKey(item))
					{
						num14 = -322353617;
						num15 = num14;
					}
					else
					{
						num14 = -1994301529;
						num15 = num14;
					}
					num = num14 ^ (int)(num2 * 1937086398);
					continue;
				}
				case 1u:
					items[item] = num_encode(num3);
					num = 633244134;
					continue;
				case 4u:
					num6 = num_decode(num6);
					num = ((int)num2 * -1682302035) ^ -1338480174;
					continue;
				case 21u:
					num9 = number;
					num = (int)(num2 * 616303116) ^ -1014658588;
					continue;
				case 18u:
					items = Items;
					num = (int)(num2 * 144573454) ^ -907321522;
					continue;
				case 20u:
					items2[item] = num_encode(num6);
					num = 182826931;
					continue;
				case 19u:
					return;
				case 16u:
					Items.Add(item, 1492);
					num = (int)((num2 * 285286033) ^ 0x71CFF015);
					continue;
				case 5u:
				{
					int num10;
					int num11;
					if (num9 <= 0)
					{
						num10 = 2017296137;
						num11 = num10;
					}
					else
					{
						num10 = 1512693618;
						num11 = num10;
					}
					num = num10 ^ ((int)num2 * -839170063);
					continue;
				}
				case 15u:
				{
					int num4;
					int num5;
					if (num3 >= 999999)
					{
						num4 = 1718323173;
						num5 = num4;
					}
					else
					{
						num4 = 1016801499;
						num5 = num4;
					}
					num = num4 ^ ((int)num2 * -1159482327);
					continue;
				}
				case 7u:
					num3 = 999999;
					num = (int)((num2 * 996000300) ^ 0x3F0F52D8);
					continue;
				case 22u:
					return;
				}
				break;
			}
		}
	}

	public void xiangziAddItem(ItemInstance item, int number = 1)
	{
		int num = number;
		int num4 = default(int);
		Dictionary<ItemInstance, int> xiangzi2 = default(Dictionary<ItemInstance, int>);
		Dictionary<ItemInstance, int> xiangzi = default(Dictionary<ItemInstance, int>);
		int num5 = default(int);
		while (true)
		{
			int num2 = -1140995991;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1528726302)) % 19)
				{
				case 14u:
					break;
				default:
					return;
				case 7u:
				{
					int num16;
					int num17;
					if (num > 0)
					{
						num16 = 2018392088;
						num17 = num16;
					}
					else
					{
						num16 = 967697029;
						num17 = num16;
					}
					num2 = num16 ^ (int)(num3 * 971530532);
					continue;
				}
				case 5u:
					num4 = num_decode(num4);
					num4 += num;
					num2 = ((int)num3 * -2117149458) ^ -1757948785;
					continue;
				case 18u:
					xiangzi2 = Xiangzi;
					num2 = ((int)num3 * -1589848031) ^ 0x3C9B94FA;
					continue;
				case 9u:
				{
					int num10;
					int num11;
					if (Xiangzi.ContainsKey(item))
					{
						num10 = -256540915;
						num11 = num10;
					}
					else
					{
						num10 = -1045400297;
						num11 = num10;
					}
					num2 = num10 ^ (int)(num3 * 76971420);
					continue;
				}
				case 4u:
					num4 = 999999;
					num2 = (int)((num3 * 1886748088) ^ 0x698E423B);
					continue;
				case 11u:
				{
					int num14;
					if (!Xiangzi.ContainsKey(item))
					{
						num2 = -1061728457;
						num14 = num2;
					}
					else
					{
						num2 = -383682525;
						num14 = num2;
					}
					continue;
				}
				case 17u:
				{
					xiangzi = Xiangzi;
					int num8;
					int num9;
					if (Xiangzi.ContainsKey(item))
					{
						num8 = -1595189992;
						num9 = num8;
					}
					else
					{
						num8 = -2128199375;
						num9 = num8;
					}
					num2 = num8 ^ (int)(num3 * 418170798);
					continue;
				}
				case 6u:
				{
					int num15;
					if (num <= 0)
					{
						num2 = -1061728457;
						num15 = num2;
					}
					else
					{
						num2 = -1854214950;
						num15 = num2;
					}
					continue;
				}
				case 10u:
				{
					int num12;
					int num13;
					if (num5 > 0)
					{
						num12 = -2009169557;
						num13 = num12;
					}
					else
					{
						num12 = -1311771969;
						num13 = num12;
					}
					num2 = num12 ^ (int)(num3 * 1535527447);
					continue;
				}
				case 2u:
					Xiangzi.Remove(item);
					num2 = ((int)num3 * -81211466) ^ -303625829;
					continue;
				case 15u:
					return;
				case 1u:
					num4 = xiangzi[item];
					num2 = ((int)num3 * -459883271) ^ -729967692;
					continue;
				case 13u:
					Xiangzi.Add(item, 1492);
					num--;
					num2 = (int)(num3 * 1245585265) ^ -1756456229;
					continue;
				case 12u:
				{
					int num6;
					int num7;
					if (num4 >= 999999)
					{
						num6 = -576207089;
						num7 = num6;
					}
					else
					{
						num6 = -95563658;
						num7 = num6;
					}
					num2 = num6 ^ (int)(num3 * 190469103);
					continue;
				}
				case 8u:
					num5 = xiangzi2[item];
					num5 = num_decode(num5);
					num5 += num;
					num2 = (int)((num3 * 1473183705) ^ 0xD48B7E0);
					continue;
				case 3u:
					xiangzi2[item] = num_encode(num5);
					num2 = -1061728457;
					continue;
				case 0u:
					xiangzi[item] = num_encode(num4);
					return;
				case 16u:
					return;
				}
				break;
			}
		}
	}

	public void NextZhoumuClear()
	{
		Dictionary<ItemInstance, int> dictionary = new Dictionary<ItemInstance, int>();
		using (Dictionary<ItemInstance, int>.Enumerator enumerator = Xiangzi.GetEnumerator())
		{
			KeyValuePair<ItemInstance, int> current = default(KeyValuePair<ItemInstance, int>);
			while (true)
			{
				IL_0040:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 1825802518;
					num2 = num;
				}
				else
				{
					num = 815811400;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x51932440)) % 5)
					{
					case 0u:
						num = 1825802518;
						continue;
					default:
						goto end_IL_001a;
					case 1u:
						break;
					case 3u:
						dictionary.Add(current.Key, current.Value);
						num = (int)((num3 * 360105124) ^ 0xC19F9ED);
						continue;
					case 4u:
						current = enumerator.Current;
						num = 1641555793;
						continue;
					case 2u:
						goto end_IL_001a;
					}
					goto IL_0040;
					continue;
					end_IL_001a:
					break;
				}
				break;
			}
		}
		int round = Round;
		string text = default(string);
		string[] removeDupString = default(string[]);
		int num5 = default(int);
		string text2 = default(string);
		string[] removeDupString2 = default(string[]);
		int num8 = default(int);
		string uUID = default(string);
		bool autoSaveOnly = default(bool);
		while (true)
		{
			int num4 = 51598102;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num4 ^ 0x51932440)) % 29)
				{
				case 23u:
					break;
				default:
					return;
				case 25u:
					text = _206A_206B_202D_202E_200E_206D_202D_202E_206D_200E_202A_202B_206D_200F_202D_206E_202E_200D_202E_202E_206F_200F_200F_200F_206B_202E_202C_200F_202B_202C_200B_206D_202E_200E_200C_202C_200F_202E_202B_206D_202E(text, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1583738914u), removeDupString[num5]);
					num4 = ((int)num3 * -2062011077) ^ 0x720ECE0B;
					continue;
				case 19u:
					text2 = _206A_206B_202D_202E_200E_206D_202D_202E_206D_200E_202A_202B_206D_200F_202D_206E_202E_200D_202E_202E_206F_200F_200F_200F_206B_202E_202C_200F_202B_202C_200B_206D_202E_200E_200C_202C_200F_202E_202B_206D_202E(text2, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2828931079u), removeDupString2[num8]);
					num4 = (int)(num3 * 306627239) ^ -1409062684;
					continue;
				case 27u:
					num5++;
					num4 = 413275260;
					continue;
				case 3u:
					RollRoleUI.trialRoles_bak = TrialRoles;
					removeDupString2 = Tools.GetRemoveDupString(_202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(TrialPalRoles, new char[1] { '#' }));
					num4 = (int)((num3 * 1109691570) ^ 0x76E6AA0F);
					continue;
				case 18u:
					uUID = UUID;
					num4 = (int)((num3 * 289491408) ^ 0x6A908C8);
					continue;
				case 11u:
				{
					int num7;
					if (num5 >= removeDupString.Length)
					{
						num4 = 817138407;
						num7 = num4;
					}
					else
					{
						num4 = 730346906;
						num7 = num4;
					}
					continue;
				}
				case 7u:
					Clear();
					num4 = (int)(num3 * 81126054) ^ -985572798;
					continue;
				case 6u:
					num4 = ((int)num3 * -851543603) ^ -948663193;
					continue;
				case 15u:
					num8++;
					num4 = 1213124019;
					continue;
				case 2u:
					TrialPalRoles = text2;
					num4 = ((int)num3 * -639608799) ^ 0x6034198B;
					continue;
				case 28u:
				{
					int num10;
					if (num8 < removeDupString2.Length)
					{
						num4 = 1790445153;
						num10 = num4;
					}
					else
					{
						num4 = 1496525000;
						num10 = num4;
					}
					continue;
				}
				case 1u:
				{
					int num9;
					if (_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(removeDupString2[num8]))
					{
						num4 = 415597696;
						num9 = num4;
					}
					else
					{
						num4 = 1039340732;
						num9 = num4;
					}
					continue;
				}
				case 13u:
					num4 = (int)((num3 * 1804791002) ^ 0x4FF7395E);
					continue;
				case 22u:
					isItemsPanelRefreshed = 0;
					num4 = (int)(num3 * 1868387364) ^ -268024746;
					continue;
				case 5u:
					IsInited = true;
					num4 = ((int)num3 * -1728459251) ^ -701182895;
					continue;
				case 17u:
					AutoSaveOnly = autoSaveOnly;
					num4 = ((int)num3 * -1701844889) ^ -906783087;
					continue;
				case 10u:
					removeDupString = Tools.GetRemoveDupString(_202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(TrialRoles, new char[1] { '#' }));
					num4 = ((int)num3 * -625453152) ^ 0x27D970C5;
					continue;
				case 24u:
					Money = 100;
					isTeamPanelRefreshed = 0;
					num4 = (int)(num3 * 1434679633) ^ -433536040;
					continue;
				case 26u:
					text = string.Empty;
					num4 = (int)((num3 * 2143134254) ^ 0x9719ADB);
					continue;
				case 14u:
					text2 = string.Empty;
					num4 = (int)((num3 * 1469939864) ^ 0x72A47F41);
					continue;
				case 9u:
					num8 = 0;
					num4 = (int)(num3 * 970033685) ^ -45234135;
					continue;
				case 21u:
					Xiangzi = dictionary;
					num4 = ((int)num3 * -656155218) ^ -415507917;
					continue;
				case 0u:
				{
					int num6;
					if (_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(removeDupString[num5]))
					{
						num4 = 1847458819;
						num6 = num4;
					}
					else
					{
						num4 = 909537752;
						num6 = num4;
					}
					continue;
				}
				case 12u:
					num5 = 0;
					num4 = ((int)num3 * -847307962) ^ 0x59C1B65B;
					continue;
				case 20u:
					autoSaveOnly = AutoSaveOnly;
					num4 = ((int)num3 * -1059475431) ^ 0x5F0BB3E8;
					continue;
				case 4u:
					Round = round;
					UUID = uUID;
					num4 = ((int)num3 * -1236010926) ^ 0x7C4833B0;
					continue;
				case 8u:
					TrialRoles = text;
					num4 = (int)(num3 * 435514038) ^ -580418367;
					continue;
				case 16u:
					return;
				}
				break;
			}
		}
	}

	public int getHaogan(string roleKey = "女主")
	{
		if (_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(roleKey))
		{
			goto IL_0008;
		}
		goto IL_005f;
		IL_0008:
		int num = -1074558101;
		goto IL_000d;
		IL_000d:
		string key = default(string);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -384715047)) % 6)
			{
			case 4u:
				break;
			case 5u:
				return int.Parse(getDataOrInit(key, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(838530381u)));
			case 1u:
				goto IL_005f;
			case 2u:
				roleKey = ResourceStrings.ResStrings[9];
				num = (int)(num2 * 254152411) ^ -768282936;
				continue;
			case 0u:
			{
				int num3;
				int num4;
				if (CommonSettings.MOD_KEY() == 2)
				{
					num3 = -112903422;
					num4 = num3;
				}
				else
				{
					num3 = -39521898;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 1313211298);
				continue;
			}
			default:
				return int.Parse(getDataOrInit(key, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2375535820u)));
			}
			break;
		}
		goto IL_0008;
		IL_005f:
		key = _206A_200C_200F_206E_202E_206D_206E_200E_202D_200E_202A_200F_200E_200B_202A_206B_200B_202A_202E_206A_202B_206C_200F_202C_202D_200F_202D_206E_206D_202A_202A_200C_200C_206D_200B_202B_202B_200C_200E_200C_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2543027892u), roleKey);
		num = -1113635627;
		goto IL_000d;
	}

	public void addHaogan(int value, string roleKey = "女主")
	{
		if (_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(roleKey))
		{
			goto IL_000b;
		}
		goto IL_009a;
		IL_000b:
		int num = -747811024;
		goto IL_0010;
		IL_0010:
		int num3 = default(int);
		string key = default(string);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -241903425)) % 13)
			{
			case 9u:
				break;
			default:
				return;
			case 8u:
				roleKey = ResourceStrings.ResStrings[9];
				num = (int)(num2 * 896460744) ^ -1487487731;
				continue;
			case 5u:
			{
				int num6;
				int num7;
				if (CommonSettings.MOD_KEY() == 2)
				{
					num6 = -2111193588;
					num7 = num6;
				}
				else
				{
					num6 = -1923155272;
					num7 = num6;
				}
				num = num6 ^ ((int)num2 * -684797133);
				continue;
			}
			case 2u:
				goto IL_009a;
			case 0u:
			{
				int num4;
				int num5;
				if (num3 < 0)
				{
					num4 = -762664474;
					num5 = num4;
				}
				else
				{
					num4 = -2016961017;
					num5 = num4;
				}
				num = num4 ^ ((int)num2 * -1126459418);
				continue;
			}
			case 3u:
				num3 = 0;
				num = (int)((num2 * 1070196171) ^ 0x49BB6FAC);
				continue;
			case 12u:
				num = ((int)num2 * -247520590) ^ -1287162172;
				continue;
			case 6u:
				num3 = 0;
				num = (int)(num2 * 2051804718) ^ -818917924;
				continue;
			case 11u:
				num3 = int.Parse(getDataOrInit(key, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3556140356u)));
				num = (int)(num2 * 214664571) ^ -1355955142;
				continue;
			case 1u:
				KeyValues[key] = num3.ToString();
				num = -1703147381;
				continue;
			case 7u:
				num3 += value;
				num = -1538732780;
				continue;
			case 4u:
				num3 = int.Parse(getDataOrInit(key, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2375535820u)));
				num = -2031213530;
				continue;
			case 10u:
				return;
			}
			break;
		}
		goto IL_000b;
		IL_009a:
		key = _206A_200C_200F_206E_202E_206D_206E_200E_202D_200E_202A_200F_200E_200B_202A_206B_200B_202A_202E_206A_202B_206C_200F_202C_202D_200F_202D_206E_206D_202A_202A_200C_200C_206D_200B_202B_202B_200C_200E_200C_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(392914217u), roleKey);
		num = -290049802;
		goto IL_0010;
	}

	public void SetLocation(string mapKey, string location)
	{
		string key = _206A_200C_200F_206E_202E_206D_206E_200E_202D_200E_202A_200F_200E_200B_202A_206B_200B_202A_202E_206A_202B_206C_200F_202C_202D_200F_202D_206E_206D_202A_202A_200C_200C_206D_200B_202B_202B_200C_200E_200C_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1522304807u), mapKey);
		if (!KeyValues.ContainsKey(key))
		{
			goto IL_001f;
		}
		goto IL_0062;
		IL_001f:
		int num = 18738896;
		goto IL_0024;
		IL_0024:
		uint num2;
		switch ((num2 = (uint)(num ^ 0x7F343595)) % 4)
		{
		case 2u:
			break;
		default:
			return;
		case 1u:
			KeyValues.Add(key, location);
			return;
		case 0u:
			goto IL_0062;
		case 3u:
			return;
		}
		goto IL_001f;
		IL_0062:
		KeyValues[key] = location;
		num = 1423541410;
		goto IL_0024;
	}

	public string GetLocation(string mapKey)
	{
		string key = _206A_200C_200F_206E_202E_206D_206E_200E_202D_200E_202A_200F_200E_200B_202A_206B_200B_202A_202E_206A_202B_206C_200F_202C_202D_200F_202D_206E_206D_202A_202A_200C_200C_206D_200B_202B_202B_200C_200E_200C_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3284735622u), mapKey);
		while (true)
		{
			int num = -70331199;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -875154133)) % 4)
				{
				case 0u:
					break;
				case 2u:
				{
					int num3;
					int num4;
					if (KeyValues.ContainsKey(key))
					{
						num3 = -1055991538;
						num4 = num3;
					}
					else
					{
						num3 = -804830836;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 91445826);
					continue;
				}
				case 3u:
					KeyValues.Add(key, string.Empty);
					num = ((int)num2 * -1460567937) ^ 0x2BE859D7;
					continue;
				default:
					return KeyValues[key];
				}
				break;
			}
		}
	}

	public void AddLog(string info)
	{
		if (_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(info))
		{
			while (true)
			{
				uint num;
				switch ((num = 1024092947u) % 3)
				{
				case 0u:
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
		string text = CommonSettings.DateToString(Date);
		string text2 = _200D_206B_206A_202D_200B_206C_206D_202C_206D_200F_206E_202B_200F_202D_200F_200D_202A_206C_202B_206C_200C_202C_202C_206D_200B_202E_200C_200E_200B_202B_206B_202C_206A_202E_202D_202E_200D_206D_206A_206A_202E(Log, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(710388383u), "");
		Log = _200D_200F_206D_200B_200E_206C_200B_206B_206E_202A_206D_200F_200C_202E_206D_202C_200C_202B_206D_206C_200E_200B_200B_202D_202B_206E_206F_202D_206F_202D_206C_206C_206D_200E_202A_202B_202B_200C_200B_202E_202E(new string[5]
		{
			text2,
			text,
			global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1100404398u),
			info,
			global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(390903560u)
		});
	}

	public void AddTimeKeyStory(string key, double days, string story)
	{
		KeyValues[_206A_200C_200F_206E_202E_206D_206E_200E_202D_200E_202A_200F_200E_200B_202A_206B_200B_202A_202E_206A_202B_206C_200F_202C_202D_200F_202D_206E_206D_202A_202A_200C_200C_206D_200B_202B_202B_200C_200E_200C_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1584034028u), key)] = _206B_202A_206D_206E_206F_206F_202A_200E_200F_200B_206B_206B_202B_206A_202B_200F_206D_206A_200E_200E_200C_202B_200E_202E_202A_200B_202D_200D_206C_202E_202B_200D_206F_200D_206C_202D_200F_202E_202B_206C_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1926359624u), (object)Tools.GetTimeStamp(Date), (object)days, (object)story);
	}

	public void RemoveTimeKey(string key)
	{
		string key2 = _206A_200C_200F_206E_202E_206D_206E_200E_202D_200E_202A_200F_200E_200B_202A_206B_200B_202A_202E_206A_202B_206C_200F_202C_202D_200F_202D_206E_206D_202A_202A_200C_200C_206D_200B_202B_202B_200C_200E_200C_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3150541448u), key);
		while (true)
		{
			int num = -1333450090;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1187435968)) % 4)
				{
				case 3u:
					break;
				default:
					return;
				case 2u:
				{
					int num3;
					int num4;
					if (KeyValues.ContainsKey(key2))
					{
						num3 = -2120671321;
						num4 = num3;
					}
					else
					{
						num3 = -119813614;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1745809677);
					continue;
				}
				case 1u:
					KeyValues.Remove(key2);
					num = ((int)num2 * -1086972004) ^ 0x56B01F70;
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public string CheckTimeFlags()
	{
		List<string> list = new List<string>();
		string result = string.Empty;
		using (Dictionary<string, string>.KeyCollection.Enumerator enumerator = KeyValues.Keys.GetEnumerator())
		{
			TimeSpan timeSpan = default(TimeSpan);
			DateTime dateTime = default(DateTime);
			double num8 = default(double);
			string[] array = default(string[]);
			string current = default(string);
			while (true)
			{
				IL_01f2:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -1015865861;
					num2 = num;
				}
				else
				{
					num = -90033970;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -1046379563)) % 15)
					{
					case 8u:
						num = -1015865861;
						continue;
					default:
						goto end_IL_0027;
					case 10u:
						timeSpan = Date - dateTime;
						num = (int)((num3 * 1477469451) ^ 0xA6E8470);
						continue;
					case 4u:
						num8 = double.Parse(array[1]);
						num = ((int)num3 * -1154069535) ^ 0x7A389311;
						continue;
					case 2u:
						array = _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(KeyValues[current], new char[1] { '#' });
						num = (int)((num3 * 1459660359) ^ 0x415449FC);
						continue;
					case 3u:
					{
						int num6;
						int num7;
						if (array.Length >= 3)
						{
							num6 = -425312604;
							num7 = num6;
						}
						else
						{
							num6 = -450920151;
							num7 = num6;
						}
						num = num6 ^ (int)(num3 * 1957009218);
						continue;
					}
					case 1u:
						goto end_IL_0027;
					case 7u:
						dateTime = Tools.GetDateTime(long.Parse(array[0]));
						num = (int)(num3 * 2062070180) ^ -608999226;
						continue;
					case 6u:
						list.Add(current);
						num = (int)((num3 * 1453211555) ^ 0x6B63F48A);
						continue;
					case 14u:
					{
						int num9;
						int num10;
						if (timeSpan.TotalDays <= num8)
						{
							num9 = 2076719886;
							num10 = num9;
						}
						else
						{
							num9 = 525014504;
							num10 = num9;
						}
						num = num9 ^ ((int)num3 * -1123337139);
						continue;
					}
					case 11u:
						current = enumerator.Current;
						num = -382365743;
						continue;
					case 0u:
						list.Add(current);
						num = -775599494;
						continue;
					case 9u:
					{
						int num4;
						int num5;
						if (_202A_206C_206B_206F_200C_206D_202E_202C_206D_200C_206B_200F_200E_206E_206A_206E_206D_202B_206F_206C_202E_206E_202D_206E_200D_206E_202C_200D_200D_202A_200C_206D_206B_202D_200B_206A_200D_200B_200B_202A_202E(current, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1796950251u)))
						{
							num4 = 1941708000;
							num5 = num4;
						}
						else
						{
							num4 = 1910340450;
							num5 = num4;
						}
						num = num4 ^ (int)(num3 * 339294790);
						continue;
					}
					case 5u:
						result = array[2];
						num = (int)(num3 * 157960863) ^ -1871527493;
						continue;
					case 12u:
						break;
					case 13u:
						goto end_IL_0027;
					}
					goto IL_01f2;
					continue;
					end_IL_0027:
					break;
				}
				break;
			}
		}
		using (List<string>.Enumerator enumerator2 = list.GetEnumerator())
		{
			while (true)
			{
				IL_026e:
				int num11;
				int num12;
				if (!enumerator2.MoveNext())
				{
					num11 = -602346353;
					num12 = num11;
				}
				else
				{
					num11 = -1510607084;
					num12 = num11;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num11 ^ -1046379563)) % 4)
					{
					case 3u:
						num11 = -1510607084;
						continue;
					default:
						goto end_IL_022e;
					case 1u:
					{
						string current2 = enumerator2.Current;
						KeyValues.Remove(current2);
						num11 = -1042630091;
						continue;
					}
					case 0u:
						break;
					case 2u:
						goto end_IL_022e;
					}
					goto IL_026e;
					continue;
					end_IL_022e:
					break;
				}
				break;
			}
		}
		return result;
	}

	public void AddFlag(string key)
	{
		KeyValues[_206A_200C_200F_206E_202E_206D_206E_200E_202D_200E_202A_200F_200E_200B_202A_206B_200B_202A_202E_206A_202B_206C_200F_202C_202D_200F_202D_206E_206D_202A_202A_200C_200C_206D_200B_202B_202B_200C_200E_200C_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3943457182u), key)] = _206C_202A_200D_206B_202A_206A_200F_206A_206B_200E_202E_206B_206B_202C_206C_200E_202A_202B_202D_200C_200F_200E_206D_206D_202C_202E_202C_200E_206E_206F_206E_202B_202A_202E_206A_200B_200B_202A_202A_202C_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1253669317u), (object)Tools.GetTimeStamp(Date));
	}

	public void RemoveFlag(string key)
	{
		string key2 = _206A_200C_200F_206E_202E_206D_206E_200E_202D_200E_202A_200F_200E_200B_202A_206B_200B_202A_202E_206A_202B_206C_200F_202C_202D_200F_202D_206E_206D_202A_202A_200C_200C_206D_200B_202B_202B_200C_200E_200C_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3980916777u), key);
		while (true)
		{
			int num = 1588570445;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x71C85130)) % 4)
				{
				case 3u:
					break;
				default:
					return;
				case 1u:
				{
					int num3;
					int num4;
					if (KeyValues.ContainsKey(key2))
					{
						num3 = 2097247766;
						num4 = num3;
					}
					else
					{
						num3 = 53480480;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 146124638);
					continue;
				}
				case 0u:
					KeyValues.Remove(key2);
					num = ((int)num2 * -1417730934) ^ 0x63677146;
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public bool HasFlag(string key)
	{
		return KeyValues.ContainsKey(_206A_200C_200F_206E_202E_206D_206E_200E_202D_200E_202A_200F_200E_200B_202A_206B_200B_202A_202E_206A_202B_206C_200F_202C_202D_200F_202D_206E_206D_202A_202A_200C_200C_206D_200B_202B_202B_200C_200E_200C_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3943457182u), key));
	}

	public bool IsStoryFinished(string storyName)
	{
		return KeyValues.ContainsKey(storyName);
	}

	public void StoryFinish(string storyName, string storyResult)
	{
		if (_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(storyName))
		{
			return;
		}
		int num3 = default(int);
		string[] array = default(string[]);
		while (true)
		{
			int num = -1401039869;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1210082305)) % 8)
				{
				case 0u:
					break;
				default:
					return;
				case 3u:
					num3 = int.Parse(array[2]) + 1;
					num = ((int)num2 * -1152080880) ^ -907044279;
					continue;
				case 5u:
				{
					int num6;
					int num7;
					if (array.Length >= 3)
					{
						num6 = 1977377941;
						num7 = num6;
					}
					else
					{
						num6 = 630468404;
						num7 = num6;
					}
					num = num6 ^ (int)(num2 * 451332957);
					continue;
				}
				case 6u:
					KeyValues[storyName] = storyResult + global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2057560981u) + (Date - Tools.GetDateTime(-62135589600L)).Days + global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1541154258u) + num3;
					num = -1139189936;
					continue;
				case 4u:
				{
					num3 = 1;
					int num4;
					int num5;
					if (KeyValues.ContainsKey(storyName))
					{
						num4 = 803234370;
						num5 = num4;
					}
					else
					{
						num4 = 350110541;
						num5 = num4;
					}
					num = num4 ^ (int)(num2 * 392761779);
					continue;
				}
				case 2u:
					num3 = 2;
					num = -1728583047;
					continue;
				case 1u:
					array = _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(KeyValues[storyName], new char[1] { '#' });
					num = (int)(num2 * 1221078333) ^ -1227373465;
					continue;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	private string getDataOrInit(string key, string initValue = "")
	{
		if (!KeyValues.ContainsKey(key))
		{
			while (true)
			{
				int num = 1253525458;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x58BA7F5C)) % 3)
					{
					case 0u:
						break;
					case 1u:
						KeyValues[key] = initValue;
						num = (int)(num2 * 395069032) ^ -1305962718;
						continue;
					default:
						goto end_IL_000e;
					}
					break;
				}
				continue;
				end_IL_000e:
				break;
			}
		}
		return KeyValues[key];
	}

	public string Save()
	{
		LastLoadingTime = new TimeSpan(DateTime.Now.Ticks);
		GameSave gameSave = default(GameSave);
		int round = default(int);
		Dictionary<ItemInstance, int> dictionary2 = default(Dictionary<ItemInstance, int>);
		Dictionary<ItemInstance, int> dictionary = default(Dictionary<ItemInstance, int>);
		KeyValuePair<ItemInstance, int> current = default(KeyValuePair<ItemInstance, int>);
		int num5 = default(int);
		KeyValuePair<string, string> current3 = default(KeyValuePair<string, string>);
		KeyValuePair<string, string> current4 = default(KeyValuePair<string, string>);
		KeyValuePair<ItemInstance, int> current6 = default(KeyValuePair<ItemInstance, int>);
		int num27 = default(int);
		while (true)
		{
			int num = 1394315401;
			while (true)
			{
				int num12;
				int num21;
				int num24;
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5626DFB)) % 8)
				{
				case 5u:
					break;
				case 2u:
					gameSave = new GameSave();
					num = ((int)num2 * -2086402212) ^ 0x17847DA0;
					continue;
				case 4u:
					gameSave.Information = GetSaveInformation();
					round = Round;
					dictionary2 = new Dictionary<ItemInstance, int>();
					dictionary = new Dictionary<ItemInstance, int>();
					num = ((int)num2 * -212280969) ^ -1801616786;
					continue;
				case 0u:
					gameSave.Temps = GameSaveRole.Create(Temp);
					num = ((int)num2 * -943503299) ^ -482019203;
					continue;
				case 7u:
					gameSave.Follows = GameSaveRole.Create(Follow);
					num = (int)((num2 * 680871581) ^ 0x4142A478);
					continue;
				case 6u:
					gameSave.NewbieTask = NewbieTask;
					num = (int)(num2 * 1253204184) ^ -573530289;
					continue;
				case 3u:
					gameSave.Roles = GameSaveRole.Create(Team);
					num = (int)((num2 * 1597859782) ^ 0x59C5EC7E);
					continue;
				default:
					{
						using (Dictionary<ItemInstance, int>.Enumerator enumerator = Items.GetEnumerator())
						{
							while (true)
							{
								IL_01e9:
								int num3;
								int num4;
								if (enumerator.MoveNext())
								{
									num3 = 2024047053;
									num4 = num3;
								}
								else
								{
									num3 = 866232376;
									num4 = num3;
								}
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ 0x5626DFB)) % 10)
									{
									case 6u:
										num3 = 2024047053;
										continue;
									default:
										goto end_IL_013a;
									case 0u:
									{
										int num8;
										int num9;
										if (current.Key.Name.EndsWith(ResourceStrings.ResStrings[331]))
										{
											num8 = 1938501402;
											num9 = num8;
										}
										else
										{
											num8 = 1424440956;
											num9 = num8;
										}
										num3 = num8 ^ (int)(num2 * 754394569);
										continue;
									}
									case 2u:
										num3 = ((int)num2 * -1029139203) ^ -641777178;
										continue;
									case 3u:
									{
										int num10;
										int num11;
										if (num5 > 0)
										{
											num10 = 1826081212;
											num11 = num10;
										}
										else
										{
											num10 = 1931126041;
											num11 = num10;
										}
										num3 = num10 ^ ((int)num2 * -1159147777);
										continue;
									}
									case 9u:
										break;
									case 7u:
										dictionary2.Add(current.Key, num5);
										num3 = 2123759258;
										continue;
									case 4u:
									{
										int num6;
										int num7;
										if (current.Key.GetItem().round < round)
										{
											num6 = -837519430;
											num7 = num6;
										}
										else
										{
											num6 = -1788749091;
											num7 = num6;
										}
										num3 = num6 ^ (int)(num2 * 185552584);
										continue;
									}
									case 8u:
										current = enumerator.Current;
										num5 = num_decode(current.Value);
										num3 = 1769265798;
										continue;
									case 5u:
										dictionary.Add(current.Key, num5);
										num3 = (int)(num2 * 2086860558) ^ -8001515;
										continue;
									case 1u:
										goto end_IL_013a;
									}
									goto IL_01e9;
									continue;
									end_IL_013a:
									break;
								}
								break;
							}
						}
						num12 = 0;
						if (dictionary2.Count > 0)
						{
							while (true)
							{
								int num13 = 323540819;
								while (true)
								{
									switch ((num2 = (uint)(num13 ^ 0x5626DFB)) % 3)
									{
									case 0u:
										break;
									case 1u:
										gameSave.GameItems = new GameSaveItem[dictionary2.Count];
										num13 = (int)((num2 * 1733226355) ^ 0x30FB2C81);
										continue;
									default:
										goto end_IL_02b3;
									}
									break;
								}
								continue;
								end_IL_02b3:
								break;
							}
							num12 = 0;
							using (Dictionary<ItemInstance, int>.Enumerator enumerator = dictionary2.GetEnumerator())
							{
								while (true)
								{
									IL_0332:
									int num14;
									int num15;
									if (enumerator.MoveNext())
									{
										num14 = 1219355839;
										num15 = num14;
									}
									else
									{
										num14 = 1316212088;
										num15 = num14;
									}
									while (true)
									{
										switch ((num2 = (uint)(num14 ^ 0x5626DFB)) % 5)
										{
										case 2u:
											num14 = 1219355839;
											continue;
										default:
											goto end_IL_0309;
										case 1u:
											break;
										case 0u:
											num12++;
											num14 = (int)(num2 * 1374533231) ^ -1108501187;
											continue;
										case 4u:
										{
											KeyValuePair<ItemInstance, int> current2 = enumerator.Current;
											gameSave.GameItems[num12] = new GameSaveItem
											{
												name = current2.Key.Name,
												triggers = current2.Key.AdditionTriggers.ToArray(),
												count = current2.Value
											};
											num14 = 652557369;
											continue;
										}
										case 3u:
											goto end_IL_0309;
										}
										goto IL_0332;
										continue;
										end_IL_0309:
										break;
									}
									break;
								}
							}
							dictionary2.Clear();
							goto IL_03cf;
						}
						goto IL_03fa;
					}
					IL_06c5:
					if (BattleKeyValues.Count > 0)
					{
						while (true)
						{
							int num16 = 731684285;
							while (true)
							{
								switch ((num2 = (uint)(num16 ^ 0x5626DFB)) % 3)
								{
								case 0u:
									break;
								case 1u:
									gameSave.BattleKeyValues = new GameSaveKeyValues[BattleKeyValues.Count];
									num12 = 0;
									num16 = (int)((num2 * 584586221) ^ 0x3F0706A5);
									continue;
								default:
									goto end_IL_06d6;
								}
								break;
							}
							continue;
							end_IL_06d6:
							break;
						}
						using Dictionary<string, string>.Enumerator enumerator2 = BattleKeyValues.GetEnumerator();
						while (true)
						{
							IL_0770:
							int num17;
							int num18;
							if (!enumerator2.MoveNext())
							{
								num17 = 817964526;
								num18 = num17;
							}
							else
							{
								num17 = 1944310824;
								num18 = num17;
							}
							while (true)
							{
								switch ((num2 = (uint)(num17 ^ 0x5626DFB)) % 6)
								{
								case 5u:
									num17 = 1944310824;
									continue;
								default:
									goto end_IL_0736;
								case 1u:
									current3 = enumerator2.Current;
									num17 = 499768301;
									continue;
								case 2u:
									break;
								case 4u:
									num12++;
									num17 = (int)((num2 * 1580420304) ^ 0x319CC60B);
									continue;
								case 0u:
									gameSave.BattleKeyValues[num12] = new GameSaveKeyValues
									{
										key = current3.Key,
										value = current3.Value
									};
									num17 = (int)((num2 * 452978095) ^ 0x3632354D);
									continue;
								case 3u:
									goto end_IL_0736;
								}
								goto IL_0770;
								continue;
								end_IL_0736:
								break;
							}
							break;
						}
					}
					gameSave.KeyValues = new GameSaveKeyValues[KeyValues.Count + 1];
					num12 = 0;
					using (Dictionary<string, string>.Enumerator enumerator2 = KeyValues.GetEnumerator())
					{
						while (true)
						{
							IL_08a8:
							int num19;
							int num20;
							if (!enumerator2.MoveNext())
							{
								num19 = 110761651;
								num20 = num19;
							}
							else
							{
								num19 = 1125644550;
								num20 = num19;
							}
							while (true)
							{
								switch ((num2 = (uint)(num19 ^ 0x5626DFB)) % 6)
								{
								case 5u:
									num19 = 1125644550;
									continue;
								default:
									goto end_IL_081d;
								case 3u:
									current4 = enumerator2.Current;
									num19 = 93080433;
									continue;
								case 1u:
									num12++;
									num19 = (int)(num2 * 1286899534) ^ -333365959;
									continue;
								case 0u:
									gameSave.KeyValues[num12] = new GameSaveKeyValues
									{
										key = current4.Key,
										value = current4.Value
									};
									num19 = (int)(num2 * 1765867648) ^ -1602089054;
									continue;
								case 4u:
									break;
								case 2u:
									goto end_IL_081d;
								}
								goto IL_08a8;
								continue;
								end_IL_081d:
								break;
							}
							break;
						}
					}
					gameSave.KeyValues[num12] = new GameSaveKeyValues
					{
						key = global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2955848252u),
						value = (CommonSettings.TOUCH_MODE ? global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(746684885u) : global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(854108657u)) + CommonSettings.GET_MOD_VERSION() + global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2129775u) + DateTime.Now.ToString(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2876577849u), DateTimeFormatInfo.InvariantInfo)
					};
					return Tools.SerializeXML(gameSave);
					IL_03fa:
					if (dictionary.Count > 0)
					{
						num21 = 1461526203;
						goto IL_03d4;
					}
					goto IL_0527;
					IL_03d4:
					while (true)
					{
						switch ((num2 = (uint)(num21 ^ 0x5626DFB)) % 5)
						{
						case 0u:
							break;
						case 1u:
							goto IL_03fa;
						case 2u:
							num12 = 0;
							num21 = ((int)num2 * -1061930991) ^ 0x12A50856;
							continue;
						case 3u:
							gameSave.CanzhangItems = new GameSaveItem[dictionary.Count];
							num21 = (int)(num2 * 275378002) ^ -483328980;
							continue;
						default:
							goto IL_0441;
						}
						break;
					}
					goto IL_03cf;
					IL_0441:
					using (Dictionary<ItemInstance, int>.Enumerator enumerator = dictionary.GetEnumerator())
					{
						while (true)
						{
							IL_04b3:
							int num22;
							int num23;
							if (!enumerator.MoveNext())
							{
								num22 = 1113792134;
								num23 = num22;
							}
							else
							{
								num22 = 1283757838;
								num23 = num22;
							}
							while (true)
							{
								switch ((num2 = (uint)(num22 ^ 0x5626DFB)) % 5)
								{
								case 0u:
									num22 = 1283757838;
									continue;
								default:
									goto end_IL_0450;
								case 3u:
								{
									KeyValuePair<ItemInstance, int> current5 = enumerator.Current;
									gameSave.CanzhangItems[num12] = new GameSaveItem
									{
										name = current5.Key.Name,
										count = current5.Value
									};
									num22 = 362489958;
									continue;
								}
								case 4u:
									break;
								case 1u:
									num12++;
									num22 = ((int)num2 * -1346253319) ^ -1582430318;
									continue;
								case 2u:
									goto end_IL_0450;
								}
								goto IL_04b3;
								continue;
								end_IL_0450:
								break;
							}
							break;
						}
					}
					dictionary.Clear();
					goto IL_04fc;
					IL_03cf:
					num21 = 787853934;
					goto IL_03d4;
					IL_0527:
					if (Xiangzi.Count > 0)
					{
						num24 = 1494060551;
						goto IL_0501;
					}
					goto IL_06c5;
					IL_0501:
					while (true)
					{
						switch ((num2 = (uint)(num24 ^ 0x5626DFB)) % 5)
						{
						case 3u:
							break;
						case 1u:
							goto IL_0527;
						case 0u:
							num12 = 0;
							num24 = ((int)num2 * -1259698448) ^ -1667595732;
							continue;
						case 2u:
							gameSave.XiangziItems = new GameSaveItem[Xiangzi.Count];
							num24 = ((int)num2 * -437407172) ^ -626277971;
							continue;
						default:
							goto IL_0578;
						}
						break;
					}
					goto IL_04fc;
					IL_0578:
					using (Dictionary<ItemInstance, int>.Enumerator enumerator = Xiangzi.GetEnumerator())
					{
						while (true)
						{
							IL_0698:
							int num25;
							int num26;
							if (enumerator.MoveNext())
							{
								num25 = 983304441;
								num26 = num25;
							}
							else
							{
								num25 = 1129996050;
								num26 = num25;
							}
							while (true)
							{
								switch ((num2 = (uint)(num25 ^ 0x5626DFB)) % 8)
								{
								case 4u:
									num25 = 983304441;
									continue;
								default:
									goto end_IL_058f;
								case 2u:
									current6 = enumerator.Current;
									num27 = num_decode(current6.Value);
									num25 = 146591406;
									continue;
								case 0u:
									gameSave.XiangziItems[num12] = new GameSaveItem
									{
										name = current6.Key.Name,
										triggers = current6.Key.AdditionTriggers.ToArray(),
										count = num27
									};
									num25 = (int)((num2 * 896984595) ^ 0x444F508);
									continue;
								case 6u:
								{
									int num30;
									int num31;
									if (current6.Key.GetItem().round < round)
									{
										num30 = -1363666646;
										num31 = num30;
									}
									else
									{
										num30 = -784253831;
										num31 = num30;
									}
									num25 = num30 ^ ((int)num2 * -1537167377);
									continue;
								}
								case 5u:
								{
									int num28;
									int num29;
									if (num27 <= 0)
									{
										num28 = -2078376473;
										num29 = num28;
									}
									else
									{
										num28 = -1674717206;
										num29 = num28;
									}
									num25 = num28 ^ ((int)num2 * -34711549);
									continue;
								}
								case 3u:
									num12++;
									num25 = 1484030268;
									continue;
								case 7u:
									break;
								case 1u:
									goto end_IL_058f;
								}
								goto IL_0698;
								continue;
								end_IL_058f:
								break;
							}
							break;
						}
					}
					goto IL_06c5;
					IL_04fc:
					num24 = 349641593;
					goto IL_0501;
				}
				break;
			}
		}
	}

	public bool Load(string str)
	{
		if (_200B_202A_200D_202E_206D_202C_202B_202D_202A_206B_200F_206E_202A_200C_206D_200F_206B_206B_202D_200D_206C_202E_200E_202B_206E_206A_206E_200D_206F_202C_206C_202C_202B_206B_206A_206D_200C_200B_202D_200D_202E((Object)(object)mapUI, (Object)null))
		{
			while (true)
			{
				int num = 1541907578;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x6D323525)) % 4)
					{
					case 0u:
						break;
					case 3u:
					{
						int num3;
						int num4;
						if (mapUI.Working())
						{
							num3 = -34912610;
							num4 = num3;
						}
						else
						{
							num3 = -517542839;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 1980260638);
						continue;
					}
					case 1u:
						return false;
					default:
						goto end_IL_000e;
					}
					break;
				}
				continue;
				end_IL_000e:
				break;
			}
		}
		int round = Round;
		Clear();
		isTeamPanelRefreshed = 0;
		isItemsPanelRefreshed = 0;
		GameSave gameSave = default(GameSave);
		bool result = default(bool);
		try
		{
			if (!CommonSettings.TOUCH_MODE)
			{
				goto IL_0091;
			}
			goto IL_00d0;
			IL_0091:
			int num5 = 261789441;
			goto IL_0096;
			IL_0096:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num5 ^ 0x6D323525)) % 6)
				{
				case 5u:
					break;
				default:
					goto end_IL_008a;
				case 1u:
					num5 = ((int)num2 * -1847363674) ^ 0x1D5464B;
					continue;
				case 0u:
					goto IL_00d0;
				case 2u:
				{
					int num6;
					int num7;
					if (!_206D_202D_206D_202A_200D_206B_206B_202D_202A_202D_206D_202C_206C_206A_200F_206E_202D_202C_202E_200F_206A_200B_206E_200C_206F_206B_202A_200D_206D_206D_206A_206E_206E_202C_206E_206C_202D_200C_200F_206F_202E(NetworkClass._202D_202C_200F_202C_206E_206E_202C_202A_206B_200C_206E_206C_206D_206F_202C_206C_202B_200F_200F_206B_202C_200D_202E_206B_200F_202A_202E_202B_206F_200E_202D_200D_206D_202C_202E_206C_200E_202D_202E_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1527428585u)), global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(471614174u)))
					{
						num6 = 1748663447;
						num7 = num6;
					}
					else
					{
						num6 = 2092836534;
						num7 = num6;
					}
					num5 = num6 ^ (int)(num2 * 1463265764);
					continue;
				}
				case 3u:
					gameSave = BasePojo.Create<GameSave>(string.Empty);
					num5 = ((int)num2 * -775076787) ^ 0x215CCFEB;
					continue;
				case 4u:
					goto end_IL_008a;
				}
				break;
			}
			goto IL_0091;
			IL_00d0:
			gameSave = BasePojo.Create<GameSave>(str);
			num5 = 1003315933;
			goto IL_0096;
			end_IL_008a:;
		}
		catch
		{
			while (true)
			{
				IL_013c:
				int num8 = 1741446017;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num8 ^ 0x6D323525)) % 3)
					{
					case 2u:
						break;
					case 1u:
						goto IL_015f;
					default:
						goto end_IL_0141;
					}
					goto IL_013c;
					IL_015f:
					result = false;
					num8 = ((int)num2 * -650733793) ^ -714418696;
					continue;
					end_IL_0141:
					break;
				}
				break;
			}
			goto IL_1303;
		}
		bool flag = false;
		GameSaveKeyValues[] array2 = default(GameSaveKeyValues[]);
		int num14 = default(int);
		GameSaveKeyValues gameSaveKeyValues = default(GameSaveKeyValues);
		string[] array = default(string[]);
		DateTime dt2 = default(DateTime);
		int num15 = default(int);
		ItemInstance itemInstance = default(ItemInstance);
		GameSaveRole[] array4 = default(GameSaveRole[]);
		GameSaveItem gameSaveItem2 = default(GameSaveItem);
		GameSaveRole gameSaveRole2 = default(GameSaveRole);
		GameSaveKeyValues gameSaveKeyValues3 = default(GameSaveKeyValues);
		GameSaveRole gameSaveRole4 = default(GameSaveRole);
		int num19 = default(int);
		GameSaveItem gameSaveItem = default(GameSaveItem);
		GameSaveKeyValues gameSaveKeyValues4 = default(GameSaveKeyValues);
		ItemInstance itemInstance2 = default(ItemInstance);
		GameSaveItem gameSaveItem3 = default(GameSaveItem);
		GameSaveItem[] array3 = default(GameSaveItem[]);
		ItemInstance itemInstance4 = default(ItemInstance);
		GameSaveItem gameSaveItem5 = default(GameSaveItem);
		ItemInstance itemInstance5 = default(ItemInstance);
		ItemInstance itemInstance3 = default(ItemInstance);
		GameSaveItem gameSaveItem4 = default(GameSaveItem);
		GameSaveRole gameSaveRole3 = default(GameSaveRole);
		while (true)
		{
			int num9 = 1526130980;
			while (true)
			{
				int num13;
				int num16;
				uint num2;
				switch ((num2 = (uint)(num9 ^ 0x6D323525)) % 8)
				{
				case 4u:
					break;
				case 1u:
					if (_200B_202C_200E_202C_202C_200E_206C_200F_206C_200B_206C_206F_202C_202C_206A_206D_206F_206C_200E_200F_200B_202A_206D_206B_202E_200F_206C_206C_200D_200B_206D_206F_206F_200D_206A_202E_200D_206C_200E_206B_202E(gameSave.GetValueByKey(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(802506112u))) > 12)
					{
						num9 = ((int)num2 * -2131253363) ^ -2030027648;
						continue;
					}
					goto IL_05ed;
				case 5u:
					array2 = gameSave.KeyValues;
					num9 = (int)((num2 * 221540950) ^ 0x2B474661);
					continue;
				case 2u:
					num14 = 0;
					num9 = ((int)num2 * -994190640) ^ -416187373;
					continue;
				case 7u:
					gameSaveKeyValues = array2[num14];
					num9 = 186068222;
					continue;
				case 0u:
					flag = true;
					num9 = (int)((num2 * 1970022725) ^ 0x38AF0928);
					continue;
				default:
					if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(gameSaveKeyValues.key, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3158520052u)))
					{
						DateTime dt;
						try
						{
							dt = DateTime.Parse(gameSaveKeyValues.value);
						}
						catch
						{
							dt = DateTime.ParseExact(gameSaveKeyValues.value, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1810115944u), _206C_200F_202E_200D_202C_200F_206E_206D_200F_206F_206E_200F_206A_202E_200B_206C_206A_206E_206D_202D_202B_206F_206B_202D_202B_206D_200E_206F_202E_202E_200C_206D_200D_202A_202B_206A_202A_200C_206E_206C_202E());
						}
						gameSaveKeyValues.value = Tools.GetTimeStamp(dt).ToString();
					}
					else
					{
						while (true)
						{
							int num10;
							int num11;
							if (!gameSaveKeyValues.key.StartsWith(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1796950251u)))
							{
								num10 = 955457998;
								num11 = num10;
							}
							else
							{
								num10 = 304774176;
								num11 = num10;
							}
							while (true)
							{
								switch ((num2 = (uint)(num10 ^ 0x6D323525)) % 5)
								{
								case 0u:
									num10 = 689314194;
									continue;
								case 1u:
									break;
								case 4u:
									array = gameSaveKeyValues.value.Split('#');
									num10 = 733304619;
									continue;
								case 3u:
									goto IL_0323;
								default:
									goto end_IL_02da;
								}
								break;
								IL_0323:
								if (gameSaveKeyValues.key.StartsWith(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3980916777u)))
								{
									num10 = (int)(num2 * 464846463) ^ -1980959051;
									continue;
								}
								goto IL_0b2f;
							}
							continue;
							end_IL_02da:
							break;
						}
						if (array[0].Length > 12)
						{
							try
							{
								dt2 = DateTime.Parse(array[0]);
							}
							catch
							{
								while (true)
								{
									IL_036f:
									int num12 = 1459674031;
									while (true)
									{
										switch ((num2 = (uint)(num12 ^ 0x6D323525)) % 3)
										{
										case 0u:
											break;
										default:
											goto end_IL_0374;
										case 1u:
											goto IL_0392;
										case 2u:
											goto end_IL_0374;
										}
										goto IL_036f;
										IL_0392:
										dt2 = DateTime.ParseExact(array[0], global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(188340458u), CultureInfo.CurrentCulture);
										num12 = ((int)num2 * -15319685) ^ 0x3457AFA4;
										continue;
										end_IL_0374:
										break;
									}
									break;
								}
							}
							gameSaveKeyValues.value = Tools.GetTimeStamp(dt2).ToString();
							goto IL_03d5;
						}
					}
					goto IL_0b2f;
				case 6u:
					goto IL_12b4;
					IL_03d5:
					num13 = 924418604;
					goto IL_03da;
					IL_05ed:
					KeyValues.Clear();
					num15 = gameSave.KeyValues.Length;
					if (gameSave.KeyValues[num15 - 1].key == global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(34570789u))
					{
						num13 = 633659587;
						num16 = num13;
					}
					else
					{
						num13 = 652380022;
						num16 = num13;
					}
					goto IL_03da;
					IL_0b2f:
					num14++;
					num13 = 932319307;
					goto IL_03da;
					IL_03da:
					while (true)
					{
						switch ((num2 = (uint)(num13 ^ 0x6D323525)) % 119)
						{
						case 44u:
							break;
						case 105u:
						{
							int num32;
							int num33;
							if (itemInstance == null)
							{
								num32 = 420342989;
								num33 = num32;
							}
							else
							{
								num32 = 1199650821;
								num33 = num32;
							}
							num13 = num32 ^ ((int)num2 * -1881802123);
							continue;
						}
						case 37u:
							goto IL_05ed;
						case 13u:
							goto IL_0635;
						case 56u:
							num13 = (int)((num2 * 17712646) ^ 0x5B6ED902);
							continue;
						case 63u:
						{
							int num36;
							int num37;
							if (!flag)
							{
								num36 = 129220775;
								num37 = num36;
							}
							else
							{
								num36 = 622019866;
								num37 = num36;
							}
							num13 = num36 ^ (int)(num2 * 847654875);
							continue;
						}
						case 6u:
							num14 = 0;
							num13 = (int)((num2 * 777802533) ^ 0x7F9B8959);
							continue;
						case 98u:
						{
							GameSaveRole gameSaveRole6 = array4[num14];
							Team.Add(gameSaveRole6.GenerateRole());
							num13 = 416439382;
							continue;
						}
						case 7u:
							goto IL_06d4;
						case 25u:
						{
							GameSaveRole gameSaveRole5 = array4[num14];
							Follow.Add(gameSaveRole5.GenerateRole());
							num14++;
							num13 = 1581366029;
							continue;
						}
						case 94u:
						{
							ResetVerifiedRealTimeFlags();
							int num26;
							int num27;
							if ((Object)(object)mapUI != (Object)null)
							{
								num26 = 1484084988;
								num27 = num26;
							}
							else
							{
								num26 = 1158369264;
								num27 = num26;
							}
							num13 = num26 ^ (int)(num2 * 360771917);
							continue;
						}
						case 31u:
							itemInstance = gameSaveItem2.Generate();
							num13 = ((int)num2 * -1255617834) ^ 0x3F889E2F;
							continue;
						case 86u:
							num14 = 0;
							num13 = (int)(num2 * 12743083) ^ -1725877057;
							continue;
						case 28u:
							num14++;
							num13 = ((int)num2 * -623194265) ^ -912103482;
							continue;
						case 99u:
							Follow.Add(gameSaveRole2.GenerateRole2());
							num13 = (int)(num2 * 2009074572) ^ -1470710500;
							continue;
						case 29u:
							num13 = ((int)num2 * -664620692) ^ 0x182696A0;
							continue;
						case 84u:
							gameSaveKeyValues3 = array2[num14];
							num13 = 186134281;
							continue;
						case 114u:
							num14++;
							num13 = 114715049;
							continue;
						case 22u:
							array4 = gameSave.Temps;
							num13 = 883222240;
							continue;
						case 27u:
							gameSaveRole4 = array4[num14];
							num13 = 90375249;
							continue;
						case 0u:
							num14 = 0;
							num13 = ((int)num2 * -2114424491) ^ -1853958189;
							continue;
						case 67u:
							num13 = ((int)num2 * -548263858) ^ 0x6073C7BB;
							continue;
						case 70u:
						{
							int num42;
							int num43;
							if (array.Length > 1)
							{
								num42 = 579336501;
								num43 = num42;
							}
							else
							{
								num42 = 1903776210;
								num43 = num42;
							}
							num13 = num42 ^ ((int)num2 * -813273272);
							continue;
						}
						case 64u:
							num15--;
							num13 = (int)((num2 * 1665329578) ^ 0x1506E7CA);
							continue;
						case 66u:
							goto IL_0876;
						case 16u:
							goto IL_08a1;
						case 58u:
							num14++;
							num13 = ((int)num2 * -988893314) ^ -1488506494;
							continue;
						case 32u:
							array4 = gameSave.Follows;
							num14 = 0;
							num13 = 1581366029;
							continue;
						case 9u:
							num19++;
							num13 = 2107285765;
							continue;
						case 109u:
							goto IL_0904;
						case 73u:
							array4 = gameSave.Temps;
							num14 = 0;
							num13 = (int)((num2 * 2047624860) ^ 0x2BC0CB22);
							continue;
						case 30u:
							num13 = (int)((num2 * 1766834971) ^ 0x6333FA6B);
							continue;
						case 55u:
						{
							int num30;
							int num31;
							if (gameSaveItem.count <= 0)
							{
								num30 = -887628110;
								num31 = num30;
							}
							else
							{
								num30 = -165803227;
								num31 = num30;
							}
							num13 = num30 ^ (int)(num2 * 1591501876);
							continue;
						}
						case 75u:
							goto IL_0981;
						case 10u:
							KeyValues.Add(gameSaveKeyValues4.key, gameSaveKeyValues4.value);
							num13 = (int)(num2 * 1267849955) ^ -1158987346;
							continue;
						case 60u:
							goto IL_09c9;
						case 107u:
							goto IL_09e5;
						case 117u:
							goto IL_0a01;
						case 92u:
							array2 = gameSave.BattleKeyValues;
							num14 = 0;
							num13 = (int)((num2 * 1113157058) ^ 0x3A3D8CB4);
							continue;
						case 78u:
						{
							int num22;
							int num23;
							if (flag)
							{
								num22 = 1697060193;
								num23 = num22;
							}
							else
							{
								num22 = 1847411282;
								num23 = num22;
							}
							num13 = num22 ^ (int)(num2 * 800325222);
							continue;
						}
						case 42u:
							goto IL_0a5b;
						case 59u:
							goto IL_0a77;
						case 111u:
							KeyValues.Add(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1632881441u), string.Empty);
							num13 = (int)(num2 * 1102040486) ^ -229733869;
							continue;
						case 17u:
							goto IL_0ac0;
						case 100u:
							goto IL_0adc;
						case 68u:
							num19 = 0;
							num13 = 1745768459;
							continue;
						case 89u:
						{
							itemInstance2 = gameSaveItem3.GenerateCanzhang();
							int num50;
							int num51;
							if (itemInstance2 == null)
							{
								num50 = -1800285159;
								num51 = num50;
							}
							else
							{
								num50 = -237462004;
								num51 = num50;
							}
							num13 = num50 ^ (int)(num2 * 528338869);
							continue;
						}
						case 3u:
							goto IL_0b2f;
						case 87u:
							array3 = gameSave.GameItems;
							num13 = ((int)num2 * -941901452) ^ 0x219BDD7E;
							continue;
						case 88u:
							num13 = ((int)num2 * -621906097) ^ 0x38F57DF1;
							continue;
						case 82u:
							itemInstance4 = gameSaveItem5.Generate2();
							num13 = ((int)num2 * -1620456913) ^ 0x2718172F;
							continue;
						case 48u:
							array3 = gameSave.XiangziItems;
							num13 = 1764446192;
							continue;
						case 79u:
						{
							GameSaveKeyValues gameSaveKeyValues5 = gameSaveKeyValues;
							gameSaveKeyValues5.value = gameSaveKeyValues5.value + global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1541154258u) + array[2];
							num13 = (int)(num2 * 408928872) ^ -2125519366;
							continue;
						}
						case 103u:
							goto IL_0bce;
						case 93u:
							goto IL_0bf6;
						case 19u:
							gameSaveItem2 = array3[num14];
							num13 = 629730502;
							continue;
						case 49u:
						{
							int num48;
							int num49;
							if (itemInstance4 == null)
							{
								num48 = -348827693;
								num49 = num48;
							}
							else
							{
								num48 = -212299690;
								num49 = num48;
							}
							num13 = num48 ^ (int)(num2 * 1352862071);
							continue;
						}
						case 21u:
							return true;
						case 96u:
							goto IL_0c59;
						case 45u:
							array4 = gameSave.Roles;
							num14 = 0;
							num13 = 1640670918;
							continue;
						case 26u:
							num13 = ((int)num2 * -389998665) ^ 0x10AFBFB9;
							continue;
						case 11u:
							num13 = ((int)num2 * -776851687) ^ 0x67CA6099;
							continue;
						case 90u:
						{
							int num46;
							int num47;
							if (gameSaveItem2.count <= 0)
							{
								num46 = -1137865422;
								num47 = num46;
							}
							else
							{
								num46 = -1341489578;
								num47 = num46;
							}
							num13 = num46 ^ (int)(num2 * 1735136203);
							continue;
						}
						case 41u:
							num14 = 0;
							num13 = ((int)num2 * -1585405473) ^ -161617941;
							continue;
						case 54u:
							num14++;
							num13 = 28054368;
							continue;
						case 40u:
						{
							int num44;
							int num45;
							if (round != Round)
							{
								num44 = 645112654;
								num45 = num44;
							}
							else
							{
								num44 = 2062273600;
								num45 = num44;
							}
							num13 = num44 ^ ((int)num2 * -1091152630);
							continue;
						}
						case 1u:
							IsInited = true;
							num13 = 1799731083;
							continue;
						case 38u:
							xiangziAddItem(itemInstance5, gameSaveItem.count);
							num13 = ((int)num2 * -2018315383) ^ 0x567BC070;
							continue;
						case 2u:
							array4 = gameSave.Roles;
							num13 = ((int)num2 * -2101699283) ^ -880736359;
							continue;
						case 104u:
						{
							itemInstance3 = gameSaveItem4.Generate2();
							int num40;
							int num41;
							if (itemInstance3 == null)
							{
								num40 = 433424104;
								num41 = num40;
							}
							else
							{
								num40 = 617558142;
								num41 = num40;
							}
							num13 = num40 ^ ((int)num2 * -2045511101);
							continue;
						}
						case 77u:
							num14++;
							num13 = 1103041496;
							continue;
						case 61u:
						{
							int num38;
							int num39;
							if (!BattleKeyValues.ContainsKey(gameSaveKeyValues3.key))
							{
								num38 = 1081809609;
								num39 = num38;
							}
							else
							{
								num38 = 1767218257;
								num39 = num38;
							}
							num13 = num38 ^ (int)(num2 * 1913302874);
							continue;
						}
						case 85u:
							num14++;
							num13 = (int)((num2 * 1459653411) ^ 0x6F2C8BE9);
							continue;
						case 12u:
						{
							int num34;
							int num35;
							if (!flag)
							{
								num34 = 79713850;
								num35 = num34;
							}
							else
							{
								num34 = 1648213064;
								num35 = num34;
							}
							num13 = num34 ^ (int)(num2 * 729474130);
							continue;
						}
						case 95u:
							Temp.Add(gameSaveRole4.GenerateRole2());
							num14++;
							num13 = ((int)num2 * -935783932) ^ -1510844284;
							continue;
						case 14u:
							num14++;
							num13 = 689554162;
							continue;
						case 50u:
							goto IL_0e50;
						case 113u:
							num14 = 0;
							num13 = (int)((num2 * 388352843) ^ 0x13144DB1);
							continue;
						case 97u:
							goto IL_0e82;
						case 24u:
							goto IL_0e9e;
						case 47u:
							goto IL_0eb7;
						case 23u:
							array3 = gameSave.XiangziItems;
							num13 = (int)((num2 * 1551005924) ^ 0x777701AB);
							continue;
						case 80u:
						{
							itemInstance5 = gameSaveItem.Generate();
							int num28;
							int num29;
							if (itemInstance5 != null)
							{
								num28 = 1343522351;
								num29 = num28;
							}
							else
							{
								num28 = 1123358282;
								num29 = num28;
							}
							num13 = num28 ^ (int)(num2 * 527093078);
							continue;
						}
						case 118u:
							addItem(itemInstance4, gameSaveItem5.count);
							num13 = (int)((num2 * 1870509273) ^ 0x506B5C10);
							continue;
						case 69u:
							goto IL_0f3a;
						case 52u:
							LuaManager.Reload();
							num13 = ((int)num2 * -1453659028) ^ 0x7BAA8DD8;
							continue;
						case 51u:
							xiangziAddItem(itemInstance3, gameSaveItem4.count);
							num13 = ((int)num2 * -407170460) ^ -462545562;
							continue;
						case 33u:
							num14++;
							num13 = 2132304931;
							continue;
						case 65u:
							Team.Add(gameSaveRole3.GenerateRole2());
							num13 = ((int)num2 * -199577655) ^ -1169688171;
							continue;
						case 102u:
							goto IL_0fce;
						case 18u:
							BattleKeyValues.Add(gameSaveKeyValues3.key, gameSaveKeyValues3.value);
							num13 = (int)((num2 * 1099139483) ^ 0xB6E5EB5);
							continue;
						case 57u:
							addItem(itemInstance2, gameSaveItem3.count);
							num13 = (int)(num2 * 1092789379) ^ -2120701038;
							continue;
						case 8u:
							num13 = (int)(num2 * 633595873) ^ -1393439125;
							continue;
						case 15u:
							array3 = gameSave.GameItems;
							num14 = 0;
							num13 = 1709937419;
							continue;
						case 39u:
							gameSaveRole3 = array4[num14];
							num13 = 1816860621;
							continue;
						case 4u:
							goto IL_1071;
						case 5u:
							array3 = gameSave.CanzhangItems;
							num13 = ((int)num2 * -1126334982) ^ -1710721897;
							continue;
						case 116u:
							array4 = gameSave.Follows;
							num13 = (int)(num2 * 1575756209) ^ -1770143702;
							continue;
						case 81u:
						{
							int num24;
							int num25;
							if (!flag)
							{
								num24 = -352363873;
								num25 = num24;
							}
							else
							{
								num24 = -969177138;
								num25 = num24;
							}
							num13 = num24 ^ (int)(num2 * 1264310768);
							continue;
						}
						case 91u:
							goto IL_10e3;
						case 110u:
							num14++;
							num13 = 604258512;
							continue;
						case 101u:
							gameSaveRole2 = array4[num14];
							num13 = 333208144;
							continue;
						case 43u:
							mapUI.Set_story(null);
							mapUI.addVerifiedRealTimeFlagsInvoke();
							num13 = (int)((num2 * 1056997647) ^ 0x5DE5A7B9);
							continue;
						case 62u:
							num13 = ((int)num2 * -304324272) ^ 0x453EE8BE;
							continue;
						case 34u:
							SetManualTempList(KeyValues[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2826627767u)]);
							Round = Round;
							num13 = 2079058587;
							continue;
						case 106u:
							num13 = ((int)num2 * -1969264336) ^ 0x29A003A0;
							continue;
						case 74u:
						{
							GameSaveKeyValues gameSaveKeyValues2 = gameSaveKeyValues;
							gameSaveKeyValues2.value = gameSaveKeyValues2.value + global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2057560981u) + array[1];
							int num20;
							int num21;
							if (array.Length <= 2)
							{
								num20 = 19347666;
								num21 = num20;
							}
							else
							{
								num20 = 277895721;
								num21 = num20;
							}
							num13 = num20 ^ ((int)num2 * -1011362773);
							continue;
						}
						case 72u:
							mapUI.ClearTeamLite();
							num13 = (int)(num2 * 312489924) ^ -680969830;
							continue;
						case 36u:
							addItem(itemInstance, gameSaveItem2.count);
							num13 = (int)(num2 * 1254497247) ^ -1418726831;
							continue;
						case 46u:
							num13 = ((int)num2 * -586099258) ^ 0x49C5DE4C;
							continue;
						case 76u:
						{
							int num17;
							int num18;
							if (flag)
							{
								num17 = 1127454011;
								num18 = num17;
							}
							else
							{
								num17 = 1508349273;
								num18 = num17;
							}
							num13 = num17 ^ (int)(num2 * 529198094);
							continue;
						}
						case 115u:
							goto IL_1259;
						case 83u:
							num14 = 0;
							num13 = (int)((num2 * 303410231) ^ 0x3323B3A0);
							continue;
						case 53u:
						{
							GameSaveRole gameSaveRole = array4[num14];
							Temp.Add(gameSaveRole.GenerateRole());
							num14++;
							num13 = 2141347112;
							continue;
						}
						case 108u:
							goto IL_12b4;
						case 112u:
							num14 = 0;
							num13 = (int)(num2 * 1668346378) ^ -1178849143;
							continue;
						case 20u:
							num13 = (int)(num2 * 1724927954) ^ -1202377426;
							continue;
						case 71u:
							gameSaveItem = array3[num14];
							num13 = 1741680543;
							continue;
						default:
							goto end_IL_0179;
						}
						break;
						IL_1259:
						int num52;
						if (gameSave.CanzhangItems != null)
						{
							num13 = 112425888;
							num52 = num13;
						}
						else
						{
							num13 = 868442454;
							num52 = num13;
						}
						continue;
						IL_06d4:
						int num53;
						if (num14 < array4.Length)
						{
							num13 = 1840500610;
							num53 = num13;
						}
						else
						{
							num13 = 1565744156;
							num53 = num13;
						}
						continue;
						IL_0a77:
						int num54;
						if (gameSave.Follows != null)
						{
							num13 = 1797062110;
							num54 = num13;
						}
						else
						{
							num13 = 1162614558;
							num54 = num13;
						}
						continue;
						IL_10e3:
						int num55;
						if (num14 >= array3.Length)
						{
							num13 = 868442454;
							num55 = num13;
						}
						else
						{
							num13 = 1001371095;
							num55 = num13;
						}
						continue;
						IL_0c59:
						int num56;
						if (num14 >= array3.Length)
						{
							num13 = 123132982;
							num56 = num13;
						}
						else
						{
							num13 = 1301741696;
							num56 = num13;
						}
						continue;
						IL_0904:
						gameSaveItem4 = array3[num14];
						int num57;
						if (gameSaveItem4.count > 0)
						{
							num13 = 1642223915;
							num57 = num13;
						}
						else
						{
							num13 = 617510210;
							num57 = num13;
						}
						continue;
						IL_1071:
						int num58;
						if (gameSave.Temps != null)
						{
							num13 = 1021431244;
							num58 = num13;
						}
						else
						{
							num13 = 1565744156;
							num58 = num13;
						}
						continue;
						IL_09c9:
						int num59;
						if (num14 >= array4.Length)
						{
							num13 = 798150430;
							num59 = num13;
						}
						else
						{
							num13 = 152593811;
							num59 = num13;
						}
						continue;
						IL_0bf6:
						int num60;
						if (num14 >= array4.Length)
						{
							num13 = 1087598007;
							num60 = num13;
						}
						else
						{
							num13 = 554270472;
							num60 = num13;
						}
						continue;
						IL_0fce:
						int num61;
						if (gameSave.Roles != null)
						{
							num13 = 738257968;
							num61 = num13;
						}
						else
						{
							num13 = 798150430;
							num61 = num13;
						}
						continue;
						IL_0a5b:
						int num62;
						if (num14 >= array4.Length)
						{
							num13 = 1162614558;
							num62 = num13;
						}
						else
						{
							num13 = 1943118929;
							num62 = num13;
						}
						continue;
						IL_0635:
						gameSaveKeyValues4 = gameSave.KeyValues[num19];
						int num63;
						if (!KeyValues.ContainsKey(gameSaveKeyValues4.key))
						{
							num13 = 177844368;
							num63 = num13;
						}
						else
						{
							num13 = 93581521;
							num63 = num13;
						}
						continue;
						IL_0f3a:
						gameSaveItem3 = array3[num14];
						int num64;
						if (gameSaveItem3.count <= 0)
						{
							num13 = 1765093537;
							num64 = num13;
						}
						else
						{
							num13 = 2029494781;
							num64 = num13;
						}
						continue;
						IL_0bce:
						NewbieTask = gameSave.NewbieTask;
						int num65;
						if (gameSave.GameItems != null)
						{
							num13 = 1361054927;
							num65 = num13;
						}
						else
						{
							num13 = 1074198731;
							num65 = num13;
						}
						continue;
						IL_0876:
						int num66;
						if (!KeyValues.ContainsKey(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1632881441u)))
						{
							num13 = 601527190;
							num66 = num13;
						}
						else
						{
							num13 = 771286273;
							num66 = num13;
						}
						continue;
						IL_0eb7:
						int num67;
						if (num14 >= array2.Length)
						{
							num13 = 324184895;
							num67 = num13;
						}
						else
						{
							num13 = 633765516;
							num67 = num13;
						}
						continue;
						IL_0a01:
						int num68;
						if (num14 < array4.Length)
						{
							num13 = 1953867863;
							num68 = num13;
						}
						else
						{
							num13 = 2113681136;
							num68 = num13;
						}
						continue;
						IL_0adc:
						int num69;
						if (gameSave.BattleKeyValues != null)
						{
							num13 = 1233396363;
							num69 = num13;
						}
						else
						{
							num13 = 324184895;
							num69 = num13;
						}
						continue;
						IL_0e9e:
						int num70;
						if (num19 >= num15)
						{
							num13 = 196602963;
							num70 = num13;
						}
						else
						{
							num13 = 113997209;
							num70 = num13;
						}
						continue;
						IL_0981:
						int num71;
						if (gameSave.XiangziItems != null)
						{
							num13 = 1679687910;
							num71 = num13;
						}
						else
						{
							num13 = 72105073;
							num71 = num13;
						}
						continue;
						IL_08a1:
						gameSaveItem5 = array3[num14];
						int num72;
						if (gameSaveItem5.count <= 0)
						{
							num13 = 134661706;
							num72 = num13;
						}
						else
						{
							num13 = 223197070;
							num72 = num13;
						}
						continue;
						IL_0e82:
						int num73;
						if (num14 >= array3.Length)
						{
							num13 = 1904794119;
							num73 = num13;
						}
						else
						{
							num13 = 1277699223;
							num73 = num13;
						}
						continue;
						IL_0ac0:
						int num74;
						if (num14 < array3.Length)
						{
							num13 = 676164130;
							num74 = num13;
						}
						else
						{
							num13 = 1074198731;
							num74 = num13;
						}
						continue;
						IL_09e5:
						int num75;
						if (num14 < array4.Length)
						{
							num13 = 359999716;
							num75 = num13;
						}
						else
						{
							num13 = 633214788;
							num75 = num13;
						}
						continue;
						IL_0e50:
						int num76;
						if (num14 >= array3.Length)
						{
							num13 = 72105073;
							num76 = num13;
						}
						else
						{
							num13 = 362660681;
							num76 = num13;
						}
					}
					goto IL_03d5;
					IL_12b4:
					if (num14 < array2.Length)
					{
						goto case 7u;
					}
					num13 = 1634235023;
					goto IL_03da;
				}
				break;
			}
			continue;
			end_IL_0179:
			break;
		}
		goto IL_1303;
		IL_1303:
		return result;
	}

	public void addSkill(string name)
	{
		int num = 1;
		string[] array = default(string[]);
		int num4 = default(int);
		Role current = default(Role);
		int num5 = default(int);
		Skill skill = default(Skill);
		SkillInstance skillInstance = default(SkillInstance);
		SkillInstance current2 = default(SkillInstance);
		InternalSkillInstance item2 = default(InternalSkillInstance);
		SpecialSkillInstance specialSkillInstance = default(SpecialSkillInstance);
		SpecialSkill specialSkill = default(SpecialSkill);
		SpecialSkillInstance current3 = default(SpecialSkillInstance);
		InternalSkill internalSkill = default(InternalSkill);
		InternalSkillInstance current4 = default(InternalSkillInstance);
		while (true)
		{
			int num2 = -439845376;
			while (true)
			{
				int num26;
				uint num3;
				switch ((num3 = (uint)(num2 ^ -932957686)) % 7)
				{
				case 0u:
					break;
				case 3u:
					array = _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(name, new char[1] { '#' });
					num2 = ((int)num3 * -527399189) ^ 0x2CA37247;
					continue;
				case 6u:
					return;
				case 2u:
					num4 = 1;
					num2 = -1106240101;
					continue;
				case 5u:
				{
					int num27;
					int num28;
					if (array.Length <= 1)
					{
						num27 = 32486727;
						num28 = num27;
					}
					else
					{
						num27 = 680614824;
						num28 = num27;
					}
					num2 = num27 ^ ((int)num3 * -377283547);
					continue;
				}
				default:
				{
					string text = array[num4];
					using (List<Role>.Enumerator enumerator = Team.GetEnumerator())
					{
						while (true)
						{
							IL_078f:
							if (enumerator.MoveNext())
							{
								while (true)
								{
									current = enumerator.Current;
									num5 = 0;
									int num6 = -906460176;
									while (true)
									{
										switch ((num3 = (uint)(num6 ^ -932957686)) % 14)
										{
										case 2u:
											num6 = -1028650021;
											continue;
										case 5u:
											break;
										case 4u:
										{
											int num7;
											int num8;
											if (_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current.Key, array[0]))
											{
												num7 = 1797927316;
												num8 = num7;
											}
											else
											{
												num7 = 531457826;
												num8 = num7;
											}
											num6 = num7 ^ (int)(num3 * 900207888);
											continue;
										}
										case 7u:
											skill = ResourceManager.Get<Skill>(text);
											num6 = (int)(num3 * 2124559231) ^ -1661718180;
											continue;
										case 11u:
											skillInstance = null;
											num6 = ((int)num3 * -292021548) ^ 0x3927806;
											continue;
										case 6u:
											num5 = 2;
											num6 = (int)((num3 * 1731107207) ^ 0x3E4C83AA);
											continue;
										case 3u:
											goto end_IL_00c4;
										case 9u:
											goto IL_01be;
										case 1u:
											goto IL_01dd;
										case 0u:
											goto IL_01f7;
										case 10u:
											goto IL_0221;
										case 13u:
											goto IL_0233;
										case 12u:
											num5 = 1;
											num6 = ((int)num3 * -109557784) ^ 0x19B8B43C;
											continue;
										default:
											goto end_IL_01a8;
										}
										if (skill.Hard < 100f)
										{
											num6 = ((int)num3 * -1098122944) ^ -1344209177;
											continue;
										}
										goto IL_0385;
										IL_0233:
										if (current.Skills.Count < current.MAX_SKILL_COUNT)
										{
											num6 = ((int)num3 * -1109187875) ^ -617412634;
											continue;
										}
										goto IL_0385;
										IL_01dd:
										if (skill != null)
										{
											num6 = ((int)num3 * -1171866652) ^ 0x18921E27;
											continue;
										}
										goto IL_0385;
										IL_0221:
										if (num5 > 0)
										{
											num6 = -1723680277;
											continue;
										}
										goto IL_078f;
										IL_01be:
										if (!skill.IsNpc)
										{
											num6 = (int)(num3 * 1296004801) ^ -1061547034;
											continue;
										}
										goto IL_0385;
										IL_01f7:
										int num9;
										if (_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(array[0], ResourceStrings.ResStrings[118]))
										{
											num6 = -896686944;
											num9 = num6;
										}
										else
										{
											num6 = -1567977972;
											num9 = num6;
										}
										continue;
										end_IL_00c4:
										break;
									}
									continue;
									end_IL_01a8:
									break;
								}
								using (List<SkillInstance>.Enumerator enumerator2 = current.Skills.GetEnumerator())
								{
									while (true)
									{
										IL_02b3:
										int num10;
										int num11;
										if (!enumerator2.MoveNext())
										{
											num10 = -1562668833;
											num11 = num10;
										}
										else
										{
											num10 = -1120905711;
											num11 = num10;
										}
										while (true)
										{
											switch ((num3 = (uint)(num10 ^ -932957686)) % 6)
											{
											case 2u:
												num10 = -1120905711;
												continue;
											default:
												goto end_IL_0289;
											case 4u:
												break;
											case 0u:
											{
												int num12;
												int num13;
												if (!_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(current2.Name, text))
												{
													num12 = 1061350384;
													num13 = num12;
												}
												else
												{
													num12 = 344822823;
													num13 = num12;
												}
												num10 = num12 ^ ((int)num3 * -1808805943);
												continue;
											}
											case 1u:
												current2 = enumerator2.Current;
												num10 = -368872662;
												continue;
											case 5u:
												skillInstance = current2;
												goto end_IL_0289;
											case 3u:
												goto end_IL_0289;
											}
											goto IL_02b3;
											continue;
											end_IL_0289:
											break;
										}
										break;
									}
								}
								if (skillInstance == null)
								{
									goto IL_0333;
								}
								goto IL_0385;
							}
							int num14 = -1895769197;
							goto IL_0748;
							IL_0748:
							while (true)
							{
								switch ((num3 = (uint)(num14 ^ -932957686)) % 7)
								{
								case 2u:
									break;
								default:
									goto end_IL_078f;
								case 1u:
									goto IL_0779;
								case 0u:
									goto IL_078f;
								case 4u:
								{
									SpecialSkillInstance item = new SpecialSkillInstance
									{
										name = text
									};
									current.SpecialSkills.Add(item);
									num14 = ((int)num3 * -1406619650) ^ 0x59C20AE8;
									continue;
								}
								case 3u:
									goto end_IL_078f;
								case 6u:
									current.InitBind();
									num14 = (int)((num3 * 1316914574) ^ 0x7BE32F43);
									continue;
								case 5u:
									goto end_IL_078f;
								}
								break;
							}
							goto IL_0743;
							IL_052c:
							int num15;
							while (true)
							{
								switch ((num3 = (uint)(num15 ^ -932957686)) % 10)
								{
								case 5u:
									break;
								case 9u:
									goto IL_056a;
								case 7u:
									goto IL_0580;
								case 0u:
									current.InitBind();
									num15 = (int)((num3 * 1696146842) ^ 0x71A5517A);
									continue;
								case 8u:
									current.InternalSkills.Add(item2);
									num15 = (int)((num3 * 1812188307) ^ 0x324D7098);
									continue;
								case 4u:
									specialSkillInstance = null;
									num15 = (int)(num3 * 572517551) ^ -1531815638;
									continue;
								case 3u:
									goto IL_05ed;
								case 2u:
									RefreshTeamMemberPanel(current, refreshImage: false, refreshText: true);
									num15 = ((int)num3 * -1667464105) ^ -1846849841;
									continue;
								case 1u:
									item2 = new InternalSkillInstance
									{
										name = text,
										level = num,
										level2 = 0f - (float)num,
										Owner = current
									};
									num15 = ((int)num3 * -2028020299) ^ -213108027;
									continue;
								default:
									goto IL_0667;
								}
								break;
								IL_05ed:
								if (!_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(specialSkill.Info))
								{
									num15 = (int)(num3 * 1938732990) ^ -86801443;
									continue;
								}
								goto IL_0779;
								IL_0580:
								if (!specialSkill.IsNpc)
								{
									num15 = (int)((num3 * 673384452) ^ 0x91D0514);
									continue;
								}
								goto IL_0779;
							}
							goto IL_0527;
							IL_0667:
							using (List<SpecialSkillInstance>.Enumerator enumerator3 = current.SpecialSkills.GetEnumerator())
							{
								while (true)
								{
									IL_06c2:
									int num16;
									int num17;
									if (enumerator3.MoveNext())
									{
										num16 = -1620025727;
										num17 = num16;
									}
									else
									{
										num16 = -1038862075;
										num17 = num16;
									}
									while (true)
									{
										switch ((num3 = (uint)(num16 ^ -932957686)) % 7)
										{
										case 3u:
											num16 = -1620025727;
											continue;
										default:
											goto end_IL_067c;
										case 1u:
											goto end_IL_067c;
										case 4u:
											break;
										case 0u:
											specialSkillInstance = current3;
											num16 = (int)(num3 * 1885648162) ^ -478464605;
											continue;
										case 5u:
											current3 = enumerator3.Current;
											num16 = -1303194350;
											continue;
										case 2u:
										{
											int num18;
											int num19;
											if (!_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(current3.Name, text))
											{
												num18 = 1748982974;
												num19 = num18;
											}
											else
											{
												num18 = 2022909708;
												num19 = num18;
											}
											num16 = num18 ^ ((int)num3 * -791753335);
											continue;
										}
										case 6u:
											goto end_IL_067c;
										}
										goto IL_06c2;
										continue;
										end_IL_067c:
										break;
									}
									break;
								}
							}
							if (specialSkillInstance == null)
							{
								goto IL_0743;
							}
							goto IL_0779;
							IL_0743:
							num14 = -1290549022;
							goto IL_0748;
							IL_0385:
							internalSkill = ResourceManager.Get<InternalSkill>(text);
							int num20;
							if (internalSkill != null)
							{
								num20 = -872651788;
								goto IL_0338;
							}
							goto IL_056a;
							IL_0527:
							num15 = -209969863;
							goto IL_052c;
							IL_0338:
							while (true)
							{
								switch ((num3 = (uint)(num20 ^ -932957686)) % 7)
								{
								case 6u:
									break;
								case 4u:
									goto IL_0369;
								case 5u:
									goto IL_0385;
								case 1u:
								{
									SkillInstance item3 = new SkillInstance
									{
										name = text,
										level = num,
										level2 = 0f - (float)num,
										Owner = current
									};
									current.Skills.Add(item3);
									current.InitBind();
									RefreshTeamMemberPanel(current, refreshImage: false, refreshText: true);
									num20 = (int)((num3 * 1582525805) ^ 0x8EA6A6D);
									continue;
								}
								case 2u:
									goto IL_03f3;
								case 3u:
									goto IL_041e;
								default:
									goto IL_0442;
								}
								break;
								IL_041e:
								if (internalSkill.Hard < 100f)
								{
									num20 = (int)((num3 * 1687688975) ^ 0x65A881EB);
									continue;
								}
								goto IL_056a;
								IL_0369:
								if (!internalSkill.IsNpc)
								{
									num20 = (int)((num3 * 319969062) ^ 0x1C393131);
									continue;
								}
								goto IL_056a;
								IL_03f3:
								if (current.InternalSkills.Count < current.MAX_INTERNALSKILL_COUNT)
								{
									num20 = (int)(num3 * 450841031) ^ -713157859;
									continue;
								}
								goto IL_056a;
							}
							goto IL_0333;
							IL_0442:
							InternalSkillInstance internalSkillInstance = null;
							using (List<InternalSkillInstance>.Enumerator enumerator4 = current.InternalSkills.GetEnumerator())
							{
								while (true)
								{
									IL_04e3:
									int num21;
									int num22;
									if (enumerator4.MoveNext())
									{
										num21 = -191866463;
										num22 = num21;
									}
									else
									{
										num21 = -536593813;
										num22 = num21;
									}
									while (true)
									{
										switch ((num3 = (uint)(num21 ^ -932957686)) % 7)
										{
										case 2u:
											num21 = -191866463;
											continue;
										default:
											goto end_IL_045d;
										case 3u:
											goto end_IL_045d;
										case 5u:
											internalSkillInstance = current4;
											num21 = ((int)num3 * -1953605188) ^ 0x419BF43A;
											continue;
										case 0u:
										{
											int num23;
											int num24;
											if (!_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(current4.Name, text))
											{
												num23 = -1301588663;
												num24 = num23;
											}
											else
											{
												num23 = -1805596203;
												num24 = num23;
											}
											num21 = num23 ^ ((int)num3 * -877854846);
											continue;
										}
										case 1u:
											break;
										case 6u:
											current4 = enumerator4.Current;
											num21 = -1009416066;
											continue;
										case 4u:
											goto end_IL_045d;
										}
										goto IL_04e3;
										continue;
										end_IL_045d:
										break;
									}
									break;
								}
							}
							if (internalSkillInstance == null)
							{
								goto IL_0527;
							}
							goto IL_056a;
							IL_0779:
							int num25;
							if (num5 != 1)
							{
								num14 = -697068548;
								num25 = num14;
							}
							else
							{
								num14 = -232188178;
								num25 = num14;
							}
							goto IL_0748;
							IL_0333:
							num20 = -742725298;
							goto IL_0338;
							IL_056a:
							specialSkill = ResourceManager.Get<SpecialSkill>(text);
							if (specialSkill != null)
							{
								num15 = -106848837;
								goto IL_052c;
							}
							goto IL_0779;
							continue;
							end_IL_078f:
							break;
						}
					}
					num4++;
					goto IL_0814;
				}
				case 4u:
					goto IL_0837;
					IL_0814:
					num26 = -495986206;
					goto IL_0819;
					IL_0819:
					switch ((num3 = (uint)(num26 ^ -932957686)) % 3)
					{
					case 0u:
						break;
					default:
						return;
					case 1u:
						goto IL_0837;
					case 2u:
						return;
					}
					goto IL_0814;
					IL_0837:
					if (num4 < array.Length)
					{
						goto default;
					}
					num26 = -1722486817;
					goto IL_0819;
				}
				break;
			}
		}
	}

	public void SetRoleHeadImage(string name)
	{
		string[] array = _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(name, new char[1] { '#' });
		Role current = default(Role);
		while (true)
		{
			int num = 159827577;
			while (true)
			{
				int num11;
				uint num2;
				switch ((num2 = (uint)(num ^ 0x17AE35C2)) % 4)
				{
				case 2u:
					break;
				case 3u:
				{
					int num12;
					if (array.Length <= 1)
					{
						num11 = -1691568354;
						num12 = num11;
					}
					else
					{
						num11 = -653761949;
						num12 = num11;
					}
					goto IL_004c;
				}
				case 0u:
					return;
				default:
				{
					using List<Role>.Enumerator enumerator = Team.GetEnumerator();
					while (true)
					{
						int num3;
						int num4;
						if (enumerator.MoveNext())
						{
							num3 = 1589684181;
							num4 = num3;
						}
						else
						{
							num3 = 651231409;
							num4 = num3;
						}
						while (true)
						{
							switch ((num2 = (uint)(num3 ^ 0x17AE35C2)) % 9)
							{
							case 0u:
								num3 = 1589684181;
								continue;
							default:
								return;
							case 7u:
							{
								int num7;
								int num8;
								if (_200B_202A_200D_202E_206D_202C_202B_202D_202A_206B_200F_206E_202A_200C_206D_200F_206B_206B_202D_200D_206C_202E_200E_202B_206E_206A_206E_200D_206F_202C_206C_202C_202B_206B_206A_206D_200C_200B_202D_200D_202E((Object)(object)mapUI, (Object)null))
								{
									num7 = -219158484;
									num8 = num7;
								}
								else
								{
									num7 = -1617473166;
									num8 = num7;
								}
								num3 = num7 ^ ((int)num2 * -989433317);
								continue;
							}
							case 6u:
								break;
							case 3u:
							{
								int num9;
								int num10;
								if (ResourceManager.Get<Resource>(array[1]) != null)
								{
									num9 = -1441974816;
									num10 = num9;
								}
								else
								{
									num9 = -1135584773;
									num10 = num9;
								}
								num3 = num9 ^ ((int)num2 * -731938224);
								continue;
							}
							case 8u:
								mapUI.RoleStatePanelObj.GetComponent<RoleStatePanelUI>().Refresh();
								RefreshTeamMemberPanel(current, refreshImage: true, refreshText: false);
								return;
							case 1u:
								current = enumerator.Current;
								num3 = 55873088;
								continue;
							case 2u:
							{
								int num5;
								int num6;
								if (!_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current.Key, array[0]))
								{
									num5 = -929994563;
									num6 = num5;
								}
								else
								{
									num5 = -1568647290;
									num6 = num5;
								}
								num3 = num5 ^ (int)(num2 * 327225011);
								continue;
							}
							case 4u:
								current.Head = array[1];
								num3 = (int)((num2 * 651727662) ^ 0x5E92BDE7);
								continue;
							case 5u:
								return;
							}
							break;
						}
					}
				}
				}
				break;
				IL_004c:
				num = num11 ^ ((int)num2 * -1623248312);
			}
		}
	}

	public void HPMP(string name)
	{
		string[] array = _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(name, new char[1] { '#' });
		if (array.Length <= 1)
		{
			goto IL_0018;
		}
		goto IL_006a;
		IL_0018:
		int num = 934643635;
		goto IL_001d;
		IL_001d:
		Role current = default(Role);
		int mAX_HPMP = default(int);
		int num13 = default(int);
		int num7 = default(int);
		while (true)
		{
			int num3;
			int num4;
			uint num2;
			switch ((num2 = (uint)(num ^ 0x420B65FF)) % 5)
			{
			case 0u:
				break;
			case 4u:
				return;
			case 2u:
				if (array.Length <= 2)
				{
					num = ((int)num2 * -1464381762) ^ 0xDE761A9;
					continue;
				}
				num3 = int.Parse(array[2]);
				goto IL_008c;
			case 1u:
				goto IL_006a;
			default:
				{
					num3 = int.Parse(array[1]);
					goto IL_008c;
				}
				IL_008c:
				num4 = num3;
				using (List<Role>.Enumerator enumerator = Team.GetEnumerator())
				{
					while (true)
					{
						int num5;
						int num6;
						if (enumerator.MoveNext())
						{
							num5 = 1439603606;
							num6 = num5;
						}
						else
						{
							num5 = 370932978;
							num6 = num5;
						}
						while (true)
						{
							switch ((num2 = (uint)(num5 ^ 0x420B65FF)) % 18)
							{
							case 2u:
								num5 = 1439603606;
								continue;
							default:
								return;
							case 14u:
							{
								int num14;
								if (current.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2434912689u)] <= mAX_HPMP)
								{
									num5 = 1313784452;
									num14 = num5;
								}
								else
								{
									num5 = 44924048;
									num14 = num5;
								}
								continue;
							}
							case 1u:
								current.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1796919217u)] = current.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1995100678u)] + num13;
								num5 = (int)((num2 * 950585882) ^ 0x2E45BCE9);
								continue;
							case 12u:
							{
								int num17;
								if (num7 <= 0)
								{
									num5 = 531108998;
									num17 = num5;
								}
								else
								{
									num5 = 372040742;
									num17 = num5;
								}
								continue;
							}
							case 6u:
								current.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2431070502u)] = mAX_HPMP;
								num5 = ((int)num2 * -386194506) ^ -1442652603;
								continue;
							case 8u:
								num5 = ((int)num2 * -2072300984) ^ -349604815;
								continue;
							case 7u:
								break;
							case 0u:
							{
								num7 = 0;
								int num9;
								int num10;
								if (_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current.Key, array[0]))
								{
									num9 = -169246678;
									num10 = num9;
								}
								else
								{
									num9 = -727334462;
									num10 = num9;
								}
								num5 = num9 ^ ((int)num2 * -648213554);
								continue;
							}
							case 13u:
								num7 = 1;
								num5 = (int)(num2 * 1966324629) ^ -498563174;
								continue;
							case 5u:
							{
								RefreshTeamMemberPanel(current, refreshImage: false, refreshText: true);
								int num15;
								int num16;
								if (num7 != 1)
								{
									num15 = 373754982;
									num16 = num15;
								}
								else
								{
									num15 = 1679997961;
									num16 = num15;
								}
								num5 = num15 ^ ((int)num2 * -1843189408);
								continue;
							}
							case 10u:
							{
								current.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(11946387u)] = current.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(187771104u)] + num4;
								mAX_HPMP = current.MAX_HPMP;
								int num11;
								int num12;
								if (current.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1995100678u)] <= mAX_HPMP)
								{
									num11 = 948266629;
									num12 = num11;
								}
								else
								{
									num11 = 412727265;
									num12 = num11;
								}
								num5 = num11 ^ ((int)num2 * -1249169307);
								continue;
							}
							case 15u:
								current.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(11946387u)] = mAX_HPMP;
								num5 = (int)((num2 * 1608882166) ^ 0x47A92B2E);
								continue;
							case 9u:
							{
								int num8;
								if (!_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(array[0], ResourceStrings.ResStrings[118]))
								{
									num5 = 731394737;
									num8 = num5;
								}
								else
								{
									num5 = 240316537;
									num8 = num5;
								}
								continue;
							}
							case 17u:
								current.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1768687720u)] = current.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2431070502u)];
								current.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(395646854u)] = current.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(187771104u)];
								num5 = 1775970570;
								continue;
							case 4u:
								return;
							case 3u:
								current = enumerator.Current;
								num5 = 1116573961;
								continue;
							case 16u:
								num7 = 2;
								num5 = (int)((num2 * 1484489051) ^ 0x40A9E13);
								continue;
							case 11u:
								return;
							}
							break;
						}
					}
				}
			}
			break;
		}
		goto IL_0018;
		IL_006a:
		num13 = int.Parse(array[1]);
		num = 1618745440;
		goto IL_001d;
	}

	public void tianfu(string name)
	{
		string[] array = _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(name, new char[1] { '+' });
		if (array.Length < 2)
		{
			goto IL_0018;
		}
		goto IL_0069;
		IL_0018:
		int num = 211631840;
		goto IL_001d;
		IL_001d:
		Role current = default(Role);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x62925FF0)) % 7)
			{
			case 0u:
				break;
			case 5u:
				return;
			case 1u:
				num = ((int)num2 * -1603134695) ^ 0x4F7A4413;
				continue;
			case 6u:
				goto IL_0069;
			case 4u:
				goto IL_007b;
			case 2u:
				array[1] = _202E_200D_206D_206C_202C_200C_206B_206A_206A_202C_200C_200F_200D_202E_200C_202E_202B_206B_200E_200C_206D_200F_200E_206C_200F_200E_200D_200C_202E_206F_206C_200F_200B_202E_200C_206F_206D_202D_202B_202E_202E(array[1], 1, _200B_202C_200E_202C_202C_200E_206C_200F_206C_200B_206C_206F_202C_202C_206A_206D_206F_206C_200E_200F_200B_202A_206D_206B_202E_200F_206C_206C_200D_200B_206D_206F_206F_200D_206A_202E_200D_206C_200E_206B_202E(array[1]) - 1);
				num = 2029901294;
				continue;
			default:
			{
				using List<Role>.Enumerator enumerator = Team.GetEnumerator();
				while (true)
				{
					int num3;
					int num4;
					if (enumerator.MoveNext())
					{
						num3 = 152123252;
						num4 = num3;
					}
					else
					{
						num3 = 1284058250;
						num4 = num3;
					}
					while (true)
					{
						switch ((num2 = (uint)(num3 ^ 0x62925FF0)) % 8)
						{
						case 0u:
							num3 = 152123252;
							continue;
						default:
							return;
						case 4u:
						{
							current = enumerator.Current;
							int num6;
							if (!_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current.Key, array[0]))
							{
								num3 = 1672589531;
								num6 = num3;
							}
							else
							{
								num3 = 1997169185;
								num6 = num3;
							}
							continue;
						}
						case 1u:
							current.TalentValue = array[1];
							RefreshTeamMemberPanel(current, refreshImage: false, refreshText: true);
							return;
						case 3u:
						{
							int num5;
							if (!_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(array[0], ResourceStrings.ResStrings[118]))
							{
								num3 = 271332781;
								num5 = num3;
							}
							else
							{
								num3 = 1538494318;
								num5 = num3;
							}
							continue;
						}
						case 6u:
							current.TalentValue = array[1];
							num3 = ((int)num2 * -391981048) ^ -1257439897;
							continue;
						case 7u:
							RefreshTeamMemberPanel(current, refreshImage: false, refreshText: true);
							num3 = ((int)num2 * -760795330) ^ 0x7F04A05F;
							continue;
						case 5u:
							break;
						case 2u:
							return;
						}
						break;
					}
				}
			}
			}
			break;
			IL_007b:
			int num7;
			if (_202A_206C_206B_206F_200C_206D_202E_202C_206D_200C_206B_200F_200E_206E_206A_206E_206D_202B_206F_206C_202E_206E_202D_206E_200D_206E_202C_200D_200D_202A_200C_206D_206B_202D_200B_206A_200D_200B_200B_202A_202E(array[1], global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1541154258u)))
			{
				num = 580290566;
				num7 = num;
			}
			else
			{
				num = 1777635170;
				num7 = num;
			}
		}
		goto IL_0018;
		IL_0069:
		array[1] = _202E_200F_200D_206A_202A_206D_200D_206F_200D_200E_202C_206D_202B_202A_206C_202B_200F_200B_202A_206C_200C_200E_200F_202E_206A_200B_202C_206E_200C_206D_206D_202E_202A_202B_206D_200B_202D_200B_202C_202E(array[1]);
		num = 1897623925;
		goto IL_001d;
	}

	public void addtianfu(string name)
	{
		string[] array = _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(name, new char[1] { '#' });
		int num2 = default(int);
		Role current = default(Role);
		while (true)
		{
			int num3;
			uint num;
			switch ((num = 854540554u) % 3)
			{
			case 2u:
				break;
			case 1u:
				num2 = 0;
				goto IL_02dc;
			default:
				{
					using (List<Role>.Enumerator enumerator = Team.GetEnumerator())
					{
						while (true)
						{
							IL_01bc:
							int num4;
							int num5;
							if (enumerator.MoveNext())
							{
								num4 = -1333871728;
								num5 = num4;
							}
							else
							{
								num4 = -582293036;
								num5 = num4;
							}
							while (true)
							{
								switch ((num = (uint)(num4 ^ -1574037761)) % 15)
								{
								case 4u:
									num4 = -1333871728;
									continue;
								default:
									goto end_IL_0062;
								case 10u:
									goto end_IL_0062;
								case 13u:
								{
									int num16;
									if (!_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current.Key, array[0]))
									{
										num4 = -1783185683;
										num16 = num4;
									}
									else
									{
										num4 = -693095536;
										num16 = num4;
									}
									continue;
								}
								case 5u:
									RefreshTeamMemberPanel(current, refreshImage: false, refreshText: true);
									num4 = (int)((num * 292326521) ^ 0x41F0F661);
									continue;
								case 9u:
									num4 = ((int)num * -1428355717) ^ 0x4F83604A;
									continue;
								case 12u:
									current.Talents.Add(array[num2 + 1]);
									RefreshTeamMemberPanel(current, refreshImage: false, refreshText: true);
									num4 = (int)(num * 1375057011) ^ -282137331;
									continue;
								case 14u:
								{
									int num10;
									int num11;
									if (!current.Talents.Contains(array[num2 + 1]))
									{
										num10 = 2020403170;
										num11 = num10;
									}
									else
									{
										num10 = 1902882269;
										num11 = num10;
									}
									num4 = num10 ^ ((int)num * -1232943654);
									continue;
								}
								case 8u:
								{
									int num8;
									int num9;
									if (_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(array[0], ResourceStrings.ResStrings[118]))
									{
										num8 = 502975252;
										num9 = num8;
									}
									else
									{
										num8 = 931815213;
										num9 = num8;
									}
									num4 = num8 ^ (int)(num * 398734443);
									continue;
								}
								case 7u:
									current = enumerator.Current;
									num4 = -368064989;
									continue;
								case 3u:
									break;
								case 6u:
								{
									int num14;
									int num15;
									if (ResourceManager.Get<Resource>(_206A_200C_200F_206E_202E_206D_206E_200E_202D_200E_202A_200F_200E_200B_202A_206B_200B_202A_202E_206A_202B_206C_200F_202C_202D_200F_202D_206E_206D_202A_202A_200C_200C_206D_200B_202B_202B_200C_200E_200C_202E(ResourceStrings.ResStrings[1107], array[num2 + 1])) != null)
									{
										num14 = 978777593;
										num15 = num14;
									}
									else
									{
										num14 = 781801747;
										num15 = num14;
									}
									num4 = num14 ^ ((int)num * -1406964670);
									continue;
								}
								case 1u:
									current.Talents.Add(array[num2 + 1]);
									num4 = ((int)num * -1966746039) ^ 0x29C75A8F;
									continue;
								case 2u:
								{
									int num12;
									int num13;
									if (ResourceManager.Get<Resource>(_206A_200C_200F_206E_202E_206D_206E_200E_202D_200E_202A_200F_200E_200B_202A_206B_200B_202A_202E_206A_202B_206C_200F_202C_202D_200F_202D_206E_206D_202A_202A_200C_200C_206D_200B_202B_202B_200C_200E_200C_202E(ResourceStrings.ResStrings[1107], array[num2 + 1])) != null)
									{
										num12 = 2042595557;
										num13 = num12;
									}
									else
									{
										num12 = 1167217668;
										num13 = num12;
									}
									num4 = num12 ^ ((int)num * -318719705);
									continue;
								}
								case 11u:
								{
									int num6;
									int num7;
									if (!current.Talents.Contains(array[num2 + 1]))
									{
										num6 = -1449608071;
										num7 = num6;
									}
									else
									{
										num6 = -62357902;
										num7 = num6;
									}
									num4 = num6 ^ ((int)num * -1645993819);
									continue;
								}
								case 0u:
									goto end_IL_0062;
								}
								goto IL_01bc;
								continue;
								end_IL_0062:
								break;
							}
							break;
						}
					}
					num2++;
					goto IL_02b9;
				}
				IL_02dc:
				if (num2 < array.Length - 1)
				{
					goto default;
				}
				num3 = -1532205196;
				goto IL_02be;
				IL_02b9:
				num3 = -1240027912;
				goto IL_02be;
				IL_02be:
				switch ((num = (uint)(num3 ^ -1574037761)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_02dc;
				case 1u:
					return;
				}
				goto IL_02b9;
			}
		}
	}

	public void deltianfu(string name)
	{
		string[] array = _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(name, new char[1] { '#' });
		if (array.Length < 2)
		{
			goto IL_0018;
		}
		goto IL_0069;
		IL_0018:
		int num = 1790162900;
		goto IL_001d;
		IL_001d:
		int num5 = default(int);
		int num9;
		uint num2;
		switch ((num2 = (uint)(num ^ 0x28D03756)) % 5)
		{
		case 2u:
			break;
		case 3u:
			return;
		case 4u:
			goto IL_0069;
		default:
		{
			using (List<Role>.Enumerator enumerator = Team.GetEnumerator())
			{
				Role current = default(Role);
				while (true)
				{
					IL_00c7:
					int num3;
					int num4;
					if (enumerator.MoveNext())
					{
						num3 = 1284998790;
						num4 = num3;
					}
					else
					{
						num3 = 406104114;
						num4 = num3;
					}
					while (true)
					{
						switch ((num2 = (uint)(num3 ^ 0x28D03756)) % 11)
						{
						case 5u:
							num3 = 1284998790;
							continue;
						default:
							goto end_IL_0085;
						case 6u:
							break;
						case 1u:
						{
							int num7;
							int num8;
							if (_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current.Key, array[0]))
							{
								num7 = 1610929346;
								num8 = num7;
							}
							else
							{
								num7 = 1046382781;
								num8 = num7;
							}
							num3 = num7 ^ ((int)num2 * -1520527576);
							continue;
						}
						case 2u:
							RefreshTeamMemberPanel(current, refreshImage: false, refreshText: true);
							num3 = ((int)num2 * -1491562606) ^ -944685066;
							continue;
						case 10u:
						{
							int num6;
							if (!_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(array[0], ResourceStrings.ResStrings[118]))
							{
								num3 = 1546126922;
								num6 = num3;
							}
							else
							{
								num3 = 548991662;
								num6 = num3;
							}
							continue;
						}
						case 8u:
							current = enumerator.Current;
							num3 = 170317199;
							continue;
						case 7u:
							current.Talents.Remove(array[num5 + 1]);
							num3 = ((int)num2 * -874935708) ^ -80843576;
							continue;
						case 4u:
							goto end_IL_0085;
						case 3u:
							RefreshTeamMemberPanel(current, refreshImage: false, refreshText: true);
							num3 = (int)(num2 * 1752156744) ^ -1777596881;
							continue;
						case 0u:
							current.Talents.Remove(array[num5 + 1]);
							num3 = (int)((num2 * 1225926085) ^ 0x537FF860);
							continue;
						case 9u:
							goto end_IL_0085;
						}
						goto IL_00c7;
						continue;
						end_IL_0085:
						break;
					}
					break;
				}
			}
			num5++;
			goto IL_01f3;
		}
		case 1u:
			goto IL_0216;
			IL_0216:
			if (num5 < array.Length - 1)
			{
				goto default;
			}
			num9 = 958534594;
			goto IL_01f8;
			IL_01f3:
			num9 = 1393552127;
			goto IL_01f8;
			IL_01f8:
			switch ((num2 = (uint)(num9 ^ 0x28D03756)) % 3)
			{
			case 0u:
				break;
			default:
				return;
			case 1u:
				goto IL_0216;
			case 2u:
				return;
			}
			goto IL_01f3;
		}
		goto IL_0018;
		IL_0069:
		num5 = 0;
		num = 1527771901;
		goto IL_001d;
	}

	public bool SetRoleAnimation(string name)
	{
		string[] array = _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(name, new char[1] { '#' });
		if (array.Length == 0)
		{
			goto IL_0019;
		}
		goto IL_015b;
		IL_0019:
		int num = 79204797;
		goto IL_001e;
		IL_001e:
		Role teamRole = default(Role);
		string text = default(string);
		bool flag = default(bool);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x24A6E541)) % 21)
			{
			case 4u:
				break;
			case 12u:
				teamRole.Animation = text;
				num = (int)(num2 * 1453921653) ^ -126001257;
				continue;
			case 7u:
				goto IL_00a2;
			case 14u:
				num = (int)(num2 * 1069328801) ^ -1038579346;
				continue;
			case 8u:
			{
				int num9;
				int num10;
				if (teamRole == null)
				{
					num9 = -130697786;
					num10 = num9;
				}
				else
				{
					num9 = -1358990518;
					num10 = num9;
				}
				num = num9 ^ ((int)num2 * -1629980133);
				continue;
			}
			case 6u:
			{
				int num5;
				int num6;
				if (_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(text))
				{
					num5 = 1921474548;
					num6 = num5;
				}
				else
				{
					num5 = 1276972149;
					num6 = num5;
				}
				num = num5 ^ (int)(num2 * 1546232256);
				continue;
			}
			case 13u:
				num = (int)(num2 * 1068380526) ^ -1939018934;
				continue;
			case 18u:
				flag = true;
				num = ((int)num2 * -1630886239) ^ 0x59AF6DB5;
				continue;
			case 2u:
				goto IL_0139;
			case 5u:
				goto IL_015b;
			case 0u:
				mapUI.ShowCustomDialogs(_206A_206B_202D_202E_200E_206D_202D_202E_206D_200E_202A_202B_206D_200F_202D_206E_202E_200D_202E_202E_206F_200F_200F_200F_206B_202E_202C_200F_202B_202C_200B_206D_202E_200E_200C_202C_200F_202E_202B_206D_202E(ResourceStrings.ResStrings[0], global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2703812968u), text));
				num = (int)(num2 * 166831099) ^ -1522379278;
				continue;
			case 16u:
				teamRole = GetTeamRole(array[0]);
				num = ((int)num2 * -487067330) ^ 0x9B1DBBB;
				continue;
			case 20u:
				goto IL_01c5;
			case 10u:
				return false;
			case 1u:
				teamRole.Animation = ResourceManager.Get<Role>(array[0]).Animation;
				flag = true;
				num = 763355594;
				continue;
			case 9u:
				goto IL_0210;
			case 17u:
			{
				int num7;
				int num8;
				if (UserDefinedAnimationManager.instance.HasAnimation(text, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3622903170u)))
				{
					num7 = -1407732719;
					num8 = num7;
				}
				else
				{
					num7 = -780351281;
					num8 = num7;
				}
				num = num7 ^ (int)(num2 * 176560611);
				continue;
			}
			case 15u:
				flag = true;
				num = ((int)num2 * -1577097722) ^ 0x2FE51DF2;
				continue;
			case 11u:
				num = ((int)num2 * -1001894704) ^ 0x1BE2CEB3;
				continue;
			case 19u:
			{
				int num3;
				int num4;
				if (CommonSettings.MOD_KEY() < 0)
				{
					num3 = -2123507023;
					num4 = num3;
				}
				else
				{
					num3 = -2026990101;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 39562184);
				continue;
			}
			default:
				return flag;
			}
			break;
			IL_0210:
			int num11;
			if (_200B_202A_200D_202E_206D_202C_202B_202D_202A_206B_200F_206E_202A_200C_206D_200F_206B_206B_202D_200D_206C_202E_200E_202B_206E_206A_206E_200D_206F_202C_206C_202C_202B_206B_206A_206D_200C_200B_202D_200D_202E((Object)(object)ResourcePool.Get(_206A_200C_200F_206E_202E_206D_206E_200E_202D_200E_202A_200F_200E_200B_202A_206B_200B_202A_202E_206A_202B_206C_200F_202C_202D_200F_202D_206E_206D_202A_202A_200C_200C_206D_200B_202B_202B_200C_200E_200C_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(875055782u), text)), (Object)null))
			{
				num = 542538679;
				num11 = num;
			}
			else
			{
				num = 1026298115;
				num11 = num;
			}
			continue;
			IL_01c5:
			int num12;
			if (!flag)
			{
				num = 1037091464;
				num12 = num;
			}
			else
			{
				num = 610639275;
				num12 = num;
			}
			continue;
			IL_0139:
			int num13;
			if (!_200B_202A_200D_202E_206D_202C_202B_202D_202A_206B_200F_206E_202A_200C_206D_200F_206B_206B_202D_200D_206C_202E_200E_202B_206E_206A_206E_200D_206F_202C_206C_202C_202B_206B_206A_206D_200C_200B_202D_200D_202E((Object)(object)mapUI, (Object)null))
			{
				num = 763355594;
				num13 = num;
			}
			else
			{
				num = 1273744040;
				num13 = num;
			}
		}
		goto IL_0019;
		IL_00a2:
		object obj = string.Empty;
		goto IL_00ac;
		IL_00ac:
		text = (string)obj;
		flag = false;
		num = 1584526544;
		goto IL_001e;
		IL_015b:
		if (array.Length > 1)
		{
			obj = array[1];
			goto IL_00ac;
		}
		num = 1362011192;
		goto IL_001e;
	}

	public void addAttrib(string name, int dianshu)
	{
		string[] array = _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(name, new char[1] { '#' });
		int num21 = default(int);
		string[] array2 = default(string[]);
		Role current = default(Role);
		int num6 = default(int);
		int num5 = default(int);
		string text = default(string);
		while (true)
		{
			int num = -789722317;
			while (true)
			{
				int num52;
				uint num2;
				switch ((num2 = (uint)(num ^ -1600797696)) % 11)
				{
				case 8u:
					break;
				case 10u:
					return;
				case 5u:
					num21 = 0;
					num = ((int)num2 * -1456907109) ^ 0x407462EC;
					continue;
				case 3u:
				{
					int num53;
					if (dianshu <= 100)
					{
						num = -1606047410;
						num53 = num;
					}
					else
					{
						num = -1469329065;
						num53 = num;
					}
					continue;
				}
				case 6u:
					array2 = _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(ResourceStrings.ResStrings[583], new char[1] { '#' });
					num = -1977270507;
					continue;
				case 9u:
				{
					int num50;
					int num51;
					if (dianshu >= -100)
					{
						num50 = 200217891;
						num51 = num50;
					}
					else
					{
						num50 = 618613549;
						num51 = num50;
					}
					num = num50 ^ (int)(num2 * 2109608473);
					continue;
				}
				case 0u:
				{
					int num54;
					if (array.Length >= 2)
					{
						num = -2018858526;
						num54 = num;
					}
					else
					{
						num = -1716599934;
						num54 = num;
					}
					continue;
				}
				case 1u:
					dianshu = 100;
					num = ((int)num2 * -1839685530) ^ -163624476;
					continue;
				case 2u:
					dianshu = -100;
					num = (int)((num2 * 1844497071) ^ 0x4E87D904);
					continue;
				default:
				{
					using (List<Role>.Enumerator enumerator = Team.GetEnumerator())
					{
						while (true)
						{
							IL_09be:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -1166660086;
								num4 = num3;
							}
							else
							{
								num3 = -752569880;
								num4 = num3;
							}
							while (true)
							{
								switch ((num2 = (uint)(num3 ^ -1600797696)) % 54)
								{
								case 10u:
									num3 = -1166660086;
									continue;
								default:
									goto end_IL_0154;
								case 43u:
								{
									current.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(400004197u)] = current.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(400004197u)] + dianshu;
									int num29;
									int num30;
									if (current.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(912726802u)] <= num6)
									{
										num29 = 502606715;
										num30 = num29;
									}
									else
									{
										num29 = 1954475323;
										num30 = num29;
									}
									num3 = num29 ^ (int)(num2 * 65329803);
									continue;
								}
								case 47u:
								{
									current.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1944260873u)] = current.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2053407229u)] + dianshu;
									int num13;
									if (current.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(424952987u)] <= num6)
									{
										num3 = -1669877936;
										num13 = num3;
									}
									else
									{
										num3 = -1593690410;
										num13 = num3;
									}
									continue;
								}
								case 5u:
								{
									current.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2741516750u)] = current.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2741516750u)] + dianshu;
									int num35;
									int num36;
									if (current.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2741516750u)] <= num6)
									{
										num35 = -1256451518;
										num36 = num35;
									}
									else
									{
										num35 = -1392146043;
										num36 = num35;
									}
									num3 = num35 ^ (int)(num2 * 381597658);
									continue;
								}
								case 31u:
									num3 = ((int)num2 * -316921763) ^ 0x3EF3AA1F;
									continue;
								case 53u:
									current.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3535376985u)] = num6;
									num3 = ((int)num2 * -1075767177) ^ -1454795419;
									continue;
								case 52u:
								{
									current.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4176639349u)] = current.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2249625138u)] + dianshu;
									int num42;
									if (current.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(942219431u)] > num6)
									{
										num3 = -1575788721;
										num42 = num3;
									}
									else
									{
										num3 = -1669877936;
										num42 = num3;
									}
									continue;
								}
								case 6u:
								{
									int num31;
									int num32;
									if (num5 == 1)
									{
										num31 = -1667099567;
										num32 = num31;
									}
									else
									{
										num31 = -120505255;
										num32 = num31;
									}
									num3 = num31 ^ (int)(num2 * 474556814);
									continue;
								}
								case 9u:
									text = array[num21 + 1];
									num3 = (int)((num2 * 1280135177) ^ 0x5D17D89F);
									continue;
								case 23u:
								{
									int num9;
									if (!_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(text, array2[11]))
									{
										num3 = -1752712826;
										num9 = num3;
									}
									else
									{
										num3 = -877444143;
										num9 = num3;
									}
									continue;
								}
								case 15u:
									current.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2930940463u)] = num6;
									num3 = ((int)num2 * -2019330445) ^ 0x5D9AF04E;
									continue;
								case 36u:
								{
									int num46;
									if (!_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(text, ResourceStrings.ResStrings[1034]))
									{
										num3 = -1974148558;
										num46 = num3;
									}
									else
									{
										num3 = -1361397232;
										num46 = num3;
									}
									continue;
								}
								case 51u:
									current.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(136168559u)] = num6;
									num3 = ((int)num2 * -834433283) ^ 0x211D3645;
									continue;
								case 19u:
								{
									int num26;
									int num27;
									if (current.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2301880830u)] <= num6)
									{
										num26 = -768703710;
										num27 = num26;
									}
									else
									{
										num26 = -159981437;
										num27 = num26;
									}
									num3 = num26 ^ (int)(num2 * 425011382);
									continue;
								}
								case 49u:
								{
									int num20;
									if (_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(array[0], ResourceStrings.ResStrings[118]))
									{
										num3 = -1374247658;
										num20 = num3;
									}
									else
									{
										num3 = -1002723576;
										num20 = num3;
									}
									continue;
								}
								case 27u:
								{
									current.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2223184606u)] = current.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(704292959u)] + dianshu;
									int num17;
									if (current.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(704292959u)] <= num6)
									{
										num3 = -1669877936;
										num17 = num3;
									}
									else
									{
										num3 = -1813564165;
										num17 = num3;
									}
									continue;
								}
								case 34u:
								{
									int num10;
									if (!_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(text, array2[10]))
									{
										num3 = -1669877936;
										num10 = num3;
									}
									else
									{
										num3 = -66284319;
										num10 = num3;
									}
									continue;
								}
								case 33u:
									current.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(136168559u)] = current.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(739543880u)] + dianshu;
									num3 = (int)(num2 * 2089409078) ^ -948348947;
									continue;
								case 39u:
									num3 = (int)(num2 * 1646084714) ^ -2058808858;
									continue;
								case 1u:
									current.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(942219431u)] = num6;
									num3 = (int)(num2 * 1554597727) ^ -864456930;
									continue;
								case 48u:
								{
									current.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1564888282u)] = current.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1564888282u)] + dianshu;
									int num43;
									int num44;
									if (current.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3795453722u)] > num6)
									{
										num43 = 341780160;
										num44 = num43;
									}
									else
									{
										num43 = 525522738;
										num44 = num43;
									}
									num3 = num43 ^ ((int)num2 * -90295473);
									continue;
								}
								case 35u:
									current.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1940200750u)] = num6;
									num3 = ((int)num2 * -2101546093) ^ -2006643087;
									continue;
								case 50u:
								{
									int num37;
									int num38;
									if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(text, ResourceStrings.ResStrings[1031]))
									{
										num37 = -1949982317;
										num38 = num37;
									}
									else
									{
										num37 = -204331138;
										num38 = num37;
									}
									num3 = num37 ^ (int)(num2 * 1168654475);
									continue;
								}
								case 0u:
								{
									num5 = 0;
									int num24;
									int num25;
									if (_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current.Key, array[0]))
									{
										num24 = -686545441;
										num25 = num24;
									}
									else
									{
										num24 = -1410533635;
										num25 = num24;
									}
									num3 = num24 ^ ((int)num2 * -761703931);
									continue;
								}
								case 14u:
									current = enumerator.Current;
									num3 = -2120628303;
									continue;
								case 44u:
								{
									int num18;
									if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(text, array2[9]))
									{
										num3 = -399616627;
										num18 = num3;
									}
									else
									{
										num3 = -175627611;
										num18 = num3;
									}
									continue;
								}
								case 42u:
								{
									int num14;
									int num15;
									if (!_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(text, array2[3]))
									{
										num14 = 107823559;
										num15 = num14;
									}
									else
									{
										num14 = 1624651235;
										num15 = num14;
									}
									num3 = num14 ^ (int)(num2 * 1592894652);
									continue;
								}
								case 13u:
								{
									int num48;
									int num49;
									if (current.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(430829805u)] > num6)
									{
										num48 = -354756749;
										num49 = num48;
									}
									else
									{
										num48 = -1234885232;
										num49 = num48;
									}
									num3 = num48 ^ ((int)num2 * -2110665920);
									continue;
								}
								case 25u:
								{
									int num47;
									if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(text, ResourceStrings.ResStrings[1032]))
									{
										num3 = -799247597;
										num47 = num3;
									}
									else
									{
										num3 = -270702844;
										num47 = num3;
									}
									continue;
								}
								case 40u:
									current.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3665747899u)] = num6;
									num3 = (int)((num2 * 1687990997) ^ 0x3AEFE39A);
									continue;
								case 30u:
								{
									int num45;
									if (num5 <= 0)
									{
										num3 = -2128725139;
										num45 = num3;
									}
									else
									{
										num3 = -1193922018;
										num45 = num3;
									}
									continue;
								}
								case 3u:
									goto end_IL_0154;
								case 16u:
									current.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(400004197u)] = num6;
									num3 = ((int)num2 * -1281172229) ^ -553532960;
									continue;
								case 45u:
									current.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3051962998u)] = current.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1790491204u)] + dianshu;
									num3 = (int)((num2 * 115523707) ^ 0x29184897);
									continue;
								case 22u:
									num6 = _200B_202A_202E_206F_206B_200E_202E_206A_206E_202B_202D_206B_202D_202C_206C_202A_200C_200C_206D_206F_202A_200D_200C_202E_202A_206C_206F_202C_200E_206C_202B_202D_202E_206F_200B_200D_202E_200C_202B_202C_202E(3000, current.MAX_ATTRIBUTE);
									num3 = (int)((num2 * 531559268) ^ 0x6E97EE7C);
									continue;
								case 46u:
								{
									int num40;
									int num41;
									if (!_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(text, array2[2]))
									{
										num40 = -1270493265;
										num41 = num40;
									}
									else
									{
										num40 = -447849865;
										num41 = num40;
									}
									num3 = num40 ^ (int)(num2 * 1779543332);
									continue;
								}
								case 7u:
								{
									int num39;
									if (!_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(text, array2[6]))
									{
										num3 = -2110965338;
										num39 = num3;
									}
									else
									{
										num3 = -372931555;
										num39 = num3;
									}
									continue;
								}
								case 28u:
									current.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3628012406u)] = num6;
									num3 = (int)((num2 * 768690373) ^ 0x7E1CD400);
									continue;
								case 12u:
									num3 = (int)((num2 * 687343780) ^ 0x393CB5F0);
									continue;
								case 21u:
								{
									int num33;
									int num34;
									if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(text, array2[4]))
									{
										num33 = 2078948960;
										num34 = num33;
									}
									else
									{
										num33 = 101554909;
										num34 = num33;
									}
									num3 = num33 ^ (int)(num2 * 115135217);
									continue;
								}
								case 17u:
								{
									int num28;
									if (!_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(text, ResourceStrings.ResStrings[1033]))
									{
										num3 = -316131955;
										num28 = num3;
									}
									else
									{
										num3 = -1731710499;
										num28 = num3;
									}
									continue;
								}
								case 29u:
									break;
								case 20u:
								{
									int num22;
									int num23;
									if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(text, array2[5]))
									{
										num22 = -1908357128;
										num23 = num22;
									}
									else
									{
										num22 = -1315515349;
										num23 = num22;
									}
									num3 = num22 ^ ((int)num2 * -1310660332);
									continue;
								}
								case 18u:
									num5 = 2;
									num3 = (int)(num2 * 1223451618) ^ -1963683740;
									continue;
								case 24u:
									current.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(788062007u)] = num6;
									num3 = (int)((num2 * 433523055) ^ 0x4328AC02);
									continue;
								case 41u:
								{
									int num19;
									if (!_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(text, array2[7]))
									{
										num3 = -1183301622;
										num19 = num3;
									}
									else
									{
										num3 = -2129545986;
										num19 = num3;
									}
									continue;
								}
								case 32u:
								{
									int num16;
									if (!_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(text, array2[8]))
									{
										num3 = -1003129667;
										num16 = num3;
									}
									else
									{
										num3 = -1339905352;
										num16 = num3;
									}
									continue;
								}
								case 4u:
								{
									current.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1550623476u)] = current.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(788062007u)] + dianshu;
									int num11;
									int num12;
									if (current.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1412133437u)] > num6)
									{
										num11 = -2103824266;
										num12 = num11;
									}
									else
									{
										num11 = -261419032;
										num12 = num11;
									}
									num3 = num11 ^ (int)(num2 * 679297985);
									continue;
								}
								case 26u:
									current.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1944260873u)] = num6;
									num3 = (int)(num2 * 1704407989) ^ -1937834978;
									continue;
								case 2u:
								{
									int num7;
									int num8;
									if (current.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1790491204u)] > num6)
									{
										num7 = -1111814408;
										num8 = num7;
									}
									else
									{
										num7 = -464697672;
										num8 = num7;
									}
									num3 = num7 ^ ((int)num2 * -409783725);
									continue;
								}
								case 11u:
									current.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(248942232u)] = current.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(269729863u)] + dianshu;
									num3 = -1565595209;
									continue;
								case 8u:
									RefreshTeamMemberPanel(current, refreshImage: false, refreshText: true);
									num3 = -1227213418;
									continue;
								case 37u:
									num5 = 1;
									num3 = ((int)num2 * -897237599) ^ -2128814967;
									continue;
								case 38u:
									goto end_IL_0154;
								}
								goto IL_09be;
								continue;
								end_IL_0154:
								break;
							}
							break;
						}
					}
					num21++;
					goto IL_0bc2;
				}
				case 7u:
					goto IL_0be5;
					IL_0bc2:
					num52 = -2047046506;
					goto IL_0bc7;
					IL_0bc7:
					switch ((num2 = (uint)(num52 ^ -1600797696)) % 3)
					{
					case 2u:
						break;
					default:
						return;
					case 1u:
						goto IL_0be5;
					case 0u:
						return;
					}
					goto IL_0bc2;
					IL_0be5:
					if (num21 < array.Length - 1)
					{
						goto default;
					}
					num52 = -1948771891;
					goto IL_0bc7;
				}
				break;
			}
		}
	}

	public string GetRoleKeyFromRoleName(string roleName)
	{
		IEnumerator<Role> enumerator = ResourceManager.GetAll<Role>().GetEnumerator();
		try
		{
			Role current = default(Role);
			string key = default(string);
			while (true)
			{
				IL_0075:
				int num;
				int num2;
				if (_200C_202A_206C_202A_200E_206A_202B_206F_206A_202E_202E_200B_200D_206B_202C_200E_200D_202E_206F_202C_202B_206D_202A_202B_206D_200F_200C_206B_206D_200B_202D_202E_200F_206C_206C_206B_202E_206D_202D_206E_202E((IEnumerator)enumerator))
				{
					num = 1982742348;
					num2 = num;
				}
				else
				{
					num = 400564952;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x33AD012)) % 6)
					{
					case 0u:
						num = 1982742348;
						continue;
					default:
						goto end_IL_0012;
					case 2u:
					{
						current = enumerator.Current;
						int num4;
						if (_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current.Name, roleName))
						{
							num = 1515238845;
							num4 = num;
						}
						else
						{
							num = 1679104749;
							num4 = num;
						}
						continue;
					}
					case 1u:
						break;
					case 3u:
						key = current.Key;
						num = ((int)num3 * -282804350) ^ 0x76CB3637;
						continue;
					case 4u:
						goto end_IL_0012;
					case 5u:
						return key;
					}
					goto IL_0075;
					continue;
					end_IL_0012:
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
					IL_00ac:
					int num5 = 921755487;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num5 ^ 0x33AD012)) % 3)
						{
						case 0u:
							break;
						default:
							goto end_IL_00b1;
						case 2u:
							goto IL_00ce;
						case 1u:
							goto end_IL_00b1;
						}
						goto IL_00ac;
						IL_00ce:
						_206D_200E_206E_206E_206A_206B_206B_202E_206F_200F_202D_202D_200B_202E_206F_200B_202A_206B_200D_206B_206B_200C_200B_206B_200F_202C_202C_206F_206A_206F_206E_202B_206B_206C_202C_206C_200F_200B_200F_202E_202E((IDisposable)enumerator);
						num5 = (int)((num3 * 312778970) ^ 0x3C7AAD23);
						continue;
						end_IL_00b1:
						break;
					}
					break;
				}
			}
		}
		return null;
	}

	public string GetRoleNameFromRoleKey(string roleKey)
	{
		IEnumerator<Role> enumerator = ResourceManager.GetAll<Role>().GetEnumerator();
		try
		{
			string name = default(string);
			Role current = default(Role);
			while (true)
			{
				IL_003f:
				int num;
				int num2;
				if (_200C_202A_206C_202A_200E_206A_202B_206F_206A_202E_202E_200B_200D_206B_202C_200E_200D_202E_206F_202C_202B_206D_202A_202B_206D_200F_200C_206B_206D_200B_202D_202E_200F_206C_206C_206B_202E_206D_202D_206E_202E((IEnumerator)enumerator))
				{
					num = -1388873743;
					num2 = num;
				}
				else
				{
					num = -89054946;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -1151078443)) % 7)
					{
					case 5u:
						num = -1388873743;
						continue;
					default:
						goto end_IL_0012;
					case 2u:
						break;
					case 3u:
						name = current.Name;
						num = (int)((num3 * 244777449) ^ 0x7C3A61F8);
						continue;
					case 4u:
					{
						int num4;
						int num5;
						if (_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current.Key, roleKey))
						{
							num4 = -192415204;
							num5 = num4;
						}
						else
						{
							num4 = -1041498628;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -262294069);
						continue;
					}
					case 1u:
						current = enumerator.Current;
						num = -796633869;
						continue;
					case 0u:
						goto end_IL_0012;
					case 6u:
						return name;
					}
					goto IL_003f;
					continue;
					end_IL_0012:
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
					IL_00c2:
					int num6 = -1621014050;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num6 ^ -1151078443)) % 3)
						{
						case 0u:
							break;
						default:
							goto end_IL_00c7;
						case 2u:
							goto IL_00e4;
						case 1u:
							goto end_IL_00c7;
						}
						goto IL_00c2;
						IL_00e4:
						_206D_200E_206E_206E_206A_206B_206B_202E_206F_200F_202D_202D_200B_202E_206F_200B_202A_206B_200D_206B_206B_200C_200B_206B_200F_202C_202C_206F_206A_206F_206E_202B_206B_206C_202C_206C_200F_200B_200F_202E_202E((IDisposable)enumerator);
						num6 = ((int)num3 * -977601885) ^ 0x7F0BE7DE;
						continue;
						end_IL_00c7:
						break;
					}
					break;
				}
			}
		}
		return null;
	}

	public string GetTeamRoleKeyFromTeamRoleName(string roleName)
	{
		using (List<Role>.Enumerator enumerator = Team.GetEnumerator())
		{
			Role current = default(Role);
			string key = default(string);
			while (true)
			{
				IL_004f:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 1163514318;
					num2 = num;
				}
				else
				{
					num = 294440052;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x5A95EB9E)) % 7)
					{
					case 0u:
						num = 1163514318;
						continue;
					default:
						goto end_IL_0013;
					case 2u:
						current = enumerator.Current;
						num = 1841366914;
						continue;
					case 6u:
						break;
					case 1u:
						key = current.Key;
						num = ((int)num3 * -2014759338) ^ -1261700398;
						continue;
					case 5u:
					{
						int num4;
						int num5;
						if (!_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current.Name, roleName))
						{
							num4 = 1346306565;
							num5 = num4;
						}
						else
						{
							num4 = 1300030465;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -664828510);
						continue;
					}
					case 4u:
						goto end_IL_0013;
					case 3u:
						return key;
					}
					goto IL_004f;
					continue;
					end_IL_0013:
					break;
				}
				break;
			}
		}
		return null;
	}

	public string GetTeamRoleNameFromTeamRoleKey(string roleKey)
	{
		using (List<Role>.Enumerator enumerator = Team.GetEnumerator())
		{
			Role current = default(Role);
			while (true)
			{
				IL_003c:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -1562008678;
					num2 = num;
				}
				else
				{
					num = -316282141;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -162115754)) % 6)
					{
					case 2u:
						num = -316282141;
						continue;
					default:
						goto end_IL_0013;
					case 3u:
						break;
					case 0u:
					{
						int num4;
						int num5;
						if (_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current.Key, roleKey))
						{
							num4 = -1289203945;
							num5 = num4;
						}
						else
						{
							num4 = -798586291;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -1587170116);
						continue;
					}
					case 1u:
						return current.Name;
					case 5u:
						current = enumerator.Current;
						num = -1980570102;
						continue;
					case 4u:
						goto end_IL_0013;
					}
					goto IL_003c;
					continue;
					end_IL_0013:
					break;
				}
				break;
			}
		}
		return null;
	}

	public void addHaoganLua(string name)
	{
		string[] array = _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(name, new char[1] { '#' });
		while (true)
		{
			int num = -1192195023;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1892934030)) % 21)
				{
				case 14u:
					break;
				default:
					return;
				case 8u:
				{
					int num7;
					int num8;
					if (_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(array[0]))
					{
						num7 = 1926571527;
						num8 = num7;
					}
					else
					{
						num7 = 485942348;
						num8 = num7;
					}
					num = num7 ^ ((int)num2 * -208554542);
					continue;
				}
				case 16u:
					array[0] = global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(495021672u);
					num = (int)(num2 * 492334802) ^ -188894961;
					continue;
				case 1u:
					addHaogan(int.Parse(array[0]), ResourceStrings.ResStrings[9]);
					num = -1748879728;
					continue;
				case 20u:
					num = ((int)num2 * -953877868) ^ -133623813;
					continue;
				case 2u:
					return;
				case 6u:
				{
					int num13;
					if (int.Parse(array[1]) < -100)
					{
						num = -1024746191;
						num13 = num;
					}
					else
					{
						num = -793703108;
						num13 = num;
					}
					continue;
				}
				case 17u:
					num = ((int)num2 * -2030872794) ^ -928700643;
					continue;
				case 12u:
				{
					int num10;
					if (int.Parse(array[0]) <= 100)
					{
						num = -210047409;
						num10 = num;
					}
					else
					{
						num = -1019690798;
						num10 = num;
					}
					continue;
				}
				case 15u:
					array[0] = global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3614298171u);
					num = (int)((num2 * 1868209221) ^ 0x15C250F8);
					continue;
				case 7u:
					array[1] = global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2281377762u);
					num = (int)((num2 * 1927527728) ^ 0x6326D4B3);
					continue;
				case 13u:
				{
					int num4;
					if (array.Length >= 2)
					{
						num = -538459610;
						num4 = num;
					}
					else
					{
						num = -2004769675;
						num4 = num;
					}
					continue;
				}
				case 18u:
					return;
				case 0u:
					addHaogan(int.Parse(array[1]), array[0]);
					num = -2004769675;
					continue;
				case 11u:
				{
					int num11;
					int num12;
					if (int.Parse(array[0]) >= -100)
					{
						num11 = -1339073530;
						num12 = num11;
					}
					else
					{
						num11 = -1869412459;
						num12 = num11;
					}
					num = num11 ^ (int)(num2 * 1608835172);
					continue;
				}
				case 9u:
					array[1] = global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1055330990u);
					num = ((int)num2 * -1954820261) ^ -118289338;
					continue;
				case 4u:
					array[0] = ResourceStrings.ResStrings[9];
					num = ((int)num2 * -218993975) ^ -1665822239;
					continue;
				case 10u:
				{
					int num9;
					if (int.Parse(array[1]) > 100)
					{
						num = -1278404155;
						num9 = num;
					}
					else
					{
						num = -2129765917;
						num9 = num;
					}
					continue;
				}
				case 5u:
				{
					int num5;
					int num6;
					if (array.Length == 0)
					{
						num5 = -1358550058;
						num6 = num5;
					}
					else
					{
						num5 = -586527356;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -2104252253);
					continue;
				}
				case 3u:
				{
					int num3;
					if (array.Length == 1)
					{
						num = -384100038;
						num3 = num;
					}
					else
					{
						num = -1906868488;
						num3 = num;
					}
					continue;
				}
				case 19u:
					return;
				}
				break;
			}
		}
	}

	internal int GetAsc2(string character)
	{
		int num = 0;
		int num2 = 0;
		int num7 = default(int);
		string text = default(string);
		while (true)
		{
			int num3 = 852909409;
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)(num3 ^ 0x201E09DA)) % 8)
				{
				case 4u:
					break;
				case 0u:
					num7 = _206C_206E_200D_202B_202E_206D_202A_206A_202C_202A_200E_206D_202C_200F_206D_202E_200C_202B_200C_206A_200F_202C_200E_200F_200E_200D_206B_206D_200F_202D_206B_202E_200F_202B_206A_202A_206A_202E_200F_202C_202E((Encoding)_206F_200D_206B_202D_206B_202E_200E_206A_202C_200D_206D_206F_202A_200E_200C_200B_200B_202A_200B_202C_202D_200D_206C_202B_202A_206F_206A_202E_200E_206A_200D_200E_202B_200D_200B_200B_202C_206F_202B_200F_202E(), text)[0];
					num3 = 958257516;
					continue;
				case 1u:
				{
					int num6;
					if (num2 < _200B_202C_200E_202C_202C_200E_206C_200F_206C_200B_206C_206F_202C_202C_206A_206D_206F_206C_200E_200F_200B_202A_206D_206B_202E_200F_206C_206C_200D_200B_206D_206F_206F_200D_206A_202E_200D_206C_200E_206B_202E(character))
					{
						num3 = 1969645272;
						num6 = num3;
					}
					else
					{
						num3 = 935995631;
						num6 = num3;
					}
					continue;
				}
				case 7u:
					throw _200F_200B_206C_200F_200D_202A_200E_200D_206D_202D_200F_202C_200C_200D_206D_202C_200C_200D_200B_202D_200D_200B_206D_200D_206A_200D_200F_206F_202A_202E_206E_206E_202C_202D_206E_202D_206E_206F_200E_202E_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(365464253u));
				case 3u:
					num3 = (int)(num4 * 74701993) ^ -1159985328;
					continue;
				case 6u:
					num += num7;
					num2++;
					num3 = ((int)num4 * -1364313691) ^ -1183862931;
					continue;
				case 2u:
				{
					text = _202E_200D_206D_206C_202C_200C_206B_206A_206A_202C_200C_200F_200D_202E_200C_202E_202B_206B_200E_200C_206D_200F_200E_206C_200F_200E_200D_200C_202E_206F_206C_200F_200B_202E_200C_206F_206D_202D_202B_202E_202E(character, num2, 1);
					int num5;
					if (_200B_202C_200E_202C_202C_200E_206C_200F_206C_200B_206C_206F_202C_202C_206A_206D_206F_206C_200E_200F_200B_202A_206D_206B_202E_200F_206C_206C_200D_200B_206D_206F_206F_200D_206A_202E_200D_206C_200E_206B_202E(text) == 1)
					{
						num3 = 1189538994;
						num5 = num3;
					}
					else
					{
						num3 = 1575844429;
						num5 = num3;
					}
					continue;
				}
				default:
					return num;
				}
				break;
			}
		}
	}

	public bool addTempMemberFromTeam(string roleKey)
	{
		Role role = null;
		using (List<Role>.Enumerator enumerator = Team.GetEnumerator())
		{
			Role current = default(Role);
			while (true)
			{
				IL_0065:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -1739572488;
					num2 = num;
				}
				else
				{
					num = -865736968;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -774241847)) % 6)
					{
					case 0u:
						num = -1739572488;
						continue;
					default:
						goto end_IL_0015;
					case 1u:
					{
						current = enumerator.Current;
						int num4;
						if (_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current.Key, roleKey))
						{
							num = -1914669837;
							num4 = num;
						}
						else
						{
							num = -997099409;
							num4 = num;
						}
						continue;
					}
					case 2u:
						break;
					case 4u:
						role = current;
						num = ((int)num3 * -2077987077) ^ 0x5C6558CE;
						continue;
					case 3u:
						goto end_IL_0015;
					case 5u:
						goto end_IL_0015;
					}
					goto IL_0065;
					continue;
					end_IL_0015:
					break;
				}
				break;
			}
		}
		if (role != null)
		{
			while (true)
			{
				int num5 = -995568811;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num5 ^ -774241847)) % 5)
					{
					case 0u:
						break;
					case 1u:
					{
						RemoveTeamMemberPanel(role);
						Team.Remove(role);
						int num6;
						int num7;
						if (!InTemp(role.Key))
						{
							num6 = 738952133;
							num7 = num6;
						}
						else
						{
							num6 = 1675526150;
							num7 = num6;
						}
						num5 = num6 ^ (int)(num3 * 497852703);
						continue;
					}
					case 2u:
						return true;
					case 3u:
						Temp.Add(role);
						num5 = ((int)num3 * -1395072567) ^ -910610230;
						continue;
					default:
						goto end_IL_00ba;
					}
					break;
				}
				continue;
				end_IL_00ba:
				break;
			}
		}
		return false;
	}

	public bool addTempMemberFromFollow(string roleKey)
	{
		Role role = null;
		using (List<Role>.Enumerator enumerator = Follow.GetEnumerator())
		{
			Role current = default(Role);
			while (true)
			{
				IL_003e:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -1342622011;
					num2 = num;
				}
				else
				{
					num = -1414242801;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -6919901)) % 6)
					{
					case 2u:
						num = -1414242801;
						continue;
					default:
						goto end_IL_0015;
					case 1u:
						break;
					case 5u:
					{
						int num4;
						int num5;
						if (!_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current.Key, roleKey))
						{
							num4 = -869089408;
							num5 = num4;
						}
						else
						{
							num4 = -1630798794;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -1235876710);
						continue;
					}
					case 3u:
						role = current;
						goto end_IL_0015;
					case 4u:
						current = enumerator.Current;
						num = -409609508;
						continue;
					case 0u:
						goto end_IL_0015;
					}
					goto IL_003e;
					continue;
					end_IL_0015:
					break;
				}
				break;
			}
		}
		if (role != null)
		{
			while (true)
			{
				int num6 = -819299879;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num6 ^ -6919901)) % 6)
					{
					case 0u:
						break;
					case 4u:
						Follow.Remove(role);
						num6 = ((int)num3 * -2088361857) ^ 0x30AE93B4;
						continue;
					case 3u:
						Temp.Add(role);
						num6 = (int)((num3 * 795448624) ^ 0x1A7A47E0);
						continue;
					case 1u:
						return true;
					case 5u:
					{
						int num7;
						int num8;
						if (!InTemp(role.Key))
						{
							num7 = 139507924;
							num8 = num7;
						}
						else
						{
							num7 = 440504856;
							num8 = num7;
						}
						num6 = num7 ^ (int)(num3 * 1126511272);
						continue;
					}
					default:
						goto end_IL_00ba;
					}
					break;
				}
				continue;
				end_IL_00ba:
				break;
			}
		}
		return false;
	}

	public bool addTeamMemberFromTemp(string roleKey)
	{
		Role role = null;
		using (List<Role>.Enumerator enumerator = Temp.GetEnumerator())
		{
			Role current = default(Role);
			while (true)
			{
				IL_0087:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -2061745996;
					num2 = num;
				}
				else
				{
					num = -1665505723;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -1574833322)) % 6)
					{
					case 2u:
						num = -1665505723;
						continue;
					default:
						goto end_IL_0015;
					case 1u:
						current = enumerator.Current;
						num = -262091333;
						continue;
					case 5u:
					{
						int num4;
						int num5;
						if (_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current.Key, roleKey))
						{
							num4 = -712390620;
							num5 = num4;
						}
						else
						{
							num4 = -1618910411;
							num5 = num4;
						}
						num = num4 ^ (int)(num3 * 560993535);
						continue;
					}
					case 3u:
						role = current;
						goto end_IL_0015;
					case 0u:
						break;
					case 4u:
						goto end_IL_0015;
					}
					goto IL_0087;
					continue;
					end_IL_0015:
					break;
				}
				break;
			}
		}
		if (role != null)
		{
			while (true)
			{
				int num6 = -1840695771;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num6 ^ -1574833322)) % 8)
					{
					case 7u:
						break;
					case 3u:
						Temp.Remove(role);
						num6 = ((int)num3 * -1498653877) ^ 0x7554F377;
						continue;
					case 5u:
					{
						int num9;
						int num10;
						if (role.Skills.Count > 0)
						{
							num9 = -1970374779;
							num10 = num9;
						}
						else
						{
							num9 = -259974670;
							num10 = num9;
						}
						num6 = num9 ^ ((int)num3 * -927599142);
						continue;
					}
					case 1u:
						Team.Add(role);
						num6 = (int)(num3 * 110373829) ^ -1645772663;
						continue;
					case 4u:
					{
						int num11;
						int num12;
						if (role.InternalSkills.Count > 0)
						{
							num11 = 329729875;
							num12 = num11;
						}
						else
						{
							num11 = 755204288;
							num12 = num11;
						}
						num6 = num11 ^ (int)(num3 * 809909644);
						continue;
					}
					case 2u:
						AddTeamMemberPanel(role);
						return true;
					case 0u:
					{
						RemoveManualTemp(role.Key);
						int num7;
						int num8;
						if (InTeam(role.Key))
						{
							num7 = 1462487568;
							num8 = num7;
						}
						else
						{
							num7 = 925253642;
							num8 = num7;
						}
						num6 = num7 ^ (int)(num3 * 701691880);
						continue;
					}
					default:
						goto end_IL_00ba;
					}
					break;
				}
				continue;
				end_IL_00ba:
				break;
			}
		}
		return false;
	}

	public bool addFollowMemberFromTemp(string roleKey)
	{
		Role role = null;
		using (List<Role>.Enumerator enumerator = Temp.GetEnumerator())
		{
			Role current = default(Role);
			while (true)
			{
				IL_0087:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 644887477;
					num2 = num;
				}
				else
				{
					num = 1770175969;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x5049F6D2)) % 6)
					{
					case 4u:
						num = 644887477;
						continue;
					default:
						goto end_IL_0015;
					case 1u:
					{
						current = enumerator.Current;
						int num4;
						if (!_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current.Key, roleKey))
						{
							num = 1299225250;
							num4 = num;
						}
						else
						{
							num = 525779897;
							num4 = num;
						}
						continue;
					}
					case 2u:
						goto end_IL_0015;
					case 3u:
						role = current;
						num = ((int)num3 * -2064505175) ^ -1593424111;
						continue;
					case 0u:
						break;
					case 5u:
						goto end_IL_0015;
					}
					goto IL_0087;
					continue;
					end_IL_0015:
					break;
				}
				break;
			}
		}
		if (role != null)
		{
			while (true)
			{
				int num5 = 338503450;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num5 ^ 0x5049F6D2)) % 6)
					{
					case 3u:
						break;
					case 4u:
						Temp.Remove(role);
						num5 = ((int)num3 * -601952200) ^ -1066412540;
						continue;
					case 5u:
						Follow.Add(role);
						num5 = (int)((num3 * 355535475) ^ 0x7AC39900);
						continue;
					case 1u:
						return true;
					case 2u:
					{
						RemoveManualTemp(role.Key);
						int num6;
						int num7;
						if (InTeam(role.Key))
						{
							num6 = 67690763;
							num7 = num6;
						}
						else
						{
							num6 = 1686532899;
							num7 = num6;
						}
						num5 = num6 ^ (int)(num3 * 1858084471);
						continue;
					}
					default:
						goto end_IL_00ba;
					}
					break;
				}
				continue;
				end_IL_00ba:
				break;
			}
		}
		return false;
	}

	public bool removeTempMember(string roleKey)
	{
		Role role = null;
		using (List<Role>.Enumerator enumerator = Temp.GetEnumerator())
		{
			Role current = default(Role);
			while (true)
			{
				IL_004e:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -2102797798;
					num2 = num;
				}
				else
				{
					num = -668864180;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -1203711119)) % 6)
					{
					case 0u:
						num = -2102797798;
						continue;
					default:
						goto end_IL_0015;
					case 5u:
						current = enumerator.Current;
						num = -1630800474;
						continue;
					case 4u:
						break;
					case 1u:
					{
						int num4;
						int num5;
						if (!_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current.Key, roleKey))
						{
							num4 = 1080180908;
							num5 = num4;
						}
						else
						{
							num4 = 1184954486;
							num5 = num4;
						}
						num = num4 ^ (int)(num3 * 295828665);
						continue;
					}
					case 2u:
						role = current;
						goto end_IL_0015;
					case 3u:
						goto end_IL_0015;
					}
					goto IL_004e;
					continue;
					end_IL_0015:
					break;
				}
				break;
			}
		}
		if (role != null)
		{
			using (List<ItemInstance>.Enumerator enumerator2 = role.Equipment.GetEnumerator())
			{
				while (true)
				{
					IL_010b:
					int num6;
					int num7;
					if (enumerator2.MoveNext())
					{
						num6 = -1033698982;
						num7 = num6;
					}
					else
					{
						num6 = -2000744068;
						num7 = num6;
					}
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num6 ^ -1203711119)) % 4)
						{
						case 0u:
							num6 = -1033698982;
							continue;
						default:
							goto end_IL_00d0;
						case 3u:
						{
							ItemInstance current2 = enumerator2.Current;
							addItem(current2);
							num6 = -605791621;
							continue;
						}
						case 2u:
							break;
						case 1u:
							goto end_IL_00d0;
						}
						goto IL_010b;
						continue;
						end_IL_00d0:
						break;
					}
					break;
				}
			}
			Temp.Remove(role);
			RemoveManualTemp(role.Key);
			return true;
		}
		return false;
	}

	public int addTempMemberFromTeamV2(string roleKey)
	{
		List<Role> list = new List<Role>();
		uint num3;
		using (List<Role>.Enumerator enumerator = Team.GetEnumerator())
		{
			Role current = default(Role);
			while (true)
			{
				IL_00b2:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -85960499;
					num2 = num;
				}
				else
				{
					num = -1586484874;
					num2 = num;
				}
				while (true)
				{
					switch ((num3 = (uint)(num ^ -1199923857)) % 7)
					{
					case 0u:
						num = -1586484874;
						continue;
					default:
						goto end_IL_001c;
					case 2u:
					{
						int num6;
						int num7;
						if (_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current.Name, roleKey))
						{
							num6 = 2123501566;
							num7 = num6;
						}
						else
						{
							num6 = 349004625;
							num7 = num6;
						}
						num = num6 ^ (int)(num3 * 1713525189);
						continue;
					}
					case 4u:
					{
						int num4;
						int num5;
						if (!_200D_202D_202C_200D_206D_200E_206B_202E_202D_200C_202C_202E_206E_202E_200D_206D_200E_206A_206D_206D_200C_200C_202A_202B_202E_200E_206E_200E_202D_206B_206D_200E_206E_202A_202D_206F_200F_200F_206F_202D_202E(current.Key, roleKey))
						{
							num4 = 1483091179;
							num5 = num4;
						}
						else
						{
							num4 = 1697298910;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -258244065);
						continue;
					}
					case 6u:
						current = enumerator.Current;
						num = -1654647326;
						continue;
					case 5u:
						break;
					case 3u:
						list.Add(current);
						num = -610732446;
						continue;
					case 1u:
						goto end_IL_001c;
					}
					goto IL_00b2;
					continue;
					end_IL_001c:
					break;
				}
				break;
			}
		}
		if (list.Count <= 0)
		{
			goto IL_00f9;
		}
		goto IL_0132;
		IL_0132:
		int num8 = 0;
		int num9 = -1975516606;
		goto IL_00fe;
		IL_00f9:
		num9 = -510457951;
		goto IL_00fe;
		IL_00fe:
		switch ((num3 = (uint)(num9 ^ -1199923857)) % 4)
		{
		case 0u:
			break;
		case 2u:
			return 0;
		case 3u:
			goto IL_0132;
		default:
		{
			using (List<Role>.Enumerator enumerator = list.GetEnumerator())
			{
				Role current2 = default(Role);
				while (true)
				{
					IL_0232:
					int num10;
					int num11;
					if (!enumerator.MoveNext())
					{
						num10 = -1372227514;
						num11 = num10;
					}
					else
					{
						num10 = -29943930;
						num11 = num10;
					}
					while (true)
					{
						switch ((num3 = (uint)(num10 ^ -1199923857)) % 9)
						{
						case 7u:
							num10 = -29943930;
							continue;
						default:
							goto end_IL_014c;
						case 8u:
							current2 = enumerator.Current;
							num10 = -1404083562;
							continue;
						case 1u:
							Temp.Add(current2);
							num10 = ((int)num3 * -216698518) ^ -1675035574;
							continue;
						case 5u:
						{
							int num12;
							int num13;
							if (InTemp(current2.Key))
							{
								num12 = 774214752;
								num13 = num12;
							}
							else
							{
								num12 = 1490795099;
								num13 = num12;
							}
							num10 = num12 ^ (int)(num3 * 2090821755);
							continue;
						}
						case 4u:
							RemoveTeamMemberPanel(current2);
							num10 = ((int)num3 * -1327818633) ^ 0x18AB8461;
							continue;
						case 3u:
							Team.Remove(current2);
							num10 = (int)((num3 * 891631697) ^ 0x1713BC39);
							continue;
						case 0u:
							num8++;
							num10 = (int)(num3 * 700893265) ^ -526102206;
							continue;
						case 6u:
							break;
						case 2u:
							goto end_IL_014c;
						}
						goto IL_0232;
						continue;
						end_IL_014c:
						break;
					}
					break;
				}
			}
			return num8;
		}
		}
		goto IL_00f9;
	}

	public int addTempMemberFromFollowV2(string roleKey)
	{
		List<Role> list = new List<Role>();
		using (List<Role>.Enumerator enumerator = Follow.GetEnumerator())
		{
			Role current = default(Role);
			while (true)
			{
				IL_00c3:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -678558890;
					num2 = num;
				}
				else
				{
					num = -1221694766;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -1289331313)) % 7)
					{
					case 5u:
						num = -1221694766;
						continue;
					default:
						goto end_IL_001c;
					case 1u:
					{
						int num6;
						int num7;
						if (!_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current.Name, roleKey))
						{
							num6 = 385353297;
							num7 = num6;
						}
						else
						{
							num6 = 1229223333;
							num7 = num6;
						}
						num = num6 ^ (int)(num3 * 435055473);
						continue;
					}
					case 3u:
					{
						int num4;
						int num5;
						if (_200D_202D_202C_200D_206D_200E_206B_202E_202D_200C_202C_202E_206E_202E_200D_206D_200E_206A_206D_206D_200C_200C_202A_202B_202E_200E_206E_200E_202D_206B_206D_200E_206E_202A_202D_206F_200F_200F_206F_202D_202E(current.Key, roleKey))
						{
							num4 = -2047369463;
							num5 = num4;
						}
						else
						{
							num4 = -1683524893;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -510540676);
						continue;
					}
					case 4u:
						current = enumerator.Current;
						num = -2125038025;
						continue;
					case 2u:
						list.Add(current);
						num = -425082403;
						continue;
					case 6u:
						break;
					case 0u:
						goto end_IL_001c;
					}
					goto IL_00c3;
					continue;
					end_IL_001c:
					break;
				}
				break;
			}
		}
		if (list.Count <= 0)
		{
			while (true)
			{
				uint num3;
				switch ((num3 = 262045996u) % 3)
				{
				case 0u:
					continue;
				case 1u:
					return 0;
				}
				break;
			}
		}
		int num8 = 0;
		using (List<Role>.Enumerator enumerator = list.GetEnumerator())
		{
			Role current2 = default(Role);
			while (true)
			{
				IL_01d9:
				int num9;
				int num10;
				if (!enumerator.MoveNext())
				{
					num9 = -1806087268;
					num10 = num9;
				}
				else
				{
					num9 = -1768133649;
					num10 = num9;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num9 ^ -1289331313)) % 6)
					{
					case 5u:
						num9 = -1768133649;
						continue;
					default:
						goto end_IL_0141;
					case 4u:
						current2 = enumerator.Current;
						Follow.Remove(current2);
						num9 = -509128779;
						continue;
					case 0u:
						Temp.Add(current2);
						num8++;
						num9 = (int)((num3 * 1835466520) ^ 0x161CD9AC);
						continue;
					case 2u:
					{
						int num11;
						int num12;
						if (InTemp(current2.Key))
						{
							num11 = 1768423276;
							num12 = num11;
						}
						else
						{
							num11 = 741024057;
							num12 = num11;
						}
						num9 = num11 ^ (int)(num3 * 153332424);
						continue;
					}
					case 1u:
						break;
					case 3u:
						goto end_IL_0141;
					}
					goto IL_01d9;
					continue;
					end_IL_0141:
					break;
				}
				break;
			}
		}
		return num8;
	}

	public int addTeamMemberFromTempV2(string roleKey)
	{
		List<Role> list = new List<Role>();
		using (List<Role>.Enumerator enumerator = Temp.GetEnumerator())
		{
			Role current = default(Role);
			while (true)
			{
				IL_00c0:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 2145737289;
					num2 = num;
				}
				else
				{
					num = 1955106868;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x4B6FA868)) % 7)
					{
					case 5u:
						num = 2145737289;
						continue;
					default:
						goto end_IL_001c;
					case 6u:
						current = enumerator.Current;
						num = 376117924;
						continue;
					case 2u:
					{
						int num6;
						int num7;
						if (_200D_202D_202C_200D_206D_200E_206B_202E_202D_200C_202C_202E_206E_202E_200D_206D_200E_206A_206D_206D_200C_200C_202A_202B_202E_200E_206E_200E_202D_206B_206D_200E_206E_202A_202D_206F_200F_200F_206F_202D_202E(current.Key, roleKey))
						{
							num6 = -389311074;
							num7 = num6;
						}
						else
						{
							num6 = -390117433;
							num7 = num6;
						}
						num = num6 ^ ((int)num3 * -1788450214);
						continue;
					}
					case 4u:
					{
						int num4;
						int num5;
						if (_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current.Name, roleKey))
						{
							num4 = 695845201;
							num5 = num4;
						}
						else
						{
							num4 = 476274823;
							num5 = num4;
						}
						num = num4 ^ (int)(num3 * 2136689569);
						continue;
					}
					case 3u:
						list.Add(current);
						num = 1126590448;
						continue;
					case 0u:
						break;
					case 1u:
						goto end_IL_001c;
					}
					goto IL_00c0;
					continue;
					end_IL_001c:
					break;
				}
				break;
			}
		}
		if (list.Count <= 0)
		{
			while (true)
			{
				uint num3;
				switch ((num3 = 919048289u) % 3)
				{
				case 0u:
					continue;
				case 2u:
					return 0;
				}
				break;
			}
		}
		int num8 = 0;
		using (List<Role>.Enumerator enumerator = list.GetEnumerator())
		{
			Role current2 = default(Role);
			while (true)
			{
				IL_0195:
				int num9;
				int num10;
				if (!enumerator.MoveNext())
				{
					num9 = 1581881664;
					num10 = num9;
				}
				else
				{
					num9 = 1228891468;
					num10 = num9;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num9 ^ 0x4B6FA868)) % 7)
					{
					case 0u:
						num9 = 1228891468;
						continue;
					default:
						goto end_IL_013b;
					case 1u:
						Team.Add(current2);
						AddTeamMemberPanel(current2);
						num8++;
						num9 = ((int)num3 * -837364106) ^ -334327955;
						continue;
					case 5u:
						break;
					case 2u:
						Temp.Remove(current2);
						num9 = (int)((num3 * 469797501) ^ 0x14A30EB7);
						continue;
					case 3u:
						current2 = enumerator.Current;
						num9 = 146538206;
						continue;
					case 6u:
					{
						RemoveManualTemp(current2.Key);
						int num11;
						int num12;
						if (InTeam(current2.Key))
						{
							num11 = 1968106765;
							num12 = num11;
						}
						else
						{
							num11 = 185949355;
							num12 = num11;
						}
						num9 = num11 ^ ((int)num3 * -209122946);
						continue;
					}
					case 4u:
						goto end_IL_013b;
					}
					goto IL_0195;
					continue;
					end_IL_013b:
					break;
				}
				break;
			}
		}
		return num8;
	}

	public int addFollowMemberFromTempV2(string roleKey)
	{
		List<Role> list = new List<Role>();
		using (List<Role>.Enumerator enumerator = Temp.GetEnumerator())
		{
			Role current = default(Role);
			while (true)
			{
				IL_00bd:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 1045336050;
					num2 = num;
				}
				else
				{
					num = 1386174509;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x475CCEF2)) % 7)
					{
					case 5u:
						num = 1045336050;
						continue;
					default:
						goto end_IL_001c;
					case 1u:
						list.Add(current);
						num = 1086029866;
						continue;
					case 0u:
					{
						int num6;
						int num7;
						if (_200D_202D_202C_200D_206D_200E_206B_202E_202D_200C_202C_202E_206E_202E_200D_206D_200E_206A_206D_206D_200C_200C_202A_202B_202E_200E_206E_200E_202D_206B_206D_200E_206E_202A_202D_206F_200F_200F_206F_202D_202E(current.Key, roleKey))
						{
							num6 = 984798003;
							num7 = num6;
						}
						else
						{
							num6 = 630933256;
							num7 = num6;
						}
						num = num6 ^ (int)(num3 * 1575345986);
						continue;
					}
					case 4u:
						current = enumerator.Current;
						num = 631866303;
						continue;
					case 6u:
					{
						int num4;
						int num5;
						if (!_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current.Name, roleKey))
						{
							num4 = -584178582;
							num5 = num4;
						}
						else
						{
							num4 = -145590359;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -995737582);
						continue;
					}
					case 3u:
						break;
					case 2u:
						goto end_IL_001c;
					}
					goto IL_00bd;
					continue;
					end_IL_001c:
					break;
				}
				break;
			}
		}
		if (list.Count <= 0)
		{
			while (true)
			{
				uint num3;
				switch ((num3 = 603038134u) % 3)
				{
				case 2u:
					continue;
				case 1u:
					return 0;
				}
				break;
			}
		}
		int num8 = 0;
		using (List<Role>.Enumerator enumerator = list.GetEnumerator())
		{
			Role current2 = default(Role);
			while (true)
			{
				IL_019e:
				int num9;
				int num10;
				if (enumerator.MoveNext())
				{
					num9 = 625955147;
					num10 = num9;
				}
				else
				{
					num9 = 1231697108;
					num10 = num9;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num9 ^ 0x475CCEF2)) % 8)
					{
					case 0u:
						num9 = 625955147;
						continue;
					default:
						goto end_IL_0138;
					case 1u:
						current2 = enumerator.Current;
						num9 = 1221525409;
						continue;
					case 2u:
						Follow.Add(current2);
						num8++;
						num9 = (int)((num3 * 1730702030) ^ 0x57EC653);
						continue;
					case 5u:
						break;
					case 3u:
						Temp.Remove(current2);
						num9 = (int)((num3 * 1496089951) ^ 0x379D557B);
						continue;
					case 7u:
					{
						int num11;
						int num12;
						if (InTeam(current2.Key))
						{
							num11 = 1839924623;
							num12 = num11;
						}
						else
						{
							num11 = 1242279480;
							num12 = num11;
						}
						num9 = num11 ^ ((int)num3 * -845413488);
						continue;
					}
					case 4u:
						RemoveManualTemp(current2.Key);
						num9 = ((int)num3 * -994199921) ^ 0x76A25111;
						continue;
					case 6u:
						goto end_IL_0138;
					}
					goto IL_019e;
					continue;
					end_IL_0138:
					break;
				}
				break;
			}
		}
		return num8;
	}

	public int removeTempMemberV2(string roleKey)
	{
		List<Role> list = new List<Role>();
		uint num3;
		using (List<Role>.Enumerator enumerator = Temp.GetEnumerator())
		{
			Role current = default(Role);
			while (true)
			{
				IL_0072:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -898945720;
					num2 = num;
				}
				else
				{
					num = -1612076401;
					num2 = num;
				}
				while (true)
				{
					switch ((num3 = (uint)(num ^ -245300551)) % 7)
					{
					case 6u:
						num = -1612076401;
						continue;
					default:
						goto end_IL_0019;
					case 1u:
					{
						int num6;
						int num7;
						if (!_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current.Name, roleKey))
						{
							num6 = 1517347168;
							num7 = num6;
						}
						else
						{
							num6 = 1630676607;
							num7 = num6;
						}
						num = num6 ^ ((int)num3 * -1806183332);
						continue;
					}
					case 3u:
						break;
					case 0u:
						list.Add(current);
						num = -1596856104;
						continue;
					case 2u:
						current = enumerator.Current;
						num = -1420056497;
						continue;
					case 5u:
					{
						int num4;
						int num5;
						if (_200D_202D_202C_200D_206D_200E_206B_202E_202D_200C_202C_202E_206E_202E_200D_206D_200E_206A_206D_206D_200C_200C_202A_202B_202E_200E_206E_200E_202D_206B_206D_200E_206E_202A_202D_206F_200F_200F_206F_202D_202E(current.Key, roleKey))
						{
							num4 = 1384105269;
							num5 = num4;
						}
						else
						{
							num4 = 562035081;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -52765541);
						continue;
					}
					case 4u:
						goto end_IL_0019;
					}
					goto IL_0072;
					continue;
					end_IL_0019:
					break;
				}
				break;
			}
		}
		if (list.Count <= 0)
		{
			goto IL_00f3;
		}
		goto IL_012c;
		IL_012c:
		int num8 = 0;
		int num9 = -305663279;
		goto IL_00f8;
		IL_00f3:
		num9 = -601504696;
		goto IL_00f8;
		IL_00f8:
		switch ((num3 = (uint)(num9 ^ -245300551)) % 4)
		{
		case 2u:
			break;
		case 1u:
			return 0;
		case 3u:
			goto IL_012c;
		default:
		{
			using (List<Role>.Enumerator enumerator = list.GetEnumerator())
			{
				Role current2 = default(Role);
				while (true)
				{
					IL_01fd:
					if (enumerator.MoveNext())
					{
						current2 = enumerator.Current;
						using (List<ItemInstance>.Enumerator enumerator2 = current2.Equipment.GetEnumerator())
						{
							while (true)
							{
								IL_019a:
								int num10;
								int num11;
								if (!enumerator2.MoveNext())
								{
									num10 = -1249878100;
									num11 = num10;
								}
								else
								{
									num10 = -706236257;
									num11 = num10;
								}
								while (true)
								{
									switch ((num3 = (uint)(num10 ^ -245300551)) % 4)
									{
									case 0u:
										num10 = -706236257;
										continue;
									default:
										goto end_IL_015f;
									case 2u:
									{
										ItemInstance current3 = enumerator2.Current;
										addItem(current3);
										num10 = -37984982;
										continue;
									}
									case 3u:
										break;
									case 1u:
										goto end_IL_015f;
									}
									goto IL_019a;
									continue;
									end_IL_015f:
									break;
								}
								break;
							}
						}
						Temp.Remove(current2);
						goto IL_01d2;
					}
					int num12 = -1453949880;
					goto IL_01d7;
					IL_01d7:
					while (true)
					{
						switch ((num3 = (uint)(num12 ^ -245300551)) % 5)
						{
						case 4u:
							break;
						default:
							goto end_IL_01fd;
						case 2u:
							goto IL_01fd;
						case 3u:
							num8++;
							num12 = (int)((num3 * 385179040) ^ 0x10C32FF6);
							continue;
						case 1u:
							RemoveManualTemp(current2.Key);
							num12 = ((int)num3 * -1083065377) ^ -1827314424;
							continue;
						case 0u:
							goto end_IL_01fd;
						}
						break;
					}
					goto IL_01d2;
					IL_01d2:
					num12 = -174968163;
					goto IL_01d7;
					continue;
					end_IL_01fd:
					break;
				}
			}
			return num8;
		}
		}
		goto IL_00f3;
	}

	public string strReplace_JyGame(string inputText)
	{
		inputText = _200D_206B_206A_202D_200B_206C_206D_202C_206D_200F_206E_202B_200F_202D_200F_200D_202A_206C_202B_206C_200C_202C_202C_206D_200B_202E_200C_200E_200B_202B_206B_202C_206A_202E_202D_202E_200D_206D_206A_206A_202E(_200D_206B_206A_202D_200B_206C_206D_202C_206D_200F_206E_202B_200F_202D_200F_200D_202A_206C_202B_206C_200C_202C_202C_206D_200B_202E_200C_200E_200B_202B_206B_202C_206A_202E_202D_202E_200D_206D_206A_206A_202E(inputText, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(87052857u), maleName), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2224572418u), femaleName);
		int num56 = default(int);
		string text = default(string);
		int num62 = default(int);
		Role role = default(Role);
		TitleInstance titleInstance = default(TitleInstance);
		TitleInstance current = default(TitleInstance);
		int num27 = default(int);
		int num7 = default(int);
		int num10 = default(int);
		int num36 = default(int);
		int num19 = default(int);
		int num38 = default(int);
		int num24 = default(int);
		int num20 = default(int);
		int num41 = default(int);
		int num37 = default(int);
		int num15 = default(int);
		int num30 = default(int);
		int num16 = default(int);
		int num33 = default(int);
		int num21 = default(int);
		string text3 = default(string);
		string text2 = default(string);
		while (true)
		{
			int num = -1230073856;
			while (true)
			{
				uint num2;
				int num6;
				switch ((num2 = (uint)(num ^ -319506248)) % 12)
				{
				case 2u:
					break;
				case 8u:
					num56 = _200D_202B_206D_200C_202A_206B_202C_202B_202E_206F_206C_200B_200C_200F_202A_200D_206A_202E_200F_202A_202A_206D_200C_202C_200F_200E_206D_206B_202D_200F_200F_202C_200B_200E_202B_200B_202A_202C_200C_200C_202E(inputText, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2331883103u));
					num = (int)(num2 * 1885789904) ^ -796146197;
					continue;
				case 5u:
					text = _202E_200D_206D_206C_202C_200C_206B_206A_206A_202C_200C_200F_200D_202E_200C_202E_202B_206B_200E_200C_206D_200F_200E_206C_200F_200E_200D_200C_202E_206F_206C_200F_200B_202E_200C_206F_206D_202D_202B_202E_202E(inputText, num56 + 2, num62 - (num56 + 2));
					num = (int)(num2 * 1040082222) ^ -1724983783;
					continue;
				case 4u:
					if (num62 > 0)
					{
						num = ((int)num2 * -58573892) ^ -284134111;
						continue;
					}
					goto IL_08d8;
				case 10u:
					num62 = _200F_206C_200F_202A_206C_202B_200D_206C_200D_206A_200E_200E_200C_202A_200F_202A_206E_200E_206C_206B_202A_200D_206A_202A_202D_206D_206B_202A_202D_202C_202B_206D_202D_202B_202A_200E_206E_202D_202D_202E(inputText, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3747330030u), _200B_202A_202E_206F_206B_200E_202E_206A_206E_202B_202D_206B_202D_202C_206C_202A_200C_200C_206D_206F_202A_200D_200C_202E_202A_206C_206F_202C_200E_206C_202B_202D_202E_206F_200B_200D_202E_200C_202B_202C_202E(num56 + 2, _200B_202C_200E_202C_202C_200E_206C_200F_206C_200B_206C_206F_202C_202C_206A_206D_206F_206C_200E_200F_200B_202A_206D_206B_202E_200F_206C_206C_200D_200B_206D_206F_206F_200D_206A_202E_200D_206C_200E_206B_202E(inputText) - 1));
					num = -60973004;
					continue;
				case 9u:
					if (role != null)
					{
						num = -1091563416;
						continue;
					}
					goto IL_08d8;
				case 7u:
					role = GetRole(text);
					num = (int)((num2 * 651414138) ^ 0x63B56F81);
					continue;
				case 3u:
				{
					int num63;
					int num64;
					if (role == null)
					{
						num63 = -645747588;
						num64 = num63;
					}
					else
					{
						num63 = -2114780296;
						num64 = num63;
					}
					num = num63 ^ ((int)num2 * -1199572421);
					continue;
				}
				case 0u:
					titleInstance = role.EquippedTitle;
					if (titleInstance == null)
					{
						num = (int)(num2 * 357942134) ^ -1136339290;
						continue;
					}
					goto IL_023c;
				case 1u:
					role = ResourceManager.Get<Role>(text);
					num = ((int)num2 * -1358321944) ^ -380925675;
					continue;
				default:
				{
					using (List<TitleInstance>.Enumerator enumerator = role.Titles.GetEnumerator())
					{
						while (true)
						{
							IL_01fc:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -1268267064;
								num4 = num3;
							}
							else
							{
								num3 = -70539197;
								num4 = num3;
							}
							while (true)
							{
								switch ((num2 = (uint)(num3 ^ -319506248)) % 5)
								{
								case 0u:
									num3 = -70539197;
									continue;
								default:
									goto end_IL_01b3;
								case 3u:
								{
									current = enumerator.Current;
									int num5;
									if (!current.IsUsed)
									{
										num3 = -265631999;
										num5 = num3;
									}
									else
									{
										num3 = -610405139;
										num5 = num3;
									}
									continue;
								}
								case 2u:
									break;
								case 1u:
									titleInstance = current;
									goto end_IL_01b3;
								case 4u:
									goto end_IL_01b3;
								}
								goto IL_01fc;
								continue;
								end_IL_01b3:
								break;
							}
							break;
						}
					}
					goto IL_023c;
				}
				case 11u:
					goto IL_04ad;
					IL_024f:
					while (true)
					{
						string name;
						switch ((num2 = (uint)(num6 ^ -319506248)) % 71)
						{
						case 16u:
							break;
						case 53u:
						{
							int num28;
							int num29;
							if (num27 >= 0)
							{
								num28 = 846586612;
								num29 = num28;
							}
							else
							{
								num28 = 876341141;
								num29 = num28;
							}
							num6 = num28 ^ ((int)num2 * -121132959);
							continue;
						}
						case 64u:
							num7 = 0;
							num10 = 0;
							num6 = ((int)num2 * -1997181899) ^ 0x2A4C3753;
							continue;
						case 30u:
						{
							int num46;
							int num47;
							if (num36 < 0)
							{
								num46 = -1299202358;
								num47 = num46;
							}
							else
							{
								num46 = -1623957314;
								num47 = num46;
							}
							num6 = num46 ^ ((int)num2 * -937629167);
							continue;
						}
						case 69u:
						{
							int num13;
							int num14;
							if (_200D_202D_202C_200D_206D_200E_206B_202E_202D_200C_202C_202E_206E_202E_200D_206D_200E_206A_206D_206D_200C_200C_202A_202B_202E_200E_206E_200E_202D_206B_206D_200E_206E_202A_202D_206F_200F_200F_206F_202D_202E(inputText, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(554141718u)))
							{
								num13 = -1989656052;
								num14 = num13;
							}
							else
							{
								num13 = -429917574;
								num14 = num13;
							}
							num6 = num13 ^ ((int)num2 * -1322589520);
							continue;
						}
						case 59u:
							goto IL_040d;
						case 28u:
							inputText = _200F_200F_200B_206B_200B_202B_206A_206D_200D_206A_202B_202B_206F_202D_206E_200F_202D_206E_206E_202A_206E_206E_206E_202B_200E_200C_200B_202B_200E_200B_200D_206F_200E_200B_200B_202C_200E_206F_202D_206A_202E(inputText, num19, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3757989360u));
							num6 = (int)(num2 * 672912659) ^ -230418793;
							continue;
						case 31u:
							num56 = _200D_202B_206D_200C_202A_206B_202C_202B_202E_206F_206C_200B_200C_200F_202A_200D_206A_202E_200F_202A_202A_206D_200C_202C_200F_200E_206D_206B_202D_200F_200F_202C_200B_200E_202B_200B_202A_202C_200C_200C_202E(inputText, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2331883103u));
							num6 = (int)(num2 * 1736549147) ^ -1718795441;
							continue;
						case 27u:
							inputText = _206A_206A_200E_206D_206F_206A_206D_200B_200C_202D_200E_206B_202A_206A_206C_202D_200E_206D_206E_200B_206F_202A_200F_202A_206F_206D_200F_200F_206D_200D_200C_200D_200C_200D_206C_202B_202D_206D_206B_202D_202E(inputText, num38, 2);
							num6 = (int)((num2 * 1457808626) ^ 0x5F6F9112);
							continue;
						case 70u:
							inputText = _206A_206A_200E_206D_206F_206A_206D_200B_200C_202D_200E_206B_202A_206A_206C_202D_200E_206D_206E_200B_206F_202A_200F_202A_206F_206D_200F_200F_206D_200D_200C_200D_200C_200D_206C_202B_202D_206D_206B_202D_202E(inputText, num7, 5);
							num6 = ((int)num2 * -498842971) ^ 0x7DE8A45A;
							continue;
						case 11u:
							goto IL_04ad;
						case 5u:
							num38 = _200F_206C_200F_202A_206C_202B_200D_206C_200D_206A_200E_200E_200C_202A_200F_202A_206E_200E_206C_206B_202A_200D_206A_202A_202D_206D_206B_202A_202D_202C_202B_206D_202D_202B_202A_200E_206E_202D_202D_202E(inputText, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1839291621u), num10 + 6);
							num6 = ((int)num2 * -696787947) ^ -2131637639;
							continue;
						case 37u:
						{
							int num25;
							int num26;
							if (num24 < 0)
							{
								num25 = -47332183;
								num26 = num25;
							}
							else
							{
								num25 = -2118256073;
								num26 = num25;
							}
							num6 = num25 ^ (int)(num2 * 1981458093);
							continue;
						}
						case 51u:
							inputText = _206A_206A_200E_206D_206F_206A_206D_200B_200C_202D_200E_206B_202A_206A_206C_202D_200E_206D_206E_200B_206F_202A_200F_202A_206F_206D_200F_200F_206D_200D_200C_200D_200C_200D_206C_202B_202D_206D_206B_202D_202E(inputText, num20, 2);
							num6 = (int)(num2 * 1995744441) ^ -949210057;
							continue;
						case 48u:
							if (titleInstance == null)
							{
								num6 = ((int)num2 * -1642834667) ^ -1239147452;
								continue;
							}
							name = titleInstance.Name;
							goto IL_0938;
						case 55u:
						{
							int num52;
							int num53;
							if (num19 < 0)
							{
								num52 = 1789817559;
								num53 = num52;
							}
							else
							{
								num52 = 385862469;
								num53 = num52;
							}
							num6 = num52 ^ ((int)num2 * -579286387);
							continue;
						}
						case 18u:
							inputText = _200F_200F_200B_206B_200B_202B_206A_206D_200D_206A_202B_202B_206F_202D_206E_200F_202D_206E_206E_202A_206E_206E_206E_202B_200E_200C_200B_202B_200E_200B_200D_206F_200E_200B_200B_202C_200E_206F_202D_206A_202E(inputText, num27, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(321372317u));
							num41 = _200F_206C_200F_202A_206C_202B_200D_206C_200D_206A_200E_200E_200C_202A_200F_202A_206E_200E_206C_206B_202A_200D_206A_202A_202D_206D_206B_202A_202D_202C_202B_206D_202D_202B_202A_200E_206E_202D_202D_202E(inputText, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1890894166u), num27 + 3);
							num6 = (int)(num2 * 1279987519) ^ -182421561;
							continue;
						case 33u:
							num24 = 0;
							num19 = 0;
							num6 = (int)((num2 * 478079541) ^ 0x6DD79E3D);
							continue;
						case 6u:
							inputText = _200F_200F_200B_206B_200B_202B_206A_206D_200D_206A_202B_202B_206F_202D_206E_200F_202D_206E_206E_202A_206E_206E_206E_202B_200E_200C_200B_202B_200E_200B_200D_206F_200E_200B_200B_202C_200E_206F_202D_206A_202E(inputText, num38, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3593552216u));
							num6 = (int)((num2 * 1196225014) ^ 0x2CD80FF6);
							continue;
						case 47u:
							goto IL_05e0;
						case 7u:
							goto IL_060e;
						case 45u:
							num27 = _200D_202B_206D_200C_202A_206B_202C_202B_202E_206F_206C_200B_200C_200F_202A_200D_206A_202E_200F_202A_202A_206D_200C_202C_200F_200E_206D_206B_202D_200F_200F_202C_200B_200E_202B_200B_202A_202C_200C_200C_202E(inputText, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3442610244u));
							num6 = -2046180849;
							continue;
						case 57u:
						{
							int num42;
							int num43;
							if (num41 >= 0)
							{
								num42 = 1452004855;
								num43 = num42;
							}
							else
							{
								num42 = 458535248;
								num43 = num42;
							}
							num6 = num42 ^ ((int)num2 * -2115954777);
							continue;
						}
						case 54u:
							inputText = _200F_200F_200B_206B_200B_202B_206A_206D_200D_206A_202B_202B_206F_202D_206E_200F_202D_206E_206E_202A_206E_206E_206E_202B_200E_200C_200B_202B_200E_200B_200D_206F_200E_200B_200B_202C_200E_206F_202D_206A_202E(inputText, num41, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2915962691u));
							num6 = (int)(num2 * 318046161) ^ -289115545;
							continue;
						case 3u:
							inputText = _200F_200F_200B_206B_200B_202B_206A_206D_200D_206A_202B_202B_206F_202D_206E_200F_202D_206E_206E_202A_206E_206E_206E_202B_200E_200C_200B_202B_200E_200B_200D_206F_200E_200B_200B_202C_200E_206F_202D_206A_202E(inputText, num37, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1583738914u));
							num6 = ((int)num2 * -2074608782) ^ 0x1729DEA2;
							continue;
						case 49u:
							num27 = 0;
							num6 = (int)(num2 * 614448521) ^ -1016777930;
							continue;
						case 29u:
							goto IL_06db;
						case 23u:
							num36 = _200F_206C_200F_202A_206C_202B_200D_206C_200D_206A_200E_200E_200C_202A_200F_202A_206E_200E_206C_206B_202A_200D_206A_202A_202D_206D_206B_202A_202D_202C_202B_206D_202D_202B_202A_200E_206E_202D_202D_202E(inputText, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4242405752u), num15 + 1);
							num6 = -912181204;
							continue;
						case 65u:
						{
							inputText = _200F_200F_200B_206B_200B_202B_206A_206D_200D_206A_202B_202B_206F_202D_206E_200F_202D_206E_206E_202A_206E_206E_206E_202B_200E_200C_200B_202B_200E_200B_200D_206F_200E_200B_200B_202C_200E_206F_202D_206A_202E(inputText, num7, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3059053342u));
							num30 = _200F_206C_200F_202A_206C_202B_200D_206C_200D_206A_200E_200E_200C_202A_200F_202A_206E_200E_206C_206B_202A_200D_206A_202A_202D_206D_206B_202A_202D_202C_202B_206D_202D_202B_202A_200E_206E_202D_202D_202E(inputText, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3631287709u), num7 + 3);
							int num31;
							int num32;
							if (num30 < 0)
							{
								num31 = -387905119;
								num32 = num31;
							}
							else
							{
								num31 = -1089871030;
								num32 = num31;
							}
							num6 = num31 ^ (int)(num2 * 370764107);
							continue;
						}
						case 8u:
							num20 = _200F_206C_200F_202A_206C_202B_200D_206C_200D_206A_200E_200E_200C_202A_200F_202A_206E_200E_206C_206B_202A_200D_206A_202A_202D_206D_206B_202A_202D_202C_202B_206D_202D_202B_202A_200E_206E_202D_202D_202E(inputText, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3768067840u), num19 + 13);
							num6 = (int)(num2 * 1063934634) ^ -799430835;
							continue;
						case 50u:
						{
							int num11;
							int num12;
							if (num10 >= 0)
							{
								num11 = -1555561873;
								num12 = num11;
							}
							else
							{
								num11 = -1112418648;
								num12 = num11;
							}
							num6 = num11 ^ ((int)num2 * -1223385214);
							continue;
						}
						case 2u:
							inputText = _200F_200F_200B_206B_200B_202B_206A_206D_200D_206A_202B_202B_206F_202D_206E_200F_202D_206E_206E_202A_206E_206E_206E_202B_200E_200C_200B_202B_200E_200B_200D_206F_200E_200B_200B_202C_200E_206F_202D_206A_202E(inputText, num15, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(993601769u));
							num6 = (int)(num2 * 1502603838) ^ -1093890951;
							continue;
						case 21u:
							inputText = _206A_206A_200E_206D_206F_206A_206D_200B_200C_202D_200E_206B_202A_206A_206C_202D_200E_206D_206E_200B_206F_202A_200F_202A_206F_206D_200F_200F_206D_200D_200C_200D_200C_200D_206C_202B_202D_206D_206B_202D_202E(inputText, num36, 10);
							num6 = (int)((num2 * 162870760) ^ 0x39707D4F);
							continue;
						case 4u:
							inputText = _200F_200F_200B_206B_200B_202B_206A_206D_200D_206A_202B_202B_206F_202D_206E_200F_202D_206E_206E_202A_206E_206E_206E_202B_200E_200C_200B_202B_200E_200B_200D_206F_200E_200B_200B_202C_200E_206F_202D_206A_202E(inputText, num20, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(373234159u));
							num6 = ((int)num2 * -173938740) ^ -182661389;
							continue;
						case 66u:
							num19 = _200D_202B_206D_200C_202A_206B_202C_202B_202E_206F_206C_200B_200C_200F_202A_200D_206A_202E_200F_202A_202A_206D_200C_202C_200F_200E_206D_206B_202D_200F_200F_202C_200B_200E_202B_200B_202A_202C_200C_200C_202E(inputText, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3210125407u));
							num6 = -1811612304;
							continue;
						case 22u:
							goto IL_0847;
						case 40u:
							inputText = _200F_200F_200B_206B_200B_202B_206A_206D_200D_206A_202B_202B_206F_202D_206E_200F_202D_206E_206E_202A_206E_206E_206E_202B_200E_200C_200B_202B_200E_200B_200D_206F_200E_200B_200B_202C_200E_206F_202D_206A_202E(inputText, num16, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2022879454u));
							num6 = ((int)num2 * -335969829) ^ -1285886641;
							continue;
						case 24u:
							inputText = _206A_206A_200E_206D_206F_206A_206D_200B_200C_202D_200E_206B_202A_206A_206C_202D_200E_206D_206E_200B_206F_202A_200F_202A_206F_206D_200F_200F_206D_200D_200C_200D_200C_200D_206C_202B_202D_206D_206B_202D_202E(inputText, num19, 6);
							num6 = (int)(num2 * 493262028) ^ -1271241116;
							continue;
						case 56u:
							inputText = _206A_206A_200E_206D_206F_206A_206D_200B_200C_202D_200E_206B_202A_206A_206C_202D_200E_206D_206E_200B_206F_202A_200F_202A_206F_206D_200F_200F_206D_200D_200C_200D_200C_200D_206C_202B_202D_206D_206B_202D_202E(inputText, num33, 9);
							inputText = _200F_200F_200B_206B_200B_202B_206A_206D_200D_206A_202B_202B_206F_202D_206E_200F_202D_206E_206E_202A_206E_206E_206E_202B_200E_200C_200B_202B_200E_200B_200D_206F_200E_200B_200B_202C_200E_206F_202D_206A_202E(inputText, num33, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1505239051u));
							num6 = (int)(num2 * 1940448358) ^ -1043024551;
							continue;
						case 13u:
							goto IL_08d8;
						case 44u:
							inputText = _206A_206A_200E_206D_206F_206A_206D_200B_200C_202D_200E_206B_202A_206A_206C_202D_200E_206D_206E_200B_206F_202A_200F_202A_206F_206D_200F_200F_206D_200D_200C_200D_200C_200D_206C_202B_202D_206D_206B_202D_202E(inputText, num41, 6);
							num6 = ((int)num2 * -49298940) ^ -1135334567;
							continue;
						case 63u:
							inputText = _200F_200F_200B_206B_200B_202B_206A_206D_200D_206A_202B_202B_206F_202D_206E_200F_202D_206E_206E_202A_206E_206E_206E_202B_200E_200C_200B_202B_200E_200B_200D_206F_200E_200B_200B_202C_200E_206F_202D_206A_202E(inputText, num30, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3669023202u));
							num6 = (int)(num2 * 1858897287) ^ -2019800380;
							continue;
						case 46u:
							name = role.Name;
							goto IL_0938;
						case 62u:
							num10 = _200D_202B_206D_200C_202A_206B_202C_202B_202E_206F_206C_200B_200C_200F_202A_200D_206A_202E_200F_202A_202A_206D_200C_202C_200F_200E_206D_206B_202D_200F_200F_202C_200B_200E_202B_200B_202A_202C_200C_200C_202E(inputText, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3776736380u));
							num6 = -839502801;
							continue;
						case 32u:
							inputText = _206A_206A_200E_206D_206F_206A_206D_200B_200C_202D_200E_206B_202A_206A_206C_202D_200E_206D_206E_200B_206F_202A_200F_202A_206F_206D_200F_200F_206D_200D_200C_200D_200C_200D_206C_202B_202D_206D_206B_202D_202E(inputText, num24, 8);
							num6 = (int)(num2 * 1630315963) ^ -869082754;
							continue;
						case 61u:
						{
							int num54;
							int num55;
							if (num15 < 0)
							{
								num54 = 1077727639;
								num55 = num54;
							}
							else
							{
								num54 = 683650585;
								num55 = num54;
							}
							num6 = num54 ^ ((int)num2 * -1245297591);
							continue;
						}
						case 35u:
						{
							int num50;
							int num51;
							if (num16 >= 0)
							{
								num50 = 114914951;
								num51 = num50;
							}
							else
							{
								num50 = 1868078346;
								num51 = num50;
							}
							num6 = num50 ^ ((int)num2 * -1571546936);
							continue;
						}
						case 41u:
							num33 = _200F_206C_200F_202A_206C_202B_200D_206C_200D_206A_200E_200E_200C_202A_200F_202A_206E_200E_206C_206B_202A_200D_206A_202A_202D_206D_206B_202A_202D_202C_202B_206D_202D_202B_202A_200E_206E_202D_202D_202E(inputText, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2812757601u), num38 + 1);
							num6 = -994274541;
							continue;
						case 17u:
							num7 = _200D_202B_206D_200C_202A_206B_202C_202B_202E_206F_206C_200B_200C_200F_202A_200D_206A_202E_200F_202A_202A_206D_200C_202C_200F_200E_206D_206B_202D_200F_200F_202C_200B_200E_202B_200B_202A_202C_200C_200C_202E(inputText, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(956388762u));
							num6 = -576892451;
							continue;
						case 34u:
							inputText = _206A_206A_200E_206D_206F_206A_206D_200B_200C_202D_200E_206B_202A_206A_206C_202D_200E_206D_206E_200B_206F_202A_200F_202A_206F_206D_200F_200F_206D_200D_200C_200D_200C_200D_206C_202B_202D_206D_206B_202D_202E(inputText, num27, 5);
							num6 = ((int)num2 * -1616913066) ^ -729222155;
							continue;
						case 42u:
							inputText = _200F_200F_200B_206B_200B_202B_206A_206D_200D_206A_202B_202B_206F_202D_206E_200F_202D_206E_206E_202A_206E_206E_206E_202B_200E_200C_200B_202B_200E_200B_200D_206F_200E_200B_200B_202C_200E_206F_202D_206A_202E(inputText, num24, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3448439734u));
							num15 = _200F_206C_200F_202A_206C_202B_200D_206C_200D_206A_200E_200E_200C_202A_200F_202A_206E_200E_206C_206B_202A_200D_206A_202A_202D_206D_206B_202A_202D_202C_202B_206D_202D_202B_202A_200E_206E_202D_202D_202E(inputText, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3388678570u), num24 + 7);
							num6 = (int)((num2 * 1132368402) ^ 0x6AAB6F90);
							continue;
						case 9u:
						{
							int num48;
							int num49;
							if (num20 < 0)
							{
								num48 = 21836712;
								num49 = num48;
							}
							else
							{
								num48 = 109695105;
								num49 = num48;
							}
							num6 = num48 ^ ((int)num2 * -1370542563);
							continue;
						}
						case 36u:
							inputText = _206A_206A_200E_206D_206F_206A_206D_200B_200C_202D_200E_206B_202A_206A_206C_202D_200E_206D_206E_200B_206F_202A_200F_202A_206F_206D_200F_200F_206D_200D_200C_200D_200C_200D_206C_202B_202D_206D_206B_202D_202E(inputText, num30, 6);
							num6 = (int)(num2 * 184082143) ^ -1961632887;
							continue;
						case 43u:
							inputText = _206A_206A_200E_206D_206F_206A_206D_200B_200C_202D_200E_206B_202A_206A_206C_202D_200E_206D_206E_200B_206F_202A_200F_202A_206F_206D_200F_200F_206D_200D_200C_200D_200C_200D_206C_202B_202D_206D_206B_202D_202E(inputText, num21, 2);
							inputText = _200F_200F_200B_206B_200B_202B_206A_206D_200D_206A_202B_202B_206F_202D_206E_200F_202D_206E_206E_202A_206E_206E_206E_202B_200E_200C_200B_202B_200E_200B_200D_206F_200E_200B_200B_202C_200E_206F_202D_206A_202E(inputText, num21, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4087182628u));
							num6 = (int)((num2 * 277053113) ^ 0x2DEC7BF);
							continue;
						case 1u:
							inputText = _200D_206B_206A_202D_200B_206C_206D_202C_206D_200F_206E_202B_200F_202D_200F_200D_202A_206C_202B_206C_200C_202C_202C_206D_200B_202E_200C_200E_200B_202B_206B_202C_206A_202E_202D_202E_200D_206D_206A_206A_202E(inputText, text3, text2);
							num6 = (int)(num2 * 423151130) ^ -1536108807;
							continue;
						case 25u:
						{
							int num44;
							int num45;
							if (num7 < 0)
							{
								num44 = -2035748271;
								num45 = num44;
							}
							else
							{
								num44 = -1524443357;
								num45 = num44;
							}
							num6 = num44 ^ ((int)num2 * -228751026);
							continue;
						}
						case 10u:
						{
							int num39;
							int num40;
							if (num38 < 0)
							{
								num39 = -719426493;
								num40 = num39;
							}
							else
							{
								num39 = -1795688264;
								num40 = num39;
							}
							num6 = num39 ^ ((int)num2 * -1840340179);
							continue;
						}
						case 60u:
							num6 = ((int)num2 * -1537122726) ^ 0x48BAEB3E;
							continue;
						case 39u:
							inputText = _206A_206A_200E_206D_206F_206A_206D_200B_200C_202D_200E_206B_202A_206A_206C_202D_200E_206D_206E_200B_206F_202A_200F_202A_206F_206D_200F_200F_206D_200D_200C_200D_200C_200D_206C_202B_202D_206D_206B_202D_202E(inputText, num16, 9);
							num6 = ((int)num2 * -1922522689) ^ 0x47A75D59;
							continue;
						case 26u:
							num21 = _200F_206C_200F_202A_206C_202B_200D_206C_200D_206A_200E_200E_200C_202A_200F_202A_206E_200E_206C_206B_202A_200D_206A_202A_202D_206D_206B_202A_202D_202C_202B_206D_202D_202B_202A_200E_206E_202D_202D_202E(inputText, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(705083690u), num16 + 16);
							num6 = ((int)num2 * -221564073) ^ -1188167688;
							continue;
						case 19u:
							inputText = _206A_206A_200E_206D_206F_206A_206D_200B_200C_202D_200E_206B_202A_206A_206C_202D_200E_206D_206E_200B_206F_202A_200F_202A_206F_206D_200F_200F_206D_200D_200C_200D_200C_200D_206C_202B_202D_206D_206B_202D_202E(inputText, num37, 1);
							num6 = (int)((num2 * 1817600905) ^ 0x697FA2E5);
							continue;
						case 58u:
							inputText = _206A_206A_200E_206D_206F_206A_206D_200B_200C_202D_200E_206B_202A_206A_206C_202D_200E_206D_206E_200B_206F_202A_200F_202A_206F_206D_200F_200F_206D_200D_200C_200D_200C_200D_206C_202B_202D_206D_206B_202D_202E(inputText, num15, 2);
							num6 = ((int)num2 * -625610956) ^ -383743525;
							continue;
						case 14u:
							inputText = _200F_200F_200B_206B_200B_202B_206A_206D_200D_206A_202B_202B_206F_202D_206E_200F_202D_206E_206E_202A_206E_206E_206E_202B_200E_200C_200B_202B_200E_200B_200D_206F_200E_200B_200B_202C_200E_206F_202D_206A_202E(inputText, num36, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3984246105u));
							num6 = (int)(num2 * 789134694) ^ -826760044;
							continue;
						case 12u:
						{
							int num34;
							int num35;
							if (num33 < 0)
							{
								num34 = -1055135454;
								num35 = num34;
							}
							else
							{
								num34 = -2002104178;
								num35 = num34;
							}
							num6 = num34 ^ ((int)num2 * -1507013101);
							continue;
						}
						case 38u:
						{
							int num22;
							int num23;
							if (num21 >= 0)
							{
								num22 = 1914229467;
								num23 = num22;
							}
							else
							{
								num22 = 881507380;
								num23 = num22;
							}
							num6 = num22 ^ (int)(num2 * 2003588640);
							continue;
						}
						case 15u:
							inputText = _200F_200F_200B_206B_200B_202B_206A_206D_200D_206A_202B_202B_206F_202D_206E_200F_202D_206E_206E_202A_206E_206E_206E_202B_200E_200C_200B_202B_200E_200B_200D_206F_200E_200B_200B_202C_200E_206F_202D_206A_202E(inputText, num10, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3922516884u));
							num6 = (int)((num2 * 1311648757) ^ 0x7E7165E1);
							continue;
						case 68u:
						{
							int num17;
							int num18;
							if (num10 >= 0)
							{
								num17 = -317019320;
								num18 = num17;
							}
							else
							{
								num17 = -1006631183;
								num18 = num17;
							}
							num6 = num17 ^ ((int)num2 * -271180562);
							continue;
						}
						case 67u:
							num16 = 0;
							num6 = ((int)num2 * -1563585688) ^ 0x2B46F7E9;
							continue;
						case 20u:
							inputText = _206A_206A_200E_206D_206F_206A_206D_200B_200C_202D_200E_206B_202A_206A_206C_202D_200E_206D_206E_200B_206F_202A_200F_202A_206F_206D_200F_200F_206D_200D_200C_200D_200C_200D_206C_202B_202D_206D_206B_202D_202E(inputText, num10, 7);
							num6 = ((int)num2 * -432841911) ^ -1796770793;
							continue;
						case 0u:
						{
							int num8;
							int num9;
							if (num7 >= 0)
							{
								num8 = -1893182068;
								num9 = num8;
							}
							else
							{
								num8 = -461758269;
								num9 = num8;
							}
							num6 = num8 ^ (int)(num2 * 1561887968);
							continue;
						}
						default:
							{
								return inputText;
							}
							IL_0938:
							text2 = name;
							num6 = -532225135;
							continue;
						}
						break;
						IL_0847:
						int num57;
						if (num27 >= 0)
						{
							num6 = -2117846999;
							num57 = num6;
						}
						else
						{
							num6 = -265301173;
							num57 = num6;
						}
						continue;
						IL_040d:
						int num58;
						if (num19 < 0)
						{
							num6 = -508859314;
							num58 = num6;
						}
						else
						{
							num6 = -44824905;
							num58 = num6;
						}
						continue;
						IL_060e:
						num24 = _200D_202B_206D_200C_202A_206B_202C_202B_202E_206F_206C_200B_200C_200F_202A_200D_206A_202E_200F_202A_202A_206D_200C_202C_200F_200E_206D_206B_202D_200F_200F_202C_200B_200E_202B_200B_202A_202C_200C_200C_202E(inputText, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(25050018u));
						int num59;
						if (num24 >= 0)
						{
							num6 = -1743084628;
							num59 = num6;
						}
						else
						{
							num6 = -497624222;
							num59 = num6;
						}
						continue;
						IL_06db:
						num16 = _200D_202B_206D_200C_202A_206B_202C_202B_202E_206F_206C_200B_200C_200F_202A_200D_206A_202E_200F_202A_202A_206D_200C_202C_200F_200E_206D_206B_202D_200F_200F_202C_200B_200E_202B_200B_202A_202C_200C_200C_202E(inputText, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(887729074u));
						int num60;
						if (num16 < 0)
						{
							num6 = -1455512524;
							num60 = num6;
						}
						else
						{
							num6 = -908208588;
							num60 = num6;
						}
						continue;
						IL_05e0:
						num37 = _200D_202B_206D_200C_202A_206B_202C_202B_202E_206F_206C_200B_200C_200F_202A_200D_206A_202E_200F_202A_202A_206D_200C_202C_200F_200E_206D_206B_202D_200F_200F_202C_200B_200E_202B_200B_202A_202C_200C_200C_202E(inputText, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4237903868u));
						int num61;
						if (num37 == num24 + 7)
						{
							num6 = -2068511443;
							num61 = num6;
						}
						else
						{
							num6 = -497624222;
							num61 = num6;
						}
					}
					goto IL_024a;
					IL_023c:
					text3 = _202E_200D_206D_206C_202C_200C_206B_206A_206A_202C_200C_200F_200D_202E_200C_202E_202B_206B_200E_200C_206D_200F_200E_206C_200F_200E_200D_200C_202E_206F_206C_200F_200B_202E_200C_206F_206D_202D_202B_202E_202E(inputText, num56, num62 - num56 + 2);
					goto IL_024a;
					IL_04ad:
					if (num56 >= 0)
					{
						goto case 10u;
					}
					num6 = -2073057564;
					goto IL_024f;
					IL_024a:
					num6 = -1985923750;
					goto IL_024f;
					IL_08d8:
					num56 = -1;
					num6 = -985979918;
					goto IL_024f;
				}
				break;
			}
		}
	}

	public void addAllTeamMember(bool isFemale)
	{
		IEnumerator<Role> enumerator = ResourceManager.GetAll<Role>().GetEnumerator();
		try
		{
			Role current = default(Role);
			while (true)
			{
				int num;
				int num2;
				if (!_200C_202A_206C_202A_200E_206A_202B_206F_206A_202E_202E_200B_200D_206B_202C_200E_200D_202E_206F_202C_202B_206D_202A_202B_206D_200F_200C_206B_206D_200B_202D_202E_200F_206C_206C_206B_202E_206D_202D_206E_202E((IEnumerator)enumerator))
				{
					num = 1467955646;
					num2 = num;
				}
				else
				{
					num = 1574034887;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x118FAF5B)) % 6)
					{
					case 3u:
						num = 1574034887;
						continue;
					default:
						return;
					case 2u:
						current = enumerator.Current;
						num = 1797277390;
						continue;
					case 1u:
					{
						int num4;
						int num5;
						if (current.Female == isFemale)
						{
							num4 = 735086984;
							num5 = num4;
						}
						else
						{
							num4 = 1258474304;
							num5 = num4;
						}
						num = num4 ^ (int)(num3 * 1138217317);
						continue;
					}
					case 4u:
						break;
					case 0u:
						addTeamMember(current.Key);
						AddTeamMemberPanel(current.Key);
						num = (int)(num3 * 376635524) ^ -1173572895;
						continue;
					case 5u:
						return;
					}
					break;
				}
			}
		}
		finally
		{
			if (enumerator != null)
			{
				while (true)
				{
					IL_00b3:
					int num6 = 464581627;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num6 ^ 0x118FAF5B)) % 3)
						{
						case 0u:
							break;
						default:
							goto end_IL_00b8;
						case 1u:
							goto IL_00d5;
						case 2u:
							goto end_IL_00b8;
						}
						goto IL_00b3;
						IL_00d5:
						_206D_200E_206E_206E_206A_206B_206B_202E_206F_200F_202D_202D_200B_202E_206F_200B_202A_206B_200D_206B_206B_200C_200B_206B_200F_202C_202C_206F_206A_206F_206E_202B_206B_206C_202C_206C_200F_200B_200F_202E_202E((IDisposable)enumerator);
						num6 = ((int)num3 * -1434849597) ^ -357801062;
						continue;
						end_IL_00b8:
						break;
					}
					break;
				}
			}
		}
	}

	public bool InTemp(string roleKey)
	{
		using (List<Role>.Enumerator enumerator = Temp.GetEnumerator())
		{
			while (true)
			{
				IL_0038:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -420183179;
					num2 = num;
				}
				else
				{
					num = -514271679;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -920110189)) % 5)
					{
					case 3u:
						num = -514271679;
						continue;
					default:
						goto end_IL_0013;
					case 0u:
						break;
					case 2u:
						return true;
					case 4u:
					{
						int num4;
						if (_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(enumerator.Current.Key, roleKey))
						{
							num = -1603818351;
							num4 = num;
						}
						else
						{
							num = -1054538158;
							num4 = num;
						}
						continue;
					}
					case 1u:
						goto end_IL_0013;
					}
					goto IL_0038;
					continue;
					end_IL_0013:
					break;
				}
				break;
			}
		}
		return false;
	}

	public bool InTeamV2(string roleName)
	{
		using (List<Role>.Enumerator enumerator = Team.GetEnumerator())
		{
			while (true)
			{
				IL_005d:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 173982608;
					num2 = num;
				}
				else
				{
					num = 232919451;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x62198DC6)) % 5)
					{
					case 2u:
						num = 173982608;
						continue;
					default:
						goto end_IL_0013;
					case 4u:
					{
						int num4;
						if (!_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(enumerator.Current.Name, roleName))
						{
							num = 1686815142;
							num4 = num;
						}
						else
						{
							num = 1202899373;
							num4 = num;
						}
						continue;
					}
					case 0u:
						break;
					case 3u:
						return true;
					case 1u:
						goto end_IL_0013;
					}
					goto IL_005d;
					continue;
					end_IL_0013:
					break;
				}
				break;
			}
		}
		using (List<Role>.Enumerator enumerator2 = Follow.GetEnumerator())
		{
			while (true)
			{
				IL_00fa:
				int num5;
				int num6;
				if (enumerator2.MoveNext())
				{
					num5 = 1471352567;
					num6 = num5;
				}
				else
				{
					num5 = 1385924228;
					num6 = num5;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num5 ^ 0x62198DC6)) % 5)
					{
					case 4u:
						num5 = 1471352567;
						continue;
					default:
						goto end_IL_00b0;
					case 3u:
					{
						int num7;
						if (_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(enumerator2.Current.Name, roleName))
						{
							num5 = 766062016;
							num7 = num5;
						}
						else
						{
							num5 = 1138524696;
							num7 = num5;
						}
						continue;
					}
					case 2u:
						break;
					case 1u:
						return true;
					case 0u:
						goto end_IL_00b0;
					}
					goto IL_00fa;
					continue;
					end_IL_00b0:
					break;
				}
				break;
			}
		}
		return false;
	}

	public void addAllTeamMemberV2(bool isFemale)
	{
		IEnumerator<Role> enumerator = ResourceManager.GetAll<Role>().GetEnumerator();
		try
		{
			Role current = default(Role);
			while (true)
			{
				int num;
				int num2;
				if (!_200C_202A_206C_202A_200E_206A_202B_206F_206A_202E_202E_200B_200D_206B_202C_200E_200D_202E_206F_202C_202B_206D_202A_202B_206D_200F_200C_206B_206D_200B_202D_202E_200F_206C_206C_206B_202E_206D_202D_206E_202E((IEnumerator)enumerator))
				{
					num = -1356403712;
					num2 = num;
				}
				else
				{
					num = -325515596;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -1351056363)) % 8)
					{
					case 4u:
						num = -325515596;
						continue;
					default:
						return;
					case 3u:
						AddTeamMemberPanel(current.Key);
						num = (int)(num3 * 1873711464) ^ -749798662;
						continue;
					case 2u:
					{
						int num6;
						int num7;
						if (current.Female == isFemale)
						{
							num6 = 313659699;
							num7 = num6;
						}
						else
						{
							num6 = 447074818;
							num7 = num6;
						}
						num = num6 ^ (int)(num3 * 559023904);
						continue;
					}
					case 0u:
						addTeamMember(current.Key);
						num = ((int)num3 * -947996111) ^ 0xBC3B156;
						continue;
					case 7u:
						break;
					case 1u:
						current = enumerator.Current;
						num = -2028423905;
						continue;
					case 6u:
					{
						int num4;
						int num5;
						if (InTeamV2(current.Name))
						{
							num4 = 1165630304;
							num5 = num4;
						}
						else
						{
							num4 = 1844180807;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -656763221);
						continue;
					}
					case 5u:
						return;
					}
					break;
				}
			}
		}
		finally
		{
			if (enumerator != null)
			{
				while (true)
				{
					IL_0100:
					int num8 = -1763194571;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num8 ^ -1351056363)) % 3)
						{
						case 2u:
							break;
						default:
							goto end_IL_0105;
						case 1u:
							goto IL_0122;
						case 0u:
							goto end_IL_0105;
						}
						goto IL_0100;
						IL_0122:
						_206D_200E_206E_206E_206A_206B_206B_202E_206F_200F_202D_202D_200B_202E_206F_200B_202A_206B_200D_206B_206B_200C_200B_206B_200F_202C_202C_206F_206A_206F_206E_202B_206B_206C_202C_206C_200F_200B_200F_202E_202E((IDisposable)enumerator);
						num8 = (int)((num3 * 49217135) ^ 0x54475FEF);
						continue;
						end_IL_0105:
						break;
					}
					break;
				}
			}
		}
	}

	public void removeMalesTeamMember(bool isMale)
	{
		List<Role> list = new List<Role>();
		using (List<Role>.Enumerator enumerator = Team.GetEnumerator())
		{
			ItemInstance current2 = default(ItemInstance);
			while (enumerator.MoveNext())
			{
				while (true)
				{
					Role current = enumerator.Current;
					int num = 471542030;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ 0x525E9500)) % 8)
						{
						case 0u:
							num = 256555511;
							continue;
						case 3u:
						{
							int num7;
							int num8;
							if (current.Female == isMale)
							{
								num7 = 1638409621;
								num8 = num7;
							}
							else
							{
								num7 = 37094850;
								num8 = num7;
							}
							num = num7 ^ (int)(num2 * 1863912565);
							continue;
						}
						case 2u:
							list.Add(current);
							num = 1258832121;
							continue;
						case 5u:
							RemoveTeamMemberPanel(current);
							num = 1919592012;
							continue;
						case 7u:
							break;
						case 6u:
						{
							int num5;
							int num6;
							if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(current.Key, ResourceStrings.ResStrings[0]))
							{
								num5 = -1382723678;
								num6 = num5;
							}
							else
							{
								num5 = -1731623045;
								num6 = num5;
							}
							num = num5 ^ ((int)num2 * -1667069056);
							continue;
						}
						default:
						{
							using (List<ItemInstance>.Enumerator enumerator2 = current.Equipment.GetEnumerator())
							{
								while (true)
								{
									IL_0128:
									int num3;
									int num4;
									if (enumerator2.MoveNext())
									{
										num3 = 519318738;
										num4 = num3;
									}
									else
									{
										num3 = 23831219;
										num4 = num3;
									}
									while (true)
									{
										switch ((num2 = (uint)(num3 ^ 0x525E9500)) % 5)
										{
										case 4u:
											num3 = 519318738;
											continue;
										default:
											goto end_IL_0102;
										case 3u:
											break;
										case 2u:
											addItem(current2);
											num3 = (int)((num2 * 1945441613) ^ 0x37B4AFBD);
											continue;
										case 1u:
											current2 = enumerator2.Current;
											num3 = 1505586160;
											continue;
										case 0u:
											goto end_IL_0102;
										}
										goto IL_0128;
										continue;
										end_IL_0102:
										break;
									}
									break;
								}
							}
							goto end_IL_00a8;
						}
						case 1u:
							goto end_IL_00a8;
						}
						break;
					}
					continue;
					end_IL_00a8:
					break;
				}
			}
		}
		Team.Clear();
		while (true)
		{
			int num9 = 635806036;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num9 ^ 0x525E9500)) % 3)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_01c5;
				case 0u:
					return;
				}
				break;
				IL_01c5:
				Team = list;
				num9 = (int)(num2 * 1415500819) ^ -1333285561;
			}
		}
	}

	public int toChineseTime(string timestr)
	{
		if (_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(timestr))
		{
			goto IL_000b;
		}
		goto IL_020e;
		IL_000b:
		int num = -1515210744;
		goto IL_0010;
		IL_0010:
		string text = default(string);
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1732870900)) % 21)
			{
			case 19u:
				break;
			case 14u:
				return -1;
			case 10u:
				text = _206D_202B_200F_202A_202E_200E_200E_200B_200C_206F_200E_200C_202C_202E_200F_202D_202E_206B_202E_200D_202C_206F_206B_200C_202D_206B_200C_206D_206D_206F_200C_202A_206A_206D_206B_202C_200D_200F_200C_202D_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(907256327u), Tools.GetRandomInt(0, 11), 1);
				num = ((int)num2 * -1254756160) ^ 0x11A50892;
				continue;
			case 5u:
				Date = Date.AddHours(2.0);
				num = -494381624;
				continue;
			case 0u:
				num4++;
				num3++;
				num = (int)((num2 * 947846315) ^ 0x2F729C59);
				continue;
			case 2u:
				num4 = 0;
				num = ((int)num2 * -1631968971) ^ -1622561260;
				continue;
			case 4u:
			{
				int num7;
				int num8;
				if (!((Object)(object)mapUI != (Object)null))
				{
					num7 = 860648958;
					num8 = num7;
				}
				else
				{
					num7 = 359417824;
					num8 = num7;
				}
				num = num7 ^ (int)(num2 * 419461932);
				continue;
			}
			case 20u:
			{
				int num5;
				int num6;
				if (_200B_202C_200E_202C_202C_200E_206C_200F_206C_200B_206C_206F_202C_202C_206A_206D_206F_206C_200E_200F_200B_202A_206D_206B_202E_200F_206C_206C_200D_200B_206D_206F_206F_200D_206A_202E_200D_206C_200E_206B_202E(timestr) < 13)
				{
					num5 = -1052474585;
					num6 = num5;
				}
				else
				{
					num5 = -516304530;
					num6 = num5;
				}
				num = num5 ^ (int)(num2 * 231255339);
				continue;
			}
			case 16u:
				text = _202E_200D_206D_206C_202C_200C_206B_206A_206A_202C_200C_200F_200D_202E_200C_202E_202B_206B_200E_200C_206D_200F_200E_206C_200F_200E_200D_200C_202E_206F_206C_200F_200B_202E_200C_206F_206D_202D_202B_202E_202E(timestr, Tools.GetRandomInt(0, _200B_202C_200E_202C_202C_200E_206C_200F_206C_200B_206C_206F_202C_202C_206A_206D_206F_206C_200E_200F_200B_202A_206D_206B_202E_200F_206C_206C_200D_200B_206D_206F_206F_200D_206A_202E_200D_206C_200E_206B_202E(timestr) - 1), 1);
				num = (int)((num2 * 184799873) ^ 0x1472D9C5);
				continue;
			case 6u:
				text = _202E_200D_206D_206C_202C_200C_206B_206A_206A_202C_200C_200F_200D_202E_200C_202E_202B_206B_200E_200C_206D_200F_200E_206C_200F_200E_200D_200C_202E_206F_206C_200F_200B_202E_200C_206F_206D_202D_202B_202E_202E(timestr, 0, 1);
				num = (int)((num2 * 1507885611) ^ 0x584E6FAF);
				continue;
			case 15u:
				return num4;
			case 9u:
				goto IL_01b3;
			case 3u:
				goto IL_01d0;
			case 12u:
				goto IL_020e;
			case 17u:
				mapUI.RefreshTimeInfo();
				num = ((int)num2 * -1833226117) ^ -2057253115;
				continue;
			case 8u:
				goto IL_0254;
			case 18u:
				goto IL_026b;
			case 1u:
				mapUI.RefreshCurrentBackground();
				num = (int)((num2 * 1281029579) ^ 0x35B8AB31);
				continue;
			case 13u:
				goto IL_02af;
			case 7u:
				num3 = 0;
				num = ((int)num2 * -1038876772) ^ -754628671;
				continue;
			default:
				return -1;
			}
			break;
			IL_02af:
			int num9;
			if (num3 < 11)
			{
				num = -764947251;
				num9 = num;
			}
			else
			{
				num = -1337099750;
				num9 = num;
			}
			continue;
			IL_01b3:
			int num10;
			if (_200B_202C_200E_202C_202C_200E_206C_200F_206C_200B_206C_206F_202C_202C_206A_206D_206F_206C_200E_200F_200B_202A_206D_206B_202E_200F_206C_206C_200D_200B_206D_206F_206F_200D_206A_202E_200D_206C_200E_206B_202E(timestr) <= 1)
			{
				num = -662273838;
				num10 = num;
			}
			else
			{
				num = -1010462152;
				num10 = num;
			}
			continue;
			IL_0254:
			int num11;
			if (text != null)
			{
				num = -67860149;
				num11 = num;
			}
			else
			{
				num = -2024985696;
				num11 = num;
			}
			continue;
			IL_026b:
			int num12;
			if (!_206F_202E_202D_200E_200E_200C_200B_202B_202C_200E_206D_206C_206A_202D_206E_200F_202A_202B_202D_200C_202E_206D_206B_202B_202C_202A_202C_206B_206E_206A_202B_206B_206C_202D_200F_200C_206D_200F_202A_206C_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3455451315u), text))
			{
				num = -1337099750;
				num12 = num;
			}
			else
			{
				num = -655429541;
				num12 = num;
			}
			continue;
			IL_01d0:
			string text2 = Tools.chineseTime[Date.Hour / 2].ToString();
			int num13;
			if (text == text2)
			{
				num = -217453011;
				num13 = num;
			}
			else
			{
				num = -1342640117;
				num13 = num;
			}
		}
		goto IL_000b;
		IL_020e:
		text = null;
		int num14;
		if (!_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(timestr, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(295557320u)))
		{
			num = -94274824;
			num14 = num;
		}
		else
		{
			num = -1360677561;
			num14 = num;
		}
		goto IL_0010;
	}

	public int resurrection(int num, int team, float hp_percent, float mp_percent, string hastalent = null, string hastalent2 = null, int x = -1, int y = -1)
	{
		if (_200E_202B_202A_200D_202C_200D_200C_202D_206D_200C_206A_200C_206D_200B_200F_206A_200E_206F_202B_200F_206C_202E_206E_206A_206C_200C_202C_206C_206C_200D_202A_202A_200B_206A_200E_202A_206B_206F_202D_202E_202E((Object)(object)battleFieldUI, (Object)null))
		{
			while (true)
			{
				uint num2;
				switch ((num2 = 1076603594u) % 3)
				{
				case 0u:
					continue;
				case 2u:
					return -1;
				}
				break;
			}
		}
		return battleFieldUI.resurrectionRole(num, team, hp_percent, mp_percent, hastalent, hastalent2, x, y);
	}

	public void delSkill(string name)
	{
		string[] array = _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(name, new char[1] { '#' });
		int num11 = default(int);
		Role current = default(Role);
		int num6 = default(int);
		bool flag = default(bool);
		SkillInstance current2 = default(SkillInstance);
		InternalSkillInstance current3 = default(InternalSkillInstance);
		SpecialSkillInstance current4 = default(SpecialSkillInstance);
		while (true)
		{
			int num = 74264331;
			while (true)
			{
				int num3;
				uint num2;
				int num30;
				switch ((num2 = (uint)(num ^ 0x6DC91AD6)) % 5)
				{
				case 4u:
					break;
				case 1u:
					num11 = 0;
					goto IL_0643;
				case 2u:
					return;
				case 3u:
				{
					int num4;
					if (array.Length <= 1)
					{
						num3 = 213615685;
						num4 = num3;
					}
					else
					{
						num3 = 193850086;
						num4 = num3;
					}
					goto IL_0070;
				}
				default:
					{
						using (List<Role>.Enumerator enumerator = Team.GetEnumerator())
						{
							while (true)
							{
								IL_05a5:
								if (enumerator.MoveNext())
								{
									while (true)
									{
										current = enumerator.Current;
										int num5 = 919873067;
										while (true)
										{
											switch ((num2 = (uint)(num5 ^ 0x6DC91AD6)) % 11)
											{
											case 7u:
												num5 = 1366907034;
												continue;
											case 6u:
												break;
											case 9u:
												num6 = 2;
												num5 = (int)((num2 * 788026232) ^ 0x32D14DC);
												continue;
											case 2u:
												goto end_IL_0092;
											case 5u:
												num6 = 0;
												num5 = (int)(num2 * 190624651) ^ -179910556;
												continue;
											case 8u:
											{
												int num7;
												int num8;
												if (_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current.Key, array[0]))
												{
													num7 = 29166020;
													num8 = num7;
												}
												else
												{
													num7 = 914032858;
													num8 = num7;
												}
												num5 = num7 ^ (int)(num2 * 603937218);
												continue;
											}
											case 4u:
												num6 = 1;
												num5 = (int)((num2 * 1258556952) ^ 0x1AC1C974);
												continue;
											case 3u:
												goto IL_0169;
											case 1u:
												goto IL_0193;
											case 0u:
												goto IL_01b7;
											default:
												goto IL_01c9;
											}
											flag = false;
											if (!flag)
											{
												num5 = (int)(num2 * 1019694583) ^ -1953531878;
												continue;
											}
											goto IL_02b7;
											IL_01c9:
											using (List<SkillInstance>.Enumerator enumerator2 = current.Skills.GetEnumerator())
											{
												while (true)
												{
													IL_028a:
													int num9;
													int num10;
													if (!enumerator2.MoveNext())
													{
														num9 = 222479075;
														num10 = num9;
													}
													else
													{
														num9 = 955496777;
														num10 = num9;
													}
													while (true)
													{
														switch ((num2 = (uint)(num9 ^ 0x6DC91AD6)) % 7)
														{
														case 5u:
															num9 = 955496777;
															continue;
														default:
															goto end_IL_01e0;
														case 1u:
															flag = true;
															goto end_IL_01e0;
														case 0u:
														{
															int num12;
															int num13;
															if (_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current2.Name, array[num11 + 1]))
															{
																num12 = -465461326;
																num13 = num12;
															}
															else
															{
																num12 = -1218585261;
																num13 = num12;
															}
															num9 = num12 ^ (int)(num2 * 2140730941);
															continue;
														}
														case 2u:
															current.Skills.Remove(current2);
															num9 = ((int)num2 * -638246174) ^ -1625461944;
															continue;
														case 4u:
															current2 = enumerator2.Current;
															num9 = 1452880018;
															continue;
														case 6u:
															break;
														case 3u:
															goto end_IL_01e0;
														}
														goto IL_028a;
														continue;
														end_IL_01e0:
														break;
													}
													break;
												}
											}
											goto IL_02b7;
											IL_01b7:
											if (num6 <= 0)
											{
												goto end_IL_0101;
											}
											num5 = 2037493299;
											continue;
											IL_02b7:
											if (!flag)
											{
												while (true)
												{
													int num14 = 1691273744;
													while (true)
													{
														switch ((num2 = (uint)(num14 ^ 0x6DC91AD6)) % 3)
														{
														case 0u:
															break;
														case 2u:
															goto IL_02e1;
														default:
															goto IL_0302;
														}
														break;
														IL_0302:
														using (List<InternalSkillInstance>.Enumerator enumerator3 = current.InternalSkills.GetEnumerator())
														{
															while (true)
															{
																IL_0350:
																int num15;
																int num16;
																if (enumerator3.MoveNext())
																{
																	num15 = 738874913;
																	num16 = num15;
																}
																else
																{
																	num15 = 454302745;
																	num16 = num15;
																}
																while (true)
																{
																	switch ((num2 = (uint)(num15 ^ 0x6DC91AD6)) % 9)
																	{
																	case 5u:
																		num15 = 738874913;
																		continue;
																	default:
																		goto end_IL_0316;
																	case 8u:
																		break;
																	case 2u:
																	{
																		int num19;
																		int num20;
																		if (!_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current3.Name, array[num11 + 1]))
																		{
																			num19 = 287294169;
																			num20 = num19;
																		}
																		else
																		{
																			num19 = 1260217674;
																			num20 = num19;
																		}
																		num15 = num19 ^ ((int)num2 * -930475605);
																		continue;
																	}
																	case 4u:
																		goto end_IL_0316;
																	case 1u:
																		current3 = enumerator3.Current;
																		num15 = 1365466630;
																		continue;
																	case 3u:
																	{
																		int num17;
																		int num18;
																		if (!current3.IsUsed)
																		{
																			num17 = -594518610;
																			num18 = num17;
																		}
																		else
																		{
																			num17 = -99318197;
																			num18 = num17;
																		}
																		num15 = num17 ^ ((int)num2 * -1280333637);
																		continue;
																	}
																	case 7u:
																		current.InternalSkills.Remove(current3);
																		num15 = (int)((num2 * 1263910605) ^ 0x62B03543);
																		continue;
																	case 0u:
																		flag = true;
																		num15 = 1917162738;
																		continue;
																	case 6u:
																		goto end_IL_0316;
																	}
																	goto IL_0350;
																	continue;
																	end_IL_0316:
																	break;
																}
																break;
															}
														}
														goto end_IL_02be;
														IL_02e1:
														if (current.InternalSkills.Count <= 1)
														{
															goto end_IL_02be;
														}
														num14 = (int)((num2 * 420601355) ^ 0x410C2C48);
													}
													continue;
													end_IL_02be:
													break;
												}
											}
											if (!flag)
											{
												while (true)
												{
													int num21 = 1565849817;
													while (true)
													{
														switch ((num2 = (uint)(num21 ^ 0x6DC91AD6)) % 3)
														{
														case 0u:
															break;
														case 2u:
															goto IL_0453;
														default:
															goto IL_0474;
														}
														break;
														IL_0474:
														using (List<SpecialSkillInstance>.Enumerator enumerator4 = current.SpecialSkills.GetEnumerator())
														{
															while (true)
															{
																IL_04d7:
																int num22;
																int num23;
																if (!enumerator4.MoveNext())
																{
																	num22 = 325770334;
																	num23 = num22;
																}
																else
																{
																	num22 = 2091464038;
																	num23 = num22;
																}
																while (true)
																{
																	switch ((num2 = (uint)(num22 ^ 0x6DC91AD6)) % 7)
																	{
																	case 0u:
																		num22 = 2091464038;
																		continue;
																	default:
																		goto end_IL_0488;
																	case 4u:
																		current.SpecialSkills.Remove(current4);
																		num22 = (int)(num2 * 640692256) ^ -32219513;
																		continue;
																	case 3u:
																		break;
																	case 2u:
																		flag = true;
																		goto end_IL_0488;
																	case 6u:
																		current4 = enumerator4.Current;
																		num22 = 1922575343;
																		continue;
																	case 5u:
																	{
																		int num24;
																		int num25;
																		if (_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current4.Name, array[num11 + 1]))
																		{
																			num24 = -2021397954;
																			num25 = num24;
																		}
																		else
																		{
																			num24 = -1334070593;
																			num25 = num24;
																		}
																		num22 = num24 ^ (int)(num2 * 1638694312);
																		continue;
																	}
																	case 1u:
																		goto end_IL_0488;
																	}
																	goto IL_04d7;
																	continue;
																	end_IL_0488:
																	break;
																}
																break;
															}
														}
														goto end_IL_0430;
														IL_0453:
														if (current.SpecialSkills.Count < 1)
														{
															goto end_IL_0430;
														}
														num21 = ((int)num2 * -581094907) ^ -921308331;
													}
													continue;
													end_IL_0430:
													break;
												}
											}
											if (!flag)
											{
												goto end_IL_0101;
											}
											goto IL_055d;
											IL_0193:
											if (current.Skills.Count > 1)
											{
												num5 = ((int)num2 * -1066467085) ^ -1509621143;
												continue;
											}
											goto IL_02b7;
											IL_0169:
											int num26;
											if (!_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(array[0], ResourceStrings.ResStrings[118]))
											{
												num5 = 117468596;
												num26 = num5;
											}
											else
											{
												num5 = 2096940277;
												num26 = num5;
											}
											continue;
											end_IL_0092:
											break;
										}
										continue;
										end_IL_0101:
										break;
									}
									continue;
								}
								int num27 = 818338101;
								goto IL_0562;
								IL_055d:
								num27 = 1581756587;
								goto IL_0562;
								IL_0562:
								while (true)
								{
									switch ((num2 = (uint)(num27 ^ 0x6DC91AD6)) % 7)
									{
									case 2u:
										break;
									default:
										goto end_IL_05a5;
									case 1u:
										goto end_IL_05a5;
									case 5u:
										goto IL_05a5;
									case 0u:
										RefreshTeamMemberPanel(current, refreshImage: false, refreshText: true);
										num27 = ((int)num2 * -2016223212) ^ -381777691;
										continue;
									case 6u:
										current.InitBind();
										num27 = ((int)num2 * -1109345252) ^ -431463043;
										continue;
									case 4u:
									{
										int num28;
										int num29;
										if (num6 == 1)
										{
											num28 = -2122101789;
											num29 = num28;
										}
										else
										{
											num28 = -33813813;
											num29 = num28;
										}
										num27 = num28 ^ ((int)num2 * -625149106);
										continue;
									}
									case 3u:
										goto end_IL_05a5;
									}
									break;
								}
								goto IL_055d;
								continue;
								end_IL_05a5:
								break;
							}
						}
						num11++;
						goto IL_0620;
					}
					IL_0625:
					switch ((num2 = (uint)(num30 ^ 0x6DC91AD6)) % 3)
					{
					case 0u:
						break;
					default:
						return;
					case 1u:
						goto IL_0643;
					case 2u:
						return;
					}
					goto IL_0620;
					IL_0643:
					if (num11 < array.Length - 1)
					{
						goto default;
					}
					num30 = 860079949;
					goto IL_0625;
					IL_0620:
					num30 = 99594263;
					goto IL_0625;
				}
				break;
				IL_0070:
				num = num3 ^ ((int)num2 * -448981331);
			}
		}
	}

	public string exit_menpai()
	{
		string result = string.Empty;
		if (KeyValues.ContainsKey(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(854191004u)))
		{
			while (true)
			{
				int num = 400573153;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x57B14B43)) % 5)
					{
					case 3u:
						break;
					case 0u:
						KeyValues.Remove(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2256607513u));
						num = ((int)num2 * -2021302802) ^ 0x322AFE71;
						continue;
					case 2u:
						KeyValues[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1151634367u)] = string.Empty;
						num = ((int)num2 * -137223697) ^ 0x3F7349DF;
						continue;
					case 1u:
						result = KeyValues[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(854191004u)];
						num = ((int)num2 * -564720301) ^ -1982988330;
						continue;
					default:
						goto end_IL_0020;
					}
					break;
				}
				continue;
				end_IL_0020:
				break;
			}
		}
		return result;
	}

	public string GetSkillList(float minHard, float maxHard)
	{
		string text = "";
		IEnumerator<Skill> enumerator = ResourceManager.GetAll<Skill>().GetEnumerator();
		try
		{
			Skill current = default(Skill);
			while (true)
			{
				IL_00cd:
				int num;
				int num2;
				if (!_200C_202A_206C_202A_200E_206A_202B_206F_206A_202E_202E_200B_200D_206B_202C_200E_200D_202E_206F_202C_202B_206D_202A_202B_206D_200F_200C_206B_206D_200B_202D_202E_200F_206C_206C_206B_202E_206D_202D_206E_202E((IEnumerator)enumerator))
				{
					num = 1664721577;
					num2 = num;
				}
				else
				{
					num = 1659591323;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x2BFA8180)) % 7)
					{
					case 5u:
						num = 1659591323;
						continue;
					default:
						goto end_IL_001b;
					case 0u:
						text = _206A_206B_202D_202E_200E_206D_202D_202E_206D_200E_202A_202B_206D_200F_202D_206E_202E_200D_202E_202E_206F_200F_200F_200F_206B_202E_202C_200F_202B_202C_200B_206D_202E_200E_200C_202C_200F_202E_202B_206D_202E(text, current.Name, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1583738914u));
						num = ((int)num3 * -1087145863) ^ -379457219;
						continue;
					case 4u:
					{
						int num6;
						int num7;
						if (current.Hard > maxHard)
						{
							num6 = 1588162545;
							num7 = num6;
						}
						else
						{
							num6 = 885837068;
							num7 = num6;
						}
						num = num6 ^ (int)(num3 * 2029638004);
						continue;
					}
					case 1u:
					{
						int num4;
						int num5;
						if (current.Hard >= minHard)
						{
							num4 = 1740878240;
							num5 = num4;
						}
						else
						{
							num4 = 644153168;
							num5 = num4;
						}
						num = num4 ^ (int)(num3 * 1538342735);
						continue;
					}
					case 2u:
						current = enumerator.Current;
						num = 708917259;
						continue;
					case 3u:
						break;
					case 6u:
						goto end_IL_001b;
					}
					goto IL_00cd;
					continue;
					end_IL_001b:
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
					IL_00ee:
					int num8 = 2049352621;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num8 ^ 0x2BFA8180)) % 3)
						{
						case 0u:
							break;
						default:
							goto end_IL_00f3;
						case 2u:
							goto IL_0111;
						case 1u:
							goto end_IL_00f3;
						}
						goto IL_00ee;
						IL_0111:
						_206D_200E_206E_206E_206A_206B_206B_202E_206F_200F_202D_202D_200B_202E_206F_200B_202A_206B_200D_206B_206B_200C_200B_206B_200F_202C_202C_206F_206A_206F_206E_202B_206B_206C_202C_206C_200F_200B_200F_202E_202E((IDisposable)enumerator);
						num8 = ((int)num3 * -364984278) ^ -1494616228;
						continue;
						end_IL_00f3:
						break;
					}
					break;
				}
			}
		}
		IEnumerator<InternalSkill> enumerator2 = ResourceManager.GetAll<InternalSkill>().GetEnumerator();
		try
		{
			InternalSkill current2 = default(InternalSkill);
			while (true)
			{
				IL_016b:
				int num9;
				int num10;
				if (!_200C_202A_206C_202A_200E_206A_202B_206F_206A_202E_202E_200B_200D_206B_202C_200E_200D_202E_206F_202C_202B_206D_202A_202B_206D_200F_200C_206B_206D_200B_202D_202E_200F_206C_206C_206B_202E_206D_202D_206E_202E((IEnumerator)enumerator2))
				{
					num9 = 464149431;
					num10 = num9;
				}
				else
				{
					num9 = 1482216135;
					num10 = num9;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num9 ^ 0x2BFA8180)) % 7)
					{
					case 4u:
						num9 = 1482216135;
						continue;
					default:
						goto end_IL_013a;
					case 0u:
						break;
					case 6u:
					{
						int num13;
						int num14;
						if (current2.Hard < minHard)
						{
							num13 = -675339533;
							num14 = num13;
						}
						else
						{
							num13 = -854037494;
							num14 = num13;
						}
						num9 = num13 ^ (int)(num3 * 440120246);
						continue;
					}
					case 3u:
						text = _206A_206B_202D_202E_200E_206D_202D_202E_206D_200E_202A_202B_206D_200F_202D_206E_202E_200D_202E_202E_206F_200F_200F_200F_206B_202E_202C_200F_202B_202C_200B_206D_202E_200E_200C_202C_200F_202E_202B_206D_202E(text, current2.Name, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2057560981u));
						num9 = ((int)num3 * -668637375) ^ -1762231598;
						continue;
					case 2u:
						current2 = enumerator2.Current;
						num9 = 415979450;
						continue;
					case 5u:
					{
						int num11;
						int num12;
						if (current2.Hard <= maxHard)
						{
							num11 = 1018532087;
							num12 = num11;
						}
						else
						{
							num11 = 1325107301;
							num12 = num11;
						}
						num9 = num11 ^ (int)(num3 * 2070651791);
						continue;
					}
					case 1u:
						goto end_IL_013a;
					}
					goto IL_016b;
					continue;
					end_IL_013a:
					break;
				}
				break;
			}
		}
		finally
		{
			if (enumerator2 != null)
			{
				while (true)
				{
					IL_0211:
					int num15 = 849583068;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num15 ^ 0x2BFA8180)) % 3)
						{
						case 0u:
							break;
						default:
							goto end_IL_0216;
						case 1u:
							goto IL_0234;
						case 2u:
							goto end_IL_0216;
						}
						goto IL_0211;
						IL_0234:
						_206D_200E_206E_206E_206A_206B_206B_202E_206F_200F_202D_202D_200B_202E_206F_200B_202A_206B_200D_206B_206B_200C_200B_206B_200F_202C_202C_206F_206A_206F_206E_202B_206B_206C_202C_206C_200F_200B_200F_202E_202E((IDisposable)enumerator2);
						num15 = ((int)num3 * -1877014472) ^ 0x20652CCA;
						continue;
						end_IL_0216:
						break;
					}
					break;
				}
			}
		}
		if (_206D_202D_206D_202A_200D_206B_206B_202D_202A_202D_206D_202C_206C_206A_200F_206E_202D_202C_202E_200F_206A_200B_206E_200C_206F_206B_202A_200D_206D_206D_206A_206E_206E_202C_206E_206C_202D_200C_200F_206F_202E(text, ""))
		{
			while (true)
			{
				int num16 = 1198234416;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num16 ^ 0x2BFA8180)) % 3)
					{
					case 0u:
						break;
					case 2u:
						text = _202E_200D_206D_206C_202C_200C_206B_206A_206A_202C_200C_200F_200D_202E_200C_202E_202B_206B_200E_200C_206D_200F_200E_206C_200F_200E_200D_200C_202E_206F_206C_200F_200B_202E_200C_206F_206D_202D_202B_202E_202E(text, 0, _200B_202C_200E_202C_202C_200E_206C_200F_206C_200B_206C_206F_202C_202C_206A_206D_206F_206C_200E_200F_200B_202A_206D_206B_202E_200F_206C_206C_200D_200B_206D_206F_206F_200D_206A_202E_200D_206C_200E_206B_202E(text) - 1);
						num16 = (int)((num3 * 1088177578) ^ 0x1A62D1A3);
						continue;
					default:
						goto end_IL_0258;
					}
					break;
				}
				continue;
				end_IL_0258:
				break;
			}
		}
		return text;
	}

	public int addAllTeamMemberFromTemp(bool isFemale)
	{
		List<Role> list = new List<Role>();
		using (List<Role>.Enumerator enumerator = Temp.GetEnumerator())
		{
			Role current = default(Role);
			while (true)
			{
				IL_0075:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 792073369;
					num2 = num;
				}
				else
				{
					num = 483707178;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0xD83C1EE)) % 6)
					{
					case 3u:
						num = 792073369;
						continue;
					default:
						goto end_IL_0019;
					case 1u:
						current = enumerator.Current;
						num = 1223397597;
						continue;
					case 5u:
					{
						int num4;
						int num5;
						if (current.Female != isFemale)
						{
							num4 = 474310411;
							num5 = num4;
						}
						else
						{
							num4 = 431699531;
							num5 = num4;
						}
						num = num4 ^ (int)(num3 * 249707345);
						continue;
					}
					case 4u:
						break;
					case 0u:
						list.Add(current);
						num = (int)((num3 * 713224628) ^ 0x15AE1D10);
						continue;
					case 2u:
						goto end_IL_0019;
					}
					goto IL_0075;
					continue;
					end_IL_0019:
					break;
				}
				break;
			}
		}
		int num6 = 0;
		using (List<Role>.Enumerator enumerator = list.GetEnumerator())
		{
			Role current2 = default(Role);
			while (true)
			{
				IL_01b7:
				int num7;
				int num8;
				if (!enumerator.MoveNext())
				{
					num7 = 1895441492;
					num8 = num7;
				}
				else
				{
					num7 = 1569194462;
					num8 = num7;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num7 ^ 0xD83C1EE)) % 9)
					{
					case 5u:
						num7 = 1569194462;
						continue;
					default:
						goto end_IL_00cc;
					case 8u:
						num6++;
						num7 = ((int)num3 * -2091097471) ^ -812344436;
						continue;
					case 6u:
						Team.Add(current2);
						num7 = (int)(num3 * 1927828457) ^ -710413400;
						continue;
					case 0u:
						Temp.Remove(current2);
						RemoveManualTemp(current2.Key);
						num7 = 482211603;
						continue;
					case 3u:
					{
						int num9;
						int num10;
						if (!InTeam(current2.Key))
						{
							num9 = -1623293574;
							num10 = num9;
						}
						else
						{
							num9 = -1683973431;
							num10 = num9;
						}
						num7 = num9 ^ ((int)num3 * -109736795);
						continue;
					}
					case 1u:
						current2 = enumerator.Current;
						num7 = 1280718001;
						continue;
					case 7u:
						AddTeamMemberPanel(current2);
						num7 = (int)((num3 * 1595998153) ^ 0x745A7259);
						continue;
					case 2u:
						break;
					case 4u:
						goto end_IL_00cc;
					}
					goto IL_01b7;
					continue;
					end_IL_00cc:
					break;
				}
				break;
			}
		}
		return num6;
	}

	public int addAllTempMemberFromTeam(bool isFemale)
	{
		List<Role> list = new List<Role>();
		using (List<Role>.Enumerator enumerator = Team.GetEnumerator())
		{
			Role current = default(Role);
			while (true)
			{
				IL_0078:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -619848500;
					num2 = num;
				}
				else
				{
					num = -2036817171;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -1809613130)) % 5)
					{
					case 3u:
						num = -619848500;
						continue;
					default:
						goto end_IL_0019;
					case 4u:
					{
						current = enumerator.Current;
						int num4;
						if (current.Female != isFemale)
						{
							num = -1721858244;
							num4 = num;
						}
						else
						{
							num = -2135124427;
							num4 = num;
						}
						continue;
					}
					case 2u:
						list.Add(current);
						num = (int)((num3 * 1812914061) ^ 0x3B99AA1B);
						continue;
					case 0u:
						break;
					case 1u:
						goto end_IL_0019;
					}
					goto IL_0078;
					continue;
					end_IL_0019:
					break;
				}
				break;
			}
		}
		int num5 = 0;
		using (List<Role>.Enumerator enumerator = list.GetEnumerator())
		{
			Role current2 = default(Role);
			while (true)
			{
				IL_00ec:
				int num6;
				int num7;
				if (!enumerator.MoveNext())
				{
					num6 = -65170584;
					num7 = num6;
				}
				else
				{
					num6 = -2019757415;
					num7 = num6;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num6 ^ -1809613130)) % 9)
					{
					case 2u:
						num6 = -2019757415;
						continue;
					default:
						goto end_IL_00b2;
					case 8u:
						break;
					case 4u:
						num5++;
						num6 = ((int)num3 * -195403396) ^ -1930728259;
						continue;
					case 5u:
						RemoveTeamMemberPanel(current2);
						num6 = -666939922;
						continue;
					case 3u:
					{
						int num8;
						int num9;
						if (InTemp(current2.Key))
						{
							num8 = 1964512837;
							num9 = num8;
						}
						else
						{
							num8 = 427205853;
							num9 = num8;
						}
						num6 = num8 ^ ((int)num3 * -1190262296);
						continue;
					}
					case 1u:
						current2 = enumerator.Current;
						num6 = -1281999877;
						continue;
					case 0u:
						Temp.Add(current2);
						num6 = ((int)num3 * -1956611684) ^ -1280205418;
						continue;
					case 6u:
						Team.Remove(current2);
						num6 = (int)((num3 * 1001277842) ^ 0x48CC618A);
						continue;
					case 7u:
						goto end_IL_00b2;
					}
					goto IL_00ec;
					continue;
					end_IL_00b2:
					break;
				}
				break;
			}
		}
		return num5;
	}

	public bool CloneTeamRole(string oldroleKey, string newroleKey, bool isdel)
	{
		if (!_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(oldroleKey))
		{
			Role role3 = default(Role);
			Role role2 = default(Role);
			Role role = default(Role);
			Role teamRole = default(Role);
			while (true)
			{
				int num = -1611421312;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1415077692)) % 23)
					{
					case 7u:
						break;
					case 21u:
						return false;
					case 17u:
						role3.Key = role2.Key;
						role3.Name = role2.Name;
						num = (int)((num2 * 1566335042) ^ 0x22096A4A);
						continue;
					case 5u:
						return true;
					case 3u:
						Team.Add(role3);
						num = ((int)num2 * -1652601254) ^ -366907777;
						continue;
					case 8u:
					{
						int num7;
						int num8;
						if (role == null)
						{
							num7 = -669831080;
							num8 = num7;
						}
						else
						{
							num7 = -467898437;
							num8 = num7;
						}
						num = num7 ^ ((int)num2 * -872625727);
						continue;
					}
					case 12u:
					{
						int num13;
						int num14;
						if (!InTemp(newroleKey))
						{
							num13 = -1590825360;
							num14 = num13;
						}
						else
						{
							num13 = -2004939458;
							num14 = num13;
						}
						num = num13 ^ ((int)num2 * -1618801213);
						continue;
					}
					case 13u:
						role2 = null;
						role = ResourceManager.Get<Role>(newroleKey);
						num = -2071099867;
						continue;
					case 15u:
						goto end_IL_000b;
					case 4u:
					{
						int num5;
						int num6;
						if (!_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(oldroleKey, newroleKey))
						{
							num5 = 1549076645;
							num6 = num5;
						}
						else
						{
							num5 = 977848047;
							num6 = num5;
						}
						num = num5 ^ ((int)num2 * -1127731995);
						continue;
					}
					case 22u:
						Team.Remove(teamRole);
						num = (int)(num2 * 2025830625) ^ -1510296379;
						continue;
					case 2u:
						role3 = NewRoleFromRole(teamRole);
						num = ((int)num2 * -380789651) ^ -345480961;
						continue;
					case 1u:
					{
						int num11;
						int num12;
						if (_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(newroleKey))
						{
							num11 = 1488595294;
							num12 = num11;
						}
						else
						{
							num11 = 88073433;
							num12 = num11;
						}
						num = num11 ^ (int)(num2 * 214100376);
						continue;
					}
					case 11u:
						role3.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3274693663u)] = role2.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3274693663u)];
						num = (int)(num2 * 471958) ^ -1466752589;
						continue;
					case 14u:
						role2 = role.Clone();
						num = ((int)num2 * -1047180057) ^ 0x560699AB;
						continue;
					case 16u:
						AddTeamMemberPanel(role3);
						num = ((int)num2 * -265126844) ^ 0xCA91139;
						continue;
					case 19u:
						role3.Head = role2.Head;
						role3.Animation = role2.Animation;
						num = (int)((num2 * 979156023) ^ 0x44B9BDEA);
						continue;
					case 9u:
						goto IL_0268;
					case 10u:
					{
						int num9;
						int num10;
						if (role2 == null)
						{
							num9 = 450991389;
							num10 = num9;
						}
						else
						{
							num9 = 428599851;
							num10 = num9;
						}
						num = num9 ^ ((int)num2 * -1060916262);
						continue;
					}
					case 18u:
						RemoveTeamMemberPanel(teamRole);
						num = ((int)num2 * -1405205650) ^ 0x3D3542F1;
						continue;
					case 6u:
						goto IL_02c1;
					case 20u:
					{
						int num3;
						int num4;
						if (isdel)
						{
							num3 = -962711621;
							num4 = num3;
						}
						else
						{
							num3 = -1130989769;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 287048774);
						continue;
					}
					default:
						return false;
					}
					break;
					IL_02c1:
					int num15;
					if (InTeam(newroleKey))
					{
						num = -1276870302;
						num15 = num;
					}
					else
					{
						num = -367275856;
						num15 = num;
					}
					continue;
					IL_0268:
					teamRole = GetTeamRole(oldroleKey);
					int num16;
					if (teamRole != null)
					{
						num = -1900048477;
						num16 = num;
					}
					else
					{
						num = -1043073109;
						num16 = num;
					}
				}
				continue;
				end_IL_000b:
				break;
			}
		}
		return false;
	}

	public Role NewRoleFromRole(Role role)
	{
		Role role2 = new Role();
		role2.Xml = role.Xml;
		role2.Key = role.Key;
		role2.Animation = role.Animation;
		role2.Name = role.Name;
		SkillInstance item = default(SkillInstance);
		InternalSkillInstance current2 = default(InternalSkillInstance);
		InternalSkillInstance internalSkillInstance = default(InternalSkillInstance);
		SpecialSkillInstance item2 = default(SpecialSkillInstance);
		SpecialSkillInstance current3 = default(SpecialSkillInstance);
		Trigger current5 = default(Trigger);
		Trigger item3 = default(Trigger);
		ItemInstance item4 = default(ItemInstance);
		TitleInstance titleInstance = default(TitleInstance);
		TitleInstance current6 = default(TitleInstance);
		while (true)
		{
			int num = 1058831034;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7163D895)) % 16)
				{
				case 13u:
					break;
				case 2u:
					role2.leftpoint2 = role.leftpoint2;
					num = ((int)num2 * -761634386) ^ -2139936131;
					continue;
				case 5u:
					role2.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(395646854u)] = role.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(11946387u)];
					role2.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2301880830u)] = role.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2301880830u)];
					role2.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(664072894u)] = role.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(664072894u)];
					num = ((int)num2 * -1783328144) ^ 0x7F91773E;
					continue;
				case 7u:
					role2.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1796919217u)] = role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(592457607u)];
					role2.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3905690180u)] = role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1796919217u)];
					num = ((int)num2 * -1017147736) ^ -1582980197;
					continue;
				case 8u:
					role2.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1940200750u)] = role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1029863417u)];
					num = (int)(num2 * 1198842399) ^ -827363604;
					continue;
				case 1u:
					role2.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2981046594u)] = role.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1977936243u)];
					role2.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2145573044u)] = role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3274693663u)];
					role2.currentSkillName = role.currentSkillName;
					role2.leftpoint = role.leftpoint;
					num = (int)((num2 * 289439176) ^ 0x402A278F);
					continue;
				case 14u:
					role2.exp = role.exp;
					num = (int)((num2 * 955210303) ^ 0x14A3F317);
					continue;
				case 11u:
					role2.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1564888282u)] = role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1564888282u)];
					role2.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3583101943u)] = role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3583101943u)];
					num = ((int)num2 * -2139338607) ^ 0x24C7E292;
					continue;
				case 15u:
					role2.Head = role.Head;
					num = (int)((num2 * 1270551331) ^ 0x553414DF);
					continue;
				case 6u:
					role2.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(187771104u)] = role.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(11946387u)];
					num = ((int)num2 * -2065118229) ^ 0x9327602;
					continue;
				case 9u:
					role2.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2722506620u)] = role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(199488088u)];
					role2.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3535376985u)] = role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(248942232u)];
					num = ((int)num2 * -187515138) ^ 0x5F185803;
					continue;
				case 0u:
					role2.exp2 = 0.0 - (double)role.exp;
					role2.SetLevel(role.Level);
					role2.character = role.character;
					role2.character2 = role.character2;
					num = ((int)num2 * -1100389117) ^ -1792730970;
					continue;
				case 12u:
					role2.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1550623476u)] = role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2475589736u)];
					num = ((int)num2 * -1957318307) ^ -1387926509;
					continue;
				case 10u:
					role2.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3406067330u)] = role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(912726802u)];
					num = (int)((num2 * 12653432) ^ 0x55FEA9EC);
					continue;
				case 4u:
					role2.GrowTemplateValue = role.GrowTemplateValue;
					num = (int)((num2 * 772923461) ^ 0x53D3909F);
					continue;
				default:
				{
					role2.TalentValue = role.TalentValue;
					using (List<SkillInstance>.Enumerator enumerator = role.Skills.GetEnumerator())
					{
						while (true)
						{
							IL_056a:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 930006141;
								num4 = num3;
							}
							else
							{
								num3 = 1081458341;
								num4 = num3;
							}
							while (true)
							{
								switch ((num2 = (uint)(num3 ^ 0x7163D895)) % 5)
								{
								case 0u:
									num3 = 930006141;
									continue;
								default:
									goto end_IL_04aa;
								case 3u:
								{
									SkillInstance current = enumerator.Current;
									item = new SkillInstance
									{
										name = current.Name,
										level = current.level,
										level2 = current.level2,
										Exp = current.Exp,
										levelformula = current.levelformula,
										equipped = current.equipped,
										RoleEffect = current.RoleEffect,
										AttackTime = current.AttackTime,
										PowerBattle = current.PowerBattle,
										CostMpBattle = current.CostMpBattle,
										Owner = role2
									};
									num3 = 1655158285;
									continue;
								}
								case 4u:
									break;
								case 2u:
									role2.Skills.Add(item);
									num3 = ((int)num2 * -341643817) ^ -1390419264;
									continue;
								case 1u:
									goto end_IL_04aa;
								}
								goto IL_056a;
								continue;
								end_IL_04aa:
								break;
							}
							break;
						}
					}
					using (List<InternalSkillInstance>.Enumerator enumerator2 = role.InternalSkills.GetEnumerator())
					{
						while (true)
						{
							IL_0649:
							int num5;
							int num6;
							if (!enumerator2.MoveNext())
							{
								num5 = 256719015;
								num6 = num5;
							}
							else
							{
								num5 = 1429294530;
								num6 = num5;
							}
							while (true)
							{
								switch ((num2 = (uint)(num5 ^ 0x7163D895)) % 7)
								{
								case 6u:
									num5 = 1429294530;
									continue;
								default:
									goto end_IL_05cd;
								case 1u:
									current2 = enumerator2.Current;
									num5 = 856762503;
									continue;
								case 4u:
								{
									int num7;
									int num8;
									if (internalSkillInstance.IsUsed)
									{
										num7 = 442922109;
										num8 = num7;
									}
									else
									{
										num7 = 1974765735;
										num8 = num7;
									}
									num5 = num7 ^ ((int)num2 * -921584991);
									continue;
								}
								case 3u:
									role2.EquippedInternalSkill = internalSkillInstance;
									num5 = ((int)num2 * -108781210) ^ 0x7320F16A;
									continue;
								case 0u:
									break;
								case 5u:
									internalSkillInstance = new InternalSkillInstance
									{
										name = current2.Name,
										level = current2.level,
										level2 = current2.level2,
										Exp = current2.Exp,
										equipped = current2.equipped,
										RoleEffect = current2.RoleEffect,
										AttackTime = current2.AttackTime,
										PowerBattle = current2.PowerBattle,
										CostMpBattle = current2.CostMpBattle,
										YinBattle = current2.YinBattle,
										YangBattle = current2.YangBattle,
										AttackBattle = current2.AttackBattle,
										Owner = role2
									};
									role2.InternalSkills.Add(internalSkillInstance);
									num5 = ((int)num2 * -161482108) ^ -1713062230;
									continue;
								case 2u:
									goto end_IL_05cd;
								}
								goto IL_0649;
								continue;
								end_IL_05cd:
								break;
							}
							break;
						}
					}
					using (List<SpecialSkillInstance>.Enumerator enumerator3 = role.SpecialSkills.GetEnumerator())
					{
						while (true)
						{
							IL_0823:
							int num9;
							int num10;
							if (enumerator3.MoveNext())
							{
								num9 = 1639967678;
								num10 = num9;
							}
							else
							{
								num9 = 1738978177;
								num10 = num9;
							}
							while (true)
							{
								switch ((num2 = (uint)(num9 ^ 0x7163D895)) % 6)
								{
								case 5u:
									num9 = 1639967678;
									continue;
								default:
									goto end_IL_0757;
								case 1u:
									role2.SpecialSkills.Add(item2);
									num9 = ((int)num2 * -751646197) ^ -971996398;
									continue;
								case 0u:
									item2 = new SpecialSkillInstance
									{
										name = current3.Name,
										equipped = current3.equipped,
										RoleEffect = current3.RoleEffect,
										AttackTime = current3.AttackTime,
										PowerBattle = current3.PowerBattle,
										CostMpBattle = current3.CostMpBattle,
										Owner = role2
									};
									num9 = (int)((num2 * 619705124) ^ 0x3D44154C);
									continue;
								case 3u:
									current3 = enumerator3.Current;
									num9 = 1713842697;
									continue;
								case 2u:
									break;
								case 4u:
									goto end_IL_0757;
								}
								goto IL_0823;
								continue;
								end_IL_0757:
								break;
							}
							break;
						}
					}
					using (List<ItemInstance>.Enumerator enumerator4 = role.Equipment.GetEnumerator())
					{
						while (true)
						{
							IL_09d8:
							if (enumerator4.MoveNext())
							{
								ItemInstance current4;
								while (true)
								{
									current4 = enumerator4.Current;
									int num11 = 1795277166;
									while (true)
									{
										switch ((num2 = (uint)(num11 ^ 0x7163D895)) % 3)
										{
										case 0u:
											num11 = 1716525702;
											continue;
										case 2u:
											break;
										default:
											goto end_IL_0885;
										}
										break;
									}
									continue;
									end_IL_0885:
									break;
								}
								List<Trigger> list = new List<Trigger>();
								using (List<Trigger>.Enumerator enumerator5 = current4.AdditionTriggers.GetEnumerator())
								{
									while (true)
									{
										IL_094b:
										int num12;
										int num13;
										if (enumerator5.MoveNext())
										{
											num12 = 1975702639;
											num13 = num12;
										}
										else
										{
											num12 = 1930162650;
											num13 = num12;
										}
										while (true)
										{
											switch ((num2 = (uint)(num12 ^ 0x7163D895)) % 6)
											{
											case 3u:
												num12 = 1975702639;
												continue;
											default:
												goto end_IL_08b4;
											case 4u:
												current5 = enumerator5.Current;
												num12 = 243234322;
												continue;
											case 5u:
												item3 = new Trigger
												{
													Name = current5.Name,
													ArgvsString = current5.ArgvsString,
													Level = current5.Level
												};
												num12 = ((int)num2 * -577571351) ^ 0x37E7ED1A;
												continue;
											case 0u:
												list.Add(item3);
												num12 = (int)((num2 * 1382870044) ^ 0x427FDE0B);
												continue;
											case 2u:
												break;
											case 1u:
												goto end_IL_08b4;
											}
											goto IL_094b;
											continue;
											end_IL_08b4:
											break;
										}
										break;
									}
								}
								item4 = new ItemInstance
								{
									Name = current4.Name,
									AdditionTriggers = list
								};
								goto IL_0994;
							}
							int num14 = 323297203;
							goto IL_0999;
							IL_0994:
							num14 = 110812632;
							goto IL_0999;
							IL_0999:
							while (true)
							{
								switch ((num2 = (uint)(num14 ^ 0x7163D895)) % 4)
								{
								case 0u:
									break;
								default:
									goto end_IL_09d8;
								case 1u:
									role2.Equipment.Add(item4);
									num14 = ((int)num2 * -1324626525) ^ 0x54503425;
									continue;
								case 3u:
									goto IL_09d8;
								case 2u:
									goto end_IL_09d8;
								}
								break;
							}
							goto IL_0994;
							continue;
							end_IL_09d8:
							break;
						}
					}
					if (CommonSettings.MOD_KEY() >= 0)
					{
						while (true)
						{
							int num15 = 1636808777;
							while (true)
							{
								switch ((num2 = (uint)(num15 ^ 0x7163D895)) % 3)
								{
								case 2u:
									break;
								case 1u:
									goto IL_0a29;
								default:
									goto IL_0a44;
								}
								break;
								IL_0a44:
								using (List<TitleInstance>.Enumerator enumerator6 = role.Titles.GetEnumerator())
								{
									while (true)
									{
										IL_0aac:
										int num16;
										int num17;
										if (!enumerator6.MoveNext())
										{
											num16 = 1703207428;
											num17 = num16;
										}
										else
										{
											num16 = 149170970;
											num17 = num16;
										}
										while (true)
										{
											switch ((num2 = (uint)(num16 ^ 0x7163D895)) % 7)
											{
											case 3u:
												num16 = 149170970;
												continue;
											default:
												goto end_IL_0a58;
											case 4u:
											{
												int num18;
												int num19;
												if (titleInstance.IsUsed)
												{
													num18 = 229269775;
													num19 = num18;
												}
												else
												{
													num18 = 1555489798;
													num19 = num18;
												}
												num16 = num18 ^ ((int)num2 * -935869508);
												continue;
											}
											case 6u:
												break;
											case 1u:
												current6 = enumerator6.Current;
												num16 = 318397626;
												continue;
											case 0u:
												titleInstance = new TitleInstance
												{
													name = current6.name,
													equipped = current6.equipped,
													Owner = role2
												};
												role2.Titles.Add(titleInstance);
												num16 = ((int)num2 * -238812169) ^ 0x3AAFE7D8;
												continue;
											case 2u:
												role2.EquippedTitle = titleInstance;
												num16 = ((int)num2 * -1221813361) ^ -887319360;
												continue;
											case 5u:
												goto end_IL_0a58;
											}
											goto IL_0aac;
											continue;
											end_IL_0a58:
											break;
										}
										break;
									}
								}
								goto IL_0b49;
								IL_0a29:
								if (role.Titles != null)
								{
									num15 = (int)(num2 * 1753443222) ^ -619769210;
									continue;
								}
								goto IL_0b49;
								IL_0b49:
								role2.jiushen_count = role.jiushen_count;
								goto end_IL_0a06;
							}
							continue;
							end_IL_0a06:
							break;
						}
					}
					role2.InitBind();
					return role2;
				}
				}
				break;
			}
		}
	}

	public int GetTrialRolesCount()
	{
		int num = _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(TrialRoles, new char[1] { '#' }).Length - 1;
		while (true)
		{
			int num2 = -1325941128;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -758219430)) % 4)
				{
				case 3u:
					break;
				case 2u:
				{
					int num4;
					int num5;
					if (num >= 0)
					{
						num4 = -233216882;
						num5 = num4;
					}
					else
					{
						num4 = -2028774865;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num3 * -408676698);
					continue;
				}
				case 1u:
					num = 0;
					num2 = (int)(num3 * 305751) ^ -114644835;
					continue;
				default:
					return num;
				}
				break;
			}
		}
	}

	public bool AddSkillMaxLevel(string name)
	{
		bool flag = false;
		int result = default(int);
		int num8 = default(int);
		int num9 = default(int);
		int num3 = default(int);
		string[] array = default(string[]);
		int skillMaxLevel = default(int);
		InternalSkill internalSkill = default(InternalSkill);
		while (true)
		{
			int num = -325332476;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1010376019)) % 35)
				{
				case 9u:
					break;
				case 3u:
					flag = true;
					num = (int)(num2 * 268940242) ^ -412478154;
					continue;
				case 0u:
					result = 1;
					num = (int)((num2 * 549809368) ^ 0x717C0942);
					continue;
				case 29u:
				{
					int num10;
					if (num8 >= num9)
					{
						num = -1441955680;
						num10 = num;
					}
					else
					{
						num = -1968940476;
						num10 = num;
					}
					continue;
				}
				case 6u:
					ModData.Set_needSave();
					num = (int)(num2 * 865474117) ^ -2124519841;
					continue;
				case 23u:
					num3 = 1;
					num = (int)(num2 * 1510841469) ^ -1161828187;
					continue;
				case 24u:
				{
					num9 = array.Length;
					int num21;
					int num22;
					if (num9 > 20)
					{
						num21 = -1156165457;
						num22 = num21;
					}
					else
					{
						num21 = -499422552;
						num22 = num21;
					}
					num = num21 ^ (int)(num2 * 1516067871);
					continue;
				}
				case 17u:
					num8 += 2;
					num = -1694138966;
					continue;
				case 32u:
				{
					int num18;
					if (result >= -100)
					{
						num = -264452804;
						num18 = num;
					}
					else
					{
						num = -1212873924;
						num18 = num;
					}
					continue;
				}
				case 33u:
					num9 = 20;
					num = ((int)num2 * -86392875) ^ 0x6428B2DE;
					continue;
				case 4u:
					num = ((int)num2 * -1814933968) ^ 0x6D7F9E55;
					continue;
				case 34u:
				{
					int num27;
					int num28;
					if (flag)
					{
						num27 = 1954036229;
						num28 = num27;
					}
					else
					{
						num27 = 1431646304;
						num28 = num27;
					}
					num = num27 ^ ((int)num2 * -1243643373);
					continue;
				}
				case 20u:
					num = ((int)num2 * -883627554) ^ -1882022884;
					continue;
				case 18u:
					num8 = 0;
					num = -1102358408;
					continue;
				case 14u:
				{
					int num23;
					int num24;
					if (skillMaxLevel + result > CommonSettings.MAX_SKILL_LEVEL)
					{
						num23 = -627125363;
						num24 = num23;
					}
					else
					{
						num23 = -2029408059;
						num24 = num23;
					}
					num = num23 ^ (int)(num2 * 758158069);
					continue;
				}
				case 5u:
				{
					int num16;
					if (result <= 100)
					{
						num = -2099109084;
						num16 = num;
					}
					else
					{
						num = -580999206;
						num16 = num;
					}
					continue;
				}
				case 7u:
				{
					int num13;
					int num14;
					if (int.TryParse(array[num8 + 1], out result))
					{
						num13 = 1559035808;
						num14 = num13;
					}
					else
					{
						num13 = 1729560805;
						num14 = num13;
					}
					num = num13 ^ ((int)num2 * -1919597681);
					continue;
				}
				case 25u:
				{
					int num6;
					if (num3 < 1)
					{
						num = -1216565766;
						num6 = num;
					}
					else
					{
						num = -252798681;
						num6 = num;
					}
					continue;
				}
				case 19u:
					num = (int)(num2 * 1372159703) ^ -1781518827;
					continue;
				case 26u:
					result = -100;
					num = (int)(num2 * 1316422738) ^ -895443480;
					continue;
				case 8u:
				{
					int num26;
					if (skillMaxLevel + result > CommonSettings.MAX_INTERNALSKILL_LEVEL)
					{
						num = -2061866155;
						num26 = num;
					}
					else
					{
						num = -1633797944;
						num26 = num;
					}
					continue;
				}
				case 21u:
				{
					skillMaxLevel = ModData.GetSkillMaxLevel(array[num8]);
					result = 1;
					int num25;
					if (num8 + 1 <= array.Length - 1)
					{
						num = -1348066717;
						num25 = num;
					}
					else
					{
						num = -695508302;
						num25 = num;
					}
					continue;
				}
				case 27u:
				{
					array = _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(name, new char[1] { '#' });
					int num19;
					int num20;
					if (array.Length != 0)
					{
						num19 = -339854704;
						num20 = num19;
					}
					else
					{
						num19 = -984799681;
						num20 = num19;
					}
					num = num19 ^ ((int)num2 * -6954392);
					continue;
				}
				case 28u:
				{
					ModData.SkillMaxLevels[array[num8]] = num3;
					int num17;
					if (skillMaxLevel == num3)
					{
						num = -546980760;
						num17 = num;
					}
					else
					{
						num = -1969299334;
						num17 = num;
					}
					continue;
				}
				case 15u:
					result = 100;
					num = (int)((num2 * 4546117) ^ 0x637D4837);
					continue;
				case 1u:
					AchievementPanelUI.timespan = new TimeSpan(0L);
					num = (int)((num2 * 1012970793) ^ 0x2BE9D446);
					continue;
				case 31u:
				{
					num3 = skillMaxLevel;
					int num15;
					if (internalSkill == null)
					{
						num = -672113451;
						num15 = num;
					}
					else
					{
						num = -656342531;
						num15 = num;
					}
					continue;
				}
				case 13u:
					internalSkill = ResourceManager.Get<InternalSkill>(array[num8]);
					num = -683276031;
					continue;
				case 11u:
				{
					int num11;
					int num12;
					if (ResourceManager.Get<Skill>(array[num8]) != null)
					{
						num11 = -1019631800;
						num12 = num11;
					}
					else
					{
						num11 = -491993472;
						num12 = num11;
					}
					num = num11 ^ ((int)num2 * -1782151644);
					continue;
				}
				case 22u:
					num3 = skillMaxLevel + result;
					num = (int)((num2 * 216295946) ^ 0x6E137C3D);
					continue;
				case 10u:
					num3 = skillMaxLevel + result;
					num = ((int)num2 * -428318511) ^ 0x21D24720;
					continue;
				case 12u:
				{
					int num7;
					if (num3 <= 999)
					{
						num = -1643959842;
						num7 = num;
					}
					else
					{
						num = -2049887835;
						num7 = num;
					}
					continue;
				}
				case 30u:
				{
					int num4;
					int num5;
					if (internalSkill == null)
					{
						num4 = -588272017;
						num5 = num4;
					}
					else
					{
						num4 = -2128671480;
						num5 = num4;
					}
					num = num4 ^ ((int)num2 * -687424002);
					continue;
				}
				case 2u:
					num3 = 999;
					num = (int)(num2 * 1409832546) ^ -1874833202;
					continue;
				default:
					return flag;
				}
				break;
			}
		}
	}

	public void addTeamMember2(string roleName)
	{
		IEnumerator<Role> enumerator = ResourceManager.GetAll<Role>().GetEnumerator();
		try
		{
			Role role2 = default(Role);
			Role current = default(Role);
			Role role = default(Role);
			while (true)
			{
				int num;
				int num2;
				if (!_200C_202A_206C_202A_200E_206A_202B_206F_206A_202E_202E_200B_200D_206B_202C_200E_200D_202E_206F_202C_202B_206D_202A_202B_206D_200F_200C_206B_206D_200B_202D_202E_200F_206C_206C_206B_202E_206D_202D_206E_202E((IEnumerator)enumerator))
				{
					num = 1257302378;
					num2 = num;
				}
				else
				{
					num = 1281968179;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x78449F3)) % 15)
					{
					case 4u:
						num = 1281968179;
						continue;
					default:
						return;
					case 5u:
						role2 = ResourceManager.Get<Role>(current.Key);
						num = (int)((num3 * 950917519) ^ 0x6C2A86F7);
						continue;
					case 7u:
					{
						int num10;
						int num11;
						if (!_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(current.Name, roleName))
						{
							num10 = -1407987647;
							num11 = num10;
						}
						else
						{
							num10 = -12519448;
							num11 = num10;
						}
						num = num10 ^ (int)(num3 * 644545323);
						continue;
					}
					case 1u:
						role = role2.Clone();
						num = ((int)num3 * -168932078) ^ 0x51B44E70;
						continue;
					case 6u:
						break;
					case 10u:
					{
						current = enumerator.Current;
						int num18;
						if (current != null)
						{
							num = 942256877;
							num18 = num;
						}
						else
						{
							num = 432556107;
							num18 = num;
						}
						continue;
					}
					case 12u:
						Team.Add(role);
						AddTeamMemberPanel(role);
						num = (int)(num3 * 250785007) ^ -2138667925;
						continue;
					case 8u:
					{
						int num6;
						int num7;
						if (role2.Skills.Count > 0)
						{
							num6 = -1877632464;
							num7 = num6;
						}
						else
						{
							num6 = -238671101;
							num7 = num6;
						}
						num = num6 ^ (int)(num3 * 713121096);
						continue;
					}
					case 13u:
					{
						int num16;
						int num17;
						if (!addTeamMemberFromTemp(current.Key))
						{
							num16 = -1269922014;
							num17 = num16;
						}
						else
						{
							num16 = -450523102;
							num17 = num16;
						}
						num = num16 ^ ((int)num3 * -143043367);
						continue;
					}
					case 3u:
					{
						int num12;
						int num13;
						if (!InTeamOnly(current.Key))
						{
							num12 = -286038724;
							num13 = num12;
						}
						else
						{
							num12 = -1847866889;
							num13 = num12;
						}
						num = num12 ^ (int)(num3 * 126049250);
						continue;
					}
					case 0u:
					{
						int num19;
						int num20;
						if (role2 == null)
						{
							num19 = 1912643297;
							num20 = num19;
						}
						else
						{
							num19 = 16259793;
							num20 = num19;
						}
						num = num19 ^ ((int)num3 * -284414470);
						continue;
					}
					case 9u:
					{
						int num14;
						int num15;
						if (!addTeamMemberFromFollow(current.Key))
						{
							num14 = -1779072187;
							num15 = num14;
						}
						else
						{
							num14 = -1806390717;
							num15 = num14;
						}
						num = num14 ^ (int)(num3 * 1699163815);
						continue;
					}
					case 2u:
					{
						int num8;
						int num9;
						if (role2.InternalSkills.Count <= 0)
						{
							num8 = -343435597;
							num9 = num8;
						}
						else
						{
							num8 = -1372813878;
							num9 = num8;
						}
						num = num8 ^ ((int)num3 * -1604060785);
						continue;
					}
					case 14u:
					{
						int num4;
						int num5;
						if (role.EquippedInternalSkill == null)
						{
							num4 = -819403306;
							num5 = num4;
						}
						else
						{
							num4 = -1374498418;
							num5 = num4;
						}
						num = num4 ^ (int)(num3 * 15928953);
						continue;
					}
					case 11u:
						return;
					}
					break;
				}
			}
		}
		finally
		{
			if (enumerator != null)
			{
				while (true)
				{
					IL_0249:
					int num21 = 1722183295;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num21 ^ 0x78449F3)) % 3)
						{
						case 2u:
							break;
						default:
							goto end_IL_024e;
						case 1u:
							goto IL_026c;
						case 0u:
							goto end_IL_024e;
						}
						goto IL_0249;
						IL_026c:
						_206D_200E_206E_206E_206A_206B_206B_202E_206F_200F_202D_202D_200B_202E_206F_200B_202A_206B_200D_206B_206B_200C_200B_206B_200F_202C_202C_206F_206A_206F_206E_202B_206B_206C_202C_206C_200F_200B_200F_202E_202E((IDisposable)enumerator);
						num21 = (int)((num3 * 753759095) ^ 0x686DE250);
						continue;
						end_IL_024e:
						break;
					}
					break;
				}
			}
		}
	}

	public bool AdjustTeamRoleOrder(string name)
	{
		string[] array = _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(name, new char[1] { '#' });
		if (array.Length < 2)
		{
			goto IL_0018;
		}
		goto IL_0059;
		IL_0018:
		int num = -2028773049;
		goto IL_001d;
		IL_001d:
		Role role = default(Role);
		int num3 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1672261341)) % 6)
			{
			case 0u:
				break;
			case 1u:
				role = null;
				num = (int)(num2 * 70982500) ^ -936497684;
				continue;
			case 3u:
				goto IL_0059;
			case 2u:
				return false;
			case 4u:
				num3 = int.Parse(array[1]);
				num = ((int)num2 * -1738804571) ^ -1288836796;
				continue;
			default:
				goto IL_008f;
			}
			break;
		}
		goto IL_0018;
		IL_0059:
		string text = array[0];
		num = -1531837955;
		goto IL_001d;
		IL_008f:
		using (List<Role>.Enumerator enumerator = Team.GetEnumerator())
		{
			Role current = default(Role);
			while (true)
			{
				IL_00e4:
				int num4;
				int num5;
				if (enumerator.MoveNext())
				{
					num4 = -1367861296;
					num5 = num4;
				}
				else
				{
					num4 = -596499898;
					num5 = num4;
				}
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num4 ^ -1672261341)) % 7)
					{
					case 4u:
						num4 = -1367861296;
						continue;
					default:
						goto end_IL_00a3;
					case 6u:
						role = current;
						num4 = (int)(num2 * 2057588807) ^ -908380957;
						continue;
					case 3u:
						break;
					case 2u:
						goto end_IL_00a3;
					case 1u:
						current = enumerator.Current;
						num4 = -1638329919;
						continue;
					case 0u:
					{
						int num6;
						int num7;
						if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(current.Key, text))
						{
							num6 = -874387108;
							num7 = num6;
						}
						else
						{
							num6 = -1340896652;
							num7 = num6;
						}
						num4 = num6 ^ ((int)num2 * -372620224);
						continue;
					}
					case 5u:
						goto end_IL_00a3;
					}
					goto IL_00e4;
					continue;
					end_IL_00a3:
					break;
				}
				break;
			}
		}
		if (role != null)
		{
			while (true)
			{
				int num8 = -325430705;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num8 ^ -1672261341)) % 9)
					{
					case 6u:
						break;
					case 5u:
						return true;
					case 7u:
						Team.Remove(role);
						num8 = -10623411;
						continue;
					case 1u:
					{
						int num9;
						int num10;
						if (num3 <= Team.Count)
						{
							num9 = 214236575;
							num10 = num9;
						}
						else
						{
							num9 = 309971756;
							num10 = num9;
						}
						num8 = num9 ^ ((int)num2 * -1936349770);
						continue;
					}
					case 0u:
						num3 = 1;
						num8 = (int)((num2 * 875981995) ^ 0x792C2543);
						continue;
					case 8u:
						num3 = Team.Count;
						num8 = ((int)num2 * -1390891153) ^ 0x4EEA0EFD;
						continue;
					case 4u:
						Team.Insert(num3 - 1, role);
						SetTeamMemberPanelIndex(role, num3 - 1);
						num8 = ((int)num2 * -273466698) ^ 0x5C708B80;
						continue;
					case 3u:
						goto IL_0252;
					default:
						goto end_IL_0162;
					}
					break;
					IL_0252:
					int num11;
					if (num3 >= 1)
					{
						num8 = -1162755660;
						num11 = num8;
					}
					else
					{
						num8 = -331398714;
						num11 = num8;
					}
				}
				continue;
				end_IL_0162:
				break;
			}
		}
		return false;
	}

	public bool AdjustTeamRoleOrderByName(string name)
	{
		string[] array = _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(name, new char[1] { '#' });
		string text = default(string);
		int num8 = default(int);
		Role role = default(Role);
		Role current = default(Role);
		while (true)
		{
			int num = -1181206571;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -638419088)) % 5)
				{
				case 0u:
					break;
				case 4u:
				{
					int num12;
					int num13;
					if (array.Length >= 2)
					{
						num12 = -285645529;
						num13 = num12;
					}
					else
					{
						num12 = -1321851565;
						num13 = num12;
					}
					num = num12 ^ (int)(num2 * 1719401448);
					continue;
				}
				case 2u:
					text = array[0];
					num8 = int.Parse(array[1]);
					role = null;
					num = -1240879706;
					continue;
				case 3u:
					return false;
				default:
				{
					using (List<Role>.Enumerator enumerator = Team.GetEnumerator())
					{
						while (true)
						{
							IL_0113:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -2087539241;
								num4 = num3;
							}
							else
							{
								num3 = -1132992793;
								num4 = num3;
							}
							while (true)
							{
								switch ((num2 = (uint)(num3 ^ -638419088)) % 7)
								{
								case 2u:
									num3 = -2087539241;
									continue;
								default:
									goto end_IL_0099;
								case 4u:
									role = current;
									num3 = ((int)num2 * -2064452475) ^ -1483317470;
									continue;
								case 0u:
								{
									int num5;
									int num6;
									if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(current.Name, text))
									{
										num5 = 879859417;
										num6 = num5;
									}
									else
									{
										num5 = 983509030;
										num6 = num5;
									}
									num3 = num5 ^ ((int)num2 * -645463931);
									continue;
								}
								case 1u:
									current = enumerator.Current;
									num3 = -687645594;
									continue;
								case 5u:
									break;
								case 6u:
									goto end_IL_0099;
								case 3u:
									goto end_IL_0099;
								}
								goto IL_0113;
								continue;
								end_IL_0099:
								break;
							}
							break;
						}
					}
					if (role != null)
					{
						while (true)
						{
							int num7 = -1934851856;
							while (true)
							{
								switch ((num2 = (uint)(num7 ^ -638419088)) % 11)
								{
								case 7u:
									break;
								case 5u:
									num8 = 1;
									num7 = ((int)num2 * -1390113192) ^ -143243585;
									continue;
								case 1u:
									SetTeamMemberPanelIndex(role, num8 - 1);
									num7 = (int)(num2 * 342850078) ^ -20581111;
									continue;
								case 2u:
									goto IL_01ce;
								case 4u:
									Team.Insert(num8 - 1, role);
									num7 = ((int)num2 * -219218570) ^ 0x7E07593;
									continue;
								case 6u:
									num7 = (int)((num2 * 1955987264) ^ 0x6A97133F);
									continue;
								case 9u:
									return true;
								case 8u:
								{
									int num9;
									int num10;
									if (num8 <= Team.Count)
									{
										num9 = -765977494;
										num10 = num9;
									}
									else
									{
										num9 = -654617590;
										num10 = num9;
									}
									num7 = num9 ^ ((int)num2 * -920613814);
									continue;
								}
								case 3u:
									Team.Remove(role);
									num7 = -1346949676;
									continue;
								case 10u:
									num8 = Team.Count;
									num7 = ((int)num2 * -1078465996) ^ 0x44FE9DF5;
									continue;
								default:
									goto end_IL_015b;
								}
								break;
								IL_01ce:
								int num11;
								if (num8 >= 1)
								{
									num7 = -1852287617;
									num11 = num7;
								}
								else
								{
									num7 = -1780160744;
									num11 = num7;
								}
							}
							continue;
							end_IL_015b:
							break;
						}
					}
					return false;
				}
				}
				break;
			}
		}
	}

	public void AddTeamMemberPanel(string roleKey)
	{
		try
		{
			if (IsInited)
			{
				goto IL_0008;
			}
			goto IL_0059;
			IL_0008:
			int num = -1919805002;
			goto IL_000d;
			IL_000d:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -549352129)) % 5)
				{
				case 0u:
					break;
				default:
					return;
				case 3u:
				{
					int num3;
					int num4;
					if (_200B_202A_200D_202E_206D_202C_202B_202D_202A_206B_200F_206E_202A_200C_206D_200F_206B_206B_202D_200D_206C_202E_200E_202B_206E_206A_206E_200D_206F_202C_206C_202C_202B_206B_206A_206D_200C_200B_202D_200D_202E((Object)(object)mapUI, (Object)null))
					{
						num3 = -1010507875;
						num4 = num3;
					}
					else
					{
						num3 = -1669434813;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1792259209);
					continue;
				}
				case 1u:
					goto IL_0059;
				case 4u:
					mapUI.ShowTeamV2(roleKey);
					mapUI.ShowRoleV2(GetTeamRole(roleKey));
					num = ((int)num2 * -489354064) ^ 0x6869033D;
					continue;
				case 2u:
					return;
				}
				break;
			}
			goto IL_0008;
			IL_0059:
			isTeamPanelRefreshed = 0;
			num = -389015507;
			goto IL_000d;
		}
		catch
		{
			isTeamPanelRefreshed = 0;
		}
	}

	public void RemoveTeamMemberPanel(string roleKey)
	{
		Role teamRole = GetTeamRole(roleKey);
		while (true)
		{
			int num = -325762904;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -266654323)) % 9)
				{
				case 2u:
					break;
				case 0u:
					return;
				case 8u:
				{
					int num7;
					int num8;
					if (IsInited)
					{
						num7 = -722486157;
						num8 = num7;
					}
					else
					{
						num7 = -935102673;
						num8 = num7;
					}
					num = num7 ^ ((int)num2 * -1280810250);
					continue;
				}
				case 7u:
					isTeamPanelRefreshed = 0;
					num = (int)((num2 * 255754207) ^ 0x25E9A11);
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (teamRole == null)
					{
						num5 = 1598250391;
						num6 = num5;
					}
					else
					{
						num5 = 1931372606;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1803885118);
					continue;
				}
				case 4u:
					isTeamPanelRefreshed = 0;
					num = -1940647081;
					continue;
				case 3u:
				{
					int num9;
					if (!mapUI.TeamPanelObj.GetComponent<TeamPanelUI>().selectMenu.RemoveItem(teamRole))
					{
						num = -624558397;
						num9 = num;
					}
					else
					{
						num = -1550886685;
						num9 = num;
					}
					continue;
				}
				case 6u:
				{
					int num3;
					int num4;
					if (_200E_202B_202A_200D_202C_200D_200C_202D_206D_200C_206A_200C_206D_200B_200F_206A_200E_206F_202B_200F_206C_202E_206E_206A_206C_200C_202C_206C_206C_200D_202A_202A_200B_206A_200E_202A_206B_206F_202D_202E_202E((Object)(object)mapUI, (Object)null))
					{
						num3 = -1298119647;
						num4 = num3;
					}
					else
					{
						num3 = -1618319032;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -2092681092);
					continue;
				}
				default:
					mapUI.RolePanel.GetComponent<RolePanelUI>().removeTeam(teamRole);
					return;
				}
				break;
			}
		}
	}

	public bool leaveRole(string roleKey)
	{
		string[] array = _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(roleKey, new char[1] { '#' });
		int num3 = default(int);
		bool result = default(bool);
		while (true)
		{
			int num = 2062370893;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2EF4EDF3)) % 13)
				{
				case 4u:
					break;
				case 3u:
				{
					int num8;
					int num9;
					if (!InTeamOnly(array[num3]))
					{
						num8 = -1160210529;
						num9 = num8;
					}
					else
					{
						num8 = -1188783000;
						num9 = num8;
					}
					num = num8 ^ (int)(num2 * 1475717716);
					continue;
				}
				case 8u:
					return result;
				case 1u:
					result = false;
					num = (int)(num2 * 805783891) ^ -1902154774;
					continue;
				case 10u:
					num3++;
					num = 1448607281;
					continue;
				case 9u:
					num = ((int)num2 * -1800058979) ^ 0x7B947C12;
					continue;
				case 7u:
					num3 = 0;
					num = ((int)num2 * -1050036959) ^ -1902377944;
					continue;
				case 0u:
					RemoveTeamMemberPanel(array[num3]);
					num = ((int)num2 * -794263745) ^ -411070687;
					continue;
				case 5u:
					removeTeamMember(array[num3]);
					result = true;
					num = ((int)num2 * -431806851) ^ -1258083916;
					continue;
				case 6u:
				{
					int num7;
					if (!_206D_202D_206D_202A_200D_206B_206B_202D_202A_202D_206D_202C_206C_206A_200F_206E_202D_202C_202E_200F_206A_200B_206E_200C_206F_206B_202A_200D_206D_206D_206A_206E_206E_202C_206E_206C_202D_200C_200F_206F_202E(array[num3], ResourceStrings.ResStrings[0]))
					{
						num = 1294283495;
						num7 = num;
					}
					else
					{
						num = 934561685;
						num7 = num;
					}
					continue;
				}
				case 2u:
				{
					int num5;
					int num6;
					if (array.Length >= 1)
					{
						num5 = -682980689;
						num6 = num5;
					}
					else
					{
						num5 = -177031217;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -2004510744);
					continue;
				}
				case 12u:
				{
					int num4;
					if (num3 >= array.Length)
					{
						num = 133765877;
						num4 = num;
					}
					else
					{
						num = 914313988;
						num4 = num;
					}
					continue;
				}
				default:
					return false;
				}
				break;
			}
		}
	}

	public int fjtl()
	{
		int num = _200B_202A_202E_206F_206B_200E_202E_206A_206E_202B_202D_206B_202D_202C_206C_202A_200C_200C_206D_206F_202A_200D_200C_202E_202A_206C_206F_202C_200E_206C_202B_202D_202E_206F_200B_200D_202E_200C_202B_202C_202E(Team.Count, 20);
		int num4 = default(int);
		while (true)
		{
			int num2 = -889480163;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1516202536)) % 7)
				{
				case 0u:
					break;
				case 1u:
					num4 = 0;
					num2 = (int)(num3 * 736498496) ^ -944628087;
					continue;
				case 3u:
					num4++;
					num2 = -1312289079;
					continue;
				case 6u:
					return 30;
				case 4u:
				{
					int num6;
					if (num4 >= num)
					{
						num2 = -1323280857;
						num6 = num2;
					}
					else
					{
						num2 = -809759166;
						num6 = num2;
					}
					continue;
				}
				case 5u:
				{
					int num5;
					if (fjtl_bool(Team[num4]))
					{
						num2 = -224819459;
						num5 = num2;
					}
					else
					{
						num2 = -258157029;
						num5 = num2;
					}
					continue;
				}
				default:
					return 0;
				}
				break;
			}
		}
	}

	public bool fjtl_bool(Role role)
	{
		using (List<ItemInstance>.Enumerator enumerator = role.Equipment.GetEnumerator())
		{
			int num4 = default(int);
			string[] talents = default(string[]);
			while (true)
			{
				IL_004d:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 992931142;
					num2 = num;
				}
				else
				{
					num = 1129476837;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x335F73DE)) % 9)
					{
					case 2u:
						num = 1129476837;
						continue;
					default:
						goto end_IL_0013;
					case 7u:
						break;
					case 1u:
						num4++;
						num = 1113338986;
						continue;
					case 0u:
						num = (int)(num3 * 241809746) ^ -1124525040;
						continue;
					case 6u:
					{
						int num6;
						if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(talents[num4], ResourceStrings.ResStrings[313]))
						{
							num = 285568702;
							num6 = num;
						}
						else
						{
							num = 359134500;
							num6 = num;
						}
						continue;
					}
					case 4u:
					{
						int num5;
						if (num4 >= talents.Length)
						{
							num = 2011517654;
							num5 = num;
						}
						else
						{
							num = 1280012551;
							num5 = num;
						}
						continue;
					}
					case 3u:
						return true;
					case 5u:
						talents = enumerator.Current.Talents;
						num4 = 0;
						num = 1020440747;
						continue;
					case 8u:
						goto end_IL_0013;
					}
					goto IL_004d;
					continue;
					end_IL_0013:
					break;
				}
				break;
			}
		}
		if (role.EquippedTitle != null)
		{
			IEnumerator<string> enumerator2 = role.EquippedTitle.Talents.GetEnumerator();
			try
			{
				while (true)
				{
					IL_0184:
					int num7;
					int num8;
					if (_200C_202A_206C_202A_200E_206A_202B_206F_206A_202E_202E_200B_200D_206B_202C_200E_200D_202E_206F_202C_202B_206D_202A_202B_206D_200F_200C_206B_206D_200B_202D_202E_200F_206C_206C_206B_202E_206D_202D_206E_202E((IEnumerator)enumerator2))
					{
						num7 = 1590325808;
						num8 = num7;
					}
					else
					{
						num7 = 1162103379;
						num8 = num7;
					}
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num7 ^ 0x335F73DE)) % 5)
						{
						case 0u:
							num7 = 1590325808;
							continue;
						default:
							goto end_IL_0130;
						case 2u:
						{
							int num9;
							if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(enumerator2.Current, ResourceStrings.ResStrings[313]))
							{
								num7 = 17657565;
								num9 = num7;
							}
							else
							{
								num7 = 5698597;
								num9 = num7;
							}
							continue;
						}
						case 1u:
							break;
						case 4u:
							return true;
						case 3u:
							goto end_IL_0130;
						}
						goto IL_0184;
						continue;
						end_IL_0130:
						break;
					}
					break;
				}
			}
			finally
			{
				if (enumerator2 != null)
				{
					while (true)
					{
						IL_01bb:
						int num10 = 1379826036;
						while (true)
						{
							uint num3;
							switch ((num3 = (uint)(num10 ^ 0x335F73DE)) % 3)
							{
							case 0u:
								break;
							default:
								goto end_IL_01c0;
							case 2u:
								goto IL_01de;
							case 1u:
								goto end_IL_01c0;
							}
							goto IL_01bb;
							IL_01de:
							_206D_200E_206E_206E_206A_206B_206B_202E_206F_200F_202D_202D_200B_202E_206F_200B_202A_206B_200D_206B_206B_200C_200B_206B_200F_202C_202C_206F_206A_206F_206E_202B_206B_206C_202C_206C_200F_200B_200F_202E_202E((IDisposable)enumerator2);
							num10 = (int)(num3 * 1902217364) ^ -670453908;
							continue;
							end_IL_01c0:
							break;
						}
						break;
					}
				}
			}
		}
		return false;
	}

	private string GetSaveInformation()
	{
		string text = _200C_200E_206C_200D_200F_202B_206B_202A_206E_202D_202E_206D_202A_202E_206D_206B_200D_202A_200D_202B_200B_206E_206B_206F_202D_206E_206F_206D_206C_202A_206C_202A_200E_200B_200E_206F_206C_200E_202E_202A_202E(Team[0].Head, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2828931079u), Team[0].Name, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2828931079u));
		while (true)
		{
			int num = -1303068175;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1161497369)) % 8)
				{
				case 3u:
					break;
				case 6u:
				{
					int num4;
					int num5;
					if (!KeyValues.ContainsKey(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(802506112u)))
					{
						num4 = 581771215;
						num5 = num4;
					}
					else
					{
						num4 = 571087566;
						num5 = num4;
					}
					num = num4 ^ (int)(num2 * 2086485584);
					continue;
				}
				case 2u:
					text = _206A_200C_200F_206E_202E_206D_206E_200E_202D_200E_202A_200F_200E_200B_202A_206B_200B_202A_202E_206A_202B_206C_200F_202C_202D_200F_202D_206E_206D_202A_202A_200C_200C_206D_200B_202B_202B_200C_200E_200C_202E(text, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2728845520u));
					num = (int)((num2 * 902923757) ^ 0x34C5F0D0);
					continue;
				case 0u:
					text = _200C_200E_206C_200D_200F_202B_206B_202A_206E_202D_202E_206D_202A_202E_206D_206B_200D_202A_200D_202B_200B_206E_206B_206F_202D_206E_206F_206D_206C_202A_206C_202A_200E_200B_200E_206F_206C_200E_202E_202A_202E(text, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3957754747u), CurrentBigMap, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1583738914u));
					num = -1848493696;
					continue;
				case 4u:
					text = _206A_206B_202D_202E_200E_206D_202D_202E_206D_200E_202A_202B_206D_200F_202D_206E_202E_200D_202E_202E_206F_200F_200F_200F_206B_202E_202C_200F_202B_202C_200B_206D_202E_200E_200C_202C_200F_202E_202B_206D_202E(text, GameMode, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2828931079u));
					num = -914693126;
					continue;
				case 7u:
				{
					int num3;
					if (AutoSaveOnly)
					{
						num = -55980427;
						num3 = num;
					}
					else
					{
						num = -1054485053;
						num3 = num;
					}
					continue;
				}
				case 1u:
					text = _200D_200F_206D_200B_200E_206C_200B_206B_206E_202A_206D_200F_200C_202E_206D_202C_200C_202B_206D_206C_200E_200B_200B_202D_202B_206E_206F_202D_206F_202D_206C_206C_206D_200E_202A_202B_202B_200C_200B_202E_202E(new string[5]
					{
						text,
						KeyValues[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2529305489u)],
						global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1541154258u),
						CurrentBigMap,
						global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2471904275u)
					});
					num = (int)(num2 * 18813540) ^ -1556530940;
					continue;
				default:
					return text + RoundString() + global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2057560981u) + CurrentNick + global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1541154258u) + Team.Count + global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2057560981u) + Tools.GetTimeStamp(DateTime.Now);
				}
				break;
			}
		}
	}

	public void addSkillLevel(string name)
	{
		string[] array = _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(name, new char[1] { '#' });
		int num12 = default(int);
		int num25 = default(int);
		string text = default(string);
		string text2 = default(string);
		SkillInstance current2 = default(SkillInstance);
		int num7 = default(int);
		InternalSkillInstance current3 = default(InternalSkillInstance);
		int num19 = default(int);
		while (true)
		{
			int num = 1523854036;
			while (true)
			{
				int num27;
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5C8DF09F)) % 12)
				{
				case 0u:
					break;
				case 4u:
					num12 = -100;
					num = (int)((num2 * 938731360) ^ 0x4D572CE5);
					continue;
				case 6u:
					num12 = int.Parse(array[num25 + 1]);
					num = (int)(num2 * 1307980309) ^ -889633216;
					continue;
				case 11u:
					num12 = 100;
					num = ((int)num2 * -954607524) ^ -1577593535;
					continue;
				case 2u:
					num25 = 1;
					goto IL_0604;
				case 3u:
					text = array[0];
					num = 1237163281;
					continue;
				case 8u:
				{
					text2 = array[num25];
					num12 = 0;
					int num31;
					if (num25 + 1 >= array.Length)
					{
						num = 1913567190;
						num31 = num;
					}
					else
					{
						num = 2039406113;
						num31 = num;
					}
					continue;
				}
				case 7u:
				{
					int num29;
					int num30;
					if (array.Length < 3)
					{
						num29 = -568141081;
						num30 = num29;
					}
					else
					{
						num29 = -1456614647;
						num30 = num29;
					}
					num = num29 ^ (int)(num2 * 14751891);
					continue;
				}
				case 9u:
				{
					int num28;
					if (num12 >= -100)
					{
						num = 2053468326;
						num28 = num;
					}
					else
					{
						num = 1280513939;
						num28 = num;
					}
					continue;
				}
				case 1u:
					return;
				case 5u:
				{
					int num26;
					if (num12 <= 100)
					{
						num = 388060261;
						num26 = num;
					}
					else
					{
						num = 1717110784;
						num26 = num;
					}
					continue;
				}
				default:
					{
						using (List<Role>.Enumerator enumerator = Team.GetEnumerator())
						{
							while (true)
							{
								IL_05ba:
								if (enumerator.MoveNext())
								{
									Role current;
									bool flag;
									while (true)
									{
										current = enumerator.Current;
										flag = false;
										int num3;
										int num4;
										if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(text, ResourceStrings.ResStrings[118]))
										{
											num3 = 604006212;
											num4 = num3;
										}
										else
										{
											num3 = 2125076346;
											num4 = num3;
										}
										while (true)
										{
											switch ((num2 = (uint)(num3 ^ 0x5C8DF09F)) % 4)
											{
											case 0u:
												num3 = 1185908717;
												continue;
											case 2u:
												break;
											case 1u:
												goto IL_01c4;
											default:
												goto end_IL_0193;
											}
											break;
											IL_01c4:
											if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(text, current.Key))
											{
												num3 = (int)((num2 * 528014086) ^ 0x7AA8311A);
												continue;
											}
											goto IL_05ba;
										}
										continue;
										end_IL_0193:
										break;
									}
									using (List<SkillInstance>.Enumerator enumerator2 = current.Skills.GetEnumerator())
									{
										while (true)
										{
											IL_02c2:
											int num5;
											int num6;
											if (enumerator2.MoveNext())
											{
												num5 = 1523393263;
												num6 = num5;
											}
											else
											{
												num5 = 70961170;
												num6 = num5;
											}
											while (true)
											{
												switch ((num2 = (uint)(num5 ^ 0x5C8DF09F)) % 14)
												{
												case 4u:
													num5 = 1523393263;
													continue;
												default:
													goto end_IL_01fe;
												case 5u:
													flag = true;
													current.InitBind();
													num5 = ((int)num2 * -227617067) ^ -269298277;
													continue;
												case 1u:
													current2.level = num7;
													num5 = 847355156;
													continue;
												case 3u:
													RefreshTeamMemberPanel(current, refreshImage: false, refreshText: true);
													num5 = (int)(num2 * 177809502) ^ -1790248217;
													continue;
												case 11u:
												{
													int num10;
													int num11;
													if (current2.level == -(int)current2.level2)
													{
														num10 = 2089385699;
														num11 = num10;
													}
													else
													{
														num10 = 1276996533;
														num11 = num10;
													}
													num5 = num10 ^ ((int)num2 * -1708190168);
													continue;
												}
												case 12u:
													break;
												case 8u:
													current2 = enumerator2.Current;
													num5 = 1926779488;
													continue;
												case 13u:
												{
													int num13;
													int num14;
													if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(current2.Name, text2))
													{
														num13 = 1896444351;
														num14 = num13;
													}
													else
													{
														num13 = 761965996;
														num14 = num13;
													}
													num5 = num13 ^ ((int)num2 * -1899787697);
													continue;
												}
												case 10u:
													num7 = current2.level + num12;
													num5 = ((int)num2 * -67336018) ^ 0xE5EB38B;
													continue;
												case 9u:
													current2.level2 = 0f - (float)num7;
													num5 = ((int)num2 * -1837975868) ^ 0x7C6E45A0;
													continue;
												case 2u:
												{
													num7 = _200B_202A_202E_206F_206B_200E_202E_206A_206E_202B_202D_206B_202D_202C_206C_202A_200C_200C_206D_206F_202A_200D_200C_202E_202A_206C_206F_202C_200E_206C_202B_202D_202E_206F_200B_200D_202E_200C_202B_202C_202E(num7, current.MAX_SKILL_LEVEL);
													int num8;
													int num9;
													if (num7 < 1)
													{
														num8 = 1561068895;
														num9 = num8;
													}
													else
													{
														num8 = 932872756;
														num9 = num8;
													}
													num5 = num8 ^ (int)(num2 * 2063438572);
													continue;
												}
												case 0u:
													num7 = 1;
													num5 = ((int)num2 * -1010691326) ^ -582418300;
													continue;
												case 6u:
													goto end_IL_01fe;
												case 7u:
													goto end_IL_01fe;
												}
												goto IL_02c2;
												continue;
												end_IL_01fe:
												break;
											}
											break;
										}
									}
									if (!flag)
									{
										using List<InternalSkillInstance>.Enumerator enumerator3 = current.InternalSkills.GetEnumerator();
										while (true)
										{
											IL_04d1:
											int num15;
											int num16;
											if (enumerator3.MoveNext())
											{
												num15 = 2073768703;
												num16 = num15;
											}
											else
											{
												num15 = 1925397037;
												num16 = num15;
											}
											while (true)
											{
												switch ((num2 = (uint)(num15 ^ 0x5C8DF09F)) % 11)
												{
												case 5u:
													num15 = 2073768703;
													continue;
												default:
													goto end_IL_03e7;
												case 4u:
													current3 = enumerator3.Current;
													num15 = 1328452777;
													continue;
												case 8u:
													num19 = current3.Level + num12;
													num19 = _200B_202A_202E_206F_206B_200E_202E_206A_206E_202B_202D_206B_202D_202C_206C_202A_200C_200C_206D_206F_202A_200D_200C_202E_202A_206C_206F_202C_200E_206C_202B_202D_202E_206F_200B_200D_202E_200C_202B_202C_202E(num19, current.MAX_INTERNALSKILL_LEVEL);
													num15 = (int)((num2 * 1579905499) ^ 0x4CE9D22D);
													continue;
												case 9u:
													current3.level = num19;
													num15 = 1810737305;
													continue;
												case 1u:
													current3.level2 = 0f - (float)num19;
													flag = true;
													current.InitBind();
													RefreshTeamMemberPanel(current, refreshImage: false, refreshText: true);
													goto end_IL_03e7;
												case 10u:
												{
													int num20;
													int num21;
													if (num19 >= 1)
													{
														num20 = -1161645633;
														num21 = num20;
													}
													else
													{
														num20 = -202794842;
														num21 = num20;
													}
													num15 = num20 ^ (int)(num2 * 1933462063);
													continue;
												}
												case 7u:
													break;
												case 3u:
													num19 = 1;
													num15 = ((int)num2 * -139812562) ^ 0x471497B0;
													continue;
												case 6u:
												{
													int num22;
													int num23;
													if (current3.level == -(int)current3.level2)
													{
														num22 = 1089855594;
														num23 = num22;
													}
													else
													{
														num22 = 1025636040;
														num23 = num22;
													}
													num15 = num22 ^ (int)(num2 * 135159420);
													continue;
												}
												case 2u:
												{
													int num17;
													int num18;
													if (!_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(current3.Name, text2))
													{
														num17 = -1422667676;
														num18 = num17;
													}
													else
													{
														num17 = -1409746527;
														num18 = num17;
													}
													num15 = num17 ^ (int)(num2 * 75831758);
													continue;
												}
												case 0u:
													goto end_IL_03e7;
												}
												goto IL_04d1;
												continue;
												end_IL_03e7:
												break;
											}
											break;
										}
									}
									if (!(_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(text, current.Key) && flag))
									{
										continue;
									}
									goto IL_0581;
								}
								int num24 = 1150332059;
								goto IL_0586;
								IL_0586:
								switch ((num2 = (uint)(num24 ^ 0x5C8DF09F)) % 4)
								{
								case 3u:
									break;
								default:
									goto end_IL_05ba;
								case 2u:
									goto end_IL_05ba;
								case 1u:
									continue;
								case 0u:
									goto end_IL_05ba;
								}
								goto IL_0581;
								IL_0581:
								num24 = 596868429;
								goto IL_0586;
								continue;
								end_IL_05ba:
								break;
							}
						}
						num25 += 2;
						goto IL_05e1;
					}
					IL_0604:
					if (num25 < array.Length - 1)
					{
						goto case 8u;
					}
					num27 = 1099319258;
					goto IL_05e6;
					IL_05e6:
					switch ((num2 = (uint)(num27 ^ 0x5C8DF09F)) % 3)
					{
					case 0u:
						break;
					default:
						return;
					case 2u:
						goto IL_0604;
					case 1u:
						return;
					}
					goto IL_05e1;
					IL_05e1:
					num27 = 411702943;
					goto IL_05e6;
				}
				break;
			}
		}
	}

	public string RoundString()
	{
		return getDataOrInit(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(355178724u), global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(727785707u));
	}

	public Role GetTempRole(string roleKey)
	{
		using (List<Role>.Enumerator enumerator = Temp.GetEnumerator())
		{
			Role current = default(Role);
			Role result = default(Role);
			while (true)
			{
				IL_0040:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 1504810425;
					num2 = num;
				}
				else
				{
					num = 1832772044;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x213CF545)) % 7)
					{
					case 0u:
						num = 1832772044;
						continue;
					default:
						goto end_IL_0013;
					case 3u:
						break;
					case 4u:
					{
						int num4;
						int num5;
						if (_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current.Key, roleKey))
						{
							num4 = -752863338;
							num5 = num4;
						}
						else
						{
							num4 = -1116231924;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -845969004);
						continue;
					}
					case 6u:
						result = current;
						num = (int)((num3 * 460705837) ^ 0x79164CC9);
						continue;
					case 1u:
						current = enumerator.Current;
						num = 834227998;
						continue;
					case 2u:
						goto end_IL_0013;
					case 5u:
						return result;
					}
					goto IL_0040;
					continue;
					end_IL_0013:
					break;
				}
				break;
			}
		}
		return null;
	}

	public int summoning(string key, int x, int y, int team = 1, int face = 1, string say = null, string difficulty = null)
	{
		return battleFieldUI.summoningMagic(key, x, y, team, face, say, difficulty);
	}

	public string GameModeChineseWithColor()
	{
		if (AutoSaveOnly)
		{
			goto IL_0008;
		}
		goto IL_0084;
		IL_0008:
		int num = -1020503706;
		goto IL_000d;
		IL_000d:
		string gameMode = default(string);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -60979458)) % 10)
			{
			case 0u:
				break;
			case 5u:
				num = (int)((num2 * 1982040507) ^ 0x4B74064D);
				continue;
			case 3u:
			{
				int num5;
				int num6;
				if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(gameMode, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(574844096u)))
				{
					num5 = -1432479943;
					num6 = num5;
				}
				else
				{
					num5 = -1824131216;
					num6 = num5;
				}
				num = num5 ^ ((int)num2 * -1763541907);
				continue;
			}
			case 9u:
				goto IL_0084;
			case 2u:
				return global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(374457202u);
			case 6u:
				return global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1133669285u);
			case 1u:
				return global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4035366309u);
			case 7u:
			{
				int num3;
				int num4;
				if (!_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(gameMode, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2038653673u)))
				{
					num3 = 100980014;
					num4 = num3;
				}
				else
				{
					num3 = 1466686466;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 1931502137);
				continue;
			}
			case 8u:
				return global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(148841851u);
			default:
				return global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(146864838u);
			}
			break;
		}
		goto IL_0008;
		IL_0084:
		gameMode = GameMode;
		int num7;
		if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(gameMode, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2176767917u)))
		{
			num = -1209489414;
			num7 = num;
		}
		else
		{
			num = -1112825803;
			num7 = num;
		}
		goto IL_000d;
	}

	public bool InTeamOnly(string roleKey)
	{
		using (List<Role>.Enumerator enumerator = Team.GetEnumerator())
		{
			bool result = default(bool);
			while (true)
			{
				IL_003c:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 777575663;
					num2 = num;
				}
				else
				{
					num = 186421390;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x3C13D49A)) % 6)
					{
					case 0u:
						num = 777575663;
						continue;
					default:
						goto end_IL_0013;
					case 3u:
						break;
					case 4u:
						result = true;
						num = ((int)num3 * -1492514693) ^ -2027430877;
						continue;
					case 5u:
					{
						int num4;
						if (!_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(enumerator.Current.Key, roleKey))
						{
							num = 1223067387;
							num4 = num;
						}
						else
						{
							num = 435200242;
							num4 = num;
						}
						continue;
					}
					case 2u:
						goto end_IL_0013;
					case 1u:
						return result;
					}
					goto IL_003c;
					continue;
					end_IL_0013:
					break;
				}
				break;
			}
		}
		return false;
	}

	public bool NameInTemp(string roleName)
	{
		using (List<Role>.Enumerator enumerator = Temp.GetEnumerator())
		{
			while (true)
			{
				IL_0038:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -1003943509;
					num2 = num;
				}
				else
				{
					num = -1143307910;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -1918657332)) % 5)
					{
					case 0u:
						num = -1003943509;
						continue;
					default:
						goto end_IL_0013;
					case 4u:
						break;
					case 2u:
						return true;
					case 3u:
					{
						int num4;
						if (_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(enumerator.Current.Name, roleName))
						{
							num = -1165510176;
							num4 = num;
						}
						else
						{
							num = -1833983654;
							num4 = num;
						}
						continue;
					}
					case 1u:
						goto end_IL_0013;
					}
					goto IL_0038;
					continue;
					end_IL_0013:
					break;
				}
				break;
			}
		}
		return false;
	}

	public void AddTeamMemberPanel(Role role)
	{
		try
		{
			if (role != null)
			{
				goto IL_0006;
			}
			goto IL_00a1;
			IL_0006:
			int num = -1350113283;
			goto IL_000b;
			IL_000b:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -249891669)) % 7)
				{
				case 6u:
					break;
				default:
					return;
				case 1u:
				{
					int num5;
					int num6;
					if (!IsInited)
					{
						num5 = -1299462469;
						num6 = num5;
					}
					else
					{
						num5 = -416544845;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -2039826738);
					continue;
				}
				case 2u:
				{
					int num3;
					int num4;
					if (_200B_202A_200D_202E_206D_202C_202B_202D_202A_206B_200F_206E_202A_200C_206D_200F_206B_206B_202D_200D_206C_202E_200E_202B_206E_206A_206E_200D_206F_202C_206C_202C_202B_206B_206A_206D_200C_200B_202D_200D_202E((Object)(object)mapUI, (Object)null))
					{
						num3 = 156489263;
						num4 = num3;
					}
					else
					{
						num3 = 164192759;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 874228762);
					continue;
				}
				case 3u:
					mapUI.ShowRoleV2(role);
					num = ((int)num2 * -1834428469) ^ -1010816106;
					continue;
				case 5u:
					goto IL_00a1;
				case 4u:
					mapUI.ShowTeamV2(role);
					num = (int)((num2 * 1294327109) ^ 0x3E94B2E);
					continue;
				case 0u:
					return;
				}
				break;
			}
			goto IL_0006;
			IL_00a1:
			isTeamPanelRefreshed = 0;
			num = -782920747;
			goto IL_000b;
		}
		catch
		{
			isTeamPanelRefreshed = 0;
		}
	}

	public Role GetRole(string roleKey)
	{
		Role result = default(Role);
		using (List<Role>.Enumerator enumerator = Temp.GetEnumerator())
		{
			Role current = default(Role);
			while (true)
			{
				IL_003d:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -1284596575;
					num2 = num;
				}
				else
				{
					num = -258179740;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -1238859675)) % 6)
					{
					case 0u:
						num = -258179740;
						continue;
					default:
						goto end_IL_0013;
					case 5u:
						break;
					case 4u:
						result = current;
						goto IL_024a;
					case 1u:
					{
						int num4;
						int num5;
						if (!_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current.Key, roleKey))
						{
							num4 = -1193258380;
							num5 = num4;
						}
						else
						{
							num4 = -956386513;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -1266903278);
						continue;
					}
					case 3u:
						current = enumerator.Current;
						num = -90700194;
						continue;
					case 2u:
						goto end_IL_0013;
					}
					goto IL_003d;
					continue;
					end_IL_0013:
					break;
				}
				break;
			}
		}
		using (List<Role>.Enumerator enumerator = Follow.GetEnumerator())
		{
			Role current2 = default(Role);
			while (true)
			{
				IL_0139:
				int num6;
				int num7;
				if (enumerator.MoveNext())
				{
					num6 = -1879790808;
					num7 = num6;
				}
				else
				{
					num6 = -1967538844;
					num7 = num6;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num6 ^ -1238859675)) % 7)
					{
					case 2u:
						num6 = -1879790808;
						continue;
					default:
						goto end_IL_00ce;
					case 6u:
						result = current2;
						num6 = (int)((num3 * 1737931333) ^ 0x4D3965AA);
						continue;
					case 3u:
					{
						int num8;
						int num9;
						if (!_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current2.Key, roleKey))
						{
							num8 = 1618205689;
							num9 = num8;
						}
						else
						{
							num8 = 235925951;
							num9 = num8;
						}
						num6 = num8 ^ ((int)num3 * -664158760);
						continue;
					}
					case 1u:
						break;
					case 4u:
						current2 = enumerator.Current;
						num6 = -749842437;
						continue;
					case 0u:
						goto end_IL_00ce;
					case 5u:
						goto IL_024a;
					}
					goto IL_0139;
					continue;
					end_IL_00ce:
					break;
				}
				break;
			}
		}
		using (List<Role>.Enumerator enumerator = Team.GetEnumerator())
		{
			Role current3 = default(Role);
			while (true)
			{
				IL_01e2:
				int num10;
				int num11;
				if (!enumerator.MoveNext())
				{
					num10 = -1102221292;
					num11 = num10;
				}
				else
				{
					num10 = -1067781193;
					num11 = num10;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num10 ^ -1238859675)) % 6)
					{
					case 4u:
						num10 = -1067781193;
						continue;
					default:
						goto end_IL_01a3;
					case 1u:
						result = current3;
						goto IL_024a;
					case 0u:
						break;
					case 2u:
						current3 = enumerator.Current;
						num10 = -498250422;
						continue;
					case 5u:
					{
						int num12;
						int num13;
						if (!_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current3.Key, roleKey))
						{
							num12 = -972232283;
							num13 = num12;
						}
						else
						{
							num12 = -1542078522;
							num13 = num12;
						}
						num10 = num12 ^ (int)(num3 * 1948177816);
						continue;
					}
					case 3u:
						goto end_IL_01a3;
					}
					goto IL_01e2;
					continue;
					end_IL_01a3:
					break;
				}
				break;
			}
		}
		return null;
		IL_024a:
		return result;
	}

	public int GetItemCount(string name)
	{
		using (Dictionary<ItemInstance, int>.Enumerator enumerator = Items.GetEnumerator())
		{
			KeyValuePair<ItemInstance, int> current = default(KeyValuePair<ItemInstance, int>);
			int result = default(int);
			while (true)
			{
				IL_0043:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 1383368987;
					num2 = num;
				}
				else
				{
					num = 1372885804;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0xCB7AA5C)) % 7)
					{
					case 3u:
						num = 1383368987;
						continue;
					default:
						goto end_IL_0013;
					case 6u:
						break;
					case 5u:
					{
						int num4;
						int num5;
						if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(current.Key.Name, name))
						{
							num4 = -1405861908;
							num5 = num4;
						}
						else
						{
							num4 = -1723407116;
							num5 = num4;
						}
						num = num4 ^ (int)(num3 * 161639980);
						continue;
					}
					case 2u:
						current = enumerator.Current;
						num = 1477735088;
						continue;
					case 0u:
						result = num_decode(current.Value);
						num = (int)((num3 * 855350868) ^ 0x2E37AF5A);
						continue;
					case 1u:
						goto end_IL_0013;
					case 4u:
						return result;
					}
					goto IL_0043;
					continue;
					end_IL_0013:
					break;
				}
				break;
			}
		}
		return 0;
	}

	public int getHaoganLua(string roleKey = "女主")
	{
		if (_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(roleKey))
		{
			goto IL_000b;
		}
		goto IL_008f;
		IL_000b:
		int num = 348310540;
		goto IL_0010;
		IL_0010:
		string key = default(string);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x75A8ACEE)) % 8)
			{
			case 7u:
				break;
			case 5u:
				return 0;
			case 0u:
				return int.Parse(KeyValues[key]);
			case 4u:
				goto IL_0076;
			case 1u:
				goto IL_008f;
			case 3u:
			{
				int num3;
				int num4;
				if (KeyValues.ContainsKey(key))
				{
					num3 = -420133835;
					num4 = num3;
				}
				else
				{
					num3 = -1614949271;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -69972279);
				continue;
			}
			case 2u:
				roleKey = ResourceStrings.ResStrings[9];
				num = ((int)num2 * -1569578776) ^ -1029676417;
				continue;
			default:
				return 50;
			}
			break;
			IL_0076:
			int num5;
			if (CommonSettings.MOD_KEY() == 2)
			{
				num = 507843475;
				num5 = num;
			}
			else
			{
				num = 527737672;
				num5 = num;
			}
		}
		goto IL_000b;
		IL_008f:
		key = _206A_200C_200F_206E_202E_206D_206E_200E_202D_200E_202A_200F_200E_200B_202A_206B_200B_202A_202E_206A_202B_206C_200F_202C_202D_200F_202D_206E_206D_202A_202A_200C_200C_206D_200B_202B_202B_200C_200E_200C_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2543027892u), roleKey);
		num = 888840725;
		goto IL_0010;
	}

	public string GetManualTempString()
	{
		return _200D_206D_206B_206A_206A_202E_206E_206A_202A_200F_202E_206D_200B_206E_206A_200C_200B_206F_200E_202D_200E_200C_200E_202E_202B_206B_206F_206C_202E_206B_200C_206D_206C_200D_200B_202A_206C_206B_200B_206D_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2828931079u), _200F_206F_206E_202D_202E_206B_206D_206A_202B_202B_206F_206C_200F_200D_202B_200E_200B_202C_206D_200C_200D_202B_206A_202B_202A_202A_200F_202D_200C_206E_206C_200F_206D_202B_202D_202C_206E_202D_202B_206F_202E.ToArray());
	}

	public bool SetManualTempList(string templist)
	{
		_200F_206F_206E_202D_202E_206B_206D_206A_202B_202B_206F_206C_200F_200D_202B_200E_200B_202C_206D_200C_200D_202B_206A_202B_202A_202A_200F_202D_200C_206E_206C_200F_206D_202B_202D_202C_206E_202D_202B_206F_202E.Clear();
		string[] array = default(string[]);
		int num3 = default(int);
		string text = default(string);
		while (true)
		{
			int num = 1894009967;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4CA85B31)) % 9)
				{
				case 0u:
					break;
				case 4u:
					array = _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(templist, new char[1] { '#' });
					num = ((int)num2 * -1945820416) ^ 0x23CF70B5;
					continue;
				case 3u:
				{
					int num6;
					if (num3 >= array.Length)
					{
						num = 1089209537;
						num6 = num;
					}
					else
					{
						num = 1414054497;
						num6 = num;
					}
					continue;
				}
				case 2u:
					num3 = 0;
					num = (int)(num2 * 1163995988) ^ -106899703;
					continue;
				case 6u:
					_200F_206F_206E_202D_202E_206B_206D_206A_202B_202B_206F_206C_200F_200D_202B_200E_200B_202C_206D_200C_200D_202B_206A_202B_202A_202A_200F_202D_200C_206E_206C_200F_206D_202B_202D_202C_206E_202D_202B_206F_202E.Add(text);
					num = (int)((num2 * 152670916) ^ 0x38B9FB0A);
					continue;
				case 8u:
				{
					int num4;
					int num5;
					if (_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(text))
					{
						num4 = 18488630;
						num5 = num4;
					}
					else
					{
						num4 = 1421760222;
						num5 = num4;
					}
					num = num4 ^ ((int)num2 * -1320147004);
					continue;
				}
				case 5u:
					num3++;
					num = 1657060441;
					continue;
				case 7u:
					text = array[num3];
					num = 10730945;
					continue;
				default:
					return true;
				}
				break;
			}
		}
	}

	public bool AddManualTemp(string key)
	{
		if (!_200F_206F_206E_202D_202E_206B_206D_206A_202B_202B_206F_206C_200F_200D_202B_200E_200B_202C_206D_200C_200D_202B_206A_202B_202A_202A_200F_202D_200C_206E_206C_200F_206D_202B_202D_202C_206E_202D_202B_206F_202E.Contains(key))
		{
			while (true)
			{
				int num = -1317750975;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1080597237)) % 4)
					{
					case 0u:
						break;
					case 2u:
						_200F_206F_206E_202D_202E_206B_206D_206A_202B_202B_206F_206C_200F_200D_202B_200E_200B_202C_206D_200C_200D_202B_206A_202B_202A_202A_200F_202D_200C_206E_206C_200F_206D_202B_202D_202C_206E_202D_202B_206F_202E.Add(key);
						num = ((int)num2 * -511708559) ^ -177885534;
						continue;
					case 3u:
						KeyValues[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1583285558u)] = GetManualTempString();
						return true;
					default:
						goto end_IL_000e;
					}
					break;
				}
				continue;
				end_IL_000e:
				break;
			}
		}
		return false;
	}

	public bool RemoveManualTemp(string key)
	{
		if (_200F_206F_206E_202D_202E_206B_206D_206A_202B_202B_206F_206C_200F_200D_202B_200E_200B_202C_206D_200C_200D_202B_206A_202B_202A_202A_200F_202D_200C_206E_206C_200F_206D_202B_202D_202C_206E_202D_202B_206F_202E.Contains(key))
		{
			while (true)
			{
				int num = 272964507;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x186568E8)) % 4)
					{
					case 0u:
						break;
					case 3u:
						_200F_206F_206E_202D_202E_206B_206D_206A_202B_202B_206F_206C_200F_200D_202B_200E_200B_202C_206D_200C_200D_202B_206A_202B_202A_202A_200F_202D_200C_206E_206C_200F_206D_202B_202D_202C_206E_202D_202B_206F_202E.Remove(key);
						num = (int)((num2 * 55773896) ^ 0x7503775D);
						continue;
					case 1u:
						KeyValues[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1632881441u)] = GetManualTempString();
						return true;
					default:
						goto end_IL_000e;
					}
					break;
				}
				continue;
				end_IL_000e:
				break;
			}
		}
		return false;
	}

	public string getHaoganList(string exception, ref List<string> roleNamelist)
	{
		List<string> list = new List<string>(_202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(exception, new char[1] { ',' }));
		string text = default(string);
		KeyValuePair<string, string> current = default(KeyValuePair<string, string>);
		List<string> haremsList = default(List<string>);
		while (true)
		{
			int num = -987611252;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1207672518)) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_003a;
				default:
				{
					roleNamelist = new List<string>();
					List<string> list2 = new List<string>();
					using (Dictionary<string, string>.Enumerator enumerator = KeyValues.GetEnumerator())
					{
						while (true)
						{
							IL_01f6:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -2030095094;
								num4 = num3;
							}
							else
							{
								num3 = -1989398608;
								num4 = num3;
							}
							while (true)
							{
								switch ((num2 = (uint)(num3 ^ -1207672518)) % 22)
								{
								case 21u:
									num3 = -1989398608;
									continue;
								default:
									goto end_IL_0097;
								case 9u:
									text = _200D_206B_206A_202D_200B_206C_206D_202C_206D_200F_206E_202B_200F_202D_200F_200D_202A_206C_202B_206C_200C_202C_202C_206D_200B_202E_200C_200E_200B_202B_206B_202C_206A_202E_202D_202E_200D_206D_206A_206A_202E(current.Key, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(392914217u), "");
									num3 = (int)((num2 * 48286780) ^ 0x5CDDCFA5);
									continue;
								case 15u:
									list2.Add(_200C_200E_206C_200D_200F_202B_206B_202A_206E_202D_202E_206D_202A_202E_206D_206B_200D_202A_200D_202B_200B_206E_206B_206F_202D_206E_206F_206D_206C_202A_206C_202A_200E_200B_200E_206F_206C_200E_202E_202A_202E(text, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3363895076u), current.Value, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3388678570u)));
									num3 = -1211165029;
									continue;
								case 2u:
									current = enumerator.Current;
									num3 = -1003805824;
									continue;
								case 7u:
									num3 = ((int)num2 * -127784499) ^ -1936705992;
									continue;
								case 13u:
									num3 = ((int)num2 * -1552580412) ^ -902664217;
									continue;
								case 19u:
									roleNamelist.Add(text);
									num3 = -2030372043;
									continue;
								case 5u:
									roleNamelist.Add(Instance.femaleName);
									num3 = (int)((num2 * 2070277461) ^ 0xDFB32E2);
									continue;
								case 0u:
									text = global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2224572418u);
									num3 = (int)((num2 * 421252986) ^ 0x1A20BE9F);
									continue;
								case 11u:
									break;
								case 14u:
									text = global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2444174133u);
									num3 = (int)((num2 * 1957974770) ^ 0x421DFEEE);
									continue;
								case 17u:
								{
									int num8;
									int num9;
									if (!_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(text, ResourceStrings.ResStrings[9]))
									{
										num8 = 529082146;
										num9 = num8;
									}
									else
									{
										num8 = 1773285322;
										num9 = num8;
									}
									num3 = num8 ^ ((int)num2 * -1169024562);
									continue;
								}
								case 12u:
								{
									int num14;
									int num15;
									if (!_206D_202D_206D_202A_200D_206B_206B_202D_202A_202D_206D_202C_206C_206A_200F_206E_202D_202C_202E_200F_206A_200B_206E_200C_206F_206B_202A_200D_206D_206D_206A_206E_206E_202C_206E_206C_202D_200C_200F_206F_202E(current.Value, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1681224206u)))
									{
										num14 = -1138395019;
										num15 = num14;
									}
									else
									{
										num14 = -1660007423;
										num15 = num14;
									}
									num3 = num14 ^ (int)(num2 * 268267457);
									continue;
								}
								case 8u:
								{
									int num12;
									int num13;
									if (_202A_206C_206B_206F_200C_206D_202E_202C_206D_200C_206B_200F_200E_206E_206A_206E_206D_202B_206F_206C_202E_206E_202D_206E_200D_206E_202C_200D_200D_202A_200C_206D_206B_202D_200B_206A_200D_200B_200B_202A_202E(current.Key, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2543027892u)))
									{
										num12 = 1104923710;
										num13 = num12;
									}
									else
									{
										num12 = 843993585;
										num13 = num12;
									}
									num3 = num12 ^ (int)(num2 * 797650489);
									continue;
								}
								case 10u:
									roleNamelist.Add(text);
									num3 = -98830309;
									continue;
								case 1u:
									list2.Add(_200D_200F_206D_200B_200E_206C_200B_206B_206E_202A_206D_200F_200C_202E_206D_202C_200C_202B_206D_206C_200E_200B_200B_202D_202B_206E_206F_202D_206F_202D_206C_206C_206D_200E_202A_202B_202B_200C_200B_202E_202E(new string[5]
									{
										global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(756314355u),
										text,
										global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1042536709u),
										current.Value,
										global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1839291621u)
									}));
									num3 = -1135048088;
									continue;
								case 4u:
								{
									int num10;
									int num11;
									if (haremsList.Contains(text))
									{
										num10 = -103035795;
										num11 = num10;
									}
									else
									{
										num10 = -999543458;
										num11 = num10;
									}
									num3 = num10 ^ (int)(num2 * 428234951);
									continue;
								}
								case 16u:
								{
									int num7;
									if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(text, ResourceStrings.ResStrings[9]))
									{
										num3 = -885422126;
										num7 = num3;
									}
									else
									{
										num3 = -1344310165;
										num7 = num3;
									}
									continue;
								}
								case 3u:
								{
									int num5;
									int num6;
									if (!list.Contains(text))
									{
										num5 = -1627606331;
										num6 = num5;
									}
									else
									{
										num5 = -1291977920;
										num6 = num5;
									}
									num3 = num5 ^ (int)(num2 * 1583922681);
									continue;
								}
								case 6u:
									roleNamelist.Add(Instance.femaleName);
									num3 = (int)((num2 * 269191019) ^ 0x5A7612B5);
									continue;
								case 18u:
									num3 = (int)(num2 * 1441897582) ^ -162921561;
									continue;
								case 20u:
									goto end_IL_0097;
								}
								goto IL_01f6;
								continue;
								end_IL_0097:
								break;
							}
							break;
						}
					}
					return _200D_206D_206B_206A_206A_202E_206E_206A_202A_200F_202E_206D_200B_206E_206A_200C_200B_206F_200E_202D_200E_200C_200E_202E_202B_206B_206F_206C_202E_206B_200C_206D_206C_200D_200B_202A_206C_206B_200B_206D_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1541154258u), list2.ToArray());
				}
				}
				break;
				IL_003a:
				List<string> roleKeyList = new List<string>();
				haremsList = GetHaremsList(_206A_206B_202D_202E_200E_206D_202D_202E_206D_200E_202A_202B_206D_200F_202D_206E_202E_200D_202E_202E_206F_200F_200F_200F_206B_202E_202C_200F_202B_202C_200B_206D_202E_200E_200C_202C_200F_202E_202B_206D_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1178885009u), exception, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2129775u)), ref roleKeyList);
				num = ((int)num2 * -2681640) ^ -798062870;
			}
		}
	}

	public int GetBattleWinCount(string battle = null)
	{
		if (!_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(battle))
		{
			goto IL_000b;
		}
		goto IL_00e6;
		IL_000b:
		int num = -1604437597;
		goto IL_0010;
		IL_0010:
		string[] array2 = default(string[]);
		int num7 = default(int);
		string[] array = default(string[]);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -916453902)) % 8)
			{
			case 5u:
				break;
			case 1u:
				goto IL_0045;
			case 2u:
				return _200B_206D_206D_200F_206C_202D_206F_202E_202C_202E_206A_200C_200D_202C_206D_206B_202C_200C_202D_200C_206B_202B_202B_200B_202E_206B_202A_200B_200F_200F_202B_206B_202C_202C_206D_206F_202A_202A_200B_206D_202E(0, int.Parse(array2[0]));
			case 6u:
				array2 = _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(BattleKeyValues[battle], new char[1] { '#' });
				num = ((int)num2 * -413840328) ^ -1245873266;
				continue;
			case 4u:
				goto IL_00b5;
			case 0u:
				num7 = 0;
				num = ((int)num2 * -1918585284) ^ 0x2E48E25D;
				continue;
			case 3u:
				goto IL_00e6;
			default:
			{
				using (Dictionary<string, string>.Enumerator enumerator = BattleKeyValues.GetEnumerator())
				{
					while (true)
					{
						IL_01ac:
						int num3;
						int num4;
						if (!enumerator.MoveNext())
						{
							num3 = -767152599;
							num4 = num3;
						}
						else
						{
							num3 = -2035261827;
							num4 = num3;
						}
						while (true)
						{
							switch ((num2 = (uint)(num3 ^ -916453902)) % 6)
							{
							case 0u:
								num3 = -2035261827;
								continue;
							default:
								goto end_IL_0117;
							case 2u:
								num7 += int.Parse(array[0]);
								num3 = (int)((num2 * 1246796713) ^ 0x621D7FC5);
								continue;
							case 4u:
							{
								int num5;
								int num6;
								if (array.Length >= 1)
								{
									num5 = -1933054482;
									num6 = num5;
								}
								else
								{
									num5 = -1262886951;
									num6 = num5;
								}
								num3 = num5 ^ (int)(num2 * 226106581);
								continue;
							}
							case 5u:
								array = _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(enumerator.Current.Value, new char[1] { '#' });
								num3 = -1263312034;
								continue;
							case 1u:
								break;
							case 3u:
								goto end_IL_0117;
							}
							goto IL_01ac;
							continue;
							end_IL_0117:
							break;
						}
						break;
					}
				}
				return num7;
			}
			}
			break;
			IL_00b5:
			if (array2.Length >= 1)
			{
				num = ((int)num2 * -1674634408) ^ -988679552;
				continue;
			}
			goto IL_01db;
			IL_0045:
			if (BattleKeyValues.ContainsKey(battle))
			{
				num = ((int)num2 * -1773104491) ^ -361219743;
				continue;
			}
			goto IL_01db;
		}
		goto IL_000b;
		IL_01db:
		return 0;
		IL_00e6:
		if (BattleKeyValues.Count > 0)
		{
			num = -1013997734;
			goto IL_0010;
		}
		goto IL_01db;
	}

	public int GetBattleLoseCount(string battle = null)
	{
		if (!_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(battle))
		{
			goto IL_000b;
		}
		goto IL_009a;
		IL_000b:
		int num = -1402074352;
		goto IL_0010;
		IL_0010:
		int num5 = default(int);
		string[] array2 = default(string[]);
		string[] array = default(string[]);
		KeyValuePair<string, string> current = default(KeyValuePair<string, string>);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -135482087)) % 8)
			{
			case 5u:
				break;
			case 1u:
				goto IL_0045;
			case 4u:
				num5 = 0;
				num = (int)((num2 * 1061566532) ^ 0x7A88516F);
				continue;
			case 2u:
				return _200B_206D_206D_200F_206C_202D_206F_202E_202C_202E_206A_200C_200D_202C_206D_206B_202C_200C_202D_200C_206B_202B_202B_200B_202E_206B_202A_200B_200F_200F_202B_206B_202C_202C_206D_206F_202A_202A_200B_206D_202E(0, int.Parse(array2[1]));
			case 3u:
				goto IL_009a;
			case 0u:
				goto IL_00b5;
			case 7u:
				array2 = _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(BattleKeyValues[battle], new char[1] { '#' });
				num = ((int)num2 * -295553239) ^ -285971722;
				continue;
			default:
			{
				using (Dictionary<string, string>.Enumerator enumerator = BattleKeyValues.GetEnumerator())
				{
					while (true)
					{
						IL_01b1:
						int num3;
						int num4;
						if (enumerator.MoveNext())
						{
							num3 = -832307644;
							num4 = num3;
						}
						else
						{
							num3 = -1196504870;
							num4 = num3;
						}
						while (true)
						{
							switch ((num2 = (uint)(num3 ^ -135482087)) % 7)
							{
							case 5u:
								num3 = -832307644;
								continue;
							default:
								goto end_IL_0117;
							case 0u:
							{
								int num6;
								int num7;
								if (array.Length >= 2)
								{
									num6 = 1871870164;
									num7 = num6;
								}
								else
								{
									num6 = 983757780;
									num7 = num6;
								}
								num3 = num6 ^ ((int)num2 * -73768109);
								continue;
							}
							case 2u:
								array = _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(current.Value, new char[1] { '#' });
								num3 = (int)(num2 * 244263577) ^ -117213404;
								continue;
							case 6u:
								num5 += int.Parse(array[1]);
								num3 = (int)(num2 * 379831646) ^ -2072224048;
								continue;
							case 4u:
								break;
							case 1u:
								current = enumerator.Current;
								num3 = -1224670122;
								continue;
							case 3u:
								goto end_IL_0117;
							}
							goto IL_01b1;
							continue;
							end_IL_0117:
							break;
						}
						break;
					}
				}
				return num5;
			}
			}
			break;
			IL_00b5:
			if (array2.Length >= 2)
			{
				num = ((int)num2 * -278320669) ^ -1792980581;
				continue;
			}
			goto IL_01f2;
			IL_0045:
			if (BattleKeyValues.ContainsKey(battle))
			{
				num = (int)(num2 * 327149484) ^ -1938814398;
				continue;
			}
			goto IL_01f2;
		}
		goto IL_000b;
		IL_01f2:
		return 0;
		IL_009a:
		if (BattleKeyValues.Count > 0)
		{
			num = -2031214763;
			goto IL_0010;
		}
		goto IL_01f2;
	}

	public int GetBattleCount(string battle = null)
	{
		if (!_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(battle))
		{
			goto IL_000b;
		}
		goto IL_0097;
		IL_000b:
		int num = -1542854094;
		goto IL_0010;
		IL_0010:
		string[] array2 = default(string[]);
		string[] array = default(string[]);
		KeyValuePair<string, string> current = default(KeyValuePair<string, string>);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -750093749)) % 6)
			{
			case 2u:
				break;
			case 1u:
				goto IL_003d;
			case 5u:
				goto IL_005e;
			case 3u:
				goto IL_0097;
			case 0u:
				return _200B_206D_206D_200F_206C_202D_206F_202E_202C_202E_206A_200C_200D_202C_206D_206B_202C_200C_202D_200C_206B_202B_202B_200B_202E_206B_202A_200B_200F_200F_202B_206B_202C_202C_206D_206F_202A_202A_200B_206D_202E(0, int.Parse(array2[0])) + _200B_206D_206D_200F_206C_202D_206F_202E_202C_202E_206A_200C_200D_202C_206D_206B_202C_200C_202D_200C_206B_202B_202B_200B_202E_206B_202A_200B_200F_200F_202B_206B_202C_202C_206D_206F_202A_202A_200B_206D_202E(0, int.Parse(array2[1]));
			default:
			{
				int num3 = 0;
				using (Dictionary<string, string>.Enumerator enumerator = BattleKeyValues.GetEnumerator())
				{
					while (true)
					{
						IL_0125:
						int num4;
						int num5;
						if (enumerator.MoveNext())
						{
							num4 = -1294473188;
							num5 = num4;
						}
						else
						{
							num4 = -1740925413;
							num5 = num4;
						}
						while (true)
						{
							switch ((num2 = (uint)(num4 ^ -750093749)) % 6)
							{
							case 2u:
								num4 = -1294473188;
								continue;
							default:
								goto end_IL_00f8;
							case 4u:
								break;
							case 3u:
							{
								array = _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(current.Value, new char[1] { '#' });
								int num6;
								int num7;
								if (array.Length >= 2)
								{
									num6 = -1135900893;
									num7 = num6;
								}
								else
								{
									num6 = -1455830456;
									num7 = num6;
								}
								num4 = num6 ^ ((int)num2 * -128745295);
								continue;
							}
							case 5u:
								num3 += int.Parse(array[0]);
								num3 += int.Parse(array[1]);
								num4 = (int)((num2 * 1023382618) ^ 0x65A0343F);
								continue;
							case 1u:
								current = enumerator.Current;
								num4 = -1516929730;
								continue;
							case 0u:
								goto end_IL_00f8;
							}
							goto IL_0125;
							continue;
							end_IL_00f8:
							break;
						}
						break;
					}
				}
				return num3;
			}
			}
			break;
			IL_005e:
			array2 = _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(BattleKeyValues[battle], new char[1] { '#' });
			if (array2.Length >= 2)
			{
				num = ((int)num2 * -174887157) ^ -1162173470;
				continue;
			}
			goto IL_01cb;
			IL_003d:
			if (BattleKeyValues.ContainsKey(battle))
			{
				num = (int)(num2 * 609096940) ^ -907610154;
				continue;
			}
			goto IL_01cb;
		}
		goto IL_000b;
		IL_01cb:
		return 0;
		IL_0097:
		if (BattleKeyValues.Count > 0)
		{
			num = -911655901;
			goto IL_0010;
		}
		goto IL_01cb;
	}

	public void SetBattleWin(string battle)
	{
		if (!BattleKeyValues.ContainsKey(battle))
		{
			goto IL_0011;
		}
		goto IL_00b7;
		IL_0011:
		int num = 1429375187;
		goto IL_0016;
		IL_0016:
		string[] array = default(string[]);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x7C4802B1)) % 9)
			{
			case 4u:
				break;
			case 3u:
				BattleKeyValues[battle] = array[0] + global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1583738914u) + array[1];
				num = (int)((num2 * 2015152473) ^ 0x3662C917);
				continue;
			case 0u:
				return;
			case 6u:
				BattleKeyValues.Add(battle, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2466607091u));
				num = (int)((num2 * 113054759) ^ 0x26F3B1);
				continue;
			case 1u:
				goto IL_00b7;
			case 7u:
			{
				int num3;
				int num4;
				if (array.Length >= 2)
				{
					num3 = 1256596294;
					num4 = num3;
				}
				else
				{
					num3 = 357165838;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 536703061);
				continue;
			}
			case 8u:
				array[0] = (int.Parse(array[0]) + 1).ToString();
				num = (int)(num2 * 46247463) ^ -1181151789;
				continue;
			case 5u:
				return;
			default:
				BattleKeyValues.Add(battle, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2210695885u));
				return;
			}
			break;
		}
		goto IL_0011;
		IL_00b7:
		array = _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(BattleKeyValues[battle], new char[1] { '#' });
		num = 1303511397;
		goto IL_0016;
	}

	public void SetBattleLose(string battle)
	{
		if (!BattleKeyValues.ContainsKey(battle))
		{
			goto IL_000e;
		}
		goto IL_0043;
		IL_000e:
		int num = 1061176398;
		goto IL_0013;
		IL_0013:
		string[] array = default(string[]);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x54C3DC6F)) % 7)
			{
			case 6u:
				break;
			case 4u:
				goto IL_0043;
			case 5u:
				return;
			case 2u:
				BattleKeyValues.Add(battle, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3377308545u));
				num = (int)((num2 * 1152892318) ^ 0x65DDE06B);
				continue;
			case 3u:
				return;
			case 1u:
				array[1] = (int.Parse(array[1]) + 1).ToString();
				BattleKeyValues[battle] = array[0] + global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2057560981u) + array[1];
				num = (int)((num2 * 95018859) ^ 0x43D86299);
				continue;
			default:
				BattleKeyValues.Add(battle, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2607179542u));
				return;
			}
			break;
		}
		goto IL_000e;
		IL_0043:
		array = _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(BattleKeyValues[battle], new char[1] { '#' });
		int num3;
		if (array.Length < 2)
		{
			num = 1005459952;
			num3 = num;
		}
		else
		{
			num = 1576529520;
			num3 = num;
		}
		goto IL_0013;
	}

	public bool DelBattle(string battle = null)
	{
		if (_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(battle))
		{
			goto IL_0008;
		}
		goto IL_007f;
		IL_0008:
		int num = 2050243924;
		goto IL_000d;
		IL_000d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x56108400)) % 6)
			{
			case 0u:
				break;
			case 4u:
				BattleKeyValues.Clear();
				num = (int)(num2 * 526046039) ^ -545653281;
				continue;
			case 1u:
				BattleKeyValues.Remove(battle);
				return true;
			case 3u:
				return true;
			case 5u:
				goto IL_007f;
			default:
				return false;
			}
			break;
		}
		goto IL_0008;
		IL_007f:
		int num3;
		if (!BattleKeyValues.ContainsKey(battle))
		{
			num = 741990886;
			num3 = num;
		}
		else
		{
			num = 618573005;
			num3 = num;
		}
		goto IL_000d;
	}

	public bool addTeamMemberFromFollow(string roleKey)
	{
		Role role = null;
		using (List<Role>.Enumerator enumerator = Follow.GetEnumerator())
		{
			Role current = default(Role);
			while (true)
			{
				IL_003e:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 1330758149;
					num2 = num;
				}
				else
				{
					num = 354626720;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x611BDBA0)) % 6)
					{
					case 5u:
						num = 1330758149;
						continue;
					default:
						goto end_IL_0015;
					case 0u:
						break;
					case 4u:
					{
						int num4;
						int num5;
						if (!_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current.Key, roleKey))
						{
							num4 = -623601442;
							num5 = num4;
						}
						else
						{
							num4 = -589316043;
							num5 = num4;
						}
						num = num4 ^ (int)(num3 * 1866588410);
						continue;
					}
					case 1u:
						current = enumerator.Current;
						num = 171217478;
						continue;
					case 3u:
						role = current;
						goto end_IL_0015;
					case 2u:
						goto end_IL_0015;
					}
					goto IL_003e;
					continue;
					end_IL_0015:
					break;
				}
				break;
			}
		}
		if (role != null)
		{
			while (true)
			{
				int num6 = 1124028603;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num6 ^ 0x611BDBA0)) % 8)
					{
					case 5u:
						break;
					case 3u:
						Follow.Remove(role);
						num6 = (int)(num3 * 107256515) ^ -248137831;
						continue;
					case 0u:
					{
						int num13;
						int num14;
						if (InTeamOnly(role.Key))
						{
							num13 = 363895634;
							num14 = num13;
						}
						else
						{
							num13 = 1011120473;
							num14 = num13;
						}
						num6 = num13 ^ ((int)num3 * -1647753813);
						continue;
					}
					case 1u:
					{
						int num9;
						int num10;
						if (InTemp(role.Key))
						{
							num9 = 726231464;
							num10 = num9;
						}
						else
						{
							num9 = 1661169404;
							num10 = num9;
						}
						num6 = num9 ^ (int)(num3 * 136892482);
						continue;
					}
					case 4u:
						Team.Add(role);
						AddTeamMemberPanel(role);
						return true;
					case 7u:
					{
						int num11;
						int num12;
						if (role.Skills.Count > 0)
						{
							num11 = -1064879426;
							num12 = num11;
						}
						else
						{
							num11 = -1374247736;
							num12 = num11;
						}
						num6 = num11 ^ ((int)num3 * -335884050);
						continue;
					}
					case 6u:
					{
						int num7;
						int num8;
						if (role.InternalSkills.Count <= 0)
						{
							num7 = 653609370;
							num8 = num7;
						}
						else
						{
							num7 = 918417959;
							num8 = num7;
						}
						num6 = num7 ^ ((int)num3 * -477236600);
						continue;
					}
					default:
						goto end_IL_00ba;
					}
					break;
				}
				continue;
				end_IL_00ba:
				break;
			}
		}
		return false;
	}

	public int GetHarems()
	{
		int num = 0;
		using (List<Role>.Enumerator enumerator = Team.GetEnumerator())
		{
			while (true)
			{
				IL_003a:
				int num2;
				int num3;
				if (enumerator.MoveNext())
				{
					num2 = 767962993;
					num3 = num2;
				}
				else
				{
					num2 = 1847632126;
					num3 = num2;
				}
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)(num2 ^ 0x2B934DFA)) % 5)
					{
					case 2u:
						num2 = 767962993;
						continue;
					default:
						goto end_IL_0015;
					case 1u:
						break;
					case 0u:
						num++;
						num2 = ((int)num4 * -235343357) ^ 0x3615F488;
						continue;
					case 3u:
					{
						int num5;
						if (enumerator.Current.isharem == 0)
						{
							num2 = 1973863403;
							num5 = num2;
						}
						else
						{
							num2 = 629938907;
							num5 = num2;
						}
						continue;
					}
					case 4u:
						goto end_IL_0015;
					}
					goto IL_003a;
					continue;
					end_IL_0015:
					break;
				}
				break;
			}
		}
		using (List<Role>.Enumerator enumerator = Follow.GetEnumerator())
		{
			while (true)
			{
				IL_0100:
				int num6;
				int num7;
				if (enumerator.MoveNext())
				{
					num6 = 1557695624;
					num7 = num6;
				}
				else
				{
					num6 = 1380912078;
					num7 = num6;
				}
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)(num6 ^ 0x2B934DFA)) % 5)
					{
					case 2u:
						num6 = 1557695624;
						continue;
					default:
						goto end_IL_00a9;
					case 1u:
					{
						int num8;
						if (enumerator.Current.isharem == 0)
						{
							num6 = 128286516;
							num8 = num6;
						}
						else
						{
							num6 = 503412459;
							num8 = num6;
						}
						continue;
					}
					case 0u:
						num++;
						num6 = ((int)num4 * -175864018) ^ 0x7095EB3A;
						continue;
					case 4u:
						break;
					case 3u:
						goto end_IL_00a9;
					}
					goto IL_0100;
					continue;
					end_IL_00a9:
					break;
				}
				break;
			}
		}
		using (List<Role>.Enumerator enumerator = Temp.GetEnumerator())
		{
			while (true)
			{
				IL_0181:
				int num9;
				int num10;
				if (enumerator.MoveNext())
				{
					num9 = 830384048;
					num10 = num9;
				}
				else
				{
					num9 = 1414749029;
					num10 = num9;
				}
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)(num9 ^ 0x2B934DFA)) % 5)
					{
					case 2u:
						num9 = 830384048;
						continue;
					default:
						goto end_IL_013d;
					case 1u:
					{
						int num11;
						if (enumerator.Current.isharem == 0)
						{
							num9 = 697570745;
							num11 = num9;
						}
						else
						{
							num9 = 1449053154;
							num11 = num9;
						}
						continue;
					}
					case 4u:
						break;
					case 3u:
						num++;
						num9 = (int)(num4 * 31329705) ^ -187127711;
						continue;
					case 0u:
						goto end_IL_013d;
					}
					goto IL_0181;
					continue;
					end_IL_013d:
					break;
				}
				break;
			}
		}
		return num;
	}

	public bool SetHarem(string roleKey, int number = 1)
	{
		Role role = GetRole(roleKey);
		if (role != null)
		{
			string text2 = default(string);
			bool flag = default(bool);
			string text = default(string);
			bool flag2 = default(bool);
			while (true)
			{
				int num = -1214482077;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -385166988)) % 33)
					{
					case 23u:
						break;
					case 26u:
						goto IL_00ad;
					case 27u:
						role.isharem = 0;
						num = (int)((num2 * 1957080759) ^ 0x5B70BD9E);
						continue;
					case 0u:
						num = (int)((num2 * 646237226) ^ 0x44E62E13);
						continue;
					case 4u:
						text2 = global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(392914217u);
						num = (int)((num2 * 822996240) ^ 0x4DC50F3B);
						continue;
					case 15u:
					{
						int num15;
						int num16;
						if (number != 0)
						{
							num15 = 2043582325;
							num16 = num15;
						}
						else
						{
							num15 = 876247954;
							num16 = num15;
						}
						num = num15 ^ (int)(num2 * 593087383);
						continue;
					}
					case 8u:
					{
						int num5;
						int num6;
						if (flag)
						{
							num5 = 1491358807;
							num6 = num5;
						}
						else
						{
							num5 = 501142651;
							num6 = num5;
						}
						num = num5 ^ ((int)num2 * -34913388);
						continue;
					}
					case 28u:
						KeyValues[text2] = global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(840126574u);
						num = (int)((num2 * 1059255954) ^ 0x284AF395);
						continue;
					case 25u:
					{
						flag = false;
						int num11;
						int num12;
						if (!KeyValues.ContainsKey(text))
						{
							num11 = 1564185801;
							num12 = num11;
						}
						else
						{
							num11 = 1461133891;
							num12 = num11;
						}
						num = num11 ^ ((int)num2 * -984614386);
						continue;
					}
					case 6u:
						KeyValues[text] = global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1626616297u);
						num = (int)(num2 * 1308994227) ^ -828584272;
						continue;
					case 12u:
						role.isharem += number;
						num = ((int)num2 * -1201534823) ^ 0x37B6C98E;
						continue;
					case 10u:
						goto IL_01f1;
					case 24u:
						goto IL_0213;
					case 11u:
						flag = true;
						num = (int)((num2 * 1741590297) ^ 0x6D7078CC);
						continue;
					case 13u:
						flag2 = true;
						num = ((int)num2 * -1611255886) ^ 0x264B2145;
						continue;
					case 7u:
						text = _206A_200C_200F_206E_202E_206D_206E_200E_202D_200E_202A_200F_200E_200B_202A_206B_200B_202A_202E_206A_202B_206C_200F_202C_202D_200F_202D_206E_206D_202A_202A_200C_200C_206D_200B_202B_202B_200C_200E_200C_202E(text, role.Name);
						num = -1063216571;
						continue;
					case 16u:
						goto IL_026c;
					case 32u:
					{
						int num17;
						int num18;
						if (int.Parse(KeyValues[text]) < 60)
						{
							num17 = -1203065285;
							num18 = num17;
						}
						else
						{
							num17 = -1393849896;
							num18 = num17;
						}
						num = num17 ^ ((int)num2 * -401210340);
						continue;
					}
					case 22u:
					{
						int num13;
						int num14;
						if (role.isharem <= 1)
						{
							num13 = 165525817;
							num14 = num13;
						}
						else
						{
							num13 = 1777233137;
							num14 = num13;
						}
						num = num13 ^ (int)(num2 * 805731523);
						continue;
					}
					case 1u:
						role.isharem = 1;
						num = (int)((num2 * 1554981104) ^ 0x6A608E72);
						continue;
					case 9u:
						flag2 = false;
						num = -1185855067;
						continue;
					case 29u:
						text2 = _206A_200C_200F_206E_202E_206D_206E_200E_202D_200E_202A_200F_200E_200B_202A_206B_200B_202A_202E_206A_202B_206C_200F_202C_202D_200F_202D_206E_206D_202A_202A_200C_200C_206D_200B_202B_202B_200C_200E_200C_202E(text2, role.Key);
						num = ((int)num2 * -301574789) ^ 0x64CD52A9;
						continue;
					case 2u:
						text = global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(729072893u);
						num = -878964851;
						continue;
					case 30u:
					{
						int num9;
						int num10;
						if (int.Parse(KeyValues[text2]) < 60)
						{
							num9 = -1909149132;
							num10 = num9;
						}
						else
						{
							num9 = -319284055;
							num10 = num9;
						}
						num = num9 ^ (int)(num2 * 2129333175);
						continue;
					}
					case 14u:
						text2 = _206A_200C_200F_206E_202E_206D_206E_200E_202D_200E_202A_200F_200E_200B_202A_206B_200B_202A_202E_206A_202B_206C_200F_202C_202D_200F_202D_206E_206D_202A_202A_200C_200C_206D_200B_202B_202B_200C_200E_200C_202E(text2, ResourceStrings.ResStrings[9]);
						num = (int)((num2 * 179996165) ^ 0x4044B42B);
						continue;
					case 18u:
						num = (int)(num2 * 1537967542) ^ -1842616745;
						continue;
					case 20u:
					{
						int num7;
						int num8;
						if (!_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(role.Key, ResourceStrings.ResStrings[9]))
						{
							num7 = -1511265882;
							num8 = num7;
						}
						else
						{
							num7 = -1061390862;
							num8 = num7;
						}
						num = num7 ^ ((int)num2 * -21725302);
						continue;
					}
					case 31u:
						return true;
					case 19u:
						goto IL_03e9;
					case 17u:
						KeyValues[text] = global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(840126574u);
						num = (int)((num2 * 1305726040) ^ 0x356F3B53);
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (role.isharem >= 0)
						{
							num3 = -1152239641;
							num4 = num3;
						}
						else
						{
							num3 = -451513631;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 913798653);
						continue;
					}
					case 3u:
						text = _206A_200C_200F_206E_202E_206D_206E_200E_202D_200E_202A_200F_200E_200B_202A_206B_200B_202A_202E_206A_202B_206C_200F_202C_202D_200F_202D_206E_206D_202A_202A_200C_200C_206D_200B_202B_202B_200C_200E_200C_202E(text, ResourceStrings.ResStrings[9]);
						num = (int)((num2 * 651789695) ^ 0x518D0B11);
						continue;
					default:
						goto end_IL_000e;
					}
					break;
					IL_03e9:
					int num19;
					if (flag)
					{
						num = -873373384;
						num19 = num;
					}
					else
					{
						num = -54896899;
						num19 = num;
					}
					continue;
					IL_00ad:
					int num20;
					if (!flag2)
					{
						num = -398731768;
						num20 = num;
					}
					else
					{
						num = -54452712;
						num20 = num;
					}
					continue;
					IL_0213:
					int num21;
					if (!flag2)
					{
						num = -1242096968;
						num21 = num;
					}
					else
					{
						num = -2018483801;
						num21 = num;
					}
					continue;
					IL_026c:
					int num22;
					if (role.isharem > 0)
					{
						num = -890131891;
						num22 = num;
					}
					else
					{
						num = -54896899;
						num22 = num;
					}
					continue;
					IL_01f1:
					int num23;
					if (!KeyValues.ContainsKey(text2))
					{
						num = -1946605047;
						num23 = num;
					}
					else
					{
						num = -659028999;
						num23 = num;
					}
				}
				continue;
				end_IL_000e:
				break;
			}
		}
		return false;
	}

	public void ClearHarems()
	{
		using (List<Role>.Enumerator enumerator = Team.GetEnumerator())
		{
			while (true)
			{
				IL_0048:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -1010558176;
					num2 = num;
				}
				else
				{
					num = -1716187950;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -63867069)) % 4)
					{
					case 0u:
						num = -1010558176;
						continue;
					default:
						goto end_IL_0013;
					case 3u:
						enumerator.Current.isharem = 0;
						num = -858221351;
						continue;
					case 2u:
						break;
					case 1u:
						goto end_IL_0013;
					}
					goto IL_0048;
					continue;
					end_IL_0013:
					break;
				}
				break;
			}
		}
		using (List<Role>.Enumerator enumerator = Follow.GetEnumerator())
		{
			while (true)
			{
				IL_00ba:
				int num4;
				int num5;
				if (!enumerator.MoveNext())
				{
					num4 = -106868187;
					num5 = num4;
				}
				else
				{
					num4 = -2125456598;
					num5 = num4;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num4 ^ -63867069)) % 4)
					{
					case 0u:
						num4 = -2125456598;
						continue;
					default:
						goto end_IL_0085;
					case 1u:
						enumerator.Current.isharem = 0;
						num4 = -1600725072;
						continue;
					case 3u:
						break;
					case 2u:
						goto end_IL_0085;
					}
					goto IL_00ba;
					continue;
					end_IL_0085:
					break;
				}
				break;
			}
		}
		using List<Role>.Enumerator enumerator = Temp.GetEnumerator();
		while (true)
		{
			int num6;
			int num7;
			if (enumerator.MoveNext())
			{
				num6 = -1631231668;
				num7 = num6;
			}
			else
			{
				num6 = -2049875106;
				num7 = num6;
			}
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num6 ^ -63867069)) % 4)
				{
				case 2u:
					num6 = -1631231668;
					continue;
				default:
					return;
				case 3u:
					enumerator.Current.isharem = 0;
					num6 = -301090853;
					continue;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public Role GetRoleByName(string roleName)
	{
		Role result = default(Role);
		using (List<Role>.Enumerator enumerator = Temp.GetEnumerator())
		{
			Role current = default(Role);
			while (true)
			{
				IL_0077:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -743877650;
					num2 = num;
				}
				else
				{
					num = -1215911632;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -983065385)) % 5)
					{
					case 0u:
						num = -1215911632;
						continue;
					default:
						goto end_IL_0013;
					case 3u:
					{
						current = enumerator.Current;
						int num4;
						if (_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current.Name, roleName))
						{
							num = -1722100395;
							num4 = num;
						}
						else
						{
							num = -1676990872;
							num4 = num;
						}
						continue;
					}
					case 1u:
						result = current;
						goto IL_0230;
					case 4u:
						break;
					case 2u:
						goto end_IL_0013;
					}
					goto IL_0077;
					continue;
					end_IL_0013:
					break;
				}
				break;
			}
		}
		using (List<Role>.Enumerator enumerator = Follow.GetEnumerator())
		{
			Role current2 = default(Role);
			while (true)
			{
				IL_00de:
				int num5;
				int num6;
				if (!enumerator.MoveNext())
				{
					num5 = -620573448;
					num6 = num5;
				}
				else
				{
					num5 = -453719001;
					num6 = num5;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num5 ^ -983065385)) % 6)
					{
					case 0u:
						num5 = -453719001;
						continue;
					default:
						goto end_IL_00b4;
					case 5u:
						break;
					case 4u:
						result = current2;
						num5 = (int)((num3 * 920388160) ^ 0x3764D9F4);
						continue;
					case 2u:
					{
						current2 = enumerator.Current;
						int num7;
						if (_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current2.Name, roleName))
						{
							num5 = -444895817;
							num7 = num5;
						}
						else
						{
							num5 = -174980916;
							num7 = num5;
						}
						continue;
					}
					case 3u:
						goto end_IL_00b4;
					case 1u:
						goto IL_0230;
					}
					goto IL_00de;
					continue;
					end_IL_00b4:
					break;
				}
				break;
			}
		}
		using (List<Role>.Enumerator enumerator = Team.GetEnumerator())
		{
			Role current3 = default(Role);
			while (true)
			{
				IL_019d:
				int num8;
				int num9;
				if (!enumerator.MoveNext())
				{
					num8 = -333685553;
					num9 = num8;
				}
				else
				{
					num8 = -1818226288;
					num9 = num8;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num8 ^ -983065385)) % 7)
					{
					case 4u:
						num8 = -1818226288;
						continue;
					default:
						goto end_IL_016c;
					case 3u:
						break;
					case 0u:
					{
						int num10;
						int num11;
						if (!_206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(current3.Name, roleName))
						{
							num10 = -1625393922;
							num11 = num10;
						}
						else
						{
							num10 = -453411669;
							num11 = num10;
						}
						num8 = num10 ^ (int)(num3 * 421974675);
						continue;
					}
					case 2u:
						result = current3;
						num8 = (int)((num3 * 706093232) ^ 0x4C7ACC5A);
						continue;
					case 6u:
						current3 = enumerator.Current;
						num8 = -800453350;
						continue;
					case 1u:
						goto end_IL_016c;
					case 5u:
						goto IL_0230;
					}
					goto IL_019d;
					continue;
					end_IL_016c:
					break;
				}
				break;
			}
		}
		return null;
		IL_0230:
		return result;
	}

	public List<string> GetHaremsList(string exception, ref List<string> roleKeyList)
	{
		roleKeyList = new List<string>();
		List<string> list = new List<string>();
		using (List<Role>.Enumerator enumerator = Team.GetEnumerator())
		{
			Role current = default(Role);
			while (true)
			{
				IL_0060:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -1984824792;
					num2 = num;
				}
				else
				{
					num = -206083687;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -1124867530)) % 7)
					{
					case 0u:
						num = -206083687;
						continue;
					default:
						goto end_IL_0020;
					case 1u:
						current = enumerator.Current;
						num = -43935919;
						continue;
					case 6u:
						break;
					case 5u:
					{
						int num6;
						int num7;
						if (_200D_202D_202C_200D_206D_200E_206B_202E_202D_200C_202C_202E_206E_202E_200D_206D_200E_206A_206D_206D_200C_200C_202A_202B_202E_200E_206E_200E_202D_206B_206D_200E_206E_202A_202D_206F_200F_200F_206F_202D_202E(exception, current.Name))
						{
							num6 = 450359413;
							num7 = num6;
						}
						else
						{
							num6 = 298799788;
							num7 = num6;
						}
						num = num6 ^ ((int)num3 * -618753060);
						continue;
					}
					case 4u:
					{
						int num4;
						int num5;
						if (current.isharem == 0)
						{
							num4 = 1033451833;
							num5 = num4;
						}
						else
						{
							num4 = 2133605314;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -167924940);
						continue;
					}
					case 2u:
						list.Add(current.Name);
						roleKeyList.Add(current.Key);
						num = (int)((num3 * 1195240676) ^ 0x3744077D);
						continue;
					case 3u:
						goto end_IL_0020;
					}
					goto IL_0060;
					continue;
					end_IL_0020:
					break;
				}
				break;
			}
		}
		using (List<Role>.Enumerator enumerator = Follow.GetEnumerator())
		{
			Role current2 = default(Role);
			while (true)
			{
				IL_015d:
				int num8;
				int num9;
				if (!enumerator.MoveNext())
				{
					num8 = -1820438578;
					num9 = num8;
				}
				else
				{
					num8 = -84474468;
					num9 = num8;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num8 ^ -1124867530)) % 8)
					{
					case 6u:
						num8 = -84474468;
						continue;
					default:
						goto end_IL_0119;
					case 2u:
						current2 = enumerator.Current;
						num8 = -1909677827;
						continue;
					case 7u:
						break;
					case 4u:
						roleKeyList.Add(current2.Key);
						num8 = ((int)num3 * -145964807) ^ 0x15FB8CBD;
						continue;
					case 1u:
					{
						int num12;
						int num13;
						if (_200D_202D_202C_200D_206D_200E_206B_202E_202D_200C_202C_202E_206E_202E_200D_206D_200E_206A_206D_206D_200C_200C_202A_202B_202E_200E_206E_200E_202D_206B_206D_200E_206E_202A_202D_206F_200F_200F_206F_202D_202E(exception, current2.Name))
						{
							num12 = -90154800;
							num13 = num12;
						}
						else
						{
							num12 = -1828983814;
							num13 = num12;
						}
						num8 = num12 ^ (int)(num3 * 1755416913);
						continue;
					}
					case 3u:
					{
						int num10;
						int num11;
						if (current2.isharem == 0)
						{
							num10 = 711676369;
							num11 = num10;
						}
						else
						{
							num10 = 946683239;
							num11 = num10;
						}
						num8 = num10 ^ (int)(num3 * 135924520);
						continue;
					}
					case 5u:
						list.Add(current2.Name);
						num8 = (int)((num3 * 265366262) ^ 0x15361D2C);
						continue;
					case 0u:
						goto end_IL_0119;
					}
					goto IL_015d;
					continue;
					end_IL_0119:
					break;
				}
				break;
			}
		}
		using (List<Role>.Enumerator enumerator = Temp.GetEnumerator())
		{
			Role current3 = default(Role);
			while (true)
			{
				IL_02d5:
				int num14;
				int num15;
				if (!enumerator.MoveNext())
				{
					num14 = -1787707252;
					num15 = num14;
				}
				else
				{
					num14 = -1883370333;
					num15 = num14;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num14 ^ -1124867530)) % 8)
					{
					case 0u:
						num14 = -1883370333;
						continue;
					default:
						goto end_IL_0229;
					case 5u:
						current3 = enumerator.Current;
						num14 = -318950774;
						continue;
					case 1u:
						roleKeyList.Add(current3.Key);
						num14 = (int)(num3 * 1132647692) ^ -746847436;
						continue;
					case 7u:
						list.Add(current3.Name);
						num14 = ((int)num3 * -456799646) ^ 0x58D562C1;
						continue;
					case 3u:
					{
						int num18;
						int num19;
						if (!_200D_202D_202C_200D_206D_200E_206B_202E_202D_200C_202C_202E_206E_202E_200D_206D_200E_206A_206D_206D_200C_200C_202A_202B_202E_200E_206E_200E_202D_206B_206D_200E_206E_202A_202D_206F_200F_200F_206F_202D_202E(exception, current3.Name))
						{
							num18 = -683308852;
							num19 = num18;
						}
						else
						{
							num18 = -696811195;
							num19 = num18;
						}
						num14 = num18 ^ (int)(num3 * 849526815);
						continue;
					}
					case 6u:
						break;
					case 4u:
					{
						int num16;
						int num17;
						if (current3.isharem == 0)
						{
							num16 = 1197105160;
							num17 = num16;
						}
						else
						{
							num16 = 1187984165;
							num17 = num16;
						}
						num14 = num16 ^ (int)(num3 * 115386620);
						continue;
					}
					case 2u:
						goto end_IL_0229;
					}
					goto IL_02d5;
					continue;
					end_IL_0229:
					break;
				}
				break;
			}
		}
		return list;
	}

	public List<string> getRoleListLua()
	{
		List<string> list = new List<string>();
		using (List<Role>.Enumerator enumerator = Team.GetEnumerator())
		{
			Role current = default(Role);
			while (true)
			{
				IL_004a:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 1867184806;
					num2 = num;
				}
				else
				{
					num = 561131307;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x343D5293)) % 7)
					{
					case 0u:
						num = 561131307;
						continue;
					default:
						goto end_IL_0019;
					case 5u:
						break;
					case 1u:
						list.Add(current.Name);
						num = ((int)num3 * -759409121) ^ -1507610976;
						continue;
					case 6u:
						list.Add(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2540932728u));
						num = (int)((num3 * 1839119218) ^ 0x32964A65);
						continue;
					case 3u:
						list.Add(current.Key);
						num = (int)(num3 * 1917953795) ^ -644528616;
						continue;
					case 2u:
						current = enumerator.Current;
						num = 2010628647;
						continue;
					case 4u:
						goto end_IL_0019;
					}
					goto IL_004a;
					continue;
					end_IL_0019:
					break;
				}
				break;
			}
		}
		using (List<Role>.Enumerator enumerator = Follow.GetEnumerator())
		{
			Role current2 = default(Role);
			while (true)
			{
				IL_0176:
				int num4;
				int num5;
				if (!enumerator.MoveNext())
				{
					num4 = 1142866822;
					num5 = num4;
				}
				else
				{
					num4 = 747444933;
					num5 = num4;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num4 ^ 0x343D5293)) % 7)
					{
					case 3u:
						num4 = 747444933;
						continue;
					default:
						goto end_IL_00fa;
					case 1u:
						current2 = enumerator.Current;
						num4 = 1829088307;
						continue;
					case 5u:
						list.Add(current2.Key);
						num4 = (int)((num3 * 181154178) ^ 0x14EB6D7A);
						continue;
					case 2u:
						list.Add(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2561488174u));
						num4 = ((int)num3 * -70233603) ^ -1350251817;
						continue;
					case 4u:
						break;
					case 0u:
						list.Add(current2.Name);
						num4 = ((int)num3 * -2105877771) ^ 0x2951F2EB;
						continue;
					case 6u:
						goto end_IL_00fa;
					}
					goto IL_0176;
					continue;
					end_IL_00fa:
					break;
				}
				break;
			}
		}
		using (List<Role>.Enumerator enumerator = Temp.GetEnumerator())
		{
			Role current3 = default(Role);
			while (true)
			{
				IL_0256:
				int num6;
				int num7;
				if (enumerator.MoveNext())
				{
					num6 = 1710931327;
					num7 = num6;
				}
				else
				{
					num6 = 445022327;
					num7 = num6;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num6 ^ 0x343D5293)) % 7)
					{
					case 0u:
						num6 = 1710931327;
						continue;
					default:
						goto end_IL_01d8;
					case 5u:
						current3 = enumerator.Current;
						num6 = 1124774934;
						continue;
					case 3u:
						list.Add(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4290218165u));
						num6 = ((int)num3 * -1684226937) ^ -556370226;
						continue;
					case 2u:
						list.Add(current3.Name);
						num6 = ((int)num3 * -61845547) ^ -361438931;
						continue;
					case 6u:
						break;
					case 1u:
						list.Add(current3.Key);
						num6 = (int)(num3 * 1733077793) ^ -608875841;
						continue;
					case 4u:
						goto end_IL_01d8;
					}
					goto IL_0256;
					continue;
					end_IL_01d8:
					break;
				}
				break;
			}
		}
		return list;
	}

	public string getRoleNameWithColor(List<string> roleList, string roleName, string dispName = null)
	{
		string text = null;
		int num6 = default(int);
		int num5 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = -1490016205;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1501177827)) % 27)
				{
				case 0u:
					break;
				case 8u:
					return _206A_206B_202D_202E_200E_206D_202D_202E_206D_200E_202A_202B_206D_200F_202D_206E_202E_200D_202E_202E_206F_200F_200F_200F_206B_202E_202C_200F_202B_202C_200B_206D_202E_200E_200C_202C_200F_202E_202B_206D_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(263205767u), text, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3984246105u));
				case 11u:
					text = roleName;
					num = -869863037;
					continue;
				case 17u:
				{
					int num18;
					int num19;
					if (roleList.Count > 3)
					{
						num18 = 616144381;
						num19 = num18;
					}
					else
					{
						num18 = 437429871;
						num19 = num18;
					}
					num = num18 ^ (int)(num2 * 753564435);
					continue;
				}
				case 20u:
					num = (int)(num2 * 7820628) ^ -1774784006;
					continue;
				case 25u:
					num6 = 0;
					num = -1198050121;
					continue;
				case 23u:
					return _206A_206B_202D_202E_200E_206D_202D_202E_206D_200E_202A_202B_206D_200F_202D_206E_202E_200D_202E_202E_206F_200F_200F_200F_206B_202E_202C_200F_202B_202C_200B_206D_202E_200E_200C_202C_200F_202E_202B_206D_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3676753347u), text, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1988573054u));
				case 1u:
				{
					int num14;
					int num15;
					if (GetTempRole(roleList[num6 - 1]).isharem == 0)
					{
						num14 = 1661222758;
						num15 = num14;
					}
					else
					{
						num14 = 1278085220;
						num15 = num14;
					}
					num = num14 ^ (int)(num2 * 1194190008);
					continue;
				}
				case 18u:
				{
					int num22;
					if (num5 != 1)
					{
						num = -411529108;
						num22 = num;
					}
					else
					{
						num = -1969578122;
						num22 = num;
					}
					continue;
				}
				case 21u:
					text = dispName;
					num = (int)((num2 * 402229469) ^ 0x37274226);
					continue;
				case 9u:
				{
					int num20;
					if (!_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(roleList[num4], roleName))
					{
						num = -777103550;
						num20 = num;
					}
					else
					{
						num = -1663464741;
						num20 = num;
					}
					continue;
				}
				case 4u:
					num6 = num4;
					num = (int)((num2 * 2045982665) ^ 0x25B7B81);
					continue;
				case 7u:
				{
					int num11;
					int num12;
					if (GetTeamRole(roleList[num6 - 1]).isharem == 0)
					{
						num11 = -1768749059;
						num12 = num11;
					}
					else
					{
						num11 = -641243275;
						num12 = num11;
					}
					num = num11 ^ ((int)num2 * -1294861577);
					continue;
				}
				case 24u:
				{
					num5 = int.Parse(roleList[num6 + 1]);
					int num7;
					if (num5 == 0)
					{
						num = -1696062168;
						num7 = num;
					}
					else
					{
						num = -1361216276;
						num7 = num;
					}
					continue;
				}
				case 19u:
					num4 = 4;
					num = (int)((num2 * 1474058301) ^ 0x1C530FD9);
					continue;
				case 10u:
					num = ((int)num2 * -1250649494) ^ 0x64128BA3;
					continue;
				case 6u:
				{
					int num21;
					if (num6 > 0)
					{
						num = -194330887;
						num21 = num;
					}
					else
					{
						num = -450356885;
						num21 = num;
					}
					continue;
				}
				case 5u:
					return _206A_206B_202D_202E_200E_206D_202D_202E_206D_200E_202A_202B_206D_200F_202D_206E_202E_200D_202E_202E_206F_200F_200F_200F_206B_202E_202C_200F_202B_202C_200B_206D_202E_200E_200C_202C_200F_202E_202B_206D_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(263205767u), text, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(373234159u));
				case 13u:
				{
					int num16;
					int num17;
					if (GetFollowRole(roleList[num6 - 1]).isharem == 0)
					{
						num16 = -918827466;
						num17 = num16;
					}
					else
					{
						num16 = -343929662;
						num17 = num16;
					}
					num = num16 ^ ((int)num2 * -1739010120);
					continue;
				}
				case 22u:
					return _206A_206B_202D_202E_200E_206D_202D_202E_206D_200E_202A_202B_206D_200F_202D_206E_202E_200D_202E_202E_206F_200F_200F_200F_206B_202E_202C_200F_202B_202C_200B_206D_202E_200E_200C_202C_200F_202E_202B_206D_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(263205767u), text, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(373234159u));
				case 2u:
				{
					int num13;
					if (num4 > roleList.Count - 2)
					{
						num = -1328249017;
						num13 = num;
					}
					else
					{
						num = -1691297549;
						num13 = num;
					}
					continue;
				}
				case 15u:
				{
					int num9;
					int num10;
					if (_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(dispName))
					{
						num9 = -314763798;
						num10 = num9;
					}
					else
					{
						num9 = -1791765322;
						num10 = num9;
					}
					num = num9 ^ ((int)num2 * -2020512313);
					continue;
				}
				case 14u:
				{
					int num8;
					if (num5 != 2)
					{
						num = -549906466;
						num8 = num;
					}
					else
					{
						num = -274320484;
						num8 = num;
					}
					continue;
				}
				case 16u:
					num4 += 3;
					num = -637558526;
					continue;
				case 3u:
				{
					int num3;
					if (roleList != null)
					{
						num = -1530459284;
						num3 = num;
					}
					else
					{
						num = -305898996;
						num3 = num;
					}
					continue;
				}
				case 26u:
					return _206A_206B_202D_202E_200E_206D_202D_202E_206D_200E_202A_202B_206D_200F_202D_206E_202E_200D_202E_202E_206F_200F_200F_200F_206B_202E_202C_200F_202B_202C_200B_206D_202E_200E_200C_202C_200F_202E_202B_206D_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3676753347u), text, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3984246105u));
				default:
					return _206A_206B_202D_202E_200E_206D_202D_202E_206D_200E_202A_202B_206D_200F_202D_206E_202E_200D_202E_202E_206F_200F_200F_200F_206B_202E_202C_200F_202B_202C_200B_206D_202E_200E_200C_202C_200F_202E_202B_206D_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3505251068u), text, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1988573054u));
				}
				break;
			}
		}
	}

	public void addTempMember(string roleKey)
	{
		if (GetRole(roleKey) != null)
		{
			return;
		}
		InternalSkillInstance internalSkillInstance = default(InternalSkillInstance);
		Role role2 = default(Role);
		Role role = default(Role);
		while (true)
		{
			int num = -1568826363;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -256341908)) % 11)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					internalSkillInstance.equipped = 1;
					num = ((int)num2 * -2849582) ^ 0x1945B20A;
					continue;
				case 10u:
				{
					int num7;
					int num8;
					if (role2.InternalSkills.Count > 0)
					{
						num7 = -1667341896;
						num8 = num7;
					}
					else
					{
						num7 = -1009039620;
						num8 = num7;
					}
					num = num7 ^ (int)(num2 * 1372805880);
					continue;
				}
				case 8u:
				{
					role = role2.Clone();
					int num9;
					int num10;
					if (role.EquippedInternalSkill != null)
					{
						num9 = 650872176;
						num10 = num9;
					}
					else
					{
						num9 = 791104242;
						num10 = num9;
					}
					num = num9 ^ ((int)num2 * -1242262775);
					continue;
				}
				case 3u:
					Temp.Add(role);
					num = -1662138716;
					continue;
				case 4u:
					role.EquippedInternalSkill = internalSkillInstance;
					num = (int)((num2 * 1817325451) ^ 0x20735834);
					continue;
				case 5u:
					role2 = ResourceManager.Get<Role>(roleKey);
					num = ((int)num2 * -986635250) ^ 0x4EF3D711;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (role2.Skills.Count > 0)
					{
						num5 = 1495735964;
						num6 = num5;
					}
					else
					{
						num5 = 158981868;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1418943162);
					continue;
				}
				case 6u:
				{
					int num3;
					int num4;
					if (role2 != null)
					{
						num3 = -350149214;
						num4 = num3;
					}
					else
					{
						num3 = -1430999617;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1566346441);
					continue;
				}
				case 9u:
					internalSkillInstance = role.InternalSkills[0];
					num = (int)(num2 * 1322428668) ^ -1544505787;
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public void InitRoleValues()
	{
		if (_202D_206E_206C_200D_206C_206D_202E_200D_202A_206F_202B_206C_206E_202B_202D_206F_200F_206D_202A_206C_202E_206E_206B_206E_200F_202B_200C_206D_206B_206E_200B_206C_200D_206C_200C_200D_200B_200B_206E_202E == null)
		{
			goto IL_000b;
		}
		goto IL_0137;
		IL_000b:
		int num = -1930080976;
		goto IL_0010;
		IL_0010:
		int num3 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -72453062)) % 12)
			{
			case 7u:
				break;
			default:
				return;
			case 4u:
				num = (int)(num2 * 382820449) ^ -1380612138;
				continue;
			case 3u:
				goto IL_0064;
			case 6u:
				_202D_206E_206C_200D_206C_206D_202E_200D_202A_206F_202B_206C_206E_202B_202D_206F_200F_206D_202A_206C_202E_206E_206B_206E_200F_202B_200C_206D_206B_206E_200B_206C_200D_206C_200C_200D_200B_200B_206E_202E[num3] = "";
				num3++;
				num = -203460762;
				continue;
			case 9u:
				num = (int)(num2 * 381522387) ^ -1548597786;
				continue;
			case 0u:
				goto IL_00b4;
			case 5u:
				_202D_206E_206C_200D_206C_206D_202E_200D_202A_206F_202B_206C_206E_202B_202D_206F_200F_206D_202A_206C_202E_206E_206B_206E_200F_202B_200C_206D_206B_206E_200B_206C_200D_206C_200C_200D_200B_200B_206E_202E.Add("");
				_202D_206E_206C_200D_206C_206D_202E_200D_202A_206F_202B_206C_206E_202B_202D_206F_200F_206D_202A_206C_202E_206E_206B_206E_200F_202B_200C_206D_206B_206E_200B_206C_200D_206C_200C_200D_200B_200B_206E_202E.Add("");
				_202D_206E_206C_200D_206C_206D_202E_200D_202A_206F_202B_206C_206E_202B_202D_206F_200F_206D_202A_206C_202E_206E_206B_206E_200F_202B_200C_206D_206B_206E_200B_206C_200D_206C_200C_200D_200B_200B_206E_202E.Add("");
				num = ((int)num2 * -1935535846) ^ -188123834;
				continue;
			case 10u:
				_202D_206E_206C_200D_206C_206D_202E_200D_202A_206F_202B_206C_206E_202B_202D_206F_200F_206D_202A_206C_202E_206E_206B_206E_200F_202B_200C_206D_206B_206E_200B_206C_200D_206C_200C_200D_200B_200B_206E_202E = new List<string>();
				num = ((int)num2 * -1118374078) ^ -1112307009;
				continue;
			case 1u:
				goto IL_0137;
			case 2u:
				_202D_206E_206C_200D_206C_206D_202E_200D_202A_206F_202B_206C_206E_202B_202D_206F_200F_206D_202A_206C_202E_206E_206B_206E_200F_202B_200C_206D_206B_206E_200B_206C_200D_206C_200C_200D_200B_200B_206E_202E.Add("");
				return;
			case 11u:
				_202D_206E_206C_200D_206C_206D_202E_200D_202A_206F_202B_206C_206E_202B_202D_206F_200F_206D_202A_206C_202E_206E_206B_206E_200F_202B_200C_206D_206B_206E_200B_206C_200D_206C_200C_200D_200B_200B_206E_202E.Add("");
				num = -1731370123;
				continue;
			case 8u:
				return;
			}
			break;
			IL_00b4:
			int num4;
			if (num3 < _202D_206E_206C_200D_206C_206D_202E_200D_202A_206F_202B_206C_206E_202B_202D_206F_200F_206D_202A_206C_202E_206E_206B_206E_200F_202B_200C_206D_206B_206E_200B_206C_200D_206C_200C_200D_200B_200B_206E_202E.Count - 1)
			{
				num = -17367684;
				num4 = num;
			}
			else
			{
				num = -1871440773;
				num4 = num;
			}
			continue;
			IL_0064:
			int num5;
			if (_202D_206E_206C_200D_206C_206D_202E_200D_202A_206F_202B_206C_206E_202B_202D_206F_200F_206D_202A_206C_202E_206E_206B_206E_200F_202B_200C_206D_206B_206E_200B_206C_200D_206C_200C_200D_200B_200B_206E_202E.Count >= 4)
			{
				num = -1641647058;
				num5 = num;
			}
			else
			{
				num = -903510107;
				num5 = num;
			}
		}
		goto IL_000b;
		IL_0137:
		num3 = 0;
		num = -1191439734;
		goto IL_0010;
	}

	public void SetRoleValues(int index, string key, string name = null)
	{
		if (index < 0)
		{
			goto IL_0004;
		}
		goto IL_0067;
		IL_0004:
		int num = 374569445;
		goto IL_0009;
		IL_0009:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x1F246E04)) % 12)
			{
			case 9u:
				break;
			default:
				return;
			case 10u:
				goto IL_004e;
			case 5u:
				goto IL_0067;
			case 7u:
				name = key;
				num = ((int)num2 * -1046377262) ^ -2018151844;
				continue;
			case 4u:
				_202D_206E_206C_200D_206C_206D_202E_200D_202A_206F_202B_206C_206E_202B_202D_206F_200F_206D_202A_206C_202E_206E_206B_206E_200F_202B_200C_206D_206B_206E_200B_206C_200D_206C_200C_200D_200B_200B_206E_202E[index] = _206A_206B_202D_202E_200E_206D_202D_202E_206D_200E_202A_202B_206D_200F_202D_206E_202E_200D_202E_202E_206F_200F_200F_200F_206B_202E_202C_200F_202B_202C_200B_206D_202E_200E_200C_202C_200F_202E_202B_206D_202E(key, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2876438784u), name);
				num = ((int)num2 * -1601324442) ^ -115841624;
				continue;
			case 0u:
				index = _202D_206E_206C_200D_206C_206D_202E_200D_202A_206F_202B_206C_206E_202B_202D_206F_200F_206D_202A_206C_202E_206E_206B_206E_200F_202B_200C_206D_206B_206E_200B_206C_200D_206C_200C_200D_200B_200B_206E_202E.Count - 1;
				num = (int)((num2 * 2037320163) ^ 0x3E0FE936);
				continue;
			case 2u:
				goto IL_00ed;
			case 1u:
				index = 0;
				num = ((int)num2 * -1873460350) ^ 0x14812BC4;
				continue;
			case 3u:
			{
				int num5;
				int num6;
				if (!_200D_202D_202C_200D_206D_200E_206B_202E_202D_200C_202C_202E_206E_202E_200D_206D_200E_206A_206D_206D_200C_200C_202A_202B_202E_200E_206E_200E_202D_206B_206D_200E_206E_202A_202D_206F_200F_200F_206F_202D_202E(key, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2812518524u)))
				{
					num5 = 1698437428;
					num6 = num5;
				}
				else
				{
					num5 = 910654038;
					num6 = num5;
				}
				num = num5 ^ (int)(num2 * 300513826);
				continue;
			}
			case 6u:
			{
				int num7;
				int num8;
				if (!_200D_202D_202C_200D_206D_200E_206B_202E_202D_200C_202C_202E_206E_202E_200D_206D_200E_206A_206D_206D_200C_200C_202A_202B_202E_200E_206E_200E_202D_206B_206D_200E_206E_202A_202D_206F_200F_200F_206F_202D_202E(name, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2812518524u)))
				{
					num7 = 232548852;
					num8 = num7;
				}
				else
				{
					num7 = 1689482808;
					num8 = num7;
				}
				num = num7 ^ ((int)num2 * -2051318376);
				continue;
			}
			case 11u:
			{
				int num3;
				int num4;
				if (!_200D_202D_202C_200D_206D_200E_206B_202E_202D_200C_202C_202E_206E_202E_200D_206D_200E_206A_206D_206D_200C_200C_202A_202B_202E_200E_206E_200E_202D_206B_206D_200E_206E_202A_202D_206F_200F_200F_206F_202D_202E(name, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3132559320u)))
				{
					num3 = 829592093;
					num4 = num3;
				}
				else
				{
					num3 = 420748126;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -1699241022);
				continue;
			}
			case 8u:
				return;
			}
			break;
			IL_00ed:
			int num9;
			if (_200D_202D_202C_200D_206D_200E_206B_202E_202D_200C_202C_202E_206E_202E_200D_206D_200E_206A_206D_206D_200C_200C_202A_202B_202E_200E_206E_200E_202D_206B_206D_200E_206E_202A_202D_206F_200F_200F_206F_202D_202E(key, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1185304713u)))
			{
				num = 320708712;
				num9 = num;
			}
			else
			{
				num = 187218175;
				num9 = num;
			}
			continue;
			IL_004e:
			int num10;
			if (_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(name))
			{
				num = 347496043;
				num10 = num;
			}
			else
			{
				num = 310517074;
				num10 = num;
			}
		}
		goto IL_0004;
		IL_0067:
		int num11;
		if (index <= _202D_206E_206C_200D_206C_206D_202E_200D_202A_206F_202B_206C_206E_202B_202D_206F_200F_206D_202A_206C_202E_206E_206B_206E_200F_202B_200C_206D_206B_206E_200B_206C_200D_206C_200C_200D_200B_200B_206E_202E.Count - 1)
		{
			num = 1676552326;
			num11 = num;
		}
		else
		{
			num = 1866844308;
			num11 = num;
		}
		goto IL_0009;
	}

	public string[] GetRoleValues(int index)
	{
		if (index < 0)
		{
			goto IL_0004;
		}
		goto IL_0062;
		IL_0004:
		int num = -939041603;
		goto IL_0009;
		IL_0009:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1694094057)) % 6)
			{
			case 3u:
				break;
			case 4u:
				index = 0;
				num = ((int)num2 * -693880048) ^ -367684613;
				continue;
			case 1u:
				index = _202D_206E_206C_200D_206C_206D_202E_200D_202A_206F_202B_206C_206E_202B_202D_206F_200F_206D_202A_206C_202E_206E_206B_206E_200F_202B_200C_206D_206B_206E_200B_206C_200D_206C_200C_200D_200B_200B_206E_202E.Count - 1;
				num = (int)((num2 * 2147158730) ^ 0x1A2A2FA);
				continue;
			case 0u:
				goto IL_0062;
			case 2u:
				num = (int)(num2 * 368921542) ^ -1322151964;
				continue;
			default:
				return _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(_202D_206E_206C_200D_206C_206D_202E_200D_202A_206F_202B_206C_206E_202B_202D_206F_200F_206D_202A_206C_202E_206E_206B_206E_200F_202B_200C_206D_206B_206E_200B_206C_200D_206C_200C_200D_200B_200B_206E_202E[index], new char[1] { '|' });
			}
			break;
		}
		goto IL_0004;
		IL_0062:
		int num3;
		if (index <= _202D_206E_206C_200D_206C_206D_202E_200D_202A_206F_202B_206C_206E_202B_202D_206F_200F_206D_202A_206C_202E_206E_206B_206E_200F_202B_200C_206D_206B_206E_200B_206C_200D_206C_200C_200D_200B_200B_206E_202E.Count - 1)
		{
			num = -511750868;
			num3 = num;
		}
		else
		{
			num = -1818839528;
			num3 = num;
		}
		goto IL_0009;
	}

	public void AddRealTimeFlag(int index, int maxSeconds)
	{
		KeyValues[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1963850131u) + index] = string.Format(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1842574002u), new TimeSpan(DateTime.Now.Ticks).ToString() + global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2828931079u) + maxSeconds);
	}

	public void RemoveRealTimeFlag(int index)
	{
		string key = global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1963850131u) + index;
		while (true)
		{
			int num = -2001830305;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1353649242)) % 4)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
				{
					int num3;
					int num4;
					if (!KeyValues.ContainsKey(key))
					{
						num3 = -835568256;
						num4 = num3;
					}
					else
					{
						num3 = -934853907;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1076683537);
					continue;
				}
				case 2u:
					KeyValues.Remove(key);
					num = ((int)num2 * -1205217669) ^ 0x359593F;
					continue;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public bool HasRealTimeFlag(int index)
	{
		return KeyValues.ContainsKey(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1887797922u) + index);
	}

	public double GetRealTimeFlagInterval(int index)
	{
		string key = global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3625150802u) + index;
		TimeSpan timeSpan = default(TimeSpan);
		TimeSpan ts = default(TimeSpan);
		while (true)
		{
			int num = -1376481208;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2136669502)) % 7)
				{
				case 4u:
					break;
				case 3u:
					timeSpan = timeSpan.Subtract(ts);
					num = ((int)num2 * -1862259889) ^ 0x23058EE4;
					continue;
				case 6u:
					return timeSpan.TotalSeconds;
				case 0u:
					timeSpan = new TimeSpan(DateTime.Now.Ticks);
					num = ((int)num2 * -1924016575) ^ 0x6E5B63C7;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!KeyValues.ContainsKey(key))
					{
						num3 = 1073956978;
						num4 = num3;
					}
					else
					{
						num3 = 1310132336;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 812419471);
					continue;
				}
				case 1u:
					ts = TimeSpan.Parse(KeyValues[key].Split('#')[0]);
					num = ((int)num2 * -111150152) ^ -684948856;
					continue;
				default:
					return double.MaxValue;
				}
				break;
			}
		}
	}

	public void RemoveTeamMemberPanel(Role role)
	{
		if (role != null)
		{
			goto IL_0006;
		}
		goto IL_00b3;
		IL_0006:
		int num = -1158935307;
		goto IL_000b;
		IL_000b:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1754169463)) % 8)
			{
			case 7u:
				break;
			case 1u:
				return;
			case 2u:
				isTeamPanelRefreshed = 0;
				num = (int)((num2 * 1955611251) ^ 0x66BC172C);
				continue;
			case 0u:
			{
				int num5;
				int num6;
				if (!_200E_202B_202A_200D_202C_200D_200C_202D_206D_200C_206A_200C_206D_200B_200F_206A_200E_206F_202B_200F_206C_202E_206E_206A_206C_200C_202C_206C_206C_200D_202A_202A_200B_206A_200E_202A_206B_206F_202D_202E_202E((Object)(object)mapUI, (Object)null))
				{
					num5 = -1140470729;
					num6 = num5;
				}
				else
				{
					num5 = -1995617404;
					num6 = num5;
				}
				num = num5 ^ ((int)num2 * -1311702497);
				continue;
			}
			case 4u:
			{
				int num3;
				int num4;
				if (!IsInited)
				{
					num3 = -1173801112;
					num4 = num3;
				}
				else
				{
					num3 = -1633684075;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 2005846647);
				continue;
			}
			case 5u:
				goto IL_00b3;
			case 6u:
				goto IL_00c4;
			default:
				mapUI.RolePanel.GetComponent<RolePanelUI>().removeTeam(role);
				return;
			}
			break;
			IL_00c4:
			int num7;
			if (mapUI.TeamPanelObj.GetComponent<TeamPanelUI>().selectMenu.RemoveItem(role))
			{
				num = -1901424374;
				num7 = num;
			}
			else
			{
				num = -1514138037;
				num7 = num;
			}
		}
		goto IL_0006;
		IL_00b3:
		isTeamPanelRefreshed = 0;
		num = -1907832976;
		goto IL_000b;
	}

	public void RefreshTeamMemberPanel(Role role, bool refreshImage, bool refreshText)
	{
		if (role != null)
		{
			while (true)
			{
				int num = 1479182046;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x4371A3B1)) % 7)
					{
					case 5u:
						break;
					case 1u:
						goto end_IL_0003;
					case 4u:
					{
						int num5;
						int num6;
						if (!_200E_202B_202A_200D_202C_200D_200C_202D_206D_200C_206A_200C_206D_200B_200F_206A_200E_206F_202B_200F_206C_202E_206E_206A_206C_200C_202C_206C_206C_200D_202A_202A_200B_206A_200E_202A_206B_206F_202D_202E_202E((Object)(object)mapUI, (Object)null))
						{
							num5 = 569411804;
							num6 = num5;
						}
						else
						{
							num5 = 611237397;
							num6 = num5;
						}
						num = num5 ^ ((int)num2 * -1235074350);
						continue;
					}
					case 3u:
						goto IL_006e;
					case 6u:
					{
						int num3;
						int num4;
						if (!IsInited)
						{
							num3 = -1079244723;
							num4 = num3;
						}
						else
						{
							num3 = -1712371464;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 1655387498);
						continue;
					}
					case 0u:
						isTeamPanelRefreshed = 0;
						num = (int)(num2 * 1409266968) ^ -1269596104;
						continue;
					default:
						mapUI.RolePanel.GetComponent<RolePanelUI>().refreshTeam(role);
						return;
					}
					break;
					IL_006e:
					int num7;
					if (!mapUI.TeamPanelObj.GetComponent<TeamPanelUI>().selectMenu.RefreshItem(role, refreshImage, refreshText, Team.Count))
					{
						num = 762841447;
						num7 = num;
					}
					else
					{
						num = 126407208;
						num7 = num;
					}
				}
				continue;
				end_IL_0003:
				break;
			}
		}
		isTeamPanelRefreshed = 0;
	}

	public void SetTeamMemberPanelIndex(Role role, int index)
	{
		try
		{
			if (role != null)
			{
				goto IL_0006;
			}
			goto IL_00cc;
			IL_0006:
			int num = 882686103;
			goto IL_000b;
			IL_000b:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2360018F)) % 9)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_0044;
				case 8u:
					mapUI.RolePanel.GetComponent<RolePanelUI>().indexTeam(role, index);
					num = 729957014;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (!IsInited)
					{
						num5 = 483916980;
						num6 = num5;
					}
					else
					{
						num5 = 1784237470;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 234101619);
					continue;
				}
				case 7u:
					return;
				case 5u:
					goto IL_00cc;
				case 6u:
				{
					int num3;
					int num4;
					if (_200E_202B_202A_200D_202C_200D_200C_202D_206D_200C_206A_200C_206D_200B_200F_206A_200E_206F_202B_200F_206C_202E_206E_206A_206C_200C_202C_206C_206C_200D_202A_202A_200B_206A_200E_202A_206B_206F_202D_202E_202E((Object)(object)mapUI, (Object)null))
					{
						num3 = 460445316;
						num4 = num3;
					}
					else
					{
						num3 = 301823124;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -990030664);
					continue;
				}
				case 3u:
					isTeamPanelRefreshed = 0;
					num = ((int)num2 * -98018380) ^ -1392621994;
					continue;
				case 2u:
					return;
				}
				break;
				IL_0044:
				int num7;
				if (mapUI.TeamPanelObj.GetComponent<TeamPanelUI>().selectMenu.SetItemIndex(role, index))
				{
					num = 627300766;
					num7 = num;
				}
				else
				{
					num = 1840776949;
					num7 = num;
				}
			}
			goto IL_0006;
			IL_00cc:
			isTeamPanelRefreshed = 0;
			num = 1977844163;
			goto IL_000b;
		}
		catch
		{
			isTeamPanelRefreshed = 0;
		}
	}

	public bool UpdateVerifiedRealTimeFlags(int index, int maxSeconds = 0)
	{
		if (HasRealTimeFlag(index))
		{
			List<int> list = default(List<int>);
			int num4 = default(int);
			int num3 = default(int);
			while (true)
			{
				int num = -603401426;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1992584499)) % 12)
					{
					case 6u:
						break;
					case 5u:
						list = new List<int>();
						num = ((int)num2 * -559711447) ^ 0x74B47497;
						continue;
					case 10u:
					{
						int num9;
						int num10;
						if (maxSeconds > 0)
						{
							num9 = 700958124;
							num10 = num9;
						}
						else
						{
							num9 = 947792565;
							num10 = num9;
						}
						num = num9 ^ ((int)num2 * -799585948);
						continue;
					}
					case 1u:
						num4 = VerifiedRealTimeFlags[index][1];
						num = (int)((num2 * 654042860) ^ 0x77C028C9);
						continue;
					case 4u:
						return true;
					case 2u:
						VerifiedRealTimeFlags[index][0] = num3 + 1;
						return true;
					case 11u:
					{
						int num7;
						int num8;
						if (!VerifiedRealTimeFlags.ContainsKey(index))
						{
							num7 = 866295898;
							num8 = num7;
						}
						else
						{
							num7 = 1098008259;
							num8 = num7;
						}
						num = num7 ^ ((int)num2 * -177816033);
						continue;
					}
					case 9u:
						list.Add(maxSeconds);
						VerifiedRealTimeFlags.Add(index, list);
						num = ((int)num2 * -1681682867) ^ -2008667844;
						continue;
					case 0u:
					{
						int num5;
						int num6;
						if (num3 < num4)
						{
							num5 = 1638218371;
							num6 = num5;
						}
						else
						{
							num5 = 1580694221;
							num6 = num5;
						}
						num = num5 ^ (int)(num2 * 1699373730);
						continue;
					}
					case 7u:
						num3 = VerifiedRealTimeFlags[index][0];
						num = -1213098476;
						continue;
					case 3u:
						list.Add(0);
						num = (int)(num2 * 186839288) ^ -1519951564;
						continue;
					default:
						goto end_IL_000c;
					}
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
		}
		return false;
	}

	public void RemoveVerifiedRealTimeFlags(int index)
	{
		if (index == -1)
		{
			goto IL_0004;
		}
		goto IL_0032;
		IL_0004:
		int num = -988249771;
		goto IL_0009;
		IL_0009:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -669820786)) % 6)
			{
			case 3u:
				break;
			default:
				return;
			case 0u:
				goto IL_0032;
			case 1u:
				VerifiedRealTimeFlags.Remove(index);
				num = (int)((num2 * 1545289830) ^ 0x4FC7D486);
				continue;
			case 5u:
				VerifiedRealTimeFlags.Clear();
				num = ((int)num2 * -2035283039) ^ -1503106433;
				continue;
			case 4u:
				return;
			case 2u:
				return;
			}
			break;
		}
		goto IL_0004;
		IL_0032:
		int num3;
		if (VerifiedRealTimeFlags.ContainsKey(index))
		{
			num = -281291525;
			num3 = num;
		}
		else
		{
			num = -1235492328;
			num3 = num;
		}
		goto IL_0009;
	}

	public bool VerifiedRealTimeFlagOk(int index)
	{
		if (VerifiedRealTimeFlags.ContainsKey(index))
		{
			while (true)
			{
				int num = -2057281505;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -725630350)) % 4)
					{
					case 3u:
						break;
					case 1u:
					{
						int num3;
						int num4;
						if (VerifiedRealTimeFlags[index][0] != VerifiedRealTimeFlags[index][1])
						{
							num3 = 1078782125;
							num4 = num3;
						}
						else
						{
							num3 = 1793762947;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 692411993);
						continue;
					}
					case 0u:
						return true;
					default:
						goto end_IL_000e;
					}
					break;
				}
				continue;
				end_IL_000e:
				break;
			}
		}
		return false;
	}

	public bool ResetVerifiedRealTimeFlags()
	{
		bool result = false;
		int num = 0;
		string key = default(string);
		while (true)
		{
			int num2 = -1339060607;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -478053677)) % 9)
				{
				case 8u:
					break;
				case 1u:
					num2 = (int)(num3 * 1923584009) ^ -1480062920;
					continue;
				case 2u:
				{
					int num7;
					int num8;
					if (!KeyValues.ContainsKey(key))
					{
						num7 = 434893655;
						num8 = num7;
					}
					else
					{
						num7 = 1970985027;
						num8 = num7;
					}
					num2 = num7 ^ (int)(num3 * 103307799);
					continue;
				}
				case 5u:
					key = global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3625150802u) + num;
					num2 = -627032473;
					continue;
				case 4u:
					num++;
					num2 = -405094694;
					continue;
				case 3u:
				{
					int num6;
					if (num >= 50)
					{
						num2 = -1532422984;
						num6 = num2;
					}
					else
					{
						num2 = -1704762849;
						num6 = num2;
					}
					continue;
				}
				case 6u:
					result = true;
					num2 = ((int)num3 * -1125416278) ^ 0x47CB3ABB;
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (UpdateVerifiedRealTimeFlags(num, int.Parse(KeyValues[key].Split('#')[1])))
					{
						num4 = 560187151;
						num5 = num4;
					}
					else
					{
						num4 = 727931335;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num3 * -498901503);
					continue;
				}
				default:
					return result;
				}
				break;
			}
		}
	}

	public ItemInstance GetItemByName(string name)
	{
		using (Dictionary<ItemInstance, int>.Enumerator enumerator = Items.GetEnumerator())
		{
			KeyValuePair<ItemInstance, int> current = default(KeyValuePair<ItemInstance, int>);
			while (true)
			{
				IL_0055:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 1891223053;
					num2 = num;
				}
				else
				{
					num = 1688259257;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x3B1B0658)) % 6)
					{
					case 4u:
						num = 1688259257;
						continue;
					default:
						goto end_IL_0013;
					case 2u:
						return current.Key;
					case 0u:
						break;
					case 3u:
						current = enumerator.Current;
						num = 1321558617;
						continue;
					case 5u:
					{
						int num4;
						int num5;
						if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(current.Key.Name, name))
						{
							num4 = 1610704243;
							num5 = num4;
						}
						else
						{
							num4 = 1513744423;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -57885813);
						continue;
					}
					case 1u:
						goto end_IL_0013;
					}
					goto IL_0055;
					continue;
					end_IL_0013:
					break;
				}
				break;
			}
		}
		return null;
	}

	private int num_encode(int num)
	{
		string text = CRC32.GetCRC32(_202C_202E_200C_206A_200C_202E_202E_206D_202C_200C_200F_206A_206B_202D_202A_206C_206E_200D_206E_202B_206E_202B_200C_200B_202D_200C_200D_202E_200D_202C_206A_206E_202B_200D_200D_206F_202A_206D_206B_202C_202E(num)).ToString();
		try
		{
			return int.Parse(num + text.Substring(text.Length - 3));
		}
		catch
		{
			return 1492;
		}
	}

	internal int num_decode(int num)
	{
		string text = num.ToString();
		int num2 = 0;
		while (true)
		{
			int num3 = -524545035;
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)(num3 ^ -392155273)) % 5)
				{
				case 4u:
					break;
				case 0u:
					num2 = 0;
					num3 = ((int)num4 * -2081082818) ^ 0x78935951;
					continue;
				case 3u:
				{
					string text2 = text.Substring(text.Length - 3);
					num2 = int.Parse(text.Substring(0, text.Length - 3));
					string text3 = CRC32.GetCRC32(BitConverter.GetBytes(num2)).ToString();
					int num7;
					int num8;
					if (!(text3.Substring(text3.Length - 3) != text2))
					{
						num7 = 2052326267;
						num8 = num7;
					}
					else
					{
						num7 = 799394435;
						num8 = num7;
					}
					num3 = num7 ^ (int)(num4 * 2006177206);
					continue;
				}
				case 1u:
				{
					int num5;
					int num6;
					if (text.Length >= 4)
					{
						num5 = -1309271876;
						num6 = num5;
					}
					else
					{
						num5 = -904831497;
						num6 = num5;
					}
					num3 = num5 ^ (int)(num4 * 254446157);
					continue;
				}
				default:
					return num2;
				}
				break;
			}
		}
	}

	public string GetRandomSelect(string storyName)
	{
		if (!_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(storyName))
		{
			string key = default(string);
			while (true)
			{
				int num = 1892577702;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x1A88BF63)) % 4)
					{
					case 0u:
						break;
					case 1u:
					{
						key = _206A_200C_200F_206E_202E_206D_206E_200E_202D_200E_202A_200F_200E_200B_202A_206B_200B_202A_202E_206A_202B_206C_200F_202C_202D_200F_202D_206E_206D_202A_202A_200C_200C_206D_200B_202B_202B_200C_200E_200C_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4203755126u), storyName);
						int num3;
						int num4;
						if (KeyValues.ContainsKey(key))
						{
							num3 = 81484451;
							num4 = num3;
						}
						else
						{
							num3 = 1951009066;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 1123279063);
						continue;
					}
					case 3u:
						return KeyValues[key];
					default:
						goto end_IL_0008;
					}
					break;
				}
				continue;
				end_IL_0008:
				break;
			}
		}
		return string.Empty;
	}

	public void SetRandomSelect(string storyName, string result)
	{
		if (_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(storyName))
		{
			return;
		}
		string text = default(string);
		string key = default(string);
		List<string> list = default(List<string>);
		while (true)
		{
			int num = 789684006;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x480F8845)) % 13)
				{
				case 0u:
					break;
				default:
					return;
				case 5u:
				{
					int num6;
					int num7;
					if (!_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(result))
					{
						num6 = 1900393472;
						num7 = num6;
					}
					else
					{
						num6 = 419843714;
						num7 = num6;
					}
					num = num6 ^ ((int)num2 * -542169524);
					continue;
				}
				case 10u:
					text = KeyValues[key];
					num = ((int)num2 * -1856379102) ^ -1200743109;
					continue;
				case 1u:
				{
					int num8;
					if (!_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(text))
					{
						num = 1786764838;
						num8 = num;
					}
					else
					{
						num = 1478369069;
						num8 = num;
					}
					continue;
				}
				case 8u:
					list = new List<string>(_202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(text, new char[1] { '#' }));
					num = ((int)num2 * -1292520681) ^ 0x1E505F3E;
					continue;
				case 6u:
					key = _206A_200C_200F_206E_202E_206D_206E_200E_202D_200E_202A_200F_200E_200B_202A_206B_200B_202A_202E_206A_202B_206C_200F_202C_202D_200F_202D_206E_206D_202A_202A_200C_200C_206D_200B_202B_202B_200C_200E_200C_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3253850103u), storyName);
					num = ((int)num2 * -449379169) ^ 0x761C63BB;
					continue;
				case 9u:
					list = new List<string>();
					num = 963486939;
					continue;
				case 4u:
					KeyValues[key] = _200D_206D_206B_206A_206A_202E_206E_206A_202A_200F_202E_206D_200B_206E_206A_200C_200B_206F_200E_202D_200E_200C_200E_202E_202B_206B_206F_206C_202E_206B_200C_206D_206C_200D_200B_202A_206C_206B_200B_206D_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2057560981u), list.ToArray());
					num = 1460858342;
					continue;
				case 2u:
					list.Add(result);
					num = ((int)num2 * -1718038327) ^ 0xA0BF39F;
					continue;
				case 11u:
					text = null;
					num = ((int)num2 * -1044411821) ^ -348374811;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (KeyValues.ContainsKey(key))
					{
						num4 = -103802194;
						num5 = num4;
					}
					else
					{
						num4 = -86025699;
						num5 = num4;
					}
					num = num4 ^ (int)(num2 * 563280912);
					continue;
				}
				case 12u:
				{
					int num3;
					if (!list.Contains(result))
					{
						num = 1048828262;
						num3 = num;
					}
					else
					{
						num = 669767652;
						num3 = num;
					}
					continue;
				}
				case 7u:
					return;
				}
				break;
			}
		}
	}

	public List<string> GetManualTemp()
	{
		return _200F_206F_206E_202D_202E_206B_206D_206A_202B_202B_206F_206C_200F_200D_202B_200E_200B_202C_206D_200C_200D_202B_206A_202B_202A_202A_200F_202D_200C_206E_206C_200F_206D_202B_202D_202C_206E_202D_202B_206F_202E;
	}

	public bool AddVerifiedRealTimeFlags()
	{
		bool result = false;
		using (Dictionary<int, List<int>>.KeyCollection.Enumerator enumerator = VerifiedRealTimeFlags.Keys.GetEnumerator())
		{
			int current = default(int);
			while (true)
			{
				IL_0077:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -1486698719;
					num2 = num;
				}
				else
				{
					num = -2048601989;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -1573158448)) % 6)
					{
					case 0u:
						num = -2048601989;
						continue;
					default:
						goto end_IL_001a;
					case 2u:
						result = true;
						num = ((int)num3 * -1036364707) ^ -450828880;
						continue;
					case 5u:
					{
						int num4;
						int num5;
						if (UpdateVerifiedRealTimeFlags(current))
						{
							num4 = -857794994;
							num5 = num4;
						}
						else
						{
							num4 = -40737018;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -338058140);
						continue;
					}
					case 4u:
						break;
					case 1u:
						current = enumerator.Current;
						num = -685658367;
						continue;
					case 3u:
						goto end_IL_001a;
					}
					goto IL_0077;
					continue;
					end_IL_001a:
					break;
				}
				break;
			}
		}
		return result;
	}

	public int GetItemCount(ItemInstance item)
	{
		using (Dictionary<ItemInstance, int>.Enumerator enumerator = Items.GetEnumerator())
		{
			int result = default(int);
			KeyValuePair<ItemInstance, int> current = default(KeyValuePair<ItemInstance, int>);
			while (true)
			{
				IL_0071:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 1725296165;
					num2 = num;
				}
				else
				{
					num = 522365367;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x45CBBB0F)) % 7)
					{
					case 3u:
						num = 1725296165;
						continue;
					default:
						goto end_IL_0013;
					case 4u:
						result = num_decode(current.Value);
						num = ((int)num3 * -56741077) ^ 0x15969EA;
						continue;
					case 6u:
						break;
					case 2u:
					{
						int num4;
						int num5;
						if (current.Key != item)
						{
							num4 = -2146210381;
							num5 = num4;
						}
						else
						{
							num4 = -1023044268;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -253866007);
						continue;
					}
					case 1u:
						current = enumerator.Current;
						num = 409687979;
						continue;
					case 0u:
						goto end_IL_0013;
					case 5u:
						return result;
					}
					goto IL_0071;
					continue;
					end_IL_0013:
					break;
				}
				break;
			}
		}
		return 0;
	}

	public ItemInstance GetItemByName2(string name, bool minAddition = true)
	{
		Dictionary<int, ItemInstance> dictionary = new Dictionary<int, ItemInstance>();
		if (!minAddition)
		{
			goto IL_0009;
		}
		int num = 100;
		goto IL_0031;
		IL_0039:
		int num11 = default(int);
		uint num4;
		using (Dictionary<ItemInstance, int>.Enumerator enumerator = Items.GetEnumerator())
		{
			int count = default(int);
			KeyValuePair<ItemInstance, int> current = default(KeyValuePair<ItemInstance, int>);
			while (true)
			{
				IL_01a8:
				int num2;
				int num3;
				if (!enumerator.MoveNext())
				{
					num2 = 508798297;
					num3 = num2;
				}
				else
				{
					num2 = 499344951;
					num3 = num2;
				}
				while (true)
				{
					switch ((num4 = (uint)(num2 ^ 0x24A089E4)) % 13)
					{
					case 10u:
						num2 = 499344951;
						continue;
					default:
						goto end_IL_004f;
					case 5u:
						num11 = count;
						num2 = ((int)num4 * -1427205315) ^ 0x8766951;
						continue;
					case 1u:
					{
						int num7;
						int num8;
						if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(current.Key.Name, name))
						{
							num7 = -1317701930;
							num8 = num7;
						}
						else
						{
							num7 = -2119945005;
							num8 = num7;
						}
						num2 = num7 ^ (int)(num4 * 1561021168);
						continue;
					}
					case 12u:
						current = enumerator.Current;
						num2 = 188388089;
						continue;
					case 3u:
					{
						int num14;
						if (count > num11)
						{
							num2 = 907151075;
							num14 = num2;
						}
						else
						{
							num2 = 1579874787;
							num14 = num2;
						}
						continue;
					}
					case 8u:
					{
						dictionary.Add(count, current.Key);
						int num9;
						int num10;
						if (!minAddition)
						{
							num9 = 992417485;
							num10 = num9;
						}
						else
						{
							num9 = 1093075500;
							num10 = num9;
						}
						num2 = num9 ^ (int)(num4 * 1171545609);
						continue;
					}
					case 2u:
					{
						int num12;
						int num13;
						if (count >= num11)
						{
							num12 = 510496115;
							num13 = num12;
						}
						else
						{
							num12 = 70643277;
							num13 = num12;
						}
						num2 = num12 ^ (int)(num4 * 1960598666);
						continue;
					}
					case 6u:
						count = current.Key.AdditionTriggers.Count;
						num2 = (int)(num4 * 471088825) ^ -79536620;
						continue;
					case 11u:
						num2 = ((int)num4 * -1974909860) ^ -37120413;
						continue;
					case 0u:
						num11 = count;
						num2 = (int)((num4 * 595368004) ^ 0x6694DC3F);
						continue;
					case 4u:
						break;
					case 9u:
					{
						int num5;
						int num6;
						if (dictionary.ContainsKey(count))
						{
							num5 = -1752652979;
							num6 = num5;
						}
						else
						{
							num5 = -1124703190;
							num6 = num5;
						}
						num2 = num5 ^ ((int)num4 * -1450865769);
						continue;
					}
					case 7u:
						goto end_IL_004f;
					}
					goto IL_01a8;
					continue;
					end_IL_004f:
					break;
				}
				break;
			}
		}
		if (dictionary.Count > 0)
		{
			while (true)
			{
				switch ((num4 = 1223491076u) % 3)
				{
				case 0u:
					continue;
				case 2u:
					return dictionary[num11];
				}
				break;
			}
		}
		return null;
		IL_0009:
		int num15 = 658013486;
		goto IL_000e;
		IL_000e:
		switch ((num4 = (uint)(num15 ^ 0x24A089E4)) % 3)
		{
		case 0u:
			break;
		case 1u:
			goto IL_002c;
		default:
			goto IL_0039;
		}
		goto IL_0009;
		IL_002c:
		num = -1;
		goto IL_0031;
		IL_0031:
		num11 = num;
		num15 = 749061764;
		goto IL_000e;
	}

	public string CopyToString(string name)
	{
		return null;
	}

	public int GetItemsCount(string name)
	{
		int num = 0;
		using (Dictionary<ItemInstance, int>.Enumerator enumerator = Items.GetEnumerator())
		{
			KeyValuePair<ItemInstance, int> current = default(KeyValuePair<ItemInstance, int>);
			while (true)
			{
				IL_0086:
				int num2;
				int num3;
				if (!enumerator.MoveNext())
				{
					num2 = 1499357211;
					num3 = num2;
				}
				else
				{
					num2 = 106382239;
					num3 = num2;
				}
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)(num2 ^ 0x58FA6CF8)) % 5)
					{
					case 0u:
						num2 = 106382239;
						continue;
					default:
						goto end_IL_0015;
					case 2u:
					{
						current = enumerator.Current;
						int num5;
						if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(current.Key.Name, name))
						{
							num2 = 1554638223;
							num5 = num2;
						}
						else
						{
							num2 = 2029633871;
							num5 = num2;
						}
						continue;
					}
					case 3u:
						num += num_decode(current.Value);
						num2 = (int)((num4 * 133994313) ^ 0x6CF2A2A0);
						continue;
					case 1u:
						break;
					case 4u:
						goto end_IL_0015;
					}
					goto IL_0086;
					continue;
					end_IL_0015:
					break;
				}
				break;
			}
		}
		return num;
	}

	public bool AddTitle(string name)
	{
		string[] array = _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(name, new char[1] { '#' });
		Role role = default(Role);
		Title title = default(Title);
		TitleInstance current = default(TitleInstance);
		TitleInstance titleInstance2 = default(TitleInstance);
		while (true)
		{
			int num = -446635720;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -916135931)) % 6)
				{
				case 4u:
					break;
				case 5u:
					if (array.Length >= 2)
					{
						num = ((int)num2 * -774103231) ^ 0x15AFF6E;
						continue;
					}
					goto IL_0389;
				case 2u:
					role = GetRole(array[0]);
					num = (int)((num2 * 1168460887) ^ 0x295DEF11);
					continue;
				case 3u:
					if (title != null)
					{
						num = ((int)num2 * -1044568502) ^ 0x139D4B96;
						continue;
					}
					goto IL_0389;
				case 0u:
					title = ResourceManager.Get<Title>(array[1]);
					if (role != null)
					{
						num = (int)((num2 * 1865284019) ^ 0x43FED61E);
						continue;
					}
					goto IL_0389;
				default:
					{
						TitleInstance titleInstance = null;
						using (List<TitleInstance>.Enumerator enumerator = role.Titles.GetEnumerator())
						{
							while (true)
							{
								IL_00ec:
								int num3;
								int num4;
								if (enumerator.MoveNext())
								{
									num3 = -1514810480;
									num4 = num3;
								}
								else
								{
									num3 = -2033204697;
									num4 = num3;
								}
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ -916135931)) % 6)
									{
									case 3u:
										num3 = -1514810480;
										continue;
									default:
										goto end_IL_00c2;
									case 5u:
										break;
									case 4u:
										goto end_IL_00c2;
									case 2u:
										titleInstance = current;
										num3 = ((int)num2 * -141347013) ^ -1070743735;
										continue;
									case 1u:
									{
										current = enumerator.Current;
										int num5;
										if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(current.Name, title.Name))
										{
											num3 = -1820983077;
											num5 = num3;
										}
										else
										{
											num3 = -1026982554;
											num5 = num3;
										}
										continue;
									}
									case 0u:
										goto end_IL_00c2;
									}
									goto IL_00ec;
									continue;
									end_IL_00c2:
									break;
								}
								break;
							}
						}
						if (titleInstance == null)
						{
							while (true)
							{
								int num6 = -1517783941;
								while (true)
								{
									int num9;
									int num12;
									switch ((num2 = (uint)(num6 ^ -916135931)) % 8)
									{
									case 0u:
										break;
									case 6u:
										titleInstance2 = new TitleInstance
										{
											name = title.Name,
											Owner = role,
											equipped = ((role.Titles.Count == 0) ? 1 : 0)
										};
										num6 = -1636214521;
										continue;
									case 5u:
										role.EquippedTitle = titleInstance2;
										goto IL_034c;
									case 7u:
										if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(array[2], global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(727785707u)))
										{
											num6 = (int)(num2 * 1071013859) ^ -1328593268;
											continue;
										}
										goto IL_034c;
									case 1u:
									{
										int num10;
										int num11;
										if (titleInstance2.equipped > 0)
										{
											num10 = -1022931866;
											num11 = num10;
										}
										else
										{
											num10 = -1638815920;
											num11 = num10;
										}
										num6 = num10 ^ ((int)num2 * -2038051506);
										continue;
									}
									case 2u:
										role.Titles.Add(titleInstance2);
										num6 = ((int)num2 * -1399903768) ^ -622800060;
										continue;
									case 3u:
										if (array.Length >= 3)
										{
											num6 = -1613952414;
											continue;
										}
										goto IL_034c;
									default:
										{
											using (List<TitleInstance>.Enumerator enumerator = role.Titles.GetEnumerator())
											{
												while (true)
												{
													IL_02d2:
													int num7;
													int num8;
													if (!enumerator.MoveNext())
													{
														num7 = -2081681826;
														num8 = num7;
													}
													else
													{
														num7 = -1845009340;
														num8 = num7;
													}
													while (true)
													{
														switch ((num2 = (uint)(num7 ^ -916135931)) % 4)
														{
														case 2u:
															num7 = -1845009340;
															continue;
														default:
															goto end_IL_029c;
														case 1u:
															enumerator.Current.equipped = 0;
															num7 = -1847771035;
															continue;
														case 0u:
															break;
														case 3u:
															goto end_IL_029c;
														}
														goto IL_02d2;
														continue;
														end_IL_029c:
														break;
													}
													break;
												}
											}
											titleInstance2.equipped = 1;
											goto IL_0304;
										}
										IL_0309:
										while (true)
										{
											switch ((num2 = (uint)(num9 ^ -916135931)) % 6)
											{
											case 4u:
												break;
											case 0u:
												RefreshTeamMemberPanel(role, refreshImage: false, refreshText: true);
												num9 = ((int)num2 * -1044351103) ^ -273727683;
												continue;
											case 3u:
												goto IL_034c;
											case 2u:
												return true;
											case 5u:
												role.EquippedTitle = titleInstance2;
												num9 = (int)(num2 * 25072361) ^ -230254061;
												continue;
											default:
												goto end_IL_0172;
											}
											break;
										}
										goto IL_0304;
										IL_0304:
										num9 = -201361680;
										goto IL_0309;
										IL_034c:
										if (InTeamOnly(array[0]))
										{
											num9 = -2131907351;
											num12 = num9;
										}
										else
										{
											num9 = -1839314479;
											num12 = num9;
										}
										goto IL_0309;
									}
									break;
								}
								continue;
								end_IL_0172:
								break;
							}
						}
						goto IL_0389;
					}
					IL_0389:
					return false;
				}
				break;
			}
		}
	}

	public bool RemoveTitle(string name)
	{
		string[] array = _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(name, new char[1] { '#' });
		Role role = GetRole(array[0]);
		TitleInstance titleInstance = default(TitleInstance);
		TitleInstance current = default(TitleInstance);
		while (true)
		{
			int num = -846961867;
			while (true)
			{
				int num7;
				int num8;
				uint num2;
				int num11;
				switch ((num2 = (uint)(num ^ -191257900)) % 6)
				{
				case 2u:
					break;
				case 1u:
					role.Titles.Clear();
					role.EquippedTitle = null;
					num = (int)(num2 * 346745023) ^ -9484473;
					continue;
				case 3u:
					if (role != null)
					{
						num = ((int)num2 * -531911720) ^ 0x4B127621;
						continue;
					}
					goto IL_024e;
				case 5u:
				{
					int num9;
					int num10;
					if (array.Length > 1)
					{
						num9 = -1326389501;
						num10 = num9;
					}
					else
					{
						num9 = -1771014958;
						num10 = num9;
					}
					num = num9 ^ (int)(num2 * 1666264847);
					continue;
				}
				default:
				{
					titleInstance = null;
					using (List<TitleInstance>.Enumerator enumerator = role.Titles.GetEnumerator())
					{
						while (true)
						{
							IL_010f:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -1326683713;
								num4 = num3;
							}
							else
							{
								num3 = -1103203470;
								num4 = num3;
							}
							while (true)
							{
								switch ((num2 = (uint)(num3 ^ -191257900)) % 6)
								{
								case 2u:
									num3 = -1103203470;
									continue;
								default:
									goto end_IL_00d0;
								case 1u:
									titleInstance = current;
									goto end_IL_00d0;
								case 5u:
									break;
								case 4u:
									current = enumerator.Current;
									num3 = -255712312;
									continue;
								case 0u:
								{
									int num5;
									int num6;
									if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(current.Name, array[1]))
									{
										num5 = 27135101;
										num6 = num5;
									}
									else
									{
										num5 = 1624894283;
										num6 = num5;
									}
									num3 = num5 ^ (int)(num2 * 1871510574);
									continue;
								}
								case 3u:
									goto end_IL_00d0;
								}
								goto IL_010f;
								continue;
								end_IL_00d0:
								break;
							}
							break;
						}
					}
					if (titleInstance == null)
					{
						goto IL_017d;
					}
					goto IL_0224;
				}
				case 0u:
					goto IL_01b7;
					IL_017d:
					num7 = -1354718194;
					goto IL_0182;
					IL_0224:
					role.Titles.Remove(titleInstance);
					if (role.EquippedTitle != titleInstance)
					{
						num7 = -1850601896;
						num8 = num7;
					}
					else
					{
						num7 = -1530184870;
						num8 = num7;
					}
					goto IL_0182;
					IL_0182:
					while (true)
					{
						switch ((num2 = (uint)(num7 ^ -191257900)) % 8)
						{
						case 7u:
							break;
						case 4u:
							goto IL_01b7;
						case 3u:
							RefreshTeamMemberPanel(role, refreshImage: false, refreshText: true);
							num7 = ((int)num2 * -655132125) ^ -1931449763;
							continue;
						case 2u:
							return false;
						case 6u:
							role.EquippedTitle = null;
							num7 = (int)((num2 * 1407956716) ^ 0x55188CB0);
							continue;
						case 0u:
							return true;
						case 1u:
							goto IL_0224;
						default:
							goto IL_024e;
						}
						break;
					}
					goto IL_017d;
					IL_01b7:
					if (!InTeamOnly(array[0]))
					{
						num7 = -1038983612;
						num11 = num7;
					}
					else
					{
						num7 = -1275239353;
						num11 = num7;
					}
					goto IL_0182;
					IL_024e:
					return false;
				}
				break;
			}
		}
	}

	public string GetSkillName(string name)
	{
		List<string> list = new List<string>();
		IEnumerator<Skill> enumerator = ResourceManager.GetAll<Skill>().GetEnumerator();
		try
		{
			while (_200C_202A_206C_202A_200E_206A_202B_206F_206A_202E_202E_200B_200D_206B_202C_200E_200D_202E_206F_202C_202B_206D_202A_202B_206D_200F_200C_206B_206D_200B_202D_202E_200F_206C_206C_206B_202E_206D_202D_206E_202E((IEnumerator)enumerator))
			{
				Skill current = enumerator.Current;
				using List<UniqueSkill>.Enumerator enumerator2 = current.UniqueSkills.GetEnumerator();
				while (true)
				{
					IL_00cc:
					int num;
					int num2;
					if (enumerator2.MoveNext())
					{
						num = 1595356623;
						num2 = num;
					}
					else
					{
						num = 1504546571;
						num2 = num;
					}
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num ^ 0x665AD822)) % 6)
						{
						case 2u:
							num = 1595356623;
							continue;
						default:
							goto end_IL_0033;
						case 5u:
						{
							int num6;
							if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(enumerator2.Current.Name, name))
							{
								num = 759652316;
								num6 = num;
							}
							else
							{
								num = 1794224682;
								num6 = num;
							}
							continue;
						}
						case 1u:
							list.Add(current.Name);
							num = ((int)num3 * -627962857) ^ 0x741FECF;
							continue;
						case 4u:
						{
							int num4;
							int num5;
							if (!list.Contains(current.Name))
							{
								num4 = 768397201;
								num5 = num4;
							}
							else
							{
								num4 = 1287439866;
								num5 = num4;
							}
							num = num4 ^ ((int)num3 * -741628904);
							continue;
						}
						case 0u:
							break;
						case 3u:
							goto end_IL_0033;
						}
						goto IL_00cc;
						continue;
						end_IL_0033:
						break;
					}
					break;
				}
			}
		}
		finally
		{
			if (enumerator != null)
			{
				while (true)
				{
					IL_0109:
					int num7 = 161589711;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num7 ^ 0x665AD822)) % 3)
						{
						case 0u:
							break;
						default:
							goto end_IL_010e;
						case 1u:
							goto IL_012c;
						case 2u:
							goto end_IL_010e;
						}
						goto IL_0109;
						IL_012c:
						_206D_200E_206E_206E_206A_206B_206B_202E_206F_200F_202D_202D_200B_202E_206F_200B_202A_206B_200D_206B_206B_200C_200B_206B_200F_202C_202C_206F_206A_206F_206E_202B_206B_206C_202C_206C_200F_200B_200F_202E_202E((IDisposable)enumerator);
						num7 = ((int)num3 * -1213418942) ^ -1141451830;
						continue;
						end_IL_010e:
						break;
					}
					break;
				}
			}
		}
		IEnumerator<InternalSkill> enumerator3 = ResourceManager.GetAll<InternalSkill>().GetEnumerator();
		try
		{
			while (_200C_202A_206C_202A_200E_206A_202B_206F_206A_202E_202E_200B_200D_206B_202C_200E_200D_202E_206F_202C_202B_206D_202A_202B_206D_200F_200C_206B_206D_200B_202D_202E_200F_206C_206C_206B_202E_206D_202D_206E_202E((IEnumerator)enumerator3))
			{
				InternalSkill current2;
				while (true)
				{
					current2 = enumerator3.Current;
					int num8 = 323662824;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num8 ^ 0x665AD822)) % 3)
						{
						case 0u:
							num8 = 1913934252;
							continue;
						case 2u:
							break;
						default:
							goto end_IL_0177;
						}
						break;
					}
					continue;
					end_IL_0177:
					break;
				}
				using List<UniqueSkill>.Enumerator enumerator2 = current2.UniqueSkills.GetEnumerator();
				while (true)
				{
					IL_020e:
					int num9;
					int num10;
					if (enumerator2.MoveNext())
					{
						num9 = 460384783;
						num10 = num9;
					}
					else
					{
						num9 = 628546997;
						num10 = num9;
					}
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num9 ^ 0x665AD822)) % 6)
						{
						case 5u:
							num9 = 460384783;
							continue;
						default:
							goto end_IL_019b;
						case 0u:
							list.Add(current2.Name);
							num9 = ((int)num3 * -2139356685) ^ -526919654;
							continue;
						case 2u:
						{
							int num12;
							int num13;
							if (!list.Contains(current2.Name))
							{
								num12 = -1055855922;
								num13 = num12;
							}
							else
							{
								num12 = -1254163518;
								num13 = num12;
							}
							num9 = num12 ^ (int)(num3 * 82709113);
							continue;
						}
						case 4u:
							break;
						case 1u:
						{
							int num11;
							if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(enumerator2.Current.Name, name))
							{
								num9 = 1634580260;
								num11 = num9;
							}
							else
							{
								num9 = 1445154324;
								num11 = num9;
							}
							continue;
						}
						case 3u:
							goto end_IL_019b;
						}
						goto IL_020e;
						continue;
						end_IL_019b:
						break;
					}
					break;
				}
			}
		}
		finally
		{
			if (enumerator3 != null)
			{
				while (true)
				{
					IL_0275:
					int num14 = 265546893;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num14 ^ 0x665AD822)) % 3)
						{
						case 2u:
							break;
						default:
							goto end_IL_027a;
						case 1u:
							goto IL_0298;
						case 0u:
							goto end_IL_027a;
						}
						goto IL_0275;
						IL_0298:
						_206D_200E_206E_206E_206A_206B_206B_202E_206F_200F_202D_202D_200B_202E_206F_200B_202A_206B_200D_206B_206B_200C_200B_206B_200F_202C_202C_206F_206A_206F_206E_202B_206B_206C_202C_206C_200F_200B_200F_202E_202E((IDisposable)enumerator3);
						num14 = (int)(num3 * 1692170235) ^ -67632496;
						continue;
						end_IL_027a:
						break;
					}
					break;
				}
			}
		}
		IEnumerator<Aoyi> enumerator4 = ResourceManager.GetAll<Aoyi>().GetEnumerator();
		try
		{
			Aoyi current3 = default(Aoyi);
			UniqueSkill current5 = default(UniqueSkill);
			UniqueSkill current7 = default(UniqueSkill);
			while (true)
			{
				IL_069d:
				if (_200C_202A_206C_202A_200E_206A_202B_206F_206A_202E_202E_200B_200D_206B_202C_200E_200D_202E_206F_202C_202B_206D_202A_202B_206D_200F_200C_206B_206D_200B_202D_202E_200F_206C_206C_206B_202E_206D_202D_206E_202E((IEnumerator)enumerator4))
				{
					while (true)
					{
						current3 = enumerator4.Current;
						if (!_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(current3.Name, name))
						{
							break;
						}
						int num15 = 363665611;
						while (true)
						{
							uint num3;
							switch ((num3 = (uint)(num15 ^ 0x665AD822)) % 4)
							{
							case 3u:
								num15 = 930125516;
								continue;
							case 2u:
								break;
							case 1u:
								goto IL_030a;
							default:
								goto IL_032b;
							}
							break;
							IL_030a:
							if (ResourceManager.Get<Skill>(current3.start) == null)
							{
								num15 = ((int)num3 * -2026042776) ^ -1475206486;
								continue;
							}
							goto IL_064a;
						}
						continue;
						IL_032b:
						enumerator = ResourceManager.GetAll<Skill>().GetEnumerator();
						try
						{
							while (_200C_202A_206C_202A_200E_206A_202B_206F_206A_202E_202E_200B_200D_206B_202C_200E_200D_202E_206F_202C_202B_206D_202A_202B_206D_200F_200C_206B_206D_200B_202D_202E_200F_206C_206C_206B_202E_206D_202D_206E_202E((IEnumerator)enumerator))
							{
								Skill current4;
								while (true)
								{
									current4 = enumerator.Current;
									int num16 = 1342258836;
									while (true)
									{
										uint num3;
										switch ((num3 = (uint)(num16 ^ 0x665AD822)) % 3)
										{
										case 0u:
											num16 = 744436112;
											continue;
										case 1u:
											break;
										default:
											goto end_IL_035e;
										}
										break;
									}
									continue;
									end_IL_035e:
									break;
								}
								using List<UniqueSkill>.Enumerator enumerator2 = current4.UniqueSkills.GetEnumerator();
								while (true)
								{
									IL_0420:
									int num17;
									int num18;
									if (enumerator2.MoveNext())
									{
										num17 = 1839463747;
										num18 = num17;
									}
									else
									{
										num17 = 80669331;
										num18 = num17;
									}
									while (true)
									{
										uint num3;
										switch ((num3 = (uint)(num17 ^ 0x665AD822)) % 6)
										{
										case 0u:
											num17 = 1839463747;
											continue;
										default:
											goto end_IL_0384;
										case 1u:
										{
											current5 = enumerator2.Current;
											int num21;
											if (!_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(current5.Name, current3.start))
											{
												num17 = 1594631182;
												num21 = num17;
											}
											else
											{
												num17 = 2100095552;
												num21 = num17;
											}
											continue;
										}
										case 3u:
											list.Add(_200C_200E_206C_200D_200F_202B_206B_202A_206E_202D_202E_206D_202A_202E_206D_206B_200D_202A_200D_202B_200B_206E_206B_206F_202D_206E_206F_206D_206C_202A_206C_202A_200E_200B_200E_206F_206C_200E_202E_202A_202E(current4.Name, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2303469568u), current5.Name, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2596997961u)));
											num17 = ((int)num3 * -1288051677) ^ 0x4A355139;
											continue;
										case 4u:
											break;
										case 2u:
										{
											int num19;
											int num20;
											if (!list.Contains(current5.Name))
											{
												num19 = -1273231979;
												num20 = num19;
											}
											else
											{
												num19 = -1510483868;
												num20 = num19;
											}
											num17 = num19 ^ (int)(num3 * 1132885061);
											continue;
										}
										case 5u:
											goto end_IL_0384;
										}
										goto IL_0420;
										continue;
										end_IL_0384:
										break;
									}
									break;
								}
							}
						}
						finally
						{
							if (enumerator != null)
							{
								while (true)
								{
									IL_0489:
									int num22 = 265004265;
									while (true)
									{
										uint num3;
										switch ((num3 = (uint)(num22 ^ 0x665AD822)) % 3)
										{
										case 2u:
											break;
										default:
											goto end_IL_048e;
										case 1u:
											goto IL_04ac;
										case 0u:
											goto end_IL_048e;
										}
										goto IL_0489;
										IL_04ac:
										_206D_200E_206E_206E_206A_206B_206B_202E_206F_200F_202D_202D_200B_202E_206F_200B_202A_206B_200D_206B_206B_200C_200B_206B_200F_202C_202C_206F_206A_206F_206E_202B_206B_206C_202C_206C_200F_200B_200F_202E_202E((IDisposable)enumerator);
										num22 = ((int)num3 * -715923392) ^ 0x70D4074A;
										continue;
										end_IL_048e:
										break;
									}
									break;
								}
							}
						}
						enumerator3 = ResourceManager.GetAll<InternalSkill>().GetEnumerator();
						try
						{
							while (_200C_202A_206C_202A_200E_206A_202B_206F_206A_202E_202E_200B_200D_206B_202C_200E_200D_202E_206F_202C_202B_206D_202A_202B_206D_200F_200C_206B_206D_200B_202D_202E_200F_206C_206C_206B_202E_206D_202D_206E_202E((IEnumerator)enumerator3))
							{
								InternalSkill current6 = enumerator3.Current;
								using List<UniqueSkill>.Enumerator enumerator2 = current6.UniqueSkills.GetEnumerator();
								while (true)
								{
									IL_0532:
									int num23;
									int num24;
									if (!enumerator2.MoveNext())
									{
										num23 = 1349212884;
										num24 = num23;
									}
									else
									{
										num23 = 1218365102;
										num24 = num23;
									}
									while (true)
									{
										uint num3;
										switch ((num3 = (uint)(num23 ^ 0x665AD822)) % 7)
										{
										case 4u:
											num23 = 1218365102;
											continue;
										default:
											goto end_IL_04f1;
										case 5u:
											current7 = enumerator2.Current;
											num23 = 1245379986;
											continue;
										case 6u:
											break;
										case 3u:
										{
											int num27;
											int num28;
											if (!list.Contains(current7.Name))
											{
												num27 = 1441061755;
												num28 = num27;
											}
											else
											{
												num27 = 1481596966;
												num28 = num27;
											}
											num23 = num27 ^ ((int)num3 * -1534447813);
											continue;
										}
										case 0u:
										{
											int num25;
											int num26;
											if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(current7.Name, current3.start))
											{
												num25 = 955039287;
												num26 = num25;
											}
											else
											{
												num25 = 796963089;
												num26 = num25;
											}
											num23 = num25 ^ ((int)num3 * -218834467);
											continue;
										}
										case 2u:
											list.Add(_200C_200E_206C_200D_200F_202B_206B_202A_206E_202D_202E_206D_202A_202E_206D_206B_200D_202A_200D_202B_200B_206E_206B_206F_202D_206E_206F_206D_206C_202A_206C_202A_200E_200B_200E_206F_206C_200E_202E_202A_202E(current6.Name, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1690987169u), current7.Name, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2723692654u)));
											num23 = (int)(num3 * 1819926481) ^ -1859803873;
											continue;
										case 1u:
											goto end_IL_04f1;
										}
										goto IL_0532;
										continue;
										end_IL_04f1:
										break;
									}
									break;
								}
							}
						}
						finally
						{
							if (enumerator3 != null)
							{
								while (true)
								{
									IL_060f:
									int num29 = 138161394;
									while (true)
									{
										uint num3;
										switch ((num3 = (uint)(num29 ^ 0x665AD822)) % 3)
										{
										case 0u:
											break;
										default:
											goto end_IL_0614;
										case 1u:
											goto IL_0632;
										case 2u:
											goto end_IL_0614;
										}
										goto IL_060f;
										IL_0632:
										_206D_200E_206E_206E_206A_206B_206B_202E_206F_200F_202D_202D_200B_202E_206F_200B_202A_206B_200D_206B_206B_200C_200B_206B_200F_202C_202C_206F_206A_206F_206E_202B_206B_206C_202C_206C_200F_200B_200F_202E_202E((IDisposable)enumerator3);
										num29 = ((int)num3 * -467984862) ^ -1863553551;
										continue;
										end_IL_0614:
										break;
									}
									break;
								}
							}
						}
						break;
					}
					continue;
				}
				int num30 = 263264356;
				goto IL_065e;
				IL_0659:
				num30 = 1575052791;
				goto IL_065e;
				IL_065e:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num30 ^ 0x665AD822)) % 4)
					{
					case 0u:
						break;
					default:
						goto end_IL_069d;
					case 1u:
						list.Add(current3.start);
						num30 = (int)(num3 * 1864168755) ^ -1009274950;
						continue;
					case 3u:
						goto IL_069d;
					case 2u:
						goto end_IL_069d;
					}
					break;
				}
				goto IL_0659;
				IL_064a:
				if (list.Contains(current3.start))
				{
					continue;
				}
				goto IL_0659;
				continue;
				end_IL_069d:
				break;
			}
		}
		finally
		{
			if (enumerator4 != null)
			{
				while (true)
				{
					IL_06b6:
					int num31 = 1209464106;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num31 ^ 0x665AD822)) % 3)
						{
						case 0u:
							break;
						default:
							goto end_IL_06bb;
						case 1u:
							goto IL_06d9;
						case 2u:
							goto end_IL_06bb;
						}
						goto IL_06b6;
						IL_06d9:
						_206D_200E_206E_206E_206A_206B_206B_202E_206F_200F_202D_202D_200B_202E_206F_200B_202A_206B_200D_206B_206B_200C_200B_206B_200F_202C_202C_206F_206A_206F_206E_202B_206B_206C_202C_206C_200F_200B_200F_202E_202E((IDisposable)enumerator4);
						num31 = (int)(num3 * 167407910) ^ -1273274820;
						continue;
						end_IL_06bb:
						break;
					}
					break;
				}
			}
		}
		if (list.Count == 0)
		{
			while (true)
			{
				int num32 = 360806476;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num32 ^ 0x665AD822)) % 5)
					{
					case 2u:
						break;
					case 1u:
						list.Add(name);
						num32 = 73581238;
						continue;
					case 0u:
					{
						int num35;
						int num36;
						if (ResourceManager.Get<InternalSkill>(name) == null)
						{
							num35 = 1707366502;
							num36 = num35;
						}
						else
						{
							num35 = 907496336;
							num36 = num35;
						}
						num32 = num35 ^ (int)(num3 * 938743928);
						continue;
					}
					case 4u:
					{
						int num33;
						int num34;
						if (ResourceManager.Get<Skill>(name) != null)
						{
							num33 = -1177210866;
							num34 = num33;
						}
						else
						{
							num33 = -1261693334;
							num34 = num33;
						}
						num32 = num33 ^ ((int)num3 * -367736047);
						continue;
					}
					default:
						goto end_IL_06f9;
					}
					break;
				}
				continue;
				end_IL_06f9:
				break;
			}
		}
		return _200D_206D_206B_206A_206A_202E_206E_206A_202A_200F_202E_206D_200B_206E_206A_200C_200B_206F_200E_202D_200E_200C_200E_202E_202B_206B_206F_206C_202E_206B_200C_206D_206C_200D_200B_202A_206C_206B_200B_206D_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(673332574u), list.ToArray());
	}

	public double getHaogan2(string key)
	{
		if (_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(key))
		{
			goto IL_0008;
		}
		goto IL_0068;
		IL_0008:
		int num = 784913181;
		goto IL_000d;
		IL_000d:
		string key2 = default(string);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x4E7BB260)) % 6)
			{
			case 2u:
				break;
			case 5u:
				return 0.0;
			case 4u:
				return 0.0;
			case 0u:
				goto IL_0068;
			case 1u:
			{
				int num3;
				int num4;
				if (!KeyValues.ContainsKey(key2))
				{
					num3 = 1542448154;
					num4 = num3;
				}
				else
				{
					num3 = 828416063;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -1433791988);
				continue;
			}
			default:
				return double.Parse(KeyValues[key2]);
			}
			break;
		}
		goto IL_0008;
		IL_0068:
		key2 = _206A_200C_200F_206E_202E_206D_206E_200E_202D_200E_202A_200F_200E_200B_202A_206B_200B_202A_202E_206A_202B_206C_200F_202C_202D_200F_202D_206E_206D_202A_202A_200C_200C_206D_200B_202B_202B_200C_200E_200C_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3559026366u), key);
		num = 543467403;
		goto IL_000d;
	}

	public void addHaogan2(string value, string key, int round = -1)
	{
		if (_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(key))
		{
			goto IL_000b;
		}
		goto IL_00e1;
		IL_000b:
		int num = 838454034;
		goto IL_0010;
		IL_0010:
		double num6 = default(double);
		string key2 = default(string);
		double num3 = default(double);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x583AA989)) % 20)
			{
			case 15u:
				break;
			default:
				return;
			case 4u:
				return;
			case 2u:
				num = (int)((num2 * 1258777090) ^ 0x49175D24);
				continue;
			case 8u:
				num6 = 0.0;
				num = ((int)num2 * -936561368) ^ -596226837;
				continue;
			case 5u:
				key2 = _206A_200C_200F_206E_202E_206D_206E_200E_202D_200E_202A_200F_200E_200B_202A_206B_200B_202A_202E_206A_202B_206C_200F_202C_202D_200F_202D_206E_206D_202A_202A_200C_200C_206D_200B_202B_202B_200C_200E_200C_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3893308878u), key);
				num = 1290802095;
				continue;
			case 3u:
				return;
			case 13u:
				goto IL_00e1;
			case 16u:
				num6 *= num3;
				num = (int)((num2 * 1849581569) ^ 0x2DDB27E5);
				continue;
			case 0u:
				num = ((int)num2 * -2143556057) ^ 0x5F6769F6;
				continue;
			case 9u:
				KeyValues[key2] = num6.ToString();
				num = 1573735117;
				continue;
			case 1u:
				goto IL_015f;
			case 14u:
				num6 += num3;
				num = 651592018;
				continue;
			case 19u:
				num6 /= num3;
				num = (int)(num2 * 1266741757) ^ -1566624055;
				continue;
			case 11u:
				goto IL_01a9;
			case 17u:
				num6 = (double)_206A_202A_200E_202C_202A_200E_202C_202E_200B_202C_206C_200D_202E_206D_200F_206C_202A_206F_202D_206A_206F_200C_202E_200E_202D_202E_206D_200D_202D_206B_206D_200F_200B_202E_200D_200D_202A_206F_206C_206F_202E((decimal)num6, round, MidpointRounding.AwayFromZero);
				num = ((int)num2 * -588691388) ^ 0x5EAF134;
				continue;
			case 18u:
			{
				int num9;
				int num10;
				if (num3 == 0.0)
				{
					num9 = -912891540;
					num10 = num9;
				}
				else
				{
					num9 = -1370880190;
					num10 = num9;
				}
				num = num9 ^ (int)(num2 * 33560877);
				continue;
			}
			case 7u:
			{
				int num7;
				int num8;
				if (!_202A_206C_206B_206F_200C_206D_202E_202C_206D_200C_206B_200F_200E_206E_206A_206E_206D_202B_206F_206C_202E_206E_202D_206E_200D_206E_202C_200D_200D_202A_200C_206D_206B_202D_200B_206A_200D_200B_200B_202A_202E(value, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4274380279u)))
				{
					num7 = 1336668940;
					num8 = num7;
				}
				else
				{
					num7 = 562815785;
					num8 = num7;
				}
				num = num7 ^ ((int)num2 * -1644991441);
				continue;
			}
			case 10u:
				goto IL_023d;
			case 6u:
			{
				int num4;
				int num5;
				if (num3 != -2147483648.0)
				{
					num4 = -1146633685;
					num5 = num4;
				}
				else
				{
					num4 = -737286555;
					num5 = num4;
				}
				num = num4 ^ ((int)num2 * -2068186810);
				continue;
			}
			case 12u:
				return;
			}
			break;
			IL_023d:
			num6 = double.Parse(getDataOrInit(key2, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(838530381u)));
			int num11;
			if (_202A_206C_206B_206F_200C_206D_202E_202C_206D_200C_206B_200F_200E_206E_206A_206E_206D_202B_206F_206C_202E_206E_202D_206E_200D_206E_202C_200D_200D_202A_200C_206D_206B_202D_200B_206A_200D_200B_200B_202A_202E(value, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1551796325u)))
			{
				num = 13269849;
				num11 = num;
			}
			else
			{
				num = 249357060;
				num11 = num;
			}
			continue;
			IL_01a9:
			int num12;
			if (round <= -1)
			{
				num = 956229984;
				num12 = num;
			}
			else
			{
				num = 308037196;
				num12 = num;
			}
			continue;
			IL_015f:
			int num13;
			if (!_202A_206C_206B_206F_200C_206D_202E_202C_206D_200C_206B_200F_200E_206E_206A_206E_206D_202B_206F_206C_202E_206E_202D_206E_200D_206E_202C_200D_200D_202A_200C_206D_206B_202D_200B_206A_200D_200B_200B_202A_202E(value, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1434420622u)))
			{
				num = 218805991;
				num13 = num;
			}
			else
			{
				num = 521879294;
				num13 = num;
			}
		}
		goto IL_000b;
		IL_00e1:
		num3 = double.Parse(_200D_206B_206A_202D_200B_206C_206D_202C_206D_200F_206E_202B_200F_202D_200F_200D_202A_206C_202B_206C_200C_202C_202C_206D_200B_202E_200C_200E_200B_202B_206B_202C_206A_202E_202D_202E_200D_206D_206A_206A_202E(_200D_206B_206A_202D_200B_206C_206D_202C_206D_200F_206E_202B_200F_202D_200F_200D_202A_206C_202B_206C_200C_202C_202C_206D_200B_202E_200C_200E_200B_202B_206B_202C_206A_202E_202D_202E_200D_206D_206A_206A_202E(value, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1551796325u), string.Empty), global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(533767640u), string.Empty));
		num = 757232579;
		goto IL_0010;
	}

	public ItemInstance GetItemByName3(string name, ItemType type)
	{
		if (!_202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(name))
		{
			using Dictionary<ItemInstance, int>.Enumerator enumerator = Items.GetEnumerator();
			KeyValuePair<ItemInstance, int> current = default(KeyValuePair<ItemInstance, int>);
			while (true)
			{
				IL_004a:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -1018448228;
					num2 = num;
				}
				else
				{
					num = -101482581;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -949066164)) % 6)
					{
					case 5u:
						num = -101482581;
						continue;
					default:
						goto end_IL_001e;
					case 2u:
						break;
					case 3u:
					{
						int num5;
						int num6;
						if (current.Key.Type == type)
						{
							num5 = 1936621096;
							num6 = num5;
						}
						else
						{
							num5 = 804939824;
							num6 = num5;
						}
						num = num5 ^ ((int)num3 * -1031470478);
						continue;
					}
					case 1u:
					{
						current = enumerator.Current;
						int num4;
						if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(current.Key.Name, name))
						{
							num = -1719807319;
							num4 = num;
						}
						else
						{
							num = -1093451830;
							num4 = num;
						}
						continue;
					}
					case 0u:
						return current.Key;
					case 4u:
						goto end_IL_001e;
					}
					goto IL_004a;
					continue;
					end_IL_001e:
					break;
				}
				break;
			}
		}
		return null;
	}

	public int GetXiangziCount(string name)
	{
		int num = 0;
		using (Dictionary<ItemInstance, int>.Enumerator enumerator = Xiangzi.GetEnumerator())
		{
			KeyValuePair<ItemInstance, int> current = default(KeyValuePair<ItemInstance, int>);
			while (true)
			{
				IL_003e:
				int num2;
				int num3;
				if (enumerator.MoveNext())
				{
					num2 = -1794052146;
					num3 = num2;
				}
				else
				{
					num2 = -568116454;
					num3 = num2;
				}
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)(num2 ^ -609297969)) % 6)
					{
					case 2u:
						num2 = -1794052146;
						continue;
					default:
						goto end_IL_0015;
					case 1u:
						break;
					case 0u:
					{
						int num5;
						int num6;
						if (_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(current.Key.Name, name))
						{
							num5 = 843749677;
							num6 = num5;
						}
						else
						{
							num5 = 246770430;
							num6 = num5;
						}
						num2 = num5 ^ ((int)num4 * -210828673);
						continue;
					}
					case 4u:
						num += num_decode(current.Value);
						num2 = ((int)num4 * -1376326276) ^ -336761742;
						continue;
					case 5u:
						current = enumerator.Current;
						num2 = -1624013741;
						continue;
					case 3u:
						goto end_IL_0015;
					}
					goto IL_003e;
					continue;
					end_IL_0015:
					break;
				}
				break;
			}
		}
		return num;
	}

	public IEnumerable<Role> GetRoles()
	{
		//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
		return new _202B_202A_200B_200E_200D_206B_202C_200C_206B_202B_206A_202E_202C_206E_200D_202B_202A_202B_206E_206B_206A_206E_206C_206D_202D_200F_202D_206F_202A_202B_200D_200E_202B_200E_206E_202C_206E_202A_206C_206B_202E(-2)
		{
			_202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E = this
		};
	}

	public int GetRolesEquipment(string name, int number)
	{
		int num = 0;
		IEnumerator<Role> enumerator = GetRoles().GetEnumerator();
		try
		{
			while (true)
			{
				IL_009d:
				int num2;
				int num3;
				if (_200C_202A_206C_202A_200E_206A_202B_206F_206A_202E_202E_200B_200D_206B_202C_200E_200D_202E_206F_202C_202B_206D_202A_202B_206D_200F_200C_206B_206D_200B_202D_202E_200F_206C_206C_206B_202E_206D_202D_206E_202E((IEnumerator)enumerator))
				{
					num2 = 1024798776;
					num3 = num2;
				}
				else
				{
					num2 = 1020061435;
					num3 = num2;
				}
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)(num2 ^ 0x1CC5C15D)) % 7)
					{
					case 3u:
						num2 = 1024798776;
						continue;
					default:
						goto end_IL_0018;
					case 5u:
					{
						int num6;
						int num7;
						if (num >= number)
						{
							num6 = -842516563;
							num7 = num6;
						}
						else
						{
							num6 = -1815445161;
							num7 = num6;
						}
						num2 = num6 ^ ((int)num4 * -660281413);
						continue;
					}
					case 4u:
						return num;
					case 2u:
					{
						int num5;
						if (enumerator.Current.GetEquipment(name) != null)
						{
							num2 = 1893871657;
							num5 = num2;
						}
						else
						{
							num2 = 835037207;
							num5 = num2;
						}
						continue;
					}
					case 0u:
						break;
					case 6u:
						num++;
						num2 = ((int)num4 * -490641712) ^ 0x3E9460DD;
						continue;
					case 1u:
						goto end_IL_0018;
					}
					goto IL_009d;
					continue;
					end_IL_0018:
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
					IL_00d4:
					int num8 = 676404609;
					while (true)
					{
						uint num4;
						switch ((num4 = (uint)(num8 ^ 0x1CC5C15D)) % 3)
						{
						case 2u:
							break;
						default:
							goto end_IL_00d9;
						case 1u:
							goto IL_00f6;
						case 0u:
							goto end_IL_00d9;
						}
						goto IL_00d4;
						IL_00f6:
						_206D_200E_206E_206E_206A_206B_206B_202E_206F_200F_202D_202D_200B_202E_206F_200B_202A_206B_200D_206B_206B_200C_200B_206B_200F_202C_202C_206F_206A_206F_206E_202B_206B_206C_202C_206C_200F_200B_200F_202E_202E((IDisposable)enumerator);
						num8 = (int)(num4 * 996795860) ^ -2020355500;
						continue;
						end_IL_00d9:
						break;
					}
					break;
				}
			}
		}
		return num;
	}

	public void ResetRolePic(string name, bool head)
	{
		string[] array = _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(name, new char[1] { '#' });
		Role role = default(Role);
		Role current = default(Role);
		Role current2 = default(Role);
		Role role2 = default(Role);
		while (true)
		{
			int num = 1930322515;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x51002AA2)) % 5)
				{
				case 2u:
					break;
				case 3u:
					if (head)
					{
						num = 340578895;
						continue;
					}
					goto IL_0204;
				case 4u:
					return;
				case 1u:
				{
					int num12;
					int num13;
					if (array.Length == 0)
					{
						num12 = -2101406619;
						num13 = num12;
					}
					else
					{
						num12 = -164852510;
						num13 = num12;
					}
					num = num12 ^ ((int)num2 * -1824951338);
					continue;
				}
				default:
					{
						using (List<Role>.Enumerator enumerator = Team.GetEnumerator())
						{
							while (true)
							{
								IL_01af:
								int num3;
								int num4;
								if (!enumerator.MoveNext())
								{
									num3 = 121067744;
									num4 = num3;
								}
								else
								{
									num3 = 224162014;
									num4 = num3;
								}
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ 0x51002AA2)) % 11)
									{
									case 4u:
										num3 = 224162014;
										continue;
									default:
										goto end_IL_008f;
									case 0u:
										role = ResourceManager.Get<Role>(current.Key);
										num3 = 1626984560;
										continue;
									case 9u:
									{
										int num10;
										int num11;
										if (!_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(array[0], current.Key))
										{
											num10 = 396619491;
											num11 = num10;
										}
										else
										{
											num10 = 71082262;
											num11 = num10;
										}
										num3 = num10 ^ ((int)num2 * -1310018904);
										continue;
									}
									case 10u:
										current = enumerator.Current;
										num3 = 1050446329;
										continue;
									case 5u:
									{
										int num6;
										int num7;
										if (!_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(array[0], ResourceStrings.ResStrings[118]))
										{
											num6 = -1077633888;
											num7 = num6;
										}
										else
										{
											num6 = -1333283659;
											num7 = num6;
										}
										num3 = num6 ^ (int)(num2 * 47714227);
										continue;
									}
									case 3u:
									{
										int num8;
										int num9;
										if (role == null)
										{
											num8 = -888236893;
											num9 = num8;
										}
										else
										{
											num8 = -1388255050;
											num9 = num8;
										}
										num3 = num8 ^ ((int)num2 * -1429649422);
										continue;
									}
									case 6u:
										return;
									case 7u:
									{
										int num5;
										if (!_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(array[0], current.Key))
										{
											num3 = 1878126779;
											num5 = num3;
										}
										else
										{
											num3 = 1016767090;
											num5 = num3;
										}
										continue;
									}
									case 1u:
										break;
									case 8u:
										current.Head = role.Head;
										RefreshTeamMemberPanel(current, refreshImage: true, refreshText: false);
										num3 = (int)(num2 * 1110840781) ^ -971417225;
										continue;
									case 2u:
										goto end_IL_008f;
									}
									goto IL_01af;
									continue;
									end_IL_008f:
									break;
								}
								break;
							}
						}
						goto IL_0204;
					}
					IL_0204:
					if (head)
					{
						return;
					}
					using (List<Role>.Enumerator enumerator = Team.GetEnumerator())
					{
						while (true)
						{
							int num14;
							int num15;
							if (!enumerator.MoveNext())
							{
								num14 = 335989985;
								num15 = num14;
							}
							else
							{
								num14 = 1688642289;
								num15 = num14;
							}
							while (true)
							{
								switch ((num2 = (uint)(num14 ^ 0x51002AA2)) % 10)
								{
								case 8u:
									num14 = 1688642289;
									continue;
								default:
									return;
								case 3u:
									current2 = enumerator.Current;
									num14 = 1328979352;
									continue;
								case 0u:
								{
									int num20;
									int num21;
									if (!_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(array[0], current2.Key))
									{
										num20 = 192107887;
										num21 = num20;
									}
									else
									{
										num20 = 208289442;
										num21 = num20;
									}
									num14 = num20 ^ ((int)num2 * -863418609);
									continue;
								}
								case 6u:
								{
									int num18;
									if (!_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(array[0], current2.Key))
									{
										num14 = 1943577494;
										num18 = num14;
									}
									else
									{
										num14 = 2017500419;
										num18 = num14;
									}
									continue;
								}
								case 5u:
									current2.Animation = role2.Animation;
									num14 = (int)(num2 * 1895600926) ^ -497573640;
									continue;
								case 9u:
									return;
								case 4u:
									break;
								case 2u:
								{
									role2 = ResourceManager.Get<Role>(current2.Key);
									int num19;
									if (role2 != null)
									{
										num14 = 1974231215;
										num19 = num14;
									}
									else
									{
										num14 = 768967806;
										num19 = num14;
									}
									continue;
								}
								case 1u:
								{
									int num16;
									int num17;
									if (!_202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(array[0], ResourceStrings.ResStrings[118]))
									{
										num16 = 1831548973;
										num17 = num16;
									}
									else
									{
										num16 = 714504063;
										num17 = num16;
									}
									num14 = num16 ^ ((int)num2 * -1319560655);
									continue;
								}
								case 7u:
									return;
								}
								break;
							}
						}
					}
				}
				break;
			}
		}
	}

	static bool _202D_200B_202B_202D_206E_206C_202E_206F_202D_200C_206E_202C_206D_200B_206A_206A_206F_206E_206B_200F_200B_200E_206F_206D_202E_202E_206A_202D_202E_206B_200B_200E_202E_206C_200F_206F_202C_206B_200E_200F_202E(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}

	static bool _206D_206A_200E_200F_200D_206B_202D_200D_202A_202B_200B_206E_206F_206A_202A_200E_206A_200B_202D_206E_206A_200E_206E_200C_200E_202D_202B_206A_202D_202E_206F_206A_200B_202C_206A_202E_206D_206F_202C_202E(string P_0, string P_1)
	{
		return P_0.Equals(P_1);
	}

	static bool _202C_206D_202B_202B_206C_202C_200F_202B_202C_206D_202D_200F_206C_200D_200C_200F_206D_206E_202B_200F_202E_200D_200F_206E_202E_206D_206F_200C_206D_206F_206F_206E_206B_200F_202E_206F_202A_206D_200C_202D_202E(string P_0, string P_1)
	{
		return P_0 == P_1;
	}

	static string _200C_206D_202D_202B_206C_202D_202D_202E_206A_200B_202E_200D_200C_206A_206D_202A_206C_200B_206E_202E_200E_206C_206E_206C_206B_200E_200E_200B_200B_202D_206B_202D_206B_202C_202B_200C_206A_202E_200E_206C_202E(object P_0)
	{
		return P_0.ToString();
	}

	static string[] _202B_202A_206D_202B_202B_206F_202E_206F_206C_202A_202C_206C_200D_202C_206B_202A_202E_206B_206A_200E_200F_206B_202C_206E_206A_206D_206C_206B_202D_206F_206A_202A_206A_202B_200F_206E_206D_202A_206C_200E_202E(string P_0, char[] P_1)
	{
		return P_0.Split(P_1);
	}

	static string _206A_206B_202D_202E_200E_206D_202D_202E_206D_200E_202A_202B_206D_200F_202D_206E_202E_200D_202E_202E_206F_200F_200F_200F_206B_202E_202C_200F_202B_202C_200B_206D_202E_200E_200C_202C_200F_202E_202B_206D_202E(string P_0, string P_1, string P_2)
	{
		return P_0 + P_1 + P_2;
	}

	static string _206A_200C_200F_206E_202E_206D_206E_200E_202D_200E_202A_200F_200E_200B_202A_206B_200B_202A_202E_206A_202B_206C_200F_202C_202D_200F_202D_206E_206D_202A_202A_200C_200C_206D_200B_202B_202B_200C_200E_200C_202E(string P_0, string P_1)
	{
		return P_0 + P_1;
	}

	static string _200D_206B_206A_202D_200B_206C_206D_202C_206D_200F_206E_202B_200F_202D_200F_200D_202A_206C_202B_206C_200C_202C_202C_206D_200B_202E_200C_200E_200B_202B_206B_202C_206A_202E_202D_202E_200D_206D_206A_206A_202E(string P_0, string P_1, string P_2)
	{
		return P_0.Replace(P_1, P_2);
	}

	static string _200D_200F_206D_200B_200E_206C_200B_206B_206E_202A_206D_200F_200C_202E_206D_202C_200C_202B_206D_206C_200E_200B_200B_202D_202B_206E_206F_202D_206F_202D_206C_206C_206D_200E_202A_202B_202B_200C_200B_202E_202E(string[] P_0)
	{
		return string.Concat(P_0);
	}

	static string _206B_202A_206D_206E_206F_206F_202A_200E_200F_200B_206B_206B_202B_206A_202B_200F_206D_206A_200E_200E_200C_202B_200E_202E_202A_200B_202D_200D_206C_202E_202B_200D_206F_200D_206C_202D_200F_202E_202B_206C_202E(string P_0, object P_1, object P_2, object P_3)
	{
		return string.Format(P_0, P_1, P_2, P_3);
	}

	static bool _202A_206C_206B_206F_200C_206D_202E_202C_206D_200C_206B_200F_200E_206E_206A_206E_206D_202B_206F_206C_202E_206E_202D_206E_200D_206E_202C_200D_200D_202A_200C_206D_206B_202D_200B_206A_200D_200B_200B_202A_202E(string P_0, string P_1)
	{
		return P_0.StartsWith(P_1);
	}

	static string _206C_202A_200D_206B_202A_206A_200F_206A_206B_200E_202E_206B_206B_202C_206C_200E_202A_202B_202D_200C_200F_200E_206D_206D_202C_202E_202C_200E_206E_206F_206E_202B_202A_202E_206A_200B_200B_202A_202A_202C_202E(string P_0, object P_1)
	{
		return string.Format(P_0, P_1);
	}

	static bool _200B_202A_200D_202E_206D_202C_202B_202D_202A_206B_200F_206E_202A_200C_206D_200F_206B_206B_202D_200D_206C_202E_200E_202B_206E_206A_206E_200D_206F_202C_206C_202C_202B_206B_206A_206D_200C_200B_202D_200D_202E(Object P_0, Object P_1)
	{
		return P_0 != P_1;
	}

	static bool _206D_202D_206D_202A_200D_206B_206B_202D_202A_202D_206D_202C_206C_206A_200F_206E_202D_202C_202E_200F_206A_200B_206E_200C_206F_206B_202A_200D_206D_206D_206A_206E_206E_202C_206E_206C_202D_200C_200F_206F_202E(string P_0, string P_1)
	{
		return P_0 != P_1;
	}

	static int _200B_202C_200E_202C_202C_200E_206C_200F_206C_200B_206C_206F_202C_202C_206A_206D_206F_206C_200E_200F_200B_202A_206D_206B_202E_200F_206C_206C_200D_200B_206D_206F_206F_200D_206A_202E_200D_206C_200E_206B_202E(string P_0)
	{
		return P_0.Length;
	}

	static CultureInfo _206C_200F_202E_200D_202C_200F_206E_206D_200F_206F_206E_200F_206A_202E_200B_206C_206A_206E_206D_202D_202B_206F_206B_202D_202B_206D_200E_206F_202E_202E_200C_206D_200D_202A_202B_206A_202A_200C_206E_206C_202E()
	{
		return CultureInfo.CurrentCulture;
	}

	static string _202E_200F_200D_206A_202A_206D_200D_206F_200D_200E_202C_206D_202B_202A_206C_202B_200F_200B_202A_206C_200C_200E_200F_202E_206A_200B_202C_206E_200C_206D_206D_202E_202A_202B_206D_200B_202D_200B_202C_202E(string P_0)
	{
		return P_0.Trim();
	}

	static string _202E_200D_206D_206C_202C_200C_206B_206A_206A_202C_200C_200F_200D_202E_200C_202E_202B_206B_200E_200C_206D_200F_200E_206C_200F_200E_200D_200C_202E_206F_206C_200F_200B_202E_200C_206F_206D_202D_202B_202E_202E(string P_0, int P_1, int P_2)
	{
		return P_0.Substring(P_1, P_2);
	}

	static int _200B_202A_202E_206F_206B_200E_202E_206A_206E_202B_202D_206B_202D_202C_206C_202A_200C_200C_206D_206F_202A_200D_200C_202E_202A_206C_206F_202C_200E_206C_202B_202D_202E_206F_200B_200D_202E_200C_202B_202C_202E(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	static bool _200C_202A_206C_202A_200E_206A_202B_206F_206A_202E_202E_200B_200D_206B_202C_200E_200D_202E_206F_202C_202B_206D_202A_202B_206D_200F_200C_206B_206D_200B_202D_202E_200F_206C_206C_206B_202E_206D_202D_206E_202E(IEnumerator P_0)
	{
		return P_0.MoveNext();
	}

	static void _206D_200E_206E_206E_206A_206B_206B_202E_206F_200F_202D_202D_200B_202E_206F_200B_202A_206B_200D_206B_206B_200C_200B_206B_200F_202C_202C_206F_206A_206F_206E_202B_206B_206C_202C_206C_200F_200B_200F_202E_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}

	static Exception _200F_200B_206C_200F_200D_202A_200E_200D_206D_202D_200F_202C_200C_200D_206D_202C_200C_200D_200B_202D_200D_200B_206D_200D_206A_200D_200F_206F_202A_202E_206E_206E_202C_202D_206E_202D_206E_206F_200E_202E_202E(string P_0)
	{
		return new Exception(P_0);
	}

	static ASCIIEncoding _206F_200D_206B_202D_206B_202E_200E_206A_202C_200D_206D_206F_202A_200E_200C_200B_200B_202A_200B_202C_202D_200D_206C_202B_202A_206F_206A_202E_200E_206A_200D_200E_202B_200D_200B_200B_202C_206F_202B_200F_202E()
	{
		return new ASCIIEncoding();
	}

	static byte[] _206C_206E_200D_202B_202E_206D_202A_206A_202C_202A_200E_206D_202C_200F_206D_202E_200C_202B_200C_206A_200F_202C_200E_200F_200E_200D_206B_206D_200F_202D_206B_202E_200F_202B_206A_202A_206A_202E_200F_202C_202E(Encoding P_0, string P_1)
	{
		return P_0.GetBytes(P_1);
	}

	static bool _200D_202D_202C_200D_206D_200E_206B_202E_202D_200C_202C_202E_206E_202E_200D_206D_200E_206A_206D_206D_200C_200C_202A_202B_202E_200E_206E_200E_202D_206B_206D_200E_206E_202A_202D_206F_200F_200F_206F_202D_202E(string P_0, string P_1)
	{
		return P_0.Contains(P_1);
	}

	static int _200D_202B_206D_200C_202A_206B_202C_202B_202E_206F_206C_200B_200C_200F_202A_200D_206A_202E_200F_202A_202A_206D_200C_202C_200F_200E_206D_206B_202D_200F_200F_202C_200B_200E_202B_200B_202A_202C_200C_200C_202E(string P_0, string P_1)
	{
		return P_0.IndexOf(P_1);
	}

	static int _200F_206C_200F_202A_206C_202B_200D_206C_200D_206A_200E_200E_200C_202A_200F_202A_206E_200E_206C_206B_202A_200D_206A_202A_202D_206D_206B_202A_202D_202C_202B_206D_202D_202B_202A_200E_206E_202D_202D_202E(string P_0, string P_1, int P_2)
	{
		return P_0.IndexOf(P_1, P_2);
	}

	static string _206A_206A_200E_206D_206F_206A_206D_200B_200C_202D_200E_206B_202A_206A_206C_202D_200E_206D_206E_200B_206F_202A_200F_202A_206F_206D_200F_200F_206D_200D_200C_200D_200C_200D_206C_202B_202D_206D_206B_202D_202E(string P_0, int P_1, int P_2)
	{
		return P_0.Remove(P_1, P_2);
	}

	static string _200F_200F_200B_206B_200B_202B_206A_206D_200D_206A_202B_202B_206F_202D_206E_200F_202D_206E_206E_202A_206E_206E_206E_202B_200E_200C_200B_202B_200E_200B_200D_206F_200E_200B_200B_202C_200E_206F_202D_206A_202E(string P_0, int P_1, string P_2)
	{
		return P_0.Insert(P_1, P_2);
	}

	static string _206D_202B_200F_202A_202E_200E_200E_200B_200C_206F_200E_200C_202C_202E_200F_202D_202E_206B_202E_200D_202C_206F_206B_200C_202D_206B_200C_206D_206D_206F_200C_202A_206A_206D_206B_202C_200D_200F_200C_202D_202E(string P_0, int P_1, int P_2)
	{
		return P_0.Substring(P_1, P_2);
	}

	static bool _206F_202E_202D_200E_200E_200C_200B_202B_202C_200E_206D_206C_206A_202D_206E_200F_202A_202B_202D_200C_202E_206D_206B_202B_202C_202A_202C_206B_206E_206A_202B_206B_206C_202D_200F_200C_206D_200F_202A_206C_202E(string P_0, string P_1)
	{
		return P_0.Contains(P_1);
	}

	static bool _200E_202B_202A_200D_202C_200D_200C_202D_206D_200C_206A_200C_206D_200B_200F_206A_200E_206F_202B_200F_206C_202E_206E_206A_206C_200C_202C_206C_206C_200D_202A_202A_200B_206A_200E_202A_206B_206F_202D_202E_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static string _200C_200E_206C_200D_200F_202B_206B_202A_206E_202D_202E_206D_202A_202E_206D_206B_200D_202A_200D_202B_200B_206E_206B_206F_202D_206E_206F_206D_206C_202A_206C_202A_200E_200B_200E_206F_206C_200E_202E_202A_202E(string P_0, string P_1, string P_2, string P_3)
	{
		return P_0 + P_1 + P_2 + P_3;
	}

	static string _200D_206D_206B_206A_206A_202E_206E_206A_202A_200F_202E_206D_200B_206E_206A_200C_200B_206F_200E_202D_200E_200C_200E_202E_202B_206B_206F_206C_202E_206B_200C_206D_206C_200D_200B_202A_206C_206B_200B_206D_202E(string P_0, string[] P_1)
	{
		return string.Join(P_0, P_1);
	}

	static int _200B_206D_206D_200F_206C_202D_206F_202E_202C_202E_206A_200C_200D_202C_206D_206B_202C_200C_202D_200C_206B_202B_202B_200B_202E_206B_202A_200B_200F_200F_202B_206B_202C_202C_206D_206F_202A_202A_200B_206D_202E(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	static byte[] _202C_202E_200C_206A_200C_202E_202E_206D_202C_200C_200F_206A_206B_202D_202A_206C_206E_200D_206E_202B_206E_202B_200C_200B_202D_200C_200D_202E_200D_202C_206A_206E_202B_200D_200D_206F_202A_206D_206B_202C_202E(int P_0)
	{
		return BitConverter.GetBytes(P_0);
	}

	static decimal _206A_202A_200E_202C_202A_200E_202C_202E_200B_202C_206C_200D_202E_206D_200F_206C_202A_206F_202D_206A_206F_200C_202E_200E_202D_202E_206D_200D_202D_206B_206D_200F_200B_202E_200D_200D_202A_206F_206C_206F_202E(decimal P_0, int P_1, MidpointRounding P_2)
	{
		return Math.Round(P_0, P_1, P_2);
	}
}
