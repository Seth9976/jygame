using System;
using System.Reflection;

namespace System.Diagnostics
{
	/// <summary>Identifies a switch used in an assembly, class, or member.</summary>
	/// <filterpriority>1</filterpriority>
	// Token: 0x02000258 RID: 600
	[global::System.MonoLimitation("This attribute is not considered in trace support.")]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event)]
	public sealed class SwitchAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.SwitchAttribute" /> class, specifying the name and the type of the switch. </summary>
		/// <param name="switchName">The display name of the switch.</param>
		/// <param name="switchType">The type of the switch.</param>
		// Token: 0x060014FE RID: 5374 RVA: 0x00042130 File Offset: 0x00040330
		public SwitchAttribute(string switchName, Type switchType)
		{
			if (switchName == null)
			{
				throw new ArgumentNullException("switchName");
			}
			if (switchType == null)
			{
				throw new ArgumentNullException("switchType");
			}
			this.name = switchName;
			this.type = switchType;
		}

		/// <summary>Returns all switch attributes for the specified assembly.</summary>
		/// <returns>An array of type <see cref="T:System.Diagnostics.SwitchAttribute" /> that contains all the switch attributes for the assembly.</returns>
		/// <param name="assembly">The <see cref="T:System.Reflection.Assembly" /> to check for switch attributes.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="assembly" /> is null.</exception>
		/// <filterpriority>1</filterpriority>
		// Token: 0x060014FF RID: 5375 RVA: 0x00042180 File Offset: 0x00040380
		public static SwitchAttribute[] GetAll(Assembly assembly)
		{
			object[] customAttributes = assembly.GetCustomAttributes(typeof(SwitchAttribute), false);
			SwitchAttribute[] array = new SwitchAttribute[customAttributes.Length];
			for (int i = 0; i < customAttributes.Length; i++)
			{
				array[i] = (SwitchAttribute)customAttributes[i];
			}
			return array;
		}

		/// <summary>Gets or sets the display name of the switch.</summary>
		/// <returns>The display name of the switch.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <see cref="P:System.Diagnostics.SwitchAttribute.SwitchName" /> is set to null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <see cref="P:System.Diagnostics.SwitchAttribute.SwitchName" /> is set to an empty string.</exception>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06001500 RID: 5376 RVA: 0x000102CA File Offset: 0x0000E4CA
		// (set) Token: 0x06001501 RID: 5377 RVA: 0x000102D2 File Offset: 0x0000E4D2
		public string SwitchName
		{
			get
			{
				return this.name;
			}
			set
			{
				if (this.name == null)
				{
					throw new ArgumentNullException("value");
				}
				this.name = value;
			}
		}

		/// <summary>Gets or sets the description of the switch.</summary>
		/// <returns>The description of the switch.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001502 RID: 5378 RVA: 0x000102F1 File Offset: 0x0000E4F1
		// (set) Token: 0x06001503 RID: 5379 RVA: 0x000102F9 File Offset: 0x0000E4F9
		public string SwitchDescription
		{
			get
			{
				return this.desc;
			}
			set
			{
				if (this.desc == null)
				{
					throw new ArgumentNullException("value");
				}
				this.desc = value;
			}
		}

		/// <summary>Gets or sets the type of the switch.</summary>
		/// <returns>A <see cref="T:System.Type" /> object that represents the type of the switch.</returns>
		/// <exception cref="T:System.ArgumentNullException">P:System.Diagnostics.SwitchAttribute.SwitchType is set to null.</exception>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x00010318 File Offset: 0x0000E518
		// (set) Token: 0x06001505 RID: 5381 RVA: 0x00010320 File Offset: 0x0000E520
		public Type SwitchType
		{
			get
			{
				return this.type;
			}
			set
			{
				if (this.type == null)
				{
					throw new ArgumentNullException("value");
				}
				this.type = value;
			}
		}

		// Token: 0x04000666 RID: 1638
		private string name;

		// Token: 0x04000667 RID: 1639
		private string desc = string.Empty;

		// Token: 0x04000668 RID: 1640
		private Type type;
	}
}
