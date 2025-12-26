using System.Collections.Generic;
using System.Xml.Serialization;

namespace JyGame;

[XmlType("map")]
public class Map : BasePojo
{
	private bool initFlag;

	[XmlAttribute("name")]
	public string Name;

	[XmlAttribute("pic")]
	public string Pic;

	[XmlAttribute("desc")]
	public string Desc;

	[XmlArrayItem(typeof(Music))]
	[XmlArray("musics")]
	public List<Music> Musics;

	[XmlElement("mapunit")]
	public List<MapLocation> MapUnits = new List<MapLocation>();

	private List<MapLocation> locations = new List<MapLocation>();

	private List<MapRole> mapRoles = new List<MapRole>();

	[XmlArray("pictures")]
	[XmlArrayItem(typeof(Picture))]
	public List<Picture> Pictures;

	[XmlAttribute("order")]
	public int Order;

	public override string PK => Name;

	public List<MapLocation> Locations
	{
		get
		{
			init();
			return locations;
		}
	}

	public List<MapRole> MapRoles
	{
		get
		{
			init();
			return mapRoles;
		}
	}

	public Music GetRandomMusic()
	{
		if (Musics == null)
		{
			goto IL_0008;
		}
		goto IL_003f;
		IL_0008:
		int num = -856626520;
		goto IL_000d;
		IL_000d:
		uint num2;
		switch ((num2 = (uint)(num ^ -1938467679)) % 4)
		{
		case 3u:
			break;
		case 1u:
			return null;
		case 2u:
			goto IL_003f;
		default:
			goto IL_004c;
		}
		goto IL_0008;
		IL_004c:
		List<Music> list = default(List<Music>);
		using (List<Music>.Enumerator enumerator = Musics.GetEnumerator())
		{
			Music current = default(Music);
			while (true)
			{
				IL_00bf:
				int num3;
				int num4;
				if (!enumerator.MoveNext())
				{
					num3 = -144385330;
					num4 = num3;
				}
				else
				{
					num3 = -611618860;
					num4 = num3;
				}
				while (true)
				{
					switch ((num2 = (uint)(num3 ^ -1938467679)) % 6)
					{
					case 0u:
						num3 = -611618860;
						continue;
					default:
						goto end_IL_005f;
					case 2u:
						list.Add(current);
						num3 = (int)((num2 * 232510779) ^ 0x7B85943E);
						continue;
					case 4u:
					{
						int num5;
						int num6;
						if (current.IsActive)
						{
							num5 = 822767011;
							num6 = num5;
						}
						else
						{
							num5 = 1563088568;
							num6 = num5;
						}
						num3 = num5 ^ (int)(num2 * 1436809490);
						continue;
					}
					case 5u:
						break;
					case 1u:
						current = enumerator.Current;
						num3 = -220621253;
						continue;
					case 3u:
						goto end_IL_005f;
					}
					goto IL_00bf;
					continue;
					end_IL_005f:
					break;
				}
				break;
			}
		}
		if (list.Count == 0)
		{
			while (true)
			{
				switch ((num2 = 1650581135u) % 3)
				{
				case 0u:
					continue;
				case 2u:
					return null;
				}
				break;
			}
		}
		return list[Tools.GetRandomInt(0, list.Count - 1)];
		IL_003f:
		list = new List<Music>();
		num = -1254086775;
		goto IL_000d;
	}

	private void init()
	{
		if (initFlag)
		{
			return;
		}
		MapLocation current = default(MapLocation);
		MapLocation current2 = default(MapLocation);
		while (true)
		{
			int num = 858197619;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x31EBB5D0)) % 5)
				{
				case 0u:
					break;
				case 3u:
					if (MapUnits[0].y > 0)
					{
						num = (int)(num2 * 129160376) ^ -2138543659;
						continue;
					}
					goto IL_0169;
				case 4u:
					if (MapUnits[0].x > 0)
					{
						num = (int)((num2 * 685528212) ^ 0x49467159);
						continue;
					}
					goto IL_0169;
				case 1u:
					if (MapUnits.Count > 0)
					{
						num = ((int)num2 * -368290508) ^ 0x3C08F2FC;
						continue;
					}
					goto IL_01f5;
				default:
					{
						using (List<MapLocation>.Enumerator enumerator = MapUnits.GetEnumerator())
						{
							while (true)
							{
								IL_00eb:
								int num3;
								int num4;
								if (enumerator.MoveNext())
								{
									num3 = 1593654803;
									num4 = num3;
								}
								else
								{
									num3 = 1732033720;
									num4 = num3;
								}
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ 0x31EBB5D0)) % 5)
									{
									case 0u:
										num3 = 1593654803;
										continue;
									default:
										goto end_IL_00b7;
									case 2u:
										current = enumerator.Current;
										num3 = 853104998;
										continue;
									case 3u:
										break;
									case 1u:
										locations.Add(current);
										num3 = (int)((num2 * 285395555) ^ 0x1CBE1B45);
										continue;
									case 4u:
										goto end_IL_00b7;
									}
									goto IL_00eb;
									continue;
									end_IL_00b7:
									break;
								}
								break;
							}
						}
						initFlag = true;
						while (true)
						{
							switch ((num2 = 1616655631u) % 3)
							{
							case 0u:
								continue;
							case 1u:
								return;
							}
							break;
						}
						goto IL_0169;
					}
					IL_0169:
					using (List<MapLocation>.Enumerator enumerator = MapUnits.GetEnumerator())
					{
						while (true)
						{
							IL_01b0:
							int num5;
							int num6;
							if (enumerator.MoveNext())
							{
								num5 = 506434836;
								num6 = num5;
							}
							else
							{
								num5 = 1476097263;
								num6 = num5;
							}
							while (true)
							{
								switch ((num2 = (uint)(num5 ^ 0x31EBB5D0)) % 5)
								{
								case 3u:
									num5 = 506434836;
									continue;
								default:
									goto end_IL_017c;
								case 1u:
									current2 = enumerator.Current;
									num5 = 995086958;
									continue;
								case 0u:
									break;
								case 2u:
									mapRoles.Add(current2);
									num5 = ((int)num2 * -1917715842) ^ 0x3F300C6E;
									continue;
								case 4u:
									goto end_IL_017c;
								}
								goto IL_01b0;
								continue;
								end_IL_017c:
								break;
							}
							break;
						}
					}
					goto IL_01f5;
					IL_01f5:
					initFlag = true;
					return;
				}
				break;
			}
		}
	}

	public Picture GetPic()
	{
		if (Pictures != null)
		{
			using List<Picture>.Enumerator enumerator = Pictures.GetEnumerator();
			Picture result = default(Picture);
			Picture current = default(Picture);
			while (true)
			{
				IL_0047:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -2077982955;
					num2 = num;
				}
				else
				{
					num = -1905442686;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -347065366)) % 6)
					{
					case 5u:
						num = -2077982955;
						continue;
					default:
						goto end_IL_001e;
					case 4u:
						break;
					case 1u:
						result = current;
						num = ((int)num3 * -1402778859) ^ 0x5F019C09;
						continue;
					case 3u:
					{
						current = enumerator.Current;
						int num4;
						if (!current.IsActive)
						{
							num = -1924902066;
							num4 = num;
						}
						else
						{
							num = -947722193;
							num4 = num;
						}
						continue;
					}
					case 0u:
						goto end_IL_001e;
					case 2u:
						return result;
					}
					goto IL_0047;
					continue;
					end_IL_001e:
					break;
				}
				break;
			}
		}
		return new Picture
		{
			Name = Pic
		};
	}
}
