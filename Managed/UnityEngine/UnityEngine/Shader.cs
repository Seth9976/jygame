using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Shader scripts used for all rendering.</para>
	/// </summary>
	// Token: 0x02000086 RID: 134
	public sealed class Shader : Object
	{
		/// <summary>
		///   <para>Finds a shader with the given name.</para>
		/// </summary>
		/// <param name="name"></param>
		// Token: 0x060007D2 RID: 2002
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Shader Find(string name);

		// Token: 0x060007D3 RID: 2003
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Shader FindBuiltin(string name);

		/// <summary>
		///   <para>Can this shader run on the end-users graphics card? (Read Only)</para>
		/// </summary>
		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060007D4 RID: 2004
		public extern bool isSupported
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Set a global shader keyword.</para>
		/// </summary>
		/// <param name="keyword"></param>
		// Token: 0x060007D5 RID: 2005
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EnableKeyword(string keyword);

		/// <summary>
		///   <para>Unset a global shader keyword.</para>
		/// </summary>
		/// <param name="keyword"></param>
		// Token: 0x060007D6 RID: 2006
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DisableKeyword(string keyword);

		/// <summary>
		///   <para>Is global shader keyword enabled?</para>
		/// </summary>
		/// <param name="keyword"></param>
		// Token: 0x060007D7 RID: 2007
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsKeywordEnabled(string keyword);

		/// <summary>
		///   <para>Shader LOD level for this shader.</para>
		/// </summary>
		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060007D8 RID: 2008
		// (set) Token: 0x060007D9 RID: 2009
		public extern int maximumLOD
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Shader LOD level for all shaders.</para>
		/// </summary>
		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060007DA RID: 2010
		// (set) Token: 0x060007DB RID: 2011
		public static extern int globalMaximumLOD
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Render queue of this shader. (Read Only)</para>
		/// </summary>
		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060007DC RID: 2012
		public extern int renderQueue
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060007DD RID: 2013
		internal extern DisableBatchingType disableBatching
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Sets a global color property for all shaders.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="color"></param>
		/// <param name="nameID"></param>
		// Token: 0x060007DE RID: 2014 RVA: 0x00005196 File Offset: 0x00003396
		public static void SetGlobalColor(string propertyName, Color color)
		{
			Shader.SetGlobalColor(Shader.PropertyToID(propertyName), color);
		}

		/// <summary>
		///   <para>Sets a global color property for all shaders.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="color"></param>
		/// <param name="nameID"></param>
		// Token: 0x060007DF RID: 2015 RVA: 0x000051A4 File Offset: 0x000033A4
		public static void SetGlobalColor(int nameID, Color color)
		{
			Shader.INTERNAL_CALL_SetGlobalColor(nameID, ref color);
		}

		// Token: 0x060007E0 RID: 2016
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetGlobalColor(int nameID, ref Color color);

		/// <summary>
		///   <para>Sets a global vector property for all shaders.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="vec"></param>
		/// <param name="nameID"></param>
		// Token: 0x060007E1 RID: 2017 RVA: 0x000051AE File Offset: 0x000033AE
		public static void SetGlobalVector(string propertyName, Vector4 vec)
		{
			Shader.SetGlobalColor(propertyName, vec);
		}

		/// <summary>
		///   <para>Sets a global vector property for all shaders.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="vec"></param>
		/// <param name="nameID"></param>
		// Token: 0x060007E2 RID: 2018 RVA: 0x000051BC File Offset: 0x000033BC
		public static void SetGlobalVector(int nameID, Vector4 vec)
		{
			Shader.SetGlobalColor(nameID, vec);
		}

		/// <summary>
		///   <para>Sets a global float property for all shaders.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x060007E3 RID: 2019 RVA: 0x000051CA File Offset: 0x000033CA
		public static void SetGlobalFloat(string propertyName, float value)
		{
			Shader.SetGlobalFloat(Shader.PropertyToID(propertyName), value);
		}

		/// <summary>
		///   <para>Sets a global float property for all shaders.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x060007E4 RID: 2020
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetGlobalFloat(int nameID, float value);

		/// <summary>
		///   <para>Sets a global int property for all shaders.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x060007E5 RID: 2021 RVA: 0x000051D8 File Offset: 0x000033D8
		public static void SetGlobalInt(string propertyName, int value)
		{
			Shader.SetGlobalFloat(propertyName, (float)value);
		}

		/// <summary>
		///   <para>Sets a global int property for all shaders.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x060007E6 RID: 2022 RVA: 0x000051E2 File Offset: 0x000033E2
		public static void SetGlobalInt(int nameID, int value)
		{
			Shader.SetGlobalFloat(nameID, (float)value);
		}

		/// <summary>
		///   <para>Sets a global texture property for all shaders.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="tex"></param>
		/// <param name="nameID"></param>
		// Token: 0x060007E7 RID: 2023 RVA: 0x000051EC File Offset: 0x000033EC
		public static void SetGlobalTexture(string propertyName, Texture tex)
		{
			Shader.SetGlobalTexture(Shader.PropertyToID(propertyName), tex);
		}

		/// <summary>
		///   <para>Sets a global texture property for all shaders.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="tex"></param>
		/// <param name="nameID"></param>
		// Token: 0x060007E8 RID: 2024
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetGlobalTexture(int nameID, Texture tex);

		/// <summary>
		///   <para>Sets a global matrix property for all shaders.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="mat"></param>
		/// <param name="nameID"></param>
		// Token: 0x060007E9 RID: 2025 RVA: 0x000051FA File Offset: 0x000033FA
		public static void SetGlobalMatrix(string propertyName, Matrix4x4 mat)
		{
			Shader.SetGlobalMatrix(Shader.PropertyToID(propertyName), mat);
		}

		/// <summary>
		///   <para>Sets a global matrix property for all shaders.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="mat"></param>
		/// <param name="nameID"></param>
		// Token: 0x060007EA RID: 2026 RVA: 0x00005208 File Offset: 0x00003408
		public static void SetGlobalMatrix(int nameID, Matrix4x4 mat)
		{
			Shader.INTERNAL_CALL_SetGlobalMatrix(nameID, ref mat);
		}

		// Token: 0x060007EB RID: 2027
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetGlobalMatrix(int nameID, ref Matrix4x4 mat);

		// Token: 0x060007EC RID: 2028
		[WrapperlessIcall]
		[Obsolete("SetGlobalTexGenMode is not supported anymore. Use programmable shaders to achieve the same effect.", true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetGlobalTexGenMode(string propertyName, TexGenMode mode);

		// Token: 0x060007ED RID: 2029
		[Obsolete("SetGlobalTextureMatrixName is not supported anymore. Use programmable shaders to achieve the same effect.", true)]
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetGlobalTextureMatrixName(string propertyName, string matrixName);

		/// <summary>
		///   <para>Sets a global compute buffer property for all shaders.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="buffer"></param>
		// Token: 0x060007EE RID: 2030
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetGlobalBuffer(string propertyName, ComputeBuffer buffer);

		/// <summary>
		///   <para>Gets unique identifier for a shader property name.</para>
		/// </summary>
		/// <param name="name"></param>
		// Token: 0x060007EF RID: 2031
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int PropertyToID(string name);

		/// <summary>
		///   <para>Fully load all shaders to prevent future performance hiccups.</para>
		/// </summary>
		// Token: 0x060007F0 RID: 2032
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void WarmupAllShaders();
	}
}
