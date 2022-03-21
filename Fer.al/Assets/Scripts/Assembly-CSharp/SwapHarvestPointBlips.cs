using System.Collections.Generic;

public class SwapHarvestPointBlips : MonoBehaviour
{
	[RootSelector("Interactable DefId", "InteractableChartData", false, false)]
	public string[] interactableDefIds;

	private List<MinimapBlip> harvestPointBlips;

	public void SwapToMainQuestBlips()
	{
	}

	public void SwapToNormalBlips()
	{
	}

	private void Swap(bool questMode)
	{
	}

	private void FindHarvestPointBlips()
	{
	}
}
