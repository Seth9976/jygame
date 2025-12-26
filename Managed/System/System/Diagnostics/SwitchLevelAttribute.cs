using System;

namespace System.Diagnostics
{
	/// <summary>Identifies the level type for a switch. </summary>
	/// <filterpriority>1</filterpriority>
	// Token: 0x02000259 RID: 601
	[global::System.MonoLimitation("This attribute is not considered in trace support.")]
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class SwitchLevelAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.SwitchLevelAttribute" /> class, specifying the type that determines whether a trace should be written.</summary>
		/// <param name="switchLevelType">The <see cref="T:System.Type" /> that determines whether a trace should be written.</param>
		// Token: 0x06001506 RID: 5382 RVA: 0x0001033F File Offset: 0x0000E53F
		public SwitchLevelAttribute(Type switchLevelType)
		{
			if (switchLevelType == null)
			{
				throw new ArgumentNullException("switchLevelType");
			}
			this.type = switchLevelType;
		}

		/// <summary>Gets or sets the type that determines whether a trace should be written.</summary>
		/// <returns>The <see cref="T:System.Type" /> that determines whether a trace should be written.</returns>
		/// <exception cref="T:System.ArgumentNullException">The set operation failed because the value is null.</exception>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001507 RID: 5383 RVA: 0x0001035F File Offset: 0x0000E55F
		// (set) Token: 0x06001508 RID: 5384 RVA: 0x00010367 File Offset: 0x0000E567
		public Type SwitchLevelType
		{
			get
			{
				return this.type;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				this.type = value;
			}
		}

		// Token: 0x04000669 RID: 1641
		private Type type;
	}
}
