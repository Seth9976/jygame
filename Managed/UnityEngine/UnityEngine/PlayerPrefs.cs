using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Stores and accesses player preferences between game sessions.</para>
	/// </summary>
	// Token: 0x020000D0 RID: 208
	public sealed class PlayerPrefs
	{
		// Token: 0x06000CA9 RID: 3241
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool TrySetInt(string key, int value);

		// Token: 0x06000CAA RID: 3242
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool TrySetFloat(string key, float value);

		// Token: 0x06000CAB RID: 3243
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool TrySetSetString(string key, string value);

		/// <summary>
		///   <para>Sets the value of the preference identified by key.</para>
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		// Token: 0x06000CAC RID: 3244 RVA: 0x0000662A File Offset: 0x0000482A
		public static void SetInt(string key, int value)
		{
			if (!PlayerPrefs.TrySetInt(key, value))
			{
				throw new PlayerPrefsException("Could not store preference value");
			}
		}

		/// <summary>
		///   <para>Returns the value corresponding to key in the preference file if it exists.</para>
		/// </summary>
		/// <param name="key"></param>
		/// <param name="defaultValue"></param>
		// Token: 0x06000CAD RID: 3245
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetInt(string key, [DefaultValue("0")] int defaultValue);

		/// <summary>
		///   <para>Returns the value corresponding to key in the preference file if it exists.</para>
		/// </summary>
		/// <param name="key"></param>
		/// <param name="defaultValue"></param>
		// Token: 0x06000CAE RID: 3246 RVA: 0x000177D8 File Offset: 0x000159D8
		[ExcludeFromDocs]
		public static int GetInt(string key)
		{
			int num = 0;
			return PlayerPrefs.GetInt(key, num);
		}

		/// <summary>
		///   <para>Sets the value of the preference identified by key.</para>
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		// Token: 0x06000CAF RID: 3247 RVA: 0x00006643 File Offset: 0x00004843
		public static void SetFloat(string key, float value)
		{
			if (!PlayerPrefs.TrySetFloat(key, value))
			{
				throw new PlayerPrefsException("Could not store preference value");
			}
		}

		/// <summary>
		///   <para>Returns the value corresponding to key in the preference file if it exists.</para>
		/// </summary>
		/// <param name="key"></param>
		/// <param name="defaultValue"></param>
		// Token: 0x06000CB0 RID: 3248
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetFloat(string key, [DefaultValue("0.0F")] float defaultValue);

		/// <summary>
		///   <para>Returns the value corresponding to key in the preference file if it exists.</para>
		/// </summary>
		/// <param name="key"></param>
		/// <param name="defaultValue"></param>
		// Token: 0x06000CB1 RID: 3249 RVA: 0x000177F0 File Offset: 0x000159F0
		[ExcludeFromDocs]
		public static float GetFloat(string key)
		{
			float num = 0f;
			return PlayerPrefs.GetFloat(key, num);
		}

		/// <summary>
		///   <para>Sets the value of the preference identified by key.</para>
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		// Token: 0x06000CB2 RID: 3250 RVA: 0x0000665C File Offset: 0x0000485C
		public static void SetString(string key, string value)
		{
			if (!PlayerPrefs.TrySetSetString(key, value))
			{
				throw new PlayerPrefsException("Could not store preference value");
			}
		}

		/// <summary>
		///   <para>Returns the value corresponding to key in the preference file if it exists.</para>
		/// </summary>
		/// <param name="key"></param>
		/// <param name="defaultValue"></param>
		// Token: 0x06000CB3 RID: 3251
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string GetString(string key, [DefaultValue("\"\"")] string defaultValue);

		/// <summary>
		///   <para>Returns the value corresponding to key in the preference file if it exists.</para>
		/// </summary>
		/// <param name="key"></param>
		/// <param name="defaultValue"></param>
		// Token: 0x06000CB4 RID: 3252 RVA: 0x0001780C File Offset: 0x00015A0C
		[ExcludeFromDocs]
		public static string GetString(string key)
		{
			string empty = string.Empty;
			return PlayerPrefs.GetString(key, empty);
		}

		/// <summary>
		///   <para>Returns true if key exists in the preferences.</para>
		/// </summary>
		/// <param name="key"></param>
		// Token: 0x06000CB5 RID: 3253
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasKey(string key);

		/// <summary>
		///   <para>Removes key and its corresponding value from the preferences.</para>
		/// </summary>
		/// <param name="key"></param>
		// Token: 0x06000CB6 RID: 3254
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DeleteKey(string key);

		/// <summary>
		///   <para>Removes all keys and values from the preferences. Use with caution.</para>
		/// </summary>
		// Token: 0x06000CB7 RID: 3255
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DeleteAll();

		/// <summary>
		///   <para>Writes all modified preferences to disk.</para>
		/// </summary>
		// Token: 0x06000CB8 RID: 3256
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Save();
	}
}
