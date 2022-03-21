using System;
using System.Collections.Generic;
using UnityEngine;

[ManagedBehaviourManager("QuestManager")]
public class NetworkedScene : ManagedBehaviour
{
	[Serializable]
	public class QuestTrackableItem
	{
		public NetworkedObjectInfo NetworkedVar;

		public QuestTrackableItemDetails questTrackableItemDetails;
	}

	[Serializable]
	public class QuestTrackableItemDetails
	{
		[HideInInspector]
		public string networkedVarUUID;

		[RootSelectorCompact("Craftable Item Chart ID", "CraftableItemChartData", null, false, false)]
		public string craftableItemChartID;

		[RootSelectorCompact("Harvest Point Chart ID", "HarvestPointChartData", null, false, false)]
		public string harvestPointChartID;

		public float harvestPointRespawnOverride;

		public int numRequired;
	}

	[Space]
	[Space(6f)]
	[RootSelectorCompact("Networked Objects Chart ID", "NetworkedObjectsChartData", null, false, false)]
	public string networkedObjectsChartID;

	public List<QuestTrackableItem> questTrackableItems;

	public NetworkedSceneGroupListObjects[] groupObjects;

	public override void MStart()
	{
	}
}
