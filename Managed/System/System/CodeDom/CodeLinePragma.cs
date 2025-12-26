using System;
using System.Runtime.InteropServices;

namespace System.CodeDom
{
	/// <summary>Represents a specific location within a specific file.</summary>
	// Token: 0x02000047 RID: 71
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[Serializable]
	public class CodeLinePragma
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeLinePragma" /> class. </summary>
		// Token: 0x0600024B RID: 587 RVA: 0x000021C3 File Offset: 0x000003C3
		public CodeLinePragma()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeLinePragma" /> class.</summary>
		/// <param name="fileName">The file name of the associated file. </param>
		/// <param name="lineNumber">The line number to store a reference to. </param>
		// Token: 0x0600024C RID: 588 RVA: 0x0000383F File Offset: 0x00001A3F
		public CodeLinePragma(string fileName, int lineNumber)
		{
			this.fileName = fileName;
			this.lineNumber = lineNumber;
		}

		/// <summary>Gets or sets the name of the associated file.</summary>
		/// <returns>The file name of the associated file.</returns>
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00003855 File Offset: 0x00001A55
		// (set) Token: 0x0600024E RID: 590 RVA: 0x0000386E File Offset: 0x00001A6E
		public string FileName
		{
			get
			{
				if (this.fileName == null)
				{
					return string.Empty;
				}
				return this.fileName;
			}
			set
			{
				this.fileName = value;
			}
		}

		/// <summary>Gets or sets the line number of the associated reference.</summary>
		/// <returns>The line number.</returns>
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00003877 File Offset: 0x00001A77
		// (set) Token: 0x06000250 RID: 592 RVA: 0x0000387F File Offset: 0x00001A7F
		public int LineNumber
		{
			get
			{
				return this.lineNumber;
			}
			set
			{
				this.lineNumber = value;
			}
		}

		// Token: 0x040000AF RID: 175
		private string fileName;

		// Token: 0x040000B0 RID: 176
		private int lineNumber;
	}
}
