using System;
using System.Collections.Specialized;
using System.Reflection;
using System.Security.Permissions;
using System.Security.Policy;

namespace System.CodeDom.Compiler
{
	/// <summary>Represents the results of compilation that are returned from a compiler.</summary>
	// Token: 0x02000085 RID: 133
	[PermissionSet((SecurityAction)14, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\nversion=\"1\"\nUnrestricted=\"true\"/>\n")]
	[PermissionSet((SecurityAction)15, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\nversion=\"1\"\nUnrestricted=\"true\"/>\n")]
	[Serializable]
	public class CompilerResults
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.Compiler.CompilerResults" /> class that uses the specified temporary files.</summary>
		/// <param name="tempFiles">A <see cref="T:System.CodeDom.Compiler.TempFileCollection" /> with which to manage and store references to intermediate files generated during compilation. </param>
		// Token: 0x06000588 RID: 1416 RVA: 0x00005CBE File Offset: 0x00003EBE
		public CompilerResults(TempFileCollection tempFiles)
		{
			this.tempFiles = tempFiles;
		}

		/// <summary>Gets or sets the compiled assembly.</summary>
		/// <returns>An <see cref="T:System.Reflection.Assembly" /> that indicates the compiled assembly.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x00005CE3 File Offset: 0x00003EE3
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x00005D12 File Offset: 0x00003F12
		public Assembly CompiledAssembly
		{
			get
			{
				if (this.compiledAssembly == null && this.pathToAssembly != null)
				{
					this.compiledAssembly = Assembly.LoadFrom(this.pathToAssembly);
				}
				return this.compiledAssembly;
			}
			set
			{
				this.compiledAssembly = value;
			}
		}

		/// <summary>Gets the collection of compiler errors and warnings.</summary>
		/// <returns>A <see cref="T:System.CodeDom.Compiler.CompilerErrorCollection" /> that indicates the errors and warnings resulting from compilation, if any.</returns>
		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00005D1B File Offset: 0x00003F1B
		public CompilerErrorCollection Errors
		{
			get
			{
				if (this.errors == null)
				{
					this.errors = new CompilerErrorCollection();
				}
				return this.errors;
			}
		}

		/// <summary>Indicates the evidence object that represents the security policy permissions of the compiled assembly.</summary>
		/// <returns>An <see cref="T:System.Security.Policy.Evidence" /> object that represents the security policy permissions of the compiled assembly.</returns>
		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x00005D39 File Offset: 0x00003F39
		// (set) Token: 0x0600058D RID: 1421 RVA: 0x00005D41 File Offset: 0x00003F41
		public Evidence Evidence
		{
			get
			{
				return this.evidence;
			}
			[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\nversion=\"1\">\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\nversion=\"1\"\nFlags=\"ControlEvidence\"/>\n</PermissionSet>\n")]
			set
			{
				this.evidence = value;
			}
		}

		/// <summary>Gets or sets the compiler's return value.</summary>
		/// <returns>The compiler's return value.</returns>
		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x00005D4A File Offset: 0x00003F4A
		// (set) Token: 0x0600058F RID: 1423 RVA: 0x00005D52 File Offset: 0x00003F52
		public int NativeCompilerReturnValue
		{
			get
			{
				return this.nativeCompilerReturnValue;
			}
			set
			{
				this.nativeCompilerReturnValue = value;
			}
		}

		/// <summary>Gets the compiler output messages.</summary>
		/// <returns>A <see cref="T:System.Collections.Specialized.StringCollection" /> that contains the output messages.</returns>
		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x00005D5B File Offset: 0x00003F5B
		// (set) Token: 0x06000591 RID: 1425 RVA: 0x00005D79 File Offset: 0x00003F79
		public global::System.Collections.Specialized.StringCollection Output
		{
			get
			{
				if (this.output == null)
				{
					this.output = new global::System.Collections.Specialized.StringCollection();
				}
				return this.output;
			}
			internal set
			{
				this.output = value;
			}
		}

		/// <summary>Gets or sets the path of the compiled assembly.</summary>
		/// <returns>The path of the assembly, or null if the assembly was generated in memory.</returns>
		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x00005D82 File Offset: 0x00003F82
		// (set) Token: 0x06000593 RID: 1427 RVA: 0x00005D8A File Offset: 0x00003F8A
		public string PathToAssembly
		{
			get
			{
				return this.pathToAssembly;
			}
			set
			{
				this.pathToAssembly = value;
			}
		}

		/// <summary>Gets or sets the temporary file collection to use.</summary>
		/// <returns>A <see cref="T:System.CodeDom.Compiler.TempFileCollection" /> with which to manage and store references to intermediate files generated during compilation.</returns>
		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x00005D93 File Offset: 0x00003F93
		// (set) Token: 0x06000595 RID: 1429 RVA: 0x00005D9B File Offset: 0x00003F9B
		public TempFileCollection TempFiles
		{
			get
			{
				return this.tempFiles;
			}
			set
			{
				this.tempFiles = value;
			}
		}

		// Token: 0x04000158 RID: 344
		private Assembly compiledAssembly;

		// Token: 0x04000159 RID: 345
		private CompilerErrorCollection errors = new CompilerErrorCollection();

		// Token: 0x0400015A RID: 346
		private Evidence evidence;

		// Token: 0x0400015B RID: 347
		private int nativeCompilerReturnValue;

		// Token: 0x0400015C RID: 348
		private global::System.Collections.Specialized.StringCollection output = new global::System.Collections.Specialized.StringCollection();

		// Token: 0x0400015D RID: 349
		private string pathToAssembly;

		// Token: 0x0400015E RID: 350
		private TempFileCollection tempFiles;
	}
}
