using System;

namespace UnityEngine.Experimental.Networking
{
	// Token: 0x020001F2 RID: 498
	public interface IMultipartFormSection
	{
		/// <summary>
		///   <para>Returns the name of this section, if any.</para>
		/// </summary>
		/// <returns>
		///   <para>The section's name, or null.</para>
		/// </returns>
		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06001D74 RID: 7540
		string sectionName { get; }

		/// <summary>
		///   <para>Returns the raw binary data contained in this section. Must not return null or a zero-length array.</para>
		/// </summary>
		/// <returns>
		///   <para>The raw binary data contained in this section. Must not be null or empty.</para>
		/// </returns>
		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06001D75 RID: 7541
		byte[] sectionData { get; }

		/// <summary>
		///   <para>Returns a string denoting the desired filename of this section on the destination server.</para>
		/// </summary>
		/// <returns>
		///   <para>The desired file name of this section, or null if this is not a file section.</para>
		/// </returns>
		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06001D76 RID: 7542
		string fileName { get; }

		/// <summary>
		///   <para>Returns the value to use in the Content-Type header for this form section.</para>
		/// </summary>
		/// <returns>
		///   <para>The value to use in the Content-Type header, or null.</para>
		/// </returns>
		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06001D77 RID: 7543
		string contentType { get; }
	}
}
