using System;
using CodeStage.AntiCheat.ObscuredTypes;
using LitJson;

[Serializable]
public abstract class SingleIntItemComponentBase : ItemComponent
{
	public ObscuredInt value;

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
