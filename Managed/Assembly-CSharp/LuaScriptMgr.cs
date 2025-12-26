using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using JyGame;
using LuaInterface;
using UnityEngine;

public class LuaScriptMgr
{
	public LuaState lua;

	public HashSet<string> fileList;

	private Dictionary<string, LuaBase> dict;

	private LuaFunction updateFunc;

	private LuaFunction lateUpdateFunc;

	private LuaFunction fixedUpdateFunc;

	private LuaFunction levelLoaded;

	private int unpackVec3;

	private int unpackVec2;

	private int unpackVec4;

	private int unpackQuat;

	private int unpackColor;

	private int unpackRay;

	private int unpackBounds;

	private int packVec3;

	private int packVec2;

	private int packVec4;

	private int packQuat;

	private LuaFunction packTouch;

	private int packRay;

	private LuaFunction packRaycastHit;

	private int packColor;

	private int packBounds;

	private int enumMetaRef;

	private int typeMetaRef;

	private int delegateMetaRef;

	private int iterMetaRef;

	private int arrayMetaRef;

	public static LockFreeQueue<LuaRef> refGCList = new LockFreeQueue<LuaRef>(1024);

	private static ObjectTranslator _206B_206A_202B_202C_200D_200E_206F_206E_202B_206D_200B_200D_200E_206A_200C_206C_206A_200B_200C_200B_202B_202A_206A_206B_202E_202E_206C_200C_200C_202C_202B_206B_200E_206F_200D_206B_206C_206C_206F_202C_202E = null;

	private static HashSet<Type> checkBaseType;

	private static LuaFunction traceback;

	private string luaIndex = global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3054892960u);

	private string luaNewIndex = global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1861914081u);

	private string luaTableCall = global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2164303186u);

	private string luaEnumIndex = global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4294352199u);

	private static Type monoType;

	private static Dictionary<Enum, object> enumMap;

	[CompilerGenerated]
	private static LuaScriptMgr _206D_200B_206C_206F_206D_200E_200E_206B_202B_202B_200D_202A_202D_202E_202C_206A_206F_206A_200C_202C_206B_202A_206F_200B_206D_206A_206D_206E_202B_206F_206B_202B_206B_200B_202A_206F_202A_206D_200C_200D_202E;

	public static LuaScriptMgr Instance
	{
		[CompilerGenerated]
		get
		{
			return _206D_200B_206C_206F_206D_200E_200E_206B_202B_202B_200D_202A_202D_202E_202C_206A_206F_206A_200C_202C_206B_202A_206F_200B_206D_206A_206D_206E_202B_206F_206B_202B_206B_200B_202A_206F_202A_206D_200C_200D_202E;
		}
		[CompilerGenerated]
		private set
		{
			_206D_200B_206C_206F_206D_200E_200E_206B_202B_202B_200D_202A_202D_202E_202C_206A_206F_206A_200C_202C_206B_202A_206F_200B_206D_206A_206D_206E_202B_206F_206B_202B_206B_200B_202A_206F_202A_206D_200C_200D_202E = value;
		}
	}

	public LuaScriptMgr()
	{
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Invalid comparison between Unknown and I4
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = 1432553358;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6FD9E3A)) % 25)
				{
				case 12u:
					break;
				case 7u:
					LuaStatic.Load = Loader;
					num = ((int)num2 * -1068705646) ^ 0x2A5E5229;
					continue;
				case 0u:
					return;
				case 8u:
					LuaDLL.lua_pushstring(lua.L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2868762008u));
					LuaDLL.luaL_dostring(lua.L, luaNewIndex);
					num = (int)(num2 * 1406564552) ^ -268052443;
					continue;
				case 24u:
					LuaDLL.lua_rawset(lua.L, LuaIndexes.LUA_REGISTRYINDEX);
					LuaDLL.lua_pushstring(lua.L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1342217523u));
					LuaDLL.luaL_dostring(lua.L, luaTableCall);
					LuaDLL.lua_rawset(lua.L, LuaIndexes.LUA_REGISTRYINDEX);
					LuaDLL.lua_pushstring(lua.L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(598615406u));
					num = ((int)num2 * -1998132123) ^ 0x7FEE078A;
					continue;
				case 13u:
					Instance = this;
					num = 1738865762;
					continue;
				case 10u:
					LuaDLL.luaL_dostring(lua.L, luaIndex);
					num = ((int)num2 * -1297676158) ^ 0x7E5BB22E;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if ((int)_200C_202A_200B_206F_200E_206E_200E_200C_200E_206D_202C_200F_202C_200F_200B_200D_200D_202B_202D_202C_202E_202C_206E_206C_206C_200C_202B_206C_202B_202E_202B_202D_206F_206A_206F_206A_202B_206D_202E_202C_202E() == 8)
					{
						num5 = 516316346;
						num6 = num5;
					}
					else
					{
						num5 = 1918082233;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -185311641);
					continue;
				}
				case 16u:
					LuaDLL.luaopen_bit(lua.L);
					num = 1111372158;
					continue;
				case 17u:
					LuaDLL.luaL_dostring(lua.L, luaEnumIndex);
					LuaDLL.lua_rawset(lua.L, LuaIndexes.LUA_REGISTRYINDEX);
					num = ((int)num2 * -2088304950) ^ -1657960900;
					continue;
				case 6u:
					LuaDLL.tolua_openlibs(lua.L);
					fileList = new HashSet<string>();
					num = (int)((num2 * 1150120791) ^ 0x77F86441);
					continue;
				case 14u:
				{
					int num7;
					int num8;
					if (Util.CheckEnvironment())
					{
						num7 = -1299692178;
						num8 = num7;
					}
					else
					{
						num7 = -868341640;
						num8 = num7;
					}
					num = num7 ^ ((int)num2 * -970150112);
					continue;
				}
				case 5u:
				{
					int num3;
					int num4;
					if ((int)_200C_202A_200B_206F_200E_206E_200E_200C_200E_206D_202C_200F_202C_200F_200B_200D_200D_202B_202D_202C_202E_202C_206E_206C_206C_200C_202B_206C_202B_202E_202B_202D_206F_206A_206F_206A_202B_206D_202E_202C_202E() == 0)
					{
						num3 = -525027833;
						num4 = num3;
					}
					else
					{
						num3 = -1252609177;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1740334657);
					continue;
				}
				case 22u:
					dict = new Dictionary<string, LuaBase>();
					LuaDLL.lua_pushstring(lua.L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3761341638u));
					num = ((int)num2 * -75282194) ^ -1505582036;
					continue;
				case 9u:
					LuaDLL.luaopen_pb(lua.L);
					num = (int)((num2 * 638323640) ^ 0x40ECA81C);
					continue;
				case 23u:
					LuaDLL.luaopen_cjson(lua.L);
					LuaDLL.luaopen_cjson_safe(lua.L);
					num = (int)((num2 * 1301256907) ^ 0x2EE7C331);
					continue;
				case 18u:
					LuaDLL.luaopen_sproto_core(lua.L);
					num = (int)(num2 * 1461336427) ^ -1148058596;
					continue;
				case 1u:
					LuaDLL.luaopen_sproto_core(lua.L);
					num = 2054741251;
					continue;
				case 11u:
					LuaDLL.luaopen_lpeg(lua.L);
					num = (int)((num2 * 1583029656) ^ 0x2E4DA19D);
					continue;
				case 21u:
					lua = new LuaState();
					_206B_206A_202B_202C_200D_200E_206F_206E_202B_206D_200B_200D_200E_206A_200C_206C_206A_200B_200C_200B_202B_202A_206A_206B_202E_202E_206C_200C_200C_202C_202B_206B_200E_206F_200D_206B_206C_206C_206F_202C_202E = lua.GetTranslator();
					num = (int)(num2 * 1065621707) ^ -1145227704;
					continue;
				case 20u:
					LuaDLL.lua_pushnumber(lua.L, 0.0);
					num = ((int)num2 * -1617735245) ^ -989503440;
					continue;
				case 19u:
					LuaDLL.luaopen_protobuf_c(lua.L);
					num = (int)((num2 * 828823638) ^ 0x5F449E25);
					continue;
				case 3u:
					Bind();
					num = (int)(num2 * 1187513858) ^ -1432629030;
					continue;
				case 15u:
					LuaDLL.lua_rawset(lua.L, LuaIndexes.LUA_REGISTRYINDEX);
					num = (int)(num2 * 1968338806) ^ -1908950702;
					continue;
				default:
					LuaDLL.lua_setglobal(lua.L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2040721581u));
					return;
				}
				break;
			}
		}
	}

	static LuaScriptMgr()
	{
		while (true)
		{
			int num = 259225764;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6202FA1C)) % 5)
				{
				case 3u:
					break;
				default:
					return;
				case 2u:
					enumMap = new Dictionary<Enum, object>();
					num = ((int)num2 * -1792759007) ^ -598670369;
					continue;
				case 0u:
					monoType = _200F_202A_200C_206F_206A_200C_206E_202C_206D_206C_206B_200B_200D_200B_200E_200B_206E_202B_202A_206F_202E_202E_202A_206C_206D_206C_200F_200B_202A_202D_206C_206D_200E_200B_206E_200E_206F_206E_202D_202E_202E(_206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(Type).TypeHandle));
					num = ((int)num2 * -1716844169) ^ -145437346;
					continue;
				case 1u:
					checkBaseType = new HashSet<Type>();
					traceback = null;
					num = ((int)num2 * -1739364873) ^ 0x52F9568D;
					continue;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private void SendGMmsg(params string[] param)
	{
		Debugger.Log(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(755734249u));
		string text = default(string);
		int num4 = default(int);
		string[] array = default(string[]);
		int num3 = default(int);
		string text2 = default(string);
		while (true)
		{
			int num = 1459914729;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x25866353)) % 9)
				{
				case 0u:
					break;
				default:
					return;
				case 7u:
					text = string.Empty;
					num4 = 0;
					array = param;
					num3 = 0;
					num = (int)(num2 * 1451357117) ^ -473544366;
					continue;
				case 1u:
				{
					int num6;
					if (num3 >= array.Length)
					{
						num = 1962957662;
						num6 = num;
					}
					else
					{
						num = 1214282024;
						num6 = num;
					}
					continue;
				}
				case 6u:
					num = (int)((num2 * 1961587208) ^ 0x2CE70472);
					continue;
				case 4u:
					CallLuaFunction(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(950427445u), text);
					num = ((int)num2 * -1055078030) ^ 0x5D4D3C28;
					continue;
				case 5u:
					num4++;
					num3++;
					num = 821363946;
					continue;
				case 2u:
				{
					text2 = array[num3];
					int num5;
					if (num4 > 0)
					{
						num = 1834508151;
						num5 = num;
					}
					else
					{
						num = 365782389;
						num5 = num;
					}
					continue;
				}
				case 3u:
					text = _206E_206A_206D_206B_200F_202A_206D_206F_202A_200F_202B_200D_202A_202D_200D_206E_202A_200D_202E_202A_206A_206F_200D_206A_206C_202B_200E_206F_202D_206D_206D_206D_202E_206A_206D_202B_200F_206F_206C_200E_202E(text, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(493608073u), text2);
					Debugger.Log(text2);
					num = ((int)num2 * -158616175) ^ -1338187503;
					continue;
				case 8u:
					return;
				}
				break;
			}
		}
	}

	private void InitLayers(IntPtr L)
	{
		LuaTable luaTable = GetLuaTable(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(126278383u));
		int num3 = default(int);
		string text = default(string);
		while (true)
		{
			int num = -813256530;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -945060032)) % 11)
				{
				case 3u:
					break;
				default:
					return;
				case 1u:
					luaTable.push(L);
					num = ((int)num2 * -98030842) ^ 0x3F1AF58C;
					continue;
				case 5u:
					LuaDLL.lua_settop(L, 0);
					num = ((int)num2 * -1372123473) ^ -491876727;
					continue;
				case 9u:
					num3 = 0;
					num = ((int)num2 * -945014200) ^ 0x1C77E27C;
					continue;
				case 0u:
					num = ((int)num2 * -561058859) ^ -1946241828;
					continue;
				case 2u:
				{
					int num5;
					if (num3 >= 32)
					{
						num = -1307441796;
						num5 = num;
					}
					else
					{
						num = -1478864009;
						num5 = num;
					}
					continue;
				}
				case 4u:
					LuaDLL.lua_pushstring(L, text);
					num = (int)(num2 * 1436910065) ^ -1247602069;
					continue;
				case 7u:
					num3++;
					num = -2025342352;
					continue;
				case 10u:
				{
					text = LayerMask.LayerToName(num3);
					int num4;
					if (_202B_206E_200B_202C_202E_206B_202B_200C_200E_206A_200C_202D_206A_202D_200E_206E_202E_206F_206D_206B_202D_200D_202B_202A_202A_200D_202C_206F_200F_206F_200C_200E_202E_202A_206A_202A_202D_202B_202A_200F_202E(text, string.Empty))
					{
						num = -1162901500;
						num4 = num;
					}
					else
					{
						num = -959607174;
						num4 = num;
					}
					continue;
				}
				case 6u:
					Push(L, num3);
					LuaDLL.lua_rawset(L, -3);
					num = (int)((num2 * 1884343505) ^ 0x5032B625);
					continue;
				case 8u:
					return;
				}
				break;
			}
		}
	}

	private void Bind()
	{
		IntPtr l = lua.L;
		BindArray(l);
		while (true)
		{
			int num = -784850939;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1075328376)) % 4)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					DelegateFactory.Register(l);
					num = (int)(num2 * 1705688016) ^ -108728808;
					continue;
				case 0u:
					LuaBinder.Bind(l);
					num = ((int)num2 * -1185558903) ^ 0x285DAC1B;
					continue;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	private void BindArray(IntPtr L)
	{
		LuaDLL.luaL_newmetatable(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3974030475u));
		while (true)
		{
			int num = -393251895;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1531392624)) % 9)
				{
				case 8u:
					break;
				default:
					return;
				case 0u:
					arrayMetaRef = LuaDLL.luaL_ref(lua.L, LuaIndexes.LUA_REGISTRYINDEX);
					LuaDLL.lua_settop(L, 0);
					num = (int)(num2 * 305195727) ^ -14505821;
					continue;
				case 2u:
					LuaDLL.lua_pushstring(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4112679809u));
					LuaDLL.lua_pushstdcallcfunction(L, __gc);
					LuaDLL.lua_rawset(L, -3);
					num = ((int)num2 * -1037316049) ^ -1404211354;
					continue;
				case 1u:
					LuaDLL.lua_pushstdcallcfunction(L, NewIndexArray);
					LuaDLL.lua_rawset(L, -3);
					num = ((int)num2 * -737682556) ^ 0x2528CA3;
					continue;
				case 6u:
					LuaDLL.lua_pushstdcallcfunction(L, IndexArray);
					num = ((int)num2 * -863283819) ^ -1880923035;
					continue;
				case 5u:
					LuaDLL.lua_pushstring(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2003425470u));
					num = (int)((num2 * 1872950529) ^ 0x4A351C34);
					continue;
				case 4u:
					LuaDLL.lua_pushstring(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1867840879u));
					num = ((int)num2 * -1763251711) ^ -167920312;
					continue;
				case 3u:
					LuaDLL.lua_rawset(L, -3);
					num = (int)(num2 * 1120930892) ^ -1801455869;
					continue;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	public IntPtr GetL()
	{
		return lua.L;
	}

	private void PrintLua(params string[] param)
	{
		if (param.Length != 2)
		{
			goto IL_0006;
		}
		goto IL_0064;
		IL_0006:
		int num = 373560768;
		goto IL_000b;
		IL_000b:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x499D3CF5)) % 5)
			{
			case 4u:
				break;
			default:
				return;
			case 1u:
				Debugger.Log(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4259482929u));
				num = ((int)num2 * -1542553659) ^ -910675040;
				continue;
			case 2u:
				return;
			case 0u:
				goto IL_0064;
			case 3u:
				return;
			}
			break;
		}
		goto IL_0006;
		IL_0064:
		CallLuaFunction(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4240176703u), param[1]);
		num = 434137939;
		goto IL_000b;
	}

	public void LuaGC(params string[] param)
	{
		LuaDLL.lua_gc(lua.L, LuaGCOptions.LUA_GCCOLLECT, 0);
	}

	private void LuaMem(params string[] param)
	{
		CallLuaFunction(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2702666209u));
	}

	public void Start()
	{
		OnBundleLoaded();
		enumMetaRef = GetTypeMetaRef(_206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(Enum).TypeHandle));
		typeMetaRef = GetTypeMetaRef(_206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(Type).TypeHandle));
		delegateMetaRef = GetTypeMetaRef(_206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(Delegate).TypeHandle));
		iterMetaRef = GetTypeMetaRef(_206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(IEnumerator).TypeHandle));
		HashSet<Type>.Enumerator enumerator = checkBaseType.GetEnumerator();
		try
		{
			Type current = default(Type);
			while (true)
			{
				IL_00a4:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -1252728972;
					num2 = num;
				}
				else
				{
					num = -731736485;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -2013406446)) % 5)
					{
					case 4u:
						num = -731736485;
						continue;
					default:
						goto end_IL_0070;
					case 2u:
						current = enumerator.Current;
						num = -1868170688;
						continue;
					case 3u:
						break;
					case 1u:
						Debugger.LogWarning(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2985226018u), _202C_206B_202B_206F_206F_206A_206D_206E_206F_206A_206B_206D_200D_206B_202D_200C_206F_202C_202A_206F_200B_206B_200D_202D_202C_202B_206A_206E_200E_200B_202D_200C_206D_202D_206A_200D_200E_202B_200C_202E_202E(current));
						num = (int)(num3 * 742298516) ^ -256231168;
						continue;
					case 0u:
						goto end_IL_0070;
					}
					goto IL_00a4;
					continue;
					end_IL_0070:
					break;
				}
				break;
			}
		}
		finally
		{
			_206F_200E_206D_206A_206F_202E_202B_200C_206D_206A_200B_206B_206B_200B_200B_206F_206D_200E_206A_200F_206C_206B_200E_206F_200D_202A_200E_202D_206D_200E_202C_200F_202C_206A_202E_200B_202D_202B_202A_200F_202E((IDisposable)enumerator);
		}
		checkBaseType.Clear();
	}

	private int GetLuaReference(string str)
	{
		LuaFunction luaFunction = GetLuaFunction(str);
		while (true)
		{
			int num = -1547550686;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)(num ^ -1406163704)) % 4)
				{
				case 0u:
					break;
				case 2u:
				{
					int num4;
					if (luaFunction != null)
					{
						num3 = 958120177;
						num4 = num3;
					}
					else
					{
						num3 = 9530527;
						num4 = num3;
					}
					goto IL_003f;
				}
				case 1u:
					return luaFunction.GetReference();
				default:
					return -1;
				}
				break;
				IL_003f:
				num = num3 ^ (int)(num2 * 1504127672);
			}
		}
	}

	private int GetTypeMetaRef(Type t)
	{
		string meta = _200C_202B_202C_200D_202E_202E_200F_202C_206D_200C_200C_200B_200C_200F_202D_200D_202E_206F_200F_206F_206E_202B_200B_202A_200C_206A_206C_202E_200C_202A_206B_202D_200C_200E_206C_202C_202B_206F_206F_202B_202E(t);
		while (true)
		{
			int num = 1561088757;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4641B7A3)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0029;
				default:
					return LuaDLL.luaL_ref(lua.L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				break;
				IL_0029:
				LuaDLL.luaL_getmetatable(lua.L, meta);
				num = (int)(num2 * 1227183372) ^ -1453674074;
			}
		}
	}

	private void OnBundleLoaded()
	{
		DoFile(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3513183493u));
		while (true)
		{
			int num = 585189173;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2FEFCFD3)) % 16)
				{
				case 15u:
					break;
				default:
					return;
				case 9u:
					packRay = GetLuaReference(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3799456121u));
					num = (int)(num2 * 1550945822) ^ -453674168;
					continue;
				case 10u:
					fixedUpdateFunc = GetLuaFunction(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4086786549u));
					levelLoaded = GetLuaFunction(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2285111240u));
					num = ((int)num2 * -1061847290) ^ -330475790;
					continue;
				case 11u:
					unpackVec3 = GetLuaReference(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3073053460u));
					unpackVec2 = GetLuaReference(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(728512465u));
					unpackVec4 = GetLuaReference(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2549915373u));
					num = (int)((num2 * 1678377632) ^ 0x37A6A2B7);
					continue;
				case 3u:
					packRaycastHit = GetLuaFunction(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4109902369u));
					packColor = GetLuaReference(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(826088315u));
					num = (int)(num2 * 1462327205) ^ -106334427;
					continue;
				case 5u:
					packTouch = GetLuaFunction(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1248325731u));
					packBounds = GetLuaReference(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1380673945u));
					num = (int)((num2 * 384220846) ^ 0x6799F8A4);
					continue;
				case 0u:
					updateFunc = GetLuaFunction(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2440323622u));
					num = (int)((num2 * 1616777087) ^ 0x51857F9D);
					continue;
				case 12u:
					DoFile(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(481269931u));
					num = ((int)num2 * -604470527) ^ -310312177;
					continue;
				case 1u:
					traceback = GetLuaFunction(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3860878013u));
					num = ((int)num2 * -2055157758) ^ -724938339;
					continue;
				case 14u:
					lateUpdateFunc = GetLuaFunction(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2014390195u));
					num = ((int)num2 * -710755380) ^ -1666246287;
					continue;
				case 6u:
					InitLayers(lua.L);
					num = (int)(num2 * 140204183) ^ -2105669358;
					continue;
				case 4u:
					unpackQuat = GetLuaReference(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2153522094u));
					unpackColor = GetLuaReference(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3544758522u));
					num = ((int)num2 * -2058751159) ^ 0x6C786EE0;
					continue;
				case 13u:
					CallLuaFunction(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4199080598u));
					num = (int)((num2 * 1679852465) ^ 0x6C8E7E2C);
					continue;
				case 8u:
					packVec4 = GetLuaReference(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3337158385u));
					packQuat = GetLuaReference(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3374937404u));
					num = ((int)num2 * -1424684276) ^ -1268466768;
					continue;
				case 7u:
					unpackRay = GetLuaReference(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2960678934u));
					unpackBounds = GetLuaReference(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3985747459u));
					packVec3 = GetLuaReference(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3066995321u));
					packVec2 = GetLuaReference(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3176301346u));
					num = ((int)num2 * -565651816) ^ -874085549;
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public void OnLevelLoaded(int level)
	{
		levelLoaded.Call(level);
	}

	public void Update()
	{
		if (updateFunc != null)
		{
			goto IL_000b;
		}
		goto IL_0070;
		IL_000b:
		int num = -623964141;
		goto IL_0010;
		IL_0010:
		int oldTop = default(int);
		IntPtr luaState = default(IntPtr);
		LuaRef luaRef = default(LuaRef);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -468444855)) % 12)
			{
			case 3u:
				break;
			default:
				return;
			case 2u:
				oldTop = updateFunc.BeginPCall();
				num = ((int)num2 * -1789871705) ^ 0x15C2016E;
				continue;
			case 0u:
			case 6u:
				goto IL_0070;
			case 5u:
				Push(luaState, _202A_206C_202D_202D_202B_206E_200B_206F_202E_202E_200C_206E_202B_206B_206E_206F_200D_202A_202C_200E_206F_202B_206E_200F_206C_202B_202D_206F_200F_202A_200D_200E_206E_200B_200F_206D_206D_206B_200F_206B_202E());
				num = ((int)num2 * -449791658) ^ -37186128;
				continue;
			case 1u:
				luaState = updateFunc.GetLuaState();
				num = (int)((num2 * 962152559) ^ 0x5CAD2D4E);
				continue;
			case 9u:
				updateFunc.EndPCall(oldTop);
				num = ((int)num2 * -46353296) ^ 0x7A0DBD1F;
				continue;
			case 7u:
				luaRef = refGCList.Dequeue();
				num = -1669263731;
				continue;
			case 8u:
				LuaDLL.lua_unref(luaRef.L, luaRef.reference);
				num = ((int)num2 * -1113142044) ^ -767766899;
				continue;
			case 11u:
				updateFunc.PCall(oldTop, 2);
				num = ((int)num2 * -664810448) ^ 0x3E76CFCC;
				continue;
			case 4u:
				Push(luaState, _200B_206A_200F_200D_206B_202C_202E_200E_206B_206B_202E_202B_206C_200C_200F_200F_202D_206E_206C_200E_200E_206F_206F_200C_202E_202C_200E_202D_200E_202D_200F_200F_206D_206F_206E_202A_206B_200B_206A_202A_202E());
				num = (int)((num2 * 1545834746) ^ 0x259C77A0);
				continue;
			case 10u:
				return;
			}
			break;
		}
		goto IL_000b;
		IL_0070:
		int num3;
		if (refGCList.IsEmpty())
		{
			num = -1999422585;
			num3 = num;
		}
		else
		{
			num = -1775644338;
			num3 = num;
		}
		goto IL_0010;
	}

	public void LateUpate()
	{
		if (lateUpdateFunc == null)
		{
			return;
		}
		while (true)
		{
			int num = 1208934268;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x44553B2B)) % 3)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_002a;
				case 0u:
					return;
				}
				break;
				IL_002a:
				lateUpdateFunc.Call();
				num = (int)(num2 * 805496776) ^ -349832467;
			}
		}
	}

	public void FixedUpdate()
	{
		if (fixedUpdateFunc == null)
		{
			return;
		}
		while (true)
		{
			int num = 2077426591;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x67BE3A4E)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_002a;
				case 2u:
					return;
				}
				break;
				IL_002a:
				fixedUpdateFunc.Call(_202B_202D_206A_200E_202A_202B_200C_200F_202B_202B_202C_206E_206F_202D_200E_200E_200C_206D_206B_200D_202C_200B_200C_206D_206E_206B_202D_202A_202D_202A_202D_200C_202C_206C_202C_202C_202E_202D_206C_200C_202E());
				num = (int)(num2 * 1785717959) ^ -1452090967;
			}
		}
	}

	private void SafeRelease(ref LuaFunction func)
	{
		if (func == null)
		{
			return;
		}
		while (true)
		{
			int num = 1319716862;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4E2E27ED)) % 3)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_0026;
				case 0u:
					return;
				}
				break;
				IL_0026:
				func.Release();
				func = null;
				num = ((int)num2 * -69571157) ^ 0x2DF42110;
			}
		}
	}

	private void SafeUnRef(ref int reference)
	{
		if (reference <= 0)
		{
			return;
		}
		while (true)
		{
			int num = 1355310190;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x33B3515)) % 4)
				{
				case 0u:
					break;
				default:
					return;
				case 3u:
					LuaDLL.lua_unref(lua.L, reference);
					num = (int)((num2 * 1998788792) ^ 0x4804D43B);
					continue;
				case 2u:
					reference = -1;
					num = ((int)num2 * -1770017179) ^ -2100486530;
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public void Destroy()
	{
		Instance = null;
		SafeUnRef(ref enumMetaRef);
		while (true)
		{
			int num = 1328136192;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5DF5920B)) % 7)
				{
				case 0u:
					break;
				case 4u:
					SafeRelease(ref fixedUpdateFunc);
					num = (int)(num2 * 1803812029) ^ -835872423;
					continue;
				case 2u:
					SafeRelease(ref packRaycastHit);
					SafeRelease(ref packTouch);
					num = (int)(num2 * 759308174) ^ -1873433926;
					continue;
				case 5u:
					SafeUnRef(ref delegateMetaRef);
					SafeUnRef(ref iterMetaRef);
					SafeUnRef(ref arrayMetaRef);
					num = (int)(num2 * 1789781939) ^ -1816727675;
					continue;
				case 3u:
					SafeRelease(ref updateFunc);
					SafeRelease(ref lateUpdateFunc);
					num = ((int)num2 * -1015519295) ^ 0x5313D615;
					continue;
				case 6u:
					SafeUnRef(ref typeMetaRef);
					num = ((int)num2 * -1612722863) ^ -1453745690;
					continue;
				default:
				{
					LuaDLL.lua_gc(lua.L, LuaGCOptions.LUA_GCCOLLECT, 0);
					Dictionary<string, LuaBase>.Enumerator enumerator = dict.GetEnumerator();
					try
					{
						while (true)
						{
							IL_0169:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 1442915058;
								num4 = num3;
							}
							else
							{
								num3 = 911858044;
								num4 = num3;
							}
							while (true)
							{
								switch ((num2 = (uint)(num3 ^ 0x5DF5920B)) % 4)
								{
								case 2u:
									num3 = 1442915058;
									continue;
								default:
									goto end_IL_012d;
								case 1u:
									enumerator.Current.Value.Dispose();
									num3 = 2055221227;
									continue;
								case 0u:
									break;
								case 3u:
									goto end_IL_012d;
								}
								goto IL_0169;
								continue;
								end_IL_012d:
								break;
							}
							break;
						}
					}
					finally
					{
						_206F_200E_206D_206A_206F_202E_202B_200C_206D_206A_200B_206B_206B_200B_200B_206F_206D_200E_206A_200F_206C_206B_200E_206F_200D_202A_200E_202D_206D_200E_202C_200F_202C_206A_202E_200B_202D_202B_202A_200F_202E((IDisposable)enumerator);
					}
					dict.Clear();
					while (true)
					{
						int num5 = 1405169735;
						while (true)
						{
							switch ((num2 = (uint)(num5 ^ 0x5DF5920B)) % 7)
							{
							case 6u:
								break;
							case 3u:
								LuaBinder.wrapList.Clear();
								num5 = (int)((num2 * 346702209) ^ 0x3D51E4B8);
								continue;
							case 0u:
								lua = null;
								DelegateFactory.Clear();
								num5 = ((int)num2 * -1138734777) ^ 0x22FAF8D0;
								continue;
							case 1u:
								lua.Close();
								num5 = ((int)num2 * -1813031252) ^ 0x36BE5197;
								continue;
							case 5u:
								lua.Dispose();
								num5 = (int)(num2 * 1889726440) ^ -1822562986;
								continue;
							case 2u:
								fileList.Clear();
								num5 = ((int)num2 * -36963856) ^ 0x281846DA;
								continue;
							default:
								Debugger.Log(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1090236766u));
								return;
							}
							break;
						}
					}
				}
				}
				break;
			}
		}
	}

	public object[] DoString(string str)
	{
		return lua.DoString(str);
	}

	public object[] DoFile(string fileName)
	{
		if (!fileList.Contains(fileName))
		{
			while (true)
			{
				uint num;
				switch ((num = 1775997947u) % 3)
				{
				case 0u:
					continue;
				case 2u:
					return lua.DoFile(fileName, null);
				}
				break;
			}
		}
		return null;
	}

	public object[] CallLuaFunction(string name, params object[] args)
	{
		LuaBase value = null;
		IntPtr l = default(IntPtr);
		LuaFunction luaFunction = default(LuaFunction);
		int num3 = default(int);
		LuaFunction luaFunction2 = default(LuaFunction);
		int newTop = default(int);
		while (true)
		{
			int num = -1468846118;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -374689237)) % 12)
				{
				case 11u:
					break;
				case 5u:
				{
					int num6;
					int num7;
					if (!dict.TryGetValue(name, out value))
					{
						num6 = 165528301;
						num7 = num6;
					}
					else
					{
						num6 = 906667506;
						num7 = num6;
					}
					num = num6 ^ (int)(num2 * 640571874);
					continue;
				}
				case 0u:
				{
					int num4;
					int num5;
					if (!PushLuaFunction(l, name))
					{
						num4 = 2122454967;
						num5 = num4;
					}
					else
					{
						num4 = 1531533270;
						num5 = num4;
					}
					num = num4 ^ ((int)num2 * -333207222);
					continue;
				}
				case 10u:
					luaFunction = new LuaFunction(num3, lua);
					num = ((int)num2 * -1063066628) ^ 0x69738A1D;
					continue;
				case 9u:
					num3 = LuaDLL.luaL_ref(l, LuaIndexes.LUA_REGISTRYINDEX);
					num = ((int)num2 * -492640890) ^ 0x7970D34B;
					continue;
				case 1u:
					return luaFunction2.Call(args);
				case 3u:
					luaFunction = null;
					newTop = LuaDLL.lua_gettop(l);
					num = (int)((num2 * 1952383540) ^ 0x41CEA20B);
					continue;
				case 4u:
					l = lua.L;
					num = -1973463172;
					continue;
				case 6u:
					LuaDLL.lua_settop(l, newTop);
					num = ((int)num2 * -2049218485) ^ 0x2D052333;
					continue;
				case 7u:
					luaFunction2 = value as LuaFunction;
					num = (int)((num2 * 1922819016) ^ 0x4B3CB616);
					continue;
				case 2u:
				{
					object[] result = luaFunction.Call(args);
					luaFunction.Dispose();
					return result;
				}
				default:
					return null;
				}
				break;
			}
		}
	}

	public LuaFunction GetLuaFunction(string name)
	{
		LuaBase value = null;
		if (!dict.TryGetValue(name, out value))
		{
			goto IL_0015;
		}
		goto IL_010d;
		IL_0015:
		int num = -446225612;
		goto IL_001a;
		IL_001a:
		int newTop = default(int);
		IntPtr l = default(IntPtr);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1099987550)) % 12)
			{
			case 6u:
				break;
			case 9u:
				Debugger.LogError(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1165707752u), name);
				num = -79608830;
				continue;
			case 11u:
				newTop = LuaDLL.lua_gettop(l);
				num = ((int)num2 * -28640101) ^ -98691605;
				continue;
			case 0u:
				LuaDLL.lua_settop(l, newTop);
				num = -355079469;
				continue;
			case 10u:
				l = lua.L;
				num = (int)((num2 * 1147203438) ^ 0x789F7719);
				continue;
			case 3u:
			{
				int num5 = LuaDLL.luaL_ref(l, LuaIndexes.LUA_REGISTRYINDEX);
				value = new LuaFunction(num5, lua);
				value.name = name;
				num = (int)((num2 * 1794790383) ^ 0x92C8271);
				continue;
			}
			case 7u:
				num = (int)((num2 * 1198042017) ^ 0x743374F1);
				continue;
			case 1u:
				goto IL_010d;
			case 2u:
				dict.Add(name, value);
				num = ((int)num2 * -1671492980) ^ -2009719879;
				continue;
			case 5u:
				num = ((int)num2 * -704374357) ^ -2142918263;
				continue;
			case 8u:
			{
				int num3;
				int num4;
				if (!PushLuaFunction(l, name))
				{
					num3 = -1596470657;
					num4 = num3;
				}
				else
				{
					num3 = -1412638107;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 1756877365);
				continue;
			}
			default:
				return value as LuaFunction;
			}
			break;
		}
		goto IL_0015;
		IL_010d:
		value.AddRef();
		num = -2123640590;
		goto IL_001a;
	}

	public int GetFunctionRef(string name)
	{
		IntPtr l = lua.L;
		int newTop = default(int);
		int result = default(int);
		while (true)
		{
			int num = -884155336;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -157009843)) % 8)
				{
				case 0u:
					break;
				case 5u:
					newTop = LuaDLL.lua_gettop(l);
					num = (int)(num2 * 927780447) ^ -621934212;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (!PushLuaFunction(l, name))
					{
						num3 = 988661983;
						num4 = num3;
					}
					else
					{
						num3 = 1515093424;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -251927279);
					continue;
				}
				case 4u:
					Debugger.LogWarning(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1165707752u), name);
					num = -1485999254;
					continue;
				case 2u:
					result = -1;
					num = ((int)num2 * -1093880633) ^ 0x6610414D;
					continue;
				case 1u:
					num = (int)((num2 * 1903605887) ^ 0x4D54C7CD);
					continue;
				case 3u:
					result = LuaDLL.luaL_ref(l, LuaIndexes.LUA_REGISTRYINDEX);
					num = (int)(num2 * 705362343) ^ -2142380007;
					continue;
				default:
					LuaDLL.lua_settop(l, newTop);
					return result;
				}
				break;
			}
		}
	}

	public bool IsFuncExists(string name)
	{
		IntPtr l = lua.L;
		int newTop = default(int);
		while (true)
		{
			int num = -1153950610;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1312880944)) % 5)
				{
				case 0u:
					break;
				case 1u:
				{
					newTop = LuaDLL.lua_gettop(l);
					int num3;
					int num4;
					if (PushLuaFunction(l, name))
					{
						num3 = 1058234050;
						num4 = num3;
					}
					else
					{
						num3 = 1202381878;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -145238689);
					continue;
				}
				case 4u:
					return true;
				case 3u:
					LuaDLL.lua_settop(l, newTop);
					num = ((int)num2 * -1434267361) ^ -99323349;
					continue;
				default:
					return false;
				}
				break;
			}
		}
	}

	public byte[] Loader(string name)
	{
		byte[] result = null;
		string path = default(string);
		while (true)
		{
			int num = -624161376;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1096885091)) % 5)
				{
				case 3u:
					break;
				case 2u:
					fileList.Add(name);
					num = ((int)num2 * -1425988521) ^ -774461187;
					continue;
				case 1u:
					path = Util.LuaPath(name);
					num = (int)(num2 * 844350359) ^ -1923597078;
					continue;
				case 0u:
					result = LuaManager.JyGameLuaLoader(path);
					num = ((int)num2 * -501812334) ^ 0x3943E024;
					continue;
				default:
					return result;
				}
				break;
			}
		}
	}

	private static bool PushLuaTable(IntPtr L, string fullPath)
	{
		string[] array = _206A_202B_202B_206F_200D_206B_202B_202E_200B_202D_200E_206E_200C_206C_200E_202A_200C_202A_202B_206F_200C_200F_206A_200F_200F_206A_202A_200C_206A_206A_200C_202E_206F_206F_206D_200B_206C_206B_200B_202E_202E(fullPath, new char[1] { '.' });
		int num3 = default(int);
		int num4 = default(int);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -851136993;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1331825161)) % 19)
				{
				case 13u:
					break;
				case 9u:
					num3 = LuaDLL.lua_gettop(L);
					LuaDLL.lua_pushstring(L, array[0]);
					num = (int)(num2 * 1675373404) ^ -2019421764;
					continue;
				case 11u:
					num4 = 1;
					num = -783961439;
					continue;
				case 4u:
					LuaDLL.lua_pushnil(L);
					Debugger.LogError(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2414833841u), array[0]);
					num = ((int)num2 * -1021356039) ^ 0x63D5ADA4;
					continue;
				case 12u:
				{
					int num8;
					int num9;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num8 = -1234482876;
						num9 = num8;
					}
					else
					{
						num8 = -1278629297;
						num9 = num8;
					}
					num = num8 ^ ((int)num2 * -549940446);
					continue;
				}
				case 6u:
					return false;
				case 10u:
				{
					int num10;
					int num11;
					if (array.Length > 1)
					{
						num10 = 1571019233;
						num11 = num10;
					}
					else
					{
						num10 = 513466058;
						num11 = num10;
					}
					num = num10 ^ ((int)num2 * -99080);
					continue;
				}
				case 15u:
					num4++;
					num = -783961439;
					continue;
				case 2u:
					LuaDLL.lua_rawget(L, -2);
					num = ((int)num2 * -152273717) ^ 0x6FFE1962;
					continue;
				case 14u:
				{
					int num7;
					if (num4 < array.Length)
					{
						num = -133647674;
						num7 = num;
					}
					else
					{
						num = -789874564;
						num7 = num;
					}
					continue;
				}
				case 16u:
					LuaDLL.lua_settop(L, num3);
					Debugger.LogError(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1467591696u), fullPath);
					return false;
				case 5u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -2025660366;
						num6 = num5;
					}
					else
					{
						num5 = -2068651775;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 780216018);
					continue;
				}
				case 17u:
					LuaDLL.lua_settop(L, num3);
					num = (int)(num2 * 586679418) ^ -1686693943;
					continue;
				case 0u:
					LuaDLL.lua_rawget(L, LuaIndexes.LUA_GLOBALSINDEX);
					num = (int)(num2 * 1591915569) ^ -1229912896;
					continue;
				case 3u:
					luaTypes = LuaDLL.lua_type(L, -1);
					num = (int)((num2 * 545159054) ^ 0x47CEA135);
					continue;
				case 18u:
					LuaDLL.lua_pushstring(L, array[num4]);
					num = -443071152;
					continue;
				case 1u:
					LuaDLL.lua_insert(L, num3 + 1);
					LuaDLL.lua_settop(L, num3 + 1);
					num = ((int)num2 * -872653710) ^ -1952525058;
					continue;
				case 7u:
					luaTypes = LuaDLL.lua_type(L, -1);
					num = (int)((num2 * 1046787026) ^ 0x4EA022BC);
					continue;
				default:
					return true;
				}
				break;
			}
		}
	}

	private static bool PushLuaFunction(IntPtr L, string fullPath)
	{
		int num = LuaDLL.lua_gettop(L);
		int num2 = _200B_202E_200E_202D_206E_202C_206D_202C_202C_206C_202A_206C_206A_202D_206A_202C_200D_202A_200C_202D_206C_200F_200E_200E_202B_202C_200E_200B_206D_202D_206D_200D_200F_200E_206F_202E_202A_200B_200E_206F_202E(fullPath, '.');
		LuaTypes luaTypes = default(LuaTypes);
		string fullPath2 = default(string);
		while (true)
		{
			int num3 = 2015366994;
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)(num3 ^ 0x1A77AC95)) % 16)
				{
				case 4u:
					break;
				case 2u:
					LuaDLL.lua_getglobal(L, fullPath);
					num3 = 1407952699;
					continue;
				case 14u:
					luaTypes = LuaDLL.lua_type(L, -1);
					num3 = (int)(num4 * 1837834215) ^ -2025834118;
					continue;
				case 3u:
					return false;
				case 7u:
				{
					int num10;
					int num11;
					if (num2 <= 0)
					{
						num10 = 1267367210;
						num11 = num10;
					}
					else
					{
						num10 = 340323118;
						num11 = num10;
					}
					num3 = num10 ^ (int)(num4 * 522008507);
					continue;
				}
				case 13u:
				{
					int num7;
					int num8;
					if (luaTypes != LuaTypes.LUA_TFUNCTION)
					{
						num7 = -1014745230;
						num8 = num7;
					}
					else
					{
						num7 = -1686914379;
						num8 = num7;
					}
					num3 = num7 ^ ((int)num4 * -1776721833);
					continue;
				}
				case 10u:
				{
					string str = _202C_202D_206A_202A_200E_200B_206B_206A_206A_206C_202B_202A_202A_206F_200E_202A_206B_206B_206C_200F_200C_206D_200B_200D_206E_206D_206B_202B_202E_202B_202A_200E_206B_200B_206A_206A_200D_202A_206F_206A_202E(fullPath, num2 + 1);
					LuaDLL.lua_pushstring(L, str);
					LuaDLL.lua_rawget(L, -2);
					num3 = (int)((num4 * 640835123) ^ 0x1025DE44);
					continue;
				}
				case 12u:
					LuaDLL.lua_settop(L, num);
					num3 = (int)(num4 * 147569498) ^ -610933588;
					continue;
				case 0u:
					LuaDLL.lua_settop(L, num + 1);
					num3 = (int)((num4 * 135965209) ^ 0x2C777C6E);
					continue;
				case 9u:
					LuaDLL.lua_insert(L, num + 1);
					num3 = 1647845701;
					continue;
				case 15u:
				{
					LuaTypes luaTypes2 = LuaDLL.lua_type(L, -1);
					int num9;
					if (luaTypes2 == LuaTypes.LUA_TFUNCTION)
					{
						num3 = 1590298044;
						num9 = num3;
					}
					else
					{
						num3 = 2042399293;
						num9 = num3;
					}
					continue;
				}
				case 5u:
				{
					int num5;
					int num6;
					if (!PushLuaTable(L, fullPath2))
					{
						num5 = 1387361834;
						num6 = num5;
					}
					else
					{
						num5 = 1781616271;
						num6 = num5;
					}
					num3 = num5 ^ (int)(num4 * 432339248);
					continue;
				}
				case 1u:
					return false;
				case 6u:
					fullPath2 = _202C_200B_206C_200E_206F_200C_200F_200C_206D_202C_206D_200F_206F_200C_206D_206C_206C_206B_200C_202B_206C_206C_206C_202E_206A_206B_200F_206D_206B_206D_202C_202D_206B_206B_206A_206A_202D_206E_206E_206D_202E(fullPath, 0, num2);
					num3 = (int)((num4 * 1536713908) ^ 0x29353378);
					continue;
				case 8u:
					LuaDLL.lua_settop(L, num);
					num3 = ((int)num4 * -931516873) ^ -486187282;
					continue;
				default:
					return true;
				}
				break;
			}
		}
	}

	public LuaTable GetLuaTable(string tableName)
	{
		LuaBase value = null;
		if (!dict.TryGetValue(tableName, out value))
		{
			goto IL_0012;
		}
		goto IL_0059;
		IL_0012:
		int num = 802115724;
		goto IL_0017;
		IL_0017:
		IntPtr l = default(IntPtr);
		int newTop = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x647AFF)) % 11)
			{
			case 0u:
				break;
			case 1u:
				goto IL_0059;
			case 4u:
				num = (int)((num2 * 511293441) ^ 0x45752BB0);
				continue;
			case 5u:
			{
				int num4;
				int num5;
				if (PushLuaTable(l, tableName))
				{
					num4 = 568141952;
					num5 = num4;
				}
				else
				{
					num4 = 1752232518;
					num5 = num4;
				}
				num = num4 ^ ((int)num2 * -2141864838);
				continue;
			}
			case 3u:
				LuaDLL.lua_settop(l, newTop);
				num = 1759641340;
				continue;
			case 8u:
				dict.Add(tableName, value);
				num = (int)(num2 * 1138052372) ^ -988965690;
				continue;
			case 7u:
				value.name = tableName;
				num = ((int)num2 * -1375656489) ^ 0x577E7DDE;
				continue;
			case 2u:
				l = lua.L;
				num = (int)(num2 * 1455131875) ^ -1122255862;
				continue;
			case 6u:
				newTop = LuaDLL.lua_gettop(l);
				num = ((int)num2 * -1570065594) ^ -532993447;
				continue;
			case 10u:
			{
				int num3 = LuaDLL.luaL_ref(l, LuaIndexes.LUA_REGISTRYINDEX);
				value = new LuaTable(num3, lua);
				num = (int)((num2 * 1418274721) ^ 0x5D973F9E);
				continue;
			}
			default:
				return value as LuaTable;
			}
			break;
		}
		goto IL_0012;
		IL_0059:
		value.AddRef();
		num = 1537705907;
		goto IL_0017;
	}

	public void RemoveLuaRes(string name)
	{
		dict.Remove(name);
	}

	private static void CreateTable(IntPtr L, string fullPath)
	{
		string[] array = _206A_202B_202B_206F_200D_206B_202B_202E_200B_202D_200E_206E_200C_206C_200E_202A_200C_202A_202B_206F_200C_200F_206A_200F_200F_206A_202A_200C_206A_206A_200C_202E_206F_206F_206D_200B_206C_206B_200B_202E_202E(fullPath, new char[1] { '.' });
		int num = LuaDLL.lua_gettop(L);
		int num8 = default(int);
		LuaTypes luaTypes2 = default(LuaTypes);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num2 = 2128645718;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x216FAD6B)) % 34)
				{
				case 0u:
					break;
				case 10u:
					LuaDLL.lua_rawget(L, -2);
					num2 = ((int)num3 * -862357057) ^ -1472709365;
					continue;
				case 6u:
					LuaDLL.lua_pushvalue(L, -2);
					num2 = (int)((num3 * 1536624366) ^ 0x72640A01);
					continue;
				case 26u:
					LuaDLL.lua_settable(L, LuaIndexes.LUA_GLOBALSINDEX);
					num2 = (int)((num3 * 1551454874) ^ 0x240E479);
					continue;
				case 8u:
					LuaDLL.lua_createtable(L, 0, 0);
					num2 = ((int)num3 * -324750546) ^ 0xE5D72EF;
					continue;
				case 9u:
					LuaDLL.lua_rawset(L, -4);
					num2 = (int)(num3 * 984902777) ^ -1487639197;
					continue;
				case 5u:
					num8++;
					num2 = 31861216;
					continue;
				case 27u:
					LuaDLL.lua_pop(L, 1);
					num2 = ((int)num3 * -850093874) ^ 0xC80BCC2;
					continue;
				case 32u:
				{
					int num11;
					int num12;
					if (luaTypes2 != LuaTypes.LUA_TNIL)
					{
						num11 = 1216197332;
						num12 = num11;
					}
					else
					{
						num11 = 1071246724;
						num12 = num11;
					}
					num2 = num11 ^ ((int)num3 * -1716105374);
					continue;
				}
				case 21u:
					LuaDLL.lua_pop(L, 1);
					num2 = ((int)num3 * -1518031754) ^ -1366855636;
					continue;
				case 33u:
					LuaDLL.lua_pushstring(L, array[num8]);
					LuaDLL.lua_rawget(L, -2);
					luaTypes = LuaDLL.lua_type(L, -1);
					num2 = 1142946545;
					continue;
				case 25u:
					LuaDLL.lua_pushvalue(L, -2);
					num2 = (int)((num3 * 2047880286) ^ 0x3D22FBC);
					continue;
				case 1u:
					LuaDLL.lua_pushvalue(L, -2);
					LuaDLL.lua_rawset(L, -4);
					num2 = ((int)num3 * -479024019) ^ -404317499;
					continue;
				case 24u:
					LuaDLL.lua_pop(L, 1);
					num2 = ((int)num3 * -1358675051) ^ -488115403;
					continue;
				case 18u:
					LuaDLL.lua_getglobal(L, array[0]);
					num2 = 490917054;
					continue;
				case 19u:
					LuaDLL.lua_createtable(L, 0, 0);
					num2 = ((int)num3 * -1750646628) ^ 0x5985C945;
					continue;
				case 14u:
					LuaDLL.lua_pushstring(L, array[0]);
					num2 = ((int)num3 * -1201818919) ^ 0x1B8AF86F;
					continue;
				case 23u:
					LuaDLL.lua_createtable(L, 0, 0);
					LuaDLL.lua_pushstring(L, array[0]);
					LuaDLL.lua_pushvalue(L, -2);
					num2 = (int)(num3 * 879755650) ^ -230721337;
					continue;
				case 15u:
				{
					int num15;
					if (num8 >= array.Length - 1)
					{
						num2 = 337478222;
						num15 = num2;
					}
					else
					{
						num2 = 605689412;
						num15 = num2;
					}
					continue;
				}
				case 13u:
					LuaDLL.lua_pushstring(L, array[array.Length - 1]);
					num2 = ((int)num3 * -321415893) ^ 0x30E80958;
					continue;
				case 2u:
					num8 = 1;
					num2 = 31861216;
					continue;
				case 30u:
					LuaDLL.lua_pushstring(L, array[num8]);
					num2 = (int)((num3 * 1996717445) ^ 0x5835AFD6);
					continue;
				case 31u:
					LuaDLL.lua_getglobal(L, array[0]);
					num2 = ((int)num3 * -389748419) ^ -1249727610;
					continue;
				case 12u:
				{
					int num13;
					int num14;
					if (luaTypes == LuaTypes.LUA_TNIL)
					{
						num13 = -1303207707;
						num14 = num13;
					}
					else
					{
						num13 = -1431226760;
						num14 = num13;
					}
					num2 = num13 ^ (int)(num3 * 185477253);
					continue;
				}
				case 16u:
					LuaDLL.lua_pop(L, 1);
					LuaDLL.lua_createtable(L, 0, 0);
					num2 = ((int)num3 * -320800854) ^ -155322435;
					continue;
				case 22u:
					LuaDLL.lua_pushstring(L, array[array.Length - 1]);
					num2 = (int)((num3 * 51559712) ^ 0x4F9C47E0);
					continue;
				case 3u:
				{
					int num9;
					int num10;
					if (luaTypes == LuaTypes.LUA_TNIL)
					{
						num9 = 95294546;
						num10 = num9;
					}
					else
					{
						num9 = 1463472067;
						num10 = num9;
					}
					num2 = num9 ^ ((int)num3 * -2026263641);
					continue;
				}
				case 7u:
					luaTypes2 = LuaDLL.lua_type(L, -1);
					num2 = ((int)num3 * -510219171) ^ -1153496502;
					continue;
				case 28u:
				{
					luaTypes = LuaDLL.lua_type(L, -1);
					int num6;
					int num7;
					if (luaTypes == LuaTypes.LUA_TNIL)
					{
						num6 = 2050888342;
						num7 = num6;
					}
					else
					{
						num6 = 1269204877;
						num7 = num6;
					}
					num2 = num6 ^ (int)(num3 * 987890916);
					continue;
				}
				case 11u:
				{
					int num4;
					int num5;
					if (array.Length <= 1)
					{
						num4 = 269882003;
						num5 = num4;
					}
					else
					{
						num4 = 382246910;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num3 * -1856156342);
					continue;
				}
				case 20u:
					luaTypes = LuaDLL.lua_type(L, -1);
					num2 = ((int)num3 * -1509981166) ^ 0x6D569DB0;
					continue;
				case 4u:
					LuaDLL.lua_settable(L, LuaIndexes.LUA_GLOBALSINDEX);
					num2 = (int)((num3 * 228713596) ^ 0x1C49B37C);
					continue;
				default:
					LuaDLL.lua_insert(L, num + 1);
					LuaDLL.lua_settop(L, num + 1);
					return;
				}
				break;
			}
		}
	}

	public static void RegisterLib(IntPtr L, string libName, Type t, LuaMethod[] regs)
	{
		CreateTable(L, libName);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = -1133630472;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1099478554)) % 15)
				{
				case 3u:
					break;
				case 2u:
					num3 = regs.Length - 1;
					LuaDLL.lua_pushstring(L, regs[num3].name);
					num = ((int)num2 * -598877601) ^ 0x7C8DC67F;
					continue;
				case 4u:
					LuaDLL.lua_pushstring(L, regs[num4].name);
					LuaDLL.lua_pushstdcallcfunction(L, regs[num4].func);
					num = -330715774;
					continue;
				case 0u:
					LuaDLL.lua_pushstring(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4006155256u));
					num = -1045772858;
					continue;
				case 1u:
					LuaDLL.lua_pop(L, 1);
					num = (int)((num2 * 804538708) ^ 0x5B561E0A);
					continue;
				case 7u:
					LuaDLL.lua_rawset(L, -3);
					num = (int)(num2 * 1807623667) ^ -1028980002;
					continue;
				case 5u:
				{
					LuaDLL.luaL_getmetatable(L, _200C_202B_202C_200D_202E_202E_200F_202C_206D_200C_200C_200B_200C_200F_202D_200D_202E_206F_200F_206F_206E_202B_200B_202A_200C_206A_206C_202E_200C_202A_206B_202D_200C_200E_206C_202C_202B_206F_206F_202B_202E(t));
					int num6;
					int num7;
					if (!LuaDLL.lua_isnil(L, -1))
					{
						num6 = 1851959168;
						num7 = num6;
					}
					else
					{
						num6 = 1435599958;
						num7 = num6;
					}
					num = num6 ^ ((int)num2 * -290653937);
					continue;
				}
				case 8u:
					num = ((int)num2 * -1511125365) ^ -1214137370;
					continue;
				case 10u:
					LuaDLL.lua_rawget(L, LuaIndexes.LUA_REGISTRYINDEX);
					LuaDLL.lua_setfield(L, -2, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1690598031u));
					num = ((int)num2 * -1988990695) ^ 0x72805D2D;
					continue;
				case 14u:
					LuaDLL.luaL_newmetatable(L, _200C_202B_202C_200D_202E_202E_200F_202C_206D_200C_200C_200B_200C_200F_202D_200D_202E_206F_200F_206F_206E_202B_200B_202A_200C_206A_206C_202E_200C_202A_206B_202D_200C_200E_206C_202C_202B_206F_206F_202B_202E(t));
					num = ((int)num2 * -452232818) ^ -654473350;
					continue;
				case 12u:
				{
					int num5;
					if (num4 >= regs.Length - 1)
					{
						num = -231672746;
						num5 = num;
					}
					else
					{
						num = -1788644330;
						num5 = num;
					}
					continue;
				}
				case 13u:
					num4++;
					num = (int)((num2 * 1922802973) ^ 0x6B4EF896);
					continue;
				case 6u:
					LuaDLL.lua_pushstdcallcfunction(L, __gc);
					LuaDLL.lua_rawset(L, -3);
					num4 = 0;
					num = (int)((num2 * 1517661157) ^ 0x3EE478B2);
					continue;
				case 11u:
					LuaDLL.lua_pushstring(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4112679809u));
					num = ((int)num2 * -1292671722) ^ -482486980;
					continue;
				default:
					LuaDLL.lua_pushstdcallcfunction(L, regs[num3].func);
					LuaDLL.lua_rawset(L, -4);
					LuaDLL.lua_setmetatable(L, -2);
					LuaDLL.lua_settop(L, 0);
					return;
				}
				break;
			}
		}
	}

	public static void RegisterLib(IntPtr L, string libName, LuaMethod[] regs)
	{
		CreateTable(L, libName);
		int num = 0;
		while (true)
		{
			int num2;
			int num3;
			if (num < regs.Length)
			{
				num2 = -1477117425;
				num3 = num2;
			}
			else
			{
				num2 = -1864838086;
				num3 = num2;
			}
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)(num2 ^ -1393897130)) % 6)
				{
				case 0u:
					num2 = -1477117425;
					continue;
				case 2u:
					num++;
					num2 = ((int)num4 * -593057632) ^ 0x5ED07B7B;
					continue;
				case 3u:
					break;
				case 5u:
					LuaDLL.lua_pushstring(L, regs[num].name);
					num2 = -34199259;
					continue;
				case 1u:
					LuaDLL.lua_pushstdcallcfunction(L, regs[num].func);
					LuaDLL.lua_rawset(L, -3);
					num2 = ((int)num4 * -535907350) ^ 0x6C186DF8;
					continue;
				default:
					LuaDLL.lua_settop(L, 0);
					return;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __gc(IntPtr luaState)
	{
		int num = LuaDLL.luanet_rawnetobj(luaState, 1);
		ObjectTranslator objectTranslator = default(ObjectTranslator);
		while (true)
		{
			int num2 = 1125026318;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x6E6CEEEE)) % 5)
				{
				case 4u:
					break;
				case 2u:
				{
					int num4;
					int num5;
					if (num == -1)
					{
						num4 = 1593457212;
						num5 = num4;
					}
					else
					{
						num4 = 507713115;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 738246967);
					continue;
				}
				case 1u:
					objectTranslator = ObjectTranslator.FromState(luaState);
					num2 = ((int)num3 * -27314564) ^ 0x500D861E;
					continue;
				case 3u:
					objectTranslator.collectObject(num);
					num2 = (int)(num3 * 1005568047) ^ -398553992;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	public static void RegisterLib(IntPtr L, string libName, Type t, LuaMethod[] regs, LuaField[] fields, Type baseType)
	{
		CreateTable(L, libName);
		LuaDLL.luaL_getmetatable(L, _200C_202B_202C_200D_202E_202E_200F_202C_206D_200C_200C_200B_200C_200F_202D_200D_202E_206F_200F_206F_206E_202B_200B_202A_200C_206A_206C_202E_200C_202A_206B_202D_200C_200E_206C_202C_202B_206F_206F_202B_202E(t));
		if (LuaDLL.lua_isnil(L, -1))
		{
			goto IL_001f;
		}
		goto IL_01cd;
		IL_001f:
		int num = 1898234827;
		goto IL_0024;
		IL_0024:
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x3171FEF6)) % 35)
			{
			case 7u:
				break;
			default:
				return;
			case 13u:
				num4 = 0;
				num = (int)(num2 * 1420571211) ^ -776808217;
				continue;
			case 17u:
				goto IL_00d9;
			case 32u:
				LuaDLL.lua_rawset(L, -3);
				num = (int)(num2 * 371003718) ^ -1429057381;
				continue;
			case 23u:
				LuaDLL.lua_pushstring(L, regs[num3].name);
				num = 337286370;
				continue;
			case 31u:
				num4++;
				num = ((int)num2 * -1115668325) ^ -1039439818;
				continue;
			case 20u:
				LuaDLL.lua_pushstdcallcfunction(L, fields[num4].getter);
				LuaDLL.lua_rawseti(L, -2, 1);
				num = (int)((num2 * 954346405) ^ 0x40BFB3EC);
				continue;
			case 26u:
				checkBaseType.Add(baseType);
				num = (int)((num2 * 877713431) ^ 0x7FE6D969);
				continue;
			case 3u:
			{
				int num7;
				int num8;
				if (LuaDLL.lua_isnil(L, -1))
				{
					num7 = 10089727;
					num8 = num7;
				}
				else
				{
					num7 = 187481273;
					num8 = num7;
				}
				num = num7 ^ ((int)num2 * -1329952548);
				continue;
			}
			case 8u:
				goto IL_01b2;
			case 11u:
				goto IL_01cd;
			case 22u:
				LuaDLL.lua_rawset(L, -3);
				num = 1662362676;
				continue;
			case 10u:
				num = (int)((num2 * 922853469) ^ 0x189111DE);
				continue;
			case 18u:
				LuaDLL.lua_pushstring(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3764655298u));
				LuaDLL.lua_pushstring(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2490404241u));
				LuaDLL.lua_rawget(L, LuaIndexes.LUA_REGISTRYINDEX);
				num = ((int)num2 * -643459449) ^ 0x256EF149;
				continue;
			case 33u:
				LuaDLL.lua_pushstdcallcfunction(L, fields[num4].setter);
				LuaDLL.lua_rawseti(L, -2, 2);
				num = (int)(num2 * 1811484017) ^ -1019855350;
				continue;
			case 30u:
				LuaDLL.lua_pushstdcallcfunction(L, regs[num3].func);
				num = ((int)num2 * -314230238) ^ 0x7D8CBAA4;
				continue;
			case 25u:
				LuaDLL.luaL_getmetatable(L, _200C_202B_202C_200D_202E_202E_200F_202C_206D_200C_200C_200B_200C_200F_202D_200D_202E_206F_200F_206F_206E_202B_200B_202A_200C_206A_206C_202E_200C_202A_206B_202D_200C_200E_206C_202C_202B_206F_206F_202B_202E(baseType));
				num = (int)((num2 * 1959665144) ^ 0x40D43716);
				continue;
			case 24u:
				LuaDLL.lua_rawset(L, -3);
				LuaDLL.lua_pushstring(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1157489904u));
				LuaDLL.lua_pushstdcallcfunction(L, __gc);
				num = (int)((num2 * 587378992) ^ 0x1BDAA3F9);
				continue;
			case 12u:
				LuaDLL.luaL_newmetatable(L, _200C_202B_202C_200D_202E_202E_200F_202C_206D_200C_200C_200B_200C_200F_202D_200D_202E_206F_200F_206F_206E_202B_200B_202A_200C_206A_206C_202E_200C_202A_206B_202D_200C_200E_206C_202C_202B_206F_206F_202B_202E(baseType));
				num = ((int)num2 * -1063260235) ^ -1506191123;
				continue;
			case 21u:
				LuaDLL.lua_pop(L, 1);
				LuaDLL.luaL_newmetatable(L, _200C_202B_202C_200D_202E_202E_200F_202C_206D_200C_200C_200B_200C_200F_202D_200D_202E_206F_200F_206F_206E_202B_200B_202A_200C_206A_206C_202E_200C_202A_206B_202D_200C_200E_206C_202C_202B_206F_206F_202B_202E(t));
				num = (int)(num2 * 1267233994) ^ -2057323382;
				continue;
			case 19u:
				goto IL_033c;
			case 28u:
			{
				int num5;
				int num6;
				if (fields[num4].getter == null)
				{
					num5 = -651168789;
					num6 = num5;
				}
				else
				{
					num5 = -864779887;
					num6 = num5;
				}
				num = num5 ^ (int)(num2 * 1151547225);
				continue;
			}
			case 27u:
				LuaDLL.lua_pushstring(L, fields[num4].name);
				LuaDLL.lua_createtable(L, 2, 0);
				num = 1071501409;
				continue;
			case 16u:
				LuaDLL.lua_setmetatable(L, -2);
				num = ((int)num2 * -1047635327) ^ -815573863;
				continue;
			case 9u:
				num3++;
				num = ((int)num2 * -173223788) ^ 0x6515FE78;
				continue;
			case 15u:
				LuaDLL.tolua_setindex(L);
				LuaDLL.tolua_setnewindex(L);
				num = 215240564;
				continue;
			case 4u:
				LuaDLL.lua_rawset(L, -3);
				num3 = 0;
				num = ((int)num2 * -1187786328) ^ 0x1DF6AF5;
				continue;
			case 0u:
				checkBaseType.Remove(baseType);
				num = 275053752;
				continue;
			case 6u:
				checkBaseType.Remove(t);
				num = (int)((num2 * 1988848872) ^ 0x40746E45);
				continue;
			case 29u:
				num = ((int)num2 * -404085139) ^ 0x3A87FF0F;
				continue;
			case 2u:
				LuaDLL.lua_settop(L, 0);
				num = ((int)num2 * -1495815923) ^ -707973;
				continue;
			case 1u:
				LuaDLL.lua_pop(L, 1);
				num = ((int)num2 * -816519898) ^ -1126294868;
				continue;
			case 14u:
				LuaDLL.lua_setmetatable(L, -2);
				num = 111619702;
				continue;
			case 5u:
				num = ((int)num2 * -1134195078) ^ 0x1A434F72;
				continue;
			case 34u:
				return;
			}
			break;
			IL_033c:
			int num9;
			if (fields[num4].setter != null)
			{
				num = 131597484;
				num9 = num;
			}
			else
			{
				num = 561917360;
				num9 = num;
			}
			continue;
			IL_01b2:
			int num10;
			if (num4 < fields.Length)
			{
				num = 1052365557;
				num10 = num;
			}
			else
			{
				num = 1412195101;
				num10 = num;
			}
			continue;
			IL_00d9:
			int num11;
			if (num3 >= regs.Length)
			{
				num = 1823133848;
				num11 = num;
			}
			else
			{
				num = 979593934;
				num11 = num;
			}
		}
		goto IL_001f;
		IL_01cd:
		int num12;
		if (baseType != null)
		{
			num = 1019591675;
			num12 = num;
		}
		else
		{
			num = 111619702;
			num12 = num;
		}
		goto IL_0024;
	}

	public static double GetNumber(IntPtr L, int stackPos)
	{
		if (LuaDLL.lua_isnumber(L, stackPos))
		{
			while (true)
			{
				uint num;
				switch ((num = 1568717204u) % 3)
				{
				case 0u:
					continue;
				case 2u:
					return LuaDLL.lua_tonumber(L, stackPos);
				}
				break;
			}
		}
		LuaDLL.luaL_typerror(L, stackPos, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1844122303u));
		return 0.0;
	}

	public static bool GetBoolean(IntPtr L, int stackPos)
	{
		if (LuaDLL.lua_isboolean(L, stackPos))
		{
			goto IL_0009;
		}
		goto IL_0046;
		IL_0009:
		int num = 2018882280;
		goto IL_000e;
		IL_000e:
		uint num2;
		switch ((num2 = (uint)(num ^ 0x4F4358A1)) % 4)
		{
		case 0u:
			break;
		case 1u:
			return LuaDLL.lua_toboolean(L, stackPos);
		case 2u:
			goto IL_0046;
		default:
			return false;
		}
		goto IL_0009;
		IL_0046:
		LuaDLL.luaL_typerror(L, stackPos, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1703943947u));
		num = 1015129650;
		goto IL_000e;
	}

	public static string GetString(IntPtr L, int stackPos)
	{
		string luaString = GetLuaString(L, stackPos);
		if (luaString == null)
		{
			while (true)
			{
				int num = -553358933;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -834935763)) % 3)
					{
					case 0u:
						break;
					case 1u:
						LuaDLL.luaL_typerror(L, stackPos, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(962144429u));
						num = ((int)num2 * -1645809918) ^ 0x46DE8476;
						continue;
					default:
						goto end_IL_000b;
					}
					break;
				}
				continue;
				end_IL_000b:
				break;
			}
		}
		return luaString;
	}

	public static LuaFunction GetFunction(IntPtr L, int stackPos)
	{
		LuaTypes luaTypes = LuaDLL.lua_type(L, stackPos);
		while (true)
		{
			int num = 858656468;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5D0033DD)) % 5)
				{
				case 2u:
					break;
				case 3u:
					LuaDLL.lua_pushvalue(L, stackPos);
					num = 913358227;
					continue;
				case 0u:
					return null;
				case 1u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TFUNCTION)
					{
						num3 = -730142509;
						num4 = num3;
					}
					else
					{
						num3 = -565159262;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1065752891);
					continue;
				}
				default:
					return new LuaFunction(LuaDLL.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX), GetTranslator(L).interpreter);
				}
				break;
			}
		}
	}

	public static LuaFunction ToLuaFunction(IntPtr L, int stackPos)
	{
		LuaDLL.lua_pushvalue(L, stackPos);
		return new LuaFunction(LuaDLL.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX), GetTranslator(L).interpreter);
	}

	public static LuaFunction GetLuaFunction(IntPtr L, int stackPos)
	{
		LuaFunction function = GetFunction(L, stackPos);
		while (true)
		{
			int num = 1558817370;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x738F7198)) % 5)
				{
				case 0u:
					break;
				case 1u:
					return null;
				case 4u:
					LuaDLL.luaL_typerror(L, stackPos, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2917354690u));
					num = (int)(num2 * 1494392880) ^ -294931006;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (function != null)
					{
						num3 = -1866276061;
						num4 = num3;
					}
					else
					{
						num3 = -527519790;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 20145515);
					continue;
				}
				default:
					return function;
				}
				break;
			}
		}
	}

	private static LuaTable ToLuaTable(IntPtr L, int stackPos)
	{
		LuaDLL.lua_pushvalue(L, stackPos);
		return new LuaTable(LuaDLL.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX), GetTranslator(L).interpreter);
	}

	private static LuaTable GetTable(IntPtr L, int stackPos)
	{
		LuaTypes luaTypes = LuaDLL.lua_type(L, stackPos);
		while (true)
		{
			int num = -775419213;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1316279859)) % 5)
				{
				case 0u:
					break;
				case 4u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 27893432;
						num4 = num3;
					}
					else
					{
						num3 = 993969208;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -103596973);
					continue;
				}
				case 3u:
					return null;
				case 2u:
					LuaDLL.lua_pushvalue(L, stackPos);
					num = -1052159792;
					continue;
				default:
					return new LuaTable(LuaDLL.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX), GetTranslator(L).interpreter);
				}
				break;
			}
		}
	}

	public static LuaTable GetLuaTable(IntPtr L, int stackPos)
	{
		LuaTable table = GetTable(L, stackPos);
		if (table == null)
		{
			while (true)
			{
				uint num;
				switch ((num = 1812009607u) % 3)
				{
				case 2u:
					continue;
				case 1u:
					LuaDLL.luaL_typerror(L, stackPos, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1703283680u));
					return null;
				}
				break;
			}
		}
		return table;
	}

	public static object GetLuaObject(IntPtr L, int stackPos)
	{
		return GetTranslator(L).getRawNetObject(L, stackPos);
	}

	public static object GetNetObjectSelf(IntPtr L, int stackPos, string type)
	{
		object rawNetObject = GetTranslator(L).getRawNetObject(L, stackPos);
		while (true)
		{
			int num = -2003282175;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)(num ^ -1415489113)) % 4)
				{
				case 3u:
					break;
				case 2u:
				{
					int num4;
					if (rawNetObject != null)
					{
						num3 = 1254782217;
						num4 = num3;
					}
					else
					{
						num3 = 126443732;
						num4 = num3;
					}
					goto IL_0045;
				}
				case 1u:
					LuaDLL.luaL_argerror(L, stackPos, _206E_206F_206B_206B_202D_200B_202E_202D_200E_202E_200B_206E_202B_202C_202A_202E_202D_202D_206E_202B_200F_200C_200D_202C_206E_202E_200B_206E_202D_206D_202D_200B_206A_202E_206F_202B_206E_200B_200D_202B_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1403133366u), (object)type));
					return null;
				default:
					return rawNetObject;
				}
				break;
				IL_0045:
				num = num3 ^ (int)(num2 * 2076520733);
			}
		}
	}

	public static object GetUnityObjectSelf(IntPtr L, int stackPos, string type)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object rawNetObject = GetTranslator(L).getRawNetObject(L, stackPos);
		while (true)
		{
			int num = -1630679576;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1626800434)) % 5)
				{
				case 3u:
					break;
				case 2u:
				{
					Object val = (Object)rawNetObject;
					int num3;
					int num4;
					if (_200D_200D_200B_206A_200B_200E_202C_206A_200D_206F_202E_206E_200B_206C_200D_200C_202D_206D_202A_200E_202A_206B_206C_200E_206B_200E_202D_200C_200C_202C_200F_206C_200E_202B_202B_202B_202A_206E_200E_202C_202E(val, (Object)null))
					{
						num3 = -1973982724;
						num4 = num3;
					}
					else
					{
						num3 = -387714195;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -212399782);
					continue;
				}
				case 0u:
					return null;
				case 1u:
					LuaDLL.luaL_argerror(L, stackPos, _206E_206F_206B_206B_202D_200B_202E_202D_200E_202E_200B_206E_202B_202C_202A_202E_202D_202D_206E_202B_200F_200C_200D_202C_206E_202E_200B_206E_202D_206D_202D_200B_206A_202E_206F_202B_206E_200B_200D_202B_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2476563062u), (object)type));
					num = (int)(num2 * 313104948) ^ -1444041333;
					continue;
				default:
					return rawNetObject;
				}
				break;
			}
		}
	}

	public static object GetTrackedObjectSelf(IntPtr L, int stackPos, string type)
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		object rawNetObject = GetTranslator(L).getRawNetObject(L, stackPos);
		TrackedReference val = default(TrackedReference);
		while (true)
		{
			int num = 809737176;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x76295665)) % 6)
				{
				case 5u:
					break;
				case 1u:
					LuaDLL.luaL_argerror(L, stackPos, _206E_206F_206B_206B_202D_200B_202E_202D_200E_202E_200B_206E_202B_202C_202A_202E_202D_202D_206E_202B_200F_200C_200D_202C_206E_202E_200B_206E_202D_206D_202D_200B_206A_202E_206F_202B_206E_200B_200D_202B_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1315886137u), (object)type));
					num = (int)(num2 * 767321803) ^ -1461214082;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!_202B_202B_202C_200E_200E_202C_206F_202A_202D_206F_202C_202E_206A_206E_206E_200F_202A_206F_206D_200F_206A_200C_202A_200F_206D_206F_206C_206B_200C_206C_206F_200E_206F_206A_206E_200F_200D_200B_206A_206D_202E(val, (TrackedReference)null))
					{
						num3 = -1387058123;
						num4 = num3;
					}
					else
					{
						num3 = -307681392;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -744172134);
					continue;
				}
				case 3u:
					val = (TrackedReference)rawNetObject;
					num = ((int)num2 * -859897455) ^ 0x7F120078;
					continue;
				case 0u:
					return null;
				default:
					return rawNetObject;
				}
				break;
			}
		}
	}

	public static T GetNetObject<T>(IntPtr L, int stackPos)
	{
		return (T)GetNetObject(L, stackPos, _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(T).TypeHandle));
	}

	public static object GetNetObject(IntPtr L, int stackPos, Type type)
	{
		if (LuaDLL.lua_isnil(L, stackPos))
		{
			goto IL_000c;
		}
		goto IL_00a8;
		IL_000c:
		int num = -2129061726;
		goto IL_0011;
		IL_0011:
		object luaObject = default(object);
		Type type2 = default(Type);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -944319112)) % 10)
			{
			case 0u:
				break;
			case 9u:
				return luaObject;
			case 1u:
				LuaDLL.luaL_argerror(L, stackPos, _206E_206F_206B_206B_202D_200B_202E_202D_200E_202E_200B_206E_202B_202C_202A_202E_202D_202D_206E_202B_200F_200C_200D_202C_206E_202E_200B_206E_202D_206D_202D_200B_206A_202E_206F_202B_206E_200B_200D_202B_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3084745107u), (object)_202A_200F_200F_200E_206E_200D_200B_202C_202C_202C_200C_202D_202B_200C_206C_200C_206B_200D_202D_200B_206A_206F_202B_202C_200C_200B_202B_200E_202B_200E_206C_206B_200D_206B_206B_206A_206C_202E_202C_206E_202E((MemberInfo)type)));
				num = ((int)num2 * -2090375694) ^ -1101836818;
				continue;
			case 3u:
			{
				int num5;
				int num6;
				if (_200B_202D_206A_206E_206D_200D_206D_202E_200E_202A_200D_206B_206B_206A_200D_202A_202E_200E_202C_202B_206F_200B_200B_206C_202B_206D_202D_206E_200C_202D_200E_206C_202C_200B_202A_206A_202B_206E_202C_202A_202E(type, type2))
				{
					num5 = -115661219;
					num6 = num5;
				}
				else
				{
					num5 = -1791130456;
					num6 = num5;
				}
				num = num5 ^ ((int)num2 * -700464408);
				continue;
			}
			case 5u:
				goto IL_00a8;
			case 7u:
				type2 = _202D_206E_202A_200B_206D_202E_202B_206E_206F_202C_202B_206E_206F_206D_202E_200C_206A_206A_202B_202A_200F_200E_200C_200E_206A_206E_200E_200E_200C_202A_206B_200E_202E_206E_200E_202E_202C_200E_202C_202E(luaObject);
				num = -453513128;
				continue;
			case 8u:
				return null;
			case 6u:
				return null;
			case 4u:
			{
				int num3;
				int num4;
				if (type == type2)
				{
					num3 = 170485701;
					num4 = num3;
				}
				else
				{
					num3 = 1125792271;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 1158311138);
				continue;
			}
			default:
				LuaDLL.luaL_argerror(L, stackPos, _202E_200C_200F_202A_202C_202E_206A_200D_202E_206D_206D_206A_206E_206D_206B_202B_200E_200E_202A_206F_200F_206B_200F_202A_202E_202C_202D_202D_200E_202D_202E_200D_200F_200B_202E_200F_200F_200B_206F_200E_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2622895087u), (object)_202A_200F_200F_200E_206E_200D_200B_202C_202C_202C_200C_202D_202B_200C_206C_200C_206B_200D_202D_200B_206A_206F_202B_202C_200C_200B_202B_200E_202B_200E_206C_206B_200D_206B_206B_206A_206C_202E_202C_206E_202E((MemberInfo)type), (object)_202A_200F_200F_200E_206E_200D_200B_202C_202C_202C_200C_202D_202B_200C_206C_200C_206B_200D_202D_200B_206A_206F_202B_202C_200C_200B_202B_200E_202B_200E_206C_206B_200D_206B_206B_206A_206C_202E_202C_206E_202E((MemberInfo)type2)));
				return null;
			}
			break;
		}
		goto IL_000c;
		IL_00a8:
		luaObject = GetLuaObject(L, stackPos);
		int num7;
		if (luaObject != null)
		{
			num = -650799717;
			num7 = num;
		}
		else
		{
			num = -384464493;
			num7 = num;
		}
		goto IL_0011;
	}

	public static T GetUnityObject<T>(IntPtr L, int stackPos) where T : Object
	{
		return (T)(object)GetUnityObject(L, stackPos, _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(T).TypeHandle));
	}

	public static Object GetUnityObject(IntPtr L, int stackPos, Type type)
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		if (LuaDLL.lua_isnil(L, stackPos))
		{
			goto IL_000c;
		}
		goto IL_00bc;
		IL_000c:
		int num = 1140804559;
		goto IL_0011;
		IL_0011:
		Object val = default(Object);
		object luaObject = default(object);
		Type type2 = default(Type);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x47B858EA)) % 13)
			{
			case 8u:
				break;
			case 7u:
			{
				int num5;
				int num6;
				if (_200D_200D_200B_206A_200B_200E_202C_206A_200D_206F_202E_206E_200B_206C_200D_200C_202D_206D_202A_200E_202A_206B_206C_200E_206B_200E_202D_200C_200C_202C_200F_206C_200E_202B_202B_202B_202A_206E_200E_202C_202E(val, (Object)null))
				{
					num5 = -559748046;
					num6 = num5;
				}
				else
				{
					num5 = -1157477005;
					num6 = num5;
				}
				num = num5 ^ ((int)num2 * -1094504648);
				continue;
			}
			case 12u:
				LuaDLL.luaL_argerror(L, stackPos, _206E_206F_206B_206B_202D_200B_202E_202D_200E_202E_200B_206E_202B_202C_202A_202E_202D_202D_206E_202B_200F_200C_200D_202C_206E_202E_200B_206E_202D_206D_202D_200B_206A_202E_206F_202B_206E_200B_200D_202B_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2911825959u), (object)_202A_200F_200F_200E_206E_200D_200B_202C_202C_202C_200C_202D_202B_200C_206C_200C_206B_200D_202D_200B_206A_206F_202B_202C_200C_200B_202B_200E_202B_200E_206C_206B_200D_206B_206B_206A_206C_202E_202C_206E_202E((MemberInfo)type)));
				num = ((int)num2 * -561613363) ^ -721067152;
				continue;
			case 0u:
				val = (Object)luaObject;
				num = 2039865344;
				continue;
			case 6u:
				goto IL_00bc;
			case 11u:
			{
				int num7;
				int num8;
				if (_206F_202A_200E_206F_202B_202A_206D_200E_206B_206E_200C_200D_206E_200B_202E_206D_206C_202E_200B_206E_200D_200B_202D_202B_206C_202E_202A_202B_200B_202A_206B_202B_202E_202A_202D_200B_200F_206A_206D_206D_202E(type2, type))
				{
					num7 = -1842240301;
					num8 = num7;
				}
				else
				{
					num7 = -247630606;
					num8 = num7;
				}
				num = num7 ^ ((int)num2 * -1767384279);
				continue;
			}
			case 5u:
				LuaDLL.luaL_argerror(L, stackPos, _206E_206F_206B_206B_202D_200B_202E_202D_200E_202E_200B_206E_202B_202C_202A_202E_202D_202D_206E_202B_200F_200C_200D_202C_206E_202E_200B_206E_202D_206D_202D_200B_206A_202E_206F_202B_206E_200B_200D_202B_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1315886137u), (object)_202A_200F_200F_200E_206E_200D_200B_202C_202C_202C_200C_202D_202B_200C_206C_200C_206B_200D_202D_200B_206A_206F_202B_202C_200C_200B_202B_200E_202B_200E_206C_206B_200D_206B_206B_206A_206C_202E_202C_206E_202E((MemberInfo)type)));
				return null;
			case 4u:
				return val;
			case 2u:
				return null;
			case 1u:
			{
				int num3;
				int num4;
				if (type != type2)
				{
					num3 = 167833149;
					num4 = num3;
				}
				else
				{
					num3 = 465737148;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 1624236799);
				continue;
			}
			case 3u:
				type2 = _202D_206E_202A_200B_206D_202E_202B_206E_206F_202C_202B_206E_206F_206D_202E_200C_206A_206A_202B_202A_200F_200E_200C_200E_206A_206E_200E_200E_200C_202A_206B_200E_202E_206E_200E_202E_202C_200E_202C_202E((object)val);
				num = 163367580;
				continue;
			case 9u:
				return null;
			default:
				LuaDLL.luaL_argerror(L, stackPos, _202E_200C_200F_202A_202C_202E_206A_200D_202E_206D_206D_206A_206E_206D_206B_202B_200E_200E_202A_206F_200F_206B_200F_202A_202E_202C_202D_202D_200E_202D_202E_200D_200F_200B_202E_200F_200F_200B_206F_200E_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2622895087u), (object)_202A_200F_200F_200E_206E_200D_200B_202C_202C_202C_200C_202D_202B_200C_206C_200C_206B_200D_202D_200B_206A_206F_202B_202C_200C_200B_202B_200E_202B_200E_206C_206B_200D_206B_206B_206A_206C_202E_202C_206E_202E((MemberInfo)type), (object)_202A_200F_200F_200E_206E_200D_200B_202C_202C_202C_200C_202D_202B_200C_206C_200C_206B_200D_202D_200B_206A_206F_202B_202C_200C_200B_202B_200E_202B_200E_206C_206B_200D_206B_206B_206A_206C_202E_202C_206E_202E((MemberInfo)type2)));
				return null;
			}
			break;
		}
		goto IL_000c;
		IL_00bc:
		luaObject = GetLuaObject(L, stackPos);
		int num9;
		if (luaObject == null)
		{
			num = 360666722;
			num9 = num;
		}
		else
		{
			num = 848415527;
			num9 = num;
		}
		goto IL_0011;
	}

	public static T GetTrackedObject<T>(IntPtr L, int stackPos) where T : TrackedReference
	{
		return (T)(object)GetTrackedObject(L, stackPos, _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(T).TypeHandle));
	}

	public static TrackedReference GetTrackedObject(IntPtr L, int stackPos, Type type)
	{
		if (LuaDLL.lua_isnil(L, stackPos))
		{
			goto IL_0009;
		}
		goto IL_0064;
		IL_0009:
		int num = -2066999458;
		goto IL_000e;
		IL_000e:
		TrackedReference val = default(TrackedReference);
		Type type2 = default(Type);
		object luaObject = default(object);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1155506568)) % 14)
			{
			case 13u:
				break;
			case 1u:
				return val;
			case 6u:
				goto IL_0064;
			case 5u:
			{
				int num7;
				int num8;
				if (type != type2)
				{
					num7 = -644597280;
					num8 = num7;
				}
				else
				{
					num7 = -1845072757;
					num8 = num7;
				}
				num = num7 ^ ((int)num2 * -1177272584);
				continue;
			}
			case 3u:
				type2 = _202D_206E_202A_200B_206D_202E_202B_206E_206F_202C_202B_206E_206F_206D_202E_200C_206A_206A_202B_202A_200F_200E_200C_200E_206A_206E_200E_200E_200C_202A_206B_200E_202E_206E_200E_202E_202C_200E_202C_202E(luaObject);
				num = -737311875;
				continue;
			case 0u:
				return null;
			case 10u:
				LuaDLL.luaL_argerror(L, stackPos, _206E_206F_206B_206B_202D_200B_202E_202D_200E_202E_200B_206E_202B_202C_202A_202E_202D_202D_206E_202B_200F_200C_200D_202C_206E_202E_200B_206E_202D_206D_202D_200B_206A_202E_206F_202B_206E_200B_200D_202B_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1403133366u), (object)_202A_200F_200F_200E_206E_200D_200B_202C_202C_202C_200C_202D_202B_200C_206C_200C_206B_200D_202D_200B_206A_206F_202B_202C_200C_200B_202B_200E_202B_200E_206C_206B_200D_206B_206B_206A_206C_202E_202C_206E_202E((MemberInfo)type)));
				num = (int)((num2 * 1367333845) ^ 0x60A91E87);
				continue;
			case 9u:
				return null;
			case 7u:
			{
				int num5;
				int num6;
				if (!_202B_202B_202C_200E_200E_202C_206F_202A_202D_206F_202C_202E_206A_206E_206E_200F_202A_206F_206D_200F_206A_200C_202A_200F_206D_206F_206C_206B_200C_206C_206F_200E_206F_206A_206E_200F_200D_200B_206A_206D_202E(val, (TrackedReference)null))
				{
					num5 = -1410982365;
					num6 = num5;
				}
				else
				{
					num5 = -514944540;
					num6 = num5;
				}
				num = num5 ^ ((int)num2 * -1175341580);
				continue;
			}
			case 2u:
				LuaDLL.luaL_argerror(L, stackPos, _206E_206F_206B_206B_202D_200B_202E_202D_200E_202E_200B_206E_202B_202C_202A_202E_202D_202D_206E_202B_200F_200C_200D_202C_206E_202E_200B_206E_202D_206D_202D_200B_206A_202E_206F_202B_206E_200B_200D_202B_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1403133366u), (object)_202A_200F_200F_200E_206E_200D_200B_202C_202C_202C_200C_202D_202B_200C_206C_200C_206B_200D_202D_200B_206A_206F_202B_202C_200C_200B_202B_200E_202B_200E_206C_206B_200D_206B_206B_206A_206C_202E_202C_206E_202E((MemberInfo)type)));
				num = ((int)num2 * -1383550497) ^ 0x40431FF8;
				continue;
			case 8u:
			{
				int num3;
				int num4;
				if (!_206F_202A_200E_206F_202B_202A_206D_200E_206B_206E_200C_200D_206E_200B_202E_206D_206C_202E_200B_206E_200D_200B_202D_202B_206C_202E_202A_202B_200B_202A_206B_202B_202E_202A_202D_200B_200F_206A_206D_206D_202E(type2, type))
				{
					num3 = -308737101;
					num4 = num3;
				}
				else
				{
					num3 = -1397398189;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 383576508);
				continue;
			}
			case 4u:
				return null;
			case 12u:
				val = (TrackedReference)((luaObject is TrackedReference) ? luaObject : null);
				num = -334500615;
				continue;
			default:
				LuaDLL.luaL_argerror(L, stackPos, _202E_200C_200F_202A_202C_202E_206A_200D_202E_206D_206D_206A_206E_206D_206B_202B_200E_200E_202A_206F_200F_206B_200F_202A_202E_202C_202D_202D_200E_202D_202E_200D_200F_200B_202E_200F_200F_200B_206F_200E_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(458349401u), (object)_202A_200F_200F_200E_206E_200D_200B_202C_202C_202C_200C_202D_202B_200C_206C_200C_206B_200D_202D_200B_206A_206F_202B_202C_200C_200B_202B_200E_202B_200E_206C_206B_200D_206B_206B_206A_206C_202E_202C_206E_202E((MemberInfo)type), (object)_202A_200F_200F_200E_206E_200D_200B_202C_202C_202C_200C_202D_202B_200C_206C_200C_206B_200D_202D_200B_206A_206F_202B_202C_200C_200B_202B_200E_202B_200E_206C_206B_200D_206B_206B_206A_206C_202E_202C_206E_202E((MemberInfo)type2)));
				return null;
			}
			break;
		}
		goto IL_0009;
		IL_0064:
		luaObject = GetLuaObject(L, stackPos);
		int num9;
		if (luaObject == null)
		{
			num = -1053524310;
			num9 = num;
		}
		else
		{
			num = -640471702;
			num9 = num;
		}
		goto IL_000e;
	}

	public static Type GetTypeObject(IntPtr L, int stackPos)
	{
		object luaObject = GetLuaObject(L, stackPos);
		if (luaObject != null)
		{
			goto IL_000b;
		}
		goto IL_0057;
		IL_000b:
		int num = -1538285491;
		goto IL_0010;
		IL_0010:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -236820134)) % 4)
			{
			case 0u:
				break;
			case 3u:
			{
				int num3;
				int num4;
				if (_202D_206E_202A_200B_206D_202E_202B_206E_206F_202C_202B_206E_206F_206D_202E_200C_206A_206A_202B_202A_200F_200E_200C_200E_206A_206E_200E_200E_200C_202A_206B_200E_202E_206E_200E_202E_202C_200E_202C_202E(luaObject) == monoType)
				{
					num3 = 661131904;
					num4 = num3;
				}
				else
				{
					num3 = 1575846639;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 1501439084);
				continue;
			}
			case 1u:
				goto IL_0057;
			default:
				return (Type)luaObject;
			}
			break;
		}
		goto IL_000b;
		IL_0057:
		LuaDLL.luaL_argerror(L, stackPos, _206E_206F_206B_206B_202D_200B_202E_202D_200E_202E_200B_206E_202B_202C_202A_202E_202D_202D_206E_202B_200F_200C_200D_202C_206E_202E_200B_206E_202D_206D_202D_200B_206A_202E_206F_202B_206E_200B_200D_202B_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3927939693u), (object)((luaObject != null) ? _202A_200F_200F_200E_206E_200D_200B_202C_202C_202C_200C_202D_202B_200C_206C_200C_206B_200D_202D_200B_206A_206F_202B_202C_200C_200B_202B_200E_202B_200E_206C_206B_200D_206B_206B_206A_206C_202E_202C_206E_202E((MemberInfo)_202D_206E_202A_200B_206D_202E_202B_206E_206F_202C_202B_206E_206F_206D_202E_200C_206A_206A_202B_202A_200F_200E_200C_200E_206A_206E_200E_200E_200C_202A_206B_200E_202E_206E_200E_202E_202C_200E_202C_202E(luaObject)) : global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1615967739u))));
		num = -1434320076;
		goto IL_0010;
	}

	public static bool IsClassOf(Type child, Type parent)
	{
		return child == parent || _200B_202D_206A_206E_206D_200D_206D_202E_200E_202A_200D_206B_206B_206A_200D_202A_202E_200E_202C_202B_206F_200B_200B_206C_202B_206D_202D_206E_200C_202D_200E_206C_202C_200B_202A_206A_202B_206E_202C_202A_202E(parent, child);
	}

	private static ObjectTranslator GetTranslator(IntPtr L)
	{
		if (_206B_206A_202B_202C_200D_200E_206F_206E_202B_206D_200B_200D_200E_206A_200C_206C_206A_200B_200C_200B_202B_202A_206A_206B_202E_202E_206C_200C_200C_202C_202B_206B_200E_206F_200D_206B_206C_206C_206F_202C_202E == null)
		{
			while (true)
			{
				uint num;
				switch ((num = 575784854u) % 3)
				{
				case 0u:
					continue;
				case 2u:
					return ObjectTranslator.FromState(L);
				}
				break;
			}
		}
		return _206B_206A_202B_202C_200D_200E_206F_206E_202B_206D_200B_200D_200E_206A_200C_206C_206A_200B_200C_200B_202B_202A_206A_206B_202E_202E_206C_200C_200C_202C_202B_206B_200E_206F_200D_206B_206C_206C_206F_202C_202E;
	}

	public static void PushVarObject(IntPtr L, object o)
	{
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_093a: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cd: Expected O, but got Unknown
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Unknown result type (might be due to invalid IL or missing references)
		if (o == null)
		{
			goto IL_0006;
		}
		goto IL_0894;
		IL_0006:
		int num = -461732961;
		goto IL_000b;
		IL_000b:
		string str = default(string);
		TrackedReference val2 = default(TrackedReference);
		Type type = default(Type);
		bool value = default(bool);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -2076676568)) % 77)
			{
			case 58u:
				break;
			default:
				return;
			case 1u:
				Push(L, (IEnumerator)o);
				num = ((int)num2 * -563049643) ^ -1443615987;
				continue;
			case 23u:
				str = (string)o;
				num = ((int)num2 * -1374965449) ^ 0x59AA3300;
				continue;
			case 21u:
				((LuaFunction)o).push(L);
				num = ((int)num2 * -1212371697) ^ -91142070;
				continue;
			case 74u:
				num = ((int)num2 * -226281797) ^ -215538964;
				continue;
			case 17u:
				val2 = (TrackedReference)o;
				num = ((int)num2 * -508646744) ^ 0x3528B1DC;
				continue;
			case 37u:
				((LuaTable)o).push(L);
				num = ((int)num2 * -2146343363) ^ 0x267BF3FA;
				continue;
			case 15u:
			{
				int num5;
				int num6;
				if (!_206F_206B_206E_206B_206C_206B_202E_202D_200B_200F_202B_200B_202B_206B_206B_206F_202D_202E_200D_206C_200D_200C_202D_202E_200C_202A_200E_206B_202B_206E_206D_206D_200E_200F_202B_206F_200C_202C_202D_200C_202E(type))
				{
					num5 = 1814485529;
					num6 = num5;
				}
				else
				{
					num5 = 589289446;
					num6 = num5;
				}
				num = num5 ^ ((int)num2 * -1431458674);
				continue;
			}
			case 44u:
				goto IL_021f;
			case 28u:
				goto IL_0240;
			case 10u:
				value = (bool)o;
				num = ((int)num2 * -1606380179) ^ 0x5C942CCA;
				continue;
			case 20u:
				LuaScriptMgr.Push(L, (Vector3)o);
				num = ((int)num2 * -1637039293) ^ 0x388E2488;
				continue;
			case 53u:
				num = ((int)num2 * -1329936628) ^ -975712375;
				continue;
			case 11u:
				Push(L, (Type)o);
				num = ((int)num2 * -374333044) ^ -1246860857;
				continue;
			case 9u:
				goto IL_02cc;
			case 42u:
				goto IL_02ed;
			case 52u:
				LuaScriptMgr.Push(L, (Touch)o);
				num = ((int)num2 * -985831510) ^ -199172688;
				continue;
			case 2u:
				PushObject(L, o);
				num = -443095391;
				continue;
			case 16u:
				LuaDLL.lua_pushnil(L);
				num = (int)(num2 * 1115013191) ^ -1018464424;
				continue;
			case 43u:
				LuaDLL.lua_pushnil(L);
				num = (int)((num2 * 103003083) ^ 0x72317216);
				continue;
			case 6u:
				goto IL_036b;
			case 66u:
				goto IL_0387;
			case 5u:
				return;
			case 60u:
				LuaDLL.lua_pushboolean(L, value);
				num = (int)((num2 * 911349042) ^ 0x73C856F5);
				continue;
			case 32u:
				num = ((int)num2 * -1786608902) ^ 0x6A3330BB;
				continue;
			case 68u:
				goto IL_03e4;
			case 70u:
				goto IL_0405;
			case 56u:
				goto IL_0426;
			case 75u:
				goto IL_044c;
			case 3u:
				goto IL_0472;
			case 26u:
				num = (int)((num2 * 1030977154) ^ 0x153685C9);
				continue;
			case 0u:
				GetTranslator(L).pushFunction(L, (LuaCSFunction)o);
				num = ((int)num2 * -17237430) ^ -1395072864;
				continue;
			case 19u:
				num = (int)(num2 * 1827383483) ^ -2010792530;
				continue;
			case 64u:
				LuaScriptMgr.Push(L, (RaycastHit)o);
				num = (int)(num2 * 2114132057) ^ -1508640532;
				continue;
			case 72u:
				num = ((int)num2 * -987210679) ^ 0x67622DD0;
				continue;
			case 14u:
				LuaScriptMgr.Push(L, (Color)o);
				num = ((int)num2 * -989855536) ^ 0x7B054B5F;
				continue;
			case 76u:
				return;
			case 45u:
				return;
			case 57u:
			{
				int num9;
				int num10;
				if (type == _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(bool).TypeHandle))
				{
					num9 = 1097950842;
					num10 = num9;
				}
				else
				{
					num9 = 257562741;
					num10 = num9;
				}
				num = num9 ^ ((int)num2 * -435026216);
				continue;
			}
			case 31u:
				num = ((int)num2 * -1922177286) ^ -1482151441;
				continue;
			case 22u:
				PushValue(L, o);
				num = -1131602267;
				continue;
			case 62u:
				LuaScriptMgr.Push(L, (Vector4)o);
				num = ((int)num2 * -923472453) ^ 0x6CDF9071;
				continue;
			case 36u:
				goto IL_05bf;
			case 30u:
				LuaDLL.lua_pushnil(L);
				num = (int)(num2 * 1472766885) ^ -127468820;
				continue;
			case 73u:
				return;
			case 49u:
				Push(L, (Delegate)o);
				num = ((int)num2 * -2062917297) ^ -1865736236;
				continue;
			case 7u:
				Push(L, (Enum)o);
				num = ((int)num2 * -430751037) ^ -804400030;
				continue;
			case 51u:
				PushArray(L, (Array)o);
				num = (int)(num2 * 732766464) ^ -718178667;
				continue;
			case 71u:
				num = ((int)num2 * -400196784) ^ -46762651;
				continue;
			case 65u:
				PushObject(L, o);
				num = -369781966;
				continue;
			case 41u:
			{
				double number = _206E_200F_202D_200B_200E_200E_200F_206A_206E_200D_202A_200D_206E_200E_200C_200E_202C_200E_206A_206B_200B_202B_202A_200F_206D_200D_202C_202D_200D_200E_206E_200E_206B_202D_200B_202B_206E_206F_202D_206A_202E(o);
				LuaDLL.lua_pushnumber(L, number);
				num = ((int)num2 * -1081654534) ^ -742572668;
				continue;
			}
			case 46u:
				goto IL_06aa;
			case 35u:
			{
				int num7;
				int num8;
				if (_202B_202B_202C_200E_200E_202C_206F_202A_202D_206F_202C_202E_206A_206E_206E_200F_202A_206F_206D_200F_206A_200C_202A_200F_206D_206F_206C_206B_200C_206C_206F_200E_206F_206A_206E_200F_200D_200B_206A_206D_202E(val2, (TrackedReference)null))
				{
					num7 = 824025759;
					num8 = num7;
				}
				else
				{
					num7 = 440652504;
					num8 = num7;
				}
				num = num7 ^ ((int)num2 * -1929017508);
				continue;
			}
			case 48u:
				PushObject(L, o);
				num = -1345685937;
				continue;
			case 69u:
				LuaScriptMgr.Push(L, (Ray)o);
				num = ((int)num2 * -747903330) ^ 0x102AB8FC;
				continue;
			case 54u:
				LuaScriptMgr.Push(L, (Quaternion)o);
				num = (int)(num2 * 1850932338) ^ -1076743633;
				continue;
			case 40u:
			{
				LuaStringBuffer luaStringBuffer = (LuaStringBuffer)o;
				LuaDLL.lua_pushlstring(L, luaStringBuffer.buffer, luaStringBuffer.buffer.Length);
				num = ((int)num2 * -1855607621) ^ -1964978034;
				continue;
			}
			case 38u:
				LuaDLL.lua_pushstring(L, str);
				num = ((int)num2 * -1681326809) ^ -619067547;
				continue;
			case 59u:
				goto IL_078c;
			case 67u:
				num = ((int)num2 * -1935752639) ^ -1015207584;
				continue;
			case 27u:
			{
				Object val = (Object)o;
				int num3;
				int num4;
				if (_200D_200D_200B_206A_200B_200E_202C_206A_200D_206F_202E_206E_200B_206C_200D_200C_202D_206D_202A_200E_202A_206B_206C_200E_206B_200E_202D_200C_200C_202C_200F_206C_200E_202B_202B_202B_202A_206E_200E_202C_202E(val, (Object)null))
				{
					num3 = -91568974;
					num4 = num3;
				}
				else
				{
					num3 = -919137659;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -1550588852);
				continue;
			}
			case 50u:
				num = ((int)num2 * -1744017684) ^ -995375451;
				continue;
			case 39u:
				goto IL_0807;
			case 8u:
				goto IL_0828;
			case 34u:
				goto IL_0849;
			case 25u:
				num = (int)(num2 * 120198595) ^ -1557927392;
				continue;
			case 47u:
				goto IL_0878;
			case 18u:
				goto IL_0894;
			case 12u:
				num = (int)(num2 * 1952580221) ^ -71948425;
				continue;
			case 13u:
				goto IL_08b8;
			case 33u:
				goto IL_08de;
			case 63u:
				num = (int)((num2 * 1266499330) ^ 0x66560BC1);
				continue;
			case 61u:
				num = (int)((num2 * 1250826655) ^ 0x349E5DEC);
				continue;
			case 4u:
				num = ((int)num2 * -1710260294) ^ 0x10C27C39;
				continue;
			case 24u:
				LuaScriptMgr.Push(L, (Vector2)o);
				num = (int)((num2 * 1247054522) ^ 0x204B34A7);
				continue;
			case 29u:
				goto IL_0957;
			case 55u:
				return;
			}
			break;
			IL_0957:
			int num11;
			if (type != _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(Vector4).TypeHandle))
			{
				num = -195933734;
				num11 = num;
			}
			else
			{
				num = -1099957484;
				num11 = num;
			}
			continue;
			IL_078c:
			int num12;
			if (!IsClassOf(type, _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(IEnumerator).TypeHandle)))
			{
				num = -1927210109;
				num12 = num;
			}
			else
			{
				num = -893497929;
				num12 = num;
			}
			continue;
			IL_02cc:
			int num13;
			if (type == _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(Color).TypeHandle))
			{
				num = -70393498;
				num13 = num;
			}
			else
			{
				num = -1839456766;
				num13 = num;
			}
			continue;
			IL_08de:
			int num14;
			if (type == _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(string).TypeHandle))
			{
				num = -1975593282;
				num14 = num;
			}
			else
			{
				num = -1319010672;
				num14 = num;
			}
			continue;
			IL_0426:
			int num15;
			if (_206F_202A_200E_206F_202B_202A_206D_200E_206B_206E_200C_200D_206E_200B_202E_206D_206C_202E_200B_206E_200D_200B_202D_202B_206C_202E_202A_202B_200B_202A_206B_202B_202E_202A_202D_200B_200F_206A_206D_206D_202E(type, _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(Object).TypeHandle)))
			{
				num = -2039754241;
				num15 = num;
			}
			else
			{
				num = -1755015968;
				num15 = num;
			}
			continue;
			IL_06aa:
			int num16;
			if (type != _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(Ray).TypeHandle))
			{
				num = -1675928334;
				num16 = num;
			}
			else
			{
				num = -1335579425;
				num16 = num;
			}
			continue;
			IL_08b8:
			int num17;
			if (!_206F_202A_200E_206F_202B_202A_206D_200E_206B_206E_200C_200D_206E_200B_202E_206D_206C_202E_200B_206E_200D_200B_202D_202B_206C_202E_202A_202B_200B_202A_206B_202B_202E_202A_202D_200B_200F_206A_206D_206D_202E(type, _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(Delegate).TypeHandle)))
			{
				num = -1801187509;
				num17 = num;
			}
			else
			{
				num = -383749677;
				num17 = num;
			}
			continue;
			IL_0387:
			int num18;
			if (type != _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(LuaStringBuffer).TypeHandle))
			{
				num = -1239579214;
				num18 = num;
			}
			else
			{
				num = -1810009803;
				num18 = num;
			}
			continue;
			IL_02ed:
			int num19;
			if (_200C_206B_200D_200F_206C_202A_206A_206D_202D_206F_206A_202D_202E_206F_202A_206E_206E_202D_202A_206F_202B_202B_202B_206F_206C_202B_202A_202C_202D_206C_206E_206F_200C_200C_206C_206C_200E_200E_202A_202E_202E(type))
			{
				num = -481328421;
				num19 = num;
			}
			else
			{
				num = -1253956976;
				num19 = num;
			}
			continue;
			IL_0878:
			int num20;
			if (!_206F_200C_206C_206E_202A_206B_206E_206F_200D_206A_202A_206A_200D_202E_206C_206C_206A_202A_206B_206F_200F_206E_202B_202D_200D_206A_206F_206A_200B_206D_206E_200B_200D_200B_206A_206A_206D_200D_202E_200C_202E(type))
			{
				num = -563816441;
				num20 = num;
			}
			else
			{
				num = -1783064109;
				num20 = num;
			}
			continue;
			IL_05bf:
			int num21;
			if (type == _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(Quaternion).TypeHandle))
			{
				num = -179179424;
				num21 = num;
			}
			else
			{
				num = -460164696;
				num21 = num;
			}
			continue;
			IL_0405:
			int num22;
			if (type != _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(Touch).TypeHandle))
			{
				num = -1268480301;
				num22 = num;
			}
			else
			{
				num = -607307542;
				num22 = num;
			}
			continue;
			IL_0849:
			int num23;
			if (!_200D_206E_206F_206C_206A_202E_206A_200D_206F_200F_206F_202B_202D_206A_206A_200F_200C_202D_200E_202E_202A_200E_206E_206D_206E_206F_206A_202C_202D_202A_206C_202C_202A_206E_206E_206B_200F_200B_206E_206A_202E(type))
			{
				num = -832897958;
				num23 = num;
			}
			else
			{
				num = -1273927130;
				num23 = num;
			}
			continue;
			IL_0240:
			int num24;
			if (type == _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(LuaFunction).TypeHandle))
			{
				num = -166395866;
				num24 = num;
			}
			else
			{
				num = -1164405820;
				num24 = num;
			}
			continue;
			IL_0472:
			int num25;
			if (type == _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(LuaTable).TypeHandle))
			{
				num = -1385114273;
				num25 = num;
			}
			else
			{
				num = -709764400;
				num25 = num;
			}
			continue;
			IL_0828:
			int num26;
			if (type != _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(Vector2).TypeHandle))
			{
				num = -1972595073;
				num26 = num;
			}
			else
			{
				num = -469032483;
				num26 = num;
			}
			continue;
			IL_036b:
			int num27;
			if (type != monoType)
			{
				num = -457948265;
				num27 = num;
			}
			else
			{
				num = -694731486;
				num27 = num;
			}
			continue;
			IL_03e4:
			int num28;
			if (type != _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(RaycastHit).TypeHandle))
			{
				num = -1680466291;
				num28 = num;
			}
			else
			{
				num = -1446178471;
				num28 = num;
			}
			continue;
			IL_0807:
			int num29;
			if (type == _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(LuaCSFunction).TypeHandle))
			{
				num = -935902866;
				num29 = num;
			}
			else
			{
				num = -674948553;
				num29 = num;
			}
			continue;
			IL_044c:
			int num30;
			if (_206F_202A_200E_206F_202B_202A_206D_200E_206B_206E_200C_200D_206E_200B_202E_206D_206C_202E_200B_206E_200D_200B_202D_202B_206C_202E_202A_202B_200B_202A_206B_202B_202E_202A_202D_200B_200F_206A_206D_206D_202E(type, _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(TrackedReference).TypeHandle)))
			{
				num = -682080399;
				num30 = num;
			}
			else
			{
				num = -830997144;
				num30 = num;
			}
			continue;
			IL_021f:
			int num31;
			if (type == _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(Vector3).TypeHandle))
			{
				num = -1965457930;
				num31 = num;
			}
			else
			{
				num = -143645865;
				num31 = num;
			}
		}
		goto IL_0006;
		IL_0894:
		type = _202D_206E_202A_200B_206D_202E_202B_206E_206F_202C_202B_206E_206F_206D_202E_200C_206A_206A_202B_202A_200F_200E_200C_200E_206A_206E_200E_200E_200C_202A_206B_200E_202E_206E_200E_202E_202C_200E_202C_202E(o);
		num = -1835202083;
		goto IL_000b;
	}

	public static void PushObject(IntPtr L, object o)
	{
		GetTranslator(L).pushObject(L, o, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3460890899u));
	}

	public static void Push(IntPtr L, Object obj)
	{
		PushObject(L, (!_200D_200D_200B_206A_200B_200E_202C_206A_200D_206F_202E_206E_200B_206C_200D_200C_202D_206D_202A_200E_202A_206B_206C_200E_206B_200E_202D_200C_200C_202C_200F_206C_200E_202B_202B_202B_202A_206E_200E_202C_202E(obj, (Object)null)) ? obj : null);
	}

	public static void Push(IntPtr L, TrackedReference obj)
	{
		PushObject(L, (!_202B_202B_202C_200E_200E_202C_206F_202A_202D_206F_202C_202E_206A_206E_206E_200F_202A_206F_206D_200F_206A_200C_202A_200F_206D_206F_206C_206B_200C_206C_206F_200E_206F_206A_206E_200F_200D_200B_206A_206D_202E(obj, (TrackedReference)null)) ? obj : null);
	}

	private static void PushMetaObject(IntPtr L, ObjectTranslator translator, object o, int metaRef)
	{
		if (o == null)
		{
			goto IL_0003;
		}
		goto IL_005d;
		IL_0003:
		int num = -1672797687;
		goto IL_0008;
		IL_0008:
		bool flag = default(bool);
		int weakTableRef = default(int);
		int index = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -143834628)) % 9)
			{
			case 7u:
				break;
			case 3u:
			{
				int num5;
				int num6;
				if (!flag)
				{
					num5 = 995026265;
					num6 = num5;
				}
				else
				{
					num5 = 255056702;
					num6 = num5;
				}
				num = num5 ^ (int)(num2 * 1114439030);
				continue;
			}
			case 5u:
				goto IL_005d;
			case 4u:
				return;
			case 8u:
				index = -1;
				flag = translator.objectsBackMap.TryGetValue(o, out index);
				num = (int)(num2 * 1723596151) ^ -1941568558;
				continue;
			case 0u:
				translator.collectObject(index);
				num = -463264665;
				continue;
			case 6u:
				LuaDLL.lua_pushnil(L);
				return;
			case 2u:
			{
				int num3;
				int num4;
				if (!LuaDLL.tolua_pushudata(L, weakTableRef, index))
				{
					num3 = 1275644636;
					num4 = num3;
				}
				else
				{
					num3 = 1645036427;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 944540751);
				continue;
			}
			default:
				index = translator.addObject(o, isValueType: false);
				LuaDLL.tolua_pushnewudata(L, metaRef, weakTableRef, index);
				return;
			}
			break;
		}
		goto IL_0003;
		IL_005d:
		weakTableRef = translator.weakTableRef;
		num = -509863319;
		goto IL_0008;
	}

	public static void Push(IntPtr L, Type o)
	{
		LuaScriptMgr mgrFromLuaState = GetMgrFromLuaState(L);
		ObjectTranslator translator = mgrFromLuaState.lua.translator;
		PushMetaObject(L, translator, o, mgrFromLuaState.typeMetaRef);
	}

	public static void Push(IntPtr L, Delegate o)
	{
		LuaScriptMgr mgrFromLuaState = GetMgrFromLuaState(L);
		ObjectTranslator translator = default(ObjectTranslator);
		while (true)
		{
			int num = 592972323;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x739AA130)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0029;
				default:
					PushMetaObject(L, translator, o, mgrFromLuaState.delegateMetaRef);
					return;
				}
				break;
				IL_0029:
				translator = mgrFromLuaState.lua.translator;
				num = ((int)num2 * -254577334) ^ 0x5D688FC7;
			}
		}
	}

	public static void Push(IntPtr L, IEnumerator o)
	{
		LuaScriptMgr mgrFromLuaState = GetMgrFromLuaState(L);
		ObjectTranslator translator = mgrFromLuaState.lua.translator;
		PushMetaObject(L, translator, o, mgrFromLuaState.iterMetaRef);
	}

	public static void PushArray(IntPtr L, Array o)
	{
		LuaScriptMgr mgrFromLuaState = GetMgrFromLuaState(L);
		ObjectTranslator translator = default(ObjectTranslator);
		while (true)
		{
			int num = -2101947508;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -356671759)) % 4)
				{
				case 3u:
					break;
				default:
					return;
				case 1u:
					translator = mgrFromLuaState.lua.translator;
					num = ((int)num2 * -1973083321) ^ -1832969906;
					continue;
				case 0u:
					PushMetaObject(L, translator, o, mgrFromLuaState.arrayMetaRef);
					num = ((int)num2 * -1086530473) ^ -1610861221;
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public static void PushValue(IntPtr L, object obj)
	{
		GetTranslator(L).PushValueResult(L, obj);
	}

	public static void Push(IntPtr L, bool b)
	{
		LuaDLL.lua_pushboolean(L, b);
	}

	public static void Push(IntPtr L, string str)
	{
		LuaDLL.lua_pushstring(L, str);
	}

	public static void Push(IntPtr L, char d)
	{
		LuaDLL.lua_pushinteger(L, d);
	}

	public static void Push(IntPtr L, sbyte d)
	{
		LuaDLL.lua_pushinteger(L, d);
	}

	public static void Push(IntPtr L, byte d)
	{
		LuaDLL.lua_pushinteger(L, d);
	}

	public static void Push(IntPtr L, short d)
	{
		LuaDLL.lua_pushinteger(L, d);
	}

	public static void Push(IntPtr L, ushort d)
	{
		LuaDLL.lua_pushinteger(L, d);
	}

	public static void Push(IntPtr L, int d)
	{
		LuaDLL.lua_pushinteger(L, d);
	}

	public static void Push(IntPtr L, uint d)
	{
		LuaDLL.lua_pushnumber(L, d);
	}

	public static void Push(IntPtr L, long d)
	{
		LuaDLL.lua_pushnumber(L, d);
	}

	public static void Push(IntPtr L, ulong d)
	{
		LuaDLL.lua_pushnumber(L, d);
	}

	public static void Push(IntPtr L, float d)
	{
		LuaDLL.lua_pushnumber(L, d);
	}

	public static void Push(IntPtr L, decimal d)
	{
		LuaDLL.lua_pushnumber(L, (double)d);
	}

	public static void Push(IntPtr L, double d)
	{
		LuaDLL.lua_pushnumber(L, d);
	}

	public static void Push(IntPtr L, IntPtr p)
	{
		LuaDLL.lua_pushlightuserdata(L, p);
	}

	public static void Push(IntPtr L, ILuaGeneratedType o)
	{
		if (o == null)
		{
			goto IL_0003;
		}
		goto IL_006b;
		IL_0003:
		int num = -2046459846;
		goto IL_0008;
		IL_0008:
		LuaTable luaTable = default(LuaTable);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -61729251)) % 6)
			{
			case 0u:
				break;
			default:
				return;
			case 5u:
				LuaDLL.lua_pushnil(L);
				num = ((int)num2 * -868975889) ^ 0x465A3027;
				continue;
			case 3u:
				luaTable.push(L);
				num = (int)(num2 * 1210119621) ^ -1152362316;
				continue;
			case 1u:
				num = ((int)num2 * -783145130) ^ 0x751F846F;
				continue;
			case 4u:
				goto IL_006b;
			case 2u:
				return;
			}
			break;
		}
		goto IL_0003;
		IL_006b:
		luaTable = o.__luaInterface_getLuaTable();
		num = -200950280;
		goto IL_0008;
	}

	public static void Push(IntPtr L, LuaTable table)
	{
		if (table == null)
		{
			goto IL_0003;
		}
		goto IL_0042;
		IL_0003:
		int num = 671179775;
		goto IL_0008;
		IL_0008:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x62B18F95)) % 5)
			{
			case 4u:
				break;
			default:
				return;
			case 2u:
				LuaDLL.lua_pushnil(L);
				num = ((int)num2 * -51010510) ^ -451541736;
				continue;
			case 0u:
				goto IL_0042;
			case 1u:
				num = (int)(num2 * 2106370285) ^ -1172215389;
				continue;
			case 3u:
				return;
			}
			break;
		}
		goto IL_0003;
		IL_0042:
		table.push(L);
		num = 1170967398;
		goto IL_0008;
	}

	public static void Push(IntPtr L, LuaFunction func)
	{
		if (func == null)
		{
			goto IL_0003;
		}
		goto IL_003e;
		IL_0003:
		int num = 191153919;
		goto IL_0008;
		IL_0008:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0xD62BE1)) % 4)
			{
			case 0u:
				break;
			default:
				return;
			case 2u:
				LuaDLL.lua_pushnil(L);
				num = (int)(num2 * 1232441700) ^ -276671034;
				continue;
			case 1u:
				goto IL_003e;
			case 3u:
				return;
			}
			break;
		}
		goto IL_0003;
		IL_003e:
		func.push();
		num = 963299454;
		goto IL_0008;
	}

	public static void Push(IntPtr L, LuaCSFunction func)
	{
		if (func == null)
		{
			goto IL_0003;
		}
		goto IL_003f;
		IL_0003:
		int num = -1473863495;
		goto IL_0008;
		IL_0008:
		uint num2;
		switch ((num2 = (uint)(num ^ -1568791976)) % 4)
		{
		case 3u:
			break;
		default:
			return;
		case 1u:
			LuaDLL.lua_pushnil(L);
			return;
		case 2u:
			goto IL_003f;
		case 0u:
			return;
		}
		goto IL_0003;
		IL_003f:
		GetTranslator(L).pushFunction(L, func);
		num = -1217860520;
		goto IL_0008;
	}

	public static bool CheckTypes(IntPtr L, int begin, Type type0)
	{
		return CheckType(L, type0, begin);
	}

	public static bool CheckTypes(IntPtr L, int begin, Type type0, Type type1)
	{
		return CheckType(L, type0, begin) && CheckType(L, type1, begin + 1);
	}

	public static bool CheckTypes(IntPtr L, int begin, Type type0, Type type1, Type type2)
	{
		if (!CheckType(L, type0, begin))
		{
			goto IL_0054;
		}
		while (true)
		{
			int num = -2019693966;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1641494159)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_002c;
				default:
					goto end_IL_000a;
				}
				break;
				IL_002c:
				if (CheckType(L, type1, begin + 1))
				{
					num = ((int)num2 * -1358416582) ^ -1489482139;
					continue;
				}
				goto IL_0054;
			}
			continue;
			end_IL_000a:
			break;
		}
		int result = (CheckType(L, type2, begin + 2) ? 1 : 0);
		goto IL_0055;
		IL_0055:
		return (byte)result != 0;
		IL_0054:
		result = 0;
		goto IL_0055;
	}

	public static bool CheckTypes(IntPtr L, int begin, Type type0, Type type1, Type type2, Type type3)
	{
		if (!CheckType(L, type0, begin))
		{
			goto IL_0074;
		}
		while (true)
		{
			int num = -1093336529;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -844922751)) % 4)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0030;
				case 3u:
					goto IL_004b;
				default:
					goto end_IL_000a;
				}
				break;
				IL_004b:
				if (CheckType(L, type2, begin + 2))
				{
					num = ((int)num2 * -429265046) ^ -217695942;
					continue;
				}
				goto IL_0074;
				IL_0030:
				if (CheckType(L, type1, begin + 1))
				{
					num = ((int)num2 * -1857519985) ^ -353782708;
					continue;
				}
				goto IL_0074;
			}
			continue;
			end_IL_000a:
			break;
		}
		int result = (CheckType(L, type3, begin + 3) ? 1 : 0);
		goto IL_0075;
		IL_0074:
		result = 0;
		goto IL_0075;
		IL_0075:
		return (byte)result != 0;
	}

	public static bool CheckTypes(IntPtr L, int begin, Type type0, Type type1, Type type2, Type type3, Type type4)
	{
		if (!CheckType(L, type0, begin))
		{
			goto IL_0097;
		}
		while (true)
		{
			int num = 714699348;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2EB2A8EB)) % 5)
				{
				case 0u:
					break;
				case 1u:
					goto IL_0037;
				case 4u:
					goto IL_0052;
				case 3u:
					goto IL_006e;
				default:
					goto end_IL_000d;
				}
				break;
				IL_006e:
				if (CheckType(L, type3, begin + 3))
				{
					num = (int)((num2 * 1965574786) ^ 0x149CFF48);
					continue;
				}
				goto IL_0097;
				IL_0037:
				if (CheckType(L, type1, begin + 1))
				{
					num = (int)((num2 * 33792175) ^ 0x28A7F2A1);
					continue;
				}
				goto IL_0097;
				IL_0052:
				if (CheckType(L, type2, begin + 2))
				{
					num = (int)(num2 * 924804737) ^ -1251874636;
					continue;
				}
				goto IL_0097;
			}
			continue;
			end_IL_000d:
			break;
		}
		int result = (CheckType(L, type4, begin + 4) ? 1 : 0);
		goto IL_0098;
		IL_0097:
		result = 0;
		goto IL_0098;
		IL_0098:
		return (byte)result != 0;
	}

	public static bool CheckTypes(IntPtr L, int begin, Type type0, Type type1, Type type2, Type type3, Type type4, Type type5)
	{
		if (!CheckType(L, type0, begin))
		{
			goto IL_00ba;
		}
		while (true)
		{
			int num = -1826714124;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1821514394)) % 6)
				{
				case 0u:
					break;
				case 2u:
					goto IL_003b;
				case 5u:
					goto IL_0056;
				case 4u:
					goto IL_0072;
				case 1u:
					goto IL_008e;
				default:
					goto end_IL_000d;
				}
				break;
				IL_008e:
				if (CheckType(L, type2, begin + 2))
				{
					num = ((int)num2 * -333137571) ^ 0x126270C7;
					continue;
				}
				goto IL_00ba;
				IL_0056:
				if (CheckType(L, type4, begin + 4))
				{
					num = ((int)num2 * -47073808) ^ -1212513779;
					continue;
				}
				goto IL_00ba;
				IL_0072:
				if (CheckType(L, type3, begin + 3))
				{
					num = (int)(num2 * 657211549) ^ -625367103;
					continue;
				}
				goto IL_00ba;
				IL_003b:
				if (CheckType(L, type1, begin + 1))
				{
					num = ((int)num2 * -939738521) ^ -1330235809;
					continue;
				}
				goto IL_00ba;
			}
			continue;
			end_IL_000d:
			break;
		}
		int result = (CheckType(L, type5, begin + 5) ? 1 : 0);
		goto IL_00bb;
		IL_00bb:
		return (byte)result != 0;
		IL_00ba:
		result = 0;
		goto IL_00bb;
	}

	public static bool CheckTypes(IntPtr L, int begin, Type type0, Type type1, Type type2, Type type3, Type type4, Type type5, Type type6)
	{
		if (!CheckType(L, type0, begin))
		{
			goto IL_00e6;
		}
		while (true)
		{
			int num = -1153053794;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -7048547)) % 7)
				{
				case 0u:
					break;
				case 1u:
					goto IL_0042;
				case 5u:
					goto IL_0061;
				case 6u:
					goto IL_007d;
				case 4u:
					goto IL_009c;
				case 3u:
					goto IL_00ba;
				default:
					goto end_IL_000d;
				}
				break;
				IL_00ba:
				if (CheckType(L, type4, begin + 4))
				{
					num = ((int)num2 * -1576006083) ^ 0x32AC2293;
					continue;
				}
				goto IL_00e6;
				IL_0042:
				if (CheckType(L, type5, begin + 5))
				{
					num = ((int)num2 * -1838208107) ^ -1791617582;
					continue;
				}
				goto IL_00e6;
				IL_009c:
				if (CheckType(L, type1, begin + 1))
				{
					num = (int)((num2 * 1558573519) ^ 0x4E0651BB);
					continue;
				}
				goto IL_00e6;
				IL_0061:
				if (CheckType(L, type2, begin + 2))
				{
					num = ((int)num2 * -1854013034) ^ 0xCFECFFE;
					continue;
				}
				goto IL_00e6;
				IL_007d:
				if (CheckType(L, type3, begin + 3))
				{
					num = (int)((num2 * 433366237) ^ 0x5F82A4A9);
					continue;
				}
				goto IL_00e6;
			}
			continue;
			end_IL_000d:
			break;
		}
		int result = (CheckType(L, type6, begin + 6) ? 1 : 0);
		goto IL_00e7;
		IL_00e6:
		result = 0;
		goto IL_00e7;
		IL_00e7:
		return (byte)result != 0;
	}

	public static bool CheckTypes(IntPtr L, int begin, Type type0, Type type1, Type type2, Type type3, Type type4, Type type5, Type type6, Type type7)
	{
		if (!CheckType(L, type0, begin))
		{
			goto IL_010c;
		}
		while (true)
		{
			int num = -1883155105;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -719180602)) % 8)
				{
				case 5u:
					break;
				case 7u:
					goto IL_0046;
				case 4u:
					goto IL_0065;
				case 1u:
					goto IL_0084;
				case 2u:
					goto IL_00a2;
				case 0u:
					goto IL_00c1;
				case 6u:
					goto IL_00e0;
				default:
					goto end_IL_000d;
				}
				break;
				IL_00e0:
				if (CheckType(L, type6, begin + 6))
				{
					num = (int)((num2 * 485812937) ^ 0x351ADAA3);
					continue;
				}
				goto IL_010c;
				IL_0084:
				if (CheckType(L, type1, begin + 1))
				{
					num = ((int)num2 * -1179669716) ^ -1446223082;
					continue;
				}
				goto IL_010c;
				IL_00c1:
				if (CheckType(L, type4, begin + 4))
				{
					num = ((int)num2 * -520493241) ^ -718028236;
					continue;
				}
				goto IL_010c;
				IL_0046:
				if (CheckType(L, type3, begin + 3))
				{
					num = (int)(num2 * 1003037175) ^ -1872749281;
					continue;
				}
				goto IL_010c;
				IL_00a2:
				if (CheckType(L, type5, begin + 5))
				{
					num = ((int)num2 * -1122232039) ^ 0x18938932;
					continue;
				}
				goto IL_010c;
				IL_0065:
				if (CheckType(L, type2, begin + 2))
				{
					num = (int)(num2 * 59533433) ^ -1635118219;
					continue;
				}
				goto IL_010c;
			}
			continue;
			end_IL_000d:
			break;
		}
		int result = (CheckType(L, type7, begin + 7) ? 1 : 0);
		goto IL_010d;
		IL_010c:
		result = 0;
		goto IL_010d;
		IL_010d:
		return (byte)result != 0;
	}

	public static bool CheckTypes(IntPtr L, int begin, Type type0, Type type1, Type type2, Type type3, Type type4, Type type5, Type type6, Type type7, Type type8)
	{
		if (!CheckType(L, type0, begin))
		{
			goto IL_0133;
		}
		while (true)
		{
			int num = 1969396790;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7596809E)) % 9)
				{
				case 0u:
					break;
				case 4u:
					goto IL_004b;
				case 7u:
					goto IL_006a;
				case 1u:
					goto IL_0089;
				case 8u:
					goto IL_00ab;
				case 2u:
					goto IL_00c9;
				case 6u:
					goto IL_00e8;
				case 3u:
					goto IL_0107;
				default:
					goto end_IL_000d;
				}
				break;
				IL_0107:
				if (CheckType(L, type3, begin + 3))
				{
					num = (int)((num2 * 2015820670) ^ 0x6CD62C0B);
					continue;
				}
				goto IL_0133;
				IL_006a:
				if (CheckType(L, type5, begin + 5))
				{
					num = (int)(num2 * 1264215601) ^ -8226615;
					continue;
				}
				goto IL_0133;
				IL_00e8:
				if (CheckType(L, type7, begin + 7))
				{
					num = (int)(num2 * 27847403) ^ -1815937685;
					continue;
				}
				goto IL_0133;
				IL_0089:
				if (CheckType(L, type2, begin + 2))
				{
					num = (int)(num2 * 1207159518) ^ -474048918;
					continue;
				}
				goto IL_0133;
				IL_00c9:
				if (CheckType(L, type6, begin + 6))
				{
					num = (int)(num2 * 1186924883) ^ -376465720;
					continue;
				}
				goto IL_0133;
				IL_004b:
				if (CheckType(L, type4, begin + 4))
				{
					num = ((int)num2 * -246461688) ^ 0xFC627E8;
					continue;
				}
				goto IL_0133;
				IL_00ab:
				if (CheckType(L, type1, begin + 1))
				{
					num = ((int)num2 * -1130501405) ^ -1380232763;
					continue;
				}
				goto IL_0133;
			}
			continue;
			end_IL_000d:
			break;
		}
		int result = (CheckType(L, type8, begin + 8) ? 1 : 0);
		goto IL_0134;
		IL_0133:
		result = 0;
		goto IL_0134;
		IL_0134:
		return (byte)result != 0;
	}

	public static bool CheckTypes(IntPtr L, int begin, Type type0, Type type1, Type type2, Type type3, Type type4, Type type5, Type type6, Type type7, Type type8, Type type9)
	{
		if (!CheckType(L, type0, begin))
		{
			goto IL_015a;
		}
		while (true)
		{
			int num = 1158801795;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2E3272A4)) % 10)
				{
				case 7u:
					break;
				case 6u:
					goto IL_004f;
				case 5u:
					goto IL_006e;
				case 1u:
					goto IL_008d;
				case 2u:
					goto IL_00ae;
				case 0u:
					goto IL_00d0;
				case 8u:
					goto IL_00ef;
				case 3u:
					goto IL_010e;
				case 4u:
					goto IL_012d;
				default:
					goto end_IL_000d;
				}
				break;
				IL_012d:
				if (CheckType(L, type4, begin + 4))
				{
					num = ((int)num2 * -1110281922) ^ 0x27385C30;
					continue;
				}
				goto IL_015a;
				IL_00ae:
				if (CheckType(L, type8, begin + 8))
				{
					num = ((int)num2 * -380025185) ^ 0x53950EF9;
					continue;
				}
				goto IL_015a;
				IL_010e:
				if (CheckType(L, type7, begin + 7))
				{
					num = (int)(num2 * 523991746) ^ -1379602936;
					continue;
				}
				goto IL_015a;
				IL_006e:
				if (CheckType(L, type6, begin + 6))
				{
					num = ((int)num2 * -94215747) ^ 0x58ECD97A;
					continue;
				}
				goto IL_015a;
				IL_00ef:
				if (CheckType(L, type5, begin + 5))
				{
					num = (int)(num2 * 131500661) ^ -1566338459;
					continue;
				}
				goto IL_015a;
				IL_008d:
				if (CheckType(L, type1, begin + 1))
				{
					num = ((int)num2 * -1988659618) ^ -487971388;
					continue;
				}
				goto IL_015a;
				IL_00d0:
				if (CheckType(L, type2, begin + 2))
				{
					num = ((int)num2 * -683397090) ^ 0x75B09C18;
					continue;
				}
				goto IL_015a;
				IL_004f:
				if (CheckType(L, type3, begin + 3))
				{
					num = (int)((num2 * 1208796319) ^ 0x64F3AD1C);
					continue;
				}
				goto IL_015a;
			}
			continue;
			end_IL_000d:
			break;
		}
		int result = (CheckType(L, type9, begin + 9) ? 1 : 0);
		goto IL_015b;
		IL_015a:
		result = 0;
		goto IL_015b;
		IL_015b:
		return (byte)result != 0;
	}

	public static bool CheckTypes(IntPtr L, int begin, params Type[] types)
	{
		int num = 0;
		while (true)
		{
			int num2 = 1403687458;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x76FC1DA2)) % 7)
				{
				case 5u:
					break;
				case 4u:
				{
					int num5;
					if (num < types.Length)
					{
						num2 = 734444079;
						num5 = num2;
					}
					else
					{
						num2 = 1783342661;
						num5 = num2;
					}
					continue;
				}
				case 3u:
				{
					int num4;
					if (CheckType(L, types[num], num + begin))
					{
						num2 = 2045179233;
						num4 = num2;
					}
					else
					{
						num2 = 827263359;
						num4 = num2;
					}
					continue;
				}
				case 6u:
					num2 = ((int)num3 * -1879502074) ^ 0x36252037;
					continue;
				case 2u:
					return false;
				case 0u:
					num++;
					num2 = 1443429687;
					continue;
				default:
					return true;
				}
				break;
			}
		}
	}

	public static bool CheckParamsType(IntPtr L, Type t, int begin, int count)
	{
		if (t == _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(object).TypeHandle))
		{
			goto IL_0010;
		}
		goto IL_00a8;
		IL_0010:
		int num = -232879906;
		goto IL_0015;
		IL_0015:
		int num3 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1616641270)) % 8)
			{
			case 0u:
				break;
			case 2u:
				goto IL_0046;
			case 5u:
				num3++;
				num = -791414303;
				continue;
			case 4u:
				return true;
			case 3u:
				goto IL_007f;
			case 6u:
				return false;
			case 7u:
				goto IL_00a8;
			default:
				return true;
			}
			break;
			IL_007f:
			int num4;
			if (num3 < count)
			{
				num = -232648328;
				num4 = num;
			}
			else
			{
				num = -902404389;
				num4 = num;
			}
			continue;
			IL_0046:
			int num5;
			if (CheckType(L, t, num3 + begin))
			{
				num = -430785609;
				num5 = num;
			}
			else
			{
				num = -1289457004;
				num5 = num;
			}
		}
		goto IL_0010;
		IL_00a8:
		num3 = 0;
		num = -791414303;
		goto IL_0015;
	}

	private static bool CheckTableType(IntPtr L, Type t, int stackPos)
	{
		if (_200C_206B_200D_200F_206C_202A_206A_206D_202D_206F_206A_202D_202E_206F_202A_206E_206E_202D_202A_206F_202B_202B_202B_206F_206C_202B_202A_202C_202D_206C_206E_206F_200C_200C_206C_206C_200E_200E_202A_202E_202E(t))
		{
			goto IL_000b;
		}
		goto IL_013f;
		IL_000b:
		int num = -480081565;
		goto IL_0010;
		IL_0010:
		string text = default(string);
		int newTop = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1398753055)) % 23)
			{
			case 19u:
				break;
			case 20u:
				goto IL_0081;
			case 21u:
				return t == _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(Vector4).TypeHandle);
			case 16u:
				return true;
			case 3u:
				text = LuaDLL.lua_tostring(L, -1);
				num = (int)(num2 * 2035274821) ^ -1318170673;
				continue;
			case 11u:
				LuaDLL.lua_pushstring(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(846611002u));
				LuaDLL.lua_gettable(L, -2);
				num = (int)((num2 * 1346633434) ^ 0x1DEB4225);
				continue;
			case 13u:
				return t == _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(Color).TypeHandle);
			case 17u:
				goto IL_013f;
			case 6u:
				return t == _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(Quaternion).TypeHandle);
			case 8u:
				goto IL_0180;
			case 22u:
				goto IL_01a6;
			case 18u:
				return t == _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(Vector3).TypeHandle);
			case 9u:
				return t == _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(Vector2).TypeHandle);
			case 14u:
				LuaDLL.lua_settop(L, newTop);
				num = ((int)num2 * -1787592308) ^ 0x7CA630F9;
				continue;
			case 7u:
			{
				int num3;
				int num4;
				if (_202B_206F_202D_200D_206F_206C_200C_200C_202C_206C_206C_206C_206A_202A_200C_206A_202E_206B_206C_200F_206C_200F_206B_206B_206D_200D_200F_200E_202C_206F_206B_202D_200F_206A_206B_206B_206A_206B_200D_202E_202E(text, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4006504997u)))
				{
					num3 = -65755557;
					num4 = num3;
				}
				else
				{
					num3 = -1877274120;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 343970597);
				continue;
			}
			case 0u:
				return t == _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(Ray).TypeHandle);
			case 4u:
				goto IL_0273;
			case 12u:
				goto IL_0299;
			case 2u:
				goto IL_02bf;
			case 1u:
				LuaDLL.lua_pushvalue(L, stackPos);
				num = ((int)num2 * -335500981) ^ 0x3D7F49A4;
				continue;
			case 10u:
				newTop = LuaDLL.lua_gettop(L);
				num = ((int)num2 * -2071561001) ^ 0x7D754717;
				continue;
			case 15u:
				return true;
			default:
				return false;
			}
			break;
			IL_02bf:
			int num5;
			if (!_206F_206B_206E_206B_206C_206B_202E_202D_200B_200F_202B_200B_202B_206B_206B_206F_202D_202E_200D_206C_200D_200C_202D_202E_200C_202A_200E_206B_202B_206E_206D_206D_200E_200F_202B_206F_200C_202C_202D_200C_202E(t))
			{
				num = -1045488382;
				num5 = num;
			}
			else
			{
				num = -16107420;
				num5 = num;
			}
			continue;
			IL_0273:
			int num6;
			if (!_202B_206F_202D_200D_206F_206C_200C_200C_202C_206C_206C_206C_206A_202A_200C_206A_202E_206B_206C_200F_206C_200F_206B_206B_206D_200D_200F_200E_202C_206F_206B_202D_200F_206A_206B_206B_206A_206B_200D_202E_202E(text, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1991708486u)))
			{
				num = -26928932;
				num6 = num;
			}
			else
			{
				num = -1687307794;
				num6 = num;
			}
			continue;
			IL_0180:
			int num7;
			if (!_202B_206F_202D_200D_206F_206C_200C_200C_202C_206C_206C_206C_206A_202A_200C_206A_202E_206B_206C_200F_206C_200F_206B_206B_206D_200D_200F_200E_202C_206F_206B_202D_200F_206A_206B_206B_206A_206B_200D_202E_202E(text, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4130552048u)))
			{
				num = -1045488382;
				num7 = num;
			}
			else
			{
				num = -269392831;
				num7 = num;
			}
			continue;
			IL_0299:
			int num8;
			if (_202B_206F_202D_200D_206F_206C_200C_200C_202C_206C_206C_206C_206A_202A_200C_206A_202E_206B_206C_200F_206C_200F_206B_206B_206D_200D_200F_200E_202C_206F_206B_202D_200F_206A_206B_206B_206A_206B_200D_202E_202E(text, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2575788074u)))
			{
				num = -2037727392;
				num8 = num;
			}
			else
			{
				num = -607692696;
				num8 = num;
			}
			continue;
			IL_0081:
			int num9;
			if (!_202B_206F_202D_200D_206F_206C_200C_200C_202C_206C_206C_206C_206A_202A_200C_206A_202E_206B_206C_200F_206C_200F_206B_206B_206D_200D_200F_200E_202C_206F_206B_202D_200F_206A_206B_206B_206A_206B_200D_202E_202E(text, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4160274666u)))
			{
				num = -1315664028;
				num9 = num;
			}
			else
			{
				num = -337409006;
				num9 = num;
			}
			continue;
			IL_01a6:
			int num10;
			if (!_202B_206F_202D_200D_206F_206C_200C_200C_202C_206C_206C_206C_206A_202A_200C_206A_202E_206B_206C_200F_206C_200F_206B_206B_206D_200D_200F_200E_202C_206F_206B_202D_200F_206A_206B_206B_206A_206B_200D_202E_202E(text, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4103711718u)))
			{
				num = -337145533;
				num10 = num;
			}
			else
			{
				num = -1587533732;
				num10 = num;
			}
		}
		goto IL_000b;
		IL_013f:
		int num11;
		if (t != _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(LuaTable).TypeHandle))
		{
			num = -2094022906;
			num11 = num;
		}
		else
		{
			num = -1243836143;
			num11 = num;
		}
		goto IL_0010;
	}

	public static bool CheckType(IntPtr L, Type t, int pos)
	{
		if (t == _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(object).TypeHandle))
		{
			goto IL_000d;
		}
		goto IL_0088;
		IL_000d:
		int num = -2015694779;
		goto IL_0012;
		IL_0012:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -867638217)) % 13)
			{
			case 4u:
				break;
			case 0u:
				num = (int)(num2 * 1848780657) ^ -1398069236;
				continue;
			case 11u:
				goto IL_006a;
			case 8u:
				goto IL_0078;
			case 3u:
				goto IL_0088;
			case 5u:
				goto IL_00c2;
			case 9u:
				goto IL_00da;
			case 1u:
				return true;
			case 10u:
				goto IL_00fd;
			case 2u:
				goto IL_0111;
			case 12u:
				goto IL_0129;
			default:
				goto IL_014d;
			}
			break;
		}
		goto IL_000d;
		IL_0129:
		return t == _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(bool).TypeHandle);
		IL_014d:
		return false;
		IL_0088:
		LuaTypes luaTypes = LuaDLL.lua_type(L, pos);
		switch (luaTypes)
		{
		case LuaTypes.LUA_TNUMBER:
			break;
		case LuaTypes.LUA_TTABLE:
			goto IL_0078;
		default:
			goto IL_00b8;
		case LuaTypes.LUA_TFUNCTION:
			goto IL_00c2;
		case LuaTypes.LUA_TNIL:
			goto IL_00da;
		case LuaTypes.LUA_TUSERDATA:
			goto IL_00fd;
		case LuaTypes.LUA_TSTRING:
			goto IL_0111;
		case LuaTypes.LUA_TBOOLEAN:
			goto IL_0129;
		case LuaTypes.LUA_TLIGHTUSERDATA:
			goto IL_014d;
		}
		goto IL_006a;
		IL_0111:
		return t == _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(string).TypeHandle);
		IL_00b8:
		num = -374708846;
		goto IL_0012;
		IL_00c2:
		return t == _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(LuaFunction).TypeHandle);
		IL_0078:
		return CheckTableType(L, t, pos);
		IL_00da:
		return t == null;
		IL_00fd:
		return CheckUserData(L, luaTypes, t, pos);
		IL_006a:
		return _200D_206E_206F_206C_206A_202E_206A_200D_206F_200F_206F_202B_202D_206A_206A_200F_200C_202D_200E_202E_202A_200E_206E_206D_206E_206F_206A_202C_202D_202A_206C_202C_202A_206E_206E_206B_200F_200B_206E_206A_202E(t);
	}

	private static bool CheckUserData(IntPtr L, LuaTypes luaType, Type t, int pos)
	{
		object luaObject = GetLuaObject(L, pos);
		Type type = _202D_206E_202A_200B_206D_202E_202B_206E_206F_202C_202B_206E_206F_206D_202E_200C_206A_206A_202B_202A_200F_200E_200C_200E_206A_206E_200E_200E_200C_202A_206B_200E_202E_206E_200E_202E_202C_200E_202C_202E(luaObject);
		while (true)
		{
			int num = 435830568;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x9F918CF)) % 6)
				{
				case 5u:
					break;
				case 2u:
				{
					int num5;
					if (t == _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(Type).TypeHandle))
					{
						num = 2018452664;
						num5 = num;
					}
					else
					{
						num = 533068893;
						num5 = num;
					}
					continue;
				}
				case 4u:
					return true;
				case 1u:
				{
					int num3;
					int num4;
					if (t != type)
					{
						num3 = 929462610;
						num4 = num3;
					}
					else
					{
						num3 = 799790754;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1229932583);
					continue;
				}
				case 3u:
					return type == monoType;
				default:
					return _200B_202D_206A_206E_206D_200D_206D_202E_200E_202A_200D_206B_206B_206A_200D_202A_202E_200E_202C_202B_206F_200B_200B_206C_202B_206D_202D_206E_200C_202D_200E_206C_202C_200B_202A_206A_202B_206E_202C_202A_202E(t, type);
				}
				break;
			}
		}
	}

	public static object[] GetParamsObject(IntPtr L, int stackPos, int count)
	{
		List<object> list = new List<object>();
		object obj = default(object);
		while (true)
		{
			int num = 157355508;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6BCCDE85)) % 12)
				{
				case 3u:
					break;
				case 0u:
					LuaDLL.luaL_argerror(L, stackPos, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1466452895u));
					num = 1395532016;
					continue;
				case 10u:
				{
					int num5;
					if (count <= 0)
					{
						num = 1858715938;
						num5 = num;
					}
					else
					{
						num = 1294100246;
						num5 = num;
					}
					continue;
				}
				case 2u:
				{
					int num3;
					int num4;
					if (obj == null)
					{
						num3 = -1676760357;
						num4 = num3;
					}
					else
					{
						num3 = -784978162;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -782751743);
					continue;
				}
				case 5u:
					num = (int)((num2 * 362048854) ^ 0x19F48D6C);
					continue;
				case 4u:
					num = ((int)num2 * -1624406794) ^ -1363329469;
					continue;
				case 6u:
					stackPos++;
					count--;
					num = ((int)num2 * -1730842965) ^ -685808435;
					continue;
				case 9u:
					list.Add(obj);
					num = (int)((num2 * 422266907) ^ 0x4BB52C16);
					continue;
				case 8u:
					num = (int)((num2 * 986686515) ^ 0x6F5ECCDB);
					continue;
				case 1u:
					obj = null;
					num = (int)(num2 * 2059646444) ^ -1145920823;
					continue;
				case 11u:
					obj = GetVarObject(L, stackPos);
					num = 915735171;
					continue;
				default:
					return list.ToArray();
				}
				break;
			}
		}
	}

	public static T[] GetParamsObject<T>(IntPtr L, int stackPos, int count)
	{
		List<T> list = new List<T>();
		T item = default(T);
		T val = default(T);
		object luaObject = default(object);
		while (true)
		{
			int num = -713880442;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1659916124)) % 12)
				{
				case 2u:
					break;
				case 11u:
				{
					int num5;
					if (count <= 0)
					{
						num = -256797096;
						num5 = num;
					}
					else
					{
						num = -363427919;
						num5 = num;
					}
					continue;
				}
				case 3u:
					list.Add(item);
					num = ((int)num2 * -1091876816) ^ 0x65A27B08;
					continue;
				case 10u:
					val = default(T);
					num = ((int)num2 * -1945332872) ^ -1866360713;
					continue;
				case 8u:
					num = ((int)num2 * -937411988) ^ -950657745;
					continue;
				case 6u:
				{
					int num6;
					int num7;
					if (luaObject != null)
					{
						num6 = 403963524;
						num7 = num6;
					}
					else
					{
						num6 = 143094401;
						num7 = num6;
					}
					num = num6 ^ (int)(num2 * 282188416);
					continue;
				}
				case 5u:
					luaObject = GetLuaObject(L, stackPos);
					stackPos++;
					count--;
					num = -1226968114;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (_202D_206E_202A_200B_206D_202E_202B_206E_206F_202C_202B_206E_206F_206D_202E_200C_206A_206A_202B_202A_200F_200E_200C_200E_206A_206E_200E_200E_200C_202A_206B_200E_202E_206E_200E_202E_202C_200E_202C_202E(luaObject) != _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(T).TypeHandle))
					{
						num3 = -1613913535;
						num4 = num3;
					}
					else
					{
						num3 = -196930883;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 788941502);
					continue;
				}
				case 1u:
					LuaDLL.luaL_argerror(L, stackPos, _206E_206F_206B_206B_202D_200B_202E_202D_200E_202E_200B_206E_202B_202C_202A_202E_202D_202D_206E_202B_200F_200C_200D_202C_206E_202E_200B_206E_202D_206D_202D_200B_206A_202E_206F_202B_206E_200B_200D_202B_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1315886137u), (object)_202A_200F_200F_200E_206E_200D_200B_202C_202C_202C_200C_202D_202B_200C_206C_200C_206B_200D_202D_200B_206A_206F_202B_202C_200C_200B_202B_200E_202B_200E_206C_206B_200D_206B_206B_206A_206C_202E_202C_206E_202E((MemberInfo)_206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(T).TypeHandle))));
					num = -256797096;
					continue;
				case 7u:
					item = val;
					num = (int)(num2 * 571414578) ^ -482029143;
					continue;
				case 9u:
					item = (T)luaObject;
					num = ((int)num2 * -1569822114) ^ 0x4FBC6695;
					continue;
				default:
					return list.ToArray();
				}
				break;
			}
		}
	}

	public static T[] GetArrayObject<T>(IntPtr L, int stackPos)
	{
		LuaTypes luaTypes = LuaDLL.lua_type(L, stackPos);
		T val = default(T);
		Type t = default(Type);
		T[] netObject = default(T[]);
		int num3 = default(int);
		List<T> list = default(List<T>);
		while (true)
		{
			int num = -694304908;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -612187454)) % 24)
				{
				case 21u:
					break;
				case 15u:
					val = default(T);
					num = ((int)num2 * -232759367) ^ -1454184419;
					continue;
				case 4u:
				{
					int num8;
					if (luaTypes != LuaTypes.LUA_TUSERDATA)
					{
						num = -707507430;
						num8 = num;
					}
					else
					{
						num = -1714182630;
						num8 = num;
					}
					continue;
				}
				case 6u:
				{
					int num10;
					int num11;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num10 = -654848290;
						num11 = num10;
					}
					else
					{
						num10 = -887070921;
						num11 = num10;
					}
					num = num10 ^ ((int)num2 * -34122112);
					continue;
				}
				case 20u:
					LuaDLL.lua_pushvalue(L, stackPos);
					t = _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(T).TypeHandle);
					num = ((int)num2 * -1391187668) ^ -1092286157;
					continue;
				case 19u:
					return null;
				case 12u:
				{
					int num6;
					int num7;
					if (netObject == null)
					{
						num6 = -42693192;
						num7 = num6;
					}
					else
					{
						num6 = -1516523776;
						num7 = num6;
					}
					num = num6 ^ (int)(num2 * 1480115043);
					continue;
				}
				case 13u:
					num3 = 1;
					num = ((int)num2 * -2136714849) ^ 0x7FA705C6;
					continue;
				case 2u:
				{
					T val2 = (T)GetVarObject(L, -1);
					list.Add(val2);
					LuaDLL.lua_pop(L, 1);
					num = -292068857;
					continue;
				}
				case 23u:
					LuaDLL.lua_pop(L, 1);
					num = (int)(num2 * 1965410091) ^ -1097968882;
					continue;
				case 5u:
					num3++;
					num = (int)((num2 * 1622770425) ^ 0x1AF7461E);
					continue;
				case 18u:
				{
					int num12;
					if (!CheckType(L, t, -1))
					{
						num = -1649607803;
						num12 = num;
					}
					else
					{
						num = -1225764760;
						num12 = num;
					}
					continue;
				}
				case 8u:
				{
					T val2 = val;
					num = (int)(num2 * 467011299) ^ -908602543;
					continue;
				}
				case 14u:
					return netObject;
				case 7u:
					LuaDLL.lua_pop(L, 1);
					num = ((int)num2 * -1190121533) ^ 0x35DEDAD4;
					continue;
				case 11u:
					list = new List<T>();
					num = (int)((num2 * 1638312210) ^ 0x65B83CC0);
					continue;
				case 16u:
					netObject = GetNetObject<T[]>(L, stackPos);
					num = (int)(num2 * 862476313) ^ -1246902610;
					continue;
				case 0u:
				{
					int num9;
					if (luaTypes != LuaTypes.LUA_TNIL)
					{
						num = -2046793349;
						num9 = num;
					}
					else
					{
						num = -1918170447;
						num9 = num;
					}
					continue;
				}
				case 10u:
				{
					luaTypes = LuaDLL.lua_type(L, -1);
					int num4;
					int num5;
					if (luaTypes != LuaTypes.LUA_TNIL)
					{
						num4 = -5705602;
						num5 = num4;
					}
					else
					{
						num4 = -1954503349;
						num5 = num4;
					}
					num = num4 ^ ((int)num2 * -715061941);
					continue;
				}
				case 1u:
					LuaDLL.lua_rawgeti(L, -1, num3);
					num = -1581335552;
					continue;
				case 17u:
					return list.ToArray();
				default:
					LuaDLL.luaL_error(L, _202E_200C_200F_202A_202C_202E_206A_200D_202E_206D_206D_206A_206E_206D_206B_202B_200E_200E_202A_206F_200F_206B_200F_202A_202E_202C_202D_202D_200E_202D_202E_200D_200F_200B_202E_200F_200F_200B_206F_200E_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(270341449u), (object)GetErrorFunc(1), (object)stackPos));
					return null;
				}
				break;
			}
		}
	}

	private static string GetErrorFunc(int skip)
	{
		StackFrame stackFrame = null;
		string text2 = default(string);
		int num4 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		StackTrace stackTrace = default(StackTrace);
		string text = default(string);
		while (true)
		{
			int num = -1612342731;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -980908991)) % 11)
				{
				case 5u:
					break;
				case 10u:
				{
					text2 = _202D_206A_200B_202D_206C_202C_200D_200F_200C_206F_202B_206F_200C_206A_200E_206D_200B_200E_206E_200D_200C_200C_206A_206D_206A_200B_202A_206A_206F_206F_200C_200B_202A_200E_200E_206D_202A_202B_202C_206A_202E(text2);
					int num6;
					int num7;
					if (_206B_206E_200D_202A_206F_206E_206B_202B_206A_206C_206A_200F_202E_200F_202C_200F_202E_206A_206B_202B_202D_202A_200F_202B_206B_200D_200F_206B_206C_200C_206E_202B_200F_206A_202B_206B_202E_200C_202B_206D_202E(text2, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(421283421u)))
					{
						num6 = 988367800;
						num7 = num6;
					}
					else
					{
						num6 = 1481223870;
						num7 = num6;
					}
					num = num6 ^ (int)(num2 * 440540044);
					continue;
				}
				case 8u:
					num4 = _202E_202D_200E_200C_200D_200D_200B_200C_206D_202E_206C_202E_200F_200D_206B_202A_202E_206D_206D_206D_200D_202D_206A_206D_206E_206F_200D_206A_206A_202E_206E_200D_206E_202A_206D_202E_206D_200E_200B_200D_202E(text2, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1923856809u));
					num = ((int)num2 * -824219602) ^ 0x2A3BF7B9;
					continue;
				case 9u:
					text2 = string.Empty;
					num = ((int)num2 * -588134592) ^ 0x1BC05F00;
					continue;
				case 3u:
					num3 = _200B_202E_200E_202D_206E_202C_206D_202C_202C_206C_202A_206C_206A_202D_206A_202C_200D_202A_200C_202D_206C_200F_200E_200E_202B_202C_200E_200B_206D_202D_206D_200D_200F_200E_206F_202E_202A_200B_200E_206F_202E(text2, '\\');
					num = (int)((num2 * 866351702) ^ 0x4545C546);
					continue;
				case 7u:
					num5 = 0;
					num = ((int)num2 * -1652987861) ^ 0x701B7DD5;
					continue;
				case 0u:
					text2 = _200B_202E_202D_206B_206E_206D_206E_206E_206A_202A_206F_202C_202D_200B_200C_206C_200D_206D_200F_206C_202B_202B_206C_200B_202A_200B_200E_206B_202E_202D_202E_202D_206D_202A_202D_200D_200E_200E_206F_206D_202E(stackFrame);
					num = ((int)num2 * -829925282) ^ 0x49D17067;
					continue;
				case 1u:
					stackTrace = _206F_200E_206D_200B_206C_200D_200C_206A_200E_202B_200B_202A_200E_206B_206B_206D_206A_206D_200B_200E_200F_206B_202C_206E_200B_202A_206D_202E_206D_200B_200D_206D_206D_202E_206A_206C_206B_206C_202E_206C_202E(skip, true);
					num = (int)((num2 * 1848185456) ^ 0x4EE03990);
					continue;
				case 4u:
					stackFrame = _200B_206D_206E_206C_202B_202E_206C_206D_206D_206C_200B_202C_206B_200F_202C_206F_202A_202B_202E_202A_202C_202B_206D_206C_202B_206C_200C_200E_202B_206E_200C_206F_200C_202B_206B_206A_206E_202B_206D_200C_202E(stackTrace, num5++);
					num = -554285768;
					continue;
				case 2u:
					text = _202C_200B_206C_200E_206F_200C_200F_200C_206D_202C_206D_200F_206F_200C_206D_206C_206C_206B_200C_202B_206C_206C_206C_202E_206A_206B_200F_206D_206B_206D_202C_202D_206B_206B_206A_206A_202D_206E_206E_206D_202E(text2, num3 + 1, num4 - num3 - 1);
					num = (int)((num2 * 1544045814) ^ 0x51F73C49);
					continue;
				default:
					return _202E_200C_200F_202A_202C_202E_206A_200D_202E_206D_206D_206A_206E_206D_206B_202B_200E_200E_202A_206F_200F_206B_200F_202A_202E_202C_202D_202D_200E_202D_202E_200D_200F_200B_202E_200F_200F_200B_206F_200E_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(459018914u), (object)text, (object)_202A_200F_200F_200E_206E_200D_200B_202C_202C_202C_200C_202D_202B_200C_206C_200C_206B_200D_202D_200B_206A_206F_202B_202C_200C_200B_202B_200E_202B_200E_206C_206B_200D_206B_206B_206A_206C_202E_202C_206E_202E((MemberInfo)_202C_206A_206F_200F_202B_202B_206F_206E_206E_206E_200C_206C_200C_200D_206E_206C_206C_202A_202A_202A_202B_200D_200E_206A_206D_206C_200C_206E_206E_206D_202B_206A_206B_206E_206C_202C_202E_206D_202E_202E(stackFrame)));
				}
				break;
			}
		}
	}

	public static string GetLuaString(IntPtr L, int stackPos)
	{
		LuaTypes luaTypes = LuaDLL.lua_type(L, stackPos);
		string result = null;
		bool flag = default(bool);
		object luaObject = default(object);
		while (true)
		{
			int num = 368186178;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x157FD92)) % 27)
				{
				case 9u:
					break;
				case 5u:
					result = flag.ToString();
					num = (int)(num2 * 1479662377) ^ -595641811;
					continue;
				case 11u:
					num = ((int)num2 * -874266773) ^ -73818621;
					continue;
				case 10u:
					LuaDLL.lua_pushvalue(L, stackPos);
					num = ((int)num2 * -862731967) ^ -1076496465;
					continue;
				case 20u:
					result = (string)luaObject;
					num = (int)((num2 * 1509319254) ^ 0x6E420DE2);
					continue;
				case 23u:
					num = ((int)num2 * -830409985) ^ -1362843056;
					continue;
				case 18u:
				{
					int num9;
					if (luaTypes != LuaTypes.LUA_TNIL)
					{
						num = 1724815156;
						num9 = num;
					}
					else
					{
						num = 506741578;
						num9 = num;
					}
					continue;
				}
				case 21u:
					num = (int)(num2 * 550218265) ^ -1142653117;
					continue;
				case 8u:
					flag = LuaDLL.lua_toboolean(L, stackPos);
					num = (int)(num2 * 2138781723) ^ -1658211363;
					continue;
				case 2u:
					LuaDLL.lua_pop(L, 1);
					num = (int)(num2 * 231852902) ^ -2101454518;
					continue;
				case 17u:
					return result;
				case 15u:
					return string.Empty;
				case 19u:
					LuaDLL.lua_call(L, 1, 1);
					result = LuaDLL.lua_tostring(L, -1);
					num = ((int)num2 * -1120118544) ^ 0x1085E6D8;
					continue;
				case 3u:
				{
					int num11;
					if (luaTypes == LuaTypes.LUA_TBOOLEAN)
					{
						num = 668881615;
						num11 = num;
					}
					else
					{
						num = 1225242094;
						num11 = num;
					}
					continue;
				}
				case 4u:
				{
					int num10;
					if (_202D_206E_202A_200B_206D_202E_202B_206E_206F_202C_202B_206E_206F_206D_202E_200C_206A_206A_202B_202A_200F_200E_200C_200E_206A_206E_200E_200E_200C_202A_206B_200E_202E_206E_200E_202E_202C_200E_202C_202E(luaObject) == _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(string).TypeHandle))
					{
						num = 1036275348;
						num10 = num;
					}
					else
					{
						num = 132248169;
						num10 = num;
					}
					continue;
				}
				case 7u:
					result = LuaDLL.lua_tostring(L, stackPos);
					num = (int)((num2 * 1507356680) ^ 0x2941DAE8);
					continue;
				case 13u:
				{
					int num7;
					int num8;
					if (luaTypes != LuaTypes.LUA_TSTRING)
					{
						num7 = 1962172057;
						num8 = num7;
					}
					else
					{
						num7 = 269177474;
						num8 = num7;
					}
					num = num7 ^ (int)(num2 * 1703115252);
					continue;
				}
				case 16u:
				{
					int num6;
					if (luaTypes != LuaTypes.LUA_TUSERDATA)
					{
						num = 275257790;
						num6 = num;
					}
					else
					{
						num = 1147101422;
						num6 = num;
					}
					continue;
				}
				case 26u:
					result = LuaDLL.lua_tonumber(L, stackPos).ToString();
					num = (int)(num2 * 1751920349) ^ -1254780256;
					continue;
				case 22u:
				{
					luaObject = GetLuaObject(L, stackPos);
					int num4;
					int num5;
					if (luaObject == null)
					{
						num4 = 318029001;
						num5 = num4;
					}
					else
					{
						num4 = 757931931;
						num5 = num4;
					}
					num = num4 ^ ((int)num2 * -878270066);
					continue;
				}
				case 1u:
				{
					int num3;
					if (luaTypes != LuaTypes.LUA_TNUMBER)
					{
						num = 1842544833;
						num3 = num;
					}
					else
					{
						num = 882954181;
						num3 = num;
					}
					continue;
				}
				case 24u:
					LuaDLL.luaL_argerror(L, stackPos, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2858561478u));
					num = ((int)num2 * -1863758734) ^ 0x3D3446EE;
					continue;
				case 0u:
					LuaDLL.lua_getglobal(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(694333374u));
					num = 1530256518;
					continue;
				case 25u:
					result = _202B_200D_202D_206C_206C_202E_200F_206F_200B_206E_202D_200D_206D_206D_202E_200F_202C_206B_206A_202B_202D_202E_200B_206B_200C_202A_202C_200B_206F_206E_200E_206F_202B_206C_202C_206D_200C_202A_206C_202E(luaObject);
					num = 1708715031;
					continue;
				case 14u:
					num = (int)((num2 * 1432777771) ^ 0x27A548B5);
					continue;
				default:
					return result;
				}
				break;
			}
		}
	}

	public static string[] GetParamsString(IntPtr L, int stackPos, int count)
	{
		List<string> list = new List<string>();
		string text = null;
		while (true)
		{
			int num = 1470062679;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3454BFD5)) % 9)
				{
				case 3u:
					break;
				case 8u:
					LuaDLL.luaL_argerror(L, stackPos, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2435246435u));
					num = ((int)num2 * -508269190) ^ -1710881706;
					continue;
				case 7u:
					text = GetLuaString(L, stackPos);
					num = 556247708;
					continue;
				case 2u:
					stackPos++;
					count--;
					num = ((int)num2 * -2077739005) ^ 0x5DA64FA6;
					continue;
				case 6u:
				{
					int num5;
					if (count > 0)
					{
						num = 1431743283;
						num5 = num;
					}
					else
					{
						num = 1401118024;
						num5 = num;
					}
					continue;
				}
				case 4u:
					num = (int)(num2 * 1615162034) ^ -995111110;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (text != null)
					{
						num3 = -1901292925;
						num4 = num3;
					}
					else
					{
						num3 = -39107586;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1444175846);
					continue;
				}
				case 0u:
					list.Add(text);
					num = 150532958;
					continue;
				default:
					return list.ToArray();
				}
				break;
			}
		}
	}

	public static string[] GetArrayString(IntPtr L, int stackPos)
	{
		LuaTypes luaTypes = LuaDLL.lua_type(L, stackPos);
		string[] netObject = default(string[]);
		int num3 = default(int);
		string item = default(string);
		List<string> list = default(List<string>);
		while (true)
		{
			int num = -1334421329;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1515037061)) % 21)
				{
				case 0u:
					break;
				case 15u:
				{
					netObject = GetNetObject<string[]>(L, stackPos);
					int num10;
					int num11;
					if (netObject != null)
					{
						num10 = 493767286;
						num11 = num10;
					}
					else
					{
						num10 = 1105439682;
						num11 = num10;
					}
					num = num10 ^ (int)(num2 * 168747025);
					continue;
				}
				case 20u:
					LuaDLL.lua_rawgeti(L, -1, num3);
					num = -859175329;
					continue;
				case 10u:
					item = null;
					num = (int)(num2 * 1208611053) ^ -1915295746;
					continue;
				case 3u:
				case 16u:
					LuaDLL.luaL_error(L, _202E_200C_200F_202A_202C_202E_206A_200D_202E_206D_206D_206A_206E_206D_206B_202B_200E_200E_202A_206F_200F_206B_200F_202A_202E_202C_202D_202D_200E_202D_202E_200D_200F_200B_202E_200F_200F_200B_206F_200E_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(568867095u), (object)GetErrorFunc(1), (object)stackPos));
					num = -1779888770;
					continue;
				case 8u:
					list.Add(item);
					LuaDLL.lua_pop(L, 1);
					num3++;
					num = ((int)num2 * -1720957885) ^ -631156855;
					continue;
				case 13u:
					LuaDLL.lua_pushvalue(L, stackPos);
					num = (int)(num2 * 796837126) ^ -2122785436;
					continue;
				case 4u:
					return null;
				case 9u:
					LuaDLL.lua_pop(L, 1);
					num = (int)(num2 * 1616641705) ^ -1158247941;
					continue;
				case 6u:
					num = ((int)num2 * -1081812363) ^ 0x1F01C495;
					continue;
				case 2u:
					return list.ToArray();
				case 19u:
				{
					luaTypes = LuaDLL.lua_type(L, -1);
					int num8;
					int num9;
					if (luaTypes != LuaTypes.LUA_TNIL)
					{
						num8 = -1794904894;
						num9 = num8;
					}
					else
					{
						num8 = -1633892722;
						num9 = num8;
					}
					num = num8 ^ (int)(num2 * 2022863429);
					continue;
				}
				case 5u:
				{
					int num7;
					if (luaTypes == LuaTypes.LUA_TUSERDATA)
					{
						num = -78906062;
						num7 = num;
					}
					else
					{
						num = -1627620309;
						num7 = num;
					}
					continue;
				}
				case 12u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -706178587;
						num6 = num5;
					}
					else
					{
						num5 = -586554034;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1793834218);
					continue;
				}
				case 11u:
				{
					int num4;
					if (luaTypes == LuaTypes.LUA_TNIL)
					{
						num = -904327074;
						num4 = num;
					}
					else
					{
						num = -1220971322;
						num4 = num;
					}
					continue;
				}
				case 17u:
					num3 = 1;
					num = (int)((num2 * 1200868922) ^ 0x64C455D1);
					continue;
				case 7u:
					item = GetLuaString(L, -1);
					num = -519956830;
					continue;
				case 1u:
					list = new List<string>();
					num = ((int)num2 * -2052938346) ^ 0x7A48DA6F;
					continue;
				case 18u:
					return netObject;
				default:
					return null;
				}
				break;
			}
		}
	}

	public static T[] GetArrayNumber<T>(IntPtr L, int stackPos)
	{
		LuaTypes luaTypes = LuaDLL.lua_type(L, stackPos);
		int num3 = default(int);
		List<T> list = default(List<T>);
		T item = default(T);
		T[] netObject = default(T[]);
		T val = default(T);
		while (true)
		{
			int num = -260437483;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2055477658)) % 23)
				{
				case 17u:
					break;
				case 3u:
					LuaDLL.lua_pop(L, 1);
					num = (int)(num2 * 1549846532) ^ -1402639520;
					continue;
				case 9u:
				case 15u:
				case 20u:
					LuaDLL.luaL_error(L, _202E_200C_200F_202A_202C_202E_206A_200D_202E_206D_206D_206A_206E_206D_206B_202B_200E_200E_202A_206F_200F_206B_200F_202A_202E_202C_202D_202D_200E_202D_202E_200D_200F_200B_202E_200F_200F_200B_206F_200E_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1391729373u), (object)GetErrorFunc(1), (object)stackPos));
					num = -725996458;
					continue;
				case 0u:
					LuaDLL.lua_pop(L, 1);
					num3++;
					num = ((int)num2 * -787448119) ^ -430063982;
					continue;
				case 22u:
				{
					int num11;
					if (luaTypes != LuaTypes.LUA_TNIL)
					{
						num = -936611759;
						num11 = num;
					}
					else
					{
						num = -342146858;
						num11 = num;
					}
					continue;
				}
				case 18u:
					return list.ToArray();
				case 8u:
					list.Add(item);
					num = (int)((num2 * 1626864220) ^ 0x65CFCA9C);
					continue;
				case 6u:
				{
					int num7;
					if (luaTypes != LuaTypes.LUA_TUSERDATA)
					{
						num = -509756876;
						num7 = num;
					}
					else
					{
						num = -165520730;
						num7 = num;
					}
					continue;
				}
				case 13u:
					return netObject;
				case 12u:
				{
					int num9;
					int num10;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num9 = 750321725;
						num10 = num9;
					}
					else
					{
						num9 = 1405742630;
						num10 = num9;
					}
					num = num9 ^ (int)(num2 * 777509481);
					continue;
				}
				case 21u:
				{
					int num8;
					if (luaTypes != LuaTypes.LUA_TNUMBER)
					{
						num = -1188430346;
						num8 = num;
					}
					else
					{
						num = -1124470557;
						num8 = num;
					}
					continue;
				}
				case 7u:
					num = (int)((num2 * 1941093124) ^ 0x4BE03B8);
					continue;
				case 4u:
				{
					LuaDLL.lua_rawgeti(L, -1, num3);
					luaTypes = LuaDLL.lua_type(L, -1);
					int num6;
					if (luaTypes != LuaTypes.LUA_TNIL)
					{
						num = -130357010;
						num6 = num;
					}
					else
					{
						num = -1871773512;
						num6 = num;
					}
					continue;
				}
				case 19u:
					list = new List<T>();
					LuaDLL.lua_pushvalue(L, stackPos);
					num = (int)((num2 * 502013975) ^ 0x69DCF481);
					continue;
				case 16u:
				{
					netObject = GetNetObject<T[]>(L, stackPos);
					int num4;
					int num5;
					if (netObject != null)
					{
						num4 = -155873418;
						num5 = num4;
					}
					else
					{
						num4 = -87169046;
						num5 = num4;
					}
					num = num4 ^ ((int)num2 * -797357765);
					continue;
				}
				case 5u:
					item = val;
					num = (int)((num2 * 1943653631) ^ 0x26F96F92);
					continue;
				case 14u:
					val = default(T);
					num = ((int)num2 * -1895398078) ^ 0x5A7C590B;
					continue;
				case 2u:
					return null;
				case 10u:
					item = (T)_206D_200F_200C_206E_200B_202D_206B_202E_202C_202C_206D_202C_206E_200C_200E_200C_200F_206A_202B_206E_200C_200F_202A_206D_202E_200F_202E_202B_202C_200E_202B_202B_202B_202E_202E_206D_200F_206D_206C_200F_202E((object)LuaDLL.lua_tonumber(L, -1), _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(typeof(T).TypeHandle));
					num = -617097838;
					continue;
				case 11u:
					num3 = 1;
					num = (int)(num2 * 1073594220) ^ -178820066;
					continue;
				default:
					return null;
				}
				break;
			}
		}
	}

	public static bool[] GetArrayBool(IntPtr L, int stackPos)
	{
		LuaTypes luaTypes = LuaDLL.lua_type(L, stackPos);
		bool[] netObject = default(bool[]);
		int num4 = default(int);
		List<bool> list = default(List<bool>);
		while (true)
		{
			int num = -968059414;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1707106133)) % 20)
				{
				case 15u:
					break;
				case 9u:
					return null;
				case 16u:
				{
					int num8;
					int num9;
					if (netObject == null)
					{
						num8 = 354906332;
						num9 = num8;
					}
					else
					{
						num8 = 1656059236;
						num9 = num8;
					}
					num = num8 ^ (int)(num2 * 1692213482);
					continue;
				}
				case 4u:
					num4 = 1;
					list = new List<bool>();
					LuaDLL.lua_pushvalue(L, stackPos);
					num = ((int)num2 * -1134666357) ^ 0x5436CA39;
					continue;
				case 12u:
				{
					bool item = LuaDLL.lua_toboolean(L, -1);
					list.Add(item);
					LuaDLL.lua_pop(L, 1);
					num = -391668263;
					continue;
				}
				case 19u:
					num = ((int)num2 * -2068005426) ^ -1117716021;
					continue;
				case 13u:
					netObject = GetNetObject<bool[]>(L, stackPos);
					num = (int)((num2 * 84459935) ^ 0x68EE5344);
					continue;
				case 0u:
				{
					int num7;
					if (luaTypes == LuaTypes.LUA_TUSERDATA)
					{
						num = -893978642;
						num7 = num;
					}
					else
					{
						num = -713199264;
						num7 = num;
					}
					continue;
				}
				case 11u:
					return netObject;
				case 7u:
				{
					int num12;
					if (luaTypes != LuaTypes.LUA_TNIL)
					{
						num = -1705627119;
						num12 = num;
					}
					else
					{
						num = -1875231454;
						num12 = num;
					}
					continue;
				}
				case 14u:
					LuaDLL.lua_rawgeti(L, -1, num4);
					num = -1731078654;
					continue;
				case 6u:
					num4++;
					num = (int)((num2 * 222072387) ^ 0x12CC2E3F);
					continue;
				case 8u:
					LuaDLL.lua_pop(L, 1);
					return list.ToArray();
				case 17u:
				{
					luaTypes = LuaDLL.lua_type(L, -1);
					int num10;
					int num11;
					if (luaTypes == LuaTypes.LUA_TNIL)
					{
						num10 = 1161746540;
						num11 = num10;
					}
					else
					{
						num10 = 542403673;
						num11 = num10;
					}
					num = num10 ^ (int)(num2 * 1921013851);
					continue;
				}
				case 5u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 885074432;
						num6 = num5;
					}
					else
					{
						num5 = 1639646244;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 36528703);
					continue;
				}
				case 1u:
				{
					int num3;
					if (luaTypes == LuaTypes.LUA_TNUMBER)
					{
						num = -20014589;
						num3 = num;
					}
					else
					{
						num = -1208517064;
						num3 = num;
					}
					continue;
				}
				case 2u:
				case 3u:
				case 18u:
					LuaDLL.luaL_error(L, _202E_200C_200F_202A_202C_202E_206A_200D_202E_206D_206D_206A_206E_206D_206B_202B_200E_200E_202A_206F_200F_206B_200F_202A_202E_202C_202D_202D_200E_202D_202E_200D_200F_200B_202E_200F_200F_200B_206F_200E_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1391729373u), (object)GetErrorFunc(1), (object)stackPos));
					num = -1882072855;
					continue;
				default:
					return null;
				}
				break;
			}
		}
	}

	public static LuaStringBuffer GetStringBuffer(IntPtr L, int stackPos)
	{
		LuaTypes luaTypes = LuaDLL.lua_type(L, stackPos);
		int strLen = default(int);
		IntPtr intPtr = default(IntPtr);
		while (true)
		{
			int num = 1668118154;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0xEDF6800)) % 9)
				{
				case 5u:
					break;
				case 8u:
					strLen = 0;
					num = 1298250836;
					continue;
				case 7u:
					intPtr = LuaDLL.lua_tolstring(L, stackPos, out strLen);
					num = (int)((num2 * 576095800) ^ 0x6A1C199);
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (luaTypes != LuaTypes.LUA_TNIL)
					{
						num4 = -88261208;
						num5 = num4;
					}
					else
					{
						num4 = -2084620052;
						num5 = num4;
					}
					num = num4 ^ (int)(num2 * 934310176);
					continue;
				}
				case 1u:
				{
					int num3;
					if (luaTypes == LuaTypes.LUA_TSTRING)
					{
						num = 669123169;
						num3 = num;
					}
					else
					{
						num = 737800865;
						num3 = num;
					}
					continue;
				}
				case 0u:
					LuaDLL.luaL_typerror(L, stackPos, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(212034898u));
					num = ((int)num2 * -929643356) ^ -2145250733;
					continue;
				case 6u:
					return null;
				case 3u:
					return null;
				default:
					return new LuaStringBuffer(intPtr, strLen);
				}
				break;
			}
		}
	}

	public static void SetValueObject(IntPtr L, int pos, object obj)
	{
		GetTranslator(L).SetValueObject(L, pos, obj);
	}

	public static void CheckArgsCount(IntPtr L, int count)
	{
		int num = LuaDLL.lua_gettop(L);
		while (true)
		{
			int num2 = 21379927;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x22B38FB9)) % 4)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
				{
					int num4;
					int num5;
					if (num != count)
					{
						num4 = -1570804848;
						num5 = num4;
					}
					else
					{
						num4 = -248407006;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 1630540346);
					continue;
				}
				case 1u:
				{
					string message = _202E_200C_200F_202A_202C_202E_206A_200D_202E_206D_206D_206A_206E_206D_206B_202B_200E_200E_202A_206F_200F_206B_200F_202A_202E_202C_202D_202D_200E_202D_202E_200D_200F_200B_202E_200F_200F_200B_206F_200E_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(582032788u), (object)GetErrorFunc(1), (object)num);
					LuaDLL.luaL_error(L, message);
					num2 = ((int)num3 * -1255358664) ^ -870556714;
					continue;
				}
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public static object GetVarTable(IntPtr L, int stackPos)
	{
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		object result = null;
		int num7 = default(int);
		string text = default(string);
		while (true)
		{
			int num = 517710526;
			while (true)
			{
				uint num2;
				int num10;
				switch ((num2 = (uint)(num ^ 0x7994EB06)) % 34)
				{
				case 21u:
					break;
				case 14u:
					num7 = LuaDLL.lua_gettop(L);
					num = (int)((num2 * 804049644) ^ 0x62267668);
					continue;
				case 28u:
					num = (int)(num2 * 955279640) ^ -127712859;
					continue;
				case 15u:
					num = (int)(num2 * 734604560) ^ -391627771;
					continue;
				case 10u:
					LuaDLL.lua_pushvalue(L, stackPos);
					num = (int)((num2 * 1176295865) ^ 0x38A25B9B);
					continue;
				case 13u:
					LuaDLL.lua_pushstring(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(846611002u));
					num = (int)(num2 * 1385916861) ^ -1307843388;
					continue;
				case 22u:
					num = ((int)num2 * -551509956) ^ -1699536363;
					continue;
				case 4u:
					result = new LuaTable(LuaDLL.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX), GetTranslator(L).interpreter);
					num = ((int)num2 * -791653904) ^ 0x3E3A4F34;
					continue;
				case 7u:
					LuaDLL.lua_settop(L, num7);
					num = ((int)num2 * -1922919671) ^ 0x43BEB4A0;
					continue;
				case 18u:
					LuaDLL.lua_pushvalue(L, stackPos);
					num = ((int)num2 * -1681083562) ^ 0x5FEB6BCC;
					continue;
				case 3u:
					if (stackPos > 0)
					{
						num = ((int)num2 * -420825982) ^ -964989075;
						continue;
					}
					num10 = stackPos + num7 + 1;
					goto IL_01ac;
				case 29u:
					num10 = stackPos;
					goto IL_01ac;
				case 23u:
					LuaDLL.lua_pushvalue(L, stackPos);
					num = 1507212193;
					continue;
				case 31u:
					result = new LuaTable(LuaDLL.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX), GetTranslator(L).interpreter);
					num = (int)((num2 * 1366664821) ^ 0xD07C046);
					continue;
				case 20u:
				{
					int num4;
					int num5;
					if (_202B_206F_202D_200D_206F_206C_200C_200C_202C_206C_206C_206C_206A_202A_200C_206A_202E_206B_206C_200F_206C_200F_206B_206B_206D_200D_200F_200E_202C_206F_206B_202D_200F_206A_206B_206B_206A_206B_200D_202E_202E(text, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3392041967u)))
					{
						num4 = 420343414;
						num5 = num4;
					}
					else
					{
						num4 = 253004107;
						num5 = num4;
					}
					num = num4 ^ (int)(num2 * 439658296);
					continue;
				}
				case 33u:
					result = GetQuaternion(L, stackPos);
					num = (int)(num2 * 772264452) ^ -1899556136;
					continue;
				case 26u:
					num = (int)((num2 * 298045582) ^ 0x22D91B99);
					continue;
				case 0u:
				{
					int num14;
					if (!_202B_206F_202D_200D_206F_206C_200C_200C_202C_206C_206C_206C_206A_202A_200C_206A_202E_206B_206C_200F_206C_200F_206B_206B_206D_200D_200F_200E_202C_206F_206B_202D_200F_206A_206B_206B_206A_206B_200D_202E_202E(text, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1853798413u)))
					{
						num = 47368752;
						num14 = num;
					}
					else
					{
						num = 1611442476;
						num14 = num;
					}
					continue;
				}
				case 25u:
					result = GetBounds(L, stackPos);
					num = (int)(num2 * 1377350068) ^ -1798049126;
					continue;
				case 2u:
					result = GetVector2(L, stackPos);
					num = ((int)num2 * -1865810934) ^ -1987902515;
					continue;
				case 24u:
				{
					int num13;
					if (_202B_206F_202D_200D_206F_206C_200C_200C_202C_206C_206C_206C_206A_202A_200C_206A_202E_206B_206C_200F_206C_200F_206B_206B_206D_200D_200F_200E_202C_206F_206B_202D_200F_206A_206B_206B_206A_206B_200D_202E_202E(text, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3781916899u)))
					{
						num = 567485104;
						num13 = num;
					}
					else
					{
						num = 119658518;
						num13 = num;
					}
					continue;
				}
				case 11u:
				{
					LuaDLL.lua_gettable(L, -2);
					int num11;
					int num12;
					if (!LuaDLL.lua_isnil(L, -1))
					{
						num11 = -1185339024;
						num12 = num11;
					}
					else
					{
						num11 = -568117890;
						num12 = num11;
					}
					num = num11 ^ ((int)num2 * -1933438558);
					continue;
				}
				case 9u:
				{
					int num9;
					if (!_202B_206F_202D_200D_206F_206C_200C_200C_202C_206C_206C_206C_206A_202A_200C_206A_202E_206B_206C_200F_206C_200F_206B_206B_206D_200D_200F_200E_202C_206F_206B_202D_200F_206A_206B_206B_206A_206B_200D_202E_202E(text, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1125313722u)))
					{
						num = 145201251;
						num9 = num;
					}
					else
					{
						num = 886819557;
						num9 = num;
					}
					continue;
				}
				case 19u:
				{
					int num8;
					if (!_202B_206F_202D_200D_206F_206C_200C_200C_202C_206C_206C_206C_206A_202A_200C_206A_202E_206B_206C_200F_206C_200F_206B_206B_206D_200D_200F_200E_202C_206F_206B_202D_200F_206A_206B_206B_206A_206B_200D_202E_202E(text, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4163976134u)))
					{
						num = 1042805319;
						num8 = num;
					}
					else
					{
						num = 1033537018;
						num8 = num;
					}
					continue;
				}
				case 1u:
					result = GetRay(L, stackPos);
					num = (int)(num2 * 1463337622) ^ -1214610565;
					continue;
				case 16u:
					LuaDLL.lua_settop(L, num7);
					num = ((int)num2 * -54665321) ^ 0x440BDFDA;
					continue;
				case 30u:
					result = GetVector4(L, stackPos);
					num = (int)((num2 * 1215750572) ^ 0x15BB85E5);
					continue;
				case 27u:
					num = (int)((num2 * 1838332757) ^ 0x5D2957A2);
					continue;
				case 17u:
				{
					int num6;
					if (_202B_206F_202D_200D_206F_206C_200C_200C_202C_206C_206C_206C_206A_202A_200C_206A_202E_206B_206C_200F_206C_200F_206B_206B_206D_200D_200F_200E_202C_206F_206B_202D_200F_206A_206B_206B_206A_206B_200D_202E_202E(text, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3872012074u)))
					{
						num = 1987383283;
						num6 = num;
					}
					else
					{
						num = 511703820;
						num6 = num;
					}
					continue;
				}
				case 32u:
					result = GetColor(L, stackPos);
					num = (int)((num2 * 1364977179) ^ 0x5052AC27);
					continue;
				case 6u:
					result = GetVector3(L, stackPos);
					num = (int)((num2 * 632856991) ^ 0x2F744A27);
					continue;
				case 12u:
					text = LuaDLL.lua_tostring(L, -1);
					num = 1596751765;
					continue;
				case 8u:
				{
					int num3;
					if (!_202B_206F_202D_200D_206F_206C_200C_200C_202C_206C_206C_206C_206A_202A_200C_206A_202E_206B_206C_200F_206C_200F_206B_206B_206D_200D_200F_200E_202C_206F_206B_202D_200F_206A_206B_206B_206A_206B_200D_202E_202E(text, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3025201365u)))
					{
						num = 1423153491;
						num3 = num;
					}
					else
					{
						num = 671569859;
						num3 = num;
					}
					continue;
				}
				default:
					{
						return result;
					}
					IL_01ac:
					stackPos = num10;
					num = 628250770;
					continue;
				}
				break;
			}
		}
	}

	public static object GetVarObject(IntPtr L, int stackPos)
	{
		LuaTypes luaTypes = LuaDLL.lua_type(L, stackPos);
		LuaTypes luaTypes2 = default(LuaTypes);
		object value = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = -462221080;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -952494124)) % 17)
				{
				case 3u:
					break;
				case 8u:
					return GetVarTable(L, stackPos);
				case 0u:
					switch (luaTypes2)
					{
					case LuaTypes.LUA_TTABLE:
						break;
					default:
						goto IL_009a;
					case LuaTypes.LUA_TFUNCTION:
						goto IL_00c2;
					case LuaTypes.LUA_TNUMBER:
						goto IL_011c;
					case LuaTypes.LUA_TSTRING:
						goto IL_0133;
					case LuaTypes.LUA_TBOOLEAN:
						goto IL_01bc;
					case LuaTypes.LUA_TUSERDATA:
						goto IL_01d3;
					case LuaTypes.LUA_TLIGHTUSERDATA:
						goto IL_01e5;
					}
					goto case 8u;
				case 15u:
					return value;
				case 11u:
					goto IL_00c2;
				case 7u:
				{
					int num4;
					int num5;
					if (num3 == -1)
					{
						num4 = -926539158;
						num5 = num4;
					}
					else
					{
						num4 = -1613460213;
						num5 = num4;
					}
					num = num4 ^ (int)(num2 * 1341617208);
					continue;
				}
				case 10u:
					num = (int)(num2 * 1693650242) ^ -1063615319;
					continue;
				case 9u:
					value = null;
					num = ((int)num2 * -1087230456) ^ 0x55D567EF;
					continue;
				case 14u:
					goto IL_011c;
				case 16u:
					goto IL_0133;
				case 2u:
					return null;
				case 13u:
					return new LuaFunction(LuaDLL.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX), GetTranslator(L).interpreter);
				case 5u:
					luaTypes2 = luaTypes;
					num = ((int)num2 * -573465285) ^ 0x7C0F7F15;
					continue;
				case 12u:
					GetTranslator(L).objects.TryGetValue(num3, out value);
					num = ((int)num2 * -473897526) ^ 0x7CDF2522;
					continue;
				case 4u:
					goto IL_01bc;
				case 6u:
					goto IL_01d3;
				default:
					goto IL_01e5;
					IL_009a:
					num = (int)(num2 * 1113815422) ^ -478349531;
					continue;
					IL_00c2:
					LuaDLL.lua_pushvalue(L, stackPos);
					num = -1264894385;
					continue;
					IL_01e5:
					return null;
					IL_01d3:
					num3 = LuaDLL.luanet_rawnetobj(L, stackPos);
					num = -1108842448;
					continue;
					IL_01bc:
					return LuaDLL.lua_toboolean(L, stackPos);
					IL_0133:
					return LuaDLL.lua_tostring(L, stackPos);
					IL_011c:
					return LuaDLL.lua_tonumber(L, stackPos);
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IndexArray(IntPtr L)
	{
		Array array = GetLuaObject(L, 1) as Array;
		if (array == null)
		{
			goto IL_0013;
		}
		goto IL_01ab;
		IL_0013:
		int num = -2123175974;
		goto IL_0018;
		IL_0018:
		object obj = default(object);
		int num3 = default(int);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -372115303)) % 16)
			{
			case 9u:
				break;
			case 14u:
				goto IL_006e;
			case 8u:
				LuaDLL.lua_pushnil(L);
				num = (int)((num2 * 2144377000) ^ 0x11D3D66D);
				continue;
			case 1u:
			{
				string luaString = GetLuaString(L, 2);
				int num8;
				int num9;
				if (_202B_206F_202D_200D_206F_206C_200C_200C_202C_206C_206C_206C_206A_202A_200C_206A_202E_206B_206C_200F_206C_200F_206B_206B_206D_200D_200F_200E_202C_206F_206B_202D_200F_206A_206B_206B_206A_206B_200D_202E_202E(luaString, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3425747557u)))
				{
					num8 = -1718909442;
					num9 = num8;
				}
				else
				{
					num8 = -383962297;
					num9 = num8;
				}
				num = num8 ^ ((int)num2 * -120385477);
				continue;
			}
			case 11u:
				PushVarObject(L, obj);
				num = -806478324;
				continue;
			case 6u:
				goto IL_00ed;
			case 7u:
				LuaDLL.luaL_error(L, _206E_206F_206B_206B_202D_200B_202E_202D_200E_202E_200B_206E_202B_202C_202A_202E_202D_202D_206E_202B_200F_200C_200D_202C_206E_202E_200B_206E_202D_206D_202D_200B_206A_202E_206F_202B_206E_200B_200D_202B_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1699268711u), (object)num3));
				return 0;
			case 0u:
				LuaDLL.luaL_error(L, _206D_206C_206A_206A_206A_200F_200C_206E_206D_206E_206E_200F_206C_200F_200C_202A_206A_206E_202E_206E_202A_206C_206D_206E_206A_206C_206E_200C_202B_202D_200E_206B_200C_200D_202E_206D_202A_206E_200D_200C_202E(new object[4]
				{
					global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1731937127u),
					num3,
					global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2285033199u),
					_200C_206E_200E_200E_200C_206E_206B_206B_206C_202A_206A_200F_200E_206F_200E_206A_202B_206E_202B_200D_206D_206E_206C_206D_202C_200B_206C_202D_202E_202C_200C_206B_206A_206A_206F_206F_206E_206C_200B_206F_202E(array)
				}));
				num = (int)(num2 * 1544791925) ^ -116600908;
				continue;
			case 15u:
			{
				int num6;
				int num7;
				if (luaTypes == LuaTypes.LUA_TNUMBER)
				{
					num6 = 1409276371;
					num7 = num6;
				}
				else
				{
					num6 = 194956943;
					num7 = num6;
				}
				num = num6 ^ ((int)num2 * -1279772112);
				continue;
			}
			case 2u:
				goto IL_01ab;
			case 3u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4274719790u));
				num = (int)((num2 * 1582112419) ^ 0x7851EE88);
				continue;
			case 4u:
				return 1;
			case 12u:
				Push(L, _200C_206E_200E_200E_200C_206E_206B_206B_206C_202A_206A_200F_200E_206F_200E_206A_202B_206E_202B_200D_206D_206E_206C_206D_202C_200B_206C_202D_202E_202C_200C_206B_206A_206A_206F_206F_206E_206C_200B_206F_202E(array));
				num = (int)((num2 * 1870949275) ^ 0x685BF0A8);
				continue;
			case 10u:
			{
				num3 = (int)LuaDLL.lua_tonumber(L, 2);
				int num4;
				int num5;
				if (num3 < _200C_206E_200E_200E_200C_206E_206B_206B_206C_202A_206A_200F_200E_206F_200E_206A_202B_206E_202B_200D_206D_206E_206C_206D_202C_200B_206C_202D_202E_202C_200C_206B_206A_206A_206F_206F_206E_206C_200B_206F_202E(array))
				{
					num4 = -848527575;
					num5 = num4;
				}
				else
				{
					num4 = -961795465;
					num5 = num4;
				}
				num = num4 ^ (int)(num2 * 2055384435);
				continue;
			}
			case 13u:
				return 0;
			default:
				return 1;
			}
			break;
			IL_00ed:
			int num10;
			if (luaTypes == LuaTypes.LUA_TSTRING)
			{
				num = -1221988696;
				num10 = num;
			}
			else
			{
				num = -806478324;
				num10 = num;
			}
			continue;
			IL_006e:
			obj = _202C_200F_202B_202A_206A_200E_200B_202A_202A_202D_202D_200F_202D_206B_200F_206A_206D_202C_200C_202A_206C_202D_202E_200F_202E_200E_206D_206B_206E_206E_200E_202D_200D_206C_202E_200C_206B_202B_206E_200F_202E(array, num3);
			int num11;
			if (obj == null)
			{
				num = -1325032722;
				num11 = num;
			}
			else
			{
				num = -528560782;
				num11 = num;
			}
		}
		goto IL_0013;
		IL_01ab:
		luaTypes = LuaDLL.lua_type(L, 2);
		num = -1725359674;
		goto IL_0018;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int NewIndexArray(IntPtr L)
	{
		Array array = GetLuaObject(L, 1) as Array;
		if (array == null)
		{
			goto IL_0010;
		}
		goto IL_005e;
		IL_0010:
		int num = 1608258493;
		goto IL_0015;
		IL_0015:
		object obj = default(object);
		Type type = default(Type);
		int num3 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x741703A4)) % 9)
			{
			case 7u:
				break;
			case 0u:
				obj = _206D_200F_200C_206E_200B_202D_206B_202E_202C_202C_206D_202C_206E_200C_200E_200C_200F_206A_202B_206E_200C_200F_202A_206D_202E_200F_202E_202B_202C_200E_202B_202B_202B_202E_202E_206D_200F_206D_206C_200F_202E(obj, type);
				num = 204963526;
				continue;
			case 4u:
				goto IL_005e;
			case 3u:
				obj = GetVarObject(L, 3);
				num = (int)(num2 * 939765454) ^ -467476537;
				continue;
			case 5u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2187513028u));
				return 0;
			case 2u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2507021065u));
				num = ((int)num2 * -7905743) ^ 0x46704DC8;
				continue;
			case 8u:
			{
				type = _206B_200F_206F_202C_200F_202E_206D_202D_200B_200F_202B_200D_202B_200C_206B_202E_200C_206C_206B_206C_206E_202A_206A_202A_200D_202E_206B_200C_200B_206F_206C_206E_206A_200D_200B_202D_206C_202A_206A_206D_202E(_202D_206E_202A_200B_206D_202E_202B_206E_206F_202C_202B_206E_206F_206D_202E_200C_206A_206A_202B_202A_200F_200E_200C_200E_206A_206E_200E_200E_200C_202A_206B_200E_202E_206E_200E_202E_202C_200E_202C_202E((object)array));
				int num4;
				int num5;
				if (!CheckType(L, type, 3))
				{
					num4 = 297465997;
					num5 = num4;
				}
				else
				{
					num4 = 1817795854;
					num5 = num4;
				}
				num = num4 ^ (int)(num2 * 1197529955);
				continue;
			}
			case 1u:
				return 0;
			default:
				_202A_206D_206E_202D_200D_200B_200D_206E_200E_206E_200B_202E_206E_200D_200F_200C_200B_202D_206C_206C_200B_202B_206B_206F_202A_206C_206E_202A_206B_206A_202A_206D_206F_202C_202E_200C_200F_202B_202C_200F_202E(array, obj, num3);
				return 0;
			}
			break;
		}
		goto IL_0010;
		IL_005e:
		num3 = (int)GetNumber(L, 2);
		num = 1242437402;
		goto IL_0015;
	}

	public static void DumpStack(IntPtr L)
	{
		int num = LuaDLL.lua_gettop(L);
		int num2 = 1;
		double num6 = default(double);
		LuaTypes luaTypes2 = default(LuaTypes);
		LuaTypes luaTypes = default(LuaTypes);
		bool flag = default(bool);
		while (true)
		{
			int num3;
			int num4;
			if (num2 > num)
			{
				num3 = 1025117728;
				num4 = num3;
			}
			else
			{
				num3 = 285391999;
				num4 = num3;
			}
			while (true)
			{
				uint num5;
				switch ((num5 = (uint)(num3 ^ 0x4B51E5BF)) % 18)
				{
				case 16u:
					num3 = 285391999;
					continue;
				default:
					return;
				case 7u:
					num3 = (int)(num5 * 776431534) ^ -718000566;
					continue;
				case 1u:
					num3 = ((int)num5 * -1386640786) ^ -2115054989;
					continue;
				case 6u:
					Debugger.Log(num6.ToString());
					num3 = (int)((num5 * 853600321) ^ 0x17B8968D);
					continue;
				case 17u:
					break;
				case 10u:
					switch (luaTypes2)
					{
					case LuaTypes.LUA_TNUMBER:
						goto IL_012f;
					case LuaTypes.LUA_TSTRING:
						goto IL_0167;
					case LuaTypes.LUA_TLIGHTUSERDATA:
						goto IL_0183;
					case LuaTypes.LUA_TBOOLEAN:
						goto IL_01db;
					}
					num3 = (int)((num5 * 1954423851) ^ 0x62C8B98A);
					continue;
				case 13u:
					num2++;
					num3 = 1229919788;
					continue;
				case 12u:
					num3 = (int)((num5 * 991114525) ^ 0x51584CB6);
					continue;
				case 9u:
					luaTypes2 = luaTypes;
					num3 = (int)(num5 * 1850597378) ^ -1755202107;
					continue;
				case 8u:
					goto IL_012f;
				case 4u:
					luaTypes = LuaDLL.lua_type(L, num2);
					num3 = 609134780;
					continue;
				case 14u:
					num3 = ((int)num5 * -331957480) ^ 0x4F14C358;
					continue;
				case 15u:
					goto IL_0167;
				case 2u:
					goto IL_0183;
				case 3u:
					Debugger.Log(flag.ToString());
					num3 = (int)(num5 * 1809859745) ^ -868546475;
					continue;
				case 0u:
					num3 = ((int)num5 * -1290557357) ^ 0x73B9FA2A;
					continue;
				case 11u:
					goto IL_01db;
				case 5u:
					return;
					IL_01db:
					flag = LuaDLL.lua_toboolean(L, num2);
					num3 = 1221598730;
					continue;
					IL_0183:
					Debugger.Log(luaTypes.ToString());
					num3 = 1658034425;
					continue;
					IL_0167:
					Debugger.Log(LuaDLL.lua_tostring(L, num2));
					num3 = 1341131575;
					continue;
					IL_012f:
					num6 = LuaDLL.lua_tonumber(L, num2);
					num3 = 377654539;
					continue;
				}
				break;
			}
		}
	}

	private static object GetEnumObj(Enum e)
	{
		object value = null;
		while (true)
		{
			int num = -1268059946;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1751199159)) % 5)
				{
				case 4u:
					break;
				case 2u:
				{
					int num3;
					int num4;
					if (!enumMap.TryGetValue(e, out value))
					{
						num3 = 1620971717;
						num4 = num3;
					}
					else
					{
						num3 = 1496706068;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -930581209);
					continue;
				}
				case 3u:
					value = e;
					num = (int)((num2 * 1165676085) ^ 0x37B058A6);
					continue;
				case 1u:
					enumMap.Add(e, value);
					num = (int)(num2 * 730500901) ^ -291704189;
					continue;
				default:
					return value;
				}
				break;
			}
		}
	}

	public static void Push(IntPtr L, Enum e)
	{
		LuaScriptMgr mgrFromLuaState = GetMgrFromLuaState(L);
		ObjectTranslator translator = mgrFromLuaState.lua.translator;
		int weakTableRef = translator.weakTableRef;
		object enumObj = default(object);
		int value = default(int);
		while (true)
		{
			int num = 929456846;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x21B205C3)) % 9)
				{
				case 3u:
					break;
				default:
					return;
				case 6u:
				{
					int num5;
					int num6;
					if (!translator.objectsBackMap.TryGetValue(enumObj, out value))
					{
						num5 = -123958114;
						num6 = num5;
					}
					else
					{
						num5 = -1285024586;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 2054136028);
					continue;
				}
				case 1u:
					value = translator.addObject(enumObj, isValueType: false);
					LuaDLL.tolua_pushnewudata(L, mgrFromLuaState.enumMetaRef, weakTableRef, value);
					num = 1490218379;
					continue;
				case 0u:
					translator.collectObject(value);
					num = 1509572330;
					continue;
				case 5u:
					enumObj = GetEnumObj(e);
					num = ((int)num2 * -512706130) ^ -355575496;
					continue;
				case 8u:
					return;
				case 4u:
				{
					int num3;
					int num4;
					if (LuaDLL.tolua_pushudata(L, weakTableRef, value))
					{
						num3 = 906291239;
						num4 = num3;
					}
					else
					{
						num3 = 617046640;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -465283740);
					continue;
				}
				case 7u:
					value = -1;
					num = (int)((num2 * 1052738071) ^ 0x7A3D4903);
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public static void Push(IntPtr L, LuaStringBuffer lsb)
	{
		if (lsb != null)
		{
			goto IL_0003;
		}
		goto IL_002d;
		IL_0003:
		int num = 1436218535;
		goto IL_0008;
		IL_0008:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x72A83916)) % 5)
			{
			case 3u:
				break;
			default:
				return;
			case 2u:
				goto IL_002d;
			case 4u:
				LuaDLL.lua_pushlstring(L, lsb.buffer, lsb.buffer.Length);
				num = (int)((num2 * 1001813105) ^ 0x3301E489);
				continue;
			case 1u:
			{
				int num3;
				int num4;
				if (lsb.buffer != null)
				{
					num3 = -1691683635;
					num4 = num3;
				}
				else
				{
					num3 = -1978820678;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -113840086);
				continue;
			}
			case 0u:
				return;
			}
			break;
		}
		goto IL_0003;
		IL_002d:
		LuaDLL.lua_pushnil(L);
		num = 1960490696;
		goto IL_0008;
	}

	public static LuaScriptMgr GetMgrFromLuaState(IntPtr L)
	{
		return Instance;
	}

	public static void ThrowLuaException(IntPtr L)
	{
		string text = LuaDLL.lua_tostring(L, -1);
		while (true)
		{
			int num = -71016247;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -860445854)) % 4)
				{
				case 2u:
					break;
				case 3u:
				{
					int num3;
					int num4;
					if (text != null)
					{
						num3 = 450089216;
						num4 = num3;
					}
					else
					{
						num3 = 1929700141;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1209114817);
					continue;
				}
				case 0u:
					text = global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3460635624u);
					num = ((int)num2 * -913739399) ^ -736522641;
					continue;
				default:
					throw new LuaScriptException(_200D_202D_206A_206A_200B_206D_200B_200D_200B_200D_200B_202D_206F_202C_206D_206C_206B_206D_200D_202A_202C_206C_202A_206B_206C_202E_206D_200D_200C_202E_200D_200C_202C_200D_200F_200F_206F_202D_202E_206A_202E(text), string.Empty);
				}
				break;
			}
		}
	}

	public static Vector3 GetVector3(IntPtr L, int stackPos)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr mgrFromLuaState = GetMgrFromLuaState(L);
		float x = 0f;
		float y = default(float);
		float z = default(float);
		while (true)
		{
			int num = 875826276;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6DF2A5AE)) % 4)
				{
				case 0u:
					break;
				case 2u:
					y = 0f;
					num = (int)(num2 * 1157293028) ^ -314764367;
					continue;
				case 3u:
					z = 0f;
					num = ((int)num2 * -717840747) ^ 0x61E367D0;
					continue;
				default:
					LuaDLL.tolua_getfloat3(L, mgrFromLuaState.unpackVec3, stackPos, ref x, ref y, ref z);
					return new Vector3(x, y, z);
				}
				break;
			}
		}
	}

	public static void Push(IntPtr L, Vector3 v3)
	{
		LuaScriptMgr mgrFromLuaState = GetMgrFromLuaState(L);
		while (true)
		{
			int num = 756443001;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x76162CCD)) % 3)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_0029;
				case 0u:
					return;
				}
				break;
				IL_0029:
				LuaDLL.tolua_pushfloat3(L, mgrFromLuaState.packVec3, v3.x, v3.y, v3.z);
				num = ((int)num2 * -1336171432) ^ 0x1862A2B3;
			}
		}
	}

	public static void Push(IntPtr L, Quaternion q)
	{
		LuaScriptMgr mgrFromLuaState = GetMgrFromLuaState(L);
		LuaDLL.tolua_pushfloat4(L, mgrFromLuaState.packQuat, q.x, q.y, q.z, q.w);
	}

	public static Quaternion GetQuaternion(IntPtr L, int stackPos)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr mgrFromLuaState = GetMgrFromLuaState(L);
		float x = 0f;
		float y = 0f;
		float z = 0f;
		float w = 1f;
		LuaDLL.tolua_getfloat4(L, mgrFromLuaState.unpackQuat, stackPos, ref x, ref y, ref z, ref w);
		return new Quaternion(x, y, z, w);
	}

	public static Vector2 GetVector2(IntPtr L, int stackPos)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr mgrFromLuaState = GetMgrFromLuaState(L);
		float x = default(float);
		float y = default(float);
		while (true)
		{
			int num = 47249915;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1C3A8754)) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_0029;
				default:
					return new Vector2(x, y);
				}
				break;
				IL_0029:
				x = 0f;
				y = 0f;
				LuaDLL.tolua_getfloat2(L, mgrFromLuaState.unpackVec2, stackPos, ref x, ref y);
				num = ((int)num2 * -1877420801) ^ 0x3CA0117F;
			}
		}
	}

	public static void Push(IntPtr L, Vector2 v2)
	{
		LuaScriptMgr mgrFromLuaState = GetMgrFromLuaState(L);
		LuaDLL.tolua_pushfloat2(L, mgrFromLuaState.packVec2, v2.x, v2.y);
	}

	public static Vector4 GetVector4(IntPtr L, int stackPos)
	{
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr mgrFromLuaState = GetMgrFromLuaState(L);
		float x = default(float);
		float y = default(float);
		float z = default(float);
		float w = default(float);
		while (true)
		{
			int num = -803483267;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2121079046)) % 6)
				{
				case 5u:
					break;
				case 0u:
					LuaDLL.tolua_getfloat4(L, mgrFromLuaState.unpackVec4, stackPos, ref x, ref y, ref z, ref w);
					num = ((int)num2 * -2083409551) ^ -567509220;
					continue;
				case 2u:
					y = 0f;
					num = (int)(num2 * 1623206700) ^ -759043503;
					continue;
				case 1u:
					z = 0f;
					w = 0f;
					num = ((int)num2 * -250178351) ^ -1501287581;
					continue;
				case 3u:
					x = 0f;
					num = ((int)num2 * -1987043219) ^ -1646790795;
					continue;
				default:
					return new Vector4(x, y, z, w);
				}
				break;
			}
		}
	}

	public static void Push(IntPtr L, Vector4 v4)
	{
		LuaScriptMgr mgrFromLuaState = GetMgrFromLuaState(L);
		LuaDLL.tolua_pushfloat4(L, mgrFromLuaState.packVec4, v4.x, v4.y, v4.z, v4.w);
	}

	public static void Push(IntPtr L, RaycastHit hit)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr mgrFromLuaState = GetMgrFromLuaState(L);
		while (true)
		{
			int num = 490804892;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x484390D7)) % 5)
				{
				case 0u:
					break;
				case 1u:
					mgrFromLuaState.packRaycastHit.push(L);
					Push(L, (Object)(object)((RaycastHit)(ref hit)).collider);
					num = (int)(num2 * 648399339) ^ -1128703950;
					continue;
				case 2u:
					Push(L, ((RaycastHit)(ref hit)).distance);
					num = (int)((num2 * 441100796) ^ 0x13698735);
					continue;
				case 3u:
					Push(L, ((RaycastHit)(ref hit)).normal);
					Push(L, ((RaycastHit)(ref hit)).point);
					Push(L, (Object)(object)((RaycastHit)(ref hit)).rigidbody);
					num = (int)(num2 * 1795308057) ^ -1194994387;
					continue;
				default:
					Push(L, (Object)(object)((RaycastHit)(ref hit)).transform);
					LuaDLL.lua_call(L, 6, -1);
					return;
				}
				break;
			}
		}
	}

	public static void Push(IntPtr L, Ray ray)
	{
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr mgrFromLuaState = GetMgrFromLuaState(L);
		LuaDLL.lua_getref(L, mgrFromLuaState.packRay);
		while (true)
		{
			int num = 584602222;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x667215B0)) % 4)
				{
				case 0u:
					break;
				case 2u:
					LuaDLL.tolua_pushfloat3(L, mgrFromLuaState.packVec3, ((Ray)(ref ray)).direction.x, ((Ray)(ref ray)).direction.y, ((Ray)(ref ray)).direction.z);
					num = ((int)num2 * -580583883) ^ -990445553;
					continue;
				case 1u:
					LuaDLL.tolua_pushfloat3(L, mgrFromLuaState.packVec3, ((Ray)(ref ray)).origin.x, ((Ray)(ref ray)).origin.y, ((Ray)(ref ray)).origin.z);
					num = ((int)num2 * -1520143768) ^ 0x673CE87F;
					continue;
				default:
					LuaDLL.lua_call(L, 2, -1);
					return;
				}
				break;
			}
		}
	}

	public static Ray GetRay(IntPtr L, int stackPos)
	{
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr mgrFromLuaState = GetMgrFromLuaState(L);
		float x = 0f;
		Vector3 val = default(Vector3);
		float y = default(float);
		float z = default(float);
		float x2 = default(float);
		float y2 = default(float);
		float z2 = default(float);
		Vector3 val2 = default(Vector3);
		while (true)
		{
			int num = -1793348038;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1744651673)) % 9)
				{
				case 7u:
					break;
				case 2u:
					((Vector3)(ref val))._002Ector(x, y, z);
					num = (int)((num2 * 2127553920) ^ 0x47D1042B);
					continue;
				case 5u:
					x2 = 0f;
					num = (int)(num2 * 2002031419) ^ -1319672699;
					continue;
				case 8u:
					LuaDLL.tolua_getfloat6(L, mgrFromLuaState.unpackRay, stackPos, ref x, ref y, ref z, ref x2, ref y2, ref z2);
					num = ((int)num2 * -1366473667) ^ 0x37C9CE60;
					continue;
				case 0u:
					((Vector3)(ref val2))._002Ector(x2, y2, z2);
					num = (int)(num2 * 1264672274) ^ -1612644484;
					continue;
				case 3u:
					z2 = 0f;
					num = ((int)num2 * -1994034883) ^ 0x6517BE4D;
					continue;
				case 6u:
					y2 = 0f;
					num = ((int)num2 * -1025343404) ^ 0x39EA799D;
					continue;
				case 1u:
					y = 0f;
					z = 0f;
					num = (int)((num2 * 1526715309) ^ 0x40FC1143);
					continue;
				default:
					return new Ray(val, val2);
				}
				break;
			}
		}
	}

	public static Bounds GetBounds(IntPtr L, int stackPos)
	{
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr mgrFromLuaState = GetMgrFromLuaState(L);
		float x = 0f;
		float y = 0f;
		float z2 = default(float);
		float x2 = default(float);
		float y2 = default(float);
		float z = default(float);
		Vector3 val2 = default(Vector3);
		Vector3 val = default(Vector3);
		while (true)
		{
			int num = 1179910786;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1FD022C6)) % 5)
				{
				case 3u:
					break;
				case 1u:
					z2 = 0f;
					num = (int)((num2 * 1026311916) ^ 0x9504D55);
					continue;
				case 2u:
					x2 = 0f;
					y2 = 0f;
					z = 0f;
					num = (int)((num2 * 1500755073) ^ 0x70A7E61B);
					continue;
				case 4u:
					LuaDLL.tolua_getfloat6(L, mgrFromLuaState.unpackBounds, stackPos, ref x, ref y, ref z2, ref x2, ref y2, ref z);
					((Vector3)(ref val2))._002Ector(x, y, z2);
					num = (int)((num2 * 1721750520) ^ 0x28DE0FBF);
					continue;
				default:
					((Vector3)(ref val))._002Ector(x2, y2, z);
					return new Bounds(val2, val);
				}
				break;
			}
		}
	}

	public static Color GetColor(IntPtr L, int stackPos)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr mgrFromLuaState = GetMgrFromLuaState(L);
		float x = default(float);
		float y = default(float);
		while (true)
		{
			int num = 285066762;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x90C55B5)) % 4)
				{
				case 0u:
					break;
				case 3u:
					x = 0f;
					num = ((int)num2 * -1156901764) ^ 0x6E0F82C8;
					continue;
				case 1u:
					y = 0f;
					num = (int)((num2 * 1006644406) ^ 0xAAD824D);
					continue;
				default:
				{
					float z = 0f;
					float w = 0f;
					LuaDLL.tolua_getfloat4(L, mgrFromLuaState.unpackColor, stackPos, ref x, ref y, ref z, ref w);
					return new Color(x, y, z, w);
				}
				}
				break;
			}
		}
	}

	public static void Push(IntPtr L, Color clr)
	{
		LuaScriptMgr mgrFromLuaState = GetMgrFromLuaState(L);
		while (true)
		{
			int num = -145208450;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -108210768)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0029;
				case 1u:
					return;
				}
				break;
				IL_0029:
				LuaDLL.tolua_pushfloat4(L, mgrFromLuaState.packColor, clr.r, clr.g, clr.b, clr.a);
				num = (int)(num2 * 375630785) ^ -1180939377;
			}
		}
	}

	public static void Push(IntPtr L, Touch touch)
	{
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected I4, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr mgrFromLuaState = GetMgrFromLuaState(L);
		mgrFromLuaState.packTouch.push(L);
		while (true)
		{
			int num = 834818036;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1AA03A8C)) % 9)
				{
				case 2u:
					break;
				default:
					return;
				case 7u:
					LuaDLL.tolua_pushfloat2(L, mgrFromLuaState.packVec2, ((Touch)(ref touch)).rawPosition.x, ((Touch)(ref touch)).rawPosition.y);
					num = (int)((num2 * 574189508) ^ 0x29619570);
					continue;
				case 8u:
					LuaDLL.lua_call(L, 7, -1);
					num = ((int)num2 * -269537569) ^ -942404055;
					continue;
				case 3u:
					LuaDLL.lua_pushinteger(L, ((Touch)(ref touch)).fingerId);
					num = ((int)num2 * -138331211) ^ -1574611983;
					continue;
				case 6u:
					LuaDLL.lua_pushinteger(L, (int)((Touch)(ref touch)).phase);
					num = ((int)num2 * -1471618769) ^ -1443120582;
					continue;
				case 0u:
					LuaDLL.lua_pushinteger(L, ((Touch)(ref touch)).tapCount);
					num = (int)((num2 * 668864604) ^ 0x52A78B00);
					continue;
				case 4u:
					LuaDLL.tolua_pushfloat2(L, mgrFromLuaState.packVec2, ((Touch)(ref touch)).deltaPosition.x, ((Touch)(ref touch)).deltaPosition.y);
					LuaDLL.lua_pushnumber(L, ((Touch)(ref touch)).deltaTime);
					num = (int)(num2 * 95311154) ^ -1251638237;
					continue;
				case 5u:
					LuaDLL.tolua_pushfloat2(L, mgrFromLuaState.packVec2, ((Touch)(ref touch)).position.x, ((Touch)(ref touch)).position.y);
					num = (int)(num2 * 337956182) ^ -313378086;
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public static void Push(IntPtr L, Bounds bound)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr mgrFromLuaState = GetMgrFromLuaState(L);
		LuaDLL.lua_getref(L, mgrFromLuaState.packBounds);
		while (true)
		{
			int num = -1409530188;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -534043398)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_0035;
				default:
					Push(L, ((Bounds)(ref bound)).size);
					LuaDLL.lua_call(L, 2, -1);
					return;
				}
				break;
				IL_0035:
				Push(L, ((Bounds)(ref bound)).center);
				num = (int)(num2 * 1910194597) ^ -970848090;
			}
		}
	}

	public static void PushTraceBack(IntPtr L)
	{
		if (traceback == null)
		{
			goto IL_0007;
		}
		goto IL_0060;
		IL_0007:
		int num = -326022510;
		goto IL_000c;
		IL_000c:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -664189674)) % 5)
			{
			case 0u:
				break;
			default:
				return;
			case 2u:
				LuaDLL.lua_getglobal(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(849556498u));
				num = (int)(num2 * 1849747354) ^ -1498740304;
				continue;
			case 3u:
				return;
			case 4u:
				goto IL_0060;
			case 1u:
				return;
			}
			break;
		}
		goto IL_0007;
		IL_0060:
		traceback.push();
		num = -143431050;
		goto IL_000c;
	}

	static RuntimePlatform _200C_202A_200B_206F_200E_206E_200E_200C_200E_206D_202C_200F_202C_200F_200B_200D_200D_202B_202D_202C_202E_202C_206E_206C_206C_200C_202B_206C_202B_202E_202B_202D_206F_206A_206F_206A_202B_206D_202E_202C_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Application.platform;
	}

	static Type _206E_202A_206E_206B_206C_200F_206A_202E_206E_206C_200E_202C_206C_200B_200F_206E_202D_206E_200F_202C_206F_206A_200D_206D_206A_202C_202B_200C_206D_206F_206A_200C_202A_200D_202E_200D_200E_200E_202C_206D_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static Type _200F_202A_200C_206F_206A_200C_206E_202C_206D_206C_206B_200B_200D_200B_200E_200B_206E_202B_202A_206F_202E_202E_202A_206C_206D_206C_200F_200B_202A_202D_206C_206D_200E_200B_206E_200E_206F_206E_202D_202E_202E(Type P_0)
	{
		return P_0.GetType();
	}

	static string _206E_206A_206D_206B_200F_202A_206D_206F_202A_200F_202B_200D_202A_202D_200D_206E_202A_200D_202E_202A_206A_206F_200D_206A_206C_202B_200E_206F_202D_206D_206D_206D_202E_206A_206D_202B_200F_206F_206C_200E_202E(string P_0, string P_1, string P_2)
	{
		return P_0 + P_1 + P_2;
	}

	static bool _202B_206E_200B_202C_202E_206B_202B_200C_200E_206A_200C_202D_206A_202D_200E_206E_202E_206F_206D_206B_202D_200D_202B_202A_202A_200D_202C_206F_200F_206F_200C_200E_202E_202A_206A_202A_202D_202B_202A_200F_202E(string P_0, string P_1)
	{
		return P_0 != P_1;
	}

	static string _202C_206B_202B_206F_206F_206A_206D_206E_206F_206A_206B_206D_200D_206B_202D_200C_206F_202C_202A_206F_200B_206B_200D_202D_202C_202B_206A_206E_200E_200B_202D_200C_206D_202D_206A_200D_200E_202B_200C_202E_202E(Type P_0)
	{
		return P_0.FullName;
	}

	static void _206F_200E_206D_206A_206F_202E_202B_200C_206D_206A_200B_206B_206B_200B_200B_206F_206D_200E_206A_200F_206C_206B_200E_206F_200D_202A_200E_202D_206D_200E_202C_200F_202C_206A_202E_200B_202D_202B_202A_200F_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}

	static string _200C_202B_202C_200D_202E_202E_200F_202C_206D_200C_200C_200B_200C_200F_202D_200D_202E_206F_200F_206F_206E_202B_200B_202A_200C_206A_206C_202E_200C_202A_206B_202D_200C_200E_206C_202C_202B_206F_206F_202B_202E(Type P_0)
	{
		return P_0.AssemblyQualifiedName;
	}

	static float _200B_206A_200F_200D_206B_202C_202E_200E_206B_206B_202E_202B_206C_200C_200F_200F_202D_206E_206C_200E_200E_206F_206F_200C_202E_202C_200E_202D_200E_202D_200F_200F_206D_206F_206E_202A_206B_200B_206A_202A_202E()
	{
		return Time.deltaTime;
	}

	static float _202A_206C_202D_202D_202B_206E_200B_206F_202E_202E_200C_206E_202B_206B_206E_206F_200D_202A_202C_200E_206F_202B_206E_200F_206C_202B_202D_206F_200F_202A_200D_200E_206E_200B_200F_206D_206D_206B_200F_206B_202E()
	{
		return Time.unscaledDeltaTime;
	}

	static float _202B_202D_206A_200E_202A_202B_200C_200F_202B_202B_202C_206E_206F_202D_200E_200E_200C_206D_206B_200D_202C_200B_200C_206D_206E_206B_202D_202A_202D_202A_202D_200C_202C_206C_202C_202C_202E_202D_206C_200C_202E()
	{
		return Time.fixedDeltaTime;
	}

	static string[] _206A_202B_202B_206F_200D_206B_202B_202E_200B_202D_200E_206E_200C_206C_200E_202A_200C_202A_202B_206F_200C_200F_206A_200F_200F_206A_202A_200C_206A_206A_200C_202E_206F_206F_206D_200B_206C_206B_200B_202E_202E(string P_0, char[] P_1)
	{
		return P_0.Split(P_1);
	}

	static int _200B_202E_200E_202D_206E_202C_206D_202C_202C_206C_202A_206C_206A_202D_206A_202C_200D_202A_200C_202D_206C_200F_200E_200E_202B_202C_200E_200B_206D_202D_206D_200D_200F_200E_206F_202E_202A_200B_200E_206F_202E(string P_0, char P_1)
	{
		return P_0.LastIndexOf(P_1);
	}

	static string _202C_200B_206C_200E_206F_200C_200F_200C_206D_202C_206D_200F_206F_200C_206D_206C_206C_206B_200C_202B_206C_206C_206C_202E_206A_206B_200F_206D_206B_206D_202C_202D_206B_206B_206A_206A_202D_206E_206E_206D_202E(string P_0, int P_1, int P_2)
	{
		return P_0.Substring(P_1, P_2);
	}

	static string _202C_202D_206A_202A_200E_200B_206B_206A_206A_206C_202B_202A_202A_206F_200E_202A_206B_206B_206C_200F_200C_206D_200B_200D_206E_206D_206B_202B_202E_202B_202A_200E_206B_200B_206A_206A_200D_202A_206F_206A_202E(string P_0, int P_1)
	{
		return P_0.Substring(P_1);
	}

	static string _206E_206F_206B_206B_202D_200B_202E_202D_200E_202E_200B_206E_202B_202C_202A_202E_202D_202D_206E_202B_200F_200C_200D_202C_206E_202E_200B_206E_202D_206D_202D_200B_206A_202E_206F_202B_206E_200B_200D_202B_202E(string P_0, object P_1)
	{
		return string.Format(P_0, P_1);
	}

	static bool _200D_200D_200B_206A_200B_200E_202C_206A_200D_206F_202E_206E_200B_206C_200D_200C_202D_206D_202A_200E_202A_206B_206C_200E_206B_200E_202D_200C_200C_202C_200F_206C_200E_202B_202B_202B_202A_206E_200E_202C_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static bool _202B_202B_202C_200E_200E_202C_206F_202A_202D_206F_202C_202E_206A_206E_206E_200F_202A_206F_206D_200F_206A_200C_202A_200F_206D_206F_206C_206B_200C_206C_206F_200E_206F_206A_206E_200F_200D_200B_206A_206D_202E(TrackedReference P_0, TrackedReference P_1)
	{
		return P_0 == P_1;
	}

	static string _202A_200F_200F_200E_206E_200D_200B_202C_202C_202C_200C_202D_202B_200C_206C_200C_206B_200D_202D_200B_206A_206F_202B_202C_200C_200B_202B_200E_202B_200E_206C_206B_200D_206B_206B_206A_206C_202E_202C_206E_202E(MemberInfo P_0)
	{
		return P_0.Name;
	}

	static Type _202D_206E_202A_200B_206D_202E_202B_206E_206F_202C_202B_206E_206F_206D_202E_200C_206A_206A_202B_202A_200F_200E_200C_200E_206A_206E_200E_200E_200C_202A_206B_200E_202E_206E_200E_202E_202C_200E_202C_202E(object P_0)
	{
		return P_0.GetType();
	}

	static bool _200B_202D_206A_206E_206D_200D_206D_202E_200E_202A_200D_206B_206B_206A_200D_202A_202E_200E_202C_202B_206F_200B_200B_206C_202B_206D_202D_206E_200C_202D_200E_206C_202C_200B_202A_206A_202B_206E_202C_202A_202E(Type P_0, Type P_1)
	{
		return P_0.IsAssignableFrom(P_1);
	}

	static string _202E_200C_200F_202A_202C_202E_206A_200D_202E_206D_206D_206A_206E_206D_206B_202B_200E_200E_202A_206F_200F_206B_200F_202A_202E_202C_202D_202D_200E_202D_202E_200D_200F_200B_202E_200F_200F_200B_206F_200E_202E(string P_0, object P_1, object P_2)
	{
		return string.Format(P_0, P_1, P_2);
	}

	static bool _206F_202A_200E_206F_202B_202A_206D_200E_206B_206E_200C_200D_206E_200B_202E_206D_206C_202E_200B_206E_200D_200B_202D_202B_206C_202E_202A_202B_200B_202A_206B_202B_202E_202A_202D_200B_200F_206A_206D_206D_202E(Type P_0, Type P_1)
	{
		return P_0.IsSubclassOf(P_1);
	}

	static bool _206F_206B_206E_206B_206C_206B_202E_202D_200B_200F_202B_200B_202B_206B_206B_206F_202D_202E_200D_206C_200D_200C_202D_202E_200C_202A_200E_206B_202B_206E_206D_206D_200E_200F_202B_206F_200C_202C_202D_200C_202E(Type P_0)
	{
		return P_0.IsValueType;
	}

	static bool _206F_200C_206C_206E_202A_206B_206E_206F_200D_206A_202A_206A_200D_202E_206C_206C_206A_202A_206B_206F_200F_206E_202B_202D_200D_206A_206F_206A_200B_206D_206E_200B_200D_200B_206A_206A_206D_200D_202E_200C_202E(Type P_0)
	{
		return P_0.IsEnum;
	}

	static bool _200D_206E_206F_206C_206A_202E_206A_200D_206F_200F_206F_202B_202D_206A_206A_200F_200C_202D_200E_202E_202A_200E_206E_206D_206E_206F_206A_202C_202D_202A_206C_202C_202A_206E_206E_206B_200F_200B_206E_206A_202E(Type P_0)
	{
		return P_0.IsPrimitive;
	}

	static double _206E_200F_202D_200B_200E_200E_200F_206A_206E_200D_202A_200D_206E_200E_200C_200E_202C_200E_206A_206B_200B_202B_202A_200F_206D_200D_202C_202D_200D_200E_206E_200E_206B_202D_200B_202B_206E_206F_202D_206A_202E(object P_0)
	{
		return Convert.ToDouble(P_0);
	}

	static bool _200C_206B_200D_200F_206C_202A_206A_206D_202D_206F_206A_202D_202E_206F_202A_206E_206E_202D_202A_206F_202B_202B_202B_206F_206C_202B_202A_202C_202D_206C_206E_206F_200C_200C_206C_206C_200E_200E_202A_202E_202E(Type P_0)
	{
		return P_0.IsArray;
	}

	static bool _202B_206F_202D_200D_206F_206C_200C_200C_202C_206C_206C_206C_206A_202A_200C_206A_202E_206B_206C_200F_206C_200F_206B_206B_206D_200D_200F_200E_202C_206F_206B_202D_200F_206A_206B_206B_206A_206B_200D_202E_202E(string P_0, string P_1)
	{
		return P_0 == P_1;
	}

	static StackTrace _206F_200E_206D_200B_206C_200D_200C_206A_200E_202B_200B_202A_200E_206B_206B_206D_206A_206D_200B_200E_200F_206B_202C_206E_200B_202A_206D_202E_206D_200B_200D_206D_206D_202E_206A_206C_206B_206C_202E_206C_202E(int P_0, bool P_1)
	{
		return new StackTrace(P_0, P_1);
	}

	static StackFrame _200B_206D_206E_206C_202B_202E_206C_206D_206D_206C_200B_202C_206B_200F_202C_206F_202A_202B_202E_202A_202C_202B_206D_206C_202B_206C_200C_200E_202B_206E_200C_206F_200C_202B_206B_206A_206E_202B_206D_200C_202E(StackTrace P_0, int P_1)
	{
		return P_0.GetFrame(P_1);
	}

	static string _200B_202E_202D_206B_206E_206D_206E_206E_206A_202A_206F_202C_202D_200B_200C_206C_200D_206D_200F_206C_202B_202B_206C_200B_202A_200B_200E_206B_202E_202D_202E_202D_206D_202A_202D_200D_200E_200E_206F_206D_202E(StackFrame P_0)
	{
		return P_0.GetFileName();
	}

	static string _202D_206A_200B_202D_206C_202C_200D_200F_200C_206F_202B_206F_200C_206A_200E_206D_200B_200E_206E_200D_200C_200C_206A_206D_206A_200B_202A_206A_206F_206F_200C_200B_202A_200E_200E_206D_202A_202B_202C_206A_202E(string P_0)
	{
		return Path.GetFileName(P_0);
	}

	static bool _206B_206E_200D_202A_206F_206E_206B_202B_206A_206C_206A_200F_202E_200F_202C_200F_202E_206A_206B_202B_202D_202A_200F_202B_206B_200D_200F_206B_206C_200C_206E_202B_200F_206A_202B_206B_202E_200C_202B_206D_202E(string P_0, string P_1)
	{
		return P_0.Contains(P_1);
	}

	static int _202E_202D_200E_200C_200D_200D_200B_200C_206D_202E_206C_202E_200F_200D_206B_202A_202E_206D_206D_206D_200D_202D_206A_206D_206E_206F_200D_206A_206A_202E_206E_200D_206E_202A_206D_202E_206D_200E_200B_200D_202E(string P_0, string P_1)
	{
		return P_0.LastIndexOf(P_1);
	}

	static MethodBase _202C_206A_206F_200F_202B_202B_206F_206E_206E_206E_200C_206C_200C_200D_206E_206C_206C_202A_202A_202A_202B_200D_200E_206A_206D_206C_200C_206E_206E_206D_202B_206A_206B_206E_206C_202C_202E_206D_202E_202E(StackFrame P_0)
	{
		return P_0.GetMethod();
	}

	static string _202B_200D_202D_206C_206C_202E_200F_206F_200B_206E_202D_200D_206D_206D_202E_200F_202C_206B_206A_202B_202D_202E_200B_206B_200C_202A_202C_200B_206F_206E_200E_206F_202B_206C_202C_206D_200C_202A_206C_202E(object P_0)
	{
		return P_0.ToString();
	}

	static object _206D_200F_200C_206E_200B_202D_206B_202E_202C_202C_206D_202C_206E_200C_200E_200C_200F_206A_202B_206E_200C_200F_202A_206D_202E_200F_202E_202B_202C_200E_202B_202B_202B_202E_202E_206D_200F_206D_206C_200F_202E(object P_0, Type P_1)
	{
		return Convert.ChangeType(P_0, P_1);
	}

	static int _200C_206E_200E_200E_200C_206E_206B_206B_206C_202A_206A_200F_200E_206F_200E_206A_202B_206E_202B_200D_206D_206E_206C_206D_202C_200B_206C_202D_202E_202C_200C_206B_206A_206A_206F_206F_206E_206C_200B_206F_202E(Array P_0)
	{
		return P_0.Length;
	}

	static string _206D_206C_206A_206A_206A_200F_200C_206E_206D_206E_206E_200F_206C_200F_200C_202A_206A_206E_202E_206E_202A_206C_206D_206E_206A_206C_206E_200C_202B_202D_200E_206B_200C_200D_202E_206D_202A_206E_200D_200C_202E(object[] P_0)
	{
		return string.Concat(P_0);
	}

	static object _202C_200F_202B_202A_206A_200E_200B_202A_202A_202D_202D_200F_202D_206B_200F_206A_206D_202C_200C_202A_206C_202D_202E_200F_202E_200E_206D_206B_206E_206E_200E_202D_200D_206C_202E_200C_206B_202B_206E_200F_202E(Array P_0, int P_1)
	{
		return P_0.GetValue(P_1);
	}

	static Type _206B_200F_206F_202C_200F_202E_206D_202D_200B_200F_202B_200D_202B_200C_206B_202E_200C_206C_206B_206C_206E_202A_206A_202A_200D_202E_206B_200C_200B_206F_206C_206E_206A_200D_200B_202D_206C_202A_206A_206D_202E(Type P_0)
	{
		return P_0.GetElementType();
	}

	static void _202A_206D_206E_202D_200D_200B_200D_206E_200E_206E_200B_202E_206E_200D_200F_200C_200B_202D_206C_206C_200B_202B_206B_206F_202A_206C_206E_202A_206B_206A_202A_206D_206F_202C_202E_200C_200F_202B_202C_200F_202E(Array P_0, object P_1, int P_2)
	{
		P_0.SetValue(P_1, P_2);
	}

	static string _200D_202D_206A_206A_200B_206D_200B_200D_200B_200D_200B_202D_206F_202C_206D_206C_206B_206D_200D_202A_202C_206C_202A_206B_206C_202E_206D_200D_200C_202E_200D_200C_202C_200D_200F_200F_206F_202D_202E_206A_202E(string P_0)
	{
		return P_0.ToString();
	}
}
