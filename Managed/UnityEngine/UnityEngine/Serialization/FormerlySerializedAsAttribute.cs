using System;

namespace UnityEngine.Serialization
{
	/// <summary>
	///   <para>Use this attribute to rename a field without losing its serialized value.</para>
	/// </summary>
	// Token: 0x02000300 RID: 768
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = false)]
	public class FormerlySerializedAsAttribute : Attribute
	{
		/// <summary>
		///   <para></para>
		/// </summary>
		/// <param name="oldName">The name of the field before renaming.</param>
		// Token: 0x06002357 RID: 9047 RVA: 0x0000EB0A File Offset: 0x0000CD0A
		public FormerlySerializedAsAttribute(string oldName)
		{
			this.m_oldName = oldName;
		}

		/// <summary>
		///   <para>The name of the field before the rename.</para>
		/// </summary>
		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06002358 RID: 9048 RVA: 0x0000EB19 File Offset: 0x0000CD19
		public string oldName
		{
			get
			{
				return this.m_oldName;
			}
		}

		// Token: 0x04000BB2 RID: 2994
		private string m_oldName;
	}
}
