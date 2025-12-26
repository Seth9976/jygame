using System;
using System.IO;
using System.IO.Compression;

namespace ZyGames.Framework.RPC.IO;

public static class GzipUtils
{
	public static byte[] EnCompress(Stream aSourceStream)
	{
		MemoryStream memoryStream = _200D_200E_200B_206B_202C_200D_200F_202E_202A_202C_200E_200B_202E_200D_202A_200E_206F_206D_202D_202B_200B_206D_206E_206F_206D_206F_202B_200D_202A_202A_202C_200F_206D_200B_206C_206A_200E_202C_202D_202A_202E();
		int num4 = default(int);
		while (true)
		{
			int num = 926236011;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3C70FEF9)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_0029;
				default:
					_200D_202C_200B_206A_206D_206D_202E_200F_200D_200F_202C_206C_206A_200C_206B_206D_200B_200B_202A_202C_206F_202D_202A_202C_202D_206D_206B_200C_202B_202B_206A_202B_200F_202B_200F_200F_206F_202C_200F_206E_202E(memoryStream, 0L, SeekOrigin.Begin);
					try
					{
						GZipStream gZipStream = _206D_206D_202B_206A_200C_200C_202D_200B_206C_200B_202E_200B_206A_206E_206F_206D_202D_206D_200B_200F_202E_200D_206C_206A_202E_200C_202B_200B_206E_200D_206E_206E_206E_200E_202C_206A_206C_206E_206C_206F_202E((Stream)memoryStream, CompressionMode.Compress);
						try
						{
							byte[] array = new byte[1024];
							while (true)
							{
								IL_0060:
								int num3 = 1208155931;
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ 0x3C70FEF9)) % 5)
									{
									case 0u:
										break;
									default:
										goto end_IL_0065;
									case 2u:
										num4 = 0;
										num3 = ((int)num2 * -397386080) ^ 0x77DE76A2;
										continue;
									case 3u:
										num4 = _206D_200D_206F_200E_206F_206B_202C_206D_202D_206D_200F_200F_202E_206D_206E_200D_206F_202D_206C_206D_200B_206B_200E_206D_202A_206F_200F_206C_206C_200B_202E_202C_202A_200E_200C_206C_206A_200B_202B_202E_202E(aSourceStream, array, 0, array.Length);
										num3 = 1681256111;
										continue;
									case 4u:
									{
										_206F_206A_200F_206C_202D_202C_200D_202E_200F_200F_202D_206E_206B_206D_200F_200D_200D_202A_200F_202C_200F_200C_206B_200F_202C_206D_206A_206D_202B_202B_206B_202C_200D_202C_206F_206A_206B_200C_206B_200F_202E(gZipStream, array, 0, num4);
										int num5;
										int num6;
										if (num4 > 0)
										{
											num5 = -1487144322;
											num6 = num5;
										}
										else
										{
											num5 = -177937847;
											num6 = num5;
										}
										num3 = num5 ^ ((int)num2 * -1416834198);
										continue;
									}
									case 1u:
										goto end_IL_0065;
									}
									goto IL_0060;
									continue;
									end_IL_0065:
									break;
								}
								break;
							}
						}
						finally
						{
							if (gZipStream != null)
							{
								while (true)
								{
									IL_00dc:
									int num7 = 684973443;
									while (true)
									{
										switch ((num2 = (uint)(num7 ^ 0x3C70FEF9)) % 3)
										{
										case 2u:
											break;
										default:
											goto end_IL_00e1;
										case 1u:
											goto IL_00ff;
										case 0u:
											goto end_IL_00e1;
										}
										goto IL_00dc;
										IL_00ff:
										_202D_200C_202B_202D_202A_206C_200E_200B_206E_202C_202A_202D_206C_206E_206A_206B_206C_202D_200F_206A_202D_206F_200E_206D_202B_206E_200C_200C_206D_206E_206E_206F_202A_202C_202E_206C_202A_200D_206B_202A_202E((IDisposable)gZipStream);
										num7 = ((int)num2 * -426161825) ^ -300644548;
										continue;
										end_IL_00e1:
										break;
									}
									break;
								}
							}
						}
					}
					finally
					{
						_202C_206C_206B_202A_202A_206C_202C_206E_200C_200D_200B_206D_200D_206E_206B_202C_202E_206F_202D_202C_202B_202C_206B_200C_200B_202D_206B_200E_206A_206A_206C_206C_200C_200C_200F_200F_206D_200E_206C_206F_202E((Stream)memoryStream);
					}
					return _202B_206B_206C_202D_200F_200C_200C_206D_200F_200F_206E_202E_200E_206C_206E_202D_202B_206F_200D_202E_200E_206D_200F_202B_206B_206F_202B_200C_200E_206F_202B_200F_206B_200F_200F_202B_206F_202A_202E_200E_202E(memoryStream);
				}
				break;
				IL_0029:
				_202C_206A_202D_200F_200D_202C_202E_200F_202E_202E_206A_200C_200B_206A_200B_206C_202C_200F_202E_200C_202C_202D_200C_202C_206A_206C_200E_200E_202A_202D_200C_206C_206A_206C_206F_200F_206E_200D_202D_202B_202E(aSourceStream, 0L, SeekOrigin.Begin);
				num = ((int)num2 * -1745071743) ^ 0x30AA059F;
			}
		}
	}

	public static byte[] EnCompress(byte[] aSourceStream, int index, int count)
	{
		MemoryStream memoryStream = _202C_202E_206C_200D_200C_202C_202B_202C_206C_200C_200F_206B_206E_202A_200D_200F_202B_202E_202A_206C_200E_200C_202E_206B_206B_206F_206A_200D_202D_202B_202D_206C_206A_206C_200D_206A_206E_206E_202E_202C_202E(aSourceStream, index, count);
		byte[] result;
		try
		{
			result = EnCompress(memoryStream);
			while (true)
			{
				uint num;
				switch ((num = 585738760u) % 3)
				{
				case 2u:
					break;
				default:
					goto end_IL_0010;
				case 1u:
					goto end_IL_0010;
				case 0u:
					goto end_IL_0010;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
		finally
		{
			if (memoryStream != null)
			{
				while (true)
				{
					IL_0048:
					int num2 = 1060672104;
					while (true)
					{
						uint num;
						switch ((num = (uint)(num2 ^ 0x66D73751)) % 3)
						{
						case 0u:
							break;
						default:
							goto end_IL_004d;
						case 1u:
							goto IL_006a;
						case 2u:
							goto end_IL_004d;
						}
						goto IL_0048;
						IL_006a:
						_202D_200C_202B_202D_202A_206C_200E_200B_206E_202C_202A_202D_206C_206E_206A_206B_206C_202D_200F_206A_202D_206F_200E_206D_202B_206E_200C_200C_206D_206E_206E_206F_202A_202C_202E_206C_202A_200D_206B_202A_202E((IDisposable)memoryStream);
						num2 = ((int)num * -1189430136) ^ -842167035;
						continue;
						end_IL_004d:
						break;
					}
					break;
				}
			}
		}
		return result;
	}

	public static byte[] DeCompress(Stream aSourceStream)
	{
		byte[] array = null;
		MemoryStream memoryStream = _200D_200E_200B_206B_202C_200D_200F_202E_202A_202C_200E_200B_202E_200D_202A_200E_206F_206D_202D_202B_200B_206D_206E_206F_206D_206F_202B_200D_202A_202A_202C_200F_206D_200B_206C_206A_200E_202C_202D_202A_202E();
		try
		{
			GZipStream gZipStream = _206D_206D_202B_206A_200C_200C_202D_200B_206C_200B_202E_200B_206A_206E_206F_206D_202D_206D_200B_200F_202E_200D_206C_206A_202E_200C_202B_200B_206E_200D_206E_206E_206E_200E_202C_206A_206C_206E_206C_206F_202E(aSourceStream, CompressionMode.Decompress);
			try
			{
				byte[] array2 = new byte[1024];
				int num3 = default(int);
				while (true)
				{
					IL_001b:
					int num = -1571199063;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ -723298740)) % 6)
						{
						case 4u:
							break;
						default:
							goto end_IL_0020;
						case 2u:
						{
							_206C_200B_200C_200B_200D_202C_202D_200E_200B_202E_200D_206E_206C_200B_200F_202E_206C_206D_206C_202C_200F_200B_202B_200F_206D_200B_200D_206A_200D_202A_202C_200C_206D_206A_206A_206E_206F_200B_200D_202E_202E(memoryStream, array2, 0, num3);
							int num4;
							int num5;
							if (num3 <= 0)
							{
								num4 = -1304211914;
								num5 = num4;
							}
							else
							{
								num4 = -710215915;
								num5 = num4;
							}
							num = num4 ^ ((int)num2 * -1888027084);
							continue;
						}
						case 5u:
							num3 = _206F_202C_200E_206B_206F_206D_200D_202D_200C_200F_200C_200C_206D_202A_206E_202C_202C_206E_202D_200F_200E_200C_200E_200B_200B_202B_202A_206F_206B_206F_202D_202C_202A_206E_206F_202C_202E_200E_200C_200E_202E(gZipStream, array2, 0, array2.Length);
							num = -1458895554;
							continue;
						case 0u:
							_206B_200B_200B_206F_200F_200B_200C_202B_202D_202A_202D_206B_202D_202C_206C_206D_200C_202B_202E_206C_202A_202A_200C_202B_206E_206C_202E_206A_206B_202D_200B_206D_200C_202A_202A_200F_206F_200E_206E_202D_202E((Stream)gZipStream);
							num = (int)(num2 * 756801098) ^ -736374571;
							continue;
						case 3u:
							num3 = 0;
							num = ((int)num2 * -279213367) ^ -245405968;
							continue;
						case 1u:
							goto end_IL_0020;
						}
						goto IL_001b;
						continue;
						end_IL_0020:
						break;
					}
					break;
				}
			}
			finally
			{
				_202C_206C_206B_202A_202A_206C_202C_206E_200C_200D_200B_206D_200D_206E_206B_202C_202E_206F_202D_202C_202B_202C_206B_200C_200B_202D_206B_200E_206A_206A_206C_206C_200C_200C_200F_200F_206D_200E_206C_206F_202E((Stream)gZipStream);
			}
			return _202B_206B_206C_202D_200F_200C_200C_206D_200F_200F_206E_202E_200E_206C_206E_202D_202B_206F_200D_202E_200E_206D_200F_202B_206B_206F_202B_200C_200E_206F_202B_200F_206B_200F_200F_202B_206F_202A_202E_200E_202E(memoryStream);
		}
		finally
		{
			if (memoryStream != null)
			{
				while (true)
				{
					IL_00c8:
					int num6 = -950819970;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num6 ^ -723298740)) % 3)
						{
						case 0u:
							break;
						default:
							goto end_IL_00cd;
						case 1u:
							goto IL_00eb;
						case 2u:
							goto end_IL_00cd;
						}
						goto IL_00c8;
						IL_00eb:
						_202D_200C_202B_202D_202A_206C_200E_200B_206E_202C_202A_202D_206C_206E_206A_206B_206C_202D_200F_206A_202D_206F_200E_206D_202B_206E_200C_200C_206D_206E_206E_206F_202A_202C_202E_206C_202A_200D_206B_202A_202E((IDisposable)memoryStream);
						num6 = (int)(num2 * 954486051) ^ -319779870;
						continue;
						end_IL_00cd:
						break;
					}
					break;
				}
			}
		}
	}

	public static byte[] DeCompress(byte[] aSourceByte, int index, int count)
	{
		MemoryStream memoryStream = _202C_202E_206C_200D_200C_202C_202B_202C_206C_200C_200F_206B_206E_202A_200D_200F_202B_202E_202A_206C_200E_200C_202E_206B_206B_206F_206A_200D_202D_202B_202D_206C_206A_206C_200D_206A_206E_206E_202E_202C_202E(aSourceByte, index, count);
		try
		{
			return DeCompress(memoryStream);
		}
		finally
		{
			if (memoryStream != null)
			{
				while (true)
				{
					IL_0017:
					int num = 501046266;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ 0x1873FBDF)) % 3)
						{
						case 2u:
							break;
						default:
							goto end_IL_001c;
						case 1u:
							goto IL_0039;
						case 0u:
							goto end_IL_001c;
						}
						goto IL_0017;
						IL_0039:
						_202D_200C_202B_202D_202A_206C_200E_200B_206E_202C_202A_202D_206C_206E_206A_206B_206C_202D_200F_206A_202D_206F_200E_206D_202B_206E_200C_200C_206D_206E_206E_206F_202A_202C_202E_206C_202A_200D_206B_202A_202E((IDisposable)memoryStream);
						num = (int)(num2 * 893648834) ^ -1135840943;
						continue;
						end_IL_001c:
						break;
					}
					break;
				}
			}
		}
	}

	static MemoryStream _200D_200E_200B_206B_202C_200D_200F_202E_202A_202C_200E_200B_202E_200D_202A_200E_206F_206D_202D_202B_200B_206D_206E_206F_206D_206F_202B_200D_202A_202A_202C_200F_206D_200B_206C_206A_200E_202C_202D_202A_202E()
	{
		return new MemoryStream();
	}

	static long _202C_206A_202D_200F_200D_202C_202E_200F_202E_202E_206A_200C_200B_206A_200B_206C_202C_200F_202E_200C_202C_202D_200C_202C_206A_206C_200E_200E_202A_202D_200C_206C_206A_206C_206F_200F_206E_200D_202D_202B_202E(Stream P_0, long P_1, SeekOrigin P_2)
	{
		return P_0.Seek(P_1, P_2);
	}

	static long _200D_202C_200B_206A_206D_206D_202E_200F_200D_200F_202C_206C_206A_200C_206B_206D_200B_200B_202A_202C_206F_202D_202A_202C_202D_206D_206B_200C_202B_202B_206A_202B_200F_202B_200F_200F_206F_202C_200F_206E_202E(MemoryStream P_0, long P_1, SeekOrigin P_2)
	{
		return P_0.Seek(P_1, P_2);
	}

	static GZipStream _206D_206D_202B_206A_200C_200C_202D_200B_206C_200B_202E_200B_206A_206E_206F_206D_202D_206D_200B_200F_202E_200D_206C_206A_202E_200C_202B_200B_206E_200D_206E_206E_206E_200E_202C_206A_206C_206E_206C_206F_202E(Stream P_0, CompressionMode P_1)
	{
		return new GZipStream(P_0, P_1);
	}

	static int _206D_200D_206F_200E_206F_206B_202C_206D_202D_206D_200F_200F_202E_206D_206E_200D_206F_202D_206C_206D_200B_206B_200E_206D_202A_206F_200F_206C_206C_200B_202E_202C_202A_200E_200C_206C_206A_200B_202B_202E_202E(Stream P_0, byte[] P_1, int P_2, int P_3)
	{
		return P_0.Read(P_1, P_2, P_3);
	}

	static void _206F_206A_200F_206C_202D_202C_200D_202E_200F_200F_202D_206E_206B_206D_200F_200D_200D_202A_200F_202C_200F_200C_206B_200F_202C_206D_206A_206D_202B_202B_206B_202C_200D_202C_206F_206A_206B_200C_206B_200F_202E(GZipStream P_0, byte[] P_1, int P_2, int P_3)
	{
		P_0.Write(P_1, P_2, P_3);
	}

	static void _202D_200C_202B_202D_202A_206C_200E_200B_206E_202C_202A_202D_206C_206E_206A_206B_206C_202D_200F_206A_202D_206F_200E_206D_202B_206E_200C_200C_206D_206E_206E_206F_202A_202C_202E_206C_202A_200D_206B_202A_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}

	static void _202C_206C_206B_202A_202A_206C_202C_206E_200C_200D_200B_206D_200D_206E_206B_202C_202E_206F_202D_202C_202B_202C_206B_200C_200B_202D_206B_200E_206A_206A_206C_206C_200C_200C_200F_200F_206D_200E_206C_206F_202E(Stream P_0)
	{
		P_0.Dispose();
	}

	static byte[] _202B_206B_206C_202D_200F_200C_200C_206D_200F_200F_206E_202E_200E_206C_206E_202D_202B_206F_200D_202E_200E_206D_200F_202B_206B_206F_202B_200C_200E_206F_202B_200F_206B_200F_200F_202B_206F_202A_202E_200E_202E(MemoryStream P_0)
	{
		return P_0.ToArray();
	}

	static MemoryStream _202C_202E_206C_200D_200C_202C_202B_202C_206C_200C_200F_206B_206E_202A_200D_200F_202B_202E_202A_206C_200E_200C_202E_206B_206B_206F_206A_200D_202D_202B_202D_206C_206A_206C_200D_206A_206E_206E_202E_202C_202E(byte[] P_0, int P_1, int P_2)
	{
		return new MemoryStream(P_0, P_1, P_2);
	}

	static int _206F_202C_200E_206B_206F_206D_200D_202D_200C_200F_200C_200C_206D_202A_206E_202C_202C_206E_202D_200F_200E_200C_200E_200B_200B_202B_202A_206F_206B_206F_202D_202C_202A_206E_206F_202C_202E_200E_200C_200E_202E(GZipStream P_0, byte[] P_1, int P_2, int P_3)
	{
		return P_0.Read(P_1, P_2, P_3);
	}

	static void _206C_200B_200C_200B_200D_202C_202D_200E_200B_202E_200D_206E_206C_200B_200F_202E_206C_206D_206C_202C_200F_200B_202B_200F_206D_200B_200D_206A_200D_202A_202C_200C_206D_206A_206A_206E_206F_200B_200D_202E_202E(MemoryStream P_0, byte[] P_1, int P_2, int P_3)
	{
		P_0.Write(P_1, P_2, P_3);
	}

	static void _206B_200B_200B_206F_200F_200B_200C_202B_202D_202A_202D_206B_202D_202C_206C_206D_200C_202B_202E_206C_202A_202A_200C_202B_206E_206C_202E_206A_206B_202D_200B_206D_200C_202A_202A_200F_206F_200E_206E_202D_202E(Stream P_0)
	{
		P_0.Close();
	}
}
