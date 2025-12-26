using System;

namespace System.ComponentModel
{
	/// <summary>Specifies which event is raised on initialization. This class cannot be inherited.</summary>
	// Token: 0x02000166 RID: 358
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class InitializationEventAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.InitializationEventAttribute" /> class.</summary>
		/// <param name="eventName">The name of the initialization event.</param>
		// Token: 0x06000CBE RID: 3262 RVA: 0x0000ABBA File Offset: 0x00008DBA
		public InitializationEventAttribute(string eventName)
		{
			this.eventName = eventName;
		}

		/// <summary>Gets the name of the initialization event.</summary>
		/// <returns>The name of the initialization event.</returns>
		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x0000ABC9 File Offset: 0x00008DC9
		public string EventName
		{
			get
			{
				return this.eventName;
			}
		}

		// Token: 0x04000392 RID: 914
		private string eventName;
	}
}
