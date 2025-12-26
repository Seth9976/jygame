using System;

namespace UnityEngine.Networking
{
	/// <summary>
	///   <para>Descibed allowed types of quality of service for channels.</para>
	/// </summary>
	// Token: 0x0200021D RID: 541
	public enum QosType
	{
		/// <summary>
		///   <para>Just sending message, no grants.</para>
		/// </summary>
		// Token: 0x0400085F RID: 2143
		Unreliable,
		/// <summary>
		///   <para>The same as unreliable, but big message (up to 32 fragment per message) can be sent.</para>
		/// </summary>
		// Token: 0x04000860 RID: 2144
		UnreliableFragmented,
		/// <summary>
		///   <para>The same as unrelaible but all unorder messages will be dropped. Example: VoIP.</para>
		/// </summary>
		// Token: 0x04000861 RID: 2145
		UnreliableSequenced,
		/// <summary>
		///   <para>Channel will be configured as relaiable, each message sent in this channel will be delivered or connection will be disconnected.</para>
		/// </summary>
		// Token: 0x04000862 RID: 2146
		Reliable,
		/// <summary>
		///   <para>Same as reliable, but big messages are allowed (up to 32 fragment with fragmentsize each for message).</para>
		/// </summary>
		// Token: 0x04000863 RID: 2147
		ReliableFragmented,
		/// <summary>
		///   <para>The same as reliable, but with granting message order.</para>
		/// </summary>
		// Token: 0x04000864 RID: 2148
		ReliableSequenced,
		/// <summary>
		///   <para>Unreliable, only last message in send buffer will be sent, only most recent message in reading buffer will be delivered.</para>
		/// </summary>
		// Token: 0x04000865 RID: 2149
		StateUpdate,
		/// <summary>
		///   <para>The same as StateUpdate, but reliable.</para>
		/// </summary>
		// Token: 0x04000866 RID: 2150
		ReliableStateUpdate,
		/// <summary>
		///   <para>Reliable message will resend almost with each frame, without waiting  delivery notification. usefull for important urgent short messages, like a shoot.</para>
		/// </summary>
		// Token: 0x04000867 RID: 2151
		AllCostDelivery
	}
}
