using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Security.Principal;
using System.Threading;

namespace System.CodeDom.Compiler
{
	/// <summary>Provides command execution functions for invoking compilers. This class cannot be inherited.</summary>
	// Token: 0x02000086 RID: 134
	[PermissionSet((SecurityAction)14, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\nversion=\"1\"\nUnrestricted=\"true\"/>\n")]
	public sealed class Executor
	{
		// Token: 0x06000596 RID: 1430 RVA: 0x000021C3 File Offset: 0x000003C3
		private Executor()
		{
		}

		/// <summary>Executes the command using the specified temporary files and waits for the call to return.</summary>
		/// <param name="cmd">The command to execute. </param>
		/// <param name="tempFiles">A <see cref="T:System.CodeDom.Compiler.TempFileCollection" /> with which to manage and store references to intermediate files generated during compilation. </param>
		// Token: 0x06000597 RID: 1431 RVA: 0x00029490 File Offset: 0x00027690
		public static void ExecWait(string cmd, TempFileCollection tempFiles)
		{
			string text = null;
			string text2 = null;
			Executor.ExecWaitWithCapture(cmd, Environment.CurrentDirectory, tempFiles, ref text, ref text2);
		}

		/// <summary>Executes the specified command using the specified user token, current directory, and temporary files; then waits for the call to return, storing output and error information from the compiler in the specified strings.</summary>
		/// <returns>The return value from the compiler.</returns>
		/// <param name="userToken">The token to start the compiler process with. </param>
		/// <param name="cmd">The command to execute. </param>
		/// <param name="currentDir">The directory to start the process in. </param>
		/// <param name="tempFiles">A <see cref="T:System.CodeDom.Compiler.TempFileCollection" /> with which to manage and store references to intermediate files generated during compilation. </param>
		/// <param name="outputName">A reference to a string that will store the compiler's message output. </param>
		/// <param name="errorName">A reference to a string that will store the name of the error or errors encountered. </param>
		// Token: 0x06000598 RID: 1432 RVA: 0x000294B4 File Offset: 0x000276B4
		[PermissionSet(SecurityAction.Assert, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\nversion=\"1\">\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\nversion=\"1\"\nFlags=\"ControlPrincipal\"/>\n</PermissionSet>\n")]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\nversion=\"1\">\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\nversion=\"1\"\nFlags=\"UnmanagedCode\"/>\n</PermissionSet>\n")]
		public static int ExecWaitWithCapture(IntPtr userToken, string cmd, string currentDir, TempFileCollection tempFiles, ref string outputName, ref string errorName)
		{
			int num;
			using (WindowsIdentity.Impersonate(userToken))
			{
				num = Executor.InternalExecWaitWithCapture(cmd, currentDir, tempFiles, ref outputName, ref errorName);
			}
			return num;
		}

		/// <summary>Executes the specified command using the specified user token and temporary files, and waits for the call to return, storing output and error information from the compiler in the specified strings.</summary>
		/// <returns>The return value from the compiler.</returns>
		/// <param name="userToken">The token to start the compiler process with. </param>
		/// <param name="cmd">The command to execute. </param>
		/// <param name="tempFiles">A <see cref="T:System.CodeDom.Compiler.TempFileCollection" /> with which to manage and store references to intermediate files generated during compilation. </param>
		/// <param name="outputName">A reference to a string that will store the compiler's message output. </param>
		/// <param name="errorName">A reference to a string that will store the name of the error or errors encountered. </param>
		// Token: 0x06000599 RID: 1433 RVA: 0x00005DA4 File Offset: 0x00003FA4
		public static int ExecWaitWithCapture(IntPtr userToken, string cmd, TempFileCollection tempFiles, ref string outputName, ref string errorName)
		{
			return Executor.ExecWaitWithCapture(userToken, cmd, Environment.CurrentDirectory, tempFiles, ref outputName, ref errorName);
		}

		/// <summary>Executes the specified command using the specified current directory and temporary files, and waits for the call to return, storing output and error information from the compiler in the specified strings.</summary>
		/// <returns>The return value from the compiler.</returns>
		/// <param name="cmd">The command to execute. </param>
		/// <param name="currentDir">The current directory. </param>
		/// <param name="tempFiles">A <see cref="T:System.CodeDom.Compiler.TempFileCollection" /> with which to manage and store references to intermediate files generated during compilation. </param>
		/// <param name="outputName">A reference to a string that will store the compiler's message output. </param>
		/// <param name="errorName">A reference to a string that will store the name of the error or errors encountered. </param>
		// Token: 0x0600059A RID: 1434 RVA: 0x00005DB6 File Offset: 0x00003FB6
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\nversion=\"1\">\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\nversion=\"1\"\nFlags=\"UnmanagedCode\"/>\n</PermissionSet>\n")]
		public static int ExecWaitWithCapture(string cmd, string currentDir, TempFileCollection tempFiles, ref string outputName, ref string errorName)
		{
			return Executor.InternalExecWaitWithCapture(cmd, currentDir, tempFiles, ref outputName, ref errorName);
		}

		/// <summary>Executes the specified command using the specified temporary files and waits for the call to return, storing output and error information from the compiler in the specified strings.</summary>
		/// <returns>The return value from the compiler.</returns>
		/// <param name="cmd">The command to execute. </param>
		/// <param name="tempFiles">A <see cref="T:System.CodeDom.Compiler.TempFileCollection" /> with which to manage and store references to intermediate files generated during compilation. </param>
		/// <param name="outputName">A reference to a string that will store the compiler's message output. </param>
		/// <param name="errorName">A reference to a string that will store the name of the error or errors encountered. </param>
		// Token: 0x0600059B RID: 1435 RVA: 0x00005DC3 File Offset: 0x00003FC3
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\nversion=\"1\">\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\nversion=\"1\"\nFlags=\"UnmanagedCode\"/>\n</PermissionSet>\n")]
		public static int ExecWaitWithCapture(string cmd, TempFileCollection tempFiles, ref string outputName, ref string errorName)
		{
			return Executor.InternalExecWaitWithCapture(cmd, Environment.CurrentDirectory, tempFiles, ref outputName, ref errorName);
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00029500 File Offset: 0x00027700
		private static int InternalExecWaitWithCapture(string cmd, string currentDir, TempFileCollection tempFiles, ref string outputName, ref string errorName)
		{
			if (cmd == null || cmd.Length == 0)
			{
				throw new ExternalException(global::Locale.GetText("No command provided for execution."));
			}
			if (outputName == null)
			{
				outputName = tempFiles.AddExtension("out");
			}
			if (errorName == null)
			{
				errorName = tempFiles.AddExtension("err");
			}
			int num = -1;
			global::System.Diagnostics.Process process = new global::System.Diagnostics.Process();
			process.StartInfo.FileName = cmd;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.WorkingDirectory = currentDir;
			try
			{
				process.Start();
				Executor.ProcessResultReader processResultReader = new Executor.ProcessResultReader(process.StandardOutput, outputName);
				Executor.ProcessResultReader processResultReader2 = new Executor.ProcessResultReader(process.StandardError, errorName);
				Thread thread = new Thread(new ThreadStart(processResultReader2.Read));
				thread.Start();
				processResultReader.Read();
				thread.Join();
				process.WaitForExit();
			}
			finally
			{
				num = process.ExitCode;
				process.Close();
			}
			return num;
		}

		// Token: 0x02000087 RID: 135
		private class ProcessResultReader
		{
			// Token: 0x0600059D RID: 1437 RVA: 0x00005DD3 File Offset: 0x00003FD3
			public ProcessResultReader(StreamReader reader, string file)
			{
				this.reader = reader;
				this.file = file;
			}

			// Token: 0x0600059E RID: 1438 RVA: 0x00029620 File Offset: 0x00027820
			public void Read()
			{
				StreamWriter streamWriter = new StreamWriter(this.file);
				try
				{
					string text;
					while ((text = this.reader.ReadLine()) != null)
					{
						streamWriter.WriteLine(text);
					}
				}
				finally
				{
					streamWriter.Close();
				}
			}

			// Token: 0x0400015F RID: 351
			private StreamReader reader;

			// Token: 0x04000160 RID: 352
			private string file;
		}
	}
}
