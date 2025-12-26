using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Base class for images &amp; text strings displayed in a GUI.</para>
	/// </summary>
	// Token: 0x0200003B RID: 59
	public class GUIElement : Behaviour
	{
		/// <summary>
		///   <para>Is a point on screen inside the element?</para>
		/// </summary>
		/// <param name="screenPosition"></param>
		/// <param name="camera"></param>
		// Token: 0x060002E8 RID: 744 RVA: 0x00002872 File Offset: 0x00000A72
		public bool HitTest(Vector3 screenPosition, [DefaultValue("null")] Camera camera)
		{
			return GUIElement.INTERNAL_CALL_HitTest(this, ref screenPosition, camera);
		}

		/// <summary>
		///   <para>Is a point on screen inside the element?</para>
		/// </summary>
		/// <param name="screenPosition"></param>
		/// <param name="camera"></param>
		// Token: 0x060002E9 RID: 745 RVA: 0x0000FBAC File Offset: 0x0000DDAC
		[ExcludeFromDocs]
		public bool HitTest(Vector3 screenPosition)
		{
			Camera camera = null;
			return GUIElement.INTERNAL_CALL_HitTest(this, ref screenPosition, camera);
		}

		// Token: 0x060002EA RID: 746
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_HitTest(GUIElement self, ref Vector3 screenPosition, Camera camera);

		/// <summary>
		///   <para>Returns bounding rectangle of GUIElement in screen coordinates.</para>
		/// </summary>
		/// <param name="camera"></param>
		// Token: 0x060002EB RID: 747
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Rect GetScreenRect([DefaultValue("null")] Camera camera);

		// Token: 0x060002EC RID: 748 RVA: 0x0000FBC4 File Offset: 0x0000DDC4
		[ExcludeFromDocs]
		public Rect GetScreenRect()
		{
			Camera camera = null;
			return this.GetScreenRect(camera);
		}
	}
}
