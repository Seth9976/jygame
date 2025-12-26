using System;

namespace System.Security.Permissions
{
	/// <summary>Allows security actions for <see cref="T:System.Security.Permissions.StorePermission" /> to be applied to code using declarative security. This class cannot be inherited.</summary>
	// Token: 0x0200047A RID: 1146
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public sealed class StorePermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.StorePermissionAttribute" /> class with the specified security action.</summary>
		/// <param name="action">One of the <see cref="T:System.Security.Permissions.SecurityAction" /> values. </param>
		// Token: 0x0600289D RID: 10397 RVA: 0x0001C441 File Offset: 0x0001A641
		public StorePermissionAttribute(SecurityAction action)
			: base(action)
		{
			this._flags = StorePermissionFlags.NoFlags;
		}

		/// <summary>Gets or sets the store permissions.</summary>
		/// <returns>A bitwise combination of the <see cref="T:System.Security.Permissions.StorePermissionFlags" /> values. The default is <see cref="F:System.Security.Permissions.StorePermissionFlags.NoFlags" />.</returns>
		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x0600289E RID: 10398 RVA: 0x0001C451 File Offset: 0x0001A651
		// (set) Token: 0x0600289F RID: 10399 RVA: 0x0007A170 File Offset: 0x00078370
		public StorePermissionFlags Flags
		{
			get
			{
				return this._flags;
			}
			set
			{
				if ((value & StorePermissionFlags.AllFlags) != value)
				{
					string text = string.Format(global::Locale.GetText("Invalid flags {0}"), value);
					throw new ArgumentException(text, "StorePermissionFlags");
				}
				this._flags = value;
			}
		}

		/// <summary>Gets or sets a value indicating whether the code is permitted to add to a store.</summary>
		/// <returns>true if the ability to add to a store is allowed; otherwise, false.</returns>
		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x060028A0 RID: 10400 RVA: 0x0001C459 File Offset: 0x0001A659
		// (set) Token: 0x060028A1 RID: 10401 RVA: 0x0001C46A File Offset: 0x0001A66A
		public bool AddToStore
		{
			get
			{
				return (this._flags & StorePermissionFlags.AddToStore) != StorePermissionFlags.NoFlags;
			}
			set
			{
				if (value)
				{
					this._flags |= StorePermissionFlags.AddToStore;
				}
				else
				{
					this._flags &= ~StorePermissionFlags.AddToStore;
				}
			}
		}

		/// <summary>Gets or sets a value indicating whether the code is permitted to create a store.</summary>
		/// <returns>true if the ability to create a store is allowed; otherwise, false.</returns>
		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x060028A2 RID: 10402 RVA: 0x0001C495 File Offset: 0x0001A695
		// (set) Token: 0x060028A3 RID: 10403 RVA: 0x0001C4A5 File Offset: 0x0001A6A5
		public bool CreateStore
		{
			get
			{
				return (this._flags & StorePermissionFlags.CreateStore) != StorePermissionFlags.NoFlags;
			}
			set
			{
				if (value)
				{
					this._flags |= StorePermissionFlags.CreateStore;
				}
				else
				{
					this._flags &= ~StorePermissionFlags.CreateStore;
				}
			}
		}

		/// <summary>Gets or sets a value indicating whether the code is permitted to delete a store.</summary>
		/// <returns>true if the ability to delete a store is allowed; otherwise, false.</returns>
		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x060028A4 RID: 10404 RVA: 0x0001C4CF File Offset: 0x0001A6CF
		// (set) Token: 0x060028A5 RID: 10405 RVA: 0x0001C4DF File Offset: 0x0001A6DF
		public bool DeleteStore
		{
			get
			{
				return (this._flags & StorePermissionFlags.DeleteStore) != StorePermissionFlags.NoFlags;
			}
			set
			{
				if (value)
				{
					this._flags |= StorePermissionFlags.DeleteStore;
				}
				else
				{
					this._flags &= ~StorePermissionFlags.DeleteStore;
				}
			}
		}

		/// <summary>Gets or sets a value indicating whether the code is permitted to enumerate the certificates in a store.</summary>
		/// <returns>true if the ability to enumerate certificates is allowed; otherwise, false.</returns>
		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x060028A6 RID: 10406 RVA: 0x0001C509 File Offset: 0x0001A709
		// (set) Token: 0x060028A7 RID: 10407 RVA: 0x0001C51D File Offset: 0x0001A71D
		public bool EnumerateCertificates
		{
			get
			{
				return (this._flags & StorePermissionFlags.EnumerateCertificates) != StorePermissionFlags.NoFlags;
			}
			set
			{
				if (value)
				{
					this._flags |= StorePermissionFlags.EnumerateCertificates;
				}
				else
				{
					this._flags &= ~StorePermissionFlags.EnumerateCertificates;
				}
			}
		}

		/// <summary>Gets or sets a value indicating whether the code is permitted to enumerate stores.</summary>
		/// <returns>true if the ability to enumerate stores is allowed; otherwise, false.</returns>
		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x060028A8 RID: 10408 RVA: 0x0001C54E File Offset: 0x0001A74E
		// (set) Token: 0x060028A9 RID: 10409 RVA: 0x0001C55E File Offset: 0x0001A75E
		public bool EnumerateStores
		{
			get
			{
				return (this._flags & StorePermissionFlags.EnumerateStores) != StorePermissionFlags.NoFlags;
			}
			set
			{
				if (value)
				{
					this._flags |= StorePermissionFlags.EnumerateStores;
				}
				else
				{
					this._flags &= ~StorePermissionFlags.EnumerateStores;
				}
			}
		}

		/// <summary>Gets or sets a value indicating whether the code is permitted to open a store.</summary>
		/// <returns>true if the ability to open a store is allowed; otherwise, false.</returns>
		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x060028AA RID: 10410 RVA: 0x0001C588 File Offset: 0x0001A788
		// (set) Token: 0x060028AB RID: 10411 RVA: 0x0001C599 File Offset: 0x0001A799
		public bool OpenStore
		{
			get
			{
				return (this._flags & StorePermissionFlags.OpenStore) != StorePermissionFlags.NoFlags;
			}
			set
			{
				if (value)
				{
					this._flags |= StorePermissionFlags.OpenStore;
				}
				else
				{
					this._flags &= ~StorePermissionFlags.OpenStore;
				}
			}
		}

		/// <summary>Gets or sets a value indicating whether the code is permitted to remove a certificate from a store.</summary>
		/// <returns>true if the ability to remove a certificate from a store is allowed; otherwise, false.</returns>
		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x060028AC RID: 10412 RVA: 0x0001C5C4 File Offset: 0x0001A7C4
		// (set) Token: 0x060028AD RID: 10413 RVA: 0x0001C5D5 File Offset: 0x0001A7D5
		public bool RemoveFromStore
		{
			get
			{
				return (this._flags & StorePermissionFlags.RemoveFromStore) != StorePermissionFlags.NoFlags;
			}
			set
			{
				if (value)
				{
					this._flags |= StorePermissionFlags.RemoveFromStore;
				}
				else
				{
					this._flags &= ~StorePermissionFlags.RemoveFromStore;
				}
			}
		}

		/// <summary>Creates and returns a new <see cref="T:System.Security.Permissions.StorePermission" />.</summary>
		/// <returns>A <see cref="T:System.Security.Permissions.StorePermission" /> that corresponds to the attribute.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x060028AE RID: 10414 RVA: 0x0007A1B4 File Offset: 0x000783B4
		public override IPermission CreatePermission()
		{
			StorePermission storePermission;
			if (base.Unrestricted)
			{
				storePermission = new StorePermission(PermissionState.Unrestricted);
			}
			else
			{
				storePermission = new StorePermission(this._flags);
			}
			return storePermission;
		}

		// Token: 0x040018E6 RID: 6374
		private StorePermissionFlags _flags;
	}
}
