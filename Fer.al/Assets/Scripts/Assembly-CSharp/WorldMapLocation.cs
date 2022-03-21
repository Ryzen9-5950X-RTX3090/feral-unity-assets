using UnityEngine;

public class WorldMapLocation : ManagedBehaviour
{
	public string uniqueMapId;

	public MinimapManager.EBlipType worldBlipType;

	[Header("World Map Display Name")]
	[RootSelector("Localization", "LocalizationChartData", false, false)]
	public string localization;

	public override void MOnEnable()
	{
	}

	public void GenerateMapId()
	{
	}

	public static string CreateNewGuid()
	{
		return null;
	}
}
