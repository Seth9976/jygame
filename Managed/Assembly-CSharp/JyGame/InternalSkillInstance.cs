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

[XmlType("internal_skill")]
public class InternalSkillInstance : SkillBox
{
	[CompilerGenerated]
	private sealed class _200B_200D_200F_202D_206B_200D_206D_202B_206A_206B_202A_206D_202D_202C_200B_202C_200D_202D_206E_206F_206E_202B_200B_206A_200C_200E_200D_206D_206A_206B_202D_206B_206B_206C_200C_206B_206F_202E_202C_200E_202E : IEnumerable<string>, IEnumerator<string>, IEnumerator, IDisposable, IEnumerable
	{
		private int _200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E;

		private string _200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E;

		private int _200B_202B_206E_200C_202C_200D_206F_202E_200F_206A_200C_202C_200B_202D_200F_206E_202D_206C_200B_202C_206C_206A_206E_206C_202B_206D_206E_200E_206E_202D_206E_202E_202E_202A_206D_206E_206D_202C_202D_202E;

		public InternalSkillInstance _202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E;

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
		public _200B_200D_200F_202D_206B_200D_206D_202B_206A_206B_202A_206D_202D_202C_200B_202C_200D_202D_206E_206F_206E_202B_200B_206A_200C_200E_200D_206D_206A_206B_202D_206B_206B_206C_200C_206B_206F_202E_202C_200E_202E(int P_0)
		{
			_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = P_0;
			_200B_202B_206E_200C_202C_200D_206F_202E_200F_206A_200C_202C_200B_202D_200F_206E_202D_206C_200B_202C_206C_206A_206E_206C_202B_206D_206E_200E_206E_202D_206E_202E_202E_202A_206D_206E_206D_202C_202D_202E = _206B_206B_206F_200F_202D_206F_200F_200E_202B_200E_200E_206C_200F_200F_202D_206D_206C_200C_200C_206F_202E_206B_202C_202B_200E_202D_206A_202C_200C_206B_202D_200C_202E_206D_200D_200E_200B_206D_202B_206C_202E(_200E_202D_206B_202B_206F_202E_200D_206E_200C_200F_200C_202D_200C_206B_202E_202D_202A_200E_200D_200B_206F_200E_200D_202E_200D_206A_202E_202A_206D_206C_202E_206C_202A_202D_200D_200C_202D_206B_206F_202E_202E());
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E;
			if (num != -3)
			{
				while (true)
				{
					int num2 = -623819914;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num2 ^ -620235476)) % 3)
						{
						case 2u:
							break;
						case 1u:
							if ((uint)(num - 1) <= 1u)
							{
								num2 = ((int)num3 * -1540920053) ^ 0x1437CD5;
								continue;
							}
							return;
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
			try
			{
			}
			finally
			{
				_202D_202A_202A_200E_206E_202E_206C_202C_206F_202C_200C_202E_202A_206E_202B_202D_202C_206F_206C_206A_202A_200F_206A_200F_206D_200B_200C_202C_202B_206E_200E_206C_202D_200D_202E_202D_206D_206D_202B_202C_202E();
			}
		}

		private bool MoveNext()
		{
			bool result = default(bool);
			try
			{
				int num = _200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E;
				InternalSkillInstance internalSkillInstance = _202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E;
				int num2;
				switch (num)
				{
				default:
					num2 = 1351957261;
					goto IL_0025;
				case 1:
					goto IL_0261;
				case 0:
					goto IL_02cf;
				case 2:
					goto IL_032e;
					IL_0025:
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num2 ^ 0x111F7B58)) % 26)
						{
						case 6u:
							break;
						default:
							goto end_IL_000f;
						case 9u:
							result = false;
							num2 = ((int)num3 * -1367337873) ^ 0x186E1625;
							continue;
						case 23u:
							_202B_202A_206B_202A_206D_206A_206D_202D_206D_206F_202A_202A_202E_206A_200B_202A_200F_206E_206B_200E_202D_200D_202D_206B_200F_200E_200C_206A_200C_206E_202E_200E_200F_206A_206D_202A_200D_200D_202B_200C_202E = null;
							num2 = 1059824959;
							continue;
						case 15u:
							goto IL_00c7;
						case 4u:
						{
							int num6;
							int num7;
							if (internalSkillInstance.Level < _202B_202A_206B_202A_206D_206A_206D_202D_206D_206F_202A_202A_202E_206A_200B_202A_200F_206E_206B_200E_202D_200D_202D_206B_200F_200E_200C_206A_200C_206E_202E_200E_200F_206A_206D_202A_200D_200D_202B_200C_202E.Level)
							{
								num6 = 2095216635;
								num7 = num6;
							}
							else
							{
								num6 = 532745925;
								num7 = num6;
							}
							num2 = num6 ^ (int)(num3 * 339416653);
							continue;
						}
						case 20u:
							result = true;
							num2 = ((int)num3 * -2084878199) ^ -466371318;
							continue;
						case 19u:
						{
							int num8;
							int num9;
							if (internalSkillInstance.IsUsed)
							{
								num8 = 1093604247;
								num9 = num8;
							}
							else
							{
								num8 = 178505668;
								num9 = num8;
							}
							num2 = num8 ^ ((int)num3 * -2085119861);
							continue;
						}
						case 8u:
							_200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E = _202B_202A_206B_202A_206D_206A_206D_202D_206D_206F_202A_202A_202E_206A_200B_202A_200F_206E_206B_200E_202D_200D_202D_206B_200F_200E_200C_206A_200C_206E_202E_200E_200F_206A_206D_202A_200D_200D_202B_200C_202E.Argvs[0];
							num2 = (int)(num3 * 1691700706) ^ -250398160;
							continue;
						case 24u:
							result = true;
							goto end_IL_000f;
						case 1u:
						{
							int num4;
							int num5;
							if (internalSkillInstance.Level >= _202B_202A_206B_202A_206D_206A_206D_202D_206D_206F_202A_202A_202E_206A_200B_202A_200F_206E_206B_200E_202D_200D_202D_206B_200F_200E_200C_206A_200C_206E_202E_200E_200F_206A_206D_202A_200D_200D_202B_200C_202E.Level)
							{
								num4 = -1954441007;
								num5 = num4;
							}
							else
							{
								num4 = -167791549;
								num5 = num4;
							}
							num2 = num4 ^ ((int)num3 * -1316489142);
							continue;
						}
						case 0u:
							goto IL_01c0;
						case 3u:
							_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E = internalSkillInstance.InternalSkill.Triggers.GetEnumerator();
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -3;
							num2 = ((int)num3 * -690877730) ^ -1312884239;
							continue;
						case 13u:
							_200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E = _202B_202A_206B_202A_206D_206A_206D_202D_206D_206F_202A_202A_202E_206A_200B_202A_200F_206E_206B_200E_202D_200D_202D_206B_200F_200E_200C_206A_200C_206E_202E_200E_200F_206A_206D_202A_200D_200D_202B_200C_202E.Argvs[0];
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 2;
							num2 = (int)((num3 * 1703590474) ^ 0x5B36C80);
							continue;
						case 17u:
							goto IL_0261;
						case 18u:
							goto end_IL_000f;
						case 2u:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 1;
							num2 = (int)(num3 * 329191240) ^ -81809030;
							continue;
						case 22u:
							result = false;
							num2 = (int)((num3 * 2033938004) ^ 0x1051FF85);
							continue;
						case 5u:
							_202D_202A_202A_200E_206E_202E_206C_202C_206F_202C_200C_202E_202A_206E_202B_202D_202C_206F_206C_206A_202A_200F_206A_200F_206D_200B_200C_202C_202B_206E_200E_206C_202D_200D_202E_202D_206D_206D_202B_202C_202E();
							num2 = ((int)num3 * -738104405) ^ -801232950;
							continue;
						case 10u:
							goto IL_02cf;
						case 14u:
							goto IL_02e0;
						case 25u:
							_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E = default(List<Trigger>.Enumerator);
							num2 = ((int)num3 * -835229260) ^ -581477686;
							continue;
						case 7u:
							goto IL_032e;
						case 12u:
							goto end_IL_000f;
						case 16u:
							num2 = ((int)num3 * -1220886287) ^ -1069819115;
							continue;
						case 11u:
							num2 = (int)((num3 * 1131333226) ^ 0x533053D9);
							continue;
						case 21u:
							goto end_IL_000f;
						}
						break;
						IL_02e0:
						int num10;
						if (!_202B_200C_202A_202E_206F_206D_206D_206E_202E_206C_206D_200E_202B_200F_206F_202C_206D_206B_206F_206F_206D_206B_200D_202D_206F_206E_200E_206A_206B_202D_202A_200F_206C_202C_200C_202A_206E_206D_202D_206C_202E(_202B_202A_206B_202A_206D_206A_206D_202D_206D_206F_202A_202A_202E_206A_200B_202A_200F_206E_206B_200E_202D_200D_202D_206B_200F_200E_200C_206A_200C_206E_202E_200E_200F_206A_206D_202A_200D_200D_202B_200C_202E.Name, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1480101968u)))
						{
							num2 = 1929897829;
							num10 = num2;
						}
						else
						{
							num2 = 1706737167;
							num10 = num2;
						}
						continue;
						IL_01c0:
						_202B_202A_206B_202A_206D_206A_206D_202D_206D_206F_202A_202A_202E_206A_200B_202A_200F_206E_206B_200E_202D_200D_202D_206B_200F_200E_200C_206A_200C_206E_202E_200E_200F_206A_206D_202A_200D_200D_202B_200C_202E = _206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E.Current;
						int num11;
						if (_202B_200C_202A_202E_206F_206D_206D_206E_202E_206C_206D_200E_202B_200F_206F_202C_206D_206B_206F_206F_206D_206B_200D_202D_206F_206E_200E_206A_206B_202D_202A_200F_206C_202C_200C_202A_206E_206D_202D_206C_202E(_202B_202A_206B_202A_206D_206A_206D_202D_206D_206F_202A_202A_202E_206A_200B_202A_200F_206E_206B_200E_202D_200D_202D_206B_200F_200E_200C_206A_200C_206E_202E_200E_200F_206A_206D_202A_200D_200D_202B_200C_202E.Name, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(407078395u)))
						{
							num2 = 1569211726;
							num11 = num2;
						}
						else
						{
							num2 = 265532602;
							num11 = num2;
						}
						continue;
						IL_00c7:
						int num12;
						if (_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E.MoveNext())
						{
							num2 = 692368978;
							num12 = num2;
						}
						else
						{
							num2 = 1111757743;
							num12 = num2;
						}
					}
					goto default;
					IL_032e:
					_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -3;
					num2 = 1929897829;
					goto IL_0025;
					IL_02cf:
					_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
					num2 = 313034049;
					goto IL_0025;
					IL_0261:
					_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -3;
					num2 = 1284143144;
					goto IL_0025;
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

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw _206F_202B_200C_200E_206A_202A_200E_206C_202D_206E_202D_206D_200E_200B_202A_200F_202E_202B_202D_206E_200E_202B_202E_202C_200E_202E_206B_206A_202E_200C_200D_202D_200F_206F_200B_206B_206D_202C_200B_202C_202E();
		}

		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			if (_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E == -2)
			{
				goto IL_000d;
			}
			goto IL_00a3;
			IL_000d:
			int num = 976778398;
			goto IL_0012;
			IL_0012:
			_200B_200D_200F_202D_206B_200D_206D_202B_206A_206B_202A_206D_202D_202C_200B_202C_200D_202D_206E_206F_206E_202B_200B_206A_200C_200E_200D_206D_206A_206B_202D_206B_206B_206C_200C_206B_206F_202E_202C_200E_202E obj = default(_200B_200D_200F_202D_206B_200D_206D_202B_206A_206B_202A_206D_202D_202C_200B_202C_200D_202D_206E_206F_206E_202B_200B_206A_200C_200E_200D_206D_206A_206B_202D_206B_206B_206C_200C_206B_206F_202E_202C_200E_202E);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6760C866)) % 7)
				{
				case 4u:
					break;
				case 2u:
				{
					int num3;
					int num4;
					if (_200B_202B_206E_200C_202C_200D_206F_202E_200F_206A_200C_202C_200B_202D_200F_206E_202D_206C_200B_202C_206C_206A_206E_206C_202B_206D_206E_200E_206E_202D_206E_202E_202E_202A_206D_206E_206D_202C_202D_202E == _206B_206B_206F_200F_202D_206F_200F_200E_202B_200E_200E_206C_200F_200F_202D_206D_206C_200C_200C_206F_202E_206B_202C_202B_200E_202D_206A_202C_200C_206B_202D_200C_202E_206D_200D_200E_200B_206D_202B_206C_202E(_200E_202D_206B_202B_206F_202E_200D_206E_200C_200F_200C_202D_200C_206B_202E_202D_202A_200E_200D_200B_206F_200E_200D_202E_200D_206A_202E_202A_206D_206C_202E_206C_202A_202D_200D_200C_202D_206B_206F_202E_202E()))
					{
						num3 = 156997553;
						num4 = num3;
					}
					else
					{
						num3 = 545070590;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1543432844);
					continue;
				}
				case 6u:
					_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 0;
					obj = this;
					num = ((int)num2 * -1596983171) ^ 0x634FAF6;
					continue;
				case 0u:
					obj._202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E = _202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E;
					num = ((int)num2 * -1726959265) ^ -1974897644;
					continue;
				case 3u:
					goto IL_00a3;
				case 5u:
					num = ((int)num2 * -1921594995) ^ 0x6427D2C4;
					continue;
				default:
					return obj;
				}
				break;
			}
			goto IL_000d;
			IL_00a3:
			obj = new _200B_200D_200F_202D_206B_200D_206D_202B_206A_206B_202A_206D_202D_202C_200B_202C_200D_202D_206E_206F_206E_202B_200B_206A_200C_200E_200D_206D_206A_206B_202D_206B_206B_206C_200C_206B_206F_202E_202C_200E_202E(0);
			num = 151511847;
			goto IL_0012;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<string>)this).GetEnumerator();
		}

		static Thread _200E_202D_206B_202B_206F_202E_200D_206E_200C_200F_200C_202D_200C_206B_202E_202D_202A_200E_200D_200B_206F_200E_200D_202E_200D_206A_202E_202A_206D_206C_202E_206C_202A_202D_200D_200C_202D_206B_206F_202E_202E()
		{
			return Thread.CurrentThread;
		}

		static int _206B_206B_206F_200F_202D_206F_200F_200E_202B_200E_200E_206C_200F_200F_202D_206D_206C_200C_200C_206F_202E_206B_202C_202B_200E_202D_206A_202C_200C_206B_202D_200C_202E_206D_200D_200E_200B_206D_202B_206C_202E(Thread P_0)
		{
			return P_0.ManagedThreadId;
		}

		static bool _202B_200C_202A_202E_206F_206D_206D_206E_202E_206C_206D_200E_202B_200F_206F_202C_206D_206B_206F_206F_206D_206B_200D_202D_206F_206E_200E_206A_206B_202D_202A_200F_206C_202C_200C_202A_206E_206D_202D_206C_202E(string P_0, string P_1)
		{
			return P_0 == P_1;
		}

		static NotSupportedException _206F_202B_200C_200E_206A_202A_200E_206C_202D_206E_202D_206D_200E_200B_202A_200F_202E_202B_202D_206E_200E_202B_202E_202C_200E_202E_206B_206A_202E_200C_200D_202D_200F_206F_200B_206B_206D_202C_200B_202C_202E()
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

	private InternalSkill _206B_200B_200C_202D_202A_206E_200B_202C_206A_200D_200E_200D_206B_202A_202B_202E_200F_202D_202D_202A_200D_200B_202A_200E_200B_202A_202C_206E_200F_206E_206C_202B_206E_202A_200C_206A_202B_206F_206D_200E_202E;

	[XmlIgnore]
	internal float level2;

	[XmlIgnore]
	public int YinBattle;

	[XmlIgnore]
	public int YangBattle;

	[XmlIgnore]
	public float AttackBattle;

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

	public int Yin
	{
		get
		{
			if (CommonSettings.MOD_KEY() == 1)
			{
				int num5 = default(int);
				while (true)
				{
					int num = -1058875719;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ -1202541448)) % 10)
						{
						case 7u:
							break;
						case 3u:
						{
							int num6;
							int num7;
							if (base.Owner.HasTalent(ResourceStrings.ResStrings[1219]))
							{
								num6 = 2047410594;
								num7 = num6;
							}
							else
							{
								num6 = 543296183;
								num7 = num6;
							}
							num = num6 ^ (int)(num2 * 2023728130);
							continue;
						}
						case 9u:
							num5 = (int)((double)num5 * 1.4);
							num = ((int)num2 * -2120668616) ^ 0x39851688;
							continue;
						case 5u:
							goto IL_00a2;
						case 8u:
							num = ((int)num2 * -1141507210) ^ 0x2EA65940;
							continue;
						case 2u:
							return num5;
						case 1u:
							num5 = InternalSkill.Yin * Level / 10;
							num = (int)((num2 * 1103062547) ^ 0x452E8DB1);
							continue;
						case 4u:
							num5 = (int)((double)num5 * 1.4);
							num = ((int)num2 * -164726954) ^ -1848216408;
							continue;
						case 6u:
						{
							int num3;
							int num4;
							if (base.Owner == null)
							{
								num3 = -605990628;
								num4 = num3;
							}
							else
							{
								num3 = -1374566643;
								num4 = num3;
							}
							num = num3 ^ (int)(num2 * 1284038726);
							continue;
						}
						default:
							goto end_IL_000b;
						}
						break;
						IL_00a2:
						int num8;
						if (!base.Owner.HasTalent(ResourceStrings.ResStrings[1220]))
						{
							num = -657511168;
							num8 = num;
						}
						else
						{
							num = -814266881;
							num8 = num;
						}
					}
					continue;
					end_IL_000b:
					break;
				}
			}
			return InternalSkill.Yin * Level / 10;
		}
	}

	public int Yang
	{
		get
		{
			int num = InternalSkill.Yang * Level / 10;
			if (base.Owner != null)
			{
				goto IL_0021;
			}
			goto IL_00dc;
			IL_0021:
			int num2 = 74049171;
			goto IL_0026;
			IL_0026:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x3627EFE0)) % 11)
				{
				case 8u:
					break;
				case 2u:
				{
					int num8;
					int num9;
					if (base.Owner.HasTalent(ResourceStrings.ResStrings[1219]))
					{
						num8 = 993524901;
						num9 = num8;
					}
					else
					{
						num8 = 525937431;
						num9 = num8;
					}
					num2 = num8 ^ (int)(num3 * 277461995);
					continue;
				}
				case 1u:
					num = (int)((double)num * 1.3);
					num2 = (int)(num3 * 589348885) ^ -1164873646;
					continue;
				case 9u:
					num = (int)((double)num * 1.4);
					num2 = (int)(num3 * 1117600817) ^ -1659947688;
					continue;
				case 4u:
					goto IL_00dc;
				case 10u:
					num2 = ((int)num3 * -1435677645) ^ -1694337663;
					continue;
				case 0u:
					num = (int)((double)num * 1.4);
					num2 = (int)(num3 * 1797262236) ^ -1285102512;
					continue;
				case 7u:
					goto IL_012a;
				case 3u:
				{
					int num6;
					int num7;
					if (base.Owner == null)
					{
						num6 = 897524809;
						num7 = num6;
					}
					else
					{
						num6 = 407073003;
						num7 = num6;
					}
					num2 = num6 ^ ((int)num3 * -858069891);
					continue;
				}
				case 5u:
				{
					int num4;
					int num5;
					if (base.Owner.HasTalent(ResourceStrings.ResStrings[311]))
					{
						num4 = 495103800;
						num5 = num4;
					}
					else
					{
						num4 = 806242442;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 1987168200);
					continue;
				}
				default:
					return num;
				}
				break;
				IL_012a:
				int num10;
				if (!base.Owner.HasTalent(ResourceStrings.ResStrings[1221]))
				{
					num2 = 40405840;
					num10 = num2;
				}
				else
				{
					num2 = 1848385952;
					num10 = num2;
				}
			}
			goto IL_0021;
			IL_00dc:
			int num11;
			if (CommonSettings.MOD_KEY() == 1)
			{
				num2 = 1166912557;
				num11 = num2;
			}
			else
			{
				num2 = 40405840;
				num11 = num2;
			}
			goto IL_0026;
		}
	}

	public float Attack
	{
		get
		{
			double num = 0.0;
			Trigger current = default(Trigger);
			while (true)
			{
				int num2 = -2124298962;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num2 ^ -575924008)) % 3)
					{
					case 0u:
						break;
					case 2u:
						if (base.Owner != null)
						{
							goto IL_0037;
						}
						goto IL_0155;
					default:
						{
							IEnumerator<Trigger> enumerator = base.Owner.GetTriggers(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1686075188u)).GetEnumerator();
							try
							{
								while (true)
								{
									IL_00b7:
									int num4;
									int num5;
									if (!_200D_206A_200E_200E_200F_200C_200D_200C_206B_200B_202D_200F_202A_206A_202E_206C_206A_202C_206B_206E_202D_200D_200B_202A_202A_206E_200D_202A_206A_202C_202C_202A_202E_202A_202D_206C_202E_202C_202E_202B_202E((IEnumerator)enumerator))
									{
										num4 = -104673224;
										num5 = num4;
									}
									else
									{
										num4 = -1022137694;
										num5 = num4;
									}
									while (true)
									{
										switch ((num3 = (uint)(num4 ^ -575924008)) % 6)
										{
										case 2u:
											num4 = -1022137694;
											continue;
										default:
											goto end_IL_0068;
										case 1u:
											num += double.Parse(current.Argvs[1]);
											num4 = (int)((num3 * 332213779) ^ 0x1827B902);
											continue;
										case 3u:
											break;
										case 4u:
											current = enumerator.Current;
											num4 = -1399805995;
											continue;
										case 5u:
										{
											int num6;
											int num7;
											if (!_206E_206B_202C_206A_200D_202A_202D_202E_206A_202A_202C_202B_206D_200B_206E_206D_202D_206E_200F_202C_200D_202E_206C_202D_206B_206F_200F_206D_206E_206A_200C_202E_206F_202D_202C_200C_200E_200D_200F_202B_202E(current.Argvs[0], InternalSkill.Name))
											{
												num6 = 1381076737;
												num7 = num6;
											}
											else
											{
												num6 = 250728185;
												num7 = num6;
											}
											num4 = num6 ^ ((int)num3 * -928065042);
											continue;
										}
										case 0u:
											goto end_IL_0068;
										}
										goto IL_00b7;
										continue;
										end_IL_0068:
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
										IL_011d:
										int num8 = -2034901360;
										while (true)
										{
											switch ((num3 = (uint)(num8 ^ -575924008)) % 3)
											{
											case 0u:
												break;
											default:
												goto end_IL_0122;
											case 2u:
												goto IL_013f;
											case 1u:
												goto end_IL_0122;
											}
											goto IL_011d;
											IL_013f:
											_206C_206F_206A_200F_202D_200F_206D_200C_206D_200C_202D_200B_202B_206C_200F_202D_206D_200C_206A_202B_206E_206A_200E_200F_206C_200B_200B_200C_206E_202A_202D_200D_202C_206B_206C_206B_200B_206E_202D_200D_202E((IDisposable)enumerator);
											num8 = ((int)num3 * -192042861) ^ -1922417911;
											continue;
											end_IL_0122:
											break;
										}
										break;
									}
								}
							}
							goto IL_0155;
						}
						IL_0155:
						return (float)Level / 10f * InternalSkill.Attack * (float)(1.0 + num / 100.0);
					}
					break;
					IL_0037:
					num2 = (int)(num3 * 1797778335) ^ -1397809509;
				}
			}
		}
	}

	public float Critical
	{
		get
		{
			if (Level < 10)
			{
				while (true)
				{
					uint num;
					switch ((num = 1688269655u) % 3)
					{
					case 0u:
						continue;
					case 2u:
						return (float)Level / 10f * InternalSkill.Critical;
					}
					break;
				}
			}
			return InternalSkill.Critical;
		}
	}

	public float Defence
	{
		get
		{
			double num = 0.0;
			Trigger current = default(Trigger);
			while (true)
			{
				int num2 = 642271417;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num2 ^ 0x41818C05)) % 3)
					{
					case 2u:
						break;
					case 1u:
						if (base.Owner != null)
						{
							goto IL_0037;
						}
						goto IL_015b;
					default:
						{
							IEnumerator<Trigger> enumerator = base.Owner.GetTriggers(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1229190677u)).GetEnumerator();
							try
							{
								while (true)
								{
									IL_0102:
									int num4;
									int num5;
									if (!_200D_206A_200E_200E_200F_200C_200D_200C_206B_200B_202D_200F_202A_206A_202E_206C_206A_202C_206B_206E_202D_200D_200B_202A_202A_206E_200D_202A_206A_202C_202C_202A_202E_202A_202D_206C_202E_202C_202E_202B_202E((IEnumerator)enumerator))
									{
										num4 = 981950724;
										num5 = num4;
									}
									else
									{
										num4 = 1963369892;
										num5 = num4;
									}
									while (true)
									{
										switch ((num3 = (uint)(num4 ^ 0x41818C05)) % 6)
										{
										case 0u:
											num4 = 1963369892;
											continue;
										default:
											goto end_IL_006b;
										case 5u:
											current = enumerator.Current;
											num4 = 1285239748;
											continue;
										case 3u:
										{
											int num6;
											int num7;
											if (!_206E_206B_202C_206A_200D_202A_202D_202E_206A_202A_202C_202B_206D_200B_206E_206D_202D_206E_200F_202C_200D_202E_206C_202D_206B_206F_200F_206D_206E_206A_200C_202E_206F_202D_202C_200C_200E_200D_200F_202B_202E(current.Argvs[0], InternalSkill.Name))
											{
												num6 = 609076387;
												num7 = num6;
											}
											else
											{
												num6 = 187900935;
												num7 = num6;
											}
											num4 = num6 ^ ((int)num3 * -1120458682);
											continue;
										}
										case 2u:
											num += double.Parse(current.Argvs[1]);
											num4 = (int)((num3 * 368582753) ^ 0x518F1A21);
											continue;
										case 4u:
											break;
										case 1u:
											goto end_IL_006b;
										}
										goto IL_0102;
										continue;
										end_IL_006b:
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
										IL_0123:
										int num8 = 1755237048;
										while (true)
										{
											switch ((num3 = (uint)(num8 ^ 0x41818C05)) % 3)
											{
											case 2u:
												break;
											default:
												goto end_IL_0128;
											case 1u:
												goto IL_0145;
											case 0u:
												goto end_IL_0128;
											}
											goto IL_0123;
											IL_0145:
											_206C_206F_206A_200F_202D_200F_206D_200C_206D_200C_202D_200B_202B_206C_200F_202D_206D_200C_206A_202B_206E_206A_200E_200F_206C_200B_200B_200C_206E_202A_202D_200D_202C_206B_206C_206B_200B_206E_202D_200D_202E((IDisposable)enumerator);
											num8 = ((int)num3 * -426692349) ^ 0xCE5AE7C;
											continue;
											end_IL_0128:
											break;
										}
										break;
									}
								}
							}
							goto IL_015b;
						}
						IL_015b:
						return (float)Level / 10f * InternalSkill.Defence * (float)(1.0 + num / 100.0);
					}
					break;
					IL_0037:
					num2 = (int)((num3 * 148491794) ^ 0x5CCFE107);
				}
			}
		}
	}

	public float Hard => InternalSkill.Hard;

	public override string Name => name;

	public override string Icon => InternalSkill.icon;

	public override Color Color => Color.magenta;

	public override int Cd => 0;

	public override int Type => 4;

	public override int CostMp => (int)Hard * Level * 4;

	public override float Power => Attack * 13f;

	public override int CostBall => 0;

	public override int CastSize => 0;

	public override int Size => 0;

	public override SkillCoverType CoverType => SkillCoverType.NORMAL;

	public override string Animation => null;

	public override SkillType SkillType => SkillType.Internal;

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
			int num = -1471220115;
			goto IL_0015;
			IL_0015:
			uint num2;
			switch ((num2 = (uint)(num ^ -163056836)) % 4)
			{
			case 3u:
				break;
			case 1u:
				return level;
			case 0u:
				goto IL_004c;
			default:
				return 1;
			}
			goto IL_0010;
			IL_004c:
			SystemClass._202D_202A_202A_200C_202D_206A_206C_206E_206C_200D_206C_206F_200E_200F_202D_202C_202B_206F_202C_200C_200D_202D_206A_206E_202E_202B_202D_206F_202C_202A_202A_202A_206B_200E_206F_206D_206D_200E_200B_206F_202E();
			num = -750934206;
			goto IL_0015;
		}
	}

	[XmlIgnore]
	public override string DescriptionInRichtext
	{
		get
		{
			string text = InternalSkill.Info;
			int maxLevel = default(int);
			Trigger current = default(Trigger);
			while (true)
			{
				int num = -329447834;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1206174981)) % 4)
					{
					case 0u:
						break;
					case 1u:
						text = _200C_202A_200F_200B_202D_202A_202D_206E_202C_202E_206E_202B_202D_202B_200F_202D_200E_206A_200C_206C_202D_200D_202E_202B_202C_202B_200C_206D_206E_200F_202C_202D_200B_202D_206E_200C_206D_200E_206B_206A_202E(text, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(925971650u));
						text = _200C_202A_200F_200B_202D_202A_202D_206E_202C_202E_206E_202B_202D_202B_200F_202D_200E_206A_200C_206C_202D_200D_202E_202B_202C_202B_200C_206D_206E_200F_202C_202D_200B_202D_206E_200C_206D_200E_206B_206A_202E(text, _202B_202A_200E_200E_206B_202E_202C_206C_206B_202B_202E_202C_200D_202C_206E_200F_200D_206F_200B_202A_200E_206B_200F_200D_202E_200E_200B_202A_200E_206E_202C_200F_202D_200C_206A_202D_202E_206D_206B_206F_202E(ResourceStrings.ResStrings[389], new object[9]
						{
							Level,
							MaxLevel,
							Exp,
							LevelupExp,
							Attack * 100f,
							Defence * 100f,
							Critical * 100f,
							Yin,
							Yang
						}));
						if (InternalSkill.Triggers.Count > 0)
						{
							num = (int)((num2 * 1825525361) ^ 0x26EC5500);
							continue;
						}
						goto IL_031e;
					case 2u:
						maxLevel = MaxLevel2;
						num = ((int)num2 * -380834489) ^ -838859138;
						continue;
					default:
						{
							text = _200C_202A_200F_200B_202D_202A_202D_206E_202C_202E_206E_202B_202D_202B_200F_202D_200E_206A_200C_206C_202D_200D_202E_202B_202C_202B_200C_206D_206E_200F_202C_202D_200B_202D_206E_200C_206D_200E_206B_206A_202E(text, _202E_206E_206E_206E_202A_200D_200D_206D_202E_200F_206B_200E_206D_202C_206F_206D_202E_200D_206C_200D_202A_206A_202A_206E_200E_200F_202A_206A_200E_206B_206E_206D_202E_206A_200D_200C_206B_200D_200B_200D_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3161166038u), (object)ResourceStrings.ResStrings[390]));
							using (List<Trigger>.Enumerator enumerator = InternalSkill.Triggers.GetEnumerator())
							{
								while (true)
								{
									IL_0243:
									int num3;
									int num4;
									if (!enumerator.MoveNext())
									{
										num3 = -1238354661;
										num4 = num3;
									}
									else
									{
										num3 = -84657602;
										num4 = num3;
									}
									while (true)
									{
										switch ((num2 = (uint)(num3 ^ -1206174981)) % 11)
										{
										case 8u:
											num3 = -84657602;
											continue;
										default:
											goto end_IL_017c;
										case 3u:
											text = _200C_202A_200F_200B_202D_202A_202D_206E_202C_202E_206E_202B_202D_202B_200F_202D_200E_206A_200C_206C_202D_200D_202E_202B_202C_202B_200C_206D_206E_200F_202C_202D_200B_202D_206E_200C_206D_200E_206B_206A_202E(text, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(373182451u));
											num3 = -1345848313;
											continue;
										case 7u:
										{
											int num7;
											int num8;
											if (Level >= current.Level)
											{
												num7 = 531969456;
												num8 = num7;
											}
											else
											{
												num7 = 1759682490;
												num8 = num7;
											}
											num3 = num7 ^ (int)(num2 * 69520341);
											continue;
										}
										case 5u:
											current = enumerator.Current;
											num3 = -1548908950;
											continue;
										case 6u:
											text = _200C_202A_200F_200B_202D_202A_202D_206E_202C_202E_206E_202B_202D_202B_200F_202D_200E_206A_200C_206C_202D_200D_202E_202B_202C_202B_200C_206D_206E_200F_202C_202D_200B_202D_206E_200C_206D_200E_206B_206A_202E(text, _202E_206E_206E_206E_202A_200D_200D_206D_202E_200F_206B_200E_206D_202C_206F_206D_202E_200D_206C_200D_202A_206A_202A_206E_200E_200F_202A_206A_200E_206B_206E_206D_202E_206A_200D_200C_206B_200D_200B_200D_202E(ResourceStrings.ResStrings[392], (object)current.Level));
											num3 = -1461091845;
											continue;
										case 4u:
											break;
										case 10u:
											text = _200C_202A_200F_200B_202D_202A_202D_206E_202C_202E_206E_202B_202D_202B_200F_202D_200E_206A_200C_206C_202D_200D_202E_202B_202C_202B_200C_206D_206E_200F_202C_202D_200B_202D_206E_200C_206D_200E_206B_206A_202E(text, _206F_200D_200E_206B_200B_202C_200E_202E_202B_206B_200F_202E_200E_202A_206A_200F_206B_206C_202D_206C_200E_206C_202E_202B_200F_200C_202E_206E_202E_206A_202C_202D_200D_200B_200B_206F_202E_206C_206E_206E_202E(ResourceStrings.ResStrings[391], (object)current.ToString2(), (object)current.Level));
											num3 = (int)(num2 * 560724514) ^ -1755694351;
											continue;
										case 9u:
										{
											int num5;
											int num6;
											if (current.Level <= maxLevel)
											{
												num5 = 431144925;
												num6 = num5;
											}
											else
											{
												num5 = 764003504;
												num6 = num5;
											}
											num3 = num5 ^ (int)(num2 * 1418570493);
											continue;
										}
										case 2u:
											text = _200C_202A_200F_200B_202D_202A_202D_206E_202C_202E_206E_202B_202D_202B_200F_202D_200E_206A_200C_206C_202D_200D_202E_202B_202C_202B_200C_206D_206E_200F_202C_202D_200B_202D_206E_200C_206D_200E_206B_206A_202E(text, _206F_200D_200E_206B_200B_202C_200E_202E_202B_206B_200F_202E_200E_202A_206A_200F_206B_206C_202D_206C_200E_206C_202E_202B_200F_200C_202E_206E_202E_206A_202C_202D_200D_200B_200B_206F_202E_206C_206E_206E_202E(ResourceStrings.ResStrings[393], (object)current.ToString2(), (object)current.Level));
											num3 = -1461091845;
											continue;
										case 1u:
											num3 = (int)((num2 * 568607127) ^ 0x70F9D3D9);
											continue;
										case 0u:
											goto end_IL_017c;
										}
										goto IL_0243;
										continue;
										end_IL_017c:
										break;
									}
									break;
								}
							}
							goto IL_031e;
						}
						IL_031e:
						return text;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public int LevelupExp => GetLevelupExp(Level);

	public InternalSkill InternalSkill
	{
		get
		{
			if (_206B_200B_200C_202D_202A_206E_200B_202C_206A_200D_200E_200D_206B_202A_202B_202E_200F_202D_202D_202A_200D_200B_202A_200E_200B_202A_202C_206E_200F_206E_206C_202B_206E_202A_200C_206A_202B_206F_206D_200E_202E == null)
			{
				while (true)
				{
					int num = -1529657582;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ -1220465644)) % 3)
						{
						case 0u:
							break;
						case 2u:
							_206B_200B_200C_202D_202A_206E_200B_202C_206A_200D_200E_200D_206B_202A_202B_202E_200F_202D_202D_202A_200D_200B_202A_200E_200B_202A_202C_206E_200F_206E_206C_202B_206E_202A_200C_206A_202B_206F_206D_200E_202E = ResourceManager.Get<InternalSkill>(name);
							num = ((int)num2 * -2033530638) ^ -1337264675;
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
			return _206B_200B_200C_202D_202A_206E_200B_202C_206A_200D_200E_200D_206B_202A_202B_202E_200F_202D_202D_202A_200D_200B_202A_200E_200B_202A_202C_206E_200F_206E_206C_202B_206E_202A_200C_206A_202B_206F_206D_200E_202E;
		}
	}

	[XmlIgnore]
	public IEnumerable<string> Talents => new _200B_200D_200F_202D_206B_200D_206D_202B_206A_206B_202A_206D_202D_202C_200B_202C_200D_202D_206E_206F_206E_202B_200B_206A_200C_200E_200D_206D_206A_206B_202D_206B_206B_206C_200C_206B_206F_202E_202C_200E_202E(-2)
	{
		_202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E = this
	};

	public override bool IsNpcSkill => InternalSkill.IsNpc;

	public override int MaxLevel
	{
		get
		{
			int num = _200D_200B_200F_200B_200E_200D_202E_200E_206C_206F_202E_202D_200C_206C_206D_202E_200D_200E_200F_202D_200B_202C_206F_202A_206B_202B_202D_206C_202E_206D_206D_200B_200F_202A_200C_206F_200F_206E_206D_202A_202E(Level, ModData.GetSkillMaxLevel(Name));
			while (true)
			{
				int num2 = 1783283018;
				while (true)
				{
					uint num3;
					int num4;
					switch ((num3 = (uint)(num2 ^ 0x4DFD0FFF)) % 4)
					{
					case 0u:
						break;
					case 1u:
					{
						int num5;
						if (base.Owner != null)
						{
							num4 = -130111988;
							num5 = num4;
						}
						else
						{
							num4 = -314077827;
							num5 = num4;
						}
						goto IL_0053;
					}
					case 2u:
						return _206F_200B_202C_200B_206F_202C_200B_200C_202C_202A_202D_206A_206E_206B_200F_202B_202D_206D_200F_200D_206C_206F_206F_200F_202A_206F_200E_202A_206B_200E_200F_206D_202D_206A_202E_202C_200B_202A_200F_202E_202E(num, CommonSettings.MAX_INTERNALSKILL_LEVEL);
					default:
						return _206F_200B_202C_200B_206F_202C_200B_200C_202C_202A_202D_206A_206E_206B_200F_202B_202D_206D_200F_200D_206C_206F_206F_200F_202A_206F_200E_202A_206B_200E_200F_206D_202D_206A_202E_202C_200B_202A_200F_202E_202E(num, RuntimeData.Instance.isBattle ? BattleField.ROLE_MAX_INTERNALSKILL_LEVEL[base.Owner] : base.Owner.MAX_INTERNALSKILL_LEVEL);
					}
					break;
					IL_0053:
					num2 = num4 ^ ((int)num3 * -1084630668);
				}
			}
		}
	}

	public override int MaxLevel2
	{
		get
		{
			int num = _200D_200B_200F_200B_200E_200D_202E_200E_206C_206F_202E_202D_200C_206C_206D_202E_200D_200E_200F_202D_200B_202C_206F_202A_206B_202B_202D_206C_202E_206D_206D_200B_200F_202A_200C_206F_200F_206E_206D_202A_202E(Level, ModData.SkillMaxLevels.ContainsKey(Name) ? ModData.SkillMaxLevels[Name] : 0);
			if (base.Owner == null)
			{
				while (true)
				{
					uint num2;
					switch ((num2 = 1777497241u) % 3)
					{
					case 0u:
						continue;
					case 1u:
						return _206F_200B_202C_200B_206F_202C_200B_200C_202C_202A_202D_206A_206E_206B_200F_202B_202D_206D_200F_200D_206C_206F_206F_200F_202A_206F_200E_202A_206B_200E_200F_206D_202D_206A_202E_202C_200B_202A_200F_202E_202E(num, CommonSettings.MAX_INTERNALSKILL_LEVEL);
					}
					break;
				}
			}
			return _206F_200B_202C_200B_206F_202C_200B_200C_202C_202A_202D_206A_206E_206B_200F_202B_202D_206D_200F_200D_206C_206F_206F_200F_202A_206F_200E_202A_206B_200E_200F_206D_202D_206A_202E_202C_200B_202A_200F_202E_202E(num, RuntimeData.Instance.isBattle ? BattleField.ROLE_MAX_INTERNALSKILL_LEVEL[base.Owner] : base.Owner.MAX_INTERNALSKILL_LEVEL);
		}
	}

	public InternalSkillInstance()
	{
		while (true)
		{
			int num = -2129935958;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1767495886)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0033;
				case 1u:
					return;
				}
				break;
				IL_0033:
				equipped = 0;
				num = ((int)num2 * -1405735769) ^ -1630693055;
			}
		}
	}

	public void RefreshUniquSkills()
	{
		UniqueSkills.Clear();
		using List<UniqueSkill>.Enumerator enumerator = InternalSkill.UniqueSkills.GetEnumerator();
		while (true)
		{
			int num;
			int num2;
			if (enumerator.MoveNext())
			{
				num = 626174776;
				num2 = num;
			}
			else
			{
				num = 809681191;
				num2 = num;
			}
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num ^ 0x33657912)) % 4)
				{
				case 0u:
					num = 626174776;
					continue;
				default:
					return;
				case 2u:
				{
					UniqueSkill current = enumerator.Current;
					UniqueSkills.Add(new UniqueSkillInstance(current, this));
					num = 961398553;
					continue;
				}
				case 3u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public int GetLevelupExp(int currentLevel)
	{
		return (int)(((float)currentLevel + 4f) / 4f * (Hard + 4f) / 4f * 40f);
	}

	public bool HasTalent(string talent)
	{
		return Talents.Contains(talent);
	}

	public override bool TryAddExp(int exp)
	{
		if (RuntimeData.Instance.isBattle)
		{
			goto IL_000f;
		}
		goto IL_024a;
		IL_000f:
		int num = 1884837164;
		goto IL_0014;
		IL_0014:
		int mAX_INTERNALSKILL_LEVEL = default(int);
		bool flag = default(bool);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x650D4107)) % 23)
			{
			case 7u:
				break;
			case 6u:
				goto IL_0085;
			case 14u:
			{
				int num5;
				int num6;
				if (level != -(int)level2)
				{
					num5 = -1589325954;
					num6 = num5;
				}
				else
				{
					num5 = -1203111149;
					num6 = num5;
				}
				num = num5 ^ (int)(num2 * 308885731);
				continue;
			}
			case 3u:
				Exp = LevelupExp;
				num = ((int)num2 * -775629534) ^ -807492471;
				continue;
			case 16u:
				goto IL_00f1;
			case 20u:
				Exp += exp;
				num = 615158034;
				continue;
			case 15u:
				mAX_INTERNALSKILL_LEVEL = base.Owner.MAX_INTERNALSKILL_LEVEL;
				num = 1183278064;
				continue;
			case 9u:
				return TryAddExpBattle(exp);
			case 4u:
				Exp -= LevelupExp;
				level++;
				num = 1524705676;
				continue;
			case 0u:
				num = (int)((num2 * 1926011850) ^ 0x39DD95FB);
				continue;
			case 22u:
			{
				exp += base.Owner.AttributesFinal[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(739543880u)] / 30;
				int num9;
				int num10;
				if (!base.Owner.HasTalent(ResourceStrings.ResStrings[160]))
				{
					num9 = -54447969;
					num10 = num9;
				}
				else
				{
					num9 = -529619234;
					num10 = num9;
				}
				num = num9 ^ ((int)num2 * -170348583);
				continue;
			}
			case 21u:
			{
				level2 -= 1f;
				int num7;
				int num8;
				if (level <= mAX_INTERNALSKILL_LEVEL)
				{
					num7 = -1864493998;
					num8 = num7;
				}
				else
				{
					num7 = -1597050615;
					num8 = num7;
				}
				num = num7 ^ ((int)num2 * -238826537);
				continue;
			}
			case 2u:
				Exp += exp;
				num = ((int)num2 * -1876827245) ^ 0x46850B70;
				continue;
			case 1u:
				goto IL_024a;
			case 19u:
				goto IL_0256;
			case 5u:
				Exp += exp * 2;
				num = 615158034;
				continue;
			case 8u:
				level2 = 0f - (float)mAX_INTERNALSKILL_LEVEL;
				num = ((int)num2 * -1687794640) ^ 0x37EEE88F;
				continue;
			case 13u:
				flag = true;
				num = 1183278064;
				continue;
			case 18u:
			{
				int num3;
				int num4;
				if (base.Owner.HasTalent(ResourceStrings.ResStrings[496]))
				{
					num3 = -1851025773;
					num4 = num3;
				}
				else
				{
					num3 = -965115519;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -981045970);
				continue;
			}
			case 10u:
				RefreshUniquSkills();
				RuntimeData.Instance.RefreshTeamMemberPanel(base.Owner, refreshImage: false, refreshText: true);
				num = (int)(num2 * 772183269) ^ -315416945;
				continue;
			case 11u:
				level = mAX_INTERNALSKILL_LEVEL;
				num = ((int)num2 * -1624950391) ^ -1318041986;
				continue;
			case 17u:
				goto IL_0329;
			default:
				return flag;
			}
			break;
			IL_0329:
			int num11;
			if (level < MaxLevel)
			{
				num = 119457270;
				num11 = num;
			}
			else
			{
				num = 62801630;
				num11 = num;
			}
			continue;
			IL_00f1:
			int num12;
			if (!Tools.ProbabilityTest(0.5))
			{
				num = 726740146;
				num12 = num;
			}
			else
			{
				num = 422557553;
				num12 = num;
			}
			continue;
			IL_0085:
			int num13;
			if (Exp >= LevelupExp)
			{
				num = 1104989920;
				num13 = num;
			}
			else
			{
				num = 489448803;
				num13 = num;
			}
			continue;
			IL_0256:
			int num14;
			if (!flag)
			{
				num = 269060269;
				num14 = num;
			}
			else
			{
				num = 1894075517;
				num14 = num;
			}
		}
		goto IL_000f;
		IL_024a:
		flag = false;
		num = 2251094;
		goto IL_0014;
	}

	public void SetLevel(int level)
	{
		this.level = level;
		while (true)
		{
			int num = 1592463140;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5A57459D)) % 3)
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
				level2 = 0f - (float)level;
				num = ((int)num2 * -642420410) ^ 0x622E165C;
			}
		}
	}

	public void SkillVariables()
	{
		YinBattle = Yin;
		while (true)
		{
			int num = -1620711818;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1196282077)) % 4)
				{
				case 2u:
					break;
				case 1u:
					YangBattle = Yang;
					AttackBattle = Attack;
					num = ((int)num2 * -995308339) ^ -1642477934;
					continue;
				case 0u:
					PowerBattle = Power;
					CostMpBattle = CostMp;
					num = (int)((num2 * 1634056587) ^ 0x14490F04);
					continue;
				default:
				{
					using List<UniqueSkillInstance>.Enumerator enumerator = UniqueSkills.GetEnumerator();
					while (true)
					{
						int num3;
						int num4;
						if (enumerator.MoveNext())
						{
							num3 = -1778413566;
							num4 = num3;
						}
						else
						{
							num3 = -1785048396;
							num4 = num3;
						}
						while (true)
						{
							switch ((num2 = (uint)(num3 ^ -1196282077)) % 4)
							{
							case 0u:
								num3 = -1778413566;
								continue;
							default:
								return;
							case 1u:
							{
								UniqueSkillInstance current = enumerator.Current;
								current.PowerBattle = current.Power;
								current.CostMpBattle = current.CostMp;
								num3 = -1396108395;
								continue;
							}
							case 2u:
								break;
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

	public List<string> GetEQTriggers(string name)
	{
		List<string> list = new List<string>();
		if (IsUsed)
		{
			using List<Trigger>.Enumerator enumerator = InternalSkill.Triggers.GetEnumerator();
			Trigger current = default(Trigger);
			while (true)
			{
				IL_0068:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -848625093;
					num2 = num;
				}
				else
				{
					num = -1357114348;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -719402898)) % 7)
					{
					case 0u:
						num = -848625093;
						continue;
					default:
						goto end_IL_0029;
					case 3u:
						current = enumerator.Current;
						num = -17309732;
						continue;
					case 6u:
						break;
					case 5u:
						list.Add(current.ArgvsString);
						num = (int)((num3 * 903429168) ^ 0x66D951EC);
						continue;
					case 2u:
					{
						int num6;
						int num7;
						if (_206E_206B_202C_206A_200D_202A_202D_202E_206A_202A_202C_202B_206D_200B_206E_206D_202D_206E_200F_202C_200D_202E_206C_202D_206B_206F_200F_206D_206E_206A_200C_202E_206F_202D_202C_200C_200E_200D_200F_202B_202E(current.Name, name))
						{
							num6 = -528808005;
							num7 = num6;
						}
						else
						{
							num6 = -1370959292;
							num7 = num6;
						}
						num = num6 ^ (int)(num3 * 142132060);
						continue;
					}
					case 4u:
					{
						int num4;
						int num5;
						if (Level < current.Level)
						{
							num4 = 1073351717;
							num5 = num4;
						}
						else
						{
							num4 = 400855424;
							num5 = num4;
						}
						num = num4 ^ (int)(num3 * 263251613);
						continue;
					}
					case 1u:
						goto end_IL_0029;
					}
					goto IL_0068;
					continue;
					end_IL_0029:
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
			int num7 = default(int);
			SkillInstance current = default(SkillInstance);
			while (true)
			{
				int num = 579514469;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x550D8274)) % 22)
					{
					case 10u:
						break;
					case 21u:
						goto IL_0088;
					case 2u:
						num = (int)((num2 * 1691382363) ^ 0xB52FC76);
						continue;
					case 5u:
						Exp += exp;
						num = ((int)num2 * -407704509) ^ -782731116;
						continue;
					case 6u:
						Exp -= LevelupExp;
						num = 1939363869;
						continue;
					case 18u:
					{
						int num5;
						int num6;
						if (!base.Owner.BuiltInTalents[156])
						{
							num5 = -1764597138;
							num6 = num5;
						}
						else
						{
							num5 = -2096788800;
							num6 = num5;
						}
						num = num5 ^ ((int)num2 * -914685246);
						continue;
					}
					case 4u:
						num = (int)((num2 * 1170625459) ^ 0x7D9C2FF0);
						continue;
					case 9u:
						level2 = 0f - (float)num7;
						num = ((int)num2 * -401981980) ^ -912860484;
						continue;
					case 20u:
						goto IL_015e;
					case 17u:
					{
						int num8;
						int num9;
						if (level > num7)
						{
							num8 = -564914376;
							num9 = num8;
						}
						else
						{
							num8 = -1558359049;
							num9 = num8;
						}
						num = num8 ^ ((int)num2 * -1981719823);
						continue;
					}
					case 1u:
						level = num7;
						num = ((int)num2 * -1955665410) ^ 0xD084C33;
						continue;
					case 3u:
						level2 -= 1f;
						num = (int)(num2 * 336799057) ^ -880705944;
						continue;
					case 15u:
						num7 = BattleField.ROLE_MAX_INTERNALSKILL_LEVEL[base.Owner];
						num = 606123327;
						continue;
					case 7u:
						Exp = LevelupExp;
						num = ((int)num2 * -77639125) ^ -259329523;
						continue;
					case 8u:
						goto IL_0221;
					case 11u:
						goto IL_0231;
					case 19u:
					{
						exp += base.Owner.AttributesFinal[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(739543880u)] / 30;
						int num3;
						int num4;
						if (!base.Owner.BuiltInTalents[155])
						{
							num3 = 1316811699;
							num4 = num3;
						}
						else
						{
							num3 = 1276674533;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -742000503);
						continue;
					}
					case 13u:
						level++;
						num = ((int)num2 * -1510801105) ^ -58156656;
						continue;
					case 0u:
						Exp += exp * 2;
						num = 797310010;
						continue;
					case 16u:
						flag = true;
						num = 606123327;
						continue;
					case 14u:
						Exp += exp;
						num = 1701928396;
						continue;
					default:
						goto IL_0307;
					}
					break;
					IL_0307:
					RefreshUniquSkills();
					using (List<SkillInstance>.Enumerator enumerator = base.Owner.Skills.GetEnumerator())
					{
						while (true)
						{
							IL_035e:
							int num10;
							int num11;
							if (enumerator.MoveNext())
							{
								num10 = 1823803988;
								num11 = num10;
							}
							else
							{
								num10 = 910622279;
								num11 = num10;
							}
							while (true)
							{
								switch ((num2 = (uint)(num10 ^ 0x550D8274)) % 6)
								{
								case 2u:
									num10 = 1823803988;
									continue;
								default:
									goto end_IL_0325;
								case 4u:
									current = enumerator.Current;
									num10 = 1690156556;
									continue;
								case 3u:
									break;
								case 0u:
								{
									int num12;
									int num13;
									if (current.IsUsed)
									{
										num12 = -803944773;
										num13 = num12;
									}
									else
									{
										num12 = -1687117885;
										num13 = num12;
									}
									num10 = num12 ^ ((int)num2 * -1033563203);
									continue;
								}
								case 5u:
									current.SkillVariables();
									num10 = ((int)num2 * -23149800) ^ 0x739E1E73;
									continue;
								case 1u:
									goto end_IL_0325;
								}
								goto IL_035e;
								continue;
								end_IL_0325:
								break;
							}
							break;
						}
					}
					base.Owner.EquippedInternalSkill.SkillVariables();
					goto end_IL_0015;
					IL_0221:
					if (!flag)
					{
						goto end_IL_0015;
					}
					num = 584602430;
					continue;
					IL_0231:
					int num14;
					if (Exp < LevelupExp)
					{
						num = 893926262;
						num14 = num;
					}
					else
					{
						num = 1787275733;
						num14 = num;
					}
					continue;
					IL_0088:
					int num15;
					if (level < MaxLevel)
					{
						num = 1499338334;
						num15 = num;
					}
					else
					{
						num = 1507785125;
						num15 = num;
					}
					continue;
					IL_015e:
					int num16;
					if (!Tools.ProbabilityTest(0.5))
					{
						num = 981550117;
						num16 = num;
					}
					else
					{
						num = 288726927;
						num16 = num;
					}
				}
				continue;
				end_IL_0015:
				break;
			}
		}
		return flag;
	}

	static bool _206E_206B_202C_206A_200D_202A_202D_202E_206A_202A_202C_202B_206D_200B_206E_206D_202D_206E_200F_202C_200D_202E_206C_202D_206B_206F_200F_206D_206E_206A_200C_202E_206F_202D_202C_200C_200E_200D_200F_202B_202E(string P_0, string P_1)
	{
		return P_0 == P_1;
	}

	static bool _200D_206A_200E_200E_200F_200C_200D_200C_206B_200B_202D_200F_202A_206A_202E_206C_206A_202C_206B_206E_202D_200D_200B_202A_202A_206E_200D_202A_206A_202C_202C_202A_202E_202A_202D_206C_202E_202C_202E_202B_202E(IEnumerator P_0)
	{
		return P_0.MoveNext();
	}

	static void _206C_206F_206A_200F_202D_200F_206D_200C_206D_200C_202D_200B_202B_206C_200F_202D_206D_200C_206A_202B_206E_206A_200E_200F_206C_200B_200B_200C_206E_202A_202D_200D_202C_206B_206C_206B_200B_206E_202D_200D_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}

	static string _200C_202A_200F_200B_202D_202A_202D_206E_202C_202E_206E_202B_202D_202B_200F_202D_200E_206A_200C_206C_202D_200D_202E_202B_202C_202B_200C_206D_206E_200F_202C_202D_200B_202D_206E_200C_206D_200E_206B_206A_202E(string P_0, string P_1)
	{
		return P_0 + P_1;
	}

	static string _202B_202A_200E_200E_206B_202E_202C_206C_206B_202B_202E_202C_200D_202C_206E_200F_200D_206F_200B_202A_200E_206B_200F_200D_202E_200E_200B_202A_200E_206E_202C_200F_202D_200C_206A_202D_202E_206D_206B_206F_202E(string P_0, object[] P_1)
	{
		return string.Format(P_0, P_1);
	}

	static string _202E_206E_206E_206E_202A_200D_200D_206D_202E_200F_206B_200E_206D_202C_206F_206D_202E_200D_206C_200D_202A_206A_202A_206E_200E_200F_202A_206A_200E_206B_206E_206D_202E_206A_200D_200C_206B_200D_200B_200D_202E(string P_0, object P_1)
	{
		return string.Format(P_0, P_1);
	}

	static string _206F_200D_200E_206B_200B_202C_200E_202E_202B_206B_200F_202E_200E_202A_206A_200F_206B_206C_202D_206C_200E_206C_202E_202B_200F_200C_202E_206E_202E_206A_202C_202D_200D_200B_200B_206F_202E_206C_206E_206E_202E(string P_0, object P_1, object P_2)
	{
		return string.Format(P_0, P_1, P_2);
	}

	static int _200D_200B_200F_200B_200E_200D_202E_200E_206C_206F_202E_202D_200C_206C_206D_202E_200D_200E_200F_202D_200B_202C_206F_202A_206B_202B_202D_206C_202E_206D_206D_200B_200F_202A_200C_206F_200F_206E_206D_202A_202E(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	static int _206F_200B_202C_200B_206F_202C_200B_200C_202C_202A_202D_206A_206E_206B_200F_202B_202D_206D_200F_200D_206C_206F_206F_200F_202A_206F_200E_202A_206B_200E_200F_206D_202D_206A_202E_202C_200B_202A_200F_202E_202E(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}
}
