using UnityEngine;

public class SMB_IdleBase : StateMachineBehaviour
{
	public float idleBreakMinTime;

	public float idleBreakMaxTime;

	public int idleAdditiveLayerIndex;

	public int moveAdditiveLayerIndex;

	private float timer;

	private ActorBase _cachedActor;

	private ActorBase GetActor(Animator animator)
	{
		return null;
	}

	private void SetIdleAdditiveLayerVisible(Animator animator, bool inVisible)
	{
	}

	private void SetMoveAdditiveLayerVisible(Animator animator, bool visible)
	{
	}

	private void ChooseIdleBreakTime()
	{
	}

	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}
}
