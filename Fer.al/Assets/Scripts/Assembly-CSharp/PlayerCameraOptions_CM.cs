using System;

[Serializable]
public class PlayerCameraOptions_CM
{
	public string virtualCameraID;

	public float zoomMultiply;

	public float minZoomLevel;

	public float maxZoomLevel;

	public float reduceZoomNearColliderDistance;

	public float yaw;

	public float tilt;

	public float distance;

	public float height;

	public float keyboardHeight;

	public float minZoomTiltOffset;

	public float maxZoomTiltOffset;

	[NonSerialized]
	public float strength;

	public static bool Combine(PlayerCameraOptions_CM outOptions, PlayerCameraOptions_CM inOptions1, PlayerCameraOptions_CM inOptions2)
	{
		return default(bool);
	}
}
