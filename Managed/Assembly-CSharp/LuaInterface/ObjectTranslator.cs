using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace LuaInterface;

public class ObjectTranslator
{
	private class CompareObject : IEqualityComparer<object>
	{
		public new bool Equals(object x, object y)
		{
			return x == y;
		}

		public int GetHashCode(object obj)
		{
			if (obj != null)
			{
				while (true)
				{
					uint num;
					switch ((num = 661764925u) % 3)
					{
					case 0u:
						continue;
					case 1u:
						return _202B_206F_202B_202D_202D_200B_202E_202B_202D_202C_206A_202E_200E_202A_202A_200F_206C_200E_202B_200C_206C_200C_202C_202E_202C_206B_206E_206E_202C_206A_206A_200D_202E_200E_206D_206C_206D_200C_206F_202C_202E(obj);
					}
					break;
				}
			}
			return 0;
		}

		static int _202B_206F_202B_202D_202D_200B_202E_202B_202D_202C_206A_202E_200E_202A_202A_200F_206C_200E_202B_200C_206C_200C_202C_202E_202C_206B_206E_206E_202C_206A_206A_200D_202E_200E_206D_206C_206D_200C_206F_202C_202E(object P_0)
		{
			return P_0.GetHashCode();
		}
	}

	internal CheckType typeChecker;

	public readonly Dictionary<int, object> objects = new Dictionary<int, object>();

	public readonly Dictionary<object, int> objectsBackMap = new Dictionary<object, int>(new CompareObject());

	private static Dictionary<Type, int> typeMetaMap = new Dictionary<Type, int>();

	internal LuaState interpreter;

	public MetaFunctions metaFunctions;

	public List<Assembly> assemblies;

	private LuaCSFunction registerTableFunction;

	private LuaCSFunction unregisterTableFunction;

	private LuaCSFunction getMethodSigFunction;

	private LuaCSFunction getConstructorSigFunction;

	private LuaCSFunction importTypeFunction;

	private LuaCSFunction loadAssemblyFunction;

	private LuaCSFunction ctypeFunction;

	private LuaCSFunction enumFromIntFunction;

	internal EventHandlerContainer pendingEvents = new EventHandlerContainer();

	private static List<ObjectTranslator> list = new List<ObjectTranslator>();

	private static int indexTranslator = 0;

	private static Dictionary<Type, bool> valueTypeMap = new Dictionary<Type, bool>();

	private int nextObj;

	[CompilerGenerated]
	private int _200D_206E_200B_206D_206B_202B_202E_200D_206F_206C_200F_202D_202B_200C_202E_206B_200F_202E_202D_200E_200E_202E_200D_200F_202B_206C_206C_200F_200B_206A_200E_206B_202A_200D_200B_206A_206A_206E_202D_206F_202E;

	public int weakTableRef
	{
		[CompilerGenerated]
		get
		{
			return _200D_206E_200B_206D_206B_202B_202E_200D_206F_206C_200F_202D_202B_200C_202E_206B_200F_202E_202D_200E_200E_202E_200D_200F_202B_206C_206C_200F_200B_206A_200E_206B_202A_200D_200B_206A_206A_206E_202D_206F_202E;
		}
		[CompilerGenerated]
		private set
		{
			_200D_206E_200B_206D_206B_202B_202E_200D_206F_206C_200F_202D_202B_200C_202E_206B_200F_202E_202D_200E_200E_202E_200D_200F_202B_206C_206C_200F_200B_206A_200E_206B_202A_200D_200B_206A_206A_206E_202D_206F_202E = value;
		}
	}

	public ObjectTranslator(LuaState P_0, IntPtr P_1)
	{
		while (true)
		{
			int num = 1530027628;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x160DF904)) % 14)
				{
				case 11u:
					break;
				case 10u:
					typeChecker = new CheckType(this);
					num = (int)(num2 * 1106847513) ^ -1783073764;
					continue;
				case 6u:
					createClassMetatable(P_1);
					num = (int)((num2 * 639776477) ^ 0x2C17111D);
					continue;
				case 12u:
					assemblies = new List<Assembly>();
					num = (int)(num2 * 1810279223) ^ -68973083;
					continue;
				case 8u:
					getConstructorSigFunction = getConstructorSignature;
					ctypeFunction = ctype;
					enumFromIntFunction = enumFromInt;
					num = (int)((num2 * 114991367) ^ 0x3C1EF809);
					continue;
				case 5u:
					assemblies.Add(_202B_200E_200E_206F_202C_202B_200D_206E_206F_202D_206B_206B_206D_200F_202C_206A_206D_200E_202D_202D_200D_200F_206C_206A_202B_206F_206A_206B_200B_206B_200B_202B_206D_206A_202A_202E_200F_202A_206F_206D_202E());
					importTypeFunction = importType;
					loadAssemblyFunction = loadAssembly;
					num = (int)((num2 * 687309261) ^ 0x7DE3657F);
					continue;
				case 4u:
					metaFunctions = new MetaFunctions(this);
					num = ((int)num2 * -334470978) ^ 0x1540FA00;
					continue;
				case 3u:
					createLuaObjectList(P_1);
					createIndexingMetaFunction(P_1);
					createBaseClassMetatable(P_1);
					num = (int)((num2 * 2024864161) ^ 0x18D18289);
					continue;
				case 13u:
					unregisterTableFunction = unregisterTable;
					num = ((int)num2 * -1187052084) ^ 0x5887119F;
					continue;
				case 1u:
					getMethodSigFunction = getMethodSignature;
					num = (int)(num2 * 867270064) ^ -783889228;
					continue;
				case 2u:
					interpreter = P_0;
					num = (int)(num2 * 797976721) ^ -381491359;
					continue;
				case 0u:
					registerTableFunction = registerTable;
					num = (int)((num2 * 1422791456) ^ 0x2A0510E7);
					continue;
				case 9u:
					weakTableRef = -1;
					num = (int)((num2 * 1648684167) ^ 0x59A0AFA7);
					continue;
				default:
					createFunctionMetatable(P_1);
					setGlobalFunctions(P_1);
					return;
				}
				break;
			}
		}
	}

	public static ObjectTranslator FromState(IntPtr luaState)
	{
		LuaDLL.lua_getglobal(luaState, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2542462573u));
		int index = default(int);
		while (true)
		{
			int num = -1206033940;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1967614740)) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_0032;
				default:
					LuaDLL.lua_pop(luaState, 1);
					return list[index];
				}
				break;
				IL_0032:
				index = (int)LuaDLL.lua_tonumber(luaState, -1);
				num = (int)((num2 * 164375608) ^ 0x78DF008B);
			}
		}
	}

	public void PushTranslator(IntPtr L)
	{
		list.Add(this);
		while (true)
		{
			int num = 191059764;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x501FAD1D)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_002d;
				case 1u:
					return;
				}
				break;
				IL_002d:
				LuaDLL.lua_pushnumber(L, indexTranslator);
				LuaDLL.lua_setglobal(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1090387535u));
				indexTranslator++;
				num = (int)((num2 * 2098348083) ^ 0x61C5E717);
			}
		}
	}

	public void Destroy()
	{
		IntPtr l = interpreter.L;
		Dictionary<Type, int>.Enumerator enumerator = typeMetaMap.GetEnumerator();
		try
		{
			int value = default(int);
			while (true)
			{
				IL_0044:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 1000321823;
					num2 = num;
				}
				else
				{
					num = 2028761883;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x7884E48C)) % 5)
					{
					case 4u:
						num = 2028761883;
						continue;
					default:
						goto end_IL_001e;
					case 2u:
						break;
					case 0u:
						LuaDLL.lua_unref(l, value);
						num = ((int)num3 * -785621607) ^ -178041039;
						continue;
					case 1u:
						value = enumerator.Current.Value;
						num = 1092987045;
						continue;
					case 3u:
						goto end_IL_001e;
					}
					goto IL_0044;
					continue;
					end_IL_001e:
					break;
				}
				break;
			}
		}
		finally
		{
			_202E_202C_206D_202D_206F_206D_200B_202D_202C_202A_202B_202B_202E_202C_202C_202D_202A_206A_202B_200C_206F_202E_200B_206C_206C_206A_202A_206E_200B_206F_202B_206F_200E_202D_202E_206D_206D_206B_200E_202E((IDisposable)enumerator);
		}
		LuaDLL.lua_unref(l, weakTableRef);
		while (true)
		{
			int num4 = 1876832054;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num4 ^ 0x7884E48C)) % 3)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_00c9;
				case 0u:
					return;
				}
				break;
				IL_00c9:
				typeMetaMap.Clear();
				num4 = ((int)num3 * -1015099694) ^ 0x56A3DE59;
			}
		}
	}

	private void createLuaObjectList(IntPtr luaState)
	{
		LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3871923763u));
		while (true)
		{
			int num = 2138077041;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5CA7D560)) % 8)
				{
				case 4u:
					break;
				case 7u:
					weakTableRef = LuaDLL.luaL_ref(luaState, LuaIndexes.LUA_REGISTRYINDEX);
					LuaDLL.lua_pushvalue(luaState, -1);
					num = ((int)num2 * -1787547564) ^ 0x3BABFFF2;
					continue;
				case 2u:
					LuaDLL.lua_pushvalue(luaState, -1);
					num = ((int)num2 * -1231092092) ^ -121259905;
					continue;
				case 5u:
					LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1035533818u));
					LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3180575710u));
					num = ((int)num2 * -1454864874) ^ -1935801642;
					continue;
				case 0u:
					LuaDLL.lua_settable(luaState, -3);
					num = (int)(num2 * 1574902999) ^ -1979635389;
					continue;
				case 6u:
					LuaDLL.lua_setmetatable(luaState, -2);
					num = ((int)num2 * -1497567498) ^ 0x2E2B91A9;
					continue;
				case 1u:
					LuaDLL.lua_newtable(luaState);
					num = ((int)num2 * -397102519) ^ -2047089325;
					continue;
				default:
					LuaDLL.lua_settable(luaState, LuaIndexes.LUA_REGISTRYINDEX);
					return;
				}
				break;
			}
		}
	}

	private void createIndexingMetaFunction(IntPtr luaState)
	{
		LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1299682269u));
		LuaDLL.luaL_dostring(luaState, MetaFunctions.luaIndexFunction);
		LuaDLL.lua_rawset(luaState, LuaIndexes.LUA_REGISTRYINDEX);
	}

	private void createBaseClassMetatable(IntPtr luaState)
	{
		LuaDLL.luaL_newmetatable(luaState, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2720352838u));
		while (true)
		{
			int num = 1771215273;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2AA6A3E3)) % 11)
				{
				case 2u:
					break;
				default:
					return;
				case 8u:
					LuaDLL.lua_pushstdcallcfunction(luaState, metaFunctions.toStringFunction);
					num = (int)(num2 * 1623011477) ^ -962883557;
					continue;
				case 10u:
					LuaDLL.lua_settable(luaState, -3);
					LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2814605998u));
					LuaDLL.lua_pushstdcallcfunction(luaState, metaFunctions.baseIndexFunction);
					num = ((int)num2 * -873954391) ^ 0x71D86F6F;
					continue;
				case 5u:
					LuaDLL.lua_settop(luaState, -2);
					num = (int)((num2 * 940829154) ^ 0x6E69934B);
					continue;
				case 4u:
					LuaDLL.lua_settable(luaState, -3);
					LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4154041690u));
					num = ((int)num2 * -1048944305) ^ -889210637;
					continue;
				case 7u:
					LuaDLL.lua_pushstdcallcfunction(luaState, metaFunctions.gcFunction);
					LuaDLL.lua_settable(luaState, -3);
					num = (int)((num2 * 480062550) ^ 0x4BEA507C);
					continue;
				case 6u:
					LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4112679809u));
					num = ((int)num2 * -1804982488) ^ 0x3894BCAB;
					continue;
				case 1u:
					LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3959348494u));
					num = (int)(num2 * 23230226) ^ -1475494043;
					continue;
				case 3u:
					LuaDLL.lua_settable(luaState, -3);
					num = (int)(num2 * 961685955) ^ -1532611427;
					continue;
				case 0u:
					LuaDLL.lua_pushstdcallcfunction(luaState, metaFunctions.newindexFunction);
					num = ((int)num2 * -1133507029) ^ -568414771;
					continue;
				case 9u:
					return;
				}
				break;
			}
		}
	}

	private void createClassMetatable(IntPtr luaState)
	{
		LuaDLL.luaL_newmetatable(luaState, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1375153255u));
		while (true)
		{
			int num = -2130215352;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -470494626)) % 9)
				{
				case 0u:
					break;
				default:
					return;
				case 6u:
					LuaDLL.lua_settable(luaState, -3);
					LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4154041690u));
					LuaDLL.lua_pushstdcallcfunction(luaState, metaFunctions.classNewindexFunction);
					LuaDLL.lua_settable(luaState, -3);
					LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3764655298u));
					LuaDLL.lua_pushstdcallcfunction(luaState, metaFunctions.callConstructorFunction);
					LuaDLL.lua_settable(luaState, -3);
					LuaDLL.lua_settop(luaState, -2);
					num = ((int)num2 * -918872554) ^ -575489880;
					continue;
				case 1u:
					LuaDLL.lua_pushstdcallcfunction(luaState, metaFunctions.classIndexFunction);
					num = ((int)num2 * -1371928066) ^ -724131140;
					continue;
				case 3u:
					LuaDLL.lua_settable(luaState, -3);
					num = (int)(num2 * 297897586) ^ -1052631186;
					continue;
				case 7u:
					LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(741052268u));
					num = (int)(num2 * 1093183513) ^ -183612712;
					continue;
				case 2u:
					LuaDLL.lua_pushstdcallcfunction(luaState, metaFunctions.gcFunction);
					LuaDLL.lua_settable(luaState, -3);
					num = ((int)num2 * -1278526146) ^ -2104436605;
					continue;
				case 5u:
					LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2003425470u));
					num = (int)((num2 * 941164433) ^ 0x3B85E699);
					continue;
				case 8u:
					LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3959348494u));
					LuaDLL.lua_pushstdcallcfunction(luaState, metaFunctions.toStringFunction);
					num = (int)((num2 * 963656459) ^ 0x18AF117A);
					continue;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private void setGlobalFunctions(IntPtr luaState)
	{
		LuaDLL.lua_pushstdcallcfunction(luaState, metaFunctions.indexFunction);
		while (true)
		{
			int num = -1767914563;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2095236712)) % 12)
				{
				case 3u:
					break;
				default:
					return;
				case 0u:
					LuaDLL.lua_pushstdcallcfunction(luaState, loadAssemblyFunction);
					LuaDLL.lua_setglobal(luaState, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(157331950u));
					LuaDLL.lua_pushstdcallcfunction(luaState, registerTableFunction);
					num = (int)(num2 * 826624214) ^ -335284668;
					continue;
				case 1u:
					LuaDLL.lua_setglobal(luaState, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2724017083u));
					LuaDLL.lua_pushstdcallcfunction(luaState, enumFromIntFunction);
					num = (int)((num2 * 1004001836) ^ 0x2C8E0322);
					continue;
				case 4u:
					LuaDLL.lua_pushstdcallcfunction(luaState, getConstructorSigFunction);
					LuaDLL.lua_setglobal(luaState, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(383744908u));
					num = (int)(num2 * 654177747) ^ -191550926;
					continue;
				case 11u:
					LuaDLL.lua_pushstdcallcfunction(luaState, getMethodSigFunction);
					num = (int)(num2 * 765145232) ^ -173894781;
					continue;
				case 9u:
					LuaDLL.lua_setglobal(luaState, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2894858504u));
					num = (int)((num2 * 1892990087) ^ 0x4EE8CB2);
					continue;
				case 2u:
					LuaDLL.lua_setglobal(luaState, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3816241955u));
					num = (int)((num2 * 527971681) ^ 0x3F77E634);
					continue;
				case 7u:
					LuaDLL.lua_setglobal(luaState, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1269325256u));
					num = ((int)num2 * -424927675) ^ -1799204881;
					continue;
				case 5u:
					LuaDLL.lua_pushstdcallcfunction(luaState, importTypeFunction);
					LuaDLL.lua_setglobal(luaState, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(308273922u));
					num = ((int)num2 * -210919254) ^ 0x27DFF1D6;
					continue;
				case 6u:
					LuaDLL.lua_pushstdcallcfunction(luaState, ctypeFunction);
					num = ((int)num2 * -2000804846) ^ 0x2E74DC95;
					continue;
				case 8u:
					LuaDLL.lua_setglobal(luaState, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3083535969u));
					LuaDLL.lua_pushstdcallcfunction(luaState, unregisterTableFunction);
					LuaDLL.lua_setglobal(luaState, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1903450157u));
					num = (int)((num2 * 1996146710) ^ 0x23B6A8B7);
					continue;
				case 10u:
					return;
				}
				break;
			}
		}
	}

	private void createFunctionMetatable(IntPtr luaState)
	{
		LuaDLL.luaL_newmetatable(luaState, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2042348358u));
		while (true)
		{
			int num = 1422573075;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x355E2AE9)) % 5)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2857123011u));
					LuaDLL.lua_pushstdcallcfunction(luaState, metaFunctions.execDelegateFunction);
					LuaDLL.lua_settable(luaState, -3);
					LuaDLL.lua_settop(luaState, -2);
					num = (int)((num2 * 199370957) ^ 0x21AB2FB9);
					continue;
				case 2u:
					LuaDLL.lua_settable(luaState, -3);
					num = (int)(num2 * 33639452) ^ -425128280;
					continue;
				case 3u:
					LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1157489904u));
					LuaDLL.lua_pushstdcallcfunction(luaState, metaFunctions.gcFunction);
					num = ((int)num2 * -504057652) ^ -528366432;
					continue;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	internal void throwError(IntPtr luaState, string message)
	{
		LuaDLL.luaL_error(luaState, message);
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int loadAssembly(IntPtr luaState)
	{
		ObjectTranslator objectTranslator = FromState(luaState);
		try
		{
			string text = LuaDLL.lua_tostring(luaState, 1);
			Assembly assembly = null;
			try
			{
				assembly = _200B_200F_206D_206E_206D_202B_206E_202C_200E_206D_202B_200D_206A_200E_206E_206A_202A_200C_206D_200D_206F_202A_202C_200F_206A_206C_200E_202E_206C_206B_206D_200D_206B_202A_200D_202C_206F_206D_206B_200E_202E(text);
			}
			catch (BadImageFormatException)
			{
			}
			if (assembly == null)
			{
				goto IL_0020;
			}
			goto IL_0087;
			IL_0087:
			int num;
			int num2;
			if (assembly == null)
			{
				num = -1979271105;
				num2 = num;
			}
			else
			{
				num = -1884291714;
				num2 = num;
			}
			goto IL_0025;
			IL_0020:
			num = -107104402;
			goto IL_0025;
			IL_0025:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num ^ -2028355057)) % 6)
				{
				case 0u:
					break;
				default:
					goto end_IL_0007;
				case 1u:
					assembly = _200C_206A_200B_206C_202D_200D_206D_206C_206D_200B_202A_202A_202C_200F_200D_202A_200D_206A_200F_200F_206D_206B_202C_202E_206F_206E_206E_202E_200E_206C_202D_200E_202E_206A_200F_202C_206C_206B_200C_202E_202E(_206B_202B_206C_200F_200F_202A_200F_206B_206A_200C_206E_206E_202B_202C_200B_206C_200B_206A_200E_202A_206B_202C_202E_206C_206B_200B_206A_202E_206E_206E_206E_206D_202A_206A_200B_200B_200B_206A_202E_206B_202E(text));
					num = (int)((num3 * 8789512) ^ 0x7BF0F028);
					continue;
				case 2u:
					objectTranslator.assemblies.Add(assembly);
					num = ((int)num3 * -727432341) ^ 0xDE981BB;
					continue;
				case 5u:
					goto IL_0087;
				case 3u:
				{
					int num4;
					int num5;
					if (objectTranslator.assemblies.Contains(assembly))
					{
						num4 = 1621891939;
						num5 = num4;
					}
					else
					{
						num4 = 1350807775;
						num5 = num4;
					}
					num = num4 ^ (int)(num3 * 1810064156);
					continue;
				}
				case 4u:
					goto end_IL_0007;
				}
				break;
			}
			goto IL_0020;
			end_IL_0007:;
		}
		catch (Exception ex2)
		{
			objectTranslator.throwError(luaState, _202E_200F_206A_206C_206F_202B_200F_200D_202D_206F_202C_206C_206C_200D_200B_202B_200C_202C_206E_202A_202B_206C_200F_202E_202E_200D_200F_206A_200F_202E_206D_202D_206F_206C_202E_202B_202A_206B_200C_206F_202E(ex2));
		}
		return 0;
	}

	internal Type FindType(string className)
	{
		List<Assembly>.Enumerator enumerator = assemblies.GetEnumerator();
		try
		{
			Type result = default(Type);
			Type type = default(Type);
			while (true)
			{
				IL_0061:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -198893498;
					num2 = num;
				}
				else
				{
					num = -103590539;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -1731642460)) % 6)
					{
					case 2u:
						num = -103590539;
						continue;
					default:
						goto end_IL_0013;
					case 5u:
						result = type;
						num = ((int)num3 * -457672151) ^ 0x34A3A6B4;
						continue;
					case 4u:
						break;
					case 1u:
					{
						Assembly current = enumerator.Current;
						type = _200C_206B_206F_206E_206E_206B_200B_202C_206B_206C_202D_200D_206D_206E_202D_206B_202C_200F_200F_206C_206A_206E_200E_200C_200D_202E_200E_206F_200D_206D_200F_200C_202E_206C_206E_206E_200F_200C_206B_202E(current, className);
						int num4;
						if (type == null)
						{
							num = -1365131218;
							num4 = num;
						}
						else
						{
							num = -1184025467;
							num4 = num;
						}
						continue;
					}
					case 0u:
						goto end_IL_0013;
					case 3u:
						return result;
					}
					goto IL_0061;
					continue;
					end_IL_0013:
					break;
				}
				break;
			}
		}
		finally
		{
			_202E_202C_206D_202D_206F_206D_200B_202D_202C_202A_202B_202B_202E_202C_202C_202D_202A_206A_202B_200C_206F_202E_200B_206C_206C_206A_202A_206E_200B_206F_202B_206F_200E_202D_202E_206D_206D_206B_200E_202E((IDisposable)enumerator);
		}
		return null;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int importType(IntPtr luaState)
	{
		ObjectTranslator objectTranslator = FromState(luaState);
		string className = LuaDLL.lua_tostring(luaState, 1);
		Type type = default(Type);
		while (true)
		{
			int num = -866351265;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1824600260)) % 6)
				{
				case 0u:
					break;
				case 1u:
				{
					type = objectTranslator.FindType(className);
					int num3;
					int num4;
					if (type == null)
					{
						num3 = 1077094440;
						num4 = num3;
					}
					else
					{
						num3 = 1160195243;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1258124386);
					continue;
				}
				case 5u:
					objectTranslator.pushType(luaState, type);
					num = (int)((num2 * 1308522931) ^ 0x57E7C097);
					continue;
				case 4u:
					LuaDLL.lua_pushnil(luaState);
					num = -267687573;
					continue;
				case 2u:
					num = ((int)num2 * -1884735509) ^ 0x184C5F7F;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int registerTable(IntPtr luaState)
	{
		ObjectTranslator objectTranslator = FromState(luaState);
		if (LuaDLL.lua_type(luaState, 1) == LuaTypes.LUA_TTABLE)
		{
			goto IL_0014;
		}
		goto IL_00b3;
		IL_0014:
		int num = -1873169703;
		goto IL_0019;
		IL_0019:
		object classInstance = default(object);
		int index = default(int);
		LuaTable table = default(LuaTable);
		Type type = default(Type);
		string text = default(string);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1575015040)) % 22)
			{
			case 9u:
				break;
			case 20u:
				objectTranslator.pushObject(luaState, classInstance, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2180736149u));
				LuaDLL.lua_newtable(luaState);
				num = ((int)num2 * -1713950443) ^ -508531187;
				continue;
			case 21u:
				goto IL_00b3;
			case 12u:
				objectTranslator.pushNewObject(luaState, classInstance, index, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4037208823u));
				num = (int)(num2 * 23134451) ^ -170288150;
				continue;
			case 13u:
				LuaDLL.lua_pushvalue(luaState, -3);
				num = ((int)num2 * -534197485) ^ 0x404F2B64;
				continue;
			case 5u:
				table = objectTranslator.getTable(luaState, 1);
				num = (int)(num2 * 1024426038) ^ -1894350418;
				continue;
			case 16u:
				classInstance = CodeGeneration.Instance.GetClassInstance(type, table);
				num = ((int)num2 * -1022928462) ^ -1097824488;
				continue;
			case 6u:
			{
				type = objectTranslator.FindType(text);
				int num5;
				int num6;
				if (type != null)
				{
					num5 = 653045358;
					num6 = num5;
				}
				else
				{
					num5 = 1249196195;
					num6 = num5;
				}
				num = num5 ^ ((int)num2 * -522405750);
				continue;
			}
			case 17u:
				LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1690598031u));
				LuaDLL.lua_pushvalue(luaState, -3);
				num = (int)(num2 * 1376342525) ^ -2095083503;
				continue;
			case 4u:
				LuaDLL.lua_settable(luaState, -3);
				num = (int)((num2 * 539378345) ^ 0x210083E9);
				continue;
			case 3u:
				LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(690516087u));
				num = ((int)num2 * -1354202672) ^ 0x166F497C;
				continue;
			case 19u:
				LuaDLL.lua_settable(luaState, -3);
				LuaDLL.lua_setmetatable(luaState, 1);
				num = ((int)num2 * -1873453561) ^ -525153966;
				continue;
			case 15u:
				objectTranslator.throwError(luaState, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(770562340u));
				num = -1135736312;
				continue;
			case 1u:
				objectTranslator.throwError(luaState, _206D_206E_200D_200F_206A_206C_200C_206D_206D_200E_200E_202C_200B_202E_200D_206E_206B_202A_206C_206C_200F_200D_200D_200C_200B_202A_206D_202C_206C_206F_202B_202B_202A_200F_202B_200F_200D_202C_206B_202E_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1601217541u), text, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3978967768u)));
				num = -1730399148;
				continue;
			case 18u:
				LuaDLL.lua_rawset(luaState, 1);
				num = ((int)num2 * -146988713) ^ 0x4B59A8E6;
				continue;
			case 2u:
				text = LuaDLL.lua_tostring(luaState, 2);
				num = (int)(num2 * 2128371060) ^ -1635972337;
				continue;
			case 7u:
			{
				int num3;
				int num4;
				if (text == null)
				{
					num3 = -470538477;
					num4 = num3;
				}
				else
				{
					num3 = -1084183702;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -955923210);
				continue;
			}
			case 14u:
				index = objectTranslator.addObject(classInstance);
				num = ((int)num2 * -2052525026) ^ 0x15E70E54;
				continue;
			case 11u:
				LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1526095227u));
				num = (int)((num2 * 713281550) ^ 0x44BF44AB);
				continue;
			default:
				return 0;
			}
			break;
		}
		goto IL_0014;
		IL_00b3:
		objectTranslator.throwError(luaState, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(88460738u));
		num = -304053572;
		goto IL_0019;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int unregisterTable(IntPtr luaState)
	{
		ObjectTranslator objectTranslator = FromState(luaState);
		try
		{
			if (LuaDLL.lua_getmetatable(luaState, 1) != 0)
			{
				goto IL_0013;
			}
			goto IL_01d2;
			IL_0013:
			int num = -366723927;
			goto IL_0018;
			IL_0018:
			object rawNetObject = default(object);
			FieldInfo fieldInfo = default(FieldInfo);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -498004872)) % 16)
				{
				case 5u:
					break;
				default:
					goto end_IL_0007;
				case 13u:
					LuaDLL.lua_pushnil(luaState);
					num = (int)((num2 * 1147380826) ^ 0x1954414A);
					continue;
				case 3u:
					LuaDLL.lua_gettable(luaState, -2);
					rawNetObject = objectTranslator.getRawNetObject(luaState, -1);
					num = (int)((num2 * 640253153) ^ 0x19F4D994);
					continue;
				case 11u:
					objectTranslator.throwError(luaState, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(101154860u));
					num = (int)((num2 * 1290387241) ^ 0x1F48277C);
					continue;
				case 6u:
					num = ((int)num2 * -930976473) ^ 0x386A4BE6;
					continue;
				case 8u:
					LuaDLL.lua_pushnil(luaState);
					LuaDLL.lua_settable(luaState, 1);
					num = (int)(num2 * 1315954824) ^ -1917020706;
					continue;
				case 10u:
					LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4114156129u));
					num = ((int)num2 * -1629712990) ^ -221625212;
					continue;
				case 0u:
					LuaDLL.lua_setmetatable(luaState, 1);
					num = ((int)num2 * -366839553) ^ -38351406;
					continue;
				case 7u:
					fieldInfo = _202C_200C_200F_206E_200D_202E_202C_206D_206E_206A_206D_200E_200F_202C_206D_200D_202C_202D_202C_200E_206F_200B_200E_202C_200F_206D_200E_200C_202A_200B_200F_200C_206E_206A_206E_202B_206C_200D_206D_206E_202E(_202C_200C_200F_206D_200C_202E_202E_206E_202A_202D_206D_200D_206B_206F_200D_206C_200F_202E_206E_206C_202B_206D_200C_200D_202A_200F_202E_200D_206A_206E_202C_206A_206A_206A_206A_200E_200D_206F_206F_202A_202E(rawNetObject), global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3573596477u));
					num = -1878555818;
					continue;
				case 12u:
					objectTranslator.throwError(luaState, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(101154860u));
					num = ((int)num2 * -635902931) ^ -743771907;
					continue;
				case 9u:
					_206B_206C_206C_200D_200C_202A_200D_206E_202A_202B_206F_200E_206B_200F_206C_200C_206E_206F_202C_206A_206A_200F_206C_202E_206F_200D_206B_206C_202B_200E_202D_200B_200D_202C_206C_206D_202C_202B_206D_202C_202E(fieldInfo, rawNetObject, (object)null);
					num = -1832290603;
					continue;
				case 14u:
				{
					int num5;
					int num6;
					if (fieldInfo == null)
					{
						num5 = -9518192;
						num6 = num5;
					}
					else
					{
						num5 = -1029073499;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -999341914);
					continue;
				}
				case 15u:
				{
					int num3;
					int num4;
					if (rawNetObject != null)
					{
						num3 = -1267515671;
						num4 = num3;
					}
					else
					{
						num3 = -2004830171;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1372415686);
					continue;
				}
				case 2u:
					goto IL_01d2;
				case 1u:
					LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2003425470u));
					num = ((int)num2 * -878887679) ^ 0x687F7A;
					continue;
				case 4u:
					goto end_IL_0007;
				}
				break;
			}
			goto IL_0013;
			IL_01d2:
			objectTranslator.throwError(luaState, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4132910294u));
			num = -1535458580;
			goto IL_0018;
			end_IL_0007:;
		}
		catch (Exception ex)
		{
			while (true)
			{
				IL_0213:
				int num7 = -1541554472;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num7 ^ -498004872)) % 3)
					{
					case 0u:
						break;
					default:
						goto end_IL_0218;
					case 1u:
						goto IL_0236;
					case 2u:
						goto end_IL_0218;
					}
					goto IL_0213;
					IL_0236:
					objectTranslator.throwError(luaState, _202E_200F_206A_206C_206F_202B_200F_200D_202D_206F_202C_206C_206C_200D_200B_202B_200C_202C_206E_202A_202B_206C_200F_202E_202E_200D_200F_206A_200F_202E_206D_202D_206F_206C_202E_202B_202A_206B_200C_206F_202E(ex));
					num7 = (int)(num2 * 224522405) ^ -1265207767;
					continue;
					end_IL_0218:
					break;
				}
				break;
			}
		}
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int getMethodSignature(IntPtr luaState)
	{
		ObjectTranslator objectTranslator = FromState(luaState);
		int num = LuaDLL.luanet_checkudata(luaState, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1416029878u));
		IReflect reflect = default(IReflect);
		object obj = default(object);
		int num4 = default(int);
		string text = default(string);
		Type[] array = default(Type[]);
		while (true)
		{
			int num2 = -461880128;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1138244628)) % 15)
				{
				case 3u:
					break;
				case 14u:
					num2 = ((int)num3 * -48828223) ^ 0x5F1B3245;
					continue;
				case 10u:
					reflect = _202C_200C_200F_206D_200C_202E_202E_206E_202A_202D_206D_200D_206B_206F_200D_206C_200F_202E_206E_206C_202B_206D_200C_200D_202A_200F_202E_200D_206A_206E_202C_206A_206A_206A_206A_200E_200D_206F_206F_202A_202E(obj);
					num2 = -417417596;
					continue;
				case 4u:
					objectTranslator.throwError(luaState, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1121290333u));
					num2 = ((int)num3 * -1742924373) ^ 0x3EF94692;
					continue;
				case 0u:
					num4 = 0;
					num2 = ((int)num3 * -1473304665) ^ 0x2FF3ACA1;
					continue;
				case 12u:
				{
					obj = objectTranslator.getRawNetObject(luaState, 1);
					int num6;
					if (obj != null)
					{
						num2 = -625199797;
						num6 = num2;
					}
					else
					{
						num2 = -399237051;
						num6 = num2;
					}
					continue;
				}
				case 9u:
					text = LuaDLL.lua_tostring(luaState, 2);
					array = new Type[LuaDLL.lua_gettop(luaState) - 2];
					num2 = -1069028601;
					continue;
				case 1u:
					LuaDLL.lua_pushnil(luaState);
					num2 = (int)(num3 * 887862699) ^ -992239288;
					continue;
				case 5u:
					obj = null;
					num2 = ((int)num3 * -1014570486) ^ -2066259957;
					continue;
				case 11u:
					return 1;
				case 6u:
					reflect = (IReflect)objectTranslator.objects[num];
					num2 = (int)((num3 * 1580678606) ^ 0x364E70DB);
					continue;
				case 13u:
					array[num4] = objectTranslator.FindType(LuaDLL.lua_tostring(luaState, num4 + 3));
					num2 = -1570506757;
					continue;
				case 2u:
				{
					int num7;
					int num8;
					if (num == -1)
					{
						num7 = -562569976;
						num8 = num7;
					}
					else
					{
						num7 = -65055364;
						num8 = num7;
					}
					num2 = num7 ^ ((int)num3 * -1457540584);
					continue;
				}
				case 8u:
					num4++;
					num2 = (int)(num3 * 929697456) ^ -1481915588;
					continue;
				default:
					if (num4 >= array.Length)
					{
						try
						{
							MethodInfo methodInfo = _202A_200E_206F_206E_200E_206D_200C_202E_206D_202A_200D_200F_206B_202A_206F_200B_202E_202B_202C_206B_202E_206C_202C_202D_206E_202B_202B_206A_200D_206A_206A_206A_202B_202A_206D_202C_206E_200E_200C_200E_202E(reflect, text, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy, (Binder)null, array, (ParameterModifier[])null);
							objectTranslator.pushFunction(luaState, new LuaMethodWrapper(objectTranslator, obj, reflect, methodInfo).call);
						}
						catch (Exception ex)
						{
							while (true)
							{
								IL_0203:
								int num5 = -234607358;
								while (true)
								{
									switch ((num3 = (uint)(num5 ^ -1138244628)) % 3)
									{
									case 0u:
										break;
									case 1u:
										goto IL_0226;
									default:
										LuaDLL.lua_pushnil(luaState);
										goto end_IL_0208;
									}
									goto IL_0203;
									IL_0226:
									objectTranslator.throwError(luaState, _202E_200F_206A_206C_206F_202B_200F_200D_202D_206F_202C_206C_206C_200D_200B_202B_200C_202C_206E_202A_202B_206C_200F_202E_202E_200D_200F_206A_200F_202E_206D_202D_206F_206C_202E_202B_202A_206B_200C_206F_202E(ex));
									num5 = ((int)num3 * -1919393131) ^ -1949144273;
									continue;
									end_IL_0208:
									break;
								}
								break;
							}
						}
						return 1;
					}
					goto case 13u;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int getConstructorSignature(IntPtr luaState)
	{
		ObjectTranslator objectTranslator = FromState(luaState);
		IReflect reflect = null;
		int num = LuaDLL.luanet_checkudata(luaState, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1375153255u));
		int num4 = default(int);
		Type[] array = default(Type[]);
		while (true)
		{
			int num2 = 1006464516;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x13EA2C5B)) % 9)
				{
				case 8u:
					break;
				case 6u:
					num4 = 0;
					num2 = (int)(num3 * 708504337) ^ -20009587;
					continue;
				case 1u:
				{
					int num8;
					if (reflect == null)
					{
						num2 = 1384032948;
						num8 = num2;
					}
					else
					{
						num2 = 1032541863;
						num8 = num2;
					}
					continue;
				}
				case 4u:
					objectTranslator.throwError(luaState, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2754202061u));
					num2 = ((int)num3 * -676423316) ^ -483093133;
					continue;
				case 7u:
					array = new Type[LuaDLL.lua_gettop(luaState) - 1];
					num2 = 1582575580;
					continue;
				case 3u:
					array[num4] = objectTranslator.FindType(LuaDLL.lua_tostring(luaState, num4 + 2));
					num4++;
					num2 = 2009040250;
					continue;
				case 2u:
				{
					int num6;
					int num7;
					if (num != -1)
					{
						num6 = 1835253601;
						num7 = num6;
					}
					else
					{
						num6 = 57453821;
						num7 = num6;
					}
					num2 = num6 ^ ((int)num3 * -291157655);
					continue;
				}
				case 5u:
					reflect = (IReflect)objectTranslator.objects[num];
					num2 = (int)((num3 * 2034346566) ^ 0x1DD56104);
					continue;
				default:
					if (num4 >= array.Length)
					{
						try
						{
							ConstructorInfo constructorInfo = _200D_200E_202E_206C_200E_206A_202A_200B_206C_200B_206A_202C_202D_206F_200D_202E_202A_202E_206F_200F_200F_206F_200E_202A_206F_202D_206C_200F_206B_202C_206E_202E_200F_200C_206F_202A_200C_200F_206E_206E_202E(_200E_206B_206D_202A_200E_202D_206B_200B_202B_206D_200F_202B_206A_206A_200D_200D_200C_202E_200D_200E_200D_206D_206B_200C_202A_200E_206A_202E_206F_206C_200C_206C_200D_202E_200E_202C_206E_206A_200F_200E_202E(reflect), array);
							objectTranslator.pushFunction(luaState, new LuaMethodWrapper(objectTranslator, null, reflect, constructorInfo).call);
						}
						catch (Exception ex)
						{
							objectTranslator.throwError(luaState, _202E_200F_206A_206C_206F_202B_200F_200D_202D_206F_202C_206C_206C_200D_200B_202B_200C_202C_206E_202A_202B_206C_200F_202E_202E_200D_200F_206A_200F_202E_206D_202D_206F_206C_202E_202B_202A_206B_200C_206F_202E(ex));
							while (true)
							{
								IL_016a:
								int num5 = 2034741025;
								while (true)
								{
									switch ((num3 = (uint)(num5 ^ 0x13EA2C5B)) % 3)
									{
									case 2u:
										break;
									default:
										goto end_IL_016f;
									case 1u:
										goto IL_018d;
									case 0u:
										goto end_IL_016f;
									}
									goto IL_016a;
									IL_018d:
									LuaDLL.lua_pushnil(luaState);
									num5 = (int)((num3 * 1633959894) ^ 0x2574D5C1);
									continue;
									end_IL_016f:
									break;
								}
								break;
							}
						}
						return 1;
					}
					goto case 3u;
				}
				break;
			}
		}
	}

	private Type typeOf(IntPtr luaState, int idx)
	{
		int num = LuaDLL.luanet_checkudata(luaState, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1375153255u));
		ProxyType proxyType = default(ProxyType);
		while (true)
		{
			int num2 = 2065439079;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x33C5E655)) % 5)
				{
				case 3u:
					break;
				case 4u:
				{
					int num4;
					int num5;
					if (num == -1)
					{
						num4 = -383421505;
						num5 = num4;
					}
					else
					{
						num4 = -547186144;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num3 * -130438189);
					continue;
				}
				case 0u:
					return null;
				case 2u:
					proxyType = (ProxyType)objects[num];
					num2 = 1008463001;
					continue;
				default:
					return proxyType.UnderlyingSystemType;
				}
				break;
			}
		}
	}

	public int pushError(IntPtr luaState, string msg)
	{
		LuaDLL.lua_pushnil(luaState);
		LuaDLL.lua_pushstring(luaState, msg);
		return 2;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ctype(IntPtr luaState)
	{
		ObjectTranslator objectTranslator = FromState(luaState);
		Type type = default(Type);
		while (true)
		{
			int num = 1521644222;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)(num ^ 0x6E0E91F3)) % 4)
				{
				case 0u:
					break;
				case 1u:
				{
					type = objectTranslator.typeOf(luaState, 1);
					int num4;
					if (type == null)
					{
						num3 = -954534320;
						num4 = num3;
					}
					else
					{
						num3 = -859315355;
						num4 = num3;
					}
					goto IL_0047;
				}
				case 3u:
					return objectTranslator.pushError(luaState, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3555560667u));
				default:
					objectTranslator.pushObject(luaState, type, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4165758674u));
					return 1;
				}
				break;
				IL_0047:
				num = num3 ^ ((int)num2 * -1916587708);
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int enumFromInt(IntPtr luaState)
	{
		ObjectTranslator objectTranslator = FromState(luaState);
		Type type = objectTranslator.typeOf(luaState, 1);
		if (type != null)
		{
			string text = default(string);
			LuaTypes luaTypes = default(LuaTypes);
			object o = default(object);
			int num3 = default(int);
			while (true)
			{
				int num = -1204704441;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1889060166)) % 11)
					{
					case 7u:
						break;
					case 8u:
						text = LuaDLL.lua_tostring(luaState, 2);
						num = ((int)num2 * -751650548) ^ -800866041;
						continue;
					case 9u:
					{
						int num6;
						int num7;
						if (luaTypes != LuaTypes.LUA_TNUMBER)
						{
							num6 = -1066203642;
							num7 = num6;
						}
						else
						{
							num6 = -1872556759;
							num7 = num6;
						}
						num = num6 ^ ((int)num2 * -737586832);
						continue;
					}
					case 10u:
					{
						int num4;
						int num5;
						if (_206F_202C_206D_206B_206C_202A_206E_206F_206B_206B_206E_200D_200C_206E_206A_202E_206E_202B_206D_200B_206F_206D_200D_206B_202C_202D_202C_202A_206E_206C_206F_200B_206C_206D_206B_200B_200F_202B_202A_202B_202E(type))
						{
							num4 = 113233405;
							num5 = num4;
						}
						else
						{
							num4 = 1284645007;
							num5 = num4;
						}
						num = num4 ^ (int)(num2 * 1828427976);
						continue;
					}
					case 3u:
						goto end_IL_0016;
					case 4u:
						o = null;
						luaTypes = LuaDLL.lua_type(luaState, 2);
						num = -1799057105;
						continue;
					case 6u:
						goto IL_0101;
					case 5u:
						num3 = (int)LuaDLL.lua_tonumber(luaState, 2);
						num = (int)(num2 * 191555036) ^ -1461081793;
						continue;
					case 1u:
						o = _206E_200E_206A_202C_206B_206C_200C_202A_206D_202A_202E_206B_206C_206E_206C_200E_206C_200B_206D_200D_206C_202C_202B_202A_206E_206A_202D_200E_202E_206A_202D_202E_206B_202E_206C_202A_206C_206D_206B_200F_202E(type, num3);
						num = (int)(num2 * 1501915665) ^ -2095342773;
						continue;
					default:
						goto IL_014b;
					case 0u:
						goto IL_01d1;
					}
					break;
					IL_014b:
					string text2 = null;
					try
					{
						o = _202C_200F_202D_200E_206D_206C_200E_206D_206A_206F_200D_202C_200E_206C_206E_206B_200B_206B_200F_206B_202E_200C_202B_200B_206A_206C_206E_202E_202A_206A_202C_202A_206B_206C_200C_206C_206C_200D_202B_200C_202E(type, text);
					}
					catch (ArgumentException ex)
					{
						text2 = _200D_206E_202A_202B_202A_206E_200D_200F_202D_202E_206B_206C_202A_200C_202E_200C_206B_202E_206F_202E_202D_206A_206F_206F_202A_200F_200E_206E_202E_206F_200D_202C_200C_202D_206E_200C_202A_200C_206F_206C_202E(ex);
					}
					if (text2 != null)
					{
						while (true)
						{
							switch ((num2 = 1541077056u) % 5)
							{
							case 3u:
								break;
							case 1u:
								return objectTranslator.pushError(luaState, text2);
							case 0u:
								goto end_IL_016a;
							default:
								goto IL_01d1;
							}
							continue;
							end_IL_016a:
							break;
						}
						goto IL_01b8;
					}
					goto IL_01d1;
					IL_0101:
					if (luaTypes == LuaTypes.LUA_TSTRING)
					{
						num = -222105760;
						continue;
					}
					goto IL_01b8;
					IL_01b8:
					return objectTranslator.pushError(luaState, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2095051309u));
					IL_01d1:
					objectTranslator.pushObject(luaState, o, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3460890899u));
					return 1;
				}
				continue;
				end_IL_0016:
				break;
			}
		}
		return objectTranslator.pushError(luaState, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(273648401u));
	}

	internal void pushType(IntPtr luaState, Type t)
	{
		pushObject(luaState, new ProxyType(t), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1416029878u));
	}

	internal void pushFunction(IntPtr luaState, LuaCSFunction func)
	{
		pushObject(luaState, func, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(460116092u));
	}

	private bool IsValueType(Type t)
	{
		bool value = false;
		while (true)
		{
			int num = -99593598;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1940997577)) % 4)
				{
				case 0u:
					break;
				case 1u:
				{
					int num3;
					int num4;
					if (valueTypeMap.TryGetValue(t, out value))
					{
						num3 = 614830559;
						num4 = num3;
					}
					else
					{
						num3 = 1613535970;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 297421646);
					continue;
				}
				case 3u:
					value = _202B_206B_200D_202B_202A_200C_200E_200F_206F_206B_200B_202E_202A_202C_206E_206B_202D_200E_206A_200D_206F_202B_206D_202E_202D_202D_200C_206C_206D_200D_202A_202E_206E_202D_200C_202C_202A_202E_206D_202D_202E(t);
					valueTypeMap.Add(t, value);
					num = ((int)num2 * -1598032531) ^ -38874226;
					continue;
				default:
					return value;
				}
				break;
			}
		}
	}

	public void pushObject(IntPtr luaState, object o, string metatable)
	{
		if (o == null)
		{
			goto IL_0006;
		}
		goto IL_00ed;
		IL_0006:
		int num = -354060176;
		goto IL_000b;
		IL_000b:
		int value = default(int);
		bool flag = default(bool);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -409893225)) % 11)
			{
			case 6u:
				break;
			default:
				return;
			case 10u:
				collectObject(o, value);
				num = -1215554284;
				continue;
			case 9u:
				return;
			case 2u:
			{
				int num5;
				int num6;
				if (LuaDLL.tolua_pushudata(luaState, weakTableRef, value))
				{
					num5 = -280532675;
					num6 = num5;
				}
				else
				{
					num5 = -787585202;
					num6 = num5;
				}
				num = num5 ^ (int)(num2 * 443710408);
				continue;
			}
			case 0u:
				return;
			case 4u:
			{
				int num7;
				int num8;
				if (!objectsBackMap.TryGetValue(o, out value))
				{
					num7 = 1811932770;
					num8 = num7;
				}
				else
				{
					num7 = 1097626974;
					num8 = num7;
				}
				num = num7 ^ ((int)num2 * -136853362);
				continue;
			}
			case 1u:
				LuaDLL.lua_pushnil(luaState);
				num = (int)((num2 * 786928687) ^ 0x73D0BB23);
				continue;
			case 7u:
				goto IL_00ed;
			case 3u:
				value = addObject(o, flag);
				pushNewObject(luaState, o, value, metatable);
				num = -931136357;
				continue;
			case 8u:
			{
				int num3;
				int num4;
				if (flag)
				{
					num3 = 465932768;
					num4 = num3;
				}
				else
				{
					num3 = 1365185166;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 484168717);
				continue;
			}
			case 5u:
				return;
			}
			break;
		}
		goto IL_0006;
		IL_00ed:
		value = -1;
		flag = _202B_206B_200D_202B_202A_200C_200E_200F_206F_206B_200B_202E_202A_202C_206E_206B_202D_200E_206A_200D_206F_202B_206D_202E_202D_202D_200C_206C_206D_200D_202A_202E_206E_202D_200C_202C_202A_202E_206D_202D_202E(_202C_200C_200F_206D_200C_202E_202E_206E_202A_202D_206D_200D_206B_206F_200D_206C_200F_202E_206E_206C_202B_206D_200C_200D_202A_200F_202E_200D_206A_206E_202C_206A_206A_206A_206A_200E_200D_206F_206F_202A_202E(o));
		num = -781338285;
		goto IL_000b;
	}

	private static void PushMetaTable(IntPtr L, Type t)
	{
		int value = -1;
		if (!typeMetaMap.TryGetValue(t, out value))
		{
			goto IL_0011;
		}
		goto IL_0046;
		IL_0011:
		int num = 424481655;
		goto IL_0016;
		IL_0016:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x60C83F6B)) % 7)
			{
			case 4u:
				break;
			default:
				return;
			case 2u:
				goto IL_0046;
			case 0u:
				return;
			case 3u:
			{
				LuaDLL.luaL_getmetatable(L, _202A_202A_202E_200D_200F_202E_200E_200D_206E_206A_202C_202B_206A_202B_200D_206D_200D_206D_200B_206B_206B_202C_206D_202B_206A_206B_206B_206B_206C_206A_202B_200E_206C_200D_202A_206E_200B_206C_202B_206A_202E(t));
				int num3;
				int num4;
				if (LuaDLL.lua_isnil(L, -1))
				{
					num3 = 894914400;
					num4 = num3;
				}
				else
				{
					num3 = 243763992;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -1886740441);
				continue;
			}
			case 5u:
				LuaDLL.lua_pushvalue(L, -1);
				value = LuaDLL.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				num = ((int)num2 * -63215661) ^ 0x232E6E33;
				continue;
			case 1u:
				typeMetaMap.Add(t, value);
				num = (int)(num2 * 1749453519) ^ -1388908889;
				continue;
			case 6u:
				return;
			}
			break;
		}
		goto IL_0011;
		IL_0046:
		LuaDLL.lua_getref(L, value);
		num = 869884437;
		goto IL_0016;
	}

	private void pushNewObject(IntPtr luaState, object o, int index, string metatable)
	{
		LuaDLL.lua_getref(luaState, weakTableRef);
		LuaDLL.luanet_newudata(luaState, index);
		Type type = default(Type);
		string meta = default(string);
		while (true)
		{
			int num = 976968276;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3D44AD24)) % 21)
				{
				case 16u:
					break;
				default:
					return;
				case 0u:
					LuaDLL.lua_pushstdcallcfunction(luaState, metaFunctions.newindexFunction);
					LuaDLL.lua_rawset(luaState, -3);
					num = ((int)num2 * -842223900) ^ 0x166A1638;
					continue;
				case 3u:
					LuaDLL.lua_newtable(luaState);
					LuaDLL.lua_rawset(luaState, -3);
					LuaDLL.lua_pushlightuserdata(luaState, LuaDLL.luanet_gettag());
					num = (int)((num2 * 1212046983) ^ 0x5F28685C);
					continue;
				case 19u:
				{
					type = _202C_200C_200F_206D_200C_202E_202E_206E_202A_202D_206D_200D_206B_206F_200D_206C_200F_202E_206E_206C_202B_206D_200C_200D_202A_200F_202E_200D_206A_206E_202C_206A_206A_206A_206A_200E_200D_206F_206F_202A_202E(o);
					PushMetaTable(luaState, _202C_200C_200F_206D_200C_202E_202E_206E_202A_202D_206D_200D_206B_206F_200D_206C_200F_202E_206E_206C_202B_206D_200C_200D_202A_200F_202E_200D_206A_206E_202C_206A_206A_206A_206A_200E_200D_206F_206F_202A_202E(o));
					int num5;
					int num6;
					if (!LuaDLL.lua_isnil(luaState, -1))
					{
						num5 = -1004220880;
						num6 = num5;
					}
					else
					{
						num5 = -586079160;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1593502106);
					continue;
				}
				case 9u:
					LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3959348494u));
					num = ((int)num2 * -700157276) ^ -613545327;
					continue;
				case 1u:
					LuaDLL.lua_remove(luaState, -2);
					num = (int)((num2 * 378310165) ^ 0x56F12E64);
					continue;
				case 6u:
					LuaDLL.lua_rawset(luaState, -3);
					LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2133904597u));
					LuaDLL.lua_pushstdcallcfunction(luaState, metaFunctions.gcFunction);
					LuaDLL.lua_rawset(luaState, -3);
					num = ((int)num2 * -632314710) ^ 0x7F560556;
					continue;
				case 18u:
					LuaDLL.lua_settop(luaState, -2);
					num = ((int)num2 * -1248254698) ^ -1604067512;
					continue;
				case 15u:
					LuaDLL.lua_pushnumber(luaState, 1.0);
					num = (int)((num2 * 1093540543) ^ 0x43D87889);
					continue;
				case 5u:
				case 13u:
					LuaDLL.lua_setmetatable(luaState, -2);
					LuaDLL.lua_pushvalue(luaState, -1);
					num = 161712867;
					continue;
				case 11u:
					LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(335377622u));
					num = ((int)num2 * -1516370999) ^ -2047834534;
					continue;
				case 2u:
					LuaDLL.lua_rawset(luaState, -3);
					LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1690598031u));
					LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2379230505u));
					num = (int)((num2 * 2029880108) ^ 0x20D691C4);
					continue;
				case 14u:
					LuaDLL.luaL_newmetatable(luaState, meta);
					num = (int)((num2 * 921909920) ^ 0x2277C27D);
					continue;
				case 10u:
				{
					int num3;
					int num4;
					if (!_206F_206C_206D_206A_202C_202A_202C_202D_202A_200F_202E_206E_206E_206B_206A_200D_206C_206B_206D_200E_200C_202B_200F_202A_200D_206B_200B_202D_200B_206F_206B_200F_200E_206F_200D_202D_200D_202C_206D_202C_202E(metatable, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2180736149u)))
					{
						num3 = -1207008045;
						num4 = num3;
					}
					else
					{
						num3 = -1196421766;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1214392629);
					continue;
				}
				case 17u:
					LuaDLL.lua_rawget(luaState, LuaIndexes.LUA_REGISTRYINDEX);
					num = ((int)num2 * -768457914) ^ -165696243;
					continue;
				case 7u:
					meta = _202A_202A_202E_200D_200F_202E_200E_200D_206E_206A_202C_202B_206A_202B_200D_206D_200D_206D_200B_206B_206B_202C_206D_202B_206A_206B_206B_206B_206C_206A_202B_200E_206C_200D_202A_206E_200B_206C_202B_206A_202E(type);
					num = ((int)num2 * -633794557) ^ -2114633433;
					continue;
				case 12u:
					LuaDLL.lua_pushstdcallcfunction(luaState, metaFunctions.toStringFunction);
					LuaDLL.lua_rawset(luaState, -3);
					LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1300677581u));
					num = (int)((num2 * 61577486) ^ 0xEE7045D);
					continue;
				case 8u:
					LuaDLL.lua_rawseti(luaState, -3, index);
					num = ((int)num2 * -1619223911) ^ -563926689;
					continue;
				case 4u:
					LuaDLL.luaL_getmetatable(luaState, metatable);
					num = 1882502478;
					continue;
				case 20u:
					return;
				}
				break;
			}
		}
	}

	public void PushNewValueObject(IntPtr luaState, object o, int index)
	{
		LuaDLL.luanet_newudata(luaState, index);
		Type type = _202C_200C_200F_206D_200C_202E_202E_206E_202A_202D_206D_200D_206B_206F_200D_206C_200F_202E_206E_206C_202B_206D_200C_200D_202A_200F_202E_200D_206A_206E_202C_206A_206A_206A_206A_200E_200D_206F_206F_202A_202E(o);
		string meta = default(string);
		while (true)
		{
			int num = 2131828976;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x594C121E)) % 20)
				{
				case 8u:
					break;
				default:
					return;
				case 3u:
					LuaDLL.lua_pushstdcallcfunction(luaState, metaFunctions.gcFunction);
					LuaDLL.lua_rawset(luaState, -3);
					num = ((int)num2 * -1451110787) ^ 0x255BE76E;
					continue;
				case 19u:
					LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3959348494u));
					num = ((int)num2 * -1772448604) ^ 0x348A5C8C;
					continue;
				case 16u:
					LuaDLL.lua_pushlightuserdata(luaState, LuaDLL.luanet_gettag());
					num = (int)((num2 * 1178585369) ^ 0x74F9F183);
					continue;
				case 10u:
					LuaDLL.lua_pushstdcallcfunction(luaState, metaFunctions.toStringFunction);
					num = ((int)num2 * -11886172) ^ -1484066766;
					continue;
				case 12u:
					LuaDLL.lua_rawset(luaState, -3);
					num = ((int)num2 * -889570325) ^ 0x4C429C15;
					continue;
				case 18u:
					LuaDLL.lua_setmetatable(luaState, -2);
					num = 1363992937;
					continue;
				case 13u:
					LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2003425470u));
					num = (int)((num2 * 1611469993) ^ 0x75E25E29);
					continue;
				case 1u:
					LuaDLL.lua_pushnumber(luaState, 1.0);
					num = (int)((num2 * 1291136661) ^ 0x715AAD12);
					continue;
				case 6u:
					LuaDLL.lua_rawset(luaState, -3);
					num = ((int)num2 * -1693683103) ^ -983582708;
					continue;
				case 2u:
					LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2379230505u));
					LuaDLL.lua_rawget(luaState, LuaIndexes.LUA_REGISTRYINDEX);
					num = (int)(num2 * 1045259977) ^ -2021746897;
					continue;
				case 11u:
					LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1526095227u));
					num = ((int)num2 * -725218490) ^ 0x7B9BCC04;
					continue;
				case 4u:
					LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2155746262u));
					LuaDLL.lua_newtable(luaState);
					num = ((int)num2 * -1244320300) ^ -1533015656;
					continue;
				case 5u:
					meta = _202A_202A_202E_200D_200F_202E_200E_200D_206E_206A_202C_202B_206A_202B_200D_206D_200D_206D_200B_206B_206B_202C_206D_202B_206A_206B_206B_206B_206C_206A_202B_200E_206C_200D_202A_206E_200B_206C_202B_206A_202E(type);
					LuaDLL.lua_settop(luaState, -2);
					num = (int)(num2 * 1406090524) ^ -1770518617;
					continue;
				case 9u:
					LuaDLL.luaL_newmetatable(luaState, meta);
					num = ((int)num2 * -444499178) ^ 0x57AC3908;
					continue;
				case 0u:
					LuaDLL.lua_pushstdcallcfunction(luaState, metaFunctions.newindexFunction);
					LuaDLL.lua_rawset(luaState, -3);
					num = (int)(num2 * 994333274) ^ -1491223388;
					continue;
				case 7u:
					LuaDLL.lua_rawset(luaState, -3);
					LuaDLL.lua_pushstring(luaState, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1157489904u));
					num = ((int)num2 * -1739385004) ^ -1965840731;
					continue;
				case 14u:
				{
					PushMetaTable(luaState, _202C_200C_200F_206D_200C_202E_202E_206E_202A_202D_206D_200D_206B_206F_200D_206C_200F_202E_206E_206C_202B_206D_200C_200D_202A_200F_202E_200D_206A_206E_202C_206A_206A_206A_206A_200E_200D_206F_206F_202A_202E(o));
					int num3;
					int num4;
					if (!LuaDLL.lua_isnil(luaState, -1))
					{
						num3 = -2147258046;
						num4 = num3;
					}
					else
					{
						num3 = -1624426143;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1351034741);
					continue;
				}
				case 17u:
					LuaDLL.lua_rawset(luaState, -3);
					num = ((int)num2 * -1030285227) ^ -274814218;
					continue;
				case 15u:
					return;
				}
				break;
			}
		}
	}

	internal object getAsType(IntPtr luaState, int stackPos, Type paramType)
	{
		ExtractValue extractValue = typeChecker.checkType(luaState, stackPos, paramType);
		while (true)
		{
			int num = 1009355120;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)(num ^ 0x107022EA)) % 4)
				{
				case 3u:
					break;
				case 2u:
				{
					int num4;
					if (extractValue == null)
					{
						num3 = 1650300594;
						num4 = num3;
					}
					else
					{
						num3 = 1025824371;
						num4 = num3;
					}
					goto IL_0046;
				}
				case 1u:
					return extractValue(luaState, stackPos);
				default:
					return null;
				}
				break;
				IL_0046:
				num = num3 ^ (int)(num2 * 330977672);
			}
		}
	}

	internal void collectObject(int udata)
	{
		object value;
		bool flag = objects.TryGetValue(udata, out value);
		while (true)
		{
			int num = -458289237;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -541927592)) % 6)
				{
				case 3u:
					break;
				default:
					return;
				case 0u:
					objectsBackMap.Remove(value);
					num = ((int)num2 * -1462298578) ^ 0x7AF98528;
					continue;
				case 2u:
				{
					objects.Remove(udata);
					int num5;
					int num6;
					if (value != null)
					{
						num5 = -1169281083;
						num6 = num5;
					}
					else
					{
						num5 = -501253140;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -133795345);
					continue;
				}
				case 1u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = -642175179;
						num8 = num7;
					}
					else
					{
						num7 = -442030607;
						num8 = num7;
					}
					num = num7 ^ ((int)num2 * -537624889);
					continue;
				}
				case 5u:
				{
					int num3;
					int num4;
					if (!_202B_206B_200D_202B_202A_200C_200E_200F_206F_206B_200B_202E_202A_202C_206E_206B_202D_200E_206A_200D_206F_202B_206D_202E_202D_202D_200C_206C_206D_200D_202A_202E_206E_202D_200C_202C_202A_202E_206D_202D_202E(_202C_200C_200F_206D_200C_202E_202E_206E_202A_202D_206D_200D_206B_206F_200D_206C_200F_202E_206E_206C_202B_206D_200C_200D_202A_200F_202E_200D_206A_206E_202C_206A_206A_206A_206A_200E_200D_206F_206F_202A_202E(value)))
					{
						num3 = -708658147;
						num4 = num3;
					}
					else
					{
						num3 = -1513564477;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -936483957);
					continue;
				}
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private void collectObject(object o, int udata)
	{
		objectsBackMap.Remove(o);
		objects.Remove(udata);
	}

	public int addObject(object obj)
	{
		int num = nextObj++;
		int num4 = default(int);
		while (true)
		{
			int num2 = 1779917414;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x5E165225)) % 4)
				{
				case 0u:
					break;
				case 3u:
				{
					num4 = num;
					objects[num4] = obj;
					int num5;
					int num6;
					if (_202B_206B_200D_202B_202A_200C_200E_200F_206F_206B_200B_202E_202A_202C_206E_206B_202D_200E_206A_200D_206F_202B_206D_202E_202D_202D_200C_206C_206D_200D_202A_202E_206E_202D_200C_202C_202A_202E_206D_202D_202E(_202C_200C_200F_206D_200C_202E_202E_206E_202A_202D_206D_200D_206B_206F_200D_206C_200F_202E_206E_206C_202B_206D_200C_200D_202A_200F_202E_200D_206A_206E_202C_206A_206A_206A_206A_200E_200D_206F_206F_202A_202E(obj)))
					{
						num5 = -817221045;
						num6 = num5;
					}
					else
					{
						num5 = -1748502236;
						num6 = num5;
					}
					num2 = num5 ^ (int)(num3 * 654819905);
					continue;
				}
				case 2u:
					objectsBackMap[obj] = num4;
					num2 = ((int)num3 * -36097358) ^ 0x69B6C82C;
					continue;
				default:
					return num4;
				}
				break;
			}
		}
	}

	public int addObject(object obj, bool isValueType)
	{
		int num = nextObj++;
		while (true)
		{
			int num2 = -1944572682;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -750259313)) % 4)
				{
				case 3u:
					break;
				case 1u:
				{
					objects[num] = obj;
					int num4;
					int num5;
					if (isValueType)
					{
						num4 = -1084349413;
						num5 = num4;
					}
					else
					{
						num4 = -502701499;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 806690612);
					continue;
				}
				case 2u:
					objectsBackMap[obj] = num;
					num2 = ((int)num3 * -1223858262) ^ -1051690013;
					continue;
				default:
					return num;
				}
				break;
			}
		}
	}

	public object getObject(IntPtr luaState, int index)
	{
		return LuaScriptMgr.GetVarObject(luaState, index);
	}

	internal LuaTable getTable(IntPtr luaState, int index)
	{
		LuaDLL.lua_pushvalue(luaState, index);
		return new LuaTable(LuaDLL.luaL_ref(luaState, LuaIndexes.LUA_REGISTRYINDEX), interpreter);
	}

	internal LuaFunction getFunction(IntPtr luaState, int index)
	{
		LuaDLL.lua_pushvalue(luaState, index);
		return new LuaFunction(LuaDLL.luaL_ref(luaState, LuaIndexes.LUA_REGISTRYINDEX), interpreter);
	}

	internal object getNetObject(IntPtr luaState, int index)
	{
		int num = LuaDLL.luanet_tonetobject(luaState, index);
		if (num != -1)
		{
			while (true)
			{
				uint num2;
				switch ((num2 = 320581987u) % 3)
				{
				case 2u:
					continue;
				case 1u:
					return objects[num];
				}
				break;
			}
		}
		return null;
	}

	internal object getRawNetObject(IntPtr luaState, int index)
	{
		int key = LuaDLL.luanet_rawnetobj(luaState, index);
		object value = null;
		objects.TryGetValue(key, out value);
		return value;
	}

	public void SetValueObject(IntPtr luaState, int stackPos, object obj)
	{
		int num = LuaDLL.luanet_rawnetobj(luaState, stackPos);
		while (true)
		{
			int num2 = 1406473044;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x592A6C17)) % 4)
				{
				case 0u:
					break;
				default:
					return;
				case 3u:
				{
					int num4;
					int num5;
					if (num == -1)
					{
						num4 = -1501190041;
						num5 = num4;
					}
					else
					{
						num4 = -1457917372;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 789297071);
					continue;
				}
				case 2u:
					objects[num] = obj;
					num2 = ((int)num3 * -449820334) ^ 0x79A0136;
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	internal int returnValues(IntPtr luaState, object[] returnValues)
	{
		if (LuaDLL.lua_checkstack(luaState, returnValues.Length + 5))
		{
			int num3 = default(int);
			while (true)
			{
				int num = 1744075435;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x6ADBAD06)) % 8)
					{
					case 0u:
						break;
					case 7u:
						goto IL_0046;
					case 4u:
						return returnValues.Length;
					case 3u:
						push(luaState, returnValues[num3]);
						num = 2044959448;
						continue;
					case 1u:
						num = ((int)num2 * -840641099) ^ 0x7358760C;
						continue;
					case 5u:
						num3 = 0;
						num = ((int)num2 * -1022019574) ^ 0xB419575;
						continue;
					case 6u:
						num3++;
						num = (int)(num2 * 351216952) ^ -231254343;
						continue;
					default:
						goto end_IL_0010;
					}
					break;
					IL_0046:
					int num4;
					if (num3 < returnValues.Length)
					{
						num = 1614619893;
						num4 = num;
					}
					else
					{
						num = 1119349738;
						num4 = num;
					}
				}
				continue;
				end_IL_0010:
				break;
			}
		}
		return 0;
	}

	internal object[] popValues(IntPtr luaState, int oldTop)
	{
		int num = LuaDLL.lua_gettop(luaState);
		if (oldTop == num)
		{
			goto IL_000b;
		}
		goto IL_0054;
		IL_000b:
		int num2 = 455842887;
		goto IL_0010;
		IL_0010:
		int num4 = default(int);
		List<object> list = default(List<object>);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ 0x459AE3C1)) % 8)
			{
			case 0u:
				break;
			case 3u:
				num4 = oldTop + 1;
				num2 = (int)((num3 * 1045298211) ^ 0x2113DAE2);
				continue;
			case 4u:
				goto IL_0054;
			case 1u:
				list.Add(getObject(luaState, num4));
				num4++;
				num2 = 1259846926;
				continue;
			case 7u:
				goto IL_007a;
			case 6u:
				return null;
			case 2u:
				num2 = (int)((num3 * 1805860279) ^ 0x5815AB08);
				continue;
			default:
				LuaDLL.lua_settop(luaState, oldTop);
				return list.ToArray();
			}
			break;
			IL_007a:
			int num5;
			if (num4 > num)
			{
				num2 = 1093817092;
				num5 = num2;
			}
			else
			{
				num2 = 512274240;
				num5 = num2;
			}
		}
		goto IL_000b;
		IL_0054:
		list = new List<object>();
		num2 = 1092858658;
		goto IL_0010;
	}

	internal object[] popValues(IntPtr luaState, int oldTop, Type[] popTypes)
	{
		int num = LuaDLL.lua_gettop(luaState);
		List<object> list = default(List<object>);
		int num7 = default(int);
		int num6 = default(int);
		while (true)
		{
			int num2 = 1306905215;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x4FC45267)) % 16)
				{
				case 15u:
					break;
				case 11u:
					list.Add(getAsType(luaState, num7, popTypes[num6]));
					num2 = 256122330;
					continue;
				case 9u:
				{
					int num10;
					if (num7 > num)
					{
						num2 = 505226109;
						num10 = num2;
					}
					else
					{
						num2 = 5673724;
						num10 = num2;
					}
					continue;
				}
				case 7u:
					num7++;
					num2 = (int)(num3 * 1598437120) ^ -848101266;
					continue;
				case 4u:
					return null;
				case 5u:
					num6 = 0;
					num2 = 92695409;
					continue;
				case 2u:
					num6 = 1;
					num2 = (int)(num3 * 437980250) ^ -271299598;
					continue;
				case 13u:
					num6++;
					num2 = (int)((num3 * 536002376) ^ 0x79C12808);
					continue;
				case 10u:
					LuaDLL.lua_settop(luaState, oldTop);
					num2 = ((int)num3 * -1098629228) ^ 0x3185F47C;
					continue;
				case 1u:
					num2 = (int)(num3 * 1335502849) ^ -68955760;
					continue;
				case 8u:
				{
					int num8;
					int num9;
					if (oldTop != num)
					{
						num8 = -1339943561;
						num9 = num8;
					}
					else
					{
						num8 = -307087245;
						num9 = num8;
					}
					num2 = num8 ^ ((int)num3 * -1997183730);
					continue;
				}
				case 0u:
					list = new List<object>();
					num2 = 9391865;
					continue;
				case 12u:
					num2 = (int)((num3 * 1383087517) ^ 0x65307122);
					continue;
				case 6u:
					num7 = oldTop + 1;
					num2 = 677656539;
					continue;
				case 14u:
				{
					int num4;
					int num5;
					if (popTypes[0] == _206E_202C_200D_202C_202E_202C_202E_202C_202A_200F_206F_202B_202E_200C_206F_206A_202D_202C_206E_200D_206A_206C_202D_206D_200C_200C_200C_202E_206B_202E_202B_202A_206F_200C_200E_202C_200D_206A_200D_200D_202E(typeof(void).TypeHandle))
					{
						num4 = -809089693;
						num5 = num4;
					}
					else
					{
						num4 = -424106460;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 1673623581);
					continue;
				}
				default:
					return list.ToArray();
				}
				break;
			}
		}
	}

	private static bool IsILua(object o)
	{
		if (o is ILuaGeneratedType)
		{
			Type type = default(Type);
			while (true)
			{
				int num = -1941989450;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1991313769)) % 4)
					{
					case 3u:
						break;
					case 1u:
						type = _202C_200C_200F_206D_200C_202E_202E_206E_202A_202D_206D_200D_206B_206F_200D_206C_200F_202E_206E_206C_202B_206D_200C_200D_202A_200F_202E_200D_206A_206E_202C_206A_206A_206A_206A_200E_200D_206F_206F_202A_202E(o);
						num = (int)((num2 * 708384910) ^ 0x5646A8C7);
						continue;
					case 2u:
						return _202D_200B_206A_206F_200F_202A_206E_202D_200C_206E_202A_202B_206A_200D_206C_206A_202E_206D_200B_206F_200B_206D_200E_206A_206B_202E_200E_200D_200B_206C_202C_200E_206D_202B_200C_206A_202E_206D_200D_202A_202E(type, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(205352972u)) != null;
					default:
						goto end_IL_0008;
					}
					break;
				}
				continue;
				end_IL_0008:
				break;
			}
		}
		return false;
	}

	internal void push(IntPtr luaState, object o)
	{
		LuaScriptMgr.PushVarObject(luaState, o);
	}

	internal void PushValueResult(IntPtr lua, object o)
	{
		int index = addObject(o, isValueType: true);
		while (true)
		{
			int num = -512624322;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -864320485)) % 3)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_002b;
				case 0u:
					return;
				}
				break;
				IL_002b:
				PushNewValueObject(lua, o, index);
				num = ((int)num2 * -1511521009) ^ -1824908120;
			}
		}
	}

	internal bool matchParameters(IntPtr luaState, MethodBase method, ref MethodCache methodCache)
	{
		return metaFunctions.matchParameters(luaState, method, ref methodCache);
	}

	internal Array tableToArray(object luaParamValue, Type paramArrayType)
	{
		return metaFunctions.TableToArray(luaParamValue, paramArrayType);
	}

	static Assembly _202B_200E_200E_206F_202C_202B_200D_206E_206F_202D_206B_206B_206D_200F_202C_206A_206D_200E_202D_202D_200D_200F_206C_206A_202B_206F_206A_206B_200B_206B_200B_202B_206D_206A_202A_202E_200F_202A_206F_206D_202E()
	{
		return Assembly.GetExecutingAssembly();
	}

	static void _202E_202C_206D_202D_206F_206D_200B_202D_202C_202A_202B_202B_202E_202C_202C_202D_202A_206A_202B_200C_206F_202E_200B_206C_206C_206A_202A_206E_200B_206F_202B_206F_200E_202D_202E_206D_206D_206B_200E_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}

	static Assembly _200B_200F_206D_206E_206D_202B_206E_202C_200E_206D_202B_200D_206A_200E_206E_206A_202A_200C_206D_200D_206F_202A_202C_200F_206A_206C_200E_202E_206C_206B_206D_200D_206B_202A_200D_202C_206F_206D_206B_200E_202E(string P_0)
	{
		return Assembly.Load(P_0);
	}

	static AssemblyName _206B_202B_206C_200F_200F_202A_200F_206B_206A_200C_206E_206E_202B_202C_200B_206C_200B_206A_200E_202A_206B_202C_202E_206C_206B_200B_206A_202E_206E_206E_206E_206D_202A_206A_200B_200B_200B_206A_202E_206B_202E(string P_0)
	{
		return AssemblyName.GetAssemblyName(P_0);
	}

	static Assembly _200C_206A_200B_206C_202D_200D_206D_206C_206D_200B_202A_202A_202C_200F_200D_202A_200D_206A_200F_200F_206D_206B_202C_202E_206F_206E_206E_202E_200E_206C_202D_200E_202E_206A_200F_202C_206C_206B_200C_202E_202E(AssemblyName P_0)
	{
		return Assembly.Load(P_0);
	}

	static string _202E_200F_206A_206C_206F_202B_200F_200D_202D_206F_202C_206C_206C_200D_200B_202B_200C_202C_206E_202A_202B_206C_200F_202E_202E_200D_200F_206A_200F_202E_206D_202D_206F_206C_202E_202B_202A_206B_200C_206F_202E(Exception P_0)
	{
		return P_0.Message;
	}

	static Type _200C_206B_206F_206E_206E_206B_200B_202C_206B_206C_202D_200D_206D_206E_202D_206B_202C_200F_200F_206C_206A_206E_200E_200C_200D_202E_200E_206F_200D_206D_200F_200C_202E_206C_206E_206E_200F_200C_206B_202E(Assembly P_0, string P_1)
	{
		return P_0.GetType(P_1);
	}

	static string _206D_206E_200D_200F_206A_206C_200C_206D_206D_200E_200E_202C_200B_202E_200D_206E_206B_202A_206C_206C_200F_200D_200D_200C_200B_202A_206D_202C_206C_206F_202B_202B_202A_200F_202B_200F_200D_202C_206B_202E_202E(string P_0, string P_1, string P_2)
	{
		return P_0 + P_1 + P_2;
	}

	static Type _202C_200C_200F_206D_200C_202E_202E_206E_202A_202D_206D_200D_206B_206F_200D_206C_200F_202E_206E_206C_202B_206D_200C_200D_202A_200F_202E_200D_206A_206E_202C_206A_206A_206A_206A_200E_200D_206F_206F_202A_202E(object P_0)
	{
		return P_0.GetType();
	}

	static FieldInfo _202C_200C_200F_206E_200D_202E_202C_206D_206E_206A_206D_200E_200F_202C_206D_200D_202C_202D_202C_200E_206F_200B_200E_202C_200F_206D_200E_200C_202A_200B_200F_200C_206E_206A_206E_202B_206C_200D_206D_206E_202E(Type P_0, string P_1)
	{
		return P_0.GetField(P_1);
	}

	static void _206B_206C_206C_200D_200C_202A_200D_206E_202A_202B_206F_200E_206B_200F_206C_200C_206E_206F_202C_206A_206A_200F_206C_202E_206F_200D_206B_206C_202B_200E_202D_200B_200D_202C_206C_206D_202C_202B_206D_202C_202E(FieldInfo P_0, object P_1, object P_2)
	{
		P_0.SetValue(P_1, P_2);
	}

	static MethodInfo _202A_200E_206F_206E_200E_206D_200C_202E_206D_202A_200D_200F_206B_202A_206F_200B_202E_202B_202C_206B_202E_206C_202C_202D_206E_202B_202B_206A_200D_206A_206A_206A_202B_202A_206D_202C_206E_200E_200C_200E_202E(IReflect P_0, string P_1, BindingFlags P_2, Binder P_3, Type[] P_4, ParameterModifier[] P_5)
	{
		return P_0.GetMethod(P_1, P_2, P_3, P_4, P_5);
	}

	static Type _200E_206B_206D_202A_200E_202D_206B_200B_202B_206D_200F_202B_206A_206A_200D_200D_200C_202E_200D_200E_200D_206D_206B_200C_202A_200E_206A_202E_206F_206C_200C_206C_200D_202E_200E_202C_206E_206A_200F_200E_202E(IReflect P_0)
	{
		return P_0.UnderlyingSystemType;
	}

	static ConstructorInfo _200D_200E_202E_206C_200E_206A_202A_200B_206C_200B_206A_202C_202D_206F_200D_202E_202A_202E_206F_200F_200F_206F_200E_202A_206F_202D_206C_200F_206B_202C_206E_202E_200F_200C_206F_202A_200C_200F_206E_206E_202E(Type P_0, Type[] P_1)
	{
		return P_0.GetConstructor(P_1);
	}

	static bool _206F_202C_206D_206B_206C_202A_206E_206F_206B_206B_206E_200D_200C_206E_206A_202E_206E_202B_206D_200B_206F_206D_200D_206B_202C_202D_202C_202A_206E_206C_206F_200B_206C_206D_206B_200B_200F_202B_202A_202B_202E(Type P_0)
	{
		return P_0.IsEnum;
	}

	static object _206E_200E_206A_202C_206B_206C_200C_202A_206D_202A_202E_206B_206C_206E_206C_200E_206C_200B_206D_200D_206C_202C_202B_202A_206E_206A_202D_200E_202E_206A_202D_202E_206B_202E_206C_202A_206C_206D_206B_200F_202E(Type P_0, int P_1)
	{
		return Enum.ToObject(P_0, P_1);
	}

	static object _202C_200F_202D_200E_206D_206C_200E_206D_206A_206F_200D_202C_200E_206C_206E_206B_200B_206B_200F_206B_202E_200C_202B_200B_206A_206C_206E_202E_202A_206A_202C_202A_206B_206C_200C_206C_206C_200D_202B_200C_202E(Type P_0, string P_1)
	{
		return Enum.Parse(P_0, P_1);
	}

	static string _200D_206E_202A_202B_202A_206E_200D_200F_202D_202E_206B_206C_202A_200C_202E_200C_206B_202E_206F_202E_202D_206A_206F_206F_202A_200F_200E_206E_202E_206F_200D_202C_200C_202D_206E_200C_202A_200C_206F_206C_202E(ArgumentException P_0)
	{
		return P_0.Message;
	}

	static bool _202B_206B_200D_202B_202A_200C_200E_200F_206F_206B_200B_202E_202A_202C_206E_206B_202D_200E_206A_200D_206F_202B_206D_202E_202D_202D_200C_206C_206D_200D_202A_202E_206E_202D_200C_202C_202A_202E_206D_202D_202E(Type P_0)
	{
		return P_0.IsValueType;
	}

	static string _202A_202A_202E_200D_200F_202E_200E_200D_206E_206A_202C_202B_206A_202B_200D_206D_200D_206D_200B_206B_206B_202C_206D_202B_206A_206B_206B_206B_206C_206A_202B_200E_206C_200D_202A_206E_200B_206C_202B_206A_202E(Type P_0)
	{
		return P_0.AssemblyQualifiedName;
	}

	static bool _206F_206C_206D_206A_202C_202A_202C_202D_202A_200F_202E_206E_206E_206B_206A_200D_206C_206B_206D_200E_200C_202B_200F_202A_200D_206B_200B_202D_200B_206F_206B_200F_200E_206F_200D_202D_200D_202C_206D_202C_202E(string P_0, string P_1)
	{
		return P_0 == P_1;
	}

	static Type _206E_202C_200D_202C_202E_202C_202E_202C_202A_200F_206F_202B_202E_200C_206F_206A_202D_202C_206E_200D_206A_206C_202D_206D_200C_200C_200C_202E_206B_202E_202B_202A_206F_200C_200E_202C_200D_206A_200D_200D_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static Type _202D_200B_206A_206F_200F_202A_206E_202D_200C_206E_202A_202B_206A_200D_206C_206A_202E_206D_200B_206F_200B_206D_200E_206A_206B_202E_200E_200D_200B_206C_202C_200E_206D_202B_200C_206A_202E_206D_200D_202A_202E(Type P_0, string P_1)
	{
		return P_0.GetInterface(P_1);
	}
}
