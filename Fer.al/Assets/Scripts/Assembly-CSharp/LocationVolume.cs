using UnityEngine;

public class LocationVolume : MonoBehaviour
{
	[RootSelector("Location Volume Def", "CraftableItemChartData", false, false)]
	public string locationVolumeDefId;

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
