using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class AudioStateMachineBehaviour : StateMachineBehaviour
{
	private List<Animator> _animators;

	private List<FeralAnimationEvent> _feralAnimationEvents;

	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
	{
	}

	public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller)
	{
	}

	public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
	{
	}

	private void AddFeralAnimationEvent(Animator animator)
	{
	}

	private void PrepareAudioExit()
	{
	}
}
