using System;

namespace LuaInterface;

internal class DelegateGenerator
{
	private ObjectTranslator translator;

	private Type delegateType;

	public DelegateGenerator(ObjectTranslator P_0, Type P_1)
	{
		translator = P_0;
		delegateType = P_1;
	}

	public object extractGenerated(IntPtr luaState, int stackPos)
	{
		return CodeGeneration.Instance.GetDelegate(delegateType, translator.getFunction(luaState, stackPos));
	}
}
