using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JyGame;
using UnityEngine;
using UnityEngine.UI;

public class ShopUI : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _202A_200D_206B_202C_202C_206B_200D_206D_202E_200E_202C_202B_202D_202A_200B_206C_206D_200E_206B_200B_200D_206D_200F_206C_206A_200C_206B_202C_200F_202C_206D_200B_206C_202A_206E_200F_202B_206F_206B_200E_202E
	{
		internal ItemInstance item;

		internal ShopUI _202A_202B_206D_202D_200C_202E_206F_200C_202B_202E_202E_206E_200D_206A_206F_206D_206F_200E_202C_206F_200B_206D_206B_202D_206C_206A_200D_200D_206D_200F_200F_206B_202A_202D_202A_200B_200F_200B_202C_202E_202E;

		internal void _202B_200C_202D_202E_200E_202D_202C_200F_200D_200C_206F_200E_206C_202D_200F_206B_200F_206C_206A_206F_200F_206A_200C_200B_206D_202B_200F_202E_200F_206F_200E_206F_200E_202D_200E_200D_200F_206F_206A_202D_202E()
		{
			_202A_202B_206D_202D_200C_202E_206F_200C_202B_202E_202E_206E_200D_206A_206F_206D_206F_200E_202C_206F_200B_206D_206B_202D_206C_206A_200D_200D_206D_200F_200F_206B_202A_202D_202A_200B_200F_200B_202C_202E_202E.BuySale(item);
		}
	}

	[CompilerGenerated]
	private sealed class _206D_200B_206C_200E_202E_202A_206B_206B_200D_206C_206A_206B_200B_202A_202E_202D_202E_202C_206C_202D_206F_202A_202A_200E_202E_206C_202D_200D_202C_206B_202B_200D_202B_206D_202C_200D_202E_202B_200D_206B_202E
	{
		internal int price;

		internal ItemInstance item;

		internal ShopUI _202A_202B_206D_202D_200C_202E_206F_200C_202B_202E_202E_206E_200D_206A_206F_206D_206F_200E_202C_206F_200B_206D_206B_202D_206C_206A_200D_200D_206D_200F_200F_206B_202A_202D_202A_200B_200F_200B_202C_202E_202E;

		internal void _206C_202D_200C_206B_206B_200C_206A_202B_202A_200F_206B_200B_200E_206E_206F_200E_206D_200D_206F_200F_202D_202D_202D_202D_200C_200E_200D_202D_200C_206A_202D_206B_206C_202B_200D_206B_200F_200D_202B_200D_202E()
		{
			RuntimeData.Instance.Money += price;
			RuntimeData.Instance.addItem(item, -1);
			AudioManager.Instance.PlayEffect(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2472008757u));
			_202A_202B_206D_202D_200C_202E_206F_200C_202B_202E_202E_206E_200D_206A_206F_206D_206F_200E_202C_206F_200B_206D_206B_202D_206C_206A_200D_200D_206D_200F_200F_206B_202A_202D_202A_200B_200F_200B_202C_202E_202E.Show(ShopStatus.SELL);
		}

		internal void _206A_200C_200C_202B_202B_202D_200D_206F_200E_202B_202C_206D_200D_200E_200B_206C_200C_200B_202E_202C_206A_206A_200D_200E_200E_200B_206D_206A_202C_202A_200D_206D_206F_206F_202A_200D_206D_200C_200B_202E_202E()
		{
			int num = RuntimeData.Instance.Items[item];
			RuntimeData.Instance.Money += price * num;
			RuntimeData.Instance.addItem(item, -num);
			while (true)
			{
				int num2 = -1137326103;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num2 ^ -975925461)) % 4)
					{
					case 0u:
						break;
					default:
						return;
					case 2u:
						AudioManager.Instance.PlayEffect(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2472008757u));
						num2 = ((int)num3 * -1974023286) ^ -296168968;
						continue;
					case 3u:
						_202A_202B_206D_202D_200C_202E_206F_200C_202B_202E_202E_206E_200D_206A_206F_206D_206F_200E_202C_206F_200B_206D_206B_202D_206C_206A_200D_200D_206D_200F_200F_206B_202A_202D_202A_200B_200F_200B_202C_202E_202E.Show(ShopStatus.SELL);
						num2 = ((int)num3 * -687280010) ^ 0x7C00CA58;
						continue;
					case 1u:
						return;
					}
					break;
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class _202E_200D_200B_206B_200E_206E_206F_206D_200C_200B_206A_202C_202A_200D_200D_200D_206B_206F_200C_206B_206A_200E_200B_202C_206E_200C_202D_206C_202E_202D_200D_202A_202A_200D_206F_200F_202C_206B_202D_206E_202E
	{
		internal ItemInstance item;

		internal ShopUI _202A_202B_206D_202D_200C_202E_206F_200C_202B_202E_202E_206E_200D_206A_206F_206D_206F_200E_202C_206F_200B_206D_206B_202D_206C_206A_200D_200D_206D_200F_200F_206B_202A_202D_202A_200B_200F_200B_202C_202E_202E;

		internal void _206B_202C_200D_206B_202D_206E_206B_200B_206E_200F_200B_206E_202C_206A_202D_200D_206F_206B_206A_200C_200E_202D_206F_206D_202B_202A_200B_206F_202C_200F_202D_206E_202E_206E_200D_200F_200D_206C_200D_200F_202E()
		{
			RuntimeData.Instance.xiangziAddItem(item, -1);
			RuntimeData.Instance.addItem(item);
			AudioManager.Instance.PlayEffect(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3725734096u));
			_202A_202B_206D_202D_200C_202E_206F_200C_202B_202E_202E_206E_200D_206A_206F_206D_206F_200E_202C_206F_200B_206D_206B_202D_206C_206A_200D_200D_206D_200F_200F_206B_202A_202D_202A_200B_200F_200B_202C_202E_202E.Show(ShopStatus.XIANGZI_GET);
		}
	}

	[CompilerGenerated]
	private sealed class _202B_206A_200C_206C_206E_200E_200C_200E_202A_202B_202A_206A_202C_200C_202A_200F_206D_206B_206C_200C_206E_206A_200F_200C_206B_202A_200C_200B_202D_202A_202D_206E_200F_202D_200B_200F_202C_206C_202E_206C_202E
	{
		internal ItemInstance item;

		internal ShopUI _202A_202B_206D_202D_200C_202E_206F_200C_202B_202E_202E_206E_200D_206A_206F_206D_206F_200E_202C_206F_200B_206D_206B_202D_206C_206A_200D_200D_206D_200F_200F_206B_202A_202D_202A_200B_200F_200B_202C_202E_202E;

		internal void _202D_206B_206A_202E_202E_202E_200E_206B_200B_202C_202D_200C_206F_206F_202C_206B_200B_202C_206C_206A_200B_202E_200F_206A_200C_202D_200B_200B_202A_202C_202A_206A_202A_200E_200F_206E_200C_200E_202E_202E()
		{
			RuntimeData.Instance.xiangziAddItem(item);
			while (true)
			{
				int num = -1642374384;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1870702545)) % 4)
					{
					case 0u:
						break;
					default:
						return;
					case 3u:
						RuntimeData.Instance.addItem(item, -1);
						num = (int)(num2 * 2087789309) ^ -941902238;
						continue;
					case 2u:
						AudioManager.Instance.PlayEffect(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(56973850u));
						_202A_202B_206D_202D_200C_202E_206F_200C_202B_202E_202E_206E_200D_206A_206F_206D_206F_200E_202C_206F_200B_206D_206B_202D_206C_206A_200D_200D_206D_200F_200F_206B_202A_202D_202A_200B_200F_200B_202C_202E_202E.Show(ShopStatus.XIANGZI_PUT);
						num = (int)(num2 * 1213462599) ^ -1746513316;
						continue;
					case 1u:
						return;
					}
					break;
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class _206C_202A_206C_202B_200C_200E_200F_206A_202E_200F_202C_200B_202C_202C_202E_202B_206D_206F_206B_202E_202B_200D_202B_202C_206F_206C_200C_202A_200B_202E_200E_206E_206E_200E_206F_200B_200C_200E_200C_206F_202E
	{
		public ItemInstance item;

		public ShopUI _202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E;

		internal void _206B_202C_202A_202A_200E_200B_202A_200E_200F_200F_200B_206C_206A_202E_206D_200C_200D_200B_200B_206C_202C_202D_202A_202B_200E_202B_202D_202B_202A_202C_202D_202D_200F_200C_202A_206B_202C_206E_206B_200F_202E()
		{
			_202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E.BuySale(item);
		}
	}

	[CompilerGenerated]
	private sealed class _206C_202B_206E_202A_200F_202D_200D_206D_206C_200B_202C_206F_206D_200B_206D_202D_200C_202E_200F_202B_206C_206E_200B_206E_200C_206F_206E_206B_206D_200B_200D_200C_200C_200F_202A_206D_200C_202D_200D_200F_202E
	{
		public int price;

		public ItemInstance item;

		public ShopUI _202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E;

		internal void _200E_206D_200F_202B_202A_200E_200C_202A_206C_206F_200F_202E_206F_206C_200B_200C_200F_200D_200E_206E_202C_200B_202B_206A_200D_200E_206E_200B_206B_200B_206E_202D_202B_200D_200D_202A_202A_206A_206D_206E_202E()
		{
			RuntimeData.Instance.Money += price;
			while (true)
			{
				int num = 1496832598;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x51DF79E4)) % 3)
					{
					case 0u:
						break;
					case 2u:
						goto IL_0039;
					default:
						AudioManager.Instance.PlayEffect(ResourceStrings.ResStrings[17]);
						_202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E.RefreshXiangzi(item, ShopStatus.SELL);
						return;
					}
					break;
					IL_0039:
					RuntimeData.Instance.addItem(item, -1);
					num = (int)((num2 * 318672330) ^ 0x5EBEEBE5);
				}
			}
		}

		internal void _200B_202C_206F_206A_200C_200D_200E_206C_202D_206A_200E_206D_202E_206E_202E_206B_206C_206D_206A_206C_206D_206A_200E_206F_200F_206A_206C_202A_202C_202A_202D_202B_202C_206F_200E_200F_202C_202C_206B_206E_202E()
		{
			int num = RuntimeData.Instance.Items[item];
			while (true)
			{
				int num2 = 44272683;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num2 ^ 0x700FDB2)) % 5)
					{
					case 3u:
						break;
					default:
						return;
					case 4u:
						num = RuntimeData.Instance.num_decode(num);
						num2 = ((int)num3 * -1441592687) ^ -266189757;
						continue;
					case 0u:
						RuntimeData.Instance.addItem(item, -num);
						AudioManager.Instance.PlayEffect(ResourceStrings.ResStrings[17]);
						_202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E.RefreshXiangzi(item, ShopStatus.SELL);
						num2 = (int)((num3 * 698735819) ^ 0x6C765374);
						continue;
					case 1u:
						RuntimeData.Instance.Money += price * num;
						num2 = ((int)num3 * -2081763324) ^ -1397867827;
						continue;
					case 2u:
						return;
					}
					break;
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class _200C_206D_206B_200B_200E_200C_200C_206D_202C_202D_202E_206D_202D_206D_200F_202D_200D_200B_202A_200B_200F_202B_200C_202B_206C_200B_200C_200D_206F_206B_202A_206E_202D_202E_202E_200C_202A_200D_202A_200C_202E
	{
		public ItemInstance item;

		public ShopUI _202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E;

		internal void _206E_206F_206E_206E_200D_206A_202C_206D_202E_206D_200D_200C_200F_206C_206F_206F_202A_200C_200D_200D_206B_206A_200F_200B_200F_200F_206C_206F_200E_202D_200F_206C_200B_200C_200F_206C_200E_200C_200B_200C_202E()
		{
			RuntimeData.Instance.xiangziAddItem(item, -1);
			RuntimeData.Instance.addItem(item);
			while (true)
			{
				int num = -1819891313;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1977841705)) % 3)
					{
					case 0u:
						break;
					case 1u:
						goto IL_0044;
					default:
						_202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E.RefreshXiangzi(item, ShopStatus.XIANGZI_GET);
						return;
					}
					break;
					IL_0044:
					AudioManager.Instance.PlayEffect(ResourceStrings.ResStrings[17]);
					num = ((int)num2 * -1350868502) ^ -1474988084;
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class _202D_206F_206A_200D_206F_206F_202D_206A_200B_206F_200E_206F_206F_206E_200D_206E_200D_200F_200D_200D_200F_206E_206C_202C_200F_200E_206E_202E_202E_202D_200E_202C_206B_200D_200C_202B_206A_206E_206F_202E_202E
	{
		public ItemInstance item;

		public ShopUI _202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E;

		internal void _202D_202D_206B_202A_202A_202C_206A_200E_206B_202B_206A_206D_200F_206D_200C_200C_202A_206C_200F_202A_200F_206E_202E_206D_200F_200C_200C_200C_206D_206C_200F_206F_206A_202B_202A_202C_206B_200D_202A_202C_202E()
		{
			RuntimeData.Instance.xiangziAddItem(item);
			RuntimeData.Instance.addItem(item, -1);
			while (true)
			{
				int num = -1981404495;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -925759843)) % 3)
					{
					case 2u:
						break;
					case 1u:
						goto IL_0044;
					default:
						_202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E.RefreshXiangzi(item, ShopStatus.XIANGZI_PUT);
						return;
					}
					break;
					IL_0044:
					AudioManager.Instance.PlayEffect(ResourceStrings.ResStrings[17]);
					num = ((int)num2 * -280026590) ^ -1684192974;
				}
			}
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _202D_200E_206C_202E_202A_202E_206C_200E_200F_206B_206E_206F_206E_206C_206A_200F_200B_206B_206B_200F_206F_202B_200B_202E_200F_202E_202E_206E_200B_206B_200B_206D_206E_206F_202D_206B_202B_206A_202E_202B_202E
	{
		public static readonly _202D_200E_206C_202E_202A_202E_206C_200E_200F_206B_206E_206F_206E_206C_206A_200F_200B_206B_206B_200F_206F_202B_200B_202E_200F_202E_202E_206E_200B_206B_200B_206D_206E_206F_202D_206B_202B_206A_202E_202B_202E _003C_003E9 = new _202D_200E_206C_202E_202A_202E_206C_200E_200F_206B_206E_206F_206E_206C_206A_200F_200B_206B_206B_200F_206F_202B_200B_202E_200F_202E_202E_206E_200B_206B_200B_206D_206E_206F_202D_206B_202B_206A_202E_202B_202E();

		public static CommonSettings.JudgeCallback _003C_003E9__0_7;

		public static CommonSettings.JudgeCallback _003C_003E9__0_12;

		internal bool _206C_206B_202C_206B_202C_200C_206C_206E_206F_200B_202B_206B_200E_200D_200E_200E_200B_200D_206C_206D_202D_206F_200C_200C_202C_202A_202D_202C_202C_206A_200D_200B_206B_200E_202C_206D_206F_206C_206B_202C_202E(object P_0)
		{
			return (P_0 as ItemInstance).price / 2 > 0;
		}

		internal bool _202C_206D_200F_206A_206D_200E_206F_200C_200B_200E_206E_200C_206F_202E_200E_200F_206F_206A_202D_206D_206A_202E_202D_200D_202E_206E_202D_206B_206D_206A_206D_202A_200F_202A_206A_206B_206A_202E_202B_206D_202E(object P_0)
		{
			ItemInstance obj = P_0 as ItemInstance;
			int box = obj.GetItem().box;
			if (obj.Type == ItemType.Mission)
			{
				while (true)
				{
					int num = 1646950336;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ 0x24E0A58D)) % 4)
						{
						case 2u:
							break;
						case 1u:
						{
							int num3;
							int num4;
							if (box != 1)
							{
								num3 = -1674179279;
								num4 = num3;
							}
							else
							{
								num3 = -476070434;
								num4 = num3;
							}
							num = num3 ^ ((int)num2 * -1055188389);
							continue;
						}
						case 0u:
							goto end_IL_001a;
						default:
							return false;
						}
						break;
					}
					continue;
					end_IL_001a:
					break;
				}
			}
			return box != -1;
		}
	}

	public static Shop CurrentShop;

	public static ShopType Type;

	public GameObject BackgroundObj;

	public GameObject BuyButtonTextObj;

	public GameObject SellButtonTextObj;

	public GameObject ItemMenuObj;

	public GameObject InfoTextObj;

	public GameObject MoneyTextObj;

	public GameObject YuanbaoTextObj;

	public GameObject ItemDetailPanelObj;

	public GameObject MessageBoxObj;

	public GameObject OneKeyBuySellToggleObj;

	private ShopStatus CurrentStatus;

	[CompilerGenerated]
	private static CommonSettings.JudgeCallback _206F_202B_202C_206A_202E_206C_206B_202A_202D_206D_206D_206F_206D_200B_200F_202C_206C_200C_202D_200F_200C_206E_200E_202D_206A_202E_206B_202B_200B_206A_202D_206A_202C_202E_202C_200D_200C_206F_202E_206D_202E;

	[CompilerGenerated]
	private static CommonSettings.JudgeCallback _206B_206B_202D_202E_206A_206A_200D_202E_200C_200C_200F_200B_202D_202C_202A_202A_206D_206D_202B_200D_206D_200F_202A_206A_200F_206E_200C_200B_206C_206E_202A_202B_206E_200E_200B_200F_206A_200C_206C_206A_202E;

	private GameObject buttonExit;

	private ItemMenu itemMenu => ItemMenuObj.GetComponent<ItemMenu>();

	private Text infoText => InfoTextObj.GetComponent<Text>();

	private ItemSkillDetailPanelUI itemDetailPanel => ItemDetailPanelObj.GetComponent<ItemSkillDetailPanelUI>();

	private MessageBoxUI messageBox => MessageBoxObj.GetComponent<MessageBoxUI>();

	private bool IsOneKeyBuySell => _202B_202B_200F_202A_206B_200F_206D_206C_206D_200F_202C_206C_202E_206F_206E_206B_206D_202E_206E_200F_200C_206F_200F_202A_200D_202B_200C_206B_206B_206D_206A_200D_206F_206C_206B_202E_200D_200F_200F_206D_202E(OneKeyBuySellToggleObj.GetComponent<Toggle>());

	static ShopUI()
	{
	}

	private void ShowMoney()
	{
		MoneyTextObj.GetComponent<Text>().text = RuntimeData.Instance.Money.ToString();
		while (true)
		{
			int num = -827207051;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1876611584)) % 4)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					YuanbaoTextObj.GetComponent<Text>().text = RuntimeData.Instance.Yuanbao.ToString();
					num = (int)(num2 * 849387605) ^ -418454870;
					continue;
				case 3u:
					((MonoBehaviour)this).Invoke(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4247151745u), 0f);
					num = ((int)num2 * -2058920304) ^ -98023568;
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void BuySale(ItemInstance item)
	{
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		RuntimeData instance = RuntimeData.Instance;
		int num8 = default(int);
		int num3 = default(int);
		ShopSale sale = default(ShopSale);
		while (true)
		{
			int num = 1451603018;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5357B1CB)) % 16)
				{
				case 15u:
					break;
				case 3u:
					instance.addItem(item);
					num = (int)((num2 * 1191597145) ^ 0x71C4497);
					continue;
				case 10u:
				{
					int num11;
					int num12;
					if (instance.Money >= num8)
					{
						num11 = 819164145;
						num12 = num11;
					}
					else
					{
						num11 = 831079715;
						num12 = num11;
					}
					num = num11 ^ ((int)num2 * -1597698209);
					continue;
				}
				case 7u:
					AudioManager.Instance.PlayEffect(ResourceStrings.ResStrings[17]);
					num = ((int)num2 * -2001598634) ^ -1435416825;
					continue;
				case 6u:
					CurrentShop.BuyItem(item.Name);
					num = ((int)num2 * -1152837597) ^ 0x252692C1;
					continue;
				case 14u:
					messageBox.Show(ResourceStrings.ResStrings[1182], string.Format(ResourceStrings.ResStrings[1183], num8.ToString()), Color.white, null, ResourceStrings.ResStrings[75]);
					infoText.text = ResourceStrings.ResStrings[1187];
					num = (int)(num2 * 472380739) ^ -545468924;
					continue;
				case 9u:
					instance.Money -= num8;
					num = 782338736;
					continue;
				case 5u:
					return;
				case 13u:
					messageBox.Show(ResourceStrings.ResStrings[1182], string.Format(ResourceStrings.ResStrings[1184], num3.ToString()), Color.white, null, ResourceStrings.ResStrings[75]);
					infoText.text = ResourceStrings.ResStrings[1187];
					return;
				case 1u:
					sale = CurrentShop.GetSale(item);
					num = ((int)num2 * -1037043029) ^ -42164332;
					continue;
				case 4u:
				{
					num8 = _200C_202B_202A_200F_202C_206E_206D_200E_200E_200C_206F_206E_202D_202A_200B_206D_206C_200D_200C_200F_202B_202E_206C_200D_200F_200C_202A_200D_206C_200B_206D_200D_202C_206F_202C_206F_206F_200F_200E_206E_202E(0, sale.price);
					int num9;
					int num10;
					if (num8 <= 0)
					{
						num9 = -2021782913;
						num10 = num9;
					}
					else
					{
						num9 = -1303424007;
						num10 = num9;
					}
					num = num9 ^ (int)(num2 * 1780600106);
					continue;
				}
				case 11u:
					instance.Yuanbao -= num3;
					num = ((int)num2 * -1727302472) ^ 0x1F1CB3E0;
					continue;
				case 2u:
				{
					int num6;
					int num7;
					if (num3 > 0)
					{
						num6 = 147053263;
						num7 = num6;
					}
					else
					{
						num6 = 820192454;
						num7 = num6;
					}
					num = num6 ^ ((int)num2 * -2061368854);
					continue;
				}
				case 12u:
					num3 = Math.Max(0, sale.yuanbao);
					num = 777441849;
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (instance.Yuanbao >= num3)
					{
						num4 = -1567876046;
						num5 = num4;
					}
					else
					{
						num4 = -1504200186;
						num5 = num4;
					}
					num = num4 ^ ((int)num2 * -1972622348);
					continue;
				}
				default:
					Show(ShopStatus.BUY);
					return;
				}
				break;
			}
		}
	}

	private void Show(ShopStatus status)
	{
		ShowMoney();
		CurrentStatus = status;
		Dictionary<ItemInstance, int> avaliableSales = default(Dictionary<ItemInstance, int>);
		while (true)
		{
			int num = 608814757;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x784A0770)) % 24)
				{
				case 19u:
					break;
				default:
					return;
				case 1u:
					_202B_200E_206E_200C_206F_202B_200F_200C_206C_200C_200F_200E_202D_202B_206C_202A_200B_202E_200D_206F_206F_202D_202B_206F_206C_206E_206D_206C_206E_206D_206B_202B_200B_206E_202B_202D_206B_200D_200E_200C_202E(OneKeyBuySellToggleObj, true);
					num = (int)((num2 * 865144353) ^ 0x556FC5CC);
					continue;
				case 12u:
					_206A_200C_200E_202A_202D_206B_202D_202B_200C_202A_202E_200D_202D_206B_206E_206E_202C_206F_206F_206F_202B_200F_202B_206A_206A_202C_206D_200C_206B_202C_202D_200F_200C_202A_202E_200D_206E_202B_202A_200D_202E(infoText, ResourceStrings.ResStrings[1190]);
					itemMenu.ShowLoader(string.Empty, RuntimeData.Instance.Items, delegate(object P_0)
					{
						int price = default(int);
						ItemInstance item = default(ItemInstance);
						ShopUI shopUI = default(ShopUI);
						while (true)
						{
							int num10 = 12290305;
							while (true)
							{
								uint num11;
								switch ((num11 = (uint)(num10 ^ 0x1B95F1A2)) % 10)
								{
								case 7u:
									break;
								case 5u:
									RuntimeData.Instance.Money += price;
									RuntimeData.Instance.addItem(item, -1);
									AudioManager.Instance.PlayEffect(ResourceStrings.ResStrings[17]);
									num10 = (int)((num11 * 780507076) ^ 0x2EAC74B3);
									continue;
								case 0u:
								{
									price = item.price / 2;
									int num13;
									int num14;
									if (price > 0)
									{
										num13 = -225039569;
										num14 = num13;
									}
									else
									{
										num13 = -2055270144;
										num14 = num13;
									}
									num10 = num13 ^ (int)(num11 * 1211711858);
									continue;
								}
								case 9u:
									RefreshXiangzi(item, ShopStatus.SELL);
									num10 = (int)((num11 * 1313756535) ^ 0x5DB1EFE5);
									continue;
								case 4u:
									return;
								case 3u:
								{
									int num12;
									if (!IsOneKeyBuySell)
									{
										num10 = 2096580078;
										num12 = num10;
									}
									else
									{
										num10 = 684190647;
										num12 = num10;
									}
									continue;
								}
								case 1u:
									shopUI = this;
									item = P_0 as ItemInstance;
									num10 = ((int)num11 * -251136913) ^ -501376699;
									continue;
								case 8u:
									AudioManager.Instance.PlayEffect(ResourceStrings.ResStrings[1163]);
									num10 = ((int)num11 * -1524327916) ^ -45209934;
									continue;
								case 6u:
									return;
								default:
									_206A_200C_200E_202A_202D_206B_202D_202B_200C_202A_202E_200D_202D_206B_206E_206E_202C_206F_206F_206F_202B_200F_202B_206A_206A_202C_206D_200C_206B_202C_202D_200F_200C_202A_202E_200D_206E_202B_202A_200D_202E(infoText, _206F_202B_200B_200B_200D_206A_206F_206E_202A_200F_200C_202A_202E_200B_200B_206A_206D_200B_206F_202A_200E_200F_202E_206C_200B_206C_202C_206D_202D_206B_202E_202B_206A_200B_202D_202D_200D_200F_202B_206B_202E(ResourceStrings.ResStrings[1191], (object)price));
									itemDetailPanel.Show(item, ItemDetailMode.Sellable, delegate
									{
										RuntimeData.Instance.Money += price;
										while (true)
										{
											int num15 = 1496832598;
											while (true)
											{
												uint num16;
												switch ((num16 = (uint)(num15 ^ 0x51DF79E4)) % 3)
												{
												case 0u:
													break;
												case 2u:
													goto IL_0039;
												default:
													AudioManager.Instance.PlayEffect(ResourceStrings.ResStrings[17]);
													shopUI.RefreshXiangzi(item, ShopStatus.SELL);
													return;
												}
												break;
												IL_0039:
												RuntimeData.Instance.addItem(item, -1);
												num15 = (int)((num16 * 318672330) ^ 0x5EBEEBE5);
											}
										}
									}, delegate
									{
										_206A_200C_200E_202A_202D_206B_202D_202B_200C_202A_202E_200D_202D_206B_206E_206E_202C_206F_206F_206F_202B_200F_202B_206A_206A_202C_206D_200C_206B_202C_202D_200F_200C_202A_202E_200D_206E_202B_202A_200D_202E(infoText, ResourceStrings.ResStrings[1190]);
									}, delegate
									{
										int num15 = RuntimeData.Instance.Items[item];
										while (true)
										{
											int num16 = 44272683;
											while (true)
											{
												uint num17;
												switch ((num17 = (uint)(num16 ^ 0x700FDB2)) % 5)
												{
												case 3u:
													break;
												default:
													return;
												case 4u:
													num15 = RuntimeData.Instance.num_decode(num15);
													num16 = ((int)num17 * -1441592687) ^ -266189757;
													continue;
												case 0u:
													RuntimeData.Instance.addItem(item, -num15);
													AudioManager.Instance.PlayEffect(ResourceStrings.ResStrings[17]);
													shopUI.RefreshXiangzi(item, ShopStatus.SELL);
													num16 = (int)((num17 * 698735819) ^ 0x6C765374);
													continue;
												case 1u:
													RuntimeData.Instance.Money += price * num15;
													num16 = ((int)num17 * -2081763324) ^ -1397867827;
													continue;
												case 2u:
													return;
												}
												break;
											}
										}
									});
									return;
								}
								break;
							}
						}
					}, null, (object P_0) => (P_0 as ItemInstance).price / 2 > 0, dynamic: true, realCount: false);
					return;
				case 23u:
					itemMenu.ShowLoader(string.Empty, avaliableSales, delegate(object P_0)
					{
						ItemInstance item = default(ItemInstance);
						ShopUI shopUI = default(ShopUI);
						while (true)
						{
							int num10 = 53532006;
							while (true)
							{
								uint num11;
								switch ((num11 = (uint)(num10 ^ 0x550D9DE1)) % 6)
								{
								case 0u:
									break;
								default:
									return;
								case 1u:
									itemDetailPanel.Show(item, ItemDetailMode.Selectable, delegate
									{
										shopUI.BuySale(item);
									}, delegate
									{
										_206A_200C_200E_202A_202D_206B_202D_202B_200C_202A_202E_200D_202D_206B_206E_206E_202C_206F_206F_206F_202B_200F_202B_206A_206A_202C_206D_200C_206B_202C_202D_200F_200C_202A_202E_200D_206E_202B_202A_200D_202E(infoText, ResourceStrings.ResStrings[1187]);
									});
									num10 = 543839620;
									continue;
								case 2u:
								{
									item = P_0 as ItemInstance;
									ShopSale sale = CurrentShop.GetSale(item);
									_206A_200C_200E_202A_202D_206B_202D_202B_200C_202A_202E_200D_202D_206B_206E_206E_202C_206F_206F_206F_202B_200F_202B_206A_206A_202C_206D_200C_206B_202C_202D_200F_200C_202A_202E_200D_206E_202B_202A_200D_202E(infoText, sale.GetPriceInfo());
									int num12;
									int num13;
									if (IsOneKeyBuySell)
									{
										num12 = 1540220699;
										num13 = num12;
									}
									else
									{
										num12 = 204866456;
										num13 = num12;
									}
									num10 = num12 ^ (int)(num11 * 1930533471);
									continue;
								}
								case 3u:
									shopUI = this;
									num10 = ((int)num11 * -827934296) ^ -828405135;
									continue;
								case 4u:
									BuySale(item);
									return;
								case 5u:
									return;
								}
								break;
							}
						}
					}, null, null, dynamic: false, realCount: true);
					num = ((int)num2 * -1634153107) ^ -1799044066;
					continue;
				case 3u:
					_206A_200C_200E_202A_202D_206B_202D_202B_200C_202A_202E_200D_202D_206B_206E_206E_202C_206F_206F_206F_202B_200F_202B_206A_206A_202C_206D_200C_206B_202C_202D_200F_200C_202A_202E_200D_206E_202B_202A_200D_202E(infoText, ResourceStrings.ResStrings[1187]);
					num = ((int)num2 * -1925772285) ^ -2146710129;
					continue;
				case 8u:
					itemMenu.ShowLoader(string.Empty, RuntimeData.Instance.Items, delegate(object P_0)
					{
						_202D_206F_206A_200D_206F_206F_202D_206A_200B_206F_200E_206F_206F_206E_200D_206E_200D_200F_200D_200D_200F_206E_206C_202C_200F_200E_206E_202E_202E_202D_200E_202C_206B_200D_200C_202B_206A_206E_206F_202E_202E obj2 = default(_202D_206F_206A_200D_206F_206F_202D_206A_200B_206F_200E_206F_206F_206E_200D_206E_200D_200F_200D_200D_200F_206E_206C_202C_200F_200E_206E_202E_202E_202D_200E_202C_206B_200D_200C_202B_206A_206E_206F_202E_202E);
						int box = default(int);
						if (RuntimeData.Instance.XiangziCount < RuntimeData.Instance.MaxXiangziItemCount)
						{
							while (true)
							{
								int num10 = -266831223;
								while (true)
								{
									uint num11;
									switch ((num11 = (uint)(num10 ^ -1964965105)) % 14)
									{
									case 2u:
										break;
									default:
										return;
									case 9u:
										return;
									case 7u:
										obj2.item = P_0 as ItemInstance;
										box = obj2.item.GetItem().box;
										num10 = (int)((num11 * 1904844570) ^ 0x510C00BF);
										continue;
									case 0u:
									{
										int num15;
										int num16;
										if (obj2.item.Type == ItemType.Mission)
										{
											num15 = -956432905;
											num16 = num15;
										}
										else
										{
											num15 = -24038807;
											num16 = num15;
										}
										num10 = num15 ^ ((int)num11 * -67835571);
										continue;
									}
									case 11u:
										RuntimeData.Instance.xiangziAddItem(obj2.item);
										num10 = (int)((num11 * 1306628272) ^ 0x57D987C5);
										continue;
									case 10u:
									{
										int num13;
										int num14;
										if (box == 1)
										{
											num13 = 272298351;
											num14 = num13;
										}
										else
										{
											num13 = 1474207492;
											num14 = num13;
										}
										num10 = num13 ^ ((int)num11 * -1465520134);
										continue;
									}
									case 8u:
										return;
									case 6u:
										obj2 = new _202D_206F_206A_200D_206F_206F_202D_206A_200B_206F_200E_206F_206F_206E_200D_206E_200D_200F_200D_200D_200F_206E_206C_202C_200F_200E_206E_202E_202E_202D_200E_202C_206B_200D_200C_202B_206A_206E_206F_202E_202E();
										obj2._202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E = this;
										num10 = (int)(num11 * 1305860142) ^ -1119256774;
										continue;
									case 4u:
									{
										int num17;
										if (box != -1)
										{
											num10 = -678346912;
											num17 = num10;
										}
										else
										{
											num10 = -1048429216;
											num17 = num10;
										}
										continue;
									}
									case 12u:
										RuntimeData.Instance.addItem(obj2.item, -1);
										AudioManager.Instance.PlayEffect(ResourceStrings.ResStrings[17]);
										num10 = ((int)num11 * -1545128194) ^ 0x6C7B3D9E;
										continue;
									case 1u:
										itemDetailPanel.Show(obj2.item, ItemDetailMode.Selectable, obj2._202D_202D_206B_202A_202A_202C_206A_200E_206B_202B_206A_206D_200F_206D_200C_200C_202A_206C_200F_202A_200F_206E_202E_206D_200F_200C_200C_200C_206D_206C_200F_206F_206A_202B_202A_202C_206B_200D_202A_202C_202E);
										num10 = -347419848;
										continue;
									case 3u:
									{
										int num12;
										if (IsOneKeyBuySell)
										{
											num10 = -339614492;
											num12 = num10;
										}
										else
										{
											num10 = -1128040324;
											num12 = num10;
										}
										continue;
									}
									case 5u:
										RefreshXiangzi(obj2.item, ShopStatus.XIANGZI_PUT);
										num10 = (int)(num11 * 1449105639) ^ -1123781374;
										continue;
									case 13u:
										return;
									}
									break;
								}
							}
						}
					}, null, delegate(object P_0)
					{
						ItemInstance obj2 = P_0 as ItemInstance;
						int box = obj2.GetItem().box;
						if (obj2.Type == ItemType.Mission)
						{
							while (true)
							{
								int num10 = 1646950336;
								while (true)
								{
									uint num11;
									switch ((num11 = (uint)(num10 ^ 0x24E0A58D)) % 4)
									{
									case 2u:
										break;
									case 1u:
									{
										int num12;
										int num13;
										if (box != 1)
										{
											num12 = -1674179279;
											num13 = num12;
										}
										else
										{
											num12 = -476070434;
											num13 = num12;
										}
										num10 = num12 ^ ((int)num11 * -1055188389);
										continue;
									}
									case 0u:
										goto end_IL_001a;
									default:
										return false;
									}
									break;
								}
								continue;
								end_IL_001a:
								break;
							}
						}
						return box != -1;
					}, dynamic: true, realCount: false);
					num = 766612559;
					continue;
				case 13u:
					return;
				case 18u:
					_202B_200E_206E_200C_206F_202B_200F_200C_206C_200C_200F_200E_202D_202B_206C_202A_200B_202E_200D_206F_206F_202D_202B_206F_206C_206E_206D_206C_206E_206D_206B_202B_200B_206E_202B_202D_206B_200D_200E_200C_202E(OneKeyBuySellToggleObj, true);
					_206A_200C_200E_202A_202D_206B_202D_202B_200C_202A_202E_200D_202D_206B_206E_206E_202C_206F_206F_206F_202B_200F_202B_206A_206A_202C_206D_200C_206B_202C_202D_200F_200C_202A_202E_200D_206E_202B_202A_200D_202E(((Component)_200E_200C_202A_206C_202E_206A_202A_202E_200D_200B_206D_206F_206C_200D_206F_200C_200D_202E_202A_200B_202B_206D_202E_200F_200B_200E_200B_202C_200F_202A_200D_200B_200C_202A_206B_206F_202B_200B_206D_200D_202E(_202A_206C_202A_206A_202D_202C_202D_206E_206F_200D_206B_200F_206B_200D_200F_206E_206F_206B_206C_200C_200F_206A_202E_206B_206C_206D_206F_206B_202A_206D_202C_206D_202E_206C_206B_202A_200F_200F_202B_206A_202E(OneKeyBuySellToggleObj), global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2180043220u))).GetComponent<Text>(), ResourceStrings.ResStrings[1188]);
					num = (int)((num2 * 890250302) ^ 0x46921856);
					continue;
				case 17u:
				{
					int num6;
					if (status != ShopStatus.SELL)
					{
						num = 1499699478;
						num6 = num;
					}
					else
					{
						num = 550746490;
						num6 = num;
					}
					continue;
				}
				case 16u:
					_206A_200C_200E_202A_202D_206B_202D_202B_200C_202A_202E_200D_202D_206B_206E_206E_202C_206F_206F_206F_202B_200F_202B_206A_206A_202C_206D_200C_206B_202C_202D_200F_200C_202A_202E_200D_206E_202B_202A_200D_202E(((Component)_200E_200C_202A_206C_202E_206A_202A_202E_200D_200B_206D_206F_206C_200D_206F_200C_200D_202E_202A_200B_202B_206D_202E_200F_200B_200E_200B_202C_200F_202A_200D_200B_200C_202A_206B_206F_202B_200B_206D_200D_202E(_202A_206C_202A_206A_202D_202C_202D_206E_206F_200D_206B_200F_206B_200D_200F_206E_206F_206B_206C_200C_200F_206A_202E_206B_206C_206D_206F_206B_202A_206D_202C_206D_202E_206C_206B_202A_200F_200F_202B_206A_202E(OneKeyBuySellToggleObj), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1676532085u))).GetComponent<Text>(), ResourceStrings.ResStrings[1185]);
					_206A_200C_200E_202A_202D_206B_202D_202B_200C_202A_202E_200D_202D_206B_206E_206E_202C_206F_206F_206F_202B_200F_202B_206A_206A_202C_206D_200C_206B_202C_202D_200F_200C_202A_202E_200D_206E_202B_202A_200D_202E(((Component)_200E_200C_202A_206C_202E_206A_202A_202E_200D_200B_206D_206F_206C_200D_206F_200C_200D_202E_202A_200B_202B_206D_202E_200F_200B_200E_200B_202C_200F_202A_200D_200B_200C_202A_206B_206F_202B_200B_206D_200D_202E(_202A_206C_202A_206A_202D_202C_202D_206E_206F_200D_206B_200F_206B_200D_200F_206E_206F_206B_206C_200C_200F_206A_202E_206B_206C_206D_206F_206B_202A_206D_202C_206D_202E_206C_206B_202A_200F_200F_202B_206A_202E(OneKeyBuySellToggleObj), global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4133172483u))).GetComponent<Text>(), ResourceStrings.ResStrings[1186]);
					num = ((int)num2 * -818287003) ^ 0x196E07C3;
					continue;
				case 0u:
				{
					int num9;
					if (status != ShopStatus.XIANGZI_PUT)
					{
						num = 766612559;
						num9 = num;
					}
					else
					{
						num = 906451700;
						num9 = num;
					}
					continue;
				}
				case 5u:
					_206A_200C_200E_202A_202D_206B_202D_202B_200C_202A_202E_200D_202D_206B_206E_206E_202C_206F_206F_206F_202B_200F_202B_206A_206A_202C_206D_200C_206B_202C_202D_200F_200C_202A_202E_200D_206E_202B_202A_200D_202E(((Component)_200E_200C_202A_206C_202E_206A_202A_202E_200D_200B_206D_206F_206C_200D_206F_200C_200D_202E_202A_200B_202B_206D_202E_200F_200B_200E_200B_202C_200F_202A_200D_200B_200C_202A_206B_206F_202B_200B_206D_200D_202E(_202A_206C_202A_206A_202D_202C_202D_206E_206F_200D_206B_200F_206B_200D_200F_206E_206F_206B_206C_200C_200F_206A_202E_206B_206C_206D_206F_206B_202A_206D_202C_206D_202E_206C_206B_202A_200F_200F_202B_206A_202E(OneKeyBuySellToggleObj), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1676532085u))).GetComponent<Text>(), ResourceStrings.ResStrings[1192]);
					_206A_200C_200E_202A_202D_206B_202D_202B_200C_202A_202E_200D_202D_206B_206E_206E_202C_206F_206F_206F_202B_200F_202B_206A_206A_202C_206D_200C_206B_202C_202D_200F_200C_202A_202E_200D_206E_202B_202A_200D_202E(((Component)_200E_200C_202A_206C_202E_206A_202A_202E_200D_200B_206D_206F_206C_200D_206F_200C_200D_202E_202A_200B_202B_206D_202E_200F_200B_200E_200B_202C_200F_202A_200D_200B_200C_202A_206B_206F_202B_200B_206D_200D_202E(_202A_206C_202A_206A_202D_202C_202D_206E_206F_200D_206B_200F_206B_200D_200F_206E_206F_206B_206C_200C_200F_206A_202E_206B_206C_206D_206F_206B_202A_206D_202C_206D_202E_206C_206B_202A_200F_200F_202B_206A_202E(OneKeyBuySellToggleObj), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(569019878u))).GetComponent<Text>(), ResourceStrings.ResStrings[1193]);
					_206A_200C_200E_202A_202D_206B_202D_202B_200C_202A_202E_200D_202D_206B_206E_206E_202C_206F_206F_206F_202B_200F_202B_206A_206A_202C_206D_200C_206B_202C_202D_200F_200C_202A_202E_200D_206E_202B_202A_200D_202E(infoText, _200F_206D_202D_206D_202A_200C_206E_206A_202D_202E_200B_202B_200E_202B_206F_202D_206D_200C_202C_206C_202C_202B_200D_202A_200B_206C_200B_200E_200F_202C_206D_200D_206D_200B_206D_200D_206C_200B_206C_206E_202E(ResourceStrings.ResStrings[1194], (object)RuntimeData.Instance.XiangziCount, (object)RuntimeData.Instance.MaxXiangziItemCount));
					num = (int)(num2 * 834922580) ^ -420082470;
					continue;
				case 21u:
				{
					int num7;
					int num8;
					if (status == ShopStatus.BUY)
					{
						num7 = -1635647588;
						num8 = num7;
					}
					else
					{
						num7 = -389458633;
						num8 = num7;
					}
					num = num7 ^ (int)(num2 * 714908014);
					continue;
				}
				case 4u:
					_206A_200C_200E_202A_202D_206B_202D_202B_200C_202A_202E_200D_202D_206B_206E_206E_202C_206F_206F_206F_202B_200F_202B_206A_206A_202C_206D_200C_206B_202C_202D_200F_200C_202A_202E_200D_206E_202B_202A_200D_202E(infoText, _200F_206D_202D_206D_202A_200C_206E_206A_202D_202E_200B_202B_200E_202B_206F_202D_206D_200C_202C_206C_202C_202B_200D_202A_200B_206C_200B_200E_200F_202C_206D_200D_206D_200B_206D_200D_206C_200B_206C_206E_202E(ResourceStrings.ResStrings[1197], (object)RuntimeData.Instance.XiangziCount, (object)RuntimeData.Instance.MaxXiangziItemCount));
					num = ((int)num2 * -1562180338) ^ -1062991999;
					continue;
				case 2u:
					_206A_200C_200E_202A_202D_206B_202D_202B_200C_202A_202E_200D_202D_206B_206E_206E_202C_206F_206F_206F_202B_200F_202B_206A_206A_202C_206D_200C_206B_202C_202D_200F_200C_202A_202E_200D_206E_202B_202A_200D_202E(((Component)_200E_200C_202A_206C_202E_206A_202A_202E_200D_200B_206D_206F_206C_200D_206F_200C_200D_202E_202A_200B_202B_206D_202E_200F_200B_200E_200B_202C_200F_202A_200D_200B_200C_202A_206B_206F_202B_200B_206D_200D_202E(_202A_206C_202A_206A_202D_202C_202D_206E_206F_200D_206B_200F_206B_200D_200F_206E_206F_206B_206C_200C_200F_206A_202E_206B_206C_206D_206F_206B_202A_206D_202C_206D_202E_206C_206B_202A_200F_200F_202B_206A_202E(OneKeyBuySellToggleObj), global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4133172483u))).GetComponent<Text>(), ResourceStrings.ResStrings[1189]);
					num = ((int)num2 * -987150141) ^ -1098946950;
					continue;
				case 6u:
					avaliableSales = CurrentShop.GetAvaliableSales();
					num = (int)((num2 * 516613577) ^ 0x2DF50DA9);
					continue;
				case 7u:
				{
					Text obj = infoText;
					_206A_200C_200E_202A_202D_206B_202D_202B_200C_202A_202E_200D_202D_206B_206E_206E_202C_206F_206F_206F_202B_200F_202B_206A_206A_202C_206D_200C_206B_202C_202D_200F_200C_202A_202E_200D_206E_202B_202A_200D_202E(obj, _202C_200E_202D_202D_206C_202D_206C_200F_206F_200E_200D_200E_200C_200B_200D_202D_200B_202D_202C_202C_200E_206A_206F_202D_200B_200B_200B_206C_200F_206C_202A_200C_200B_200D_206B_202D_206D_200B_206F_202A_202E(_200F_202D_206B_206D_200D_200E_202C_202C_206B_200F_200B_206E_200F_206F_200D_202D_202A_206C_200F_200D_200D_202B_200C_202E_206C_206B_206C_200C_202A_206B_202D_202D_200B_206C_206C_206F_202C_202A_200B_202E_202E(obj), _206F_202B_200B_200B_200D_206A_206F_206E_202A_200F_200C_202A_202E_200B_200B_206A_206D_200B_206F_202A_200E_200F_202E_206C_200B_206C_202C_206D_202D_206B_202E_202B_206A_200B_202D_202D_200D_200F_202B_206B_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1452249068u), (object)ResourceStrings.ResStrings[1181])));
					num = (int)(num2 * 602088886) ^ -1673284758;
					continue;
				}
				case 10u:
					_202B_200E_206E_200C_206F_202B_200F_200C_206C_200C_200F_200E_202D_202B_206C_202A_200B_202E_200D_206F_206F_202D_202B_206F_206C_206E_206D_206C_206E_206D_206B_202B_200B_206E_202B_202D_206B_200D_200E_200C_202E(OneKeyBuySellToggleObj, true);
					num = (int)((num2 * 1429716922) ^ 0x35E2C8DC);
					continue;
				case 22u:
				{
					int num5;
					if (status == ShopStatus.XIANGZI_GET)
					{
						num = 1479715121;
						num5 = num;
					}
					else
					{
						num = 978912200;
						num5 = num;
					}
					continue;
				}
				case 9u:
				{
					int num3;
					int num4;
					if (RuntimeData.Instance.XiangziCount < RuntimeData.Instance.MaxXiangziItemCount)
					{
						num3 = -633055289;
						num4 = num3;
					}
					else
					{
						num3 = -2014749608;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 129739199);
					continue;
				}
				case 14u:
					itemMenu.ShowLoader(string.Empty, RuntimeData.Instance.Xiangzi, delegate(object P_0)
					{
						ItemInstance item = P_0 as ItemInstance;
						while (true)
						{
							int num10 = 2076717834;
							while (true)
							{
								uint num11;
								switch ((num11 = (uint)(num10 ^ 0x443CF4F1)) % 7)
								{
								case 0u:
									break;
								case 2u:
								{
									int num12;
									int num13;
									if (IsOneKeyBuySell)
									{
										num12 = -1564531214;
										num13 = num12;
									}
									else
									{
										num12 = -550690167;
										num13 = num12;
									}
									num10 = num12 ^ (int)(num11 * 1673318932);
									continue;
								}
								case 1u:
									RuntimeData.Instance.xiangziAddItem(item, -1);
									num10 = (int)(num11 * 1936820809) ^ -624531128;
									continue;
								case 5u:
									return;
								case 4u:
									RuntimeData.Instance.addItem(item);
									num10 = (int)(num11 * 423294251) ^ -661370740;
									continue;
								case 6u:
									AudioManager.Instance.PlayEffect(ResourceStrings.ResStrings[17]);
									RefreshXiangzi(item, ShopStatus.XIANGZI_GET);
									num10 = (int)(num11 * 1996935219) ^ -385811131;
									continue;
								default:
									itemDetailPanel.Show(item, ItemDetailMode.Selectable, delegate
									{
										RuntimeData.Instance.xiangziAddItem(item, -1);
										RuntimeData.Instance.addItem(item);
										while (true)
										{
											int num14 = -1819891313;
											while (true)
											{
												uint num15;
												switch ((num15 = (uint)(num14 ^ -1977841705)) % 3)
												{
												case 0u:
													break;
												case 1u:
													goto IL_0044;
												default:
													RefreshXiangzi(item, ShopStatus.XIANGZI_GET);
													return;
												}
												break;
												IL_0044:
												AudioManager.Instance.PlayEffect(ResourceStrings.ResStrings[17]);
												num14 = ((int)num15 * -1350868502) ^ -1474988084;
											}
										}
									});
									return;
								}
								break;
							}
						}
					}, null, null, dynamic: true, realCount: false);
					return;
				case 20u:
					_202B_200E_206E_200C_206F_202B_200F_200C_206C_200C_200F_200E_202D_202B_206C_202A_200B_202E_200D_206F_206F_202D_202B_206F_206C_206E_206D_206C_206E_206D_206B_202B_200B_206E_202B_202D_206B_200D_200E_200C_202E(OneKeyBuySellToggleObj, true);
					num = ((int)num2 * -861120247) ^ -213856529;
					continue;
				case 11u:
					_206A_200C_200E_202A_202D_206B_202D_202B_200C_202A_202E_200D_202D_206B_206E_206E_202C_206F_206F_206F_202B_200F_202B_206A_206A_202C_206D_200C_206B_202C_202D_200F_200C_202A_202E_200D_206E_202B_202A_200D_202E(((Component)_200E_200C_202A_206C_202E_206A_202A_202E_200D_200B_206D_206F_206C_200D_206F_200C_200D_202E_202A_200B_202B_206D_202E_200F_200B_200E_200B_202C_200F_202A_200D_200B_200C_202A_206B_206F_202B_200B_206D_200D_202E(_202A_206C_202A_206A_202D_202C_202D_206E_206F_200D_206B_200F_206B_200D_200F_206E_206F_206B_206C_200C_200F_206A_202E_206B_206C_206D_206F_206B_202A_206D_202C_206D_202E_206C_206B_202A_200F_200F_202B_206A_202E(OneKeyBuySellToggleObj), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1676532085u))).GetComponent<Text>(), ResourceStrings.ResStrings[1195]);
					_206A_200C_200E_202A_202D_206B_202D_202B_200C_202A_202E_200D_202D_206B_206E_206E_202C_206F_206F_206F_202B_200F_202B_206A_206A_202C_206D_200C_206B_202C_202D_200F_200C_202A_202E_200D_206E_202B_202A_200D_202E(((Component)_200E_200C_202A_206C_202E_206A_202A_202E_200D_200B_206D_206F_206C_200D_206F_200C_200D_202E_202A_200B_202B_206D_202E_200F_200B_200E_200B_202C_200F_202A_200D_200B_200C_202A_206B_206F_202B_200B_206D_200D_202E(_202A_206C_202A_206A_202D_202C_202D_206E_206F_200D_206B_200F_206B_200D_200F_206E_206F_206B_206C_200C_200F_206A_202E_206B_206C_206D_206F_206B_202A_206D_202C_206D_202E_206C_206B_202A_200F_200F_202B_206A_202E(OneKeyBuySellToggleObj), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(569019878u))).GetComponent<Text>(), ResourceStrings.ResStrings[1196]);
					num = ((int)num2 * -516011613) ^ 0x685BE7D;
					continue;
				case 15u:
					return;
				}
				break;
			}
		}
	}

	public void OnBuy()
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		if (CommonSettings.UpdatingShopUI)
		{
			goto IL_000a;
		}
		goto IL_00f4;
		IL_000a:
		int num = -1397713223;
		goto IL_000f;
		IL_000f:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1933384432)) % 8)
			{
			case 3u:
				break;
			default:
				return;
			case 2u:
				_202C_200B_206B_200B_200F_202C_200F_202C_206C_202E_202E_200C_206B_200E_202D_206F_206A_206F_206A_200B_206E_206F_200C_200F_200C_200D_202C_200F_202D_200C_200C_200B_202B_200D_202E_200B_200F_202C_202E_202A_202E((Graphic)(object)BuyButtonTextObj.GetComponent<Text>(), Color.red);
				_202C_200B_206B_200B_200F_202C_200F_202C_206C_202E_202E_200C_206B_200E_202D_206F_206A_206F_206A_200B_206E_206F_200C_200F_200C_200D_202C_200F_202D_200C_200C_200B_202B_200D_202E_200B_200F_202C_202E_202A_202E((Graphic)(object)SellButtonTextObj.GetComponent<Text>(), Color.white);
				num = ((int)num2 * -2050614061) ^ -2061460517;
				continue;
			case 5u:
				Show(ShopStatus.BUY);
				return;
			case 0u:
				_202C_200B_206B_200B_200F_202C_200F_202C_206C_202E_202E_200C_206B_200E_202D_206F_206A_206F_206A_200B_206E_206F_200C_200F_200C_200D_202C_200F_202D_200C_200C_200B_202B_200D_202E_200B_200F_202C_202E_202A_202E((Graphic)(object)BuyButtonTextObj.GetComponent<Text>(), Color.red);
				_202C_200B_206B_200B_200F_202C_200F_202C_206C_202E_202E_200C_206B_200E_202D_206F_206A_206F_206A_200B_206E_206F_200C_200F_200C_200D_202C_200F_202D_200C_200C_200B_202B_200D_202E_200B_200F_202C_202E_202A_202E((Graphic)(object)SellButtonTextObj.GetComponent<Text>(), Color.white);
				Show(ShopStatus.XIANGZI_PUT);
				num = -225881900;
				continue;
			case 6u:
			{
				int num3;
				int num4;
				if (Type != ShopType.SHOP)
				{
					num3 = 755861138;
					num4 = num3;
				}
				else
				{
					num3 = 48705568;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 988592319);
				continue;
			}
			case 7u:
				goto IL_00f4;
			case 1u:
				return;
			case 4u:
				return;
			}
			break;
		}
		goto IL_000a;
		IL_00f4:
		CommonSettings.UpdatingShopUI = true;
		num = -367812066;
		goto IL_000f;
	}

	public void OnSell()
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (CommonSettings.UpdatingShopUI)
		{
			goto IL_0007;
		}
		goto IL_0062;
		IL_0007:
		int num = 538557276;
		goto IL_000c;
		IL_000c:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x8708DEF)) % 7)
			{
			case 6u:
				break;
			default:
				return;
			case 1u:
				return;
			case 0u:
				Show(ShopStatus.XIANGZI_GET);
				num = ((int)num2 * -313140524) ^ -284298044;
				continue;
			case 4u:
				goto IL_0062;
			case 2u:
				_202C_200B_206B_200B_200F_202C_200F_202C_206C_202E_202E_200C_206B_200E_202D_206F_206A_206F_206A_200B_206E_206F_200C_200F_200C_200D_202C_200F_202D_200C_200C_200B_202B_200D_202E_200B_200F_202C_202E_202A_202E((Graphic)(object)BuyButtonTextObj.GetComponent<Text>(), Color.white);
				_202C_200B_206B_200B_200F_202C_200F_202C_206C_202E_202E_200C_206B_200E_202D_206F_206A_206F_206A_200B_206E_206F_200C_200F_200C_200D_202C_200F_202D_200C_200C_200B_202B_200D_202E_200B_200F_202C_202E_202A_202E((Graphic)(object)SellButtonTextObj.GetComponent<Text>(), Color.red);
				Show(ShopStatus.SELL);
				return;
			case 3u:
				_202C_200B_206B_200B_200F_202C_200F_202C_206C_202E_202E_200C_206B_200E_202D_206F_206A_206F_206A_200B_206E_206F_200C_200F_200C_200D_202C_200F_202D_200C_200C_200B_202B_200D_202E_200B_200F_202C_202E_202A_202E((Graphic)(object)BuyButtonTextObj.GetComponent<Text>(), Color.white);
				_202C_200B_206B_200B_200F_202C_200F_202C_206C_202E_202E_200C_206B_200E_202D_206F_206A_206F_206A_200B_206E_206F_200C_200F_200C_200D_202C_200F_202D_200C_200C_200B_202B_200D_202E_200B_200F_202C_202E_202A_202E((Graphic)(object)SellButtonTextObj.GetComponent<Text>(), Color.red);
				num = 2048545969;
				continue;
			case 5u:
				return;
			}
			break;
		}
		goto IL_0007;
		IL_0062:
		CommonSettings.UpdatingShopUI = true;
		int num3;
		if (Type != ShopType.SHOP)
		{
			num = 33245143;
			num3 = num;
		}
		else
		{
			num = 1484991467;
			num3 = num;
		}
		goto IL_000c;
	}

	public void OnExit()
	{
		CommonSettings.UpdatingShopUI = false;
		string[] array = default(string[]);
		string value = default(string);
		string text = default(string);
		while (true)
		{
			int num = 1118413268;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)(num ^ 0x7B2CDECB)) % 8)
				{
				case 0u:
					break;
				default:
					return;
				case 3u:
					RuntimeData.Instance.gameEngine.SwitchGameScene(array[0], value);
					return;
				case 4u:
					RuntimeData.Instance.gameEngine.SwitchGameScene(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3461219753u), RuntimeData.Instance.CurrentBigMap);
					num = 830238182;
					continue;
				case 7u:
				{
					text = _200B_206E_200B_202C_200F_200C_206D_206C_206E_206A_202E_206F_206F_202A_200B_206A_206B_202C_206B_200F_200C_206A_206F_206A_202B_206D_200C_206C_200F_206B_206A_202D_206B_200C_200B_202B_202E_200B_200C_202B_202E(RuntimeData.Instance.gameEngine.CurrentSceneValue);
					int num5;
					int num6;
					if (_202B_202C_206A_200F_206A_202C_200E_206C_200F_202C_206A_202E_206D_202C_202E_202D_206A_202E_206E_206B_200C_206A_200B_200C_202D_200D_202D_202C_206A_200C_202A_202B_206D_200B_206B_202B_206D_200E_200C_206F_202E(text) <= 2)
					{
						num5 = -514215919;
						num6 = num5;
					}
					else
					{
						num5 = -1430165773;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1914770702);
					continue;
				}
				case 1u:
					obj = string.Empty;
					goto IL_00d3;
				case 2u:
					array = _200F_206D_200B_202D_200E_206D_202C_200E_206D_202E_206F_200E_200E_206D_202A_206F_206D_200F_200D_206A_200C_200D_200E_202B_202D_200B_200E_206E_206D_202A_200C_200E_202E_200C_200B_200C_200C_206A_202A_200C_202E(text, new char[1] { '#' }, StringSplitOptions.RemoveEmptyEntries);
					if (array.Length > 1)
					{
						obj = array[1];
						goto IL_00d3;
					}
					num = ((int)num2 * -364682040) ^ -343077694;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (!_200E_202E_206F_202A_200D_200B_200B_200D_206F_206A_206D_202B_200D_206A_202C_202E_202D_200B_200F_202B_200E_200B_206B_200B_206F_202A_200D_200C_206F_206C_202D_202C_200C_200E_200B_202B_202D_202D_206D_206B_202E(text, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1541154258u)))
					{
						num3 = -1010060779;
						num4 = num3;
					}
					else
					{
						num3 = -301583949;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 435938591);
					continue;
				}
				case 5u:
					return;
					IL_00d3:
					value = (string)obj;
					num = 1913698064;
					continue;
				}
				break;
			}
		}
	}

	private void Start()
	{
		initObj();
		Sprite image2 = default(Sprite);
		Sprite image = default(Sprite);
		while (true)
		{
			int num = -716135147;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -839587948)) % 17)
				{
				case 8u:
					break;
				default:
					return;
				case 6u:
					_200B_202E_200C_206A_200C_202E_202A_206B_202A_202E_202C_200C_200E_206B_206C_206E_200F_200D_202B_200F_202E_200C_206F_200E_200B_206B_200B_206D_200F_206B_202D_200D_206A_206E_206D_206C_206C_202E_200D_206D_202E(BackgroundObj.GetComponent<Image>(), image2);
					num = ((int)num2 * -480938698) ^ -2082131546;
					continue;
				case 13u:
					_200B_202E_200C_206A_200C_202E_202A_206B_202A_202E_202C_200C_200E_206B_206C_206E_200F_200D_202B_200F_202E_200C_206F_200E_200B_206B_200B_206D_200F_206B_202D_200D_206A_206E_206D_206C_206C_202E_200D_206D_202E(BackgroundObj.GetComponent<Image>(), image);
					num = (int)((num2 * 1169140596) ^ 0x4C23A3B9);
					continue;
				case 1u:
				{
					image2 = Resource.GetImage2(CurrentShop.pic, forceLoadFromResource: false);
					int num8;
					int num9;
					if (!_200C_202D_206E_202B_202E_200C_202E_202A_206F_206D_200E_206D_206B_200E_202D_206A_200F_202C_202C_200D_202D_202D_206B_200E_202C_200D_202C_202B_206F_200B_200D_202E_206D_200C_202B_206B_200F_202B_206A_206A_202E((Object)(object)image2, (Object)null))
					{
						num8 = 939050470;
						num9 = num8;
					}
					else
					{
						num8 = 457269578;
						num9 = num8;
					}
					num = num8 ^ (int)(num2 * 538958579);
					continue;
				}
				case 9u:
					CommonSettings.UpdatingShopUI = true;
					num = (int)((num2 * 804010792) ^ 0x320CDD04);
					continue;
				case 5u:
					Show(ShopStatus.BUY);
					num = -995291581;
					continue;
				case 14u:
					image = Resource.GetImage2(ResourceStrings.ResStrings[1180], forceLoadFromResource: false);
					num = ((int)num2 * -1946002640) ^ 0x27813F35;
					continue;
				case 4u:
					_200F_200B_206F_206C_202A_200C_202A_200F_206F_206E_200C_200E_200C_202D_202C_200F_202D_200B_202A_200F_206C_206C_200D_200D_200C_200C_206B_202A_200C_200B_206B_202C_202E_200F_202E_202B_206A_206A_202E_202D_202E((object)global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(787925384u));
					num = ((int)num2 * -172426488) ^ -2145527664;
					continue;
				case 16u:
					return;
				case 0u:
					Show(ShopStatus.XIANGZI_GET);
					return;
				case 15u:
					CommonSettings.UpdatingShopUI = false;
					num = (int)(num2 * 1483940169) ^ -1339191955;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (!_200C_202D_206E_202B_202E_200C_202E_202A_206F_206D_200E_206D_206B_200E_202D_206A_200F_202C_202C_200D_202D_202D_206B_200E_202C_200D_202C_202B_206F_200B_200D_202E_206D_200C_202B_206B_200F_202B_206A_206A_202E((Object)(object)image, (Object)null))
					{
						num4 = -1319167836;
						num5 = num4;
					}
					else
					{
						num4 = -513661443;
						num5 = num4;
					}
					num = num4 ^ ((int)num2 * -841683139);
					continue;
				}
				case 7u:
				{
					int num12;
					if (Type == ShopType.SHOP)
					{
						num = -1330309656;
						num12 = num;
					}
					else
					{
						num = -995291581;
						num12 = num;
					}
					continue;
				}
				case 10u:
				{
					int num10;
					int num11;
					if (Type != ShopType.XIANGZI)
					{
						num10 = 1447612521;
						num11 = num10;
					}
					else
					{
						num10 = 1650114553;
						num11 = num10;
					}
					num = num10 ^ (int)(num2 * 1651997391);
					continue;
				}
				case 12u:
				{
					int num6;
					int num7;
					if (CurrentShop != null)
					{
						num6 = -297683296;
						num7 = num6;
					}
					else
					{
						num6 = -1278434238;
						num7 = num6;
					}
					num = num6 ^ (int)(num2 * 1109335491);
					continue;
				}
				case 11u:
				{
					int num3;
					if (!_206F_206F_202B_200C_202E_200C_200B_206B_202D_206C_202A_202B_206F_206F_202B_206F_200F_200B_206D_200C_206B_200F_206B_202D_206B_202B_202C_202B_202D_206F_202A_206C_202A_202C_206E_200B_200D_200F_202B_200D_202E(CurrentShop.pic))
					{
						num = -933105840;
						num3 = num;
					}
					else
					{
						num = -229441558;
						num3 = num;
					}
					continue;
				}
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void Update()
	{
	}

	[CompilerGenerated]
	private void _202D_202C_206B_200E_202A_206C_206E_202D_200C_202D_202E_206B_206B_202C_206C_206F_202D_202A_202C_200F_200E_200F_200F_202D_206E_202C_200C_206C_200E_206F_206D_206D_200F_206E_206F_202B_200C_200E_200C_206A_202E(object P_0)
	{
		ItemInstance item = P_0 as ItemInstance;
		while (true)
		{
			int num = -1789585321;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -91901909)) % 6)
				{
				case 3u:
					break;
				default:
					return;
				case 2u:
				{
					ShopSale sale = CurrentShop.GetSale(item);
					_206A_200C_200E_202A_202D_206B_202D_202B_200C_202A_202E_200D_202D_206B_206E_206E_202C_206F_206F_206F_202B_200F_202B_206A_206A_202C_206D_200C_206B_202C_202D_200F_200C_202A_202E_200D_206E_202B_202A_200D_202E(infoText, sale.GetPriceInfo());
					int num3;
					int num4;
					if (!IsOneKeyBuySell)
					{
						num3 = -767790012;
						num4 = num3;
					}
					else
					{
						num3 = -1712689715;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 958154684);
					continue;
				}
				case 4u:
					BuySale(item);
					num = ((int)num2 * -1903975377) ^ 0x2A2D7C84;
					continue;
				case 5u:
					num = ((int)num2 * -1649288388) ^ 0x7E54DEA1;
					continue;
				case 1u:
					itemDetailPanel.Show(item, ItemDetailMode.Selectable, delegate
					{
						BuySale(item);
					});
					num = -1408748403;
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private void _206C_202C_202C_200E_206C_206F_202D_200D_206D_200F_200E_200B_200C_202A_206C_206D_202A_202C_202B_206F_206A_200B_202E_206B_206C_202A_200F_200C_202D_200D_202B_202A_200D_206C_202C_200D_206E_202E_206F_202E_202E(object P_0)
	{
		ItemInstance item = default(ItemInstance);
		int price = default(int);
		ShopUI shopUI = default(ShopUI);
		while (true)
		{
			int num = -1562971176;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -510304214)) % 8)
				{
				case 0u:
					break;
				default:
					return;
				case 3u:
					Show(ShopStatus.SELL);
					num = (int)((num2 * 815691361) ^ 0x4B1892F5);
					continue;
				case 6u:
					RuntimeData.Instance.addItem(item, -1);
					AudioManager.Instance.PlayEffect(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2472008757u));
					num = ((int)num2 * -1319088459) ^ 0x3A828E27;
					continue;
				case 5u:
					RuntimeData.Instance.Money += price;
					num = (int)((num2 * 2059614628) ^ 0x22FC6E98);
					continue;
				case 1u:
				{
					item = P_0 as ItemInstance;
					price = item.price / 2;
					int num3;
					int num4;
					if (IsOneKeyBuySell)
					{
						num3 = -2009110748;
						num4 = num3;
					}
					else
					{
						num3 = -1405385274;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1196201667);
					continue;
				}
				case 2u:
					shopUI = this;
					num = ((int)num2 * -170843611) ^ -1117445231;
					continue;
				case 7u:
					_206A_200C_200E_202A_202D_206B_202D_202B_200C_202A_202E_200D_202D_206B_206E_206E_202C_206F_206F_206F_202B_200F_202B_206A_206A_202C_206D_200C_206B_202C_202D_200F_200C_202A_202E_200D_206E_202B_202A_200D_202E(infoText, _206F_202B_200B_200B_200D_206A_206F_206E_202A_200F_200C_202A_202E_200B_200B_206A_206D_200B_206F_202A_200E_200F_202E_206C_200B_206C_202C_206D_202D_206B_202E_202B_206A_200B_202D_202D_200D_200F_202B_206B_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(409567617u), (object)price));
					itemDetailPanel.Show(item, ItemDetailMode.Sellable, delegate
					{
						RuntimeData.Instance.Money += price;
						RuntimeData.Instance.addItem(item, -1);
						AudioManager.Instance.PlayEffect(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2472008757u));
						shopUI.Show(ShopStatus.SELL);
					}, null, delegate
					{
						int num5 = RuntimeData.Instance.Items[item];
						RuntimeData.Instance.Money += price * num5;
						RuntimeData.Instance.addItem(item, -num5);
						while (true)
						{
							int num6 = -1137326103;
							while (true)
							{
								uint num7;
								switch ((num7 = (uint)(num6 ^ -975925461)) % 4)
								{
								case 0u:
									break;
								default:
									return;
								case 2u:
									AudioManager.Instance.PlayEffect(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2472008757u));
									num6 = ((int)num7 * -1974023286) ^ -296168968;
									continue;
								case 3u:
									shopUI.Show(ShopStatus.SELL);
									num6 = ((int)num7 * -687280010) ^ 0x7C00CA58;
									continue;
								case 1u:
									return;
								}
								break;
							}
						}
					});
					num = -1326017466;
					continue;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private static bool _202C_200B_206E_206A_206C_200C_200F_202A_200E_206A_202B_202B_200F_206D_200B_200E_206E_206D_206C_206A_206F_200D_202D_206A_202B_202B_200C_202B_200C_206C_206C_200C_206F_206E_200F_200F_202B_200F_206F_202D_202E(object P_0)
	{
		ItemInstance itemInstance = P_0 as ItemInstance;
		return itemInstance.price > 0;
	}

	[CompilerGenerated]
	private void _206F_206E_206E_206B_206C_200D_206D_200B_202A_200E_206E_200B_200C_206F_202A_202A_206E_206A_206A_200C_200C_206D_200C_206C_206E_206C_200C_206B_202A_206C_206A_200C_200B_206E_202A_206D_200B_200C_206F_200D_202E(object P_0)
	{
		ShopUI shopUI = default(ShopUI);
		ItemInstance item = default(ItemInstance);
		while (true)
		{
			int num = -531531782;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1071476241)) % 4)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					shopUI = this;
					item = P_0 as ItemInstance;
					num = (int)(num2 * 944325776) ^ -218824888;
					continue;
				case 3u:
					itemDetailPanel.Show(item, ItemDetailMode.Selectable, delegate
					{
						RuntimeData.Instance.xiangziAddItem(item, -1);
						RuntimeData.Instance.addItem(item);
						AudioManager.Instance.PlayEffect(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3725734096u));
						shopUI.Show(ShopStatus.XIANGZI_GET);
					});
					num = (int)((num2 * 1236769540) ^ 0x70D3B531);
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private void _206E_202E_202D_202A_202C_202B_202A_200E_202B_202A_202E_200F_206D_206E_202A_200C_200B_200B_206E_202D_206A_200D_200C_206F_206B_202E_202C_206F_202C_202B_202A_202A_200F_200F_200C_200C_202E_202A_202A_202C_202E(object P_0)
	{
		if (RuntimeData.Instance.XiangziCount >= RuntimeData.Instance.MaxXiangziItemCount)
		{
			return;
		}
		_202B_206A_200C_206C_206E_200E_200C_200E_202A_202B_202A_206A_202C_200C_202A_200F_206D_206B_206C_200C_206E_206A_200F_200C_206B_202A_200C_200B_202D_202A_202D_206E_200F_202D_200B_200F_202C_206C_202E_206C_202E obj = default(_202B_206A_200C_206C_206E_200E_200C_200E_202A_202B_202A_206A_202C_200C_202A_200F_206D_206B_206C_200C_206E_206A_200F_200C_206B_202A_200C_200B_202D_202A_202D_206E_200F_202D_200B_200F_202C_206C_202E_206C_202E);
		while (true)
		{
			int num = 2038692192;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x110DDB5F)) % 9)
				{
				case 6u:
					break;
				default:
					return;
				case 4u:
					return;
				case 3u:
					obj._202A_202B_206D_202D_200C_202E_206F_200C_202B_202E_202E_206E_200D_206A_206F_206D_206F_200E_202C_206F_200B_206D_206B_202D_206C_206A_200D_200D_206D_200F_200F_206B_202A_202D_202A_200B_200F_200B_202C_202E_202E = this;
					num = ((int)num2 * -1292266431) ^ 0x61812AA8;
					continue;
				case 0u:
					itemDetailPanel.Show(obj.item, ItemDetailMode.Selectable, obj._202D_206B_206A_202E_202E_202E_200E_206B_200B_202C_202D_200C_206F_206F_202C_206B_200B_202C_206C_206A_200B_202E_200F_206A_200C_202D_200B_200B_202A_202C_202A_206A_202A_200E_200F_206E_200C_200E_202E_202E);
					num = 620252002;
					continue;
				case 8u:
					obj.item = P_0 as ItemInstance;
					num = ((int)num2 * -350255984) ^ 0x4F281E15;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (obj.item.Type != ItemType.Canzhang)
					{
						num5 = 629356943;
						num6 = num5;
					}
					else
					{
						num5 = 688765750;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 107818879);
					continue;
				}
				case 5u:
				{
					int num3;
					int num4;
					if (obj.item.Type == ItemType.Mission)
					{
						num3 = -899511495;
						num4 = num3;
					}
					else
					{
						num3 = -1101152722;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1454777158);
					continue;
				}
				case 1u:
					obj = new _202B_206A_200C_206C_206E_200E_200C_200E_202A_202B_202A_206A_202C_200C_202A_200F_206D_206B_206C_200C_206E_206A_200F_200C_206B_202A_200C_200B_202D_202A_202D_206E_200F_202D_200B_200F_202C_206C_202E_206C_202E();
					num = ((int)num2 * -1931065222) ^ 0x5A455FCF;
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private static bool _202D_206A_200D_202E_202E_206C_206A_206E_202B_206F_202D_200F_206A_206F_206A_202A_206E_200C_206A_200F_200E_202C_202E_202B_200D_202D_200B_202E_206C_202D_206B_202D_200C_200E_200D_206B_202D_202D_206F_206D_202E(object P_0)
	{
		ItemInstance itemInstance = P_0 as ItemInstance;
		while (true)
		{
			int num = 1466280898;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x53E83142)) % 5)
				{
				case 4u:
					break;
				case 2u:
				{
					int num5;
					int num6;
					if (itemInstance.Type == ItemType.Mission)
					{
						num5 = 155116078;
						num6 = num5;
					}
					else
					{
						num5 = 208834029;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1087133986);
					continue;
				}
				case 3u:
				{
					int num3;
					int num4;
					if (itemInstance.Type == ItemType.Canzhang)
					{
						num3 = -52108557;
						num4 = num3;
					}
					else
					{
						num3 = -1034447266;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 804359219);
					continue;
				}
				case 1u:
					return false;
				default:
					return true;
				}
				break;
			}
		}
	}

	private void initObj()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_070b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		_202A_206C_202A_206A_202D_202C_202D_206E_206F_200D_206B_200F_206B_200D_200F_206E_206F_206B_206C_200C_200F_206A_202E_206B_206C_206D_206F_206B_202A_206D_202C_206D_202E_206C_206B_202A_200F_200F_202B_206A_202E(InfoTextObj).localPosition = new Vector3(-165f, -290f, 0f);
		Transform val2 = default(Transform);
		float num6 = default(float);
		Sprite val = default(Sprite);
		while (true)
		{
			int num = -314966468;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1164681415)) % 34)
				{
				case 17u:
					break;
				default:
					return;
				case 32u:
					val2.localPosition = new Vector3(-370f, 50f, 0f);
					num = -294105045;
					continue;
				case 12u:
				{
					int num4;
					int num5;
					if (CommonSettings.ScreenScale >= 2f)
					{
						num4 = 1146743886;
						num5 = num4;
					}
					else
					{
						num4 = 1625705717;
						num5 = num4;
					}
					num = num4 ^ ((int)num2 * -1686239422);
					continue;
				}
				case 11u:
					MoneyTextObj.GetComponent<Text>().font = ModEditorResourceManager.GetFont(CommonSettings.SYSTEM_FONT_NAME);
					YuanbaoTextObj.GetComponent<Text>().font = ModEditorResourceManager.GetFont(CommonSettings.SYSTEM_FONT_NAME);
					num = ((int)num2 * -296916278) ^ 0x736CAD3F;
					continue;
				case 9u:
					((Component)OneKeyBuySellToggleObj.transform.FindChild(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1676532085u))).GetComponent<Text>().font = ModEditorResourceManager.GetFont(CommonSettings.SYSTEM_FONT_NAME);
					num = ((int)num2 * -1427912561) ^ 0x3442153C;
					continue;
				case 23u:
					return;
				case 1u:
					InfoTextObj.AddComponent<Outline>();
					num = (int)((num2 * 538905094) ^ 0x7D5AE0AD);
					continue;
				case 0u:
					OneKeyBuySellToggleObj.transform.SetSiblingIndex(3);
					num = -2134848444;
					continue;
				case 24u:
					BuyButtonTextObj.GetComponent<Text>().text = ResourceStrings.ResStrings[1198].Split('#')[0];
					SellButtonTextObj.GetComponent<Text>().text = ResourceStrings.ResStrings[1199].Split('#')[0];
					num = (int)(num2 * 961437434) ^ -1418567551;
					continue;
				case 8u:
				{
					int num11;
					int num12;
					if (!CommonSettings.USE_SYSTEM_FONT)
					{
						num11 = 2074968667;
						num12 = num11;
					}
					else
					{
						num11 = 384308352;
						num12 = num11;
					}
					num = num11 ^ ((int)num2 * -693793119);
					continue;
				}
				case 29u:
					num6 = (640f * CommonSettings.ScreenScale - 1140f) * 0.49f;
					num = (int)(num2 * 1173013675) ^ -752185274;
					continue;
				case 16u:
					((Component)val2).GetComponent<Image>().sprite = val;
					((Component)val2.FindChild(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(553445101u))).gameObject.SetActive(false);
					num = (int)(num2 * 1003725098) ^ -1370443165;
					continue;
				case 15u:
					BuyButtonTextObj.GetComponent<Text>().text = ResourceStrings.ResStrings[1198].Split('#')[1];
					num = -1484283138;
					continue;
				case 27u:
				{
					int num10;
					if (CommonSettings.ScreenScale < 2f)
					{
						num = -1967135004;
						num10 = num;
					}
					else
					{
						num = -1022355788;
						num10 = num;
					}
					continue;
				}
				case 2u:
					buttonExit.GetComponent<Text>().text = ResourceStrings.ResStrings[1134];
					num = (int)((num2 * 397861673) ^ 0x4DA4102F);
					continue;
				case 3u:
					BackgroundObj.GetComponent<RectTransform>().sizeDelta = new Vector2(640f * CommonSettings.ScreenScale, 640f);
					num = ((int)num2 * -1047134405) ^ -284060917;
					continue;
				case 6u:
					buttonExit = GameObject.Find(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2076768354u));
					num = -553318879;
					continue;
				case 28u:
					BuyButtonTextObj.GetComponent<Text>().font = ModEditorResourceManager.GetFont(CommonSettings.SYSTEM_FONT_NAME);
					SellButtonTextObj.GetComponent<Text>().font = ModEditorResourceManager.GetFont(CommonSettings.SYSTEM_FONT_NAME);
					num = (int)(num2 * 39058739) ^ -995555197;
					continue;
				case 5u:
					val2 = ((Component)this).transform.FindChild(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(980502570u));
					num = (int)((num2 * 1082120537) ^ 0x749E01D2);
					continue;
				case 13u:
					num = (int)(num2 * 1079970212) ^ -601982651;
					continue;
				case 33u:
					buttonExit.GetComponent<Text>().font = ModEditorResourceManager.GetFont(CommonSettings.SYSTEM_FONT_NAME);
					num = (int)(num2 * 1249588451) ^ -1916946888;
					continue;
				case 26u:
				{
					int num8;
					int num9;
					if (Type == ShopType.XIANGZI)
					{
						num8 = -328507609;
						num9 = num8;
					}
					else
					{
						num8 = -623700976;
						num9 = num8;
					}
					num = num8 ^ (int)(num2 * 406631556);
					continue;
				}
				case 7u:
					SellButtonTextObj.GetComponent<Text>().text = ResourceStrings.ResStrings[1199].Split('#')[1];
					num = ((int)num2 * -688935397) ^ 0x240EF32D;
					continue;
				case 25u:
				{
					float num7 = (640f * CommonSettings.ScreenScale - 1140f) * 0.49f;
					((Component)this).transform.FindChild(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(980502570u)).localPosition = new Vector3(-454f - num7, 63f, 0f);
					OneKeyBuySellToggleObj.transform.localPosition = new Vector3(-432f - num7, 233f, 0f);
					num = (int)(num2 * 811175154) ^ -1759601490;
					continue;
				}
				case 20u:
					val2.localPosition = new Vector3(-370f - num6, 50f, 0f);
					OneKeyBuySellToggleObj.transform.localPosition = new Vector3(-439f - num6, -177f, 0f);
					num = ((int)num2 * -82426258) ^ -266866557;
					continue;
				case 30u:
					OneKeyBuySellToggleObj.transform.localPosition = new Vector3(-439f, -177f, 0f);
					num = (int)((num2 * 1701782663) ^ 0x499D923F);
					continue;
				case 10u:
					infoText.font = ModEditorResourceManager.GetFont(CommonSettings.SYSTEM_FONT_NAME);
					num = (int)(num2 * 1908670230) ^ -650746418;
					continue;
				case 31u:
					((Graphic)BuyButtonTextObj.GetComponent<Text>()).color = Color.red;
					num = ((int)num2 * -636877707) ^ 0x11F5C60C;
					continue;
				case 14u:
					((Component)OneKeyBuySellToggleObj.transform.FindChild(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3473335511u))).GetComponent<Text>().font = ModEditorResourceManager.GetFont(CommonSettings.SYSTEM_FONT_NAME);
					num = ((int)num2 * -419788922) ^ -156385160;
					continue;
				case 19u:
					num = (int)(num2 * 1639011862) ^ -691705673;
					continue;
				case 22u:
					BackgroundObj.GetComponent<RectTransform>().sizeDelta = new Vector2(640f * CommonSettings.ScreenScale, 640f);
					num = (int)(num2 * 1670973046) ^ -1924061924;
					continue;
				case 4u:
				{
					val = ModEditorResourceManager.uiCache[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3584665497u)];
					int num3;
					if (!((Object)(object)val != (Object)null))
					{
						num = -271940188;
						num3 = num;
					}
					else
					{
						num = -362734428;
						num3 = num;
					}
					continue;
				}
				case 18u:
					((Graphic)SellButtonTextObj.GetComponent<Text>()).color = Color.red;
					num = ((int)num2 * -1931430485) ^ 0x57CEFF90;
					continue;
				case 21u:
					return;
				}
				break;
			}
		}
	}

	private void RefreshXiangzi(ItemInstance item, ShopStatus status)
	{
		if (item == null)
		{
			goto IL_0006;
		}
		goto IL_021a;
		IL_0006:
		int num = -2012919875;
		goto IL_000b;
		IL_000b:
		int num7 = default(int);
		int num12 = default(int);
		int num3 = default(int);
		int num6 = default(int);
		int num9 = default(int);
		int num8 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -2080981958)) % 33)
			{
			case 13u:
				break;
			default:
				return;
			case 20u:
				num = (int)(num2 * 324652514) ^ -1209434618;
				continue;
			case 6u:
			{
				num7 = 0;
				int num17;
				int num18;
				if (!RuntimeData.Instance.Xiangzi.ContainsKey(item))
				{
					num17 = -89521974;
					num18 = num17;
				}
				else
				{
					num17 = -572769038;
					num18 = num17;
				}
				num = num17 ^ ((int)num2 * -1368417896);
				continue;
			}
			case 3u:
			{
				num12 = 0;
				int num19;
				int num20;
				if (RuntimeData.Instance.Items.ContainsKey(item))
				{
					num19 = 1459660434;
					num20 = num19;
				}
				else
				{
					num19 = 1172611833;
					num20 = num19;
				}
				num = num19 ^ ((int)num2 * -55834253);
				continue;
			}
			case 25u:
				itemMenu.SelectMenuObj.GetComponent<SelectMenu>().RefreshItemShop(item, num3);
				num = -1688491176;
				continue;
			case 14u:
			{
				Text obj = infoText;
				_206A_200C_200E_202A_202D_206B_202D_202B_200C_202A_202E_200D_202D_206B_206E_206E_202C_206F_206F_206F_202B_200F_202B_206A_206A_202C_206D_200C_206B_202C_202D_200F_200C_202A_202E_200D_206E_202B_202A_200D_202E(obj, _202C_200E_202D_202D_206C_202D_206C_200F_206F_200E_200D_200E_200C_200B_200D_202D_200B_202D_202C_202C_200E_206A_206F_202D_200B_200B_200B_206C_200F_206C_202A_200C_200B_200D_206B_202D_206D_200B_206F_202A_202E(_200F_202D_206B_206D_200D_200E_202C_202C_206B_200F_200B_206E_200F_206F_200D_202D_202A_206C_200F_200D_200D_202B_200C_202E_206C_206B_206C_200C_202A_206B_202D_202D_200B_206C_206C_206F_202C_202A_200B_202E_202E(obj), _206F_202B_200B_200B_200D_206A_206F_206E_202A_200F_200C_202A_202E_200B_200B_206A_206D_200B_206F_202A_200E_200F_202E_206C_200B_206C_202C_206D_202D_206B_202E_202B_206A_200B_202D_202D_200D_200F_202B_206B_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3807813759u), (object)ResourceStrings.ResStrings[1181])));
				num = (int)((num2 * 817787412) ^ 0x270AAD7);
				continue;
			}
			case 9u:
				itemMenu.SelectMenuObj.GetComponent<SelectMenu>().RemoveItemShop(item);
				num = (int)((num2 * 357118140) ^ 0x25253F33);
				continue;
			case 18u:
				_206A_200C_200E_202A_202D_206B_202D_202B_200C_202A_202E_200D_202D_206B_206E_206E_202C_206F_206F_206F_202B_200F_202B_206A_206A_202C_206D_200C_206B_202C_202D_200F_200C_202A_202E_200D_206E_202B_202A_200D_202E(infoText, _200F_206D_202D_206D_202A_200C_206E_206A_202D_202E_200B_202B_200E_202B_206F_202D_206D_200C_202C_206C_202C_202B_200D_202A_200B_206C_200B_200E_200F_202C_206D_200D_206D_200B_206D_200D_206C_200B_206C_206E_202E(ResourceStrings.ResStrings[1197], (object)RuntimeData.Instance.XiangziCount, (object)RuntimeData.Instance.MaxXiangziItemCount));
				num = -377228757;
				continue;
			case 4u:
				num12 = RuntimeData.Instance.Items[item];
				num = (int)(num2 * 1524519095) ^ -2018060217;
				continue;
			case 24u:
				goto IL_021a;
			case 16u:
				goto IL_022a;
			case 10u:
				goto IL_0242;
			case 17u:
				goto IL_0269;
			case 0u:
				num = (int)((num2 * 1458751616) ^ 0x5C4C0BD8);
				continue;
			case 7u:
				_206A_200C_200E_202A_202D_206B_202D_202B_200C_202A_202E_200D_202D_206B_206E_206E_202C_206F_206F_206F_202B_200F_202B_206A_206A_202C_206D_200C_206B_202C_202D_200F_200C_202A_202E_200D_206E_202B_202A_200D_202E(infoText, ResourceStrings.ResStrings[1190]);
				num = -785083409;
				continue;
			case 1u:
				num6 = RuntimeData.Instance.Items[item];
				num = ((int)num2 * -1530723768) ^ -678119762;
				continue;
			case 15u:
				_206A_200C_200E_202A_202D_206B_202D_202B_200C_202A_202E_200D_202D_206B_206E_206E_202C_206F_206F_206F_202B_200F_202B_206A_206A_202C_206D_200C_206B_202C_202D_200F_200C_202A_202E_200D_206E_202B_202A_200D_202E(infoText, _200F_206D_202D_206D_202A_200C_206E_206A_202D_202E_200B_202B_200E_202B_206F_202D_206D_200C_202C_206C_202C_202B_200D_202A_200B_206C_200B_200E_200F_202C_206D_200D_206D_200B_206D_200D_206C_200B_206C_206E_202E(ResourceStrings.ResStrings[1194], (object)RuntimeData.Instance.XiangziCount, (object)RuntimeData.Instance.MaxXiangziItemCount));
				num = -2086533345;
				continue;
			case 5u:
			{
				int num15;
				int num16;
				if (status == ShopStatus.XIANGZI_GET)
				{
					num15 = 64123320;
					num16 = num15;
				}
				else
				{
					num15 = 110359425;
					num16 = num15;
				}
				num = num15 ^ (int)(num2 * 457608773);
				continue;
			}
			case 30u:
			{
				int num13;
				int num14;
				if (RuntimeData.Instance.XiangziCount >= RuntimeData.Instance.MaxXiangziItemCount)
				{
					num13 = -932620091;
					num14 = num13;
				}
				else
				{
					num13 = -1241222522;
					num14 = num13;
				}
				num = num13 ^ ((int)num2 * -563345831);
				continue;
			}
			case 8u:
				num3 = RuntimeData.Instance.num_decode(num6);
				num = -158699531;
				continue;
			case 29u:
				goto IL_0399;
			case 22u:
			{
				int num10;
				int num11;
				if (!RuntimeData.Instance.Items.ContainsKey(item))
				{
					num10 = -1026796917;
					num11 = num10;
				}
				else
				{
					num10 = -1515128223;
					num11 = num10;
				}
				num = num10 ^ ((int)num2 * -1460811089);
				continue;
			}
			case 23u:
				return;
			case 12u:
				num6 = 0;
				num = ((int)num2 * -2121855) ^ 0x3C775FD6;
				continue;
			case 27u:
				itemMenu.SelectMenuObj.GetComponent<SelectMenu>().RemoveItemShop(item);
				num = ((int)num2 * -26391039) ^ 0x5963D8B7;
				continue;
			case 19u:
				itemMenu.SelectMenuObj.GetComponent<SelectMenu>().RefreshItemShop(item, num9);
				num = -881721752;
				continue;
			case 31u:
				num = (int)((num2 * 923265521) ^ 0x46C03954);
				continue;
			case 32u:
				itemMenu.SelectMenuObj.GetComponent<SelectMenu>().RefreshItemShop(item, num8);
				num = -1513364569;
				continue;
			case 26u:
				num7 = RuntimeData.Instance.Xiangzi[item];
				num = ((int)num2 * -1514144247) ^ -1656280190;
				continue;
			case 21u:
				itemMenu.SelectMenuObj.GetComponent<SelectMenu>().RemoveItemShop(item);
				num = ((int)num2 * -476753688) ^ 0x43E3E491;
				continue;
			case 28u:
				return;
			case 11u:
			{
				int num4;
				int num5;
				if (num3 > 0)
				{
					num4 = -1011897704;
					num5 = num4;
				}
				else
				{
					num4 = -1072652158;
					num5 = num4;
				}
				num = num4 ^ (int)(num2 * 794077334);
				continue;
			}
			case 2u:
				return;
			}
			break;
			IL_0399:
			int num21;
			if (status == ShopStatus.XIANGZI_PUT)
			{
				num = -196012819;
				num21 = num;
			}
			else
			{
				num = -640877713;
				num21 = num;
			}
			continue;
			IL_0242:
			num9 = RuntimeData.Instance.num_decode(num12);
			int num22;
			if (num9 <= 0)
			{
				num = -1560986352;
				num22 = num;
			}
			else
			{
				num = -1949659692;
				num22 = num;
			}
			continue;
			IL_022a:
			int num23;
			if (status != ShopStatus.SELL)
			{
				num = -785083409;
				num23 = num;
			}
			else
			{
				num = -694155445;
				num23 = num;
			}
			continue;
			IL_0269:
			num8 = RuntimeData.Instance.num_decode(num7);
			int num24;
			if (num8 <= 0)
			{
				num = -148148257;
				num24 = num;
			}
			else
			{
				num = -2005677861;
				num24 = num;
			}
		}
		goto IL_0006;
		IL_021a:
		ShowMoney();
		num = -2055170387;
		goto IL_000b;
	}

	private void showSetActive()
	{
		_202B_200E_206E_200C_206F_202B_200F_200C_206C_200C_200F_200E_202D_202B_206C_202A_200B_202E_200D_206F_206F_202D_202B_206F_206C_206E_206D_206C_206E_206D_206B_202B_200B_206E_202B_202D_206B_200D_200E_200C_202E(buttonExit, false);
		_202B_200E_206E_200C_206F_202B_200F_200C_206C_200C_200F_200E_202D_202B_206C_202A_200B_202E_200D_206F_206F_202D_202B_206F_206C_206E_206D_206C_206E_206D_206B_202B_200B_206E_202B_202D_206B_200D_200E_200C_202E(BuyButtonTextObj, false);
		_202B_200E_206E_200C_206F_202B_200F_200C_206C_200C_200F_200E_202D_202B_206C_202A_200B_202E_200D_206F_206F_202D_202B_206F_206C_206E_206D_206C_206E_206D_206B_202B_200B_206E_202B_202D_206B_200D_200E_200C_202E(SellButtonTextObj, false);
		while (true)
		{
			int num = 1223987207;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x42FEAFE9)) % 10)
				{
				case 4u:
					break;
				default:
					return;
				case 9u:
					_202B_200E_206E_200C_206F_202B_200F_200C_206C_200C_200F_200E_202D_202B_206C_202A_200B_202E_200D_206F_206F_202D_202B_206F_206C_206E_206D_206C_206E_206D_206B_202B_200B_206E_202B_202D_206B_200D_200E_200C_202E(BuyButtonTextObj, true);
					num = (int)(num2 * 141839887) ^ -1422916130;
					continue;
				case 8u:
					_202B_200E_206E_200C_206F_202B_200F_200C_206C_200C_200F_200E_202D_202B_206C_202A_200B_202E_200D_206F_206F_202D_202B_206F_206C_206E_206D_206C_206E_206D_206B_202B_200B_206E_202B_202D_206B_200D_200E_200C_202E(OneKeyBuySellToggleObj, true);
					num = ((int)num2 * -2138932246) ^ -100861258;
					continue;
				case 3u:
					_202B_200E_206E_200C_206F_202B_200F_200C_206C_200C_200F_200E_202D_202B_206C_202A_200B_202E_200D_206F_206F_202D_202B_206F_206C_206E_206D_206C_206E_206D_206B_202B_200B_206E_202B_202D_206B_200D_200E_200C_202E(YuanbaoTextObj, true);
					num = ((int)num2 * -157398563) ^ -416666027;
					continue;
				case 0u:
					_202B_200E_206E_200C_206F_202B_200F_200C_206C_200C_200F_200E_202D_202B_206C_202A_200B_202E_200D_206F_206F_202D_202B_206F_206C_206E_206D_206C_206E_206D_206B_202B_200B_206E_202B_202D_206B_200D_200E_200C_202E(SellButtonTextObj, true);
					_202B_200E_206E_200C_206F_202B_200F_200C_206C_200C_200F_200E_202D_202B_206C_202A_200B_202E_200D_206F_206F_202D_202B_206F_206C_206E_206D_206C_206E_206D_206B_202B_200B_206E_202B_202D_206B_200D_200E_200C_202E(InfoTextObj, true);
					num = (int)(num2 * 98865181) ^ -1084324361;
					continue;
				case 6u:
					_202B_200E_206E_200C_206F_202B_200F_200C_206C_200C_200F_200E_202D_202B_206C_202A_200B_202E_200D_206F_206F_202D_202B_206F_206C_206E_206D_206C_206E_206D_206B_202B_200B_206E_202B_202D_206B_200D_200E_200C_202E(InfoTextObj, false);
					num = ((int)num2 * -217631739) ^ -474449598;
					continue;
				case 7u:
					_202B_200E_206E_200C_206F_202B_200F_200C_206C_200C_200F_200E_202D_202B_206C_202A_200B_202E_200D_206F_206F_202D_202B_206F_206C_206E_206D_206C_206E_206D_206B_202B_200B_206E_202B_202D_206B_200D_200E_200C_202E(MoneyTextObj, true);
					num = (int)(num2 * 2006959293) ^ -758612409;
					continue;
				case 2u:
					_202B_200E_206E_200C_206F_202B_200F_200C_206C_200C_200F_200E_202D_202B_206C_202A_200B_202E_200D_206F_206F_202D_202B_206F_206C_206E_206D_206C_206E_206D_206B_202B_200B_206E_202B_202D_206B_200D_200E_200C_202E(MoneyTextObj, false);
					_202B_200E_206E_200C_206F_202B_200F_200C_206C_200C_200F_200E_202D_202B_206C_202A_200B_202E_200D_206F_206F_202D_202B_206F_206C_206E_206D_206C_206E_206D_206B_202B_200B_206E_202B_202D_206B_200D_200E_200C_202E(YuanbaoTextObj, false);
					_202B_200E_206E_200C_206F_202B_200F_200C_206C_200C_200F_200E_202D_202B_206C_202A_200B_202E_200D_206F_206F_202D_202B_206F_206C_206E_206D_206C_206E_206D_206B_202B_200B_206E_202B_202D_206B_200D_200E_200C_202E(buttonExit, true);
					num = ((int)num2 * -280908379) ^ 0x4BDE8EB8;
					continue;
				case 1u:
					_202B_200E_206E_200C_206F_202B_200F_200C_206C_200C_200F_200E_202D_202B_206C_202A_200B_202E_200D_206F_206F_202D_202B_206F_206C_206E_206D_206C_206E_206D_206B_202B_200B_206E_202B_202D_206B_200D_200E_200C_202E(OneKeyBuySellToggleObj, false);
					num = (int)(num2 * 1256566075) ^ -155893210;
					continue;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private void _200F_202D_206F_200F_202E_200E_200D_200D_206B_202A_202C_206E_206D_206C_202C_200C_206C_206D_206C_200B_202B_200D_200C_202B_200B_202B_200F_200F_206E_202E_202D_200D_206B_206D_206D_202B_202E_200F_206F_206F_202E(object P_0)
	{
		ItemInstance item = default(ItemInstance);
		ShopUI shopUI = default(ShopUI);
		while (true)
		{
			int num = 53532006;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x550D9DE1)) % 6)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					itemDetailPanel.Show(item, ItemDetailMode.Selectable, delegate
					{
						shopUI.BuySale(item);
					}, delegate
					{
						_206A_200C_200E_202A_202D_206B_202D_202B_200C_202A_202E_200D_202D_206B_206E_206E_202C_206F_206F_206F_202B_200F_202B_206A_206A_202C_206D_200C_206B_202C_202D_200F_200C_202A_202E_200D_206E_202B_202A_200D_202E(infoText, ResourceStrings.ResStrings[1187]);
					});
					num = 543839620;
					continue;
				case 2u:
				{
					item = P_0 as ItemInstance;
					ShopSale sale = CurrentShop.GetSale(item);
					_206A_200C_200E_202A_202D_206B_202D_202B_200C_202A_202E_200D_202D_206B_206E_206E_202C_206F_206F_206F_202B_200F_202B_206A_206A_202C_206D_200C_206B_202C_202D_200F_200C_202A_202E_200D_206E_202B_202A_200D_202E(infoText, sale.GetPriceInfo());
					int num3;
					int num4;
					if (IsOneKeyBuySell)
					{
						num3 = 1540220699;
						num4 = num3;
					}
					else
					{
						num3 = 204866456;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1930533471);
					continue;
				}
				case 3u:
					shopUI = this;
					num = ((int)num2 * -827934296) ^ -828405135;
					continue;
				case 4u:
					BuySale(item);
					return;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private void _200F_200E_206E_202D_200D_206A_206D_206F_202A_202C_202C_200D_200C_202E_206C_206F_200C_206B_206E_206F_200F_206D_206A_202E_206F_206D_200F_202C_200F_202D_202E_206F_206D_206C_200B_206A_206D_202B_202C_206F_202E()
	{
		_206A_200C_200E_202A_202D_206B_202D_202B_200C_202A_202E_200D_202D_206B_206E_206E_202C_206F_206F_206F_202B_200F_202B_206A_206A_202C_206D_200C_206B_202C_202D_200F_200C_202A_202E_200D_206E_202B_202A_200D_202E(infoText, ResourceStrings.ResStrings[1187]);
	}

	[CompilerGenerated]
	private void _202B_202B_202B_200D_206B_202A_206E_206C_206F_206D_206F_206A_202A_206E_200C_202D_202B_206E_200D_206F_206F_200F_206D_200C_202D_202E_206C_200D_200B_202C_202A_200F_202A_200C_206C_202A_202B_206C_200D_202D_202E(object P_0)
	{
		int price = default(int);
		ItemInstance item = default(ItemInstance);
		ShopUI shopUI = default(ShopUI);
		while (true)
		{
			int num = 12290305;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1B95F1A2)) % 10)
				{
				case 7u:
					break;
				case 5u:
					RuntimeData.Instance.Money += price;
					RuntimeData.Instance.addItem(item, -1);
					AudioManager.Instance.PlayEffect(ResourceStrings.ResStrings[17]);
					num = (int)((num2 * 780507076) ^ 0x2EAC74B3);
					continue;
				case 0u:
				{
					price = item.price / 2;
					int num4;
					int num5;
					if (price > 0)
					{
						num4 = -225039569;
						num5 = num4;
					}
					else
					{
						num4 = -2055270144;
						num5 = num4;
					}
					num = num4 ^ (int)(num2 * 1211711858);
					continue;
				}
				case 9u:
					RefreshXiangzi(item, ShopStatus.SELL);
					num = (int)((num2 * 1313756535) ^ 0x5DB1EFE5);
					continue;
				case 4u:
					return;
				case 3u:
				{
					int num3;
					if (!IsOneKeyBuySell)
					{
						num = 2096580078;
						num3 = num;
					}
					else
					{
						num = 684190647;
						num3 = num;
					}
					continue;
				}
				case 1u:
					shopUI = this;
					item = P_0 as ItemInstance;
					num = ((int)num2 * -251136913) ^ -501376699;
					continue;
				case 8u:
					AudioManager.Instance.PlayEffect(ResourceStrings.ResStrings[1163]);
					num = ((int)num2 * -1524327916) ^ -45209934;
					continue;
				case 6u:
					return;
				default:
					_206A_200C_200E_202A_202D_206B_202D_202B_200C_202A_202E_200D_202D_206B_206E_206E_202C_206F_206F_206F_202B_200F_202B_206A_206A_202C_206D_200C_206B_202C_202D_200F_200C_202A_202E_200D_206E_202B_202A_200D_202E(infoText, _206F_202B_200B_200B_200D_206A_206F_206E_202A_200F_200C_202A_202E_200B_200B_206A_206D_200B_206F_202A_200E_200F_202E_206C_200B_206C_202C_206D_202D_206B_202E_202B_206A_200B_202D_202D_200D_200F_202B_206B_202E(ResourceStrings.ResStrings[1191], (object)price));
					itemDetailPanel.Show(item, ItemDetailMode.Sellable, delegate
					{
						RuntimeData.Instance.Money += price;
						while (true)
						{
							int num6 = 1496832598;
							while (true)
							{
								uint num7;
								switch ((num7 = (uint)(num6 ^ 0x51DF79E4)) % 3)
								{
								case 0u:
									break;
								case 2u:
									goto IL_0039;
								default:
									AudioManager.Instance.PlayEffect(ResourceStrings.ResStrings[17]);
									shopUI.RefreshXiangzi(item, ShopStatus.SELL);
									return;
								}
								break;
								IL_0039:
								RuntimeData.Instance.addItem(item, -1);
								num6 = (int)((num7 * 318672330) ^ 0x5EBEEBE5);
							}
						}
					}, delegate
					{
						_206A_200C_200E_202A_202D_206B_202D_202B_200C_202A_202E_200D_202D_206B_206E_206E_202C_206F_206F_206F_202B_200F_202B_206A_206A_202C_206D_200C_206B_202C_202D_200F_200C_202A_202E_200D_206E_202B_202A_200D_202E(infoText, ResourceStrings.ResStrings[1190]);
					}, delegate
					{
						int num6 = RuntimeData.Instance.Items[item];
						while (true)
						{
							int num7 = 44272683;
							while (true)
							{
								uint num8;
								switch ((num8 = (uint)(num7 ^ 0x700FDB2)) % 5)
								{
								case 3u:
									break;
								default:
									return;
								case 4u:
									num6 = RuntimeData.Instance.num_decode(num6);
									num7 = ((int)num8 * -1441592687) ^ -266189757;
									continue;
								case 0u:
									RuntimeData.Instance.addItem(item, -num6);
									AudioManager.Instance.PlayEffect(ResourceStrings.ResStrings[17]);
									shopUI.RefreshXiangzi(item, ShopStatus.SELL);
									num7 = (int)((num8 * 698735819) ^ 0x6C765374);
									continue;
								case 1u:
									RuntimeData.Instance.Money += price * num6;
									num7 = ((int)num8 * -2081763324) ^ -1397867827;
									continue;
								case 2u:
									return;
								}
								break;
							}
						}
					});
					return;
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private void _202E_206C_202E_206D_202C_206E_202C_202B_200C_202A_202B_206E_200E_202C_206B_200E_200C_206E_206A_200C_200D_206E_202A_206C_202E_202C_202E_202B_206B_200E_206D_206A_206C_202E_206A_202D_200D_200F_202E_202B_202E()
	{
		_206A_200C_200E_202A_202D_206B_202D_202B_200C_202A_202E_200D_202D_206B_206E_206E_202C_206F_206F_206F_202B_200F_202B_206A_206A_202C_206D_200C_206B_202C_202D_200F_200C_202A_202E_200D_206E_202B_202A_200D_202E(infoText, ResourceStrings.ResStrings[1190]);
	}

	[CompilerGenerated]
	private void _202C_202C_202B_200F_200D_202A_206D_202B_200C_206E_206B_202A_206D_202B_202A_206F_200E_200C_202D_200F_202C_206A_202E_200D_206E_202A_202C_206A_200F_202E_206B_200F_206F_202E_200F_202E_206E_200B_206D_206E_202E(object P_0)
	{
		ItemInstance item = P_0 as ItemInstance;
		while (true)
		{
			int num = 2076717834;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x443CF4F1)) % 7)
				{
				case 0u:
					break;
				case 2u:
				{
					int num3;
					int num4;
					if (IsOneKeyBuySell)
					{
						num3 = -1564531214;
						num4 = num3;
					}
					else
					{
						num3 = -550690167;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1673318932);
					continue;
				}
				case 1u:
					RuntimeData.Instance.xiangziAddItem(item, -1);
					num = (int)(num2 * 1936820809) ^ -624531128;
					continue;
				case 5u:
					return;
				case 4u:
					RuntimeData.Instance.addItem(item);
					num = (int)(num2 * 423294251) ^ -661370740;
					continue;
				case 6u:
					AudioManager.Instance.PlayEffect(ResourceStrings.ResStrings[17]);
					RefreshXiangzi(item, ShopStatus.XIANGZI_GET);
					num = (int)(num2 * 1996935219) ^ -385811131;
					continue;
				default:
					itemDetailPanel.Show(item, ItemDetailMode.Selectable, delegate
					{
						RuntimeData.Instance.xiangziAddItem(item, -1);
						RuntimeData.Instance.addItem(item);
						while (true)
						{
							int num5 = -1819891313;
							while (true)
							{
								uint num6;
								switch ((num6 = (uint)(num5 ^ -1977841705)) % 3)
								{
								case 0u:
									break;
								case 1u:
									goto IL_0044;
								default:
									RefreshXiangzi(item, ShopStatus.XIANGZI_GET);
									return;
								}
								break;
								IL_0044:
								AudioManager.Instance.PlayEffect(ResourceStrings.ResStrings[17]);
								num5 = ((int)num6 * -1350868502) ^ -1474988084;
							}
						}
					});
					return;
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private void _206E_206A_202C_202A_200C_206A_206B_200E_202A_206B_202C_206B_206D_200B_206B_206D_206C_202D_206D_206A_202C_200E_202D_202D_206A_200E_202E_206B_206A_200B_202B_202A_200E_206C_200C_200E_202D_206B_200E_202E_202E(object P_0)
	{
		if (RuntimeData.Instance.XiangziCount >= RuntimeData.Instance.MaxXiangziItemCount)
		{
			return;
		}
		_202D_206F_206A_200D_206F_206F_202D_206A_200B_206F_200E_206F_206F_206E_200D_206E_200D_200F_200D_200D_200F_206E_206C_202C_200F_200E_206E_202E_202E_202D_200E_202C_206B_200D_200C_202B_206A_206E_206F_202E_202E obj = default(_202D_206F_206A_200D_206F_206F_202D_206A_200B_206F_200E_206F_206F_206E_200D_206E_200D_200F_200D_200D_200F_206E_206C_202C_200F_200E_206E_202E_202E_202D_200E_202C_206B_200D_200C_202B_206A_206E_206F_202E_202E);
		int box = default(int);
		while (true)
		{
			int num = -266831223;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1964965105)) % 14)
				{
				case 2u:
					break;
				default:
					return;
				case 9u:
					return;
				case 7u:
					obj.item = P_0 as ItemInstance;
					box = obj.item.GetItem().box;
					num = (int)((num2 * 1904844570) ^ 0x510C00BF);
					continue;
				case 0u:
				{
					int num6;
					int num7;
					if (obj.item.Type == ItemType.Mission)
					{
						num6 = -956432905;
						num7 = num6;
					}
					else
					{
						num6 = -24038807;
						num7 = num6;
					}
					num = num6 ^ ((int)num2 * -67835571);
					continue;
				}
				case 11u:
					RuntimeData.Instance.xiangziAddItem(obj.item);
					num = (int)((num2 * 1306628272) ^ 0x57D987C5);
					continue;
				case 10u:
				{
					int num4;
					int num5;
					if (box == 1)
					{
						num4 = 272298351;
						num5 = num4;
					}
					else
					{
						num4 = 1474207492;
						num5 = num4;
					}
					num = num4 ^ ((int)num2 * -1465520134);
					continue;
				}
				case 8u:
					return;
				case 6u:
					obj = new _202D_206F_206A_200D_206F_206F_202D_206A_200B_206F_200E_206F_206F_206E_200D_206E_200D_200F_200D_200D_200F_206E_206C_202C_200F_200E_206E_202E_202E_202D_200E_202C_206B_200D_200C_202B_206A_206E_206F_202E_202E();
					obj._202C_206B_206A_200C_202C_202C_200D_202E_206B_202C_206C_200C_200D_206E_200C_206C_206A_206D_206F_202D_206F_200F_206F_206A_206A_200C_202B_202D_200C_200B_206C_206B_200D_206B_200E_202A_202A_206D_206E_202A_202E = this;
					num = (int)(num2 * 1305860142) ^ -1119256774;
					continue;
				case 4u:
				{
					int num8;
					if (box != -1)
					{
						num = -678346912;
						num8 = num;
					}
					else
					{
						num = -1048429216;
						num8 = num;
					}
					continue;
				}
				case 12u:
					RuntimeData.Instance.addItem(obj.item, -1);
					AudioManager.Instance.PlayEffect(ResourceStrings.ResStrings[17]);
					num = ((int)num2 * -1545128194) ^ 0x6C7B3D9E;
					continue;
				case 1u:
					itemDetailPanel.Show(obj.item, ItemDetailMode.Selectable, obj._202D_202D_206B_202A_202A_202C_206A_200E_206B_202B_206A_206D_200F_206D_200C_200C_202A_206C_200F_202A_200F_206E_202E_206D_200F_200C_200C_200C_206D_206C_200F_206F_206A_202B_202A_202C_206B_200D_202A_202C_202E);
					num = -347419848;
					continue;
				case 3u:
				{
					int num3;
					if (IsOneKeyBuySell)
					{
						num = -339614492;
						num3 = num;
					}
					else
					{
						num = -1128040324;
						num3 = num;
					}
					continue;
				}
				case 5u:
					RefreshXiangzi(obj.item, ShopStatus.XIANGZI_PUT);
					num = (int)(num2 * 1449105639) ^ -1123781374;
					continue;
				case 13u:
					return;
				}
				break;
			}
		}
	}

	static int _200C_202B_202A_200F_202C_206E_206D_200E_200E_200C_206F_206E_202D_202A_200B_206D_206C_200D_200C_200F_202B_202E_206C_200D_200F_200C_202A_200D_206C_200B_206D_200D_202C_206F_202C_206F_206F_200F_200E_206E_202E(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	static bool _202B_202B_200F_202A_206B_200F_206D_206C_206D_200F_202C_206C_202E_206F_206E_206B_206D_202E_206E_200F_200C_206F_200F_202A_200D_202B_200C_206B_206B_206D_206A_200D_206F_206C_206B_202E_200D_200F_200F_206D_202E(Toggle P_0)
	{
		return P_0.isOn;
	}

	static void _202B_200E_206E_200C_206F_202B_200F_200C_206C_200C_200F_200E_202D_202B_206C_202A_200B_202E_200D_206F_206F_202D_202B_206F_206C_206E_206D_206C_206E_206D_206B_202B_200B_206E_202B_202D_206B_200D_200E_200C_202E(GameObject P_0, bool P_1)
	{
		P_0.SetActive(P_1);
	}

	static Transform _202A_206C_202A_206A_202D_202C_202D_206E_206F_200D_206B_200F_206B_200D_200F_206E_206F_206B_206C_200C_200F_206A_202E_206B_206C_206D_206F_206B_202A_206D_202C_206D_202E_206C_206B_202A_200F_200F_202B_206A_202E(GameObject P_0)
	{
		return P_0.transform;
	}

	static Transform _200E_200C_202A_206C_202E_206A_202A_202E_200D_200B_206D_206F_206C_200D_206F_200C_200D_202E_202A_200B_202B_206D_202E_200F_200B_200E_200B_202C_200F_202A_200D_200B_200C_202A_206B_206F_202B_200B_206D_200D_202E(Transform P_0, string P_1)
	{
		return P_0.FindChild(P_1);
	}

	static void _206A_200C_200E_202A_202D_206B_202D_202B_200C_202A_202E_200D_202D_206B_206E_206E_202C_206F_206F_206F_202B_200F_202B_206A_206A_202C_206D_200C_206B_202C_202D_200F_200C_202A_202E_200D_206E_202B_202A_200D_202E(Text P_0, string P_1)
	{
		P_0.text = P_1;
	}

	static string _200F_206D_202D_206D_202A_200C_206E_206A_202D_202E_200B_202B_200E_202B_206F_202D_206D_200C_202C_206C_202C_202B_200D_202A_200B_206C_200B_200E_200F_202C_206D_200D_206D_200B_206D_200D_206C_200B_206C_206E_202E(string P_0, object P_1, object P_2)
	{
		return string.Format(P_0, P_1, P_2);
	}

	static string _200F_202D_206B_206D_200D_200E_202C_202C_206B_200F_200B_206E_200F_206F_200D_202D_202A_206C_200F_200D_200D_202B_200C_202E_206C_206B_206C_200C_202A_206B_202D_202D_200B_206C_206C_206F_202C_202A_200B_202E_202E(Text P_0)
	{
		return P_0.text;
	}

	static string _206F_202B_200B_200B_200D_206A_206F_206E_202A_200F_200C_202A_202E_200B_200B_206A_206D_200B_206F_202A_200E_200F_202E_206C_200B_206C_202C_206D_202D_206B_202E_202B_206A_200B_202D_202D_200D_200F_202B_206B_202E(string P_0, object P_1)
	{
		return string.Format(P_0, P_1);
	}

	static string _202C_200E_202D_202D_206C_202D_206C_200F_206F_200E_200D_200E_200C_200B_200D_202D_200B_202D_202C_202C_200E_206A_206F_202D_200B_200B_200B_206C_200F_206C_202A_200C_200B_200D_206B_202D_206D_200B_206F_202A_202E(string P_0, string P_1)
	{
		return P_0 + P_1;
	}

	static void _202C_200B_206B_200B_200F_202C_200F_202C_206C_202E_202E_200C_206B_200E_202D_206F_206A_206F_206A_200B_206E_206F_200C_200F_200C_200D_202C_200F_202D_200C_200C_200B_202B_200D_202E_200B_200F_202C_202E_202A_202E(Graphic P_0, Color P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.color = P_1;
	}

	static string _200B_206E_200B_202C_200F_200C_206D_206C_206E_206A_202E_206F_206F_202A_200B_206A_206B_202C_206B_200F_200C_206A_206F_206A_202B_206D_200C_206C_200F_206B_206A_202D_206B_200C_200B_202B_202E_200B_200C_202B_202E(string P_0)
	{
		return P_0.Trim();
	}

	static int _202B_202C_206A_200F_206A_202C_200E_206C_200F_202C_206A_202E_206D_202C_202E_202D_206A_202E_206E_206B_200C_206A_200B_200C_202D_200D_202D_202C_206A_200C_202A_202B_206D_200B_206B_202B_206D_200E_200C_206F_202E(string P_0)
	{
		return P_0.Length;
	}

	static bool _200E_202E_206F_202A_200D_200B_200B_200D_206F_206A_206D_202B_200D_206A_202C_202E_202D_200B_200F_202B_200E_200B_206B_200B_206F_202A_200D_200C_206F_206C_202D_202C_200C_200E_200B_202B_202D_202D_206D_206B_202E(string P_0, string P_1)
	{
		return P_0.Contains(P_1);
	}

	static string[] _200F_206D_200B_202D_200E_206D_202C_200E_206D_202E_206F_200E_200E_206D_202A_206F_206D_200F_200D_206A_200C_200D_200E_202B_202D_200B_200E_206E_206D_202A_200C_200E_202E_200C_200B_200C_200C_206A_202A_200C_202E(string P_0, char[] P_1, StringSplitOptions P_2)
	{
		return P_0.Split(P_1, P_2);
	}

	static bool _200C_202D_206E_202B_202E_200C_202E_202A_206F_206D_200E_206D_206B_200E_202D_206A_200F_202C_202C_200D_202D_202D_206B_200E_202C_200D_202C_202B_206F_200B_200D_202E_206D_200C_202B_206B_200F_202B_206A_206A_202E(Object P_0, Object P_1)
	{
		return P_0 != P_1;
	}

	static void _200B_202E_200C_206A_200C_202E_202A_206B_202A_202E_202C_200C_200E_206B_206C_206E_200F_200D_202B_200F_202E_200C_206F_200E_200B_206B_200B_206D_200F_206B_202D_200D_206A_206E_206D_206C_206C_202E_200D_206D_202E(Image P_0, Sprite P_1)
	{
		P_0.sprite = P_1;
	}

	static void _200F_200B_206F_206C_202A_200C_202A_200F_206F_206E_200C_200E_200C_202D_202C_200F_202D_200B_202A_200F_206C_206C_200D_200D_200C_200C_206B_202A_200C_200B_206B_202C_202E_200F_202E_202B_206A_206A_202E_202D_202E(object P_0)
	{
		Debug.LogError(P_0);
	}

	static bool _206F_206F_202B_200C_202E_200C_200B_206B_202D_206C_202A_202B_206F_206F_202B_206F_200F_200B_206D_200C_206B_200F_206B_202D_206B_202B_202C_202B_202D_206F_202A_206C_202A_202C_206E_200B_200D_200F_202B_200D_202E(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}
}
