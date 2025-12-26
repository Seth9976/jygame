using System;
using System.Collections;
using System.Runtime.CompilerServices;
using LuaInterface;

namespace JyGame;

public static class LuaTool
{
	[CompilerGenerated]
	private sealed class _206F_202D_206B_206F_206A_206D_206A_200B_206A_206D_202A_200F_200F_206F_202D_202C_202E_202E_206D_206D_200F_206E_206A_202E_200E_202B_202C_206B_200F_206B_206B_202B_202D_202D_206A_200F_200D_206F_202E_206F_202E
	{
		internal LuaFunction fun;

		internal void _200D_200B_206E_206F_206E_202D_202C_200C_206E_206F_202C_206C_202B_206B_200E_200D_200E_200E_202A_206B_206E_202D_206E_206C_206C_206E_200B_200D_200F_206D_200F_202A_202C_206D_206A_202C_202E_206F_200B_206B_202E()
		{
			fun.Call();
		}
	}

	[CompilerGenerated]
	private sealed class _202A_206F_206D_206F_202A_202E_202E_200C_206F_202B_202E_206D_206F_206D_200D_200C_200D_202C_206D_202A_206C_206F_206A_206B_206F_202A_202E_206C_206C_206C_200B_202B_200E_200E_202E_206C_202B_200F_206C_202D_202E
	{
		internal LuaFunction fun;

		internal void _202A_200F_202E_206D_206F_206D_202A_206D_200F_200D_202D_202E_202A_206E_202D_206E_202D_202B_206A_202D_202D_206D_200B_202B_200D_206C_200D_200D_200F_206F_200D_200E_202B_200D_200B_206F_202B_200F_200B_200F_202E(string P_0)
		{
			fun.call(new object[1] { P_0 }, null);
		}
	}

	[CompilerGenerated]
	private sealed class _202E_206A_202E_200E_200F_206A_206C_202C_202A_202D_200F_202E_206C_200D_202C_206B_202E_206D_202D_200E_202E_206D_200D_206D_202A_202E_200D_206F_206C_202E_200B_202E_200D_200C_200B_202C_200D_206C_202A_202E_202E
	{
		internal LuaFunction fun;

		internal void _206E_200F_200D_202D_202E_200F_202C_202C_206B_200D_200E_202C_206B_202A_202D_202E_202E_202B_206B_202E_202A_200F_202E_202E_200E_200E_206E_200C_200F_200B_206F_200F_202B_202A_206F_202D_200F_202C_200E_206D_202E(int P_0)
		{
			fun.call(new object[1] { P_0 }, null);
		}
	}

	[CompilerGenerated]
	private sealed class _200F_206A_202C_200B_202C_202E_206B_200E_200C_202B_206D_206A_200E_202A_200F_202C_200B_206F_200D_200F_206E_206F_200C_202B_202D_200F_206A_206D_206B_200F_200D_200D_206B_206A_206D_202A_202B_206D_200B_206F_202E
	{
		internal LuaFunction fun;

		internal void _202E_200D_202D_200D_200E_206D_206C_200F_200C_206E_202E_206F_206D_202E_200F_200B_202A_200B_206D_206E_202C_200E_202D_206C_206B_200D_200B_206D_202D_206A_200D_202C_202A_200E_200D_202B_202D_206D_206C_200D_202E(object P_0)
		{
			fun.call(new object[1] { P_0 }, null);
		}
	}

	public static CommonSettings.VoidCallBack MakeVoidCallBack(LuaFunction fun)
	{
		return delegate
		{
			fun.Call();
		};
	}

	public static CommonSettings.StringCallBack MakeStringCallBack(LuaFunction fun)
	{
		return delegate(string P_0)
		{
			fun.call(new object[1] { P_0 }, null);
		};
	}

	public static CommonSettings.IntCallBack MakeIntCallBack(LuaFunction fun)
	{
		LuaFunction fun2 = default(LuaFunction);
		while (true)
		{
			int num = -962770036;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1932902643)) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_0028;
				default:
					return delegate(int P_0)
					{
						fun2.call(new object[1] { P_0 }, null);
					};
				}
				break;
				IL_0028:
				fun2 = fun;
				num = (int)(num2 * 1261073218) ^ -213998044;
			}
		}
	}

	public static CommonSettings.ObjectCallBack MakeObjectCallBack(LuaFunction fun)
	{
		LuaFunction fun2 = default(LuaFunction);
		while (true)
		{
			int num = 449705808;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4D34A2E5)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0028;
				default:
					return delegate(object P_0)
					{
						fun2.call(new object[1] { P_0 }, null);
					};
				}
				break;
				IL_0028:
				fun2 = fun;
				num = (int)((num2 * 1827325343) ^ 0x15120085);
			}
		}
	}

	public static string[] MakeStringArray(LuaTable table)
	{
		return table.ToArray<string>();
	}

	public static LuaTable CreateLuaTable()
	{
		return (LuaTable)LuaManager.luamgr.DoString(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(316925669u))[0];
	}

	public static LuaTable CreateLuaTable(IEnumerable objs)
	{
		LuaTable luaTable = CreateLuaTable();
		int num = 0;
		IEnumerator enumerator = _206D_202E_202D_200E_206C_200D_200C_200C_200C_200E_202A_200D_202D_200D_200F_200B_206C_202D_200E_206B_202C_202D_206A_206F_206A_202C_206E_202E_202D_206C_206A_202A_202A_202D_202A_200E_202B_202D_206E_200C_202E(objs);
		try
		{
			while (true)
			{
				IL_0058:
				int num2;
				int num3;
				if (enumerator.MoveNext())
				{
					num2 = 2114298714;
					num3 = num2;
				}
				else
				{
					num2 = 1001873279;
					num3 = num2;
				}
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)(num2 ^ 0x5BDCB9EF)) % 5)
					{
					case 0u:
						num2 = 2114298714;
						continue;
					default:
						goto end_IL_0016;
					case 1u:
					{
						object value = _206B_200C_206D_202E_200D_200C_206D_202E_200E_202C_202C_200E_200B_206C_206A_206E_200C_200E_206A_202A_202C_206D_206F_206D_202A_206A_206A_202B_206F_200B_202D_200F_200E_200F_206B_206E_206B_206E_206D_206B_202E(enumerator);
						luaTable[num.ToString()] = value;
						num2 = 224686157;
						continue;
					}
					case 4u:
						break;
					case 3u:
						num++;
						num2 = ((int)num4 * -11537460) ^ 0x2B58E394;
						continue;
					case 2u:
						goto end_IL_0016;
					}
					goto IL_0058;
					continue;
					end_IL_0016:
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
				IL_008f:
				int num5 = 1733135628;
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)(num5 ^ 0x5BDCB9EF)) % 5)
					{
					case 0u:
						break;
					default:
						goto end_IL_0094;
					case 4u:
					{
						int num6;
						int num7;
						if (disposable == null)
						{
							num6 = -712749878;
							num7 = num6;
						}
						else
						{
							num6 = -1197854716;
							num7 = num6;
						}
						num5 = num6 ^ (int)(num4 * 1692932859);
						continue;
					}
					case 2u:
						goto end_IL_0094;
					case 3u:
						disposable.Dispose();
						num5 = 388417492;
						continue;
					case 1u:
						goto end_IL_0094;
					}
					goto IL_008f;
					continue;
					end_IL_0094:
					break;
				}
				break;
			}
		}
		return luaTable;
	}

	public static LuaTable CreateLuaTable(IList objs)
	{
		LuaTable luaTable = CreateLuaTable();
		int num = 0;
		IEnumerator enumerator = _206D_202E_202D_200E_206C_200D_200C_200C_200C_200E_202A_200D_202D_200D_200F_200B_206C_202D_200E_206B_202C_202D_206A_206F_206A_202C_206E_202E_202D_206C_206A_202A_202A_202D_202A_200E_202B_202D_206E_200C_202E((IEnumerable)objs);
		try
		{
			while (true)
			{
				IL_003c:
				int num2;
				int num3;
				if (enumerator.MoveNext())
				{
					num2 = 1326582760;
					num3 = num2;
				}
				else
				{
					num2 = 30261175;
					num3 = num2;
				}
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)(num2 ^ 0x7149A029)) % 5)
					{
					case 4u:
						num2 = 1326582760;
						continue;
					default:
						goto end_IL_0016;
					case 0u:
						break;
					case 1u:
						num++;
						num2 = (int)(num4 * 487769711) ^ -25142709;
						continue;
					case 2u:
					{
						object value = _206B_200C_206D_202E_200D_200C_206D_202E_200E_202C_202C_200E_200B_206C_206A_206E_200C_200E_206A_202A_202C_206D_206F_206D_202A_206A_206A_202B_206F_200B_202D_200F_200E_200F_206B_206E_206B_206E_206D_206B_202E(enumerator);
						luaTable[num.ToString()] = value;
						num2 = 111725166;
						continue;
					}
					case 3u:
						goto end_IL_0016;
					}
					goto IL_003c;
					continue;
					end_IL_0016:
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
				IL_008f:
				int num5 = 927260624;
				while (true)
				{
					uint num4;
					int num6;
					switch ((num4 = (uint)(num5 ^ 0x7149A029)) % 4)
					{
					case 3u:
						break;
					case 1u:
					{
						int num7;
						if (disposable == null)
						{
							num6 = 266530769;
							num7 = num6;
						}
						else
						{
							num6 = 1996917719;
							num7 = num6;
						}
						goto IL_00c8;
					}
					case 2u:
						goto end_IL_0094;
					default:
						disposable.Dispose();
						goto end_IL_0094;
					}
					goto IL_008f;
					IL_00c8:
					num5 = num6 ^ ((int)num4 * -966382970);
					continue;
					end_IL_0094:
					break;
				}
				break;
			}
		}
		return luaTable;
	}

	public static LuaTable CreateLuaTable(IDictionary objs)
	{
		LuaTable luaTable = CreateLuaTable();
		IEnumerator enumerator = _206D_202E_202D_200E_206C_200D_200C_200C_200C_200E_202A_200D_202D_200D_200F_200B_206C_202D_200E_206B_202C_202D_206A_206F_206A_202C_206E_202E_202D_206C_206A_202A_202A_202D_202A_200E_202B_202D_206E_200C_202E((IEnumerable)_200E_202A_202B_202B_202C_202B_206C_200C_202D_206C_206B_200B_206D_200C_202D_200B_206F_200F_200D_202C_206B_200F_202D_200D_206C_206D_202C_200E_206F_206B_206E_202C_206E_200C_206D_206C_206E_206A_206B_200C_202E(objs));
		try
		{
			object obj = default(object);
			while (true)
			{
				IL_004d:
				int num;
				int num2;
				if (_206E_200D_202E_200B_206E_202E_206D_202B_206F_202A_202A_206A_206B_200D_206F_206A_206C_202A_200D_202B_202A_206F_202B_202C_206A_206B_206D_202D_202C_206E_202D_200E_206B_202D_206A_200E_202D_200B_202C_206C_202E(enumerator))
				{
					num = -1603444231;
					num2 = num;
				}
				else
				{
					num = -553613453;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -126765405)) % 5)
					{
					case 2u:
						num = -1603444231;
						continue;
					default:
						goto end_IL_0019;
					case 1u:
						obj = _206B_200C_206D_202E_200D_200C_206D_202E_200E_202C_202C_200E_200B_206C_206A_206E_200C_200E_206A_202A_202C_206D_206F_206D_202A_206A_206A_202B_206F_200B_202D_200F_200E_200F_206B_206E_206B_206E_206D_206B_202E(enumerator);
						num = -857518880;
						continue;
					case 3u:
						break;
					case 0u:
						luaTable[obj] = _200B_202E_200B_206A_202A_202C_202E_202B_200C_200C_200D_202E_202D_202A_202B_202B_202C_200D_200C_202A_206B_200F_200E_206F_206B_202A_206B_200C_206C_202C_200F_202D_200C_200C_200E_206C_202D_206F_200E_200F_202E(objs, obj);
						num = (int)((num3 * 1406751976) ^ 0x2866E8F1);
						continue;
					case 4u:
						goto end_IL_0019;
					}
					goto IL_004d;
					continue;
					end_IL_0019:
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
				IL_008d:
				int num4 = -1627340606;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num4 ^ -126765405)) % 5)
					{
					case 3u:
						break;
					default:
						goto end_IL_0092;
					case 1u:
					{
						int num5;
						int num6;
						if (disposable == null)
						{
							num5 = 1057502253;
							num6 = num5;
						}
						else
						{
							num5 = 2034684875;
							num6 = num5;
						}
						num4 = num5 ^ (int)(num3 * 2067603720);
						continue;
					}
					case 0u:
						goto end_IL_0092;
					case 4u:
						_200F_206A_206A_202C_206F_206A_200E_200D_206C_200B_206A_202D_200B_206F_202D_202E_206A_200F_202A_202E_200D_206E_206A_206C_206D_206D_206B_200B_206F_206A_200F_206C_202B_200F_202B_200C_206B_206C_206C_200C_202E(disposable);
						num4 = -498546215;
						continue;
					case 2u:
						goto end_IL_0092;
					}
					goto IL_008d;
					continue;
					end_IL_0092:
					break;
				}
				break;
			}
		}
		return luaTable;
	}

	public static LuaTable toLuaTable(this IEnumerable objs)
	{
		return CreateLuaTable(objs);
	}

	public static LuaTable toLuaTable(this IList objs)
	{
		return CreateLuaTable(objs);
	}

	public static LuaTable toLuaTable(this IDictionary objs)
	{
		return CreateLuaTable(objs);
	}

	static IEnumerator _206D_202E_202D_200E_206C_200D_200C_200C_200C_200E_202A_200D_202D_200D_200F_200B_206C_202D_200E_206B_202C_202D_206A_206F_206A_202C_206E_202E_202D_206C_206A_202A_202A_202D_202A_200E_202B_202D_206E_200C_202E(IEnumerable P_0)
	{
		return P_0.GetEnumerator();
	}

	static object _206B_200C_206D_202E_200D_200C_206D_202E_200E_202C_202C_200E_200B_206C_206A_206E_200C_200E_206A_202A_202C_206D_206F_206D_202A_206A_206A_202B_206F_200B_202D_200F_200E_200F_206B_206E_206B_206E_206D_206B_202E(IEnumerator P_0)
	{
		return P_0.Current;
	}

	static ICollection _200E_202A_202B_202B_202C_202B_206C_200C_202D_206C_206B_200B_206D_200C_202D_200B_206F_200F_200D_202C_206B_200F_202D_200D_206C_206D_202C_200E_206F_206B_206E_202C_206E_200C_206D_206C_206E_206A_206B_200C_202E(IDictionary P_0)
	{
		return P_0.Keys;
	}

	static object _200B_202E_200B_206A_202A_202C_202E_202B_200C_200C_200D_202E_202D_202A_202B_202B_202C_200D_200C_202A_206B_200F_200E_206F_206B_202A_206B_200C_206C_202C_200F_202D_200C_200C_200E_206C_202D_206F_200E_200F_202E(IDictionary P_0, object P_1)
	{
		return P_0[P_1];
	}

	static bool _206E_200D_202E_200B_206E_202E_206D_202B_206F_202A_202A_206A_206B_200D_206F_206A_206C_202A_200D_202B_202A_206F_202B_202C_206A_206B_206D_202D_202C_206E_202D_200E_206B_202D_206A_200E_202D_200B_202C_206C_202E(IEnumerator P_0)
	{
		return P_0.MoveNext();
	}

	static void _200F_206A_206A_202C_206F_206A_200E_200D_206C_200B_206A_202D_200B_206F_202D_202E_206A_200F_202A_202E_200D_206E_206A_206C_206D_206D_206B_200B_206F_206A_200F_206C_202B_200F_202B_200C_206B_206C_206C_200C_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}
}
