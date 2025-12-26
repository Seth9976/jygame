using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace LuaInterface;

public static class LuaRegistrationHelper
{
	public static void TaggedInstanceMethods(LuaState lua, object o)
	{
		if (lua == null)
		{
			goto IL_0006;
		}
		goto IL_01fe;
		IL_0006:
		int num = -1886054096;
		goto IL_000b;
		IL_000b:
		MethodInfo[] array = default(MethodInfo[]);
		MethodInfo methodInfo = default(MethodInfo);
		int num4 = default(int);
		LuaGlobalAttribute luaGlobalAttribute = default(LuaGlobalAttribute);
		object[] array2 = default(object[]);
		int num3 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1932502991)) % 19)
			{
			case 9u:
				break;
			default:
				return;
			case 16u:
				num = ((int)num2 * -1928317999) ^ 0x3E758E52;
				continue;
			case 3u:
				array = _200E_202C_202D_200B_200C_200F_200D_200F_202A_202A_202B_200D_206D_206E_200C_206A_206D_200E_206F_206A_200E_200C_206D_202D_200C_200E_202C_202B_206F_202D_202A_206D_200B_200D_202A_200B_200E_206C_202E_206B_202E(_202B_200E_200E_202C_206A_202B_206F_200D_206C_206A_202C_202E_200E_202E_200C_206C_202C_202E_200B_200E_202B_202E_200E_202C_206C_200D_202B_202B_200E_206C_206D_200D_206D_202D_202A_202B_200D_200B_202D_202B_202E(o), BindingFlags.Instance | BindingFlags.Public);
				num = -853271294;
				continue;
			case 0u:
				throw _202E_206B_206D_206C_200B_206A_200E_206B_202A_202C_206D_206A_206B_206F_202E_206F_202C_202B_206A_206E_206B_206E_202B_202A_200F_200E_206C_206F_202A_202A_202C_200D_206B_202C_206C_206B_206A_202C_200B_202A_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1149073153u));
			case 4u:
				num = ((int)num2 * -1022335495) ^ 0x77A54AAD;
				continue;
			case 14u:
				lua.RegisterFunction(_202E_200E_200C_200C_200B_206E_206E_206B_200F_202B_206D_202B_202B_206F_206D_202A_206A_206B_202D_200B_206D_202B_202A_206F_202B_206A_202A_206A_206B_200C_200E_206A_200F_206A_202A_200E_206C_200D_200D_200D_202E((MemberInfo)methodInfo), o, methodInfo);
				num = ((int)num2 * -1602786590) ^ -1017293121;
				continue;
			case 6u:
				num4++;
				num = (int)((num2 * 26865902) ^ 0x159022F5);
				continue;
			case 18u:
				lua.RegisterFunction(luaGlobalAttribute.Name, o, methodInfo);
				num = -1538331110;
				continue;
			case 1u:
				goto IL_011d;
			case 5u:
				goto IL_0139;
			case 10u:
				num4 = 0;
				num = ((int)num2 * -473413486) ^ 0x5C6E0568;
				continue;
			case 17u:
				methodInfo = array[num4];
				array2 = _206E_200C_200D_206B_202A_200B_206B_200F_206D_206D_206C_202E_202A_206B_202E_202C_200F_202E_206F_206A_200C_206B_202A_202C_206F_200F_200B_202B_202A_202E_206A_206D_200D_200E_200C_206A_200C_202E_202D_206D_202E((MemberInfo)methodInfo, _202B_206C_200C_206E_202A_200B_202A_206D_206E_206C_200D_200F_200C_206B_206B_200E_202B_206F_200D_202C_202A_206E_202D_200E_206E_200C_202E_206B_206C_202A_206E_206A_200F_200D_206A_206F_206B_200C_200D_206F_202E(typeof(LuaGlobalAttribute).TypeHandle), true);
				num = -1112483192;
				continue;
			case 12u:
				num3 = 0;
				num = (int)(num2 * 1236030972) ^ -167825572;
				continue;
			case 13u:
				goto IL_019f;
			case 2u:
				throw _202E_206B_206D_206C_200B_206A_200E_206B_202A_202C_206D_206A_206B_206F_202E_206F_202C_202B_206A_206E_206B_206E_202B_202A_200F_200E_206C_206F_202A_202A_202C_200D_206B_202C_206C_206B_206A_202C_200B_202A_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2207668438u));
			case 15u:
				num3++;
				num = -2103425980;
				continue;
			case 7u:
				goto IL_01fe;
			case 8u:
				num = ((int)num2 * -630970653) ^ 0x8566F9C;
				continue;
			case 11u:
				return;
			}
			break;
			IL_019f:
			luaGlobalAttribute = (LuaGlobalAttribute)array2[num3];
			int num5;
			if (_206D_202D_206B_202E_206E_200F_200E_200C_202E_206E_206C_200C_200D_206F_200E_206C_206E_202A_200B_206C_202C_200B_202E_202B_200B_202C_200E_206E_202B_206B_206D_206B_200D_206A_206C_206C_206C_200E_202C_206E_202E(luaGlobalAttribute.Name))
			{
				num = -152116638;
				num5 = num;
			}
			else
			{
				num = -209457362;
				num5 = num;
			}
			continue;
			IL_0139:
			int num6;
			if (num4 >= array.Length)
			{
				num = -504474257;
				num6 = num;
			}
			else
			{
				num = -1426823424;
				num6 = num;
			}
			continue;
			IL_011d:
			int num7;
			if (num3 < array2.Length)
			{
				num = -202900183;
				num7 = num;
			}
			else
			{
				num = -634849681;
				num7 = num;
			}
		}
		goto IL_0006;
		IL_01fe:
		int num8;
		if (o == null)
		{
			num = -470814039;
			num8 = num;
		}
		else
		{
			num = -1656176971;
			num8 = num;
		}
		goto IL_000b;
	}

	public static void TaggedStaticMethods(LuaState lua, Type type)
	{
		if (lua == null)
		{
			goto IL_0006;
		}
		goto IL_014d;
		IL_0006:
		int num = 449137554;
		goto IL_000b;
		IL_000b:
		object[] array = default(object[]);
		MethodInfo methodInfo = default(MethodInfo);
		int num3 = default(int);
		MethodInfo[] array2 = default(MethodInfo[]);
		LuaGlobalAttribute luaGlobalAttribute = default(LuaGlobalAttribute);
		int num4 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x5830D4EF)) % 22)
			{
			case 10u:
				break;
			default:
				return;
			case 19u:
				array = _206E_200C_200D_206B_202A_200B_206B_200F_206D_206D_206C_202E_202A_206B_202E_202C_200F_202E_206F_206A_200C_206B_202A_202C_206F_200F_200B_202B_202A_202E_206A_206D_200D_200E_200C_206A_200C_202E_202D_206D_202E((MemberInfo)methodInfo, _202B_206C_200C_206E_202A_200B_202A_206D_206E_206C_200D_200F_200C_206B_206B_200E_202B_206F_200D_202C_202A_206E_202D_200E_206E_200C_202E_206B_206C_202A_206E_206A_200F_200D_206A_206F_206B_200C_200D_206F_202E(typeof(LuaGlobalAttribute).TypeHandle), false);
				num = (int)((num2 * 1017688335) ^ 0x1CD3E87F);
				continue;
			case 21u:
				num3 = 0;
				num = ((int)num2 * -678392174) ^ -1643009121;
				continue;
			case 20u:
				goto IL_00b5;
			case 7u:
				num3++;
				num = 1949823261;
				continue;
			case 8u:
				goto IL_00e1;
			case 13u:
				throw _202E_206B_206D_206C_200B_206A_200E_206B_202A_202C_206D_206A_206B_206F_202E_206F_202C_202B_206A_206E_206B_206E_202B_202A_200F_200E_206C_206F_202A_202A_202C_200D_206B_202C_206C_206B_206A_202C_200B_202A_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(392357619u));
			case 17u:
				goto IL_0120;
			case 4u:
				array2 = _200E_202C_202D_200B_200C_200F_200D_200F_202A_202A_202B_200D_206D_206E_200C_206A_206D_200E_206F_206A_200E_200C_206D_202D_200C_200E_202C_202B_206F_202D_202A_206D_200B_200D_202A_200B_200E_206C_202E_206B_202E(type, BindingFlags.Static | BindingFlags.Public);
				num = 1948620719;
				continue;
			case 18u:
				goto IL_014d;
			case 16u:
				lua.RegisterFunction(luaGlobalAttribute.Name, null, methodInfo);
				num = 1307699590;
				continue;
			case 1u:
			{
				int num5;
				int num6;
				if (!_206D_202D_206B_202E_206E_200F_200E_200C_202E_206E_206C_200C_200D_206F_200E_206C_206E_202A_200B_206C_202C_200B_202E_202B_200B_202C_200E_206E_202B_206B_206D_206B_200D_206A_206C_206C_206C_200E_202C_206E_202E(luaGlobalAttribute.Name))
				{
					num5 = -813637321;
					num6 = num5;
				}
				else
				{
					num5 = -817459120;
					num6 = num5;
				}
				num = num5 ^ (int)(num2 * 1780023804);
				continue;
			}
			case 14u:
				num4 = 0;
				num = (int)((num2 * 889235084) ^ 0x62D0353E);
				continue;
			case 11u:
				lua.RegisterFunction(_202E_200E_200C_200C_200B_206E_206E_206B_200F_202B_206D_202B_202B_206F_206D_202A_206A_206B_202D_200B_206D_202B_202A_206F_202B_206A_202A_206A_206B_200C_200E_206A_200F_206A_202A_200E_206C_200D_200D_200D_202E((MemberInfo)methodInfo), null, methodInfo);
				num = (int)((num2 * 1895100493) ^ 0x3228B4B8);
				continue;
			case 0u:
				num = ((int)num2 * -2035117337) ^ 0x1348C5F6;
				continue;
			case 6u:
				throw _202E_206B_206D_206C_200B_206A_200E_206B_202A_202C_206D_206A_206B_206F_202E_206F_202C_202B_206A_206E_206B_206E_202B_202A_200F_200E_206C_206F_202A_202A_202C_200D_206B_202C_206C_206B_206A_202C_200B_202A_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(924289442u));
			case 5u:
				num4++;
				num = ((int)num2 * -723440448) ^ -645241428;
				continue;
			case 15u:
				num = (int)(num2 * 1383949233) ^ -153083283;
				continue;
			case 3u:
				methodInfo = array2[num4];
				num = 810751016;
				continue;
			case 2u:
				throw _206C_200B_206E_202B_206E_200C_200F_206A_206C_202D_200C_200F_200C_202A_206C_200F_200C_202D_202B_206E_200B_202B_206A_200F_202C_200C_206B_206B_200B_200B_206F_206C_202D_200E_206B_202C_206A_202D_200F_206F_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3076722723u), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1961445347u));
			case 9u:
				luaGlobalAttribute = (LuaGlobalAttribute)array[num3];
				num = 1558489862;
				continue;
			case 12u:
				return;
			}
			break;
			IL_0120:
			int num7;
			if (num4 < array2.Length)
			{
				num = 201342378;
				num7 = num;
			}
			else
			{
				num = 2050389445;
				num7 = num;
			}
			continue;
			IL_00e1:
			int num8;
			if (!_206B_206F_200E_200B_202E_206C_206F_202A_206F_206A_206E_206E_200C_206A_206C_206D_200B_200F_200E_206C_206F_200C_206D_202C_200E_206F_202D_202E_200B_200D_202E_206B_202C_200D_206C_200F_206B_200E_206D_206E_202E(type))
			{
				num = 1144093815;
				num8 = num;
			}
			else
			{
				num = 2119153807;
				num8 = num;
			}
			continue;
			IL_00b5:
			int num9;
			if (num3 < array.Length)
			{
				num = 794511232;
				num9 = num;
			}
			else
			{
				num = 1712291084;
				num9 = num;
			}
		}
		goto IL_0006;
		IL_014d:
		int num10;
		if (type == null)
		{
			num = 596765681;
			num10 = num;
		}
		else
		{
			num = 86032309;
			num10 = num;
		}
		goto IL_000b;
	}

	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Justification = "The type parameter is used to select an enum type")]
	public static void Enumeration<T>(LuaState lua)
	{
		if (lua == null)
		{
			goto IL_0006;
		}
		goto IL_00cc;
		IL_0006:
		int num = 1881072614;
		goto IL_000b;
		IL_000b:
		string[] array2 = default(string[]);
		Type type = default(Type);
		int num3 = default(int);
		T[] array = default(T[]);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x4CD119)) % 9)
			{
			case 4u:
				break;
			default:
				return;
			case 5u:
				array2 = _202A_202C_200F_202C_202B_206A_200C_202B_200D_206E_202C_206A_200F_206B_202E_202D_202B_206A_200C_206D_206A_202E_206A_202B_202B_206F_202E_202B_200D_206E_202B_206D_206F_200B_206B_206D_202C_206E_206A_202B_202E(type);
				num = 569740984;
				continue;
			case 0u:
			{
				string fullPath = _202D_206A_206D_202D_200B_206B_200D_202B_206F_200B_206F_202D_206F_200C_202C_200F_206C_206A_202E_202C_206D_200C_202E_206D_206A_206A_206F_206A_206F_202D_200C_200D_206F_206D_200E_206B_206E_202A_206C_202D_202E(_202E_200E_200C_200C_200B_206E_206E_206B_200F_202B_206D_202B_202B_206F_206D_202A_206A_206B_202D_200B_206D_202B_202A_206F_202B_206A_202A_206A_206B_200C_200E_206A_200F_206A_202A_200E_206C_200D_200D_200D_202E((MemberInfo)type), global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3180854736u), array2[num3]);
				lua[fullPath] = array[num3];
				num3++;
				num = 1900593794;
				continue;
			}
			case 7u:
				throw _202E_206B_206D_206C_200B_206A_200E_206B_202A_202C_206D_206A_206B_206F_202E_206F_202C_202B_206A_206E_206B_206E_202B_202A_200F_200E_206C_206F_202A_202A_202C_200D_206B_202C_206C_206B_206A_202C_200B_202A_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2207668438u));
			case 3u:
				goto IL_00b2;
			case 2u:
				goto IL_00cc;
			case 6u:
				array = (T[])_200E_200B_206E_202A_200C_202C_206E_200C_200E_202C_202D_206F_200E_200F_202A_206B_202E_202B_200D_200D_206B_206C_206C_200E_202C_202A_202E_202C_200E_202D_206D_202B_202D_200B_206C_206D_206F_206A_206E_206E_202E(type);
				lua.NewTable(_202E_200E_200C_200C_200B_206E_206E_206B_200F_202B_206D_202B_202B_206F_206D_202A_206A_206B_202D_200B_206D_202B_202A_206F_202B_206A_202A_206A_206B_200C_200E_206A_200F_206A_202A_200E_206C_200D_200D_200D_202E((MemberInfo)type));
				num3 = 0;
				num = (int)((num2 * 103000744) ^ 0x6562692A);
				continue;
			case 8u:
				throw _200F_202C_200E_206B_202D_206A_202E_200C_202A_202B_202D_200E_206D_202C_206B_202E_200F_200E_202A_200B_200D_206B_202D_206F_200F_202C_200E_202E_202D_202C_202C_200D_202D_206F_200D_200D_200C_206E_202C_200D_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(921780714u));
			case 1u:
				return;
			}
			break;
			IL_00b2:
			int num4;
			if (num3 < array2.Length)
			{
				num = 891507685;
				num4 = num;
			}
			else
			{
				num = 1676590158;
				num4 = num;
			}
		}
		goto IL_0006;
		IL_00cc:
		type = _202B_206C_200C_206E_202A_200B_202A_206D_206E_206C_200D_200F_200C_206B_206B_200E_202B_206F_200D_202C_202A_206E_202D_200E_206E_200C_202E_206B_206C_202A_206E_206A_200F_200D_206A_206F_206B_200C_200D_206F_202E(typeof(T).TypeHandle);
		int num5;
		if (!_200C_206B_206F_200F_202D_202E_200B_202D_206B_202A_200C_206C_206E_202D_206A_200C_202C_202A_202B_206B_206F_206E_202B_206B_206F_202C_206B_200E_200C_206B_206B_206D_202D_200E_206D_202C_206E_200D_206A_202E(type))
		{
			num = 5818395;
			num5 = num;
		}
		else
		{
			num = 109794342;
			num5 = num;
		}
		goto IL_000b;
	}

	static ArgumentNullException _202E_206B_206D_206C_200B_206A_200E_206B_202A_202C_206D_206A_206B_206F_202E_206F_202C_202B_206A_206E_206B_206E_202B_202A_200F_200E_206C_206F_202A_202A_202C_200D_206B_202C_206C_206B_206A_202C_200B_202A_202E(string P_0)
	{
		return new ArgumentNullException(P_0);
	}

	static Type _202B_200E_200E_202C_206A_202B_206F_200D_206C_206A_202C_202E_200E_202E_200C_206C_202C_202E_200B_200E_202B_202E_200E_202C_206C_200D_202B_202B_200E_206C_206D_200D_206D_202D_202A_202B_200D_200B_202D_202B_202E(object P_0)
	{
		return P_0.GetType();
	}

	static MethodInfo[] _200E_202C_202D_200B_200C_200F_200D_200F_202A_202A_202B_200D_206D_206E_200C_206A_206D_200E_206F_206A_200E_200C_206D_202D_200C_200E_202C_202B_206F_202D_202A_206D_200B_200D_202A_200B_200E_206C_202E_206B_202E(Type P_0, BindingFlags P_1)
	{
		return P_0.GetMethods(P_1);
	}

	static Type _202B_206C_200C_206E_202A_200B_202A_206D_206E_206C_200D_200F_200C_206B_206B_200E_202B_206F_200D_202C_202A_206E_202D_200E_206E_200C_202E_206B_206C_202A_206E_206A_200F_200D_206A_206F_206B_200C_200D_206F_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static object[] _206E_200C_200D_206B_202A_200B_206B_200F_206D_206D_206C_202E_202A_206B_202E_202C_200F_202E_206F_206A_200C_206B_202A_202C_206F_200F_200B_202B_202A_202E_206A_206D_200D_200E_200C_206A_200C_202E_202D_206D_202E(MemberInfo P_0, Type P_1, bool P_2)
	{
		return P_0.GetCustomAttributes(P_1, P_2);
	}

	static bool _206D_202D_206B_202E_206E_200F_200E_200C_202E_206E_206C_200C_200D_206F_200E_206C_206E_202A_200B_206C_202C_200B_202E_202B_200B_202C_200E_206E_202B_206B_206D_206B_200D_206A_206C_206C_206C_200E_202C_206E_202E(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}

	static string _202E_200E_200C_200C_200B_206E_206E_206B_200F_202B_206D_202B_202B_206F_206D_202A_206A_206B_202D_200B_206D_202B_202A_206F_202B_206A_202A_206A_206B_200C_200E_206A_200F_206A_202A_200E_206C_200D_200D_200D_202E(MemberInfo P_0)
	{
		return P_0.Name;
	}

	static bool _206B_206F_200E_200B_202E_206C_206F_202A_206F_206A_206E_206E_200C_206A_206C_206D_200B_200F_200E_206C_206F_200C_206D_202C_200E_206F_202D_202E_200B_200D_202E_206B_202C_200D_206C_200F_206B_200E_206D_206E_202E(Type P_0)
	{
		return P_0.IsClass;
	}

	static ArgumentException _206C_200B_206E_202B_206E_200C_200F_206A_206C_202D_200C_200F_200C_202A_206C_200F_200C_202D_202B_206E_200B_202B_206A_200F_202C_200C_206B_206B_200B_200B_206F_206C_202D_200E_206B_202C_206A_202D_200F_206F_202E(string P_0, string P_1)
	{
		return new ArgumentException(P_0, P_1);
	}

	static bool _200C_206B_206F_200F_202D_202E_200B_202D_206B_202A_200C_206C_206E_202D_206A_200C_202C_202A_202B_206B_206F_206E_202B_206B_206F_202C_206B_200E_200C_206B_206B_206D_202D_200E_206D_202C_206E_200D_206A_202E(Type P_0)
	{
		return P_0.IsEnum;
	}

	static ArgumentException _200F_202C_200E_206B_202D_206A_202E_200C_202A_202B_202D_200E_206D_202C_206B_202E_200F_200E_202A_200B_200D_206B_202D_206F_200F_202C_200E_202E_202D_202C_202C_200D_202D_206F_200D_200D_200C_206E_202C_200D_202E(string P_0)
	{
		return new ArgumentException(P_0);
	}

	static string[] _202A_202C_200F_202C_202B_206A_200C_202B_200D_206E_202C_206A_200F_206B_202E_202D_202B_206A_200C_206D_206A_202E_206A_202B_202B_206F_202E_202B_200D_206E_202B_206D_206F_200B_206B_206D_202C_206E_206A_202B_202E(Type P_0)
	{
		return Enum.GetNames(P_0);
	}

	static Array _200E_200B_206E_202A_200C_202C_206E_200C_200E_202C_202D_206F_200E_200F_202A_206B_202E_202B_200D_200D_206B_206C_206C_200E_202C_202A_202E_202C_200E_202D_206D_202B_202D_200B_206C_206D_206F_206A_206E_206E_202E(Type P_0)
	{
		return Enum.GetValues(P_0);
	}

	static string _202D_206A_206D_202D_200B_206B_200D_202B_206F_200B_206F_202D_206F_200C_202C_200F_206C_206A_202E_202C_206D_200C_202E_206D_206A_206A_206F_206A_206F_202D_200C_200D_206F_206D_200E_206B_206E_202A_206C_202D_202E(string P_0, string P_1, string P_2)
	{
		return P_0 + P_1 + P_2;
	}
}
