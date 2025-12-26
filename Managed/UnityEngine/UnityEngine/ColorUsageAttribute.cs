using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Attribute used to configure the usage of the ColorField and Color Picker for a color.</para>
	/// </summary>
	// Token: 0x020002CB RID: 715
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public sealed class ColorUsageAttribute : PropertyAttribute
	{
		/// <summary>
		///   <para>Attribute for Color fields. Used for configuring the GUI for the color.</para>
		/// </summary>
		/// <param name="showAlpha">If false then the alpha channel info is hidden both in the ColorField and in the Color Picker.</param>
		/// <param name="hdr">Set to true if the color should be treated as a HDR color (default value: false).</param>
		/// <param name="minBrightness">Minimum allowed HDR color component value when using the HDR Color Picker (default value: 0).</param>
		/// <param name="maxBrightness">Maximum allowed HDR color component value when using the HDR Color Picker (default value: 8).</param>
		/// <param name="minExposureValue">Minimum exposure value allowed in the HDR Color Picker (default value: 1/8 = 0.125).</param>
		/// <param name="maxExposureValue">Maximum exposure value allowed in the HDR Color Picker (default value: 3).</param>
		// Token: 0x060021BD RID: 8637 RVA: 0x0000D8B1 File Offset: 0x0000BAB1
		public ColorUsageAttribute(bool showAlpha)
		{
			this.showAlpha = showAlpha;
		}

		/// <summary>
		///   <para>Attribute for Color fields. Used for configuring the GUI for the color.</para>
		/// </summary>
		/// <param name="showAlpha">If false then the alpha channel info is hidden both in the ColorField and in the Color Picker.</param>
		/// <param name="hdr">Set to true if the color should be treated as a HDR color (default value: false).</param>
		/// <param name="minBrightness">Minimum allowed HDR color component value when using the HDR Color Picker (default value: 0).</param>
		/// <param name="maxBrightness">Maximum allowed HDR color component value when using the HDR Color Picker (default value: 8).</param>
		/// <param name="minExposureValue">Minimum exposure value allowed in the HDR Color Picker (default value: 1/8 = 0.125).</param>
		/// <param name="maxExposureValue">Maximum exposure value allowed in the HDR Color Picker (default value: 3).</param>
		// Token: 0x060021BE RID: 8638 RVA: 0x0002982C File Offset: 0x00027A2C
		public ColorUsageAttribute(bool showAlpha, bool hdr, float minBrightness, float maxBrightness, float minExposureValue, float maxExposureValue)
		{
			this.showAlpha = showAlpha;
			this.hdr = hdr;
			this.minBrightness = minBrightness;
			this.maxBrightness = maxBrightness;
			this.minExposureValue = minExposureValue;
			this.maxExposureValue = maxExposureValue;
		}

		/// <summary>
		///   <para>If false then the alpha bar is hidden in the ColorField and the alpha value is not shown in the Color Picker.</para>
		/// </summary>
		// Token: 0x04000AE5 RID: 2789
		public readonly bool showAlpha = true;

		/// <summary>
		///   <para>If set to true the Color is treated as a HDR color.</para>
		/// </summary>
		// Token: 0x04000AE6 RID: 2790
		public readonly bool hdr;

		/// <summary>
		///   <para>Minimum allowed HDR color component value when using the Color Picker.</para>
		/// </summary>
		// Token: 0x04000AE7 RID: 2791
		public readonly float minBrightness;

		/// <summary>
		///   <para>Maximum allowed HDR color component value when using the HDR Color Picker.</para>
		/// </summary>
		// Token: 0x04000AE8 RID: 2792
		public readonly float maxBrightness = 8f;

		/// <summary>
		///   <para>Minimum exposure value allowed in the HDR Color Picker.</para>
		/// </summary>
		// Token: 0x04000AE9 RID: 2793
		public readonly float minExposureValue = 0.125f;

		/// <summary>
		///   <para>Maximum exposure value allowed in the HDR Color Picker.</para>
		/// </summary>
		// Token: 0x04000AEA RID: 2794
		public readonly float maxExposureValue = 3f;
	}
}
