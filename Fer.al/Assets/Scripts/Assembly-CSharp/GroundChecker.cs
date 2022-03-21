using UnityEngine;

public class GroundChecker : MonoBehaviour
{
	[Header("Controller Info")]
	public float controllerHeight;

	[Header("Results")]
	public float groundSlopeAngle;

	public Vector3 groundSlopeDir;

	public Vector3 groundSlopeFlatDir;

	[Header("Settings")]
	public bool showDebug;

	public LayerMask castingMask;

	public float startDistanceFromBottom;

	public float sphereCastRadius;

	public float sphereCastDistance;

	public float raycastLength;

	public Vector3 rayOriginOffset1;

	public Vector3 rayOriginOffset2;

	public void CheckGround()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
