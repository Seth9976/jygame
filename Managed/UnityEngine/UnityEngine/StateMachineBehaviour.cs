using System;
using UnityEngine.Experimental.Director;

namespace UnityEngine
{
	/// <summary>
	///   <para>StateMachineBehaviour is a component that can be added to a state machine state. It's the base class every script on a state derives from.</para>
	/// </summary>
	// Token: 0x020002D9 RID: 729
	public abstract class StateMachineBehaviour : ScriptableObject
	{
		// Token: 0x060021FC RID: 8700 RVA: 0x00002753 File Offset: 0x00000953
		public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x060021FD RID: 8701 RVA: 0x00002753 File Offset: 0x00000953
		public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x060021FE RID: 8702 RVA: 0x00002753 File Offset: 0x00000953
		public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x060021FF RID: 8703 RVA: 0x00002753 File Offset: 0x00000953
		public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x06002200 RID: 8704 RVA: 0x00002753 File Offset: 0x00000953
		public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		/// <summary>
		///   <para>Called on the first Update frame when a transition from a state from another statemachine transition to one of this statemachine's state.</para>
		/// </summary>
		/// <param name="animator">The Animator playing this state machine.</param>
		/// <param name="stateMachinePathHash">The full path hash for this state machine.</param>
		// Token: 0x06002201 RID: 8705 RVA: 0x00002753 File Offset: 0x00000953
		public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
		{
		}

		/// <summary>
		///   <para>Called on the last Update frame when one of the statemachine's state is transitionning toward another state in another state machine.</para>
		/// </summary>
		/// <param name="animator">The Animator playing this state machine.</param>
		/// <param name="stateMachinePathHash">The full path hash for this state machine.</param>
		// Token: 0x06002202 RID: 8706 RVA: 0x00002753 File Offset: 0x00000953
		public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash)
		{
		}

		// Token: 0x06002203 RID: 8707 RVA: 0x00002753 File Offset: 0x00000953
		public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
		{
		}

		// Token: 0x06002204 RID: 8708 RVA: 0x00002753 File Offset: 0x00000953
		public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
		{
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x00002753 File Offset: 0x00000953
		public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
		{
		}

		// Token: 0x06002206 RID: 8710 RVA: 0x00002753 File Offset: 0x00000953
		public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
		{
		}

		// Token: 0x06002207 RID: 8711 RVA: 0x00002753 File Offset: 0x00000953
		public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
		{
		}

		// Token: 0x06002208 RID: 8712 RVA: 0x00002753 File Offset: 0x00000953
		public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller)
		{
		}

		// Token: 0x06002209 RID: 8713 RVA: 0x00002753 File Offset: 0x00000953
		public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller)
		{
		}
	}
}
