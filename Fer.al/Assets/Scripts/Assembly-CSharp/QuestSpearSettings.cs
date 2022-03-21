using UnityEngine;

public class QuestSpearSettings : ScriptableObject
{
	[Tooltip("Heigh of the arch when returning to the player")]
	public float archeight;

	[Tooltip("Controls to smoothness of the arch when returning to the player")]
	public int shotArchPoints;

	[Tooltip("Offset to attach to player")]
	public Vector3 offset;

	[Tooltip("Offset to attach to player in first person mode")]
	public Vector3 firstPersonOffset;

	[Tooltip("Move speed - Lower values = faster")]
	public float moveSpeed;

	[Tooltip("How far in front of the player to move to when launched")]
	public float range;

	[Tooltip("How long to remain impaled on something before returning")]
	public float impaleWait;
}
