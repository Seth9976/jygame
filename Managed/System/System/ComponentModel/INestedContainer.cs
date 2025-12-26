using System;

namespace System.ComponentModel
{
	/// <summary>Provides functionality for nested containers, which logically contain zero or more other components and are owned by a parent component.</summary>
	// Token: 0x02000162 RID: 354
	public interface INestedContainer : IDisposable, IContainer
	{
		/// <summary>Gets the owning component for the nested container.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.IComponent" /> that owns the nested container.</returns>
		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000CB4 RID: 3252
		IComponent Owner { get; }
	}
}
