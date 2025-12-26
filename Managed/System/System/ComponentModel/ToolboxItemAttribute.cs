using System;

namespace System.ComponentModel
{
	/// <summary>Represents an attribute of a toolbox item.</summary>
	// Token: 0x020001B0 RID: 432
	[AttributeUsage(AttributeTargets.All)]
	public class ToolboxItemAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ToolboxItemAttribute" /> class and specifies whether to use default initialization values.</summary>
		/// <param name="defaultType">true to create a toolbox item attribute for a default type; false to associate no default toolbox item support for this attribute. </param>
		// Token: 0x06000EFC RID: 3836 RVA: 0x0000C663 File Offset: 0x0000A863
		public ToolboxItemAttribute(bool defaultType)
		{
			if (defaultType)
			{
				this.itemTypeName = "System.Drawing.Design.ToolboxItem, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ToolboxItemAttribute" /> class using the specified name of the type.</summary>
		/// <param name="toolboxItemTypeName">The names of the type of the toolbox item and of the assembly that contains the type. </param>
		// Token: 0x06000EFD RID: 3837 RVA: 0x0000C67C File Offset: 0x0000A87C
		public ToolboxItemAttribute(string toolboxItemName)
		{
			this.itemTypeName = toolboxItemName;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ToolboxItemAttribute" /> class using the specified type of the toolbox item.</summary>
		/// <param name="toolboxItemType">The type of the toolbox item. </param>
		// Token: 0x06000EFE RID: 3838 RVA: 0x0000C68B File Offset: 0x0000A88B
		public ToolboxItemAttribute(Type toolboxItemType)
		{
			this.itemType = toolboxItemType;
		}

		/// <summary>Gets or sets the type of the toolbox item.</summary>
		/// <returns>The type of the toolbox item.</returns>
		/// <exception cref="T:System.ArgumentException">The type cannot be found. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x000365B0 File Offset: 0x000347B0
		public Type ToolboxItemType
		{
			get
			{
				if (this.itemType == null && this.itemTypeName != null)
				{
					try
					{
						this.itemType = Type.GetType(this.itemTypeName, true);
					}
					catch (Exception ex)
					{
						throw new ArgumentException("Failed to create ToolboxItem of type: " + this.itemTypeName, ex);
					}
				}
				return this.itemType;
			}
		}

		/// <summary>Gets or sets the name of the type of the current <see cref="T:System.Drawing.Design.ToolboxItem" />.</summary>
		/// <returns>The fully qualified type name of the current toolbox item.</returns>
		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000F01 RID: 3841 RVA: 0x0000C6B6 File Offset: 0x0000A8B6
		public string ToolboxItemTypeName
		{
			get
			{
				if (this.itemTypeName == null)
				{
					if (this.itemType == null)
					{
						return string.Empty;
					}
					this.itemTypeName = this.itemType.AssemblyQualifiedName;
				}
				return this.itemTypeName;
			}
		}

		/// <param name="obj">The object to compare.</param>
		// Token: 0x06000F02 RID: 3842 RVA: 0x00036620 File Offset: 0x00034820
		public override bool Equals(object o)
		{
			ToolboxItemAttribute toolboxItemAttribute = o as ToolboxItemAttribute;
			return toolboxItemAttribute != null && toolboxItemAttribute.ToolboxItemTypeName == this.ToolboxItemTypeName;
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x0000C6EB File Offset: 0x0000A8EB
		public override int GetHashCode()
		{
			if (this.itemTypeName != null)
			{
				return this.itemTypeName.GetHashCode();
			}
			return base.GetHashCode();
		}

		/// <summary>Gets a value indicating whether the current value of the attribute is the default value for the attribute.</summary>
		/// <returns>true if the current value of the attribute is the default; otherwise, false.</returns>
		// Token: 0x06000F04 RID: 3844 RVA: 0x0000C70A File Offset: 0x0000A90A
		public override bool IsDefaultAttribute()
		{
			return this.Equals(ToolboxItemAttribute.Default);
		}

		// Token: 0x04000448 RID: 1096
		private const string defaultItemType = "System.Drawing.Design.ToolboxItem, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ToolboxItemAttribute" /> class and sets the type to the default, <see cref="T:System.Drawing.Design.ToolboxItem" />. This field is read-only.</summary>
		// Token: 0x04000449 RID: 1097
		public static readonly ToolboxItemAttribute Default = new ToolboxItemAttribute("System.Drawing.Design.ToolboxItem, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ToolboxItemAttribute" /> class and sets the type to null. This field is read-only.</summary>
		// Token: 0x0400044A RID: 1098
		public static readonly ToolboxItemAttribute None = new ToolboxItemAttribute(false);

		// Token: 0x0400044B RID: 1099
		private Type itemType;

		// Token: 0x0400044C RID: 1100
		private string itemTypeName;
	}
}
