using System;

namespace LuaInterface;

public class MonoPInvokeCallbackAttribute : Attribute
{
	private Type type;

	public MonoPInvokeCallbackAttribute(Type P_0)
	{
		type = P_0;
	}
}
