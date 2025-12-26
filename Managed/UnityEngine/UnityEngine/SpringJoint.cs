using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>The spring joint ties together 2 rigid bodies, spring forces will be automatically applied to keep the object at the given distance.</para>
	/// </summary>
	// Token: 0x02000107 RID: 263
	public sealed class SpringJoint : Joint
	{
		/// <summary>
		///   <para>The spring force used to keep the two objects together.</para>
		/// </summary>
		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000FB5 RID: 4021
		// (set) Token: 0x06000FB6 RID: 4022
		public extern float spring
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The damper force used to dampen the spring force.</para>
		/// </summary>
		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000FB7 RID: 4023
		// (set) Token: 0x06000FB8 RID: 4024
		public extern float damper
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The minimum distance between the bodies relative to their initial distance.</para>
		/// </summary>
		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000FB9 RID: 4025
		// (set) Token: 0x06000FBA RID: 4026
		public extern float minDistance
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The maximum distance between the bodies relative to their initial distance.</para>
		/// </summary>
		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000FBB RID: 4027
		// (set) Token: 0x06000FBC RID: 4028
		public extern float maxDistance
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The maximum allowed error between the current spring length and the length defined by minDistance and maxDistance.</para>
		/// </summary>
		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000FBD RID: 4029
		// (set) Token: 0x06000FBE RID: 4030
		public extern float tolerance
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
