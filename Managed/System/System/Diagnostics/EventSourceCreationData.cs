using System;

namespace System.Diagnostics
{
	/// <summary>Represents the configuration settings used to create an event log source on the local computer or a remote computer.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x02000230 RID: 560
	public class EventSourceCreationData
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.EventSourceCreationData" /> class with a specified event source and event log name.</summary>
		/// <param name="source">The name to register with the event log as a source of entries. </param>
		/// <param name="logName">The name of the log to which entries from the source are written. </param>
		// Token: 0x06001308 RID: 4872 RVA: 0x0000F25E File Offset: 0x0000D45E
		public EventSourceCreationData(string source, string logName)
		{
			this._source = source;
			this._logName = logName;
			this._machineName = ".";
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x0000F27F File Offset: 0x0000D47F
		internal EventSourceCreationData(string source, string logName, string machineName)
		{
			this._source = source;
			if (logName == null || logName.Length == 0)
			{
				this._logName = "Application";
			}
			else
			{
				this._logName = logName;
			}
			this._machineName = machineName;
		}

		/// <summary>Gets or sets the number of categories in the category resource file.</summary>
		/// <returns>The number of categories in the category resource file. The default value is zero.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The property is set to a negative value or to a value larger than <see cref="F:System.UInt16.MaxValue" />. </exception>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x0600130A RID: 4874 RVA: 0x0000F2BD File Offset: 0x0000D4BD
		// (set) Token: 0x0600130B RID: 4875 RVA: 0x0000F2C5 File Offset: 0x0000D4C5
		public int CategoryCount
		{
			get
			{
				return this._categoryCount;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._categoryCount = value;
			}
		}

		/// <summary>Gets or sets the path of the resource file that contains category strings for the source.</summary>
		/// <returns>The path of the category resource file. The default is an empty string ("").</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x0600130C RID: 4876 RVA: 0x0000F2E0 File Offset: 0x0000D4E0
		// (set) Token: 0x0600130D RID: 4877 RVA: 0x0000F2E8 File Offset: 0x0000D4E8
		public string CategoryResourceFile
		{
			get
			{
				return this._categoryResourceFile;
			}
			set
			{
				this._categoryResourceFile = value;
			}
		}

		/// <summary>Gets or sets the name of the event log to which the source writes entries.</summary>
		/// <returns>The name of the event log. This can be Application, System, or a custom log name. The default value is "Application."</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x0600130E RID: 4878 RVA: 0x0000F2F1 File Offset: 0x0000D4F1
		// (set) Token: 0x0600130F RID: 4879 RVA: 0x0000F2F9 File Offset: 0x0000D4F9
		public string LogName
		{
			get
			{
				return this._logName;
			}
			set
			{
				this._logName = value;
			}
		}

		/// <summary>Gets or sets the name of the computer on which to register the event source.</summary>
		/// <returns>The name of the system on which to register the event source. The default is the local computer (".").</returns>
		/// <exception cref="T:System.ArgumentException">The computer name is invalid. </exception>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06001310 RID: 4880 RVA: 0x0000F302 File Offset: 0x0000D502
		// (set) Token: 0x06001311 RID: 4881 RVA: 0x0000F30A File Offset: 0x0000D50A
		public string MachineName
		{
			get
			{
				return this._machineName;
			}
			set
			{
				this._machineName = value;
			}
		}

		/// <summary>Gets or sets the path of the message resource file that contains message formatting strings for the source.</summary>
		/// <returns>The path of the message resource file. The default is an empty string ("").</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06001312 RID: 4882 RVA: 0x0000F313 File Offset: 0x0000D513
		// (set) Token: 0x06001313 RID: 4883 RVA: 0x0000F31B File Offset: 0x0000D51B
		public string MessageResourceFile
		{
			get
			{
				return this._messageResourceFile;
			}
			set
			{
				this._messageResourceFile = value;
			}
		}

		/// <summary>Gets or sets the path of the resource file that contains message parameter strings for the source.</summary>
		/// <returns>The path of the parameter resource file. The default is an empty string ("").</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06001314 RID: 4884 RVA: 0x0000F324 File Offset: 0x0000D524
		// (set) Token: 0x06001315 RID: 4885 RVA: 0x0000F32C File Offset: 0x0000D52C
		public string ParameterResourceFile
		{
			get
			{
				return this._parameterResourceFile;
			}
			set
			{
				this._parameterResourceFile = value;
			}
		}

		/// <summary>Gets or sets the name to register with the event log as an event source.</summary>
		/// <returns>The name to register with the event log as a source of entries. The default is an empty string ("").</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06001316 RID: 4886 RVA: 0x0000F335 File Offset: 0x0000D535
		// (set) Token: 0x06001317 RID: 4887 RVA: 0x0000F33D File Offset: 0x0000D53D
		public string Source
		{
			get
			{
				return this._source;
			}
			set
			{
				this._source = value;
			}
		}

		// Token: 0x04000578 RID: 1400
		private string _source;

		// Token: 0x04000579 RID: 1401
		private string _logName;

		// Token: 0x0400057A RID: 1402
		private string _machineName;

		// Token: 0x0400057B RID: 1403
		private string _messageResourceFile;

		// Token: 0x0400057C RID: 1404
		private string _parameterResourceFile;

		// Token: 0x0400057D RID: 1405
		private string _categoryResourceFile;

		// Token: 0x0400057E RID: 1406
		private int _categoryCount;
	}
}
