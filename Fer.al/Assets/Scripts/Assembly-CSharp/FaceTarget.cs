using UnityEngine;

public class FaceTarget : ManagedBehaviour
{
	private float _rotationSpeed;

	public Transform _headNode;

	private Transform _target;

	public Transform initialTarget;

	public Transform aradiaTarget;

	public Transform delilahTarget;

	public Transform wideCameraTarget;

	public Transform aradiaCameraTarget;

	public Transform delilahCameraTarget;

	private Quaternion _initialHeadRotation;

	private Quaternion _desiredHeadRotation;

	private float time;

	public Transform Target
	{
		set
		{
		}
	}

	public override void MStart()
	{
	}

	public override void MUpdate()
	{
	}

	public void LateUpdate()
	{
	}

	public void SetNewTarget(string newTarget)
	{
	}

	public void LookAtAradia()
	{
	}

	public void LookAtDelilah()
	{
	}

	public void LookAtWideCamera()
	{
	}

	public void LookAtAradiaCamera()
	{
	}

	public void LookAtDelilahCamera()
	{
	}
}
