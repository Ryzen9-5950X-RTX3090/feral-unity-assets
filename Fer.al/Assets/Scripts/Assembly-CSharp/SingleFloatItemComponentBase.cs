using System;
using LitJson;

[Serializable]
public abstract class SingleFloatItemComponentBase : ItemComponent
{
	public float value;

	public abstract string JsonKey { get; }

	public override ItemComponent ParseJsonOverride(JsonData jsonData)
	{
		return null;
	}
}
