using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JyGame;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MusicPanelUI : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _206F_202B_206B_202B_202E_206E_200D_202E_202E_200D_202E_200B_202E_202C_200D_200C_206C_202C_200E_200B_206B_202D_206E_200E_202A_202E_206C_200D_206B_200F_206C_200E_200F_200D_200C_206C_202D_200B_202E_202A_202E
	{
		internal string key;

		internal void _200B_206A_202C_200B_202D_202C_206D_202B_200B_206F_200B_202E_206F_206F_206F_200E_202D_200E_202C_202D_206E_200D_206D_202E_206A_202C_200C_202B_206D_206A_206A_206A_206E_200F_202E_200F_202C_206F_206A_202A_202E()
		{
			AudioManager.Instance.Play(key);
		}
	}

	[CompilerGenerated]
	private sealed class _202C_200F_200D_206E_202B_200D_202A_206D_206F_200C_202E_206D_206E_206B_200F_200C_206E_206B_206E_200C_202B_202D_206C_200F_200F_200F_200E_206F_206C_202A_202B_206A_202E_206B_202A_206D_206C_206D_206D_200F_202E
	{
		public int value;

		public string key;

		internal void _200D_200C_206E_202E_200D_202E_206F_200E_206E_202E_200F_200B_200F_202C_206A_206C_206A_206B_202E_206B_202A_206C_206E_202D_206E_200E_202E_202C_206C_200C_202A_200E_206F_200F_202D_206F_206A_200E_206E_202A_202E()
		{
			if (value == 1)
			{
				while (true)
				{
					uint num;
					switch ((num = 73261426u) % 3)
					{
					case 2u:
						continue;
					case 1u:
						AudioManager.Instance.PlayOne(key);
						return;
					}
					break;
				}
			}
			AudioManager.Instance.Play(key);
		}
	}

	[CompilerGenerated]
	private sealed class _202B_200E_206C_202D_200F_206F_200F_206B_200E_202E_200F_206E_206C_202D_202A_200D_200C_200C_202E_202B_206A_202B_202D_200B_206C_200C_206B_200F_202D_200C_200C_202C_200E_200E_202B_202B_200B_206A_200D_206C_202E : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E;

		private object _200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E;

		public SelectMenu selectMenu;

		public MusicPanelUI _202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E;

		private int _200D_206E_202E_200F_200B_206A_200B_200E_200D_200F_206F_200C_200B_200D_200E_206D_202C_206F_202B_200C_206F_202C_202E_206B_202A_200C_200B_200B_202B_202B_206A_202B_206C_206C_206E_200B_202E_206A_202E_200C_202E;

		private Dictionary<string, int>.Enumerator _206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E;

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
		public _202B_200E_206C_202D_200F_206F_200F_206B_200E_202E_200F_206E_206C_202D_202A_200D_200C_200C_202E_202B_206A_202B_202D_200B_206C_200C_206B_200F_202D_200C_200C_202C_200E_200E_202B_202B_200B_206A_200D_206C_202E(int P_0)
		{
			_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = P_0;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E;
			while (true)
			{
				int num2 = 556777316;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num2 ^ 0x23D12411)) % 4)
					{
					case 0u:
						break;
					case 1u:
					{
						int num4;
						int num5;
						if (num == -3)
						{
							num4 = -1749780740;
							num5 = num4;
						}
						else
						{
							num4 = -1601977811;
							num5 = num4;
						}
						num2 = num4 ^ ((int)num3 * -1945779570);
						continue;
					}
					case 2u:
						if (num == 1)
						{
							num2 = ((int)num3 * -453840548) ^ 0x733DD242;
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
			//IL_06d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e2: Expected O, but got Unknown
			bool result = default(bool);
			try
			{
				int num = _200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E;
				MusicPanelUI musicPanelUI = default(MusicPanelUI);
				Dictionary<string, int> dictionary = default(Dictionary<string, int>);
				List<string> list = default(List<string>);
				List<string> list2 = default(List<string>);
				string key = default(string);
				string current = default(string);
				GameObject val = default(GameObject);
				_202C_200F_200D_206E_202B_200D_202A_206D_206F_200C_202E_206D_206E_206B_200F_200C_206E_206B_206E_200C_202B_202D_206C_200F_200F_200F_200E_206F_206C_202A_202B_206A_202E_206B_202A_206D_206C_206D_206D_200F_202E obj = default(_202C_200F_200D_206E_202B_200D_202A_206D_206F_200C_202E_206D_206E_206B_200F_200C_206E_206B_206E_200C_202B_202D_206C_200F_200F_200F_200E_206F_206C_202A_202B_206A_202E_206B_202A_206D_206C_206D_206D_200F_202E);
				KeyValuePair<string, int> current3 = default(KeyValuePair<string, int>);
				while (true)
				{
					IL_0007:
					int num2 = 1411753878;
					while (true)
					{
						int num21;
						uint num3;
						switch ((num3 = (uint)(num2 ^ 0x79D20E23)) % 8)
						{
						case 0u:
							break;
						case 5u:
							musicPanelUI = _202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E;
							switch (num)
							{
							case 0:
								goto IL_00fa;
							case 1:
								goto IL_0721;
							case 2:
								goto IL_07b6;
							}
							num2 = ((int)num3 * -1605348004) ^ -409485336;
							continue;
						case 7u:
							result = false;
							goto end_IL_000c;
						case 6u:
							selectMenu.Show(musicPanelUI._206C_206E_200E_206E_206B_202B_200C_206C_200D_202A_200E_200C_206B_200E_206D_200D_200B_200E_206C_206B_202A_206D_206D_206E_206F_206C_200E_206C_206E_206F_202C_202E_200E_200B_200E_200B_200D_202B_206C_200F_202E);
							num2 = ((int)num3 * -236630069) ^ 0x6976F902;
							continue;
						case 2u:
							dictionary = new Dictionary<string, int>();
							list = new List<string>();
							list2 = new List<string>();
							num2 = (int)(num3 * 424525439) ^ -331149612;
							continue;
						case 3u:
							if (_202A_206E_206E_202B_202C_200E_206E_206D_202D_200F_202B_206B_200C_202D_206F_202C_200C_206A_200E_200C_202C_202C_202B_206E_206F_202A_206C_202E_200C_202C_206A_200C_202A_200E_200D_206F_202D_202C_200D_206B_202E(selectMenu.selectContent) == 0)
							{
								num2 = ((int)num3 * -2068677293) ^ 0x6E77C5D8;
								continue;
							}
							goto IL_05bd;
						case 4u:
							goto IL_00fa;
						default:
							{
								IEnumerator<Resource> enumerator = ResourceManager.GetAll<Resource>().GetEnumerator();
								try
								{
									while (true)
									{
										IL_02be:
										int num4;
										int num5;
										if (!_206A_202C_202A_202C_206D_202E_206A_200C_206C_206E_206A_202A_206F_200E_200C_202B_206F_206A_202E_202A_200E_206D_206E_202A_202B_200F_202B_206E_206C_200E_206F_206F_200D_200C_202C_206C_206E_202E_200B_202E_202E((IEnumerator)enumerator))
										{
											num4 = 2047470110;
											num5 = num4;
										}
										else
										{
											num4 = 1035333139;
											num5 = num4;
										}
										while (true)
										{
											switch ((num3 = (uint)(num4 ^ 0x79D20E23)) % 15)
											{
											case 2u:
												num4 = 1035333139;
												continue;
											default:
												goto end_IL_0121;
											case 4u:
											{
												int num15;
												if (!_202E_200B_202B_202A_206E_200C_200C_202A_206D_200F_206A_200D_200D_200C_206A_206E_206A_202B_200C_206D_206C_202A_202D_202B_202B_202C_202D_202E_200B_202A_206F_202E_202B_200B_206E_206C_206C_206D_202B_206F_202E(key, ResourceStrings.ResStrings[1102]))
												{
													num4 = 2140768692;
													num15 = num4;
												}
												else
												{
													num4 = 766983867;
													num15 = num4;
												}
												continue;
											}
											case 10u:
											{
												int num13;
												int num14;
												if (!list2.Contains(key))
												{
													num13 = -2025894041;
													num14 = num13;
												}
												else
												{
													num13 = -735583252;
													num14 = num13;
												}
												num4 = num13 ^ ((int)num3 * -1002077463);
												continue;
											}
											case 6u:
											{
												int num9;
												int num10;
												if (_202E_200B_202B_202A_206E_200C_200C_202A_206D_200F_206A_200D_200D_200C_206A_206E_206A_202B_200C_206D_206C_202A_202D_202B_202B_202C_202D_202E_200B_202A_206F_202E_202B_200B_206E_206C_206C_206D_202B_206F_202E(key, ResourceStrings.ResStrings[1100]))
												{
													num9 = 530324212;
													num10 = num9;
												}
												else
												{
													num9 = 1026391470;
													num10 = num9;
												}
												num4 = num9 ^ ((int)num3 * -944692570);
												continue;
											}
											case 3u:
												dictionary.Add(key, -1);
												num4 = ((int)num3 * -1947053262) ^ 0x7B15FC87;
												continue;
											case 9u:
												num4 = (int)(num3 * 675349253) ^ -875022690;
												continue;
											case 13u:
												list.Add(key);
												num4 = ((int)num3 * -700100734) ^ 0xA55AFBD;
												continue;
											case 12u:
												num4 = (int)((num3 * 1687892688) ^ 0x3384AB34);
												continue;
											case 11u:
											{
												int num11;
												int num12;
												if (!dictionary.ContainsKey(key))
												{
													num11 = 2074810638;
													num12 = num11;
												}
												else
												{
													num11 = 1481968482;
													num12 = num11;
												}
												num4 = num11 ^ ((int)num3 * -2045826186);
												continue;
											}
											case 5u:
											{
												int num7;
												int num8;
												if (!list.Contains(key))
												{
													num7 = 31338164;
													num8 = num7;
												}
												else
												{
													num7 = 1392734920;
													num8 = num7;
												}
												num4 = num7 ^ (int)(num3 * 1686358826);
												continue;
											}
											case 8u:
												key = enumerator.Current.Key;
												num4 = 1959601810;
												continue;
											case 7u:
												break;
											case 14u:
												list2.Add(key);
												num4 = (int)((num3 * 777705427) ^ 0x230085A0);
												continue;
											case 0u:
											{
												int num6;
												if (!_202E_200B_202B_202A_206E_200C_200C_202A_206D_200F_206A_200D_200D_200C_206A_206E_206A_202B_200C_206D_206C_202A_202D_202B_202B_202C_202D_202E_200B_202A_206F_202E_202B_200B_206E_206C_206C_206D_202B_206F_202E(key, ResourceStrings.ResStrings[1101]))
												{
													num4 = 1673329715;
													num6 = num4;
												}
												else
												{
													num4 = 295179621;
													num6 = num4;
												}
												continue;
											}
											case 1u:
												goto end_IL_0121;
											}
											goto IL_02be;
											continue;
											end_IL_0121:
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
											IL_0329:
											int num16 = 1914613685;
											while (true)
											{
												switch ((num3 = (uint)(num16 ^ 0x79D20E23)) % 3)
												{
												case 2u:
													break;
												default:
													goto end_IL_032e;
												case 1u:
													goto IL_034c;
												case 0u:
													goto end_IL_032e;
												}
												goto IL_0329;
												IL_034c:
												_200F_200D_206D_200F_200E_206C_200E_206C_206F_206D_200D_206A_202D_202B_202B_200C_200C_206E_206D_206A_206F_202D_206C_200D_206D_200C_206C_202A_202A_206D_206C_206C_202A_200E_206B_206F_206A_202A_200D_206F_202E((IDisposable)enumerator);
												num16 = ((int)num3 * -1474269090) ^ 0x116CFBD;
												continue;
												end_IL_032e:
												break;
											}
											break;
										}
									}
								}
								using (List<string>.Enumerator enumerator2 = list.GetEnumerator())
								{
									while (true)
									{
										IL_039a:
										int num17;
										int num18;
										if (enumerator2.MoveNext())
										{
											num17 = 555989307;
											num18 = num17;
										}
										else
										{
											num17 = 64431936;
											num18 = num17;
										}
										while (true)
										{
											switch ((num3 = (uint)(num17 ^ 0x79D20E23)) % 5)
											{
											case 0u:
												num17 = 555989307;
												continue;
											default:
												goto end_IL_0374;
											case 3u:
												break;
											case 4u:
												dictionary.Add(current, -1);
												num17 = (int)((num3 * 2135145521) ^ 0x6AC93CF2);
												continue;
											case 1u:
												current = enumerator2.Current;
												num17 = 911754726;
												continue;
											case 2u:
												goto end_IL_0374;
											}
											goto IL_039a;
											continue;
											end_IL_0374:
											break;
										}
										break;
									}
								}
								using (List<string>.Enumerator enumerator2 = list2.GetEnumerator())
								{
									while (true)
									{
										IL_0438:
										int num19;
										int num20;
										if (!enumerator2.MoveNext())
										{
											num19 = 1680161172;
											num20 = num19;
										}
										else
										{
											num19 = 908162654;
											num20 = num19;
										}
										while (true)
										{
											switch ((num3 = (uint)(num19 ^ 0x79D20E23)) % 4)
											{
											case 0u:
												num19 = 908162654;
												continue;
											default:
												goto end_IL_03fd;
											case 1u:
											{
												string current2 = enumerator2.Current;
												dictionary.Add(current2, 1);
												num19 = 2037743605;
												continue;
											}
											case 2u:
												break;
											case 3u:
												goto end_IL_03fd;
											}
											goto IL_0438;
											continue;
											end_IL_03fd:
											break;
										}
										break;
									}
								}
								list.Clear();
								list2.Clear();
								goto IL_0470;
							}
							IL_07b6:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
							result = false;
							goto end_IL_000c;
							IL_05bd:
							_200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E = 0;
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 2;
							num21 = 982034759;
							goto IL_0475;
							IL_0470:
							num21 = 610687247;
							goto IL_0475;
							IL_00fa:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
							num2 = 2000874429;
							continue;
							IL_0721:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -3;
							num21 = 823919470;
							goto IL_0475;
							IL_0475:
							while (true)
							{
								switch ((num3 = (uint)(num21 ^ 0x79D20E23)) % 24)
								{
								case 6u:
									break;
								case 15u:
									_202C_200C_202E_206E_206F_206A_200E_200B_206B_202E_206B_200C_206B_202C_200F_200F_200E_202A_206E_202B_200C_202E_206F_206A_202B_206E_206E_200C_202C_206E_202A_206A_202C_206A_200D_200E_202E_206E_200F_200E_202E(((Component)_206B_200E_200C_202D_202E_206D_200E_200D_200D_202E_206F_202A_206B_206C_200D_202D_206E_206A_200D_202E_206C_202E_206B_202B_200E_202A_206B_200B_206F_202D_202D_206C_202E_202E_202D_206B_202C_206C_206E_200F_202E(_202D_206D_206C_200F_202B_202C_202E_206B_200E_206C_200B_200E_206C_202B_202B_206C_200F_206C_206E_206D_200F_206C_206B_206A_200C_200B_206C_202A_200F_200B_206A_202D_206A_206C_202B_206D_202C_206F_200E_202C_202E(val), global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2510808305u))).GetComponent<Text>(), obj.key);
									num21 = ((int)num3 * -1722193007) ^ -702576054;
									continue;
								case 16u:
									num21 = (int)((num3 * 1081751094) ^ 0x49D96FBA);
									continue;
								case 17u:
									_202D_202A_202A_200E_206E_202E_206C_202C_206F_202C_200C_202E_202A_206E_202B_202D_202C_206F_206C_206A_202A_200F_206A_200F_206D_200B_200C_202C_202B_206E_200E_206C_202D_200D_202E_202D_206D_206D_202B_202C_202E();
									_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E = default(Dictionary<string, int>.Enumerator);
									num21 = ((int)num3 * -497176817) ^ -949945077;
									continue;
								case 22u:
									_206F_206D_206D_200C_206E_200D_206A_200D_200F_202C_202B_206B_200B_200E_200C_202B_206F_206F_206E_206C_206F_200E_206F_200E_206F_202E_202A_200C_206D_202A_200D_200F_200E_200D_206F_200E_200F_202E_200F_206E_202E(musicPanelUI.selectMenu, true);
									num21 = ((int)num3 * -53797779) ^ -968523428;
									continue;
								case 1u:
									goto IL_057c;
								case 0u:
									val = Object.Instantiate<GameObject>(musicPanelUI.selectItemPrefab);
									num21 = ((int)num3 * -1149371511) ^ -761074276;
									continue;
								case 23u:
									goto IL_05bd;
								case 2u:
									_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E = dictionary.GetEnumerator();
									_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -3;
									num21 = (int)((num3 * 317505901) ^ 0x4BB02B91);
									continue;
								case 11u:
									goto end_IL_000c;
								case 7u:
								{
									int num22;
									int num23;
									if (_200D_206E_202E_200F_200B_206A_200B_200E_200D_200F_206F_200C_200B_200D_200E_206D_202C_206F_202B_200C_206F_202C_202E_206B_202A_200C_200B_200B_202B_202B_206A_202B_206C_206C_206E_200B_202E_206A_202E_200C_202E < 40)
									{
										num22 = 398971732;
										num23 = num22;
									}
									else
									{
										num22 = 1021237032;
										num23 = num22;
									}
									num21 = num22 ^ ((int)num3 * -1865207630);
									continue;
								}
								case 21u:
									_200D_206E_202E_200F_200B_206A_200B_200E_200D_200F_206F_200C_200B_200D_200E_206D_202C_206F_202B_200C_206F_202C_202E_206B_202A_200C_200B_200B_202B_202B_206A_202B_206C_206C_206E_200B_202E_206A_202E_200C_202E = 0;
									num21 = ((int)num3 * -282610725) ^ 0x4B751307;
									continue;
								case 9u:
									_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 1;
									num21 = (int)(num3 * 1777212462) ^ -296171033;
									continue;
								case 20u:
									_200D_206E_202E_200F_200B_206A_200B_200E_200D_200F_206F_200C_200B_200D_200E_206D_202C_206F_202B_200C_206F_202C_202E_206B_202A_200C_200B_200B_202B_202B_206A_202B_206C_206C_206E_200B_202E_206A_202E_200C_202E = 0;
									num21 = (int)(num3 * 911583085) ^ -893916811;
									continue;
								case 3u:
									_200D_206E_202E_200F_200B_206A_200B_200E_200D_200F_206F_200C_200B_200D_200E_206D_202C_206F_202B_200C_206F_202C_202E_206B_202A_200C_200B_200B_202B_202B_206A_202B_206C_206C_206E_200B_202E_206A_202E_200C_202E++;
									num21 = (int)((num3 * 1955561249) ^ 0x1F1A11A7);
									continue;
								case 4u:
									result = true;
									num21 = ((int)num3 * -1293840302) ^ 0x53EA0668;
									continue;
								case 14u:
									_202C_206C_202A_202E_202C_206D_206C_200B_202D_200D_206E_200C_200B_206C_202C_206E_200D_206D_206B_202B_202A_200E_206A_202E_200E_202E_200D_206F_202C_206E_200D_202E_206C_206E_206E_202D_206E_202B_206E_206A_202E((UnityEvent)(object)_206C_202A_200B_202C_200F_200E_202C_200C_202E_202E_206B_200E_206C_206E_206F_202A_202A_202A_202D_206A_200F_206E_206E_202D_202C_200C_202C_200B_200E_202E_202E_206F_202B_200B_200F_202B_206C_202B_206C_200D_202E(val.GetComponent<Button>()), new UnityAction(obj._200D_200C_206E_202E_200D_202E_206F_200E_206E_202E_200F_200B_200F_202C_206A_206C_206A_206B_202E_206B_202A_206C_206E_202D_206E_200E_202E_202C_206C_200C_202A_200E_206F_200F_202D_206F_206A_200E_206E_202A_202E));
									selectMenu.AddItem(val);
									num21 = (int)((num3 * 1975802916) ^ 0x5F3F4A20);
									continue;
								case 19u:
									_200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E = 0;
									num21 = ((int)num3 * -2040593422) ^ 0x4FE6E3EC;
									continue;
								case 12u:
									goto IL_0721;
								case 18u:
									obj = new _202C_200F_200D_206E_202B_200D_202A_206D_206F_200C_202E_206D_206E_206B_200F_200C_206E_206B_206E_200C_202B_202D_206C_200F_200F_200F_200E_206F_206C_202A_202B_206A_202E_206B_202A_206D_206C_206D_206D_200F_202E
									{
										key = current3.Key,
										value = current3.Value
									};
									num21 = (int)((num3 * 1722331492) ^ 0x47DB9B3);
									continue;
								case 8u:
									current3 = _206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E.Current;
									num21 = 1532144553;
									continue;
								case 10u:
									result = true;
									goto end_IL_000c;
								case 5u:
									_206F_206D_206D_200C_206E_200D_206A_200D_200F_202C_202B_206B_200B_200E_200C_202B_206F_206F_206E_206C_206F_200E_206F_200E_206F_202E_202A_200C_206D_202A_200D_200F_200E_200D_206F_200E_200F_202E_200F_206E_202E(musicPanelUI.selectMenu, false);
									num21 = ((int)num3 * -1897062728) ^ 0x3AABA4A5;
									continue;
								default:
									goto IL_07b6;
								}
								break;
								IL_057c:
								int num24;
								if (!_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E.MoveNext())
								{
									num21 = 1981208882;
									num24 = num21;
								}
								else
								{
									num21 = 822934483;
									num24 = num21;
								}
							}
							goto IL_0470;
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
			while (true)
			{
				int num = 1584456801;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x13D983A2)) % 3)
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
					num = (int)(num2 * 728680356) ^ -1208295890;
				}
			}
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw _202B_200D_206D_200D_202A_202B_200B_206B_202C_200D_202B_202D_206A_206F_206A_206C_200C_202B_206F_206F_206D_202B_202A_206E_202D_206F_206F_202A_206E_202A_200B_206C_200E_202A_206E_206F_202B_206E_206C_206B_202E();
		}

		static int _202A_206E_206E_202B_202C_200E_206E_206D_202D_200F_202B_206B_200C_202D_206F_202C_200C_206A_200E_200C_202C_202C_202B_206E_206F_202A_206C_202E_200C_202C_206A_200C_202A_200E_200D_206F_202D_202C_200D_206B_202E(Transform P_0)
		{
			return P_0.childCount;
		}

		static bool _202E_200B_202B_202A_206E_200C_200C_202A_206D_200F_206A_200D_200D_200C_206A_206E_206A_202B_200C_206D_206C_202A_202D_202B_202B_202C_202D_202E_200B_202A_206F_202E_202B_200B_206E_206C_206C_206D_202B_206F_202E(string P_0, string P_1)
		{
			return P_0.StartsWith(P_1);
		}

		static bool _206A_202C_202A_202C_206D_202E_206A_200C_206C_206E_206A_202A_206F_200E_200C_202B_206F_206A_202E_202A_200E_206D_206E_202A_202B_200F_202B_206E_206C_200E_206F_206F_200D_200C_202C_206C_206E_202E_200B_202E_202E(IEnumerator P_0)
		{
			return P_0.MoveNext();
		}

		static void _200F_200D_206D_200F_200E_206C_200E_206C_206F_206D_200D_206A_202D_202B_202B_200C_200C_206E_206D_206A_206F_202D_206C_200D_206D_200C_206C_202A_202A_206D_206C_206C_202A_200E_206B_206F_206A_202A_200D_206F_202E(IDisposable P_0)
		{
			P_0.Dispose();
		}

		static Transform _202D_206D_206C_200F_202B_202C_202E_206B_200E_206C_200B_200E_206C_202B_202B_206C_200F_206C_206E_206D_200F_206C_206B_206A_200C_200B_206C_202A_200F_200B_206A_202D_206A_206C_202B_206D_202C_206F_200E_202C_202E(GameObject P_0)
		{
			return P_0.transform;
		}

		static Transform _206B_200E_200C_202D_202E_206D_200E_200D_200D_202E_206F_202A_206B_206C_200D_202D_206E_206A_200D_202E_206C_202E_206B_202B_200E_202A_206B_200B_206F_202D_202D_206C_202E_202E_202D_206B_202C_206C_206E_200F_202E(Transform P_0, string P_1)
		{
			return P_0.FindChild(P_1);
		}

		static void _202C_200C_202E_206E_206F_206A_200E_200B_206B_202E_206B_200C_206B_202C_200F_200F_200E_202A_206E_202B_200C_202E_206F_206A_202B_206E_206E_200C_202C_206E_202A_206A_202C_206A_200D_200E_202E_206E_200F_200E_202E(Text P_0, string P_1)
		{
			P_0.text = P_1;
		}

		static ButtonClickedEvent _206C_202A_200B_202C_200F_200E_202C_200C_202E_202E_206B_200E_206C_206E_206F_202A_202A_202A_202D_206A_200F_206E_206E_202D_202C_200C_202C_200B_200E_202E_202E_206F_202B_200B_200F_202B_206C_202B_206C_200D_202E(Button P_0)
		{
			return P_0.onClick;
		}

		static void _202C_206C_202A_202E_202C_206D_206C_200B_202D_200D_206E_200C_200B_206C_202C_206E_200D_206D_206B_202B_202A_200E_206A_202E_200E_202E_200D_206F_202C_206E_200D_202E_206C_206E_206E_202D_206E_202B_206E_206A_202E(UnityEvent P_0, UnityAction P_1)
		{
			P_0.AddListener(P_1);
		}

		static void _206F_206D_206D_200C_206E_200D_206A_200D_200F_202C_202B_206B_200B_200E_200C_202B_206F_206F_206E_206C_206F_200E_206F_200E_206F_202E_202A_200C_206D_202A_200D_200F_200E_200D_206F_200E_200F_202E_200F_206E_202E(GameObject P_0, bool P_1)
		{
			P_0.SetActive(P_1);
		}

		static NotSupportedException _202B_200D_206D_200D_202A_202B_200B_206B_202C_200D_202B_202D_206A_206F_206A_206C_200C_202B_206F_206F_206D_202B_202A_206E_202D_206F_206F_202A_206E_202A_200B_206C_200E_202A_206E_206F_202B_206E_206C_206B_202E()
		{
			return new NotSupportedException();
		}
	}

	public GameObject selectMenu;

	public GameObject selectItemPrefab;

	private bool _200D_200E_206D_202C_200C_200D_202E_206F_202C_200F_206A_202A_202D_206D_202E_202C_206C_200D_202C_202A_206C_202B_200C_202B_202B_206C_202A_202C_200F_202C_202C_206D_200B_206C_202E_200E_200F_200F_202B_202E_202E;

	public void Show()
	{
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		_200C_206C_202E_200F_206E_202A_202A_202B_206B_206F_202D_202D_206B_206A_200F_206E_202C_202A_200F_206C_202A_200D_202D_200E_206E_200E_206A_202A_200F_200E_202B_202B_206D_200E_206C_200D_206D_206A_206D_202C_202E(_200E_206A_202A_202D_200C_202B_202D_200E_200D_200D_206F_206E_202C_202B_200E_200F_200F_206E_200B_202C_206E_206D_202D_202A_202E_202E_206E_202D_200F_200D_206F_202E_206F_202C_206D_202E_206B_200D_202B_202D_202E((Component)(object)this), true);
		Text component = default(Text);
		while (true)
		{
			int num = 1125994481;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3EE1F0D8)) % 10)
				{
				case 8u:
					break;
				default:
					return;
				case 7u:
				{
					component.text = ResourceStrings.ResStrings[1081];
					int num5;
					int num6;
					if (CommonSettings.USE_SYSTEM_FONT)
					{
						num5 = -1507234520;
						num6 = num5;
					}
					else
					{
						num5 = -1533628151;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1900808362);
					continue;
				}
				case 6u:
					component.font = ModEditorResourceManager.GetFont(CommonSettings.SYSTEM_FONT_NAME);
					num = ((int)num2 * -991035400) ^ 0x1FEFB26E;
					continue;
				case 0u:
					((Component)selectItemPrefab.transform.FindChild(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2905757779u))).GetComponent<Text>().font = ModEditorResourceManager.GetFont(CommonSettings.SYSTEM_FONT_NAME);
					num = ((int)num2 * -1971647066) ^ -1598492829;
					continue;
				case 9u:
				{
					int num3;
					int num4;
					if (!_200D_200E_206D_202C_200C_200D_202E_206F_202C_200F_206A_202A_202D_206D_202E_202C_206C_200D_202C_202A_206C_202B_200C_202B_202B_206C_202A_202C_200F_202C_202C_206D_200B_206C_202E_200E_200F_200F_202B_202E_202E)
					{
						num3 = -1333218512;
						num4 = num3;
					}
					else
					{
						num3 = -1752064576;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1939866774);
					continue;
				}
				case 3u:
					component = ((Component)_206A_200F_200F_200C_206A_202D_206C_200E_202E_202C_206C_206B_206C_206C_206D_202B_206F_202B_202E_206C_206C_200D_200E_206A_206E_202C_206D_200F_200B_200F_202C_206C_200C_202C_200D_206E_202D_206F_202D_200F_202E(_202A_206C_202E_202D_206D_206F_206B_206A_206F_202E_200F_206A_206E_202D_202E_206F_206E_200E_202D_200C_206A_206B_200D_200D_206D_200E_200B_200C_202C_202B_200B_200B_200D_200E_202B_202D_206C_202C_206B_206D_202E((Component)(object)this), global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(146980761u))).GetComponent<Text>();
					_206E_206E_206E_202A_202C_202B_202B_206F_200E_202C_202B_202B_200C_200B_206A_206C_206E_206B_200F_200C_206F_200C_206C_202D_206E_202D_206E_206E_206C_202D_206D_200D_200C_200E_200D_200B_202B_206F_206C_206F_202E((Component)(object)component).localPosition = new Vector3(-5f, 241f, 0f);
					num = (int)((num2 * 1372283490) ^ 0x69249C8F);
					continue;
				case 2u:
					_200D_200E_206D_202C_200C_200D_202E_206F_202C_200F_206A_202A_202D_206D_202E_202C_206C_200D_202C_202A_206C_202B_200C_202B_202B_206C_202A_202C_200F_202C_202C_206D_200B_206C_202E_200E_200F_200F_202B_202E_202E = true;
					num = (int)(num2 * 1408774994) ^ -286477915;
					continue;
				case 5u:
					((Graphic)component).color = Color.yellow;
					((Component)component).gameObject.AddComponent<Outline>();
					((Component)component).gameObject.SetActive(false);
					((Component)component).gameObject.SetActive(true);
					num = 1042627526;
					continue;
				case 4u:
					((MonoBehaviour)this).StartCoroutine(ShowCoroutine(selectMenu.GetComponent<SelectMenu>()));
					num = 358509881;
					continue;
				case 1u:
					return;
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

	[CompilerGenerated]
	private void _200B_202A_200B_200D_202D_206D_200D_200B_200E_200B_202E_206A_206E_200D_206B_202A_202A_202E_206B_200C_200C_202C_200D_202B_200D_202B_200F_200D_206A_202E_202A_206E_202E_200D_202E_202E_202D_200F_200D_202C_202E()
	{
		_200C_206C_202E_200F_206E_202A_202A_202B_206B_206F_202D_202D_206B_206A_200F_206E_202C_202A_200F_206C_202A_200D_202D_200E_206E_200E_206A_202A_200F_200E_202B_202B_206D_200E_206C_200D_206D_206A_206D_202C_202E(_200E_206A_202A_202D_200C_202B_202D_200E_200D_200D_206F_206E_202C_202B_200E_200F_200F_206E_200B_202C_206E_206D_202D_202A_202E_202E_206E_202D_200F_200D_206F_202E_206F_202C_206D_202E_206B_200D_202B_202D_202E((Component)(object)this), false);
	}

	private IEnumerator ShowCoroutine(SelectMenu selectMenu)
	{
		//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
		return new _202B_200E_206C_202D_200F_206F_200F_206B_200E_202E_200F_206E_206C_202D_202A_200D_200C_200C_202E_202B_206A_202B_202D_200B_206C_200C_206B_200F_202D_200C_200C_202C_200E_200E_202B_202B_200B_206A_200D_206C_202E(0)
		{
			_202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E = this,
			selectMenu = selectMenu
		};
	}

	[CompilerGenerated]
	private void _206C_206E_200E_206E_206B_202B_200C_206C_200D_202A_200E_200C_206B_200E_206D_200D_200B_200E_206C_206B_202A_206D_206D_206E_206F_206C_200E_206C_206E_206F_202C_202E_200E_200B_200E_200B_200D_202B_206C_200F_202E()
	{
		_200C_206C_202E_200F_206E_202A_202A_202B_206B_206F_202D_202D_206B_206A_200F_206E_202C_202A_200F_206C_202A_200D_202D_200E_206E_200E_206A_202A_200F_200E_202B_202B_206D_200E_206C_200D_206D_206A_206D_202C_202E(_200E_206A_202A_202D_200C_202B_202D_200E_200D_200D_206F_206E_202C_202B_200E_200F_200F_206E_200B_202C_206E_206D_202D_202A_202E_202E_206E_202D_200F_200D_206F_202E_206F_202C_206D_202E_206B_200D_202B_202D_202E((Component)(object)this), false);
	}

	static GameObject _200E_206A_202A_202D_200C_202B_202D_200E_200D_200D_206F_206E_202C_202B_200E_200F_200F_206E_200B_202C_206E_206D_202D_202A_202E_202E_206E_202D_200F_200D_206F_202E_206F_202C_206D_202E_206B_200D_202B_202D_202E(Component P_0)
	{
		return P_0.gameObject;
	}

	static void _200C_206C_202E_200F_206E_202A_202A_202B_206B_206F_202D_202D_206B_206A_200F_206E_202C_202A_200F_206C_202A_200D_202D_200E_206E_200E_206A_202A_200F_200E_202B_202B_206D_200E_206C_200D_206D_206A_206D_202C_202E(GameObject P_0, bool P_1)
	{
		P_0.SetActive(P_1);
	}

	static Transform _202A_206C_202E_202D_206D_206F_206B_206A_206F_202E_200F_206A_206E_202D_202E_206F_206E_200E_202D_200C_206A_206B_200D_200D_206D_200E_200B_200C_202C_202B_200B_200B_200D_200E_202B_202D_206C_202C_206B_206D_202E(Component P_0)
	{
		return P_0.transform;
	}

	static Transform _206A_200F_200F_200C_206A_202D_206C_200E_202E_202C_206C_206B_206C_206C_206D_202B_206F_202B_202E_206C_206C_200D_200E_206A_206E_202C_206D_200F_200B_200F_202C_206C_200C_202C_200D_206E_202D_206F_202D_200F_202E(Transform P_0, string P_1)
	{
		return P_0.FindChild(P_1);
	}

	static Transform _206E_206E_206E_202A_202C_202B_202B_206F_200E_202C_202B_202B_200C_200B_206A_206C_206E_206B_200F_200C_206F_200C_206C_202D_206E_202D_206E_206E_206C_202D_206D_200D_200C_200E_200D_200B_202B_206F_206C_206F_202E(Component P_0)
	{
		return P_0.transform;
	}
}
