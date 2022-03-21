using UnityEngine;

public class WayfarerIntroCameraControl : MonoBehaviour
{
	[SerializeField]
	private Transform cameraTarget;

	[SerializeField]
	private Vector2 offsetMultiplier;

	[SerializeField]
	private Vector2 maxOffset;

	[SerializeField]
	private float smoothTime;

	private bool rotating;

	private bool previousRotating;

	private Vector2 startRotateVector;

	private Vector2 previousRotateVector;

	private Vector2 currentVelocity;

	private void Update()
	{
	}
}
