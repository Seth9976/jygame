using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Networking
{
	// Token: 0x02000227 RID: 551
	internal sealed class GlobalConfigInternal : IDisposable
	{
		// Token: 0x06001F7A RID: 8058 RVA: 0x000264D8 File Offset: 0x000246D8
		public GlobalConfigInternal(GlobalConfig config)
		{
			this.InitWrapper();
			this.InitThreadAwakeTimeout(config.ThreadAwakeTimeout);
			this.InitReactorModel((byte)config.ReactorModel);
			this.InitReactorMaximumReceivedMessages(config.ReactorMaximumReceivedMessages);
			this.InitReactorMaximumSentMessages(config.ReactorMaximumSentMessages);
			this.InitMaxPacketSize(config.MaxPacketSize);
		}

		// Token: 0x06001F7B RID: 8059
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitWrapper();

		// Token: 0x06001F7C RID: 8060
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitThreadAwakeTimeout(uint ms);

		// Token: 0x06001F7D RID: 8061
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitReactorModel(byte model);

		// Token: 0x06001F7E RID: 8062
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitReactorMaximumReceivedMessages(ushort size);

		// Token: 0x06001F7F RID: 8063
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitReactorMaximumSentMessages(ushort size);

		// Token: 0x06001F80 RID: 8064
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitMaxPacketSize(ushort size);

		// Token: 0x06001F81 RID: 8065
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Dispose();

		// Token: 0x06001F82 RID: 8066 RVA: 0x00026530 File Offset: 0x00024730
		~GlobalConfigInternal()
		{
			this.Dispose();
		}

		// Token: 0x0400089A RID: 2202
		internal IntPtr m_Ptr;
	}
}
