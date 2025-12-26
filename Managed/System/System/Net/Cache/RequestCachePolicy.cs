using System;

namespace System.Net.Cache
{
	/// <summary>Defines an application's caching requirements for resources obtained by using <see cref="T:System.Net.WebRequest" /> objects.</summary>
	// Token: 0x020002CE RID: 718
	public class RequestCachePolicy
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Cache.RequestCachePolicy" /> class. </summary>
		// Token: 0x06001893 RID: 6291 RVA: 0x000021C3 File Offset: 0x000003C3
		public RequestCachePolicy()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Cache.RequestCachePolicy" /> class. using the specified cache policy.</summary>
		/// <param name="level">A <see cref="T:System.Net.Cache.RequestCacheLevel" /> that specifies the cache behavior for resources obtained using <see cref="T:System.Net.WebRequest" /> objects. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">level is not a valid <see cref="T:System.Net.Cache.RequestCacheLevel" />.value.</exception>
		// Token: 0x06001894 RID: 6292 RVA: 0x000122C4 File Offset: 0x000104C4
		public RequestCachePolicy(RequestCacheLevel level)
		{
			this.level = level;
		}

		/// <summary>Gets the <see cref="T:System.Net.Cache.RequestCacheLevel" /> value specified when this instance was constructed.</summary>
		/// <returns>A <see cref="T:System.Net.Cache.RequestCacheLevel" /> value that specifies the cache behavior for resources obtained using <see cref="T:System.Net.WebRequest" /> objects.</returns>
		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06001895 RID: 6293 RVA: 0x000122D3 File Offset: 0x000104D3
		public RequestCacheLevel Level
		{
			get
			{
				return this.level;
			}
		}

		/// <summary>Returns a string representation of this instance.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the <see cref="P:System.Net.Cache.RequestCachePolicy.Level" /> for this instance.</returns>
		// Token: 0x06001896 RID: 6294 RVA: 0x00002664 File Offset: 0x00000864
		[global::System.MonoTODO]
		public override string ToString()
		{
			throw new NotImplementedException();
		}

		// Token: 0x04000FAF RID: 4015
		private RequestCacheLevel level;
	}
}
