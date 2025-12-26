using System;

namespace System.ComponentModel
{
	/// <summary>Specifies a property that is offered by an extender provider. This class cannot be inherited.</summary>
	// Token: 0x02000151 RID: 337
	[AttributeUsage(AttributeTargets.All)]
	public sealed class ExtenderProvidedPropertyAttribute : Attribute
	{
		// Token: 0x06000C58 RID: 3160 RVA: 0x00031F40 File Offset: 0x00030140
		internal static ExtenderProvidedPropertyAttribute CreateAttribute(PropertyDescriptor extenderProperty, IExtenderProvider provider, Type receiverType)
		{
			return new ExtenderProvidedPropertyAttribute
			{
				extender = extenderProperty,
				receiver = receiverType,
				extenderProvider = provider
			};
		}

		/// <summary>Gets the property that is being provided.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptor" /> encapsulating the property that is being provided.</returns>
		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x0000A9EE File Offset: 0x00008BEE
		public PropertyDescriptor ExtenderProperty
		{
			get
			{
				return this.extender;
			}
		}

		/// <summary>Gets the extender provider that is providing the property.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.IExtenderProvider" /> that is providing the property.</returns>
		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x0000A9F6 File Offset: 0x00008BF6
		public IExtenderProvider Provider
		{
			get
			{
				return this.extenderProvider;
			}
		}

		/// <summary>Gets the type of object that can receive the property.</summary>
		/// <returns>A <see cref="T:System.Type" /> describing the type of object that can receive the property.</returns>
		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000C5B RID: 3163 RVA: 0x0000A9FE File Offset: 0x00008BFE
		public Type ReceiverType
		{
			get
			{
				return this.receiver;
			}
		}

		/// <summary>Provides an indication whether the value of this instance is the default value for the derived class.</summary>
		/// <returns>true if this instance is the default attribute for the class; otherwise, false.</returns>
		// Token: 0x06000C5C RID: 3164 RVA: 0x0000AA06 File Offset: 0x00008C06
		public override bool IsDefaultAttribute()
		{
			return this.extender == null && this.extenderProvider == null && this.receiver == null;
		}

		/// <summary>Determines whether the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Object" />.</summary>
		/// <returns>true if the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Object" />; otherwise, false.</returns>
		/// <param name="obj">An <see cref="T:System.Object" /> to compare with this instance or null. </param>
		// Token: 0x06000C5D RID: 3165 RVA: 0x00031F6C File Offset: 0x0003016C
		public override bool Equals(object obj)
		{
			return obj is ExtenderProvidedPropertyAttribute && (obj == this || (((ExtenderProvidedPropertyAttribute)obj).ExtenderProperty.Equals(this.extender) && ((ExtenderProvidedPropertyAttribute)obj).Provider.Equals(this.extenderProvider) && ((ExtenderProvidedPropertyAttribute)obj).ReceiverType.Equals(this.receiver)));
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000C5E RID: 3166 RVA: 0x0000AA2A File Offset: 0x00008C2A
		public override int GetHashCode()
		{
			return this.extender.GetHashCode() ^ this.extenderProvider.GetHashCode() ^ this.receiver.GetHashCode();
		}

		// Token: 0x04000381 RID: 897
		private PropertyDescriptor extender;

		// Token: 0x04000382 RID: 898
		private IExtenderProvider extenderProvider;

		// Token: 0x04000383 RID: 899
		private Type receiver;
	}
}
