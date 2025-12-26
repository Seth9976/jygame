using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>LayerMask allow you to display the LayerMask popup menu in the inspector.</para>
	/// </summary>
	// Token: 0x02000054 RID: 84
	public struct LayerMask
	{
		/// <summary>
		///   <para>Converts a layer mask value to an integer value.</para>
		/// </summary>
		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x00002D1F File Offset: 0x00000F1F
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x00002D27 File Offset: 0x00000F27
		public int value
		{
			get
			{
				return this.m_Mask;
			}
			set
			{
				this.m_Mask = value;
			}
		}

		/// <summary>
		///   <para>Given a layer number, returns the name of the layer as defined in either a Builtin or a User Layer in the.</para>
		/// </summary>
		/// <param name="layer"></param>
		// Token: 0x06000475 RID: 1141
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string LayerToName(int layer);

		/// <summary>
		///   <para>Given a layer name, returns the layer index as defined by either a Builtin or a User Layer in the.</para>
		/// </summary>
		/// <param name="layerName"></param>
		// Token: 0x06000476 RID: 1142
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int NameToLayer(string layerName);

		/// <summary>
		///   <para>Given a set of layer names as defined by either a Builtin or a User Layer in the, returns the equivalent layer mask for all of them.</para>
		/// </summary>
		/// <param name="layerNames">List of layer names to convert to a layer mask.</param>
		/// <returns>
		///   <para>The layer mask created from the layerNames.</para>
		/// </returns>
		// Token: 0x06000477 RID: 1143 RVA: 0x00010490 File Offset: 0x0000E690
		public static int GetMask(params string[] layerNames)
		{
			int num = 0;
			foreach (string text in layerNames)
			{
				int num2 = LayerMask.NameToLayer(text);
				if (num2 != 0)
				{
					num |= 1 << num2;
				}
			}
			return num;
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00002D30 File Offset: 0x00000F30
		public static implicit operator int(LayerMask mask)
		{
			return mask.m_Mask;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x000104D8 File Offset: 0x0000E6D8
		public static implicit operator LayerMask(int intVal)
		{
			LayerMask layerMask;
			layerMask.m_Mask = intVal;
			return layerMask;
		}

		// Token: 0x040000CB RID: 203
		private int m_Mask;
	}
}
