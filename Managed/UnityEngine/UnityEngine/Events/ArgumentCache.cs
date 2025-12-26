using System;
using System.Text.RegularExpressions;
using UnityEngine.Serialization;

namespace UnityEngine.Events
{
	// Token: 0x020002E4 RID: 740
	[Serializable]
	internal class ArgumentCache : ISerializationCallbackReceiver
	{
		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06002274 RID: 8820 RVA: 0x0000DDDC File Offset: 0x0000BFDC
		// (set) Token: 0x06002275 RID: 8821 RVA: 0x0000DDE4 File Offset: 0x0000BFE4
		public Object unityObjectArgument
		{
			get
			{
				return this.m_ObjectArgument;
			}
			set
			{
				this.m_ObjectArgument = value;
				this.m_ObjectArgumentAssemblyTypeName = ((!(value != null)) ? string.Empty : value.GetType().AssemblyQualifiedName);
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06002276 RID: 8822 RVA: 0x0000DE14 File Offset: 0x0000C014
		public string unityObjectArgumentAssemblyTypeName
		{
			get
			{
				return this.m_ObjectArgumentAssemblyTypeName;
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06002277 RID: 8823 RVA: 0x0000DE1C File Offset: 0x0000C01C
		// (set) Token: 0x06002278 RID: 8824 RVA: 0x0000DE24 File Offset: 0x0000C024
		public int intArgument
		{
			get
			{
				return this.m_IntArgument;
			}
			set
			{
				this.m_IntArgument = value;
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06002279 RID: 8825 RVA: 0x0000DE2D File Offset: 0x0000C02D
		// (set) Token: 0x0600227A RID: 8826 RVA: 0x0000DE35 File Offset: 0x0000C035
		public float floatArgument
		{
			get
			{
				return this.m_FloatArgument;
			}
			set
			{
				this.m_FloatArgument = value;
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x0600227B RID: 8827 RVA: 0x0000DE3E File Offset: 0x0000C03E
		// (set) Token: 0x0600227C RID: 8828 RVA: 0x0000DE46 File Offset: 0x0000C046
		public string stringArgument
		{
			get
			{
				return this.m_StringArgument;
			}
			set
			{
				this.m_StringArgument = value;
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x0600227D RID: 8829 RVA: 0x0000DE4F File Offset: 0x0000C04F
		// (set) Token: 0x0600227E RID: 8830 RVA: 0x0000DE57 File Offset: 0x0000C057
		public bool boolArgument
		{
			get
			{
				return this.m_BoolArgument;
			}
			set
			{
				this.m_BoolArgument = value;
			}
		}

		// Token: 0x0600227F RID: 8831 RVA: 0x0002D140 File Offset: 0x0002B340
		private void TidyAssemblyTypeName()
		{
			if (string.IsNullOrEmpty(this.m_ObjectArgumentAssemblyTypeName))
			{
				return;
			}
			this.m_ObjectArgumentAssemblyTypeName = Regex.Replace(this.m_ObjectArgumentAssemblyTypeName, ", Version=\\d+.\\d+.\\d+.\\d+", string.Empty);
			this.m_ObjectArgumentAssemblyTypeName = Regex.Replace(this.m_ObjectArgumentAssemblyTypeName, ", Culture=\\w+", string.Empty);
			this.m_ObjectArgumentAssemblyTypeName = Regex.Replace(this.m_ObjectArgumentAssemblyTypeName, ", PublicKeyToken=\\w+", string.Empty);
		}

		// Token: 0x06002280 RID: 8832 RVA: 0x0000DE60 File Offset: 0x0000C060
		public void OnBeforeSerialize()
		{
			this.TidyAssemblyTypeName();
		}

		// Token: 0x06002281 RID: 8833 RVA: 0x0000DE60 File Offset: 0x0000C060
		public void OnAfterDeserialize()
		{
			this.TidyAssemblyTypeName();
		}

		// Token: 0x04000B79 RID: 2937
		private const string kVersionString = ", Version=\\d+.\\d+.\\d+.\\d+";

		// Token: 0x04000B7A RID: 2938
		private const string kCultureString = ", Culture=\\w+";

		// Token: 0x04000B7B RID: 2939
		private const string kTokenString = ", PublicKeyToken=\\w+";

		// Token: 0x04000B7C RID: 2940
		[SerializeField]
		[FormerlySerializedAs("objectArgument")]
		private Object m_ObjectArgument;

		// Token: 0x04000B7D RID: 2941
		[FormerlySerializedAs("objectArgumentAssemblyTypeName")]
		[SerializeField]
		private string m_ObjectArgumentAssemblyTypeName;

		// Token: 0x04000B7E RID: 2942
		[SerializeField]
		[FormerlySerializedAs("intArgument")]
		private int m_IntArgument;

		// Token: 0x04000B7F RID: 2943
		[SerializeField]
		[FormerlySerializedAs("floatArgument")]
		private float m_FloatArgument;

		// Token: 0x04000B80 RID: 2944
		[SerializeField]
		[FormerlySerializedAs("stringArgument")]
		private string m_StringArgument;

		// Token: 0x04000B81 RID: 2945
		[SerializeField]
		private bool m_BoolArgument;
	}
}
