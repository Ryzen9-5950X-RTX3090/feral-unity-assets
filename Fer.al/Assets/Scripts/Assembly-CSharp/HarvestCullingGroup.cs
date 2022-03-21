using UnityEngine;

[RequireComponent(typeof(Collider))]
public class HarvestCullingGroup : ManagedBehaviour
{
	[SerializeField]
	private bool _visibleOnEnter;

	[SerializeField]
	private bool _visibleOnExit;

	[SerializeField]
	private bool _onlyDisableRenderers;

	[SerializeField]
	private GameObject _gameObjectToCull;

	public override void MStart()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
