using System;
using System.ComponentModel;

namespace System.Diagnostics
{
	/// <summary>Specifies a description for a property or event.</summary>
	/// <filterpriority>1</filterpriority>
	// Token: 0x02000238 RID: 568
	[AttributeUsage(AttributeTargets.All)]
	public class MonitoringDescriptionAttribute : global::System.ComponentModel.DescriptionAttribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.MonitoringDescriptionAttribute" /> class, using the specified description.</summary>
		/// <param name="description">The application-defined description text. </param>
		// Token: 0x06001373 RID: 4979 RVA: 0x0000F60E File Offset: 0x0000D80E
		public MonitoringDescriptionAttribute(string description)
			: base(description)
		{
		}

		/// <summary>Gets description text associated with the item monitored.</summary>
		/// <returns>An application-defined description.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06001374 RID: 4980 RVA: 0x0000F617 File Offset: 0x0000D817
		public override string Description
		{
			get
			{
				return base.Description;
			}
		}
	}
}
