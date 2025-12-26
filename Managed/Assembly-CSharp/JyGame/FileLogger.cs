using System;
using System.IO;
using UnityEngine;

namespace JyGame;

public class FileLogger : ILogger
{
	public static FileLogger instance;

	static FileLogger()
	{
		instance = new FileLogger();
	}

	public void log(string msg)
	{
		Log(msg);
	}

	public void Log(string msg)
	{
		_206B_200E_206F_206C_202E_200F_200C_202A_202B_206E_200E_200E_206A_200E_202C_202E_200F_202B_206E_200E_206D_206F_202C_206E_206C_202B_200B_200B_200C_202C_206F_206B_202A_202D_200F_206C_200C_200F_206C_206F_202E();
	}

	public void LogWarning(string msg)
	{
		if (_206B_200E_206F_206C_202E_200F_200C_202A_202B_206E_200E_200E_206A_200E_202C_202E_200F_202B_206E_200E_206D_206F_202C_206E_206C_202B_200B_200B_200C_202C_206F_206B_202A_202D_200F_206C_200C_200F_206C_206F_202E())
		{
			return;
		}
		while (true)
		{
			int num = -1571057932;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2133696682)) % 3)
				{
				case 0u:
					break;
				case 2u:
					if (!_200C_202D_206A_202A_202D_202A_206F_202B_202D_202B_202A_200B_206E_202E_202C_202E_206A_202A_202D_206A_202D_206C_202C_202B_200D_206A_202C_206B_200F_202C_202B_202E_206F_200D_200D_200F_206A_206D_200F_206B_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3279146500u)))
					{
						goto IL_0040;
					}
					return;
				default:
				{
					StreamWriter streamWriter = _206D_202E_202A_202B_200D_202C_200D_206C_206E_200D_206A_200B_202C_200D_202E_202B_200B_200B_206A_200B_200C_202D_200C_202B_202C_200C_206F_206E_206B_202E_202D_200C_202B_200E_200D_206D_200B_202A_200D_206C_202E((Stream)_206B_206A_206F_206C_206B_202A_200F_206C_206E_202D_200B_202E_206C_206F_206A_200E_206F_200D_200C_206E_206F_206A_200B_202B_206C_202C_202D_202B_200F_200E_202B_202D_200B_202E_200C_202B_206C_206E_202D_206E_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(922339745u), FileMode.Append));
					try
					{
						streamWriter.WriteLine(DateTime.Now.ToString() + global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3467139093u) + msg);
						return;
					}
					finally
					{
						if (streamWriter != null)
						{
							while (true)
							{
								IL_008d:
								int num3 = -1445788446;
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ -2133696682)) % 3)
									{
									case 2u:
										break;
									default:
										goto end_IL_0092;
									case 1u:
										goto IL_00af;
									case 0u:
										goto end_IL_0092;
									}
									goto IL_008d;
									IL_00af:
									((IDisposable)streamWriter).Dispose();
									num3 = ((int)num2 * -1523647123) ^ -1506095543;
									continue;
									end_IL_0092:
									break;
								}
								break;
							}
						}
					}
				}
				}
				break;
				IL_0040:
				num = ((int)num2 * -1576263797) ^ 0x89409C5;
			}
		}
	}

	public void LogError(string msg)
	{
		if (_206B_200E_206F_206C_202E_200F_200C_202A_202B_206E_200E_200E_206A_200E_202C_202E_200F_202B_206E_200E_206D_206F_202C_206E_206C_202B_200B_200B_200C_202C_206F_206B_202A_202D_200F_206C_200C_200F_206C_206F_202E())
		{
			return;
		}
		while (true)
		{
			int num = -76012688;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -428944777)) % 3)
				{
				case 0u:
					break;
				case 2u:
					if (!_200C_202D_206A_202A_202D_202A_206F_202B_202D_202B_202A_200B_206E_202E_202C_202E_206A_202A_202D_206A_202D_206C_202C_202B_200D_206A_202C_206B_200F_202C_202B_202E_206F_200D_200D_200F_206A_206D_200F_206B_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(145995861u)))
					{
						goto IL_0040;
					}
					return;
				default:
				{
					StreamWriter streamWriter = _206D_202E_202A_202B_200D_202C_200D_206C_206E_200D_206A_200B_202C_200D_202E_202B_200B_200B_206A_200B_200C_202D_200C_202B_202C_200C_206F_206E_206B_202E_202D_200C_202B_200E_200D_206D_200B_202A_200D_206C_202E((Stream)_206B_206A_206F_206C_206B_202A_200F_206C_206E_202D_200B_202E_206C_206F_206A_200E_206F_200D_200C_206E_206F_206A_200B_202B_206C_202C_202D_202B_200F_200E_202B_202D_200B_202E_200C_202B_206C_206E_202D_206E_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1532253795u), FileMode.Append));
					try
					{
						streamWriter.WriteLine(DateTime.Now.ToString() + global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(338608295u) + msg);
						return;
					}
					finally
					{
						if (streamWriter != null)
						{
							while (true)
							{
								IL_008d:
								int num3 = -1013153852;
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ -428944777)) % 3)
									{
									case 2u:
										break;
									default:
										goto end_IL_0092;
									case 1u:
										goto IL_00af;
									case 0u:
										goto end_IL_0092;
									}
									goto IL_008d;
									IL_00af:
									((IDisposable)streamWriter).Dispose();
									num3 = ((int)num2 * -700919735) ^ 0xB660567;
									continue;
									end_IL_0092:
									break;
								}
								break;
							}
						}
					}
				}
				}
				break;
				IL_0040:
				num = ((int)num2 * -1561825061) ^ 0x70C2D2D1;
			}
		}
	}

	static bool _206B_200E_206F_206C_202E_200F_200C_202A_202B_206E_200E_200E_206A_200E_202C_202E_200F_202B_206E_200E_206D_206F_202C_206E_206C_202B_200B_200B_200C_202C_206F_206B_202A_202D_200F_206C_200C_200F_206C_206F_202E()
	{
		return Application.isMobilePlatform;
	}

	static bool _200C_202D_206A_202A_202D_202A_206F_202B_202D_202B_202A_200B_206E_202E_202C_202E_206A_202A_202D_206A_202D_206C_202C_202B_200D_206A_202C_206B_200F_202C_202B_202E_206F_200D_200D_200F_206A_206D_200F_206B_202E(string P_0)
	{
		return Directory.Exists(P_0);
	}

	static FileStream _206B_206A_206F_206C_206B_202A_200F_206C_206E_202D_200B_202E_206C_206F_206A_200E_206F_200D_200C_206E_206F_206A_200B_202B_206C_202C_202D_202B_200F_200E_202B_202D_200B_202E_200C_202B_206C_206E_202D_206E_202E(string P_0, FileMode P_1)
	{
		return File.Open(P_0, P_1);
	}

	static StreamWriter _206D_202E_202A_202B_200D_202C_200D_206C_206E_200D_206A_200B_202C_200D_202E_202B_200B_200B_206A_200B_200C_202D_200C_202B_202C_200C_206F_206E_206B_202E_202D_200C_202B_200E_200D_206D_200B_202A_200D_206C_202E(Stream P_0)
	{
		return new StreamWriter(P_0);
	}
}
