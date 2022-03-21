using System;
using LitJson;

[Serializable]
public class SanctuaryInfo : BaseInfo
{
	public class PlacementInfo
	{
		public Inventory placement;

		public PlacementInfo(JsonData jsonData)
		{
		}
	}

	public string houseDefID;

	public string islandDefID;

	public string houseDefId;

	public string islandDefId;

	public string houseInvId;

	public string islandInvId;

	public string classInvId;

	[NonSerialized]
	public PlacementInfo placementInfo;
}
