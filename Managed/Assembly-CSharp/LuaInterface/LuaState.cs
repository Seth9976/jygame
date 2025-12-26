using System;
using System.Collections.Specialized;
using System.IO;
using System.Reflection;
using System.Text;

namespace LuaInterface;

public class LuaState : IDisposable
{
	public IntPtr L;

	internal LuaCSFunction tracebackFunction;

	internal ObjectTranslator translator;

	internal LuaCSFunction panicCallback;

	internal LuaCSFunction printFunction;

	internal LuaCSFunction loadfileFunction;

	internal LuaCSFunction loaderFunction;

	internal LuaCSFunction dofileFunction;

	internal LuaCSFunction import_wrapFunction;

	public object this[string fullPath]
	{
		get
		{
			object result = null;
			string[] array2 = default(string[]);
			string[] array = default(string[]);
			int newTop = default(int);
			while (true)
			{
				int num = 375970579;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x5F241626)) % 7)
					{
					case 0u:
						break;
					case 4u:
						result = getObject(array2);
						num = ((int)num2 * -2050838354) ^ -687371165;
						continue;
					case 1u:
						array2 = new string[array.Length - 1];
						_200D_206B_206A_206F_206B_200B_206B_200D_202E_200B_202C_200D_206F_206D_202A_202B_202D_200C_200F_202E_206C_200C_206C_200B_206B_202E_200B_200E_206D_206C_206B_202A_206C_202E_200D_206E_206E_202D_206E_202B_202E((Array)array, 1, (Array)array2, 0, array.Length - 1);
						num = ((int)num2 * -1704556108) ^ -1407018159;
						continue;
					case 3u:
						LuaDLL.lua_settop(L, newTop);
						num = 1344580761;
						continue;
					case 6u:
						newTop = LuaDLL.lua_gettop(L);
						array = _202D_202D_200C_206E_206A_206B_200B_206A_200F_206D_206A_200E_200C_200C_206D_206F_206F_200B_202B_206E_202A_200E_206A_200D_202D_202A_202A_206E_202E_206D_206E_206D_200E_206A_202E_202B_206A_202A_206D_206A_202E(fullPath, new char[1] { '.' });
						LuaDLL.lua_getglobal(L, array[0]);
						result = translator.getObject(L, -1);
						num = ((int)num2 * -1622452168) ^ 0x498A7B1C;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (array.Length > 1)
						{
							num3 = -1231124854;
							num4 = num3;
						}
						else
						{
							num3 = -347363395;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 1566154750);
						continue;
					}
					default:
						return result;
					}
					break;
				}
			}
		}
		set
		{
			int newTop = LuaDLL.lua_gettop(L);
			string[] array = default(string[]);
			while (true)
			{
				int num = 1075732942;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x4209AB4F)) % 9)
					{
					case 3u:
						break;
					case 8u:
						translator.push(L, value);
						LuaDLL.lua_setglobal(L, fullPath);
						num = (int)(num2 * 1522416097) ^ -1234801284;
						continue;
					case 6u:
					{
						int num4;
						int num5;
						if (array.Length != 1)
						{
							num4 = 1680976629;
							num5 = num4;
						}
						else
						{
							num4 = 1699898999;
							num5 = num4;
						}
						num = num4 ^ (int)(num2 * 1576268689);
						continue;
					}
					case 4u:
						Debugger.LogError(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1156359471u), array[0]);
						LuaDLL.lua_settop(L, newTop);
						num = (int)(num2 * 2084063529) ^ -1388418809;
						continue;
					case 5u:
					{
						string[] array2 = new string[array.Length - 1];
						_200D_206B_206A_206F_206B_200B_206B_200D_202E_200B_202C_200D_206F_206D_202A_202B_202D_200C_200F_202E_206C_200C_206C_200B_206B_202E_200B_200E_206D_206C_206B_202A_206C_202E_200D_206E_206E_202D_206E_202B_202E((Array)array, 1, (Array)array2, 0, array.Length - 1);
						setObject(array2, value);
						num = 439353787;
						continue;
					}
					case 0u:
					{
						LuaDLL.lua_rawglobal(L, array[0]);
						int num3;
						if (LuaDLL.lua_type(L, -1) != LuaTypes.LUA_TNIL)
						{
							num = 111748846;
							num3 = num;
						}
						else
						{
							num = 992936160;
							num3 = num;
						}
						continue;
					}
					case 2u:
						array = _202D_202D_200C_206E_206A_206B_200B_206A_200F_206D_206A_200E_200C_200C_206D_206F_206F_200B_202B_206E_202A_200E_206A_200D_202D_202A_202A_206E_202E_206D_206E_206D_200E_206A_202E_202B_206A_202A_206D_206A_202E(fullPath, new char[1] { '.' });
						num = ((int)num2 * -1111357493) ^ 0x1E192F2B;
						continue;
					case 1u:
						return;
					default:
						LuaDLL.lua_settop(L, newTop);
						return;
					}
					break;
				}
			}
		}
	}

	public LuaState()
	{
		L = LuaDLL.luaL_newstate();
		LuaDLL.luaL_openlibs(L);
		LuaDLL.lua_pushstring(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(234496036u));
		LuaDLL.lua_pushboolean(L, value: true);
		LuaDLL.lua_settable(L, LuaIndexes.LUA_REGISTRYINDEX);
		LuaDLL.lua_newtable(L);
		LuaDLL.lua_setglobal(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1960751554u));
		LuaDLL.lua_pushvalue(L, LuaIndexes.LUA_GLOBALSINDEX);
		LuaDLL.lua_getglobal(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2283296501u));
		LuaDLL.lua_pushstring(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3115008415u));
		LuaDLL.lua_getglobal(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3539834168u));
		LuaDLL.lua_settable(L, -3);
		LuaDLL.lua_pushstring(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4088474395u));
		LuaDLL.lua_getglobal(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1338792064u));
		LuaDLL.lua_settable(L, -3);
		LuaDLL.lua_pushstring(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1013268820u));
		LuaDLL.lua_getglobal(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1013268820u));
		LuaDLL.lua_settable(L, -3);
		LuaDLL.lua_replace(L, LuaIndexes.LUA_GLOBALSINDEX);
		translator = new ObjectTranslator(this, L);
		LuaDLL.lua_replace(L, LuaIndexes.LUA_GLOBALSINDEX);
		translator.PushTranslator(L);
		panicCallback = LuaStatic.panic;
		LuaDLL.lua_atpanic(L, panicCallback);
		printFunction = LuaStatic.print;
		LuaDLL.lua_pushstdcallcfunction(L, printFunction);
		LuaDLL.lua_setfield(L, LuaIndexes.LUA_GLOBALSINDEX, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(802307614u));
		loadfileFunction = LuaStatic.loadfile;
		LuaDLL.lua_pushstdcallcfunction(L, loadfileFunction);
		LuaDLL.lua_setfield(L, LuaIndexes.LUA_GLOBALSINDEX, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1618987159u));
		dofileFunction = LuaStatic.dofile;
		LuaDLL.lua_pushstdcallcfunction(L, dofileFunction);
		LuaDLL.lua_setfield(L, LuaIndexes.LUA_GLOBALSINDEX, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(873122692u));
		import_wrapFunction = LuaStatic.importWrap;
		LuaDLL.lua_pushstdcallcfunction(L, import_wrapFunction);
		LuaDLL.lua_setfield(L, LuaIndexes.LUA_GLOBALSINDEX, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1584792443u));
		loaderFunction = LuaStatic.loader;
		LuaDLL.lua_pushstdcallcfunction(L, loaderFunction);
		int index = LuaDLL.lua_gettop(L);
		LuaDLL.lua_getfield(L, LuaIndexes.LUA_GLOBALSINDEX, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(471240931u));
		LuaDLL.lua_getfield(L, -1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2747994566u));
		int num = LuaDLL.lua_gettop(L);
		for (int num2 = LuaDLL.luaL_getn(L, num) + 1; num2 > 1; num2--)
		{
			LuaDLL.lua_rawgeti(L, num, num2 - 1);
			LuaDLL.lua_rawseti(L, num, num2);
		}
		LuaDLL.lua_pushvalue(L, index);
		LuaDLL.lua_rawseti(L, num, 1);
		LuaDLL.lua_settop(L, 0);
		DoString(LuaStatic.init_luanet);
		tracebackFunction = LuaStatic.traceback;
	}

	public void Close()
	{
		if (!(L != IntPtr.Zero))
		{
			return;
		}
		while (true)
		{
			int num = -1964875402;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2107798661)) % 4)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					translator.Destroy();
					num = (int)((num2 * 1957667041) ^ 0xE8F8DBD);
					continue;
				case 3u:
					LuaDLL.lua_close(L);
					num = (int)(num2 * 936623689) ^ -1827996262;
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public ObjectTranslator GetTranslator()
	{
		return translator;
	}

	internal void ThrowExceptionFromError(int oldTop)
	{
		string text = LuaDLL.lua_tostring(L, -1);
		LuaDLL.lua_settop(L, oldTop);
		if (text == null)
		{
			while (true)
			{
				int num = 1698986639;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x687E9F8A)) % 3)
					{
					case 0u:
						break;
					case 2u:
						text = global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2529472362u);
						num = (int)(num2 * 478774370) ^ -439425822;
						continue;
					default:
						goto end_IL_001c;
					}
					break;
				}
				continue;
				end_IL_001c:
				break;
			}
		}
		throw new LuaScriptException(text, string.Empty);
	}

	internal int SetPendingException(Exception e)
	{
		if (e != null)
		{
			while (true)
			{
				int num = 257997071;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x8CAADFC)) % 4)
					{
					case 2u:
						break;
					case 3u:
						translator.throwError(L, _202A_202C_206A_200F_206B_206C_206C_206F_206A_202B_202C_200C_206C_206E_200B_202C_202E_202D_200B_206A_206E_206A_200B_200D_206B_202A_200E_206E_202C_202D_202C_206B_202D_206A_202E_206E_200C_206B_202C_206B_202E(e));
						LuaDLL.lua_pushnil(L);
						num = (int)((num2 * 1082829094) ^ 0x7F052572);
						continue;
					case 0u:
						return 1;
					default:
						goto end_IL_0003;
					}
					break;
				}
				continue;
				end_IL_0003:
				break;
			}
		}
		return 0;
	}

	public LuaFunction LoadString(string chunk, string name, LuaTable env)
	{
		int oldTop = LuaDLL.lua_gettop(L);
		byte[] array = _202D_200B_202A_202B_200C_206F_200E_200E_206A_206B_202A_202C_200C_200D_206D_206E_202C_206A_202E_200F_202A_202A_206D_200E_200E_206A_206B_200E_200C_200E_202A_206C_202D_202E_202E_200E_206E_206E_202B_200F_202E(_206D_202D_200F_202E_200B_200B_206B_200F_202E_202B_206F_202D_206E_200B_202D_200C_206E_200E_206F_202B_206E_206F_200C_200C_206E_202C_200D_206A_200C_202C_206F_200F_206E_200C_200C_202E_202D_200D_200C_202D_202E(), chunk);
		LuaFunction function = default(LuaFunction);
		while (true)
		{
			int num = -1714168445;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1032104129)) % 8)
				{
				case 7u:
					break;
				case 4u:
				{
					int num4;
					int num5;
					if (LuaDLL.luaL_loadbuffer(L, array, array.Length, name) != 0)
					{
						num4 = -24096383;
						num5 = num4;
					}
					else
					{
						num4 = -578493540;
						num5 = num4;
					}
					num = num4 ^ (int)(num2 * 1689319338);
					continue;
				}
				case 1u:
					env.push(L);
					LuaDLL.lua_setfenv(L, -2);
					num = ((int)num2 * -228858246) ^ -289836200;
					continue;
				case 6u:
					ThrowExceptionFromError(oldTop);
					num = ((int)num2 * -1002660960) ^ -1641142652;
					continue;
				case 3u:
				{
					int num3;
					if (env == null)
					{
						num = -543895918;
						num3 = num;
					}
					else
					{
						num = -866655242;
						num3 = num;
					}
					continue;
				}
				case 2u:
					translator.popValues(L, oldTop);
					num = ((int)num2 * -560417832) ^ -1265917689;
					continue;
				case 5u:
					function = translator.getFunction(L, -1);
					num = -497497979;
					continue;
				default:
					return function;
				}
				break;
			}
		}
	}

	public LuaFunction LoadString(string chunk, string name)
	{
		return LoadString(chunk, name, null);
	}

	public LuaFunction LoadFile(string fileName)
	{
		int oldTop = LuaDLL.lua_gettop(L);
		string text = default(string);
		LuaFunction function = default(LuaFunction);
		while (true)
		{
			int num = -314057727;
			while (true)
			{
				byte[] array;
				int num4;
				uint num2;
				switch ((num2 = (uint)(num ^ -790550129)) % 4)
				{
				case 3u:
					break;
				case 2u:
					array = null;
					num = (int)(num2 * 1964536411) ^ -1922022368;
					continue;
				case 1u:
					text = Util.LuaPath(fileName);
					num = (int)(num2 * 850744464) ^ -1730143329;
					continue;
				default:
					{
						FileStream fileStream = _206F_200B_200D_200C_200E_206B_202B_200C_202D_206E_202D_206F_200B_200C_202C_206B_200C_206A_206F_202A_200F_200C_200C_206E_206A_202D_202B_200C_206F_200D_202E_202C_202A_200E_206A_200B_206B_206A_206B_206F_202E(text, FileMode.Open);
						try
						{
							BinaryReader binaryReader = _200E_200C_206F_202B_206D_200F_202C_206B_202D_202A_202A_200B_206B_206C_202D_206B_200C_202E_202E_200C_206B_202B_200E_202B_200F_200D_202E_200D_206F_200B_206C_202B_202D_200E_200F_200E_202A_200F_206A_206B_202E((Stream)fileStream);
							array = _202D_202D_206B_202D_206E_200C_206F_200E_202B_206A_206A_206B_200B_202A_200D_206E_200E_202B_200D_206D_206B_206A_200D_206F_206F_202C_200E_206D_202C_206D_202C_202E_200C_202A_206C_202A_200D_206C_206E_202E_202E(binaryReader, (int)_202D_202E_202C_202E_206F_206C_200F_200E_200F_206D_206B_206D_206E_200C_202D_206F_202E_200E_206F_200D_202D_206F_202B_200F_202B_206B_206C_200C_202A_200E_200B_200F_206A_202C_200B_202C_200D_200C_202A_206A_202E(fileStream));
							_202B_202D_200E_206C_202B_200E_202D_206F_200E_202B_202E_200E_206D_206D_202E_206C_200F_206B_206B_202E_206F_200C_206F_202D_202A_200C_202B_206F_206B_206A_200C_206F_202E_202E_200D_206A_200D_206B_202C_202E((Stream)fileStream);
						}
						finally
						{
							if (fileStream != null)
							{
								while (true)
								{
									IL_0086:
									int num3 = -646247082;
									while (true)
									{
										switch ((num2 = (uint)(num3 ^ -790550129)) % 3)
										{
										case 0u:
											break;
										default:
											goto end_IL_008b;
										case 2u:
											goto IL_00a9;
										case 1u:
											goto end_IL_008b;
										}
										goto IL_0086;
										IL_00a9:
										_206E_202C_206E_200F_200F_206A_200D_200C_200F_200D_206D_206A_206C_200D_200D_202D_202B_202C_202D_206F_200E_206A_202D_206D_200E_202C_200F_200D_200B_200F_206B_206C_202E_206E_202E_200F_200B_200C_202E_202C_202E((IDisposable)fileStream);
										num3 = ((int)num2 * -1994786303) ^ -1348310403;
										continue;
										end_IL_008b:
										break;
									}
									break;
								}
							}
						}
						if (LuaDLL.luaL_loadbuffer(L, array, array.Length, fileName) != 0)
						{
							goto IL_00d2;
						}
						goto IL_0110;
					}
					IL_0110:
					function = translator.getFunction(L, -1);
					translator.popValues(L, oldTop);
					num4 = -1840375102;
					goto IL_00d7;
					IL_00d7:
					while (true)
					{
						switch ((num2 = (uint)(num4 ^ -790550129)) % 4)
						{
						case 0u:
							break;
						case 2u:
							ThrowExceptionFromError(oldTop);
							num4 = (int)(num2 * 413589555) ^ -1624088822;
							continue;
						case 3u:
							goto IL_0110;
						default:
							return function;
						}
						break;
					}
					goto IL_00d2;
					IL_00d2:
					num4 = -1168440835;
					goto IL_00d7;
				}
				break;
			}
		}
	}

	public object[] DoString(string chunk)
	{
		return DoString(chunk, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2737103286u), null);
	}

	public object[] DoString(string chunk, string chunkName, LuaTable env)
	{
		int oldTop = LuaDLL.lua_gettop(L);
		byte[] array = _202D_200B_202A_202B_200C_206F_200E_200E_206A_206B_202A_202C_200C_200D_206D_206E_202C_206A_202E_200F_202A_202A_206D_200E_200E_206A_206B_200E_200C_200E_202A_206C_202D_202E_202E_200E_206E_206E_202B_200F_202E(_206D_202D_200F_202E_200B_200B_206B_200F_202E_202B_206F_202D_206E_200B_202D_200C_206E_200E_206F_202B_206E_206F_200C_200C_206E_202C_200D_206A_200C_202C_206F_200F_206E_200C_200C_202E_202D_200D_200C_202D_202E(), chunk);
		while (true)
		{
			int num = -2044668799;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -93732789)) % 9)
				{
				case 0u:
					break;
				case 6u:
					ThrowExceptionFromError(oldTop);
					num = -881410583;
					continue;
				case 2u:
					ThrowExceptionFromError(oldTop);
					num = -881410583;
					continue;
				case 7u:
					env.push(L);
					LuaDLL.lua_setfenv(L, -2);
					num = (int)(num2 * 841681982) ^ -285317617;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (env == null)
					{
						num4 = 1895130394;
						num5 = num4;
					}
					else
					{
						num4 = 1267097593;
						num5 = num4;
					}
					num = num4 ^ ((int)num2 * -2022689877);
					continue;
				}
				case 8u:
				{
					int num6;
					int num7;
					if (LuaDLL.luaL_loadbuffer(L, array, array.Length, chunkName) == 0)
					{
						num6 = 1784973360;
						num7 = num6;
					}
					else
					{
						num6 = 1766772739;
						num7 = num6;
					}
					num = num6 ^ (int)(num2 * 525336705);
					continue;
				}
				case 3u:
				{
					int num3;
					if (LuaDLL.lua_pcall(L, 0, -1, 0) != 0)
					{
						num = -1136325921;
						num3 = num;
					}
					else
					{
						num = -1827626615;
						num3 = num;
					}
					continue;
				}
				case 4u:
					return translator.popValues(L, oldTop);
				default:
					return null;
				}
				break;
			}
		}
	}

	public object[] DoFile(string fileName)
	{
		return DoFile(fileName, null);
	}

	public object[] DoFile(string fileName, LuaTable env)
	{
		LuaDLL.lua_pushstdcallcfunction(L, tracebackFunction);
		int oldTop = default(int);
		byte[] array = default(byte[]);
		string name = default(string);
		object[] result = default(object[]);
		while (true)
		{
			int num = -1098043218;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1717779541)) % 19)
				{
				case 18u:
					break;
				case 4u:
				{
					oldTop = LuaDLL.lua_gettop(L);
					array = LuaStatic.Load(fileName);
					int num10;
					int num11;
					if (array != null)
					{
						num10 = 501074454;
						num11 = num10;
					}
					else
					{
						num10 = 930372689;
						num11 = num10;
					}
					num = num10 ^ ((int)num2 * -846529752);
					continue;
				}
				case 0u:
					env.push(L);
					LuaDLL.lua_setfenv(L, -2);
					num = ((int)num2 * -1713917022) ^ -1606016733;
					continue;
				case 2u:
					LuaDLL.lua_pop(L, 1);
					num = (int)((num2 * 952168971) ^ 0x6EEAE2C4);
					continue;
				case 14u:
				{
					int num6;
					int num7;
					if (!_206B_200E_200F_206C_206D_202B_202D_202B_206B_202B_206A_200F_200D_202A_200C_206D_200E_206F_200D_202B_202B_200C_200E_202C_202D_202D_200D_200B_202D_200C_206C_206C_206F_206E_206D_200C_202C_200B_200F_206F_202E(fileName, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(520677338u)))
					{
						num6 = -614438641;
						num7 = num6;
					}
					else
					{
						num6 = -1553714630;
						num7 = num6;
					}
					num = num6 ^ (int)(num2 * 471377384);
					continue;
				}
				case 15u:
					LuaDLL.lua_pop(L, 1);
					num = -1048506551;
					continue;
				case 3u:
					LuaDLL.lua_pop(L, 1);
					num = (int)(num2 * 318775804) ^ -1082420399;
					continue;
				case 16u:
					ThrowExceptionFromError(oldTop);
					num = -280800275;
					continue;
				case 10u:
				{
					int num8;
					int num9;
					if (LuaDLL.luaL_loadbuffer(L, array, array.Length, name) != 0)
					{
						num8 = -2062286037;
						num9 = num8;
					}
					else
					{
						num8 = -1892642219;
						num9 = num8;
					}
					num = num8 ^ ((int)num2 * -683245259);
					continue;
				}
				case 12u:
					return result;
				case 11u:
					return null;
				case 7u:
					ThrowExceptionFromError(oldTop);
					num = -1185919060;
					continue;
				case 5u:
					Debugger.LogError(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1545745863u), fileName);
					num = ((int)num2 * -1535656569) ^ -183375162;
					continue;
				case 6u:
					name = Util.LuaPath(fileName);
					num = -1274284772;
					continue;
				case 13u:
				{
					int num4;
					int num5;
					if (env == null)
					{
						num4 = -34185490;
						num5 = num4;
					}
					else
					{
						num4 = -998510334;
						num5 = num4;
					}
					num = num4 ^ (int)(num2 * 442863801);
					continue;
				}
				case 17u:
					result = translator.popValues(L, oldTop);
					num = (int)(num2 * 1767327990) ^ -1118749745;
					continue;
				case 8u:
				{
					int num3;
					if (LuaDLL.lua_pcall(L, 0, -1, -2) == 0)
					{
						num = -1194877324;
						num3 = num;
					}
					else
					{
						num = -884179493;
						num3 = num;
					}
					continue;
				}
				case 1u:
					LuaDLL.lua_pop(L, 1);
					num = ((int)num2 * -1860818925) ^ 0x5E3B8B87;
					continue;
				default:
					return null;
				}
				break;
			}
		}
	}

	internal object getObject(string[] remainingPath)
	{
		object obj = null;
		int num3 = default(int);
		while (true)
		{
			int num = -566006607;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -648859220)) % 10)
				{
				case 6u:
					break;
				case 5u:
					num3 = 0;
					num = ((int)num2 * -1551873966) ^ 0x3F777E4B;
					continue;
				case 8u:
					LuaDLL.lua_pushstring(L, remainingPath[num3]);
					num = -2104682564;
					continue;
				case 3u:
					num = ((int)num2 * -323437022) ^ 0x4F9C31CD;
					continue;
				case 0u:
					num = (int)(num2 * 1698797758) ^ -1810902380;
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (obj != null)
					{
						num5 = 1161221940;
						num6 = num5;
					}
					else
					{
						num5 = 1289814137;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -307468979);
					continue;
				}
				case 9u:
					num3++;
					num = -525970121;
					continue;
				case 7u:
				{
					int num4;
					if (num3 < remainingPath.Length)
					{
						num = -1372450706;
						num4 = num;
					}
					else
					{
						num = -38988144;
						num4 = num;
					}
					continue;
				}
				case 2u:
					LuaDLL.lua_gettable(L, -2);
					obj = translator.getObject(L, -1);
					num = (int)((num2 * 1450389726) ^ 0x40BFCF5B);
					continue;
				default:
					return obj;
				}
				break;
			}
		}
	}

	public double GetNumber(string fullPath)
	{
		return (double)this[fullPath];
	}

	public string GetString(string fullPath)
	{
		return (string)this[fullPath];
	}

	public LuaTable GetTable(string fullPath)
	{
		return (LuaTable)this[fullPath];
	}

	public LuaFunction GetFunction(string fullPath)
	{
		object obj = this[fullPath];
		while (true)
		{
			int num = 1874265841;
			while (true)
			{
				uint num2;
				object result;
				switch ((num2 = (uint)(num ^ 0x837EE91)) % 3)
				{
				case 0u:
					break;
				case 1u:
					if (obj is LuaCSFunction)
					{
						goto IL_0032;
					}
					result = (LuaFunction)obj;
					goto IL_0055;
				default:
					{
						result = new LuaFunction((LuaCSFunction)obj, this);
						goto IL_0055;
					}
					IL_0055:
					return (LuaFunction)result;
				}
				break;
				IL_0032:
				num = ((int)num2 * -340456810) ^ 0x2017B7AB;
			}
		}
	}

	public Delegate GetFunction(Type delegateType, string fullPath)
	{
		translator.throwError(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1557017474u));
		return null;
	}

	internal void setObject(string[] remainingPath, object val)
	{
		int num = 0;
		while (true)
		{
			int num2 = -474638926;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -747463014)) % 5)
				{
				case 0u:
					break;
				case 2u:
				{
					int num4;
					if (num >= remainingPath.Length - 1)
					{
						num2 = -949507215;
						num4 = num2;
					}
					else
					{
						num2 = -508731676;
						num4 = num2;
					}
					continue;
				}
				case 1u:
					LuaDLL.lua_pushstring(L, remainingPath[num]);
					LuaDLL.lua_gettable(L, -2);
					num++;
					num2 = -944195754;
					continue;
				case 3u:
					num2 = ((int)num3 * -692192295) ^ -360178754;
					continue;
				default:
					LuaDLL.lua_pushstring(L, remainingPath[remainingPath.Length - 1]);
					translator.push(L, val);
					LuaDLL.lua_settable(L, -3);
					return;
				}
				break;
			}
		}
	}

	public void NewTable(string fullPath)
	{
		string[] array = _202D_202D_200C_206E_206A_206B_200B_206A_200F_206D_206A_200E_200C_200C_206D_206F_206F_200B_202B_206E_202A_200E_206A_200D_202D_202A_202A_206E_202E_206D_206E_206D_200E_206A_202E_202B_206A_202A_206D_206A_202E(fullPath, new char[1] { '.' });
		int newTop = LuaDLL.lua_gettop(L);
		if (array.Length == 1)
		{
			goto IL_0024;
		}
		goto IL_0090;
		IL_0024:
		int num = -2134619965;
		goto IL_0029;
		IL_0029:
		int num3 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1537064207)) % 11)
			{
			case 9u:
				break;
			default:
				return;
			case 5u:
				LuaDLL.lua_newtable(L);
				LuaDLL.lua_setglobal(L, fullPath);
				num = (int)(num2 * 82388051) ^ -598001946;
				continue;
			case 10u:
				goto IL_0090;
			case 3u:
				LuaDLL.lua_newtable(L);
				num = (int)(num2 * 947714335) ^ -1715012910;
				continue;
			case 1u:
				LuaDLL.lua_pushstring(L, array[num3]);
				LuaDLL.lua_gettable(L, -2);
				num3++;
				num = -971647299;
				continue;
			case 2u:
				goto IL_00eb;
			case 7u:
				LuaDLL.lua_settop(L, newTop);
				num = -1064484475;
				continue;
			case 8u:
				num3 = 1;
				num = (int)((num2 * 276694516) ^ 0x1E2D5F11);
				continue;
			case 0u:
				LuaDLL.lua_pushstring(L, array[array.Length - 1]);
				num = ((int)num2 * -1063138679) ^ 0x24E901AF;
				continue;
			case 6u:
				LuaDLL.lua_settable(L, -3);
				num = ((int)num2 * -1854623829) ^ 0x5A89C277;
				continue;
			case 4u:
				return;
			}
			break;
			IL_00eb:
			int num4;
			if (num3 < array.Length - 1)
			{
				num = -10649094;
				num4 = num;
			}
			else
			{
				num = -513718171;
				num4 = num;
			}
		}
		goto IL_0024;
		IL_0090:
		LuaDLL.lua_getglobal(L, array[0]);
		num = -355910922;
		goto IL_0029;
	}

	public LuaTable NewTable()
	{
		int newTop = LuaDLL.lua_gettop(L);
		while (true)
		{
			int num = 2000595648;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1704CE08)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_002e;
				default:
				{
					LuaTable result = (LuaTable)translator.getObject(L, -1);
					LuaDLL.lua_settop(L, newTop);
					return result;
				}
				}
				break;
				IL_002e:
				LuaDLL.lua_newtable(L);
				num = (int)(num2 * 2081499655) ^ -975560390;
			}
		}
	}

	public ListDictionary GetTableDict(LuaTable table)
	{
		ListDictionary listDictionary = _200E_206B_200C_206E_202E_206E_200F_200B_200C_206B_202D_202D_202B_200D_200D_206D_206C_202B_206A_206A_206E_200F_202D_202A_200F_206C_206D_200B_200F_206B_202B_206E_202A_202E_202E_200F_200D_206E_200B_200C_202E();
		int newTop = LuaDLL.lua_gettop(L);
		while (true)
		{
			int num = -637241894;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1158002512)) % 9)
				{
				case 0u:
					break;
				case 1u:
					translator.push(L, table);
					num = (int)(num2 * 1722881751) ^ -833382903;
					continue;
				case 6u:
					LuaDLL.lua_pushnil(L);
					num = (int)((num2 * 1362116557) ^ 0x435C8167);
					continue;
				case 2u:
					_202B_200E_200E_200D_206A_206F_202D_200F_200E_206F_202D_206E_206B_206E_200C_200F_200B_206B_206C_202D_206C_200C_206E_206E_202E_202E_206E_202E_200C_202E_200F_202D_202A_206D_206F_200F_206D_206C_206A_200F_202E(listDictionary, translator.getObject(L, -2), translator.getObject(L, -1));
					num = -263535549;
					continue;
				case 4u:
					num = ((int)num2 * -623699649) ^ -973076619;
					continue;
				case 3u:
					LuaDLL.lua_settop(L, -2);
					num = ((int)num2 * -875721987) ^ 0x6349EB8E;
					continue;
				case 8u:
					LuaDLL.lua_settop(L, newTop);
					num = ((int)num2 * -2060644794) ^ 0x158E0E7A;
					continue;
				case 5u:
				{
					int num3;
					if (LuaDLL.lua_next(L, -2) == 0)
					{
						num = -1825711165;
						num3 = num;
					}
					else
					{
						num = -789145145;
						num3 = num;
					}
					continue;
				}
				default:
					return listDictionary;
				}
				break;
			}
		}
	}

	internal void dispose(int reference)
	{
		if (!(L != IntPtr.Zero))
		{
			return;
		}
		while (true)
		{
			int num = -1026641588;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1715803656)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_0034;
				case 2u:
					return;
				}
				break;
				IL_0034:
				LuaDLL.lua_unref(L, reference);
				num = ((int)num2 * -1468197749) ^ -1055563706;
			}
		}
	}

	internal object rawGetObject(int reference, string field)
	{
		int newTop = LuaDLL.lua_gettop(L);
		object result = default(object);
		while (true)
		{
			int num = 332285304;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x33E780FD)) % 6)
				{
				case 2u:
					break;
				case 4u:
					LuaDLL.lua_rawget(L, -2);
					result = translator.getObject(L, -1);
					num = ((int)num2 * -304550136) ^ 0x72172F87;
					continue;
				case 5u:
					LuaDLL.lua_pushstring(L, field);
					num = ((int)num2 * -171738868) ^ 0x6AFDE8E3;
					continue;
				case 1u:
					LuaDLL.lua_getref(L, reference);
					num = ((int)num2 * -1974349555) ^ -1829116289;
					continue;
				case 0u:
					LuaDLL.lua_settop(L, newTop);
					num = (int)((num2 * 863756257) ^ 0x200604E2);
					continue;
				default:
					return result;
				}
				break;
			}
		}
	}

	internal object getObject(int reference, string field)
	{
		int newTop = LuaDLL.lua_gettop(L);
		LuaDLL.lua_getref(L, reference);
		object result = default(object);
		while (true)
		{
			int num = 506513663;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x13E658A5)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_003a;
				default:
					return result;
				}
				break;
				IL_003a:
				result = getObject(_202D_202D_200C_206E_206A_206B_200B_206A_200F_206D_206A_200E_200C_200C_206D_206F_206F_200B_202B_206E_202A_200E_206A_200D_202D_202A_202A_206E_202E_206D_206E_206D_200E_206A_202E_202B_206A_202A_206D_206A_202E(field, new char[1] { '.' }));
				LuaDLL.lua_settop(L, newTop);
				num = ((int)num2 * -2105723087) ^ -1261349441;
			}
		}
	}

	internal object getObject(int reference, object field)
	{
		int newTop = LuaDLL.lua_gettop(L);
		object result = default(object);
		while (true)
		{
			int num = -1681910609;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1609996338)) % 4)
				{
				case 2u:
					break;
				case 1u:
					LuaDLL.lua_getref(L, reference);
					translator.push(L, field);
					num = ((int)num2 * -1948734568) ^ -1446104522;
					continue;
				case 0u:
					LuaDLL.lua_gettable(L, -2);
					result = translator.getObject(L, -1);
					num = ((int)num2 * -1028281006) ^ -2050795395;
					continue;
				default:
					LuaDLL.lua_settop(L, newTop);
					return result;
				}
				break;
			}
		}
	}

	internal void setObject(int reference, string field, object val)
	{
		int newTop = LuaDLL.lua_gettop(L);
		while (true)
		{
			int num = 1368757410;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4F7DDC67)) % 4)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					LuaDLL.lua_getref(L, reference);
					setObject(_202D_202D_200C_206E_206A_206B_200B_206A_200F_206D_206A_200E_200C_200C_206D_206F_206F_200B_202B_206E_202A_200E_206A_200D_202D_202A_202A_206E_202E_206D_206E_206D_200E_206A_202E_202B_206A_202A_206D_206A_202E(field, new char[1] { '.' }), val);
					num = (int)(num2 * 1183038217) ^ -1440530575;
					continue;
				case 3u:
					LuaDLL.lua_settop(L, newTop);
					num = ((int)num2 * -1675719952) ^ 0x333F3019;
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	internal void setObject(int reference, object field, object val)
	{
		int newTop = LuaDLL.lua_gettop(L);
		LuaDLL.lua_getref(L, reference);
		while (true)
		{
			int num = -1801694936;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1603031839)) % 4)
				{
				case 3u:
					break;
				default:
					return;
				case 1u:
					translator.push(L, field);
					translator.push(L, val);
					num = (int)((num2 * 405081958) ^ 0x3556E65);
					continue;
				case 2u:
					LuaDLL.lua_settable(L, -3);
					LuaDLL.lua_settop(L, newTop);
					num = (int)((num2 * 956115010) ^ 0x3A2E1301);
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public LuaFunction RegisterFunction(string path, object target, MethodBase function)
	{
		int newTop = LuaDLL.lua_gettop(L);
		LuaMethodWrapper luaMethodWrapper = new LuaMethodWrapper(translator, target, _202D_202A_202E_206D_200B_206E_206C_200E_202C_202E_202D_200E_206F_202E_200D_206F_206B_206C_206E_206A_206A_202C_200C_202D_202E_202A_202B_202D_206E_200D_200C_206F_206D_206B_202E_200F_200E_202A_200B_206B_202E((MemberInfo)function), function);
		LuaFunction function2 = default(LuaFunction);
		while (true)
		{
			int num = -797190744;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -860896543)) % 6)
				{
				case 4u:
					break;
				case 3u:
					translator.push(L, new LuaCSFunction(luaMethodWrapper.call));
					num = ((int)num2 * -31318385) ^ -1796121125;
					continue;
				case 0u:
					LuaDLL.lua_settop(L, newTop);
					num = ((int)num2 * -1373964551) ^ 0x2FFF71EC;
					continue;
				case 2u:
					function2 = GetFunction(path);
					num = (int)(num2 * 1466198344) ^ -195666973;
					continue;
				case 1u:
					this[path] = translator.getObject(L, -1);
					num = ((int)num2 * -2012388841) ^ -1386622328;
					continue;
				default:
					return function2;
				}
				break;
			}
		}
	}

	public LuaFunction CreateFunction(object target, MethodBase function)
	{
		int newTop = LuaDLL.lua_gettop(L);
		object obj2 = default(object);
		LuaFunction result = default(LuaFunction);
		while (true)
		{
			int num = 1646980629;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)(num ^ 0x24DB4CEC)) % 4)
				{
				case 3u:
					break;
				case 1u:
				{
					LuaMethodWrapper luaMethodWrapper = new LuaMethodWrapper(translator, target, _202D_202A_202E_206D_200B_206E_206C_200E_202C_202E_202D_200E_206F_202E_200D_206F_206B_206C_206E_206A_206A_202C_200C_202D_202E_202A_202B_202D_206E_200D_200C_206F_206D_206B_202E_200F_200E_202A_200B_206B_202E((MemberInfo)function), function);
					translator.push(L, new LuaCSFunction(luaMethodWrapper.call));
					obj2 = translator.getObject(L, -1);
					if (obj2 is LuaCSFunction)
					{
						num = (int)((num2 * 328672976) ^ 0x7496FDDE);
						continue;
					}
					obj = (LuaFunction)obj2;
					goto IL_00a9;
				}
				case 2u:
					obj = new LuaFunction((LuaCSFunction)obj2, this);
					goto IL_00a9;
				default:
					{
						return result;
					}
					IL_00a9:
					result = (LuaFunction)obj;
					LuaDLL.lua_settop(L, newTop);
					num = 1907047680;
					continue;
				}
				break;
			}
		}
	}

	internal bool compareRef(int ref1, int ref2)
	{
		if (ref1 == ref2)
		{
			goto IL_0004;
		}
		goto IL_003b;
		IL_0004:
		int num = 1303448698;
		goto IL_0009;
		IL_0009:
		uint num2;
		int newTop = default(int);
		switch ((num2 = (uint)(num ^ 0x1EA0AC47)) % 4)
		{
		case 3u:
			break;
		case 1u:
			return true;
		case 0u:
			goto IL_003b;
		default:
		{
			LuaDLL.lua_getref(L, ref2);
			int num3 = LuaDLL.lua_equal(L, -1, -2);
			LuaDLL.lua_settop(L, newTop);
			return num3 != 0;
		}
		}
		goto IL_0004;
		IL_003b:
		newTop = LuaDLL.lua_gettop(L);
		LuaDLL.lua_getref(L, ref1);
		num = 1695788445;
		goto IL_0009;
	}

	internal void pushCSFunction(LuaCSFunction function)
	{
		translator.pushFunction(L, function);
	}

	public void Dispose()
	{
		Dispose(dispose: true);
		L = IntPtr.Zero;
		while (true)
		{
			int num = -1570243628;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1061711107)) % 4)
				{
				case 3u:
					break;
				default:
					return;
				case 1u:
					_202E_206D_206C_206A_206F_202B_202C_200B_202E_206C_200E_206D_206E_200F_206D_202D_200D_200D_200E_200D_206F_200E_200C_202B_202A_200C_206A_206F_200E_200E_202A_202B_206C_206F_200D_206B_202C_206B_206F_202D_202E((object)this);
					num = (int)((num2 * 2002469206) ^ 0xEF806FF);
					continue;
				case 0u:
					_200C_200E_206E_206C_206F_202E_202E_202C_200B_202D_200C_200D_202D_202C_206F_202D_206B_200E_202C_206B_202B_206F_202A_202D_206F_200E_202D_206E_202C_202B_202C_200D_200D_200E_206D_206C_206B_206D_200E_200F_202E(2, GCCollectionMode.Optimized);
					num = (int)((num2 * 392646387) ^ 0x63DF0723);
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public virtual void Dispose(bool dispose)
	{
		if (!dispose)
		{
			return;
		}
		while (true)
		{
			int num = 709925004;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x734D6AF3)) % 5)
				{
				case 3u:
					break;
				default:
					return;
				case 2u:
				{
					int num3;
					int num4;
					if (translator != null)
					{
						num3 = -1248694048;
						num4 = num3;
					}
					else
					{
						num3 = -521224383;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1882483722);
					continue;
				}
				case 0u:
					translator = null;
					num = ((int)num2 * -1570357386) ^ 0xA526E29;
					continue;
				case 1u:
					translator.pendingEvents.Dispose();
					num = (int)((num2 * 683850714) ^ 0xFCCA50C);
					continue;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	static string _202A_202C_206A_200F_206B_206C_206C_206F_206A_202B_202C_200C_206C_206E_200B_202C_202E_202D_200B_206A_206E_206A_200B_200D_206B_202A_200E_206E_202C_202D_202C_206B_202D_206A_202E_206E_200C_206B_202C_206B_202E(Exception P_0)
	{
		return P_0.ToString();
	}

	static Encoding _206D_202D_200F_202E_200B_200B_206B_200F_202E_202B_206F_202D_206E_200B_202D_200C_206E_200E_206F_202B_206E_206F_200C_200C_206E_202C_200D_206A_200C_202C_206F_200F_206E_200C_200C_202E_202D_200D_200C_202D_202E()
	{
		return Encoding.UTF8;
	}

	static byte[] _202D_200B_202A_202B_200C_206F_200E_200E_206A_206B_202A_202C_200C_200D_206D_206E_202C_206A_202E_200F_202A_202A_206D_200E_200E_206A_206B_200E_200C_200E_202A_206C_202D_202E_202E_200E_206E_206E_202B_200F_202E(Encoding P_0, string P_1)
	{
		return P_0.GetBytes(P_1);
	}

	static FileStream _206F_200B_200D_200C_200E_206B_202B_200C_202D_206E_202D_206F_200B_200C_202C_206B_200C_206A_206F_202A_200F_200C_200C_206E_206A_202D_202B_200C_206F_200D_202E_202C_202A_200E_206A_200B_206B_206A_206B_206F_202E(string P_0, FileMode P_1)
	{
		return new FileStream(P_0, P_1);
	}

	static BinaryReader _200E_200C_206F_202B_206D_200F_202C_206B_202D_202A_202A_200B_206B_206C_202D_206B_200C_202E_202E_200C_206B_202B_200E_202B_200F_200D_202E_200D_206F_200B_206C_202B_202D_200E_200F_200E_202A_200F_206A_206B_202E(Stream P_0)
	{
		return new BinaryReader(P_0);
	}

	static long _202D_202E_202C_202E_206F_206C_200F_200E_200F_206D_206B_206D_206E_200C_202D_206F_202E_200E_206F_200D_202D_206F_202B_200F_202B_206B_206C_200C_202A_200E_200B_200F_206A_202C_200B_202C_200D_200C_202A_206A_202E(FileStream P_0)
	{
		return P_0.Length;
	}

	static byte[] _202D_202D_206B_202D_206E_200C_206F_200E_202B_206A_206A_206B_200B_202A_200D_206E_200E_202B_200D_206D_206B_206A_200D_206F_206F_202C_200E_206D_202C_206D_202C_202E_200C_202A_206C_202A_200D_206C_206E_202E_202E(BinaryReader P_0, int P_1)
	{
		return P_0.ReadBytes(P_1);
	}

	static void _202B_202D_200E_206C_202B_200E_202D_206F_200E_202B_202E_200E_206D_206D_202E_206C_200F_206B_206B_202E_206F_200C_206F_202D_202A_200C_202B_206F_206B_206A_200C_206F_202E_202E_200D_206A_200D_206B_202C_202E(Stream P_0)
	{
		P_0.Close();
	}

	static void _206E_202C_206E_200F_200F_206A_200D_200C_200F_200D_206D_206A_206C_200D_200D_202D_202B_202C_202D_206F_200E_206A_202D_206D_200E_202C_200F_200D_200B_200F_206B_206C_202E_206E_202E_200F_200B_200C_202E_202C_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}

	static bool _206B_200E_200F_206C_206D_202B_202D_202B_206B_202B_206A_200F_200D_202A_200C_206D_200E_206F_200D_202B_202B_200C_200E_202C_202D_202D_200D_200B_202D_200C_206C_206C_206F_206E_206D_200C_202C_200B_200F_206F_202E(string P_0, string P_1)
	{
		return P_0.Contains(P_1);
	}

	static string[] _202D_202D_200C_206E_206A_206B_200B_206A_200F_206D_206A_200E_200C_200C_206D_206F_206F_200B_202B_206E_202A_200E_206A_200D_202D_202A_202A_206E_202E_206D_206E_206D_200E_206A_202E_202B_206A_202A_206D_206A_202E(string P_0, char[] P_1)
	{
		return P_0.Split(P_1);
	}

	static void _200D_206B_206A_206F_206B_200B_206B_200D_202E_200B_202C_200D_206F_206D_202A_202B_202D_200C_200F_202E_206C_200C_206C_200B_206B_202E_200B_200E_206D_206C_206B_202A_206C_202E_200D_206E_206E_202D_206E_202B_202E(Array P_0, int P_1, Array P_2, int P_3, int P_4)
	{
		Array.Copy(P_0, P_1, P_2, P_3, P_4);
	}

	static ListDictionary _200E_206B_200C_206E_202E_206E_200F_200B_200C_206B_202D_202D_202B_200D_200D_206D_206C_202B_206A_206A_206E_200F_202D_202A_200F_206C_206D_200B_200F_206B_202B_206E_202A_202E_202E_200F_200D_206E_200B_200C_202E()
	{
		return new ListDictionary();
	}

	static void _202B_200E_200E_200D_206A_206F_202D_200F_200E_206F_202D_206E_206B_206E_200C_200F_200B_206B_206C_202D_206C_200C_206E_206E_202E_202E_206E_202E_200C_202E_200F_202D_202A_206D_206F_200F_206D_206C_206A_200F_202E(ListDictionary P_0, object P_1, object P_2)
	{
		P_0[P_1] = P_2;
	}

	static Type _202D_202A_202E_206D_200B_206E_206C_200E_202C_202E_202D_200E_206F_202E_200D_206F_206B_206C_206E_206A_206A_202C_200C_202D_202E_202A_202B_202D_206E_200D_200C_206F_206D_206B_202E_200F_200E_202A_200B_206B_202E(MemberInfo P_0)
	{
		return P_0.DeclaringType;
	}

	static void _202E_206D_206C_206A_206F_202B_202C_200B_202E_206C_200E_206D_206E_200F_206D_202D_200D_200D_200E_200D_206F_200E_200C_202B_202A_200C_206A_206F_200E_200E_202A_202B_206C_206F_200D_206B_202C_206B_206F_202D_202E(object P_0)
	{
		GC.SuppressFinalize(P_0);
	}

	static void _200C_200E_206E_206C_206F_202E_202E_202C_200B_202D_200C_200D_202D_202C_206F_202D_206B_200E_202C_206B_202B_206F_202A_202D_206F_200E_202D_206E_202C_202B_202C_200D_200D_200E_206D_206C_206B_206D_200E_200F_202E(int P_0, GCCollectionMode P_1)
	{
		GC.Collect(P_0, P_1);
	}
}
