using System;
using System.Collections;

namespace System.ComponentModel.Design
{
	/// <summary>Provides support for building a set of related custom designers.</summary>
	// Token: 0x02000125 RID: 293
	public interface ITreeDesigner : IDisposable, IDesigner
	{
		/// <summary>Gets a collection of child designers.</summary>
		/// <returns>An <see cref="T:System.Collections.ICollection" />, containing the collection of <see cref="T:System.ComponentModel.Design.IDesigner" /> child objects of the current designer. </returns>
		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000B3C RID: 2876
		ICollection Children { get; }

		/// <summary>Gets the parent designer.</summary>
		/// <returns>An <see cref="T:System.ComponentModel.Design.IDesigner" /> representing the parent designer, or null if there is no parent.</returns>
		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000B3D RID: 2877
		IDesigner Parent { get; }
	}
}
