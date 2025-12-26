using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Diagnostics
{
	/// <summary>Provides the default output methods and behavior for tracing.</summary>
	/// <filterpriority>1</filterpriority>
	// Token: 0x0200021B RID: 539
	public class DefaultTraceListener : TraceListener
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DefaultTraceListener" /> class with "Default" as its <see cref="P:System.Diagnostics.TraceListener.Name" /> property value.</summary>
		// Token: 0x06001209 RID: 4617 RVA: 0x0000E805 File Offset: 0x0000CA05
		public DefaultTraceListener()
			: base("Default")
		{
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x0003C798 File Offset: 0x0003A998
		static DefaultTraceListener()
		{
			if (!DefaultTraceListener.OnWin32)
			{
				string environmentVariable = Environment.GetEnvironmentVariable("MONO_TRACE_LISTENER");
				if (environmentVariable != null)
				{
					string text;
					string text2;
					if (environmentVariable.StartsWith("Console.Out"))
					{
						text = "Console.Out";
						text2 = DefaultTraceListener.GetPrefix(environmentVariable, "Console.Out");
					}
					else if (environmentVariable.StartsWith("Console.Error"))
					{
						text = "Console.Error";
						text2 = DefaultTraceListener.GetPrefix(environmentVariable, "Console.Error");
					}
					else
					{
						text = environmentVariable;
						text2 = string.Empty;
					}
					DefaultTraceListener.MonoTraceFile = text;
					DefaultTraceListener.MonoTracePrefix = text2;
				}
			}
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x0000E812 File Offset: 0x0000CA12
		private static string GetPrefix(string var, string target)
		{
			if (var.Length > target.Length)
			{
				return var.Substring(target.Length + 1);
			}
			return string.Empty;
		}

		/// <summary>Gets or sets a value indicating whether the application is running in user-interface mode.</summary>
		/// <returns>true if user-interface mode is enabled; otherwise, false.</returns>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x0600120C RID: 4620 RVA: 0x0000E839 File Offset: 0x0000CA39
		// (set) Token: 0x0600120D RID: 4621 RVA: 0x0000E841 File Offset: 0x0000CA41
		public bool AssertUiEnabled
		{
			get
			{
				return this.assertUiEnabled;
			}
			set
			{
				this.assertUiEnabled = value;
			}
		}

		/// <summary>Gets or sets the name of a log file to write trace or debug messages to.</summary>
		/// <returns>The name of a log file to write trace or debug messages to.</returns>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x0600120E RID: 4622 RVA: 0x0000E84A File Offset: 0x0000CA4A
		// (set) Token: 0x0600120F RID: 4623 RVA: 0x0000E852 File Offset: 0x0000CA52
		[global::System.MonoTODO]
		public string LogFileName
		{
			get
			{
				return this.logFileName;
			}
			set
			{
				this.logFileName = value;
			}
		}

		/// <summary>Emits or displays a message and a stack trace for an assertion that always fails.</summary>
		/// <param name="message">The message to emit or display. </param>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		///   <IPermission class="System.Security.Permissions.UIPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x06001210 RID: 4624 RVA: 0x0000E85B File Offset: 0x0000CA5B
		public override void Fail(string message)
		{
			base.Fail(message);
		}

		/// <summary>Emits or displays detailed messages and a stack trace for an assertion that always fails.</summary>
		/// <param name="message">The message to emit or display. </param>
		/// <param name="detailMessage">The detailed message to emit or display. </param>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		///   <IPermission class="System.Security.Permissions.UIPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x06001211 RID: 4625 RVA: 0x0003C834 File Offset: 0x0003AA34
		public override void Fail(string message, string detailMessage)
		{
			base.Fail(message, detailMessage);
			if (this.ProcessUI(message, detailMessage) == DefaultTraceListener.DialogResult.Abort)
			{
				try
				{
					Thread.CurrentThread.Abort();
				}
				catch (MethodAccessException)
				{
				}
			}
			this.WriteLine(new StackTrace().ToString());
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x0003C88C File Offset: 0x0003AA8C
		private DefaultTraceListener.DialogResult ProcessUI(string message, string detailMessage)
		{
			if (!this.AssertUiEnabled)
			{
				return DefaultTraceListener.DialogResult.None;
			}
			object obj;
			MethodInfo method;
			try
			{
				Assembly assembly = Assembly.Load("System.Windows.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");
				if (assembly == null)
				{
					return DefaultTraceListener.DialogResult.None;
				}
				Type type = assembly.GetType("System.Windows.Forms.MessageBoxButtons");
				obj = Enum.Parse(type, "AbortRetryIgnore");
				method = assembly.GetType("System.Windows.Forms.MessageBox").GetMethod("Show", new Type[]
				{
					typeof(string),
					typeof(string),
					type
				});
			}
			catch
			{
				return DefaultTraceListener.DialogResult.None;
			}
			if (method == null || obj == null)
			{
				return DefaultTraceListener.DialogResult.None;
			}
			string text = string.Format("Assertion Failed: {0} to quit, {1} to debug, {2} to continue", "Abort", "Retry", "Ignore");
			string text2 = string.Format("{0}{1}{2}{1}{1}{3}", new object[]
			{
				message,
				Environment.NewLine,
				detailMessage,
				new StackTrace()
			});
			string text3 = method.Invoke(null, new object[] { text2, text, obj }).ToString();
			if (text3 != null)
			{
				if (DefaultTraceListener.<>f__switch$map3 == null)
				{
					DefaultTraceListener.<>f__switch$map3 = new Dictionary<string, int>(2)
					{
						{ "Ignore", 0 },
						{ "Abort", 1 }
					};
				}
				int num;
				if (DefaultTraceListener.<>f__switch$map3.TryGetValue(text3, out num))
				{
					if (num == 0)
					{
						return DefaultTraceListener.DialogResult.Ignore;
					}
					if (num == 1)
					{
						return DefaultTraceListener.DialogResult.Abort;
					}
				}
			}
			return DefaultTraceListener.DialogResult.Retry;
		}

		// Token: 0x06001213 RID: 4627
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void WriteWindowsDebugString(string message);

		// Token: 0x06001214 RID: 4628 RVA: 0x0000E864 File Offset: 0x0000CA64
		private void WriteDebugString(string message)
		{
			if (DefaultTraceListener.OnWin32)
			{
				DefaultTraceListener.WriteWindowsDebugString(message);
			}
			else
			{
				this.WriteMonoTrace(message);
			}
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x0003CA14 File Offset: 0x0003AC14
		private void WriteMonoTrace(string message)
		{
			string monoTraceFile = DefaultTraceListener.MonoTraceFile;
			if (monoTraceFile != null)
			{
				if (DefaultTraceListener.<>f__switch$map4 == null)
				{
					DefaultTraceListener.<>f__switch$map4 = new Dictionary<string, int>(2)
					{
						{ "Console.Out", 0 },
						{ "Console.Error", 1 }
					};
				}
				int num;
				if (DefaultTraceListener.<>f__switch$map4.TryGetValue(monoTraceFile, out num))
				{
					if (num == 0)
					{
						Console.Out.Write(message);
						return;
					}
					if (num == 1)
					{
						Console.Error.Write(message);
						return;
					}
				}
			}
			this.WriteLogFile(message, DefaultTraceListener.MonoTraceFile);
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x0000E882 File Offset: 0x0000CA82
		private void WritePrefix()
		{
			if (!DefaultTraceListener.OnWin32)
			{
				this.WriteMonoTrace(DefaultTraceListener.MonoTracePrefix);
			}
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x0000E899 File Offset: 0x0000CA99
		private void WriteImpl(string message)
		{
			if (base.NeedIndent)
			{
				this.WriteIndent();
				this.WritePrefix();
			}
			this.WriteDebugString(message);
			if (Debugger.IsLogging())
			{
				Debugger.Log(0, null, message);
			}
			this.WriteLogFile(message, this.LogFileName);
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x0003CAB4 File Offset: 0x0003ACB4
		private void WriteLogFile(string message, string logFile)
		{
			try
			{
				this.WriteLogFileImpl(message, logFile);
			}
			catch (MethodAccessException)
			{
			}
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x0003CAE4 File Offset: 0x0003ACE4
		private void WriteLogFileImpl(string message, string logFile)
		{
			if (logFile != null && logFile.Length != 0)
			{
				FileInfo fileInfo = new FileInfo(logFile);
				StreamWriter streamWriter = null;
				try
				{
					if (fileInfo.Exists)
					{
						streamWriter = fileInfo.AppendText();
					}
					else
					{
						streamWriter = fileInfo.CreateText();
					}
				}
				catch
				{
					return;
				}
				using (streamWriter)
				{
					streamWriter.Write(message);
					streamWriter.Flush();
				}
			}
		}

		/// <summary>Writes the output to the OutputDebugString function and to the <see cref="M:System.Diagnostics.Debugger.Log(System.Int32,System.String,System.String)" /> method.</summary>
		/// <param name="message">The message to write to OutputDebugString and <see cref="M:System.Diagnostics.Debugger.Log(System.Int32,System.String,System.String)" />. </param>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x0600121A RID: 4634 RVA: 0x0000E8D8 File Offset: 0x0000CAD8
		public override void Write(string message)
		{
			this.WriteImpl(message);
		}

		/// <summary>Writes the output to the OutputDebugString function and to the <see cref="M:System.Diagnostics.Debugger.Log(System.Int32,System.String,System.String)" /> method, followed by a carriage return and line feed (\r\n).</summary>
		/// <param name="message">The message to write to OutputDebugString and <see cref="M:System.Diagnostics.Debugger.Log(System.Int32,System.String,System.String)" />. </param>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x0600121B RID: 4635 RVA: 0x0003CB78 File Offset: 0x0003AD78
		public override void WriteLine(string message)
		{
			string text = message + Environment.NewLine;
			this.WriteImpl(text);
			base.NeedIndent = true;
		}

		// Token: 0x0400052A RID: 1322
		private const string ConsoleOutTrace = "Console.Out";

		// Token: 0x0400052B RID: 1323
		private const string ConsoleErrorTrace = "Console.Error";

		// Token: 0x0400052C RID: 1324
		private static readonly bool OnWin32 = Path.DirectorySeparatorChar == '\\';

		// Token: 0x0400052D RID: 1325
		private static readonly string MonoTracePrefix;

		// Token: 0x0400052E RID: 1326
		private static readonly string MonoTraceFile;

		// Token: 0x0400052F RID: 1327
		private string logFileName;

		// Token: 0x04000530 RID: 1328
		private bool assertUiEnabled;

		// Token: 0x0200021C RID: 540
		private enum DialogResult
		{
			// Token: 0x04000534 RID: 1332
			None,
			// Token: 0x04000535 RID: 1333
			Retry,
			// Token: 0x04000536 RID: 1334
			Ignore,
			// Token: 0x04000537 RID: 1335
			Abort
		}
	}
}
