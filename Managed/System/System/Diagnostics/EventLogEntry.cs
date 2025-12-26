using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Diagnostics
{
	/// <summary>Encapsulates a single record in the event log. This class cannot be inherited.</summary>
	/// <filterpriority>1</filterpriority>
	// Token: 0x02000226 RID: 550
	[global::System.ComponentModel.ToolboxItem(false)]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[PermissionSet((SecurityAction)14, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\nversion=\"1\"\nUnrestricted=\"true\"/>\n")]
	[Serializable]
	public sealed class EventLogEntry : global::System.ComponentModel.Component, ISerializable
	{
		// Token: 0x060012A2 RID: 4770 RVA: 0x0003E6E8 File Offset: 0x0003C8E8
		internal EventLogEntry(string category, short categoryNumber, int index, int eventID, string source, string message, string userName, string machineName, EventLogEntryType entryType, DateTime timeGenerated, DateTime timeWritten, byte[] data, string[] replacementStrings, long instanceId)
		{
			this.category = category;
			this.categoryNumber = categoryNumber;
			this.data = data;
			this.entryType = entryType;
			this.eventID = eventID;
			this.index = index;
			this.machineName = machineName;
			this.message = message;
			this.replacementStrings = replacementStrings;
			this.source = source;
			this.timeGenerated = timeGenerated;
			this.timeWritten = timeWritten;
			this.userName = userName;
			this.instanceId = instanceId;
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x00004F3E File Offset: 0x0000313E
		[global::System.MonoTODO]
		private EventLogEntry(SerializationInfo info, StreamingContext context)
		{
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data needed to serialize the target object.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data. </param>
		/// <param name="context">The destination (see <see cref="T:System.Runtime.Serialization.StreamingContext" />) for this serialization. </param>
		// Token: 0x060012A4 RID: 4772 RVA: 0x00002664 File Offset: 0x00000864
		[global::System.MonoTODO("Needs serialization support")]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new NotImplementedException();
		}

		/// <summary>Gets the text associated with the <see cref="P:System.Diagnostics.EventLogEntry.CategoryNumber" /> property for this entry.</summary>
		/// <returns>The application-specific category text.</returns>
		/// <exception cref="T:System.Exception">The space could not be allocated for one of the insertion strings associated with the category. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x060012A5 RID: 4773 RVA: 0x0000EEEF File Offset: 0x0000D0EF
		[MonitoringDescription("The category of this event entry.")]
		public string Category
		{
			get
			{
				return this.category;
			}
		}

		/// <summary>Gets the category number of the event log entry.</summary>
		/// <returns>The application-specific category number for this entry.</returns>
		/// <filterpriority>1</filterpriority>
		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x060012A6 RID: 4774 RVA: 0x0000EEF7 File Offset: 0x0000D0F7
		[MonitoringDescription("An ID for the category of this event entry.")]
		public short CategoryNumber
		{
			get
			{
				return this.categoryNumber;
			}
		}

		/// <summary>Gets the binary data associated with the entry.</summary>
		/// <returns>An array of bytes that holds the binary data associated with the entry.</returns>
		/// <filterpriority>1</filterpriority>
		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x060012A7 RID: 4775 RVA: 0x0000EEFF File Offset: 0x0000D0FF
		[MonitoringDescription("Binary data associated with this event entry.")]
		public byte[] Data
		{
			get
			{
				return this.data;
			}
		}

		/// <summary>Gets the event type of this entry.</summary>
		/// <returns>The <see cref="T:System.Diagnostics.EventLogEntryType" /> that indicates the event type associated with the entry in the event log.</returns>
		/// <filterpriority>1</filterpriority>
		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x060012A8 RID: 4776 RVA: 0x0000EF07 File Offset: 0x0000D107
		[MonitoringDescription("The type of this event entry.")]
		public EventLogEntryType EntryType
		{
			get
			{
				return this.entryType;
			}
		}

		/// <summary>Gets the application-specific event identifier for the current event entry.</summary>
		/// <returns>The application-specific identifier for the event message.</returns>
		/// <filterpriority>3</filterpriority>
		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x060012A9 RID: 4777 RVA: 0x0000EF0F File Offset: 0x0000D10F
		[Obsolete("Use InstanceId")]
		[MonitoringDescription("An ID number for this event entry.")]
		public int EventID
		{
			get
			{
				return this.eventID;
			}
		}

		/// <summary>Gets the index of this entry in the event log.</summary>
		/// <returns>The index of this entry in the event log.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x060012AA RID: 4778 RVA: 0x0000EF17 File Offset: 0x0000D117
		[MonitoringDescription("Sequence numer of this event entry.")]
		public int Index
		{
			get
			{
				return this.index;
			}
		}

		/// <summary>Gets the resource identifier that designates the message text of the event entry.</summary>
		/// <returns>A resource identifier that corresponds to a string definition in the message resource file of the event source.</returns>
		/// <filterpriority>1</filterpriority>
		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x060012AB RID: 4779 RVA: 0x0000EF1F File Offset: 0x0000D11F
		[MonitoringDescription("The instance ID for this event entry.")]
		[ComVisible(false)]
		public long InstanceId
		{
			get
			{
				return this.instanceId;
			}
		}

		/// <summary>Gets the name of the computer on which this entry was generated.</summary>
		/// <returns>The name of the computer that contains the event log.</returns>
		/// <filterpriority>1</filterpriority>
		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x060012AC RID: 4780 RVA: 0x0000EF27 File Offset: 0x0000D127
		[MonitoringDescription("The Computer on which this event entry occured.")]
		public string MachineName
		{
			get
			{
				return this.machineName;
			}
		}

		/// <summary>Gets the localized message associated with this event entry.</summary>
		/// <returns>The formatted, localized text for the message. This includes associated replacement strings.</returns>
		/// <exception cref="T:System.Exception">The space could not be allocated for one of the insertion strings associated with the message. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x060012AD RID: 4781 RVA: 0x0000EF2F File Offset: 0x0000D12F
		[global::System.ComponentModel.Editor("System.ComponentModel.Design.BinaryEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[MonitoringDescription("The message of this event entry.")]
		public string Message
		{
			get
			{
				return this.message;
			}
		}

		/// <summary>Gets the replacement strings associated with the entry.</summary>
		/// <returns>An array of type <see cref="T:System.String" /> that holds the insertion strings stored in the event entry.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x060012AE RID: 4782 RVA: 0x0000EF37 File Offset: 0x0000D137
		[MonitoringDescription("Application strings for this event entry.")]
		public string[] ReplacementStrings
		{
			get
			{
				return this.replacementStrings;
			}
		}

		/// <summary>Gets the name of the application that generated this event.</summary>
		/// <returns>The name registered with the event log as the source of this event.</returns>
		/// <filterpriority>1</filterpriority>
		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x060012AF RID: 4783 RVA: 0x0000EF3F File Offset: 0x0000D13F
		[MonitoringDescription("The source application of this event entry.")]
		public string Source
		{
			get
			{
				return this.source;
			}
		}

		/// <summary>Gets the local time at which this event was generated.</summary>
		/// <returns>A <see cref="T:System.DateTime" /> that represents the local time at which this event was generated.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x060012B0 RID: 4784 RVA: 0x0000EF47 File Offset: 0x0000D147
		[MonitoringDescription("Generation time of this event entry.")]
		public DateTime TimeGenerated
		{
			get
			{
				return this.timeGenerated;
			}
		}

		/// <summary>Gets the local time at which this event was written to the log.</summary>
		/// <returns>A <see cref="T:System.DateTime" /> that represents the local time at which this event was written to the log.</returns>
		/// <filterpriority>1</filterpriority>
		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x060012B1 RID: 4785 RVA: 0x0000EF4F File Offset: 0x0000D14F
		[MonitoringDescription("The time at which this event entry was written to the logfile.")]
		public DateTime TimeWritten
		{
			get
			{
				return this.timeWritten;
			}
		}

		/// <summary>Gets the name of the user who is responsible for this event.</summary>
		/// <returns>The security identifier (SID) that uniquely identifies a user or group.</returns>
		/// <exception cref="T:System.SystemException">Account information could not be obtained for the user's SID. </exception>
		/// <filterpriority>1</filterpriority>
		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x060012B2 RID: 4786 RVA: 0x0000EF57 File Offset: 0x0000D157
		[MonitoringDescription("The name of a user associated with this event entry.")]
		public string UserName
		{
			get
			{
				return this.userName;
			}
		}

		/// <summary>Performs a comparison between two event log entries.</summary>
		/// <returns>true if the <see cref="T:System.Diagnostics.EventLogEntry" /> objects are identical; otherwise, false.</returns>
		/// <param name="otherEntry">The <see cref="T:System.Diagnostics.EventLogEntry" /> to compare. </param>
		/// <filterpriority>1</filterpriority>
		// Token: 0x060012B3 RID: 4787 RVA: 0x0003E768 File Offset: 0x0003C968
		public bool Equals(EventLogEntry otherEntry)
		{
			return otherEntry == this || (otherEntry.Category == this.category && otherEntry.CategoryNumber == this.categoryNumber && otherEntry.Data.Equals(this.data) && otherEntry.EntryType == this.entryType && otherEntry.EventID == this.eventID && otherEntry.Index == this.index && otherEntry.MachineName == this.machineName && otherEntry.Message == this.message && otherEntry.ReplacementStrings.Equals(this.replacementStrings) && otherEntry.Source == this.source && otherEntry.TimeGenerated.Equals(this.timeGenerated) && otherEntry.TimeWritten.Equals(this.timeWritten) && otherEntry.UserName == this.userName);
		}

		// Token: 0x04000554 RID: 1364
		private string category;

		// Token: 0x04000555 RID: 1365
		private short categoryNumber;

		// Token: 0x04000556 RID: 1366
		private byte[] data;

		// Token: 0x04000557 RID: 1367
		private EventLogEntryType entryType;

		// Token: 0x04000558 RID: 1368
		private int eventID;

		// Token: 0x04000559 RID: 1369
		private int index;

		// Token: 0x0400055A RID: 1370
		private string machineName;

		// Token: 0x0400055B RID: 1371
		private string message;

		// Token: 0x0400055C RID: 1372
		private string[] replacementStrings;

		// Token: 0x0400055D RID: 1373
		private string source;

		// Token: 0x0400055E RID: 1374
		private DateTime timeGenerated;

		// Token: 0x0400055F RID: 1375
		private DateTime timeWritten;

		// Token: 0x04000560 RID: 1376
		private string userName;

		// Token: 0x04000561 RID: 1377
		private long instanceId;
	}
}
