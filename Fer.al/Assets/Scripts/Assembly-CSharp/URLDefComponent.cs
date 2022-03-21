using System;

[Serializable]
[ChartComponent("URL")]
public class URLDefComponent : DefComponent
{
	[ChartString]
	public string dev;

	[ChartString]
	public string stage;

	[ChartString]
	public string prod;
}
