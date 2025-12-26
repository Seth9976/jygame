using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace LuaInterface;

internal class CheckType
{
	private ObjectTranslator translator;

	private ExtractValue extractNetObject;

	private Dictionary<long, ExtractValue> extractValues = new Dictionary<long, ExtractValue>();

	public CheckType(ObjectTranslator P_0)
	{
		translator = P_0;
		extractValues.Add(_206D_202D_206B_200C_200D_202C_206C_202D_200B_202D_200D_206C_200D_206B_206C_206D_206A_200D_200F_206E_206C_206A_202E_200D_202A_206C_206B_200B_202C_202B_202A_202D_202E_202B_206F_206B_206A_206D_202A_206C_202E(_206E_202C_202C_200E_200B_206D_206E_202E_202C_202A_206C_202E_200D_202B_206A_200F_200D_202D_200F_206D_202B_206A_206E_202C_206D_206D_202B_200C_206D_202D_202E_206F_206E_206E_200D_206A_206A_206E_206E_206C_202E(typeof(object).TypeHandle)).Value.ToInt64(), getAsObject);
		extractValues.Add(typeof(sbyte).TypeHandle.Value.ToInt64(), getAsSbyte);
		extractValues.Add(typeof(byte).TypeHandle.Value.ToInt64(), getAsByte);
		extractValues.Add(typeof(short).TypeHandle.Value.ToInt64(), getAsShort);
		extractValues.Add(typeof(ushort).TypeHandle.Value.ToInt64(), getAsUshort);
		extractValues.Add(typeof(int).TypeHandle.Value.ToInt64(), getAsInt);
		extractValues.Add(typeof(uint).TypeHandle.Value.ToInt64(), getAsUint);
		extractValues.Add(typeof(long).TypeHandle.Value.ToInt64(), getAsLong);
		extractValues.Add(typeof(ulong).TypeHandle.Value.ToInt64(), getAsUlong);
		extractValues.Add(typeof(double).TypeHandle.Value.ToInt64(), getAsDouble);
		extractValues.Add(typeof(char).TypeHandle.Value.ToInt64(), getAsChar);
		extractValues.Add(typeof(float).TypeHandle.Value.ToInt64(), getAsFloat);
		extractValues.Add(typeof(decimal).TypeHandle.Value.ToInt64(), getAsDecimal);
		extractValues.Add(typeof(bool).TypeHandle.Value.ToInt64(), getAsBoolean);
		extractValues.Add(typeof(string).TypeHandle.Value.ToInt64(), getAsString);
		extractValues.Add(typeof(LuaFunction).TypeHandle.Value.ToInt64(), getAsFunction);
		extractValues.Add(typeof(LuaTable).TypeHandle.Value.ToInt64(), getAsTable);
		extractValues.Add(typeof(Vector3).TypeHandle.Value.ToInt64(), getAsVector3);
		extractValues.Add(typeof(Vector2).TypeHandle.Value.ToInt64(), getAsVector2);
		extractValues.Add(typeof(Quaternion).TypeHandle.Value.ToInt64(), getAsQuaternion);
		extractValues.Add(typeof(Color).TypeHandle.Value.ToInt64(), getAsColor);
		extractValues.Add(typeof(Vector4).TypeHandle.Value.ToInt64(), getAsVector4);
		extractValues.Add(typeof(Ray).TypeHandle.Value.ToInt64(), getAsRay);
		extractValues.Add(typeof(Bounds).TypeHandle.Value.ToInt64(), getAsBounds);
		extractNetObject = getAsNetObject;
	}

	internal ExtractValue getExtractor(IReflect paramType)
	{
		return getExtractor(_200E_206C_200B_202C_206C_200C_202A_202E_202A_206B_202B_200D_206C_200F_202D_202A_202A_206F_202B_206E_206E_206E_202C_202D_200E_202A_200D_206D_202C_202E_206F_200B_202E_206D_206B_202D_202C_206E_202C_200F_202E(paramType));
	}

	internal ExtractValue getExtractor(Type paramType)
	{
		if (_200C_202A_202C_200F_200C_200D_200B_206B_200B_206B_200C_200F_206A_206B_202B_202B_202C_206F_202D_206D_202E_206C_202D_206C_200F_206A_202E_200D_202E_202A_206F_200D_206D_206C_206B_206B_200B_200C_206C_202C_202E(paramType))
		{
			goto IL_0008;
		}
		goto IL_0049;
		IL_0008:
		int num = 249576142;
		goto IL_000d;
		IL_000d:
		long key = default(long);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x2983AB20)) % 5)
			{
			case 4u:
				break;
			case 1u:
				paramType = _206C_202E_202B_202E_200D_206D_206C_202A_202A_202D_202D_206F_206B_206F_202B_202D_206A_202E_202A_202A_202D_206F_206F_206F_200C_202C_200C_202B_206D_206B_202C_206E_200F_202C_202C_200C_206A_200E_202A_206D_202E(paramType);
				num = ((int)num2 * -1133390170) ^ -962177662;
				continue;
			case 0u:
				goto IL_0049;
			case 2u:
				return extractValues[key];
			default:
				return extractNetObject;
			}
			break;
		}
		goto IL_0008;
		IL_0049:
		key = _206D_202D_206B_200C_200D_202C_206C_202D_200B_202D_200D_206C_200D_206B_206C_206D_206A_200D_200F_206E_206C_206A_202E_200D_202A_206C_206B_200B_202C_202B_202A_202D_202E_202B_206F_206B_206A_206D_202A_206C_202E(paramType).Value.ToInt64();
		int num3;
		if (extractValues.ContainsKey(key))
		{
			num = 1596857101;
			num3 = num;
		}
		else
		{
			num = 729158005;
			num3 = num;
		}
		goto IL_000d;
	}

	internal ExtractValue checkType(IntPtr luaState, int stackPos, Type paramType)
	{
		LuaTypes luaTypes = LuaDLL.lua_type(luaState, stackPos);
		ExtractValue extractValue = default(ExtractValue);
		long key = default(long);
		string text = default(string);
		RuntimeTypeHandle runtimeTypeHandle = default(RuntimeTypeHandle);
		int newTop = default(int);
		object netObject = default(object);
		object rawNetObject = default(object);
		Type type = default(Type);
		while (true)
		{
			int num = -24260331;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1848036212)) % 99)
				{
				case 32u:
					break;
				case 57u:
					extractValue = extractValues[typeof(Quaternion).TypeHandle.Value.ToInt64()];
					num = ((int)num2 * -433661065) ^ 0x58F33B40;
					continue;
				case 44u:
				{
					int num49;
					if (paramType.IsInterface)
					{
						num = -1422579210;
						num49 = num;
					}
					else
					{
						num = -977886467;
						num49 = num;
					}
					continue;
				}
				case 93u:
					return extractValues[key];
				case 89u:
				{
					int num37;
					int num38;
					if (paramType == typeof(Quaternion))
					{
						num37 = 1101130418;
						num38 = num37;
					}
					else
					{
						num37 = 270139028;
						num38 = num37;
					}
					num = num37 ^ ((int)num2 * -1259656232);
					continue;
				}
				case 66u:
				{
					int num70;
					if (luaTypes == LuaTypes.LUA_TNIL)
					{
						num = -580825771;
						num70 = num;
					}
					else
					{
						num = -1937383678;
						num70 = num;
					}
					continue;
				}
				case 22u:
					LuaDLL.lua_settop(luaState, -2);
					num = ((int)num2 * -1164401875) ^ 0x71344418;
					continue;
				case 39u:
					extractValue = null;
					LuaDLL.lua_pushvalue(luaState, stackPos);
					num = (int)((num2 * 2032649780) ^ 0xACDFB64);
					continue;
				case 11u:
				{
					int num43;
					int num44;
					if (luaTypes == LuaTypes.LUA_TFUNCTION)
					{
						num43 = 249747101;
						num44 = num43;
					}
					else
					{
						num43 = 1047255881;
						num44 = num43;
					}
					num = num43 ^ (int)(num2 * 1289496100);
					continue;
				}
				case 28u:
				{
					int num68;
					int num69;
					if (text == global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3457765948u))
					{
						num68 = -1088730633;
						num69 = num68;
					}
					else
					{
						num68 = -1634070031;
						num69 = num68;
					}
					num = num68 ^ ((int)num2 * -1491748820);
					continue;
				}
				case 56u:
					return extractValues[key];
				case 67u:
					num = (int)(num2 * 1389035655) ^ -216506172;
					continue;
				case 52u:
				{
					int num58;
					if (paramType.IsValueType)
					{
						num = -1503364352;
						num58 = num;
					}
					else
					{
						num = -1115107077;
						num58 = num;
					}
					continue;
				}
				case 41u:
					LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1438587224u));
					LuaDLL.lua_gettable(luaState, -2);
					num = ((int)num2 * -288199055) ^ -1995242206;
					continue;
				case 48u:
				{
					int num35;
					int num36;
					if (paramType == typeof(Vector4))
					{
						num35 = -360256498;
						num36 = num35;
					}
					else
					{
						num35 = -960931112;
						num36 = num35;
					}
					num = num35 ^ (int)(num2 * 1890654320);
					continue;
				}
				case 23u:
					return extractValues[typeof(LuaFunction).TypeHandle.Value.ToInt64()];
				case 68u:
					num = ((int)num2 * -500991567) ^ -698810788;
					continue;
				case 30u:
					key = runtimeTypeHandle.Value.ToInt64();
					num = (int)((num2 * 1877106300) ^ 0x56B7999F);
					continue;
				case 10u:
					LuaDLL.lua_settop(luaState, newTop);
					num = -375393362;
					continue;
				case 14u:
				{
					int num75;
					if (!(text == global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3016777011u)))
					{
						num = -1728314728;
						num75 = num;
					}
					else
					{
						num = -342697008;
						num75 = num;
					}
					continue;
				}
				case 33u:
				{
					int num64;
					int num65;
					if (LuaDLL.lua_isstring(luaState, stackPos))
					{
						num64 = -1701079288;
						num65 = num64;
					}
					else
					{
						num64 = -730367446;
						num65 = num64;
					}
					num = num64 ^ ((int)num2 * -504969735);
					continue;
				}
				case 78u:
				{
					int num61;
					if (luaTypes != LuaTypes.LUA_TUSERDATA)
					{
						num = -1783401243;
						num61 = num;
					}
					else
					{
						num = -332166125;
						num61 = num;
					}
					continue;
				}
				case 63u:
				{
					int num51;
					if (paramType == typeof(string))
					{
						num = -1008528443;
						num51 = num;
					}
					else
					{
						num = -565988779;
						num51 = num;
					}
					continue;
				}
				case 35u:
				{
					int num41;
					int num42;
					if (!paramType.IsClass)
					{
						num41 = 1032009462;
						num42 = num41;
					}
					else
					{
						num41 = 132459996;
						num42 = num41;
					}
					num = num41 ^ (int)(num2 * 1482014666);
					continue;
				}
				case 60u:
				{
					int num32;
					if (!(text == global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4163976134u)))
					{
						num = -830269082;
						num32 = num;
					}
					else
					{
						num = -493136540;
						num32 = num;
					}
					continue;
				}
				case 21u:
					return extractValues[typeof(object).TypeHandle.Value.ToInt64()];
				case 45u:
				{
					int num22;
					int num23;
					if (paramType == typeof(Vector3))
					{
						num22 = -718295984;
						num23 = num22;
					}
					else
					{
						num22 = -1173070363;
						num23 = num22;
					}
					num = num22 ^ ((int)num2 * -1062041180);
					continue;
				}
				case 61u:
					extractValue = extractValues[typeof(Color).TypeHandle.Value.ToInt64()];
					num = ((int)num2 * -491054443) ^ 0x47090010;
					continue;
				case 0u:
					return extractNetObject;
				case 76u:
					return extractValues[typeof(string).TypeHandle.Value.ToInt64()];
				case 96u:
				{
					int num10;
					int num11;
					if (paramType != typeof(Color))
					{
						num10 = 1475199859;
						num11 = num10;
					}
					else
					{
						num10 = 142101980;
						num11 = num10;
					}
					num = num10 ^ ((int)num2 * -905040217);
					continue;
				}
				case 13u:
					newTop = LuaDLL.lua_gettop(luaState);
					num = (int)((num2 * 99004505) ^ 0x3FD9F81B);
					continue;
				case 58u:
				{
					int num73;
					if (!LuaDLL.lua_isnumber(luaState, stackPos))
					{
						num = -1543055005;
						num73 = num;
					}
					else
					{
						num = -1191843565;
						num73 = num;
					}
					continue;
				}
				case 64u:
				{
					int num71;
					if (luaTypes == LuaTypes.LUA_TSTRING)
					{
						num = -475709385;
						num71 = num;
					}
					else
					{
						num = -1033060759;
						num71 = num;
					}
					continue;
				}
				case 85u:
				{
					int num59;
					int num60;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num59 = 72867141;
						num60 = num59;
					}
					else
					{
						num59 = 522996367;
						num60 = num59;
					}
					num = num59 ^ ((int)num2 * -1143540994);
					continue;
				}
				case 94u:
				{
					int num54;
					int num55;
					if (!_200C_202A_202C_200F_200C_200D_200B_206B_200B_206B_200C_200F_206A_206B_202B_202B_202C_206F_202D_206D_202E_206C_202D_206C_200F_206A_202E_200D_202E_202A_206F_200D_206D_206C_206B_206B_200B_200C_206C_202C_202E(paramType))
					{
						num54 = -257703467;
						num55 = num54;
					}
					else
					{
						num54 = -2106312314;
						num55 = num54;
					}
					num = num54 ^ (int)(num2 * 1941815180);
					continue;
				}
				case 4u:
					return extractValue;
				case 12u:
				{
					int num47;
					int num48;
					if (luaTypes != LuaTypes.LUA_TBOOLEAN)
					{
						num47 = -1412882843;
						num48 = num47;
					}
					else
					{
						num47 = -915637433;
						num48 = num47;
					}
					num = num47 ^ (int)(num2 * 254371748);
					continue;
				}
				case 95u:
				{
					int num45;
					if (luaTypes != LuaTypes.LUA_TNUMBER)
					{
						num = -1472439221;
						num45 = num;
					}
					else
					{
						num = -1685694806;
						num45 = num;
					}
					continue;
				}
				case 2u:
				{
					int num33;
					if (paramType == typeof(LuaTable))
					{
						num = -1802191625;
						num33 = num;
					}
					else
					{
						num = -1867535611;
						num33 = num;
					}
					continue;
				}
				case 54u:
				{
					int num30;
					if (!(text == global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4130552048u)))
					{
						num = -1178492076;
						num30 = num;
					}
					else
					{
						num = -2050533844;
						num30 = num;
					}
					continue;
				}
				case 15u:
					return extractValues[key];
				case 20u:
					return extractNetObject;
				case 72u:
				{
					int num26;
					if (luaTypes != LuaTypes.LUA_TFUNCTION)
					{
						num = -2001096955;
						num26 = num;
					}
					else
					{
						num = -175101484;
						num26 = num;
					}
					continue;
				}
				case 40u:
				{
					int num20;
					int num21;
					if (!LuaDLL.lua_isboolean(luaState, stackPos))
					{
						num20 = -624705196;
						num21 = num20;
					}
					else
					{
						num20 = -2001558904;
						num21 = num20;
					}
					num = num20 ^ ((int)num2 * -1156975096);
					continue;
				}
				case 84u:
					paramType = _206C_202E_202B_202E_200D_206D_206C_202A_202A_202D_202D_206F_206B_206F_202B_202D_206A_202E_202A_202A_202D_206F_206F_206F_200C_202C_200C_202B_206D_206B_202C_206E_200F_202C_202C_200C_206A_200E_202A_206D_202E(paramType);
					num = (int)(num2 * 1509619351) ^ -1392097901;
					continue;
				case 46u:
					netObject = translator.getNetObject(luaState, -1);
					num = (int)((num2 * 1042304688) ^ 0x1E70762D);
					continue;
				case 87u:
					num = (int)(num2 * 2105902203) ^ -1770837513;
					continue;
				case 36u:
				{
					int num13;
					int num14;
					if (LuaDLL.lua_isnil(luaState, -1))
					{
						num13 = 1675959815;
						num14 = num13;
					}
					else
					{
						num13 = 1488158383;
						num14 = num13;
					}
					num = num13 ^ (int)(num2 * 302196943);
					continue;
				}
				case 7u:
					extractValue = extractValues[typeof(Vector4).TypeHandle.Value.ToInt64()];
					num = (int)((num2 * 1850608142) ^ 0x149E0287);
					continue;
				case 37u:
					translator.throwError(luaState, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2227868537u));
					num = (int)(num2 * 1828267446) ^ -1694872408;
					continue;
				case 26u:
					extractValue = extractValues[typeof(Vector3).TypeHandle.Value.ToInt64()];
					num = (int)(num2 * 198887363) ^ -1043370997;
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (!paramType.Equals(typeof(object)))
					{
						num5 = -1098717808;
						num6 = num5;
					}
					else
					{
						num5 = -1379889880;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 876098804);
					continue;
				}
				case 8u:
					num = ((int)num2 * -1378316966) ^ 0x16E94391;
					continue;
				case 53u:
				{
					int num74;
					if (LuaDLL.lua_type(luaState, stackPos) == LuaTypes.LUA_TTABLE)
					{
						num = -1375303436;
						num74 = num;
					}
					else
					{
						num = -1566119456;
						num74 = num;
					}
					continue;
				}
				case 75u:
					num = (int)((num2 * 370344252) ^ 0x9EDC415);
					continue;
				case 49u:
				{
					int num72;
					if (luaTypes != LuaTypes.LUA_TNIL)
					{
						num = -1856818468;
						num72 = num;
					}
					else
					{
						num = -1470796571;
						num72 = num;
					}
					continue;
				}
				case 1u:
					return extractNetObject;
				case 9u:
				{
					int num66;
					int num67;
					if (paramType != typeof(Vector2))
					{
						num66 = -1607062402;
						num67 = num66;
					}
					else
					{
						num66 = -1133087550;
						num67 = num66;
					}
					num = num66 ^ ((int)num2 * -347763617);
					continue;
				}
				case 86u:
				{
					int num62;
					int num63;
					if (!paramType.IsAssignableFrom(rawNetObject.GetType()))
					{
						num62 = -1554102736;
						num63 = num62;
					}
					else
					{
						num62 = -1367434499;
						num63 = num62;
					}
					num = num62 ^ ((int)num2 * -839963302);
					continue;
				}
				case 77u:
					extractValue = extractValues[typeof(Ray).TypeHandle.Value.ToInt64()];
					num = (int)((num2 * 1008562563) ^ 0x7539E700);
					continue;
				case 71u:
					runtimeTypeHandle = _206D_202D_206B_200C_200D_202C_206C_202D_200B_202D_200D_206C_200D_206B_206C_206D_206A_200D_200F_206E_206C_206A_202E_200D_202A_206C_206B_200B_202C_202B_202A_202D_202E_202B_206F_206B_206A_206D_202A_206C_202E(paramType);
					num = -389756859;
					continue;
				case 31u:
					return extractNetObject;
				case 70u:
					text = LuaDLL.lua_tostring(luaState, -1);
					num = (int)(num2 * 1708987265) ^ -467864777;
					continue;
				case 43u:
				{
					int num56;
					int num57;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num56 = -1376453185;
						num57 = num56;
					}
					else
					{
						num56 = -380821775;
						num57 = num56;
					}
					num = num56 ^ ((int)num2 * -1039642053);
					continue;
				}
				case 16u:
					return extractValues[typeof(double).TypeHandle.Value.ToInt64()];
				case 50u:
				{
					int num52;
					int num53;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num52 = -523305023;
						num53 = num52;
					}
					else
					{
						num52 = -1872202371;
						num53 = num52;
					}
					num = num52 ^ (int)(num2 * 741935312);
					continue;
				}
				case 47u:
				{
					type = _200D_206B_202B_200E_202C_202C_206E_200E_200F_202B_200D_206A_200C_206E_206F_206D_200B_206E_206A_206D_200C_202E_202D_206B_200B_206D_206F_202D_202A_200E_200D_202B_200C_202C_206B_200B_200C_206F_200F_206D_202E(paramType);
					int num50;
					if (type != null)
					{
						num = -1120427905;
						num50 = num;
					}
					else
					{
						num = -676098627;
						num50 = num;
					}
					continue;
				}
				case 59u:
				{
					int num46;
					if (text == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1762199165u))
					{
						num = -992994057;
						num46 = num;
					}
					else
					{
						num = -25809316;
						num46 = num;
					}
					continue;
				}
				case 83u:
				{
					int num39;
					int num40;
					if (luaTypes != LuaTypes.LUA_TFUNCTION)
					{
						num39 = -1365499915;
						num40 = num39;
					}
					else
					{
						num39 = -1839763908;
						num40 = num39;
					}
					num = num39 ^ (int)(num2 * 301599531);
					continue;
				}
				case 25u:
				{
					int num34;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num = -530857584;
						num34 = num;
					}
					else
					{
						num = -613449695;
						num34 = num;
					}
					continue;
				}
				case 88u:
					num = (int)(num2 * 1466771825) ^ -129129662;
					continue;
				case 38u:
					extractValue = extractValues[typeof(Vector2).TypeHandle.Value.ToInt64()];
					num = ((int)num2 * -1004462536) ^ 0x6E47B2BE;
					continue;
				case 74u:
					translator.throwError(luaState, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(57686303u));
					num = ((int)num2 * -1921940012) ^ -2087880770;
					continue;
				case 29u:
					extractValue = null;
					num = -207930651;
					continue;
				case 18u:
				{
					int num31;
					if (!typeof(Delegate).IsAssignableFrom(paramType))
					{
						num = -478303203;
						num31 = num;
					}
					else
					{
						num = -1498689951;
						num31 = num;
					}
					continue;
				}
				case 62u:
				{
					int num29;
					if (!paramType.IsInterface)
					{
						num = -1670121675;
						num29 = num;
					}
					else
					{
						num = -1557339580;
						num29 = num;
					}
					continue;
				}
				case 73u:
				{
					int num28;
					if (!(text == global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1991708486u)))
					{
						num = -1081451326;
						num28 = num;
					}
					else
					{
						num = -1385097877;
						num28 = num;
					}
					continue;
				}
				case 97u:
				{
					int num27;
					if (paramType != typeof(LuaFunction))
					{
						num = -1865641354;
						num27 = num;
					}
					else
					{
						num = -1128261339;
						num27 = num;
					}
					continue;
				}
				case 82u:
					return extractValues[key];
				case 69u:
				{
					int num24;
					int num25;
					if (!paramType.IsAssignableFrom(netObject.GetType()))
					{
						num24 = -861013522;
						num25 = num24;
					}
					else
					{
						num24 = -2121811834;
						num25 = num24;
					}
					num = num24 ^ ((int)num2 * -2113178455);
					continue;
				}
				case 65u:
				{
					int num19;
					if (paramType == typeof(bool))
					{
						num = -2036786800;
						num19 = num;
					}
					else
					{
						num = -1460331716;
						num19 = num;
					}
					continue;
				}
				case 98u:
				{
					int num17;
					int num18;
					if (paramType != typeof(Ray))
					{
						num17 = -841209676;
						num18 = num17;
					}
					else
					{
						num17 = -1417426892;
						num18 = num17;
					}
					num = num17 ^ (int)(num2 * 1261375139);
					continue;
				}
				case 80u:
					return extractValues[key];
				case 55u:
				{
					int num15;
					int num16;
					if (netObject == null)
					{
						num15 = 510652285;
						num16 = num15;
					}
					else
					{
						num15 = 1820953087;
						num16 = num15;
					}
					num = num15 ^ (int)(num2 * 135055583);
					continue;
				}
				case 92u:
				{
					int num12;
					if (paramType.IsGenericParameter)
					{
						num = -1628502058;
						num12 = num;
					}
					else
					{
						num = -1472439221;
						num12 = num;
					}
					continue;
				}
				case 42u:
					return extractValues[key];
				case 90u:
				{
					int num8;
					int num9;
					if (extractValue == null)
					{
						num8 = -1811571847;
						num9 = num8;
					}
					else
					{
						num8 = -176319792;
						num9 = num8;
					}
					num = num8 ^ (int)(num2 * 1522378545);
					continue;
				}
				case 79u:
					paramType = type;
					num = (int)(num2 * 2041885446) ^ -1574245617;
					continue;
				case 81u:
					return extractValues[typeof(LuaTable).TypeHandle.Value.ToInt64()];
				case 24u:
				{
					rawNetObject = translator.getRawNetObject(luaState, stackPos);
					int num7;
					if (rawNetObject != null)
					{
						num = -2047426547;
						num7 = num;
					}
					else
					{
						num = -1155799958;
						num7 = num;
					}
					continue;
				}
				case 3u:
				{
					int num3;
					int num4;
					if (LuaDLL.luaL_getmetafield(luaState, stackPos, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3291265083u)) != LuaTypes.LUA_TNIL)
					{
						num3 = 1343866607;
						num4 = num3;
					}
					else
					{
						num3 = 2005610634;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1752867028);
					continue;
				}
				case 34u:
					return extractValues[typeof(bool).TypeHandle.Value.ToInt64()];
				default:
					return null;
				}
				break;
			}
		}
	}

	private object getAsSbyte(IntPtr luaState, int stackPos)
	{
		sbyte b = (sbyte)LuaDLL.lua_tonumber(luaState, stackPos);
		if (b == 0)
		{
			while (true)
			{
				int num = 206852818;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x34F55CC8)) % 4)
					{
					case 3u:
						break;
					case 2u:
					{
						int num3;
						int num4;
						if (LuaDLL.lua_isnumber(luaState, stackPos))
						{
							num3 = 1849401920;
							num4 = num3;
						}
						else
						{
							num3 = 744232233;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -2016243214);
						continue;
					}
					case 1u:
						return null;
					default:
						goto end_IL_000d;
					}
					break;
				}
				continue;
				end_IL_000d:
				break;
			}
		}
		return b;
	}

	private object getAsByte(IntPtr luaState, int stackPos)
	{
		byte b = (byte)LuaDLL.lua_tonumber(luaState, stackPos);
		while (true)
		{
			int num = -957597583;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1894006157)) % 5)
				{
				case 0u:
					break;
				case 2u:
				{
					int num5;
					int num6;
					if (b == 0)
					{
						num5 = -1787749468;
						num6 = num5;
					}
					else
					{
						num5 = -295919328;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1912608934);
					continue;
				}
				case 4u:
				{
					int num3;
					int num4;
					if (LuaDLL.lua_isnumber(luaState, stackPos))
					{
						num3 = 1812565199;
						num4 = num3;
					}
					else
					{
						num3 = 1820139691;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1132507289);
					continue;
				}
				case 1u:
					return null;
				default:
					return b;
				}
				break;
			}
		}
	}

	private object getAsShort(IntPtr luaState, int stackPos)
	{
		short num = (short)LuaDLL.lua_tonumber(luaState, stackPos);
		while (true)
		{
			int num2 = -525073710;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -823007464)) % 5)
				{
				case 2u:
					break;
				case 0u:
					return null;
				case 3u:
				{
					int num6;
					int num7;
					if (!LuaDLL.lua_isnumber(luaState, stackPos))
					{
						num6 = 1363565494;
						num7 = num6;
					}
					else
					{
						num6 = 1278630021;
						num7 = num6;
					}
					num2 = num6 ^ ((int)num3 * -237409079);
					continue;
				}
				case 1u:
				{
					int num4;
					int num5;
					if (num == 0)
					{
						num4 = 262137334;
						num5 = num4;
					}
					else
					{
						num4 = 1983831771;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num3 * -2012583742);
					continue;
				}
				default:
					return num;
				}
				break;
			}
		}
	}

	private object getAsUshort(IntPtr luaState, int stackPos)
	{
		ushort num = (ushort)LuaDLL.lua_tonumber(luaState, stackPos);
		while (true)
		{
			int num2 = -778479621;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -236924277)) % 5)
				{
				case 0u:
					break;
				case 2u:
					return null;
				case 1u:
				{
					int num6;
					int num7;
					if (LuaDLL.lua_isnumber(luaState, stackPos))
					{
						num6 = -95299612;
						num7 = num6;
					}
					else
					{
						num6 = -1770226901;
						num7 = num6;
					}
					num2 = num6 ^ (int)(num3 * 1808035283);
					continue;
				}
				case 3u:
				{
					int num4;
					int num5;
					if (num != 0)
					{
						num4 = -634828537;
						num5 = num4;
					}
					else
					{
						num4 = -11913926;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 6429528);
					continue;
				}
				default:
					return num;
				}
				break;
			}
		}
	}

	private object getAsInt(IntPtr luaState, int stackPos)
	{
		int num = (int)LuaDLL.lua_tonumber(luaState, stackPos);
		if (num == 0)
		{
			while (true)
			{
				int num2 = 1515987562;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num2 ^ 0x5EA31031)) % 4)
					{
					case 2u:
						break;
					case 3u:
					{
						int num4;
						int num5;
						if (!LuaDLL.lua_isnumber(luaState, stackPos))
						{
							num4 = -372308390;
							num5 = num4;
						}
						else
						{
							num4 = -2134201429;
							num5 = num4;
						}
						num2 = num4 ^ (int)(num3 * 595549685);
						continue;
					}
					case 0u:
						return null;
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
		return num;
	}

	private object getAsUint(IntPtr luaState, int stackPos)
	{
		uint num = (uint)LuaDLL.lua_tonumber(luaState, stackPos);
		while (true)
		{
			int num2 = 1702333631;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x65A226E)) % 5)
				{
				case 3u:
					break;
				case 0u:
					return null;
				case 1u:
				{
					int num6;
					int num7;
					if (!LuaDLL.lua_isnumber(luaState, stackPos))
					{
						num6 = -736918373;
						num7 = num6;
					}
					else
					{
						num6 = -1924123466;
						num7 = num6;
					}
					num2 = num6 ^ ((int)num3 * -1637701296);
					continue;
				}
				case 2u:
				{
					int num4;
					int num5;
					if (num == 0)
					{
						num4 = 747164380;
						num5 = num4;
					}
					else
					{
						num4 = 1177264212;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 572759106);
					continue;
				}
				default:
					return num;
				}
				break;
			}
		}
	}

	private object getAsLong(IntPtr luaState, int stackPos)
	{
		long num = (long)LuaDLL.lua_tonumber(luaState, stackPos);
		while (true)
		{
			int num2 = 2063330157;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x44B5D7CA)) % 5)
				{
				case 3u:
					break;
				case 4u:
					return null;
				case 1u:
				{
					int num6;
					int num7;
					if (LuaDLL.lua_isnumber(luaState, stackPos))
					{
						num6 = 545251464;
						num7 = num6;
					}
					else
					{
						num6 = 1294492747;
						num7 = num6;
					}
					num2 = num6 ^ ((int)num3 * -900359214);
					continue;
				}
				case 2u:
				{
					int num4;
					int num5;
					if (num == 0L)
					{
						num4 = 1414836215;
						num5 = num4;
					}
					else
					{
						num4 = 127066337;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num3 * -1293410073);
					continue;
				}
				default:
					return num;
				}
				break;
			}
		}
	}

	private object getAsUlong(IntPtr luaState, int stackPos)
	{
		ulong num = (ulong)LuaDLL.lua_tonumber(luaState, stackPos);
		while (true)
		{
			int num2 = 791095091;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x7C932E83)) % 5)
				{
				case 4u:
					break;
				case 3u:
				{
					int num6;
					int num7;
					if (num == 0L)
					{
						num6 = 1895615700;
						num7 = num6;
					}
					else
					{
						num6 = 520052578;
						num7 = num6;
					}
					num2 = num6 ^ (int)(num3 * 1537979153);
					continue;
				}
				case 1u:
					return null;
				case 2u:
				{
					int num4;
					int num5;
					if (LuaDLL.lua_isnumber(luaState, stackPos))
					{
						num4 = 649643842;
						num5 = num4;
					}
					else
					{
						num4 = 38326144;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num3 * -209441552);
					continue;
				}
				default:
					return num;
				}
				break;
			}
		}
	}

	private object getAsDouble(IntPtr luaState, int stackPos)
	{
		double num = LuaDLL.lua_tonumber(luaState, stackPos);
		if (num == 0.0)
		{
			while (true)
			{
				int num2 = -2025964933;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num2 ^ -1195640508)) % 4)
					{
					case 0u:
						break;
					case 3u:
					{
						int num4;
						int num5;
						if (!LuaDLL.lua_isnumber(luaState, stackPos))
						{
							num4 = -943343041;
							num5 = num4;
						}
						else
						{
							num4 = -1902323196;
							num5 = num4;
						}
						num2 = num4 ^ ((int)num3 * -1017205246);
						continue;
					}
					case 1u:
						return null;
					default:
						goto end_IL_0014;
					}
					break;
				}
				continue;
				end_IL_0014:
				break;
			}
		}
		return num;
	}

	private object getAsChar(IntPtr luaState, int stackPos)
	{
		char c = (char)LuaDLL.lua_tonumber(luaState, stackPos);
		if (c == '\0')
		{
			while (true)
			{
				int num = -342288586;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -106331841)) % 4)
					{
					case 2u:
						break;
					case 1u:
					{
						int num3;
						int num4;
						if (!LuaDLL.lua_isnumber(luaState, stackPos))
						{
							num3 = 748761365;
							num4 = num3;
						}
						else
						{
							num3 = 1141353758;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 825136694);
						continue;
					}
					case 0u:
						return null;
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
		return c;
	}

	private object getAsFloat(IntPtr luaState, int stackPos)
	{
		float num = (float)LuaDLL.lua_tonumber(luaState, stackPos);
		if (num == 0f)
		{
			while (true)
			{
				int num2 = 1442867470;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num2 ^ 0x2C0E0531)) % 4)
					{
					case 2u:
						break;
					case 3u:
					{
						int num4;
						int num5;
						if (LuaDLL.lua_isnumber(luaState, stackPos))
						{
							num4 = 1527670832;
							num5 = num4;
						}
						else
						{
							num4 = 782940773;
							num5 = num4;
						}
						num2 = num4 ^ ((int)num3 * -1818268396);
						continue;
					}
					case 0u:
						return null;
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
		return num;
	}

	private object getAsDecimal(IntPtr luaState, int stackPos)
	{
		decimal num = (decimal)LuaDLL.lua_tonumber(luaState, stackPos);
		if (num == 0m)
		{
			while (true)
			{
				int num2 = 8083454;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num2 ^ 0x64574ED3)) % 4)
					{
					case 2u:
						break;
					case 1u:
					{
						int num4;
						int num5;
						if (LuaDLL.lua_isnumber(luaState, stackPos))
						{
							num4 = 597301276;
							num5 = num4;
						}
						else
						{
							num4 = 77727563;
							num5 = num4;
						}
						num2 = num4 ^ (int)(num3 * 302034999);
						continue;
					}
					case 3u:
						return null;
					default:
						goto end_IL_001b;
					}
					break;
				}
				continue;
				end_IL_001b:
				break;
			}
		}
		return num;
	}

	private object getAsBoolean(IntPtr luaState, int stackPos)
	{
		return LuaDLL.lua_toboolean(luaState, stackPos);
	}

	private object getAsString(IntPtr luaState, int stackPos)
	{
		string text = LuaDLL.lua_tostring(luaState, stackPos);
		while (true)
		{
			int num = -194282511;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -93942619)) % 5)
				{
				case 2u:
					break;
				case 3u:
				{
					int num5;
					int num6;
					if (!_202A_202B_200D_200D_200D_206B_206B_206A_206D_202D_202D_202C_206E_202D_202B_206C_200D_206D_206D_206C_206A_206B_200B_206D_202A_202E_202E_202D_200B_206C_200C_206E_206E_202D_202D_206C_200D_206F_202B_202D_202E(text, string.Empty))
					{
						num5 = 1343863085;
						num6 = num5;
					}
					else
					{
						num5 = 1222234615;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -440586305);
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (!LuaDLL.lua_isstring(luaState, stackPos))
					{
						num3 = -1608442412;
						num4 = num3;
					}
					else
					{
						num3 = -1408711965;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1434827855);
					continue;
				}
				case 4u:
					return null;
				default:
					return text;
				}
				break;
			}
		}
	}

	private object getAsTable(IntPtr luaState, int stackPos)
	{
		return translator.getTable(luaState, stackPos);
	}

	private object getAsFunction(IntPtr luaState, int stackPos)
	{
		return translator.getFunction(luaState, stackPos);
	}

	public object getAsObject(IntPtr luaState, int stackPos)
	{
		if (LuaDLL.lua_type(luaState, stackPos) == LuaTypes.LUA_TTABLE)
		{
			goto IL_000d;
		}
		goto IL_008d;
		IL_000d:
		int num = -112994481;
		goto IL_0012;
		IL_0012:
		object result = default(object);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1004113089)) % 7)
			{
			case 6u:
				break;
			case 2u:
			{
				int num5;
				int num6;
				if (LuaDLL.luaL_getmetafield(luaState, stackPos, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3291265083u)) != LuaTypes.LUA_TNIL)
				{
					num5 = 369037898;
					num6 = num5;
				}
				else
				{
					num5 = 542417584;
					num6 = num5;
				}
				num = num5 ^ (int)(num2 * 1077008020);
				continue;
			}
			case 5u:
				LuaDLL.lua_insert(luaState, stackPos);
				LuaDLL.lua_remove(luaState, stackPos + 1);
				num = (int)((num2 * 1167191145) ^ 0x2FD59C00);
				continue;
			case 4u:
				goto IL_008d;
			case 1u:
				LuaDLL.lua_settop(luaState, -2);
				num = -805563792;
				continue;
			case 3u:
			{
				int num3;
				int num4;
				if (LuaDLL.luaL_checkmetatable(luaState, -1))
				{
					num3 = 648711374;
					num4 = num3;
				}
				else
				{
					num3 = 1170330298;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -1543545955);
				continue;
			}
			default:
				return result;
			}
			break;
		}
		goto IL_000d;
		IL_008d:
		result = translator.getObject(luaState, stackPos);
		num = -1236862227;
		goto IL_0012;
	}

	public object getAsNetObject(IntPtr luaState, int stackPos)
	{
		object obj = translator.getRawNetObject(luaState, stackPos);
		while (true)
		{
			int num = -215288329;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1656331601)) % 9)
				{
				case 3u:
					break;
				case 8u:
				{
					int num7;
					int num8;
					if (LuaDLL.luaL_checkmetatable(luaState, -1))
					{
						num7 = 1330153939;
						num8 = num7;
					}
					else
					{
						num7 = 1621328265;
						num8 = num7;
					}
					num = num7 ^ ((int)num2 * -295184027);
					continue;
				}
				case 2u:
				{
					int num5;
					int num6;
					if (LuaDLL.luaL_getmetafield(luaState, stackPos, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2814605998u)) != LuaTypes.LUA_TNIL)
					{
						num5 = 2023058315;
						num6 = num5;
					}
					else
					{
						num5 = 1311831840;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1892837620);
					continue;
				}
				case 5u:
				{
					int num9;
					int num10;
					if (LuaDLL.lua_type(luaState, stackPos) == LuaTypes.LUA_TTABLE)
					{
						num9 = -1497761097;
						num10 = num9;
					}
					else
					{
						num9 = -1261067904;
						num10 = num9;
					}
					num = num9 ^ ((int)num2 * -1814399516);
					continue;
				}
				case 0u:
					LuaDLL.lua_settop(luaState, -2);
					num = -1964322624;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (obj != null)
					{
						num3 = 1728998248;
						num4 = num3;
					}
					else
					{
						num3 = 1809081303;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -2015221985);
					continue;
				}
				case 6u:
					LuaDLL.lua_insert(luaState, stackPos);
					LuaDLL.lua_remove(luaState, stackPos + 1);
					obj = translator.getNetObject(luaState, stackPos);
					num = ((int)num2 * -652307065) ^ 0x7B8E86EE;
					continue;
				case 4u:
					num = (int)(num2 * 861843397) ^ -890551107;
					continue;
				default:
					return obj;
				}
				break;
			}
		}
	}

	public object getAsVector3(IntPtr L, int stackPos)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return LuaScriptMgr.GetVector3(L, stackPos);
	}

	public object getAsVector2(IntPtr L, int stackPos)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return LuaScriptMgr.GetVector2(L, stackPos);
	}

	public object getAsQuaternion(IntPtr L, int stackPos)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return LuaScriptMgr.GetQuaternion(L, stackPos);
	}

	public object getAsColor(IntPtr L, int stackPos)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return LuaScriptMgr.GetColor(L, stackPos);
	}

	public object getAsVector4(IntPtr L, int stackPos)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return LuaScriptMgr.GetVector4(L, stackPos);
	}

	public object getAsRay(IntPtr L, int stackPos)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return LuaScriptMgr.GetRay(L, stackPos);
	}

	public object getAsBounds(IntPtr L, int stackPos)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return LuaScriptMgr.GetBounds(L, stackPos);
	}

	static Type _206E_202C_202C_200E_200B_206D_206E_202E_202C_202A_206C_202E_200D_202B_206A_200F_200D_202D_200F_206D_202B_206A_206E_202C_206D_206D_202B_200C_206D_202D_202E_206F_206E_206E_200D_206A_206A_206E_206E_206C_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static RuntimeTypeHandle _206D_202D_206B_200C_200D_202C_206C_202D_200B_202D_200D_206C_200D_206B_206C_206D_206A_200D_200F_206E_206C_206A_202E_200D_202A_206C_206B_200B_202C_202B_202A_202D_202E_202B_206F_206B_206A_206D_202A_206C_202E(Type P_0)
	{
		return P_0.TypeHandle;
	}

	static Type _200E_206C_200B_202C_206C_200C_202A_202E_202A_206B_202B_200D_206C_200F_202D_202A_202A_206F_202B_206E_206E_206E_202C_202D_200E_202A_200D_206D_202C_202E_206F_200B_202E_206D_206B_202D_202C_206E_202C_200F_202E(IReflect P_0)
	{
		return P_0.UnderlyingSystemType;
	}

	static bool _200C_202A_202C_200F_200C_200D_200B_206B_200B_206B_200C_200F_206A_206B_202B_202B_202C_206F_202D_206D_202E_206C_202D_206C_200F_206A_202E_200D_202E_202A_206F_200D_206D_206C_206B_206B_200B_200C_206C_202C_202E(Type P_0)
	{
		return P_0.IsByRef;
	}

	static Type _206C_202E_202B_202E_200D_206D_206C_202A_202A_202D_202D_206F_206B_206F_202B_202D_206A_202E_202A_202A_202D_206F_206F_206F_200C_202C_200C_202B_206D_206B_202C_206E_200F_202C_202C_200C_206A_200E_202A_206D_202E(Type P_0)
	{
		return P_0.GetElementType();
	}

	static Type _200D_206B_202B_200E_202C_202C_206E_200E_200F_202B_200D_206A_200C_206E_206F_206D_200B_206E_206A_206D_200C_202E_202D_206B_200B_206D_206F_202D_202A_200E_200D_202B_200C_202C_206B_200B_200C_206F_200F_206D_202E(Type P_0)
	{
		return Nullable.GetUnderlyingType(P_0);
	}

	static bool _202A_202B_200D_200D_200D_206B_206B_206A_206D_202D_202D_202C_206E_202D_202B_206C_200D_206D_206D_206C_206A_206B_200B_206D_202A_202E_202E_202D_200B_206C_200C_206E_206E_202D_202D_206C_200D_206F_202B_202D_202E(string P_0, string P_1)
	{
		return P_0 == P_1;
	}
}
