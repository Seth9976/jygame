using System;
using UnityEngine.Networking.NetworkSystem;

namespace UnityEngine.Networking
{
	// Token: 0x0200002E RID: 46
	[AddComponentMenu("Network/NetworkAnimator")]
	[RequireComponent(typeof(NetworkIdentity))]
	[RequireComponent(typeof(Animator))]
	[DisallowMultipleComponent]
	public class NetworkAnimator : NetworkBehaviour
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00005014 File Offset: 0x00003214
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x0000501C File Offset: 0x0000321C
		public Animator animator
		{
			get
			{
				return this.m_Animator;
			}
			set
			{
				this.m_Animator = value;
				this.ResetParameterOptions();
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000502C File Offset: 0x0000322C
		public void SetParameterAutoSend(int index, bool value)
		{
			if (value)
			{
				this.m_ParameterSendBits |= 1U << index;
			}
			else
			{
				this.m_ParameterSendBits &= ~(1U << index);
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000506C File Offset: 0x0000326C
		public bool GetParameterAutoSend(int index)
		{
			return (this.m_ParameterSendBits & (1U << index)) != 0U;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00005084 File Offset: 0x00003284
		internal void ResetParameterOptions()
		{
			Debug.Log("ResetParameterOptions");
			this.m_ParameterSendBits = 0U;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00005098 File Offset: 0x00003298
		private void InitializeAuthority()
		{
			this.m_ParameterWriter = new NetworkWriter();
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000050A8 File Offset: 0x000032A8
		public override void OnStartServer()
		{
			if (!base.localPlayerAuthority)
			{
				this.InitializeAuthority();
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000050BC File Offset: 0x000032BC
		public override void OnStartLocalPlayer()
		{
			if (base.localPlayerAuthority)
			{
				this.InitializeAuthority();
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000050D0 File Offset: 0x000032D0
		private void FixedUpdate()
		{
			if (this.m_ParameterWriter == null)
			{
				return;
			}
			this.CheckSendRate();
			int num;
			float num2;
			if (!this.CheckAnimStateChanged(out num, out num2))
			{
				return;
			}
			AnimationMessage animationMessage = new AnimationMessage();
			animationMessage.netId = base.netId;
			animationMessage.stateHash = num;
			animationMessage.normalizedTime = num2;
			this.m_ParameterWriter.SeekZero();
			this.WriteParameters(this.m_ParameterWriter, false);
			animationMessage.parameters = this.m_ParameterWriter.ToArray();
			if (base.hasAuthority || ClientScene.readyConnection != null)
			{
				ClientScene.readyConnection.Send(40, animationMessage);
				return;
			}
			if (base.isServer && !base.localPlayerAuthority)
			{
				NetworkServer.SendToReady(base.gameObject, 40, animationMessage);
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00005194 File Offset: 0x00003394
		private bool CheckAnimStateChanged(out int stateHash, out float normalizedTime)
		{
			stateHash = 0;
			normalizedTime = 0f;
			if (this.m_Animator.IsInTransition(0))
			{
				AnimatorTransitionInfo animatorTransitionInfo = this.m_Animator.GetAnimatorTransitionInfo(0);
				if (animatorTransitionInfo.fullPathHash != this.m_TransitionHash)
				{
					this.m_TransitionHash = animatorTransitionInfo.fullPathHash;
					this.m_AnimationHash = 0;
					return true;
				}
				return false;
			}
			else
			{
				AnimatorStateInfo currentAnimatorStateInfo = this.m_Animator.GetCurrentAnimatorStateInfo(0);
				if (currentAnimatorStateInfo.fullPathHash != this.m_AnimationHash)
				{
					if (this.m_AnimationHash != 0)
					{
						stateHash = currentAnimatorStateInfo.fullPathHash;
						normalizedTime = currentAnimatorStateInfo.normalizedTime;
					}
					this.m_TransitionHash = 0;
					this.m_AnimationHash = currentAnimatorStateInfo.fullPathHash;
					return true;
				}
				return false;
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00005248 File Offset: 0x00003448
		private void CheckSendRate()
		{
			if (this.GetNetworkSendInterval() != 0f && this.m_SendTimer < Time.time)
			{
				this.m_SendTimer = Time.time + this.GetNetworkSendInterval();
				AnimationParametersMessage animationParametersMessage = new AnimationParametersMessage();
				animationParametersMessage.netId = base.netId;
				this.m_ParameterWriter.SeekZero();
				this.WriteParameters(this.m_ParameterWriter, true);
				animationParametersMessage.parameters = this.m_ParameterWriter.ToArray();
				if (base.hasAuthority && ClientScene.readyConnection != null)
				{
					ClientScene.readyConnection.Send(41, animationParametersMessage);
					return;
				}
				if (base.isServer && !base.localPlayerAuthority)
				{
					NetworkServer.SendToReady(base.gameObject, 41, animationParametersMessage);
				}
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000530C File Offset: 0x0000350C
		private void SetSendTrackingParam(string p, int i)
		{
			p = "Sent Param: " + p;
			if (i == 0)
			{
				this.param0 = p;
			}
			if (i == 1)
			{
				this.param1 = p;
			}
			if (i == 2)
			{
				this.param2 = p;
			}
			if (i == 3)
			{
				this.param3 = p;
			}
			if (i == 4)
			{
				this.param4 = p;
			}
			if (i == 5)
			{
				this.param5 = p;
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000537C File Offset: 0x0000357C
		private void SetRecvTrackingParam(string p, int i)
		{
			p = "Recv Param: " + p;
			if (i == 0)
			{
				this.param0 = p;
			}
			if (i == 1)
			{
				this.param1 = p;
			}
			if (i == 2)
			{
				this.param2 = p;
			}
			if (i == 3)
			{
				this.param3 = p;
			}
			if (i == 4)
			{
				this.param4 = p;
			}
			if (i == 5)
			{
				this.param5 = p;
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000053EC File Offset: 0x000035EC
		internal void HandleAnimMsg(AnimationMessage msg, NetworkReader reader)
		{
			if (base.hasAuthority)
			{
				return;
			}
			if (msg.stateHash != 0)
			{
				this.m_Animator.Play(msg.stateHash, 0, msg.normalizedTime);
			}
			this.ReadParameters(reader, false);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00005428 File Offset: 0x00003628
		internal void HandleAnimParamsMsg(AnimationParametersMessage msg, NetworkReader reader)
		{
			if (base.hasAuthority)
			{
				return;
			}
			this.ReadParameters(reader, true);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00005440 File Offset: 0x00003640
		internal void HandleAnimTriggerMsg(int hash)
		{
			this.m_Animator.SetTrigger(hash);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00005450 File Offset: 0x00003650
		private void WriteParameters(NetworkWriter writer, bool autoSend)
		{
			for (int i = 0; i < this.m_Animator.parameters.Length; i++)
			{
				if (!autoSend || this.GetParameterAutoSend(i))
				{
					AnimatorControllerParameter animatorControllerParameter = this.m_Animator.parameters[i];
					if (animatorControllerParameter.type == AnimatorControllerParameterType.Int)
					{
						writer.WritePackedUInt32((uint)this.m_Animator.GetInteger(animatorControllerParameter.nameHash));
						this.SetSendTrackingParam(animatorControllerParameter.name + ":" + this.m_Animator.GetInteger(animatorControllerParameter.nameHash), i);
					}
					if (animatorControllerParameter.type == AnimatorControllerParameterType.Float)
					{
						writer.Write(this.m_Animator.GetFloat(animatorControllerParameter.nameHash));
						this.SetSendTrackingParam(animatorControllerParameter.name + ":" + this.m_Animator.GetFloat(animatorControllerParameter.nameHash), i);
					}
					if (animatorControllerParameter.type == AnimatorControllerParameterType.Bool)
					{
						writer.Write(this.m_Animator.GetBool(animatorControllerParameter.nameHash));
						this.SetSendTrackingParam(animatorControllerParameter.name + ":" + this.m_Animator.GetBool(animatorControllerParameter.nameHash), i);
					}
				}
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00005590 File Offset: 0x00003790
		private void ReadParameters(NetworkReader reader, bool autoSend)
		{
			for (int i = 0; i < this.m_Animator.parameters.Length; i++)
			{
				if (!autoSend || this.GetParameterAutoSend(i))
				{
					AnimatorControllerParameter animatorControllerParameter = this.m_Animator.parameters[i];
					if (animatorControllerParameter.type == AnimatorControllerParameterType.Int)
					{
						int num = (int)reader.ReadPackedUInt32();
						this.m_Animator.SetInteger(animatorControllerParameter.nameHash, num);
						this.SetRecvTrackingParam(animatorControllerParameter.name + ":" + num, i);
					}
					if (animatorControllerParameter.type == AnimatorControllerParameterType.Float)
					{
						float num2 = reader.ReadSingle();
						this.m_Animator.SetFloat(animatorControllerParameter.nameHash, num2);
						this.SetRecvTrackingParam(animatorControllerParameter.name + ":" + num2, i);
					}
					if (animatorControllerParameter.type == AnimatorControllerParameterType.Bool)
					{
						bool flag = reader.ReadBoolean();
						this.m_Animator.SetBool(animatorControllerParameter.nameHash, flag);
						this.SetRecvTrackingParam(animatorControllerParameter.name + ":" + flag, i);
					}
				}
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000056AC File Offset: 0x000038AC
		public override bool OnSerialize(NetworkWriter writer, bool forceAll)
		{
			if (forceAll)
			{
				if (this.m_Animator.IsInTransition(0))
				{
					AnimatorStateInfo nextAnimatorStateInfo = this.m_Animator.GetNextAnimatorStateInfo(0);
					writer.Write(nextAnimatorStateInfo.fullPathHash);
					writer.Write(nextAnimatorStateInfo.normalizedTime);
				}
				else
				{
					AnimatorStateInfo currentAnimatorStateInfo = this.m_Animator.GetCurrentAnimatorStateInfo(0);
					writer.Write(currentAnimatorStateInfo.fullPathHash);
					writer.Write(currentAnimatorStateInfo.normalizedTime);
				}
				this.WriteParameters(writer, false);
				return true;
			}
			return false;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00005730 File Offset: 0x00003930
		public override void OnDeserialize(NetworkReader reader, bool initialState)
		{
			if (initialState)
			{
				int num = reader.ReadInt32();
				float num2 = reader.ReadSingle();
				this.ReadParameters(reader, false);
				this.m_Animator.Play(num, 0, num2);
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00005768 File Offset: 0x00003968
		public void SetTrigger(string triggerName)
		{
			this.SetTrigger(Animator.StringToHash(triggerName));
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00005778 File Offset: 0x00003978
		public void SetTrigger(int hash)
		{
			AnimationTriggerMessage animationTriggerMessage = new AnimationTriggerMessage();
			animationTriggerMessage.netId = base.netId;
			animationTriggerMessage.hash = hash;
			if (base.hasAuthority && base.localPlayerAuthority)
			{
				if (NetworkClient.allClients.Count > 0)
				{
					NetworkConnection readyConnection = ClientScene.readyConnection;
					if (readyConnection != null)
					{
						readyConnection.Send(42, animationTriggerMessage);
					}
				}
				return;
			}
			if (base.isServer && !base.localPlayerAuthority)
			{
				NetworkServer.SendToReady(base.gameObject, 42, animationTriggerMessage);
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00005800 File Offset: 0x00003A00
		internal static void OnAnimationServerMessage(NetworkMessage netMsg)
		{
			netMsg.ReadMessage<AnimationMessage>(NetworkAnimator.s_AnimationMessage);
			if (LogFilter.logDev)
			{
				Debug.Log(string.Concat(new object[]
				{
					"OnAnimationMessage for netId=",
					NetworkAnimator.s_AnimationMessage.netId,
					" conn=",
					netMsg.conn
				}));
			}
			GameObject gameObject = NetworkServer.FindLocalObject(NetworkAnimator.s_AnimationMessage.netId);
			if (gameObject == null)
			{
				return;
			}
			NetworkAnimator component = gameObject.GetComponent<NetworkAnimator>();
			if (component != null)
			{
				NetworkReader networkReader = new NetworkReader(NetworkAnimator.s_AnimationMessage.parameters);
				component.HandleAnimMsg(NetworkAnimator.s_AnimationMessage, networkReader);
				NetworkServer.SendToReady(gameObject, 40, NetworkAnimator.s_AnimationMessage);
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000058B8 File Offset: 0x00003AB8
		internal static void OnAnimationParametersServerMessage(NetworkMessage netMsg)
		{
			netMsg.ReadMessage<AnimationParametersMessage>(NetworkAnimator.s_AnimationParametersMessage);
			if (LogFilter.logDev)
			{
				Debug.Log(string.Concat(new object[]
				{
					"OnAnimationParametersMessage for netId=",
					NetworkAnimator.s_AnimationParametersMessage.netId,
					" conn=",
					netMsg.conn
				}));
			}
			GameObject gameObject = NetworkServer.FindLocalObject(NetworkAnimator.s_AnimationParametersMessage.netId);
			if (gameObject == null)
			{
				return;
			}
			NetworkAnimator component = gameObject.GetComponent<NetworkAnimator>();
			if (component != null)
			{
				NetworkReader networkReader = new NetworkReader(NetworkAnimator.s_AnimationParametersMessage.parameters);
				component.HandleAnimParamsMsg(NetworkAnimator.s_AnimationParametersMessage, networkReader);
				NetworkServer.SendToReady(gameObject, 41, NetworkAnimator.s_AnimationParametersMessage);
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00005970 File Offset: 0x00003B70
		internal static void OnAnimationTriggerServerMessage(NetworkMessage netMsg)
		{
			netMsg.ReadMessage<AnimationTriggerMessage>(NetworkAnimator.s_AnimationTriggerMessage);
			if (LogFilter.logDev)
			{
				Debug.Log(string.Concat(new object[]
				{
					"OnAnimationTriggerMessage for netId=",
					NetworkAnimator.s_AnimationTriggerMessage.netId,
					" conn=",
					netMsg.conn
				}));
			}
			GameObject gameObject = NetworkServer.FindLocalObject(NetworkAnimator.s_AnimationTriggerMessage.netId);
			if (gameObject == null)
			{
				return;
			}
			NetworkAnimator component = gameObject.GetComponent<NetworkAnimator>();
			if (component != null)
			{
				component.HandleAnimTriggerMsg(NetworkAnimator.s_AnimationTriggerMessage.hash);
				NetworkServer.SendToReady(gameObject, 42, NetworkAnimator.s_AnimationTriggerMessage);
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00005A1C File Offset: 0x00003C1C
		internal static void OnAnimationClientMessage(NetworkMessage netMsg)
		{
			netMsg.ReadMessage<AnimationMessage>(NetworkAnimator.s_AnimationMessage);
			GameObject gameObject = ClientScene.FindLocalObject(NetworkAnimator.s_AnimationMessage.netId);
			if (gameObject == null)
			{
				return;
			}
			NetworkAnimator component = gameObject.GetComponent<NetworkAnimator>();
			if (component != null)
			{
				NetworkReader networkReader = new NetworkReader(NetworkAnimator.s_AnimationMessage.parameters);
				component.HandleAnimMsg(NetworkAnimator.s_AnimationMessage, networkReader);
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00005A80 File Offset: 0x00003C80
		internal static void OnAnimationParametersClientMessage(NetworkMessage netMsg)
		{
			netMsg.ReadMessage<AnimationParametersMessage>(NetworkAnimator.s_AnimationParametersMessage);
			GameObject gameObject = ClientScene.FindLocalObject(NetworkAnimator.s_AnimationParametersMessage.netId);
			if (gameObject == null)
			{
				return;
			}
			NetworkAnimator component = gameObject.GetComponent<NetworkAnimator>();
			if (component != null)
			{
				NetworkReader networkReader = new NetworkReader(NetworkAnimator.s_AnimationParametersMessage.parameters);
				component.HandleAnimParamsMsg(NetworkAnimator.s_AnimationParametersMessage, networkReader);
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00005AE4 File Offset: 0x00003CE4
		internal static void OnAnimationTriggerClientMessage(NetworkMessage netMsg)
		{
			netMsg.ReadMessage<AnimationTriggerMessage>(NetworkAnimator.s_AnimationTriggerMessage);
			GameObject gameObject = ClientScene.FindLocalObject(NetworkAnimator.s_AnimationTriggerMessage.netId);
			if (gameObject == null)
			{
				return;
			}
			NetworkAnimator component = gameObject.GetComponent<NetworkAnimator>();
			if (component != null)
			{
				component.HandleAnimTriggerMsg(NetworkAnimator.s_AnimationTriggerMessage.hash);
			}
		}

		// Token: 0x0400007A RID: 122
		[SerializeField]
		private Animator m_Animator;

		// Token: 0x0400007B RID: 123
		[SerializeField]
		private uint m_ParameterSendBits;

		// Token: 0x0400007C RID: 124
		private static AnimationMessage s_AnimationMessage = new AnimationMessage();

		// Token: 0x0400007D RID: 125
		private static AnimationParametersMessage s_AnimationParametersMessage = new AnimationParametersMessage();

		// Token: 0x0400007E RID: 126
		private static AnimationTriggerMessage s_AnimationTriggerMessage = new AnimationTriggerMessage();

		// Token: 0x0400007F RID: 127
		private int m_AnimationHash;

		// Token: 0x04000080 RID: 128
		private int m_TransitionHash;

		// Token: 0x04000081 RID: 129
		private NetworkWriter m_ParameterWriter;

		// Token: 0x04000082 RID: 130
		private float m_SendTimer;

		// Token: 0x04000083 RID: 131
		public string param0;

		// Token: 0x04000084 RID: 132
		public string param1;

		// Token: 0x04000085 RID: 133
		public string param2;

		// Token: 0x04000086 RID: 134
		public string param3;

		// Token: 0x04000087 RID: 135
		public string param4;

		// Token: 0x04000088 RID: 136
		public string param5;
	}
}
