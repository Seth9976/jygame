using System;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Security.Policy;

namespace System.CodeDom.Compiler
{
	/// <summary>Represents the parameters used to invoke a compiler.</summary>
	// Token: 0x02000082 RID: 130
	[PermissionSet((SecurityAction)14, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\nversion=\"1\"\nUnrestricted=\"true\"/>\n")]
	[PermissionSet((SecurityAction)15, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\nversion=\"1\"\nUnrestricted=\"true\"/>\n")]
	[Serializable]
	public class CompilerParameters
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.Compiler.CompilerParameters" /> class.</summary>
		// Token: 0x06000555 RID: 1365 RVA: 0x00005A2F File Offset: 0x00003C2F
		public CompilerParameters()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.Compiler.CompilerParameters" /> class using the specified assembly names.</summary>
		/// <param name="assemblyNames">The names of the assemblies to reference. </param>
		// Token: 0x06000556 RID: 1366 RVA: 0x00005A49 File Offset: 0x00003C49
		public CompilerParameters(string[] assemblyNames)
		{
			this.referencedAssemblies = new global::System.Collections.Specialized.StringCollection();
			this.referencedAssemblies.AddRange(assemblyNames);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.Compiler.CompilerParameters" /> class using the specified assembly names and output file name.</summary>
		/// <param name="assemblyNames">The names of the assemblies to reference. </param>
		/// <param name="outputName">The output file name. </param>
		// Token: 0x06000557 RID: 1367 RVA: 0x00005A7A File Offset: 0x00003C7A
		public CompilerParameters(string[] assemblyNames, string output)
		{
			this.referencedAssemblies = new global::System.Collections.Specialized.StringCollection();
			this.referencedAssemblies.AddRange(assemblyNames);
			this.outputAssembly = output;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.Compiler.CompilerParameters" /> class using the specified assembly names, output name, and a value indicating whether to include debug information.</summary>
		/// <param name="assemblyNames">The names of the assemblies to reference. </param>
		/// <param name="outputName">The output file name. </param>
		/// <param name="includeDebugInformation">true if debug information should be included; false if debug information should be excluded. </param>
		// Token: 0x06000558 RID: 1368 RVA: 0x00005AB2 File Offset: 0x00003CB2
		public CompilerParameters(string[] assemblyNames, string output, bool includeDebugInfo)
		{
			this.referencedAssemblies = new global::System.Collections.Specialized.StringCollection();
			this.referencedAssemblies.AddRange(assemblyNames);
			this.outputAssembly = output;
			this.includeDebugInformation = includeDebugInfo;
		}

		/// <summary>Gets or sets the optional additional-command line arguments string to use when invoking the compiler.</summary>
		/// <returns>Any additional command line arguments for the compiler.</returns>
		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x00005AF1 File Offset: 0x00003CF1
		// (set) Token: 0x0600055A RID: 1370 RVA: 0x00005AF9 File Offset: 0x00003CF9
		public string CompilerOptions
		{
			get
			{
				return this.compilerOptions;
			}
			set
			{
				this.compilerOptions = value;
			}
		}

		/// <summary>Specifies an evidence object that represents the security policy permissions to grant the compiled assembly.</summary>
		/// <returns>An <see cref="T:System.Security.Policy.Evidence" /> object that represents the security policy permissions to grant the compiled assembly.</returns>
		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x00005B02 File Offset: 0x00003D02
		// (set) Token: 0x0600055C RID: 1372 RVA: 0x00005B0A File Offset: 0x00003D0A
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

		/// <summary>Gets or sets a value indicating whether to generate an executable.</summary>
		/// <returns>true if an executable should be generated; otherwise, false.</returns>
		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x00005B13 File Offset: 0x00003D13
		// (set) Token: 0x0600055E RID: 1374 RVA: 0x00005B1B File Offset: 0x00003D1B
		public bool GenerateExecutable
		{
			get
			{
				return this.generateExecutable;
			}
			set
			{
				this.generateExecutable = value;
			}
		}

		/// <summary>Gets or sets a value indicating whether to generate the output in memory.</summary>
		/// <returns>true if the compiler should generate the output in memory; otherwise, false.</returns>
		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x00005B24 File Offset: 0x00003D24
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x00005B2C File Offset: 0x00003D2C
		public bool GenerateInMemory
		{
			get
			{
				return this.generateInMemory;
			}
			set
			{
				this.generateInMemory = value;
			}
		}

		/// <summary>Gets or sets a value indicating whether to include debug information in the compiled executable.</summary>
		/// <returns>true if debug information should be generated; otherwise, false.</returns>
		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x00005B35 File Offset: 0x00003D35
		// (set) Token: 0x06000562 RID: 1378 RVA: 0x00005B3D File Offset: 0x00003D3D
		public bool IncludeDebugInformation
		{
			get
			{
				return this.includeDebugInformation;
			}
			set
			{
				this.includeDebugInformation = value;
			}
		}

		/// <summary>Gets or sets the name of the main class.</summary>
		/// <returns>The name of the main class.</returns>
		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x00005B46 File Offset: 0x00003D46
		// (set) Token: 0x06000564 RID: 1380 RVA: 0x00005B4E File Offset: 0x00003D4E
		public string MainClass
		{
			get
			{
				return this.mainClass;
			}
			set
			{
				this.mainClass = value;
			}
		}

		/// <summary>Gets or sets the name of the output assembly.</summary>
		/// <returns>The name of the output assembly.</returns>
		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x00005B57 File Offset: 0x00003D57
		// (set) Token: 0x06000566 RID: 1382 RVA: 0x00005B5F File Offset: 0x00003D5F
		public string OutputAssembly
		{
			get
			{
				return this.outputAssembly;
			}
			set
			{
				this.outputAssembly = value;
			}
		}

		/// <summary>Gets the assemblies referenced by the current project.</summary>
		/// <returns>A <see cref="T:System.Collections.Specialized.StringCollection" /> that contains the assembly names that are referenced by the source to compile.</returns>
		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x00005B68 File Offset: 0x00003D68
		public global::System.Collections.Specialized.StringCollection ReferencedAssemblies
		{
			get
			{
				if (this.referencedAssemblies == null)
				{
					this.referencedAssemblies = new global::System.Collections.Specialized.StringCollection();
				}
				return this.referencedAssemblies;
			}
		}

		/// <summary>Gets or sets the collection that contains the temporary files.</summary>
		/// <returns>A <see cref="T:System.CodeDom.Compiler.TempFileCollection" /> that contains the temporary files.</returns>
		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x00005B86 File Offset: 0x00003D86
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x00005BA4 File Offset: 0x00003DA4
		public TempFileCollection TempFiles
		{
			get
			{
				if (this.tempFiles == null)
				{
					this.tempFiles = new TempFileCollection();
				}
				return this.tempFiles;
			}
			set
			{
				this.tempFiles = value;
			}
		}

		/// <summary>Gets or sets a value indicating whether to treat warnings as errors.</summary>
		/// <returns>true if warnings should be treated as errors; otherwise, false.</returns>
		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x00005BAD File Offset: 0x00003DAD
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x00005BB5 File Offset: 0x00003DB5
		public bool TreatWarningsAsErrors
		{
			get
			{
				return this.treatWarningsAsErrors;
			}
			set
			{
				this.treatWarningsAsErrors = value;
			}
		}

		/// <summary>Gets or sets the user token to use when creating the compiler process.</summary>
		/// <returns>The user token to use.</returns>
		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x00005BBE File Offset: 0x00003DBE
		// (set) Token: 0x0600056D RID: 1389 RVA: 0x00005BC6 File Offset: 0x00003DC6
		public IntPtr UserToken
		{
			get
			{
				return this.userToken;
			}
			set
			{
				this.userToken = value;
			}
		}

		/// <summary>Gets or sets the warning level at which the compiler aborts compilation.</summary>
		/// <returns>The warning level at which the compiler aborts compilation.</returns>
		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x00005BCF File Offset: 0x00003DCF
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x00005BD7 File Offset: 0x00003DD7
		public int WarningLevel
		{
			get
			{
				return this.warningLevel;
			}
			set
			{
				this.warningLevel = value;
			}
		}

		/// <summary>Gets or sets the file name of a Win32 resource file to link into the compiled assembly.</summary>
		/// <returns>A Win32 resource file that will be linked into the compiled assembly.</returns>
		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x00005BE0 File Offset: 0x00003DE0
		// (set) Token: 0x06000571 RID: 1393 RVA: 0x00005BE8 File Offset: 0x00003DE8
		public string Win32Resource
		{
			get
			{
				return this.win32Resource;
			}
			set
			{
				this.win32Resource = value;
			}
		}

		/// <summary>Gets the .NET Framework resource files to include when compiling the assembly output.</summary>
		/// <returns>A <see cref="T:System.Collections.Specialized.StringCollection" /> containing the file paths of .NET Framework resources to include in the generated assembly.</returns>
		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x00005BF1 File Offset: 0x00003DF1
		[ComVisible(false)]
		public global::System.Collections.Specialized.StringCollection EmbeddedResources
		{
			get
			{
				if (this.embedded_resources == null)
				{
					this.embedded_resources = new global::System.Collections.Specialized.StringCollection();
				}
				return this.embedded_resources;
			}
		}

		/// <summary>Gets the .NET Framework resource files that are referenced in the current source.</summary>
		/// <returns>A <see cref="T:System.Collections.Specialized.StringCollection" /> containing the file paths of .NET Framework resources that are referenced by the source.</returns>
		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x00005C0F File Offset: 0x00003E0F
		[ComVisible(false)]
		public global::System.Collections.Specialized.StringCollection LinkedResources
		{
			get
			{
				if (this.linked_resources == null)
				{
					this.linked_resources = new global::System.Collections.Specialized.StringCollection();
				}
				return this.linked_resources;
			}
		}

		// Token: 0x04000145 RID: 325
		private string compilerOptions;

		// Token: 0x04000146 RID: 326
		private Evidence evidence;

		// Token: 0x04000147 RID: 327
		private bool generateExecutable;

		// Token: 0x04000148 RID: 328
		private bool generateInMemory;

		// Token: 0x04000149 RID: 329
		private bool includeDebugInformation;

		// Token: 0x0400014A RID: 330
		private string mainClass;

		// Token: 0x0400014B RID: 331
		private string outputAssembly;

		// Token: 0x0400014C RID: 332
		private global::System.Collections.Specialized.StringCollection referencedAssemblies;

		// Token: 0x0400014D RID: 333
		private TempFileCollection tempFiles;

		// Token: 0x0400014E RID: 334
		private bool treatWarningsAsErrors;

		// Token: 0x0400014F RID: 335
		private IntPtr userToken = IntPtr.Zero;

		// Token: 0x04000150 RID: 336
		private int warningLevel = -1;

		// Token: 0x04000151 RID: 337
		private string win32Resource;

		// Token: 0x04000152 RID: 338
		private global::System.Collections.Specialized.StringCollection embedded_resources;

		// Token: 0x04000153 RID: 339
		private global::System.Collections.Specialized.StringCollection linked_resources;
	}
}
