using System;
using System.Runtime.InteropServices;

namespace System.CodeDom
{
	/// <summary>Represents an argument used in a metadata attribute declaration.</summary>
	// Token: 0x02000027 RID: 39
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[ComVisible(true)]
	[Serializable]
	public class CodeAttributeArgument
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeAttributeArgument" /> class.</summary>
		// Token: 0x06000165 RID: 357 RVA: 0x000021C3 File Offset: 0x000003C3
		public CodeAttributeArgument()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeAttributeArgument" /> class using the specified value.</summary>
		/// <param name="value">A <see cref="T:System.CodeDom.CodeExpression" /> that represents the value of the argument. </param>
		// Token: 0x06000166 RID: 358 RVA: 0x00002E00 File Offset: 0x00001000
		public CodeAttributeArgument(CodeExpression value)
		{
			this.value = value;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeAttributeArgument" /> class using the specified name and value.</summary>
		/// <param name="name">The name of the attribute property the argument applies to. </param>
		/// <param name="value">A <see cref="T:System.CodeDom.CodeExpression" /> that represents the value of the argument. </param>
		// Token: 0x06000167 RID: 359 RVA: 0x00002E0F File Offset: 0x0000100F
		public CodeAttributeArgument(string name, CodeExpression value)
		{
			this.name = name;
			this.value = value;
		}

		/// <summary>Gets or sets the name of the attribute.</summary>
		/// <returns>The name of the attribute property the argument is for.</returns>
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00002E25 File Offset: 0x00001025
		// (set) Token: 0x06000169 RID: 361 RVA: 0x00002E3E File Offset: 0x0000103E
		public string Name
		{
			get
			{
				if (this.name == null)
				{
					return string.Empty;
				}
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		/// <summary>Gets or sets the value for the attribute argument.</summary>
		/// <returns>A <see cref="T:System.CodeDom.CodeExpression" /> that indicates the value for the attribute argument.</returns>
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00002E47 File Offset: 0x00001047
		// (set) Token: 0x0600016B RID: 363 RVA: 0x00002E4F File Offset: 0x0000104F
		public CodeExpression Value
		{
			get
			{
				return this.value;
			}
			set
			{
				this.value = value;
			}
		}

		// Token: 0x0400006A RID: 106
		private string name;

		// Token: 0x0400006B RID: 107
		private CodeExpression value;
	}
}
