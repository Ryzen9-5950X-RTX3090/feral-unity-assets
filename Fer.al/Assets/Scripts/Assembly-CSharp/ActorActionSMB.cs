using UnityEngine;

public class ActorActionSMB : StateMachineBehaviour
{
	public string stateID;

	public ActorActionType actionType;

	public bool forceThirdPersonCamera;

	public bool dontAllowMovement;

	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
	{
	}

	public override void OnStateMachineExit(Animator animator, int stateMachinePathHash)
	{
	}
}
