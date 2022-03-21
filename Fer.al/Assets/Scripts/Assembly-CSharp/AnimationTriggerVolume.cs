using UnityEngine;

[RequireComponent(typeof(Collider))]
public class AnimationTriggerVolume : ManagedBehaviour
{
	[SerializeField]
	private Animator _animator;

	[SerializeField]
	private string _triggerEnterAnimVar;

	[SerializeField]
	private string _triggerExitAnimVar;

	private void OnTriggerEnter(Collider inCollider)
	{
	}

	private void OnTriggerExit(Collider inCollider)
	{
	}

	private void TriggerEnter()
	{
	}

	private void TriggerExit()
	{
	}
}
