using System;

namespace System.ComponentModel
{
	/// <summary>Specifies whether the Visual Studio Custom Action Installer or the Installer Tool (Installutil.exe) should be invoked when the assembly is installed.</summary>
	// Token: 0x020001A8 RID: 424
	[AttributeUsage(AttributeTargets.Class)]
	public class RunInstallerAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.RunInstallerAttribute" /> class.</summary>
		/// <param name="runInstaller">true if an installer should be invoked during installation of an assembly; otherwise, false. </param>
		// Token: 0x06000EDA RID: 3802 RVA: 0x0000C4B9 File Offset: 0x0000A6B9
		public RunInstallerAttribute(bool runInstaller)
		{
			this.runInstaller = runInstaller;
		}

		/// <summary>Determines whether the value of the specified <see cref="T:System.ComponentModel.RunInstallerAttribute" /> is equivalent to the current <see cref="T:System.ComponentModel.RunInstallerAttribute" />.</summary>
		/// <returns>true if the specified <see cref="T:System.ComponentModel.RunInstallerAttribute" /> is equal to the current <see cref="T:System.ComponentModel.RunInstallerAttribute" />; otherwise, false.</returns>
		/// <param name="obj">The object to compare.</param>
		// Token: 0x06000EDC RID: 3804 RVA: 0x000363F8 File Offset: 0x000345F8
		public override bool Equals(object obj)
		{
			return obj is RunInstallerAttribute && ((RunInstallerAttribute)obj).RunInstaller.Equals(this.runInstaller);
		}

		/// <summary>Generates a hash code for the current <see cref="T:System.ComponentModel.RunInstallerAttribute" />.</summary>
		/// <returns>A hash code for the current <see cref="T:System.ComponentModel.RunInstallerAttribute" />.</returns>
		// Token: 0x06000EDD RID: 3805 RVA: 0x0000C4EB File Offset: 0x0000A6EB
		public override int GetHashCode()
		{
			return this.runInstaller.GetHashCode();
		}

		/// <summary>Determines if this attribute is the default.</summary>
		/// <returns>true if the attribute is the default value for this attribute class; otherwise, false.</returns>
		// Token: 0x06000EDE RID: 3806 RVA: 0x0000C4F8 File Offset: 0x0000A6F8
		public override bool IsDefaultAttribute()
		{
			return this.Equals(RunInstallerAttribute.Default);
		}

		/// <summary>Gets a value indicating whether an installer should be invoked during installation of an assembly.</summary>
		/// <returns>true if an installer should be invoked during installation of an assembly; otherwise, false.</returns>
		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000EDF RID: 3807 RVA: 0x0000C505 File Offset: 0x0000A705
		public bool RunInstaller
		{
			get
			{
				return this.runInstaller;
			}
		}

		/// <summary>Specifies that the Visual Studio Custom Action Installer or the Installer Tool (Installutil.exe) should be invoked when the assembly is installed. This static field is read-only.</summary>
		// Token: 0x04000440 RID: 1088
		public static readonly RunInstallerAttribute Yes = new RunInstallerAttribute(true);

		/// <summary>Specifies that the Visual Studio Custom Action Installer or the Installer Tool (Installutil.exe) should not be invoked when the assembly is installed. This static field is read-only.</summary>
		// Token: 0x04000441 RID: 1089
		public static readonly RunInstallerAttribute No = new RunInstallerAttribute(false);

		/// <summary>Specifies the default visiblity, which is <see cref="F:System.ComponentModel.RunInstallerAttribute.No" />. This static field is read-only.</summary>
		// Token: 0x04000442 RID: 1090
		public static readonly RunInstallerAttribute Default = new RunInstallerAttribute(false);

		// Token: 0x04000443 RID: 1091
		private bool runInstaller;
	}
}
