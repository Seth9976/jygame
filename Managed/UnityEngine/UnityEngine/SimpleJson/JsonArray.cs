using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;

namespace SimpleJson
{
	// Token: 0x0200022A RID: 554
	[GeneratedCode("simple-json", "1.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal class JsonArray : List<object>
	{
		// Token: 0x06001F9C RID: 8092 RVA: 0x0000C761 File Offset: 0x0000A961
		public JsonArray()
		{
		}

		// Token: 0x06001F9D RID: 8093 RVA: 0x0000C769 File Offset: 0x0000A969
		public JsonArray(int capacity)
			: base(capacity)
		{
		}

		// Token: 0x06001F9E RID: 8094 RVA: 0x0000C772 File Offset: 0x0000A972
		public override string ToString()
		{
			return SimpleJson.SerializeObject(this) ?? string.Empty;
		}
	}
}
