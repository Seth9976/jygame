using System;

namespace System.ComponentModel
{
	/// <summary>Specifies that a property or method is viewable in an editor. This class cannot be inherited.</summary>
	// Token: 0x02000148 RID: 328
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
	public sealed class EditorBrowsableAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.EditorBrowsableAttribute" /> class with <see cref="P:System.ComponentModel.EditorBrowsableAttribute.State" /> set to the default state.</summary>
		// Token: 0x06000C03 RID: 3075 RVA: 0x0000A686 File Offset: 0x00008886
		public EditorBrowsableAttribute()
		{
			this.state = EditorBrowsableState.Always;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.EditorBrowsableAttribute" /> class with an <see cref="T:System.ComponentModel.EditorBrowsableState" />.</summary>
		/// <param name="state">The <see cref="T:System.ComponentModel.EditorBrowsableState" /> to set <see cref="P:System.ComponentModel.EditorBrowsableAttribute.State" /> to. </param>
		// Token: 0x06000C04 RID: 3076 RVA: 0x0000A695 File Offset: 0x00008895
		public EditorBrowsableAttribute(EditorBrowsableState state)
		{
			this.state = state;
		}

		/// <summary>Gets the browsable state of the property or method.</summary>
		/// <returns>An <see cref="T:System.ComponentModel.EditorBrowsableState" /> that is the browsable state of the property or method.</returns>
		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000C05 RID: 3077 RVA: 0x0000A6A4 File Offset: 0x000088A4
		public EditorBrowsableState State
		{
			get
			{
				return this.state;
			}
		}

		/// <summary>Returns whether the value of the given object is equal to the current <see cref="T:System.ComponentModel.EditorBrowsableAttribute" />.</summary>
		/// <returns>true if the value of the given object is equal to that of the current; otherwise, false.</returns>
		/// <param name="obj">The object to test the value equality of. </param>
		// Token: 0x06000C06 RID: 3078 RVA: 0x0000A6AC File Offset: 0x000088AC
		public override bool Equals(object obj)
		{
			return obj is EditorBrowsableAttribute && (obj == this || ((EditorBrowsableAttribute)obj).State == this.state);
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x0000A6D7 File Offset: 0x000088D7
		public override int GetHashCode()
		{
			return this.state.GetHashCode();
		}

		// Token: 0x04000372 RID: 882
		private EditorBrowsableState state;
	}
}
