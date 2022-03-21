using UnityEngine;

[ChartComponent("Interactable")]
public class InteractableDefComponent : DefComponent
{
	[ChartDef("HarvestPoint", new string[] { })]
	public string harvestPointRef;

	[ChartDef("Loot", new string[] { })]
	public string lootPointRef;

	[ChartDef("Inspiration", new string[] { })]
	public string inspirationRef;

	[ChartDef("Image", new string[] { })]
	public string interactImageRef;

	[ChartDef("Localization", new string[] { })]
	public string localizedTooltipID;

	[ChartFloat]
	public float interactTimer;

	[ChartFloat]
	public float interactRange;

	[ChartFloat]
	public float serverAllowedInteractRange;

	[ChartVector3]
	public Vector3 interactImageOffset;

	[ChartVector3]
	public Vector3 interactImageOffsetFirstPerson;
}
