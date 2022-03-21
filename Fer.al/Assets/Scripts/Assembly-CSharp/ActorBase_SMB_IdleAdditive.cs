using System.Collections.Generic;
using UnityEngine;

public class ActorBase_SMB_IdleAdditive : StateMachineBehaviour
{
	public enum IdleAdditiveState
	{
		BaseAdditive,
		LookLeftAdd,
		LookRightAdd,
		LookAroundAdd
	}

	public float minBaseTime;

	public float maxBaseTime;

	public int idleBaseLayerIndex;

	[EnumList(typeof(IdleAdditiveState), 0.35f)]
	public List<float> weights;

	private IdleAdditiveState _currentState;

	private float noAdditiveTimer;

	private const string baseIdleName = "Idle Base Add";

	private void OnEnable()
	{
	}

	private IdleAdditiveState ChooseNewState()
	{
		return default(IdleAdditiveState);
	}

	private void HandleStateSelection(Animator animator)
	{
	}

	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}
}
