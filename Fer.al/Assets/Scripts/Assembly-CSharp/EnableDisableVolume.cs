using UnityEngine;

public class EnableDisableVolume : ManagedBehaviour
{
	public enum EState
	{
		NONE,
		ENABLE,
		DISABLE,
		TOGGLE
	}

	[SerializeField]
	private EState _onEnter;

	[SerializeField]
	private EState _onExit;

	[SerializeField]
	private bool _localPlayerOnly;

	[SerializeField]
	private GameObject[] _objects;

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private void UpdateObjects(EState inState)
	{
	}
}
