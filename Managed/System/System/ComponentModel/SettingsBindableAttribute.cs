using System;

namespace System.ComponentModel
{
	/// <summary>Specifies when a component property can be bound to an application setting.</summary>
	// Token: 0x020001AB RID: 427
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
	public sealed class SettingsBindableAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.SettingsBindableAttribute" /> class. </summary>
		/// <param name="bindable">true to specify that a property is appropriate to bind settings to; otherwise, false.</param>
		// Token: 0x06000EE8 RID: 3816 RVA: 0x0000C562 File Offset: 0x0000A762
		public SettingsBindableAttribute(bool bindable)
		{
			this.bindable = bindable;
		}

		/// <summary>Gets a value indicating whether a property is appropriate to bind settings to. </summary>
		/// <returns>true if the property is appropriate to bind settings to; otherwise, false.</returns>
		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000EEA RID: 3818 RVA: 0x0000C589 File Offset: 0x0000A789
		public bool Bindable
		{
			get
			{
				return this.bindable;
			}
		}

		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000EEB RID: 3819 RVA: 0x0000C591 File Offset: 0x0000A791
		public override int GetHashCode()
		{
			return (!this.bindable) ? (-1) : 1;
		}

		/// <summary>Determines whether two <see cref="T:System.ComponentModel.SettingsBindableAttribute" /> objects are equal.</summary>
		/// <returns>true if <paramref name="obj" /> equals the type and value of this instance; otherwise, false.</returns>
		/// <param name="obj">The value to compare to.</param>
		// Token: 0x06000EEC RID: 3820 RVA: 0x00036450 File Offset: 0x00034650
		public override bool Equals(object obj)
		{
			SettingsBindableAttribute settingsBindableAttribute = obj as SettingsBindableAttribute;
			return settingsBindableAttribute != null && this.bindable == settingsBindableAttribute.bindable;
		}

		/// <summary>Specifies that a property is appropriate to bind settings to.</summary>
		// Token: 0x04000445 RID: 1093
		public static readonly SettingsBindableAttribute Yes = new SettingsBindableAttribute(true);

		/// <summary>Specifies that a property is not appropriate to bind settings to.</summary>
		// Token: 0x04000446 RID: 1094
		public static readonly SettingsBindableAttribute No = new SettingsBindableAttribute(false);

		// Token: 0x04000447 RID: 1095
		private bool bindable;
	}
}
