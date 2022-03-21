using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using LitJson;

[Serializable]
public class UserVarItemComponent : ItemComponent
{
	public Dictionary<int, ObscuredLong> values;

	public override ItemComponent ParseJsonOverride(JsonData jsonData)
	{
		return null;
	}

	protected override JsonData ToJsonOverride()
	{
		return null;
	}
}
