using System.Threading;

public class LockFreeQueue<T>
{
	public int head;

	public int tail;

	public T[] items;

	private int capacity;

	public int Count => tail - head;

	public LockFreeQueue()
		: this(64)
	{
	}

	public LockFreeQueue(int P_0)
	{
		while (true)
		{
			int num = 1401905016;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5B688329)) % 4)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					items = new T[P_0];
					tail = (head = 0);
					num = (int)(num2 * 427285359) ^ -34620671;
					continue;
				case 3u:
					capacity = P_0;
					num = ((int)num2 * -198458781) ^ -307779484;
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public bool IsEmpty()
	{
		return head == tail;
	}

	public void Clear()
	{
		head = (tail = 0);
	}

	private bool IsFull()
	{
		return tail - head >= capacity;
	}

	public void Enqueue(T item)
	{
		int num4 = default(int);
		while (true)
		{
			int num;
			int num2;
			if (IsFull())
			{
				num = 1412189458;
				num2 = num;
			}
			else
			{
				num = 1260813894;
				num2 = num;
			}
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num ^ 0x68088E08)) % 6)
				{
				case 3u:
					num = 1412189458;
					continue;
				case 2u:
					_200F_200C_206C_206C_202B_206C_200E_202D_202B_206C_200E_206B_200E_200C_202D_202A_202B_200B_200F_206A_206D_206B_206D_202E_206F_200E_202C_206E_202A_200D_206F_206A_200E_206F_206F_200B_206C_200C_206A_206C_202E(1);
					num = 2030542248;
					continue;
				case 1u:
					items[num4] = item;
					num = (int)(num3 * 1903222805) ^ -367393684;
					continue;
				case 4u:
					break;
				case 0u:
					num4 = tail % capacity;
					num = (int)(num3 * 1465093220) ^ -998438131;
					continue;
				default:
					tail++;
					return;
				}
				break;
			}
		}
	}

	public T Dequeue()
	{
		if (IsEmpty())
		{
			goto IL_0008;
		}
		goto IL_005a;
		IL_0008:
		int num = 362687704;
		goto IL_000d;
		IL_000d:
		T result2 = default(T);
		T result = default(T);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x15906329)) % 5)
			{
			case 0u:
				break;
			case 4u:
				result2 = default(T);
				num = ((int)num2 * -2045028505) ^ 0x7399FDFB;
				continue;
			case 2u:
				return result2;
			case 3u:
				goto IL_005a;
			default:
				return result;
			}
			break;
		}
		goto IL_0008;
		IL_005a:
		int num3 = head % capacity;
		result = items[num3];
		head++;
		num = 97111230;
		goto IL_000d;
	}

	static void _200F_200C_206C_206C_202B_206C_200E_202D_202B_206C_200E_206B_200E_200C_202D_202A_202B_200B_200F_206A_206D_206B_206D_202E_206F_200E_202C_206E_202A_200D_206F_206A_200E_206F_206F_200B_206C_200C_206A_206C_202E(int P_0)
	{
		Thread.Sleep(P_0);
	}
}
