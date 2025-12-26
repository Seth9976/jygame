using System;

namespace System.ComponentModel
{
	/// <summary>Indicates that an object's text representation is obscured by characters such as asterisks. This class cannot be inherited.</summary>
	// Token: 0x02000198 RID: 408
	[AttributeUsage(AttributeTargets.All)]
	public sealed class PasswordPropertyTextAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.PasswordPropertyTextAttribute" /> class. </summary>
		// Token: 0x06000E30 RID: 3632 RVA: 0x0000BD64 File Offset: 0x00009F64
		public PasswordPropertyTextAttribute()
			: this(false)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.PasswordPropertyTextAttribute" /> class, optionally showing password text. </summary>
		/// <param name="password">true to indicate that the property should be shown as password text; otherwise, false. The default is false.</param>
		// Token: 0x06000E31 RID: 3633 RVA: 0x0000BD6D File Offset: 0x00009F6D
		public PasswordPropertyTextAttribute(bool password)
		{
			this._password = password;
		}

		/// <summary>Gets a value indicating if the property for which the <see cref="T:System.ComponentModel.PasswordPropertyTextAttribute" /> is defined should be shown as password text.</summary>
		/// <returns>true if the property should be shown as password text; otherwise, false.</returns>
		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000E33 RID: 3635 RVA: 0x0000BD9E File Offset: 0x00009F9E
		public bool Password
		{
			get
			{
				return this._password;
			}
		}

		/// <summary>Determines whether two <see cref="T:System.ComponentModel.PasswordPropertyTextAttribute" /> instances are equal.</summary>
		/// <returns>true if the specified <see cref="T:System.ComponentModel.PasswordPropertyTextAttribute" /> is equal to the current <see cref="T:System.ComponentModel.PasswordPropertyTextAttribute" />; otherwise, false.</returns>
		/// <param name="o">The <see cref="T:System.ComponentModel.PasswordPropertyTextAttribute" /> to compare with the current <see cref="T:System.ComponentModel.PasswordPropertyTextAttribute" />.</param>
		// Token: 0x06000E34 RID: 3636 RVA: 0x0000BDA6 File Offset: 0x00009FA6
		public override bool Equals(object o)
		{
			return o is PasswordPropertyTextAttribute && ((PasswordPropertyTextAttribute)o).Password == this.Password;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A hash code for the current <see cref="T:System.ComponentModel.PasswordPropertyTextAttribute" />.</returns>
		// Token: 0x06000E35 RID: 3637 RVA: 0x00034D18 File Offset: 0x00032F18
		public override int GetHashCode()
		{
			return this.Password.GetHashCode();
		}

		/// <summary>Returns an indication whether the value of this instance is the default value.</summary>
		/// <returns>true if this instance is the default attribute for the class; otherwise, false.</returns>
		// Token: 0x06000E36 RID: 3638 RVA: 0x0000BDC8 File Offset: 0x00009FC8
		public override bool IsDefaultAttribute()
		{
			return PasswordPropertyTextAttribute.Default.Equals(this);
		}

		/// <summary>Specifies the default value for the <see cref="T:System.ComponentModel.PasswordPropertyTextAttribute" />.</summary>
		// Token: 0x0400040E RID: 1038
		public static readonly PasswordPropertyTextAttribute Default = PasswordPropertyTextAttribute.No;

		/// <summary>Specifies that a text property is not used as a password. This static (Shared in Visual Basic) field is read-only.</summary>
		// Token: 0x0400040F RID: 1039
		public static readonly PasswordPropertyTextAttribute No = new PasswordPropertyTextAttribute(false);

		/// <summary>Specifies that a text property is used as a password. This static (Shared in Visual Basic) field is read-only.</summary>
		// Token: 0x04000410 RID: 1040
		public static readonly PasswordPropertyTextAttribute Yes = new PasswordPropertyTextAttribute(true);

		// Token: 0x04000411 RID: 1041
		private bool _password;
	}
}
