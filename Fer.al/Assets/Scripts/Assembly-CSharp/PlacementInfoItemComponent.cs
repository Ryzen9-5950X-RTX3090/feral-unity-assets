using System;
using LitJson;

[Serializable]
public class PlacementInfoItemComponent : ItemComponent
{
	public Inventory placedItems;

	public override ItemComponent ParseJsonOverride(JsonData jsonData)
	{
		return null;
	}

	protected override JsonData ToJsonOverride()
	{
		return null;
	}
}
