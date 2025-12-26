using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>A class you can derive from if you want to create objects that don't need to be attached to game objects.</para>
	/// </summary>
	// Token: 0x02000012 RID: 18
	[StructLayout(LayoutKind.Sequential)]
	public class ScriptableObject : Object
	{
		// Token: 0x06000060 RID: 96 RVA: 0x000021FB File Offset: 0x000003FB
		public ScriptableObject()
		{
			ScriptableObject.Internal_CreateScriptableObject(this);
		}

		// Token: 0x06000061 RID: 97
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CreateScriptableObject([Writable] ScriptableObject self);

		// Token: 0x06000062 RID: 98 RVA: 0x00002209 File Offset: 0x00000409
		[Obsolete("Use EditorUtility.SetDirty instead")]
		public void SetDirty()
		{
			ScriptableObject.INTERNAL_CALL_SetDirty(this);
		}

		// Token: 0x06000063 RID: 99
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetDirty(ScriptableObject self);

		/// <summary>
		///   <para>Creates an instance of a scriptable object with className.</para>
		/// </summary>
		/// <param name="className"></param>
		// Token: 0x06000064 RID: 100
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern ScriptableObject CreateInstance(string className);

		/// <summary>
		///   <para>Creates an instance of a scriptable object with type.</para>
		/// </summary>
		/// <param name="type"></param>
		// Token: 0x06000065 RID: 101 RVA: 0x00002211 File Offset: 0x00000411
		public static ScriptableObject CreateInstance(Type type)
		{
			return ScriptableObject.CreateInstanceFromType(type);
		}

		// Token: 0x06000066 RID: 102
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ScriptableObject CreateInstanceFromType(Type type);

		// Token: 0x06000067 RID: 103 RVA: 0x00002219 File Offset: 0x00000419
		public static T CreateInstance<T>() where T : ScriptableObject
		{
			return (T)((object)ScriptableObject.CreateInstance(typeof(T)));
		}
	}
}
