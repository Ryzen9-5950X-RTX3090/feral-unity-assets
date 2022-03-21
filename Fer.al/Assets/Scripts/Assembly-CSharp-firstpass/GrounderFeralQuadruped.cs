using RootMotion.FinalIK;
using UnityEngine;

public class GrounderFeralQuadruped : Grounder
{
	public IK[] legs;

	public Transform hierarchyRootBone;

	public Transform rootBone;

	public Transform collarBone;

	public Transform pelvisBone;

	[Tooltip("The weight of rotating the character root to the ground normal (range: 0 - 1).")]
	[Range(0f, 1f)]
	public float rootRotationWeight;

	[Tooltip("The speed of rotating the character root to the ground normal (range: 0 - inf).")]
	public float rootRotationSpeed;

	[Tooltip("The maximum angle of root rotation (range: 0 - 90).")]
	public float maxRootRotationAngle;

	private Transform[] feet;

	private Quaternion[] footRotations;

	private Vector3 animatedPelvisLocalPosition;

	private Vector3 solvedPelvisLocalPosition;

	private int solvedFeet;

	private bool solved;

	private float lastWeight;

	private float _currentPitch;

	private float _currentOffset;

	public float maxBodyOffset;

	[ContextMenu("User Manual")]
	protected override void OpenUserManual()
	{
	}

	[ContextMenu("Scrpt Reference")]
	protected override void OpenScriptReference()
	{
	}

	public override void ResetPosition()
	{
	}

	public void LateUpdate()
	{
	}

	private bool IsReadyToInitiate()
	{
		return default(bool);
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	public void OnDrawGizmos()
	{
	}

	private void Initiate()
	{
	}

	private void OnSolverUpdate()
	{
	}

	private void SetLegIK(int index)
	{
	}

	private void OnPostSolverUpdate()
	{
	}

	private void OnDestroy()
	{
	}
}
