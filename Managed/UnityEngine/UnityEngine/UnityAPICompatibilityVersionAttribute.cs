using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Declares an assembly to be compatible (API wise) with a specific Unity API. Used by internal tools to avoid processing the assembly in order to decide whether assemblies may be using old Unity API.</para>
	/// </summary>
	// Token: 0x020002E1 RID: 737
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public class UnityAPICompatibilityVersionAttribute : Attribute
	{
		/// <summary>
		///   <para>Initializes a new instance of UnityAPICompatibilityVersionAttribute.</para>
		/// </summary>
		/// <param name="version">Unity version that this assembly with compatible with.</param>
		// Token: 0x06002271 RID: 8817 RVA: 0x0000DDC5 File Offset: 0x0000BFC5
		public UnityAPICompatibilityVersionAttribute(string version)
		{
			this._version = version;
		}

		/// <summary>
		///   <para>Version of Unity API.</para>
		/// </summary>
		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06002272 RID: 8818 RVA: 0x0000DDD4 File Offset: 0x0000BFD4
		public string version
		{
			get
			{
				return this._version;
			}
		}

		// Token: 0x04000B6C RID: 2924
		private string _version;
	}
}
