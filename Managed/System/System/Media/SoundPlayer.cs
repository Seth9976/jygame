using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Threading;
using Mono.Audio;

namespace System.Media
{
	/// <summary>Controls playback of a sound from a .wav file.</summary>
	// Token: 0x020002C1 RID: 705
	[global::System.ComponentModel.ToolboxItem(false)]
	[Serializable]
	public class SoundPlayer : global::System.ComponentModel.Component, ISerializable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Media.SoundPlayer" /> class.</summary>
		// Token: 0x0600182E RID: 6190 RVA: 0x00011E4C File Offset: 0x0001004C
		public SoundPlayer()
		{
			this.sound_location = string.Empty;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Media.SoundPlayer" /> class, and attaches the .wav file within the specified <see cref="T:System.IO.Stream" />.</summary>
		/// <param name="stream">A <see cref="T:System.IO.Stream" /> to a .wav file.</param>
		// Token: 0x0600182F RID: 6191 RVA: 0x00011E75 File Offset: 0x00010075
		public SoundPlayer(Stream stream)
			: this()
		{
			this.audiostream = stream;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Media.SoundPlayer" /> class, and attaches the specified .wav file.</summary>
		/// <param name="soundLocation">The location of a .wav file to load.</param>
		/// <exception cref="T:System.UriFormatException">The URL value specified by <paramref name="soundLocation" /> cannot be resolved.</exception>
		// Token: 0x06001830 RID: 6192 RVA: 0x00011E84 File Offset: 0x00010084
		public SoundPlayer(string soundLocation)
			: this()
		{
			if (soundLocation == null)
			{
				throw new ArgumentNullException("soundLocation");
			}
			this.sound_location = soundLocation;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Media.SoundPlayer" /> class.</summary>
		/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to be used for deserialization.</param>
		/// <param name="context">The destination to be used for deserialization.</param>
		/// <exception cref="T:System.UriFormatException">The <see cref="P:System.Media.SoundPlayer.SoundLocation" /> specified in <paramref name="serializationInfo" /> cannot be resolved.</exception>
		// Token: 0x06001831 RID: 6193 RVA: 0x00011EA4 File Offset: 0x000100A4
		protected SoundPlayer(SerializationInfo serializationInfo, StreamingContext context)
			: this()
		{
			throw new NotImplementedException();
		}

		/// <summary>Occurs when a .wav file has been successfully or unsuccessfully loaded.</summary>
		// Token: 0x1400004B RID: 75
		// (add) Token: 0x06001833 RID: 6195 RVA: 0x00011EC8 File Offset: 0x000100C8
		// (remove) Token: 0x06001834 RID: 6196 RVA: 0x00011EE1 File Offset: 0x000100E1
		public event global::System.ComponentModel.AsyncCompletedEventHandler LoadCompleted;

		/// <summary>Occurs when a new audio source path for this <see cref="T:System.Media.SoundPlayer" /> has been set.</summary>
		// Token: 0x1400004C RID: 76
		// (add) Token: 0x06001835 RID: 6197 RVA: 0x00011EFA File Offset: 0x000100FA
		// (remove) Token: 0x06001836 RID: 6198 RVA: 0x00011F13 File Offset: 0x00010113
		public event EventHandler SoundLocationChanged;

		/// <summary>Occurs when a new <see cref="T:System.IO.Stream" /> audio source for this <see cref="T:System.Media.SoundPlayer" /> has been set.</summary>
		// Token: 0x1400004D RID: 77
		// (add) Token: 0x06001837 RID: 6199 RVA: 0x00011F2C File Offset: 0x0001012C
		// (remove) Token: 0x06001838 RID: 6200 RVA: 0x00011F45 File Offset: 0x00010145
		public event EventHandler StreamChanged;

		/// <summary>For a description of this member, see the <see cref="M:System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)" /> method.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" />  to populate with data.</param>
		/// <param name="context">The destination (see <see cref="T:System.Runtime.Serialization.StreamingContext" />) for this serialization.</param>
		// Token: 0x06001839 RID: 6201 RVA: 0x000029F5 File Offset: 0x00000BF5
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x0004A2D4 File Offset: 0x000484D4
		private void LoadFromStream(Stream s)
		{
			this.mstream = new MemoryStream();
			byte[] array = new byte[4096];
			int num;
			while ((num = s.Read(array, 0, 4096)) > 0)
			{
				this.mstream.Write(array, 0, num);
			}
			this.mstream.Position = 0L;
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x0004A32C File Offset: 0x0004852C
		private void LoadFromUri(string location)
		{
			this.mstream = null;
			if (string.IsNullOrEmpty(location))
			{
				return;
			}
			Stream stream;
			if (File.Exists(location))
			{
				stream = new FileStream(location, FileMode.Open, FileAccess.Read, FileShare.Read);
			}
			else
			{
				global::System.Net.WebRequest webRequest = global::System.Net.WebRequest.Create(location);
				stream = webRequest.GetResponse().GetResponseStream();
			}
			using (stream)
			{
				this.LoadFromStream(stream);
			}
		}

		/// <summary>Loads a sound synchronously.</summary>
		/// <exception cref="T:System.ServiceProcess.TimeoutException">The elapsed time during loading exceeds the time, in milliseconds, specified by <see cref="P:System.Media.SoundPlayer.LoadTimeout" />. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">The file specified by <see cref="P:System.Media.SoundPlayer.SoundLocation" /> cannot be found.</exception>
		// Token: 0x0600183C RID: 6204 RVA: 0x0004A3A8 File Offset: 0x000485A8
		public void Load()
		{
			if (this.load_completed)
			{
				return;
			}
			if (this.audiostream != null)
			{
				this.LoadFromStream(this.audiostream);
			}
			else
			{
				this.LoadFromUri(this.sound_location);
			}
			this.adata = null;
			this.adev = null;
			this.load_completed = true;
			global::System.ComponentModel.AsyncCompletedEventArgs asyncCompletedEventArgs = new global::System.ComponentModel.AsyncCompletedEventArgs(null, false, this);
			this.OnLoadCompleted(asyncCompletedEventArgs);
			if (this.LoadCompleted != null)
			{
				this.LoadCompleted(this, asyncCompletedEventArgs);
			}
			if (SoundPlayer.use_win32_player)
			{
				if (this.win32_player == null)
				{
					this.win32_player = new Mono.Audio.Win32SoundPlayer(this.mstream);
				}
				else
				{
					this.win32_player.Stream = this.mstream;
				}
			}
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x0004A464 File Offset: 0x00048664
		private void AsyncFinished(IAsyncResult ar)
		{
			ThreadStart threadStart = ar.AsyncState as ThreadStart;
			threadStart.EndInvoke(ar);
		}

		/// <summary>Loads a .wav file from a stream or a Web resource using a new thread.</summary>
		/// <exception cref="T:System.ServiceProcess.TimeoutException">The elapsed time during loading exceeds the time, in milliseconds, specified by <see cref="P:System.Media.SoundPlayer.LoadTimeout" />. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">The file specified by <see cref="P:System.Media.SoundPlayer.SoundLocation" /> cannot be found.</exception>
		// Token: 0x0600183E RID: 6206 RVA: 0x0004A484 File Offset: 0x00048684
		public void LoadAsync()
		{
			if (this.load_completed)
			{
				return;
			}
			ThreadStart threadStart = new ThreadStart(this.Load);
			threadStart.BeginInvoke(new AsyncCallback(this.AsyncFinished), threadStart);
		}

		/// <summary>Raises the <see cref="E:System.Media.SoundPlayer.LoadCompleted" /> event.</summary>
		/// <param name="e">An <see cref="T:System.ComponentModel.AsyncCompletedEventArgs" />  that contains the event data. </param>
		// Token: 0x0600183F RID: 6207 RVA: 0x000029F5 File Offset: 0x00000BF5
		protected virtual void OnLoadCompleted(global::System.ComponentModel.AsyncCompletedEventArgs e)
		{
		}

		/// <summary>Raises the <see cref="E:System.Media.SoundPlayer.SoundLocationChanged" /> event.</summary>
		/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
		// Token: 0x06001840 RID: 6208 RVA: 0x000029F5 File Offset: 0x00000BF5
		protected virtual void OnSoundLocationChanged(EventArgs e)
		{
		}

		/// <summary>Raises the <see cref="E:System.Media.SoundPlayer.StreamChanged" /> event.</summary>
		/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
		// Token: 0x06001841 RID: 6209 RVA: 0x000029F5 File Offset: 0x00000BF5
		protected virtual void OnStreamChanged(EventArgs e)
		{
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x00011F5E File Offset: 0x0001015E
		private void Start()
		{
			if (!SoundPlayer.use_win32_player)
			{
				this.stopped = false;
				if (this.adata != null)
				{
					this.adata.IsStopped = false;
				}
			}
			if (!this.load_completed)
			{
				this.Load();
			}
		}

		/// <summary>Plays the .wav file using a new thread, and loads the .wav file first if it has not been loaded.</summary>
		/// <exception cref="T:System.ServiceProcess.TimeoutException">The elapsed time during loading exceeds the time, in milliseconds, specified by <see cref="P:System.Media.SoundPlayer.LoadTimeout" />. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">The file specified by <see cref="P:System.Media.SoundPlayer.SoundLocation" /> cannot be found.</exception>
		/// <exception cref="T:System.InvalidOperationException">The .wav header is corrupted; the file specified by <see cref="P:System.Media.SoundPlayer.SoundLocation" /> is not a PCM .wav file.</exception>
		// Token: 0x06001843 RID: 6211 RVA: 0x0004A4C0 File Offset: 0x000486C0
		public void Play()
		{
			if (!SoundPlayer.use_win32_player)
			{
				ThreadStart threadStart = new ThreadStart(this.PlaySync);
				threadStart.BeginInvoke(new AsyncCallback(this.AsyncFinished), threadStart);
			}
			else
			{
				this.Start();
				if (this.mstream == null)
				{
					SystemSounds.Beep.Play();
					return;
				}
				this.win32_player.Play();
			}
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x00011F99 File Offset: 0x00010199
		private void PlayLoop()
		{
			this.Start();
			if (this.mstream == null)
			{
				SystemSounds.Beep.Play();
				return;
			}
			while (!this.stopped)
			{
				this.PlaySync();
			}
		}

		/// <summary>Plays and loops the .wav file using a new thread, and loads the .wav file first if it has not been loaded.</summary>
		/// <exception cref="T:System.ServiceProcess.TimeoutException">The elapsed time during loading exceeds the time, in milliseconds, specified by <see cref="P:System.Media.SoundPlayer.LoadTimeout" />. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">The file specified by <see cref="P:System.Media.SoundPlayer.SoundLocation" /> cannot be found.</exception>
		/// <exception cref="T:System.InvalidOperationException">The .wav header is corrupted; the file specified by <see cref="P:System.Media.SoundPlayer.SoundLocation" /> is not a PCM .wav file.</exception>
		// Token: 0x06001845 RID: 6213 RVA: 0x0004A524 File Offset: 0x00048724
		public void PlayLooping()
		{
			if (!SoundPlayer.use_win32_player)
			{
				ThreadStart threadStart = new ThreadStart(this.PlayLoop);
				threadStart.BeginInvoke(new AsyncCallback(this.AsyncFinished), threadStart);
			}
			else
			{
				this.Start();
				if (this.mstream == null)
				{
					SystemSounds.Beep.Play();
					return;
				}
				this.win32_player.PlayLooping();
			}
		}

		/// <summary>Plays the .wav file and loads the .wav file first if it has not been loaded.</summary>
		/// <exception cref="T:System.ServiceProcess.TimeoutException">The elapsed time during loading exceeds the time, in milliseconds, specified by <see cref="P:System.Media.SoundPlayer.LoadTimeout" />. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">The file specified by <see cref="P:System.Media.SoundPlayer.SoundLocation" /> cannot be found.</exception>
		/// <exception cref="T:System.InvalidOperationException">The .wav header is corrupted; the file specified by <see cref="P:System.Media.SoundPlayer.SoundLocation" /> is not a PCM .wav file.</exception>
		// Token: 0x06001846 RID: 6214 RVA: 0x0004A588 File Offset: 0x00048788
		public void PlaySync()
		{
			this.Start();
			if (this.mstream == null)
			{
				SystemSounds.Beep.Play();
				return;
			}
			if (!SoundPlayer.use_win32_player)
			{
				try
				{
					if (this.adata == null)
					{
						this.adata = new Mono.Audio.WavData(this.mstream);
					}
					if (this.adev == null)
					{
						this.adev = Mono.Audio.AudioDevice.CreateDevice(null);
					}
					if (this.adata != null)
					{
						this.adata.Setup(this.adev);
						this.adata.Play(this.adev);
					}
				}
				catch
				{
				}
			}
			else
			{
				this.win32_player.PlaySync();
			}
		}

		/// <summary>Stops playback of the sound if playback is occurring.</summary>
		// Token: 0x06001847 RID: 6215 RVA: 0x00011FCD File Offset: 0x000101CD
		public void Stop()
		{
			if (!SoundPlayer.use_win32_player)
			{
				this.stopped = true;
				if (this.adata != null)
				{
					this.adata.IsStopped = true;
				}
			}
			else
			{
				this.win32_player.Stop();
			}
		}

		/// <summary>Gets a value indicating whether loading of a .wav file has successfully completed.</summary>
		/// <returns>true if a .wav file is loaded; false if a .wav file has not yet been loaded.</returns>
		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06001848 RID: 6216 RVA: 0x00012007 File Offset: 0x00010207
		public bool IsLoadCompleted
		{
			get
			{
				return this.load_completed;
			}
		}

		/// <summary>Gets or sets the time, in milliseconds, in which the .wav file must load.</summary>
		/// <returns>The number of milliseconds to wait. The default is 10000 (10 seconds).</returns>
		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001849 RID: 6217 RVA: 0x0001200F File Offset: 0x0001020F
		// (set) Token: 0x0600184A RID: 6218 RVA: 0x00012017 File Offset: 0x00010217
		public int LoadTimeout
		{
			get
			{
				return this.load_timeout;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentException("timeout must be >= 0");
				}
				this.load_timeout = value;
			}
		}

		/// <summary>Gets or sets the file path or URL of the .wav file to load.</summary>
		/// <returns>The file path or URL from which to load a .wav file, or <see cref="F:System.String.Empty" /> if no file path is present. The default is <see cref="F:System.String.Empty" />.</returns>
		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x0600184B RID: 6219 RVA: 0x00012032 File Offset: 0x00010232
		// (set) Token: 0x0600184C RID: 6220 RVA: 0x0004A648 File Offset: 0x00048848
		public string SoundLocation
		{
			get
			{
				return this.sound_location;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				this.sound_location = value;
				this.load_completed = false;
				this.OnSoundLocationChanged(EventArgs.Empty);
				if (this.SoundLocationChanged != null)
				{
					this.SoundLocationChanged(this, EventArgs.Empty);
				}
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.IO.Stream" /> from which to load the .wav file.</summary>
		/// <returns>A <see cref="T:System.IO.Stream" /> from which to load the .wav file, or null if no stream is available. The default is null.</returns>
		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x0600184D RID: 6221 RVA: 0x0001203A File Offset: 0x0001023A
		// (set) Token: 0x0600184E RID: 6222 RVA: 0x0004A69C File Offset: 0x0004889C
		public Stream Stream
		{
			get
			{
				return this.audiostream;
			}
			set
			{
				if (this.audiostream != value)
				{
					this.audiostream = value;
					this.load_completed = false;
					this.OnStreamChanged(EventArgs.Empty);
					if (this.StreamChanged != null)
					{
						this.StreamChanged(this, EventArgs.Empty);
					}
				}
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.Object" /> that contains data about the <see cref="T:System.Media.SoundPlayer" />.</summary>
		/// <returns>An <see cref="T:System.Object" /> that contains data about the <see cref="T:System.Media.SoundPlayer" />.</returns>
		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x0600184F RID: 6223 RVA: 0x00012042 File Offset: 0x00010242
		// (set) Token: 0x06001850 RID: 6224 RVA: 0x0001204A File Offset: 0x0001024A
		public object Tag
		{
			get
			{
				return this.tag;
			}
			set
			{
				this.tag = value;
			}
		}

		// Token: 0x04000F69 RID: 3945
		private string sound_location;

		// Token: 0x04000F6A RID: 3946
		private Stream audiostream;

		// Token: 0x04000F6B RID: 3947
		private object tag = string.Empty;

		// Token: 0x04000F6C RID: 3948
		private MemoryStream mstream;

		// Token: 0x04000F6D RID: 3949
		private bool load_completed;

		// Token: 0x04000F6E RID: 3950
		private int load_timeout = 10000;

		// Token: 0x04000F6F RID: 3951
		private Mono.Audio.AudioDevice adev;

		// Token: 0x04000F70 RID: 3952
		private Mono.Audio.AudioData adata;

		// Token: 0x04000F71 RID: 3953
		private bool stopped;

		// Token: 0x04000F72 RID: 3954
		private Mono.Audio.Win32SoundPlayer win32_player;

		// Token: 0x04000F73 RID: 3955
		private static readonly bool use_win32_player = Environment.OSVersion.Platform != PlatformID.Unix;
	}
}
