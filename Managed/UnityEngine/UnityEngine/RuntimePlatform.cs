using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>The platform application is running. Returned by Application.platform.</para>
	/// </summary>
	// Token: 0x02000009 RID: 9
	public enum RuntimePlatform
	{
		/// <summary>
		///   <para>In the Unity editor on Mac OS X.</para>
		/// </summary>
		// Token: 0x04000012 RID: 18
		OSXEditor,
		/// <summary>
		///   <para>In the player on Mac OS X.</para>
		/// </summary>
		// Token: 0x04000013 RID: 19
		OSXPlayer,
		/// <summary>
		///   <para>In the player on Windows.</para>
		/// </summary>
		// Token: 0x04000014 RID: 20
		WindowsPlayer,
		/// <summary>
		///   <para>In the web player on Mac OS X.</para>
		/// </summary>
		// Token: 0x04000015 RID: 21
		OSXWebPlayer,
		/// <summary>
		///   <para>In the Dashboard widget on Mac OS X.</para>
		/// </summary>
		// Token: 0x04000016 RID: 22
		OSXDashboardPlayer,
		/// <summary>
		///   <para>In the web player on Windows.</para>
		/// </summary>
		// Token: 0x04000017 RID: 23
		WindowsWebPlayer,
		/// <summary>
		///   <para>In the Unity editor on Windows.</para>
		/// </summary>
		// Token: 0x04000018 RID: 24
		WindowsEditor = 7,
		/// <summary>
		///   <para>In the player on the iPhone.</para>
		/// </summary>
		// Token: 0x04000019 RID: 25
		IPhonePlayer,
		/// <summary>
		///   <para>In the player on the XBOX360.</para>
		/// </summary>
		// Token: 0x0400001A RID: 26
		XBOX360 = 10,
		/// <summary>
		///   <para>In the player on the Play Station 3.</para>
		/// </summary>
		// Token: 0x0400001B RID: 27
		PS3 = 9,
		/// <summary>
		///   <para>In the player on Android devices.</para>
		/// </summary>
		// Token: 0x0400001C RID: 28
		Android = 11,
		// Token: 0x0400001D RID: 29
		[Obsolete("NaCl export is no longer supported in Unity 5.0+.")]
		NaCl,
		// Token: 0x0400001E RID: 30
		[Obsolete("FlashPlayer export is no longer supported in Unity 5.0+.")]
		FlashPlayer = 15,
		/// <summary>
		///   <para>In the player on Linux.</para>
		/// </summary>
		// Token: 0x0400001F RID: 31
		LinuxPlayer = 13,
		/// <summary>
		///   <para>In the player on WebGL?</para>
		/// </summary>
		// Token: 0x04000020 RID: 32
		WebGLPlayer = 17,
		// Token: 0x04000021 RID: 33
		[Obsolete("Use WSAPlayerX86 instead")]
		MetroPlayerX86,
		/// <summary>
		///   <para>In the player on Windows Store Apps when CPU architecture is X86.</para>
		/// </summary>
		// Token: 0x04000022 RID: 34
		WSAPlayerX86 = 18,
		// Token: 0x04000023 RID: 35
		[Obsolete("Use WSAPlayerX64 instead")]
		MetroPlayerX64,
		/// <summary>
		///   <para>In the player on Windows Store Apps when CPU architecture is X64.</para>
		/// </summary>
		// Token: 0x04000024 RID: 36
		WSAPlayerX64 = 19,
		// Token: 0x04000025 RID: 37
		[Obsolete("Use WSAPlayerARM instead")]
		MetroPlayerARM,
		/// <summary>
		///   <para>In the player on Windows Store Apps when CPU architecture is ARM.</para>
		/// </summary>
		// Token: 0x04000026 RID: 38
		WSAPlayerARM = 20,
		/// <summary>
		///   <para>In the player on Windows Phone 8 device.
		/// </para>
		/// </summary>
		// Token: 0x04000027 RID: 39
		WP8Player,
		// Token: 0x04000028 RID: 40
		BlackBerryPlayer,
		/// <summary>
		///   <para>In the player on Tizen.</para>
		/// </summary>
		// Token: 0x04000029 RID: 41
		TizenPlayer,
		/// <summary>
		///   <para>In the player on the PS Vita.</para>
		/// </summary>
		// Token: 0x0400002A RID: 42
		PSP2,
		/// <summary>
		///   <para>In the player on the Playstation 4.</para>
		/// </summary>
		// Token: 0x0400002B RID: 43
		PS4,
		// Token: 0x0400002C RID: 44
		PSM,
		/// <summary>
		///   <para>In the player on Xbox One.</para>
		/// </summary>
		// Token: 0x0400002D RID: 45
		XboxOne,
		/// <summary>
		///   <para>In the player on Samsung Smart TV.</para>
		/// </summary>
		// Token: 0x0400002E RID: 46
		SamsungTVPlayer,
		/// <summary>
		///   <para>In the player on Wii U.</para>
		/// </summary>
		// Token: 0x0400002F RID: 47
		WiiU = 30
	}
}
