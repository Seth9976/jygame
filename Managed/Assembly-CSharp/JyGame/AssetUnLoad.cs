using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace JyGame;

public class AssetUnLoad
{
	private HashSet<Object> markDatas = new HashSet<Object>();

	private static List<Component> components = new List<Component>();

	public static void UnLoadGameObjects(IEnumerable<GameObject> removelist, params IEnumerable<GameObject>[] saveLists)
	{
		AssetUnLoad assetUnLoad = new AssetUnLoad();
		IEnumerator<GameObject> enumerator = removelist.GetEnumerator();
		try
		{
			GameObject current = default(GameObject);
			while (true)
			{
				IL_003a:
				int num;
				int num2;
				if (_200E_200C_206A_202B_202B_202C_200D_200B_200E_206B_202C_202E_206A_206E_206C_206C_202A_206B_206B_206C_202B_202C_200C_202E_206D_206B_202E_202A_206F_202C_202E_202C_206B_202D_200E_200D_206D_202A_206E_206E_202E((IEnumerator)enumerator))
				{
					num = -1605133192;
					num2 = num;
				}
				else
				{
					num = -1711944523;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -1365913747)) % 5)
					{
					case 3u:
						num = -1605133192;
						continue;
					default:
						goto end_IL_0014;
					case 4u:
						break;
					case 2u:
						assetUnLoad.MarkAssetsInComponent(current, mark: true);
						num = (int)((num3 * 833152554) ^ 0x2B7BE679);
						continue;
					case 1u:
						current = enumerator.Current;
						num = -1595537291;
						continue;
					case 0u:
						goto end_IL_0014;
					}
					goto IL_003a;
					continue;
					end_IL_0014:
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
					IL_007e:
					int num4 = -1295462625;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num4 ^ -1365913747)) % 3)
						{
						case 0u:
							break;
						default:
							goto end_IL_0083;
						case 1u:
							goto IL_00a1;
						case 2u:
							goto end_IL_0083;
						}
						goto IL_007e;
						IL_00a1:
						_202A_202C_200B_200F_202C_206F_206C_202B_202C_202B_206C_206E_206F_206D_202C_206A_202B_200B_206F_200F_200E_202B_206E_206F_202D_206A_206E_202E_200E_200D_206A_206F_202C_202B_202D_200E_200D_202B_200D_206B_202E((IDisposable)enumerator);
						num4 = ((int)num3 * -166850659) ^ -454617670;
						continue;
						end_IL_0083:
						break;
					}
					break;
				}
			}
		}
		int num5 = 0;
		GameObject current2 = default(GameObject);
		while (true)
		{
			uint num3;
			if (num5 < saveLists.Length)
			{
				enumerator = saveLists[num5].GetEnumerator();
				try
				{
					while (true)
					{
						IL_0121:
						int num6;
						int num7;
						if (_200E_200C_206A_202B_202B_202C_200D_200B_200E_206B_202C_202E_206A_206E_206C_206C_202A_206B_206B_206C_202B_202C_200C_202E_206D_206B_202E_202A_206F_202C_202E_202C_206B_202D_200E_200D_206D_202A_206E_206E_202E((IEnumerator)enumerator))
						{
							num6 = -1753628440;
							num7 = num6;
						}
						else
						{
							num6 = -621654862;
							num7 = num6;
						}
						while (true)
						{
							switch ((num3 = (uint)(num6 ^ -1365913747)) % 5)
							{
							case 2u:
								num6 = -1753628440;
								continue;
							default:
								goto end_IL_00d3;
							case 1u:
								current2 = enumerator.Current;
								num6 = -1344673519;
								continue;
							case 4u:
								assetUnLoad.MarkAssetsInComponent(current2, mark: false);
								num6 = (int)(num3 * 1924350953) ^ -241491135;
								continue;
							case 0u:
								break;
							case 3u:
								goto end_IL_00d3;
							}
							goto IL_0121;
							continue;
							end_IL_00d3:
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
							IL_013f:
							int num8 = -1744471861;
							while (true)
							{
								switch ((num3 = (uint)(num8 ^ -1365913747)) % 3)
								{
								case 2u:
									break;
								default:
									goto end_IL_0144;
								case 1u:
									goto IL_0162;
								case 0u:
									goto end_IL_0144;
								}
								goto IL_013f;
								IL_0162:
								_202A_202C_200B_200F_202C_206F_206C_202B_202C_202B_206C_206E_206F_206D_202C_206A_202B_200B_206F_200F_200E_202B_206E_206F_202D_206A_206E_202E_200E_200D_206A_206F_202C_202B_202D_200E_200D_202B_200D_206B_202E((IDisposable)enumerator);
								num8 = (int)(num3 * 1731171380) ^ -1150129875;
								continue;
								end_IL_0144:
								break;
							}
							break;
						}
					}
				}
				num5++;
				goto IL_017f;
			}
			int num9 = -910758528;
			goto IL_0184;
			IL_0184:
			switch ((num3 = (uint)(num9 ^ -1365913747)) % 3)
			{
			case 0u:
				break;
			case 2u:
				continue;
			default:
				assetUnLoad.Run();
				return;
			}
			goto IL_017f;
			IL_017f:
			num9 = -652298777;
			goto IL_0184;
		}
	}

	public virtual void MarkAssetsInComponent(GameObject asset, bool mark)
	{
		asset.GetComponentsInChildren<Component>(true, components);
		using (List<Component>.Enumerator enumerator = components.GetEnumerator())
		{
			Component current = default(Component);
			while (true)
			{
				IL_015f:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 396775728;
					num2 = num;
				}
				else
				{
					num = 2082675749;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x416E2008)) % 21)
					{
					case 12u:
						num = 2082675749;
						continue;
					default:
						goto end_IL_0021;
					case 10u:
					{
						int num6;
						if (current is Renderer)
						{
							num = 986497273;
							num6 = num;
						}
						else
						{
							num = 1623593407;
							num6 = num;
						}
						continue;
					}
					case 2u:
					{
						int num10;
						if (current is RawImage)
						{
							num = 1628221022;
							num10 = num;
						}
						else
						{
							num = 846335232;
							num10 = num;
						}
						continue;
					}
					case 7u:
						MarkAssetsInComponent((RawImage)(object)((current is RawImage) ? current : null), mark);
						num = ((int)num3 * -2028107134) ^ 0x3EF6AEAC;
						continue;
					case 18u:
						num = ((int)num3 * -1774882909) ^ 0x454110E8;
						continue;
					case 15u:
						MarkAssetsInComponent((Animator)(object)((current is Animator) ? current : null), mark);
						num = ((int)num3 * -380193714) ^ 0x62AFE212;
						continue;
					case 0u:
						num = ((int)num3 * -1508070562) ^ -1876118838;
						continue;
					case 19u:
					{
						int num5;
						if (current is Animator)
						{
							num = 899006151;
							num5 = num;
						}
						else
						{
							num = 1332267578;
							num5 = num;
						}
						continue;
					}
					case 11u:
						MarkAssetsInComponent((MeshFilter)(object)((current is MeshFilter) ? current : null), mark);
						num = ((int)num3 * -1774401117) ^ 0x4AD26059;
						continue;
					case 16u:
						break;
					case 20u:
						num = (int)((num3 * 1364431439) ^ 0x28087D4);
						continue;
					case 8u:
						MarkAssetsInComponent((AudioSource)(object)((current is AudioSource) ? current : null), mark);
						num = ((int)num3 * -1749370731) ^ 0x25494B7F;
						continue;
					case 17u:
						MarkAssetsInComponent((Animation)(object)((current is Animation) ? current : null), mark);
						num = ((int)num3 * -1096507045) ^ -835773301;
						continue;
					case 9u:
						MarkAssetsInComponent((Renderer)(object)((current is Renderer) ? current : null), mark);
						num = ((int)num3 * -1454308081) ^ -913449028;
						continue;
					case 6u:
						num = ((int)num3 * -140088060) ^ -2131705460;
						continue;
					case 3u:
					{
						current = enumerator.Current;
						int num9;
						if (current is MeshFilter)
						{
							num = 1783210315;
							num9 = num;
						}
						else
						{
							num = 1127143445;
							num9 = num;
						}
						continue;
					}
					case 4u:
					{
						int num8;
						if (current is AudioSource)
						{
							num = 2132468071;
							num8 = num;
						}
						else
						{
							num = 1704437195;
							num8 = num;
						}
						continue;
					}
					case 5u:
						MarkAssetsInComponent((Image)(object)((current is Image) ? current : null), mark);
						num = (int)((num3 * 776269586) ^ 0x4AF392A2);
						continue;
					case 13u:
					{
						int num7;
						if (current is Animation)
						{
							num = 1270032296;
							num7 = num;
						}
						else
						{
							num = 655872221;
							num7 = num;
						}
						continue;
					}
					case 1u:
					{
						int num4;
						if (current is Image)
						{
							num = 115121153;
							num4 = num;
						}
						else
						{
							num = 168889213;
							num4 = num;
						}
						continue;
					}
					case 14u:
						goto end_IL_0021;
					}
					goto IL_015f;
					continue;
					end_IL_0021:
					break;
				}
				break;
			}
		}
		components.Clear();
	}

	public virtual void MarkAssetsInComponent(Renderer asset, bool needRemove)
	{
		if (asset is SpriteRenderer)
		{
			goto IL_000b;
		}
		goto IL_00e9;
		IL_000b:
		int num = 160050539;
		goto IL_0010;
		IL_0010:
		Material[] array = default(Material[]);
		int num3 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x66AE1390)) % 11)
			{
			case 6u:
				break;
			default:
				return;
			case 1u:
				array = _202E_202D_202C_200E_202E_200D_206E_202E_202B_202C_202B_202B_200E_200C_202B_202C_202D_200E_202D_200E_200C_206C_200B_206B_202A_206F_206B_202E_202E_200C_202E_202C_200E_202A_206E_202B_200B_206E_202C_206F_202E(asset);
				num = 1300815675;
				continue;
			case 5u:
			{
				Material asset2 = array[num3];
				MarkAssetsInComponent(asset2, needRemove);
				num = 1306369964;
				continue;
			}
			case 9u:
				num3 = 0;
				num = ((int)num2 * -1424492661) ^ 0x53019877;
				continue;
			case 4u:
				goto IL_0083;
			case 3u:
				num3++;
				num = (int)((num2 * 1976029254) ^ 0x7DA455E0);
				continue;
			case 10u:
				MarkAsset((Object)(object)_206C_206F_206B_200E_206B_206D_206C_206A_202B_200F_206E_206D_202E_200D_206E_206A_206A_200E_202B_200C_200E_206E_200D_200E_206C_202A_202E_200E_200E_200D_200B_206C_202C_206E_200D_206D_200B_200F_206D_200F_202E((SkinnedMeshRenderer)(object)((asset is SkinnedMeshRenderer) ? asset : null)), needRemove);
				num = (int)((num2 * 1633522691) ^ 0x4F368CAE);
				continue;
			case 0u:
				num = ((int)num2 * -1744842029) ^ -346162030;
				continue;
			case 2u:
				goto IL_00e9;
			case 7u:
				MarkAssetsInComponent(_206A_202D_206C_202D_202E_202A_200B_206A_202B_200F_202A_202E_200B_202D_202B_206A_206B_206A_206D_202A_200B_200C_206F_206B_206B_202B_202B_200E_206B_200D_200C_200F_202C_202C_202B_200C_202C_200F_202B_202D_202E((SpriteRenderer)(object)((asset is SpriteRenderer) ? asset : null)), needRemove);
				return;
			case 8u:
				return;
			}
			break;
			IL_0083:
			int num4;
			if (num3 >= array.Length)
			{
				num = 1586566118;
				num4 = num;
			}
			else
			{
				num = 1499712514;
				num4 = num;
			}
		}
		goto IL_000b;
		IL_00e9:
		int num5;
		if (!(asset is SkinnedMeshRenderer))
		{
			num = 1235350161;
			num5 = num;
		}
		else
		{
			num = 1428688261;
			num5 = num;
		}
		goto IL_0010;
	}

	public virtual void MarkAssetsInComponent(MeshFilter asset, bool needRemove)
	{
		MarkAsset((Object)(object)_202C_202C_206A_200F_202C_202B_202E_200D_206C_206E_202B_202A_206D_200C_200E_202E_206A_206A_200F_206C_206E_200D_200D_200C_206B_200C_202D_202A_206B_206D_202E_206B_202B_200B_200D_200C_200C_206E_206F_202D_202E(asset), needRemove);
	}

	public virtual void MarkAssetsInComponent(Animation asset, bool needRemove)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		IEnumerator enumerator = _206A_202C_206D_202C_200C_200D_202E_202C_206C_202B_200E_202A_206D_206D_206C_206A_206E_200C_206D_200D_202C_200B_200D_206D_206F_200F_206C_202A_206F_206C_200C_202D_202C_200F_202E_206C_200B_206D_206C_200F_202E(asset);
		try
		{
			AnimationState val = default(AnimationState);
			while (true)
			{
				int num;
				int num2;
				if (!_200E_200C_206A_202B_202B_202C_200D_200B_200E_206B_202C_202E_206A_206E_206C_206C_202A_206B_206B_206C_202B_202C_200C_202E_206D_206B_202E_202A_206F_202C_202E_202C_206B_202D_200E_200D_206D_202A_206E_206E_202E(enumerator))
				{
					num = -1542561931;
					num2 = num;
				}
				else
				{
					num = -280298737;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -1857398719)) % 5)
					{
					case 3u:
						num = -280298737;
						continue;
					default:
						return;
					case 2u:
						val = (AnimationState)_200E_200C_206D_202C_206A_206B_200D_202E_206C_200E_202A_202A_200E_200C_202A_202E_206F_206E_206A_200E_202B_206E_206B_200C_200D_206A_202C_200E_206D_202B_202C_202D_206E_202B_200D_206C_200C_206E_206E_202D_202E(enumerator);
						num = -1359834377;
						continue;
					case 1u:
						MarkAsset((Object)(object)_202A_206E_200B_206D_200D_200D_206D_200D_206D_206C_202A_202A_202A_206A_206A_202B_202B_206B_200F_202A_206C_200F_206B_200C_206A_200C_206D_206D_200E_206B_200C_206D_206D_202A_206E_200D_202D_202D_202D_202C_202E(val), needRemove);
						num = (int)((num3 * 660130793) ^ 0x2A9069FD);
						continue;
					case 4u:
						break;
					case 0u:
						return;
					}
					break;
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable disposable)
			{
				while (true)
				{
					IL_0087:
					int num4 = -1743660286;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num4 ^ -1857398719)) % 3)
						{
						case 0u:
							break;
						default:
							goto end_IL_008c;
						case 1u:
							goto IL_00a9;
						case 2u:
							goto end_IL_008c;
						}
						goto IL_0087;
						IL_00a9:
						_202A_202C_200B_200F_202C_206F_206C_202B_202C_202B_206C_206E_206F_206D_202C_206A_202B_200B_206F_200F_200E_202B_206E_206F_202D_206A_206E_202E_200E_200D_206A_206F_202C_202B_202D_200E_200D_202B_200D_206B_202E(disposable);
						num4 = ((int)num3 * -2121362002) ^ -1909515151;
						continue;
						end_IL_008c:
						break;
					}
					break;
				}
			}
		}
	}

	public virtual void MarkAssetsInComponent(Animator asset, bool needRemove)
	{
		RuntimeAnimatorController val = _202B_200D_206D_200E_200E_202C_200C_206A_206F_206F_202B_202E_200F_206D_206E_202B_202E_206C_206E_200B_206B_200B_202E_202C_202B_206F_200E_206A_202D_202C_200C_200C_206D_202C_200E_206C_206D_206D_206C_202E(asset);
		int num3 = default(int);
		AnimationClip[] array = default(AnimationClip[]);
		AnimationClip asset2 = default(AnimationClip);
		while (true)
		{
			int num = -1318408753;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2101162616)) % 10)
				{
				case 3u:
					break;
				default:
					return;
				case 6u:
					num = ((int)num2 * -1876816532) ^ 0x3EA39731;
					continue;
				case 8u:
					return;
				case 1u:
				{
					int num5;
					int num6;
					if (_200D_206A_206E_200E_200B_206C_200D_202A_206B_206D_202C_206B_206A_202C_202B_206B_200E_200B_202A_206E_200E_202D_206C_200E_206D_200E_202B_202C_200F_202A_202A_202E_200F_200D_200C_202D_206C_206E_202A_200C_202E((Object)(object)val, (Object)null))
					{
						num5 = -380371336;
						num6 = num5;
					}
					else
					{
						num5 = -1821120209;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -308086460);
					continue;
				}
				case 7u:
				{
					int num4;
					if (num3 >= array.Length)
					{
						num = -328533466;
						num4 = num;
					}
					else
					{
						num = -2032489880;
						num4 = num;
					}
					continue;
				}
				case 4u:
					MarkAsset((Object)(object)asset2, needRemove);
					num = (int)((num2 * 1376993535) ^ 0x1ADA8C0B);
					continue;
				case 0u:
					asset2 = array[num3];
					num = -833858266;
					continue;
				case 5u:
					num3++;
					num = (int)(num2 * 870915202) ^ -1343367045;
					continue;
				case 9u:
					array = _200E_206A_206D_200C_202B_206B_200E_202B_206E_206F_206A_200E_206D_206F_206A_202A_202D_200C_206D_206C_200C_200F_200C_206C_202D_202E_200D_206C_200F_206E_202A_206D_202C_200B_202C_200C_206C_200F_200F_202E(val);
					num3 = 0;
					num = -1802991706;
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public virtual void MarkAssetsInComponent(AudioSource asset, bool needRemove)
	{
		MarkAsset((Object)(object)_202A_200F_202E_202B_202E_206C_206D_202D_200C_206A_202C_202C_206A_200C_200B_200B_200E_202B_202B_202D_206D_202B_206C_200C_206C_200F_200F_202B_200B_200D_202B_200E_200F_202C_202D_206B_200C_202D_202D_200E_202E(asset), needRemove);
	}

	public virtual void MarkAssetsInComponent(Image asset, bool needRemove)
	{
		MarkAssetsInComponent(_202C_206F_206C_200B_200F_206D_202A_202D_202C_206A_200D_206D_206F_206F_202E_202B_202B_206D_200E_202B_202E_206D_206B_206C_206B_202A_200C_206A_200F_202E_206A_200E_200F_206E_200D_200E_202E_206D_206E_202A_202E(asset), needRemove);
	}

	public virtual void MarkAssetsInComponent(RawImage asset, bool needRemove)
	{
		MarkAsset((Object)(object)_206D_202E_200F_206C_200D_206E_206C_206C_200C_200E_206C_206D_202E_206D_206A_202C_200B_200F_200B_206D_200B_206D_206F_206C_200D_202D_200F_200E_202A_206A_206E_202D_206F_206D_206A_202E_206E_206D_206D_200F_202E(asset), needRemove);
	}

	public virtual void MarkAssetsInComponent(Sprite asset, bool needRemove)
	{
		MarkAsset((Object)(object)asset, needRemove);
		MarkAsset((Object)(object)_202A_206E_206F_206B_200D_206F_200B_200F_202D_202B_202E_202D_202B_202A_206C_200B_202A_200E_206C_206C_206F_202D_200E_202A_200F_202E_206A_200B_202A_206D_200D_206B_202E_206B_200F_206D_206E_206A_206C_206C_202E(asset), needRemove);
	}

	public virtual void MarkAssetsInComponent(Material asset, bool needRemove)
	{
		MarkAsset((Object)(object)_206F_200B_206E_202A_206F_200F_200C_202A_202E_202D_200F_202B_206B_206A_206F_200F_206D_202D_200D_202D_200F_206A_200F_206E_202E_202E_200F_200B_206C_200F_206E_206E_200C_202E_202C_202B_200F_202E_202A_202E(asset), needRemove);
	}

	public virtual void MarkAssets(IEnumerable<Object> asset, bool needRemove)
	{
		IEnumerator<Object> enumerator = asset.GetEnumerator();
		try
		{
			Object current = default(Object);
			while (true)
			{
				int num;
				int num2;
				if (!_200E_200C_206A_202B_202B_202C_200D_200B_200E_206B_202C_202E_206A_206E_206C_206C_202A_206B_206B_206C_202B_202C_200C_202E_206D_206B_202E_202A_206F_202C_202E_202C_206B_202D_200E_200D_206D_202A_206E_206E_202E((IEnumerator)enumerator))
				{
					num = -113321172;
					num2 = num;
				}
				else
				{
					num = -1960225597;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -1338524313)) % 5)
					{
					case 0u:
						num = -1960225597;
						continue;
					default:
						return;
					case 3u:
						break;
					case 2u:
						MarkAsset(current, needRemove);
						num = (int)((num3 * 1130912397) ^ 0x1B92124C);
						continue;
					case 1u:
						current = enumerator.Current;
						num = -323705177;
						continue;
					case 4u:
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
					IL_0076:
					int num4 = -423241182;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num4 ^ -1338524313)) % 3)
						{
						case 0u:
							break;
						default:
							goto end_IL_007b;
						case 2u:
							goto IL_0098;
						case 1u:
							goto end_IL_007b;
						}
						goto IL_0076;
						IL_0098:
						_202A_202C_200B_200F_202C_206F_206C_202B_202C_202B_206C_206E_206F_206D_202C_206A_202B_200B_206F_200F_200E_202B_206E_206F_202D_206A_206E_202E_200E_200D_206A_206F_202C_202B_202D_200E_200D_202B_200D_206B_202E((IDisposable)enumerator);
						num4 = (int)(num3 * 814951658) ^ -1278412347;
						continue;
						end_IL_007b:
						break;
					}
					break;
				}
			}
		}
	}

	public virtual void MarkAsset(Object asset, bool needRemove)
	{
		if (needRemove)
		{
			goto IL_0003;
		}
		goto IL_0049;
		IL_0003:
		int num = -254588514;
		goto IL_0008;
		IL_0008:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -790902597)) % 5)
			{
			case 0u:
				break;
			default:
				return;
			case 1u:
				markDatas.Add(asset);
				num = ((int)num2 * -565764822) ^ -1374481608;
				continue;
			case 3u:
				goto IL_0049;
			case 2u:
				return;
			case 4u:
				return;
			}
			break;
		}
		goto IL_0003;
		IL_0049:
		markDatas.Remove(asset);
		num = -2038953026;
		goto IL_0008;
	}

	public void Run()
	{
		using (HashSet<Object>.Enumerator enumerator = markDatas.GetEnumerator())
		{
			while (true)
			{
				IL_0047:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 692497294;
					num2 = num;
				}
				else
				{
					num = 658722964;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x4C512860)) % 4)
					{
					case 3u:
						num = 692497294;
						continue;
					default:
						goto end_IL_0013;
					case 2u:
						_202B_202E_206A_200F_206D_202C_202E_206A_202C_202A_202B_200F_202C_202B_200F_206B_200B_200E_200C_202D_206D_200F_202A_202A_206B_206D_206C_202A_202C_202D_206D_206E_200F_200E_206F_200B_200D_200C_206D_200E_202E(enumerator.Current);
						num = 412653765;
						continue;
					case 1u:
						break;
					case 0u:
						goto end_IL_0013;
					}
					goto IL_0047;
					continue;
					end_IL_0013:
					break;
				}
				break;
			}
		}
		markDatas.Clear();
	}

	static bool _200E_200C_206A_202B_202B_202C_200D_200B_200E_206B_202C_202E_206A_206E_206C_206C_202A_206B_206B_206C_202B_202C_200C_202E_206D_206B_202E_202A_206F_202C_202E_202C_206B_202D_200E_200D_206D_202A_206E_206E_202E(IEnumerator P_0)
	{
		return P_0.MoveNext();
	}

	static void _202A_202C_200B_200F_202C_206F_206C_202B_202C_202B_206C_206E_206F_206D_202C_206A_202B_200B_206F_200F_200E_202B_206E_206F_202D_206A_206E_202E_200E_200D_206A_206F_202C_202B_202D_200E_200D_202B_200D_206B_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}

	static Sprite _206A_202D_206C_202D_202E_202A_200B_206A_202B_200F_202A_202E_200B_202D_202B_206A_206B_206A_206D_202A_200B_200C_206F_206B_206B_202B_202B_200E_206B_200D_200C_200F_202C_202C_202B_200C_202C_200F_202B_202D_202E(SpriteRenderer P_0)
	{
		return P_0.sprite;
	}

	static Mesh _206C_206F_206B_200E_206B_206D_206C_206A_202B_200F_206E_206D_202E_200D_206E_206A_206A_200E_202B_200C_200E_206E_200D_200E_206C_202A_202E_200E_200E_200D_200B_206C_202C_206E_200D_206D_200B_200F_206D_200F_202E(SkinnedMeshRenderer P_0)
	{
		return P_0.sharedMesh;
	}

	static Material[] _202E_202D_202C_200E_202E_200D_206E_202E_202B_202C_202B_202B_200E_200C_202B_202C_202D_200E_202D_200E_200C_206C_200B_206B_202A_206F_206B_202E_202E_200C_202E_202C_200E_202A_206E_202B_200B_206E_202C_206F_202E(Renderer P_0)
	{
		return P_0.sharedMaterials;
	}

	static Mesh _202C_202C_206A_200F_202C_202B_202E_200D_206C_206E_202B_202A_206D_200C_200E_202E_206A_206A_200F_206C_206E_200D_200D_200C_206B_200C_202D_202A_206B_206D_202E_206B_202B_200B_200D_200C_200C_206E_206F_202D_202E(MeshFilter P_0)
	{
		return P_0.sharedMesh;
	}

	static IEnumerator _206A_202C_206D_202C_200C_200D_202E_202C_206C_202B_200E_202A_206D_206D_206C_206A_206E_200C_206D_200D_202C_200B_200D_206D_206F_200F_206C_202A_206F_206C_200C_202D_202C_200F_202E_206C_200B_206D_206C_200F_202E(Animation P_0)
	{
		return P_0.GetEnumerator();
	}

	static object _200E_200C_206D_202C_206A_206B_200D_202E_206C_200E_202A_202A_200E_200C_202A_202E_206F_206E_206A_200E_202B_206E_206B_200C_200D_206A_202C_200E_206D_202B_202C_202D_206E_202B_200D_206C_200C_206E_206E_202D_202E(IEnumerator P_0)
	{
		return P_0.Current;
	}

	static AnimationClip _202A_206E_200B_206D_200D_200D_206D_200D_206D_206C_202A_202A_202A_206A_206A_202B_202B_206B_200F_202A_206C_200F_206B_200C_206A_200C_206D_206D_200E_206B_200C_206D_206D_202A_206E_200D_202D_202D_202D_202C_202E(AnimationState P_0)
	{
		return P_0.clip;
	}

	static RuntimeAnimatorController _202B_200D_206D_200E_200E_202C_200C_206A_206F_206F_202B_202E_200F_206D_206E_202B_202E_206C_206E_200B_206B_200B_202E_202C_202B_206F_200E_206A_202D_202C_200C_200C_206D_202C_200E_206C_206D_206D_206C_202E(Animator P_0)
	{
		return P_0.runtimeAnimatorController;
	}

	static bool _200D_206A_206E_200E_200B_206C_200D_202A_206B_206D_202C_206B_206A_202C_202B_206B_200E_200B_202A_206E_200E_202D_206C_200E_206D_200E_202B_202C_200F_202A_202A_202E_200F_200D_200C_202D_206C_206E_202A_200C_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static AnimationClip[] _200E_206A_206D_200C_202B_206B_200E_202B_206E_206F_206A_200E_206D_206F_206A_202A_202D_200C_206D_206C_200C_200F_200C_206C_202D_202E_200D_206C_200F_206E_202A_206D_202C_200B_202C_200C_206C_200F_200F_202E(RuntimeAnimatorController P_0)
	{
		return P_0.animationClips;
	}

	static AudioClip _202A_200F_202E_202B_202E_206C_206D_202D_200C_206A_202C_202C_206A_200C_200B_200B_200E_202B_202B_202D_206D_202B_206C_200C_206C_200F_200F_202B_200B_200D_202B_200E_200F_202C_202D_206B_200C_202D_202D_200E_202E(AudioSource P_0)
	{
		return P_0.clip;
	}

	static Sprite _202C_206F_206C_200B_200F_206D_202A_202D_202C_206A_200D_206D_206F_206F_202E_202B_202B_206D_200E_202B_202E_206D_206B_206C_206B_202A_200C_206A_200F_202E_206A_200E_200F_206E_200D_200E_202E_206D_206E_202A_202E(Image P_0)
	{
		return P_0.sprite;
	}

	static Texture _206D_202E_200F_206C_200D_206E_206C_206C_200C_200E_206C_206D_202E_206D_206A_202C_200B_200F_200B_206D_200B_206D_206F_206C_200D_202D_200F_200E_202A_206A_206E_202D_206F_206D_206A_202E_206E_206D_206D_200F_202E(RawImage P_0)
	{
		return P_0.texture;
	}

	static Texture2D _202A_206E_206F_206B_200D_206F_200B_200F_202D_202B_202E_202D_202B_202A_206C_200B_202A_200E_206C_206C_206F_202D_200E_202A_200F_202E_206A_200B_202A_206D_200D_206B_202E_206B_200F_206D_206E_206A_206C_206C_202E(Sprite P_0)
	{
		return P_0.texture;
	}

	static Texture _206F_200B_206E_202A_206F_200F_200C_202A_202E_202D_200F_202B_206B_206A_206F_200F_206D_202D_200D_202D_200F_206A_200F_206E_202E_202E_200F_200B_206C_200F_206E_206E_200C_202E_202C_202B_200F_202E_202A_202E(Material P_0)
	{
		return P_0.mainTexture;
	}

	static void _202B_202E_206A_200F_206D_202C_202E_206A_202C_202A_202B_200F_202C_202B_200F_206B_200B_200E_200C_202D_206D_200F_202A_202A_206B_206D_206C_202A_202C_202D_206D_206E_200F_200E_206F_200B_200D_200C_206D_200E_202E(Object P_0)
	{
		Resources.UnloadAsset(P_0);
	}
}
