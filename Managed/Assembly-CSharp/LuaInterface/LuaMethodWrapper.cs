using System;
using System.Collections.Generic;
using System.Reflection;

namespace LuaInterface;

internal class LuaMethodWrapper
{
	private ObjectTranslator _202D_202B_206D_202A_202A_202E_202C_206E_200B_202D_202E_200C_202E_200F_200F_206D_200D_202D_202D_200E_200B_200B_206F_200F_202E_202D_200F_206F_206F_202B_206A_202B_202B_202A_202E_200C_206D_206D_202E_200C_202E;

	private MethodBase _206E_200C_206B_206C_202D_206E_206E_200F_202D_206E_206F_200E_202D_202E_200C_202E_206B_200F_200F_200E_200B_200F_200E_202B_206B_202B_206B_206C_206C_200E_200B_206E_200C_202B_206D_200E_200D_202C_202E_200F_202E;

	private MethodCache _202A_200C_206F_206B_200D_206F_206D_206E_206E_206F_200F_206C_206E_200D_206D_202C_206A_202C_202C_206E_206D_200E_206B_202A_200C_206A_202E_200B_200B_200B_206E_206D_206B_202B_202A_200C_206E_200C_202C_206C_202E = default(MethodCache);

	private string _200F_206B_202A_206D_206E_206B_202B_202C_206C_202C_202D_200D_200F_206D_206F_200B_206D_206C_206A_200F_200B_206E_206E_200F_200D_200D_202E_202B_206B_202A_202D_202D_200D_202D_202A_202D_202A_200E_206D_206D_202E;

	private MemberInfo[] _200D_206D_206E_200B_202D_206A_200E_206A_200B_206B_206D_200C_206F_200B_200C_206C_206F_200C_202C_206E_206F_206E_200D_200E_206E_202D_206B_202A_200D_200D_206D_206B_206B_206C_202B_200F_206F_202D_206D_200F_202E;

	public IReflect _206F_200D_206C_202E_202B_200F_206A_206F_202C_202D_206B_206B_206C_202B_200C_200C_206C_206B_206B_200D_206C_206D_202A_200C_202D_206F_206F_202C_200F_200B_200C_206B_200F_202A_206C_202D_202C_206D_206A_200D_202E;

	private ExtractValue _200E_200E_200D_200F_202C_206D_200D_200F_200D_202C_202B_202D_200B_200C_200C_202C_202B_200F_206E_202C_206A_200D_200F_206E_202E_202D_202E_206A_200E_202E_200E_200B_206A_202B_200E_202D_200E_206C_200C_202B_202E;

	private object _200E_200B_202C_200F_200B_202D_200E_202D_202C_206D_200F_202D_200B_200B_200E_202E_206B_202C_200E_206E_200E_200D_200D_200B_200D_206E_206C_206D_206F_206B_200F_202A_200F_206B_202C_202E_202C_202E_202C_200D_202E;

	private BindingFlags _206F_200C_202D_206F_206E_202B_206C_206F_206C_206C_206A_200B_200F_200D_202E_202E_206D_200C_206B_206B_206D_206A_200E_206B_200E_202C_206C_202C_206E_202B_206D_202B_200E_206A_200E_200B_202A_206D_202E_200D_202E;

	public LuaMethodWrapper(ObjectTranslator P_0, object P_1, IReflect P_2, MethodBase P_3)
	{
		while (true)
		{
			int num = 1725660066;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5B97A257)) % 12)
				{
				case 0u:
					break;
				default:
					return;
				case 5u:
					_202D_202B_206D_202A_202A_202E_202C_206E_200B_202D_202E_200C_202E_200F_200F_206D_200D_202D_202D_200E_200B_200B_206F_200F_202E_202D_200F_206F_206F_202B_206A_202B_202B_202A_202E_200C_206D_206D_202E_200C_202E = P_0;
					num = ((int)num2 * -1480841854) ^ 0x7F9B04B7;
					continue;
				case 6u:
					_200E_200B_202C_200F_200B_202D_200E_202D_202C_206D_200F_202D_200B_200B_200E_202E_206B_202C_200E_206E_200E_200D_200D_200B_200D_206E_206C_206D_206F_206B_200F_202A_200F_206B_202C_202E_202C_202E_202C_200D_202E = P_1;
					num = (int)(num2 * 831292177) ^ -1073396659;
					continue;
				case 1u:
					_200E_200E_200D_200F_202C_206D_200D_200F_200D_202C_202B_202D_200B_200C_200C_202C_202B_200F_206E_202C_206A_200D_200F_206E_202E_202D_202E_206A_200E_202E_200E_200B_206A_202B_200E_202D_200E_206C_200C_202B_202E = P_0.typeChecker.getExtractor(P_2);
					num = ((int)num2 * -854803930) ^ 0x156D8355;
					continue;
				case 7u:
					num = (int)(num2 * 35431380) ^ -1680783844;
					continue;
				case 9u:
					_200F_206B_202A_206D_206E_206B_202B_202C_206C_202C_202D_200D_200F_206D_206F_200B_206D_206C_206A_200F_200B_206E_206E_200F_200D_200D_202E_202B_206B_202A_202D_202D_200D_202D_202A_202D_202A_200E_206D_206D_202E = _206D_200E_200F_200D_200F_206A_206E_200E_200C_206A_206D_202D_202A_202C_206D_206C_200E_200D_200C_202C_200F_200B_200F_200E_200B_202A_200B_206A_202C_202B_202B_206C_206F_200B_206F_200F_200B_200E_206D_202E((MemberInfo)P_3);
					num = ((int)num2 * -896451539) ^ 0xC66E39C;
					continue;
				case 10u:
					_206F_200C_202D_206F_206E_202B_206C_206F_206C_206C_206A_200B_200F_200D_202E_202E_206D_200C_206B_206B_206D_206A_200E_206B_200E_202C_206C_202C_206E_202B_206D_202B_200E_206A_200E_200B_202A_206D_202E_200D_202E = BindingFlags.Static;
					num = (int)((num2 * 495305604) ^ 0x15D929A0);
					continue;
				case 8u:
				{
					_206F_200D_206C_202E_202B_200F_206A_206F_202C_202D_206B_206B_206C_202B_200C_200C_206C_206B_206B_200D_206C_206D_202A_200C_202D_206F_206F_202C_200F_200B_200C_206B_200F_202A_206C_202D_202C_206D_206A_200D_202E = P_2;
					int num5;
					int num6;
					if (P_2 == null)
					{
						num5 = 1366230291;
						num6 = num5;
					}
					else
					{
						num5 = 1998458926;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 267892887);
					continue;
				}
				case 4u:
					_206E_200C_206B_206C_202D_206E_206E_200F_202D_206E_206F_200E_202D_202E_200C_202E_206B_200F_200F_200E_200B_200F_200E_202B_206B_202B_206B_206C_206C_200E_200B_206E_200C_202B_206D_200E_200D_202C_202E_200F_202E = P_3;
					num = 929165102;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!_200C_206B_206E_202E_200B_206C_206E_206E_200E_200F_202C_206C_206F_206F_206A_206C_202D_206F_206A_202E_206D_200C_206F_206C_206A_206F_200C_200B_206A_200C_206F_206B_202B_200E_206C_202D_206A_200E_202C_202A_202E(P_3))
					{
						num3 = 1912691826;
						num4 = num3;
					}
					else
					{
						num3 = 1076915959;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 992182207);
					continue;
				}
				case 11u:
					_206F_200C_202D_206F_206E_202B_206C_206F_206C_206C_206A_200B_200F_200D_202E_202E_206D_200C_206B_206B_206D_206A_200E_206B_200E_202C_206C_202C_206E_202B_206D_202B_200E_206A_200E_200B_202A_206D_202E_200D_202E = BindingFlags.Instance;
					num = 1847710000;
					continue;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public LuaMethodWrapper(ObjectTranslator P_0, IReflect P_1, string P_2, BindingFlags P_3)
	{
		_202D_202B_206D_202A_202A_202E_202C_206E_200B_202D_202E_200C_202E_200F_200F_206D_200D_202D_202D_200E_200B_200B_206F_200F_202E_202D_200F_206F_206F_202B_206A_202B_202B_202A_202E_200C_206D_206D_202E_200C_202E = P_0;
		_200F_206B_202A_206D_206E_206B_202B_202C_206C_202C_202D_200D_200F_206D_206F_200B_206D_206C_206A_200F_200B_206E_206E_200F_200D_200D_202E_202B_206B_202A_202D_202D_200D_202D_202A_202D_202A_200E_206D_206D_202E = P_2;
		_206F_200D_206C_202E_202B_200F_206A_206F_202C_202D_206B_206B_206C_202B_200C_200C_206C_206B_206B_200D_206C_206D_202A_200C_202D_206F_206F_202C_200F_200B_200C_206B_200F_202A_206C_202D_202C_206D_206A_200D_202E = P_1;
		if (P_1 != null)
		{
			_200E_200E_200D_200F_202C_206D_200D_200F_200D_202C_202B_202D_200B_200C_200C_202C_202B_200F_206E_202C_206A_200D_200F_206E_202E_202D_202E_206A_200E_202E_200E_200B_206A_202B_200E_202D_200E_206C_200C_202B_202E = P_0.typeChecker.getExtractor(P_1);
		}
		_206F_200C_202D_206F_206E_202B_206C_206F_206C_206C_206A_200B_200F_200D_202E_202E_206D_200C_206B_206B_206D_206A_200E_206B_200E_202C_206C_202C_206E_202B_206D_202B_200E_206A_200E_200B_202A_206D_202E_200D_202E = P_3;
		_200D_206D_206E_200B_202D_206A_200E_206A_200B_206B_206D_200C_206F_200B_200C_206C_206F_200C_202C_206E_206F_206E_200D_200E_206E_202D_206B_202A_200D_200D_206D_206B_206B_206C_202B_200F_206F_202D_206D_200F_202E = _206D_206C_202D_206E_202B_200E_200D_200F_200D_202D_200E_206A_200C_200D_200B_206E_202C_202E_202A_206E_200B_206A_202A_206D_202A_200C_206D_206D_206F_202B_200E_200F_206F_202B_200D_206E_200E_206A_202B_200F_202E(_202B_206D_200C_202E_200D_200E_202B_206E_200B_200B_206F_202C_202B_200C_206C_206B_202C_200B_206A_202A_202D_200C_200C_200C_202E_202E_200C_206E_206B_200E_200C_206C_202D_206B_202B_206A_200E_206F_206C_206D_202E(P_1), P_2, MemberTypes.Method, P_3 | BindingFlags.Public | BindingFlags.IgnoreCase);
	}

	private int SetPendingException(Exception e)
	{
		return _202D_202B_206D_202A_202A_202E_202C_206E_200B_202D_202E_200C_202E_200F_200F_206D_200D_202D_202D_200E_200B_200B_206F_200F_202E_202D_200F_206F_206F_202B_206A_202B_202B_202A_202E_200C_206D_206D_202E_200C_202E.interpreter.SetPendingException(e);
	}

	private static bool IsInteger(double x)
	{
		return _200E_206F_200B_200C_200E_206F_206C_200D_202C_206C_200D_206E_202D_206E_202B_200B_202D_206D_206E_200C_202A_206C_202E_206C_200B_206D_202D_206A_206C_206D_206B_206D_202A_206A_206E_200B_202B_202E_202B_200E_202E(x) == x;
	}

	private void ClearCachedArgs()
	{
		if (_202A_200C_206F_206B_200D_206F_206D_206E_206E_206F_200F_206C_206E_200D_206D_202C_206A_202C_202C_206E_206D_200E_206B_202A_200C_206A_202E_200B_200B_200B_206E_206D_206B_202B_202A_200C_206E_200C_202C_206C_202E.args == null)
		{
			goto IL_000d;
		}
		goto IL_0054;
		IL_000d:
		int num = -1750690498;
		goto IL_0012;
		IL_0012:
		int num3 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1784663876)) % 7)
			{
			case 3u:
				break;
			default:
				return;
			case 5u:
				_202A_200C_206F_206B_200D_206F_206D_206E_206E_206F_200F_206C_206E_200D_206D_202C_206A_202C_202C_206E_206D_200E_206B_202A_200C_206A_202E_200B_200B_200B_206E_206D_206B_202B_202A_200C_206E_200C_202C_206C_202E.args[num3] = null;
				num = -963895572;
				continue;
			case 2u:
				goto IL_0054;
			case 1u:
				num3++;
				num = ((int)num2 * -571361870) ^ 0x43457021;
				continue;
			case 0u:
				goto IL_0070;
			case 6u:
				return;
			case 4u:
				return;
			}
			break;
			IL_0070:
			int num4;
			if (num3 >= _202A_200C_206F_206B_200D_206F_206D_206E_206E_206F_200F_206C_206E_200D_206D_202C_206A_202C_202C_206E_206D_200E_206B_202A_200C_206A_202E_200B_200B_200B_206E_206D_206B_202B_202A_200C_206E_200C_202C_206C_202E.args.Length)
			{
				num = -2007872711;
				num4 = num;
			}
			else
			{
				num = -1564463714;
				num4 = num;
			}
		}
		goto IL_000d;
		IL_0054:
		num3 = 0;
		num = -108809343;
		goto IL_0012;
	}

	public int call(IntPtr luaState)
	{
		MethodBase methodBase = _206E_200C_206B_206C_202D_206E_206E_200F_202D_206E_206F_200E_202D_202E_200C_202E_206B_200F_200F_200E_200B_200F_200E_202B_206B_202B_206B_206C_206C_200E_200B_206E_200C_202B_206D_200E_200D_202C_202E_200F_202E;
		bool flag2 = default(bool);
		MethodBase cachedMethod = default(MethodBase);
		int num52 = default(int);
		int num23 = default(int);
		object obj = default(object);
		bool flag = default(bool);
		int num5 = default(int);
		MethodArgs methodArgs = default(MethodArgs);
		object obj2 = default(object);
		int result = default(int);
		int num36 = default(int);
		List<Type> list = default(List<Type>);
		object[] args2 = default(object[]);
		object obj3 = default(object);
		MemberInfo[] array = default(MemberInfo[]);
		MethodInfo methodInfo = default(MethodInfo);
		bool flag4 = default(bool);
		int num29 = default(int);
		MemberInfo memberInfo = default(MemberInfo);
		string text = default(string);
		MethodBase method = default(MethodBase);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 1635360613;
			while (true)
			{
				int num17;
				int num18;
				int num26;
				uint num2;
				int num53;
				switch ((num2 = (uint)(num ^ 0x2DBDE5B7)) % 18)
				{
				case 0u:
					break;
				case 5u:
					throw new LuaException(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4294884575u));
				case 17u:
				{
					int num56;
					int num57;
					if (flag2)
					{
						num56 = 1894830374;
						num57 = num56;
					}
					else
					{
						num56 = 1716184174;
						num57 = num56;
					}
					num = num56 ^ (int)(num2 * 3053666);
					continue;
				}
				case 7u:
					cachedMethod = _202A_200C_206F_206B_200D_206F_206D_206E_206E_206F_200F_206C_206E_200D_206D_202C_206A_202C_202C_206E_206D_200E_206B_202A_200C_206A_202E_200B_200B_200B_206E_206D_206B_202B_202A_200C_206E_200C_202C_206C_202E.cachedMethod;
					if (num52 == _202A_200C_206F_206B_200D_206F_206D_206E_206E_206F_200F_206C_206E_200D_206D_202C_206A_202C_202C_206E_206D_200E_206B_202A_200C_206A_202E_200B_200B_200B_206E_206D_206B_202B_202A_200C_206E_200C_202C_206C_202E.argTypes.Length)
					{
						num = ((int)num2 * -935631146) ^ -545219891;
						continue;
					}
					goto IL_05ef;
				case 10u:
				{
					num23 = 0;
					int num54;
					int num55;
					if (LuaDLL.lua_checkstack(luaState, 5))
					{
						num54 = 2050765805;
						num55 = num54;
					}
					else
					{
						num54 = 978626619;
						num55 = num54;
					}
					num = num54 ^ ((int)num2 * -1354337218);
					continue;
				}
				case 16u:
					if (_202A_200C_206F_206B_200D_206F_206D_206E_206E_206F_200F_206C_206E_200D_206D_202C_206A_202C_202C_206E_206D_200E_206B_202A_200C_206A_202E_200B_200B_200B_206E_206D_206B_202B_202A_200C_206E_200C_202C_206C_202E.cachedMethod != null)
					{
						num = 1323657462;
						continue;
					}
					goto IL_05ef;
				case 11u:
					obj = _200E_200E_200D_200F_202C_206D_200D_200F_200D_202C_202B_202D_200B_200C_200C_202C_202B_200F_206E_202C_206A_200D_200F_206E_202E_202D_202E_206A_200E_202E_200E_200B_206A_202B_200E_202D_200E_206C_200C_202B_202E(luaState, 1);
					num = 811964797;
					continue;
				case 13u:
					num17 = 0;
					goto IL_013d;
				case 6u:
				{
					int num27;
					int num28;
					if (!LuaDLL.lua_checkstack(luaState, _202A_200C_206F_206B_200D_206F_206D_206E_206E_206F_200F_206C_206E_200D_206D_202C_206A_202C_202C_206E_206D_200E_206B_202A_200C_206A_202E_200B_200B_200B_206E_206D_206B_202B_202A_200C_206E_200C_202C_206C_202E.outList.Length + 6))
					{
						num27 = 1112130908;
						num28 = num27;
					}
					else
					{
						num27 = 382961618;
						num28 = num27;
					}
					num = num27 ^ ((int)num2 * -2072739588);
					continue;
				}
				case 9u:
					num = ((int)num2 * -1926566418) ^ 0x60FACB3F;
					continue;
				case 14u:
					SetPendingException(null);
					if (methodBase == null)
					{
						num = ((int)num2 * -1567389515) ^ 0x6C57554;
						continue;
					}
					goto IL_0741;
				case 12u:
					flag = true;
					num = (int)((num2 * 1059568323) ^ 0x708367E9);
					continue;
				case 15u:
					obj = null;
					num = (int)((num2 * 1022879569) ^ 0x5E261BDB);
					continue;
				case 2u:
					flag2 = (_206F_200C_202D_206F_206E_202B_206C_206F_206C_206C_206A_200B_200F_200D_202E_202E_206D_200C_206B_206B_206D_206A_200E_206B_200E_202C_206C_202C_206E_202B_206D_202B_200E_206A_200E_200B_202A_206D_202E_200D_202E & BindingFlags.Static) == BindingFlags.Static;
					num = 1752184265;
					continue;
				case 3u:
					if (!flag2)
					{
						num17 = 1;
						goto IL_013d;
					}
					num = ((int)num2 * -1114471948) ^ -2021768838;
					continue;
				case 8u:
					throw new LuaException(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2063627508u));
				case 4u:
					obj = _200E_200B_202C_200F_200B_202D_200E_202D_202C_206D_200F_202D_200B_200B_200E_202E_206B_202C_200E_206E_200E_200D_200D_200B_200D_206E_206C_206D_206F_206B_200F_202A_200F_206B_202C_202E_202C_202E_202C_200D_202E;
					num = ((int)num2 * -1379748816) ^ -453645429;
					continue;
				default:
					{
						object[] args = _202A_200C_206F_206B_200D_206F_206D_206E_206E_206F_200F_206C_206E_200D_206D_202C_206A_202C_202C_206E_206D_200E_206B_202A_200C_206A_202E_200B_200B_200B_206E_206D_206B_202B_202A_200C_206E_200C_202C_206C_202E.args;
						try
						{
							int num3 = 0;
							while (true)
							{
								IL_0264:
								int num4 = 254127726;
								while (true)
								{
									switch ((num2 = (uint)(num4 ^ 0x2DBDE5B7)) % 18)
									{
									case 9u:
										break;
									default:
										goto end_IL_0269;
									case 13u:
										num4 = (int)(num2 * 400150958) ^ -815999075;
										continue;
									case 8u:
										throw new LuaException(_200F_200C_206D_206E_206B_200D_200C_206E_202E_206C_200D_202E_202E_206A_202A_206F_200D_200C_202A_206B_200B_206D_200C_200D_202D_206A_202D_200D_202E_202E_202B_206D_206E_206E_206E_206E_206C_200E_202E_206B_202E((object)global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(837220709u), (object)(num3 + 1), (object)global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(832540374u)));
									case 3u:
									{
										int num7;
										if (_206E_206D_202E_200E_200B_200B_206B_206A_202C_200D_200E_202D_200E_206F_202D_206C_200D_200C_202E_206C_200D_206C_206B_200E_200F_200F_202E_202C_206A_200F_202C_200E_200F_202C_200F_200E_206D_206E_206A_200C_202E(_202A_200C_206F_206B_200D_206F_206D_206E_206E_206F_200F_206C_206E_200D_206D_202C_206A_202C_202C_206E_206D_200E_206B_202A_200C_206A_202E_200B_200B_200B_206E_206D_206B_202B_202A_200C_206E_200C_202C_206C_202E.cachedMethod))
										{
											num4 = 752867226;
											num7 = num4;
										}
										else
										{
											num4 = 1987617901;
											num7 = num4;
										}
										continue;
									}
									case 6u:
									{
										int num12;
										int num13;
										if (!LuaDLL.lua_isnil(luaState, num3 + 1 + num5))
										{
											num12 = -148828727;
											num13 = num12;
										}
										else
										{
											num12 = -1843907706;
											num13 = num12;
										}
										num4 = num12 ^ (int)(num2 * 692609342);
										continue;
									}
									case 14u:
									{
										int num9;
										if (num3 < _202A_200C_206F_206B_200D_206F_206D_206E_206E_206F_200F_206C_206E_200D_206D_202C_206A_202C_202C_206E_206D_200E_206B_202A_200C_206A_202E_200B_200B_200B_206E_206D_206B_202B_202A_200C_206E_200C_202C_206C_202E.argTypes.Length)
										{
											num4 = 1208136872;
											num9 = num4;
										}
										else
										{
											num4 = 828912416;
											num9 = num4;
										}
										continue;
									}
									case 15u:
									{
										int num10;
										int num11;
										if ((_206F_200C_202D_206F_206E_202B_206C_206F_206C_206C_206A_200B_200F_200D_202E_202E_206D_200C_206B_206B_206D_206A_200E_206B_200E_202C_206C_202C_206E_202B_206D_202B_200E_206A_200E_200B_202A_206D_202E_200D_202E & BindingFlags.Static) == BindingFlags.Static)
										{
											num10 = -1104927898;
											num11 = num10;
										}
										else
										{
											num10 = -1562685495;
											num11 = num10;
										}
										num4 = num10 ^ (int)(num2 * 1597778657);
										continue;
									}
									case 5u:
										_202D_202B_206D_202A_202A_202E_202C_206E_200B_202D_202E_200C_202E_200F_200F_206D_200D_202D_202D_200E_200B_200B_206F_200F_202E_202D_200F_206F_206F_202B_206A_202B_202B_202A_202E_200C_206D_206D_202E_200C_202E.push(luaState, _202C_200D_202D_206E_200D_206E_200D_202E_200E_202C_202C_206D_206C_202C_202B_200D_206C_200B_202C_202C_206D_206D_200B_200B_200E_202E_200C_206F_206A_202D_202C_200D_200F_200C_200E_202B_206E_206B_202C_202E_202E((ConstructorInfo)cachedMethod, args));
										num4 = ((int)num2 * -1007802909) ^ 0x13A9BC5F;
										continue;
									case 2u:
										args[methodArgs.index] = _202D_202B_206D_202A_202A_202E_202C_206E_200B_202D_202E_200C_202E_200F_200F_206D_200D_202D_202D_200E_200B_200B_206F_200F_202E_202D_200F_206F_206F_202B_206A_202B_202B_202A_202E_200C_206D_206D_202E_200C_202E.tableToArray(obj2, methodArgs.paramsArrayType);
										num4 = ((int)num2 * -281643747) ^ 0x2B8B9B9B;
										continue;
									case 12u:
										args[methodArgs.index] = obj2;
										num4 = 36023779;
										continue;
									case 16u:
									{
										int num8;
										if (args[methodArgs.index] == null)
										{
											num4 = 1876420319;
											num8 = num4;
										}
										else
										{
											num4 = 1278150838;
											num8 = num4;
										}
										continue;
									}
									case 0u:
										_202D_202B_206D_202A_202A_202E_202C_206E_200B_202D_202E_200C_202E_200F_200F_206D_200D_202D_202D_200E_200B_200B_206F_200F_202E_202D_200F_206F_206F_202B_206A_202B_202B_202A_202E_200C_206D_206D_202E_200C_202E.push(luaState, _200C_206C_206E_206A_200F_200D_200C_200F_206F_200D_206B_200C_206E_202E_200C_206E_200F_206F_202D_200B_202D_206F_206D_202B_200E_200C_202B_206C_206E_200B_206F_206D_206F_200C_200F_206D_202D_202E_202B_202B_202E(cachedMethod, (object)null, args));
										num4 = ((int)num2 * -630555104) ^ -568998188;
										continue;
									case 17u:
										num4 = ((int)num2 * -1108726477) ^ -1599460119;
										continue;
									case 1u:
										flag = false;
										num4 = 1761315467;
										continue;
									case 7u:
										num3++;
										num4 = 1815896547;
										continue;
									case 11u:
									{
										methodArgs = _202A_200C_206F_206B_200D_206F_206D_206E_206E_206F_200F_206C_206E_200D_206D_202C_206A_202C_202C_206E_206D_200E_206B_202A_200C_206A_202E_200B_200B_200B_206E_206D_206B_202B_202A_200C_206E_200C_202C_206C_202E.argTypes[num3];
										obj2 = methodArgs.extractValue(luaState, num3 + 1 + num5);
										int num6;
										if (_202A_200C_206F_206B_200D_206F_206D_206E_206E_206F_200F_206C_206E_200D_206D_202C_206A_202C_202C_206E_206D_200E_206B_202A_200C_206A_202E_200B_200B_200B_206E_206D_206B_202B_202A_200C_206E_200C_202C_206C_202E.argTypes[num3].isParamsArray)
										{
											num4 = 702020463;
											num6 = num4;
										}
										else
										{
											num4 = 2082700881;
											num6 = num4;
										}
										continue;
									}
									case 4u:
										_202D_202B_206D_202A_202A_202E_202C_206E_200B_202D_202E_200C_202E_200F_200F_206D_200D_202D_202D_200E_200B_200B_206F_200F_202E_202D_200F_206F_206F_202B_206A_202B_202B_202A_202E_200C_206D_206D_202E_200C_202E.push(luaState, _200C_206C_206E_206A_200F_200D_200C_200F_206F_200D_206B_200C_206E_202E_200C_206E_200F_206F_202D_200B_202D_206F_206D_202B_200E_200C_202B_206C_206E_200B_206F_206D_206F_200C_200F_206D_202D_202E_202B_202B_202E(cachedMethod, obj, args));
										num4 = 1854064148;
										continue;
									case 10u:
										goto end_IL_0269;
									}
									goto IL_0264;
									continue;
									end_IL_0269:
									break;
								}
								break;
							}
						}
						catch (TargetInvocationException ex)
						{
							result = SetPendingException(_206C_202B_206D_200F_202B_206F_206D_200F_206C_206A_200F_200F_200E_200B_200E_206D_206C_202C_200F_206A_206C_206B_200F_202D_200C_202E_202B_200E_206F_200D_202C_206E_206B_202C_200E_206B_206C_206A_206A_200C_202E((Exception)ex));
							while (true)
							{
								switch ((num2 = 800691536u) % 3)
								{
								case 0u:
									break;
								default:
									goto end_IL_052f;
								case 1u:
									goto end_IL_052f;
								case 2u:
									goto IL_102d;
								}
								continue;
								end_IL_052f:
								break;
							}
						}
						catch (Exception pendingException)
						{
							while (true)
							{
								IL_056e:
								int num14 = 1990582722;
								while (true)
								{
									switch ((num2 = (uint)(num14 ^ 0x2DBDE5B7)) % 5)
									{
									case 3u:
										break;
									default:
										goto end_IL_0573;
									case 1u:
									{
										int num15;
										int num16;
										if (_200D_206D_206E_200B_202D_206A_200E_206A_200B_206B_206D_200C_206F_200B_200C_206C_206F_200C_202C_206E_206F_206E_200D_200E_206E_202D_206B_202A_200D_200D_206D_206B_206B_206C_202B_200F_206F_202D_206D_200F_202E.Length == 1)
										{
											num15 = 966215542;
											num16 = num15;
										}
										else
										{
											num15 = 1341296421;
											num16 = num15;
										}
										num14 = num15 ^ (int)(num2 * 1851894872);
										continue;
									}
									case 4u:
										result = SetPendingException(pendingException);
										num14 = ((int)num2 * -221071116) ^ -200321338;
										continue;
									case 2u:
										goto end_IL_0573;
									case 0u:
										goto IL_102d;
									}
									goto IL_056e;
									continue;
									end_IL_0573:
									break;
								}
								break;
							}
						}
						goto IL_05ef;
					}
					IL_0ed7:
					num18 = 0;
					while (true)
					{
						int num19;
						int num20;
						if (num18 >= _202A_200C_206F_206B_200D_206F_206D_206E_206E_206F_200F_206C_206E_200D_206D_202C_206A_202C_202C_206E_206D_200E_206B_202A_200C_206A_202E_200B_200B_200B_206E_206D_206B_202B_202A_200C_206E_200C_202C_206C_202E.outList.Length)
						{
							num19 = 2050825687;
							num20 = num19;
						}
						else
						{
							num19 = 720746965;
							num20 = num19;
						}
						while (true)
						{
							int result2;
							switch ((num2 = (uint)(num19 ^ 0x2DBDE5B7)) % 11)
							{
							case 3u:
								num19 = 720746965;
								continue;
							case 5u:
								num23++;
								num19 = (int)(num2 * 973010953) ^ -726025005;
								continue;
							case 0u:
							{
								int num24;
								int num25;
								if (num23 <= 0)
								{
									num24 = -1925939144;
									num25 = num24;
								}
								else
								{
									num24 = -2075472844;
									num25 = num24;
								}
								num19 = num24 ^ ((int)num2 * -637532058);
								continue;
							}
							case 6u:
								if (num23 < 1)
								{
									num19 = ((int)num2 * -202171491) ^ -2054261823;
									continue;
								}
								result2 = num23;
								goto IL_0fe8;
							case 1u:
								num23++;
								num19 = 1693944615;
								continue;
							case 9u:
								_202D_202B_206D_202A_202A_202E_202C_206E_200B_202D_202E_200C_202E_200F_200F_206D_200D_202D_202D_200E_200B_200B_206F_200F_202E_202D_200F_206F_206F_202B_206A_202B_202B_202A_202E_200C_206D_206D_202E_200C_202E.push(luaState, _202A_200C_206F_206B_200D_206F_206D_206E_206E_206F_200F_206C_206E_200D_206D_202C_206A_202C_202C_206E_206D_200E_206B_202A_200C_206A_202E_200B_200B_200B_206E_206D_206B_202B_202A_200C_206E_200C_202C_206C_202E.args[_202A_200C_206F_206B_200D_206F_206D_206E_206E_206F_200F_206C_206E_200D_206D_202C_206A_202C_202C_206E_206D_200E_206B_202A_200C_206A_202E_200B_200B_200B_206E_206D_206B_202B_202A_200C_206E_200C_202C_206C_202E.outList[num18]]);
								num18++;
								num19 = ((int)num2 * -893853019) ^ 0x241E4C0A;
								continue;
							case 4u:
								break;
							case 8u:
								result2 = 1;
								goto IL_0fe8;
							case 10u:
								ClearCachedArgs();
								num19 = 1929114463;
								continue;
							case 7u:
							{
								int num21;
								int num22;
								if (!_202A_200C_206F_206B_200D_206F_206D_206E_206E_206F_200F_206C_206E_200D_206D_202C_206A_202C_202C_206E_206D_200E_206B_202A_200C_206A_202E_200B_200B_200B_206E_206D_206B_202B_202A_200C_206E_200C_202C_206C_202E.IsReturnVoid)
								{
									num21 = -1105863178;
									num22 = num21;
								}
								else
								{
									num21 = -1634654082;
									num22 = num21;
								}
								num19 = num21 ^ (int)(num2 * 1446920745);
								continue;
							}
							default:
								goto end_IL_0fbf;
								IL_0fe8:
								return result2;
							}
							break;
						}
						continue;
						end_IL_0fbf:
						break;
					}
					goto IL_102d;
					IL_05ef:
					if (flag)
					{
						goto IL_05f5;
					}
					goto IL_0901;
					IL_0901:
					if (flag)
					{
						num26 = 1207105342;
						goto IL_05fa;
					}
					goto IL_0ed7;
					IL_05fa:
					while (true)
					{
						string text2;
						string message;
						switch ((num2 = (uint)(num26 ^ 0x2DBDE5B7)) % 54)
						{
						case 46u:
							break;
						case 11u:
							num36++;
							num26 = ((int)num2 * -1337797191) ^ -945149028;
							continue;
						case 10u:
							ClearCachedArgs();
							num26 = ((int)num2 * -1432399106) ^ 0x51018C81;
							continue;
						case 44u:
							list = new List<Type>();
							args2 = _202A_200C_206F_206B_200D_206F_206D_206E_206E_206F_200F_206C_206E_200D_206D_202C_206A_202C_202C_206E_206D_200E_206B_202A_200C_206A_202E_200B_200B_200B_206E_206D_206B_202B_202A_200C_206E_200C_202C_206C_202E.args;
							num26 = (int)(num2 * 185580204) ^ -1721600233;
							continue;
						case 5u:
							goto IL_0741;
						case 3u:
						{
							int num41;
							int num42;
							if (obj == null)
							{
								num41 = -1721761838;
								num42 = num41;
							}
							else
							{
								num41 = -1411019777;
								num42 = num41;
							}
							num26 = num41 ^ (int)(num2 * 683445169);
							continue;
						}
						case 22u:
							text2 = global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1714071210u);
							goto IL_079a;
						case 21u:
							obj3 = args2[num36];
							num26 = 2033231340;
							continue;
						case 13u:
							goto IL_07bf;
						case 16u:
							ClearCachedArgs();
							return 1;
						case 39u:
						{
							int num34;
							int num35;
							if (_206E_206D_202E_200E_200B_200B_206B_206A_202C_200D_200E_202D_200E_206F_202D_206C_200D_200C_202E_206C_200D_206C_206B_200E_200F_200F_202E_202C_206A_200F_202C_200E_200F_202C_200F_200E_206D_206E_206A_200C_202E(methodBase))
							{
								num34 = -1407842123;
								num35 = num34;
							}
							else
							{
								num34 = -1187080723;
								num35 = num34;
							}
							num26 = num34 ^ (int)(num2 * 334582863);
							continue;
						}
						case 31u:
							LuaDLL.lua_remove(luaState, 1);
							num26 = 2005647319;
							continue;
						case 32u:
							num26 = ((int)num2 * -865315727) ^ -1276976721;
							continue;
						case 23u:
							list.Add(_200C_202C_206F_200F_202C_206B_202E_206C_202A_200D_206D_206D_202B_200D_202B_202E_202E_200B_206C_206B_202E_206D_206F_200B_200C_206F_200B_202C_200C_202B_206F_200F_202B_200C_206D_206A_202B_202A_202E_202B_202E(obj3));
							num26 = ((int)num2 * -552845868) ^ -343286938;
							continue;
						case 24u:
							array = _200D_206D_206E_200B_202D_206A_200E_206A_200B_206B_206D_200C_206F_200B_200C_206C_206F_200C_202C_206E_206F_206E_200D_200E_206E_202D_206B_202A_200D_200D_206D_206B_206B_206C_202B_200F_206F_202D_206D_200F_202E;
							num26 = ((int)num2 * -1369615538) ^ 0x48A8F962;
							continue;
						case 52u:
							goto IL_089b;
						case 53u:
							LuaDLL.lua_pushnil(luaState);
							num26 = ((int)num2 * -1604951238) ^ -1637815801;
							continue;
						case 45u:
							goto IL_08d0;
						case 4u:
							return 1;
						case 34u:
						case 47u:
						case 51u:
							goto IL_0901;
						case 30u:
							num26 = (int)(num2 * 1893183003) ^ -2055708862;
							continue;
						case 50u:
							obj = _200E_200E_200D_200F_202C_206D_200D_200F_200D_202C_202B_202D_200B_200C_200C_202C_202B_200F_206E_202C_206A_200D_200F_206E_202E_202D_202E_206A_200E_202E_200E_200B_206A_202B_200E_202D_200E_206C_200C_202B_202E(luaState, 1);
							num26 = (int)((num2 * 1586567314) ^ 0x2B4D5C9A);
							continue;
						case 36u:
							_202D_202B_206D_202A_202A_202E_202C_206E_200B_202D_202E_200C_202E_200F_200F_206D_200D_202D_202D_200E_200B_200B_206F_200F_202E_202D_200F_206F_206F_202B_206A_202B_202B_202A_202E_200C_206D_206D_202E_200C_202E.push(luaState, _200C_206C_206E_206A_200F_200D_200C_200F_206F_200D_206B_200C_206E_202E_200C_206E_200F_206F_202D_200B_202D_206F_206D_202B_200E_200C_202B_206C_206E_200B_206F_206D_206F_200C_200F_206D_202D_202E_202B_202B_202E((MethodBase)methodInfo, obj, _202A_200C_206F_206B_200D_206F_206D_206E_206E_206F_200F_206C_206E_200D_206D_202C_206A_202C_202C_206E_206D_200E_206B_202A_200C_206A_202E_200B_200B_200B_206E_206D_206B_202B_202A_200C_206E_200C_202C_206C_202E.args));
							flag = false;
							num26 = (int)((num2 * 1104177018) ^ 0x76D586A2);
							continue;
						case 42u:
							return 1;
						case 37u:
							LuaDLL.luaL_error(luaState, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2636381683u));
							num26 = ((int)num2 * -13473808) ^ -1873630390;
							continue;
						case 1u:
						{
							int num39;
							int num40;
							if (flag4)
							{
								num39 = 815038429;
								num40 = num39;
							}
							else
							{
								num39 = 949412370;
								num40 = num39;
							}
							num26 = num39 ^ (int)(num2 * 134668436);
							continue;
						}
						case 7u:
							goto IL_09d2;
						case 20u:
						{
							int num37;
							int num38;
							if (!flag2)
							{
								num37 = -1513667404;
								num38 = num37;
							}
							else
							{
								num37 = -1082680145;
								num38 = num37;
							}
							num26 = num37 ^ (int)(num2 * 1820783471);
							continue;
						}
						case 9u:
							return 1;
						case 27u:
							num29 = 0;
							num26 = (int)((num2 * 953244615) ^ 0x2142CA1E);
							continue;
						case 48u:
							memberInfo = array[num29];
							num26 = 1021917937;
							continue;
						case 33u:
							if (text != null)
							{
								text2 = _202C_206B_206D_200C_200F_206F_206B_200B_202B_202D_200C_206E_202E_202C_206B_202B_202D_202A_202A_202A_202A_200C_200D_200E_206D_206C_200E_200C_202B_200C_206A_202A_200B_206D_202D_200E_206F_200F_200E_200D_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2439902221u), text);
								goto IL_079a;
							}
							num26 = ((int)num2 * -312149334) ^ -369170193;
							continue;
						case 2u:
							num36 = 0;
							num26 = (int)((num2 * 1567863852) ^ 0x338FE1E1);
							continue;
						case 41u:
							LuaDLL.lua_remove(luaState, 1);
							num26 = (int)(num2 * 1550876030) ^ -1377967310;
							continue;
						case 28u:
							text = _200D_206E_202B_200C_202C_200D_206F_200F_200B_206E_206C_200E_200F_206F_202E_202C_202B_200B_202E_202A_202A_200B_206E_206C_206D_200F_206C_202E_200E_206C_202E_200D_202D_202D_202E_200B_202C_200D_206E_202A_202E(_206D_200E_200F_200D_200F_206A_206E_200E_200C_206A_206D_202D_202A_202C_206D_206C_200E_200D_200C_202C_200F_200B_200F_200E_200B_202A_200B_206A_202C_202B_202B_206C_206F_200B_206F_200F_200B_200E_206D_202E((MemberInfo)_206F_206A_200C_200D_206D_202B_202A_200E_202B_202C_202E_206D_200F_200D_206E_206A_200D_206E_200E_206F_202E_200B_200D_202E_200B_200C_200E_202B_206B_200B_206A_202A_206D_200D_206E_206D_206F_202D_202A_202E_202E(memberInfo)), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3953477269u), _206D_200E_200F_200D_200F_206A_206E_200E_200C_206A_206D_202D_202A_202C_206D_206C_200E_200D_200C_202C_200F_200B_200F_200E_200B_202A_200B_206A_202C_202B_202B_206C_206F_200B_206F_200F_200B_200E_206D_202E(memberInfo));
							method = (MethodInfo)memberInfo;
							num26 = ((int)num2 * -2119208313) ^ -1466856906;
							continue;
						case 15u:
							flag4 = _202D_202B_206D_202A_202A_202E_202C_206E_200B_202D_202E_200C_202E_200F_200F_206D_200D_202D_202D_200E_200B_200B_206F_200F_202E_202D_200F_206F_206F_202B_206A_202B_202B_202A_202E_200C_206D_206D_202E_200C_202E.matchParameters(luaState, method, ref _202A_200C_206F_206B_200D_206F_206D_206E_206E_206F_200F_206C_206E_200D_206D_202C_206A_202C_202C_206E_206D_200E_206B_202A_200C_206A_202E_200B_200B_200B_206E_206D_206B_202B_202A_200C_206E_200C_202C_206C_202E);
							num26 = ((int)num2 * -880282926) ^ 0x7E7175A0;
							continue;
						case 26u:
							_202D_202B_206D_202A_202A_202E_202C_206E_200B_202D_202E_200C_202E_200F_200F_206D_200D_202D_202D_200E_200B_200B_206F_200F_202E_202D_200F_206F_206F_202B_206A_202B_202B_202A_202E_200C_206D_206D_202E_200C_202E.throwError(luaState, _206C_202B_202C_200D_206F_206D_200D_202C_200B_202B_206D_206B_206D_202D_202B_206C_206F_202C_202B_200D_200B_200D_202C_200D_206D_202E_200F_200F_202A_206B_206C_200E_206B_202E_200C_202E_200D_200D_206C_200F_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(803586007u), (object)_200F_206B_202A_206D_206E_206B_202B_202C_206C_202C_202D_200D_200F_206D_206F_200B_206D_206C_206A_200F_200B_206E_206E_200F_200D_200D_202E_202B_206B_202A_202D_202D_200D_202D_202A_202D_202A_200E_206D_206D_202E));
							LuaDLL.lua_pushnil(luaState);
							num26 = (int)((num2 * 829801302) ^ 0xCE2FB70);
							continue;
						case 40u:
							_202D_202B_206D_202A_202A_202E_202C_206E_200B_202D_202E_200C_202E_200F_200F_206D_200D_202D_202D_200E_200B_200B_206F_200F_202E_202D_200F_206F_206F_202B_206A_202B_202B_202A_202E_200C_206D_206D_202E_200C_202E.matchParameters(luaState, methodBase, ref _202A_200C_206F_206B_200D_206F_206D_206E_206E_206F_200F_206C_206E_200D_206D_202C_206A_202C_202C_206E_206D_200E_206B_202A_200C_206A_202E_200B_200B_200B_206E_206D_206B_202B_202A_200C_206E_200C_202C_206C_202E);
							num26 = ((int)num2 * -1347203118) ^ -24641845;
							continue;
						case 29u:
							LuaDLL.lua_pushnil(luaState);
							num26 = ((int)num2 * -251906244) ^ 0x67039717;
							continue;
						case 17u:
							text = null;
							num26 = ((int)num2 * -2056586274) ^ -1569205381;
							continue;
						case 14u:
						{
							int num32;
							int num33;
							if (!_202B_200E_200C_206B_202D_202E_200D_206F_206F_200B_206B_206A_200C_202E_200F_200E_206F_200F_206F_202C_200B_206A_206E_206F_206C_200F_206A_202A_200F_202D_200D_202C_200E_200F_202D_202E_206E_202E_200D_206E_202E(methodBase))
							{
								num32 = -38310174;
								num33 = num32;
							}
							else
							{
								num32 = -675759839;
								num33 = num32;
							}
							num26 = num32 ^ (int)(num2 * 14387793);
							continue;
						}
						case 8u:
							goto IL_0bbe;
						case 43u:
						{
							int num30;
							int num31;
							if (obj == null)
							{
								num30 = -1176189944;
								num31 = num30;
							}
							else
							{
								num30 = -1501375609;
								num31 = num30;
							}
							num26 = num30 ^ ((int)num2 * -535867125);
							continue;
						}
						case 38u:
							LuaDLL.lua_pushnil(luaState);
							ClearCachedArgs();
							num26 = ((int)num2 * -1771002541) ^ 0x3C3555C3;
							continue;
						case 6u:
							flag3 = false;
							num26 = 1454331470;
							continue;
						case 19u:
							num29++;
							num26 = 1491871585;
							continue;
						case 12u:
							LuaDLL.luaL_error(luaState, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2421461530u));
							num26 = ((int)num2 * -2084190697) ^ -622285797;
							continue;
						case 25u:
							methodInfo = _202A_200C_202B_202C_202A_202B_206B_200D_206E_200E_206A_206A_202E_202C_202B_202D_200F_206E_202C_202C_202A_200C_206A_202D_206D_202E_206B_206C_206C_200D_200B_200C_206A_206A_200D_202E_202B_206C_206E_200F_202E(methodBase as MethodInfo, list.ToArray());
							num26 = ((int)num2 * -1353168029) ^ -1572707848;
							continue;
						case 18u:
							goto IL_0c80;
						case 0u:
							flag3 = true;
							num26 = ((int)num2 * -964814062) ^ 0x6C393A7F;
							continue;
						case 49u:
							goto IL_0cb2;
						default:
							{
								ClearCachedArgs();
								throw new LuaException(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1493777737u));
							}
							IL_079a:
							message = text2;
							LuaDLL.luaL_error(luaState, message);
							num26 = 977961842;
							continue;
						}
						break;
						IL_0cb2:
						int num43;
						if (!_202D_202B_206D_202A_202A_202E_202C_206E_200B_202D_202E_200C_202E_200F_200F_206D_200D_202D_202D_200E_200B_200B_206F_200F_202E_202D_200F_206F_206F_202B_206A_202B_202B_202A_202E_200C_206D_206D_202E_200C_202E.matchParameters(luaState, methodBase, ref _202A_200C_206F_206B_200D_206F_206D_206E_206E_206F_200F_206C_206E_200D_206D_202C_206A_202C_202C_206E_206D_200E_206B_202A_200C_206A_202E_200B_200B_200B_206E_206D_206B_202B_202A_200C_206E_200C_202C_206C_202E))
						{
							num26 = 531433686;
							num43 = num26;
						}
						else
						{
							num26 = 271453000;
							num43 = num26;
						}
						continue;
						IL_07bf:
						if (!LuaDLL.lua_checkstack(luaState, _202A_200C_206F_206B_200D_206F_206D_206E_206E_206F_200F_206C_206E_200D_206D_202C_206A_202C_202C_206E_206D_200E_206B_202A_200C_206A_202E_200B_200B_200B_206E_206D_206B_202B_202A_200C_206E_200C_202C_206C_202E.outList.Length + 6))
						{
							num26 = ((int)num2 * -253865530) ^ -96500936;
							continue;
						}
						goto IL_0cf1;
						IL_08d0:
						int num44;
						if (_206D_200E_206B_206E_202E_206D_200D_200B_202E_200F_206D_200F_206C_206C_202E_206B_200B_202C_200E_202E_200F_200F_206C_200B_202E_200B_200E_200B_200B_200F_202B_202E_206B_206F_206A_200D_200B_200E_202A_202E(methodBase))
						{
							num26 = 1055219977;
							num44 = num26;
						}
						else
						{
							num26 = 702385138;
							num44 = num26;
						}
						continue;
						IL_0c80:
						int num45;
						if (num29 < array.Length)
						{
							num26 = 946007081;
							num45 = num26;
						}
						else
						{
							num26 = 1868719326;
							num45 = num26;
						}
						continue;
						IL_09d2:
						int num46;
						if (!flag3)
						{
							num26 = 9342114;
							num46 = num26;
						}
						else
						{
							num26 = 382378059;
							num46 = num26;
						}
						continue;
						IL_089b:
						int num47;
						if (num36 < args2.Length)
						{
							num26 = 2106454802;
							num47 = num26;
						}
						else
						{
							num26 = 2127863610;
							num47 = num26;
						}
						continue;
						IL_0bbe:
						int num48;
						if (_200C_206B_206E_202E_200B_206C_206E_206E_200E_200F_202C_206C_206F_206F_206A_206C_202D_206F_206A_202E_206D_200C_206F_206C_206A_206F_200C_200B_206A_200C_206F_206B_202B_200E_206C_202D_206A_200E_202C_202A_202E(methodBase))
						{
							num26 = 423616268;
							num48 = num26;
						}
						else
						{
							num26 = 1554566336;
							num48 = num26;
						}
					}
					goto IL_05f5;
					IL_0cf1:
					try
					{
						if (flag2)
						{
							goto IL_0cf8;
						}
						goto IL_0de7;
						IL_0cf8:
						int num49 = 1231304639;
						goto IL_0cfd;
						IL_0cfd:
						while (true)
						{
							switch ((num2 = (uint)(num49 ^ 0x2DBDE5B7)) % 7)
							{
							case 5u:
								break;
							default:
								goto end_IL_0cf1;
							case 4u:
								_202D_202B_206D_202A_202A_202E_202C_206E_200B_202D_202E_200C_202E_200F_200F_206D_200D_202D_202D_200E_200B_200B_206F_200F_202E_202D_200F_206F_206F_202B_206A_202B_202B_202A_202E_200C_206D_206D_202E_200C_202E.push(luaState, _202C_200D_202D_206E_200D_206E_200D_202E_200E_202C_202C_206D_206C_202C_202B_200D_206C_200B_202C_202C_206D_206D_200B_200B_200E_202E_200C_206F_206A_202D_202C_200D_200F_200C_200E_202B_206E_206B_202C_202E_202E((ConstructorInfo)_202A_200C_206F_206B_200D_206F_206D_206E_206E_206F_200F_206C_206E_200D_206D_202C_206A_202C_202C_206E_206D_200E_206B_202A_200C_206A_202E_200B_200B_200B_206E_206D_206B_202B_202A_200C_206E_200C_202C_206C_202E.cachedMethod, _202A_200C_206F_206B_200D_206F_206D_206E_206E_206F_200F_206C_206E_200D_206D_202C_206A_202C_202C_206E_206D_200E_206B_202A_200C_206A_202E_200B_200B_200B_206E_206D_206B_202B_202A_200C_206E_200C_202C_206C_202E.args));
								num49 = (int)((num2 * 2045474215) ^ 0x5F8A629C);
								continue;
							case 1u:
								num49 = (int)((num2 * 1296413865) ^ 0x13BFA3E4);
								continue;
							case 3u:
								_202D_202B_206D_202A_202A_202E_202C_206E_200B_202D_202E_200C_202E_200F_200F_206D_200D_202D_202D_200E_200B_200B_206F_200F_202E_202D_200F_206F_206F_202B_206A_202B_202B_202A_202E_200C_206D_206D_202E_200C_202E.push(luaState, _200C_206C_206E_206A_200F_200D_200C_200F_206F_200D_206B_200C_206E_202E_200C_206E_200F_206F_202D_200B_202D_206F_206D_202B_200E_200C_202B_206C_206E_200B_206F_206D_206F_200C_200F_206D_202D_202E_202B_202B_202E(_202A_200C_206F_206B_200D_206F_206D_206E_206E_206F_200F_206C_206E_200D_206D_202C_206A_202C_202C_206E_206D_200E_206B_202A_200C_206A_202E_200B_200B_200B_206E_206D_206B_202B_202A_200C_206E_200C_202C_206C_202E.cachedMethod, (object)null, _202A_200C_206F_206B_200D_206F_206D_206E_206E_206F_200F_206C_206E_200D_206D_202C_206A_202C_202C_206E_206D_200E_206B_202A_200C_206A_202E_200B_200B_200B_206E_206D_206B_202B_202A_200C_206E_200C_202C_206C_202E.args));
								num49 = (int)(num2 * 191977406) ^ -1704098674;
								continue;
							case 6u:
								_202D_202B_206D_202A_202A_202E_202C_206E_200B_202D_202E_200C_202E_200F_200F_206D_200D_202D_202D_200E_200B_200B_206F_200F_202E_202D_200F_206F_206F_202B_206A_202B_202B_202A_202E_200C_206D_206D_202E_200C_202E.push(luaState, _200C_206C_206E_206A_200F_200D_200C_200F_206F_200D_206B_200C_206E_202E_200C_206E_200F_206F_202D_200B_202D_206F_206D_202B_200E_200C_202B_206C_206E_200B_206F_206D_206F_200C_200F_206D_202D_202E_202B_202B_202E(_202A_200C_206F_206B_200D_206F_206D_206E_206E_206F_200F_206C_206E_200D_206D_202C_206A_202C_202C_206E_206D_200E_206B_202A_200C_206A_202E_200B_200B_200B_206E_206D_206B_202B_202A_200C_206E_200C_202C_206C_202E.cachedMethod, obj, _202A_200C_206F_206B_200D_206F_206D_206E_206E_206F_200F_206C_206E_200D_206D_202C_206A_202C_202C_206E_206D_200E_206B_202A_200C_206A_202E_200B_200B_200B_206E_206D_206B_202B_202A_200C_206E_200C_202C_206C_202E.args));
								num49 = 602878805;
								continue;
							case 2u:
								goto IL_0de7;
							case 0u:
								goto end_IL_0cf1;
							}
							break;
						}
						goto IL_0cf8;
						IL_0de7:
						int num50;
						if (!_206E_206D_202E_200E_200B_200B_206B_206A_202C_200D_200E_202D_200E_206F_202D_206C_200D_200C_202E_206C_200D_206C_206B_200E_200F_200F_202E_202C_206A_200F_202C_200E_200F_202C_200F_200E_206D_206E_206A_200C_202E(_202A_200C_206F_206B_200D_206F_206D_206E_206E_206F_200F_206C_206E_200D_206D_202C_206A_202C_202C_206E_206D_200E_206B_202A_200C_206A_202E_200B_200B_200B_206E_206D_206B_202B_202A_200C_206E_200C_202C_206C_202E.cachedMethod))
						{
							num49 = 1693488505;
							num50 = num49;
						}
						else
						{
							num49 = 2009018040;
							num50 = num49;
						}
						goto IL_0cfd;
						end_IL_0cf1:;
					}
					catch (TargetInvocationException ex2)
					{
						ClearCachedArgs();
						result = SetPendingException(_206C_202B_206D_200F_202B_206F_206D_200F_206C_206A_200F_200F_200E_200B_200E_206D_206C_202C_200F_206A_206C_206B_200F_202D_200C_202E_202B_200E_206F_200D_202C_206E_206B_202C_200E_206B_206C_206A_206A_200C_202E((Exception)ex2));
						while (true)
						{
							switch ((num2 = 666746113u) % 3)
							{
							case 2u:
								break;
							default:
								goto end_IL_0e29;
							case 0u:
								goto end_IL_0e29;
							case 1u:
								goto IL_102d;
							}
							continue;
							end_IL_0e29:
							break;
						}
					}
					catch (Exception pendingException2)
					{
						while (true)
						{
							IL_0e65:
							int num51 = 1385329781;
							while (true)
							{
								switch ((num2 = (uint)(num51 ^ 0x2DBDE5B7)) % 5)
								{
								case 0u:
									break;
								default:
									goto end_IL_0e6a;
								case 4u:
									result = SetPendingException(pendingException2);
									num51 = ((int)num2 * -434453091) ^ 0x6EFA7DC7;
									continue;
								case 3u:
									ClearCachedArgs();
									num51 = ((int)num2 * -1679960240) ^ -623550954;
									continue;
								case 2u:
									goto end_IL_0e6a;
								case 1u:
									goto IL_102d;
								}
								goto IL_0e65;
								continue;
								end_IL_0e6a:
								break;
							}
							break;
						}
					}
					goto IL_0ed7;
					IL_013d:
					num5 = num17;
					num52 = LuaDLL.lua_gettop(luaState) - num5;
					num = 270508194;
					continue;
					IL_0741:
					if (_206D_200E_206B_206E_202E_206D_200D_200B_202E_200F_206D_200F_206C_206C_202E_206B_200B_202C_200E_202E_200F_200F_206C_200B_202E_200B_200E_200B_200B_200F_202B_202E_206B_206F_206A_200D_200B_200E_202A_202E(methodBase))
					{
						num26 = 2005751213;
						num53 = num26;
					}
					else
					{
						num26 = 380987697;
						num53 = num26;
					}
					goto IL_05fa;
					IL_05f5:
					num26 = 1411521983;
					goto IL_05fa;
					IL_102d:
					return result;
				}
				break;
			}
		}
	}

	static string _206D_200E_200F_200D_200F_206A_206E_200E_200C_206A_206D_202D_202A_202C_206D_206C_200E_200D_200C_202C_200F_200B_200F_200E_200B_202A_200B_206A_202C_202B_202B_206C_206F_200B_206F_200F_200B_200E_206D_202E(MemberInfo P_0)
	{
		return P_0.Name;
	}

	static bool _200C_206B_206E_202E_200B_206C_206E_206E_200E_200F_202C_206C_206F_206F_206A_206C_202D_206F_206A_202E_206D_200C_206F_206C_206A_206F_200C_200B_206A_200C_206F_206B_202B_200E_206C_202D_206A_200E_202C_202A_202E(MethodBase P_0)
	{
		return P_0.IsStatic;
	}

	static Type _202B_206D_200C_202E_200D_200E_202B_206E_200B_200B_206F_202C_202B_200C_206C_206B_202C_200B_206A_202A_202D_200C_200C_200C_202E_202E_200C_206E_206B_200E_200C_206C_202D_206B_202B_206A_200E_206F_206C_206D_202E(IReflect P_0)
	{
		return P_0.UnderlyingSystemType;
	}

	static MemberInfo[] _206D_206C_202D_206E_202B_200E_200D_200F_200D_202D_200E_206A_200C_200D_200B_206E_202C_202E_202A_206E_200B_206A_202A_206D_202A_200C_206D_206D_206F_202B_200E_200F_206F_202B_200D_206E_200E_206A_202B_200F_202E(Type P_0, string P_1, MemberTypes P_2, BindingFlags P_3)
	{
		return P_0.GetMember(P_1, P_2, P_3);
	}

	static double _200E_206F_200B_200C_200E_206F_206C_200D_202C_206C_200D_206E_202D_206E_202B_200B_202D_206D_206E_200C_202A_206C_202E_206C_200B_206D_202D_206A_206C_206D_206B_206D_202A_206A_206E_200B_202B_202E_202B_200E_202E(double P_0)
	{
		return Math.Ceiling(P_0);
	}

	static string _200F_200C_206D_206E_206B_200D_200C_206E_202E_206C_200D_202E_202E_206A_202A_206F_200D_200C_202A_206B_200B_206D_200C_200D_202D_206A_202D_200D_202E_202E_202B_206D_206E_206E_206E_206E_206C_200E_202E_206B_202E(object P_0, object P_1, object P_2)
	{
		return string.Concat(P_0, P_1, P_2);
	}

	static object _200C_206C_206E_206A_200F_200D_200C_200F_206F_200D_206B_200C_206E_202E_200C_206E_200F_206F_202D_200B_202D_206F_206D_202B_200E_200C_202B_206C_206E_200B_206F_206D_206F_200C_200F_206D_202D_202E_202B_202B_202E(MethodBase P_0, object P_1, object[] P_2)
	{
		return P_0.Invoke(P_1, P_2);
	}

	static bool _206E_206D_202E_200E_200B_200B_206B_206A_202C_200D_200E_202D_200E_206F_202D_206C_200D_200C_202E_206C_200D_206C_206B_200E_200F_200F_202E_202C_206A_200F_202C_200E_200F_202C_200F_200E_206D_206E_206A_200C_202E(MethodBase P_0)
	{
		return P_0.IsConstructor;
	}

	static object _202C_200D_202D_206E_200D_206E_200D_202E_200E_202C_202C_206D_206C_202C_202B_200D_206C_200B_202C_202C_206D_206D_200B_200B_200E_202E_200C_206F_206A_202D_202C_200D_200F_200C_200E_202B_206E_206B_202C_202E_202E(ConstructorInfo P_0, object[] P_1)
	{
		return P_0.Invoke(P_1);
	}

	static Exception _206C_202B_206D_200F_202B_206F_206D_200F_206C_206A_200F_200F_200E_200B_200E_206D_206C_202C_200F_206A_206C_206B_200F_202D_200C_202E_202B_200E_206F_200D_202C_206E_206B_202C_200E_206B_206C_206A_206A_200C_202E(Exception P_0)
	{
		return P_0.GetBaseException();
	}

	static string _206C_202B_202C_200D_206F_206D_200D_202C_200B_202B_206D_206B_206D_202D_202B_206C_206F_202C_202B_200D_200B_200D_202C_200D_206D_202E_200F_200F_202A_206B_206C_200E_206B_202E_200C_202E_200D_200D_206C_200F_202E(string P_0, object P_1)
	{
		return string.Format(P_0, P_1);
	}

	static Type _206F_206A_200C_200D_206D_202B_202A_200E_202B_202C_202E_206D_200F_200D_206E_206A_200D_206E_200E_206F_202E_200B_200D_202E_200B_200C_200E_202B_206B_200B_206A_202A_206D_200D_206E_206D_206F_202D_202A_202E_202E(MemberInfo P_0)
	{
		return P_0.ReflectedType;
	}

	static string _200D_206E_202B_200C_202C_200D_206F_200F_200B_206E_206C_200E_200F_206F_202E_202C_202B_200B_202E_202A_202A_200B_206E_206C_206D_200F_206C_202E_200E_206C_202E_200D_202D_202D_202E_200B_202C_200D_206E_202A_202E(string P_0, string P_1, string P_2)
	{
		return P_0 + P_1 + P_2;
	}

	static string _202C_206B_206D_200C_200F_206F_206B_200B_202B_202D_200C_206E_202E_202C_206B_202B_202D_202A_202A_202A_202A_200C_200D_200E_206D_206C_200E_200C_202B_200C_206A_202A_200B_206D_202D_200E_206F_200F_200E_200D_202E(string P_0, string P_1)
	{
		return P_0 + P_1;
	}

	static bool _206D_200E_206B_206E_202E_206D_200D_200B_202E_200F_206D_200F_206C_206C_202E_206B_200B_202C_200E_202E_200F_200F_206C_200B_202E_200B_200E_200B_200B_200F_202B_202E_206B_206F_206A_200D_200B_200E_202A_202E(MethodBase P_0)
	{
		return P_0.ContainsGenericParameters;
	}

	static bool _202B_200E_200C_206B_202D_202E_200D_206F_206F_200B_206B_206A_200C_202E_200F_200E_206F_200F_206F_202C_200B_206A_206E_206F_206C_200F_206A_202A_200F_202D_200D_202C_200E_200F_202D_202E_206E_202E_200D_206E_202E(MethodBase P_0)
	{
		return P_0.IsGenericMethodDefinition;
	}

	static Type _200C_202C_206F_200F_202C_206B_202E_206C_202A_200D_206D_206D_202B_200D_202B_202E_202E_200B_206C_206B_202E_206D_206F_200B_200C_206F_200B_202C_200C_202B_206F_200F_202B_200C_206D_206A_202B_202A_202E_202B_202E(object P_0)
	{
		return P_0.GetType();
	}

	static MethodInfo _202A_200C_202B_202C_202A_202B_206B_200D_206E_200E_206A_206A_202E_202C_202B_202D_200F_206E_202C_202C_202A_200C_206A_202D_206D_202E_206B_206C_206C_200D_200B_200C_206A_206A_200D_202E_202B_206C_206E_200F_202E(MethodInfo P_0, Type[] P_1)
	{
		return P_0.MakeGenericMethod(P_1);
	}
}
