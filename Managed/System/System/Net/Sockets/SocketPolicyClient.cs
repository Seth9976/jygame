using System;
using System.IO;
using System.Text;

namespace System.Net.Sockets
{
	// Token: 0x02000418 RID: 1048
	internal static class SocketPolicyClient
	{
		// Token: 0x06002469 RID: 9321 RVA: 0x000195AE File Offset: 0x000177AE
		private static void Log(string msg)
		{
			Console.WriteLine(string.Concat(new object[]
			{
				"SocketPolicyClient",
				SocketPolicyClient.session,
				": ",
				msg
			}));
		}

		// Token: 0x0600246A RID: 9322 RVA: 0x0006AC3C File Offset: 0x00068E3C
		private static Stream GetPolicyStreamForIP(string ip, int policyport, int timeout)
		{
			SocketPolicyClient.session++;
			SocketPolicyClient.Log("Incoming GetPolicyStreamForIP");
			IPEndPoint ipendPoint = new IPEndPoint(IPAddress.Parse(ip), policyport);
			Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			byte[] array = new byte[5000];
			MemoryStream memoryStream = new MemoryStream();
			try
			{
				SocketPolicyClient.Log("About to BeginConnect to " + ipendPoint);
				IAsyncResult asyncResult = socket.BeginConnect(ipendPoint, null, null, false);
				SocketPolicyClient.Log("About to WaitOne");
				DateTime now = DateTime.Now;
				if (!asyncResult.AsyncWaitHandle.WaitOne(timeout))
				{
					SocketPolicyClient.Log("WaitOne timed out. Duration: " + (DateTime.Now - now).TotalMilliseconds);
					socket.Close();
					throw new Exception("BeginConnect timed out");
				}
				socket.EndConnect(asyncResult);
				SocketPolicyClient.Log("Socket connected");
				byte[] bytes = Encoding.ASCII.GetBytes("<policy-file-request/>\0");
				SocketError socketError;
				socket.Send_nochecks(bytes, 0, bytes.Length, SocketFlags.None, out socketError);
				if (socketError != SocketError.Success)
				{
					SocketPolicyClient.Log("Socket error: " + socketError);
					return memoryStream;
				}
				int num = socket.Receive_nochecks(array, 0, array.Length, SocketFlags.None, out socketError);
				if (socketError != SocketError.Success)
				{
					SocketPolicyClient.Log("Socket error: " + socketError);
					return memoryStream;
				}
				try
				{
					socket.Shutdown(SocketShutdown.Both);
					socket.Close();
				}
				catch (SocketException)
				{
				}
				memoryStream = new MemoryStream(array, 0, num);
			}
			catch (Exception ex)
			{
				SocketPolicyClient.Log("Caught exception: " + ex.Message);
				return memoryStream;
			}
			memoryStream.Seek(0L, SeekOrigin.Begin);
			return memoryStream;
		}

		// Token: 0x04001636 RID: 5686
		private const string policy_request = "<policy-file-request/>\0";

		// Token: 0x04001637 RID: 5687
		private static int session;
	}
}
