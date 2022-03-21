using UnityAtoms;
using UnityEngine;

[CreateAssetMenu]
public class Match3TileType : ScriptableObject
{
	public int typeValueOnServer;

	public bool isMatchable;

	public Color tileBaseColor;

	[Header("Sprites/Animations")]
	public Sprite sprite;

	public AnimationClip boosterFlyerVertical;

	public AnimationClip boosterFlyerHorizontal;

	public AnimationClip boosterTwinTrouble1;

	public AnimationClip boosterTwinTrouble2;

	public AnimationClip boosterPeacock;

	public Sprite blockerEgg;

	[Header("Effects")]
	public GameObject standardRemovalFxPrefab;

	public GameObject twinTroubleremovalFxPrefab;

	public GameObject doubleTwinTroubleremovalFxPrefab;

	public GameObject FlyerVerticalFxPrefab;

	public GameObject FlyerHorizontalFxPrefab;

	public GameObject twinTroubleSpawnInFxPrefab;

	public GameObject FlyerSpawnInFxPrefab;

	public GameObject boosterSpawnInFxPrefab;

	public GameObject boosterActivateFxPrefab;

	public GameObject eggShineFxPrefab;

	public GameObject eggHatchFxPrefab;

	public GameObject clearedByPeacockFxPrefab;

	[Header("Events")]
	public VoidEvent tileTypeAddedEvent;

	public VoidEvent boosterFlyerAddedEvent;

	public VoidEvent boosterTwinTroubleAddedEvent;

	public VoidEvent blockerAddedEvent;

	public VoidEvent tileTypeRemovedEvent;

	public VoidEvent boosterFlyerRemovedEvent;

	public VoidEvent boosterTwinTroubleRemovedEvent;

	public VoidEvent blockerRemovedEvent;

	public VoidEvent clearedWithPeacockEvent;

	[Header("Availability")]
	public int firstAvailableLevelNumber;
}
