using System;
using LitJson;

[Serializable]
public class TwiggleItemComponent : ItemComponent
{
	public long endWorkTime;

	public int workType;

	public JsonData workParams;

	public override ItemComponent ParseJsonOverride(JsonData jsonData)
	{
		return null;
	}

	protected override JsonData ToJsonOverride()
	{
		return null;
	}
}
