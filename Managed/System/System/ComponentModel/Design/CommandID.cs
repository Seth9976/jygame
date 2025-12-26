using System;
using System.Runtime.InteropServices;

namespace System.ComponentModel.Design
{
	/// <summary>Represents a unique command identifier that consists of a numeric command ID and a GUID menu group identifier.</summary>
	// Token: 0x020000FA RID: 250
	[ComVisible(true)]
	public class CommandID
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.CommandID" /> class using the specified menu group GUID and command ID number.</summary>
		/// <param name="menuGroup">The GUID of the group that this menu command belongs to. </param>
		/// <param name="commandID">The numeric identifier of this menu command. </param>
		// Token: 0x06000A28 RID: 2600 RVA: 0x0000975D File Offset: 0x0000795D
		public CommandID(Guid menuGroup, int commandID)
		{
			this.cID = commandID;
			this.guid = menuGroup;
		}

		/// <summary>Gets the GUID of the menu group that the menu command identified by this <see cref="T:System.ComponentModel.Design.CommandID" /> belongs to.</summary>
		/// <returns>The GUID of the command group for this command.</returns>
		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x00009773 File Offset: 0x00007973
		public virtual Guid Guid
		{
			get
			{
				return this.guid;
			}
		}

		/// <summary>Gets the numeric command ID.</summary>
		/// <returns>The command ID number.</returns>
		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x0000977B File Offset: 0x0000797B
		public virtual int ID
		{
			get
			{
				return this.cID;
			}
		}

		/// <summary>Determines whether two <see cref="T:System.ComponentModel.Design.CommandID" /> instances are equal.</summary>
		/// <returns>true if the specified object is equivalent to this one; otherwise, false.</returns>
		/// <param name="obj">The object to compare. </param>
		// Token: 0x06000A2B RID: 2603 RVA: 0x000302DC File Offset: 0x0002E4DC
		public override bool Equals(object obj)
		{
			return obj is CommandID && (obj == this || (((CommandID)obj).Guid.Equals(this.guid) && ((CommandID)obj).ID.Equals(this.cID)));
		}

		/// <returns>A hash code for the current <see cref="T:System.Object" />.</returns>
		// Token: 0x06000A2C RID: 2604 RVA: 0x00009783 File Offset: 0x00007983
		public override int GetHashCode()
		{
			return this.guid.GetHashCode() ^ this.cID.GetHashCode();
		}

		/// <summary>Returns a <see cref="T:System.String" /> that represents the current object.</summary>
		/// <returns>A string that contains the command ID information, both the GUID and integer identifier. </returns>
		// Token: 0x06000A2D RID: 2605 RVA: 0x0000979C File Offset: 0x0000799C
		public override string ToString()
		{
			return this.guid.ToString() + " : " + this.cID.ToString();
		}

		// Token: 0x040002BD RID: 701
		private int cID;

		// Token: 0x040002BE RID: 702
		private Guid guid;
	}
}
