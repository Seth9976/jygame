using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Gradient used for animating colors.</para>
	/// </summary>
	// Token: 0x0200004F RID: 79
	[StructLayout(LayoutKind.Sequential)]
	public sealed class Gradient
	{
		/// <summary>
		///   <para>Create a new Gradient object.</para>
		/// </summary>
		// Token: 0x06000424 RID: 1060 RVA: 0x00002C21 File Offset: 0x00000E21
		public Gradient()
		{
			this.Init();
		}

		// Token: 0x06000425 RID: 1061
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Init();

		// Token: 0x06000426 RID: 1062
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Cleanup();

		// Token: 0x06000427 RID: 1063 RVA: 0x00010120 File Offset: 0x0000E320
		~Gradient()
		{
			this.Cleanup();
		}

		/// <summary>
		///   <para>Calculate color at a given time.</para>
		/// </summary>
		/// <param name="time">Time of the key (0 - 1).</param>
		// Token: 0x06000428 RID: 1064
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Color Evaluate(float time);

		/// <summary>
		///   <para>All color keys defined in the gradient.</para>
		/// </summary>
		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000429 RID: 1065
		// (set) Token: 0x0600042A RID: 1066
		public extern GradientColorKey[] colorKeys
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>All alpha keys defined in the gradient.</para>
		/// </summary>
		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600042B RID: 1067
		// (set) Token: 0x0600042C RID: 1068
		public extern GradientAlphaKey[] alphaKeys
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Setup Gradient with an array of color keys and alpha keys.</para>
		/// </summary>
		/// <param name="colorKeys">Color keys of the gradient (maximum 8 color keys).</param>
		/// <param name="alphaKeys">Alpha keys of the gradient (maximum 8 alpha keys).</param>
		// Token: 0x0600042D RID: 1069
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetKeys(GradientColorKey[] colorKeys, GradientAlphaKey[] alphaKeys);

		// Token: 0x040000C0 RID: 192
		internal IntPtr m_Ptr;
	}
}
