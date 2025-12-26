using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace System.ComponentModel
{
	/// <summary>Throws an exception for a Win32 error code.</summary>
	// Token: 0x020001CA RID: 458
	[SuppressUnmanagedCodeSecurity]
	[Serializable]
	public class Win32Exception : ExternalException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Win32Exception" /> class with the last Win32 error that occurred.</summary>
		// Token: 0x06000FF8 RID: 4088 RVA: 0x0000D02A File Offset: 0x0000B22A
		public Win32Exception()
			: base(Win32Exception.W32ErrorMessage(Marshal.GetLastWin32Error()))
		{
			this.native_error_code = Marshal.GetLastWin32Error();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Win32Exception" /> class with the specified error.</summary>
		/// <param name="error">The Win32 error code associated with this exception. </param>
		// Token: 0x06000FF9 RID: 4089 RVA: 0x0000D047 File Offset: 0x0000B247
		public Win32Exception(int error)
			: base(Win32Exception.W32ErrorMessage(error))
		{
			this.native_error_code = error;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Win32Exception" /> class with the specified error and the specified detailed description.</summary>
		/// <param name="error">The Win32 error code associated with this exception. </param>
		/// <param name="message">A detailed description of the error. </param>
		// Token: 0x06000FFA RID: 4090 RVA: 0x0000D05C File Offset: 0x0000B25C
		public Win32Exception(int error, string message)
			: base(message)
		{
			this.native_error_code = error;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Win32Exception" /> class with the specified detailed description. </summary>
		/// <param name="message">A detailed description of the error.</param>
		// Token: 0x06000FFB RID: 4091 RVA: 0x0000D06C File Offset: 0x0000B26C
		[PermissionSet(SecurityAction.LinkDemand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\nversion=\"1\">\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\nversion=\"1\"\nFlags=\"UnmanagedCode\"/>\n</PermissionSet>\n")]
		public Win32Exception(string message)
			: base(message)
		{
			this.native_error_code = Marshal.GetLastWin32Error();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Win32Exception" /> class with the specified detailed description and the specified exception.</summary>
		/// <param name="message">A detailed description of the error.</param>
		/// <param name="innerException">A reference to the inner exception that is the cause of this exception.</param>
		// Token: 0x06000FFC RID: 4092 RVA: 0x0000D080 File Offset: 0x0000B280
		[PermissionSet(SecurityAction.LinkDemand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\nversion=\"1\">\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\nversion=\"1\"\nFlags=\"UnmanagedCode\"/>\n</PermissionSet>\n")]
		public Win32Exception(string message, Exception innerException)
			: base(message, innerException)
		{
			this.native_error_code = Marshal.GetLastWin32Error();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Win32Exception" /> class with the specified context and the serialization information.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> associated with this exception. </param>
		/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that represents the context of this exception. </param>
		// Token: 0x06000FFD RID: 4093 RVA: 0x0000D095 File Offset: 0x0000B295
		protected Win32Exception(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			this.native_error_code = info.GetInt32("NativeErrorCode");
		}

		/// <summary>Gets the Win32 error code associated with this exception.</summary>
		/// <returns>The Win32 error code associated with this exception.</returns>
		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000FFE RID: 4094 RVA: 0x0000D0B0 File Offset: 0x0000B2B0
		public int NativeErrorCode
		{
			get
			{
				return this.native_error_code;
			}
		}

		/// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the file name and line number at which this <see cref="T:System.ComponentModel.Win32Exception" /> occurred.</summary>
		/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</param>
		/// <param name="context">The contextual information about the source or destination.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="info" /> is null.</exception>
		// Token: 0x06000FFF RID: 4095 RVA: 0x0000D0B8 File Offset: 0x0000B2B8
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\nversion=\"1\">\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\nversion=\"1\"\nFlags=\"SerializationFormatter\"/>\n</PermissionSet>\n")]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.AddValue("NativeErrorCode", this.native_error_code);
			base.GetObjectData(info, context);
		}

		// Token: 0x06001000 RID: 4096
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string W32ErrorMessage(int error_code);

		// Token: 0x0400047E RID: 1150
		private int native_error_code;
	}
}
