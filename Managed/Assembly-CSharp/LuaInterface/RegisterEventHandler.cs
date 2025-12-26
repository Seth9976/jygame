using System;
using System.Reflection;

namespace LuaInterface;

internal class RegisterEventHandler
{
	private object target;

	private EventInfo eventInfo;

	private EventHandlerContainer pendingEvents;

	public RegisterEventHandler(EventHandlerContainer P_0, object P_1, EventInfo P_2)
	{
		target = P_1;
		eventInfo = P_2;
		pendingEvents = P_0;
	}

	public Delegate Add(LuaFunction function)
	{
		Delegate obj = CodeGeneration.Instance.GetDelegate(_202A_200C_200F_200D_206D_202A_206B_200B_206B_200E_200F_202C_206E_206A_200E_200F_200E_206A_202D_206A_202D_202C_202C_200D_200B_200B_206D_200E_200C_200E_206B_200C_202C_206F_202D_206A_202B_206B_206E_206E_202E(eventInfo), function);
		_200E_206C_202D_200E_202D_202A_202B_206A_200F_206C_202E_206A_206F_200F_206C_200B_200C_202A_206F_206D_200D_200E_206E_202D_200C_206B_206C_206D_206D_200B_200C_200E_206C_202D_202A_200C_206D_206E_206D_200E_202E(eventInfo, target, obj);
		while (true)
		{
			int num = -1918829949;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1558794529)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_004b;
				default:
					return obj;
				}
				break;
				IL_004b:
				pendingEvents.Add(obj, this);
				num = (int)((num2 * 439849112) ^ 0x718687C2);
			}
		}
	}

	public void Remove(Delegate handlerDelegate)
	{
		RemovePending(handlerDelegate);
		while (true)
		{
			int num = -1197258703;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1108509639)) % 3)
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
				pendingEvents.Remove(handlerDelegate);
				num = (int)(num2 * 990623393) ^ -1863674110;
			}
		}
	}

	internal void RemovePending(Delegate handlerDelegate)
	{
		_202E_202E_200D_200B_206D_202C_206E_206A_206C_206C_200E_206D_202C_202D_202A_202E_202E_200F_202E_202C_206D_200D_206F_200F_206A_202E_200D_202A_206B_200C_202E_202E_206B_206F_200E_202E_202C_206D_202D_206A_202E(eventInfo, target, handlerDelegate);
	}

	static Type _202A_200C_200F_200D_206D_202A_206B_200B_206B_200E_200F_202C_206E_206A_200E_200F_200E_206A_202D_206A_202D_202C_202C_200D_200B_200B_206D_200E_200C_200E_206B_200C_202C_206F_202D_206A_202B_206B_206E_206E_202E(EventInfo P_0)
	{
		return P_0.EventHandlerType;
	}

	static void _200E_206C_202D_200E_202D_202A_202B_206A_200F_206C_202E_206A_206F_200F_206C_200B_200C_202A_206F_206D_200D_200E_206E_202D_200C_206B_206C_206D_206D_200B_200C_200E_206C_202D_202A_200C_206D_206E_206D_200E_202E(EventInfo P_0, object P_1, Delegate P_2)
	{
		P_0.AddEventHandler(P_1, P_2);
	}

	static void _202E_202E_200D_200B_206D_202C_206E_206A_206C_206C_200E_206D_202C_202D_202A_202E_202E_200F_202E_202C_206D_200D_206F_200F_206A_202E_200D_202A_206B_200C_202E_202E_206B_206F_200E_202E_202C_206D_202D_206A_202E(EventInfo P_0, object P_1, Delegate P_2)
	{
		P_0.RemoveEventHandler(P_1, P_2);
	}
}
