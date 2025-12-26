using System;

namespace UnityEngine.Experimental.Director
{
	// Token: 0x020001A0 RID: 416
	public interface IAnimatorControllerPlayable
	{
		/// <summary>
		///   <para>Gets the value of a float parameter.</para>
		/// </summary>
		/// <param name="name">The name of the parameter.</param>
		/// <param name="id">The id of the parameter. The id is generated using Animator::StringToHash.</param>
		// Token: 0x06001788 RID: 6024
		float GetFloat(string name);

		/// <summary>
		///   <para>Gets the value of a float parameter.</para>
		/// </summary>
		/// <param name="name">The name of the parameter.</param>
		/// <param name="id">The id of the parameter. The id is generated using Animator::StringToHash.</param>
		// Token: 0x06001789 RID: 6025
		float GetFloat(int id);

		/// <summary>
		///   <para>Sets the value of a float parameter.</para>
		/// </summary>
		/// <param name="name">The name of the parameter.</param>
		/// <param name="value">The new value for the parameter.</param>
		/// <param name="id">The id of the parameter. The id is generated using Animator::StringToHash.</param>
		// Token: 0x0600178A RID: 6026
		void SetFloat(string name, float value);

		/// <summary>
		///   <para>Sets the value of a float parameter.</para>
		/// </summary>
		/// <param name="name">The name of the parameter.</param>
		/// <param name="value">The new value for the parameter.</param>
		/// <param name="id">The id of the parameter. The id is generated using Animator::StringToHash.</param>
		// Token: 0x0600178B RID: 6027
		void SetFloat(int id, float value);

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.GetBool.</para>
		/// </summary>
		/// <param name="name">The name of the parameter.</param>
		/// <param name="id">The id of the parameter. The id is generated using Animator::StringToHash.</param>
		// Token: 0x0600178C RID: 6028
		bool GetBool(string name);

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.GetBool.</para>
		/// </summary>
		/// <param name="name">The name of the parameter.</param>
		/// <param name="id">The id of the parameter. The id is generated using Animator::StringToHash.</param>
		// Token: 0x0600178D RID: 6029
		bool GetBool(int id);

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.SetBool.</para>
		/// </summary>
		/// <param name="name">The name of the parameter.</param>
		/// <param name="value">The new value for the parameter.</param>
		/// <param name="id">The id of the parameter. The id is generated using Animator::StringToHash.</param>
		// Token: 0x0600178E RID: 6030
		void SetBool(string name, bool value);

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.SetBool.</para>
		/// </summary>
		/// <param name="name">The name of the parameter.</param>
		/// <param name="value">The new value for the parameter.</param>
		/// <param name="id">The id of the parameter. The id is generated using Animator::StringToHash.</param>
		// Token: 0x0600178F RID: 6031
		void SetBool(int id, bool value);

		/// <summary>
		///   <para>Gets the value of an integer parameter.</para>
		/// </summary>
		/// <param name="name">The name of the parameter.</param>
		/// <param name="id">The id of the parameter. The id is generated using Animator::StringToHash.</param>
		// Token: 0x06001790 RID: 6032
		int GetInteger(string name);

		/// <summary>
		///   <para>Gets the value of an integer parameter.</para>
		/// </summary>
		/// <param name="name">The name of the parameter.</param>
		/// <param name="id">The id of the parameter. The id is generated using Animator::StringToHash.</param>
		// Token: 0x06001791 RID: 6033
		int GetInteger(int id);

		/// <summary>
		///   <para>Sets the value of an integer parameter.</para>
		/// </summary>
		/// <param name="name">The name of the parameter.</param>
		/// <param name="value">The new value for the parameter.</param>
		/// <param name="id">The id of the parameter. The id is generated using Animator::StringToHash.</param>
		// Token: 0x06001792 RID: 6034
		void SetInteger(string name, int value);

		/// <summary>
		///   <para>Sets the value of an integer parameter.</para>
		/// </summary>
		/// <param name="name">The name of the parameter.</param>
		/// <param name="value">The new value for the parameter.</param>
		/// <param name="id">The id of the parameter. The id is generated using Animator::StringToHash.</param>
		// Token: 0x06001793 RID: 6035
		void SetInteger(int id, int value);

		/// <summary>
		///   <para>Sets a trigger parameter to active.
		/// A trigger parameter is a bool parameter that gets reset to false when it has been used in a transition. For state machines with multiple layers, the trigger will only get reset once all layers have been evaluated, so that the layers can synchronize their transitions on the same parameter.</para>
		/// </summary>
		/// <param name="name">The name of the parameter.</param>
		/// <param name="id">The id of the parameter. The id is generated using Animator::StringToHash.</param>
		// Token: 0x06001794 RID: 6036
		void SetTrigger(string name);

		/// <summary>
		///   <para>Sets a trigger parameter to active.
		/// A trigger parameter is a bool parameter that gets reset to false when it has been used in a transition. For state machines with multiple layers, the trigger will only get reset once all layers have been evaluated, so that the layers can synchronize their transitions on the same parameter.</para>
		/// </summary>
		/// <param name="name">The name of the parameter.</param>
		/// <param name="id">The id of the parameter. The id is generated using Animator::StringToHash.</param>
		// Token: 0x06001795 RID: 6037
		void SetTrigger(int id);

		/// <summary>
		///   <para>Resets the trigger parameter to false.</para>
		/// </summary>
		/// <param name="name">The name of the parameter.</param>
		/// <param name="id">The id of the parameter. The id is generated using Animator::StringToHash.</param>
		// Token: 0x06001796 RID: 6038
		void ResetTrigger(string name);

		/// <summary>
		///   <para>Resets the trigger parameter to false.</para>
		/// </summary>
		/// <param name="name">The name of the parameter.</param>
		/// <param name="id">The id of the parameter. The id is generated using Animator::StringToHash.</param>
		// Token: 0x06001797 RID: 6039
		void ResetTrigger(int id);

		/// <summary>
		///   <para>Returns true if a parameter is controlled by an additional curve on an animation.</para>
		/// </summary>
		/// <param name="name">The name of the parameter.</param>
		/// <param name="id">The id of the parameter. The id is generated using Animator::StringToHash.</param>
		// Token: 0x06001798 RID: 6040
		bool IsParameterControlledByCurve(string name);

		/// <summary>
		///   <para>Returns true if a parameter is controlled by an additional curve on an animation.</para>
		/// </summary>
		/// <param name="name">The name of the parameter.</param>
		/// <param name="id">The id of the parameter. The id is generated using Animator::StringToHash.</param>
		// Token: 0x06001799 RID: 6041
		bool IsParameterControlledByCurve(int id);

		/// <summary>
		///   <para>The AnimatorController layer count.</para>
		/// </summary>
		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x0600179A RID: 6042
		int layerCount { get; }

		/// <summary>
		///   <para>Gets name of the layer.</para>
		/// </summary>
		/// <param name="layerIndex">The layer's index.</param>
		// Token: 0x0600179B RID: 6043
		string GetLayerName(int layerIndex);

		/// <summary>
		///   <para>Gets the index of the layer with specified name.</para>
		/// </summary>
		/// <param name="layerName">The layer's name.</param>
		// Token: 0x0600179C RID: 6044
		int GetLayerIndex(string layerName);

		/// <summary>
		///   <para>Gets the layer's current weight.</para>
		/// </summary>
		/// <param name="layerIndex">The layer's index.</param>
		// Token: 0x0600179D RID: 6045
		float GetLayerWeight(int layerIndex);

		/// <summary>
		///   <para>Sets the layer's current weight.</para>
		/// </summary>
		/// <param name="layerIndex">The layer's index.</param>
		/// <param name="weight">The weight of the layer.</param>
		// Token: 0x0600179E RID: 6046
		void SetLayerWeight(int layerIndex, float weight);

		/// <summary>
		///   <para>Gets the current State information on a specified AnimatorController layer.</para>
		/// </summary>
		/// <param name="layerIndex">The layer's index.</param>
		// Token: 0x0600179F RID: 6047
		AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex);

		/// <summary>
		///   <para>Gets the next State information on a specified AnimatorController layer.</para>
		/// </summary>
		/// <param name="layerIndex">The layer's index.</param>
		// Token: 0x060017A0 RID: 6048
		AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex);

		/// <summary>
		///   <para>Gets the Transition information on a specified AnimatorController layer.</para>
		/// </summary>
		/// <param name="layerIndex">The layer's index.</param>
		// Token: 0x060017A1 RID: 6049
		AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex);

		/// <summary>
		///   <para>Gets the list of AnimatorClipInfo currently played by the current state.</para>
		/// </summary>
		/// <param name="layerIndex">The layer's index.</param>
		// Token: 0x060017A2 RID: 6050
		AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex);

		/// <summary>
		///   <para>Gets the list of AnimatorClipInfo currently played by the next state.</para>
		/// </summary>
		/// <param name="layerIndex">The layer's index.</param>
		// Token: 0x060017A3 RID: 6051
		AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex);

		/// <summary>
		///   <para>Is the specified AnimatorController layer in a transition.</para>
		/// </summary>
		/// <param name="layerIndex">The layer's index.</param>
		// Token: 0x060017A4 RID: 6052
		bool IsInTransition(int layerIndex);

		/// <summary>
		///   <para>The number of AnimatorControllerParameters used by the AnimatorController.</para>
		/// </summary>
		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x060017A5 RID: 6053
		int parameterCount { get; }

		/// <summary>
		///   <para>Read only access to the AnimatorControllerParameters used by the animator.</para>
		/// </summary>
		/// <param name="index">The index of the parameter.</param>
		// Token: 0x060017A6 RID: 6054
		AnimatorControllerParameter GetParameter(int index);

		/// <summary>
		///   <para>Same as IAnimatorControllerPlayable.CrossFade, but the duration and offset in the target state are in fixed time.</para>
		/// </summary>
		/// <param name="stateName">The name of the destination state.</param>
		/// <param name="transitionDuration">The duration of the transition. Value is in seconds.</param>
		/// <param name="layer">Layer index containing the destination state. If no layer is specified or layer is -1, the first state that is found with the given name or hash will be played.</param>
		/// <param name="fixedTime">Start time of the current destination state. Value is in seconds. If no explicit fixedTime is specified or fixedTime value is float.NegativeInfinity, the state will either be played from the start if it's not already playing, or will continue playing from its current time and no transition will happen.</param>
		/// <param name="stateNameHash">The AnimatorState fullPathHash, nameHash or shortNameHash to play. Passing 0 will transition to self.</param>
		// Token: 0x060017A7 RID: 6055
		void CrossFadeInFixedTime(string stateName, float transitionDuration, int layer, float fixedTime);

		/// <summary>
		///   <para>Same as IAnimatorControllerPlayable.CrossFade, but the duration and offset in the target state are in fixed time.</para>
		/// </summary>
		/// <param name="stateName">The name of the destination state.</param>
		/// <param name="transitionDuration">The duration of the transition. Value is in seconds.</param>
		/// <param name="layer">Layer index containing the destination state. If no layer is specified or layer is -1, the first state that is found with the given name or hash will be played.</param>
		/// <param name="fixedTime">Start time of the current destination state. Value is in seconds. If no explicit fixedTime is specified or fixedTime value is float.NegativeInfinity, the state will either be played from the start if it's not already playing, or will continue playing from its current time and no transition will happen.</param>
		/// <param name="stateNameHash">The AnimatorState fullPathHash, nameHash or shortNameHash to play. Passing 0 will transition to self.</param>
		// Token: 0x060017A8 RID: 6056
		void CrossFadeInFixedTime(int stateNameHash, float transitionDuration, int layer, float fixedTime);

		/// <summary>
		///   <para>Creates a dynamic transition between the current state and the destination state.</para>
		/// </summary>
		/// <param name="stateName">The name of the destination state.</param>
		/// <param name="transitionDuration">The duration of the transition. Value is in source state normalized time.</param>
		/// <param name="layer">Layer index containing the destination state. If no layer is specified or layer is -1, the first state that is found with the given name or hash will be played.</param>
		/// <param name="normalizedTime">Start time of the current destination state. Value is in source state normalized time, should be between 0 and 1.  If no explicit normalizedTime is specified or normalizedTime value is float.NegativeInfinity, the state will either be played from the start if it's not already playing, or will continue playing from its current time and no transition will happen.</param>
		/// <param name="stateNameHash">The AnimatorState fullPathHash, nameHash or shortNameHash to play. Passing 0 will transition to self.</param>
		// Token: 0x060017A9 RID: 6057
		void CrossFade(string stateName, float transitionDuration, int layer, float normalizedTime);

		/// <summary>
		///   <para>Creates a dynamic transition between the current state and the destination state.</para>
		/// </summary>
		/// <param name="stateName">The name of the destination state.</param>
		/// <param name="transitionDuration">The duration of the transition. Value is in source state normalized time.</param>
		/// <param name="layer">Layer index containing the destination state. If no layer is specified or layer is -1, the first state that is found with the given name or hash will be played.</param>
		/// <param name="normalizedTime">Start time of the current destination state. Value is in source state normalized time, should be between 0 and 1.  If no explicit normalizedTime is specified or normalizedTime value is float.NegativeInfinity, the state will either be played from the start if it's not already playing, or will continue playing from its current time and no transition will happen.</param>
		/// <param name="stateNameHash">The AnimatorState fullPathHash, nameHash or shortNameHash to play. Passing 0 will transition to self.</param>
		// Token: 0x060017AA RID: 6058
		void CrossFade(int stateNameHash, float transitionDuration, int layer, float normalizedTime);

		/// <summary>
		///   <para>Same as IAnimatorControllerPlayable.Play, but the offset in the target state is in fixed time.</para>
		/// </summary>
		/// <param name="stateName">The name of the state to play.</param>
		/// <param name="layer">Layer index containing the destination state. If no layer is specified or layer is -1, the first state that is found with the given name or hash will be played.</param>
		/// <param name="fixedTime">Start time of the current destination state. Value is in seconds. If no explicit fixedTime is specified or fixedTime value is float.NegativeInfinity, the state will either be played from the start if it's not already playing, or will continue playing from its current time.</param>
		/// <param name="stateNameHash">The AnimatorState fullPathHash, nameHash or shortNameHash to play. Passing 0 will transition to self.</param>
		// Token: 0x060017AB RID: 6059
		void PlayInFixedTime(string stateName, int layer, float fixedTime);

		/// <summary>
		///   <para>Same as IAnimatorControllerPlayable.Play, but the offset in the target state is in fixed time.</para>
		/// </summary>
		/// <param name="stateName">The name of the state to play.</param>
		/// <param name="layer">Layer index containing the destination state. If no layer is specified or layer is -1, the first state that is found with the given name or hash will be played.</param>
		/// <param name="fixedTime">Start time of the current destination state. Value is in seconds. If no explicit fixedTime is specified or fixedTime value is float.NegativeInfinity, the state will either be played from the start if it's not already playing, or will continue playing from its current time.</param>
		/// <param name="stateNameHash">The AnimatorState fullPathHash, nameHash or shortNameHash to play. Passing 0 will transition to self.</param>
		// Token: 0x060017AC RID: 6060
		void PlayInFixedTime(int stateNameHash, int layer, float fixedTime);

		/// <summary>
		///   <para>Plays a state.</para>
		/// </summary>
		/// <param name="stateName">The name of the state to play.</param>
		/// <param name="layer">Layer index containing the destination state. If no layer is specified or layer is -1, the first state that is found with the given name or hash will be played.</param>
		/// <param name="normalizedTime">Start time of the current destination state. Value is in normalized time. If no explicit normalizedTime is specified or value is float.NegativeInfinity, the state will either be played from the start if it's not already playing, or will continue playing from its current time.</param>
		/// <param name="stateNameHash">The AnimatorState fullPathHash, nameHash or shortNameHash to play. Passing 0 will transition to self.</param>
		// Token: 0x060017AD RID: 6061
		void Play(string stateName, int layer, float normalizedTime);

		/// <summary>
		///   <para>Plays a state.</para>
		/// </summary>
		/// <param name="stateName">The name of the state to play.</param>
		/// <param name="layer">Layer index containing the destination state. If no layer is specified or layer is -1, the first state that is found with the given name or hash will be played.</param>
		/// <param name="normalizedTime">Start time of the current destination state. Value is in normalized time. If no explicit normalizedTime is specified or value is float.NegativeInfinity, the state will either be played from the start if it's not already playing, or will continue playing from its current time.</param>
		/// <param name="stateNameHash">The AnimatorState fullPathHash, nameHash or shortNameHash to play. Passing 0 will transition to self.</param>
		// Token: 0x060017AE RID: 6062
		void Play(int stateNameHash, int layer, float normalizedTime);

		/// <summary>
		///   <para>Returns true if the AnimatorState is present in the Animator's controller.</para>
		/// </summary>
		/// <param name="layerIndex">The layer's index.</param>
		/// <param name="stateID">The AnimatorState fullPathHash, nameHash or shortNameHash.</param>
		// Token: 0x060017AF RID: 6063
		bool HasState(int layerIndex, int stateID);
	}
}
