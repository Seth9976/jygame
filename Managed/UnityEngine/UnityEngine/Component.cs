using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine.Internal;
using UnityEngineInternal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Base class for everything attached to GameObjects.</para>
	/// </summary>
	// Token: 0x020000C7 RID: 199
	public class Component : Object
	{
		/// <summary>
		///   <para>The Transform attached to this GameObject (null if there is none attached).</para>
		/// </summary>
		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000B75 RID: 2933
		public extern Transform transform
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The game object this component is attached to. A component is always attached to a game object.</para>
		/// </summary>
		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000B76 RID: 2934
		public extern GameObject gameObject
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns the component of Type type if the game object has one attached, null if it doesn't.</para>
		/// </summary>
		/// <param name="type">The type of Component to retrieve.</param>
		// Token: 0x06000B77 RID: 2935 RVA: 0x00006026 File Offset: 0x00004226
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component GetComponent(Type type)
		{
			return this.gameObject.GetComponent(type);
		}

		// Token: 0x06000B78 RID: 2936
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue);

		// Token: 0x06000B79 RID: 2937 RVA: 0x00017120 File Offset: 0x00015320
		[SecuritySafeCritical]
		public unsafe T GetComponent<T>()
		{
			CastHelper<T> castHelper = default(CastHelper<T>);
			this.GetComponentFastPath(typeof(T), new IntPtr((void*)(&castHelper.onePointerFurtherThanT)));
			return castHelper.t;
		}

		/// <summary>
		///   <para>Returns the component with name type if the game object has one attached, null if it doesn't.</para>
		/// </summary>
		/// <param name="type"></param>
		// Token: 0x06000B7A RID: 2938
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Component GetComponent(string type);

		/// <summary>
		///   <para>Returns the component of Type type in the GameObject or any of its children using depth first search.</para>
		/// </summary>
		/// <param name="t">The type of Component to retrieve.</param>
		// Token: 0x06000B7B RID: 2939 RVA: 0x00006034 File Offset: 0x00004234
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component GetComponentInChildren(Type t)
		{
			return this.gameObject.GetComponentInChildren(t);
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x00006042 File Offset: 0x00004242
		public T GetComponentInChildren<T>()
		{
			return (T)((object)this.GetComponentInChildren(typeof(T)));
		}

		/// <summary>
		///   <para>Returns all components of Type type in the GameObject or any of its children.</para>
		/// </summary>
		/// <param name="t">The type of Component to retrieve.</param>
		/// <param name="includeInactive">Should Components on inactive GameObjects be included in the found set?</param>
		// Token: 0x06000B7D RID: 2941 RVA: 0x00017158 File Offset: 0x00015358
		[ExcludeFromDocs]
		public Component[] GetComponentsInChildren(Type t)
		{
			bool flag = false;
			return this.GetComponentsInChildren(t, flag);
		}

		/// <summary>
		///   <para>Returns all components of Type type in the GameObject or any of its children.</para>
		/// </summary>
		/// <param name="t">The type of Component to retrieve.</param>
		/// <param name="includeInactive">Should Components on inactive GameObjects be included in the found set?</param>
		// Token: 0x06000B7E RID: 2942 RVA: 0x00006059 File Offset: 0x00004259
		public Component[] GetComponentsInChildren(Type t, [DefaultValue("false")] bool includeInactive)
		{
			return this.gameObject.GetComponentsInChildren(t, includeInactive);
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x00006068 File Offset: 0x00004268
		public T[] GetComponentsInChildren<T>(bool includeInactive)
		{
			return this.gameObject.GetComponentsInChildren<T>(includeInactive);
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x00006076 File Offset: 0x00004276
		public void GetComponentsInChildren<T>(bool includeInactive, List<T> result)
		{
			this.gameObject.GetComponentsInChildren<T>(includeInactive, result);
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x00006085 File Offset: 0x00004285
		public T[] GetComponentsInChildren<T>()
		{
			return this.GetComponentsInChildren<T>(false);
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x0000608E File Offset: 0x0000428E
		public void GetComponentsInChildren<T>(List<T> results)
		{
			this.GetComponentsInChildren<T>(false, results);
		}

		/// <summary>
		///   <para>Returns the component of Type type in the GameObject or any of its parents.</para>
		/// </summary>
		/// <param name="t">The type of Component to retrieve.</param>
		// Token: 0x06000B83 RID: 2947 RVA: 0x00006098 File Offset: 0x00004298
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component GetComponentInParent(Type t)
		{
			return this.gameObject.GetComponentInParent(t);
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x000060A6 File Offset: 0x000042A6
		public T GetComponentInParent<T>()
		{
			return (T)((object)this.GetComponentInParent(typeof(T)));
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00017170 File Offset: 0x00015370
		[ExcludeFromDocs]
		public Component[] GetComponentsInParent(Type t)
		{
			bool flag = false;
			return this.GetComponentsInParent(t, flag);
		}

		/// <summary>
		///   <para>Returns all components of Type type in the GameObject or any of its parents.</para>
		/// </summary>
		/// <param name="t">The type of Component to retrieve.</param>
		/// <param name="includeInactive">Should inactive Components be included in the found set?</param>
		// Token: 0x06000B86 RID: 2950 RVA: 0x000060BD File Offset: 0x000042BD
		public Component[] GetComponentsInParent(Type t, [DefaultValue("false")] bool includeInactive)
		{
			return this.gameObject.GetComponentsInParent(t, includeInactive);
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x000060CC File Offset: 0x000042CC
		public T[] GetComponentsInParent<T>(bool includeInactive)
		{
			return this.gameObject.GetComponentsInParent<T>(includeInactive);
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x000060DA File Offset: 0x000042DA
		public void GetComponentsInParent<T>(bool includeInactive, List<T> results)
		{
			this.gameObject.GetComponentsInParent<T>(includeInactive, results);
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x000060E9 File Offset: 0x000042E9
		public T[] GetComponentsInParent<T>()
		{
			return this.GetComponentsInParent<T>(false);
		}

		/// <summary>
		///   <para>Returns all components of Type type in the GameObject.</para>
		/// </summary>
		/// <param name="type">The type of Component to retrieve.</param>
		// Token: 0x06000B8A RID: 2954 RVA: 0x000060F2 File Offset: 0x000042F2
		public Component[] GetComponents(Type type)
		{
			return this.gameObject.GetComponents(type);
		}

		// Token: 0x06000B8B RID: 2955
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetComponentsForListInternal(Type searchType, object resultList);

		// Token: 0x06000B8C RID: 2956 RVA: 0x00006100 File Offset: 0x00004300
		public void GetComponents(Type type, List<Component> results)
		{
			this.GetComponentsForListInternal(type, results);
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x0000610A File Offset: 0x0000430A
		public void GetComponents<T>(List<T> results)
		{
			this.GetComponentsForListInternal(typeof(T), results);
		}

		/// <summary>
		///   <para>The tag of this game object.</para>
		/// </summary>
		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000B8E RID: 2958 RVA: 0x0000611D File Offset: 0x0000431D
		// (set) Token: 0x06000B8F RID: 2959 RVA: 0x0000612A File Offset: 0x0000432A
		public string tag
		{
			get
			{
				return this.gameObject.tag;
			}
			set
			{
				this.gameObject.tag = value;
			}
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x00006138 File Offset: 0x00004338
		public T[] GetComponents<T>()
		{
			return this.gameObject.GetComponents<T>();
		}

		/// <summary>
		///   <para>Is this game object tagged with tag ?</para>
		/// </summary>
		/// <param name="tag">The tag to compare.</param>
		// Token: 0x06000B91 RID: 2961
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool CompareTag(string tag);

		/// <summary>
		///   <para>Calls the method named methodName on every MonoBehaviour in this game object and on every ancestor of the behaviour.</para>
		/// </summary>
		/// <param name="methodName">Name of method to call.</param>
		/// <param name="value">Optional parameter value for the method.</param>
		/// <param name="options">Should an error be raised if the method does not exist on the target object?</param>
		// Token: 0x06000B92 RID: 2962
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SendMessageUpwards(string methodName, [DefaultValue("null")] object value, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options);

		/// <summary>
		///   <para>Calls the method named methodName on every MonoBehaviour in this game object and on every ancestor of the behaviour.</para>
		/// </summary>
		/// <param name="methodName">Name of method to call.</param>
		/// <param name="value">Optional parameter value for the method.</param>
		/// <param name="options">Should an error be raised if the method does not exist on the target object?</param>
		// Token: 0x06000B93 RID: 2963 RVA: 0x00017188 File Offset: 0x00015388
		[ExcludeFromDocs]
		public void SendMessageUpwards(string methodName, object value)
		{
			SendMessageOptions sendMessageOptions = SendMessageOptions.RequireReceiver;
			this.SendMessageUpwards(methodName, value, sendMessageOptions);
		}

		/// <summary>
		///   <para>Calls the method named methodName on every MonoBehaviour in this game object and on every ancestor of the behaviour.</para>
		/// </summary>
		/// <param name="methodName">Name of method to call.</param>
		/// <param name="value">Optional parameter value for the method.</param>
		/// <param name="options">Should an error be raised if the method does not exist on the target object?</param>
		// Token: 0x06000B94 RID: 2964 RVA: 0x000171A0 File Offset: 0x000153A0
		[ExcludeFromDocs]
		public void SendMessageUpwards(string methodName)
		{
			SendMessageOptions sendMessageOptions = SendMessageOptions.RequireReceiver;
			object obj = null;
			this.SendMessageUpwards(methodName, obj, sendMessageOptions);
		}

		/// <summary>
		///   <para>Calls the method named methodName on every MonoBehaviour in this game object and on every ancestor of the behaviour.</para>
		/// </summary>
		/// <param name="methodName">Name of method to call.</param>
		/// <param name="value">Optional parameter value for the method.</param>
		/// <param name="options">Should an error be raised if the method does not exist on the target object?</param>
		// Token: 0x06000B95 RID: 2965 RVA: 0x00006145 File Offset: 0x00004345
		public void SendMessageUpwards(string methodName, SendMessageOptions options)
		{
			this.SendMessageUpwards(methodName, null, options);
		}

		/// <summary>
		///   <para>Calls the method named methodName on every MonoBehaviour in this game object.</para>
		/// </summary>
		/// <param name="methodName">Name of the method to call.</param>
		/// <param name="value">Optional parameter for the method.</param>
		/// <param name="options">Should an error be raised if the target object doesn't implement the method for the message?</param>
		// Token: 0x06000B96 RID: 2966
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SendMessage(string methodName, [DefaultValue("null")] object value, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options);

		/// <summary>
		///   <para>Calls the method named methodName on every MonoBehaviour in this game object.</para>
		/// </summary>
		/// <param name="methodName">Name of the method to call.</param>
		/// <param name="value">Optional parameter for the method.</param>
		/// <param name="options">Should an error be raised if the target object doesn't implement the method for the message?</param>
		// Token: 0x06000B97 RID: 2967 RVA: 0x000171BC File Offset: 0x000153BC
		[ExcludeFromDocs]
		public void SendMessage(string methodName, object value)
		{
			SendMessageOptions sendMessageOptions = SendMessageOptions.RequireReceiver;
			this.SendMessage(methodName, value, sendMessageOptions);
		}

		/// <summary>
		///   <para>Calls the method named methodName on every MonoBehaviour in this game object.</para>
		/// </summary>
		/// <param name="methodName">Name of the method to call.</param>
		/// <param name="value">Optional parameter for the method.</param>
		/// <param name="options">Should an error be raised if the target object doesn't implement the method for the message?</param>
		// Token: 0x06000B98 RID: 2968 RVA: 0x000171D4 File Offset: 0x000153D4
		[ExcludeFromDocs]
		public void SendMessage(string methodName)
		{
			SendMessageOptions sendMessageOptions = SendMessageOptions.RequireReceiver;
			object obj = null;
			this.SendMessage(methodName, obj, sendMessageOptions);
		}

		/// <summary>
		///   <para>Calls the method named methodName on every MonoBehaviour in this game object.</para>
		/// </summary>
		/// <param name="methodName">Name of the method to call.</param>
		/// <param name="value">Optional parameter for the method.</param>
		/// <param name="options">Should an error be raised if the target object doesn't implement the method for the message?</param>
		// Token: 0x06000B99 RID: 2969 RVA: 0x00006150 File Offset: 0x00004350
		public void SendMessage(string methodName, SendMessageOptions options)
		{
			this.SendMessage(methodName, null, options);
		}

		/// <summary>
		///   <para>Calls the method named methodName on every MonoBehaviour in this game object or any of its children.</para>
		/// </summary>
		/// <param name="methodName">Name of the method to call.</param>
		/// <param name="parameter">Optional parameter to pass to the method (can be any value).</param>
		/// <param name="options">Should an error be raised if the method does not exist for a given target object?</param>
		// Token: 0x06000B9A RID: 2970
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void BroadcastMessage(string methodName, [DefaultValue("null")] object parameter, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options);

		/// <summary>
		///   <para>Calls the method named methodName on every MonoBehaviour in this game object or any of its children.</para>
		/// </summary>
		/// <param name="methodName">Name of the method to call.</param>
		/// <param name="parameter">Optional parameter to pass to the method (can be any value).</param>
		/// <param name="options">Should an error be raised if the method does not exist for a given target object?</param>
		// Token: 0x06000B9B RID: 2971 RVA: 0x000171F0 File Offset: 0x000153F0
		[ExcludeFromDocs]
		public void BroadcastMessage(string methodName, object parameter)
		{
			SendMessageOptions sendMessageOptions = SendMessageOptions.RequireReceiver;
			this.BroadcastMessage(methodName, parameter, sendMessageOptions);
		}

		/// <summary>
		///   <para>Calls the method named methodName on every MonoBehaviour in this game object or any of its children.</para>
		/// </summary>
		/// <param name="methodName">Name of the method to call.</param>
		/// <param name="parameter">Optional parameter to pass to the method (can be any value).</param>
		/// <param name="options">Should an error be raised if the method does not exist for a given target object?</param>
		// Token: 0x06000B9C RID: 2972 RVA: 0x00017208 File Offset: 0x00015408
		[ExcludeFromDocs]
		public void BroadcastMessage(string methodName)
		{
			SendMessageOptions sendMessageOptions = SendMessageOptions.RequireReceiver;
			object obj = null;
			this.BroadcastMessage(methodName, obj, sendMessageOptions);
		}

		/// <summary>
		///   <para>Calls the method named methodName on every MonoBehaviour in this game object or any of its children.</para>
		/// </summary>
		/// <param name="methodName">Name of the method to call.</param>
		/// <param name="parameter">Optional parameter to pass to the method (can be any value).</param>
		/// <param name="options">Should an error be raised if the method does not exist for a given target object?</param>
		// Token: 0x06000B9D RID: 2973 RVA: 0x0000615B File Offset: 0x0000435B
		public void BroadcastMessage(string methodName, SendMessageOptions options)
		{
			this.BroadcastMessage(methodName, null, options);
		}
	}
}
