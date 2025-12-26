using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Controls the from script.</para>
	/// </summary>
	// Token: 0x02000014 RID: 20
	public sealed class Profiler
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000069 RID: 105
		public static extern bool supported
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Sets profiler output file in built players.</para>
		/// </summary>
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600006A RID: 106
		// (set) Token: 0x0600006B RID: 107
		public static extern string logFile
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Sets profiler output file in built players.</para>
		/// </summary>
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600006C RID: 108
		// (set) Token: 0x0600006D RID: 109
		public static extern bool enableBinaryLog
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Enables the Profiler.</para>
		/// </summary>
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600006E RID: 110
		// (set) Token: 0x0600006F RID: 111
		public static extern bool enabled
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Displays the recorded profiledata in the profiler.</para>
		/// </summary>
		/// <param name="file"></param>
		// Token: 0x06000070 RID: 112
		[WrapperlessIcall]
		[Conditional("ENABLE_PROFILER")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void AddFramesFromFile(string file);

		/// <summary>
		///   <para>Begin profiling a piece of code with a custom label.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="targetObject"></param>
		// Token: 0x06000071 RID: 113 RVA: 0x0000222F File Offset: 0x0000042F
		[Conditional("ENABLE_PROFILER")]
		public static void BeginSample(string name)
		{
			Profiler.BeginSampleOnly(name);
		}

		/// <summary>
		///   <para>Begin profiling a piece of code with a custom label.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="targetObject"></param>
		// Token: 0x06000072 RID: 114
		[WrapperlessIcall]
		[Conditional("ENABLE_PROFILER")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BeginSample(string name, Object targetObject);

		// Token: 0x06000073 RID: 115
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void BeginSampleOnly(string name);

		/// <summary>
		///   <para>End profiling a piece of code with a custom label.</para>
		/// </summary>
		// Token: 0x06000074 RID: 116
		[WrapperlessIcall]
		[Conditional("ENABLE_PROFILER")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EndSample();

		/// <summary>
		///   <para>Resize the profiler sample buffers to allow the desired amount of samples per thread.</para>
		/// </summary>
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000075 RID: 117
		// (set) Token: 0x06000076 RID: 118
		public static extern int maxNumberOfSamplesPerFrame
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Heap size used by the program.</para>
		/// </summary>
		/// <returns>
		///   <para>Size of the used heap in bytes, (or 0 if the profiler is disabled).</para>
		/// </returns>
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000077 RID: 119
		public static extern uint usedHeapSize
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns the runtime memory usage of the resource.</para>
		/// </summary>
		/// <param name="o"></param>
		// Token: 0x06000078 RID: 120
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetRuntimeMemorySize(Object o);

		/// <summary>
		///   <para>Returns the size of the mono heap.</para>
		/// </summary>
		// Token: 0x06000079 RID: 121
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern uint GetMonoHeapSize();

		/// <summary>
		///   <para>Returns the used size from mono.</para>
		/// </summary>
		// Token: 0x0600007A RID: 122
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern uint GetMonoUsedSize();

		// Token: 0x0600007B RID: 123
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern uint GetTotalAllocatedMemory();

		// Token: 0x0600007C RID: 124
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern uint GetTotalUnusedReservedMemory();

		// Token: 0x0600007D RID: 125
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern uint GetTotalReservedMemory();
	}
}
