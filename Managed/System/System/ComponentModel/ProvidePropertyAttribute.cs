using System;

namespace System.ComponentModel
{
	/// <summary>Specifies the name of the property that an implementer of <see cref="T:System.ComponentModel.IExtenderProvider" /> offers to other components. This class cannot be inherited</summary>
	// Token: 0x0200019F RID: 415
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
	public sealed class ProvidePropertyAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ProvidePropertyAttribute" /> class with the name of the property and the type of its receiver.</summary>
		/// <param name="propertyName">The name of the property extending to an object of the specified type. </param>
		/// <param name="receiverTypeName">The name of the data type this property can extend. </param>
		// Token: 0x06000E9B RID: 3739 RVA: 0x0000C18F File Offset: 0x0000A38F
		public ProvidePropertyAttribute(string propertyName, string receiverTypeName)
		{
			this.Property = propertyName;
			this.Receiver = receiverTypeName;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ProvidePropertyAttribute" /> class with the name of the property and its <see cref="T:System.Type" />.</summary>
		/// <param name="propertyName">The name of the property extending to an object of the specified type. </param>
		/// <param name="receiverType">The <see cref="T:System.Type" /> of the data type of the object that can receive the property. </param>
		// Token: 0x06000E9C RID: 3740 RVA: 0x0000C1A5 File Offset: 0x0000A3A5
		public ProvidePropertyAttribute(string propertyName, Type receiverType)
		{
			this.Property = propertyName;
			this.Receiver = receiverType.AssemblyQualifiedName;
		}

		/// <summary>Gets the name of a property that this class provides.</summary>
		/// <returns>The name of a property that this class provides.</returns>
		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000E9D RID: 3741 RVA: 0x0000C1C0 File Offset: 0x0000A3C0
		public string PropertyName
		{
			get
			{
				return this.Property;
			}
		}

		/// <summary>Gets the name of the data type this property can extend.</summary>
		/// <returns>The name of the data type this property can extend.</returns>
		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000E9E RID: 3742 RVA: 0x0000C1C8 File Offset: 0x0000A3C8
		public string ReceiverTypeName
		{
			get
			{
				return this.Receiver;
			}
		}

		/// <summary>Gets a unique identifier for this attribute.</summary>
		/// <returns>An <see cref="T:System.Object" /> that is a unique identifier for the attribute.</returns>
		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000E9F RID: 3743 RVA: 0x0000C1D0 File Offset: 0x0000A3D0
		public override object TypeId
		{
			get
			{
				return base.TypeId + this.Property;
			}
		}

		/// <summary>Returns whether the value of the given object is equal to the current <see cref="T:System.ComponentModel.ProvidePropertyAttribute" />.</summary>
		/// <returns>true if the value of the given object is equal to that of the current; otherwise, false.</returns>
		/// <param name="obj">The object to test the value equality of. </param>
		// Token: 0x06000EA0 RID: 3744 RVA: 0x0003575C File Offset: 0x0003395C
		public override bool Equals(object obj)
		{
			return obj is ProvidePropertyAttribute && (obj == this || (((ProvidePropertyAttribute)obj).PropertyName == this.Property && ((ProvidePropertyAttribute)obj).ReceiverTypeName == this.Receiver));
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A hash code for the current <see cref="T:System.ComponentModel.ProvidePropertyAttribute" />.</returns>
		// Token: 0x06000EA1 RID: 3745 RVA: 0x0000C1E3 File Offset: 0x0000A3E3
		public override int GetHashCode()
		{
			return (this.Property + this.Receiver).GetHashCode();
		}

		// Token: 0x04000420 RID: 1056
		private string Property;

		// Token: 0x04000421 RID: 1057
		private string Receiver;
	}
}
