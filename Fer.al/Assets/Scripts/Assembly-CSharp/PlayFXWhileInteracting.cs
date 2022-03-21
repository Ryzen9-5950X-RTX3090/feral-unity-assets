using UnityEngine;

public class PlayFXWhileInteracting : MonoBehaviour
{
	[SerializeField]
	private Interactable _interactable;

	[SerializeField]
	private ParticleSystem _fx;

	[SerializeField]
	private bool _loopWhileInteracting;

	private bool _started;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnInteractableInteracted(InteractableInteractedMessage inMessage)
	{
	}

	private void Update()
	{
	}
}
