using System;

namespace UnityEngine
{
	// Token: 0x02000083 RID: 131
	public interface ISerializationCallbackReceiver
	{
		/// <summary>
		///   <para>Implement this method to receive a callback after unity serialized your object.</para>
		/// </summary>
		// Token: 0x060007C7 RID: 1991
		void OnBeforeSerialize();

		/// <summary>
		///   <para>See ISerializationCallbackReceiver.OnBeforeSerialize for documentation on how to use this method.</para>
		/// </summary>
		// Token: 0x060007C8 RID: 1992
		void OnAfterDeserialize();
	}
}
