using System;

namespace JetBrains.Annotations
{
	// Token: 0x0200029D RID: 669
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
	public sealed class NotifyPropertyChangedInvocatorAttribute : Attribute
	{
		// Token: 0x060020B8 RID: 8376 RVA: 0x0000286A File Offset: 0x00000A6A
		public NotifyPropertyChangedInvocatorAttribute()
		{
		}

		// Token: 0x060020B9 RID: 8377 RVA: 0x0000CFAF File Offset: 0x0000B1AF
		public NotifyPropertyChangedInvocatorAttribute(string parameterName)
		{
			this.ParameterName = parameterName;
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x060020BA RID: 8378 RVA: 0x0000CFBE File Offset: 0x0000B1BE
		// (set) Token: 0x060020BB RID: 8379 RVA: 0x0000CFC6 File Offset: 0x0000B1C6
		public string ParameterName { get; private set; }
	}
}
