using UnityEngine;

[CreateAssetMenu]
public class SpellBoltSettings : ScriptableObject
{
	[Tooltip("Offset from the player to place the bolt display.")]
	public Vector3 displayOffset;

	[Tooltip("Offset to attach to player in first person mode")]
	public Vector3 firstPersonOffset;

	[Tooltip("How large a circle the rotating bolts inscribe.")]
	public float boltDisplayRadius;

	[Tooltip("How long does it take bolts to move to new positions when one is fired.")]
	public float boltDisplayUpdateTime;

	[Tooltip("How fast should bolts rotate above the player.")]
	public float boltDisplayRotateSpeed;

	[Tooltip("How far does a fired bolt move.")]
	public float boltRange;

	[Tooltip("How fast does a fired bolt move.")]
	public float boltMoveSpeed;

	[Tooltip("Can bolts home in on targets.")]
	public bool canHome;

	[Tooltip("How strongly does a bolt home onto a target in range. Ignored if canHome = false")]
	[Range(0f, 1f)]
	public float boltHomingStrength;
}
