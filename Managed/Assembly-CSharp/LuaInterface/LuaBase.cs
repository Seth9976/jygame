using System;

namespace LuaInterface;

public abstract class LuaBase : IDisposable
{
	private bool _200B_200C_206C_206B_206E_206B_200B_206A_200D_206E_202D_202C_206E_202C_202E_200E_200C_206F_202E_200D_200E_206F_200B_202D_200B_206D_206B_206C_202E_200C_200D_200B_200D_200D_202D_200F_200D_202C_206C_200F_202E;

	protected int _Reference;

	protected LuaState _Interpreter;

	protected ObjectTranslator translator;

	public string name;

	private int count;

	public LuaBase()
	{
		while (true)
		{
			int num = 701076175;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x68314863)) % 3)
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
				count = 1;
				num = ((int)num2 * -569059280) ^ -2117527042;
			}
		}
	}

	~LuaBase()
	{
		Dispose(disposeManagedResources: false);
	}

	public void Dispose()
	{
		Dispose(disposeManagedResources: true);
		_200F_206B_202E_202B_202D_206F_200F_200D_202B_206E_206F_202E_202D_206D_200E_206A_206A_202B_202E_206E_206E_206D_202E_200B_200E_202D_202B_202E_202D_200E_206B_200E_206D_200F_202A_202D_200C_200E_206D_206C_202E((object)this);
	}

	public void AddRef()
	{
		count++;
	}

	public void Release()
	{
		if (!_200B_200C_206C_206B_206E_206B_200B_206A_200D_206E_202D_202C_206E_202C_202E_200E_200C_206F_202E_200D_200E_206F_200B_202D_200B_206D_206B_206C_202E_200C_200D_200B_200D_200D_202D_200F_200D_202C_206C_200F_202E)
		{
			goto IL_0008;
		}
		goto IL_0062;
		IL_0008:
		int num = 566421037;
		goto IL_000d;
		IL_000d:
		LuaScriptMgr mgrFromLuaState = default(LuaScriptMgr);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x3CF5AB7)) % 12)
			{
			case 4u:
				break;
			default:
				return;
			case 9u:
				return;
			case 10u:
				goto IL_0062;
			case 6u:
			{
				mgrFromLuaState = LuaScriptMgr.GetMgrFromLuaState(_Interpreter.L);
				int num5;
				int num6;
				if (mgrFromLuaState == null)
				{
					num5 = 1390396460;
					num6 = num5;
				}
				else
				{
					num5 = 230175614;
					num6 = num5;
				}
				num = num5 ^ ((int)num2 * -829954963);
				continue;
			}
			case 3u:
				count--;
				num = 1949498938;
				continue;
			case 5u:
			{
				int num7;
				int num8;
				if (count <= 0)
				{
					num7 = 1370120305;
					num8 = num7;
				}
				else
				{
					num7 = 1962222480;
					num8 = num7;
				}
				num = num7 ^ (int)(num2 * 392446918);
				continue;
			}
			case 2u:
			{
				int num3;
				int num4;
				if (name == null)
				{
					num3 = 1283129655;
					num4 = num3;
				}
				else
				{
					num3 = 1664721726;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -622000233);
				continue;
			}
			case 11u:
				return;
			case 8u:
				goto IL_0113;
			case 1u:
				Dispose();
				num = 1372426367;
				continue;
			case 7u:
				mgrFromLuaState.RemoveLuaRes(name);
				num = ((int)num2 * -490407584) ^ 0x1D669A86;
				continue;
			case 0u:
				return;
			}
			break;
			IL_0113:
			int num9;
			if (name != null)
			{
				num = 1091571909;
				num9 = num;
			}
			else
			{
				num = 128056998;
				num9 = num;
			}
		}
		goto IL_0008;
		IL_0062:
		Dispose();
		num = 1115749680;
		goto IL_000d;
	}

	public virtual void Dispose(bool disposeManagedResources)
	{
		if (_200B_200C_206C_206B_206E_206B_200B_206A_200D_206E_202D_202C_206E_202C_202E_200E_200C_206F_202E_200D_200E_206F_200B_202D_200B_206D_206B_206C_202E_200C_200D_200B_200D_200D_202D_200F_200D_202C_206C_200F_202E)
		{
			return;
		}
		while (true)
		{
			int num = -239761157;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1113735131)) % 11)
				{
				case 6u:
					break;
				default:
					return;
				case 1u:
				{
					int num5;
					int num6;
					if (_Reference == 0)
					{
						num5 = 1278414599;
						num6 = num5;
					}
					else
					{
						num5 = 1147450934;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1620224573);
					continue;
				}
				case 9u:
				{
					int num7;
					if (!(_Interpreter.L != IntPtr.Zero))
					{
						num = -122959903;
						num7 = num;
					}
					else
					{
						num = -774728540;
						num7 = num;
					}
					continue;
				}
				case 4u:
					LuaScriptMgr.refGCList.Enqueue(new LuaRef(_Interpreter.L, _Reference));
					num = (int)((num2 * 1252886583) ^ 0x75BFEA7D);
					continue;
				case 8u:
				{
					int num8;
					int num9;
					if (!disposeManagedResources)
					{
						num8 = 298708964;
						num9 = num8;
					}
					else
					{
						num8 = 1651604088;
						num9 = num8;
					}
					num = num8 ^ (int)(num2 * 1881377374);
					continue;
				}
				case 7u:
					_Interpreter.dispose(_Reference);
					num = (int)(num2 * 371784747) ^ -1375967988;
					continue;
				case 10u:
					_Reference = 0;
					num = ((int)num2 * -1141893355) ^ -1550667142;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (_Interpreter != null)
					{
						num3 = 940493836;
						num4 = num3;
					}
					else
					{
						num3 = 278457006;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 796330163);
					continue;
				}
				case 2u:
					_Reference = 0;
					num = ((int)num2 * -991506644) ^ -2062839975;
					continue;
				case 3u:
					_Interpreter = null;
					_200B_200C_206C_206B_206E_206B_200B_206A_200D_206E_202D_202C_206E_202C_202E_200E_200C_206F_202E_200D_200E_206F_200B_202D_200B_206D_206B_206C_202E_200C_200D_200B_200D_200D_202D_200F_200D_202C_206C_200F_202E = true;
					num = -227298432;
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	protected void PushArgs(IntPtr L, object o)
	{
		LuaScriptMgr.PushVarObject(L, o);
	}

	public override bool Equals(object o)
	{
		if (o is LuaBase)
		{
			while (true)
			{
				uint num;
				switch ((num = 1483959485u) % 3)
				{
				case 0u:
					continue;
				case 2u:
				{
					LuaBase luaBase = (LuaBase)o;
					return _Interpreter.compareRef(luaBase._Reference, _Reference);
				}
				}
				break;
			}
		}
		return false;
	}

	public override int GetHashCode()
	{
		return _Reference;
	}

	static void _200F_206B_202E_202B_202D_206F_200F_200D_202B_206E_206F_202E_202D_206D_200E_206A_206A_202B_202E_206E_206E_206D_202E_200B_200E_202D_202B_202E_202D_200E_206B_200E_206D_200F_202A_202D_200C_200E_206D_206C_202E(object P_0)
	{
		GC.SuppressFinalize(P_0);
	}
}
