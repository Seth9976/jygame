using System;
using System.ComponentModel;

namespace System.Timers
{
	/// <summary>Sets the description that visual designers can display when referencing an event, extender, or property.</summary>
	// Token: 0x020004CD RID: 1229
	[AttributeUsage(AttributeTargets.All)]
	public class TimersDescriptionAttribute : global::System.ComponentModel.DescriptionAttribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Timers.TimersDescriptionAttribute" /> class.</summary>
		/// <param name="description">The description to use. </param>
		// Token: 0x06002B8E RID: 11150 RVA: 0x0000F60E File Offset: 0x0000D80E
		public TimersDescriptionAttribute(string description)
			: base(description)
		{
		}

		/// <summary>Gets the description that visual designers can display when referencing an event, extender, or property.</summary>
		/// <returns>The description for the event, extender, or property.</returns>
		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x06002B8F RID: 11151 RVA: 0x0000F617 File Offset: 0x0000D817
		public override string Description
		{
			get
			{
				return base.Description;
			}
		}
	}
}
