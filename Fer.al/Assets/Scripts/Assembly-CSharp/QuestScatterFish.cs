using UnityEngine;

public class QuestScatterFish : ManagedBehaviour
{
	[SerializeField]
	private float _moveSpeed;

	[SerializeField]
	private float _turnSpeed;

	[SerializeField]
	private float _spawnRadius;

	[SerializeField]
	private float _stoppingDistance;

	[SerializeField]
	[Tooltip("How close the player can get before scattering")]
	private float _scatterDistance;

	[SerializeField]
	private float _burstMultiplier;

	private InteractableDefComponent _interactableDefComponent;

	private bool _moving;

	private bool _rotating;

	private bool _finished;

	private float _dTime;

	private float _burst;

	private float _scatterAngle;

	private float _serverAllowedRange;

	private Vector3 _moveDir;

	private Vector3 _moveTo;

	private Transform _fishMover;

	private Transform _playerTrans;

	private Transform _avoid1;

	private Transform _avoid2;

	private Animator _animator;

	private Interactable _interactable;

	public InteractableDefComponent interactableDefComponent
	{
		get
		{
			return null;
		}
	}

	public override void MStartAfterLocal()
	{
	}

	public override void MOnDestroy()
	{
	}

	public override void MUpdate()
	{
	}

	private void OnInteractableInteracted(InteractableInteractedMessage inMessage)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
