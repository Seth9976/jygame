using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Substance memory budget.</para>
	/// </summary>
	// Token: 0x0200008D RID: 141
	public enum ProceduralCacheSize
	{
		/// <summary>
		///   <para>A limit of 128MB for the cache or the working memory.</para>
		/// </summary>
		// Token: 0x040001A4 RID: 420
		Tiny,
		/// <summary>
		///   <para>A limit of 256MB for the cache or the working memory.</para>
		/// </summary>
		// Token: 0x040001A5 RID: 421
		Medium,
		/// <summary>
		///   <para>A limit of 512MB for the cache or the working memory.</para>
		/// </summary>
		// Token: 0x040001A6 RID: 422
		Heavy,
		/// <summary>
		///   <para>No limit for the cache or the working memory.</para>
		/// </summary>
		// Token: 0x040001A7 RID: 423
		NoLimit,
		/// <summary>
		///   <para>A limit of 1B (one byte) for the cache or the working memory.</para>
		/// </summary>
		// Token: 0x040001A8 RID: 424
		None
	}
}
