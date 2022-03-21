using System;
using System.Collections.Generic;
using LitJson;

[Serializable]
public class HouseItemComponent : ItemComponent
{
	public string themeDefId;

	public int x;

	public int y;

	public int stage;

	public List<int> enlargedAreas;

	public List<RoomData> roomData;

	public int gridId;

	public override ItemComponent ParseJsonOverride(JsonData jsonData)
	{
		return null;
	}

	protected override JsonData ToJsonOverride()
	{
		return null;
	}
}
