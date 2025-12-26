using System;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

namespace UnityEngine
{
	/// <summary>
	///   <para>ShaderVariantCollection records which shader variants are actually used in each shader.</para>
	/// </summary>
	// Token: 0x02000088 RID: 136
	public sealed class ShaderVariantCollection : Object
	{
		/// <summary>
		///   <para>Create a new empty shader variant collection.</para>
		/// </summary>
		// Token: 0x06000837 RID: 2103 RVA: 0x000053DF File Offset: 0x000035DF
		public ShaderVariantCollection()
		{
			ShaderVariantCollection.Internal_Create(this);
		}

		// Token: 0x06000838 RID: 2104
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Create([Writable] ShaderVariantCollection mono);

		/// <summary>
		///   <para>Number of shaders in this collection (Read Only).</para>
		/// </summary>
		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000839 RID: 2105
		public extern int shaderCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Number of total varians in this collection (Read Only).</para>
		/// </summary>
		// Token: 0x170001DD RID: 477
		// (get) Token: 0x0600083A RID: 2106
		public extern int variantCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x000053ED File Offset: 0x000035ED
		public bool Add(ShaderVariantCollection.ShaderVariant variant)
		{
			return this.AddInternal(variant.shader, variant.passType, variant.keywords);
		}

		// Token: 0x0600083C RID: 2108
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool AddInternal(Shader shader, PassType passType, string[] keywords);

		// Token: 0x0600083D RID: 2109 RVA: 0x0000540A File Offset: 0x0000360A
		public bool Remove(ShaderVariantCollection.ShaderVariant variant)
		{
			return this.RemoveInternal(variant.shader, variant.passType, variant.keywords);
		}

		// Token: 0x0600083E RID: 2110
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool RemoveInternal(Shader shader, PassType passType, string[] keywords);

		// Token: 0x0600083F RID: 2111 RVA: 0x00005427 File Offset: 0x00003627
		public bool Contains(ShaderVariantCollection.ShaderVariant variant)
		{
			return this.ContainsInternal(variant.shader, variant.passType, variant.keywords);
		}

		// Token: 0x06000840 RID: 2112
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool ContainsInternal(Shader shader, PassType passType, string[] keywords);

		/// <summary>
		///   <para>Remove all shader variants from the collection.</para>
		/// </summary>
		// Token: 0x06000841 RID: 2113
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Clear();

		/// <summary>
		///   <para>Is this ShaderVariantCollection already warmed up? (Read Only)</para>
		/// </summary>
		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000842 RID: 2114
		public extern bool isWarmedUp
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Fully load shaders in ShaderVariantCollection.</para>
		/// </summary>
		// Token: 0x06000843 RID: 2115
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void WarmUp();

		/// <summary>
		///   <para>Identifies a specific variant of a shader.</para>
		/// </summary>
		// Token: 0x02000089 RID: 137
		public struct ShaderVariant
		{
			/// <summary>
			///   <para>Creates a ShaderVariant structure.</para>
			/// </summary>
			/// <param name="shader"></param>
			/// <param name="passType"></param>
			/// <param name="keywords"></param>
			// Token: 0x06000844 RID: 2116 RVA: 0x00005444 File Offset: 0x00003644
			public ShaderVariant(Shader shader, PassType passType, params string[] keywords)
			{
				this.shader = shader;
				this.passType = passType;
				this.keywords = keywords;
				ShaderVariantCollection.ShaderVariant.Internal_CheckVariant(shader, passType, keywords);
			}

			// Token: 0x06000845 RID: 2117
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void Internal_CheckVariant(Shader shader, PassType passType, string[] keywords);

			/// <summary>
			///   <para>Shader to use in this variant.</para>
			/// </summary>
			// Token: 0x0400017F RID: 383
			public Shader shader;

			/// <summary>
			///   <para>Pass type to use in this variant.</para>
			/// </summary>
			// Token: 0x04000180 RID: 384
			public PassType passType;

			/// <summary>
			///   <para>Array of shader keywords to use in this variant.</para>
			/// </summary>
			// Token: 0x04000181 RID: 385
			public string[] keywords;
		}
	}
}
