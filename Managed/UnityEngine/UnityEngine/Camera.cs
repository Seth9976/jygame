using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Rendering;

namespace UnityEngine
{
	/// <summary>
	///   <para>A Camera is a device through which the player views the world.</para>
	/// </summary>
	// Token: 0x020000AE RID: 174
	public sealed class Camera : Behaviour
	{
		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x00005933 File Offset: 0x00003B33
		// (set) Token: 0x060009BE RID: 2494 RVA: 0x0000593B File Offset: 0x00003B3B
		[Obsolete("use Camera.fieldOfView instead.")]
		public float fov
		{
			get
			{
				return this.fieldOfView;
			}
			set
			{
				this.fieldOfView = value;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x00005944 File Offset: 0x00003B44
		// (set) Token: 0x060009C0 RID: 2496 RVA: 0x0000594C File Offset: 0x00003B4C
		[Obsolete("use Camera.nearClipPlane instead.")]
		public float near
		{
			get
			{
				return this.nearClipPlane;
			}
			set
			{
				this.nearClipPlane = value;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x00005955 File Offset: 0x00003B55
		// (set) Token: 0x060009C2 RID: 2498 RVA: 0x0000595D File Offset: 0x00003B5D
		[Obsolete("use Camera.farClipPlane instead.")]
		public float far
		{
			get
			{
				return this.farClipPlane;
			}
			set
			{
				this.farClipPlane = value;
			}
		}

		/// <summary>
		///   <para>The field of view of the camera in degrees.</para>
		/// </summary>
		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060009C3 RID: 2499
		// (set) Token: 0x060009C4 RID: 2500
		public extern float fieldOfView
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The near clipping plane distance.</para>
		/// </summary>
		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060009C5 RID: 2501
		// (set) Token: 0x060009C6 RID: 2502
		public extern float nearClipPlane
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The far clipping plane distance.</para>
		/// </summary>
		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060009C7 RID: 2503
		// (set) Token: 0x060009C8 RID: 2504
		public extern float farClipPlane
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Rendering path.</para>
		/// </summary>
		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060009C9 RID: 2505
		// (set) Token: 0x060009CA RID: 2506
		public extern RenderingPath renderingPath
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Actually used rendering path (Read Only).</para>
		/// </summary>
		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060009CB RID: 2507
		public extern RenderingPath actualRenderingPath
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>High dynamic range rendering.</para>
		/// </summary>
		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060009CC RID: 2508
		// (set) Token: 0x060009CD RID: 2509
		public extern bool hdr
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x060009CE RID: 2510
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern string[] GetHDRWarnings();

		/// <summary>
		///   <para>Camera's half-size when in orthographic mode.</para>
		/// </summary>
		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060009CF RID: 2511
		// (set) Token: 0x060009D0 RID: 2512
		public extern float orthographicSize
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Is the camera orthographic (true) or perspective (false)?</para>
		/// </summary>
		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060009D1 RID: 2513
		// (set) Token: 0x060009D2 RID: 2514
		public extern bool orthographic
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Opaque object sorting mode.</para>
		/// </summary>
		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060009D3 RID: 2515
		// (set) Token: 0x060009D4 RID: 2516
		public extern OpaqueSortMode opaqueSortMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Transparent object sorting mode.</para>
		/// </summary>
		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060009D5 RID: 2517
		// (set) Token: 0x060009D6 RID: 2518
		public extern TransparencySortMode transparencySortMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Camera's depth in the camera rendering order.</para>
		/// </summary>
		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060009D7 RID: 2519
		// (set) Token: 0x060009D8 RID: 2520
		public extern float depth
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The aspect ratio (width divided by height).</para>
		/// </summary>
		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060009D9 RID: 2521
		// (set) Token: 0x060009DA RID: 2522
		public extern float aspect
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>This is used to render parts of the scene selectively.</para>
		/// </summary>
		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060009DB RID: 2523
		// (set) Token: 0x060009DC RID: 2524
		public extern int cullingMask
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060009DD RID: 2525
		internal static extern int PreviewCullingLayer
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Mask to select which layers can trigger events on the camera.</para>
		/// </summary>
		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060009DE RID: 2526
		// (set) Token: 0x060009DF RID: 2527
		public extern int eventMask
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The color with which the screen will be cleared.</para>
		/// </summary>
		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x00016BB0 File Offset: 0x00014DB0
		// (set) Token: 0x060009E1 RID: 2529 RVA: 0x00005966 File Offset: 0x00003B66
		public Color backgroundColor
		{
			get
			{
				Color color;
				this.INTERNAL_get_backgroundColor(out color);
				return color;
			}
			set
			{
				this.INTERNAL_set_backgroundColor(ref value);
			}
		}

		// Token: 0x060009E2 RID: 2530
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_backgroundColor(out Color value);

		// Token: 0x060009E3 RID: 2531
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_backgroundColor(ref Color value);

		/// <summary>
		///   <para>Where on the screen is the camera rendered in normalized coordinates.</para>
		/// </summary>
		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x00016BC8 File Offset: 0x00014DC8
		// (set) Token: 0x060009E5 RID: 2533 RVA: 0x00005970 File Offset: 0x00003B70
		public Rect rect
		{
			get
			{
				Rect rect;
				this.INTERNAL_get_rect(out rect);
				return rect;
			}
			set
			{
				this.INTERNAL_set_rect(ref value);
			}
		}

		// Token: 0x060009E6 RID: 2534
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_rect(out Rect value);

		// Token: 0x060009E7 RID: 2535
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_rect(ref Rect value);

		/// <summary>
		///   <para>Where on the screen is the camera rendered in pixel coordinates.</para>
		/// </summary>
		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x00016BE0 File Offset: 0x00014DE0
		// (set) Token: 0x060009E9 RID: 2537 RVA: 0x0000597A File Offset: 0x00003B7A
		public Rect pixelRect
		{
			get
			{
				Rect rect;
				this.INTERNAL_get_pixelRect(out rect);
				return rect;
			}
			set
			{
				this.INTERNAL_set_pixelRect(ref value);
			}
		}

		// Token: 0x060009EA RID: 2538
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_pixelRect(out Rect value);

		// Token: 0x060009EB RID: 2539
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_pixelRect(ref Rect value);

		/// <summary>
		///   <para>Destination render texture.</para>
		/// </summary>
		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060009EC RID: 2540
		// (set) Token: 0x060009ED RID: 2541
		public extern RenderTexture targetTexture
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x060009EE RID: 2542
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetTargetBuffersImpl(out RenderBuffer color, out RenderBuffer depth);

		// Token: 0x060009EF RID: 2543
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetTargetBuffersMRTImpl(RenderBuffer[] color, out RenderBuffer depth);

		/// <summary>
		///   <para>Sets the Camera to render to the chosen buffers of one or more RenderTextures.</para>
		/// </summary>
		/// <param name="colorBuffer">The RenderBuffer(s) to which color information will be rendered.</param>
		/// <param name="depthBuffer">The RenderBuffer to which depth information will be rendered.</param>
		// Token: 0x060009F0 RID: 2544 RVA: 0x00005984 File Offset: 0x00003B84
		public void SetTargetBuffers(RenderBuffer colorBuffer, RenderBuffer depthBuffer)
		{
			this.SetTargetBuffersImpl(out colorBuffer, out depthBuffer);
		}

		/// <summary>
		///   <para>Sets the Camera to render to the chosen buffers of one or more RenderTextures.</para>
		/// </summary>
		/// <param name="colorBuffer">The RenderBuffer(s) to which color information will be rendered.</param>
		/// <param name="depthBuffer">The RenderBuffer to which depth information will be rendered.</param>
		// Token: 0x060009F1 RID: 2545 RVA: 0x00005990 File Offset: 0x00003B90
		public void SetTargetBuffers(RenderBuffer[] colorBuffer, RenderBuffer depthBuffer)
		{
			this.SetTargetBuffersMRTImpl(colorBuffer, out depthBuffer);
		}

		/// <summary>
		///   <para>How wide is the camera in pixels (Read Only).</para>
		/// </summary>
		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060009F2 RID: 2546
		public extern int pixelWidth
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>How tall is the camera in pixels (Read Only).</para>
		/// </summary>
		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060009F3 RID: 2547
		public extern int pixelHeight
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Matrix that transforms from camera space to world space (Read Only).</para>
		/// </summary>
		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x00016BF8 File Offset: 0x00014DF8
		public Matrix4x4 cameraToWorldMatrix
		{
			get
			{
				Matrix4x4 matrix4x;
				this.INTERNAL_get_cameraToWorldMatrix(out matrix4x);
				return matrix4x;
			}
		}

		// Token: 0x060009F5 RID: 2549
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_cameraToWorldMatrix(out Matrix4x4 value);

		/// <summary>
		///   <para>Matrix that transforms from world to camera space.</para>
		/// </summary>
		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x00016C10 File Offset: 0x00014E10
		// (set) Token: 0x060009F7 RID: 2551 RVA: 0x0000599B File Offset: 0x00003B9B
		public Matrix4x4 worldToCameraMatrix
		{
			get
			{
				Matrix4x4 matrix4x;
				this.INTERNAL_get_worldToCameraMatrix(out matrix4x);
				return matrix4x;
			}
			set
			{
				this.INTERNAL_set_worldToCameraMatrix(ref value);
			}
		}

		// Token: 0x060009F8 RID: 2552
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_worldToCameraMatrix(out Matrix4x4 value);

		// Token: 0x060009F9 RID: 2553
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_worldToCameraMatrix(ref Matrix4x4 value);

		/// <summary>
		///   <para>Make the rendering position reflect the camera's position in the scene.</para>
		/// </summary>
		// Token: 0x060009FA RID: 2554 RVA: 0x000059A5 File Offset: 0x00003BA5
		public void ResetWorldToCameraMatrix()
		{
			Camera.INTERNAL_CALL_ResetWorldToCameraMatrix(this);
		}

		// Token: 0x060009FB RID: 2555
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ResetWorldToCameraMatrix(Camera self);

		/// <summary>
		///   <para>Set a custom projection matrix.</para>
		/// </summary>
		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x00016C28 File Offset: 0x00014E28
		// (set) Token: 0x060009FD RID: 2557 RVA: 0x000059AD File Offset: 0x00003BAD
		public Matrix4x4 projectionMatrix
		{
			get
			{
				Matrix4x4 matrix4x;
				this.INTERNAL_get_projectionMatrix(out matrix4x);
				return matrix4x;
			}
			set
			{
				this.INTERNAL_set_projectionMatrix(ref value);
			}
		}

		// Token: 0x060009FE RID: 2558
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_projectionMatrix(out Matrix4x4 value);

		// Token: 0x060009FF RID: 2559
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_projectionMatrix(ref Matrix4x4 value);

		/// <summary>
		///   <para>Make the projection reflect normal camera's parameters.</para>
		/// </summary>
		// Token: 0x06000A00 RID: 2560 RVA: 0x000059B7 File Offset: 0x00003BB7
		public void ResetProjectionMatrix()
		{
			Camera.INTERNAL_CALL_ResetProjectionMatrix(this);
		}

		// Token: 0x06000A01 RID: 2561
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ResetProjectionMatrix(Camera self);

		/// <summary>
		///   <para>Revert the aspect ratio to the screen's aspect ratio.</para>
		/// </summary>
		// Token: 0x06000A02 RID: 2562 RVA: 0x000059BF File Offset: 0x00003BBF
		public void ResetAspect()
		{
			Camera.INTERNAL_CALL_ResetAspect(this);
		}

		// Token: 0x06000A03 RID: 2563
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ResetAspect(Camera self);

		/// <summary>
		///   <para>Get the world-space speed of the camera (Read Only).</para>
		/// </summary>
		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x00016C40 File Offset: 0x00014E40
		public Vector3 velocity
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_velocity(out vector);
				return vector;
			}
		}

		// Token: 0x06000A05 RID: 2565
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_velocity(out Vector3 value);

		/// <summary>
		///   <para>How the camera clears the background.</para>
		/// </summary>
		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000A06 RID: 2566
		// (set) Token: 0x06000A07 RID: 2567
		public extern CameraClearFlags clearFlags
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Stereoscopic rendering.</para>
		/// </summary>
		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000A08 RID: 2568
		public extern bool stereoEnabled
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Distance between the virtual eyes.</para>
		/// </summary>
		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000A09 RID: 2569
		// (set) Token: 0x06000A0A RID: 2570
		public extern float stereoSeparation
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Distance to a point where virtual eyes converge.</para>
		/// </summary>
		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000A0B RID: 2571
		// (set) Token: 0x06000A0C RID: 2572
		public extern float stereoConvergence
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Identifies what kind of camera this is.</para>
		/// </summary>
		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000A0D RID: 2573
		// (set) Token: 0x06000A0E RID: 2574
		public extern CameraType cameraType
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Render only once and use resulting image for both eyes.</para>
		/// </summary>
		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000A0F RID: 2575
		// (set) Token: 0x06000A10 RID: 2576
		public extern bool stereoMirrorMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Set the target display for this Camera.</para>
		/// </summary>
		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000A11 RID: 2577
		// (set) Token: 0x06000A12 RID: 2578
		public extern int targetDisplay
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Transforms position from world space into screen space.</para>
		/// </summary>
		/// <param name="position"></param>
		// Token: 0x06000A13 RID: 2579 RVA: 0x000059C7 File Offset: 0x00003BC7
		public Vector3 WorldToScreenPoint(Vector3 position)
		{
			return Camera.INTERNAL_CALL_WorldToScreenPoint(this, ref position);
		}

		// Token: 0x06000A14 RID: 2580
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Vector3 INTERNAL_CALL_WorldToScreenPoint(Camera self, ref Vector3 position);

		/// <summary>
		///   <para>Transforms position from world space into viewport space.</para>
		/// </summary>
		/// <param name="position"></param>
		// Token: 0x06000A15 RID: 2581 RVA: 0x000059D1 File Offset: 0x00003BD1
		public Vector3 WorldToViewportPoint(Vector3 position)
		{
			return Camera.INTERNAL_CALL_WorldToViewportPoint(this, ref position);
		}

		// Token: 0x06000A16 RID: 2582
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Vector3 INTERNAL_CALL_WorldToViewportPoint(Camera self, ref Vector3 position);

		/// <summary>
		///   <para>Transforms position from viewport space into world space.</para>
		/// </summary>
		/// <param name="position"></param>
		// Token: 0x06000A17 RID: 2583 RVA: 0x000059DB File Offset: 0x00003BDB
		public Vector3 ViewportToWorldPoint(Vector3 position)
		{
			return Camera.INTERNAL_CALL_ViewportToWorldPoint(this, ref position);
		}

		// Token: 0x06000A18 RID: 2584
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Vector3 INTERNAL_CALL_ViewportToWorldPoint(Camera self, ref Vector3 position);

		/// <summary>
		///   <para>Transforms position from screen space into world space.</para>
		/// </summary>
		/// <param name="position"></param>
		// Token: 0x06000A19 RID: 2585 RVA: 0x000059E5 File Offset: 0x00003BE5
		public Vector3 ScreenToWorldPoint(Vector3 position)
		{
			return Camera.INTERNAL_CALL_ScreenToWorldPoint(this, ref position);
		}

		// Token: 0x06000A1A RID: 2586
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Vector3 INTERNAL_CALL_ScreenToWorldPoint(Camera self, ref Vector3 position);

		/// <summary>
		///   <para>Transforms position from screen space into viewport space.</para>
		/// </summary>
		/// <param name="position"></param>
		// Token: 0x06000A1B RID: 2587 RVA: 0x000059EF File Offset: 0x00003BEF
		public Vector3 ScreenToViewportPoint(Vector3 position)
		{
			return Camera.INTERNAL_CALL_ScreenToViewportPoint(this, ref position);
		}

		// Token: 0x06000A1C RID: 2588
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Vector3 INTERNAL_CALL_ScreenToViewportPoint(Camera self, ref Vector3 position);

		/// <summary>
		///   <para>Transforms position from viewport space into screen space.</para>
		/// </summary>
		/// <param name="position"></param>
		// Token: 0x06000A1D RID: 2589 RVA: 0x000059F9 File Offset: 0x00003BF9
		public Vector3 ViewportToScreenPoint(Vector3 position)
		{
			return Camera.INTERNAL_CALL_ViewportToScreenPoint(this, ref position);
		}

		// Token: 0x06000A1E RID: 2590
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Vector3 INTERNAL_CALL_ViewportToScreenPoint(Camera self, ref Vector3 position);

		/// <summary>
		///   <para>Returns a ray going from camera through a viewport point.</para>
		/// </summary>
		/// <param name="position"></param>
		// Token: 0x06000A1F RID: 2591 RVA: 0x00005A03 File Offset: 0x00003C03
		public Ray ViewportPointToRay(Vector3 position)
		{
			return Camera.INTERNAL_CALL_ViewportPointToRay(this, ref position);
		}

		// Token: 0x06000A20 RID: 2592
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Ray INTERNAL_CALL_ViewportPointToRay(Camera self, ref Vector3 position);

		/// <summary>
		///   <para>Returns a ray going from camera through a screen point.</para>
		/// </summary>
		/// <param name="position"></param>
		// Token: 0x06000A21 RID: 2593 RVA: 0x00005A0D File Offset: 0x00003C0D
		public Ray ScreenPointToRay(Vector3 position)
		{
			return Camera.INTERNAL_CALL_ScreenPointToRay(this, ref position);
		}

		// Token: 0x06000A22 RID: 2594
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Ray INTERNAL_CALL_ScreenPointToRay(Camera self, ref Vector3 position);

		/// <summary>
		///   <para>The first enabled camera tagged "MainCamera" (Read Only).</para>
		/// </summary>
		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000A23 RID: 2595
		public static extern Camera main
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The camera we are currently rendering with, for low-level render control only (Read Only).</para>
		/// </summary>
		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000A24 RID: 2596
		public static extern Camera current
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns all enabled cameras in the scene.</para>
		/// </summary>
		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000A25 RID: 2597
		public static extern Camera[] allCameras
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The number of cameras in the current scene.</para>
		/// </summary>
		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000A26 RID: 2598
		public static extern int allCamerasCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Fills an array of Camera with the current cameras in the scene, without allocating a new array.</para>
		/// </summary>
		/// <param name="cameras">An array to be filled up with cameras currently in the scene.</param>
		// Token: 0x06000A27 RID: 2599
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetAllCameras(Camera[] cameras);

		// Token: 0x06000A28 RID: 2600 RVA: 0x00005A17 File Offset: 0x00003C17
		private static void FireOnPreCull(Camera cam)
		{
			if (Camera.onPreCull != null)
			{
				Camera.onPreCull(cam);
			}
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x00005A2E File Offset: 0x00003C2E
		private static void FireOnPreRender(Camera cam)
		{
			if (Camera.onPreRender != null)
			{
				Camera.onPreRender(cam);
			}
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x00005A45 File Offset: 0x00003C45
		private static void FireOnPostRender(Camera cam)
		{
			if (Camera.onPostRender != null)
			{
				Camera.onPostRender(cam);
			}
		}

		/// <summary>
		///   <para>Render the camera manually.</para>
		/// </summary>
		// Token: 0x06000A2B RID: 2603
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Render();

		/// <summary>
		///   <para>Render the camera with shader replacement.</para>
		/// </summary>
		/// <param name="shader"></param>
		/// <param name="replacementTag"></param>
		// Token: 0x06000A2C RID: 2604
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RenderWithShader(Shader shader, string replacementTag);

		/// <summary>
		///   <para>Make the camera render with shader replacement.</para>
		/// </summary>
		/// <param name="shader"></param>
		/// <param name="replacementTag"></param>
		// Token: 0x06000A2D RID: 2605
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetReplacementShader(Shader shader, string replacementTag);

		/// <summary>
		///   <para>Remove shader replacement from camera.</para>
		/// </summary>
		// Token: 0x06000A2E RID: 2606 RVA: 0x00005A5C File Offset: 0x00003C5C
		public void ResetReplacementShader()
		{
			Camera.INTERNAL_CALL_ResetReplacementShader(this);
		}

		// Token: 0x06000A2F RID: 2607
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ResetReplacementShader(Camera self);

		/// <summary>
		///   <para>Whether or not the Camera will use occlusion culling during rendering.</para>
		/// </summary>
		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000A30 RID: 2608
		// (set) Token: 0x06000A31 RID: 2609
		public extern bool useOcclusionCulling
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06000A32 RID: 2610
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RenderDontRestore();

		// Token: 0x06000A33 RID: 2611
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetupCurrent(Camera cur);

		// Token: 0x06000A34 RID: 2612 RVA: 0x00016C58 File Offset: 0x00014E58
		[ExcludeFromDocs]
		public bool RenderToCubemap(Cubemap cubemap)
		{
			int num = 63;
			return this.RenderToCubemap(cubemap, num);
		}

		/// <summary>
		///   <para>Render into a static cubemap from this camera.</para>
		/// </summary>
		/// <param name="cubemap">The cube map to render to.</param>
		/// <param name="faceMask">A bitmask which determines which of the six faces are rendered to.</param>
		/// <returns>
		///   <para>False is rendering fails, else true.</para>
		/// </returns>
		// Token: 0x06000A35 RID: 2613 RVA: 0x00005A64 File Offset: 0x00003C64
		public bool RenderToCubemap(Cubemap cubemap, [DefaultValue("63")] int faceMask)
		{
			return this.Internal_RenderToCubemapTexture(cubemap, faceMask);
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00016C70 File Offset: 0x00014E70
		[ExcludeFromDocs]
		public bool RenderToCubemap(RenderTexture cubemap)
		{
			int num = 63;
			return this.RenderToCubemap(cubemap, num);
		}

		/// <summary>
		///   <para>Render into a cubemap from this camera.</para>
		/// </summary>
		/// <param name="faceMask">A bitfield indicating which cubemap faces should be rendered into.</param>
		/// <param name="cubemap">The texture to render to.</param>
		/// <returns>
		///   <para>False is rendering fails, else true.</para>
		/// </returns>
		// Token: 0x06000A37 RID: 2615 RVA: 0x00005A6E File Offset: 0x00003C6E
		public bool RenderToCubemap(RenderTexture cubemap, [DefaultValue("63")] int faceMask)
		{
			return this.Internal_RenderToCubemapRT(cubemap, faceMask);
		}

		// Token: 0x06000A38 RID: 2616
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool Internal_RenderToCubemapRT(RenderTexture cubemap, int faceMask);

		// Token: 0x06000A39 RID: 2617
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool Internal_RenderToCubemapTexture(Cubemap cubemap, int faceMask);

		/// <summary>
		///   <para>Per-layer culling distances.</para>
		/// </summary>
		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000A3A RID: 2618
		// (set) Token: 0x06000A3B RID: 2619
		public extern float[] layerCullDistances
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>How to perform per-layer culling for a Camera.</para>
		/// </summary>
		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000A3C RID: 2620
		// (set) Token: 0x06000A3D RID: 2621
		public extern bool layerCullSpherical
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Makes this camera's settings match other camera.</para>
		/// </summary>
		/// <param name="other"></param>
		// Token: 0x06000A3E RID: 2622
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void CopyFrom(Camera other);

		/// <summary>
		///   <para>How and if camera generates a depth texture.</para>
		/// </summary>
		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000A3F RID: 2623
		// (set) Token: 0x06000A40 RID: 2624
		public extern DepthTextureMode depthTextureMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Should the camera clear the stencil buffer after the deferred light pass?</para>
		/// </summary>
		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000A41 RID: 2625
		// (set) Token: 0x06000A42 RID: 2626
		public extern bool clearStencilAfterLightingPass
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06000A43 RID: 2627
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern bool IsFiltered(GameObject go);

		/// <summary>
		///   <para>Add a command buffer to be executed at a specified place.</para>
		/// </summary>
		/// <param name="evt">When to execute the command buffer during rendering.</param>
		/// <param name="buffer">The buffer to execute.</param>
		// Token: 0x06000A44 RID: 2628
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer);

		/// <summary>
		///   <para>Remove command buffer from execution at a specified place.</para>
		/// </summary>
		/// <param name="evt">When to execute the command buffer during rendering.</param>
		/// <param name="buffer">The buffer to execute.</param>
		// Token: 0x06000A45 RID: 2629
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer);

		/// <summary>
		///   <para>Remove command buffers from execution at a specified place.</para>
		/// </summary>
		/// <param name="evt">When to execute the command buffer during rendering.</param>
		// Token: 0x06000A46 RID: 2630
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RemoveCommandBuffers(CameraEvent evt);

		/// <summary>
		///   <para>Remove all command buffers set on this camera.</para>
		/// </summary>
		// Token: 0x06000A47 RID: 2631
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RemoveAllCommandBuffers();

		/// <summary>
		///   <para>Get command buffers to be executed at a specified place.</para>
		/// </summary>
		/// <param name="evt">When to execute the command buffer during rendering.</param>
		/// <returns>
		///   <para>Array of command buffers.</para>
		/// </returns>
		// Token: 0x06000A48 RID: 2632
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern CommandBuffer[] GetCommandBuffers(CameraEvent evt);

		/// <summary>
		///   <para>Number of command buffers set up on this camera (Read Only).</para>
		/// </summary>
		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000A49 RID: 2633
		public extern int commandBufferCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00005A78 File Offset: 0x00003C78
		internal GameObject RaycastTry(Ray ray, float distance, int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Camera.INTERNAL_CALL_RaycastTry(this, ref ray, distance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00016C88 File Offset: 0x00014E88
		[ExcludeFromDocs]
		internal GameObject RaycastTry(Ray ray, float distance, int layerMask)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Camera.INTERNAL_CALL_RaycastTry(this, ref ray, distance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000A4C RID: 2636
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern GameObject INTERNAL_CALL_RaycastTry(Camera self, ref Ray ray, float distance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x06000A4D RID: 2637 RVA: 0x00005A86 File Offset: 0x00003C86
		internal GameObject RaycastTry2D(Ray ray, float distance, int layerMask)
		{
			return Camera.INTERNAL_CALL_RaycastTry2D(this, ref ray, distance, layerMask);
		}

		// Token: 0x06000A4E RID: 2638
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern GameObject INTERNAL_CALL_RaycastTry2D(Camera self, ref Ray ray, float distance, int layerMask);

		/// <summary>
		///   <para>Calculates and returns oblique near-plane projection matrix.</para>
		/// </summary>
		/// <param name="clipPlane">Vector4 that describes a clip plane.</param>
		/// <returns>
		///   <para>Oblique near-plane projection matrix.</para>
		/// </returns>
		// Token: 0x06000A4F RID: 2639 RVA: 0x00005A92 File Offset: 0x00003C92
		public Matrix4x4 CalculateObliqueMatrix(Vector4 clipPlane)
		{
			return Camera.INTERNAL_CALL_CalculateObliqueMatrix(this, ref clipPlane);
		}

		// Token: 0x06000A50 RID: 2640
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Matrix4x4 INTERNAL_CALL_CalculateObliqueMatrix(Camera self, ref Vector4 clipPlane);

		// Token: 0x06000A51 RID: 2641 RVA: 0x00002753 File Offset: 0x00000953
		internal void OnlyUsedForTesting1()
		{
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00002753 File Offset: 0x00000953
		internal void OnlyUsedForTesting2()
		{
		}

		/// <summary>
		///   <para>Event that is fired before any camera starts culling.</para>
		/// </summary>
		// Token: 0x04000213 RID: 531
		public static Camera.CameraCallback onPreCull;

		/// <summary>
		///   <para>Event that is fired before any camera starts rendering.</para>
		/// </summary>
		// Token: 0x04000214 RID: 532
		public static Camera.CameraCallback onPreRender;

		/// <summary>
		///   <para>Event that is fired after any camera finishes rendering.</para>
		/// </summary>
		// Token: 0x04000215 RID: 533
		public static Camera.CameraCallback onPostRender;

		/// <summary>
		///   <para>Delegate type for camera callbacks.</para>
		/// </summary>
		/// <param name="cam"></param>
		// Token: 0x020000AF RID: 175
		// (Invoke) Token: 0x06000A54 RID: 2644
		public delegate void CameraCallback(Camera cam);
	}
}
