using System;

namespace System.ComponentModel
{
	/// <summary>Top level mapping layer between a COM object and TypeDescriptor.</summary>
	// Token: 0x02000158 RID: 344
	[Obsolete("Use TypeDescriptionProvider and TypeDescriptor.ComObjectType instead")]
	public interface IComNativeDescriptorHandler
	{
		// Token: 0x06000C84 RID: 3204
		AttributeCollection GetAttributes(object component);

		// Token: 0x06000C85 RID: 3205
		string GetClassName(object component);

		// Token: 0x06000C86 RID: 3206
		TypeConverter GetConverter(object component);

		// Token: 0x06000C87 RID: 3207
		EventDescriptor GetDefaultEvent(object component);

		// Token: 0x06000C88 RID: 3208
		PropertyDescriptor GetDefaultProperty(object component);

		// Token: 0x06000C89 RID: 3209
		object GetEditor(object component, Type baseEditorType);

		// Token: 0x06000C8A RID: 3210
		EventDescriptorCollection GetEvents(object component);

		// Token: 0x06000C8B RID: 3211
		EventDescriptorCollection GetEvents(object component, Attribute[] attributes);

		// Token: 0x06000C8C RID: 3212
		string GetName(object component);

		// Token: 0x06000C8D RID: 3213
		PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes);

		/// <summary>Retrieves the value of the property that has the specified dispatch identifier.</summary>
		/// <param name="component">The object to which the property belongs.</param>
		/// <param name="dispid">The dispatch identifier.</param>
		/// <param name="success">A <see cref="T:System.Boolean" />, passed by reference, that represents whether or not the property was retrieved. </param>
		// Token: 0x06000C8E RID: 3214
		object GetPropertyValue(object component, int dispid, ref bool success);

		/// <summary>Retrieves the value of the property that has the specified name.</summary>
		/// <param name="component">The object to which the property belongs.</param>
		/// <param name="propertyName">The name of the property.</param>
		/// <param name="success">A <see cref="T:System.Boolean" />, passed by reference, that represents whether or not the property was retrieved. </param>
		// Token: 0x06000C8F RID: 3215
		object GetPropertyValue(object component, string propertyName, ref bool success);
	}
}
