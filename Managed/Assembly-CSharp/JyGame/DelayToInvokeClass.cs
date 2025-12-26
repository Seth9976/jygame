using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace JyGame;

public class DelayToInvokeClass : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _200D_200F_200D_202A_200B_206E_202D_200E_202E_200B_206C_200B_200E_202B_202E_202C_206D_202A_202B_200C_202E_206C_206E_200E_206D_200D_200E_200E_200D_200F_206A_200F_206F_200E_202B_200F_202D_200F_200D_202C_202E : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E;

		private object _200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E;

		public float delaySeconds;

		public Action action;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E;
			}
		}

		[DebuggerHidden]
		public _200D_200F_200D_202A_200B_206E_202D_200E_202E_200B_206C_200B_200E_202B_202E_202C_206D_202A_202B_200C_202E_206C_206E_200E_206D_200D_200E_200E_200D_200F_206A_200F_206F_200E_202B_200F_202D_200F_200D_202C_202E(int P_0)
		{
			_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = P_0;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E;
			if (num != 0)
			{
				goto IL_000a;
			}
			goto IL_0073;
			IL_000a:
			int num2 = -2035733722;
			goto IL_000f;
			IL_000f:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1256477003)) % 9)
				{
				case 6u:
					break;
				case 1u:
					action();
					num2 = ((int)num3 * -95986842) ^ 0x4202E3B9;
					continue;
				case 3u:
					return false;
				case 8u:
					goto IL_0073;
				case 5u:
				{
					int num4;
					int num5;
					if (num == 1)
					{
						num4 = 464134841;
						num5 = num4;
					}
					else
					{
						num4 = 1408457294;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 2028165625);
					continue;
				}
				case 2u:
					return true;
				case 4u:
					_200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E = _202E_200D_200F_202C_206F_202C_200F_202E_206A_200D_206D_206B_202B_202C_202C_206A_206E_202E_206E_200C_200F_200D_206D_202B_202C_206D_206F_206C_202E_206E_206B_206E_206C_206F_200C_206D_206C_200F_206C_206C_202E(delaySeconds);
					_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 1;
					num2 = (int)((num3 * 1657669512) ^ 0x2FFA8338);
					continue;
				case 0u:
					_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
					num2 = -686523699;
					continue;
				default:
					return false;
				}
				break;
			}
			goto IL_000a;
			IL_0073:
			_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
			num2 = -533852934;
			goto IL_000f;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw _200B_206B_200B_202D_200B_200B_200E_202A_200D_200B_202E_202B_200E_202E_200D_206E_202C_202D_206C_202E_206F_200D_202B_200F_200B_206F_202C_202E_206E_200C_206A_206E_206B_200F_200E_200E_206D_206C_206E_202C_202E();
		}

		static WaitForSeconds _202E_200D_200F_202C_206F_202C_200F_202E_206A_200D_206D_206B_202B_202C_202C_206A_206E_202E_206E_200C_200F_200D_206D_202B_202C_206D_206F_206C_202E_206E_206B_206E_206C_206F_200C_206D_206C_200F_206C_206C_202E(float P_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Expected O, but got Unknown
			return new WaitForSeconds(P_0);
		}

		static NotSupportedException _200B_206B_200B_202D_200B_200B_200E_202A_200D_200B_202E_202B_200E_202E_200D_206E_202C_202D_206C_202E_206F_200D_202B_200F_200B_206F_202C_202E_206E_200C_206A_206E_206B_200F_200E_200E_206D_206C_206E_202C_202E()
		{
			return new NotSupportedException();
		}
	}

	public static IEnumerator DelayToInvokeDo(Action action, float delaySeconds)
	{
		while (true)
		{
			int num = -533852934;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1256477003)) % 9)
				{
				case 6u:
					num = -2035733722;
					continue;
				default:
					yield break;
				case 1u:
					action();
					num = ((int)num2 * -95986842) ^ 0x4202E3B9;
					continue;
				case 3u:
					yield break;
				case 8u:
					break;
				case 5u:
				{
					int num3;
					num = ((num3 != 1) ? 1408457294 : 464134841) ^ (int)(num2 * 2028165625);
					continue;
				}
				case 2u:
					/*Error near IL_00a2: Unexpected return in MoveNext()*/;
				case 4u:
					yield return _200D_200F_200D_202A_200B_206E_202D_200E_202E_200B_206C_200B_200E_202B_202E_202C_206D_202A_202B_200C_202E_206C_206E_200E_206D_200D_200E_200E_200D_200F_206A_200F_206F_200E_202B_200F_202D_200F_200D_202C_202E._202E_200D_200F_202C_206F_202C_200F_202E_206A_200D_206D_206B_202B_202C_202C_206A_206E_202E_206E_200C_200F_200D_206D_202B_202C_206D_206F_206C_202E_206E_206B_206E_206C_206F_200C_206D_206C_200F_206C_206C_202E(delaySeconds);
					/*Error: Unable to find 'return true' for yield return*/;
				case 0u:
					num = -686523699;
					continue;
				}
				break;
			}
		}
	}
}
