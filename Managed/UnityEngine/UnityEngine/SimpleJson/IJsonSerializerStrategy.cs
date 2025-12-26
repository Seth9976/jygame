using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;

namespace SimpleJson
{
	// Token: 0x0200022D RID: 557
	[GeneratedCode("simple-json", "1.0.0")]
	internal interface IJsonSerializerStrategy
	{
		// Token: 0x06001FD1 RID: 8145
		[SuppressMessage("Microsoft.Design", "CA1007:UseGenericsWhereAppropriate", Justification = "Need to support .NET 2")]
		bool TrySerializeNonPrimitiveObject(object input, out object output);

		// Token: 0x06001FD2 RID: 8146
		object DeserializeObject(object value, Type type);
	}
}
