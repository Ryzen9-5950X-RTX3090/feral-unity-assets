using UnityEngine;

public class SocialExpanseDigSpotSettings : ScriptableObject
{
	[Tooltip("Offset from the avatar for the camera to move to when digging")]
	public Vector3 cameraOffset;

	[Tooltip("How far from the center of the dig spot will the avatar move to when digging")]
	public float digDistance;

	[Tooltip("Speed that the camera transitions to cameraOffset")]
	public float camMoveSpeed;

	[Tooltip("Seconds to take to align and move avater to the dig spot")]
	public float alignSpeed;
}
