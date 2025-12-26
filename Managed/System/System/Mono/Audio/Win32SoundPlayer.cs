using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Mono.Audio
{
	// Token: 0x020002C4 RID: 708
	internal class Win32SoundPlayer : IDisposable
	{
		// Token: 0x06001859 RID: 6233 RVA: 0x0004A70C File Offset: 0x0004890C
		public Win32SoundPlayer(Stream s)
		{
			if (s != null)
			{
				this._buffer = new byte[s.Length];
				s.Read(this._buffer, 0, this._buffer.Length);
			}
			else
			{
				this._buffer = new byte[0];
			}
		}

		// Token: 0x0600185A RID: 6234
		[DllImport("winmm.dll", SetLastError = true)]
		private static extern bool PlaySound(byte[] ptrToSound, UIntPtr hmod, Win32SoundPlayer.SoundFlags flags);

		// Token: 0x170005B3 RID: 1459
		// (set) Token: 0x0600185B RID: 6235 RVA: 0x0004A760 File Offset: 0x00048960
		public Stream Stream
		{
			set
			{
				this.Stop();
				if (value != null)
				{
					this._buffer = new byte[value.Length];
					value.Read(this._buffer, 0, this._buffer.Length);
				}
				else
				{
					this._buffer = new byte[0];
				}
			}
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x000120BC File Offset: 0x000102BC
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x0004A7B4 File Offset: 0x000489B4
		~Win32SoundPlayer()
		{
			this.Dispose(false);
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x000120CB File Offset: 0x000102CB
		protected virtual void Dispose(bool disposing)
		{
			if (!this._disposed)
			{
				this.Stop();
				this._disposed = true;
			}
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x000120E5 File Offset: 0x000102E5
		public void Play()
		{
			Win32SoundPlayer.PlaySound(this._buffer, UIntPtr.Zero, (Win32SoundPlayer.SoundFlags)5U);
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x000120F9 File Offset: 0x000102F9
		public void PlayLooping()
		{
			Win32SoundPlayer.PlaySound(this._buffer, UIntPtr.Zero, (Win32SoundPlayer.SoundFlags)13U);
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x0001210E File Offset: 0x0001030E
		public void PlaySync()
		{
			Win32SoundPlayer.PlaySound(this._buffer, UIntPtr.Zero, (Win32SoundPlayer.SoundFlags)6U);
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x00012122 File Offset: 0x00010322
		public void Stop()
		{
			Win32SoundPlayer.PlaySound(null, UIntPtr.Zero, Win32SoundPlayer.SoundFlags.SND_SYNC);
		}

		// Token: 0x04000F78 RID: 3960
		private byte[] _buffer;

		// Token: 0x04000F79 RID: 3961
		private bool _disposed;

		// Token: 0x020002C5 RID: 709
		private enum SoundFlags : uint
		{
			// Token: 0x04000F7B RID: 3963
			SND_SYNC,
			// Token: 0x04000F7C RID: 3964
			SND_ASYNC,
			// Token: 0x04000F7D RID: 3965
			SND_NODEFAULT,
			// Token: 0x04000F7E RID: 3966
			SND_MEMORY = 4U,
			// Token: 0x04000F7F RID: 3967
			SND_LOOP = 8U,
			// Token: 0x04000F80 RID: 3968
			SND_FILENAME = 131072U
		}
	}
}
