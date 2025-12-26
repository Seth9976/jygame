using System;
using System.Collections.Generic;
using System.Security;
using System.Security.Permissions;

namespace System.Net.NetworkInformation
{
	/// <summary>Allows security actions for <see cref="T:System.Net.NetworkInformation.NetworkInformationPermission" /> to be applied to code using declarative security.</summary>
	// Token: 0x020003BD RID: 957
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public sealed class NetworkInformationPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.NetworkInformation.NetworkInformationPermissionAttribute" /> class.</summary>
		/// <param name="action">A <see cref="T:System.Security.Permissions.SecurityAction" /> value that specifies the permission behavior.</param>
		// Token: 0x060020F6 RID: 8438 RVA: 0x0001388B File Offset: 0x00011A8B
		public NetworkInformationPermissionAttribute(SecurityAction action)
			: base(action)
		{
		}

		/// <summary>Creates and returns a new <see cref="T:System.Net.NetworkInformation.NetworkInformationPermission" /> object.</summary>
		/// <returns>A <see cref="T:System.Net.NetworkInformation.NetworkInformationPermission" /> that corresponds to this attribute.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x060020F7 RID: 8439 RVA: 0x00060FA8 File Offset: 0x0005F1A8
		[global::System.MonoTODO("verify implementation")]
		public override IPermission CreatePermission()
		{
			NetworkInformationAccess networkInformationAccess = NetworkInformationAccess.None;
			string text = this.Access;
			if (text != null)
			{
				if (NetworkInformationPermissionAttribute.<>f__switch$map11 == null)
				{
					NetworkInformationPermissionAttribute.<>f__switch$map11 = new Dictionary<string, int>(2)
					{
						{ "Read", 0 },
						{ "Full", 1 }
					};
				}
				int num;
				if (NetworkInformationPermissionAttribute.<>f__switch$map11.TryGetValue(text, out num))
				{
					if (num != 0)
					{
						if (num == 1)
						{
							networkInformationAccess = NetworkInformationAccess.Read | NetworkInformationAccess.Ping;
						}
					}
					else
					{
						networkInformationAccess = NetworkInformationAccess.Read;
					}
				}
			}
			return new NetworkInformationPermission(networkInformationAccess);
		}

		/// <summary>Gets or sets the network information access level.</summary>
		/// <returns>A string that specifies the access level.</returns>
		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x060020F8 RID: 8440 RVA: 0x000179F7 File Offset: 0x00015BF7
		// (set) Token: 0x060020F9 RID: 8441 RVA: 0x0006102C File Offset: 0x0005F22C
		public string Access
		{
			get
			{
				return this.access;
			}
			set
			{
				string text = this.access;
				if (text != null)
				{
					if (NetworkInformationPermissionAttribute.<>f__switch$map10 == null)
					{
						NetworkInformationPermissionAttribute.<>f__switch$map10 = new Dictionary<string, int>(3)
						{
							{ "Read", 0 },
							{ "Full", 0 },
							{ "None", 0 }
						};
					}
					int num;
					if (NetworkInformationPermissionAttribute.<>f__switch$map10.TryGetValue(text, out num))
					{
						if (num == 0)
						{
							this.access = value;
							return;
						}
					}
				}
				throw new ArgumentException("Only 'Read', 'Full' and 'None' are allowed");
			}
		}

		// Token: 0x040013F1 RID: 5105
		private string access;
	}
}
