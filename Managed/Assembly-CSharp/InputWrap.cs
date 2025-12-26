using System;
using LuaInterface;
using UnityEngine;

public class InputWrap
{
	private static Type classType = _200F_202B_202B_200E_206E_202D_206E_200F_202A_202E_200E_200B_206A_206C_202E_202D_206C_206D_200D_202B_206F_206D_202A_206A_206D_202D_202C_206C_200F_200E_206E_206D_206C_206E_202A_206D_200F_200E_206F_206F_202E(typeof(Input).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[17]
		{
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(841196288u), GetAxis),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(942418747u), GetAxisRaw),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3229117185u), GetButton),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2352212850u), GetButtonDown),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3477712356u), GetButtonUp),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1814662268u), GetKey),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2618096724u), GetKeyDown),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3985124578u), GetKeyUp),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1026302953u), GetJoystickNames),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3057369258u), GetMouseButton),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2035253259u), GetMouseButtonDown),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1647195449u), GetMouseButtonUp),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2246741707u), ResetInputAxes),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2561461373u), GetAccelerationEvent),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2949009318u), GetTouch),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2254933974u), _200B_200D_200C_200B_200B_202D_202C_206D_200D_200F_206B_206B_200E_206A_200C_206F_206A_206E_200B_206F_202C_206C_206E_206A_206F_206E_206F_202D_206C_206F_200D_206E_206A_206C_206E_202C_206B_206C_200F_206F_202E),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(10103728u), GetClassType)
		};
		LuaField[] fields = default(LuaField[]);
		while (true)
		{
			int num = 773004795;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x600C62A)) % 4)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					fields = new LuaField[25]
					{
						new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(996003923u), get_compensateSensors, set_compensateSensors),
						new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(114026049u), get_gyro, null),
						new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2752198565u), get_mousePosition, null),
						new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(749708182u), get_mouseScrollDelta, null),
						new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3010738539u), get_mousePresent, null),
						new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2383813990u), get_simulateMouseWithTouches, set_simulateMouseWithTouches),
						new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1262687942u), get_anyKey, null),
						new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(12612284u), get_anyKeyDown, null),
						new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(835074126u), get_inputString, null),
						new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3082318048u), get_acceleration, null),
						new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1325725942u), get_accelerationEvents, null),
						new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(239025242u), get_accelerationEventCount, null),
						new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4261031839u), get_touches, null),
						new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(344422310u), get_touchCount, null),
						new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2175880083u), get_touchPressureSupported, null),
						new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3994968121u), get_stylusTouchSupported, null),
						new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3561153113u), get_touchSupported, null),
						new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2614568912u), get_multiTouchEnabled, set_multiTouchEnabled),
						new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4272822864u), get_location, null),
						new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1047606468u), get_compass, null),
						new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3655790670u), get_deviceOrientation, null),
						new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3731261656u), get_imeCompositionMode, set_imeCompositionMode),
						new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(365913378u), get_compositionString, null),
						new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3882203628u), get_imeIsSelected, null),
						new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3034402299u), get_compositionCursorPos, set_compositionCursorPos)
					};
					num = ((int)num2 * -1105708548) ^ -1323351411;
					continue;
				case 3u:
					LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2277686765u), _200F_202B_202B_200E_206E_202D_206E_200F_202A_202E_200E_200B_206A_206C_202E_202D_206C_206D_200D_202B_206F_206D_202A_206A_206D_202D_202C_206C_200F_200E_206E_206D_206C_206E_202A_206D_200F_200E_206F_206F_202E(typeof(Input).TypeHandle), regs, fields, _200F_202B_202B_200E_206E_202D_206E_200F_202A_202E_200E_200B_206A_206C_202E_202D_206C_206D_200D_202B_206F_206D_202A_206A_206D_202D_202C_206C_200F_200E_206E_206D_206C_206E_202A_206D_200F_200E_206F_206F_202E(typeof(object).TypeHandle));
					num = (int)(num2 * 1283364342) ^ -1585495130;
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _200B_200D_200C_200B_200B_202D_202C_206D_200D_200F_206B_206B_200E_206A_200C_206F_206A_206E_200B_206F_202C_206C_206E_206A_206F_206E_206F_202D_206C_206F_200D_206E_206A_206C_206E_202C_206B_206C_200F_206F_202E(IntPtr P_0)
	{
		int num = LuaDLL.lua_gettop(P_0);
		Input o = default(Input);
		while (true)
		{
			int num2 = 1745383330;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x6758D30A)) % 6)
				{
				case 0u:
					break;
				case 3u:
					LuaDLL.luaL_error(P_0, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2525380914u));
					num2 = 958714200;
					continue;
				case 5u:
					o = _200B_206D_206F_206E_206A_202C_200C_206B_202D_202D_202E_200F_200B_200B_200F_202C_202E_202A_202E_202B_200B_206E_206B_202A_200E_202A_206D_200F_206A_202C_202E_206A_202D_202D_200C_202E_200E_206D_200D_202E_202E();
					num2 = (int)(num3 * 2009294895) ^ -50722568;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (num == 0)
					{
						num4 = 587319567;
						num5 = num4;
					}
					else
					{
						num4 = 592170129;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num3 * -916143822);
					continue;
				}
				case 1u:
					LuaScriptMgr.PushObject(P_0, o);
					return 1;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_compensateSensors(IntPtr L)
	{
		LuaScriptMgr.Push(L, _206F_200F_200B_202C_200B_202A_200F_200D_206F_202B_202A_206E_202B_206B_202C_200B_206D_206B_200B_200E_202A_200E_200E_200E_200E_202A_206B_200D_202C_200B_202C_200D_202D_202C_202B_202E_200C_206D_200C_206A_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_gyro(IntPtr L)
	{
		LuaScriptMgr.PushObject(L, _200F_206B_202D_200C_206F_202E_200C_206F_206C_200F_202A_202C_200C_200E_202D_200E_200E_206A_206C_202D_202C_202A_202A_206F_206E_202A_200B_200B_206F_202B_202E_206B_206B_200B_206C_200D_200E_202E_206D_202A_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_mousePosition(IntPtr L)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr.Push(L, _206D_202C_200F_200C_202A_200E_200C_206B_200B_206D_200F_206D_202C_206E_206D_200E_200B_206F_202C_202E_202A_206D_200C_206F_200F_202B_202C_200E_206D_206B_200E_200B_200E_206F_200D_202A_202A_200E_202C_200F_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_mouseScrollDelta(IntPtr L)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr.Push(L, _202C_200C_206D_202E_202C_206D_206A_202A_200D_202C_202E_202A_206E_206B_206C_200E_202C_206F_200D_200E_206B_200C_202A_202C_200E_206B_202C_202D_206F_206F_206D_202E_200B_202A_206F_202C_200D_200C_202A_206C_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_mousePresent(IntPtr L)
	{
		LuaScriptMgr.Push(L, _200C_206B_200C_202E_202C_202E_206F_206E_200B_202A_206F_200F_206A_200E_200E_202E_202A_200B_202E_206E_206B_202A_206F_200D_202B_200F_202E_206E_200E_200E_202D_206D_202A_206C_202A_202E_202C_206E_206B_206E_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_simulateMouseWithTouches(IntPtr L)
	{
		LuaScriptMgr.Push(L, _202A_200E_206B_200D_202D_200D_206C_206C_202D_206D_200C_206A_206D_202D_200B_206E_206A_202A_200C_200D_202A_200B_202D_206A_206E_200F_200F_206A_206B_206A_206D_206F_206B_206A_200E_200E_206C_200D_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_anyKey(IntPtr L)
	{
		LuaScriptMgr.Push(L, _206C_206B_200F_206C_206F_206F_202B_206A_206E_202A_206F_206D_202E_206F_206F_200E_206E_202E_202A_206E_202A_202A_206E_206A_200B_206C_200E_202A_202E_206F_206E_202D_202B_206D_202D_206A_200B_202E_206A_200C_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_anyKeyDown(IntPtr L)
	{
		LuaScriptMgr.Push(L, _202B_202C_206E_200C_200F_206F_206E_206F_206A_200C_206F_202D_206F_202C_200B_200C_200E_202D_200E_200C_200D_202A_200F_206E_202A_202B_202D_202E_200F_206D_206D_202C_202B_202C_202C_206B_200F_206A_202A_202E_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_inputString(IntPtr L)
	{
		LuaScriptMgr.Push(L, _206C_202B_202C_202B_200F_200E_206B_200F_200C_206A_200F_202A_202C_202D_202E_202E_206D_202A_200F_200E_200C_200F_202A_200B_206F_206A_200D_200C_200D_200B_206C_202D_206D_202C_200B_202B_200B_206E_200E_206A_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_acceleration(IntPtr L)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr.Push(L, _202A_206B_206B_202D_202A_200E_206E_200D_202E_202E_200B_202D_200D_206A_202B_200B_202A_206B_206B_202E_200D_206B_202B_206F_202E_200C_200B_202C_206E_200E_206C_200E_202A_200E_200C_202E_202B_206C_202E_200D_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_accelerationEvents(IntPtr L)
	{
		LuaScriptMgr.PushArray(L, _200E_206C_200E_206F_206A_200B_206C_202C_200F_200E_200C_206A_206A_202A_206C_202A_200B_202B_206E_200D_202B_206C_206E_202B_200C_200E_202A_200B_202A_200D_202D_206C_202D_206D_200E_202A_206B_200E_202E_206E_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_accelerationEventCount(IntPtr L)
	{
		LuaScriptMgr.Push(L, _200C_202C_200D_206B_202C_202C_200F_202A_202E_200D_202D_206A_206D_206E_200D_206C_202D_200D_200E_206C_202D_202C_202A_202C_200F_202B_202A_202A_202E_202A_202A_200D_200C_206D_206D_206A_202E_202E_202D_202C_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_touches(IntPtr L)
	{
		LuaScriptMgr.PushArray(L, _202E_200C_202A_202B_200D_206C_206B_200F_206F_206D_200E_206E_200C_200B_202E_200B_202D_202B_202A_200C_200B_200F_206B_206C_202C_206F_200E_200F_202A_200D_206D_202D_202B_200C_202A_202D_206F_206F_206F_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_touchCount(IntPtr L)
	{
		LuaScriptMgr.Push(L, _206D_206D_206A_206F_206C_202A_206C_206C_206B_200C_206C_200B_202D_200C_200D_206A_200E_206C_200B_206C_200B_206C_200B_200D_202B_202D_206E_206E_200F_206C_206C_206D_202E_206E_206C_200E_200B_206E_200D_202D_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_touchPressureSupported(IntPtr L)
	{
		LuaScriptMgr.Push(L, _206C_206D_200C_202C_206F_200C_206B_200F_200C_206B_202C_202E_202A_200D_206C_200E_200F_200B_202E_202C_202E_202D_206C_206D_200B_206B_202E_202E_206B_200B_206F_206A_200D_206C_200D_206A_206C_206A_200C_206B_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_stylusTouchSupported(IntPtr L)
	{
		LuaScriptMgr.Push(L, _202B_206F_200F_206C_206A_206C_206F_206E_202B_202B_202C_206A_200D_206E_206D_202B_202E_206B_200B_200D_206F_206F_206A_202C_206F_202D_206D_200C_200F_206A_200E_206E_206D_202B_200D_206D_206C_200D_206C_202D_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_touchSupported(IntPtr L)
	{
		LuaScriptMgr.Push(L, _200C_202B_200F_202B_202D_200D_206B_206E_206B_206E_200D_206F_200F_200E_202D_200B_206F_200C_202D_202C_202C_200F_202C_206B_202B_202E_206E_200E_200D_206B_200D_206D_206D_202A_206B_206E_202A_200F_202A_200E_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_multiTouchEnabled(IntPtr L)
	{
		LuaScriptMgr.Push(L, _200D_200F_202A_200D_200C_200C_206D_202E_200E_200E_200F_202B_200B_200E_202C_206C_200E_206E_200F_202C_202E_202C_206F_206A_200B_202D_206A_202A_202A_206B_206D_202B_206C_200B_206F_202D_200C_200C_206C_206F_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_location(IntPtr L)
	{
		LuaScriptMgr.PushObject(L, _202C_206C_206D_202A_202B_206C_200E_206C_206D_202D_200B_206B_202B_202E_206B_200E_200B_202B_200F_200D_202B_206C_200F_200C_200F_206F_202D_202A_202E_200B_200B_200C_206C_202C_200B_206D_200F_200F_200E_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_compass(IntPtr L)
	{
		LuaScriptMgr.PushObject(L, _206D_202E_202D_206C_202B_200C_202E_200C_202D_206E_202D_202D_206D_200E_200E_202B_206A_202C_202E_200F_200B_202D_206F_206D_206E_200D_202C_202E_206A_202C_206D_200C_206A_202D_206F_206D_206F_206C_200D_206A_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_deviceOrientation(IntPtr L)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr.Push(L, (Enum)(object)_206F_206B_202E_200B_200E_202E_206F_206D_202C_202A_206D_206C_202E_206D_202B_206D_202C_200E_202D_202A_206A_200F_206B_202D_206D_202C_202B_202C_206B_202E_202A_206A_202B_206F_200C_200F_200F_206B_206C_200E_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_imeCompositionMode(IntPtr L)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr.Push(L, (Enum)(object)_202C_202B_206B_202C_206B_206A_206C_202B_202A_202E_202B_202C_200E_206A_202B_200D_200C_206C_202E_206F_206F_206D_202E_200F_200F_206B_206B_202C_202D_206E_200B_200E_206D_200D_200E_206C_202A_202D_202B_206E_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_compositionString(IntPtr L)
	{
		LuaScriptMgr.Push(L, _200C_202C_200B_200D_202C_202B_206E_202D_200B_200F_200B_206F_202C_202D_206E_202B_206D_202E_206B_200C_206B_202A_200F_200E_202B_206C_200F_206B_200C_206B_200D_200D_202A_200B_200C_206C_202B_206E_206B_202B_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_imeIsSelected(IntPtr L)
	{
		LuaScriptMgr.Push(L, _206B_200C_206F_206A_200E_206E_206E_206C_206B_200B_206A_202B_202E_200D_200C_202B_206D_202D_206E_206D_206F_200E_206A_200E_200C_202A_202C_206D_200F_206D_200E_202C_202A_206E_202E_200D_202C_206D_202C_200E_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_compositionCursorPos(IntPtr L)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr.Push(L, _202C_202B_206B_206F_200C_200D_202A_202D_202D_206B_200C_202A_200D_200B_202A_202D_202A_202A_200E_202C_200F_200E_206F_202B_202B_202B_206D_206B_202A_200E_202B_202A_206A_202E_200F_206A_206B_206E_200E_200E_202E());
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_compensateSensors(IntPtr L)
	{
		_206A_200B_202C_206E_200E_200D_202A_206A_202A_202B_206A_202E_206C_206F_200F_200F_202A_200E_202E_200C_206C_206A_202D_200F_202A_206D_200C_202E_202D_200C_206F_206E_200D_202B_202A_206D_202D_206F_206E_202C_202E(LuaScriptMgr.GetBoolean(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_simulateMouseWithTouches(IntPtr L)
	{
		_202D_206B_206C_206D_200E_206F_202E_206F_200D_202D_202C_202C_202D_200C_206E_202E_200B_200D_206A_202E_200F_202E_202A_206B_200E_200D_200E_206E_206E_200C_202A_206D_200F_206D_206F_206B_202A_206F_202D_206A_202E(LuaScriptMgr.GetBoolean(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_multiTouchEnabled(IntPtr L)
	{
		_202E_200E_200C_202C_202D_202D_202D_206C_200C_202E_200B_200C_200C_200C_202A_200C_206D_202A_206D_200B_206C_200E_206B_206B_200C_200C_202D_206E_200B_206E_200F_202C_206D_206F_200F_206A_202B_206A_200D_200F_202E(LuaScriptMgr.GetBoolean(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_imeCompositionMode(IntPtr L)
	{
		_206A_202D_200C_202B_206D_206F_202A_200B_202D_206C_206F_200B_200E_206C_202E_202E_202D_206D_206E_200B_200C_200E_200C_202A_202B_202A_202D_206F_200C_206F_202E_202C_206A_202C_206A_202B_202B_206E_202B_202A_202E((IMECompositionMode)(int)LuaScriptMgr.GetNetObject(L, 3, _200F_202B_202B_200E_206E_202D_206E_200F_202A_202E_200E_200B_206A_206C_202E_202D_206C_206D_200D_202B_206F_206D_202A_206A_206D_202D_202C_206C_200F_200E_206E_206D_206C_206E_202A_206D_200F_200E_206F_206F_202E(typeof(IMECompositionMode).TypeHandle)));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_compositionCursorPos(IntPtr L)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_200D_200B_206C_206B_202A_202B_200E_206F_200D_206B_202A_202C_206A_202E_206C_206F_202D_200F_202D_200D_200C_200F_200D_206F_200B_206C_206A_206F_202A_206D_202E_206E_202E_200D_206C_202A_200C_202C_202D_206D_202E(LuaScriptMgr.GetVector2(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetAxis(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string luaString = LuaScriptMgr.GetLuaString(L, 1);
		float d = _206B_206A_200D_200F_206B_206F_206F_206E_206A_202B_200D_202E_200E_200F_200B_200F_200E_200E_200D_200E_200C_206C_206F_206A_206C_206C_200F_202C_206C_202C_202E_200D_202B_202C_202A_202B_200F_206D_206D_206D_202E(luaString);
		LuaScriptMgr.Push(L, d);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetAxisRaw(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string luaString = default(string);
		while (true)
		{
			int num = -2066483609;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1704495247)) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_0029;
				default:
				{
					float d = _200D_202B_202B_206F_202A_206C_206D_206B_206E_200E_200B_200F_206D_202D_202C_206A_202B_202E_200E_202B_206E_206A_202D_202C_206D_200D_200D_200E_202E_202D_202E_202E_206B_200C_202C_206A_202D_206C_200B_200C_202E(luaString);
					LuaScriptMgr.Push(L, d);
					return 1;
				}
				}
				break;
				IL_0029:
				luaString = LuaScriptMgr.GetLuaString(L, 1);
				num = (int)(num2 * 1096867611) ^ -208733819;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetButton(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		bool b = default(bool);
		while (true)
		{
			int num = -1974614963;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1904293128)) % 4)
				{
				case 3u:
					break;
				case 1u:
				{
					string luaString = LuaScriptMgr.GetLuaString(L, 1);
					b = _200F_202E_206C_200E_206D_202C_202D_206F_206C_200F_202E_200E_206C_202D_206C_202E_200E_202A_202C_200C_202D_206D_206E_200B_206E_206F_200F_206D_206C_200F_200B_200F_202D_206E_200C_200B_202A_206C_202E_202B_202E(luaString);
					num = (int)(num2 * 609120570) ^ -1648357852;
					continue;
				}
				case 2u:
					LuaScriptMgr.Push(L, b);
					num = ((int)num2 * -421215801) ^ -316829626;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetButtonDown(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		bool b = default(bool);
		while (true)
		{
			int num = -383872080;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -336076210)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0029;
				default:
					LuaScriptMgr.Push(L, b);
					return 1;
				}
				break;
				IL_0029:
				string luaString = LuaScriptMgr.GetLuaString(L, 1);
				b = _200D_200E_206E_200B_200C_206D_206A_206A_206F_200E_202A_206D_200C_200D_206C_206F_206B_206F_206A_206A_200D_206C_200E_206A_206C_202A_200B_200C_200E_200F_200B_200D_200F_200D_206D_206E_200E_206E_202E_202D_202E(luaString);
				num = (int)((num2 * 2025188425) ^ 0x33B5AD4F);
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetButtonUp(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string luaString = default(string);
		bool b = default(bool);
		while (true)
		{
			int num = -1302006651;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -32892295)) % 5)
				{
				case 4u:
					break;
				case 1u:
					luaString = LuaScriptMgr.GetLuaString(L, 1);
					num = ((int)num2 * -733152446) ^ -1547265266;
					continue;
				case 3u:
					LuaScriptMgr.Push(L, b);
					num = ((int)num2 * -1417418280) ^ 0x59FF3BC2;
					continue;
				case 0u:
					b = _206A_200C_206F_200C_200B_206F_206F_206E_206A_202B_202B_202A_200C_206F_200E_206E_202B_206C_202E_202D_202D_206E_202C_200D_206C_200F_206D_200C_202A_200B_202D_206F_206F_202B_206E_200D_206C_206D_202A_206D_202E(luaString);
					num = ((int)num2 * -1817259613) ^ -2127895810;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetKey(IntPtr L)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		int num = LuaDLL.lua_gettop(L);
		if (num == 1)
		{
			goto IL_000e;
		}
		goto IL_00ca;
		IL_000e:
		int num2 = 810064350;
		goto IL_0013;
		IL_0013:
		bool b = default(bool);
		string text = default(string);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ 0x1DFC03C9)) % 11)
			{
			case 7u:
				break;
			case 10u:
				b = _202E_200F_200C_206C_206F_206A_202E_200E_202E_206D_202B_206E_200D_206A_206E_206A_202C_206F_202D_200B_206B_200B_202B_206F_206A_206B_202D_202D_202E_206B_200E_200F_206C_206D_200C_200B_206D_202E_206A_206C_202E(text);
				num2 = (int)(num3 * 327716649) ^ -762230206;
				continue;
			case 4u:
			{
				KeyCode val = (KeyCode)(int)LuaScriptMgr.GetLuaObject(L, 1);
				bool b2 = _206C_206E_200C_202E_200B_206C_200E_206E_200B_206C_206C_206A_206A_200C_202E_200F_200C_202B_200E_200D_206C_206D_200B_206D_200F_202B_200F_206C_200D_200D_202A_202D_202A_200E_206C_200C_202B_206E_202D_206D_202E(val);
				LuaScriptMgr.Push(L, b2);
				num2 = ((int)num3 * -1753641935) ^ -1636102361;
				continue;
			}
			case 1u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3658085974u));
				num2 = 822293152;
				continue;
			case 2u:
				return 1;
			case 3u:
				goto IL_00ca;
			case 9u:
			{
				int num6;
				int num7;
				if (LuaScriptMgr.CheckTypes(L, 1, _200F_202B_202B_200E_206E_202D_206E_200F_202A_202E_200E_200B_206A_206C_202E_202D_206C_206D_200D_202B_206F_206D_202A_206A_206D_202D_202C_206C_200F_200E_206E_206D_206C_206E_202A_206D_200F_200E_206F_206F_202E(typeof(KeyCode).TypeHandle)))
				{
					num6 = -324086650;
					num7 = num6;
				}
				else
				{
					num6 = -343810257;
					num7 = num6;
				}
				num2 = num6 ^ ((int)num3 * -309156002);
				continue;
			}
			case 0u:
				text = LuaScriptMgr.GetString(L, 1);
				num2 = ((int)num3 * -2080606275) ^ -112545923;
				continue;
			case 5u:
			{
				int num4;
				int num5;
				if (!LuaScriptMgr.CheckTypes(L, 1, _200F_202B_202B_200E_206E_202D_206E_200F_202A_202E_200E_200B_206A_206C_202E_202D_206C_206D_200D_202B_206F_206D_202A_206A_206D_202D_202C_206C_200F_200E_206E_206D_206C_206E_202A_206D_200F_200E_206F_206F_202E(typeof(string).TypeHandle)))
				{
					num4 = -947015098;
					num5 = num4;
				}
				else
				{
					num4 = -471466082;
					num5 = num4;
				}
				num2 = num4 ^ (int)(num3 * 448699703);
				continue;
			}
			case 8u:
				LuaScriptMgr.Push(L, b);
				return 1;
			default:
				return 0;
			}
			break;
		}
		goto IL_000e;
		IL_00ca:
		int num8;
		if (num != 1)
		{
			num2 = 803390469;
			num8 = num2;
		}
		else
		{
			num2 = 1851938460;
			num8 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetKeyDown(IntPtr L)
	{
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		int num = LuaDLL.lua_gettop(L);
		bool b = default(bool);
		string text = default(string);
		bool b2 = default(bool);
		while (true)
		{
			int num2 = 190795786;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x22ED168)) % 14)
				{
				case 8u:
					break;
				case 12u:
				{
					int num6;
					if (num != 1)
					{
						num2 = 1087204471;
						num6 = num2;
					}
					else
					{
						num2 = 508419504;
						num6 = num2;
					}
					continue;
				}
				case 9u:
					return 1;
				case 6u:
					b = _206F_202B_200C_202D_202B_200C_202E_200B_200C_206C_202E_206E_202A_206E_200D_202B_202C_206D_200D_202E_202D_206A_202B_202C_200E_206D_200F_202A_206F_200C_200E_206F_202D_206A_202E_202B_202C_202E_202A_206B_202E(text);
					num2 = ((int)num3 * -202066442) ^ 0xB31A594;
					continue;
				case 10u:
					return 1;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2798159860u));
					num2 = 122741797;
					continue;
				case 2u:
				{
					int num7;
					int num8;
					if (num != 1)
					{
						num7 = 1133403642;
						num8 = num7;
					}
					else
					{
						num7 = 948556349;
						num8 = num7;
					}
					num2 = num7 ^ (int)(num3 * 746970775);
					continue;
				}
				case 13u:
					text = LuaScriptMgr.GetString(L, 1);
					num2 = (int)((num3 * 1966901489) ^ 0x16349D9F);
					continue;
				case 0u:
				{
					int num9;
					int num10;
					if (LuaScriptMgr.CheckTypes(L, 1, _200F_202B_202B_200E_206E_202D_206E_200F_202A_202E_200E_200B_206A_206C_202E_202D_206C_206D_200D_202B_206F_206D_202A_206A_206D_202D_202C_206C_200F_200E_206E_206D_206C_206E_202A_206D_200F_200E_206F_206F_202E(typeof(string).TypeHandle)))
					{
						num9 = 28044141;
						num10 = num9;
					}
					else
					{
						num9 = 378821399;
						num10 = num9;
					}
					num2 = num9 ^ ((int)num3 * -465229436);
					continue;
				}
				case 1u:
				{
					KeyCode val = (KeyCode)(int)LuaScriptMgr.GetLuaObject(L, 1);
					b2 = _202A_202E_206D_206A_206A_200D_200E_206B_206E_206B_202D_206D_202D_202B_206D_202C_200C_206D_202B_200E_200D_206F_200F_202B_206D_200B_202E_202A_200E_206C_202B_200C_200D_202A_206A_202C_200F_202C_200C_202C_202E(val);
					num2 = ((int)num3 * -322904737) ^ 0x175E6CC0;
					continue;
				}
				case 3u:
					LuaScriptMgr.Push(L, b2);
					num2 = ((int)num3 * -1692062712) ^ -1440433548;
					continue;
				case 11u:
				{
					int num4;
					int num5;
					if (!LuaScriptMgr.CheckTypes(L, 1, _200F_202B_202B_200E_206E_202D_206E_200F_202A_202E_200E_200B_206A_206C_202E_202D_206C_206D_200D_202B_206F_206D_202A_206A_206D_202D_202C_206C_200F_200E_206E_206D_206C_206E_202A_206D_200F_200E_206F_206F_202E(typeof(KeyCode).TypeHandle)))
					{
						num4 = -1892010300;
						num5 = num4;
					}
					else
					{
						num4 = -1458573505;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num3 * -199553328);
					continue;
				}
				case 4u:
					LuaScriptMgr.Push(L, b);
					num2 = ((int)num3 * -1917025430) ^ 0x6372521D;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetKeyUp(IntPtr L)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		int num = LuaDLL.lua_gettop(L);
		if (num == 1)
		{
			goto IL_000e;
		}
		goto IL_0138;
		IL_000e:
		int num2 = -1354352697;
		goto IL_0013;
		IL_0013:
		KeyCode val = default(KeyCode);
		bool b = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ -344453726)) % 12)
			{
			case 5u:
				break;
			case 3u:
			{
				bool b2 = _206E_206F_206B_206E_206D_206E_200D_200C_200E_200F_202A_206D_200E_206A_200D_202A_202E_200F_206C_202C_200C_200E_200E_206F_202A_202B_206C_200C_200F_202B_202B_202C_200C_200B_206C_200E_206B_202D_202D_200D_202E(val);
				LuaScriptMgr.Push(L, b2);
				num2 = (int)(num3 * 634213142) ^ -1911834390;
				continue;
			}
			case 6u:
				return 1;
			case 2u:
			{
				int num6;
				int num7;
				if (LuaScriptMgr.CheckTypes(L, 1, _200F_202B_202B_200E_206E_202D_206E_200F_202A_202E_200E_200B_206A_206C_202E_202D_206C_206D_200D_202B_206F_206D_202A_206A_206D_202D_202C_206C_200F_200E_206E_206D_206C_206E_202A_206D_200F_200E_206F_206F_202E(typeof(string).TypeHandle)))
				{
					num6 = -2123731194;
					num7 = num6;
				}
				else
				{
					num6 = -1016633253;
					num7 = num6;
				}
				num2 = num6 ^ ((int)num3 * -1119688);
				continue;
			}
			case 0u:
				return 1;
			case 4u:
				val = (KeyCode)(int)LuaScriptMgr.GetLuaObject(L, 1);
				num2 = (int)((num3 * 633808263) ^ 0x49A3F9A1);
				continue;
			case 1u:
			{
				int num4;
				int num5;
				if (LuaScriptMgr.CheckTypes(L, 1, _200F_202B_202B_200E_206E_202D_206E_200F_202A_202E_200E_200B_206A_206C_202E_202D_206C_206D_200D_202B_206F_206D_202A_206A_206D_202D_202C_206C_200F_200E_206E_206D_206C_206E_202A_206D_200F_200E_206F_206F_202E(typeof(KeyCode).TypeHandle)))
				{
					num4 = -864443153;
					num5 = num4;
				}
				else
				{
					num4 = -1614250987;
					num5 = num4;
				}
				num2 = num4 ^ (int)(num3 * 283386573);
				continue;
			}
			case 9u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1275645323u));
				num2 = -1162289199;
				continue;
			case 10u:
				goto IL_0138;
			case 8u:
			{
				string text = LuaScriptMgr.GetString(L, 1);
				b = _200D_206F_200E_206E_200B_202D_206B_200F_206F_202A_202A_202B_202A_200D_206D_202A_200B_206A_200E_202C_206D_200F_202A_206D_206F_200D_206B_202B_202C_206C_206F_202B_200D_202B_206D_206C_202A_206B_202E_206F_202E(text);
				num2 = ((int)num3 * -204493714) ^ 0x12C90C3D;
				continue;
			}
			case 11u:
				LuaScriptMgr.Push(L, b);
				num2 = (int)(num3 * 147956044) ^ -465596206;
				continue;
			default:
				return 0;
			}
			break;
		}
		goto IL_000e;
		IL_0138:
		int num8;
		if (num != 1)
		{
			num2 = -2035839669;
			num8 = num2;
		}
		else
		{
			num2 = -1132967188;
			num8 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetJoystickNames(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		string[] o = _200E_202C_206C_202B_206C_206B_206F_206F_206C_202E_206D_202A_200F_202D_202E_202A_206F_200F_206A_206B_202C_206A_200F_200E_202E_202E_202B_202C_202A_200D_200F_206D_200D_206B_206A_200C_206F_206B_202A_206A_202E();
		LuaScriptMgr.PushArray(L, o);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetMouseButton(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		bool b = default(bool);
		while (true)
		{
			int num = 218116887;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1945CFFE)) % 4)
				{
				case 3u:
					break;
				case 1u:
				{
					int num3 = (int)LuaScriptMgr.GetNumber(L, 1);
					b = _202D_206A_206E_206C_200D_202C_206A_200B_206A_200C_202E_202B_200B_202D_206B_202E_206E_206B_206A_202A_202D_206D_206C_202A_200B_200B_206C_202D_206F_206D_202A_202E_206D_202A_206A_200D_202A_206A_200D_206A_202E(num3);
					num = ((int)num2 * -265820261) ^ 0x6132351B;
					continue;
				}
				case 2u:
					LuaScriptMgr.Push(L, b);
					num = ((int)num2 * -2092308479) ^ -531343736;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetMouseButtonDown(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		int num3 = default(int);
		while (true)
		{
			int num = 1999239823;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x74576609)) % 4)
				{
				case 0u:
					break;
				case 2u:
					num3 = (int)LuaScriptMgr.GetNumber(L, 1);
					num = (int)((num2 * 772993777) ^ 0x6B1E0C28);
					continue;
				case 3u:
				{
					bool b = _200C_202E_206B_202C_200E_202C_202B_206B_206C_206E_202E_206D_200E_200C_200D_206C_206D_200E_200F_202A_206F_202A_202C_202A_206B_200E_200B_206C_206D_200D_202C_200B_202E_206A_200E_202A_200F_200F_206E_206D_202E(num3);
					LuaScriptMgr.Push(L, b);
					num = ((int)num2 * -1094720988) ^ -1820026372;
					continue;
				}
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetMouseButtonUp(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		int num = (int)LuaScriptMgr.GetNumber(L, 1);
		bool b = default(bool);
		while (true)
		{
			int num2 = -1918436578;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1658526825)) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_0032;
				default:
					LuaScriptMgr.Push(L, b);
					return 1;
				}
				break;
				IL_0032:
				b = _200F_200C_200D_206B_200D_202D_202E_206F_200D_202B_206A_200E_200B_202B_206E_202D_206D_206E_200C_206D_202D_206E_206B_206A_206F_200C_202E_206C_206D_206C_202A_206A_200D_206A_202A_202D_202E_200D_202C_202C_202E(num);
				num2 = ((int)num3 * -1330270225) ^ 0x5ACE4FF0;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int ResetInputAxes(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		_202A_206B_206E_202B_202C_206B_206C_202E_200B_200E_206A_202B_202A_202B_200D_202C_200D_202E_206A_200E_200B_200C_206E_200F_206E_206A_202B_200E_206A_202A_200E_200E_200E_202B_200E_202C_206E_202E_200C_202A_202E();
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetAccelerationEvent(IntPtr L)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr.CheckArgsCount(L, 1);
		int num3 = default(int);
		while (true)
		{
			int num = -138794472;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -12876891)) % 4)
				{
				case 0u:
					break;
				case 1u:
					num3 = (int)LuaScriptMgr.GetNumber(L, 1);
					num = (int)((num2 * 742947746) ^ 0x50E5B849);
					continue;
				case 2u:
				{
					AccelerationEvent val = _200C_206D_202B_206F_206E_206A_200C_206B_200E_206A_206E_202C_200E_200D_202C_200E_200E_206A_200D_206D_206F_206B_206E_200E_202C_202B_202A_202A_202A_206A_202D_206C_202B_200E_206D_200E_206D_202E_206C_202E_202E(num3);
					LuaScriptMgr.PushValue(L, val);
					num = (int)(num2 * 487039848) ^ -1995151926;
					continue;
				}
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetTouch(IntPtr L)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr.CheckArgsCount(L, 1);
		int num = (int)LuaScriptMgr.GetNumber(L, 1);
		Touch touch = _200D_202E_202E_206C_202C_202B_206A_200E_206D_200F_200C_202C_200B_200E_200E_206A_206F_206A_202E_200D_206B_200D_202D_206F_206C_206A_200C_200B_200E_206E_200F_202A_202E_206F_202E_206A_200F_202C_202B_206D_202E(num);
		while (true)
		{
			int num2 = -1230422580;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -977910113)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_0039;
				default:
					return 1;
				}
				break;
				IL_0039:
				LuaScriptMgr.Push(L, touch);
				num2 = ((int)num3 * -1314060908) ^ 0x6CE88402;
			}
		}
	}

	static Type _200F_202B_202B_200E_206E_202D_206E_200F_202A_202E_200E_200B_206A_206C_202E_202D_206C_206D_200D_202B_206F_206D_202A_206A_206D_202D_202C_206C_200F_200E_206E_206D_206C_206E_202A_206D_200F_200E_206F_206F_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static Input _200B_206D_206F_206E_206A_202C_200C_206B_202D_202D_202E_200F_200B_200B_200F_202C_202E_202A_202E_202B_200B_206E_206B_202A_200E_202A_206D_200F_206A_202C_202E_206A_202D_202D_200C_202E_200E_206D_200D_202E_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Input();
	}

	static bool _206F_200F_200B_202C_200B_202A_200F_200D_206F_202B_202A_206E_202B_206B_202C_200B_206D_206B_200B_200E_202A_200E_200E_200E_200E_202A_206B_200D_202C_200B_202C_200D_202D_202C_202B_202E_200C_206D_200C_206A_202E()
	{
		return Input.compensateSensors;
	}

	static Gyroscope _200F_206B_202D_200C_206F_202E_200C_206F_206C_200F_202A_202C_200C_200E_202D_200E_200E_206A_206C_202D_202C_202A_202A_206F_206E_202A_200B_200B_206F_202B_202E_206B_206B_200B_206C_200D_200E_202E_206D_202A_202E()
	{
		return Input.gyro;
	}

	static Vector3 _206D_202C_200F_200C_202A_200E_200C_206B_200B_206D_200F_206D_202C_206E_206D_200E_200B_206F_202C_202E_202A_206D_200C_206F_200F_202B_202C_200E_206D_206B_200E_200B_200E_206F_200D_202A_202A_200E_202C_200F_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Input.mousePosition;
	}

	static Vector2 _202C_200C_206D_202E_202C_206D_206A_202A_200D_202C_202E_202A_206E_206B_206C_200E_202C_206F_200D_200E_206B_200C_202A_202C_200E_206B_202C_202D_206F_206F_206D_202E_200B_202A_206F_202C_200D_200C_202A_206C_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Input.mouseScrollDelta;
	}

	static bool _200C_206B_200C_202E_202C_202E_206F_206E_200B_202A_206F_200F_206A_200E_200E_202E_202A_200B_202E_206E_206B_202A_206F_200D_202B_200F_202E_206E_200E_200E_202D_206D_202A_206C_202A_202E_202C_206E_206B_206E_202E()
	{
		return Input.mousePresent;
	}

	static bool _202A_200E_206B_200D_202D_200D_206C_206C_202D_206D_200C_206A_206D_202D_200B_206E_206A_202A_200C_200D_202A_200B_202D_206A_206E_200F_200F_206A_206B_206A_206D_206F_206B_206A_200E_200E_206C_200D_202E()
	{
		return Input.simulateMouseWithTouches;
	}

	static bool _206C_206B_200F_206C_206F_206F_202B_206A_206E_202A_206F_206D_202E_206F_206F_200E_206E_202E_202A_206E_202A_202A_206E_206A_200B_206C_200E_202A_202E_206F_206E_202D_202B_206D_202D_206A_200B_202E_206A_200C_202E()
	{
		return Input.anyKey;
	}

	static bool _202B_202C_206E_200C_200F_206F_206E_206F_206A_200C_206F_202D_206F_202C_200B_200C_200E_202D_200E_200C_200D_202A_200F_206E_202A_202B_202D_202E_200F_206D_206D_202C_202B_202C_202C_206B_200F_206A_202A_202E_202E()
	{
		return Input.anyKeyDown;
	}

	static string _206C_202B_202C_202B_200F_200E_206B_200F_200C_206A_200F_202A_202C_202D_202E_202E_206D_202A_200F_200E_200C_200F_202A_200B_206F_206A_200D_200C_200D_200B_206C_202D_206D_202C_200B_202B_200B_206E_200E_206A_202E()
	{
		return Input.inputString;
	}

	static Vector3 _202A_206B_206B_202D_202A_200E_206E_200D_202E_202E_200B_202D_200D_206A_202B_200B_202A_206B_206B_202E_200D_206B_202B_206F_202E_200C_200B_202C_206E_200E_206C_200E_202A_200E_200C_202E_202B_206C_202E_200D_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Input.acceleration;
	}

	static AccelerationEvent[] _200E_206C_200E_206F_206A_200B_206C_202C_200F_200E_200C_206A_206A_202A_206C_202A_200B_202B_206E_200D_202B_206C_206E_202B_200C_200E_202A_200B_202A_200D_202D_206C_202D_206D_200E_202A_206B_200E_202E_206E_202E()
	{
		return Input.accelerationEvents;
	}

	static int _200C_202C_200D_206B_202C_202C_200F_202A_202E_200D_202D_206A_206D_206E_200D_206C_202D_200D_200E_206C_202D_202C_202A_202C_200F_202B_202A_202A_202E_202A_202A_200D_200C_206D_206D_206A_202E_202E_202D_202C_202E()
	{
		return Input.accelerationEventCount;
	}

	static Touch[] _202E_200C_202A_202B_200D_206C_206B_200F_206F_206D_200E_206E_200C_200B_202E_200B_202D_202B_202A_200C_200B_200F_206B_206C_202C_206F_200E_200F_202A_200D_206D_202D_202B_200C_202A_202D_206F_206F_206F_202E()
	{
		return Input.touches;
	}

	static int _206D_206D_206A_206F_206C_202A_206C_206C_206B_200C_206C_200B_202D_200C_200D_206A_200E_206C_200B_206C_200B_206C_200B_200D_202B_202D_206E_206E_200F_206C_206C_206D_202E_206E_206C_200E_200B_206E_200D_202D_202E()
	{
		return Input.touchCount;
	}

	static bool _206C_206D_200C_202C_206F_200C_206B_200F_200C_206B_202C_202E_202A_200D_206C_200E_200F_200B_202E_202C_202E_202D_206C_206D_200B_206B_202E_202E_206B_200B_206F_206A_200D_206C_200D_206A_206C_206A_200C_206B_202E()
	{
		return Input.touchPressureSupported;
	}

	static bool _202B_206F_200F_206C_206A_206C_206F_206E_202B_202B_202C_206A_200D_206E_206D_202B_202E_206B_200B_200D_206F_206F_206A_202C_206F_202D_206D_200C_200F_206A_200E_206E_206D_202B_200D_206D_206C_200D_206C_202D_202E()
	{
		return Input.stylusTouchSupported;
	}

	static bool _200C_202B_200F_202B_202D_200D_206B_206E_206B_206E_200D_206F_200F_200E_202D_200B_206F_200C_202D_202C_202C_200F_202C_206B_202B_202E_206E_200E_200D_206B_200D_206D_206D_202A_206B_206E_202A_200F_202A_200E_202E()
	{
		return Input.touchSupported;
	}

	static bool _200D_200F_202A_200D_200C_200C_206D_202E_200E_200E_200F_202B_200B_200E_202C_206C_200E_206E_200F_202C_202E_202C_206F_206A_200B_202D_206A_202A_202A_206B_206D_202B_206C_200B_206F_202D_200C_200C_206C_206F_202E()
	{
		return Input.multiTouchEnabled;
	}

	static LocationService _202C_206C_206D_202A_202B_206C_200E_206C_206D_202D_200B_206B_202B_202E_206B_200E_200B_202B_200F_200D_202B_206C_200F_200C_200F_206F_202D_202A_202E_200B_200B_200C_206C_202C_200B_206D_200F_200F_200E_202E()
	{
		return Input.location;
	}

	static Compass _206D_202E_202D_206C_202B_200C_202E_200C_202D_206E_202D_202D_206D_200E_200E_202B_206A_202C_202E_200F_200B_202D_206F_206D_206E_200D_202C_202E_206A_202C_206D_200C_206A_202D_206F_206D_206F_206C_200D_206A_202E()
	{
		return Input.compass;
	}

	static DeviceOrientation _206F_206B_202E_200B_200E_202E_206F_206D_202C_202A_206D_206C_202E_206D_202B_206D_202C_200E_202D_202A_206A_200F_206B_202D_206D_202C_202B_202C_206B_202E_202A_206A_202B_206F_200C_200F_200F_206B_206C_200E_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Input.deviceOrientation;
	}

	static IMECompositionMode _202C_202B_206B_202C_206B_206A_206C_202B_202A_202E_202B_202C_200E_206A_202B_200D_200C_206C_202E_206F_206F_206D_202E_200F_200F_206B_206B_202C_202D_206E_200B_200E_206D_200D_200E_206C_202A_202D_202B_206E_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Input.imeCompositionMode;
	}

	static string _200C_202C_200B_200D_202C_202B_206E_202D_200B_200F_200B_206F_202C_202D_206E_202B_206D_202E_206B_200C_206B_202A_200F_200E_202B_206C_200F_206B_200C_206B_200D_200D_202A_200B_200C_206C_202B_206E_206B_202B_202E()
	{
		return Input.compositionString;
	}

	static bool _206B_200C_206F_206A_200E_206E_206E_206C_206B_200B_206A_202B_202E_200D_200C_202B_206D_202D_206E_206D_206F_200E_206A_200E_200C_202A_202C_206D_200F_206D_200E_202C_202A_206E_202E_200D_202C_206D_202C_200E_202E()
	{
		return Input.imeIsSelected;
	}

	static Vector2 _202C_202B_206B_206F_200C_200D_202A_202D_202D_206B_200C_202A_200D_200B_202A_202D_202A_202A_200E_202C_200F_200E_206F_202B_202B_202B_206D_206B_202A_200E_202B_202A_206A_202E_200F_206A_206B_206E_200E_200E_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Input.compositionCursorPos;
	}

	static void _206A_200B_202C_206E_200E_200D_202A_206A_202A_202B_206A_202E_206C_206F_200F_200F_202A_200E_202E_200C_206C_206A_202D_200F_202A_206D_200C_202E_202D_200C_206F_206E_200D_202B_202A_206D_202D_206F_206E_202C_202E(bool P_0)
	{
		Input.compensateSensors = P_0;
	}

	static void _202D_206B_206C_206D_200E_206F_202E_206F_200D_202D_202C_202C_202D_200C_206E_202E_200B_200D_206A_202E_200F_202E_202A_206B_200E_200D_200E_206E_206E_200C_202A_206D_200F_206D_206F_206B_202A_206F_202D_206A_202E(bool P_0)
	{
		Input.simulateMouseWithTouches = P_0;
	}

	static void _202E_200E_200C_202C_202D_202D_202D_206C_200C_202E_200B_200C_200C_200C_202A_200C_206D_202A_206D_200B_206C_200E_206B_206B_200C_200C_202D_206E_200B_206E_200F_202C_206D_206F_200F_206A_202B_206A_200D_200F_202E(bool P_0)
	{
		Input.multiTouchEnabled = P_0;
	}

	static void _206A_202D_200C_202B_206D_206F_202A_200B_202D_206C_206F_200B_200E_206C_202E_202E_202D_206D_206E_200B_200C_200E_200C_202A_202B_202A_202D_206F_200C_206F_202E_202C_206A_202C_206A_202B_202B_206E_202B_202A_202E(IMECompositionMode P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		Input.imeCompositionMode = P_0;
	}

	static void _200D_200B_206C_206B_202A_202B_200E_206F_200D_206B_202A_202C_206A_202E_206C_206F_202D_200F_202D_200D_200C_200F_200D_206F_200B_206C_206A_206F_202A_206D_202E_206E_202E_200D_206C_202A_200C_202C_202D_206D_202E(Vector2 P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		Input.compositionCursorPos = P_0;
	}

	static float _206B_206A_200D_200F_206B_206F_206F_206E_206A_202B_200D_202E_200E_200F_200B_200F_200E_200E_200D_200E_200C_206C_206F_206A_206C_206C_200F_202C_206C_202C_202E_200D_202B_202C_202A_202B_200F_206D_206D_206D_202E(string P_0)
	{
		return Input.GetAxis(P_0);
	}

	static float _200D_202B_202B_206F_202A_206C_206D_206B_206E_200E_200B_200F_206D_202D_202C_206A_202B_202E_200E_202B_206E_206A_202D_202C_206D_200D_200D_200E_202E_202D_202E_202E_206B_200C_202C_206A_202D_206C_200B_200C_202E(string P_0)
	{
		return Input.GetAxisRaw(P_0);
	}

	static bool _200F_202E_206C_200E_206D_202C_202D_206F_206C_200F_202E_200E_206C_202D_206C_202E_200E_202A_202C_200C_202D_206D_206E_200B_206E_206F_200F_206D_206C_200F_200B_200F_202D_206E_200C_200B_202A_206C_202E_202B_202E(string P_0)
	{
		return Input.GetButton(P_0);
	}

	static bool _200D_200E_206E_200B_200C_206D_206A_206A_206F_200E_202A_206D_200C_200D_206C_206F_206B_206F_206A_206A_200D_206C_200E_206A_206C_202A_200B_200C_200E_200F_200B_200D_200F_200D_206D_206E_200E_206E_202E_202D_202E(string P_0)
	{
		return Input.GetButtonDown(P_0);
	}

	static bool _206A_200C_206F_200C_200B_206F_206F_206E_206A_202B_202B_202A_200C_206F_200E_206E_202B_206C_202E_202D_202D_206E_202C_200D_206C_200F_206D_200C_202A_200B_202D_206F_206F_202B_206E_200D_206C_206D_202A_206D_202E(string P_0)
	{
		return Input.GetButtonUp(P_0);
	}

	static bool _206C_206E_200C_202E_200B_206C_200E_206E_200B_206C_206C_206A_206A_200C_202E_200F_200C_202B_200E_200D_206C_206D_200B_206D_200F_202B_200F_206C_200D_200D_202A_202D_202A_200E_206C_200C_202B_206E_202D_206D_202E(KeyCode P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Input.GetKey(P_0);
	}

	static bool _202E_200F_200C_206C_206F_206A_202E_200E_202E_206D_202B_206E_200D_206A_206E_206A_202C_206F_202D_200B_206B_200B_202B_206F_206A_206B_202D_202D_202E_206B_200E_200F_206C_206D_200C_200B_206D_202E_206A_206C_202E(string P_0)
	{
		return Input.GetKey(P_0);
	}

	static bool _202A_202E_206D_206A_206A_200D_200E_206B_206E_206B_202D_206D_202D_202B_206D_202C_200C_206D_202B_200E_200D_206F_200F_202B_206D_200B_202E_202A_200E_206C_202B_200C_200D_202A_206A_202C_200F_202C_200C_202C_202E(KeyCode P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Input.GetKeyDown(P_0);
	}

	static bool _206F_202B_200C_202D_202B_200C_202E_200B_200C_206C_202E_206E_202A_206E_200D_202B_202C_206D_200D_202E_202D_206A_202B_202C_200E_206D_200F_202A_206F_200C_200E_206F_202D_206A_202E_202B_202C_202E_202A_206B_202E(string P_0)
	{
		return Input.GetKeyDown(P_0);
	}

	static bool _206E_206F_206B_206E_206D_206E_200D_200C_200E_200F_202A_206D_200E_206A_200D_202A_202E_200F_206C_202C_200C_200E_200E_206F_202A_202B_206C_200C_200F_202B_202B_202C_200C_200B_206C_200E_206B_202D_202D_200D_202E(KeyCode P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Input.GetKeyUp(P_0);
	}

	static bool _200D_206F_200E_206E_200B_202D_206B_200F_206F_202A_202A_202B_202A_200D_206D_202A_200B_206A_200E_202C_206D_200F_202A_206D_206F_200D_206B_202B_202C_206C_206F_202B_200D_202B_206D_206C_202A_206B_202E_206F_202E(string P_0)
	{
		return Input.GetKeyUp(P_0);
	}

	static string[] _200E_202C_206C_202B_206C_206B_206F_206F_206C_202E_206D_202A_200F_202D_202E_202A_206F_200F_206A_206B_202C_206A_200F_200E_202E_202E_202B_202C_202A_200D_200F_206D_200D_206B_206A_200C_206F_206B_202A_206A_202E()
	{
		return Input.GetJoystickNames();
	}

	static bool _202D_206A_206E_206C_200D_202C_206A_200B_206A_200C_202E_202B_200B_202D_206B_202E_206E_206B_206A_202A_202D_206D_206C_202A_200B_200B_206C_202D_206F_206D_202A_202E_206D_202A_206A_200D_202A_206A_200D_206A_202E(int P_0)
	{
		return Input.GetMouseButton(P_0);
	}

	static bool _200C_202E_206B_202C_200E_202C_202B_206B_206C_206E_202E_206D_200E_200C_200D_206C_206D_200E_200F_202A_206F_202A_202C_202A_206B_200E_200B_206C_206D_200D_202C_200B_202E_206A_200E_202A_200F_200F_206E_206D_202E(int P_0)
	{
		return Input.GetMouseButtonDown(P_0);
	}

	static bool _200F_200C_200D_206B_200D_202D_202E_206F_200D_202B_206A_200E_200B_202B_206E_202D_206D_206E_200C_206D_202D_206E_206B_206A_206F_200C_202E_206C_206D_206C_202A_206A_200D_206A_202A_202D_202E_200D_202C_202C_202E(int P_0)
	{
		return Input.GetMouseButtonUp(P_0);
	}

	static void _202A_206B_206E_202B_202C_206B_206C_202E_200B_200E_206A_202B_202A_202B_200D_202C_200D_202E_206A_200E_200B_200C_206E_200F_206E_206A_202B_200E_206A_202A_200E_200E_200E_202B_200E_202C_206E_202E_200C_202A_202E()
	{
		Input.ResetInputAxes();
	}

	static AccelerationEvent _200C_206D_202B_206F_206E_206A_200C_206B_200E_206A_206E_202C_200E_200D_202C_200E_200E_206A_200D_206D_206F_206B_206E_200E_202C_202B_202A_202A_202A_206A_202D_206C_202B_200E_206D_200E_206D_202E_206C_202E_202E(int P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return Input.GetAccelerationEvent(P_0);
	}

	static Touch _200D_202E_202E_206C_202C_202B_206A_200E_206D_200F_200C_202C_200B_200E_200E_206A_206F_206A_202E_200D_206B_200D_202D_206F_206C_206A_200C_200B_200E_206E_200F_202A_202E_206F_202E_206A_200F_202C_202B_206D_202E(int P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return Input.GetTouch(P_0);
	}
}
