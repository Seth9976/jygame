using System;
using System.Collections.Specialized;
using System.Net.Mime;
using System.Text;

namespace System.Net.Mail
{
	/// <summary>Represents an e-mail message that can be sent using the <see cref="T:System.Net.Mail.SmtpClient" /> class.</summary>
	// Token: 0x02000354 RID: 852
	public class MailMessage : IDisposable
	{
		/// <summary>Initializes an empty instance of the <see cref="T:System.Net.Mail.MailMessage" /> class.</summary>
		// Token: 0x06001DCF RID: 7631 RVA: 0x0005CB98 File Offset: 0x0005AD98
		public MailMessage()
		{
			this.to = new MailAddressCollection();
			this.alternateViews = new AlternateViewCollection();
			this.attachments = new AttachmentCollection();
			this.bcc = new MailAddressCollection();
			this.cc = new MailAddressCollection();
			this.replyTo = new MailAddressCollection();
			this.headers = new global::System.Collections.Specialized.NameValueCollection();
			this.headers.Add("MIME-Version", "1.0");
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Mail.MailMessage" /> class by using the specified <see cref="T:System.Net.Mail.MailAddress" /> class objects. </summary>
		/// <param name="from">A <see cref="T:System.Net.Mail.MailAddress" /> that contains the address of the sender of the e-mail message.</param>
		/// <param name="to">A <see cref="T:System.Net.Mail.MailAddress" /> that contains the address of the recipient of the e-mail message.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="from" /> is null.-or-<paramref name="to" /> is null.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="from" /> or <paramref name="to" /> is malformed.</exception>
		// Token: 0x06001DD0 RID: 7632 RVA: 0x00015948 File Offset: 0x00013B48
		public MailMessage(MailAddress from, MailAddress to)
			: this()
		{
			if (from == null || to == null)
			{
				throw new ArgumentNullException();
			}
			this.From = from;
			this.to.Add(to);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Mail.MailMessage" /> class by using the specified <see cref="T:System.String" /> class objects. </summary>
		/// <param name="from">A <see cref="T:System.String" /> that contains the address of the sender of the e-mail message.</param>
		/// <param name="to">A <see cref="T:System.String" /> that contains the addresses of the recipients of the e-mail message.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="from" /> is null.-or-<paramref name="to" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="from" /> is <see cref="F:System.String.Empty" /> ("").-or-<paramref name="to" /> is <see cref="F:System.String.Empty" /> ("").</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="from" /> or <paramref name="to" /> is malformed.</exception>
		// Token: 0x06001DD1 RID: 7633 RVA: 0x0005CC18 File Offset: 0x0005AE18
		public MailMessage(string from, string to)
			: this()
		{
			if (from == null || from == string.Empty)
			{
				throw new ArgumentNullException("from");
			}
			if (to == null || to == string.Empty)
			{
				throw new ArgumentNullException("to");
			}
			this.from = new MailAddress(from);
			foreach (string text in to.Split(new char[] { ',' }))
			{
				this.to.Add(new MailAddress(text.Trim()));
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Mail.MailMessage" /> class. </summary>
		/// <param name="from">A <see cref="T:System.String" /> that contains the address of the sender of the e-mail message.</param>
		/// <param name="to">A <see cref="T:System.String" /> that contains the address of the recipient of the e-mail message.</param>
		/// <param name="subject">A <see cref="T:System.String" /> that contains the subject text.</param>
		/// <param name="body">A <see cref="T:System.String" /> that contains the message body.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="from" /> is null.-or-<paramref name="to" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="from" /> is <see cref="F:System.String.Empty" /> ("").-or-<paramref name="to" /> is <see cref="F:System.String.Empty" /> ("").</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="from" /> or <paramref name="to" /> is malformed.</exception>
		// Token: 0x06001DD2 RID: 7634 RVA: 0x0005CCBC File Offset: 0x0005AEBC
		public MailMessage(string from, string to, string subject, string body)
			: this()
		{
			if (from == null || from == string.Empty)
			{
				throw new ArgumentNullException("from");
			}
			if (to == null || to == string.Empty)
			{
				throw new ArgumentNullException("to");
			}
			this.from = new MailAddress(from);
			foreach (string text in to.Split(new char[] { ',' }))
			{
				this.to.Add(new MailAddress(text.Trim()));
			}
			this.Body = body;
			this.Subject = subject;
		}

		/// <summary>Gets the attachment collection used to store alternate forms of the message body.</summary>
		/// <returns>A writable <see cref="T:System.Net.Mail.AlternateViewCollection" />.</returns>
		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06001DD3 RID: 7635 RVA: 0x00015975 File Offset: 0x00013B75
		public AlternateViewCollection AlternateViews
		{
			get
			{
				return this.alternateViews;
			}
		}

		/// <summary>Gets the attachment collection used to store data attached to this e-mail message.</summary>
		/// <returns>A writable <see cref="T:System.Net.Mail.AttachmentCollection" />.</returns>
		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06001DD4 RID: 7636 RVA: 0x0001597D File Offset: 0x00013B7D
		public AttachmentCollection Attachments
		{
			get
			{
				return this.attachments;
			}
		}

		/// <summary>Gets the address collection that contains the blind carbon copy (BCC) recipients for this e-mail message.</summary>
		/// <returns>A writable <see cref="T:System.Net.Mail.MailAddressCollection" /> object.</returns>
		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06001DD5 RID: 7637 RVA: 0x00015985 File Offset: 0x00013B85
		public MailAddressCollection Bcc
		{
			get
			{
				return this.bcc;
			}
		}

		/// <summary>Gets or sets the message body.</summary>
		/// <returns>A <see cref="T:System.String" /> value that contains the body text.</returns>
		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06001DD6 RID: 7638 RVA: 0x0001598D File Offset: 0x00013B8D
		// (set) Token: 0x06001DD7 RID: 7639 RVA: 0x00015995 File Offset: 0x00013B95
		public string Body
		{
			get
			{
				return this.body;
			}
			set
			{
				if (value != null && this.bodyEncoding == null)
				{
					this.bodyEncoding = this.GuessEncoding(value) ?? Encoding.ASCII;
				}
				this.body = value;
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06001DD8 RID: 7640 RVA: 0x0005CD6C File Offset: 0x0005AF6C
		internal global::System.Net.Mime.ContentType BodyContentType
		{
			get
			{
				return new global::System.Net.Mime.ContentType((!this.isHtml) ? "text/plain" : "text/html")
				{
					CharSet = (this.BodyEncoding ?? Encoding.ASCII).HeaderName
				};
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06001DD9 RID: 7641 RVA: 0x000159C8 File Offset: 0x00013BC8
		internal global::System.Net.Mime.TransferEncoding ContentTransferEncoding
		{
			get
			{
				return global::System.Net.Mime.ContentType.GuessTransferEncoding(this.BodyEncoding);
			}
		}

		/// <summary>Gets or sets the encoding used to encode the message body.</summary>
		/// <returns>An <see cref="T:System.Text.Encoding" /> applied to the contents of the <see cref="P:System.Net.Mail.MailMessage.Body" />.</returns>
		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06001DDA RID: 7642 RVA: 0x000159D5 File Offset: 0x00013BD5
		// (set) Token: 0x06001DDB RID: 7643 RVA: 0x000159DD File Offset: 0x00013BDD
		public Encoding BodyEncoding
		{
			get
			{
				return this.bodyEncoding;
			}
			set
			{
				this.bodyEncoding = value;
			}
		}

		/// <summary>Gets the address collection that contains the carbon copy (CC) recipients for this e-mail message.</summary>
		/// <returns>A writable <see cref="T:System.Net.Mail.MailAddressCollection" /> object.</returns>
		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06001DDC RID: 7644 RVA: 0x000159E6 File Offset: 0x00013BE6
		public MailAddressCollection CC
		{
			get
			{
				return this.cc;
			}
		}

		/// <summary>Gets or sets the delivery notifications for this e-mail message.</summary>
		/// <returns>A <see cref="T:System.Net.Mail.DeliveryNotificationOptions" /> value that contains the delivery notifications for this message.</returns>
		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06001DDD RID: 7645 RVA: 0x000159EE File Offset: 0x00013BEE
		// (set) Token: 0x06001DDE RID: 7646 RVA: 0x000159F6 File Offset: 0x00013BF6
		public DeliveryNotificationOptions DeliveryNotificationOptions
		{
			get
			{
				return this.deliveryNotificationOptions;
			}
			set
			{
				this.deliveryNotificationOptions = value;
			}
		}

		/// <summary>Gets or sets the from address for this e-mail message.</summary>
		/// <returns>A <see cref="T:System.Net.Mail.MailAddress" /> that contains the from address information.</returns>
		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06001DDF RID: 7647 RVA: 0x000159FF File Offset: 0x00013BFF
		// (set) Token: 0x06001DE0 RID: 7648 RVA: 0x00015A07 File Offset: 0x00013C07
		public MailAddress From
		{
			get
			{
				return this.from;
			}
			set
			{
				this.from = value;
			}
		}

		/// <summary>Gets the e-mail headers that are transmitted with this e-mail message.</summary>
		/// <returns>A <see cref="T:System.Collections.Specialized.NameValueCollection" /> that contains the e-mail headers.</returns>
		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06001DE1 RID: 7649 RVA: 0x00015A10 File Offset: 0x00013C10
		public global::System.Collections.Specialized.NameValueCollection Headers
		{
			get
			{
				return this.headers;
			}
		}

		/// <summary>Gets or sets a value indicating whether the mail message body is in Html.</summary>
		/// <returns>true if the message body is in Html; else false. The default is false.</returns>
		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06001DE2 RID: 7650 RVA: 0x00015A18 File Offset: 0x00013C18
		// (set) Token: 0x06001DE3 RID: 7651 RVA: 0x00015A20 File Offset: 0x00013C20
		public bool IsBodyHtml
		{
			get
			{
				return this.isHtml;
			}
			set
			{
				this.isHtml = value;
			}
		}

		/// <summary>Gets or sets the priority of this e-mail message.</summary>
		/// <returns>A <see cref="T:System.Net.Mail.MailPriority" /> that contains the priority of this message.</returns>
		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06001DE4 RID: 7652 RVA: 0x00015A29 File Offset: 0x00013C29
		// (set) Token: 0x06001DE5 RID: 7653 RVA: 0x00015A31 File Offset: 0x00013C31
		public MailPriority Priority
		{
			get
			{
				return this.priority;
			}
			set
			{
				this.priority = value;
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06001DE6 RID: 7654 RVA: 0x00015A3A File Offset: 0x00013C3A
		// (set) Token: 0x06001DE7 RID: 7655 RVA: 0x00015A42 File Offset: 0x00013C42
		internal Encoding HeadersEncoding
		{
			get
			{
				return this.headersEncoding;
			}
			set
			{
				this.headersEncoding = value;
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06001DE8 RID: 7656 RVA: 0x00015A4B File Offset: 0x00013C4B
		internal MailAddressCollection ReplyToList
		{
			get
			{
				return this.replyTo;
			}
		}

		/// <summary>Gets or sets the ReplyTo address for the mail message.</summary>
		/// <returns>A MailAddress that indicates the value of the <see cref="P:System.Net.Mail.MailMessage.ReplyTo" /> field.</returns>
		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06001DE9 RID: 7657 RVA: 0x00015A53 File Offset: 0x00013C53
		// (set) Token: 0x06001DEA RID: 7658 RVA: 0x00015A73 File Offset: 0x00013C73
		public MailAddress ReplyTo
		{
			get
			{
				if (this.replyTo.Count == 0)
				{
					return null;
				}
				return this.replyTo[0];
			}
			set
			{
				this.replyTo.Clear();
				this.replyTo.Add(value);
			}
		}

		/// <summary>Gets or sets the sender's address for this e-mail message.</summary>
		/// <returns>A <see cref="T:System.Net.Mail.MailAddress" /> that contains the sender's address information.</returns>
		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06001DEB RID: 7659 RVA: 0x00015A8C File Offset: 0x00013C8C
		// (set) Token: 0x06001DEC RID: 7660 RVA: 0x00015A94 File Offset: 0x00013C94
		public MailAddress Sender
		{
			get
			{
				return this.sender;
			}
			set
			{
				this.sender = value;
			}
		}

		/// <summary>Gets or sets the subject line for this e-mail message.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the subject content.</returns>
		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06001DED RID: 7661 RVA: 0x00015A9D File Offset: 0x00013C9D
		// (set) Token: 0x06001DEE RID: 7662 RVA: 0x00015AA5 File Offset: 0x00013CA5
		public string Subject
		{
			get
			{
				return this.subject;
			}
			set
			{
				if (value != null && this.subjectEncoding == null)
				{
					this.subjectEncoding = this.GuessEncoding(value);
				}
				this.subject = value;
			}
		}

		/// <summary>Gets or sets the encoding used for the subject content for this e-mail message.</summary>
		/// <returns>An <see cref="T:System.Text.Encoding" /> that was used to encode the <see cref="P:System.Net.Mail.MailMessage.Subject" /> property.</returns>
		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06001DEF RID: 7663 RVA: 0x00015ACC File Offset: 0x00013CCC
		// (set) Token: 0x06001DF0 RID: 7664 RVA: 0x00015AD4 File Offset: 0x00013CD4
		public Encoding SubjectEncoding
		{
			get
			{
				return this.subjectEncoding;
			}
			set
			{
				this.subjectEncoding = value;
			}
		}

		/// <summary>Gets the address collection that contains the recipients of this e-mail message.</summary>
		/// <returns>A writable <see cref="T:System.Net.Mail.MailAddressCollection" /> object.</returns>
		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06001DF1 RID: 7665 RVA: 0x00015ADD File Offset: 0x00013CDD
		public MailAddressCollection To
		{
			get
			{
				return this.to;
			}
		}

		/// <summary>Releases all resources used by the <see cref="T:System.Net.Mail.MailMessage" />. </summary>
		// Token: 0x06001DF2 RID: 7666 RVA: 0x00015AE5 File Offset: 0x00013CE5
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Net.Mail.MailMessage" /> and optionally releases the managed resources. </summary>
		/// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
		// Token: 0x06001DF3 RID: 7667 RVA: 0x000029F5 File Offset: 0x00000BF5
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x00015AF4 File Offset: 0x00013CF4
		private Encoding GuessEncoding(string s)
		{
			return global::System.Net.Mime.ContentType.GuessEncoding(s);
		}

		// Token: 0x04001256 RID: 4694
		private AlternateViewCollection alternateViews;

		// Token: 0x04001257 RID: 4695
		private AttachmentCollection attachments;

		// Token: 0x04001258 RID: 4696
		private MailAddressCollection bcc;

		// Token: 0x04001259 RID: 4697
		private MailAddressCollection replyTo;

		// Token: 0x0400125A RID: 4698
		private string body;

		// Token: 0x0400125B RID: 4699
		private MailPriority priority;

		// Token: 0x0400125C RID: 4700
		private MailAddress sender;

		// Token: 0x0400125D RID: 4701
		private DeliveryNotificationOptions deliveryNotificationOptions;

		// Token: 0x0400125E RID: 4702
		private MailAddressCollection cc;

		// Token: 0x0400125F RID: 4703
		private MailAddress from;

		// Token: 0x04001260 RID: 4704
		private global::System.Collections.Specialized.NameValueCollection headers;

		// Token: 0x04001261 RID: 4705
		private MailAddressCollection to;

		// Token: 0x04001262 RID: 4706
		private string subject;

		// Token: 0x04001263 RID: 4707
		private Encoding subjectEncoding;

		// Token: 0x04001264 RID: 4708
		private Encoding bodyEncoding;

		// Token: 0x04001265 RID: 4709
		private Encoding headersEncoding = Encoding.UTF8;

		// Token: 0x04001266 RID: 4710
		private bool isHtml;
	}
}
