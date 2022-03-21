using UnityEngine;
using UnityEngine.Events;

public class InRangeToLocalActor : ManagedBehaviour
{
	public enum EState
	{
		OUTOFRANGE,
		INRANGE
	}

	[SerializeField]
	private float _range;

	private Transform _triggerer;

	[SerializeField]
	private UnityEvent OnOutOfRange;

	[SerializeField]
	private UnityEvent OnInRange;

	private float? _rangeSq;

	private EState _desiredState;

	private EState _currentState;

	public Transform triggerer
	{
		get
		{
			return null;
		}
	}

	private float rangeSq
	{
		get
		{
			return default(float);
		}
	}

	private Vector3 _relativePosition
	{
		get
		{
			return default(Vector3);
		}
	}

	public override void MUpdate()
	{
	}

	private void InRange()
	{
	}

	private void OutOfRange()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
