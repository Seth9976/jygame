using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Component added to a camera to make it render 2D GUI elements.</para>
	/// </summary>
	// Token: 0x0200003D RID: 61
	public sealed class GUILayer : Behaviour
	{
		/// <summary>
		///   <para>Get the GUI element at a specific screen position.</para>
		/// </summary>
		/// <param name="screenPosition"></param>
		// Token: 0x060002FB RID: 763 RVA: 0x00002899 File Offset: 0x00000A99
		public GUIElement HitTest(Vector3 screenPosition)
		{
			return GUILayer.INTERNAL_CALL_HitTest(this, ref screenPosition);
		}

		// Token: 0x060002FC RID: 764
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern GUIElement INTERNAL_CALL_HitTest(GUILayer self, ref Vector3 screenPosition);
	}
}
