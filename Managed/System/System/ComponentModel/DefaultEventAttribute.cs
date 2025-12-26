using System;

namespace System.ComponentModel
{
	/// <summary>Specifies the default event for a component.</summary>
	// Token: 0x020000F3 RID: 243
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class DefaultEventAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultEventAttribute" /> class.</summary>
		/// <param name="name">The name of the default event for the component this attribute is bound to. </param>
		// Token: 0x060009F0 RID: 2544 RVA: 0x0000947D File Offset: 0x0000767D
		public DefaultEventAttribute(string name)
		{
			this.eventName = name;
		}

		/// <summary>Gets the name of the default event for the component this attribute is bound to.</summary>
		/// <returns>The name of the default event for the component this attribute is bound to. The default value is null.</returns>
		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x00009499 File Offset: 0x00007699
		public string Name
		{
			get
			{
				return this.eventName;
			}
		}

		/// <summary>Returns whether the value of the given object is equal to the current <see cref="T:System.ComponentModel.DefaultEventAttribute" />.</summary>
		/// <returns>true if the value of the given object is equal to that of the current; otherwise, false.</returns>
		/// <param name="obj">The object to test the value equality of. </param>
		// Token: 0x060009F3 RID: 2547 RVA: 0x000094A1 File Offset: 0x000076A1
		public override bool Equals(object o)
		{
			return o is DefaultEventAttribute && ((DefaultEventAttribute)o).eventName == this.eventName;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x060009F4 RID: 2548 RVA: 0x0000946D File Offset: 0x0000766D
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x040002AF RID: 687
		private string eventName;

		/// <summary>Specifies the default value for the <see cref="T:System.ComponentModel.DefaultEventAttribute" />, which is null. This static field is read-only.</summary>
		// Token: 0x040002B0 RID: 688
		public static readonly DefaultEventAttribute Default = new DefaultEventAttribute(null);
	}
}
