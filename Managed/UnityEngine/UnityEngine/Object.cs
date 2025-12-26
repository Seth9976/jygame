using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Internal;
using UnityEngineInternal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Base class for all objects Unity can reference.</para>
	/// </summary>
	// Token: 0x020000C6 RID: 198
	[StructLayout(LayoutKind.Sequential)]
	public class Object
	{
		// Token: 0x06000B50 RID: 2896
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Object Internal_CloneSingle(Object data);

		// Token: 0x06000B51 RID: 2897 RVA: 0x00005F34 File Offset: 0x00004134
		private static Object Internal_InstantiateSingle(Object data, Vector3 pos, Quaternion rot)
		{
			return Object.INTERNAL_CALL_Internal_InstantiateSingle(data, ref pos, ref rot);
		}

		// Token: 0x06000B52 RID: 2898
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Object INTERNAL_CALL_Internal_InstantiateSingle(Object data, ref Vector3 pos, ref Quaternion rot);

		/// <summary>
		///   <para>Removes a gameobject, component or asset.</para>
		/// </summary>
		/// <param name="obj">The object to destroy.</param>
		/// <param name="t">The optional amount of time to delay before destroying the object.</param>
		// Token: 0x06000B53 RID: 2899
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Destroy(Object obj, [DefaultValue("0.0F")] float t);

		/// <summary>
		///   <para>Removes a gameobject, component or asset.</para>
		/// </summary>
		/// <param name="obj">The object to destroy.</param>
		/// <param name="t">The optional amount of time to delay before destroying the object.</param>
		// Token: 0x06000B54 RID: 2900 RVA: 0x00017058 File Offset: 0x00015258
		[ExcludeFromDocs]
		public static void Destroy(Object obj)
		{
			float num = 0f;
			Object.Destroy(obj, num);
		}

		/// <summary>
		///   <para>Destroys the object obj immediately. You are strongly recommended to use Destroy instead.</para>
		/// </summary>
		/// <param name="obj">Object to be destroyed.</param>
		/// <param name="allowDestroyingAssets">Set to true to allow assets to be destoyed.</param>
		// Token: 0x06000B55 RID: 2901
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyImmediate(Object obj, [DefaultValue("false")] bool allowDestroyingAssets);

		/// <summary>
		///   <para>Destroys the object obj immediately. You are strongly recommended to use Destroy instead.</para>
		/// </summary>
		/// <param name="obj">Object to be destroyed.</param>
		/// <param name="allowDestroyingAssets">Set to true to allow assets to be destoyed.</param>
		// Token: 0x06000B56 RID: 2902 RVA: 0x00017074 File Offset: 0x00015274
		[ExcludeFromDocs]
		public static void DestroyImmediate(Object obj)
		{
			bool flag = false;
			Object.DestroyImmediate(obj, flag);
		}

		/// <summary>
		///   <para>Returns a list of all active loaded objects of Type type.</para>
		/// </summary>
		/// <param name="type">The type of object to find.</param>
		/// <returns>
		///   <para>The array of objects found matching the type specified.</para>
		/// </returns>
		// Token: 0x06000B57 RID: 2903
		[WrapperlessIcall]
		[TypeInferenceRule(TypeInferenceRules.ArrayOfTypeReferencedByFirstArgument)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Object[] FindObjectsOfType(Type type);

		/// <summary>
		///   <para>The name of the object.</para>
		/// </summary>
		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000B58 RID: 2904
		// (set) Token: 0x06000B59 RID: 2905
		public extern string name
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Makes the object target not be destroyed automatically when loading a new scene.</para>
		/// </summary>
		/// <param name="target"></param>
		// Token: 0x06000B5A RID: 2906
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DontDestroyOnLoad(Object target);

		/// <summary>
		///   <para>Should the object be hidden, saved with the scene or modifiable by the user?</para>
		/// </summary>
		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000B5B RID: 2907
		// (set) Token: 0x06000B5C RID: 2908
		public extern HideFlags hideFlags
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06000B5D RID: 2909
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyObject(Object obj, [DefaultValue("0.0F")] float t);

		// Token: 0x06000B5E RID: 2910 RVA: 0x0001708C File Offset: 0x0001528C
		[ExcludeFromDocs]
		public static void DestroyObject(Object obj)
		{
			float num = 0f;
			Object.DestroyObject(obj, num);
		}

		// Token: 0x06000B5F RID: 2911
		[WrapperlessIcall]
		[Obsolete("use Object.FindObjectsOfType instead.")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Object[] FindSceneObjectsOfType(Type type);

		/// <summary>
		///   <para>Returns a list of all active and inactive loaded objects of Type type, including assets.</para>
		/// </summary>
		/// <param name="type">The type of object or asset to find.</param>
		/// <returns>
		///   <para>The array of objects and assets found matching the type specified.</para>
		/// </returns>
		// Token: 0x06000B60 RID: 2912
		[WrapperlessIcall]
		[Obsolete("use Resources.FindObjectsOfTypeAll instead.")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Object[] FindObjectsOfTypeIncludingAssets(Type type);

		/// <summary>
		///   <para>Returns a list of all active and inactive loaded objects of Type type.</para>
		/// </summary>
		/// <param name="type">The type of object to find.</param>
		/// <returns>
		///   <para>The array of objects found matching the type specified.</para>
		/// </returns>
		// Token: 0x06000B61 RID: 2913 RVA: 0x00005F40 File Offset: 0x00004140
		[Obsolete("Please use Resources.FindObjectsOfTypeAll instead")]
		public static Object[] FindObjectsOfTypeAll(Type type)
		{
			return Resources.FindObjectsOfTypeAll(type);
		}

		/// <summary>
		///   <para>Returns the name of the game object.</para>
		/// </summary>
		// Token: 0x06000B62 RID: 2914
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public override extern string ToString();

		// Token: 0x06000B63 RID: 2915
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool DoesObjectWithInstanceIDExist(int instanceID);

		// Token: 0x06000B64 RID: 2916 RVA: 0x00005F48 File Offset: 0x00004148
		public override bool Equals(object o)
		{
			return Object.CompareBaseObjects(this, o as Object);
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x00005F56 File Offset: 0x00004156
		public override int GetHashCode()
		{
			return this.GetInstanceID();
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x000170A8 File Offset: 0x000152A8
		private static bool CompareBaseObjects(Object lhs, Object rhs)
		{
			bool flag = lhs == null;
			bool flag2 = rhs == null;
			if (flag2 && flag)
			{
				return true;
			}
			if (flag2)
			{
				return !Object.IsNativeObjectAlive(lhs);
			}
			if (flag)
			{
				return !Object.IsNativeObjectAlive(rhs);
			}
			return lhs.m_InstanceID == rhs.m_InstanceID;
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00005F5E File Offset: 0x0000415E
		private static bool IsNativeObjectAlive(Object o)
		{
			return o.GetCachedPtr() != IntPtr.Zero;
		}

		/// <summary>
		///   <para>Returns the instance id of the object.</para>
		/// </summary>
		// Token: 0x06000B68 RID: 2920 RVA: 0x00005F70 File Offset: 0x00004170
		public int GetInstanceID()
		{
			return this.m_InstanceID;
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x00005F78 File Offset: 0x00004178
		private IntPtr GetCachedPtr()
		{
			return this.m_CachedPtr;
		}

		/// <summary>
		///   <para>Clones the object original and returns the clone.</para>
		/// </summary>
		/// <param name="original">An existing object that you want to make a copy of.</param>
		/// <param name="position">Position for the new object.</param>
		/// <param name="rotation">Orientation of the new object.</param>
		// Token: 0x06000B6A RID: 2922 RVA: 0x00005F80 File Offset: 0x00004180
		[TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
		public static Object Instantiate(Object original, Vector3 position, Quaternion rotation)
		{
			Object.CheckNullArgument(original, "The thing you want to instantiate is null.");
			return Object.Internal_InstantiateSingle(original, position, rotation);
		}

		/// <summary>
		///   <para>Clones the object original and returns the clone.</para>
		/// </summary>
		/// <param name="original">An existing object that you want to make a copy of.</param>
		/// <param name="position">Position for the new object.</param>
		/// <param name="rotation">Orientation of the new object.</param>
		// Token: 0x06000B6B RID: 2923 RVA: 0x00005F95 File Offset: 0x00004195
		[TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
		public static Object Instantiate(Object original)
		{
			Object.CheckNullArgument(original, "The thing you want to instantiate is null.");
			return Object.Internal_CloneSingle(original);
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00005FA8 File Offset: 0x000041A8
		public static T Instantiate<T>(T original) where T : Object
		{
			Object.CheckNullArgument(original, "The thing you want to instantiate is null.");
			return (T)((object)Object.Internal_CloneSingle(original));
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x00005FCA File Offset: 0x000041CA
		private static void CheckNullArgument(object arg, string message)
		{
			if (arg == null)
			{
				throw new ArgumentException(message);
			}
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x00005FD9 File Offset: 0x000041D9
		public static T[] FindObjectsOfType<T>() where T : Object
		{
			return Resources.ConvertObjects<T>(Object.FindObjectsOfType(typeof(T)));
		}

		/// <summary>
		///   <para>Returns the first active loaded object of Type type.</para>
		/// </summary>
		/// <param name="type"></param>
		// Token: 0x06000B6F RID: 2927 RVA: 0x000170FC File Offset: 0x000152FC
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public static Object FindObjectOfType(Type type)
		{
			Object[] array = Object.FindObjectsOfType(type);
			if (array.Length > 0)
			{
				return array[0];
			}
			return null;
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00005FEF File Offset: 0x000041EF
		public static T FindObjectOfType<T>() where T : Object
		{
			return (T)((object)Object.FindObjectOfType(typeof(T)));
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00006005 File Offset: 0x00004205
		public static implicit operator bool(Object exists)
		{
			return !Object.CompareBaseObjects(exists, null);
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x00006011 File Offset: 0x00004211
		public static bool operator ==(Object x, Object y)
		{
			return Object.CompareBaseObjects(x, y);
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x0000601A File Offset: 0x0000421A
		public static bool operator !=(Object x, Object y)
		{
			return !Object.CompareBaseObjects(x, y);
		}

		// Token: 0x0400025A RID: 602
		private int m_InstanceID;

		// Token: 0x0400025B RID: 603
		private IntPtr m_CachedPtr;
	}
}
