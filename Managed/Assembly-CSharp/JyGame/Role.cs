using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml.Serialization;
using UnityEngine;

namespace JyGame;

[XmlType("role")]
public class Role : BasePojo
{
	[CompilerGenerated]
	private sealed class _206F_202A_200C_202C_206E_206C_202D_200C_206B_206E_200D_206D_206C_206E_206C_206F_206F_206C_206C_200D_206B_206E_200E_202C_200E_200C_200B_200E_200C_206E_202D_200E_200B_206A_200C_206C_202C_202D_202C_206E_202E : IEnumerable<string>, IEnumerator<string>, IEnumerator, IDisposable, IEnumerable
	{
		internal List<string> _200C_206E_206C_206D_206F_202D_206C_200F_206F_202A_200C_206E_206E_206D_200D_202D_200D_200B_206B_202A_206B_202D_206B_206A_206C_200E_206B_206A_202E_200D_202B_200F_202A_200F_202C_206C_202A_206D_200F_206D_202E;

		internal IEnumerator<Trigger> _206B_202A_206D_202C_200E_206B_206F_200D_206F_200C_206E_206F_206F_200E_200C_202B_206A_202A_200C_202E_202A_206D_202B_206A_206B_206B_200C_206C_202D_200C_202C_202A_202C_202D_206F_202A_202B_200F_200F_200C_202E;

		internal Trigger _202E_202C_206F_200B_200F_202E_200F_200C_206B_200E_206C_202D_206E_200E_206C_200B_202A_200C_206B_206A_206D_206A_200B_200B_202C_202C_206C_202A_200F_200F_200E_202A_202B_202D_206C_206D_202B_200B_202A_202D_202E;

		internal string _206C_202B_202B_206B_202D_200D_202A_206A_206F_200C_206C_200C_200E_206A_206F_200B_200D_202D_202B_202D_202B_206F_202B_206B_202A_202C_206D_200B_200E_200D_200F_200F_202C_200D_202A_206A_206B_206E_202C_202B_202E;

		internal List<ItemInstance>.Enumerator _206D_202D_202E_200C_202A_206F_200D_200B_200F_206E_202E_206C_202C_206B_200B_202E_202D_206D_206B_206A_202C_206A_200D_200B_206A_200C_202C_206C_206A_200D_200E_206A_206E_200D_202C_206E_202B_202D_206A_202B_202E;

		internal ItemInstance _200C_206E_202A_200D_202E_200D_206F_206F_206E_202C_202C_200C_206B_206F_206C_200B_200F_206D_200C_206C_206B_206B_200E_200D_206E_202D_200E_200B_200C_200C_202A_202B_200C_206C_200F_202B_200F_202D_200E_200D_202E;

		internal string[] _202C_206B_202D_202D_206B_202C_200E_206E_206E_202D_206D_200B_202E_206C_200E_206A_202D_206F_200B_200E_202B_202A_202A_206F_202C_202A_206C_200B_202E_200D_206B_206E_202E_202C_206B_206A_200C_202B_202D_200F_202E;

		internal int _200F_206A_206D_206C_202B_206B_206A_206F_206F_206F_202D_206E_202B_202C_200F_206F_202D_202D_200C_206C_202C_200E_202E_200D_206E_200E_200E_206A_206A_206F_202D_202E_206A_202E_202D_202D_206E_200D_200C_200D_202E;

		internal string _202D_206E_206A_202B_202E_200C_202E_200C_200F_206C_202A_202A_202B_206F_206E_206C_200C_200F_200C_206D_206D_202E_200D_206D_206A_202C_206D_206B_206D_200F_206E_206A_206B_206A_206A_202C_202A_200B_206E_202C_202E;

		internal int _0024PC;

		internal string _0024current;

		internal Role _202A_202B_206D_202D_200C_202E_206F_200C_202B_202E_202E_206E_200D_206A_206F_206D_206F_200E_202C_206F_200B_206D_206B_202D_206C_206A_200D_200D_206D_200F_200F_206B_202A_202D_202A_200B_200F_200B_202C_202E_202E;

		string IEnumerator<string>.Current
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

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return System_002ECollections_002EGeneric_002EIEnumerable_003Cstring_003E_002EGetEnumerator();
		}

		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			if (_200E_206A_200E_200E_200F_202E_200C_202A_206C_200D_206F_200F_202E_200D_206E_200B_202E_200F_200D_202C_206D_206B_200E_200E_202D_206A_200D_200D_200D_202E_206D_200F_206C_206E_200E_200B_206A_202E_202E_202B_202E(ref _0024PC, 0, -2) == -2)
			{
				goto IL_0012;
			}
			goto IL_0049;
			IL_0012:
			int num = 2130575233;
			goto IL_0017;
			IL_0017:
			uint num2;
			_206F_202A_200C_202C_206E_206C_202D_200C_206B_206E_200D_206D_206C_206E_206C_206F_206F_206C_206C_200D_206B_206E_200E_202C_200E_200C_200B_200E_200C_206E_202D_200E_200B_206A_200C_206C_202C_202D_202C_206E_202E obj = default(_206F_202A_200C_202C_206E_206C_202D_200C_206B_206E_200D_206D_206C_206E_206C_206F_206F_206C_206C_200D_206B_206E_200E_202C_200E_200C_200B_200E_200C_206E_202D_200E_200B_206A_200C_206C_202C_202D_202C_206E_202E);
			switch ((num2 = (uint)(num ^ 0x2CF55F72)) % 4)
			{
			case 0u:
				break;
			case 3u:
				return this;
			case 1u:
				goto IL_0049;
			default:
				obj._202A_202B_206D_202D_200C_202E_206F_200C_202B_202E_202E_206E_200D_206A_206F_206D_206F_200E_202C_206F_200B_206D_206B_202D_206C_206A_200D_200D_206D_200F_200F_206B_202A_202D_202A_200B_200F_200B_202C_202E_202E = _202A_202B_206D_202D_200C_202E_206F_200C_202B_202E_202E_206E_200D_206A_206F_206D_206F_200E_202C_206F_200B_206D_206B_202D_206C_206A_200D_200D_206D_200F_200F_206B_202A_202D_202A_200B_200F_200B_202C_202E_202E;
				return obj;
			}
			goto IL_0012;
			IL_0049:
			obj = new _206F_202A_200C_202C_206E_206C_202D_200C_206B_206E_200D_206D_206C_206E_206C_206F_206F_206C_206C_200D_206B_206E_200E_202C_200E_200C_200B_200E_200C_206E_202D_200E_200B_206A_200C_206C_202C_202D_202C_206E_202E();
			num = 1458720500;
			goto IL_0017;
		}

		public bool MoveNext()
		{
			uint num = (uint)_0024PC;
			_0024PC = -1;
			bool flag = false;
			bool result = default(bool);
			while (true)
			{
				int num2 = 2084587835;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num2 ^ 0x2733E86C)) % 5)
					{
					case 2u:
						break;
					case 0u:
						_200C_206E_206C_206D_206F_202D_206C_200F_206F_202A_200C_206E_206E_206D_200D_202D_200D_200B_206B_202A_206B_202D_206B_206A_206C_200E_206B_206A_202E_200D_202B_200F_202A_200F_202C_206C_202A_206D_200F_206D_202E = new List<string>();
						_206B_202A_206D_202C_200E_206B_206F_200D_206F_200C_206E_206F_206F_200E_200C_202B_206A_202A_200C_202E_202A_206D_202B_206A_206B_206B_200C_206C_202D_200C_202C_202A_202C_202D_206F_202A_202B_200F_200F_200C_202E = _202A_202B_206D_202D_200C_202E_206F_200C_202B_202E_202E_206E_200D_206A_206F_206D_206F_200E_202C_206F_200B_206D_206B_202D_206C_206A_200D_200D_206D_200F_200F_206B_202A_202D_202A_200B_200F_200B_202C_202E_202E.GetTriggers(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1021681084u)).GetEnumerator();
						num2 = 567833010;
						continue;
					case 4u:
						switch (num)
						{
						case 0u:
							break;
						default:
							goto IL_0092;
						case 1u:
							goto IL_00a7;
						case 2u:
							goto IL_02de;
						}
						goto case 0u;
					default:
						num = 4294967293u;
						goto IL_00a7;
					case 3u:
						{
							return false;
						}
						IL_00a7:
						try
						{
							int num4;
							switch (num)
							{
							default:
								num4 = 2081227814;
								goto IL_00b8;
							case 1u:
								goto IL_01b6;
								IL_00b8:
								while (true)
								{
									switch ((num3 = (uint)(num4 ^ 0x2733E86C)) % 12)
									{
									case 9u:
										break;
									default:
										goto end_IL_00aa;
									case 0u:
									{
										_206C_202B_202B_206B_202D_200D_202A_206A_206F_200C_206C_200C_200E_206A_206F_200B_200D_202D_202B_202D_202B_206F_202B_206B_202A_202C_206D_200B_200E_200D_200F_200F_202C_200D_202A_206A_206B_206E_202C_202B_202E = _202E_202C_206F_200B_200F_202E_200F_200C_206B_200E_206C_202D_206E_200E_206C_200B_202A_200C_206B_206A_206D_206A_200B_200B_202C_202C_206C_202A_200F_200F_200E_202A_202B_202D_206C_206D_202B_200B_202A_202D_202E.Argvs[0];
										int num7;
										int num8;
										if (_200C_206A_202A_206A_202C_206D_200E_206A_206D_200B_206D_202E_206C_200F_206F_206B_206E_206F_202B_200F_200D_200E_200F_202A_200D_202A_206A_202B_200D_206A_202C_206D_206D_200C_206B_200E_206E_206E_202C_200C_202E(_202E_202C_206F_200B_200F_202E_200F_200C_206B_200E_206C_202D_206E_200E_206C_200B_202A_200C_206B_206A_206D_206A_200B_200B_202C_202C_206C_202A_200F_200F_200E_202A_202B_202D_206C_206D_202B_200B_202A_202D_202E.Name, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1480101968u)))
										{
											num7 = 226827443;
											num8 = num7;
										}
										else
										{
											num7 = 1414913023;
											num8 = num7;
										}
										num4 = num7 ^ ((int)num3 * -2044709436);
										continue;
									}
									case 5u:
										_0024PC = 1;
										num4 = (int)((num3 * 675949113) ^ 0x8519069);
										continue;
									case 10u:
										num4 = (int)((num3 * 448771749) ^ 0x214EE04D);
										continue;
									case 7u:
										goto IL_0177;
									case 2u:
										_0024current = _206C_202B_202B_206B_202D_200D_202A_206A_206F_200C_206C_200C_200E_206A_206F_200B_200D_202D_202B_202D_202B_206F_202B_206B_202A_202C_206D_200B_200E_200D_200F_200F_202C_200D_202A_206A_206B_206E_202C_202B_202E;
										num4 = ((int)num3 * -775274472) ^ -1062481019;
										continue;
									case 3u:
										goto IL_01b6;
									case 8u:
										flag = true;
										num4 = (int)(num3 * 2145735841) ^ -1556374471;
										continue;
									case 11u:
									{
										int num5;
										int num6;
										if (_200C_206E_206C_206D_206F_202D_206C_200F_206F_202A_200C_206E_206E_206D_200D_202D_200D_200B_206B_202A_206B_202D_206B_206A_206C_200E_206B_206A_202E_200D_202B_200F_202A_200F_202C_206C_202A_206D_200F_206D_202E.Contains(_206C_202B_202B_206B_202D_200D_202A_206A_206F_200C_206C_200C_200E_206A_206F_200B_200D_202D_202B_202D_202B_206F_202B_206B_202A_202C_206D_200B_200E_200D_200F_200F_202C_200D_202A_206A_206B_206E_202C_202B_202E))
										{
											num5 = -1139399969;
											num6 = num5;
										}
										else
										{
											num5 = -1726707954;
											num6 = num5;
										}
										num4 = num5 ^ (int)(num3 * 247324384);
										continue;
									}
									case 6u:
										_202E_202C_206F_200B_200F_202E_200F_200C_206B_200E_206C_202D_206E_200E_206C_200B_202A_200C_206B_206A_206D_206A_200B_200B_202C_202C_206C_202A_200F_200F_200E_202A_202B_202D_206C_206D_202B_200B_202A_202D_202E = _206B_202A_206D_202C_200E_206B_206F_200D_206F_200C_206E_206F_206F_200E_200C_202B_206A_202A_200C_202E_202A_206D_202B_206A_206B_206B_200C_206C_202D_200C_202C_202A_202C_202D_206F_202A_202B_200F_200F_200C_202E.Current;
										num4 = 889524076;
										continue;
									case 4u:
										goto end_IL_00aa;
									case 1u:
										goto IL_053f;
									}
									break;
									IL_0177:
									int num9;
									if (!_202E_206F_202E_202C_200D_202A_200C_206C_206F_202A_202C_200B_206C_206A_206E_200C_202E_200D_202E_200C_202D_206E_206F_206C_206D_202A_202D_206D_206A_202A_202C_206B_206A_200D_202A_206B_202E_200B_206A_202A_202E((IEnumerator)_206B_202A_206D_202C_200E_206B_206F_200D_206F_200C_206E_206F_206F_200E_200C_202B_206A_202A_200C_202E_202A_206D_202B_206A_206B_206B_200C_206C_202D_200C_202C_202A_202C_202D_206F_202A_202B_200F_200F_200C_202E))
									{
										num4 = 1408183788;
										num9 = num4;
									}
									else
									{
										num4 = 1064246834;
										num9 = num4;
									}
								}
								goto default;
								IL_01b6:
								_200C_206E_206C_206D_206F_202D_206C_200F_206F_202A_200C_206E_206E_206D_200D_202D_200D_200B_206B_202A_206B_202D_206B_206A_206C_200E_206B_206A_202E_200D_202B_200F_202A_200F_202C_206C_202A_206D_200F_206D_202E.Add(_206C_202B_202B_206B_202D_200D_202A_206A_206F_200C_206C_200C_200E_206A_206F_200B_200D_202D_202B_202D_202B_206F_202B_206B_202A_202C_206D_200B_200E_200D_200F_200F_202C_200D_202A_206A_206B_206E_202C_202B_202E);
								num4 = 2072905727;
								goto IL_00b8;
								end_IL_00aa:
								break;
							}
						}
						finally
						{
							if (flag)
							{
								goto IL_024b;
							}
							goto IL_0289;
							IL_024b:
							int num10 = 1970664261;
							goto IL_0250;
							IL_0250:
							while (true)
							{
								switch ((num3 = (uint)(num10 ^ 0x2733E86C)) % 6)
								{
								case 5u:
									break;
								default:
									goto end_IL_0248;
								case 1u:
									goto end_IL_0248;
								case 0u:
									goto IL_0289;
								case 2u:
									goto end_IL_0248;
								case 3u:
									_200D_202B_200E_200F_206C_202D_202D_200E_200F_200C_202A_200B_202D_206B_206C_202E_206B_202C_200B_202E_202B_202A_202E_202E_206E_200F_202D_206C_202D_206F_200D_200B_206B_206A_202D_202D_200E_206B_206D_202C_202E((IDisposable)_206B_202A_206D_202C_200E_206B_206F_200D_206F_200C_206E_206F_206F_200E_200C_202B_206A_202A_200C_202E_202A_206D_202B_206A_206B_206B_200C_206C_202D_200C_202C_202A_202C_202D_206F_202A_202B_200F_200F_200C_202E);
									num10 = 1999781672;
									continue;
								case 4u:
									goto end_IL_0248;
								}
								break;
							}
							goto IL_024b;
							IL_0289:
							int num11;
							if (_206B_202A_206D_202C_200E_206B_206F_200D_206F_200C_206E_206F_206F_200E_200C_202B_206A_202A_200C_202E_202A_206D_202B_206A_206B_206B_200C_206C_202D_200C_202C_202A_202C_202D_206F_202A_202B_200F_200F_200C_202E != null)
							{
								num10 = 1992511835;
								num11 = num10;
							}
							else
							{
								num10 = 1921529996;
								num11 = num10;
							}
							goto IL_0250;
							end_IL_0248:;
						}
						_206D_202D_202E_200C_202A_206F_200D_200B_200F_206E_202E_206C_202C_206B_200B_202E_202D_206D_206B_206A_202C_206A_200D_200B_206A_200C_202C_206C_206A_200D_200E_206A_206E_200D_202C_206E_202B_202D_206A_202B_202E = _202A_202B_206D_202D_200C_202E_206F_200C_202B_202E_202E_206E_200D_206A_206F_206D_206F_200E_202C_206F_200B_206D_206B_202D_206C_206A_200D_200D_206D_200F_200F_206B_202A_202D_202A_200B_200F_200B_202C_202E_202E.Equipment.GetEnumerator();
						num = 4294967293u;
						goto IL_02de;
						IL_053f:
						return true;
						IL_02de:
						try
						{
							int num12;
							switch (num)
							{
							default:
								num12 = 258395068;
								goto IL_02ef;
							case 2u:
								goto IL_0429;
								IL_02ef:
								while (true)
								{
									switch ((num3 = (uint)(num12 ^ 0x2733E86C)) % 14)
									{
									case 9u:
										break;
									default:
										goto end_IL_02e1;
									case 3u:
									{
										int num13;
										int num14;
										if (_200C_206E_206C_206D_206F_202D_206C_200F_206F_202A_200C_206E_206E_206D_200D_202D_200D_200B_206B_202A_206B_202D_206B_206A_206C_200E_206B_206A_202E_200D_202B_200F_202A_200F_202C_206C_202A_206D_200F_206D_202E.Contains(_202D_206E_206A_202B_202E_200C_202E_200C_200F_206C_202A_202A_202B_206F_206E_206C_200C_200F_200C_206D_206D_202E_200D_206D_206A_202C_206D_206B_206D_200F_206E_206A_206B_206A_206A_202C_202A_200B_206E_202C_202E))
										{
											num13 = 500655919;
											num14 = num13;
										}
										else
										{
											num13 = 973107713;
											num14 = num13;
										}
										num12 = num13 ^ (int)(num3 * 516228167);
										continue;
									}
									case 10u:
										goto IL_0368;
									case 0u:
										_0024current = _202D_206E_206A_202B_202E_200C_202E_200C_200F_206C_202A_202A_202B_206F_206E_206C_200C_200F_200C_206D_206D_202E_200D_206D_206A_202C_206D_206B_206D_200F_206E_206A_206B_206A_206A_202C_202A_200B_206E_202C_202E;
										num12 = (int)(num3 * 944199878) ^ -1413485324;
										continue;
									case 6u:
										_202D_206E_206A_202B_202E_200C_202E_200C_200F_206C_202A_202A_202B_206F_206E_206C_200C_200F_200C_206D_206D_202E_200D_206D_206A_202C_206D_206B_206D_200F_206E_206A_206B_206A_206A_202C_202A_200B_206E_202C_202E = _202C_206B_202D_202D_206B_202C_200E_206E_206E_202D_206D_200B_202E_206C_200E_206A_202D_206F_200B_200E_202B_202A_202A_206F_202C_202A_206C_200B_202E_200D_206B_206E_202E_202C_206B_206A_200C_202B_202D_200F_202E[_200F_206A_206D_206C_202B_206B_206A_206F_206F_206F_202D_206E_202B_202C_200F_206F_202D_202D_200C_206C_202C_200E_202E_200D_206E_200E_200E_206A_206A_206F_202D_202E_206A_202E_202D_202D_206E_200D_200C_200D_202E];
										num12 = 925333835;
										continue;
									case 1u:
										goto IL_03c4;
									case 7u:
										_202C_206B_202D_202D_206B_202C_200E_206E_206E_202D_206D_200B_202E_206C_200E_206A_202D_206F_200B_200E_202B_202A_202A_206F_202C_202A_206C_200B_202E_200D_206B_206E_202E_202C_206B_206A_200C_202B_202D_200F_202E = _200C_206E_202A_200D_202E_200D_206F_206F_206E_202C_202C_200C_206B_206F_206C_200B_200F_206D_200C_206C_206B_206B_200E_200D_206E_202D_200E_200B_200C_200C_202A_202B_200C_206C_200F_202B_200F_202D_200E_200D_202E.Talents;
										_200F_206A_206D_206C_202B_206B_206A_206F_206F_206F_202D_206E_202B_202C_200F_206F_202D_202D_200C_206C_202C_200E_202E_200D_206E_200E_200E_206A_206A_206F_202D_202E_206A_202E_202D_202D_206E_200D_200C_200D_202E = 0;
										num12 = ((int)num3 * -1762729261) ^ -933428442;
										continue;
									case 5u:
										goto IL_0429;
									case 2u:
										_200F_206A_206D_206C_202B_206B_206A_206F_206F_206F_202D_206E_202B_202C_200F_206F_202D_202D_200C_206C_202C_200E_202E_200D_206E_200E_200E_206A_206A_206F_202D_202E_206A_202E_202D_202D_206E_200D_200C_200D_202E++;
										num12 = 307160147;
										continue;
									case 8u:
										goto IL_045c;
									case 12u:
										num12 = (int)(num3 * 1422546944) ^ -1360549090;
										continue;
									case 4u:
										_0024PC = 2;
										flag = true;
										num12 = ((int)num3 * -1035544192) ^ 0x58A3CC1D;
										continue;
									case 13u:
										goto end_IL_02e1;
									case 11u:
										goto IL_053f;
									}
									break;
									IL_045c:
									_200C_206E_202A_200D_202E_200D_206F_206F_206E_202C_202C_200C_206B_206F_206C_200B_200F_206D_200C_206C_206B_206B_200E_200D_206E_202D_200E_200B_200C_200C_202A_202B_200C_206C_200F_202B_200F_202D_200E_200D_202E = _206D_202D_202E_200C_202A_206F_200D_200B_200F_206E_202E_206C_202C_206B_200B_202E_202D_206D_206B_206A_202C_206A_200D_200B_206A_200C_202C_206C_206A_200D_200E_206A_206E_200D_202C_206E_202B_202D_206A_202B_202E.Current;
									int num15;
									if (_200C_206E_202A_200D_202E_200D_206F_206F_206E_202C_202C_200C_206B_206F_206C_200B_200F_206D_200C_206C_206B_206B_200E_200D_206E_202D_200E_200B_200C_200C_202A_202B_200C_206C_200F_202B_200F_202D_200E_200D_202E != null)
									{
										num12 = 1858906107;
										num15 = num12;
									}
									else
									{
										num12 = 1753754398;
										num15 = num12;
									}
									continue;
									IL_03c4:
									int num16;
									if (_200F_206A_206D_206C_202B_206B_206A_206F_206F_206F_202D_206E_202B_202C_200F_206F_202D_202D_200C_206C_202C_200E_202E_200D_206E_200E_200E_206A_206A_206F_202D_202E_206A_202E_202D_202D_206E_200D_200C_200D_202E >= _202C_206B_202D_202D_206B_202C_200E_206E_206E_202D_206D_200B_202E_206C_200E_206A_202D_206F_200B_200E_202B_202A_202A_206F_202C_202A_206C_200B_202E_200D_206B_206E_202E_202C_206B_206A_200C_202B_202D_200F_202E.Length)
									{
										num12 = 1753754398;
										num16 = num12;
									}
									else
									{
										num12 = 2010872322;
										num16 = num12;
									}
									continue;
									IL_0368:
									int num17;
									if (_206D_202D_202E_200C_202A_206F_200D_200B_200F_206E_202E_206C_202C_206B_200B_202E_202D_206D_206B_206A_202C_206A_200D_200B_206A_200C_202C_206C_206A_200D_200E_206A_206E_200D_202C_206E_202B_202D_206A_202B_202E.MoveNext())
									{
										num12 = 986593776;
										num17 = num12;
									}
									else
									{
										num12 = 2114972809;
										num17 = num12;
									}
								}
								goto default;
								IL_0429:
								_200C_206E_206C_206D_206F_202D_206C_200F_206F_202A_200C_206E_206E_206D_200D_202D_200D_200B_206B_202A_206B_202D_206B_206A_206C_200E_206B_206A_202E_200D_202B_200F_202A_200F_202C_206C_202A_206D_200F_206D_202E.Add(_202D_206E_206A_202B_202E_200C_202E_200C_200F_206C_202A_202A_202B_206F_206E_206C_200C_200F_200C_206D_206D_202E_200D_206D_206A_202C_206D_206B_206D_200F_206E_206A_206B_206A_206A_202C_202A_200B_206E_202C_202E);
								num12 = 288144126;
								goto IL_02ef;
								end_IL_02e1:
								break;
							}
						}
						finally
						{
							if (flag)
							{
								goto IL_04bb;
							}
							goto IL_04f1;
							IL_04bb:
							int num18 = 1632097450;
							goto IL_04c0;
							IL_04c0:
							switch ((num3 = (uint)(num18 ^ 0x2733E86C)) % 4)
							{
							case 0u:
								break;
							default:
								goto end_IL_04b8;
							case 2u:
								goto end_IL_04b8;
							case 1u:
								goto IL_04f1;
							case 3u:
								goto end_IL_04b8;
							}
							goto IL_04bb;
							IL_04f1:
							_200D_202B_200E_200F_206C_202D_202D_200E_200F_200C_202A_200B_202D_206B_206C_202E_206B_202C_200B_202E_202B_202A_202E_202E_206E_200F_202D_206C_202D_206F_200D_200B_206B_206A_202D_202D_200E_206B_206D_202C_202E((IDisposable)_206D_202D_202E_200C_202A_206F_200D_200B_200F_206E_202E_206C_202C_206B_200B_202E_202D_206D_206B_206A_202C_206A_200D_200B_206A_200C_202C_206C_206A_200D_200E_206A_206E_200D_202C_206E_202B_202D_206A_202B_202E);
							num18 = 1119879935;
							goto IL_04c0;
							end_IL_04b8:;
						}
						_0024PC = -1;
						while (true)
						{
							switch ((num3 = 376071825u) % 4)
							{
							case 2u:
								continue;
							case 1u:
								goto end_IL_0510;
							case 0u:
								goto IL_053f;
							}
							return result;
							continue;
							end_IL_0510:
							break;
						}
						goto case 3u;
						IL_0092:
						num2 = (int)(num3 * 1413148303) ^ -277603256;
						continue;
					}
					break;
				}
			}
		}

		[DebuggerHidden]
		public void Dispose()
		{
			uint num = (uint)_0024PC;
			_0024PC = -1;
			switch (num)
			{
			case 1u:
				try
				{
					break;
				}
				finally
				{
					if (_206B_202A_206D_202C_200E_206B_206F_200D_206F_200C_206E_206F_206F_200E_200C_202B_206A_202A_200C_202E_202A_206D_202B_206A_206B_206B_200C_206C_202D_200C_202C_202A_202C_202D_206F_202A_202B_200F_200F_200C_202E != null)
					{
						goto IL_005e;
					}
					while (true)
					{
						uint num2;
						switch ((num2 = 1987624570u) % 3)
						{
						case 0u:
							continue;
						case 1u:
							goto end_IL_002c;
						}
						goto IL_005e;
						continue;
						end_IL_002c:
						break;
					}
					goto end_IL_0024;
					IL_005e:
					_200D_202B_200E_200F_206C_202D_202D_200E_200F_200C_202A_200B_202D_206B_206C_202E_206B_202C_200B_202E_202B_202A_202E_202E_206E_200F_202D_206C_202D_206F_200D_200B_206B_206A_202D_202D_200E_206B_206D_202C_202E((IDisposable)_206B_202A_206D_202C_200E_206B_206F_200D_206F_200C_206E_206F_206F_200E_200C_202B_206A_202A_200C_202E_202A_206D_202B_206A_206B_206B_200C_206C_202D_200C_202C_202A_202C_202D_206F_202A_202B_200F_200F_200C_202E);
					end_IL_0024:;
				}
			case 2u:
				try
				{
					break;
				}
				finally
				{
					_200D_202B_200E_200F_206C_202D_202D_200E_200F_200C_202A_200B_202D_206B_206C_202E_206B_202C_200B_202E_202B_202A_202E_202E_206E_200F_202D_206C_202D_206F_200D_200B_206B_206A_202D_202D_200E_206B_206D_202C_202E((IDisposable)_206D_202D_202E_200C_202A_206F_200D_200B_200F_206E_202E_206C_202C_206B_200B_202E_202D_206D_206B_206A_202C_206A_200D_200B_206A_200C_202C_206C_206A_200D_200E_206A_206E_200D_202C_206E_202B_202D_206A_202B_202E);
				}
			case 0u:
				break;
			}
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw _206E_206C_200B_206B_206A_200C_200B_202C_202A_206F_202B_206D_200E_202D_206A_206B_206D_200E_202A_202C_200D_206E_200F_202E_206D_206C_202E_200B_200D_206D_200D_206C_202E_202A_200B_200D_202C_200D_206B_202D_202E();
		}

		static int _200E_206A_200E_200E_200F_202E_200C_202A_206C_200D_206F_200F_202E_200D_206E_200B_202E_200F_200D_202C_206D_206B_200E_200E_202D_206A_200D_200D_200D_202E_206D_200F_206C_206E_200E_200B_206A_202E_202E_202B_202E(ref int P_0, int P_1, int P_2)
		{
			return Interlocked.CompareExchange(ref P_0, P_1, P_2);
		}

		static bool _200C_206A_202A_206A_202C_206D_200E_206A_206D_200B_206D_202E_206C_200F_206F_206B_206E_206F_202B_200F_200D_200E_200F_202A_200D_202A_206A_202B_200D_206A_202C_206D_206D_200C_206B_200E_206E_206E_202C_200C_202E(string P_0, string P_1)
		{
			return P_0 == P_1;
		}

		static bool _202E_206F_202E_202C_200D_202A_200C_206C_206F_202A_202C_200B_206C_206A_206E_200C_202E_200D_202E_200C_202D_206E_206F_206C_206D_202A_202D_206D_206A_202A_202C_206B_206A_200D_202A_206B_202E_200B_206A_202A_202E(IEnumerator P_0)
		{
			return P_0.MoveNext();
		}

		static void _200D_202B_200E_200F_206C_202D_202D_200E_200F_200C_202A_200B_202D_206B_206C_202E_206B_202C_200B_202E_202B_202A_202E_202E_206E_200F_202D_206C_202D_206F_200D_200B_206B_206A_202D_202D_200E_206B_206D_202C_202E(IDisposable P_0)
		{
			P_0.Dispose();
		}

		static NotSupportedException _206E_206C_200B_206B_206A_200C_200B_202C_202A_206F_202B_206D_200E_202D_206A_206B_206D_200E_202A_202C_200D_206E_200F_202E_206D_206C_202E_200B_200D_206D_200D_206C_202E_202A_200B_200D_202C_200D_206B_202D_202E()
		{
			return new NotSupportedException();
		}
	}

	[CompilerGenerated]
	private sealed class _200D_200E_202A_202D_206D_206F_202B_202A_200C_200B_202B_206B_202B_200B_206A_206B_202A_206D_206F_206F_206A_206D_200E_206C_202B_202D_200E_206C_200B_200B_202A_200F_206C_200F_206C_200C_206B_200B_206E_206A_202E : IEnumerable<SkillBox>, IEnumerator<SkillBox>, IEnumerator, IDisposable, IEnumerable
	{
		internal List<SpecialSkillInstance>.Enumerator _200F_202B_200D_206D_200D_200B_206B_202E_202C_202B_200B_206E_206B_200D_206A_200C_202B_200D_202B_206B_206C_202A_206D_206A_202B_206C_206C_200B_202D_206E_202A_202C_202C_200F_200F_206E_206C_200B_202E_206A_202E;

		internal SpecialSkillInstance _202C_206F_202A_200C_202D_202E_202D_206C_206A_200E_202E_206B_202A_202C_206E_206E_202B_200E_200E_202D_200F_202C_200B_202C_206D_206E_200B_202D_206E_200F_200B_200F_200F_202C_202B_206B_206D_206C_200B_202C_202E;

		internal List<SkillInstance>.Enumerator _200B_200D_202B_202A_200B_202B_206A_202C_206A_200D_206A_206C_202C_202E_206D_206A_200E_206E_200B_200C_206B_202E_202C_202E_206F_202C_206E_206B_200B_202E_200C_200F_206E_202E_202C_206B_200F_206D_206D_202E_202E;

		internal SkillInstance _200B_206A_206E_206E_202E_200B_206F_202D_202D_200F_206A_206D_200D_200E_206C_202D_206A_200D_202D_206D_206A_200D_202D_202D_206F_202D_200F_202E_202D_202D_206E_200B_206B_206F_200E_202C_206E_202D_202B_200C_202E;

		internal List<UniqueSkillInstance>.Enumerator _202C_200C_200F_206B_206E_202B_200D_206E_202B_206E_200F_200D_202B_202E_206C_206C_202A_202E_206A_206D_200F_206B_206A_206F_206E_202A_206C_206C_206E_200D_206B_200B_206B_202B_202C_200F_206B_202C_202C_206B_202E;

		internal UniqueSkillInstance _206F_202A_206B_200B_206F_200E_206A_206E_202E_202B_202D_200E_202B_206F_200C_206A_206E_206A_202A_206A_206E_202B_206C_200F_200E_206D_206C_202B_200D_200D_200E_202B_200F_202C_202B_202E_200E_200F_206F_206A_202E;

		internal InternalSkillInstance _206A_202E_206A_202D_200F_200E_200F_206F_202A_206D_202D_202E_206A_200B_202C_206B_200D_206A_202E_206B_202B_206B_206E_202C_206B_206C_202E_206F_202C_200C_202A_200C_200B_206A_200F_200B_206A_202D_202C_202C_202E;

		internal List<UniqueSkillInstance>.Enumerator _206D_206A_202D_206C_202C_202D_200F_206C_202C_200F_206E_202D_206F_206B_200C_206B_206E_206B_200E_200F_206F_200E_206D_206C_200C_200C_202D_202D_202D_206E_202B_200D_200D_202D_206C_200C_200B_206C_206B_202D_202E;

		internal UniqueSkillInstance _206E_202A_206A_206B_202B_202A_206A_202D_202E_200D_200F_206D_206E_206E_206C_206A_206F_206E_202E_202E_200D_206B_200E_202B_200B_206A_202A_202A_206A_206F_200E_206E_206A_206C_200F_200F_202C_200F_202E;

		internal int _0024PC;

		internal SkillBox _0024current;

		internal Role _202A_202B_206D_202D_200C_202E_206F_200C_202B_202E_202E_206E_200D_206A_206F_206D_206F_200E_202C_206F_200B_206D_206B_202D_206C_206A_200D_200D_206D_200F_200F_206B_202A_202D_202A_200B_200F_200B_202C_202E_202E;

		SkillBox IEnumerator<SkillBox>.Current
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

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return System_002ECollections_002EGeneric_002EIEnumerable_003CJyGame_002ESkillBox_003E_002EGetEnumerator();
		}

		[DebuggerHidden]
		IEnumerator<SkillBox> IEnumerable<SkillBox>.GetEnumerator()
		{
			if (_206B_200B_202D_206C_206C_200E_202C_200B_206A_206F_202D_206B_202A_200C_200F_200B_202C_206F_200C_202A_206B_200D_206C_206D_206E_200E_202E_206D_200B_206A_206B_206D_202E_200C_202A_202A_202E_206C_206F_206B_202E(ref _0024PC, 0, -2) == -2)
			{
				goto IL_0012;
			}
			goto IL_0049;
			IL_0012:
			int num = -1574483025;
			goto IL_0017;
			IL_0017:
			uint num2;
			_200D_200E_202A_202D_206D_206F_202B_202A_200C_200B_202B_206B_202B_200B_206A_206B_202A_206D_206F_206F_206A_206D_200E_206C_202B_202D_200E_206C_200B_200B_202A_200F_206C_200F_206C_200C_206B_200B_206E_206A_202E obj = default(_200D_200E_202A_202D_206D_206F_202B_202A_200C_200B_202B_206B_202B_200B_206A_206B_202A_206D_206F_206F_206A_206D_200E_206C_202B_202D_200E_206C_200B_200B_202A_200F_206C_200F_206C_200C_206B_200B_206E_206A_202E);
			switch ((num2 = (uint)(num ^ -1516941168)) % 4)
			{
			case 2u:
				break;
			case 3u:
				return this;
			case 0u:
				goto IL_0049;
			default:
				obj._202A_202B_206D_202D_200C_202E_206F_200C_202B_202E_202E_206E_200D_206A_206F_206D_206F_200E_202C_206F_200B_206D_206B_202D_206C_206A_200D_200D_206D_200F_200F_206B_202A_202D_202A_200B_200F_200B_202C_202E_202E = _202A_202B_206D_202D_200C_202E_206F_200C_202B_202E_202E_206E_200D_206A_206F_206D_206F_200E_202C_206F_200B_206D_206B_202D_206C_206A_200D_200D_206D_200F_200F_206B_202A_202D_202A_200B_200F_200B_202C_202E_202E;
				return obj;
			}
			goto IL_0012;
			IL_0049:
			obj = new _200D_200E_202A_202D_206D_206F_202B_202A_200C_200B_202B_206B_202B_200B_206A_206B_202A_206D_206F_206F_206A_206D_200E_206C_202B_202D_200E_206C_200B_200B_202A_200F_206C_200F_206C_200C_206B_200B_206E_206A_202E();
			num = -1649915767;
			goto IL_0017;
		}

		public bool MoveNext()
		{
			uint num = (uint)_0024PC;
			bool flag = default(bool);
			bool result = default(bool);
			while (true)
			{
				int num2 = 918083297;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num2 ^ 0x7B86046B)) % 4)
					{
					case 0u:
						break;
					case 2u:
						_0024PC = -1;
						flag = false;
						switch (num)
						{
						case 0u:
							goto IL_0073;
						case 1u:
							goto IL_008c;
						case 2u:
						case 3u:
							goto IL_0203;
						case 4u:
							goto IL_055d;
						}
						goto IL_0050;
					default:
						goto IL_0073;
					case 1u:
						{
							return false;
						}
						IL_0073:
						_200F_202B_200D_206D_200D_200B_206B_202E_202C_202B_200B_206E_206B_200D_206A_200C_202B_200D_202B_206B_206C_202A_206D_206A_202B_206C_206C_200B_202D_206E_202A_202C_202C_200F_200F_206E_206C_200B_202E_206A_202E = _202A_202B_206D_202D_200C_202E_206F_200C_202B_202E_202E_206E_200D_206A_206F_206D_206F_200E_202C_206F_200B_206D_206B_202D_206C_206A_200D_200D_206D_200F_200F_206B_202A_202D_202A_200B_200F_200B_202C_202E_202E.SpecialSkills.GetEnumerator();
						num = 4294967293u;
						goto IL_008c;
						IL_008c:
						try
						{
							int num4;
							int num7;
							switch (num)
							{
							default:
								num4 = 1689166892;
								goto IL_009d;
							case 1u:
								goto IL_00e9;
								IL_009d:
								while (true)
								{
									switch ((num3 = (uint)(num4 ^ 0x7B86046B)) % 10)
									{
									case 0u:
										break;
									default:
										goto end_IL_008f;
									case 7u:
										num4 = ((int)num3 * -1576421935) ^ -1283077677;
										continue;
									case 5u:
										goto IL_00e9;
									case 1u:
										_0024PC = 1;
										num4 = (int)(num3 * 1014109817) ^ -1584615887;
										continue;
									case 9u:
										_202C_206F_202A_200C_202D_202E_202D_206C_206A_200E_202E_206B_202A_202C_206E_206E_202B_200E_200E_202D_200F_202C_200B_202C_206D_206E_200B_202D_206E_200F_200B_200F_200F_202C_202B_206B_206D_206C_200B_202C_202E = _200F_202B_200D_206D_200D_200B_206B_202E_202C_202B_200B_206E_206B_200D_206A_200C_202B_200D_202B_206B_206C_202A_206D_206A_202B_206C_206C_200B_202D_206E_202A_202C_202C_200F_200F_206E_206C_200B_202E_206A_202E.Current;
										num4 = 945675303;
										continue;
									case 8u:
									{
										int num5;
										int num6;
										if (!_202C_206F_202A_200C_202D_202E_202D_206C_206A_200E_202E_206B_202A_202C_206E_206E_202B_200E_200E_202D_200F_202C_200B_202C_206D_206E_200B_202D_206E_200F_200B_200F_200F_202C_202B_206B_206D_206C_200B_202C_202E.IsUsed)
										{
											num5 = 1244247807;
											num6 = num5;
										}
										else
										{
											num5 = 1090434845;
											num6 = num5;
										}
										num4 = num5 ^ ((int)num3 * -844666102);
										continue;
									}
									case 2u:
										_0024current = _202C_206F_202A_200C_202D_202E_202D_206C_206A_200E_202E_206B_202A_202C_206E_206E_202B_200E_200E_202D_200F_202C_200B_202C_206D_206E_200B_202D_206E_200F_200B_200F_200F_202C_202B_206B_206D_206C_200B_202C_202E;
										num4 = 391770478;
										continue;
									case 3u:
										flag = true;
										goto IL_06fe;
									case 4u:
										num4 = (int)(num3 * 926405119) ^ -974203216;
										continue;
									case 6u:
										goto end_IL_008f;
									}
									break;
								}
								goto default;
								IL_00e9:
								if (_200F_202B_200D_206D_200D_200B_206B_202E_202C_202B_200B_206E_206B_200D_206A_200C_202B_200D_202B_206B_206C_202A_206D_206A_202B_206C_206C_200B_202D_206E_202A_202C_202C_200F_200F_206E_206C_200B_202E_206A_202E.MoveNext())
								{
									num4 = 1030344322;
									num7 = num4;
								}
								else
								{
									num4 = 1818986193;
									num7 = num4;
								}
								goto IL_009d;
								end_IL_008f:
								break;
							}
						}
						finally
						{
							if (!flag)
							{
								goto IL_01d9;
							}
							while (true)
							{
								switch ((num3 = 952768270u) % 3)
								{
								case 0u:
									continue;
								case 1u:
									goto end_IL_01a7;
								}
								goto IL_01d9;
								continue;
								end_IL_01a7:
								break;
							}
							goto end_IL_01a4;
							IL_01d9:
							_206A_206B_200B_202B_200B_202C_206A_200D_200B_206C_200C_202A_206B_202A_206C_206A_200C_206C_200D_202A_202C_200E_200E_200F_206F_202D_202A_200E_200E_202C_206F_202B_202D_200C_202A_200D_200F_202C_202E_200F_202E((IDisposable)_200F_202B_200D_206D_200D_200B_206B_202E_202C_202B_200B_206E_206B_200D_206A_200C_202B_200D_202B_206B_206C_202A_206D_206A_202B_206C_206C_200B_202D_206E_202A_202C_202C_200F_200F_206E_206C_200B_202E_206A_202E);
							end_IL_01a4:;
						}
						_200B_200D_202B_202A_200B_202B_206A_202C_206A_200D_206A_206C_202C_202E_206D_206A_200E_206E_200B_200C_206B_202E_202C_202E_206F_202C_206E_206B_200B_202E_200C_200F_206E_202E_202C_206B_200F_206D_206D_202E_202E = _202A_202B_206D_202D_200C_202E_206F_200C_202B_202E_202E_206E_200D_206A_206F_206D_206F_200E_202C_206F_200B_206D_206B_202D_206C_206A_200D_200D_206D_200F_200F_206B_202A_202D_202A_200B_200F_200B_202C_202E_202E.Skills.GetEnumerator();
						num = 4294967293u;
						goto IL_0203;
						IL_06c8:
						_0024PC = -1;
						while (true)
						{
							switch ((num3 = 10550750u) % 4)
							{
							case 0u:
								continue;
							case 2u:
								goto end_IL_06cf;
							case 1u:
								goto IL_06fe;
							}
							return result;
							continue;
							end_IL_06cf:
							break;
						}
						goto case 1u;
						IL_0203:
						try
						{
							int num8;
							switch (num)
							{
							default:
								num8 = 2100532734;
								goto IL_0218;
							case 2u:
								goto IL_0255;
							case 3u:
								{
									try
									{
										int num11;
										int num13;
										switch (num)
										{
										default:
											num11 = 935984956;
											goto IL_033a;
										case 3u:
											goto IL_03b5;
											IL_033a:
											while (true)
											{
												switch ((num3 = (uint)(num11 ^ 0x7B86046B)) % 9)
												{
												case 3u:
													break;
												default:
													goto end_IL_032c;
												case 8u:
													_0024PC = 3;
													num11 = (int)((num3 * 679474327) ^ 0x6DAB7553);
													continue;
												case 7u:
													_0024current = _206F_202A_206B_200B_206F_200E_206A_206E_202E_202B_202D_200E_202B_206F_200C_206A_206E_206A_202A_206A_206E_202B_206C_200F_200E_206D_206C_202B_200D_200D_200E_202B_200F_202C_202B_202E_200E_200F_206F_206A_202E;
													num11 = (int)((num3 * 156992791) ^ 0x4E33E180);
													continue;
												case 2u:
													flag = true;
													num11 = (int)((num3 * 1934127682) ^ 0x5AD0EA37);
													continue;
												case 6u:
													goto IL_03b5;
												case 4u:
													goto IL_03d6;
												case 5u:
													goto end_IL_0206;
												case 1u:
													num11 = (int)(num3 * 598584519) ^ -564051010;
													continue;
												case 0u:
													goto end_IL_032c;
												}
												break;
												IL_03d6:
												_206F_202A_206B_200B_206F_200E_206A_206E_202E_202B_202D_200E_202B_206F_200C_206A_206E_206A_202A_206A_206E_202B_206C_200F_200E_206D_206C_202B_200D_200D_200E_202B_200F_202C_202B_202E_200E_200F_206F_206A_202E = _202C_200C_200F_206B_206E_202B_200D_206E_202B_206E_200F_200D_202B_202E_206C_206C_202A_202E_206A_206D_200F_206B_206A_206F_206E_202A_206C_206C_206E_200D_206B_200B_206B_202B_202C_200F_206B_202C_202C_206B_202E.Current;
												int num12;
												if (_200B_206A_206E_206E_202E_200B_206F_202D_202D_200F_206A_206D_200D_200E_206C_202D_206A_200D_202D_206D_206A_200D_202D_202D_206F_202D_200F_202E_202D_202D_206E_200B_206B_206F_200E_202C_206E_202D_202B_200C_202E.level >= _206F_202A_206B_200B_206F_200E_206A_206E_202E_202B_202D_200E_202B_206F_200C_206A_206E_206A_202A_206A_206E_202B_206C_200F_200E_206D_206C_202B_200D_200D_200E_202B_200F_202C_202B_202E_200E_200F_206F_206A_202E.UniqueSkill.RequireLevel)
												{
													num11 = 174659113;
													num12 = num11;
												}
												else
												{
													num11 = 330602271;
													num12 = num11;
												}
											}
											goto default;
											IL_03b5:
											if (_202C_200C_200F_206B_206E_202B_200D_206E_202B_206E_200F_200D_202B_202E_206C_206C_202A_202E_206A_206D_200F_206B_206A_206F_206E_202A_206C_206C_206E_200D_206B_200B_206B_202B_202C_200F_206B_202C_202C_206B_202E.MoveNext())
											{
												num11 = 116751535;
												num13 = num11;
											}
											else
											{
												num11 = 1703671590;
												num13 = num11;
											}
											goto IL_033a;
											end_IL_032c:
											break;
										}
									}
									finally
									{
										if (flag)
										{
											goto IL_0446;
										}
										goto IL_047c;
										IL_0446:
										int num14 = 484999373;
										goto IL_044b;
										IL_044b:
										switch ((num3 = (uint)(num14 ^ 0x7B86046B)) % 4)
										{
										case 0u:
											break;
										default:
											goto end_IL_0443;
										case 2u:
											goto end_IL_0443;
										case 1u:
											goto IL_047c;
										case 3u:
											goto end_IL_0443;
										}
										goto IL_0446;
										IL_047c:
										_206A_206B_200B_202B_200B_202C_206A_200D_200B_206C_200C_202A_206B_202A_206C_206A_200C_206C_200D_202A_202C_200E_200E_200F_206F_202D_202A_200E_200E_202C_206F_202B_202D_200C_202A_200D_200F_202C_202E_200F_202E((IDisposable)_202C_200C_200F_206B_206E_202B_200D_206E_202B_206E_200F_200D_202B_202E_206C_206C_202A_202E_206A_206D_200F_206B_206A_206F_206E_202A_206C_206C_206E_200D_206B_200B_206B_202B_202C_200F_206B_202C_202C_206B_202E);
										num14 = 251417644;
										goto IL_044b;
										end_IL_0443:;
									}
									goto IL_0494;
								}
								IL_0218:
								while (true)
								{
									switch ((num3 = (uint)(num8 ^ 0x7B86046B)) % 10)
									{
									case 4u:
										break;
									case 8u:
										goto IL_0255;
									case 2u:
										flag = true;
										num8 = ((int)num3 * -126788232) ^ -1292086860;
										continue;
									case 3u:
										goto end_IL_0206;
									case 5u:
										goto IL_02ae;
									case 0u:
									{
										int num9;
										int num10;
										if (_200B_206A_206E_206E_202E_200B_206F_202D_202D_200F_206A_206D_200D_200E_206C_202D_206A_200D_202D_206D_206A_200D_202D_202D_206F_202D_200F_202E_202D_202D_206E_200B_206B_206F_200E_202C_206E_202D_202B_200C_202E.IsUsed)
										{
											num9 = 1949107143;
											num10 = num9;
										}
										else
										{
											num9 = 1476897958;
											num10 = num9;
										}
										num8 = num9 ^ (int)(num3 * 208207958);
										continue;
									}
									case 6u:
										_0024current = _200B_206A_206E_206E_202E_200B_206F_202D_202D_200F_206A_206D_200D_200E_206C_202D_206A_200D_202D_206D_206A_200D_202D_202D_206F_202D_200F_202E_202D_202D_206E_200B_206B_206F_200E_202C_206E_202D_202B_200C_202E;
										_0024PC = 2;
										num8 = 1930922037;
										continue;
									default:
										goto IL_0326;
									case 1u:
									case 9u:
										goto IL_0494;
									}
									break;
								}
								goto default;
								IL_0326:
								num = 4294967293u;
								goto case 3u;
								IL_0494:
								if (_200B_200D_202B_202A_200B_202B_206A_202C_206A_200D_206A_206C_202C_202E_206D_206A_200E_206E_200B_200C_206B_202E_202C_202E_206F_202C_206E_206B_200B_202E_200C_200F_206E_202E_202C_206B_200F_206D_206D_202E_202E.MoveNext())
								{
									goto IL_02ae;
								}
								goto IL_04f7;
								IL_02ae:
								_200B_206A_206E_206E_202E_200B_206F_202D_202D_200F_206A_206D_200D_200E_206C_202D_206A_200D_202D_206D_206A_200D_202D_202D_206F_202D_200F_202E_202D_202D_206E_200B_206B_206F_200E_202C_206E_202D_202B_200C_202E = _200B_200D_202B_202A_200B_202B_206A_202C_206A_200D_206A_206C_202C_202E_206D_206A_200E_206E_200B_200C_206B_202E_202C_202E_206F_202C_206E_206B_200B_202E_200C_200F_206E_202E_202C_206B_200F_206D_206D_202E_202E.Current;
								num8 = 149323657;
								goto IL_0218;
								IL_0255:
								_202C_200C_200F_206B_206E_202B_200D_206E_202B_206E_200F_200D_202B_202E_206C_206C_202A_202E_206A_206D_200F_206B_206A_206F_206E_202A_206C_206C_206E_200D_206B_200B_206B_202B_202C_200F_206B_202C_202C_206B_202E = _200B_206A_206E_206E_202E_200B_206F_202D_202D_200F_206A_206D_200D_200E_206C_202D_206A_200D_202D_206D_206A_200D_202D_202D_206F_202D_200F_202E_202D_202D_206E_200B_206B_206F_200E_202C_206E_202D_202B_200C_202E.UniqueSkills.GetEnumerator();
								num8 = 1387809472;
								goto IL_0218;
								end_IL_0206:
								break;
							}
						}
						finally
						{
							if (flag)
							{
								goto IL_04a9;
							}
							goto IL_04df;
							IL_04a9:
							int num15 = 750318706;
							goto IL_04ae;
							IL_04ae:
							switch ((num3 = (uint)(num15 ^ 0x7B86046B)) % 4)
							{
							case 2u:
								break;
							default:
								goto end_IL_04a6;
							case 1u:
								goto end_IL_04a6;
							case 3u:
								goto IL_04df;
							case 0u:
								goto end_IL_04a6;
							}
							goto IL_04a9;
							IL_04df:
							_206A_206B_200B_202B_200B_202C_206A_200D_200B_206C_200C_202A_206B_202A_206C_206A_200C_206C_200D_202A_202C_200E_200E_200F_206F_202D_202A_200E_200E_202C_206F_202B_202D_200C_202A_200D_200F_202C_202E_200F_202E((IDisposable)_200B_200D_202B_202A_200B_202B_206A_202C_206A_200D_206A_206C_202C_202E_206D_206A_200E_206E_200B_200C_206B_202E_202C_202E_206F_202C_206E_206B_200B_202E_200C_200F_206E_202E_202C_206B_200F_206D_206D_202E_202E);
							num15 = 1479346011;
							goto IL_04ae;
							end_IL_04a6:;
						}
						goto IL_06fe;
						IL_04f7:
						_206A_202E_206A_202D_200F_200E_200F_206F_202A_206D_202D_202E_206A_200B_202C_206B_200D_206A_202E_206B_202B_206B_206E_202C_206B_206C_202E_206F_202C_200C_202A_200C_200B_206A_200F_200B_206A_202D_202C_202C_202E = _202A_202B_206D_202D_200C_202E_206F_200C_202B_202E_202E_206E_200D_206A_206F_206D_206F_200E_202C_206F_200B_206D_206B_202D_206C_206A_200D_200D_206D_200F_200F_206B_202A_202D_202A_200B_200F_200B_202C_202E_202E.EquippedInternalSkill;
						while (true)
						{
							int num16 = 1580304870;
							while (true)
							{
								switch ((num3 = (uint)(num16 ^ 0x7B86046B)) % 3)
								{
								case 0u:
									break;
								case 1u:
									goto IL_052a;
								default:
									goto end_IL_0508;
								}
								break;
								IL_052a:
								if (_206A_202E_206A_202D_200F_200E_200F_206F_202A_206D_202D_202E_206A_200B_202C_206B_200D_206A_202E_206B_202B_206B_206E_202C_206B_206C_202E_206F_202C_200C_202A_200C_200B_206A_200F_200B_206A_202D_202C_202C_202E != null)
								{
									num16 = ((int)num3 * -556471228) ^ -1039333041;
									continue;
								}
								goto IL_06c8;
							}
							continue;
							end_IL_0508:
							break;
						}
						_206D_206A_202D_206C_202C_202D_200F_206C_202C_200F_206E_202D_206F_206B_200C_206B_206E_206B_200E_200F_206F_200E_206D_206C_200C_200C_202D_202D_202D_206E_202B_200D_200D_202D_206C_200C_200B_206C_206B_202D_202E = _206A_202E_206A_202D_200F_200E_200F_206F_202A_206D_202D_202E_206A_200B_202C_206B_200D_206A_202E_206B_202B_206B_206E_202C_206B_206C_202E_206F_202C_200C_202A_200C_200B_206A_200F_200B_206A_202D_202C_202C_202E.UniqueSkills.GetEnumerator();
						num = 4294967293u;
						goto IL_055d;
						IL_06fe:
						return true;
						IL_055d:
						try
						{
							int num17;
							int num19;
							switch (num)
							{
							default:
								num17 = 1874213782;
								goto IL_056e;
							case 4u:
								goto IL_0612;
								IL_056e:
								while (true)
								{
									switch ((num3 = (uint)(num17 ^ 0x7B86046B)) % 9)
									{
									case 2u:
										break;
									default:
										goto end_IL_0560;
									case 6u:
										num17 = ((int)num3 * -1329156648) ^ 0x15526718;
										continue;
									case 7u:
										_0024PC = 4;
										num17 = (int)((num3 * 690269075) ^ 0xB8719CE);
										continue;
									case 4u:
										flag = true;
										num17 = ((int)num3 * -462397673) ^ -542515188;
										continue;
									case 8u:
										_0024current = _206E_202A_206A_206B_202B_202A_206A_202D_202E_200D_200F_206D_206E_206E_206C_206A_206F_206E_202E_202E_200D_206B_200E_202B_200B_206A_202A_202A_206A_206F_200E_206E_206A_206C_200F_200F_202C_200F_202E;
										num17 = (int)(num3 * 1810618646) ^ -348562971;
										continue;
									case 5u:
										goto IL_0612;
									case 0u:
										goto IL_0633;
									case 3u:
										goto end_IL_0560;
									case 1u:
										goto IL_06fe;
									}
									break;
									IL_0633:
									_206E_202A_206A_206B_202B_202A_206A_202D_202E_200D_200F_206D_206E_206E_206C_206A_206F_206E_202E_202E_200D_206B_200E_202B_200B_206A_202A_202A_206A_206F_200E_206E_206A_206C_200F_200F_202C_200F_202E = _206D_206A_202D_206C_202C_202D_200F_206C_202C_200F_206E_202D_206F_206B_200C_206B_206E_206B_200E_200F_206F_200E_206D_206C_200C_200C_202D_202D_202D_206E_202B_200D_200D_202D_206C_200C_200B_206C_206B_202D_202E.Current;
									int num18;
									if (_206A_202E_206A_202D_200F_200E_200F_206F_202A_206D_202D_202E_206A_200B_202C_206B_200D_206A_202E_206B_202B_206B_206E_202C_206B_206C_202E_206F_202C_200C_202A_200C_200B_206A_200F_200B_206A_202D_202C_202C_202E.level >= _206E_202A_206A_206B_202B_202A_206A_202D_202E_200D_200F_206D_206E_206E_206C_206A_206F_206E_202E_202E_200D_206B_200E_202B_200B_206A_202A_202A_206A_206F_200E_206E_206A_206C_200F_200F_202C_200F_202E.UniqueSkill.RequireLevel)
									{
										num17 = 960433971;
										num18 = num17;
									}
									else
									{
										num17 = 83071328;
										num18 = num17;
									}
								}
								goto default;
								IL_0612:
								if (_206D_206A_202D_206C_202C_202D_200F_206C_202C_200F_206E_202D_206F_206B_200C_206B_206E_206B_200E_200F_206F_200E_206D_206C_200C_200C_202D_202D_202D_206E_202B_200D_200D_202D_206C_200C_200B_206C_206B_202D_202E.MoveNext())
								{
									num17 = 312681365;
									num19 = num17;
								}
								else
								{
									num17 = 2024112315;
									num19 = num17;
								}
								goto IL_056e;
								end_IL_0560:
								break;
							}
						}
						finally
						{
							if (flag)
							{
								goto IL_067a;
							}
							goto IL_06b0;
							IL_067a:
							int num20 = 314233934;
							goto IL_067f;
							IL_067f:
							switch ((num3 = (uint)(num20 ^ 0x7B86046B)) % 4)
							{
							case 2u:
								break;
							default:
								goto end_IL_0677;
							case 1u:
								goto end_IL_0677;
							case 3u:
								goto IL_06b0;
							case 0u:
								goto end_IL_0677;
							}
							goto IL_067a;
							IL_06b0:
							_206A_206B_200B_202B_200B_202C_206A_200D_200B_206C_200C_202A_206B_202A_206C_206A_200C_206C_200D_202A_202C_200E_200E_200F_206F_202D_202A_200E_200E_202C_206F_202B_202D_200C_202A_200D_200F_202C_202E_200F_202E((IDisposable)_206D_206A_202D_206C_202C_202D_200F_206C_202C_200F_206E_202D_206F_206B_200C_206B_206E_206B_200E_200F_206F_200E_206D_206C_200C_200C_202D_202D_202D_206E_202B_200D_200D_202D_206C_200C_200B_206C_206B_202D_202E);
							num20 = 1413353423;
							goto IL_067f;
							end_IL_0677:;
						}
						goto IL_06c8;
					}
					break;
					IL_0050:
					num2 = (int)((num3 * 30925443) ^ 0x771F543C);
				}
			}
		}

		[DebuggerHidden]
		public void Dispose()
		{
			uint num = (uint)_0024PC;
			while (true)
			{
				int num2 = 858321039;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num2 ^ 0x193D6FF2)) % 4)
					{
					case 3u:
						break;
					default:
						return;
					case 1u:
						_0024PC = -1;
						num2 = ((int)num3 * -1410828176) ^ -1069333466;
						continue;
					case 0u:
						switch (num)
						{
						default:
							num2 = (int)(num3 * 621443437) ^ -1192468712;
							break;
						case 1u:
							try
							{
								return;
							}
							finally
							{
								_206A_206B_200B_202B_200B_202C_206A_200D_200B_206C_200C_202A_206B_202A_206C_206A_200C_206C_200D_202A_202C_200E_200E_200F_206F_202D_202A_200E_200E_202C_206F_202B_202D_200C_202A_200D_200F_202C_202E_200F_202E((IDisposable)_200F_202B_200D_206D_200D_200B_206B_202E_202C_202B_200B_206E_206B_200D_206A_200C_202B_200D_202B_206B_206C_202A_206D_206A_202B_206C_206C_200B_202D_206E_202A_202C_202C_200F_200F_206E_206C_200B_202E_206A_202E);
							}
						case 2u:
						case 3u:
							try
							{
								switch (num)
								{
								case 3u:
									try
									{
										break;
									}
									finally
									{
										_206A_206B_200B_202B_200B_202C_206A_200D_200B_206C_200C_202A_206B_202A_206C_206A_200C_206C_200D_202A_202C_200E_200E_200F_206F_202D_202A_200E_200E_202C_206F_202B_202D_200C_202A_200D_200F_202C_202E_200F_202E((IDisposable)_202C_200C_200F_206B_206E_202B_200D_206E_202B_206E_200F_200D_202B_202E_206C_206C_202A_202E_206A_206D_200F_206B_206A_206F_206E_202A_206C_206C_206E_200D_206B_200B_206B_202B_202C_200F_206B_202C_202C_206B_202E);
									}
								case 2u:
									break;
								}
								return;
							}
							finally
							{
								_206A_206B_200B_202B_200B_202C_206A_200D_200B_206C_200C_202A_206B_202A_206C_206A_200C_206C_200D_202A_202C_200E_200E_200F_206F_202D_202A_200E_200E_202C_206F_202B_202D_200C_202A_200D_200F_202C_202E_200F_202E((IDisposable)_200B_200D_202B_202A_200B_202B_206A_202C_206A_200D_206A_206C_202C_202E_206D_206A_200E_206E_200B_200C_206B_202E_202C_202E_206F_202C_206E_206B_200B_202E_200C_200F_206E_202E_202C_206B_200F_206D_206D_202E_202E);
							}
						case 4u:
							try
							{
								return;
							}
							finally
							{
								_206A_206B_200B_202B_200B_202C_206A_200D_200B_206C_200C_202A_206B_202A_206C_206A_200C_206C_200D_202A_202C_200E_200E_200F_206F_202D_202A_200E_200E_202C_206F_202B_202D_200C_202A_200D_200F_202C_202E_200F_202E((IDisposable)_206D_206A_202D_206C_202C_202D_200F_206C_202C_200F_206E_202D_206F_206B_200C_206B_206E_206B_200E_200F_206F_200E_206D_206C_200C_200C_202D_202D_202D_206E_202B_200D_200D_202D_206C_200C_200B_206C_206B_202D_202E);
							}
						case 0u:
							return;
						}
						continue;
					case 2u:
						return;
					}
					break;
				}
			}
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw _206A_202C_206D_200D_200B_206B_206B_200E_200F_206B_206E_200F_202E_206C_200E_206A_200B_200C_200F_200D_200F_200C_206D_202E_206A_202D_200F_202A_200F_206A_202E_206A_206B_202D_206C_202B_200C_200E_202D_206F_202E();
		}

		static int _206B_200B_202D_206C_206C_200E_202C_200B_206A_206F_202D_206B_202A_200C_200F_200B_202C_206F_200C_202A_206B_200D_206C_206D_206E_200E_202E_206D_200B_206A_206B_206D_202E_200C_202A_202A_202E_206C_206F_206B_202E(ref int P_0, int P_1, int P_2)
		{
			return Interlocked.CompareExchange(ref P_0, P_1, P_2);
		}

		static void _206A_206B_200B_202B_200B_202C_206A_200D_200B_206C_200C_202A_206B_202A_206C_206A_200C_206C_200D_202A_202C_200E_200E_200F_206F_202D_202A_200E_200E_202C_206F_202B_202D_200C_202A_200D_200F_202C_202E_200F_202E(IDisposable P_0)
		{
			P_0.Dispose();
		}

		static NotSupportedException _206A_202C_206D_200D_200B_206B_206B_200E_200F_206B_206E_200F_202E_206C_200E_206A_200B_200C_200F_200D_200F_200C_206D_202E_206A_202D_200F_202A_200F_206A_202E_206A_206B_202D_206C_202B_200C_200E_202D_206F_202E()
		{
			return new NotSupportedException();
		}
	}

	[CompilerGenerated]
	private sealed class _202C_206A_206C_200D_206B_200C_202D_202D_200B_206C_202E_200C_202B_206D_206D_200F_202E_200D_200E_200C_202A_200C_200F_202B_200E_206C_206C_200B_206A_206A_202A_200F_206E_200C_206E_202D_206A_202B_202B_202C_202E : IEnumerable<Trigger>, IEnumerator<Trigger>, IEnumerator, IDisposable, IEnumerable
	{
		private int _200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E;

		private Trigger _200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E;

		private int _200B_202B_206E_200C_202C_200D_206F_202E_200F_206A_200C_202C_200B_202D_200F_206E_202D_206C_200B_202C_206C_206A_206E_206C_202B_206D_206E_200E_206E_202D_206E_202E_202E_202A_206D_206E_206D_202C_202D_202E;

		public Role _202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E;

		private string name;

		public string _202B_206F_200C_202E_206C_202E_206E_206A_200F_206D_206D_200C_200E_202C_200B_206E_200C_206B_200F_206B_200C_200D_200B_200E_202A_202C_206A_200B_202A_202E_206D_200C_202A_200C_200D_200C_202D_202E_202B_200D_202E;

		private SkillInstance _206C_202A_202B_200B_206B_200E_202E_206B_206E_206F_206D_202C_202E_202A_200F_200D_206C_206B_206F_206F_200C_206F_200E_206D_202C_206C_202D_200E_202B_202E_200B_202D_202A_206F_206F_200C_206C_200F_200D_202E_202E;

		private InternalSkillInstance _200C_202A_206B_202A_200C_206B_202A_202B_206D_200F_206D_200E_200F_202C_200D_200D_200B_202C_206D_206B_202B_206B_202A_200C_200E_202B_202B_206E_206B_202E_200C_206E_200C_206B_200E_200B_200F_200D_200D_200F_202E;

		private List<ItemInstance>.Enumerator _206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E;

		private IEnumerator<Trigger> _200D_206A_202C_200E_206F_206B_202A_202D_200D_200E_202B_202A_206E_206E_202E_206B_200E_200F_202C_202D_202A_206C_202C_202A_200E_200C_206B_206B_206C_200D_206B_202A_202A_202D_200B_206E_206F_200F_202A_206A_202E;

		private List<SkillInstance>.Enumerator _206A_206D_206C_200B_202A_202B_202A_202D_206D_200C_206E_200C_206E_200E_202E_202E_206E_202D_202A_200D_200F_202E_200B_206F_200B_206A_202C_202C_202E_206A_200B_200D_200C_206E_206F_200D_206B_200D_200F_206A_202E;

		private List<Trigger>.Enumerator _200E_200F_202E_206E_206C_206F_202C_206A_206D_202A_200B_206A_206A_200E_202B_202C_202E_200F_202C_200E_202C_206C_200F_200E_202C_200F_202B_206F_202C_206A_202C_200D_200E_202D_206F_206E_206A_200D_200C_202A_202E;

		private List<InternalSkillInstance>.Enumerator _202A_202E_206F_202C_202A_206D_206B_200D_206C_202A_202C_200E_206C_206B_206F_206D_206E_202A_206A_200C_202B_202B_202D_200C_206E_202E_206D_200F_206E_202E_206C_202C_206F_200F_206C_206D_200E_206D_200F_200F_202E;

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
		public _202C_206A_206C_200D_206B_200C_202D_202D_200B_206C_202E_200C_202B_206D_206D_200F_202E_200D_200E_200C_202A_200C_200F_202B_200E_206C_206C_200B_206A_206A_202A_200F_206E_200C_206E_202D_206A_202B_202B_202C_202E(int P_0)
		{
			while (true)
			{
				int num = -864399595;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1487496958)) % 4)
					{
					case 2u:
						break;
					default:
						return;
					case 3u:
						_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = P_0;
						num = ((int)num2 * -1220237995) ^ 0x6CFB4E3D;
						continue;
					case 0u:
						_200B_202B_206E_200C_202C_200D_206F_202E_200F_206A_200C_202C_200B_202D_200F_206E_202D_206C_200B_202C_206C_206A_206E_206C_202B_206D_206E_200E_206E_202D_206E_202E_202E_202A_206D_206E_206D_202C_202D_202E = _202D_206B_200B_206B_202D_206C_206F_206E_202B_206E_200B_206C_202B_202E_200E_202A_206D_206B_206E_200D_200D_206A_200B_206F_202C_206D_206E_202C_202D_202A_206E_200F_202D_200E_206E_202B_202E_202A_202E_200E_202E(_206B_202A_206C_206A_200C_200E_202E_202E_200C_206E_206F_200F_206A_202E_202B_202B_202B_202C_202A_202A_206B_202E_206D_202C_202A_202B_200C_206A_200B_202E_206F_200E_200F_206B_202E_200E_206B_202A_200D_202E());
						num = ((int)num2 * -1685469256) ^ -867867257;
						continue;
					case 1u:
						return;
					}
					break;
				}
			}
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E;
			while (true)
			{
				int num2 = 2001766813;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num2 ^ 0x19355DB)) % 4)
					{
					case 0u:
						break;
					case 2u:
						switch (num)
						{
						default:
							goto IL_006e;
						case -4:
						case -3:
						case 1:
							break;
						case -6:
						case -5:
						case 2:
							try
							{
								if (num != -6)
								{
									while (true)
									{
										int num7 = 376752549;
										while (true)
										{
											switch ((num3 = (uint)(num7 ^ 0x19355DB)) % 4)
											{
											case 0u:
												break;
											case 2u:
											{
												int num8;
												int num9;
												if (num == 2)
												{
													num8 = -247664068;
													num9 = num8;
												}
												else
												{
													num8 = -2146103938;
													num9 = num8;
												}
												num7 = num8 ^ ((int)num3 * -1212367544);
												continue;
											}
											case 1u:
												return;
											default:
												goto end_IL_0107;
											}
											break;
										}
										continue;
										end_IL_0107:
										break;
									}
								}
								try
								{
									return;
								}
								finally
								{
									_200D_200B_206F_200F_200F_202B_206F_202D_202B_202C_202E_206E_206B_206A_206C_200D_206C_206C_206F_206E_206C_206B_202A_206E_206C_206B_206D_206A_200C_202A_206E_202C_202C_202E_206C_206A_206A_200F_206A_206B_202E();
								}
							}
							finally
							{
								_206E_202C_200F_206C_200F_206A_206D_206F_206A_206C_200B_202E_202C_202B_206B_200C_206D_206F_206B_202A_202D_202B_206C_202A_202C_200D_202B_200E_200C_206E_202C_202A_200D_200F_206E_202D_200F_202D_202E_206A_202E();
							}
						case -8:
						case -7:
						case 3:
							try
							{
								if (num != -8)
								{
									while (true)
									{
										int num4 = 549522338;
										while (true)
										{
											switch ((num3 = (uint)(num4 ^ 0x19355DB)) % 4)
											{
											case 2u:
												break;
											case 1u:
											{
												int num5;
												int num6;
												if (num == 3)
												{
													num5 = -2136483612;
													num6 = num5;
												}
												else
												{
													num5 = -1158902909;
													num6 = num5;
												}
												num4 = num5 ^ (int)(num3 * 1875806564);
												continue;
											}
											case 0u:
												return;
											default:
												goto end_IL_0178;
											}
											break;
										}
										continue;
										end_IL_0178:
										break;
									}
								}
								try
								{
									return;
								}
								finally
								{
									_206A_206B_202A_200C_202E_206D_206B_206E_206B_206D_202C_206B_206C_200F_206D_206C_202E_206B_206F_200C_202B_202B_202C_206D_202B_202D_200F_200B_206A_206B_200E_206E_206B_200B_202A_202D_206D_202A_202C_206B_202E();
								}
							}
							finally
							{
								_202E_200C_206B_202D_200E_206D_202C_206E_202C_206C_200C_206C_200D_206A_202D_202C_200F_206C_200C_200C_206B_206D_206B_200D_202D_200B_202B_202E_206B_206B_206E_200F_200C_206F_200F_200E_202D_206E_206C_206F_202E();
							}
						case -9:
						case 4:
							try
							{
								return;
							}
							finally
							{
								_206D_202B_202D_206D_206F_206B_202C_200D_206C_206F_206E_202E_202E_202A_200E_206B_206F_200E_202A_202B_202D_200E_202B_206A_202C_202D_206C_206B_206D_200F_206B_202D_202E_206C_200C_206E_202B_206E_206F_202B_202E();
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
							if (num != -4)
							{
								while (true)
								{
									int num10 = 1763243110;
									while (true)
									{
										switch ((num3 = (uint)(num10 ^ 0x19355DB)) % 4)
										{
										case 2u:
											break;
										case 1u:
										{
											int num11;
											int num12;
											if (num == 1)
											{
												num11 = 779228217;
												num12 = num11;
											}
											else
											{
												num11 = 1847138462;
												num12 = num11;
											}
											num10 = num11 ^ (int)(num3 * 544928941);
											continue;
										}
										case 0u:
											return;
										default:
											goto end_IL_0096;
										}
										break;
									}
									continue;
									end_IL_0096:
									break;
								}
							}
							try
							{
								return;
							}
							finally
							{
								_200D_206E_202A_206D_200B_206A_200B_200D_202E_200C_200D_206A_202A_200B_202D_200E_202D_200B_206A_200B_200D_206F_200F_202D_202D_200C_206E_206D_206B_202C_206B_202D_206A_206B_200E_200D_200D_202A_202C_206E_202E();
							}
						}
						finally
						{
							_202D_202A_202A_200E_206E_202E_206C_202C_206F_202C_200C_202E_202A_206E_202B_202D_202C_206F_206C_206A_202A_200F_206A_200F_206D_200B_200C_202C_202B_206E_200E_206C_202D_200D_202E_202D_206D_206D_202B_202C_202E();
						}
					}
					break;
					IL_006e:
					num2 = ((int)num3 * -274287306) ^ -391492234;
				}
			}
		}

		private bool MoveNext()
		{
			bool result = default(bool);
			try
			{
				int num = _200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E;
				Role role = _202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E;
				int num2;
				Trigger current2 = default(Trigger);
				ItemInstance current5 = default(ItemInstance);
				Trigger current4 = default(Trigger);
				Trigger current = default(Trigger);
				Trigger current3 = default(Trigger);
				switch (num)
				{
				default:
					num2 = -1318721775;
					goto IL_002d;
				case 2:
					goto IL_01a0;
				case 1:
					goto IL_0456;
				case 3:
					goto IL_050a;
				case 0:
					goto IL_068d;
				case 4:
					goto IL_07f6;
					IL_002d:
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num2 ^ -1250069430)) % 63)
						{
						case 55u:
							break;
						default:
							goto end_IL_000f;
						case 10u:
							_206C_202A_202B_200B_206B_200E_202E_206B_206E_206F_206D_202C_202E_202A_200F_200D_206C_206B_206F_206F_200C_206F_200E_206D_202C_206C_202D_200E_202B_202E_200B_202D_202A_206F_206F_200C_206C_200F_200D_202E_202E = _206A_206D_206C_200B_202A_202B_202A_202D_206D_200C_206E_200C_206E_200E_202E_202E_206E_202D_202A_200D_200F_202E_200B_206F_200B_206A_202C_202C_202E_206A_200B_200D_200C_206E_206F_200D_206B_200D_200F_206A_202E.Current;
							num2 = -1948724035;
							continue;
						case 38u:
						{
							int num6;
							int num7;
							if (!_202C_202E_202E_202A_202A_206C_206D_206F_202E_200E_206A_202C_206D_206D_206F_206B_202B_206A_206A_202D_200E_206B_200C_202C_206D_202E_200C_206A_202B_202A_202C_206F_206F_206D_206E_202C_206A_200F_200E_206E_202E(current2.Name, name))
							{
								num6 = 1788283826;
								num7 = num6;
							}
							else
							{
								num6 = 1625828252;
								num7 = num6;
							}
							num2 = num6 ^ (int)(num3 * 1770635064);
							continue;
						}
						case 59u:
							result = false;
							num2 = ((int)num3 * -135446787) ^ -740140911;
							continue;
						case 35u:
							goto IL_01a0;
						case 53u:
							current5 = _206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E.Current;
							num2 = -1054486643;
							continue;
						case 47u:
							goto end_IL_000f;
						case 31u:
							num2 = (int)((num3 * 1793495781) ^ 0xB524280);
							continue;
						case 15u:
							goto end_IL_000f;
						case 5u:
							_202A_202E_206F_202C_202A_206D_206B_200D_206C_202A_202C_200E_206C_206B_206F_206D_206E_202A_206A_200C_202B_202B_202D_200C_206E_202E_206D_200F_206E_202E_206C_202C_206F_200F_206C_206D_200E_206D_200F_200F_202E = role.InternalSkills.GetEnumerator();
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -7;
							num2 = ((int)num3 * -195557366) ^ -2096189867;
							continue;
						case 40u:
							_200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E = current2;
							num2 = (int)(num3 * 438535297) ^ -560850228;
							continue;
						case 46u:
							_202D_202A_202A_200E_206E_202E_206C_202C_206F_202C_200C_202E_202A_206E_202B_202D_202C_206F_206C_206A_202A_200F_206A_200F_206D_200B_200C_202C_202B_206E_200E_206C_202D_200D_202E_202D_206D_206D_202B_202C_202E();
							num2 = ((int)num3 * -635189985) ^ -1209400148;
							continue;
						case 45u:
							current4 = _200E_200F_202E_206E_206C_206F_202C_206A_206D_202A_200B_206A_206A_200E_202B_202C_202E_200F_202C_200E_202C_206C_200F_200E_202C_200F_202B_206F_202C_206A_202C_200D_200E_202D_206F_206E_206A_200D_200C_202A_202E.Current;
							num2 = -1793221876;
							continue;
						case 11u:
						{
							int num12;
							int num13;
							if (_202C_202E_202E_202A_202A_206C_206D_206F_202E_200E_206A_202C_206D_206D_206F_206B_202B_206A_206A_202D_200E_206B_200C_202C_206D_202E_200C_206A_202B_202A_202C_206F_206F_206D_206E_202C_206A_200F_200E_206E_202E(current4.Name, name))
							{
								num12 = -1408756509;
								num13 = num12;
							}
							else
							{
								num12 = -97916444;
								num13 = num12;
							}
							num2 = num12 ^ ((int)num3 * -1701685143);
							continue;
						}
						case 14u:
							_200D_206A_202C_200E_206F_206B_202A_202D_200D_200E_202B_202A_206E_206E_202E_206B_200E_200F_202C_202D_202A_206C_202C_202A_200E_200C_206B_206B_206C_200D_206B_202A_202A_202D_200B_206E_206F_200F_202A_206A_202E = current5.AllTriggers.GetEnumerator();
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -4;
							num2 = ((int)num3 * -732041092) ^ 0x6BF9759B;
							continue;
						case 39u:
							_206E_202C_200F_206C_200F_206A_206D_206F_206A_206C_200B_202E_202C_202B_206B_200C_206D_206F_206B_202A_202D_202B_206C_202A_202C_200D_202B_200E_200C_206E_202C_202A_200D_200F_206E_202D_200F_202D_202E_206A_202E();
							num2 = (int)(num3 * 289253255) ^ -97487270;
							continue;
						case 19u:
							_200E_200F_202E_206E_206C_206F_202C_206A_206D_202A_200B_206A_206A_200E_202B_202C_202E_200F_202C_200E_202C_206C_200F_200E_202C_200F_202B_206F_202C_206A_202C_200D_200E_202D_206F_206E_206A_200D_200C_202A_202E = role.EquippedTitle.Title.Triggers.GetEnumerator();
							num2 = ((int)num3 * -620920515) ^ -2052662991;
							continue;
						case 61u:
							_200E_200F_202E_206E_206C_206F_202C_206A_206D_202A_200B_206A_206A_200E_202B_202C_202E_200F_202C_200E_202C_206C_200F_200E_202C_200F_202B_206F_202C_206A_202C_200D_200E_202D_206F_206E_206A_200D_200C_202A_202E = _206C_202A_202B_200B_206B_200E_202E_206B_206E_206F_206D_202C_202E_202A_200F_200D_206C_206B_206F_206F_200C_206F_200E_206D_202C_206C_202D_200E_202B_202E_200B_202D_202A_206F_206F_200C_206C_200F_200D_202E_202E.Skill.Triggers.GetEnumerator();
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -6;
							num2 = (int)(num3 * 1933270796) ^ -1742242504;
							continue;
						case 21u:
							_206A_206B_202A_200C_202E_206D_206B_206E_206B_206D_202C_206B_206C_200F_206D_206C_202E_206B_206F_200C_202B_202B_202C_206D_202B_202D_200F_200B_206A_206B_200E_206E_206B_200B_202A_202D_206D_202A_202C_206B_202E();
							_200E_200F_202E_206E_206C_206F_202C_206A_206D_202A_200B_206A_206A_200E_202B_202C_202E_200F_202C_200E_202C_206C_200F_200E_202C_200F_202B_206F_202C_206A_202C_200D_200E_202D_206F_206E_206A_200D_200C_202A_202E = default(List<Trigger>.Enumerator);
							_200C_202A_206B_202A_200C_206B_202A_202B_206D_200F_206D_200E_200F_202C_200D_200D_200B_202C_206D_206B_202B_206B_202A_200C_200E_202B_202B_206E_206B_202E_200C_206E_200C_206B_200E_200B_200F_200D_200D_200F_202E = null;
							num2 = ((int)num3 * -1585737877) ^ 0x1CEA63F1;
							continue;
						case 41u:
							num2 = (int)(num3 * 1260590565) ^ -130381524;
							continue;
						case 57u:
							_200D_206A_202C_200E_206F_206B_202A_202D_200D_200E_202B_202A_206E_206E_202E_206B_200E_200F_202C_202D_202A_206C_202C_202A_200E_200C_206B_206B_206C_200D_206B_202A_202A_202D_200B_206E_206F_200F_202A_206A_202E = null;
							num2 = (int)(num3 * 431251270) ^ -613134570;
							continue;
						case 33u:
							_206D_202B_202D_206D_206F_206B_202C_200D_206C_206F_206E_202E_202E_202A_200E_206B_206F_200E_202A_202B_202D_200E_202B_206A_202C_202D_206C_206B_206D_200F_206B_202D_202E_206C_200C_206E_202B_206E_206F_202B_202E();
							_200E_200F_202E_206E_206C_206F_202C_206A_206D_202A_200B_206A_206A_200E_202B_202C_202E_200F_202C_200E_202C_206C_200F_200E_202C_200F_202B_206F_202C_206A_202C_200D_200E_202D_206F_206E_206A_200D_200C_202A_202E = default(List<Trigger>.Enumerator);
							num2 = ((int)num3 * -1687927965) ^ 0x2F31ABF4;
							continue;
						case 0u:
							_202E_200C_206B_202D_200E_206D_202C_206E_202C_206C_200C_206C_200D_206A_202D_202C_200F_206C_200C_200C_206B_206D_206B_200D_202D_200B_202B_202E_206B_206B_206E_200F_200C_206F_200F_200E_202D_206E_206C_206F_202E();
							num2 = (int)((num3 * 730396123) ^ 0x58B0450F);
							continue;
						case 16u:
							goto IL_03f3;
						case 44u:
							goto IL_0414;
						case 4u:
							goto IL_0435;
						case 50u:
							goto IL_0456;
						case 48u:
							_206C_202A_202B_200B_206B_200E_202E_206B_206E_206F_206D_202C_202E_202A_200F_200D_206C_206B_206F_206F_200C_206F_200E_206D_202C_206C_202D_200E_202B_202E_200B_202D_202A_206F_206F_200C_206C_200F_200D_202E_202E = null;
							num2 = (int)(num3 * 1027741239) ^ -1466603516;
							continue;
						case 7u:
							goto IL_0482;
						case 36u:
							_200E_200F_202E_206E_206C_206F_202C_206A_206D_202A_200B_206A_206A_200E_202B_202C_202E_200F_202C_200E_202C_206C_200F_200E_202C_200F_202B_206F_202C_206A_202C_200D_200E_202D_206F_206E_206A_200D_200C_202A_202E = _200C_202A_206B_202A_200C_206B_202A_202B_206D_200F_206D_200E_200F_202C_200D_200D_200B_202C_206D_206B_202B_206B_202A_200C_200E_202B_202B_206E_206B_202E_200C_206E_200C_206B_200E_200B_200F_200D_200D_200F_202E.InternalSkill.Triggers.GetEnumerator();
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -8;
							num2 = ((int)num3 * -300897199) ^ 0x75CDD637;
							continue;
						case 24u:
							_200D_206E_202A_206D_200B_206A_200B_200D_202E_200C_200D_206A_202A_200B_202D_200E_202D_200B_206A_200B_200D_206F_200F_202D_202D_200C_206E_206D_206B_202C_206B_202D_206A_206B_200E_200D_200D_202A_202C_206E_202E();
							num2 = ((int)num3 * -30375700) ^ -636649701;
							continue;
						case 23u:
							goto end_IL_000f;
						case 1u:
							goto IL_050a;
						case 37u:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 2;
							result = true;
							goto end_IL_000f;
						case 29u:
							goto IL_053d;
						case 25u:
							_200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E = current;
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 1;
							result = true;
							num2 = (int)(num3 * 959645731) ^ -443750140;
							continue;
						case 3u:
							_206A_206D_206C_200B_202A_202B_202A_202D_206D_200C_206E_200C_206E_200E_202E_202E_206E_202D_202A_200D_200F_202E_200B_206F_200B_206A_202C_202C_202E_206A_200B_200D_200C_206E_206F_200D_206B_200D_200F_206A_202E = default(List<SkillInstance>.Enumerator);
							num2 = ((int)num3 * -91586633) ^ 0x4C964B18;
							continue;
						case 26u:
							_200D_200B_206F_200F_200F_202B_206F_202D_202B_202C_202E_206E_206B_206A_206C_200D_206C_206C_206F_206E_206C_206B_202A_206E_206C_206B_206D_206A_200C_202A_206E_202C_202C_202E_206C_206A_206A_200F_206A_206B_202E();
							num2 = (int)(num3 * 1690599698) ^ -1183488799;
							continue;
						case 51u:
							num2 = (int)(num3 * 371873619) ^ -759565265;
							continue;
						case 54u:
							_200C_202A_206B_202A_200C_206B_202A_202B_206D_200F_206D_200E_200F_202C_200D_200D_200B_202C_206D_206B_202B_206B_202A_200C_200E_202B_202B_206E_206B_202E_200C_206E_200C_206B_200E_200B_200F_200D_200D_200F_202E = _202A_202E_206F_202C_202A_206D_206B_200D_206C_202A_202C_200E_206C_206B_206F_206D_206E_202A_206A_200C_202B_202B_202D_200C_206E_202E_206D_200F_206E_202E_206C_202C_206F_200F_206C_206D_200E_206D_200F_200F_202E.Current;
							num2 = -1846355549;
							continue;
						case 18u:
						{
							int num10;
							int num11;
							if (role.EquippedTitle == null)
							{
								num10 = 575307741;
								num11 = num10;
							}
							else
							{
								num10 = 793007422;
								num11 = num10;
							}
							num2 = num10 ^ ((int)num3 * -1454987582);
							continue;
						}
						case 32u:
							_200E_200F_202E_206E_206C_206F_202C_206A_206D_202A_200B_206A_206A_200E_202B_202C_202E_200F_202C_200E_202C_206C_200F_200E_202C_200F_202B_206F_202C_206A_202C_200D_200E_202D_206F_206E_206A_200D_200C_202A_202E = default(List<Trigger>.Enumerator);
							num2 = (int)(num3 * 1878864183) ^ -1298075501;
							continue;
						case 2u:
							_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E = role.Equipment.GetEnumerator();
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -3;
							num2 = ((int)num3 * -885086573) ^ -414454451;
							continue;
						case 58u:
							_200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E = current4;
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 4;
							num2 = ((int)num3 * -1121606208) ^ 0x77DAC37B;
							continue;
						case 27u:
							num2 = (int)((num3 * 1426820858) ^ 0x2E4EE369);
							continue;
						case 13u:
							goto IL_068d;
						case 49u:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -9;
							num2 = (int)((num3 * 1846989462) ^ 0x685AE6E5);
							continue;
						case 6u:
							result = true;
							num2 = (int)((num3 * 422802554) ^ 0x1386F001);
							continue;
						case 30u:
							result = false;
							num2 = -578907431;
							continue;
						case 28u:
							current = _200D_206A_202C_200E_206F_206B_202A_202D_200D_200E_202B_202A_206E_206E_202E_206B_200E_200F_202C_202D_202A_206C_202C_202A_200E_200C_206B_206B_206C_200D_206B_202A_202A_202D_200B_206E_206F_200F_202A_206A_202E.Current;
							num2 = -1450683307;
							continue;
						case 43u:
							goto IL_06f1;
						case 62u:
							num2 = (int)(num3 * 1720303640) ^ -2054285494;
							continue;
						case 42u:
							_202A_202E_206F_202C_202A_206D_206B_200D_206C_202A_202C_200E_206C_206B_206F_206D_206E_202A_206A_200C_202B_202B_202D_200C_206E_202E_206D_200F_206E_202E_206C_202C_206F_200F_206C_206D_200E_206D_200F_200F_202E = default(List<InternalSkillInstance>.Enumerator);
							num2 = (int)(num3 * 458749822) ^ -1381558445;
							continue;
						case 52u:
							_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E = default(List<ItemInstance>.Enumerator);
							_206A_206D_206C_200B_202A_202B_202A_202D_206D_200C_206E_200C_206E_200E_202E_202E_206E_202D_202A_200D_200F_202E_200B_206F_200B_206A_202C_202C_202E_206A_200B_200D_200C_206E_206F_200D_206B_200D_200F_206A_202E = role.Skills.GetEnumerator();
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -5;
							num2 = ((int)num3 * -1935552307) ^ 0x5E989937;
							continue;
						case 60u:
							_200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E = current3;
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 3;
							result = true;
							num2 = (int)(num3 * 595077705) ^ -1530307950;
							continue;
						case 8u:
							goto IL_07b4;
						case 20u:
							goto IL_07d5;
						case 17u:
							goto IL_07f6;
						case 34u:
							goto IL_0808;
						case 9u:
						{
							int num8;
							int num9;
							if (_202C_202E_202E_202A_202A_206C_206D_206F_202E_200E_206A_202C_206D_206D_206F_206B_202B_206A_206A_202D_200E_206B_200C_202C_206D_202E_200C_206A_202B_202A_202C_206F_206F_206D_206E_202C_206A_200F_200E_206E_202E(current3.Name, name))
							{
								num8 = 1705913694;
								num9 = num8;
							}
							else
							{
								num8 = 526082667;
								num9 = num8;
							}
							num2 = num8 ^ ((int)num3 * -1192476365);
							continue;
						}
						case 56u:
							goto end_IL_000f;
						case 12u:
						{
							int num4;
							int num5;
							if (!_202C_202E_202E_202A_202A_206C_206D_206F_202E_200E_206A_202C_206D_206D_206F_206B_202B_206A_206A_202D_200E_206B_200C_202C_206D_202E_200C_206A_202B_202A_202C_206F_206F_206D_206E_202C_206A_200F_200E_206E_202E(current.Name, name))
							{
								num4 = -1810482961;
								num5 = num4;
							}
							else
							{
								num4 = -494147257;
								num5 = num4;
							}
							num2 = num4 ^ (int)(num3 * 342680636);
							continue;
						}
						case 22u:
							goto end_IL_000f;
						}
						break;
						IL_0808:
						current3 = _200E_200F_202E_206E_206C_206F_202C_206A_206D_202A_200B_206A_206A_200E_202B_202C_202E_200F_202C_200E_202C_206C_200F_200E_202C_200F_202B_206F_202C_206A_202C_200D_200E_202D_206F_206E_206A_200D_200C_202A_202E.Current;
						int num14;
						if (_200C_202A_206B_202A_200C_206B_202A_202B_206D_200F_206D_200E_200F_202C_200D_200D_200B_202C_206D_206B_202B_206B_202A_200C_200E_202B_202B_206E_206B_202E_200C_206E_200C_206B_200E_200B_200F_200D_200D_200F_202E.level < current3.Level)
						{
							num2 = -485276530;
							num14 = num2;
						}
						else
						{
							num2 = -1337175091;
							num14 = num2;
						}
						continue;
						IL_06f1:
						current2 = _200E_200F_202E_206E_206C_206F_202C_206A_206D_202A_200B_206A_206A_200E_202B_202C_202E_200F_202C_200E_202C_206C_200F_200E_202C_200F_202B_206F_202C_206A_202C_200D_200E_202D_206F_206E_206A_200D_200C_202A_202E.Current;
						int num15;
						if (_206C_202A_202B_200B_206B_200E_202E_206B_206E_206F_206D_202C_202E_202A_200F_200D_206C_206B_206F_206F_200C_206F_200E_206D_202C_206C_202D_200E_202B_202E_200B_202D_202A_206F_206F_200C_206C_200F_200D_202E_202E.level >= current2.Level)
						{
							num2 = -1290578474;
							num15 = num2;
						}
						else
						{
							num2 = -516835950;
							num15 = num2;
						}
						continue;
						IL_0482:
						int num16;
						if (!_202A_202E_206F_202C_202A_206D_206B_200D_206C_202A_202C_200E_206C_206B_206F_206D_206E_202A_206A_200C_202B_202B_202D_200C_206E_202E_206D_200F_206E_202E_206C_202C_206F_200F_206C_206D_200E_206D_200F_200F_202E.MoveNext())
						{
							num2 = -1217019883;
							num16 = num2;
						}
						else
						{
							num2 = -1722783852;
							num16 = num2;
						}
						continue;
						IL_07d5:
						int num17;
						if (!_200E_200F_202E_206E_206C_206F_202C_206A_206D_202A_200B_206A_206A_200E_202B_202C_202E_200F_202C_200E_202C_206C_200F_200E_202C_200F_202B_206F_202C_206A_202C_200D_200E_202D_206F_206E_206A_200D_200C_202A_202E.MoveNext())
						{
							num2 = -1335938173;
							num17 = num2;
						}
						else
						{
							num2 = -333608846;
							num17 = num2;
						}
						continue;
						IL_0414:
						int num18;
						if (!_206B_202E_206F_202B_206D_202E_202A_206F_206F_206C_202A_206C_206B_206E_202B_200B_206B_200B_200D_202C_206A_200C_200B_206A_200E_200D_206B_202D_206E_206A_202D_206F_200D_200F_202D_200B_200C_206B_200E_202A_202E((IEnumerator)_200D_206A_202C_200E_206F_206B_202A_202D_200D_200E_202B_202A_206E_206E_202E_206B_200E_200F_202C_202D_202A_206C_202C_202A_200E_200C_206B_206B_206C_200D_206B_202A_202A_202D_200B_206E_206F_200F_202A_206A_202E))
						{
							num2 = -1348236161;
							num18 = num2;
						}
						else
						{
							num2 = -1945309162;
							num18 = num2;
						}
						continue;
						IL_053d:
						int num19;
						if (!_200E_200F_202E_206E_206C_206F_202C_206A_206D_202A_200B_206A_206A_200E_202B_202C_202E_200F_202C_200E_202C_206C_200F_200E_202C_200F_202B_206F_202C_206A_202C_200D_200E_202D_206F_206E_206A_200D_200C_202A_202E.MoveNext())
						{
							num2 = -669459983;
							num19 = num2;
						}
						else
						{
							num2 = -223353345;
							num19 = num2;
						}
						continue;
						IL_07b4:
						int num20;
						if (!_206A_206D_206C_200B_202A_202B_202A_202D_206D_200C_206E_200C_206E_200E_202E_202E_206E_202D_202A_200D_200F_202E_200B_206F_200B_206A_202C_202C_202E_206A_200B_200D_200C_206E_206F_200D_206B_200D_200F_206A_202E.MoveNext())
						{
							num2 = -12206371;
							num20 = num2;
						}
						else
						{
							num2 = -1249311543;
							num20 = num2;
						}
						continue;
						IL_03f3:
						int num21;
						if (!_200E_200F_202E_206E_206C_206F_202C_206A_206D_202A_200B_206A_206A_200E_202B_202C_202E_200F_202C_200E_202C_206C_200F_200E_202C_200F_202B_206F_202C_206A_202C_200D_200E_202D_206F_206E_206A_200D_200C_202A_202E.MoveNext())
						{
							num2 = -2101440413;
							num21 = num2;
						}
						else
						{
							num2 = -1294079440;
							num21 = num2;
						}
						continue;
						IL_0435:
						int num22;
						if (_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E.MoveNext())
						{
							num2 = -2132657759;
							num22 = num2;
						}
						else
						{
							num2 = -1615143873;
							num22 = num2;
						}
					}
					goto default;
					IL_07f6:
					_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -9;
					num2 = -775431598;
					goto IL_002d;
					IL_068d:
					_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
					num2 = -1655727505;
					goto IL_002d;
					IL_050a:
					_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -8;
					num2 = -485276530;
					goto IL_002d;
					IL_0456:
					_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -4;
					num2 = -2026562645;
					goto IL_002d;
					IL_01a0:
					_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -6;
					num2 = -516835950;
					goto IL_002d;
					end_IL_000f:
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
			((IDisposable)_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E/*cast due to .constrained prefix*/).Dispose();
		}

		private void _200D_206E_202A_206D_200B_206A_200B_200D_202E_200C_200D_206A_202A_200B_202D_200E_202D_200B_206A_200B_200D_206F_200F_202D_202D_200C_206E_206D_206B_202C_206B_202D_206A_206B_200E_200D_200D_202A_202C_206E_202E()
		{
			_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -3;
			if (_200D_206A_202C_200E_206F_206B_202A_202D_200D_200E_202B_202A_206E_206E_202E_206B_200E_200F_202C_202D_202A_206C_202C_202A_200E_200C_206B_206B_206C_200D_206B_202A_202A_202D_200B_206E_206F_200F_202A_206A_202E == null)
			{
				return;
			}
			while (true)
			{
				int num = -1359783029;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -2100747029)) % 3)
					{
					case 2u:
						break;
					default:
						return;
					case 1u:
						goto IL_0032;
					case 0u:
						return;
					}
					break;
					IL_0032:
					_202C_202A_200C_202D_206D_206C_202D_206E_206D_200E_206B_202E_200E_200D_206D_200E_206E_200D_206D_206F_202C_200D_202D_200E_206A_200F_200C_200B_206B_202D_206E_206B_202D_200D_206D_202E_202E_206D_202E_206B_202E((IDisposable)_200D_206A_202C_200E_206F_206B_202A_202D_200D_200E_202B_202A_206E_206E_202E_206B_200E_200F_202C_202D_202A_206C_202C_202A_200E_200C_206B_206B_206C_200D_206B_202A_202A_202D_200B_206E_206F_200F_202A_206A_202E);
					num = ((int)num2 * -442538190) ^ -161504087;
				}
			}
		}

		private void _206E_202C_200F_206C_200F_206A_206D_206F_206A_206C_200B_202E_202C_202B_206B_200C_206D_206F_206B_202A_202D_202B_206C_202A_202C_200D_202B_200E_200C_206E_202C_202A_200D_200F_206E_202D_200F_202D_202E_206A_202E()
		{
			_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
			while (true)
			{
				int num = 274993138;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x37ABDEE8)) % 3)
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
					((IDisposable)_206A_206D_206C_200B_202A_202B_202A_202D_206D_200C_206E_200C_206E_200E_202E_202E_206E_202D_202A_200D_200F_202E_200B_206F_200B_206A_202C_202C_202E_206A_200B_200D_200C_206E_206F_200D_206B_200D_200F_206A_202E/*cast due to .constrained prefix*/).Dispose();
					num = ((int)num2 * -631844684) ^ 0x2689A8E1;
				}
			}
		}

		private void _200D_200B_206F_200F_200F_202B_206F_202D_202B_202C_202E_206E_206B_206A_206C_200D_206C_206C_206F_206E_206C_206B_202A_206E_206C_206B_206D_206A_200C_202A_206E_202C_202C_202E_206C_206A_206A_200F_206A_206B_202E()
		{
			_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -5;
			while (true)
			{
				int num = 968798114;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x116DD8E7)) % 3)
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
					((IDisposable)_200E_200F_202E_206E_206C_206F_202C_206A_206D_202A_200B_206A_206A_200E_202B_202C_202E_200F_202C_200E_202C_206C_200F_200E_202C_200F_202B_206F_202C_206A_202C_200D_200E_202D_206F_206E_206A_200D_200C_202A_202E/*cast due to .constrained prefix*/).Dispose();
					num = ((int)num2 * -390962619) ^ 0x5BE17414;
				}
			}
		}

		private void _202E_200C_206B_202D_200E_206D_202C_206E_202C_206C_200C_206C_200D_206A_202D_202C_200F_206C_200C_200C_206B_206D_206B_200D_202D_200B_202B_202E_206B_206B_206E_200F_200C_206F_200F_200E_202D_206E_206C_206F_202E()
		{
			_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
			((IDisposable)_202A_202E_206F_202C_202A_206D_206B_200D_206C_202A_202C_200E_206C_206B_206F_206D_206E_202A_206A_200C_202B_202B_202D_200C_206E_202E_206D_200F_206E_202E_206C_202C_206F_200F_206C_206D_200E_206D_200F_200F_202E/*cast due to .constrained prefix*/).Dispose();
		}

		private void _206A_206B_202A_200C_202E_206D_206B_206E_206B_206D_202C_206B_206C_200F_206D_206C_202E_206B_206F_200C_202B_202B_202C_206D_202B_202D_200F_200B_206A_206B_200E_206E_206B_200B_202A_202D_206D_202A_202C_206B_202E()
		{
			_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -7;
			((IDisposable)_200E_200F_202E_206E_206C_206F_202C_206A_206D_202A_200B_206A_206A_200E_202B_202C_202E_200F_202C_200E_202C_206C_200F_200E_202C_200F_202B_206F_202C_206A_202C_200D_200E_202D_206F_206E_206A_200D_200C_202A_202E/*cast due to .constrained prefix*/).Dispose();
		}

		private void _206D_202B_202D_206D_206F_206B_202C_200D_206C_206F_206E_202E_202E_202A_200E_206B_206F_200E_202A_202B_202D_200E_202B_206A_202C_202D_206C_206B_206D_200F_206B_202D_202E_206C_200C_206E_202B_206E_206F_202B_202E()
		{
			_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
			((IDisposable)_200E_200F_202E_206E_206C_206F_202C_206A_206D_202A_200B_206A_206A_200E_202B_202C_202E_200F_202C_200E_202C_206C_200F_200E_202C_200F_202B_206F_202C_206A_202C_200D_200E_202D_206F_206E_206A_200D_200C_202A_202E/*cast due to .constrained prefix*/).Dispose();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw _206F_206F_206C_206C_206A_202C_206B_200C_206B_200B_202C_206B_200B_200C_200E_200C_206E_206A_200E_202C_200E_200B_206E_206F_200D_202A_202E_206D_200E_206E_206C_206B_206A_200D_206B_200E_202D_200B_202A_202A_202E();
		}

		[DebuggerHidden]
		IEnumerator<Trigger> IEnumerable<Trigger>.GetEnumerator()
		{
			if (_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E == -2)
			{
				goto IL_000a;
			}
			goto IL_0048;
			IL_000a:
			int num = 916546705;
			goto IL_000f;
			IL_000f:
			_202C_206A_206C_200D_206B_200C_202D_202D_200B_206C_202E_200C_202B_206D_206D_200F_202E_200D_200E_200C_202A_200C_200F_202B_200E_206C_206C_200B_206A_206A_202A_200F_206E_200C_206E_202D_206A_202B_202B_202C_202E obj = default(_202C_206A_206C_200D_206B_200C_202D_202D_200B_206C_202E_200C_202B_206D_206D_200F_202E_200D_200E_200C_202A_200C_200F_202B_200E_206C_206C_200B_206A_206A_202A_200F_206E_200C_206E_202D_206A_202B_202B_202C_202E);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2355B86F)) % 9)
				{
				case 5u:
					break;
				case 7u:
					goto IL_0048;
				case 0u:
					obj._202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E = _202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E;
					num = (int)((num2 * 1717893272) ^ 0x70EE954E);
					continue;
				case 2u:
					obj.name = _202B_206F_200C_202E_206C_202E_206E_206A_200F_206D_206D_200C_200E_202C_200B_206E_200C_206B_200F_206B_200C_200D_200B_200E_202A_202C_206A_200B_202A_202E_206D_200C_202A_200C_200D_200C_202D_202E_202B_200D_202E;
					num = 2045500575;
					continue;
				case 3u:
					_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 0;
					num = ((int)num2 * -868555555) ^ -573095210;
					continue;
				case 4u:
					obj = this;
					num = ((int)num2 * -395830123) ^ 0x1622EB31;
					continue;
				case 6u:
					num = ((int)num2 * -790587783) ^ 0x57A0A91;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (_200B_202B_206E_200C_202C_200D_206F_202E_200F_206A_200C_202C_200B_202D_200F_206E_202D_206C_200B_202C_206C_206A_206E_206C_202B_206D_206E_200E_206E_202D_206E_202E_202E_202A_206D_206E_206D_202C_202D_202E == _202D_206B_200B_206B_202D_206C_206F_206E_202B_206E_200B_206C_202B_202E_200E_202A_206D_206B_206E_200D_200D_206A_200B_206F_202C_206D_206E_202C_202D_202A_206E_200F_202D_200E_206E_202B_202E_202A_202E_200E_202E(_206B_202A_206C_206A_200C_200E_202E_202E_200C_206E_206F_200F_206A_202E_202B_202B_202B_202C_202A_202A_206B_202E_206D_202C_202A_202B_200C_206A_200B_202E_206F_200E_200F_206B_202E_200E_206B_202A_200D_202E()))
					{
						num3 = 110842845;
						num4 = num3;
					}
					else
					{
						num3 = 1160351510;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1211546435);
					continue;
				}
				default:
					return obj;
				}
				break;
			}
			goto IL_000a;
			IL_0048:
			obj = new _202C_206A_206C_200D_206B_200C_202D_202D_200B_206C_202E_200C_202B_206D_206D_200F_202E_200D_200E_200C_202A_200C_200F_202B_200E_206C_206C_200B_206A_206A_202A_200F_206E_200C_206E_202D_206A_202B_202B_202C_202E(0);
			num = 4654070;
			goto IL_000f;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<Trigger>)this).GetEnumerator();
		}

		static Thread _206B_202A_206C_206A_200C_200E_202E_202E_200C_206E_206F_200F_206A_202E_202B_202B_202B_202C_202A_202A_206B_202E_206D_202C_202A_202B_200C_206A_200B_202E_206F_200E_200F_206B_202E_200E_206B_202A_200D_202E()
		{
			return Thread.CurrentThread;
		}

		static int _202D_206B_200B_206B_202D_206C_206F_206E_202B_206E_200B_206C_202B_202E_200E_202A_206D_206B_206E_200D_200D_206A_200B_206F_202C_206D_206E_202C_202D_202A_206E_200F_202D_200E_206E_202B_202E_202A_202E_200E_202E(Thread P_0)
		{
			return P_0.ManagedThreadId;
		}

		static bool _202C_202E_202E_202A_202A_206C_206D_206F_202E_200E_206A_202C_206D_206D_206F_206B_202B_206A_206A_202D_200E_206B_200C_202C_206D_202E_200C_206A_202B_202A_202C_206F_206F_206D_206E_202C_206A_200F_200E_206E_202E(string P_0, string P_1)
		{
			return P_0 == P_1;
		}

		static bool _206B_202E_206F_202B_206D_202E_202A_206F_206F_206C_202A_206C_206B_206E_202B_200B_206B_200B_200D_202C_206A_200C_200B_206A_200E_200D_206B_202D_206E_206A_202D_206F_200D_200F_202D_200B_200C_206B_200E_202A_202E(IEnumerator P_0)
		{
			return P_0.MoveNext();
		}

		static void _202C_202A_200C_202D_206D_206C_202D_206E_206D_200E_206B_202E_200E_200D_206D_200E_206E_200D_206D_206F_202C_200D_202D_200E_206A_200F_200C_200B_206B_202D_206E_206B_202D_200D_206D_202E_202E_206D_202E_206B_202E(IDisposable P_0)
		{
			P_0.Dispose();
		}

		static NotSupportedException _206F_206F_206C_206C_206A_202C_206B_200C_206B_200B_202C_206B_200B_200C_200E_200C_206E_206A_200E_202C_200E_200B_206E_206F_200D_202A_202E_206D_200E_206E_206C_206B_206A_200D_206B_200E_202D_200B_202A_202A_202E()
		{
			return new NotSupportedException();
		}
	}

	[CompilerGenerated]
	private sealed class _206C_200B_206C_200C_200D_200E_206C_206C_206C_202C_202E_200B_202B_206E_206D_206E_202E_206F_202E_202B_206F_200E_200D_200F_202B_206B_206B_200D_206B_202C_200B_200B_206A_200F_206B_200E_200C_206B_200E_202D_202E : IEnumerable<Trigger>, IEnumerator<Trigger>, IEnumerator, IDisposable, IEnumerable
	{
		private int _200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E;

		private Trigger _200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E;

		private int _200B_202B_206E_200C_202C_200D_206F_202E_200F_206A_200C_202C_200B_202D_200F_206E_202D_206C_200B_202C_206C_206A_206E_206C_202B_206D_206E_200E_206E_202D_206E_202E_202E_202A_206D_206E_206D_202C_202D_202E;

		public Role _202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E;

		private SkillInstance _206C_202A_202B_200B_206B_200E_202E_206B_206E_206F_206D_202C_202E_202A_200F_200D_206C_206B_206F_206F_200C_206F_200E_206D_202C_206C_202D_200E_202B_202E_200B_202D_202A_206F_206F_200C_206C_200F_200D_202E_202E;

		private InternalSkillInstance _200C_202A_206B_202A_200C_206B_202A_202B_206D_200F_206D_200E_200F_202C_200D_200D_200B_202C_206D_206B_202B_206B_202A_200C_200E_202B_202B_206E_206B_202E_200C_206E_200C_206B_200E_200B_200F_200D_200D_200F_202E;

		private List<ItemInstance>.Enumerator _206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E;

		private IEnumerator<Trigger> _200D_206A_202C_200E_206F_206B_202A_202D_200D_200E_202B_202A_206E_206E_202E_206B_200E_200F_202C_202D_202A_206C_202C_202A_200E_200C_206B_206B_206C_200D_206B_202A_202A_202D_200B_206E_206F_200F_202A_206A_202E;

		private List<SkillInstance>.Enumerator _206A_206D_206C_200B_202A_202B_202A_202D_206D_200C_206E_200C_206E_200E_202E_202E_206E_202D_202A_200D_200F_202E_200B_206F_200B_206A_202C_202C_202E_206A_200B_200D_200C_206E_206F_200D_206B_200D_200F_206A_202E;

		private List<Trigger>.Enumerator _200E_200F_202E_206E_206C_206F_202C_206A_206D_202A_200B_206A_206A_200E_202B_202C_202E_200F_202C_200E_202C_206C_200F_200E_202C_200F_202B_206F_202C_206A_202C_200D_200E_202D_206F_206E_206A_200D_200C_202A_202E;

		private List<InternalSkillInstance>.Enumerator _202A_202E_206F_202C_202A_206D_206B_200D_206C_202A_202C_200E_206C_206B_206F_206D_206E_202A_206A_200C_202B_202B_202D_200C_206E_202E_206D_200F_206E_202E_206C_202C_206F_200F_206C_206D_200E_206D_200F_200F_202E;

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
		public _206C_200B_206C_200C_200D_200E_206C_206C_206C_202C_202E_200B_202B_206E_206D_206E_202E_206F_202E_202B_206F_200E_200D_200F_202B_206B_206B_200D_206B_202C_200B_200B_206A_200F_206B_200E_200C_206B_200E_202D_202E(int P_0)
		{
			_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = P_0;
			_200B_202B_206E_200C_202C_200D_206F_202E_200F_206A_200C_202C_200B_202D_200F_206E_202D_206C_200B_202C_206C_206A_206E_206C_202B_206D_206E_200E_206E_202D_206E_202E_202E_202A_206D_206E_206D_202C_202D_202E = _200D_206F_200F_200F_206B_202D_206B_200B_200C_202A_200B_200E_200B_200E_206E_200D_202E_200C_200E_202A_202B_206C_200C_202B_200B_202E_202D_206D_202A_206E_202A_206F_206E_202C_206E_202B_202D_206E_206B_200D_202E(_200B_200E_200E_206A_206D_206B_202D_202A_200D_200B_202A_206D_206C_200E_200D_200B_200D_202D_200F_206F_202E_200E_200B_206C_206B_202A_202A_200E_200B_206E_206F_202A_200E_202A_200D_200F_206F_200D_202C_202E());
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E;
			while (true)
			{
				int num2 = -796130977;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num2 ^ -1496309674)) % 4)
					{
					case 0u:
						break;
					case 1u:
						switch (num)
						{
						default:
							goto IL_006e;
						case -4:
						case -3:
						case 1:
							break;
						case -6:
						case -5:
						case 2:
							try
							{
								if (num != -6)
								{
									while (true)
									{
										int num7 = -717783189;
										while (true)
										{
											switch ((num3 = (uint)(num7 ^ -1496309674)) % 4)
											{
											case 2u:
												break;
											case 1u:
											{
												int num8;
												int num9;
												if (num == 2)
												{
													num8 = -1618463354;
													num9 = num8;
												}
												else
												{
													num8 = -769081203;
													num9 = num8;
												}
												num7 = num8 ^ ((int)num3 * -740663497);
												continue;
											}
											case 0u:
												return;
											default:
												goto end_IL_0107;
											}
											break;
										}
										continue;
										end_IL_0107:
										break;
									}
								}
								try
								{
									return;
								}
								finally
								{
									_200D_200B_206F_200F_200F_202B_206F_202D_202B_202C_202E_206E_206B_206A_206C_200D_206C_206C_206F_206E_206C_206B_202A_206E_206C_206B_206D_206A_200C_202A_206E_202C_202C_202E_206C_206A_206A_200F_206A_206B_202E();
								}
							}
							finally
							{
								_206E_202C_200F_206C_200F_206A_206D_206F_206A_206C_200B_202E_202C_202B_206B_200C_206D_206F_206B_202A_202D_202B_206C_202A_202C_200D_202B_200E_200C_206E_202C_202A_200D_200F_206E_202D_200F_202D_202E_206A_202E();
							}
						case -8:
						case -7:
						case 3:
							try
							{
								if (num != -8)
								{
									while (true)
									{
										int num4 = -1994095328;
										while (true)
										{
											switch ((num3 = (uint)(num4 ^ -1496309674)) % 4)
											{
											case 0u:
												break;
											case 2u:
											{
												int num5;
												int num6;
												if (num == 3)
												{
													num5 = -1389314719;
													num6 = num5;
												}
												else
												{
													num5 = -886357161;
													num6 = num5;
												}
												num4 = num5 ^ ((int)num3 * -834891386);
												continue;
											}
											case 1u:
												return;
											default:
												goto end_IL_0178;
											}
											break;
										}
										continue;
										end_IL_0178:
										break;
									}
								}
								try
								{
									return;
								}
								finally
								{
									_206A_206B_202A_200C_202E_206D_206B_206E_206B_206D_202C_206B_206C_200F_206D_206C_202E_206B_206F_200C_202B_202B_202C_206D_202B_202D_200F_200B_206A_206B_200E_206E_206B_200B_202A_202D_206D_202A_202C_206B_202E();
								}
							}
							finally
							{
								_202E_200C_206B_202D_200E_206D_202C_206E_202C_206C_200C_206C_200D_206A_202D_202C_200F_206C_200C_200C_206B_206D_206B_200D_202D_200B_202B_202E_206B_206B_206E_200F_200C_206F_200F_200E_202D_206E_206C_206F_202E();
							}
						case -9:
						case 4:
							try
							{
								return;
							}
							finally
							{
								_206D_202B_202D_206D_206F_206B_202C_200D_206C_206F_206E_202E_202E_202A_200E_206B_206F_200E_202A_202B_202D_200E_202B_206A_202C_202D_206C_206B_206D_200F_206B_202D_202E_206C_200C_206E_202B_206E_206F_202B_202E();
							}
						case -2:
						case -1:
						case 0:
							return;
						}
						goto default;
					case 2u:
						return;
					default:
						try
						{
							if (num != -4)
							{
								while (true)
								{
									int num10 = -1801319177;
									while (true)
									{
										switch ((num3 = (uint)(num10 ^ -1496309674)) % 4)
										{
										case 3u:
											break;
										case 1u:
										{
											int num11;
											int num12;
											if (num == 1)
											{
												num11 = 1907831345;
												num12 = num11;
											}
											else
											{
												num11 = 1442407783;
												num12 = num11;
											}
											num10 = num11 ^ ((int)num3 * -840396973);
											continue;
										}
										case 2u:
											return;
										default:
											goto end_IL_0096;
										}
										break;
									}
									continue;
									end_IL_0096:
									break;
								}
							}
							try
							{
								return;
							}
							finally
							{
								_200D_206E_202A_206D_200B_206A_200B_200D_202E_200C_200D_206A_202A_200B_202D_200E_202D_200B_206A_200B_200D_206F_200F_202D_202D_200C_206E_206D_206B_202C_206B_202D_206A_206B_200E_200D_200D_202A_202C_206E_202E();
							}
						}
						finally
						{
							_202D_202A_202A_200E_206E_202E_206C_202C_206F_202C_200C_202E_202A_206E_202B_202D_202C_206F_206C_206A_202A_200F_206A_200F_206D_200B_200C_202C_202B_206E_200E_206C_202D_200D_202E_202D_206D_206D_202B_202C_202E();
						}
					}
					break;
					IL_006e:
					num2 = ((int)num3 * -2125794404) ^ 0x6156D200;
				}
			}
		}

		private bool MoveNext()
		{
			bool result = default(bool);
			try
			{
				int num = _200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E;
				Role role = _202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E;
				Trigger current3 = default(Trigger);
				Trigger current2 = default(Trigger);
				Trigger current4 = default(Trigger);
				ItemInstance current = default(ItemInstance);
				while (true)
				{
					IL_000e:
					int num2 = 1495434780;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num2 ^ 0x4D5334A7)) % 61)
						{
						case 19u:
							break;
						case 37u:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -6;
							num2 = (int)(num3 * 1905283581) ^ -1914878002;
							continue;
						case 16u:
							_206C_202A_202B_200B_206B_200E_202E_206B_206E_206F_206D_202C_202E_202A_200F_200D_206C_206B_206F_206F_200C_206F_200E_206D_202C_206C_202D_200E_202B_202E_200B_202D_202A_206F_206F_200C_206C_200F_200D_202E_202E = _206A_206D_206C_200B_202A_202B_202A_202D_206D_200C_206E_200C_206E_200E_202E_202E_206E_202D_202A_200D_200F_202E_200B_206F_200B_206A_202C_202C_202E_206A_200B_200D_200C_206E_206F_200D_206B_200D_200F_206A_202E.Current;
							num2 = 2045905221;
							continue;
						case 17u:
							_200E_200F_202E_206E_206C_206F_202C_206A_206D_202A_200B_206A_206A_200E_202B_202C_202E_200F_202C_200E_202C_206C_200F_200E_202C_200F_202B_206F_202C_206A_202C_200D_200E_202D_206F_206E_206A_200D_200C_202A_202E = role.EquippedTitle.Title.Triggers.GetEnumerator();
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -9;
							num2 = ((int)num3 * -1531467462) ^ 0x356653C6;
							continue;
						case 44u:
							_200E_200F_202E_206E_206C_206F_202C_206A_206D_202A_200B_206A_206A_200E_202B_202C_202E_200F_202C_200E_202C_206C_200F_200E_202C_200F_202B_206F_202C_206A_202C_200D_200E_202D_206F_206E_206A_200D_200C_202A_202E = _200C_202A_206B_202A_200C_206B_202A_202B_206D_200F_206D_200E_200F_202C_200D_200D_200B_202C_206D_206B_202B_206B_202A_200C_200E_202B_202B_206E_206B_202E_200C_206E_200C_206B_200E_200B_200F_200D_200D_200F_202E.InternalSkill.Triggers.GetEnumerator();
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -8;
							num2 = ((int)num3 * -1198572150) ^ -1176075457;
							continue;
						case 40u:
							_200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E = current3;
							num2 = ((int)num3 * -820190894) ^ -1817218998;
							continue;
						case 4u:
							_206A_206D_206C_200B_202A_202B_202A_202D_206D_200C_206E_200C_206E_200E_202E_202E_206E_202D_202A_200D_200F_202E_200B_206F_200B_206A_202C_202C_202E_206A_200B_200D_200C_206E_206F_200D_206B_200D_200F_206A_202E = default(List<SkillInstance>.Enumerator);
							_202A_202E_206F_202C_202A_206D_206B_200D_206C_202A_202C_200E_206C_206B_206F_206D_206E_202A_206A_200C_202B_202B_202D_200C_206E_202E_206D_200F_206E_202E_206C_202C_206F_200F_206C_206D_200E_206D_200F_200F_202E = role.InternalSkills.GetEnumerator();
							num2 = (int)((num3 * 657061317) ^ 0x1523F0B0);
							continue;
						case 5u:
						{
							int num13;
							int num14;
							if (_206C_202A_202B_200B_206B_200E_202E_206B_206E_206F_206D_202C_202E_202A_200F_200D_206C_206B_206F_206F_200C_206F_200E_206D_202C_206C_202D_200E_202B_202E_200B_202D_202A_206F_206F_200C_206C_200F_200D_202E_202E.level >= current2.Level)
							{
								num13 = -63213499;
								num14 = num13;
							}
							else
							{
								num13 = -823194372;
								num14 = num13;
							}
							num2 = num13 ^ ((int)num3 * -685035973);
							continue;
						}
						case 34u:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -6;
							num2 = 430089657;
							continue;
						case 7u:
						{
							Trigger current5 = _200E_200F_202E_206E_206C_206F_202C_206A_206D_202A_200B_206A_206A_200E_202B_202C_202E_200F_202C_200E_202C_206C_200F_200E_202C_200F_202B_206F_202C_206A_202C_200D_200E_202D_206F_206E_206A_200D_200C_202A_202E.Current;
							_200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E = current5;
							num2 = 922040989;
							continue;
						}
						case 11u:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 2;
							result = true;
							num2 = ((int)num3 * -772713733) ^ 0x41435BE6;
							continue;
						case 35u:
							_200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E = current4;
							num2 = (int)((num3 * 1002420552) ^ 0x710AF5DC);
							continue;
						case 9u:
							_200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E = current2;
							num2 = (int)((num3 * 782515559) ^ 0x24432C2E);
							continue;
						case 58u:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 1;
							result = true;
							num2 = (int)((num3 * 143551703) ^ 0x737AD);
							continue;
						case 10u:
							_206A_206D_206C_200B_202A_202B_202A_202D_206D_200C_206E_200C_206E_200E_202E_202E_206E_202D_202A_200D_200F_202E_200B_206F_200B_206A_202C_202C_202E_206A_200B_200D_200C_206E_206F_200D_206B_200D_200F_206A_202E = role.Skills.GetEnumerator();
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -5;
							num2 = ((int)num3 * -302740837) ^ 0x78E23A18;
							continue;
						case 3u:
							goto end_IL_0013;
						case 45u:
							_200C_202A_206B_202A_200C_206B_202A_202B_206D_200F_206D_200E_200F_202C_200D_200D_200B_202C_206D_206B_202B_206B_202A_200C_200E_202B_202B_206E_206B_202E_200C_206E_200C_206B_200E_200B_200F_200D_200D_200F_202E = null;
							num2 = (int)(num3 * 1345737504) ^ -695334833;
							continue;
						case 28u:
						{
							int num6;
							if (!_202A_202E_206F_202C_202A_206D_206B_200D_206C_202A_202C_200E_206C_206B_206F_206D_206E_202A_206A_200C_202B_202B_202D_200C_206E_202E_206D_200F_206E_202E_206C_202C_206F_200F_206C_206D_200E_206D_200F_200F_202E.MoveNext())
							{
								num2 = 1801048559;
								num6 = num2;
							}
							else
							{
								num2 = 605596190;
								num6 = num2;
							}
							continue;
						}
						case 42u:
							_206A_206B_202A_200C_202E_206D_206B_206E_206B_206D_202C_206B_206C_200F_206D_206C_202E_206B_206F_200C_202B_202B_202C_206D_202B_202D_200F_200B_206A_206B_200E_206E_206B_200B_202A_202D_206D_202A_202C_206B_202E();
							_200E_200F_202E_206E_206C_206F_202C_206A_206D_202A_200B_206A_206A_200E_202B_202C_202E_200F_202C_200E_202C_206C_200F_200E_202C_200F_202B_206F_202C_206A_202C_200D_200E_202D_206F_206E_206A_200D_200C_202A_202E = default(List<Trigger>.Enumerator);
							num2 = (int)((num3 * 552023298) ^ 0x6D6E211A);
							continue;
						case 14u:
							_200D_200B_206F_200F_200F_202B_206F_202D_202B_202C_202E_206E_206B_206A_206C_200D_206C_206C_206F_206E_206C_206B_202A_206E_206C_206B_206D_206A_200C_202A_206E_202C_202C_202E_206C_206A_206A_200F_206A_206B_202E();
							_200E_200F_202E_206E_206C_206F_202C_206A_206D_202A_200B_206A_206A_200E_202B_202C_202E_200F_202C_200E_202C_206C_200F_200E_202C_200F_202B_206F_202C_206A_202C_200D_200E_202D_206F_206E_206A_200D_200C_202A_202E = default(List<Trigger>.Enumerator);
							num2 = (int)(num3 * 509710432) ^ -56291430;
							continue;
						case 31u:
							goto end_IL_0013;
						case 57u:
						{
							int num15;
							int num16;
							if (_200C_202A_206B_202A_200C_206B_202A_202B_206D_200F_206D_200E_200F_202C_200D_200D_200B_202C_206D_206B_202B_206B_202A_200C_200E_202B_202B_206E_206B_202E_200C_206E_200C_206B_200E_200B_200F_200D_200D_200F_202E.level < current4.Level)
							{
								num15 = -789261666;
								num16 = num15;
							}
							else
							{
								num15 = -282095486;
								num16 = num15;
							}
							num2 = num15 ^ (int)(num3 * 447840757);
							continue;
						}
						case 52u:
							goto IL_03ec;
						case 36u:
							_200C_202A_206B_202A_200C_206B_202A_202B_206D_200F_206D_200E_200F_202C_200D_200D_200B_202C_206D_206B_202B_206B_202A_200C_200E_202B_202B_206E_206B_202E_200C_206E_200C_206B_200E_200B_200F_200D_200D_200F_202E = _202A_202E_206F_202C_202A_206D_206B_200D_206C_202A_202C_200E_206C_206B_206F_206D_206E_202A_206A_200C_202B_202B_202D_200C_206E_202E_206D_200F_206E_202E_206C_202C_206F_200F_206C_206D_200E_206D_200F_200F_202E.Current;
							num2 = 1298403529;
							continue;
						case 23u:
							_202D_202A_202A_200E_206E_202E_206C_202C_206F_202C_200C_202E_202A_206E_202B_202D_202C_206F_206C_206A_202A_200F_206A_200F_206D_200B_200C_202C_202B_206E_200E_206C_202D_200D_202E_202D_206D_206D_202B_202C_202E();
							_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E = default(List<ItemInstance>.Enumerator);
							num2 = ((int)num3 * -543645995) ^ -1714436541;
							continue;
						case 24u:
							switch (num)
							{
							case 2:
								break;
							case 0:
								goto IL_03ec;
							default:
								goto IL_0457;
							case 4:
								goto IL_04cf;
							case 3:
								goto IL_04e1;
							case 1:
								goto IL_06b4;
							}
							goto case 34u;
						case 56u:
							_206C_202A_202B_200B_206B_200E_202E_206B_206E_206F_206D_202C_202E_202A_200F_200D_206C_206B_206F_206F_200C_206F_200E_206D_202C_206C_202D_200E_202B_202E_200B_202D_202A_206F_206F_200C_206C_200F_200D_202E_202E = null;
							num2 = (int)((num3 * 2137212322) ^ 0x2964366B);
							continue;
						case 41u:
							num2 = ((int)num3 * -1275809936) ^ 0x69CEB131;
							continue;
						case 32u:
							current4 = _200E_200F_202E_206E_206C_206F_202C_206A_206D_202A_200B_206A_206A_200E_202B_202C_202E_200F_202C_200E_202C_206C_200F_200E_202C_200F_202B_206F_202C_206A_202C_200D_200E_202D_206F_206E_206A_200D_200C_202A_202E.Current;
							num2 = 1581133595;
							continue;
						case 55u:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 4;
							result = true;
							goto end_IL_0013;
						case 8u:
							goto IL_04cf;
						case 38u:
							goto IL_04e1;
						case 20u:
							_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E = role.Equipment.GetEnumerator();
							num2 = (int)((num3 * 893803705) ^ 0x51C3E344);
							continue;
						case 25u:
							_200D_206E_202A_206D_200B_206A_200B_200D_202E_200C_200D_206A_202A_200B_202D_200E_202D_200B_206A_200B_200D_206F_200F_202D_202D_200C_206E_206D_206B_202C_206B_202D_206A_206B_200E_200D_200D_202A_202C_206E_202E();
							num2 = ((int)num3 * -804170236) ^ 0x1A184FDC;
							continue;
						case 43u:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -3;
							num2 = (int)((num3 * 1876974695) ^ 0x2DF2A82B);
							continue;
						case 33u:
							result = false;
							goto end_IL_0013;
						case 12u:
							num2 = ((int)num3 * -1831010923) ^ -1168154727;
							continue;
						case 18u:
							_202E_200C_206B_202D_200E_206D_202C_206E_202C_206C_200C_206C_200D_206A_202D_202C_200F_206C_200C_200C_206B_206D_206B_200D_202D_200B_202B_202E_206B_206B_206E_200F_200C_206F_200F_200E_202D_206E_206C_206F_202E();
							num2 = (int)((num3 * 429982733) ^ 0x72BC9C6);
							continue;
						case 59u:
						{
							int num12;
							if (_202B_206C_200C_202D_206C_202D_202D_202B_206A_200B_202C_206C_206E_206E_202E_200D_202C_200F_206D_202C_200D_200F_202C_200E_200C_202B_200E_206F_200D_200F_200B_202B_206F_200D_206E_206E_202B_200E_206F_200D_202E((IEnumerator)_200D_206A_202C_200E_206F_206B_202A_202D_200D_200E_202B_202A_206E_206E_202E_206B_200E_200F_202C_202D_202A_206C_202C_202A_200E_200C_206B_206B_206C_200D_206B_202A_202A_202D_200B_206E_206F_200F_202A_206A_202E))
							{
								num2 = 1670895039;
								num12 = num2;
							}
							else
							{
								num2 = 1337456929;
								num12 = num2;
							}
							continue;
						}
						case 21u:
							_206D_202B_202D_206D_206F_206B_202C_200D_206C_206F_206E_202E_202E_202A_200E_206B_206F_200E_202A_202B_202D_200E_202B_206A_202C_202D_206C_206B_206D_200F_206B_202D_202E_206C_200C_206E_202B_206E_206F_202B_202E();
							_200E_200F_202E_206E_206C_206F_202C_206A_206D_202A_200B_206A_206A_200E_202B_202C_202E_200F_202C_200E_202C_206C_200F_200E_202C_200F_202B_206F_202C_206A_202C_200D_200E_202D_206F_206E_206A_200D_200C_202A_202E = default(List<Trigger>.Enumerator);
							num2 = (int)(num3 * 179493093) ^ -1991816028;
							continue;
						case 50u:
							_200E_200F_202E_206E_206C_206F_202C_206A_206D_202A_200B_206A_206A_200E_202B_202C_202E_200F_202C_200E_202C_206C_200F_200E_202C_200F_202B_206F_202C_206A_202C_200D_200E_202D_206F_206E_206A_200D_200C_202A_202E = _206C_202A_202B_200B_206B_200E_202E_206B_206E_206F_206D_202C_202E_202A_200F_200D_206C_206B_206F_206F_200C_206F_200E_206D_202C_206C_202D_200E_202B_202E_200B_202D_202A_206F_206F_200C_206C_200F_200D_202E_202E.Skill.Triggers.GetEnumerator();
							num2 = ((int)num3 * -245027114) ^ 0x6D8364C8;
							continue;
						case 51u:
						{
							_202A_202E_206F_202C_202A_206D_206B_200D_206C_202A_202C_200E_206C_206B_206F_206D_206E_202A_206A_200C_202B_202B_202D_200C_206E_202E_206D_200F_206E_202E_206C_202C_206F_200F_206C_206D_200E_206D_200F_200F_202E = default(List<InternalSkillInstance>.Enumerator);
							int num10;
							int num11;
							if (role.EquippedTitle != null)
							{
								num10 = 157309238;
								num11 = num10;
							}
							else
							{
								num10 = 965710018;
								num11 = num10;
							}
							num2 = num10 ^ ((int)num3 * -1409454252);
							continue;
						}
						case 6u:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -4;
							num2 = (int)(num3 * 1020877389) ^ -820656311;
							continue;
						case 29u:
						{
							int num9;
							if (_200E_200F_202E_206E_206C_206F_202C_206A_206D_202A_200B_206A_206A_200E_202B_202C_202E_200F_202C_200E_202C_206C_200F_200E_202C_200F_202B_206F_202C_206A_202C_200D_200E_202D_206F_206E_206A_200D_200C_202A_202E.MoveNext())
							{
								num2 = 769139414;
								num9 = num2;
							}
							else
							{
								num2 = 1958134520;
								num9 = num2;
							}
							continue;
						}
						case 60u:
						{
							int num8;
							if (!_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E.MoveNext())
							{
								num2 = 389892660;
								num8 = num2;
							}
							else
							{
								num2 = 1208270405;
								num8 = num2;
							}
							continue;
						}
						case 47u:
						{
							int num7;
							if (_200E_200F_202E_206E_206C_206F_202C_206A_206D_202A_200B_206A_206A_200E_202B_202C_202E_200F_202C_200E_202C_206C_200F_200E_202C_200F_202B_206F_202C_206A_202C_200D_200E_202D_206F_206E_206A_200D_200C_202A_202E.MoveNext())
							{
								num2 = 970168973;
								num7 = num2;
							}
							else
							{
								num2 = 1883634573;
								num7 = num2;
							}
							continue;
						}
						case 49u:
							goto IL_06b4;
						case 0u:
						{
							int num5;
							if (!_206A_206D_206C_200B_202A_202B_202A_202D_206D_200C_206E_200C_206E_200E_202E_202E_206E_202D_202A_200D_200F_202E_200B_206F_200B_206A_202C_202C_202E_206A_200B_200D_200C_206E_206F_200D_206B_200D_200F_206A_202E.MoveNext())
							{
								num2 = 826101572;
								num5 = num2;
							}
							else
							{
								num2 = 1637211523;
								num5 = num2;
							}
							continue;
						}
						case 30u:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 3;
							result = true;
							num2 = ((int)num3 * -553434644) ^ -1973082998;
							continue;
						case 26u:
							current3 = _200D_206A_202C_200E_206F_206B_202A_202D_200D_200E_202B_202A_206E_206E_202E_206B_200E_200F_202C_202D_202A_206C_202C_202A_200E_200C_206B_206B_206C_200D_206B_202A_202A_202D_200B_206E_206F_200F_202A_206A_202E.Current;
							num2 = 1048404597;
							continue;
						case 15u:
							_206E_202C_200F_206C_200F_206A_206D_206F_206A_206C_200B_202E_202C_202B_206B_200C_206D_206F_206B_202A_202D_202B_206C_202A_202C_200D_202B_200E_200C_206E_202C_202A_200D_200F_206E_202D_200F_202D_202E_206A_202E();
							num2 = (int)(num3 * 775571881) ^ -1192187010;
							continue;
						case 48u:
							current2 = _200E_200F_202E_206E_206C_206F_202C_206A_206D_202A_200B_206A_206A_200E_202B_202C_202E_200F_202C_200E_202C_206C_200F_200E_202C_200F_202B_206F_202C_206A_202C_200D_200E_202D_206F_206E_206A_200D_200C_202A_202E.Current;
							num2 = 666155736;
							continue;
						case 54u:
							num2 = ((int)num3 * -1244536042) ^ -1522657718;
							continue;
						case 39u:
						{
							int num4;
							if (_200E_200F_202E_206E_206C_206F_202C_206A_206D_202A_200B_206A_206A_200E_202B_202C_202E_200F_202C_200E_202C_206C_200F_200E_202C_200F_202B_206F_202C_206A_202C_200D_200E_202D_206F_206E_206A_200D_200C_202A_202E.MoveNext())
							{
								num2 = 1238795945;
								num4 = num2;
							}
							else
							{
								num2 = 1707875925;
								num4 = num2;
							}
							continue;
						}
						case 1u:
							_200D_206A_202C_200E_206F_206B_202A_202D_200D_200E_202B_202A_206E_206E_202E_206B_200E_200F_202C_202D_202A_206C_202C_202A_200E_200C_206B_206B_206C_200D_206B_202A_202A_202D_200B_206E_206F_200F_202A_206A_202E = current.AllTriggers.GetEnumerator();
							num2 = ((int)num3 * -1939682809) ^ 0x7E3FC899;
							continue;
						case 27u:
							goto end_IL_0013;
						case 22u:
							num2 = (int)(num3 * 568960630) ^ -1343804203;
							continue;
						case 53u:
							current = _206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E.Current;
							num2 = 373466318;
							continue;
						case 46u:
							_200D_206A_202C_200E_206F_206B_202A_202D_200D_200E_202B_202A_206E_206E_202E_206B_200E_200F_202C_202D_202A_206C_202C_202A_200E_200C_206B_206B_206C_200D_206B_202A_202A_202D_200B_206E_206F_200F_202A_206A_202E = null;
							num2 = (int)((num3 * 2008757511) ^ 0x7C351F70);
							continue;
						case 2u:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -7;
							num2 = (int)((num3 * 610198705) ^ 0x67472DE2);
							continue;
						default:
							{
								result = false;
								goto end_IL_0013;
							}
							IL_06b4:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -4;
							num2 = 1287138406;
							continue;
							IL_04e1:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -8;
							num2 = 127243378;
							continue;
							IL_04cf:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -9;
							num2 = 743151457;
							continue;
							IL_0457:
							num2 = ((int)num3 * -1946889857) ^ -301869786;
							continue;
							IL_03ec:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
							num2 = 73306414;
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
			((IDisposable)_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E/*cast due to .constrained prefix*/).Dispose();
		}

		private void _200D_206E_202A_206D_200B_206A_200B_200D_202E_200C_200D_206A_202A_200B_202D_200E_202D_200B_206A_200B_200D_206F_200F_202D_202D_200C_206E_206D_206B_202C_206B_202D_206A_206B_200E_200D_200D_202A_202C_206E_202E()
		{
			_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -3;
			while (true)
			{
				int num = -955250160;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1429954939)) % 4)
					{
					case 0u:
						break;
					default:
						return;
					case 1u:
					{
						int num3;
						int num4;
						if (_200D_206A_202C_200E_206F_206B_202A_202D_200D_200E_202B_202A_206E_206E_202E_206B_200E_200F_202C_202D_202A_206C_202C_202A_200E_200C_206B_206B_206C_200D_206B_202A_202A_202D_200B_206E_206F_200F_202A_206A_202E != null)
						{
							num3 = -788288923;
							num4 = num3;
						}
						else
						{
							num3 = -263061580;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 149119158);
						continue;
					}
					case 2u:
						_202D_202B_206C_200C_200E_206E_206F_200F_200E_206C_202A_200C_206B_200D_202B_206D_206E_202E_202B_202C_206B_206A_206E_200E_200D_202C_202A_206F_202B_200C_200B_200B_206B_202D_200C_200E_202B_200C_202E_200F_202E((IDisposable)_200D_206A_202C_200E_206F_206B_202A_202D_200D_200E_202B_202A_206E_206E_202E_206B_200E_200F_202C_202D_202A_206C_202C_202A_200E_200C_206B_206B_206C_200D_206B_202A_202A_202D_200B_206E_206F_200F_202A_206A_202E);
						num = (int)(num2 * 938828884) ^ -391143742;
						continue;
					case 3u:
						return;
					}
					break;
				}
			}
		}

		private void _206E_202C_200F_206C_200F_206A_206D_206F_206A_206C_200B_202E_202C_202B_206B_200C_206D_206F_206B_202A_202D_202B_206C_202A_202C_200D_202B_200E_200C_206E_202C_202A_200D_200F_206E_202D_200F_202D_202E_206A_202E()
		{
			_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
			((IDisposable)_206A_206D_206C_200B_202A_202B_202A_202D_206D_200C_206E_200C_206E_200E_202E_202E_206E_202D_202A_200D_200F_202E_200B_206F_200B_206A_202C_202C_202E_206A_200B_200D_200C_206E_206F_200D_206B_200D_200F_206A_202E/*cast due to .constrained prefix*/).Dispose();
		}

		private void _200D_200B_206F_200F_200F_202B_206F_202D_202B_202C_202E_206E_206B_206A_206C_200D_206C_206C_206F_206E_206C_206B_202A_206E_206C_206B_206D_206A_200C_202A_206E_202C_202C_202E_206C_206A_206A_200F_206A_206B_202E()
		{
			_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -5;
			((IDisposable)_200E_200F_202E_206E_206C_206F_202C_206A_206D_202A_200B_206A_206A_200E_202B_202C_202E_200F_202C_200E_202C_206C_200F_200E_202C_200F_202B_206F_202C_206A_202C_200D_200E_202D_206F_206E_206A_200D_200C_202A_202E/*cast due to .constrained prefix*/).Dispose();
		}

		private void _202E_200C_206B_202D_200E_206D_202C_206E_202C_206C_200C_206C_200D_206A_202D_202C_200F_206C_200C_200C_206B_206D_206B_200D_202D_200B_202B_202E_206B_206B_206E_200F_200C_206F_200F_200E_202D_206E_206C_206F_202E()
		{
			_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
			while (true)
			{
				int num = -964122415;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -983529409)) % 3)
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
					((IDisposable)_202A_202E_206F_202C_202A_206D_206B_200D_206C_202A_202C_200E_206C_206B_206F_206D_206E_202A_206A_200C_202B_202B_202D_200C_206E_202E_206D_200F_206E_202E_206C_202C_206F_200F_206C_206D_200E_206D_200F_200F_202E/*cast due to .constrained prefix*/).Dispose();
					num = (int)((num2 * 2027521773) ^ 0xCD2E01);
				}
			}
		}

		private void _206A_206B_202A_200C_202E_206D_206B_206E_206B_206D_202C_206B_206C_200F_206D_206C_202E_206B_206F_200C_202B_202B_202C_206D_202B_202D_200F_200B_206A_206B_200E_206E_206B_200B_202A_202D_206D_202A_202C_206B_202E()
		{
			_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -7;
			((IDisposable)_200E_200F_202E_206E_206C_206F_202C_206A_206D_202A_200B_206A_206A_200E_202B_202C_202E_200F_202C_200E_202C_206C_200F_200E_202C_200F_202B_206F_202C_206A_202C_200D_200E_202D_206F_206E_206A_200D_200C_202A_202E/*cast due to .constrained prefix*/).Dispose();
		}

		private void _206D_202B_202D_206D_206F_206B_202C_200D_206C_206F_206E_202E_202E_202A_200E_206B_206F_200E_202A_202B_202D_200E_202B_206A_202C_202D_206C_206B_206D_200F_206B_202D_202E_206C_200C_206E_202B_206E_206F_202B_202E()
		{
			_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
			((IDisposable)_200E_200F_202E_206E_206C_206F_202C_206A_206D_202A_200B_206A_206A_200E_202B_202C_202E_200F_202C_200E_202C_206C_200F_200E_202C_200F_202B_206F_202C_206A_202C_200D_200E_202D_206F_206E_206A_200D_200C_202A_202E/*cast due to .constrained prefix*/).Dispose();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw _202B_206D_200E_200F_206B_202A_200D_200F_200C_200D_200C_202E_202C_202D_206E_202A_206B_202D_206D_206B_202E_206A_200B_200D_202C_202D_200E_200F_206F_206E_200E_206D_202D_206C_202C_202D_200B_202E_202B_202E_202E();
		}

		[DebuggerHidden]
		IEnumerator<Trigger> IEnumerable<Trigger>.GetEnumerator()
		{
			if (_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E == -2)
			{
				goto IL_000a;
			}
			goto IL_006e;
			IL_000a:
			int num = 1061268497;
			goto IL_000f;
			IL_000f:
			_206C_200B_206C_200C_200D_200E_206C_206C_206C_202C_202E_200B_202B_206E_206D_206E_202E_206F_202E_202B_206F_200E_200D_200F_202B_206B_206B_200D_206B_202C_200B_200B_206A_200F_206B_200E_200C_206B_200E_202D_202E obj = default(_206C_200B_206C_200C_200D_200E_206C_206C_206C_202C_202E_200B_202B_206E_206D_206E_202E_206F_202E_202B_206F_200E_200D_200F_202B_206B_206B_200D_206B_202C_200B_200B_206A_200F_206B_200E_200C_206B_200E_202D_202E);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1713EEA4)) % 8)
				{
				case 7u:
					break;
				case 5u:
				{
					int num3;
					int num4;
					if (_200B_202B_206E_200C_202C_200D_206F_202E_200F_206A_200C_202C_200B_202D_200F_206E_202D_206C_200B_202C_206C_206A_206E_206C_202B_206D_206E_200E_206E_202D_206E_202E_202E_202A_206D_206E_206D_202C_202D_202E != _200D_206F_200F_200F_206B_202D_206B_200B_200C_202A_200B_200E_200B_200E_206E_200D_202E_200C_200E_202A_202B_206C_200C_202B_200B_202E_202D_206D_202A_206E_202A_206F_206E_202C_206E_202B_202D_206E_206B_200D_202E(_200B_200E_200E_206A_206D_206B_202D_202A_200D_200B_202A_206D_206C_200E_200D_200B_200D_202D_200F_206F_202E_200E_200B_206C_206B_202A_202A_200E_200B_206E_206F_202A_200E_202A_200D_200F_206F_200D_202C_202E()))
					{
						num3 = 140347647;
						num4 = num3;
					}
					else
					{
						num3 = 2143392389;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -456681349);
					continue;
				}
				case 4u:
					goto IL_006e;
				case 3u:
					num = ((int)num2 * -458942992) ^ 0x28917B84;
					continue;
				case 6u:
					_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 0;
					num = ((int)num2 * -2098377327) ^ -1434143797;
					continue;
				case 1u:
					obj = this;
					num = (int)((num2 * 173264421) ^ 0x3145F362);
					continue;
				case 2u:
					obj._202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E = _202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E;
					num = (int)(num2 * 647367351) ^ -462175126;
					continue;
				default:
					return obj;
				}
				break;
			}
			goto IL_000a;
			IL_006e:
			obj = new _206C_200B_206C_200C_200D_200E_206C_206C_206C_202C_202E_200B_202B_206E_206D_206E_202E_206F_202E_202B_206F_200E_200D_200F_202B_206B_206B_200D_206B_202C_200B_200B_206A_200F_206B_200E_200C_206B_200E_202D_202E(0);
			num = 424031894;
			goto IL_000f;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<Trigger>)this).GetEnumerator();
		}

		static Thread _200B_200E_200E_206A_206D_206B_202D_202A_200D_200B_202A_206D_206C_200E_200D_200B_200D_202D_200F_206F_202E_200E_200B_206C_206B_202A_202A_200E_200B_206E_206F_202A_200E_202A_200D_200F_206F_200D_202C_202E()
		{
			return Thread.CurrentThread;
		}

		static int _200D_206F_200F_200F_206B_202D_206B_200B_200C_202A_200B_200E_200B_200E_206E_200D_202E_200C_200E_202A_202B_206C_200C_202B_200B_202E_202D_206D_202A_206E_202A_206F_206E_202C_206E_202B_202D_206E_206B_200D_202E(Thread P_0)
		{
			return P_0.ManagedThreadId;
		}

		static bool _202B_206C_200C_202D_206C_202D_202D_202B_206A_200B_202C_206C_206E_206E_202E_200D_202C_200F_206D_202C_200D_200F_202C_200E_200C_202B_200E_206F_200D_200F_200B_202B_206F_200D_206E_206E_202B_200E_206F_200D_202E(IEnumerator P_0)
		{
			return P_0.MoveNext();
		}

		static void _202D_202B_206C_200C_200E_206E_206F_200F_200E_206C_202A_200C_206B_200D_202B_206D_206E_202E_202B_202C_206B_206A_206E_200E_200D_202C_202A_206F_202B_200C_200B_200B_206B_202D_200C_200E_202B_200C_202E_200F_202E(IDisposable P_0)
		{
			P_0.Dispose();
		}

		static NotSupportedException _202B_206D_200E_200F_206B_202A_200D_200F_200C_200D_200C_202E_202C_202D_206E_202A_206B_202D_206D_206B_202E_206A_200B_200D_202C_202D_200E_200F_206F_206E_200E_206D_202D_206C_202C_202D_200B_202E_202B_202E_202E()
		{
			return new NotSupportedException();
		}
	}

	[XmlAttribute("key")]
	public string Key;

	[XmlAttribute("animation")]
	public string Animation;

	[XmlAttribute("name")]
	public string Name;

	[XmlAttribute("head")]
	public string Head;

	[XmlIgnore]
	public int hp;

	[XmlAttribute]
	public int maxhp;

	[XmlIgnore]
	public int mp;

	[XmlAttribute]
	public int maxmp;

	[XmlAttribute]
	public int wuxing;

	[XmlAttribute]
	public int shenfa;

	[XmlAttribute]
	public int bili;

	[XmlAttribute]
	public int gengu;

	[XmlAttribute]
	public int fuyuan;

	[XmlAttribute]
	public int dingli;

	[XmlAttribute]
	public int quanzhang;

	[XmlAttribute]
	public int jianfa;

	[XmlAttribute]
	public int daofa;

	[XmlAttribute]
	public int qimen;

	[XmlIgnore]
	internal string currentSkillName = string.Empty;

	private int _202B_202C_202C_200B_206B_200B_206D_206A_206B_200D_200D_200F_206E_200F_202D_206D_202E_200C_206F_206B_200E_206C_206B_200D_202C_206D_206A_206C_202B_200E_202B_200B_206F_206E_206F_202D_206A_206E_206D_206F_202E;

	[XmlAttribute]
	public int exp;

	[XmlAttribute("arena")]
	public string ArenaValue;

	[XmlAttribute("female")]
	public int FemaleValue;

	[XmlIgnore]
	public List<string> Talents = new List<string>();

	[XmlIgnore]
	internal int leftpoint;

	[XmlAttribute("grow_template")]
	public string GrowTemplateValue = global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4042279289u);

	[XmlArray("skills")]
	[XmlArrayItem(typeof(SkillInstance))]
	public List<SkillInstance> Skills = new List<SkillInstance>();

	[XmlArrayItem(typeof(InternalSkillInstance))]
	[XmlArray("internal_skills")]
	public List<InternalSkillInstance> InternalSkills = new List<InternalSkillInstance>();

	[XmlArrayItem(typeof(SpecialSkillInstance))]
	[XmlArray("special_skills")]
	public List<SpecialSkillInstance> SpecialSkills = new List<SpecialSkillInstance>();

	[XmlIgnore]
	public int balls;

	[XmlArray("items")]
	[XmlArrayItem(typeof(ItemInstance))]
	public List<ItemInstance> Equipment = new List<ItemInstance>();

	[XmlIgnore]
	public AttributeFinalHelper AttributesFinal;

	[XmlIgnore]
	public AttributeHelper Attributes;

	[XmlIgnore]
	public BattleSprite Sprite;

	[XmlIgnore]
	internal int jiushen_count;

	[XmlIgnore]
	internal List<SkillInstance> Skills_bak = new List<SkillInstance>();

	[XmlIgnore]
	internal List<SpecialSkillInstance> SpecialSkills_bak = new List<SpecialSkillInstance>();

	[XmlIgnore]
	internal string Book_Skill_bak = string.Empty;

	[XmlIgnore]
	internal int addmaxhp;

	[XmlIgnore]
	internal int addmaxmp;

	[XmlIgnore]
	public double DefanceValue;

	[XmlIgnore]
	public double CriticalpValue;

	[XmlIgnore]
	public double EquipmentCriticalpValue;

	[XmlIgnore]
	public double EquipmentDefencePercent;

	[XmlIgnore]
	public double SubCriticalPercent;

	[XmlIgnore]
	public double Difficulty;

	[XmlIgnore]
	public double AoyiBaseProbability;

	[XmlIgnore]
	public float xiValue;

	[XmlIgnore]
	public double mingzhongValue;

	[XmlIgnore]
	public double anti_debuffValue;

	[XmlIgnore]
	public double attackValue;

	[XmlIgnore]
	public double powerup_quanzhangValue;

	[XmlIgnore]
	public double powerup_jianfaValue;

	[XmlIgnore]
	public double powerup_daofaValue;

	[XmlIgnore]
	public double powerup_qimenValue;

	[XmlIgnore]
	public double powerup_xianshuValue;

	[XmlIgnore]
	public double criticalValue;

	[XmlIgnore]
	internal double Defencep;

	[XmlIgnore]
	public InternalSkillInstance EquippedInternalSkill;

	[XmlIgnore]
	public List<bool> BuiltInTalents;

	[XmlIgnore]
	public List<bool> ModTalents;

	[XmlIgnore]
	internal SkillBox CurrentSkillAI;

	[XmlIgnore]
	internal int skilltarget_x;

	[XmlIgnore]
	internal int skilltarget_y;

	[XmlIgnore]
	public int isharem;

	[XmlAttribute]
	public int character;

	private Dictionary<string, double> powerup_aoyi_Power;

	private Dictionary<string, double> powerup_aoyi_probability;

	[XmlIgnore]
	internal double leftpoint2;

	[XmlIgnore]
	internal double exp2;

	[XmlAttribute]
	public int character2;

	[XmlArrayItem(typeof(TitleInstance))]
	[XmlArray("titles")]
	public List<TitleInstance> Titles = new List<TitleInstance>();

	[XmlIgnore]
	public TitleInstance EquippedTitle;

	[XmlAttribute("anqi")]
	public string HiddenWeapon = string.Empty;

	[XmlIgnore]
	internal SkillBox CurrentSkillAnqi;

	[XmlIgnore]
	internal int addCdValue;

	[XmlIgnore]
	internal int addCdValue_Normal;

	[XmlIgnore]
	internal int addCdValue_Unique;

	[XmlIgnore]
	internal int addCdValue_Special;

	private RoleGrowTemplate _206F_202A_202B_200D_206A_202B_206E_206C_200E_202B_206B_200F_200E_206D_200F_202B_202A_206B_206A_200B_206C_202A_206A_202C_202D_206B_200B_202B_202D_202C_202B_200C_200E_200E_200C_200D_200F_206C_206C_200D_202E;

	[XmlIgnore]
	public override string PK => Key;

	[XmlIgnore]
	public SkillBox CurrentSkill
	{
		get
		{
			if (CurrentSkillAnqi != null)
			{
				goto IL_0008;
			}
			goto IL_003a;
			IL_0008:
			int num = 525275286;
			goto IL_000d;
			IL_000d:
			SkillBox skillBox = default(SkillBox);
			SkillBox current = default(SkillBox);
			SkillBox result = default(SkillBox);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2A5CABC1)) % 6)
				{
				case 2u:
					break;
				case 0u:
					goto IL_003a;
				case 4u:
				{
					int num12;
					int num13;
					if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(HiddenWeapon, currentSkillName))
					{
						num12 = 24384112;
						num13 = num12;
					}
					else
					{
						num12 = 1843133095;
						num13 = num12;
					}
					num = num12 ^ ((int)num2 * -1187354618);
					continue;
				}
				case 3u:
					return CurrentSkillAnqi;
				case 1u:
				{
					int num14;
					int num15;
					if (!_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(CurrentSkillAnqi.Name, HiddenWeapon))
					{
						num14 = 2015380085;
						num15 = num14;
					}
					else
					{
						num14 = 959902211;
						num15 = num14;
					}
					num = num14 ^ (int)(num2 * 1141461086);
					continue;
				}
				default:
				{
					IEnumerator<SkillBox> enumerator = GetAvaliableSkills().GetEnumerator();
					try
					{
						while (true)
						{
							IL_0119:
							int num3;
							int num4;
							if (_202A_206A_206F_206D_206E_206A_200E_202E_206A_200B_206E_200D_206A_200D_206E_202B_200E_206D_202C_200B_200F_206C_202C_206A_202C_206D_200C_206F_206D_200E_202A_206E_206B_200E_202E_206C_206F_200F_206B_200C_202E((IEnumerator)enumerator))
							{
								num3 = 547578520;
								num4 = num3;
							}
							else
							{
								num3 = 863407871;
								num4 = num3;
							}
							while (true)
							{
								switch ((num2 = (uint)(num3 ^ 0x2A5CABC1)) % 13)
								{
								case 4u:
									num3 = 547578520;
									continue;
								default:
									goto end_IL_00cf;
								case 7u:
									break;
								case 2u:
								{
									int num9;
									int num10;
									if (skillBox != null)
									{
										num9 = -376778633;
										num10 = num9;
									}
									else
									{
										num9 = -447126024;
										num10 = num9;
									}
									num3 = num9 ^ (int)(num2 * 891495358);
									continue;
								}
								case 11u:
								{
									int num7;
									if (!_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(current.Name, currentSkillName))
									{
										num3 = 582422202;
										num7 = num3;
									}
									else
									{
										num3 = 1539504694;
										num7 = num3;
									}
									continue;
								}
								case 6u:
									result = current;
									num3 = ((int)num2 * -1746335164) ^ -1498946124;
									continue;
								case 12u:
									skillBox = current;
									num3 = ((int)num2 * -1144360858) ^ -118658347;
									continue;
								case 9u:
								{
									int num8;
									if (_202B_202C_206D_206B_202E_206C_200C_202D_202B_202A_206F_206E_202E_202B_206F_206E_206F_202B_206C_206C_202A_206E_202B_200C_202A_202E_200F_202A_200E_206D_206C_202D_202B_200D_202D_206C_202B_202C_200C_202E(currentSkillName))
									{
										num3 = 601556736;
										num8 = num3;
									}
									else
									{
										num3 = 949739095;
										num8 = num3;
									}
									continue;
								}
								case 8u:
									current = enumerator.Current;
									num3 = 1878276723;
									continue;
								case 10u:
								{
									int num5;
									int num6;
									if (current.SkillType != SkillType.Normal)
									{
										num5 = -1171473417;
										num6 = num5;
									}
									else
									{
										num5 = -1207724265;
										num6 = num5;
									}
									num3 = num5 ^ (int)(num2 * 1349365152);
									continue;
								}
								case 3u:
									result = current;
									num3 = ((int)num2 * -64115721) ^ -826351922;
									continue;
								case 0u:
									goto end_IL_00cf;
								case 1u:
								case 5u:
									return result;
								}
								goto IL_0119;
								continue;
								end_IL_00cf:
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
								IL_023b:
								int num11 = 184982887;
								while (true)
								{
									switch ((num2 = (uint)(num11 ^ 0x2A5CABC1)) % 3)
									{
									case 0u:
										break;
									default:
										goto end_IL_0240;
									case 1u:
										goto IL_025e;
									case 2u:
										goto end_IL_0240;
									}
									goto IL_023b;
									IL_025e:
									_202D_200E_200B_206B_200E_206D_200F_200C_202B_200F_202A_202A_206D_206D_206B_202B_202C_206D_206B_202D_202A_206A_202E_200B_202B_200C_202E_200D_206B_202C_202C_202E_206E_202C_202B_206D_202E_202C_200F_200E_202E((IDisposable)enumerator);
									num11 = (int)((num2 * 1165436698) ^ 0x718BF63);
									continue;
									end_IL_0240:
									break;
								}
								break;
							}
						}
					}
					return skillBox;
				}
				}
				break;
			}
			goto IL_0008;
			IL_003a:
			skillBox = null;
			num = 1107687526;
			goto IL_000d;
		}
		set
		{
			currentSkillName = value.Name;
		}
	}

	[XmlIgnore]
	public int wuxue => 100 + Level * GrowTemplate.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3703017849u)];

	[XmlAttribute]
	public int level
	{
		get
		{
			return _202B_202C_202C_200B_206B_200B_206D_206A_206B_200D_200D_200F_206E_200F_202D_206D_202E_200C_206F_206B_200E_206C_206B_200D_202C_206D_206A_206C_202B_200E_202B_200B_206F_206E_206F_202D_206A_206E_206D_206F_202E;
		}
		set
		{
			if (exp != -(int)exp2)
			{
				return;
			}
			while (true)
			{
				int num = -157133669;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -857255652)) % 5)
					{
					case 0u:
						break;
					default:
						return;
					case 2u:
						_202B_202C_202C_200B_206B_200B_206D_206A_206B_200D_200D_200F_206E_200F_202D_206D_202E_200C_206F_206B_200E_206C_206B_200D_202C_206D_206A_206C_202B_200E_202B_200B_206F_206E_206F_202D_206A_206E_206D_206F_202E = value;
						num = ((int)num2 * -325113722) ^ -1596822946;
						continue;
					case 3u:
						exp2 = 0.0 - (double)exp;
						num = ((int)num2 * -1009691988) ^ 0xCB4B228;
						continue;
					case 4u:
						exp = PrevLevelupExp;
						num = ((int)num2 * -384567678) ^ -476639293;
						continue;
					case 1u:
						return;
					}
					break;
				}
			}
		}
	}

	public int Level => level;

	[XmlIgnore]
	public int Exp
	{
		get
		{
			if (exp == -(int)exp2)
			{
				while (true)
				{
					uint num;
					switch ((num = 1318237627u) % 3)
					{
					case 0u:
						continue;
					case 1u:
						return exp;
					}
					break;
				}
			}
			return 0;
		}
		set
		{
			if (exp != -(int)exp2)
			{
				return;
			}
			while (true)
			{
				int num = 2039868938;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x13918678)) % 4)
					{
					case 0u:
						break;
					default:
						return;
					case 2u:
						exp = value;
						num = ((int)num2 * -581840667) ^ -484214437;
						continue;
					case 1u:
						exp2 = 0.0 - (double)value;
						num = ((int)num2 * -1657308783) ^ -1403118958;
						continue;
					case 3u:
						return;
					}
					break;
				}
			}
		}
	}

	public bool Arena => _206A_206B_202A_202E_202C_206A_202B_206D_206C_206A_200E_206C_200B_200D_206F_202D_202D_200D_200C_202B_200C_202D_200D_200B_200E_206D_202D_206C_200E_206F_206E_202A_202C_206E_200B_202D_206C_206F_200C_200D_202E(ArenaValue, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1513702912u));

	public bool Female => Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2145573044u)] == 1;

	[XmlAttribute("talent")]
	public string TalentValue
	{
		get
		{
			return _202A_206D_200C_202D_206D_200E_200C_206D_202B_200E_202B_206F_206A_202B_202E_200C_206B_202C_202A_200D_200F_202E_202A_206A_202E_200F_206B_202D_206C_206E_200E_206B_206E_202E_206D_202B_206F_206F_200F_200C_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1583738914u), Talents.ToArray());
		}
		set
		{
			Talents.Clear();
			string text = default(string);
			string[] array = default(string[]);
			int num3 = default(int);
			while (true)
			{
				int num = -351560810;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -608160634)) % 9)
					{
					case 8u:
						break;
					default:
						return;
					case 1u:
					{
						int num6;
						int num7;
						if (!Talents.Contains(text))
						{
							num6 = -1369378633;
							num7 = num6;
						}
						else
						{
							num6 = -30328204;
							num7 = num6;
						}
						num = num6 ^ (int)(num2 * 305199799);
						continue;
					}
					case 3u:
						text = array[num3];
						num = -675794604;
						continue;
					case 6u:
						Talents.Add(text);
						num = (int)((num2 * 1095794794) ^ 0x6029D7E9);
						continue;
					case 4u:
					{
						int num8;
						if (num3 < array.Length)
						{
							num = -1492384714;
							num8 = num;
						}
						else
						{
							num = -1491218413;
							num8 = num;
						}
						continue;
					}
					case 2u:
					{
						int num4;
						int num5;
						if (!_202B_202C_206D_206B_202E_206C_200C_202D_202B_202A_206F_206E_202E_202B_206F_206E_206F_202B_206C_206C_202A_206E_202B_200C_202A_202E_200F_202A_200E_206D_206C_202D_202B_200D_202D_206C_202B_202C_200C_202E(text))
						{
							num4 = -2052404211;
							num5 = num4;
						}
						else
						{
							num4 = -593970503;
							num5 = num4;
						}
						num = num4 ^ (int)(num2 * 2061710620);
						continue;
					}
					case 7u:
						array = _202B_202C_200F_202C_202E_202A_200C_206F_200F_202B_206A_202C_200F_200C_200E_206B_206F_202E_200E_206E_200B_206D_200F_200F_200C_206A_202D_206F_200E_200B_206E_200B_206A_206B_202E_202A_200F_206D_200F_202D_202E(value, new char[1] { '#' });
						num3 = 0;
						num = (int)(num2 * 1741871519) ^ -2072166244;
						continue;
					case 0u:
						num3++;
						num = -2055533972;
						continue;
					case 5u:
						return;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public RoleGrowTemplate GrowTemplate
	{
		get
		{
			if (_206F_202A_202B_200D_206A_202B_206E_206C_200E_202B_206B_200F_200E_206D_200F_202B_202A_206B_206A_200B_206C_202A_206A_202C_202D_206B_200B_202B_202D_202C_202B_200C_200E_200E_200C_200D_200F_206C_206C_200D_202E == null)
			{
				while (true)
				{
					int num = 1528480423;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ 0x5758B634)) % 4)
						{
						case 0u:
							break;
						case 3u:
						{
							_206F_202A_202B_200D_206A_202B_206E_206C_200E_202B_206B_200F_200E_206D_200F_202B_202A_206B_206A_200B_206C_202A_206A_202C_202D_206B_200B_202B_202D_202C_202B_200C_200E_200E_200C_200D_200F_206C_206C_200D_202E = ResourceManager.Get<RoleGrowTemplate>(GrowTemplateValue);
							int num3;
							int num4;
							if (_206F_202A_202B_200D_206A_202B_206E_206C_200E_202B_206B_200F_200E_206D_200F_202B_202A_206B_206A_200B_206C_202A_206A_202C_202D_206B_200B_202B_202D_202C_202B_200C_200E_200E_200C_200D_200F_206C_206C_200D_202E == null)
							{
								num3 = 1858469591;
								num4 = num3;
							}
							else
							{
								num3 = 175631764;
								num4 = num3;
							}
							num = num3 ^ ((int)num2 * -1526013625);
							continue;
						}
						case 2u:
							_206F_202A_202B_200D_206A_202B_206E_206C_200E_202B_206B_200F_200E_206D_200F_202B_202A_206B_206A_200B_206C_202A_206A_202C_202D_206B_200B_202B_202D_202C_202B_200C_200E_200E_200C_200D_200F_206C_206C_200D_202E = ResourceManager.Get<RoleGrowTemplate>(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2197207655u));
							num = (int)((num2 * 508600319) ^ 0x1ECC9A8B);
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
			return _206F_202A_202B_200D_206A_202B_206E_206C_200E_202B_206B_200F_200E_206D_200F_202B_202A_206B_206A_200B_206C_202A_206A_202C_202D_206B_200B_202B_202D_202C_202B_200C_200E_200E_200C_200D_200F_206C_206C_200D_202E;
		}
	}

	[XmlIgnore]
	public int LevelupExp => CommonSettings.LevelupExp(Level);

	[XmlIgnore]
	public int PrevLevelupExp => CommonSettings.LevelupExp(Level - 1);

	[XmlIgnore]
	public IEnumerable<string> EquipmentTalents
	{
		get
		{
			_206F_202A_200C_202C_206E_206C_202D_200C_206B_206E_200D_206D_206C_206E_206C_206F_206F_206C_206C_200D_206B_206E_200E_202C_200E_200C_200B_200E_200C_206E_202D_200E_200B_206A_200C_206C_202C_202D_202C_206E_202E obj = new _206F_202A_200C_202C_206E_206C_202D_200C_206B_206E_200D_206D_206C_206E_206C_206F_206F_206C_206C_200D_206B_206E_200E_202C_200E_200C_200B_200E_200C_206E_202D_200E_200B_206A_200C_206C_202C_202D_202C_206E_202E();
			while (true)
			{
				int num = -147547963;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -2043123689)) % 3)
					{
					case 0u:
						break;
					case 2u:
						goto IL_0028;
					default:
						obj._0024PC = -2;
						return obj;
					}
					break;
					IL_0028:
					obj._202A_202B_206D_202D_200C_202E_206F_200C_202B_202E_202E_206E_200D_206A_206F_206D_206F_200E_202C_206F_200B_206D_206B_202D_206C_206A_200D_200D_206D_200F_200F_206B_202A_202D_202A_200B_200F_200B_202C_202E_202E = this;
					num = (int)((num2 * 1335906703) ^ 0x709DC60B);
				}
			}
		}
	}

	[XmlIgnore]
	public bool Animal => Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1320577198u)] == -1;

	[XmlIgnore]
	public double Defence
	{
		get
		{
			Defencep = GetdefenceDescAttack();
			return (double)Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1995100678u)] / (1.0 - Defencep) / 30.0;
		}
	}

	[XmlIgnore]
	public double Attack
	{
		get
		{
			double num = 1.0;
			double criticalp = default(double);
			float num23 = default(float);
			SkillInstance current3 = default(SkillInstance);
			UniqueSkillInstance current4 = default(UniqueSkillInstance);
			while (true)
			{
				int num2 = 1987634301;
				while (true)
				{
					float num25;
					uint num3;
					switch ((num3 = (uint)(num2 ^ 0x5F6D33AF)) % 5)
					{
					case 4u:
						break;
					case 0u:
						num25 = 0f;
						goto IL_0047;
					case 1u:
						if (EquippedTitle != null)
						{
							num25 = EquippedTitle.Attack;
							goto IL_0047;
						}
						num2 = (int)(num3 * 289493661) ^ -392389319;
						continue;
					case 2u:
						criticalp = 0.0;
						num2 = (int)((num3 * 1923855213) ^ 0x485DCB3);
						continue;
					default:
						{
							double num4 = 0.0;
							IEnumerator<Trigger> enumerator = GetTriggers(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3115868650u)).GetEnumerator();
							try
							{
								while (true)
								{
									IL_00f0:
									int num5;
									int num6;
									if (!_202A_206A_206F_206D_206E_206A_200E_202E_206A_200B_206E_200D_206A_200D_206E_202B_200E_206D_202C_200B_200F_206C_202C_206A_202C_206D_200C_206F_206D_200E_202A_206E_206B_200E_202E_206C_206F_200F_206B_200C_202E((IEnumerator)enumerator))
									{
										num5 = 1018289874;
										num6 = num5;
									}
									else
									{
										num5 = 1281739952;
										num6 = num5;
									}
									while (true)
									{
										switch ((num3 = (uint)(num5 ^ 0x5F6D33AF)) % 4)
										{
										case 0u:
											num5 = 1281739952;
											continue;
										default:
											goto end_IL_00a9;
										case 3u:
										{
											Trigger current = enumerator.Current;
											num4 += double.Parse(current.Argvs[0]);
											num5 = 407912717;
											continue;
										}
										case 2u:
											break;
										case 1u:
											goto end_IL_00a9;
										}
										goto IL_00f0;
										continue;
										end_IL_00a9:
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
										IL_0110:
										int num7 = 34637271;
										while (true)
										{
											switch ((num3 = (uint)(num7 ^ 0x5F6D33AF)) % 3)
											{
											case 2u:
												break;
											default:
												goto end_IL_0115;
											case 1u:
												goto IL_0133;
											case 0u:
												goto end_IL_0115;
											}
											goto IL_0110;
											IL_0133:
											_202D_200E_200B_206B_200E_206D_200F_200C_202B_200F_202A_202A_206D_206D_206B_202B_202C_206D_206B_202D_202A_206A_202E_200B_202B_200C_202E_200D_206B_202C_202C_202E_206E_202C_202B_206D_202E_202C_200F_200E_202E((IDisposable)enumerator);
											num7 = ((int)num3 * -2120187246) ^ -1821847117;
											continue;
											end_IL_0115:
											break;
										}
										break;
									}
								}
							}
							num4 /= 100.0;
							while (true)
							{
								int num8 = 1556924864;
								while (true)
								{
									switch ((num3 = (uint)(num8 ^ 0x5F6D33AF)) % 14)
									{
									case 10u:
										break;
									case 12u:
										criticalp = 1.0;
										num8 = ((int)num3 * -989678983) ^ 0x310044D1;
										continue;
									case 0u:
										num *= _202E_200E_200B_200E_206F_200D_206F_202E_200C_206F_202A_200D_202E_202D_206A_202C_206E_200B_206D_200B_202E_202D_206E_200F_206D_200D_200F_202E_206C_206B_206C_202E_206A_202A_206F_206F_200B_202C_202D_200F_202E((double)AttributesFinal[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1564888282u)] + 50.0, 0.3);
										num8 = 536592388;
										continue;
									case 4u:
										num *= 2.0 + (double)AttributesFinal[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1564888282u)] / 400.0;
										num8 = ((int)num3 * -1739271040) ^ 0x78215816;
										continue;
									case 7u:
										set_critical(ref criticalp, ref num4);
										num8 = ((int)num3 * -1286514921) ^ -36533889;
										continue;
									case 1u:
									{
										int num21;
										int num22;
										if (CommonSettings.MOD_KEY() == 1)
										{
											num21 = 1101066309;
											num22 = num21;
										}
										else
										{
											num21 = 136537544;
											num22 = num21;
										}
										num8 = num21 ^ (int)(num3 * 1703275585);
										continue;
									}
									case 8u:
										criticalp = (double)AttributesFinal[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2259249129u)] / 50.0 / 20.0 * (double)(1f + EquippedInternalSkill.Critical) + (double)CriticalProbabilityAdd();
										num8 = (int)(num3 * 1814713538) ^ -1193549432;
										continue;
									case 9u:
										num *= 2.0 + (double)GetMaxSkillTypeValue() / 200.0;
										num *= (double)(1f + (EquippedInternalSkill.Attack + num23));
										num8 = ((int)num3 * -1558568221) ^ -1020306276;
										continue;
									case 5u:
									{
										int num24;
										if (criticalp <= 1.0)
										{
											num8 = 1014715355;
											num24 = num8;
										}
										else
										{
											num8 = 317575029;
											num24 = num8;
										}
										continue;
									}
									case 13u:
										num *= 2.0 + (double)GetMaxSkillTypeValue() / 400.0;
										num8 = (int)(num3 * 385081934) ^ -1611524;
										continue;
									case 3u:
										num *= (double)(1f + (EquippedInternalSkill.Attack + num23));
										num8 = (int)(num3 * 283269386) ^ -429423893;
										continue;
									case 11u:
										num = 4.0;
										num8 = ((int)num3 * -2000430454) ^ -91865003;
										continue;
									case 2u:
										criticalp = (_202E_200E_200B_200E_206F_200D_206F_202E_200C_206F_202A_200D_202E_202D_206A_202C_206E_200B_206D_200B_202E_202D_206E_200F_206D_200D_200F_202E_206C_206B_206C_202E_206A_202A_206F_206F_200B_202C_202D_200F_202E(_202C_200C_202C_202A_206B_202E_206D_200B_200F_206F_200E_202D_200C_206C_202E_202D_202B_202B_202D_206B_202C_202E_202D_206C_202B_200D_200E_206E_200D_206D_206A_200B_206A_200D_202B_200B_200C_200D_200E_202A_202E((double)AttributesFinal[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2475589736u)], 31.0), 0.077) - 1.3) * (double)(1f + EquippedInternalSkill.Critical) + (double)CriticalProbabilityAdd();
										num8 = (int)((num3 * 1590280824) ^ 0x448AF9D2);
										continue;
									default:
									{
										double num9 = 0.0;
										enumerator = GetTriggers(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2081569984u)).GetEnumerator();
										try
										{
											while (true)
											{
												IL_0497:
												int num10;
												int num11;
												if (!_202A_206A_206F_206D_206E_206A_200E_202E_206A_200B_206E_200D_206A_200D_206E_202B_200E_206D_202C_200B_200F_206C_202C_206A_202C_206D_200C_206F_206D_200E_202A_206E_206B_200E_202E_206C_206F_200F_206B_200C_202E((IEnumerator)enumerator))
												{
													num10 = 976012790;
													num11 = num10;
												}
												else
												{
													num10 = 882513777;
													num11 = num10;
												}
												while (true)
												{
													switch ((num3 = (uint)(num10 ^ 0x5F6D33AF)) % 4)
													{
													case 0u:
														num10 = 882513777;
														continue;
													default:
														goto end_IL_044e;
													case 2u:
													{
														Trigger current2 = enumerator.Current;
														num9 += double.Parse(current2.Argvs[0]);
														num10 = 1810565068;
														continue;
													}
													case 3u:
														break;
													case 1u:
														goto end_IL_044e;
													}
													goto IL_0497;
													continue;
													end_IL_044e:
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
													IL_04b7:
													int num12 = 1840340445;
													while (true)
													{
														switch ((num3 = (uint)(num12 ^ 0x5F6D33AF)) % 3)
														{
														case 0u:
															break;
														default:
															goto end_IL_04bc;
														case 2u:
															goto IL_04da;
														case 1u:
															goto end_IL_04bc;
														}
														goto IL_04b7;
														IL_04da:
														_202D_200E_200B_206B_200E_206D_200F_200C_202B_200F_202A_202A_206D_206D_206B_202B_202C_206D_206B_202D_202A_206A_202E_200B_202B_200C_202E_200D_206B_202C_202C_202E_206E_202C_202B_206D_202E_202C_200F_200E_202E((IDisposable)enumerator);
														num12 = (int)(num3 * 357901350) ^ -1253239547;
														continue;
														end_IL_04bc:
														break;
													}
													break;
												}
											}
										}
										num *= 1.0 + criticalp * (1.5 + num4);
										float num13 = 0.1f;
										using (List<SkillInstance>.Enumerator enumerator2 = Skills.GetEnumerator())
										{
											while (true)
											{
												IL_057a:
												int num14;
												int num15;
												if (!enumerator2.MoveNext())
												{
													num14 = 736959532;
													num15 = num14;
												}
												else
												{
													num14 = 1322253026;
													num15 = num14;
												}
												while (true)
												{
													switch ((num3 = (uint)(num14 ^ 0x5F6D33AF)) % 6)
													{
													case 2u:
														num14 = 1322253026;
														continue;
													default:
														goto end_IL_0527;
													case 1u:
														current3 = enumerator2.Current;
														num14 = 1634457909;
														continue;
													case 3u:
														num13 = current3.Power;
														num14 = ((int)num3 * -1180020367) ^ -1830763614;
														continue;
													case 4u:
														break;
													case 0u:
													{
														int num16;
														int num17;
														if (current3.Power <= num13)
														{
															num16 = 1981473801;
															num17 = num16;
														}
														else
														{
															num16 = 1516523316;
															num17 = num16;
														}
														num14 = num16 ^ (int)(num3 * 2126470512);
														continue;
													}
													case 5u:
														goto end_IL_0527;
													}
													goto IL_057a;
													continue;
													end_IL_0527:
													break;
												}
												break;
											}
										}
										if (num13 == 0.1f)
										{
											using List<UniqueSkillInstance>.Enumerator enumerator3 = EquippedInternalSkill.UniqueSkills.GetEnumerator();
											while (true)
											{
												IL_063c:
												int num18;
												int num19;
												if (!enumerator3.MoveNext())
												{
													num18 = 1715288290;
													num19 = num18;
												}
												else
												{
													num18 = 1131423264;
													num19 = num18;
												}
												while (true)
												{
													switch ((num3 = (uint)(num18 ^ 0x5F6D33AF)) % 5)
													{
													case 3u:
														num18 = 1131423264;
														continue;
													default:
														goto end_IL_05f1;
													case 1u:
													{
														current4 = enumerator3.Current;
														int num20;
														if (current4.Power <= num13)
														{
															num18 = 172435160;
															num20 = num18;
														}
														else
														{
															num18 = 1707317304;
															num20 = num18;
														}
														continue;
													}
													case 2u:
														break;
													case 4u:
														num13 = current4.Power;
														num18 = (int)(num3 * 803417008) ^ -2071301624;
														continue;
													case 0u:
														goto end_IL_05f1;
													}
													goto IL_063c;
													continue;
													end_IL_05f1:
													break;
												}
												break;
											}
										}
										return num * (double)num13 + num9;
									}
									}
									break;
								}
							}
						}
						IL_0047:
						num23 = num25;
						num2 = 273733732;
						continue;
					}
					break;
				}
			}
		}
	}

	public int MAX_INTERNALSKILL_COUNT
	{
		get
		{
			string max_internalskill_count = GrowTemplate.max_internalskill_count;
			if (!_202B_202C_206D_206B_202E_206C_200C_202D_202B_202A_206F_206E_202E_202B_206F_206E_206F_202B_206C_206C_202A_206E_202B_200C_202A_202E_200F_202A_200E_206D_206C_202D_202B_200D_202D_206C_202B_202C_200C_202E(max_internalskill_count))
			{
				while (true)
				{
					uint num;
					switch ((num = 740584523u) % 3)
					{
					case 0u:
						continue;
					case 2u:
						return (int)double.Parse(Tools.Compute(_206F_202C_206E_206C_200B_206D_206B_202E_206E_200E_202A_202E_206C_200E_206F_200C_200D_200E_206B_206C_206D_200B_206E_202E_200B_202A_202D_202E_202D_202B_202E_206C_200B_202A_206B_202C_200F_202B_202B_206F_202E(max_internalskill_count, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1875398881u), RuntimeData.Instance.RoundString())));
					}
					break;
				}
			}
			return CommonSettings.MAX_INTERNALSKILL_COUNT;
		}
	}

	public int MAX_SKILL_COUNT
	{
		get
		{
			string max_skill_count = GrowTemplate.max_skill_count;
			if (!_202B_202C_206D_206B_202E_206C_200C_202D_202B_202A_206F_206E_202E_202B_206F_206E_206F_202B_206C_206C_202A_206E_202B_200C_202A_202E_200F_202A_200E_206D_206C_202D_202B_200D_202D_206C_202B_202C_200C_202E(max_skill_count))
			{
				while (true)
				{
					uint num;
					switch ((num = 1368132110u) % 3)
					{
					case 0u:
						continue;
					case 2u:
						return (int)double.Parse(Tools.Compute(_206F_202C_206E_206C_200B_206D_206B_202E_206E_200E_202A_202E_206C_200E_206F_200C_200D_200E_206B_206C_206D_200B_206E_202E_200B_202A_202D_202E_202D_202B_202E_206C_200B_202A_206B_202C_200F_202B_202B_206F_202E(max_skill_count, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3250051652u), RuntimeData.Instance.RoundString())));
					}
					break;
				}
			}
			return CommonSettings.MAX_SKILL_COUNT;
		}
	}

	public int MAX_INTERNALSKILL_LEVEL
	{
		get
		{
			string max_internalskill_level = GrowTemplate.max_internalskill_level;
			if (!_202B_202C_206D_206B_202E_206C_200C_202D_202B_202A_206F_206E_202E_202B_206F_206E_206F_202B_206C_206C_202A_206E_202B_200C_202A_202E_200F_202A_200E_206D_206C_202D_202B_200D_202D_206C_202B_202C_200C_202E(max_internalskill_level))
			{
				while (true)
				{
					uint num;
					switch ((num = 126557384u) % 3)
					{
					case 0u:
						continue;
					case 2u:
						return (int)double.Parse(Tools.Compute(_206F_202C_206E_206C_200B_206D_206B_202E_206E_200E_202A_202E_206C_200E_206F_200C_200D_200E_206B_206C_206D_200B_206E_202E_200B_202A_202D_202E_202D_202B_202E_206C_200B_202A_206B_202C_200F_202B_202B_206F_202E(max_internalskill_level, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1381559287u), RuntimeData.Instance.RoundString())));
					}
					break;
				}
			}
			return CommonSettings.MAX_INTERNALSKILL_LEVEL;
		}
	}

	public int MAX_SKILL_LEVEL
	{
		get
		{
			string max_skill_level = GrowTemplate.max_skill_level;
			while (true)
			{
				int num = 1511609966;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)(num ^ 0x78C429C4)) % 4)
					{
					case 0u:
						break;
					case 2u:
					{
						int num4;
						if (_202B_202C_206D_206B_202E_206C_200C_202D_202B_202A_206F_206E_202E_202B_206F_206E_206F_202B_206C_206C_202A_206E_202B_200C_202A_202E_200F_202A_200E_206D_206C_202D_202B_200D_202D_206C_202B_202C_200C_202E(max_skill_level))
						{
							num3 = 1951040507;
							num4 = num3;
						}
						else
						{
							num3 = 1997655329;
							num4 = num3;
						}
						goto IL_0048;
					}
					case 3u:
						return (int)double.Parse(Tools.Compute(_206F_202C_206E_206C_200B_206D_206B_202E_206E_200E_202A_202E_206C_200E_206F_200C_200D_200E_206B_206C_206D_200B_206E_202E_200B_202A_202D_202E_202D_202B_202E_206C_200B_202A_206B_202C_200F_202B_202B_206F_202E(max_skill_level, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3121341046u), RuntimeData.Instance.RoundString())));
					default:
						return CommonSettings.MAX_SKILL_LEVEL;
					}
					break;
					IL_0048:
					num = num3 ^ ((int)num2 * -1734997989);
				}
			}
		}
	}

	public int MAX_ATTRIBUTE
	{
		get
		{
			string max_attribute = GrowTemplate.max_attribute;
			if (!_202B_202C_206D_206B_202E_206C_200C_202D_202B_202A_206F_206E_202E_202B_206F_206E_206F_202B_206C_206C_202A_206E_202B_200C_202A_202E_200F_202A_200E_206D_206C_202D_202B_200D_202D_206C_202B_202C_200C_202E(max_attribute))
			{
				while (true)
				{
					uint num;
					switch ((num = 341237830u) % 3)
					{
					case 0u:
						continue;
					case 1u:
						return (int)double.Parse(Tools.Compute(_206F_202C_206E_206C_200B_206D_206B_202E_206E_200E_202A_202E_206C_200E_206F_200C_200D_200E_206B_206C_206D_200B_206E_202E_200B_202A_202D_202E_202D_202B_202E_206C_200B_202A_206B_202C_200F_202B_202B_206F_202E(max_attribute, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3250051652u), RuntimeData.Instance.RoundString())));
					}
					break;
				}
			}
			return CommonSettings.MAX_ATTRIBUTE;
		}
	}

	public int MAX_HPMP
	{
		get
		{
			string max_hpmp = GrowTemplate.max_hpmp;
			while (true)
			{
				int num = -193917072;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)(num ^ -597866626)) % 4)
					{
					case 0u:
						break;
					case 2u:
					{
						int num4;
						if (!_202B_202C_206D_206B_202E_206C_200C_202D_202B_202A_206F_206E_202E_202B_206F_206E_206F_202B_206C_206C_202A_206E_202B_200C_202A_202E_200F_202A_200E_206D_206C_202D_202B_200D_202D_206C_202B_202C_200C_202E(max_hpmp))
						{
							num3 = -1192759551;
							num4 = num3;
						}
						else
						{
							num3 = -1695175413;
							num4 = num3;
						}
						goto IL_0048;
					}
					case 1u:
						return (int)double.Parse(Tools.Compute(_206F_202C_206E_206C_200B_206D_206B_202E_206E_200E_202A_202E_206C_200E_206F_200C_200D_200E_206B_206C_206D_200B_206E_202E_200B_202A_202D_202E_202D_202B_202E_206C_200B_202A_206B_202C_200F_202B_202B_206F_202E(max_hpmp, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3250051652u), RuntimeData.Instance.RoundString())));
					default:
						return CommonSettings.MAX_HPMP;
					}
					break;
					IL_0048:
					num = num3 ^ ((int)num2 * -1399586395);
				}
			}
		}
	}

	public int MAX_LEVEL
	{
		get
		{
			string max_level = GrowTemplate.max_level;
			if (!_202B_202C_206D_206B_202E_206C_200C_202D_202B_202A_206F_206E_202E_202B_206F_206E_206F_202B_206C_206C_202A_206E_202B_200C_202A_202E_200F_202A_200E_206D_206C_202D_202B_200D_202D_206C_202B_202C_200C_202E(max_level))
			{
				while (true)
				{
					uint num;
					switch ((num = 778679437u) % 3)
					{
					case 2u:
						continue;
					case 1u:
						return (int)double.Parse(Tools.Compute(_206F_202C_206E_206C_200B_206D_206B_202E_206E_200E_202A_202E_206C_200E_206F_200C_200D_200E_206B_206C_206D_200B_206E_202E_200B_202A_202D_202E_202D_202B_202E_206C_200B_202A_206B_202C_200F_202B_202B_206F_202E(max_level, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(800863094u), RuntimeData.Instance.RoundString())));
					}
					break;
				}
			}
			return CommonSettings.MAX_LEVEL;
		}
	}

	public Role()
	{
		AttributesFinal = new AttributeFinalHelper(this);
		Attributes = new AttributeHelper(this);
	}

	public static Role Generate(string key, bool addskill = false)
	{
		Role role = ResourceManager.Get<Role>(key);
		if (role != null)
		{
			while (true)
			{
				uint num;
				switch ((num = 274267783u) % 3)
				{
				case 2u:
					continue;
				case 1u:
					return role.Clone();
				}
				break;
			}
		}
		return null;
	}

	public override void InitBind()
	{
		try
		{
			using (List<SkillInstance>.Enumerator enumerator = Skills.GetEnumerator())
			{
				SkillInstance current = default(SkillInstance);
				while (true)
				{
					IL_0129:
					if (enumerator.MoveNext())
					{
						while (true)
						{
							current = enumerator.Current;
							current.Owner = this;
							int num = 1802325869;
							while (true)
							{
								uint num2;
								switch ((num2 = (uint)(num ^ 0x3FAC9D3A)) % 4)
								{
								case 0u:
									num = 139123456;
									continue;
								case 2u:
									break;
								case 3u:
									current.RefreshUniquSkills();
									num = ((int)num2 * -1574987098) ^ 0x1A361E85;
									continue;
								default:
									goto end_IL_0038;
								}
								break;
							}
							continue;
							end_IL_0038:
							break;
						}
						using (List<UniqueSkillInstance>.Enumerator enumerator2 = current.UniqueSkills.GetEnumerator())
						{
							while (true)
							{
								IL_00ad:
								int num3;
								int num4;
								if (!enumerator2.MoveNext())
								{
									num3 = 1652323053;
									num4 = num3;
								}
								else
								{
									num3 = 1278895504;
									num4 = num3;
								}
								while (true)
								{
									uint num2;
									switch ((num2 = (uint)(num3 ^ 0x3FAC9D3A)) % 4)
									{
									case 0u:
										num3 = 1278895504;
										continue;
									default:
										goto end_IL_0077;
									case 2u:
										enumerator2.Current.Owner = this;
										num3 = 1601339175;
										continue;
									case 1u:
										break;
									case 3u:
										goto end_IL_0077;
									}
									goto IL_00ad;
									continue;
									end_IL_0077:
									break;
								}
								break;
							}
						}
						if (current.level2 != 0f)
						{
							continue;
						}
						goto IL_00e4;
					}
					int num5 = 1193917746;
					goto IL_00e9;
					IL_00e4:
					num5 = 807928035;
					goto IL_00e9;
					IL_00e9:
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num5 ^ 0x3FAC9D3A)) % 4)
						{
						case 3u:
							break;
						default:
							goto end_IL_0129;
						case 1u:
							current.level2 = 0f - (float)current.level;
							num5 = (int)(num2 * 1923104595) ^ -43225509;
							continue;
						case 2u:
							goto IL_0129;
						case 0u:
							goto end_IL_0129;
						}
						break;
					}
					goto IL_00e4;
					continue;
					end_IL_0129:
					break;
				}
			}
			using (List<InternalSkillInstance>.Enumerator enumerator3 = InternalSkills.GetEnumerator())
			{
				InternalSkillInstance current2 = default(InternalSkillInstance);
				while (true)
				{
					IL_0268:
					if (enumerator3.MoveNext())
					{
						while (true)
						{
							current2 = enumerator3.Current;
							int num6 = 404189368;
							while (true)
							{
								uint num2;
								switch ((num2 = (uint)(num6 ^ 0x3FAC9D3A)) % 3)
								{
								case 0u:
									num6 = 186100231;
									continue;
								case 1u:
									break;
								default:
									goto end_IL_0180;
								}
								break;
							}
							continue;
							end_IL_0180:
							break;
						}
						current2.Owner = this;
						current2.RefreshUniquSkills();
						using (List<UniqueSkillInstance>.Enumerator enumerator2 = current2.UniqueSkills.GetEnumerator())
						{
							while (true)
							{
								IL_01e9:
								int num7;
								int num8;
								if (!enumerator2.MoveNext())
								{
									num7 = 163550931;
									num8 = num7;
								}
								else
								{
									num7 = 1873346209;
									num8 = num7;
								}
								while (true)
								{
									uint num2;
									switch ((num2 = (uint)(num7 ^ 0x3FAC9D3A)) % 4)
									{
									case 0u:
										num7 = 1873346209;
										continue;
									default:
										goto end_IL_01b3;
									case 3u:
										enumerator2.Current.Owner = this;
										num7 = 1590642624;
										continue;
									case 2u:
										break;
									case 1u:
										goto end_IL_01b3;
									}
									goto IL_01e9;
									continue;
									end_IL_01b3:
									break;
								}
								break;
							}
						}
						if (current2.level2 != 0f)
						{
							continue;
						}
						goto IL_0221;
					}
					int num9 = 1236260005;
					goto IL_0226;
					IL_0221:
					num9 = 256594535;
					goto IL_0226;
					IL_0226:
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num9 ^ 0x3FAC9D3A)) % 4)
						{
						case 2u:
							break;
						default:
							goto end_IL_0268;
						case 1u:
							current2.level2 = 0f - (float)current2.level;
							num9 = ((int)num2 * -1129359559) ^ -1840543777;
							continue;
						case 0u:
							goto IL_0268;
						case 3u:
							goto end_IL_0268;
						}
						break;
					}
					goto IL_0221;
					continue;
					end_IL_0268:
					break;
				}
			}
			using (List<SpecialSkillInstance>.Enumerator enumerator4 = SpecialSkills.GetEnumerator())
			{
				while (true)
				{
					IL_02d5:
					int num10;
					int num11;
					if (!enumerator4.MoveNext())
					{
						num10 = 1597078390;
						num11 = num10;
					}
					else
					{
						num10 = 1410423172;
						num11 = num10;
					}
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num10 ^ 0x3FAC9D3A)) % 4)
						{
						case 3u:
							num10 = 1410423172;
							continue;
						default:
							goto end_IL_029f;
						case 2u:
							enumerator4.Current.Owner = this;
							num10 = 1649705359;
							continue;
						case 1u:
							break;
						case 0u:
							goto end_IL_029f;
						}
						goto IL_02d5;
						continue;
						end_IL_029f:
						break;
					}
					break;
				}
			}
			if (EquippedInternalSkill != null)
			{
				goto IL_0307;
			}
			goto IL_0355;
			IL_0307:
			int num12 = 321477863;
			goto IL_030c;
			IL_030c:
			while (true)
			{
				uint num2;
				int num15;
				int num19;
				switch ((num2 = (uint)(num12 ^ 0x3FAC9D3A)) % 4)
				{
				case 0u:
					break;
				case 1u:
				{
					int num20;
					int num21;
					if (EquippedInternalSkill.IsUsed)
					{
						num20 = 509197329;
						num21 = num20;
					}
					else
					{
						num20 = 2082700032;
						num21 = num20;
					}
					num12 = num20 ^ (int)(num2 * 290241200);
					continue;
				}
				case 2u:
					goto IL_0355;
				default:
					{
						using (List<TitleInstance>.Enumerator enumerator5 = Titles.GetEnumerator())
						{
							while (true)
							{
								IL_03b2:
								int num13;
								int num14;
								if (enumerator5.MoveNext())
								{
									num13 = 903703363;
									num14 = num13;
								}
								else
								{
									num13 = 1445667598;
									num14 = num13;
								}
								while (true)
								{
									switch ((num2 = (uint)(num13 ^ 0x3FAC9D3A)) % 4)
									{
									case 2u:
										num13 = 903703363;
										continue;
									default:
										goto end_IL_037c;
									case 1u:
										enumerator5.Current.Owner = this;
										num13 = 284567577;
										continue;
									case 3u:
										break;
									case 0u:
										goto end_IL_037c;
									}
									goto IL_03b2;
									continue;
									end_IL_037c:
									break;
								}
								break;
							}
						}
						if (EquippedTitle == null)
						{
							goto IL_03e7;
						}
						goto IL_074c;
					}
					IL_03ec:
					while (true)
					{
						switch ((num2 = (uint)(num15 ^ 0x3FAC9D3A)) % 21)
						{
						case 10u:
							break;
						default:
							return;
						case 18u:
							goto IL_0456;
						case 12u:
							hp = maxhp;
							num15 = ((int)num2 * -318713064) ^ 0x7C9E3AD9;
							continue;
						case 2u:
							EquippedTitle = GetEquippedTitle();
							num15 = ((int)num2 * -1180474346) ^ 0x256CDA8B;
							continue;
						case 6u:
							Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(269729863u)] = jianfa;
							num15 = ((int)num2 * -1903236200) ^ 0x7F6CC2F3;
							continue;
						case 3u:
							leftpoint2 = leftpoint;
							num15 = ((int)num2 * -2089691797) ^ -879248157;
							continue;
						case 4u:
							Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3406067330u)] = dingli;
							Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2663905188u)] = wuxing;
							num15 = ((int)num2 * -598108937) ^ -381823992;
							continue;
						case 13u:
							Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1995100678u)] = maxhp;
							Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4229302121u)] = mp;
							num15 = ((int)num2 * -583027599) ^ -427907191;
							continue;
						case 19u:
							mp = maxmp;
							num15 = ((int)num2 * -1098838029) ^ 0x31D7CF1F;
							continue;
						case 15u:
							goto IL_05b8;
						case 5u:
							Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1564888282u)] = bili;
							Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(788062007u)] = fuyuan;
							num15 = (int)(num2 * 1887376530) ^ -542003631;
							continue;
						case 8u:
							goto IL_061d;
						case 11u:
							Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3054398905u)] = hp;
							num15 = 836349324;
							continue;
						case 0u:
							Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2186305609u)] = shenfa;
							num15 = (int)((num2 * 2121128068) ^ 0x743D5044);
							continue;
						case 14u:
							Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2223184606u)] = daofa;
							Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2981046594u)] = qimen;
							Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3436397321u)] = FemaleValue;
							num15 = ((int)num2 * -237676980) ^ 0xE8F527B;
							continue;
						case 16u:
							Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3051962998u)] = gengu;
							num15 = (int)(num2 * 1359074861) ^ -2127737604;
							continue;
						case 1u:
							Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1306348308u)] = maxmp;
							num15 = (int)(num2 * 576462715) ^ -1633861600;
							continue;
						case 20u:
							goto IL_074c;
						case 7u:
							exp2 = 0.0 - (double)exp;
							num15 = ((int)num2 * -142437370) ^ 0x3C6F0FA1;
							continue;
						case 9u:
							Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(199488088u)] = quanzhang;
							num15 = (int)(num2 * 633000052) ^ -652941845;
							continue;
						case 17u:
							return;
						}
						break;
						IL_061d:
						int num16;
						if (mp == 0)
						{
							num15 = 1373156389;
							num16 = num15;
						}
						else
						{
							num15 = 1352472178;
							num16 = num15;
						}
						continue;
						IL_05b8:
						int num17;
						if (hp == 0)
						{
							num15 = 1373942966;
							num17 = num15;
						}
						else
						{
							num15 = 295465977;
							num17 = num15;
						}
						continue;
						IL_0456:
						int num18;
						if (exp2 != 0.0)
						{
							num15 = 513750435;
							num18 = num15;
						}
						else
						{
							num15 = 1476399761;
							num18 = num15;
						}
					}
					goto IL_03e7;
					IL_074c:
					if (leftpoint2 != 0.0)
					{
						num15 = 1559535512;
						num19 = num15;
					}
					else
					{
						num15 = 1176027915;
						num19 = num15;
					}
					goto IL_03ec;
					IL_03e7:
					num15 = 2026859775;
					goto IL_03ec;
				}
				break;
			}
			goto IL_0307;
			IL_0355:
			EquippedInternalSkill = GetEquippedInternalSkill();
			num12 = 456287713;
			goto IL_030c;
		}
		catch
		{
			while (true)
			{
				int num22 = 530619103;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num22 ^ 0x3FAC9D3A)) % 3)
					{
					case 2u:
						break;
					default:
						return;
					case 1u:
						goto IL_07e6;
					case 0u:
						return;
					}
					break;
					IL_07e6:
					_200C_206D_200F_200B_202A_200F_200C_202C_200C_202E_206F_202C_202C_202C_206C_200B_200E_202B_206D_206C_200D_202B_206F_200B_200F_202C_206F_200D_202C_200E_202D_202B_202E_200F_202E_206D_202A_202C_200C_206F_202E((object)_202E_206F_206E_202D_206B_202D_200F_200B_200E_200C_206A_200D_200B_206B_202A_202D_206E_202A_206C_206B_202E_206A_206E_206B_202C_206B_206D_200D_202B_200C_206B_202C_202B_200F_202C_206E_206F_206B_200F_200E_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1645076579u), Key));
					num22 = ((int)num2 * -1321109447) ^ 0x20FEDC15;
				}
			}
		}
	}

	public string GetAnimation()
	{
		string result = default(string);
		if (EquippedTitle != null)
		{
			using List<string>.Enumerator enumerator = EquippedTitle.GetEQTriggers(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1526213692u)).GetEnumerator();
			string[] array = default(string[]);
			while (true)
			{
				IL_00da:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 1327112345;
					num2 = num;
				}
				else
				{
					num = 1989791767;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x52E47ED5)) % 9)
					{
					case 7u:
						num = 1989791767;
						continue;
					default:
						goto end_IL_0030;
					case 1u:
						array = _202B_202C_200F_202C_202E_202A_200C_206F_200F_202B_206A_202C_200F_200C_200E_206B_206F_202E_200E_206E_200B_206D_200F_200F_200C_206A_202D_206F_200E_200B_206E_200B_206A_206B_202E_202A_200F_206D_200F_202D_202E(enumerator.Current, new char[1] { ',' });
						num = 2144645973;
						continue;
					case 3u:
						result = array[2];
						goto IL_05bd;
					case 8u:
						result = array[1];
						goto IL_05bd;
					case 2u:
					{
						int num6;
						int num7;
						if (!Female)
						{
							num6 = 2141782152;
							num7 = num6;
						}
						else
						{
							num6 = 1330087831;
							num7 = num6;
						}
						num = num6 ^ ((int)num3 * -1913649116);
						continue;
					}
					case 4u:
						break;
					case 6u:
					{
						int num8;
						int num9;
						if (array.Length <= 1)
						{
							num8 = 779181418;
							num9 = num8;
						}
						else
						{
							num8 = 1323077617;
							num9 = num8;
						}
						num = num8 ^ (int)(num3 * 1449562899);
						continue;
					}
					case 5u:
					{
						int num4;
						int num5;
						if (array.Length <= 2)
						{
							num4 = -1354148740;
							num5 = num4;
						}
						else
						{
							num4 = -1132658313;
							num5 = num4;
						}
						num = num4 ^ (int)(num3 * 1526115490);
						continue;
					}
					case 0u:
						goto end_IL_0030;
					}
					goto IL_00da;
					continue;
					end_IL_0030:
					break;
				}
				break;
			}
		}
		using (List<string>.Enumerator enumerator = EquippedInternalSkill.GetEQTriggers(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2567659611u)).GetEnumerator())
		{
			string[] array2 = default(string[]);
			while (true)
			{
				IL_023d:
				int num10;
				int num11;
				if (!enumerator.MoveNext())
				{
					num10 = 1836198127;
					num11 = num10;
				}
				else
				{
					num10 = 1309005436;
					num11 = num10;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num10 ^ 0x52E47ED5)) % 10)
					{
					case 8u:
						num10 = 1309005436;
						continue;
					default:
						goto end_IL_0172;
					case 5u:
						array2 = _202B_202C_200F_202C_202E_202A_200C_206F_200F_202B_206A_202C_200F_200C_200E_206B_206F_202E_200E_206E_200B_206D_200F_200F_200C_206A_202D_206F_200E_200B_206E_200B_206A_206B_202E_202A_200F_206D_200F_202D_202E(enumerator.Current, new char[1] { ',' });
						num10 = 1780792158;
						continue;
					case 0u:
						result = array2[1];
						goto IL_05bd;
					case 4u:
					{
						int num14;
						int num15;
						if (array2.Length <= 2)
						{
							num14 = -1654277431;
							num15 = num14;
						}
						else
						{
							num14 = -2020573174;
							num15 = num14;
						}
						num10 = num14 ^ ((int)num3 * -1549485398);
						continue;
					}
					case 9u:
					{
						int num16;
						int num17;
						if (array2.Length <= 1)
						{
							num16 = 959535927;
							num17 = num16;
						}
						else
						{
							num16 = 1888582912;
							num17 = num16;
						}
						num10 = num16 ^ ((int)num3 * -10935869);
						continue;
					}
					case 3u:
						break;
					case 6u:
					{
						int num12;
						int num13;
						if (Female)
						{
							num12 = 1777184739;
							num13 = num12;
						}
						else
						{
							num12 = 1078882497;
							num13 = num12;
						}
						num10 = num12 ^ ((int)num3 * -1698946769);
						continue;
					}
					case 1u:
						result = array2[2];
						num10 = ((int)num3 * -944888832) ^ 0x1505E1A4;
						continue;
					case 2u:
						goto end_IL_0172;
					case 7u:
						goto IL_05bd;
					}
					goto IL_023d;
					continue;
					end_IL_0172:
					break;
				}
				break;
			}
		}
		string[] array3 = default(string[]);
		foreach (SkillInstance skill in Skills)
		{
			using List<string>.Enumerator enumerator = skill.GetEQTriggers(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1526213692u)).GetEnumerator();
			while (true)
			{
				IL_0319:
				int num18;
				int num19;
				if (enumerator.MoveNext())
				{
					num18 = 720566648;
					num19 = num18;
				}
				else
				{
					num18 = 145378146;
					num19 = num18;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num18 ^ 0x52E47ED5)) % 10)
					{
					case 3u:
						num18 = 720566648;
						continue;
					default:
						goto end_IL_02db;
					case 4u:
						break;
					case 5u:
					{
						array3 = _202B_202C_200F_202C_202E_202A_200C_206F_200F_202B_206A_202C_200F_200C_200E_206B_206F_202E_200E_206E_200B_206D_200F_200F_200C_206A_202D_206F_200E_200B_206E_200B_206A_206B_202E_202A_200F_206D_200F_202D_202E(enumerator.Current, new char[1] { ',' });
						int num24;
						if (array3.Length > 1)
						{
							num18 = 2049271715;
							num24 = num18;
						}
						else
						{
							num18 = 1885743271;
							num24 = num18;
						}
						continue;
					}
					case 1u:
						result = array3[2];
						num18 = (int)(num3 * 1843447586) ^ -1102849711;
						continue;
					case 7u:
						result = array3[1];
						num18 = 1180471539;
						continue;
					case 6u:
					{
						int num22;
						int num23;
						if (!Female)
						{
							num22 = -229915292;
							num23 = num22;
						}
						else
						{
							num22 = -1052433155;
							num23 = num22;
						}
						num18 = num22 ^ ((int)num3 * -2025225847);
						continue;
					}
					case 2u:
					{
						int num20;
						int num21;
						if (array3.Length > 2)
						{
							num20 = -1183047586;
							num21 = num20;
						}
						else
						{
							num20 = -1771837274;
							num21 = num20;
						}
						num18 = num20 ^ (int)(num3 * 1862354430);
						continue;
					}
					case 9u:
						goto end_IL_02db;
					case 0u:
					case 8u:
						goto IL_05bd;
					}
					goto IL_0319;
					continue;
					end_IL_02db:
					break;
				}
				break;
			}
		}
		IEnumerator<Trigger> enumerator3 = GetTriggers(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2097782500u)).GetEnumerator();
		try
		{
			Trigger current = default(Trigger);
			while (true)
			{
				IL_0558:
				int num25;
				int num26;
				if (!_202A_206A_206F_206D_206E_206A_200E_202E_206A_200B_206E_200D_206A_200D_206E_202B_200E_206D_202C_200B_200F_206C_202C_206A_202C_206D_200C_206F_206D_200E_202A_206E_206B_200E_202E_206C_206F_200F_206B_200C_202E((IEnumerator)enumerator3))
				{
					num25 = 2048825116;
					num26 = num25;
				}
				else
				{
					num25 = 286540576;
					num26 = num25;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num25 ^ 0x52E47ED5)) % 9)
					{
					case 6u:
						num25 = 286540576;
						continue;
					default:
						goto end_IL_0451;
					case 2u:
					{
						int num31;
						int num32;
						if (Female)
						{
							num31 = 377283465;
							num32 = num31;
						}
						else
						{
							num31 = 316138150;
							num32 = num31;
						}
						num25 = num31 ^ (int)(num3 * 1588142256);
						continue;
					}
					case 0u:
						result = current.Argvs[1];
						goto IL_05bd;
					case 4u:
						current = enumerator3.Current;
						num25 = 1169876550;
						continue;
					case 1u:
						result = current.Argvs[2];
						goto IL_05bd;
					case 3u:
					{
						int num29;
						int num30;
						if (current.Argvs.Count <= 2)
						{
							num29 = 1254284938;
							num30 = num29;
						}
						else
						{
							num29 = 465184862;
							num30 = num29;
						}
						num25 = num29 ^ ((int)num3 * -573581075);
						continue;
					}
					case 5u:
					{
						int num27;
						int num28;
						if (current.Argvs.Count <= 1)
						{
							num27 = 684266199;
							num28 = num27;
						}
						else
						{
							num27 = 680982110;
							num28 = num27;
						}
						num25 = num27 ^ ((int)num3 * -1224091999);
						continue;
					}
					case 8u:
						break;
					case 7u:
						goto end_IL_0451;
					}
					goto IL_0558;
					continue;
					end_IL_0451:
					break;
				}
				break;
			}
		}
		finally
		{
			if (enumerator3 != null)
			{
				while (true)
				{
					IL_057b:
					int num33 = 321346695;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num33 ^ 0x52E47ED5)) % 3)
						{
						case 2u:
							break;
						default:
							goto end_IL_0580;
						case 1u:
							goto IL_059e;
						case 0u:
							goto end_IL_0580;
						}
						goto IL_057b;
						IL_059e:
						_202D_200E_200B_206B_200E_206D_200F_200C_202B_200F_202A_202A_206D_206D_206B_202B_202C_206D_206B_202D_202A_206A_202E_200B_202B_200C_202E_200D_206B_202C_202C_202E_206E_202C_202B_206D_202E_202C_200F_200E_202E((IDisposable)enumerator3);
						num33 = ((int)num3 * -1444659826) ^ -477167380;
						continue;
						end_IL_0580:
						break;
					}
					break;
				}
			}
		}
		return Animation;
		IL_05bd:
		return result;
	}

	public ItemInstance GetEquipment(ItemType type)
	{
		if (type == ItemType.Book)
		{
			while (true)
			{
				uint num;
				switch ((num = 813601330u) % 3)
				{
				case 2u:
					continue;
				case 1u:
					return GetEquipment(12);
				}
				break;
			}
		}
		return GetEquipment((int)type);
	}

	public ItemInstance GetEquipment(int type)
	{
		if (Equipment == null)
		{
			goto IL_0008;
		}
		goto IL_007f;
		IL_0008:
		int num = 879846779;
		goto IL_000d;
		IL_000d:
		List<int> list = default(List<int>);
		ItemInstance result = default(ItemInstance);
		ItemInstance current = default(ItemInstance);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x7DEEC62F)) % 6)
			{
			case 4u:
				break;
			case 2u:
				return null;
			case 3u:
			{
				int num6;
				int num7;
				if (type != 12)
				{
					num6 = 1709723324;
					num7 = num6;
				}
				else
				{
					num6 = 266597459;
					num7 = num6;
				}
				num = num6 ^ (int)(num2 * 166668710);
				continue;
			}
			case 0u:
				list.Add(4);
				num = ((int)num2 * -987721540) ^ -1591717762;
				continue;
			case 5u:
				goto IL_007f;
			default:
			{
				using (List<ItemInstance>.Enumerator enumerator = Equipment.GetEnumerator())
				{
					while (true)
					{
						IL_00d3:
						int num3;
						int num4;
						if (!enumerator.MoveNext())
						{
							num3 = 1531250334;
							num4 = num3;
						}
						else
						{
							num3 = 1071120025;
							num4 = num3;
						}
						while (true)
						{
							switch ((num2 = (uint)(num3 ^ 0x7DEEC62F)) % 6)
							{
							case 0u:
								num3 = 1071120025;
								continue;
							default:
								goto end_IL_00a9;
							case 3u:
								break;
							case 2u:
								result = current;
								num3 = (int)((num2 * 1577287047) ^ 0x3419AFD2);
								continue;
							case 4u:
							{
								current = enumerator.Current;
								int num5;
								if (list.Contains(current.type))
								{
									num3 = 1949083401;
									num5 = num3;
								}
								else
								{
									num3 = 35636210;
									num5 = num3;
								}
								continue;
							}
							case 5u:
								goto end_IL_00a9;
							case 1u:
								return result;
							}
							goto IL_00d3;
							continue;
							end_IL_00a9:
							break;
						}
						break;
					}
				}
				return null;
			}
			}
			break;
		}
		goto IL_0008;
		IL_007f:
		list = new List<int>();
		list.Add(type);
		num = 1372068536;
		goto IL_000d;
	}

	public Role Clone()
	{
		Role role = BasePojo.Create<Role>(Xml);
		role.Xml = Xml;
		return role;
	}

	public void Reset(bool recover = true)
	{
		if (recover)
		{
			goto IL_0003;
		}
		goto IL_0045;
		IL_0003:
		int num = 447498826;
		goto IL_0008;
		IL_0008:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x6E4168EA)) % 10)
			{
			case 0u:
				break;
			default:
				return;
			case 3u:
				goto IL_0045;
			case 9u:
				Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1678197155u)] = 1;
				num = ((int)num2 * -1915224292) ^ -316139374;
				continue;
			case 2u:
				Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3054398905u)] = Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1796919217u)];
				Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4229302121u)] = Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(475395429u)];
				num = (int)(num2 * 1665678184) ^ -822577933;
				continue;
			case 1u:
				SkillCdRecover();
				num = ((int)num2 * -576266741) ^ 0x5E3556D3;
				continue;
			case 5u:
				num = (int)(num2 * 1372825102) ^ -204281568;
				continue;
			case 4u:
				Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2873590287u)] = 1;
				num = (int)((num2 * 1350068502) ^ 0x7CF5722F);
				continue;
			case 7u:
				goto IL_014e;
			case 8u:
				balls = 0;
				num = 1742003845;
				continue;
			case 6u:
				return;
			}
			break;
			IL_014e:
			int num3;
			if (Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1678197155u)] > 0)
			{
				num = 2062992510;
				num3 = num;
			}
			else
			{
				num = 357555207;
				num3 = num;
			}
		}
		goto IL_0003;
		IL_0045:
		int num4;
		if (Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1524427486u)] <= 0)
		{
			num = 1533263020;
			num4 = num;
		}
		else
		{
			num = 1177257515;
			num4 = num;
		}
		goto IL_0008;
	}

	public void SkillCdRecover()
	{
		List<SkillInstance>.Enumerator enumerator = Skills.GetEnumerator();
		try
		{
			UniqueSkillInstance current2 = default(UniqueSkillInstance);
			while (enumerator.MoveNext())
			{
				SkillInstance current;
				while (true)
				{
					current = enumerator.Current;
					int num = 1375135355;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ 0x7D6AACEE)) % 4)
						{
						case 0u:
							num = 184032461;
							continue;
						case 3u:
							break;
						case 1u:
							current.CurrentCd = 0;
							num = ((int)num2 * -44838629) ^ -1323343653;
							continue;
						default:
							goto end_IL_0038;
						}
						break;
					}
					continue;
					end_IL_0038:
					break;
				}
				List<UniqueSkillInstance>.Enumerator enumerator2 = current.UniqueSkills.GetEnumerator();
				try
				{
					while (true)
					{
						IL_0097:
						int num3;
						int num4;
						if (!enumerator2.MoveNext())
						{
							num3 = 2122793753;
							num4 = num3;
						}
						else
						{
							num3 = 1706788193;
							num4 = num3;
						}
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num3 ^ 0x7D6AACEE)) % 5)
							{
							case 0u:
								num3 = 1706788193;
								continue;
							default:
								goto end_IL_0071;
							case 3u:
								break;
							case 4u:
								current2.CurrentCd = 0;
								num3 = ((int)num2 * -476395005) ^ -23879988;
								continue;
							case 2u:
								current2 = enumerator2.Current;
								num3 = 992805377;
								continue;
							case 1u:
								goto end_IL_0071;
							}
							goto IL_0097;
							continue;
							end_IL_0071:
							break;
						}
						break;
					}
				}
				finally
				{
					_202D_200E_200B_206B_200E_206D_200F_200C_202B_200F_202A_202A_206D_206D_206B_202B_202C_206D_206B_202D_202A_206A_202E_200B_202B_200C_202E_200D_206B_202C_202C_202E_206E_202C_202B_206D_202E_202C_200F_200E_202E((IDisposable)enumerator2);
				}
			}
		}
		finally
		{
			_202D_200E_200B_206B_200E_206D_200F_200C_202B_200F_202A_202A_206D_206D_206B_202B_202C_206D_206B_202D_202A_206A_202E_200B_202B_200C_202E_200D_206B_202C_202C_202E_206E_202C_202B_206D_202E_202C_200F_200E_202E((IDisposable)enumerator);
		}
		List<InternalSkillInstance>.Enumerator enumerator3 = InternalSkills.GetEnumerator();
		try
		{
			UniqueSkillInstance current4 = default(UniqueSkillInstance);
			while (enumerator3.MoveNext())
			{
				InternalSkillInstance current3;
				while (true)
				{
					current3 = enumerator3.Current;
					int num5 = 338206223;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num5 ^ 0x7D6AACEE)) % 3)
						{
						case 0u:
							num5 = 1202788771;
							continue;
						case 1u:
							break;
						default:
							goto end_IL_0134;
						}
						break;
					}
					continue;
					end_IL_0134:
					break;
				}
				List<UniqueSkillInstance>.Enumerator enumerator4 = current3.UniqueSkills.GetEnumerator();
				try
				{
					while (true)
					{
						IL_018f:
						int num6;
						int num7;
						if (!enumerator4.MoveNext())
						{
							num6 = 1973420549;
							num7 = num6;
						}
						else
						{
							num6 = 446968525;
							num7 = num6;
						}
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num6 ^ 0x7D6AACEE)) % 5)
							{
							case 0u:
								num6 = 446968525;
								continue;
							default:
								goto end_IL_0159;
							case 2u:
								current4 = enumerator4.Current;
								num6 = 571426485;
								continue;
							case 3u:
								break;
							case 1u:
								current4.CurrentCd = 0;
								num6 = ((int)num2 * -1709068156) ^ 0x26B5697F;
								continue;
							case 4u:
								goto end_IL_0159;
							}
							goto IL_018f;
							continue;
							end_IL_0159:
							break;
						}
						break;
					}
				}
				finally
				{
					_202D_200E_200B_206B_200E_206D_200F_200C_202B_200F_202A_202A_206D_206D_206B_202B_202C_206D_206B_202D_202A_206A_202E_200B_202B_200C_202E_200D_206B_202C_202C_202E_206E_202C_202B_206D_202E_202C_200F_200E_202E((IDisposable)enumerator4);
				}
			}
		}
		finally
		{
			_202D_200E_200B_206B_200E_206D_200F_200C_202B_200F_202A_202A_206D_206D_206B_202B_202C_206D_206B_202D_202A_206A_202E_200B_202B_200C_202E_200D_206B_202C_202C_202E_206E_202C_202B_206D_202E_202C_200F_200E_202E((IDisposable)enumerator3);
		}
		List<SpecialSkillInstance>.Enumerator enumerator5 = SpecialSkills.GetEnumerator();
		try
		{
			while (true)
			{
				int num8;
				int num9;
				if (enumerator5.MoveNext())
				{
					num8 = 2003180401;
					num9 = num8;
				}
				else
				{
					num8 = 1656153219;
					num9 = num8;
				}
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num8 ^ 0x7D6AACEE)) % 4)
					{
					case 0u:
						num8 = 2003180401;
						continue;
					default:
						return;
					case 3u:
					{
						SpecialSkillInstance current5 = enumerator5.Current;
						current5.CurrentCd = 0;
						num8 = 614784724;
						continue;
					}
					case 2u:
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
			_202D_200E_200B_206B_200E_206D_200F_200C_202B_200F_202A_202A_206D_206D_206B_202B_202C_206D_206B_202D_202A_206A_202E_200B_202B_200C_202E_200D_206B_202C_202C_202E_206E_202C_202B_206D_202E_202C_200F_200E_202E((IDisposable)enumerator5);
		}
	}

	public void AddTalent(string talent)
	{
		Talents.Add(talent);
		while (true)
		{
			int num = -920274913;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1596025134)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_002e;
				case 2u:
					return;
				}
				break;
				IL_002e:
				RuntimeData.Instance.RefreshTeamMemberPanel(this, refreshImage: false, refreshText: true);
				num = ((int)num2 * -1166263160) ^ 0x2FB1C4AE;
			}
		}
	}

	public bool RemoveTalent(string talent)
	{
		if (Talents.Contains(talent))
		{
			while (true)
			{
				int num = -890097520;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1037988675)) % 5)
					{
					case 0u:
						break;
					case 2u:
						Talents.Remove(talent);
						num = ((int)num2 * -280056372) ^ -298340868;
						continue;
					case 1u:
						return true;
					case 3u:
						RuntimeData.Instance.RefreshTeamMemberPanel(this, refreshImage: false, refreshText: true);
						num = ((int)num2 * -148125137) ^ -1376810976;
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
		return false;
	}

	public bool HasTalent(string talent)
	{
		if (Talents.Contains(talent))
		{
			goto IL_0011;
		}
		goto IL_00b2;
		IL_0011:
		int num = -525874225;
		goto IL_0016;
		IL_0016:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1557260922)) % 8)
			{
			case 2u:
				break;
			case 7u:
				goto IL_004a;
			case 0u:
			{
				int num3;
				int num4;
				if (EquippedInternalSkill.HasTalent(talent))
				{
					num3 = 101990347;
					num4 = num3;
				}
				else
				{
					num3 = 738121269;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 134657238);
				continue;
			}
			case 1u:
				return true;
			case 6u:
				return true;
			case 4u:
				goto IL_00b2;
			case 5u:
				return true;
			default:
				goto IL_00e8;
			}
			break;
			IL_004a:
			int num5;
			if (EquippedInternalSkill != null)
			{
				num = -456322754;
				num5 = num;
			}
			else
			{
				num = -1197897755;
				num5 = num;
			}
		}
		goto IL_0011;
		IL_00b2:
		int num6;
		if (EquipmentTalents.Contains(talent))
		{
			num = -2138967160;
			num6 = num;
		}
		else
		{
			num = -804485007;
			num6 = num;
		}
		goto IL_0016;
		IL_0247:
		bool result = default(bool);
		return result;
		IL_00e8:
		using (List<SkillInstance>.Enumerator enumerator = Skills.GetEnumerator())
		{
			SkillInstance current = default(SkillInstance);
			while (true)
			{
				IL_013e:
				int num7;
				int num8;
				if (enumerator.MoveNext())
				{
					num7 = -1857620590;
					num8 = num7;
				}
				else
				{
					num7 = -983522687;
					num8 = num7;
				}
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num7 ^ -1557260922)) % 8)
					{
					case 5u:
						num7 = -1857620590;
						continue;
					default:
						goto end_IL_00fb;
					case 4u:
						current = enumerator.Current;
						num7 = -1148037660;
						continue;
					case 6u:
						break;
					case 1u:
					{
						int num11;
						int num12;
						if (!current.HasTalent(talent))
						{
							num11 = 350551631;
							num12 = num11;
						}
						else
						{
							num11 = 692961970;
							num12 = num11;
						}
						num7 = num11 ^ ((int)num2 * -2003135249);
						continue;
					}
					case 2u:
					{
						int num9;
						int num10;
						if (current == null)
						{
							num9 = -514486582;
							num10 = num9;
						}
						else
						{
							num9 = -690805491;
							num10 = num9;
						}
						num7 = num9 ^ (int)(num2 * 636529769);
						continue;
					}
					case 3u:
						result = true;
						num7 = ((int)num2 * -1124302413) ^ 0x783E01CF;
						continue;
					case 7u:
						goto end_IL_00fb;
					case 0u:
						goto IL_0247;
					}
					goto IL_013e;
					continue;
					end_IL_00fb:
					break;
				}
				break;
			}
		}
		if (EquippedTitle != null)
		{
			while (true)
			{
				int num13 = -842504604;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num13 ^ -1557260922)) % 5)
					{
					case 0u:
						break;
					case 1u:
					{
						int num14;
						int num15;
						if (EquippedTitle.HasTalent(talent))
						{
							num14 = -1676769417;
							num15 = num14;
						}
						else
						{
							num14 = -481028312;
							num15 = num14;
						}
						num13 = num14 ^ ((int)num2 * -454075838);
						continue;
					}
					case 2u:
						return true;
					case 4u:
						goto end_IL_01dc;
					default:
						goto IL_0247;
					}
					break;
				}
				continue;
				end_IL_01dc:
				break;
			}
		}
		return false;
	}

	public InternalSkillInstance GetEquippedInternalSkill()
	{
		List<InternalSkillInstance>.Enumerator enumerator = InternalSkills.GetEnumerator();
		InternalSkillInstance result = default(InternalSkillInstance);
		try
		{
			InternalSkillInstance current = default(InternalSkillInstance);
			while (true)
			{
				IL_0038:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 500635705;
					num2 = num;
				}
				else
				{
					num = 778463200;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x448B9BC4)) % 5)
					{
					case 4u:
						num = 778463200;
						continue;
					default:
						goto end_IL_0013;
					case 3u:
						break;
					case 2u:
						result = current;
						return result;
					case 1u:
					{
						current = enumerator.Current;
						int num4;
						if (current.IsUsed)
						{
							num = 305039706;
							num4 = num;
						}
						else
						{
							num = 2101849;
							num4 = num;
						}
						continue;
					}
					case 0u:
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
		finally
		{
			_202D_200E_200B_206B_200E_206D_200F_200C_202B_200F_202A_202A_206D_206D_206B_202B_202C_206D_206B_202D_202A_206A_202E_200B_202B_200C_202E_200D_206B_202C_202C_202E_206E_202C_202B_206D_202E_202C_200F_200E_202E((IDisposable)enumerator);
		}
		if (InternalSkills.Count > 0)
		{
			while (true)
			{
				int num5 = 329038529;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num5 ^ 0x448B9BC4)) % 5)
					{
					case 0u:
						break;
					case 3u:
						InternalSkills[0].equipped = 1;
						num5 = (int)(num3 * 1484057196) ^ -1106975433;
						continue;
					case 1u:
						return InternalSkills[0];
					case 4u:
						goto end_IL_00a5;
					default:
						return result;
					}
					break;
				}
				continue;
				end_IL_00a5:
				break;
			}
		}
		return null;
	}

	public void SetEquippedInternalSkill(InternalSkillInstance skill)
	{
		using (List<InternalSkillInstance>.Enumerator enumerator = InternalSkills.GetEnumerator())
		{
			while (true)
			{
				IL_0048:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -2043895791;
					num2 = num;
				}
				else
				{
					num = -1200603550;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -517487496)) % 4)
					{
					case 0u:
						num = -1200603550;
						continue;
					default:
						goto end_IL_0013;
					case 2u:
						enumerator.Current.equipped = 0;
						num = -615083729;
						continue;
					case 3u:
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
		skill.equipped = 1;
		EquippedInternalSkill = skill;
	}

	public IEnumerable<SkillBox> GetAvaliableSkills()
	{
		bool flag = default(bool);
		List<SpecialSkillInstance>.Enumerator enumerator = default(List<SpecialSkillInstance>.Enumerator);
		SpecialSkillInstance current = default(SpecialSkillInstance);
		List<SkillInstance>.Enumerator enumerator2 = default(List<SkillInstance>.Enumerator);
		UniqueSkillInstance current2 = default(UniqueSkillInstance);
		List<UniqueSkillInstance>.Enumerator enumerator3 = default(List<UniqueSkillInstance>.Enumerator);
		InternalSkillInstance equippedInternalSkill = default(InternalSkillInstance);
		List<UniqueSkillInstance>.Enumerator enumerator4 = default(List<UniqueSkillInstance>.Enumerator);
		SkillInstance current4 = default(SkillInstance);
		UniqueSkillInstance current3 = default(UniqueSkillInstance);
		while (true)
		{
			int num = 918083297;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7B86046B)) % 4)
				{
				case 0u:
					break;
				case 2u:
				{
					flag = false;
					uint num3;
					switch (num3)
					{
					case 0u:
						goto IL_0073;
					case 1u:
						goto IL_008c;
					case 2u:
					case 3u:
						goto IL_0203;
					case 4u:
						goto IL_055d;
					}
					goto IL_0050;
				}
				case 1u:
					yield break;
				default:
					goto IL_0073;
					IL_0073:
					enumerator = SpecialSkills.GetEnumerator();
					goto IL_008c;
					IL_008c:
					try
					{
						while (true)
						{
							IL_0098:
							int num4 = 1689166892;
							while (true)
							{
								switch ((num2 = (uint)(num4 ^ 0x7B86046B)) % 10)
								{
								case 0u:
									break;
								default:
									goto end_IL_009d;
								case 7u:
									num4 = ((int)num2 * -1576421935) ^ -1283077677;
									continue;
								case 5u:
									num4 = ((!enumerator.MoveNext()) ? 1818986193 : 1030344322);
									continue;
								case 1u:
									num4 = (int)(num2 * 1014109817) ^ -1584615887;
									continue;
								case 9u:
									current = enumerator.Current;
									num4 = 945675303;
									continue;
								case 8u:
									num4 = (current.IsUsed ? 1090434845 : 1244247807) ^ ((int)num2 * -844666102);
									continue;
								case 2u:
									yield return current;
									/*Error: Unable to find new state assignment for yield return*/;
								case 3u:
									flag = true;
									goto IL_06fe;
								case 4u:
									num4 = (int)(num2 * 926405119) ^ -974203216;
									continue;
								}
								goto IL_0098;
								continue;
								end_IL_009d:
								break;
							}
							break;
						}
					}
					finally
					{
						if (!flag)
						{
							goto IL_01d9;
						}
						while (true)
						{
							switch (952768270u % 3u)
							{
							case 0u:
								continue;
							case 1u:
								goto end_IL_01a7;
							}
							goto IL_01d9;
							continue;
							end_IL_01a7:
							break;
						}
						goto end_IL_01a4;
						IL_01d9:
						_200D_200E_202A_202D_206D_206F_202B_202A_200C_200B_202B_206B_202B_200B_206A_206B_202A_206D_206F_206F_206A_206D_200E_206C_202B_202D_200E_206C_200B_200B_202A_200F_206C_200F_206C_200C_206B_200B_206E_206A_202E._206A_206B_200B_202B_200B_202C_206A_200D_200B_206C_200C_202A_206B_202A_206C_206A_200C_206C_200D_202A_202C_200E_200E_200F_206F_202D_202A_200E_200E_202C_206F_202B_202D_200C_202A_200D_200F_202C_202E_200F_202E((IDisposable)enumerator);
						end_IL_01a4:;
					}
					enumerator2 = Skills.GetEnumerator();
					goto IL_0203;
					IL_055d:
					try
					{
						while (true)
						{
							IL_0569:
							int num5 = 1874213782;
							while (true)
							{
								switch ((num2 = (uint)(num5 ^ 0x7B86046B)) % 9)
								{
								case 2u:
									break;
								default:
									goto end_IL_056e;
								case 6u:
									num5 = ((int)num2 * -1329156648) ^ 0x15526718;
									continue;
								case 7u:
									num5 = (int)((num2 * 690269075) ^ 0xB8719CE);
									continue;
								case 4u:
									flag = true;
									num5 = ((int)num2 * -462397673) ^ -542515188;
									continue;
								case 8u:
									yield return current2;
									/*Error: Unable to find new state assignment for yield return*/;
								case 5u:
									num5 = ((!enumerator3.MoveNext()) ? 2024112315 : 312681365);
									continue;
								case 0u:
									current2 = enumerator3.Current;
									num5 = ((equippedInternalSkill.level < current2.UniqueSkill.RequireLevel) ? 83071328 : 960433971);
									continue;
								case 1u:
									goto IL_06fe;
								}
								goto IL_0569;
								continue;
								end_IL_056e:
								break;
							}
							break;
						}
					}
					finally
					{
						if (flag)
						{
							goto IL_067a;
						}
						goto IL_06b0;
						IL_067a:
						int num6 = 314233934;
						goto IL_067f;
						IL_067f:
						switch ((uint)(num6 ^ 0x7B86046B) % 4u)
						{
						case 2u:
							break;
						default:
							goto end_IL_0677;
						case 1u:
							goto end_IL_0677;
						case 3u:
							goto IL_06b0;
						case 0u:
							goto end_IL_0677;
						}
						goto IL_067a;
						IL_06b0:
						_200D_200E_202A_202D_206D_206F_202B_202A_200C_200B_202B_206B_202B_200B_206A_206B_202A_206D_206F_206F_206A_206D_200E_206C_202B_202D_200E_206C_200B_200B_202A_200F_206C_200F_206C_200C_206B_200B_206E_206A_202E._206A_206B_200B_202B_200B_202C_206A_200D_200B_206C_200C_202A_206B_202A_206C_206A_200C_206C_200D_202A_202C_200E_200E_200F_206F_202D_202A_200E_200E_202C_206F_202B_202D_200C_202A_200D_200F_202C_202E_200F_202E((IDisposable)enumerator3);
						num6 = 1413353423;
						goto IL_067f;
						end_IL_0677:;
					}
					goto IL_06cf;
					IL_0203:
					try
					{
						while (true)
						{
							IL_0213:
							int num7 = 2100532734;
							while (true)
							{
								switch ((num2 = (uint)(num7 ^ 0x7B86046B)) % 10)
								{
								case 4u:
									break;
								case 8u:
									enumerator4 = current4.UniqueSkills.GetEnumerator();
									num7 = 1387809472;
									continue;
								case 2u:
									flag = true;
									num7 = ((int)num2 * -126788232) ^ -1292086860;
									continue;
								case 3u:
									goto end_IL_0218;
								case 5u:
									current4 = enumerator2.Current;
									num7 = 149323657;
									continue;
								case 0u:
									num7 = ((!current4.IsUsed) ? 1476897958 : 1949107143) ^ (int)(num2 * 208207958);
									continue;
								case 6u:
									yield return current4;
									/*Error: Unable to find 'return true' for yield return*/;
								default:
									try
									{
										while (true)
										{
											IL_0335:
											int num8 = 935984956;
											while (true)
											{
												switch ((num2 = (uint)(num8 ^ 0x7B86046B)) % 9)
												{
												case 3u:
													break;
												default:
													goto end_IL_033a;
												case 8u:
													num8 = (int)((num2 * 679474327) ^ 0x6DAB7553);
													continue;
												case 7u:
													yield return current3;
													/*Error: Unable to find new state assignment for yield return*/;
												case 2u:
													flag = true;
													num8 = (int)((num2 * 1934127682) ^ 0x5AD0EA37);
													continue;
												case 6u:
													num8 = ((!enumerator4.MoveNext()) ? 1703671590 : 116751535);
													continue;
												case 4u:
													current3 = enumerator4.Current;
													num8 = ((current4.level < current3.UniqueSkill.RequireLevel) ? 330602271 : 174659113);
													continue;
												case 5u:
													goto end_IL_0218;
												case 1u:
													num8 = (int)(num2 * 598584519) ^ -564051010;
													continue;
												}
												goto IL_0335;
												continue;
												end_IL_033a:
												break;
											}
											break;
										}
									}
									finally
									{
										if (flag)
										{
											goto IL_0446;
										}
										goto IL_047c;
										IL_0446:
										int num9 = 484999373;
										goto IL_044b;
										IL_044b:
										switch ((uint)(num9 ^ 0x7B86046B) % 4u)
										{
										case 0u:
											break;
										default:
											goto end_IL_0443;
										case 2u:
											goto end_IL_0443;
										case 1u:
											goto IL_047c;
										case 3u:
											goto end_IL_0443;
										}
										goto IL_0446;
										IL_047c:
										_200D_200E_202A_202D_206D_206F_202B_202A_200C_200B_202B_206B_202B_200B_206A_206B_202A_206D_206F_206F_206A_206D_200E_206C_202B_202D_200E_206C_200B_200B_202A_200F_206C_200F_206C_200C_206B_200B_206E_206A_202E._206A_206B_200B_202B_200B_202C_206A_200D_200B_206C_200C_202A_206B_202A_206C_206A_200C_206C_200D_202A_202C_200E_200E_200F_206F_202D_202A_200E_200E_202C_206F_202B_202D_200C_202A_200D_200F_202C_202E_200F_202E((IDisposable)enumerator4);
										num9 = 251417644;
										goto IL_044b;
										end_IL_0443:;
									}
									goto case 1u;
								case 1u:
								case 9u:
									if (enumerator2.MoveNext())
									{
										goto case 5u;
									}
									goto IL_04f7;
								}
								goto IL_0213;
								continue;
								end_IL_0218:
								break;
							}
							break;
						}
					}
					finally
					{
						if (flag)
						{
							goto IL_04a9;
						}
						goto IL_04df;
						IL_04a9:
						int num10 = 750318706;
						goto IL_04ae;
						IL_04ae:
						switch ((uint)(num10 ^ 0x7B86046B) % 4u)
						{
						case 2u:
							break;
						default:
							goto end_IL_04a6;
						case 1u:
							goto end_IL_04a6;
						case 3u:
							goto IL_04df;
						case 0u:
							goto end_IL_04a6;
						}
						goto IL_04a9;
						IL_04df:
						_200D_200E_202A_202D_206D_206F_202B_202A_200C_200B_202B_206B_202B_200B_206A_206B_202A_206D_206F_206F_206A_206D_200E_206C_202B_202D_200E_206C_200B_200B_202A_200F_206C_200F_206C_200C_206B_200B_206E_206A_202E._206A_206B_200B_202B_200B_202C_206A_200D_200B_206C_200C_202A_206B_202A_206C_206A_200C_206C_200D_202A_202C_200E_200E_200F_206F_202D_202A_200E_200E_202C_206F_202B_202D_200C_202A_200D_200F_202C_202E_200F_202E((IDisposable)enumerator2);
						num10 = 1479346011;
						goto IL_04ae;
						end_IL_04a6:;
					}
					goto IL_06fe;
					IL_04f7:
					equippedInternalSkill = EquippedInternalSkill;
					while (true)
					{
						int num11 = 1580304870;
						while (true)
						{
							switch ((num2 = (uint)(num11 ^ 0x7B86046B)) % 3)
							{
							case 0u:
								break;
							case 1u:
								goto IL_052a;
							default:
								goto end_IL_0508;
							}
							break;
							IL_052a:
							if (equippedInternalSkill != null)
							{
								num11 = ((int)num2 * -556471228) ^ -1039333041;
								continue;
							}
							goto IL_06cf;
						}
						continue;
						end_IL_0508:
						break;
					}
					enumerator3 = equippedInternalSkill.UniqueSkills.GetEnumerator();
					goto IL_055d;
					IL_06cf:
					while (true)
					{
						switch (10550750u % 4u)
						{
						case 0u:
							continue;
						case 2u:
							yield break;
						case 1u:
							break;
						default:
							yield break;
						case 3u:
							yield break;
						}
						break;
					}
					goto IL_06fe;
					IL_06fe:
					/*Error near IL_06ff: Unexpected return in MoveNext()*/;
				}
				break;
				IL_0050:
				num = (int)((num2 * 30925443) ^ 0x771F543C);
			}
		}
	}

	public IEnumerable<Trigger> GetTriggers(string name)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _202C_206A_206C_200D_206B_200C_202D_202D_200B_206C_202E_200C_202B_206D_206D_200F_202E_200D_200E_200C_202A_200C_200F_202B_200E_206C_206C_200B_206A_206A_202A_200F_206E_200C_206E_202D_206A_202B_202B_202C_202E(-2)
		{
			_202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E = this,
			_202B_206F_200C_202E_206C_202E_206E_206A_200F_206D_206D_200C_200E_202C_200B_206E_200C_206B_200F_206B_200C_200D_200B_200E_202A_202C_206A_200B_202A_202E_206D_200C_202A_200C_200D_200C_202D_202E_202B_200D_202E = name
		};
	}

	public IEnumerable<Trigger> GetAllTriggers()
	{
		//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
		return new _206C_200B_206C_200C_200D_200E_206C_206C_206C_202C_202E_200B_202B_206E_206D_206E_202E_206F_202E_202B_206F_200E_200D_200F_202B_206B_206B_200D_206B_202C_200B_200B_206A_200F_206B_200E_200C_206B_200E_202D_202E(-2)
		{
			_202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E = this
		};
	}

	public int GetAdditionAttribute(string attribute)
	{
		if (!_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(186240569u)))
		{
			goto IL_0012;
		}
		string text = ResourceStrings.ResStrings[1029];
		goto IL_004c;
		IL_004c:
		string text2 = text;
		int num = 0;
		int num2 = 1196772950;
		goto IL_0017;
		IL_0012:
		num2 = 1929240039;
		goto IL_0017;
		IL_0017:
		uint num3;
		switch ((num3 = (uint)(num2 ^ 0x4E4DE9ED)) % 3)
		{
		case 2u:
			break;
		case 1u:
			goto IL_0035;
		default:
		{
			IEnumerator<Trigger> enumerator = GetTriggers(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1966185521u)).GetEnumerator();
			try
			{
				Trigger current = default(Trigger);
				while (true)
				{
					IL_00c7:
					int num4;
					int num5;
					if (_202A_206A_206F_206D_206E_206A_200E_202E_206A_200B_206E_200D_206A_200D_206E_202B_200E_206D_202C_200B_200F_206C_202C_206A_202C_206D_200C_206F_206D_200E_202A_206E_206B_200E_202E_206C_206F_200F_206B_200C_202E((IEnumerator)enumerator))
					{
						num4 = 1986361396;
						num5 = num4;
					}
					else
					{
						num4 = 1811287050;
						num5 = num4;
					}
					while (true)
					{
						switch ((num3 = (uint)(num4 ^ 0x4E4DE9ED)) % 5)
						{
						case 0u:
							num4 = 1986361396;
							continue;
						default:
							goto end_IL_0073;
						case 3u:
						{
							current = enumerator.Current;
							int num6;
							if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(current.Argvs[0], text2))
							{
								num4 = 181836764;
								num6 = num4;
							}
							else
							{
								num4 = 1363890299;
								num6 = num4;
							}
							continue;
						}
						case 2u:
							break;
						case 1u:
							num += int.Parse(current.Argvs[1]);
							num4 = ((int)num3 * -281151333) ^ 0x4421CBD0;
							continue;
						case 4u:
							goto end_IL_0073;
						}
						goto IL_00c7;
						continue;
						end_IL_0073:
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
						IL_010d:
						int num7 = 143324122;
						while (true)
						{
							switch ((num3 = (uint)(num7 ^ 0x4E4DE9ED)) % 3)
							{
							case 0u:
								break;
							default:
								goto end_IL_0112;
							case 2u:
								goto IL_0130;
							case 1u:
								goto end_IL_0112;
							}
							goto IL_010d;
							IL_0130:
							_202D_200E_200B_206B_200E_206D_200F_200C_202B_200F_202A_202A_206D_206D_206B_202B_202C_206D_206B_202D_202A_206A_202E_200B_202B_200C_202E_200D_206B_202C_202C_202E_206E_202C_202B_206D_202E_202C_200F_200E_202E((IDisposable)enumerator);
							num7 = ((int)num3 * -2025593004) ^ -2120639980;
							continue;
							end_IL_0112:
							break;
						}
						break;
					}
				}
			}
			int num8 = CommonSettings.MOD_KEY();
			while (true)
			{
				int num9 = 279096096;
				while (true)
				{
					switch ((num3 = (uint)(num9 ^ 0x4E4DE9ED)) % 86)
					{
					case 51u:
						break;
					case 23u:
					{
						int num33;
						int num34;
						if (HasTalent(ResourceStrings.ResStrings[1242]))
						{
							num33 = 688169625;
							num34 = num33;
						}
						else
						{
							num33 = 678120497;
							num34 = num33;
						}
						num9 = num33 ^ ((int)num3 * -522399337);
						continue;
					}
					case 9u:
					{
						int num91;
						int num92;
						if (!_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(655417903u)))
						{
							num91 = 1707672261;
							num92 = num91;
						}
						else
						{
							num91 = 1139437555;
							num92 = num91;
						}
						num9 = num91 ^ ((int)num3 * -1446547257);
						continue;
					}
					case 5u:
					{
						int num16;
						if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(430829805u)))
						{
							num9 = 875148887;
							num16 = num9;
						}
						else
						{
							num9 = 799065646;
							num16 = num9;
						}
						continue;
					}
					case 29u:
					{
						int num104;
						int num105;
						if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2431070502u)))
						{
							num104 = -736242150;
							num105 = num104;
						}
						else
						{
							num104 = -1181203029;
							num105 = num104;
						}
						num9 = num104 ^ (int)(num3 * 941425622);
						continue;
					}
					case 50u:
					{
						int num27;
						int num28;
						if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1550623476u)))
						{
							num27 = 1466496716;
							num28 = num27;
						}
						else
						{
							num27 = 1752085334;
							num28 = num27;
						}
						num9 = num27 ^ ((int)num3 * -1385730016);
						continue;
					}
					case 84u:
					{
						int num99;
						int num100;
						if (!HasTalent(ResourceStrings.ResStrings[1243]))
						{
							num99 = 65423728;
							num100 = num99;
						}
						else
						{
							num99 = 415671450;
							num100 = num99;
						}
						num9 = num99 ^ (int)(num3 * 982911682);
						continue;
					}
					case 52u:
					{
						int num107;
						int num108;
						if (!_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4081375616u)))
						{
							num107 = -77464260;
							num108 = num107;
						}
						else
						{
							num107 = -1208663900;
							num108 = num107;
						}
						num9 = num107 ^ (int)(num3 * 856031532);
						continue;
					}
					case 76u:
					{
						int num52;
						int num53;
						if (HasTalent(ResourceStrings.ResStrings[1229]))
						{
							num52 = -32013429;
							num53 = num52;
						}
						else
						{
							num52 = -1093379495;
							num53 = num52;
						}
						num9 = num52 ^ (int)(num3 * 533034296);
						continue;
					}
					case 77u:
						num += 120;
						num9 = 1020538084;
						continue;
					case 82u:
					{
						int num19;
						int num20;
						if (!_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(710450445u)))
						{
							num19 = 973240969;
							num20 = num19;
						}
						else
						{
							num19 = 1225888194;
							num20 = num19;
						}
						num9 = num19 ^ ((int)num3 * -1962859225);
						continue;
					}
					case 24u:
					{
						int num80;
						int num81;
						if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2930940463u)))
						{
							num80 = -79475040;
							num81 = num80;
						}
						else
						{
							num80 = -785447950;
							num81 = num80;
						}
						num9 = num80 ^ ((int)num3 * -182047519);
						continue;
					}
					case 39u:
					{
						int num49;
						int num50;
						if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2722506620u)))
						{
							num49 = -767259269;
							num50 = num49;
						}
						else
						{
							num49 = -2143558602;
							num50 = num49;
						}
						num9 = num49 ^ ((int)num3 * -1179353275);
						continue;
					}
					case 12u:
					{
						int num120;
						int num121;
						if (!_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(11946387u)))
						{
							num120 = -1402976309;
							num121 = num120;
						}
						else
						{
							num120 = -1775964336;
							num121 = num120;
						}
						num9 = num120 ^ (int)(num3 * 359183538);
						continue;
					}
					case 8u:
					{
						int num113;
						if (!HasTalent(ResourceStrings.ResStrings[1262]))
						{
							num9 = 1037882447;
							num113 = num9;
						}
						else
						{
							num9 = 2141663966;
							num113 = num9;
						}
						continue;
					}
					case 35u:
					{
						int num85;
						if (!_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2249625138u)))
						{
							num9 = 835987236;
							num85 = num9;
						}
						else
						{
							num9 = 213972103;
							num85 = num9;
						}
						continue;
					}
					case 17u:
					{
						int num72;
						int num73;
						if (!_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2186305609u)))
						{
							num72 = -1190974970;
							num73 = num72;
						}
						else
						{
							num72 = -1587255215;
							num73 = num72;
						}
						num9 = num72 ^ ((int)num3 * -1309565839);
						continue;
					}
					case 73u:
					{
						int num39;
						if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1944260873u)))
						{
							num9 = 303188080;
							num39 = num9;
						}
						else
						{
							num9 = 1861672156;
							num39 = num9;
						}
						continue;
					}
					case 44u:
					{
						int num23;
						if (!HasTalent(ResourceStrings.ResStrings[1263]))
						{
							num9 = 1583380525;
							num23 = num9;
						}
						else
						{
							num9 = 1993643888;
							num23 = num9;
						}
						continue;
					}
					case 38u:
					{
						int num118;
						int num119;
						if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2077292732u)))
						{
							num118 = 161151282;
							num119 = num118;
						}
						else
						{
							num118 = 1971507893;
							num119 = num118;
						}
						num9 = num118 ^ (int)(num3 * 849209097);
						continue;
					}
					case 25u:
					{
						int num97;
						int num98;
						if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1995100678u)))
						{
							num97 = -1779161591;
							num98 = num97;
						}
						else
						{
							num97 = -1937431098;
							num98 = num97;
						}
						num9 = num97 ^ (int)(num3 * 1228008453);
						continue;
					}
					case 54u:
					{
						int num83;
						int num84;
						if (HasTalent(ResourceStrings.ResStrings[1223]))
						{
							num83 = 513323648;
							num84 = num83;
						}
						else
						{
							num83 = 2128524697;
							num84 = num83;
						}
						num9 = num83 ^ (int)(num3 * 631060313);
						continue;
					}
					case 22u:
					{
						int num57;
						int num58;
						if (!HasTalent(ResourceStrings.ResStrings[1245]))
						{
							num57 = -391916562;
							num58 = num57;
						}
						else
						{
							num57 = -302522610;
							num58 = num57;
						}
						num9 = num57 ^ (int)(num3 * 255883360);
						continue;
					}
					case 3u:
						num9 = ((int)num3 * -283577489) ^ -1554771979;
						continue;
					case 42u:
						num *= 2;
						num9 = ((int)num3 * -1707015281) ^ 0x3FB287A6;
						continue;
					case 4u:
					{
						int num54;
						if (!HasTalent(ResourceStrings.ResStrings[1233]))
						{
							num9 = 384793046;
							num54 = num9;
						}
						else
						{
							num9 = 1332044217;
							num54 = num9;
						}
						continue;
					}
					case 83u:
						num = (int)((double)num * 1.4);
						num9 = 1702724052;
						continue;
					case 63u:
					{
						int num32;
						if (!HasTalent(ResourceStrings.ResStrings[1237]))
						{
							num9 = 1702724052;
							num32 = num9;
						}
						else
						{
							num9 = 2137778676;
							num32 = num9;
						}
						continue;
					}
					case 30u:
					{
						int num29;
						if (!_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1790491204u)))
						{
							num9 = 833483978;
							num29 = num9;
						}
						else
						{
							num9 = 295501765;
							num29 = num9;
						}
						continue;
					}
					case 80u:
					{
						int num125;
						if (num8 != 4)
						{
							num9 = 64885300;
							num125 = num9;
						}
						else
						{
							num9 = 635434514;
							num125 = num9;
						}
						continue;
					}
					case 0u:
						num9 = (int)((num3 * 1231899881) ^ 0x6BAE6C78);
						continue;
					case 53u:
					{
						int num114;
						if (!_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2930940463u)))
						{
							num9 = 1253232087;
							num114 = num9;
						}
						else
						{
							num9 = 537253651;
							num114 = num9;
						}
						continue;
					}
					case 16u:
					{
						int num109;
						int num110;
						if (_206E_202B_200D_206D_200E_200E_206C_200F_200B_200F_206C_200F_206D_206D_200C_202B_206B_200B_206F_206E_206A_200B_200B_200B_206A_206A_202E_206D_206F_202B_200C_202C_206B_200B_200D_206F_200F_200E_200D_206E_202E(attribute, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2434912689u)))
						{
							num109 = -624594122;
							num110 = num109;
						}
						else
						{
							num109 = -840410163;
							num110 = num109;
						}
						num9 = num109 ^ ((int)num3 * -987590621);
						continue;
					}
					case 47u:
					{
						int num94;
						int num95;
						if (HasTalent(ResourceStrings.ResStrings[1240]))
						{
							num94 = 1959988345;
							num95 = num94;
						}
						else
						{
							num94 = 433168670;
							num95 = num94;
						}
						num9 = num94 ^ (int)(num3 * 1340999833);
						continue;
					}
					case 37u:
					{
						int num87;
						if (!HasTalent(ResourceStrings.ResStrings[1232]))
						{
							num9 = 393945795;
							num87 = num9;
						}
						else
						{
							num9 = 1142714537;
							num87 = num9;
						}
						continue;
					}
					case 2u:
					{
						int num68;
						int num69;
						if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3583101943u)))
						{
							num68 = -1626279756;
							num69 = num68;
						}
						else
						{
							num68 = -2114868863;
							num69 = num68;
						}
						num9 = num68 ^ (int)(num3 * 1275356403);
						continue;
					}
					case 18u:
					{
						int num64;
						int num65;
						if (!HasTalent(ResourceStrings.ResStrings[1246]))
						{
							num64 = -772323694;
							num65 = num64;
						}
						else
						{
							num64 = -555976114;
							num65 = num64;
						}
						num9 = num64 ^ ((int)num3 * -1660913706);
						continue;
					}
					case 70u:
					{
						int num44;
						int num45;
						if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(394181284u)))
						{
							num44 = -2108386188;
							num45 = num44;
						}
						else
						{
							num44 = -1674779661;
							num45 = num44;
						}
						num9 = num44 ^ (int)(num3 * 479492540);
						continue;
					}
					case 15u:
					{
						int num38;
						if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(704292959u)))
						{
							num9 = 1630130477;
							num38 = num9;
						}
						else
						{
							num9 = 635434514;
							num38 = num9;
						}
						continue;
					}
					case 59u:
					{
						int num26;
						if (!HasTalent(ResourceStrings.ResStrings[1234]))
						{
							num9 = 923297145;
							num26 = num9;
						}
						else
						{
							num9 = 2014737605;
							num26 = num9;
						}
						continue;
					}
					case 48u:
					{
						int num14;
						int num15;
						if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4081375616u)))
						{
							num14 = -1200012238;
							num15 = num14;
						}
						else
						{
							num14 = -537133344;
							num15 = num14;
						}
						num9 = num14 ^ (int)(num3 * 1225957235);
						continue;
					}
					case 61u:
					{
						int num128;
						if (HasTalent(ResourceStrings.ResStrings[1231]))
						{
							num9 = 51506561;
							num128 = num9;
						}
						else
						{
							num9 = 59076894;
							num128 = num9;
						}
						continue;
					}
					case 41u:
					{
						int num126;
						if (!HasTalent(ResourceStrings.ResStrings[1238]))
						{
							num9 = 1682042952;
							num126 = num9;
						}
						else
						{
							num9 = 1598457384;
							num126 = num9;
						}
						continue;
					}
					case 46u:
					{
						int num122;
						if (!HasTalent(ResourceStrings.ResStrings[1261]))
						{
							num9 = 59968083;
							num122 = num9;
						}
						else
						{
							num9 = 1442000328;
							num122 = num9;
						}
						continue;
					}
					case 33u:
					{
						int num115;
						if (!_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(701808387u)))
						{
							num9 = 731587686;
							num115 = num9;
						}
						else
						{
							num9 = 420716204;
							num115 = num9;
						}
						continue;
					}
					case 78u:
					{
						int num102;
						int num103;
						if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(89557949u)))
						{
							num102 = -227378952;
							num103 = num102;
						}
						else
						{
							num102 = -600841234;
							num103 = num102;
						}
						num9 = num102 ^ (int)(num3 * 1315689290);
						continue;
					}
					case 45u:
					{
						int num93;
						if (!HasTalent(ResourceStrings.ResStrings[1266]))
						{
							num9 = 900322066;
							num93 = num9;
						}
						else
						{
							num9 = 1568917892;
							num93 = num9;
						}
						continue;
					}
					case 34u:
					{
						int num88;
						if (HasTalent(ResourceStrings.ResStrings[1236]))
						{
							num9 = 1050026028;
							num88 = num9;
						}
						else
						{
							num9 = 915409264;
							num88 = num9;
						}
						continue;
					}
					case 20u:
					{
						int num78;
						int num79;
						if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2053407229u)))
						{
							num78 = -1933981942;
							num79 = num78;
						}
						else
						{
							num78 = -707816099;
							num79 = num78;
						}
						num9 = num78 ^ (int)(num3 * 1494628097);
						continue;
					}
					case 55u:
						num = (int)((double)num * 1.3);
						num9 = ((int)num3 * -2079726050) ^ -1544624290;
						continue;
					case 14u:
					{
						int num74;
						int num75;
						if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2869211242u)))
						{
							num74 = -1677233476;
							num75 = num74;
						}
						else
						{
							num74 = -2088876160;
							num75 = num74;
						}
						num9 = num74 ^ (int)(num3 * 596671311);
						continue;
					}
					case 57u:
						num = (int)((double)num * 1.75);
						num9 = 2088170198;
						continue;
					case 11u:
					{
						int num63;
						if (!HasTalent(ResourceStrings.ResStrings[1260]))
						{
							num9 = 1760011087;
							num63 = num9;
						}
						else
						{
							num9 = 2141267495;
							num63 = num9;
						}
						continue;
					}
					case 60u:
						num = (int)((double)num * 1.5);
						num9 = ((int)num3 * -160109944) ^ -591950105;
						continue;
					case 19u:
					{
						int num59;
						int num60;
						if (num8 != 1)
						{
							num59 = -1056173697;
							num60 = num59;
						}
						else
						{
							num59 = -265601172;
							num60 = num59;
						}
						num9 = num59 ^ (int)(num3 * 66766705);
						continue;
					}
					case 67u:
					{
						int num48;
						if (!HasTalent(ResourceStrings.ResStrings[1267]))
						{
							num9 = 2088170198;
							num48 = num9;
						}
						else
						{
							num9 = 421375575;
							num48 = num9;
						}
						continue;
					}
					case 56u:
					{
						int num42;
						int num43;
						if (!HasTalent(ResourceStrings.ResStrings[159]))
						{
							num42 = 877509894;
							num43 = num42;
						}
						else
						{
							num42 = 722893890;
							num43 = num42;
						}
						num9 = num42 ^ ((int)num3 * -942399407);
						continue;
					}
					case 13u:
					{
						int num40;
						if (!HasTalent(ResourceStrings.ResStrings[1268]))
						{
							num9 = 635434514;
							num40 = num9;
						}
						else
						{
							num9 = 1253913783;
							num40 = num9;
						}
						continue;
					}
					case 40u:
					{
						int num35;
						if (HasTalent(ResourceStrings.ResStrings[1264]))
						{
							num9 = 507166434;
							num35 = num9;
						}
						else
						{
							num9 = 306312181;
							num35 = num9;
						}
						continue;
					}
					case 6u:
					{
						int num21;
						int num22;
						if (!_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1368077529u)))
						{
							num21 = -433382889;
							num22 = num21;
						}
						else
						{
							num21 = -658963304;
							num22 = num21;
						}
						num9 = num21 ^ (int)(num3 * 1075403941);
						continue;
					}
					case 65u:
					{
						int num12;
						int num13;
						if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(400004197u)))
						{
							num12 = 691665992;
							num13 = num12;
						}
						else
						{
							num12 = 749913207;
							num13 = num12;
						}
						num9 = num12 ^ (int)(num3 * 1872820044);
						continue;
					}
					case 1u:
					{
						int num127;
						if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2259249129u)))
						{
							num9 = 670540322;
							num127 = num9;
						}
						else
						{
							num9 = 1207330729;
							num127 = num9;
						}
						continue;
					}
					case 74u:
					{
						int num123;
						int num124;
						if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1977936243u)))
						{
							num123 = -1380935126;
							num124 = num123;
						}
						else
						{
							num123 = -1150932664;
							num124 = num123;
						}
						num9 = num123 ^ (int)(num3 * 814059653);
						continue;
					}
					case 32u:
					{
						int num116;
						int num117;
						if (!HasTalent(ResourceStrings.ResStrings[1222]))
						{
							num116 = -1966535566;
							num117 = num116;
						}
						else
						{
							num116 = -1470945852;
							num117 = num116;
						}
						num9 = num116 ^ (int)(num3 * 419398981);
						continue;
					}
					case 69u:
					{
						int num111;
						int num112;
						if (!_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2475589736u)))
						{
							num111 = 980846113;
							num112 = num111;
						}
						else
						{
							num111 = 2145564168;
							num112 = num111;
						}
						num9 = num111 ^ (int)(num3 * 840905340);
						continue;
					}
					case 27u:
					{
						int num106;
						if (HasTalent(ResourceStrings.ResStrings[160]))
						{
							num9 = 507977953;
							num106 = num9;
						}
						else
						{
							num9 = 635434514;
							num106 = num9;
						}
						continue;
					}
					case 85u:
					{
						int num101;
						if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(655417903u)))
						{
							num9 = 1087484783;
							num101 = num9;
						}
						else
						{
							num9 = 141484920;
							num101 = num9;
						}
						continue;
					}
					case 36u:
					{
						int num96;
						if (HasTalent(ResourceStrings.ResStrings[1235]))
						{
							num9 = 1812782006;
							num96 = num9;
						}
						else
						{
							num9 = 744621171;
							num96 = num9;
						}
						continue;
					}
					case 79u:
					{
						int num89;
						int num90;
						if (!HasTalent(ResourceStrings.ResStrings[1259]))
						{
							num89 = -703183262;
							num90 = num89;
						}
						else
						{
							num89 = -1007853798;
							num90 = num89;
						}
						num9 = num89 ^ ((int)num3 * -1637521444);
						continue;
					}
					case 58u:
					{
						int num86;
						if (HasTalent(ResourceStrings.ResStrings[1265]))
						{
							num9 = 1081843357;
							num86 = num9;
						}
						else
						{
							num9 = 358854252;
							num86 = num9;
						}
						continue;
					}
					case 28u:
					{
						int num82;
						if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1368077529u)))
						{
							num9 = 138411809;
							num82 = num9;
						}
						else
						{
							num9 = 900664202;
							num82 = num9;
						}
						continue;
					}
					case 71u:
					{
						int num76;
						int num77;
						if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(739543880u)))
						{
							num76 = -200667737;
							num77 = num76;
						}
						else
						{
							num76 = -769486356;
							num77 = num76;
						}
						num9 = num76 ^ ((int)num3 * -1412338735);
						continue;
					}
					case 62u:
					{
						int num70;
						int num71;
						if (!_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3535376985u)))
						{
							num70 = -1285096859;
							num71 = num70;
						}
						else
						{
							num70 = -298326838;
							num71 = num70;
						}
						num9 = num70 ^ ((int)num3 * -408928679);
						continue;
					}
					case 10u:
					{
						int num66;
						int num67;
						if (num > 3000)
						{
							num66 = 1644149158;
							num67 = num66;
						}
						else
						{
							num66 = 650205642;
							num67 = num66;
						}
						num9 = num66 ^ ((int)num3 * -1207775705);
						continue;
					}
					case 64u:
					{
						int num61;
						int num62;
						if (!_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1923523063u)))
						{
							num61 = 16367532;
							num62 = num61;
						}
						else
						{
							num61 = 242112964;
							num62 = num61;
						}
						num9 = num61 ^ ((int)num3 * -1285331260);
						continue;
					}
					case 66u:
					{
						int num55;
						int num56;
						if (!_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(942219431u)))
						{
							num55 = 1535080961;
							num56 = num55;
						}
						else
						{
							num55 = 2037286708;
							num56 = num55;
						}
						num9 = num55 ^ ((int)num3 * -2039671084);
						continue;
					}
					case 49u:
					{
						int num51;
						if (num8 != 2)
						{
							num9 = 1551528719;
							num51 = num9;
						}
						else
						{
							num9 = 1076517738;
							num51 = num9;
						}
						continue;
					}
					case 26u:
					{
						int num46;
						int num47;
						if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(704292959u)))
						{
							num46 = -685024440;
							num47 = num46;
						}
						else
						{
							num46 = -273932937;
							num47 = num46;
						}
						num9 = num46 ^ (int)(num3 * 2092970634);
						continue;
					}
					case 68u:
					{
						int num41;
						if (HasTalent(ResourceStrings.ResStrings[1230]))
						{
							num9 = 974689444;
							num41 = num9;
						}
						else
						{
							num9 = 264917370;
							num41 = num9;
						}
						continue;
					}
					case 31u:
					{
						int num36;
						int num37;
						if (!_206E_202B_200D_206D_200E_200E_206C_200F_200B_200F_206C_200F_206D_206D_200C_202B_206B_200B_206F_206E_206A_200B_200B_200B_206A_206A_202E_206D_206F_202B_200C_202C_206B_200B_200D_206F_200F_200E_200D_206E_202E(attribute, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(592457607u)))
						{
							num36 = 1936629125;
							num37 = num36;
						}
						else
						{
							num36 = 1399006454;
							num37 = num36;
						}
						num9 = num36 ^ (int)(num3 * 437211012);
						continue;
					}
					case 43u:
					{
						int num30;
						int num31;
						if (!_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2434912689u)))
						{
							num30 = -1686296520;
							num31 = num30;
						}
						else
						{
							num30 = -1522179849;
							num31 = num30;
						}
						num9 = num30 ^ ((int)num3 * -1551823373);
						continue;
					}
					case 21u:
					{
						int num24;
						int num25;
						if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attribute, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3628012406u)))
						{
							num24 = 1735139594;
							num25 = num24;
						}
						else
						{
							num24 = 1859754747;
							num25 = num24;
						}
						num9 = num24 ^ (int)(num3 * 968300050);
						continue;
					}
					case 81u:
					{
						int num17;
						int num18;
						if (!HasTalent(ResourceStrings.ResStrings[1244]))
						{
							num17 = -1378561879;
							num18 = num17;
						}
						else
						{
							num17 = -371800389;
							num18 = num17;
						}
						num9 = num17 ^ ((int)num3 * -280712519);
						continue;
					}
					case 72u:
					{
						int num10;
						int num11;
						if (HasTalent(ResourceStrings.ResStrings[1241]))
						{
							num10 = 1711063718;
							num11 = num10;
						}
						else
						{
							num10 = 2124807330;
							num11 = num10;
						}
						num9 = num10 ^ (int)(num3 * 442280361);
						continue;
					}
					case 75u:
						num = 3000;
						num9 = (int)((num3 * 616264928) ^ 0x331CC876);
						continue;
					default:
						return num;
					}
					break;
				}
			}
		}
		}
		goto IL_0012;
		IL_0035:
		text = CommonSettings.AttributeToChinese(attribute);
		goto IL_004c;
	}

	public int GetSkillTypeValue()
	{
		return AttributesFinal[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2053407229u)] + AttributesFinal[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(269729863u)] + AttributesFinal[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1029863417u)] + AttributesFinal[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2249625138u)];
	}

	public int GetMaxSkillTypeValue()
	{
		int[] array = new int[4]
		{
			AttributesFinal[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(199488088u)],
			AttributesFinal[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(394181284u)],
			AttributesFinal[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2223184606u)],
			AttributesFinal[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4176639349u)]
		};
		return _206E_206A_202D_202E_202A_200B_202A_202C_202B_206E_206B_202A_202C_202A_206B_200D_206F_206F_200C_202C_202A_200B_202B_206A_202C_206D_206F_202D_200D_200E_206A_202C_206F_200D_202E_200C_200C_206A_206F_206C_202E((IEnumerable<int>)array);
	}

	public string GetAttributeString(string attr)
	{
		if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attr, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1995100678u)))
		{
			goto IL_0012;
		}
		goto IL_0052;
		IL_0012:
		int num = 833230347;
		goto IL_0017;
		IL_0017:
		uint num2;
		switch ((num2 = (uint)(num ^ 0x5876B6EC)) % 5)
		{
		case 2u:
			break;
		case 3u:
			return GetAttributeMpString();
		case 4u:
			goto IL_0052;
		case 1u:
			return GetAttributeHpString();
		default:
			return _206C_206E_200B_206B_206B_202C_206F_206B_202A_200C_206E_206E_202A_202A_202A_206C_206D_206B_206C_206A_200B_206C_202A_202B_206D_206C_202D_202B_206B_206A_206A_202E_202A_206A_206E_206E_206E_200E_202E_206F_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1784753666u), (object)Attributes[attr], (object)GetAdditionAttribute(attr));
		}
		goto IL_0012;
		IL_0052:
		int num3;
		if (!_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attr, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(187771104u)))
		{
			num = 1768081676;
			num3 = num;
		}
		else
		{
			num = 945347137;
			num3 = num;
		}
		goto IL_0017;
	}

	public float CriticalProbabilityAdd()
	{
		float num = 0f;
		IEnumerator<Trigger> enumerator = GetTriggers(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2921175454u)).GetEnumerator();
		try
		{
			while (true)
			{
				IL_0072:
				int num2;
				int num3;
				if (_202A_206A_206F_206D_206E_206A_200E_202E_206A_200B_206E_200D_206A_200D_206E_202B_200E_206D_202C_200B_200F_206C_202C_206A_202C_206D_200C_206F_206D_200E_202A_206E_206B_200E_202E_206C_206F_200F_206B_200C_202E((IEnumerator)enumerator))
				{
					num2 = -245496322;
					num3 = num2;
				}
				else
				{
					num2 = -1662317975;
					num3 = num2;
				}
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)(num2 ^ -633018041)) % 4)
					{
					case 0u:
						num2 = -245496322;
						continue;
					default:
						goto end_IL_0023;
					case 1u:
					{
						Trigger current = enumerator.Current;
						num += (float)(double.Parse(current.Argvs[0]) / 100.0);
						num2 = -610358156;
						continue;
					}
					case 3u:
						break;
					case 2u:
						goto end_IL_0023;
					}
					goto IL_0072;
					continue;
					end_IL_0023:
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
					IL_0090:
					int num5 = -1638611422;
					while (true)
					{
						uint num4;
						switch ((num4 = (uint)(num5 ^ -633018041)) % 3)
						{
						case 0u:
							break;
						default:
							goto end_IL_0095;
						case 1u:
							goto IL_00b3;
						case 2u:
							goto end_IL_0095;
						}
						goto IL_0090;
						IL_00b3:
						_202D_200E_200B_206B_200E_206D_200F_200C_202B_200F_202A_202A_206D_206D_206B_202B_202C_206D_206B_202D_202A_206A_202E_200B_202B_200C_202E_200D_206B_202C_202C_202E_206E_202C_202B_206D_202E_202C_200F_200E_202E((IDisposable)enumerator);
						num5 = ((int)num4 * -65838669) ^ 0x7E95B784;
						continue;
						end_IL_0095:
						break;
					}
					break;
				}
			}
		}
		enumerator = GetTriggers(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3192915409u)).GetEnumerator();
		try
		{
			Trigger current2 = default(Trigger);
			while (true)
			{
				IL_010d:
				int num6;
				int num7;
				if (_202A_206A_206F_206D_206E_206A_200E_202E_206A_200B_206E_200D_206A_200D_206E_202B_200E_206D_202C_200B_200F_206C_202C_206A_202C_206D_200C_206F_206D_200E_202A_206E_206B_200E_202E_206C_206F_200F_206B_200C_202E((IEnumerator)enumerator))
				{
					num6 = -67192236;
					num7 = num6;
				}
				else
				{
					num6 = -1196895576;
					num7 = num6;
				}
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)(num6 ^ -633018041)) % 5)
					{
					case 3u:
						num6 = -67192236;
						continue;
					default:
						goto end_IL_00e7;
					case 4u:
						break;
					case 0u:
						num += (float)(double.Parse(current2.Argvs[1]) / 100.0);
						num6 = (int)(num4 * 113695628) ^ -1380381348;
						continue;
					case 1u:
						current2 = enumerator.Current;
						num6 = -1644233303;
						continue;
					case 2u:
						goto end_IL_00e7;
					}
					goto IL_010d;
					continue;
					end_IL_00e7:
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
					IL_0168:
					int num8 = -210949212;
					while (true)
					{
						uint num4;
						switch ((num4 = (uint)(num8 ^ -633018041)) % 3)
						{
						case 0u:
							break;
						default:
							goto end_IL_016d;
						case 2u:
							goto IL_018b;
						case 1u:
							goto end_IL_016d;
						}
						goto IL_0168;
						IL_018b:
						_202D_200E_200B_206B_200E_206D_200F_200C_202B_200F_202A_202A_206D_206D_206B_202B_202C_206D_206B_202D_202A_206A_202E_200B_202B_200C_202E_200D_206B_202C_202C_202E_206E_202C_202B_206D_202E_202C_200F_200E_202E((IDisposable)enumerator);
						num8 = (int)(num4 * 1001793690) ^ -1654316114;
						continue;
						end_IL_016d:
						break;
					}
					break;
				}
			}
		}
		return _200C_206F_202A_206F_206D_200B_200E_206F_206F_206D_202B_206A_206C_202C_202E_206B_206E_200B_200F_202B_206B_200B_206D_206C_206E_206E_206C_206F_206D_206E_200B_206D_200C_202C_200C_202A_202B_202B_200F_202B_202E(1f, num);
	}

	public bool AddExp(int add)
	{
		bool flag = false;
		ItemSkill itemSkill = default(ItemSkill);
		ItemInstance equipment = default(ItemInstance);
		int num11 = default(int);
		int mAX_ATTRIBUTE = default(int);
		int mAX_INTERNALSKILL_COUNT = default(int);
		InternalSkillInstance current = default(InternalSkillInstance);
		bool result = default(bool);
		int mAX_LEVEL = default(int);
		SkillInstance skillInstance = default(SkillInstance);
		int mAX_SKILL_COUNT = default(int);
		InternalSkillInstance internalSkillInstance = default(InternalSkillInstance);
		bool flag3 = default(bool);
		SkillInstance current2 = default(SkillInstance);
		while (true)
		{
			int num = -1553430212;
			while (true)
			{
				int num9;
				int num40;
				uint num2;
				switch ((num2 = (uint)(num ^ -290437965)) % 14)
				{
				case 10u:
					break;
				case 1u:
					Exp += add * 2;
					num = (int)((num2 * 1905507273) ^ 0x57B32215);
					continue;
				case 2u:
					Exp += add;
					num = -1604403922;
					continue;
				case 12u:
					itemSkill = equipment.GetItemSkill();
					num = (int)(num2 * 642018291) ^ -1265145026;
					continue;
				case 3u:
					num = ((int)num2 * -647855730) ^ 0x2337093C;
					continue;
				case 8u:
				{
					num11 = _206E_202D_206A_202B_206E_206A_206A_206A_206D_206A_200F_206F_202C_202A_206D_200C_202A_202D_202C_206B_202E_200C_206C_206B_200C_200E_206D_206F_200E_200E_206F_206F_202E_202C_206C_200E_202C_200B_200C_206B_202E(3000, mAX_ATTRIBUTE);
					int num41;
					int num42;
					if (HasTalent(ResourceStrings.ResStrings[496]))
					{
						num41 = 1028815842;
						num42 = num41;
					}
					else
					{
						num41 = 1274806603;
						num42 = num41;
					}
					num = num41 ^ ((int)num2 * -1905439544);
					continue;
				}
				case 0u:
					if (equipment != null)
					{
						num = ((int)num2 * -448296870) ^ -1734878399;
						continue;
					}
					goto IL_1125;
				case 13u:
					equipment = GetEquipment(4);
					num = -961893161;
					continue;
				case 5u:
					if (itemSkill != null)
					{
						num = (int)(num2 * 442423660) ^ -219275360;
						continue;
					}
					goto IL_1125;
				case 4u:
					if (InternalSkills.Count <= mAX_INTERNALSKILL_COUNT)
					{
						num = (int)((num2 * 515022210) ^ 0xCBBE1AA);
						continue;
					}
					goto IL_1125;
				case 6u:
					mAX_INTERNALSKILL_COUNT = MAX_INTERNALSKILL_COUNT;
					num = (int)(num2 * 1862844167) ^ -1296345823;
					continue;
				case 9u:
					mAX_ATTRIBUTE = MAX_ATTRIBUTE;
					num = (int)((num2 * 612459933) ^ 0x2DF6D1F2);
					continue;
				case 11u:
					if (itemSkill.IsInternal)
					{
						num = ((int)num2 * -144705204) ^ -861826555;
						continue;
					}
					goto IL_038b;
				default:
					{
						bool flag2 = false;
						using (List<InternalSkillInstance>.Enumerator enumerator = InternalSkills.GetEnumerator())
						{
							while (true)
							{
								IL_02c3:
								int num3;
								int num4;
								if (!enumerator.MoveNext())
								{
									num3 = -801385969;
									num4 = num3;
								}
								else
								{
									num3 = -105297517;
									num4 = num3;
								}
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ -290437965)) % 9)
									{
									case 2u:
										num3 = -105297517;
										continue;
									default:
										goto end_IL_01d3;
									case 6u:
										goto end_IL_01d3;
									case 7u:
									{
										int num7;
										int num8;
										if (_202D_202C_200F_200C_202D_206C_202D_206C_200D_200D_200C_206A_206F_200B_202B_202B_200D_206E_202A_200E_202C_202C_202E_200D_206D_200C_206A_202A_200F_202D_206D_200C_206A_200F_206B_206D_206A_202C_200D_202A_202E(current.Name, itemSkill.SkillName))
										{
											num7 = 403332869;
											num8 = num7;
										}
										else
										{
											num7 = 2147384129;
											num8 = num7;
										}
										num3 = num7 ^ ((int)num2 * -1160810120);
										continue;
									}
									case 1u:
										current.TryAddExp(add);
										num3 = ((int)num2 * -442420088) ^ -240119826;
										continue;
									case 8u:
										current = enumerator.Current;
										num3 = -521137099;
										continue;
									case 3u:
										flag2 = true;
										num3 = ((int)num2 * -1793615547) ^ 0x85AD302;
										continue;
									case 4u:
									{
										int num5;
										int num6;
										if (itemSkill.MaxLevel >= current.Level)
										{
											num5 = -1961813147;
											num6 = num5;
										}
										else
										{
											num5 = -441881047;
											num6 = num5;
										}
										num3 = num5 ^ (int)(num2 * 1055304954);
										continue;
									}
									case 0u:
										break;
									case 5u:
										goto end_IL_01d3;
									}
									goto IL_02c3;
									continue;
									end_IL_01d3:
									break;
								}
								break;
							}
						}
						if (!flag2)
						{
							goto IL_02f7;
						}
						goto IL_1125;
					}
					IL_05ce:
					while (true)
					{
						switch ((num2 = (uint)(num9 ^ -290437965)) % 60)
						{
						case 52u:
							break;
						case 7u:
							result = true;
							num9 = -863094514;
							continue;
						case 51u:
							Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3051962998u)] = Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3628012406u)] + GrowTemplate.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2575692001u)];
							num9 = (int)(num2 * 347619612) ^ -1572070695;
							continue;
						case 2u:
							Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2722506620u)] = num11;
							num9 = (int)((num2 * 916212072) ^ 0x15BADDD4);
							continue;
						case 48u:
							goto IL_0762;
						case 33u:
							Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2186305609u)] = num11;
							num9 = ((int)num2 * -719115816) ^ 0x3EF4655B;
							continue;
						case 58u:
							goto IL_07b7;
						case 13u:
							Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(739543880u)] = num11;
							num9 = ((int)num2 * -1779445598) ^ -291048103;
							continue;
						case 5u:
							goto IL_080c;
						case 54u:
							Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2301880830u)] = Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1368077529u)] + GrowTemplate.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(739543880u)];
							num9 = (int)((num2 * 2120818115) ^ 0x5EB77642);
							continue;
						case 44u:
							goto IL_0886;
						case 27u:
							goto IL_08b2;
						case 31u:
							goto IL_08de;
						case 22u:
							goto IL_090a;
						case 57u:
							goto IL_0936;
						case 47u:
							goto IL_0962;
						case 26u:
							Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(942219431u)] = num11;
							num9 = (int)((num2 * 1110656574) ^ 0x63AAD7BC);
							continue;
						case 35u:
							goto IL_09b7;
						case 50u:
							goto IL_09e3;
						case 32u:
							Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(704292959u)] = Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1940200750u)] + GrowTemplate.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(704292959u)];
							num9 = ((int)num2 * -1710057415) ^ 0x22C2FE50;
							continue;
						case 39u:
							Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1029863417u)] = num11;
							num9 = ((int)num2 * -200120663) ^ 0x2ACB7718;
							continue;
						case 24u:
							Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1550623476u)] = num11;
							num9 = (int)((num2 * 1818199148) ^ 0x3082DB39);
							continue;
						case 6u:
							mAX_LEVEL = MAX_LEVEL;
							num9 = (int)((num2 * 1049290500) ^ 0x2ABF9057);
							continue;
						case 4u:
						{
							int num18;
							int num19;
							if (Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(710450445u)] >= mAX_ATTRIBUTE)
							{
								num18 = -938215368;
								num19 = num18;
							}
							else
							{
								num18 = -2045011671;
								num19 = num18;
							}
							num9 = num18 ^ (int)(num2 * 1615224833);
							continue;
						}
						case 28u:
						{
							int num16;
							int num17;
							if (Level >= mAX_LEVEL)
							{
								num16 = 259238946;
								num17 = num16;
							}
							else
							{
								num16 = 938724943;
								num17 = num16;
							}
							num9 = num16 ^ (int)(num2 * 226740759);
							continue;
						}
						case 3u:
							Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3583101943u)] = num11;
							num9 = (int)(num2 * 1744473976) ^ -1837994595;
							continue;
						case 46u:
							goto IL_0b59;
						case 1u:
							goto IL_0b85;
						case 56u:
							goto IL_0bb1;
						case 10u:
							Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(592457607u)] = _206E_202D_206A_202B_206E_206A_206A_206A_206D_206A_200F_206F_202C_202A_206D_200C_202A_202D_202C_206B_202E_200C_206C_206B_200C_200E_206D_206F_200E_200E_206F_206F_202E_202C_206C_200E_202C_200B_200C_206B_202E(Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(31734228u)] + GrowTemplate.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3905690180u)], MAX_HPMP);
							Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1306348308u)] = _206E_202D_206A_202B_206E_206A_206A_206A_206D_206A_200F_206F_202C_202A_206D_200C_202A_202D_202C_206B_202E_200C_206C_206B_200C_200E_206D_206F_200E_200E_206F_206F_202E_202C_206C_200E_202C_200B_200C_206B_202E(Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2434912689u)] + GrowTemplate.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4229302121u)], MAX_HPMP);
							num9 = ((int)num2 * -81913437) ^ 0x74D4A6E9;
							continue;
						case 41u:
							goto IL_0c90;
						case 21u:
							skillInstance = new SkillInstance
							{
								name = itemSkill.SkillName,
								level = 1,
								level2 = -1f,
								Owner = this
							};
							num9 = (int)(num2 * 788841626) ^ -2026120707;
							continue;
						case 18u:
							Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1564888282u)] = Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1564888282u)] + GrowTemplate.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3665747899u)];
							num9 = ((int)num2 * -1578033649) ^ -987317314;
							continue;
						case 11u:
							goto IL_0d54;
						case 38u:
						{
							int num14;
							int num15;
							if (Skills.Count >= mAX_SKILL_COUNT)
							{
								num14 = 1544237215;
								num15 = num14;
							}
							else
							{
								num14 = 1923890164;
								num15 = num14;
							}
							num9 = num14 ^ (int)(num2 * 2062279737);
							continue;
						}
						case 9u:
							leftpoint2 += 2.0;
							num9 = (int)((num2 * 206553103) ^ 0x490EF216);
							continue;
						case 19u:
							Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(664072894u)] = Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2930940463u)] + GrowTemplate.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2186305609u)];
							num9 = ((int)num2 * -1065498195) ^ 0x5B1F6BAE;
							continue;
						case 53u:
							num9 = (int)((num2 * 1015067230) ^ 0x1FE88730);
							continue;
						case 37u:
							leftpoint += 2;
							num9 = (int)(num2 * 525165425) ^ -507053321;
							continue;
						case 15u:
							Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(269729863u)] = num11;
							num9 = (int)(num2 * 758331998) ^ -938147538;
							continue;
						case 20u:
							goto IL_0e8a;
						case 34u:
							Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3535376985u)] = Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(430829805u)] + GrowTemplate.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(394181284u)];
							num9 = (int)((num2 * 1639061335) ^ 0x3A71104C);
							continue;
						case 45u:
							Exp = 0;
							num9 = ((int)num2 * -2115412813) ^ 0x2F8C5D01;
							continue;
						case 12u:
							level++;
							num9 = (int)(num2 * 1424940423) ^ -2145646030;
							continue;
						case 29u:
							Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1944260873u)] = Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2722506620u)] + GrowTemplate.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(199488088u)];
							num9 = (int)((num2 * 326891921) ^ 0x1972D0B);
							continue;
						case 43u:
							Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2981046594u)] = Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2249625138u)] + GrowTemplate.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2249625138u)];
							num9 = (int)(num2 * 920030789) ^ -882071989;
							continue;
						case 36u:
							goto IL_0ff9;
						case 8u:
							skillInstance.RefreshUniquSkills();
							Skills.Add(skillInstance);
							num9 = ((int)num2 * -1562568344) ^ -785001372;
							continue;
						case 55u:
							goto IL_104c;
						case 42u:
							Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1923523063u)] = num11;
							num9 = (int)((num2 * 1906683007) ^ 0x64382B70);
							continue;
						case 17u:
							flag = true;
							num9 = ((int)num2 * -1257973398) ^ -1883430505;
							continue;
						case 23u:
							goto IL_10b6;
						case 59u:
							skillInstance.TryAddExp(add);
							num9 = ((int)num2 * -239113304) ^ 0x39D50AB6;
							continue;
						case 16u:
						{
							int num12;
							int num13;
							if (Level < mAX_LEVEL)
							{
								num12 = 1307122374;
								num13 = num12;
							}
							else
							{
								num12 = 316036906;
								num13 = num12;
							}
							num9 = num12 ^ (int)(num2 * 472452166);
							continue;
						}
						case 30u:
							goto IL_1125;
						case 40u:
							flag = true;
							num9 = -320082045;
							continue;
						case 0u:
							Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1412133437u)] = Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(788062007u)] + GrowTemplate.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(788062007u)];
							num9 = ((int)num2 * -1879203680) ^ 0x1F894958;
							continue;
						case 25u:
							Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(400004197u)] = Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(701808387u)] + GrowTemplate.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(701808387u)];
							num9 = (int)((num2 * 996357600) ^ 0x71D4ED33);
							continue;
						case 14u:
							Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3795453722u)] = num11;
							num9 = (int)((num2 * 1855611703) ^ 0xE82BF9);
							continue;
						default:
							if (flag)
							{
								try
								{
									RuntimeData.Instance.RefreshTeamMemberPanel(this, refreshImage: false, refreshText: true);
								}
								catch
								{
									while (true)
									{
										IL_122a:
										int num10 = -1306691094;
										while (true)
										{
											switch ((num2 = (uint)(num10 ^ -290437965)) % 3)
											{
											case 2u:
												break;
											default:
												goto end_IL_122f;
											case 1u:
												goto IL_124d;
											case 0u:
												goto end_IL_122f;
											}
											goto IL_122a;
											IL_124d:
											RuntimeData.Instance.isTeamPanelRefreshed = 0;
											num10 = (int)((num2 * 1536040776) ^ 0x514D70C6);
											continue;
											end_IL_122f:
											break;
										}
										break;
									}
								}
							}
							return result;
						}
						break;
						IL_10b6:
						int num20;
						if (Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(710450445u)] <= num11)
						{
							num9 = -388232385;
							num20 = num9;
						}
						else
						{
							num9 = -700509991;
							num20 = num9;
						}
						continue;
						IL_0962:
						int num21;
						if (Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(269729863u)] > num11)
						{
							num9 = -1716920080;
							num21 = num9;
						}
						else
						{
							num9 = -1024491596;
							num21 = num9;
						}
						continue;
						IL_0b85:
						int num22;
						if (Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2223184606u)] >= mAX_ATTRIBUTE)
						{
							num9 = -840681368;
							num22 = num9;
						}
						else
						{
							num9 = -403209397;
							num22 = num9;
						}
						continue;
						IL_104c:
						int num23;
						if (Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1029863417u)] > num11)
						{
							num9 = -1143448492;
							num23 = num9;
						}
						else
						{
							num9 = -316076697;
							num23 = num9;
						}
						continue;
						IL_08de:
						int num24;
						if (Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(199488088u)] >= mAX_ATTRIBUTE)
						{
							num9 = -1438780802;
							num24 = num9;
						}
						else
						{
							num9 = -366448362;
							num24 = num9;
						}
						continue;
						IL_0886:
						int num25;
						if (Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(136168559u)] <= num11)
						{
							num9 = -583779701;
							num25 = num9;
						}
						else
						{
							num9 = -57508694;
							num25 = num9;
						}
						continue;
						IL_0ff9:
						int num26;
						if (Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2981046594u)] > num11)
						{
							num9 = -1879335095;
							num26 = num9;
						}
						else
						{
							num9 = -151423696;
							num26 = num9;
						}
						continue;
						IL_0b59:
						int num27;
						if (Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(400004197u)] < mAX_ATTRIBUTE)
						{
							num9 = -739945666;
							num27 = num9;
						}
						else
						{
							num9 = -1827724973;
							num27 = num9;
						}
						continue;
						IL_0936:
						int num28;
						if (Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2930940463u)] <= num11)
						{
							num9 = -7972221;
							num28 = num9;
						}
						else
						{
							num9 = -855099150;
							num28 = num9;
						}
						continue;
						IL_0e8a:
						int num29;
						if (Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2053407229u)] <= num11)
						{
							num9 = -377587804;
							num29 = num9;
						}
						else
						{
							num9 = -554992651;
							num29 = num9;
						}
						continue;
						IL_07b7:
						int num30;
						if (Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(739543880u)] >= mAX_ATTRIBUTE)
						{
							num9 = -1723476852;
							num30 = num9;
						}
						else
						{
							num9 = -2109121623;
							num30 = num9;
						}
						continue;
						IL_09e3:
						int num31;
						if (Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(912726802u)] > num11)
						{
							num9 = -319153167;
							num31 = num9;
						}
						else
						{
							num9 = -967331122;
							num31 = num9;
						}
						continue;
						IL_0d54:
						int num32;
						if (Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(788062007u)] >= mAX_ATTRIBUTE)
						{
							num9 = -1912968360;
							num32 = num9;
						}
						else
						{
							num9 = -2129771165;
							num32 = num9;
						}
						continue;
						IL_08b2:
						int num33;
						if (Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4176639349u)] >= mAX_ATTRIBUTE)
						{
							num9 = -1463400944;
							num33 = num9;
						}
						else
						{
							num9 = -226088276;
							num33 = num9;
						}
						continue;
						IL_090a:
						int num34;
						if (Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3583101943u)] <= num11)
						{
							num9 = -1625838475;
							num34 = num9;
						}
						else
						{
							num9 = -1656336352;
							num34 = num9;
						}
						continue;
						IL_0c90:
						int num35;
						if (Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(430829805u)] < mAX_ATTRIBUTE)
						{
							num9 = -1347734895;
							num35 = num9;
						}
						else
						{
							num9 = -1478024254;
							num35 = num9;
						}
						continue;
						IL_09b7:
						int num36;
						if (Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1790491204u)] < mAX_ATTRIBUTE)
						{
							num9 = -1199911584;
							num36 = num9;
						}
						else
						{
							num9 = -729695027;
							num36 = num9;
						}
						continue;
						IL_0762:
						int num37;
						if (Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(788062007u)] > num11)
						{
							num9 = -1929778457;
							num37 = num9;
						}
						else
						{
							num9 = -1499070391;
							num37 = num9;
						}
						continue;
						IL_0bb1:
						int num38;
						if (Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2930940463u)] >= mAX_ATTRIBUTE)
						{
							num9 = -873945335;
							num38 = num9;
						}
						else
						{
							num9 = -1069209968;
							num38 = num9;
						}
						continue;
						IL_080c:
						int num39;
						if (Exp <= LevelupExp)
						{
							num9 = -1107388566;
							num39 = num9;
						}
						else
						{
							num9 = -424405173;
							num39 = num9;
						}
					}
					goto IL_05c9;
					IL_05c9:
					num9 = -1073256727;
					goto IL_05ce;
					IL_038b:
					if (!itemSkill.IsInternal)
					{
						num40 = -1953998610;
						goto IL_02fc;
					}
					goto IL_1125;
					IL_02fc:
					while (true)
					{
						switch ((num2 = (uint)(num40 ^ -290437965)) % 13)
						{
						case 0u:
							break;
						case 1u:
							mAX_SKILL_COUNT = MAX_SKILL_COUNT;
							num40 = (int)(num2 * 1242256006) ^ -1535241146;
							continue;
						case 12u:
							internalSkillInstance.RefreshUniquSkills();
							num40 = ((int)num2 * -1632069847) ^ 0x34C6F7A7;
							continue;
						case 2u:
							flag3 = false;
							num40 = (int)((num2 * 1350669897) ^ 0x4F7805);
							continue;
						case 4u:
							goto IL_038b;
						case 7u:
							internalSkillInstance = new InternalSkillInstance
							{
								name = itemSkill.SkillName,
								level = 1,
								level2 = -1f,
								equipped = 0,
								Owner = this
							};
							num40 = ((int)num2 * -1165913480) ^ -630168335;
							continue;
						case 5u:
							if (Skills.Count <= mAX_SKILL_COUNT)
							{
								num40 = (int)((num2 * 612472994) ^ 0x2E0AC6DA);
								continue;
							}
							goto IL_1125;
						case 3u:
							if (itemSkill.MaxLevel > 0)
							{
								num40 = ((int)num2 * -1126957310) ^ -319589892;
								continue;
							}
							goto IL_1125;
						case 9u:
							if (InternalSkills.Count < mAX_INTERNALSKILL_COUNT)
							{
								num40 = (int)((num2 * 1364974460) ^ 0x153635D3);
								continue;
							}
							goto IL_1125;
						case 11u:
							InternalSkills.Add(internalSkillInstance);
							num40 = (int)(num2 * 1020799102) ^ -378673845;
							continue;
						case 10u:
							internalSkillInstance.TryAddExp(add);
							num40 = ((int)num2 * -2069976588) ^ -1241359907;
							continue;
						default:
							goto IL_04a6;
						case 6u:
							goto IL_1125;
						}
						break;
					}
					goto IL_02f7;
					IL_04a6:
					using (List<SkillInstance>.Enumerator enumerator2 = Skills.GetEnumerator())
					{
						while (true)
						{
							IL_0563:
							int num43;
							int num44;
							if (enumerator2.MoveNext())
							{
								num43 = -1844637242;
								num44 = num43;
							}
							else
							{
								num43 = -2078209804;
								num44 = num43;
							}
							while (true)
							{
								switch ((num2 = (uint)(num43 ^ -290437965)) % 8)
								{
								case 0u:
									num43 = -1844637242;
									continue;
								default:
									goto end_IL_04bd;
								case 2u:
								{
									int num46;
									int num47;
									if (itemSkill.MaxLevel < current2.Level)
									{
										num46 = 1136576012;
										num47 = num46;
									}
									else
									{
										num46 = 647331960;
										num47 = num46;
									}
									num43 = num46 ^ (int)(num2 * 1012577868);
									continue;
								}
								case 6u:
									goto end_IL_04bd;
								case 5u:
								{
									current2 = enumerator2.Current;
									int num45;
									if (_202D_202C_200F_200C_202D_206C_202D_206C_200D_200D_200C_206A_206F_200B_202B_202B_200D_206E_202A_200E_202C_202C_202E_200D_206D_200C_206A_202A_200F_202D_206D_200C_206A_200F_206B_206D_206A_202C_200D_202A_202E(current2.Name, itemSkill.SkillName))
									{
										num43 = -700647054;
										num45 = num43;
									}
									else
									{
										num43 = -1497686289;
										num45 = num43;
									}
									continue;
								}
								case 4u:
									break;
								case 3u:
									current2.TryAddExp(add);
									num43 = ((int)num2 * -1313065851) ^ 0x37BF4A4A;
									continue;
								case 1u:
									flag3 = true;
									num43 = ((int)num2 * -1658338544) ^ -2066923607;
									continue;
								case 7u:
									goto end_IL_04bd;
								}
								goto IL_0563;
								continue;
								end_IL_04bd:
								break;
							}
							break;
						}
					}
					if (!flag3)
					{
						goto IL_05c9;
					}
					goto IL_1125;
					IL_02f7:
					num40 = -392466611;
					goto IL_02fc;
					IL_1125:
					result = false;
					num9 = -1780060487;
					goto IL_05ce;
				}
				break;
			}
		}
	}

	public bool CanLearnTalent(string t, ref int need)
	{
		int talentCost = Resource.GetTalentCost(t);
		int num = AttributesFinal[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1418183660u)];
		int totalWuxueCost = default(int);
		while (true)
		{
			int num2 = 766315761;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x7314F1E0)) % 4)
				{
				case 2u:
					break;
				case 1u:
					totalWuxueCost = GetTotalWuxueCost();
					num2 = ((int)num3 * -1714358983) ^ -580075514;
					continue;
				case 3u:
					need = talentCost;
					num2 = (int)(num3 * 1626683729) ^ -718099737;
					continue;
				default:
					return talentCost + totalWuxueCost <= num;
				}
				break;
			}
		}
	}

	public int GetTotalWuxueCost()
	{
		int num = 0;
		List<string>.Enumerator enumerator = Talents.GetEnumerator();
		try
		{
			string current = default(string);
			while (true)
			{
				IL_0061:
				int num2;
				int num3;
				if (!enumerator.MoveNext())
				{
					num2 = -642323855;
					num3 = num2;
				}
				else
				{
					num2 = -1592498756;
					num3 = num2;
				}
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)(num2 ^ -1279533327)) % 5)
					{
					case 0u:
						num2 = -1592498756;
						continue;
					default:
						goto end_IL_0015;
					case 2u:
						current = enumerator.Current;
						num2 = -836386373;
						continue;
					case 3u:
						num += Resource.GetTalentCost(current);
						num2 = ((int)num4 * -270076611) ^ -482775791;
						continue;
					case 1u:
						break;
					case 4u:
						goto end_IL_0015;
					}
					goto IL_0061;
					continue;
					end_IL_0015:
					break;
				}
				break;
			}
		}
		finally
		{
			_202D_200E_200B_206B_200E_206D_200F_200C_202B_200F_202A_202A_206D_206D_206B_202B_202C_206D_206B_202D_202A_206A_202E_200B_202B_200C_202E_200D_206B_202C_202C_202E_206E_202C_202B_206D_202E_202C_200F_200E_202E((IDisposable)enumerator);
		}
		return num;
	}

	public void addRoundSkillLevel()
	{
		int num = RuntimeData.Instance.Round / LuaManager.GetConfigInt(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3144813227u));
		int mAX_SKILL_LEVEL = default(int);
		SkillInstance current = default(SkillInstance);
		InternalSkillInstance current2 = default(InternalSkillInstance);
		while (true)
		{
			int num2 = -985561969;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1615962906)) % 4)
				{
				case 3u:
					break;
				case 1u:
					if (num > 0)
					{
						num2 = ((int)num3 * -1945004725) ^ -1173983269;
						continue;
					}
					return;
				case 2u:
					mAX_SKILL_LEVEL = MAX_SKILL_LEVEL;
					num2 = (int)((num3 * 1735972993) ^ 0x68BF0E60);
					continue;
				default:
				{
					int mAX_INTERNALSKILL_LEVEL = MAX_INTERNALSKILL_LEVEL;
					using (List<SkillInstance>.Enumerator enumerator = Skills.GetEnumerator())
					{
						while (true)
						{
							IL_00bb:
							int num4;
							int num5;
							if (!enumerator.MoveNext())
							{
								num4 = -1496549138;
								num5 = num4;
							}
							else
							{
								num4 = -1990151251;
								num5 = num4;
							}
							while (true)
							{
								switch ((num3 = (uint)(num4 ^ -1615962906)) % 7)
								{
								case 3u:
									num4 = -1990151251;
									continue;
								default:
									goto end_IL_008a;
								case 4u:
									break;
								case 5u:
								{
									int num6;
									int num7;
									if (current.level > mAX_SKILL_LEVEL)
									{
										num6 = -1850242308;
										num7 = num6;
									}
									else
									{
										num6 = -1599752143;
										num7 = num6;
									}
									num4 = num6 ^ ((int)num3 * -2111284231);
									continue;
								}
								case 1u:
									current.level2 = 0f - (float)current.level;
									num4 = -1438879087;
									continue;
								case 0u:
									current.level = mAX_SKILL_LEVEL;
									num4 = (int)((num3 * 1068574196) ^ 0x2E61956);
									continue;
								case 2u:
									current = enumerator.Current;
									current.level += num;
									num4 = -2030586323;
									continue;
								case 6u:
									goto end_IL_008a;
								}
								goto IL_00bb;
								continue;
								end_IL_008a:
								break;
							}
							break;
						}
					}
					using List<InternalSkillInstance>.Enumerator enumerator2 = InternalSkills.GetEnumerator();
					while (true)
					{
						int num8;
						int num9;
						if (!enumerator2.MoveNext())
						{
							num8 = -730750536;
							num9 = num8;
						}
						else
						{
							num8 = -638439079;
							num9 = num8;
						}
						while (true)
						{
							switch ((num3 = (uint)(num8 ^ -1615962906)) % 7)
							{
							case 5u:
								num8 = -638439079;
								continue;
							default:
								return;
							case 2u:
								current2.level2 = 0f - (float)current2.level;
								num8 = -383474488;
								continue;
							case 4u:
								break;
							case 0u:
							{
								current2.level += num;
								int num10;
								int num11;
								if (current2.level <= mAX_INTERNALSKILL_LEVEL)
								{
									num10 = -434534286;
									num11 = num10;
								}
								else
								{
									num10 = -708507417;
									num11 = num10;
								}
								num8 = num10 ^ (int)(num3 * 1151383414);
								continue;
							}
							case 6u:
								current2 = enumerator2.Current;
								num8 = -1386506523;
								continue;
							case 1u:
								current2.level = mAX_INTERNALSKILL_LEVEL;
								num8 = (int)(num3 * 764952614) ^ -859907934;
								continue;
							case 3u:
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

	public void addRandomTalentAndWeapons()
	{
		addRandomTalent();
	}

	private void addRandomTalent()
	{
		int num = 0;
		string text5 = default(string);
		string text = default(string);
		int num6 = default(int);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		int randomInt = default(int);
		while (true)
		{
			int num2 = 94505234;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x2D64F49B)) % 40)
				{
				case 30u:
					break;
				default:
					return;
				case 33u:
				{
					int num27;
					int num28;
					if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(RuntimeData.Instance.GameMode, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2124360156u)))
					{
						num27 = -41930807;
						num28 = num27;
					}
					else
					{
						num27 = -2139926191;
						num28 = num27;
					}
					num2 = num27 ^ (int)(num3 * 1185553297);
					continue;
				}
				case 5u:
					Talents.Add(text5);
					num2 = (int)(num3 * 773284291) ^ -943295869;
					continue;
				case 14u:
					text = CommonSettings.GetEnemyRandomTalentListCrazyDefence();
					num2 = 685456796;
					continue;
				case 28u:
				{
					int num21;
					int num22;
					if (!HasTalent(text5))
					{
						num21 = -1866028350;
						num22 = num21;
					}
					else
					{
						num21 = -1151812593;
						num22 = num21;
					}
					num2 = num21 ^ ((int)num3 * -633788631);
					continue;
				}
				case 13u:
				{
					int num7;
					if (num6 >= num)
					{
						num2 = 840571314;
						num7 = num2;
					}
					else
					{
						num2 = 1726486595;
						num7 = num2;
					}
					continue;
				}
				case 12u:
					text5 = string.Empty;
					num6 = 0;
					num2 = 2138331879;
					continue;
				case 3u:
				{
					int num13;
					int num14;
					if (HasTalent(text))
					{
						num13 = -333056773;
						num14 = num13;
					}
					else
					{
						num13 = -2000665791;
						num14 = num13;
					}
					num2 = num13 ^ (int)(num3 * 23267166);
					continue;
				}
				case 4u:
					text2 = string.Empty;
					num2 = 1493801774;
					continue;
				case 20u:
				{
					int num23;
					int num24;
					if (num < 4)
					{
						num23 = -780024425;
						num24 = num23;
					}
					else
					{
						num23 = -1686713447;
						num24 = num23;
					}
					num2 = num23 ^ (int)(num3 * 2061699458);
					continue;
				}
				case 2u:
				{
					int num17;
					int num18;
					if (!HasTalent(text))
					{
						num17 = -839987963;
						num18 = num17;
					}
					else
					{
						num17 = -952799934;
						num18 = num17;
					}
					num2 = num17 ^ ((int)num3 * -2023091016);
					continue;
				}
				case 36u:
					num2 = (int)(num3 * 611499695) ^ -1462039974;
					continue;
				case 17u:
					num = 3;
					num2 = (int)((num3 * 441966663) ^ 0x47011CF2);
					continue;
				case 31u:
					num6++;
					num2 = ((int)num3 * -1243003689) ^ -2082255201;
					continue;
				case 27u:
				{
					int num10;
					if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(RuntimeData.Instance.GameMode, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2143033974u)))
					{
						num2 = 1244102320;
						num10 = num2;
					}
					else
					{
						num2 = 193487965;
						num10 = num2;
					}
					continue;
				}
				case 8u:
					num2 = ((int)num3 * -1770274022) ^ -249227941;
					continue;
				case 37u:
					text2 = CommonSettings.GetEnemyRandomTalentListCrazyAttack();
					num2 = 2041593162;
					continue;
				case 19u:
					num = 4;
					num2 = 193487965;
					continue;
				case 23u:
					num2 = ((int)num3 * -1607554392) ^ -1240833979;
					continue;
				case 10u:
					text = CommonSettings.GetEnemyRandomTalentListCrazyOther();
					num2 = 1597951952;
					continue;
				case 18u:
					return;
				case 1u:
				{
					int num25;
					int num26;
					if (!HasTalent(text2))
					{
						num25 = -1861559253;
						num26 = num25;
					}
					else
					{
						num25 = -1820619445;
						num26 = num25;
					}
					num2 = num25 ^ (int)(num3 * 1049285717);
					continue;
				}
				case 22u:
					num2 = (int)((num3 * 1764926870) ^ 0x209CB93F);
					continue;
				case 35u:
					num = 1;
					num2 = (int)((num3 * 331510010) ^ 0x741FD8D2);
					continue;
				case 11u:
				{
					int num19;
					int num20;
					if (RuntimeData.Instance.AutoSaveOnly)
					{
						num19 = -264532638;
						num20 = num19;
					}
					else
					{
						num19 = -1494692872;
						num20 = num19;
					}
					num2 = num19 ^ ((int)num3 * -926514514);
					continue;
				}
				case 15u:
					Talents.Add(text3);
					text4 = string.Empty;
					num2 = ((int)num3 * -1803138869) ^ -625905938;
					continue;
				case 24u:
				{
					text4 = CommonSettings.GetEnemyRandomTalentListCrazyOther();
					int num16;
					if (HasTalent(text4))
					{
						num2 = 858083595;
						num16 = num2;
					}
					else
					{
						num2 = 859267068;
						num16 = num2;
					}
					continue;
				}
				case 0u:
					Talents.Add(text);
					num2 = 2070615247;
					continue;
				case 32u:
					text5 = CommonSettings.GetEnemyRandomTalent(Female);
					num2 = 1725363191;
					continue;
				case 21u:
					Talents.Add(text2);
					text3 = string.Empty;
					num2 = (int)(num3 * 271057652) ^ -1958537190;
					continue;
				case 7u:
					Talents.Add(text4);
					num2 = (int)(num3 * 835748542) ^ -1113689925;
					continue;
				case 26u:
				{
					int num15;
					if (randomInt == 2)
					{
						num2 = 1876293173;
						num15 = num2;
					}
					else
					{
						num2 = 1105471089;
						num15 = num2;
					}
					continue;
				}
				case 39u:
				{
					int num11;
					int num12;
					if (HasTalent(text))
					{
						num11 = -498810262;
						num12 = num11;
					}
					else
					{
						num11 = -909138516;
						num12 = num11;
					}
					num2 = num11 ^ ((int)num3 * -1688953879);
					continue;
				}
				case 29u:
				{
					text3 = CommonSettings.GetEnemyRandomTalentListCrazyDefence();
					int num9;
					if (HasTalent(text3))
					{
						num2 = 1743951134;
						num9 = num2;
					}
					else
					{
						num2 = 1032487060;
						num9 = num2;
					}
					continue;
				}
				case 34u:
					randomInt = Tools.GetRandomInt(1, 3);
					num2 = (int)(num3 * 698775339) ^ -1165849827;
					continue;
				case 6u:
				{
					int num8;
					if (num >= 3)
					{
						num2 = 134087479;
						num8 = num2;
					}
					else
					{
						num2 = 924317183;
						num8 = num2;
					}
					continue;
				}
				case 38u:
				{
					int num4;
					int num5;
					if (randomInt == 1)
					{
						num4 = -106469822;
						num5 = num4;
					}
					else
					{
						num4 = -1571396607;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num3 * -66960024);
					continue;
				}
				case 16u:
					text = string.Empty;
					num2 = ((int)num3 * -365861563) ^ -1683108467;
					continue;
				case 9u:
					text = CommonSettings.GetEnemyRandomTalentListCrazyAttack();
					num2 = 1611510049;
					continue;
				case 25u:
					return;
				}
				break;
			}
		}
	}

	public bool HasRoleTalent(string talent)
	{
		if (Talents.Contains(talent))
		{
			while (true)
			{
				uint num;
				switch ((num = 920491288u) % 3)
				{
				case 2u:
					continue;
				case 1u:
					return true;
				}
				break;
			}
		}
		return false;
	}

	public bool HasEquipmentTalent(string talent)
	{
		if (EquipmentTalents.Contains(talent))
		{
			goto IL_000e;
		}
		goto IL_0074;
		IL_000e:
		int num = -49611400;
		goto IL_0013;
		IL_0013:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1099101417)) % 6)
			{
			case 4u:
				break;
			case 0u:
				return true;
			case 1u:
			{
				int num3;
				int num4;
				if (EquippedInternalSkill.HasTalent(talent))
				{
					num3 = -525421489;
					num4 = num3;
				}
				else
				{
					num3 = -1397019392;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 905834248);
				continue;
			}
			case 2u:
				goto IL_0074;
			case 3u:
				return true;
			default:
				goto IL_00a1;
			}
			break;
		}
		goto IL_000e;
		IL_01ea:
		bool result = default(bool);
		return result;
		IL_00a1:
		using (List<SkillInstance>.Enumerator enumerator = Skills.GetEnumerator())
		{
			SkillInstance current = default(SkillInstance);
			while (true)
			{
				IL_0111:
				int num5;
				int num6;
				if (!enumerator.MoveNext())
				{
					num5 = -1535868959;
					num6 = num5;
				}
				else
				{
					num5 = -39166824;
					num6 = num5;
				}
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num5 ^ -1099101417)) % 7)
					{
					case 4u:
						num5 = -39166824;
						continue;
					default:
						goto end_IL_00b4;
					case 1u:
					{
						current = enumerator.Current;
						int num9;
						if (current == null)
						{
							num5 = -573259985;
							num9 = num5;
						}
						else
						{
							num5 = -1265129707;
							num9 = num5;
						}
						continue;
					}
					case 0u:
						result = true;
						num5 = (int)(num2 * 1633408025) ^ -1590914260;
						continue;
					case 2u:
						break;
					case 6u:
					{
						int num7;
						int num8;
						if (current.HasTalent(talent))
						{
							num7 = -545988500;
							num8 = num7;
						}
						else
						{
							num7 = -291229913;
							num8 = num7;
						}
						num5 = num7 ^ ((int)num2 * -683479036);
						continue;
					}
					case 5u:
						goto end_IL_00b4;
					case 3u:
						goto IL_01ea;
					}
					goto IL_0111;
					continue;
					end_IL_00b4:
					break;
				}
				break;
			}
		}
		if (EquippedTitle != null)
		{
			while (true)
			{
				int num10 = -531568923;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num10 ^ -1099101417)) % 5)
					{
					case 4u:
						break;
					case 3u:
					{
						int num11;
						int num12;
						if (!EquippedTitle.HasTalent(talent))
						{
							num11 = -141504164;
							num12 = num11;
						}
						else
						{
							num11 = -1338783039;
							num12 = num11;
						}
						num10 = num11 ^ (int)(num2 * 1659118022);
						continue;
					}
					case 1u:
						return true;
					case 2u:
						goto end_IL_017f;
					default:
						goto IL_01ea;
					}
					break;
				}
				continue;
				end_IL_017f:
				break;
			}
		}
		return false;
		IL_0074:
		int num13;
		if (EquippedInternalSkill != null)
		{
			num = -749890946;
			num13 = num;
		}
		else
		{
			num = -1908801720;
			num13 = num;
		}
		goto IL_0013;
	}

	public void addRoundSkillLevel_Zhenlongqiju()
	{
		int num = RuntimeData.Instance.Round / LuaManager.GetConfigInt(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(631725038u));
		if (num <= 1)
		{
			return;
		}
		using (List<SkillInstance>.Enumerator enumerator = Skills.GetEnumerator())
		{
			while (true)
			{
				IL_0085:
				int num2;
				int num3;
				if (enumerator.MoveNext())
				{
					num2 = 1327404047;
					num3 = num2;
				}
				else
				{
					num2 = 2071648113;
					num3 = num2;
				}
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)(num2 ^ 0x7BEFA8A5)) % 4)
					{
					case 3u:
						num2 = 1327404047;
						continue;
					default:
						goto end_IL_0035;
					case 2u:
					{
						SkillInstance current = enumerator.Current;
						current.level += Tools.GetRandomInt(0, 1);
						current.level2 = 0f - (float)current.level;
						num2 = 1809510260;
						continue;
					}
					case 1u:
						break;
					case 0u:
						goto end_IL_0035;
					}
					goto IL_0085;
					continue;
					end_IL_0035:
					break;
				}
				break;
			}
		}
		using List<InternalSkillInstance>.Enumerator enumerator2 = InternalSkills.GetEnumerator();
		while (true)
		{
			int num5;
			int num6;
			if (!enumerator2.MoveNext())
			{
				num5 = 1253425859;
				num6 = num5;
			}
			else
			{
				num5 = 359443056;
				num6 = num5;
			}
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)(num5 ^ 0x7BEFA8A5)) % 4)
				{
				case 0u:
					num5 = 359443056;
					continue;
				default:
					return;
				case 1u:
				{
					InternalSkillInstance current2 = enumerator2.Current;
					current2.level += Tools.GetRandomInt((int)((double)num / 10.0), (int)((double)num / 5.0));
					current2.level2 = 0f - (float)current2.level;
					num5 = 629844430;
					continue;
				}
				case 3u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	internal bool AddExpBattle(int add)
	{
		bool flag = false;
		ItemInstance equipment = default(ItemInstance);
		ItemSkill itemSkill = default(ItemSkill);
		bool flag2 = default(bool);
		InternalSkillInstance current = default(InternalSkillInstance);
		InternalSkillInstance internalSkillInstance = default(InternalSkillInstance);
		bool flag3 = default(bool);
		SkillInstance current2 = default(SkillInstance);
		bool flag4 = default(bool);
		int num35 = default(int);
		int num32 = default(int);
		SkillInstance skillInstance = default(SkillInstance);
		int num29 = default(int);
		SkillInstance current3 = default(SkillInstance);
		while (true)
		{
			int num = 1598903965;
			while (true)
			{
				int num12;
				int num24;
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7BFB1AD9)) % 12)
				{
				case 5u:
					break;
				case 4u:
					equipment = GetEquipment(4);
					num = 1180567767;
					continue;
				case 1u:
					Exp += add * 2;
					num = (int)((num2 * 1520996983) ^ 0x2685C28E);
					continue;
				case 9u:
					if (itemSkill.IsInternal)
					{
						num = (int)(num2 * 384748433) ^ -1089640978;
						continue;
					}
					goto IL_03a7;
				case 8u:
				{
					int num22;
					int num23;
					if (BuiltInTalents[156])
					{
						num22 = -1291633960;
						num23 = num22;
					}
					else
					{
						num22 = -906304773;
						num23 = num22;
					}
					num = num22 ^ (int)(num2 * 1326024943);
					continue;
				}
				case 11u:
					itemSkill = equipment.GetItemSkill();
					num = ((int)num2 * -522632803) ^ 0x19DDD461;
					continue;
				case 6u:
					if (equipment != null)
					{
						num = (int)((num2 * 1717705536) ^ 0x5903910A);
						continue;
					}
					goto IL_0fb6;
				case 10u:
					Exp += add;
					num = 154418069;
					continue;
				case 7u:
					flag2 = false;
					num = (int)(num2 * 603401385) ^ -46527482;
					continue;
				case 2u:
					if (InternalSkills.Count <= BattleField.ROLE_MAX_INTERNALSKILL_COUNT[this])
					{
						num = (int)((num2 * 104818137) ^ 0x3469C4A8);
						continue;
					}
					goto IL_0fb6;
				case 3u:
					if (itemSkill != null)
					{
						num = (int)((num2 * 356563479) ^ 0x6DDE0905);
						continue;
					}
					goto IL_0fb6;
				default:
					{
						using (List<InternalSkillInstance>.Enumerator enumerator = InternalSkills.GetEnumerator())
						{
							while (true)
							{
								IL_021e:
								int num3;
								int num4;
								if (enumerator.MoveNext())
								{
									num3 = 1831244248;
									num4 = num3;
								}
								else
								{
									num3 = 121924079;
									num4 = num3;
								}
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ 0x7BFB1AD9)) % 9)
									{
									case 3u:
										num3 = 1831244248;
										continue;
									default:
										goto end_IL_018b;
									case 2u:
										current = enumerator.Current;
										num3 = 1130000325;
										continue;
									case 7u:
										flag = true;
										goto end_IL_018b;
									case 5u:
									{
										int num7;
										int num8;
										if (!_202D_202C_200F_200C_202D_206C_202D_206C_200D_200D_200C_206A_206F_200B_202B_202B_200D_206E_202A_200E_202C_202C_202E_200D_206D_200C_206A_202A_200F_202D_206D_200C_206A_200F_206B_206D_206A_202C_200D_202A_202E(current.Name, itemSkill.SkillName))
										{
											num7 = 1154914900;
											num8 = num7;
										}
										else
										{
											num7 = 1097158569;
											num8 = num7;
										}
										num3 = num7 ^ (int)(num2 * 2000680856);
										continue;
									}
									case 1u:
										break;
									case 6u:
									{
										int num9 = current.level;
										current.TryAddExpBattle(add);
										int num10;
										int num11;
										if (num9 != current.level)
										{
											num10 = 63810494;
											num11 = num10;
										}
										else
										{
											num10 = 1831779135;
											num11 = num10;
										}
										num3 = num10 ^ (int)(num2 * 212493112);
										continue;
									}
									case 0u:
									{
										flag2 = true;
										int num5;
										int num6;
										if (itemSkill.MaxLevel >= current.Level)
										{
											num5 = 2085170687;
											num6 = num5;
										}
										else
										{
											num5 = 296526943;
											num6 = num5;
										}
										num3 = num5 ^ ((int)num2 * -694286633);
										continue;
									}
									case 8u:
										current.SkillVariables();
										num3 = ((int)num2 * -1257324518) ^ -418822061;
										continue;
									case 4u:
										goto end_IL_018b;
									}
									goto IL_021e;
									continue;
									end_IL_018b:
									break;
								}
								break;
							}
						}
						if (!flag2)
						{
							goto IL_02d2;
						}
						goto IL_0fb6;
					}
					IL_02d7:
					while (true)
					{
						switch ((num2 = (uint)(num12 ^ 0x7BFB1AD9)) % 10)
						{
						case 7u:
							break;
						case 2u:
							goto IL_0315;
						case 4u:
							internalSkillInstance = new InternalSkillInstance
							{
								name = itemSkill.SkillName,
								level = 1,
								level2 = -1f,
								equipped = 0,
								Owner = this
							};
							num12 = ((int)num2 * -65247667) ^ -652563097;
							continue;
						case 3u:
							goto IL_0379;
						case 8u:
							goto IL_03a7;
						case 5u:
							goto IL_03bd;
						case 6u:
							internalSkillInstance.RefreshUniquSkills();
							InternalSkills.Add(internalSkillInstance);
							internalSkillInstance.TryAddExpBattle(add);
							internalSkillInstance.SkillVariables();
							num12 = (int)(num2 * 43423798) ^ -1245237668;
							continue;
						case 9u:
							goto IL_0422;
						case 1u:
							flag3 = false;
							num12 = (int)(num2 * 1141052356) ^ -984742457;
							continue;
						default:
							goto IL_0452;
						}
						break;
						IL_0422:
						flag = true;
						goto IL_0fb6;
						IL_03bd:
						if (InternalSkills.Count < BattleField.ROLE_MAX_INTERNALSKILL_COUNT[this])
						{
							num12 = ((int)num2 * -1296469295) ^ -2128312914;
							continue;
						}
						goto IL_0fb6;
						IL_0315:
						if (itemSkill.MaxLevel > 0)
						{
							num12 = (int)(num2 * 1249560689) ^ -1772816932;
							continue;
						}
						goto IL_0fb6;
						IL_0379:
						if (Skills.Count <= BattleField.ROLE_MAX_SKILL_COUNT[this])
						{
							num12 = (int)(num2 * 1149830142) ^ -1593134336;
							continue;
						}
						goto IL_0fb6;
					}
					goto IL_02d2;
					IL_0452:
					using (List<SkillInstance>.Enumerator enumerator2 = Skills.GetEnumerator())
					{
						while (true)
						{
							IL_04c7:
							int num13;
							int num14;
							if (!enumerator2.MoveNext())
							{
								num13 = 184624010;
								num14 = num13;
							}
							else
							{
								num13 = 1038700283;
								num14 = num13;
							}
							while (true)
							{
								switch ((num2 = (uint)(num13 ^ 0x7BFB1AD9)) % 9)
								{
								case 6u:
									num13 = 1038700283;
									continue;
								default:
									goto end_IL_0466;
								case 8u:
									current2 = enumerator2.Current;
									num13 = 134040557;
									continue;
								case 0u:
									flag = true;
									goto end_IL_0466;
								case 3u:
									break;
								case 2u:
								{
									int num18;
									int num19;
									if (!_202D_202C_200F_200C_202D_206C_202D_206C_200D_200D_200C_206A_206F_200B_202B_202B_200D_206E_202A_200E_202C_202C_202E_200D_206D_200C_206A_202A_200F_202D_206D_200C_206A_200F_206B_206D_206A_202C_200D_202A_202E(current2.Name, itemSkill.SkillName))
									{
										num18 = 867851481;
										num19 = num18;
									}
									else
									{
										num18 = 286121038;
										num19 = num18;
									}
									num13 = num18 ^ (int)(num2 * 848341742);
									continue;
								}
								case 7u:
								{
									flag3 = true;
									int num20;
									int num21;
									if (itemSkill.MaxLevel < current2.Level)
									{
										num20 = 610320697;
										num21 = num20;
									}
									else
									{
										num20 = 2008088582;
										num21 = num20;
									}
									num13 = num20 ^ (int)(num2 * 2088472797);
									continue;
								}
								case 1u:
									current2.SkillVariables();
									num13 = (int)(num2 * 1478543682) ^ -596043364;
									continue;
								case 5u:
								{
									int num15 = current2.level;
									current2.TryAddExpBattle(add);
									int num16;
									int num17;
									if (num15 != current2.level)
									{
										num16 = 278350511;
										num17 = num16;
									}
									else
									{
										num16 = 517225502;
										num17 = num16;
									}
									num13 = num16 ^ (int)(num2 * 399323647);
									continue;
								}
								case 4u:
									goto end_IL_0466;
								}
								goto IL_04c7;
								continue;
								end_IL_0466:
								break;
							}
							break;
						}
					}
					if (!flag3)
					{
						goto IL_05aa;
					}
					goto IL_0fb6;
					IL_0fb6:
					flag4 = false;
					num24 = 1366487693;
					goto IL_05af;
					IL_05af:
					while (true)
					{
						switch ((num2 = (uint)(num24 ^ 0x7BFB1AD9)) % 62)
						{
						case 18u:
							break;
						case 31u:
						{
							int num40;
							int num41;
							if (Skills.Count >= BattleField.ROLE_MAX_SKILL_COUNT[this])
							{
								num40 = -1929762703;
								num41 = num40;
							}
							else
							{
								num40 = -377977974;
								num41 = num40;
							}
							num24 = num40 ^ ((int)num2 * -1237999043);
							continue;
						}
						case 17u:
							leftpoint += 2;
							num24 = ((int)num2 * -887313398) ^ -824225029;
							continue;
						case 8u:
							Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1940200750u)] = Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1940200750u)] + GrowTemplate.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2077292732u)];
							num24 = (int)(num2 * 1296697678) ^ -1473834987;
							continue;
						case 46u:
							num35 = Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(187771104u)] - addmaxmp;
							num24 = (int)(num2 * 1180123009) ^ -1174028165;
							continue;
						case 57u:
							Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1995100678u)] = _206D_200E_206D_202C_206A_206D_200F_200E_206A_206D_202A_202D_206D_200D_200F_200C_206C_206C_200B_206C_202A_206B_206A_202A_206E_200B_202B_200B_202D_202E_202A_206B_200E_202D_206F_206D_206F_206C_206B_200D_202E(1, num29 + addmaxhp);
							num24 = 1147021375;
							continue;
						case 58u:
							num24 = (int)(num2 * 332566078) ^ -1005955770;
							continue;
						case 43u:
							Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(788062007u)] = Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2475589736u)] + GrowTemplate.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1550623476u)];
							num24 = (int)((num2 * 1065308216) ^ 0x67018C10);
							continue;
						case 16u:
							goto IL_0835;
						case 61u:
							Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(655417903u)] = num32;
							num24 = 1839082828;
							continue;
						case 60u:
							Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(430829805u)] = Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3535376985u)] + GrowTemplate.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(430829805u)];
							num24 = ((int)num2 * -1116800956) ^ -247526123;
							continue;
						case 32u:
							num35 += GrowTemplate.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1881894199u)];
							num24 = ((int)num2 * -578640737) ^ 0x574B0AE1;
							continue;
						case 10u:
							num24 = (int)(num2 * 266619062) ^ -2001211415;
							continue;
						case 24u:
							Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(136168559u)] = num32;
							num24 = 784129490;
							continue;
						case 2u:
							level++;
							num24 = 853210616;
							continue;
						case 15u:
							flag4 = true;
							num24 = 80367393;
							continue;
						case 13u:
							goto IL_097d;
						case 6u:
							Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2053407229u)] = num32;
							num24 = 532601045;
							continue;
						case 39u:
							Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2053407229u)] = Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(199488088u)] + GrowTemplate.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(199488088u)];
							num24 = (int)(num2 * 424991726) ^ -576117039;
							continue;
						case 44u:
							skillInstance = new SkillInstance
							{
								name = itemSkill.SkillName,
								level = 1,
								level2 = -1f,
								Owner = this
							};
							num24 = (int)((num2 * 1011078808) ^ 0x1861B75E);
							continue;
						case 38u:
							goto IL_0aa0;
						case 34u:
						{
							num32 = BattleField.ROLE_MAX_ATTRIBUTE[this];
							int num38;
							int num39;
							if (Level < BattleField.ROLE_MAX_LEVEL[this])
							{
								num38 = -570570039;
								num39 = num38;
							}
							else
							{
								num38 = -494508983;
								num39 = num38;
							}
							num24 = num38 ^ ((int)num2 * -1339352046);
							continue;
						}
						case 21u:
							goto IL_0b23;
						case 12u:
							goto IL_0b6a;
						case 11u:
							num24 = (int)(num2 * 1683242176) ^ -1863914228;
							continue;
						case 1u:
							Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3051962998u)] = num32;
							num24 = 487012667;
							continue;
						case 49u:
							if (flag4 || flag)
							{
								num24 = 464827495;
								continue;
							}
							goto IL_131d;
						case 30u:
						{
							int num36;
							int num37;
							if (num35 > BattleField.ROLE_MAX_HPMP[this])
							{
								num36 = -1985473263;
								num37 = num36;
							}
							else
							{
								num36 = -1949415092;
								num37 = num36;
							}
							num24 = num36 ^ ((int)num2 * -632227930);
							continue;
						}
						case 7u:
							num24 = (int)(num2 * 1829230871) ^ -363109508;
							continue;
						case 27u:
							goto IL_0c35;
						case 53u:
							Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(664072894u)] = num32;
							num24 = 887056999;
							continue;
						case 36u:
							Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(912726802u)] = num32;
							num24 = 882325017;
							continue;
						case 51u:
							Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(942219431u)] = Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4176639349u)] + GrowTemplate.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(942219431u)];
							num24 = (int)((num2 * 2107248406) ^ 0x4C2E7AD2);
							continue;
						case 19u:
							goto IL_0d14;
						case 26u:
							num35 = BattleField.ROLE_MAX_HPMP[this];
							num24 = ((int)num2 * -671996760) ^ -1254033068;
							continue;
						case 54u:
							Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2930940463u)] = Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(664072894u)] + GrowTemplate.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2741516750u)];
							num24 = ((int)num2 * -1704050386) ^ -224764729;
							continue;
						case 5u:
							goto IL_0dd3;
						case 50u:
							Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2223184606u)] = num32;
							num24 = 252658598;
							continue;
						case 33u:
							Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3535376985u)] = num32;
							num24 = 1867657009;
							continue;
						case 47u:
							Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2981046594u)] = num32;
							num24 = 1392103060;
							continue;
						case 48u:
							num24 = ((int)num2 * -1908891330) ^ 0x3418B109;
							continue;
						case 22u:
							leftpoint2 += 2.0;
							num24 = (int)(num2 * 1457455006) ^ -1021946584;
							continue;
						case 0u:
							Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2663905188u)] = Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2301880830u)] + GrowTemplate.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(739543880u)];
							num24 = ((int)num2 * -1564225625) ^ 0x2E0E529E;
							continue;
						case 25u:
							Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3795453722u)] = Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(710450445u)] + GrowTemplate.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1564888282u)];
							num24 = ((int)num2 * -673652624) ^ -2029025166;
							continue;
						case 55u:
							Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1550623476u)] = num32;
							num24 = 225858840;
							continue;
						case 3u:
						{
							int num33;
							int num34;
							if (Level < BattleField.ROLE_MAX_LEVEL[this])
							{
								num33 = -1288958478;
								num34 = num33;
							}
							else
							{
								num33 = -986493499;
								num34 = num33;
							}
							num24 = num33 ^ ((int)num2 * -778742089);
							continue;
						}
						case 45u:
							goto IL_0fb6;
						case 35u:
							skillInstance.RefreshUniquSkills();
							Skills.Add(skillInstance);
							num24 = (int)(num2 * 836042718) ^ -9411357;
							continue;
						case 29u:
							skillInstance.SkillVariables();
							num24 = (int)((num2 * 1958242183) ^ 0x4F735BCD);
							continue;
						case 28u:
						{
							int num30;
							int num31;
							if (num29 > BattleField.ROLE_MAX_HPMP[this])
							{
								num30 = -1539827510;
								num31 = num30;
							}
							else
							{
								num30 = -1533418044;
								num31 = num30;
							}
							num24 = num30 ^ (int)(num2 * 834663231);
							continue;
						}
						case 41u:
							num29 = BattleField.ROLE_MAX_HPMP[this];
							num24 = ((int)num2 * -922616271) ^ 0x59B02DE7;
							continue;
						case 42u:
							num24 = ((int)num2 * -2091994538) ^ 0x4A869903;
							continue;
						case 20u:
							goto IL_1062;
						case 9u:
							Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3628012406u)] = Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3051962998u)] + GrowTemplate.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3051962998u)];
							num24 = ((int)num2 * -665377004) ^ 0x1B5D63E7;
							continue;
						case 59u:
							Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(912726802u)] = Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(400004197u)] + GrowTemplate.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(400004197u)];
							num24 = (int)((num2 * 1784617462) ^ 0x1E47A908);
							continue;
						case 40u:
							goto IL_1134;
						case 56u:
							skillInstance.TryAddExpBattle(add);
							num24 = ((int)num2 * -1165685022) ^ 0x9911A3A;
							continue;
						case 37u:
							flag = true;
							num24 = ((int)num2 * -865071042) ^ -631071614;
							continue;
						case 23u:
							num29 = Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2431070502u)] - addmaxhp;
							num29 += GrowTemplate.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3054398905u)];
							num24 = ((int)num2 * -643724875) ^ 0x5875D782;
							continue;
						case 14u:
							Exp = 0;
							num24 = ((int)num2 * -503088071) ^ -2145234279;
							continue;
						case 4u:
							goto IL_1216;
						default:
							{
								using (List<SkillInstance>.Enumerator enumerator2 = Skills.GetEnumerator())
								{
									while (true)
									{
										IL_12b2:
										int num25;
										int num26;
										if (enumerator2.MoveNext())
										{
											num25 = 492691059;
											num26 = num25;
										}
										else
										{
											num25 = 972244528;
											num26 = num25;
										}
										while (true)
										{
											switch ((num2 = (uint)(num25 ^ 0x7BFB1AD9)) % 6)
											{
											case 0u:
												num25 = 492691059;
												continue;
											default:
												goto end_IL_1271;
											case 1u:
												current3.SkillVariables();
												num25 = (int)((num2 * 1056095235) ^ 0x444BA9F7);
												continue;
											case 5u:
												break;
											case 4u:
												current3 = enumerator2.Current;
												num25 = 703237637;
												continue;
											case 2u:
											{
												int num27;
												int num28;
												if (!current3.IsUsed)
												{
													num27 = 793808620;
													num28 = num27;
												}
												else
												{
													num27 = 99826832;
													num28 = num27;
												}
												num25 = num27 ^ ((int)num2 * -1004038712);
												continue;
											}
											case 3u:
												goto end_IL_1271;
											}
											goto IL_12b2;
											continue;
											end_IL_1271:
											break;
										}
										break;
									}
								}
								EquippedInternalSkill.SkillVariables();
								goto IL_131d;
							}
							IL_131d:
							return flag4;
						}
						break;
						IL_1216:
						int num42;
						if (Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2301880830u)] + GrowTemplate.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1368077529u)] >= num32)
						{
							num24 = 110407023;
							num42 = num24;
						}
						else
						{
							num24 = 1944102157;
							num42 = num24;
						}
						continue;
						IL_0b6a:
						int num43;
						if (Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1940200750u)] + GrowTemplate.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1029863417u)] >= num32)
						{
							num24 = 987010079;
							num43 = num24;
						}
						else
						{
							num24 = 619354875;
							num43 = num24;
						}
						continue;
						IL_0d14:
						int num44;
						if (Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3583101943u)] + GrowTemplate.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2575692001u)] < num32)
						{
							num24 = 1520904338;
							num44 = num24;
						}
						else
						{
							num24 = 2034592926;
							num44 = num24;
						}
						continue;
						IL_1134:
						int num45;
						if (Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2186305609u)] + GrowTemplate.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2741516750u)] < num32)
						{
							num24 = 1665876805;
							num45 = num24;
						}
						else
						{
							num24 = 1502616386;
							num45 = num24;
						}
						continue;
						IL_0835:
						int num46;
						if (Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(394181284u)] + GrowTemplate.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3535376985u)] >= num32)
						{
							num24 = 1216576156;
							num46 = num24;
						}
						else
						{
							num24 = 777639755;
							num46 = num24;
						}
						continue;
						IL_0aa0:
						int num47;
						if (Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(912726802u)] + GrowTemplate.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(400004197u)] >= num32)
						{
							num24 = 1504907623;
							num47 = num24;
						}
						else
						{
							num24 = 829231778;
							num47 = num24;
						}
						continue;
						IL_1062:
						int num48;
						if (Exp <= LevelupExp)
						{
							num24 = 572317338;
							num48 = num24;
						}
						else
						{
							num24 = 708598336;
							num48 = num24;
						}
						continue;
						IL_0c35:
						int num49;
						if (Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1412133437u)] + GrowTemplate.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(788062007u)] >= num32)
						{
							num24 = 882604840;
							num49 = num24;
						}
						else
						{
							num24 = 1091001678;
							num49 = num24;
						}
						continue;
						IL_0b23:
						int num50;
						if (Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4176639349u)] + GrowTemplate.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1977936243u)] < num32)
						{
							num24 = 14389264;
							num50 = num24;
						}
						else
						{
							num24 = 868468716;
							num50 = num24;
						}
						continue;
						IL_0dd3:
						int num51;
						if (Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2053407229u)] + GrowTemplate.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(424952987u)] >= num32)
						{
							num24 = 1758234745;
							num51 = num24;
						}
						else
						{
							num24 = 646986274;
							num51 = num24;
						}
						continue;
						IL_097d:
						Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(11946387u)] = _206D_200E_206D_202C_206A_206D_200F_200E_206A_206D_202A_202D_206D_200D_200F_200C_206C_206C_200B_206C_202A_206B_206A_202A_206E_200B_202B_200B_202D_202E_202A_206B_200E_202D_206F_206D_206F_206C_206B_200D_202E(0, num35 + addmaxmp);
						int num52;
						if (Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(655417903u)] + GrowTemplate.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(710450445u)] < num32)
						{
							num24 = 1944920550;
							num52 = num24;
						}
						else
						{
							num24 = 903907184;
							num52 = num24;
						}
					}
					goto IL_05aa;
					IL_02d2:
					num12 = 96825458;
					goto IL_02d7;
					IL_05aa:
					num24 = 527199848;
					goto IL_05af;
					IL_03a7:
					if (!itemSkill.IsInternal)
					{
						num12 = 1309980681;
						goto IL_02d7;
					}
					goto IL_0fb6;
				}
				break;
			}
		}
	}

	private double GetdefenceDescAttack()
	{
		double defanceValue = GetDefanceValue();
		Trigger current = default(Trigger);
		double num5 = default(double);
		while (true)
		{
			int num = 1232320288;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x44FB5589)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_002a;
				default:
				{
					IEnumerator<Trigger> enumerator = GetTriggers(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(624742663u)).GetEnumerator();
					try
					{
						while (true)
						{
							IL_0095:
							int num3;
							int num4;
							if (!_202A_206A_206F_206D_206E_206A_200E_202E_206A_200B_206E_200D_206A_200D_206E_202B_200E_206D_202C_200B_200F_206C_202C_206A_202C_206D_200C_206F_206D_200E_202A_206E_206B_200E_202E_206C_206F_200F_206B_200C_202E((IEnumerator)enumerator))
							{
								num3 = 536553984;
								num4 = num3;
							}
							else
							{
								num3 = 1306520997;
								num4 = num3;
							}
							while (true)
							{
								switch ((num2 = (uint)(num3 ^ 0x44FB5589)) % 5)
								{
								case 2u:
									num3 = 1306520997;
									continue;
								default:
									goto end_IL_0061;
								case 3u:
									current = enumerator.Current;
									num3 = 319579918;
									continue;
								case 1u:
									break;
								case 4u:
									num5 += double.Parse(current.Argvs[0]);
									num3 = (int)(num2 * 1848910093) ^ -13913909;
									continue;
								case 0u:
									goto end_IL_0061;
								}
								goto IL_0095;
								continue;
								end_IL_0061:
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
								IL_00d7:
								int num6 = 145045026;
								while (true)
								{
									switch ((num2 = (uint)(num6 ^ 0x44FB5589)) % 3)
									{
									case 0u:
										break;
									default:
										goto end_IL_00dc;
									case 2u:
										goto IL_00fa;
									case 1u:
										goto end_IL_00dc;
									}
									goto IL_00d7;
									IL_00fa:
									_202D_200E_200B_206B_200E_206D_200F_200C_202B_200F_202A_202A_206D_206D_206B_202B_202C_206D_206B_202D_202A_206A_202E_200B_202B_200C_202E_200D_206B_202C_202C_202E_206E_202C_202B_206D_202E_202C_200F_200E_202E((IDisposable)enumerator);
									num6 = ((int)num2 * -584281095) ^ 0x45BFEEE3;
									continue;
									end_IL_00dc:
									break;
								}
								break;
							}
						}
					}
					return AttackLogic.defenceDescAttack(defanceValue) + AttackLogic.defenceDescAttack2(num5);
				}
				}
				break;
				IL_002a:
				num5 = 0.0;
				num = (int)((num2 * 157273618) ^ 0x28B32EE6);
			}
		}
	}

	public double GetDefanceValue()
	{
		if (EquippedTitle == null)
		{
			goto IL_000b;
		}
		float num = EquippedTitle.Defence;
		goto IL_00ce;
		IL_00bc:
		num = 0f;
		goto IL_00ce;
		IL_000b:
		int num2 = 742013312;
		goto IL_0010;
		IL_0010:
		float num4 = default(float);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ 0x37AC1887)) % 7)
			{
			case 6u:
				break;
			case 3u:
				return 10.0 * ((double)AttributesFinal[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3583101943u)] + 600.0) * (1.0 + (double)(EquippedInternalSkill.Defence + num4) * 0.75);
			case 1u:
				goto IL_00a0;
			case 4u:
				goto IL_00bc;
			case 2u:
				return 150.0 + (10.0 + (double)AttributesFinal[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(701808387u)] / 50.0 + (double)AttributesFinal[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3051962998u)] / 25.0) * 5.0 * (double)(1f + (EquippedInternalSkill.Defence + num4) * 0.66f);
			case 0u:
			{
				int num5;
				int num6;
				if (CommonSettings.MOD_KEY() == 1)
				{
					num5 = -1646406751;
					num6 = num5;
				}
				else
				{
					num5 = -1579469676;
					num6 = num5;
				}
				num2 = num5 ^ ((int)num3 * -254136189);
				continue;
			}
			default:
				return 98.0 + (double)(RuntimeData.Instance.Round * 2) + (10.0 + (double)AttributesFinal[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1923523063u)] / 50.0 + (double)AttributesFinal[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2575692001u)] / 50.0) * 8.0 * (double)(1f + (EquippedInternalSkill.Defence + num4));
			}
			break;
			IL_00a0:
			int num7;
			if (CommonSettings.MOD_KEY() == 2)
			{
				num2 = 785995288;
				num7 = num2;
			}
			else
			{
				num2 = 822231406;
				num7 = num2;
			}
		}
		goto IL_000b;
		IL_00ce:
		num4 = num;
		num2 = 2089756461;
		goto IL_0010;
	}

	private double GetEquipmentDefencePercent(ref double subcriticalp)
	{
		double num = 0.0;
		IEnumerator<Trigger> enumerator = GetTriggers(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(862773248u)).GetEnumerator();
		try
		{
			Trigger current = default(Trigger);
			while (true)
			{
				IL_0081:
				int num2;
				int num3;
				if (_202A_206A_206F_206D_206E_206A_200E_202E_206A_200B_206E_200D_206A_200D_206E_202B_200E_206D_202C_200B_200F_206C_202C_206A_202C_206D_200C_206F_206D_200E_202A_206E_206B_200E_202E_206C_206F_200F_206B_200C_202E((IEnumerator)enumerator))
				{
					num2 = -969968420;
					num3 = num2;
				}
				else
				{
					num2 = -662145392;
					num3 = num2;
				}
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)(num2 ^ -8274108)) % 6)
					{
					case 0u:
						num2 = -969968420;
						continue;
					default:
						goto end_IL_0027;
					case 4u:
						current = enumerator.Current;
						num2 = -1996401875;
						continue;
					case 5u:
						num += double.Parse(current.Argvs[0]);
						num2 = ((int)num4 * -12477294) ^ 0x347949AF;
						continue;
					case 1u:
						break;
					case 3u:
						subcriticalp += double.Parse(current.Argvs[1]) / 100.0;
						num2 = (int)(num4 * 937244192) ^ -1648805793;
						continue;
					case 2u:
						goto end_IL_0027;
					}
					goto IL_0081;
					continue;
					end_IL_0027:
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
					IL_00d1:
					int num5 = -1034295026;
					while (true)
					{
						uint num4;
						switch ((num4 = (uint)(num5 ^ -8274108)) % 3)
						{
						case 0u:
							break;
						default:
							goto end_IL_00d6;
						case 2u:
							goto IL_00f3;
						case 1u:
							goto end_IL_00d6;
						}
						goto IL_00d1;
						IL_00f3:
						_202D_200E_200B_206B_200E_206D_200F_200C_202B_200F_202A_202A_206D_206D_206B_202B_202C_206D_206B_202D_202A_206A_202E_200B_202B_200C_202E_200D_206B_202C_202C_202E_206E_202C_202B_206D_202E_202C_200F_200E_202E((IDisposable)enumerator);
						num5 = ((int)num4 * -1636561349) ^ 0x4D6241D3;
						continue;
						end_IL_00d6:
						break;
					}
					break;
				}
			}
		}
		return AttackLogic.defenceDescAttack2(num);
	}

	public void SetRoleBattleValue()
	{
		SetRoleBattleTalent();
		Trigger current = default(Trigger);
		string current2 = default(string);
		string current3 = default(string);
		Trigger current4 = default(Trigger);
		string current6 = default(string);
		Trigger current7 = default(Trigger);
		string current12 = default(string);
		double num57 = default(double);
		double num63 = default(double);
		double num50 = default(double);
		double num49 = default(double);
		double num56 = default(double);
		double num64 = default(double);
		double num58 = default(double);
		double num45 = default(double);
		double num61 = default(double);
		double num48 = default(double);
		double num51 = default(double);
		double num41 = default(double);
		Trigger current13 = default(Trigger);
		string name = default(string);
		double num53 = default(double);
		while (true)
		{
			int num = -909544092;
			while (true)
			{
				float num3;
				double num11;
				int num20;
				int num21;
				uint num2;
				switch ((num2 = (uint)(num ^ -903138290)) % 7)
				{
				case 6u:
					break;
				case 3u:
					EquipmentDefencePercent = GetEquipmentDefencePercent(ref SubCriticalPercent);
					num = (int)((num2 * 434951470) ^ 0x6EC22645);
					continue;
				case 1u:
					CriticalpValue = (_202E_200E_200B_200E_206F_200D_206F_202E_200C_206F_202A_200D_202E_202D_206A_202C_206E_200B_206D_200B_202E_202D_206E_200F_206D_200D_200F_202E_206C_206B_206C_202E_206A_202A_206F_206F_200B_202C_202D_200F_202E(_202C_200C_202C_202A_206B_202E_206D_200B_200F_206F_200E_202D_200C_206C_202E_202D_202B_202B_202D_206B_202C_202E_202D_206C_202B_200D_200E_206E_200D_206D_206A_200B_206A_200D_202B_200B_200C_200D_200E_202A_202E((double)AttributesFinal[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1550623476u)], 31.0), 0.077) - 1.3) * (double)(1f + EquippedInternalSkill.Critical);
					num = ((int)num2 * -558004264) ^ 0x3EEFD482;
					continue;
				case 0u:
					EquipmentCriticalpValue = CriticalProbabilityAdd();
					SubCriticalPercent = 0.0;
					num = ((int)num2 * -1634079370) ^ -1321752172;
					continue;
				case 2u:
					DefanceValue = GetDefanceValue();
					num = ((int)num2 * -1859675352) ^ 0x33B3ABF;
					continue;
				case 4u:
					AoyiBaseProbability = AoyiLogic.GetAoyiBaseProbability(this);
					num = (int)((num2 * 1831486693) ^ 0x413F14E7);
					continue;
				default:
					{
						num3 = 0f;
						IEnumerator<Trigger> enumerator = GetTriggers(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4138249670u)).GetEnumerator();
						try
						{
							while (true)
							{
								IL_018d:
								int num4;
								int num5;
								if (!_202A_206A_206F_206D_206E_206A_200E_202E_206A_200B_206E_200D_206A_200D_206E_202B_200E_206D_202C_200B_200F_206C_202C_206A_202C_206D_200C_206F_206D_200E_202A_206E_206B_200E_202E_206C_206F_200F_206B_200C_202E((IEnumerator)enumerator))
								{
									num4 = -223477150;
									num5 = num4;
								}
								else
								{
									num4 = -1358826232;
									num5 = num4;
								}
								while (true)
								{
									switch ((num2 = (uint)(num4 ^ -903138290)) % 5)
									{
									case 0u:
										num4 = -1358826232;
										continue;
									default:
										goto end_IL_0157;
									case 2u:
										current = enumerator.Current;
										num4 = -915765572;
										continue;
									case 3u:
										break;
									case 4u:
										num3 += float.Parse(current.Argvs[0]) / 100f;
										num4 = (int)((num2 * 2004234034) ^ 0x58184A5);
										continue;
									case 1u:
										goto end_IL_0157;
									}
									goto IL_018d;
									continue;
									end_IL_0157:
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
									IL_01d8:
									int num6 = -2057365410;
									while (true)
									{
										switch ((num2 = (uint)(num6 ^ -903138290)) % 3)
										{
										case 0u:
											break;
										default:
											goto end_IL_01dd;
										case 1u:
											goto IL_01fb;
										case 2u:
											goto end_IL_01dd;
										}
										goto IL_01d8;
										IL_01fb:
										_202D_200E_200B_206B_200E_206D_200F_200C_202B_200F_202A_202A_206D_206D_206B_202B_202C_206D_206B_202D_202A_206A_202E_200B_202B_200C_202E_200D_206B_202C_202C_202E_206E_202C_202B_206D_202E_202C_200F_200E_202E((IDisposable)enumerator);
										num6 = ((int)num2 * -1798016008) ^ -2097223809;
										continue;
										end_IL_01dd:
										break;
									}
									break;
								}
							}
						}
						using (List<string>.Enumerator enumerator2 = EquippedInternalSkill.GetEQTriggers(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(691816430u)).GetEnumerator())
						{
							while (true)
							{
								IL_025c:
								int num7;
								int num8;
								if (!enumerator2.MoveNext())
								{
									num7 = -2022178993;
									num8 = num7;
								}
								else
								{
									num7 = -2081549453;
									num8 = num7;
								}
								while (true)
								{
									switch ((num2 = (uint)(num7 ^ -903138290)) % 5)
									{
									case 0u:
										num7 = -2081549453;
										continue;
									default:
										goto end_IL_0236;
									case 3u:
										break;
									case 1u:
										num3 += float.Parse(current2) / 100f;
										num7 = (int)((num2 * 1795339175) ^ 0x2BB2ED75);
										continue;
									case 4u:
										current2 = enumerator2.Current;
										num7 = -1637600790;
										continue;
									case 2u:
										goto end_IL_0236;
									}
									goto IL_025c;
									continue;
									end_IL_0236:
									break;
								}
								break;
							}
						}
						foreach (SkillInstance skill in Skills)
						{
							using List<string>.Enumerator enumerator2 = skill.GetEQTriggers(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3512237417u)).GetEnumerator();
							while (true)
							{
								IL_0342:
								int num9;
								int num10;
								if (!enumerator2.MoveNext())
								{
									num9 = -716798009;
									num10 = num9;
								}
								else
								{
									num9 = -1783348255;
									num10 = num9;
								}
								while (true)
								{
									switch ((num2 = (uint)(num9 ^ -903138290)) % 5)
									{
									case 4u:
										num9 = -1783348255;
										continue;
									default:
										goto end_IL_02ec;
									case 2u:
										current3 = enumerator2.Current;
										num9 = -1622949898;
										continue;
									case 1u:
										num3 += float.Parse(current3) / 100f;
										num9 = ((int)num2 * -987722827) ^ -1128162515;
										continue;
									case 3u:
										break;
									case 0u:
										goto end_IL_02ec;
									}
									goto IL_0342;
									continue;
									end_IL_02ec:
									break;
								}
								break;
							}
						}
						num11 = 0.9 + (double)AttributesFinal[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3058596364u)] * 0.13 / (double)BattleField.ROLE_MAX_ATTRIBUTE[this];
						if (num11 > 1.0)
						{
							while (true)
							{
								int num12 = -1251537005;
								while (true)
								{
									switch ((num2 = (uint)(num12 ^ -903138290)) % 3)
									{
									case 0u:
										break;
									case 2u:
										num11 = 1.0;
										num12 = ((int)num2 * -510635360) ^ 0x60BA0126;
										continue;
									default:
										goto end_IL_03cc;
									}
									break;
								}
								continue;
								end_IL_03cc:
								break;
							}
						}
						enumerator = GetTriggers(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(437031842u)).GetEnumerator();
						try
						{
							while (true)
							{
								IL_045d:
								int num13;
								int num14;
								if (!_202A_206A_206F_206D_206E_206A_200E_202E_206A_200B_206E_200D_206A_200D_206E_202B_200E_206D_202C_200B_200F_206C_202C_206A_202C_206D_200C_206F_206D_200E_202A_206E_206B_200E_202E_206C_206F_200F_206B_200C_202E((IEnumerator)enumerator))
								{
									num13 = -2010262064;
									num14 = num13;
								}
								else
								{
									num13 = -311922211;
									num14 = num13;
								}
								while (true)
								{
									switch ((num2 = (uint)(num13 ^ -903138290)) % 5)
									{
									case 0u:
										num13 = -311922211;
										continue;
									default:
										goto end_IL_0427;
									case 1u:
										current4 = enumerator.Current;
										num13 = -1036131455;
										continue;
									case 2u:
										break;
									case 3u:
										num11 += double.Parse(current4.Argvs[0]) / 100.0;
										num13 = ((int)num2 * -1013940080) ^ -2104558818;
										continue;
									case 4u:
										goto end_IL_0427;
									}
									goto IL_045d;
									continue;
									end_IL_0427:
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
									IL_04ac:
									int num15 = -1497432771;
									while (true)
									{
										switch ((num2 = (uint)(num15 ^ -903138290)) % 3)
										{
										case 0u:
											break;
										default:
											goto end_IL_04b1;
										case 2u:
											goto IL_04cf;
										case 1u:
											goto end_IL_04b1;
										}
										goto IL_04ac;
										IL_04cf:
										_202D_200E_200B_206B_200E_206D_200F_200C_202B_200F_202A_202A_206D_206D_206B_202B_202C_206D_206B_202D_202A_206A_202E_200B_202B_200C_202E_200D_206B_202C_202C_202E_206E_202C_202B_206D_202E_202C_200F_200E_202E((IDisposable)enumerator);
										num15 = (int)((num2 * 503697672) ^ 0x4CC01D34);
										continue;
										end_IL_04b1:
										break;
									}
									break;
								}
							}
						}
						using (List<string>.Enumerator enumerator2 = EquippedInternalSkill.GetEQTriggers(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2163509595u)).GetEnumerator())
						{
							while (true)
							{
								IL_0550:
								int num16;
								int num17;
								if (enumerator2.MoveNext())
								{
									num16 = -85206509;
									num17 = num16;
								}
								else
								{
									num16 = -1897404320;
									num17 = num16;
								}
								while (true)
								{
									switch ((num2 = (uint)(num16 ^ -903138290)) % 4)
									{
									case 3u:
										num16 = -85206509;
										continue;
									default:
										goto end_IL_050a;
									case 1u:
									{
										string current5 = enumerator2.Current;
										num11 += double.Parse(current5) / 100.0;
										num16 = -925350870;
										continue;
									}
									case 0u:
										break;
									case 2u:
										goto end_IL_050a;
									}
									goto IL_0550;
									continue;
									end_IL_050a:
									break;
								}
								break;
							}
						}
						foreach (SkillInstance skill2 in Skills)
						{
							using List<string>.Enumerator enumerator2 = skill2.GetEQTriggers(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3224158158u)).GetEnumerator();
							while (true)
							{
								IL_05e6:
								int num18;
								int num19;
								if (!enumerator2.MoveNext())
								{
									num18 = -956666268;
									num19 = num18;
								}
								else
								{
									num18 = -1439006615;
									num19 = num18;
								}
								while (true)
								{
									switch ((num2 = (uint)(num18 ^ -903138290)) % 5)
									{
									case 3u:
										num18 = -1439006615;
										continue;
									default:
										goto end_IL_05b0;
									case 1u:
										current6 = enumerator2.Current;
										num18 = -772543555;
										continue;
									case 4u:
										break;
									case 0u:
										num11 += double.Parse(current6) / 100.0;
										num18 = ((int)num2 * -1502720176) ^ 0x5AFBBF5B;
										continue;
									case 2u:
										goto end_IL_05b0;
									}
									goto IL_05e6;
									continue;
									end_IL_05b0:
									break;
								}
								break;
							}
						}
						if (num11 > 2.0)
						{
							goto IL_065c;
						}
						goto IL_06a1;
					}
					IL_06a1:
					if (num11 >= 0.01)
					{
						num20 = -1555528717;
						num21 = num20;
					}
					else
					{
						num20 = -760520498;
						num21 = num20;
					}
					goto IL_0661;
					IL_065c:
					num20 = -1263139488;
					goto IL_0661;
					IL_0661:
					while (true)
					{
						double num22;
						int num30;
						int num82;
						switch ((num2 = (uint)(num20 ^ -903138290)) % 5)
						{
						case 4u:
							break;
						case 2u:
							num11 = 2.0;
							num20 = (int)((num2 * 508738719) ^ 0x6E62F8A1);
							continue;
						case 1u:
							goto IL_06a1;
						case 3u:
							num11 = 0.01;
							num20 = (int)((num2 * 1203234385) ^ 0x42B7D333);
							continue;
						default:
							{
								num22 = 0.0;
								IEnumerator<Trigger> enumerator = GetTriggers(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3914770147u)).GetEnumerator();
								try
								{
									while (true)
									{
										IL_0736:
										int num23;
										int num24;
										if (!_202A_206A_206F_206D_206E_206A_200E_202E_206A_200B_206E_200D_206A_200D_206E_202B_200E_206D_202C_200B_200F_206C_202C_206A_202C_206D_200C_206F_206D_200E_202A_206E_206B_200E_202E_206C_206F_200F_206B_200C_202E((IEnumerator)enumerator))
										{
											num23 = -1013186327;
											num24 = num23;
										}
										else
										{
											num23 = -1371391786;
											num24 = num23;
										}
										while (true)
										{
											switch ((num2 = (uint)(num23 ^ -903138290)) % 5)
											{
											case 4u:
												num23 = -1371391786;
												continue;
											default:
												goto end_IL_0700;
											case 3u:
												current7 = enumerator.Current;
												num23 = -342380651;
												continue;
											case 2u:
												break;
											case 1u:
												num22 += double.Parse(current7.Argvs[0]) / 100.0;
												num23 = (int)(num2 * 1603619005) ^ -57077105;
												continue;
											case 0u:
												goto end_IL_0700;
											}
											goto IL_0736;
											continue;
											end_IL_0700:
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
											IL_0785:
											int num25 = -1610042532;
											while (true)
											{
												switch ((num2 = (uint)(num25 ^ -903138290)) % 3)
												{
												case 2u:
													break;
												default:
													goto end_IL_078a;
												case 1u:
													goto IL_07a8;
												case 0u:
													goto end_IL_078a;
												}
												goto IL_0785;
												IL_07a8:
												_202D_200E_200B_206B_200E_206D_200F_200C_202B_200F_202A_202A_206D_206D_206B_202B_202C_206D_206B_202D_202A_206A_202E_200B_202B_200C_202E_200D_206B_202C_202C_202E_206E_202C_202B_206D_202E_202C_200F_200E_202E((IDisposable)enumerator);
												num25 = (int)((num2 * 618217141) ^ 0xFD6F6EE);
												continue;
												end_IL_078a:
												break;
											}
											break;
										}
									}
								}
								using (List<string>.Enumerator enumerator2 = EquippedInternalSkill.GetEQTriggers(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1093039933u)).GetEnumerator())
								{
									while (true)
									{
										IL_0829:
										int num26;
										int num27;
										if (enumerator2.MoveNext())
										{
											num26 = -1027073689;
											num27 = num26;
										}
										else
										{
											num26 = -599347280;
											num27 = num26;
										}
										while (true)
										{
											switch ((num2 = (uint)(num26 ^ -903138290)) % 4)
											{
											case 3u:
												num26 = -1027073689;
												continue;
											default:
												goto end_IL_07e3;
											case 1u:
											{
												string current8 = enumerator2.Current;
												num22 += double.Parse(current8) / 100.0;
												num26 = -276685882;
												continue;
											}
											case 0u:
												break;
											case 2u:
												goto end_IL_07e3;
											}
											goto IL_0829;
											continue;
											end_IL_07e3:
											break;
										}
										break;
									}
								}
								foreach (SkillInstance skill3 in Skills)
								{
									using List<string>.Enumerator enumerator2 = skill3.GetEQTriggers(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1605191018u)).GetEnumerator();
									while (true)
									{
										IL_08cf:
										int num28;
										int num29;
										if (enumerator2.MoveNext())
										{
											num28 = -208243741;
											num29 = num28;
										}
										else
										{
											num28 = -417804064;
											num29 = num28;
										}
										while (true)
										{
											switch ((num2 = (uint)(num28 ^ -903138290)) % 4)
											{
											case 3u:
												num28 = -208243741;
												continue;
											default:
												goto end_IL_0889;
											case 1u:
											{
												string current9 = enumerator2.Current;
												num22 += double.Parse(current9) / 100.0;
												num28 = -1482477078;
												continue;
											}
											case 0u:
												break;
											case 2u:
												goto end_IL_0889;
											}
											goto IL_08cf;
											continue;
											end_IL_0889:
											break;
										}
										break;
									}
								}
								if (num22 > 0.9)
								{
									goto IL_0921;
								}
								goto IL_096e;
							}
							IL_0926:
							while (true)
							{
								switch ((num2 = (uint)(num30 ^ -903138290)) % 7)
								{
								case 4u:
									break;
								case 1u:
									num22 = 0.9;
									num30 = (int)((num2 * 247456605) ^ 0x4985E5E);
									continue;
								case 6u:
									goto IL_096e;
								case 5u:
									num30 = (int)((num2 * 1053112256) ^ 0x7D24DB1A);
									continue;
								case 2u:
									num22 = 0.001;
									num30 = ((int)num2 * -1180460449) ^ 0x5EA7E7DE;
									continue;
								case 3u:
									if (EquippedTitle != null)
									{
										num30 = -670367758;
										continue;
									}
									goto IL_0b96;
								default:
									{
										using (List<string>.Enumerator enumerator2 = EquippedTitle.GetEQTriggers(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(691816430u)).GetEnumerator())
										{
											while (true)
											{
												IL_0a32:
												int num31;
												int num32;
												if (enumerator2.MoveNext())
												{
													num31 = -1315867657;
													num32 = num31;
												}
												else
												{
													num31 = -2095920656;
													num32 = num31;
												}
												while (true)
												{
													switch ((num2 = (uint)(num31 ^ -903138290)) % 4)
													{
													case 3u:
														num31 = -1315867657;
														continue;
													default:
														goto end_IL_09f0;
													case 1u:
													{
														string current10 = enumerator2.Current;
														num3 += float.Parse(current10) / 100f;
														num31 = -1150516538;
														continue;
													}
													case 0u:
														break;
													case 2u:
														goto end_IL_09f0;
													}
													goto IL_0a32;
													continue;
													end_IL_09f0:
													break;
												}
												break;
											}
										}
										using (List<string>.Enumerator enumerator2 = EquippedTitle.GetEQTriggers(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3224158158u)).GetEnumerator())
										{
											while (true)
											{
												IL_0ac5:
												int num33;
												int num34;
												if (enumerator2.MoveNext())
												{
													num33 = -1601990308;
													num34 = num33;
												}
												else
												{
													num33 = -528292479;
													num34 = num33;
												}
												while (true)
												{
													switch ((num2 = (uint)(num33 ^ -903138290)) % 4)
													{
													case 0u:
														num33 = -1601990308;
														continue;
													default:
														goto end_IL_0a7f;
													case 2u:
													{
														string current11 = enumerator2.Current;
														num11 += double.Parse(current11) / 100.0;
														num33 = -276257553;
														continue;
													}
													case 1u:
														break;
													case 3u:
														goto end_IL_0a7f;
													}
													goto IL_0ac5;
													continue;
													end_IL_0a7f:
													break;
												}
												break;
											}
										}
										using (List<string>.Enumerator enumerator2 = EquippedTitle.GetEQTriggers(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(650078527u)).GetEnumerator())
										{
											while (true)
											{
												IL_0b48:
												int num35;
												int num36;
												if (!enumerator2.MoveNext())
												{
													num35 = -1262720686;
													num36 = num35;
												}
												else
												{
													num35 = -510384912;
													num36 = num35;
												}
												while (true)
												{
													switch ((num2 = (uint)(num35 ^ -903138290)) % 5)
													{
													case 3u:
														num35 = -510384912;
														continue;
													default:
														goto end_IL_0b12;
													case 4u:
														current12 = enumerator2.Current;
														num35 = -2002948675;
														continue;
													case 0u:
														break;
													case 1u:
														num22 += double.Parse(current12) / 100.0;
														num35 = ((int)num2 * -593410173) ^ 0x600C37DA;
														continue;
													case 2u:
														goto end_IL_0b12;
													}
													goto IL_0b48;
													continue;
													end_IL_0b12:
													break;
												}
												break;
											}
										}
										goto IL_0b96;
									}
									IL_0b96:
									xiValue = num3;
									mingzhongValue = num11;
									while (true)
									{
										int num37 = -1581414417;
										while (true)
										{
											switch ((num2 = (uint)(num37 ^ -903138290)) % 10)
											{
											case 9u:
												break;
											case 1u:
												anti_debuffValue = num22;
												num37 = (int)((num2 * 2130091356) ^ 0x30F3716C);
												continue;
											case 2u:
												num57 = 1.0;
												num37 = ((int)num2 * -340966977) ^ -1991263467;
												continue;
											case 6u:
												num63 = 0.0;
												num50 = 1.0;
												num49 = 1.0;
												num56 = 1.0;
												num37 = (int)(num2 * 69457065) ^ -1877494404;
												continue;
											case 5u:
												num64 = 1.0;
												num37 = (int)(num2 * 1989352950) ^ -1290316254;
												continue;
											case 0u:
												num58 = 0.5;
												num37 = (int)((num2 * 649304803) ^ 0xBDFB5F5);
												continue;
											case 3u:
												num45 = 0.5;
												num61 = 0.5;
												powerup_aoyi_Power = new Dictionary<string, double>();
												num37 = (int)((num2 * 296052016) ^ 0x742D2BB7);
												continue;
											case 4u:
												num48 = 1.5;
												num51 = 0.5;
												num37 = (int)(num2 * 1654636987) ^ -49552134;
												continue;
											case 7u:
												powerup_aoyi_probability = new Dictionary<string, double>();
												num37 = (int)(num2 * 151147868) ^ -584634476;
												continue;
											default:
											{
												IEnumerator<Trigger> enumerator = GetAllTriggers().GetEnumerator();
												try
												{
													while (true)
													{
														IL_125b:
														int num38;
														int num39;
														if (_202A_206A_206F_206D_206E_206A_200E_202E_206A_200B_206E_200D_206A_200D_206E_202B_200E_206D_202C_200B_200F_206C_202C_206A_202C_206D_200C_206F_206D_200E_202A_206E_206B_200E_202E_206C_206F_200F_206B_200C_202E((IEnumerator)enumerator))
														{
															num38 = -819397238;
															num39 = num38;
														}
														else
														{
															num38 = -1837922744;
															num39 = num38;
														}
														while (true)
														{
															switch ((num2 = (uint)(num38 ^ -903138290)) % 40)
															{
															case 16u:
																num38 = -819397238;
																continue;
															default:
																goto end_IL_0d25;
															case 4u:
																num41 += double.Parse(current13.Argvs[1]);
																num38 = (int)(num2 * 1054926476) ^ -1045315969;
																continue;
															case 2u:
																num63 += double.Parse(current13.Argvs[0]);
																num38 = ((int)num2 * -1841723885) ^ -1986958309;
																continue;
															case 20u:
																num61 += double.Parse(current13.Argvs[0]);
																num38 = (int)(num2 * 2078204033) ^ -1248793170;
																continue;
															case 10u:
																num49 += double.Parse(current13.Argvs[0]) / 100.0;
																num38 = ((int)num2 * -1948807822) ^ -2005329993;
																continue;
															case 0u:
																num48 += double.Parse(current13.Argvs[0]) / 100.0;
																num38 = ((int)num2 * -1140908103) ^ -1079312598;
																continue;
															case 24u:
																num45 += double.Parse(current13.Argvs[0]);
																num38 = (int)(num2 * 729767613) ^ -772861831;
																continue;
															case 37u:
															{
																int num66;
																if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(name, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(430049467u)))
																{
																	num38 = -626562990;
																	num66 = num38;
																}
																else
																{
																	num38 = -960239630;
																	num66 = num38;
																}
																continue;
															}
															case 30u:
																num53 = powerup_aoyi_probability[current13.Argvs[0]];
																num38 = ((int)num2 * -1095614018) ^ -433405642;
																continue;
															case 36u:
															{
																current13 = enumerator.Current;
																name = current13.Name;
																int num60;
																if (!_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(name, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4216920819u)))
																{
																	num38 = -1495649135;
																	num60 = num38;
																}
																else
																{
																	num38 = -1050015780;
																	num60 = num38;
																}
																continue;
															}
															case 21u:
																num56 += double.Parse(current13.Argvs[0]) / 100.0;
																num38 = ((int)num2 * -1104969164) ^ 0x1761FF96;
																continue;
															case 15u:
																num38 = ((int)num2 * -450863934) ^ -1096919316;
																continue;
															case 34u:
																num57 += double.Parse(current13.Argvs[0]) / 100.0;
																num38 = ((int)num2 * -1248497259) ^ 0x191886B3;
																continue;
															case 33u:
																num53 += double.Parse(current13.Argvs[2]);
																powerup_aoyi_Power[current13.Argvs[0]] = num41;
																powerup_aoyi_probability[current13.Argvs[0]] = num53;
																num38 = ((int)num2 * -262326022) ^ -1699302456;
																continue;
															case 5u:
																num38 = (int)(num2 * 2047997857) ^ -789388657;
																continue;
															case 3u:
															{
																int num46;
																if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(name, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(711496160u)))
																{
																	num38 = -2137328095;
																	num46 = num38;
																}
																else
																{
																	num38 = -1024705234;
																	num46 = num38;
																}
																continue;
															}
															case 27u:
															{
																int num43;
																if (!_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(name, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(560889304u)))
																{
																	num38 = -156269309;
																	num43 = num38;
																}
																else
																{
																	num38 = -1006701450;
																	num43 = num38;
																}
																continue;
															}
															case 6u:
																num38 = (int)(num2 * 1846568763) ^ -120932912;
																continue;
															case 19u:
															{
																int num65;
																if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(name, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3606122234u)))
																{
																	num38 = -1438834577;
																	num65 = num38;
																}
																else
																{
																	num38 = -324461726;
																	num65 = num38;
																}
																continue;
															}
															case 25u:
																num64 += double.Parse(current13.Argvs[0]) / 100.0;
																num38 = ((int)num2 * -692413845) ^ -1825228423;
																continue;
															case 23u:
															{
																int num62;
																if (!_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(name, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3608460132u)))
																{
																	num38 = -1409499485;
																	num62 = num38;
																}
																else
																{
																	num38 = -39048744;
																	num62 = num38;
																}
																continue;
															}
															case 17u:
															{
																int num59;
																if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(name, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1185199784u)))
																{
																	num38 = -252783840;
																	num59 = num38;
																}
																else
																{
																	num38 = -1825218107;
																	num59 = num38;
																}
																continue;
															}
															case 22u:
																num58 += double.Parse(current13.Argvs[0]);
																num38 = (int)((num2 * 2054995760) ^ 0x48143484);
																continue;
															case 39u:
																powerup_aoyi_probability.Add(current13.Argvs[0], double.Parse(current13.Argvs[2]));
																num38 = (int)(num2 * 716012479) ^ -654893394;
																continue;
															case 7u:
															{
																int num54;
																int num55;
																if (powerup_aoyi_Power.ContainsKey(current13.Argvs[0]))
																{
																	num54 = 701161446;
																	num55 = num54;
																}
																else
																{
																	num54 = 261622377;
																	num55 = num54;
																}
																num38 = num54 ^ ((int)num2 * -1545480421);
																continue;
															}
															case 9u:
															{
																int num52;
																if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(name, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(7860661u)))
																{
																	num38 = -1452075788;
																	num52 = num38;
																}
																else
																{
																	num38 = -146678099;
																	num52 = num38;
																}
																continue;
															}
															case 35u:
																num51 += double.Parse(current13.Argvs[0]);
																num38 = (int)(num2 * 669602433) ^ -442115199;
																continue;
															case 12u:
																break;
															case 38u:
																num50 += double.Parse(current13.Argvs[0]) / 100.0;
																num38 = ((int)num2 * -1017016593) ^ -1247186302;
																continue;
															case 31u:
																num38 = (int)(num2 * 63717335) ^ -955157733;
																continue;
															case 18u:
																num38 = (int)(num2 * 819734833) ^ -1119245320;
																continue;
															case 11u:
																num38 = ((int)num2 * -337806087) ^ -1246541671;
																continue;
															case 13u:
															{
																int num47;
																if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(name, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3282273608u)))
																{
																	num38 = -2145090420;
																	num47 = num38;
																}
																else
																{
																	num38 = -772446210;
																	num47 = num38;
																}
																continue;
															}
															case 29u:
																num41 = powerup_aoyi_Power[current13.Argvs[0]];
																num38 = (int)((num2 * 1910067496) ^ 0x5BBC2E48);
																continue;
															case 32u:
															{
																int num44;
																if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(name, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(94818519u)))
																{
																	num38 = -2145779021;
																	num44 = num38;
																}
																else
																{
																	num38 = -380326193;
																	num44 = num38;
																}
																continue;
															}
															case 8u:
															{
																int num42;
																if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(name, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1107588222u)))
																{
																	num38 = -671753987;
																	num42 = num38;
																}
																else
																{
																	num38 = -717748785;
																	num42 = num38;
																}
																continue;
															}
															case 1u:
																num38 = (int)(num2 * 929794406) ^ -941254908;
																continue;
															case 28u:
															{
																int num40;
																if (!_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(name, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3371489213u)))
																{
																	num38 = -312545843;
																	num40 = num38;
																}
																else
																{
																	num38 = -712446058;
																	num40 = num38;
																}
																continue;
															}
															case 26u:
																powerup_aoyi_Power.Add(current13.Argvs[0], double.Parse(current13.Argvs[1]));
																num38 = -532327799;
																continue;
															case 14u:
																goto end_IL_0d25;
															}
															goto IL_125b;
															continue;
															end_IL_0d25:
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
															IL_13fb:
															int num67 = -1673949392;
															while (true)
															{
																switch ((num2 = (uint)(num67 ^ -903138290)) % 3)
																{
																case 0u:
																	break;
																default:
																	goto end_IL_1400;
																case 2u:
																	goto IL_141e;
																case 1u:
																	goto end_IL_1400;
																}
																goto IL_13fb;
																IL_141e:
																_202D_200E_200B_206B_200E_206D_200F_200C_202B_200F_202A_202A_206D_206D_206B_202B_202C_206D_206B_202D_202A_206A_202E_200B_202B_200C_202E_200D_206B_202C_202C_202E_206E_202C_202B_206D_202E_202C_200F_200E_202E((IDisposable)enumerator);
																num67 = ((int)num2 * -1587273766) ^ 0x3DE835F4;
																continue;
																end_IL_1400:
																break;
															}
															break;
														}
													}
												}
												attackValue = num63;
												while (true)
												{
													int num68 = -1741032026;
													while (true)
													{
														switch ((num2 = (uint)(num68 ^ -903138290)) % 17)
														{
														case 8u:
															break;
														case 11u:
														{
															int num78;
															if (BuiltInTalents[201])
															{
																num68 = -1003220528;
																num78 = num68;
															}
															else
															{
																num68 = -2147052892;
																num78 = num68;
															}
															continue;
														}
														case 3u:
														{
															criticalValue = num48;
															int num80;
															int num81;
															if (CommonSettings.MOD_KEY() == 1)
															{
																num80 = 1775873178;
																num81 = num80;
															}
															else
															{
																num80 = 792580745;
																num81 = num80;
															}
															num68 = num80 ^ ((int)num2 * -1450310924);
															continue;
														}
														case 10u:
														{
															int num79;
															if (CriticalpValue > 1.0)
															{
																num68 = -983783461;
																num79 = num68;
															}
															else
															{
																num68 = -200530795;
																num79 = num68;
															}
															continue;
														}
														case 13u:
														{
															int num75;
															if (!BuiltInTalents[202])
															{
																num68 = -596831733;
																num75 = num68;
															}
															else
															{
																num68 = -772686243;
																num75 = num68;
															}
															continue;
														}
														case 9u:
															num68 = (int)((num2 * 166171964) ^ 0x68D5906B);
															continue;
														case 15u:
															num51 += 3.0;
															num68 = (int)(num2 * 1263288940) ^ -689545650;
															continue;
														case 16u:
															set_critical(ref CriticalpValue, ref criticalValue);
															num68 = -381667231;
															continue;
														case 4u:
															powerup_jianfaValue = num49;
															num68 = (int)(num2 * 147041439) ^ -1193087257;
															continue;
														case 7u:
															num51 += 1.0;
															num68 = (int)(num2 * 1099262215) ^ -1984315058;
															continue;
														case 14u:
															powerup_daofaValue = num56;
															powerup_qimenValue = num57;
															powerup_xianshuValue = num64;
															num68 = ((int)num2 * -1860282941) ^ -1962049955;
															continue;
														case 2u:
															powerup_quanzhangValue = num50;
															num68 = ((int)num2 * -602327510) ^ 0x7A70D4D0;
															continue;
														case 6u:
														{
															int num76;
															int num77;
															if (mingzhongValue >= 2.0)
															{
																num76 = -1016100316;
																num77 = num76;
															}
															else
															{
																num76 = -953239908;
																num77 = num76;
															}
															num68 = num76 ^ (int)(num2 * 1775198881);
															continue;
														}
														case 1u:
															CriticalpValue = 1.0;
															num68 = ((int)num2 * -2048762083) ^ -1082265932;
															continue;
														case 0u:
															addCdValue = _206D_200E_206D_202C_206A_206D_200F_200E_206A_206D_202A_202D_206D_200D_200F_200C_206C_206C_200B_206C_202A_206B_206A_202A_206E_200B_202B_200B_202D_202E_202A_206B_200E_202D_206F_206D_206F_206C_206B_200D_202E(0, (int)_200F_200D_202C_206D_200D_206F_202D_206E_200C_206C_206F_200D_200D_202C_200E_202E_202C_202C_206D_206C_206F_200E_206F_206B_206A_206F_206E_206F_200C_200C_206D_206D_202C_200D_200E_200C_200E_206D_200D_202A_202E(3.0, num51));
															addCdValue_Normal = _206D_200E_206D_202C_206A_206D_200F_200E_206A_206D_202A_202D_206D_200D_200F_200C_206C_206C_200B_206C_202A_206B_206A_202A_206E_200B_202B_200B_202D_202E_202A_206B_200E_202D_206F_206D_206F_206C_206B_200D_202E(0, (int)_200F_200D_202C_206D_200D_206F_202D_206E_200C_206C_206F_200D_200D_202C_200E_202E_202C_202C_206D_206C_206F_200E_206F_206B_206A_206F_206E_206F_200C_200C_206D_206D_202C_200D_200E_200C_200E_206D_200D_202A_202E(3.0, num58));
															addCdValue_Unique = _206D_200E_206D_202C_206A_206D_200F_200E_206A_206D_202A_202D_206D_200D_200F_200C_206C_206C_200B_206C_202A_206B_206A_202A_206E_200B_202B_200B_202D_202E_202A_206B_200E_202D_206F_206D_206F_206C_206B_200D_202E(0, (int)_200F_200D_202C_206D_200D_206F_202D_206E_200C_206C_206F_200D_200D_202C_200E_202E_202C_202C_206D_206C_206F_200E_206F_206B_206A_206F_206E_206F_200C_200C_206D_206D_202C_200D_200E_200C_200E_206D_200D_202A_202E(3.0, num45));
															addCdValue_Special = _206D_200E_206D_202C_206A_206D_200F_200E_206A_206D_202A_202D_206D_200D_200F_200C_206C_206C_200B_206C_202A_206B_206A_202A_206E_200B_202B_200B_202D_202E_202A_206B_200E_202D_206F_206D_206F_206C_206B_200D_202E(0, (int)_200F_200D_202C_206D_200D_206F_202D_206E_200C_206C_206F_200D_200D_202C_200E_202E_202C_202C_206D_206C_206F_200E_206F_206B_206A_206F_206E_206F_200C_200C_206D_206D_202C_200D_200E_200C_200E_206D_200D_202A_202E(3.0, num61));
															CurrentSkillAI = null;
															CurrentSkillAnqi = null;
															num68 = -528971096;
															continue;
														case 12u:
															mingzhongValue = 2.0;
															num68 = ((int)num2 * -604390864) ^ 0x4AC0D78;
															continue;
														default:
														{
															skilltarget_x = 0;
															skilltarget_y = 0;
															using (List<SkillInstance>.Enumerator enumerator3 = Skills.GetEnumerator())
															{
																while (true)
																{
																	IL_175e:
																	int num69;
																	int num70;
																	if (enumerator3.MoveNext())
																	{
																		num69 = -175108223;
																		num70 = num69;
																	}
																	else
																	{
																		num69 = -509088401;
																		num70 = num69;
																	}
																	while (true)
																	{
																		switch ((num2 = (uint)(num69 ^ -903138290)) % 4)
																		{
																		case 2u:
																			num69 = -175108223;
																			continue;
																		default:
																			goto end_IL_1729;
																		case 3u:
																			enumerator3.Current.SkillVariables();
																			num69 = -2107883094;
																			continue;
																		case 0u:
																			break;
																		case 1u:
																			goto end_IL_1729;
																		}
																		goto IL_175e;
																		continue;
																		end_IL_1729:
																		break;
																	}
																	break;
																}
															}
															using (List<InternalSkillInstance>.Enumerator enumerator4 = InternalSkills.GetEnumerator())
															{
																while (true)
																{
																	IL_17d1:
																	int num71;
																	int num72;
																	if (enumerator4.MoveNext())
																	{
																		num71 = -195099189;
																		num72 = num71;
																	}
																	else
																	{
																		num71 = -863642831;
																		num72 = num71;
																	}
																	while (true)
																	{
																		switch ((num2 = (uint)(num71 ^ -903138290)) % 4)
																		{
																		case 0u:
																			num71 = -195099189;
																			continue;
																		default:
																			goto end_IL_179c;
																		case 1u:
																			enumerator4.Current.SkillVariables();
																			num71 = -979528836;
																			continue;
																		case 2u:
																			break;
																		case 3u:
																			goto end_IL_179c;
																		}
																		goto IL_17d1;
																		continue;
																		end_IL_179c:
																		break;
																	}
																	break;
																}
															}
															using List<SpecialSkillInstance>.Enumerator enumerator5 = SpecialSkills.GetEnumerator();
															while (true)
															{
																int num73;
																int num74;
																if (enumerator5.MoveNext())
																{
																	num73 = -2143841489;
																	num74 = num73;
																}
																else
																{
																	num73 = -1530499724;
																	num74 = num73;
																}
																while (true)
																{
																	switch ((num2 = (uint)(num73 ^ -903138290)) % 4)
																	{
																	case 0u:
																		num73 = -2143841489;
																		continue;
																	default:
																		return;
																	case 1u:
																		enumerator5.Current.SkillVariables();
																		num73 = -1966349915;
																		continue;
																	case 3u:
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
													}
												}
											}
											}
											break;
										}
									}
								}
								break;
							}
							goto IL_0921;
							IL_0921:
							num30 = -622025081;
							goto IL_0926;
							IL_096e:
							if (num22 < 0.001)
							{
								num30 = -1740551054;
								num82 = num30;
							}
							else
							{
								num30 = -1437160998;
								num82 = num30;
							}
							goto IL_0926;
						}
						break;
					}
					goto IL_065c;
				}
				break;
			}
		}
	}

	private string GetAttributeHpString()
	{
		int num = Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(31734228u)];
		int num2 = GetAdditionAttribute(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(31734228u));
		int additionAttribute = GetAdditionAttribute(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2032836171u));
		while (true)
		{
			int num3 = 973773304;
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)(num3 ^ 0x2C39BF22)) % 4)
				{
				case 3u:
					break;
				case 2u:
				{
					int num5;
					int num6;
					if (additionAttribute != 0)
					{
						num5 = -5933115;
						num6 = num5;
					}
					else
					{
						num5 = -1746184180;
						num6 = num5;
					}
					num3 = num5 ^ (int)(num4 * 149981487);
					continue;
				}
				case 1u:
					num2 += (int)((double)num * ((double)additionAttribute / 100.0));
					num3 = (int)(num4 * 73307722) ^ -2100647168;
					continue;
				default:
					return _206C_206E_200B_206B_206B_202C_206F_206B_202A_200C_206E_206E_202A_202A_202A_206C_206D_206B_206C_206A_200B_206C_202A_202B_206D_206C_202D_202B_206B_206A_206A_202E_202A_206A_206E_206E_206E_200E_202E_206F_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2024378677u), (object)num, (object)num2);
				}
				break;
			}
		}
	}

	private string GetAttributeMpString()
	{
		int num = Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1306348308u)];
		int num4 = default(int);
		int additionAttribute = default(int);
		while (true)
		{
			int num2 = -9064951;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -553678732)) % 4)
				{
				case 2u:
					break;
				case 1u:
				{
					num4 = GetAdditionAttribute(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(475395429u));
					additionAttribute = GetAdditionAttribute(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1761699035u));
					int num5;
					int num6;
					if (additionAttribute != 0)
					{
						num5 = -2118754759;
						num6 = num5;
					}
					else
					{
						num5 = -825699266;
						num6 = num5;
					}
					num2 = num5 ^ ((int)num3 * -1804439250);
					continue;
				}
				case 3u:
					num4 += (int)((double)num * ((double)additionAttribute / 100.0));
					num2 = (int)((num3 * 583550784) ^ 0x142D6888);
					continue;
				default:
					return _206C_206E_200B_206B_206B_202C_206F_206B_202A_200C_206E_206E_202A_202A_202A_206C_206D_206B_206C_206A_200B_206C_202A_202B_206D_206C_202D_202B_206B_206A_206A_202E_202A_206A_206E_206E_206E_200E_202E_206F_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1140730343u), (object)num, (object)num4);
				}
				break;
			}
		}
	}

	public int GetSkillLevel(string skillname)
	{
		using (List<SkillInstance>.Enumerator enumerator = Skills.GetEnumerator())
		{
			SkillInstance current = default(SkillInstance);
			int result = default(int);
			while (true)
			{
				IL_0043:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 1953285558;
					num2 = num;
				}
				else
				{
					num = 1272594062;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x3FA0AE06)) % 7)
					{
					case 6u:
						num = 1272594062;
						continue;
					default:
						goto end_IL_0013;
					case 0u:
						break;
					case 1u:
						current = enumerator.Current;
						num = 1367779809;
						continue;
					case 4u:
					{
						int num4;
						int num5;
						if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(current.Skill.Name, skillname))
						{
							num4 = -874819213;
							num5 = num4;
						}
						else
						{
							num4 = -327233579;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -1700899193);
						continue;
					}
					case 3u:
						result = current.Level;
						num = ((int)num3 * -1184186198) ^ -851136793;
						continue;
					case 2u:
						goto end_IL_0013;
					case 5u:
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
		return -1;
	}

	public int GetInternalSkillLevel(string internalskillname)
	{
		using (List<InternalSkillInstance>.Enumerator enumerator = InternalSkills.GetEnumerator())
		{
			InternalSkillInstance current = default(InternalSkillInstance);
			int result = default(int);
			while (true)
			{
				IL_0060:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -709265979;
					num2 = num;
				}
				else
				{
					num = -1883815916;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -35046913)) % 7)
					{
					case 3u:
						num = -1883815916;
						continue;
					default:
						goto end_IL_0013;
					case 6u:
						current = enumerator.Current;
						num = -1048995525;
						continue;
					case 0u:
						break;
					case 1u:
					{
						int num4;
						int num5;
						if (!_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(current.Name, internalskillname))
						{
							num4 = 895393161;
							num5 = num4;
						}
						else
						{
							num4 = 173597302;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -804004394);
						continue;
					}
					case 5u:
						result = current.Level;
						num = ((int)num3 * -650468731) ^ -1981221443;
						continue;
					case 2u:
						goto end_IL_0013;
					case 4u:
						return result;
					}
					goto IL_0060;
					continue;
					end_IL_0013:
					break;
				}
				break;
			}
		}
		return -1;
	}

	private void set_critical(ref double criticalp, ref double critical)
	{
		if (CommonSettings.MOD_KEY() != 1)
		{
			return;
		}
		double num3 = default(double);
		while (true)
		{
			int num = -1092324304;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1204789285)) % 6)
				{
				case 5u:
					break;
				default:
					return;
				case 2u:
					critical += num3 / 800.0;
					num = -427339912;
					continue;
				case 4u:
					critical += 0.4;
					num = (int)(num2 * 2059903001) ^ -968491707;
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (!HasTalent(ResourceStrings.ResStrings[1239]))
					{
						num4 = 736684365;
						num5 = num4;
					}
					else
					{
						num4 = 811896835;
						num5 = num4;
					}
					num = num4 ^ ((int)num2 * -208148863);
					continue;
				}
				case 1u:
					num3 = GetMaxSkillTypeValue();
					criticalp = num3 / 1000.0 * (double)(1f + EquippedInternalSkill.Critical);
					num = (int)(num2 * 877485541) ^ -2057866618;
					continue;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public void SetRoleBattleTalent()
	{
		BuiltInTalents = new List<bool>();
		while (true)
		{
			int num = -1574780060;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1023058789)) % 136)
				{
				case 110u:
					break;
				default:
					return;
				case 71u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[307]));
					num = (int)(num2 * 978793391) ^ -1927334492;
					continue;
				case 13u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[240]));
					num = (int)(num2 * 529912231) ^ -712978662;
					continue;
				case 58u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[278]));
					num = (int)(num2 * 645445397) ^ -1439046153;
					continue;
				case 121u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[201]));
					num = ((int)num2 * -2137098069) ^ -1113269201;
					continue;
				case 43u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[289]));
					num = (int)((num2 * 670384208) ^ 0x19BB00DF);
					continue;
				case 42u:
					BuiltInTalents.Add(HasRoleTalent(ResourceStrings.ResStrings[265]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[266]));
					BuiltInTalents.Add(HasRoleTalent(ResourceStrings.ResStrings[267]));
					num = (int)(num2 * 1649337639) ^ -191121588;
					continue;
				case 87u:
					BuiltInTalents.Add(item: false);
					num = (int)(num2 * 1153677136) ^ -66795719;
					continue;
				case 64u:
				{
					int num5;
					int num6;
					if (CommonSettings.MOD_KEY() == 1)
					{
						num5 = 1433646760;
						num6 = num5;
					}
					else
					{
						num5 = 1058439450;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1619272474);
					continue;
				}
				case 60u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[215]));
					BuiltInTalents.Add(HasRoleTalent(ResourceStrings.ResStrings[216]));
					BuiltInTalents.Add(HasRoleTalent(ResourceStrings.ResStrings[217]));
					BuiltInTalents.Add(HasRoleTalent(ResourceStrings.ResStrings[218]));
					num = (int)(num2 * 622097289) ^ -1210030256;
					continue;
				case 50u:
					BuiltInTalents.Add(item: false);
					num = ((int)num2 * -1978821283) ^ 0x3D87336E;
					continue;
				case 131u:
					BuiltInTalents.Add(item: false);
					num = ((int)num2 * -1926795819) ^ -333697891;
					continue;
				case 73u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[302]));
					num = ((int)num2 * -398147769) ^ -179886647;
					continue;
				case 134u:
					BuiltInTalents.Add(item: false);
					num = (int)(num2 * 1770485140) ^ -1084165379;
					continue;
				case 74u:
					BuiltInTalents.Add(item: false);
					BuiltInTalents.Add(item: false);
					num = (int)((num2 * 1527067744) ^ 0x27149EE5);
					continue;
				case 16u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[263]));
					num = ((int)num2 * -1609805146) ^ 0x7C8B7C61;
					continue;
				case 63u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[258]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[259]));
					num = ((int)num2 * -1827379292) ^ -1675769016;
					continue;
				case 80u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[165]));
					num = ((int)num2 * -579227028) ^ -1666847721;
					continue;
				case 119u:
					BuiltInTalents.Add(item: false);
					BuiltInTalents.Add(item: false);
					num = (int)(num2 * 176797517) ^ -537953827;
					continue;
				case 19u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[1213]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[1214]));
					num = (int)(num2 * 1514860334) ^ -823726768;
					continue;
				case 48u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[182]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[183]));
					num = ((int)num2 * -28407810) ^ -1904462242;
					continue;
				case 100u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[496]));
					num = (int)((num2 * 352453257) ^ 0x5472EACE);
					continue;
				case 23u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[161]));
					num = (int)(num2 * 2116241903) ^ -771767052;
					continue;
				case 46u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[272]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[273]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[274]));
					num = ((int)num2 * -444291438) ^ 0x6A70442;
					continue;
				case 125u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[212]));
					num = ((int)num2 * -1365752649) ^ 0x293C7945;
					continue;
				case 90u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[241]));
					num = (int)((num2 * 369846903) ^ 0x538BB6A5);
					continue;
				case 0u:
					BuiltInTalents.Add(item: false);
					num = ((int)num2 * -2127873903) ^ -608818803;
					continue;
				case 61u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[199]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[200]));
					num = (int)((num2 * 2039180737) ^ 0x54838637);
					continue;
				case 9u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[167]));
					num = (int)((num2 * 362164921) ^ 0x464845DB);
					continue;
				case 56u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[174]));
					num = (int)(num2 * 2058793732) ^ -1405823289;
					continue;
				case 72u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[253]));
					num = ((int)num2 * -1122614382) ^ -637334626;
					continue;
				case 104u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[242]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[243]));
					num = (int)((num2 * 1988153238) ^ 0x4FDC7B94);
					continue;
				case 123u:
					BuiltInTalents.Add(HasRoleTalent(ResourceStrings.ResStrings[191]));
					num = ((int)num2 * -234610826) ^ 0x7B8DA3D8;
					continue;
				case 84u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[314]));
					num = (int)((num2 * 375831264) ^ 0x40C4961F);
					continue;
				case 55u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[198]));
					num = ((int)num2 * -2074285854) ^ 0x7673FEB0;
					continue;
				case 32u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[160]));
					num = ((int)num2 * -1888262826) ^ 0xD08C6AF;
					continue;
				case 98u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[210]));
					num = (int)((num2 * 1677177819) ^ 0x35578EC6);
					continue;
				case 95u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[260]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[261]));
					num = ((int)num2 * -1768524818) ^ -265941854;
					continue;
				case 91u:
					BuiltInTalents.Add(HasRoleTalent(ResourceStrings.ResStrings[179]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[180]));
					num = (int)(num2 * 876889688) ^ -1803481232;
					continue;
				case 127u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[244]));
					num = (int)((num2 * 1000193537) ^ 0x6449F45F);
					continue;
				case 102u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[188]));
					num = (int)(num2 * 1560585937) ^ -166336718;
					continue;
				case 130u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[264]));
					num = (int)(num2 * 1589258340) ^ -1271595447;
					continue;
				case 22u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[1292]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[1293]));
					num = (int)((num2 * 1781071659) ^ 0x1EEF3E63);
					continue;
				case 86u:
					BuiltInTalents.Add(item: false);
					num = (int)((num2 * 1810012598) ^ 0x7A8E64C3);
					continue;
				case 62u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[308]));
					num = ((int)num2 * -1274559698) ^ 0x122FD361;
					continue;
				case 28u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[175]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[176]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[177]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[178]));
					num = (int)(num2 * 22312955) ^ -713806044;
					continue;
				case 103u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[202]));
					num = ((int)num2 * -94284915) ^ -200889330;
					continue;
				case 69u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[286]));
					num = ((int)num2 * -1098752546) ^ -1269866785;
					continue;
				case 108u:
					BuiltInTalents.Add(HasRoleTalent(ResourceStrings.ResStrings[301]));
					num = ((int)num2 * -1821493747) ^ 0x600913EB;
					continue;
				case 44u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[169]));
					num = ((int)num2 * -1123332417) ^ 0x3E04FAF7;
					continue;
				case 65u:
					BuiltInTalents.Add(item: false);
					BuiltInTalents.Add(item: false);
					BuiltInTalents.Add(item: false);
					num = ((int)num2 * -1785748196) ^ 0x145939F4;
					continue;
				case 57u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[195]));
					num = ((int)num2 * -1191937007) ^ -2063019571;
					continue;
				case 25u:
				{
					int num3;
					int num4;
					if (CommonSettings.MOD_KEY() >= 0)
					{
						num3 = -130182734;
						num4 = num3;
					}
					else
					{
						num3 = -543180642;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1830462730);
					continue;
				}
				case 52u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[236]));
					num = ((int)num2 * -1216424285) ^ 0x1B52B0BD;
					continue;
				case 126u:
					BuiltInTalents.Add(HasRoleTalent(ResourceStrings.ResStrings[249]));
					num = ((int)num2 * -2117067143) ^ 0x1F1C9DBD;
					continue;
				case 118u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[162]));
					num = ((int)num2 * -428629520) ^ -713235617;
					continue;
				case 133u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[220]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[221]));
					num = ((int)num2 * -32038622) ^ 0x2723EE27;
					continue;
				case 76u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[284]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[285]));
					num = (int)(num2 * 432114651) ^ -1629310758;
					continue;
				case 78u:
					BuiltInTalents.Add(item: false);
					BuiltInTalents.Add(item: false);
					num = (int)((num2 * 1458436671) ^ 0x702D2FF9);
					continue;
				case 10u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[237]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[238]));
					num = (int)((num2 * 615312482) ^ 0x39FD3A1D);
					continue;
				case 88u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[208]));
					num = ((int)num2 * -302462093) ^ -605731185;
					continue;
				case 41u:
					BuiltInTalents.Add(HasRoleTalent(ResourceStrings.ResStrings[268]));
					BuiltInTalents.Add(HasRoleTalent(ResourceStrings.ResStrings[269]));
					num = ((int)num2 * -236539611) ^ -337962229;
					continue;
				case 106u:
					BuiltInTalents.Add(item: false);
					BuiltInTalents.Add(item: false);
					BuiltInTalents.Add(item: false);
					num = ((int)num2 * -2019628148) ^ 0x6C8C3621;
					continue;
				case 45u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[194]));
					num = ((int)num2 * -1219004579) ^ 0x7AE32C73;
					continue;
				case 21u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[254]));
					num = (int)(num2 * 1270057075) ^ -1264359531;
					continue;
				case 37u:
					BuiltInTalents.Add(item: false);
					num = (int)((num2 * 700631970) ^ 0x3D08009F);
					continue;
				case 36u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[166]));
					num = ((int)num2 * -576908952) ^ 0x36C06892;
					continue;
				case 53u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[213]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[214]));
					num = ((int)num2 * -582153055) ^ -943895974;
					continue;
				case 47u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[225]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[226]));
					num = (int)(num2 * 395531116) ^ -148647145;
					continue;
				case 67u:
					BuiltInTalents.Add(item: false);
					BuiltInTalents.Add(item: false);
					BuiltInTalents.Add(item: false);
					num = (int)(num2 * 1155418766) ^ -70494620;
					continue;
				case 105u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[185]));
					num = ((int)num2 * -862436474) ^ -1569286186;
					continue;
				case 59u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[186]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[187]));
					num = ((int)num2 * -1894707230) ^ 0x732E3A03;
					continue;
				case 5u:
					BuiltInTalents.Add(item: false);
					num = ((int)num2 * -1600248402) ^ -1360537739;
					continue;
				case 39u:
					BuiltInTalents.Add(item: false);
					num = ((int)num2 * -1960430614) ^ 0x196CBECA;
					continue;
				case 54u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[203]));
					num = ((int)num2 * -1855766085) ^ 0x26443B44;
					continue;
				case 14u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[304]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[305]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[306]));
					num = ((int)num2 * -2114176767) ^ 0x71F87DF2;
					continue;
				case 26u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[287]));
					num = (int)(num2 * 840446833) ^ -1835480502;
					continue;
				case 77u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[283]));
					num = (int)(num2 * 1423685337) ^ -1831030198;
					continue;
				case 51u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[197]));
					num = ((int)num2 * -1082439951) ^ -342400473;
					continue;
				case 3u:
					BuiltInTalents.Add(item: false);
					BuiltInTalents.Add(item: false);
					BuiltInTalents.Add(item: false);
					num = ((int)num2 * -2111810228) ^ 0x79E92FEE;
					continue;
				case 66u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[295]));
					num = ((int)num2 * -1168990101) ^ -1829536575;
					continue;
				case 128u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[227]));
					num = ((int)num2 * -540833473) ^ -1139253445;
					continue;
				case 7u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[196]));
					num = (int)(num2 * 1802732146) ^ -1440661706;
					continue;
				case 107u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[245]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[246]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[247]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[248]));
					num = ((int)num2 * -1839517313) ^ -714600288;
					continue;
				case 31u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[257]));
					num = (int)((num2 * 685286632) ^ 0x308BF29C);
					continue;
				case 6u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[279]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[280]));
					BuiltInTalents.Add(HasRoleTalent(ResourceStrings.ResStrings[281]));
					num = (int)(num2 * 1824177574) ^ -1277118987;
					continue;
				case 115u:
					BuiltInTalents.Add(item: false);
					num = ((int)num2 * -570455410) ^ -393550128;
					continue;
				case 20u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[290]));
					num = (int)(num2 * 211669953) ^ -1203895135;
					continue;
				case 112u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[1245]));
					num = (int)((num2 * 2094183378) ^ 0x43CAFB4A);
					continue;
				case 120u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[231]));
					BuiltInTalents.Add(HasRoleTalent(ResourceStrings.ResStrings[232]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[233]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[234]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[235]));
					num = ((int)num2 * -790449228) ^ 0x1CA4E287;
					continue;
				case 49u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[255]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[256]));
					num = (int)((num2 * 1040855349) ^ 0x3F397551);
					continue;
				case 30u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[291]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[292]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[293]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[294]));
					num = (int)((num2 * 1736690349) ^ 0x5531F827);
					continue;
				case 18u:
					BuiltInTalents.Add(item: false);
					num = ((int)num2 * -1309740198) ^ 0x7C356864;
					continue;
				case 4u:
					BuiltInTalents.Add(item: false);
					num = (int)(num2 * 713008227) ^ -60472860;
					continue;
				case 94u:
					BuiltInTalents.Add(item: false);
					num = (int)(num2 * 911647232) ^ -642455921;
					continue;
				case 34u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[230]));
					num = ((int)num2 * -191270079) ^ -83675183;
					continue;
				case 89u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[192]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[193]));
					num = (int)((num2 * 961665234) ^ 0x1C487414);
					continue;
				case 24u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[250]));
					BuiltInTalents.Add(HasRoleTalent(ResourceStrings.ResStrings[251]));
					BuiltInTalents.Add(HasRoleTalent(ResourceStrings.ResStrings[252]));
					num = ((int)num2 * -604935184) ^ -1957497397;
					continue;
				case 33u:
					ModTalents = new List<bool>();
					num = -1295652504;
					continue;
				case 114u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[190]));
					num = (int)((num2 * 1192349710) ^ 0x5D6FB6AC);
					continue;
				case 17u:
					BuiltInTalents.Add(HasRoleTalent(ResourceStrings.ResStrings[299]));
					BuiltInTalents.Add(HasRoleTalent(ResourceStrings.ResStrings[300]));
					num = (int)(num2 * 1390635138) ^ -281401283;
					continue;
				case 1u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[297]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[298]));
					num = (int)(num2 * 292212605) ^ -63927889;
					continue;
				case 35u:
					BuiltInTalents.Add(HasEquipmentTalent(ResourceStrings.ResStrings[181]));
					num = ((int)num2 * -551347506) ^ 0x55B90CF1;
					continue;
				case 97u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[1247]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[1248]));
					num = (int)(num2 * 378712866) ^ -613570719;
					continue;
				case 113u:
					BuiltInTalents.Add(item: false);
					num = ((int)num2 * -1132898443) ^ 0x24540012;
					continue;
				case 122u:
					BuiltInTalents.Add(HasRoleTalent(ResourceStrings.ResStrings[1294]));
					num = (int)((num2 * 467733762) ^ 0x2A58B55F);
					continue;
				case 79u:
					BuiltInTalents.Add(item: false);
					BuiltInTalents.Add(item: false);
					BuiltInTalents.Add(item: false);
					BuiltInTalents.Add(item: false);
					num = ((int)num2 * -1418213917) ^ 0xB739CD;
					continue;
				case 93u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[270]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[271]));
					num = (int)((num2 * 653654523) ^ 0x1AA2308A);
					continue;
				case 124u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[315]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[316]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[317]));
					num = ((int)num2 * -360172767) ^ -1510137882;
					continue;
				case 96u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[228]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[229]));
					num = (int)((num2 * 1389996180) ^ 0x31DFA551);
					continue;
				case 111u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[189]));
					num = ((int)num2 * -2017448772) ^ 0x12BDEA6D;
					continue;
				case 81u:
					BuiltInTalents.Add(item: false);
					BuiltInTalents.Add(item: false);
					BuiltInTalents.Add(item: false);
					BuiltInTalents.Add(item: false);
					BuiltInTalents.Add(item: false);
					num = (int)(num2 * 2084643925) ^ -1288162320;
					continue;
				case 85u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[303]));
					num = (int)((num2 * 3929381) ^ 0x498E2AA4);
					continue;
				case 99u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[262]));
					num = (int)((num2 * 186563299) ^ 0x7BB2A7A);
					continue;
				case 2u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[282]));
					num = ((int)num2 * -17021883) ^ 0x10BFA864;
					continue;
				case 68u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[209]));
					num = ((int)num2 * -557120890) ^ -14386183;
					continue;
				case 135u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[277]));
					num = ((int)num2 * -1415089542) ^ -145351113;
					continue;
				case 40u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[170]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[171]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[172]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[173]));
					num = ((int)num2 * -697812248) ^ -748918677;
					continue;
				case 109u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[276]));
					num = ((int)num2 * -1924960150) ^ -39970778;
					continue;
				case 75u:
					BuiltInTalents.Add(HasRoleTalent(ResourceStrings.ResStrings[205]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[206]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[207]));
					num = ((int)num2 * -1936684108) ^ 0x34097867;
					continue;
				case 116u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[296]));
					num = ((int)num2 * -639362184) ^ -1358784798;
					continue;
				case 27u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[288]));
					num = (int)(num2 * 467961587) ^ -827665927;
					continue;
				case 101u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[204]));
					num = (int)((num2 * 1376079275) ^ 0x76E73097);
					continue;
				case 11u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[211]));
					num = ((int)num2 * -1609027334) ^ -917612592;
					continue;
				case 132u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[163]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[164]));
					num = ((int)num2 * -1058606181) ^ -927043057;
					continue;
				case 15u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[219]));
					num = ((int)num2 * -1894997368) ^ -1880685154;
					continue;
				case 117u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[275]));
					num = (int)((num2 * 1175386631) ^ 0x7343D5CD);
					continue;
				case 38u:
					BuiltInTalents.Add(item: false);
					num = (int)((num2 * 1167530294) ^ 0x3710C435);
					continue;
				case 8u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[1249]));
					num = ((int)num2 * -654658954) ^ 0x11EC2C83;
					continue;
				case 129u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[168]));
					num = ((int)num2 * -169980944) ^ 0x3C95A5BF;
					continue;
				case 12u:
					BuiltInTalents.Add(item: false);
					num = (int)(num2 * 1951774490) ^ -1088497975;
					continue;
				case 92u:
					BuiltInTalents.Add(item: false);
					num = ((int)num2 * -2029834942) ^ 0x4910F0AC;
					continue;
				case 29u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[184]));
					num = ((int)num2 * -1947179015) ^ 0x34D01BFF;
					continue;
				case 70u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[222]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[223]));
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[224]));
					num = (int)((num2 * 1698717507) ^ 0x163D9146);
					continue;
				case 82u:
					BuiltInTalents.Add(HasTalent(ResourceStrings.ResStrings[239]));
					num = ((int)num2 * -1927628949) ^ -1566914056;
					continue;
				case 83u:
					return;
				}
				break;
			}
		}
	}

	public double Get_powerup_aoyi(string name, bool getpower)
	{
		if (getpower)
		{
			goto IL_0003;
		}
		goto IL_0034;
		IL_0003:
		int num = 1594002945;
		goto IL_0008;
		IL_0008:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0xC352B62)) % 6)
			{
			case 0u:
				break;
			case 2u:
				goto IL_0034;
			case 4u:
				return powerup_aoyi_Power[name];
			case 5u:
				return powerup_aoyi_probability[name];
			case 3u:
			{
				int num3;
				int num4;
				if (!powerup_aoyi_Power.ContainsKey(name))
				{
					num3 = -1695297068;
					num4 = num3;
				}
				else
				{
					num3 = -316260523;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 641030349);
				continue;
			}
			default:
				return 0.0;
			}
			break;
		}
		goto IL_0003;
		IL_0034:
		int num5;
		if (powerup_aoyi_probability.ContainsKey(name))
		{
			num = 1570736067;
			num5 = num;
		}
		else
		{
			num = 689678739;
			num5 = num;
		}
		goto IL_0008;
	}

	public void Clear_powerup_aoyi()
	{
		powerup_aoyi_Power = null;
		while (true)
		{
			int num = -55776682;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -442721318)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0029;
				case 1u:
					return;
				}
				break;
				IL_0029:
				powerup_aoyi_probability = null;
				num = (int)((num2 * 1196033690) ^ 0x2C31D74B);
			}
		}
	}

	internal void SetLevel(int level)
	{
		_202B_202C_202C_200B_206B_200B_206D_206A_206B_200D_200D_200F_206E_200F_202D_206D_202E_200C_206F_206B_200E_206C_206B_200D_202C_206D_206A_206C_202B_200E_202B_200B_206F_206E_206F_202D_206A_206E_206D_206F_202E = _206D_200E_206D_202C_206A_206D_200F_200E_206A_206D_202A_202D_206D_200D_200F_200C_206C_206C_200B_206C_202A_206B_206A_202A_206E_200B_202B_200B_202D_202E_202A_206B_200E_202D_206F_206D_206F_206C_206B_200D_202E(1, level);
	}

	public TitleInstance GetEquippedTitle()
	{
		TitleInstance titleInstance = null;
		using (List<TitleInstance>.Enumerator enumerator = Titles.GetEnumerator())
		{
			TitleInstance current = default(TitleInstance);
			while (true)
			{
				IL_0043:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 454092602;
					num2 = num;
				}
				else
				{
					num = 201901930;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x25C434EC)) % 7)
					{
					case 5u:
						num = 201901930;
						continue;
					default:
						goto end_IL_0015;
					case 2u:
						break;
					case 3u:
					{
						int num4;
						int num5;
						if (current.IsUsed)
						{
							num4 = -3304265;
							num5 = num4;
						}
						else
						{
							num4 = -1675426131;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -677946623);
						continue;
					}
					case 6u:
						goto end_IL_0015;
					case 0u:
						titleInstance = current;
						num = ((int)num3 * -548944885) ^ -1013822214;
						continue;
					case 1u:
						current = enumerator.Current;
						num = 1351025490;
						continue;
					case 4u:
						goto end_IL_0015;
					}
					goto IL_0043;
					continue;
					end_IL_0015:
					break;
				}
				break;
			}
		}
		if (titleInstance != null)
		{
			using List<TitleInstance>.Enumerator enumerator = Titles.GetEnumerator();
			TitleInstance current2 = default(TitleInstance);
			while (true)
			{
				IL_0124:
				int num6;
				int num7;
				if (enumerator.MoveNext())
				{
					num6 = 1336748573;
					num7 = num6;
				}
				else
				{
					num6 = 397832458;
					num7 = num6;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num6 ^ 0x25C434EC)) % 5)
					{
					case 0u:
						num6 = 1336748573;
						continue;
					default:
						goto end_IL_00e1;
					case 2u:
					{
						current2 = enumerator.Current;
						int num8;
						if (current2 == titleInstance)
						{
							num6 = 1274124915;
							num8 = num6;
						}
						else
						{
							num6 = 155252393;
							num8 = num6;
						}
						continue;
					}
					case 1u:
						break;
					case 4u:
						current2.equipped = 0;
						num6 = (int)((num3 * 971606687) ^ 0x2F0B40A8);
						continue;
					case 3u:
						goto end_IL_00e1;
					}
					goto IL_0124;
					continue;
					end_IL_00e1:
					break;
				}
				break;
			}
		}
		return titleInstance;
	}

	public void SetEquippedTitle(TitleInstance title)
	{
		using (List<TitleInstance>.Enumerator enumerator = Titles.GetEnumerator())
		{
			while (true)
			{
				IL_0048:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -1060796486;
					num2 = num;
				}
				else
				{
					num = -507665037;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -1013802041)) % 4)
					{
					case 3u:
						num = -1060796486;
						continue;
					default:
						goto end_IL_0013;
					case 1u:
						enumerator.Current.equipped = 0;
						num = -1671574255;
						continue;
					case 2u:
						break;
					case 0u:
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
		if (title != null)
		{
			goto IL_0075;
		}
		goto IL_00b9;
		IL_00b9:
		EquippedTitle = null;
		int num4 = -10054841;
		goto IL_007a;
		IL_0075:
		num4 = -271851188;
		goto IL_007a;
		IL_007a:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num4 ^ -1013802041)) % 6)
			{
			case 4u:
				break;
			default:
				return;
			case 1u:
				title.equipped = 1;
				num4 = (int)(num3 * 559736869) ^ -237982780;
				continue;
			case 3u:
				goto IL_00b9;
			case 0u:
				EquippedTitle = title;
				num4 = ((int)num3 * -1838611176) ^ -1639620144;
				continue;
			case 5u:
				return;
			case 2u:
				return;
			}
			break;
		}
		goto IL_0075;
	}

	public bool HasTitle(string name)
	{
		using (List<TitleInstance>.Enumerator enumerator = Titles.GetEnumerator())
		{
			bool result = default(bool);
			while (true)
			{
				IL_0083:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -712339147;
					num2 = num;
				}
				else
				{
					num = -509278243;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -658585848)) % 6)
					{
					case 2u:
						num = -712339147;
						continue;
					default:
						goto end_IL_0013;
					case 5u:
					{
						int num4;
						if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(enumerator.Current.Name, name))
						{
							num = -580132494;
							num4 = num;
						}
						else
						{
							num = -1921507648;
							num4 = num;
						}
						continue;
					}
					case 0u:
						result = true;
						num = (int)((num3 * 474090509) ^ 0x5B01DED1);
						continue;
					case 4u:
						break;
					case 3u:
						goto end_IL_0013;
					case 1u:
						return result;
					}
					goto IL_0083;
					continue;
					end_IL_0013:
					break;
				}
				break;
			}
		}
		return false;
	}

	public SpecialSkillInstance GetSpecialSkill(string specialskillname)
	{
		using (List<SpecialSkillInstance>.Enumerator enumerator = SpecialSkills.GetEnumerator())
		{
			SpecialSkillInstance current = default(SpecialSkillInstance);
			SpecialSkillInstance result = default(SpecialSkillInstance);
			while (true)
			{
				IL_004f:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -1349743990;
					num2 = num;
				}
				else
				{
					num = -381745376;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -1908992812)) % 7)
					{
					case 0u:
						num = -381745376;
						continue;
					default:
						goto end_IL_0013;
					case 5u:
						current = enumerator.Current;
						num = -1114405133;
						continue;
					case 2u:
						break;
					case 1u:
					{
						int num4;
						int num5;
						if (!_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(current.Name, specialskillname))
						{
							num4 = 1196543627;
							num5 = num4;
						}
						else
						{
							num4 = 1419005855;
							num5 = num4;
						}
						num = num4 ^ (int)(num3 * 2082785055);
						continue;
					}
					case 3u:
						result = current;
						num = (int)((num3 * 2111412366) ^ 0x3C0F9A01);
						continue;
					case 6u:
						goto end_IL_0013;
					case 4u:
						return result;
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

	public ItemInstance GetEquipment(string name)
	{
		using (List<ItemInstance>.Enumerator enumerator = Equipment.GetEnumerator())
		{
			ItemInstance current = default(ItemInstance);
			while (true)
			{
				IL_0085:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 666945451;
					num2 = num;
				}
				else
				{
					num = 1662414729;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x669EE18C)) % 6)
					{
					case 2u:
						num = 1662414729;
						continue;
					default:
						goto end_IL_0013;
					case 3u:
						current = enumerator.Current;
						num = 2100911408;
						continue;
					case 0u:
					{
						int num4;
						int num5;
						if (!_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(current.Name, name))
						{
							num4 = 850925458;
							num5 = num4;
						}
						else
						{
							num4 = 1828409029;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -1384439885);
						continue;
					}
					case 1u:
						return current;
					case 4u:
						break;
					case 5u:
						goto end_IL_0013;
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

	public Color GetColor(int female)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		if (female == 1)
		{
			goto IL_0004;
		}
		goto IL_0057;
		IL_0004:
		int num = -657689059;
		goto IL_0009;
		IL_0009:
		uint num2;
		switch ((num2 = (uint)(num ^ -1617184549)) % 5)
		{
		case 0u:
			break;
		case 1u:
			return new Color(0.6902f, 0.87843f, 0.902f, 1f);
		case 3u:
			goto IL_0057;
		case 2u:
			return new Color(1f, 0.753f, 0.796f, 1f);
		default:
			return new Color(0.8588f, 0.439216f, 0.57647f, 1f);
		}
		goto IL_0004;
		IL_0057:
		int num3;
		if (female != 0)
		{
			num = -1715918950;
			num3 = num;
		}
		else
		{
			num = -1497866106;
			num3 = num;
		}
		goto IL_0009;
	}

	public Color GetColor()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return GetColor(Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2145573044u)]);
	}

	public int GetMaxSkillTypeValue2()
	{
		int num = _206E_206A_202D_202E_202A_200B_202A_202C_202B_206E_206B_202A_202C_202A_206B_200D_206F_206F_200C_202C_202A_200B_202B_206A_202C_206D_206F_202D_200D_200E_206A_202C_206F_200D_202E_200C_200C_206A_206F_206C_202E((IEnumerable<int>)new int[4]
		{
			Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2722506620u)] + GetAdditionAttribute(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1944260873u)),
			Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(430829805u)] + GetAdditionAttribute(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(248942232u)),
			Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2223184606u)] + GetAdditionAttribute(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1940200750u)),
			Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4176639349u)] + GetAdditionAttribute(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1977936243u))
		});
		return _206E_202D_206A_202B_206E_206A_206A_206A_206D_206A_200F_206F_202C_202A_206D_200C_202A_202D_202C_206B_202E_200C_206C_206B_200C_200E_206D_206F_200E_200E_206F_206F_202E_202C_206C_200E_202C_200B_200C_206B_202E(_206E_202D_206A_202B_206E_206A_206A_206A_206D_206A_200F_206F_202C_202A_206D_200C_202A_202D_202C_206B_202E_200C_206C_206B_200C_200E_206D_206F_200E_200E_206F_206F_202E_202C_206C_200E_202C_200B_200C_206B_202E(3000, MAX_ATTRIBUTE), num);
	}

	public string GetAttributeString2(string attr)
	{
		if (_202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(attr, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(186240569u)))
		{
			int num4 = default(int);
			int num3 = default(int);
			while (true)
			{
				int num = -1233453101;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -503813330)) % 5)
					{
					case 2u:
						break;
					case 3u:
						num4 = _206E_206A_202D_202E_202A_200B_202A_202C_202B_206E_206B_202A_202C_202A_206B_200D_206F_206F_200C_202C_202A_200B_202B_206A_202C_206D_206F_202D_200D_200E_206A_202C_206F_200D_202E_200C_200C_206A_206F_206C_202E((IEnumerable<int>)new int[4]
						{
							Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(199488088u)] + GetAdditionAttribute(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2053407229u)),
							Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(394181284u)] + GetAdditionAttribute(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3535376985u)),
							Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1940200750u)] + GetAdditionAttribute(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1029863417u)),
							Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2249625138u)] + GetAdditionAttribute(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2981046594u))
						});
						num = (int)((num2 * 780169937) ^ 0x1C178E9);
						continue;
					case 4u:
						num3 = _206E_202D_206A_202B_206E_206A_206A_206A_206D_206A_200F_206F_202C_202A_206D_200C_202A_202D_202C_206B_202E_200C_206C_206B_200C_200E_206D_206F_200E_200E_206F_206F_202E_202C_206C_200E_202C_200B_200C_206B_202E(3000, MAX_ATTRIBUTE);
						num = (int)((num2 * 1206676404) ^ 0x15CF56DF);
						continue;
					case 1u:
						return _206C_206E_200B_206B_206B_202C_206F_206B_202A_200C_206E_206E_202A_202A_202A_206C_206D_206B_206C_206A_200B_206C_202A_202B_206D_206C_202D_202B_206B_206A_206A_202E_202A_206A_206E_206E_206E_200E_202E_206F_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2024378677u), (object)_206E_202D_206A_202B_206E_206A_206A_206A_206D_206A_200F_206F_202C_202A_206D_200C_202A_202D_202C_206B_202E_200C_206C_206B_200C_200E_206D_206F_200E_200E_206F_206F_202E_202C_206C_200E_202C_200B_200C_206B_202E(num3, num4), (object)GetAdditionAttribute(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3842028702u)));
					default:
						goto end_IL_0015;
					}
					break;
				}
				continue;
				end_IL_0015:
				break;
			}
		}
		return GetAttributeString(attr);
	}

	internal void NullGrowTemplate()
	{
		_206F_202A_202B_200D_206A_202B_206E_206C_200E_202B_206B_200F_200E_206D_200F_202B_202A_206B_206A_200B_206C_202A_206A_202C_202D_206B_200B_202B_202D_202C_202B_200C_200E_200E_200C_200D_200F_206C_206C_200D_202E = null;
	}

	static string _202E_206F_206E_202D_206B_202D_200F_200B_200E_200C_206A_200D_200B_206B_202A_202D_206E_202A_206C_206B_202E_206A_206E_206B_202C_206B_206D_200D_202B_200C_206B_202C_202B_200F_202C_206E_206F_206B_200F_200E_202E(string P_0, string P_1)
	{
		return P_0 + P_1;
	}

	static void _200C_206D_200F_200B_202A_200F_200C_202C_200C_202E_206F_202C_202C_202C_206C_200B_200E_202B_206D_206C_200D_202B_206F_200B_200F_202C_206F_200D_202C_200E_202D_202B_202E_200F_202E_206D_202A_202C_200C_206F_202E(object P_0)
	{
		Debug.LogError(P_0);
	}

	static string[] _202B_202C_200F_202C_202E_202A_200C_206F_200F_202B_206A_202C_200F_200C_200E_206B_206F_202E_200E_206E_200B_206D_200F_200F_200C_206A_202D_206F_200E_200B_206E_200B_206A_206B_202E_202A_200F_206D_200F_202D_202E(string P_0, char[] P_1)
	{
		return P_0.Split(P_1);
	}

	static bool _202A_206A_206F_206D_206E_206A_200E_202E_206A_200B_206E_200D_206A_200D_206E_202B_200E_206D_202C_200B_200F_206C_202C_206A_202C_206D_200C_206F_206D_200E_202A_206E_206B_200E_202E_206C_206F_200F_206B_200C_202E(IEnumerator P_0)
	{
		return P_0.MoveNext();
	}

	static void _202D_200E_200B_206B_200E_206D_200F_200C_202B_200F_202A_202A_206D_206D_206B_202B_202C_206D_206B_202D_202A_206A_202E_200B_202B_200C_202E_200D_206B_202C_202C_202E_206E_202C_202B_206D_202E_202C_200F_200E_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}

	static bool _202D_206E_202C_202C_206F_206C_202E_200C_202B_202D_202D_200B_206D_206F_202D_200C_202C_200D_206E_200B_202E_202A_202C_200D_202E_200E_206D_206E_206C_206C_206C_202A_202B_200E_206E_206A_202B_200C_200C_202C_202E(string P_0, string P_1)
	{
		return P_0 == P_1;
	}

	static bool _202B_202C_206D_206B_202E_206C_200C_202D_202B_202A_206F_206E_202E_202B_206F_206E_206F_202B_206C_206C_202A_206E_202B_200C_202A_202E_200F_202A_200E_206D_206C_202D_202B_200D_202D_206C_202B_202C_200C_202E(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}

	static bool _206A_206B_202A_202E_202C_206A_202B_206D_206C_206A_200E_206C_200B_200D_206F_202D_202D_200D_200C_202B_200C_202D_200D_200B_200E_206D_202D_206C_200E_206F_206E_202A_202C_206E_200B_202D_206C_206F_200C_200D_202E(string P_0, string P_1)
	{
		return P_0 != P_1;
	}

	static string _202A_206D_200C_202D_206D_200E_200C_206D_202B_200E_202B_206F_206A_202B_202E_200C_206B_202C_202A_200D_200F_202E_202A_206A_202E_200F_206B_202D_206C_206E_200E_206B_206E_202E_206D_202B_206F_206F_200F_200C_202E(string P_0, string[] P_1)
	{
		return string.Join(P_0, P_1);
	}

	static bool _206E_202B_200D_206D_200E_200E_206C_200F_200B_200F_206C_200F_206D_206D_200C_202B_206B_200B_206F_206E_206A_200B_200B_200B_206A_206A_202E_206D_206F_202B_200C_202C_206B_200B_200D_206F_200F_200E_200D_206E_202E(string P_0, string P_1)
	{
		return P_0.StartsWith(P_1);
	}

	static int _206E_206A_202D_202E_202A_200B_202A_202C_202B_206E_206B_202A_202C_202A_206B_200D_206F_206F_200C_202C_202A_200B_202B_206A_202C_206D_206F_202D_200D_200E_206A_202C_206F_200D_202E_200C_200C_206A_206F_206C_202E(IEnumerable<int> P_0)
	{
		return P_0.Max();
	}

	static string _206C_206E_200B_206B_206B_202C_206F_206B_202A_200C_206E_206E_202A_202A_202A_206C_206D_206B_206C_206A_200B_206C_202A_202B_206D_206C_202D_202B_206B_206A_206A_202E_202A_206A_206E_206E_206E_200E_202E_206F_202E(string P_0, object P_1, object P_2)
	{
		return string.Format(P_0, P_1, P_2);
	}

	static double _202E_200E_200B_200E_206F_200D_206F_202E_200C_206F_202A_200D_202E_202D_206A_202C_206E_200B_206D_200B_202E_202D_206E_200F_206D_200D_200F_202E_206C_206B_206C_202E_206A_202A_206F_206F_200B_202C_202D_200F_202E(double P_0, double P_1)
	{
		return Math.Pow(P_0, P_1);
	}

	static double _202C_200C_202C_202A_206B_202E_206D_200B_200F_206F_200E_202D_200C_206C_202E_202D_202B_202B_202D_206B_202C_202E_202D_206C_202B_200D_200E_206E_200D_206D_206A_200B_206A_200D_202B_200B_200C_200D_200E_202A_202E(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	static float _200C_206F_202A_206F_206D_200B_200E_206F_206F_206D_202B_206A_206C_202C_202E_206B_206E_200B_200F_202B_206B_200B_206D_206C_206E_206E_206C_206F_206D_206E_200B_206D_200C_202C_200C_202A_202B_202B_200F_202B_202E(float P_0, float P_1)
	{
		return Math.Min(P_0, P_1);
	}

	static int _206E_202D_206A_202B_206E_206A_206A_206A_206D_206A_200F_206F_202C_202A_206D_200C_202A_202D_202C_206B_202E_200C_206C_206B_200C_200E_206D_206F_200E_200E_206F_206F_202E_202C_206C_200E_202C_200B_200C_206B_202E(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	static bool _202D_202C_200F_200C_202D_206C_202D_206C_200D_200D_200C_206A_206F_200B_202B_202B_200D_206E_202A_200E_202C_202C_202E_200D_206D_200C_206A_202A_200F_202D_206D_200C_206A_200F_206B_206D_206A_202C_200D_202A_202E(string P_0, string P_1)
	{
		return P_0.Equals(P_1);
	}

	static int _206D_200E_206D_202C_206A_206D_200F_200E_206A_206D_202A_202D_206D_200D_200F_200C_206C_206C_200B_206C_202A_206B_206A_202A_206E_200B_202B_200B_202D_202E_202A_206B_200E_202D_206F_206D_206F_206C_206B_200D_202E(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	static double _200F_200D_202C_206D_200D_206F_202D_206E_200C_206C_206F_200D_200D_202C_200E_202E_202C_202C_206D_206C_206F_200E_206F_206B_206A_206F_206E_206F_200C_200C_206D_206D_202C_200D_200E_200C_200E_206D_200D_202A_202E(double P_0, double P_1)
	{
		return Math.Min(P_0, P_1);
	}

	static string _206F_202C_206E_206C_200B_206D_206B_202E_206E_200E_202A_202E_206C_200E_206F_200C_200D_200E_206B_206C_206D_200B_206E_202E_200B_202A_202D_202E_202D_202B_202E_206C_200B_202A_206B_202C_200F_202B_202B_206F_202E(string P_0, string P_1, string P_2)
	{
		return P_0.Replace(P_1, P_2);
	}
}
