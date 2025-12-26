using System;
using System.Reflection;

namespace System.ComponentModel
{
	/// <summary>Identifies the property tab or tabs to display for the specified class or classes.</summary>
	// Token: 0x0200019D RID: 413
	[AttributeUsage(AttributeTargets.All)]
	public class PropertyTabAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.PropertyTabAttribute" /> class.</summary>
		// Token: 0x06000E8D RID: 3725 RVA: 0x0000C0CB File Offset: 0x0000A2CB
		public PropertyTabAttribute()
		{
			this.tabs = Type.EmptyTypes;
			this.scopes = new PropertyTabScope[0];
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.PropertyTabAttribute" /> class using the specified tab class name.</summary>
		/// <param name="tabClassName">The assembly qualified name of the type of tab to create. For an example of this format convention, see <see cref="P:System.Type.AssemblyQualifiedName" />. </param>
		// Token: 0x06000E8E RID: 3726 RVA: 0x0000C0EA File Offset: 0x0000A2EA
		public PropertyTabAttribute(string tabClassName)
			: this(tabClassName, PropertyTabScope.Component)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.PropertyTabAttribute" /> class using the specified type of tab.</summary>
		/// <param name="tabClass">The type of tab to create. </param>
		// Token: 0x06000E8F RID: 3727 RVA: 0x0000C0F4 File Offset: 0x0000A2F4
		public PropertyTabAttribute(Type tabClass)
			: this(tabClass, PropertyTabScope.Component)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.PropertyTabAttribute" /> class using the specified tab class name and tab scope.</summary>
		/// <param name="tabClassName">The assembly qualified name of the type of tab to create. For an example of this format convention, see <see cref="P:System.Type.AssemblyQualifiedName" />. </param>
		/// <param name="tabScope">A <see cref="T:System.ComponentModel.PropertyTabScope" /> that indicates the scope of this tab. If the scope is <see cref="F:System.ComponentModel.PropertyTabScope.Component" />, it is shown only for components with the corresponding <see cref="T:System.ComponentModel.PropertyTabAttribute" />. If it is <see cref="F:System.ComponentModel.PropertyTabScope.Document" />, it is shown for all components on the document. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="tabScope" /> is not <see cref="F:System.ComponentModel.PropertyTabScope.Document" /> or <see cref="F:System.ComponentModel.PropertyTabScope.Component" />.</exception>
		// Token: 0x06000E90 RID: 3728 RVA: 0x0000C0FE File Offset: 0x0000A2FE
		public PropertyTabAttribute(string tabClassName, PropertyTabScope tabScope)
		{
			if (tabClassName == null)
			{
				throw new ArgumentNullException("tabClassName");
			}
			this.InitializeArrays(new string[] { tabClassName }, new PropertyTabScope[] { tabScope });
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.PropertyTabAttribute" /> class using the specified type of tab and tab scope.</summary>
		/// <param name="tabClass">The type of tab to create. </param>
		/// <param name="tabScope">A <see cref="T:System.ComponentModel.PropertyTabScope" /> that indicates the scope of this tab. If the scope is <see cref="F:System.ComponentModel.PropertyTabScope.Component" />, it is shown only for components with the corresponding <see cref="T:System.ComponentModel.PropertyTabAttribute" />. If it is <see cref="F:System.ComponentModel.PropertyTabScope.Document" />, it is shown for all components on the document. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="tabScope" /> is not <see cref="F:System.ComponentModel.PropertyTabScope.Document" /> or <see cref="F:System.ComponentModel.PropertyTabScope.Component" />.</exception>
		// Token: 0x06000E91 RID: 3729 RVA: 0x0000C131 File Offset: 0x0000A331
		public PropertyTabAttribute(Type tabClass, PropertyTabScope tabScope)
		{
			if (tabClass == null)
			{
				throw new ArgumentNullException("tabClass");
			}
			this.InitializeArrays(new Type[] { tabClass }, new PropertyTabScope[] { tabScope });
		}

		/// <summary>Gets the types of tabs that this attribute uses.</summary>
		/// <returns>An array of types indicating the types of tabs that this attribute uses.</returns>
		/// <exception cref="T:System.TypeLoadException">The types specified by the <see cref="P:System.ComponentModel.PropertyTabAttribute.TabClassNames" /> property could not be found.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x0000C164 File Offset: 0x0000A364
		public Type[] TabClasses
		{
			get
			{
				return this.tabs;
			}
		}

		/// <summary>Gets an array of tab scopes of each tab of this <see cref="T:System.ComponentModel.PropertyTabAttribute" />.</summary>
		/// <returns>An array of <see cref="T:System.ComponentModel.PropertyTabScope" /> objects that indicate the scopes of the tabs.</returns>
		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000E93 RID: 3731 RVA: 0x0000C16C File Offset: 0x0000A36C
		public PropertyTabScope[] TabScopes
		{
			get
			{
				return this.scopes;
			}
		}

		/// <summary>Gets the names of the tab classes that this attribute uses.</summary>
		/// <returns>The names of the tab classes that this attribute uses.</returns>
		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000E94 RID: 3732 RVA: 0x00035594 File Offset: 0x00033794
		protected string[] TabClassNames
		{
			get
			{
				string[] array = new string[this.tabs.Length];
				for (int i = 0; i < this.tabs.Length; i++)
				{
					array[i] = this.tabs[i].Name;
				}
				return array;
			}
		}

		/// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary>
		/// <returns>true if <paramref name="other" /> refers to the same <see cref="T:System.ComponentModel.PropertyTabAttribute" /> instance; otherwise, false.</returns>
		/// <param name="other">An object to compare to this instance, or null.</param>
		/// <exception cref="T:System.TypeLoadException">The types specified by the <see cref="P:System.ComponentModel.PropertyTabAttribute.TabClassNames" /> property of the<paramref name=" other" /> parameter could not be found.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x06000E95 RID: 3733 RVA: 0x0000C174 File Offset: 0x0000A374
		public override bool Equals(object other)
		{
			return other is PropertyTabAttribute && this.Equals((PropertyTabAttribute)other);
		}

		/// <summary>Returns a value indicating whether this instance is equal to a specified attribute.</summary>
		/// <returns>true if the <see cref="T:System.ComponentModel.PropertyTabAttribute" /> instances are equal; otherwise, false.</returns>
		/// <param name="other">A <see cref="T:System.ComponentModel.PropertyTabAttribute" /> to compare to this instance, or null.</param>
		/// <exception cref="T:System.TypeLoadException">The types specified by the <see cref="P:System.ComponentModel.PropertyTabAttribute.TabClassNames" /> property of the <paramref name="other" /> parameter cannot be found.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x06000E96 RID: 3734 RVA: 0x000355DC File Offset: 0x000337DC
		public bool Equals(PropertyTabAttribute other)
		{
			if (other != this)
			{
				if (other.TabClasses.Length != this.tabs.Length)
				{
					return false;
				}
				for (int i = 0; i < this.tabs.Length; i++)
				{
					if (this.tabs[i] != other.TabClasses[i])
					{
						return false;
					}
				}
			}
			return true;
		}

		/// <summary>Gets the hash code for this object.</summary>
		/// <returns>The hash code for the object the attribute belongs to.</returns>
		// Token: 0x06000E97 RID: 3735 RVA: 0x0000946D File Offset: 0x0000766D
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Initializes the attribute using the specified names of tab classes and array of tab scopes.</summary>
		/// <param name="tabClassNames">An array of fully qualified type names of the types to create for tabs on the Properties window. </param>
		/// <param name="tabScopes">The scope of each tab. If the scope is <see cref="F:System.ComponentModel.PropertyTabScope.Component" />, it is shown only for components with the corresponding <see cref="T:System.ComponentModel.PropertyTabAttribute" />. If it is <see cref="F:System.ComponentModel.PropertyTabScope.Document" />, it is shown for all components on the document. </param>
		/// <exception cref="T:System.ArgumentException">One or more of the values in <paramref name="tabScopes" /> is not <see cref="F:System.ComponentModel.PropertyTabScope.Document" /> or <see cref="F:System.ComponentModel.PropertyTabScope.Component" />.-or-The length of the <paramref name="tabClassNames" /> and <paramref name="tabScopes" /> arrays do not match.-or-<paramref name="tabClassNames" /> or <paramref name="tabScopes" /> is null.</exception>
		// Token: 0x06000E98 RID: 3736 RVA: 0x00035638 File Offset: 0x00033838
		protected void InitializeArrays(string[] tabClassNames, PropertyTabScope[] tabScopes)
		{
			if (tabScopes == null)
			{
				throw new ArgumentNullException("tabScopes");
			}
			if (tabClassNames == null)
			{
				throw new ArgumentNullException("tabClassNames");
			}
			this.scopes = tabScopes;
			this.tabs = new Type[tabClassNames.Length];
			for (int i = 0; i < tabClassNames.Length; i++)
			{
				this.tabs[i] = this.GetTypeFromName(tabClassNames[i]);
			}
		}

		/// <summary>Initializes the attribute using the specified names of tab classes and array of tab scopes.</summary>
		/// <param name="tabClasses">The types of tabs to create. </param>
		/// <param name="tabScopes">The scope of each tab. If the scope is <see cref="F:System.ComponentModel.PropertyTabScope.Component" />, it is shown only for components with the corresponding <see cref="T:System.ComponentModel.PropertyTabAttribute" />. If it is <see cref="F:System.ComponentModel.PropertyTabScope.Document" />, it is shown for all components on the document. </param>
		/// <exception cref="T:System.ArgumentException">One or more of the values in <paramref name="tabScopes" /> is not <see cref="F:System.ComponentModel.PropertyTabScope.Document" /> or <see cref="F:System.ComponentModel.PropertyTabScope.Component" />.-or-The length of the <paramref name="tabClassNames" /> and <paramref name="tabScopes" /> arrays do not match.-or-<paramref name="tabClassNames" /> or <paramref name="tabScopes" /> is null.</exception>
		// Token: 0x06000E99 RID: 3737 RVA: 0x000356A4 File Offset: 0x000338A4
		protected void InitializeArrays(Type[] tabClasses, PropertyTabScope[] tabScopes)
		{
			if (tabScopes == null)
			{
				throw new ArgumentNullException("tabScopes");
			}
			if (tabClasses == null)
			{
				throw new ArgumentNullException("tabClasses");
			}
			if (tabClasses.Length != tabScopes.Length)
			{
				throw new ArgumentException("tabClasses.Length != tabScopes.Length");
			}
			this.tabs = tabClasses;
			this.scopes = tabScopes;
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x000356F8 File Offset: 0x000338F8
		private Type GetTypeFromName(string typeName)
		{
			if (typeName == null)
			{
				throw new ArgumentNullException("typeName");
			}
			int num = typeName.IndexOf(",");
			if (num != -1)
			{
				string text = typeName.Substring(0, num);
				string text2 = typeName.Substring(num + 1);
				Assembly assembly = Assembly.Load(text2);
				if (assembly != null)
				{
					return assembly.GetType(text, true);
				}
			}
			return Type.GetType(typeName, true);
		}

		// Token: 0x04000419 RID: 1049
		private Type[] tabs;

		// Token: 0x0400041A RID: 1050
		private PropertyTabScope[] scopes;
	}
}
