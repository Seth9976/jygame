using System;
using System.ComponentModel;

namespace System.Diagnostics
{
	/// <summary>Represents a.dll or .exe file that is loaded into a particular process.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x0200024E RID: 590
	[global::System.ComponentModel.Designer("System.Diagnostics.Design.ProcessModuleDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public class ProcessModule : global::System.ComponentModel.Component
	{
		// Token: 0x06001498 RID: 5272 RVA: 0x0000FF69 File Offset: 0x0000E169
		internal ProcessModule(IntPtr baseaddr, IntPtr entryaddr, string filename, FileVersionInfo version_info, int memory_size, string modulename)
		{
			this.baseaddr = baseaddr;
			this.entryaddr = entryaddr;
			this.filename = filename;
			this.version_info = version_info;
			this.memory_size = memory_size;
			this.modulename = modulename;
		}

		/// <summary>Gets the memory address where the module was loaded.</summary>
		/// <returns>The load address of the module.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06001499 RID: 5273 RVA: 0x0000FF9E File Offset: 0x0000E19E
		[MonitoringDescription("The base memory address of this module")]
		public IntPtr BaseAddress
		{
			get
			{
				return this.baseaddr;
			}
		}

		/// <summary>Gets the memory address for the function that runs when the system loads and runs the module.</summary>
		/// <returns>The entry point of the module.</returns>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x0600149A RID: 5274 RVA: 0x0000FFA6 File Offset: 0x0000E1A6
		[MonitoringDescription("The base memory address of the entry point of this module")]
		public IntPtr EntryPointAddress
		{
			get
			{
				return this.entryaddr;
			}
		}

		/// <summary>Gets the full path to the module.</summary>
		/// <returns>The fully qualified path that defines the location of the module.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x0600149B RID: 5275 RVA: 0x0000FFAE File Offset: 0x0000E1AE
		[MonitoringDescription("The file name of this module")]
		public string FileName
		{
			get
			{
				return this.filename;
			}
		}

		/// <summary>Gets version information about the module.</summary>
		/// <returns>A <see cref="T:System.Diagnostics.FileVersionInfo" /> that contains the module's version information.</returns>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x0600149C RID: 5276 RVA: 0x0000FFB6 File Offset: 0x0000E1B6
		[global::System.ComponentModel.Browsable(false)]
		public FileVersionInfo FileVersionInfo
		{
			get
			{
				return this.version_info;
			}
		}

		/// <summary>Gets the amount of memory that is required to load the module.</summary>
		/// <returns>The size, in bytes, of the memory that the module occupies.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x0600149D RID: 5277 RVA: 0x0000FFBE File Offset: 0x0000E1BE
		[MonitoringDescription("The memory needed by this module")]
		public int ModuleMemorySize
		{
			get
			{
				return this.memory_size;
			}
		}

		/// <summary>Gets the name of the process module.</summary>
		/// <returns>The name of the module.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x0600149E RID: 5278 RVA: 0x0000FFC6 File Offset: 0x0000E1C6
		[MonitoringDescription("The name of this module")]
		public string ModuleName
		{
			get
			{
				return this.modulename;
			}
		}

		/// <summary>Converts the name of the module to a string.</summary>
		/// <returns>The value of the <see cref="P:System.Diagnostics.ProcessModule.ModuleName" /> property.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x0600149F RID: 5279 RVA: 0x0000FFCE File Offset: 0x0000E1CE
		public override string ToString()
		{
			return this.ModuleName;
		}

		// Token: 0x0400062E RID: 1582
		private IntPtr baseaddr;

		// Token: 0x0400062F RID: 1583
		private IntPtr entryaddr;

		// Token: 0x04000630 RID: 1584
		private string filename;

		// Token: 0x04000631 RID: 1585
		private FileVersionInfo version_info;

		// Token: 0x04000632 RID: 1586
		private int memory_size;

		// Token: 0x04000633 RID: 1587
		private string modulename;
	}
}
