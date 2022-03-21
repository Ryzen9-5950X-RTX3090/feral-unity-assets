using System;
using LitJson;

[Serializable]
public abstract class SingleStringItemComponentBase : ItemComponent
{
	public string value;

	public abstract string JsonKey { get; }

	public override ItemComponent ParseJsonOverride(JsonData jsonData)
	{
		return null;
	}
}
