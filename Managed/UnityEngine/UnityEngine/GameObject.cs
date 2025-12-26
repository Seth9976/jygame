using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine.Internal;
using UnityEngineInternal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Base class for all entities in Unity scenes.</para>
	/// </summary>
	// Token: 0x020000C9 RID: 201
	public sealed class GameObject : Object
	{
		/// <summary>
		///   <para>Creates a new game object, named name.</para>
		/// </summary>
		/// <param name="name"></param>
		// Token: 0x06000BD4 RID: 3028 RVA: 0x00006177 File Offset: 0x00004377
		public GameObject(string name)
		{
			GameObject.Internal_CreateGameObject(this, name);
		}

		/// <summary>
		///   <para>Creates a new game object.</para>
		/// </summary>
		// Token: 0x06000BD5 RID: 3029 RVA: 0x00006186 File Offset: 0x00004386
		public GameObject()
		{
			GameObject.Internal_CreateGameObject(this, null);
		}

		/// <summary>
		///   <para>Creates a game object and attaches the specified components.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="components"></param>
		// Token: 0x06000BD6 RID: 3030 RVA: 0x0001723C File Offset: 0x0001543C
		public GameObject(string name, params Type[] components)
		{
			GameObject.Internal_CreateGameObject(this, name);
			foreach (Type type in components)
			{
				this.AddComponent(type);
			}
		}

		/// <summary>
		///   <para>Creates a game object with a primitive mesh renderer and appropriate collider.</para>
		/// </summary>
		/// <param name="type">The type of primitive object to create.</param>
		// Token: 0x06000BD7 RID: 3031
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern GameObject CreatePrimitive(PrimitiveType type);

		/// <summary>
		///   <para>Returns the component of Type type if the game object has one attached, null if it doesn't.</para>
		/// </summary>
		/// <param name="type">The type of Component to retrieve.</param>
		// Token: 0x06000BD8 RID: 3032
		[WrapperlessIcall]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Component GetComponent(Type type);

		// Token: 0x06000BD9 RID: 3033
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue);

		// Token: 0x06000BDA RID: 3034 RVA: 0x00017278 File Offset: 0x00015478
		[SecuritySafeCritical]
		public unsafe T GetComponent<T>()
		{
			CastHelper<T> castHelper = default(CastHelper<T>);
			this.GetComponentFastPath(typeof(T), new IntPtr((void*)(&castHelper.onePointerFurtherThanT)));
			return castHelper.t;
		}

		// Token: 0x06000BDB RID: 3035
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern Component GetComponentByName(string type);

		/// <summary>
		///   <para>Returns the component with name type if the game object has one attached, null if it doesn't.</para>
		/// </summary>
		/// <param name="type">The type of Component to retrieve.</param>
		// Token: 0x06000BDC RID: 3036 RVA: 0x00006195 File Offset: 0x00004395
		public Component GetComponent(string type)
		{
			return this.GetComponentByName(type);
		}

		/// <summary>
		///   <para>Returns the component of Type type in the GameObject or any of its children using depth first search.</para>
		/// </summary>
		/// <param name="type">The type of Component to retrieve.</param>
		// Token: 0x06000BDD RID: 3037 RVA: 0x000172B0 File Offset: 0x000154B0
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component GetComponentInChildren(Type type)
		{
			if (this.activeInHierarchy)
			{
				Component component = this.GetComponent(type);
				if (component != null)
				{
					return component;
				}
			}
			Transform transform = this.transform;
			if (transform != null)
			{
				foreach (object obj in transform)
				{
					Transform transform2 = (Transform)obj;
					Component componentInChildren = transform2.gameObject.GetComponentInChildren(type);
					if (componentInChildren != null)
					{
						return componentInChildren;
					}
				}
			}
			return null;
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x0000619E File Offset: 0x0000439E
		public T GetComponentInChildren<T>()
		{
			return (T)((object)this.GetComponentInChildren(typeof(T)));
		}

		/// <summary>
		///   <para>Finds component in the parent.</para>
		/// </summary>
		/// <param name="type">Type of component to find.</param>
		// Token: 0x06000BDF RID: 3039 RVA: 0x00017368 File Offset: 0x00015568
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component GetComponentInParent(Type type)
		{
			if (this.activeInHierarchy)
			{
				Component component = this.GetComponent(type);
				if (component != null)
				{
					return component;
				}
			}
			Transform transform = this.transform.parent;
			if (transform != null)
			{
				while (transform != null)
				{
					if (transform.gameObject.activeInHierarchy)
					{
						Component component2 = transform.gameObject.GetComponent(type);
						if (component2 != null)
						{
							return component2;
						}
					}
					transform = transform.parent;
				}
			}
			return null;
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x000061B5 File Offset: 0x000043B5
		public T GetComponentInParent<T>()
		{
			return (T)((object)this.GetComponentInParent(typeof(T)));
		}

		/// <summary>
		///   <para>Returns all components of Type type in the GameObject.</para>
		/// </summary>
		/// <param name="type">The type of Component to retrieve.</param>
		// Token: 0x06000BE1 RID: 3041 RVA: 0x000061CC File Offset: 0x000043CC
		public Component[] GetComponents(Type type)
		{
			return (Component[])this.GetComponentsInternal(type, false, false, true, false, null);
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x000061DF File Offset: 0x000043DF
		public T[] GetComponents<T>()
		{
			return (T[])this.GetComponentsInternal(typeof(T), true, false, true, false, null);
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x000061FB File Offset: 0x000043FB
		public void GetComponents(Type type, List<Component> results)
		{
			this.GetComponentsInternal(type, false, false, true, false, results);
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x0000620A File Offset: 0x0000440A
		public void GetComponents<T>(List<T> results)
		{
			this.GetComponentsInternal(typeof(T), false, false, true, false, results);
		}

		/// <summary>
		///   <para>Returns all components of Type type in the GameObject or any of its children.</para>
		/// </summary>
		/// <param name="type">The type of Component to retrieve.</param>
		/// <param name="includeInactive">Should Components on inactive GameObjects be included in the found set?</param>
		// Token: 0x06000BE5 RID: 3045 RVA: 0x000173F4 File Offset: 0x000155F4
		[ExcludeFromDocs]
		public Component[] GetComponentsInChildren(Type type)
		{
			bool flag = false;
			return this.GetComponentsInChildren(type, flag);
		}

		/// <summary>
		///   <para>Returns all components of Type type in the GameObject or any of its children.</para>
		/// </summary>
		/// <param name="type">The type of Component to retrieve.</param>
		/// <param name="includeInactive">Should Components on inactive GameObjects be included in the found set?</param>
		// Token: 0x06000BE6 RID: 3046 RVA: 0x00006222 File Offset: 0x00004422
		public Component[] GetComponentsInChildren(Type type, [DefaultValue("false")] bool includeInactive)
		{
			return (Component[])this.GetComponentsInternal(type, false, true, includeInactive, false, null);
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x00006235 File Offset: 0x00004435
		public T[] GetComponentsInChildren<T>(bool includeInactive)
		{
			return (T[])this.GetComponentsInternal(typeof(T), true, true, includeInactive, false, null);
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x00006251 File Offset: 0x00004451
		public void GetComponentsInChildren<T>(bool includeInactive, List<T> results)
		{
			this.GetComponentsInternal(typeof(T), true, true, includeInactive, false, results);
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x00006269 File Offset: 0x00004469
		public T[] GetComponentsInChildren<T>()
		{
			return this.GetComponentsInChildren<T>(false);
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x00006272 File Offset: 0x00004472
		public void GetComponentsInChildren<T>(List<T> results)
		{
			this.GetComponentsInChildren<T>(false, results);
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x0001740C File Offset: 0x0001560C
		[ExcludeFromDocs]
		public Component[] GetComponentsInParent(Type type)
		{
			bool flag = false;
			return this.GetComponentsInParent(type, flag);
		}

		/// <summary>
		///   <para>Returns all components of Type type in the GameObject or any of its parents.</para>
		/// </summary>
		/// <param name="type">The type of Component to retrieve.</param>
		/// <param name="includeInactive">Should inactive Components be included in the found set?</param>
		// Token: 0x06000BEC RID: 3052 RVA: 0x0000627C File Offset: 0x0000447C
		public Component[] GetComponentsInParent(Type type, [DefaultValue("false")] bool includeInactive)
		{
			return (Component[])this.GetComponentsInternal(type, false, true, includeInactive, true, null);
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x0000628F File Offset: 0x0000448F
		public void GetComponentsInParent<T>(bool includeInactive, List<T> results)
		{
			this.GetComponentsInternal(typeof(T), true, true, includeInactive, true, results);
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x000062A7 File Offset: 0x000044A7
		public T[] GetComponentsInParent<T>(bool includeInactive)
		{
			return (T[])this.GetComponentsInternal(typeof(T), true, true, includeInactive, true, null);
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x000062C3 File Offset: 0x000044C3
		public T[] GetComponentsInParent<T>()
		{
			return this.GetComponentsInParent<T>(false);
		}

		// Token: 0x06000BF0 RID: 3056
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList);

		// Token: 0x06000BF1 RID: 3057
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern Component AddComponentInternal(string className);

		/// <summary>
		///   <para>The Transform attached to this GameObject. (null if there is none attached).</para>
		/// </summary>
		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000BF2 RID: 3058
		public extern Transform transform
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The layer the game object is in. A layer is in the range [0...31].</para>
		/// </summary>
		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000BF3 RID: 3059
		// (set) Token: 0x06000BF4 RID: 3060
		public extern int layer
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000BF5 RID: 3061
		// (set) Token: 0x06000BF6 RID: 3062
		[Obsolete("GameObject.active is obsolete. Use GameObject.SetActive(), GameObject.activeSelf or GameObject.activeInHierarchy.")]
		public extern bool active
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Activates/Deactivates the GameObject.</para>
		/// </summary>
		/// <param name="value">Activate or deactivation the  object.</param>
		// Token: 0x06000BF7 RID: 3063
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetActive(bool value);

		/// <summary>
		///   <para>The local active state of this GameObject. (Read Only)</para>
		/// </summary>
		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000BF8 RID: 3064
		public extern bool activeSelf
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Is the GameObject active in the scene?</para>
		/// </summary>
		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000BF9 RID: 3065
		public extern bool activeInHierarchy
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x06000BFA RID: 3066
		[WrapperlessIcall]
		[Obsolete("gameObject.SetActiveRecursively() is obsolete. Use GameObject.SetActive(), which is now inherited by children.")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetActiveRecursively(bool state);

		/// <summary>
		///   <para>Editor only API that specifies if a game object is static.</para>
		/// </summary>
		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000BFB RID: 3067
		// (set) Token: 0x06000BFC RID: 3068
		public extern bool isStatic
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000BFD RID: 3069
		internal extern bool isStaticBatchable
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The tag of this game object.</para>
		/// </summary>
		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000BFE RID: 3070
		// (set) Token: 0x06000BFF RID: 3071
		public extern string tag
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Is this game object tagged with tag ?</para>
		/// </summary>
		/// <param name="tag">The tag to compare.</param>
		// Token: 0x06000C00 RID: 3072
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool CompareTag(string tag);

		// Token: 0x06000C01 RID: 3073
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern GameObject FindGameObjectWithTag(string tag);

		/// <summary>
		///   <para>Returns one active GameObject tagged tag. Returns null if no GameObject was found.</para>
		/// </summary>
		/// <param name="tag">The tag to search for.</param>
		// Token: 0x06000C02 RID: 3074 RVA: 0x000062CC File Offset: 0x000044CC
		public static GameObject FindWithTag(string tag)
		{
			return GameObject.FindGameObjectWithTag(tag);
		}

		/// <summary>
		///   <para>Returns a list of active GameObjects tagged tag. Returns empty array if no GameObject was found.</para>
		/// </summary>
		/// <param name="tag">The name of the tag to search GameObjects for.</param>
		// Token: 0x06000C03 RID: 3075
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern GameObject[] FindGameObjectsWithTag(string tag);

		/// <summary>
		///   <para>Calls the method named methodName on every MonoBehaviour in this game object and on every ancestor of the behaviour.</para>
		/// </summary>
		/// <param name="methodName">The name of the method to call.</param>
		/// <param name="value">An optional parameter value to pass to the called method.</param>
		/// <param name="options">Should an error be raised if the method doesn't exist on the target object?</param>
		// Token: 0x06000C04 RID: 3076
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SendMessageUpwards(string methodName, [DefaultValue("null")] object value, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options);

		/// <summary>
		///   <para>Calls the method named methodName on every MonoBehaviour in this game object and on every ancestor of the behaviour.</para>
		/// </summary>
		/// <param name="methodName">The name of the method to call.</param>
		/// <param name="value">An optional parameter value to pass to the called method.</param>
		/// <param name="options">Should an error be raised if the method doesn't exist on the target object?</param>
		// Token: 0x06000C05 RID: 3077 RVA: 0x00017424 File Offset: 0x00015624
		[ExcludeFromDocs]
		public void SendMessageUpwards(string methodName, object value)
		{
			SendMessageOptions sendMessageOptions = SendMessageOptions.RequireReceiver;
			this.SendMessageUpwards(methodName, value, sendMessageOptions);
		}

		/// <summary>
		///   <para>Calls the method named methodName on every MonoBehaviour in this game object and on every ancestor of the behaviour.</para>
		/// </summary>
		/// <param name="methodName">The name of the method to call.</param>
		/// <param name="value">An optional parameter value to pass to the called method.</param>
		/// <param name="options">Should an error be raised if the method doesn't exist on the target object?</param>
		// Token: 0x06000C06 RID: 3078 RVA: 0x0001743C File Offset: 0x0001563C
		[ExcludeFromDocs]
		public void SendMessageUpwards(string methodName)
		{
			SendMessageOptions sendMessageOptions = SendMessageOptions.RequireReceiver;
			object obj = null;
			this.SendMessageUpwards(methodName, obj, sendMessageOptions);
		}

		/// <summary>
		///   <para></para>
		/// </summary>
		/// <param name="methodName"></param>
		/// <param name="options"></param>
		// Token: 0x06000C07 RID: 3079 RVA: 0x000062D4 File Offset: 0x000044D4
		public void SendMessageUpwards(string methodName, SendMessageOptions options)
		{
			this.SendMessageUpwards(methodName, null, options);
		}

		/// <summary>
		///   <para>Calls the method named methodName on every MonoBehaviour in this game object.</para>
		/// </summary>
		/// <param name="methodName">The name of the method to call.</param>
		/// <param name="value">An optional parameter value to pass to the called method.</param>
		/// <param name="options">Should an error be raised if the method doesn't exist on the target object?</param>
		// Token: 0x06000C08 RID: 3080
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SendMessage(string methodName, [DefaultValue("null")] object value, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options);

		/// <summary>
		///   <para>Calls the method named methodName on every MonoBehaviour in this game object.</para>
		/// </summary>
		/// <param name="methodName">The name of the method to call.</param>
		/// <param name="value">An optional parameter value to pass to the called method.</param>
		/// <param name="options">Should an error be raised if the method doesn't exist on the target object?</param>
		// Token: 0x06000C09 RID: 3081 RVA: 0x00017458 File Offset: 0x00015658
		[ExcludeFromDocs]
		public void SendMessage(string methodName, object value)
		{
			SendMessageOptions sendMessageOptions = SendMessageOptions.RequireReceiver;
			this.SendMessage(methodName, value, sendMessageOptions);
		}

		/// <summary>
		///   <para>Calls the method named methodName on every MonoBehaviour in this game object.</para>
		/// </summary>
		/// <param name="methodName">The name of the method to call.</param>
		/// <param name="value">An optional parameter value to pass to the called method.</param>
		/// <param name="options">Should an error be raised if the method doesn't exist on the target object?</param>
		// Token: 0x06000C0A RID: 3082 RVA: 0x00017470 File Offset: 0x00015670
		[ExcludeFromDocs]
		public void SendMessage(string methodName)
		{
			SendMessageOptions sendMessageOptions = SendMessageOptions.RequireReceiver;
			object obj = null;
			this.SendMessage(methodName, obj, sendMessageOptions);
		}

		/// <summary>
		///   <para></para>
		/// </summary>
		/// <param name="methodName"></param>
		/// <param name="options"></param>
		// Token: 0x06000C0B RID: 3083 RVA: 0x000062DF File Offset: 0x000044DF
		public void SendMessage(string methodName, SendMessageOptions options)
		{
			this.SendMessage(methodName, null, options);
		}

		/// <summary>
		///   <para>Calls the method named methodName on every MonoBehaviour in this game object or any of its children.</para>
		/// </summary>
		/// <param name="methodName"></param>
		/// <param name="parameter"></param>
		/// <param name="options"></param>
		// Token: 0x06000C0C RID: 3084
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void BroadcastMessage(string methodName, [DefaultValue("null")] object parameter, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options);

		/// <summary>
		///   <para>Calls the method named methodName on every MonoBehaviour in this game object or any of its children.</para>
		/// </summary>
		/// <param name="methodName"></param>
		/// <param name="parameter"></param>
		/// <param name="options"></param>
		// Token: 0x06000C0D RID: 3085 RVA: 0x0001748C File Offset: 0x0001568C
		[ExcludeFromDocs]
		public void BroadcastMessage(string methodName, object parameter)
		{
			SendMessageOptions sendMessageOptions = SendMessageOptions.RequireReceiver;
			this.BroadcastMessage(methodName, parameter, sendMessageOptions);
		}

		/// <summary>
		///   <para>Calls the method named methodName on every MonoBehaviour in this game object or any of its children.</para>
		/// </summary>
		/// <param name="methodName"></param>
		/// <param name="parameter"></param>
		/// <param name="options"></param>
		// Token: 0x06000C0E RID: 3086 RVA: 0x000174A4 File Offset: 0x000156A4
		[ExcludeFromDocs]
		public void BroadcastMessage(string methodName)
		{
			SendMessageOptions sendMessageOptions = SendMessageOptions.RequireReceiver;
			object obj = null;
			this.BroadcastMessage(methodName, obj, sendMessageOptions);
		}

		/// <summary>
		///   <para></para>
		/// </summary>
		/// <param name="methodName"></param>
		/// <param name="options"></param>
		// Token: 0x06000C0F RID: 3087 RVA: 0x000062EA File Offset: 0x000044EA
		public void BroadcastMessage(string methodName, SendMessageOptions options)
		{
			this.BroadcastMessage(methodName, null, options);
		}

		// Token: 0x06000C10 RID: 3088
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Component Internal_AddComponentWithType(Type componentType);

		/// <summary>
		///   <para>Adds a component class of type componentType to the game object. C# Users can use a generic version.</para>
		/// </summary>
		/// <param name="componentType"></param>
		// Token: 0x06000C11 RID: 3089 RVA: 0x000062F5 File Offset: 0x000044F5
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component AddComponent(Type componentType)
		{
			return this.Internal_AddComponentWithType(componentType);
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x000062FE File Offset: 0x000044FE
		public T AddComponent<T>() where T : Component
		{
			return this.AddComponent(typeof(T)) as T;
		}

		// Token: 0x06000C13 RID: 3091
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CreateGameObject([Writable] GameObject mono, string name);

		/// <summary>
		///   <para>Finds a game object by name and returns it.</para>
		/// </summary>
		/// <param name="name"></param>
		// Token: 0x06000C14 RID: 3092
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern GameObject Find(string name);

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000C15 RID: 3093 RVA: 0x0000631A File Offset: 0x0000451A
		public GameObject gameObject
		{
			get
			{
				return this;
			}
		}
	}
}
