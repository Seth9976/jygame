using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>MonoBehaviour is the base class every script derives from.</para>
	/// </summary>
	// Token: 0x020000B8 RID: 184
	public class MonoBehaviour : Behaviour
	{
		// Token: 0x06000ABC RID: 2748
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern MonoBehaviour();

		// Token: 0x06000ABD RID: 2749
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_CancelInvokeAll();

		// Token: 0x06000ABE RID: 2750
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool Internal_IsInvokingAll();

		/// <summary>
		///   <para>Invokes the method methodName in time seconds.</para>
		/// </summary>
		/// <param name="methodName"></param>
		/// <param name="time"></param>
		// Token: 0x06000ABF RID: 2751
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Invoke(string methodName, float time);

		/// <summary>
		///   <para>Invokes the method methodName in time seconds, then repeatedly every repeatRate seconds.</para>
		/// </summary>
		/// <param name="methodName"></param>
		/// <param name="time"></param>
		/// <param name="repeatRate"></param>
		// Token: 0x06000AC0 RID: 2752
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InvokeRepeating(string methodName, float time, float repeatRate);

		/// <summary>
		///   <para>Cancels all Invoke calls on this MonoBehaviour.</para>
		/// </summary>
		// Token: 0x06000AC1 RID: 2753 RVA: 0x00005D2E File Offset: 0x00003F2E
		public void CancelInvoke()
		{
			this.Internal_CancelInvokeAll();
		}

		/// <summary>
		///   <para>Cancels all Invoke calls with name methodName on this behaviour.</para>
		/// </summary>
		/// <param name="methodName"></param>
		// Token: 0x06000AC2 RID: 2754
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void CancelInvoke(string methodName);

		/// <summary>
		///   <para>Is any invoke on methodName pending?</para>
		/// </summary>
		/// <param name="methodName"></param>
		// Token: 0x06000AC3 RID: 2755
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsInvoking(string methodName);

		/// <summary>
		///   <para>Is any invoke pending on this MonoBehaviour?</para>
		/// </summary>
		// Token: 0x06000AC4 RID: 2756 RVA: 0x00005D36 File Offset: 0x00003F36
		public bool IsInvoking()
		{
			return this.Internal_IsInvokingAll();
		}

		/// <summary>
		///   <para>Starts a coroutine.</para>
		/// </summary>
		/// <param name="routine"></param>
		// Token: 0x06000AC5 RID: 2757 RVA: 0x00005D3E File Offset: 0x00003F3E
		public Coroutine StartCoroutine(IEnumerator routine)
		{
			return this.StartCoroutine_Auto(routine);
		}

		// Token: 0x06000AC6 RID: 2758
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Coroutine StartCoroutine_Auto(IEnumerator routine);

		/// <summary>
		///   <para>Starts a coroutine named methodName.</para>
		/// </summary>
		/// <param name="methodName"></param>
		/// <param name="value"></param>
		// Token: 0x06000AC7 RID: 2759
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Coroutine StartCoroutine(string methodName, [DefaultValue("null")] object value);

		/// <summary>
		///   <para>Starts a coroutine named methodName.</para>
		/// </summary>
		/// <param name="methodName"></param>
		/// <param name="value"></param>
		// Token: 0x06000AC8 RID: 2760 RVA: 0x00016F08 File Offset: 0x00015108
		[ExcludeFromDocs]
		public Coroutine StartCoroutine(string methodName)
		{
			object obj = null;
			return this.StartCoroutine(methodName, obj);
		}

		/// <summary>
		///   <para>Stops the first coroutine named methodName, or the coroutine stored in routine running on this behaviour.</para>
		/// </summary>
		/// <param name="methodName">Name of coroutine.</param>
		/// <param name="routine">Name of the function in code.</param>
		// Token: 0x06000AC9 RID: 2761
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void StopCoroutine(string methodName);

		/// <summary>
		///   <para>Stops the first coroutine named methodName, or the coroutine stored in routine running on this behaviour.</para>
		/// </summary>
		/// <param name="methodName">Name of coroutine.</param>
		/// <param name="routine">Name of the function in code.</param>
		// Token: 0x06000ACA RID: 2762 RVA: 0x00005D47 File Offset: 0x00003F47
		public void StopCoroutine(IEnumerator routine)
		{
			this.StopCoroutineViaEnumerator_Auto(routine);
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x00005D50 File Offset: 0x00003F50
		public void StopCoroutine(Coroutine routine)
		{
			this.StopCoroutine_Auto(routine);
		}

		// Token: 0x06000ACC RID: 2764
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void StopCoroutineViaEnumerator_Auto(IEnumerator routine);

		// Token: 0x06000ACD RID: 2765
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void StopCoroutine_Auto(Coroutine routine);

		/// <summary>
		///   <para>Stops all coroutines running on this behaviour.</para>
		/// </summary>
		// Token: 0x06000ACE RID: 2766
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void StopAllCoroutines();

		/// <summary>
		///   <para>Logs message to the Unity Console (identical to Debug.Log).</para>
		/// </summary>
		/// <param name="message"></param>
		// Token: 0x06000ACF RID: 2767 RVA: 0x00005D59 File Offset: 0x00003F59
		public static void print(object message)
		{
			Debug.Log(message);
		}

		/// <summary>
		///   <para>Disabling this lets you skip the GUI layout phase.</para>
		/// </summary>
		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000AD0 RID: 2768
		// (set) Token: 0x06000AD1 RID: 2769
		public extern bool useGUILayout
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}
	}
}
