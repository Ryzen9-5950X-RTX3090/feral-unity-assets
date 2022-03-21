using UnityEngine;

public class ObjectLauncher : MonoBehaviour
{
	public enum LaunchDirection
	{
		Forward,
		Backward,
		Left,
		Right,
		None
	}

	public GameObject objectToLaunch;

	public Transform launchParent;

	public GameObject copyMaterialFromObject;

	public LaunchDirection launchDirection;

	public Vector3 additiveLaunchDirection;

	public float launchForce;

	public void Launch()
	{
	}
}
