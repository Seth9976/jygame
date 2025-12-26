using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml.Serialization;
using UnityEngine;

namespace JyGame;

[XmlType("item")]
public class ItemInstance : BasePojo
{
	[CompilerGenerated]
	private sealed class _202B_200F_202C_206D_202A_202C_200F_202E_202E_200F_206E_200F_200B_200E_202A_206C_202E_206E_206E_202E_202C_206E_200E_206C_202E_202A_202B_202E_200D_200C_202B_200B_206B_200D_206C_202C_206C_202E_200C_200F_202E : IEnumerable<Trigger>, IEnumerator<Trigger>, IEnumerator, IDisposable, IEnumerable
	{
		private int _200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E;

		private Trigger _200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E;

		private int _200B_202B_206E_200C_202C_200D_206F_202E_200F_206A_200C_202C_200B_202D_200F_206E_202D_206C_200B_202C_206C_206A_206E_206C_202B_206D_206E_200E_206E_202D_206E_202E_202E_202A_206D_206E_206D_202C_202D_202E;

		public ItemInstance _202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E;

		private List<Trigger>.Enumerator _206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E;

		Trigger IEnumerator<Trigger>.Current
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
		public _202B_200F_202C_206D_202A_202C_200F_202E_202E_200F_206E_200F_200B_200E_202A_206C_202E_206E_206E_202E_202C_206E_200E_206C_202E_202A_202B_202E_200D_200C_202B_200B_206B_200D_206C_202C_206C_202E_200C_200F_202E(int P_0)
		{
			_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = P_0;
			_200B_202B_206E_200C_202C_200D_206F_202E_200F_206A_200C_202C_200B_202D_200F_206E_202D_206C_200B_202C_206C_206A_206E_206C_202B_206D_206E_200E_206E_202D_206E_202E_202E_202A_206D_206E_206D_202C_202D_202E = _202B_202B_200B_206E_202C_202E_202D_206B_206A_200F_202A_206B_206F_202A_206A_206D_202C_206F_202A_200D_202E_206E_206D_202D_200E_206E_202A_206F_206E_200F_202E_206E_200E_200F_206E_200B_202B_206A_200C_200E_202E(_206D_200B_200B_202E_206C_200E_206C_200F_202A_202E_200F_206B_202A_206D_206A_202E_200F_200D_206E_206C_200E_206A_206C_202D_200D_200C_206F_206B_206E_200E_202D_202D_200F_202B_200E_202B_202B_202E_200E_206A_202E());
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E;
			while (true)
			{
				int num2 = 1761982217;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num2 ^ 0x39294D7B)) % 4)
					{
					case 0u:
						break;
					case 2u:
						switch (num)
						{
						default:
							goto IL_0052;
						case -3:
						case 1:
							break;
						case -4:
						case 2:
							try
							{
								return;
							}
							finally
							{
								_200D_206E_202A_206D_200B_206A_200B_200D_202E_200C_200D_206A_202A_200B_202D_200E_202D_200B_206A_200B_200D_206F_200F_202D_202D_200C_206E_206D_206B_202C_206B_202D_206A_206B_200E_200D_200D_202A_202C_206E_202E();
							}
						case -2:
						case -1:
						case 0:
							return;
						}
						goto default;
					case 1u:
						return;
					default:
						try
						{
							return;
						}
						finally
						{
							_202D_202A_202A_200E_206E_202E_206C_202C_206F_202C_200C_202E_202A_206E_202B_202D_202C_206F_206C_206A_202A_200F_206A_200F_206D_200B_200C_202C_202B_206E_200E_206C_202D_200D_202E_202D_206D_206D_202B_202C_202E();
						}
					}
					break;
					IL_0052:
					num2 = (int)((num3 * 2063996619) ^ 0x153DBFFC);
				}
			}
		}

		private bool MoveNext()
		{
			bool result = default(bool);
			try
			{
				int num = _200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E;
				ItemInstance itemInstance = _202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E;
				Trigger current = default(Trigger);
				while (true)
				{
					IL_000e:
					int num2 = -1519138955;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num2 ^ -2036468281)) % 25)
						{
						case 19u:
							break;
						default:
							goto end_IL_0013;
						case 22u:
							goto end_IL_0013;
						case 16u:
						{
							int num5;
							if (_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E.MoveNext())
							{
								num2 = -1226509219;
								num5 = num2;
							}
							else
							{
								num2 = -2077767628;
								num5 = num2;
							}
							continue;
						}
						case 3u:
							_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E = itemInstance.Triggers.GetEnumerator();
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -3;
							num2 = ((int)num3 * -753465985) ^ -368909275;
							continue;
						case 13u:
							_200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E = current;
							num2 = ((int)num3 * -986813254) ^ -357313801;
							continue;
						case 18u:
							num2 = ((int)num3 * -1243138395) ^ -1906572353;
							continue;
						case 5u:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
							num2 = -1906804428;
							continue;
						case 14u:
						{
							int num4;
							if (_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E.MoveNext())
							{
								num2 = -875355677;
								num4 = num2;
							}
							else
							{
								num2 = -468864215;
								num4 = num2;
							}
							continue;
						}
						case 12u:
							_200D_206E_202A_206D_200B_206A_200B_200D_202E_200C_200D_206A_202A_200B_202D_200E_202D_200B_206A_200B_200D_206F_200F_202D_202D_200C_206E_206D_206B_202C_206B_202D_206A_206B_200E_200D_200D_202A_202C_206E_202E();
							num2 = ((int)num3 * -444805356) ^ -1804346496;
							continue;
						case 4u:
							result = true;
							num2 = ((int)num3 * -117547791) ^ 0xBEF0FB1;
							continue;
						case 24u:
							goto IL_0180;
						case 21u:
							goto end_IL_0013;
						case 23u:
						{
							Trigger current2 = _206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E.Current;
							_200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E = current2;
							num2 = -210880431;
							continue;
						}
						case 7u:
							goto IL_01c7;
						case 0u:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 1;
							num2 = (int)((num3 * 1951295141) ^ 0x42ECA876);
							continue;
						case 8u:
							_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E = itemInstance.AdditionTriggers.GetEnumerator();
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -4;
							num2 = (int)((num3 * 362914234) ^ 0x7058C106);
							continue;
						case 17u:
							result = false;
							num2 = (int)(num3 * 1064486855) ^ -1397916499;
							continue;
						case 15u:
							_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E = default(List<Trigger>.Enumerator);
							result = false;
							num2 = ((int)num3 * -293941445) ^ 0x5FF8A340;
							continue;
						case 1u:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 2;
							num2 = ((int)num3 * -1813978472) ^ -2313853;
							continue;
						case 20u:
							goto end_IL_0013;
						case 10u:
							_202D_202A_202A_200E_206E_202E_206C_202C_206F_202C_200C_202E_202A_206E_202B_202D_202C_206F_206C_206A_202A_200F_206A_200F_206D_200B_200C_202C_202B_206E_200E_206C_202D_200D_202E_202D_206D_206D_202B_202C_202E();
							_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E = default(List<Trigger>.Enumerator);
							num2 = (int)((num3 * 676261170) ^ 0xB864089);
							continue;
						case 9u:
							current = _206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E.Current;
							num2 = -111971172;
							continue;
						case 6u:
							switch (num)
							{
							case 0:
								break;
							case 2:
								goto IL_0180;
							case 1:
								goto IL_01c7;
							default:
								goto IL_02d5;
							}
							goto case 5u;
						case 2u:
							result = true;
							num2 = (int)((num3 * 179932719) ^ 0x64589CD7);
							continue;
						case 11u:
							goto end_IL_0013;
							IL_02d5:
							num2 = ((int)num3 * -1249109772) ^ -1984037576;
							continue;
							IL_01c7:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -3;
							num2 = -1030467672;
							continue;
							IL_0180:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -4;
							num2 = -1292465738;
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
				int num = 1467534002;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x1DB7CDF4)) % 3)
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
					num = ((int)num2 * -227441391) ^ -1253868499;
				}
			}
		}

		private void _200D_206E_202A_206D_200B_206A_200B_200D_202E_200C_200D_206A_202A_200B_202D_200E_202D_200B_206A_200B_200D_206F_200F_202D_202D_200C_206E_206D_206B_202C_206B_202D_206A_206B_200E_200D_200D_202A_202C_206E_202E()
		{
			_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
			while (true)
			{
				int num = -1814962373;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1840930254)) % 3)
					{
					case 0u:
						break;
					default:
						return;
					case 1u:
						goto IL_0029;
					case 2u:
						return;
					}
					break;
					IL_0029:
					((IDisposable)_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E/*cast due to .constrained prefix*/).Dispose();
					num = (int)(num2 * 569572122) ^ -1965484517;
				}
			}
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw _206B_202E_202A_202D_200C_206A_200D_206D_200C_200E_200C_202A_200B_200C_206C_202B_206E_206D_202C_202E_202B_202D_202A_206B_206C_202D_206D_200D_202E_206D_200D_202A_206F_202E_202C_200B_200F_206E_200F_206B_202E();
		}

		[DebuggerHidden]
		IEnumerator<Trigger> IEnumerable<Trigger>.GetEnumerator()
		{
			if (_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E == -2)
			{
				goto IL_000a;
			}
			goto IL_003f;
			IL_000a:
			int num = 2112615679;
			goto IL_000f;
			IL_000f:
			_202B_200F_202C_206D_202A_202C_200F_202E_202E_200F_206E_200F_200B_200E_202A_206C_202E_206E_206E_202E_202C_206E_200E_206C_202E_202A_202B_202E_200D_200C_202B_200B_206B_200D_206C_202C_206C_202E_200C_200F_202E obj = default(_202B_200F_202C_206D_202A_202C_200F_202E_202E_200F_206E_200F_200B_200E_202A_206C_202E_206E_206E_202E_202C_206E_200E_206C_202E_202A_202B_202E_200D_200C_202B_200B_206B_200D_206C_202C_206C_202E_200C_200F_202E);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x702C50D2)) % 7)
				{
				case 5u:
					break;
				case 1u:
					goto IL_003f;
				case 3u:
					_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 0;
					obj = this;
					num = ((int)num2 * -1927329643) ^ 0x4C4C9058;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (_200B_202B_206E_200C_202C_200D_206F_202E_200F_206A_200C_202C_200B_202D_200F_206E_202D_206C_200B_202C_206C_206A_206E_206C_202B_206D_206E_200E_206E_202D_206E_202E_202E_202A_206D_206E_206D_202C_202D_202E == _202B_202B_200B_206E_202C_202E_202D_206B_206A_200F_202A_206B_206F_202A_206A_206D_202C_206F_202A_200D_202E_206E_206D_202D_200E_206E_202A_206F_206E_200F_202E_206E_200E_200F_206E_200B_202B_206A_200C_200E_202E(_206D_200B_200B_202E_206C_200E_206C_200F_202A_202E_200F_206B_202A_206D_206A_202E_200F_200D_206E_206C_200E_206A_206C_202D_200D_200C_206F_206B_206E_200E_202D_202D_200F_202B_200E_202B_202B_202E_200E_206A_202E()))
					{
						num3 = 1849401053;
						num4 = num3;
					}
					else
					{
						num3 = 1638040264;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1226433730);
					continue;
				}
				case 0u:
					obj._202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E = _202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E;
					num = ((int)num2 * -1979355138) ^ -590360026;
					continue;
				case 4u:
					num = (int)(num2 * 490823579) ^ -283999093;
					continue;
				default:
					return obj;
				}
				break;
			}
			goto IL_000a;
			IL_003f:
			obj = new _202B_200F_202C_206D_202A_202C_200F_202E_202E_200F_206E_200F_200B_200E_202A_206C_202E_206E_206E_202E_202C_206E_200E_206C_202E_202A_202B_202E_200D_200C_202B_200B_206B_200D_206C_202C_206C_202E_200C_200F_202E(0);
			num = 877831880;
			goto IL_000f;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<Trigger>)this).GetEnumerator();
		}

		static Thread _206D_200B_200B_202E_206C_200E_206C_200F_202A_202E_200F_206B_202A_206D_206A_202E_200F_200D_206E_206C_200E_206A_206C_202D_200D_200C_206F_206B_206E_200E_202D_202D_200F_202B_200E_202B_202B_202E_200E_206A_202E()
		{
			return Thread.CurrentThread;
		}

		static int _202B_202B_200B_206E_202C_202E_202D_206B_206A_200F_202A_206B_206F_202A_206A_206D_202C_206F_202A_200D_202E_206E_206D_202D_200E_206E_202A_206F_206E_200F_202E_206E_200E_200F_206E_200B_202B_206A_200C_200E_202E(Thread P_0)
		{
			return P_0.ManagedThreadId;
		}

		static NotSupportedException _206B_202E_202A_202D_200C_206A_200D_206D_200C_200E_200C_202A_200B_200C_206C_202B_206E_206D_202C_202E_202B_202D_202A_206B_206C_202D_206D_200D_202E_206D_200D_202A_206F_202E_202C_200B_200F_206E_200F_206B_202E()
		{
			return new NotSupportedException();
		}
	}

	[XmlIgnore]
	private string _206A_202D_202C_200D_206B_206E_200E_206F_206B_206E_206D_200B_200D_206E_200B_200D_206D_202A_200D_200F_206B_200F_206A_206A_200F_206F_206E_206F_206F_200B_202E_200B_200B_200E_206B_206F_206E_200D_202A_200F_202E;

	[XmlElement("addition_trigger")]
	public List<Trigger> AdditionTriggers = new List<Trigger>();

	[XmlIgnore]
	private Item _202E_202C_200B_202E_200B_202A_202B_200F_200B_200C_206E_200C_202A_202B_200C_200E_200F_200D_206A_206F_200D_200E_200D_200E_206B_202C_206D_206B_200E_206F_206B_200C_202C_206A_200B_202B_200F_202B_202B_202E_202E;

	public override string PK
	{
		get
		{
			string text;
			if (type >= 10)
			{
				int num3 = default(int);
				while (true)
				{
					int num = 1735494540;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ 0xFDD2255)) % 3)
						{
						case 0u:
							break;
						case 2u:
							num3 = type;
							num = ((int)num2 * -1124499284) ^ 0x7BEF5D1B;
							continue;
						default:
							goto end_IL_000a;
						}
						break;
					}
					continue;
					end_IL_000a:
					break;
				}
				text = num3.ToString();
			}
			else
			{
				text = global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(838530381u) + type;
			}
			string text2 = text + pic + global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3874746690u) + Name;
			using (List<Trigger>.Enumerator enumerator = AdditionTriggers.GetEnumerator())
			{
				Trigger current = default(Trigger);
				while (true)
				{
					IL_00bf:
					int num4;
					int num5;
					if (enumerator.MoveNext())
					{
						num4 = 1648970657;
						num5 = num4;
					}
					else
					{
						num4 = 904182243;
						num5 = num4;
					}
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num4 ^ 0xFDD2255)) % 5)
						{
						case 4u:
							num4 = 1648970657;
							continue;
						default:
							goto end_IL_0099;
						case 3u:
							break;
						case 0u:
							text2 = text2 + global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3874746690u) + current.PK;
							num4 = (int)(num2 * 744656797) ^ -1042165933;
							continue;
						case 1u:
							current = enumerator.Current;
							num4 = 1500665531;
							continue;
						case 2u:
							goto end_IL_0099;
						}
						goto IL_00bf;
						continue;
						end_IL_0099:
						break;
					}
					break;
				}
			}
			return text2;
		}
	}

	[XmlAttribute("name")]
	public string Name
	{
		get
		{
			return _206A_202D_202C_200D_206B_206E_200E_206F_206B_206E_206D_200B_200D_206E_200B_200D_206D_202A_200D_200F_206B_200F_206A_206A_200F_206F_206E_206F_206F_200B_202E_200B_200B_200E_206B_206F_206E_200D_202A_200F_202E;
		}
		set
		{
			_206A_202D_202C_200D_206B_206E_200E_206F_206B_206E_206D_200B_200D_206E_200B_200D_206D_202A_200D_200F_206B_200F_206A_206A_200F_206F_206E_206F_206F_200B_202E_200B_200B_200E_206B_206F_206E_200D_202A_200F_202E = value;
			while (true)
			{
				int num = 1815709647;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x749EC91)) % 4)
					{
					case 0u:
						break;
					default:
						return;
					case 2u:
					{
						int num3;
						int num4;
						if (_202E_202C_200B_202E_200B_202A_202B_200F_200B_200C_206E_200C_202A_202B_200C_200E_200F_200D_206A_206F_200D_200E_200D_200E_206B_202C_206D_206B_200E_206F_206B_200C_202C_206A_200B_202B_200F_202B_202B_202E_202E == null)
						{
							num3 = -347442264;
							num4 = num3;
						}
						else
						{
							num3 = -339889314;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 2065793964);
						continue;
					}
					case 1u:
						_202E_202C_200B_202E_200B_202A_202B_200F_200B_200C_206E_200C_202A_202B_200C_200E_200F_200D_206A_206F_200D_200E_200D_200E_206B_202C_206D_206B_200E_206F_206B_200C_202C_206A_200B_202B_200F_202B_202B_202E_202E = Item.GetItem(value);
						num = ((int)num2 * -297619804) ^ 0x1BEBEE92;
						continue;
					case 3u:
						return;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public string desc => item.desc;

	[XmlIgnore]
	public string talent => item.talent;

	[XmlIgnore]
	public string pic => item.pic;

	[XmlIgnore]
	public int level => item.level;

	[XmlIgnore]
	public int price => item.price;

	[XmlIgnore]
	public bool drop => item.drop;

	[XmlIgnore]
	public string[] Talents => _206E_202A_206A_202D_206A_206A_206E_206A_202A_206E_206A_206C_200D_206D_200C_200F_200B_202B_202A_202B_200B_200D_202E_200E_206D_202D_206A_200E_200B_202C_200E_202A_202D_206B_200B_200E_200D_206D_200C_202D_202E(talent, new char[1] { '#' }, StringSplitOptions.RemoveEmptyEntries);

	[XmlIgnore]
	public string CanzhangSkill => item.CanzhangSkill;

	[XmlIgnore]
	public List<Require> Requires => item.Requires;

	[XmlIgnore]
	public List<Trigger> Triggers => item.Triggers;

	[XmlIgnore]
	public int Cooldown => item.Cooldown;

	[XmlIgnore]
	public IEnumerable<Trigger> AllTriggers => new _202B_200F_202C_206D_202A_202C_200F_202E_202E_200F_206E_200F_200B_200E_202A_206C_202E_206E_206E_202E_202C_206E_200E_206C_202E_202A_202B_202E_200D_200C_202B_200B_206B_200D_206C_202C_206C_202E_200C_200F_202E(-2)
	{
		_202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E = this
	};

	public string EquipCase
	{
		get
		{
			if (Requires == null)
			{
				goto IL_0008;
			}
			goto IL_0045;
			IL_0008:
			int num = 82872962;
			goto IL_000d;
			IL_000d:
			string text = default(string);
			uint num2;
			switch ((num2 = (uint)(num ^ 0x6BAF3EC7)) % 4)
			{
			case 3u:
				break;
			case 1u:
				return string.Empty;
			case 0u:
				goto IL_0045;
			default:
			{
				using (List<int>.Enumerator enumerator = getItemRequireRoleLevel().GetEnumerator())
				{
					int current = default(int);
					while (true)
					{
						IL_00a7:
						int num3;
						int num4;
						if (!enumerator.MoveNext())
						{
							num3 = 969264188;
							num4 = num3;
						}
						else
						{
							num3 = 660359998;
							num4 = num3;
						}
						while (true)
						{
							switch ((num2 = (uint)(num3 ^ 0x6BAF3EC7)) % 7)
							{
							case 0u:
								num3 = 660359998;
								continue;
							default:
								goto end_IL_0066;
							case 5u:
								current = enumerator.Current;
								num3 = 1210861819;
								continue;
							case 6u:
								break;
							case 3u:
							{
								int num5;
								int num6;
								if (current >= 0)
								{
									num5 = -1916585552;
									num6 = num5;
								}
								else
								{
									num5 = -728310516;
									num6 = num5;
								}
								num3 = num5 ^ ((int)num2 * -130121323);
								continue;
							}
							case 4u:
								text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, _206C_202C_200B_206A_202D_206A_200D_200D_206E_200D_206A_200B_202A_200C_206C_200E_202D_206F_200F_206B_200C_206C_206E_200F_202C_200B_206C_202E_206D_200F_206F_206B_200B_206B_200C_206F_202E_206B_202E_202C_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4119622751u), (object)ResourceStrings.ResStrings[431], (object)(-current)));
								num3 = 627943439;
								continue;
							case 2u:
								text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, _206C_202C_200B_206A_202D_206A_200D_200D_206E_200D_206A_200B_202A_200C_206C_200E_202D_206F_200F_206B_200C_206C_206E_200F_202C_200B_206C_202E_206D_200F_206F_206B_200B_206B_200C_206F_202E_206B_202E_202C_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1365371698u), (object)ResourceStrings.ResStrings[431], (object)current));
								num3 = ((int)num2 * -681879082) ^ -421642595;
								continue;
							case 1u:
								goto end_IL_0066;
							}
							goto IL_00a7;
							continue;
							end_IL_0066:
							break;
						}
						break;
					}
				}
				Dictionary<string, int> itemRequireAttrs = getItemRequireAttrs();
				if (itemRequireAttrs.Count > 0)
				{
					while (true)
					{
						int num7 = 529270313;
						while (true)
						{
							switch ((num2 = (uint)(num7 ^ 0x6BAF3EC7)) % 4)
							{
							case 3u:
								break;
							case 2u:
							{
								int num8;
								int num9;
								if (!_206C_206E_202C_206C_200C_206C_202E_202C_206D_202C_206C_200B_200D_200C_200B_202C_200E_200B_200B_200F_202B_202A_202B_202C_202C_202A_200C_202A_202C_206E_200C_202C_202E_200D_200E_202B_202C_200C_206C_202E_202E(text, string.Empty))
								{
									num8 = -886738985;
									num9 = num8;
								}
								else
								{
									num8 = -1033705826;
									num9 = num8;
								}
								num7 = num8 ^ ((int)num2 * -1787465770);
								continue;
							}
							case 1u:
								text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(_206E_206B_202D_200F_200E_200E_206C_200C_206E_206A_202B_200E_206B_202A_200F_206F_206B_200D_206A_206D_200B_206C_202A_206B_202E_202B_202D_202B_206B_200D_202C_206F_200F_206A_206A_206C_200D_200D_200C_202C_202E(text, new char[0]), global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2910989005u));
								num7 = ((int)num2 * -1744256706) ^ 0x9ABD1C5;
								continue;
							default:
								goto end_IL_0179;
							}
							break;
						}
						continue;
						end_IL_0179:
						break;
					}
					using Dictionary<string, int>.KeyCollection.Enumerator enumerator2 = itemRequireAttrs.Keys.GetEnumerator();
					string current2 = default(string);
					int num14 = default(int);
					int num12 = default(int);
					while (true)
					{
						IL_03b1:
						int num10;
						int num11;
						if (!enumerator2.MoveNext())
						{
							num10 = 1560703826;
							num11 = num10;
						}
						else
						{
							num10 = 109714029;
							num11 = num10;
						}
						while (true)
						{
							switch ((num2 = (uint)(num10 ^ 0x6BAF3EC7)) % 12)
							{
							case 2u:
								num10 = 109714029;
								continue;
							default:
								goto end_IL_020a;
							case 10u:
							{
								current2 = enumerator2.Current;
								int num13;
								if (_202D_206C_202A_206A_200F_202E_200F_202B_206D_206C_206D_202B_200D_200F_202C_202D_206B_206B_202B_206B_200B_206F_200D_202D_206D_200F_202A_200E_206A_200D_202A_200C_200E_206B_200D_206A_200E_200E_200F_206E_202E(current2, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3816599084u)))
								{
									num10 = 102186388;
									num13 = num10;
								}
								else
								{
									num10 = 2010590023;
									num13 = num10;
								}
								continue;
							}
							case 0u:
							{
								num14 = CommonSettings.AttributeToIndex(current2);
								int num17;
								if (num14 != 16)
								{
									num10 = 202938319;
									num17 = num10;
								}
								else
								{
									num10 = 1046532020;
									num17 = num10;
								}
								continue;
							}
							case 8u:
								num10 = ((int)num2 * -597400673) ^ -404011886;
								continue;
							case 4u:
								text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, _206C_202C_200B_206A_202D_206A_200D_200D_206E_200D_206A_200B_202A_200C_206C_200E_202D_206F_200F_206B_200C_206C_206E_200F_202C_200B_206C_202E_206D_200F_206F_206B_200B_206B_200C_206F_202E_206B_202E_202C_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3545399874u), (object)CommonSettings.RoleAttributeChineseList[num14], (object)itemRequireAttrs[current2]));
								num10 = 2094819910;
								continue;
							case 3u:
								text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, _206C_202C_200B_206A_202D_206A_200D_200D_206E_200D_206A_200B_202A_200C_206C_200E_202D_206F_200F_206B_200C_206C_206E_200F_202C_200B_206C_202E_206D_200F_206F_206B_200B_206B_200C_206F_202E_206B_202E_202C_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2297210305u), (object)CommonSettings.RoleAttributeChineseList[num14], (object)((itemRequireAttrs[current2] == 1) ? ResourceStrings.ResStrings[432] : ResourceStrings.ResStrings[433])));
								num10 = 2094819910;
								continue;
							case 1u:
							{
								int num15;
								int num16;
								if (num12 != 16)
								{
									num15 = -568929691;
									num16 = num15;
								}
								else
								{
									num15 = -290157872;
									num16 = num15;
								}
								num10 = num15 ^ ((int)num2 * -2105009087);
								continue;
							}
							case 6u:
								text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, _206C_202C_200B_206A_202D_206A_200D_200D_206E_200D_206A_200B_202A_200C_206C_200E_202D_206F_200F_206B_200C_206C_206E_200F_202C_200B_206C_202E_206D_200F_206F_206B_200B_206B_200C_206F_202E_206B_202E_202C_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1132125344u), (object)CommonSettings.RoleAttributeChineseList[num12], (object)((itemRequireAttrs[current2] == 1) ? ResourceStrings.ResStrings[432] : ResourceStrings.ResStrings[433])));
								num10 = 2094819910;
								continue;
							case 9u:
								break;
							case 7u:
								num12 = CommonSettings.AttributeToIndex(_202B_206E_206E_202C_200C_200C_202D_202B_206B_200B_200C_202A_200C_200C_206C_200B_206E_206B_206C_202A_206D_206C_200D_202C_202E_200B_200B_200B_206B_200D_206F_202D_202D_200E_206B_202C_202A_202B_200F_202E(current2, 1, _202A_206C_200F_200F_202C_206B_206D_200B_202D_202A_200B_206D_206C_202A_202C_202E_200F_206F_202C_202D_200F_200F_200E_200B_200F_200B_202B_206C_200B_200C_200E_202C_206C_206C_200E_202B_200C_200C_206B_200D_202E(current2) - 1));
								num10 = (int)((num2 * 1023360073) ^ 0xB530FE1);
								continue;
							case 11u:
								text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, _206C_202C_200B_206A_202D_206A_200D_200D_206E_200D_206A_200B_202A_200C_206C_200E_202D_206F_200F_206B_200C_206C_206E_200F_202C_200B_206C_202E_206D_200F_206F_206B_200B_206B_200C_206F_202E_206B_202E_202C_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4119622751u), (object)CommonSettings.RoleAttributeChineseList[num12], (object)itemRequireAttrs[current2]));
								num10 = 1417477739;
								continue;
							case 5u:
								goto end_IL_020a;
							}
							goto IL_03b1;
							continue;
							end_IL_020a:
							break;
						}
						break;
					}
				}
				List<string> itemRequireTalents = getItemRequireTalents();
				if (itemRequireTalents.Count > 0)
				{
					bool flag = default(bool);
					while (true)
					{
						int num18 = 1335583919;
						while (true)
						{
							switch ((num2 = (uint)(num18 ^ 0x6BAF3EC7)) % 5)
							{
							case 3u:
								break;
							case 2u:
							{
								int num19;
								int num20;
								if (_206C_206E_202C_206C_200C_206C_202E_202C_206D_202C_206C_200B_200D_200C_200B_202C_200E_200B_200B_200F_202B_202A_202B_202C_202C_202A_200C_202A_202C_206E_200C_202C_202E_200D_200E_202B_202C_200C_206C_202E_202E(text, string.Empty))
								{
									num19 = -1217602444;
									num20 = num19;
								}
								else
								{
									num19 = -778698976;
									num20 = num19;
								}
								num18 = num19 ^ (int)(num2 * 663521517);
								continue;
							}
							case 4u:
								text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(_206E_206B_202D_200F_200E_200E_206C_200C_206E_206A_202B_200E_206B_202A_200F_206F_206B_200D_206A_206D_200B_206C_202A_206B_202E_202B_202D_202B_206B_200D_202C_206F_200F_206A_206A_206C_200D_200D_200C_202C_202E(text, new char[0]), global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(390903560u));
								num18 = ((int)num2 * -1116452102) ^ 0x37CC2E76;
								continue;
							case 0u:
								flag = false;
								num18 = 1062115456;
								continue;
							default:
								goto end_IL_0451;
							}
							break;
						}
						continue;
						end_IL_0451:
						break;
					}
					using List<string>.Enumerator enumerator3 = itemRequireTalents.GetEnumerator();
					bool flag2 = default(bool);
					string[] array = default(string[]);
					int num23 = default(int);
					int num27 = default(int);
					while (true)
					{
						IL_05a8:
						int num21;
						int num22;
						if (enumerator3.MoveNext())
						{
							num21 = 2013687647;
							num22 = num21;
						}
						else
						{
							num21 = 1944137106;
							num22 = num21;
						}
						while (true)
						{
							switch ((num2 = (uint)(num21 ^ 0x6BAF3EC7)) % 17)
							{
							case 10u:
								num21 = 2013687647;
								continue;
							default:
								goto end_IL_04ee;
							case 12u:
								text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, ResourceStrings.ResStrings[435]);
								num21 = 966133416;
								continue;
							case 14u:
								text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, ResourceStrings.ResStrings[434]);
								num21 = ((int)num2 * -1788660048) ^ -729355594;
								continue;
							case 0u:
								flag2 = false;
								num21 = 694363721;
								continue;
							case 5u:
								flag2 = true;
								num21 = 1844712883;
								continue;
							case 7u:
								break;
							case 8u:
								text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(_206E_206B_202D_200F_200E_200E_206C_200C_206E_206A_202B_200E_206B_202A_200F_206F_206B_200D_206A_206D_200B_206C_202A_206B_202E_202B_202D_202B_206B_200D_202C_206F_200F_206A_206A_206C_200D_200D_200C_202C_202E(text, new char[0]), ResourceStrings.ResStrings[436]);
								num21 = ((int)num2 * -596480680) ^ -913199518;
								continue;
							case 9u:
							{
								int num25;
								int num26;
								if (_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(array[0], global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4080104489u)))
								{
									num25 = -408618895;
									num26 = num25;
								}
								else
								{
									num25 = -763289259;
									num26 = num25;
								}
								num21 = num25 ^ (int)(num2 * 1440311911);
								continue;
							}
							case 4u:
							{
								int num28;
								if (flag2)
								{
									num21 = 1660997678;
									num28 = num21;
								}
								else
								{
									num21 = 1266796222;
									num28 = num21;
								}
								continue;
							}
							case 11u:
								num23 = num27;
								num21 = ((int)num2 * -25307298) ^ -1006275448;
								continue;
							case 13u:
							{
								string current3 = enumerator3.Current;
								if (flag)
								{
									text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(_206E_206B_202D_200F_200E_200E_206C_200C_206E_206A_202B_200E_206B_202A_200F_206F_206B_200D_206A_206D_200B_206C_202A_206B_202E_202B_202D_202B_206B_200D_202C_206F_200F_206A_206A_206C_200D_200D_200C_202C_202E(text, new char[0]), global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(390903560u));
								}
								else
								{
									flag = true;
								}
								array = _206B_200E_206B_200C_202B_202E_200D_200C_202D_200D_202E_200E_200B_200B_206E_202E_200B_202B_206B_202C_206F_200F_200D_200D_200F_206D_200C_206C_202E_202B_202D_200F_200D_202A_200F_202C_206F_202A_200D_202B_202E(current3, new char[1] { '|' });
								num27 = 0;
								num21 = 1710458049;
								continue;
							}
							case 3u:
								num27 = 1;
								num21 = (int)(num2 * 1024673595) ^ -473660684;
								continue;
							case 1u:
								text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, _200B_206F_202E_206F_200C_206A_206D_206E_206B_200C_206A_206C_206C_206B_200D_200D_206F_202B_200F_202C_206E_200C_202B_200B_202D_206D_202A_206D_200F_206A_206A_200D_202B_200C_202A_202A_200F_206F_202E_202B_202E(_202D_202B_206C_200E_206A_202A_200F_200E_206F_200F_202A_200C_206D_206C_202B_200C_200C_200F_206F_206D_202C_206A_200D_202C_206D_200D_200B_200E_202D_200E_206E_202B_200D_200E_202A_202B_200F_206B_206E_200E_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3516972026u), array[num23], global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1272141780u)), new object[0]));
								num23++;
								num21 = 350433964;
								continue;
							case 16u:
							{
								int num24;
								if (num23 >= array.Length)
								{
									num21 = 1271121765;
									num24 = num21;
								}
								else
								{
									num21 = 324549223;
									num24 = num21;
								}
								continue;
							}
							case 6u:
								num21 = ((int)num2 * -594236944) ^ 0x4BA4B958;
								continue;
							case 15u:
								num21 = (int)((num2 * 1419476764) ^ 0x7F25761F);
								continue;
							case 2u:
								goto end_IL_04ee;
							}
							goto IL_05a8;
							continue;
							end_IL_04ee:
							break;
						}
						break;
					}
				}
				List<string> itemRequireRoleKeys = getItemRequireRoleKeys();
				int num32 = default(int);
				string[] array2 = default(string[]);
				bool flag4 = default(bool);
				int num33 = default(int);
				bool flag5 = default(bool);
				string[] array4 = default(string[]);
				string[] array3 = default(string[]);
				int num46 = default(int);
				bool flag6 = default(bool);
				int num45 = default(int);
				string[] array5 = default(string[]);
				int num55 = default(int);
				string[] array6 = default(string[]);
				int num60 = default(int);
				int num61 = default(int);
				int num56 = default(int);
				bool flag8 = default(bool);
				while (true)
				{
					int num29 = 739190895;
					while (true)
					{
						List<string> itemRequireStorys;
						List<string> itemRequireItems;
						switch ((num2 = (uint)(num29 ^ 0x6BAF3EC7)) % 5)
						{
						case 3u:
							break;
						case 2u:
							text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(_206E_206B_202D_200F_200E_200E_206C_200C_206E_206A_202B_200E_206B_202A_200F_206F_206B_200D_206A_206D_200B_206C_202A_206B_202E_202B_202D_202B_206B_200D_202C_206F_200F_206A_206A_206C_200D_200D_200C_202C_202E(text, new char[0]), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(373182451u));
							num29 = ((int)num2 * -1222987562) ^ 0x6F1A7ACC;
							continue;
						case 0u:
						{
							int num38;
							int num39;
							if (!_206C_206E_202C_206C_200C_206C_202E_202C_206D_202C_206C_200B_200D_200C_200B_202C_200E_200B_200B_200F_202B_202A_202B_202C_202C_202A_200C_202A_202C_206E_200C_202C_202E_200D_200E_202B_202C_200C_206C_202E_202E(text, string.Empty))
							{
								num38 = -813908444;
								num39 = num38;
							}
							else
							{
								num38 = -70893166;
								num39 = num38;
							}
							num29 = num38 ^ ((int)num2 * -275088565);
							continue;
						}
						case 1u:
							if (itemRequireRoleKeys.Count > 0)
							{
								num29 = ((int)num2 * -1703911243) ^ -1606747111;
								continue;
							}
							goto IL_0a62;
						default:
							{
								bool flag3 = false;
								using (List<string>.Enumerator enumerator3 = itemRequireRoleKeys.GetEnumerator())
								{
									while (true)
									{
										IL_085d:
										int num30;
										int num31;
										if (!enumerator3.MoveNext())
										{
											num30 = 225276109;
											num31 = num30;
										}
										else
										{
											num30 = 1686626430;
											num31 = num30;
										}
										while (true)
										{
											switch ((num2 = (uint)(num30 ^ 0x6BAF3EC7)) % 17)
											{
											case 2u:
												num30 = 1686626430;
												continue;
											default:
												goto end_IL_0803;
											case 7u:
												break;
											case 9u:
												num32++;
												num30 = (int)(num2 * 244428169) ^ -2093541362;
												continue;
											case 16u:
												text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, _200B_206F_202E_206F_200C_206A_206D_206E_206B_200C_206A_206C_206C_206B_200D_200D_206F_202B_200F_202C_206E_200C_202B_200B_202D_206D_202A_206D_200F_206A_206A_200D_202B_200C_202A_202A_200F_206F_202E_202B_202E(_202D_202B_206C_200E_206A_202A_200F_200E_206F_200F_202A_200C_206D_206C_202B_200C_200C_200F_206F_206D_202C_206A_200D_202C_206D_200D_200B_200E_202D_200E_206E_202B_200D_200E_202A_202B_200F_206B_206E_200E_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3516972026u), array2[num32], global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(487703859u)), new object[0]));
												num30 = 1870880621;
												continue;
											case 4u:
											{
												int num37;
												if (!flag4)
												{
													num30 = 1159900635;
													num37 = num30;
												}
												else
												{
													num30 = 1429359705;
													num37 = num30;
												}
												continue;
											}
											case 12u:
												flag4 = false;
												num30 = 134355330;
												continue;
											case 5u:
												flag4 = true;
												num30 = 602858694;
												continue;
											case 3u:
											{
												string current4 = enumerator3.Current;
												if (flag3)
												{
													text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(_206E_206B_202D_200F_200E_200E_206C_200C_206E_206A_202B_200E_206B_202A_200F_206F_206B_200D_206A_206D_200B_206C_202A_206B_202E_202B_202D_202B_206B_200D_202C_206F_200F_206A_206A_206C_200D_200D_200C_202C_202E(text, new char[0]), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(373182451u));
												}
												else
												{
													flag3 = true;
												}
												array2 = _206B_200E_206B_200C_202B_202E_200D_200C_202D_200D_202E_200E_200B_200B_206E_202E_200B_202B_206B_202C_206F_200F_200D_200D_200F_206D_200C_206C_202E_202B_202D_200F_200D_202A_200F_202C_206F_202A_200D_202B_202E(current4, new char[1] { '|' });
												num30 = 715277955;
												continue;
											}
											case 0u:
												num33 = 1;
												text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, ResourceStrings.ResStrings[437]);
												num30 = ((int)num2 * -1840292586) ^ 0x40E194D;
												continue;
											case 14u:
												num30 = (int)(num2 * 1642396772) ^ -2101391320;
												continue;
											case 1u:
											{
												int num35;
												int num36;
												if (_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(array2[0], global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1102747038u)))
												{
													num35 = -323235001;
													num36 = num35;
												}
												else
												{
													num35 = -1592572711;
													num36 = num35;
												}
												num30 = num35 ^ (int)(num2 * 418160496);
												continue;
											}
											case 11u:
												num33 = 0;
												num30 = ((int)num2 * -2090324593) ^ 0x2C7CD630;
												continue;
											case 8u:
											{
												int num34;
												if (num32 < array2.Length)
												{
													num30 = 380101974;
													num34 = num30;
												}
												else
												{
													num30 = 1517159861;
													num34 = num30;
												}
												continue;
											}
											case 15u:
												text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(_206E_206B_202D_200F_200E_200E_206C_200C_206E_206A_202B_200E_206B_202A_200F_206F_206B_200D_206A_206D_200B_206C_202A_206B_202E_202B_202D_202B_206B_200D_202C_206F_200F_206A_206A_206C_200D_200D_200C_202C_202E(text, new char[0]), ResourceStrings.ResStrings[436]);
												num30 = ((int)num2 * -108954654) ^ 0x7F41FDBA;
												continue;
											case 13u:
												text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, ResourceStrings.ResStrings[438]);
												num30 = 2062301101;
												continue;
											case 6u:
												num32 = num33;
												num30 = (int)(num2 * 1562101992) ^ -1314385600;
												continue;
											case 10u:
												goto end_IL_0803;
											}
											goto IL_085d;
											continue;
											end_IL_0803:
											break;
										}
										break;
									}
								}
								goto IL_0a62;
							}
							IL_0a62:
							itemRequireStorys = getItemRequireStorys();
							if (itemRequireStorys.Count > 0)
							{
								while (true)
								{
									int num40 = 1658500039;
									while (true)
									{
										switch ((num2 = (uint)(num40 ^ 0x6BAF3EC7)) % 5)
										{
										case 4u:
											break;
										case 2u:
										{
											int num41;
											int num42;
											if (_206C_206E_202C_206C_200C_206C_202E_202C_206D_202C_206C_200B_200D_200C_200B_202C_200E_200B_200B_200F_202B_202A_202B_202C_202C_202A_200C_202A_202C_206E_200C_202C_202E_200D_200E_202B_202C_200C_206C_202E_202E(text, string.Empty))
											{
												num41 = -1544065968;
												num42 = num41;
											}
											else
											{
												num41 = -1493009778;
												num42 = num41;
											}
											num40 = num41 ^ ((int)num2 * -2113834151);
											continue;
										}
										case 1u:
											text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(_206E_206B_202D_200F_200E_200E_206C_200C_206E_206A_202B_200E_206B_202A_200F_206F_206B_200D_206A_206D_200B_206C_202A_206B_202E_202B_202D_202B_206B_200D_202C_206F_200F_206A_206A_206C_200D_200D_200C_202C_202E(text, new char[0]), global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(925971650u));
											num40 = ((int)num2 * -1833237457) ^ -410448073;
											continue;
										case 0u:
											flag5 = false;
											num40 = 582495684;
											continue;
										default:
											goto end_IL_0a77;
										}
										break;
									}
									continue;
									end_IL_0a77:
									break;
								}
								using List<string>.Enumerator enumerator3 = itemRequireStorys.GetEnumerator();
								while (true)
								{
									IL_0c7e:
									int num43;
									int num44;
									if (!enumerator3.MoveNext())
									{
										num43 = 544108894;
										num44 = num43;
									}
									else
									{
										num43 = 1056727672;
										num44 = num43;
									}
									while (true)
									{
										switch ((num2 = (uint)(num43 ^ 0x6BAF3EC7)) % 18)
										{
										case 13u:
											num43 = 1056727672;
											continue;
										default:
											goto end_IL_0b15;
										case 6u:
											text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, ResourceStrings.ResStrings[440]);
											num43 = 565254104;
											continue;
										case 9u:
											num43 = (int)((num2 * 78674973) ^ 0x5FB19E68);
											continue;
										case 4u:
											text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, _200B_206F_202E_206F_200C_206A_206D_206E_206B_200C_206A_206C_206C_206B_200D_200D_206F_202B_200F_202C_206E_200C_202B_200B_202D_206D_202A_206D_200F_206A_206A_200D_202B_200C_202A_202A_200F_206F_202E_202B_202E(_202D_202B_206C_200E_206A_202A_200F_200E_206F_200F_202A_200C_206D_206C_202B_200C_200C_200F_206F_206D_202C_206A_200D_202C_206D_200D_200B_200E_202D_200E_206E_202B_200D_200E_202A_202B_200F_206B_206E_200E_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3734077339u), array4[0], global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2757850461u)), new object[0]));
											num43 = (int)((num2 * 206463469) ^ 0x107EF1D9);
											continue;
										case 16u:
											text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(_206E_206B_202D_200F_200E_200E_206C_200C_206E_206A_202B_200E_206B_202A_200F_206F_206B_200D_206A_206D_200B_206C_202A_206B_202E_202B_202D_202B_206B_200D_202C_206F_200F_206A_206A_206C_200D_200D_200C_202C_202E(text, new char[0]), ResourceStrings.ResStrings[436]);
											num43 = ((int)num2 * -1999086590) ^ -1107299048;
											continue;
										case 10u:
											text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, ResourceStrings.ResStrings[439]);
											num43 = ((int)num2 * -497518964) ^ -1365201024;
											continue;
										case 15u:
										{
											array4 = _206B_200E_206B_200C_202B_202E_200D_200C_202D_200D_202E_200E_200B_200B_206E_202E_200B_202B_206B_202C_206F_200F_200D_200D_200F_206D_200C_206C_202E_202B_202D_200F_200D_202A_200F_202C_206F_202A_200D_202B_202E(array3[num46], new char[1] { ',' });
											int num48;
											if (flag6)
											{
												num43 = 995128085;
												num48 = num43;
											}
											else
											{
												num43 = 567773551;
												num48 = num43;
											}
											continue;
										}
										case 14u:
											flag6 = true;
											num43 = 1213433735;
											continue;
										case 3u:
											break;
										case 12u:
										{
											int num51;
											if (num46 < array3.Length)
											{
												num43 = 53342038;
												num51 = num43;
											}
											else
											{
												num43 = 343048988;
												num51 = num43;
											}
											continue;
										}
										case 17u:
											text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, _200B_206F_202E_206F_200C_206A_206D_206E_206B_200C_206A_206C_206C_206B_200D_200D_206F_202B_200F_202C_206E_200C_202B_200B_202D_206D_202A_206D_200F_206A_206A_200D_202B_200C_202A_202A_200F_206F_202E_202B_202E(_202D_202B_206C_200E_206A_202A_200F_200E_206F_200F_202A_200C_206D_206C_202B_200C_200C_200F_206F_206D_202C_206A_200D_202C_206D_200D_200B_200E_202D_200E_206E_202B_200D_200E_202A_202B_200F_206B_206E_200E_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3516972026u), array4[1], global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4172553623u)), new object[0]));
											num43 = 60208365;
											continue;
										case 7u:
										{
											num45 = 0;
											int num49;
											int num50;
											if (!_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(array3[0], global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2651523886u)))
											{
												num49 = 399114143;
												num50 = num49;
											}
											else
											{
												num49 = 246158931;
												num50 = num49;
											}
											num43 = num49 ^ ((int)num2 * -51537506);
											continue;
										}
										case 11u:
											flag6 = false;
											num46 = num45;
											num43 = 1593768595;
											continue;
										case 2u:
										{
											int num47;
											if (array4.Length != 1)
											{
												num43 = 605549646;
												num47 = num43;
											}
											else
											{
												num43 = 219626819;
												num47 = num43;
											}
											continue;
										}
										case 8u:
											num46++;
											num43 = 1593768595;
											continue;
										case 0u:
											num45 = 1;
											num43 = ((int)num2 * -981393168) ^ 0x2A449B55;
											continue;
										case 1u:
										{
											string current5 = enumerator3.Current;
											if (flag5)
											{
												text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(_206E_206B_202D_200F_200E_200E_206C_200C_206E_206A_202B_200E_206B_202A_200F_206F_206B_200D_206A_206D_200B_206C_202A_206B_202E_202B_202D_202B_206B_200D_202C_206F_200F_206A_206A_206C_200D_200D_200C_202C_202E(text, new char[0]), global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2910989005u));
											}
											else
											{
												flag5 = true;
											}
											array3 = _206B_200E_206B_200C_202B_202E_200D_200C_202D_200D_202E_200E_200B_200B_206E_202E_200B_202B_206B_202C_206F_200F_200D_200D_200F_206D_200C_206C_202E_202B_202D_200F_200D_202A_200F_202C_206F_202A_200D_202B_202E(current5, new char[1] { '|' });
											num43 = 744419542;
											continue;
										}
										case 5u:
											goto end_IL_0b15;
										}
										goto IL_0c7e;
										continue;
										end_IL_0b15:
										break;
									}
									break;
								}
							}
							itemRequireItems = getItemRequireItems();
							while (true)
							{
								int num52 = 657226353;
								while (true)
								{
									switch ((num2 = (uint)(num52 ^ 0x6BAF3EC7)) % 5)
									{
									case 3u:
										break;
									case 0u:
										text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(_206E_206B_202D_200F_200E_200E_206C_200C_206E_206A_202B_200E_206B_202A_200F_206F_206B_200D_206A_206D_200B_206C_202A_206B_202E_202B_202D_202B_206B_200D_202C_206F_200F_206A_206A_206C_200D_200D_200C_202C_202E(text, new char[0]), global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3271294194u));
										num52 = (int)(num2 * 530558357) ^ -509883168;
										continue;
									case 1u:
									{
										int num71;
										int num72;
										if (!_206C_206E_202C_206C_200C_206C_202E_202C_206D_202C_206C_200B_200D_200C_200B_202C_200E_200B_200B_200F_202B_202A_202B_202C_202C_202A_200C_202A_202C_206E_200C_202C_202E_200D_200E_202B_202C_200C_206C_202E_202E(text, string.Empty))
										{
											num71 = 165766842;
											num72 = num71;
										}
										else
										{
											num71 = 129429877;
											num72 = num71;
										}
										num52 = num71 ^ (int)(num2 * 1986048846);
										continue;
									}
									case 2u:
										if (itemRequireItems.Count > 0)
										{
											num52 = ((int)num2 * -1606996805) ^ -1107330355;
											continue;
										}
										goto IL_13c7;
									default:
										{
											bool flag7 = false;
											using (List<string>.Enumerator enumerator3 = itemRequireItems.GetEnumerator())
											{
												while (true)
												{
													IL_1366:
													int num53;
													int num54;
													if (enumerator3.MoveNext())
													{
														num53 = 617229758;
														num54 = num53;
													}
													else
													{
														num53 = 1325044717;
														num54 = num53;
													}
													while (true)
													{
														int num57;
														int num59;
														int num58;
														int num64;
														switch ((num2 = (uint)(num53 ^ 0x6BAF3EC7)) % 27)
														{
														case 3u:
															num53 = 617229758;
															continue;
														default:
															goto end_IL_0e8b;
														case 18u:
															text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, _200B_206F_202E_206F_200C_206A_206D_206E_206B_200C_206A_206C_206C_206B_200D_200D_206F_202B_200F_202C_206E_200C_202B_200B_202D_206D_202A_206D_200F_206A_206A_200D_202B_200C_202A_202A_200F_206F_202E_202B_202E(_202E_206C_200B_206B_206D_202A_206F_202E_202C_206A_206E_206E_206A_200E_200B_200F_202B_202B_200C_202B_202D_200F_202E_206E_200D_206D_206F_206A_202E_202B_200B_206E_206C_200E_202A_206C_200B_206D_202B_202C_202E(new string[5]
															{
																global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3734077339u),
																array5[0],
																global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3583135367u),
																ResourceStrings.ResStrings[1075],
																global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1252436857u)
															}), new object[0]));
															num53 = 1333145644;
															continue;
														case 22u:
														{
															int num68;
															if (num55 >= array6.Length)
															{
																num53 = 1638094533;
																num68 = num53;
															}
															else
															{
																num53 = 1911567711;
																num68 = num53;
															}
															continue;
														}
														case 7u:
															if (_202D_202A_206F_206C_206D_206A_206A_206C_202D_200B_200C_206E_206A_200F_202E_202E_206D_202C_206C_206F_206B_202D_206A_206B_200E_206D_200C_202D_202C_202D_206A_206D_200B_200B_206F_206F_200F_200F_206F_202B_202E(array5[1]))
															{
																num53 = 1035877097;
																continue;
															}
															num57 = _206A_200D_200D_202D_202C_206E_206A_200E_200F_202A_206A_200D_206C_202B_206D_206F_202E_202A_200D_200C_200E_202C_202C_200F_202B_200C_202A_200F_206D_206A_206F_200E_206E_200D_200E_200C_206B_206B_206D_200E_202E(1, int.Parse(array5[1]));
															goto IL_1343;
														case 0u:
														{
															int num65;
															if (array5.Length != 1)
															{
																num53 = 60477012;
																num65 = num53;
															}
															else
															{
																num53 = 496279300;
																num65 = num53;
															}
															continue;
														}
														case 11u:
															text += string.Format(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3734077339u) + array5[0] + global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(487703859u) + ResourceStrings.ResStrings[1075] + global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2365314062u) + (num60 - 1) + global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2309876135u) + num61 + global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2757850461u));
															num53 = 1065616826;
															continue;
														case 2u:
														{
															string current6 = enumerator3.Current;
															if (flag7)
															{
																text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(_206E_206B_202D_200F_200E_200E_206C_200C_206E_206A_202B_200E_206B_202A_200F_206F_206B_200D_206A_206D_200B_206C_202A_206B_202E_202B_202D_202B_206B_200D_202C_206F_200F_206A_206A_206C_200D_200D_200C_202C_202E(text, new char[0]), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(373182451u));
															}
															else
															{
																flag7 = true;
															}
															array6 = _206B_200E_206B_200C_202B_202E_200D_200C_202D_200D_202E_200E_200B_200B_206E_202E_200B_202B_206B_202C_206F_200F_200D_200D_200F_206D_200C_206C_202E_202B_202D_200F_200D_202A_200F_202C_206F_202A_200D_202B_202E(current6, new char[1] { '|' });
															num53 = 2088767216;
															continue;
														}
														case 17u:
															num59 = 0;
															goto IL_10b9;
														case 14u:
															if (!_202D_202A_206F_206C_206D_206A_206A_206C_202D_200B_200C_206E_206A_200F_202E_202E_206D_202C_206C_206F_206B_202D_206A_206B_200E_206D_200C_202D_202C_202D_206A_206D_200B_200B_206F_206F_200F_200F_206F_202B_202E(array5[2]))
															{
																num59 = _206A_200D_200D_202D_202C_206E_206A_200E_200F_202A_206A_200D_206C_202B_206D_206F_202E_202A_200D_200C_200E_202C_202C_200F_202B_200C_202A_200F_206D_206A_206F_200E_206E_200D_200E_200C_206B_206B_206D_200E_202E(0, int.Parse(array5[2]));
																goto IL_10b9;
															}
															num53 = ((int)num2 * -1132469372) ^ 0x4971543E;
															continue;
														case 9u:
															text += string.Format(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3516972026u) + array5[0] + global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3270650518u) + ResourceStrings.ResStrings[1075] + global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1072021771u) + num60 + global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2309876135u) + num61 + global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1272141780u));
															num53 = ((int)num2 * -2125574316) ^ -1044098937;
															continue;
														case 20u:
														{
															int num69;
															int num70;
															if (num56 != 0)
															{
																num69 = -1009519302;
																num70 = num69;
															}
															else
															{
																num69 = -150383787;
																num70 = num69;
															}
															num53 = num69 ^ (int)(num2 * 618700020);
															continue;
														}
														case 6u:
															num53 = ((int)num2 * -1425601500) ^ -299510406;
															continue;
														case 10u:
															flag8 = true;
															num53 = 1843425026;
															continue;
														case 25u:
															num58 = 0;
															goto IL_11d5;
														case 13u:
														{
															int num66;
															int num67;
															if (array5.Length > 2)
															{
																num66 = -382213029;
																num67 = num66;
															}
															else
															{
																num66 = -1268612087;
																num67 = num66;
															}
															num53 = num66 ^ (int)(num2 * 1239090927);
															continue;
														}
														case 12u:
														{
															int num62;
															int num63;
															if (!flag8)
															{
																num62 = 1912705595;
																num63 = num62;
															}
															else
															{
																num62 = 202721948;
																num63 = num62;
															}
															num53 = num62 ^ (int)(num2 * 2068402403);
															continue;
														}
														case 8u:
															num55++;
															num53 = 1677106098;
															continue;
														case 15u:
															text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, _200B_206F_202E_206F_200C_206A_206D_206E_206B_200C_206A_206C_206C_206B_200D_200D_206F_202B_200F_202C_206E_200C_202B_200B_202D_206D_202A_206D_200F_206A_206A_200D_202B_200C_202A_202A_200F_206F_202E_202B_202E(_202E_206C_200B_206B_206D_202A_206F_202E_202C_206A_206E_206E_206A_200E_200B_200F_202B_202B_200C_202B_202D_200F_202E_206E_200D_206D_206F_206A_202E_202B_200B_206E_206C_200E_202A_206C_200B_206D_202B_202C_202E(new string[5]
															{
																global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1449247610u),
																array5[0],
																global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(487703859u),
																ResourceStrings.ResStrings[1075],
																global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4017330499u)
															}), new object[0]));
															num53 = ((int)num2 * -415629297) ^ -1938334424;
															continue;
														case 23u:
															if (_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(array6[0], global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1102747038u)))
															{
																num58 = 1;
																goto IL_11d5;
															}
															num53 = (int)((num2 * 657919256) ^ 0x253F0277);
															continue;
														case 1u:
															num53 = (int)((num2 * 1793478258) ^ 0x7FD23B1C);
															continue;
														case 5u:
															array5 = _206B_200E_206B_200C_202B_202E_200D_200C_202D_200D_202E_200E_200B_200B_206E_202E_200B_202B_206B_202C_206F_200F_200D_200D_200F_206D_200C_206C_202E_202B_202D_200F_200D_202A_200F_202C_206F_202A_200D_202B_202E(array6[num55], new char[1] { ',' });
															num53 = 761833219;
															continue;
														case 21u:
															num53 = ((int)num2 * -1092935865) ^ -410485225;
															continue;
														case 24u:
															num57 = 1;
															goto IL_1343;
														case 4u:
															num55 = num56;
															num53 = (int)(num2 * 108226227) ^ -989008265;
															continue;
														case 26u:
															break;
														case 19u:
															text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(_206E_206B_202D_200F_200E_200E_206C_200C_206E_206A_202B_200E_206B_202A_200F_206F_206B_200D_206A_206D_200B_206C_202A_206B_202E_202B_202D_202B_206B_200D_202C_206F_200F_206A_206A_206C_200D_200D_200C_202C_202E(text, new char[0]), ResourceStrings.ResStrings[436]);
															num53 = ((int)num2 * -801906926) ^ 0x3FC5449C;
															continue;
														case 16u:
															goto end_IL_0e8b;
															IL_10b9:
															num61 = num59;
															if (num56 == 0)
															{
																num53 = 1567733643;
																num64 = num53;
															}
															else
															{
																num53 = 141130571;
																num64 = num53;
															}
															continue;
															IL_1343:
															num60 = num57;
															num53 = 2108132482;
															continue;
															IL_11d5:
															num56 = num58;
															text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, ResourceStrings.ResStrings[1076]);
															flag8 = false;
															num53 = 696117942;
															continue;
														}
														goto IL_1366;
														continue;
														end_IL_0e8b:
														break;
													}
													break;
												}
											}
											goto IL_13c7;
										}
										IL_13c7:
										return text.TrimEnd();
									}
									break;
								}
							}
						}
						break;
					}
				}
			}
			}
			goto IL_0008;
			IL_0045:
			text = string.Empty;
			num = 330618261;
			goto IL_000d;
		}
	}

	[XmlIgnore]
	public string DescriptionInRichtext
	{
		get
		{
			string text = _202D_202B_206C_200E_206A_202A_200F_200E_206F_200F_202A_200C_206D_206C_202B_200C_200C_200F_206F_206D_202C_206A_200D_202C_206D_200D_200B_200E_202D_200E_206E_202B_200D_200E_202A_202B_200F_206B_206E_200E_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(571174833u), desc, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1988573054u));
			string equipCase = EquipCase;
			string text2 = default(string);
			Trigger current = default(Trigger);
			string[] talents = default(string[]);
			int num34 = default(int);
			int num15 = default(int);
			SkillInstance current2 = default(SkillInstance);
			while (true)
			{
				int num = 163082005;
				while (true)
				{
					int num8;
					int num9;
					uint num2;
					switch ((num2 = (uint)(num ^ 0x64B7717E)) % 15)
					{
					case 14u:
						break;
					case 4u:
						num = ((int)num2 * -54285359) ^ 0x2F762B03;
						continue;
					case 9u:
						text2 = ResourceStrings.ResStrings[427];
						num = 2079717356;
						continue;
					case 12u:
						text2 = ResourceStrings.ResStrings[425];
						num = 943037889;
						continue;
					case 5u:
						text2 = ResourceStrings.ResStrings[426];
						num = (int)(num2 * 1755185203) ^ -1769151365;
						continue;
					case 3u:
					{
						int num47;
						int num48;
						if (type >= 1)
						{
							num47 = 1942100923;
							num48 = num47;
						}
						else
						{
							num47 = 1653889683;
							num48 = num47;
						}
						num = num47 ^ (int)(num2 * 442649616);
						continue;
					}
					case 0u:
						if (Triggers.Count > 0)
						{
							num = 1677410129;
							continue;
						}
						goto IL_0447;
					case 13u:
						text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, _206C_206A_202B_202E_206A_202B_206F_200B_202C_200E_202C_206D_202D_206A_202A_202E_200B_202E_200F_206B_200C_206B_200D_200C_202C_206A_200F_200D_202A_206A_202E_206C_206E_200F_200E_202A_200F_206D_206C_202E_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(770977575u), (object)ResourceStrings.ResStrings[442]));
						num = (int)(num2 * 893738556) ^ -1270629862;
						continue;
					case 2u:
						text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, _202E_206D_206E_206E_202D_206F_206B_200E_206F_206A_202D_200F_202E_206F_206C_200E_202C_202C_200C_200F_206E_202B_202C_202A_200C_202C_202D_200B_200F_206D_206C_206F_200E_200D_200E_202A_202E_202E_200F_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2270379056u), (object)text2, (object)ResourceStrings.ResStrings[441], (object)equipCase));
						num = 2010093946;
						continue;
					case 8u:
					{
						int num45;
						int num46;
						if (type > 3)
						{
							num45 = 1003068609;
							num46 = num45;
						}
						else
						{
							num45 = 2127936524;
							num46 = num45;
						}
						num = num45 ^ (int)(num2 * 281869738);
						continue;
					}
					case 7u:
						num = ((int)num2 * -25174827) ^ 0x11F3C407;
						continue;
					case 1u:
					{
						int num10;
						if (type == 12)
						{
							num = 1834075870;
							num10 = num;
						}
						else
						{
							num = 796320896;
							num10 = num;
						}
						continue;
					}
					case 11u:
					{
						int num7;
						if (type != 4)
						{
							num = 1245223846;
							num7 = num;
						}
						else
						{
							num = 1673376544;
							num7 = num;
						}
						continue;
					}
					case 6u:
					{
						int num5;
						int num6;
						if (_202A_202E_206A_206B_200F_200D_200E_206B_200C_202D_202A_202B_200B_202D_206E_206F_200E_200F_202B_206D_202A_206B_202A_206C_200E_206E_206E_206C_202E_200B_206A_200D_206E_200F_206D_202B_200B_202A_206C_200C_202E(equipCase, string.Empty))
						{
							num5 = -1262533747;
							num6 = num5;
						}
						else
						{
							num5 = -1323921855;
							num6 = num5;
						}
						num = num5 ^ (int)(num2 * 1512489125);
						continue;
					}
					default:
						{
							using (List<Trigger>.Enumerator enumerator = Triggers.GetEnumerator())
							{
								while (true)
								{
									IL_0273:
									int num3;
									int num4;
									if (!enumerator.MoveNext())
									{
										num3 = 1439953750;
										num4 = num3;
									}
									else
									{
										num3 = 1576256698;
										num4 = num3;
									}
									while (true)
									{
										switch ((num2 = (uint)(num3 ^ 0x64B7717E)) % 5)
										{
										case 3u:
											num3 = 1576256698;
											continue;
										default:
											goto end_IL_023d;
										case 2u:
											current = enumerator.Current;
											num3 = 554646344;
											continue;
										case 0u:
											break;
										case 1u:
											text = _202D_202B_206C_200E_206A_202A_200F_200E_206F_200F_202A_200C_206D_206C_202B_200C_200C_200F_206F_206D_202C_206A_200D_202C_206D_200D_200B_200E_202D_200E_206E_202B_200D_200E_202A_202B_200F_206B_206E_200E_202E(text, current.ToString2(), global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3271294194u));
											num3 = (int)(num2 * 574110042) ^ -1558519466;
											continue;
										case 4u:
											goto end_IL_023d;
										}
										goto IL_0273;
										continue;
										end_IL_023d:
										break;
									}
									break;
								}
							}
							text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(931496648u));
							goto IL_02d6;
						}
						IL_0447:
						if (Talents.Length != 0)
						{
							num8 = 695151767;
							num9 = num8;
						}
						else
						{
							num8 = 1556378760;
							num9 = num8;
						}
						goto IL_02db;
						IL_02db:
						while (true)
						{
							int num26;
							int num35;
							int num38;
							int num41;
							switch ((num2 = (uint)(num8 ^ 0x64B7717E)) % 12)
							{
							case 10u:
								break;
							case 7u:
								goto IL_0321;
							case 1u:
							{
								int num42;
								int num43;
								if (Triggers.Count == 0)
								{
									num42 = -531313196;
									num43 = num42;
								}
								else
								{
									num42 = -1441137141;
									num43 = num42;
								}
								num8 = num42 ^ (int)(num2 * 1929155694);
								continue;
							}
							case 4u:
								text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, _206C_206A_202B_202E_206A_202B_206F_200B_202C_200E_202C_206D_202D_206A_202A_202E_200B_202E_200F_206B_200C_206B_200D_200C_202C_206A_200F_200D_202A_206A_202E_206C_206E_200F_200E_202A_200F_206D_206C_202E_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3531775993u), (object)ResourceStrings.ResStrings[442]));
								num8 = ((int)num2 * -1855350541) ^ -20287287;
								continue;
							case 2u:
								text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, GetBuffsString());
								num8 = 1237678927;
								continue;
							case 6u:
							{
								string name = talents[num34];
								text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, _206C_206A_202B_202E_206A_202B_206F_200B_202C_200E_202C_206D_202D_206A_202A_202E_200B_202E_200F_206B_200C_206B_200D_200C_202C_206A_200F_200D_202A_206A_202E_206C_206E_200F_200E_202A_200F_206D_206C_202E_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3047814512u), (object)Resource.GetTalentInfo(name, displayCost: false)));
								num34++;
								num8 = 1494000833;
								continue;
							}
							case 0u:
								num8 = ((int)num2 * -1750750425) ^ 0x3BD25179;
								continue;
							case 3u:
								talents = Talents;
								num8 = 1009956458;
								continue;
							case 5u:
								if (Skills.Count > 0)
								{
									num8 = ((int)num2 * -887783992) ^ -1307513147;
									continue;
								}
								goto IL_077e;
							case 8u:
								num34 = 0;
								num8 = ((int)num2 * -390699787) ^ -1312200494;
								continue;
							case 9u:
								goto IL_0447;
							default:
								{
									text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, _206C_206A_202B_202E_206A_202B_206F_200B_202C_200E_202C_206D_202D_206A_202A_202E_200B_202E_200F_206B_200C_206B_200D_200C_202C_206A_200F_200D_202A_206A_202E_206C_206E_200F_200E_202A_200F_206D_206C_202E_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1415399060u), (object)ResourceStrings.ResStrings[443]));
									using (List<SkillInstance>.Enumerator enumerator2 = Skills.GetEnumerator())
									{
										while (true)
										{
											IL_066a:
											int num11;
											int num12;
											if (enumerator2.MoveNext())
											{
												num11 = 2035128631;
												num12 = num11;
											}
											else
											{
												num11 = 87134655;
												num12 = num11;
											}
											while (true)
											{
												switch ((num2 = (uint)(num11 ^ 0x64B7717E)) % 15)
												{
												case 10u:
													num11 = 2035128631;
													continue;
												default:
													goto end_IL_04a0;
												case 11u:
													num15 = (int)double.Parse(Tools.Compute(_206C_206F_206F_200D_202E_202D_200F_206D_202E_202B_202A_202D_206D_206A_206B_202E_202A_200B_206D_202C_206C_202C_202B_202B_202C_206F_206F_202B_200C_200F_202A_200F_206E_202D_206F_202B_200D_206B_200C_206A_202E(current2.levelformula, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3121341046u), RuntimeData.Instance.RoundString())));
													num11 = 1959498222;
													continue;
												case 4u:
												{
													int num18;
													int num19;
													if (_200C_206D_206A_200C_206A_202E_206F_202D_200B_202C_202B_202D_200C_206B_206D_206E_206C_202D_200F_202B_200C_200B_206D_202D_206C_202D_200C_200B_200D_206F_202E_200C_200C_202E_202A_206E_202B_202C_202B_200F_202E(current2.levelformula, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(108956290u)))
													{
														num18 = -612970762;
														num19 = num18;
													}
													else
													{
														num18 = -1572405790;
														num19 = num18;
													}
													num11 = num18 ^ ((int)num2 * -2130439683);
													continue;
												}
												case 0u:
													num15 = (int)double.Parse(current2.levelformula);
													num11 = 898606147;
													continue;
												case 12u:
												{
													int num24;
													int num25;
													if (!_200C_206D_206A_200C_206A_202E_206F_202D_200B_202C_202B_202D_200C_206B_206D_206E_206C_202D_200F_202B_200C_200B_206D_202D_206C_202D_200C_200B_200D_206F_202E_200C_200C_202E_202A_206E_202B_202C_202B_200F_202E(current2.levelformula, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1055545151u)))
													{
														num24 = -2057913919;
														num25 = num24;
													}
													else
													{
														num24 = -960244578;
														num25 = num24;
													}
													num11 = num24 ^ ((int)num2 * -1242871796);
													continue;
												}
												case 5u:
												{
													num15 = 1;
													int num20;
													int num21;
													if (!_202D_202A_206F_206C_206D_206A_206A_206C_202D_200B_200C_206E_206A_200F_202E_202E_206D_202C_206C_206F_206B_202D_206A_206B_200E_206D_200C_202D_202C_202D_206A_206D_200B_200B_206F_206F_200F_200F_206F_202B_202E(current2.levelformula))
													{
														num20 = -1540380078;
														num21 = num20;
													}
													else
													{
														num20 = -396195625;
														num21 = num20;
													}
													num11 = num20 ^ (int)(num2 * 647345622);
													continue;
												}
												case 13u:
													num11 = ((int)num2 * -2099702239) ^ 0x60FAF6D3;
													continue;
												case 14u:
													current2 = enumerator2.Current;
													num11 = 1842277664;
													continue;
												case 2u:
												{
													int num22;
													int num23;
													if (_200C_206D_206A_200C_206A_202E_206F_202D_200B_202C_202B_202D_200C_206B_206D_206E_206C_202D_200F_202B_200C_200B_206D_202D_206C_202D_200C_200B_200D_206F_202E_200C_200C_202E_202A_206E_202B_202C_202B_200F_202E(current2.levelformula, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3195734653u)))
													{
														num22 = -1676719110;
														num23 = num22;
													}
													else
													{
														num22 = -1978793634;
														num23 = num22;
													}
													num11 = num22 ^ ((int)num2 * -1514715461);
													continue;
												}
												case 7u:
												{
													int num16;
													int num17;
													if (_200C_206D_206A_200C_206A_202E_206F_202D_200B_202C_202B_202D_200C_206B_206D_206E_206C_202D_200F_202B_200C_200B_206D_202D_206C_202D_200C_200B_200D_206F_202E_200C_200C_202E_202A_206E_202B_202C_202B_200F_202E(current2.levelformula, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(904572443u)))
													{
														num16 = -1231745226;
														num17 = num16;
													}
													else
													{
														num16 = -69028774;
														num17 = num16;
													}
													num11 = num16 ^ (int)(num2 * 422990853);
													continue;
												}
												case 9u:
													break;
												case 8u:
													text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, _200B_206F_202E_206F_200C_206A_206D_206E_206B_200C_206A_206C_206C_206B_200D_200D_206F_202B_200F_202C_206E_200C_202B_200B_202D_206D_202A_206D_200F_206A_206A_200D_202B_200C_202A_202A_200F_206F_202E_202B_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3972918129u), new object[4]
													{
														current2.Name,
														ResourceStrings.ResStrings[444],
														num15,
														current2.Skill.Info
													}));
													num11 = (int)(num2 * 773491112) ^ -1822334789;
													continue;
												case 6u:
													num15 = _206A_200D_200D_202D_202C_206E_206A_200E_200F_202A_206A_200D_206C_202B_206D_206F_202E_202A_200D_200C_200E_202C_202C_200F_202B_200C_202A_200F_206D_206A_206F_200E_206E_200D_200E_200C_206B_206B_206D_200E_202E(num15, current2.level);
													num11 = 608766498;
													continue;
												case 1u:
												{
													int num13;
													int num14;
													if (_200C_206D_206A_200C_206A_202E_206F_202D_200B_202C_202B_202D_200C_206B_206D_206E_206C_202D_200F_202B_200C_200B_206D_202D_206C_202D_200C_200B_200D_206F_202E_200C_200C_202E_202A_206E_202B_202C_202B_200F_202E(current2.levelformula, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(36296972u)))
													{
														num13 = -1924090130;
														num14 = num13;
													}
													else
													{
														num13 = -1955572218;
														num14 = num13;
													}
													num11 = num13 ^ ((int)num2 * -1694490096);
													continue;
												}
												case 3u:
													goto end_IL_04a0;
												}
												goto IL_066a;
												continue;
												end_IL_04a0:
												break;
											}
											break;
										}
									}
									text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4087182628u));
									goto IL_075b;
								}
								IL_09a9:
								while (true)
								{
									switch ((num2 = (uint)(num26 ^ 0x64B7717E)) % 9)
									{
									case 6u:
										break;
									case 7u:
										goto IL_09e3;
									case 2u:
									{
										int num31;
										int num32;
										if (_206C_206E_202C_206C_200C_206C_202E_202C_206D_202C_206C_200B_200D_200C_200B_202C_200E_200B_200B_200F_202B_202A_202B_202C_202C_202A_200C_202A_202C_206E_200C_202C_202E_200D_200E_202B_202C_200C_206C_202E_202E(RuntimeData.Instance.GameMode, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2176767917u)))
										{
											num31 = -1769489558;
											num32 = num31;
										}
										else
										{
											num31 = -1300429773;
											num32 = num31;
										}
										num26 = num31 ^ (int)(num2 * 1720376592);
										continue;
									}
									case 5u:
									{
										int num29;
										int num30;
										if (!_200F_202D_200D_202C_206F_206D_206A_202B_206F_206B_206A_206D_200B_206F_206A_200D_202C_202E_200F_206F_206B_202C_202D_206F_200B_206F_200C_206D_202C_200D_200B_202C_206B_206D_206E_200F_200B_200B_206B_202E(text, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(390903560u)))
										{
											num29 = 638402889;
											num30 = num29;
										}
										else
										{
											num29 = 1459283910;
											num30 = num29;
										}
										num26 = num29 ^ ((int)num2 * -983884036);
										continue;
									}
									case 3u:
									{
										int num27;
										int num28;
										if (type == 14)
										{
											num27 = 152699594;
											num28 = num27;
										}
										else
										{
											num27 = 1551756415;
											num28 = num27;
										}
										num26 = num27 ^ ((int)num2 * -581558516);
										continue;
									}
									case 1u:
										text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, _206C_202C_200B_206A_202D_206A_200D_200D_206E_200D_206A_200B_202A_200C_206C_200E_202D_206F_200F_206B_200C_206C_206E_200F_202C_200B_206C_202E_206D_200F_206F_206B_200B_206B_200C_206F_202E_206B_202E_202C_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1757893715u), (object)ResourceStrings.ResStrings[430], (object)Cooldown));
										num26 = 1041666851;
										continue;
									case 8u:
										text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(925971650u));
										num26 = (int)(num2 * 225732074) ^ -1582784816;
										continue;
									case 4u:
										goto IL_0ae9;
									default:
										return text;
									}
									break;
									IL_09e3:
									int num33;
									if (Cooldown <= 0)
									{
										num26 = 1041666851;
										num33 = num26;
									}
									else
									{
										num26 = 1523542239;
										num33 = num26;
									}
								}
								goto IL_09a4;
								IL_09a4:
								num26 = 1515843794;
								goto IL_09a9;
								IL_077e:
								if (SpecialSkills.Count > 0)
								{
									num35 = 1747866376;
									goto IL_0760;
								}
								goto IL_08bf;
								IL_0760:
								switch ((num2 = (uint)(num35 ^ 0x64B7717E)) % 3)
								{
								case 0u:
									break;
								case 1u:
									goto IL_077e;
								default:
									goto IL_0796;
								}
								goto IL_075b;
								IL_0796:
								text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, _206C_206A_202B_202E_206A_202B_206F_200B_202C_200E_202C_206D_202D_206A_202A_202E_200B_202E_200F_206B_200C_206B_200D_200C_202C_206A_200F_200D_202A_206A_202E_206C_206E_200F_200E_202A_200F_206D_206C_202E_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1170073152u), (object)ResourceStrings.ResStrings[445]));
								using (List<SpecialSkillInstance>.Enumerator enumerator3 = SpecialSkills.GetEnumerator())
								{
									while (true)
									{
										IL_085a:
										int num36;
										int num37;
										if (enumerator3.MoveNext())
										{
											num36 = 1238475539;
											num37 = num36;
										}
										else
										{
											num36 = 1236935868;
											num37 = num36;
										}
										while (true)
										{
											switch ((num2 = (uint)(num36 ^ 0x64B7717E)) % 4)
											{
											case 3u:
												num36 = 1238475539;
												continue;
											default:
												goto end_IL_07d2;
											case 1u:
											{
												SpecialSkillInstance current3 = enumerator3.Current;
												text = _202E_206C_200B_206B_206D_202A_206F_202E_202C_206A_206E_206E_206A_200E_200B_200F_202B_202B_200C_202B_202D_200F_202E_206E_200D_206D_206F_206A_202E_202B_200B_206E_206C_200E_202A_206C_200B_206D_202B_202C_202E(new string[6]
												{
													text,
													global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2543745123u),
													current3.Name,
													global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3969677947u),
													current3.SpecialSkill.Info,
													global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3271294194u)
												});
												num36 = 800296754;
												continue;
											}
											case 0u:
												break;
											case 2u:
												goto end_IL_07d2;
											}
											goto IL_085a;
											continue;
											end_IL_07d2:
											break;
										}
										break;
									}
								}
								text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3984246105u));
								goto IL_0898;
								IL_075b:
								num35 = 2029420106;
								goto IL_0760;
								IL_08bf:
								if (AdditionTriggers.Count > 0)
								{
									num38 = 609014448;
									goto IL_089d;
								}
								goto IL_0ae9;
								IL_089d:
								while (true)
								{
									switch ((num2 = (uint)(num38 ^ 0x64B7717E)) % 4)
									{
									case 3u:
										break;
									case 1u:
										goto IL_08bf;
									case 2u:
										text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, _206C_206A_202B_202E_206A_202B_206F_200B_202C_200E_202C_206D_202D_206A_202A_202E_200B_202E_200F_206B_200C_206B_200D_200C_202C_206A_200F_200D_202A_206A_202E_206C_206E_200F_200E_202A_200F_206D_206C_202E_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(256760002u), (object)ResourceStrings.ResStrings[446]));
										num38 = (int)((num2 * 991064513) ^ 0x5B9567AC);
										continue;
									default:
										goto IL_090c;
									}
									break;
								}
								goto IL_0898;
								IL_090c:
								using (List<Trigger>.Enumerator enumerator = AdditionTriggers.GetEnumerator())
								{
									while (true)
									{
										IL_0969:
										int num39;
										int num40;
										if (enumerator.MoveNext())
										{
											num39 = 720421081;
											num40 = num39;
										}
										else
										{
											num39 = 531176303;
											num40 = num39;
										}
										while (true)
										{
											switch ((num2 = (uint)(num39 ^ 0x64B7717E)) % 4)
											{
											case 0u:
												num39 = 720421081;
												continue;
											default:
												goto end_IL_091f;
											case 3u:
											{
												Trigger current4 = enumerator.Current;
												text = _202D_202B_206C_200E_206A_202A_200F_200E_206F_200F_202A_200C_206D_206C_202B_200C_200C_200F_206F_206D_202C_206A_200D_202C_206D_200D_200B_200E_202D_200E_206E_202B_200D_200E_202A_202B_200F_206B_206E_200E_202E(text, current4.ToString2(), global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2910989005u));
												num39 = 1387895760;
												continue;
											}
											case 2u:
												break;
											case 1u:
												goto end_IL_091f;
											}
											goto IL_0969;
											continue;
											end_IL_091f:
											break;
										}
										break;
									}
								}
								text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(373234159u));
								goto IL_09a4;
								IL_0898:
								num38 = 553854771;
								goto IL_089d;
								IL_0ae9:
								if (type != 0)
								{
									num26 = 95234851;
									num41 = num26;
								}
								else
								{
									num26 = 1802599830;
									num41 = num26;
								}
								goto IL_09a9;
							}
							break;
							IL_0321:
							int num44;
							if (num34 < talents.Length)
							{
								num8 = 2004562380;
								num44 = num8;
							}
							else
							{
								num8 = 1556378760;
								num44 = num8;
							}
						}
						goto IL_02d6;
						IL_02d6:
						num8 = 399302771;
						goto IL_02db;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public string DescriptionInRichtextBlackEnd => DescriptionInRichtext;

	[XmlIgnore]
	public int type => item.type;

	[XmlIgnore]
	public ItemType Type => (ItemType)item.type;

	[XmlIgnore]
	public Item item
	{
		get
		{
			if (_202E_202C_200B_202E_200B_202A_202B_200F_200B_200C_206E_200C_202A_202B_200C_200E_200F_200D_206A_206F_200D_200E_200D_200E_206B_202C_206D_206B_200E_206F_206B_200C_202C_206A_200B_202B_200F_202B_202B_202E_202E == null)
			{
				while (true)
				{
					int num = 464422763;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ 0x46A5CE69)) % 3)
						{
						case 0u:
							break;
						case 2u:
							_202E_202C_200B_202E_200B_202A_202B_200F_200B_200C_206E_200C_202A_202B_200C_200E_200F_200D_206A_206F_200D_200E_200D_200E_206B_202C_206D_206B_200E_206F_206B_200C_202C_206A_200B_202B_200F_202B_202B_202E_202E = Item.GetItem(Name);
							num = (int)((num2 * 1569523219) ^ 0x637EB9E7);
							continue;
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
			return _202E_202C_200B_202E_200B_202A_202B_200F_200B_200C_206E_200C_202A_202B_200C_200E_200F_200D_206A_206F_200D_200E_200D_200E_206B_202C_206D_206B_200E_206F_206B_200C_202C_206A_200B_202B_200F_202B_202B_202E_202E;
		}
	}

	[XmlIgnore]
	public List<SkillInstance> Skills => item.Skills;

	[XmlIgnore]
	public List<SpecialSkillInstance> SpecialSkills => item.SpecialSkills;

	[XmlIgnore]
	public IEnumerable<Buff> Buffs => item.Buffs;

	public Color GetColor()
	{
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		if (AdditionTriggers.Count > 16)
		{
			goto IL_0012;
		}
		goto IL_0114;
		IL_0012:
		int num = -1991874570;
		goto IL_0017;
		IL_0017:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -2023046312)) % 41)
			{
			case 25u:
				break;
			case 14u:
				return Color.green;
			case 34u:
				return new Color(0.098f, 0f, 0f, 1f);
			case 6u:
				goto IL_0114;
			case 0u:
				return new Color(1f, 0.804f, 0f, 1f);
			case 21u:
				goto IL_0163;
			case 1u:
				return Color.black;
			case 27u:
				goto IL_019d;
			case 24u:
				goto IL_01c0;
			case 28u:
				return Color.yellow;
			case 10u:
				return new Color(0.196f, 0f, 0.196f, 1f);
			case 12u:
				return new Color(0.196f, 0.196f, 0f, 1f);
			case 38u:
				goto IL_0253;
			case 17u:
				return new Color(0.196f, 0.098f, 0f, 1f);
			case 29u:
				return Color.magenta;
			case 40u:
				return Color.magenta;
			case 35u:
				return new Color(1f, 0.412f, 0f, 1f);
			case 33u:
				return Color.blue;
			case 19u:
				return new Color(1f, 0.216f, 0f, 1f);
			case 18u:
				return new Color(0f, 0f, 0.196f, 1f);
			case 31u:
				return new Color(1f, 0.608f, 0f, 1f);
			case 23u:
				return Color.blue;
			case 11u:
				goto IL_03b2;
			case 30u:
				return new Color(0.7f, 1f, 0.7f, 1f);
			case 36u:
				goto IL_0400;
			case 5u:
				goto IL_041d;
			case 13u:
				goto IL_043f;
			case 9u:
				goto IL_0462;
			case 4u:
				goto IL_0485;
			case 16u:
				goto IL_04a7;
			case 15u:
				return Color.red;
			case 37u:
				return new Color(0f, 0.196f, 0f, 1f);
			case 8u:
				return Color.red;
			case 32u:
				goto IL_0526;
			case 20u:
				goto IL_0548;
			case 3u:
				goto IL_0578;
			case 2u:
				goto IL_059a;
			case 39u:
				goto IL_05bc;
			case 22u:
				goto IL_05d9;
			case 7u:
				goto IL_05fc;
			default:
				return Color.white;
			}
			break;
			IL_05fc:
			int num3;
			if (AdditionTriggers.Count != 1)
			{
				num = -616642971;
				num3 = num;
			}
			else
			{
				num = -1172693929;
				num3 = num;
			}
			continue;
			IL_0526:
			int num4;
			if (AdditionTriggers.Count != 5)
			{
				num = -1982907055;
				num4 = num;
			}
			else
			{
				num = -1403528804;
				num4 = num;
			}
			continue;
			IL_043f:
			int num5;
			if (AdditionTriggers.Count != 10)
			{
				num = -25280057;
				num5 = num;
			}
			else
			{
				num = -1295014671;
				num5 = num;
			}
			continue;
			IL_05d9:
			int num6;
			if (AdditionTriggers.Count != 12)
			{
				num = -121519421;
				num6 = num;
			}
			else
			{
				num = -1612220917;
				num6 = num;
			}
			continue;
			IL_019d:
			int num7;
			if (AdditionTriggers.Count != 11)
			{
				num = -745483474;
				num7 = num;
			}
			else
			{
				num = -2024034306;
				num7 = num;
			}
			continue;
			IL_04a7:
			int num8;
			if (AdditionTriggers.Count != 13)
			{
				num = -332335171;
				num8 = num;
			}
			else
			{
				num = -91267768;
				num8 = num;
			}
			continue;
			IL_05bc:
			int num9;
			if (type == 8)
			{
				num = -2096075704;
				num9 = num;
			}
			else
			{
				num = -1736583826;
				num9 = num;
			}
			continue;
			IL_03b2:
			int num10;
			if (AdditionTriggers.Count == 6)
			{
				num = -269595623;
				num10 = num;
			}
			else
			{
				num = -738251858;
				num10 = num;
			}
			continue;
			IL_041d:
			int num11;
			if (AdditionTriggers.Count == 7)
			{
				num = -1042939020;
				num11 = num;
			}
			else
			{
				num = -952338708;
				num11 = num;
			}
			continue;
			IL_059a:
			int num12;
			if (AdditionTriggers.Count == 3)
			{
				num = -1264808749;
				num12 = num;
			}
			else
			{
				num = -1734301491;
				num12 = num;
			}
			continue;
			IL_0485:
			int num13;
			if (AdditionTriggers.Count == 8)
			{
				num = -1770891292;
				num13 = num;
			}
			else
			{
				num = -13128843;
				num13 = num;
			}
			continue;
			IL_0163:
			int num14;
			if (AdditionTriggers.Count != 2)
			{
				num = -854277228;
				num14 = num;
			}
			else
			{
				num = -278379512;
				num14 = num;
			}
			continue;
			IL_0578:
			int num15;
			if (AdditionTriggers.Count != 4)
			{
				num = -55612067;
				num15 = num;
			}
			else
			{
				num = -250431065;
				num15 = num;
			}
			continue;
			IL_01c0:
			int num16;
			if (AdditionTriggers.Count != 9)
			{
				num = -1699017527;
				num16 = num;
			}
			else
			{
				num = -1942512100;
				num16 = num;
			}
			continue;
			IL_0462:
			int num17;
			if (AdditionTriggers.Count != 15)
			{
				num = -1948226223;
				num17 = num;
			}
			else
			{
				num = -220977563;
				num17 = num;
			}
			continue;
			IL_0548:
			int num18;
			if (Name.EndsWith(ResourceStrings.ResStrings[331]))
			{
				num = -835077073;
				num18 = num;
			}
			else
			{
				num = -878546925;
				num18 = num;
			}
			continue;
			IL_0400:
			int num19;
			if (type == 7)
			{
				num = -993959537;
				num19 = num;
			}
			else
			{
				num = -1593371351;
				num19 = num;
			}
			continue;
			IL_0253:
			int num20;
			if (AdditionTriggers.Count == 14)
			{
				num = -591205713;
				num20 = num;
			}
			else
			{
				num = -2123344550;
				num20 = num;
			}
		}
		goto IL_0012;
		IL_0114:
		int num21;
		if (AdditionTriggers.Count == 16)
		{
			num = -458314616;
			num21 = num;
		}
		else
		{
			num = -456795667;
			num21 = num;
		}
		goto IL_0017;
	}

	public string GetTypeStr()
	{
		return GetItemTypeStr(Type);
	}

	public string GetLevelStr()
	{
		if (Type != ItemType.Weapon)
		{
			goto IL_000c;
		}
		goto IL_00f6;
		IL_000c:
		int num = 101875294;
		goto IL_0011;
		IL_0011:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x303DE673)) % 52)
			{
			case 3u:
				break;
			case 15u:
				goto IL_00f6;
			case 43u:
				goto IL_0117;
			case 39u:
				return global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2916780493u);
			case 51u:
				goto IL_0156;
			case 2u:
				return global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(759852298u);
			case 33u:
				return global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3761527303u);
			case 6u:
				return string.Empty;
			case 14u:
			{
				int num9;
				int num10;
				if (AdditionTriggers.Count != 5)
				{
					num9 = 596226050;
					num10 = num9;
				}
				else
				{
					num9 = 1961141781;
					num10 = num9;
				}
				num = num9 ^ (int)(num2 * 1589468201);
				continue;
			}
			case 11u:
				goto IL_01f4;
			case 18u:
				goto IL_0216;
			case 1u:
				return _206C_206A_202B_202E_206A_202B_206F_200B_202C_200E_202C_206D_202D_206A_202A_202E_200B_202E_200F_206B_200C_206B_200D_200C_202C_206A_200F_200D_202A_206A_202E_206C_206E_200F_200E_202A_200F_206D_206C_202E_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3040238935u), (object)ResourceStrings.ResStrings[421]);
			case 50u:
				goto IL_0269;
			case 16u:
				goto IL_0285;
			case 32u:
				return global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1750664316u);
			case 0u:
				goto IL_02c4;
			case 29u:
				return global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2383195244u);
			case 37u:
				goto IL_0304;
			case 31u:
				return global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(246405352u);
			case 46u:
				return global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2402852575u);
			case 19u:
				goto IL_0361;
			case 24u:
				return global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2987515746u);
			case 9u:
			{
				int num11;
				int num12;
				if (Type != ItemType.Armor)
				{
					num11 = 594192869;
					num12 = num11;
				}
				else
				{
					num11 = 335615792;
					num12 = num11;
				}
				num = num11 ^ (int)(num2 * 1096524172);
				continue;
			}
			case 21u:
				return _206C_206A_202B_202E_206A_202B_206F_200B_202C_200E_202C_206D_202D_206A_202A_202E_200B_202E_200F_206B_200C_206B_200D_200C_202C_206A_200F_200D_202A_206A_202E_206C_206E_200F_200E_202A_200F_206D_206C_202E_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3951217665u), (object)ResourceStrings.ResStrings[424]);
			case 49u:
				goto IL_03f7;
			case 48u:
				return global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2961061015u);
			case 13u:
				goto IL_0437;
			case 30u:
				return global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3561831273u);
			case 25u:
				goto IL_0477;
			case 23u:
				return global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1401355679u);
			case 5u:
				goto IL_04b7;
			case 28u:
				goto IL_04da;
			case 22u:
				return global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1983499002u);
			case 35u:
				return global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1081256836u);
			case 20u:
				return _206C_206A_202B_202E_206A_202B_206F_200B_202C_200E_202C_206D_202D_206A_202A_202E_200B_202E_200F_206B_200C_206B_200D_200C_202C_206A_200F_200D_202A_206A_202E_206C_206E_200F_200E_202A_200F_206D_206C_202E_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3212103844u), (object)ResourceStrings.ResStrings[420]);
			case 12u:
				return global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3535730242u);
			case 8u:
			{
				int num7;
				int num8;
				if (AdditionTriggers.Count != 5)
				{
					num7 = 1199951068;
					num8 = num7;
				}
				else
				{
					num7 = 947320612;
					num8 = num7;
				}
				num = num7 ^ ((int)num2 * -1697872004);
				continue;
			}
			case 10u:
			{
				int num5;
				int num6;
				if (Type == ItemType.Accessories)
				{
					num5 = -1975853622;
					num6 = num5;
				}
				else
				{
					num5 = -1232921025;
					num6 = num5;
				}
				num = num5 ^ (int)(num2 * 967702359);
				continue;
			}
			case 4u:
				goto IL_05d4;
			case 44u:
				goto IL_05f0;
			case 36u:
				return _206C_206A_202B_202E_206A_202B_206F_200B_202C_200E_202C_206D_202D_206A_202A_202E_200B_202E_200F_206B_200C_206B_200D_200C_202C_206A_200F_200D_202A_206A_202E_206C_206E_200F_200E_202A_200F_206D_206C_202E_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3212103844u), (object)ResourceStrings.ResStrings[422]);
			case 34u:
				goto IL_0643;
			case 27u:
				goto IL_0665;
			case 47u:
				return global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3302895556u);
			case 7u:
				return global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4142868931u);
			case 38u:
				goto IL_06c2;
			case 26u:
			{
				int num3;
				int num4;
				if (AdditionTriggers.Count > 28)
				{
					num3 = 79424840;
					num4 = num3;
				}
				else
				{
					num3 = 1897132256;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -491752217);
				continue;
			}
			case 40u:
				return _206C_206A_202B_202E_206A_202B_206F_200B_202C_200E_202C_206D_202D_206A_202A_202E_200B_202E_200F_206B_200C_206B_200D_200C_202C_206A_200F_200D_202A_206A_202E_206C_206E_200F_200E_202A_200F_206D_206C_202E_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3690953366u), (object)ResourceStrings.ResStrings[423]);
			case 42u:
				goto IL_0740;
			case 45u:
				return global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4176617726u);
			case 17u:
				goto IL_077f;
			default:
				return global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1363629886u);
			}
			break;
			IL_077f:
			int num13;
			if (AdditionTriggers.Count == 2)
			{
				num = 1501429279;
				num13 = num;
			}
			else
			{
				num = 1549492983;
				num13 = num;
			}
			continue;
			IL_04da:
			int num14;
			if (AdditionTriggers.Count >= 17)
			{
				num = 1286066149;
				num14 = num;
			}
			else
			{
				num = 1235784466;
				num14 = num;
			}
			continue;
			IL_01f4:
			int num15;
			if (AdditionTriggers.Count < 6)
			{
				num = 1026141037;
				num15 = num;
			}
			else
			{
				num = 339492519;
				num15 = num;
			}
			continue;
			IL_0740:
			int num16;
			if (AdditionTriggers.Count != 5)
			{
				num = 2113556229;
				num16 = num;
			}
			else
			{
				num = 1889657691;
				num16 = num;
			}
			continue;
			IL_0361:
			int num17;
			if (AdditionTriggers.Count == 13)
			{
				num = 1418860346;
				num17 = num;
			}
			else
			{
				num = 1558077558;
				num17 = num;
			}
			continue;
			IL_04b7:
			int num18;
			if (AdditionTriggers.Count != 11)
			{
				num = 1522975498;
				num18 = num;
			}
			else
			{
				num = 943268025;
				num18 = num;
			}
			continue;
			IL_06c2:
			int num19;
			if (AdditionTriggers.Count == 6)
			{
				num = 2133024532;
				num19 = num;
			}
			else
			{
				num = 274733307;
				num19 = num;
			}
			continue;
			IL_0285:
			int num20;
			if (AdditionTriggers.Count == 7)
			{
				num = 252673973;
				num20 = num;
			}
			else
			{
				num = 445638328;
				num20 = num;
			}
			continue;
			IL_0216:
			int num21;
			if (AdditionTriggers.Count != 4)
			{
				num = 1214309019;
				num21 = num;
			}
			else
			{
				num = 791899734;
				num21 = num;
			}
			continue;
			IL_0665:
			int num22;
			if (AdditionTriggers.Count != 15)
			{
				num = 1485756954;
				num22 = num;
			}
			else
			{
				num = 1907649271;
				num22 = num;
			}
			continue;
			IL_0477:
			int num23;
			if (AdditionTriggers.Count != 16)
			{
				num = 1835651799;
				num23 = num;
			}
			else
			{
				num = 1550286604;
				num23 = num;
			}
			continue;
			IL_0304:
			int num24;
			if (AdditionTriggers.Count != 14)
			{
				num = 920626812;
				num24 = num;
			}
			else
			{
				num = 433250768;
				num24 = num;
			}
			continue;
			IL_0643:
			int num25;
			if (AdditionTriggers.Count != 1)
			{
				num = 1130903434;
				num25 = num;
			}
			else
			{
				num = 868719202;
				num25 = num;
			}
			continue;
			IL_0156:
			int num26;
			if (AdditionTriggers.Count != 8)
			{
				num = 1265156978;
				num26 = num;
			}
			else
			{
				num = 211278420;
				num26 = num;
			}
			continue;
			IL_0437:
			int num27;
			if (AdditionTriggers.Count != 12)
			{
				num = 2071362552;
				num27 = num;
			}
			else
			{
				num = 466116102;
				num27 = num;
			}
			continue;
			IL_05f0:
			int num28;
			if (AdditionTriggers.Count == 3)
			{
				num = 372834835;
				num28 = num;
			}
			else
			{
				num = 520876709;
				num28 = num;
			}
			continue;
			IL_0269:
			int num29;
			if (CommonSettings.MOD_KEY() != 4)
			{
				num = 1026141037;
				num29 = num;
			}
			else
			{
				num = 385366379;
				num29 = num;
			}
			continue;
			IL_02c4:
			int num30;
			if (AdditionTriggers.Count != 10)
			{
				num = 825639394;
				num30 = num;
			}
			else
			{
				num = 101315864;
				num30 = num;
			}
			continue;
			IL_05d4:
			int num31;
			if (CommonSettings.MOD_KEY() == 1)
			{
				num = 1208841713;
				num31 = num;
			}
			else
			{
				num = 1704150977;
				num31 = num;
			}
			continue;
			IL_03f7:
			int num32;
			if (AdditionTriggers.Count == 9)
			{
				num = 1915030513;
				num32 = num;
			}
			else
			{
				num = 186300255;
				num32 = num;
			}
			continue;
			IL_0117:
			int num33;
			if (AdditionTriggers.Count >= 6)
			{
				num = 1649712237;
				num33 = num;
			}
			else
			{
				num = 1704150977;
				num33 = num;
			}
		}
		goto IL_000c;
		IL_00f6:
		int num34;
		if (AdditionTriggers.Count != 0)
		{
			num = 1900759477;
			num34 = num;
		}
		else
		{
			num = 1702072231;
			num34 = num;
		}
		goto IL_0011;
	}

	public bool HasTalent(string talent)
	{
		string[] array = _206B_200E_206B_200C_202B_202E_200D_200C_202D_200D_202E_200E_200B_200B_206E_202E_200B_202B_206B_202C_206F_200F_200D_200D_200F_206D_200C_206C_202E_202B_202D_200F_200D_202A_200F_202C_206F_202A_200D_202B_202E(talent, new char[1] { '#' });
		int num = 0;
		Trigger current = default(Trigger);
		bool result = default(bool);
		Trigger current2 = default(Trigger);
		while (true)
		{
			int num2 = 30231984;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x126C00E2)) % 7)
				{
				case 0u:
					break;
				case 5u:
					num++;
					num2 = 1318962941;
					continue;
				case 2u:
				{
					int num16;
					if (!_202A_202E_206A_206B_200F_200D_200E_206B_200C_202D_202A_202B_200B_202D_206E_206F_200E_200F_202B_206D_202A_206B_202A_206C_200E_206E_206E_206C_202E_200B_206A_200D_206E_200F_206D_202B_200B_202A_206C_200C_202E(array[num], talent))
					{
						num2 = 805952736;
						num16 = num2;
					}
					else
					{
						num2 = 539439191;
						num16 = num2;
					}
					continue;
				}
				case 3u:
					num2 = ((int)num3 * -829561342) ^ -361136039;
					continue;
				case 4u:
				{
					int num15;
					if (num >= array.Length)
					{
						num2 = 1894691786;
						num15 = num2;
					}
					else
					{
						num2 = 1394127255;
						num15 = num2;
					}
					continue;
				}
				case 6u:
					return true;
				default:
					{
						using (List<Trigger>.Enumerator enumerator = Triggers.GetEnumerator())
						{
							while (true)
							{
								IL_0120:
								int num4;
								int num5;
								if (!enumerator.MoveNext())
								{
									num4 = 633520169;
									num5 = num4;
								}
								else
								{
									num4 = 1529332206;
									num5 = num4;
								}
								while (true)
								{
									switch ((num3 = (uint)(num4 ^ 0x126C00E2)) % 8)
									{
									case 0u:
										num4 = 1529332206;
										continue;
									default:
										goto end_IL_00bd;
									case 6u:
									{
										int num8;
										int num9;
										if (_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(current.Argvs[0], talent))
										{
											num8 = -1444252575;
											num9 = num8;
										}
										else
										{
											num8 = -363504329;
											num9 = num8;
										}
										num4 = num8 ^ (int)(num3 * 739096406);
										continue;
									}
									case 1u:
										break;
									case 4u:
										current = enumerator.Current;
										num4 = 355941847;
										continue;
									case 7u:
										result = true;
										num4 = ((int)num3 * -3357051) ^ -1561927965;
										continue;
									case 5u:
									{
										int num6;
										int num7;
										if (_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(current.Name, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1480101968u)))
										{
											num6 = 15303715;
											num7 = num6;
										}
										else
										{
											num6 = 1318677308;
											num7 = num6;
										}
										num4 = num6 ^ (int)(num3 * 1288108547);
										continue;
									}
									case 3u:
										goto end_IL_00bd;
									case 2u:
										goto IL_02ac;
									}
									goto IL_0120;
									continue;
									end_IL_00bd:
									break;
								}
								break;
							}
						}
						using (List<Trigger>.Enumerator enumerator = AdditionTriggers.GetEnumerator())
						{
							while (true)
							{
								IL_027d:
								int num10;
								int num11;
								if (enumerator.MoveNext())
								{
									num10 = 168417005;
									num11 = num10;
								}
								else
								{
									num10 = 1685366435;
									num11 = num10;
								}
								while (true)
								{
									switch ((num3 = (uint)(num10 ^ 0x126C00E2)) % 6)
									{
									case 0u:
										num10 = 168417005;
										continue;
									default:
										goto end_IL_01d4;
									case 3u:
									{
										current2 = enumerator.Current;
										int num14;
										if (_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(current2.Name, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1480101968u)))
										{
											num10 = 1789973350;
											num14 = num10;
										}
										else
										{
											num10 = 2067519513;
											num14 = num10;
										}
										continue;
									}
									case 2u:
									{
										int num12;
										int num13;
										if (!_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(current2.Argvs[0], talent))
										{
											num12 = -1703714247;
											num13 = num12;
										}
										else
										{
											num12 = -1199570356;
											num13 = num12;
										}
										num10 = num12 ^ ((int)num3 * -585500792);
										continue;
									}
									case 4u:
										result = true;
										goto IL_02ac;
									case 5u:
										break;
									case 1u:
										goto end_IL_01d4;
									}
									goto IL_027d;
									continue;
									end_IL_01d4:
									break;
								}
								break;
							}
						}
						return false;
					}
					IL_02ac:
					return result;
				}
				break;
			}
		}
	}

	public void AddRandomTriggers(int number)
	{
		if (Type != ItemType.Weapon)
		{
			goto IL_000c;
		}
		goto IL_00a7;
		IL_000c:
		int num = 622408312;
		goto IL_0011;
		IL_0011:
		int num5 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x4D8DBC1B)) % 9)
			{
			case 8u:
				break;
			default:
				return;
			case 7u:
			{
				int num6;
				int num7;
				if (Type == ItemType.Armor)
				{
					num6 = 696841823;
					num7 = num6;
				}
				else
				{
					num6 = 2133855403;
					num7 = num6;
				}
				num = num6 ^ (int)(num2 * 1394167690);
				continue;
			}
			case 2u:
				AddRandomTrigger();
				num5++;
				num = 1401851715;
				continue;
			case 1u:
				goto IL_007d;
			case 4u:
				num = ((int)num2 * -1389145498) ^ 0x48DC1965;
				continue;
			case 6u:
				goto IL_00a7;
			case 5u:
			{
				int num3;
				int num4;
				if (Type != ItemType.Accessories)
				{
					num3 = -1876302242;
					num4 = num3;
				}
				else
				{
					num3 = -1165805133;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 197948975);
				continue;
			}
			case 0u:
				return;
			case 3u:
				return;
			}
			break;
			IL_007d:
			int num8;
			if (num5 >= number)
			{
				num = 95248887;
				num8 = num;
			}
			else
			{
				num = 109627824;
				num8 = num;
			}
		}
		goto IL_000c;
		IL_00a7:
		num5 = 0;
		num = 588982970;
		goto IL_0011;
	}

	public void AddRandomTrigger()
	{
		Trigger trigger = GenerateRandomTrigger();
		while (true)
		{
			int num = -215354975;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)(num ^ -1199243086)) % 4)
				{
				case 0u:
					break;
				case 3u:
				{
					int num4;
					if (trigger != null)
					{
						num3 = -515687650;
						num4 = num3;
					}
					else
					{
						num3 = -1654751267;
						num4 = num3;
					}
					goto IL_003e;
				}
				case 1u:
					return;
				default:
					AdditionTriggers.Add(trigger);
					return;
				}
				break;
				IL_003e:
				num = num3 ^ (int)(num2 * 1620281814);
			}
		}
	}

	public Trigger GenerateRandomTrigger()
	{
		if (CommonSettings.MOD_KEY() == 1)
		{
			goto IL_000b;
		}
		goto IL_0099;
		IL_000b:
		int num = -2026829685;
		goto IL_0010;
		IL_0010:
		Dictionary<string, bool> dictionary = default(Dictionary<string, bool>);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1035026698)) % 16)
			{
			case 7u:
				break;
			case 3u:
				dictionary.Add(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1117334145u), haveAdditionTrigger(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1581301540u)));
				num = ((int)num2 * -1047448126) ^ 0x54A4D465;
				continue;
			case 12u:
				goto IL_0099;
			case 2u:
			{
				int num3;
				int num4;
				if (Type == ItemType.Accessories)
				{
					num3 = -689480452;
					num4 = num3;
				}
				else
				{
					num3 = -842839634;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 1310806815);
				continue;
			}
			case 11u:
			{
				int num5;
				int num6;
				if (Type != ItemType.Armor)
				{
					num5 = 3486755;
					num6 = num5;
				}
				else
				{
					num5 = 160460181;
					num6 = num5;
				}
				num = num5 ^ (int)(num2 * 1566289029);
				continue;
			}
			case 6u:
				return null;
			case 10u:
				dictionary.Add(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3355625919u), haveAdditionTrigger(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1868103068u)));
				num = (int)((num2 * 1157056915) ^ 0x601B9D88);
				continue;
			case 5u:
				dictionary.Add(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3282273608u), haveAdditionTrigger(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1202943773u)));
				dictionary.Add(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3047877272u), haveAdditionTrigger(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3047877272u)));
				num = (int)((num2 * 856493316) ^ 0x5A2AC04C);
				continue;
			case 13u:
				return GenerateRandomTrigger1();
			case 4u:
				dictionary = new Dictionary<string, bool>();
				dictionary.Add(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(395918471u), haveAdditionTrigger(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(291629272u)));
				dictionary.Add(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1168936690u), haveAdditionTrigger(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1168936690u)));
				num = -763338171;
				continue;
			case 9u:
				dictionary.Add(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3115470418u), haveAdditionTrigger(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(430049467u)));
				dictionary.Add(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3192915409u), getAdditionTrigger(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2081569984u)) > 2);
				num = -432356729;
				continue;
			case 14u:
				dictionary.Add(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2921175454u), haveAdditionTrigger(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(168170830u)));
				dictionary.Add(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1989573738u), haveAdditionTrigger(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3115868650u)));
				dictionary.Add(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4140937175u), haveAdditionTrigger(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3524828816u)));
				num = ((int)num2 * -340910878) ^ -648846240;
				continue;
			case 15u:
				dictionary.Add(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1111387534u), haveAdditionTrigger(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1111387534u)));
				num = ((int)num2 * -1521558371) ^ -1681565748;
				continue;
			case 1u:
				dictionary.Add(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(862773248u), getAdditionTrigger(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1961315404u)) > 2);
				dictionary.Add(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(466966049u), getAdditionTrigger(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1065731600u)) > 2);
				dictionary.Add(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(749566769u), getAdditionTrigger(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3248502277u)) > 2);
				num = -1723718610;
				continue;
			case 0u:
				dictionary.Add(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1185199784u), haveAdditionTrigger(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4266327373u)));
				num = ((int)num2 * -466236483) ^ -162134199;
				continue;
			default:
				goto IL_03b0;
			}
			break;
		}
		goto IL_000b;
		IL_06d3:
		List<ITTrigger> list;
		double num7 = 1.0 / (double)list.Count * 0.1;
		int num8 = -380512033;
		goto IL_0685;
		IL_0685:
		Trigger trigger = default(Trigger);
		List<ITTrigger> list2 = default(List<ITTrigger>);
		int num14 = default(int);
		ITTrigger current = default(ITTrigger);
		int num11;
		Trigger current2 = default(Trigger);
		while (true)
		{
			int num13;
			bool flag;
			int num20;
			uint num2;
			switch ((num2 = (uint)(num8 ^ -1035026698)) % 6)
			{
			case 0u:
				break;
			case 4u:
				trigger = null;
				list2 = new List<ITTrigger>();
				num8 = -562409166;
				continue;
			case 1u:
				num14 = 0;
				num8 = (int)((num2 * 1946924600) ^ 0x165D44F8);
				continue;
			case 3u:
				goto IL_06d3;
			case 5u:
				return null;
			default:
				{
					using (List<ITTrigger>.Enumerator enumerator = list.GetEnumerator())
					{
						while (true)
						{
							IL_078d:
							int num9;
							int num10;
							if (enumerator.MoveNext())
							{
								num9 = -1346820645;
								num10 = num9;
							}
							else
							{
								num9 = -2031081239;
								num10 = num9;
							}
							while (true)
							{
								switch ((num2 = (uint)(num9 ^ -1035026698)) % 5)
								{
								case 2u:
									num9 = -1346820645;
									continue;
								default:
									goto end_IL_071b;
								case 1u:
								{
									current = enumerator.Current;
									int num12;
									if (Tools.ProbabilityTest(_200C_206D_200B_202D_200C_206E_206C_206F_200E_202B_206A_206B_200E_206C_202A_200D_200B_202A_206A_206F_206E_206D_200B_206C_206D_200B_206A_202C_202B_202A_202D_202A_202A_206B_206F_206E_200F_202D_202A_206C_202E((double)current.Weight / (double)num11, num7)))
									{
										num9 = -936438617;
										num12 = num9;
									}
									else
									{
										num9 = -271164265;
										num12 = num9;
									}
									continue;
								}
								case 3u:
									list2.Add(current);
									num9 = ((int)num2 * -137569028) ^ -371515605;
									continue;
								case 0u:
									break;
								case 4u:
									goto end_IL_071b;
								}
								goto IL_078d;
								continue;
								end_IL_071b:
								break;
							}
							break;
						}
					}
					if (list2.Count > 0)
					{
						goto IL_07c4;
					}
					goto IL_0822;
				}
				IL_0822:
				if (trigger != null)
				{
					num13 = -1944908583;
					goto IL_07c9;
				}
				goto IL_097c;
				IL_07c9:
				while (true)
				{
					switch ((num2 = (uint)(num13 ^ -1035026698)) % 5)
					{
					case 0u:
						break;
					case 2u:
						trigger = list2[Tools.GetRandomInt(0, list2.Count - 1)].GenerateItemTrigger(level);
						num13 = (int)((num2 * 1562052632) ^ 0x126265E5);
						continue;
					case 3u:
						goto IL_0822;
					case 1u:
						goto IL_0830;
					default:
						goto IL_0854;
					}
					break;
					IL_0830:
					if (!_202D_202A_206F_206C_206D_206A_206A_206C_202D_200B_200C_206E_206A_200F_202E_202E_206D_202C_206C_206F_206B_202D_206A_206B_200E_206D_200C_202D_202C_202D_206A_206D_200B_200B_206F_206F_200F_200F_206F_202B_202E(trigger.ArgvsString))
					{
						num13 = ((int)num2 * -677693686) ^ 0x372E0DC;
						continue;
					}
					goto IL_097c;
				}
				goto IL_07c4;
				IL_0854:
				flag = true;
				using (List<Trigger>.Enumerator enumerator2 = AdditionTriggers.GetEnumerator())
				{
					while (true)
					{
						IL_08ee:
						int num15;
						int num16;
						if (enumerator2.MoveNext())
						{
							num15 = -1889407982;
							num16 = num15;
						}
						else
						{
							num15 = -198199888;
							num16 = num15;
						}
						while (true)
						{
							switch ((num2 = (uint)(num15 ^ -1035026698)) % 6)
							{
							case 3u:
								num15 = -1889407982;
								continue;
							default:
								goto end_IL_086e;
							case 0u:
								flag = false;
								goto end_IL_086e;
							case 5u:
							{
								int num18;
								int num19;
								if (!_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(trigger.Argvs[0], current2.Argvs[0]))
								{
									num18 = 567423232;
									num19 = num18;
								}
								else
								{
									num18 = 941538081;
									num19 = num18;
								}
								num15 = num18 ^ ((int)num2 * -1322100987);
								continue;
							}
							case 1u:
								break;
							case 2u:
							{
								current2 = enumerator2.Current;
								int num17;
								if (_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(trigger.Name, current2.Name))
								{
									num15 = -740013309;
									num17 = num15;
								}
								else
								{
									num15 = -1055579703;
									num17 = num15;
								}
								continue;
							}
							case 4u:
								goto end_IL_086e;
							}
							goto IL_08ee;
							continue;
							end_IL_086e:
							break;
						}
						break;
					}
				}
				if (!flag)
				{
					goto IL_0951;
				}
				goto IL_09c5;
				IL_07c4:
				num13 = -1738635760;
				goto IL_07c9;
				IL_097c:
				num14++;
				num20 = -1439659061;
				goto IL_0956;
				IL_0956:
				while (true)
				{
					switch ((num2 = (uint)(num20 ^ -1035026698)) % 5)
					{
					case 2u:
						break;
					case 1u:
						goto IL_097c;
					case 4u:
						goto IL_0989;
					case 0u:
						goto IL_09a2;
					default:
						goto IL_09c5;
					}
					break;
					IL_09a2:
					if (Tools.ProbabilityTest(0.05))
					{
						num20 = (int)((num2 * 1390629355) ^ 0x340D1AAE);
						continue;
					}
					goto case 4u;
					IL_0989:
					if (num14 >= 100)
					{
						num20 = ((int)num2 * -58507950) ^ 0x2388D9D4;
						continue;
					}
					goto case 4u;
				}
				goto IL_0951;
				IL_09c5:
				return trigger;
				IL_0951:
				num20 = -1295388439;
				goto IL_0956;
			}
			break;
		}
		goto IL_0680;
		IL_0099:
		int num21;
		if (Type != ItemType.Weapon)
		{
			num = -1186962227;
			num21 = num;
		}
		else
		{
			num = -490706638;
			num21 = num;
		}
		goto IL_0010;
		IL_0680:
		num8 = -2055873029;
		goto IL_0685;
		IL_03b0:
		int round = RuntimeData.Instance.Round;
		list = new List<ITTrigger>();
		num11 = 0;
		IEnumerator<ItemTrigger> enumerator3 = ResourceManager.GetAll<ItemTrigger>().GetEnumerator();
		try
		{
			ITTrigger current4 = default(ITTrigger);
			bool flag2 = default(bool);
			while (_206D_206C_200E_202D_206D_206B_206B_200B_206F_206F_202B_206F_200D_206D_202D_202E_206A_202E_206B_200C_206A_200F_202E_206D_200D_206F_200B_202C_206E_206F_200B_200F_200B_202C_200E_200C_202E_206E_202B_206A_202E((IEnumerator)enumerator3))
			{
				while (true)
				{
					ItemTrigger current3 = enumerator3.Current;
					int num22 = -1521425112;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num22 ^ -1035026698)) % 6)
						{
						case 5u:
							num22 = -1113563825;
							continue;
						case 4u:
						{
							int num25;
							int num26;
							if (level <= current3.MaxLevel)
							{
								num25 = -989781672;
								num26 = num25;
							}
							else
							{
								num25 = -1527579227;
								num26 = num25;
							}
							num22 = num25 ^ (int)(num2 * 346044562);
							continue;
						}
						case 1u:
							break;
						case 3u:
							goto end_IL_03d9;
						case 2u:
						{
							int num23;
							int num24;
							if (level < current3.MinLevel)
							{
								num23 = -432552093;
								num24 = num23;
							}
							else
							{
								num23 = -979459200;
								num24 = num23;
							}
							num22 = num23 ^ ((int)num2 * -1602059075);
							continue;
						}
						default:
							goto IL_048c;
						}
						if (!_202A_202E_206A_206B_200F_200D_200E_206B_200C_202D_202A_202B_200B_202D_206E_206F_200E_200F_202B_206D_202A_206B_202A_206C_200E_206E_206E_206C_202E_200B_206A_200D_206E_200F_206D_202B_200B_202A_206C_200C_202E(Name, current3.Name))
						{
							goto end_IL_044d;
						}
						num22 = -1472179848;
						continue;
						IL_048c:
						using (List<ITTrigger>.Enumerator enumerator = current3.Triggers.GetEnumerator())
						{
							while (true)
							{
								IL_04e7:
								int num27;
								int num28;
								if (!enumerator.MoveNext())
								{
									num27 = -1170181877;
									num28 = num27;
								}
								else
								{
									num27 = -1509294222;
									num28 = num27;
								}
								while (true)
								{
									switch ((num2 = (uint)(num27 ^ -1035026698)) % 12)
									{
									case 7u:
										num27 = -1509294222;
										continue;
									default:
										goto end_IL_04a1;
									case 11u:
										break;
									case 1u:
										num11 += current4.Weight;
										num27 = (int)(num2 * 456792003) ^ -946994947;
										continue;
									case 2u:
									{
										int num36;
										int num37;
										if (!dictionary.ContainsKey(current4.Name))
										{
											num36 = -1882562142;
											num37 = num36;
										}
										else
										{
											num36 = -375677241;
											num37 = num36;
										}
										num27 = num36 ^ ((int)num2 * -2006088212);
										continue;
									}
									case 3u:
									{
										int num34;
										int num35;
										if (!_202D_202A_206F_206C_206D_206A_206A_206C_202D_200B_200C_206E_206A_200F_202E_202E_206D_202C_206C_206F_206B_202D_206A_206B_200E_206D_200C_202D_202C_202D_206A_206D_200B_200B_206F_206F_200F_200F_206F_202B_202E(current4.Name))
										{
											num34 = 154398417;
											num35 = num34;
										}
										else
										{
											num34 = 448764633;
											num35 = num34;
										}
										num27 = num34 ^ (int)(num2 * 1533716795);
										continue;
									}
									case 0u:
									{
										int num31;
										if (!flag2)
										{
											num27 = -1686546711;
											num31 = num27;
										}
										else
										{
											num27 = -228708;
											num31 = num27;
										}
										continue;
									}
									case 8u:
										current4 = enumerator.Current;
										flag2 = true;
										num27 = -1365193511;
										continue;
									case 4u:
										list.Add(current4);
										num27 = ((int)num2 * -2117932018) ^ 0x1477E229;
										continue;
									case 5u:
									{
										int num32;
										int num33;
										if (!dictionary[current4.Name])
										{
											num32 = 272963341;
											num33 = num32;
										}
										else
										{
											num32 = 1241626299;
											num33 = num32;
										}
										num27 = num32 ^ ((int)num2 * -508322337);
										continue;
									}
									case 10u:
										flag2 = false;
										num27 = -1070568262;
										continue;
									case 6u:
									{
										int num29;
										int num30;
										if (round >= current4.Round)
										{
											num29 = 1046797067;
											num30 = num29;
										}
										else
										{
											num29 = 273107949;
											num30 = num29;
										}
										num27 = num29 ^ (int)(num2 * 1840655546);
										continue;
									}
									case 9u:
										goto end_IL_04a1;
									}
									goto IL_04e7;
									continue;
									end_IL_04a1:
									break;
								}
								break;
							}
						}
						goto end_IL_044d;
						continue;
						end_IL_03d9:
						break;
					}
					continue;
					end_IL_044d:
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
					IL_063d:
					int num38 = -754030921;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num38 ^ -1035026698)) % 3)
						{
						case 0u:
							break;
						default:
							goto end_IL_0642;
						case 2u:
							goto IL_0660;
						case 1u:
							goto end_IL_0642;
						}
						goto IL_063d;
						IL_0660:
						_206C_200F_206A_202B_206E_206A_202B_206B_200D_206B_200C_202A_202E_206A_200E_206B_202C_200B_206F_206D_202A_200E_200D_206A_202D_206D_202A_202B_200B_200F_206B_206E_202C_206A_206F_202E_202A_202E_206D_200D_202E((IDisposable)enumerator3);
						num38 = (int)(num2 * 2043900849) ^ -238998998;
						continue;
						end_IL_0642:
						break;
					}
					break;
				}
			}
		}
		if (list.Count == 0)
		{
			goto IL_0680;
		}
		goto IL_06d3;
	}

	public Dictionary<string, int> getItemRequireAttrs()
	{
		Dictionary<string, int> dictionary = new Dictionary<string, int>();
		using (List<Require>.Enumerator enumerator = Requires.GetEnumerator())
		{
			Require current = default(Require);
			while (true)
			{
				IL_0119:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 1157579400;
					num2 = num;
				}
				else
				{
					num = 1575302983;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x529EC303)) % 12)
					{
					case 7u:
						num = 1157579400;
						continue;
					default:
						goto end_IL_001c;
					case 2u:
						dictionary.Add(current.Name, int.Parse(current.ArgvsString));
						num = (int)(num3 * 954075573) ^ -423798201;
						continue;
					case 4u:
					{
						int num6;
						if (_202D_206C_202A_206A_200F_202E_200F_202B_206D_206C_206D_202B_200D_200F_202C_202D_206B_206B_202B_206B_200B_206F_200D_202D_206D_200F_202A_200E_206A_200D_202A_200C_200E_206B_200D_206A_200E_200E_200F_206E_202E(current.Name, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(887725519u)))
						{
							num = 1638789210;
							num6 = num;
						}
						else
						{
							num = 1219606469;
							num6 = num;
						}
						continue;
					}
					case 5u:
					{
						int num10;
						int num11;
						if (CommonSettings.AttributeToIndex(_202B_206E_206E_202C_200C_200C_202D_202B_206B_200B_200C_202A_200C_200C_206C_200B_206E_206B_206C_202A_206D_206C_200D_202C_202E_200B_200B_200B_206B_200D_206F_202D_202D_200E_206B_202C_202A_202B_200F_202E(current.Name, 1, _202A_206C_200F_200F_202C_206B_206D_200B_202D_202A_200B_206D_206C_202A_202C_202E_200F_206F_202C_202D_200F_200F_200E_200B_200F_200B_202B_206C_200B_200C_200E_202C_206C_206C_200E_202B_200C_200C_206B_200D_202E(current.Name) - 1)) >= 0)
						{
							num10 = -270050306;
							num11 = num10;
						}
						else
						{
							num10 = -1210337397;
							num11 = num10;
						}
						num = num10 ^ ((int)num3 * -613826818);
						continue;
					}
					case 9u:
					{
						int num7;
						int num8;
						if (!dictionary.ContainsKey(current.Name))
						{
							num7 = 1582592936;
							num8 = num7;
						}
						else
						{
							num7 = 33159376;
							num8 = num7;
						}
						num = num7 ^ ((int)num3 * -860805647);
						continue;
					}
					case 6u:
						break;
					case 1u:
						dictionary.Add(current.Name, int.Parse(current.ArgvsString));
						num = (int)((num3 * 304241397) ^ 0x483993D8);
						continue;
					case 3u:
					{
						current = enumerator.Current;
						int num9;
						if (CommonSettings.AttributeToIndex(current.Name) >= 0)
						{
							num = 1575972642;
							num9 = num;
						}
						else
						{
							num = 1634721123;
							num9 = num;
						}
						continue;
					}
					case 11u:
					{
						int num4;
						int num5;
						if (dictionary.ContainsKey(current.Name))
						{
							num4 = -795340013;
							num5 = num4;
						}
						else
						{
							num4 = -1213965220;
							num5 = num4;
						}
						num = num4 ^ (int)(num3 * 1823282898);
						continue;
					}
					case 10u:
						dictionary[current.Name] = dictionary[current.Name] + int.Parse(current.ArgvsString);
						num = 1970106587;
						continue;
					case 8u:
						num = ((int)num3 * -835113315) ^ 0x6D6FACBD;
						continue;
					case 0u:
						goto end_IL_001c;
					}
					goto IL_0119;
					continue;
					end_IL_001c:
					break;
				}
				break;
			}
		}
		return dictionary;
	}

	public List<string> getItemRequireTalents()
	{
		List<string> list = new List<string>();
		using (List<Require>.Enumerator enumerator = Requires.GetEnumerator())
		{
			Require current = default(Require);
			while (true)
			{
				IL_00ad:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -415517993;
					num2 = num;
				}
				else
				{
					num = -1382682956;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -1135110249)) % 8)
					{
					case 7u:
						num = -1382682956;
						continue;
					default:
						goto end_IL_001c;
					case 3u:
						current = enumerator.Current;
						num = -1436644499;
						continue;
					case 4u:
						list.Add(current.ArgvsString);
						num = ((int)num3 * -551102148) ^ 0x3CD8BA6E;
						continue;
					case 2u:
					{
						int num5;
						int num6;
						if (!_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(current.Name, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3198126615u)))
						{
							num5 = 256143456;
							num6 = num5;
						}
						else
						{
							num5 = 1202205641;
							num6 = num5;
						}
						num = num5 ^ (int)(num3 * 512957277);
						continue;
					}
					case 1u:
						break;
					case 6u:
						list.Add(_200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1387518389u), current.ArgvsString));
						num = (int)((num3 * 1473615667) ^ 0x34B0E3FC);
						continue;
					case 5u:
					{
						int num4;
						if (!_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(current.Name, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2543506046u)))
						{
							num = -1192921410;
							num4 = num;
						}
						else
						{
							num = -1600120287;
							num4 = num;
						}
						continue;
					}
					case 0u:
						goto end_IL_001c;
					}
					goto IL_00ad;
					continue;
					end_IL_001c:
					break;
				}
				break;
			}
		}
		return list;
	}

	public bool CanEquip(Role r)
	{
		if (Requires == null)
		{
			goto IL_000b;
		}
		goto IL_0209;
		IL_000b:
		int num = 1166663341;
		goto IL_0010;
		IL_0010:
		int num3 = default(int);
		string text = default(string);
		Dictionary<string, int> itemRequireAttrs = default(Dictionary<string, int>);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x29C79FD6)) % 21)
			{
			case 8u:
				break;
			case 17u:
				return false;
			case 5u:
				goto IL_008c;
			case 20u:
				goto IL_00aa;
			case 1u:
				goto IL_00d3;
			case 12u:
				num3++;
				num = 2025007375;
				continue;
			case 14u:
				num3 = 0;
				num = ((int)num2 * -1305366163) ^ -616722310;
				continue;
			case 2u:
				return false;
			case 16u:
				goto IL_0137;
			case 13u:
			{
				int num12;
				int num13;
				if (r.AttributesFinal[text] != itemRequireAttrs[_200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4080104489u), text)])
				{
					num12 = -2037304245;
					num13 = num12;
				}
				else
				{
					num12 = -1325073131;
					num13 = num12;
				}
				num = num12 ^ (int)(num2 * 2037758041);
				continue;
			}
			case 3u:
				text = CommonSettings.RoleAttributeList[num3];
				num = 1003265827;
				continue;
			case 11u:
				return false;
			case 6u:
			{
				int num6;
				int num7;
				if (r.AttributesFinal[text] == itemRequireAttrs[text])
				{
					num6 = 38444788;
					num7 = num6;
				}
				else
				{
					num6 = 1994893890;
					num7 = num6;
				}
				num = num6 ^ (int)(num2 * 918052000);
				continue;
			}
			case 15u:
				goto IL_0209;
			case 9u:
				return false;
			case 7u:
				return false;
			case 4u:
				num = (int)(num2 * 381589909) ^ -289789336;
				continue;
			case 19u:
			{
				int num10;
				int num11;
				if (itemRequireAttrs.ContainsKey(text))
				{
					num10 = -473922544;
					num11 = num10;
				}
				else
				{
					num10 = -493221955;
					num11 = num10;
				}
				num = num10 ^ ((int)num2 * -1765750331);
				continue;
			}
			case 0u:
			{
				int num8;
				int num9;
				if (num3 == 16)
				{
					num8 = -2070553673;
					num9 = num8;
				}
				else
				{
					num8 = -109324339;
					num9 = num8;
				}
				num = num8 ^ ((int)num2 * -2085560431);
				continue;
			}
			case 10u:
			{
				int num4;
				int num5;
				if (num3 == 16)
				{
					num4 = -2127840817;
					num5 = num4;
				}
				else
				{
					num4 = -838471876;
					num5 = num4;
				}
				num = num4 ^ ((int)num2 * -1067995079);
				continue;
			}
			default:
				goto IL_02c1;
			}
			break;
			IL_0137:
			int num14;
			if (r.AttributesFinal[text] >= itemRequireAttrs[_200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1102747038u), text)])
			{
				num = 702752828;
				num14 = num;
			}
			else
			{
				num = 1005267824;
				num14 = num;
			}
			continue;
			IL_00aa:
			int num15;
			if (r.AttributesFinal[text] >= itemRequireAttrs[text])
			{
				num = 694296116;
				num15 = num;
			}
			else
			{
				num = 1559209439;
				num15 = num;
			}
			continue;
			IL_008c:
			int num16;
			if (num3 < CommonSettings.RoleAttributeList.Length)
			{
				num = 1453147790;
				num16 = num;
			}
			else
			{
				num = 662202922;
				num16 = num;
			}
			continue;
			IL_00d3:
			int num17;
			if (itemRequireAttrs.ContainsKey(_200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4080104489u), text)))
			{
				num = 1580407908;
				num17 = num;
			}
			else
			{
				num = 1005267824;
				num17 = num;
			}
		}
		goto IL_000b;
		IL_0209:
		itemRequireAttrs = getItemRequireAttrs();
		num = 633879861;
		goto IL_0010;
		IL_02c1:
		bool result = default(bool);
		string[] array = default(string[]);
		int num20 = default(int);
		using (List<string>.Enumerator enumerator = getItemRequireTalents().GetEnumerator())
		{
			int num26 = default(int);
			string[] array2 = default(string[]);
			bool flag = default(bool);
			while (true)
			{
				IL_043b:
				int num18;
				int num19;
				if (!enumerator.MoveNext())
				{
					num18 = 1051829046;
					num19 = num18;
				}
				else
				{
					num18 = 1151603923;
					num19 = num18;
				}
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num18 ^ 0x29C79FD6)) % 23)
					{
					case 5u:
						num18 = 1151603923;
						continue;
					default:
						goto end_IL_02d7;
					case 18u:
						result = false;
						num18 = (int)((num2 * 1030364271) ^ 0x19FE8C1F);
						continue;
					case 16u:
					{
						string text2 = array[num20];
						int num22;
						if (r.HasTalent(text2))
						{
							num18 = 843858030;
							num22 = num18;
						}
						else
						{
							num18 = 155893942;
							num22 = num18;
						}
						continue;
					}
					case 21u:
					{
						int num27;
						if (num26 >= array2.Length)
						{
							num18 = 62159250;
							num27 = num18;
						}
						else
						{
							num18 = 1104049106;
							num27 = num18;
						}
						continue;
					}
					case 20u:
						num26 = 1;
						num18 = ((int)num2 * -1735532659) ^ 0xA5DC4F2;
						continue;
					case 15u:
						result = false;
						num18 = (int)((num2 * 1396423490) ^ 0x4C140669);
						continue;
					case 10u:
						num18 = ((int)num2 * -78834073) ^ 0x4067518C;
						continue;
					case 13u:
					{
						int num28;
						if (r.HasTalent(array2[num26]))
						{
							num18 = 1955583011;
							num28 = num18;
						}
						else
						{
							num18 = 266987027;
							num28 = num18;
						}
						continue;
					}
					case 22u:
						num26++;
						num18 = 1363366962;
						continue;
					case 6u:
						num18 = ((int)num2 * -367927554) ^ 0x2A5E5180;
						continue;
					case 12u:
						break;
					case 2u:
					{
						int num24;
						int num25;
						if (!_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(array2[0], global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3816599084u)))
						{
							num24 = -622994012;
							num25 = num24;
						}
						else
						{
							num24 = -854220046;
							num25 = num24;
						}
						num18 = num24 ^ ((int)num2 * -678517583);
						continue;
					}
					case 7u:
						num20++;
						num18 = 1564508523;
						continue;
					case 4u:
						flag = true;
						num18 = ((int)num2 * -1083440093) ^ -559105220;
						continue;
					case 1u:
						array2 = _206B_200E_206B_200C_202B_202E_200D_200C_202D_200D_202E_200E_200B_200B_206E_202E_200B_202B_206B_202C_206F_200F_200D_200D_200F_206D_200C_206C_202E_202B_202D_200F_200D_202A_200F_202C_206F_202A_200D_202B_202E(enumerator.Current, new char[1] { '|' });
						num18 = 1245153948;
						continue;
					case 3u:
					{
						int num23;
						if (num20 < array.Length)
						{
							num18 = 1451328125;
							num23 = num18;
						}
						else
						{
							num18 = 1118324537;
							num23 = num18;
						}
						continue;
					}
					case 14u:
					{
						int num21;
						if (flag)
						{
							num18 = 963591928;
							num21 = num18;
						}
						else
						{
							num18 = 647599706;
							num21 = num18;
						}
						continue;
					}
					case 11u:
						num18 = (int)(num2 * 458385882) ^ -1054236541;
						continue;
					case 19u:
						num18 = (int)((num2 * 799696725) ^ 0x77DCCF53);
						continue;
					case 0u:
						flag = false;
						array = array2;
						num20 = 0;
						num18 = 1388959122;
						continue;
					case 17u:
						goto end_IL_02d7;
					case 8u:
					case 9u:
						goto IL_183d;
					}
					goto IL_043b;
					continue;
					end_IL_02d7:
					break;
				}
				break;
			}
		}
		using (List<int>.Enumerator enumerator2 = getItemRequireRoleLevel().GetEnumerator())
		{
			int current = default(int);
			while (true)
			{
				IL_05f0:
				int num29;
				int num30;
				if (!enumerator2.MoveNext())
				{
					num29 = 62264696;
					num30 = num29;
				}
				else
				{
					num29 = 1722532856;
					num30 = num29;
				}
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num29 ^ 0x29C79FD6)) % 9)
					{
					case 3u:
						num29 = 1722532856;
						continue;
					default:
						goto end_IL_057d;
					case 0u:
					{
						int num33;
						int num34;
						if (r.Level >= current)
						{
							num33 = 1595067510;
							num34 = num33;
						}
						else
						{
							num33 = 577433935;
							num34 = num33;
						}
						num29 = num33 ^ ((int)num2 * -138641552);
						continue;
					}
					case 1u:
						break;
					case 6u:
						result = false;
						goto IL_183d;
					case 8u:
						result = false;
						num29 = (int)(num2 * 1816293110) ^ -210569516;
						continue;
					case 5u:
					{
						int num32;
						if (r.Level < -current)
						{
							num29 = 374674198;
							num32 = num29;
						}
						else
						{
							num29 = 407539853;
							num32 = num29;
						}
						continue;
					}
					case 7u:
					{
						current = enumerator2.Current;
						int num31;
						if (current >= 0)
						{
							num29 = 143904748;
							num31 = num29;
						}
						else
						{
							num29 = 971491237;
							num31 = num29;
						}
						continue;
					}
					case 2u:
						goto end_IL_057d;
					case 4u:
						goto IL_183d;
					}
					goto IL_05f0;
					continue;
					end_IL_057d:
					break;
				}
				break;
			}
		}
		using (List<string>.Enumerator enumerator = getItemRequireStorys().GetEnumerator())
		{
			int num38 = default(int);
			string[] array3 = default(string[]);
			bool flag2 = default(bool);
			string text3 = default(string);
			while (true)
			{
				IL_08cf:
				int num35;
				int num36;
				if (enumerator.MoveNext())
				{
					num35 = 1601086683;
					num36 = num35;
				}
				else
				{
					num35 = 804975210;
					num36 = num35;
				}
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num35 ^ 0x29C79FD6)) % 20)
					{
					case 16u:
						num35 = 1601086683;
						continue;
					default:
						goto end_IL_06a5;
					case 2u:
						num35 = ((int)num2 * -1594185427) ^ -282720080;
						continue;
					case 14u:
						result = false;
						goto IL_183d;
					case 5u:
					{
						int num39;
						if (num38 >= array3.Length)
						{
							num35 = 1777060828;
							num39 = num35;
						}
						else
						{
							num35 = 1545796117;
							num39 = num35;
						}
						continue;
					}
					case 13u:
						num38 = 1;
						num35 = (int)((num2 * 1459488941) ^ 0x31A4F6D2);
						continue;
					case 7u:
					{
						int num41;
						if (RuntimeData.Instance.KeyValues.ContainsKey(_206B_200E_206B_200C_202B_202E_200D_200C_202D_200D_202E_200E_200B_200B_206E_202E_200B_202B_206B_202C_206F_200F_200D_200D_200F_206D_200C_206C_202E_202B_202D_200F_200D_202A_200F_202C_206F_202A_200D_202B_202E(array3[num38], new char[1] { ',' })[0]))
						{
							num35 = 1145952630;
							num41 = num35;
						}
						else
						{
							num35 = 2020760084;
							num41 = num35;
						}
						continue;
					}
					case 0u:
						num20++;
						num35 = 1505021347;
						continue;
					case 9u:
					{
						array3 = _206B_200E_206B_200C_202B_202E_200D_200C_202D_200D_202E_200E_200B_200B_206E_202E_200B_202B_206B_202C_206F_200F_200D_200D_200F_206D_200C_206C_202E_202B_202D_200F_200D_202A_200F_202C_206F_202A_200D_202B_202E(enumerator.Current, new char[1] { '|' });
						int num44;
						if (_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(array3[0], global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3816599084u)))
						{
							num35 = 1366933527;
							num44 = num35;
						}
						else
						{
							num35 = 1950534621;
							num44 = num35;
						}
						continue;
					}
					case 10u:
						num20 = 0;
						num35 = (int)((num2 * 1738310673) ^ 0x1FF22315);
						continue;
					case 15u:
						flag2 = true;
						num35 = (int)(num2 * 1526295924) ^ -1686079739;
						continue;
					case 12u:
						result = false;
						num35 = ((int)num2 * -976394678) ^ 0x632A9387;
						continue;
					case 18u:
						num38++;
						num35 = 1384532927;
						continue;
					case 6u:
					{
						int num42;
						int num43;
						if (RuntimeData.Instance.KeyValues.ContainsKey(_206B_200E_206B_200C_202B_202E_200D_200C_202D_200D_202E_200E_200B_200B_206E_202E_200B_202B_206B_202C_206F_200F_200D_200D_200F_206D_200C_206C_202E_202B_202D_200F_200D_202A_200F_202C_206F_202A_200D_202B_202E(text3, new char[1] { ',' })[0]))
						{
							num42 = -504071421;
							num43 = num42;
						}
						else
						{
							num42 = -1038945600;
							num43 = num42;
						}
						num35 = num42 ^ ((int)num2 * -110474911);
						continue;
					}
					case 11u:
						flag2 = false;
						array = array3;
						num35 = 486612608;
						continue;
					case 1u:
					{
						int num40;
						if (num20 < array.Length)
						{
							num35 = 122967293;
							num40 = num35;
						}
						else
						{
							num35 = 254759737;
							num40 = num35;
						}
						continue;
					}
					case 8u:
						break;
					case 3u:
					{
						int num37;
						if (!flag2)
						{
							num35 = 433038336;
							num37 = num35;
						}
						else
						{
							num35 = 841963378;
							num37 = num35;
						}
						continue;
					}
					case 19u:
						text3 = array[num20];
						num35 = 1316502424;
						continue;
					case 4u:
						goto end_IL_06a5;
					case 17u:
						goto IL_183d;
					}
					goto IL_08cf;
					continue;
					end_IL_06a5:
					break;
				}
				break;
			}
		}
		using (List<string>.Enumerator enumerator = getItemRequireRoleKeys().GetEnumerator())
		{
			string[] array4 = default(string[]);
			int num47 = default(int);
			string text4 = default(string);
			bool flag3 = default(bool);
			while (true)
			{
				IL_0a9e:
				int num45;
				int num46;
				if (!enumerator.MoveNext())
				{
					num45 = 1456561141;
					num46 = num45;
				}
				else
				{
					num45 = 1304018814;
					num46 = num45;
				}
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num45 ^ 0x29C79FD6)) % 22)
					{
					case 8u:
						num45 = 1304018814;
						continue;
					default:
						goto end_IL_093b;
					case 12u:
						num45 = ((int)num2 * -1607089627) ^ -1823611906;
						continue;
					case 11u:
					{
						int num49;
						if (!_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(r.Key, array4[num47]))
						{
							num45 = 214210062;
							num49 = num45;
						}
						else
						{
							num45 = 1548613;
							num49 = num45;
						}
						continue;
					}
					case 10u:
					{
						int num54;
						int num55;
						if (_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(r.Key, text4))
						{
							num54 = 1478882733;
							num55 = num54;
						}
						else
						{
							num54 = 1369301314;
							num55 = num54;
						}
						num45 = num54 ^ (int)(num2 * 94950692);
						continue;
					}
					case 20u:
					{
						int num51;
						if (num47 >= array4.Length)
						{
							num45 = 1875928602;
							num51 = num45;
						}
						else
						{
							num45 = 2078883987;
							num51 = num45;
						}
						continue;
					}
					case 2u:
					{
						int num52;
						int num53;
						if (!_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(array4[0], global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3816599084u)))
						{
							num52 = -1476139931;
							num53 = num52;
						}
						else
						{
							num52 = -1476622504;
							num53 = num52;
						}
						num45 = num52 ^ (int)(num2 * 1876238367);
						continue;
					}
					case 19u:
					{
						int num50;
						if (num20 < array.Length)
						{
							num45 = 444891858;
							num50 = num45;
						}
						else
						{
							num45 = 2101107577;
							num50 = num45;
						}
						continue;
					}
					case 14u:
						text4 = array[num20];
						num45 = 354872350;
						continue;
					case 21u:
					{
						int num48;
						if (flag3)
						{
							num45 = 280121730;
							num48 = num45;
						}
						else
						{
							num45 = 2098987301;
							num48 = num45;
						}
						continue;
					}
					case 16u:
						break;
					case 4u:
						num47++;
						num45 = 886160982;
						continue;
					case 9u:
						flag3 = false;
						array = array4;
						num45 = 359565365;
						continue;
					case 0u:
						num20++;
						num45 = 1422404177;
						continue;
					case 1u:
						result = false;
						goto IL_183d;
					case 3u:
						num45 = (int)(num2 * 704735271) ^ -2079965989;
						continue;
					case 5u:
						num20 = 0;
						num45 = ((int)num2 * -1967326718) ^ -678299753;
						continue;
					case 7u:
						flag3 = true;
						num45 = (int)(num2 * 1896274668) ^ -1412024537;
						continue;
					case 13u:
						num45 = (int)((num2 * 1486350231) ^ 0x73816D1A);
						continue;
					case 6u:
						array4 = _206B_200E_206B_200C_202B_202E_200D_200C_202D_200D_202E_200E_200B_200B_206E_202E_200B_202B_206B_202C_206F_200F_200D_200D_200F_206D_200C_206C_202E_202B_202D_200F_200D_202A_200F_202C_206F_202A_200D_202B_202E(enumerator.Current, new char[1] { '|' });
						num45 = 82187738;
						continue;
					case 18u:
						num47 = 1;
						num45 = ((int)num2 * -1404798719) ^ -1396205049;
						continue;
					case 17u:
						result = false;
						goto IL_183d;
					case 15u:
						goto end_IL_093b;
					}
					goto IL_0a9e;
					continue;
					end_IL_093b:
					break;
				}
				break;
			}
		}
		using (List<string>.Enumerator enumerator = getItemRequireItems().GetEnumerator())
		{
			bool flag4 = default(bool);
			string[] array6 = default(string[]);
			int num63 = default(int);
			int rolesEquipment2 = default(int);
			string[] array5 = default(string[]);
			int num65 = default(int);
			int rolesEquipment5 = default(int);
			int rolesEquipment4 = default(int);
			string[] array7 = default(string[]);
			int num59 = default(int);
			int rolesEquipment3 = default(int);
			int num60 = default(int);
			int rolesEquipment6 = default(int);
			int num77 = default(int);
			int rolesEquipment = default(int);
			while (true)
			{
				IL_0ec5:
				int num56;
				int num57;
				if (enumerator.MoveNext())
				{
					num56 = 1803027236;
					num57 = num56;
				}
				else
				{
					num56 = 143064862;
					num57 = num56;
				}
				while (true)
				{
					uint num2;
					int num62;
					int num114;
					int num64;
					int num58;
					int num72;
					int num121;
					switch ((num2 = (uint)(num56 ^ 0x29C79FD6)) % 90)
					{
					case 29u:
						num56 = 1803027236;
						continue;
					default:
						goto end_IL_0bd3;
					case 85u:
						flag4 = true;
						num56 = (int)((num2 * 1047017319) ^ 0x148C8A80);
						continue;
					case 51u:
						flag4 = true;
						num56 = (int)((num2 * 582346133) ^ 0x692E5219);
						continue;
					case 37u:
					{
						int num99;
						int num100;
						if (RuntimeData.Instance.GetXiangziCount(array6[0]) >= num63)
						{
							num99 = -1342553192;
							num100 = num99;
						}
						else
						{
							num99 = -1147637432;
							num100 = num99;
						}
						num56 = num99 ^ (int)(num2 * 1299538400);
						continue;
					}
					case 25u:
					{
						rolesEquipment2 = RuntimeData.Instance.GetRolesEquipment(array5[0], num65);
						int num125;
						int num126;
						if (rolesEquipment2 >= num65)
						{
							num125 = 84574743;
							num126 = num125;
						}
						else
						{
							num125 = 911147893;
							num126 = num125;
						}
						num56 = num125 ^ (int)(num2 * 1005642776);
						continue;
					}
					case 26u:
					{
						int num107;
						int num108;
						if (rolesEquipment5 < num63)
						{
							num107 = 1363444884;
							num108 = num107;
						}
						else
						{
							num107 = 477826233;
							num108 = num107;
						}
						num56 = num107 ^ (int)(num2 * 343152369);
						continue;
					}
					case 69u:
					{
						int num122;
						int num123;
						if (rolesEquipment4 < num63)
						{
							num122 = -1588792151;
							num123 = num122;
						}
						else
						{
							num122 = -1501223585;
							num123 = num122;
						}
						num56 = num122 ^ (int)(num2 * 728214843);
						continue;
					}
					case 2u:
						rolesEquipment5 = RuntimeData.Instance.GetRolesEquipment(array6[0], num63);
						num56 = (int)(num2 * 1378277650) ^ -1370733676;
						continue;
					case 81u:
						result = false;
						goto IL_183d;
					case 71u:
						flag4 = false;
						array = array7;
						num20 = 0;
						num56 = 1764897412;
						continue;
					case 0u:
					{
						int num101;
						int num102;
						if (RuntimeData.Instance.GetItemsCount(array6[0]) < num63)
						{
							num101 = 1220318724;
							num102 = num101;
						}
						else
						{
							num101 = 1321477369;
							num102 = num101;
						}
						num56 = num101 ^ (int)(num2 * 502614606);
						continue;
					}
					case 86u:
						result = false;
						goto IL_183d;
					case 8u:
						break;
					case 68u:
						num56 = ((int)num2 * -1973330019) ^ 0x683AD7F2;
						continue;
					case 87u:
					{
						int num73;
						if (RuntimeData.Instance.GetItemsCount(array5[0]) + rolesEquipment2 >= num65)
						{
							num56 = 1913876459;
							num73 = num56;
						}
						else
						{
							num56 = 562946496;
							num73 = num56;
						}
						continue;
					}
					case 24u:
					{
						int num118;
						if (num20 >= array.Length)
						{
							num56 = 323901892;
							num118 = num56;
						}
						else
						{
							num56 = 783904092;
							num118 = num56;
						}
						continue;
					}
					case 35u:
						array5 = _206B_200E_206B_200C_202B_202E_200D_200C_202D_200D_202E_200E_200B_200B_206E_202E_200B_202B_206B_202C_206F_200F_200D_200D_200F_206D_200C_206C_202E_202B_202D_200F_200D_202A_200F_202C_206F_202A_200D_202B_202E(array7[num59], new char[1] { ',' });
						num56 = 2020590740;
						continue;
					case 72u:
					{
						int num113;
						if (rolesEquipment3 + RuntimeData.Instance.GetItemsCount(array5[0]) + RuntimeData.Instance.GetXiangziCount(array5[0]) < num65)
						{
							num56 = 562946496;
							num113 = num56;
						}
						else
						{
							num56 = 1865307371;
							num113 = num56;
						}
						continue;
					}
					case 62u:
						result = false;
						goto IL_183d;
					case 73u:
					{
						int num105;
						if (num60 == 5)
						{
							num56 = 1497814203;
							num105 = num56;
						}
						else
						{
							num56 = 803487567;
							num105 = num56;
						}
						continue;
					}
					case 1u:
					{
						int num94;
						int num95;
						if (RuntimeData.Instance.GetItemsCount(array5[0]) < num65)
						{
							num94 = -787389339;
							num95 = num94;
						}
						else
						{
							num94 = -1980076213;
							num95 = num94;
						}
						num56 = num94 ^ ((int)num2 * -1537079999);
						continue;
					}
					case 88u:
						flag4 = true;
						num56 = ((int)num2 * -610700816) ^ -660609628;
						continue;
					case 19u:
						rolesEquipment4 = RuntimeData.Instance.GetRolesEquipment(array6[0], num63);
						num56 = ((int)num2 * -948430621) ^ -1119792624;
						continue;
					case 31u:
						result = false;
						num56 = (int)(num2 * 128146581) ^ -225081898;
						continue;
					case 40u:
						rolesEquipment6 = RuntimeData.Instance.GetRolesEquipment(array6[0], num63);
						num56 = (int)((num2 * 1963559635) ^ 0xBA4AE04);
						continue;
					case 6u:
					{
						int num84;
						int num85;
						if (RuntimeData.Instance.GetItemsCount(array6[0]) + RuntimeData.Instance.GetXiangziCount(array6[0]) < num63)
						{
							num84 = -282739776;
							num85 = num84;
						}
						else
						{
							num84 = -680831587;
							num85 = num84;
						}
						num56 = num84 ^ (int)(num2 * 1366732615);
						continue;
					}
					case 79u:
						flag4 = true;
						num56 = (int)(num2 * 2044339493) ^ -1595064265;
						continue;
					case 34u:
						rolesEquipment3 = RuntimeData.Instance.GetRolesEquipment(array5[0], num65);
						num56 = (int)((num2 * 589361429) ^ 0x2F439F37);
						continue;
					case 55u:
						num62 = 0;
						goto IL_10f1;
					case 39u:
						flag4 = true;
						num56 = ((int)num2 * -1833764050) ^ 0x29F3CCE;
						continue;
					case 49u:
						result = false;
						goto IL_183d;
					case 20u:
						num114 = 1;
						goto IL_114f;
					case 15u:
					{
						int num115;
						int num116;
						if (RuntimeData.Instance.GetXiangziCount(array5[0]) >= num65)
						{
							num115 = 461866489;
							num116 = num115;
						}
						else
						{
							num115 = 7837468;
							num116 = num115;
						}
						num56 = num115 ^ (int)(num2 * 966990676);
						continue;
					}
					case 59u:
					{
						int num112;
						if (num77 != 1)
						{
							num56 = 453019454;
							num112 = num56;
						}
						else
						{
							num56 = 1234140656;
							num112 = num56;
						}
						continue;
					}
					case 18u:
						result = false;
						goto IL_183d;
					case 10u:
						array7 = _206B_200E_206B_200C_202B_202E_200D_200C_202D_200D_202E_200E_200B_200B_206E_202E_200B_202B_206B_202C_206F_200F_200D_200D_200F_206D_200C_206C_202E_202B_202D_200F_200D_202A_200F_202C_206F_202A_200D_202B_202E(enumerator.Current, new char[1] { '|' });
						num56 = 1458666672;
						continue;
					case 17u:
					{
						int num109;
						if (num77 < 6)
						{
							num56 = 492003688;
							num109 = num56;
						}
						else
						{
							num56 = 1889687978;
							num109 = num56;
						}
						continue;
					}
					case 28u:
					{
						int num104;
						if (num77 == 4)
						{
							num56 = 1302571982;
							num104 = num56;
						}
						else
						{
							num56 = 1365718064;
							num104 = num56;
						}
						continue;
					}
					case 54u:
					{
						int num97;
						if (num77 != 3)
						{
							num56 = 1949570414;
							num97 = num56;
						}
						else
						{
							num56 = 197590227;
							num97 = num56;
						}
						continue;
					}
					case 67u:
					{
						int num93;
						if (rolesEquipment + RuntimeData.Instance.GetXiangziCount(array5[0]) >= num65)
						{
							num56 = 318906521;
							num93 = num56;
						}
						else
						{
							num56 = 562946496;
							num93 = num56;
						}
						continue;
					}
					case 30u:
					{
						int num88;
						int num89;
						if (_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(array7[0], global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(887725519u)))
						{
							num88 = 296484062;
							num89 = num88;
						}
						else
						{
							num88 = 862120127;
							num89 = num88;
						}
						num56 = num88 ^ (int)(num2 * 336886981);
						continue;
					}
					case 46u:
					{
						int num83;
						if (rolesEquipment5 + RuntimeData.Instance.GetItemsCount(array6[0]) + RuntimeData.Instance.GetXiangziCount(array6[0]) >= num63)
						{
							num56 = 1014882233;
							num83 = num56;
						}
						else
						{
							num56 = 492003688;
							num83 = num56;
						}
						continue;
					}
					case 52u:
						flag4 = true;
						num56 = (int)((num2 * 1957523957) ^ 0x35672B1C);
						continue;
					case 89u:
					{
						int num78;
						int num79;
						if (num77 <= 0)
						{
							num78 = -1732222733;
							num79 = num78;
						}
						else
						{
							num78 = -1298274420;
							num79 = num78;
						}
						num56 = num78 ^ (int)(num2 * 1985382831);
						continue;
					}
					case 5u:
					{
						int num75;
						if (num59 < array7.Length)
						{
							num56 = 1600924651;
							num75 = num56;
						}
						else
						{
							num56 = 523466810;
							num75 = num56;
						}
						continue;
					}
					case 56u:
					{
						int num68;
						int num69;
						if (RuntimeData.Instance.GetItemsCount(array5[0]) + RuntimeData.Instance.GetXiangziCount(array5[0]) < num65)
						{
							num68 = 971298124;
							num69 = num68;
						}
						else
						{
							num68 = 1196421818;
							num69 = num68;
						}
						num56 = num68 ^ ((int)num2 * -1978173970);
						continue;
					}
					case 75u:
						result = false;
						goto IL_183d;
					case 14u:
						num56 = ((int)num2 * -2114652772) ^ -1173814983;
						continue;
					case 4u:
						if (_202D_202A_206F_206C_206D_206A_206A_206C_202D_200B_200C_206E_206A_200F_202E_202E_206D_202C_206C_206F_206B_202D_206A_206B_200E_206D_200C_202D_202C_202D_206A_206D_200B_200B_206F_206F_200F_200F_206F_202B_202E(array6[1]))
						{
							num56 = (int)(num2 * 707131068) ^ -390271667;
							continue;
						}
						num64 = _206A_200D_200D_202D_202C_206E_206A_200E_200F_202A_206A_200D_206C_202B_206D_206F_202E_202A_200D_200C_200E_202C_202C_200F_202B_200C_202A_200F_206D_206A_206F_200E_206E_200D_200E_200C_206B_206B_206D_200E_202E(1, int.Parse(array6[1]));
						goto IL_17b5;
					case 70u:
					{
						int num124;
						if (num77 != 2)
						{
							num56 = 1085214576;
							num124 = num56;
						}
						else
						{
							num56 = 735943865;
							num124 = num56;
						}
						continue;
					}
					case 83u:
						flag4 = true;
						num56 = ((int)num2 * -1797515070) ^ -22786622;
						continue;
					case 76u:
					{
						int num119;
						int num120;
						if (array5.Length <= 1)
						{
							num119 = 65852980;
							num120 = num119;
						}
						else
						{
							num119 = 1375918304;
							num120 = num119;
						}
						num56 = num119 ^ (int)(num2 * 757800460);
						continue;
					}
					case 66u:
					{
						int num117;
						if (num77 != 5)
						{
							num56 = 762829539;
							num117 = num56;
						}
						else
						{
							num56 = 1284722148;
							num117 = num56;
						}
						continue;
					}
					case 16u:
						if (!_202D_202A_206F_206C_206D_206A_206A_206C_202D_200B_200C_206E_206A_200F_202E_202E_206D_202C_206C_206F_206B_202D_206A_206B_200E_206D_200C_202D_202C_202D_206A_206D_200B_200B_206F_206F_200F_200F_206F_202B_202E(array5[1]))
						{
							num114 = _206A_200D_200D_202D_202C_206E_206A_200E_200F_202A_206A_200D_206C_202B_206D_206F_202E_202A_200D_200C_200E_202C_202C_200F_202B_200C_202A_200F_206D_206A_206F_200E_206E_200D_200E_200C_206B_206B_206D_200E_202E(1, int.Parse(array5[1]));
							goto IL_114f;
						}
						num56 = ((int)num2 * -1565961841) ^ -268601698;
						continue;
					case 22u:
						if (_202D_202A_206F_206C_206D_206A_206A_206C_202D_200B_200C_206E_206A_200F_202E_202E_206D_202C_206C_206F_206B_202D_206A_206B_200E_206D_200C_202D_202C_202D_206A_206D_200B_200B_206F_206F_200F_200F_206F_202B_202E(array6[2]))
						{
							num56 = (int)((num2 * 978935261) ^ 0x78BABF37);
							continue;
						}
						num58 = int.Parse(array6[2]);
						goto IL_1809;
					case 63u:
						num56 = (int)((num2 * 1977752516) ^ 0x40B0C4C8);
						continue;
					case 57u:
						flag4 = true;
						num56 = ((int)num2 * -166187625) ^ 0x466A6C39;
						continue;
					case 27u:
						result = false;
						goto IL_183d;
					case 60u:
						num56 = (int)(num2 * 483560335) ^ -785983648;
						continue;
					case 61u:
						result = false;
						num56 = ((int)num2 * -421030801) ^ -958716020;
						continue;
					case 74u:
						if (!_202D_202A_206F_206C_206D_206A_206A_206C_202D_200B_200C_206E_206A_200F_202E_202E_206D_202C_206C_206F_206B_202D_206A_206B_200E_206D_200C_202D_202C_202D_206A_206D_200B_200B_206F_206F_200F_200F_206F_202B_202E(array5[2]))
						{
							num62 = int.Parse(array5[2]);
							goto IL_10f1;
						}
						num56 = (int)((num2 * 2012527793) ^ 0x729AB9D9);
						continue;
					case 12u:
					{
						int num110;
						int num111;
						if (RuntimeData.Instance.GetRolesEquipment(array6[0], num63) < num63)
						{
							num110 = 1463625690;
							num111 = num110;
						}
						else
						{
							num110 = 1697524307;
							num111 = num110;
						}
						num56 = num110 ^ (int)(num2 * 1958286179);
						continue;
					}
					case 3u:
					{
						int num106;
						if (rolesEquipment6 + RuntimeData.Instance.GetXiangziCount(array6[0]) >= num63)
						{
							num56 = 969833285;
							num106 = num56;
						}
						else
						{
							num56 = 492003688;
							num106 = num56;
						}
						continue;
					}
					case 58u:
						num59 = 1;
						num56 = ((int)num2 * -1095415070) ^ 0x2FDBDAB8;
						continue;
					case 41u:
						result = false;
						goto IL_183d;
					case 47u:
					{
						int num103;
						if (num60 == 4)
						{
							num56 = 1823723452;
							num103 = num56;
						}
						else
						{
							num56 = 1170389317;
							num103 = num56;
						}
						continue;
					}
					case 36u:
					{
						int num98;
						if (!flag4)
						{
							num56 = 1723533518;
							num98 = num56;
						}
						else
						{
							num56 = 1836345268;
							num98 = num56;
						}
						continue;
					}
					case 78u:
					{
						array6 = _206B_200E_206B_200C_202B_202E_200D_200C_202D_200D_202E_200E_200B_200B_206E_202E_200B_202B_206B_202C_206F_200F_200D_200D_200F_206D_200C_206C_202E_202B_202D_200F_200D_202A_200F_202C_206F_202A_200D_202B_202E(array[num20], new char[1] { ',' });
						int num96;
						if (array6.Length <= 1)
						{
							num56 = 2089512853;
							num96 = num56;
						}
						else
						{
							num56 = 2008072700;
							num96 = num56;
						}
						continue;
					}
					case 44u:
						num20++;
						num56 = 1764897412;
						continue;
					case 82u:
					{
						int num91;
						int num92;
						if (rolesEquipment6 >= num63)
						{
							num91 = 1488125425;
							num92 = num91;
						}
						else
						{
							num91 = 378159717;
							num92 = num91;
						}
						num56 = num91 ^ ((int)num2 * -1554376910);
						continue;
					}
					case 21u:
					{
						int num90;
						if (num60 != 2)
						{
							num56 = 1209703600;
							num90 = num56;
						}
						else
						{
							num56 = 165654413;
							num90 = num56;
						}
						continue;
					}
					case 45u:
					{
						int num86;
						int num87;
						if (RuntimeData.Instance.GetRolesEquipment(array5[0], num65) >= num65)
						{
							num86 = -1603436449;
							num87 = num86;
						}
						else
						{
							num86 = -636293700;
							num87 = num86;
						}
						num56 = num86 ^ ((int)num2 * -564075164);
						continue;
					}
					case 53u:
					{
						int num81;
						int num82;
						if (rolesEquipment3 < num65)
						{
							num81 = 200291828;
							num82 = num81;
						}
						else
						{
							num81 = 1585337365;
							num82 = num81;
						}
						num56 = num81 ^ ((int)num2 * -501317812);
						continue;
					}
					case 32u:
					{
						int num80;
						if (RuntimeData.Instance.GetItemsCount(array6[0]) + rolesEquipment4 >= num63)
						{
							num56 = 1747575755;
							num80 = num56;
						}
						else
						{
							num56 = 492003688;
							num80 = num56;
						}
						continue;
					}
					case 77u:
					{
						int num76;
						if (num60 != 1)
						{
							num56 = 797589421;
							num76 = num56;
						}
						else
						{
							num56 = 1453868769;
							num76 = num56;
						}
						continue;
					}
					case 48u:
					{
						int num74;
						if (num60 != 3)
						{
							num56 = 1201928889;
							num74 = num56;
						}
						else
						{
							num56 = 1235006049;
							num74 = num56;
						}
						continue;
					}
					case 38u:
						num56 = ((int)num2 * -511287388) ^ 0x7B02F7F4;
						continue;
					case 11u:
						flag4 = true;
						num56 = (int)(num2 * 830397901) ^ -258872089;
						continue;
					case 50u:
					{
						int num70;
						int num71;
						if (array6.Length <= 2)
						{
							num70 = -1463843467;
							num71 = num70;
						}
						else
						{
							num70 = -2094731780;
							num71 = num70;
						}
						num56 = num70 ^ (int)(num2 * 1692397462);
						continue;
					}
					case 65u:
					{
						rolesEquipment = RuntimeData.Instance.GetRolesEquipment(array5[0], num65);
						int num66;
						int num67;
						if (rolesEquipment < num65)
						{
							num66 = 986300696;
							num67 = num66;
						}
						else
						{
							num66 = 236311781;
							num67 = num66;
						}
						num56 = num66 ^ ((int)num2 * -1592599863);
						continue;
					}
					case 84u:
						result = false;
						goto IL_183d;
					case 33u:
						num64 = 1;
						goto IL_17b5;
					case 42u:
						num56 = (int)((num2 * 1918579383) ^ 0x485464D0);
						continue;
					case 9u:
					{
						int num61;
						if (num60 >= 6)
						{
							num56 = 1629855052;
							num61 = num56;
						}
						else
						{
							num56 = 562946496;
							num61 = num56;
						}
						continue;
					}
					case 80u:
						num59++;
						num56 = 1614683905;
						continue;
					case 13u:
						num58 = 0;
						goto IL_1809;
					case 7u:
						flag4 = true;
						num56 = ((int)num2 * -395663560) ^ -1779246964;
						continue;
					case 64u:
						goto end_IL_0bd3;
					case 23u:
					case 43u:
						goto IL_183d;
						IL_17b5:
						num63 = num64;
						num56 = 551631766;
						continue;
						IL_10f1:
						num60 = num62;
						if (num60 > 0)
						{
							num56 = 1317439953;
							num72 = num56;
						}
						else
						{
							num56 = 1317219507;
							num72 = num56;
						}
						continue;
						IL_1809:
						num77 = num58;
						num56 = 631062759;
						continue;
						IL_114f:
						num65 = num114;
						if (array5.Length > 2)
						{
							num56 = 1040451914;
							num121 = num56;
						}
						else
						{
							num56 = 1394542597;
							num121 = num56;
						}
						continue;
					}
					goto IL_0ec5;
					continue;
					end_IL_0bd3:
					break;
				}
				break;
			}
		}
		return true;
		IL_183d:
		return result;
	}

	public ItemSkill GetItemSkill()
	{
		ItemSkill result = default(ItemSkill);
		using (List<Trigger>.Enumerator enumerator = Triggers.GetEnumerator())
		{
			Trigger current = default(Trigger);
			while (true)
			{
				IL_01b0:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -882327664;
					num2 = num;
				}
				else
				{
					num = -1244963159;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -1700290306)) % 10)
					{
					case 7u:
						num = -1244963159;
						continue;
					default:
						goto end_IL_0016;
					case 9u:
					{
						int num8;
						int num9;
						if (!_202A_202E_206A_206B_200F_200D_200E_206B_200C_202D_202A_202B_200B_202D_206E_206F_200E_200F_202B_206D_202A_206B_202A_206C_200E_206E_206E_206C_202E_200B_206A_200D_206E_200F_206D_202B_200B_202A_206C_200C_202E(current.Name, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3003433419u)))
						{
							num8 = -1741681740;
							num9 = num8;
						}
						else
						{
							num8 = -83653444;
							num9 = num8;
						}
						num = num8 ^ (int)(num3 * 1503964310);
						continue;
					}
					case 1u:
						current = enumerator.Current;
						num = -646825609;
						continue;
					case 3u:
					{
						int num10;
						int num11;
						if (_202A_202E_206A_206B_200F_200D_200E_206B_200C_202D_202A_202B_200B_202D_206E_206F_200E_200F_202B_206D_202A_206B_202A_206C_200E_206E_206E_206C_202E_200B_206A_200D_206E_200F_206D_202B_200B_202A_206C_200C_202E(current.Name, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4075180608u)))
						{
							num10 = -878912560;
							num11 = num10;
						}
						else
						{
							num10 = -196726515;
							num11 = num10;
						}
						num = num10 ^ (int)(num3 * 1545928926);
						continue;
					}
					case 6u:
						result = new ItemSkill
						{
							IsInternal = _202A_202E_206A_206B_200F_200D_200E_206B_200C_202D_202A_202B_200B_202D_206E_206F_200E_200F_202B_206D_202A_206B_202A_206C_200E_206E_206E_206C_202E_200B_206A_200D_206E_200F_206D_202B_200B_202A_206C_200C_202E(current.Name, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4075180608u)),
							SkillName = current.Argvs[0],
							MaxLevel = ((current.Argvs.Count <= 1) ? 1 : int.Parse(current.Argvs[1]))
						};
						num = -1534627100;
						continue;
					case 2u:
					{
						int num6;
						int num7;
						if (_202A_202E_206A_206B_200F_200D_200E_206B_200C_202D_202A_202B_200B_202D_206E_206F_200E_200F_202B_206D_202A_206B_202A_206C_200E_206E_206E_206C_202E_200B_206A_200D_206E_200F_206D_202B_200B_202A_206C_200C_202E(current.Name, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1480101968u)))
						{
							num6 = 1467872226;
							num7 = num6;
						}
						else
						{
							num6 = 1419011286;
							num7 = num6;
						}
						num = num6 ^ ((int)num3 * -1250951222);
						continue;
					}
					case 5u:
					{
						int num4;
						int num5;
						if (_202A_202E_206A_206B_200F_200D_200E_206B_200C_202D_202A_202B_200B_202D_206E_206F_200E_200F_202B_206D_202A_206B_202A_206C_200E_206E_206E_206C_202E_200B_206A_200D_206E_200F_206D_202B_200B_202A_206C_200C_202E(current.Name, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(278347322u)))
						{
							num4 = -174784377;
							num5 = num4;
						}
						else
						{
							num4 = -1611827160;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -1447190091);
						continue;
					}
					case 8u:
						break;
					case 4u:
						goto end_IL_0016;
					case 0u:
						goto IL_0327;
					}
					goto IL_01b0;
					continue;
					end_IL_0016:
					break;
				}
				break;
			}
		}
		if (!_202D_202A_206F_206C_206D_206A_206A_206C_202D_200B_200C_206E_206A_200F_202E_202E_206D_202C_206C_206F_206B_202D_206A_206B_200E_206D_200C_202D_202C_202D_206A_206D_200B_200B_206F_206F_200F_200F_206F_202B_202E(talent))
		{
			while (true)
			{
				uint num3;
				switch ((num3 = 1130647832u) % 3)
				{
				case 0u:
					continue;
				case 2u:
					return new ItemSkill
					{
						IsInternal = false,
						SkillName = talent,
						MaxLevel = -1
					};
				}
				break;
			}
		}
		using (List<Trigger>.Enumerator enumerator = Triggers.GetEnumerator())
		{
			Trigger current2 = default(Trigger);
			while (true)
			{
				IL_028c:
				int num12;
				int num13;
				if (enumerator.MoveNext())
				{
					num12 = -1162561605;
					num13 = num12;
				}
				else
				{
					num12 = -959182948;
					num13 = num12;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num12 ^ -1700290306)) % 6)
					{
					case 0u:
						num12 = -1162561605;
						continue;
					default:
						goto end_IL_0250;
					case 5u:
						current2 = enumerator.Current;
						num12 = -803519483;
						continue;
					case 1u:
						break;
					case 3u:
					{
						int num14;
						int num15;
						if (_202A_202E_206A_206B_200F_200D_200E_206B_200C_202D_202A_202B_200B_202D_206E_206F_200E_200F_202B_206D_202A_206B_202A_206C_200E_206E_206E_206C_202E_200B_206A_200D_206E_200F_206D_202B_200B_202A_206C_200C_202E(current2.Name, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3596028323u)))
						{
							num14 = -395661295;
							num15 = num14;
						}
						else
						{
							num14 = -1130503340;
							num15 = num14;
						}
						num12 = num14 ^ (int)(num3 * 1291762163);
						continue;
					}
					case 2u:
						result = new ItemSkill
						{
							IsInternal = false,
							SkillName = current2.Argvs[0],
							MaxLevel = 1
						};
						goto IL_0327;
					case 4u:
						goto end_IL_0250;
					}
					goto IL_028c;
					continue;
					end_IL_0250:
					break;
				}
				break;
			}
		}
		return null;
		IL_0327:
		return result;
	}

	public ItemResult TryUse(Role source, Role target)
	{
		ItemResult itemResult = new ItemResult();
		using (List<Trigger>.Enumerator enumerator = item.Triggers.GetEnumerator())
		{
			Trigger current = default(Trigger);
			string name = default(string);
			int num8 = default(int);
			string[] array = default(string[]);
			int num7 = default(int);
			int num23 = default(int);
			int num15 = default(int);
			int num14 = default(int);
			while (true)
			{
				IL_06de:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 1339817151;
					num2 = num;
				}
				else
				{
					num = 634438543;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x4CF50324)) % 75)
					{
					case 21u:
						num = 634438543;
						continue;
					default:
						goto end_IL_0021;
					case 33u:
						itemResult.MaxDaofa = int.Parse(current.Argvs[0]);
						num = (int)(num3 * 1673951308) ^ -1363283983;
						continue;
					case 32u:
					{
						int num36;
						if (_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(name, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(682949148u)))
						{
							num = 1317523796;
							num36 = num;
						}
						else
						{
							num = 493162694;
							num36 = num;
						}
						continue;
					}
					case 23u:
					{
						int num40;
						int num41;
						if (itemResult.Buffs == null)
						{
							num40 = 2349262;
							num41 = num40;
						}
						else
						{
							num40 = 1408896457;
							num41 = num40;
						}
						num = num40 ^ (int)(num3 * 756735438);
						continue;
					}
					case 48u:
					{
						num8 = _202E_206C_206B_200E_202D_200D_200C_200B_206A_202B_200F_200D_206C_206D_202E_206D_200C_200C_200C_206A_206E_200E_200F_200C_200F_202A_206B_200F_200F_206B_202B_202C_206A_206A_200B_202B_202B_202E_202C_200F_202E(array[num7], '@');
						int num17;
						if (num8 <= 0)
						{
							num = 1991814860;
							num17 = num;
						}
						else
						{
							num = 1625937029;
							num17 = num;
						}
						continue;
					}
					case 38u:
						itemResult.MaxGengu = int.Parse(current.Argvs[0]);
						num = ((int)num3 * -142618468) ^ 0x5681E856;
						continue;
					case 2u:
					{
						int num37;
						if (!_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(name, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1999429887u)))
						{
							num = 1885892441;
							num37 = num;
						}
						else
						{
							num = 848878970;
							num37 = num;
						}
						continue;
					}
					case 20u:
					{
						int num30;
						if (_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(name, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1788996138u)))
						{
							num = 1103307407;
							num30 = num;
						}
						else
						{
							num = 574669771;
							num30 = num;
						}
						continue;
					}
					case 46u:
						itemResult.MaxQimen = int.Parse(current.Argvs[0]);
						num = (int)((num3 * 1243207811) ^ 0x72AE19DB);
						continue;
					case 45u:
						num7++;
						num = 958589561;
						continue;
					case 66u:
						itemResult.DescPoisonDuration = int.Parse(current.Argvs[1]);
						num = (int)(num3 * 1266362972) ^ -1445827017;
						continue;
					case 69u:
						num = ((int)num3 * -857614683) ^ 0x76BC785C;
						continue;
					case 4u:
						num = (int)((num3 * 1931625353) ^ 0x353A7538);
						continue;
					case 35u:
						itemResult.Mp += num23;
						num = ((int)num3 * -1781162765) ^ -312640585;
						continue;
					case 34u:
						itemResult.Buffs = new List<Buff>();
						num = ((int)num3 * -1942665402) ^ 0x1AF68AD3;
						continue;
					case 47u:
					{
						int num10;
						if (!_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(name, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4073696776u)))
						{
							num = 1530762017;
							num10 = num;
						}
						else
						{
							num = 1554090464;
							num10 = num;
						}
						continue;
					}
					case 61u:
						num = (int)((num3 * 916162923) ^ 0x542FE4EC);
						continue;
					case 62u:
						num = (int)(num3 * 499442907) ^ -1749731114;
						continue;
					case 25u:
					{
						int num39;
						if (_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(name, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3465369481u)))
						{
							num = 660244838;
							num39 = num;
						}
						else
						{
							num = 72432742;
							num39 = num;
						}
						continue;
					}
					case 17u:
					{
						int num34;
						if (!_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(name, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2711099638u)))
						{
							num = 2117382784;
							num34 = num;
						}
						else
						{
							num = 466443546;
							num34 = num;
						}
						continue;
					}
					case 63u:
					{
						int num31;
						int num32;
						if (_202D_202A_206F_206C_206D_206A_206A_206C_202D_200B_200C_206E_206A_200F_202E_202E_206D_202C_206C_206F_206B_202D_206A_206B_200E_206D_200C_202D_202C_202D_206A_206D_200B_200B_206F_206F_200F_200F_206F_202B_202E(array[1]))
						{
							num31 = 1532646626;
							num32 = num31;
						}
						else
						{
							num31 = 736337605;
							num32 = num31;
						}
						num = num31 ^ (int)(num3 * 873402555);
						continue;
					}
					case 74u:
					{
						int num25;
						if (!_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(name, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(646645819u)))
						{
							num = 1766051398;
							num25 = num;
						}
						else
						{
							num = 1923421281;
							num25 = num;
						}
						continue;
					}
					case 52u:
						itemResult.MaxFuyuan = int.Parse(current.Argvs[0]);
						num = (int)(num3 * 851423870) ^ -442841364;
						continue;
					case 14u:
					{
						int num20;
						int num21;
						if (array.Length == 0)
						{
							num20 = -663613418;
							num21 = num20;
						}
						else
						{
							num20 = -580889047;
							num21 = num20;
						}
						num = num20 ^ (int)(num3 * 130874774);
						continue;
					}
					case 59u:
						itemResult.Female = int.Parse(current.Argvs[0]);
						num = (int)(num3 * 125715579) ^ -1704910900;
						continue;
					case 54u:
					{
						int num12;
						int num13;
						if (_202A_206C_200F_200F_202C_206B_206D_200B_202D_202A_200B_206D_206C_202A_202C_202E_200F_206F_202C_202D_200F_200F_200E_200B_200F_200B_202B_206C_200B_200C_200E_202C_206C_206C_200E_202B_200C_200C_206B_200D_202E(current.ArgvsString) > 4)
						{
							num12 = -556566397;
							num13 = num12;
						}
						else
						{
							num12 = -143615222;
							num13 = num12;
						}
						num = num12 ^ (int)(num3 * 1760214232);
						continue;
					}
					case 30u:
						num = ((int)num3 * -417237527) ^ 0x2D81CDB4;
						continue;
					case 60u:
					{
						int num6;
						if (!_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(name, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3085991755u)))
						{
							num = 1596796753;
							num6 = num;
						}
						else
						{
							num = 1644053442;
							num6 = num;
						}
						continue;
					}
					case 11u:
						itemResult.SwitchGameScene = _202D_202B_206C_200E_206A_202A_200F_200E_206F_200F_202A_200C_206D_206C_202B_200C_200C_200F_206F_206D_202C_206A_200D_202C_206D_200D_200B_200E_202D_200E_206E_202B_200D_200E_202A_202B_200F_206B_206E_200E_202E(itemResult.SwitchGameScene, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1541154258u), array[1]);
						num = (int)((num3 * 946555349) ^ 0x1CB15AFD);
						continue;
					case 37u:
						itemResult.MaxWuxing = int.Parse(current.Argvs[0]);
						num = (int)(num3 * 1838379013) ^ -69242629;
						continue;
					case 6u:
						itemResult.DescPoisonLevel = int.Parse(current.Argvs[0]);
						num = (int)(num3 * 1628586914) ^ -2135842395;
						continue;
					case 57u:
						num15 = int.Parse(current.Argvs[0]);
						num = (int)((num3 * 887440827) ^ 0x4E0623A5);
						continue;
					case 70u:
					{
						int num42;
						if (_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(name, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3006817443u)))
						{
							num = 689384061;
							num42 = num;
						}
						else
						{
							num = 722026078;
							num42 = num;
						}
						continue;
					}
					case 53u:
						num = (int)(num3 * 779623510) ^ -250948500;
						continue;
					case 24u:
						num = ((int)num3 * -1337543380) ^ 0x25A5FB12;
						continue;
					case 41u:
						num14 = (int)((double)target.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2431070502u)] * ((double)int.Parse(current.Argvs[0]) / 100.0));
						num = ((int)num3 * -2091319093) ^ -926995701;
						continue;
					case 50u:
					{
						int num38;
						if (_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(name, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4046693431u)))
						{
							num = 1821539230;
							num38 = num;
						}
						else
						{
							num = 1075582282;
							num38 = num;
						}
						continue;
					}
					case 18u:
						itemResult.SwitchGameScene = string.Empty;
						num = 1766051398;
						continue;
					case 43u:
						itemResult.MaxBili = int.Parse(current.Argvs[0]);
						num = ((int)num3 * -1121423634) ^ 0x405E6404;
						continue;
					case 67u:
						num = (int)((num3 * 2071166187) ^ 0x6A8C1D6B);
						continue;
					case 5u:
						num23 = int.Parse(current.Argvs[0]);
						num = ((int)num3 * -733029000) ^ 0x59AEF07F;
						continue;
					case 19u:
						break;
					case 3u:
					{
						int num35;
						if (!_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(name, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1766595201u)))
						{
							num = 187012845;
							num35 = num;
						}
						else
						{
							num = 596871759;
							num35 = num;
						}
						continue;
					}
					case 8u:
						itemResult.MaxDingli = int.Parse(current.Argvs[0]);
						num = (int)(num3 * 475069841) ^ -1734364464;
						continue;
					case 44u:
					{
						int num33;
						if (!_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(name, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(526923066u)))
						{
							num = 1184816477;
							num33 = num;
						}
						else
						{
							num = 641714493;
							num33 = num;
						}
						continue;
					}
					case 16u:
						itemResult.MaxJianfa = int.Parse(current.Argvs[0]);
						num = (int)((num3 * 857498001) ^ 0x45798B16);
						continue;
					case 29u:
						itemResult.MaxHp = int.Parse(current.Argvs[0]);
						num = ((int)num3 * -589116833) ^ -593106694;
						continue;
					case 1u:
					{
						int num28;
						int num29;
						if (array.Length <= 1)
						{
							num28 = -61793401;
							num29 = num28;
						}
						else
						{
							num28 = -1355017911;
							num29 = num28;
						}
						num = num28 ^ (int)(num3 * 168509505);
						continue;
					}
					case 65u:
						itemResult.MaxMp = int.Parse(current.Argvs[0]);
						num = ((int)num3 * -525433262) ^ 0x1CC33A55;
						continue;
					case 49u:
					{
						int num27;
						if (_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(name, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(155585149u)))
						{
							num = 256789364;
							num27 = num;
						}
						else
						{
							num = 916940112;
							num27 = num;
						}
						continue;
					}
					case 26u:
					{
						int num26 = (int)((double)target.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(475395429u)] * ((double)int.Parse(current.Argvs[0]) / 100.0));
						itemResult.Mp += num26;
						num = (int)(num3 * 173139366) ^ -730779402;
						continue;
					}
					case 12u:
					{
						int num24;
						if (_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(name, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1449376701u)))
						{
							num = 701017643;
							num24 = num;
						}
						else
						{
							num = 1516442690;
							num24 = num;
						}
						continue;
					}
					case 72u:
						LuaManager.Call(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(350278345u), source, target, current, itemResult);
						num = 1002345208;
						continue;
					case 55u:
						itemResult.MaxShenfa = int.Parse(current.Argvs[0]);
						num = (int)(num3 * 126807556) ^ -1150767350;
						continue;
					case 42u:
					{
						int num22;
						if (_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(name, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1375895299u)))
						{
							num = 101576991;
							num22 = num;
						}
						else
						{
							num = 995797968;
							num22 = num;
						}
						continue;
					}
					case 31u:
					{
						int num19;
						if (_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(name, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3333995814u)))
						{
							num = 1228901368;
							num19 = num;
						}
						else
						{
							num = 1793647525;
							num19 = num;
						}
						continue;
					}
					case 58u:
					{
						int num18;
						if (_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(name, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(985960478u)))
						{
							num = 1684874551;
							num18 = num;
						}
						else
						{
							num = 1725466157;
							num18 = num;
						}
						continue;
					}
					case 0u:
					{
						int num16;
						if (_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(name, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3528689010u)))
						{
							num = 1881156867;
							num16 = num;
						}
						else
						{
							num = 483320293;
							num16 = num;
						}
						continue;
					}
					case 27u:
						itemResult.Hp += num15;
						num = (int)((num3 * 1470633089) ^ 0x288C0B4);
						continue;
					case 22u:
						num = ((int)num3 * -1739912651) ^ -1568895861;
						continue;
					case 64u:
						itemResult.Hp += num14;
						num = (int)(num3 * 1808249516) ^ -1879739969;
						continue;
					case 73u:
						num = (int)((num3 * 1985334694) ^ 0x43881D8);
						continue;
					case 56u:
						array = _206B_200E_206B_200C_202B_202E_200D_200C_202D_200D_202E_200E_200B_200B_206E_202E_200B_202B_206B_202C_206F_200F_200D_200D_200F_206D_200C_206C_202E_202B_202D_200F_200D_202A_200F_202C_206F_202A_200D_202B_202E(current.ArgvsString, new char[1] { ',' });
						num7 = 0;
						num = ((int)num3 * -445764320) ^ -316191591;
						continue;
					case 28u:
					{
						int num11;
						if (num7 < array.Length)
						{
							num = 89444679;
							num11 = num;
						}
						else
						{
							num = 244155228;
							num11 = num;
						}
						continue;
					}
					case 71u:
						num = (int)(num3 * 173886666) ^ -1812309982;
						continue;
					case 9u:
						itemResult.MaxQuanzhang = int.Parse(current.Argvs[0]);
						num = ((int)num3 * -1341436687) ^ 0x4F0A42C9;
						continue;
					case 10u:
					{
						current = enumerator.Current;
						name = current.Name;
						int num9;
						if (!_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(name, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(441766451u)))
						{
							num = 1792010824;
							num9 = num;
						}
						else
						{
							num = 1292862205;
							num9 = num;
						}
						continue;
					}
					case 51u:
						itemResult.Balls = int.Parse(current.Argvs[0]);
						num = (int)(num3 * 1055732640) ^ -1587150067;
						continue;
					case 15u:
						num = ((int)num3 * -1391640424) ^ 0x5457601E;
						continue;
					case 13u:
						array[num7] = _202B_206E_206E_202C_200C_200C_202D_202B_206B_200B_200C_202A_200C_200C_206C_200B_206E_206B_206C_202A_206D_206C_200D_202C_202E_200B_200B_200B_206B_200D_206F_202D_202D_200E_206B_202C_202A_202B_200F_202E(array[num7], 0, num8);
						num = (int)((num3 * 1450086482) ^ 0x610D0F5E);
						continue;
					case 68u:
						itemResult.SwitchGameScene = array[0];
						num = ((int)num3 * -1682009594) ^ 0x1F33788B;
						continue;
					case 40u:
					{
						int num5;
						if (_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(name, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1524847687u)))
						{
							num = 1304902233;
							num5 = num;
						}
						else
						{
							num = 190028144;
							num5 = num;
						}
						continue;
					}
					case 7u:
						itemResult.Buffs.AddRange(Buff.Parse(current.Argvs[0]));
						num = 1766051398;
						continue;
					case 36u:
					{
						int num4;
						if (!_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(name, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4149167762u)))
						{
							num = 1428563574;
							num4 = num;
						}
						else
						{
							num = 146308972;
							num4 = num;
						}
						continue;
					}
					case 39u:
						goto end_IL_0021;
					}
					goto IL_06de;
					continue;
					end_IL_0021:
					break;
				}
				break;
			}
		}
		return itemResult;
	}

	public override bool Equals(object obj)
	{
		if (obj is ItemInstance)
		{
			while (true)
			{
				uint num;
				switch ((num = 755749601u) % 3)
				{
				case 0u:
					continue;
				case 2u:
					return _200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(PK, (obj as ItemInstance).PK);
				}
				break;
			}
		}
		return false;
	}

	public override int GetHashCode()
	{
		int num = 0;
		string pK = PK;
		int num2 = 0;
		while (true)
		{
			int num3 = 1090514616;
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)(num3 ^ 0x13770BF0)) % 6)
				{
				case 3u:
					break;
				case 2u:
				{
					int num5;
					if (num2 < _202A_206C_200F_200F_202C_206B_206D_200B_202D_202A_200B_206D_206C_202A_202C_202E_200F_206F_202C_202D_200F_200F_200E_200B_200F_200B_202B_206C_200B_200C_200E_202C_206C_206C_200E_202B_200C_200C_206B_200D_202E(pK))
					{
						num3 = 329585189;
						num5 = num3;
					}
					else
					{
						num3 = 830114882;
						num5 = num3;
					}
					continue;
				}
				case 1u:
				{
					char c = _202C_200D_200C_200B_200E_206A_200D_200D_202D_200F_200F_206D_206C_200E_200F_202D_202C_206D_206A_200C_206A_202B_202D_202E_200E_206C_200E_206B_200E_200F_206A_202C_202D_202C_206B_206B_202E_202E_206A_206A_202E(pK, num2);
					num += c;
					num3 = 1200977797;
					continue;
				}
				case 4u:
					num3 = ((int)num4 * -1971764366) ^ 0x1F3B8FE;
					continue;
				case 5u:
					num2++;
					num3 = ((int)num4 * -223521445) ^ 0x20EA5C79;
					continue;
				default:
					return num;
				}
				break;
			}
		}
	}

	public static ItemInstance Generate(string name, bool setRandomTriggers = false)
	{
		Item item = Item.GetItem(name);
		while (true)
		{
			int num = -1336357502;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)(num ^ -1288506048)) % 4)
				{
				case 0u:
					break;
				case 2u:
				{
					int num4;
					if (item == null)
					{
						num3 = 118334663;
						num4 = num3;
					}
					else
					{
						num3 = 554069029;
						num4 = num3;
					}
					goto IL_003e;
				}
				case 1u:
					return Generate2(item, setRandomTriggers);
				default:
					return null;
				}
				break;
				IL_003e:
				num = num3 ^ (int)(num2 * 1026835504);
			}
		}
	}

	private List<string> getItemRequireStorys()
	{
		List<string> list = new List<string>();
		using (List<Require>.Enumerator enumerator = Requires.GetEnumerator())
		{
			Require current = default(Require);
			while (true)
			{
				IL_00aa:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 682436872;
					num2 = num;
				}
				else
				{
					num = 911469486;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x74EF89AC)) % 9)
					{
					case 0u:
						num = 911469486;
						continue;
					default:
						goto end_IL_001c;
					case 7u:
						list.Add(current.ArgvsString);
						num = (int)(num3 * 1782688000) ^ -888061317;
						continue;
					case 2u:
						num = ((int)num3 * -2136744450) ^ 0x689AB446;
						continue;
					case 6u:
					{
						int num6;
						if (!_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(current.Name, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(525651667u)))
						{
							num = 1409559572;
							num6 = num;
						}
						else
						{
							num = 1955586302;
							num6 = num;
						}
						continue;
					}
					case 1u:
						break;
					case 3u:
						current = enumerator.Current;
						num = 905010630;
						continue;
					case 4u:
						list.Add(_200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2134166786u), current.ArgvsString));
						num = (int)(num3 * 481395922) ^ -1693286064;
						continue;
					case 5u:
					{
						int num4;
						int num5;
						if (!_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(current.Name, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(451352088u)))
						{
							num4 = 1980080545;
							num5 = num4;
						}
						else
						{
							num4 = 1782464005;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -1781240889);
						continue;
					}
					case 8u:
						goto end_IL_001c;
					}
					goto IL_00aa;
					continue;
					end_IL_001c:
					break;
				}
				break;
			}
		}
		return list;
	}

	private List<string> getItemRequireRoleKeys()
	{
		List<string> list = new List<string>();
		using (List<Require>.Enumerator enumerator = Requires.GetEnumerator())
		{
			Require current = default(Require);
			while (true)
			{
				IL_0108:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -1831895066;
					num2 = num;
				}
				else
				{
					num = -1570543638;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -611553744)) % 8)
					{
					case 4u:
						num = -1831895066;
						continue;
					default:
						goto end_IL_001c;
					case 3u:
					{
						int num6;
						if (_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(current.Name, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2451070577u)))
						{
							num = -1457090787;
							num6 = num;
						}
						else
						{
							num = -713429263;
							num6 = num;
						}
						continue;
					}
					case 0u:
					{
						int num4;
						int num5;
						if (!_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(current.Name, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2413335084u)))
						{
							num4 = 367123611;
							num5 = num4;
						}
						else
						{
							num4 = 1844254047;
							num5 = num4;
						}
						num = num4 ^ (int)(num3 * 1139404119);
						continue;
					}
					case 5u:
						list.Add(_200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(656931348u), current.ArgvsString));
						num = (int)(num3 * 1446681816) ^ -689010935;
						continue;
					case 6u:
						current = enumerator.Current;
						num = -1400536024;
						continue;
					case 7u:
						list.Add(current.ArgvsString);
						num = ((int)num3 * -690067176) ^ 0x32D43359;
						continue;
					case 1u:
						break;
					case 2u:
						goto end_IL_001c;
					}
					goto IL_0108;
					continue;
					end_IL_001c:
					break;
				}
				break;
			}
		}
		return list;
	}

	public Item GetItem()
	{
		return _202E_202C_200B_202E_200B_202A_202B_200F_200B_200C_206E_200C_202A_202B_200C_200E_200F_200D_206A_206F_200D_200E_200D_200E_206B_202C_206D_206B_200E_206F_206B_200C_202C_206A_200B_202B_200F_202B_202B_202E_202E;
	}

	public static ItemInstance Generate2(Item item, bool setRandomTriggers = false)
	{
		return item.Generate(setRandomTriggers);
	}

	public void SetItem(Item item)
	{
		_202E_202C_200B_202E_200B_202A_202B_200F_200B_200C_206E_200C_202A_202B_200C_200E_200F_200D_206A_206F_200D_200E_200D_200E_206B_202C_206D_206B_200E_206F_206B_200C_202C_206A_200B_202B_200F_202B_202B_202E_202E = item;
	}

	private Trigger GenerateRandomTrigger1()
	{
		if (Type != ItemType.Weapon)
		{
			goto IL_000c;
		}
		goto IL_00e0;
		IL_000c:
		int num = -1930495816;
		goto IL_0011;
		IL_0011:
		Dictionary<string, bool> dictionary = default(Dictionary<string, bool>);
		int round = default(int);
		List<ITTrigger> list = default(List<ITTrigger>);
		int num3 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -874526295)) % 10)
			{
			case 0u:
				break;
			case 1u:
			{
				int num6;
				int num7;
				if (Type == ItemType.Armor)
				{
					num6 = 1305488005;
					num7 = num6;
				}
				else
				{
					num6 = 1016908461;
					num7 = num6;
				}
				num = num6 ^ (int)(num2 * 314521457);
				continue;
			}
			case 3u:
			{
				int num4;
				int num5;
				if (Type == ItemType.Accessories)
				{
					num4 = 269826100;
					num5 = num4;
				}
				else
				{
					num4 = 46728333;
					num5 = num4;
				}
				num = num4 ^ (int)(num2 * 382682992);
				continue;
			}
			case 4u:
				return null;
			case 5u:
				dictionary.Add(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(7860661u), haveAdditionTrigger(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1168936690u)));
				num = ((int)num2 * -2082103921) ^ -2034723480;
				continue;
			case 7u:
				goto IL_00e0;
			case 8u:
				round = RuntimeData.Instance.Round;
				list = new List<ITTrigger>();
				num = ((int)num2 * -1721148567) ^ 0x516B8BF5;
				continue;
			case 2u:
				num3 = 0;
				num = ((int)num2 * -999968323) ^ 0x349D474E;
				continue;
			case 6u:
				dictionary.Add(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1581301540u), haveAdditionTrigger(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(94818519u)));
				dictionary.Add(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3282273608u), haveAdditionTrigger(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1016810967u)));
				num = (int)((num2 * 598772203) ^ 0x14D4DB7F);
				continue;
			default:
				goto IL_019c;
			}
			break;
		}
		goto IL_000c;
		IL_019c:
		IEnumerator<ItemTrigger> enumerator = ResourceManager.GetAll<ItemTrigger>().GetEnumerator();
		try
		{
			ITTrigger current2 = default(ITTrigger);
			bool flag = default(bool);
			while (_206D_206C_200E_202D_206D_206B_206B_200B_206F_206F_202B_206F_200D_206D_202D_202E_206A_202E_206B_200C_206A_200F_202E_206D_200D_206F_200B_202C_206E_206F_200B_200F_200B_202C_200E_200C_202E_206E_202B_206A_202E((IEnumerator)enumerator))
			{
				while (true)
				{
					ItemTrigger current = enumerator.Current;
					int num8;
					int num9;
					if (level < current.MinLevel)
					{
						num8 = -691599117;
						num9 = num8;
					}
					else
					{
						num8 = -75605188;
						num9 = num8;
					}
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num8 ^ -874526295)) % 5)
						{
						case 0u:
							num8 = -1978426146;
							continue;
						case 3u:
							break;
						case 4u:
						{
							int num10;
							int num11;
							if (level <= current.MaxLevel)
							{
								num10 = 1458461796;
								num11 = num10;
							}
							else
							{
								num10 = 1008187698;
								num11 = num10;
							}
							num8 = num10 ^ (int)(num2 * 1353376637);
							continue;
						}
						case 1u:
							goto IL_022a;
						default:
							goto IL_024b;
						}
						break;
						IL_024b:
						using (List<ITTrigger>.Enumerator enumerator2 = current.Triggers.GetEnumerator())
						{
							while (true)
							{
								IL_037e:
								int num12;
								int num13;
								if (!enumerator2.MoveNext())
								{
									num12 = -1882093330;
									num13 = num12;
								}
								else
								{
									num12 = -1737874276;
									num13 = num12;
								}
								while (true)
								{
									switch ((num2 = (uint)(num12 ^ -874526295)) % 11)
									{
									case 4u:
										num12 = -1737874276;
										continue;
									default:
										goto end_IL_0263;
									case 10u:
										num3 += current2.Weight;
										list.Add(current2);
										num12 = (int)((num2 * 618905335) ^ 0x5684A73F);
										continue;
									case 8u:
									{
										int num15;
										int num16;
										if (round >= current2.Round)
										{
											num15 = 649315303;
											num16 = num15;
										}
										else
										{
											num15 = 354804841;
											num16 = num15;
										}
										num12 = num15 ^ (int)(num2 * 853767331);
										continue;
									}
									case 5u:
									{
										int num19;
										int num20;
										if (dictionary.ContainsKey(current2.Name))
										{
											num19 = -258740152;
											num20 = num19;
										}
										else
										{
											num19 = -1115222649;
											num20 = num19;
										}
										num12 = num19 ^ ((int)num2 * -962442433);
										continue;
									}
									case 9u:
										flag = false;
										num12 = -617605064;
										continue;
									case 2u:
									{
										int num21;
										int num22;
										if (dictionary[current2.Name])
										{
											num21 = 1117113887;
											num22 = num21;
										}
										else
										{
											num21 = 1487691984;
											num22 = num21;
										}
										num12 = num21 ^ ((int)num2 * -1251368500);
										continue;
									}
									case 7u:
									{
										int num17;
										int num18;
										if (!_202D_202A_206F_206C_206D_206A_206A_206C_202D_200B_200C_206E_206A_200F_202E_202E_206D_202C_206C_206F_206B_202D_206A_206B_200E_206D_200C_202D_202C_202D_206A_206D_200B_200B_206F_206F_200F_200F_206F_202B_202E(current2.Name))
										{
											num17 = 1785570559;
											num18 = num17;
										}
										else
										{
											num17 = 533122592;
											num18 = num17;
										}
										num12 = num17 ^ (int)(num2 * 1381678409);
										continue;
									}
									case 1u:
										break;
									case 3u:
										current2 = enumerator2.Current;
										flag = true;
										num12 = -597627722;
										continue;
									case 0u:
									{
										int num14;
										if (flag)
										{
											num12 = -515470913;
											num14 = num12;
										}
										else
										{
											num12 = -1522916757;
											num14 = num12;
										}
										continue;
									}
									case 6u:
										goto end_IL_0263;
									}
									goto IL_037e;
									continue;
									end_IL_0263:
									break;
								}
								break;
							}
						}
						goto end_IL_01d8;
						IL_022a:
						if (!_202A_202E_206A_206B_200F_200D_200E_206B_200C_202D_202A_202B_200B_202D_206E_206F_200E_200F_202B_206D_202A_206B_202A_206C_200E_206E_206E_206C_202E_200B_206A_200D_206E_200F_206D_202B_200B_202A_206C_200C_202E(Name, current.Name))
						{
							goto end_IL_01d8;
						}
						num8 = -1136726619;
					}
					continue;
					end_IL_01d8:
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
					IL_03eb:
					int num23 = -196283784;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num23 ^ -874526295)) % 3)
						{
						case 0u:
							break;
						default:
							goto end_IL_03f0;
						case 1u:
							goto IL_040e;
						case 2u:
							goto end_IL_03f0;
						}
						goto IL_03eb;
						IL_040e:
						_206C_200F_206A_202B_206E_206A_202B_206B_200D_206B_200C_202A_202E_206A_200E_206B_202C_200B_206F_206D_202A_200E_200D_206A_202D_206D_202A_202B_200B_200F_206B_206E_202C_206A_206F_202E_202A_202E_206D_200D_202E((IDisposable)enumerator);
						num23 = ((int)num2 * -972938294) ^ -1841841458;
						continue;
						end_IL_03f0:
						break;
					}
					break;
				}
			}
		}
		if (list.Count == 0)
		{
			goto IL_042e;
		}
		goto IL_046b;
		IL_00e0:
		dictionary = new Dictionary<string, bool>();
		dictionary.Add(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(291629272u), haveAdditionTrigger(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3739154093u)));
		num = -1633909738;
		goto IL_0011;
		IL_042e:
		int num24 = -1980689662;
		goto IL_0433;
		IL_046b:
		double num25 = 1.0 / (double)list.Count * 0.1;
		int num26 = 0;
		num24 = -1936627393;
		goto IL_0433;
		IL_0433:
		Trigger trigger = default(Trigger);
		ITTrigger current3 = default(ITTrigger);
		bool flag2 = default(bool);
		while (true)
		{
			List<ITTrigger> list2;
			int num31;
			int num32;
			uint num2;
			switch ((num2 = (uint)(num24 ^ -874526295)) % 5)
			{
			case 0u:
				break;
			case 1u:
				return null;
			case 2u:
				goto IL_046b;
			case 4u:
				trigger = null;
				num24 = -606863714;
				continue;
			default:
				{
					list2 = new List<ITTrigger>();
					using (List<ITTrigger>.Enumerator enumerator2 = list.GetEnumerator())
					{
						while (true)
						{
							IL_04dc:
							int num27;
							int num28;
							if (enumerator2.MoveNext())
							{
								num27 = -943852460;
								num28 = num27;
							}
							else
							{
								num27 = -1662819097;
								num28 = num27;
							}
							while (true)
							{
								switch ((num2 = (uint)(num27 ^ -874526295)) % 6)
								{
								case 3u:
									num27 = -943852460;
									continue;
								default:
									goto end_IL_04b2;
								case 4u:
									break;
								case 0u:
								{
									int num29;
									int num30;
									if (!Tools.ProbabilityTest(_200C_206D_200B_202D_200C_206E_206C_206F_200E_202B_206A_206B_200E_206C_202A_200D_200B_202A_206A_206F_206E_206D_200B_206C_206D_200B_206A_202C_202B_202A_202D_202A_202A_206B_206F_206E_200F_202D_202A_206C_202E((double)current3.Weight / (double)num3, num25)))
									{
										num29 = 393003329;
										num30 = num29;
									}
									else
									{
										num29 = 1236229896;
										num30 = num29;
									}
									num27 = num29 ^ ((int)num2 * -22033743);
									continue;
								}
								case 1u:
									current3 = enumerator2.Current;
									num27 = -1303878087;
									continue;
								case 5u:
									list2.Add(current3);
									num27 = (int)((num2 * 1583464797) ^ 0x1633051C);
									continue;
								case 2u:
									goto end_IL_04b2;
								}
								goto IL_04dc;
								continue;
								end_IL_04b2:
								break;
							}
							break;
						}
					}
					if (list2.Count > 0)
					{
						goto IL_0572;
					}
					goto IL_05e7;
				}
				IL_06c9:
				return trigger;
				IL_05e7:
				if (trigger != null)
				{
					num31 = -1572187937;
					goto IL_0577;
				}
				goto IL_0680;
				IL_0655:
				num32 = -769411076;
				goto IL_065a;
				IL_0577:
				while (true)
				{
					switch ((num2 = (uint)(num31 ^ -874526295)) % 6)
					{
					case 3u:
						break;
					case 5u:
						trigger = list2[Tools.GetRandomInt(0, list2.Count - 1)].GenerateItemTrigger(level);
						num31 = ((int)num2 * -568676659) ^ 0x8474899;
						continue;
					case 2u:
						flag2 = true;
						num31 = (int)(num2 * 2144635435) ^ -1093763177;
						continue;
					case 1u:
						goto IL_05e7;
					case 0u:
						goto IL_05f5;
					default:
						goto IL_0616;
					}
					break;
					IL_05f5:
					if (!_202D_202A_206F_206C_206D_206A_206A_206C_202D_200B_200C_206E_206A_200F_202E_202E_206D_202C_206C_206F_206B_202D_206A_206B_200E_206D_200C_202D_202C_202D_206A_206D_200B_200B_206F_206F_200F_200F_206F_202B_202E(trigger.ArgvsString))
					{
						num31 = ((int)num2 * -855479716) ^ 0x16E6B807;
						continue;
					}
					goto IL_0680;
				}
				goto IL_0572;
				IL_0616:
				if (flag2)
				{
					try
					{
						flag2 = LuaManager.Call<bool>(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2004810599u), new object[2] { this, trigger });
					}
					catch
					{
						_206F_200D_202E_206F_202E_206B_200E_206E_206C_200C_202B_206D_202A_202A_202A_200F_200E_200E_206A_206B_202A_206B_200C_202A_200C_206D_206F_200E_202C_206F_206B_206E_206E_200F_206C_206F_206D_202B_206E_206E_202E((object)global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3926553244u));
						flag2 = false;
					}
				}
				if (!flag2)
				{
					goto IL_0655;
				}
				goto IL_06c9;
				IL_0572:
				num31 = -698141820;
				goto IL_0577;
				IL_0680:
				num26++;
				num32 = -824275478;
				goto IL_065a;
				IL_065a:
				while (true)
				{
					switch ((num2 = (uint)(num32 ^ -874526295)) % 5)
					{
					case 0u:
						break;
					case 3u:
						goto IL_0680;
					case 1u:
						goto IL_068d;
					case 2u:
						goto IL_06a6;
					default:
						goto IL_06c9;
					}
					break;
					IL_06a6:
					if (Tools.ProbabilityTest(0.05))
					{
						num32 = ((int)num2 * -1886323914) ^ 0x3D3731A2;
						continue;
					}
					goto case 4u;
					IL_068d:
					if (num26 >= 100)
					{
						num32 = (int)(num2 * 1723956092) ^ -250764925;
						continue;
					}
					goto case 4u;
				}
				goto IL_0655;
			}
			break;
		}
		goto IL_042e;
	}

	private List<int> getItemRequireRoleLevel()
	{
		List<int> list = new List<int>();
		using (List<Require>.Enumerator enumerator = Requires.GetEnumerator())
		{
			Require current = default(Require);
			while (true)
			{
				IL_00a0:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 449693358;
					num2 = num;
				}
				else
				{
					num = 1340193788;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x5DFE51B)) % 8)
					{
					case 0u:
						num = 449693358;
						continue;
					default:
						goto end_IL_001c;
					case 4u:
					{
						int num5;
						if (_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(current.Name, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2438178312u)))
						{
							num = 1505551930;
							num5 = num;
						}
						else
						{
							num = 487809072;
							num5 = num;
						}
						continue;
					}
					case 6u:
						list.Add(_206F_206B_206F_200F_202C_202C_200B_202C_206D_202B_206A_206E_200B_206E_200E_206D_202D_202E_202B_200F_200E_200F_200C_202A_200D_200B_200D_206E_200E_202E_202D_202A_202E_206F_202A_200E_206B_202B_206F_200F_202E(int.Parse(current.ArgvsString)));
						num = ((int)num3 * -1268954767) ^ -1495698545;
						continue;
					case 3u:
						break;
					case 1u:
						list.Add(-_206A_200D_200D_202D_202C_206E_206A_200E_200F_202A_206A_200D_206C_202B_206D_206F_202E_202A_200D_200C_200E_202C_202C_200F_202B_200C_202A_200F_206D_206A_206F_200E_206E_200D_200E_200C_206B_206B_206D_200E_202E(1, int.Parse(current.ArgvsString)));
						num = (int)((num3 * 2084733845) ^ 0x27AFD505);
						continue;
					case 5u:
					{
						current = enumerator.Current;
						int num4;
						if (_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(current.Name, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1254515770u)))
						{
							num = 497574629;
							num4 = num;
						}
						else
						{
							num = 331304919;
							num4 = num;
						}
						continue;
					}
					case 2u:
						num = ((int)num3 * -277395952) ^ -1747413872;
						continue;
					case 7u:
						goto end_IL_001c;
					}
					goto IL_00a0;
					continue;
					end_IL_001c:
					break;
				}
				break;
			}
		}
		return list;
	}

	public string GetBuffsString()
	{
		string text = null;
		IEnumerator<Buff> enumerator = Buffs.GetEnumerator();
		try
		{
			Buff current = default(Buff);
			while (true)
			{
				IL_013e:
				int num;
				int num2;
				if (_206D_206C_200E_202D_206D_206B_206B_200B_206F_206F_202B_206F_200D_206D_202D_202E_206A_202E_206B_200C_206A_200F_202E_206D_200D_206F_200B_202C_206E_206F_200B_200F_200B_202C_200E_200C_202E_206E_202B_206A_202E((IEnumerator)enumerator))
				{
					num = -790870596;
					num2 = num;
				}
				else
				{
					num = -2118851314;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -1291395623)) % 18)
					{
					case 15u:
						num = -790870596;
						continue;
					default:
						goto end_IL_0018;
					case 4u:
						num = (int)(num3 * 1598276884) ^ -724467031;
						continue;
					case 1u:
						text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, _206C_202C_200B_206A_202D_206A_200D_200D_206E_200D_206A_200B_202A_200C_206C_200E_202D_206F_200F_206B_200C_206C_206E_200F_202C_200B_206C_202E_206D_200F_206F_206B_200B_206B_200C_206F_202E_206B_202E_202C_202E(ResourceStrings.ResStrings[566], (object)current.Name, (object)current.Level));
						num = (int)((num3 * 128557167) ^ 0x58D9D5DD);
						continue;
					case 5u:
						text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, _206C_206A_202B_202E_206A_202B_206F_200B_202C_200E_202C_206D_202D_206A_202A_202E_200B_202E_200F_206B_200C_206B_200D_200C_202C_206A_200F_200D_202A_206A_202E_206C_206E_200F_200E_202A_200F_206D_206C_202E_202E(ResourceStrings.ResStrings[567], (object)current.Round));
						num = ((int)num3 * -258213466) ^ -23358430;
						continue;
					case 3u:
						current = enumerator.Current;
						num = -1736962782;
						continue;
					case 14u:
						text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, _200B_206F_202E_206F_200C_206A_206D_206E_206B_200C_206A_206C_206C_206B_200D_200D_206F_202B_200F_202C_206E_200C_202B_200B_202D_206D_202A_206D_200F_206A_206A_200D_202B_200C_202A_202A_200F_206F_202E_202B_202E(ResourceStrings.ResStrings[568], new object[0]));
						num = ((int)num3 * -1157460403) ^ -1133810313;
						continue;
					case 8u:
						break;
					case 10u:
						text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, _200B_206F_202E_206F_200C_206A_206D_206E_206B_200C_206A_206C_206C_206B_200D_200D_206F_202B_200F_202C_206E_200C_202B_200B_202D_206D_202A_206D_200F_206A_206A_200D_202B_200C_202A_202A_200F_206F_202E_202B_202E(ResourceStrings.ResStrings[571], new object[0]));
						num = -727102831;
						continue;
					case 13u:
					{
						int num8;
						if (current.Property < 0)
						{
							num = -460415687;
							num8 = num;
						}
						else
						{
							num = -1447040461;
							num8 = num;
						}
						continue;
					}
					case 11u:
					{
						int num7;
						if (current.Property != 100)
						{
							num = -798613208;
							num7 = num;
						}
						else
						{
							num = -504951923;
							num7 = num;
						}
						continue;
					}
					case 0u:
						num = ((int)num3 * -1049261054) ^ -1179108027;
						continue;
					case 6u:
						text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(925971650u));
						num = -1944828177;
						continue;
					case 9u:
					{
						int num5;
						int num6;
						if (current.Round <= 0)
						{
							num5 = 51333520;
							num6 = num5;
						}
						else
						{
							num5 = 790253354;
							num6 = num5;
						}
						num = num5 ^ (int)(num3 * 1464784096);
						continue;
					}
					case 12u:
						text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, _200B_206F_202E_206F_200C_206A_206D_206E_206B_200C_206A_206C_206C_206B_200D_200D_206F_202B_200F_202C_206E_200C_202B_200B_202D_206D_202A_206D_200F_206A_206A_200D_202B_200C_202A_202A_200F_206F_202E_202B_202E(ResourceStrings.ResStrings[570], new object[0]));
						num = (int)(num3 * 1741062033) ^ -807849776;
						continue;
					case 2u:
						text = _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(text, _206C_206A_202B_202E_206A_202B_206F_200B_202C_200E_202C_206D_202D_206A_202A_202E_200B_202E_200F_206B_200C_206B_200D_200C_202C_206A_200F_200D_202A_206A_202E_206C_206E_200F_200E_202A_200F_206D_206C_202E_202E(ResourceStrings.ResStrings[569], (object)current.Property));
						num = (int)((num3 * 1618283775) ^ 0xF125879);
						continue;
					case 17u:
						num = ((int)num3 * -2041773679) ^ -1620524382;
						continue;
					case 16u:
					{
						int num4;
						if (current.Property == -1)
						{
							num = -1464676045;
							num4 = num;
						}
						else
						{
							num = -2108578375;
							num4 = num;
						}
						continue;
					}
					case 7u:
						goto end_IL_0018;
					}
					goto IL_013e;
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
					IL_02b1:
					int num9 = -429105118;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num9 ^ -1291395623)) % 3)
						{
						case 2u:
							break;
						default:
							goto end_IL_02b6;
						case 1u:
							goto IL_02d3;
						case 0u:
							goto end_IL_02b6;
						}
						goto IL_02b1;
						IL_02d3:
						_206C_200F_206A_202B_206E_206A_202B_206B_200D_206B_200C_202A_202E_206A_200E_206B_202C_200B_206F_206D_202A_200E_200D_206A_202D_206D_202A_202B_200B_200F_206B_206E_202C_206A_206F_202E_202A_202E_206D_200D_202E((IDisposable)enumerator);
						num9 = (int)(num3 * 2057717681) ^ -1175113401;
						continue;
						end_IL_02b6:
						break;
					}
					break;
				}
			}
		}
		return text;
	}

	private List<string> getItemRequireItems()
	{
		List<string> list = new List<string>();
		using (List<Require>.Enumerator enumerator = Requires.GetEnumerator())
		{
			Require current = default(Require);
			while (true)
			{
				IL_00d8:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 718637230;
					num2 = num;
				}
				else
				{
					num = 1786315933;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x2AAA179F)) % 8)
					{
					case 4u:
						num = 1786315933;
						continue;
					default:
						goto end_IL_001c;
					case 2u:
						current = enumerator.Current;
						num = 668804024;
						continue;
					case 6u:
						list.Add(current.ArgvsString);
						num = ((int)num3 * -256393360) ^ 0x419EE26A;
						continue;
					case 3u:
					{
						int num6;
						if (_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(current.Name, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1303105011u)))
						{
							num = 1615580783;
							num6 = num;
						}
						else
						{
							num = 189145674;
							num6 = num;
						}
						continue;
					}
					case 7u:
					{
						int num4;
						int num5;
						if (_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(current.Name, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(206470463u)))
						{
							num4 = -528173923;
							num5 = num4;
						}
						else
						{
							num4 = -1857604760;
							num5 = num4;
						}
						num = num4 ^ (int)(num3 * 972331668);
						continue;
					}
					case 5u:
						break;
					case 0u:
						list.Add(_200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2134166786u), current.ArgvsString));
						num = ((int)num3 * -2125174295) ^ 0x37F4E93A;
						continue;
					case 1u:
						goto end_IL_001c;
					}
					goto IL_00d8;
					continue;
					end_IL_001c:
					break;
				}
				break;
			}
		}
		return list;
	}

	public static string GetItemTypeStr(ItemType type)
	{
		switch (type)
		{
		default:
			while (true)
			{
				int num = 950929146;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x15207C03)) % 18)
					{
					case 2u:
						break;
					case 6u:
						goto end_IL_0042;
					case 14u:
						goto IL_00bb;
					case 4u:
						goto IL_00d5;
					case 17u:
						goto IL_00ef;
					case 3u:
						num = (int)((num2 * 1888784520) ^ 0x4ED23547);
						continue;
					case 11u:
						goto IL_011b;
					case 7u:
						goto IL_0135;
					case 16u:
						goto IL_014f;
					case 13u:
						goto IL_0169;
					case 12u:
						goto IL_0183;
					case 5u:
						goto IL_019d;
					case 9u:
						goto IL_01b7;
					case 15u:
						goto IL_01d1;
					case 8u:
						goto IL_01eb;
					case 1u:
						goto IL_0205;
					case 0u:
						goto end_IL_0001;
					default:
						return ResourceStrings.ResStrings[1076];
					}
					break;
				}
				continue;
				end_IL_0042:
				break;
			}
			goto case ItemType.SpeicalSkillBook;
		case ItemType.SpeicalSkillBook:
			return ResourceStrings.ResStrings[412];
		case ItemType.Special:
			goto IL_00bb;
		case ItemType.SwitchGameScene:
			goto IL_00d5;
		case ItemType.TalentBook:
			goto IL_00ef;
		case ItemType.Canzhang:
			goto IL_011b;
		case ItemType.Armor:
			goto IL_0135;
		case ItemType.Accessories:
			goto IL_014f;
		case ItemType.Mission:
			goto IL_0169;
		case ItemType.Book2:
			goto IL_0183;
		case ItemType.Upgrade:
			goto IL_019d;
		case ItemType.Costa:
			goto IL_01b7;
		case ItemType.HiddenWeapon:
			goto IL_01d1;
		case ItemType.SwitchGameScene2:
			goto IL_01eb;
		case ItemType.Weapon:
			goto IL_0205;
		case ItemType.Book:
			break;
			IL_0205:
			return ResourceStrings.ResStrings[407];
			IL_01eb:
			return ResourceStrings.ResStrings[419];
			IL_01d1:
			return ResourceStrings.ResStrings[743];
			IL_01b7:
			return ResourceStrings.ResStrings[406];
			IL_019d:
			return ResourceStrings.ResStrings[414];
			IL_0183:
			return ResourceStrings.ResStrings[418];
			IL_0169:
			return ResourceStrings.ResStrings[411];
			IL_014f:
			return ResourceStrings.ResStrings[409];
			IL_0135:
			return ResourceStrings.ResStrings[408];
			IL_011b:
			return ResourceStrings.ResStrings[416];
			IL_00ef:
			return ResourceStrings.ResStrings[413];
			IL_00d5:
			return ResourceStrings.ResStrings[417];
			IL_00bb:
			return ResourceStrings.ResStrings[415];
			end_IL_0001:
			break;
		}
		return ResourceStrings.ResStrings[410];
	}

	private bool haveAdditionTrigger(string name)
	{
		using (List<Trigger>.Enumerator enumerator = AdditionTriggers.GetEnumerator())
		{
			bool result = default(bool);
			while (true)
			{
				IL_0072:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -1897887715;
					num2 = num;
				}
				else
				{
					num = -1606850;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -100541813)) % 6)
					{
					case 3u:
						num = -1606850;
						continue;
					default:
						goto end_IL_0013;
					case 1u:
					{
						int num4;
						if (!_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(enumerator.Current.Name, name))
						{
							num = -1206212747;
							num4 = num;
						}
						else
						{
							num = -606305915;
							num4 = num;
						}
						continue;
					}
					case 4u:
						break;
					case 2u:
						result = true;
						num = ((int)num3 * -1189733220) ^ 0x1171072A;
						continue;
					case 0u:
						goto end_IL_0013;
					case 5u:
						return result;
					}
					goto IL_0072;
					continue;
					end_IL_0013:
					break;
				}
				break;
			}
		}
		return false;
	}

	private int getAdditionTrigger(string name)
	{
		int num = 0;
		using (List<Trigger>.Enumerator enumerator = AdditionTriggers.GetEnumerator())
		{
			while (true)
			{
				IL_005f:
				int num2;
				int num3;
				if (!enumerator.MoveNext())
				{
					num2 = -1149518654;
					num3 = num2;
				}
				else
				{
					num2 = -1699874513;
					num3 = num2;
				}
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)(num2 ^ -1004294615)) % 5)
					{
					case 0u:
						num2 = -1699874513;
						continue;
					default:
						goto end_IL_0015;
					case 4u:
					{
						int num5;
						if (!_200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(enumerator.Current.Name, name))
						{
							num2 = -335725575;
							num5 = num2;
						}
						else
						{
							num2 = -1717315169;
							num5 = num2;
						}
						continue;
					}
					case 1u:
						break;
					case 2u:
						num++;
						num2 = (int)((num4 * 800262699) ^ 0x3C7E0C6B);
						continue;
					case 3u:
						goto end_IL_0015;
					}
					goto IL_005f;
					continue;
					end_IL_0015:
					break;
				}
				break;
			}
		}
		return num;
	}

	static string[] _206E_202A_206A_202D_206A_206A_206E_206A_202A_206E_206A_206C_200D_206D_200C_200F_200B_202B_202A_202B_200B_200D_202E_200E_206D_202D_206A_200E_200B_202C_200E_202A_202D_206B_200B_200E_200D_206D_200C_202D_202E(string P_0, char[] P_1, StringSplitOptions P_2)
	{
		return P_0.Split(P_1, P_2);
	}

	static string _206C_206A_202B_202E_206A_202B_206F_200B_202C_200E_202C_206D_202D_206A_202A_202E_200B_202E_200F_206B_200C_206B_200D_200C_202C_206A_200F_200D_202A_206A_202E_206C_206E_200F_200E_202A_200F_206D_206C_202E_202E(string P_0, object P_1)
	{
		return string.Format(P_0, P_1);
	}

	static string[] _206B_200E_206B_200C_202B_202E_200D_200C_202D_200D_202E_200E_200B_200B_206E_202E_200B_202B_206B_202C_206F_200F_200D_200D_200F_206D_200C_206C_202E_202B_202D_200F_200D_202A_200F_202C_206F_202A_200D_202B_202E(string P_0, char[] P_1)
	{
		return P_0.Split(P_1);
	}

	static bool _202A_202E_206A_206B_200F_200D_200E_206B_200C_202D_202A_202B_200B_202D_206E_206F_200E_200F_202B_206D_202A_206B_202A_206C_200E_206E_206E_206C_202E_200B_206A_200D_206E_200F_206D_202B_200B_202A_206C_200C_202E(string P_0, string P_1)
	{
		return P_0.Equals(P_1);
	}

	static bool _200C_202B_206C_206F_200D_206C_206E_200E_202A_200C_206A_202D_206A_206D_202B_200D_206E_200E_206F_200D_206C_200D_202C_206F_206D_202C_200F_206D_200C_206D_200B_206A_206A_206A_202A_200E_202A_202A_206C_202A_202E(string P_0, string P_1)
	{
		return P_0 == P_1;
	}

	static bool _202D_202A_206F_206C_206D_206A_206A_206C_202D_200B_200C_206E_206A_200F_202E_202E_206D_202C_206C_206F_206B_202D_206A_206B_200E_206D_200C_202D_202C_202D_206A_206D_200B_200B_206F_206F_200F_200F_206F_202B_202E(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}

	static bool _206D_206C_200E_202D_206D_206B_206B_200B_206F_206F_202B_206F_200D_206D_202D_202E_206A_202E_206B_200C_206A_200F_202E_206D_200D_206F_200B_202C_206E_206F_200B_200F_200B_202C_200E_200C_202E_206E_202B_206A_202E(IEnumerator P_0)
	{
		return P_0.MoveNext();
	}

	static void _206C_200F_206A_202B_206E_206A_202B_206B_200D_206B_200C_202A_202E_206A_200E_206B_202C_200B_206F_206D_202A_200E_200D_206A_202D_206D_202A_202B_200B_200F_206B_206E_202C_206A_206F_202E_202A_202E_206D_200D_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}

	static double _200C_206D_200B_202D_200C_206E_206C_206F_200E_202B_206A_206B_200E_206C_202A_200D_200B_202A_206A_206F_206E_206D_200B_206C_206D_200B_206A_202C_202B_202A_202D_202A_202A_206B_206F_206E_200F_202D_202A_206C_202E(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	static bool _202D_206C_202A_206A_200F_202E_200F_202B_206D_206C_206D_202B_200D_200F_202C_202D_206B_206B_202B_206B_200B_206F_200D_202D_206D_200F_202A_200E_206A_200D_202A_200C_200E_206B_200D_206A_200E_200E_200F_206E_202E(string P_0, string P_1)
	{
		return P_0.StartsWith(P_1);
	}

	static int _202A_206C_200F_200F_202C_206B_206D_200B_202D_202A_200B_206D_206C_202A_202C_202E_200F_206F_202C_202D_200F_200F_200E_200B_200F_200B_202B_206C_200B_200C_200E_202C_206C_206C_200E_202B_200C_200C_206B_200D_202E(string P_0)
	{
		return P_0.Length;
	}

	static string _202B_206E_206E_202C_200C_200C_202D_202B_206B_200B_200C_202A_200C_200C_206C_200B_206E_206B_206C_202A_206D_206C_200D_202C_202E_200B_200B_200B_206B_200D_206F_202D_202D_200E_206B_202C_202A_202B_200F_202E(string P_0, int P_1, int P_2)
	{
		return P_0.Substring(P_1, P_2);
	}

	static string _200D_200D_202D_202A_206C_202B_206C_206E_200D_206A_206E_202C_200C_202B_206A_206D_202C_200F_200F_202A_202B_206F_200F_202E_202E_200D_200E_200D_200F_200E_206C_206B_202D_206B_206A_200C_206C_206D_202A_202A_202E(string P_0, string P_1)
	{
		return P_0 + P_1;
	}

	static int _206A_200D_200D_202D_202C_206E_206A_200E_200F_202A_206A_200D_206C_202B_206D_206F_202E_202A_200D_200C_200E_202C_202C_200F_202B_200C_202A_200F_206D_206A_206F_200E_206E_200D_200E_200C_206B_206B_206D_200E_202E(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	static string _206C_202C_200B_206A_202D_206A_200D_200D_206E_200D_206A_200B_202A_200C_206C_200E_202D_206F_200F_206B_200C_206C_206E_200F_202C_200B_206C_202E_206D_200F_206F_206B_200B_206B_200C_206F_202E_206B_202E_202C_202E(string P_0, object P_1, object P_2)
	{
		return string.Format(P_0, P_1, P_2);
	}

	static bool _206C_206E_202C_206C_200C_206C_202E_202C_206D_202C_206C_200B_200D_200C_200B_202C_200E_200B_200B_200F_202B_202A_202B_202C_202C_202A_200C_202A_202C_206E_200C_202C_202E_200D_200E_202B_202C_200C_206C_202E_202E(string P_0, string P_1)
	{
		return P_0 != P_1;
	}

	static string _206E_206B_202D_200F_200E_200E_206C_200C_206E_206A_202B_200E_206B_202A_200F_206F_206B_200D_206A_206D_200B_206C_202A_206B_202E_202B_202D_202B_206B_200D_202C_206F_200F_206A_206A_206C_200D_200D_200C_202C_202E(string P_0, char[] P_1)
	{
		return P_0.TrimEnd(P_1);
	}

	static string _202D_202B_206C_200E_206A_202A_200F_200E_206F_200F_202A_200C_206D_206C_202B_200C_200C_200F_206F_206D_202C_206A_200D_202C_206D_200D_200B_200E_202D_200E_206E_202B_200D_200E_202A_202B_200F_206B_206E_200E_202E(string P_0, string P_1, string P_2)
	{
		return P_0 + P_1 + P_2;
	}

	static string _200B_206F_202E_206F_200C_206A_206D_206E_206B_200C_206A_206C_206C_206B_200D_200D_206F_202B_200F_202C_206E_200C_202B_200B_202D_206D_202A_206D_200F_206A_206A_200D_202B_200C_202A_202A_200F_206F_202E_202B_202E(string P_0, object[] P_1)
	{
		return string.Format(P_0, P_1);
	}

	static string _202E_206C_200B_206B_206D_202A_206F_202E_202C_206A_206E_206E_206A_200E_200B_200F_202B_202B_200C_202B_202D_200F_202E_206E_200D_206D_206F_206A_202E_202B_200B_206E_206C_200E_202A_206C_200B_206D_202B_202C_202E(string[] P_0)
	{
		return string.Concat(P_0);
	}

	static int _202E_206C_206B_200E_202D_200D_200C_200B_206A_202B_200F_200D_206C_206D_202E_206D_200C_200C_200C_206A_206E_200E_200F_200C_200F_202A_206B_200F_200F_206B_202B_202C_206A_206A_200B_202B_202B_202E_202C_200F_202E(string P_0, char P_1)
	{
		return P_0.IndexOf(P_1);
	}

	static string _202E_206D_206E_206E_202D_206F_206B_200E_206F_206A_202D_200F_202E_206F_206C_200E_202C_202C_200C_200F_206E_202B_202C_202A_200C_202C_202D_200B_200F_206D_206C_206F_200E_200D_200E_202A_202E_202E_200F_202E(string P_0, object P_1, object P_2, object P_3)
	{
		return string.Format(P_0, P_1, P_2, P_3);
	}

	static bool _200C_206D_206A_200C_206A_202E_206F_202D_200B_202C_202B_202D_200C_206B_206D_206E_206C_202D_200F_202B_200C_200B_206D_202D_206C_202D_200C_200B_200D_206F_202E_200C_200C_202E_202A_206E_202B_202C_202B_200F_202E(string P_0, string P_1)
	{
		return P_0.Contains(P_1);
	}

	static string _206C_206F_206F_200D_202E_202D_200F_206D_202E_202B_202A_202D_206D_206A_206B_202E_202A_200B_206D_202C_206C_202C_202B_202B_202C_206F_206F_202B_200C_200F_202A_200F_206E_202D_206F_202B_200D_206B_200C_206A_202E(string P_0, string P_1, string P_2)
	{
		return P_0.Replace(P_1, P_2);
	}

	static bool _200F_202D_200D_202C_206F_206D_206A_202B_206F_206B_206A_206D_200B_206F_206A_200D_202C_202E_200F_206F_206B_202C_202D_206F_200B_206F_200C_206D_202C_200D_200B_202C_206B_206D_206E_200F_200B_200B_206B_202E(string P_0, string P_1)
	{
		return P_0.EndsWith(P_1);
	}

	static char _202C_200D_200C_200B_200E_206A_200D_200D_202D_200F_200F_206D_206C_200E_200F_202D_202C_206D_206A_200C_206A_202B_202D_202E_200E_206C_200E_206B_200E_200F_206A_202C_202D_202C_206B_206B_202E_202E_206A_206A_202E(string P_0, int P_1)
	{
		return P_0[P_1];
	}

	static void _206F_200D_202E_206F_202E_206B_200E_206E_206C_200C_202B_206D_202A_202A_202A_200F_200E_200E_206A_206B_202A_206B_200C_202A_200C_206D_206F_200E_202C_206F_206B_206E_206E_200F_206C_206F_206D_202B_206E_206E_202E(object P_0)
	{
		Debug.LogError(P_0);
	}

	static int _206F_206B_206F_200F_202C_202C_200B_202C_206D_202B_206A_206E_200B_206E_200E_206D_202D_202E_202B_200F_200E_200F_200C_202A_200D_200B_200D_206E_200E_202E_202D_202A_202E_206F_202A_200E_206B_202B_206F_200F_202E(int P_0)
	{
		return Math.Abs(P_0);
	}
}
