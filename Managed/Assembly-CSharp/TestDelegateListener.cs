using System;
using UnityEngine;

public class TestDelegateListener : MonoBehaviour
{
	public Action onClick;

	public TestLuaDelegate.VoidDelegate onEvClick;

	private void OnGUI()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		if (GUI.Button(new Rect(10f, 10f, 200f, 20f), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1560684283u)))
		{
			goto IL_002a;
		}
		goto IL_0099;
		IL_002a:
		int num = 1550228041;
		goto IL_002f;
		IL_002f:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x1C54E08C)) % 7)
			{
			case 4u:
				break;
			default:
				return;
			case 0u:
				onEvClick(((Component)this).gameObject);
				num = (int)((num2 * 1150580116) ^ 0x1D6901D6);
				continue;
			case 6u:
				onClick();
				num = ((int)num2 * -1192512467) ^ -241554512;
				continue;
			case 5u:
				goto IL_0099;
			case 3u:
			{
				int num5;
				int num6;
				if (onEvClick == null)
				{
					num5 = 793062367;
					num6 = num5;
				}
				else
				{
					num5 = 1028210196;
					num6 = num5;
				}
				num = num5 ^ ((int)num2 * -431573471);
				continue;
			}
			case 2u:
			{
				int num3;
				int num4;
				if (onClick == null)
				{
					num3 = -242854226;
					num4 = num3;
				}
				else
				{
					num3 = -1390214154;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -1803625037);
				continue;
			}
			case 1u:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_0099:
		int num7;
		if (GUI.Button(new Rect(10f, 50f, 200f, 20f), global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(453172076u)))
		{
			num = 1721625217;
			num7 = num;
		}
		else
		{
			num = 30974578;
			num7 = num;
		}
		goto IL_002f;
	}
}
