using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>A block of material values to apply.</para>
	/// </summary>
	// Token: 0x02000029 RID: 41
	public sealed class MaterialPropertyBlock
	{
		// Token: 0x060001F1 RID: 497 RVA: 0x00002493 File Offset: 0x00000693
		public MaterialPropertyBlock()
		{
			this.InitBlock();
		}

		// Token: 0x060001F2 RID: 498
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void InitBlock();

		// Token: 0x060001F3 RID: 499
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void DestroyBlock();

		// Token: 0x060001F4 RID: 500 RVA: 0x0000F3F0 File Offset: 0x0000D5F0
		~MaterialPropertyBlock()
		{
			this.DestroyBlock();
		}

		/// <summary>
		///   <para>Is the material property block empty? (Read Only)</para>
		/// </summary>
		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001F5 RID: 501
		public extern bool isEmpty
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Set a float property.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x060001F6 RID: 502 RVA: 0x000024A1 File Offset: 0x000006A1
		public void SetFloat(string name, float value)
		{
			this.SetFloat(Shader.PropertyToID(name), value);
		}

		/// <summary>
		///   <para>Set a float property.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x060001F7 RID: 503
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetFloat(int nameID, float value);

		/// <summary>
		///   <para>Set a vector property.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x060001F8 RID: 504 RVA: 0x000024B0 File Offset: 0x000006B0
		public void SetVector(string name, Vector4 value)
		{
			this.SetVector(Shader.PropertyToID(name), value);
		}

		/// <summary>
		///   <para>Set a vector property.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x060001F9 RID: 505 RVA: 0x000024BF File Offset: 0x000006BF
		public void SetVector(int nameID, Vector4 value)
		{
			MaterialPropertyBlock.INTERNAL_CALL_SetVector(this, nameID, ref value);
		}

		// Token: 0x060001FA RID: 506
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetVector(MaterialPropertyBlock self, int nameID, ref Vector4 value);

		/// <summary>
		///   <para>Set a color property.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x060001FB RID: 507 RVA: 0x000024CA File Offset: 0x000006CA
		public void SetColor(string name, Color value)
		{
			this.SetColor(Shader.PropertyToID(name), value);
		}

		/// <summary>
		///   <para>Set a color property.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x060001FC RID: 508 RVA: 0x000024D9 File Offset: 0x000006D9
		public void SetColor(int nameID, Color value)
		{
			MaterialPropertyBlock.INTERNAL_CALL_SetColor(this, nameID, ref value);
		}

		// Token: 0x060001FD RID: 509
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetColor(MaterialPropertyBlock self, int nameID, ref Color value);

		/// <summary>
		///   <para>Set a matrix property.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x060001FE RID: 510 RVA: 0x000024E4 File Offset: 0x000006E4
		public void SetMatrix(string name, Matrix4x4 value)
		{
			this.SetMatrix(Shader.PropertyToID(name), value);
		}

		/// <summary>
		///   <para>Set a matrix property.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x060001FF RID: 511 RVA: 0x000024F3 File Offset: 0x000006F3
		public void SetMatrix(int nameID, Matrix4x4 value)
		{
			MaterialPropertyBlock.INTERNAL_CALL_SetMatrix(this, nameID, ref value);
		}

		// Token: 0x06000200 RID: 512
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetMatrix(MaterialPropertyBlock self, int nameID, ref Matrix4x4 value);

		/// <summary>
		///   <para>Set a texture property.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000201 RID: 513 RVA: 0x000024FE File Offset: 0x000006FE
		public void SetTexture(string name, Texture value)
		{
			this.SetTexture(Shader.PropertyToID(name), value);
		}

		/// <summary>
		///   <para>Set a texture property.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000202 RID: 514
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetTexture(int nameID, Texture value);

		/// <summary>
		///   <para>Add a float material property.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000203 RID: 515 RVA: 0x0000250D File Offset: 0x0000070D
		public void AddFloat(string name, float value)
		{
			this.AddFloat(Shader.PropertyToID(name), value);
		}

		/// <summary>
		///   <para>Add a float material property.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000204 RID: 516
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void AddFloat(int nameID, float value);

		/// <summary>
		///   <para>Add a vector material property.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000205 RID: 517 RVA: 0x0000251C File Offset: 0x0000071C
		public void AddVector(string name, Vector4 value)
		{
			this.AddVector(Shader.PropertyToID(name), value);
		}

		/// <summary>
		///   <para>Add a vector material property.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000206 RID: 518 RVA: 0x0000252B File Offset: 0x0000072B
		public void AddVector(int nameID, Vector4 value)
		{
			MaterialPropertyBlock.INTERNAL_CALL_AddVector(this, nameID, ref value);
		}

		// Token: 0x06000207 RID: 519
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_AddVector(MaterialPropertyBlock self, int nameID, ref Vector4 value);

		/// <summary>
		///   <para>Add a color material property.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000208 RID: 520 RVA: 0x00002536 File Offset: 0x00000736
		public void AddColor(string name, Color value)
		{
			this.AddColor(Shader.PropertyToID(name), value);
		}

		/// <summary>
		///   <para>Add a color material property.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000209 RID: 521 RVA: 0x00002545 File Offset: 0x00000745
		public void AddColor(int nameID, Color value)
		{
			MaterialPropertyBlock.INTERNAL_CALL_AddColor(this, nameID, ref value);
		}

		// Token: 0x0600020A RID: 522
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_AddColor(MaterialPropertyBlock self, int nameID, ref Color value);

		/// <summary>
		///   <para>Add a matrix material property.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x0600020B RID: 523 RVA: 0x00002550 File Offset: 0x00000750
		public void AddMatrix(string name, Matrix4x4 value)
		{
			this.AddMatrix(Shader.PropertyToID(name), value);
		}

		/// <summary>
		///   <para>Add a matrix material property.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x0600020C RID: 524 RVA: 0x0000255F File Offset: 0x0000075F
		public void AddMatrix(int nameID, Matrix4x4 value)
		{
			MaterialPropertyBlock.INTERNAL_CALL_AddMatrix(this, nameID, ref value);
		}

		// Token: 0x0600020D RID: 525
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_AddMatrix(MaterialPropertyBlock self, int nameID, ref Matrix4x4 value);

		/// <summary>
		///   <para>Add a texture material property.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x0600020E RID: 526 RVA: 0x0000256A File Offset: 0x0000076A
		public void AddTexture(string name, Texture value)
		{
			this.AddTexture(Shader.PropertyToID(name), value);
		}

		/// <summary>
		///   <para>Add a texture material property.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x0600020F RID: 527
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void AddTexture(int nameID, Texture value);

		/// <summary>
		///   <para>Get a float from the property block.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000210 RID: 528 RVA: 0x00002579 File Offset: 0x00000779
		public float GetFloat(string name)
		{
			return this.GetFloat(Shader.PropertyToID(name));
		}

		/// <summary>
		///   <para>Get a float from the property block.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000211 RID: 529
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern float GetFloat(int nameID);

		/// <summary>
		///   <para>Get a vector from the property block.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000212 RID: 530 RVA: 0x00002587 File Offset: 0x00000787
		public Vector4 GetVector(string name)
		{
			return this.GetVector(Shader.PropertyToID(name));
		}

		/// <summary>
		///   <para>Get a vector from the property block.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000213 RID: 531
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Vector4 GetVector(int nameID);

		/// <summary>
		///   <para>Get a matrix from the property block.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000214 RID: 532 RVA: 0x00002595 File Offset: 0x00000795
		public Matrix4x4 GetMatrix(string name)
		{
			return this.GetMatrix(Shader.PropertyToID(name));
		}

		/// <summary>
		///   <para>Get a matrix from the property block.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000215 RID: 533
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Matrix4x4 GetMatrix(int nameID);

		/// <summary>
		///   <para>Get a texture from the property block.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000216 RID: 534 RVA: 0x000025A3 File Offset: 0x000007A3
		public Texture GetTexture(string name)
		{
			return this.GetTexture(Shader.PropertyToID(name));
		}

		/// <summary>
		///   <para>Get a texture from the property block.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000217 RID: 535
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Texture GetTexture(int nameID);

		/// <summary>
		///   <para>Clear material property values.</para>
		/// </summary>
		// Token: 0x06000218 RID: 536
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Clear();

		// Token: 0x04000085 RID: 133
		internal IntPtr m_Ptr;
	}
}
