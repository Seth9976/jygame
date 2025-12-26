using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JyGame;
using UnityEngine;
using UnityEngine.UI;

public class WhacAMole : MonoBehaviour
{
	private class MolePojo
	{
		private float activeTime;

		private static float timeout;

		public static string[] items;

		private int type;

		[CompilerGenerated]
		private int _200E_202A_202C_202E_206D_206B_202D_200E_200D_206E_206D_202D_200F_206A_206B_206C_202B_206E_206B_202C_202E_202B_200B_206F_202E_200D_200E_206C_206C_202B_202E_202E_200D_200F_206A_200C_206B_202A_206B_202E;

		[CompilerGenerated]
		private string _200E_202A_202E_202C_200B_200E_200D_202C_206E_206C_202C_200F_200E_206F_206E_202A_202E_206B_200B_202D_202B_200F_202B_206E_200B_200D_206F_206A_200B_202E_200C_200C_200C_200C_206F_206C_202B_206F_200C_202E;

		[CompilerGenerated]
		private string _200D_206C_202E_206A_202B_202D_206D_202D_202E_202D_202D_202C_202D_206E_206E_202A_202C_200E_202D_206D_202A_202D_202E_206F_200E_206E_206B_200D_206B_206D_200F_202C_206A_202D_206F_200E_206F_202C_200C_202E_202E;

		public int Point
		{
			[CompilerGenerated]
			get
			{
				return _200E_202A_202C_202E_206D_206B_202D_200E_200D_206E_206D_202D_200F_206A_206B_206C_202B_206E_206B_202C_202E_202B_200B_206F_202E_200D_200E_206C_206C_202B_202E_202E_200D_200F_206A_200C_206B_202A_206B_202E;
			}
			[CompilerGenerated]
			private set
			{
				_200E_202A_202C_202E_206D_206B_202D_200E_200D_206E_206D_202D_200F_206A_206B_206C_202B_206E_206B_202C_202E_202B_200B_206F_202E_200D_200E_206C_206C_202B_202E_202E_200D_200F_206A_200C_206B_202A_206B_202E = value;
			}
		}

		public string Audio
		{
			[CompilerGenerated]
			get
			{
				return _200E_202A_202E_202C_200B_200E_200D_202C_206E_206C_202C_200F_200E_206F_206E_202A_202E_206B_200B_202D_202B_200F_202B_206E_200B_200D_206F_206A_200B_202E_200C_200C_200C_200C_206F_206C_202B_206F_200C_202E;
			}
			[CompilerGenerated]
			private set
			{
				_200E_202A_202E_202C_200B_200E_200D_202C_206E_206C_202C_200F_200E_206F_206E_202A_202E_206B_200B_202D_202B_200F_202B_206E_200B_200D_206F_206A_200B_202E_200C_200C_200C_200C_206F_206C_202B_206F_200C_202E = value;
			}
		}

		public string Item
		{
			[CompilerGenerated]
			get
			{
				return _200D_206C_202E_206A_202B_202D_206D_202D_202E_202D_202D_202C_202D_206E_206E_202A_202C_200E_202D_206D_202A_202D_202E_206F_200E_206E_206B_200D_206B_206D_200F_202C_206A_202D_206F_200E_206F_202C_200C_202E_202E;
			}
			[CompilerGenerated]
			private set
			{
				_200D_206C_202E_206A_202B_202D_206D_202D_202E_202D_202D_202C_202D_206E_206E_202A_202C_200E_202D_206D_202A_202D_202E_206F_200E_206E_206B_200D_206B_206D_200F_202C_206A_202D_206F_200E_206F_202C_200C_202E_202E = value;
			}
		}

		public bool IsTimeout
		{
			get
			{
				if (_200F_202A_200C_206F_200E_200D_206D_206F_202E_206B_206C_202D_206B_202E_206A_202A_200F_206E_202D_206E_202C_200F_200F_200F_202B_206B_206D_200C_202C_200D_200C_206C_200D_206F_206F_202E_206A_206E_202C_206D_202E() - activeTime > timeout)
				{
					while (true)
					{
						int num = -2046933849;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num ^ -1339454368)) % 6)
							{
							case 5u:
								break;
							case 3u:
								activeTime = _200F_202A_200C_206F_200E_200D_206D_206F_202E_206B_206C_202D_206B_202E_206A_202A_200F_206E_202D_206E_202C_200F_200F_200F_202B_206B_206D_200C_202C_200D_200C_206C_200D_206F_206F_202E_206A_206E_202C_206D_202E() + (float)_206D_200B_202C_206A_200E_206B_200F_200D_200E_200F_200B_200B_200D_200E_202A_200B_202C_206B_206F_200E_206B_200D_202C_202B_200B_206A_202A_200D_200F_206A_200D_206C_202E_206C_202E_206B_200C_200D_200E_202A_202E(4, 10);
								num = -583720708;
								continue;
							case 4u:
								activeTime = _200F_202A_200C_206F_200E_200D_206D_206F_202E_206B_206C_202D_206B_202E_206A_202A_200F_206E_202D_206E_202C_200F_200F_200F_202B_206B_206D_200C_202C_200D_200C_206C_200D_206F_206F_202E_206A_206E_202C_206D_202E() + _200C_202E_206C_200D_202A_202A_202A_202A_206C_202B_200D_202A_200B_206E_206A_200D_206A_206C_202E_202C_202E_202D_200D_202D_206E_200C_200E_200D_202D_200D_200D_200C_206F_202C_202D_206C_200F_202C_202D_200E_202E(0.7f, 5f);
								num = ((int)num2 * -49625461) ^ 0x21E73DB2;
								continue;
							case 0u:
								return true;
							case 1u:
							{
								int num3;
								int num4;
								if (type != 0)
								{
									num3 = -695899659;
									num4 = num3;
								}
								else
								{
									num3 = -319508226;
									num4 = num3;
								}
								num = num3 ^ ((int)num2 * -1515739348);
								continue;
							}
							default:
								goto end_IL_0016;
							}
							break;
						}
						continue;
						end_IL_0016:
						break;
					}
				}
				return false;
			}
		}

		public bool IsAwake => _200F_202A_200C_206F_200E_200D_206D_206F_202E_206B_206C_202D_206B_202E_206A_202A_200F_206E_202D_206E_202C_200F_200F_200F_202B_206B_206D_200C_202C_200D_200C_206C_200D_206F_206F_202E_206A_206E_202C_206D_202E() > activeTime;

		public MolePojo(int P_0)
			: this(P_0, ResourceStrings.ResStrings[1163])
		{
		}

		public MolePojo()
		{
			type = 1;
			activeTime = _200F_202A_200C_206F_200E_200D_206D_206F_202E_206B_206C_202D_206B_202E_206A_202A_200F_206E_202D_206E_202C_200F_200F_200F_202B_206B_206D_200C_202C_200D_200C_206C_200D_206F_206F_202E_206A_206E_202C_206D_202E() + (float)_206D_200B_202C_206A_200E_206B_200F_200D_200E_200F_200B_200B_200D_200E_202A_200B_202C_206B_206F_200E_206B_200D_202C_202B_200B_206A_202A_200D_200F_206A_200D_206C_202E_206C_202E_206B_200C_200D_200E_202A_202E(4, 10);
		}

		public MolePojo(int P_0, string P_1)
		{
			Point = P_0;
			Audio = P_1;
			activeTime = _200F_202A_200C_206F_200E_200D_206D_206F_202E_206B_206C_202D_206B_202E_206A_202A_200F_206E_202D_206E_202C_200F_200F_200F_202B_206B_206D_200C_202C_200D_200C_206C_200D_206F_206F_202E_206A_206E_202C_206D_202E() + _200C_202E_206C_200D_202A_202A_202A_202A_206C_202B_200D_202A_200B_206E_206A_200D_206A_206C_202E_202C_202E_202D_200D_202D_206E_200C_200E_200D_202D_200D_200D_200C_206F_202C_202D_206C_200F_202C_202D_200E_202E(0.7f, 3f);
		}

		static MolePojo()
		{
			timeout = 0.7f;
			while (true)
			{
				int num = -1914027729;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1191123537)) % 3)
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
					items = new string[10]
					{
						global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3599927863u),
						global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3640742160u),
						global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2095015197u),
						global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1838133380u),
						global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1383386563u),
						global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1810900335u),
						global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1433467182u),
						global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1836900851u),
						global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3748553632u),
						global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1524945252u)
					};
					num = ((int)num2 * -858863578) ^ 0x6045774E;
				}
			}
		}

		private string RandomItem(params string[] names)
		{
			ArrayList arrayList = _200B_202D_200C_206D_206A_202D_200D_206B_202B_206D_206C_200C_202A_200E_200F_200F_206E_206C_200D_206C_206C_200E_202A_202D_202C_202E_206E_206D_206E_206D_200E_206E_202A_202C_206B_200F_206E_206E_206A_206B_202E();
			int num3 = default(int);
			while (true)
			{
				int num = 2048665113;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x697FB18F)) % 7)
					{
					case 6u:
						break;
					case 5u:
						num3 = 0;
						num = ((int)num2 * -342806503) ^ 0x43DB1745;
						continue;
					case 3u:
						num = ((int)num2 * -565053320) ^ 0x6AEB4049;
						continue;
					case 2u:
					{
						int num4;
						if (num3 < names.Length)
						{
							num = 1405712779;
							num4 = num;
						}
						else
						{
							num = 1243126125;
							num4 = num;
						}
						continue;
					}
					case 0u:
						num3++;
						num = (int)(num2 * 812263513) ^ -1719618109;
						continue;
					case 1u:
						_206D_200E_200F_202C_200C_202A_200B_202A_202A_206B_206E_206A_206F_206D_200E_206B_206C_200F_202C_200E_200E_200E_206D_202D_202D_200D_200D_202C_202D_200C_202B_200B_206F_206F_206E_206C_206F_202A_202B_206C_202E(arrayList, (object)names[num3]);
						num = 805786293;
						continue;
					default:
						return _200F_206E_200B_202C_202A_200D_200C_206D_206B_200B_202E_206A_202B_206F_206A_202C_200F_206D_206B_206F_200D_206C_206E_206A_206A_206A_206D_206B_200B_200D_202C_202C_200E_206F_202C_200C_206C_200B_202A_202B_202E(arrayList, _206D_200B_202C_206A_200E_206B_200F_200D_200E_200F_200B_200B_200D_200E_202A_200B_202C_206B_206F_200E_206B_200D_202C_202B_200B_206A_202A_200D_200F_206A_200D_206C_202E_206C_202E_206B_200C_200D_200E_202A_202E(0, _202A_206D_202E_202C_206F_202B_206B_200C_202B_200C_202D_200E_206E_206C_206D_206A_206C_200D_206B_202B_206E_206F_200C_206E_202D_206A_202E_202B_200E_202A_206E_206E_206D_202A_202D_206B_206F_206F_206C_202E(arrayList))) as string;
					}
					break;
				}
			}
		}

		public void Active()
		{
			if (type == 1)
			{
				while (true)
				{
					int num = 1158070180;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ 0x12302391)) % 3)
						{
						case 0u:
							break;
						case 2u:
							Item = RandomItem(items);
							num = (int)(num2 * 893363254) ^ -1570912729;
							continue;
						default:
							goto end_IL_0009;
						}
						break;
					}
					continue;
					end_IL_0009:
					break;
				}
			}
			activeTime = _200F_202A_200C_206F_200E_200D_206D_206F_202E_206B_206C_202D_206B_202E_206A_202A_200F_206E_202D_206E_202C_200F_200F_200F_202B_206B_206D_200C_202C_200D_200C_206C_200D_206F_206F_202E_206A_206E_202C_206D_202E();
		}

		static float _200F_202A_200C_206F_200E_200D_206D_206F_202E_206B_206C_202D_206B_202E_206A_202A_200F_206E_202D_206E_202C_200F_200F_200F_202B_206B_206D_200C_202C_200D_200C_206C_200D_206F_206F_202E_206A_206E_202C_206D_202E()
		{
			return Time.time;
		}

		static int _206D_200B_202C_206A_200E_206B_200F_200D_200E_200F_200B_200B_200D_200E_202A_200B_202C_206B_206F_200E_206B_200D_202C_202B_200B_206A_202A_200D_200F_206A_200D_206C_202E_206C_202E_206B_200C_200D_200E_202A_202E(int P_0, int P_1)
		{
			return Random.Range(P_0, P_1);
		}

		static float _200C_202E_206C_200D_202A_202A_202A_202A_206C_202B_200D_202A_200B_206E_206A_200D_206A_206C_202E_202C_202E_202D_200D_202D_206E_200C_200E_200D_202D_200D_200D_200C_206F_202C_202D_206C_200F_202C_202D_200E_202E(float P_0, float P_1)
		{
			return Random.Range(P_0, P_1);
		}

		static ArrayList _200B_202D_200C_206D_206A_202D_200D_206B_202B_206D_206C_200C_202A_200E_200F_200F_206E_206C_200D_206C_206C_200E_202A_202D_202C_202E_206E_206D_206E_206D_200E_206E_202A_202C_206B_200F_206E_206E_206A_206B_202E()
		{
			return new ArrayList();
		}

		static int _206D_200E_200F_202C_200C_202A_200B_202A_202A_206B_206E_206A_206F_206D_200E_206B_206C_200F_202C_200E_200E_200E_206D_202D_202D_200D_200D_202C_202D_200C_202B_200B_206F_206F_206E_206C_206F_202A_202B_206C_202E(ArrayList P_0, object P_1)
		{
			return P_0.Add(P_1);
		}

		static int _202A_206D_202E_202C_206F_202B_206B_200C_202B_200C_202D_200E_206E_206C_206D_206A_206C_200D_206B_202B_206E_206F_200C_206E_202D_206A_202E_202B_200E_202A_206E_206E_206D_202A_202D_206B_206F_206F_206C_202E(ArrayList P_0)
		{
			return P_0.Count;
		}

		static object _200F_206E_200B_202C_202A_200D_200C_206D_206B_200B_202E_206A_202B_206F_206A_202C_200F_206D_206B_206F_200D_206C_206E_206A_206A_206A_206D_206B_200B_200D_202C_202C_200E_206F_202C_200C_206C_200B_202A_202B_202E(ArrayList P_0, int P_1)
		{
			return P_0[P_1];
		}
	}

	[CompilerGenerated]
	private sealed class _202E_200E_206D_200C_206D_206D_202B_200B_206B_206E_200C_206B_206E_206E_200C_202E_206B_206B_200B_206D_202E_200D_200E_206D_206F_200D_202C_202E_200D_200B_206D_200E_200E_206F_206C_200B_206E_200E_200E_206B_202E
	{
		internal Queue msgs;

		internal CommonSettings.VoidCallBack callback;

		internal WhacAMole _202A_202B_206D_202D_200C_202E_206F_200C_202B_202E_202E_206E_200D_206A_206F_206D_206F_200E_202C_206F_200B_206D_206B_202D_206C_206A_200D_200D_206D_200F_200F_206B_202A_202D_202A_200B_200F_200B_202C_202E_202E;

		internal void _202D_206F_200E_200B_206E_206E_206D_206C_200B_206C_206F_202A_200B_202C_200E_206B_206D_206E_206B_206A_206A_200B_202A_202B_200E_200C_206B_206D_202C_202E_202E_206E_206B_200B_202D_202D_206D_202E_206A_200E_202E()
		{
			if (_202B_206B_200F_200C_202E_200F_206D_206A_206B_206A_206E_202C_202D_206C_206B_206D_200B_206B_202B_200E_202A_202B_202C_206D_200E_202C_202A_202D_202B_200D_206C_200E_202C_206E_206D_202C_200D_206C_202B_200D_202E(msgs) > 0)
			{
				goto IL_000e;
			}
			goto IL_0038;
			IL_000e:
			int num = -97903656;
			goto IL_0013;
			IL_0013:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1319450034)) % 5)
				{
				case 2u:
					break;
				default:
					return;
				case 3u:
					goto IL_0038;
				case 4u:
					num = ((int)num2 * -1781426552) ^ 0x617DDA86;
					continue;
				case 1u:
					_202A_202B_206D_202D_200C_202E_206F_200C_202B_202E_202E_206E_200D_206A_206F_206D_206F_200E_202C_206F_200B_206D_206B_202D_206C_206A_200D_200D_206D_200F_200F_206B_202A_202D_202A_200B_200F_200B_202C_202E_202E.ShowDialog(msgs, callback);
					num = (int)((num2 * 707905149) ^ 0x5B6C451D);
					continue;
				case 0u:
					return;
				}
				break;
			}
			goto IL_000e;
			IL_0038:
			callback();
			num = -1283332754;
			goto IL_0013;
		}

		static int _202B_206B_200F_200C_202E_200F_206D_206A_206B_206A_206E_202C_202D_206C_206B_206D_200B_206B_202B_200E_202A_202B_202C_206D_200E_202C_202A_202D_202B_200D_206C_200E_202C_206E_206D_202C_200D_206C_202B_200D_202E(Queue P_0)
		{
			return P_0.Count;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _206C_200D_202D_200D_206B_200E_206B_200D_202A_202A_200B_200D_206C_206C_206E_202A_206D_206E_200D_206A_200C_200F_206A_200D_206A_202B_202B_202C_206A_206A_202A_200E_202B_206D_202C_206E_202C_202B_202B_206F_202E
	{
		public static readonly _206C_200D_202D_200D_206B_200E_206B_200D_202A_202A_200B_200D_206C_206C_206E_202A_206D_206E_200D_206A_200C_200F_206A_200D_206A_202B_202B_202C_206A_206A_202A_200E_202B_206D_202C_206E_202C_202B_202B_206F_202E _003C_003E9 = new _206C_200D_202D_200D_206B_200E_206B_200D_202A_202A_200B_200D_206C_206C_206E_202A_206D_206E_200D_206A_200C_200F_206A_200D_206A_202B_202B_202C_206A_206A_202A_200E_202B_206D_202C_206E_202C_202B_202B_206F_202E();

		public static CommonSettings.VoidCallBack _003C_003E9__0_0;

		internal void _202A_200B_202E_202D_206E_206F_202C_206D_206B_200B_200E_202D_202A_202E_200B_206A_206B_202E_200D_206B_200D_202A_206E_200B_206E_206E_202C_200B_200C_202B_206D_202C_206A_206B_202A_202E_202B_202D_200F_200E_202E()
		{
			RuntimeData.Instance.gameEngine.SwitchGameScene(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4092172572u), ResourceStrings.ResStrings[1162]);
		}
	}

	public GameObject dong;

	public GameObject xi;

	public GameObject nan;

	public GameObject bei;

	public GameObject wu;

	public GameObject bomb;

	public GameObject dialogPanel;

	private DodgeUI dialog;

	private Dictionary<GameObject, MolePojo> pojos = new Dictionary<GameObject, MolePojo>();

	private ArrayList hidePojo = _206E_200C_206E_200B_206E_200D_202A_200F_206A_202E_206C_202D_206F_202E_200B_202C_206B_206C_202C_202B_202E_202E_202B_206B_200C_202C_202D_206D_206B_202D_202A_200C_200E_206D_202B_206E_202A_200C_200B_200F_202E();

	private ArrayList showPojo = _206E_200C_206E_200B_206E_200D_202A_200F_206A_202E_206C_202D_206F_202E_200B_202C_206B_206C_202C_202B_202E_202E_202B_206B_200C_202C_202D_206D_206B_202D_202A_200C_200E_206D_202B_206E_202A_200C_200B_200F_202E();

	private Dictionary<string, int> items = new Dictionary<string, int>();

	private static ArrayList uniqueItems;

	private int point;

	private float bombTime;

	private float startTime;

	private bool flag = true;

	private static Vector3 target;

	private Vector3 moveDirect;

	[CompilerGenerated]
	private static CommonSettings.VoidCallBack _200B_200C_200E_200F_202C_206C_206A_200D_200E_202D_206F_206B_200E_200E_202B_206A_206B_202A_206A_206F_202B_200C_202E_206A_200B_200D_206F_206B_206D_200E_206B_200F_206C_200F_200C_200D_206C_202E_200E_200C_202E;

	static WhacAMole()
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		ArrayList arrayList = _206E_200C_206E_200B_206E_200D_202A_200F_206A_202E_206C_202D_206F_202E_200B_202C_206B_206C_202C_202B_202E_202E_202B_206B_200C_202C_202D_206D_206B_202D_202A_200C_200E_206D_202B_206E_202A_200C_200B_200F_202E();
		while (true)
		{
			int num = -1717635497;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1127783550)) % 4)
				{
				case 0u:
					break;
				case 1u:
					_206E_202C_202E_206A_206E_200C_202B_206A_202A_206F_202D_200C_200F_202E_200D_206D_206B_200B_202A_206F_206A_202D_206E_200F_202B_202C_202D_202D_200B_200D_202E_206A_206E_206F_202D_206A_206C_202B_200B_206F_202E(arrayList, (object)global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4268672704u));
					num = (int)(num2 * 993920647) ^ -919376469;
					continue;
				case 2u:
					_206E_202C_202E_206A_206E_200C_202B_206A_202A_206F_202D_200C_200F_202E_200D_206D_206B_200B_202A_206F_206A_202D_206E_200F_202B_202C_202D_202D_200B_200D_202E_206A_206E_206F_202D_206A_206C_202B_200B_206F_202E(arrayList, (object)global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3376297268u));
					_206E_202C_202E_206A_206E_200C_202B_206A_202A_206F_202D_200C_200F_202E_200D_206D_206B_200B_202A_206F_206A_202D_206E_200F_202B_202C_202D_202D_200B_200D_202E_206A_206E_206F_202D_206A_206C_202B_200B_206F_202E(arrayList, (object)global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1836900851u));
					_206E_202C_202E_206A_206E_200C_202B_206A_202A_206F_202D_200C_200F_202E_200D_206D_206B_200B_202A_206F_206A_202D_206E_200F_202B_202C_202D_202D_200B_200D_202E_206A_206E_206F_202D_206A_206C_202B_200B_206F_202E(arrayList, (object)global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1524945252u));
					uniqueItems = arrayList;
					num = (int)(num2 * 551430347) ^ -1031287453;
					continue;
				default:
					target = new Vector3(720f, -450f);
					return;
				}
				break;
			}
		}
	}

	private void Start()
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		if (CommonSettings.ScreenScale >= 2f)
		{
			goto IL_000c;
		}
		goto IL_0064;
		IL_000c:
		int num = -913148704;
		goto IL_0011;
		IL_0011:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -862540518)) % 5)
			{
			case 4u:
				break;
			case 0u:
				bomb.GetComponent<Image>().sprite = Resource.GetIcon(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2031594047u));
				num = (int)((num2 * 1984554702) ^ 0x70600D29);
				continue;
			case 3u:
				goto IL_0064;
			case 1u:
				_202B_206F_206D_200F_202B_200C_200B_206A_202C_200F_202C_206D_206C_200D_202E_200C_206C_202A_200F_200E_200E_206B_206C_206B_202A_202D_200B_200B_206A_200B_206D_206B_202B_202E_202A_200F_200E_200E_202E_200E_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1142946836u)).GetComponent<RectTransform>().sizeDelta = new Vector2(640f * CommonSettings.ScreenScale, 640f);
				num = (int)(num2 * 1769952154) ^ -874339754;
				continue;
			default:
				goto IL_00b5;
			}
			break;
		}
		goto IL_000c;
		IL_01b6:
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num3 ^ -862540518)) % 9)
			{
			case 8u:
				break;
			default:
				return;
			case 3u:
				pojos.Add(nan, new MolePojo(2));
				pojos.Add(bei, new MolePojo(3));
				num3 = (int)((num2 * 1027106295) ^ 0x7BB5D721);
				continue;
			case 5u:
				dialog = dialogPanel.GetComponent<DodgeUI>();
				num3 = ((int)num2 * -1219159390) ^ -820050226;
				continue;
			case 4u:
				uniqueItems = new ArrayList
				{
					global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1810900335u),
					global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3376297268u),
					global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1836900851u),
					global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2107781877u)
				};
				num3 = ((int)num2 * -1286591040) ^ 0x6D20C649;
				continue;
			case 6u:
				goto IL_02af;
			case 1u:
				MolePojo.items = new string[10]
				{
					global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3599927863u),
					global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3640742160u),
					global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2095015197u),
					global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(142756864u),
					global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(996242214u),
					global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1810900335u),
					global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1164394552u),
					global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1836900851u),
					global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3879256625u),
					global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3777520771u)
				};
				num3 = ((int)num2 * -1936712295) ^ 0x5ACC009B;
				continue;
			case 7u:
				startTime = Time.time;
				num3 = (int)(num2 * 405914511) ^ -446944269;
				continue;
			case 2u:
				pojos.Add(wu, new MolePojo());
				hidePojo.AddRange(pojos.Keys);
				num3 = (int)(num2 * 1876832782) ^ -325755337;
				continue;
			case 0u:
				return;
			}
			break;
		}
		goto IL_01b1;
		IL_02af:
		pojos.Add(dong, new MolePojo(-2, ResourceStrings.ResStrings[1164]));
		pojos.Add(xi, new MolePojo(4));
		num3 = -1198424580;
		goto IL_01b6;
		IL_0064:
		if (CommonSettings.MOD_MODE)
		{
			num = -1212126982;
			goto IL_0011;
		}
		goto IL_02af;
		IL_01b1:
		num3 = -1854037639;
		goto IL_01b6;
		IL_00b5:
		bool flag = false;
		try
		{
			uniqueItems = new ArrayList(LuaManager.CallWithStringReturn(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3916992118u), true).Split('#'));
			MolePojo.items = LuaManager.CallWithStringReturn(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(954922977u), false).Split('#');
			while (true)
			{
				IL_0122:
				int num4 = -1927747811;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num4 ^ -862540518)) % 5)
					{
					case 0u:
						break;
					default:
						goto end_IL_0127;
					case 3u:
					{
						int num7;
						int num8;
						if (uniqueItems.Count <= 0)
						{
							num7 = -1862926165;
							num8 = num7;
						}
						else
						{
							num7 = -1902567487;
							num8 = num7;
						}
						num4 = num7 ^ ((int)num2 * -1453837174);
						continue;
					}
					case 4u:
					{
						int num5;
						int num6;
						if (MolePojo.items.Length != 0)
						{
							num5 = 1119793781;
							num6 = num5;
						}
						else
						{
							num5 = 2095751965;
							num6 = num5;
						}
						num4 = num5 ^ (int)(num2 * 1175762736);
						continue;
					}
					case 2u:
						flag = true;
						num4 = ((int)num2 * -786076574) ^ 0x6FEACEB3;
						continue;
					case 1u:
						goto end_IL_0127;
					}
					goto IL_0122;
					continue;
					end_IL_0127:
					break;
				}
				break;
			}
		}
		catch
		{
			flag = false;
		}
		if (!flag)
		{
			goto IL_01b1;
		}
		goto IL_02af;
	}

	private void GameOver()
	{
		Queue queue = _202B_206A_206A_200D_200E_206A_202D_202B_200F_200E_200B_200F_206C_206A_206A_206E_202E_202B_200C_200F_206F_200C_200D_206D_206F_200C_202C_200D_206C_206F_200D_206A_206D_206A_202E_202B_200C_206B_202C_200D_202E();
		using (Dictionary<string, int>.KeyCollection.Enumerator enumerator = items.Keys.GetEnumerator())
		{
			string current = default(string);
			while (true)
			{
				IL_0055:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -2124039002;
					num2 = num;
				}
				else
				{
					num = -2072437667;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -47871307)) % 5)
					{
					case 3u:
						num = -2124039002;
						continue;
					default:
						goto end_IL_001e;
					case 1u:
						current = enumerator.Current;
						num = -768828295;
						continue;
					case 4u:
						break;
					case 2u:
						RuntimeData.Instance.addItem(ResourceManager.Get<Item>(current), items[current]);
						_206E_206A_206D_200C_206D_202A_202C_202A_200D_202A_200B_206F_200D_206B_200D_206C_206F_202E_200E_200E_206F_202B_206E_200B_206E_200C_206B_202D_206C_202A_202C_202C_206E_200B_202C_200C_200C_200B_206F_202B_202E(queue, (object)_202D_200B_206D_206E_202A_202E_206E_206A_206C_200B_206D_202E_200B_202E_206A_206F_206D_202D_200D_202C_200B_202C_206C_206A_202D_206F_206F_200F_206D_206C_206E_202D_200D_202E_206A_206E_202B_202B_206F_206D_202E(ResourceStrings.ResStrings[1176], (object)current, (object)items[current]));
						num = ((int)num3 * -1463066636) ^ -1462166391;
						continue;
					case 0u:
						goto end_IL_001e;
					}
					goto IL_0055;
					continue;
					end_IL_001e:
					break;
				}
				break;
			}
		}
		RuntimeData.Instance.biliPoint = RuntimeData.Instance.biliPoint + point;
		if (RuntimeData.Instance.Team[0].Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1564888282u)] >= CommonSettings.SMALLGAME_MAX_ATTRIBUTE)
		{
			goto IL_0122;
		}
		goto IL_02b3;
		IL_02b3:
		int num4;
		int num5;
		if (RuntimeData.Instance.biliPoint >= RuntimeData.Instance.Team[0].Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(655417903u)])
		{
			num4 = -1951798337;
			num5 = num4;
		}
		else
		{
			num4 = -658021346;
			num5 = num4;
		}
		goto IL_0127;
		IL_0122:
		num4 = -823753323;
		goto IL_0127;
		IL_0127:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num4 ^ -47871307)) % 9)
			{
			case 0u:
				break;
			case 6u:
				_206E_206A_206D_200C_206D_202A_202C_202A_200D_202A_200B_206F_200D_206B_200D_206C_206F_202E_200E_200E_206F_202B_206E_200B_206E_200C_206B_202D_206C_202A_202C_202C_206E_200B_202C_200C_200C_200B_206F_202B_202E(queue, (object)ResourceStrings.ResStrings[1179]);
				num4 = -244844682;
				continue;
			case 4u:
				num4 = (int)((num3 * 489601191) ^ 0x571C276A);
				continue;
			case 5u:
				RuntimeData.Instance.biliPoint = 0;
				num4 = (int)(num3 * 274944961) ^ -207207269;
				continue;
			case 3u:
				_206E_206A_206D_200C_206D_202A_202C_202A_200D_202A_200B_206F_200D_206B_200D_206C_206F_202E_200E_200E_206F_202B_206E_200B_206E_200C_206B_202D_206C_202A_202C_202C_206E_200B_202C_200C_200C_200B_206F_202B_202E(queue, (object)_202D_200B_206D_206E_202A_202E_206E_206A_206C_200B_206D_202E_200B_202E_206A_206F_206D_202D_200D_202C_200B_202C_206C_206A_202D_206F_206F_200F_206D_206C_206E_202D_200D_202E_206A_206E_202B_202B_206F_206D_202E(ResourceStrings.ResStrings[1178], (object)RuntimeData.Instance.Team[0].Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(710450445u)], (object)(RuntimeData.Instance.Team[0].Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(710450445u)] + 5)));
				RuntimeData.Instance.Team[0].Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1564888282u)] = RuntimeData.Instance.Team[0].Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(710450445u)] + 5;
				num4 = (int)((num3 * 967596157) ^ 0x72A3209C);
				continue;
			case 2u:
				RuntimeData.Instance.biliPoint = 0;
				num4 = (int)((num3 * 21313806) ^ 0x5E4619C8);
				continue;
			case 1u:
				_206E_206A_206D_200C_206D_202A_202C_202A_200D_202A_200B_206F_200D_206B_200D_206C_206F_202E_200E_200E_206F_202B_206E_200B_206E_200C_206B_202D_206C_202A_202C_202C_206E_200B_202C_200C_200C_200B_206F_202B_202E(queue, (object)ResourceStrings.ResStrings[1177]);
				num4 = ((int)num3 * -536407083) ^ 0x124465D0;
				continue;
			case 7u:
				goto IL_02b3;
			default:
				ShowDialog(queue, delegate
				{
					RuntimeData.Instance.gameEngine.SwitchGameScene(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4092172572u), ResourceStrings.ResStrings[1162]);
				});
				return;
			}
			break;
		}
		goto IL_0122;
	}

	private void ShowDialog(string msg, CommonSettings.VoidCallBack callback = null)
	{
		string[] array = _200E_200C_206D_206F_200D_206F_202C_200E_206D_200C_206F_200C_206D_202C_206A_202B_206A_202C_202D_206E_206E_206F_200E_200E_206F_206F_200C_202D_206C_200F_202D_206A_202B_200C_206A_206E_202A_202B_206B_206B_202E(msg, new char[1] { '|' });
		while (true)
		{
			int num = 1786814628;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x66EE6661)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_0034;
				case 2u:
					return;
				}
				break;
				IL_0034:
				dialog.Show(array[0], array[1], callback);
				num = ((int)num2 * -200750827) ^ -1893444749;
			}
		}
	}

	private void ShowDialog(Queue msgs, CommonSettings.VoidCallBack callback = null)
	{
		Queue msgs2 = default(Queue);
		CommonSettings.VoidCallBack callback2 = default(CommonSettings.VoidCallBack);
		WhacAMole whacAMole = default(WhacAMole);
		while (true)
		{
			int num = 1124821636;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x67AB230D)) % 5)
				{
				case 3u:
					break;
				default:
					return;
				case 1u:
					msgs2 = msgs;
					callback2 = callback;
					num = (int)(num2 * 1339573246) ^ -640385877;
					continue;
				case 4u:
					whacAMole = this;
					num = ((int)num2 * -156894700) ^ 0x4747A9C6;
					continue;
				case 0u:
					ShowDialog(_202E_200B_206A_202A_202D_202E_200F_200B_206C_206B_206D_200C_200B_200E_206D_206D_200B_202B_202A_202D_206F_202A_206F_200D_206F_206F_206A_200B_200F_200E_200C_206D_200C_202E_202A_200B_206A_200F_206F_206B_202E(msgs2) as string, delegate
					{
						if (_202E_200E_206D_200C_206D_206D_202B_200B_206B_206E_200C_206B_206E_206E_200C_202E_206B_206B_200B_206D_202E_200D_200E_206D_206F_200D_202C_202E_200D_200B_206D_200E_200E_206F_206C_200B_206E_200E_200E_206B_202E._202B_206B_200F_200C_202E_200F_206D_206A_206B_206A_206E_202C_202D_206C_206B_206D_200B_206B_202B_200E_202A_202B_202C_206D_200E_202C_202A_202D_202B_200D_206C_200E_202C_206E_206D_202C_200D_206C_202B_200D_202E(msgs2) > 0)
						{
							goto IL_000e;
						}
						goto IL_0038;
						IL_000e:
						int num3 = -97903656;
						goto IL_0013;
						IL_0013:
						while (true)
						{
							uint num4;
							switch ((num4 = (uint)(num3 ^ -1319450034)) % 5)
							{
							case 2u:
								break;
							default:
								return;
							case 3u:
								goto IL_0038;
							case 4u:
								num3 = ((int)num4 * -1781426552) ^ 0x617DDA86;
								continue;
							case 1u:
								whacAMole.ShowDialog(msgs2, callback2);
								num3 = (int)((num4 * 707905149) ^ 0x5B6C451D);
								continue;
							case 0u:
								return;
							}
							break;
						}
						goto IL_000e;
						IL_0038:
						callback2();
						num3 = -1283332754;
						goto IL_0013;
					});
					num = (int)((num2 * 35689629) ^ 0x153E0117);
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void Update()
	{
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		if (!flag)
		{
			goto IL_0008;
		}
		goto IL_0040;
		IL_0008:
		int num = -1540197775;
		goto IL_000d;
		IL_000d:
		uint num2;
		switch ((num2 = (uint)(num ^ -273994520)) % 4)
		{
		case 0u:
			break;
		case 1u:
			return;
		case 3u:
			goto IL_0040;
		default:
		{
			flag = false;
			IEnumerator enumerator = _206D_206E_206F_200C_206F_200B_206B_206E_200E_200C_206D_200B_202C_200F_202A_206B_202A_202D_200C_206F_206F_206E_202C_206D_206B_206B_202A_206A_206D_200B_202C_202A_200E_200E_206C_202C_206F_206B_206D_202C_202E(showPojo);
			try
			{
				while (true)
				{
					IL_00b3:
					int num3;
					int num4;
					if (_202C_206F_206E_202B_202B_206E_200F_206C_206E_206D_206D_202E_206F_206C_206F_200E_200D_200D_200C_202B_206D_206D_200C_200D_206A_200F_200B_202D_202D_202D_200F_202B_202E_206B_200E_206A_206E_200B_206B_206F_202E(enumerator))
					{
						num3 = -1210960183;
						num4 = num3;
					}
					else
					{
						num3 = -30384713;
						num4 = num3;
					}
					while (true)
					{
						switch ((num2 = (uint)(num3 ^ -273994520)) % 4)
						{
						case 0u:
							num3 = -1210960183;
							continue;
						default:
							goto end_IL_0077;
						case 1u:
						{
							GameObject val = (GameObject)_206C_206B_206F_206D_202B_206E_206E_202E_200B_206D_200C_202B_206C_200C_202D_200B_200B_200B_202D_206A_200F_202D_200B_202A_202E_200E_206B_206B_200F_202A_206F_206F_202A_202B_200C_202B_200F_202C_206B_202C_202E(enumerator);
							_200D_200C_200C_200C_200D_200E_202D_202B_200B_206C_200F_206F_206D_206C_202E_206F_200C_206D_200F_202A_206A_206B_200D_206F_206E_206D_206E_202A_202E_206F_202D_206A_206C_200F_200D_200B_200E_200F_206D_200F_202E(val, false);
							num3 = -1950995006;
							continue;
						}
						case 2u:
							break;
						case 3u:
							goto end_IL_0077;
						}
						goto IL_00b3;
						continue;
						end_IL_0077:
						break;
					}
					break;
				}
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				while (true)
				{
					IL_00d6:
					int num5 = -248175821;
					while (true)
					{
						switch ((num2 = (uint)(num5 ^ -273994520)) % 5)
						{
						case 3u:
							break;
						default:
							goto end_IL_00db;
						case 2u:
						{
							int num6;
							int num7;
							if (disposable == null)
							{
								num6 = 505274813;
								num7 = num6;
							}
							else
							{
								num6 = 641298351;
								num7 = num6;
							}
							num5 = num6 ^ (int)(num2 * 2012958417);
							continue;
						}
						case 4u:
							goto end_IL_00db;
						case 0u:
							_200F_206D_200E_202A_206F_206D_202A_200B_206A_206D_200F_206D_206D_206A_200D_200E_200E_200E_206D_202A_200C_206B_206E_200D_200D_200C_202D_202B_200F_200F_202A_200D_200E_202C_206E_200C_200E_200C_206E_202E(disposable);
							num5 = -1098065287;
							continue;
						case 1u:
							goto end_IL_00db;
						}
						goto IL_00d6;
						continue;
						end_IL_00db:
						break;
					}
					break;
				}
			}
			GameOver();
			return;
		}
		}
		goto IL_0008;
		IL_0040:
		if (_206A_206D_206C_202A_206B_200E_200D_202E_202E_202C_202A_202B_206D_202B_200E_206E_202B_202C_202E_206A_206F_202A_206B_202E_206E_206E_200C_206B_202A_200E_206B_206D_200F_200D_200C_202B_200E_200D_206E_202D_202E() - startTime > 30f)
		{
			num = -1154405698;
			goto IL_000d;
		}
		GameObject val3 = default(GameObject);
		int num19 = default(int);
		GameObject val2 = default(GameObject);
		while (true)
		{
			int num8 = _206E_202C_206F_206B_200D_202A_206D_202A_206A_202B_200F_200B_200C_200E_200D_202C_200E_202B_200F_206C_206E_200C_206C_206E_200F_206E_202D_202C_202B_206F_202A_206C_200E_202D_206F_202E_200F_200C_202B_206A_202E(hidePojo) - 1;
			int num9 = -1440857401;
			while (true)
			{
				switch ((num2 = (uint)(num9 ^ -273994520)) % 26)
				{
				case 17u:
					num9 = -146155223;
					continue;
				default:
					return;
				case 23u:
				{
					int num24;
					if (pojos[val3].IsTimeout)
					{
						num9 = -1933803531;
						num24 = num9;
					}
					else
					{
						num9 = -1068855227;
						num24 = num9;
					}
					continue;
				}
				case 13u:
					num19--;
					num9 = -1886128132;
					continue;
				case 10u:
					num9 = ((int)num2 * -344754156) ^ 0x519D8755;
					continue;
				case 7u:
					num8--;
					num9 = -2078278149;
					continue;
				case 19u:
					break;
				case 20u:
					num19 = showPojo.Count - 1;
					num9 = ((int)num2 * -454938398) ^ 0x6D7760EB;
					continue;
				case 14u:
					_200D_200C_200C_200C_200D_200E_202D_202B_200B_206C_200F_206F_206D_206C_202E_206F_200C_206D_200F_202A_206A_206B_200D_206F_206E_206D_206E_202A_202E_206F_202D_206A_206C_200F_200D_200B_200E_200F_206D_200F_202E(val2, true);
					_200D_200F_206D_202B_200B_206B_206B_202D_202B_206C_206B_206C_202B_206D_202C_206E_200F_202B_200B_206F_200B_202D_206F_200B_200C_206C_206A_202C_202C_202A_202D_200B_206F_200B_200D_200E_206A_202B_206C_202D_202E(val2).position = new Vector3((float)_200D_200E_202A_202B_200F_200C_202E_202A_202C_206A_202D_206D_200E_202C_202B_202A_200E_206F_206E_206C_200B_206B_206F_206D_206E_202A_206B_200C_200E_202D_202C_202D_202B_200C_206A_202C_202A_206E_200F_206D_202E(-487, 494), (float)_200D_200E_202A_202B_200F_200C_202E_202A_202C_206A_202D_206D_200E_202C_202B_202A_200E_206F_206E_206C_200B_206B_206F_206D_206E_202A_206B_200C_200E_202D_202C_202D_202B_200C_206A_202C_202A_206E_200F_206D_202E(-249, 239));
					num9 = -857111454;
					continue;
				case 24u:
					hidePojo.RemoveAt(num8);
					showPojo.Add(val2);
					num9 = ((int)num2 * -1983740325) ^ 0x2554DE6B;
					continue;
				case 6u:
				{
					int num23;
					if (num19 >= 0)
					{
						num9 = -1758617754;
						num23 = num9;
					}
					else
					{
						num9 = -153928013;
						num23 = num9;
					}
					continue;
				}
				case 0u:
				{
					object obj2 = showPojo[num19];
					val3 = (GameObject)((obj2 is GameObject) ? obj2 : null);
					int num20;
					if (!((Object)(object)val3 == (Object)(object)wu))
					{
						num9 = -907852809;
						num20 = num9;
					}
					else
					{
						num9 = -1938223836;
						num20 = num9;
					}
					continue;
				}
				case 12u:
				{
					object obj = _202B_202E_206F_200C_200E_206F_206B_200E_202C_202D_206D_200F_202E_206A_202E_206C_206B_200E_202D_202D_202C_202D_202E_200D_200E_202E_206D_206C_206D_202A_202E_202B_206A_200D_206C_206A_206A_202D_200C_206D_202E(hidePojo, num8);
					val2 = (GameObject)((obj is GameObject) ? obj : null);
					int num16;
					if (!pojos[val2].IsAwake)
					{
						num9 = -634717339;
						num16 = num9;
					}
					else
					{
						num9 = -914715752;
						num16 = num9;
					}
					continue;
				}
				case 16u:
					moveDirect = Vector3.zero;
					num9 = (int)(num2 * 1230480336) ^ -1146131202;
					continue;
				case 8u:
				{
					int num12;
					int num13;
					if (!(moveDirect != Vector3.zero))
					{
						num12 = -129377817;
						num13 = num12;
					}
					else
					{
						num12 = -472292596;
						num13 = num12;
					}
					num9 = num12 ^ ((int)num2 * -663547284);
					continue;
				}
				case 5u:
					_200E_200E_202E_202B_206D_202A_202B_202C_200F_200F_200C_200D_206D_202E_206E_206D_202A_200B_200B_206E_200D_202E_202D_206F_200E_200D_206A_206B_206D_202A_202B_206F_200C_206F_200C_206B_200D_202D_202A_200C_202E(val2.GetComponent<Image>(), Resource.GetImage(ResourceManager.Get<Item>(pojos[val2].Item).pic, forceLoadFromResource: false));
					num9 = ((int)num2 * -916740801) ^ 0x7B7FF073;
					continue;
				case 21u:
					val3.SetActive(false);
					showPojo.RemoveAt(num19);
					hidePojo.Add(val3);
					num9 = (int)(num2 * 943574731) ^ -1107055174;
					continue;
				case 3u:
					bomb.SetActive(false);
					num9 = (int)((num2 * 1287617817) ^ 0xD130677);
					continue;
				case 25u:
				{
					int num22;
					if (num8 >= 0)
					{
						num9 = -318285398;
						num22 = num9;
					}
					else
					{
						num9 = -948816092;
						num22 = num9;
					}
					continue;
				}
				case 2u:
				{
					int num21;
					if (moveDirect != Vector3.zero)
					{
						num9 = -1955297609;
						num21 = num9;
					}
					else
					{
						num9 = -261276450;
						num21 = num9;
					}
					continue;
				}
				case 11u:
					num9 = ((int)num2 * -213446868) ^ 0x4CB34CEF;
					continue;
				case 9u:
					num9 = (int)((num2 * 14484516) ^ 0x4319B030);
					continue;
				case 1u:
				{
					int num17;
					int num18;
					if ((double)(Time.time - bombTime) <= 0.5)
					{
						num17 = -118655134;
						num18 = num17;
					}
					else
					{
						num17 = -546639643;
						num18 = num17;
					}
					num9 = num17 ^ ((int)num2 * -1752626094);
					continue;
				}
				case 22u:
				{
					int num14;
					int num15;
					if (Vector3.Distance(wu.transform.position, target) < 1f)
					{
						num14 = 2018069890;
						num15 = num14;
					}
					else
					{
						num14 = 1958067870;
						num15 = num14;
					}
					num9 = num14 ^ ((int)num2 * -574366624);
					continue;
				}
				case 18u:
				{
					pojos[val2].Active();
					int num10;
					int num11;
					if (pojos[val2].Item == null)
					{
						num10 = -169254020;
						num11 = num10;
					}
					else
					{
						num10 = -1103695015;
						num11 = num10;
					}
					num9 = num10 ^ (int)(num2 * 1702489476);
					continue;
				}
				case 15u:
					wu.transform.Translate(moveDirect);
					num9 = ((int)num2 * -1169608557) ^ -454586845;
					continue;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	public void Hit(GameObject sender)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		MolePojo molePojo = pojos[sender];
		while (true)
		{
			int num = 1817131082;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6389F2BF)) % 14)
				{
				case 3u:
					break;
				default:
					return;
				case 1u:
				{
					point += molePojo.Point;
					int num6;
					int num7;
					if (molePojo.Audio == null)
					{
						num6 = -1527280317;
						num7 = num6;
					}
					else
					{
						num6 = -2021528459;
						num7 = num6;
					}
					num = num6 ^ ((int)num2 * -1089644211);
					continue;
				}
				case 2u:
				{
					moveDirect = (target - _200B_202D_206B_206D_202D_206B_202B_206F_206D_206B_206A_200F_206C_202C_206F_202D_206A_200F_206D_206D_200E_202E_206C_200B_202B_206F_206B_202C_200E_206E_200F_202C_202B_202B_206B_202B_206C_202B_202B_206A_202E(_200D_200F_206D_202B_200B_206B_206B_202D_202B_206C_206B_206C_202B_206D_202C_206E_200F_202B_200B_206F_200B_202D_206F_200B_200C_206C_206A_202C_202C_202A_202D_200B_206F_200B_200D_200E_206A_202B_206C_202D_202E(sender))) / 20f;
					int num4;
					int num5;
					if (items.ContainsKey(molePojo.Item))
					{
						num4 = -1089050608;
						num5 = num4;
					}
					else
					{
						num4 = -413873891;
						num5 = num4;
					}
					num = num4 ^ ((int)num2 * -1048812631);
					continue;
				}
				case 11u:
				{
					int num9;
					if (molePojo.Item == null)
					{
						num = 1787606037;
						num9 = num;
					}
					else
					{
						num = 286223647;
						num9 = num;
					}
					continue;
				}
				case 7u:
					_200C_202D_202E_206D_202D_200C_202A_202C_200D_200B_206C_202D_206E_202D_206B_206E_206A_200D_206F_202C_202A_206C_206C_202A_206A_200B_206D_200E_202C_200F_206F_202E_206C_202C_200D_200E_202C_200B_200D_206A_202E(_200D_200F_206D_202B_200B_206B_206B_202D_202B_206C_206B_206C_202B_206D_202C_206E_200F_202B_200B_206F_200B_202D_206F_200B_200C_206C_206A_202C_202C_202A_202D_200B_206F_200B_200D_200E_206A_202B_206C_202D_202E(bomb), _200B_202D_206B_206D_202D_206B_202B_206F_206D_206B_206A_200F_206C_202C_206F_202D_206A_200F_206D_206D_200E_202E_206C_200B_202B_206F_206B_202C_200E_206E_200F_202C_202B_202B_206B_202B_206C_202B_202B_206A_202E(_200D_200F_206D_202B_200B_206B_206B_202D_202B_206C_206B_206C_202B_206D_202C_206E_200F_202B_200B_206F_200B_202D_206F_200B_200C_206C_206A_202C_202C_202A_202D_200B_206F_200B_200D_200E_206A_202B_206C_202D_202E(sender)));
					num = ((int)num2 * -733892891) ^ -504379937;
					continue;
				case 0u:
					bombTime = _206A_206D_206C_202A_206B_200E_200D_202E_202E_202C_202A_202B_206D_202B_200E_206E_202B_202C_202E_206A_206F_202A_206B_202E_206E_206E_200C_206B_202A_200E_206B_206D_200F_200D_200C_202B_200E_200D_206E_202D_202E();
					num = 225311934;
					continue;
				case 5u:
					_200D_200C_200C_200C_200D_200E_202D_202B_200B_206C_200F_206F_206D_206C_202E_206F_200C_206D_200F_202A_206A_206B_200D_206F_206E_206D_206E_202A_202E_206F_202D_206A_206C_200F_200D_200B_200E_200F_206D_200F_202E(bomb, true);
					num = ((int)num2 * -1692851221) ^ 0x6407F5D0;
					continue;
				case 6u:
					items.Add(molePojo.Item, 1);
					num = 1521338609;
					continue;
				case 10u:
					return;
				case 13u:
				{
					Dictionary<string, int> dictionary2;
					Dictionary<string, int> dictionary = (dictionary2 = items);
					string item;
					string key = (item = molePojo.Item);
					int num8 = dictionary2[item];
					dictionary[key] = num8 + 1;
					num = ((int)num2 * -950930470) ^ -1977376235;
					continue;
				}
				case 9u:
					AudioManager.Instance.PlayEffect(molePojo.Audio);
					num = (int)((num2 * 1604302487) ^ 0x7BE0917F);
					continue;
				case 4u:
					num = ((int)num2 * -409318331) ^ -1503734035;
					continue;
				case 12u:
				{
					int num3;
					if (_200E_206E_202D_202C_202B_206A_202A_206C_206A_202D_200C_206E_200B_200F_206E_206D_206B_206F_202B_206E_202C_206A_206C_202C_202B_202E_202D_200C_206F_202B_200D_202D_206C_202A_206C_200E_200C_206D_206B_206A_202E(uniqueItems, (object)molePojo.Item))
					{
						num = 1042645541;
						num3 = num;
					}
					else
					{
						num = 1042645541;
						num3 = num;
					}
					continue;
				}
				case 8u:
					return;
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private static void _206A_200B_200C_200D_206C_202A_206A_202C_200D_202E_202A_202A_202B_206B_206E_202C_200F_202E_206E_206C_202B_202A_202B_200B_200E_206A_200D_200C_206E_200B_202A_200C_202A_200B_206C_206B_200D_206E_206D_206E_202E()
	{
		RuntimeData.Instance.gameEngine.SwitchGameScene(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(117271931u), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3531535823u));
	}

	static ArrayList _206E_200C_206E_200B_206E_200D_202A_200F_206A_202E_206C_202D_206F_202E_200B_202C_206B_206C_202C_202B_202E_202E_202B_206B_200C_202C_202D_206D_206B_202D_202A_200C_200E_206D_202B_206E_202A_200C_200B_200F_202E()
	{
		return new ArrayList();
	}

	static int _206E_202C_202E_206A_206E_200C_202B_206A_202A_206F_202D_200C_200F_202E_200D_206D_206B_200B_202A_206F_206A_202D_206E_200F_202B_202C_202D_202D_200B_200D_202E_206A_206E_206F_202D_206A_206C_202B_200B_206F_202E(ArrayList P_0, object P_1)
	{
		return P_0.Add(P_1);
	}

	static GameObject _202B_206F_206D_200F_202B_200C_200B_206A_202C_200F_202C_206D_206C_200D_202E_200C_206C_202A_200F_200E_200E_206B_206C_206B_202A_202D_200B_200B_206A_200B_206D_206B_202B_202E_202A_200F_200E_200E_202E_200E_202E(string P_0)
	{
		return GameObject.Find(P_0);
	}

	static Queue _202B_206A_206A_200D_200E_206A_202D_202B_200F_200E_200B_200F_206C_206A_206A_206E_202E_202B_200C_200F_206F_200C_200D_206D_206F_200C_202C_200D_206C_206F_200D_206A_206D_206A_202E_202B_200C_206B_202C_200D_202E()
	{
		return new Queue();
	}

	static string _202D_200B_206D_206E_202A_202E_206E_206A_206C_200B_206D_202E_200B_202E_206A_206F_206D_202D_200D_202C_200B_202C_206C_206A_202D_206F_206F_200F_206D_206C_206E_202D_200D_202E_206A_206E_202B_202B_206F_206D_202E(string P_0, object P_1, object P_2)
	{
		return string.Format(P_0, P_1, P_2);
	}

	static void _206E_206A_206D_200C_206D_202A_202C_202A_200D_202A_200B_206F_200D_206B_200D_206C_206F_202E_200E_200E_206F_202B_206E_200B_206E_200C_206B_202D_206C_202A_202C_202C_206E_200B_202C_200C_200C_200B_206F_202B_202E(Queue P_0, object P_1)
	{
		P_0.Enqueue(P_1);
	}

	static string[] _200E_200C_206D_206F_200D_206F_202C_200E_206D_200C_206F_200C_206D_202C_206A_202B_206A_202C_202D_206E_206E_206F_200E_200E_206F_206F_200C_202D_206C_200F_202D_206A_202B_200C_206A_206E_202A_202B_206B_206B_202E(string P_0, char[] P_1)
	{
		return P_0.Split(P_1);
	}

	static object _202E_200B_206A_202A_202D_202E_200F_200B_206C_206B_206D_200C_200B_200E_206D_206D_200B_202B_202A_202D_206F_202A_206F_200D_206F_206F_206A_200B_200F_200E_200C_206D_200C_202E_202A_200B_206A_200F_206F_206B_202E(Queue P_0)
	{
		return P_0.Dequeue();
	}

	static float _206A_206D_206C_202A_206B_200E_200D_202E_202E_202C_202A_202B_206D_202B_200E_206E_202B_202C_202E_206A_206F_202A_206B_202E_206E_206E_200C_206B_202A_200E_206B_206D_200F_200D_200C_202B_200E_200D_206E_202D_202E()
	{
		return Time.time;
	}

	static IEnumerator _206D_206E_206F_200C_206F_200B_206B_206E_200E_200C_206D_200B_202C_200F_202A_206B_202A_202D_200C_206F_206F_206E_202C_206D_206B_206B_202A_206A_206D_200B_202C_202A_200E_200E_206C_202C_206F_206B_206D_202C_202E(ArrayList P_0)
	{
		return P_0.GetEnumerator();
	}

	static object _206C_206B_206F_206D_202B_206E_206E_202E_200B_206D_200C_202B_206C_200C_202D_200B_200B_200B_202D_206A_200F_202D_200B_202A_202E_200E_206B_206B_200F_202A_206F_206F_202A_202B_200C_202B_200F_202C_206B_202C_202E(IEnumerator P_0)
	{
		return P_0.Current;
	}

	static void _200D_200C_200C_200C_200D_200E_202D_202B_200B_206C_200F_206F_206D_206C_202E_206F_200C_206D_200F_202A_206A_206B_200D_206F_206E_206D_206E_202A_202E_206F_202D_206A_206C_200F_200D_200B_200E_200F_206D_200F_202E(GameObject P_0, bool P_1)
	{
		P_0.SetActive(P_1);
	}

	static bool _202C_206F_206E_202B_202B_206E_200F_206C_206E_206D_206D_202E_206F_206C_206F_200E_200D_200D_200C_202B_206D_206D_200C_200D_206A_200F_200B_202D_202D_202D_200F_202B_202E_206B_200E_206A_206E_200B_206B_206F_202E(IEnumerator P_0)
	{
		return P_0.MoveNext();
	}

	static void _200F_206D_200E_202A_206F_206D_202A_200B_206A_206D_200F_206D_206D_206A_200D_200E_200E_200E_206D_202A_200C_206B_206E_200D_200D_200C_202D_202B_200F_200F_202A_200D_200E_202C_206E_200C_200E_200C_206E_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}

	static int _206E_202C_206F_206B_200D_202A_206D_202A_206A_202B_200F_200B_200C_200E_200D_202C_200E_202B_200F_206C_206E_200C_206C_206E_200F_206E_202D_202C_202B_206F_202A_206C_200E_202D_206F_202E_200F_200C_202B_206A_202E(ArrayList P_0)
	{
		return P_0.Count;
	}

	static object _202B_202E_206F_200C_200E_206F_206B_200E_202C_202D_206D_200F_202E_206A_202E_206C_206B_200E_202D_202D_202C_202D_202E_200D_200E_202E_206D_206C_206D_202A_202E_202B_206A_200D_206C_206A_206A_202D_200C_206D_202E(ArrayList P_0, int P_1)
	{
		return P_0[P_1];
	}

	static void _200E_200E_202E_202B_206D_202A_202B_202C_200F_200F_200C_200D_206D_202E_206E_206D_202A_200B_200B_206E_200D_202E_202D_206F_200E_200D_206A_206B_206D_202A_202B_206F_200C_206F_200C_206B_200D_202D_202A_200C_202E(Image P_0, Sprite P_1)
	{
		P_0.sprite = P_1;
	}

	static Transform _200D_200F_206D_202B_200B_206B_206B_202D_202B_206C_206B_206C_202B_206D_202C_206E_200F_202B_200B_206F_200B_202D_206F_200B_200C_206C_206A_202C_202C_202A_202D_200B_206F_200B_200D_200E_206A_202B_206C_202D_202E(GameObject P_0)
	{
		return P_0.transform;
	}

	static int _200D_200E_202A_202B_200F_200C_202E_202A_202C_206A_202D_206D_200E_202C_202B_202A_200E_206F_206E_206C_200B_206B_206F_206D_206E_202A_206B_200C_200E_202D_202C_202D_202B_200C_206A_202C_202A_206E_200F_206D_202E(int P_0, int P_1)
	{
		return Random.Range(P_0, P_1);
	}

	static Vector3 _200B_202D_206B_206D_202D_206B_202B_206F_206D_206B_206A_200F_206C_202C_206F_202D_206A_200F_206D_206D_200E_202E_206C_200B_202B_206F_206B_202C_200E_206E_200F_202C_202B_202B_206B_202B_206C_202B_202B_206A_202E(Transform P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.position;
	}

	static bool _200E_206E_202D_202C_202B_206A_202A_206C_206A_202D_200C_206E_200B_200F_206E_206D_206B_206F_202B_206E_202C_206A_206C_202C_202B_202E_202D_200C_206F_202B_200D_202D_206C_202A_206C_200E_200C_206D_206B_206A_202E(ArrayList P_0, object P_1)
	{
		return P_0.Contains(P_1);
	}

	static void _200C_202D_202E_206D_202D_200C_202A_202C_200D_200B_206C_202D_206E_202D_206B_206E_206A_200D_206F_202C_202A_206C_206C_202A_206A_200B_206D_200E_202C_200F_206F_202E_206C_202C_200D_200E_202C_200B_200D_206A_202E(Transform P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.position = P_1;
	}
}
