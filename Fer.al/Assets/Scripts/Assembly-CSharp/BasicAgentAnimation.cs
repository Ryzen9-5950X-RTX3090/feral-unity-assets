using UnityEngine;
using UnityEngine.AI;

public class BasicAgentAnimation : ManagedBehaviour
{
	[SerializeField]
	private RuntimeAnimatorController _controller;

	private NavMeshAgent _navMeshAgent;

	private Animator _animator;

	public override void MStart()
	{
	}

	private void LateUpdate()
	{
	}
}
