using System;

namespace LuaInterface;

internal class ClassGenerator
{
	private ObjectTranslator translator;

	private Type klass;

	public ClassGenerator(ObjectTranslator P_0, Type P_1)
	{
		while (true)
		{
			int num = 1230129162;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x635C0248)) % 3)
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
				translator = P_0;
				klass = P_1;
				num = ((int)num2 * -1043896291) ^ 0x2B1A7C52;
			}
		}
	}

	public object extractGenerated(IntPtr luaState, int stackPos)
	{
		return CodeGeneration.Instance.GetClassInstance(klass, translator.getTable(luaState, stackPos));
	}
}
