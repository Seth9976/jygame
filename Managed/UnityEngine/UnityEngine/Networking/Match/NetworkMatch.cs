using System;
using System.Collections;
using System.Collections.Generic;
using SimpleJson;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
	/// <summary>
	///   <para>A component for communicating with the UNET Matchmaking service.</para>
	/// </summary>
	// Token: 0x02000218 RID: 536
	public class NetworkMatch : MonoBehaviour
	{
		/// <summary>
		///   <para>The base URI of the UNET MatchMaker that this NetworkMatch will communicate with.</para>
		/// </summary>
		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06001EB8 RID: 7864 RVA: 0x0000C2B7 File Offset: 0x0000A4B7
		// (set) Token: 0x06001EB9 RID: 7865 RVA: 0x0000C2BF File Offset: 0x0000A4BF
		public Uri baseUri
		{
			get
			{
				return this.m_BaseUri;
			}
			set
			{
				this.m_BaseUri = value;
			}
		}

		/// <summary>
		///   <para>Set this before calling any UNET functions. Must match AppID for this program from the Cloud API.</para>
		/// </summary>
		/// <param name="programAppID">AppID that corresponds to the Cloud API AppID for this app.</param>
		// Token: 0x06001EBA RID: 7866 RVA: 0x0000C2C8 File Offset: 0x0000A4C8
		public void SetProgramAppID(AppID programAppID)
		{
			Utility.SetAppID(programAppID);
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x00025430 File Offset: 0x00023630
		public Coroutine CreateMatch(string matchName, uint matchSize, bool matchAdvertise, string matchPassword, NetworkMatch.ResponseDelegate<CreateMatchResponse> callback)
		{
			return this.CreateMatch(new CreateMatchRequest
			{
				name = matchName,
				size = matchSize,
				advertise = matchAdvertise,
				password = matchPassword
			}, callback);
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x0002546C File Offset: 0x0002366C
		public Coroutine CreateMatch(CreateMatchRequest req, NetworkMatch.ResponseDelegate<CreateMatchResponse> callback)
		{
			Uri uri = new Uri(this.baseUri, "/json/reply/CreateMatchRequest");
			Debug.Log("MatchMakingClient Create :" + uri);
			WWWForm wwwform = new WWWForm();
			wwwform.AddField("projectId", Application.cloudProjectId);
			wwwform.AddField("sourceId", Utility.GetSourceID().ToString());
			wwwform.AddField("appId", Utility.GetAppID().ToString());
			wwwform.AddField("accessTokenString", 0);
			wwwform.AddField("domain", 0);
			wwwform.AddField("name", req.name);
			wwwform.AddField("size", req.size.ToString());
			wwwform.AddField("advertise", req.advertise.ToString());
			wwwform.AddField("password", req.password);
			wwwform.headers["Accept"] = "application/json";
			WWW www = new WWW(uri.ToString(), wwwform);
			return base.StartCoroutine(this.ProcessMatchResponse<CreateMatchResponse>(www, callback));
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x00025584 File Offset: 0x00023784
		public Coroutine JoinMatch(NetworkID netId, string matchPassword, NetworkMatch.ResponseDelegate<JoinMatchResponse> callback)
		{
			return this.JoinMatch(new JoinMatchRequest
			{
				networkId = netId,
				password = matchPassword
			}, callback);
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x000255B0 File Offset: 0x000237B0
		public Coroutine JoinMatch(JoinMatchRequest req, NetworkMatch.ResponseDelegate<JoinMatchResponse> callback)
		{
			Uri uri = new Uri(this.baseUri, "/json/reply/JoinMatchRequest");
			Debug.Log("MatchMakingClient Join :" + uri);
			WWWForm wwwform = new WWWForm();
			wwwform.AddField("projectId", Application.cloudProjectId);
			wwwform.AddField("sourceId", Utility.GetSourceID().ToString());
			wwwform.AddField("appId", Utility.GetAppID().ToString());
			wwwform.AddField("accessTokenString", 0);
			wwwform.AddField("domain", 0);
			wwwform.AddField("networkId", req.networkId.ToString());
			wwwform.AddField("password", req.password);
			wwwform.headers["Accept"] = "application/json";
			WWW www = new WWW(uri.ToString(), wwwform);
			return base.StartCoroutine(this.ProcessMatchResponse<JoinMatchResponse>(www, callback));
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x0002569C File Offset: 0x0002389C
		public Coroutine DestroyMatch(NetworkID netId, NetworkMatch.ResponseDelegate<BasicResponse> callback)
		{
			return this.DestroyMatch(new DestroyMatchRequest
			{
				networkId = netId
			}, callback);
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x000256C0 File Offset: 0x000238C0
		public Coroutine DestroyMatch(DestroyMatchRequest req, NetworkMatch.ResponseDelegate<BasicResponse> callback)
		{
			Uri uri = new Uri(this.baseUri, "/json/reply/DestroyMatchRequest");
			Debug.Log("MatchMakingClient Destroy :" + uri.ToString());
			WWWForm wwwform = new WWWForm();
			wwwform.AddField("projectId", Application.cloudProjectId);
			wwwform.AddField("sourceId", Utility.GetSourceID().ToString());
			wwwform.AddField("appId", Utility.GetAppID().ToString());
			wwwform.AddField("accessTokenString", Utility.GetAccessTokenForNetwork(req.networkId).GetByteString());
			wwwform.AddField("domain", 0);
			wwwform.AddField("networkId", req.networkId.ToString());
			wwwform.headers["Accept"] = "application/json";
			WWW www = new WWW(uri.ToString(), wwwform);
			return base.StartCoroutine(this.ProcessMatchResponse<BasicResponse>(www, callback));
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x000257B0 File Offset: 0x000239B0
		public Coroutine DropConnection(NetworkID netId, NodeID dropNodeId, NetworkMatch.ResponseDelegate<BasicResponse> callback)
		{
			return this.DropConnection(new DropConnectionRequest
			{
				networkId = netId,
				nodeId = dropNodeId
			}, callback);
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x000257DC File Offset: 0x000239DC
		public Coroutine DropConnection(DropConnectionRequest req, NetworkMatch.ResponseDelegate<BasicResponse> callback)
		{
			Uri uri = new Uri(this.baseUri, "/json/reply/DropConnectionRequest");
			Debug.Log("MatchMakingClient DropConnection :" + uri);
			WWWForm wwwform = new WWWForm();
			wwwform.AddField("projectId", Application.cloudProjectId);
			wwwform.AddField("sourceId", Utility.GetSourceID().ToString());
			wwwform.AddField("appId", Utility.GetAppID().ToString());
			wwwform.AddField("accessTokenString", Utility.GetAccessTokenForNetwork(req.networkId).GetByteString());
			wwwform.AddField("domain", 0);
			wwwform.AddField("networkId", req.networkId.ToString());
			wwwform.AddField("nodeId", req.nodeId.ToString());
			wwwform.headers["Accept"] = "application/json";
			WWW www = new WWW(uri.ToString(), wwwform);
			return base.StartCoroutine(this.ProcessMatchResponse<BasicResponse>(www, callback));
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x000258E4 File Offset: 0x00023AE4
		public Coroutine ListMatches(int startPageNumber, int resultPageSize, string matchNameFilter, NetworkMatch.ResponseDelegate<ListMatchResponse> callback)
		{
			return this.ListMatches(new ListMatchRequest
			{
				pageNum = startPageNumber,
				pageSize = resultPageSize,
				nameFilter = matchNameFilter
			}, callback);
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x00025918 File Offset: 0x00023B18
		public Coroutine ListMatches(ListMatchRequest req, NetworkMatch.ResponseDelegate<ListMatchResponse> callback)
		{
			Uri uri = new Uri(this.baseUri, "/json/reply/ListMatchRequest");
			Debug.Log("MatchMakingClient ListMatches :" + uri);
			WWWForm wwwform = new WWWForm();
			wwwform.AddField("projectId", Application.cloudProjectId);
			wwwform.AddField("sourceId", Utility.GetSourceID().ToString());
			wwwform.AddField("appId", Utility.GetAppID().ToString());
			wwwform.AddField("includePasswordMatches", req.includePasswordMatches.ToString());
			wwwform.AddField("accessTokenString", 0);
			wwwform.AddField("domain", 0);
			wwwform.AddField("pageSize", req.pageSize);
			wwwform.AddField("pageNum", req.pageNum);
			wwwform.AddField("nameFilter", req.nameFilter);
			wwwform.headers["Accept"] = "application/json";
			WWW www = new WWW(uri.ToString(), wwwform);
			return base.StartCoroutine(this.ProcessMatchResponse<ListMatchResponse>(www, callback));
		}

		// Token: 0x06001EC5 RID: 7877 RVA: 0x00025A24 File Offset: 0x00023C24
		private IEnumerator ProcessMatchResponse<JSONRESPONSE>(WWW client, NetworkMatch.ResponseDelegate<JSONRESPONSE> callback) where JSONRESPONSE : Response, new()
		{
			yield return client;
			JSONRESPONSE jsonInterface = (JSONRESPONSE)((object)null);
			if (string.IsNullOrEmpty(client.error))
			{
				object o;
				if (global::SimpleJson.SimpleJson.TryDeserializeObject(client.text, out o))
				{
					IDictionary<string, object> dictJsonObj = o as IDictionary<string, object>;
					if (dictJsonObj != null)
					{
						try
						{
							jsonInterface = new JSONRESPONSE();
							jsonInterface.Parse(o);
						}
						catch (FormatException ex)
						{
							FormatException exception = ex;
							Debug.Log(exception);
						}
					}
				}
				if (jsonInterface == null)
				{
					Debug.LogError("Could not parse: " + client.text);
				}
				else
				{
					Debug.Log("JSON Response: " + jsonInterface.ToString());
				}
			}
			else
			{
				Debug.LogError("Request error: " + client.error);
				Debug.LogError("Raw response: " + client.text);
			}
			if (jsonInterface == null)
			{
				jsonInterface = new JSONRESPONSE();
			}
			callback(jsonInterface);
			yield break;
		}

		// Token: 0x0400084C RID: 2124
		private const string kMultiplayerNetworkingIdKey = "CloudNetworkingId";

		// Token: 0x0400084D RID: 2125
		private Uri m_BaseUri = new Uri("https://mm.unet.unity3d.com");

		// Token: 0x02000219 RID: 537
		// (Invoke) Token: 0x06001EC7 RID: 7879
		public delegate void ResponseDelegate<T>(T response);
	}
}
