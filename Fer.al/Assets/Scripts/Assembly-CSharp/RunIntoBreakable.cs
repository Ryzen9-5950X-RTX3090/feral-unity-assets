using UnityEngine;

public class RunIntoBreakable : MonoBehaviour
{
	[SerializeField]
	private GameObject mesh;

	[SerializeField]
	private GameObject fx;

	[SerializeField]
	private Interaction interaction;

	private bool done;

	private ActorBase actorBase;

	private void OnTriggerEnter(Collider other)
	{
	}
}
