using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace System.ComponentModel
{
	/// <summary>Provides a read-only container for a collection of <see cref="T:System.ComponentModel.IComponent" /> objects.</summary>
	// Token: 0x020000E1 RID: 225
	[ComVisible(true)]
	public class ComponentCollection : ReadOnlyCollectionBase
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ComponentCollection" /> class using the specified array of components.</summary>
		/// <param name="components">An array of <see cref="T:System.ComponentModel.IComponent" /> objects to initialize the collection with. </param>
		// Token: 0x0600097C RID: 2428 RVA: 0x00008E22 File Offset: 0x00007022
		public ComponentCollection(IComponent[] components)
		{
			base.InnerList.AddRange(components);
		}

		/// <summary>Gets the <see cref="T:System.ComponentModel.Component" /> in the collection at the specified collection index.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.IComponent" /> at the specified index.</returns>
		/// <param name="index">The collection index of the <see cref="T:System.ComponentModel.Component" /> to get. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">If the specified index is not within the index range of the collection. </exception>
		// Token: 0x17000227 RID: 551
		public virtual IComponent this[int index]
		{
			get
			{
				return (IComponent)base.InnerList[index];
			}
		}

		/// <summary>Gets any component in the collection matching the specified name.</summary>
		/// <returns>A component with a name matching the name specified by the <paramref name="name" /> parameter, or null if the named component cannot be found in the collection.</returns>
		/// <param name="name">The name of the <see cref="T:System.ComponentModel.IComponent" /> to get. </param>
		// Token: 0x17000228 RID: 552
		public virtual IComponent this[string name]
		{
			get
			{
				foreach (object obj in base.InnerList)
				{
					IComponent component = (IComponent)obj;
					if (component.Site != null && component.Site.Name == name)
					{
						return component;
					}
				}
				return null;
			}
		}

		/// <summary>Copies the entire collection to an array, starting writing at the specified array index.</summary>
		/// <param name="array">An <see cref="T:System.ComponentModel.IComponent" /> array to copy the objects in the collection to. </param>
		/// <param name="index">The index of the <paramref name="array" /> at which copying to should begin. </param>
		// Token: 0x0600097F RID: 2431 RVA: 0x00008E49 File Offset: 0x00007049
		public void CopyTo(IComponent[] array, int index)
		{
			base.InnerList.CopyTo(array, index);
		}
	}
}
