using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.ComponentModel
{
	/// <summary>Specifies an exception that is handled as a warning instead of an error.</summary>
	// Token: 0x020001C7 RID: 455
	[Serializable]
	public class WarningException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.WarningException" /> class with the specified message and no Help file.</summary>
		/// <param name="message">The message to display to the end user. </param>
		// Token: 0x06000FE7 RID: 4071 RVA: 0x0000CF37 File Offset: 0x0000B137
		public WarningException(string message)
			: base(message)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.WarningException" /> class with the specified message, and with access to the specified Help file.</summary>
		/// <param name="message">The message to display to the end user. </param>
		/// <param name="helpUrl">The Help file to display if the user requests help. </param>
		// Token: 0x06000FE8 RID: 4072 RVA: 0x0000CF40 File Offset: 0x0000B140
		public WarningException(string message, string helpUrl)
			: base(message)
		{
			this.helpUrl = helpUrl;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.WarningException" /> class with the specified message, and with access to the specified Help file and topic.</summary>
		/// <param name="message">The message to display to the end user. </param>
		/// <param name="helpUrl">The Help file to display if the user requests help. </param>
		/// <param name="helpTopic">The Help topic to display if the user requests help. </param>
		// Token: 0x06000FE9 RID: 4073 RVA: 0x0000CF50 File Offset: 0x0000B150
		public WarningException(string message, string helpUrl, string helpTopic)
			: base(message)
		{
			this.helpUrl = helpUrl;
			this.helpTopic = helpTopic;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.WarningException" /> class. </summary>
		// Token: 0x06000FEA RID: 4074 RVA: 0x0000CF67 File Offset: 0x0000B167
		public WarningException()
			: base(global::Locale.GetText("Warning"))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.WarningException" /> class with the specified detailed description and the specified exception. </summary>
		/// <param name="message">A detailed description of the error.</param>
		/// <param name="innerException">A reference to the inner exception that is the cause of this exception.</param>
		// Token: 0x06000FEB RID: 4075 RVA: 0x0000CF79 File Offset: 0x0000B179
		public WarningException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.WarningException" /> class using the specified serialization data and context.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to be used for deserialization.</param>
		/// <param name="context">The destination to be used for deserialization.</param>
		// Token: 0x06000FEC RID: 4076 RVA: 0x00038968 File Offset: 0x00036B68
		protected WarningException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			try
			{
				this.helpTopic = info.GetString("helpTopic");
				this.helpUrl = info.GetString("helpUrl");
			}
			catch (SerializationException)
			{
				this.helpTopic = info.GetString("HelpTopic");
				this.helpUrl = info.GetString("HelpUrl");
			}
		}

		/// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the parameter name and additional exception information.</summary>
		/// <param name="info">Stores the data that was being used to serialize or deserialize the object that the <see cref="T:System.ComponentModel.Design.Serialization.CodeDomSerializer" /> was serializing or deserializing. </param>
		/// <param name="context">Describes the source and destination of the stream that generated the exception, as well as a means for serialization to retain that context and an additional caller-defined context. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="info" /> is null.</exception>
		// Token: 0x06000FED RID: 4077 RVA: 0x0000CF83 File Offset: 0x0000B183
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\nversion=\"1\">\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\nversion=\"1\"\nFlags=\"SerializationFormatter\"/>\n</PermissionSet>\n")]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			base.GetObjectData(info, context);
			info.AddValue("helpTopic", this.helpTopic);
			info.AddValue("helpUrl", this.helpUrl);
		}

		/// <summary>Gets the Help topic associated with the warning.</summary>
		/// <returns>The Help topic associated with the warning.</returns>
		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000FEE RID: 4078 RVA: 0x0000CFC0 File Offset: 0x0000B1C0
		public string HelpTopic
		{
			get
			{
				return this.helpTopic;
			}
		}

		/// <summary>Gets the Help file associated with the warning.</summary>
		/// <returns>The Help file associated with the warning.</returns>
		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000FEF RID: 4079 RVA: 0x0000CFC8 File Offset: 0x0000B1C8
		public string HelpUrl
		{
			get
			{
				return this.helpUrl;
			}
		}

		// Token: 0x0400047A RID: 1146
		private string helpUrl;

		// Token: 0x0400047B RID: 1147
		private string helpTopic;
	}
}
