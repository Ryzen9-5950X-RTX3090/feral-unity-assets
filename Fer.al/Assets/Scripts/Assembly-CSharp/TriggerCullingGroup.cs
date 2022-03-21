using UnityEngine;

[RequireComponent(typeof(Collider))]
public class TriggerCullingGroup : ManagedBehaviour
{
	[SerializeField]
	private bool _visibleOnEnter;

	[SerializeField]
	private bool _visibleOnExit;

	[SerializeField]
	private bool _onlyDisableRenderers;

	[SerializeField]
	private GameObject _gameObjectToCull;

	private bool Visible
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

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private void SetVisible(bool inVisible)
	{
	}
}
