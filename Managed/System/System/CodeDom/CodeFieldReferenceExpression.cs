using System;
using System.Runtime.InteropServices;

namespace System.CodeDom
{
	/// <summary>Represents a reference to a field.</summary>
	// Token: 0x02000042 RID: 66
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[ComVisible(true)]
	[Serializable]
	public class CodeFieldReferenceExpression : CodeExpression
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeFieldReferenceExpression" /> class.</summary>
		// Token: 0x06000227 RID: 551 RVA: 0x0000366E File Offset: 0x0000186E
		public CodeFieldReferenceExpression()
		{
			this.fieldName = string.Empty;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeFieldReferenceExpression" /> class using the specified target object and field name.</summary>
		/// <param name="targetObject">A <see cref="T:System.CodeDom.CodeExpression" /> that indicates the object that contains the field. </param>
		/// <param name="fieldName">The name of the field. </param>
		// Token: 0x06000228 RID: 552 RVA: 0x00003681 File Offset: 0x00001881
		public CodeFieldReferenceExpression(CodeExpression targetObject, string fieldName)
		{
			this.targetObject = targetObject;
			this.fieldName = fieldName;
		}

		/// <summary>Gets or sets the name of the field to reference.</summary>
		/// <returns>A string containing the field name.</returns>
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00003697 File Offset: 0x00001897
		// (set) Token: 0x0600022A RID: 554 RVA: 0x0000369F File Offset: 0x0000189F
		public string FieldName
		{
			get
			{
				return this.fieldName;
			}
			set
			{
				this.fieldName = value;
			}
		}

		/// <summary>Gets or sets the object that contains the field to reference.</summary>
		/// <returns>A <see cref="T:System.CodeDom.CodeExpression" /> that indicates the object that contains the field to reference.</returns>
		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600022B RID: 555 RVA: 0x000036A8 File Offset: 0x000018A8
		// (set) Token: 0x0600022C RID: 556 RVA: 0x000036B0 File Offset: 0x000018B0
		public CodeExpression TargetObject
		{
			get
			{
				return this.targetObject;
			}
			set
			{
				this.targetObject = value;
			}
		}

		// Token: 0x0600022D RID: 557 RVA: 0x000036B9 File Offset: 0x000018B9
		internal override void Accept(ICodeDomVisitor visitor)
		{
			visitor.Visit(this);
		}

		// Token: 0x040000A4 RID: 164
		private CodeExpression targetObject;

		// Token: 0x040000A5 RID: 165
		private string fieldName;
	}
}
