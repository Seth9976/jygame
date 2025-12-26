using System;

namespace System.ComponentModel
{
	/// <summary>Provides the ability to retrieve the full nested name of a component.</summary>
	// Token: 0x02000163 RID: 355
	public interface INestedSite : IServiceProvider, ISite
	{
		/// <summary>Gets the full name of the component in this site.</summary>
		/// <returns>The full name of the component in this site.</returns>
		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000CB5 RID: 3253
		string FullName { get; }
	}
}
