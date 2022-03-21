using UnityEngine;

public class SimpleTeleport : MonoBehaviour
{
	[SerializeField]
	[RootSelector("Level", "LevelChartData", false, false)]
	private string _levelDefId;

	private LevelDefComponent.WorldMapInfo _worldMapInfo;

	public void Teleport()
	{
	}
}
