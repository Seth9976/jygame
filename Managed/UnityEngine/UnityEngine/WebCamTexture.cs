using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>WebCam Textures are textures onto which the live video input is rendered.</para>
	/// </summary>
	// Token: 0x0200016C RID: 364
	public sealed class WebCamTexture : Texture
	{
		/// <summary>
		///   <para>Create a WebCamTexture.</para>
		/// </summary>
		/// <param name="deviceName">The name of the video input device to be used.</param>
		/// <param name="requestedWidth">The requested width of the texture.</param>
		/// <param name="requestedHeight">The requested height of the texture.</param>
		/// <param name="requestedFPS">The requested frame rate of the texture.</param>
		// Token: 0x06001531 RID: 5425 RVA: 0x00007DC6 File Offset: 0x00005FC6
		public WebCamTexture(string deviceName, int requestedWidth, int requestedHeight, int requestedFPS)
		{
			WebCamTexture.Internal_CreateWebCamTexture(this, deviceName, requestedWidth, requestedHeight, requestedFPS);
		}

		/// <summary>
		///   <para>Create a WebCamTexture.</para>
		/// </summary>
		/// <param name="deviceName">The name of the video input device to be used.</param>
		/// <param name="requestedWidth">The requested width of the texture.</param>
		/// <param name="requestedHeight">The requested height of the texture.</param>
		/// <param name="requestedFPS">The requested frame rate of the texture.</param>
		// Token: 0x06001532 RID: 5426 RVA: 0x00007DD9 File Offset: 0x00005FD9
		public WebCamTexture(string deviceName, int requestedWidth, int requestedHeight)
		{
			WebCamTexture.Internal_CreateWebCamTexture(this, deviceName, requestedWidth, requestedHeight, 0);
		}

		/// <summary>
		///   <para>Create a WebCamTexture.</para>
		/// </summary>
		/// <param name="deviceName">The name of the video input device to be used.</param>
		/// <param name="requestedWidth">The requested width of the texture.</param>
		/// <param name="requestedHeight">The requested height of the texture.</param>
		/// <param name="requestedFPS">The requested frame rate of the texture.</param>
		// Token: 0x06001533 RID: 5427 RVA: 0x00007DEB File Offset: 0x00005FEB
		public WebCamTexture(string deviceName)
		{
			WebCamTexture.Internal_CreateWebCamTexture(this, deviceName, 0, 0, 0);
		}

		/// <summary>
		///   <para>Create a WebCamTexture.</para>
		/// </summary>
		/// <param name="deviceName">The name of the video input device to be used.</param>
		/// <param name="requestedWidth">The requested width of the texture.</param>
		/// <param name="requestedHeight">The requested height of the texture.</param>
		/// <param name="requestedFPS">The requested frame rate of the texture.</param>
		// Token: 0x06001534 RID: 5428 RVA: 0x00007DFD File Offset: 0x00005FFD
		public WebCamTexture(int requestedWidth, int requestedHeight, int requestedFPS)
		{
			WebCamTexture.Internal_CreateWebCamTexture(this, string.Empty, requestedWidth, requestedHeight, requestedFPS);
		}

		/// <summary>
		///   <para>Create a WebCamTexture.</para>
		/// </summary>
		/// <param name="deviceName">The name of the video input device to be used.</param>
		/// <param name="requestedWidth">The requested width of the texture.</param>
		/// <param name="requestedHeight">The requested height of the texture.</param>
		/// <param name="requestedFPS">The requested frame rate of the texture.</param>
		// Token: 0x06001535 RID: 5429 RVA: 0x00007E13 File Offset: 0x00006013
		public WebCamTexture(int requestedWidth, int requestedHeight)
		{
			WebCamTexture.Internal_CreateWebCamTexture(this, string.Empty, requestedWidth, requestedHeight, 0);
		}

		/// <summary>
		///   <para>Create a WebCamTexture.</para>
		/// </summary>
		/// <param name="deviceName">The name of the video input device to be used.</param>
		/// <param name="requestedWidth">The requested width of the texture.</param>
		/// <param name="requestedHeight">The requested height of the texture.</param>
		/// <param name="requestedFPS">The requested frame rate of the texture.</param>
		// Token: 0x06001536 RID: 5430 RVA: 0x00007E29 File Offset: 0x00006029
		public WebCamTexture()
		{
			WebCamTexture.Internal_CreateWebCamTexture(this, string.Empty, 0, 0, 0);
		}

		// Token: 0x06001537 RID: 5431
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CreateWebCamTexture([Writable] WebCamTexture self, string scriptingDevice, int requestedWidth, int requestedHeight, int maxFramerate);

		/// <summary>
		///   <para>Starts the camera.</para>
		/// </summary>
		// Token: 0x06001538 RID: 5432 RVA: 0x00007E3F File Offset: 0x0000603F
		public void Play()
		{
			WebCamTexture.INTERNAL_CALL_Play(this);
		}

		// Token: 0x06001539 RID: 5433
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Play(WebCamTexture self);

		/// <summary>
		///   <para>Pauses the camera.</para>
		/// </summary>
		// Token: 0x0600153A RID: 5434 RVA: 0x00007E47 File Offset: 0x00006047
		public void Pause()
		{
			WebCamTexture.INTERNAL_CALL_Pause(this);
		}

		// Token: 0x0600153B RID: 5435
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Pause(WebCamTexture self);

		/// <summary>
		///   <para>Stops the camera.</para>
		/// </summary>
		// Token: 0x0600153C RID: 5436 RVA: 0x00007E4F File Offset: 0x0000604F
		public void Stop()
		{
			WebCamTexture.INTERNAL_CALL_Stop(this);
		}

		// Token: 0x0600153D RID: 5437
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Stop(WebCamTexture self);

		/// <summary>
		///   <para>Returns if the camera is currently playing.</para>
		/// </summary>
		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x0600153E RID: 5438
		public extern bool isPlaying
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Set this to specify the name of the device to use.</para>
		/// </summary>
		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x0600153F RID: 5439
		// (set) Token: 0x06001540 RID: 5440
		public extern string deviceName
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Set the requested frame rate of the camera device (in frames per second).</para>
		/// </summary>
		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001541 RID: 5441
		// (set) Token: 0x06001542 RID: 5442
		public extern float requestedFPS
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Set the requested width of the camera device.</para>
		/// </summary>
		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001543 RID: 5443
		// (set) Token: 0x06001544 RID: 5444
		public extern int requestedWidth
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Set the requested height of the camera device.</para>
		/// </summary>
		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001545 RID: 5445
		// (set) Token: 0x06001546 RID: 5446
		public extern int requestedHeight
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Return a list of available devices.</para>
		/// </summary>
		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001547 RID: 5447
		public static extern WebCamDevice[] devices
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns pixel color at coordinates (x, y).</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		// Token: 0x06001548 RID: 5448
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Color GetPixel(int x, int y);

		/// <summary>
		///   <para>Get a block of pixel colors.</para>
		/// </summary>
		// Token: 0x06001549 RID: 5449 RVA: 0x00007E57 File Offset: 0x00006057
		public Color[] GetPixels()
		{
			return this.GetPixels(0, 0, this.width, this.height);
		}

		/// <summary>
		///   <para>Get a block of pixel colors.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="blockWidth"></param>
		/// <param name="blockHeight"></param>
		// Token: 0x0600154A RID: 5450
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Color[] GetPixels(int x, int y, int blockWidth, int blockHeight);

		/// <summary>
		///   <para>Returns the pixels data in raw format.</para>
		/// </summary>
		/// <param name="colors">Optional array to receive pixel data.</param>
		// Token: 0x0600154B RID: 5451
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Color32[] GetPixels32([DefaultValue("null")] Color32[] colors);

		// Token: 0x0600154C RID: 5452 RVA: 0x0001A5EC File Offset: 0x000187EC
		[ExcludeFromDocs]
		public Color32[] GetPixels32()
		{
			Color32[] array = null;
			return this.GetPixels32(array);
		}

		/// <summary>
		///   <para>Returns an clockwise angle (in degrees), which can be used to rotate a polygon so camera contents are shown in correct orientation.</para>
		/// </summary>
		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x0600154D RID: 5453
		public extern int videoRotationAngle
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns if the texture image is vertically flipped.</para>
		/// </summary>
		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x0600154E RID: 5454
		public extern bool videoVerticallyMirrored
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Did the video buffer update this frame?</para>
		/// </summary>
		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x0600154F RID: 5455
		public extern bool didUpdateThisFrame
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}
	}
}
