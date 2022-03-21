using UnityEngine;

public class MouseLook : MonoBehaviour
{
	public enum RotationAxes
	{
		MouseXAndY,
		MouseX,
		MouseY
	}

	public RotationAxes axes;

	public float sensitivityX;

	public float sensitivityY;

	public float minimumX;

	public float maximumX;

	public float minimumY;

	public float maximumY;

	public float forwardSpeedScale;

	public float strafeSpeedScale;

	private float rotationX;

	private float rotationY;

	private bool look;

	private Quaternion originalRotation;

	private void Update()
	{
	}

	private void Start()
	{
	}

	public static float ClampAngle(float angle, float min, float max)
	{
		return default(float);
	}
}
