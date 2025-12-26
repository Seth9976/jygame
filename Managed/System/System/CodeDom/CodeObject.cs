using System;
using System.Collections;
using System.Collections.Specialized;
using System.Runtime.InteropServices;

namespace System.CodeDom
{
	/// <summary>Provides a common base class for most Code Document Object Model (CodeDOM) objects.</summary>
	// Token: 0x02000054 RID: 84
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[ComVisible(true)]
	[Serializable]
	public class CodeObject
	{
		/// <summary>Gets the user-definable data for the current object.</summary>
		/// <returns>An <see cref="T:System.Collections.IDictionary" /> containing user data for the current object.</returns>
		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x00004179 File Offset: 0x00002379
		public IDictionary UserData
		{
			get
			{
				if (this.userData == null)
				{
					this.userData = new global::System.Collections.Specialized.ListDictionary();
				}
				return this.userData;
			}
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00002664 File Offset: 0x00000864
		internal virtual void Accept(ICodeDomVisitor visitor)
		{
			throw new NotImplementedException();
		}

		// Token: 0x040000DE RID: 222
		private IDictionary userData;
	}
}
