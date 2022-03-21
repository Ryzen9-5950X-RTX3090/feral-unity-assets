using System;

[Serializable]
[ChartComponent("NetworkedObjects")]
public class NetworkedObjectsDefComponent : DefComponent
{
	[ChartString]
	public string scriptJson;
}
