using System;
using System.Collections;
using System.Collections.Specialized;

namespace LuaInterface;

public class LuaTable : LuaBase
{
	public object this[string field]
	{
		get
		{
			return _Interpreter.getObject(_Reference, field);
		}
		set
		{
			_Interpreter.setObject(_Reference, field, value);
		}
	}

	public object this[object field]
	{
		get
		{
			return _Interpreter.getObject(_Reference, field);
		}
		set
		{
			_Interpreter.setObject(_Reference, field, value);
		}
	}

	public int Count => _200B_200C_206C_200E_200D_206D_202C_206A_206C_206B_206F_200C_202E_200C_206D_206A_200C_202A_200D_206F_202D_202D_206E_206C_202E_206B_202E_206D_200E_206D_206B_206C_202C_200C_200B_200F_200D_200E_202E(_Interpreter.GetTableDict(this));

	public ICollection Keys => _206D_202E_206A_200F_200C_206D_206B_200C_200C_200C_202C_202C_200E_200F_206E_200C_206A_200F_206C_202B_206A_202C_202C_206B_200B_200E_206D_200C_200B_206C_206A_206A_200E_202E_206D_206D_200F_206D_202A_202B_202E(_Interpreter.GetTableDict(this));

	public ICollection Values => _200B_200D_200F_206B_202A_202E_206C_200F_206D_206B_200F_206B_206C_200B_206E_206F_200F_206A_206B_202C_200D_206E_200D_202D_206C_202A_202C_200E_202E_206C_206E_200C_206A_206D_200F_202C_206E_206C_206B_202A_202E(_Interpreter.GetTableDict(this));

	public LuaTable(int P_0, LuaState P_1)
	{
		while (true)
		{
			int num = 1601602461;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x51FD6C68)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_0028;
				case 2u:
					return;
				}
				break;
				IL_0028:
				_Reference = P_0;
				_Interpreter = P_1;
				translator = P_1.translator;
				num = ((int)num2 * -445842947) ^ -1144172757;
			}
		}
	}

	public LuaTable(int P_0, IntPtr P_1)
	{
		while (true)
		{
			int num = 759646831;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x71C2DDAF)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_0028;
				default:
					translator = ObjectTranslator.FromState(P_1);
					_Interpreter = translator.interpreter;
					return;
				}
				break;
				IL_0028:
				_Reference = P_0;
				num = (int)((num2 * 2088703586) ^ 0x4DF1B7D5);
			}
		}
	}

	public IDictionaryEnumerator GetEnumerator()
	{
		return _202C_202E_206E_202D_206A_206F_206C_202E_200C_200C_206B_202C_202A_206E_206F_200F_206C_200F_202B_200F_202D_206D_200D_202C_202C_206C_202D_202C_202A_206F_200F_206C_200B_206E_200E_200C_202D_202C_202E_206A_202E(_Interpreter.GetTableDict(this));
	}

	public void SetMetaTable(LuaTable metaTable)
	{
		push(_Interpreter.L);
		while (true)
		{
			int num = 1136032619;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x220BC91C)) % 5)
				{
				case 2u:
					break;
				default:
					return;
				case 3u:
					metaTable.push(_Interpreter.L);
					num = (int)(num2 * 798581781) ^ -1917310245;
					continue;
				case 1u:
					LuaDLL.lua_pop(_Interpreter.L, 1);
					num = (int)(num2 * 1288867028) ^ -2047473980;
					continue;
				case 0u:
					LuaDLL.lua_setmetatable(_Interpreter.L, -2);
					num = (int)(num2 * 1884384119) ^ -1991837924;
					continue;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	public T[] ToArray<T>()
	{
		IntPtr l = _Interpreter.L;
		while (true)
		{
			int num = 1386758572;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x73380A36)) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_002e;
				default:
					return LuaScriptMgr.GetArrayObject<T>(l, -1);
				}
				break;
				IL_002e:
				push(l);
				num = ((int)num2 * -1317864834) ^ -233816226;
			}
		}
	}

	public void Set(string key, object o)
	{
		IntPtr l = _Interpreter.L;
		while (true)
		{
			int num = 1367002407;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6BE23241)) % 4)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					push(l);
					num = (int)(num2 * 2124981584) ^ -2016931548;
					continue;
				case 1u:
					LuaDLL.lua_pushstring(l, key);
					PushArgs(l, o);
					LuaDLL.lua_rawset(l, -3);
					LuaDLL.lua_settop(l, 0);
					num = (int)((num2 * 1124600605) ^ 0x581C8B7B);
					continue;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	internal object rawget(string field)
	{
		return _Interpreter.rawGetObject(_Reference, field);
	}

	internal object rawgetFunction(string field)
	{
		object obj = _Interpreter.rawGetObject(_Reference, field);
		while (true)
		{
			int num = 603380268;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)(num ^ 0x39FE85FB)) % 4)
				{
				case 0u:
					break;
				case 3u:
				{
					int num4;
					if (obj is LuaCSFunction)
					{
						num3 = 1079299701;
						num4 = num3;
					}
					else
					{
						num3 = 1084030898;
						num4 = num3;
					}
					goto IL_004f;
				}
				case 1u:
					return new LuaFunction((LuaCSFunction)obj, _Interpreter);
				default:
					return obj;
				}
				break;
				IL_004f:
				num = num3 ^ ((int)num2 * -755486303);
			}
		}
	}

	public LuaFunction RawGetFunc(string field)
	{
		IntPtr l = _Interpreter.L;
		LuaFunction result = default(LuaFunction);
		int newTop = default(int);
		while (true)
		{
			int num = 46166673;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x522B40EF)) % 7)
				{
				case 0u:
					break;
				case 3u:
					LuaDLL.lua_pushstring(l, field);
					LuaDLL.lua_gettable(l, -2);
					num = (int)(num2 * 1571651518) ^ -673591772;
					continue;
				case 2u:
					result = new LuaFunction(LuaDLL.luaL_ref(l, LuaIndexes.LUA_REGISTRYINDEX), l);
					num = (int)((num2 * 1834120181) ^ 0x63166179);
					continue;
				case 1u:
				{
					LuaTypes luaTypes = LuaTypes.LUA_TNONE;
					result = null;
					num = ((int)num2 * -1644300114) ^ 0x356EC616;
					continue;
				}
				case 5u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(l, -1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TFUNCTION)
					{
						num3 = 433596197;
						num4 = num3;
					}
					else
					{
						num3 = 2136067379;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -2009881836);
					continue;
				}
				case 6u:
					newTop = LuaDLL.lua_gettop(l);
					LuaDLL.lua_getref(l, _Reference);
					num = (int)(num2 * 651366564) ^ -1840401993;
					continue;
				default:
					LuaDLL.lua_settop(l, newTop);
					return result;
				}
				break;
			}
		}
	}

	internal void push(IntPtr luaState)
	{
		LuaDLL.lua_getref(luaState, _Reference);
	}

	public override string ToString()
	{
		return global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3762522053u);
	}

	static IDictionaryEnumerator _202C_202E_206E_202D_206A_206F_206C_202E_200C_200C_206B_202C_202A_206E_206F_200F_206C_200F_202B_200F_202D_206D_200D_202C_202C_206C_202D_202C_202A_206F_200F_206C_200B_206E_200E_200C_202D_202C_202E_206A_202E(ListDictionary P_0)
	{
		return P_0.GetEnumerator();
	}

	static int _200B_200C_206C_200E_200D_206D_202C_206A_206C_206B_206F_200C_202E_200C_206D_206A_200C_202A_200D_206F_202D_202D_206E_206C_202E_206B_202E_206D_200E_206D_206B_206C_202C_200C_200B_200F_200D_200E_202E(ListDictionary P_0)
	{
		return P_0.Count;
	}

	static ICollection _206D_202E_206A_200F_200C_206D_206B_200C_200C_200C_202C_202C_200E_200F_206E_200C_206A_200F_206C_202B_206A_202C_202C_206B_200B_200E_206D_200C_200B_206C_206A_206A_200E_202E_206D_206D_200F_206D_202A_202B_202E(ListDictionary P_0)
	{
		return P_0.Keys;
	}

	static ICollection _200B_200D_200F_206B_202A_202E_206C_200F_206D_206B_200F_206B_206C_200B_206E_206F_200F_206A_206B_202C_200D_206E_200D_202D_206C_202A_202C_200E_202E_206C_206E_200C_206A_206D_200F_202C_206E_206C_206B_202A_202E(ListDictionary P_0)
	{
		return P_0.Values;
	}
}
