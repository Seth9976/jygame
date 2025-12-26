using System;
using System.Runtime.Serialization;

namespace LuaInterface;

[Serializable]
public class LuaException : Exception
{
	public LuaException()
	{
	}

	public LuaException(string P_0)
		: base(P_0)
	{
	}

	public LuaException(string P_0, Exception P_1)
		: base(P_0, P_1)
	{
	}

	protected LuaException(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
