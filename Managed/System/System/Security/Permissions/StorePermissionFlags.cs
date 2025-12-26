using System;

namespace System.Security.Permissions
{
	/// <summary>Specifies the permitted access to X.509 certificate stores.</summary>
	// Token: 0x0200047C RID: 1148
	[Flags]
	[Serializable]
	public enum StorePermissionFlags
	{
		/// <summary>Permission is not given to perform any certificate or store operations.</summary>
		// Token: 0x040018EA RID: 6378
		NoFlags = 0,
		/// <summary>The ability to create a new store.</summary>
		// Token: 0x040018EB RID: 6379
		CreateStore = 1,
		/// <summary>The ability to delete a store.</summary>
		// Token: 0x040018EC RID: 6380
		DeleteStore = 2,
		/// <summary>The ability to enumerate the stores on a computer.</summary>
		// Token: 0x040018ED RID: 6381
		EnumerateStores = 4,
		/// <summary>The ability to open a store.</summary>
		// Token: 0x040018EE RID: 6382
		OpenStore = 16,
		/// <summary>The ability to add a certificate to a store.</summary>
		// Token: 0x040018EF RID: 6383
		AddToStore = 32,
		/// <summary>The ability to remove a certificate from a store.</summary>
		// Token: 0x040018F0 RID: 6384
		RemoveFromStore = 64,
		/// <summary>The ability to enumerate the certificates in a store.</summary>
		// Token: 0x040018F1 RID: 6385
		EnumerateCertificates = 128,
		/// <summary>The ability to perform all certificate and store operations.</summary>
		// Token: 0x040018F2 RID: 6386
		AllFlags = 247
	}
}
