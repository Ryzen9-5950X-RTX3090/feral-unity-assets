using System;

public class PlayerCameraOptions : MonoBehaviour
{
	public string optionsName;

	public float zoomMultiply;

	public float minZoomLevel;

	public float maxZoomLevel;

	public float reduceZoomNearColliderDistance;

	public float tilt;

	public float distance;

	public float height;

	public float keyboardHeight;

	public float minTilt;

	public float maxTilt;

	[NonSerialized]
	public float strength;

	public static bool Combine(PlayerCameraOptions outOptions, PlayerCameraOptions inOptions1, PlayerCameraOptions inOptions2)
	{
		return default(bool);
	}
}
