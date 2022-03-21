using UnityEngine;

public class RiftDebris : ManagedBehaviour
{
	[SerializeField]
	private GameObject _debrisMesh;

	[SerializeField]
	private GameObject _destroyedDebrisMesh;

	[SerializeField]
	private FeralAudioInfo _destroyedAudio;

	[SerializeField]
	private float _bounceVelocity;

	private bool _isDestroyed;

	private Interactable _interactableComponent;

	public bool IsDestroyed
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public override void MStart()
	{
	}

	public override void MOnDestroy()
	{
	}

	private void OnRespawn()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
