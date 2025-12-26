using UnityEngine;

public class CameraAdjustUI : MonoBehaviour
{
	private float devHeight = 640f;

	private float devWidth = 1140f;

	private void Start()
	{
		float num = _206B_206C_202B_206C_200E_206F_200D_206C_202A_202B_202D_202B_206B_200E_202D_206E_206B_202A_206A_206E_202C_202B_206E_206C_202E_202A_200B_200F_202A_206D_202E_200D_206A_206E_200F_202B_206B_206D_202C_200F_202E(((Component)this).GetComponent<Camera>());
		float num4 = default(float);
		while (true)
		{
			int num2 = -1992587232;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1249417708)) % 5)
				{
				case 2u:
					break;
				default:
					return;
				case 3u:
					num4 = (float)_202A_200C_202A_202C_202A_202E_206E_202E_200E_200D_202A_206C_200C_202C_202C_206A_206E_206F_202C_200F_200B_206A_206D_200F_206D_206F_202B_200E_206F_206F_202B_202D_202D_200F_206B_206E_202D_206A_202B_202E() * 1f / (float)_202E_206F_202C_206D_206C_202B_200D_206E_200B_200C_206B_206D_202C_206E_200B_206A_206E_200B_200E_202C_206C_206C_200B_202D_200F_202E_200C_202C_206E_202D_200F_206C_200E_202A_200B_202B_206E_200D_202B_202C_202E();
					num2 = ((int)num3 * -2022636943) ^ 0x6FF00B3;
					continue;
				case 1u:
					num = devWidth / (2f * num4);
					_206F_206C_202C_200D_206C_206C_200B_206D_200F_202D_202D_206B_200E_202B_206D_200E_202E_206A_202B_202D_206C_202A_200D_206B_206A_206D_200B_206C_206A_206C_202C_202D_200E_200B_202B_206F_206C_206A_202D_202A_202E(((Component)this).GetComponent<Camera>(), num);
					num2 = ((int)num3 * -1817496211) ^ 0x771C2C8B;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (num * 2f * num4 >= devWidth)
					{
						num5 = 1685187266;
						num6 = num5;
					}
					else
					{
						num5 = 466504633;
						num6 = num5;
					}
					num2 = num5 ^ (int)(num3 * 836636632);
					continue;
				}
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void Update()
	{
	}

	static float _206B_206C_202B_206C_200E_206F_200D_206C_202A_202B_202D_202B_206B_200E_202D_206E_206B_202A_206A_206E_202C_202B_206E_206C_202E_202A_200B_200F_202A_206D_202E_200D_206A_206E_200F_202B_206B_206D_202C_200F_202E(Camera P_0)
	{
		return P_0.orthographicSize;
	}

	static int _202A_200C_202A_202C_202A_202E_206E_202E_200E_200D_202A_206C_200C_202C_202C_206A_206E_206F_202C_200F_200B_206A_206D_200F_206D_206F_202B_200E_206F_206F_202B_202D_202D_200F_206B_206E_202D_206A_202B_202E()
	{
		return Screen.width;
	}

	static int _202E_206F_202C_206D_206C_202B_200D_206E_200B_200C_206B_206D_202C_206E_200B_206A_206E_200B_200E_202C_206C_206C_200B_202D_200F_202E_200C_202C_206E_202D_200F_206C_200E_202A_200B_202B_206E_200D_202B_202C_202E()
	{
		return Screen.height;
	}

	static void _206F_206C_202C_200D_206C_206C_200B_206D_200F_202D_202D_206B_200E_202B_206D_200E_202E_206A_202B_202D_206C_202A_200D_206B_206A_206D_200B_206C_206A_206C_202C_202D_200E_200B_202B_206F_206C_206A_202D_202A_202E(Camera P_0, float P_1)
	{
		P_0.orthographicSize = P_1;
	}
}
