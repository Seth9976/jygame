using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Physics material describes how to handle colliding objects (friction, bounciness).</para>
	/// </summary>
	// Token: 0x02000116 RID: 278
	public sealed class PhysicMaterial : Object
	{
		/// <summary>
		///   <para>Creates a new material.</para>
		/// </summary>
		// Token: 0x060010C9 RID: 4297 RVA: 0x000074B1 File Offset: 0x000056B1
		public PhysicMaterial()
		{
			PhysicMaterial.Internal_CreateDynamicsMaterial(this, null);
		}

		/// <summary>
		///   <para>Creates a new material named name.</para>
		/// </summary>
		/// <param name="name"></param>
		// Token: 0x060010CA RID: 4298 RVA: 0x000074C0 File Offset: 0x000056C0
		public PhysicMaterial(string name)
		{
			PhysicMaterial.Internal_CreateDynamicsMaterial(this, name);
		}

		// Token: 0x060010CB RID: 4299
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CreateDynamicsMaterial([Writable] PhysicMaterial mat, string name);

		/// <summary>
		///   <para>The friction used when already moving.  This value has to be between 0 and 1.</para>
		/// </summary>
		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060010CC RID: 4300
		// (set) Token: 0x060010CD RID: 4301
		public extern float dynamicFriction
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The friction coefficient used when an object is lying on a surface.</para>
		/// </summary>
		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x060010CE RID: 4302
		// (set) Token: 0x060010CF RID: 4303
		public extern float staticFriction
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>How bouncy is the surface? A value of 0 will not bounce. A value of 1 will bounce without any loss of energy.</para>
		/// </summary>
		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x060010D0 RID: 4304
		// (set) Token: 0x060010D1 RID: 4305
		public extern float bounciness
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060010D2 RID: 4306 RVA: 0x000074CF File Offset: 0x000056CF
		// (set) Token: 0x060010D3 RID: 4307 RVA: 0x000074D7 File Offset: 0x000056D7
		[Obsolete("Use PhysicMaterial.bounciness instead", true)]
		public float bouncyness
		{
			get
			{
				return this.bounciness;
			}
			set
			{
				this.bounciness = value;
			}
		}

		/// <summary>
		///   <para>The direction of anisotropy. Anisotropic friction is enabled if the vector is not zero.</para>
		/// </summary>
		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060010D4 RID: 4308 RVA: 0x00005F24 File Offset: 0x00004124
		// (set) Token: 0x060010D5 RID: 4309 RVA: 0x00002753 File Offset: 0x00000953
		[Obsolete("Anisotropic friction is no longer supported since Unity 5.0.", true)]
		public Vector3 frictionDirection2
		{
			get
			{
				return Vector3.zero;
			}
			set
			{
			}
		}

		/// <summary>
		///   <para>If anisotropic friction is enabled, dynamicFriction2 will be applied along frictionDirection2.</para>
		/// </summary>
		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x060010D6 RID: 4310
		// (set) Token: 0x060010D7 RID: 4311
		[Obsolete("Anisotropic friction is no longer supported since Unity 5.0.", true)]
		public extern float dynamicFriction2
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>If anisotropic friction is enabled, staticFriction2 will be applied along frictionDirection2.</para>
		/// </summary>
		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x060010D8 RID: 4312
		// (set) Token: 0x060010D9 RID: 4313
		[Obsolete("Anisotropic friction is no longer supported since Unity 5.0.", true)]
		public extern float staticFriction2
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Determines how the friction is combined.</para>
		/// </summary>
		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x060010DA RID: 4314
		// (set) Token: 0x060010DB RID: 4315
		public extern PhysicMaterialCombine frictionCombine
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Determines how the bounciness is combined.</para>
		/// </summary>
		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x060010DC RID: 4316
		// (set) Token: 0x060010DD RID: 4317
		public extern PhysicMaterialCombine bounceCombine
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x060010DE RID: 4318 RVA: 0x00005F24 File Offset: 0x00004124
		// (set) Token: 0x060010DF RID: 4319 RVA: 0x00002753 File Offset: 0x00000953
		[Obsolete("Anisotropic friction is no longer supported since Unity 5.0.", true)]
		public Vector3 frictionDirection
		{
			get
			{
				return Vector3.zero;
			}
			set
			{
			}
		}
	}
}
