using System.Collections.Generic;
using UnityEngine;

public class SanctuaryGreenHouseExterior : ManagedBehaviour
{
	[RootSelector("Greenhouse", "CraftableItemChartData", false, false)]
	public string greenhouseDefId;

	public Transform spawn;

	public List<Transform> enterVolumes;

	public List<Transform> doors;

	public override void MStart()
	{
	}

	public void TeleportToSpawn()
	{
	}

	private void SpawnGreenhouseDoor()
	{
	}
}
