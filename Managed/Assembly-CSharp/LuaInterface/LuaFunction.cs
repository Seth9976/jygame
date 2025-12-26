using System;

namespace LuaInterface;

public class LuaFunction : LuaBase
{
	internal LuaCSFunction function;

	private IntPtr L;

	private int beginPos = -1;

	public LuaFunction(int P_0, LuaState P_1)
	{
		_Reference = P_0;
		function = null;
		_Interpreter = P_1;
		L = _Interpreter.L;
		translator = _Interpreter.translator;
	}

	public LuaFunction(LuaCSFunction P_0, LuaState P_1)
	{
		while (true)
		{
			int num = 1224204377;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x590C06A0)) % 5)
				{
				case 3u:
					break;
				case 2u:
					_Reference = 0;
					num = ((int)num2 * -1375606555) ^ -391389284;
					continue;
				case 4u:
					_Interpreter = P_1;
					L = _Interpreter.L;
					num = ((int)num2 * -474110936) ^ 0x2821B279;
					continue;
				case 1u:
					function = P_0;
					num = ((int)num2 * -696304344) ^ 0x3275C53A;
					continue;
				default:
					translator = _Interpreter.translator;
					return;
				}
				break;
			}
		}
	}

	public LuaFunction(int P_0, IntPtr P_1)
	{
		_Reference = P_0;
		function = null;
		L = P_1;
		translator = ObjectTranslator.FromState(L);
		_Interpreter = translator.interpreter;
	}

	internal object[] call(object[] args, Type[] returnTypes)
	{
		int num = 0;
		LuaScriptMgr.PushTraceBack(L);
		string text = default(string);
		int num4 = default(int);
		int num7 = default(int);
		int num10 = default(int);
		object[] result = default(object[]);
		while (true)
		{
			int num2 = 443174992;
			while (true)
			{
				uint num3;
				object[] array;
				switch ((num3 = (uint)(num2 ^ 0x7F75A1A1)) % 21)
				{
				case 0u:
					break;
				case 11u:
					text = LuaDLL.lua_tostring(L, -1);
					LuaDLL.lua_settop(L, num4 - 1);
					num2 = ((int)num3 * -844116014) ^ -1732249454;
					continue;
				case 9u:
					num7 = LuaDLL.lua_pcall(L, num, -1, -num - 2);
					num2 = 2094768632;
					continue;
				case 20u:
				{
					int num8;
					int num9;
					if (num7 != 0)
					{
						num8 = 1747234849;
						num9 = num8;
					}
					else
					{
						num8 = 11395706;
						num9 = num8;
					}
					num2 = num8 ^ (int)(num3 * 429559366);
					continue;
				}
				case 17u:
					num4 = LuaDLL.lua_gettop(L);
					num2 = (int)((num3 * 1885648140) ^ 0x46058735);
					continue;
				case 14u:
					PushArgs(L, args[num10]);
					num2 = 15259707;
					continue;
				case 4u:
					LuaDLL.lua_settop(L, num4 - 1);
					num2 = (int)(num3 * 94286070) ^ -429185754;
					continue;
				case 16u:
					if (returnTypes != null)
					{
						num2 = 555364654;
						continue;
					}
					array = translator.popValues(L, num4);
					goto IL_02a8;
				case 15u:
				{
					int num14;
					int num15;
					if (text == null)
					{
						num14 = -2009613048;
						num15 = num14;
					}
					else
					{
						num14 = -1058584934;
						num15 = num14;
					}
					num2 = num14 ^ ((int)num3 * -792204779);
					continue;
				}
				case 12u:
					num10 = 0;
					num2 = ((int)num3 * -1592665257) ^ 0x63B3CF28;
					continue;
				case 18u:
					LuaDLL.lua_pop(L, 1);
					throw new LuaException(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1481546488u));
				case 5u:
					text = global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3460635624u);
					num2 = ((int)num3 * -1142696605) ^ 0x7F5082F7;
					continue;
				case 1u:
					num10++;
					num2 = (int)(num3 * 440354047) ^ -1214309651;
					continue;
				case 13u:
				{
					int num12;
					int num13;
					if (args == null)
					{
						num12 = 1734726354;
						num13 = num12;
					}
					else
					{
						num12 = 2132639942;
						num13 = num12;
					}
					num2 = num12 ^ (int)(num3 * 644444621);
					continue;
				}
				case 2u:
					push(L);
					num2 = 1227201505;
					continue;
				case 3u:
				{
					int num11;
					if (num10 >= args.Length)
					{
						num2 = 726742930;
						num11 = num2;
					}
					else
					{
						num2 = 1661022634;
						num11 = num2;
					}
					continue;
				}
				case 8u:
					throw new LuaScriptException(text, string.Empty);
				case 7u:
				{
					int num5;
					int num6;
					if (!LuaDLL.lua_checkstack(L, args.Length + 6))
					{
						num5 = 1945212840;
						num6 = num5;
					}
					else
					{
						num5 = 1781741764;
						num6 = num5;
					}
					num2 = num5 ^ (int)(num3 * 616093754);
					continue;
				}
				case 6u:
					array = translator.popValues(L, num4, returnTypes);
					goto IL_02a8;
				case 19u:
					num = args.Length;
					num2 = ((int)num3 * -592791552) ^ 0x337A4534;
					continue;
				default:
					{
						return result;
					}
					IL_02a8:
					result = array;
					num2 = 1446507782;
					continue;
				}
				break;
			}
		}
	}

	public object[] Call(params object[] args)
	{
		return call(args, null);
	}

	public object[] Call()
	{
		int num = BeginPCall();
		while (true)
		{
			int num2 = 1009353728;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x15F0B55C)) % 5)
				{
				case 0u:
					break;
				case 4u:
				{
					int num4;
					int num5;
					if (PCall(num, 0))
					{
						num4 = 1062232623;
						num5 = num4;
					}
					else
					{
						num4 = 1075241182;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 1208324617);
					continue;
				}
				case 1u:
				{
					object[] result = PopValues(num);
					EndPCall(num);
					return result;
				}
				case 2u:
					LuaDLL.lua_settop(L, num - 1);
					num2 = 2035012295;
					continue;
				default:
					return null;
				}
				break;
			}
		}
	}

	public object[] Call(double arg1)
	{
		int num = BeginPCall();
		LuaScriptMgr.Push(L, arg1);
		object[] result = default(object[]);
		while (true)
		{
			int num2 = 484977839;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x2CC8D7FA)) % 5)
				{
				case 0u:
					break;
				case 3u:
					EndPCall(num);
					return result;
				case 2u:
					result = PopValues(num);
					num2 = (int)(num3 * 626470074) ^ -366282912;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (!PCall(num, 1))
					{
						num4 = -300888059;
						num5 = num4;
					}
					else
					{
						num4 = -729234690;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num3 * -1319625009);
					continue;
				}
				default:
					LuaDLL.lua_settop(L, num - 1);
					return null;
				}
				break;
			}
		}
	}

	public int BeginPCall()
	{
		LuaScriptMgr.PushTraceBack(L);
		beginPos = LuaDLL.lua_gettop(L);
		while (true)
		{
			int num = 378410582;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3137D0F)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_003e;
				default:
					return beginPos;
				}
				break;
				IL_003e:
				push(L);
				num = ((int)num2 * -228810833) ^ 0x56DAB741;
			}
		}
	}

	public bool PCall(int oldTop, int args)
	{
		if (LuaDLL.lua_pcall(L, args, -1, -args - 2) != 0)
		{
			string text = default(string);
			while (true)
			{
				int num = 1886377287;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x452D07CE)) % 5)
					{
					case 3u:
						break;
					case 1u:
					{
						text = LuaDLL.lua_tostring(L, -1);
						LuaDLL.lua_settop(L, oldTop - 1);
						int num3;
						int num4;
						if (text != null)
						{
							num3 = -1253904876;
							num4 = num3;
						}
						else
						{
							num3 = -1919201367;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -993719937);
						continue;
					}
					case 2u:
						throw new LuaScriptException(text, string.Empty);
					case 0u:
						text = global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1028720572u);
						num = ((int)num2 * -1348144992) ^ 0x341536E3;
						continue;
					default:
						goto end_IL_0016;
					}
					break;
				}
				continue;
				end_IL_0016:
				break;
			}
		}
		return true;
	}

	public object[] PopValues(int oldTop)
	{
		return translator.popValues(L, oldTop);
	}

	public void EndPCall(int oldTop)
	{
		LuaDLL.lua_settop(L, oldTop - 1);
	}

	public IntPtr GetLuaState()
	{
		return L;
	}

	internal void push(IntPtr luaState)
	{
		if (_Reference != 0)
		{
			goto IL_0008;
		}
		goto IL_0032;
		IL_0008:
		int num = -650017977;
		goto IL_000d;
		IL_000d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -166288590)) % 5)
			{
			case 0u:
				break;
			default:
				return;
			case 4u:
				goto IL_0032;
			case 2u:
				num = ((int)num2 * -526966712) ^ 0x601D5B40;
				continue;
			case 3u:
				LuaDLL.lua_getref(luaState, _Reference);
				num = (int)(num2 * 1137921964) ^ -175304208;
				continue;
			case 1u:
				return;
			}
			break;
		}
		goto IL_0008;
		IL_0032:
		_Interpreter.pushCSFunction(function);
		num = -453891792;
		goto IL_000d;
	}

	internal void push()
	{
		if (_Reference != 0)
		{
			goto IL_0008;
		}
		goto IL_004e;
		IL_0008:
		int num = 870784136;
		goto IL_000d;
		IL_000d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x1CE44E9D)) % 4)
			{
			case 3u:
				break;
			default:
				return;
			case 1u:
				LuaDLL.lua_getref(L, _Reference);
				num = ((int)num2 * -1118903181) ^ -398513728;
				continue;
			case 0u:
				goto IL_004e;
			case 2u:
				return;
			}
			break;
		}
		goto IL_0008;
		IL_004e:
		_Interpreter.pushCSFunction(function);
		num = 2126625455;
		goto IL_000d;
	}

	public override string ToString()
	{
		return global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4225882099u);
	}

	public override bool Equals(object o)
	{
		if (o is LuaFunction)
		{
			LuaFunction luaFunction = default(LuaFunction);
			while (true)
			{
				int num = 1141106249;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x260F24A6)) % 7)
					{
					case 0u:
						break;
					case 3u:
						luaFunction = (LuaFunction)o;
						num = ((int)num2 * -1889732228) ^ 0x60DF0922;
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (luaFunction._Reference != 0)
						{
							num5 = 621048277;
							num6 = num5;
						}
						else
						{
							num5 = 664551393;
							num6 = num5;
						}
						num = num5 ^ ((int)num2 * -1479774714);
						continue;
					}
					case 2u:
						return function == luaFunction.function;
					case 4u:
						return _Interpreter.compareRef(luaFunction._Reference, _Reference);
					case 5u:
					{
						int num3;
						int num4;
						if (_Reference != 0)
						{
							num3 = 996109170;
							num4 = num3;
						}
						else
						{
							num3 = 1438195225;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -1225038828);
						continue;
					}
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
		return false;
	}

	public override int GetHashCode()
	{
		if (_Reference != 0)
		{
			while (true)
			{
				uint num;
				switch ((num = 2005608823u) % 3)
				{
				case 0u:
					continue;
				case 1u:
					return _Reference;
				}
				break;
			}
		}
		return function.GetHashCode();
	}

	public int GetReference()
	{
		return _Reference;
	}
}
