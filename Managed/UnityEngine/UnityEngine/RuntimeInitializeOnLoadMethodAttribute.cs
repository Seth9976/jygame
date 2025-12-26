using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	/// <summary>
	///   <para>Allow an runtime class method to be initialized when Unity game loads runtime without action from the user.</para>
	/// </summary>
	// Token: 0x020002CD RID: 717
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public class RuntimeInitializeOnLoadMethodAttribute : PreserveAttribute
	{
		/// <summary>
		///   <para>Allow an runtime class method to be initialized when Unity game loads runtime without action from the user.</para>
		/// </summary>
		/// <param name="loadType">RuntimeInitializeLoadType: Before or After scene is loaded.</param>
		// Token: 0x060021BF RID: 8639 RVA: 0x0000D8E8 File Offset: 0x0000BAE8
		public RuntimeInitializeOnLoadMethodAttribute()
		{
			this.loadType = RuntimeInitializeLoadType.AfterSceneLoad;
		}

		/// <summary>
		///   <para>Allow an runtime class method to be initialized when Unity game loads runtime without action from the user.</para>
		/// </summary>
		/// <param name="loadType">RuntimeInitializeLoadType: Before or After scene is loaded.</param>
		// Token: 0x060021C0 RID: 8640 RVA: 0x0000D8F7 File Offset: 0x0000BAF7
		public RuntimeInitializeOnLoadMethodAttribute(RuntimeInitializeLoadType loadType)
		{
			this.loadType = loadType;
		}

		/// <summary>
		///   <para>Set RuntimeInitializeOnLoadMethod type.</para>
		/// </summary>
		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x060021C1 RID: 8641 RVA: 0x0000D906 File Offset: 0x0000BB06
		// (set) Token: 0x060021C2 RID: 8642 RVA: 0x0000D90E File Offset: 0x0000BB0E
		public RuntimeInitializeLoadType loadType { get; private set; }
	}
}
