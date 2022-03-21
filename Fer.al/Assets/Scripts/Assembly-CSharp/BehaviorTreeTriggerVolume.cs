using NodeCanvas.Framework;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class BehaviorTreeTriggerVolume : ManagedBehaviour
{
	public enum ETriggerType
	{
		NONE,
		ENTER,
		EXIT
	}

	[SerializeField]
	private ETriggerType _triggerType;

	[SerializeField]
	private GraphOwner _graph;

	private bool _triggerHitThisFrame;

	private bool triggerHitThisFrame
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	private void OnTriggerEnter(Collider inCollider)
	{
	}

	private void OnTriggerExit(Collider inCollider)
	{
	}
}
