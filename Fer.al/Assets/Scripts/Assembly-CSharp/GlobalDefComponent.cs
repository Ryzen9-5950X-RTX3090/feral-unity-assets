using System;

[Serializable]
[ChartComponent("Global")]
public class GlobalDefComponent : DefComponent
{
	[ChartInt]
	public int intValue;

	[ChartFloat]
	public float floatValue;

	[ChartString]
	public string stringValue;

	[ChartBool]
	public bool boolValue;
}
