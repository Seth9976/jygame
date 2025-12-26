using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace JyGame;

public class ItemMenu : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _200D_206C_200C_206B_206C_202E_200E_202A_202D_200E_202D_200D_206D_200D_206C_206D_206B_200B_202E_200E_202C_200D_206F_202D_202B_200B_200B_206E_202A_206D_200D_200D_206C_202C_206C_202E_206D_202C_206E_206D_202E
	{
		internal ItemInstance item;

		internal ItemMenu _202A_202B_206D_202D_200C_202E_206F_200C_202B_202E_202E_206E_200D_206A_206F_206D_206F_200E_202C_206F_200B_206D_206B_202D_206C_206A_200D_200D_206D_200F_200F_206B_202A_202D_202A_200B_200F_200B_202C_202E_202E;

		internal void _206C_202C_206E_206F_202E_202E_206F_202E_202D_200D_202A_200C_200E_206E_202E_206C_200D_200D_202C_200B_202A_206B_202D_200F_206C_202D_202D_202B_200B_200D_200D_206D_206C_200B_202B_202E_202B_200F_202C_202C_202E()
		{
			_202A_202B_206D_202D_200C_202E_206F_200C_202B_202E_202E_206E_200D_206A_206F_206D_206F_200E_202C_206F_200B_206D_206B_202D_206C_206A_200D_200D_206D_200F_200F_206B_202A_202D_202A_200B_200F_200B_202C_202E_202E._206B_200B_200F_200D_206E_206C_206D_206D_206C_200C_206B_200B_206E_202A_206C_202D_202D_206C_206A_202B_206D_202D_200E_200F_202A_206E_200F_206F_200F_202C_202D_206E_202A_206D_206C_200C_206F_206A_202C_206C_202E(item);
		}
	}

	[CompilerGenerated]
	private sealed class _206E_200F_202A_202B_202C_202D_202C_202C_206F_200C_202C_202B_200C_200F_202B_200E_200E_202C_200E_206D_200C_200D_206A_206B_206F_206C_200C_206A_200B_200F_200B_206E_202A_202C_202A_206E_206E_206D_206B_202B_202E
	{
		public ItemInstance item;

		public ItemMenu _202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E;

		internal void _200F_200B_206D_200C_206F_202D_206B_206E_206E_200E_200D_202D_202C_200E_202C_202C_206C_202C_206F_202B_202A_200D_200E_206F_200F_206C_202A_202D_200E_200C_202E_200C_200D_206C_200D_206E_206B_200E_202E()
		{
			_202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E._206B_200B_200F_200D_206E_206C_206D_206D_206C_200C_206B_200B_206E_202A_206C_202D_202D_206C_206A_202B_206D_202D_200E_200F_202A_206E_200F_206F_200F_202C_202D_206E_202A_206D_206C_200C_206F_206A_202C_206C_202E(item);
		}
	}

	[CompilerGenerated]
	private sealed class _206A_202E_206D_202D_206F_206C_206F_200F_202C_200F_206B_200F_206F_202B_200E_202E_206F_206C_206A_206D_202A_206D_206F_202A_200F_200C_200B_202D_202A_202D_202D_206D_206A_206E_206B_200D_200F_200E_200F_202E_202E : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E;

		private object _200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E;

		public ItemMenu _202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E;

		public SelectMenu selectMenu;

		public List<KeyValuePair<ItemInstance, int>> list;

		private int _200B_202C_200F_206C_206F_202C_206B_206E_200D_202B_206E_206B_200C_206E_202A_200B_200E_200E_202A_206F_202D_200B_206C_200F_200E_200F_202D_206F_200B_206A_206A_206D_200C_202D_202A_200E_200F_206A_202A_206B_202E;

		private bool _200C_206B_200B_206A_206E_202A_202E_206D_200D_200F_206F_200E_206E_206C_202C_200C_206C_202D_200E_202A_202E_202B_206B_206F_206E_200C_206C_200E_206D_200E_206F_200E_202D_202B_200F_200D_200C_206E_202A_202E_202E;

		private List<KeyValuePair<ItemInstance, int>>.Enumerator _206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E;

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
		public _206A_202E_206D_202D_206F_206C_206F_200F_202C_200F_206B_200F_206F_202B_200E_202E_206F_206C_206A_206D_202A_206D_206F_202A_200F_200C_200B_202D_202A_202D_202D_206D_206A_206E_206B_200D_200F_200E_200F_202E_202E(int P_0)
		{
			_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = P_0;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E;
			if (num != -3)
			{
				while (true)
				{
					int num2 = 1845261181;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num2 ^ 0x42DE794B)) % 3)
						{
						case 0u:
							break;
						case 1u:
							if (num == 1)
							{
								num2 = (int)(num3 * 1600046089) ^ -974605705;
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
				ItemMenu itemMenu = _202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E;
				int num2;
				int num4 = default(int);
				_206E_200F_202A_202B_202C_202D_202C_202C_206F_200C_202C_202B_200C_200F_202B_200E_200E_202C_200E_206D_200C_200D_206A_206B_206F_206C_200C_206A_200B_200F_200B_206E_202A_202C_202A_206E_206E_206D_206B_202B_202E obj = default(_206E_200F_202A_202B_202C_202D_202C_202C_206F_200C_202C_202B_200C_200F_202B_200E_200E_202C_200E_206D_200C_200D_206A_206B_206F_206C_200C_206A_200B_200F_200B_206E_202A_202C_202A_206E_206E_206D_206B_202B_202E);
				KeyValuePair<ItemInstance, int> current = default(KeyValuePair<ItemInstance, int>);
				GameObject val = default(GameObject);
				switch (num)
				{
				default:
					num2 = -1389329735;
					goto IL_0029;
				case 1:
					goto IL_00ed;
				case 2:
					goto IL_026f;
				case 0:
					goto IL_0407;
				case 3:
					goto IL_0453;
					IL_0029:
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num2 ^ -35028288)) % 34)
						{
						case 10u:
							break;
						default:
							goto end_IL_000f;
						case 24u:
							_200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E = 0;
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 1;
							num2 = (int)((num3 * 1521580569) ^ 0x12E51CE2);
							continue;
						case 28u:
							goto IL_00ed;
						case 32u:
						{
							int num9;
							int num10;
							if (_200B_202C_200F_206C_206F_202C_206B_206E_200D_202B_206E_206B_200C_206E_202A_200B_200E_200E_202A_206F_202D_200B_206C_200F_200E_200F_202D_206F_200B_206A_206A_206D_200C_202D_202A_200E_200F_206A_202A_206B_202E <= 41)
							{
								num9 = -409920031;
								num10 = num9;
							}
							else
							{
								num9 = -1332992009;
								num10 = num9;
							}
							num2 = num9 ^ ((int)num3 * -1318727116);
							continue;
						}
						case 8u:
							itemMenu.ShowSelectMenuAll(selectMenu, list.Count);
							num2 = (int)(num3 * 1903930214) ^ -1200636232;
							continue;
						case 16u:
							goto IL_0172;
						case 7u:
							goto end_IL_000f;
						case 29u:
							_200B_202C_200F_206C_206F_202C_206B_206E_200D_202B_206E_206B_200C_206E_202A_200B_200E_200E_202A_206F_202D_200B_206C_200F_200E_200F_202D_206F_200B_206A_206A_206D_200C_202D_202A_200E_200F_206A_202A_206B_202E = 0;
							num2 = (int)(num3 * 1319531134) ^ -736661672;
							continue;
						case 19u:
							num4 = RuntimeData.Instance.num_decode(num4);
							num2 = ((int)num3 * -904345334) ^ 0x78E104CA;
							continue;
						case 0u:
							_200B_202C_200F_206C_206F_202C_206B_206E_200D_202B_206E_206B_200C_206E_202A_200B_200E_200E_202A_206F_202D_200B_206C_200F_200E_200F_202D_206F_200B_206A_206A_206D_200C_202D_202A_200E_200F_206A_202A_206B_202E = 0;
							_200C_206B_200B_206A_206E_202A_202E_206D_200D_200F_206F_200E_206E_206C_202C_200C_206C_202D_200E_202A_202E_202B_206B_206F_206E_200C_206C_200E_206D_200E_206F_200E_202D_202B_200F_200D_200C_206E_202A_202E_202E = false;
							num2 = ((int)num3 * -1561747573) ^ 0x2E284A7C;
							continue;
						case 6u:
							goto end_IL_000f;
						case 15u:
							_200C_206B_200B_206A_206E_202A_202E_206D_200D_200F_206F_200E_206E_206C_202C_200C_206C_202D_200E_202A_202E_202B_206B_206F_206E_200C_206C_200E_206D_200E_206F_200E_202D_202B_200F_200D_200C_206E_202A_202E_202E = true;
							num2 = (int)(num3 * 474817166) ^ -2053890205;
							continue;
						case 31u:
							goto IL_026f;
						case 3u:
						{
							int num7;
							int num8;
							if (_200C_206B_200B_206A_206E_202A_202E_206D_200D_200F_206F_200E_206E_206C_202C_200C_206C_202D_200E_202A_202E_202B_206B_206F_206E_200C_206C_200E_206D_200E_206F_200E_202D_202B_200F_200D_200C_206E_202A_202E_202E)
							{
								num7 = 890741122;
								num8 = num7;
							}
							else
							{
								num7 = 1377102772;
								num8 = num7;
							}
							num2 = num7 ^ (int)(num3 * 1081817463);
							continue;
						}
						case 13u:
							_200B_202C_200F_206C_206F_202C_206B_206E_200D_202B_206E_206B_200C_206E_202A_200B_200E_200E_202A_206F_202D_200B_206C_200F_200E_200F_202D_206F_200B_206A_206A_206D_200C_202D_202A_200E_200F_206A_202A_206B_202E++;
							num2 = (int)(num3 * 450371644) ^ -1455114608;
							continue;
						case 22u:
							result = true;
							goto end_IL_000f;
						case 11u:
							CommonSettings.UpdatingShopUI = false;
							_200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E = 0;
							num2 = -1275069806;
							continue;
						case 12u:
							_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E = list.GetEnumerator();
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -3;
							num2 = ((int)num3 * -1157224171) ^ 0x72902759;
							continue;
						case 33u:
							goto IL_0328;
						case 17u:
							_202D_202A_202A_200E_206E_202E_206C_202C_206F_202C_200C_202E_202A_206E_202B_202D_202C_206F_206C_206A_202A_200F_206A_200F_206D_200B_200C_202C_202B_206E_200E_206C_202D_200D_202E_202D_206D_206D_202B_202C_202E();
							_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E = default(List<KeyValuePair<ItemInstance, int>>.Enumerator);
							num2 = (int)(num3 * 1355270004) ^ -1978178899;
							continue;
						case 20u:
							obj = new _206E_200F_202A_202B_202C_202D_202C_202C_206F_200C_202C_202B_200C_200F_202B_200E_200E_202C_200E_206D_200C_200D_206A_206B_206F_206C_200C_206A_200B_200F_200B_206E_202A_202C_202A_206E_206E_206D_206B_202B_202E();
							num2 = ((int)num3 * -2132859040) ^ 0x79BCCB4;
							continue;
						case 14u:
							result = true;
							num2 = (int)(num3 * 1550716132) ^ -173506202;
							continue;
						case 1u:
							current = _206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E.Current;
							num2 = -308402394;
							continue;
						case 9u:
							_200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E = 0;
							num2 = ((int)num3 * -1370784681) ^ -935496774;
							continue;
						case 25u:
							_202E_202D_206F_202E_206B_202E_200D_200F_206E_206C_202D_202E_206A_206B_206A_206E_206D_206D_200B_206D_206A_206A_202B_206F_200B_206F_206B_202A_202E_206C_206C_202C_202C_206D_206D_200B_206C_200E_200B_202A_202E(_202E_206A_202D_206A_202C_206A_206D_200F_200E_206B_206F_206A_202E_202B_202B_202A_200B_206F_200E_200C_206F_206D_206B_200F_206C_206C_200C_206D_202B_202D_200B_200D_200C_202B_200C_206A_206B_202B_206D_202E((Component)(object)selectMenu), false);
							_202E_202D_206F_202E_206B_202E_200D_200F_206E_206C_202D_202E_206A_206B_206A_206E_206D_206D_200B_206D_206A_206A_202B_206F_200B_206F_206B_202A_202E_206C_206C_202C_202C_206D_206D_200B_206C_200E_200B_202A_202E(_202E_206A_202D_206A_202C_206A_206D_200F_200E_206B_206F_206A_202E_202B_202B_202A_200B_206F_200E_200C_206F_206D_206B_200F_206C_206C_200C_206D_202B_202D_200B_200D_200C_202B_200C_206A_206B_202B_206D_202E((Component)(object)selectMenu), true);
							num2 = ((int)num3 * -7953293) ^ 0x47092A3C;
							continue;
						case 4u:
							goto IL_0407;
						case 5u:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 2;
							result = true;
							goto end_IL_000f;
						case 30u:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 3;
							num2 = (int)(num3 * 1001883872) ^ -104319214;
							continue;
						case 23u:
							goto IL_0453;
						case 27u:
							result = false;
							num2 = (int)(num3 * 1049041987) ^ -1453920174;
							continue;
						case 26u:
							obj._202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E = itemMenu;
							obj.item = current.Key;
							num2 = (int)((num3 * 600698351) ^ 0x271B7A08);
							continue;
						case 21u:
							num2 = (int)(num3 * 1205791166) ^ -1022350281;
							continue;
						case 2u:
						{
							val = Object.Instantiate<GameObject>(itemMenu.ItemPrefab);
							num4 = current.Value;
							int num5;
							int num6;
							if (!itemMenu._206A_206B_206C_200B_200D_202E_200D_206A_202A_206C_200C_206D_200C_206C_200D_202B_206D_206A_206F_200E_206D_200F_206E_202A_200B_200D_200E_206F_206F_200F_202A_206A_202B_206A_206A_200E_206D_206D_200E_202E_202E)
							{
								num5 = 1344126105;
								num6 = num5;
							}
							else
							{
								num5 = 1196639092;
								num6 = num5;
							}
							num2 = num5 ^ (int)(num3 * 366271835);
							continue;
						}
						case 18u:
							goto end_IL_000f;
						}
						break;
						IL_0328:
						int num11;
						if (!_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E.MoveNext())
						{
							num2 = -417435155;
							num11 = num2;
						}
						else
						{
							num2 = -892850097;
							num11 = num2;
						}
						continue;
						IL_0172:
						val.GetComponent<ItemUI>().Bind(obj.item, num4, obj._200F_200B_206D_200C_206F_202D_206B_206E_206E_200E_200D_202D_202C_200E_202C_202C_206C_202C_206F_202B_202A_200D_200E_206F_200F_206C_202A_202D_200E_200C_202E_200C_200D_206C_200D_206E_206B_200E_202E, itemMenu._202E_206B_202A_206B_206D_206E_202D_206C_202B_200B_202D_200B_202C_200D_202A_200B_206C_202B_206C_202A_202B_206A_206B_206A_200C_200C_202C_200C_206E_202C_202A_206E_202D_200F_202A_202E_202C_200D_206A_202D_202E, itemMenu.ItemPreviewPanelObj);
						selectMenu.AddItem(val);
						int num12;
						if (!itemMenu._202E_200E_200E_206F_200D_200B_202A_206D_202B_206D_206D_200D_202A_202B_202E_206F_202D_202B_206A_200E_206E_206D_206B_206B_200F_202D_202C_200F_206C_202B_200B_202E_200C_206B_202A_200E_206C_206E_206B_202A_202E)
						{
							num2 = -1504549423;
							num12 = num2;
						}
						else
						{
							num2 = -684868811;
							num12 = num2;
						}
					}
					goto default;
					IL_0453:
					_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
					result = false;
					num2 = -2129338234;
					goto IL_0029;
					IL_0407:
					_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
					num2 = -226365432;
					goto IL_0029;
					IL_026f:
					_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
					num2 = -1504723413;
					goto IL_0029;
					IL_00ed:
					_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -3;
					_202E_202D_206F_202E_206B_202E_200D_200F_206E_206C_202D_202E_206A_206B_206A_206E_206D_206D_200B_206D_206A_206A_202B_206F_200B_206F_206B_202A_202E_206C_206C_202C_202C_206D_206D_200B_206C_200E_200B_202A_202E(_202E_206A_202D_206A_202C_206A_206D_200F_200E_206B_206F_206A_202E_202B_202B_202A_200B_206F_200E_200C_206F_206D_206B_200F_206C_206C_200C_206D_202B_202D_200B_200D_200C_202B_200C_206A_206B_202B_206D_202E((Component)(object)selectMenu), false);
					_202E_202D_206F_202E_206B_202E_200D_200F_206E_206C_202D_202E_206A_206B_206A_206E_206D_206D_200B_206D_206A_206A_202B_206F_200B_206F_206B_202A_202E_206C_206C_202C_202C_206D_206D_200B_206C_200E_200B_202A_202E(_202E_206A_202D_206A_202C_206A_206D_200F_200E_206B_206F_206A_202E_202B_202B_202A_200B_206F_200E_200C_206F_206D_206B_200F_206C_206C_200C_206D_202B_202D_200B_200D_200C_202B_200C_206A_206B_202B_206D_202E((Component)(object)selectMenu), true);
					num2 = -1504549423;
					goto IL_0029;
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
			while (true)
			{
				int num = -2013690253;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1099424803)) % 3)
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
					num = (int)(num2 * 1326705269) ^ -658998541;
				}
			}
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw _202E_202C_202B_200B_206C_206C_200C_200E_206C_200C_202B_200E_202E_206C_200D_206E_206C_202A_200B_200C_200C_206A_200E_200D_202C_200C_200C_202E_200F_206E_202E_202E_202A_206D_202D_206B_206D_200B_202D_200E_202E();
		}

		static GameObject _202E_206A_202D_206A_202C_206A_206D_200F_200E_206B_206F_206A_202E_202B_202B_202A_200B_206F_200E_200C_206F_206D_206B_200F_206C_206C_200C_206D_202B_202D_200B_200D_200C_202B_200C_206A_206B_202B_206D_202E(Component P_0)
		{
			return P_0.gameObject;
		}

		static void _202E_202D_206F_202E_206B_202E_200D_200F_206E_206C_202D_202E_206A_206B_206A_206E_206D_206D_200B_206D_206A_206A_202B_206F_200B_206F_206B_202A_202E_206C_206C_202C_202C_206D_206D_200B_206C_200E_200B_202A_202E(GameObject P_0, bool P_1)
		{
			P_0.SetActive(P_1);
		}

		static NotSupportedException _202E_202C_202B_200B_206C_206C_200C_200E_206C_200C_202B_200E_202E_206C_200D_206E_206C_202A_200B_200C_200C_206A_200E_200D_202C_200C_200C_202E_200F_206E_202E_202E_202A_206D_202D_206B_206D_200B_202D_200E_202E()
		{
			return new NotSupportedException();
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _200B_206E_202E_206D_202C_206E_200E_206B_202D_206A_202A_200E_200E_206B_200D_200C_206E_202D_206C_200C_200D_202E_206C_202D_206B_206C_206C_202C_202D_206B_200F_202C_202B_200F_202E_206A_202E_200E_200B_206E_202E
	{
		public static readonly _200B_206E_202E_206D_202C_206E_200E_206B_202D_206A_202A_200E_200E_206B_200D_200C_206E_202D_206C_200C_200D_202E_206C_202D_206B_206C_206C_202C_202D_206B_200F_202C_202B_200F_202E_206A_202E_200E_200B_206E_202E _003C_003E9 = new _200B_206E_202E_206D_202C_206E_200E_206B_202D_206A_202A_200E_200E_206B_200D_200C_206E_202D_206C_200C_200D_202E_206C_202D_206B_206C_206C_202C_202D_206B_200F_202C_202B_200F_202E_206A_202E_200E_200B_206E_202E();

		public static Comparison<KeyValuePair<ItemInstance, int>> _003C_003E9__0_0;

		internal int _202C_200C_206E_206C_200E_206A_202D_202E_206D_206F_206A_206C_202B_206B_206A_202C_206A_202C_200D_202E_200B_200E_200C_200E_202D_206B_200B_202A_202C_202D_200F_202E_200F_206D_200D_206E_200D_206F_206A_202B_202E(KeyValuePair<ItemInstance, int> P_0, KeyValuePair<ItemInstance, int> P_1)
		{
			return _202B_200F_206A_202B_200D_200D_200C_206C_200B_200D_202C_206E_200F_206A_206E_200C_202E_200D_200D_206E_206D_200F_202E_206C_202E_200F_206A_202A_202A_206F_200B_206C_202C_200B_200E_206C_202C_202A_206D_202D_202E(P_0.Key.PK, P_1.Key.PK);
		}

		static int _202B_200F_206A_202B_200D_200D_200C_206C_200B_200D_202C_206E_200F_206A_206E_200C_202E_200D_200D_206E_206D_200F_202E_206C_202E_200F_206A_202A_202A_206F_200B_206C_202C_200B_200E_206C_202C_202A_206D_202D_202E(string P_0, string P_1)
		{
			return P_0.CompareTo(P_1);
		}
	}

	[CompilerGenerated]
	private sealed class _206A_200E_206E_206E_202B_200D_200C_202B_200B_206E_202B_202A_202A_200D_206E_200F_206F_206D_202B_206B_202E_200C_202C_200F_200D_200E_200B_206A_202B_206F_200B_206D_206D_206C_202A_200F_200D_200E_200D_206A_202E
	{
		public GameObject btnObj;

		public ItemMenu _202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E;

		internal void _206D_202A_206B_200B_202D_202E_202E_206C_200E_206E_206C_202E_200C_200E_200B_200B_202A_200E_202D_202B_200F_200D_202A_202B_200E_206B_202D_202E_206F_200E_206A_202E_200B_202A_202D_206A_200F_206C_206F_206B_202E()
		{
			_202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E.OnClicked(btnObj);
		}
	}

	public GameObject ItemPrefab;

	public GameObject SelectMenuObj;

	public GameObject ItemPreviewPanelObj;

	private ItemFilter _200E_200C_202B_206A_202E_206E_206A_206F_200D_200E_200D_202A_206F_202A_206C_202E_200D_202A_202B_206B_202A_200E_200E_202E_202C_202A_206A_202B_206D_202E_206E_206E_200F_200B_206C_206E_200F_202C_206E_200F_202E;

	private string _202E_206B_206D_202B_206F_200E_200B_200D_206D_200B_202C_200B_200D_206A_200B_202E_202D_206D_202B_206F_200F_206F_206B_200D_202B_202E_206F_206D_202C_206A_206C_200D_200F_202E_200B_200E_200D_202B_206D_202E_202E;

	private Dictionary<ItemInstance, int> _206A_202C_200F_206D_202B_202E_206F_202D_200D_206F_202B_206A_202B_206B_202A_206C_200D_206B_202D_200B_206E_202A_200C_202D_202C_206C_202D_202B_202E_200B_206D_206E_206A_206E_206E_200D_206C_206C_206E_200D_202E;

	private CommonSettings.ObjectCallBack _206B_200B_200F_200D_206E_206C_206D_206D_206C_200C_206B_200B_206E_202A_206C_202D_202D_206C_206A_202B_206D_202D_200E_200F_202A_206E_200F_206F_200F_202C_202D_206E_202A_206D_206C_200C_206F_206A_202C_206C_202E;

	private CommonSettings.VoidCallBack _206E_200E_202A_200C_202E_206A_206D_200D_206A_202D_202E_200C_206C_200D_200C_206F_200C_200E_206C_202B_202D_202B_206E_206D_206E_202B_206C_200B_206A_206D_202C_200E_200D_206C_200B_206C_200F_202E_200F_206D_202E;

	private CommonSettings.JudgeCallback _202E_206B_202A_206B_206D_206E_202D_206C_202B_200B_202D_200B_202C_200D_202A_200B_206C_202B_206C_202A_202B_206A_206B_206A_200C_200C_202C_200C_206E_202C_202A_206E_202D_200F_202A_202E_202C_200D_206A_202D_202E;

	[CompilerGenerated]
	private static Comparison<KeyValuePair<ItemInstance, int>> _200B_206E_206E_202A_202C_200C_206F_206A_206A_200B_206D_200B_200D_206F_200D_200B_206F_206F_200E_200B_200B_200C_202A_200B_200B_206F_200C_202E_200F_202A_200C_200C_200E_206F_206B_206D_202B_206A_202A_200F_202E;

	private Text _206A_206D_206E_206D_206A_200E_202E_200E_200F_206C_202A_200E_206F_200E_202B_200D_202D_206C_206C_206C_202B_200E_200B_202C_200F_206D_206F_202B_200F_200E_200F_206C_200F_202E_200E_200E_200D_206E_206A_200E_202E;

	private Text _202C_206B_206D_206C_206F_206F_202B_202C_202E_200E_206D_202A_206A_200E_202A_200C_200C_200E_202D_202E_206F_200E_202C_202E_202D_206E_202A_202B_200F_200C_206A_200E_206B_200D_206C_200C_200F_206F_206F_202E;

	private Text _202D_200F_200B_200B_202C_202C_206C_202C_206F_206C_206A_206D_202C_202B_206B_200F_202A_202D_202D_206A_206D_206D_202B_200D_206F_202D_202E_200E_202E_206F_202B_202C_200F_206D_202E_206F_206A_200B_206F_206A_202E;

	private Text _200F_202A_200D_202E_202C_200D_200D_200C_200B_206D_200B_206B_202B_200B_200F_206F_202E_206C_206C_206E_206D_200F_200D_202A_200E_206E_200E_202C_202D_200D_200F_202A_200F_206D_200B_200D_206A_206E_200E_206F_202E;

	private Text _200B_206C_200B_206F_200E_200D_202E_200B_200C_202A_200D_202A_206B_206C_206E_206D_200E_206D_200D_206E_202E_206F_200B_206C_200B_202D_206D_200C_200C_202E_200D_206C_206F_202D_206D_200B_202A_200F_200B_202A_202E;

	private Text _202D_200E_202C_202E_206D_202E_202D_200B_206B_206A_206A_202A_206F_206E_206A_202B_202A_206C_206D_202B_206E_206D_206C_206D_206C_202C_206F_202A_206B_202C_202B_200D_200D_206B_206B_202E_200E_200B_202E_200D_202E;

	private bool _206A_206B_206C_200B_200D_202E_200D_206A_202A_206C_200C_206D_200C_206C_200D_202B_206D_206A_206F_200E_206D_200F_206E_202A_200B_200D_200E_206F_206F_200F_202A_206A_202B_206A_206A_200E_206D_206D_200E_202E_202E;

	private bool _202E_200E_200E_206F_200D_200B_202A_206D_202B_206D_206D_200D_202A_202B_202E_206F_202D_202B_206A_200E_206E_206D_206B_206B_200F_202D_202C_200F_206C_202B_200B_202E_200C_206B_202A_200E_206C_206E_206B_202A_202E;

	private SelectMenu selectMenu => SelectMenuObj.GetComponent<SelectMenu>();

	public void OnButtonAll()
	{
		SetFilter(ItemFilter.All);
	}

	public void OnButtonZhuangbei()
	{
		SetFilter(ItemFilter.Zhuangbei);
	}

	public void OnButtonMiji()
	{
		SetFilter(ItemFilter.Miji);
	}

	public void OnButtonCosta()
	{
		SetFilter(ItemFilter.Costa);
	}

	public void OnButtonSpecial()
	{
		SetFilter(ItemFilter.Special);
	}

	public void SetFilter(ItemFilter filter)
	{
		if (CommonSettings.UpdatingShopUI)
		{
			goto IL_0007;
		}
		goto IL_004d;
		IL_0007:
		int num = 519214173;
		goto IL_000c;
		IL_000c:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x2E87042B)) % 5)
			{
			case 3u:
				break;
			default:
				return;
			case 4u:
				_200E_200C_202B_206A_202E_206E_206A_206F_200D_200E_200D_202A_206F_202A_206C_202E_200D_202A_202B_206B_202A_200E_200E_202E_202C_202A_206A_202B_206D_202E_206E_206E_200F_200B_206C_206E_200F_202C_206E_200F_202E = filter;
				Refresh();
				num = ((int)num2 * -1909462136) ^ -1627053629;
				continue;
			case 1u:
				goto IL_004d;
			case 2u:
				return;
			case 0u:
				return;
			}
			break;
		}
		goto IL_0007;
		IL_004d:
		CommonSettings.UpdatingShopUI = true;
		_202E_206E_202D_202D_206E_200D_206D_200F_202A_206A_202E_206A_206A_206A_202A_206B_200C_200E_206D_206C_200B_206C_206A_206E_206B_200E_202A_206B_200E_200B_200F_200C_200B_206D_202E_206B_206E_206F_200F_202B_202E((MonoBehaviour)(object)this);
		num = 1729977584;
		goto IL_000c;
	}

	private void Refresh()
	{
		initObj();
		SelectMenu selectMenu = default(SelectMenu);
		List<KeyValuePair<ItemInstance, int>> list = default(List<KeyValuePair<ItemInstance, int>>);
		ItemType type = default(ItemType);
		KeyValuePair<ItemInstance, int> current = default(KeyValuePair<ItemInstance, int>);
		while (true)
		{
			int num = 1822993448;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5C1CF00D)) % 5)
				{
				case 4u:
					break;
				case 2u:
					_200D_206B_200D_200E_206E_200C_202A_200D_206E_200D_202A_206A_200F_206A_200C_206C_202A_206D_200F_206A_202B_202C_200F_200F_200F_200C_206D_200D_206F_206A_200F_202A_200D_202D_200F_202D_206F_202C_202A_202E(ItemPreviewPanelObj, false);
					selectMenu = this.selectMenu;
					num = ((int)num2 * -1989155483) ^ 0x24F43A07;
					continue;
				case 3u:
					selectMenu.Clear();
					num = (int)(num2 * 2055205328) ^ -987222709;
					continue;
				case 1u:
					list = new List<KeyValuePair<ItemInstance, int>>();
					num = ((int)num2 * -647776569) ^ -726518512;
					continue;
				default:
				{
					using (Dictionary<ItemInstance, int>.Enumerator enumerator = _206A_202C_200F_206D_202B_202E_206F_202D_200D_206F_202B_206A_202B_206B_202A_206C_200D_206B_202D_200B_206E_202A_200C_202D_202C_206C_202D_202B_202E_200B_206D_206E_206A_206E_206E_200D_206C_206C_206E_200D_202E.GetEnumerator())
					{
						while (true)
						{
							IL_01dc:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 383135774;
								num4 = num3;
							}
							else
							{
								num3 = 832909565;
								num4 = num3;
							}
							while (true)
							{
								switch ((num2 = (uint)(num3 ^ 0x5C1CF00D)) % 26)
								{
								case 0u:
									num3 = 383135774;
									continue;
								default:
									goto end_IL_0096;
								case 19u:
								{
									int num8;
									int num9;
									if (type != ItemType.Upgrade)
									{
										num8 = -930154048;
										num9 = num8;
									}
									else
									{
										num8 = -717263061;
										num9 = num8;
									}
									num3 = num8 ^ (int)(num2 * 791350549);
									continue;
								}
								case 10u:
								{
									int num37;
									int num38;
									if (type != ItemType.Accessories)
									{
										num37 = -419680482;
										num38 = num37;
									}
									else
									{
										num37 = -268169325;
										num38 = num37;
									}
									num3 = num37 ^ ((int)num2 * -1711304743);
									continue;
								}
								case 24u:
								{
									int num11;
									int num12;
									if (type == ItemType.Mission)
									{
										num11 = -1070368550;
										num12 = num11;
									}
									else
									{
										num11 = -386523067;
										num12 = num11;
									}
									num3 = num11 ^ ((int)num2 * -4924969);
									continue;
								}
								case 18u:
								{
									int num39;
									int num40;
									if (type == ItemType.TalentBook)
									{
										num39 = 248761613;
										num40 = num39;
									}
									else
									{
										num39 = 1387788789;
										num40 = num39;
									}
									num3 = num39 ^ (int)(num2 * 1671213221);
									continue;
								}
								case 8u:
								{
									int num27;
									if (_200E_200C_202B_206A_202E_206E_206A_206F_200D_200E_200D_202A_206F_202A_206C_202E_200D_202A_202B_206B_202A_200E_200E_202E_202C_202A_206A_202B_206D_202E_206E_206E_200F_200B_206C_206E_200F_202C_206E_200F_202E != ItemFilter.Zhuangbei)
									{
										num3 = 733585293;
										num27 = num3;
									}
									else
									{
										num3 = 1193066320;
										num27 = num3;
									}
									continue;
								}
								case 23u:
								{
									int num19;
									int num20;
									if (type != ItemType.HiddenWeapon)
									{
										num19 = -2082769457;
										num20 = num19;
									}
									else
									{
										num19 = -1638185832;
										num20 = num19;
									}
									num3 = num19 ^ ((int)num2 * -644849260);
									continue;
								}
								case 4u:
									break;
								case 25u:
								{
									int num28;
									int num29;
									if (type != ItemType.Weapon)
									{
										num28 = -1770022328;
										num29 = num28;
									}
									else
									{
										num28 = -110234162;
										num29 = num28;
									}
									num3 = num28 ^ ((int)num2 * -522246625);
									continue;
								}
								case 13u:
									list.Add(current);
									num3 = 1101537027;
									continue;
								case 7u:
								{
									int num34;
									if (_200E_200C_202B_206A_202E_206E_206A_206F_200D_200E_200D_202A_206F_202A_206C_202E_200D_202A_202B_206B_202A_200E_200E_202E_202C_202A_206A_202B_206D_202E_206E_206E_200F_200B_206C_206E_200F_202C_206E_200F_202E != ItemFilter.Miji)
									{
										num3 = 2042562451;
										num34 = num3;
									}
									else
									{
										num3 = 1076845267;
										num34 = num3;
									}
									continue;
								}
								case 21u:
								{
									int num17;
									int num18;
									if (type == ItemType.Book2)
									{
										num17 = -1420174317;
										num18 = num17;
									}
									else
									{
										num17 = -1052222307;
										num18 = num17;
									}
									num3 = num17 ^ ((int)num2 * -2034812266);
									continue;
								}
								case 2u:
								{
									int num13;
									int num14;
									if (type != ItemType.Costa)
									{
										num13 = -1127396132;
										num14 = num13;
									}
									else
									{
										num13 = -936424526;
										num14 = num13;
									}
									num3 = num13 ^ ((int)num2 * -740308429);
									continue;
								}
								case 14u:
								{
									int num32;
									int num33;
									if (type == ItemType.SwitchGameScene2)
									{
										num32 = 1020241843;
										num33 = num32;
									}
									else
									{
										num32 = 81313571;
										num33 = num32;
									}
									num3 = num32 ^ ((int)num2 * -1132869712);
									continue;
								}
								case 16u:
								{
									int num25;
									int num26;
									if (type == ItemType.Canzhang)
									{
										num25 = 439512426;
										num26 = num25;
									}
									else
									{
										num25 = 1325450130;
										num26 = num25;
									}
									num3 = num25 ^ ((int)num2 * -603061604);
									continue;
								}
								case 1u:
								{
									int num21;
									int num22;
									if (type == ItemType.SwitchGameScene)
									{
										num21 = 1942489813;
										num22 = num21;
									}
									else
									{
										num21 = 1763778476;
										num22 = num21;
									}
									num3 = num21 ^ (int)(num2 * 1237508577);
									continue;
								}
								case 20u:
								{
									int num6;
									int num7;
									if (type == ItemType.Armor)
									{
										num6 = -1176396793;
										num7 = num6;
									}
									else
									{
										num6 = -1535053879;
										num7 = num6;
									}
									num3 = num6 ^ (int)(num2 * 1785102487);
									continue;
								}
								case 22u:
								{
									int num35;
									int num36;
									if (type != ItemType.Book)
									{
										num35 = -677956878;
										num36 = num35;
									}
									else
									{
										num35 = -1891334463;
										num36 = num35;
									}
									num3 = num35 ^ ((int)num2 * -672223385);
									continue;
								}
								case 17u:
								{
									int num30;
									int num31;
									if (type == ItemType.Special)
									{
										num30 = -1343296606;
										num31 = num30;
									}
									else
									{
										num30 = -50065512;
										num31 = num30;
									}
									num3 = num30 ^ ((int)num2 * -707248136);
									continue;
								}
								case 15u:
								{
									int num23;
									int num24;
									if (type != ItemType.SpeicalSkillBook)
									{
										num23 = -13421651;
										num24 = num23;
									}
									else
									{
										num23 = -1866445835;
										num24 = num23;
									}
									num3 = num23 ^ (int)(num2 * 2083756734);
									continue;
								}
								case 11u:
								{
									int num15;
									int num16;
									if (_200E_200C_202B_206A_202E_206E_206A_206F_200D_200E_200D_202A_206F_202A_206C_202E_200D_202A_202B_206B_202A_200E_200E_202E_202C_202A_206A_202B_206D_202E_206E_206E_200F_200B_206C_206E_200F_202C_206E_200F_202E == ItemFilter.Costa)
									{
										num15 = -940660477;
										num16 = num15;
									}
									else
									{
										num15 = -1525669928;
										num16 = num15;
									}
									num3 = num15 ^ ((int)num2 * -886581532);
									continue;
								}
								case 5u:
									type = current.Key.Type;
									num3 = ((int)num2 * -1514813686) ^ -1802612308;
									continue;
								case 12u:
								{
									int num10;
									if (_200E_200C_202B_206A_202E_206E_206A_206F_200D_200E_200D_202A_206F_202A_206C_202E_200D_202A_202B_206B_202A_200E_200E_202E_202C_202A_206A_202B_206D_202E_206E_206E_200F_200B_206C_206E_200F_202C_206E_200F_202E == ItemFilter.Special)
									{
										num3 = 699653064;
										num10 = num3;
									}
									else
									{
										num3 = 1530989178;
										num10 = num3;
									}
									continue;
								}
								case 3u:
								{
									int num5;
									if (_200E_200C_202B_206A_202E_206E_206A_206F_200D_200E_200D_202A_206F_202A_206C_202E_200D_202A_202B_206B_202A_200E_200E_202E_202C_202A_206A_202B_206D_202E_206E_206E_200F_200B_206C_206E_200F_202C_206E_200F_202E != ItemFilter.Mission)
									{
										num3 = 1768769436;
										num5 = num3;
									}
									else
									{
										num3 = 788119079;
										num5 = num3;
									}
									continue;
								}
								case 9u:
									current = enumerator.Current;
									num3 = 233176324;
									continue;
								case 6u:
									goto end_IL_0096;
								}
								goto IL_01dc;
								continue;
								end_IL_0096:
								break;
							}
							break;
						}
					}
					list.Sort((KeyValuePair<ItemInstance, int> P_0, KeyValuePair<ItemInstance, int> P_1) => _200B_206E_202E_206D_202C_206E_200E_206B_202D_206A_202A_200E_200E_206B_200D_200C_206E_202D_206C_200C_200D_202E_206C_202D_206B_206C_206C_202C_202D_206B_200F_202C_202B_200F_202E_206A_202E_200E_200B_206E_202E._202B_200F_206A_202B_200D_200D_200C_206C_200B_200D_202C_206E_200F_206A_206E_200C_202E_200D_200D_206E_206D_200F_202E_206C_202E_200F_206A_202A_202A_206F_200B_206C_202C_200B_200E_206C_202C_202A_206D_202D_202E(P_0.Key.PK, P_1.Key.PK));
					_202E_202E_200D_200F_206E_202E_202D_202C_202B_206C_202A_206D_200C_206D_200D_202E_206C_202C_200B_200C_206F_202A_206E_200C_206B_200D_202E_202D_206A_202B_206A_200B_200E_206F_206A_206C_200D_202E_202E((MonoBehaviour)(object)this, AddSelectMenuAll(list, selectMenu));
					return;
				}
				}
				break;
			}
		}
	}

	public void Show(string title, List<ItemInstance> items, CommonSettings.ObjectCallBack callback, CommonSettings.VoidCallBack cancelCallback, CommonSettings.JudgeCallback isItemActiveCallback)
	{
		Dictionary<ItemInstance, int> dictionary = new Dictionary<ItemInstance, int>();
		using (List<ItemInstance>.Enumerator enumerator = items.GetEnumerator())
		{
			ItemInstance current = default(ItemInstance);
			while (true)
			{
				IL_00b1:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 1996256018;
					num2 = num;
				}
				else
				{
					num = 1690432502;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x1C5B8B7D)) % 7)
					{
					case 0u:
						num = 1996256018;
						continue;
					default:
						goto end_IL_0017;
					case 3u:
					{
						current = enumerator.Current;
						int num4;
						if (!dictionary.ContainsKey(current))
						{
							num = 1089638470;
							num4 = num;
						}
						else
						{
							num = 1024549259;
							num4 = num;
						}
						continue;
					}
					case 5u:
						dictionary[current]++;
						num = ((int)num3 * -475786243) ^ 0x48ADA27B;
						continue;
					case 2u:
						dictionary.Add(current, 1);
						num = 774347790;
						continue;
					case 6u:
						num = (int)((num3 * 2059177811) ^ 0x4C1E75C6);
						continue;
					case 1u:
						break;
					case 4u:
						goto end_IL_0017;
					}
					goto IL_00b1;
					continue;
					end_IL_0017:
					break;
				}
				break;
			}
		}
		ShowLoader(title, dictionary, callback, cancelCallback, isItemActiveCallback, _202E_200E_200E_206F_200D_200B_202A_206D_202B_206D_206D_200D_202A_202B_202E_206F_202D_202B_206A_200E_206E_206D_206B_206B_200F_202D_202C_200F_206C_202B_200B_202E_200C_206B_202A_200E_206C_206E_206B_202A_202E, realCount: true);
	}

	public void Show(string title, Dictionary<ItemInstance, int> items, CommonSettings.ObjectCallBack callback, CommonSettings.VoidCallBack cancelCallback, CommonSettings.JudgeCallback isItemActiveCallback)
	{
		_202E_206B_206D_202B_206F_200E_200B_200D_206D_200B_202C_200B_200D_206A_200B_202E_202D_206D_202B_206F_200F_206F_206B_200D_202B_202E_206F_206D_202C_206A_206C_200D_200F_202E_200B_200E_200D_202B_206D_202E_202E = title;
		_206E_200E_202A_200C_202E_206A_206D_200D_206A_202D_202E_200C_206C_200D_200C_206F_200C_200E_206C_202B_202D_202B_206E_206D_206E_202B_206C_200B_206A_206D_202C_200E_200D_206C_200B_206C_200F_202E_200F_206D_202E = cancelCallback;
		bool flag = default(bool);
		while (true)
		{
			int num = 2021496755;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3DA026B9)) % 21)
				{
				case 2u:
					break;
				default:
					return;
				case 5u:
					RuntimeData.Instance.isItemsPanelRefreshed = 1;
					num = ((int)num2 * -1136281084) ^ -1656916179;
					continue;
				case 9u:
				{
					int num11;
					int num12;
					if (!_202B_202C_206C_202E_202A_200D_202B_206B_200F_200D_206B_200F_206B_202C_206F_206C_202C_202B_202B_202D_200C_202E_206C_200C_200C_200E_202C_206E_202D_200F_206B_206C_206E_202C_202D_202A_206F_200B_200F_200C_202E(title, ResourceStrings.ResStrings[76]))
					{
						num11 = 817565240;
						num12 = num11;
					}
					else
					{
						num11 = 999494954;
						num12 = num11;
					}
					num = num11 ^ ((int)num2 * -817333608);
					continue;
				}
				case 12u:
					_200D_206B_200D_200E_206E_200C_202A_200D_206E_200D_202A_206A_200F_206A_200C_206C_202A_206D_200F_206A_202B_202C_200F_200F_200F_200C_206D_200D_206F_206A_200F_202A_200D_202D_200F_202D_206F_202C_202A_202E(_202D_202A_206C_206F_200B_202B_206A_202D_200D_200C_200E_202A_200C_202B_206B_206B_200D_202A_202B_206D_200B_206E_206C_206A_206E_200D_202C_202B_206A_202D_206F_200E_202C_206A_202D_200F_200D_206D_206C_206E_202E((Component)(object)this), true);
					num = 353676256;
					continue;
				case 0u:
					CommonSettings.UpdatingShopUI = false;
					num = ((int)num2 * -1167915638) ^ 0x73E54230;
					continue;
				case 8u:
				{
					int num13;
					if (flag)
					{
						num = 129392057;
						num13 = num;
					}
					else
					{
						num = 2111370396;
						num13 = num;
					}
					continue;
				}
				case 6u:
				{
					int num5;
					int num6;
					if (_200E_200C_202B_206A_202E_206E_206A_206F_200D_200E_200D_202A_206F_202A_206C_202E_200D_202A_202B_206B_202A_200E_200E_202E_202C_202A_206A_202B_206D_202E_206E_206E_200F_200B_206C_206E_200F_202C_206E_200F_202E > ItemFilter.Mission)
					{
						num5 = -1921983062;
						num6 = num5;
					}
					else
					{
						num5 = -555223559;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 211130345);
					continue;
				}
				case 19u:
				{
					int num7;
					int num8;
					if (_200E_200C_202B_206A_202E_206E_206A_206F_200D_200E_200D_202A_206F_202A_206C_202E_200D_202A_202B_206B_202A_200E_200E_202E_202C_202A_206A_202B_206D_202E_206E_206E_200F_200B_206C_206E_200F_202C_206E_200F_202E >= ItemFilter.All)
					{
						num7 = -1095860339;
						num8 = num7;
					}
					else
					{
						num7 = -130514634;
						num8 = num7;
					}
					num = num7 ^ ((int)num2 * -398824751);
					continue;
				}
				case 16u:
				{
					int num14;
					int num15;
					if (_200C_206E_202B_200C_200C_206A_202D_200D_202A_206F_206B_200B_206D_206D_200E_202B_206A_206A_200C_200D_202D_202E_202A_206C_202D_200D_202B_206E_206A_206D_206E_202D_200B_202E_200D_206D_200B_202C_206A_202C_202E(selectMenu.selectContent) != 0)
					{
						num14 = -372961075;
						num15 = num14;
					}
					else
					{
						num14 = -2056754185;
						num15 = num14;
					}
					num = num14 ^ (int)(num2 * 497358352);
					continue;
				}
				case 17u:
					_202E_200E_200E_206F_200D_200B_202A_206D_202B_206D_206D_200D_202A_202B_202E_206F_202D_202B_206A_200E_206E_206D_206B_206B_200F_202D_202C_200F_206C_202B_200B_202E_200C_206B_202A_200E_206C_206E_206B_202A_202E = true;
					num = 2089634557;
					continue;
				case 14u:
					flag = true;
					num = ((int)num2 * -80205225) ^ 0x7578E284;
					continue;
				case 20u:
					_206A_202C_200F_206D_202B_202E_206F_202D_200D_206F_202B_206A_202B_206B_202A_206C_200D_206B_202D_200B_206E_202A_200C_202D_202C_206C_202D_202B_202E_200B_206D_206E_206A_206E_206E_200D_206C_206C_206E_200D_202E = items;
					Refresh();
					num = 1639547893;
					continue;
				case 4u:
				{
					int num9;
					int num10;
					if (CommonSettings.UpdatingShopUI)
					{
						num9 = -844915291;
						num10 = num9;
					}
					else
					{
						num9 = -1441032364;
						num10 = num9;
					}
					num = num9 ^ ((int)num2 * -1816210291);
					continue;
				}
				case 15u:
					_200E_200C_202B_206A_202E_206E_206A_206F_200D_200E_200D_202A_206F_202A_206C_202E_200D_202A_202B_206B_202A_200E_200E_202E_202C_202A_206A_202B_206D_202E_206E_206E_200F_200B_206C_206E_200F_202C_206E_200F_202E = ItemFilter.All;
					num = 900810170;
					continue;
				case 1u:
					RuntimeData.Instance.isItemsPanelRefreshed = 0;
					num = (int)(num2 * 671068922) ^ -1797617908;
					continue;
				case 13u:
					flag = false;
					num = (int)((num2 * 2049117255) ^ 0x429E4FBD);
					continue;
				case 18u:
					_206B_200B_200F_200D_206E_206C_206D_206D_206C_200C_206B_200B_206E_202A_206C_202D_202D_206C_206A_202B_206D_202D_200E_200F_202A_206E_200F_206F_200F_202C_202D_206E_202A_206D_206C_200C_206F_206A_202C_206C_202E = callback;
					_202E_206B_202A_206B_206D_206E_202D_206C_202B_200B_202D_200B_202C_200D_202A_200B_206C_202B_206C_202A_202B_206A_206B_206A_200C_200C_202C_200C_206E_202C_202A_206E_202D_200F_202A_202E_202C_200D_206A_202D_202E = isItemActiveCallback;
					num = ((int)num2 * -1645205190) ^ 0x42B84AB6;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (RuntimeData.Instance.isItemsPanelRefreshed != 0)
					{
						num3 = 2054959619;
						num4 = num3;
					}
					else
					{
						num3 = 399744269;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1938044534);
					continue;
				}
				case 7u:
					num = ((int)num2 * -202256634) ^ 0xE75D932;
					continue;
				case 11u:
					Refresh2();
					num = 1639547893;
					continue;
				case 10u:
					return;
				}
				break;
			}
		}
	}

	public void Hide()
	{
		_202E_200E_200E_206F_200D_200B_202A_206D_202B_206D_206D_200D_202A_202B_202E_206F_202D_202B_206A_200E_206E_206D_206B_206B_200F_202D_202C_200F_206C_202B_200B_202E_200C_206B_202A_200E_206C_206E_206B_202A_202E = true;
		while (true)
		{
			int num = 1750237968;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x271496F)) % 3)
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
				_200D_206B_200D_200E_206E_200C_202A_200D_206E_200D_202A_206A_200F_206A_200C_206C_202A_206D_200F_206A_202B_202C_200F_200F_200F_200C_206D_200D_206F_206A_200F_202A_200D_202D_200F_202D_206F_202C_202A_202E(_202D_202A_206C_206F_200B_202B_206A_202D_200D_200C_200E_202A_200C_202B_206B_206B_200D_202A_202B_206D_200B_206E_206C_206A_206E_200D_202C_202B_206A_202D_206F_200E_202C_206A_202D_200F_200D_206D_206C_206E_202E((Component)(object)this), false);
				num = (int)(num2 * 1026235220) ^ -1922662382;
			}
		}
	}

	public void CancelButtonClicked()
	{
		if (_206E_200E_202A_200C_202E_206A_206D_200D_206A_202D_202E_200C_206C_200D_200C_206F_200C_200E_206C_202B_202D_202B_206E_206D_206E_202B_206C_200B_206A_206D_202C_200E_200D_206C_200B_206C_200F_202E_200F_206D_202E == null)
		{
			return;
		}
		while (true)
		{
			int num = 415110882;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x507B642D)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_002a;
				case 1u:
					return;
				}
				break;
				IL_002a:
				_206E_200E_202A_200C_202E_206A_206D_200D_206A_202D_202E_200C_206C_200D_200C_206F_200C_200E_206C_202B_202D_202B_206E_206D_206E_202B_206C_200B_206A_206D_202C_200E_200D_206C_200B_206C_200F_202E_200F_206D_202E();
				num = ((int)num2 * -1739333928) ^ -1619278575;
			}
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
		if (!_206F_206F_202B_206A_200E_202B_206D_202D_206E_202A_202C_202B_202B_200B_202B_200F_202B_206E_202B_206E_206A_206F_202D_206F_202E_200D_200F_200E_206C_206A_206D_202E_206F_206F_206F_202B_200B_206E_206C_206D_202E((KeyCode)27))
		{
			goto IL_000c;
		}
		goto IL_00c1;
		IL_000c:
		int num = 113672943;
		goto IL_0011;
		IL_0011:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0xDACFA)) % 8)
			{
			case 2u:
				break;
			default:
				return;
			case 1u:
				CancelButtonClicked();
				num = ((int)num2 * -1788116570) ^ 0xFEC2D3A;
				continue;
			case 7u:
			{
				int num5;
				int num6;
				if (!_202D_206F_202D_206F_200E_202A_200C_200F_200F_202D_202B_200B_206B_202C_200C_200E_206C_202A_202E_206D_200B_206B_206A_202D_206A_206A_202A_200F_206F_202E_200C_200C_202E_206D_200F_200B_200D_206C_200B_202B_202E((Object)(object)RuntimeData.Instance.mapUI, (Object)null))
				{
					num5 = 80895498;
					num6 = num5;
				}
				else
				{
					num5 = 266411295;
					num6 = num5;
				}
				num = num5 ^ (int)(num2 * 1418844250);
				continue;
			}
			case 4u:
				Hide();
				num = ((int)num2 * -1635384807) ^ 0x77E6FDC7;
				continue;
			case 5u:
			{
				int num7;
				int num8;
				if (_206B_202B_200D_206D_202D_206F_206C_200E_202C_202A_206E_202E_202A_202A_202E_200C_202A_200B_200D_202B_202D_206F_200C_206D_206B_200E_206C_200F_206D_202B_206A_202A_206B_202D_206C_206D_202B_206E_206E_200C_202E(1))
				{
					num7 = 1959736223;
					num8 = num7;
				}
				else
				{
					num7 = 1614915689;
					num8 = num7;
				}
				num = num7 ^ (int)(num2 * 1440153537);
				continue;
			}
			case 0u:
				goto IL_00c1;
			case 3u:
			{
				int num3;
				int num4;
				if (_206E_200C_202D_200F_206D_202E_206F_200B_206C_202A_202D_206D_206F_206C_202B_206F_202D_202B_200B_206D_202E_206E_200F_202E_206E_202D_206C_206F_206A_202E_200F_202B_200C_206E_202B_206C_206F_202E_202C_202C_202E(RuntimeData.Instance.mapUI.RoleStatePanelObj))
				{
					num3 = 1469794358;
					num4 = num3;
				}
				else
				{
					num3 = 176339516;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -458716288);
				continue;
			}
			case 6u:
				return;
			}
			break;
		}
		goto IL_000c;
		IL_00c1:
		int num9;
		if (_206E_200C_202D_200F_206D_202E_206F_200B_206C_202A_202D_206D_206F_206C_202B_206F_202D_202B_200B_206D_202E_206E_200F_202E_206E_202D_206C_206F_206A_202E_200F_202B_200C_206E_202B_206C_206F_202E_202C_202C_202E(_202D_202A_206C_206F_200B_202B_206A_202D_200D_200C_200E_202A_200C_202B_206B_206B_200D_202A_202B_206D_200B_206E_206C_206A_206E_200D_202C_202B_206A_202D_206F_200E_202C_206A_202D_200F_200D_206D_206C_206E_202E((Component)(object)this)))
		{
			num = 1041267293;
			num9 = num;
		}
		else
		{
			num = 1625489596;
			num9 = num;
		}
		goto IL_0011;
	}

	[CompilerGenerated]
	private static int _206F_206D_202E_206D_206A_202C_202D_200E_206C_206A_200B_202E_200C_206E_202E_202E_202E_206A_202D_202E_202C_200E_206D_206F_202E_200B_206B_202E_202D_200E_206C_206A_200F_200F_200B_206C_206C_202E_202E_206F_202E(KeyValuePair<ItemInstance, int> P_0, KeyValuePair<ItemInstance, int> P_1)
	{
		return _202E_202A_202D_200C_206F_206F_202B_200F_202D_206F_206B_200D_200C_206C_206B_206D_206E_206C_206F_206D_202D_200D_200E_206C_202D_202B_202E_200F_200E_206C_206C_200E_200D_202D_206B_202D_202C_206F_202C_206E_202E(P_0.Key.PK, P_1.Key.PK);
	}

	[CompilerGenerated]
	private void _202D_202E_206A_206C_206D_200E_206D_206E_200C_200C_202B_200C_206A_200E_202E_200C_206A_200B_200D_202E_200B_202C_200D_200B_206F_206D_202A_202D_200E_202A_200E_206F_200C_202A_200D_200C_206B_206B_206A_200E_202E()
	{
		Hide();
		CancelButtonClicked();
	}

	private void Refresh2()
	{
		_200D_206B_200D_200E_206E_200C_202A_200D_206E_200D_202A_206A_200F_206A_200C_206C_202A_206D_200F_206A_202B_202C_200F_200F_200F_200C_206D_200D_206F_206A_200F_202A_200D_202D_200F_202D_206F_202C_202A_202E(ItemPreviewPanelObj, false);
		ShowSelectMenuAll(selectMenu);
		CommonSettings.UpdatingShopUI = false;
	}

	private void SetSelectButtons()
	{
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		if (_200C_200C_202C_202A_206C_202C_206E_202D_206F_206A_206A_206A_202A_202B_200D_202D_206E_206C_200B_200D_206E_200C_202D_200D_200E_202C_200B_202B_202C_206E_202B_206B_206E_200F_200C_202B_202A_202B_202E_206B_202E((Object)(object)_202D_200E_202C_202E_206D_202E_202D_200B_206B_206A_206A_202A_206F_206E_206A_202B_202A_206C_206D_202B_206E_206D_206C_206D_206C_202C_206F_202A_206B_202C_202B_200D_200D_206B_206B_202E_200E_200B_202E_200D_202E, (Object)null))
		{
			goto IL_0011;
		}
		goto IL_03ea;
		IL_0011:
		int num = -618579645;
		goto IL_0016;
		IL_0016:
		ItemFilter itemFilter = default(ItemFilter);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -257358012)) % 35)
			{
			case 15u:
				break;
			default:
				return;
			case 28u:
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_202D_200F_200B_200B_202C_202C_206C_202C_206F_206C_206A_206D_202C_202B_206B_200F_202A_202D_202D_206A_206D_206D_202B_200D_206F_202D_202E_200E_202E_206F_202B_202C_200F_206D_202E_206F_206A_200B_206F_206A_202E, Color.yellow);
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_200F_202A_200D_202E_202C_200D_200D_200C_200B_206D_200B_206B_202B_200B_200F_206F_202E_206C_206C_206E_206D_200F_200D_202A_200E_206E_200E_202C_202D_200D_200F_202A_200F_206D_200B_200D_206A_206E_200E_206F_202E, Color.white);
				num = ((int)num2 * -2137824336) ^ 0x4873C963;
				continue;
			case 14u:
				return;
			case 29u:
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_206A_206D_206E_206D_206A_200E_202E_200E_200F_206C_202A_200E_206F_200E_202B_200D_202D_206C_206C_206C_202B_200E_200B_202C_200F_206D_206F_202B_200F_200E_200F_206C_200F_202E_200E_200E_200D_206E_206A_200E_202E, Color.yellow);
				num = -1062086968;
				continue;
			case 30u:
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_200B_206C_200B_206F_200E_200D_202E_200B_200C_202A_200D_202A_206B_206C_206E_206D_200E_206D_200D_206E_202E_206F_200B_206C_200B_202D_206D_200C_200C_202E_200D_206C_206F_202D_206D_200B_202A_200F_200B_202A_202E, Color.white);
				num = (int)((num2 * 2099581505) ^ 0x740F7ACB);
				continue;
			case 21u:
				return;
			case 10u:
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_202D_200E_202C_202E_206D_202E_202D_200B_206B_206A_206A_202A_206F_206E_206A_202B_202A_206C_206D_202B_206E_206D_206C_206D_206C_202C_206F_202A_206B_202C_202B_200D_200D_206B_206B_202E_200E_200B_202E_200D_202E, Color.white);
				num = ((int)num2 * -245452170) ^ -826287688;
				continue;
			case 6u:
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_202D_200F_200B_200B_202C_202C_206C_202C_206F_206C_206A_206D_202C_202B_206B_200F_202A_202D_202D_206A_206D_206D_202B_200D_206F_202D_202E_200E_202E_206F_202B_202C_200F_206D_202E_206F_206A_200B_206F_206A_202E, Color.white);
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_200F_202A_200D_202E_202C_200D_200D_200C_200B_206D_200B_206B_202B_200B_200F_206F_202E_206C_206C_206E_206D_200F_200D_202A_200E_206E_200E_202C_202D_200D_200F_202A_200F_206D_200B_200D_206A_206E_200E_206F_202E, Color.white);
				num = ((int)num2 * -1650296967) ^ -655814548;
				continue;
			case 17u:
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_202C_206B_206D_206C_206F_206F_202B_202C_202E_200E_206D_202A_206A_200E_202A_200C_200C_200E_202D_202E_206F_200E_202C_202E_202D_206E_202A_202B_200F_200C_206A_200E_206B_200D_206C_200C_200F_206F_206F_202E, Color.white);
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_202D_200F_200B_200B_202C_202C_206C_202C_206F_206C_206A_206D_202C_202B_206B_200F_202A_202D_202D_206A_206D_206D_202B_200D_206F_202D_202E_200E_202E_206F_202B_202C_200F_206D_202E_206F_206A_200B_206F_206A_202E, Color.white);
				num = ((int)num2 * -1454336448) ^ -381913032;
				continue;
			case 3u:
				return;
			case 32u:
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_200F_202A_200D_202E_202C_200D_200D_200C_200B_206D_200B_206B_202B_200B_200F_206F_202E_206C_206C_206E_206D_200F_200D_202A_200E_206E_200E_202C_202D_200D_200F_202A_200F_206D_200B_200D_206A_206E_200E_206F_202E, Color.yellow);
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_200B_206C_200B_206F_200E_200D_202E_200B_200C_202A_200D_202A_206B_206C_206E_206D_200E_206D_200D_206E_202E_206F_200B_206C_200B_202D_206D_200C_200C_202E_200D_206C_206F_202D_206D_200B_202A_200F_200B_202A_202E, Color.white);
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_202D_200E_202C_202E_206D_202E_202D_200B_206B_206A_206A_202A_206F_206E_206A_202B_202A_206C_206D_202B_206E_206D_206C_206D_206C_202C_206F_202A_206B_202C_202B_200D_200D_206B_206B_202E_200E_200B_202E_200D_202E, Color.white);
				num = (int)((num2 * 1521242542) ^ 0x274453DE);
				continue;
			case 12u:
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_200B_206C_200B_206F_200E_200D_202E_200B_200C_202A_200D_202A_206B_206C_206E_206D_200E_206D_200D_206E_202E_206F_200B_206C_200B_202D_206D_200C_200C_202E_200D_206C_206F_202D_206D_200B_202A_200F_200B_202A_202E, Color.white);
				num = (int)((num2 * 1680609483) ^ 0x723590A7);
				continue;
			case 5u:
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_202D_200E_202C_202E_206D_202E_202D_200B_206B_206A_206A_202A_206F_206E_206A_202B_202A_206C_206D_202B_206E_206D_206C_206D_206C_202C_206F_202A_206B_202C_202B_200D_200D_206B_206B_202E_200E_200B_202E_200D_202E, Color.white);
				num = (int)(num2 * 1139383265) ^ -516758686;
				continue;
			case 19u:
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_202D_200E_202C_202E_206D_202E_202D_200B_206B_206A_206A_202A_206F_206E_206A_202B_202A_206C_206D_202B_206E_206D_206C_206D_206C_202C_206F_202A_206B_202C_202B_200D_200D_206B_206B_202E_200E_200B_202E_200D_202E, Color.white);
				num = (int)(num2 * 2142257084) ^ -1714761312;
				continue;
			case 34u:
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_206A_206D_206E_206D_206A_200E_202E_200E_200F_206C_202A_200E_206F_200E_202B_200D_202D_206C_206C_206C_202B_200E_200B_202C_200F_206D_206F_202B_200F_200E_200F_206C_200F_202E_200E_200E_200D_206E_206A_200E_202E, Color.white);
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_202C_206B_206D_206C_206F_206F_202B_202C_202E_200E_206D_202A_206A_200E_202A_200C_200C_200E_202D_202E_206F_200E_202C_202E_202D_206E_202A_202B_200F_200C_206A_200E_206B_200D_206C_200C_200F_206F_206F_202E, Color.white);
				num = -32748493;
				continue;
			case 31u:
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_202C_206B_206D_206C_206F_206F_202B_202C_202E_200E_206D_202A_206A_200E_202A_200C_200C_200E_202D_202E_206F_200E_202C_202E_202D_206E_202A_202B_200F_200C_206A_200E_206B_200D_206C_200C_200F_206F_206F_202E, Color.white);
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_202D_200F_200B_200B_202C_202C_206C_202C_206F_206C_206A_206D_202C_202B_206B_200F_202A_202D_202D_206A_206D_206D_202B_200D_206F_202D_202E_200E_202E_206F_202B_202C_200F_206D_202E_206F_206A_200B_206F_206A_202E, Color.white);
				num = ((int)num2 * -1178346844) ^ -2104096873;
				continue;
			case 1u:
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_202C_206B_206D_206C_206F_206F_202B_202C_202E_200E_206D_202A_206A_200E_202A_200C_200C_200E_202D_202E_206F_200E_202C_202E_202D_206E_202A_202B_200F_200C_206A_200E_206B_200D_206C_200C_200F_206F_206F_202E, Color.white);
				num = ((int)num2 * -1940379669) ^ 0x480B1B8D;
				continue;
			case 16u:
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_202D_200F_200B_200B_202C_202C_206C_202C_206F_206C_206A_206D_202C_202B_206B_200F_202A_202D_202D_206A_206D_206D_202B_200D_206F_202D_202E_200E_202E_206F_202B_202C_200F_206D_202E_206F_206A_200B_206F_206A_202E, Color.white);
				num = (int)((num2 * 127836795) ^ 0x5E73DC73);
				continue;
			case 23u:
				goto IL_032c;
			case 8u:
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_202D_200E_202C_202E_206D_202E_202D_200B_206B_206A_206A_202A_206F_206E_206A_202B_202A_206C_206D_202B_206E_206D_206C_206D_206C_202C_206F_202A_206B_202C_202B_200D_200D_206B_206B_202E_200E_200B_202E_200D_202E, Color.yellow);
				return;
			case 4u:
				goto IL_0369;
			case 13u:
				num = (int)(num2 * 259757305) ^ -1224541775;
				continue;
			case 25u:
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_202D_200E_202C_202E_206D_202E_202D_200B_206B_206A_206A_202A_206F_206E_206A_202B_202A_206C_206D_202B_206E_206D_206C_206D_206C_202C_206F_202A_206B_202C_202B_200D_200D_206B_206B_202E_200E_200B_202E_200D_202E, Color.white);
				return;
			case 20u:
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_200F_202A_200D_202E_202C_200D_200D_200C_200B_206D_200B_206B_202B_200B_200F_206F_202E_206C_206C_206E_206D_200F_200D_202A_200E_206E_200E_202C_202D_200D_200F_202A_200F_206D_200B_200D_206A_206E_200E_206F_202E, Color.white);
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_200B_206C_200B_206F_200E_200D_202E_200B_200C_202A_200D_202A_206B_206C_206E_206D_200E_206D_200D_206E_202E_206F_200B_206C_200B_202D_206D_200C_200C_202E_200D_206C_206F_202D_206D_200B_202A_200F_200B_202A_202E, Color.yellow);
				num = ((int)num2 * -572621758) ^ -1738665968;
				continue;
			case 27u:
				goto IL_03ea;
			case 2u:
				goto IL_03fb;
			case 18u:
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_200B_206C_200B_206F_200E_200D_202E_200B_200C_202A_200D_202A_206B_206C_206E_206D_200E_206D_200D_206E_202E_206F_200B_206C_200B_202D_206D_200C_200C_202E_200D_206C_206F_202D_206D_200B_202A_200F_200B_202A_202E, Color.white);
				num = ((int)num2 * -1281470682) ^ 0x7135CAFB;
				continue;
			case 26u:
				switch (itemFilter)
				{
				case ItemFilter.Miji:
					break;
				case ItemFilter.Mission:
					goto IL_032c;
				case ItemFilter.Special:
					goto IL_0369;
				case ItemFilter.Zhuangbei:
					goto IL_03fb;
				default:
					goto IL_0453;
				case ItemFilter.Costa:
					goto IL_04ba;
				}
				goto case 34u;
			case 22u:
				return;
			case 24u:
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_202C_206B_206D_206C_206F_206F_202B_202C_202E_200E_206D_202A_206A_200E_202A_200C_200C_200E_202D_202E_206F_200E_202C_202E_202D_206E_202A_202B_200F_200C_206A_200E_206B_200D_206C_200C_200F_206F_206F_202E, Color.yellow);
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_202D_200F_200B_200B_202C_202C_206C_202C_206F_206C_206A_206D_202C_202B_206B_200F_202A_202D_202D_206A_206D_206D_202B_200D_206F_202D_202E_200E_202E_206F_202B_202C_200F_206D_202E_206F_206A_200B_206F_206A_202E, Color.white);
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_200F_202A_200D_202E_202C_200D_200D_200C_200B_206D_200B_206B_202B_200B_200F_206F_202E_206C_206C_206E_206D_200F_200D_202A_200E_206E_200E_202C_202D_200D_200F_202A_200F_206D_200B_200D_206A_206E_200E_206F_202E, Color.white);
				num = (int)(num2 * 1112734647) ^ -496346813;
				continue;
			case 11u:
				goto IL_04ba;
			case 33u:
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_202C_206B_206D_206C_206F_206F_202B_202C_202E_200E_206D_202A_206A_200E_202A_200C_200C_200E_202D_202E_206F_200E_202C_202E_202D_206E_202A_202B_200F_200C_206A_200E_206B_200D_206C_200C_200F_206F_206F_202E, Color.white);
				num = ((int)num2 * -1221915077) ^ 0x18593FCC;
				continue;
			case 0u:
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_200B_206C_200B_206F_200E_200D_202E_200B_200C_202A_200D_202A_206B_206C_206E_206D_200E_206D_200D_206E_202E_206F_200B_206C_200B_202D_206D_200C_200C_202E_200D_206C_206F_202D_206D_200B_202A_200F_200B_202A_202E, Color.white);
				num = (int)((num2 * 1899078157) ^ 0x6AE353F5);
				continue;
			case 9u:
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_200F_202A_200D_202E_202C_200D_200D_200C_200B_206D_200B_206B_202B_200B_200F_206F_202E_206C_206C_206E_206D_200F_200D_202A_200E_206E_200E_202C_202D_200D_200F_202A_200F_206D_200B_200D_206A_206E_200E_206F_202E, Color.white);
				num = (int)(num2 * 1799814951) ^ -1334626032;
				continue;
			case 7u:
				return;
				IL_04ba:
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_206A_206D_206E_206D_206A_200E_202E_200E_200F_206C_202A_200E_206F_200E_202B_200D_202D_206C_206C_206C_202B_200E_200B_202C_200F_206D_206F_202B_200F_200E_200F_206C_200F_202E_200E_200E_200D_206E_206A_200E_202E, Color.white);
				num = -1546377843;
				continue;
				IL_0453:
				num = (int)((num2 * 1809101877) ^ 0x4534AE24);
				continue;
				IL_03fb:
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_206A_206D_206E_206D_206A_200E_202E_200E_200F_206C_202A_200E_206F_200E_202B_200D_202D_206C_206C_206C_202B_200E_200B_202C_200F_206D_206F_202B_200F_200E_200F_206C_200F_202E_200E_200E_200D_206E_206A_200E_202E, Color.white);
				num = -946013982;
				continue;
				IL_0369:
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_206A_206D_206E_206D_206A_200E_202E_200E_200F_206C_202A_200E_206F_200E_202B_200D_202D_206C_206C_206C_202B_200E_200B_202C_200F_206D_206F_202B_200F_200E_200F_206C_200F_202E_200E_200E_200D_206E_206A_200E_202E, Color.white);
				num = -332443341;
				continue;
				IL_032c:
				_202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E((Graphic)(object)_206A_206D_206E_206D_206A_200E_202E_200E_200F_206C_202A_200E_206F_200E_202B_200D_202D_206C_206C_206C_202B_200E_200B_202C_200F_206D_206F_202B_200F_200E_200F_206C_200F_202E_200E_200E_200D_206E_206A_200E_202E, Color.white);
				num = -878809688;
				continue;
			}
			break;
		}
		goto IL_0011;
		IL_03ea:
		itemFilter = _200E_200C_202B_206A_202E_206E_206A_206F_200D_200E_200D_202A_206F_202A_206C_202E_200D_202A_202B_206B_202A_200E_200E_202E_202C_202A_206A_202B_206D_202E_206E_206E_200F_200B_206C_206E_200F_202C_206E_200F_202E;
		num = -1082251737;
		goto IL_0016;
	}

	private void OnClicked(GameObject sender)
	{
		if (!_202E_200E_206D_202B_206C_200B_206F_202C_206A_206C_202A_200D_206B_206E_202A_200F_200B_206B_206D_206F_200C_200C_200D_206F_200E_200E_206A_202B_202B_202E_202A_206A_202E_202C_206E_202D_200B_200B_200D_202B_202E(_206F_206C_200F_206A_200F_206B_200E_202A_206C_202B_202A_206D_206E_202E_202B_206F_206D_200D_206E_206C_206D_206D_200F_200C_202D_200D_202B_202D_202E_202E_202B_206B_206B_206C_200C_202D_206F_200C_200C_202E_202E((Object)(object)sender), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1833591357u)))
		{
			return;
		}
		while (true)
		{
			int num = -1503104813;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -150604703)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0039;
				case 1u:
					return;
				}
				break;
				IL_0039:
				SetFilter(ItemFilter.Mission);
				num = (int)((num2 * 199431140) ^ 0xD53AFEE);
			}
		}
	}

	private void initObj()
	{
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected O, but got Unknown
		//IL_072e: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		if (!_200C_200C_202C_202A_206C_202C_206E_202D_206F_206A_206A_206A_202A_202B_200D_202D_206E_206C_200B_200D_206E_200C_202D_200D_200E_202C_200B_202B_202C_206E_202B_206B_206E_200F_200C_202B_202A_202B_202E_206B_202E((Object)(object)_206A_206D_206E_206D_206A_200E_202E_200E_200F_206C_202A_200E_206F_200E_202B_200D_202D_206C_206C_206C_202B_200E_200B_202C_200F_206D_206F_202B_200F_200E_200F_206C_200F_202E_200E_200E_200D_206E_206A_200E_202E, (Object)null))
		{
			return;
		}
		Transform val4 = default(Transform);
		Transform val2 = default(Transform);
		_206A_200E_206E_206E_202B_200D_200C_202B_200B_206E_202B_202A_202A_200D_206E_200F_206F_206D_202B_206B_202E_200C_202C_200F_200D_200E_200B_206A_202B_206F_200B_206D_206D_206C_202A_200F_200D_200E_200D_206A_202E obj = default(_206A_200E_206E_206E_202B_200D_200C_202B_200B_206E_202B_202A_202A_200D_206E_200F_206F_206D_202B_206B_202E_200C_202C_200F_200D_200E_200B_206A_202B_206F_200B_206D_206D_206C_202A_200F_200D_200E_200D_206A_202E);
		Transform val = default(Transform);
		Transform val3 = default(Transform);
		Transform val5 = default(Transform);
		while (true)
		{
			int num = -1898522223;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -707898534)) % 38)
				{
				case 7u:
					break;
				default:
					return;
				case 4u:
				{
					int num5;
					if (_202B_202C_206C_202E_202A_200D_202B_206B_200F_200D_206B_200F_206B_202C_206F_206C_202C_202B_202B_202D_200C_202E_206C_200C_200C_200E_202C_206E_202D_200F_206B_206C_206E_202C_202D_202A_206F_200B_200F_200C_202E(_206B_202D_206B_206E_206D_200B_206E_202B_202B_206C_202C_200B_200C_202C_206E_200C_206B_202E_200C_200E_206B_206E_206F_202E_200D_202A_206E_200D_202B_200C_206B_202D_200F_200B_202C_202D_202A_206B_206B_200C_202E(), global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2132284838u)))
					{
						num = -159732995;
						num5 = num;
					}
					else
					{
						num = -571448746;
						num5 = num;
					}
					continue;
				}
				case 13u:
					val4 = ItemPrefab.transform.FindChild(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2905757779u));
					num = -2118918138;
					continue;
				case 29u:
				{
					int num11;
					int num12;
					if (!CommonSettings.USE_SYSTEM_FONT)
					{
						num11 = -1747845997;
						num12 = num11;
					}
					else
					{
						num11 = -1011284522;
						num12 = num11;
					}
					num = num11 ^ (int)(num2 * 1711043349);
					continue;
				}
				case 20u:
					_200F_202A_200D_202E_202C_200D_200D_200C_200B_206D_200B_206B_202B_200B_200F_206F_202E_206C_206C_206E_206D_200F_200D_202A_200E_206E_200E_202C_202D_200D_200F_202A_200F_206D_200B_200D_206A_206E_200E_206F_202E = ((Component)_202E_202C_200E_202B_200F_200B_202C_206C_202D_200E_202A_202B_202C_202A_206C_200D_206C_206E_206F_202B_202C_200D_200C_202C_206B_206F_202C_200C_202A_202E_206F_200B_202A_202D_206C_202E_202D_200D_202A_206C_202E(_202E_202C_200E_202B_200F_200B_202C_206C_202D_200E_202A_202B_202C_202A_206C_200D_206C_206E_206F_202B_202C_200D_200C_202C_206B_206F_202C_200C_202A_202E_206F_200B_202A_202D_206C_202E_202D_200D_202A_206C_202E(val2, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3658343713u)), global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2712075045u))).GetComponent<Text>();
					num = (int)(num2 * 2840252) ^ -1020841827;
					continue;
				case 17u:
				{
					int num7;
					int num8;
					if (RuntimeData.Instance.isBattle)
					{
						num7 = -443078865;
						num8 = num7;
					}
					else
					{
						num7 = -128107664;
						num8 = num7;
					}
					num = num7 ^ (int)(num2 * 430779121);
					continue;
				}
				case 18u:
				{
					Button component = obj.btnObj.GetComponent<Button>();
					_206F_206F_202D_200F_206C_206A_200D_202D_202C_200E_206E_202B_206D_202A_206E_202B_206D_202E_200F_202A_202B_202A_206F_200B_206F_206B_200D_202C_200D_206A_202D_206E_202D_202A_202C_202A_200E_202A_206F_202E(_206E_202B_200F_202B_206F_202C_206A_200E_206D_206D_200C_200B_206B_200B_200E_202D_206F_206F_206C_202D_206C_200E_200C_200D_206A_206C_206A_200F_200F_206C_202C_206F_206A_202D_206B_200F_200C_200B_200C_200E_202E((Component)(object)component), _200C_200B_200E_206F_206C_200C_200F_202A_200B_206B_202B_206F_202C_200B_202A_202C_206B_202A_206A_200C_202C_202A_202E_202E_202A_200D_202A_206A_200C_202B_200F_200F_206C_200F_206A_206C_200E_200B_202A_202D_202E(val));
					_206E_202B_200F_202B_206F_202C_206A_200E_206D_206D_200C_200B_206B_200B_200E_202D_206F_206F_206C_202D_206C_200E_200C_200D_206A_206C_206A_200F_200F_206C_202C_206F_206A_202D_206B_200F_200C_200B_200C_200E_202E((Component)(object)component).localPosition = new Vector3(-498f, -134.6f, 0f);
					((UnityEventBase)component.onClick).SetPersistentListenerState(0, (UnityEventCallState)0);
					((UnityEvent)component.onClick).AddListener(new UnityAction(obj._206D_202A_206B_200B_202D_202E_202E_206C_200E_206E_206C_202E_200C_200E_200B_200B_202A_200E_202D_202B_200F_200D_202A_202B_200E_206B_202D_202E_206F_200E_206A_202E_200B_202A_202D_206A_200F_206C_206F_206B_202E));
					num = (int)((num2 * 2040104939) ^ 0x70FCDA2E);
					continue;
				}
				case 11u:
				{
					int num9;
					int num10;
					if (CommonSettings.USE_SYSTEM_FONT)
					{
						num9 = -1046001978;
						num10 = num9;
					}
					else
					{
						num9 = -377304019;
						num10 = num9;
					}
					num = num9 ^ (int)(num2 * 763449);
					continue;
				}
				case 9u:
					val2 = _202E_202C_200E_202B_200F_200B_202C_206C_202D_200E_202A_202B_202C_202A_206C_200D_206C_206E_206F_202B_202C_200D_200C_202C_206B_206F_202C_200C_202A_202E_206F_200B_202A_202D_206C_202E_202D_200D_202A_206C_202E(_200F_200E_206E_206A_202C_206E_200F_206C_206D_206A_206D_206C_202A_206F_206E_200B_202B_206A_202D_206A_206B_200E_202A_206A_206C_202C_202B_202B_206A_206C_200F_202D_200B_200C_202B_200C_206F_206E_200D_202A_202E((Component)(object)this), global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2779446395u));
					_206A_206D_206E_206D_206A_200E_202E_200E_200F_206C_202A_200E_206F_200E_202B_200D_202D_206C_206C_206C_202B_200E_200B_202C_200F_206D_206F_202B_200F_200E_200F_206C_200F_202E_200E_200E_200D_206E_206A_200E_202E = ((Component)_202E_202C_200E_202B_200F_200B_202C_206C_202D_200E_202A_202B_202C_202A_206C_200D_206C_206E_206F_202B_202C_200D_200C_202C_206B_206F_202C_200C_202A_202E_206F_200B_202A_202D_206C_202E_202D_200D_202A_206C_202E(_202E_202C_200E_202B_200F_200B_202C_206C_202D_200E_202A_202B_202C_202A_206C_200D_206C_206E_206F_202B_202C_200D_200C_202C_206B_206F_202C_200C_202A_202E_206F_200B_202A_202D_206C_202E_202D_200D_202A_206C_202E(val2, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3976660322u)), global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2510808305u))).GetComponent<Text>();
					num = ((int)num2 * -1042355565) ^ 0x292907D6;
					continue;
				case 27u:
					_202D_200E_202C_202E_206D_202E_202D_200B_206B_206A_206A_202A_206F_206E_206A_202B_202A_206C_206D_202B_206E_206D_206C_206D_206C_202C_206F_202A_206B_202C_202B_200D_200D_206B_206B_202E_200E_200B_202E_200D_202E = ((Component)_202E_202C_200E_202B_200F_200B_202C_206C_202D_200E_202A_202B_202C_202A_206C_200D_206C_206E_206F_202B_202C_200D_200C_202C_206B_206F_202C_200C_202A_202E_206F_200B_202A_202D_206C_202E_202D_200D_202A_206C_202E(_206F_206C_202B_200C_202C_202E_200C_200F_200F_200C_206D_206C_202A_206A_202C_202D_206E_206C_202A_202E_202C_200D_206E_202D_200C_200F_200B_206D_206C_202C_206A_202A_206C_206A_206F_206A_202D_206B_206D_200C_202E(obj.btnObj), global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2510808305u))).GetComponent<Text>();
					_200F_206C_202D_206C_206E_206D_206C_202B_202B_202D_202A_202B_200F_200D_206A_202B_206F_200C_202E_202B_206B_202D_202C_200C_200D_206B_202C_202D_200C_200E_202D_200D_200C_206E_206B_202A_202D_200C_200E_202C_202E(_202D_200E_202C_202E_206D_202E_202D_200B_206B_206A_206A_202A_206F_206E_206A_202B_202A_206C_206D_202B_206E_206D_206C_206D_206C_202C_206F_202A_206B_202C_202B_200D_200D_206B_206B_202E_200E_200B_202E_200D_202E, ResourceStrings.ResStrings[82]);
					num = (int)(num2 * 377898171) ^ -1692880529;
					continue;
				case 6u:
					((Component)val3).gameObject.SetActive(false);
					num = ((int)num2 * -567498644) ^ 0x3A9B8FFA;
					continue;
				case 35u:
					_206A_202D_206E_200F_202D_206B_202D_200B_206B_206B_206D_200F_206B_202E_200F_202C_200F_206A_206D_202A_200D_200D_200D_206E_202E_202D_206E_202D_206B_206F_206F_202B_200F_206C_202C_206E_202E_200E_206F_202A_202E(((Component)_202E_202C_200E_202B_200F_200B_202C_206C_202D_200E_202A_202B_202C_202A_206C_200D_206C_206E_206F_202B_202C_200D_200C_202C_206B_206F_202C_200C_202A_202E_206F_200B_202A_202D_206C_202E_202D_200D_202A_206C_202E(_200F_200E_206E_206A_202C_206E_200F_206C_206D_206A_206D_206C_202A_206F_206E_200B_202B_206A_202D_206A_206B_200E_202A_206A_206C_202C_202B_202B_206A_206C_200F_202D_200B_200C_202B_200C_206F_206E_200D_202A_202E((Component)(object)this), global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4025413114u))).GetComponent<Text>(), ModEditorResourceManager.GetFont(CommonSettings.SYSTEM_FONT_NAME));
					num = (int)((num2 * 1687277940) ^ 0x33CB8219);
					continue;
				case 12u:
					((Component)ItemPrefab.transform.FindChild(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2674367751u))).GetComponent<Image>().sprite = ModEditorResourceManager.uiCache[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3715204446u)];
					num = ((int)num2 * -1970673274) ^ 0x18974267;
					continue;
				case 15u:
				{
					int num6;
					if (!(Application.loadedLevelName == global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(943200524u)))
					{
						num = -1969140894;
						num6 = num;
					}
					else
					{
						num = -1307480882;
						num6 = num;
					}
					continue;
				}
				case 22u:
					_202D_200F_200B_200B_202C_202C_206C_202C_206F_206C_206A_206D_202C_202B_206B_200F_202A_202D_202D_206A_206D_206D_202B_200D_206F_202D_202E_200E_202E_206F_202B_202C_200F_206D_202E_206F_206A_200B_206F_206A_202E = ((Component)_202E_202C_200E_202B_200F_200B_202C_206C_202D_200E_202A_202B_202C_202A_206C_200D_206C_206E_206F_202B_202C_200D_200C_202C_206B_206F_202C_200C_202A_202E_206F_200B_202A_202D_206C_202E_202D_200D_202A_206C_202E(_202E_202C_200E_202B_200F_200B_202C_206C_202D_200E_202A_202B_202C_202A_206C_200D_206C_206E_206F_202B_202C_200D_200C_202C_206B_206F_202C_200C_202A_202E_206F_200B_202A_202D_206C_202E_202D_200D_202A_206C_202E(val2, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1943692096u)), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4073321940u))).GetComponent<Text>();
					num = ((int)num2 * -441335810) ^ -938989696;
					continue;
				case 8u:
					_206A_202D_206E_200F_202D_206B_202D_200B_206B_206B_206D_200F_206B_202E_200F_202C_200F_206A_206D_202A_200D_200D_200D_206E_202E_202D_206E_202D_206B_206F_206F_202B_200F_206C_202C_206E_202E_200E_206F_202A_202E(_202D_200F_200B_200B_202C_202C_206C_202C_206F_206C_206A_206D_202C_202B_206B_200F_202A_202D_202D_206A_206D_206D_202B_200D_206F_202D_202E_200E_202E_206F_202B_202C_200F_206D_202E_206F_206A_200B_206F_206A_202E, ModEditorResourceManager.GetFont(CommonSettings.SYSTEM_FONT_NAME));
					num = ((int)num2 * -1387559438) ^ -940687793;
					continue;
				case 5u:
					_206A_202D_206E_200F_202D_206B_202D_200B_206B_206B_206D_200F_206B_202E_200F_202C_200F_206A_206D_202A_200D_200D_200D_206E_202E_202D_206E_202D_206B_206F_206F_202B_200F_206C_202C_206E_202E_200E_206F_202A_202E(_200B_206C_200B_206F_200E_200D_202E_200B_200C_202A_200D_202A_206B_206C_206E_206D_200E_206D_200D_206E_202E_206F_200B_206C_200B_202D_206D_200C_200C_202E_200D_206C_206F_202D_206D_200B_202A_200F_200B_202A_202E, ModEditorResourceManager.GetFont(CommonSettings.SYSTEM_FONT_NAME));
					num = ((int)num2 * -1935553851) ^ -1905440731;
					continue;
				case 3u:
					((Component)val5).GetComponent<Text>().font = ModEditorResourceManager.GetFont(CommonSettings.SYSTEM_FONT_NAME);
					num = (int)((num2 * 1283870006) ^ 0x158287D0);
					continue;
				case 26u:
				{
					int num3;
					int num4;
					if (!((Object)(object)ModEditorResourceManager.uiCache[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4183515291u)] != (Object)null))
					{
						num3 = -1197998077;
						num4 = num3;
					}
					else
					{
						num3 = -959253872;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 79884660);
					continue;
				}
				case 34u:
					_200E_200C_202B_206A_202E_206E_206A_206F_200D_200E_200D_202A_206F_202A_206C_202E_200D_202A_202B_206B_202A_200E_200E_202E_202C_202A_206A_202B_206D_202E_206E_206E_200F_200B_206C_206E_200F_202C_206E_200F_202E = ItemFilter.All;
					num = -1359220474;
					continue;
				case 1u:
					_202C_206B_206D_206C_206F_206F_202B_202C_202E_200E_206D_202A_206A_200E_202A_200C_200C_200E_202D_202E_206F_200E_202C_202E_202D_206E_202A_202B_200F_200C_206A_200E_206B_200D_206C_200C_200F_206F_206F_202E = ((Component)_202E_202C_200E_202B_200F_200B_202C_206C_202D_200E_202A_202B_202C_202A_206C_200D_206C_206E_206F_202B_202C_200D_200C_202C_206B_206F_202C_200C_202A_202E_206F_200B_202A_202D_206C_202E_202D_200D_202A_206C_202E(_202E_202C_200E_202B_200F_200B_202C_206C_202D_200E_202A_202B_202C_202A_206C_200D_206C_206E_206F_202B_202C_200D_200C_202C_206B_206F_202C_200C_202A_202E_206F_200B_202A_202D_206C_202E_202D_200D_202A_206C_202E(val2, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3871063218u)), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4073321940u))).GetComponent<Text>();
					num = (int)(num2 * 988412671) ^ -202823155;
					continue;
				case 0u:
					num = ((int)num2 * -1676247048) ^ 0x7261D663;
					continue;
				case 10u:
				{
					Transform obj3 = ItemPrefab.transform.FindChild(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(917410536u));
					((Component)obj3).GetComponent<RectTransform>().sizeDelta = new Vector2(85f, 85f);
					((Component)obj3).GetComponent<Image>().sprite = null;
					((Graphic)((Component)obj3).GetComponent<Image>()).color = new Color(0f, 0f, 0f, 0f);
					num = -697555000;
					continue;
				}
				case 25u:
					_206A_202D_206E_200F_202D_206B_202D_200B_206B_206B_206D_200F_206B_202E_200F_202C_200F_206A_206D_202A_200D_200D_200D_206E_202E_202D_206E_202D_206B_206F_206F_202B_200F_206C_202C_206E_202E_200E_206F_202A_202E(_206A_206D_206E_206D_206A_200E_202E_200E_200F_206C_202A_200E_206F_200E_202B_200D_202D_206C_206C_206C_202B_200E_200B_202C_200F_206D_206F_202B_200F_200E_200F_206C_200F_202E_200E_200E_200D_206E_206A_200E_202E, ModEditorResourceManager.GetFont(CommonSettings.SYSTEM_FONT_NAME));
					_206A_202D_206E_200F_202D_206B_202D_200B_206B_206B_206D_200F_206B_202E_200F_202C_200F_206A_206D_202A_200D_200D_200D_206E_202E_202D_206E_202D_206B_206F_206F_202B_200F_206C_202C_206E_202E_200E_206F_202A_202E(_202C_206B_206D_206C_206F_206F_202B_202C_202E_200E_206D_202A_206A_200E_202A_200C_200C_200E_202D_202E_206F_200E_202C_202E_202D_206E_202A_202B_200F_200C_206A_200E_206B_200D_206C_200C_200F_206F_206F_202E, ModEditorResourceManager.GetFont(CommonSettings.SYSTEM_FONT_NAME));
					num = ((int)num2 * -1035863018) ^ 0x559B7D98;
					continue;
				case 32u:
					obj.btnObj = Object.Instantiate<GameObject>(_206F_202B_206E_200E_206F_200C_202D_206E_200D_206E_206A_202D_206C_206E_206E_202D_200E_200B_202D_202A_206E_200E_206A_202C_202E_206B_202A_202D_206F_206B_202B_206A_206F_202A_202A_200B_206D_202C_202E_206B_202E((Component)(object)val));
					_200F_202A_206A_206E_200E_202B_200E_202B_200F_206B_202C_200E_200E_206B_200D_200D_200D_206F_200F_202C_202E_206B_202C_206E_206E_206A_200D_202C_206C_206A_206F_200B_202E_202C_200C_200C_206B_206E_202E_206A_202E((Object)(object)obj.btnObj, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1099230584u));
					num = ((int)num2 * -1608962341) ^ 0x58BBB337;
					continue;
				case 36u:
					num = (int)((num2 * 1326768365) ^ 0x1CEAC0E2);
					continue;
				case 2u:
					((Component)this).transform.FindChild(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1018193563u)).FindChild(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2794901851u)).localPosition = new Vector3(514f, 116f, 0f);
					num = -223117565;
					continue;
				case 24u:
				{
					Transform obj2 = ((Component)this).transform.FindChild(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2217778713u));
					((Component)obj2).GetComponent<RectTransform>().sizeDelta = new Vector2(872f, 463f);
					obj2.localPosition = new Vector3(126f, -101f, 0f);
					num = ((int)num2 * -100901041) ^ -1127804810;
					continue;
				}
				case 28u:
					val5 = ItemPrefab.transform.FindChild(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1109494624u));
					((Component)val4).GetComponent<Text>().fontSize = 21;
					num = (int)(num2 * 365129362) ^ -789127285;
					continue;
				case 16u:
					val3 = ((Component)this).transform.FindChild(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2251844943u));
					num = ((int)num2 * -553858050) ^ -1854795875;
					continue;
				case 21u:
					_206A_202D_206E_200F_202D_206B_202D_200B_206B_206B_206D_200F_206B_202E_200F_202C_200F_206A_206D_202A_200D_200D_200D_206E_202E_202D_206E_202D_206B_206F_206F_202B_200F_206C_202C_206E_202E_200E_206F_202A_202E(_200F_202A_200D_202E_202C_200D_200D_200C_200B_206D_200B_206B_202B_200B_200F_206F_202E_206C_206C_206E_206D_200F_200D_202A_200E_206E_200E_202C_202D_200D_200F_202A_200F_206D_200B_200D_206A_206E_200E_206F_202E, ModEditorResourceManager.GetFont(CommonSettings.SYSTEM_FONT_NAME));
					num = ((int)num2 * -1814803984) ^ -1858765325;
					continue;
				case 23u:
					val5.localPosition = new Vector3(-0.02501297f, 34.5f, 0f);
					num = (int)((num2 * 827259215) ^ 0x32EA55F0);
					continue;
				case 37u:
					((Component)val4).GetComponent<Text>().font = ModEditorResourceManager.GetFont(CommonSettings.SYSTEM_FONT_NAME);
					num = ((int)num2 * -2048500237) ^ 0x3EA2C996;
					continue;
				case 14u:
					_200B_206C_200B_206F_200E_200D_202E_200B_200C_202A_200D_202A_206B_206C_206E_206D_200E_206D_200D_206E_202E_206F_200B_206C_200B_202D_206D_200C_200C_202E_200D_206C_206F_202D_206D_200B_202A_200F_200B_202A_202E = ((Component)_202E_202C_200E_202B_200F_200B_202C_206C_202D_200E_202A_202B_202C_202A_206C_200D_206C_206E_206F_202B_202C_200D_200C_202C_206B_206F_202C_200C_202A_202E_206F_200B_202A_202D_206C_202E_202D_200D_202A_206C_202E(val, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2712075045u))).GetComponent<Text>();
					num = ((int)num2 * -943846581) ^ 0x2238371D;
					continue;
				case 19u:
					obj = new _206A_200E_206E_206E_202B_200D_200C_202B_200B_206E_202B_202A_202A_200D_206E_200F_206F_206D_202B_206B_202E_200C_202C_200F_200D_200E_200B_206A_202B_206F_200B_206D_206D_206C_202A_200F_200D_200E_200D_206A_202E();
					obj._202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E = this;
					num = ((int)num2 * -433108222) ^ -1849542926;
					continue;
				case 31u:
					_206A_206D_206E_206D_206A_200E_202E_200E_200F_206C_202A_200E_206F_200E_202B_200D_202D_206C_206C_206C_202B_200E_200B_202C_200F_206D_206F_202B_200F_200E_200F_206C_200F_202E_200E_200E_200D_206E_206A_200E_202E = ((Component)val3.FindChild(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(56570083u)).FindChild(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4073321940u))).GetComponent<Text>();
					num = ((int)num2 * -1371444520) ^ 0x3A70A020;
					continue;
				case 33u:
					val = _202E_202C_200E_202B_200F_200B_202C_206C_202D_200E_202A_202B_202C_202A_206C_200D_206C_206E_206F_202B_202C_200D_200C_202C_206B_206F_202C_200C_202A_202E_206F_200B_202A_202D_206C_202E_202D_200D_202A_206C_202E(val2, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(999951609u));
					num = ((int)num2 * -1132014256) ^ -1717714844;
					continue;
				case 30u:
					return;
				}
				break;
			}
		}
	}

	private void ShowSelectMenuAll(SelectMenu selectMenu, int count = -1)
	{
		if (count >= 0)
		{
			goto IL_0007;
		}
		goto IL_01cc;
		IL_0007:
		int num = 1255065009;
		goto IL_000c;
		IL_000c:
		string text = default(string);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x7D69AA58)) % 18)
			{
			case 12u:
				break;
			case 0u:
				((Component)_202E_202C_200E_202B_200F_200B_202C_206C_202D_200E_202A_202B_202C_202A_206C_200D_206C_206E_206F_202B_202C_200D_200C_202C_206B_206F_202C_200C_202A_202E_206F_200B_202A_202D_206C_202E_202D_200D_202A_206C_202E(_200F_200E_206E_206A_202C_206E_200F_206C_206D_206A_206D_206C_202A_206F_206E_200B_202B_206A_202D_206A_206B_200E_202A_206A_206C_202C_202B_202B_206A_206C_200F_202D_200B_200C_202B_200C_206F_206E_200D_202A_202E((Component)(object)this), global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(878498933u))).GetComponent<Text>().text = text + global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4094942061u) + count + global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(487703859u);
				num = 2017007191;
				continue;
			case 6u:
				selectMenu.Show(delegate
				{
					Hide();
					CancelButtonClicked();
				});
				num = (int)((num2 * 2050347592) ^ 0x33A3193E);
				continue;
			case 17u:
				switch (_200E_200C_202B_206A_202E_206E_206A_206F_200D_200E_200D_202A_206F_202A_206C_202E_200D_202A_202B_206B_202A_200E_200E_202E_202C_202A_206A_202B_206D_202E_206E_206E_200F_200B_206C_206E_200F_202C_206E_200F_202E)
				{
				case ItemFilter.Mission:
					goto IL_0131;
				case ItemFilter.Special:
					goto IL_01b5;
				case ItemFilter.Zhuangbei:
					goto IL_0200;
				case ItemFilter.Costa:
					goto IL_0217;
				case ItemFilter.Miji:
					goto IL_022e;
				}
				num = ((int)num2 * -2088076669) ^ -121031938;
				continue;
			case 13u:
				num = ((int)num2 * -698285910) ^ 0x7E3029F2;
				continue;
			case 10u:
				return;
			case 8u:
				goto IL_0131;
			case 11u:
				text = _202E_206B_206D_202B_206F_200E_200B_200D_206D_200B_202C_200B_200D_206A_200B_202E_202D_206D_202B_206F_200F_206F_206B_200D_202B_202E_206F_206D_202C_206A_206C_200D_200F_202E_200B_200E_200D_202B_206D_202E_202E;
				num = ((int)num2 * -920611205) ^ -1205438225;
				continue;
			case 14u:
			{
				int num5;
				int num6;
				if (_206E_200E_202A_200C_202E_206A_206D_200D_206A_202D_202E_200C_206C_200D_200C_206F_200C_200E_206C_202B_202D_202B_206E_206D_206E_202B_206C_200B_206A_206D_202C_200E_200D_206C_200B_206C_200F_202E_200F_206D_202E != null)
				{
					num5 = 2065465466;
					num6 = num5;
				}
				else
				{
					num5 = 2140422057;
					num6 = num5;
				}
				num = num5 ^ ((int)num2 * -389145853);
				continue;
			}
			case 16u:
			{
				int num3;
				int num4;
				if (!_202E_200E_206D_202B_206C_200B_206F_202C_206A_206C_202A_200D_206B_206E_202A_200F_200B_206B_206D_206F_200C_200C_200D_206F_200E_200E_206A_202B_202B_202E_202A_206A_202E_202C_206E_202D_200B_200B_200D_202B_202E(text, ResourceStrings.ResStrings[76]))
				{
					num3 = -1792609492;
					num4 = num3;
				}
				else
				{
					num3 = -1698601147;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 1371479467);
				continue;
			}
			case 5u:
				goto IL_01b5;
			case 9u:
				goto IL_01cc;
			case 1u:
				num = (int)((num2 * 1118115448) ^ 0x67185C18);
				continue;
			case 7u:
				num = ((int)num2 * -2069636007) ^ -1608136935;
				continue;
			case 2u:
				goto IL_0200;
			case 15u:
				goto IL_0217;
			case 4u:
				goto IL_022e;
			default:
				{
					selectMenu.Show();
					return;
				}
				IL_0200:
				text = ResourceStrings.ResStrings[77];
				num = 1510578752;
				continue;
				IL_01b5:
				text = ResourceStrings.ResStrings[80];
				num = 1627505497;
				continue;
				IL_0217:
				text = ResourceStrings.ResStrings[79];
				num = 1510578752;
				continue;
				IL_0131:
				text = ResourceStrings.ResStrings[81];
				num = 1510578752;
				continue;
				IL_022e:
				text = ResourceStrings.ResStrings[78];
				num = 1722831645;
				continue;
			}
			break;
		}
		goto IL_0007;
		IL_01cc:
		SetSelectButtons();
		num = 1498722410;
		goto IL_000c;
	}

	private IEnumerator AddSelectMenuAll(List<KeyValuePair<ItemInstance, int>> list, SelectMenu selectMenu)
	{
		//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
		return new _206A_202E_206D_202D_206F_206C_206F_200F_202C_200F_206B_200F_206F_202B_200E_202E_206F_206C_206A_206D_202A_206D_206F_202A_200F_200C_200B_202D_202A_202D_202D_206D_206A_206E_206B_200D_200F_200E_200F_202E_202E(0)
		{
			_202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E = this,
			list = list,
			selectMenu = selectMenu
		};
	}

	public void SetIsRealCount(bool flag = true)
	{
		_206A_206B_206C_200B_200D_202E_200D_206A_202A_206C_200C_206D_200C_206C_200D_202B_206D_206A_206F_200E_206D_200F_206E_202A_200B_200D_200E_206F_206F_200F_202A_206A_202B_206A_206A_200E_206D_206D_200E_202E_202E = flag;
	}

	public void ShowLoader(string title, Dictionary<ItemInstance, int> items, CommonSettings.ObjectCallBack callback, CommonSettings.VoidCallBack cancelCallback, CommonSettings.JudgeCallback isItemActiveCallback, bool dynamic, bool realCount)
	{
		_202E_200E_200E_206F_200D_200B_202A_206D_202B_206D_206D_200D_202A_202B_202E_206F_202D_202B_206A_200E_206E_206D_206B_206B_200F_202D_202C_200F_206C_202B_200B_202E_200C_206B_202A_200E_206C_206E_206B_202A_202E = dynamic;
		while (true)
		{
			int num = -849664395;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -557784837)) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_002a;
				default:
					Show(title, items, callback, cancelCallback, isItemActiveCallback);
					return;
				}
				break;
				IL_002a:
				_206A_206B_206C_200B_200D_202E_200D_206A_202A_206C_200C_206D_200C_206C_200D_202B_206D_206A_206F_200E_206D_200F_206E_202A_200B_200D_200E_206F_206F_200F_202A_206A_202B_206A_206A_200E_206D_206D_200E_202E_202E = realCount;
				num = ((int)num2 * -787105368) ^ 0x6AD4B15E;
			}
		}
	}

	[CompilerGenerated]
	private void _202D_206E_202D_206C_200D_202E_202E_200B_200C_206A_206E_206B_202B_202E_200D_206C_206F_202A_206A_200E_202A_202D_202A_202A_200B_200D_206E_200D_202A_200F_200F_200D_202E_202E_202D_202B_200B_202E_202A_202B_202E()
	{
		Hide();
		CancelButtonClicked();
	}

	static void _202E_206E_202D_202D_206E_200D_206D_200F_202A_206A_202E_206A_206A_206A_202A_206B_200C_200E_206D_206C_200B_206C_206A_206E_206B_200E_202A_206B_200E_200B_200F_200C_200B_206D_202E_206B_206E_206F_200F_202B_202E(MonoBehaviour P_0)
	{
		P_0.StopAllCoroutines();
	}

	static void _200D_206B_200D_200E_206E_200C_202A_200D_206E_200D_202A_206A_200F_206A_200C_206C_202A_206D_200F_206A_202B_202C_200F_200F_200F_200C_206D_200D_206F_206A_200F_202A_200D_202D_200F_202D_206F_202C_202A_202E(GameObject P_0, bool P_1)
	{
		P_0.SetActive(P_1);
	}

	static Coroutine _202E_202E_200D_200F_206E_202E_202D_202C_202B_206C_202A_206D_200C_206D_200D_202E_206C_202C_200B_200C_206F_202A_206E_200C_206B_200D_202E_202D_206A_202B_206A_200B_200E_206F_206A_206C_200D_202E_202E(MonoBehaviour P_0, IEnumerator P_1)
	{
		return P_0.StartCoroutine(P_1);
	}

	static bool _202B_202C_206C_202E_202A_200D_202B_206B_200F_200D_206B_200F_206B_202C_206F_206C_202C_202B_202B_202D_200C_202E_206C_200C_200C_200E_202C_206E_202D_200F_206B_206C_206E_202C_202D_202A_206F_200B_200F_200C_202E(string P_0, string P_1)
	{
		return P_0 != P_1;
	}

	static GameObject _202D_202A_206C_206F_200B_202B_206A_202D_200D_200C_200E_202A_200C_202B_206B_206B_200D_202A_202B_206D_200B_206E_206C_206A_206E_200D_202C_202B_206A_202D_206F_200E_202C_206A_202D_200F_200D_206D_206C_206E_202E(Component P_0)
	{
		return P_0.gameObject;
	}

	static int _200C_206E_202B_200C_200C_206A_202D_200D_202A_206F_206B_200B_206D_206D_200E_202B_206A_206A_200C_200D_202D_202E_202A_206C_202D_200D_202B_206E_206A_206D_206E_202D_200B_202E_200D_206D_200B_202C_206A_202C_202E(Transform P_0)
	{
		return P_0.childCount;
	}

	static bool _206F_206F_202B_206A_200E_202B_206D_202D_206E_202A_202C_202B_202B_200B_202B_200F_202B_206E_202B_206E_206A_206F_202D_206F_202E_200D_200F_200E_206C_206A_206D_202E_206F_206F_206F_202B_200B_206E_206C_206D_202E(KeyCode P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Input.GetKeyDown(P_0);
	}

	static bool _206B_202B_200D_206D_202D_206F_206C_200E_202C_202A_206E_202E_202A_202A_202E_200C_202A_200B_200D_202B_202D_206F_200C_206D_206B_200E_206C_200F_206D_202B_206A_202A_206B_202D_206C_206D_202B_206E_206E_200C_202E(int P_0)
	{
		return Input.GetMouseButtonDown(P_0);
	}

	static bool _206E_200C_202D_200F_206D_202E_206F_200B_206C_202A_202D_206D_206F_206C_202B_206F_202D_202B_200B_206D_202E_206E_200F_202E_206E_202D_206C_206F_206A_202E_200F_202B_200C_206E_202B_206C_206F_202E_202C_202C_202E(GameObject P_0)
	{
		return P_0.activeSelf;
	}

	static bool _202D_206F_202D_206F_200E_202A_200C_200F_200F_202D_202B_200B_206B_202C_200C_200E_206C_202A_202E_206D_200B_206B_206A_202D_206A_206A_202A_200F_206F_202E_200C_200C_202E_206D_200F_200B_200D_206C_200B_202B_202E(Object P_0, Object P_1)
	{
		return P_0 != P_1;
	}

	static int _202E_202A_202D_200C_206F_206F_202B_200F_202D_206F_206B_200D_200C_206C_206B_206D_206E_206C_206F_206D_202D_200D_200E_206C_202D_202B_202E_200F_200E_206C_206C_200E_200D_202D_206B_202D_202C_206F_202C_206E_202E(string P_0, string P_1)
	{
		return P_0.CompareTo(P_1);
	}

	static bool _200C_200C_202C_202A_206C_202C_206E_202D_206F_206A_206A_206A_202A_202B_200D_202D_206E_206C_200B_200D_206E_200C_202D_200D_200E_202C_200B_202B_202C_206E_202B_206B_206E_200F_200C_202B_202A_202B_202E_206B_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static void _202B_200B_206A_200C_206A_202A_206A_206B_200F_206F_200B_206C_202B_206F_202D_202C_200B_200E_200D_200C_206F_200E_200F_200D_200B_200F_202C_202E_202C_200E_202C_206F_202B_206A_202B_202E_202A_202B_202A_202C_202E(Graphic P_0, Color P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.color = P_1;
	}

	static string _206F_206C_200F_206A_200F_206B_200E_202A_206C_202B_202A_206D_206E_202E_202B_206F_206D_200D_206E_206C_206D_206D_200F_200C_202D_200D_202B_202D_202E_202E_202B_206B_206B_206C_200C_202D_206F_200C_200C_202E_202E(Object P_0)
	{
		return P_0.name;
	}

	static bool _202E_200E_206D_202B_206C_200B_206F_202C_206A_206C_202A_200D_206B_206E_202A_200F_200B_206B_206D_206F_200C_200C_200D_206F_200E_200E_206A_202B_202B_202E_202A_206A_202E_202C_206E_202D_200B_200B_200D_202B_202E(string P_0, string P_1)
	{
		return P_0 == P_1;
	}

	static Transform _200F_200E_206E_206A_202C_206E_200F_206C_206D_206A_206D_206C_202A_206F_206E_200B_202B_206A_202D_206A_206B_200E_202A_206A_206C_202C_202B_202B_206A_206C_200F_202D_200B_200C_202B_200C_206F_206E_200D_202A_202E(Component P_0)
	{
		return P_0.transform;
	}

	static Transform _202E_202C_200E_202B_200F_200B_202C_206C_202D_200E_202A_202B_202C_202A_206C_200D_206C_206E_206F_202B_202C_200D_200C_202C_206B_206F_202C_200C_202A_202E_206F_200B_202A_202D_206C_202E_202D_200D_202A_206C_202E(Transform P_0, string P_1)
	{
		return P_0.FindChild(P_1);
	}

	static void _206A_202D_206E_200F_202D_206B_202D_200B_206B_206B_206D_200F_206B_202E_200F_202C_200F_206A_206D_202A_200D_200D_200D_206E_202E_202D_206E_202D_206B_206F_206F_202B_200F_206C_202C_206E_202E_200E_206F_202A_202E(Text P_0, Font P_1)
	{
		P_0.font = P_1;
	}

	static string _206B_202D_206B_206E_206D_200B_206E_202B_202B_206C_202C_200B_200C_202C_206E_200C_206B_202E_200C_200E_206B_206E_206F_202E_200D_202A_206E_200D_202B_200C_206B_202D_200F_200B_202C_202D_202A_206B_206B_200C_202E()
	{
		return Application.loadedLevelName;
	}

	static GameObject _206F_202B_206E_200E_206F_200C_202D_206E_200D_206E_206A_202D_206C_206E_206E_202D_200E_200B_202D_202A_206E_200E_206A_202C_202E_206B_202A_202D_206F_206B_202B_206A_206F_202A_202A_200B_206D_202C_202E_206B_202E(Component P_0)
	{
		return P_0.gameObject;
	}

	static void _200F_202A_206A_206E_200E_202B_200E_202B_200F_206B_202C_200E_200E_206B_200D_200D_200D_206F_200F_202C_202E_206B_202C_206E_206E_206A_200D_202C_206C_206A_206F_200B_202E_202C_200C_200C_206B_206E_202E_206A_202E(Object P_0, string P_1)
	{
		P_0.name = P_1;
	}

	static Transform _206F_206C_202B_200C_202C_202E_200C_200F_200F_200C_206D_206C_202A_206A_202C_202D_206E_206C_202A_202E_202C_200D_206E_202D_200C_200F_200B_206D_206C_202C_206A_202A_206C_206A_206F_206A_202D_206B_206D_200C_202E(GameObject P_0)
	{
		return P_0.transform;
	}

	static void _200F_206C_202D_206C_206E_206D_206C_202B_202B_202D_202A_202B_200F_200D_206A_202B_206F_200C_202E_202B_206B_202D_202C_200C_200D_206B_202C_202D_200C_200E_202D_200D_200C_206E_206B_202A_202D_200C_200E_202C_202E(Text P_0, string P_1)
	{
		P_0.text = P_1;
	}

	static Transform _206E_202B_200F_202B_206F_202C_206A_200E_206D_206D_200C_200B_206B_200B_200E_202D_206F_206F_206C_202D_206C_200E_200C_200D_206A_206C_206A_200F_200F_206C_202C_206F_206A_202D_206B_200F_200C_200B_200C_200E_202E(Component P_0)
	{
		return P_0.transform;
	}

	static Transform _200C_200B_200E_206F_206C_200C_200F_202A_200B_206B_202B_206F_202C_200B_202A_202C_206B_202A_206A_200C_202C_202A_202E_202E_202A_200D_202A_206A_200C_202B_200F_200F_206C_200F_206A_206C_200E_200B_202A_202D_202E(Transform P_0)
	{
		return P_0.parent;
	}

	static void _206F_206F_202D_200F_206C_206A_200D_202D_202C_200E_206E_202B_206D_202A_206E_202B_206D_202E_200F_202A_202B_202A_206F_200B_206F_206B_200D_202C_200D_206A_202D_206E_202D_202A_202C_202A_200E_202A_206F_202E(Transform P_0, Transform P_1)
	{
		P_0.SetParent(P_1);
	}
}
