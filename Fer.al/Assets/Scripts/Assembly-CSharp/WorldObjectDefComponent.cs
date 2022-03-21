using System;

[Serializable]
[ChartComponent("World Object")]
public class WorldObjectDefComponent : DefComponent
{
	[ChartString]
	public string infoClassName;
}
