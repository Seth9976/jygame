using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine.Cloud.Service
{
	// Token: 0x02000242 RID: 578
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class CloudService : IDisposable
	{
		// Token: 0x06002046 RID: 8262 RVA: 0x0000CBDE File Offset: 0x0000ADDE
		public CloudService(CloudServiceType serviceType)
		{
			this.InternalCreate(serviceType);
		}

		// Token: 0x06002047 RID: 8263
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void InternalCreate(CloudServiceType serviceType);

		// Token: 0x06002048 RID: 8264
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void InternalDestroy();

		// Token: 0x06002049 RID: 8265 RVA: 0x00028284 File Offset: 0x00026484
		~CloudService()
		{
			this.InternalDestroy();
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x0000CBED File Offset: 0x0000ADED
		public void Dispose()
		{
			this.InternalDestroy();
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600204B RID: 8267
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool Initialize(string projectId);

		// Token: 0x0600204C RID: 8268
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool StartEventHandler(string sessionInfo, int maxNumberOfEventInQueue, int maxEventTimeoutInSec);

		// Token: 0x0600204D RID: 8269
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool PauseEventHandler(bool flushEvents);

		// Token: 0x0600204E RID: 8270
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool StopEventHandler();

		// Token: 0x0600204F RID: 8271 RVA: 0x0000CBFB File Offset: 0x0000ADFB
		public bool StartEventDispatcher(CloudServiceConfig serviceConfig, Dictionary<string, string> headers)
		{
			return this.InternalStartEventDispatcher(serviceConfig, CloudService.FlattenedHeadersFrom(headers));
		}

		// Token: 0x06002050 RID: 8272
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool InternalStartEventDispatcher(CloudServiceConfig serviceConfig, string[] headers);

		// Token: 0x06002051 RID: 8273
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool PauseEventDispatcher();

		// Token: 0x06002052 RID: 8274
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool StopEventDispatcher();

		// Token: 0x06002053 RID: 8275
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void ResetNetworkRetryIndex();

		// Token: 0x06002054 RID: 8276
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool QueueEvent(string eventData, CloudEventFlags flags);

		// Token: 0x06002055 RID: 8277 RVA: 0x0000CC0A File Offset: 0x0000AE0A
		public bool SaveFileFromServer(string fileName, string url, Dictionary<string, string> headers, object d, string methodName)
		{
			if (methodName == null)
			{
				methodName = string.Empty;
			}
			return this.InternalSaveFileFromServer(fileName, url, CloudService.FlattenedHeadersFrom(headers), d, methodName);
		}

		// Token: 0x06002056 RID: 8278
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool InternalSaveFileFromServer(string fileName, string url, string[] headers, object d, string methodName);

		// Token: 0x06002057 RID: 8279
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool SaveFile(string fileName, string data);

		// Token: 0x06002058 RID: 8280
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern string RestoreFile(string fileName);

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06002059 RID: 8281
		public extern string serviceFolderName
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x00015930 File Offset: 0x00013B30
		private static string[] FlattenedHeadersFrom(Dictionary<string, string> headers)
		{
			if (headers == null)
			{
				return null;
			}
			string[] array = new string[headers.Count * 2];
			int num = 0;
			foreach (KeyValuePair<string, string> keyValuePair in headers)
			{
				array[num++] = keyValuePair.Key.ToString();
				array[num++] = keyValuePair.Value.ToString();
			}
			return array;
		}

		// Token: 0x040008D0 RID: 2256
		[NonSerialized]
		internal IntPtr m_Ptr;
	}
}
