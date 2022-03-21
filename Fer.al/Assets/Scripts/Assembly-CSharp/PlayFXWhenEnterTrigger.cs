using UnityEngine;

public class PlayFXWhenEnterTrigger : MonoBehaviour
{
	[SerializeField]
	private Collider trigger;

	[SerializeField]
	private ParticleSystem fx;

	private void OnTriggerEnter(Collider other)
	{
	}
}
