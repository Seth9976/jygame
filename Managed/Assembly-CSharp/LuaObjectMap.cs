using System.Collections.Generic;

public class LuaObjectMap
{
	private List<object> list;

	private Queue<int> pool;

	public object this[int i] => list[i];

	public LuaObjectMap()
	{
		while (true)
		{
			int num = -799434880;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -956902845)) % 3)
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
				list = new List<object>(1024);
				pool = new Queue<int>(1024);
				num = (int)(num2 * 600215250) ^ -1117091290;
			}
		}
	}

	public int Add(object obj)
	{
		int num = -1;
		if (pool.Count > 0)
		{
			goto IL_0010;
		}
		goto IL_003e;
		IL_0010:
		int num2 = -1883873193;
		goto IL_0015;
		IL_0015:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ -1242987560)) % 6)
			{
			case 4u:
				break;
			case 5u:
				goto IL_003e;
			case 0u:
				num2 = ((int)num3 * -1350316294) ^ -1524462027;
				continue;
			case 2u:
				num = list.Count - 1;
				num2 = ((int)num3 * -11422775) ^ -1251095865;
				continue;
			case 1u:
				num = pool.Dequeue();
				list[num] = obj;
				num2 = (int)((num3 * 1030344355) ^ 0x10FC44D9);
				continue;
			default:
				return num;
			}
			break;
		}
		goto IL_0010;
		IL_003e:
		list.Add(obj);
		num2 = -918062046;
		goto IL_0015;
	}

	public bool TryGetValue(int index, out object obj)
	{
		if (index >= 0)
		{
			goto IL_0004;
		}
		goto IL_0032;
		IL_0004:
		int num = -1343434741;
		goto IL_0009;
		IL_0009:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -657107254)) % 6)
			{
			case 2u:
				break;
			case 3u:
				goto IL_0032;
			case 4u:
				return obj != null;
			case 0u:
				obj = list[index];
				num = (int)((num2 * 1986548060) ^ 0x407938DE);
				continue;
			case 5u:
			{
				int num3;
				int num4;
				if (index < list.Count)
				{
					num3 = 1346261879;
					num4 = num3;
				}
				else
				{
					num3 = 1147828992;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 1439937231);
				continue;
			}
			default:
				return false;
			}
			break;
		}
		goto IL_0004;
		IL_0032:
		obj = null;
		num = -1208283841;
		goto IL_0009;
	}

	public object Remove(int index)
	{
		if (index >= 0)
		{
			object obj = default(object);
			while (true)
			{
				int num = 1725606345;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x4292029C)) % 7)
					{
					case 2u:
						break;
					case 3u:
						list[index] = null;
						num = 945421006;
						continue;
					case 6u:
						return obj;
					case 4u:
					{
						int num5;
						int num6;
						if (index < list.Count)
						{
							num5 = 622616694;
							num6 = num5;
						}
						else
						{
							num5 = 1384627506;
							num6 = num5;
						}
						num = num5 ^ (int)(num2 * 397287461);
						continue;
					}
					case 1u:
						pool.Enqueue(index);
						num = (int)(num2 * 1617723464) ^ -967426728;
						continue;
					case 5u:
					{
						obj = list[index];
						int num3;
						int num4;
						if (obj == null)
						{
							num3 = 1028017300;
							num4 = num3;
						}
						else
						{
							num3 = 1685702780;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -167347356);
						continue;
					}
					default:
						goto end_IL_0007;
					}
					break;
				}
				continue;
				end_IL_0007:
				break;
			}
		}
		return null;
	}
}
