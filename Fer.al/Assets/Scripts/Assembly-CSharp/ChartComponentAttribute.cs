using System;

[AttributeUsage(AttributeTargets.Class)]
public class ChartComponentAttribute : Attribute
{
	public string label;

	public ChartComponentAttribute(string inLabel)
	{
	}
}
