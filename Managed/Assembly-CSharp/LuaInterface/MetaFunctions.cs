using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace LuaInterface;

public class MetaFunctions
{
	internal static string luaIndexFunction = global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1744308392u);

	private ObjectTranslator translator;

	private Hashtable memberCache = _202E_200B_200E_202A_200D_200D_202E_200F_202E_200F_200E_206A_200E_206A_206C_206E_202C_200D_200F_206E_206C_202E_200F_206E_200F_206B_202D_202C_202B_200C_202B_206B_206A_202A_200B_200C_202A_200E_200B_206A_202E();

	internal LuaCSFunction gcFunction;

	internal LuaCSFunction indexFunction;

	internal LuaCSFunction newindexFunction;

	internal LuaCSFunction baseIndexFunction;

	internal LuaCSFunction classIndexFunction;

	internal LuaCSFunction classNewindexFunction;

	internal LuaCSFunction execDelegateFunction;

	internal LuaCSFunction callConstructorFunction;

	internal LuaCSFunction toStringFunction;

	public MetaFunctions(ObjectTranslator P_0)
	{
		while (true)
		{
			int num = 1875235938;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x105420CD)) % 6)
				{
				case 3u:
					break;
				default:
					return;
				case 1u:
					translator = P_0;
					gcFunction = collectObject;
					toStringFunction = toString;
					indexFunction = getMethod;
					newindexFunction = setFieldOrProperty;
					num = (int)((num2 * 1444597903) ^ 0x98C4BD4);
					continue;
				case 2u:
					execDelegateFunction = runFunctionDelegate;
					num = ((int)num2 * -38640107) ^ -2100423670;
					continue;
				case 4u:
					classIndexFunction = getClassMethod;
					classNewindexFunction = setClassFieldOrProperty;
					num = (int)((num2 * 1210247822) ^ 0x4980DBE7);
					continue;
				case 0u:
					baseIndexFunction = getBaseMethod;
					callConstructorFunction = callConstructor;
					num = (int)((num2 * 1103394630) ^ 0x65F20751);
					continue;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int runFunctionDelegate(IntPtr luaState)
	{
		ObjectTranslator objectTranslator = ObjectTranslator.FromState(luaState);
		LuaCSFunction luaCSFunction = (LuaCSFunction)objectTranslator.getRawNetObject(luaState, 1);
		while (true)
		{
			int num = -106832435;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2030843250)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0037;
				default:
					return luaCSFunction(luaState);
				}
				break;
				IL_0037:
				LuaDLL.lua_remove(luaState, 1);
				num = ((int)num2 * -674151539) ^ 0x3DFCC7F2;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int collectObject(IntPtr luaState)
	{
		int num = LuaDLL.luanet_rawnetobj(luaState, 1);
		if (num != -1)
		{
			ObjectTranslator objectTranslator = default(ObjectTranslator);
			while (true)
			{
				int num2 = -1264013035;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num2 ^ -829843426)) % 4)
					{
					case 0u:
						break;
					case 3u:
						objectTranslator = ObjectTranslator.FromState(luaState);
						num2 = (int)((num3 * 1237855988) ^ 0x338FD1CC);
						continue;
					case 2u:
						objectTranslator.collectObject(num);
						num2 = ((int)num3 * -443946151) ^ 0x7EB92289;
						continue;
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
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int toString(IntPtr luaState)
	{
		ObjectTranslator objectTranslator = ObjectTranslator.FromState(luaState);
		object rawNetObject = objectTranslator.getRawNetObject(luaState, 1);
		while (true)
		{
			int num = -1285534457;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1398583070)) % 6)
				{
				case 4u:
					break;
				case 1u:
				{
					int num3;
					int num4;
					if (rawNetObject != null)
					{
						num3 = -2012381396;
						num4 = num3;
					}
					else
					{
						num3 = -1630506954;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1567678946);
					continue;
				}
				case 2u:
					LuaDLL.lua_pushnil(luaState);
					num = -99729811;
					continue;
				case 3u:
					num = (int)(num2 * 1512664533) ^ -894339060;
					continue;
				case 0u:
					objectTranslator.push(luaState, _206E_206F_202D_200F_200B_206D_202A_206B_200C_202A_206A_200B_200F_206E_206A_202D_206B_206F_200D_202D_200B_202B_206D_206D_206B_206A_202B_202E_200E_202D_202C_200D_202E_202A_206D_202B_200C_206E_200B_206A_202E((object)_202D_206D_202B_202D_200D_200D_206B_206F_206D_200C_202E_206C_206C_202D_202A_200F_202D_200B_206C_206C_206F_202E_206F_200E_206D_200B_206D_202D_200D_206F_206C_206B_206C_206C_202C_206B_206A_206A_206E_202D_202E(rawNetObject), (object)global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3802293093u), (object)_200D_202A_200C_206D_202B_206A_200D_202A_206C_202E_200F_200C_200C_206A_200B_202C_206F_202B_202E_200D_200B_206D_200D_200B_202D_202C_202A_200B_202E_202C_206C_206F_202C_200E_200D_206B_200B_200D_206F_206B_202E(rawNetObject)));
					num = (int)((num2 * 1667140889) ^ 0x3B86BBE7);
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	public static void dumpStack(ObjectTranslator translator, IntPtr luaState)
	{
		int num = LuaDLL.lua_gettop(luaState);
		int num2 = 1;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num3;
			int num4;
			if (num2 <= num)
			{
				num3 = -1025353084;
				num4 = num3;
			}
			else
			{
				num3 = -1598836379;
				num4 = num3;
			}
			while (true)
			{
				uint num5;
				string text2;
				string text3;
				switch ((num5 = (uint)(num3 ^ -1939361722)) % 10)
				{
				case 9u:
					num3 = -1025353084;
					continue;
				default:
					return;
				case 1u:
					text2 = global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1703283680u);
					goto IL_0064;
				case 6u:
				{
					object rawNetObject = translator.getRawNetObject(luaState, num2);
					string text = _202D_206D_202B_202D_200D_200D_206B_206F_206D_200C_202E_206C_206C_202D_202A_200F_202D_200B_206C_206C_206F_202E_206F_200E_206D_200B_206D_202D_200D_206F_206C_206B_206C_206C_202C_206B_206A_206A_206E_202D_202E(rawNetObject);
					num3 = (int)((num5 * 1583107363) ^ 0xC5CA8B6);
					continue;
				}
				case 2u:
					break;
				case 8u:
				{
					string text = LuaDLL.lua_tostring(luaState, num2);
					num3 = ((int)num5 * -2028332355) ^ 0xE139AF5;
					continue;
				}
				case 4u:
					luaTypes = LuaDLL.lua_type(luaState, num2);
					num3 = -273699045;
					continue;
				case 3u:
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						text2 = LuaDLL.lua_typename(luaState, luaTypes);
						goto IL_0064;
					}
					num3 = (int)((num5 * 1469345436) ^ 0x1256AF4B);
					continue;
				case 0u:
					num2++;
					num3 = -1274011366;
					continue;
				case 5u:
				{
					int num6;
					int num7;
					if (luaTypes == LuaTypes.LUA_TUSERDATA)
					{
						num6 = -1730450769;
						num7 = num6;
					}
					else
					{
						num6 = -847532597;
						num7 = num6;
					}
					num3 = num6 ^ (int)(num5 * 1203849787);
					continue;
				}
				case 7u:
					return;
					IL_0064:
					text3 = text2;
					num3 = -1259521952;
					continue;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int getMethod(IntPtr luaState)
	{
		ObjectTranslator objectTranslator = ObjectTranslator.FromState(luaState);
		object rawNetObject = default(object);
		int result = default(int);
		MethodInfo methodInfo2 = default(MethodInfo);
		MethodInfo methodInfo = default(MethodInfo);
		int num16 = default(int);
		Array array4 = default(Array);
		ParameterInfo[] array = default(ParameterInfo[]);
		MethodInfo[] array2 = default(MethodInfo[]);
		int num13 = default(int);
		object o2 = default(object);
		MethodInfo[] array3 = default(MethodInfo[]);
		while (true)
		{
			int num = -1518041727;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1801316218)) % 5)
				{
				case 3u:
					break;
				case 2u:
					objectTranslator.throwError(luaState, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1580995155u));
					LuaDLL.lua_pushnil(luaState);
					return 1;
				case 0u:
				{
					int num24;
					int num25;
					if (rawNetObject != null)
					{
						num24 = 1508857251;
						num25 = num24;
					}
					else
					{
						num24 = 480009415;
						num25 = num24;
					}
					num = num24 ^ ((int)num2 * -1701283611);
					continue;
				}
				case 1u:
					rawNetObject = objectTranslator.getRawNetObject(luaState, 1);
					num = (int)(num2 * 645783175) ^ -248137646;
					continue;
				default:
					{
						object obj = objectTranslator.getObject(luaState, 2);
						string text = obj as string;
						Type type = _202A_200C_200B_200B_200E_202D_206F_200D_200E_206D_200B_200B_200E_206E_206A_200D_202E_200B_206D_200E_206B_202C_202B_206A_206F_202C_200E_206B_200B_206D_202C_202A_202D_200E_200C_202C_206F_206F_200D_200D_202E(rawNetObject);
						try
						{
							if (text != null)
							{
								while (true)
								{
									IL_00af:
									int num3 = -1423523853;
									while (true)
									{
										int num4;
										switch ((num2 = (uint)(num3 ^ -1801316218)) % 4)
										{
										case 3u:
											break;
										default:
											goto end_IL_00b4;
										case 1u:
										{
											int num5;
											if (!objectTranslator.metaFunctions.isMemberPresent(type, text))
											{
												num4 = 1141093043;
												num5 = num4;
											}
											else
											{
												num4 = 2006639673;
												num5 = num4;
											}
											goto IL_00f4;
										}
										case 2u:
											result = objectTranslator.metaFunctions.getMember(luaState, type, rawNetObject, text, BindingFlags.IgnoreCase | BindingFlags.Instance);
											goto IL_0609;
										case 0u:
											goto end_IL_00b4;
										}
										goto IL_00af;
										IL_00f4:
										num3 = num4 ^ (int)(num2 * 991845717);
										continue;
										end_IL_00b4:
										break;
									}
									break;
								}
							}
						}
						catch
						{
						}
						bool flag = true;
						while (true)
						{
							int num6 = -236727744;
							while (true)
							{
								object obj3;
								int num12;
								int num19;
								switch ((num2 = (uint)(num6 ^ -1801316218)) % 22)
								{
								case 14u:
									break;
								case 16u:
									if (_202B_200B_202D_206A_206F_206A_206A_206B_202A_200B_200E_200F_202B_200E_206C_206E_202B_206E_200E_200E_206A_200E_202B_200F_200B_206D_206C_202A_200B_206C_206B_206C_206F_200C_202E_200C_202E_200D_202A_202D_202E(_206E_206F_200B_206C_206C_200C_206C_200B_202C_206D_206A_200F_206B_200E_202B_200D_202A_206E_202C_206A_206E_206E_206B_200F_200F_206B_202E_206D_206F_206D_202C_202D_202D_200E_202E_200C_206D_206F_206A_206E_202E((MemberInfo)methodInfo2), global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2378368958u)))
									{
										num6 = (int)(num2 * 721476945) ^ -1671915690;
										continue;
									}
									goto IL_055b;
								case 0u:
									obj3 = _206A_202B_206B_206D_206C_200E_200B_200F_200E_200E_202D_206C_200C_200C_202C_200E_200B_202E_200E_206C_202B_200C_206C_200B_206A_206C_202E_206F_202A_206C_200B_200F_202A_206C_202A_206E_200E_200F_200C_206B_202E((MethodBase)methodInfo);
									goto IL_01db;
								case 13u:
									if (methodInfo == null)
									{
										obj3 = null;
										goto IL_01db;
									}
									num6 = ((int)num2 * -1674345414) ^ 0x5FBCC47A;
									continue;
								case 20u:
									num16 = (int)(double)obj;
									num6 = ((int)num2 * -61990731) ^ -1929993096;
									continue;
								case 3u:
									return objectTranslator.pushError(luaState, _206F_206B_200F_206E_200C_200C_202E_206F_206F_200B_200B_206D_202C_206F_206B_200F_200B_200D_200F_202A_206A_206B_206C_206C_200D_200F_200F_202E_202E_200E_202D_206F_206E_200D_200C_206C_202A_200B_206A_202E_202E((object)global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2071556564u), obj));
								case 10u:
									return objectTranslator.pushError(luaState, _200E_202B_200D_202E_202D_206E_200B_206A_206C_206D_202B_206E_206E_200E_202E_200C_202B_202C_202C_202A_202A_200E_206E_206B_200F_206D_202C_200F_206C_200D_200B_206C_200B_206C_206F_206B_206C_200D_206C_206A_202E(new object[4]
									{
										global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(810360758u),
										num16,
										global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2285033199u),
										_202A_202E_200C_202E_200C_206F_200C_202D_202E_200B_202C_202D_200F_206F_200B_206C_200F_206F_206B_202E_202C_200E_206B_206F_202E_200F_202A_200F_202E_202E_206F_202A_200E_206D_206B_200E_202E_202C_206E_206E_202E(array4)
									}));
								case 17u:
								{
									int num22;
									int num23;
									if (array.Length != 1)
									{
										num22 = -189648192;
										num23 = num22;
									}
									else
									{
										num22 = -1956945095;
										num23 = num22;
									}
									num6 = num22 ^ ((int)num2 * -973341529);
									continue;
								}
								case 7u:
									methodInfo2 = array2[num13];
									num6 = -1883210072;
									continue;
								case 6u:
								{
									array4 = rawNetObject as Array;
									int num20;
									int num21;
									if (num16 < _202A_202E_200C_202E_200C_206F_200C_202D_202E_200B_202C_202D_200F_206F_200B_206C_200F_206F_206B_202E_202C_200E_206B_206F_202E_200F_202A_200F_202E_202E_206F_202A_200E_206D_206B_200E_202E_202C_206E_206E_202E(array4))
									{
										num20 = -1962003636;
										num21 = num20;
									}
									else
									{
										num20 = -2051587154;
										num21 = num20;
									}
									num6 = num20 ^ ((int)num2 * -1454441615);
									continue;
								}
								case 9u:
									objectTranslator.push(luaState, o2);
									flag = false;
									num6 = ((int)num2 * -2015071056) ^ -458197919;
									continue;
								case 12u:
									if (_206A_202B_206B_206D_206C_200E_200B_200F_200E_200E_202D_206C_200C_200C_202C_200E_200B_202E_200E_206C_202B_200C_206C_200B_206A_206C_202E_206F_202A_206C_200B_200F_202A_206C_202A_206E_200E_200F_200C_206B_202E((MethodBase)methodInfo2).Length == 1)
									{
										num6 = ((int)num2 * -737712556) ^ -217403153;
										continue;
									}
									goto IL_055b;
								case 5u:
									methodInfo = methodInfo2;
									num6 = ((int)num2 * -2036138025) ^ 0x2CDB0658;
									continue;
								case 4u:
									array3 = _202C_200B_200E_200F_206F_206A_200F_202E_206C_206D_202A_200D_202D_206D_200B_202B_200C_202E_202B_202B_206C_200D_206E_202E_206E_200E_206A_202C_202E_202B_206F_202E_200B_206F_202C_200C_202D_200E_206C_206C_202E(type);
									num6 = -1701786773;
									continue;
								case 18u:
									o2 = _200D_202C_202B_200B_202D_206E_202B_202A_200D_200D_202B_206C_202A_202B_206D_206A_206C_202A_200F_200B_206F_206A_206E_200F_206C_202D_206B_206E_200D_200C_202D_202D_200C_202A_206F_202A_206A_206B_206D_202C_202E(array4, num16);
									num6 = -846478157;
									continue;
								case 21u:
								{
									int num17;
									int num18;
									if (obj is double)
									{
										num17 = 1302162320;
										num18 = num17;
									}
									else
									{
										num17 = 68047774;
										num18 = num17;
									}
									num6 = num17 ^ (int)(num2 * 219572310);
									continue;
								}
								case 2u:
								{
									int num14;
									int num15;
									if (_202E_206D_206D_206B_202B_200F_200E_202A_206E_206D_206D_200C_200E_200D_206D_202E_200C_202C_206B_200D_206D_202D_202C_206C_206F_202A_206A_200D_206B_200F_200C_200D_200B_206F_202C_200B_200D_202A_200C_200C_202E(type))
									{
										num14 = 1893580365;
										num15 = num14;
									}
									else
									{
										num14 = 433766532;
										num15 = num14;
									}
									num6 = num14 ^ (int)(num2 * 933396852);
									continue;
								}
								case 15u:
									array2 = array3;
									num13 = 0;
									num6 = (int)((num2 * 979271914) ^ 0x11FE5289);
									continue;
								case 11u:
								{
									int num10;
									int num11;
									if (array == null)
									{
										num10 = -424870716;
										num11 = num10;
									}
									else
									{
										num10 = -1685565500;
										num11 = num10;
									}
									num6 = num10 ^ (int)(num2 * 1575910561);
									continue;
								}
								default:
									obj = objectTranslator.getAsType(luaState, 2, _206E_200B_206F_206F_200B_206E_200E_200B_206D_202B_202D_206F_202E_206D_206E_202E_200E_202A_206B_206C_202D_200C_200F_206C_206A_200C_206B_202A_206D_200D_206B_200C_206C_206E_206B_206C_200C_200C_202C_206E_202E(array[0]));
									try
									{
										object o = _202B_206A_200D_202E_206B_206D_206B_206A_206E_200C_200F_202D_200C_206B_200D_206E_200C_200C_206B_206E_200F_206E_202E_206C_200D_200B_202A_200E_202E_206F_202E_206C_200D_206A_202C_202E_202B_206C_206D_202B_202E((MethodBase)methodInfo, rawNetObject, new object[1] { obj });
										objectTranslator.push(luaState, o);
										flag = false;
									}
									catch (TargetInvocationException ex)
									{
										while (true)
										{
											IL_0469:
											int num7 = -1737359172;
											while (true)
											{
												switch ((num2 = (uint)(num7 ^ -1801316218)) % 6)
												{
												case 5u:
													break;
												default:
													goto end_IL_046e;
												case 1u:
													result = objectTranslator.pushError(luaState, _206E_206F_202D_200F_200B_206D_202A_206B_200C_202A_206A_200B_200F_206E_206A_202D_206B_206F_200D_202D_200B_202B_206D_206D_206B_206A_202B_202E_200E_202D_202C_200D_202E_202A_206D_202B_200C_206E_200B_206A_202E((object)global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1158607237u), obj, (object)global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3666732799u)));
													num7 = (int)(num2 * 106632921) ^ -1194409641;
													continue;
												case 0u:
													result = objectTranslator.pushError(luaState, _200E_202B_200D_202E_202D_206E_200B_206A_206C_206D_202B_206E_206E_200E_202E_200C_202B_202C_202C_202A_202A_200E_206E_206B_200F_206D_202C_200F_206C_200D_200B_206C_200B_206C_206F_206B_206C_200D_206C_206A_202E(new object[4]
													{
														global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(853735259u),
														obj,
														global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(522925104u),
														_206D_200D_202B_206E_202C_206A_206F_200C_206E_202A_202D_200D_200D_206D_200F_202C_206B_206C_200B_206C_206E_206D_206B_202C_206D_202B_200E_202E_200D_200B_202A_206B_206F_206D_202E_206D_202B_202E_202D_200E_202E((Exception)ex)
													}));
													goto end_IL_0130;
												case 2u:
												{
													int num8;
													int num9;
													if (!(_202B_206F_200B_200F_206D_200F_206D_202B_200B_206A_200D_200C_202E_206B_206F_200E_202D_206D_206B_200D_202A_202C_206B_206E_200D_202E_202A_206E_206E_200E_200C_202C_200C_206F_200F_202A_206F_202B_206A_200F_202E((Exception)ex) is KeyNotFoundException))
													{
														num8 = -2081139774;
														num9 = num8;
													}
													else
													{
														num8 = -410564459;
														num9 = num8;
													}
													num7 = num8 ^ ((int)num2 * -1657299959);
													continue;
												}
												case 3u:
													goto end_IL_046e;
												case 4u:
													goto end_IL_0130;
												}
												goto IL_0469;
												continue;
												end_IL_046e:
												break;
											}
											break;
										}
									}
									goto IL_055b;
								case 19u:
									goto IL_0594;
								case 1u:
									goto IL_05e0;
									IL_0566:
									while (true)
									{
										switch ((num2 = (uint)(num12 ^ -1801316218)) % 7)
										{
										case 2u:
											break;
										case 6u:
											goto IL_0594;
										case 5u:
											return objectTranslator.pushError(luaState, _206F_206B_200F_206E_200C_200C_202E_206F_206F_200B_200B_206D_202C_206F_206B_200F_200B_200D_200F_202A_206A_206B_206C_206C_200D_200F_200F_202E_202E_200E_202D_206F_206E_200D_200C_206C_202A_200B_206A_202E_202E((object)global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3395760498u), obj));
										case 0u:
											return 2;
										case 3u:
											goto IL_05e0;
										case 1u:
											LuaDLL.lua_pushboolean(luaState, value: false);
											num12 = -1691868697;
											continue;
										default:
											goto end_IL_0130;
										}
										break;
									}
									goto IL_0561;
									IL_055b:
									num13++;
									goto IL_0561;
									IL_0561:
									num12 = -1186022156;
									goto IL_0566;
									IL_05e0:
									if (!flag)
									{
										num12 = -1929539845;
										num19 = num12;
									}
									else
									{
										num12 = -2016567919;
										num19 = num12;
									}
									goto IL_0566;
									IL_0594:
									if (num13 < array2.Length)
									{
										goto case 7u;
									}
									num12 = -702004185;
									goto IL_0566;
									IL_01db:
									array = (ParameterInfo[])obj3;
									num6 = -2100630049;
									continue;
								}
								break;
							}
							continue;
							end_IL_0130:
							break;
						}
						goto IL_0609;
					}
					IL_0609:
					return result;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int getBaseMethod(IntPtr luaState)
	{
		ObjectTranslator objectTranslator = ObjectTranslator.FromState(luaState);
		object rawNetObject = default(object);
		string text = default(string);
		while (true)
		{
			int num = 1095985660;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5041D270)) % 15)
				{
				case 7u:
					break;
				case 13u:
					objectTranslator.throwError(luaState, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1580995155u));
					LuaDLL.lua_pushnil(luaState);
					LuaDLL.lua_pushboolean(luaState, value: false);
					return 2;
				case 9u:
					objectTranslator.metaFunctions.getMember(luaState, _202A_200C_200B_200B_200E_202D_206F_200D_200E_206D_200B_200B_200E_206E_206A_200D_202E_200B_206D_200E_206B_202C_202B_206A_206F_202C_200E_206B_200B_206D_202C_202A_202D_200E_200C_202C_206F_206F_200D_200D_202E(rawNetObject), rawNetObject, _202C_202E_206E_200D_202B_202A_200E_206E_206C_202B_200B_200B_200F_202A_206E_206D_206C_202E_206E_200B_202E_202A_206C_206B_200E_200B_200C_206A_206A_206E_202C_200F_202E_200C_206E_200E_202D_202E_206C_202A_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(680458659u), text), BindingFlags.IgnoreCase | BindingFlags.Instance);
					num = 1489171562;
					continue;
				case 6u:
					LuaDLL.lua_pushboolean(luaState, value: false);
					num = 1907454972;
					continue;
				case 11u:
					LuaDLL.lua_pushboolean(luaState, value: false);
					num = (int)(num2 * 1284635630) ^ -1907862196;
					continue;
				case 10u:
					LuaDLL.lua_pushnil(luaState);
					num = ((int)num2 * -991577527) ^ 0x6F41B72D;
					continue;
				case 1u:
					return objectTranslator.metaFunctions.getMember(luaState, _202A_200C_200B_200B_200E_202D_206F_200D_200E_206D_200B_200B_200E_206E_206A_200D_202E_200B_206D_200E_206B_202C_202B_206A_206F_202C_200E_206B_200B_206D_202C_202A_202D_200E_200C_202C_206F_206F_200D_200D_202E(rawNetObject), rawNetObject, text, BindingFlags.IgnoreCase | BindingFlags.Instance);
				case 2u:
					rawNetObject = objectTranslator.getRawNetObject(luaState, 1);
					num = (int)((num2 * 1140136118) ^ 0x25948B9D);
					continue;
				case 5u:
				{
					int num6;
					int num7;
					if (LuaDLL.lua_type(luaState, -1) == LuaTypes.LUA_TNIL)
					{
						num6 = -468549723;
						num7 = num6;
					}
					else
					{
						num6 = -149805629;
						num7 = num6;
					}
					num = num6 ^ (int)(num2 * 1740510855);
					continue;
				}
				case 12u:
				{
					int num4;
					int num5;
					if (rawNetObject != null)
					{
						num4 = 1183284426;
						num5 = num4;
					}
					else
					{
						num4 = 1747506162;
						num5 = num4;
					}
					num = num4 ^ (int)(num2 * 507773835);
					continue;
				}
				case 8u:
					LuaDLL.lua_settop(luaState, -2);
					num = (int)(num2 * 2130931555) ^ -1796438211;
					continue;
				case 0u:
				{
					text = LuaDLL.lua_tostring(luaState, 2);
					int num3;
					if (text != null)
					{
						num = 347351134;
						num3 = num;
					}
					else
					{
						num = 1236041130;
						num3 = num;
					}
					continue;
				}
				case 3u:
					LuaDLL.lua_settop(luaState, -2);
					num = (int)(num2 * 53208530) ^ -1075260017;
					continue;
				case 14u:
					return 2;
				default:
					return 2;
				}
				break;
			}
		}
	}

	private bool isMemberPresent(IReflect objType, string methodName)
	{
		object obj = checkMemberCache(memberCache, objType, methodName);
		if (obj != null)
		{
			goto IL_0012;
		}
		goto IL_0049;
		IL_0012:
		int num = -1458820852;
		goto IL_0017;
		IL_0017:
		uint num2;
		MemberInfo[] array = default(MemberInfo[]);
		switch ((num2 = (uint)(num ^ -135447607)) % 4)
		{
		case 2u:
			break;
		case 1u:
			return true;
		case 0u:
			goto IL_0049;
		default:
			return array.Length > 0;
		}
		goto IL_0012;
		IL_0049:
		array = _202A_200F_202B_206B_200F_202C_206B_206F_206D_206E_206A_202E_200E_206A_206E_200B_200C_206D_206C_206F_206E_206A_200B_202E_206D_202A_200F_200C_202B_206A_200B_200E_206A_200F_202E_206D_206A_206D_200B_206F_202E(objType, methodName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		num = -1277448254;
		goto IL_0017;
	}

	private int getMember(IntPtr luaState, IReflect objType, object obj, string methodName, BindingFlags bindingType)
	{
		bool flag = false;
		MemberInfo[] array = default(MemberInfo[]);
		MemberInfo memberInfo = default(MemberInfo);
		FieldInfo fieldInfo = default(FieldInfo);
		object obj2 = default(object);
		PropertyInfo propertyInfo = default(PropertyInfo);
		LuaCSFunction luaCSFunction = default(LuaCSFunction);
		Type t = default(Type);
		EventInfo eventInfo = default(EventInfo);
		int result = default(int);
		while (true)
		{
			int num = 1076351131;
			while (true)
			{
				int num12;
				uint num2;
				int num25;
				switch ((num2 = (uint)(num ^ 0x79C1024F)) % 17)
				{
				case 0u:
					break;
				case 10u:
				{
					array = _202A_200F_202B_206B_200F_202C_206B_206F_206D_206E_206A_202E_200E_206A_206E_200B_200C_206D_206C_206F_206E_206A_200B_202E_206D_202A_200F_200C_202B_206A_200B_200E_206A_200F_202E_206D_206A_206D_200B_206F_202E(objType, methodName, bindingType | BindingFlags.Static | BindingFlags.Public | BindingFlags.IgnoreCase);
					int num13;
					if (array.Length > 0)
					{
						num = 1416800621;
						num13 = num;
					}
					else
					{
						num = 1114814487;
						num13 = num;
					}
					continue;
				}
				case 9u:
					memberInfo = array[0];
					num = ((int)num2 * -1261081295) ^ 0x40D30480;
					continue;
				case 14u:
					fieldInfo = (FieldInfo)memberInfo;
					if (obj2 == null)
					{
						num = ((int)num2 * -688643186) ^ 0x71ED2A09;
						continue;
					}
					goto IL_0234;
				case 11u:
					num = (int)((num2 * 336701648) ^ 0x1ED3CDF7);
					continue;
				case 3u:
					flag = true;
					num = (int)(num2 * 158995942) ^ -1583827439;
					continue;
				case 13u:
					translator.pushFunction(luaState, (LuaCSFunction)obj2);
					translator.push(luaState, true);
					num = ((int)num2 * -298167484) ^ -890410095;
					continue;
				case 1u:
				{
					int num23;
					int num24;
					if (array.Length <= 0)
					{
						num23 = 790221012;
						num24 = num23;
					}
					else
					{
						num23 = 1624835208;
						num24 = num23;
					}
					num = num23 ^ ((int)num2 * -1438303616);
					continue;
				}
				case 4u:
					memberInfo = array[0];
					num = ((int)num2 * -128978856) ^ -1277082034;
					continue;
				case 2u:
					if (memberInfo != null)
					{
						num = 819206124;
						continue;
					}
					goto IL_061a;
				case 12u:
				{
					memberInfo = null;
					obj2 = checkMemberCache(memberCache, objType, methodName);
					int num10;
					int num11;
					if (obj2 is LuaCSFunction)
					{
						num10 = 170371342;
						num11 = num10;
					}
					else
					{
						num10 = 1637866940;
						num11 = num10;
					}
					num = num10 ^ ((int)num2 * -1743506481);
					continue;
				}
				case 15u:
					memberInfo = (MemberInfo)obj2;
					num = (int)(num2 * 1785555380) ^ -1204778119;
					continue;
				case 8u:
				{
					int num9;
					if (obj2 != null)
					{
						num = 582865399;
						num9 = num;
					}
					else
					{
						num = 477149587;
						num9 = num;
					}
					continue;
				}
				case 6u:
					if (_206D_202E_206F_200F_200C_206C_206E_206B_200B_200E_202A_202D_200E_206A_200D_200C_200C_200E_200C_200C_202C_202E_206F_202C_200E_202C_200F_200F_206F_206A_206D_206A_206D_200C_202A_200B_206F_206A_206A_202B_202E(memberInfo) == MemberTypes.Field)
					{
						num = ((int)num2 * -1223994329) ^ -483586727;
						continue;
					}
					while (_206D_202E_206F_200F_200C_206C_206E_206B_200B_200E_202A_202D_200E_206A_200D_200C_200C_200E_200C_200C_202C_202E_206F_202C_200E_202C_200F_200F_206F_206A_206D_206A_206D_200C_202A_200B_206F_206A_206A_202B_202E(memberInfo) == MemberTypes.Property)
					{
						int num3 = 847099921;
						while (true)
						{
							switch ((num2 = (uint)(num3 ^ 0x79C1024F)) % 4)
							{
							case 0u:
								num3 = 1852150426;
								continue;
							case 1u:
								break;
							case 2u:
								goto IL_0293;
							default:
								goto IL_02ae;
							}
							break;
							IL_02ae:
							setMemberCache(memberCache, objType, methodName, memberInfo);
							goto IL_02be;
							IL_0293:
							propertyInfo = (PropertyInfo)memberInfo;
							if (obj2 == null)
							{
								num3 = ((int)num2 * -954527206) ^ -1740391468;
								continue;
							}
							goto IL_02be;
							IL_02be:
							try
							{
								object o = _202B_206A_200D_202E_206B_206D_206B_206A_206E_200C_200F_202D_200C_206B_200D_206E_200C_200C_206B_206E_200F_206E_202E_206C_200D_200B_202A_200E_202E_206F_202E_206C_200D_206A_202C_202E_202B_206C_206D_202B_202E((MethodBase)_206B_206A_206E_202B_202B_202C_202E_206E_206E_202C_202C_200D_206D_202D_200C_202C_206F_200E_202D_200B_202B_202A_202D_202C_206B_206D_202D_206D_200F_206F_202D_200C_200B_200C_200D_200B_206C_206C_206B_206A_202E(propertyInfo), obj, (object[])null);
								translator.push(luaState, o);
							}
							catch (ArgumentException)
							{
								while (true)
								{
									IL_02e2:
									int num4 = 1890913376;
									while (true)
									{
										switch ((num2 = (uint)(num4 ^ 0x79C1024F)) % 6)
										{
										case 0u:
											break;
										default:
											goto end_IL_02e7;
										case 5u:
											return getMember(luaState, _206A_206C_206B_200D_206A_200F_206E_202D_202D_200F_202C_206B_206F_202E_200E_202B_206D_202A_202B_202D_202A_202D_202A_202E_206A_200F_202C_206A_200C_202B_200D_200C_200B_202C_206D_200C_202A_206B_200D_206D_202E((Type)objType), obj, methodName, bindingType);
										case 1u:
											LuaDLL.lua_pushnil(luaState);
											num4 = 1215732611;
											continue;
										case 3u:
										{
											int num7;
											int num8;
											if (!(objType is Type))
											{
												num7 = -1870539357;
												num8 = num7;
											}
											else
											{
												num7 = -1072739166;
												num8 = num7;
											}
											num4 = num7 ^ ((int)num2 * -1614165457);
											continue;
										}
										case 2u:
										{
											int num5;
											int num6;
											if ((Type)objType == _206D_206C_200E_200E_206E_200C_206A_202A_202B_206D_200B_200F_202B_206E_202C_200C_206E_206A_206B_200C_206E_202D_200B_206B_202C_202C_200D_200C_200C_202D_206F_206F_202E_200C_202D_202A_200F_206D_200C_206D_202E(typeof(object).TypeHandle))
											{
												num5 = 300006826;
												num6 = num5;
											}
											else
											{
												num5 = 1617475298;
												num6 = num5;
											}
											num4 = num5 ^ ((int)num2 * -225892498);
											continue;
										}
										case 4u:
											goto end_IL_02e7;
										}
										goto IL_02e2;
										continue;
										end_IL_02e7:
										break;
									}
									break;
								}
							}
							catch (TargetInvocationException e)
							{
								ThrowError(luaState, e);
								LuaDLL.lua_pushnil(luaState);
							}
							goto IL_06e0;
						}
					}
					goto IL_04e9;
				case 5u:
					array = _202A_200F_202B_206B_200F_202C_206B_206F_206D_206E_206A_202E_200E_206A_206E_200B_200C_206D_206C_206F_206E_206A_200B_202E_206D_202A_200F_200C_202B_206A_200B_200E_206A_200F_202E_206D_206A_206D_200B_206F_202E(objType, methodName, bindingType | BindingFlags.Public | BindingFlags.IgnoreCase);
					num = 1401746302;
					continue;
				case 7u:
					return 2;
				default:
					{
						setMemberCache(memberCache, objType, methodName, memberInfo);
						goto IL_0234;
					}
					IL_0234:
					try
					{
						translator.push(luaState, _202C_202B_200B_200D_200B_202B_202D_206F_202E_206D_202E_202E_206E_200C_202E_206A_202E_202B_200F_206A_200E_206B_200E_206D_200E_202A_206E_206E_206E_206D_206D_202D_202E_206C_206B_200D_206C_202E_206C_206E_202E(fieldInfo, obj));
					}
					catch
					{
						LuaDLL.lua_pushnil(luaState);
					}
					goto IL_06e0;
					IL_06e0:
					translator.push(luaState, false);
					num12 = 335836655;
					goto IL_03c2;
					IL_03c2:
					while (true)
					{
						switch ((num2 = (uint)(num12 ^ 0x79C1024F)) % 25)
						{
						case 3u:
							num12 = 1362973801;
							continue;
						case 18u:
							num12 = (int)(num2 * 2008242858) ^ -325845626;
							continue;
						case 22u:
						{
							int num16;
							int num17;
							if (_206D_202E_206F_200F_200C_206C_206E_206B_200B_200E_202A_202D_200E_206A_200D_200C_200C_200E_200C_200C_202C_202E_206F_202C_200E_202C_200F_200F_206F_206A_206D_206A_206D_200C_202A_200B_206F_206A_206A_202B_202E(memberInfo) != MemberTypes.NestedType)
							{
								num16 = 1751408698;
								num17 = num16;
							}
							else
							{
								num16 = 774483811;
								num17 = num16;
							}
							num12 = num16 ^ (int)(num2 * 767852469);
							continue;
						}
						case 19u:
							translator.pushFunction(luaState, luaCSFunction);
							num12 = 1898841497;
							continue;
						case 10u:
							return 2;
						case 17u:
						{
							string text = _206E_206F_200B_206C_206C_200C_206C_200B_202C_206D_206A_200F_206B_200E_202B_200D_202A_206E_202C_206A_206E_206E_206B_200F_200F_206B_202E_206D_206F_206D_202C_202D_202D_200E_202E_200C_206D_206F_206A_206E_202E(memberInfo);
							Type type = _200E_202A_200C_206F_202D_200C_200F_200C_202E_206A_206F_200B_206F_200F_202E_200D_200C_206A_200C_206C_200B_202E_202C_206D_206A_200F_200D_202B_200B_200D_202E_200D_200E_202A_206F_206B_200B_206A_206B_206C_202E(memberInfo);
							string className = _206B_206D_202E_202E_200D_206D_200B_202C_202C_206A_200C_202D_202A_200C_200D_206E_200F_206A_206D_202D_206B_202C_200E_202C_206E_200D_200F_206D_202C_206B_200D_200C_202B_206A_206B_206A_202C_206E_206E_200D_202E(_206B_202B_200B_206E_206D_202A_202C_200E_202B_200C_206F_200E_200F_206B_200B_202D_200B_206C_202D_202B_200D_202B_206B_200E_202A_200C_206D_206D_202E_200E_200C_206B_200C_206B_200B_202E_206E_200B_200E_202C_202E(type), global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3675639468u), text);
							t = translator.FindType(className);
							num12 = 1572377370;
							continue;
						}
						case 16u:
							break;
						case 9u:
							setMemberCache(memberCache, objType, methodName, memberInfo);
							num12 = ((int)num2 * -87536011) ^ -1279577676;
							continue;
						case 20u:
							setMemberCache(memberCache, objType, methodName, luaCSFunction);
							num12 = (int)((num2 * 2000755634) ^ 0x5422BCD1);
							continue;
						case 21u:
						{
							int num20;
							int num21;
							if (obj2 != null)
							{
								num20 = -377373993;
								num21 = num20;
							}
							else
							{
								num20 = -1732493412;
								num21 = num20;
							}
							num12 = num20 ^ ((int)num2 * -109848656);
							continue;
						}
						case 2u:
						{
							eventInfo = (EventInfo)memberInfo;
							int num18;
							int num19;
							if (obj2 != null)
							{
								num18 = -931971883;
								num19 = num18;
							}
							else
							{
								num18 = -391961156;
								num19 = num18;
							}
							num12 = num18 ^ ((int)num2 * -1170459829);
							continue;
						}
						case 23u:
							translator.push(luaState, new RegisterEventHandler(translator.pendingEvents, obj, eventInfo));
							num12 = 1347832461;
							continue;
						case 0u:
						{
							int num14;
							int num15;
							if (obj2 == null)
							{
								num14 = -1747883088;
								num15 = num14;
							}
							else
							{
								num14 = -1056358905;
								num15 = num14;
							}
							num12 = num14 ^ ((int)num2 * -120113606);
							continue;
						}
						case 7u:
							translator.throwError(luaState, _202C_202E_206E_200D_202B_202A_200E_206E_206C_202B_200B_200B_200F_202A_206E_206D_206C_202E_206E_200B_202E_202A_206C_206B_200E_200B_200C_206A_206A_206E_202C_200F_202E_200C_206E_200E_202D_202E_206C_202A_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1004677231u), methodName));
							LuaDLL.lua_pushnil(luaState);
							num12 = 925071698;
							continue;
						case 14u:
							goto IL_061a;
						case 4u:
							goto IL_0647;
						case 15u:
							return 2;
						case 13u:
							translator.push(luaState, true);
							num12 = ((int)num2 * -665436630) ^ -1781657261;
							continue;
						case 12u:
							translator.pushType(luaState, t);
							num12 = (int)((num2 * 1905840687) ^ 0x6BDC5C88);
							continue;
						case 8u:
							luaCSFunction = new LuaMethodWrapper(translator, objType, methodName, bindingType).call;
							num12 = 847840052;
							continue;
						case 1u:
						case 5u:
						case 24u:
							goto IL_06e0;
						case 6u:
							setMemberCache(memberCache, objType, methodName, memberInfo);
							num12 = ((int)num2 * -1739647106) ^ 0x1E47A4A8;
							continue;
						default:
							return result;
						}
						break;
						IL_0647:
						int num22;
						if (!flag)
						{
							num12 = 1223336886;
							num22 = num12;
						}
						else
						{
							num12 = 558964631;
							num22 = num12;
						}
					}
					goto IL_04e9;
					IL_04e9:
					if (_206D_202E_206F_200F_200C_206C_206E_206B_200B_200E_202A_202D_200E_206A_200D_200C_200C_200E_200C_200C_202C_202E_206F_202C_200E_202C_200F_200F_206F_206A_206D_206A_206D_200C_202A_200B_206F_206A_206A_202B_202E(memberInfo) != MemberTypes.Event)
					{
						num12 = 1813918117;
						num25 = num12;
					}
					else
					{
						num12 = 330059660;
						num25 = num12;
					}
					goto IL_03c2;
					IL_061a:
					translator.throwError(luaState, _202C_202E_206E_200D_202B_202A_200E_206E_206C_202B_200B_200B_200F_202A_206E_206D_206C_202E_206E_200B_202E_202A_206C_206B_200E_200B_200C_206A_206A_206E_202C_200F_202E_200C_206E_200E_202D_202E_206C_202A_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1647709901u), methodName));
					LuaDLL.lua_pushnil(luaState);
					num12 = 1275212568;
					goto IL_03c2;
				}
				break;
			}
		}
	}

	private object checkMemberCache(Hashtable memberCache, IReflect objType, string memberName)
	{
		Hashtable hashtable = (Hashtable)_202B_206F_200F_206C_206B_200C_206D_206A_202E_200E_202C_202A_206B_200D_202E_202E_200D_206E_202D_202A_200E_202A_206F_202D_202B_200C_202D_202B_202A_202C_202B_202D_202E_200D_206A_200B_202E_202B_202C_202E(memberCache, (object)objType);
		while (true)
		{
			int num = -685621045;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)(num ^ -1264755355)) % 4)
				{
				case 0u:
					break;
				case 2u:
				{
					int num4;
					if (hashtable != null)
					{
						num3 = -1587096416;
						num4 = num3;
					}
					else
					{
						num3 = -1483018;
						num4 = num3;
					}
					goto IL_0044;
				}
				case 1u:
					return _202B_206F_200F_206C_206B_200C_206D_206A_202E_200E_202C_202A_206B_200D_202E_202E_200D_206E_202D_202A_200E_202A_206F_202D_202B_200C_202D_202B_202A_202C_202B_202D_202E_200D_206A_200B_202E_202B_202C_202E(hashtable, (object)memberName);
				default:
					return null;
				}
				break;
				IL_0044:
				num = num3 ^ ((int)num2 * -1431789910);
			}
		}
	}

	private void setMemberCache(Hashtable memberCache, IReflect objType, string memberName, object member)
	{
		Hashtable hashtable = (Hashtable)_202B_206F_200F_206C_206B_200C_206D_206A_202E_200E_202C_202A_206B_200D_202E_202E_200D_206E_202D_202A_200E_202A_206F_202D_202B_200C_202D_202B_202A_202C_202B_202D_202E_200D_206A_200B_202E_202B_202C_202E(memberCache, (object)objType);
		if (hashtable == null)
		{
			goto IL_0010;
		}
		goto IL_004f;
		IL_0010:
		int num = 911844159;
		goto IL_0015;
		IL_0015:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x22D7CEE2)) % 5)
			{
			case 0u:
				break;
			default:
				return;
			case 2u:
				hashtable = _202E_200B_200E_202A_200D_200D_202E_200F_202E_200F_200E_206A_200E_206A_206C_206E_202C_200D_200F_206E_206C_202E_200F_206E_200F_206B_202D_202C_202B_200C_202B_206B_206A_202A_200B_200C_202A_200E_200B_206A_202E();
				num = (int)(num2 * 1275860289) ^ -336448517;
				continue;
			case 4u:
				goto IL_004f;
			case 3u:
				_200E_200F_206B_202C_202A_200D_206E_200F_202B_200D_206D_200E_202E_200C_206B_200F_200F_206F_200E_200E_206D_200E_200F_206A_200D_206C_202E_206D_206F_206D_200E_202C_202B_206B_206B_202B_206E_202A_206D_200E_202E(memberCache, (object)objType, (object)hashtable);
				num = ((int)num2 * -1844718858) ^ -1508220507;
				continue;
			case 1u:
				return;
			}
			break;
		}
		goto IL_0010;
		IL_004f:
		_200E_200F_206B_202C_202A_200D_206E_200F_202B_200D_206D_200E_202E_200C_206B_200F_200F_206F_200E_200E_206D_200E_200F_206A_200D_206C_202E_206D_206F_206D_200E_202C_202B_206B_206B_202B_206E_202A_206D_200E_202E(hashtable, (object)memberName, member);
		num = 1812621295;
		goto IL_0015;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int setFieldOrProperty(IntPtr luaState)
	{
		ObjectTranslator objectTranslator = ObjectTranslator.FromState(luaState);
		object rawNetObject = objectTranslator.getRawNetObject(luaState, 1);
		Type type = default(Type);
		bool flag = default(bool);
		string detailMessage = default(string);
		object asType = default(object);
		Type paramType = default(Type);
		Type paramType2 = default(Type);
		ParameterInfo[] array = default(ParameterInfo[]);
		int num6 = default(int);
		MethodInfo methodInfo = default(MethodInfo);
		object[] array2 = default(object[]);
		Array array3 = default(Array);
		object asType3 = default(object);
		while (true)
		{
			int num = -911888011;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1907306116)) % 7)
				{
				case 0u:
					break;
				case 5u:
					return 0;
				case 6u:
					type = _202A_200C_200B_200B_200E_202D_206F_200D_200E_206D_200B_200B_200E_206E_206A_200D_202E_200B_206D_200E_206B_202C_202B_206A_206F_202C_200E_206B_200B_206D_202C_202A_202D_200E_200C_202C_206F_206F_200D_200D_202E(rawNetObject);
					flag = objectTranslator.metaFunctions.trySetMember(luaState, type, rawNetObject, BindingFlags.IgnoreCase | BindingFlags.Instance, out detailMessage);
					num = -635889529;
					continue;
				case 2u:
				{
					int num10;
					int num11;
					if (rawNetObject == null)
					{
						num10 = -1967511260;
						num11 = num10;
					}
					else
					{
						num10 = -1228343796;
						num11 = num10;
					}
					num = num10 ^ (int)(num2 * 1654866376);
					continue;
				}
				case 3u:
					objectTranslator.throwError(luaState, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(84846967u));
					num = (int)((num2 * 116373045) ^ 0xE2FA607);
					continue;
				case 4u:
					if (flag)
					{
						num = ((int)num2 * -217133814) ^ 0x61EB378D;
						continue;
					}
					try
					{
						if (_202E_206D_206D_206B_202B_200F_200E_202A_206E_206D_206D_200C_200E_200D_206D_202E_200C_202C_206B_200D_206D_202D_202C_206C_206F_202A_206A_200D_206B_200F_200C_200D_200B_206F_202C_200B_200D_202A_200C_200C_202E(type))
						{
							goto IL_00e1;
						}
						goto IL_023d;
						IL_00e1:
						int num3 = -1137074340;
						goto IL_00e6;
						IL_00e6:
						while (true)
						{
							switch ((num2 = (uint)(num3 ^ -1907306116)) % 15)
							{
							case 4u:
								break;
							default:
								goto end_IL_00d6;
							case 11u:
								asType = objectTranslator.getAsType(luaState, 3, paramType);
								paramType2 = _206E_200B_206F_206F_200B_206E_200E_200B_206D_202B_202D_206F_202E_206D_206E_202E_200E_202A_206B_206C_202D_200C_200F_206C_206A_200C_206B_202A_206D_200D_206B_200C_206C_206E_206B_206C_200C_200C_202C_206E_202E(array[0]);
								num3 = ((int)num2 * -1879119131) ^ -1295340725;
								continue;
							case 2u:
								objectTranslator.throwError(luaState, detailMessage);
								num3 = -501580213;
								continue;
							case 14u:
								num6 = (int)LuaDLL.lua_tonumber(luaState, 2);
								num3 = (int)(num2 * 1082832531) ^ -1047208574;
								continue;
							case 10u:
							{
								int num7;
								int num8;
								if (LuaDLL.lua_isnumber(luaState, 2))
								{
									num7 = -618170745;
									num8 = num7;
								}
								else
								{
									num7 = -103078638;
									num8 = num7;
								}
								num3 = num7 ^ (int)(num2 * 1250006578);
								continue;
							}
							case 12u:
								_202B_206A_200D_202E_206B_206D_206B_206A_206E_200C_200F_202D_200C_206B_200D_206E_200C_200C_206B_206E_200F_206E_202E_206C_200D_200B_202A_200E_202E_206F_202E_206C_200D_206A_202C_202E_202B_206C_206D_202B_202E((MethodBase)methodInfo, rawNetObject, array2);
								num3 = ((int)num2 * -1707430487) ^ 0x4FADB80D;
								continue;
							case 3u:
								array3 = (Array)rawNetObject;
								asType3 = objectTranslator.getAsType(luaState, 3, _200D_202B_202B_206B_202B_206E_206B_206A_206A_206A_206B_200E_202E_206D_206D_206D_202C_200B_200E_200F_200F_206D_200F_206F_206B_206D_202B_202C_200F_202A_200C_202B_202B_206B_200B_200B_202D_200D_202D_200D_202E(_202A_200C_200B_200B_200E_202D_206F_200D_200E_206D_200B_200B_200E_206E_206A_200D_202E_200B_206D_200E_206B_202C_202B_206A_206F_202C_200E_206B_200B_206D_202C_202A_202D_200E_200C_202C_206F_206F_200D_200D_202E((object)array3)));
								num3 = (int)(num2 * 30598045) ^ -670851303;
								continue;
							case 6u:
								array = _206A_202B_206B_206D_206C_200E_200B_200F_200E_200E_202D_206C_200C_200C_202C_200E_200B_202E_200E_206C_202B_200C_206C_200B_206A_206C_202E_206F_202A_206C_200B_200F_202A_206C_202A_206E_200E_200F_200C_206B_202E((MethodBase)methodInfo);
								num3 = (int)(num2 * 1352303799) ^ -195498324;
								continue;
							case 1u:
								paramType = _206E_200B_206F_206F_200B_206E_200E_200B_206D_202B_202D_206F_202E_206D_206E_202E_200E_202A_206B_206C_202D_200C_200F_206C_206A_200C_206B_202A_206D_200D_206B_200C_206C_206E_206B_206C_200C_200C_202C_206E_202E(array[1]);
								num3 = (int)(num2 * 1506837747) ^ -1287882427;
								continue;
							case 13u:
								goto IL_023d;
							case 5u:
								_206A_200B_206F_206A_206E_206C_202D_202C_206B_206A_202D_200E_200E_200C_206E_206A_202B_206F_206D_202E_206E_202A_200F_206E_206B_200F_202B_202C_206B_200C_200B_200D_202C_206A_206D_202E_200D_200D_202C_202B_202E(array3, asType3, num6);
								num3 = ((int)num2 * -2048652892) ^ -1416079597;
								continue;
							case 0u:
								num3 = ((int)num2 * -1080835896) ^ 0x5FAC6783;
								continue;
							case 8u:
							{
								object asType2 = objectTranslator.getAsType(luaState, 2, paramType2);
								array2 = new object[2] { asType2, asType };
								num3 = ((int)num2 * -279230908) ^ 0x761E1284;
								continue;
							}
							case 9u:
							{
								int num4;
								int num5;
								if (methodInfo != null)
								{
									num4 = 771729105;
									num5 = num4;
								}
								else
								{
									num4 = 1159904513;
									num5 = num4;
								}
								num3 = num4 ^ (int)(num2 * 394957203);
								continue;
							}
							case 7u:
								goto end_IL_00d6;
							}
							break;
						}
						goto IL_00e1;
						IL_023d:
						methodInfo = _202C_200C_206E_202A_200B_202C_202B_202C_206D_206B_202E_206C_202B_206E_206E_206B_202C_206E_200D_206D_200C_202D_206B_206B_206B_206F_200C_200C_206D_200F_200C_200C_206A_206B_200E_200D_200C_206F_202E_206F_202E(type, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3494925589u));
						num3 = -942122477;
						goto IL_00e6;
						end_IL_00d6:;
					}
					catch (SEHException)
					{
						while (true)
						{
							switch ((num2 = 280449688u) % 3)
							{
							case 2u:
								break;
							default:
								goto end_IL_02e1;
							case 1u:
								throw;
							case 0u:
								goto end_IL_02e1;
							}
							continue;
							end_IL_02e1:
							break;
						}
					}
					catch (Exception e)
					{
						while (true)
						{
							IL_031a:
							int num9 = -2047862271;
							while (true)
							{
								switch ((num2 = (uint)(num9 ^ -1907306116)) % 3)
								{
								case 0u:
									break;
								default:
									goto end_IL_031f;
								case 1u:
									goto IL_033d;
								case 2u:
									goto end_IL_031f;
								}
								goto IL_031a;
								IL_033d:
								objectTranslator.metaFunctions.ThrowError(luaState, e);
								num9 = ((int)num2 * -896901731) ^ 0x247F44DC;
								continue;
								end_IL_031f:
								break;
							}
							break;
						}
					}
					return 0;
				default:
					return 0;
				}
				break;
			}
		}
	}

	private bool trySetMember(IntPtr luaState, IReflect targetType, object target, BindingFlags bindingType, out string detailMessage)
	{
		detailMessage = null;
		if (LuaDLL.lua_type(luaState, 2) != LuaTypes.LUA_TSTRING)
		{
			goto IL_0011;
		}
		goto IL_0172;
		IL_0011:
		int num = -246267759;
		goto IL_0016;
		IL_0016:
		string text = default(string);
		MemberInfo memberInfo = default(MemberInfo);
		MemberInfo[] array = default(MemberInfo[]);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -120933325)) % 17)
			{
			case 14u:
				break;
			case 9u:
			{
				int num5;
				int num6;
				if (_200E_200D_202B_206F_206E_206C_206E_202E_200E_206D_202B_200C_202D_206C_202C_206A_202E_202C_202E_206B_206D_202D_200E_206E_200F_206C_200D_200B_206C_202B_206B_200D_200C_202A_206B_206D_202E_200F_206B_202D_202E(text) >= 1)
				{
					num5 = -1622569507;
					num6 = num5;
				}
				else
				{
					num5 = -1633450913;
					num6 = num5;
				}
				num = num5 ^ ((int)num2 * -1474927994);
				continue;
			}
			case 15u:
				memberInfo = array[0];
				setMemberCache(memberCache, targetType, text, memberInfo);
				num = (int)(num2 * 141344400) ^ -1969734597;
				continue;
			case 2u:
				return false;
			case 1u:
				num = ((int)num2 * -891230205) ^ 0x4CBB6704;
				continue;
			case 7u:
				detailMessage = global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2143790201u);
				return false;
			case 12u:
				goto IL_00fa;
			case 8u:
				return false;
			case 5u:
				array = _202A_200F_202B_206B_200F_202C_206B_206F_206D_206E_206A_202E_200E_206A_206E_200B_200C_206D_206C_206F_206E_206A_200B_202E_206D_202A_200F_200C_202B_206A_200B_200E_206A_200F_202E_206D_206A_206D_200B_206F_202E(targetType, text, bindingType | BindingFlags.Public | BindingFlags.IgnoreCase);
				num = ((int)num2 * -763953980) ^ 0x2BE1442B;
				continue;
			case 16u:
			{
				int num9;
				int num10;
				if (char.IsLetter(_206C_206C_200D_202B_206F_200B_200E_206E_206A_206B_206F_202C_206D_200D_202D_200F_202B_202C_206A_202E_202C_206C_206A_200B_206D_200E_202A_202D_200C_200D_202E_200D_200B_206F_200C_202C_202A_202C_200B_202C_202E(text, 0)))
				{
					num9 = -1022102067;
					num10 = num9;
				}
				else
				{
					num9 = -1151121492;
					num10 = num9;
				}
				num = num9 ^ (int)(num2 * 1403443983);
				continue;
			}
			case 11u:
				goto IL_0172;
			case 4u:
			{
				int num7;
				int num8;
				if (_206C_206C_200D_202B_206F_200B_200E_206E_206A_206B_206F_202C_206D_200D_202D_200F_202B_202C_206A_202E_202C_206C_206A_200B_206D_200E_202A_202D_200C_200D_202E_200D_200B_206F_200C_202C_202A_202C_200B_202C_202E(text, 0) == '_')
				{
					num7 = -102269686;
					num8 = num7;
				}
				else
				{
					num7 = -1539254522;
					num8 = num7;
				}
				num = num7 ^ ((int)num2 * -1794813847);
				continue;
			}
			case 6u:
				detailMessage = global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3558245118u);
				num = (int)(num2 * 113214817) ^ -1171866261;
				continue;
			case 0u:
				goto IL_01d9;
			case 10u:
				detailMessage = _206B_206D_202E_202E_200D_206D_200B_202C_202C_206A_200C_202D_202A_200C_200D_206E_200F_206A_206D_202D_206B_202C_200E_202C_206E_200D_200F_206D_202C_206B_200D_200C_202B_206A_206B_206A_202C_206E_206E_200D_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1304194526u), text, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1947901463u));
				num = -1795500830;
				continue;
			case 3u:
			{
				int num3;
				int num4;
				if (array.Length <= 0)
				{
					num3 = -809873795;
					num4 = num3;
				}
				else
				{
					num3 = -1249849011;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 13940266);
				continue;
			}
			default:
			{
				FieldInfo fieldInfo = (FieldInfo)memberInfo;
				object asType = translator.getAsType(luaState, 3, _200D_200D_206E_202D_202D_200E_200C_206A_200C_206E_200D_206C_200C_206B_202C_200C_202B_206A_206A_200B_202E_202C_206E_206C_206C_206D_202B_206B_200F_206D_206F_206D_206A_200B_206B_206D_206F_202E_202B_200F_202E(fieldInfo));
				try
				{
					_202A_206E_202B_202A_200C_200C_206F_200E_202C_202B_200D_202C_202E_206E_202E_206C_200D_202B_202D_202E_200D_202C_202A_200E_200E_206A_200B_206D_202A_202D_206A_206C_202A_206C_200B_202C_202B_202A_200B_200E_202E(fieldInfo, target, asType);
				}
				catch (Exception e)
				{
					ThrowError(luaState, e);
				}
				return true;
			}
			}
			break;
			IL_01d9:
			memberInfo = (MemberInfo)checkMemberCache(memberCache, targetType, text);
			int num11;
			if (memberInfo != null)
			{
				num = -845691204;
				num11 = num;
			}
			else
			{
				num = -1806597001;
				num11 = num;
			}
			continue;
			IL_00fa:
			if (_206D_202E_206F_200F_200C_206C_206E_206B_200B_200E_202A_202D_200E_206A_200D_200C_200C_200E_200C_200C_202C_202E_206F_202C_200E_202C_200F_200F_206F_206A_206D_206A_206D_200C_202A_200B_206F_206A_206A_202B_202E(memberInfo) == MemberTypes.Field)
			{
				num = -1526312316;
				continue;
			}
			goto IL_02a7;
		}
		goto IL_0011;
		IL_0172:
		text = LuaDLL.lua_tostring(luaState, 2);
		int num12;
		if (text == null)
		{
			num = -2073185895;
			num12 = num;
		}
		else
		{
			num = -2049363502;
			num12 = num;
		}
		goto IL_0016;
		IL_02a7:
		while (_206D_202E_206F_200F_200C_206C_206E_206B_200B_200E_202A_202D_200E_206A_200D_200C_200C_200E_200C_200C_202C_202E_206F_202C_200E_202C_200F_200F_206F_206A_206D_206A_206D_200C_202A_200B_206F_206A_206A_202B_202E(memberInfo) == MemberTypes.Property)
		{
			int num13 = -1271463695;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num13 ^ -120933325)) % 3)
				{
				case 0u:
					goto IL_0284;
				case 2u:
					break;
				default:
				{
					PropertyInfo propertyInfo = (PropertyInfo)memberInfo;
					object asType2 = translator.getAsType(luaState, 3, _206B_200E_202E_206B_206E_202C_202B_200B_206E_200E_200E_202B_202B_202B_202A_200F_202A_202D_206F_202E_202D_206F_200C_202E_206F_200F_202E_202B_206E_206C_206B_202B_202C_202D_206F_202C_200E_202E_206A_200D_202E(propertyInfo));
					try
					{
						_200D_200B_206D_200B_202D_202D_206B_206E_202D_200C_202D_206F_206E_200D_206E_206B_202E_200B_202E_200D_206E_206B_202C_200D_206D_206A_200C_202E_200B_202A_200E_206F_200C_202E_200D_206E_206B_202B_200E_202B_202E(propertyInfo, target, asType2, (object[])null);
					}
					catch (Exception e2)
					{
						ThrowError(luaState, e2);
					}
					return true;
				}
				}
				break;
				IL_0284:
				num13 = -525275326;
			}
		}
		while (true)
		{
			detailMessage = _206B_206D_202E_202E_200D_206D_200B_202C_202C_206A_200C_202D_202A_200C_200D_206E_200F_206A_206D_202D_206B_202C_200E_202C_206E_200D_200F_206D_202C_206B_200D_200C_202B_206A_206B_206A_202C_206E_206E_200D_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(677732739u), text, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2018085227u));
			int num14 = -1464278104;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num14 ^ -120933325)) % 3)
				{
				case 0u:
					goto IL_02f2;
				case 2u:
					break;
				default:
					return false;
				}
				break;
				IL_02f2:
				num14 = -895184460;
			}
		}
	}

	private int setMember(IntPtr luaState, IReflect targetType, object target, BindingFlags bindingType)
	{
		if (!trySetMember(luaState, targetType, target, bindingType, out var detailMessage))
		{
			while (true)
			{
				int num = -131720136;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -775533439)) % 3)
					{
					case 0u:
						break;
					case 2u:
						translator.throwError(luaState, detailMessage);
						num = (int)((num2 * 579406128) ^ 0x4EEAC3A5);
						continue;
					default:
						goto end_IL_0011;
					}
					break;
				}
				continue;
				end_IL_0011:
				break;
			}
		}
		return 0;
	}

	private void ThrowError(IntPtr luaState, Exception e)
	{
		TargetInvocationException ex = e as TargetInvocationException;
		if (ex != null)
		{
			goto IL_000a;
		}
		goto IL_0047;
		IL_000a:
		int num = -2131751551;
		goto IL_000f;
		IL_000f:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -937657877)) % 4)
			{
			case 0u:
				break;
			default:
				return;
			case 2u:
				e = _202B_206F_200B_200F_206D_200F_206D_202B_200B_206A_200D_200C_202E_206B_206F_200E_202D_206D_206B_200D_202A_202C_206B_206E_200D_202E_202A_206E_206E_200E_200C_202C_200C_206F_200F_202A_206F_202B_206A_200F_202E((Exception)ex);
				num = ((int)num2 * -61432667) ^ 0x7D3A960E;
				continue;
			case 3u:
				goto IL_0047;
			case 1u:
				return;
			}
			break;
		}
		goto IL_000a;
		IL_0047:
		translator.throwError(luaState, _206D_200D_202B_206E_202C_206A_206F_200C_206E_202A_202D_200D_200D_206D_200F_202C_206B_206C_200B_206C_206E_206D_206B_202C_206D_202B_200E_202E_200D_200B_202A_206B_206F_206D_202E_206D_202B_202E_202D_200E_202E(e));
		num = -1090457022;
		goto IL_000f;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int getClassMethod(IntPtr luaState)
	{
		ObjectTranslator objectTranslator = ObjectTranslator.FromState(luaState);
		object rawNetObject = objectTranslator.getRawNetObject(luaState, 1);
		string text = default(string);
		IReflect reflect = default(IReflect);
		int num5 = default(int);
		while (true)
		{
			int num = 991324147;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x27883AD6)) % 14)
				{
				case 5u:
					break;
				case 8u:
				{
					text = LuaDLL.lua_tostring(luaState, 2);
					int num10;
					if (text != null)
					{
						num = 1214213607;
						num10 = num;
					}
					else
					{
						num = 344892416;
						num10 = num;
					}
					continue;
				}
				case 13u:
				{
					int num8;
					int num9;
					if (!LuaDLL.lua_isnumber(luaState, 2))
					{
						num8 = 1079927064;
						num9 = num8;
					}
					else
					{
						num8 = 891730181;
						num9 = num8;
					}
					num = num8 ^ (int)(num2 * 514988336);
					continue;
				}
				case 4u:
					objectTranslator.push(luaState, _206E_200C_206A_202B_200C_202A_200B_202B_200E_206F_202E_202C_202D_206A_202C_206B_200E_206C_202C_202A_200E_206D_202A_200E_202E_200F_206F_200C_202C_202D_206A_206C_200F_206C_206B_206A_202D_206E_206A_202B_202E(_200C_202E_206B_202D_200D_202C_200F_206F_206D_206E_202C_206A_206F_200B_206C_202E_200E_206C_200E_206A_202E_206F_202D_202E_200C_200C_202C_202E_206D_206C_200E_202C_206F_200B_206D_202E_200D_202D_206D_200D_202E(reflect), num5));
					num = (int)(num2 * 589200577) ^ -1958301811;
					continue;
				case 0u:
					return 1;
				case 9u:
					num5 = (int)LuaDLL.lua_tonumber(luaState, 2);
					num = (int)((num2 * 1208109550) ^ 0x317D35B2);
					continue;
				case 12u:
				{
					int num6;
					int num7;
					if (!(rawNetObject is IReflect))
					{
						num6 = -483850819;
						num7 = num6;
					}
					else
					{
						num6 = -1947391820;
						num7 = num6;
					}
					num = num6 ^ ((int)num2 * -1023235249);
					continue;
				}
				case 1u:
					objectTranslator.throwError(luaState, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1672595590u));
					LuaDLL.lua_pushnil(luaState);
					num = 261890816;
					continue;
				case 11u:
				{
					int num3;
					int num4;
					if (rawNetObject != null)
					{
						num3 = 1711636804;
						num4 = num3;
					}
					else
					{
						num3 = 1819072351;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -2056661214);
					continue;
				}
				case 10u:
					reflect = (IReflect)rawNetObject;
					num = 1406367639;
					continue;
				case 2u:
					return 1;
				case 6u:
					LuaDLL.lua_pushnil(luaState);
					num = (int)(num2 * 1924975986) ^ -1142952212;
					continue;
				case 3u:
					return 1;
				default:
					return objectTranslator.metaFunctions.getMember(luaState, reflect, null, text, BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.FlattenHierarchy);
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int setClassFieldOrProperty(IntPtr luaState)
	{
		ObjectTranslator objectTranslator = ObjectTranslator.FromState(luaState);
		object rawNetObject = default(object);
		while (true)
		{
			int num = -1445445043;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1418390536)) % 6)
				{
				case 0u:
					break;
				case 5u:
					rawNetObject = objectTranslator.getRawNetObject(luaState, 1);
					num = (int)(num2 * 1735734756) ^ -1628450163;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (rawNetObject == null)
					{
						num5 = -303314654;
						num6 = num5;
					}
					else
					{
						num5 = -1752647289;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1172202572);
					continue;
				}
				case 2u:
					objectTranslator.throwError(luaState, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(109310928u));
					return 0;
				case 1u:
				{
					int num3;
					int num4;
					if (!(rawNetObject is IReflect))
					{
						num3 = -1710222834;
						num4 = num3;
					}
					else
					{
						num3 = -1326301282;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1488712160);
					continue;
				}
				default:
				{
					IReflect targetType = (IReflect)rawNetObject;
					return objectTranslator.metaFunctions.setMember(luaState, targetType, null, BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.FlattenHierarchy);
				}
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int callConstructor(IntPtr luaState)
	{
		ObjectTranslator objectTranslator = ObjectTranslator.FromState(luaState);
		MethodCache methodCache = default(MethodCache);
		object rawNetObject = objectTranslator.getRawNetObject(luaState, 1);
		if (rawNetObject != null)
		{
			goto IL_001e;
		}
		goto IL_00d0;
		IL_001e:
		int num = 1322267701;
		goto IL_0023;
		IL_0023:
		int num5 = default(int);
		IReflect reflect = default(IReflect);
		ConstructorInfo[] array = default(ConstructorInfo[]);
		ConstructorInfo constructorInfo = default(ConstructorInfo);
		ConstructorInfo[] array2 = default(ConstructorInfo[]);
		bool flag = default(bool);
		string text2 = default(string);
		while (true)
		{
			int num6;
			uint num2;
			switch ((num2 = (uint)(num ^ 0x4B955405)) % 11)
			{
			case 4u:
				break;
			case 3u:
			{
				int num7;
				int num8;
				if (!(rawNetObject is IReflect))
				{
					num7 = -1130893711;
					num8 = num7;
				}
				else
				{
					num7 = -566211769;
					num8 = num7;
				}
				num = num7 ^ (int)(num2 * 368568949);
				continue;
			}
			case 6u:
				num5 = 0;
				num = (int)((num2 * 230971564) ^ 0x4FE10CE2);
				continue;
			case 9u:
				reflect = (IReflect)rawNetObject;
				LuaDLL.lua_remove(luaState, 1);
				array = _200D_200B_200C_202E_206E_206A_200F_200B_200C_202E_202C_200B_200D_206E_206E_206B_206F_206E_200E_206A_200E_200C_200B_200D_202B_206D_200F_206D_206C_206F_206B_200B_206E_202B_206D_202C_202C_202E_206D_202B_202E(_200C_202E_206B_202D_200D_202C_200F_206F_206D_206E_202C_206A_206F_200B_206C_202E_200E_206C_200E_206A_202E_206F_202D_202E_200C_200C_202C_202E_206D_206C_200E_202C_206F_200B_206D_202E_200D_202D_206D_200D_202E(reflect));
				num = 422751373;
				continue;
			case 2u:
				constructorInfo = array2[num5];
				num = 1311298832;
				continue;
			case 1u:
				goto IL_00d0;
			case 0u:
				flag = objectTranslator.metaFunctions.matchParameters(luaState, constructorInfo, ref methodCache);
				num = (int)(num2 * 935099946) ^ -618446832;
				continue;
			case 10u:
				array2 = array;
				num = ((int)num2 * -1700150057) ^ -1422856823;
				continue;
			case 7u:
				LuaDLL.lua_pushnil(luaState);
				return 1;
			default:
				if (flag)
				{
					try
					{
						objectTranslator.push(luaState, _202C_200B_206F_202A_200B_200E_202C_202A_202E_206C_202B_200B_206E_206D_200C_200E_206F_200C_200D_200E_202C_200F_202A_206C_200B_206A_200D_206D_206F_200E_202C_206C_200D_206C_200B_200F_206E_206A_206B_202A_202E(constructorInfo, methodCache.args));
					}
					catch (TargetInvocationException e)
					{
						while (true)
						{
							IL_017c:
							int num3 = 423815415;
							while (true)
							{
								switch ((num2 = (uint)(num3 ^ 0x4B955405)) % 3)
								{
								case 2u:
									break;
								case 1u:
									goto IL_019f;
								default:
									LuaDLL.lua_pushnil(luaState);
									goto end_IL_0181;
								}
								goto IL_017c;
								IL_019f:
								objectTranslator.metaFunctions.ThrowError(luaState, e);
								num3 = (int)((num2 * 880946013) ^ 0x1B2BD7AB);
								continue;
								end_IL_0181:
								break;
							}
							break;
						}
					}
					catch
					{
						while (true)
						{
							IL_01c6:
							int num4 = 156159326;
							while (true)
							{
								switch ((num2 = (uint)(num4 ^ 0x4B955405)) % 3)
								{
								case 2u:
									break;
								default:
									goto end_IL_01cb;
								case 1u:
									goto IL_01e9;
								case 0u:
									goto end_IL_01cb;
								}
								goto IL_01c6;
								IL_01e9:
								LuaDLL.lua_pushnil(luaState);
								num4 = ((int)num2 * -262929367) ^ -1166584487;
								continue;
								end_IL_01cb:
								break;
							}
							break;
						}
					}
					return 1;
				}
				goto IL_0299;
			case 5u:
				{
					if (num5 < array2.Length)
					{
						goto case 2u;
					}
					num6 = 1147501943;
					goto IL_0208;
				}
				IL_0299:
				num5++;
				num6 = 1869486634;
				goto IL_0208;
				IL_0208:
				while (true)
				{
					string text;
					switch ((num2 = (uint)(num6 ^ 0x4B955405)) % 7)
					{
					case 5u:
						num6 = 176611096;
						continue;
					case 0u:
						LuaDLL.luaL_error(luaState, _200C_206F_202C_206D_200C_202C_202C_206C_206C_202C_200C_200E_202A_206C_206D_202B_206E_200D_206D_202D_202A_200E_206D_200C_202A_206F_200F_202B_200F_202E_206B_206D_202A_202B_206C_200C_206B_206B_206E_206F_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1693333400u), (object)_200C_202E_206B_202D_200D_202C_200F_206F_206D_206E_202C_206A_206F_200B_206C_202E_200E_206C_200E_206A_202E_206F_202D_202E_200C_200C_202C_202E_206D_206C_200E_202C_206F_200B_206D_202E_200D_202D_206D_200D_202E(reflect), (object)text2));
						num6 = ((int)num2 * -783647185) ^ -687161328;
						continue;
					case 1u:
						break;
					case 4u:
						text = global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2493291032u);
						goto IL_028d;
					case 2u:
						goto IL_0299;
					case 3u:
						if (array.Length != 0)
						{
							text = _206E_206F_200B_206C_206C_200C_206C_200B_202C_206D_206A_200F_206B_200E_202B_200D_202A_206E_202C_206A_206E_206E_206B_200F_200F_206B_202E_206D_206F_206D_202C_202D_202D_200E_202E_200C_206D_206F_206A_206E_202E((MemberInfo)array[0]);
							goto IL_028d;
						}
						num6 = (int)(num2 * 755260397) ^ -363789922;
						continue;
					default:
						{
							LuaDLL.lua_pushnil(luaState);
							return 1;
						}
						IL_028d:
						text2 = text;
						num6 = 1610806494;
						continue;
					}
					break;
				}
				goto case 5u;
			}
			break;
		}
		goto IL_001e;
		IL_00d0:
		LuaDLL.luaL_error(luaState, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(649816338u));
		num = 561516880;
		goto IL_0023;
	}

	private static bool IsInteger(double x)
	{
		return _202C_202A_200F_200C_206C_202A_202A_206B_200B_200C_202A_206F_202A_206A_202B_202A_202B_206E_200E_206A_206B_200C_206D_200B_206A_202A_206B_206B_202C_200E_200F_202B_206E_206F_200B_200C_202E_206B_206A_200F_202E(x) == x;
	}

	internal Array TableToArray(object luaParamValue, Type paramArrayType)
	{
		if (luaParamValue is LuaTable)
		{
			goto IL_000b;
		}
		goto IL_00e7;
		IL_000b:
		int num = 2021591103;
		goto IL_0010;
		IL_0010:
		object obj = default(object);
		int num9 = default(int);
		IDictionaryEnumerator enumerator = default(IDictionaryEnumerator);
		LuaTable luaTable = default(LuaTable);
		Array array = default(Array);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x2D7A698B)) % 16)
			{
			case 11u:
				break;
			case 3u:
				goto IL_0066;
			case 9u:
			{
				int num7;
				int num8;
				if (_202A_200C_200B_200B_200E_202D_206F_200D_200E_206D_200B_200B_200E_206E_206A_200D_202E_200B_206D_200E_206B_202C_202B_206A_206F_202C_200E_206B_200B_206D_202C_202A_202D_200E_200C_202C_206F_206F_200D_200D_202E(obj) == _206D_206C_200E_200E_206E_200C_206A_202A_202B_206D_200B_200F_202B_206E_202C_200C_206E_206A_206B_200C_206E_202D_200B_206B_202C_202C_200D_200C_200C_202D_206F_206F_202E_200C_202D_202A_200F_206D_200C_206D_202E(typeof(double).TypeHandle))
				{
					num7 = -452912341;
					num8 = num7;
				}
				else
				{
					num7 = -1088136751;
					num8 = num7;
				}
				num = num7 ^ (int)(num2 * 1240396962);
				continue;
			}
			case 2u:
			{
				int num5;
				int num6;
				if (!IsInteger((double)obj))
				{
					num5 = -1252614597;
					num6 = num5;
				}
				else
				{
					num5 = -1603415793;
					num6 = num5;
				}
				num = num5 ^ ((int)num2 * -1155099764);
				continue;
			}
			case 0u:
				goto IL_00e7;
			case 12u:
				obj = _200F_202B_206A_202A_200C_206F_206B_206A_202A_200C_202C_206F_200E_202D_200C_200C_200F_200C_202A_202E_200D_206F_206D_206A_206B_202A_206E_206D_200B_206A_206B_202A_206E_206C_206B_206B_206B_206A_202A_202B_202E((double)obj);
				num = (int)((num2 * 1600083557) ^ 0x37CC6AF);
				continue;
			case 15u:
				num = (int)((num2 * 2045734014) ^ 0x38A8C44E);
				continue;
			case 10u:
				num9++;
				num = ((int)num2 * -1937951998) ^ 0x51AD8742;
				continue;
			case 5u:
				enumerator = luaTable.GetEnumerator();
				_200E_206D_200D_206D_202B_206F_202A_200B_206F_206B_200D_202D_202D_200B_206E_200D_206B_206C_202A_206B_202B_206B_202C_206C_202E_206F_200F_202B_200E_202B_202A_200E_200B_200B_206A_206D_200C_202E_206E_200F_202E((IEnumerator)enumerator);
				array = _206E_200C_206A_202B_200C_202A_200B_202B_200E_206F_202E_202C_202D_206A_202C_206B_200E_206C_202C_202A_200E_206D_202A_200E_202E_200F_206F_200C_202C_202D_206A_206C_200F_206C_206B_206A_202D_206E_206A_202B_202E(paramArrayType, _202B_206C_206F_202B_206C_206A_202B_200F_206E_200E_202A_206D_200E_206E_202B_206C_206F_206A_206A_206B_202D_206C_202B_206D_202C_206C_202B_202D_202D_202C_206B_206B_206C_202C_206B_202C_206B_206F_200E_200F_202E(luaTable.Values));
				num = (int)((num2 * 543596073) ^ 0x33B410B8);
				continue;
			case 4u:
				luaTable = (LuaTable)luaParamValue;
				num = ((int)num2 * -193189541) ^ -1589569310;
				continue;
			case 8u:
				_206A_200B_206F_206A_206E_206C_202D_202C_206B_206A_202D_200E_200E_200C_206E_206A_202B_206F_206D_202E_206E_202A_200F_206E_206B_200F_202B_202C_206B_200C_200B_200D_202C_206A_206D_202E_200D_200D_202C_202B_202E(array, _202C_206E_202D_202E_202E_206A_206E_206B_206B_200F_202C_202A_206C_206B_206E_206B_200C_206A_206E_200F_206F_202C_200D_206C_206A_202A_200C_206D_200E_200F_206C_206A_206D_206D_206B_202A_206A_206D_200F_202E_202E(obj, paramArrayType), num9);
				num = 817510113;
				continue;
			case 6u:
				num = (int)(num2 * 574625899) ^ -1444885388;
				continue;
			case 14u:
				num9 = 0;
				num = ((int)num2 * -789349911) ^ -551503309;
				continue;
			case 13u:
				goto IL_01de;
			case 1u:
			{
				int num3;
				int num4;
				if (obj == null)
				{
					num3 = 1194132538;
					num4 = num3;
				}
				else
				{
					num3 = 1608885787;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -716078903);
				continue;
			}
			default:
				return array;
			}
			break;
			IL_01de:
			int num10;
			if (!_202C_202A_206C_202A_202C_206C_206D_200C_206B_206B_200E_202C_200E_202D_206A_202B_200B_200D_200E_200B_206F_206D_206B_206E_200B_200D_206E_206E_202B_206C_202D_206A_200E_200E_200F_206F_206D_200B_202B_206A_202E((IEnumerator)enumerator))
			{
				num = 1709587876;
				num10 = num;
			}
			else
			{
				num = 611403576;
				num10 = num;
			}
			continue;
			IL_0066:
			obj = _202E_202E_202E_202B_202B_202C_206A_206E_206C_200E_202C_202E_206C_202A_206A_202E_206F_206C_206B_202A_200C_200E_206A_206D_202A_202A_206D_202B_202B_202A_206B_202B_202C_206E_206D_206F_200D_200F_206F_200F_202E(enumerator);
			int num11;
			if (paramArrayType != _206D_206C_200E_200E_206E_200C_206A_202A_202B_206D_200B_200F_202B_206E_202C_200C_206E_206A_206B_200C_206E_202D_200B_206B_202C_202C_200D_200C_200C_202D_206F_206F_202E_200C_202D_202A_200F_206D_200C_206D_202E(typeof(object).TypeHandle))
			{
				num = 671448035;
				num11 = num;
			}
			else
			{
				num = 928347930;
				num11 = num;
			}
		}
		goto IL_000b;
		IL_00e7:
		array = _206E_200C_206A_202B_200C_202A_200B_202B_200E_206F_202E_202C_202D_206A_202C_206B_200E_206C_202C_202A_200E_206D_202A_200E_202E_200F_206F_200C_202C_202D_206A_206C_200F_206C_206B_206A_202D_206E_206A_202B_202E(paramArrayType, 1);
		_206A_200B_206F_206A_206E_206C_202D_202C_206B_206A_202D_200E_200E_200C_206E_206A_202B_206F_206D_202E_206E_202A_200F_206E_206B_200F_202B_202C_206B_200C_200B_200D_202C_206A_206D_202E_200D_200D_202C_202B_202E(array, luaParamValue, 0);
		num = 1207863148;
		goto IL_0010;
	}

	internal bool matchParameters(IntPtr luaState, MethodBase method, ref MethodCache methodCache)
	{
		bool flag = true;
		ParameterInfo[] array = _206A_202B_206B_206D_206C_200E_200B_200F_200E_200E_202D_206C_200C_200C_202C_200E_200B_202E_200E_206C_202B_200C_206C_200B_206A_206C_202E_206F_202A_206C_200B_200F_202A_206C_202A_206E_200E_200F_200C_206B_202E(method);
		int num = 1;
		int num2 = LuaDLL.lua_gettop(luaState);
		ParameterInfo parameterInfo = default(ParameterInfo);
		ExtractValue extractValue = default(ExtractValue);
		MethodArgs item2 = default(MethodArgs);
		MethodArgs item = default(MethodArgs);
		Type type = default(Type);
		ArrayList arrayList = default(ArrayList);
		List<int> list2 = default(List<int>);
		int num11 = default(int);
		ParameterInfo[] array2 = default(ParameterInfo[]);
		int num12 = default(int);
		object luaParamValue = default(object);
		int index = default(int);
		List<MethodArgs> list = default(List<MethodArgs>);
		while (true)
		{
			int num3 = 845603288;
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)(num3 ^ 0x225B2E55)) % 48)
				{
				case 27u:
					break;
				case 40u:
				{
					int num21;
					if (_202B_202B_206E_206F_202B_200E_206A_202C_202D_202A_200F_200E_200F_200F_202A_200E_200B_206C_200D_206B_206F_202B_200D_206D_202E_202C_206D_206D_206B_206B_200D_206B_200D_202B_200E_200E_202A_206F_202C_200F_202E(luaState, num, parameterInfo, out extractValue))
					{
						num3 = 1253172070;
						num21 = num3;
					}
					else
					{
						num3 = 6390979;
						num21 = num3;
					}
					continue;
				}
				case 8u:
					num3 = (int)(num4 * 1330631165) ^ -809409860;
					continue;
				case 4u:
				{
					int num16;
					int num17;
					if (_206D_202D_200F_200C_206F_202D_202C_202C_202E_200F_206D_200C_200C_206F_200D_202B_206C_202A_206A_206E_200D_200C_206E_206C_200D_200C_202A_206E_200C_206D_202C_200F_206D_206D_200E_200E_206E_206B_206E_202E(_206E_200B_206F_206F_200B_206E_200E_200B_206D_202B_202D_206F_202E_206D_206E_202E_200E_202A_206B_206C_202D_200C_200F_206C_206A_200C_206B_202A_206D_200D_206B_200C_206C_206E_206B_206C_200C_200C_202C_206E_202E(parameterInfo)))
					{
						num16 = 1953630058;
						num17 = num16;
					}
					else
					{
						num16 = 1481893811;
						num17 = num16;
					}
					num3 = num16 ^ (int)(num4 * 518993450);
					continue;
				}
				case 15u:
					num3 = (int)(num4 * 1235872458) ^ -1776320797;
					continue;
				case 7u:
					item2.isParamsArray = true;
					num3 = (int)(num4 * 878124919) ^ -553111219;
					continue;
				case 36u:
					item.extractValue = extractValue;
					num3 = ((int)num4 * -153803934) ^ -888826204;
					continue;
				case 25u:
					item2.paramsArrayType = type;
					num3 = (int)((num4 * 576817908) ^ 0x6ED2615D);
					continue;
				case 38u:
					item = default(MethodArgs);
					num3 = (int)(num4 * 567503856) ^ -1351712446;
					continue;
				case 22u:
				{
					int num19;
					if (_206E_200F_200B_202A_200E_202C_206D_200D_206A_202E_206F_206B_200D_206B_202A_202C_200D_202C_200E_206A_200F_206A_200B_202E_206C_202C_200E_200C_200E_202C_200C_206C_202C_202D_200D_202C_200D_206B_200B_202D_202E(luaState, num, parameterInfo, out extractValue))
					{
						num3 = 1044468662;
						num19 = num3;
					}
					else
					{
						num3 = 2054884609;
						num19 = num3;
					}
					continue;
				}
				case 20u:
				{
					int num14;
					if (_206D_206F_206B_200E_206B_202D_202B_202A_206E_200F_206F_202E_202A_206F_200F_206F_202D_206C_202C_200F_206E_202E_200D_200E_200E_200C_202C_202A_206F_206E_200F_206D_200C_206B_206D_206C_200C_202E_202D_200D_202E(parameterInfo))
					{
						num3 = 2063891479;
						num14 = num3;
					}
					else
					{
						num3 = 2022399863;
						num14 = num3;
					}
					continue;
				}
				case 2u:
					_202E_202E_202B_202C_200B_206D_202E_206A_200C_202B_202C_202A_202B_202C_200B_200D_200D_202B_200C_200D_200C_202B_200E_202B_202B_202B_202A_202A_206F_206E_202C_200F_206C_200D_202B_202C_206D_200E_206E_200C_202E(arrayList, _206D_206D_202D_206F_202E_200C_200F_206C_206B_206E_200B_200C_202D_206E_206C_202D_200C_202D_200B_206F_202C_206F_206F_206A_200B_202B_202E_206E_206A_202B_202C_206D_200B_206E_206A_206B_206C_206A_202D_206A_202E(parameterInfo));
					num3 = (int)(num4 * 75799240) ^ -1128084771;
					continue;
				case 23u:
					list2.Add(num11);
					num3 = (int)(num4 * 1652135617) ^ -1330742452;
					continue;
				case 34u:
					flag = false;
					num3 = 1664906315;
					continue;
				case 35u:
				{
					int num7;
					int num8;
					if (_200E_200F_200B_200D_206F_206C_206A_206D_206C_200B_206F_206D_200E_206E_206E_200D_202B_202E_206F_200F_206A_200B_206E_206B_202D_206F_202C_202C_202E_202B_206D_202E_206E_202C_202D_200B_206F_200D_206E_200E_202E(parameterInfo))
					{
						num7 = -964372516;
						num8 = num7;
					}
					else
					{
						num7 = -1313577470;
						num8 = num7;
					}
					num3 = num7 ^ (int)(num4 * 1624259046);
					continue;
				}
				case 14u:
					item2 = default(MethodArgs);
					num3 = (int)(num4 * 1420286845) ^ -518119121;
					continue;
				case 16u:
					parameterInfo = array2[num12];
					num3 = 1000433526;
					continue;
				case 26u:
				{
					int num20;
					if (!flag)
					{
						num3 = 606154759;
						num20 = num3;
					}
					else
					{
						num3 = 1146456730;
						num20 = num3;
					}
					continue;
				}
				case 47u:
					_202E_202E_202B_202C_200B_206D_202E_206A_200C_202B_202C_202A_202B_202C_200B_200D_200D_202B_200C_200D_200C_202B_200E_202B_202B_202B_202A_202A_206F_206E_202C_200F_206C_200D_202B_202C_206D_200E_206E_200C_202E(arrayList, _206D_206D_202D_206F_202E_200C_200F_206C_206B_206E_200B_200C_202D_206E_206C_202D_200C_202D_200B_206F_202C_206F_206F_206A_200B_202B_202E_206E_206A_202B_202C_206D_200B_206E_206A_206B_206C_206A_202D_206A_202E(parameterInfo));
					num3 = (int)((num4 * 2105889555) ^ 0xFE38C68);
					continue;
				case 46u:
					num++;
					num3 = 1662206016;
					continue;
				case 32u:
				case 33u:
					num12++;
					num3 = 119263765;
					continue;
				case 39u:
					item.index = num11;
					num3 = ((int)num4 * -609231900) ^ 0x478EA95D;
					continue;
				case 9u:
					flag = false;
					num3 = 667033328;
					continue;
				case 31u:
					methodCache.args = _200F_200E_202C_206C_206D_202E_206E_206C_206F_202B_200E_206A_202A_206E_202E_202A_200F_206A_206E_202D_202D_206A_202A_206B_206A_202B_200C_206D_200B_206D_202A_200C_200D_202A_206D_202E_200D_206C_202C_200F_202E(arrayList);
					num3 = ((int)num4 * -971666546) ^ 0x46AAE9AF;
					continue;
				case 19u:
					luaParamValue = extractValue(luaState, num);
					num3 = (int)(num4 * 87687784) ^ -287860447;
					continue;
				case 13u:
					flag = false;
					num3 = (int)((num4 * 813547334) ^ 0x21EE5A81);
					continue;
				case 5u:
				{
					int num18;
					if (num != num2 + 1)
					{
						num3 = 1941571896;
						num18 = num3;
					}
					else
					{
						num3 = 836386895;
						num18 = num3;
					}
					continue;
				}
				case 28u:
					item2.index = index;
					item2.extractValue = extractValue;
					num3 = ((int)num4 * -894451613) ^ 0x676BD336;
					continue;
				case 12u:
				{
					type = _200D_202B_202B_206B_202B_206E_206B_206A_206A_206A_206B_200E_202E_206D_206D_206D_202C_200B_200E_200F_200F_206D_200F_206F_206B_206D_202B_202C_200F_202A_200C_202B_202B_206B_200B_200B_202D_200D_202D_200D_202E(_206E_200B_206F_206F_200B_206E_200E_200B_206D_202B_202D_206F_202E_206D_206E_202E_200E_202A_206B_206C_202D_200C_200F_206C_206A_200C_206B_202A_206D_200D_206B_200C_206C_206E_206B_206C_200C_200C_202C_206E_202E(parameterInfo));
					Array array3 = TableToArray(luaParamValue, type);
					index = _202E_202E_202B_202C_200B_206D_202E_206A_200C_202B_202C_202A_202B_202C_200B_200D_200D_202B_200C_200D_200C_202B_200E_202B_202B_202B_202A_202A_206F_206E_202C_200F_206C_200D_202B_202C_206D_200E_206E_200C_202E(arrayList, (object)array3);
					num3 = ((int)num4 * -5672388) ^ 0xBA27DAB;
					continue;
				}
				case 42u:
					num3 = (int)((num4 * 1957266498) ^ 0x3CB386B0);
					continue;
				case 6u:
					list2.Add(_202E_202E_202B_202C_200B_206D_202E_206A_200C_202B_202C_202A_202B_202C_200B_200D_200D_202B_200C_200D_200C_202B_200E_202B_202B_202B_202A_202A_206F_206E_202C_200F_206C_200D_202B_202C_206D_200E_206E_200C_202E(arrayList, (object)null));
					num3 = (int)(num4 * 1285247195) ^ -1547201370;
					continue;
				case 11u:
				{
					int num15;
					if (num > num2)
					{
						num3 = 935981582;
						num15 = num3;
					}
					else
					{
						num3 = 762957245;
						num15 = num3;
					}
					continue;
				}
				case 45u:
					num12 = 0;
					num3 = (int)(num4 * 445503833) ^ -1175333137;
					continue;
				case 24u:
					methodCache.cachedMethod = method;
					methodCache.outList = list2.ToArray();
					methodCache.argTypes = list.ToArray();
					num3 = ((int)num4 * -305315033) ^ -117602785;
					continue;
				case 10u:
					array2 = array;
					num3 = (int)(num4 * 390966251) ^ -1113297930;
					continue;
				case 30u:
					num3 = (int)(num4 * 617541295) ^ -1605345166;
					continue;
				case 37u:
					num3 = (int)((num4 * 30251706) ^ 0x5C838946);
					continue;
				case 44u:
					list.Add(item2);
					num++;
					num3 = (int)(num4 * 2025401095) ^ -430638517;
					continue;
				case 0u:
				{
					int num13;
					if (num12 >= array2.Length)
					{
						num3 = 667033328;
						num13 = num3;
					}
					else
					{
						num3 = 65852469;
						num13 = num3;
					}
					continue;
				}
				case 1u:
					list2 = new List<int>();
					list = new List<MethodArgs>();
					num3 = ((int)num4 * -1047785720) ^ -2136319817;
					continue;
				case 3u:
					num11 = _202E_202E_202B_202C_200B_206D_202E_206A_200C_202B_202C_202A_202B_202C_200B_200D_200D_202B_200C_200D_200C_202B_200E_202B_202B_202B_202A_202A_206F_206E_202C_200F_206C_200D_202B_202C_206D_200E_206E_200C_202E(arrayList, extractValue(luaState, num));
					num3 = (int)(num4 * 215388964) ^ -943757809;
					continue;
				case 17u:
					num3 = (int)(num4 * 577130829) ^ -205557447;
					continue;
				case 21u:
				{
					int num9;
					int num10;
					if (!_202A_202D_206E_200D_200F_206A_206F_202E_202D_206E_206D_206A_200B_202C_200B_202B_202C_206F_206F_202C_206F_202B_202E_206B_200D_202E_202A_202C_206A_202B_200E_200B_200D_206D_206E_200D_206B_202C_200F_200D_202E(parameterInfo))
					{
						num9 = -1259207271;
						num10 = num9;
					}
					else
					{
						num9 = -209546748;
						num10 = num9;
					}
					num3 = num9 ^ (int)(num4 * 2015667243);
					continue;
				}
				case 43u:
				{
					int num5;
					int num6;
					if (!_206D_206F_206B_200E_206B_202D_202B_202A_206E_200F_206F_202E_202A_206F_200F_206F_202D_206C_202C_200F_206E_202E_200D_200E_200E_200C_202C_202A_206F_206E_200F_206D_200C_206B_206D_206C_200C_202E_202D_200D_202E(parameterInfo))
					{
						num5 = 1786823959;
						num6 = num5;
					}
					else
					{
						num5 = 858961313;
						num6 = num5;
					}
					num3 = num5 ^ ((int)num4 * -2136554991);
					continue;
				}
				case 41u:
					list.Add(item);
					num3 = (int)(num4 * 1659688318) ^ -1331620465;
					continue;
				case 29u:
					arrayList = _200C_202E_200B_200D_200B_202C_200F_202C_202A_206D_202D_202A_202D_200E_206A_200D_200C_206A_206B_206B_200B_206F_202D_206F_206C_206B_202D_206D_200C_202C_202B_202E_200F_202C_202C_206A_200B_200E_206F_206E_202E();
					num3 = ((int)num4 * -368048035) ^ -937549523;
					continue;
				default:
					return flag;
				}
				break;
			}
		}
	}

	private bool _202B_202B_206E_206F_202B_200E_206A_202C_202D_202A_200F_200E_200F_200F_202A_200E_200B_206C_200D_206B_206F_202B_200D_206D_202E_202C_206D_206D_206B_206B_200D_206B_200D_202B_200E_200E_202A_206F_202C_200F_202E(IntPtr P_0, int P_1, ParameterInfo P_2, out ExtractValue P_3)
	{
		bool result = default(bool);
		try
		{
			result = (P_3 = translator.typeChecker.checkType(P_0, P_1, _206E_200B_206F_206F_200B_206E_200E_200B_206D_202B_202D_206F_202E_206D_206E_202E_200E_202A_206B_206C_202D_200C_200F_206C_206A_200C_206B_202A_206D_200D_206B_200C_206C_206E_206B_206C_200C_200C_202C_206E_202E(P_2))) != null;
		}
		catch
		{
			while (true)
			{
				IL_002a:
				int num = 273324768;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x7ADD9E09)) % 5)
					{
					case 0u:
						break;
					default:
						goto end_IL_002f;
					case 2u:
						goto end_IL_002f;
					case 1u:
						result = false;
						num = (int)(num2 * 36410624) ^ -1261851455;
						continue;
					case 4u:
						P_3 = null;
						num = ((int)num2 * -1715065680) ^ 0x3C61568A;
						continue;
					case 3u:
						goto end_IL_002f;
					}
					goto IL_002a;
					continue;
					end_IL_002f:
					break;
				}
				break;
			}
		}
		return result;
	}

	private bool _206E_200F_200B_202A_200E_202C_206D_200D_206A_202E_206F_206B_200D_206B_202A_202C_200D_202C_200E_206A_200F_206A_200B_202E_206C_202C_200E_200C_200E_202C_200C_206C_202C_202D_200D_202C_200D_206B_200B_202D_202E(IntPtr P_0, int P_1, ParameterInfo P_2, out ExtractValue P_3)
	{
		P_3 = null;
		bool result = default(bool);
		if (_206D_200F_202A_206E_200C_206A_206D_206F_206D_202B_206C_202A_206D_206C_206E_206A_206B_202B_200E_206D_206C_202E_206A_200F_200B_206A_206E_206C_206B_206C_200E_202D_202B_202A_206B_206E_200E_200B_200E_200D_202E(P_2, _206D_206C_200E_200E_206E_200C_206A_202A_202B_206D_200B_200F_202B_206E_202C_200C_206E_206A_206B_200C_206E_202D_200B_206B_202C_202C_200D_200C_200C_202D_206F_206F_202E_200C_202D_202A_200F_206D_200C_206D_202E(typeof(ParamArrayAttribute).TypeHandle), false).Length > 0)
		{
			LuaTypes luaTypes = default(LuaTypes);
			try
			{
				luaTypes = LuaDLL.lua_type(P_0, P_1);
			}
			catch (Exception)
			{
				P_3 = null;
				while (true)
				{
					IL_002c:
					int num = 750003582;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ 0x2DED31AC)) % 4)
						{
						case 0u:
							break;
						default:
							goto end_IL_0031;
						case 2u:
							goto IL_0053;
						case 3u:
							goto end_IL_0031;
						case 1u:
							goto IL_0159;
						}
						goto IL_002c;
						IL_0053:
						result = false;
						num = ((int)num2 * -1570611730) ^ 0x1CB4FD21;
						continue;
						end_IL_0031:
						break;
					}
					break;
				}
			}
			if (luaTypes == LuaTypes.LUA_TTABLE)
			{
				try
				{
					P_3 = translator.typeChecker.getExtractor(_206D_206C_200E_200E_206E_200C_206A_202A_202B_206D_200B_200F_202B_206E_202C_200C_206E_206A_206B_200C_206E_202D_200B_206B_202C_202C_200D_200C_200C_202D_206F_206F_202E_200C_202D_202A_200F_206D_200C_206D_202E(typeof(LuaTable).TypeHandle));
				}
				catch (Exception)
				{
				}
				if (P_3 == null)
				{
					goto IL_0150;
				}
				while (true)
				{
					uint num2;
					switch ((num2 = 1938856709u) % 4)
					{
					case 3u:
						break;
					case 1u:
						return true;
					default:
						goto end_IL_00a8;
					case 2u:
						goto IL_0150;
					}
					continue;
					end_IL_00a8:
					break;
				}
			}
			Type paramType = _200D_202B_202B_206B_202B_206E_206B_206A_206A_206A_206B_200E_202E_206D_206D_206D_202C_200B_200E_200F_200F_206D_200F_206F_206B_206D_202B_202C_200F_202A_200C_202B_202B_206B_200B_200B_202D_200D_202D_200D_202E(_206E_200B_206F_206F_200B_206E_200E_200B_206D_202B_202D_206F_202E_206D_206E_202E_200E_202A_206B_206C_202D_200C_200F_206C_206A_200C_206B_202A_206D_200D_206B_200C_206C_206E_206B_206C_200C_200C_202C_206E_202E(P_2));
			try
			{
				P_3 = translator.typeChecker.checkType(P_0, P_1, paramType);
			}
			catch (Exception)
			{
			}
			if (P_3 != null)
			{
				while (true)
				{
					uint num2;
					switch ((num2 = 1576373959u) % 4)
					{
					case 0u:
						break;
					case 3u:
						return true;
					case 1u:
						goto end_IL_0117;
					default:
						goto IL_0159;
					}
					continue;
					end_IL_0117:
					break;
				}
			}
		}
		goto IL_0150;
		IL_0159:
		return result;
		IL_0150:
		return false;
	}

	static Hashtable _202E_200B_200E_202A_200D_200D_202E_200F_202E_200F_200E_206A_200E_206A_206C_206E_202C_200D_200F_206E_206C_202E_200F_206E_200F_206B_202D_202C_202B_200C_202B_206B_206A_202A_200B_200C_202A_200E_200B_206A_202E()
	{
		return new Hashtable();
	}

	static string _202D_206D_202B_202D_200D_200D_206B_206F_206D_200C_202E_206C_206C_202D_202A_200F_202D_200B_206C_206C_206F_202E_206F_200E_206D_200B_206D_202D_200D_206F_206C_206B_206C_206C_202C_206B_206A_206A_206E_202D_202E(object P_0)
	{
		return P_0.ToString();
	}

	static int _200D_202A_200C_206D_202B_206A_200D_202A_206C_202E_200F_200C_200C_206A_200B_202C_206F_202B_202E_200D_200B_206D_200D_200B_202D_202C_202A_200B_202E_202C_206C_206F_202C_200E_200D_206B_200B_200D_206F_206B_202E(object P_0)
	{
		return P_0.GetHashCode();
	}

	static string _206E_206F_202D_200F_200B_206D_202A_206B_200C_202A_206A_200B_200F_206E_206A_202D_206B_206F_200D_202D_200B_202B_206D_206D_206B_206A_202B_202E_200E_202D_202C_200D_202E_202A_206D_202B_200C_206E_200B_206A_202E(object P_0, object P_1, object P_2)
	{
		return string.Concat(P_0, P_1, P_2);
	}

	static Type _202A_200C_200B_200B_200E_202D_206F_200D_200E_206D_200B_200B_200E_206E_206A_200D_202E_200B_206D_200E_206B_202C_202B_206A_206F_202C_200E_206B_200B_206D_202C_202A_202D_200E_200C_202C_206F_206F_200D_200D_202E(object P_0)
	{
		return P_0.GetType();
	}

	static bool _202E_206D_206D_206B_202B_200F_200E_202A_206E_206D_206D_200C_200E_200D_206D_202E_200C_202C_206B_200D_206D_202D_202C_206C_206F_202A_206A_200D_206B_200F_200C_200D_200B_206F_202C_200B_200D_202A_200C_200C_202E(Type P_0)
	{
		return P_0.IsArray;
	}

	static int _202A_202E_200C_202E_200C_206F_200C_202D_202E_200B_202C_202D_200F_206F_200B_206C_200F_206F_206B_202E_202C_200E_206B_206F_202E_200F_202A_200F_202E_202E_206F_202A_200E_206D_206B_200E_202E_202C_206E_206E_202E(Array P_0)
	{
		return P_0.Length;
	}

	static string _200E_202B_200D_202E_202D_206E_200B_206A_206C_206D_202B_206E_206E_200E_202E_200C_202B_202C_202C_202A_202A_200E_206E_206B_200F_206D_202C_200F_206C_200D_200B_206C_200B_206C_206F_206B_206C_200D_206C_206A_202E(object[] P_0)
	{
		return string.Concat(P_0);
	}

	static object _200D_202C_202B_200B_202D_206E_202B_202A_200D_200D_202B_206C_202A_202B_206D_206A_206C_202A_200F_200B_206F_206A_206E_200F_206C_202D_206B_206E_200D_200C_202D_202D_200C_202A_206F_202A_206A_206B_206D_202C_202E(Array P_0, int P_1)
	{
		return P_0.GetValue(P_1);
	}

	static MethodInfo[] _202C_200B_200E_200F_206F_206A_200F_202E_206C_206D_202A_200D_202D_206D_200B_202B_200C_202E_202B_202B_206C_200D_206E_202E_206E_200E_206A_202C_202E_202B_206F_202E_200B_206F_202C_200C_202D_200E_206C_206C_202E(Type P_0)
	{
		return P_0.GetMethods();
	}

	static string _206E_206F_200B_206C_206C_200C_206C_200B_202C_206D_206A_200F_206B_200E_202B_200D_202A_206E_202C_206A_206E_206E_206B_200F_200F_206B_202E_206D_206F_206D_202C_202D_202D_200E_202E_200C_206D_206F_206A_206E_202E(MemberInfo P_0)
	{
		return P_0.Name;
	}

	static bool _202B_200B_202D_206A_206F_206A_206A_206B_202A_200B_200E_200F_202B_200E_206C_206E_202B_206E_200E_200E_206A_200E_202B_200F_200B_206D_206C_202A_200B_206C_206B_206C_206F_200C_202E_200C_202E_200D_202A_202D_202E(string P_0, string P_1)
	{
		return P_0 == P_1;
	}

	static ParameterInfo[] _206A_202B_206B_206D_206C_200E_200B_200F_200E_200E_202D_206C_200C_200C_202C_200E_200B_202E_200E_206C_202B_200C_206C_200B_206A_206C_202E_206F_202A_206C_200B_200F_202A_206C_202A_206E_200E_200F_200C_206B_202E(MethodBase P_0)
	{
		return P_0.GetParameters();
	}

	static string _206F_206B_200F_206E_200C_200C_202E_206F_206F_200B_200B_206D_202C_206F_206B_200F_200B_200D_200F_202A_206A_206B_206C_206C_200D_200F_200F_202E_202E_200E_202D_206F_206E_200D_200C_206C_202A_200B_206A_202E_202E(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	static Type _206E_200B_206F_206F_200B_206E_200E_200B_206D_202B_202D_206F_202E_206D_206E_202E_200E_202A_206B_206C_202D_200C_200F_206C_206A_200C_206B_202A_206D_200D_206B_200C_206C_206E_206B_206C_200C_200C_202C_206E_202E(ParameterInfo P_0)
	{
		return P_0.ParameterType;
	}

	static object _202B_206A_200D_202E_206B_206D_206B_206A_206E_200C_200F_202D_200C_206B_200D_206E_200C_200C_206B_206E_200F_206E_202E_206C_200D_200B_202A_200E_202E_206F_202E_206C_200D_206A_202C_202E_202B_206C_206D_202B_202E(MethodBase P_0, object P_1, object[] P_2)
	{
		return P_0.Invoke(P_1, P_2);
	}

	static Exception _202B_206F_200B_200F_206D_200F_206D_202B_200B_206A_200D_200C_202E_206B_206F_200E_202D_206D_206B_200D_202A_202C_206B_206E_200D_202E_202A_206E_206E_200E_200C_202C_200C_206F_200F_202A_206F_202B_206A_200F_202E(Exception P_0)
	{
		return P_0.InnerException;
	}

	static string _206D_200D_202B_206E_202C_206A_206F_200C_206E_202A_202D_200D_200D_206D_200F_202C_206B_206C_200B_206C_206E_206D_206B_202C_206D_202B_200E_202E_200D_200B_202A_206B_206F_206D_202E_206D_202B_202E_202D_200E_202E(Exception P_0)
	{
		return P_0.Message;
	}

	static string _202C_202E_206E_200D_202B_202A_200E_206E_206C_202B_200B_200B_200F_202A_206E_206D_206C_202E_206E_200B_202E_202A_206C_206B_200E_200B_200C_206A_206A_206E_202C_200F_202E_200C_206E_200E_202D_202E_206C_202A_202E(string P_0, string P_1)
	{
		return P_0 + P_1;
	}

	static MemberInfo[] _202A_200F_202B_206B_200F_202C_206B_206F_206D_206E_206A_202E_200E_206A_206E_200B_200C_206D_206C_206F_206E_206A_200B_202E_206D_202A_200F_200C_202B_206A_200B_200E_206A_200F_202E_206D_206A_206D_200B_206F_202E(IReflect P_0, string P_1, BindingFlags P_2)
	{
		return P_0.GetMember(P_1, P_2);
	}

	static MemberTypes _206D_202E_206F_200F_200C_206C_206E_206B_200B_200E_202A_202D_200E_206A_200D_200C_200C_200E_200C_200C_202C_202E_206F_202C_200E_202C_200F_200F_206F_206A_206D_206A_206D_200C_202A_200B_206F_206A_206A_202B_202E(MemberInfo P_0)
	{
		return P_0.MemberType;
	}

	static object _202C_202B_200B_200D_200B_202B_202D_206F_202E_206D_202E_202E_206E_200C_202E_206A_202E_202B_200F_206A_200E_206B_200E_206D_200E_202A_206E_206E_206E_206D_206D_202D_202E_206C_206B_200D_206C_202E_206C_206E_202E(FieldInfo P_0, object P_1)
	{
		return P_0.GetValue(P_1);
	}

	static MethodInfo _206B_206A_206E_202B_202B_202C_202E_206E_206E_202C_202C_200D_206D_202D_200C_202C_206F_200E_202D_200B_202B_202A_202D_202C_206B_206D_202D_206D_200F_206F_202D_200C_200B_200C_200D_200B_206C_206C_206B_206A_202E(PropertyInfo P_0)
	{
		return P_0.GetGetMethod();
	}

	static Type _206D_206C_200E_200E_206E_200C_206A_202A_202B_206D_200B_200F_202B_206E_202C_200C_206E_206A_206B_200C_206E_202D_200B_206B_202C_202C_200D_200C_200C_202D_206F_206F_202E_200C_202D_202A_200F_206D_200C_206D_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static Type _206A_206C_206B_200D_206A_200F_206E_202D_202D_200F_202C_206B_206F_202E_200E_202B_206D_202A_202B_202D_202A_202D_202A_202E_206A_200F_202C_206A_200C_202B_200D_200C_200B_202C_206D_200C_202A_206B_200D_206D_202E(Type P_0)
	{
		return P_0.BaseType;
	}

	static Type _200E_202A_200C_206F_202D_200C_200F_200C_202E_206A_206F_200B_206F_200F_202E_200D_200C_206A_200C_206C_200B_202E_202C_206D_206A_200F_200D_202B_200B_200D_202E_200D_200E_202A_206F_206B_200B_206A_206B_206C_202E(MemberInfo P_0)
	{
		return P_0.DeclaringType;
	}

	static string _206B_202B_200B_206E_206D_202A_202C_200E_202B_200C_206F_200E_200F_206B_200B_202D_200B_206C_202D_202B_200D_202B_206B_200E_202A_200C_206D_206D_202E_200E_200C_206B_200C_206B_200B_202E_206E_200B_200E_202C_202E(Type P_0)
	{
		return P_0.FullName;
	}

	static string _206B_206D_202E_202E_200D_206D_200B_202C_202C_206A_200C_202D_202A_200C_200D_206E_200F_206A_206D_202D_206B_202C_200E_202C_206E_200D_200F_206D_202C_206B_200D_200C_202B_206A_206B_206A_202C_206E_206E_200D_202E(string P_0, string P_1, string P_2)
	{
		return P_0 + P_1 + P_2;
	}

	static object _202B_206F_200F_206C_206B_200C_206D_206A_202E_200E_202C_202A_206B_200D_202E_202E_200D_206E_202D_202A_200E_202A_206F_202D_202B_200C_202D_202B_202A_202C_202B_202D_202E_200D_206A_200B_202E_202B_202C_202E(Hashtable P_0, object P_1)
	{
		return P_0[P_1];
	}

	static void _200E_200F_206B_202C_202A_200D_206E_200F_202B_200D_206D_200E_202E_200C_206B_200F_200F_206F_200E_200E_206D_200E_200F_206A_200D_206C_202E_206D_206F_206D_200E_202C_202B_206B_206B_202B_206E_202A_206D_200E_202E(Hashtable P_0, object P_1, object P_2)
	{
		P_0[P_1] = P_2;
	}

	static Type _200D_202B_202B_206B_202B_206E_206B_206A_206A_206A_206B_200E_202E_206D_206D_206D_202C_200B_200E_200F_200F_206D_200F_206F_206B_206D_202B_202C_200F_202A_200C_202B_202B_206B_200B_200B_202D_200D_202D_200D_202E(Type P_0)
	{
		return P_0.GetElementType();
	}

	static void _206A_200B_206F_206A_206E_206C_202D_202C_206B_206A_202D_200E_200E_200C_206E_206A_202B_206F_206D_202E_206E_202A_200F_206E_206B_200F_202B_202C_206B_200C_200B_200D_202C_206A_206D_202E_200D_200D_202C_202B_202E(Array P_0, object P_1, int P_2)
	{
		P_0.SetValue(P_1, P_2);
	}

	static MethodInfo _202C_200C_206E_202A_200B_202C_202B_202C_206D_206B_202E_206C_202B_206E_206E_206B_202C_206E_200D_206D_200C_202D_206B_206B_206B_206F_200C_200C_206D_200F_200C_200C_206A_206B_200E_200D_200C_206F_202E_206F_202E(Type P_0, string P_1)
	{
		return P_0.GetMethod(P_1);
	}

	static int _200E_200D_202B_206F_206E_206C_206E_202E_200E_206D_202B_200C_202D_206C_202C_206A_202E_202C_202E_206B_206D_202D_200E_206E_200F_206C_200D_200B_206C_202B_206B_200D_200C_202A_206B_206D_202E_200F_206B_202D_202E(string P_0)
	{
		return P_0.Length;
	}

	static char _206C_206C_200D_202B_206F_200B_200E_206E_206A_206B_206F_202C_206D_200D_202D_200F_202B_202C_206A_202E_202C_206C_206A_200B_206D_200E_202A_202D_200C_200D_202E_200D_200B_206F_200C_202C_202A_202C_200B_202C_202E(string P_0, int P_1)
	{
		return P_0[P_1];
	}

	static Type _200D_200D_206E_202D_202D_200E_200C_206A_200C_206E_200D_206C_200C_206B_202C_200C_202B_206A_206A_200B_202E_202C_206E_206C_206C_206D_202B_206B_200F_206D_206F_206D_206A_200B_206B_206D_206F_202E_202B_200F_202E(FieldInfo P_0)
	{
		return P_0.FieldType;
	}

	static void _202A_206E_202B_202A_200C_200C_206F_200E_202C_202B_200D_202C_202E_206E_202E_206C_200D_202B_202D_202E_200D_202C_202A_200E_200E_206A_200B_206D_202A_202D_206A_206C_202A_206C_200B_202C_202B_202A_200B_200E_202E(FieldInfo P_0, object P_1, object P_2)
	{
		P_0.SetValue(P_1, P_2);
	}

	static Type _206B_200E_202E_206B_206E_202C_202B_200B_206E_200E_200E_202B_202B_202B_202A_200F_202A_202D_206F_202E_202D_206F_200C_202E_206F_200F_202E_202B_206E_206C_206B_202B_202C_202D_206F_202C_200E_202E_206A_200D_202E(PropertyInfo P_0)
	{
		return P_0.PropertyType;
	}

	static void _200D_200B_206D_200B_202D_202D_206B_206E_202D_200C_202D_206F_206E_200D_206E_206B_202E_200B_202E_200D_206E_206B_202C_200D_206D_206A_200C_202E_200B_202A_200E_206F_200C_202E_200D_206E_206B_202B_200E_202B_202E(PropertyInfo P_0, object P_1, object P_2, object[] P_3)
	{
		P_0.SetValue(P_1, P_2, P_3);
	}

	static Type _200C_202E_206B_202D_200D_202C_200F_206F_206D_206E_202C_206A_206F_200B_206C_202E_200E_206C_200E_206A_202E_206F_202D_202E_200C_200C_202C_202E_206D_206C_200E_202C_206F_200B_206D_202E_200D_202D_206D_200D_202E(IReflect P_0)
	{
		return P_0.UnderlyingSystemType;
	}

	static Array _206E_200C_206A_202B_200C_202A_200B_202B_200E_206F_202E_202C_202D_206A_202C_206B_200E_206C_202C_202A_200E_206D_202A_200E_202E_200F_206F_200C_202C_202D_206A_206C_200F_206C_206B_206A_202D_206E_206A_202B_202E(Type P_0, int P_1)
	{
		return Array.CreateInstance(P_0, P_1);
	}

	static ConstructorInfo[] _200D_200B_200C_202E_206E_206A_200F_200B_200C_202E_202C_200B_200D_206E_206E_206B_206F_206E_200E_206A_200E_200C_200B_200D_202B_206D_200F_206D_206C_206F_206B_200B_206E_202B_206D_202C_202C_202E_206D_202B_202E(Type P_0)
	{
		return P_0.GetConstructors();
	}

	static object _202C_200B_206F_202A_200B_200E_202C_202A_202E_206C_202B_200B_206E_206D_200C_200E_206F_200C_200D_200E_202C_200F_202A_206C_200B_206A_200D_206D_206F_200E_202C_206C_200D_206C_200B_200F_206E_206A_206B_202A_202E(ConstructorInfo P_0, object[] P_1)
	{
		return P_0.Invoke(P_1);
	}

	static string _200C_206F_202C_206D_200C_202C_202C_206C_206C_202C_200C_200E_202A_206C_206D_202B_206E_200D_206D_202D_202A_200E_206D_200C_202A_206F_200F_202B_200F_202E_206B_206D_202A_202B_206C_200C_206B_206B_206E_206F_202E(string P_0, object P_1, object P_2)
	{
		return string.Format(P_0, P_1, P_2);
	}

	static double _202C_202A_200F_200C_206C_202A_202A_206B_200B_200C_202A_206F_202A_206A_202B_202A_202B_206E_200E_206A_206B_200C_206D_200B_206A_202A_206B_206B_202C_200E_200F_202B_206E_206F_200B_200C_202E_206B_206A_200F_202E(double P_0)
	{
		return Math.Ceiling(P_0);
	}

	static void _200E_206D_200D_206D_202B_206F_202A_200B_206F_206B_200D_202D_202D_200B_206E_200D_206B_206C_202A_206B_202B_206B_202C_206C_202E_206F_200F_202B_200E_202B_202A_200E_200B_200B_206A_206D_200C_202E_206E_200F_202E(IEnumerator P_0)
	{
		P_0.Reset();
	}

	static int _202B_206C_206F_202B_206C_206A_202B_200F_206E_200E_202A_206D_200E_206E_202B_206C_206F_206A_206A_206B_202D_206C_202B_206D_202C_206C_202B_202D_202D_202C_206B_206B_206C_202C_206B_202C_206B_206F_200E_200F_202E(ICollection P_0)
	{
		return P_0.Count;
	}

	static object _202E_202E_202E_202B_202B_202C_206A_206E_206C_200E_202C_202E_206C_202A_206A_202E_206F_206C_206B_202A_200C_200E_206A_206D_202A_202A_206D_202B_202B_202A_206B_202B_202C_206E_206D_206F_200D_200F_206F_200F_202E(IDictionaryEnumerator P_0)
	{
		return P_0.Value;
	}

	static int _200F_202B_206A_202A_200C_206F_206B_206A_202A_200C_202C_206F_200E_202D_200C_200C_200F_200C_202A_202E_200D_206F_206D_206A_206B_202A_206E_206D_200B_206A_206B_202A_206E_206C_206B_206B_206B_206A_202A_202B_202E(double P_0)
	{
		return Convert.ToInt32(P_0);
	}

	static object _202C_206E_202D_202E_202E_206A_206E_206B_206B_200F_202C_202A_206C_206B_206E_206B_200C_206A_206E_200F_206F_202C_200D_206C_206A_202A_200C_206D_200E_200F_206C_206A_206D_206D_206B_202A_206A_206D_200F_202E_202E(object P_0, Type P_1)
	{
		return Convert.ChangeType(P_0, P_1);
	}

	static bool _202C_202A_206C_202A_202C_206C_206D_200C_206B_206B_200E_202C_200E_202D_206A_202B_200B_200D_200E_200B_206F_206D_206B_206E_200B_200D_206E_206E_202B_206C_202D_206A_200E_200E_200F_206F_206D_200B_202B_206A_202E(IEnumerator P_0)
	{
		return P_0.MoveNext();
	}

	static ArrayList _200C_202E_200B_200D_200B_202C_200F_202C_202A_206D_202D_202A_202D_200E_206A_200D_200C_206A_206B_206B_200B_206F_202D_206F_206C_206B_202D_206D_200C_202C_202B_202E_200F_202C_202C_206A_200B_200E_206F_206E_202E()
	{
		return new ArrayList();
	}

	static bool _200E_200F_200B_200D_206F_206C_206A_206D_206C_200B_206F_206D_200E_206E_206E_200D_202B_202E_206F_200F_206A_200B_206E_206B_202D_206F_202C_202C_202E_202B_206D_202E_206E_202C_202D_200B_206F_200D_206E_200E_202E(ParameterInfo P_0)
	{
		return P_0.IsIn;
	}

	static bool _202A_202D_206E_200D_200F_206A_206F_202E_202D_206E_206D_206A_200B_202C_200B_202B_202C_206F_206F_202C_206F_202B_202E_206B_200D_202E_202A_202C_206A_202B_200E_200B_200D_206D_206E_200D_206B_202C_200F_200D_202E(ParameterInfo P_0)
	{
		return P_0.IsOut;
	}

	static int _202E_202E_202B_202C_200B_206D_202E_206A_200C_202B_202C_202A_202B_202C_200B_200D_200D_202B_200C_200D_200C_202B_200E_202B_202B_202B_202A_202A_206F_206E_202C_200F_206C_200D_202B_202C_206D_200E_206E_200C_202E(ArrayList P_0, object P_1)
	{
		return P_0.Add(P_1);
	}

	static bool _206D_206F_206B_200E_206B_202D_202B_202A_206E_200F_206F_202E_202A_206F_200F_206F_202D_206C_202C_200F_206E_202E_200D_200E_200E_200C_202C_202A_206F_206E_200F_206D_200C_206B_206D_206C_200C_202E_202D_200D_202E(ParameterInfo P_0)
	{
		return P_0.IsOptional;
	}

	static object _206D_206D_202D_206F_202E_200C_200F_206C_206B_206E_200B_200C_202D_206E_206C_202D_200C_202D_200B_206F_202C_206F_206F_206A_200B_202B_202E_206E_206A_202B_202C_206D_200B_206E_206A_206B_206C_206A_202D_206A_202E(ParameterInfo P_0)
	{
		return P_0.DefaultValue;
	}

	static bool _206D_202D_200F_200C_206F_202D_202C_202C_202E_200F_206D_200C_200C_206F_200D_202B_206C_202A_206A_206E_200D_200C_206E_206C_200D_200C_202A_206E_200C_206D_202C_200F_206D_206D_200E_200E_206E_206B_206E_202E(Type P_0)
	{
		return P_0.IsByRef;
	}

	static object[] _200F_200E_202C_206C_206D_202E_206E_206C_206F_202B_200E_206A_202A_206E_202E_202A_200F_206A_206E_202D_202D_206A_202A_206B_206A_202B_200C_206D_200B_206D_202A_200C_200D_202A_206D_202E_200D_206C_202C_200F_202E(ArrayList P_0)
	{
		return P_0.ToArray();
	}

	static object[] _206D_200F_202A_206E_200C_206A_206D_206F_206D_202B_206C_202A_206D_206C_206E_206A_206B_202B_200E_206D_206C_202E_206A_200F_200B_206A_206E_206C_206B_206C_200E_202D_202B_202A_206B_206E_200E_200B_200E_200D_202E(ParameterInfo P_0, Type P_1, bool P_2)
	{
		return P_0.GetCustomAttributes(P_1, P_2);
	}
}
