using System;

namespace UnityEngine.Internal
{
	// Token: 0x020002FD RID: 765
	[AttributeUsage(AttributeTargets.Parameter | AttributeTargets.GenericParameter)]
	[Serializable]
	public class DefaultValueAttribute : Attribute
	{
		// Token: 0x06002351 RID: 9041 RVA: 0x0000EAD4 File Offset: 0x0000CCD4
		public DefaultValueAttribute(string value)
		{
			this.DefaultValue = value;
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06002352 RID: 9042 RVA: 0x0000EAE3 File Offset: 0x0000CCE3
		public object Value
		{
			get
			{
				return this.DefaultValue;
			}
		}

		// Token: 0x06002353 RID: 9043 RVA: 0x0002E4A0 File Offset: 0x0002C6A0
		public override bool Equals(object obj)
		{
			DefaultValueAttribute defaultValueAttribute = obj as DefaultValueAttribute;
			if (defaultValueAttribute == null)
			{
				return false;
			}
			if (this.DefaultValue == null)
			{
				return defaultValueAttribute.Value == null;
			}
			return this.DefaultValue.Equals(defaultValueAttribute.Value);
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x0000EAEB File Offset: 0x0000CCEB
		public override int GetHashCode()
		{
			if (this.DefaultValue == null)
			{
				return base.GetHashCode();
			}
			return this.DefaultValue.GetHashCode();
		}

		// Token: 0x04000BB1 RID: 2993
		private object DefaultValue;
	}
}
