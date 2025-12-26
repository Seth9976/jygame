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

[XmlType("skill")]
public class SkillInstance : SkillBox
{
	[CompilerGenerated]
	private sealed class _202A_200E_206B_206A_206D_206D_200B_206F_200E_206C_206B_206B_202D_206A_200D_206F_206C_200D_202C_206A_206C_206B_206A_202C_206D_202B_206D_206D_200E_206C_206A_202B_206C_206D_206D_206F_200D_202B_202A_202C_202E : IEnumerable<string>, IEnumerator<string>, IEnumerator, IDisposable, IEnumerable
	{
		private int _200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E;

		private string _200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E;

		private int _200B_202B_206E_200C_202C_200D_206F_202E_200F_206A_200C_202C_200B_202D_200F_206E_202D_206C_200B_202C_206C_206A_206E_206C_202B_206D_206E_200E_206E_202D_206E_202E_202E_202A_206D_206E_206D_202C_202D_202E;

		public SkillInstance _202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E;

		private Trigger _202B_202A_206B_202A_206D_206A_206D_202D_206D_206F_202A_202A_202E_206A_200B_202A_200F_206E_206B_200E_202D_200D_202D_206B_200F_200E_200C_206A_200C_206E_202E_200E_200F_206A_206D_202A_200D_200D_202B_200C_202E;

		private List<Trigger>.Enumerator _206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E;

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
		public _202A_200E_206B_206A_206D_206D_200B_206F_200E_206C_206B_206B_202D_206A_200D_206F_206C_200D_202C_206A_206C_206B_206A_202C_206D_202B_206D_206D_200E_206C_206A_202B_206C_206D_206D_206F_200D_202B_202A_202C_202E(int P_0)
		{
			while (true)
			{
				int num = 882148658;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x2D05A9B0)) % 3)
					{
					case 0u:
						break;
					default:
						return;
					case 2u:
						goto IL_0028;
					case 1u:
						return;
					}
					break;
					IL_0028:
					_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = P_0;
					_200B_202B_206E_200C_202C_200D_206F_202E_200F_206A_200C_202C_200B_202D_200F_206E_202D_206C_200B_202C_206C_206A_206E_206C_202B_206D_206E_200E_206E_202D_206E_202E_202E_202A_206D_206E_206D_202C_202D_202E = _202C_200D_206E_206A_200D_202A_206E_206F_200E_206D_202B_206D_206D_200F_200F_202A_200D_200D_200E_202E_202D_206A_202A_202A_200D_200E_200B_206B_206C_202E_200B_206A_206D_206F_200E_202E_206E_200E_206E_202A_202E(_206B_200B_200C_202C_200D_206D_200D_206C_202E_206E_206F_200F_202A_200D_202A_206B_202D_202A_206A_206D_200E_200B_206B_200F_200D_206C_200D_206A_202A_202B_206D_202D_200D_206A_202D_202C_202E_200E_200C_202E());
					num = ((int)num2 * -1322264647) ^ 0xE00689B;
				}
			}
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E;
			while (true)
			{
				int num2 = 525857182;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num2 ^ 0x6AC4E2D7)) % 4)
					{
					case 3u:
						break;
					case 1u:
					{
						int num4;
						int num5;
						if (num != -3)
						{
							num4 = 1908455492;
							num5 = num4;
						}
						else
						{
							num4 = 1872470166;
							num5 = num4;
						}
						num2 = num4 ^ ((int)num3 * -586684485);
						continue;
					}
					case 0u:
						if ((uint)(num - 1) <= 1u)
						{
							num2 = ((int)num3 * -584734953) ^ 0x4E695F85;
							continue;
						}
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
				}
			}
		}

		private bool MoveNext()
		{
			bool result = default(bool);
			try
			{
				int num = _200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E;
				SkillInstance skillInstance = default(SkillInstance);
				while (true)
				{
					IL_0007:
					int num2 = -476433635;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num2 ^ -1872134328)) % 22)
						{
						case 21u:
							break;
						case 9u:
							num2 = (int)((num3 * 1430988688) ^ 0x5F1943BD);
							continue;
						case 18u:
							_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E = default(List<Trigger>.Enumerator);
							num2 = ((int)num3 * -1356396211) ^ -535361972;
							continue;
						case 6u:
							_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E = skillInstance.Skill.Triggers.GetEnumerator();
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -3;
							num2 = (int)((num3 * 2127171565) ^ 0x5612A803);
							continue;
						case 7u:
						{
							int num10;
							int num11;
							if (skillInstance.Level >= _202B_202A_206B_202A_206D_206A_206D_202D_206D_206F_202A_202A_202E_206A_200B_202A_200F_206E_206B_200E_202D_200D_202D_206B_200F_200E_200C_206A_200C_206E_202E_200E_200F_206A_206D_202A_200D_200D_202B_200C_202E.Level)
							{
								num10 = 948763818;
								num11 = num10;
							}
							else
							{
								num10 = 322396447;
								num11 = num10;
							}
							num2 = num10 ^ (int)(num3 * 188498614);
							continue;
						}
						case 4u:
						{
							int num6;
							if (_202E_200C_206E_206D_206B_206A_202E_202C_202A_200C_206F_202A_202C_206E_200B_206C_206F_206D_202B_206E_200F_206D_206C_206B_206A_200D_206B_200E_206C_200F_202E_202B_206A_206D_200E_200E_202B_202C_206B_206C_202E(_202B_202A_206B_202A_206D_206A_206D_202D_206D_206F_202A_202A_202E_206A_200B_202A_200F_206E_206B_200E_202D_200D_202D_206B_200F_200E_200C_206A_200C_206E_202E_200E_200F_206A_206D_202A_200D_200D_202B_200C_202E.Name, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(810474758u)))
							{
								num2 = -1962407948;
								num6 = num2;
							}
							else
							{
								num2 = -812707763;
								num6 = num2;
							}
							continue;
						}
						case 5u:
						{
							int num7;
							int num8;
							if (_202E_200C_206E_206D_206B_206A_202E_202C_202A_200C_206F_202A_202C_206E_200B_206C_206F_206D_202B_206E_200F_206D_206C_206B_206A_200D_206B_200E_206C_200F_202E_202B_206A_206D_200E_200E_202B_202C_206B_206C_202E(_202B_202A_206B_202A_206D_206A_206D_202D_206D_206F_202A_202A_202E_206A_200B_202A_200F_206E_206B_200E_202D_200D_202D_206B_200F_200E_200C_206A_200C_206E_202E_200E_200F_206A_206D_202A_200D_200D_202B_200C_202E.Name, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(46284554u)))
							{
								num7 = 116243803;
								num8 = num7;
							}
							else
							{
								num7 = 1920398650;
								num8 = num7;
							}
							num2 = num7 ^ (int)(num3 * 201438664);
							continue;
						}
						case 16u:
						{
							int num12;
							int num13;
							if (skillInstance.Level < _202B_202A_206B_202A_206D_206A_206D_202D_206D_206F_202A_202A_202E_206A_200B_202A_200F_206E_206B_200E_202D_200D_202D_206B_200F_200E_200C_206A_200C_206E_202E_200E_200F_206A_206D_202A_200D_200D_202B_200C_202E.Level)
							{
								num12 = 1365990725;
								num13 = num12;
							}
							else
							{
								num12 = 1307625740;
								num13 = num12;
							}
							num2 = num12 ^ (int)(num3 * 1907352158);
							continue;
						}
						case 8u:
							_202D_202A_202A_200E_206E_202E_206C_202C_206F_202C_200C_202E_202A_206E_202B_202D_202C_206F_206C_206A_202A_200F_206A_200F_206D_200B_200C_202C_202B_206E_200E_206C_202D_200D_202E_202D_206D_206D_202B_202C_202E();
							num2 = ((int)num3 * -305289837) ^ 0x690CB0B6;
							continue;
						case 19u:
						{
							int num9;
							if (_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E.MoveNext())
							{
								num2 = -853428419;
								num9 = num2;
							}
							else
							{
								num2 = -1340130454;
								num9 = num2;
							}
							continue;
						}
						case 14u:
							goto end_IL_000c;
						case 17u:
							skillInstance = _202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E;
							switch (num)
							{
							case 1:
								goto IL_0217;
							case 0:
								goto IL_0229;
							case 2:
								goto IL_02a6;
							}
							num2 = ((int)num3 * -670686851) ^ -411666752;
							continue;
						case 0u:
							goto IL_0217;
						case 2u:
							goto IL_0229;
						case 12u:
							_200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E = _202B_202A_206B_202A_206D_206A_206D_202D_206D_206F_202A_202A_202E_206A_200B_202A_200F_206E_206B_200E_202D_200D_202D_206B_200F_200E_200C_206A_200C_206E_202E_200E_200F_206A_206D_202A_200D_200D_202B_200C_202E.Argvs[0];
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 2;
							result = true;
							goto end_IL_000c;
						case 1u:
							_202B_202A_206B_202A_206D_206A_206D_202D_206D_206F_202A_202A_202E_206A_200B_202A_200F_206E_206B_200E_202D_200D_202D_206B_200F_200E_200C_206A_200C_206E_202E_200E_200F_206A_206D_202A_200D_200D_202B_200C_202E = null;
							num2 = -2099025267;
							continue;
						case 20u:
						{
							int num4;
							int num5;
							if (skillInstance.IsUsed)
							{
								num4 = -1006448467;
								num5 = num4;
							}
							else
							{
								num4 = -44337827;
								num5 = num4;
							}
							num2 = num4 ^ ((int)num3 * -892661133);
							continue;
						}
						case 3u:
							goto IL_02a6;
						case 15u:
							_202B_202A_206B_202A_206D_206A_206D_202D_206D_206F_202A_202A_202E_206A_200B_202A_200F_206E_206B_200E_202D_200D_202D_206B_200F_200E_200C_206A_200C_206E_202E_200E_200F_206A_206D_202A_200D_200D_202B_200C_202E = _206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E.Current;
							num2 = -1594075125;
							continue;
						case 13u:
							result = false;
							goto end_IL_000c;
						case 11u:
							_200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E = _202B_202A_206B_202A_206D_206A_206D_202D_206D_206F_202A_202A_202E_206A_200B_202A_200F_206E_206B_200E_202D_200D_202D_206B_200F_200E_200C_206A_200C_206E_202E_200E_200F_206A_206D_202A_200D_200D_202B_200C_202E.Argvs[0];
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 1;
							result = true;
							num2 = ((int)num3 * -1159131385) ^ 0x19200F45;
							continue;
						default:
							{
								result = false;
								goto end_IL_000c;
							}
							IL_02a6:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -3;
							num2 = -812707763;
							continue;
							IL_0229:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
							num2 = -1191579570;
							continue;
							IL_0217:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -3;
							num2 = -2069669825;
							continue;
						}
						goto IL_0007;
						continue;
						end_IL_000c:
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

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw _200B_206F_206A_202D_206D_202B_200D_200E_206E_206F_206E_206F_202C_206A_202B_200C_206F_206F_206B_202C_206A_200B_206C_200B_200D_202B_206D_200F_202A_206C_200F_206C_202D_200E_202E_206E_200F_206C_206B_202B_202E();
		}

		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			if (_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E == -2)
			{
				goto IL_000a;
			}
			goto IL_0038;
			IL_000a:
			int num = -1165442840;
			goto IL_000f;
			IL_000f:
			_202A_200E_206B_206A_206D_206D_200B_206F_200E_206C_206B_206B_202D_206A_200D_206F_206C_200D_202C_206A_206C_206B_206A_202C_206D_202B_206D_206D_200E_206C_206A_202B_206C_206D_206D_206F_200D_202B_202A_202C_202E result = default(_202A_200E_206B_206A_206D_206D_200B_206F_200E_206C_206B_206B_202D_206A_200D_206F_206C_200D_202C_206A_206C_206B_206A_202C_206D_202B_206D_206D_200E_206C_206A_202B_206C_206D_206D_206F_200D_202B_202A_202C_202E);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1782728632)) % 6)
				{
				case 0u:
					break;
				case 5u:
					goto IL_0038;
				case 3u:
					result = this;
					num = (int)(num2 * 716528134) ^ -997361507;
					continue;
				case 4u:
					_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 0;
					num = ((int)num2 * -1960382393) ^ -2026883407;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (_200B_202B_206E_200C_202C_200D_206F_202E_200F_206A_200C_202C_200B_202D_200F_206E_202D_206C_200B_202C_206C_206A_206E_206C_202B_206D_206E_200E_206E_202D_206E_202E_202E_202A_206D_206E_206D_202C_202D_202E != _202C_200D_206E_206A_200D_202A_206E_206F_200E_206D_202B_206D_206D_200F_200F_202A_200D_200D_200E_202E_202D_206A_202A_202A_200D_200E_200B_206B_206C_202E_200B_206A_206D_206F_200E_202E_206E_200E_206E_202A_202E(_206B_200B_200C_202C_200D_206D_200D_206C_202E_206E_206F_200F_202A_200D_202A_206B_202D_202A_206A_206D_200E_200B_206B_200F_200D_206C_200D_206A_202A_202B_206D_202D_200D_206A_202D_202C_202E_200E_200C_202E()))
					{
						num3 = -562619829;
						num4 = num3;
					}
					else
					{
						num3 = -1678373220;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 341698221);
					continue;
				}
				default:
					return result;
				}
				break;
			}
			goto IL_000a;
			IL_0038:
			result = new _202A_200E_206B_206A_206D_206D_200B_206F_200E_206C_206B_206B_202D_206A_200D_206F_206C_200D_202C_206A_206C_206B_206A_202C_206D_202B_206D_206D_200E_206C_206A_202B_206C_206D_206D_206F_200D_202B_202A_202C_202E(0)
			{
				_202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E = _202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E
			};
			num = -1239317149;
			goto IL_000f;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<string>)this).GetEnumerator();
		}

		static Thread _206B_200B_200C_202C_200D_206D_200D_206C_202E_206E_206F_200F_202A_200D_202A_206B_202D_202A_206A_206D_200E_200B_206B_200F_200D_206C_200D_206A_202A_202B_206D_202D_200D_206A_202D_202C_202E_200E_200C_202E()
		{
			return Thread.CurrentThread;
		}

		static int _202C_200D_206E_206A_200D_202A_206E_206F_200E_206D_202B_206D_206D_200F_200F_202A_200D_200D_200E_202E_202D_206A_202A_202A_200D_200E_200B_206B_206C_202E_200B_206A_206D_206F_200E_202E_206E_200E_206E_202A_202E(Thread P_0)
		{
			return P_0.ManagedThreadId;
		}

		static bool _202E_200C_206E_206D_206B_206A_202E_202C_202A_200C_206F_202A_202C_206E_200B_206C_206F_206D_202B_206E_200F_206D_206C_206B_206A_200D_206B_200E_206C_200F_202E_202B_206A_206D_200E_200E_202B_202C_206B_206C_202E(string P_0, string P_1)
		{
			return P_0 == P_1;
		}

		static NotSupportedException _200B_206F_206A_202D_206D_202B_200D_200E_206E_206F_206E_206F_202C_206A_202B_200C_206F_206F_206B_202C_206A_200B_206C_200B_200D_202B_206D_200F_202A_206C_200F_206C_202D_200E_202E_206E_200F_206C_206B_202B_202E()
		{
			return new NotSupportedException();
		}
	}

	private string _206A_202D_202C_200D_206B_206E_200E_206F_206B_206E_206D_200B_200D_206E_200B_200D_206D_202A_200D_200F_206B_200F_206A_206A_200F_206F_206E_206F_206F_200B_202E_200B_200B_200E_206B_206F_206E_200D_202A_200F_202E;

	[XmlIgnore]
	public List<UniqueSkillInstance> UniqueSkills = new List<UniqueSkillInstance>();

	[XmlAttribute]
	public int level;

	[XmlAttribute]
	public int Exp;

	[XmlAttribute]
	public string levelformula;

	private Skill _206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E;

	[XmlIgnore]
	internal float level2;

	[XmlAttribute]
	public string name
	{
		get
		{
			return _206A_202D_202C_200D_206B_206E_200E_206F_206B_206E_206D_200B_200D_206E_200B_200D_206D_202A_200D_200F_206B_200F_206A_206A_200F_206F_206E_206F_206F_200B_202E_200B_200B_200E_206B_206F_206E_200D_202A_200F_202E;
		}
		set
		{
			_206A_202D_202C_200D_206B_206E_200E_206F_206B_206E_206D_200B_200D_206E_200B_200D_206D_202A_200D_200F_206B_200F_206A_206A_200F_206F_206E_206F_206F_200B_202E_200B_200B_200E_206B_206F_206E_200D_202A_200F_202E = value;
		}
	}

	public override string Name => name;

	public override string Icon => Skill.icon;

	public override Color Color => Color.white;

	public override int Cd => Skill.GetCooldown(level);

	public override int Type => Skill.Type;

	public override int CostMp => new SkillCoverTypeHelper(CoverType).CostMp(Power, Size);

	public override int CostBall => 0;

	public override int CastSize => Skill.GetCastSize(level);

	public override string Animation => Skill.GetAnimationName(level);

	public override SkillType SkillType => SkillType.Normal;

	public override int Level
	{
		get
		{
			if (level == -(int)level2)
			{
				goto IL_0010;
			}
			goto IL_004c;
			IL_0010:
			int num = 930364847;
			goto IL_0015;
			IL_0015:
			uint num2;
			switch ((num2 = (uint)(num ^ 0x20612A76)) % 4)
			{
			case 0u:
				break;
			case 1u:
				return level;
			case 2u:
				goto IL_004c;
			default:
				return 1;
			}
			goto IL_0010;
			IL_004c:
			SystemClass._202D_202A_202A_200C_202D_206A_206C_206E_206C_200D_206C_206F_200E_200F_202D_202C_202B_206F_202C_200C_200D_202D_206A_206E_202E_202B_202D_206F_202C_202A_202A_202A_206B_200E_206F_206D_206D_200E_200B_206F_202E();
			num = 198816953;
			goto IL_0015;
		}
	}

	public override bool Tiaohe => Skill.Tiaohe;

	public override float Suit => Skill.Suit;

	public override string Audio => Skill.Audio;

	[XmlIgnore]
	public override string DescriptionInRichtext
	{
		get
		{
			string text = Skill.Info;
			float num10 = default(float);
			float num13 = default(float);
			int maxLevel = default(int);
			Trigger current = default(Trigger);
			while (true)
			{
				int num = -536661630;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1289605455)) % 31)
					{
					case 0u:
						break;
					case 8u:
						text = _206C_206D_202E_200B_202D_206C_200F_206A_200E_206A_206B_200E_206C_200D_202E_200F_200B_206A_202C_202E_206A_206A_200F_202D_206B_202D_202C_206B_200F_202C_206A_202C_206F_202D_202E_202A_202D_206D_206C_200C_202E(text, _200B_206A_206D_206A_202E_206F_206E_202D_206C_206B_202C_202A_206C_200F_206E_202C_206A_202E_202C_202B_206D_200B_206E_200C_206E_202E_200C_202E_202B_206B_206C_200C_202D_206B_202C_206E_202D_206A_200E_202E(ResourceStrings.ResStrings[398], new object[0]));
						num = ((int)num2 * -358100496) ^ -360317142;
						continue;
					case 3u:
					{
						int num17;
						if (Suit > 0f)
						{
							num = -196930056;
							num17 = num;
						}
						else
						{
							num = -583131545;
							num17 = num;
						}
						continue;
					}
					case 4u:
						text = _206C_206D_202E_200B_202D_206C_200F_206A_200E_206A_206B_200E_206C_200D_202E_200F_200B_206A_202C_202E_206A_206A_200F_202D_206B_202D_202C_206B_200F_202C_206A_202C_206F_202D_202E_202A_202D_206D_206C_200C_202E(text, _206A_200D_206E_200C_202C_200C_202B_200C_200C_206F_200E_206F_200C_206C_200C_202E_206D_200D_200B_206A_206D_206E_202C_206E_200D_202D_200E_202C_202E_202E_206E_206A_206F_206E_200B_200E_206A_206F_202C_202E(ResourceStrings.ResStrings[738], (object)num10, (object)num13));
						num = -2002606027;
						continue;
					case 28u:
						num13 = 100f;
						num = (int)(num2 * 282409903) ^ -1954922097;
						continue;
					case 10u:
						text = _206C_206D_202E_200B_202D_206C_200F_206A_200E_206A_206B_200E_206C_200D_202E_200F_200B_206A_202C_202E_206A_206A_200F_202D_206B_202D_202C_206B_200F_202C_206A_202C_206F_202D_202E_202A_202D_206D_206C_200C_202E(text, _200B_206A_206D_206A_202E_206F_206E_202D_206C_206B_202C_202A_206C_200F_206E_202C_206A_202E_202C_202B_206D_200B_206E_200C_206E_202E_200C_202E_202B_206B_206C_200C_202D_206B_202C_206E_202D_206A_200E_202E(ResourceStrings.ResStrings[394], new object[9]
						{
							Level,
							MaxLevel,
							Exp,
							LevelupExp,
							Power,
							GetSkillCoverTypeChinese(),
							Size,
							CastSize,
							CostMp
						}));
						num = ((int)num2 * -594764136) ^ 0x57C2DBA2;
						continue;
					case 14u:
						num = (int)((num2 * 666012625) ^ 0x9C4D074);
						continue;
					case 6u:
						num10 = (int)((TiaoheScale + 1E-05f) % 1f * 1000f);
						num = ((int)num2 * -874479925) ^ 0x568EAEE2;
						continue;
					case 20u:
						num10 = 100f;
						num = ((int)num2 * -1775890488) ^ -395206732;
						continue;
					case 30u:
						text = _206C_206D_202E_200B_202D_206C_200F_206A_200E_206A_206B_200E_206C_200D_202E_200F_200B_206A_202C_202E_206A_206A_200F_202D_206B_202D_202C_206B_200F_202C_206A_202C_206F_202D_202E_202A_202D_206D_206C_200C_202E(text, _200B_206A_206D_206A_202E_206F_206E_202D_206C_206B_202C_202A_206C_200F_206E_202C_206A_202E_202C_202B_206D_200B_206E_200C_206E_202E_200C_202E_202B_206B_206C_200C_202D_206B_202C_206E_202D_206A_200E_202E(ResourceStrings.ResStrings[394], new object[9]
						{
							Level,
							MaxLevel,
							Exp,
							LevelupExp,
							PowerBattle,
							GetSkillCoverTypeChinese(),
							Size,
							CastSize,
							CostMpBattle
						}));
						num = -1189426292;
						continue;
					case 21u:
						text = _206C_206D_202E_200B_202D_206C_200F_206A_200E_206A_206B_200E_206C_200D_202E_200F_200B_206A_202C_202E_206A_206A_200F_202D_206B_202D_202C_206B_200F_202C_206A_202C_206F_202D_202E_202A_202D_206D_206C_200C_202E(text, _206A_200D_206E_200C_202C_200C_202B_200C_200C_206F_200E_206F_200C_206C_200C_202E_206D_200D_200B_206A_206D_206E_202C_206E_200D_202D_200E_202C_202E_202E_206E_206A_206F_206E_200B_200E_206A_206F_202C_202E(ResourceStrings.ResStrings[395], (object)CurrentCd, (object)Cd));
						num = ((int)num2 * -2119911165) ^ 0x51CE114D;
						continue;
					case 13u:
					{
						int num18;
						if (num10 != 100f)
						{
							num = -2104142075;
							num18 = num;
						}
						else
						{
							num = -598067241;
							num18 = num;
						}
						continue;
					}
					case 17u:
						num = (int)((num2 * 1977714442) ^ 0x3926BBD7);
						continue;
					case 1u:
						num13 = _206D_200F_200D_202C_206C_202B_200E_202E_200C_202A_206F_206B_200C_200B_200F_202C_200F_200E_206A_200F_200F_206E_202A_200D_202C_200C_206B_206F_206E_200E_202D_206E_202B_206F_200B_206A_200E_200D_206B_206F_202E(999, (int)TiaoheScale);
						num = (int)(num2 * 268196562) ^ -1169853429;
						continue;
					case 26u:
					{
						int num12;
						if (CurrentCd == 0)
						{
							num = -861729120;
							num12 = num;
						}
						else
						{
							num = -473431801;
							num12 = num;
						}
						continue;
					}
					case 24u:
					{
						int num21;
						int num22;
						if (num13 != 100f)
						{
							num21 = -202350023;
							num22 = num21;
						}
						else
						{
							num21 = -1369265501;
							num22 = num21;
						}
						num = num21 ^ ((int)num2 * -1577941526);
						continue;
					}
					case 23u:
						maxLevel = MaxLevel2;
						num = (int)((num2 * 644516776) ^ 0x5CBE18E9);
						continue;
					case 19u:
					{
						text = _206C_206D_202E_200B_202D_206C_200F_206A_200E_206A_206B_200E_206C_200D_202E_200F_200B_206A_202C_202E_206A_206A_200F_202D_206B_202D_202C_206B_200F_202C_206A_202C_206F_202D_202E_202A_202D_206D_206C_200C_202E(text, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2910989005u));
						int num19;
						int num20;
						if (Item != null)
						{
							num19 = 826505828;
							num20 = num19;
						}
						else
						{
							num19 = 952788790;
							num20 = num19;
						}
						num = num19 ^ (int)(num2 * 1870265477);
						continue;
					}
					case 15u:
						text = _206C_206D_202E_200B_202D_206C_200F_206A_200E_206A_206B_200E_206C_200D_202E_200F_200B_206A_202C_202E_206A_206A_200F_202D_206B_202D_202C_206B_200F_202C_206A_202C_206F_202D_202E_202A_202D_206D_206C_200C_202E(text, _202E_206E_202A_206B_202B_206B_202A_200B_202C_206D_206A_200E_202B_206A_206D_206F_206F_206A_206A_206C_202E_206C_206B_202B_200E_206E_202A_200C_206B_200B_200E_200B_200C_202A_200B_202D_206B_202C_200B_202C_202E(ResourceStrings.ResStrings[399], (object)(Skill.Suit * 100f)));
						num = ((int)num2 * -1007359012) ^ 0x68D7E3F3;
						continue;
					case 5u:
						num = (int)((num2 * 1397432123) ^ 0x193639AD);
						continue;
					case 12u:
						text = _206C_206D_202E_200B_202D_206C_200F_206A_200E_206A_206B_200E_206C_200D_202E_200F_200B_206A_202C_202E_206A_206A_200F_202D_206B_202D_202C_206B_200F_202C_206A_202C_206F_202D_202E_202A_202D_206D_206C_200C_202E(text, _206A_200D_206E_200C_202C_200C_202B_200C_200C_206F_200E_206F_200C_206C_200C_202E_206D_200D_200B_206A_206D_206E_202C_206E_200D_202D_200E_202C_202E_202E_206E_206A_206F_206E_200B_200E_206A_206F_202C_202E(ResourceStrings.ResStrings[396], (object)CurrentCd, (object)Cd));
						num = -1151485826;
						continue;
					case 9u:
						text = _206C_206D_202E_200B_202D_206C_200F_206A_200E_206A_206B_200E_206C_200D_202E_200F_200B_206A_202C_202E_206A_206A_200F_202D_206B_202D_202C_206B_200F_202C_206A_202C_206F_202D_202E_202A_202D_206D_206C_200C_202E(text, _200B_206A_206D_206A_202E_206F_206E_202D_206C_206B_202C_202A_206C_200F_206E_202C_206A_202E_202C_202B_206D_200B_206E_200C_206E_202E_200C_202E_202B_206B_206C_200C_202D_206B_202C_206E_202D_206A_200E_202E(ResourceStrings.ResStrings[397], new object[0]));
						num = -1629591809;
						continue;
					case 25u:
					{
						int num15;
						int num16;
						if (TiaoheScale < 1.001f)
						{
							num15 = 1705856793;
							num16 = num15;
						}
						else
						{
							num15 = 2099940785;
							num16 = num15;
						}
						num = num15 ^ (int)(num2 * 940838300);
						continue;
					}
					case 18u:
						text = _206C_206D_202E_200B_202D_206C_200F_206A_200E_206A_206B_200E_206C_200D_202E_200F_200B_206A_202C_202E_206A_206A_200F_202D_206B_202D_202C_206B_200F_202C_206A_202C_206F_202D_202E_202A_202D_206D_206C_200C_202E(text, GetBuffsString());
						if (Skill.Triggers.Count > 0)
						{
							num = -1258652778;
							continue;
						}
						goto IL_07f8;
					case 2u:
						text = _206C_206D_202E_200B_202D_206C_200F_206A_200E_206A_206B_200E_206C_200D_202E_200F_200B_206A_202C_202E_206A_206A_200F_202D_206B_202D_202C_206B_200F_202C_206A_202C_206F_202D_202E_202A_202D_206D_206C_200C_202E(text, _202E_206E_202A_206B_202B_206B_202A_200B_202C_206D_206A_200E_202B_206A_206D_206F_206F_206A_206A_206C_202E_206C_206B_202B_200E_206E_202A_200C_206B_200B_200E_200B_200C_202A_200B_202D_206B_202C_200B_202C_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(8549061u), (object)ResourceStrings.ResStrings[390]));
						num = ((int)num2 * -349335103) ^ 0x3C345AC2;
						continue;
					case 7u:
					{
						int num14;
						if (Suit != 0f)
						{
							num = -859386377;
							num14 = num;
						}
						else
						{
							num = -824652399;
							num14 = num;
						}
						continue;
					}
					case 27u:
					{
						int num11;
						if (Suit >= 0f)
						{
							num = -1629591809;
							num11 = num;
						}
						else
						{
							num = -226863285;
							num11 = num;
						}
						continue;
					}
					case 16u:
						text = _206C_206D_202E_200B_202D_206C_200F_206A_200E_206A_206B_200E_206C_200D_202E_200F_200B_206A_202C_202E_206A_206A_200F_202D_206B_202D_202C_206B_200F_202C_206A_202C_206F_202D_202E_202A_202D_206D_206C_200C_202E(text, _202E_206E_202A_206B_202B_206B_202A_200B_202C_206D_206A_200E_202B_206A_206D_206F_206F_206A_206A_206C_202E_206C_206B_202B_200E_206E_202A_200C_206B_200B_200E_200B_200C_202A_200B_202D_206B_202C_200B_202C_202E(ResourceStrings.ResStrings[400], (object)((0f - Skill.Suit) * 100f)));
						num = ((int)num2 * -725385553) ^ -1238627559;
						continue;
					case 11u:
						num = ((int)num2 * -1168587879) ^ -1719603407;
						continue;
					case 22u:
					{
						int num9;
						if (!Tiaohe)
						{
							num = -1134528336;
							num9 = num;
						}
						else
						{
							num = -985312063;
							num9 = num;
						}
						continue;
					}
					default:
						{
							using (List<Trigger>.Enumerator enumerator = Skill.Triggers.GetEnumerator())
							{
								while (true)
								{
									IL_070e:
									int num3;
									int num4;
									if (enumerator.MoveNext())
									{
										num3 = -2093669687;
										num4 = num3;
									}
									else
									{
										num3 = -1149196441;
										num4 = num3;
									}
									while (true)
									{
										switch ((num2 = (uint)(num3 ^ -1289605455)) % 12)
										{
										case 11u:
											num3 = -2093669687;
											continue;
										default:
											goto end_IL_0637;
										case 0u:
										{
											int num7;
											int num8;
											if (current.Level <= maxLevel)
											{
												num7 = -2123114418;
												num8 = num7;
											}
											else
											{
												num7 = -899735216;
												num8 = num7;
											}
											num3 = num7 ^ (int)(num2 * 611287889);
											continue;
										}
										case 7u:
										{
											int num5;
											int num6;
											if (Level < current.Level)
											{
												num5 = -9170484;
												num6 = num5;
											}
											else
											{
												num5 = -946536354;
												num6 = num5;
											}
											num3 = num5 ^ (int)(num2 * 1217064867);
											continue;
										}
										case 3u:
											text = _206C_206D_202E_200B_202D_206C_200F_206A_200E_206A_206B_200E_206C_200D_202E_200F_200B_206A_202C_202E_206A_206A_200F_202D_206B_202D_202C_206B_200F_202C_206A_202C_206F_202D_202E_202A_202D_206D_206C_200C_202E(text, _206A_200D_206E_200C_202C_200C_202B_200C_200C_206F_200E_206F_200C_206C_200C_202E_206D_200D_200B_206A_206D_206E_202C_206E_200D_202D_200E_202C_202E_202E_206E_206A_206F_206E_200B_200E_206A_206F_202C_202E(ResourceStrings.ResStrings[401], (object)current.ToString2(), (object)current.Level));
											num3 = (int)((num2 * 136144590) ^ 0x746FC0CB);
											continue;
										case 6u:
											break;
										case 10u:
											text = _206C_206D_202E_200B_202D_206C_200F_206A_200E_206A_206B_200E_206C_200D_202E_200F_200B_206A_202C_202E_206A_206A_200F_202D_206B_202D_202C_206B_200F_202C_206A_202C_206F_202D_202E_202A_202D_206D_206C_200C_202E(text, _206A_200D_206E_200C_202C_200C_202B_200C_200C_206F_200E_206F_200C_206C_200C_202E_206D_200D_200B_206A_206D_206E_202C_206E_200D_202D_200E_202C_202E_202E_206E_206A_206F_206E_200B_200E_206A_206F_202C_202E(ResourceStrings.ResStrings[403], (object)current.ToString2(), (object)current.Level));
											num3 = -686814340;
											continue;
										case 8u:
											current = enumerator.Current;
											num3 = -1884954882;
											continue;
										case 1u:
											text = _206C_206D_202E_200B_202D_206C_200F_206A_200E_206A_206B_200E_206C_200D_202E_200F_200B_206A_202C_202E_206A_206A_200F_202D_206B_202D_202C_206B_200F_202C_206A_202C_206F_202D_202E_202A_202D_206D_206C_200C_202E(text, _202E_206E_202A_206B_202B_206B_202A_200B_202C_206D_206A_200E_202B_206A_206D_206F_206F_206A_206A_206C_202E_206C_206B_202B_200E_206E_202A_200C_206B_200B_200E_200B_200C_202A_200B_202D_206B_202C_200B_202C_202E(ResourceStrings.ResStrings[402], (object)current.Level));
											num3 = -1379936140;
											continue;
										case 4u:
											num3 = ((int)num2 * -1615639519) ^ 0x11A2BE94;
											continue;
										case 9u:
											num3 = ((int)num2 * -1978138260) ^ 0xA02EB60;
											continue;
										case 5u:
											text = _206C_206D_202E_200B_202D_206C_200F_206A_200E_206A_206B_200E_206C_200D_202E_200F_200B_206A_202C_202E_206A_206A_200F_202D_206B_202D_202C_206B_200F_202C_206A_202C_206F_202D_202E_202A_202D_206D_206C_200C_202E(text, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(390903560u));
											num3 = -1964850821;
											continue;
										case 2u:
											goto end_IL_0637;
										}
										goto IL_070e;
										continue;
										end_IL_0637:
										break;
									}
									break;
								}
							}
							goto IL_07f8;
						}
						IL_07f8:
						return text;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public override IEnumerable<Buff> Buffs => Skill.Buffs;

	public override float Power
	{
		get
		{
			float num = 0f;
			Trigger current = default(Trigger);
			while (true)
			{
				int num2 = 431876041;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num2 ^ 0x4724A8FA)) % 3)
					{
					case 0u:
						break;
					case 2u:
						if (base.Owner != null)
						{
							goto IL_0033;
						}
						goto IL_0149;
					default:
						{
							IEnumerator<Trigger> enumerator = base.Owner.GetTriggers(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(127416572u)).GetEnumerator();
							try
							{
								while (true)
								{
									IL_00b0:
									int num4;
									int num5;
									if (_206D_206F_206B_206E_206F_202C_206E_206F_200C_202B_202E_202A_202C_202E_206E_200D_202D_202E_206C_200C_206A_206F_202A_200F_200B_200D_206E_200B_202B_202B_206E_200B_206F_200E_200C_202D_200C_206F_202B_206A_202E((IEnumerator)enumerator))
									{
										num4 = 957530187;
										num5 = num4;
									}
									else
									{
										num4 = 1571233169;
										num5 = num4;
									}
									while (true)
									{
										switch ((num3 = (uint)(num4 ^ 0x4724A8FA)) % 6)
										{
										case 4u:
											num4 = 957530187;
											continue;
										default:
											goto end_IL_0064;
										case 3u:
											num += float.Parse(current.Argvs[1]);
											num4 = (int)((num3 * 1943916080) ^ 0x5D0C2350);
											continue;
										case 0u:
											break;
										case 5u:
											current = enumerator.Current;
											num4 = 1098851518;
											continue;
										case 2u:
										{
											int num6;
											int num7;
											if (_206D_206B_206E_206E_202E_202B_200E_200F_200F_200B_202B_206B_206D_200D_202E_206C_200B_200C_202B_200E_206B_206A_202D_206A_206D_200D_206B_202E_202C_206C_200D_202D_202C_200C_200F_200C_202C_206D_202E_202C_202E(current.Argvs[0], Name))
											{
												num6 = 187830865;
												num7 = num6;
											}
											else
											{
												num6 = 1673417376;
												num7 = num6;
											}
											num4 = num6 ^ ((int)num3 * -528184584);
											continue;
										}
										case 1u:
											goto end_IL_0064;
										}
										goto IL_00b0;
										continue;
										end_IL_0064:
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
										IL_0111:
										int num8 = 493640135;
										while (true)
										{
											switch ((num3 = (uint)(num8 ^ 0x4724A8FA)) % 3)
											{
											case 0u:
												break;
											default:
												goto end_IL_0116;
											case 2u:
												goto IL_0133;
											case 1u:
												goto end_IL_0116;
											}
											goto IL_0111;
											IL_0133:
											_200F_202D_200C_200C_206F_206F_202A_202B_206D_200C_202B_206C_206F_202C_202D_200F_206C_206D_206A_206A_206D_206D_200E_202B_202D_202E_206F_202D_202B_206F_202B_200F_200F_206B_206F_202E_200C_206A_202A_202B_202E((IDisposable)enumerator);
											num8 = (int)((num3 * 1323733176) ^ 0xEE010F1);
											continue;
											end_IL_0116:
											break;
										}
										break;
									}
								}
							}
							goto IL_0149;
						}
						IL_0149:
						return (float)_202C_202B_206C_206A_206C_202C_200E_202E_206D_200E_202D_200D_200B_200E_200D_200C_206A_200B_202A_206A_202D_206D_206B_206F_206A_202E_202C_206B_200B_206F_200D_202B_202B_206E_200E_200C_202B_200E_200D_200C_202E((decimal)(Skill.GetPower(Level) * (1f + num / 100f)), 2, MidpointRounding.AwayFromZero);
					}
					break;
					IL_0033:
					num2 = (int)((num3 * 315502601) ^ 0x6A50831B);
				}
			}
		}
	}

	public override int Size => Skill.GetCoverSize(level);

	public override SkillCoverType CoverType => Skill.GetCoverType(level);

	public Skill Skill
	{
		get
		{
			if (_206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E == null)
			{
				while (true)
				{
					int num = -1915494442;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ -1699298013)) % 4)
						{
						case 2u:
							break;
						case 1u:
							_206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E = ResourceManager.Get<Skill>(name);
							num = (int)((num2 * 1970047364) ^ 0x2FA71AF8);
							continue;
						case 3u:
							AttackTime = _206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E.attacktime;
							num = (int)(num2 * 1465441528) ^ -413348737;
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
			return _206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E;
		}
		set
		{
			_206A_206E_202C_200F_200E_206F_202C_202B_206F_202E_200B_206E_206F_202A_200F_202E_200C_200B_202D_200C_206B_206F_206D_206B_202C_206D_202B_202E_206A_200C_200F_200F_200D_206D_206B_200B_206C_200B_202B_200F_202E = value;
			if (value == null)
			{
				return;
			}
			while (true)
			{
				int num = -597333453;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -676962160)) % 3)
					{
					case 2u:
						break;
					default:
						return;
					case 1u:
						goto IL_002c;
					case 0u:
						return;
					}
					break;
					IL_002c:
					AttackTime = value.attacktime;
					num = (int)((num2 * 1077514959) ^ 0x2E441C64);
				}
			}
		}
	}

	[XmlIgnore]
	public int LevelupExp => Skill.GetLevelupExp(Level);

	[XmlIgnore]
	public int PreLevelupExp => Skill.GetLevelupExp(Level - 1);

	[XmlIgnore]
	public IEnumerable<string> Talents => new _202A_200E_206B_206A_206D_206D_200B_206F_200E_206C_206B_206B_202D_206A_200D_206F_206C_200D_202C_206A_206C_206B_206A_202C_206D_202B_206D_206D_200E_206C_206A_202B_206C_206D_206D_206F_200D_202B_202A_202C_202E(-2)
	{
		_202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E = this
	};

	public override float TiaoheScale => Skill.TiaoheScale;

	public override string Audio2 => Skill.Audio2;

	public override bool IsNpcSkill => Skill.IsNpc;

	public override int MaxLevel
	{
		get
		{
			int num = _206C_202D_200D_200F_202C_206E_200D_206C_206D_202A_200C_200F_200E_206E_202E_200D_200F_206B_206A_206A_202D_206A_206F_206E_200F_206F_202A_202E_200B_200F_202C_202B_206F_200C_200E_202D_202D_206E_206E_200E_202E(Level, ModData.GetSkillMaxLevel(Name));
			while (true)
			{
				int num2 = 1092325698;
				while (true)
				{
					uint num3;
					int num4;
					switch ((num3 = (uint)(num2 ^ 0x1941CDA7)) % 4)
					{
					case 2u:
						break;
					case 1u:
					{
						int num5;
						if (base.Owner != null)
						{
							num4 = -1728235358;
							num5 = num4;
						}
						else
						{
							num4 = -413813703;
							num5 = num4;
						}
						goto IL_0053;
					}
					case 0u:
						return _206D_200F_200D_202C_206C_202B_200E_202E_200C_202A_206F_206B_200C_200B_200F_202C_200F_200E_206A_200F_200F_206E_202A_200D_202C_200C_206B_206F_206E_200E_202D_206E_202B_206F_200B_206A_200E_200D_206B_206F_202E(num, CommonSettings.MAX_SKILL_LEVEL);
					default:
						return _206D_200F_200D_202C_206C_202B_200E_202E_200C_202A_206F_206B_200C_200B_200F_202C_200F_200E_206A_200F_200F_206E_202A_200D_202C_200C_206B_206F_206E_200E_202D_206E_202B_206F_200B_206A_200E_200D_206B_206F_202E(num, RuntimeData.Instance.isBattle ? BattleField.ROLE_MAX_SKILL_LEVEL[base.Owner] : base.Owner.MAX_SKILL_LEVEL);
					}
					break;
					IL_0053:
					num2 = num4 ^ ((int)num3 * -20510970);
				}
			}
		}
	}

	public override int MaxLevel2
	{
		get
		{
			int num = _206C_202D_200D_200F_202C_206E_200D_206C_206D_202A_200C_200F_200E_206E_202E_200D_200F_206B_206A_206A_202D_206A_206F_206E_200F_206F_202A_202E_200B_200F_202C_202B_206F_200C_200E_202D_202D_206E_206E_200E_202E(Level, ModData.SkillMaxLevels.ContainsKey(Name) ? ModData.SkillMaxLevels[Name] : 0);
			while (true)
			{
				int num2 = 1738265376;
				while (true)
				{
					uint num3;
					int num4;
					switch ((num3 = (uint)(num2 ^ 0x72EEAE85)) % 4)
					{
					case 3u:
						break;
					case 1u:
					{
						int num5;
						if (base.Owner != null)
						{
							num4 = 1099674699;
							num5 = num4;
						}
						else
						{
							num4 = 1777178509;
							num5 = num4;
						}
						goto IL_006d;
					}
					case 2u:
						return _206D_200F_200D_202C_206C_202B_200E_202E_200C_202A_206F_206B_200C_200B_200F_202C_200F_200E_206A_200F_200F_206E_202A_200D_202C_200C_206B_206F_206E_200E_202D_206E_202B_206F_200B_206A_200E_200D_206B_206F_202E(num, CommonSettings.MAX_SKILL_LEVEL);
					default:
						return _206D_200F_200D_202C_206C_202B_200E_202E_200C_202A_206F_206B_200C_200B_200F_202C_200F_200E_206A_200F_200F_206E_202A_200D_202C_200C_206B_206F_206E_200E_202D_206E_202B_206F_200B_206A_200E_200D_206B_206F_202E(num, RuntimeData.Instance.isBattle ? BattleField.ROLE_MAX_SKILL_LEVEL[base.Owner] : base.Owner.MAX_SKILL_LEVEL);
					}
					break;
					IL_006d:
					num2 = num4 ^ ((int)num3 * -1070701570);
				}
			}
		}
	}

	public void RefreshUniquSkills()
	{
		UniqueSkills.Clear();
		using List<UniqueSkill>.Enumerator enumerator = Skill.UniqueSkills.GetEnumerator();
		while (true)
		{
			int num;
			int num2;
			if (enumerator.MoveNext())
			{
				num = 1794090637;
				num2 = num;
			}
			else
			{
				num = 999430227;
				num2 = num;
			}
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num ^ 0x44E0441E)) % 4)
				{
				case 0u:
					num = 1794090637;
					continue;
				default:
					return;
				case 3u:
				{
					UniqueSkill current = enumerator.Current;
					UniqueSkills.Add(new UniqueSkillInstance(current, this));
					num = 961710308;
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

	public override bool TryAddExp(int exp)
	{
		if (RuntimeData.Instance.isBattle)
		{
			goto IL_000f;
		}
		goto IL_02e4;
		IL_000f:
		int num = 1045237159;
		goto IL_0014;
		IL_0014:
		bool flag = default(bool);
		int mAX_SKILL_LEVEL = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x6CE43B2E)) % 22)
			{
			case 20u:
				break;
			case 1u:
				flag = true;
				num = 401353389;
				continue;
			case 2u:
				Exp += exp;
				num = 336999181;
				continue;
			case 15u:
			{
				int num9;
				int num10;
				if (level != -(int)level2)
				{
					num9 = 2100194549;
					num10 = num9;
				}
				else
				{
					num9 = 666504463;
					num10 = num9;
				}
				num = num9 ^ ((int)num2 * -378617629);
				continue;
			}
			case 5u:
				level2 -= 1f;
				num = ((int)num2 * -435911689) ^ 0x7145F579;
				continue;
			case 0u:
			{
				int num5;
				int num6;
				if (level > mAX_SKILL_LEVEL)
				{
					num5 = 1194983855;
					num6 = num5;
				}
				else
				{
					num5 = 217457933;
					num6 = num5;
				}
				num = num5 ^ ((int)num2 * -6176386);
				continue;
			}
			case 21u:
				mAX_SKILL_LEVEL = base.Owner.MAX_SKILL_LEVEL;
				num = 401353389;
				continue;
			case 13u:
				level = mAX_SKILL_LEVEL;
				num = ((int)num2 * -190351431) ^ -333972787;
				continue;
			case 3u:
				RuntimeData.Instance.RefreshTeamMemberPanel(base.Owner, refreshImage: false, refreshText: true);
				num = ((int)num2 * -1452949656) ^ -1051825384;
				continue;
			case 17u:
				Exp = LevelupExp;
				num = ((int)num2 * -1776976154) ^ -19058058;
				continue;
			case 14u:
				level2 = 0f - (float)mAX_SKILL_LEVEL;
				num = (int)((num2 * 1069952321) ^ 0x42E58577);
				continue;
			case 6u:
				Exp -= LevelupExp;
				level++;
				num = 1550586577;
				continue;
			case 9u:
			{
				int num7;
				int num8;
				if (base.Owner.HasTalent(ResourceStrings.ResStrings[496]))
				{
					num7 = 1112754893;
					num8 = num7;
				}
				else
				{
					num7 = 1539984495;
					num8 = num7;
				}
				num = num7 ^ (int)(num2 * 797513207);
				continue;
			}
			case 19u:
				return TryAddExpBattle(exp);
			case 12u:
				goto IL_0220;
			case 7u:
				RefreshUniquSkills();
				num = ((int)num2 * -1668659235) ^ -1148637064;
				continue;
			case 8u:
			{
				exp += base.Owner.AttributesFinal[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(136168559u)] / 30;
				int num3;
				int num4;
				if (!base.Owner.HasTalent(ResourceStrings.ResStrings[160]))
				{
					num3 = -316383989;
					num4 = num3;
				}
				else
				{
					num3 = -156161106;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 1783060274);
				continue;
			}
			case 18u:
				goto IL_02b3;
			case 4u:
				Exp += exp * 2;
				num = 336999181;
				continue;
			case 10u:
				goto IL_02e4;
			case 11u:
				goto IL_02f0;
			default:
				return flag;
			}
			break;
			IL_02f0:
			int num11;
			if (Exp < LevelupExp)
			{
				num = 429865236;
				num11 = num;
			}
			else
			{
				num = 1343206722;
				num11 = num;
			}
			continue;
			IL_02b3:
			int num12;
			if (flag)
			{
				num = 1945702581;
				num12 = num;
			}
			else
			{
				num = 2019302960;
				num12 = num;
			}
			continue;
			IL_0220:
			int num13;
			if (level >= MaxLevel)
			{
				num = 949726821;
				num13 = num;
			}
			else
			{
				num = 114886870;
				num13 = num;
			}
		}
		goto IL_000f;
		IL_02e4:
		flag = false;
		num = 395488537;
		goto IL_0014;
	}

	public bool HasTalent(string talent)
	{
		return Talents.Contains(talent);
	}

	public void SkillVariables()
	{
		PowerBattle = Power;
		CostMpBattle = CostMp;
		using List<UniqueSkillInstance>.Enumerator enumerator = UniqueSkills.GetEnumerator();
		while (true)
		{
			int num;
			int num2;
			if (enumerator.MoveNext())
			{
				num = 1483148739;
				num2 = num;
			}
			else
			{
				num = 756669326;
				num2 = num;
			}
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num ^ 0x6EA71662)) % 4)
				{
				case 3u:
					num = 1483148739;
					continue;
				default:
					return;
				case 1u:
				{
					UniqueSkillInstance current = enumerator.Current;
					current.PowerBattle = current.Power;
					current.CostMpBattle = current.CostMp;
					num = 924741152;
					continue;
				}
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public List<string> GetEQTriggers(string name)
	{
		List<string> list = new List<string>();
		if (IsUsed)
		{
			using List<Trigger>.Enumerator enumerator = Skill.Triggers.GetEnumerator();
			Trigger current = default(Trigger);
			while (true)
			{
				IL_00b0:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 1922821903;
					num2 = num;
				}
				else
				{
					num = 1790314880;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x102F9731)) % 7)
					{
					case 0u:
						num = 1922821903;
						continue;
					default:
						goto end_IL_002c;
					case 6u:
						current = enumerator.Current;
						num = 174214032;
						continue;
					case 4u:
						list.Add(current.ArgvsString);
						num = (int)(num3 * 646851972) ^ -456523197;
						continue;
					case 1u:
					{
						int num6;
						int num7;
						if (Level < current.Level)
						{
							num6 = 896088949;
							num7 = num6;
						}
						else
						{
							num6 = 2132063780;
							num7 = num6;
						}
						num = num6 ^ ((int)num3 * -1105211555);
						continue;
					}
					case 2u:
						break;
					case 3u:
					{
						int num4;
						int num5;
						if (_206D_206B_206E_206E_202E_202B_200E_200F_200F_200B_202B_206B_206D_200D_202E_206C_200B_200C_202B_200E_206B_206A_202D_206A_206D_200D_206B_202E_202C_206C_200D_202D_202C_200C_200F_200C_202C_206D_202E_202C_202E(current.Name, name))
						{
							num4 = -225604931;
							num5 = num4;
						}
						else
						{
							num4 = -467968159;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -1523344866);
						continue;
					}
					case 5u:
						goto end_IL_002c;
					}
					goto IL_00b0;
					continue;
					end_IL_002c:
					break;
				}
				break;
			}
		}
		return list;
	}

	internal bool TryAddExpBattle(int exp)
	{
		bool flag = false;
		if (level == -(int)level2)
		{
			int num3 = default(int);
			SkillInstance current = default(SkillInstance);
			while (true)
			{
				int num = 1543399843;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x2C65BF74)) % 22)
					{
					case 0u:
						break;
					case 8u:
					{
						int num8;
						int num9;
						if (level > num3)
						{
							num8 = -307497769;
							num9 = num8;
						}
						else
						{
							num8 = -1718416496;
							num9 = num8;
						}
						num = num8 ^ (int)(num2 * 894021727);
						continue;
					}
					case 7u:
						goto IL_00ae;
					case 11u:
						num = ((int)num2 * -1105870256) ^ -217251013;
						continue;
					case 21u:
						Exp = LevelupExp;
						num = (int)((num2 * 824302098) ^ 0x130F9E8D);
						continue;
					case 19u:
						num = ((int)num2 * -1457408632) ^ 0x33AC5491;
						continue;
					case 4u:
						num = (int)((num2 * 1794178937) ^ 0x39F118F6);
						continue;
					case 2u:
						level++;
						num = ((int)num2 * -331635102) ^ -2041318941;
						continue;
					case 13u:
						level2 = 0f - (float)num3;
						num = (int)(num2 * 781350351) ^ -600790579;
						continue;
					case 18u:
						num3 = BattleField.ROLE_MAX_SKILL_LEVEL[base.Owner];
						num = 1776499759;
						continue;
					case 9u:
					{
						exp += base.Owner.AttributesFinal[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2301880830u)] / 30;
						int num6;
						int num7;
						if (!base.Owner.BuiltInTalents[155])
						{
							num6 = 620309995;
							num7 = num6;
						}
						else
						{
							num6 = 77606144;
							num7 = num6;
						}
						num = num6 ^ ((int)num2 * -517452056);
						continue;
					}
					case 16u:
						flag = true;
						num = 151388491;
						continue;
					case 10u:
						RefreshUniquSkills();
						num = (int)(num2 * 796926895) ^ -593205672;
						continue;
					case 1u:
						goto IL_01e8;
					case 12u:
						Exp += exp;
						num = 1371077028;
						continue;
					case 6u:
						Exp -= LevelupExp;
						num = 10339154;
						continue;
					case 3u:
					{
						int num4;
						int num5;
						if (base.Owner.BuiltInTalents[156])
						{
							num4 = 483893165;
							num5 = num4;
						}
						else
						{
							num4 = 1935509465;
							num5 = num4;
						}
						num = num4 ^ (int)(num2 * 189431651);
						continue;
					}
					case 20u:
						Exp += exp * 2;
						num = 1300218390;
						continue;
					case 5u:
						level = num3;
						num = (int)((num2 * 1695615874) ^ 0x60BE4F15);
						continue;
					case 17u:
						level2 -= 1f;
						num = (int)(num2 * 1296574604) ^ -1940120796;
						continue;
					case 15u:
						goto IL_02cc;
					default:
						goto IL_02ee;
					}
					break;
					IL_02ee:
					using (List<SkillInstance>.Enumerator enumerator = base.Owner.Skills.GetEnumerator())
					{
						while (true)
						{
							IL_0377:
							int num10;
							int num11;
							if (enumerator.MoveNext())
							{
								num10 = 2038583374;
								num11 = num10;
							}
							else
							{
								num10 = 1033510493;
								num11 = num10;
							}
							while (true)
							{
								switch ((num2 = (uint)(num10 ^ 0x2C65BF74)) % 6)
								{
								case 0u:
									num10 = 2038583374;
									continue;
								default:
									goto end_IL_0306;
								case 4u:
									current = enumerator.Current;
									num10 = 1735257886;
									continue;
								case 1u:
									current.SkillVariables();
									num10 = (int)((num2 * 1141120037) ^ 0x2BDC2118);
									continue;
								case 2u:
								{
									int num12;
									int num13;
									if (!current.IsUsed)
									{
										num12 = -189379875;
										num13 = num12;
									}
									else
									{
										num12 = -811002451;
										num13 = num12;
									}
									num10 = num12 ^ (int)(num2 * 1987351886);
									continue;
								}
								case 5u:
									break;
								case 3u:
									goto end_IL_0306;
								}
								goto IL_0377;
								continue;
								end_IL_0306:
								break;
							}
							break;
						}
					}
					base.Owner.EquippedInternalSkill.SkillVariables();
					goto end_IL_0015;
					IL_00ae:
					if (!flag)
					{
						goto end_IL_0015;
					}
					num = 1341337604;
					continue;
					IL_02cc:
					int num14;
					if (Exp >= LevelupExp)
					{
						num = 205705903;
						num14 = num;
					}
					else
					{
						num = 860729737;
						num14 = num;
					}
					continue;
					IL_01e8:
					int num15;
					if (level >= MaxLevel)
					{
						num = 299400633;
						num15 = num;
					}
					else
					{
						num = 516293908;
						num15 = num;
					}
				}
				continue;
				end_IL_0015:
				break;
			}
		}
		return flag;
	}

	static string _206C_206D_202E_200B_202D_206C_200F_206A_200E_206A_206B_200E_206C_200D_202E_200F_200B_206A_202C_202E_206A_206A_200F_202D_206B_202D_202C_206B_200F_202C_206A_202C_206F_202D_202E_202A_202D_206D_206C_200C_202E(string P_0, string P_1)
	{
		return P_0 + P_1;
	}

	static string _200B_206A_206D_206A_202E_206F_206E_202D_206C_206B_202C_202A_206C_200F_206E_202C_206A_202E_202C_202B_206D_200B_206E_200C_206E_202E_200C_202E_202B_206B_206C_200C_202D_206B_202C_206E_202D_206A_200E_202E(string P_0, object[] P_1)
	{
		return string.Format(P_0, P_1);
	}

	static string _206A_200D_206E_200C_202C_200C_202B_200C_200C_206F_200E_206F_200C_206C_200C_202E_206D_200D_200B_206A_206D_206E_202C_206E_200D_202D_200E_202C_202E_202E_206E_206A_206F_206E_200B_200E_206A_206F_202C_202E(string P_0, object P_1, object P_2)
	{
		return string.Format(P_0, P_1, P_2);
	}

	static int _206D_200F_200D_202C_206C_202B_200E_202E_200C_202A_206F_206B_200C_200B_200F_202C_200F_200E_206A_200F_200F_206E_202A_200D_202C_200C_206B_206F_206E_200E_202D_206E_202B_206F_200B_206A_200E_200D_206B_206F_202E(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	static string _202E_206E_202A_206B_202B_206B_202A_200B_202C_206D_206A_200E_202B_206A_206D_206F_206F_206A_206A_206C_202E_206C_206B_202B_200E_206E_202A_200C_206B_200B_200E_200B_200C_202A_200B_202D_206B_202C_200B_202C_202E(string P_0, object P_1)
	{
		return string.Format(P_0, P_1);
	}

	static bool _206D_206B_206E_206E_202E_202B_200E_200F_200F_200B_202B_206B_206D_200D_202E_206C_200B_200C_202B_200E_206B_206A_202D_206A_206D_200D_206B_202E_202C_206C_200D_202D_202C_200C_200F_200C_202C_206D_202E_202C_202E(string P_0, string P_1)
	{
		return P_0 == P_1;
	}

	static bool _206D_206F_206B_206E_206F_202C_206E_206F_200C_202B_202E_202A_202C_202E_206E_200D_202D_202E_206C_200C_206A_206F_202A_200F_200B_200D_206E_200B_202B_202B_206E_200B_206F_200E_200C_202D_200C_206F_202B_206A_202E(IEnumerator P_0)
	{
		return P_0.MoveNext();
	}

	static void _200F_202D_200C_200C_206F_206F_202A_202B_206D_200C_202B_206C_206F_202C_202D_200F_206C_206D_206A_206A_206D_206D_200E_202B_202D_202E_206F_202D_202B_206F_202B_200F_200F_206B_206F_202E_200C_206A_202A_202B_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}

	static decimal _202C_202B_206C_206A_206C_202C_200E_202E_206D_200E_202D_200D_200B_200E_200D_200C_206A_200B_202A_206A_202D_206D_206B_206F_206A_202E_202C_206B_200B_206F_200D_202B_202B_206E_200E_200C_202B_200E_200D_200C_202E(decimal P_0, int P_1, MidpointRounding P_2)
	{
		return Math.Round(P_0, P_1, P_2);
	}

	static int _206C_202D_200D_200F_202C_206E_200D_206C_206D_202A_200C_200F_200E_206E_202E_200D_200F_206B_206A_206A_202D_206A_206F_206E_200F_206F_202A_202E_200B_200F_202C_202B_206F_200C_200E_202D_202D_206E_206E_200E_202E(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}
}
