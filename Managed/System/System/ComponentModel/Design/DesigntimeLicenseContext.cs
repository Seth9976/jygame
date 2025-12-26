using System;
using System.Collections;
using System.Reflection;

namespace System.ComponentModel.Design
{
	/// <summary>Represents a design-time license context that can support a license provider at design time.</summary>
	// Token: 0x02000108 RID: 264
	public class DesigntimeLicenseContext : LicenseContext
	{
		/// <summary>Gets a saved license key.</summary>
		/// <returns>The saved license key that matches the specified type.</returns>
		/// <param name="type">The type of the license key. </param>
		/// <param name="resourceAssembly">The assembly to get the key from. </param>
		// Token: 0x06000A9A RID: 2714 RVA: 0x00009BCE File Offset: 0x00007DCE
		public override string GetSavedLicenseKey(Type type, Assembly resourceAssembly)
		{
			return (string)this.keys[type];
		}

		/// <summary>Sets a saved license key.</summary>
		/// <param name="type">The type of the license key. </param>
		/// <param name="key">The license key. </param>
		// Token: 0x06000A9B RID: 2715 RVA: 0x00009BE1 File Offset: 0x00007DE1
		public override void SetSavedLicenseKey(Type type, string key)
		{
			this.keys[type] = key;
		}

		/// <summary>Gets the license usage mode.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.LicenseUsageMode" /> indicating the licensing mode for the context.</returns>
		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x000025B7 File Offset: 0x000007B7
		public override LicenseUsageMode UsageMode
		{
			get
			{
				return LicenseUsageMode.Designtime;
			}
		}

		// Token: 0x040002DA RID: 730
		internal Hashtable keys = new Hashtable();
	}
}
