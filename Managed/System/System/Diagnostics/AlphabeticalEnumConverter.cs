using System;
using System.ComponentModel;

namespace System.Diagnostics
{
	// Token: 0x02000211 RID: 529
	internal sealed class AlphabeticalEnumConverter : global::System.ComponentModel.EnumConverter
	{
		// Token: 0x060011A9 RID: 4521 RVA: 0x0000E40A File Offset: 0x0000C60A
		public AlphabeticalEnumConverter(Type type)
			: base(type)
		{
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x0000E413 File Offset: 0x0000C613
		[global::System.MonoTODO("Create sorted standart values")]
		public override global::System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(global::System.ComponentModel.ITypeDescriptorContext context)
		{
			return base.Values;
		}
	}
}
