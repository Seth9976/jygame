using System;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Data of a lightmap.</para>
	/// </summary>
	// Token: 0x0200002F RID: 47
	[StructLayout(LayoutKind.Sequential)]
	public sealed class LightmapData
	{
		/// <summary>
		///   <para>Lightmap storing the full incoming light.</para>
		/// </summary>
		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600026E RID: 622 RVA: 0x00002726 File Offset: 0x00000926
		// (set) Token: 0x0600026F RID: 623 RVA: 0x0000272E File Offset: 0x0000092E
		public Texture2D lightmapFar
		{
			get
			{
				return this.m_Light;
			}
			set
			{
				this.m_Light = value;
			}
		}

		/// <summary>
		///   <para>Lightmap storing only the indirect incoming light.</para>
		/// </summary>
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000270 RID: 624 RVA: 0x00002737 File Offset: 0x00000937
		// (set) Token: 0x06000271 RID: 625 RVA: 0x0000273F File Offset: 0x0000093F
		public Texture2D lightmapNear
		{
			get
			{
				return this.m_Dir;
			}
			set
			{
				this.m_Dir = value;
			}
		}

		// Token: 0x0400009C RID: 156
		internal Texture2D m_Light;

		// Token: 0x0400009D RID: 157
		internal Texture2D m_Dir;
	}
}
