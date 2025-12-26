using System;
using System.Security.Cryptography;
using System.Text;

namespace System.Net
{
	// Token: 0x02000307 RID: 775
	internal class DigestSession
	{
		// Token: 0x06001A51 RID: 6737 RVA: 0x000137C4 File Offset: 0x000119C4
		public DigestSession()
		{
			this._nc = 1;
			this.lastUse = DateTime.Now;
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001A53 RID: 6739 RVA: 0x000137EA File Offset: 0x000119EA
		public string Algorithm
		{
			get
			{
				return this.parser.Algorithm;
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001A54 RID: 6740 RVA: 0x000137F7 File Offset: 0x000119F7
		public string Realm
		{
			get
			{
				return this.parser.Realm;
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001A55 RID: 6741 RVA: 0x00013804 File Offset: 0x00011A04
		public string Nonce
		{
			get
			{
				return this.parser.Nonce;
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001A56 RID: 6742 RVA: 0x00013811 File Offset: 0x00011A11
		public string Opaque
		{
			get
			{
				return this.parser.Opaque;
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001A57 RID: 6743 RVA: 0x0001381E File Offset: 0x00011A1E
		public string QOP
		{
			get
			{
				return this.parser.QOP;
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06001A58 RID: 6744 RVA: 0x0004E9C4 File Offset: 0x0004CBC4
		public string CNonce
		{
			get
			{
				if (this._cnonce == null)
				{
					byte[] array = new byte[15];
					DigestSession.rng.GetBytes(array);
					this._cnonce = Convert.ToBase64String(array);
					Array.Clear(array, 0, array.Length);
				}
				return this._cnonce;
			}
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x0004EA0C File Offset: 0x0004CC0C
		public bool Parse(string challenge)
		{
			this.parser = new DigestHeaderParser(challenge);
			if (!this.parser.Parse())
			{
				return false;
			}
			if (this.parser.Algorithm == null || this.parser.Algorithm.ToUpper().StartsWith("MD5"))
			{
				this.hash = HashAlgorithm.Create("MD5");
			}
			return true;
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x0004EA78 File Offset: 0x0004CC78
		private string HashToHexString(string toBeHashed)
		{
			if (this.hash == null)
			{
				return null;
			}
			this.hash.Initialize();
			byte[] array = this.hash.ComputeHash(Encoding.ASCII.GetBytes(toBeHashed));
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in array)
			{
				stringBuilder.Append(b.ToString("x2"));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x0004EAF4 File Offset: 0x0004CCF4
		private string HA1(string username, string password)
		{
			string text = string.Format("{0}:{1}:{2}", username, this.Realm, password);
			if (this.Algorithm != null && this.Algorithm.ToLower() == "md5-sess")
			{
				text = string.Format("{0}:{1}:{2}", this.HashToHexString(text), this.Nonce, this.CNonce);
			}
			return this.HashToHexString(text);
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x0004EB60 File Offset: 0x0004CD60
		private string HA2(HttpWebRequest webRequest)
		{
			string text = string.Format("{0}:{1}", webRequest.Method, webRequest.RequestUri.PathAndQuery);
			if (this.QOP == "auth-int")
			{
			}
			return this.HashToHexString(text);
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x0004EBA8 File Offset: 0x0004CDA8
		private string Response(string username, string password, HttpWebRequest webRequest)
		{
			string text = string.Format("{0}:{1}:", this.HA1(username, password), this.Nonce);
			if (this.QOP != null)
			{
				text += string.Format("{0}:{1}:{2}:", this._nc.ToString("X8"), this.CNonce, this.QOP);
			}
			text += this.HA2(webRequest);
			return this.HashToHexString(text);
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x0004EC1C File Offset: 0x0004CE1C
		public Authorization Authenticate(WebRequest webRequest, ICredentials credentials)
		{
			if (this.parser == null)
			{
				throw new InvalidOperationException();
			}
			HttpWebRequest httpWebRequest = webRequest as HttpWebRequest;
			if (httpWebRequest == null)
			{
				return null;
			}
			this.lastUse = DateTime.Now;
			NetworkCredential credential = credentials.GetCredential(httpWebRequest.RequestUri, "digest");
			if (credential == null)
			{
				return null;
			}
			string userName = credential.UserName;
			if (userName == null || userName == string.Empty)
			{
				return null;
			}
			string password = credential.Password;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("Digest username=\"{0}\", ", userName);
			stringBuilder.AppendFormat("realm=\"{0}\", ", this.Realm);
			stringBuilder.AppendFormat("nonce=\"{0}\", ", this.Nonce);
			stringBuilder.AppendFormat("uri=\"{0}\", ", httpWebRequest.Address.PathAndQuery);
			if (this.Algorithm != null)
			{
				stringBuilder.AppendFormat("algorithm=\"{0}\", ", this.Algorithm);
			}
			stringBuilder.AppendFormat("response=\"{0}\", ", this.Response(userName, password, httpWebRequest));
			if (this.QOP != null)
			{
				stringBuilder.AppendFormat("qop=\"{0}\", ", this.QOP);
			}
			lock (this)
			{
				if (this.QOP != null)
				{
					stringBuilder.AppendFormat("nc={0:X8}, ", this._nc);
					this._nc++;
				}
			}
			if (this.CNonce != null)
			{
				stringBuilder.AppendFormat("cnonce=\"{0}\", ", this.CNonce);
			}
			if (this.Opaque != null)
			{
				stringBuilder.AppendFormat("opaque=\"{0}\", ", this.Opaque);
			}
			stringBuilder.Length -= 2;
			return new Authorization(stringBuilder.ToString());
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06001A5F RID: 6751 RVA: 0x0001382B File Offset: 0x00011A2B
		public DateTime LastUse
		{
			get
			{
				return this.lastUse;
			}
		}

		// Token: 0x04001057 RID: 4183
		private static RandomNumberGenerator rng = RandomNumberGenerator.Create();

		// Token: 0x04001058 RID: 4184
		private DateTime lastUse;

		// Token: 0x04001059 RID: 4185
		private int _nc;

		// Token: 0x0400105A RID: 4186
		private HashAlgorithm hash;

		// Token: 0x0400105B RID: 4187
		private DigestHeaderParser parser;

		// Token: 0x0400105C RID: 4188
		private string _cnonce;
	}
}
