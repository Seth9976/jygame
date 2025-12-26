using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Use this PropertyAttribute to add some spacing in the Inspector.</para>
	/// </summary>
	// Token: 0x020002C6 RID: 710
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
	public class SpaceAttribute : PropertyAttribute
	{
		// Token: 0x060021B5 RID: 8629 RVA: 0x0000D820 File Offset: 0x0000BA20
		public SpaceAttribute()
		{
			this.height = 8f;
		}

		/// <summary>
		///   <para>Use this DecoratorDrawer to add some spacing in the Inspector.</para>
		/// </summary>
		/// <param name="height">The spacing in pixels.</param>
		// Token: 0x060021B6 RID: 8630 RVA: 0x0000D833 File Offset: 0x0000BA33
		public SpaceAttribute(float height)
		{
			this.height = height;
		}

		/// <summary>
		///   <para>The spacing in pixels.</para>
		/// </summary>
		// Token: 0x04000ADE RID: 2782
		public readonly float height;
	}
}
