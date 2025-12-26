using System;

namespace System.ComponentModel
{
	/// <summary>Creates an instance of a particular type of property from a drop-down box within the <see cref="T:System.Windows.Forms.PropertyGrid" />. </summary>
	// Token: 0x0200016A RID: 362
	public abstract class InstanceCreationEditor
	{
		/// <summary>Gets the specified text.</summary>
		/// <returns>The specified text.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000CCA RID: 3274 RVA: 0x0000AC35 File Offset: 0x00008E35
		public virtual string Text
		{
			get
			{
				return global::Locale.GetText("(New ...)");
			}
		}

		/// <summary>When overridden in a derived class, returns an instance of the specified type.</summary>
		/// <returns>An instance of the specified type or null.</returns>
		/// <param name="context">The context information.</param>
		/// <param name="instanceType">The specified type.</param>
		// Token: 0x06000CCB RID: 3275
		public abstract object CreateInstance(ITypeDescriptorContext context, Type type);
	}
}
