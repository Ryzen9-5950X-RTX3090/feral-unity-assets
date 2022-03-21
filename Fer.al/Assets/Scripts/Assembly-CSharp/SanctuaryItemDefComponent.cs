using System.Collections.Generic;
using UnityEngine;

[ChartComponent("Sanctuary Item")]
public class SanctuaryItemDefComponent : DefComponent, IItemDefComponent
{
	[ChartBool]
	public bool isWallObject;

	[ChartBool]
	public bool collideWithPlayer;

	[ChartBool]
	public bool isStatic;

	[ChartBool]
	public bool canStack;

	[ChartBool]
	public bool canStackOn;

	[ChartEnum]
	public ESanctuaryItemType objectType;

	[ChartEnum]
	public ESanctuaryStateInteract stateInteractType;

	[ChartBool]
	public bool isPreplacedForNewAccounts;

	[ChartVector3]
	public Vector3 preplacedPosition;

	[ChartVector3]
	public Vector3 preplacedRotation;

	[ChartList]
	public List<SanctuaryItemState> availableStates;

	public void OnClientOnlyItemCreated(Item item)
	{
	}
}
