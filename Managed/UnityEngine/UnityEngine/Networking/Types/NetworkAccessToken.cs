using System;

namespace UnityEngine.Networking.Types
{
	/// <summary>
	///   <para>Access token used to authenticate a client session for the purposes of allowing or disallowing match operations requested by that client.</para>
	/// </summary>
	// Token: 0x02000215 RID: 533
	public class NetworkAccessToken
	{
		// Token: 0x06001E99 RID: 7833 RVA: 0x0000C17E File Offset: 0x0000A37E
		public NetworkAccessToken()
		{
			this.array = new byte[64];
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x0000C193 File Offset: 0x0000A393
		public NetworkAccessToken(byte[] array)
		{
			this.array = array;
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x0000C1A2 File Offset: 0x0000A3A2
		public NetworkAccessToken(string strArray)
		{
			this.array = Convert.FromBase64String(strArray);
		}

		/// <summary>
		///   <para>Accessor to get an encoded string from the m_array data.</para>
		/// </summary>
		// Token: 0x06001E9C RID: 7836 RVA: 0x0000C1B6 File Offset: 0x0000A3B6
		public string GetByteString()
		{
			return Convert.ToBase64String(this.array);
		}

		/// <summary>
		///   <para>Checks if the token is a valid set of data with respect to default values (returns true if the values are not default, does not validate the token is a current legitimate token with respect to the server's auth framework).</para>
		/// </summary>
		// Token: 0x06001E9D RID: 7837 RVA: 0x0002523C File Offset: 0x0002343C
		public bool IsValid()
		{
			if (this.array == null || this.array.Length != 64)
			{
				return false;
			}
			bool flag = false;
			foreach (byte b in this.array)
			{
				if (b != 0)
				{
					flag = true;
					break;
				}
			}
			return flag;
		}

		// Token: 0x0400083F RID: 2111
		private const int NETWORK_ACCESS_TOKEN_SIZE = 64;

		/// <summary>
		///   <para>Binary field for the actual token.</para>
		/// </summary>
		// Token: 0x04000840 RID: 2112
		public byte[] array;
	}
}
