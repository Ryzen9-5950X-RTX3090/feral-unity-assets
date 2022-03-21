using System;
using LitJson;

[Serializable]
public abstract class SingleUIntItemComponentBase : ItemComponent
{
	public uint value;

	public abstract string JsonKey { get; }

	public override ItemComponent ParseJsonOverride(JsonData jsonData)
	{
		return null;
	}

	protected override JsonData ToJsonOverride()
	{
		return null;
	}
}
