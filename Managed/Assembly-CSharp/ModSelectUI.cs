using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml;
using JyGame;
using UnityEngine;
using UnityEngine.UI;

public class ModSelectUI : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _206F_200C_202A_200E_202A_202C_202C_200D_206D_200D_206A_206D_202C_202B_206F_206F_202C_202B_200C_202A_202D_202C_200E_206F_200E_206F_202D_202A_202B_206E_206E_202D_206A_202E_206A_206A_202A_200B_202E_202B_202E : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E;

		private object _200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E;

		public ModSelectUI _202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E;

		public ModInfo mod;

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
		public _206F_200C_202A_200E_202A_202C_202C_200D_206D_200D_206A_206D_202C_202B_206F_206F_202C_202B_200C_202A_202D_202C_200E_206F_200E_206F_202D_202A_202B_206E_206E_202D_206A_202E_206A_206A_202A_200B_202E_202B_202E(int P_0)
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
			ModSelectUI modSelectUI = default(ModSelectUI);
			string[] array = default(string[]);
			string config = default(string);
			while (true)
			{
				int num2 = -94094293;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num2 ^ -1843945392)) % 23)
					{
					case 5u:
						break;
					case 18u:
						modSelectUI = _202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E;
						switch (num)
						{
						case 1:
							goto IL_00dd;
						case 0:
							goto IL_0229;
						case 2:
							goto IL_028c;
						}
						num2 = (int)((num3 * 998085378) ^ 0x556AF0DF);
						continue;
					case 19u:
					{
						int randomInt = Tools.GetRandomInt(0, array.Length - 1);
						RuntimeData.Instance.MAINMENU_STORY = _200B_206E_206B_200B_206C_200C_202E_206B_202E_206F_202A_206E_200D_200B_206A_206C_206E_202D_202D_206D_206C_206F_202E_202B_206B_200D_200D_206B_206B_206D_202B_200F_202D_206D_202C_206A_206E_202D_200C_206D_202E(array[randomInt]);
						num2 = ((int)num3 * -238970758) ^ 0x2880B0C1;
						continue;
					}
					case 20u:
						goto IL_00dd;
					case 1u:
					{
						int num12;
						int num13;
						if (!_206E_202B_202E_206A_202E_206A_200D_206F_202D_202B_206A_202E_200D_202D_206E_202C_202E_206D_206C_202E_206B_202E_200F_200E_202C_206C_202C_206F_206C_202C_206A_202D_206E_202B_206B_206A_206D_206E_200F_202C_202E(_200B_202A_206A_202E_206D_200C_202C_202E_200E_202D_202E_202A_202B_202B_206A_206B_200C_202B_206F_206F_206A_202A_202E_200B_206C_202E_200B_206E_206C_206A_200B_206B_206A_206F_202C_200E_202A_200D_202A_206F_202E(mod.LocalDirPath, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3520750327u))))
						{
							num12 = 132415203;
							num13 = num12;
						}
						else
						{
							num12 = 973807417;
							num13 = num12;
						}
						num2 = num12 ^ ((int)num3 * -297601998);
						continue;
					}
					case 10u:
					{
						int num10;
						int num11;
						if (_206C_206B_200C_200F_200E_200E_206A_200F_200B_200D_206E_200D_200D_206B_200B_206C_206E_200B_200E_200F_202E_200F_202D_202B_206D_200B_200D_206C_202C_202A_206A_200E_206F_200C_206B_200C_202E_202C_202D_200F_202E(RuntimeData.Instance.hash1, _206B_200F_206B_200B_200D_200B_200C_206A_202C_206F_200C_202B_202B_202C_206C_202C_200D_202D_200E_200F_202C_200E_202A_200C_206E_206F_200C_202B_202D_200D_200E_200C_200B_202B_206A_202D_200C_206E_200D_202B_202E(modSelectUI.downloadingText)))
						{
							num10 = 693650297;
							num11 = num10;
						}
						else
						{
							num10 = 271687348;
							num11 = num10;
						}
						num2 = num10 ^ (int)(num3 * 596080834);
						continue;
					}
					case 4u:
						return true;
					case 11u:
					{
						int num6;
						int num7;
						if (mod != null)
						{
							num6 = -871603632;
							num7 = num6;
						}
						else
						{
							num6 = -1234537142;
							num7 = num6;
						}
						num2 = num6 ^ ((int)num3 * -1478908883);
						continue;
					}
					case 6u:
					{
						int num14;
						int num15;
						if (RuntimeData.Instance.GetAsc2(RuntimeData.Instance.hash1) != 1558)
						{
							num14 = -927430680;
							num15 = num14;
						}
						else
						{
							num14 = -690749790;
							num15 = num14;
						}
						num2 = num14 ^ (int)(num3 * 1260597438);
						continue;
					}
					case 0u:
						_200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E = 0;
						_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 2;
						return true;
					case 7u:
						_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 1;
						num2 = (int)(num3 * 408527575) ^ -1723585019;
						continue;
					case 2u:
						LoadingUI.Load(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(952303036u));
						num2 = -426286502;
						continue;
					case 9u:
						goto IL_0229;
					case 15u:
						_200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E = 0;
						num2 = (int)((num3 * 536875098) ^ 0x7F58CB53);
						continue;
					case 16u:
						return false;
					case 12u:
						ModManager.SetCurrentMod2(mod);
						num2 = (int)(num3 * 2036766711) ^ -395895789;
						continue;
					case 14u:
						goto IL_028c;
					case 21u:
					{
						int num8;
						int num9;
						if (modSelectUI._202C_202D_202C_206C_206F_206A_206A_200F_206F_202C_206F_206B_206F_202D_200C_206A_200C_200C_200E_202B_206D_202B_202B_206A_200D_200F_200F_206A_200C_206F_206D_200B_206C_206F_202B_202A_200E_206A_202A_206E_202E)
						{
							num8 = -603025840;
							num9 = num8;
						}
						else
						{
							num8 = -469535444;
							num9 = num8;
						}
						num2 = num8 ^ ((int)num3 * -819935099);
						continue;
					}
					case 22u:
						modSelectUI._202C_202D_202C_206C_206F_206A_206A_200F_206F_202C_206F_206B_206F_202D_200C_206A_200C_200C_200E_202B_206D_202B_202B_206A_200D_200F_200F_206A_200C_206F_206D_200B_206C_206F_202B_202A_200E_206A_202A_206E_202E = true;
						_200F_206D_206D_206D_206A_206B_202C_200B_206E_206F_200D_200D_202C_200B_200B_206F_202E_206F_200C_202A_200C_206C_206B_200E_206A_202B_206C_206C_202C_206C_202C_206A_200F_206F_202A_202D_202C_202A_206F_206E_202E((MonoBehaviour)(object)modSelectUI);
						num2 = (int)((num3 * 1585182413) ^ 0x5AEB2EF9);
						continue;
					case 3u:
						array = _200D_202C_206A_200C_206B_200E_202D_202E_206E_200B_206A_206A_206A_202A_206E_206D_206F_206D_202B_206F_206B_200C_200D_206E_200B_206D_200B_202A_202D_202E_200D_202C_200F_206B_206F_202A_202B_200B_206D_202A_202E(config, new char[1] { ',' });
						num2 = (int)(num3 * 963008032) ^ -545285799;
						continue;
					case 13u:
						ModManager.SetCurrentMod(mod);
						num2 = (int)(num3 * 1685774762) ^ -483273899;
						continue;
					case 17u:
					{
						config = LuaManager.GetConfig(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3961739264u));
						int num4;
						int num5;
						if (!_206E_202C_202C_202C_206C_206C_206E_206C_200E_202C_206E_206F_200F_206C_200F_200C_206E_200C_200B_200F_206F_200C_206D_200D_206A_202D_206A_202B_202B_200F_200E_206A_206B_200E_202D_206F_206D_202E_206A_206C_202E(config))
						{
							num4 = 1436075684;
							num5 = num4;
						}
						else
						{
							num4 = 1688944071;
							num5 = num4;
						}
						num2 = num4 ^ ((int)num3 * -145655476);
						continue;
					}
					default:
						{
							return false;
						}
						IL_0229:
						_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
						num2 = -957022382;
						continue;
						IL_00dd:
						_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
						num2 = -658563110;
						continue;
						IL_028c:
						_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
						num2 = -550247748;
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
			throw _206D_202E_200F_202C_202D_200E_200E_202D_202D_206C_200C_202D_200B_200F_206E_206F_200D_200F_200F_202C_200D_206F_206A_206C_200D_202D_206F_200E_202D_202D_202E_202D_206F_206F_200C_206C_202C_206D_202E_202C_202E();
		}

		static void _200F_206D_206D_206D_206A_206B_202C_200B_206E_206F_200D_200D_202C_200B_200B_206F_202E_206F_200C_202A_200C_206C_206B_200E_206A_202B_206C_206C_202C_206C_202C_206A_200F_206F_202A_202D_202C_202A_206F_206E_202E(MonoBehaviour P_0)
		{
			P_0.CancelInvoke();
		}

		static string _206B_200F_206B_200B_200D_200B_200C_206A_202C_206F_200C_202B_202B_202C_206C_202C_200D_202D_200E_200F_202C_200E_202A_200C_206E_206F_200C_202B_202D_200D_200E_200C_200B_202B_206A_202D_200C_206E_200D_202B_202E(Text P_0)
		{
			return P_0.text;
		}

		static bool _206C_206B_200C_200F_200E_200E_206A_200F_200B_200D_206E_200D_200D_206B_200B_206C_206E_200B_200E_200F_202E_200F_202D_202B_206D_200B_200D_206C_202C_202A_206A_200E_206F_200C_206B_200C_202E_202C_202D_200F_202E(string P_0, string P_1)
		{
			return P_0 == P_1;
		}

		static string _200B_202A_206A_202E_206D_200C_202C_202E_200E_202D_202E_202A_202B_202B_206A_206B_200C_202B_206F_206F_206A_202A_202E_200B_206C_202E_200B_206E_206C_206A_200B_206B_206A_206F_202C_200E_202A_200D_202A_206F_202E(string P_0, string P_1)
		{
			return P_0 + P_1;
		}

		static bool _206E_202B_202E_206A_202E_206A_200D_206F_202D_202B_206A_202E_200D_202D_206E_202C_202E_206D_206C_202E_206B_202E_200F_200E_202C_206C_202C_206F_206C_202C_206A_202D_206E_202B_206B_206A_206D_206E_200F_202C_202E(string P_0)
		{
			return File.Exists(P_0);
		}

		static bool _206E_202C_202C_202C_206C_206C_206E_206C_200E_202C_206E_206F_200F_206C_200F_200C_206E_200C_200B_200F_206F_200C_206D_200D_206A_202D_206A_202B_202B_200F_200E_206A_206B_200E_202D_206F_206D_202E_206A_206C_202E(string P_0)
		{
			return string.IsNullOrEmpty(P_0);
		}

		static string[] _200D_202C_206A_200C_206B_200E_202D_202E_206E_200B_206A_206A_206A_202A_206E_206D_206F_206D_202B_206F_206B_200C_200D_206E_200B_206D_200B_202A_202D_202E_200D_202C_200F_206B_206F_202A_202B_200B_206D_202A_202E(string P_0, char[] P_1)
		{
			return P_0.Split(P_1);
		}

		static string _200B_206E_206B_200B_206C_200C_202E_206B_202E_206F_202A_206E_200D_200B_206A_206C_206E_202D_202D_206D_206C_206F_202E_202B_206B_200D_200D_206B_206B_206D_202B_200F_202D_206D_202C_206A_206E_202D_200C_206D_202E(string P_0)
		{
			return P_0.Trim();
		}

		static NotSupportedException _206D_202E_200F_202C_202D_200E_200E_202D_202D_206C_200C_202D_200B_200F_206E_206F_200D_200F_200F_202C_200D_206F_206A_206C_200D_202D_206F_200E_202D_202D_202E_202D_206F_206F_200C_206C_202C_206D_202E_202C_202E()
		{
			return new NotSupportedException();
		}
	}

	public SelectMenu selectMenu;

	public ModItemUI modItem;

	public Text downloadingText;

	public GameObject gonggaoPanel;

	public Text gonggaoText;

	public Text versionText;

	public Button closeBtn;

	private bool isLocal;

	private ModInfo _202E_206D_202C_202A_200C_206C_200D_200F_200B_202B_206C_202A_200E_206F_200C_200C_202C_200E_202D_206D_206D_206A_206D_200D_202A_206B_200D_206D_206C_202D_202E_202C_200F_200E_206D_206B_200B_206E_202D_200F_202E;

	private bool _202C_202D_202C_206C_206F_206A_206A_200F_206F_202C_206F_206B_206F_202D_200C_206A_200C_200C_200E_202B_206D_202B_202B_206A_200D_200F_200F_206A_200C_206F_206D_200B_206C_206F_202B_202A_200E_206A_202A_206E_202E;

	private void Start()
	{
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		Refresh();
		string text2 = default(string);
		string text3 = default(string);
		string text = default(string);
		FileInfo[] array = default(FileInfo[]);
		int num5 = default(int);
		GameObject val = default(GameObject);
		while (true)
		{
			int num = 1776224917;
			while (true)
			{
				int num7;
				int num8;
				StreamReader streamReader2;
				uint num2;
				switch ((num2 = (uint)(num ^ 0x43D670B6)) % 13)
				{
				case 11u:
					break;
				case 3u:
					_200C_202E_206C_202C_200F_202C_202C_200D_202B_200D_202D_200E_202B_200E_202C_206A_202A_206D_206C_206B_200B_206A_206F_202A_202D_202E_200B_206B_202A_202C_202C_202B_206B_202D_200E_200C_206D_202D_206C_206F_202E(60);
					num = ((int)num2 * -1727274315) ^ -1645345983;
					continue;
				case 2u:
					if (_200C_206C_206D_200E_206A_206B_206F_206D_202C_206D_206A_200C_202D_206A_202B_202B_202B_206C_206C_206B_206D_200C_200C_206C_206F_206A_206C_206D_206F_200E_202D_202B_206F_206E_202D_206B_200D_206D_202C_200D_202E(_206D_202A_202D_202B_206B_206A_206E_202E_206E_206E_202C_202B_206B_206C_206B_206E_202A_206A_202B_200E_200C_202C_206B_200D_202E_206E_200B_206B_200E_200E_202E_202A_206A_206C_202D_202E_202A_200E_200E_206D_202E(text2, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3193177598u))))
					{
						num = 1958865606;
						continue;
					}
					goto IL_050e;
				case 6u:
					OnGonggao();
					num = (int)(num2 * 1928019496) ^ -1533745701;
					continue;
				case 9u:
					ModEditorResourceManager.uiCache.Add(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2029011131u), ModEditorResourceManager.LoadSpriteWithCompress(_206D_202A_202D_202B_206B_206A_206E_202E_206E_206E_202C_202B_206B_206C_206B_206E_202A_206A_202B_200E_200C_202C_206B_200D_202E_206E_200B_206B_200E_200E_202E_202A_206A_206C_202D_202E_202A_200E_200E_206D_202E(CommonSettings.persistentDataPath, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(835651584u))));
					num = ((int)num2 * -865615137) ^ -1626213134;
					continue;
				case 1u:
					_202E_202B_200C_200B_200D_206C_206C_200C_202A_202A_202A_206B_202D_200C_200E_200F_200D_206B_202E_202D_202E_200D_202C_202C_200D_202E_200F_206B_202E_206C_200D_206C_200F_202D_200F_200F_202B_200E_206E_206A_202E((MonoBehaviour)(object)this, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2785017618u), 0f);
					num = (int)((num2 * 228333031) ^ 0x678404E1);
					continue;
				case 4u:
					_202B_206D_206E_202E_206A_206A_200C_202C_206B_200D_206F_202C_202E_202B_202E_206D_202A_202B_202E_202C_200D_206C_202B_200D_206F_200D_202A_200C_202C_206B_202D_206A_206E_206A_202E_202E_202E_200F_200E_200F_202E(text3);
					num = ((int)num2 * -488056513) ^ -1006590321;
					continue;
				case 0u:
					_206D_200B_202D_200B_206C_202D_206A_206C_202B_200D_200F_202D_202E_202C_206B_206A_206A_206D_200B_206E_202B_200E_206A_200F_202A_200D_206C_206B_202C_206E_200D_202A_200D_200C_202E_200B_200C_202A_200C_202D_202E(_200C_202B_202C_202B_202D_202E_202E_206D_206D_200D_202B_200B_206C_206D_200C_202B_202E_202D_206E_200C_200B_206F_206A_202C_206C_202C_200C_200D_200F_202D_206F_200B_200C_202E_200F_200D_200C_206A_200D_200D_202E((Component)(object)closeBtn), AssetBundleManager.IsInited);
					_202E_206D_202C_202A_200C_206C_200D_200F_200B_202B_206C_202A_200E_206F_200C_200C_202C_200E_202D_206D_206D_206A_206D_200D_202A_206B_200D_206D_206C_202D_202E_202C_200F_200E_206D_206B_200B_206E_202D_200F_202E = null;
					num = ((int)num2 * -1951456470) ^ 0x19233EE0;
					continue;
				case 8u:
				{
					int num15;
					if (!ModEditorResourceManager.uiCache.ContainsKey(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3648649124u)))
					{
						num = 995040672;
						num15 = num;
					}
					else
					{
						num = 487532451;
						num15 = num;
					}
					continue;
				}
				case 5u:
					if (!AssetBundleManager.IsInited)
					{
						num = ((int)num2 * -685889465) ^ 0xEDA374D;
						continue;
					}
					goto IL_050e;
				case 12u:
				{
					int num9;
					int num10;
					if (_200F_206D_200D_206C_200C_206B_206F_200C_200E_200D_200B_206D_206D_200F_206F_206B_200C_202B_202D_206E_200D_202B_200E_206C_206E_200D_206B_206E_202B_200B_202E_200C_206C_200C_202C_202C_206B_206F_200B_206A_202E() != -1)
					{
						num9 = 2028560606;
						num10 = num9;
					}
					else
					{
						num9 = 1823297845;
						num10 = num9;
					}
					num = num9 ^ (int)(num2 * 998893312);
					continue;
				}
				case 7u:
				{
					string persistentDataPath = CommonSettings.persistentDataPath;
					text2 = _206D_202A_202D_202B_206B_206A_206E_202E_206E_206E_202C_202B_206B_206C_206B_206E_202A_206A_202B_200E_200C_202C_206B_200D_202E_206E_200B_206B_200E_200E_202E_202A_206A_206C_202D_202E_202A_200E_200E_206D_202E(persistentDataPath, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(458296654u));
					if (!_200C_202B_206A_200E_202A_206E_202D_200F_200F_202B_200C_206D_206D_206E_206F_206D_206A_200D_206D_202C_206D_206B_206D_202C_206D_202D_200C_206A_206D_206D_206D_206C_202B_202A_202A_202B_202D_200C_206B_200D_202E(text2))
					{
						_202B_206D_206E_202E_206A_206A_200C_202C_206B_200D_206F_202C_202E_202B_202E_206D_202A_202B_202E_202C_200D_206C_202B_200D_206F_200D_202A_200C_202C_206B_202D_206A_206E_206A_202E_202E_202E_200F_200E_200F_202E(text2);
					}
					text3 = _206D_202A_202D_202B_206B_206A_206E_202E_206E_206E_202C_202B_206B_206C_206B_206E_202A_206A_202B_200E_200C_202C_206B_200D_202E_206E_200B_206B_200E_200E_202E_202A_206A_206C_202D_202E_202A_200E_200E_206D_202E(persistentDataPath, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4273841377u));
					int num6;
					if (_200C_202B_206A_200E_202A_206E_202D_200F_200F_202B_200C_206D_206D_206E_206F_206D_206A_200D_206D_202C_206D_206B_206D_202C_206D_202D_200C_206A_206D_206D_206D_206C_202B_202A_202A_202B_202D_200C_206B_200D_202E(text3))
					{
						num = 1952323085;
						num6 = num;
					}
					else
					{
						num = 1959636040;
						num6 = num;
					}
					continue;
				}
				default:
					{
						text = null;
						StreamReader streamReader = _206A_200D_200B_200C_202B_206C_202A_206D_206A_202B_200C_206E_206C_202A_202D_202E_200E_206E_200F_200B_206B_206C_206F_202A_202C_200E_200B_206D_200F_200F_202A_206C_202A_202B_202E_206A_200D_202B_200C_202D_202E(_206D_202A_202D_202B_206B_206A_206E_202E_206E_206E_202C_202B_206B_206C_206B_206E_202A_206A_202B_200E_200C_202C_206B_200D_202E_206E_200B_206B_200E_200E_202E_202A_206A_206C_202D_202E_202A_200E_200E_206D_202E(text2, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3193177598u)));
						try
						{
							text = _206C_206C_200B_206E_202C_206D_202C_200D_200D_202C_206A_202C_206B_202D_200E_200E_200E_202B_206A_206E_200B_202A_206F_206D_200F_200B_200C_200C_202D_202D_200F_206D_202D_206E_202E_200D_202E_200D_206A_206D_202E((TextReader)streamReader);
						}
						finally
						{
							if (streamReader != null)
							{
								while (true)
								{
									IL_023f:
									int num3 = 1988499893;
									while (true)
									{
										switch ((num2 = (uint)(num3 ^ 0x43D670B6)) % 3)
										{
										case 0u:
											break;
										default:
											goto end_IL_0244;
										case 1u:
											goto IL_0262;
										case 2u:
											goto end_IL_0244;
										}
										goto IL_023f;
										IL_0262:
										_200F_202E_202D_206C_206B_206D_206C_206E_202C_202E_202B_206B_206E_200F_200C_200F_202E_200D_200D_206E_206F_200F_206A_206F_206F_200F_202E_200D_200C_206C_206F_202C_206C_206F_202D_206C_200C_206F_200E_202E_202E((IDisposable)streamReader);
										num3 = (int)(num2 * 2041997772) ^ -1448178953;
										continue;
										end_IL_0244:
										break;
									}
									break;
								}
							}
						}
						if (!_200E_200B_206A_200D_200C_200E_206B_200C_200E_200B_202C_206B_206C_206D_200E_200B_202B_200D_206C_202E_202E_206E_206B_202D_206E_200C_200D_202C_206A_206C_202C_206B_200C_206E_200C_206F_202B_206B_206D_206A_202E(text))
						{
							while (true)
							{
								int num4 = 1543493905;
								while (true)
								{
									switch ((num2 = (uint)(num4 ^ 0x43D670B6)) % 4)
									{
									case 2u:
										break;
									case 3u:
										array = _202B_206C_206B_202E_202A_200D_200D_202B_200C_206B_200E_200D_202E_202E_202A_200D_206A_202C_206F_200D_206D_200D_202C_206A_206F_206F_202B_206E_200B_206C_200B_206E_206F_200B_200E_202A_206B_206C_202E_206A_202E(_206A_200C_200D_206E_206D_200F_206D_202B_202B_202C_200C_202E_206E_202E_202B_200B_200D_206F_200E_206C_206C_200E_202C_206F_200F_206C_206D_206E_206C_200C_200C_206C_206D_206D_206F_202C_202E_202D_202C_206F_202E(text2), global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1507367067u));
										num4 = (int)((num2 * 1047929144) ^ 0x37BB0376);
										continue;
									case 0u:
										goto end_IL_0285;
									default:
										goto IL_02eb;
									}
									break;
								}
								continue;
								end_IL_0285:
								break;
							}
							num5 = 0;
							goto IL_04c7;
						}
						goto IL_050e;
					}
					IL_0470:
					if (_202E_206D_202C_202A_200C_206C_200D_200F_200B_202B_206C_202A_200E_206F_200C_200C_202C_200E_202D_206D_206D_206A_206D_200D_202A_206B_200D_206D_206C_202D_202E_202C_200F_200E_206D_206B_200B_206E_202D_200F_202E != null)
					{
						num7 = 1686673739;
						num8 = num7;
					}
					else
					{
						num7 = 731629529;
						num8 = num7;
					}
					goto IL_03fd;
					IL_03fd:
					while (true)
					{
						switch ((num2 = (uint)(num7 ^ 0x43D670B6)) % 15)
						{
						case 12u:
							break;
						case 7u:
							((Component)modItem).gameObject.SetActive(false);
							num7 = ((int)num2 * -1600055419) ^ -1590656656;
							continue;
						case 14u:
							goto IL_0470;
						case 9u:
						{
							CommonSettings.ScreenScale = (float)Screen.width / (float)Screen.height;
							int num13;
							int num14;
							if (CommonSettings.ScreenScale >= 2f)
							{
								num13 = 72031861;
								num14 = num13;
							}
							else
							{
								num13 = 2033955855;
								num14 = num13;
							}
							num7 = num13 ^ (int)(num2 * 1202111638);
							continue;
						}
						case 3u:
							goto IL_04c7;
						case 2u:
							val.GetComponent<RectTransform>().sizeDelta = Vector2.op_Implicit(new Vector3(108f, 112f));
							num7 = (int)(num2 * 858141657) ^ -463274801;
							continue;
						case 10u:
							goto IL_050e;
						case 1u:
							_202E_202B_200C_200B_200D_206C_206C_200C_202A_202A_202A_206B_202D_200C_200E_200F_200D_206B_202E_202D_202E_200D_202C_202C_200D_202E_200F_206B_202E_206C_200D_206C_200F_202D_200F_200F_202B_200E_206E_206A_202E((MonoBehaviour)(object)this, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3896171969u), 0.08f);
							num7 = (int)((num2 * 1668549517) ^ 0x12E0BB4F);
							continue;
						case 11u:
							_202E_202A_200E_202C_206B_200F_202B_206C_202C_200E_206C_200B_200D_200B_206C_200C_200C_202C_202D_202A_202C_200C_202E_206E_202D_202D_206E_200C_206C_206D_200D_206C_202D_202B_202C_206C_200F_202C_200D_206D_202E(val).localPosition = new Vector3(331f, 0f, 0f);
							num7 = (int)(num2 * 127766904) ^ -1800979743;
							continue;
						case 6u:
							GameObject.Find(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4201175930u)).SetActive(false);
							num7 = 1664250846;
							continue;
						case 5u:
						{
							int num11;
							int num12;
							if ((Object)(object)ModEditorResourceManager.uiCache[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3438503506u)] != (Object)null)
							{
								num11 = -460190424;
								num12 = num11;
							}
							else
							{
								num11 = -1371687778;
								num12 = num11;
							}
							num7 = num11 ^ (int)(num2 * 1833869177);
							continue;
						}
						case 8u:
							((Component)((Component)this).transform.FindChild(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(431580002u)).FindChild(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1456648527u))).gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(640f * CommonSettings.ScreenScale, 640f);
							num7 = ((int)num2 * -1570542405) ^ 0x1B555056;
							continue;
						case 4u:
							_206D_200B_202D_200B_206C_202D_206A_206C_202B_200D_200F_202D_202E_202C_206B_206A_206A_206D_200B_206E_202B_200E_206A_200F_202A_200D_206C_206B_202C_206E_200D_202A_200D_200C_202E_200B_200C_202A_200C_202D_202E(_200B_206D_202C_202A_206F_206D_206F_202E_202E_200F_206F_206D_202D_202D_200C_206A_202A_202A_206F_200C_206C_206B_206F_206B_202D_200E_200F_206C_202D_200D_200E_206B_202D_206E_202D_200C_206B_200B_202D_200F_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(187053272u)), false);
							_206D_200B_202D_200B_206C_202D_206A_206C_202B_200D_200F_202D_202E_202C_206B_206A_206A_206D_200B_206E_202B_200E_206A_200F_202A_200D_206C_206B_202C_206E_200D_202A_200D_200C_202E_200B_200C_202A_200C_202D_202E(_200B_206D_202C_202A_206F_206D_206F_202E_202E_200F_206F_206D_202D_202D_200C_206A_202A_202A_206F_200C_206C_206B_206F_206B_202D_200E_200F_206C_202D_200D_200E_206B_202D_206E_202D_200C_206B_200B_202D_200F_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3725305034u)), false);
							num7 = ((int)num2 * -1931176369) ^ -986047029;
							continue;
						case 13u:
							val.GetComponent<Image>().sprite = ModEditorResourceManager.uiCache[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2029011131u)];
							num7 = ((int)num2 * -362159332) ^ 0x4E7D2170;
							continue;
						default:
							((MonoBehaviour)this).Invoke(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(32747389u), 8f);
							return;
						}
						break;
					}
					goto IL_03f8;
					IL_04c7:
					if (num5 < array.Length)
					{
						goto IL_02eb;
					}
					num7 = 530406298;
					goto IL_03fd;
					IL_050e:
					val = _200C_202B_202C_202B_202D_202E_202E_206D_206D_200D_202B_200B_206C_206D_200C_202B_202E_202D_206E_200C_200B_206F_206A_202C_206C_202C_200C_200D_200F_202D_206F_200B_200C_202E_200F_200D_200C_206A_200D_200D_202E((Component)(object)((Component)modItem).GetComponent<ModItemUI>().startBtn);
					num7 = 658452293;
					goto IL_03fd;
					IL_03f8:
					num7 = 789433825;
					goto IL_03fd;
					IL_02eb:
					streamReader2 = _206A_200D_200B_200C_202B_206C_202A_206D_206A_202B_200C_206E_206C_202A_202D_202E_200E_206E_200F_200B_206B_206C_206F_202A_202C_200E_200B_206D_200F_200F_202A_206C_202A_202B_202E_206A_200D_202B_200C_202D_202E(_206A_206C_202E_206E_202A_200C_202A_202B_200F_202C_202E_200F_200D_206B_206C_202D_200E_200F_200E_206A_206E_202E_202A_202B_200D_202D_202C_200F_200E_200D_206C_200B_206A_202E_206B_206F_202A_200B_202E_206D_202E((FileSystemInfo)array[num5]));
					try
					{
						ModInfo modInfo = LoadSingleModInfo(_202C_202D_200E_200F_200D_206A_202C_206C_202C_206B_202B_202B_202B_200C_206E_206E_206F_200F_202D_200D_200B_202C_206A_206E_202A_202A_200B_202A_206C_206D_202A_206D_202E_202A_200C_200C_202B_200C_206E_200D_202E((TextReader)streamReader2));
						while (true)
						{
							IL_030b:
							int num16 = 1115410433;
							while (true)
							{
								switch ((num2 = (uint)(num16 ^ 0x43D670B6)) % 6)
								{
								case 4u:
									break;
								default:
									goto end_IL_0310;
								case 3u:
									_202E_206D_202C_202A_200C_206C_200D_200F_200B_202B_206C_202A_200E_206F_200C_200C_202C_200E_202D_206D_206D_206A_206D_200D_202A_206B_200D_206D_206C_202D_202E_202C_200F_200E_206D_206B_200B_206E_202D_200F_202E = modInfo;
									num16 = (int)(num2 * 1663616944) ^ -57360726;
									continue;
								case 5u:
								{
									int num19;
									int num20;
									if (!_200F_206F_202A_200D_206C_202C_202E_200E_200B_202E_206C_206C_200E_200E_200E_206A_202E_200C_206A_200E_206A_200D_200F_206B_200E_206C_206E_200D_206B_206A_206D_206C_200F_206D_202D_206C_200E_200F_206D_206A_202E(text, modInfo.key))
									{
										num19 = 2006400321;
										num20 = num19;
									}
									else
									{
										num19 = 1724564972;
										num20 = num19;
									}
									num16 = num19 ^ ((int)num2 * -1657750685);
									continue;
								}
								case 1u:
								{
									int num17;
									int num18;
									if (modInfo != null)
									{
										num17 = 792770750;
										num18 = num17;
									}
									else
									{
										num17 = 1275833955;
										num18 = num17;
									}
									num16 = num17 ^ (int)(num2 * 2016809197);
									continue;
								}
								case 0u:
									goto end_IL_0310;
								case 2u:
									goto IL_0470;
								}
								goto IL_030b;
								continue;
								end_IL_0310:
								break;
							}
							break;
						}
					}
					finally
					{
						if (streamReader2 != null)
						{
							while (true)
							{
								IL_03b7:
								int num21 = 170358253;
								while (true)
								{
									switch ((num2 = (uint)(num21 ^ 0x43D670B6)) % 3)
									{
									case 0u:
										break;
									default:
										goto end_IL_03bc;
									case 2u:
										goto IL_03da;
									case 1u:
										goto end_IL_03bc;
									}
									goto IL_03b7;
									IL_03da:
									_200F_202E_202D_206C_206B_206D_206C_206E_202C_202E_202B_206B_206E_200F_200C_200F_202E_200D_200D_206E_206F_200F_206A_206F_206F_200F_202E_200D_200C_206C_206F_202C_206C_206F_202D_206C_200C_206F_200E_202E_202E((IDisposable)streamReader2);
									num21 = ((int)num2 * -1090021323) ^ 0x2AEE74B2;
									continue;
									end_IL_03bc:
									break;
								}
								break;
							}
						}
					}
					num5++;
					goto IL_03f8;
				}
				break;
			}
		}
	}

	private void Update()
	{
	}

	public List<ModInfo> LoadXml(string xml)
	{
		List<ModInfo> list = new List<ModInfo>();
		XmlDocument xmlDocument = _202A_200F_200E_202E_200F_202E_200E_206A_206B_202A_200C_202C_206F_202D_206D_202A_200D_200D_200E_206A_200F_200C_202D_206F_206E_200C_200F_206E_206B_206C_202C_200C_202E_200B_202D_206E_200E_206C_206B_206C_202E();
		_202C_202E_200B_202C_202A_200C_202B_206A_200E_202B_200F_202B_206A_206C_206D_202D_200B_206C_200B_200B_202D_200D_206D_200E_200F_206E_200B_200F_200F_202C_202A_206F_200B_206F_202C_202A_206B_200C_200E_206D_202E(xmlDocument, xml);
		IEnumerator enumerator = _200C_200F_206B_206B_206C_206B_200E_206F_202C_206C_206C_206C_206C_206D_202A_206B_200F_200F_200F_202E_206B_202C_200F_202E_206C_206A_202D_206C_206C_202E_200C_200C_200F_202E_202A_206B_206C_200E_206D_202B_202E(_206B_200F_202B_206C_202A_200B_202C_200D_202E_200B_206C_200C_206E_206A_206A_202B_200F_202A_200E_206D_202B_206A_206E_202A_206F_200D_200E_200C_202C_202A_206F_206B_200F_200E_200F_202B_202B_202C_206F_206E_202E((XmlNode)xmlDocument, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3746042844u)));
		try
		{
			XmlNode xmlNode = default(XmlNode);
			while (true)
			{
				IL_008e:
				int num;
				int num2;
				if (!_200C_200B_206A_200E_202C_200D_206F_202C_200B_206F_202B_206F_206C_206B_206C_206E_200E_206F_202D_200B_200F_200E_202D_202A_206F_200E_202B_202A_200F_206D_206B_206F_202C_202C_206C_202C_200F_206D_200C_206F_202E(enumerator))
				{
					num = -91200751;
					num2 = num;
				}
				else
				{
					num = -1437541994;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -753331576)) % 5)
					{
					case 0u:
						num = -1437541994;
						continue;
					default:
						goto end_IL_0030;
					case 2u:
						xmlNode = (XmlNode)_206A_206E_206D_206B_202E_200C_200E_200E_206F_206F_206B_206A_206E_200F_200D_206E_200B_206C_206C_206B_200D_206D_200F_206F_200E_202B_200D_206F_202E_206E_206B_202D_206B_202C_206D_200D_206B_206A_202E_202C_202E(enumerator);
						num = -1795887662;
						continue;
					case 3u:
					{
						ModInfo item = BasePojo.Create<ModInfo>(_206D_200E_206A_206B_202D_200E_202E_206D_200F_206B_206E_200C_206E_200D_200E_202E_206B_206A_202B_202E_202A_202C_200C_202A_206B_202A_202E_206C_202A_200E_206B_206B_200B_200D_202E_200D_206E_202C_200F_202B_202E(xmlNode));
						list.Add(item);
						num = (int)((num3 * 1882298451) ^ 0x384F68C6);
						continue;
					}
					case 1u:
						break;
					case 4u:
						goto end_IL_0030;
					}
					goto IL_008e;
					continue;
					end_IL_0030:
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
				IL_00b1:
				int num4 = -539088500;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num4 ^ -753331576)) % 5)
					{
					case 0u:
						break;
					default:
						goto end_IL_00b6;
					case 4u:
					{
						int num5;
						int num6;
						if (disposable != null)
						{
							num5 = 1718597401;
							num6 = num5;
						}
						else
						{
							num5 = 973888055;
							num6 = num5;
						}
						num4 = num5 ^ (int)(num3 * 1439660504);
						continue;
					}
					case 3u:
						goto end_IL_00b6;
					case 1u:
						_200F_202E_202D_206C_206B_206D_206C_206E_202C_202E_202B_206B_206E_200F_200C_200F_202E_200D_200D_206E_206F_200F_206A_206F_206F_200F_202E_200D_200C_206C_206F_202C_206C_206F_202D_206C_200C_206F_200E_202E_202E(disposable);
						num4 = -933835658;
						continue;
					case 2u:
						goto end_IL_00b6;
					}
					goto IL_00b1;
					continue;
					end_IL_00b6:
					break;
				}
				break;
			}
		}
		IEnumerator enumerator2 = _200C_200F_206B_206B_206C_206B_200E_206F_202C_206C_206C_206C_206C_206D_202A_206B_200F_200F_200F_202E_206B_202C_200F_202E_206C_206A_202D_206C_206C_202E_200C_200C_200F_202E_202A_206B_206C_200E_206D_202B_202E(_206B_200F_202B_206C_202A_200B_202C_200D_202E_200B_206C_200C_206E_206A_206A_202B_200F_202A_200E_206D_202B_206A_206E_202A_206F_200D_200E_200C_202C_202A_206F_206B_200F_200E_200F_202B_202B_202C_206F_206E_202E((XmlNode)xmlDocument, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4017268437u)));
		try
		{
			GonggaoInfo gonggaoInfo = default(GonggaoInfo);
			while (true)
			{
				IL_015e:
				int num7;
				int num8;
				if (_200C_200B_206A_200E_202C_200D_206F_202C_200B_206F_202B_206F_206C_206B_206C_206E_200E_206F_202D_200B_200F_200E_202D_202A_206F_200E_202B_202A_200F_206D_206B_206F_202C_202C_206C_202C_200F_206D_200C_206F_202E(enumerator2))
				{
					num7 = -635112663;
					num8 = num7;
				}
				else
				{
					num7 = -718994768;
					num8 = num7;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num7 ^ -753331576)) % 5)
					{
					case 2u:
						num7 = -635112663;
						continue;
					default:
						goto end_IL_0138;
					case 4u:
						break;
					case 0u:
						_202D_200D_200C_202B_200F_200D_206C_206E_202A_200F_202C_202E_200C_200B_202C_202C_200C_200C_200E_206F_202C_200E_206B_200B_200E_200B_202E_206C_202C_200F_206B_206F_202B_202E_206A_200E_202A_206E_202C_206B_202E(gonggaoText, gonggaoInfo.text);
						num7 = (int)(num3 * 880966428) ^ -65629250;
						continue;
					case 1u:
					{
						XmlNode xmlNode2 = (XmlNode)_206A_206E_206D_206B_202E_200C_200E_200E_206F_206F_206B_206A_206E_200F_200D_206E_200B_206C_206C_206B_200D_206D_200F_206F_200E_202B_200D_206F_202E_206E_206B_202D_206B_202C_206D_200D_206B_206A_202E_202C_202E(enumerator2);
						gonggaoInfo = BasePojo.Create<GonggaoInfo>(_206D_200E_206A_206B_202D_200E_202E_206D_200F_206B_206E_200C_206E_200D_200E_202E_206B_206A_202B_202E_202A_202C_200C_202A_206B_202A_202E_206C_202A_200E_206B_206B_200B_200D_202E_200D_206E_202C_200F_202B_202E(xmlNode2));
						num7 = -988268449;
						continue;
					}
					case 3u:
						goto end_IL_0138;
					}
					goto IL_015e;
					continue;
					end_IL_0138:
					break;
				}
				break;
			}
		}
		finally
		{
			IDisposable disposable2 = enumerator2 as IDisposable;
			if (disposable2 != null)
			{
				goto IL_0203;
			}
			while (true)
			{
				uint num3;
				switch ((num3 = 1603219439u) % 3)
				{
				case 0u:
					continue;
				case 2u:
					goto end_IL_01cf;
				}
				goto IL_0203;
				continue;
				end_IL_01cf:
				break;
			}
			goto end_IL_01c2;
			IL_0203:
			_200F_202E_202D_206C_206B_206D_206C_206E_202C_202E_202B_206B_206E_200F_200C_200F_202E_200D_200D_206E_206F_200F_206A_206F_206F_200F_202E_200D_200C_206C_206F_202C_206C_206F_202D_206C_200C_206F_200E_202E_202E(disposable2);
			end_IL_01c2:;
		}
		return list;
	}

	public ModInfo LoadSingleModInfo(string xml)
	{
		XmlDocument xmlDocument = _202A_200F_200E_202E_200F_202E_200E_206A_206B_202A_200C_202C_206F_202D_206D_202A_200D_200D_200E_206A_200F_200C_202D_206F_206E_200C_200F_206E_206B_206C_202C_200C_202E_200B_202D_206E_200E_206C_206B_206C_202E();
		_202C_202E_200B_202C_202A_200C_202B_206A_200E_202B_200F_202B_206A_206C_206D_202D_200B_206C_200B_200B_202D_200D_206D_200E_200F_206E_200B_200F_200F_202C_202A_206F_200B_206F_202C_202A_206B_200C_200E_206D_202E(xmlDocument, xml);
		IEnumerator enumerator = _200C_200F_206B_206B_206C_206B_200E_206F_202C_206C_206C_206C_206C_206D_202A_206B_200F_200F_200F_202E_206B_202C_200F_202E_206C_206A_202D_206C_206C_202E_200C_200C_200F_202E_202A_206B_206C_200E_206D_202B_202E(_206B_200F_202B_206C_202A_200B_202C_200D_202E_200B_206C_200C_206E_206A_206A_202B_200F_202A_200E_206D_202B_206A_206E_202A_206F_200D_200E_200C_202C_202A_206F_206B_200F_200E_200F_202B_202B_202C_206F_206E_202E((XmlNode)xmlDocument, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2338192398u)));
		if (_200C_200B_206A_200E_202C_200D_206F_202C_200B_206F_202B_206F_206C_206B_206C_206E_200E_206F_202D_200B_200F_200E_202D_202A_206F_200E_202B_202A_200F_206D_206B_206F_202C_202C_206C_202C_200F_206D_200C_206F_202E(enumerator))
		{
			while (true)
			{
				uint num;
				switch ((num = 1027094696u) % 3)
				{
				case 0u:
					continue;
				case 2u:
					return BasePojo.Create<ModInfo>(_206D_200E_206A_206B_202D_200E_202E_206D_200F_206B_206E_200C_206E_200D_200E_202E_206B_206A_202B_202E_202A_202C_200C_202A_206B_202A_202E_206C_202A_200E_206B_206B_200B_200D_202E_200D_206E_202C_200F_202B_202E((XmlNode)_206A_206E_206D_206B_202E_200C_200E_200E_206F_206F_206B_206A_206E_200F_200D_206E_200B_206C_206C_206B_200D_206D_200F_206F_200E_202B_200D_206F_202E_206E_206B_202D_206B_202C_206D_200D_206B_206A_202E_202C_202E(enumerator)));
				}
				break;
			}
		}
		return null;
	}

	public void NoMod()
	{
		_202D_202E_202D_206D_200C_202E_202C_200E_202E_202E_200C_206A_200E_206F_202B_206A_200D_202C_202D_200E_200C_206C_206F_200F_200C_202E_202A_206F_202D_200F_202C_200C_206A_202E_202D_206F_200B_206F_206F_206A_202E((MonoBehaviour)(object)this, SetModCoroutine(null));
	}

	public void Refresh()
	{
		isLocal = false;
		while (true)
		{
			int num = -1717268311;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1172930303)) % 5)
				{
				case 2u:
					break;
				case 3u:
					_202D_200D_200C_202B_200F_200D_206C_206E_202A_200F_202C_202E_200C_200B_202C_202C_200C_200C_200E_206F_202C_200E_206B_200B_200E_200B_202E_206C_202C_200F_206B_206F_202B_202E_206A_200E_202A_206E_202C_206B_202E(versionText, _206C_206C_200E_206B_202C_206B_200E_206B_200B_202C_200D_202B_202A_200C_206E_206B_202B_202E_200E_206C_206C_202E_206E_202D_206A_206B_206B_200C_202B_200C_206D_206D_202C_200B_206A_200B_202C_200E_206F_200C_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(320085131u), new object[0]));
					num = ((int)num2 * -1930726188) ^ -1786227294;
					continue;
				case 1u:
					_202D_200D_200C_202B_200F_200D_206C_206E_202A_200F_202C_202E_200C_200B_202C_202C_200C_200C_200E_206F_202C_200E_206B_200B_200E_200B_202E_206C_202C_200F_206B_206F_202B_202E_206A_200E_202A_206E_202C_206B_202E(downloadingText, _202C_206E_206A_206A_200B_206D_202A_202E_200B_202A_202A_200B_206A_202D_200F_206F_200C_206D_202C_202D_200F_200F_206D_200D_202C_206A_202C_202A_202A_206A_202E_202A_206F_202B_206C_200F_206E_200E_206B_202E_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3403580487u), ref RuntimeData.Instance.hash1));
					_202D_200D_200C_202B_200F_200D_206C_206E_202A_200F_202C_202E_200C_200B_202C_202C_200C_200C_200E_206F_202C_200E_206B_200B_200E_200B_202E_206C_202C_200F_206B_206F_202B_202E_206A_200E_202A_206E_202C_206B_202E(gonggaoText, _202C_206E_206A_206A_200B_206D_202A_202E_200B_202A_202A_200B_206A_202D_200F_206F_200C_206D_202C_202D_200F_200F_206D_200D_202C_206A_202C_202A_202A_206A_202E_202A_206F_202B_206C_200F_206E_200E_206B_202E_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1851069984u), ref RuntimeData.Instance.hash2));
					num = ((int)num2 * -1747421042) ^ -734407137;
					continue;
				case 4u:
					_206D_200B_202D_200B_206C_202D_206A_206C_202B_200D_200F_202D_202E_202C_206B_206A_206A_206D_200B_206E_202B_200E_206A_200F_202A_200D_206C_206B_202C_206E_200D_202A_200D_200C_202E_200B_200C_202A_200C_202D_202E(_200C_202B_202C_202B_202D_202E_202E_206D_206D_200D_202B_200B_206C_206D_200C_202B_202E_202D_206E_200C_200B_206F_206A_202C_206C_202C_200C_200D_200F_202D_206F_200B_200C_202E_200F_200D_200C_206A_200D_200D_202E((Component)(object)downloadingText), true);
					num = (int)(num2 * 1293021712) ^ -434871999;
					continue;
				default:
					_206C_206A_206A_206A_206C_206D_202C_206A_206E_202D_202B_200D_200B_200F_200C_202A_200D_200E_202C_206D_202A_200C_206D_202A_206C_200F_206B_206B_202B_202E_206E_200C_206F_206E_202D_206A_200D_206B_200F_206E_202E(gonggaoText, 30);
					return;
				}
				break;
			}
		}
	}

	public void RefreshLocal()
	{
		isLocal = true;
		selectMenu.Clear();
		string text = default(string);
		FileInfo[] array = default(FileInfo[]);
		int num3 = default(int);
		GameObject val = default(GameObject);
		while (true)
		{
			int num = 820147371;
			while (true)
			{
				int num6;
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3D51E45B)) % 7)
				{
				case 0u:
					break;
				case 3u:
					_202B_206D_206E_202E_206A_206A_200C_202C_206B_200D_206F_202C_202E_202B_202E_206D_202A_202B_202E_202C_200D_206C_202B_200D_206F_200D_202A_200C_202C_206B_202D_206A_206E_206A_202E_202E_202E_200F_200E_200F_202E(text);
					num = (int)((num2 * 1691475231) ^ 0x70183D68);
					continue;
				case 1u:
					array = _202C_202C_202D_206A_206B_206C_206A_202B_206D_202E_200E_200D_200D_200D_202E_200D_206F_200C_206B_206C_206F_200D_200D_200F_206B_202A_206B_202D_206D_200E_206F_206B_200C_206B_200E_200C_206E_206C_200E_202E_202E(_206A_200C_200D_206E_206D_200F_206D_202B_202B_202C_200C_202E_206E_202E_202B_200B_200D_206F_200E_206C_206C_200E_202C_206F_200F_206C_206D_206E_206C_200C_200C_206C_206D_206D_206F_202C_202E_202D_202C_206F_202E(text), global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3480542717u));
					num3 = 0;
					num = 1156237594;
					continue;
				case 6u:
				{
					int num7;
					int num8;
					if (!_200C_202B_206A_200E_202A_206E_202D_200F_200F_202B_200C_206D_206D_206E_206F_206D_206A_200D_206D_202C_206D_206B_206D_202C_206D_202D_200C_206A_206D_206D_206D_206C_202B_202A_202A_202B_202D_200C_206B_200D_202E(text))
					{
						num7 = 317246921;
						num8 = num7;
					}
					else
					{
						num7 = 1341350726;
						num8 = num7;
					}
					num = num7 ^ ((int)num2 * -882109208);
					continue;
				}
				case 4u:
					text = _206D_202A_202D_202B_206B_206A_206E_202E_206E_206E_202C_202B_206B_206C_206B_206E_202A_206A_202B_200E_200C_202C_206B_200D_202E_206E_200B_206B_200E_200E_202E_202A_206A_206C_202D_202E_202A_200E_200E_206D_202E(CommonSettings.persistentDataPath, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(458296654u));
					num = (int)(num2 * 77962164) ^ -1691745801;
					continue;
				default:
				{
					FileInfo fileInfo = array[num3];
					StreamReader streamReader = _206A_200D_200B_200C_202B_206C_202A_206D_206A_202B_200C_206E_206C_202A_202D_202E_200E_206E_200F_200B_206B_206C_206F_202A_202C_200E_200B_206D_200F_200F_202A_206C_202A_202B_202E_206A_200D_202B_200C_202D_202E(_206A_206C_202E_206E_202A_200C_202A_202B_200F_202C_202E_200F_200D_206B_206C_202D_200E_200F_200E_206A_206E_202E_202A_202B_200D_202D_202C_200F_200E_200D_206C_200B_206A_202E_206B_206F_202A_200B_202E_206D_202E((FileSystemInfo)fileInfo));
					try
					{
						ModInfo modInfo = LoadSingleModInfo(_202C_200E_200D_202A_200C_206F_202B_200B_206E_202E_202D_206B_200F_202E_206F_200E_200D_206A_202A_200F_206E_202D_206B_206D_202D_200C_206F_200F_200E_206F_202B_200C_200C_202E_202A_206B_202B_200B_200D_202E(streamReader));
						if (modInfo != null)
						{
							while (true)
							{
								IL_0107:
								int num4 = 924967104;
								while (true)
								{
									switch ((num2 = (uint)(num4 ^ 0x3D51E45B)) % 6)
									{
									case 0u:
										break;
									default:
										goto end_IL_010c;
									case 5u:
										val = Object.Instantiate<GameObject>(_200C_202B_202C_202B_202D_202E_202E_206D_206D_200D_202B_200B_206C_206D_200C_202B_202E_202D_206E_200C_200B_206F_206A_202C_206C_202C_200C_200D_200F_202D_206F_200B_200C_202E_200F_200D_200C_206A_200D_200D_202E((Component)(object)modItem));
										num4 = ((int)num2 * -135981765) ^ 0x7F8309D1;
										continue;
									case 3u:
										_206D_200B_202D_200B_206C_202D_206A_206C_202B_200D_200F_202D_202E_202C_206B_206A_206A_206D_200B_206E_202B_200E_206A_200F_202A_200D_206C_206B_202C_206E_200D_202A_200D_200C_202E_200B_200C_202A_200C_202D_202E(val, true);
										num4 = ((int)num2 * -1558027749) ^ 0x45F3F3A0;
										continue;
									case 4u:
										val.GetComponent<ModItemUI>().Bind(modInfo, this, local: true);
										num4 = ((int)num2 * -166784202) ^ 0x236CE959;
										continue;
									case 2u:
										selectMenu.AddItem(val);
										num4 = (int)(num2 * 890879667) ^ -1340141816;
										continue;
									case 1u:
										goto end_IL_010c;
									}
									goto IL_0107;
									continue;
									end_IL_010c:
									break;
								}
								break;
							}
						}
					}
					finally
					{
						if (streamReader != null)
						{
							while (true)
							{
								IL_01b9:
								int num5 = 693579832;
								while (true)
								{
									switch ((num2 = (uint)(num5 ^ 0x3D51E45B)) % 3)
									{
									case 0u:
										break;
									default:
										goto end_IL_01be;
									case 1u:
										goto IL_01dc;
									case 2u:
										goto end_IL_01be;
									}
									goto IL_01b9;
									IL_01dc:
									_200F_202E_202D_206C_206B_206D_206C_206E_202C_202E_202B_206B_206E_200F_200C_200F_202E_200D_200D_206E_206F_200F_206A_206F_206F_200F_202E_200D_200C_206C_206F_202C_206C_206F_202D_206C_200C_206F_200E_202E_202E((IDisposable)streamReader);
									num5 = ((int)num2 * -1338882828) ^ 0x77F67AA3;
									continue;
									end_IL_01be:
									break;
								}
								break;
							}
						}
					}
					num3++;
					goto IL_01f8;
				}
				case 5u:
					goto IL_021b;
					IL_01f8:
					num6 = 390784441;
					goto IL_01fd;
					IL_01fd:
					switch ((num2 = (uint)(num6 ^ 0x3D51E45B)) % 3)
					{
					case 0u:
						break;
					default:
						return;
					case 2u:
						goto IL_021b;
					case 1u:
						return;
					}
					goto IL_01f8;
					IL_021b:
					if (num3 < array.Length)
					{
						goto default;
					}
					num6 = 1521619646;
					goto IL_01fd;
				}
				break;
			}
		}
	}

	public void OnLocalMod()
	{
		_206D_200B_202D_200B_206C_202D_206A_206C_202B_200D_200F_202D_202E_202C_206B_206A_206A_206D_200B_206E_202B_200E_206A_200F_202A_200D_206C_206B_202C_206E_200D_202A_200D_200C_202E_200B_200C_202A_200C_202D_202E(_200C_202B_202C_202B_202D_202E_202E_206D_206D_200D_202B_200B_206C_206D_200C_202B_202E_202D_206E_200C_200B_206F_206A_202C_206C_202C_200C_200D_200F_202D_206F_200B_200C_202E_200F_200D_200C_206A_200D_200D_202E((Component)(object)selectMenu), true);
		_206D_200B_202D_200B_206C_202D_206A_206C_202B_200D_200F_202D_202E_202C_206B_206A_206A_206D_200B_206E_202B_200E_206A_200F_202A_200D_206C_206B_202C_206E_200D_202A_200D_200C_202E_200B_200C_202A_200C_202D_202E(gonggaoPanel, false);
		while (true)
		{
			int num = -1544014068;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1751480377)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_003f;
				default:
					_202E_202B_200C_200B_200D_206C_206C_200C_202A_202A_202A_206B_202D_200C_200E_200F_200D_206B_202E_202D_202E_200D_202C_202C_200D_202E_200F_206B_202E_206C_200D_206C_200F_202D_200F_200F_202B_200E_206E_206A_202E((MonoBehaviour)(object)this, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4270132693u), 0.01f);
					_202C_202D_202C_206C_206F_206A_206A_200F_206F_202C_206F_206B_206F_202D_200C_206A_200C_200C_200E_202B_206D_202B_202B_206A_200D_200F_200F_206A_200C_206F_206D_200B_206C_206F_202B_202A_200E_206A_202A_206E_202E = false;
					return;
				}
				break;
				IL_003f:
				RefreshLocal();
				_200F_202E_200C_202E_202D_202B_202C_202B_202B_206E_200B_200D_206F_206D_202E_206A_202A_206D_206B_200B_206C_200B_206A_206E_200D_206F_206A_202B_206B_200E_206D_202A_202C_200D_206F_206F_202B_206A_202A_200F_202E((MonoBehaviour)(object)this);
				num = ((int)num2 * -135603397) ^ 0x2E8D0513;
			}
		}
	}

	public void OnOnlineMod()
	{
		_206D_200B_202D_200B_206C_202D_206A_206C_202B_200D_200F_202D_202E_202C_206B_206A_206A_206D_200B_206E_202B_200E_206A_200F_202A_200D_206C_206B_202C_206E_200D_202A_200D_200C_202E_200B_200C_202A_200C_202D_202E(_200C_202B_202C_202B_202D_202E_202E_206D_206D_200D_202B_200B_206C_206D_200C_202B_202E_202D_206E_200C_200B_206F_206A_202C_206C_202C_200C_200D_200F_202D_206F_200B_200C_202E_200F_200D_200C_206A_200D_200D_202E((Component)(object)selectMenu), true);
		while (true)
		{
			int num = -1365424166;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -383865929)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_0033;
				case 2u:
					return;
				}
				break;
				IL_0033:
				_206D_200B_202D_200B_206C_202D_206A_206C_202B_200D_200F_202D_202E_202C_206B_206A_206A_206D_200B_206E_202B_200E_206A_200F_202A_200D_206C_206B_202C_206E_200D_202A_200D_200C_202E_200B_200C_202A_200C_202D_202E(gonggaoPanel, false);
				Refresh();
				num = ((int)num2 * -900863765) ^ -1711375268;
			}
		}
	}

	public void OnGonggao()
	{
		_206D_200B_202D_200B_206C_202D_206A_206C_202B_200D_200F_202D_202E_202C_206B_206A_206A_206D_200B_206E_202B_200E_206A_200F_202A_200D_206C_206B_202C_206E_200D_202A_200D_200C_202E_200B_200C_202A_200C_202D_202E(_200C_202B_202C_202B_202D_202E_202E_206D_206D_200D_202B_200B_206C_206D_200C_202B_202E_202D_206E_200C_200B_206F_206A_202C_206C_202C_200C_200D_200F_202D_206F_200B_200C_202E_200F_200D_200C_206A_200D_200D_202E((Component)(object)selectMenu), false);
		_206D_200B_202D_200B_206C_202D_206A_206C_202B_200D_200F_202D_202E_202C_206B_206A_206A_206D_200B_206E_202B_200E_206A_200F_202A_200D_206C_206B_202C_206E_200D_202A_200D_200C_202E_200B_200C_202A_200C_202D_202E(gonggaoPanel, true);
	}

	public void OnClose()
	{
		LoadingUI.Load(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(952303036u));
	}

	[CompilerGenerated]
	private void _206F_202D_202E_206E_200D_206B_206D_206F_202E_206A_206A_200B_200C_206A_200C_202A_202A_206E_202A_202A_200C_200B_202C_206C_200F_200C_206F_200F_206C_200D_200C_200F_206B_206A_206F_200D_206D_206A_206C_202E_202E(string P_0)
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		_206D_200B_202D_200B_206C_202D_206A_206C_202B_200D_200F_202D_202E_202C_206B_206A_206A_206D_200B_206E_202B_200E_206A_200F_202A_200D_206C_206B_202C_206E_200D_202A_200D_200C_202E_200B_200C_202A_200C_202D_202E(_200C_202B_202C_202B_202D_202E_202E_206D_206D_200D_202B_200B_206C_206D_200C_202B_202E_202D_206E_200C_200B_206F_206A_202C_206C_202C_200C_200D_200F_202D_206F_200B_200C_202E_200F_200D_200C_206A_200D_200D_202E((Component)(object)downloadingText), false);
		List<ModInfo> list = (ModManager.mods = LoadXml(P_0));
		if (isLocal)
		{
			return;
		}
		GameObject val = default(GameObject);
		ModInfo current = default(ModInfo);
		while (true)
		{
			int num = 283988479;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1B277A5A)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_004d;
				default:
				{
					List<ModInfo>.Enumerator enumerator = list.GetEnumerator();
					try
					{
						while (true)
						{
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 1780064443;
								num4 = num3;
							}
							else
							{
								num3 = 939340122;
								num4 = num3;
							}
							while (true)
							{
								switch ((num2 = (uint)(num3 ^ 0x1B277A5A)) % 8)
								{
								case 4u:
									num3 = 1780064443;
									continue;
								default:
									return;
								case 6u:
									selectMenu.AddItem(val);
									num3 = 1205776793;
									continue;
								case 3u:
									break;
								case 7u:
									_200E_202D_200B_200D_202B_206E_200D_206D_206D_200B_202C_202C_206F_200F_206D_202B_200B_200B_200B_200F_206B_200D_206C_206E_200C_206D_202E_206E_200D_206B_200E_200E_200D_206C_206E_200C_202A_202C_206C_202E((Graphic)(object)((Component)val.GetComponent<ModItemUI>().downloadBtn).GetComponent<Image>(), Color.green);
									num3 = ((int)num2 * -747428137) ^ 0x55BC5D95;
									continue;
								case 5u:
								{
									int num5;
									int num6;
									if (!_200C_206C_206D_200E_206A_206B_206F_206D_202C_206D_206A_200C_202D_206A_202B_202B_202B_206C_206C_206B_206D_200C_200C_206C_206F_206A_206C_206D_206F_200E_202D_202B_206F_206E_202D_206B_200D_206D_202C_200D_202E(current.LocalXmlPath))
									{
										num5 = -43125838;
										num6 = num5;
									}
									else
									{
										num5 = -752202682;
										num6 = num5;
									}
									num3 = num5 ^ ((int)num2 * -1705659866);
									continue;
								}
								case 1u:
									current = enumerator.Current;
									val = Object.Instantiate<GameObject>(_200C_202B_202C_202B_202D_202E_202E_206D_206D_200D_202B_200B_206C_206D_200C_202B_202E_202D_206E_200C_200B_206F_206A_202C_206C_202C_200C_200D_200F_202D_206F_200B_200C_202E_200F_200D_200C_206A_200D_200D_202E((Component)(object)modItem));
									val.GetComponent<ModItemUI>().Bind(current, this, local: false);
									num3 = 2126575991;
									continue;
								case 2u:
									_202D_200D_200C_202B_200F_200D_206C_206E_202A_200F_202C_202E_200C_200B_202C_202C_200C_200C_200E_206F_202C_200E_206B_200B_200E_200B_202E_206C_202C_200F_206B_206F_202B_202E_206A_200E_202A_206E_202C_206B_202E(((Component)_206F_202E_200C_200B_202D_206D_200E_202C_206F_202B_200F_206E_206E_200C_200D_206C_200D_206D_200C_206C_202A_206C_200F_200F_206D_206B_202D_206B_206E_202D_206D_202C_202B_206D_200B_202E_206A_206C_206E_202C_202E(_206B_202E_206B_200B_206E_206E_200C_206F_202B_202D_200E_202E_206D_206A_206E_200C_206A_200C_206E_206E_206A_206E_200B_202A_200F_202E_206B_202B_200B_200C_200C_202B_206F_202C_206D_200D_206C_202C_200D_200D_202E((Component)(object)val.GetComponent<ModItemUI>().downloadBtn), global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(44441376u))).GetComponent<Text>(), global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(240661703u));
									num3 = ((int)num2 * -1273546167) ^ -43443449;
									continue;
								case 0u:
									return;
								}
								break;
							}
						}
					}
					finally
					{
						_200F_202E_202D_206C_206B_206D_206C_206E_202C_202E_202B_206B_206E_200F_200C_200F_202E_200D_200D_206E_206F_200F_206A_206F_206F_200F_202E_200D_200C_206C_206F_202C_206C_206F_202D_206C_200C_206F_200E_202E_202E((IDisposable)enumerator);
					}
				}
				}
				break;
				IL_004d:
				selectMenu.Clear();
				num = ((int)num2 * -901434351) ^ -165279685;
			}
		}
	}

	[CompilerGenerated]
	private void _206F_202B_206C_202B_202B_202E_200B_206A_206B_200C_200B_200B_202D_200F_200D_206B_206F_202B_206E_202C_206B_202B_206D_202E_202A_200F_202E_206B_206D_200E_206B_206E_200C_202A_200B_206E_202E_206D_206E_200F_202E()
	{
		_202D_200D_200C_202B_200F_200D_206C_206E_202A_200F_202C_202E_200C_200B_202C_202C_200C_200C_200E_206F_202C_200E_206B_200B_200E_200B_202E_206C_202C_200F_206B_206F_202B_202E_206A_200E_202A_206E_202C_206B_202E(downloadingText, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3509033343u));
	}

	private static string _202C_206E_206A_206A_200B_206D_202A_202E_200B_202A_202A_200B_206A_202D_200F_206F_200C_206D_202C_202D_200F_200F_206D_200D_202C_206A_202C_202A_202A_206A_202E_202A_206F_202B_206C_200F_206E_200E_206B_202E_202E(string P_0, ref string P_1)
	{
		string text = "";
		int num7 = default(int);
		int num6 = default(int);
		while (true)
		{
			int num = -1200496226;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1751818820)) % 7)
				{
				case 4u:
					break;
				case 1u:
					num7 = _206B_202A_202B_202E_206C_206D_206D_202A_200C_206B_206E_200D_202D_206B_206A_202A_200D_200C_202D_202D_200B_200F_202E_206A_200C_202E_206B_200D_206C_202C_202A_200B_206A_206A_206C_200B_206D_206A_200E_206C_202E(P_0, 0);
					num6 = 0;
					num = (int)((num2 * 816043848) ^ 0x72AE63DC);
					continue;
				case 2u:
					num = ((int)num2 * -134572633) ^ -1681289837;
					continue;
				case 6u:
					num6++;
					num = ((int)num2 * -2094709265) ^ -387620123;
					continue;
				case 0u:
				{
					int num8;
					if (num6 >= P_0.Length - 1)
					{
						num = -2071699826;
						num8 = num;
					}
					else
					{
						num = -2081960445;
						num8 = num;
					}
					continue;
				}
				case 5u:
					text += (char)(_206B_202A_202B_202E_206C_206D_206D_202A_200C_206B_206E_200D_202D_206B_206A_202A_200D_200C_202D_202D_200B_200F_202E_206A_200C_202E_206B_200D_206C_202C_202A_200B_206A_206A_206C_200B_206D_206A_200E_206C_202E(P_0, num6 + 1) - num7 + 2);
					num = -402259258;
					continue;
				default:
				{
					string text2 = "";
					try
					{
						int num3 = 0;
						while (true)
						{
							IL_00ca:
							int num4 = -1122975112;
							while (true)
							{
								switch ((num2 = (uint)(num4 ^ -1751818820)) % 6)
								{
								case 4u:
									break;
								default:
									goto end_IL_00cf;
								case 3u:
								{
									int num5;
									if (num3 >= text.Length / 4)
									{
										num4 = -1813068613;
										num5 = num4;
									}
									else
									{
										num4 = -1585395901;
										num5 = num4;
									}
									continue;
								}
								case 1u:
									text2 += (char)int.Parse(text.Substring(num3 * 4, 4), NumberStyles.HexNumber);
									num4 = -949189716;
									continue;
								case 2u:
									num4 = (int)((num2 * 2029332048) ^ 0x778EA45D);
									continue;
								case 0u:
									num3++;
									num4 = (int)((num2 * 1406266371) ^ 0x5737FB2D);
									continue;
								case 5u:
									goto end_IL_00cf;
								}
								goto IL_00ca;
								continue;
								end_IL_00cf:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					P_1 = text2;
					return text2;
				}
				}
				break;
			}
		}
	}

	private void autoOnLocalMod()
	{
		if (!_202E_206E_202D_200F_206A_206B_202C_206E_206B_206A_206C_202C_200D_200C_206C_206E_202C_206C_206F_206F_200C_202C_206E_206F_200E_206D_206A_202D_202C_200E_202B_206B_206F_200D_202B_202B_200B_206B_206D_200F_202E(_200C_202B_202C_202B_202D_202E_202E_206D_206D_200D_202B_200B_206C_206D_200C_202B_202E_202D_206E_200C_200B_206F_206A_202C_206C_202C_200C_200D_200F_202D_206F_200B_200C_202E_200F_200D_200C_206A_200D_200D_202E((Component)(object)_206D_202B_206A_206D_206D_206F_202D_206B_200C_202A_206C_202B_202C_200E_206F_206E_200E_202C_202A_202D_200C_200D_202B_200D_200E_200C_200E_200D_202A_200B_206C_202B_206E_206D_200C_200D_206D_200F_200F_206E_202E((Component)(object)this))))
		{
			return;
		}
		while (true)
		{
			int num = -825331093;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2046738222)) % 5)
				{
				case 0u:
					break;
				default:
					return;
				case 4u:
				{
					int num5;
					int num6;
					if (_202E_206E_202D_200F_206A_206B_202C_206E_206B_206A_206C_202C_200D_200C_206C_206E_202C_206C_206F_206F_200C_202C_206E_206F_200E_206D_206A_202D_202C_200E_202B_206B_206F_200D_202B_202B_200B_206B_206D_200F_202E(_200C_202B_202C_202B_202D_202E_202E_206D_206D_200D_202B_200B_206C_206D_200C_202B_202E_202D_206E_200C_200B_206F_206A_202C_206C_202C_200C_200D_200F_202D_206F_200B_200C_202E_200F_200D_200C_206A_200D_200D_202E((Component)(object)selectMenu)))
					{
						num5 = -1962394310;
						num6 = num5;
					}
					else
					{
						num5 = -1197287523;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1137811236);
					continue;
				}
				case 3u:
					OnLocalMod();
					num = ((int)num2 * -53746946) ^ 0x91FBC26;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (isLocal)
					{
						num3 = -1348317706;
						num4 = num3;
					}
					else
					{
						num3 = -922772750;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1106274576);
					continue;
				}
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private void readFile()
	{
		if (!_202E_200D_206C_200F_200E_206A_200C_206E_206A_206A_202E_206C_202D_202A_202A_200E_200D_200F_206D_200D_200C_206F_202B_200D_206A_202C_200B_200E_206E_206A_200D_202D_206A_206E_206D_200B_200D_206E_200C_206A_202E())
		{
			goto IL_0044;
		}
		while (true)
		{
			uint num;
			switch ((num = 43795072u) % 3)
			{
			case 2u:
				break;
			case 1u:
				goto end_IL_0007;
			default:
				goto IL_0044;
			}
			continue;
			end_IL_0007:
			break;
		}
		_200F_202A_200B_206A_202B_206C_202D_206A_202B_200E_200F_202C_200D_200B_200E_206B_202B_206E_200B_206A_200B_200F_200B_206E_200B_202E_206A_202C_202D_200C_200B_202C_200D_206B_206E_206F_202E_206C_200C_206F_202E(-1);
		goto IL_00fd;
		IL_0044:
		try
		{
			FileStream fileStream = _206C_202B_200F_206E_200F_206D_206D_200E_202E_200B_202B_202C_206E_200D_202C_202C_206F_206D_206C_202E_200B_206C_206C_206C_202A_202C_206C_202C_206A_200F_200F_206B_206B_206A_202D_202E_206E_206B_200F_206E_202E(_202B_200F_206F_202B_206F_202D_202A_200D_200E_200E_202E_206E_200C_206C_202B_200E_202A_202C_200D_200B_200B_206B_200F_202A_206A_200B_202D_202B_206C_206F_202E_202B_200C_206F_206D_202D_200C_206D_206E_206F_202E(_206F_200C_206B_200D_200B_206C_200F_206D_202E_200C_206C_202B_202B_206A_202E_200C_200E_206A_200B_202A_202C_200F_206A_202E_206E_206E_202A_200B_206B_202C_206A_202B_206D_206C_200D_200E_202C_206E_202D_200D_202E(_206E_200C_206A_206F_202C_202A_206A_200E_206E_202A_200F_202A_202B_206D_202E_200B_206C_206F_206F_202B_206A_200E_206C_202C_202E_200B_200D_206E_202E_200D_206D_200E_206A_206C_202C_200C_200F_200D_206C_206E_202E())), FileMode.Open, FileAccess.Read);
			int num2 = (int)_206B_206F_206D_200F_206F_202E_206C_206C_202C_200F_206D_200D_202B_202A_202A_202C_200F_200E_206A_200B_202B_206F_206F_200E_206D_200B_202A_200E_202A_202C_206A_206A_206D_200D_200C_200B_206C_202C_206B_202E((Stream)fileStream);
			byte[] array = new byte[num2];
			_200F_206B_200D_206E_206A_202A_206A_206E_206A_202E_202B_202C_200F_206B_206D_206C_206A_202D_206E_206A_202A_200E_200B_202A_206B_202B_200B_206C_202A_206F_206E_200B_206A_206F_200D_206B_200F_202A_206D_200C_202E((Stream)fileStream, array, 0, num2);
			_202D_200E_206C_200B_202B_200E_206D_206E_200D_200D_206D_200D_202E_200F_206C_202B_206D_200B_202A_206D_200B_206E_206E_206D_200C_202A_202D_206E_206A_206D_200D_200C_206B_202A_200E_200B_202C_206B_206F_202E((Stream)fileStream);
			while (true)
			{
				IL_0078:
				int num3 = 419346374;
				while (true)
				{
					uint num;
					switch ((num = (uint)(num3 ^ 0x557359D8)) % 5)
					{
					case 4u:
						break;
					default:
						goto end_IL_007d;
					case 1u:
					{
						int num4;
						int num5;
						if (CRC32.GetCRC32(array) == 3891665744u)
						{
							num4 = -605697119;
							num5 = num4;
						}
						else
						{
							num4 = -30869703;
							num5 = num4;
						}
						num3 = num4 ^ (int)(num * 862058853);
						continue;
					}
					case 0u:
						_206D_200F_206A_206C_206F_206A_200F_200D_200D_200C_200F_206F_202B_206A_200D_202A_202E_206B_206D_206E_206B_202E_206D_200E_200F_202D_206F_206B_202E_200E_202C_206A_200E_206D_202A_200D_206F_200C_202A_202D_202E();
						num3 = ((int)num * -450114293) ^ 0x51284DD;
						continue;
					case 3u:
						return;
					case 2u:
						goto end_IL_007d;
					}
					goto IL_0078;
					continue;
					end_IL_007d:
					break;
				}
				break;
			}
		}
		catch
		{
			_206D_200F_206A_206C_206F_206A_200F_200D_200D_200C_200F_206F_202B_206A_200D_202A_202E_206B_206D_206E_206B_202E_206D_200E_200F_202D_206F_206B_202E_200E_202C_206A_200E_206D_202A_200D_206F_200C_202A_202D_202E();
			return;
		}
		goto IL_00fd;
		IL_00fd:
		if (!_202E_202B_202E_206B_206B_202D_200D_206E_206C_202D_206F_200F_206B_202E_206D_202B_202A_206D_206A_200E_206F_206D_206D_206E_200E_200D_206E_206C_200E_202D_200D_206F_206F_202A_202D_200B_206D_200D_200E_200C_202E(_200B_202E_202E_200B_200D_206D_202B_200C_206D_202C_200B_202E_206E_202D_202B_200C_206E_206B_206C_200B_206C_202E_200C_202D_206F_200C_202D_206F_200C_206C_206A_206B_200D_206A_202D_202E_202C_206C_202D_202B_202E(), global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3449038713u)))
		{
			while (true)
			{
				int num6 = 1729580140;
				while (true)
				{
					uint num;
					switch ((num = (uint)(num6 ^ 0x557359D8)) % 5)
					{
					case 4u:
						break;
					default:
						return;
					case 3u:
						goto end_IL_0113;
					case 0u:
					{
						int num9;
						int num10;
						if (_202E_202B_202E_206B_206B_202D_200D_206E_206C_202D_206F_200F_206B_202E_206D_202B_202A_206D_206A_200E_206F_206D_206D_206E_200E_200D_206E_206C_200E_202D_200D_206F_206F_202A_202D_200B_206D_200D_200E_200C_202E(_206D_206E_206A_206A_202B_206D_202D_206A_200D_200E_206A_206E_206F_200B_200F_206A_200D_206D_200B_206E_200F_202C_202B_206B_206D_200F_202E_200F_206F_202E_200D_206D_206A_206C_206F_202D_202C_206B_206D_200D_202E(), global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4044977183u)))
						{
							num9 = -479643148;
							num10 = num9;
						}
						else
						{
							num9 = -28960916;
							num10 = num9;
						}
						num6 = num9 ^ ((int)num * -1855291394);
						continue;
					}
					case 1u:
					{
						int num7;
						int num8;
						if (!_202E_202B_202E_206B_206B_202D_200D_206E_206C_202D_206F_200F_206B_202E_206D_202B_202A_206D_206A_200E_206F_206D_206D_206E_200E_200D_206E_206C_200E_202D_200D_206F_206F_202A_202D_200B_206D_200D_200E_200C_202E(_202B_206A_202B_200B_200D_200D_206E_206B_206C_202D_200E_200F_202B_206B_202E_206A_202C_200C_202A_206A_202C_202D_206C_206C_202A_200F_200D_200E_206D_202C_202C_200B_202A_200B_200B_206B_202B_206C_206C_206E_202E(), global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2976223496u)))
						{
							num7 = 763471748;
							num8 = num7;
						}
						else
						{
							num7 = 774794292;
							num8 = num7;
						}
						num6 = num7 ^ ((int)num * -1982651818);
						continue;
					}
					case 2u:
						return;
					}
					break;
				}
				continue;
				end_IL_0113:
				break;
			}
		}
		_206D_200F_206A_206C_206F_206A_200F_200D_200D_200C_200F_206F_202B_206A_200D_202A_202E_206B_206D_206E_206B_202E_206D_200E_200F_202D_206F_206B_202E_200E_202C_206A_200E_206D_202A_200D_206F_200C_202A_202D_202E();
	}

	public IEnumerator SetModCoroutine(ModInfo mod)
	{
		ModSelectUI modSelectUI = default(ModSelectUI);
		string[] array = default(string[]);
		string config = default(string);
		while (true)
		{
			int num = -94094293;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1843945392)) % 23)
				{
				case 5u:
					break;
				default:
					yield break;
				case 18u:
				{
					modSelectUI = this;
					int num3;
					switch (num3)
					{
					case 1:
						goto IL_00dd;
					case 0:
						goto IL_0229;
					case 2:
						goto IL_028c;
					}
					num = (int)((num2 * 998085378) ^ 0x556AF0DF);
					continue;
				}
				case 19u:
				{
					int randomInt = Tools.GetRandomInt(0, array.Length - 1);
					RuntimeData.Instance.MAINMENU_STORY = _206F_200C_202A_200E_202A_202C_202C_200D_206D_200D_206A_206D_202C_202B_206F_206F_202C_202B_200C_202A_202D_202C_200E_206F_200E_206F_202D_202A_202B_206E_206E_202D_206A_202E_206A_206A_202A_200B_202E_202B_202E._200B_206E_206B_200B_206C_200C_202E_206B_202E_206F_202A_206E_200D_200B_206A_206C_206E_202D_202D_206D_206C_206F_202E_202B_206B_200D_200D_206B_206B_206D_202B_200F_202D_206D_202C_206A_206E_202D_200C_206D_202E(array[randomInt]);
					num = ((int)num2 * -238970758) ^ 0x2880B0C1;
					continue;
				}
				case 20u:
					goto IL_00dd;
				case 1u:
					num = (_206F_200C_202A_200E_202A_202C_202C_200D_206D_200D_206A_206D_202C_202B_206F_206F_202C_202B_200C_202A_202D_202C_200E_206F_200E_206F_202D_202A_202B_206E_206E_202D_206A_202E_206A_206A_202A_200B_202E_202B_202E._206E_202B_202E_206A_202E_206A_200D_206F_202D_202B_206A_202E_200D_202D_206E_202C_202E_206D_206C_202E_206B_202E_200F_200E_202C_206C_202C_206F_206C_202C_206A_202D_206E_202B_206B_206A_206D_206E_200F_202C_202E(_206F_200C_202A_200E_202A_202C_202C_200D_206D_200D_206A_206D_202C_202B_206F_206F_202C_202B_200C_202A_202D_202C_200E_206F_200E_206F_202D_202A_202B_206E_206E_202D_206A_202E_206A_206A_202A_200B_202E_202B_202E._200B_202A_206A_202E_206D_200C_202C_202E_200E_202D_202E_202A_202B_202B_206A_206B_200C_202B_206F_206F_206A_202A_202E_200B_206C_202E_200B_206E_206C_206A_200B_206B_206A_206F_202C_200E_202A_200D_202A_206F_202E(mod.LocalDirPath, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3520750327u))) ? 973807417 : 132415203) ^ ((int)num2 * -297601998);
					continue;
				case 10u:
					num = ((!_206F_200C_202A_200E_202A_202C_202C_200D_206D_200D_206A_206D_202C_202B_206F_206F_202C_202B_200C_202A_202D_202C_200E_206F_200E_206F_202D_202A_202B_206E_206E_202D_206A_202E_206A_206A_202A_200B_202E_202B_202E._206C_206B_200C_200F_200E_200E_206A_200F_200B_200D_206E_200D_200D_206B_200B_206C_206E_200B_200E_200F_202E_200F_202D_202B_206D_200B_200D_206C_202C_202A_206A_200E_206F_200C_206B_200C_202E_202C_202D_200F_202E(RuntimeData.Instance.hash1, _206F_200C_202A_200E_202A_202C_202C_200D_206D_200D_206A_206D_202C_202B_206F_206F_202C_202B_200C_202A_202D_202C_200E_206F_200E_206F_202D_202A_202B_206E_206E_202D_206A_202E_206A_206A_202A_200B_202E_202B_202E._206B_200F_206B_200B_200D_200B_200C_206A_202C_206F_200C_202B_202B_202C_206C_202C_200D_202D_200E_200F_202C_200E_202A_200C_206E_206F_200C_202B_202D_200D_200E_200C_200B_202B_206A_202D_200C_206E_200D_202B_202E(modSelectUI.downloadingText))) ? 271687348 : 693650297) ^ (int)(num2 * 596080834);
					continue;
				case 4u:
					/*Error near IL_0166: Unexpected return in MoveNext()*/;
				case 11u:
					num = ((mod == null) ? (-1234537142) : (-871603632)) ^ ((int)num2 * -1478908883);
					continue;
				case 6u:
					num = ((RuntimeData.Instance.GetAsc2(RuntimeData.Instance.hash1) == 1558) ? (-690749790) : (-927430680)) ^ (int)(num2 * 1260597438);
					continue;
				case 0u:
					yield return 0;
					break;
				case 7u:
					try
					{
						num = (int)(num2 * 408527575) ^ -1723585019;
					}
					finally
					{
						/*Error: Could not find finallyMethod for state=1.
Possibly this method is affected by a C# compiler bug that causes the finally body
not to run in case of an exception or early 'break;' out of a loop consuming this iterable.*/;
					}
				case 2u:
					LoadingUI.Load(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(952303036u));
					num = -426286502;
					continue;
				case 9u:
					goto IL_0229;
				case 15u:
					yield return 0;
					/*Error: Unable to find new state assignment for yield return*/;
				case 16u:
					yield break;
				case 12u:
					ModManager.SetCurrentMod2(mod);
					num = (int)(num2 * 2036766711) ^ -395895789;
					continue;
				case 14u:
					goto IL_028c;
				case 21u:
					num = ((!modSelectUI._202C_202D_202C_206C_206F_206A_206A_200F_206F_202C_206F_206B_206F_202D_200C_206A_200C_200C_200E_202B_206D_202B_202B_206A_200D_200F_200F_206A_200C_206F_206D_200B_206C_206F_202B_202A_200E_206A_202A_206E_202E) ? (-469535444) : (-603025840)) ^ ((int)num2 * -819935099);
					continue;
				case 22u:
					modSelectUI._202C_202D_202C_206C_206F_206A_206A_200F_206F_202C_206F_206B_206F_202D_200C_206A_200C_200C_200E_202B_206D_202B_202B_206A_200D_200F_200F_206A_200C_206F_206D_200B_206C_206F_202B_202A_200E_206A_202A_206E_202E = true;
					_206F_200C_202A_200E_202A_202C_202C_200D_206D_200D_206A_206D_202C_202B_206F_206F_202C_202B_200C_202A_202D_202C_200E_206F_200E_206F_202D_202A_202B_206E_206E_202D_206A_202E_206A_206A_202A_200B_202E_202B_202E._200F_206D_206D_206D_206A_206B_202C_200B_206E_206F_200D_200D_202C_200B_200B_206F_202E_206F_200C_202A_200C_206C_206B_200E_206A_202B_206C_206C_202C_206C_202C_206A_200F_206F_202A_202D_202C_202A_206F_206E_202E((MonoBehaviour)(object)modSelectUI);
					num = (int)((num2 * 1585182413) ^ 0x5AEB2EF9);
					continue;
				case 3u:
					array = _206F_200C_202A_200E_202A_202C_202C_200D_206D_200D_206A_206D_202C_202B_206F_206F_202C_202B_200C_202A_202D_202C_200E_206F_200E_206F_202D_202A_202B_206E_206E_202D_206A_202E_206A_206A_202A_200B_202E_202B_202E._200D_202C_206A_200C_206B_200E_202D_202E_206E_200B_206A_206A_206A_202A_206E_206D_206F_206D_202B_206F_206B_200C_200D_206E_200B_206D_200B_202A_202D_202E_200D_202C_200F_206B_206F_202A_202B_200B_206D_202A_202E(config, new char[1] { ',' });
					num = (int)(num2 * 963008032) ^ -545285799;
					continue;
				case 13u:
					ModManager.SetCurrentMod(mod);
					num = (int)(num2 * 1685774762) ^ -483273899;
					continue;
				case 17u:
					{
						config = LuaManager.GetConfig(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3961739264u));
						num = (_206F_200C_202A_200E_202A_202C_202C_200D_206D_200D_206A_206D_202C_202B_206F_206F_202C_202B_200C_202A_202D_202C_200E_206F_200E_206F_202D_202A_202B_206E_206E_202D_206A_202E_206A_206A_202A_200B_202E_202B_202E._206E_202C_202C_202C_206C_206C_206E_206C_200E_202C_206E_206F_200F_206C_200F_200C_206E_200C_200B_200F_206F_200C_206D_200D_206A_202D_206A_202B_202B_200F_200E_206A_206B_200E_202D_206F_206D_202E_206A_206C_202E(config) ? 1688944071 : 1436075684) ^ ((int)num2 * -145655476);
						continue;
					}
					IL_0229:
					num = -957022382;
					continue;
					IL_00dd:
					num = -658563110;
					continue;
					IL_028c:
					num = -550247748;
					continue;
				}
				break;
			}
		}
	}

	private void ClearMemory()
	{
		if (!Tools.ProbabilityTest(0.5))
		{
			return;
		}
		while (true)
		{
			int num = 203999018;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6BDFA412)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_0032;
				case 2u:
					return;
				}
				break;
				IL_0032:
				_202A_202A_200B_200B_206C_202C_206B_202C_202C_200C_202D_200E_200E_206E_202C_200F_202D_206C_206C_202D_200E_202B_200B_200F_202E_206A_206D_202A_200C_202E_200E_200F_200E_202C_200E_206C_202A_202E_200B_206D_202E();
				num = ((int)num2 * -2099150938) ^ -1778295526;
			}
		}
	}

	private void Autorun()
	{
		if (_202E_206D_202C_202A_200C_206C_200D_200F_200B_202B_206C_202A_200E_206F_200C_200C_202C_200E_202D_206D_206D_206A_206D_200D_202A_206B_200D_206D_206C_202D_202E_202C_200F_200E_206D_206B_200B_206E_202D_200F_202E == null)
		{
			return;
		}
		while (true)
		{
			int num = 1952145537;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4712EA81)) % 3)
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
				_202D_202E_202D_206D_200C_202E_202C_200E_202E_202E_200C_206A_200E_206F_202B_206A_200D_202C_202D_200E_200C_206C_206F_200F_200C_202E_202A_206F_202D_200F_202C_200C_206A_202E_202D_206F_200B_206F_206F_206A_202E((MonoBehaviour)(object)this, SetModCoroutine(_202E_206D_202C_202A_200C_206C_200D_200F_200B_202B_206C_202A_200E_206F_200C_200C_202C_200E_202D_206D_206D_206A_206D_200D_202A_206B_200D_206D_206C_202D_202E_202C_200F_200E_206D_206B_200B_206E_202D_200F_202E));
				num = (int)((num2 * 1534744148) ^ 0x67B1B6A5);
			}
		}
	}

	static GameObject _200C_202B_202C_202B_202D_202E_202E_206D_206D_200D_202B_200B_206C_206D_200C_202B_202E_202D_206E_200C_200B_206F_206A_202C_206C_202C_200C_200D_200F_202D_206F_200B_200C_202E_200F_200D_200C_206A_200D_200D_202E(Component P_0)
	{
		return P_0.gameObject;
	}

	static void _206D_200B_202D_200B_206C_202D_206A_206C_202B_200D_200F_202D_202E_202C_206B_206A_206A_206D_200B_206E_202B_200E_206A_200F_202A_200D_206C_206B_202C_206E_200D_202A_200D_200C_202E_200B_200C_202A_200C_202D_202E(GameObject P_0, bool P_1)
	{
		P_0.SetActive(P_1);
	}

	static int _200F_206D_200D_206C_200C_206B_206F_200C_200E_200D_200B_206D_206D_200F_206F_206B_200C_202B_202D_206E_200D_202B_200E_206C_206E_200D_206B_206E_202B_200B_202E_200C_206C_200C_202C_202C_206B_206F_200B_206A_202E()
	{
		return Application.targetFrameRate;
	}

	static void _200C_202E_206C_202C_200F_202C_202C_200D_202B_200D_202D_200E_202B_200E_202C_206A_202A_206D_206C_206B_200B_206A_206F_202A_202D_202E_200B_206B_202A_202C_202C_202B_206B_202D_200E_200C_206D_202D_206C_206F_202E(int P_0)
	{
		Application.targetFrameRate = P_0;
	}

	static string _206D_202A_202D_202B_206B_206A_206E_202E_206E_206E_202C_202B_206B_206C_206B_206E_202A_206A_202B_200E_200C_202C_206B_200D_202E_206E_200B_206B_200E_200E_202E_202A_206A_206C_202D_202E_202A_200E_200E_206D_202E(string P_0, string P_1)
	{
		return P_0 + P_1;
	}

	static bool _200C_202B_206A_200E_202A_206E_202D_200F_200F_202B_200C_206D_206D_206E_206F_206D_206A_200D_206D_202C_206D_206B_206D_202C_206D_202D_200C_206A_206D_206D_206D_206C_202B_202A_202A_202B_202D_200C_206B_200D_202E(string P_0)
	{
		return Directory.Exists(P_0);
	}

	static DirectoryInfo _202B_206D_206E_202E_206A_206A_200C_202C_206B_200D_206F_202C_202E_202B_202E_206D_202A_202B_202E_202C_200D_206C_202B_200D_206F_200D_202A_200C_202C_206B_202D_206A_206E_206A_202E_202E_202E_200F_200E_200F_202E(string P_0)
	{
		return Directory.CreateDirectory(P_0);
	}

	static void _202E_202B_200C_200B_200D_206C_206C_200C_202A_202A_202A_206B_202D_200C_200E_200F_200D_206B_202E_202D_202E_200D_202C_202C_200D_202E_200F_206B_202E_206C_200D_206C_200F_202D_200F_200F_202B_200E_206E_206A_202E(MonoBehaviour P_0, string P_1, float P_2)
	{
		P_0.Invoke(P_1, P_2);
	}

	static bool _200C_206C_206D_200E_206A_206B_206F_206D_202C_206D_206A_200C_202D_206A_202B_202B_202B_206C_206C_206B_206D_200C_200C_206C_206F_206A_206C_206D_206F_200E_202D_202B_206F_206E_202D_206B_200D_206D_202C_200D_202E(string P_0)
	{
		return File.Exists(P_0);
	}

	static StreamReader _206A_200D_200B_200C_202B_206C_202A_206D_206A_202B_200C_206E_206C_202A_202D_202E_200E_206E_200F_200B_206B_206C_206F_202A_202C_200E_200B_206D_200F_200F_202A_206C_202A_202B_202E_206A_200D_202B_200C_202D_202E(string P_0)
	{
		return new StreamReader(P_0);
	}

	static string _206C_206C_200B_206E_202C_206D_202C_200D_200D_202C_206A_202C_206B_202D_200E_200E_200E_202B_206A_206E_200B_202A_206F_206D_200F_200B_200C_200C_202D_202D_200F_206D_202D_206E_202E_200D_202E_200D_206A_206D_202E(TextReader P_0)
	{
		return P_0.ReadLine();
	}

	static void _200F_202E_202D_206C_206B_206D_206C_206E_202C_202E_202B_206B_206E_200F_200C_200F_202E_200D_200D_206E_206F_200F_206A_206F_206F_200F_202E_200D_200C_206C_206F_202C_206C_206F_202D_206C_200C_206F_200E_202E_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}

	static bool _200E_200B_206A_200D_200C_200E_206B_200C_200E_200B_202C_206B_206C_206D_200E_200B_202B_200D_206C_202E_202E_206E_206B_202D_206E_200C_200D_202C_206A_206C_202C_206B_200C_206E_200C_206F_202B_206B_206D_206A_202E(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}

	static DirectoryInfo _206A_200C_200D_206E_206D_200F_206D_202B_202B_202C_200C_202E_206E_202E_202B_200B_200D_206F_200E_206C_206C_200E_202C_206F_200F_206C_206D_206E_206C_200C_200C_206C_206D_206D_206F_202C_202E_202D_202C_206F_202E(string P_0)
	{
		return new DirectoryInfo(P_0);
	}

	static FileInfo[] _202B_206C_206B_202E_202A_200D_200D_202B_200C_206B_200E_200D_202E_202E_202A_200D_206A_202C_206F_200D_206D_200D_202C_206A_206F_206F_202B_206E_200B_206C_200B_206E_206F_200B_200E_202A_206B_206C_202E_206A_202E(DirectoryInfo P_0, string P_1)
	{
		return P_0.GetFiles(P_1);
	}

	static string _206A_206C_202E_206E_202A_200C_202A_202B_200F_202C_202E_200F_200D_206B_206C_202D_200E_200F_200E_206A_206E_202E_202A_202B_200D_202D_202C_200F_200E_200D_206C_200B_206A_202E_206B_206F_202A_200B_202E_206D_202E(FileSystemInfo P_0)
	{
		return P_0.FullName;
	}

	static string _202C_202D_200E_200F_200D_206A_202C_206C_202C_206B_202B_202B_202B_200C_206E_206E_206F_200F_202D_200D_200B_202C_206A_206E_202A_202A_200B_202A_206C_206D_202A_206D_202E_202A_200C_200C_202B_200C_206E_200D_202E(TextReader P_0)
	{
		return P_0.ReadToEnd();
	}

	static bool _200F_206F_202A_200D_206C_202C_202E_200E_200B_202E_206C_206C_200E_200E_200E_206A_202E_200C_206A_200E_206A_200D_200F_206B_200E_206C_206E_200D_206B_206A_206D_206C_200F_206D_202D_206C_200E_200F_206D_206A_202E(string P_0, string P_1)
	{
		return P_0 == P_1;
	}

	static GameObject _200B_206D_202C_202A_206F_206D_206F_202E_202E_200F_206F_206D_202D_202D_200C_206A_202A_202A_206F_200C_206C_206B_206F_206B_202D_200E_200F_206C_202D_200D_200E_206B_202D_206E_202D_200C_206B_200B_202D_200F_202E(string P_0)
	{
		return GameObject.Find(P_0);
	}

	static Transform _202E_202A_200E_202C_206B_200F_202B_206C_202C_200E_206C_200B_200D_200B_206C_200C_200C_202C_202D_202A_202C_200C_202E_206E_202D_202D_206E_200C_206C_206D_200D_206C_202D_202B_202C_206C_200F_202C_200D_206D_202E(GameObject P_0)
	{
		return P_0.transform;
	}

	static XmlDocument _202A_200F_200E_202E_200F_202E_200E_206A_206B_202A_200C_202C_206F_202D_206D_202A_200D_200D_200E_206A_200F_200C_202D_206F_206E_200C_200F_206E_206B_206C_202C_200C_202E_200B_202D_206E_200E_206C_206B_206C_202E()
	{
		return new XmlDocument();
	}

	static void _202C_202E_200B_202C_202A_200C_202B_206A_200E_202B_200F_202B_206A_206C_206D_202D_200B_206C_200B_200B_202D_200D_206D_200E_200F_206E_200B_200F_200F_202C_202A_206F_200B_206F_202C_202A_206B_200C_200E_206D_202E(XmlDocument P_0, string P_1)
	{
		P_0.LoadXml(P_1);
	}

	static XmlNodeList _206B_200F_202B_206C_202A_200B_202C_200D_202E_200B_206C_200C_206E_206A_206A_202B_200F_202A_200E_206D_202B_206A_206E_202A_206F_200D_200E_200C_202C_202A_206F_206B_200F_200E_200F_202B_202B_202C_206F_206E_202E(XmlNode P_0, string P_1)
	{
		return P_0.SelectNodes(P_1);
	}

	static IEnumerator _200C_200F_206B_206B_206C_206B_200E_206F_202C_206C_206C_206C_206C_206D_202A_206B_200F_200F_200F_202E_206B_202C_200F_202E_206C_206A_202D_206C_206C_202E_200C_200C_200F_202E_202A_206B_206C_200E_206D_202B_202E(XmlNodeList P_0)
	{
		return P_0.GetEnumerator();
	}

	static object _206A_206E_206D_206B_202E_200C_200E_200E_206F_206F_206B_206A_206E_200F_200D_206E_200B_206C_206C_206B_200D_206D_200F_206F_200E_202B_200D_206F_202E_206E_206B_202D_206B_202C_206D_200D_206B_206A_202E_202C_202E(IEnumerator P_0)
	{
		return P_0.Current;
	}

	static string _206D_200E_206A_206B_202D_200E_202E_206D_200F_206B_206E_200C_206E_200D_200E_202E_206B_206A_202B_202E_202A_202C_200C_202A_206B_202A_202E_206C_202A_200E_206B_206B_200B_200D_202E_200D_206E_202C_200F_202B_202E(XmlNode P_0)
	{
		return P_0.OuterXml;
	}

	static bool _200C_200B_206A_200E_202C_200D_206F_202C_200B_206F_202B_206F_206C_206B_206C_206E_200E_206F_202D_200B_200F_200E_202D_202A_206F_200E_202B_202A_200F_206D_206B_206F_202C_202C_206C_202C_200F_206D_200C_206F_202E(IEnumerator P_0)
	{
		return P_0.MoveNext();
	}

	static void _202D_200D_200C_202B_200F_200D_206C_206E_202A_200F_202C_202E_200C_200B_202C_202C_200C_200C_200E_206F_202C_200E_206B_200B_200E_200B_202E_206C_202C_200F_206B_206F_202B_202E_206A_200E_202A_206E_202C_206B_202E(Text P_0, string P_1)
	{
		P_0.text = P_1;
	}

	static Coroutine _202D_202E_202D_206D_200C_202E_202C_200E_202E_202E_200C_206A_200E_206F_202B_206A_200D_202C_202D_200E_200C_206C_206F_200F_200C_202E_202A_206F_202D_200F_202C_200C_206A_202E_202D_206F_200B_206F_206F_206A_202E(MonoBehaviour P_0, IEnumerator P_1)
	{
		return P_0.StartCoroutine(P_1);
	}

	static string _206C_206C_200E_206B_202C_206B_200E_206B_200B_202C_200D_202B_202A_200C_206E_206B_202B_202E_200E_206C_206C_202E_206E_202D_206A_206B_206B_200C_202B_200C_206D_206D_202C_200B_206A_200B_202C_200E_206F_200C_202E(string P_0, object[] P_1)
	{
		return string.Format(P_0, P_1);
	}

	static void _206C_206A_206A_206A_206C_206D_202C_206A_206E_202D_202B_200D_200B_200F_200C_202A_200D_200E_202C_206D_202A_200C_206D_202A_206C_200F_206B_206B_202B_202E_206E_200C_206F_206E_202D_206A_200D_206B_200F_206E_202E(Text P_0, int P_1)
	{
		P_0.fontSize = P_1;
	}

	static FileInfo[] _202C_202C_202D_206A_206B_206C_206A_202B_206D_202E_200E_200D_200D_200D_202E_200D_206F_200C_206B_206C_206F_200D_200D_200F_206B_202A_206B_202D_206D_200E_206F_206B_200C_206B_200E_200C_206E_206C_200E_202E_202E(DirectoryInfo P_0, string P_1)
	{
		return P_0.GetFiles(P_1);
	}

	static string _202C_200E_200D_202A_200C_206F_202B_200B_206E_202E_202D_206B_200F_202E_206F_200E_200D_206A_202A_200F_206E_202D_206B_206D_202D_200C_206F_200F_200E_206F_202B_200C_200C_202E_202A_206B_202B_200B_200D_202E(StreamReader P_0)
	{
		return P_0.ReadToEnd();
	}

	static void _200F_202E_200C_202E_202D_202B_202C_202B_202B_206E_200B_200D_206F_206D_202E_206A_202A_206D_206B_200B_206C_200B_206A_206E_200D_206F_206A_202B_206B_200E_206D_202A_202C_200D_206F_206F_202B_206A_202A_200F_202E(MonoBehaviour P_0)
	{
		P_0.CancelInvoke();
	}

	static Transform _206B_202E_206B_200B_206E_206E_200C_206F_202B_202D_200E_202E_206D_206A_206E_200C_206A_200C_206E_206E_206A_206E_200B_202A_200F_202E_206B_202B_200B_200C_200C_202B_206F_202C_206D_200D_206C_202C_200D_200D_202E(Component P_0)
	{
		return P_0.transform;
	}

	static Transform _206F_202E_200C_200B_202D_206D_200E_202C_206F_202B_200F_206E_206E_200C_200D_206C_200D_206D_200C_206C_202A_206C_200F_200F_206D_206B_202D_206B_206E_202D_206D_202C_202B_206D_200B_202E_206A_206C_206E_202C_202E(Transform P_0, string P_1)
	{
		return P_0.FindChild(P_1);
	}

	static void _200E_202D_200B_200D_202B_206E_200D_206D_206D_200B_202C_202C_206F_200F_206D_202B_200B_200B_200B_200F_206B_200D_206C_206E_200C_206D_202E_206E_200D_206B_200E_200E_200D_206C_206E_200C_202A_202C_206C_202E(Graphic P_0, Color P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.color = P_1;
	}

	static char _206B_202A_202B_202E_206C_206D_206D_202A_200C_206B_206E_200D_202D_206B_206A_202A_200D_200C_202D_202D_200B_200F_202E_206A_200C_202E_206B_200D_206C_202C_202A_200B_206A_206A_206C_200B_206D_206A_200E_206C_202E(string P_0, int P_1)
	{
		return P_0[P_1];
	}

	static Transform _206D_202B_206A_206D_206D_206F_202D_206B_200C_202A_206C_202B_202C_200E_206F_206E_200E_202C_202A_202D_200C_200D_202B_200D_200E_200C_200E_200D_202A_200B_206C_202B_206E_206D_200C_200D_206D_200F_200F_206E_202E(Component P_0)
	{
		return P_0.transform;
	}

	static bool _202E_206E_202D_200F_206A_206B_202C_206E_206B_206A_206C_202C_200D_200C_206C_206E_202C_206C_206F_206F_200C_202C_206E_206F_200E_206D_206A_202D_202C_200E_202B_206B_206F_200D_202B_202B_200B_206B_206D_200F_202E(GameObject P_0)
	{
		return P_0.activeSelf;
	}

	static bool _202E_200D_206C_200F_200E_206A_200C_206E_206A_206A_202E_206C_202D_202A_202A_200E_200D_200F_206D_200D_200C_206F_202B_200D_206A_202C_200B_200E_206E_206A_200D_202D_206A_206E_206D_200B_200D_206E_200C_206A_202E()
	{
		return Application.isMobilePlatform;
	}

	static void _200F_202A_200B_206A_202B_206C_202D_206A_202B_200E_200F_202C_200D_200B_200E_206B_202B_206E_200B_206A_200B_200F_200B_206E_200B_202E_206A_202C_202D_200C_200B_202C_200D_206B_206E_206F_202E_206C_200C_206F_202E(int P_0)
	{
		Screen.sleepTimeout = P_0;
	}

	static Process _206E_200C_206A_206F_202C_202A_206A_200E_206E_202A_200F_202A_202B_206D_202E_200B_206C_206F_206F_202B_206A_200E_206C_202C_202E_200B_200D_206E_202E_200D_206D_200E_206A_206C_202C_200C_200F_200D_206C_206E_202E()
	{
		return Process.GetCurrentProcess();
	}

	static ProcessModule _206F_200C_206B_200D_200B_206C_200F_206D_202E_200C_206C_202B_202B_206A_202E_200C_200E_206A_200B_202A_202C_200F_206A_202E_206E_206E_202A_200B_206B_202C_206A_202B_206D_206C_200D_200E_202C_206E_202D_200D_202E(Process P_0)
	{
		return P_0.MainModule;
	}

	static string _202B_200F_206F_202B_206F_202D_202A_200D_200E_200E_202E_206E_200C_206C_202B_200E_202A_202C_200D_200B_200B_206B_200F_202A_206A_200B_202D_202B_206C_206F_202E_202B_200C_206F_206D_202D_200C_206D_206E_206F_202E(ProcessModule P_0)
	{
		return P_0.FileName;
	}

	static FileStream _206C_202B_200F_206E_200F_206D_206D_200E_202E_200B_202B_202C_206E_200D_202C_202C_206F_206D_206C_202E_200B_206C_206C_206C_202A_202C_206C_202C_206A_200F_200F_206B_206B_206A_202D_202E_206E_206B_200F_206E_202E(string P_0, FileMode P_1, FileAccess P_2)
	{
		return new FileStream(P_0, P_1, P_2);
	}

	static long _206B_206F_206D_200F_206F_202E_206C_206C_202C_200F_206D_200D_202B_202A_202A_202C_200F_200E_206A_200B_202B_206F_206F_200E_206D_200B_202A_200E_202A_202C_206A_206A_206D_200D_200C_200B_206C_202C_206B_202E(Stream P_0)
	{
		return P_0.Length;
	}

	static int _200F_206B_200D_206E_206A_202A_206A_206E_206A_202E_202B_202C_200F_206B_206D_206C_206A_202D_206E_206A_202A_200E_200B_202A_206B_202B_200B_206C_202A_206F_206E_200B_206A_206F_200D_206B_200F_202A_206D_200C_202E(Stream P_0, byte[] P_1, int P_2, int P_3)
	{
		return P_0.Read(P_1, P_2, P_3);
	}

	static void _202D_200E_206C_200B_202B_200E_206D_206E_200D_200D_206D_200D_202E_200F_206C_202B_206D_200B_202A_206D_200B_206E_206E_206D_200C_202A_202D_206E_206A_206D_200D_200C_206B_202A_200E_200B_202C_206B_206F_202E(Stream P_0)
	{
		P_0.Close();
	}

	static void _206D_200F_206A_206C_206F_206A_200F_200D_200D_200C_200F_206F_202B_206A_200D_202A_202E_206B_206D_206E_206B_202E_206D_200E_200F_202D_206F_206B_202E_200E_202C_206A_200E_206D_202A_200D_206F_200C_202A_202D_202E()
	{
		Application.Quit();
	}

	static string _200B_202E_202E_200B_200D_206D_202B_200C_206D_202C_200B_202E_206E_202D_202B_200C_206E_206B_206C_200B_206C_202E_200C_202D_206F_200C_202D_206F_200C_206C_206A_206B_200D_206A_202D_202E_202C_206C_202D_202B_202E()
	{
		return Application.bundleIdentifier;
	}

	static bool _202E_202B_202E_206B_206B_202D_200D_206E_206C_202D_206F_200F_206B_202E_206D_202B_202A_206D_206A_200E_206F_206D_206D_206E_200E_200D_206E_206C_200E_202D_200D_206F_206F_202A_202D_200B_206D_200D_200E_200C_202E(string P_0, string P_1)
	{
		return P_0 != P_1;
	}

	static string _202B_206A_202B_200B_200D_200D_206E_206B_206C_202D_200E_200F_202B_206B_202E_206A_202C_200C_202A_206A_202C_202D_206C_206C_202A_200F_200D_200E_206D_202C_202C_200B_202A_200B_200B_206B_202B_206C_206C_206E_202E()
	{
		return Application.productName;
	}

	static string _206D_206E_206A_206A_202B_206D_202D_206A_200D_200E_206A_206E_206F_200B_200F_206A_200D_206D_200B_206E_200F_202C_202B_206B_206D_200F_202E_200F_206F_202E_200D_206D_206A_206C_206F_202D_202C_206B_206D_200D_202E()
	{
		return Application.version;
	}

	static AsyncOperation _202A_202A_200B_200B_206C_202C_206B_202C_202C_200C_202D_200E_200E_206E_202C_200F_202D_206C_206C_202D_200E_202B_200B_200F_202E_206A_206D_202A_200C_202E_200E_200F_200E_202C_200E_206C_202A_202E_200B_206D_202E()
	{
		return Resources.UnloadUnusedAssets();
	}
}
