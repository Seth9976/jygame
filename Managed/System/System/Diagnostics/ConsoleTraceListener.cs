using System;

namespace System.Diagnostics
{
	/// <summary>Directs tracing or debugging output to either the standard output or the standard error stream.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x02000213 RID: 531
	public class ConsoleTraceListener : TextWriterTraceListener
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.ConsoleTraceListener" /> class with trace output written to the standard output stream.</summary>
		// Token: 0x060011B0 RID: 4528 RVA: 0x0000E44C File Offset: 0x0000C64C
		public ConsoleTraceListener()
			: this(false)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.ConsoleTraceListener" /> class with an option to write trace output to the standard output stream or the standard error stream.</summary>
		/// <param name="useErrorStream">true to write tracing and debugging output to the standard error stream; false to write tracing and debugging output to the standard output stream.</param>
		// Token: 0x060011B1 RID: 4529 RVA: 0x0000E455 File Offset: 0x0000C655
		public ConsoleTraceListener(bool useErrorStream)
			: base((!useErrorStream) ? Console.Out : Console.Error)
		{
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x0000E472 File Offset: 0x0000C672
		internal ConsoleTraceListener(string data)
			: this(Convert.ToBoolean(data))
		{
		}
	}
}
