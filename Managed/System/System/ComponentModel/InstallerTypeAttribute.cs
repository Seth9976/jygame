using System;

namespace System.ComponentModel
{
	/// <summary>Specifies the installer for a type that installs components.</summary>
	// Token: 0x02000169 RID: 361
	[AttributeUsage(AttributeTargets.Class)]
	public class InstallerTypeAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.InstallerTypeAttribute" /> class with the name of the component's installer type.</summary>
		/// <param name="typeName">The name of a <see cref="T:System.Type" /> that represents the installer for the component this attribute is bound to. This class must implement <see cref="T:System.ComponentModel.Design.IDesigner" />. </param>
		// Token: 0x06000CC4 RID: 3268 RVA: 0x0000ABD1 File Offset: 0x00008DD1
		public InstallerTypeAttribute(string typeName)
		{
			this.installer = Type.GetType(typeName, false);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.InstallerTypeAttribute" /> class, when given a <see cref="T:System.Type" /> that represents the installer for a component.</summary>
		/// <param name="installerType">A <see cref="T:System.Type" /> that represents the installer for the component this attribute is bound to. This class must implement <see cref="T:System.ComponentModel.Design.IDesigner" />. </param>
		// Token: 0x06000CC5 RID: 3269 RVA: 0x0000ABE6 File Offset: 0x00008DE6
		public InstallerTypeAttribute(Type installerType)
		{
			this.installer = installerType;
		}

		/// <summary>Gets the type of installer associated with this attribute.</summary>
		/// <returns>A <see cref="T:System.Type" /> that represents the type of installer associated with this attribute, or null if an installer does not exist.</returns>
		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x0000ABF5 File Offset: 0x00008DF5
		public virtual Type InstallerType
		{
			get
			{
				return this.installer;
			}
		}

		/// <summary>Returns whether the value of the given object is equal to the current <see cref="T:System.ComponentModel.InstallerTypeAttribute" />.</summary>
		/// <returns>true if the value of the given object is equal to that of the current; otherwise, false.</returns>
		/// <param name="obj">The object to test the value equality of. </param>
		// Token: 0x06000CC7 RID: 3271 RVA: 0x0000ABFD File Offset: 0x00008DFD
		public override bool Equals(object obj)
		{
			return obj is InstallerTypeAttribute && (obj == this || ((InstallerTypeAttribute)obj).InstallerType == this.installer);
		}

		/// <summary>Returns the hashcode for this object.</summary>
		/// <returns>A hash code for the current <see cref="T:System.ComponentModel.InstallerTypeAttribute" />.</returns>
		// Token: 0x06000CC8 RID: 3272 RVA: 0x0000AC28 File Offset: 0x00008E28
		public override int GetHashCode()
		{
			return this.installer.GetHashCode();
		}

		// Token: 0x04000393 RID: 915
		private Type installer;
	}
}
