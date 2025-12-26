using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Security;
using System.Security.Permissions;
using System.Text;
using Microsoft.Win32;

namespace System.Diagnostics
{
	/// <summary>Specifies a set of values that are used when you start a process.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x02000250 RID: 592
	[global::System.ComponentModel.TypeConverter(typeof(global::System.ComponentModel.ExpandableObjectConverter))]
	[PermissionSet((SecurityAction)14, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\nversion=\"1\"\nUnrestricted=\"true\"/>\n")]
	public sealed class ProcessStartInfo
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.ProcessStartInfo" /> class without specifying a file name with which to start the process.</summary>
		// Token: 0x060014A0 RID: 5280 RVA: 0x00041CB4 File Offset: 0x0003FEB4
		public ProcessStartInfo()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.ProcessStartInfo" /> class and specifies a file name such as an application or document with which to start the process.</summary>
		/// <param name="fileName">An application or document with which to start a process. </param>
		// Token: 0x060014A1 RID: 5281 RVA: 0x00041D08 File Offset: 0x0003FF08
		public ProcessStartInfo(string filename)
		{
			this.filename = filename;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.ProcessStartInfo" /> class, specifies an application file name with which to start the process, and specifies a set of command-line arguments to pass to the application.</summary>
		/// <param name="fileName">An application with which to start a process. </param>
		/// <param name="arguments">Command-line arguments to pass to the application when the process starts. </param>
		// Token: 0x060014A2 RID: 5282 RVA: 0x00041D64 File Offset: 0x0003FF64
		public ProcessStartInfo(string filename, string arguments)
		{
			this.filename = filename;
			this.arguments = arguments;
		}

		/// <summary>Gets or sets the set of command-line arguments to use when starting the application.</summary>
		/// <returns>File type–specific arguments that the system can associate with the application specified in the <see cref="P:System.Diagnostics.ProcessStartInfo.FileName" /> property. The length of the arguments added to the length of the full path to the process must be less than 2080.</returns>
		/// <filterpriority>1</filterpriority>
		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x060014A4 RID: 5284 RVA: 0x0000FFE3 File Offset: 0x0000E1E3
		// (set) Token: 0x060014A5 RID: 5285 RVA: 0x0000FFEB File Offset: 0x0000E1EB
		[global::System.ComponentModel.RecommendedAsConfigurable(true)]
		[global::System.ComponentModel.TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[global::System.ComponentModel.DefaultValue("")]
		[MonitoringDescription("Command line agruments for this process.")]
		[global::System.ComponentModel.NotifyParentProperty(true)]
		public string Arguments
		{
			get
			{
				return this.arguments;
			}
			set
			{
				this.arguments = value;
			}
		}

		/// <summary>Gets or sets a value indicating whether to start the process in a new window.</summary>
		/// <returns>true to start the process without creating a new window to contain it; otherwise, false. The default is false.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x060014A6 RID: 5286 RVA: 0x0000FFF4 File Offset: 0x0000E1F4
		// (set) Token: 0x060014A7 RID: 5287 RVA: 0x0000FFFC File Offset: 0x0000E1FC
		[MonitoringDescription("Start this process with a new window.")]
		[global::System.ComponentModel.NotifyParentProperty(true)]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool CreateNoWindow
		{
			get
			{
				return this.create_no_window;
			}
			set
			{
				this.create_no_window = value;
			}
		}

		/// <summary>Gets search paths for files, directories for temporary files, application-specific options, and other similar information.</summary>
		/// <returns>A <see cref="T:System.Collections.Specialized.StringDictionary" /> that provides environment variables that apply to this process and child processes. The default is null.</returns>
		/// <filterpriority>1</filterpriority>
		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x060014A8 RID: 5288 RVA: 0x00041DC4 File Offset: 0x0003FFC4
		[global::System.ComponentModel.NotifyParentProperty(true)]
		[MonitoringDescription("Environment variables used for this process.")]
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.Editor("System.Diagnostics.Design.StringDictionaryEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		public global::System.Collections.Specialized.StringDictionary EnvironmentVariables
		{
			get
			{
				if (this.envVars == null)
				{
					this.envVars = new global::System.Collections.Specialized.ProcessStringDictionary();
					foreach (object obj in Environment.GetEnvironmentVariables())
					{
						DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
						this.envVars.Add((string)dictionaryEntry.Key, (string)dictionaryEntry.Value);
					}
				}
				return this.envVars;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x060014A9 RID: 5289 RVA: 0x00010005 File Offset: 0x0000E205
		internal bool HaveEnvVars
		{
			get
			{
				return this.envVars != null;
			}
		}

		/// <summary>Gets or sets a value indicating whether an error dialog box is displayed to the user if the process cannot be started.</summary>
		/// <returns>true to display an error dialog box on the screen if the process cannot be started; otherwise, false.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x060014AA RID: 5290 RVA: 0x00010013 File Offset: 0x0000E213
		// (set) Token: 0x060014AB RID: 5291 RVA: 0x0001001B File Offset: 0x0000E21B
		[MonitoringDescription("Thread shows dialogboxes for errors.")]
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.NotifyParentProperty(true)]
		public bool ErrorDialog
		{
			get
			{
				return this.error_dialog;
			}
			set
			{
				this.error_dialog = value;
			}
		}

		/// <summary>Gets or sets the window handle to use when an error dialog box is shown for a process that cannot be started.</summary>
		/// <returns>An <see cref="T:System.IntPtr" /> that identifies the handle of the error dialog box that results from a process start failure.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x060014AC RID: 5292 RVA: 0x00010024 File Offset: 0x0000E224
		// (set) Token: 0x060014AD RID: 5293 RVA: 0x0001002C File Offset: 0x0000E22C
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public IntPtr ErrorDialogParentHandle
		{
			get
			{
				return this.error_dialog_parent_handle;
			}
			set
			{
				this.error_dialog_parent_handle = value;
			}
		}

		/// <summary>Gets or sets the application or document to start.</summary>
		/// <returns>The name of the application to start, or the name of a document of a file type that is associated with an application and that has a default open action available to it. The default is an empty string ("").</returns>
		/// <filterpriority>1</filterpriority>
		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060014AE RID: 5294 RVA: 0x00010035 File Offset: 0x0000E235
		// (set) Token: 0x060014AF RID: 5295 RVA: 0x0001003D File Offset: 0x0000E23D
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.RecommendedAsConfigurable(true)]
		[global::System.ComponentModel.Editor("System.Diagnostics.Design.StartFileNameEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[global::System.ComponentModel.TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[MonitoringDescription("The name of the resource to start this process.")]
		[global::System.ComponentModel.NotifyParentProperty(true)]
		public string FileName
		{
			get
			{
				return this.filename;
			}
			set
			{
				this.filename = value;
			}
		}

		/// <summary>Gets or sets a value that indicates whether the error output of an application is written to the <see cref="P:System.Diagnostics.Process.StandardError" /> stream.</summary>
		/// <returns>true to write error output to <see cref="P:System.Diagnostics.Process.StandardError" />; otherwise, false.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060014B0 RID: 5296 RVA: 0x00010046 File Offset: 0x0000E246
		// (set) Token: 0x060014B1 RID: 5297 RVA: 0x0001004E File Offset: 0x0000E24E
		[MonitoringDescription("Errors of this process are redirected.")]
		[global::System.ComponentModel.NotifyParentProperty(true)]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool RedirectStandardError
		{
			get
			{
				return this.redirect_standard_error;
			}
			set
			{
				this.redirect_standard_error = value;
			}
		}

		/// <summary>Gets or sets a value indicating whether the input for an application is read from the <see cref="P:System.Diagnostics.Process.StandardInput" /> stream.</summary>
		/// <returns>true to read input from <see cref="P:System.Diagnostics.Process.StandardInput" />; otherwise, false.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x060014B2 RID: 5298 RVA: 0x00010057 File Offset: 0x0000E257
		// (set) Token: 0x060014B3 RID: 5299 RVA: 0x0001005F File Offset: 0x0000E25F
		[MonitoringDescription("Standard input of this process is redirected.")]
		[global::System.ComponentModel.NotifyParentProperty(true)]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool RedirectStandardInput
		{
			get
			{
				return this.redirect_standard_input;
			}
			set
			{
				this.redirect_standard_input = value;
			}
		}

		/// <summary>Gets or sets a value that indicates whether the output of an application is written to the <see cref="P:System.Diagnostics.Process.StandardOutput" /> stream.</summary>
		/// <returns>true to write output to <see cref="P:System.Diagnostics.Process.StandardOutput" />; otherwise, false.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x060014B4 RID: 5300 RVA: 0x00010068 File Offset: 0x0000E268
		// (set) Token: 0x060014B5 RID: 5301 RVA: 0x00010070 File Offset: 0x0000E270
		[global::System.ComponentModel.DefaultValue(false)]
		[MonitoringDescription("Standart output of this process is redirected.")]
		[global::System.ComponentModel.NotifyParentProperty(true)]
		public bool RedirectStandardOutput
		{
			get
			{
				return this.redirect_standard_output;
			}
			set
			{
				this.redirect_standard_output = value;
			}
		}

		/// <summary>Gets or sets the preferred encoding for error output.</summary>
		/// <returns>An <see cref="T:System.Text.Encoding" /> object that represents the preferred encoding for error output. The default is null.</returns>
		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x060014B6 RID: 5302 RVA: 0x00010079 File Offset: 0x0000E279
		// (set) Token: 0x060014B7 RID: 5303 RVA: 0x00010081 File Offset: 0x0000E281
		public Encoding StandardErrorEncoding
		{
			get
			{
				return this.encoding_stderr;
			}
			set
			{
				this.encoding_stderr = value;
			}
		}

		/// <summary>Gets or sets the preferred encoding for standard output.</summary>
		/// <returns>An <see cref="T:System.Text.Encoding" /> object that represents the preferred encoding for standard output. The default is null.</returns>
		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x060014B8 RID: 5304 RVA: 0x0001008A File Offset: 0x0000E28A
		// (set) Token: 0x060014B9 RID: 5305 RVA: 0x00010092 File Offset: 0x0000E292
		public Encoding StandardOutputEncoding
		{
			get
			{
				return this.encoding_stdout;
			}
			set
			{
				this.encoding_stdout = value;
			}
		}

		/// <summary>Gets or sets a value indicating whether to use the operating system shell to start the process.</summary>
		/// <returns>true to use the shell when starting the process; otherwise, the process is created directly from the executable file. The default is true.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x060014BA RID: 5306 RVA: 0x0001009B File Offset: 0x0000E29B
		// (set) Token: 0x060014BB RID: 5307 RVA: 0x000100A3 File Offset: 0x0000E2A3
		[global::System.ComponentModel.NotifyParentProperty(true)]
		[MonitoringDescription("Use the shell to start this process.")]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool UseShellExecute
		{
			get
			{
				return this.use_shell_execute;
			}
			set
			{
				this.use_shell_execute = value;
			}
		}

		/// <summary>Gets or sets the verb to use when opening the application or document specified by the <see cref="P:System.Diagnostics.ProcessStartInfo.FileName" /> property.</summary>
		/// <returns>The action to take with the file that the process opens. The default is an empty string ("").</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x060014BC RID: 5308 RVA: 0x000100AC File Offset: 0x0000E2AC
		// (set) Token: 0x060014BD RID: 5309 RVA: 0x000100B4 File Offset: 0x0000E2B4
		[global::System.ComponentModel.NotifyParentProperty(true)]
		[global::System.ComponentModel.DefaultValue("")]
		[MonitoringDescription("The verb to apply to a used document.")]
		[global::System.ComponentModel.TypeConverter("System.Diagnostics.Design.VerbConverter, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		public string Verb
		{
			get
			{
				return this.verb;
			}
			set
			{
				this.verb = value;
			}
		}

		/// <summary>Gets the set of verbs associated with the type of file specified by the <see cref="P:System.Diagnostics.ProcessStartInfo.FileName" /> property.</summary>
		/// <returns>The actions that the system can apply to the file indicated by the <see cref="P:System.Diagnostics.ProcessStartInfo.FileName" /> property.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x060014BE RID: 5310 RVA: 0x00041E60 File Offset: 0x00040060
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public string[] Verbs
		{
			get
			{
				string text = ((!((this.filename == null) | (this.filename.Length == 0))) ? Path.GetExtension(this.filename) : null);
				if (text == null)
				{
					return ProcessStartInfo.empty;
				}
				PlatformID platform = Environment.OSVersion.Platform;
				switch (platform)
				{
				case PlatformID.Unix:
				case PlatformID.MacOSX:
					break;
				default:
					if (platform != (PlatformID)128)
					{
						RegistryKey registryKey = null;
						RegistryKey registryKey2 = null;
						RegistryKey registryKey3 = null;
						string[] array;
						try
						{
							registryKey = Registry.ClassesRoot.OpenSubKey(text);
							string text2 = ((registryKey == null) ? null : (registryKey.GetValue(null) as string));
							registryKey2 = ((text2 == null) ? null : Registry.ClassesRoot.OpenSubKey(text2));
							registryKey3 = ((registryKey2 == null) ? null : registryKey2.OpenSubKey("shell"));
							array = ((registryKey3 == null) ? null : registryKey3.GetSubKeyNames());
						}
						finally
						{
							if (registryKey3 != null)
							{
								registryKey3.Close();
							}
							if (registryKey2 != null)
							{
								registryKey2.Close();
							}
							if (registryKey != null)
							{
								registryKey.Close();
							}
						}
						return array;
					}
					break;
				}
				return ProcessStartInfo.empty;
			}
		}

		/// <summary>Gets or sets the window state to use when the process is started.</summary>
		/// <returns>A <see cref="T:System.Diagnostics.ProcessWindowStyle" /> that indicates whether the process is started in a window that is maximized, minimized, normal (neither maximized nor minimized), or not visible. The default is normal.</returns>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The window style is not one of the <see cref="T:System.Diagnostics.ProcessWindowStyle" /> enumeration members. </exception>
		/// <filterpriority>2</filterpriority>
		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x060014BF RID: 5311 RVA: 0x000100BD File Offset: 0x0000E2BD
		// (set) Token: 0x060014C0 RID: 5312 RVA: 0x000100C5 File Offset: 0x0000E2C5
		[global::System.ComponentModel.NotifyParentProperty(true)]
		[global::System.ComponentModel.DefaultValue(typeof(ProcessWindowStyle), "Normal")]
		[MonitoringDescription("The window style used to start this process.")]
		public ProcessWindowStyle WindowStyle
		{
			get
			{
				return this.window_style;
			}
			set
			{
				this.window_style = value;
			}
		}

		/// <summary>Gets or sets the initial directory for the process to be started.</summary>
		/// <returns>The fully qualified name of the directory that contains the process to be started. The default is an empty string ("").</returns>
		/// <filterpriority>1</filterpriority>
		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x060014C1 RID: 5313 RVA: 0x000100CE File Offset: 0x0000E2CE
		// (set) Token: 0x060014C2 RID: 5314 RVA: 0x000100D6 File Offset: 0x0000E2D6
		[global::System.ComponentModel.TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[MonitoringDescription("The initial directory for this process.")]
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.RecommendedAsConfigurable(true)]
		[global::System.ComponentModel.Editor("System.Diagnostics.Design.WorkingDirectoryEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[global::System.ComponentModel.NotifyParentProperty(true)]
		public string WorkingDirectory
		{
			get
			{
				return this.working_directory;
			}
			set
			{
				this.working_directory = ((value != null) ? value : string.Empty);
			}
		}

		/// <summary>Gets or sets a value that indicates whether the Windows user profile is to be loaded from the registry. </summary>
		/// <returns>true to load the Windows user profile; otherwise, false. </returns>
		/// <filterpriority>1</filterpriority>
		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x060014C3 RID: 5315 RVA: 0x000100EF File Offset: 0x0000E2EF
		// (set) Token: 0x060014C4 RID: 5316 RVA: 0x000100F7 File Offset: 0x0000E2F7
		[global::System.ComponentModel.NotifyParentProperty(true)]
		public bool LoadUserProfile
		{
			get
			{
				return this.load_user_profile;
			}
			set
			{
				this.load_user_profile = value;
			}
		}

		/// <summary>Gets or sets the user name to be used when starting the process.</summary>
		/// <returns>The user name to use when starting the process.</returns>
		/// <filterpriority>1</filterpriority>
		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x060014C5 RID: 5317 RVA: 0x00010100 File Offset: 0x0000E300
		// (set) Token: 0x060014C6 RID: 5318 RVA: 0x00010108 File Offset: 0x0000E308
		[global::System.ComponentModel.NotifyParentProperty(true)]
		public string UserName
		{
			get
			{
				return this.username;
			}
			set
			{
				this.username = value;
			}
		}

		/// <summary>Gets or sets a value that identifies the domain to use when starting the process. </summary>
		/// <returns>The Active Directory domain to use when starting the process. The domain property is primarily of interest to users within enterprise environments that use Active Directory.</returns>
		/// <filterpriority>1</filterpriority>
		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x060014C7 RID: 5319 RVA: 0x00010111 File Offset: 0x0000E311
		// (set) Token: 0x060014C8 RID: 5320 RVA: 0x00010119 File Offset: 0x0000E319
		[global::System.ComponentModel.NotifyParentProperty(true)]
		public string Domain
		{
			get
			{
				return this.domain;
			}
			set
			{
				this.domain = value;
			}
		}

		/// <summary>Gets or sets a secure string that contains the user password to use when starting the process.</summary>
		/// <returns>A <see cref="T:System.Security.SecureString" /> that contains the user password to use when starting the process.</returns>
		/// <filterpriority>1</filterpriority>
		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x060014C9 RID: 5321 RVA: 0x00010122 File Offset: 0x0000E322
		// (set) Token: 0x060014CA RID: 5322 RVA: 0x0001012A File Offset: 0x0000E32A
		public SecureString Password
		{
			get
			{
				return this.password;
			}
			set
			{
				this.password = value;
			}
		}

		// Token: 0x0400063B RID: 1595
		private string arguments = string.Empty;

		// Token: 0x0400063C RID: 1596
		private IntPtr error_dialog_parent_handle = (IntPtr)0;

		// Token: 0x0400063D RID: 1597
		private string filename = string.Empty;

		// Token: 0x0400063E RID: 1598
		private string verb = string.Empty;

		// Token: 0x0400063F RID: 1599
		private string working_directory = string.Empty;

		// Token: 0x04000640 RID: 1600
		private global::System.Collections.Specialized.ProcessStringDictionary envVars;

		// Token: 0x04000641 RID: 1601
		private bool create_no_window;

		// Token: 0x04000642 RID: 1602
		private bool error_dialog;

		// Token: 0x04000643 RID: 1603
		private bool redirect_standard_error;

		// Token: 0x04000644 RID: 1604
		private bool redirect_standard_input;

		// Token: 0x04000645 RID: 1605
		private bool redirect_standard_output;

		// Token: 0x04000646 RID: 1606
		private bool use_shell_execute = true;

		// Token: 0x04000647 RID: 1607
		private ProcessWindowStyle window_style;

		// Token: 0x04000648 RID: 1608
		private Encoding encoding_stderr;

		// Token: 0x04000649 RID: 1609
		private Encoding encoding_stdout;

		// Token: 0x0400064A RID: 1610
		private string username;

		// Token: 0x0400064B RID: 1611
		private string domain;

		// Token: 0x0400064C RID: 1612
		private SecureString password;

		// Token: 0x0400064D RID: 1613
		private bool load_user_profile;

		// Token: 0x0400064E RID: 1614
		private static readonly string[] empty = new string[0];
	}
}
