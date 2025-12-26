using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace UnityEngine
{
	// Token: 0x020000A1 RID: 161
	internal sealed class UnityLogWriter : TextWriter
	{
		// Token: 0x06000938 RID: 2360
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void WriteStringToUnityLog(string s);

		// Token: 0x06000939 RID: 2361 RVA: 0x0000578A File Offset: 0x0000398A
		public static void Init()
		{
			Console.SetOut(new UnityLogWriter());
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x0600093A RID: 2362 RVA: 0x00005796 File Offset: 0x00003996
		public override Encoding Encoding
		{
			get
			{
				return Encoding.UTF8;
			}
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x0000579D File Offset: 0x0000399D
		public override void Write(char value)
		{
			UnityLogWriter.WriteStringToUnityLog(value.ToString());
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x000057AB File Offset: 0x000039AB
		public override void Write(string s)
		{
			UnityLogWriter.WriteStringToUnityLog(s);
		}
	}
}
