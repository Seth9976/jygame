using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Security.Permissions;
using Mono.CSharp;

namespace Microsoft.CSharp
{
	/// <summary>Provides access to instances of the C# code generator and code compiler.</summary>
	// Token: 0x0200000D RID: 13
	[PermissionSet((SecurityAction)15, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\nversion=\"1\"\nUnrestricted=\"true\"/>\n")]
	[PermissionSet((SecurityAction)14, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\nversion=\"1\"\nUnrestricted=\"true\"/>\n")]
	public class CSharpCodeProvider : global::System.CodeDom.Compiler.CodeDomProvider
	{
		/// <summary>Initializes a new instance of the <see cref="T:Microsoft.CSharp.CSharpCodeProvider" /> class. </summary>
		// Token: 0x06000079 RID: 121 RVA: 0x000025E8 File Offset: 0x000007E8
		public CSharpCodeProvider()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:Microsoft.CSharp.CSharpCodeProvider" /> class by using the specified provider options. </summary>
		/// <param name="providerOptions">A <see cref="T:System.Collections.Generic.IDictionary`2" /> object that contains the provider options from the configuration file.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="providerOptions" /> is null.</exception>
		// Token: 0x0600007A RID: 122 RVA: 0x000025F0 File Offset: 0x000007F0
		public CSharpCodeProvider(IDictionary<string, string> providerOptions)
		{
			this.providerOptions = providerOptions;
		}

		/// <summary>Gets the file name extension to use when creating source code files.</summary>
		/// <returns>The file name extension to use for generated source code files.</returns>
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000025FF File Offset: 0x000007FF
		public override string FileExtension
		{
			get
			{
				return "cs";
			}
		}

		/// <summary>Gets an instance of the C# code compiler.</summary>
		/// <returns>An instance of the C# <see cref="T:System.CodeDom.Compiler.ICodeCompiler" /> implementation.</returns>
		// Token: 0x0600007C RID: 124 RVA: 0x00002606 File Offset: 0x00000806
		[Obsolete("Use CodeDomProvider class")]
		public override global::System.CodeDom.Compiler.ICodeCompiler CreateCompiler()
		{
			if (this.providerOptions != null && this.providerOptions.Count > 0)
			{
				return new Mono.CSharp.CSharpCodeCompiler(this.providerOptions);
			}
			return new Mono.CSharp.CSharpCodeCompiler();
		}

		/// <summary>Gets an instance of the C# code generator.</summary>
		/// <returns>An instance of the C# <see cref="T:System.CodeDom.Compiler.ICodeGenerator" /> implementation.</returns>
		// Token: 0x0600007D RID: 125 RVA: 0x00002635 File Offset: 0x00000835
		[Obsolete("Use CodeDomProvider class")]
		public override global::System.CodeDom.Compiler.ICodeGenerator CreateGenerator()
		{
			if (this.providerOptions != null && this.providerOptions.Count > 0)
			{
				return new Mono.CSharp.CSharpCodeGenerator(this.providerOptions);
			}
			return new Mono.CSharp.CSharpCodeGenerator();
		}

		/// <summary>Gets a <see cref="T:System.ComponentModel.TypeConverter" /> for the specified type of object.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.TypeConverter" /> for the specified type.</returns>
		/// <param name="type">The type of object to retrieve a type converter for. </param>
		// Token: 0x0600007E RID: 126 RVA: 0x00002664 File Offset: 0x00000864
		[global::System.MonoTODO]
		public override global::System.ComponentModel.TypeConverter GetConverter(Type Type)
		{
			throw new NotImplementedException();
		}

		/// <summary>Generates code for the specified class member using the specified text writer and code generator options.</summary>
		/// <param name="member">A <see cref="T:System.CodeDom.CodeTypeMember" /> to generate code for.</param>
		/// <param name="writer">The <see cref="T:System.IO.TextWriter" /> to write to.</param>
		/// <param name="options">The <see cref="T:System.CodeDom.Compiler.CodeGeneratorOptions" /> to use when generating the code.</param>
		// Token: 0x0600007F RID: 127 RVA: 0x00002664 File Offset: 0x00000864
		[global::System.MonoTODO]
		public override void GenerateCodeFromMember(global::System.CodeDom.CodeTypeMember member, TextWriter writer, global::System.CodeDom.Compiler.CodeGeneratorOptions options)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0400002A RID: 42
		private IDictionary<string, string> providerOptions;
	}
}
