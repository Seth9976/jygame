using System;
using System.Runtime.CompilerServices;
using UnityEngineInternal;

namespace UnityEngine
{
	/// <summary>
	///   <para>The Resources class allows you to find and access Objects including assets.</para>
	/// </summary>
	// Token: 0x0200007E RID: 126
	public sealed class Resources
	{
		// Token: 0x060007AD RID: 1965 RVA: 0x00014610 File Offset: 0x00012810
		internal static T[] ConvertObjects<T>(Object[] rawObjects) where T : Object
		{
			if (rawObjects == null)
			{
				return null;
			}
			T[] array = new T[rawObjects.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (T)((object)rawObjects[i]);
			}
			return array;
		}

		/// <summary>
		///   <para>Returns a list of all objects of Type type.</para>
		/// </summary>
		/// <param name="type">Type of the class to match while searching.</param>
		/// <returns>
		///   <para>An array of objects whose class is type or is derived from type.</para>
		/// </returns>
		// Token: 0x060007AE RID: 1966
		[WrapperlessIcall]
		[TypeInferenceRule(TypeInferenceRules.ArrayOfTypeReferencedByFirstArgument)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Object[] FindObjectsOfTypeAll(Type type);

		// Token: 0x060007AF RID: 1967 RVA: 0x000050EB File Offset: 0x000032EB
		public static T[] FindObjectsOfTypeAll<T>() where T : Object
		{
			return Resources.ConvertObjects<T>(Resources.FindObjectsOfTypeAll(typeof(T)));
		}

		/// <summary>
		///   <para>Loads an asset stored at path in a Resources folder.</para>
		/// </summary>
		/// <param name="path">Pathname of the target folder.</param>
		// Token: 0x060007B0 RID: 1968 RVA: 0x00005101 File Offset: 0x00003301
		public static Object Load(string path)
		{
			return Resources.Load(path, typeof(Object));
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00005113 File Offset: 0x00003313
		public static T Load<T>(string path) where T : Object
		{
			return (T)((object)Resources.Load(path, typeof(T)));
		}

		/// <summary>
		///   <para>Loads an asset stored at path in a Resources folder.</para>
		/// </summary>
		/// <param name="path">Pathname of the target folder.</param>
		/// <param name="systemTypeInstance">Type filter for objects returned.</param>
		// Token: 0x060007B2 RID: 1970
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedBySecondArgument)]
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Object Load(string path, Type systemTypeInstance);

		/// <summary>
		///   <para>Asynchronously loads an asset stored at path in a Resources folder.</para>
		/// </summary>
		/// <param name="path">Pathname of the target folder.</param>
		// Token: 0x060007B3 RID: 1971 RVA: 0x0000512A File Offset: 0x0000332A
		public static ResourceRequest LoadAsync(string path)
		{
			return Resources.LoadAsync(path, typeof(Object));
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x0000513C File Offset: 0x0000333C
		public static ResourceRequest LoadAsync<T>(string path) where T : Object
		{
			return Resources.LoadAsync(path, typeof(T));
		}

		/// <summary>
		///   <para>Asynchronously loads an asset stored at path in a Resources folder.</para>
		/// </summary>
		/// <param name="path">Pathname of the target folder.</param>
		/// <param name="systemTypeInstance">Type filter for objects returned.</param>
		/// <param name="type"></param>
		// Token: 0x060007B5 RID: 1973
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern ResourceRequest LoadAsync(string path, Type type);

		/// <summary>
		///   <para>Loads all assets in a folder or file at path in a Resources folder.</para>
		/// </summary>
		/// <param name="path">Pathname of the target folder.</param>
		/// <param name="systemTypeInstance">Type filter for objects returned.</param>
		// Token: 0x060007B6 RID: 1974
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Object[] LoadAll(string path, Type systemTypeInstance);

		/// <summary>
		///   <para>Loads all assets in a folder or file at path in a Resources folder.</para>
		/// </summary>
		/// <param name="path">Pathname of the target folder.</param>
		// Token: 0x060007B7 RID: 1975 RVA: 0x0000514E File Offset: 0x0000334E
		public static Object[] LoadAll(string path)
		{
			return Resources.LoadAll(path, typeof(Object));
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00005160 File Offset: 0x00003360
		public static T[] LoadAll<T>(string path) where T : Object
		{
			return Resources.ConvertObjects<T>(Resources.LoadAll(path, typeof(T)));
		}

		// Token: 0x060007B9 RID: 1977
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Object GetBuiltinResource(Type type, string path);

		// Token: 0x060007BA RID: 1978 RVA: 0x00005177 File Offset: 0x00003377
		public static T GetBuiltinResource<T>(string path) where T : Object
		{
			return (T)((object)Resources.GetBuiltinResource(typeof(T), path));
		}

		/// <summary>
		///   <para>Unloads assetToUnload from memory.</para>
		/// </summary>
		/// <param name="assetToUnload"></param>
		// Token: 0x060007BB RID: 1979
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnloadAsset(Object assetToUnload);

		/// <summary>
		///   <para>Unloads assets that are not used.</para>
		/// </summary>
		/// <returns>
		///   <para>Object on which you can yield to wait until the operation completes.</para>
		/// </returns>
		// Token: 0x060007BC RID: 1980
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern AsyncOperation UnloadUnusedAssets();
	}
}
