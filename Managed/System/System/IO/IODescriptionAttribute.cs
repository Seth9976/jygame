using System;
using System.ComponentModel;

namespace System.IO
{
	/// <summary>Sets the description visual designers can display when referencing an event, extender, or property.</summary>
	/// <filterpriority>1</filterpriority>
	// Token: 0x02000296 RID: 662
	[AttributeUsage(AttributeTargets.All)]
	public class IODescriptionAttribute : global::System.ComponentModel.DescriptionAttribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.IO.IODescriptionAttribute" /> class.</summary>
		/// <param name="description">The description to use. </param>
		// Token: 0x06001709 RID: 5897 RVA: 0x0000F60E File Offset: 0x0000D80E
		public IODescriptionAttribute(string description)
			: base(description)
		{
		}

		/// <summary>Gets the description.</summary>
		/// <returns>The description for the event, extender, or property.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x0600170A RID: 5898 RVA: 0x00009694 File Offset: 0x00007894
		public override string Description
		{
			get
			{
				return base.DescriptionValue;
			}
		}
	}
}
