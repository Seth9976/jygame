using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Interface into the Input system.</para>
	/// </summary>
	// Token: 0x020000C4 RID: 196
	public sealed class Input
	{
		// Token: 0x06000B0E RID: 2830
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int mainGyroIndex_Internal();

		// Token: 0x06000B0F RID: 2831
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetKeyInt(int key);

		// Token: 0x06000B10 RID: 2832
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetKeyString(string name);

		// Token: 0x06000B11 RID: 2833
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetKeyUpInt(int key);

		// Token: 0x06000B12 RID: 2834
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetKeyUpString(string name);

		// Token: 0x06000B13 RID: 2835
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetKeyDownInt(int key);

		// Token: 0x06000B14 RID: 2836
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetKeyDownString(string name);

		/// <summary>
		///   <para>Returns the value of the virtual axis identified by axisName.</para>
		/// </summary>
		/// <param name="axisName"></param>
		// Token: 0x06000B15 RID: 2837
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetAxis(string axisName);

		/// <summary>
		///   <para>Returns the value of the virtual axis identified by axisName with no smoothing filtering applied.</para>
		/// </summary>
		/// <param name="axisName"></param>
		// Token: 0x06000B16 RID: 2838
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetAxisRaw(string axisName);

		/// <summary>
		///   <para>Returns true while the virtual button identified by buttonName is held down.</para>
		/// </summary>
		/// <param name="buttonName"></param>
		// Token: 0x06000B17 RID: 2839
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetButton(string buttonName);

		/// <summary>
		///   <para>This property controls if input sensors should be compensated for screen orientation.</para>
		/// </summary>
		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000B18 RID: 2840
		// (set) Token: 0x06000B19 RID: 2841
		public static extern bool compensateSensors
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000B1A RID: 2842
		[Obsolete("isGyroAvailable property is deprecated. Please use SystemInfo.supportsGyroscope instead.")]
		public static extern bool isGyroAvailable
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns default gyroscope.</para>
		/// </summary>
		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x00005E97 File Offset: 0x00004097
		public static Gyroscope gyro
		{
			get
			{
				if (Input.m_MainGyro == null)
				{
					Input.m_MainGyro = new Gyroscope(Input.mainGyroIndex_Internal());
				}
				return Input.m_MainGyro;
			}
		}

		/// <summary>
		///   <para>Returns true during the frame the user pressed down the virtual button identified by buttonName.</para>
		/// </summary>
		/// <param name="buttonName"></param>
		// Token: 0x06000B1C RID: 2844
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetButtonDown(string buttonName);

		/// <summary>
		///   <para>Returns true the first frame the user releases the virtual button identified by buttonName.</para>
		/// </summary>
		/// <param name="buttonName"></param>
		// Token: 0x06000B1D RID: 2845
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetButtonUp(string buttonName);

		/// <summary>
		///   <para>Returns true while the user holds down the key identified by name. Think auto fire.</para>
		/// </summary>
		/// <param name="name"></param>
		// Token: 0x06000B1E RID: 2846 RVA: 0x00005EB7 File Offset: 0x000040B7
		public static bool GetKey(string name)
		{
			return Input.GetKeyString(name);
		}

		/// <summary>
		///   <para>Returns true while the user holds down the key identified by the key KeyCode enum parameter.</para>
		/// </summary>
		/// <param name="key"></param>
		// Token: 0x06000B1F RID: 2847 RVA: 0x00005EBF File Offset: 0x000040BF
		public static bool GetKey(KeyCode key)
		{
			return Input.GetKeyInt((int)key);
		}

		/// <summary>
		///   <para>Returns true during the frame the user starts pressing down the key identified by name.</para>
		/// </summary>
		/// <param name="name"></param>
		// Token: 0x06000B20 RID: 2848 RVA: 0x00005EC7 File Offset: 0x000040C7
		public static bool GetKeyDown(string name)
		{
			return Input.GetKeyDownString(name);
		}

		/// <summary>
		///   <para>Returns true during the frame the user starts pressing down the key identified by the key KeyCode enum parameter.</para>
		/// </summary>
		/// <param name="key"></param>
		// Token: 0x06000B21 RID: 2849 RVA: 0x00005ECF File Offset: 0x000040CF
		public static bool GetKeyDown(KeyCode key)
		{
			return Input.GetKeyDownInt((int)key);
		}

		/// <summary>
		///   <para>Returns true during the frame the user releases the key identified by name.</para>
		/// </summary>
		/// <param name="name"></param>
		// Token: 0x06000B22 RID: 2850 RVA: 0x00005ED7 File Offset: 0x000040D7
		public static bool GetKeyUp(string name)
		{
			return Input.GetKeyUpString(name);
		}

		/// <summary>
		///   <para>Returns true during the frame the user releases the key identified by the key KeyCode enum parameter.</para>
		/// </summary>
		/// <param name="key"></param>
		// Token: 0x06000B23 RID: 2851 RVA: 0x00005EDF File Offset: 0x000040DF
		public static bool GetKeyUp(KeyCode key)
		{
			return Input.GetKeyUpInt((int)key);
		}

		/// <summary>
		///   <para>Returns an array of strings describing the connected joysticks.</para>
		/// </summary>
		// Token: 0x06000B24 RID: 2852
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string[] GetJoystickNames();

		/// <summary>
		///   <para>Returns whether the given mouse button is held down.</para>
		/// </summary>
		/// <param name="button"></param>
		// Token: 0x06000B25 RID: 2853
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetMouseButton(int button);

		/// <summary>
		///   <para>Returns true during the frame the user pressed the given mouse button.</para>
		/// </summary>
		/// <param name="button"></param>
		// Token: 0x06000B26 RID: 2854
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetMouseButtonDown(int button);

		/// <summary>
		///   <para>Returns true during the frame the user releases the given mouse button.</para>
		/// </summary>
		/// <param name="button"></param>
		// Token: 0x06000B27 RID: 2855
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetMouseButtonUp(int button);

		/// <summary>
		///   <para>Resets all input. After ResetInputAxes all axes return to 0 and all buttons return to 0 for one frame.</para>
		/// </summary>
		// Token: 0x06000B28 RID: 2856
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ResetInputAxes();

		/// <summary>
		///   <para>The current mouse position in pixel coordinates. (Read Only)</para>
		/// </summary>
		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x00016F78 File Offset: 0x00015178
		public static Vector3 mousePosition
		{
			get
			{
				Vector3 vector;
				Input.INTERNAL_get_mousePosition(out vector);
				return vector;
			}
		}

		// Token: 0x06000B2A RID: 2858
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_mousePosition(out Vector3 value);

		/// <summary>
		///   <para>The current mouse scroll delta. (Read Only)</para>
		/// </summary>
		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x00016F90 File Offset: 0x00015190
		public static Vector2 mouseScrollDelta
		{
			get
			{
				Vector2 vector;
				Input.INTERNAL_get_mouseScrollDelta(out vector);
				return vector;
			}
		}

		// Token: 0x06000B2C RID: 2860
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_mouseScrollDelta(out Vector2 value);

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000B2D RID: 2861
		public static extern bool mousePresent
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Enables/Disables mouse simulation with touches. By default this option is enabled.</para>
		/// </summary>
		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000B2E RID: 2862
		// (set) Token: 0x06000B2F RID: 2863
		public static extern bool simulateMouseWithTouches
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Is any key or mouse button currently held down? (Read Only)</para>
		/// </summary>
		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000B30 RID: 2864
		public static extern bool anyKey
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns true the first frame the user hits any key or mouse button. (Read Only)</para>
		/// </summary>
		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000B31 RID: 2865
		public static extern bool anyKeyDown
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns the keyboard input entered this frame. (Read Only)</para>
		/// </summary>
		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000B32 RID: 2866
		public static extern string inputString
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Last measured linear acceleration of a device in three-dimensional space. (Read Only)</para>
		/// </summary>
		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x00016FA8 File Offset: 0x000151A8
		public static Vector3 acceleration
		{
			get
			{
				Vector3 vector;
				Input.INTERNAL_get_acceleration(out vector);
				return vector;
			}
		}

		// Token: 0x06000B34 RID: 2868
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_acceleration(out Vector3 value);

		/// <summary>
		///   <para>Returns list of acceleration measurements which occurred during the last frame. (Read Only) (Allocates temporary variables).</para>
		/// </summary>
		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x00016FC0 File Offset: 0x000151C0
		public static AccelerationEvent[] accelerationEvents
		{
			get
			{
				int accelerationEventCount = Input.accelerationEventCount;
				AccelerationEvent[] array = new AccelerationEvent[accelerationEventCount];
				for (int i = 0; i < accelerationEventCount; i++)
				{
					array[i] = Input.GetAccelerationEvent(i);
				}
				return array;
			}
		}

		/// <summary>
		///   <para>Returns specific acceleration measurement which occurred during last frame. (Does not allocate temporary variables).</para>
		/// </summary>
		/// <param name="index"></param>
		// Token: 0x06000B36 RID: 2870
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern AccelerationEvent GetAccelerationEvent(int index);

		/// <summary>
		///   <para>Number of acceleration measurements which occurred during last frame.</para>
		/// </summary>
		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000B37 RID: 2871
		public static extern int accelerationEventCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns list of objects representing status of all touches during last frame. (Read Only) (Allocates temporary variables).</para>
		/// </summary>
		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x00017000 File Offset: 0x00015200
		public static Touch[] touches
		{
			get
			{
				int touchCount = Input.touchCount;
				Touch[] array = new Touch[touchCount];
				for (int i = 0; i < touchCount; i++)
				{
					array[i] = Input.GetTouch(i);
				}
				return array;
			}
		}

		/// <summary>
		///   <para>Returns object representing status of a specific touch. (Does not allocate temporary variables).</para>
		/// </summary>
		/// <param name="index"></param>
		// Token: 0x06000B39 RID: 2873
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Touch GetTouch(int index);

		/// <summary>
		///   <para>Number of touches. Guaranteed not to change throughout the frame. (Read Only)</para>
		/// </summary>
		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000B3A RID: 2874
		public static extern int touchCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Property indicating whether keypresses are eaten by a textinput if it has focus (default true).</para>
		/// </summary>
		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000B3B RID: 2875
		// (set) Token: 0x06000B3C RID: 2876
		[Obsolete("eatKeyPressOnTextFieldFocus property is deprecated, and only provided to support legacy behavior.")]
		public static extern bool eatKeyPressOnTextFieldFocus
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Bool value which let's users check if touch pressure is supported.</para>
		/// </summary>
		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000B3D RID: 2877
		public static extern bool touchPressureSupported
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns true when Stylus Touch is supported by a device or platform.</para>
		/// </summary>
		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000B3E RID: 2878
		public static extern bool stylusTouchSupported
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns whether the device on which application is currently running supports touch input.</para>
		/// </summary>
		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x00002C36 File Offset: 0x00000E36
		public static bool touchSupported
		{
			get
			{
				return false;
			}
		}

		/// <summary>
		///   <para>Property indicating whether the system handles multiple touches.</para>
		/// </summary>
		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000B40 RID: 2880
		// (set) Token: 0x06000B41 RID: 2881
		public static extern bool multiTouchEnabled
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Property for accessing device location (handheld devices only). (Read Only)</para>
		/// </summary>
		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x00005EE7 File Offset: 0x000040E7
		public static LocationService location
		{
			get
			{
				if (Input.locationServiceInstance == null)
				{
					Input.locationServiceInstance = new LocationService();
				}
				return Input.locationServiceInstance;
			}
		}

		/// <summary>
		///   <para>Property for accessing compass (handheld devices only). (Read Only)</para>
		/// </summary>
		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x00005F02 File Offset: 0x00004102
		public static Compass compass
		{
			get
			{
				if (Input.compassInstance == null)
				{
					Input.compassInstance = new Compass();
				}
				return Input.compassInstance;
			}
		}

		/// <summary>
		///   <para>Device physical orientation as reported by OS. (Read Only)</para>
		/// </summary>
		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000B44 RID: 2884
		public static extern DeviceOrientation deviceOrientation
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x00005F1D File Offset: 0x0000411D
		[Obsolete("Use ps3 move API instead", true)]
		public static Quaternion GetRotation(int deviceID)
		{
			return Quaternion.identity;
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00005F24 File Offset: 0x00004124
		[Obsolete("Use ps3 move API instead", true)]
		public static Vector3 GetPosition(int deviceID)
		{
			return Vector3.zero;
		}

		/// <summary>
		///   <para>Controls enabling and disabling of IME input composition.</para>
		/// </summary>
		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000B47 RID: 2887
		// (set) Token: 0x06000B48 RID: 2888
		public static extern IMECompositionMode imeCompositionMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The current IME composition string being typed by the user.</para>
		/// </summary>
		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000B49 RID: 2889
		public static extern string compositionString
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Does the user have an IME keyboard input source selected?</para>
		/// </summary>
		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000B4A RID: 2890
		public static extern bool imeIsSelected
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The current text input position used by IMEs to open windows.</para>
		/// </summary>
		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x00017040 File Offset: 0x00015240
		// (set) Token: 0x06000B4C RID: 2892 RVA: 0x00005F2B File Offset: 0x0000412B
		public static Vector2 compositionCursorPos
		{
			get
			{
				Vector2 vector;
				Input.INTERNAL_get_compositionCursorPos(out vector);
				return vector;
			}
			set
			{
				Input.INTERNAL_set_compositionCursorPos(ref value);
			}
		}

		// Token: 0x06000B4D RID: 2893
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_compositionCursorPos(out Vector2 value);

		// Token: 0x06000B4E RID: 2894
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_compositionCursorPos(ref Vector2 value);

		// Token: 0x0400024D RID: 589
		private static Gyroscope m_MainGyro;

		// Token: 0x0400024E RID: 590
		private static LocationService locationServiceInstance;

		// Token: 0x0400024F RID: 591
		private static Compass compassInstance;
	}
}
