using System;
using System.Collections;
using System.Collections.Specialized;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace System.ComponentModel
{
	/// <summary>Provides simple functionality for enumerating resources for a component or object. The <see cref="T:System.ComponentModel.ComponentResourceManager" /> class is a <see cref="T:System.Resources.ResourceManager" />.</summary>
	// Token: 0x020000E5 RID: 229
	public class ComponentResourceManager : ResourceManager
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ComponentResourceManager" /> class with default values.</summary>
		// Token: 0x06000994 RID: 2452 RVA: 0x00008F7C File Offset: 0x0000717C
		public ComponentResourceManager()
		{
		}

		/// <summary>Creates a <see cref="T:System.ComponentModel.ComponentResourceManager" /> that looks up resources in satellite assemblies based on information from the specified <see cref="T:System.Type" />.</summary>
		/// <param name="t">A <see cref="T:System.Type" /> from which the <see cref="T:System.ComponentModel.ComponentResourceManager" /> derives all information for finding resource files. </param>
		// Token: 0x06000995 RID: 2453 RVA: 0x00008F84 File Offset: 0x00007184
		public ComponentResourceManager(Type t)
			: base(t)
		{
		}

		/// <summary>Applies a resource's value to the corresponding property of the object.</summary>
		/// <param name="value">An <see cref="T:System.Object" /> that contains the property value to be applied. </param>
		/// <param name="objectName">A <see cref="T:System.String" /> that contains the name of the object to look up in the resources. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> or <paramref name="objectName" /> is null.</exception>
		// Token: 0x06000996 RID: 2454 RVA: 0x00008F8D File Offset: 0x0000718D
		public void ApplyResources(object value, string objectName)
		{
			this.ApplyResources(value, objectName, null);
		}

		/// <summary>Applies a resource's value to the corresponding property of the object.</summary>
		/// <param name="value">An <see cref="T:System.Object" /> that contains the property value to be applied. </param>
		/// <param name="objectName">A <see cref="T:System.String" /> that contains the name of the object to look up in the resources.</param>
		/// <param name="culture">The culture for which to apply resources.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> or <paramref name="objectName" /> is null.</exception>
		// Token: 0x06000997 RID: 2455 RVA: 0x0002F8A4 File Offset: 0x0002DAA4
		public virtual void ApplyResources(object value, string objectName, CultureInfo culture)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (objectName == null)
			{
				throw new ArgumentNullException("objectName");
			}
			if (culture == null)
			{
				culture = CultureInfo.CurrentUICulture;
			}
			Hashtable hashtable = ((!this.IgnoreCase) ? new Hashtable() : global::System.Collections.Specialized.CollectionsUtil.CreateCaseInsensitiveHashtable());
			this.BuildResources(culture, hashtable);
			string text = objectName + ".";
			CompareOptions compareOptions = ((!this.IgnoreCase) ? CompareOptions.None : CompareOptions.IgnoreCase);
			Type type = value.GetType();
			BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.Public;
			if (this.IgnoreCase)
			{
				bindingFlags |= BindingFlags.IgnoreCase;
			}
			foreach (object obj in hashtable)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
				string text2 = (string)dictionaryEntry.Key;
				if (culture.CompareInfo.IsPrefix(text2, text, compareOptions))
				{
					string text3 = text2.Substring(text.Length);
					PropertyInfo property = type.GetProperty(text3, bindingFlags);
					if (property != null && property.CanWrite)
					{
						object value2 = dictionaryEntry.Value;
						if (value2 == null || property.PropertyType.IsInstanceOfType(value2))
						{
							property.SetValue(value, value2, null);
						}
					}
				}
			}
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x0002FA18 File Offset: 0x0002DC18
		private void BuildResources(CultureInfo culture, Hashtable resources)
		{
			if (culture != culture.Parent)
			{
				this.BuildResources(culture.Parent, resources);
			}
			ResourceSet resourceSet = this.GetResourceSet(culture, true, false);
			if (resourceSet != null)
			{
				foreach (object obj in resourceSet)
				{
					DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
					resources[(string)dictionaryEntry.Key] = dictionaryEntry.Value;
				}
			}
		}
	}
}
