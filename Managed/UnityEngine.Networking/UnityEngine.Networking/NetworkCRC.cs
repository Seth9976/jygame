using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine.Networking.NetworkSystem;

namespace UnityEngine.Networking
{
	// Token: 0x02000039 RID: 57
	public class NetworkCRC
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00008B38 File Offset: 0x00006D38
		internal static NetworkCRC singleton
		{
			get
			{
				if (NetworkCRC.s_Singleton == null)
				{
					NetworkCRC.s_Singleton = new NetworkCRC();
				}
				return NetworkCRC.s_Singleton;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00008B54 File Offset: 0x00006D54
		public Dictionary<string, int> scripts
		{
			get
			{
				return this.m_Scripts;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00008B5C File Offset: 0x00006D5C
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x00008B68 File Offset: 0x00006D68
		public static bool scriptCRCCheck
		{
			get
			{
				return NetworkCRC.singleton.m_ScriptCRCCheck;
			}
			set
			{
				NetworkCRC.singleton.m_ScriptCRCCheck = value;
			}
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00008B78 File Offset: 0x00006D78
		public static void ReinitializeScriptCRCs(Assembly callingAssembly)
		{
			NetworkCRC.singleton.m_Scripts.Clear();
			foreach (Type type in callingAssembly.GetTypes())
			{
				if (type.BaseType == typeof(NetworkBehaviour))
				{
					MethodInfo method = type.GetMethod(".cctor", BindingFlags.Static);
					if (method != null)
					{
						method.Invoke(null, new object[0]);
					}
				}
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00008BEC File Offset: 0x00006DEC
		public static void RegisterBehaviour(string name, int channel)
		{
			NetworkCRC.singleton.m_Scripts[name] = channel;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00008C00 File Offset: 0x00006E00
		internal static bool Validate(CRCMessageEntry[] scripts, int numChannels)
		{
			return NetworkCRC.singleton.ValidateInternal(scripts, numChannels);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00008C10 File Offset: 0x00006E10
		private bool ValidateInternal(CRCMessageEntry[] remoteScripts, int numChannels)
		{
			if (this.m_Scripts.Count != remoteScripts.Length)
			{
				if (LogFilter.logWarn)
				{
					Debug.LogWarning("Network configuration mismatch detected. The number of networked scripts on the client does not match the number of networked scripts on the server. This could be caused by lazy loading of scripts on the client. This warning can be disabled by the checkbox NetworkManager Script CRC Check.");
				}
				this.Dump(remoteScripts);
				return false;
			}
			foreach (CRCMessageEntry crcmessageEntry in remoteScripts)
			{
				if (LogFilter.logDebug)
				{
					Debug.Log(string.Concat(new object[] { "Script: ", crcmessageEntry.name, " Channel: ", crcmessageEntry.channel }));
				}
				if (this.m_Scripts.ContainsKey(crcmessageEntry.name))
				{
					int num = this.m_Scripts[crcmessageEntry.name];
					if (num != (int)crcmessageEntry.channel)
					{
						if (LogFilter.logError)
						{
							Debug.LogError(string.Concat(new object[] { "HLAPI CRC Channel Mismatch. Script: ", crcmessageEntry.name, " LocalChannel: ", num, " RemoteChannel: ", crcmessageEntry.channel }));
						}
						this.Dump(remoteScripts);
						return false;
					}
				}
				if ((int)crcmessageEntry.channel >= numChannels)
				{
					if (LogFilter.logError)
					{
						Debug.LogError(string.Concat(new object[] { "HLAPI CRC channel out of range! Script: ", crcmessageEntry.name, " Channel: ", crcmessageEntry.channel }));
					}
					this.Dump(remoteScripts);
					return false;
				}
			}
			return true;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00008DA4 File Offset: 0x00006FA4
		private void Dump(CRCMessageEntry[] remoteScripts)
		{
			foreach (string text in this.m_Scripts.Keys)
			{
				Debug.Log(string.Concat(new object[]
				{
					"CRC Local Dump ",
					text,
					" : ",
					this.m_Scripts[text]
				}));
			}
			foreach (CRCMessageEntry crcmessageEntry in remoteScripts)
			{
				Debug.Log(string.Concat(new object[] { "CRC Remote Dump ", crcmessageEntry.name, " : ", crcmessageEntry.channel }));
			}
		}

		// Token: 0x040000D4 RID: 212
		internal static NetworkCRC s_Singleton;

		// Token: 0x040000D5 RID: 213
		private Dictionary<string, int> m_Scripts = new Dictionary<string, int>();

		// Token: 0x040000D6 RID: 214
		private bool m_ScriptCRCCheck;
	}
}
