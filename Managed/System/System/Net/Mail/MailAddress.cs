using System;
using System.Text;

namespace System.Net.Mail
{
	/// <summary>Represents the address of an electronic mail sender or recipient.</summary>
	// Token: 0x02000353 RID: 851
	public class MailAddress
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Mail.MailAddress" /> class using the specified address. </summary>
		/// <param name="address">A <see cref="T:System.String" /> that contains an e-mail address.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="address" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="address" /> is <see cref="F:System.String.Empty" /> ("").</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="address" /> is not in a recognized format.</exception>
		// Token: 0x06001DC3 RID: 7619 RVA: 0x0001588E File Offset: 0x00013A8E
		public MailAddress(string address)
			: this(address, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Mail.MailAddress" /> class using the specified address and display name.</summary>
		/// <param name="address">A <see cref="T:System.String" /> that contains an e-mail address.</param>
		/// <param name="displayName">A <see cref="T:System.String" /> that contains the display name associated with <paramref name="address" />. This parameter can be null.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="address" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="address" /> is <see cref="F:System.String.Empty" /> ("").</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="address" /> is not in a recognized format.-or-<paramref name="address" /> contains non-ASCII characters.</exception>
		// Token: 0x06001DC4 RID: 7620 RVA: 0x00015898 File Offset: 0x00013A98
		public MailAddress(string address, string displayName)
			: this(address, displayName, Encoding.Default)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Mail.MailAddress" /> class using the specified address, display name, and encoding.</summary>
		/// <param name="address">A <see cref="T:System.String" /> that contains an e-mail address.</param>
		/// <param name="displayName">A <see cref="T:System.String" /> that contains the display name associated with <paramref name="address" />.</param>
		/// <param name="displayNameEncoding">The <see cref="T:System.Text.Encoding" /> that defines the character set used for <paramref name="displayName" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="address" /> is null.-or-<paramref name="displayName" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="address" /> is <see cref="F:System.String.Empty" /> ("").-or-<paramref name="displayName" /> is <see cref="F:System.String.Empty" /> ("").</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="address" /> is not in a recognized format.-or-<paramref name="address" /> contains non-ASCII characters.</exception>
		// Token: 0x06001DC5 RID: 7621 RVA: 0x0005CA00 File Offset: 0x0005AC00
		public MailAddress(string address, string displayName, Encoding displayNameEncoding)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			int num = address.IndexOf('"');
			if (num == 0)
			{
				int num2 = address.IndexOf('"', num + 1);
				if (num2 == -1)
				{
					throw MailAddress.CreateFormatException();
				}
				this.displayName = address.Substring(num + 1, num2 - 1).Trim();
				address = address.Substring(num2 + 1);
			}
			int num3 = address.IndexOf('<');
			if (num3 != -1)
			{
				if (num3 + 1 >= address.Length)
				{
					throw MailAddress.CreateFormatException();
				}
				int num4 = address.IndexOf('>', num3 + 1);
				if (num4 == -1)
				{
					throw MailAddress.CreateFormatException();
				}
				if (this.displayName == null)
				{
					this.displayName = address.Substring(0, num3).Trim();
				}
				address = address.Substring(++num3, num4 - num3);
			}
			if (displayName != null)
			{
				this.displayName = displayName.Trim();
			}
			this.address = address.Trim();
		}

		/// <summary>Gets the e-mail address specified when this instance was created.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the e-mail address.</returns>
		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06001DC6 RID: 7622 RVA: 0x000158A7 File Offset: 0x00013AA7
		public string Address
		{
			get
			{
				return this.address;
			}
		}

		/// <summary>Gets the display name composed from the display name and address information specified when this instance was created.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the display name; otherwise, <see cref="F:System.String.Empty" /> ("") if no display name information was specified when this instance was created.</returns>
		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06001DC7 RID: 7623 RVA: 0x000158AF File Offset: 0x00013AAF
		public string DisplayName
		{
			get
			{
				if (this.displayName == null)
				{
					return string.Empty;
				}
				return this.displayName;
			}
		}

		/// <summary>Gets the host portion of the address specified when this instance was created.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the name of the host computer that accepts e-mail for the <see cref="P:System.Net.Mail.MailAddress.User" /> property.</returns>
		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06001DC8 RID: 7624 RVA: 0x000158C8 File Offset: 0x00013AC8
		public string Host
		{
			get
			{
				return this.Address.Substring(this.address.IndexOf("@") + 1);
			}
		}

		/// <summary>Gets the user information from the address specified when this instance was created.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the user name portion of the <see cref="P:System.Net.Mail.MailAddress.Address" />.</returns>
		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06001DC9 RID: 7625 RVA: 0x000158E7 File Offset: 0x00013AE7
		public string User
		{
			get
			{
				return this.Address.Substring(0, this.address.IndexOf("@"));
			}
		}

		/// <summary>Compares two mail addresses.</summary>
		/// <returns>true if the two mail addresses are equal; otherwise, false.</returns>
		/// <param name="value">A <see cref="T:System.Net.Mail.MailAddress" /> instance to compare to the current instance.</param>
		// Token: 0x06001DCA RID: 7626 RVA: 0x00015905 File Offset: 0x00013B05
		public override bool Equals(object obj)
		{
			return this.Equals(obj as MailAddress);
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x00015913 File Offset: 0x00013B13
		private bool Equals(MailAddress other)
		{
			return other != null && this.Address == other.Address;
		}

		/// <summary>Returns a hash value for a mail address.</summary>
		/// <returns>An integer hash value.</returns>
		// Token: 0x06001DCC RID: 7628 RVA: 0x0001592F File Offset: 0x00013B2F
		public override int GetHashCode()
		{
			return this.address.GetHashCode();
		}

		/// <summary>Returns a string representation of this instance.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the contents of this <see cref="T:System.Net.Mail.MailAddress" />.</returns>
		// Token: 0x06001DCD RID: 7629 RVA: 0x0005CAF8 File Offset: 0x0005ACF8
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (this.DisplayName != null && this.DisplayName.Length > 0)
			{
				stringBuilder.Append("\"");
				stringBuilder.Append(this.DisplayName);
				stringBuilder.Append("\"");
				stringBuilder.Append(" ");
				stringBuilder.Append("<");
				stringBuilder.Append(this.Address);
				stringBuilder.Append(">");
			}
			else
			{
				stringBuilder.Append(this.Address);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x0001593C File Offset: 0x00013B3C
		private static FormatException CreateFormatException()
		{
			return new FormatException("The specified string is not in the form required for an e-mail address.");
		}

		// Token: 0x04001254 RID: 4692
		private string address;

		// Token: 0x04001255 RID: 4693
		private string displayName;
	}
}
