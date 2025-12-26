using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>A collection of common color functions.</para>
	/// </summary>
	// Token: 0x020000A4 RID: 164
	public sealed class ColorUtility
	{
		// Token: 0x06000943 RID: 2371
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool DoTryParseHtmlColor(string htmlString, out Color32 color);

		// Token: 0x06000944 RID: 2372 RVA: 0x000166DC File Offset: 0x000148DC
		public static bool TryParseHtmlString(string htmlString, out Color color)
		{
			Color32 color2;
			bool flag = ColorUtility.DoTryParseHtmlColor(htmlString, out color2);
			color = color2;
			return flag;
		}

		/// <summary>
		///   <para>Returns the color as a hexadecimal string in the format "RRGGBB".</para>
		/// </summary>
		/// <param name="color">The color to be converted.</param>
		/// <returns>
		///   <para>Hexadecimal string representing the color.</para>
		/// </returns>
		// Token: 0x06000945 RID: 2373 RVA: 0x00016700 File Offset: 0x00014900
		public static string ToHtmlStringRGB(Color color)
		{
			Color32 color2 = color;
			return string.Format("{0:X2}{1:X2}{2:X2}", color2.r, color2.g, color2.b);
		}

		/// <summary>
		///   <para>Returns the color as a hexadecimal string in the format "RRGGBBAA".</para>
		/// </summary>
		/// <param name="color">The color to be converted.</param>
		/// <returns>
		///   <para>Hexadecimal string representing the color.</para>
		/// </returns>
		// Token: 0x06000946 RID: 2374 RVA: 0x00016744 File Offset: 0x00014944
		public static string ToHtmlStringRGBA(Color color)
		{
			Color32 color2 = color;
			return string.Format("{0:X2}{1:X2}{2:X2}{3:X2}", new object[] { color2.r, color2.g, color2.b, color2.a });
		}
	}
}
